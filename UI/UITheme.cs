using System.Collections.Generic;
using UnityEngine;

namespace tr_mod_menu.UI;

internal static class UITheme
{
    // Catppuccin Mocha backgrounds/accent, with text pushed to true white/silver per feedback
    public static readonly Color Base = Hex("#1E1E2E");
    public static readonly Color Mantle = Hex("#181825"); // darker than Surface -- row/card backgrounds
    public static readonly Color Surface = Hex("#24273A");
    public static readonly Color Border = Hex("#313244");
    public static readonly Color Surface2 = Hex("#585B70");
    public static readonly Color Text = Hex("#FFFFFF");
    public static readonly Color MutedText = Hex("#B8BCC8");
    public static readonly Color Accent = Hex("#CBA6F7");
    public static readonly Color AccentHover = Hex("#DDB6F2");
    public static readonly Color Green = Hex("#A6E3A1");
    public static readonly Color Red = Hex("#F38BA8");

    // A more saturated, less pink-leaning red than Red above, specifically for the "not
    // connected" status dot -- Catppuccin's own Red/Maroon are both too pastel to read as an
    // unambiguous "red" status indicator next to Green.
    public static readonly Color StatusRed = Hex("#EF4444");

    // Distinct per-player identity colors for the online player selector (kept apart from
    // Accent/Green/Red above, which already carry other meanings).
    public static readonly Color[] PlayerColors =
    {
        Hex("#89B4FA"), // blue
        Hex("#FAB387"), // peach
        Hex("#94E2D5")  // teal
    };

    public const int WindowWidth = 620;
    public const int WindowHeight = 420;
    public const int TitleBarHeight = 34;
    public const int SidebarWidth = 150;
    public const int RowHeight = 30;

    public const float AnimSpeed = 12f;
    public const float WindowAnimDuration = 0.15f;
    public const float WindowClosedScale = 0.94f;

    private static Color Hex(string hex)
    {
        ColorUtility.TryParseHtmlString(hex, out var c);
        return c;
    }

    private static readonly Dictionary<(int w, int h, int r), Sprite> SpriteCache = new();

    public static Sprite RoundedRect(int width, int height, int radius)
    {
        var key = (width, height, radius);
        if (SpriteCache.TryGetValue(key, out var cached))
            return cached;

        var tex = new Texture2D(width, height, TextureFormat.RGBA32, false, false)
        {
            filterMode = FilterMode.Bilinear,
            wrapMode = TextureWrapMode.Clamp
        };

        var half = new Vector2(width / 2f, height / 2f);
        for (var y = 0; y < height; y++)
        {
            for (var x = 0; x < width; x++)
            {
                var p = new Vector2(x + 0.5f - half.x, y + 0.5f - half.y);
                var q = new Vector2(Mathf.Abs(p.x) - (half.x - radius), Mathf.Abs(p.y) - (half.y - radius));
                var dist = Vector2.Max(q, Vector2.zero).magnitude + Mathf.Min(Mathf.Max(q.x, q.y), 0f) - radius;
                var alpha = Mathf.Clamp01(0.5f - dist);
                tex.SetPixel(x, y, new Color(1f, 1f, 1f, alpha));
            }
        }
        tex.Apply(false);

        var border = Mathf.Min(radius + 2, Mathf.Min(width, height) / 2);
        var sprite = Sprite.Create(
            tex,
            new Rect(0, 0, width, height),
            new Vector2(0.5f, 0.5f),
            100f,
            0,
            SpriteMeshType.FullRect,
            new Vector4(border, border, border, border));

        SpriteCache[key] = sprite;
        return sprite;
    }
}
