using System;
using TMPro;
using tr_mod_menu.UI.Widgets;
using UnityEngine;
using UnityEngine.UI;

namespace tr_mod_menu.UI;

internal readonly struct UILabel
{
    public readonly Graphic Graphic;
    private readonly Action<string> _setText;

    public UILabel(Graphic graphic, Action<string> setText)
    {
        Graphic = graphic;
        _setText = setText;
    }

    public void SetText(string text) => _setText(text);
}

internal readonly struct SidebarTab
{
    public readonly GameObject GameObject;
    public readonly HoverEffect Hover;

    public SidebarTab(GameObject gameObject, HoverEffect hover)
    {
        GameObject = gameObject;
        Hover = hover;
    }
}

internal static class UIFactory
{
    private static bool? _tmpOk;
    private static TMP_FontAsset _tmpFont;
    private static Font _legacyFont;

    private static bool TmpAvailable()
    {
        if (_tmpOk.HasValue)
            return _tmpOk.Value;

        _tmpFont = Resources.Load<TMP_FontAsset>("Fonts & Materials/LiberationSans SDF");
        _tmpOk = _tmpFont != null;
        if (!_tmpOk.Value)
        {
            Plugin.Logger.LogWarning("[UI] TMP default font asset not found; falling back to legacy UI.Text.");
            _legacyFont = Resources.GetBuiltinResource<Font>("LegacyRuntime.ttf");
        }
        return _tmpOk.Value;
    }

    public static RectTransform Stretch(RectTransform rt)
    {
        rt.anchorMin = Vector2.zero;
        rt.anchorMax = Vector2.one;
        rt.offsetMin = Vector2.zero;
        rt.offsetMax = Vector2.zero;
        rt.pivot = new Vector2(0.5f, 0.5f);
        return rt;
    }

    public static RectTransform CreateFullRect(Transform parent, string name)
    {
        var go = new GameObject(name, typeof(RectTransform));
        go.transform.SetParent(parent, false);
        return Stretch((RectTransform)go.transform);
    }

    public static Image CreatePanel(Transform parent, string name, Color color, int spriteSize, int radius)
    {
        var go = new GameObject(name, typeof(RectTransform));
        go.transform.SetParent(parent, false);
        var img = go.AddComponent<Image>();
        img.sprite = UITheme.RoundedRect(spriteSize, spriteSize, radius);
        img.type = Image.Type.Sliced;
        img.color = color;
        return img;
    }

    public static UILabel CreateLabel(Transform parent, string text, int fontSize, Color color)
    {
        var go = new GameObject("Label", typeof(RectTransform));
        go.transform.SetParent(parent, false);

        if (TmpAvailable())
        {
            var tmp = go.AddComponent<TextMeshProUGUI>();
            tmp.font = _tmpFont;
            tmp.text = text;
            tmp.fontSize = fontSize;
            tmp.color = color;
            tmp.alignment = TextAlignmentOptions.MidlineLeft;
            tmp.enableWordWrapping = false;
            tmp.overflowMode = TextOverflowModes.Overflow;
            tmp.raycastTarget = false;
            return new UILabel(tmp, s => tmp.text = s);
        }

        var legacyText = go.AddComponent<Text>();
        legacyText.font = _legacyFont;
        legacyText.text = text;
        legacyText.fontSize = fontSize;
        legacyText.color = color;
        legacyText.alignment = TextAnchor.MiddleLeft;
        legacyText.horizontalOverflow = HorizontalWrapMode.Overflow;
        legacyText.verticalOverflow = VerticalWrapMode.Overflow;
        legacyText.raycastTarget = false;
        return new UILabel(legacyText, s => legacyText.text = s);
    }

