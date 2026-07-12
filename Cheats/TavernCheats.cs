using UnityEngine;

namespace tr_mod_menu.Cheats;

internal static class TavernCheats
{
    // What players think of as "perk points" are TavernReputation's "skill points", spent on the
    // Talents tree (TalentUI/TalentDatabaseAccessor -- yes, "Talents" in the UI and dev console,
    // "Perks" in several unrelated class names like PerkTreeUI/PlayerPerksUI, which actually
    // belong to a *different* system for assigning perks to hired employees). They aren't a
    // stored currency: TavernReputation.GetRemainingSkillPoints() computes
    // GetMilestone() - <points already spent across unlocked talents>, so the only way to grant
    // more is to advance the milestone itself.
    //
    // TavernReputation.NextMilestone() is a clean, public, static method -- and it's not a
    // reimplementation, it's the exact method the game calls when reputation naturally crosses a
    // milestone threshold: it increments the milestone, grants the same recipe-fragment reward a
    // real milestone-up gives, and -- if online and we're the host -- sends the same
    // OnlineReputationManager RPC the game uses to broadcast a milestone to every other client.
    // So like WorldTime's Time Scale, this rides the game's own existing sync and only takes
    // effect for the whole session when called by the host (TavernReputation is a per-client
    // singleton kept in sync via that RPC, not a continuously-broadcast networked object, so a
    // non-host caller wouldn't get immediately overridden like WorldTime -- it just silently
    // never sends the RPC, permanently desyncing the caller's own view from the shared truth
    // until the next real milestone corrects it). Gated the same way as SetTimeScale.
    //
    // The milestone's own property setter already clamps to RepUnlocksManager.MaxMilstone (the
    // last defined reputation tier), so this can't push it out of range -- but NextMilestone()
    // still unconditionally grants its recipe-fragment reward and sends its RPC on every call
    // regardless of whether the clamp actually changed anything, so looping past the cap would
    // hand out free, unbounded recipe fragments as a side effect. Stop once already at the cap
    // instead of relying on the clamp alone.
    public static void AddPerkPoints(float amount)
    {
        if (!OnlineManager.MasterOrOffline())
        {
            Plugin.Logger.LogWarning("[Cheats] Add Perk Points: only the host can grant shared skill points in an online session.");
            return;
        }

        var requested = Mathf.Max(0, Mathf.RoundToInt(amount));
        var granted = 0;
        for (var i = 0; i < requested; i++)
        {
            if (TavernReputation.GetMilestone() >= RepUnlocksManager.MaxMilstone)
                break;

            TavernReputation.NextMilestone();
            granted++;
        }

        Plugin.Logger.LogInfo($"[Cheats] Add Perk Points: granted {granted} (remaining: {TavernReputation.GetRemainingSkillPoints()}).");
    }
}
