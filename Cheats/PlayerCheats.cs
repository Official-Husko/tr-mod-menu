using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

namespace tr_mod_menu.Cheats;

// Real game hooks, as opposed to the still-inert placeholder rows in UI/MenuCategories.cs.
// Money/MoneyCalc are the game's own (decompiled, obfuscated) classes -- Money.GetBalance()
// returns the player's live MoneyCalc wallet, whose Copper/Silver/Gold properties are the only
// cleanly-named (non-obfuscated) members on that class, so those are what we set directly
// rather than guessing at one of its many obfuscated helper methods.
internal static class PlayerCheats
{
    // Player slots are 1-4 (0 is unused -- see PlayerController's array-bounds helper, which
    // rejects anything < 1). Slot 1 is always whoever spawned first, which in every game_source
    // spawn-registration path is the room creator, i.e. the host -- so 2/3/4 are "everyone else."
    //
    // Kept as reusable infrastructure (with UIFactory.CreatePlayerSelectorBar /
    // UI/Widgets/PlayerSlotToggle.cs) for a *future* cheat that can legitimately affect other
    // connected players -- not currently consulted by any cheat. See CLAUDE.md: "Cheats never
    // target other online players": SetWalkSpeed/SetSprintSpeed below stay local-only because
    // PlayerController.speed/sprintMultiplier are unsynced, and the only way to change them
    // remotely (a custom Photon RPC) requires the target to also be running this mod.
    public const int HostPlayerNum = 1;
    public static readonly int[] OnlinePlayerSlots = { 2, 3, 4 };
    public static readonly HashSet<int> SelectedOnlinePlayers = new();

    public static bool IsSlotConnected(int playerNum) => PlayerController.GetPlayer(playerNum) != null;

    // amount is a delta (positive adds, negative subtracts), encoded the same way the game
    // itself packs its three coin denominations into one number: copper + silver*100 + gold*10000
    // (confirmed against MoneyCalc's own total getter). Recomputing that decomposition ourselves
    // from the Copper/Silver/Gold properties, rather than calling one of MoneyCalc's obfuscated
    // helper methods, keeps this on the only members of that class we can be confident about.
    public static void AddMoney(float amount)
    {
        if (!Money.KLKDEMKNHNN())
        {
            Plugin.Logger.LogWarning("[Cheats] Add Money: no active game session yet (Money not loaded).");
            return;
        }

        var balance = Money.GetBalance();
        var currentTotal = balance.Copper + balance.Silver * 100 + balance.Gold * 10000;
        var newTotal = Mathf.Max(0, currentTotal + Mathf.RoundToInt(amount));

        balance.Gold = newTotal / 10000;
        balance.Silver = newTotal / 100 % 100;
        balance.Copper = newTotal % 100;

        Plugin.Logger.LogInfo($"[Cheats] Add Money: {amount:+0;-0} -> {balance.Gold}g {balance.Silver}s {balance.Copper}c.");
    }

    // PlayerController.speed (base walk speed) and .sprintMultiplier (applied on top of speed
    // while sprinting) are both clean public fields.
    //
    // Finding *which* PlayerController is ours does NOT go through PlayerController.HGJCFHPNFBI()
    // (the obvious "scan the player array for whoever's PhotonView.IsMine" candidate) despite
    // that being the pattern this class otherwise follows -- its decompiled body dereferences
    // GJBBNHCMNJN[0].gameObject with no null check, and slot 0 is never assigned by any spawn
    // path in this file (registration always starts at index 1), so it throws a
    // NullReferenceException on its very first loop iteration, unconditionally, every time it's
    // called. Confirmed live: dragging Walk/Sprint Speed threw exactly that NRE. Reimplementing
    // the same "IsMine" logic ourselves via Object.FindObjectsOfType, with a null check
    // GJBBNHCMNJN[0] apparently doesn't get, avoids the bug entirely. No PhotonView at all
    // (solo/offline play) also counts as "this is us," since there's only ever one in that case.
    //
    // Local player only, deliberately: there is no native way to change another connected
    // player's speed (PlayerController.speed/sprintMultiplier are purely local, unsynced fields),
    // and a cheat whose effect depends on the target also running this mod isn't one we ship --
    // see CLAUDE.md.
    private static PlayerController _cachedLocalPlayer;

    private static PlayerController LocalPlayer()
    {
        if (_cachedLocalPlayer != null)
            return _cachedLocalPlayer;

        foreach (var candidate in Object.FindObjectsByType<PlayerController>(FindObjectsSortMode.None))
        {
            var view = candidate.GetComponent<PhotonView>();
            if (view == null || view.IsMine)
            {
                _cachedLocalPlayer = candidate;
                return candidate;
            }
        }

        Plugin.Logger.LogWarning("[Cheats] No local player found yet (not spawned in a save).");
        return null;
    }

    public static void SetWalkSpeed(float speed)
    {
        var player = LocalPlayer();
        if (player == null)
            return;

        player.speed = Mathf.Max(0f, speed);
        Plugin.Logger.LogInfo($"[Cheats] Walk Speed -> {player.speed:0.00}");
    }

    public static void SetSprintSpeed(float multiplier)
    {
        var player = LocalPlayer();
        if (player == null)
            return;

        player.sprintMultiplier = Mathf.Max(0f, multiplier);
        Plugin.Logger.LogInfo($"[Cheats] Sprint Speed multiplier -> {player.sprintMultiplier:0.00}");
    }
}
