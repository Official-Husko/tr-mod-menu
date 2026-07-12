using System.Collections;
using BepInEx.Configuration;
using tr_mod_menu.Cheats;
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
        DestroyExisting();

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
        var uiScale = config.Bind("General", "UIScale", 1f,
            new ConfigDescription("Scale of the mod menu window.", new AcceptableValueRange<float>(0.75f, 1.5f)));

        EnsureEventSystem();

        StartCoroutine(BuildAfterCompatibilityCheck(canvasRoot, uiScale));
    }

    // CompatibilityGate needs VersionNumberManager.instance, which is only set once the game's
    // own VersionNumberManager component runs its Awake() -- not guaranteed to exist yet when
    // our plugin's own Awake() runs, so we build the actual menu one frame at a time until
    // either it shows up or we give up and treat the version as unknown (fail safe: cheats stay
    // disabled rather than defaulting to enabled).
    private IEnumerator BuildAfterCompatibilityCheck(RectTransform canvasRoot, ConfigEntry<float> uiScale)
    {
        const float timeoutSeconds = 30f;
        var elapsed = 0f;
        while (VersionNumberManager.instance == null && elapsed < timeoutSeconds)
        {
            elapsed += Time.unscaledDeltaTime;
            yield return null;
        }

        CompatibilityGate.Check();

        _window = MenuWindow.Create(canvasRoot, _toggleKey, uiScale);
        _window.Close(instant: true);

        // Shown immediately (not gated behind opening the menu) so the player sees it even if
        // they never touch Insert -- the whole point is to warn before they go looking for
        // cheats that are quietly disabled.
        if (!CompatibilityGate.CheatsEnabled)
            CompatibilityBanner.Show(canvasRoot);
    }

    // BepInEx Script Engine hot-reloads this assembly without unloading whatever a previous
    // Awake() built, so a stale UI root (and its own EventSystem) can persist across reloads
    // via DontDestroyOnLoad. Without this, each reload would stack up another full menu -- and
    // another Update() polling the toggle key, so pressing it would open/close all of them at
    // once.
    //
    // Matching must be done by GameObject *name*, not component type: Script Engine loads each
    // reload into a brand new Assembly, so a stale root's MenuController component is a
    // different CLR Type than this one despite sharing the same name/namespace --
    // Resources.FindObjectsOfTypeAll<MenuController>() can never match across that boundary.
    // Names on the GameObjects themselves survive reloads, so search on those instead.
    // Resources.FindObjectsOfTypeAll also catches inactive/DontDestroyOnLoad instances that
    // plain scene-search APIs like GameObject.Find can miss.
    private static void DestroyExisting()
    {
        foreach (var go in Resources.FindObjectsOfTypeAll<GameObject>())
        {
            if (go != null && (go.name == "TRModMenu_UIRoot" || go.name == "TRModMenu_EventSystem"))
                Destroy(go);
        }
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
        if (_window != null && Input.GetKeyDown(_toggleKey.Value))
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
