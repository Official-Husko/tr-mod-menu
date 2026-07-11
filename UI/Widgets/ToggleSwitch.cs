using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace tr_mod_menu.UI.Widgets;

// Bespoke pill+knob toggle. Needs two simultaneously-lerped properties (knob
// position and pill color), so a plain HoverEffect isn't enough for this one.
internal class ToggleSwitch : MonoBehaviour, IPointerClickHandler
{
    private static readonly Vector2 KnobOffPos = new(12f, 0f);
    private static readonly Vector2 KnobOnPos = new(32f, 0f);

    public Image Pill;
    public RectTransform Knob;
    public bool Value { get; private set; }
    public event Action<bool> OnValueChanged;

    private Vector2 _knobTarget;
    private Color _pillTarget;

    public void SetValue(bool value, bool notify = true)
    {
        Value = value;
        _knobTarget = value ? KnobOnPos : KnobOffPos;
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
