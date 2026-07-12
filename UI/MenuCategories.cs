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
    Note
}

internal class RowSpec
{
    public string Label;
    public RowKind Kind;
    public bool DefaultBool;
    public float DefaultFloat;
    public float Min;
    public float Max;
    public string Format = "0.0";
    public List<string> Options;

    // Most rows are still inert placeholders logged by MenuWindow.BuildDataRow. A row that's
    // been wired to a real game system (see Cheats/) sets this to override that placeholder.
    public Action<float> OnExecute;

    public static RowSpec Toggle(string label, bool defaultValue = false) => new()
    {
        Label = label,
        Kind = RowKind.Toggle,
        DefaultBool = defaultValue
    };

    public static RowSpec Slider(string label, float min, float max, float defaultValue, string format = "0.0") => new()
    {
        Label = label,
        Kind = RowKind.Slider,
        Min = min,
        Max = max,
        DefaultFloat = defaultValue,
        Format = format
    };

    // Pick an option from a dropdown, then click Execute to apply it.
    public static RowSpec Dropdown(string label, List<string> options) => new()
    {
        Label = label,
        Kind = RowKind.Dropdown,
        Options = options
    };

    // Pick an option AND type an amount, then click Execute.
    public static RowSpec DropdownAmount(string label, List<string> options, float defaultAmount, string format = "0") => new()
    {
        Label = label,
        Kind = RowKind.DropdownAmount,
        Options = options,
        DefaultFloat = defaultAmount,
        Format = format
    };

    // Type a number, then click Execute.
    public static RowSpec NumberInput(string label, float defaultValue, string format = "0", Action<float> onExecute = null) => new()
    {
        Label = label,
        Kind = RowKind.NumberInput,
        DefaultFloat = defaultValue,
        Format = format,
        OnExecute = onExecute
    };

    // Small grey explanatory caption, no controls -- e.g. clarifying how to read a NumberInput's units.
    public static RowSpec Note(string text) => new()
    {
        Label = text,
        Kind = RowKind.Note
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
                RowSpec.Toggle("God Mode"),
                RowSpec.Toggle("Infinite Stamina"),
                RowSpec.Slider("Move Speed", 1f, 5f, 1f, "0.0\"x\""),
                RowSpec.Toggle("Infinite Money"),
                RowSpec.NumberInput("Add Money", 10000f, "0", PlayerCheats.AddMoney),
                RowSpec.Note("e.g. 10250 = 1 gold, 2 silver, 50 copper. Negative values subtract.")
            }
        },
        new CategorySpec
        {
            Name = "Online",
            IconName = "online",
            Rows = new List<RowSpec>
            {
                RowSpec.Toggle("Sync Cheats To All Players"),
                RowSpec.Toggle("Hide Cheats From Other Players"),
                RowSpec.Toggle("Give All Players Infinite Money"),
                RowSpec.Toggle("Host-Only Cheat Restrictions")
            }
        },
        new CategorySpec
        {
            Name = "Farming",
            IconName = "farming",
            Rows = new List<RowSpec>
            {
                RowSpec.Toggle("Instant Crop Growth"),
                RowSpec.Toggle("Water Crops Automatically"),
                RowSpec.Slider("Crop Growth Speed", 1f, 10f, 1f, "0.0\"x\""),
                RowSpec.DropdownAmount("Give Item", new List<string> { "Food", "Seed", "Fish", "Drink" }, 1f)
            }
        },
        new CategorySpec
        {
            Name = "Tavern",
            IconName = "tavern",
            Rows = new List<RowSpec>
            {
                RowSpec.Toggle("Instant Barrel Aging"),
                RowSpec.Toggle("Max Tavern Reputation"),
                RowSpec.Slider("Service Speed", 1f, 5f, 1f, "0.0\"x\""),
                RowSpec.Slider("Tavern XP Multiplier", 1f, 10f, 1f, "0.0\"x\"")
            }
        },
        new CategorySpec
        {
            Name = "World",
            IconName = "world",
            Rows = new List<RowSpec>
            {
                RowSpec.Toggle("Freeze Time of Day"),
                RowSpec.Slider("Time Scale", 0f, 5f, 1f, "0.0\"x\""),
                RowSpec.Toggle("Disable Weather"),
                RowSpec.Dropdown("Set Weather", new List<string> { "Sunny", "Rain", "Snow", "Cloudy", "Wind" })
            }
        },
        new CategorySpec
        {
            Name = "Misc",
            IconName = "misc",
            Rows = new List<RowSpec>
            {
                RowSpec.Toggle("Noclip"),
                RowSpec.Toggle("Unlock All Recipes")
            }
        }
    };
}
