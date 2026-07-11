using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace tr_mod_menu.UI;

internal class MenuWindow : MonoBehaviour
{
    private CanvasGroup _canvasGroup;
    private RectTransform _windowRect;
    private Image _backdrop;
    private Coroutine _animCoroutine;

    private readonly List<SidebarTab> _tabs = new();
    private readonly List<GameObject> _categoryPanels = new();

    public static MenuWindow Create(RectTransform canvasRoot)
    {
        var backdrop = UIFactory.CreatePanel(canvasRoot, "Backdrop",
            new Color(UITheme.Base.r, UITheme.Base.g, UITheme.Base.b, 0.55f), 4, 0);
        UIFactory.Stretch(backdrop.rectTransform);
        backdrop.raycastTarget = true;

        var windowGo = new GameObject("Window", typeof(RectTransform));
        windowGo.transform.SetParent(canvasRoot, false);

        var window = windowGo.AddComponent<MenuWindow>();
        window.Init(backdrop);
        return window;
    }

    private void Init(Image backdrop)
    {
        _backdrop = backdrop;

        _windowRect = (RectTransform)transform;
        _windowRect.anchorMin = new Vector2(0.5f, 0.5f);
        _windowRect.anchorMax = new Vector2(0.5f, 0.5f);
        _windowRect.pivot = new Vector2(0.5f, 0.5f);
        _windowRect.sizeDelta = new Vector2(UITheme.WindowWidth, UITheme.WindowHeight);
        _windowRect.anchoredPosition = Vector2.zero;

        _canvasGroup = gameObject.AddComponent<CanvasGroup>();

        var panelImg = gameObject.AddComponent<Image>();
        panelImg.sprite = UITheme.RoundedRect(64, 64, 14);
        panelImg.type = Image.Type.Sliced;
        panelImg.color = UITheme.Surface;
        panelImg.raycastTarget = true;

        BuildTitleBar();
        BuildDividers();

        var sidebarRect = BuildSidebar();
        var contentRect = BuildContent();
        BuildCategories(sidebarRect, contentRect);
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

        var title = UIFactory.CreateLabel(titleBarRect, "TR MOD MENU", 17, UITheme.Text);
        var titleRect = title.Graphic.rectTransform;
        UIFactory.Stretch(titleRect);
        titleRect.offsetMin = new Vector2(18f, 0f);
        titleRect.offsetMax = new Vector2(-90f, 0f);

        var resetGo = new GameObject("ResetButton", typeof(RectTransform));
        resetGo.transform.SetParent(titleBarRect, false);
        var resetRect = (RectTransform)resetGo.transform;
        resetRect.anchorMin = new Vector2(1f, 0.5f);
        resetRect.anchorMax = new Vector2(1f, 0.5f);
        resetRect.pivot = new Vector2(1f, 0.5f);
        resetRect.sizeDelta = new Vector2(60f, 24f);
        resetRect.anchoredPosition = new Vector2(-16f, 0f);

        var resetImg = resetGo.AddComponent<Image>();
        resetImg.color = new Color(0f, 0f, 0f, 0f);
        resetImg.raycastTarget = true;

        var resetButton = resetGo.AddComponent<Button>();
        resetButton.transition = Selectable.Transition.None;
        resetButton.targetGraphic = resetImg;
        resetButton.onClick.AddListener(() => Plugin.Logger.LogInfo("[Placeholder] Reset clicked (no-op)."));

        var resetLabel = UIFactory.CreateLabel(resetRect, "Reset", 14, UITheme.Red);
        UIFactory.Stretch(resetLabel.Graphic.rectTransform);
    }

    private void BuildDividers()
    {
        var underTitle = UIFactory.CreatePanel(transform, "TitleDivider", UITheme.Border, 4, 0);
        var underTitleRect = underTitle.rectTransform;
        underTitleRect.anchorMin = new Vector2(0f, 1f);
        underTitleRect.anchorMax = new Vector2(1f, 1f);
        underTitleRect.offsetMin = new Vector2(0f, -(UITheme.TitleBarHeight + 2f));
        underTitleRect.offsetMax = new Vector2(0f, -UITheme.TitleBarHeight);

        var vertical = UIFactory.CreatePanel(transform, "SidebarDivider", UITheme.Border, 4, 0);
        var verticalRect = vertical.rectTransform;
        verticalRect.anchorMin = new Vector2(0f, 0f);
        verticalRect.anchorMax = new Vector2(0f, 1f);
        verticalRect.offsetMin = new Vector2(UITheme.SidebarWidth, 8f);
        verticalRect.offsetMax = new Vector2(UITheme.SidebarWidth + 2f, -(UITheme.TitleBarHeight + 8f));
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
        vlg.padding = new RectOffset(12, 12, 12, 12);
        vlg.spacing = 6;
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
        contentRect.offsetMin = new Vector2(UITheme.SidebarWidth + 2f, 0f);
        contentRect.offsetMax = new Vector2(0f, -UITheme.TitleBarHeight);
        return contentRect;
    }

    private void BuildCategories(RectTransform sidebarRect, RectTransform contentRect)
    {
        for (var i = 0; i < MenuCategories.All.Count; i++)
        {
            var category = MenuCategories.All[i];
            var index = i;

            var tab = UIFactory.CreateSidebarTab(sidebarRect, category.Name, () => SelectCategory(index));
            _tabs.Add(tab);

            var panelRect = UIFactory.CreateFullRect(contentRect, $"Panel_{category.Name}");
            var rowList = UIFactory.CreateRowList(panelRect);
            foreach (var row in category.Rows)
            {
                if (row.Kind == RowKind.Toggle)
                {
                    UIFactory.CreateToggleRow(rowList, row.Label, row.DefaultBool,
                        v => Plugin.Logger.LogInfo($"[Placeholder] {category.Name}.{row.Label} = {v}"));
                }
                else
                {
                    UIFactory.CreateSliderRow(rowList, row.Label, row.Min, row.Max, row.DefaultFloat, row.Format,
                        v => Plugin.Logger.LogInfo($"[Placeholder] {category.Name}.{row.Label} = {v.ToString(row.Format)}"));
                }
            }

            panelRect.gameObject.SetActive(i == 0);
            _categoryPanels.Add(panelRect.gameObject);
        }

        if (_tabs.Count > 0)
            _tabs[0].Hover.IsSelected = true;
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
            _windowRect.localScale = Vector3.one * UITheme.WindowClosedScale;
            _backdrop.gameObject.SetActive(false);
            return;
        }

        AnimateTo(0f, UITheme.WindowClosedScale);
    }

    private void AnimateTo(float targetAlpha, float targetScale)
    {
        if (_animCoroutine != null)
            StopCoroutine(_animCoroutine);
        _animCoroutine = StartCoroutine(AnimateRoutine(targetAlpha, targetScale));
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
