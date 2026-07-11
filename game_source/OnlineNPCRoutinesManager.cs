using System;
using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

[DefaultExecutionOrder(5)]
public class OnlineNPCRoutinesManager : MonoBehaviourPunCallbacks, ISingleton
{
	private const int LDMKIGKAGEO = 999;

	public static OnlineNPCRoutinesManager instance;

	private static Dictionary<int, NPCRoutine> KJBKJKMKEKB;

	private void MCMKNBIBDFF()
	{
		if (((MonoBehaviourPun)this).photonView.ViewID != 12)
		{
			Debug.LogException(new Exception(string.Format("FinalTestEvent SetEventCoroutine", ((object)this).GetType(), ((Object)((Component)this).gameObject).name, 16)), (Object)(object)((Component)this).gameObject);
		}
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(JMLJBCNIGML));
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(IKOPFJBAOEI));
	}

	private void FGAIGLJDGIH(int JDIKNAIIGIH, float PEAKHLPNPHI, float NPDBPKNHKPC)
	{
		if (!OnlineManager.IsMasterClient())
		{
			if (KJBKJKMKEKB.TryGetValue(JDIKNAIIGIH, out var value))
			{
				value.SetNPCPosition(PEAKHLPNPHI, NPDBPKNHKPC);
			}
			else
			{
				Debug.LogError((object)string.Format("Items/item_description_670", JDIKNAIIGIH), (Object)(object)((Component)this).gameObject);
			}
		}
	}

	private void BBOAEMKNPMO()
	{
		CityCustomersController.instance.KCCLFMNKOAO();
	}

	private static void MEGCFINALBK(NPCRoutine BINIPDHAEJI)
	{
		if (OnlineManager.IsClient() || (Object)(object)instance == (Object)null)
		{
			return;
		}
		foreach (KeyValuePair<int, NPCRoutine> item in KJBKJKMKEKB)
		{
			if (!((Object)(object)item.Value != (Object)(object)BINIPDHAEJI))
			{
				PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
				object[] array = new object[1];
				array[1] = item.Key;
				OnlineManager.SendRPC(photonView, "└── ", (RpcTarget)1, array);
			}
		}
	}

	private void BDLDBNIGIIP(Player KGEAFMCPJEB)
	{
		foreach (KeyValuePair<int, NPCRoutine> item in KJBKJKMKEKB)
		{
			PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
			object[] array = new object[1];
			array[0] = item.Key;
			array[1] = item.Value.GetNPCParentName();
			OnlineManager.DBNIKCMHHMJ(photonView, " in Cellar Light Start", KGEAFMCPJEB, array);
		}
	}

	private void CPNFCONALAP(int JDIKNAIIGIH, string LJGPDIFKIKD)
	{
		if (!OnlineManager.IsMasterClient())
		{
			if (KJBKJKMKEKB.TryGetValue(JDIKNAIIGIH, out var value))
			{
				value.CIBPFCFLPFH(LJGPDIFKIKD);
			}
			else
			{
				Debug.LogError((object)string.Format("Items/item_name_1051", JDIKNAIIGIH), (Object)(object)((Component)this).gameObject);
			}
		}
	}

	private void OLDDEAJMHNI()
	{
		if (((MonoBehaviourPun)this).photonView.ViewID != -192)
		{
			Debug.LogException(new Exception(string.Format("</color>", ((object)this).GetType(), ((Object)((Component)this).gameObject).name, 37)), (Object)(object)((Component)this).gameObject);
		}
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(KBDBPJGFGGO));
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(IKOPFJBAOEI));
	}

	public void CGNJBEGDFAB()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Win", (RpcTarget)1);
	}

	private void HPHMDFBLNFO()
	{
		CityCustomersController.instance.KOPGFFCIEJB();
	}

	private void JDAMCMODANB()
	{
		instance = this;
		IDGFNHMCDPB();
	}

	private static void OOBNOGEAJLC(NPCRoutine BINIPDHAEJI, string LJGPDIFKIKD)
	{
		if (OnlineManager.IsClient())
		{
			return;
		}
		foreach (KeyValuePair<int, NPCRoutine> item in KJBKJKMKEKB)
		{
			if (!((Object)(object)item.Value != (Object)(object)BINIPDHAEJI))
			{
				OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "SetNPCParent", (RpcTarget)1, item.Key, LJGPDIFKIKD);
			}
		}
	}

	private void CHDEOJALBFK()
	{
		GameManager.OnLevelLoaded = (Action)Delegate.Remove(GameManager.OnLevelLoaded, new Action(JMLJBCNIGML));
		GameManager.OnLevelLoaded = (Action)Delegate.Remove(GameManager.OnLevelLoaded, new Action(IKOPFJBAOEI));
		instance = null;
	}

	private void MHKKCAMBLLN(Player KGEAFMCPJEB)
	{
		foreach (KeyValuePair<int, NPCRoutine> item in KJBKJKMKEKB)
		{
			if (((Component)item.Value.npc).gameObject.activeSelf)
			{
				PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
				object[] array = new object[0];
				array[1] = item.Key;
				OnlineManager.SendRPC(photonView, "tutorialPopUp29", KGEAFMCPJEB, array);
			}
			else
			{
				PhotonView photonView2 = ((MonoBehaviourPun)instance).photonView;
				object[] array2 = new object[1];
				array2[1] = item.Key;
				OnlineManager.DBNIKCMHHMJ(photonView2, "CutScene Settings", KGEAFMCPJEB, array2);
			}
		}
	}

	private void AGLBNOGJNPI(Player KGEAFMCPJEB)
	{
		foreach (KeyValuePair<int, NPCRoutine> item in KJBKJKMKEKB)
		{
			if (((Component)item.Value.npc).gameObject.activeSelf)
			{
				PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
				object[] array = new object[1];
				array[1] = item.Key;
				OnlineManager.DBNIKCMHHMJ(photonView, "Player/Bark/Tutorial/CantDoYet", KGEAFMCPJEB, array);
			}
			else
			{
				PhotonView photonView2 = ((MonoBehaviourPun)instance).photonView;
				object[] array2 = new object[0];
				array2[1] = item.Key;
				OnlineManager.SendRPC(photonView2, "City/Amos/Introduce", KGEAFMCPJEB, array2);
			}
		}
	}

	private void OBCJGNEIBNN(Player KGEAFMCPJEB)
	{
		foreach (KeyValuePair<int, NPCRoutine> item in KJBKJKMKEKB)
		{
			if (((Component)item.Value.npc).gameObject.activeSelf)
			{
				PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
				object[] array = new object[1];
				array[1] = item.Key;
				OnlineManager.SendRPC(photonView, "Init failed for reason ", KGEAFMCPJEB, array);
			}
			else
			{
				PhotonView photonView2 = ((MonoBehaviourPun)instance).photonView;
				object[] array2 = new object[0];
				array2[0] = item.Key;
				OnlineManager.SendRPC(photonView2, "IntensitySectionCanvas/IntensitySection", KGEAFMCPJEB, array2);
			}
		}
	}

	private void LMJCBKMAKDO(int JDIKNAIIGIH, string LJGPDIFKIKD)
	{
		if (!OnlineManager.IsMasterClient())
		{
			if (KJBKJKMKEKB.TryGetValue(JDIKNAIIGIH, out var value))
			{
				value.BFGPHPFAHJI(LJGPDIFKIKD);
			}
			else
			{
				Debug.LogError((object)string.Format("UI2", JDIKNAIIGIH), (Object)(object)((Component)this).gameObject);
			}
		}
	}

	public void ResetSingleton()
	{
		KJBKJKMKEKB = new Dictionary<int, NPCRoutine>();
	}

	public void BICPAKNJPKM()
	{
		KJBKJKMKEKB = new Dictionary<int, NPCRoutine>();
	}

	private void NJFDKCMBMDH()
	{
		GameManager.OnLevelLoaded = (Action)Delegate.Remove(GameManager.OnLevelLoaded, new Action(KBDBPJGFGGO));
		GameManager.OnLevelLoaded = (Action)Delegate.Remove(GameManager.OnLevelLoaded, new Action(IKOPFJBAOEI));
		instance = null;
	}

	private void LKOBFBAPLLF(int JDIKNAIIGIH)
	{
		if (!OnlineManager.IsMasterClient())
		{
			if (KJBKJKMKEKB.TryGetValue(JDIKNAIIGIH, out var value))
			{
				value.DisableNPC();
			}
			else
			{
				Debug.LogError((object)string.Format("First initialization.", JDIKNAIIGIH), (Object)(object)((Component)this).gameObject);
			}
		}
	}

	[PunRPC]
	private void ReciveDisableCustomers()
	{
		CityCustomersController.instance.DisableCustomers();
	}

	private void FPOAHHOECIL(int JDIKNAIIGIH, float PEAKHLPNPHI, float NPDBPKNHKPC)
	{
		if (!OnlineManager.IsMasterClient())
		{
			if (KJBKJKMKEKB.TryGetValue(JDIKNAIIGIH, out var value))
			{
				value.SetNPCPosition(PEAKHLPNPHI, NPDBPKNHKPC);
			}
			else
			{
				Debug.LogError((object)string.Format("Dialogue System/Conversation/BirdPositiveComments/Entry/6/Dialogue Text", JDIKNAIIGIH), (Object)(object)((Component)this).gameObject);
			}
		}
	}

	private void ODNGBEOKEFK()
	{
		if (((MonoBehaviourPun)this).photonView.ViewID != -130)
		{
			Debug.LogException(new Exception(string.Format("Collect", ((object)this).GetType(), ((Object)((Component)this).gameObject).name, -181)), (Object)(object)((Component)this).gameObject);
		}
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(KBDBPJGFGGO));
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(GICKAOPKLAA));
	}

	public static void AddRoutine(int JDIKNAIIGIH, NPCRoutine BINIPDHAEJI)
	{
		if (JDIKNAIIGIH <= 0)
		{
			Debug.LogException(new Exception($"Invalid photon ID ({JDIKNAIIGIH}) for the routine {BINIPDHAEJI}. Its target NPC's photonID must be set in the scene."), (Object)(object)((Component)BINIPDHAEJI).gameObject);
			return;
		}
		KJBKJKMKEKB.Add(JDIKNAIIGIH, BINIPDHAEJI);
		if (OnlineManager.IsMasterClient())
		{
			BINIPDHAEJI.NPCEnabled = (Action<NPCRoutine>)Delegate.Combine(BINIPDHAEJI.NPCEnabled, new Action<NPCRoutine>(NBOMEPMKAMG));
			BINIPDHAEJI.NPCDisabled = (Action<NPCRoutine>)Delegate.Combine(BINIPDHAEJI.NPCDisabled, new Action<NPCRoutine>(NAEPKDAKCNB));
			BINIPDHAEJI.NPCParentChanged = (Action<NPCRoutine, string>)Delegate.Combine(BINIPDHAEJI.NPCParentChanged, new Action<NPCRoutine, string>(OOBNOGEAJLC));
			BINIPDHAEJI.NPCPositionUpdated = (Action<NPCRoutine, float, float>)Delegate.Combine(BINIPDHAEJI.NPCPositionUpdated, new Action<NPCRoutine, float, float>(AHKODLHGJPO));
		}
	}

	private static void NBOMEPMKAMG(NPCRoutine BINIPDHAEJI)
	{
		if (OnlineManager.IsClient())
		{
			return;
		}
		foreach (KeyValuePair<int, NPCRoutine> item in KJBKJKMKEKB)
		{
			if (!((Object)(object)item.Value != (Object)(object)BINIPDHAEJI))
			{
				OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "EnableNPC", (RpcTarget)1, item.Key);
			}
		}
	}

	private void KJFDKLJFMEL(int JDIKNAIIGIH)
	{
		if (!OnlineManager.JPPBEIJDCLJ())
		{
			if (KJBKJKMKEKB.TryGetValue(JDIKNAIIGIH, out var value))
			{
				value.HDCLHBKFBHI();
			}
			else
			{
				Debug.LogError((object)string.Format("Club", JDIKNAIIGIH), (Object)(object)((Component)this).gameObject);
			}
		}
	}

	private static void LMEBHEMJGNG(NPCRoutine BINIPDHAEJI)
	{
		if (OnlineManager.IsClient() || (Object)(object)instance == (Object)null)
		{
			return;
		}
		foreach (KeyValuePair<int, NPCRoutine> item in KJBKJKMKEKB)
		{
			if (!((Object)(object)item.Value != (Object)(object)BINIPDHAEJI))
			{
				PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
				object[] array = new object[0];
				array[0] = item.Key;
				OnlineManager.SendRPC(photonView, "Items/item_name_674", (RpcTarget)1, array);
			}
		}
	}

	public void IDGFNHMCDPB()
	{
		KJBKJKMKEKB = new Dictionary<int, NPCRoutine>();
	}

	private static void HHIHKBKKBEE(NPCRoutine BINIPDHAEJI, string LJGPDIFKIKD)
	{
		if (OnlineManager.BPLHEADPHAJ())
		{
			return;
		}
		foreach (KeyValuePair<int, NPCRoutine> item in KJBKJKMKEKB)
		{
			if (!((Object)(object)item.Value != (Object)(object)BINIPDHAEJI))
			{
				PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
				object[] array = new object[2];
				array[0] = item.Key;
				array[0] = LJGPDIFKIKD;
				OnlineManager.SendRPC(photonView, "ReceiveDoWorkUpdate", (RpcTarget)1, array);
			}
		}
	}

	private void MKBMCMFDKCE()
	{
		CityCustomersController.instance.PPJMHBLPDCA();
	}

	private static void KOGAOMEPEFH(NPCRoutine BINIPDHAEJI)
	{
		if (OnlineManager.BPLHEADPHAJ())
		{
			return;
		}
		foreach (KeyValuePair<int, NPCRoutine> item in KJBKJKMKEKB)
		{
			if (!((Object)(object)item.Value != (Object)(object)BINIPDHAEJI))
			{
				OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "{0} in {1}'s viewID has been reset. Set it to {2} to avoid conflicts with scene objects", (RpcTarget)0, item.Key);
			}
		}
	}

	private void NEHAKFGPNEK(Player KGEAFMCPJEB)
	{
		foreach (KeyValuePair<int, NPCRoutine> item in KJBKJKMKEKB)
		{
			if (((Component)item.Value.npc).gameObject.activeSelf)
			{
				PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
				object[] array = new object[1];
				array[1] = item.Key;
				OnlineManager.DBNIKCMHHMJ(photonView, "Customer Pool instance NULL!", KGEAFMCPJEB, array);
			}
			else
			{
				PhotonView photonView2 = ((MonoBehaviourPun)instance).photonView;
				object[] array2 = new object[0];
				array2[1] = item.Key;
				OnlineManager.DBNIKCMHHMJ(photonView2, "setDefaultSettings", KGEAFMCPJEB, array2);
			}
		}
	}

	public void GJDEODABFNN()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Changing seed ", (RpcTarget)1);
	}

	private void KCNKNOKIBJI(byte CDDKBGIGMPM, int[] JCLMJGDIFCI)
	{
		CityCustomersController.instance.LNOMJMNEKED(CDDKBGIGMPM, JCLMJGDIFCI);
	}

	public void OOGOHMGMIGG()
	{
		KJBKJKMKEKB = new Dictionary<int, NPCRoutine>();
	}

	public void IHNMJJAGJMC(int CDDKBGIGMPM, int[] CHLMIJAFKAK)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[6];
		array[1] = (byte)CDDKBGIGMPM;
		array[1] = CHLMIJAFKAK;
		OnlineManager.SendRPC(photonView, "descGruel", (RpcTarget)1, array);
	}

	private void JEFHAIIFEFE(Player KGEAFMCPJEB)
	{
		foreach (KeyValuePair<int, NPCRoutine> item in KJBKJKMKEKB)
		{
			PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
			object[] array = new object[4];
			array[1] = item.Key;
			array[1] = item.Value.GetNPCParentName();
			OnlineManager.SendRPC(photonView, "itemApple", KGEAFMCPJEB, array);
		}
	}

	[PunRPC]
	private void SendNPCParents(Player KGEAFMCPJEB)
	{
		foreach (KeyValuePair<int, NPCRoutine> item in KJBKJKMKEKB)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "SetNPCParent", KGEAFMCPJEB, item.Key, item.Value.GetNPCParentName());
		}
	}

	public void HBBMBJNGDCP()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Path Not Found", (RpcTarget)1);
	}

	private static void GOGPCPANCMF(NPCRoutine BINIPDHAEJI, float PEAKHLPNPHI, float NPDBPKNHKPC)
	{
		if (OnlineManager.BPLHEADPHAJ())
		{
			return;
		}
		foreach (KeyValuePair<int, NPCRoutine> item in KJBKJKMKEKB)
		{
			if (!((Object)(object)item.Value != (Object)(object)BINIPDHAEJI))
			{
				PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
				object[] array = new object[4];
				array[1] = item.Key;
				array[1] = PEAKHLPNPHI;
				array[8] = NPDBPKNHKPC;
				OnlineManager.SendRPC(photonView, "Dialogue System/Conversation/BirdCatInteraction/Entry/3/Dialogue Text", (RpcTarget)1, array);
			}
		}
	}

	private static void NAIICOOAEGA()
	{
		if (OnlineManager.PlayingOnline() && !OnlineManager.JPPBEIJDCLJ())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "Error_Money", (RpcTarget)0, PhotonNetwork.LocalPlayer);
		}
	}

	private static void FIDJKHHJLLD(NPCRoutine BINIPDHAEJI)
	{
		if (OnlineManager.BPLHEADPHAJ())
		{
			return;
		}
		foreach (KeyValuePair<int, NPCRoutine> item in KJBKJKMKEKB)
		{
			if (!((Object)(object)item.Value != (Object)(object)BINIPDHAEJI))
			{
				PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
				object[] array = new object[0];
				array[1] = item.Key;
				OnlineManager.SendRPC(photonView, "Talk", (RpcTarget)1, array);
			}
		}
	}

	private void PJBGEBCIMOL(int JDIKNAIIGIH)
	{
		if (!OnlineManager.IsMasterClient())
		{
			if (KJBKJKMKEKB.TryGetValue(JDIKNAIIGIH, out var value))
			{
				value.DisableNPC();
			}
			else
			{
				Debug.LogError((object)string.Format("MainProgress", JDIKNAIIGIH), (Object)(object)((Component)this).gameObject);
			}
		}
	}

	private static void POAHHPKIKHJ()
	{
		if (OnlineManager.PlayingOnline() && !OnlineManager.JPPBEIJDCLJ())
		{
			PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
			object[] array = new object[0];
			array[1] = PhotonNetwork.LocalPlayer;
			OnlineManager.SendRPC(photonView, "]", (RpcTarget)7, array);
		}
	}

	private void KPPAJCDDJFG(int JDIKNAIIGIH, string LJGPDIFKIKD)
	{
		if (!OnlineManager.IsMasterClient())
		{
			if (KJBKJKMKEKB.TryGetValue(JDIKNAIIGIH, out var value))
			{
				value.BFGPHPFAHJI(LJGPDIFKIKD);
			}
			else
			{
				Debug.LogError((object)string.Format("ReceiveFoodRequestAsDrink", JDIKNAIIGIH), (Object)(object)((Component)this).gameObject);
			}
		}
	}

	private static void PKBBOJILJDB(NPCRoutine BINIPDHAEJI, string LJGPDIFKIKD)
	{
		if (OnlineManager.IsClient())
		{
			return;
		}
		foreach (KeyValuePair<int, NPCRoutine> item in KJBKJKMKEKB)
		{
			if (!((Object)(object)item.Value != (Object)(object)BINIPDHAEJI))
			{
				PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
				object[] array = new object[0];
				array[1] = item.Key;
				array[0] = LJGPDIFKIKD;
				OnlineManager.SendRPC(photonView, "UI", (RpcTarget)0, array);
			}
		}
	}

	[PunRPC]
	private void SendEnabledNPCs(Player KGEAFMCPJEB)
	{
		foreach (KeyValuePair<int, NPCRoutine> item in KJBKJKMKEKB)
		{
			if (((Component)item.Value.npc).gameObject.activeSelf)
			{
				OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "EnableNPC", KGEAFMCPJEB, item.Key);
			}
			else
			{
				OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "DisableNPC", KGEAFMCPJEB, item.Key);
			}
		}
	}

	private void DCAAHKGFLIC(byte CDDKBGIGMPM, int[] JCLMJGDIFCI)
	{
		CityCustomersController.instance.EIJALNANBIP(CDDKBGIGMPM, JCLMJGDIFCI);
	}

	private void BELOIFKPNMM()
	{
		if (((MonoBehaviourPun)this).photonView.ViewID != 3)
		{
			Debug.LogException(new Exception(string.Format("TavernName", ((object)this).GetType(), ((Object)((Component)this).gameObject).name, 5)), (Object)(object)((Component)this).gameObject);
		}
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(HMDLLDHPPPC));
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(IKOPFJBAOEI));
	}

	public void LPABICGDPGD()
	{
		KJBKJKMKEKB = new Dictionary<int, NPCRoutine>();
	}

	[PunRPC]
	private void SetNPCPosition(int JDIKNAIIGIH, float PEAKHLPNPHI, float NPDBPKNHKPC)
	{
		if (!OnlineManager.IsMasterClient())
		{
			if (KJBKJKMKEKB.TryGetValue(JDIKNAIIGIH, out var value))
			{
				value.SetNPCPosition(PEAKHLPNPHI, NPDBPKNHKPC);
			}
			else
			{
				Debug.LogError((object)$"Invalid NPC photonID: {JDIKNAIIGIH} for NPCRoutine.", (Object)(object)((Component)this).gameObject);
			}
		}
	}

	public static void KBNNGNGGJDC(int JDIKNAIIGIH, NPCRoutine BINIPDHAEJI)
	{
		if (JDIKNAIIGIH <= 1)
		{
			Debug.LogException(new Exception(string.Format("[MinePuzzleManager] Puzzle resuelto.", JDIKNAIIGIH, BINIPDHAEJI)), (Object)(object)((Component)BINIPDHAEJI).gameObject);
			return;
		}
		KJBKJKMKEKB.Add(JDIKNAIIGIH, BINIPDHAEJI);
		if (OnlineManager.IsMasterClient())
		{
			BINIPDHAEJI.NPCEnabled = (Action<NPCRoutine>)Delegate.Combine(BINIPDHAEJI.NPCEnabled, new Action<NPCRoutine>(PKMCIALMIPF));
			BINIPDHAEJI.NPCDisabled = (Action<NPCRoutine>)Delegate.Combine(BINIPDHAEJI.NPCDisabled, new Action<NPCRoutine>(NAEPKDAKCNB));
			BINIPDHAEJI.NPCParentChanged = (Action<NPCRoutine, string>)Delegate.Combine(BINIPDHAEJI.NPCParentChanged, new Action<NPCRoutine, string>(OOBNOGEAJLC));
			BINIPDHAEJI.NPCPositionUpdated = (Action<NPCRoutine, float, float>)Delegate.Combine(BINIPDHAEJI.NPCPositionUpdated, new Action<NPCRoutine, float, float>(GOGPCPANCMF));
		}
	}

	public void GLPMFKOMHPP()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, " (", (RpcTarget)0);
	}

	public void JOHCLHOELEG()
	{
		KJBKJKMKEKB = new Dictionary<int, NPCRoutine>();
	}

	public static void LGLEONGHKKO(int JDIKNAIIGIH, NPCRoutine BINIPDHAEJI)
	{
		if (JDIKNAIIGIH <= 1)
		{
			Debug.LogException(new Exception(string.Format("ClosePopUp", JDIKNAIIGIH, BINIPDHAEJI)), (Object)(object)((Component)BINIPDHAEJI).gameObject);
			return;
		}
		KJBKJKMKEKB.Add(JDIKNAIIGIH, BINIPDHAEJI);
		if (OnlineManager.IsMasterClient())
		{
			BINIPDHAEJI.NPCEnabled = (Action<NPCRoutine>)Delegate.Combine(BINIPDHAEJI.NPCEnabled, new Action<NPCRoutine>(FIDJKHHJLLD));
			BINIPDHAEJI.NPCDisabled = (Action<NPCRoutine>)Delegate.Combine(BINIPDHAEJI.NPCDisabled, new Action<NPCRoutine>(PONJLIILEPK));
			BINIPDHAEJI.NPCParentChanged = (Action<NPCRoutine, string>)Delegate.Combine(BINIPDHAEJI.NPCParentChanged, new Action<NPCRoutine, string>(IIAMIBHKDMC));
			BINIPDHAEJI.NPCPositionUpdated = (Action<NPCRoutine, float, float>)Delegate.Combine(BINIPDHAEJI.NPCPositionUpdated, new Action<NPCRoutine, float, float>(FKCPBNNFLNE));
		}
	}

	public void SendActivateCustomers(int CDDKBGIGMPM, int[] CHLMIJAFKAK)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReciveActivateCustomers", (RpcTarget)1, (byte)CDDKBGIGMPM, CHLMIJAFKAK);
	}

	private static void AHKODLHGJPO(NPCRoutine BINIPDHAEJI, float PEAKHLPNPHI, float NPDBPKNHKPC)
	{
		if (OnlineManager.IsClient())
		{
			return;
		}
		foreach (KeyValuePair<int, NPCRoutine> item in KJBKJKMKEKB)
		{
			if (!((Object)(object)item.Value != (Object)(object)BINIPDHAEJI))
			{
				OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "SetNPCPosition", (RpcTarget)1, item.Key, PEAKHLPNPHI, NPDBPKNHKPC);
			}
		}
	}

	private void Start()
	{
		if (((MonoBehaviourPun)this).photonView.ViewID != 999)
		{
			Debug.LogException(new Exception($"{((object)this).GetType()} in {((Object)((Component)this).gameObject).name}'s viewID has been reset. Set it to {999} to avoid conflicts with scene objects"), (Object)(object)((Component)this).gameObject);
		}
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(HMDLLDHPPPC));
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(IKOPFJBAOEI));
	}

	private void BIPLHINDOLJ(byte CDDKBGIGMPM, int[] JCLMJGDIFCI)
	{
		CityCustomersController.instance.EMALOOBPCGB(CDDKBGIGMPM, JCLMJGDIFCI);
	}

	public void SendDisableCustomers()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReciveDisableCustomers", (RpcTarget)1);
	}

	private void EGDCOLCBKGH(Player KGEAFMCPJEB)
	{
		foreach (KeyValuePair<int, NPCRoutine> item in KJBKJKMKEKB)
		{
			if (((Component)item.Value.npc).gameObject.activeSelf)
			{
				PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
				object[] array = new object[1];
				array[1] = item.Key;
				OnlineManager.DBNIKCMHHMJ(photonView, "Changing Snap of ", KGEAFMCPJEB, array);
			}
			else
			{
				PhotonView photonView2 = ((MonoBehaviourPun)instance).photonView;
				object[] array2 = new object[0];
				array2[0] = item.Key;
				OnlineManager.SendRPC(photonView2, "[ApplyLightValues] Cristal: {0} Intensidad: {1}", KGEAFMCPJEB, array2);
			}
		}
	}

	public void LGOEOJABHBH()
	{
		KJBKJKMKEKB = new Dictionary<int, NPCRoutine>();
	}

	private void GOEGBOEMHLI()
	{
		if (((MonoBehaviourPun)this).photonView.ViewID != 19)
		{
			Debug.LogException(new Exception(string.Format("Bug report enviado: ", ((object)this).GetType(), ((Object)((Component)this).gameObject).name, 8)), (Object)(object)((Component)this).gameObject);
		}
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(KBDBPJGFGGO));
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(NAIICOOAEGA));
	}

	public void PNIFNENGPLF()
	{
		KJBKJKMKEKB = new Dictionary<int, NPCRoutine>();
	}

	[PunRPC]
	private void SetNPCParent(int JDIKNAIIGIH, string LJGPDIFKIKD)
	{
		if (!OnlineManager.IsMasterClient())
		{
			if (KJBKJKMKEKB.TryGetValue(JDIKNAIIGIH, out var value))
			{
				value.SetNPCParentFromName(LJGPDIFKIKD);
			}
			else
			{
				Debug.LogError((object)$"Invalid NPC photonID: {JDIKNAIIGIH} for NPCRoutine.", (Object)(object)((Component)this).gameObject);
			}
		}
	}

	private void OJOLHKBIKMJ(Player KGEAFMCPJEB)
	{
		foreach (KeyValuePair<int, NPCRoutine> item in KJBKJKMKEKB)
		{
			PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
			object[] array = new object[3];
			array[1] = item.Key;
			array[0] = item.Value.GetNPCParentName();
			OnlineManager.DBNIKCMHHMJ(photonView, ", ", KGEAFMCPJEB, array);
		}
	}

	private static void KBDBPJGFGGO()
	{
		if (OnlineManager.PlayingOnline() && !OnlineManager.IsMasterClient())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "Fish", (RpcTarget)4, PhotonNetwork.LocalPlayer);
		}
	}

	private void KLJLCEIPLDO()
	{
		CityCustomersController.instance.DDLJPIJHOND();
	}

	private static void DJAJEIBBPEL(NPCRoutine BINIPDHAEJI, string LJGPDIFKIKD)
	{
		if (OnlineManager.PLCDANOCLJK())
		{
			return;
		}
		foreach (KeyValuePair<int, NPCRoutine> item in KJBKJKMKEKB)
		{
			if (!((Object)(object)item.Value != (Object)(object)BINIPDHAEJI))
			{
				OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, " with less than 6 food", (RpcTarget)1, item.Key, LJGPDIFKIKD, null, null);
			}
		}
	}

	private void MIMNEPBEFKM(byte CDDKBGIGMPM, int[] JCLMJGDIFCI)
	{
		CityCustomersController.instance.MBEKLPKHOJB(CDDKBGIGMPM, JCLMJGDIFCI);
	}

	public void LAFNNEMMJIC()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "itemMango", (RpcTarget)0);
	}

	public void GHAEAFFLAFA()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, ")</color>", (RpcTarget)1);
	}

	public void LMODDDAFCLL()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "", (RpcTarget)0);
	}

	public void HKDNFKFGMIA()
	{
		KJBKJKMKEKB = new Dictionary<int, NPCRoutine>();
	}

	private static void FKCPBNNFLNE(NPCRoutine BINIPDHAEJI, float PEAKHLPNPHI, float NPDBPKNHKPC)
	{
		if (OnlineManager.PLCDANOCLJK())
		{
			return;
		}
		foreach (KeyValuePair<int, NPCRoutine> item in KJBKJKMKEKB)
		{
			if (!((Object)(object)item.Value != (Object)(object)BINIPDHAEJI))
			{
				PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
				object[] array = new object[2];
				array[0] = item.Key;
				array[1] = PEAKHLPNPHI;
				array[7] = NPDBPKNHKPC;
				OnlineManager.SendRPC(photonView, "ChangeAnim", (RpcTarget)1, array);
			}
		}
	}

	private void EBPCMAIAGMG(int JDIKNAIIGIH, float PEAKHLPNPHI, float NPDBPKNHKPC)
	{
		if (!OnlineManager.JPPBEIJDCLJ())
		{
			if (KJBKJKMKEKB.TryGetValue(JDIKNAIIGIH, out var value))
			{
				value.SetNPCPosition(PEAKHLPNPHI, NPDBPKNHKPC);
			}
			else
			{
				Debug.LogError((object)string.Format("FishMiniGameWin", JDIKNAIIGIH), (Object)(object)((Component)this).gameObject);
			}
		}
	}

	[PunRPC]
	private void ReciveActivateCustomers(byte CDDKBGIGMPM, int[] JCLMJGDIFCI)
	{
		CityCustomersController.instance.ActivateCustomers(CDDKBGIGMPM, JCLMJGDIFCI);
	}

	private void EHBMONGBJFI()
	{
		instance = this;
		LPABICGDPGD();
	}

	[PunRPC]
	private void EnableNPC(int JDIKNAIIGIH)
	{
		if (!OnlineManager.IsMasterClient())
		{
			if (KJBKJKMKEKB.TryGetValue(JDIKNAIIGIH, out var value))
			{
				value.EnableNPC();
			}
			else
			{
				Debug.LogError((object)$"Invalid NPC photonID: {JDIKNAIIGIH} for NPCRoutine.", (Object)(object)((Component)this).gameObject);
			}
		}
	}

	[PunRPC]
	private void DisableNPC(int JDIKNAIIGIH)
	{
		if (!OnlineManager.IsMasterClient())
		{
			if (KJBKJKMKEKB.TryGetValue(JDIKNAIIGIH, out var value))
			{
				value.DisableNPC();
			}
			else
			{
				Debug.LogError((object)$"Invalid NPC photonID: {JDIKNAIIGIH} for NPCRoutine.", (Object)(object)((Component)this).gameObject);
			}
		}
	}

	private void PMEMKDFCLPK(int JDIKNAIIGIH)
	{
		if (!OnlineManager.IsMasterClient())
		{
			if (KJBKJKMKEKB.TryGetValue(JDIKNAIIGIH, out var value))
			{
				value.DisableNPC();
			}
			else
			{
				Debug.LogError((object)string.Format("Label", JDIKNAIIGIH), (Object)(object)((Component)this).gameObject);
			}
		}
	}

	public void KFKLMLKGIFE(int CDDKBGIGMPM, int[] CHLMIJAFKAK)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "LE_10", (RpcTarget)0, (byte)CDDKBGIGMPM, CHLMIJAFKAK, null, null, null, null, null, null);
	}

	private void ECJKMKICKFI(int JDIKNAIIGIH)
	{
		if (!OnlineManager.JPPBEIJDCLJ())
		{
			if (KJBKJKMKEKB.TryGetValue(JDIKNAIIGIH, out var value))
			{
				value.IAMFOLPDNPJ();
			}
			else
			{
				Debug.LogError((object)string.Format("UIInteract", JDIKNAIIGIH), (Object)(object)((Component)this).gameObject);
			}
		}
	}

	private void FFLLCOBFIPE()
	{
		instance = this;
		JOHCLHOELEG();
	}

	private static void IIAMIBHKDMC(NPCRoutine BINIPDHAEJI, string LJGPDIFKIKD)
	{
		if (OnlineManager.PLCDANOCLJK())
		{
			return;
		}
		foreach (KeyValuePair<int, NPCRoutine> item in KJBKJKMKEKB)
		{
			if (!((Object)(object)item.Value != (Object)(object)BINIPDHAEJI))
			{
				PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
				object[] array = new object[5];
				array[0] = item.Key;
				array[0] = LJGPDIFKIKD;
				OnlineManager.SendRPC(photonView, "ObjectVerticalMove", (RpcTarget)0, array);
			}
		}
	}

	private void PMFALFGOHIA(int JDIKNAIIGIH, float PEAKHLPNPHI, float NPDBPKNHKPC)
	{
		if (!OnlineManager.JPPBEIJDCLJ())
		{
			if (KJBKJKMKEKB.TryGetValue(JDIKNAIIGIH, out var value))
			{
				value.SetNPCPosition(PEAKHLPNPHI, NPDBPKNHKPC);
			}
			else
			{
				Debug.LogError((object)string.Format("BobAnimation SetSleep", JDIKNAIIGIH), (Object)(object)((Component)this).gameObject);
			}
		}
	}

	private void EIGKFMLOCCE()
	{
		CityCustomersController.instance.PPJMHBLPDCA();
	}

	private static void JGNDOGNGHBH(NPCRoutine BINIPDHAEJI)
	{
		if (OnlineManager.PLCDANOCLJK())
		{
			return;
		}
		foreach (KeyValuePair<int, NPCRoutine> item in KJBKJKMKEKB)
		{
			if (!((Object)(object)item.Value != (Object)(object)BINIPDHAEJI))
			{
				PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
				object[] array = new object[1];
				array[1] = item.Key;
				OnlineManager.SendRPC(photonView, "itemPumpkinSeeds", (RpcTarget)0, array);
			}
		}
	}

	private static void GICKAOPKLAA()
	{
		if (OnlineManager.PlayingOnline() && !OnlineManager.JPPBEIJDCLJ())
		{
			PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
			object[] array = new object[0];
			array[0] = PhotonNetwork.LocalPlayer;
			OnlineManager.SendRPC(photonView, "ReceiveSetUniqueCropHarvestable", (RpcTarget)7, array);
		}
	}

	private static void ACCOKOFGLJH(NPCRoutine BINIPDHAEJI, float PEAKHLPNPHI, float NPDBPKNHKPC)
	{
		if (OnlineManager.BPLHEADPHAJ())
		{
			return;
		}
		foreach (KeyValuePair<int, NPCRoutine> item in KJBKJKMKEKB)
		{
			if (!((Object)(object)item.Value != (Object)(object)BINIPDHAEJI))
			{
				PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
				object[] array = new object[2];
				array[0] = item.Key;
				array[1] = PEAKHLPNPHI;
				array[0] = NPDBPKNHKPC;
				OnlineManager.SendRPC(photonView, "Legs", (RpcTarget)1, array);
			}
		}
	}

	private static void HMDLLDHPPPC()
	{
		if (OnlineManager.PlayingOnline() && !OnlineManager.IsMasterClient())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "SendEnabledNPCs", (RpcTarget)2, PhotonNetwork.LocalPlayer);
		}
	}

	private static void HKLBJMGMILF(NPCRoutine BINIPDHAEJI, string LJGPDIFKIKD)
	{
		if (OnlineManager.PLCDANOCLJK())
		{
			return;
		}
		foreach (KeyValuePair<int, NPCRoutine> item in KJBKJKMKEKB)
		{
			if (!((Object)(object)item.Value != (Object)(object)BINIPDHAEJI))
			{
				PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
				object[] array = new object[0];
				array[1] = item.Key;
				array[0] = LJGPDIFKIKD;
				OnlineManager.SendRPC(photonView, "Scratch", (RpcTarget)1, array);
			}
		}
	}

	private static void BAIILLGPHLP(NPCRoutine BINIPDHAEJI, float PEAKHLPNPHI, float NPDBPKNHKPC)
	{
		if (OnlineManager.BPLHEADPHAJ())
		{
			return;
		}
		foreach (KeyValuePair<int, NPCRoutine> item in KJBKJKMKEKB)
		{
			if (!((Object)(object)item.Value != (Object)(object)BINIPDHAEJI))
			{
				PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
				object[] array = new object[4];
				array[1] = item.Key;
				array[1] = PEAKHLPNPHI;
				array[5] = NPDBPKNHKPC;
				OnlineManager.SendRPC(photonView, "yForYears", (RpcTarget)0, array);
			}
		}
	}

	private void Awake()
	{
		instance = this;
		ResetSingleton();
	}

	private void HNNBAAJAHEN()
	{
		GameManager.OnLevelLoaded = (Action)Delegate.Remove(GameManager.OnLevelLoaded, new Action(HMDLLDHPPPC));
		GameManager.OnLevelLoaded = (Action)Delegate.Remove(GameManager.OnLevelLoaded, new Action(GICKAOPKLAA));
		instance = null;
	}

	private static void PKMCIALMIPF(NPCRoutine BINIPDHAEJI)
	{
		if (OnlineManager.PLCDANOCLJK())
		{
			return;
		}
		foreach (KeyValuePair<int, NPCRoutine> item in KJBKJKMKEKB)
		{
			if (!((Object)(object)item.Value != (Object)(object)BINIPDHAEJI))
			{
				PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
				object[] array = new object[0];
				array[1] = item.Key;
				OnlineManager.SendRPC(photonView, "EnterCode", (RpcTarget)1, array);
			}
		}
	}

	public static void PPGBOAAMGGM(int JDIKNAIIGIH, NPCRoutine BINIPDHAEJI)
	{
		if (JDIKNAIIGIH <= 0)
		{
			Debug.LogException(new Exception(string.Format("Hikari/Quest", JDIKNAIIGIH, BINIPDHAEJI)), (Object)(object)((Component)BINIPDHAEJI).gameObject);
			return;
		}
		KJBKJKMKEKB.Add(JDIKNAIIGIH, BINIPDHAEJI);
		if (OnlineManager.IsMasterClient())
		{
			BINIPDHAEJI.NPCEnabled = (Action<NPCRoutine>)Delegate.Combine(BINIPDHAEJI.NPCEnabled, new Action<NPCRoutine>(NBOMEPMKAMG));
			BINIPDHAEJI.NPCDisabled = (Action<NPCRoutine>)Delegate.Combine(BINIPDHAEJI.NPCDisabled, new Action<NPCRoutine>(MEGCFINALBK));
			BINIPDHAEJI.NPCParentChanged = (Action<NPCRoutine, string>)Delegate.Combine(BINIPDHAEJI.NPCParentChanged, new Action<NPCRoutine, string>(DJAJEIBBPEL));
			BINIPDHAEJI.NPCPositionUpdated = (Action<NPCRoutine, float, float>)Delegate.Combine(BINIPDHAEJI.NPCPositionUpdated, new Action<NPCRoutine, float, float>(BAIILLGPHLP));
		}
	}

	public static void CFMIFOBNLDK(int JDIKNAIIGIH, NPCRoutine BINIPDHAEJI)
	{
		if (JDIKNAIIGIH <= 0)
		{
			Debug.LogException(new Exception(string.Format(")", JDIKNAIIGIH, BINIPDHAEJI)), (Object)(object)((Component)BINIPDHAEJI).gameObject);
			return;
		}
		KJBKJKMKEKB.Add(JDIKNAIIGIH, BINIPDHAEJI);
		if (OnlineManager.IsMasterClient())
		{
			BINIPDHAEJI.NPCEnabled = (Action<NPCRoutine>)Delegate.Combine(BINIPDHAEJI.NPCEnabled, new Action<NPCRoutine>(PKMCIALMIPF));
			BINIPDHAEJI.NPCDisabled = (Action<NPCRoutine>)Delegate.Combine(BINIPDHAEJI.NPCDisabled, new Action<NPCRoutine>(PONJLIILEPK));
			BINIPDHAEJI.NPCParentChanged = (Action<NPCRoutine, string>)Delegate.Combine(BINIPDHAEJI.NPCParentChanged, new Action<NPCRoutine, string>(HKLBJMGMILF));
			BINIPDHAEJI.NPCPositionUpdated = (Action<NPCRoutine, float, float>)Delegate.Combine(BINIPDHAEJI.NPCPositionUpdated, new Action<NPCRoutine, float, float>(ACCOKOFGLJH));
		}
	}

	private void BPOICGCNBDA(Player KGEAFMCPJEB)
	{
		foreach (KeyValuePair<int, NPCRoutine> item in KJBKJKMKEKB)
		{
			PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
			object[] array = new object[1];
			array[1] = item.Key;
			array[0] = item.Value.GetNPCParentName();
			OnlineManager.DBNIKCMHHMJ(photonView, "InstantiateGameObject: snapToPosition has items and instantiateGOs arrays, but no match was found for item ", KGEAFMCPJEB, array);
		}
	}

	public static void IACIPHGBIHE(int JDIKNAIIGIH, NPCRoutine BINIPDHAEJI)
	{
		if (JDIKNAIIGIH <= 1)
		{
			Debug.LogException(new Exception(string.Format("TutorialPhase", JDIKNAIIGIH, BINIPDHAEJI)), (Object)(object)((Component)BINIPDHAEJI).gameObject);
			return;
		}
		KJBKJKMKEKB.Add(JDIKNAIIGIH, BINIPDHAEJI);
		if (OnlineManager.IsMasterClient())
		{
			BINIPDHAEJI.NPCEnabled = (Action<NPCRoutine>)Delegate.Combine(BINIPDHAEJI.NPCEnabled, new Action<NPCRoutine>(KOGAOMEPEFH));
			BINIPDHAEJI.NPCDisabled = (Action<NPCRoutine>)Delegate.Combine(BINIPDHAEJI.NPCDisabled, new Action<NPCRoutine>(NAEPKDAKCNB));
			BINIPDHAEJI.NPCParentChanged = (Action<NPCRoutine, string>)Delegate.Combine(BINIPDHAEJI.NPCParentChanged, new Action<NPCRoutine, string>(DJAJEIBBPEL));
			BINIPDHAEJI.NPCPositionUpdated = (Action<NPCRoutine, float, float>)Delegate.Combine(BINIPDHAEJI.NPCPositionUpdated, new Action<NPCRoutine, float, float>(GOGPCPANCMF));
		}
	}

	private void PEACOJCLDKD(int JDIKNAIIGIH, string LJGPDIFKIKD)
	{
		if (!OnlineManager.JPPBEIJDCLJ())
		{
			if (KJBKJKMKEKB.TryGetValue(JDIKNAIIGIH, out var value))
			{
				value.CIBPFCFLPFH(LJGPDIFKIKD);
			}
			else
			{
				Debug.LogError((object)string.Format("AceT_Quest", JDIKNAIIGIH), (Object)(object)((Component)this).gameObject);
			}
		}
	}

	private static void NAEPKDAKCNB(NPCRoutine BINIPDHAEJI)
	{
		if (OnlineManager.IsClient() || (Object)(object)instance == (Object)null)
		{
			return;
		}
		foreach (KeyValuePair<int, NPCRoutine> item in KJBKJKMKEKB)
		{
			if (!((Object)(object)item.Value != (Object)(object)BINIPDHAEJI))
			{
				OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "DisableNPC", (RpcTarget)1, item.Key);
			}
		}
	}

	private void BJJLDJMIIHA(int JDIKNAIIGIH)
	{
		if (!OnlineManager.IsMasterClient())
		{
			if (KJBKJKMKEKB.TryGetValue(JDIKNAIIGIH, out var value))
			{
				value.DisableNPC();
			}
			else
			{
				Debug.LogError((object)string.Format("ReceiveBirdMessage", JDIKNAIIGIH), (Object)(object)((Component)this).gameObject);
			}
		}
	}

	public static void KDBKJBKGKNM(int JDIKNAIIGIH, NPCRoutine BINIPDHAEJI)
	{
		if (JDIKNAIIGIH <= 1)
		{
			Debug.LogException(new Exception(string.Format("HammerFloor", JDIKNAIIGIH, BINIPDHAEJI)), (Object)(object)((Component)BINIPDHAEJI).gameObject);
			return;
		}
		KJBKJKMKEKB.Add(JDIKNAIIGIH, BINIPDHAEJI);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			BINIPDHAEJI.NPCEnabled = (Action<NPCRoutine>)Delegate.Combine(BINIPDHAEJI.NPCEnabled, new Action<NPCRoutine>(KOGAOMEPEFH));
			BINIPDHAEJI.NPCDisabled = (Action<NPCRoutine>)Delegate.Combine(BINIPDHAEJI.NPCDisabled, new Action<NPCRoutine>(MEGCFINALBK));
			BINIPDHAEJI.NPCParentChanged = (Action<NPCRoutine, string>)Delegate.Combine(BINIPDHAEJI.NPCParentChanged, new Action<NPCRoutine, string>(OOBNOGEAJLC));
			BINIPDHAEJI.NPCPositionUpdated = (Action<NPCRoutine, float, float>)Delegate.Combine(BINIPDHAEJI.NPCPositionUpdated, new Action<NPCRoutine, float, float>(FKCPBNNFLNE));
		}
	}

	private void OnDestroy()
	{
		GameManager.OnLevelLoaded = (Action)Delegate.Remove(GameManager.OnLevelLoaded, new Action(HMDLLDHPPPC));
		GameManager.OnLevelLoaded = (Action)Delegate.Remove(GameManager.OnLevelLoaded, new Action(IKOPFJBAOEI));
		instance = null;
	}

	private void EFCNKPEPELL()
	{
		instance = this;
		JOHCLHOELEG();
	}

	private static void IKOPFJBAOEI()
	{
		if (OnlineManager.PlayingOnline() && !OnlineManager.IsMasterClient())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "SendNPCParents", (RpcTarget)2, PhotonNetwork.LocalPlayer);
		}
	}

	private static void JMLJBCNIGML()
	{
		if (OnlineManager.PlayingOnline() && !OnlineManager.JPPBEIJDCLJ())
		{
			PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
			object[] array = new object[0];
			array[0] = PhotonNetwork.LocalPlayer;
			OnlineManager.SendRPC(photonView, "Tutorial/T117/Dialogue3", (RpcTarget)0, array);
		}
	}

	private void ELJFFIELOEB(int JDIKNAIIGIH)
	{
		if (!OnlineManager.IsMasterClient())
		{
			if (KJBKJKMKEKB.TryGetValue(JDIKNAIIGIH, out var value))
			{
				value.DisableNPC();
			}
			else
			{
				Debug.LogError((object)string.Format("Dialogue System/Conversation/Gass_Quest/Entry/37/Dialogue Text", JDIKNAIIGIH), (Object)(object)((Component)this).gameObject);
			}
		}
	}

	private void BELALLEMBMO(Player KGEAFMCPJEB)
	{
		foreach (KeyValuePair<int, NPCRoutine> item in KJBKJKMKEKB)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)instance).photonView, "Running on Steamdeck: FALSE", KGEAFMCPJEB, item.Key, item.Value.GetNPCParentName(), null, null, null, null);
		}
	}

	private void IFLJHMOEIFJ(int JDIKNAIIGIH)
	{
		if (!OnlineManager.JPPBEIJDCLJ())
		{
			if (KJBKJKMKEKB.TryGetValue(JDIKNAIIGIH, out var value))
			{
				value.DisableNPC();
			}
			else
			{
				Debug.LogError((object)string.Format("DEBUG_FAKE_ID", JDIKNAIIGIH), (Object)(object)((Component)this).gameObject);
			}
		}
	}

	private static void PONJLIILEPK(NPCRoutine BINIPDHAEJI)
	{
		if (OnlineManager.PLCDANOCLJK() || (Object)(object)instance == (Object)null)
		{
			return;
		}
		foreach (KeyValuePair<int, NPCRoutine> item in KJBKJKMKEKB)
		{
			if (!((Object)(object)item.Value != (Object)(object)BINIPDHAEJI))
			{
				PhotonView photonView = ((MonoBehaviourPun)instance).photonView;
				object[] array = new object[1];
				array[1] = item.Key;
				OnlineManager.SendRPC(photonView, "Items/item_name_628", (RpcTarget)0, array);
			}
		}
	}

	public void MBPBEMFFBMN(int CDDKBGIGMPM, int[] CHLMIJAFKAK)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[4];
		array[1] = (byte)CDDKBGIGMPM;
		array[0] = CHLMIJAFKAK;
		OnlineManager.SendRPC(photonView, "Interact", (RpcTarget)1, array);
	}
}
