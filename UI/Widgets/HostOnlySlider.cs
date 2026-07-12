using System;
using UnityEngine;
using UnityEngine.UI;

namespace tr_mod_menu.UI.Widgets;

// Attached to a slider row whose control should only be interactable while a caller-supplied
// condition holds -- currently: are we the session host, or playing solo (see
// Cheats/WorldCheats.SetTimeScale). Polls rather than checking once at build time, since
// online/host status can change while the menu stays open (join/leave a session, host
// migration). Only touches HoverEffect's target colors, never the handle Image directly -- the
// handle already has its own HoverEffect running an Update() of its own every frame, and two
// components independently Lerp-ing the same Image.color would fight each other.
internal class HostOnlySlider : MonoBehaviour
{
    public Slider Slider;
    public Image Fill;
    public HoverEffect HandleHover;
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

        Slider.interactable = _allowed;

        var fillTarget = _allowed ? UITheme.Accent : UITheme.Surface2;
        Fill.color = Color.Lerp(Fill.color, fillTarget, Time.unscaledDeltaTime * UITheme.AnimSpeed);

        var handleTarget = _allowed ? UITheme.Text : UITheme.MutedText;
        HandleHover.IdleColor = handleTarget;
        HandleHover.HoverColor = _allowed ? UITheme.AccentHover : handleTarget;
        HandleHover.SelectedColor = HandleHover.HoverColor;
    }
}
