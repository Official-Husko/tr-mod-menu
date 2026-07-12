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
    NumberInput
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

    public static RowSpec Toggle(string label, string iconName, bool defaultValue = false, string note = null) => new()
    {
        Label = label,
        IconName = iconName,
        Kind = RowKind.Toggle,
        DefaultBool = defaultValue,
        Note = note
    };

    public static RowSpec Slider(string label, string iconName, float min, float max, float defaultValue, string format = "0.0", string note = null) => new()
    {
        Label = label,
        IconName = iconName,
        Kind = RowKind.Slider,
        Min = min,
        Max = max,
        DefaultFloat = defaultValue,
        Format = format,
        Note = note
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
    public static RowSpec NumberInput(string label, string iconName, float defaultValue, string format = "0", Action<float> onExecute = null, string note = null) => new()
    {
        Label = label,
        IconName = iconName,
        Kind = RowKind.NumberInput,
        DefaultFloat = defaultValue,
        Format = format,
        OnExecute = onExecute,
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
                RowSpec.Toggle("God Mode", "shieldhalved"),
                RowSpec.Toggle("Infinite Stamina", "bolt"),
                RowSpec.Slider("Move Speed", "gaugehigh", 1f, 5f, 1f, "0.0\"x\""),
                RowSpec.Toggle("Infinite Money", "sackdollar"),
                RowSpec.NumberInput("Add Money", "handholdingdollar", 10000f, "0", PlayerCheats.AddMoney,
                    "e.g. 10250 = 1 gold, 2 silver, 50 copper. Negative values subtract.")
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
                RowSpec.Slider("Tavern XP Multiplier", "arrowtrendup", 1f, 10f, 1f, "0.0\"x\"")
            }
        },
        new CategorySpec
        {
            Name = "World",
            IconName = "world",
            Rows = new List<RowSpec>
            {
                RowSpec.Toggle("Freeze Time of Day", "snowflake"),
                RowSpec.Slider("Time Scale", "clockrotateleft", 0f, 5f, 1f, "0.0\"x\""),
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
                RowSpec.Toggle("Unlock All Recipes", "bookopen")
            }
        }
    };
}
