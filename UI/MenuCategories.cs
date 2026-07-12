using System;
using System.Collections.Generic;
using tr_mod_menu.Cheats;

namespace tr_mod_menu.UI;

internal enum RowKind
{
    Toggle,
    Slider,
    Dropdown,
    DropdownAmount,
    NumberInput,
    Button
}

internal class RowSpec
{
    public string Label;
    public string IconName;
    public RowKind Kind;
    public bool DefaultBool;
    public float DefaultFloat;
    public float Min;
    public float Max;
    public string Format = "0.0";
    public List<string> Options;

    // Small grey caption shown inside the same card, below a thin separator -- e.g.
    // clarifying how to read a NumberInput's units. Null means no note area at all.
    public string Note;

    // Most rows are still inert placeholders logged by MenuWindow.BuildDataRow. A row that's
    // been wired to a real game system (see Cheats/) sets this to override that placeholder.
    public Action<float> OnExecute;

    // Button rows only: close the whole mod menu right after executing, so the game's own UI
    // (e.g. the character creator) isn't stuck behind our overlay/backdrop.
    public bool CloseMenuAfter;

    // Slider/NumberInput rows only: this cheat only takes effect for the whole session when
    // applied by whoever's authoritative for the state it touches (e.g. WorldTime or
    // TavernReputation, both host-owned/host-broadcast). The row stays visible but its control is
    // live-disabled (re-checked while the menu is open, not just once at build time) whenever
    // OnlineManager.MasterOrOffline() is false -- i.e. we're online and not the host. See
    // UI/Widgets/HostOnlySlider.cs and UI/Widgets/HostOnlyNumberRow.cs.
    public bool HostOnly;

    public static RowSpec Toggle(string label, string iconName, bool defaultValue = false, string note = null) => new()
    {
        Label = label,
        IconName = iconName,
        Kind = RowKind.Toggle,
        DefaultBool = defaultValue,
        Note = note
    };

    public static RowSpec Slider(string label, string iconName, float min, float max, float defaultValue, string format = "0.0", Action<float> onExecute = null, string note = null, bool hostOnly = false) => new()
    {
        Label = label,
        IconName = iconName,
        Kind = RowKind.Slider,
        Min = min,
        Max = max,
        DefaultFloat = defaultValue,
        Format = format,
        OnExecute = onExecute,
        Note = note,
        HostOnly = hostOnly
    };

    // Pick an option from a dropdown, then click Execute to apply it.
    public static RowSpec Dropdown(string label, string iconName, List<string> options, string note = null) => new()
    {
        Label = label,
        IconName = iconName,
        Kind = RowKind.Dropdown,
        Options = options,
        Note = note
    };

    // Pick an option AND type an amount, then click Execute.
    public static RowSpec DropdownAmount(string label, string iconName, List<string> options, float defaultAmount, string format = "0", string note = null) => new()
    {
        Label = label,
        IconName = iconName,
        Kind = RowKind.DropdownAmount,
        Options = options,
        DefaultFloat = defaultAmount,
        Format = format,
        Note = note
    };

    // Type a number, then click Execute.
    public static RowSpec NumberInput(string label, string iconName, float defaultValue, string format = "0", Action<float> onExecute = null, string note = null, bool hostOnly = false) => new()
    {
        Label = label,
        IconName = iconName,
        Kind = RowKind.NumberInput,
        DefaultFloat = defaultValue,
        Format = format,
        OnExecute = onExecute,
        Note = note,
        HostOnly = hostOnly
    };

    // Just a label + Execute button, no input of its own -- for one-shot actions.
    public static RowSpec Button(string label, string iconName, Action onExecute, bool closeMenuAfter = false, string note = null) => new()
    {
        Label = label,
        IconName = iconName,
        Kind = RowKind.Button,
        OnExecute = onExecute == null ? null : (_ => onExecute()),
        CloseMenuAfter = closeMenuAfter,
        Note = note
    };
}

internal class CategorySpec
{
    public string Name;
    public string IconName;
    public List<RowSpec> Rows;
}

