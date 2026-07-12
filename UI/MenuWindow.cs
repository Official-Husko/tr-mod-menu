using System;
using System.Collections;
using System.Collections.Generic;
using BepInEx.Configuration;
using UnityEngine;
using UnityEngine.UI;

namespace tr_mod_menu.UI;

internal class MenuWindow : MonoBehaviour
{
    private CanvasGroup _canvasGroup;
    private RectTransform _windowRect;
    private Image _backdrop;
    private Coroutine _animCoroutine;
    private float _uiScale = 1f;

    private readonly List<SidebarTab> _tabs = new();
    private readonly List<GameObject> _categoryPanels = new();

    public static MenuWindow Create(RectTransform canvasRoot, ConfigEntry<KeyCode> toggleKey, ConfigEntry<float> uiScale)
    {
        var backdrop = UIFactory.CreatePanel(canvasRoot, "Backdrop",
            new Color(UITheme.Base.r, UITheme.Base.g, UITheme.Base.b, 0.55f), 4, 0);
        UIFactory.Stretch(backdrop.rectTransform);
        backdrop.raycastTarget = true;

        var windowGo = new GameObject("Window", typeof(RectTransform));
        windowGo.transform.SetParent(canvasRoot, false);

        var window = windowGo.AddComponent<MenuWindow>();
        window.Init(backdrop, toggleKey, uiScale);
        return window;
    }

    private void Init(Image backdrop, ConfigEntry<KeyCode> toggleKey, ConfigEntry<float> uiScale)
    {
        _backdrop = backdrop;
        _uiScale = uiScale.Value;

        _windowRect = (RectTransform)transform;
        _windowRect.anchorMin = new Vector2(0.5f, 0.5f);
        _windowRect.anchorMax = new Vector2(0.5f, 0.5f);
        _windowRect.pivot = new Vector2(0.5f, 0.5f);
        _windowRect.sizeDelta = new Vector2(UITheme.WindowWidth, UITheme.WindowHeight);
        _windowRect.anchoredPosition = Vector2.zero;

        _canvasGroup = gameObject.AddComponent<CanvasGroup>();

        var panelImg = gameObject.AddComponent<Image>();
        panelImg.sprite = UITheme.RoundedRect(64, 64, 12);
        panelImg.type = Image.Type.Sliced;
        panelImg.color = UITheme.Surface;
        panelImg.raycastTarget = true;

        BuildTitleBar();
        BuildDividers();

        var sidebarRect = BuildSidebar();
        var contentRect = BuildContent();
        BuildCategories(sidebarRect, contentRect, toggleKey, uiScale);
    }

    // Live-applies the scale (no lerp) so dragging the Settings slider previews instantly, and
    // persists it to the config entry. Open/close animations multiply their target scale by
    // this value (see AnimateTo/Close) so the window keeps opening at whatever scale was chosen.
    private void SetUiScale(float scale, ConfigEntry<float> uiScaleConfig)
    {
        _uiScale = Mathf.Clamp(scale, 0.1f, 3f);
        _windowRect.localScale = Vector3.one * _uiScale;
        uiScaleConfig.Value = _uiScale;
    }

    private void BuildTitleBar()
    {
        var titleBar = new GameObject("TitleBar", typeof(RectTransform));
        titleBar.transform.SetParent(transform, false);
        var titleBarRect = (RectTransform)titleBar.transform;
        titleBarRect.anchorMin = new Vector2(0f, 1f);
        titleBarRect.anchorMax = new Vector2(1f, 1f);
        titleBarRect.offsetMin = new Vector2(0f, -UITheme.TitleBarHeight);
        titleBarRect.offsetMax = new Vector2(0f, 0f);

        var title = UIFactory.CreateLabel(titleBarRect, "TR MOD MENU", 14, UITheme.Text);
        var titleRect = title.Graphic.rectTransform;
        UIFactory.Stretch(titleRect);
        titleRect.offsetMin = new Vector2(14f, 0f);
        titleRect.offsetMax = new Vector2(-76f, 0f);

        var resetGo = new GameObject("ResetButton", typeof(RectTransform));
        resetGo.transform.SetParent(titleBarRect, false);
        var resetRect = (RectTransform)resetGo.transform;
        resetRect.anchorMin = new Vector2(1f, 0.5f);
        resetRect.anchorMax = new Vector2(1f, 0.5f);
        resetRect.pivot = new Vector2(1f, 0.5f);
        resetRect.sizeDelta = new Vector2(52f, 20f);
        resetRect.anchoredPosition = new Vector2(-14f, 0f);

        var resetImg = resetGo.AddComponent<Image>();
        resetImg.color = new Color(0f, 0f, 0f, 0f);
        resetImg.raycastTarget = true;

        var resetButton = resetGo.AddComponent<Button>();
        resetButton.transition = Selectable.Transition.None;
        resetButton.targetGraphic = resetImg;
        resetButton.onClick.AddListener(() => Plugin.Logger.LogInfo("[Placeholder] Reset clicked (no-op)."));

        var resetLabel = UIFactory.CreateLabel(resetRect, "Reset", 12, UITheme.Red);
        UIFactory.Stretch(resetLabel.Graphic.rectTransform);
    }

