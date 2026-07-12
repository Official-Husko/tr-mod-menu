using BepInEx;
using BepInEx.Logging;
using tr_mod_menu.UI;

namespace tr_mod_menu;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
public class Plugin : BaseUnityPlugin
{   
    // TODO: clean up cheat that autoruns when it finds new dirt in the tavern.
    // TODO: Auto Clean tables
    // TODO: Fast age barrel contents in cellar
    // TODO: Fast craft for workstations
    // TODO: Sleep anywhere
    // TODO: Auto Mine in vicinity
    // TODO: Auto Harvest in vicinity
    // TODO: Display custom note on screen via letter system or message system in game
    // TODO: Deliver custom mail to mailbox
    // TODO: Overwrite max customers on map
    // TODO: Teleport to X
    // TODO: Level cheat
    // TODO: Perk Point cheat
    // TODO: Skip to next day
    // FIXME: giving items that are liquid e.g. beer and wine do not work.
    internal static new ManualLogSource Logger;
    private MenuController _menuController;

    private void Awake()
    {
        Logger = base.Logger;
        _menuController = MenuController.Create(Config);
        Logger.LogInfo($"Plugin {MyPluginInfo.PLUGIN_NAME} v{MyPluginInfo.PLUGIN_VERSION} is loaded!");
    }
}