    public static SidebarTab CreateSidebarTab(RectTransform parent, string label, Action onClick)
    {
        var go = new GameObject($"Tab_{label}", typeof(RectTransform));
        go.transform.SetParent(parent, false);

        var layoutEl = go.AddComponent<LayoutElement>();
        layoutEl.preferredHeight = 40;
        layoutEl.flexibleWidth = 1;

        var img = go.AddComponent<Image>();
        img.sprite = UITheme.RoundedRect(48, 48, 8);
        img.type = Image.Type.Sliced;
        img.color = new Color(0f, 0f, 0f, 0f);

        var button = go.AddComponent<Button>();
        button.transition = Selectable.Transition.None;
        button.onClick.AddListener(() => onClick?.Invoke());

        var labelHandle = CreateLabel(go.transform, label, 15, UITheme.MutedText);
        var labelRect = labelHandle.Graphic.rectTransform;
        Stretch(labelRect);
        labelRect.offsetMin = new Vector2(14, 0);
        labelRect.offsetMax = new Vector2(-14, 0);

        var hover = go.AddComponent<HoverEffect>();
        hover.TargetImage = img;
        hover.TargetLabel = labelHandle.Graphic;
        hover.IdleColor = new Color(0f, 0f, 0f, 0f);
        hover.HoverColor = new Color(UITheme.Border.r, UITheme.Border.g, UITheme.Border.b, 1f);
        hover.SelectedColor = new Color(UITheme.Accent.r, UITheme.Accent.g, UITheme.Accent.b, 0.18f);
        hover.IdleLabelColor = UITheme.MutedText;
        hover.HoverLabelColor = UITheme.Text;
        hover.SelectedLabelColor = UITheme.Accent;

        return new SidebarTab(go, hover);
    }

    public static RectTransform CreateRowList(RectTransform parent)
    {
        var rect = CreateFullRect(parent, "RowList");
        var vlg = rect.gameObject.AddComponent<VerticalLayoutGroup>();
        vlg.padding = new RectOffset(0, 0, 8, 8);
        vlg.spacing = 4;
        vlg.childAlignment = TextAnchor.UpperLeft;
        vlg.childControlHeight = true;
        vlg.childControlWidth = true;
        vlg.childForceExpandHeight = false;
        vlg.childForceExpandWidth = true;
        return rect;
    }

    private static RectTransform CreateRow(RectTransform parent)
    {
        var go = new GameObject("Row", typeof(RectTransform));
        go.transform.SetParent(parent, false);

        var layoutEl = go.AddComponent<LayoutElement>();
        layoutEl.preferredHeight = UITheme.RowHeight;
        layoutEl.minHeight = UITheme.RowHeight;

        var hlg = go.AddComponent<HorizontalLayoutGroup>();
        hlg.padding = new RectOffset(16, 16, 0, 0);
        hlg.spacing = 12;
        hlg.childAlignment = TextAnchor.MiddleLeft;
        hlg.childControlWidth = true;
        hlg.childControlHeight = true;
        hlg.childForceExpandWidth = false;
        hlg.childForceExpandHeight = true;

        return (RectTransform)go.transform;
    }

    private static void CreateRowLabel(RectTransform row, string text)
    {
        var label = CreateLabel(row, text, 15, UITheme.Text);
        var layoutEl = label.Graphic.gameObject.AddComponent<LayoutElement>();
        layoutEl.flexibleWidth = 1;
    }

    public static void CreateToggleRow(RectTransform parent, string label, bool defaultValue, Action<bool> onChanged)
    {
        var row = CreateRow(parent);
        CreateRowLabel(row, label);

        var pillGo = new GameObject("Toggle", typeof(RectTransform));
        pillGo.transform.SetParent(row, false);
        var pillLayoutEl = pillGo.AddComponent<LayoutElement>();
        pillLayoutEl.preferredWidth = 44;
        pillLayoutEl.preferredHeight = 24;

        var pillImg = pillGo.AddComponent<Image>();
        pillImg.sprite = UITheme.RoundedRect(44, 24, 12);
        pillImg.type = Image.Type.Sliced;
        pillImg.color = defaultValue ? UITheme.Green : UITheme.Surface2;

        var knobGo = new GameObject("Knob", typeof(RectTransform));
        knobGo.transform.SetParent(pillGo.transform, false);
        var knobRect = (RectTransform)knobGo.transform;
        knobRect.anchorMin = new Vector2(0f, 0.5f);
        knobRect.anchorMax = new Vector2(0f, 0.5f);
        knobRect.pivot = new Vector2(0.5f, 0.5f);
        knobRect.sizeDelta = new Vector2(20f, 20f);
        knobRect.anchoredPosition = defaultValue ? new Vector2(32f, 0f) : new Vector2(12f, 0f);
        var knobImg = knobGo.AddComponent<Image>();
        knobImg.sprite = UITheme.RoundedRect(20, 20, 10);
        knobImg.color = UITheme.Text;

        var toggle = pillGo.AddComponent<ToggleSwitch>();
        toggle.Pill = pillImg;
        toggle.Knob = knobRect;
        toggle.SetValue(defaultValue, notify: false);
        toggle.OnValueChanged += v => onChanged?.Invoke(v);
    }

