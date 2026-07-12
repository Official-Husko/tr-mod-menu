namespace tr_mod_menu.Cheats;

// Cheats that reach into the game's obfuscated Assembly-CSharp are only verified against one
// specific game version -- an update can silently rename/reshuffle the randomized members they
// depend on (see CLAUDE.md's modding notes), which risks a cheat doing the wrong thing rather
// than just failing loudly. Checked once at startup; every real (non-placeholder) cheat row
// gets disabled for the whole session if the running game doesn't match.
//
// The version comes from the game's own VersionNumberManager.instance.version -- confirmed by
// PauseMenuUI.Start(), which does the exact same read to populate the version text shown at the
// bottom of the in-game pause menu, so whatever we detect matches what the player can see with
// their own eyes. Not UnityEngine.Application.version -- that's a generic Unity build-version
// field this game doesn't appear to use for its own displayed version.
internal static class CompatibilityGate
{
    public const string KnownCompatibleVersion = "v0.7.5.3.0";

    public static string DetectedVersion { get; private set; } = "unknown";
    public static bool CheatsEnabled { get; private set; }

    // Callers must wait for VersionNumberManager.instance to exist before calling this --
    // MenuController does that via a coroutine, since it's set in VersionNumberManager.Awake()
    // on a game object that doesn't necessarily exist yet when our own plugin's Awake() runs.
    public static void Check()
    {
        DetectedVersion = VersionNumberManager.instance != null
            ? VersionNumberManager.instance.version
            : "unknown (VersionNumberManager not found)";
        CheatsEnabled = DetectedVersion == KnownCompatibleVersion;

        if (CheatsEnabled)
        {
            Plugin.Logger.LogInfo(
                $"[Compat] Game version {DetectedVersion} matches the known-compatible version -- cheats enabled.");
        }
        else
        {
            Plugin.Logger.LogWarning(
                $"[Compat] Game version {DetectedVersion} does not match the known-compatible version " +
                $"({KnownCompatibleVersion}). Cheats accessing obfuscated game code have been disabled.");
        }
    }
}
