using System;
using System.Collections.Generic;
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

    public void SetAlignRight()
    {
        switch (Graphic)
        {
            case TextMeshProUGUI tmp:
                tmp.alignment = TextAlignmentOptions.MidlineRight;
                break;
            case Text legacy:
                legacy.alignment = TextAnchor.MiddleRight;
                break;
        }
    }
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
            // The game's default material for this font asset may have its own tinted
            // _FaceColor baked in, which multiplies against our vertex color below and can
            // turn every label black regardless of what we set `.color` to. Force a neutral
            // white base on our own material instance so `.color` is the only thing tinting.
            tmp.fontMaterial.SetColor("_FaceColor", Color.white);
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

    public static SidebarTab CreateSidebarTab(RectTransform parent, string label, string iconName, Action onClick)
    {
        var go = new GameObject($"Tab_{label}", typeof(RectTransform));
        go.transform.SetParent(parent, false);

        var layoutEl = go.AddComponent<LayoutElement>();
        layoutEl.preferredHeight = 30;
        layoutEl.flexibleWidth = 1;

        var img = go.AddComponent<Image>();
        img.sprite = UITheme.RoundedRect(40, 40, 7);
        img.type = Image.Type.Sliced;
        img.color = new Color(0f, 0f, 0f, 0f);

        var button = go.AddComponent<Button>();
        button.transition = Selectable.Transition.None;
        button.onClick.AddListener(() => onClick?.Invoke());

        var icon = Icons.Load(iconName);
        Image iconImg = null;
        var labelInset = 12f;
        if (icon != null)
        {
            var iconGo = new GameObject("Icon", typeof(RectTransform));
            iconGo.transform.SetParent(go.transform, false);
            var iconRect = (RectTransform)iconGo.transform;
            iconRect.anchorMin = new Vector2(0f, 0.5f);
            iconRect.anchorMax = new Vector2(0f, 0.5f);
            iconRect.pivot = new Vector2(0f, 0.5f);
            iconRect.sizeDelta = new Vector2(14f, 14f);
            iconRect.anchoredPosition = new Vector2(10f, 0f);

            iconImg = iconGo.AddComponent<Image>();
            iconImg.sprite = icon;
            iconImg.color = UITheme.MutedText;
            iconImg.raycastTarget = false;

            labelInset = 10f + 14f + 6f; // icon left inset + icon width + gap before label
        }

        var labelHandle = CreateLabel(go.transform, label, 13, UITheme.MutedText);
        var labelRect = labelHandle.Graphic.rectTransform;
        Stretch(labelRect);
        labelRect.offsetMin = new Vector2(labelInset, 0);
        labelRect.offsetMax = new Vector2(-12, 0);

        var hover = go.AddComponent<HoverEffect>();
        hover.TargetImage = img;
        hover.TargetLabel = labelHandle.Graphic;
        hover.TargetIcon = iconImg;
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
        vlg.padding = new RectOffset(0, 0, 6, 6);
        vlg.spacing = 2;
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
        hlg.padding = new RectOffset(14, 14, 0, 0);
        hlg.spacing = 10;
        hlg.childAlignment = TextAnchor.MiddleLeft;
        hlg.childControlWidth = true;
        hlg.childControlHeight = true;
        hlg.childForceExpandWidth = false;
        // Must stay false: HorizontalLayoutGroup folds its own childForceExpand flag into the
        // flexible-size it reports to ITS parent (RowList), so leaving this true made every row
        // report flexibleHeight=1 upward and get stretched to fill the whole panel evenly.
        hlg.childForceExpandHeight = false;

        return (RectTransform)go.transform;
    }

    private static void CreateRowLabel(RectTransform row, string text)
    {
        var label = CreateLabel(row, text, 13, UITheme.Text);
        var layoutEl = label.Graphic.gameObject.AddComponent<LayoutElement>();
        layoutEl.flexibleWidth = 1;
    }

    public static void CreateNoteRow(RectTransform parent, string text)
    {
        var row = CreateRow(parent);
        var label = CreateLabel(row, text, 10, UITheme.MutedText);
        var layoutEl = label.Graphic.gameObject.AddComponent<LayoutElement>();
        layoutEl.flexibleWidth = 1;
    }

    public static void CreateInfoRow(RectTransform parent, string label, string value)
    {
        var row = CreateRow(parent);
        CreateRowLabel(row, label);

        var valueLabel = CreateLabel(row, value, 12, UITheme.MutedText);
        valueLabel.SetAlignRight();
        var layoutEl = valueLabel.Graphic.gameObject.AddComponent<LayoutElement>();
        layoutEl.preferredWidth = 180;
    }

    public static void CreateLinkRow(RectTransform parent, string label, string url)
    {
        var row = CreateRow(parent);
        CreateRowLabel(row, label);

        var linkGo = new GameObject("Link", typeof(RectTransform));
        linkGo.transform.SetParent(row, false);
        var linkLayoutEl = linkGo.AddComponent<LayoutElement>();
        linkLayoutEl.preferredWidth = 180;
        linkLayoutEl.preferredHeight = UITheme.RowHeight;

        var img = linkGo.AddComponent<Image>();
        img.color = new Color(0f, 0f, 0f, 0f);
        img.raycastTarget = true;

        var button = linkGo.AddComponent<Button>();
        button.transition = Selectable.Transition.None;
        button.targetGraphic = img;
        button.onClick.AddListener(() =>
        {
            Application.OpenURL(url);
            Plugin.Logger.LogInfo($"[UI] Opening {url}");
        });

        var linkLabel = CreateLabel(linkGo.transform, url, 12, UITheme.Accent);
        Stretch(linkLabel.Graphic.rectTransform);
        linkLabel.SetAlignRight();
    }

    public static void CreateToggleRow(RectTransform parent, string label, bool defaultValue, Action<bool> onChanged)
    {
        const float pillWidth = 36f;
        const float pillHeight = 18f;
        const float knobSize = 14f;
        const float margin = 2f;
        var offX = margin + knobSize / 2f;
        var onX = pillWidth - margin - knobSize / 2f;

        var row = CreateRow(parent);
        CreateRowLabel(row, label);

        var pillGo = new GameObject("Toggle", typeof(RectTransform));
        pillGo.transform.SetParent(row, false);
        var pillLayoutEl = pillGo.AddComponent<LayoutElement>();
        pillLayoutEl.preferredWidth = pillWidth;
        pillLayoutEl.preferredHeight = pillHeight;

        var pillImg = pillGo.AddComponent<Image>();
        pillImg.sprite = UITheme.RoundedRect((int)pillWidth, (int)pillHeight, (int)(pillHeight / 2f));
        pillImg.type = Image.Type.Sliced;
        pillImg.color = defaultValue ? UITheme.Green : UITheme.Surface2;

        var knobGo = new GameObject("Knob", typeof(RectTransform));
        knobGo.transform.SetParent(pillGo.transform, false);
        var knobRect = (RectTransform)knobGo.transform;
        knobRect.anchorMin = new Vector2(0f, 0.5f);
        knobRect.anchorMax = new Vector2(0f, 0.5f);
        knobRect.pivot = new Vector2(0.5f, 0.5f);
        knobRect.sizeDelta = new Vector2(knobSize, knobSize);
        var knobImg = knobGo.AddComponent<Image>();
        knobImg.sprite = UITheme.RoundedRect((int)knobSize, (int)knobSize, (int)(knobSize / 2f));
        knobImg.color = UITheme.Text;

        var toggle = pillGo.AddComponent<ToggleSwitch>();
        toggle.Pill = pillImg;
        toggle.Knob = knobRect;
        toggle.OffPos = new Vector2(offX, 0f);
        toggle.OnPos = new Vector2(onX, 0f);
        knobRect.anchoredPosition = defaultValue ? toggle.OnPos : toggle.OffPos;
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
        containerLayoutEl.preferredWidth = 170;
        containerLayoutEl.preferredHeight = 18;
        var containerRect = (RectTransform)containerGo.transform;
        var containerHlg = containerGo.AddComponent<HorizontalLayoutGroup>();
        containerHlg.spacing = 8;
        containerHlg.childAlignment = TextAnchor.MiddleLeft;
        containerHlg.childControlWidth = true;
        containerHlg.childControlHeight = true;
        containerHlg.childForceExpandWidth = false;
        // Same leak as CreateRow's HorizontalLayoutGroup -- must stay false.
        containerHlg.childForceExpandHeight = false;

        var sliderGo = new GameObject("Slider", typeof(RectTransform));
        sliderGo.transform.SetParent(containerRect, false);
        var sliderLayoutEl = sliderGo.AddComponent<LayoutElement>();
        sliderLayoutEl.preferredWidth = 110;
        sliderLayoutEl.preferredHeight = 14;
        sliderLayoutEl.flexibleWidth = 1;
        var sliderRect = (RectTransform)sliderGo.transform;
        var slider = sliderGo.AddComponent<Slider>();
        slider.direction = Slider.Direction.LeftToRight;
        slider.minValue = min;
        slider.maxValue = max;
        slider.transition = Selectable.Transition.None;

        var trackImg = CreatePanel(sliderRect, "Track", UITheme.Surface2, 160, 4);
        var trackRect = trackImg.rectTransform;
        trackRect.anchorMin = new Vector2(0f, 0.35f);
        trackRect.anchorMax = new Vector2(1f, 0.65f);
        trackRect.offsetMin = Vector2.zero;
        trackRect.offsetMax = Vector2.zero;

        var fillAreaRect = CreateFullRect(sliderRect, "Fill Area");
        fillAreaRect.anchorMin = new Vector2(0f, 0.35f);
        fillAreaRect.anchorMax = new Vector2(1f, 0.65f);
        fillAreaRect.offsetMin = Vector2.zero;
        fillAreaRect.offsetMax = Vector2.zero;

        var fillImg = CreatePanel(fillAreaRect, "Fill", UITheme.Accent, 160, 4);
        var fillRect = fillImg.rectTransform;
        fillRect.anchorMin = new Vector2(0f, 0f);
        fillRect.anchorMax = new Vector2(1f, 1f);
        fillRect.offsetMin = Vector2.zero;
        fillRect.offsetMax = Vector2.zero;
        slider.fillRect = fillRect;

        var handleAreaRect = CreateFullRect(sliderRect, "Handle Slide Area");

        var handleImg = CreatePanel(handleAreaRect, "Handle", UITheme.Text, 10, 5);
        var handleRect = handleImg.rectTransform;
        handleRect.sizeDelta = new Vector2(10f, 10f);
        var handleHover = handleImg.gameObject.AddComponent<HoverEffect>();
        handleHover.TargetImage = handleImg;
        handleHover.IdleColor = UITheme.Text;
        handleHover.HoverColor = UITheme.AccentHover;
        handleHover.SelectedColor = UITheme.AccentHover;
        slider.handleRect = handleRect;
        slider.targetGraphic = handleImg;

        var valueLabel = CreateLabel(containerRect, defaultValue.ToString(format), 12, UITheme.MutedText);
        var valueLayoutEl = valueLabel.Graphic.gameObject.AddComponent<LayoutElement>();
        valueLayoutEl.preferredWidth = 44;

        slider.value = defaultValue;
        slider.onValueChanged.AddListener(v =>
        {
            valueLabel.SetText(v.ToString(format));
            onChanged?.Invoke(v);
        });
    }

    private static SimpleDropdown CreateDropdown(RectTransform parent, List<string> options, int defaultIndex, float width)
    {
        var ddGo = new GameObject("Dropdown", typeof(RectTransform));
        ddGo.transform.SetParent(parent, false);
        var ddLayoutEl = ddGo.AddComponent<LayoutElement>();
        ddLayoutEl.preferredWidth = width;
        ddLayoutEl.preferredHeight = 20f;

        var ddImg = ddGo.AddComponent<Image>();
        ddImg.sprite = UITheme.RoundedRect(40, 20, 6);
        ddImg.type = Image.Type.Sliced;
        ddImg.color = UITheme.Surface2;

        var captionLabel = CreateLabel(ddGo.transform, options.Count > 0 ? options[defaultIndex] : "", 12, UITheme.Text);
        var captionRect = captionLabel.Graphic.rectTransform;
        Stretch(captionRect);
        captionRect.offsetMin = new Vector2(8f, 0f);
        captionRect.offsetMax = new Vector2(-18f, 0f);

        var arrow = Icons.Load("chevrondown");
        if (arrow != null)
        {
            var arrowGo = new GameObject("Arrow", typeof(RectTransform));
            arrowGo.transform.SetParent(ddGo.transform, false);
            var arrowRect = (RectTransform)arrowGo.transform;
            arrowRect.anchorMin = new Vector2(1f, 0.5f);
            arrowRect.anchorMax = new Vector2(1f, 0.5f);
            arrowRect.pivot = new Vector2(1f, 0.5f);
            arrowRect.sizeDelta = new Vector2(9f, 9f);
            arrowRect.anchoredPosition = new Vector2(-7f, 0f);
            var arrowImg = arrowGo.AddComponent<Image>();
            arrowImg.sprite = arrow;
            arrowImg.color = UITheme.MutedText;
            arrowImg.raycastTarget = false;
        }

        var dropdown = ddGo.AddComponent<SimpleDropdown>();
        dropdown.Options = options;
        dropdown.Value = Mathf.Clamp(defaultIndex, 0, Mathf.Max(options.Count - 1, 0));
        dropdown.OnCaptionChanged = captionLabel.SetText;

        return dropdown;
    }

    private static TMP_InputField CreateNumberInput(RectTransform parent, float defaultValue, string format, float width)
    {
        var go = new GameObject("NumberInput", typeof(RectTransform));
        go.transform.SetParent(parent, false);
        var layoutEl = go.AddComponent<LayoutElement>();
        layoutEl.preferredWidth = width;
        layoutEl.preferredHeight = 20f;

        var bgImg = go.AddComponent<Image>();
        bgImg.sprite = UITheme.RoundedRect(40, 20, 6);
        bgImg.type = Image.Type.Sliced;
        bgImg.color = UITheme.Surface2;

        if (!TmpAvailable())
        {
            Plugin.Logger.LogWarning("[UI] Number input requires TMP; skipping (no TMP font asset was found).");
            return null;
        }

        var textAreaRect = CreateFullRect(go.transform, "Text Area");
        textAreaRect.offsetMin = new Vector2(6f, 2f);
        textAreaRect.offsetMax = new Vector2(-6f, -2f);
        textAreaRect.gameObject.AddComponent<RectMask2D>();

        var textLabel = CreateLabel(textAreaRect, defaultValue.ToString(format), 12, UITheme.Text);
        Stretch(textLabel.Graphic.rectTransform);

        var inputField = go.AddComponent<TMP_InputField>();
        inputField.targetGraphic = bgImg;
        inputField.textViewport = textAreaRect;
        inputField.textComponent = (TMP_Text)textLabel.Graphic;
        inputField.contentType = TMP_InputField.ContentType.IntegerNumber;
        inputField.text = defaultValue.ToString(format);

        return inputField;
    }

    private static void AddExecuteButton(RectTransform row, Action onClick)
    {
        var go = new GameObject("Execute", typeof(RectTransform));
        go.transform.SetParent(row, false);
        var layoutEl = go.AddComponent<LayoutElement>();
        layoutEl.preferredWidth = 56f;
        layoutEl.preferredHeight = 20f;

        var img = go.AddComponent<Image>();
        img.sprite = UITheme.RoundedRect(40, 20, 6);
        img.type = Image.Type.Sliced;
        img.color = UITheme.Accent;

        var button = go.AddComponent<Button>();
        button.transition = Selectable.Transition.None;
        button.targetGraphic = img;
        button.onClick.AddListener(() => onClick?.Invoke());

        var hover = go.AddComponent<HoverEffect>();
        hover.TargetImage = img;
        hover.IdleColor = UITheme.Accent;
        hover.HoverColor = UITheme.AccentHover;
        hover.SelectedColor = UITheme.AccentHover;

        var label = CreateLabel(go.transform, "Execute", 11, UITheme.Base);
        Stretch(label.Graphic.rectTransform);
        switch (label.Graphic)
        {
            case TextMeshProUGUI tmp:
                tmp.alignment = TextAlignmentOptions.Center;
                break;
            case Text legacy:
                legacy.alignment = TextAnchor.MiddleCenter;
                break;
        }
    }

    // Pick an option, click Execute.
    public static void CreateDropdownActionRow(RectTransform parent, string label, List<string> options, Action<int> onExecute)
    {
        var row = CreateRow(parent);
        CreateRowLabel(row, label);

        var dropdown = CreateDropdown(row, options, 0, 130f);

        AddExecuteButton(row, () => onExecute?.Invoke(dropdown.Value));
    }

    // Pick an option, type an amount, click Execute.
    public static void CreateDropdownAmountActionRow(RectTransform parent, string label, List<string> options, float defaultAmount, string format, Action<int, float> onExecute)
    {
        var row = CreateRow(parent);
        CreateRowLabel(row, label);

        var dropdown = CreateDropdown(row, options, 0, 90f);
        var numberInput = CreateNumberInput(row, defaultAmount, format, 50f);
        if (numberInput == null)
            return;

        AddExecuteButton(row, () =>
        {
            float.TryParse(numberInput.text, out var amount);
            onExecute?.Invoke(dropdown.Value, amount);
        });
    }

    // Type a number, click Execute.
    public static void CreateNumberActionRow(RectTransform parent, string label, float defaultValue, string format, Action<float> onExecute)
    {
        var row = CreateRow(parent);
        CreateRowLabel(row, label);

        var numberInput = CreateNumberInput(row, defaultValue, format, 70f);
        if (numberInput == null)
            return;

        AddExecuteButton(row, () =>
        {
            float.TryParse(numberInput.text, out var value);
            onExecute?.Invoke(value);
        });
    }
}