    public static void CreateSliderRow(RectTransform parent, string label, float min, float max, float defaultValue, string format, Action<float> onChanged)
    {
        var row = CreateRow(parent);
        CreateRowLabel(row, label);

        var containerGo = new GameObject("SliderContainer", typeof(RectTransform));
        containerGo.transform.SetParent(row, false);
        var containerLayoutEl = containerGo.AddComponent<LayoutElement>();
        containerLayoutEl.preferredWidth = 220;
        containerLayoutEl.preferredHeight = 24;
        var containerRect = (RectTransform)containerGo.transform;
        var containerHlg = containerGo.AddComponent<HorizontalLayoutGroup>();
        containerHlg.spacing = 10;
        containerHlg.childAlignment = TextAnchor.MiddleLeft;
        containerHlg.childControlWidth = true;
        containerHlg.childControlHeight = true;
        containerHlg.childForceExpandWidth = false;
        containerHlg.childForceExpandHeight = true;

        var sliderGo = new GameObject("Slider", typeof(RectTransform));
        sliderGo.transform.SetParent(containerRect, false);
        var sliderLayoutEl = sliderGo.AddComponent<LayoutElement>();
        sliderLayoutEl.preferredWidth = 140;
        sliderLayoutEl.flexibleWidth = 1;
        var sliderRect = (RectTransform)sliderGo.transform;
        var slider = sliderGo.AddComponent<Slider>();
        slider.direction = Slider.Direction.LeftToRight;
        slider.minValue = min;
        slider.maxValue = max;
        slider.transition = Selectable.Transition.None;

        var trackImg = CreatePanel(sliderRect, "Track", UITheme.Surface2, 200, 5);
        var trackRect = trackImg.rectTransform;
        trackRect.anchorMin = new Vector2(0f, 0.3f);
        trackRect.anchorMax = new Vector2(1f, 0.7f);
        trackRect.offsetMin = Vector2.zero;
        trackRect.offsetMax = Vector2.zero;

        var fillAreaRect = CreateFullRect(sliderRect, "Fill Area");
        fillAreaRect.anchorMin = new Vector2(0f, 0.3f);
        fillAreaRect.anchorMax = new Vector2(1f, 0.7f);
        fillAreaRect.offsetMin = Vector2.zero;
        fillAreaRect.offsetMax = Vector2.zero;

        var fillImg = CreatePanel(fillAreaRect, "Fill", UITheme.Accent, 200, 5);
        var fillRect = fillImg.rectTransform;
        fillRect.anchorMin = new Vector2(0f, 0f);
        fillRect.anchorMax = new Vector2(1f, 1f);
        fillRect.offsetMin = Vector2.zero;
        fillRect.offsetMax = Vector2.zero;
        slider.fillRect = fillRect;

        var handleAreaRect = CreateFullRect(sliderRect, "Handle Slide Area");

        var handleImg = CreatePanel(handleAreaRect, "Handle", UITheme.Text, 20, 10);
        var handleRect = handleImg.rectTransform;
        handleRect.sizeDelta = new Vector2(20f, 20f);
        var handleHover = handleImg.gameObject.AddComponent<HoverEffect>();
        handleHover.TargetImage = handleImg;
        handleHover.IdleColor = UITheme.Text;
        handleHover.HoverColor = UITheme.AccentHover;
        handleHover.SelectedColor = UITheme.AccentHover;
        slider.handleRect = handleRect;
        slider.targetGraphic = handleImg;

        var valueLabel = CreateLabel(containerRect, defaultValue.ToString(format), 14, UITheme.MutedText);
        var valueLayoutEl = valueLabel.Graphic.gameObject.AddComponent<LayoutElement>();
        valueLayoutEl.preferredWidth = 56;

        slider.value = defaultValue;
        slider.onValueChanged.AddListener(v =>
        {
            valueLabel.SetText(v.ToString(format));
            onChanged?.Invoke(v);
        });
    }
}
