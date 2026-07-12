using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace tr_mod_menu.UI.Widgets;

// Same idea as HostOnlySlider, for a NumberInput+Execute row instead of a slider -- see that
// file for why this polls rather than checking once at build time. TMP_InputField is left on
// Unity's own default ColorTint Selectable transition (unlike every other control in this file,
// which explicitly opts out via Transition.None), so toggling its .interactable alone already
// dims it correctly with no extra work here. The Execute button uses Transition.None like
// everything else, so its HoverEffect target colors need updating by hand instead -- and, unlike
// the slider handle, its label Graphic has no HoverEffect of its own contesting it, so it's safe
// to set directly.
internal class HostOnlyNumberRow : MonoBehaviour
{
    public TMP_InputField NumberInput;
    public Button ExecuteButton;
    public HoverEffect ExecuteHover;
    public Graphic ExecuteLabel;
    public Func<bool> IsAllowed;

    private bool _allowed = true;
    private float _checkTimer;

    private void Update()
    {
        _checkTimer -= Time.unscaledDeltaTime;
        if (_checkTimer <= 0f)
        {
            _checkTimer = 0.5f;
            _allowed = IsAllowed?.Invoke() ?? true;
        }

        NumberInput.interactable = _allowed;
        ExecuteButton.interactable = _allowed;

        var idleColor = _allowed ? UITheme.Accent : UITheme.Surface2;
        ExecuteHover.IdleColor = idleColor;
        ExecuteHover.HoverColor = _allowed ? UITheme.AccentHover : idleColor;
        ExecuteHover.SelectedColor = ExecuteHover.HoverColor;
        ExecuteLabel.color = _allowed ? UITheme.Base : UITheme.MutedText;
    }
}
