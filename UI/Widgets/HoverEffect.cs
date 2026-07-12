using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace tr_mod_menu.UI.Widgets;

// Drives idle/hover/selected color lerps on an Image (and optionally its label).
// Reused by sidebar tabs (all three states) and the slider handle (idle/hover only).
internal class HoverEffect : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Image TargetImage;
    public Graphic TargetLabel;
    public Image TargetIcon;
    public Color IdleColor;
    public Color HoverColor;
    public Color SelectedColor;
    public Color IdleLabelColor;
    public Color HoverLabelColor;
    public Color SelectedLabelColor;
    public bool IsSelected;

    private bool _hovered;

    public void OnPointerEnter(PointerEventData eventData) => _hovered = true;
    public void OnPointerExit(PointerEventData eventData) => _hovered = false;

    private void Update()
    {
        var imageTarget = IsSelected ? SelectedColor : (_hovered ? HoverColor : IdleColor);
        TargetImage.color = Color.Lerp(TargetImage.color, imageTarget, Time.unscaledDeltaTime * UITheme.AnimSpeed);

        var labelTarget = IsSelected ? SelectedLabelColor : (_hovered ? HoverLabelColor : IdleLabelColor);

        if (TargetLabel != null)
            TargetLabel.color = Color.Lerp(TargetLabel.color, labelTarget, Time.unscaledDeltaTime * UITheme.AnimSpeed);

        if (TargetIcon != null)
            TargetIcon.color = Color.Lerp(TargetIcon.color, labelTarget, Time.unscaledDeltaTime * UITheme.AnimSpeed);
    }
}
