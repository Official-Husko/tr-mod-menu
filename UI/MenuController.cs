using BepInEx.Configuration;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace tr_mod_menu.UI;

internal class MenuController : MonoBehaviour
{
    private ConfigEntry<KeyCode> _toggleKey;
    private MenuWindow _window;
    private bool _isOpen;
    private CursorLockMode _savedLockState;
    private bool _savedCursorVisible;

    public static MenuController Create(ConfigFile config)
    {
        var root = new GameObject("TRModMenu_UIRoot");
        DontDestroyOnLoad(root);

        var canvas = root.AddComponent<Canvas>();
        canvas.renderMode = RenderMode.ScreenSpaceOverlay;
        canvas.sortingOrder = 30000; // draw above any game canvas regardless of its own sort order

        var scaler = root.AddComponent<CanvasScaler>();
        scaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;
        scaler.referenceResolution = new Vector2(1920f, 1080f);
        scaler.screenMatchMode = CanvasScaler.ScreenMatchMode.MatchWidthOrHeight;
        scaler.matchWidthOrHeight = 0.5f;

        root.AddComponent<GraphicRaycaster>();

        var controller = root.AddComponent<MenuController>();
        controller.Init(config, (RectTransform)root.transform);
        return controller;
    }

    private void Init(ConfigFile config, RectTransform canvasRoot)
    {
        _toggleKey = config.Bind("General", "MenuToggleKey", KeyCode.Insert, "Key to show/hide the mod menu.");

        EnsureEventSystem();

        _window = MenuWindow.Create(canvasRoot);
        _window.Close(instant: true);
    }

    // A second EventSystem is harmless (Unity no-ops any but the first), so this is a cheap
    // safety net in case our persistent one was destroyed across a scene transition.
    private static void EnsureEventSystem()
    {
        if (EventSystem.current != null)
            return;

        var go = new GameObject("TRModMenu_EventSystem");
        DontDestroyOnLoad(go);
        go.AddComponent<EventSystem>();
        go.AddComponent<StandaloneInputModule>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(_toggleKey.Value))
            Toggle();
    }

    private void Toggle()
    {
        EnsureEventSystem();

        if (_isOpen)
            CloseMenu();
        else
            OpenMenu();
    }

    private void OpenMenu()
    {
        _isOpen = true;
        _savedLockState = Cursor.lockState;
        _savedCursorVisible = Cursor.visible;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        _window.Open();
    }

    private void CloseMenu()
    {
        _isOpen = false;
        Cursor.lockState = _savedLockState;
        Cursor.visible = _savedCursorVisible;
        _window.Close();
    }
}
