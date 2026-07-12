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
  `[Placeholder] ...` when used — that's expected, not a bug. `CompatibilityGate.cs` checks
  `VersionNumberManager.instance.version` against `KnownCompatibleVersion` once at startup and
  disables every wired (non-placeholder) row if it doesn't match — see "Adding a new cheat"
  below. See also "Cheats never target other online players" below for a hard rule plus some
  unused-for-now infrastructure kept around for a future cheat that can legitimately use it.
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
3. Wire a `RowSpec` in `MenuCategories.cs` to it via the `onExecute` parameter. Every row
   factory (`Toggle`/`Slider`/`Dropdown`/`DropdownAmount`/`NumberInput`) takes an `iconName`
   (Font Awesome name, see "Adding an icon") and an optional trailing `note` string — a note
   renders as a small caption *inside the same card*, below a separator line, rather than as
   its own row.
4. If the UI needs a new control type, add it in `UI/UIFactory.cs`. Every row is wrapped in a
   rounded, `UITheme.Mantle`-colored card (`UIFactory.CreateRow`, private) that auto-sizes via
   `ContentSizeFitter` — go through `CreateRow`/`CreateRowLabel` rather than building a bare row
   directly on the list, so new row types get the same card/icon/note treatment for free.
5. If the method touches any obfuscated (randomly-named) member, it's automatically covered by
   `CompatibilityGate` as long as it's wired through `RowSpec.OnExecute` like the rest — no
   extra step needed. If `Application.version` doesn't match
   `CompatibilityGate.KnownCompatibleVersion`, the row's control renders disabled instead of
   running, and `CompatibilityBanner` warns the player at startup regardless of whether they
   open the menu. Bump `KnownCompatibleVersion` (and re-verify every obfuscated member every
   cheat relies on) after confirming a mod update against a new game version.

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

### Worked examples already in this repo

`Cheats/PlayerCheats.cs` follows the "prefer clean public members" rule above:
`Money.GetBalance()` and `Money.KLKDEMKNHNN()` (an obfuscated-but-public "is loaded" check) are
public statics on the game's `Money` class, and `MoneyCalc.Copper`/`.Silver`/`.Gold` are the
only cleanly-named members on that class — everything else on it is obfuscated. We use only
those, and reconstruct the total-value math ourselves (`copper + silver*100 + gold*10000`,
matching the game's own encoding) rather than calling one of `MoneyCalc`'s obfuscated helper
methods that happens to do something similar.

That same file is also a counter-example worth remembering: reading an obfuscated method's
decompiled body is not proof it's safe to call. `PlayerController.HGJCFHPNFBI()` looks like
exactly the "find the local player" method we needed (scans the player array for whichever
one's `PhotonView.IsMine`), so it was used for `LocalPlayer()` initially — but its decompiled
loop dereferences `GJBBNHCMNJN[0].gameObject` with no null check, and slot 0 is never assigned
by any spawn-registration path in that file (always starts at index 1), so it throws a
`NullReferenceException` on its very first iteration, unconditionally, every single call.
Confirmed live: dragging the Walk/Sprint Speed sliders threw exactly that, from inside the
game's own method, not ours. `PlayerCheats.LocalPlayer()` now reimplements the same "IsMine"
logic itself via `Object.FindObjectsByType<PlayerController>(FindObjectsSortMode.None)` with a
proper null check, avoiding the obfuscated method entirely. Lesson: verify a decompiled method
against actual runtime behavior before trusting it, not just against how plausible its body
reads — obfuscation can produce genuinely broken code paths, not only unstably-named ones.

`Cheats/CompatibilityGate.cs` finds the game's *displayed* version by tracing a visible piece of
UI back to its data source, rather than guessing: the pause menu shows a version string at the
bottom of its centered box, so grep `game_source/` for the UI class that draws it
(`PauseMenuUI.cs`) and read what it binds — `versionNumberText.text = VersionNumberManager.instance.version;`.
`VersionNumberManager.instance`/`.version` are both clean public names (everything else on that
class is obfuscated). This is more reliable than `UnityEngine.Application.version`, which this
game doesn't appear to actually use for its own displayed version. It also demonstrates a timing
issue worth remembering: `VersionNumberManager.instance` is set in *its own* `Awake()`, which
isn't guaranteed to have run yet when a BepInEx plugin's `Awake()` fires — `MenuController` polls
for it in a coroutine (with a timeout, failing safe to "cheats disabled") before building
anything that depends on `CompatibilityGate.CheatsEnabled`.

### Cheats never target other online players

Rule: a cheat's effect must never depend on another connected player also running tr-mod-menu.
If the only way to make a cheat affect someone else is for them to have this mod installed too,
don't build it — cut it rather than ship a partial/conditional version.

This came up for real: `PlayerController.speed`/`.sprintMultiplier` are purely local, unsynced
fields (no `IPunObservable`/`OnPhotonSerializeView` anywhere on that class, no existing
`[PunRPC]` methods either), so there's no native game mechanism to change another client's
movement speed. The only way around that is a custom Photon RPC — which requires a matching
`[PunRPC]` handler to already exist on the *receiving* machine, i.e. the target would need to be
running this same mod. Built (a custom `[PunRPC]` receiver riding each player's existing
`PhotonView`) and then removed once that dependency was clear. Before attempting a cross-player
cheat again: check for `IPunObservable`/existing `[PunRPC]` on the target class first. If neither
exists, the feature doesn't ship, full stop — surface that at design time rather than after
building it.

The UI half of that attempt is kept, though: `UIFactory.CreatePlayerSelectorBar` +
`UI/Widgets/PlayerSlotToggle.cs` (tickable P2/P3/P4 chips, grayed out live when a slot isn't
connected) and `PlayerCheats.OnlinePlayerSlots`/`.SelectedOnlinePlayers`/`.IsSlotConnected` are
still in the repo, deliberately not called from anywhere. They're for a *future* cheat that can
affect other players through some genuinely synced/authoritative mechanism (not a custom RPC
requiring the mod on both ends) — if you find one, wire the selector bar into that cheat's panel
and consult `SelectedOnlinePlayers` from its `OnExecute`, following the same shape
`SetWalkSpeed`/`SetSprintSpeed` would have used.

Session cap is 4 players either way, worth knowing for any *local-only* cheat that needs to
reason about the session: slot 0 is unused, so valid `PlayerController` slots are 1-4, and
whoever spawns first (the room creator) always claims slot 1 — every spawn-registration path in
`PlayerController.cs` (`game_source`) assigns the first free slot starting from 1, so slot 1 is
always the host.
