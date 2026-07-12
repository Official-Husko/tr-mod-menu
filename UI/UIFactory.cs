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

    public static UILabel CreateLabel(Transform parent, string text, int fontSize, Color color, bool wrap = false)
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
            tmp.alignment = wrap ? TextAlignmentOptions.TopLeft : TextAlignmentOptions.MidlineLeft;
            tmp.enableWordWrapping = wrap;
            tmp.overflowMode = TextOverflowModes.Overflow;
            tmp.raycastTarget = false;
            return new UILabel(tmp, s => tmp.text = s);
        }

        var legacyText = go.AddComponent<Text>();
        legacyText.font = _legacyFont;
        legacyText.text = text;
        legacyText.fontSize = fontSize;
        legacyText.color = color;
        legacyText.alignment = wrap ? TextAnchor.UpperLeft : TextAnchor.MiddleLeft;
        legacyText.horizontalOverflow = wrap ? HorizontalWrapMode.Wrap : HorizontalWrapMode.Overflow;
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
        vlg.spacing = 4;
        vlg.childAlignment = TextAnchor.UpperLeft;
        vlg.childControlHeight = false; // cards size themselves via ContentSizeFitter; see CreateRow
        vlg.childControlWidth = true;
        vlg.childForceExpandHeight = false;
        vlg.childForceExpandWidth = true;
        return rect;
    }

    // Wraps every row in its own rounded, darker-than-the-panel "card" -- gives each cheat a
    // capsuled feel instead of sitting as a bare line directly on the panel background. When
    // `note` is set, a thin separator + a small caption are appended inside the *same* card,
    // below the row, rather than becoming a separate row of their own.
    private static RectTransform CreateRow(RectTransform parent, string iconName = null, string note = null)
    {
        var cardGo = new GameObject("Card", typeof(RectTransform));
        cardGo.transform.SetParent(parent, false);

        var cardImg = cardGo.AddComponent<Image>();
        cardImg.sprite = UITheme.RoundedRect(40, 40, 8);
        cardImg.type = Image.Type.Sliced;
        cardImg.color = UITheme.Mantle;

        var cardVlg = cardGo.AddComponent<VerticalLayoutGroup>();
        cardVlg.padding = new RectOffset(0, 0, 4, 4);
        cardVlg.spacing = 2;
        cardVlg.childAlignment = TextAnchor.UpperLeft;
        cardVlg.childControlWidth = true;
        // False, same as everywhere else in this file: with this true, a card whose row is
        // itself a HorizontalLayoutGroup would fold *its own* childForceExpand flag into the
        // flexible-size the card reports to RowList, stretching every card to fill the panel.
        cardVlg.childControlHeight = false;
        cardVlg.childForceExpandWidth = true;
        cardVlg.childForceExpandHeight = false;

        // The card has no fixed height of its own -- it must grow to fit its row (+ optional
        // note) -- so ITS OWN preferred height needs to come from a ContentSizeFitter, not a
        // LayoutElement (RowList reads the card's actual current rect height for stacking,
        // since RowList's own childControlHeight is also false -- see CreateRowList above).
        var fitter = cardGo.AddComponent<ContentSizeFitter>();
        fitter.verticalFit = ContentSizeFitter.FitMode.PreferredSize;

        var rowGo = new GameObject("Row", typeof(RectTransform));
        rowGo.transform.SetParent(cardGo.transform, false);
        ((RectTransform)rowGo.transform).sizeDelta = new Vector2(0f, UITheme.RowHeight);

        var hlg = rowGo.AddComponent<HorizontalLayoutGroup>();
        hlg.padding = new RectOffset(10, 10, 0, 0);
        hlg.spacing = 8;
        hlg.childAlignment = TextAnchor.MiddleLeft;
        hlg.childControlWidth = true;
        hlg.childControlHeight = true;
        hlg.childForceExpandWidth = false;
        hlg.childForceExpandHeight = false;

        var icon = iconName != null ? Icons.Load(iconName) : null;
        if (icon != null)
        {
            var iconGo = new GameObject("Icon", typeof(RectTransform));
            iconGo.transform.SetParent(rowGo.transform, false);
            var iconLayoutEl = iconGo.AddComponent<LayoutElement>();
            iconLayoutEl.preferredWidth = 14f;
            iconLayoutEl.preferredHeight = 14f;
            var iconImg = iconGo.AddComponent<Image>();
            iconImg.sprite = icon;
            iconImg.color = UITheme.MutedText;
            iconImg.raycastTarget = false;
        }

        if (note != null)
        {
            var sep = CreatePanel(cardGo.transform, "Separator", UITheme.Border, 4, 0);
            sep.rectTransform.sizeDelta = new Vector2(0f, 1f);

            var noteGo = new GameObject("Note", typeof(RectTransform));
            noteGo.transform.SetParent(cardGo.transform, false);
            ((RectTransform)noteGo.transform).sizeDelta = new Vector2(0f, 24f);

            var noteLabel = CreateLabel(noteGo.transform, note, 10, UITheme.MutedText, wrap: true);
            var noteLabelRect = noteLabel.Graphic.rectTransform;
            Stretch(noteLabelRect);
            noteLabelRect.offsetMin = new Vector2(10f, 2f);
            noteLabelRect.offsetMax = new Vector2(-10f, -2f);
        }

        return (RectTransform)rowGo.transform;
    }

    private static void CreateRowLabel(RectTransform row, string text)
    {
        var label = CreateLabel(row, text, 13, UITheme.Text);
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

    public static void CreateToggleRow(RectTransform parent, string label, string iconName, bool defaultValue, Action<bool> onChanged, string note = null)
    {
        const float pillWidth = 36f;
        const float pillHeight = 18f;
        const float knobSize = 14f;
        const float margin = 2f;
        var offX = margin + knobSize / 2f;
        var onX = pillWidth - margin - knobSize / 2f;

        var row = CreateRow(parent, iconName, note);
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

    // `disabled` grays out the slider and blocks dragging without hiding the row -- same
    // purpose as CreateNumberActionRow's `disabled`: show a real cheat exists but is currently
    // blocked (e.g. by CompatibilityGate) rather than making it look like a no-op placeholder.
    public static void CreateSliderRow(RectTransform parent, string label, string iconName, float min, float max, float defaultValue, string format, Action<float> onChanged, bool disabled = false, string note = null)
    {
        var row = CreateRow(parent, iconName, note);
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
        slider.interactable = !disabled;

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

        var fillImg = CreatePanel(fillAreaRect, "Fill", disabled ? UITheme.Surface2 : UITheme.Accent, 160, 4);
        var fillRect = fillImg.rectTransform;
        fillRect.anchorMin = new Vector2(0f, 0f);
        fillRect.anchorMax = new Vector2(1f, 1f);
        fillRect.offsetMin = Vector2.zero;
        fillRect.offsetMax = Vector2.zero;
        slider.fillRect = fillRect;

        var handleAreaRect = CreateFullRect(sliderRect, "Handle Slide Area");

        var handleColor = disabled ? UITheme.MutedText : UITheme.Text;
        var handleImg = CreatePanel(handleAreaRect, "Handle", handleColor, 10, 5);
        var handleRect = handleImg.rectTransform;
        handleRect.sizeDelta = new Vector2(10f, 10f);
        var handleHover = handleImg.gameObject.AddComponent<HoverEffect>();
        handleHover.TargetImage = handleImg;
        handleHover.IdleColor = handleColor;
        handleHover.HoverColor = disabled ? handleColor : UITheme.AccentHover;
        handleHover.SelectedColor = handleHover.HoverColor;
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

    private static void AddExecuteButton(RectTransform row, Action onClick, bool disabled = false)
    {
        var go = new GameObject("Execute", typeof(RectTransform));
        go.transform.SetParent(row, false);
        var layoutEl = go.AddComponent<LayoutElement>();
        layoutEl.preferredWidth = 56f;
        layoutEl.preferredHeight = 20f;

        var idleColor = disabled ? UITheme.Surface2 : UITheme.Accent;

        var img = go.AddComponent<Image>();
        img.sprite = UITheme.RoundedRect(40, 20, 6);
        img.type = Image.Type.Sliced;
        img.color = idleColor;

        var button = go.AddComponent<Button>();
        button.transition = Selectable.Transition.None;
        button.targetGraphic = img;
        button.interactable = !disabled;
        button.onClick.AddListener(() => onClick?.Invoke());

        var hover = go.AddComponent<HoverEffect>();
        hover.TargetImage = img;
        hover.IdleColor = idleColor;
        hover.HoverColor = disabled ? idleColor : UITheme.AccentHover;
        hover.SelectedColor = hover.HoverColor;

        var label = CreateLabel(go.transform, "Execute", 11, disabled ? UITheme.MutedText : UITheme.Base);
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
    public static void CreateDropdownActionRow(RectTransform parent, string label, string iconName, List<string> options, Action<int> onExecute, string note = null)
    {
        var row = CreateRow(parent, iconName, note);
        CreateRowLabel(row, label);

        var dropdown = CreateDropdown(row, options, 0, 130f);

        AddExecuteButton(row, () => onExecute?.Invoke(dropdown.Value));
    }

    // Pick an option, type an amount, click Execute.
    public static void CreateDropdownAmountActionRow(RectTransform parent, string label, string iconName, List<string> options, float defaultAmount, string format, Action<int, float> onExecute, string note = null)
    {
        var row = CreateRow(parent, iconName, note);
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

    // Type a number, click Execute. `disabled` grays out the field and button without
    // hiding the row -- used to show a real cheat exists but is currently blocked
    // (e.g. by CompatibilityGate) rather than making it look like a no-op placeholder.
    public static void CreateNumberActionRow(RectTransform parent, string label, string iconName, float defaultValue, string format, Action<float> onExecute, bool disabled = false, string note = null)
    {
        var row = CreateRow(parent, iconName, note);
        CreateRowLabel(row, label);

        var numberInput = CreateNumberInput(row, defaultValue, format, 70f);
        if (numberInput == null)
            return;

        numberInput.interactable = !disabled;

        AddExecuteButton(row, () =>
        {
            float.TryParse(numberInput.text, out var value);
            onExecute?.Invoke(value);
        }, disabled);
    }

    // A row of tickable chips, one per online player slot, for "which connected players should
    // this cheat also apply to." Chips gray themselves out (and can't be ticked) whenever that
    // slot isn't occupied -- see PlayerSlotToggle, which polls connectivity live since a player
    // can join/leave while the menu stays open. `disabled` forces every chip permanently gray
    // (used when CompatibilityGate has cheats off entirely, since even checking slot occupancy
    // touches the same obfuscated player-array machinery the gate exists to guard against).
    //
    // Not currently called anywhere -- kept as reusable infrastructure for a future cheat that
    // can legitimately affect other connected players. See CLAUDE.md: "Cheats never target
    // other online players" for why this isn't wired to the speed cheats.
    public static void CreatePlayerSelectorBar(RectTransform parent, string label, string iconName, int[] playerNums, Func<int, bool> isConnected, Action<int, bool> onToggled, bool disabled = false)
    {
        var row = CreateRow(parent, iconName);
        CreateRowLabel(row, label);

        for (var i = 0; i < playerNums.Length; i++)
        {
            var num = playerNums[i];
            var playerColor = UITheme.PlayerColors[i % UITheme.PlayerColors.Length];

            var chipGo = new GameObject($"PlayerSlot_{num}", typeof(RectTransform));
            chipGo.transform.SetParent(row, false);
            var layoutEl = chipGo.AddComponent<LayoutElement>();
            layoutEl.preferredWidth = 40f;
            layoutEl.preferredHeight = 20f;

            var img = chipGo.AddComponent<Image>();
            img.sprite = UITheme.RoundedRect(40, 20, 6);
            img.type = Image.Type.Sliced;
            img.color = UITheme.Mantle;

            // Small connection-status dot on the left, independent of the tick/selection state.
            var dotGo = new GameObject("Dot", typeof(RectTransform));
            dotGo.transform.SetParent(chipGo.transform, false);
            var dotRect = (RectTransform)dotGo.transform;
            dotRect.anchorMin = new Vector2(0f, 0.5f);
            dotRect.anchorMax = new Vector2(0f, 0.5f);
            dotRect.pivot = new Vector2(0.5f, 0.5f);
            dotRect.sizeDelta = new Vector2(6f, 6f);
            dotRect.anchoredPosition = new Vector2(8f, 0f);
            var dotImg = dotGo.AddComponent<Image>();
            dotImg.sprite = UITheme.RoundedRect(6, 6, 3);
            dotImg.color = UITheme.StatusRed;
            dotImg.raycastTarget = false;

            var labelHandle = CreateLabel(chipGo.transform, $"P{num}", 11, UITheme.Border);
            var labelRect = labelHandle.Graphic.rectTransform;
            Stretch(labelRect);
            labelRect.offsetMin = new Vector2(13f, 0f);
            labelRect.offsetMax = new Vector2(-3f, 0f);
            switch (labelHandle.Graphic)
            {
                case TextMeshProUGUI tmp:
                    tmp.alignment = TextAlignmentOptions.Center;
                    break;
                case Text legacy:
                    legacy.alignment = TextAnchor.MiddleCenter;
                    break;
            }

            var slot = chipGo.AddComponent<PlayerSlotToggle>();
            slot.PlayerNum = num;
            slot.PlayerColor = playerColor;
            slot.Background = img;
            slot.Label = labelHandle.Graphic;
            slot.Dot = dotImg;
            slot.IsConnected = isConnected;
            slot.OnToggled = onToggled;
            slot.StaticallyDisabled = disabled;
        }
    }

    // Just a label + Execute button, no input control of its own -- for one-shot actions.
    public static void CreateButtonRow(RectTransform parent, string label, string iconName, Action onExecute, bool disabled = false, string note = null)
    {
        var row = CreateRow(parent, iconName, note);
        CreateRowLabel(row, label);
        AddExecuteButton(row, onExecute, disabled);
    }
}
