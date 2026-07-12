using UnityEngine;

namespace tr_mod_menu.Cheats;

internal static class WorldCheats
{
    // WorldTime advances via (Update(), the real per-frame entry point):
    //   EDIPJBOOEHD += Time.deltaTime * <const> * multiplier * multiplierDevConsole
    // Two separate multiplier fields exist. WorldTime.multiplier is the game's own -- that same
    // Update() silently snaps it back to 0 or 1 every frame based on dialogue/sleep state, so
    // setting *that* directly to freeze time would just get overwritten within a single frame.
    // WorldTime.multiplierDevConsole is a second, clean public static field that exists
    // specifically as a cheat/dev-console-only override the auto-correction logic never touches
    // -- it's what the game's own DevConsole "World Time ##" command sets (via a wrapper that
    // only takes whole numbers; we set the field directly instead for smooth/zero values).
    //
    // WorldTime is a networked singleton ([RequireComponent(PhotonView)], IPunObservable):
    // whichever client owns the view -- the room host -- is the one "IsWriting" in
    // OnPhotonSerializeView, broadcasting its own computed elapsed-time value to everyone else;
    // non-owning clients' locally computed time gets overwritten by that broadcast on every sync
    // tick. So this only takes effect for the whole session when set by the host -- via the
    // game's own existing sync, no custom RPC needed, so it doesn't require the mod on the other
    // end -- but a non-host client's own change would just be overridden a moment later.
    // OnlineManager.MasterOrOffline() (clean, already used by the game itself for the same kind
    // of authority check, e.g. RandomOrderQuestsManager) is true in solo/offline play and true
    // only for the host when online -- gate on that and bail rather than silently no-op, since
    // the row itself is already live-disabled for non-host players (see RowSpec.HostOnly /
    // UI/Widgets/HostOnlySlider.cs) and this shouldn't normally be reachable for them.
    public static void SetTimeScale(float scale)
    {
        if (!OnlineManager.MasterOrOffline())
        {
            Plugin.Logger.LogWarning("[Cheats] Time Scale: only the host can change time speed in an online session.");
            return;
        }

        WorldTime.multiplierDevConsole = Mathf.Max(0f, scale);
        Plugin.Logger.LogInfo($"[Cheats] Time Scale -> {WorldTime.multiplierDevConsole:0.00}x");
    }
}