// Placeholder feature set for the UI shell -- no real game hooks yet.
// Labels are grounded in real Travellers Rest systems from game_source
// (AgingBarrel, TavernReputation, TavernServiceManager, TavernXP, Crop,
// CropSeason, PlayerController, MoneyCalc, Weather, and the game's own
// Online*/co-op systems such as OnlineTavernManager) so the layout reads
// as real content rather than lorem-ipsum placeholders.
internal static class MenuCategories
{
    public static readonly List<CategorySpec> All = new()
    {
        new CategorySpec
        {
            Name = "Player",
            IconName = "player",
            Rows = new List<RowSpec>
            {
                RowSpec.Slider("Walk Speed", "gaugehigh", 0.5f, 5f, 1f, "0.00\"x\"", PlayerCheats.SetWalkSpeed),
                RowSpec.Slider("Sprint Speed", "bolt", 1f, 5f, 1.75f, "0.00\"x\"", PlayerCheats.SetSprintSpeed),
                RowSpec.Toggle("Infinite Money", "sackdollar"),
                RowSpec.NumberInput("Add Money", "handholdingdollar", 10000f, "0", PlayerCheats.AddMoney,
                    "e.g. 10250 = 1 gold, 2 silver, 50 copper. Negative values subtract."),
                RowSpec.Button("Open Character Editor", "userpen", PlayerCheats.OpenCharacterEditor, closeMenuAfter: true,
                    "Opens the game's own character creator (same as using a Wardrobe). Click Accept inside it to save.")
            }
        },
        new CategorySpec
        {
            Name = "Online",
            IconName = "online",
            Rows = new List<RowSpec>
            {
                RowSpec.Toggle("Sync Cheats To All Players", "arrowsrotate"),
                RowSpec.Toggle("Hide Cheats From Other Players", "eyeslash"),
                RowSpec.Toggle("Give All Players Infinite Money", "sackdollar"),
                RowSpec.Toggle("Host-Only Cheat Restrictions", "lock")
            }
        },
        new CategorySpec
        {
            Name = "Farming",
            IconName = "farming",
            Rows = new List<RowSpec>
            {
                RowSpec.Toggle("Instant Crop Growth", "seedling"),
                RowSpec.Toggle("Water Crops Automatically", "droplet"),
                RowSpec.Slider("Crop Growth Speed", "gaugehigh", 1f, 10f, 1f, "0.0\"x\""),
                RowSpec.DropdownAmount("Give Item", "gift", new List<string> { "Food", "Seed", "Fish", "Drink" }, 1f)
            }
        },
        new CategorySpec
        {
            Name = "Tavern",
            IconName = "tavern",
            Rows = new List<RowSpec>
            {
                RowSpec.Toggle("Instant Barrel Aging", "hourglasshalf"),
                RowSpec.Toggle("Max Tavern Reputation", "star"),
                RowSpec.Slider("Service Speed", "gaugehigh", 1f, 5f, 1f, "0.0\"x\""),
                RowSpec.Slider("Tavern XP Multiplier", "arrowtrendup", 1f, 10f, 1f, "0.0\"x\""),
                RowSpec.Button("Complete All Orders", "receipt", QuestCheats.CompleteAllOrders,
                    note: "Instantly hands in every active tavern order. Syncs to other online players."),
                RowSpec.NumberInput("Add Perk Points", "brain", 1f, "0", TavernCheats.AddPerkPoints,
                    "Grants Talent tree skill points by advancing the reputation milestone (same as reaching it normally). Only takes effect for the whole session when you're the host (or playing solo) -- disabled otherwise.",
                    hostOnly: true)
            }
        },
        new CategorySpec
        {
            Name = "World",
            IconName = "world",
            Rows = new List<RowSpec>
            {
                RowSpec.Slider("Time Scale", "clockrotateleft", 0f, 5f, WorldTime.multiplierDevConsole, "0.0\"x\"", WorldCheats.SetTimeScale,
                    "0x freezes the clock, up to 5x fast-forwards it. Only takes effect for the whole session when you're the host (or playing solo) -- disabled otherwise.",
                    hostOnly: true),
                RowSpec.Toggle("Disable Weather", "ban"),
                RowSpec.Dropdown("Set Weather", "cloud", new List<string> { "Sunny", "Rain", "Snow", "Cloudy", "Wind" })
            }
        },
        new CategorySpec
        {
            Name = "Misc",
            IconName = "misc",
            Rows = new List<RowSpec>
            {
                RowSpec.Toggle("Noclip", "ghost"),
                RowSpec.Toggle("Unlock All Recipes", "bookopen"),
                RowSpec.Button("Complete All Missions", "listcheck", QuestCheats.CompleteAllMissions,
                    note: "Instantly finishes every active side mission. Syncs to other online players."),
                RowSpec.Button("Complete All Quests", "scroll", QuestCheats.CompleteAllQuests,
                    note: "Instantly finishes every active story/board quest. Local only -- other players still see them as open.")
            }
        }
    };
}
