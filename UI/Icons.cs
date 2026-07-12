using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEngine;

namespace tr_mod_menu.UI;

// Loads the small set of PNG icons embedded via <EmbeddedResource Include="Icons/*.png" />
// (rasterized ahead of time from the Font Awesome Pro SVG kit in assets/ -- Unity has no
// runtime SVG renderer, and loading the raw webfonts would need Editor-only font import).
internal static class Icons
{
    private static readonly Dictionary<string, Sprite> Cache = new();

    public static Sprite Load(string name)
    {
        if (Cache.TryGetValue(name, out var cached))
            return cached;

        var resourceName = $"tr_mod_menu.Icons.{name}.png";
        var assembly = Assembly.GetExecutingAssembly();
        using var stream = assembly.GetManifestResourceStream(resourceName);
        if (stream == null)
        {
            Plugin.Logger.LogWarning($"[UI] Icon '{name}' not found (missing embedded resource '{resourceName}').");
            Cache[name] = null;
            return null;
        }

        using var ms = new MemoryStream();
        stream.CopyTo(ms);

        var tex = new Texture2D(2, 2, TextureFormat.RGBA32, false)
        {
            filterMode = FilterMode.Bilinear
        };
        if (!ImageConversion.LoadImage(tex, ms.ToArray()))
        {
            Plugin.Logger.LogWarning($"[UI] Failed to decode icon '{name}'.");
            Cache[name] = null;
            return null;
        }

        var sprite = Sprite.Create(tex, new Rect(0f, 0f, tex.width, tex.height), new Vector2(0.5f, 0.5f), 100f);
        Cache[name] = sprite;
        return sprite;
    }
}
