using System;
using System.Collections.Generic;
using tr_mod_menu.UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace tr_mod_menu.UI.Widgets;

// A hand-rolled dropdown instead of Unity's TMP_Dropdown/UI.Dropdown: those need a whole
// Template/Viewport/Content/Item hierarchy wired via hardcoded internal path lookups
// ("Viewport/Content/Item") that are normally set up by Editor tooling we don't have here, and
// in practice it didn't reliably open. This version only uses primitives (Button, Image,
// VerticalLayoutGroup, ScrollRect) already proven to work elsewhere in this menu.
internal class SimpleDropdown : MonoBehaviour, IPointerClickHandler
{
    private const float ItemHeight = 20f;
    private const int MaxVisibleItems = 6;
    private const float ItemSpacing = 1f; // shared with both list builders' VerticalLayoutGroup.spacing

    public List<string> Options;
    public int Value;
    public Action<string> OnCaptionChanged;
    public bool Disabled;

    // Give Item is the first row with two SimpleDropdowns side by side -- tracked globally
    // (not just this instance's own _popup) so opening one always closes any other that's open,
    // rather than relying on each dropdown only ever seeing clicks meant for itself.
    private static SimpleDropdown _openDropdown;

    private GameObject _popup;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (Disabled)
            return;

        if (_popup != null)
            ClosePopup();
        else
            OpenPopup();
    }

    // For a dropdown whose options depend on another control (e.g. an item list filtered by a
    // category dropdown) -- swaps the option list and re-applies OnCaptionChanged so the
    // displayed caption reflects the new list immediately, the same way a manual selection would,
    // without requiring the popup to actually be opened.
    public void SetOptions(List<string> options, int value = 0)
    {
        ClosePopup();
        Options = options;
        Value = Mathf.Clamp(value, 0, Mathf.Max(options.Count - 1, 0));
        OnCaptionChanged?.Invoke(Options.Count > 0 ? Options[Value] : "");
    }

    private void OnDisable() => ClosePopup();

    private void OpenPopup()
    {
        if (_openDropdown != null && _openDropdown != this)
            _openDropdown.ClosePopup();

        var canvas = GetComponentInParent<Canvas>();
        if (canvas == null)
            return;
        var canvasRoot = (RectTransform)canvas.transform;
        var cam = canvas.renderMode == RenderMode.ScreenSpaceOverlay ? null : canvas.worldCamera;

        var ddRect = (RectTransform)transform;
        var corners = new Vector3[4];
        ddRect.GetWorldCorners(corners); // 0 = bottom-left, 3 = bottom-right

        // ScreenPointToLocalPointInRectangle returns a point relative to canvasRoot's *pivot*
        // (its center, by default), not its bottom-left corner. The blocker/popup below is
        // anchored at (0.5, 0.5) to match that same center-relative convention, rather than
        // mixing it with a (0,0) bottom-left anchor -- that mismatch (treating a center-relative
        // offset as a corner-relative one) is what threw the popup off to the wrong spot.
        RectTransformUtility.ScreenPointToLocalPointInRectangle(canvasRoot,
            RectTransformUtility.WorldToScreenPoint(cam, corners[0]), cam, out var localBottomLeft);
        RectTransformUtility.ScreenPointToLocalPointInRectangle(canvasRoot,
            RectTransformUtility.WorldToScreenPoint(cam, corners[3]), cam, out var localBottomRight);

        var width = localBottomRight.x - localBottomLeft.x;
        var visibleCount = Mathf.Min(Options.Count, MaxVisibleItems);
        // +8f is the popup's own 4px-per-side margin (see BuildPlainList/BuildScrollingList's
        // offsetMin/offsetMax insets). The visible items also need spacing *between* them
        // (visibleCount - 1 gaps) -- omitting that here previously left the popup exactly that
        // many pixels short, clipping the last visible item against the viewport/list bounds
        // instead of leaving it fully readable.
        var popupHeight = ItemHeight * visibleCount + Mathf.Max(0, visibleCount - 1) * ItemSpacing + 8f;
        var needsScroll = Options.Count > MaxVisibleItems;

        // Full-screen invisible blocker closes the popup on an outside click; the popup is a
        // child of it so its own graphics always draw (and raycast-hit) on top of the blocker.
        var blockerGo = new GameObject("DropdownBlocker", typeof(RectTransform));
        blockerGo.transform.SetParent(canvasRoot, false);
        UIFactory.Stretch((RectTransform)blockerGo.transform);
        var blockerImg = blockerGo.AddComponent<Image>();
        blockerImg.color = new Color(0f, 0f, 0f, 0f);
        var blockerBtn = blockerGo.AddComponent<Button>();
        blockerBtn.transition = Selectable.Transition.None;
        blockerBtn.onClick.AddListener(ClosePopup);

        var popupGo = new GameObject("DropdownPopup", typeof(RectTransform));
        popupGo.transform.SetParent(blockerGo.transform, false);
        var popupRect = (RectTransform)popupGo.transform;
        popupRect.anchorMin = new Vector2(0.5f, 0.5f);
        popupRect.anchorMax = new Vector2(0.5f, 0.5f);
        popupRect.pivot = new Vector2(0f, 1f);
        popupRect.anchoredPosition = new Vector2(localBottomLeft.x, localBottomLeft.y - 2f);
        popupRect.sizeDelta = new Vector2(width, popupHeight);

        var popupImg = popupGo.AddComponent<Image>();
        popupImg.sprite = UITheme.RoundedRect(40, 40, 6);
        popupImg.type = Image.Type.Sliced;
        popupImg.color = UITheme.Surface;
        popupImg.raycastTarget = true;

        var listParent = needsScroll ? BuildScrollingList(popupRect) : BuildPlainList(popupRect);

        for (var i = 0; i < Options.Count; i++)
            BuildItem(listParent, i);

        // Same class of bug as MenuWindow.BuildCategoryPanel's ForceRebuildLayoutImmediate (see
        // its comment): this whole hierarchy -- ScrollRect/Viewport/Content/Scrollbar/layout
        // groups -- is built from raw GameObjects this same frame and shown immediately, with no
        // prior layout pass to piggyback on. Left alone, ScrollRect's bounds/scrollbar-size
        // calculations (which need resolved RectTransform sizes) run stale on the first rendered
        // frame -- confirmed live: the scrollbar handle rendered at full track size, wide enough
        // to cover part of the popup, exactly like a panel's cards stacking with stale sizes
        // before its first rebuild. Force it here, after every child exists, rather than trusting
        // Unity's automatic end-of-frame rebuild to land before this popup is first painted.
        LayoutRebuilder.ForceRebuildLayoutImmediate(popupRect);

        _popup = blockerGo;
        _openDropdown = this;
    }

    // Short lists: no scrolling machinery needed, items just stack in a plain layout group.
    private static RectTransform BuildPlainList(RectTransform popupRect)
    {
        var listRect = UIFactory.CreateFullRect(popupRect, "List");
        listRect.offsetMin = new Vector2(4f, 4f);
        listRect.offsetMax = new Vector2(-4f, -4f);
        var vlg = listRect.gameObject.AddComponent<VerticalLayoutGroup>();
        vlg.childAlignment = TextAnchor.UpperLeft;
        vlg.childControlWidth = true;
        vlg.childControlHeight = false; // explicit sizeDelta per item, same fix as the row-stretch bug
        vlg.childForceExpandWidth = true;
        vlg.childForceExpandHeight = false;
        vlg.spacing = ItemSpacing;
        return listRect;
    }

    // Long lists: cap the popup at MaxVisibleItems tall and scroll the rest, with a visible
    // scrollbar down the right edge.
    private RectTransform BuildScrollingList(RectTransform popupRect)
    {
        var scrollAreaRect = UIFactory.CreateFullRect(popupRect, "ScrollArea");
        scrollAreaRect.offsetMin = new Vector2(4f, 4f);
        scrollAreaRect.offsetMax = new Vector2(-4f, -4f);

        var scrollRect = scrollAreaRect.gameObject.AddComponent<ScrollRect>();
        scrollRect.horizontal = false;
        scrollRect.vertical = true;
        scrollRect.movementType = ScrollRect.MovementType.Clamped;
        scrollRect.scrollSensitivity = ItemHeight;

        var viewportRect = UIFactory.CreateFullRect(scrollAreaRect, "Viewport");
        viewportRect.offsetMax = new Vector2(-10f, 0f); // leave room for the scrollbar
        viewportRect.gameObject.AddComponent<RectMask2D>();

        var contentRect = new GameObject("Content", typeof(RectTransform));
        contentRect.transform.SetParent(viewportRect, false);
        var contentRT = (RectTransform)contentRect.transform;
        contentRT.anchorMin = new Vector2(0f, 1f);
        contentRT.anchorMax = new Vector2(1f, 1f);
        contentRT.pivot = new Vector2(0.5f, 1f);
        contentRT.anchoredPosition = Vector2.zero;
        // Same gap this method's caller (OpenPopup) already accounts for in popupHeight, but for
        // *every* item here, not just the visible window -- this is the full scrollable content,
        // so leaving out the (Options.Count - 1) inter-item gaps understated its true height by
        // exactly that many pixels. ScrollRect derives its scrollable range from this sizeDelta,
        // so an undersized content area made the last item or two permanently unreachable by
        // scrolling, not just visually tight -- there was no way to scroll far enough to bring the
        // bottom of the list fully into view.
        contentRT.sizeDelta = new Vector2(0f, ItemHeight * Options.Count + Mathf.Max(0, Options.Count - 1) * ItemSpacing);
        var vlg = contentRect.gameObject.AddComponent<VerticalLayoutGroup>();
        vlg.childAlignment = TextAnchor.UpperLeft;
        vlg.childControlWidth = true;
        vlg.childControlHeight = false;
        vlg.childForceExpandWidth = true;
        vlg.childForceExpandHeight = false;
        vlg.spacing = ItemSpacing;

        scrollRect.viewport = viewportRect;
        scrollRect.content = contentRT;

        var scrollbarRect = (RectTransform)new GameObject("Scrollbar", typeof(RectTransform)).transform;
        scrollbarRect.SetParent(scrollAreaRect, false);
        scrollbarRect.anchorMin = new Vector2(1f, 0f);
        scrollbarRect.anchorMax = new Vector2(1f, 1f);
        scrollbarRect.pivot = new Vector2(1f, 1f);
        scrollbarRect.sizeDelta = new Vector2(6f, 0f);
        scrollbarRect.anchoredPosition = Vector2.zero;

        var trackImg = scrollbarRect.gameObject.AddComponent<Image>();
        trackImg.sprite = UITheme.RoundedRect(6, 40, 3);
        trackImg.type = Image.Type.Sliced;
        trackImg.color = UITheme.Base;

        var scrollbar = scrollbarRect.gameObject.AddComponent<Scrollbar>();
        scrollbar.direction = Scrollbar.Direction.BottomToTop;

        var handleAreaRect = UIFactory.CreateFullRect(scrollbarRect, "Sliding Area");
        var handleGo = new GameObject("Handle", typeof(RectTransform));
        handleGo.transform.SetParent(handleAreaRect, false);
        var handleRT = (RectTransform)handleGo.transform;
        handleRT.anchorMin = new Vector2(0f, 1f - Mathf.Clamp01((float)MaxVisibleItems / Options.Count));
        handleRT.anchorMax = Vector2.one;
        // The actual bug behind five failed fix attempts: a fresh RectTransform's sizeDelta
        // defaults to (100, 100), and with stretch anchors (anchorMin != anchorMax, as above)
        // sizeDelta isn't ignored -- it's an offset ADDED on top of the anchor-stretched size.
        // Every previous attempt correctly computed and set anchorMin/anchorMax (confirmed by
        // logging the live values: Handle.anchorMin/Max were exactly right on every single frame)
        // but never touched sizeDelta, so the handle was always rendering ~100px wider and taller
        // than its anchors alone would suggest -- explaining both the "way wider than a 6px
        // scrollbar could ever be" mystery and why reasserting anchors every frame changed nothing.
        handleRT.sizeDelta = Vector2.zero;
        var handleImg = handleGo.AddComponent<Image>();
        handleImg.sprite = UITheme.RoundedRect(6, 20, 3);
        handleImg.type = Image.Type.Sliced;
        handleImg.color = UITheme.Accent;

        scrollbar.targetGraphic = handleImg;
        scrollbar.handleRect = handleRT;
        scrollbar.size = Mathf.Clamp01((float)MaxVisibleItems / Options.Count);
        scrollRect.verticalScrollbar = scrollbar;
        scrollRect.verticalScrollbarVisibility = ScrollRect.ScrollbarVisibility.Permanent;

        return contentRT;
    }

    private void BuildItem(RectTransform parent, int index)
    {
        var itemGo = new GameObject($"Option_{Options[index]}", typeof(RectTransform));
        itemGo.transform.SetParent(parent, false);
        ((RectTransform)itemGo.transform).sizeDelta = new Vector2(0f, ItemHeight);

        var itemImg = itemGo.AddComponent<Image>();
        itemImg.color = new Color(0f, 0f, 0f, 0f);

        var itemBtn = itemGo.AddComponent<Button>();
        itemBtn.transition = Selectable.Transition.None;
        itemBtn.targetGraphic = itemImg;
        itemBtn.onClick.AddListener(() => Select(index));

        var itemHover = itemGo.AddComponent<HoverEffect>();
        itemHover.TargetImage = itemImg;
        itemHover.IdleColor = new Color(0f, 0f, 0f, 0f);
        itemHover.HoverColor = new Color(UITheme.Accent.r, UITheme.Accent.g, UITheme.Accent.b, 0.18f);
        itemHover.SelectedColor = itemHover.HoverColor;
        itemHover.IsSelected = index == Value;

        var itemLabel = UIFactory.CreateLabel(itemGo.transform, Options[index], 12, UITheme.Text);
        var itemLabelRect = itemLabel.Graphic.rectTransform;
        UIFactory.Stretch(itemLabelRect);
        itemLabelRect.offsetMin = new Vector2(8f, 0f);
        itemLabelRect.offsetMax = new Vector2(-8f, 0f);
    }

    private void Select(int index)
    {
        Value = index;
        OnCaptionChanged?.Invoke(Options[index]);
        ClosePopup();
    }

    private void ClosePopup()
    {
        if (_popup != null)
            Destroy(_popup);
        _popup = null;
        if (_openDropdown == this)
            _openDropdown = null;
    }
}
