using UnityEngine;

namespace tr_mod_menu.Cheats;

// Real game hooks, as opposed to the still-inert placeholder rows in UI/MenuCategories.cs.
// Money/MoneyCalc are the game's own (decompiled, obfuscated) classes -- Money.GetBalance()
// returns the player's live MoneyCalc wallet, whose Copper/Silver/Gold properties are the only
// cleanly-named (non-obfuscated) members on that class, so those are what we set directly
// rather than guessing at one of its many obfuscated helper methods.
internal static class PlayerCheats
{
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
}
