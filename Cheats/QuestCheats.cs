using System.Collections.Generic;

namespace tr_mod_menu.Cheats;

// The game has three separate active-task systems that all read as "quests" to a player but
// live in different managers: side Missions (MissionsManager), tavern Order quests
// (RandomOrderQuestsManager -- itself just a filtered view over QuestManager's own active-quest
// list, order quests are ordinary Quest instances with id == 0), and main story/board Quests
// (QuestManager directly, id != 0). See CLAUDE.md for the full completion-path research behind
// each of these, including why each is (or isn't) safe to force-complete and how/whether it
// syncs to other online players.
internal static class QuestCheats
{
    // MissionsManager.CompleteMission is a clean, public, static, single entry point -- marks
    // every objective complete then runs the mission's own finish logic (rewards, linked-mission
    // chaining, etc.), identical to normal completion, not a separate/parallel code path.
    //
    // While online, ActiveMission's own objective-completion step already sends a Photon RPC to
    // other clients (OnlineMissionsManager.SendCompleteObjective -> [PunRPC] ReceiveCompleteObjective,
    // which runs the same local completion logic on their end) -- so this genuinely syncs without
    // requiring the mod on the other end. Reward items always land in player slot 1's inventory
    // regardless of who completes it (ActiveMission.triggerPlayerNum is never set to anything
    // else anywhere in the game) -- a pre-existing base-game quirk, not something this introduces.
    public static void CompleteAllMissions()
    {
        var snapshot = new List<ActiveMission>(MissionsManager.instance.activeMissions);
        foreach (var active in snapshot)
            MissionsManager.CompleteMission(active.mission.id);

        Plugin.Logger.LogInfo($"[Cheats] Completed {snapshot.Count} active mission(s).");
    }

    // RandomOrderQuestsManager.CompleteOrderQuest is clean and public but, unlike
    // TryToCompleteOrder (the vanilla "hand in ingredients" path), doesn't send the online RPC
    // itself -- so we send it ourselves via OnlineOrderQuestsManager.SendCompleteOrderQuest
    // (also clean/public), the exact same RPC TryToCompleteOrder fires, so other clients update
    // without needing the mod.
    //
    // Completing an order removes it from QuestManager's active-quest list as a side effect
    // (ActiveQuest.JGNBGECEINP fires OnQuestComplete, which QuestManager.AddQuest already wires
    // to its own RemoveQuest for every quest it creates, orders included -- confirmed by reading
    // AddQuest directly). That means indices shift after each completion, so this goes
    // highest-index-first: whatever we haven't processed yet keeps a valid index. The online send
    // uses the same index, in the same order, so the other client's list -- which mirrors ours
    // pre-completion -- shifts identically on both ends.
    public static void CompleteAllOrders()
    {
        var player = PlayerCheats.LocalPlayer();
        if (player == null)
            return;

        var orders = RandomOrderQuestsManager.GGFJGHHHEJC.GetCurrentOrderQuests();
        var online = OnlineManager.PlayingOnline();

        for (var i = orders.Length - 1; i >= 0; i--)
        {
            RandomOrderQuestsManager.GGFJGHHHEJC.CompleteOrderQuest(player.playerNum, i);
            if (online)
                OnlineOrderQuestsManager.instance.SendCompleteOrderQuest(i);
        }

        Plugin.Logger.LogInfo($"[Cheats] Completed {orders.Length} active tavern order(s).");
    }

    // QuestManager has no clean top-level "complete" wrapper (unlike Missions/Orders above) --
    // every quest type funnels through ActiveQuest.JGNBGECEINP itself, which is also exactly
    // what the game's own dev console's "Complete quest" command calls (confirmed in DevConsole.cs).
    // The dev console's own "complete every active quest" variant excludes id == 0 (order quests,
    // handled separately by CompleteAllOrders above) -- matched here for the same reason.
    //
    // There is no "complete quest" RPC anywhere in OnlineQuestManager (only "add"/"progress" are
    // networked), so this is local-only: it completes the quest on this client only and will not
    // update another connected player's copy of the same quest.
    public static void CompleteAllQuests()
    {
        var player = PlayerCheats.LocalPlayer();
        if (player == null)
            return;

        var manager = QuestManager.GGFJGHHHEJC;
        var snapshot = new List<ActiveQuest>(manager.MADOFDHLKKN);
        var count = 0;
        foreach (var active in snapshot)
        {
            if (active.quest.id == 0)
                continue;

            active.JGNBGECEINP(player.playerNum);

            // Every quest QuestManager.AddQuest creates normally wires its own removal (from
            // MADOFDHLKKN, and therefore from the quest log -- GetDisplayedQuest only filters on
            // quest.showGoal, not ActiveQuest.active) to fire off the OnQuestComplete event
            // JGNBGECEINP raises above. Quest id 1 -- "New Game Setup" in SceneReferences.cs, the
            // very first quest a new save gets -- is special-cased in AddQuest to skip that wiring
            // entirely; in normal play it's only ever cleared as a side effect of quest id 3 being
            // granted later, via a direct RemoveQuest(Quest) call. Without this, id 1 (and
            // possibly other quests sharing the same quirk) "completes" internally but never
            // leaves the quest log, which is exactly the "First Customers... not completing" bug
            // this fixes. Guard with Contains first: QuestManager.RemoveQuest(Quest) has no null
            // check if the quest isn't found (same class of bug as HGJCFHPNFBI, see CLAUDE.md), so
            // only call it for quests JGNBGECEINP didn't already remove.
            if (manager.MADOFDHLKKN.Contains(active))
                manager.RemoveQuest(active.quest);

            count++;
        }

        Plugin.Logger.LogInfo($"[Cheats] Completed {count} active quest(s) (local only -- other players still see them as open).");
    }
}
