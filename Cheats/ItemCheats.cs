using System.Collections.Generic;
using UnityEngine;

namespace tr_mod_menu.Cheats;

internal static class ItemCheats
{
    // Built once and cached: ItemDatabase is a scene-level singleton set up in its own Awake(),
    // independent of any save/spawn (unlike PlayerCheats.LocalPlayer(), which needs an actual
    // save loaded) -- so this is safe to build as soon as the mod menu itself is built.
    private static List<(Category Category, List<Item> Items)> _catalog;

    // Plain strings only, kept decoupled from Item so UIFactory/MenuWindow never need to
    // reference a real game type directly -- same shape every other row builder in this file
    // already follows.
    public static List<(string CategoryName, List<string> ItemNames)> GetCatalogLabels()
    {
        EnsureCatalog();

        var result = new List<(string, List<string>)>();
        foreach (var (category, items) in _catalog)
        {
            var names = new List<string>();
            foreach (var item in items)
                names.Add(item.IABAKHPEOAF(true));
            result.Add((category.ToString(), names));
        }
        return result;
    }

    // Item.category is the game's own real grouping (12 values: Misc, Brewing, Food, Farming,
    // Nature, Tools, Crafters, Furniture, Decorations, All, Lighting, Cosmetic -- confirmed used
    // for real by ShopUI, not a guess) -- replaces the old placeholder's made-up
    // "Food/Seed/Fish/Drink" options, which didn't correspond to any single real enum.
    //
    // Item.JMDALJBNFML() (obfuscated, no clean equivalent exists) is a virtual factory the game
    // itself relies on to construct the right ItemInstance subtype (FoodInstance/SeedInstance/
    // FishInstance/plain ItemInstance) -- this is the exact pattern PlayerInventory's own
    // add-by-id code uses, not a shortcut around it. Calling `new ItemInstance(item)` directly
    // instead would silently produce the wrong runtime type for anything that isn't a plain Item,
    // and likely break tooltip/freshness logic downstream that does `is FoodInstance` checks.
    //
    // PlayerInventory.AddItem(ItemInstance, bool dropIfFull, ...) -- confirmed by reading its
    // body directly (not just trusting how it reads) that it has no online/RPC call anywhere in
    // it: each player's inventory is a separate, playerNum-indexed local component, so this only
    // ever touches the caller's own inventory. Deliberately NOT using the other, richer
    // AddItem-by-amount overload (AINJENENGFG) that also exists on this class -- that one calls
    // into OnlineSlotsManager for stacked-slot batches, an online path this cheat doesn't need
    // and hasn't been verified safe/local the way plain AddItem has, so this loops single AddItem
    // calls instead. dropIfFull: true so a full inventory drops the excess at your feet instead
    // of the cheat silently doing nothing partway through a bigger amount.
    public static void GiveItem(int categoryIndex, int itemIndex, float amount)
    {
        var player = PlayerCheats.LocalPlayer();
        if (player == null)
            return;

        EnsureCatalog();
        if (categoryIndex < 0 || categoryIndex >= _catalog.Count)
            return;

        var items = _catalog[categoryIndex].Items;
        if (itemIndex < 0 || itemIndex >= items.Count)
            return;

        var inventory = PlayerInventory.GetPlayer(player.playerNum);
        if (inventory == null)
            return;

        var item = items[itemIndex];
        var requested = Mathf.Max(1, Mathf.RoundToInt(amount));
        var given = 0;
        for (var i = 0; i < requested; i++)
        {
            if (!inventory.AddItem(item.JMDALJBNFML(), true))
                break;
            given++;
        }

        Plugin.Logger.LogInfo($"[Cheats] Give Item: gave {given}/{requested}x {item.IABAKHPEOAF(true)}.");
    }

    private static void EnsureCatalog()
    {
        if (_catalog != null)
            return;

        _catalog = new List<(Category, List<Item>)>();

        var db = ItemDatabaseAccessor.GetDatabaseSO();
        if (db == null || db.items == null)
        {
            Plugin.Logger.LogWarning("[Cheats] Give Item: item database not ready yet.");
            return;
        }

        var byCategory = new Dictionary<Category, List<Item>>();
        foreach (var item in db.items)
        {
            if (item == null)
                continue;

            if (!byCategory.TryGetValue(item.category, out var list))
            {
                list = new List<Item>();
                byCategory[item.category] = list;
            }
            list.Add(item);
        }

        foreach (var pair in byCategory)
            _catalog.Add((pair.Key, pair.Value));
    }
}
