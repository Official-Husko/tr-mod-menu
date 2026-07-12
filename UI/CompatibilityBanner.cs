using tr_mod_menu.Cheats;
using UnityEngine;
using UnityEngine.UI;

namespace tr_mod_menu.UI;

// Full-screen modal shown once at startup when CompatibilityGate detects a game version
// mismatch. Independent of MenuWindow -- it's shown immediately regardless of whether the
// player ever opens the menu, since the whole point is to warn before they go looking for
// cheats that are quietly disabled.
internal static class CompatibilityBanner
{
    private const float PanelWidth = 480f;
    private const float PanelHeight = 230f;

    public static void Show(RectTransform canvasRoot)
    {
        var backdrop = UIFactory.CreatePanel(canvasRoot, "CompatBackdrop", new Color(UITheme.Base.r, UITheme.Base.g, UITheme.Base.b, 0.85f), 4, 0);
        UIFactory.Stretch(backdrop.rectTransform);
        backdrop.raycastTarget = true;

        var panelGo = new GameObject("CompatPanel", typeof(RectTransform));
        panelGo.transform.SetParent(canvasRoot, false);
        var panelRect = (RectTransform)panelGo.transform;
        panelRect.anchorMin = new Vector2(0.5f, 0.5f);
        panelRect.anchorMax = new Vector2(0.5f, 0.5f);
        panelRect.pivot = new Vector2(0.5f, 0.5f);
        panelRect.sizeDelta = new Vector2(PanelWidth, PanelHeight);
        panelRect.anchoredPosition = Vector2.zero;

        var panelImg = panelGo.AddComponent<Image>();
        panelImg.sprite = UITheme.RoundedRect(64, 64, 12);
        panelImg.type = Image.Type.Sliced;
        panelImg.color = UITheme.Surface;
        panelImg.raycastTarget = true;

        var accentBar = UIFactory.CreatePanel(panelRect, "AccentBar", UITheme.Red, 4, 0);
        var accentRect = accentBar.rectTransform;
        accentRect.anchorMin = new Vector2(0f, 1f);
        accentRect.anchorMax = new Vector2(1f, 1f);
        accentRect.pivot = new Vector2(0.5f, 1f);
        accentRect.sizeDelta = new Vector2(0f, 4f);
        accentRect.anchoredPosition = Vector2.zero;

        var title = UIFactory.CreateLabel(panelRect, "Compatibility Warning", 16, UITheme.Red);
        var titleRect = title.Graphic.rectTransform;
        titleRect.anchorMin = new Vector2(0f, 1f);
        titleRect.anchorMax = new Vector2(1f, 1f);
        titleRect.pivot = new Vector2(0.5f, 1f);
        titleRect.sizeDelta = new Vector2(-40f, 24f);
        titleRect.anchoredPosition = new Vector2(0f, -20f);

        var body = UIFactory.CreateLabel(panelRect,
            "Cheats accessing obfuscated code have been disabled for security and compatibility reasons.\n\n" +
            $"Detected game version: {CompatibilityGate.DetectedVersion}\n" +
            $"Please use version {CompatibilityGate.KnownCompatibleVersion} of the game, or check for a mod update.",
            13, UITheme.Text, wrap: true);
        var bodyRect = body.Graphic.rectTransform;
        bodyRect.anchorMin = new Vector2(0f, 0f);
        bodyRect.anchorMax = new Vector2(1f, 1f);
        bodyRect.offsetMin = new Vector2(20f, 48f);
        bodyRect.offsetMax = new Vector2(-20f, -50f);

        CreateButton(panelRect, "Close Game", UITheme.Red, isRight: false, () => Application.Quit());
        CreateButton(panelRect, "I Have Read And Understood", UITheme.Accent, isRight: true,
            () => Object.Destroy(backdrop.gameObject));
    }

    private static void CreateButton(RectTransform parent, string text, Color accent, bool isRight, System.Action onClick)
    {
        var go = new GameObject($"Button_{text}", typeof(RectTransform));
        go.transform.SetParent(parent, false);
        var rect = (RectTransform)go.transform;
        rect.anchorMin = new Vector2(isRight ? 0.5f : 0f, 0f);
        rect.anchorMax = new Vector2(isRight ? 1f : 0.5f, 0f);
        rect.pivot = new Vector2(0.5f, 0f);
        rect.offsetMin = new Vector2(isRight ? 8f : 16f, 16f);
        rect.offsetMax = new Vector2(isRight ? -16f : -8f, 46f);

        var img = go.AddComponent<Image>();
        img.sprite = UITheme.RoundedRect(40, 20, 6);
        img.type = Image.Type.Sliced;
        img.color = accent;

        var button = go.AddComponent<Button>();
        button.transition = Selectable.Transition.None;
        button.targetGraphic = img;
        button.onClick.AddListener(() => onClick?.Invoke());

        var hover = go.AddComponent<Widgets.HoverEffect>();
        hover.TargetImage = img;
        hover.IdleColor = accent;
        hover.HoverColor = Color.Lerp(accent, Color.white, 0.15f);
        hover.SelectedColor = hover.HoverColor;

        var label = UIFactory.CreateLabel(go.transform, text, 12, UITheme.Base);
        UIFactory.Stretch(label.Graphic.rectTransform);
        switch (label.Graphic)
        {
            case TMPro.TextMeshProUGUI tmp:
                tmp.alignment = TMPro.TextAlignmentOptions.Center;
                break;
            case Text legacy:
                legacy.alignment = TextAnchor.MiddleCenter;
                break;
        }
    }
}
