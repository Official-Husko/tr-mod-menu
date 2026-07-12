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

`x.id` above is now stale and won't compile as-is: `Item.id` is `protected` in the current
decompile (every public accessor for it is obfuscated, e.g. `JDJGFAACPFC()`/`IMCJPECAAPC()`, all
functionally-identical one-liners around the same protected field) -- found while building the
Give Item cheat below. Don't chase the raw id at all if you just want a display string: `Item`
already has a clean public method for that, `item.IABAKHPEOAF(true)` (the `true` suppresses
`<color=...>` rich-text tags the method otherwise wraps around Halloween/Christmas shop items,
which would otherwise show up as literal text outside a rich-text-aware label). Only reach for one
of the obfuscated id getters if you specifically need the raw int (e.g. to build a localization
key by hand, as above).

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

### Reusing the game's own UI instead of building one

`PlayerCheats.OpenCharacterEditor()` (the "Open Character Editor" button, Player tab) is an
example of the cheapest and most correct way to expose a game feature: find the object that
already triggers it and call the same entry point, rather than reimplementing any UI or save
logic ourselves. The character creator is normally opened by walking up to a Wardrobe; grepping
`game_source/Wardrobe.cs` shows its `MouseUp()` does exactly
`CharacterCreatorUI.loadGame = null; CharacterCreatorUI.Get(playerNum).OpenUI();` — both clean
public members. Calling that directly from our button gets the *exact* real character creator
(sliders, cycling, Accept/Cancel), with all of its save/confirm behavior (`AcceptButton()` ->
`SetCharacter(playerNum); CloseUI();`) unchanged, for zero extra code. This only works because a
Wardrobe is a plain trigger with no extra state to fake — for a feature like this, check whether
the game already has a "press button, thing happens" object before writing any bespoke UI.

This is also the reason `RowSpec.Button`/`RowKind.Button` and `MenuWindow.CloseRequested` exist:
our own menu's backdrop (`raycastTarget=true`, drawn above everything) would otherwise block the
real character creator once it opens. `RowSpec.CloseMenuAfter = true` on a button row closes our
menu right after running its `OnExecute`, via a `CloseRequested` action `MenuController` wires to
its existing `CloseMenu()`. Any future cheat that opens another piece of the game's own full-screen
UI should set the same flag rather than trying to reorder canvas sort order.

### Force-completing quests/missions/orders (`Cheats/QuestCheats.cs`)

The game has three separate active-task systems that all read as "quests" to a player but live
in different managers, each with a different completion story:

- **Side Missions** (`MissionsManager`) have a genuine clean, public, static single entry point:
  `MissionsManager.CompleteMission(int missionId)`. It marks every objective complete then runs
  the mission's own finish logic (rewards, linked-mission chaining) -- not a parallel/reimplemented
  path. Enumerate via the clean `MissionsManager.instance.activeMissions` list. While online, the
  underlying objective-completion step already fires a Photon RPC to other clients
  (`OnlineMissionsManager.SendCompleteObjective` -> `[PunRPC] ReceiveCompleteObjective`, which runs
  the identical local completion logic on their end), so this **genuinely syncs** without requiring
  the mod on the other end -- satisfies "Cheats never target other online players" above by riding
  a mechanism the game already has, not a custom RPC. One base-game quirk worth knowing (not
  something this introduces): `ActiveMission.triggerPlayerNum` is never set to anything but `1`
  anywhere in the shipped code, so mission rewards always land in player slot 1's inventory
  regardless of who actually completes it.
- **Tavern Orders** (`RandomOrderQuestsManager`) are not a separate data model -- they're ordinary
  `Quest`/`ActiveQuest` instances living in `QuestManager`'s own list, just filtered by `id == 0`
  (order quests are runtime-generated, so they share a placeholder id) and `is CraftItemTypeQuest`.
  `RandomOrderQuestsManager.CompleteOrderQuest(playerNum, orderIndex)` is clean and public, but
  unlike the vanilla "hand in ingredients" path (`TryToCompleteOrder`) it does **not** send the
  online RPC itself -- call `OnlineOrderQuestsManager.instance.SendCompleteOrderQuest(orderIndex)`
  (also clean) right after, the same RPC the vanilla path fires, so this syncs too without a custom
  RPC. Completing an order removes it from `QuestManager`'s list as a side effect (confirmed by
  reading `QuestManager.AddQuest`, which wires every quest it creates -- orders included -- to
  remove itself from the active list via its own `OnQuestComplete` event), which shifts every later
  index. `CompleteAllOrders` therefore completes **highest-index-first** so already-processed
  indices don't shift out from under the loop, and sends the matching online RPC in that same
  order so the other client's mirrored list shifts identically on both ends.
