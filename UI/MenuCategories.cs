using System.Collections.Generic;

namespace tr_mod_menu.UI;

internal enum RowKind
{
    Toggle,
    Slider
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
// CropSeason, PlayerController, MoneyCalc, Weather) so the layout reads as
// real content rather than lorem-ipsum placeholders.
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
                RowSpec.Toggle("Infinite Money")
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
                RowSpec.Slider("Crop Growth Speed", 1f, 10f, 1f, "0.0\"x\"")
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
                RowSpec.Toggle("Disable Weather")
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