    private void BuildDividers()
    {
        var underTitle = UIFactory.CreatePanel(transform, "TitleDivider", UITheme.Border, 4, 0);
        var underTitleRect = underTitle.rectTransform;
        underTitleRect.anchorMin = new Vector2(0f, 1f);
        underTitleRect.anchorMax = new Vector2(1f, 1f);
        underTitleRect.offsetMin = new Vector2(0f, -(UITheme.TitleBarHeight + 1f));
        underTitleRect.offsetMax = new Vector2(0f, -UITheme.TitleBarHeight);

        var vertical = UIFactory.CreatePanel(transform, "SidebarDivider", UITheme.Border, 4, 0);
        var verticalRect = vertical.rectTransform;
        verticalRect.anchorMin = new Vector2(0f, 0f);
        verticalRect.anchorMax = new Vector2(0f, 1f);
        verticalRect.offsetMin = new Vector2(UITheme.SidebarWidth, 6f);
        verticalRect.offsetMax = new Vector2(UITheme.SidebarWidth + 1f, -(UITheme.TitleBarHeight + 6f));
    }

    private RectTransform BuildSidebar()
    {
        var sidebar = new GameObject("Sidebar", typeof(RectTransform));
        sidebar.transform.SetParent(transform, false);
        var sidebarRect = (RectTransform)sidebar.transform;
        sidebarRect.anchorMin = new Vector2(0f, 0f);
        sidebarRect.anchorMax = new Vector2(0f, 1f);
        sidebarRect.offsetMin = new Vector2(0f, 0f);
        sidebarRect.offsetMax = new Vector2(UITheme.SidebarWidth, -UITheme.TitleBarHeight);

        var vlg = sidebar.AddComponent<VerticalLayoutGroup>();
        vlg.padding = new RectOffset(8, 8, 8, 8);
        vlg.spacing = 3;
        vlg.childAlignment = TextAnchor.UpperLeft;
        vlg.childControlWidth = true;
        vlg.childControlHeight = true;
        vlg.childForceExpandWidth = true;
        vlg.childForceExpandHeight = false;

        return sidebarRect;
    }

    private RectTransform BuildContent()
    {
        var content = new GameObject("Content", typeof(RectTransform));
        content.transform.SetParent(transform, false);
        var contentRect = (RectTransform)content.transform;
        contentRect.anchorMin = new Vector2(0f, 0f);
        contentRect.anchorMax = new Vector2(1f, 1f);
        contentRect.offsetMin = new Vector2(UITheme.SidebarWidth + 1f, 0f);
        contentRect.offsetMax = new Vector2(0f, -UITheme.TitleBarHeight);
        return contentRect;
    }

    private void BuildCategories(RectTransform sidebarRect, RectTransform contentRect, ConfigEntry<KeyCode> toggleKey, ConfigEntry<float> uiScale)
    {
        foreach (var category in MenuCategories.All)
        {
            AddPanel(sidebarRect, contentRect, category.Name, category.IconName, rowList =>
            {
                foreach (var row in category.Rows)
                    BuildDataRow(rowList, category.Name, row);
            });
        }

        // Flexible spacer absorbs all leftover sidebar height, pinning Settings/About to the
        // bottom edge instead of just trailing immediately after the last cheat category.
        var spacerGo = new GameObject("Spacer", typeof(RectTransform));
        spacerGo.transform.SetParent(sidebarRect, false);
        spacerGo.AddComponent<LayoutElement>().flexibleHeight = 1f;

        AddPanel(sidebarRect, contentRect, "Settings", "settings", rowList => BuildSettingsPanel(rowList, toggleKey, uiScale));
        AddPanel(sidebarRect, contentRect, "About", "about", BuildAboutPanel);

        if (_tabs.Count > 0)
            _tabs[0].Hover.IsSelected = true;
        for (var i = 0; i < _categoryPanels.Count; i++)
            _categoryPanels[i].SetActive(i == 0);
    }

    private void AddPanel(RectTransform sidebarRect, RectTransform contentRect, string name, string iconName, Action<RectTransform> build)
    {
        var index = _tabs.Count;
        var tab = UIFactory.CreateSidebarTab(sidebarRect, name, iconName, () => SelectCategory(index));
        _tabs.Add(tab);

        var panelRect = UIFactory.CreateFullRect(contentRect, $"Panel_{name}");
        var rowList = UIFactory.CreateRowList(panelRect);
        build(rowList);

        _categoryPanels.Add(panelRect.gameObject);
    }

