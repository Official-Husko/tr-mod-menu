using System;
using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class OnlinePlayerDataManager : MonoBehaviourPunCallbacks, ISingleton
{
	public static OnlinePlayerDataManager instance;

	public Action OnActorBedAssigned = delegate
	{
	};

	public static Dictionary<int, OnlinePlayerData> Players = new Dictionary<int, OnlinePlayerData>();

	private Dictionary<int, int> BKBOPOAOBIP = new Dictionary<int, int>();

	private static int MMFHANPALHI;

	private static OnlinePlayerData BGAGHKMEKNH;

	public static Gender GetPlayerGender(int MPMECNEJOMB)
	{
		if (!PlayerExists(MPMECNEJOMB))
		{
			return Gender.Unisex;
		}
		return Players[MPMECNEJOMB].gender;
	}

	public static void AddActorBedAssigned(int JJPJHIHBOIB, int GJDMLMEMKMD, bool HLHAICFGNGP = true)
	{
		Debug.Log((object)("ActorBedAssigned added actorNumber: " + JJPJHIHBOIB + " bedAssigned: " + GJDMLMEMKMD));
		if (instance.BKBOPOAOBIP.ContainsKey(JJPJHIHBOIB))
		{
			instance.BKBOPOAOBIP[JJPJHIHBOIB] = GJDMLMEMKMD;
		}
		else
		{
			instance.BKBOPOAOBIP.Add(JJPJHIHBOIB, GJDMLMEMKMD);
		}
		if (HLHAICFGNGP)
		{
			instance.OnActorBedAssigned();
		}
	}

	public static int AMKENIGKFCF(string IMFLEJALLNJ)
	{
		foreach (KeyValuePair<int, OnlinePlayerData> player in Players)
		{
			if (player.Value.playerName == IMFLEJALLNJ)
			{
				return GetPlayerNumByActorNumber(player.Value.actorNumber);
			}
		}
		if (Application.isEditor)
		{
			Debug.LogError((object)("ReceiveCompletedMission" + IMFLEJALLNJ + "[MinePuzzleManager] Element {0} assigned to spawner {1} on piece {2}"));
		}
		return 1;
	}

	private static void FJNOAEBCDJI()
	{
		Players.Clear();
		Players = new Dictionary<int, OnlinePlayerData>();
		MMFHANPALHI = 0;
	}

	public static bool EEPJDEGHJLJ(PlatformOS DJBHINLJOBO)
	{
		return Utils.FIGOCKBBIFO(DJBHINLJOBO);
	}

	private static void CAAMEEBOAOF(Player HCPKKOBFHDN, int GELMAIBEHDO)
	{
		if (Players.ContainsKey(HCPKKOBFHDN.ActorNumber))
		{
			Debug.LogException(new Exception($"Player with actor number {HCPKKOBFHDN.ActorNumber} already exists in the dictionary. This shouldn't happen."));
			return;
		}
		OnlinePlayerData value = new OnlinePlayerData(HCPKKOBFHDN, GELMAIBEHDO);
		Players.Add(HCPKKOBFHDN.ActorNumber, value);
		OnlineManager.NetworkLog($"New player added as local player {GELMAIBEHDO} with actor number {HCPKKOBFHDN.ActorNumber}");
	}

	private static void DLJEDLDAMIO(Player HCPKKOBFHDN, int GELMAIBEHDO)
	{
		if (Players.ContainsKey(HCPKKOBFHDN.ActorNumber))
		{
			Debug.LogException(new Exception(string.Format("Skin", HCPKKOBFHDN.ActorNumber)));
			return;
		}
		OnlinePlayerData value = new OnlinePlayerData(HCPKKOBFHDN, GELMAIBEHDO);
		Players.Add(HCPKKOBFHDN.ActorNumber, value);
		OnlineManager.NetworkLog(string.Format("Dialogue System/Conversation/Crowly_Standar/Entry/42/Dialogue Text", GELMAIBEHDO, HCPKKOBFHDN.ActorNumber), KDPDNOJAAPK: true, PMDIIFECEOD: false, ILMKCLKMACA: true);
	}

	public static int JBDEFDMGCDA(int JIIGOACEIKL)
	{
		if (OnlineManager.IsOffline())
		{
			return JIIGOACEIKL;
		}
		if ((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL) != (Object)null)
		{
			return GetBedAssignedByActorNumber(((MonoBehaviourPun)PlayerController.OPHDCMJLLEC(JIIGOACEIKL).onlinePlayer).photonView.OwnerActorNr);
		}
		if (Application.isEditor)
		{
			Debug.LogWarning((object)string.Format("Items/item_name_1120", JIIGOACEIKL));
		}
		return 1;
	}

	public static bool IsPlayerOnSteam(PlatformOS DJBHINLJOBO)
	{
		return Utils.FIGOCKBBIFO(DJBHINLJOBO);
	}

	public static int GetPlayerNumByBedAssigned(int HDNAFIPKEOF)
	{
		try
		{
			if (!OnlineManager.PlayingOnline())
			{
				return HDNAFIPKEOF;
			}
			return GetPlayerNumByActorNumber(GetActorNumberByBedAssigned(HDNAFIPKEOF));
		}
		catch
		{
			if (Application.isEditor)
			{
				Debug.LogError((object)$"Error with assigned bed {HDNAFIPKEOF}");
			}
			return 0;
		}
	}

	public static IEnumerator RemoveActorBedAssignedCoroutine(int JJPJHIHBOIB)
	{
		yield return null;
		Debug.Log((object)("ActorBedAssigned removed actorNumber: " + JJPJHIHBOIB));
		instance.BKBOPOAOBIP.Remove(JJPJHIHBOIB);
	}

	private void NGIPIFFOPDA(int MPMECNEJOMB, string LNHBAFGPGBJ)
	{
		if (PIOCEPCFHDK(MPMECNEJOMB))
		{
			JIDKIOJAPDD(MPMECNEJOMB).playerName = LNHBAFGPGBJ;
			OnlineManager.NetworkLog(string.Format("Coming soon!", MPMECNEJOMB, LNHBAFGPGBJ), KDPDNOJAAPK: false, PMDIIFECEOD: false, ILMKCLKMACA: true);
		}
	}

	private static void BPBIJJBOPHM(PhotonView KMBDEJMAAAE)
	{
		if (PlayerExists(KMBDEJMAAAE.Controller.ActorNumber))
		{
			Players[KMBDEJMAAAE.Controller.ActorNumber].GCMJOKLLEMO(KMBDEJMAAAE);
		}
	}

	public static OnlinePlayerData FindByLocalPlayerNum(int GELMAIBEHDO)
	{
		foreach (OnlinePlayerData value in Players.Values)
		{
			if (value.playerNum == GELMAIBEHDO)
			{
				return value;
			}
		}
		Debug.LogError((object)$"Player with playerNum {GELMAIBEHDO} does not exist or has been removed from the dictionary after disconnecting.");
		return null;
	}

	private void Awake()
	{
		instance = this;
		ResetSingleton();
	}

	private void PKFMLJGJKCP()
	{
		OnlineManager.OnNetworkStateChanged = (Action<NetworkState>)Delegate.Remove(OnlineManager.OnNetworkStateChanged, new Action<NetworkState>(NPPABGPFLCJ));
		OnlinePlayer.OnlinePlayerInitialized = (Action<Player, int>)Delegate.Remove(OnlinePlayer.OnlinePlayerInitialized, new Action<Player, int>(CAAMEEBOAOF));
		OnlinePlayer.OnlinePlayerDestroyed = (Action<Player>)Delegate.Remove(OnlinePlayer.OnlinePlayerDestroyed, new Action<Player>(PEAGACNCGFL));
		OnlinePlayer.OnlinePlayerNameChanged = (Action<int, string>)Delegate.Remove(OnlinePlayer.OnlinePlayerNameChanged, new Action<int, string>(CFJJGHKGILL));
		OnlinePlayer.OnlinePlayerGenderChanged = (Action<int, Gender>)Delegate.Remove(OnlinePlayer.OnlinePlayerGenderChanged, new Action<int, Gender>(KHIEAJGEIMF));
		OnlinePlayer.OnlinePlayerSpawned = (Action<PhotonView>)Delegate.Remove(OnlinePlayer.OnlinePlayerSpawned, new Action<PhotonView>(IPHFFGIBHNG));
		OnlinePlayer.OnlinePlayerPlatformID = (Action<int, string, PlatformOS>)Delegate.Remove(OnlinePlayer.OnlinePlayerPlatformID, new Action<int, string, PlatformOS>(KMLGLOINNPG));
		if (Object.op_Implicit((Object)(object)GameManager.NJNFHEPLEHL()))
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(OFDMNIEGMCF));
		}
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public static string GetPlayerNameByBedAssigned(int HDNAFIPKEOF)
	{
		try
		{
			return GetPlayerName(GetActorNumberByBedAssigned(HDNAFIPKEOF));
		}
		catch
		{
			if (Application.isEditor)
			{
				Debug.LogError((object)$"Error with assigned bed {HDNAFIPKEOF}");
			}
			return "";
		}
	}

	public static Gender GGPPENHHFAD(int MPMECNEJOMB)
	{
		if (!CCJCKFDKICG(MPMECNEJOMB))
		{
			return Gender.Unisex;
		}
		return Players[MPMECNEJOMB].gender;
	}

	public static int AKLPADOCHDP(int MPMECNEJOMB)
	{
		if (instance.BKBOPOAOBIP.ContainsKey(MPMECNEJOMB))
		{
			return instance.BKBOPOAOBIP[MPMECNEJOMB];
		}
		if (Application.isEditor && MPMECNEJOMB != 0)
		{
			Debug.LogWarning((object)string.Format("ReceiveSelectPerkLevel", MPMECNEJOMB));
		}
		return 1;
	}

	public static int GetActorNumberByBedAssigned(int GJDMLMEMKMD)
	{
		foreach (KeyValuePair<int, int> item in instance.BKBOPOAOBIP)
		{
			if (item.Value == GJDMLMEMKMD)
			{
				return item.Key;
			}
		}
		if (Application.isEditor)
		{
			Debug.LogWarning((object)$"Error with assigned bed {GJDMLMEMKMD}.");
		}
		return 0;
	}

	public static bool CCJCKFDKICG(int MPMECNEJOMB)
	{
		if (!Players.ContainsKey(MPMECNEJOMB))
		{
			Debug.LogWarning((object)string.Format("ClosePopUp", MPMECNEJOMB));
			return false;
		}
		return true;
	}

	private void CFJJGHKGILL(int MPMECNEJOMB, string LNHBAFGPGBJ)
	{
		if (PlayerExists(MPMECNEJOMB))
		{
			Find(MPMECNEJOMB).playerName = LNHBAFGPGBJ;
			OnlineManager.NetworkLog($"Player {MPMECNEJOMB} name changed: {LNHBAFGPGBJ}");
		}
	}

	public override void OnPlayerLeftRoom(Player HCPKKOBFHDN)
	{
		NCFKAEBLMJN(HCPKKOBFHDN);
		((MonoBehaviour)this).StartCoroutine(RemoveActorBedAssignedCoroutine(HCPKKOBFHDN.ActorNumber));
	}

	public static string GetPlayerName(int MPMECNEJOMB)
	{
		if (!PlayerExists(MPMECNEJOMB))
		{
			return "";
		}
		return Players[MPMECNEJOMB].playerName;
	}

	private void KHIEAJGEIMF(int MPMECNEJOMB, Gender OHMAEGCHIOC)
	{
		if (PlayerExists(MPMECNEJOMB))
		{
			Find(MPMECNEJOMB).gender = OHMAEGCHIOC;
			OnlineManager.NetworkLog($"Player {MPMECNEJOMB} gender changed: {OHMAEGCHIOC}");
		}
	}

	public static bool ONCJDICJILF(PlatformOS DJBHINLJOBO)
	{
		return Utils.FIGOCKBBIFO(DJBHINLJOBO);
	}

	private static void PEAGACNCGFL(Player HCPKKOBFHDN)
	{
		if (HCPKKOBFHDN != null && PIOCEPCFHDK(HCPKKOBFHDN.ActorNumber) && !((Object)(object)OnlineBedroomsManager.instance == (Object)null))
		{
			OnlineBedroomsManager.instance.OGLBBPCNMNI(HCPKKOBFHDN.ActorNumber);
			Players.Remove(HCPKKOBFHDN.ActorNumber);
			OnlineManager.NetworkLog(string.Format("{0}\nPlayers: {1}/{2}", HCPKKOBFHDN.ActorNumber, Players.Count), KDPDNOJAAPK: true);
		}
	}

	public static string EDKBGMHNDLJ(int MPMECNEJOMB)
	{
		if (!PlayerExists(MPMECNEJOMB))
		{
			return "Dialogue System/Conversation/Crowly_SkelletonBird/Entry/1/Dialogue Text";
		}
		return Players[MPMECNEJOMB].playerName;
	}

	public static Gender GetPlayerGenderByBedAssigned(int HDNAFIPKEOF)
	{
		try
		{
			return GetPlayerGender(GetActorNumberByBedAssigned(HDNAFIPKEOF));
		}
		catch
		{
			if (Application.isEditor)
			{
				Debug.LogError((object)$"Error with assigned bed {HDNAFIPKEOF}");
			}
			return Gender.Unisex;
		}
	}

	public static void JGIMEMHOIGC(int JJPJHIHBOIB, int GJDMLMEMKMD, bool HLHAICFGNGP = true)
	{
		Debug.Log((object)("Remove" + JJPJHIHBOIB + "Stand" + GJDMLMEMKMD));
		if (instance.BKBOPOAOBIP.ContainsKey(JJPJHIHBOIB))
		{
			instance.BKBOPOAOBIP[JJPJHIHBOIB] = GJDMLMEMKMD;
		}
		else
		{
			instance.BKBOPOAOBIP.Add(JJPJHIHBOIB, GJDMLMEMKMD);
		}
		if (HLHAICFGNGP)
		{
			instance.OnActorBedAssigned();
		}
	}

	private void OFDMNIEGMCF()
	{
		if (OnlineManager.IsMasterClient())
		{
			JGIMEMHOIGC(PhotonNetwork.LocalPlayer.ActorNumber, 1);
		}
	}

	private void OnDestroy()
	{
		OnlineManager.OnNetworkStateChanged = (Action<NetworkState>)Delegate.Remove(OnlineManager.OnNetworkStateChanged, new Action<NetworkState>(NPPABGPFLCJ));
		OnlinePlayer.OnlinePlayerInitialized = (Action<Player, int>)Delegate.Remove(OnlinePlayer.OnlinePlayerInitialized, new Action<Player, int>(CAAMEEBOAOF));
		OnlinePlayer.OnlinePlayerDestroyed = (Action<Player>)Delegate.Remove(OnlinePlayer.OnlinePlayerDestroyed, new Action<Player>(NCFKAEBLMJN));
		OnlinePlayer.OnlinePlayerNameChanged = (Action<int, string>)Delegate.Remove(OnlinePlayer.OnlinePlayerNameChanged, new Action<int, string>(CFJJGHKGILL));
		OnlinePlayer.OnlinePlayerGenderChanged = (Action<int, Gender>)Delegate.Remove(OnlinePlayer.OnlinePlayerGenderChanged, new Action<int, Gender>(KHIEAJGEIMF));
		OnlinePlayer.OnlinePlayerSpawned = (Action<PhotonView>)Delegate.Remove(OnlinePlayer.OnlinePlayerSpawned, new Action<PhotonView>(BPBIJJBOPHM));
		OnlinePlayer.OnlinePlayerPlatformID = (Action<int, string, PlatformOS>)Delegate.Remove(OnlinePlayer.OnlinePlayerPlatformID, new Action<int, string, PlatformOS>(KMLGLOINNPG));
		if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
		}
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public static void RemoveActorBedAssignedNextFrame(int JJPJHIHBOIB)
	{
		if ((Object)(object)instance != (Object)null)
		{
			((MonoBehaviour)instance).StartCoroutine(RemoveActorBedAssignedCoroutine(JJPJHIHBOIB));
		}
	}

	public static int GetBedAssignedByActorNumber(int MPMECNEJOMB)
	{
		if (instance.BKBOPOAOBIP.ContainsKey(MPMECNEJOMB))
		{
			return instance.BKBOPOAOBIP[MPMECNEJOMB];
		}
		if (Application.isEditor && MPMECNEJOMB != 0)
		{
			Debug.LogWarning((object)$"No bed assigned to actor number: {MPMECNEJOMB}");
		}
		return 0;
	}

	public void ResetSingleton()
	{
		NCKNLKGKLNI();
	}

	public static void EGBADHEGJKA(int JJPJHIHBOIB, int GJDMLMEMKMD, bool HLHAICFGNGP = true)
	{
		Debug.Log((object)("Items/item_name_1042" + JJPJHIHBOIB + "Items/item_name_623" + GJDMLMEMKMD));
		if (instance.BKBOPOAOBIP.ContainsKey(JJPJHIHBOIB))
		{
			instance.BKBOPOAOBIP[JJPJHIHBOIB] = GJDMLMEMKMD;
		}
		else
		{
			instance.BKBOPOAOBIP.Add(JJPJHIHBOIB, GJDMLMEMKMD);
		}
		if (HLHAICFGNGP)
		{
			instance.OnActorBedAssigned();
		}
	}

	public static string GetPlayerPlatformID(int MPMECNEJOMB)
	{
		if (!PlayerExists(MPMECNEJOMB))
		{
			return "";
		}
		return Players[MPMECNEJOMB].platformID.OLAIJIBJAGD;
	}

	public static int ConnectedPlayerCount()
	{
		return Players.Count;
	}

	[Obsolete("Use GetPlayerPlatformID() instead.")]
	public static string GetPlayerSteamID(int MPMECNEJOMB)
	{
		if (!PlayerExists(MPMECNEJOMB))
		{
			return "";
		}
		if (!IsPlayerOnSteam(Players[MPMECNEJOMB].platformID.GMIBKAPNFMG))
		{
			Debug.LogError((object)"Trying to get a player's steam name but they're not playing on a steam platform");
			return "";
		}
		return Players[MPMECNEJOMB].platformID.OLAIJIBJAGD;
	}

	public static string NBKABKMHGNP(int MPMECNEJOMB)
	{
		if (!PIOCEPCFHDK(MPMECNEJOMB))
		{
			return "IntensityControls";
		}
		return Players[MPMECNEJOMB].platformID.CDJFLEPJIBO();
	}

	public static int GetPlayerNumByActorNumber(int MPMECNEJOMB)
	{
		BGAGHKMEKNH = Find(MPMECNEJOMB);
		if (BGAGHKMEKNH != null)
		{
			return BGAGHKMEKNH.playerNum;
		}
		if (Application.isEditor && MPMECNEJOMB != 0)
		{
			Debug.LogError((object)$"Error with actor number {MPMECNEJOMB}");
		}
		return 0;
	}

	[Obsolete("Use SetPlayerPlatformID( instead.")]
	private void PEFKNACJJFO(int MPMECNEJOMB, string JAAOJOAFCED)
	{
		if (PlayerExists(MPMECNEJOMB))
		{
			if (!IsPlayerOnSteam(Players[MPMECNEJOMB].platformID.GMIBKAPNFMG))
			{
				Debug.LogError((object)"Trying to set a player's steam name but they're not playing on a steam platform");
				return;
			}
			PlatformOS dJBHINLJOBO = Players[MPMECNEJOMB].platformID.GMIBKAPNFMG;
			Players[MPMECNEJOMB].platformID = new PlatformID(JAAOJOAFCED, dJBHINLJOBO);
			OnlineManager.NetworkLog($"Player {MPMECNEJOMB} steamID: {JAAOJOAFCED}");
		}
	}

	public static bool PlayerExists(int MPMECNEJOMB)
	{
		if (!Players.ContainsKey(MPMECNEJOMB))
		{
			Debug.LogWarning((object)$"Player with actor number {MPMECNEJOMB} does not exist or has already been removed from the dictionary after disconnecting.");
			return false;
		}
		return true;
	}

	public static int GetBedAssignedByPlayerNum(int JIIGOACEIKL)
	{
		if (OnlineManager.IsOffline())
		{
			return JIIGOACEIKL;
		}
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) != (Object)null)
		{
			return GetBedAssignedByActorNumber(((MonoBehaviourPun)PlayerController.GetPlayer(JIIGOACEIKL).onlinePlayer).photonView.OwnerActorNr);
		}
		if (Application.isEditor)
		{
			Debug.LogWarning((object)$"No bed assigned to player num: {JIIGOACEIKL}");
		}
		return 0;
	}

	public static bool PIOCEPCFHDK(int MPMECNEJOMB)
	{
		if (!Players.ContainsKey(MPMECNEJOMB))
		{
			Debug.LogWarning((object)string.Format("Items/item_description_1102", MPMECNEJOMB));
			return false;
		}
		return false;
	}

	private void KMLGLOINNPG(int MPMECNEJOMB, string CHOGDNALKPA, PlatformOS DJBHINLJOBO)
	{
		if (PlayerExists(MPMECNEJOMB))
		{
			Players[MPMECNEJOMB].platformID = new PlatformID(CHOGDNALKPA, DJBHINLJOBO);
			OnlineManager.NetworkLog($"Player {MPMECNEJOMB} ID: {CHOGDNALKPA}, platform: {DJBHINLJOBO.ToString()}");
		}
	}

	public static bool LOFMEDODOPA(PlatformOS DJBHINLJOBO)
	{
		return Utils.FIGOCKBBIFO(DJBHINLJOBO);
	}

	private void NPPABGPFLCJ(NetworkState IKAGABHNANJ)
	{
		if (IKAGABHNANJ == NetworkState.Offline)
		{
			NCKNLKGKLNI();
		}
	}

	private void BGPGIOMKKAO()
	{
		if (OnlineManager.IsMasterClient())
		{
			AddActorBedAssigned(PhotonNetwork.LocalPlayer.ActorNumber, 1);
		}
	}

	private static void IPHFFGIBHNG(PhotonView KMBDEJMAAAE)
	{
		if (PlayerExists(KMBDEJMAAAE.Controller.ActorNumber))
		{
			Players[KMBDEJMAAAE.Controller.ActorNumber].NFHBFIDCJON(KMBDEJMAAAE);
		}
	}

	private static void NCKNLKGKLNI()
	{
		Players.Clear();
		Players = new Dictionary<int, OnlinePlayerData>();
		MMFHANPALHI = 0;
	}

	public static int GetPlayerNumByName(string IMFLEJALLNJ)
	{
		foreach (KeyValuePair<int, OnlinePlayerData> player in Players)
		{
			if (player.Value.playerName == IMFLEJALLNJ)
			{
				return GetPlayerNumByActorNumber(player.Value.actorNumber);
			}
		}
		if (Application.isEditor)
		{
			Debug.LogError((object)("Error: could not find player with name " + IMFLEJALLNJ + "."));
		}
		return 0;
	}

	public static string OIMEFCJGACI(int MPMECNEJOMB)
	{
		if (!CCJCKFDKICG(MPMECNEJOMB))
		{
			return "MineState";
		}
		return Players[MPMECNEJOMB].playerName;
	}

	private void Start()
	{
		OnlineManager.OnNetworkStateChanged = (Action<NetworkState>)Delegate.Combine(OnlineManager.OnNetworkStateChanged, new Action<NetworkState>(NPPABGPFLCJ));
		OnlinePlayer.OnlinePlayerInitialized = (Action<Player, int>)Delegate.Combine(OnlinePlayer.OnlinePlayerInitialized, new Action<Player, int>(CAAMEEBOAOF));
		OnlinePlayer.OnlinePlayerDestroyed = (Action<Player>)Delegate.Combine(OnlinePlayer.OnlinePlayerDestroyed, new Action<Player>(NCFKAEBLMJN));
		OnlinePlayer.OnlinePlayerNameChanged = (Action<int, string>)Delegate.Combine(OnlinePlayer.OnlinePlayerNameChanged, new Action<int, string>(CFJJGHKGILL));
		OnlinePlayer.OnlinePlayerGenderChanged = (Action<int, Gender>)Delegate.Combine(OnlinePlayer.OnlinePlayerGenderChanged, new Action<int, Gender>(KHIEAJGEIMF));
		OnlinePlayer.OnlinePlayerSpawned = (Action<PhotonView>)Delegate.Combine(OnlinePlayer.OnlinePlayerSpawned, new Action<PhotonView>(BPBIJJBOPHM));
		OnlinePlayer.OnlinePlayerPlatformID = (Action<int, string, PlatformOS>)Delegate.Combine(OnlinePlayer.OnlinePlayerPlatformID, new Action<int, string, PlatformOS>(KMLGLOINNPG));
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
	}

	private static void NCFKAEBLMJN(Player HCPKKOBFHDN)
	{
		if (HCPKKOBFHDN != null && PlayerExists(HCPKKOBFHDN.ActorNumber) && !((Object)(object)OnlineBedroomsManager.instance == (Object)null))
		{
			OnlineBedroomsManager.instance.RemoveFromDictionary(HCPKKOBFHDN.ActorNumber);
			Players.Remove(HCPKKOBFHDN.ActorNumber);
			OnlineManager.NetworkLog($"Player with actor number {HCPKKOBFHDN.ActorNumber} removed from Players dictionary. Entries left: {Players.Count}");
		}
	}

	public static OnlinePlayerData Find(int MPMECNEJOMB)
	{
		if (!PlayerExists(MPMECNEJOMB))
		{
			return null;
		}
		return Players[MPMECNEJOMB];
	}

	public static OnlinePlayerData JIDKIOJAPDD(int MPMECNEJOMB)
	{
		if (!PlayerExists(MPMECNEJOMB))
		{
			return null;
		}
		return Players[MPMECNEJOMB];
	}
}
