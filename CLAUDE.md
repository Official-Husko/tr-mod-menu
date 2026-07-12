# tr-mod-menu

BepInEx 5 (Mono) mod for **Travellers Rest** (Stardew-inspired tavern sim). Adds a runtime-built
uGUI mod menu (dark theme, sidebar navigation) plus real cheat hooks into the game's own
(decompiled, obfuscated) `Assembly-CSharp.dll`.

## Project layout

- `Plugin.cs` — BepInEx entry point, builds `UI.MenuController` in `Awake()`.
- `UI/` — the menu itself: colors/sizes (`UITheme.cs`), widget factory (`UIFactory.cs`),
  custom widgets (`UI/Widgets/`), category/row data (`MenuCategories.cs`), window layout
  (`MenuWindow.cs`), bootstrap + hotkey + config (`MenuController.cs`), icon loader
  (`Icons.cs`). Built entirely at runtime via code — no Unity Editor project, no prefabs, no
  AssetBundles.
- `Cheats/` — real hooks into the game, one static class per category (e.g. `PlayerCheats.cs`).
  A `RowSpec` in `MenuCategories.cs` wires a UI row to one of these via its `onExecute`
  parameter (stored as `RowSpec.OnExecute`). Until wired, a row just logs
  `[Placeholder] ...` when used — that's expected, not a bug.
- `Icons/` — small PNGs rasterized ahead of time from the Font Awesome Pro kit in `assets/`
  (embedded as resources — see "Adding an icon" below).
- `game_source/` — ILSpy-decompiled dump of every assembly the game loads (Assembly-CSharp,
  UnityEngine.UI, TMPro, etc., all flattened together into one folder). Reference only, never
  compiled (excluded via `DefaultItemExcludes` in the csproj) — use it to find real class/field
  names before writing a cheat, per the modding notes below.
- `assets/` — the full Font Awesome Pro kit (CSS/SVG/webfonts), also excluded from the build.
  Pull only the specific icon(s) you need out of it rather than referencing it at runtime.