- **Main story/board Quests** (`QuestManager` directly, `id != 0`) have no clean top-level
  wrapper -- every quest subtype funnels through `ActiveQuest.JGNBGECEINP(playerNum)` (obfuscated,
  but confirmed as the real, single, type-agnostic completion point: it's exactly what the game's
  own `DevConsole.cs` calls for its "Complete quest" command, including a "complete every active
  quest" variant that explicitly skips `id == 0` -- matched in `CompleteAllQuests` for the same
  reason, since orders are handled separately above). Critically, `OnlineQuestManager` only has
  RPCs for "add quest" and "progress quest" -- **there is no "complete quest" RPC anywhere in the
  assembly**. So this cheat is local-only: it finishes the quest on your own client, but another
  connected player's copy of that same quest keeps showing as open on their screen. That's
  disclosed in the row's note text rather than silently shipped as if it were networked.

`PlayerCheats.LocalPlayer()` was widened from `private` to `internal` so `QuestCheats` can reuse
the exact same safe local-player lookup instead of re-scanning `FindObjectsByType` itself.

**Real bug found via this feature**: the very first quest a new save gets ("First Customers",
quest id 1, granted by `SceneReferences.LOLAFOECMGP()` / "New Game Setup") looked like it
completed when `CompleteAllQuests` ran, but stayed in the quest log. Root cause: `QuestManager.
AddQuest` special-cases `id == 1` with a shortcut that skips the wiring every *other* quest gets
(`OnQuestComplete += RemoveQuest`) -- so `JGNBGECEINP` still runs fine (rewards, sound, events)
but nothing ever takes quest id 1 out of `MADOFDHLKKN`, and `GetDisplayedQuest()` only filters on
`quest.showGoal`, not `ActiveQuest.active`, so it keeps showing as open. In normal play, id 1 is
only ever cleared as a side effect of quest id 3 being granted later, via a direct
`RemoveQuest(Quest)` call in that same `AddQuest` method. Fix: after calling `JGNBGECEINP`, check
whether the quest is still in `MADOFDHLKKN` and, if so, call `QuestManager.RemoveQuest(Quest)`
ourselves to force it out -- mirroring exactly what the id-3 special case does. Note
`RemoveQuest(Quest)` itself has no null check if the quest isn't found in the list (`MADOFDHLKKN.
Find(...)` can return `null`, then it's dereferenced unconditionally) -- same class of bug as
`HGJCFHPNFBI()` above -- so it's only called after confirming the quest is still present, never
unconditionally. Lesson, same as the `HGJCFHPNFBI` case: a "single completion method" isn't
always uniform across every id: check whether the caller of that method (here, `AddQuest`) special-cases specific ids before assuming completion behaves identically for all of them.

### Host-authoritative cheats (`Cheats/WorldCheats.cs`, Time Scale)

Not every "can this sync online" question is a flat yes/no like the walk-speed case above. Time
Scale (`WorldCheats.SetTimeScale`, World tab) is a third category: a cheat that **does** ride the
game's own existing sync -- no custom RPC, no dependency on the target running the mod -- but only
takes effect for the whole session when applied by whoever's *authoritative* for that state.
`WorldTime` is a networked singleton (`[RequireComponent(PhotonView)]`, `IPunObservable`): the
room host owns the view and is the one "IsWriting" in `OnPhotonSerializeView`, broadcasting its
own computed elapsed-time value to everyone else every sync tick; a non-host client's own locally
computed time gets overwritten by that broadcast almost immediately. So setting the multiplier
genuinely propagates to the whole session, but only when done by the host -- a non-host client's
attempt is not "blocked" by anything, it just gets silently stomped by the next incoming sync
packet, which would look like the cheat doing nothing.

Two more things worth remembering from this one:

- **Two multiplier fields exist on `WorldTime` on purpose.** `multiplier` is the game's own, and
  its real per-frame `Update()` silently snaps it back to `0`/`1` based on dialogue/sleep state --
  setting *that* directly to freeze time gets overwritten within a single frame. `multiplierDevConsole`
  is a second, clean public field that exists specifically so a cheat/dev-console override doesn't
  fight that auto-correction -- it's what the game's own `DevConsole` "World Time ##" command sets.
  When a value you want to force keeps getting reset, check whether the surrounding `Update()`
  loop has its own opinion about that same field before assuming the field itself is broken.
- **A cheat that's only sometimes valid needs a *live*, not build-once, disabled check.** Host
  status can change while the menu stays open (join/leave a session, host migration) -- unlike
  `CompatibilityGate` (checked once at startup, since a game-version mismatch can't change
  mid-session), this needed a control that re-evaluates periodically. `UI/Widgets/HostOnlySlider.cs`
  polls `OnlineManager.MasterOrOffline()` every 0.5s (same cadence as `PlayerSlotToggle`'s
  connectivity poll) and live-updates `Slider.interactable` plus the fill/handle colors to match.
  It deliberately never touches the handle `Image.color` directly -- the handle already has its
  own `HoverEffect` running its own per-frame color Lerp, and two components independently
  Lerp-ing the same `Image.color` toward different targets fight each other every frame. Wire a
  new host-only slider via `RowSpec.Slider(..., hostOnly: true)`, not by hand-building the gate.

### Perk points aren't a stored currency (`Cheats/TavernCheats.cs`, Add Perk Points)

What players call "perk points" is `TavernReputation`'s "skill points", spent on the **Talents**
tree (`TalentUI`/`TalentDatabaseAccessor` -- that's the game's real name for it, in both the UI
and `DevConsole`'s "Talents" command). Don't confuse this with the *other*, unrelated system that
happens to have "Perk" in several class names (`PerkTreeUI`/`PlayerPerksUI`/`PerkSlotUI`/
`EmployeePerk`) -- that one assigns perks to hired employees, not the player.

`TavernReputation.GetRemainingSkillPoints()` is derived, not stored: `GetMilestone() - <points
already spent across unlocked talents>`. There's no "add N points" method to call -- the only way
to grant more is to advance the milestone itself, via `TavernReputation.NextMilestone()` (clean,
public, static). Confirmed by reading it that this isn't a reimplementation: it's the literal
method the game calls when reputation naturally crosses a threshold, so calling it grants the same
recipe-fragment reward a real milestone-up gives, for free, as a side effect -- expected, not a
bug, since it's the same code path.

Third variant of the "does this sync online" question this session has now hit: like `WorldTime`,
`NextMilestone()` rides the game's own existing RPC (`OnlineReputationManager`, host-gated inside
the method itself) rather than a custom one -- but *unlike* `WorldTime` (a continuously-broadcast
networked object where a non-host's local change gets overwritten within moments), `TavernReputation`
is a plain per-client singleton kept in sync only via discrete RPC messages. A non-host caller's
`NextMilestone()` simply never sends the RPC (the guard inside the method itself fails silently),
which permanently desyncs their own local view from the shared truth until the next *real*
milestone corrects it -- worse than `WorldTime`'s "briefly stomped," not better, so it gets the
same host-only gating (`RowSpec.NumberInput(..., hostOnly: true)`, extending the exact same
live-disable treatment to number-input rows via the new `UI/Widgets/HostOnlyNumberRow.cs`, sibling
to `HostOnlySlider`).

One more overshoot check worth recording: the milestone's own property setter already clamps to
`RepUnlocksManager.MaxMilstone` (confirmed by reading it), so repeated calls can't push it out of
range -- but `NextMilestone()` still unconditionally grants its recipe-fragment reward and fires
its RPC on *every* call regardless of whether the clamp actually changed anything. `AddPerkPoints`
therefore stops looping once already at the cap instead of trusting the clamp alone, to avoid
handing out free, unbounded recipe fragments as an unintended side effect of a big "add points"
number.

### Give Item (`Cheats/ItemCheats.cs`, `UI/Widgets/SimpleDropdown.SetOptions`)

Straightforward compared to the last few (purely local, confirmed by reading `PlayerInventory.
AddItem`'s body directly: no `OnlineManager`/RPC call anywhere in it, each player's inventory is
its own separate `playerNum`-indexed component) -- the interesting part was the UI, not the cheat.

The old placeholder's four options ("Food"/"Seed"/"Fish"/"Drink") didn't correspond to any single
real enum. The actual data is `Item.category` (`Category`, a real top-level 12-value enum --
`Misc, Brewing, Food, Farming, Nature, Tools, Crafters, Furniture, Decorations, All, Lighting,
Cosmetic` -- confirmed used for real by `ShopUI`, not guessed), enumerated from `ItemDatabaseAccessor.
GetDatabaseSO().items` (clean, a scene-level singleton independent of any save/spawn, so the
catalog can be built as soon as the menu itself is built, unlike anything gated on
`PlayerCheats.LocalPlayer()`). With a few hundred items across 12 categories, a single flat
dropdown of everything would be unusable, so Give Item is a **cascading two-dropdown row**
(category, then items filtered to it) -- the first row in this mod that needed one, so
`UI/Widgets/SimpleDropdown.cs` gained a `SetOptions(list, value)` method (swaps the option list
and re-applies `OnCaptionChanged` immediately, same as a manual selection would) and a `Disabled`
flag (`SimpleDropdown` had no disabled-state concept at all before this, since no earlier
`Dropdown`/`DropdownAmount` row was ever gated by `CompatibilityGate`). `UIFactory.
CreateGiveItemRow` wires the category dropdown's `OnCaptionChanged` to also call the item
dropdown's `SetOptions` with that category's item list, rather than generalizing
`CreateDropdownAmountActionRow` -- that one's still a single static list with no dependency
between controls, a genuinely different (simpler) shape worth keeping separate.

Constructing the actual item to hand over isn't `new ItemInstance(item)` -- `Item` has a virtual
factory, `item.JMDALJBNFML()` (obfuscated, no clean equivalent exists), overridden per subtype
(`Food`/`Seed`/`Fish` each return their own `*Instance` type). This is confirmed as the game's own
real pattern, not a workaround: `PlayerInventory`'s own add-by-id code calls the exact same
factory method before handing the result to `AddItem`. Using the base `ItemInstance` constructor
directly on a `Food`/`Seed`/`Fish` item would silently produce the wrong runtime type and likely
break any downstream tooltip/freshness logic that does an `is FoodInstance` check.

One more worth flagging for later: `PlayerInventory` has a *second*, richer add method
(`AINJENENGFG(ItemInstance, int amount, ...)`) that takes a quantity directly instead of looping --
tempting to reach for, but reading its body shows it calls into `OnlineSlotsManager` for batches of
stacked slots, a path that hasn't been verified local-only the way plain `AddItem` has. `GiveItem`
deliberately loops single `AddItem(item.JMDALJBNFML(), true)` calls instead (the `true` is
`dropIfFull`, confirmed by reading `AddItem`'s body -- spawns a `DroppedItem` at your feet instead
of silently failing partway through a bigger requested amount). Lesson repeated from the
`HGJCFHPNFBI` case: when two methods do almost the same thing, the one that conveniently matches
your exact call shape isn't automatically the safe one to reach for -- read the body of whichever
one you didn't pick too, if only to confirm you were right to avoid it.

Give Item's Category dropdown was also the first dropdown in this mod with more than
`SimpleDropdown.MaxVisibleItems` (6) options, and the first to actually exercise `BuildScrollingList`
-- which surfaced a real bug there. User report: "a big [accent-colored] box covering parts of" the
popup. Took five attempts and, in the end, adding debug logging that dumped the actual live
`RectTransform` values to find: the real bug was **`handleRT.sizeDelta` was never set**, left at a
fresh `RectTransform`'s default of `(100, 100)`. With stretch anchors (`anchorMin != anchorMax`,
which the handle correctly used from the start), `sizeDelta` isn't ignored -- it's an offset ADDED
on top of the anchor-stretched size. So the handle was always rendering ~100px wider and taller
than its (correctly-computed, every single time) anchors alone would suggest. Fix:
`handleRT.sizeDelta = Vector2.zero;` alongside the anchor assignment. One line.

Every attempt before finding this was chasing the wrong layer of the problem:

- **Attempts 1-2** (`scrollbar.size = ...`, then `LayoutRebuilder.ForceRebuildLayoutImmediate`)
  targeted *when* the handle's geometry got computed, on the theory that it was stale/unresolved.
  Neither held. (Attempt 2 specifically couldn't have worked regardless: `LayoutRebuilder` only
  walks `ILayoutElement`/`ILayoutGroup` components, and `ScrollRect`/`Scrollbar` aren't in that
  family at all -- they're driven through `CanvasUpdateRegistry`'s separate pipeline.)
- **Diagnosis, not a third guess**: rather than keep guessing from code, every distinctly-colored
  element in the popup was temporarily recolored to a unique debug color and shipped for the user
  to screenshot. Reply: "red box" -- confirmed the handle, not the track/background/item
  highlight/blocker. Useful, but only narrowed *which component*, not *why* -- the bug wasn't in
  when the geometry updated, it was in what value one of its fields had never been given.
- **Attempts 3-4** (writing `handleRect.anchorMin`/`anchorMax` directly, then carefully reordering
  every other wiring call to guarantee that write was strictly last) were still fighting the "when"
  theory -- and *anchorMin*/*anchorMax* were never actually the problem to begin with, confirmed
  later by logging them: exactly correct on every single frame, all five attempts. Reordering fixed
  nothing because there was nothing wrong left to fix at that layer.
- **What actually broke the loop**: logging the live `RectTransform` values (`.rect`, `.anchorMin`,
  `.anchorMax`, `.sizeDelta`, parent `.rect`, from a `LateUpdate` for the first 5 frames) straight to
  BepInEx's log, and asking the user to paste them back. `Handle.sizeDelta=(100.00, 100.00)` was
  right there in the first line, next to `anchorMin`/`anchorMax` values that were completely
  correct -- the mismatch between "anchors are right" and "rect is still wrong" is exactly what
  should have pointed at sizeDelta many attempts earlier.

Also added while investigating (unrelated but a real gap this row exposed, kept in the final fix): a
static `_openDropdown` tracker on `SimpleDropdown` so opening one instance always closes any other
one that's open -- Give Item is the first row with two dropdowns side by side, and there was no
prior guarantee against both ending up open at once.

General lessons:

- When a fix doesn't work, don't refine the same theory a second time from pure code-reading -- get
  real evidence. Debug-coloring suspects narrowed *which* component; it took logging the actual
  field *values* to find *which field*. Screenshots answer "where"; logs answer "what."
- A RectTransform has (at least) four things that jointly determine its final rect: anchorMin,
  anchorMax, sizeDelta, and pivot. Getting one of them (anchors) provably correct on every frame is
  not the same as getting the *rect* correct -- `sizeDelta` defaults to `(100, 100)` on every fresh
  RectTransform and is silently additive under stretch anchors, not inert. When hand-building UI
  from raw `new GameObject(...)` (no prefab, no Inspector default of `(0,0)` to fall back on), set
  every dimension explicitly -- an unset one doesn't mean "no effect," it means "Unity's default,"
  which for `sizeDelta` is actively wrong for a stretched element.
- Five wrong-layer fixes in a row is a sign to change *category* of action, not to try a sixth
  variation of the same one. The thing that actually worked wasn't a cleverer fix -- it was
  switching from "guess, then verify by asking for a screenshot" to "log the exact values and read
  them directly." Escalate to real data sooner than five attempts in, next time.

Right after that fix landed, a second, separate bug surfaced in the same popup: the last item in a
dropdown list was cut off/unreadable. Both list builders (`BuildPlainList`, `BuildScrollingList`)
sized their container from `ItemHeight * count` alone, never adding in the `(count - 1)` inter-item
gaps `VerticalLayoutGroup.spacing` (1px) actually needs -- so every dropdown in the mod was always
very slightly short by that many pixels, negligible for a handful of options but big enough at 11
categories to visibly clip the last one. For the scrolling list specifically this was worse than
cosmetic: `ScrollRect` derives its scrollable range from `content.sizeDelta`, so the undersized
value made the bottom item permanently unreachable by scrolling, not just visually tight. Fixed by
adding a shared `ItemSpacing` constant and folding `Mathf.Max(0, count - 1) * ItemSpacing` into
every place a list's total height gets computed (`OpenPopup`'s `popupHeight`, and
`BuildScrollingList`'s `contentRT.sizeDelta`). Same lesson as the `sizeDelta` bug right above it,
different field: a hand-built layout's total size is the sum of every dimension a `LayoutGroup`
actually uses (item sizes *and* spacing *and* padding), not just the obvious term -- leaving one
out doesn't fail loudly, it just quietly undersizes the container by exactly that much.
