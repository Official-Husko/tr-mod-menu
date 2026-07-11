using BepInEx;
using BepInEx.Logging;
using tr_mod_menu.UI;

namespace tr_mod_menu;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
public class Plugin : BaseUnityPlugin
{
    internal static new ManualLogSource Logger;
    private MenuController _menuController;

    private void Awake()
    {
        Logger = base.Logger;
        _menuController = MenuController.Create(Config);
        Logger.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");
    }
}