    private static void BuildDataRow(RectTransform rowList, string categoryName, RowSpec row)
    {
        switch (row.Kind)
        {
            case RowKind.Toggle:
                UIFactory.CreateToggleRow(rowList, row.Label, row.DefaultBool,
                    v => Plugin.Logger.LogInfo($"[Placeholder] {categoryName}.{row.Label} = {v}"));
                break;
            case RowKind.Slider:
                UIFactory.CreateSliderRow(rowList, row.Label, row.Min, row.Max, row.DefaultFloat, row.Format,
                    v => Plugin.Logger.LogInfo($"[Placeholder] {categoryName}.{row.Label} = {v.ToString(row.Format)}"));
                break;
            case RowKind.Dropdown:
                UIFactory.CreateDropdownActionRow(rowList, row.Label, row.Options,
                    i => Plugin.Logger.LogInfo($"[Placeholder] {categoryName}.{row.Label} executed with '{row.Options[i]}'"));
                break;
            case RowKind.DropdownAmount:
                UIFactory.CreateDropdownAmountActionRow(rowList, row.Label, row.Options, row.DefaultFloat, row.Format,
                    (i, amount) => Plugin.Logger.LogInfo($"[Placeholder] {categoryName}.{row.Label} executed with '{row.Options[i]}' x{amount.ToString(row.Format)}"));
                break;
            case RowKind.NumberInput:
                UIFactory.CreateNumberActionRow(rowList, row.Label, row.DefaultFloat, row.Format,
                    row.OnExecute ?? (v => Plugin.Logger.LogInfo($"[Placeholder] {categoryName}.{row.Label} executed with {v.ToString(row.Format)}")));
                break;
            case RowKind.Note:
                UIFactory.CreateNoteRow(rowList, row.Label);
                break;
        }
    }

    private void BuildSettingsPanel(RectTransform rowList, ConfigEntry<KeyCode> toggleKey, ConfigEntry<float> uiScale)
    {
        UIFactory.CreateInfoRow(rowList, "Menu Toggle Key", toggleKey.Value.ToString());
        UIFactory.CreateSliderRow(rowList, "UI Scale", 0.75f, 1.5f, uiScale.Value, "0.00\"x\"",
            v => SetUiScale(v, uiScale));
    }

    private static void BuildAboutPanel(RectTransform rowList)
    {
        UIFactory.CreateInfoRow(rowList, "Mod", MyPluginInfo.PLUGIN_NAME);
        UIFactory.CreateInfoRow(rowList, "Version", MyPluginInfo.PLUGIN_VERSION);
        UIFactory.CreateInfoRow(rowList, "Game", "Travellers Rest");
        UIFactory.CreateInfoRow(rowList, "Credits", AboutInfo.Credits);
        UIFactory.CreateLinkRow(rowList, "Source Code", AboutInfo.RepoUrl);
    }

    private void SelectCategory(int index)
    {
        for (var i = 0; i < _tabs.Count; i++)
            _tabs[i].Hover.IsSelected = i == index;
        for (var i = 0; i < _categoryPanels.Count; i++)
            _categoryPanels[i].SetActive(i == index);
    }

    public void Open()
    {
        _backdrop.gameObject.SetActive(true);
        _canvasGroup.interactable = true;
        _canvasGroup.blocksRaycasts = true;
        AnimateTo(1f, 1f);
    }

    public void Close(bool instant = false)
    {
        _canvasGroup.interactable = false;
        _canvasGroup.blocksRaycasts = false;

        if (instant)
        {
            if (_animCoroutine != null)
                StopCoroutine(_animCoroutine);
            _canvasGroup.alpha = 0f;
            _windowRect.localScale = Vector3.one * UITheme.WindowClosedScale * _uiScale;
            _backdrop.gameObject.SetActive(false);
            return;
        }

        AnimateTo(0f, UITheme.WindowClosedScale);
    }

    private void AnimateTo(float targetAlpha, float targetScale)
    {
        if (_animCoroutine != null)
            StopCoroutine(_animCoroutine);
        _animCoroutine = StartCoroutine(AnimateRoutine(targetAlpha, targetScale * _uiScale));
    }

    private IEnumerator AnimateRoutine(float targetAlpha, float targetScale)
    {
        var startAlpha = _canvasGroup.alpha;
        var startScale = _windowRect.localScale.x;
        var elapsed = 0f;

        while (elapsed < UITheme.WindowAnimDuration)
        {
            elapsed += Time.unscaledDeltaTime;
            var t = Mathf.Clamp01(elapsed / UITheme.WindowAnimDuration);
            _canvasGroup.alpha = Mathf.Lerp(startAlpha, targetAlpha, t);
            var s = Mathf.Lerp(startScale, targetScale, t);
            _windowRect.localScale = new Vector3(s, s, 1f);
            yield return null;
        }

        _canvasGroup.alpha = targetAlpha;
        _windowRect.localScale = new Vector3(targetScale, targetScale, 1f);

        if (targetAlpha <= 0f)
            _backdrop.gameObject.SetActive(false);
    }
}
