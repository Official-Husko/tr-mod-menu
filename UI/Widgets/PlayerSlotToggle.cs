using System;
using tr_mod_menu.UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace tr_mod_menu.UI.Widgets;

// A tickable chip representing one online player slot. Always visible; grays itself out and
// forces itself off whenever that slot isn't occupied by a connected player, rather than
// hiding. Polls connectivity periodically (rather than once at build time) since a player can
// join/leave while the menu stays open.
//
// Ticking a chip is currently only ever recorded (see PlayerCheats.SelectedOnlinePlayers), not
// consumed by any cheat yet -- see CLAUDE.md: "Cheats never target other online players" for why
// (it would require the target to also run this mod).
internal class PlayerSlotToggle : MonoBehaviour, IPointerClickHandler
{
    public int PlayerNum;
    public Color PlayerColor = UITheme.Surface2;
    public Func<int, bool> IsConnected;
    public Action<int, bool> OnToggled;
    public bool StaticallyDisabled; // true when CompatibilityGate has cheats off entirely

    public Image Background;
    public Graphic Label;
    public Image Dot;

    public bool Selected { get; private set; }

    private bool _connected;
    private float _checkTimer;

    public void OnPointerClick(PointerEventData eventData)
    {
        if (StaticallyDisabled || !_connected)
            return;

        Selected = !Selected;
        OnToggled?.Invoke(PlayerNum, Selected);
    }

    private void Update()
    {
        if (!StaticallyDisabled)
        {
            _checkTimer -= Time.unscaledDeltaTime;
            if (_checkTimer <= 0f)
            {
                _checkTimer = 0.5f;
                var nowConnected = IsConnected?.Invoke(PlayerNum) ?? false;
                if (nowConnected != _connected)
                {
                    _connected = nowConnected;
                    if (!_connected && Selected)
                    {
                        Selected = false;
                        OnToggled?.Invoke(PlayerNum, false);
                    }
                }
            }
        }

        var bgTarget = StaticallyDisabled || !_connected
            ? UITheme.Mantle
            : (Selected ? PlayerColor : UITheme.Surface2);
        Background.color = Color.Lerp(Background.color, bgTarget, Time.unscaledDeltaTime * UITheme.AnimSpeed);

        var labelTarget = StaticallyDisabled || !_connected
            ? UITheme.Border
            : (Selected ? UITheme.Base : PlayerColor);
        Label.color = Color.Lerp(Label.color, labelTarget, Time.unscaledDeltaTime * UITheme.AnimSpeed);

        if (Dot != null)
        {
            var dotTarget = StaticallyDisabled ? UITheme.Border : (_connected ? UITheme.Green : UITheme.StatusRed);
            Dot.color = Color.Lerp(Dot.color, dotTarget, Time.unscaledDeltaTime * UITheme.AnimSpeed);
        }
    }
}
