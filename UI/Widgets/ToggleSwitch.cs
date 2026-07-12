using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace tr_mod_menu.UI.Widgets;

// Bespoke pill+knob toggle. Needs two simultaneously-lerped properties (knob
// position and pill color), so a plain HoverEffect isn't enough for this one.
// Off/On knob positions are supplied by the caller (UIFactory) rather than
// hardcoded here, so there is exactly one place that knows the pill/knob
// pixel sizes -- keeping a second copy in sync with UIFactory is what broke
// the knob position last time the pill was resized.
internal class ToggleSwitch : MonoBehaviour, IPointerClickHandler
{
    public Image Pill;
    public RectTransform Knob;
    public Vector2 OffPos;
    public Vector2 OnPos;
    public bool Value { get; private set; }
    public event Action<bool> OnValueChanged;

    private Vector2 _knobTarget;
    private Color _pillTarget;

    public void SetValue(bool value, bool notify = true)
    {
        Value = value;
        _knobTarget = value ? OnPos : OffPos;
        _pillTarget = value ? UITheme.Green : UITheme.Surface2;
        if (notify)
            OnValueChanged?.Invoke(value);
    }

    public void OnPointerClick(PointerEventData eventData) => SetValue(!Value);

    private void Update()
    {
        Knob.anchoredPosition = Vector2.Lerp(Knob.anchoredPosition, _knobTarget, Time.unscaledDeltaTime * 10f);
        Pill.color = Color.Lerp(Pill.color, _pillTarget, Time.unscaledDeltaTime * 10f);
    }
}