Game install: `/home/pawbeans/Downloads/Travellers Rest/Windows/` (BepInEx 5, Mono — not
Len's Island, see below). `build.sh` builds and copies the DLL to `BepInEx/scripts/` there,
where BepInEx Script Engine (already installed) hot-reloads it without restarting the game.

`HarmonyX` (0Harmony) is already available as a transitive dependency of `BepInEx.Core` — no
extra `PackageReference` needed to use `[HarmonyPatch]`/`HarmonyLib`.

## Adding an icon

1. Find the SVG under `assets/svgs/<style>/<name>.svg` (Font Awesome icon names).
2. Rasterize it and force it white-on-transparent so `Image.color` tinting works the same way
   the procedural rounded-rect sprites do:

   ```sh
   rsvg-convert -w 64 -h 64 assets/svgs/solid/<name>.svg -o Icons/<name>.png
   python3 -c "
   from PIL import Image
   p = 'Icons/<name>.png'
   img = Image.open(p).convert('RGBA')
   white = Image.new('RGBA', img.size, (255, 255, 255, 0))
   white.putalpha(img.split()[3])
   white.save(p)
   "
   ```

3. Reference it via `Icons.Load(\"<name>\")` — it's auto-embedded by the csproj's
   `Icons/*.png` glob, no csproj edit needed.

## Adding a new cheat

1. Find the real hook in `game_source/` (see modding notes below for how to deal with the
   randomized names).
2. Add a static method to the matching file in `Cheats/` (or start a new one).
3. Wire a `RowSpec` in `MenuCategories.cs` to it via the `onExecute` parameter.
4. If the UI needs a new control type, add it in `UI/UIFactory.cs`.

---

## Modding notes (from a fellow modder's tips doc)

These apply to any BepInEx/HarmonyX mod against this game's Assembly-CSharp, not just this one.

### Why are nearly all method/property names random strings?

The game's build pipeline has broken up the original methods into smaller pieces under random
names, and hoisted any variable used across more than one piece into class fields. Consequences:

- A lot of what you see in `game_source/` is randomly-named noise, much of it unused.
- **The random names change on every game update.** If your mod calls a randomly-named
  method/field directly, it *will* break on the next patch.
- Prefer public, cleanly-named members over obfuscated helper methods, even if a helper method
  looks like it does what you want. Properties especially often survive obfuscation (Unity
  serialization needs stable names) — see the `Money`/`MoneyCalc` example below. When you must
  use an obfuscated member anyway, treat it as fragile and comment why.
- This makes modding more difficult in general; be ready to get creative with reflection.

### Patching a method with HarmonyX

Standard `[HarmonyPatch]` usage — see the HarmonyX docs and BepInEx example mods on GitHub. No
extra setup needed in this repo (see "HarmonyX is already available" above).

### Reading a private field via reflection (Harmony `Traverse`)

```csharp
[HarmonyPatch(typeof(FishingUI), "LateUpdate")]
[HarmonyPrefix]
static bool LateUpdatePrefix(FishingUI __instance)
{
    // Get the private field
    Slider reflectedSlider = Traverse.Create(__instance).Field("progress").GetValue<Slider>();
    reflectedSlider.value = 1.0f;
    return true;
}
```

- Method instead of field: `Traverse.Create(x).Method("Name", argTypes).GetValue<T>()`.
- `GetValue()` needs an explicit `<Type>`.
- See Harmony's `Traverse` and `AccessTools` classes for more.
- There's also `___privateField` as a patch method parameter name, to access a private field
  on `__instance` directly without `Traverse` — documented by Harmony, not yet used in this repo.

### Finding a field when you know the type but not the (randomized) name

```csharp
Slot[] reflectedSlots = null;
FieldInfo[] fields = pi.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
foreach (var fi in fields)
{
    if (fi.FieldType == typeof(Slot[]))
    {
        reflectedSlots = (Slot[])fi.GetValue(pi);
        break;
    }
}
```

Use `BindingFlags.Public` instead if the field isn't private. If more than one field shares
that type, you'll need another way to disambiguate (order, a debugger, trial and error).

### Accessing a C# instance that isn't reachable by name (only attached to a Unity object)

Some classes only ever exist as components attached to a Unity GameObject, with no visible
reference to their creation in the decompiled C#:

```csharp
UnityEngine.Object.FindObjectOfType<WorldTime>().currentGameDate.min
```

Or find every instance of a type and filter:

```csharp
ContainerUI targetContainer = null;
foreach (var cUI in UnityEngine.Object.FindObjectsOfType<ContainerUI>())
{
    if (cUI.IsOpen()) { targetContainer = cUI; break; }
}
```

This is a full scene scan under the hood — fine to call once (e.g. `Awake`, or on menu open),
**don't call it every `Update()`**. Where possible, patch a method on the target class instead
so you get a reference exactly when needed, rather than polling for the object every frame.

### Popup message over the character

```csharp
MainUI.ShowErrorText(1, "Hello World!");
```

Note: a second message is ignored while one is already showing.

### Spawning a Unity object from C #

```csharp
public void CatSpawn()
{
    if (this.catNPC == null)
    {
        UnityEngine.Object.Instantiate<GameObject>(this.catPrefab,
            TravelZonesManager.GDNODPKDDGA.GetTravelZone(Location.Tavern, Location.Road, -1).transform.position,
            Quaternion.identity).GetComponent<CatNPC>().Spawn();
    }
}
```

### Localization system

```csharp
Item x = ItemDatabaseAccessor.GetItem(3439);
string name = LocalisationSystem.Get("Items/item_name_" + x.id);
string desc = LocalisationSystem.Get("Items/item_description_" + x.id);
```

### Worked example already in this repo

`Cheats/PlayerCheats.cs` follows the "prefer clean public members" rule above:
`Money.GetBalance()` and `Money.KLKDEMKNHNN()` (an obfuscated-but-public "is loaded" check) are
public statics on the game's `Money` class, and `MoneyCalc.Copper`/`.Silver`/`.Gold` are the
only cleanly-named members on that class — everything else on it is obfuscated. We use only
those, and reconstruct the total-value math ourselves (`copper + silver*100 + gold*10000`,
matching the game's own encoding) rather than calling one of `MoneyCalc`'s obfuscated helper
methods that happens to do something similar.
