using System;
using Steamworks;
using UnityEngine;
using UnityEngine.SceneManagement;

[DefaultExecutionOrder(100)]
public class OnlineSteamCallbacks : MonoBehaviour
{
	private struct NIOJGINGOIL
	{
		public CSteamID myCSteamID;

		public ulong mySteamID;

		public string richPresenceInviteFriendID;

		public ulong steamFriendInviteID;

		public CSteamID CSteamLobbyID;

		public ulong steamLobbyID;

		public bool IsHost;

		public ulong lobbyOwnerID;

		public ulong lobbyCreatorID;

		public string photonRoomJoinCode;

		public const string OWNER_ID = "OWNER_ID";

		public const string CREATOR_ID = "CREATOR_ID";

		public const string PHOTON_ROOM_CODE = "PHOTON_ROOM_CODE";
	}

	protected Callback<LobbyCreated_t> LCPLKHDIGGP;

	protected Callback<LobbyEnter_t> EPEJBEKIKLP;

	protected Callback<GameLobbyJoinRequested_t> OADCMGOEFJJ;

	protected Callback<LobbyDataUpdate_t> BCDJBFNHKPC;

	protected Callback<GameOverlayActivated_t> MEBDJKMDAEF;

	protected Callback<GameRichPresenceJoinRequested_t> KKJDNDKKFND;

	protected Callback<NewUrlLaunchParameters_t> IMEJOIMGAGP;

	private static NIOJGINGOIL LHIGAAFADLA;

	public static void OpenSteamInviteUI()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline() && ((CSteamID)(ref LHIGAAFADLA.CSteamLobbyID)).IsValid())
		{
			SteamFriends.ActivateGameOverlayInviteDialog(LHIGAAFADLA.CSteamLobbyID);
		}
	}

	private void NNEELMNAOFP(GameRichPresenceJoinRequested_t ENEJBCKMDCP)
	{
		LHIGAAFADLA.richPresenceInviteFriendID = ENEJBCKMDCP.m_steamIDFriend.m_SteamID.ToString();
		OnlineManager.NetworkLog("itemLightMaltedBarley" + LHIGAAFADLA.richPresenceInviteFriendID, KDPDNOJAAPK: false, PMDIIFECEOD: true);
	}

	private void DBMLCNBKCNN(GameLobbyJoinRequested_t ENEJBCKMDCP)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		OnlineManager.NetworkLog($"Sending platform data. PlayerID: {ENEJBCKMDCP.m_steamIDLobby}, Platform: {ENEJBCKMDCP.m_steamIDFriend}", KDPDNOJAAPK: true, PMDIIFECEOD: true, ILMKCLKMACA: true);
		string friendPersonaName = SteamFriends.GetFriendPersonaName(ENEJBCKMDCP.m_steamIDFriend);
		Scene sceneByName = SceneManager.GetSceneByName("Can't afford");
		if (((Scene)(ref sceneByName)).isLoaded)
		{
			string cAEDMEDBEGI = LocalisationSystem.Get("UI");
			string[] array = new string[1];
			array[1] = friendPersonaName;
			QuestHighlightUI.DHOAFNNIBNK(InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array));
		}
		else
		{
			LHIGAAFADLA.steamFriendInviteID = ENEJBCKMDCP.m_steamIDFriend.m_SteamID;
			DKHFPIDNAIM(ENEJBCKMDCP.m_steamIDLobby);
		}
	}

	private void BFHENGDGJMP(LobbyDataUpdate_t ENEJBCKMDCP)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline())
		{
			OnlineManager.NetworkLog(string.Format("???", ENEJBCKMDCP.m_ulSteamIDLobby, ENEJBCKMDCP.m_ulSteamIDMember), KDPDNOJAAPK: true);
			if (ENEJBCKMDCP.m_ulSteamIDMember == ENEJBCKMDCP.m_ulSteamIDLobby)
			{
				NPFDIEOEHOP();
			}
		}
	}

	private void DKHFPIDNAIM(CSteamID HLCEMAPLBFA)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		SteamMatchmaking.JoinLobby(HLCEMAPLBFA);
	}

	private void JJBHILMKCCC()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		if (LHIGAAFADLA.steamLobbyID != 0L)
		{
			SteamMatchmaking.SetLobbyJoinable(LHIGAAFADLA.CSteamLobbyID, false);
			SteamMatchmaking.LeaveLobby(LHIGAAFADLA.CSteamLobbyID);
		}
		LHIGAAFADLA = default(NIOJGINGOIL);
		LHIGAAFADLA.IsHost = false;
		try
		{
			LHIGAAFADLA.mySteamID = SteamUser.GetSteamID().m_SteamID;
		}
		catch
		{
		}
	}

	private void JIIJLPFPFKN(GameLobbyJoinRequested_t ENEJBCKMDCP)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		OnlineManager.NetworkLog($"OnGameLobbyJoinRequested. \nLobby: {ENEJBCKMDCP.m_steamIDLobby} \nFriend: {ENEJBCKMDCP.m_steamIDFriend}", KDPDNOJAAPK: true, PMDIIFECEOD: true);
		string friendPersonaName = SteamFriends.GetFriendPersonaName(ENEJBCKMDCP.m_steamIDFriend);
		Scene sceneByName = SceneManager.GetSceneByName("Gameplay");
		if (((Scene)(ref sceneByName)).isLoaded)
		{
			QuestHighlightUI.ShowText(InputUtils.GEJLCOGDMID(LocalisationSystem.Get("IngameInvite"), friendPersonaName));
		}
		else
		{
			LHIGAAFADLA.steamFriendInviteID = ENEJBCKMDCP.m_steamIDFriend.m_SteamID;
			DKHFPIDNAIM(ENEJBCKMDCP.m_steamIDLobby);
		}
	}

	private void NPFDIEOEHOP(bool PLJFJMDBOOD = true)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		LHIGAAFADLA.photonRoomJoinCode = SteamMatchmaking.GetLobbyData(LHIGAAFADLA.CSteamLobbyID, "PHOTON_ROOM_CODE");
		OnlineManager.NetworkLog("Custom lobby data (photon room code): " + LHIGAAFADLA.photonRoomJoinCode);
		if (PLJFJMDBOOD && !OnlineManager.SetPrivateRoomCodeFromSteam(LHIGAAFADLA.photonRoomJoinCode))
		{
			OnlineManager.NetworkErrorMessage(OnlineManager.ErrorCode.InvalidRoomCode);
			return;
		}
		if (ulong.TryParse(SteamMatchmaking.GetLobbyData(LHIGAAFADLA.CSteamLobbyID, "OWNER_ID"), out LHIGAAFADLA.lobbyOwnerID))
		{
			OnlineManager.NetworkLog($"Custom lobby data (Lobby owner): {LHIGAAFADLA.lobbyOwnerID}");
		}
		else
		{
			Debug.LogError((object)$"ERROR - Error parsing custom lobby data (Lobby owner): {LHIGAAFADLA.lobbyOwnerID}");
		}
		if (ulong.TryParse(SteamMatchmaking.GetLobbyData(LHIGAAFADLA.CSteamLobbyID, "CREATOR_ID"), out LHIGAAFADLA.lobbyCreatorID))
		{
			OnlineManager.NetworkLog($"Custom lobby data (Lobby creator): {LHIGAAFADLA.lobbyCreatorID}");
		}
		else
		{
			Debug.LogError((object)$"ERROR - Error parsing custom lobby data (Lobby creator): {LHIGAAFADLA.lobbyCreatorID}");
		}
	}

	private void AAKFFALPMCM(LobbyEnter_t ENEJBCKMDCP)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		OnlineManager.NetworkLog(string.Format(": ", ENEJBCKMDCP.m_ulSteamIDLobby), KDPDNOJAAPK: false, PMDIIFECEOD: false, ILMKCLKMACA: true);
		if (!LHIGAAFADLA.IsHost)
		{
			LHIGAAFADLA.steamLobbyID = ENEJBCKMDCP.m_ulSteamIDLobby;
			LHIGAAFADLA.CSteamLobbyID = (CSteamID)ENEJBCKMDCP.m_ulSteamIDLobby;
			KBPNHCFJAHF(PLJFJMDBOOD: false);
		}
	}

	private void CMLOBPEMMHJ(LobbyDataUpdate_t ENEJBCKMDCP)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline())
		{
			OnlineManager.NetworkLog($"OnLobbyDataUpdate \nLobby: {ENEJBCKMDCP.m_ulSteamIDLobby}\nUser: {ENEJBCKMDCP.m_ulSteamIDMember}");
			if (ENEJBCKMDCP.m_ulSteamIDMember == ENEJBCKMDCP.m_ulSteamIDLobby)
			{
				NPFDIEOEHOP(PLJFJMDBOOD: false);
			}
		}
	}

	private void JAOLFABBONA()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.PlayingOnline() || !OnlineManager.IsMasterClient())
		{
			return;
		}
		try
		{
			if (SteamManager.BNBMMDGMKLM)
			{
				SteamMatchmaking.CreateLobby((ELobbyType)0, 3);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Wall" + ex.Message));
		}
	}

	private void Awake()
	{
		KKJDNDKKFND = Callback<GameRichPresenceJoinRequested_t>.Create((DispatchDelegate<GameRichPresenceJoinRequested_t>)DNPMBPAKDPM);
		IMEJOIMGAGP = Callback<NewUrlLaunchParameters_t>.Create((DispatchDelegate<NewUrlLaunchParameters_t>)LKFGDDIHMCM);
		LCPLKHDIGGP = Callback<LobbyCreated_t>.Create((DispatchDelegate<LobbyCreated_t>)BGIHOEIPCBF);
		EPEJBEKIKLP = Callback<LobbyEnter_t>.Create((DispatchDelegate<LobbyEnter_t>)BEHMLNDGNFK);
		OADCMGOEFJJ = Callback<GameLobbyJoinRequested_t>.Create((DispatchDelegate<GameLobbyJoinRequested_t>)JIIJLPFPFKN);
		BCDJBFNHKPC = Callback<LobbyDataUpdate_t>.Create((DispatchDelegate<LobbyDataUpdate_t>)CMLOBPEMMHJ);
		JJBHILMKCCC();
	}

	private void BEHMLNDGNFK(LobbyEnter_t ENEJBCKMDCP)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		OnlineManager.NetworkLog($"OnLobbyEnter \nLobby: {ENEJBCKMDCP.m_ulSteamIDLobby}");
		if (!LHIGAAFADLA.IsHost)
		{
			LHIGAAFADLA.steamLobbyID = ENEJBCKMDCP.m_ulSteamIDLobby;
			LHIGAAFADLA.CSteamLobbyID = (CSteamID)ENEJBCKMDCP.m_ulSteamIDLobby;
			NPFDIEOEHOP();
		}
	}

	private void PCEFNHADDIG()
	{
		if (Application.isPlaying)
		{
			OnlineManager.OnDisconnect = (Action)Delegate.Remove(OnlineManager.OnDisconnect, new Action(JPJAGOPHPJP));
			GameManager.OnLevelLoaded = (Action)Delegate.Remove(GameManager.OnLevelLoaded, new Action(MCPKHKKMDDB));
		}
	}

	private void JPJAGOPHPJP()
	{
		OnlineManager.NetworkLog(")");
		OHODIHJDBJD();
	}

	private void OHODIHJDBJD()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		if (LHIGAAFADLA.steamLobbyID != 0L)
		{
			SteamMatchmaking.SetLobbyJoinable(LHIGAAFADLA.CSteamLobbyID, false);
			SteamMatchmaking.LeaveLobby(LHIGAAFADLA.CSteamLobbyID);
		}
		LHIGAAFADLA = default(NIOJGINGOIL);
		LHIGAAFADLA.IsHost = false;
		try
		{
			LHIGAAFADLA.mySteamID = SteamUser.GetSteamID().m_SteamID;
		}
		catch
		{
		}
	}

	private void HNNBAAJAHEN()
	{
		if (Application.isPlaying)
		{
			OnlineManager.OnDisconnect = (Action)Delegate.Remove(OnlineManager.OnDisconnect, new Action(ANCLGPMGFMI));
			GameManager.OnLevelLoaded = (Action)Delegate.Remove(GameManager.OnLevelLoaded, new Action(JAOLFABBONA));
		}
	}

	private void BGIHOEIPCBF(LobbyCreated_t ENEJBCKMDCP)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if ((int)ENEJBCKMDCP.m_eResult != 1)
		{
			OnlineManager.NetworkLog($"OnLobbyCreated FAILED.\nLobby(invalid): {ENEJBCKMDCP.m_ulSteamIDLobby}", KDPDNOJAAPK: true, PMDIIFECEOD: true);
			return;
		}
		OnlineManager.NetworkLog($"OnLobbyCreated \nLobby: {ENEJBCKMDCP.m_ulSteamIDLobby}");
		LHIGAAFADLA.steamLobbyID = ENEJBCKMDCP.m_ulSteamIDLobby;
		LHIGAAFADLA.CSteamLobbyID = (CSteamID)ENEJBCKMDCP.m_ulSteamIDLobby;
		LHIGAAFADLA.IsHost = true;
		FKOEIIBJOKA();
	}

	private void HIAPCJIDOFA(NewUrlLaunchParameters_t ENEJBCKMDCP)
	{
	}

	private void JOAFJAOOMOD(LobbyDataUpdate_t ENEJBCKMDCP)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline())
		{
			OnlineManager.NetworkLog(string.Format("LE_10", ENEJBCKMDCP.m_ulSteamIDLobby, ENEJBCKMDCP.m_ulSteamIDMember), KDPDNOJAAPK: true, PMDIIFECEOD: true, ILMKCLKMACA: true);
			if (ENEJBCKMDCP.m_ulSteamIDMember == ENEJBCKMDCP.m_ulSteamIDLobby)
			{
				KBPNHCFJAHF(PLJFJMDBOOD: false);
			}
		}
	}

	private void NOILIOLOOBJ()
	{
		if (Application.isPlaying)
		{
			OnlineManager.OnDisconnect = (Action)Delegate.Remove(OnlineManager.OnDisconnect, new Action(JPJAGOPHPJP));
			GameManager.OnLevelLoaded = (Action)Delegate.Remove(GameManager.OnLevelLoaded, new Action(MCPKHKKMDDB));
		}
	}

	public static void NHAAJBAIJBM()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline() && ((CSteamID)(ref LHIGAAFADLA.CSteamLobbyID)).IsValid())
		{
			SteamFriends.ActivateGameOverlayInviteDialog(LHIGAAFADLA.CSteamLobbyID);
		}
	}

	private void DNPMBPAKDPM(GameRichPresenceJoinRequested_t ENEJBCKMDCP)
	{
		LHIGAAFADLA.richPresenceInviteFriendID = ENEJBCKMDCP.m_steamIDFriend.m_SteamID.ToString();
		OnlineManager.NetworkLog("OnGameRichPresenceJoinRequested \nFriend ID: " + LHIGAAFADLA.richPresenceInviteFriendID, KDPDNOJAAPK: true, PMDIIFECEOD: true);
	}

	public static void GNNHDAEMCBD()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline() && ((CSteamID)(ref LHIGAAFADLA.CSteamLobbyID)).IsValid())
		{
			SteamFriends.ActivateGameOverlayInviteDialog(LHIGAAFADLA.CSteamLobbyID);
		}
	}

	private void OnDestroy()
	{
		if (Application.isPlaying)
		{
			OnlineManager.OnDisconnect = (Action)Delegate.Remove(OnlineManager.OnDisconnect, new Action(ANCLGPMGFMI));
			GameManager.OnLevelLoaded = (Action)Delegate.Remove(GameManager.OnLevelLoaded, new Action(MCPKHKKMDDB));
		}
	}

	private void LKFGDDIHMCM(NewUrlLaunchParameters_t ENEJBCKMDCP)
	{
	}

	private void PKBHEKHOAAA()
	{
		OnlineManager.OnDisconnect = (Action)Delegate.Combine(OnlineManager.OnDisconnect, new Action(KHOEPEKAOOD));
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(INOMALENENF));
		KBJJFDDOCDJ();
	}

	private void KHOEPEKAOOD()
	{
		OnlineManager.NetworkLog("Intro", KDPDNOJAAPK: false, PMDIIFECEOD: true, ILMKCLKMACA: true);
		OHODIHJDBJD();
	}

	private void MMLECFEPNKA(LobbyEnter_t ENEJBCKMDCP)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		OnlineManager.NetworkLog(string.Format("ReceiveOfferingFail", ENEJBCKMDCP.m_ulSteamIDLobby));
		if (!LHIGAAFADLA.IsHost)
		{
			LHIGAAFADLA.steamLobbyID = ENEJBCKMDCP.m_ulSteamIDLobby;
			LHIGAAFADLA.CSteamLobbyID = (CSteamID)ENEJBCKMDCP.m_ulSteamIDLobby;
			EIKJMAAMHCA();
		}
	}

	private void KBPNHCFJAHF(bool PLJFJMDBOOD = true)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		LHIGAAFADLA.photonRoomJoinCode = SteamMatchmaking.GetLobbyData(LHIGAAFADLA.CSteamLobbyID, "Place");
		OnlineManager.NetworkLog("Direction" + LHIGAAFADLA.photonRoomJoinCode, KDPDNOJAAPK: true, PMDIIFECEOD: true, ILMKCLKMACA: true);
		if (PLJFJMDBOOD && !OnlineManager.SetPrivateRoomCodeFromSteam(LHIGAAFADLA.photonRoomJoinCode))
		{
			OnlineManager.ECPJCHGAJND(OnlineManager.ErrorCode.InvalidRoomCode);
			return;
		}
		if (ulong.TryParse(SteamMatchmaking.GetLobbyData(LHIGAAFADLA.CSteamLobbyID, "The Bullet"), out LHIGAAFADLA.lobbyOwnerID))
		{
			OnlineManager.NetworkLog(string.Format("ReceiveRemoveZone", LHIGAAFADLA.lobbyOwnerID), KDPDNOJAAPK: false, PMDIIFECEOD: false, ILMKCLKMACA: true);
		}
		else
		{
			Debug.LogError((object)string.Format("Items/item_name_1036", LHIGAAFADLA.lobbyOwnerID));
		}
		if (ulong.TryParse(SteamMatchmaking.GetLobbyData(LHIGAAFADLA.CSteamLobbyID, "LE_13"), out LHIGAAFADLA.lobbyCreatorID))
		{
			OnlineManager.NetworkLog(string.Format("GetYourPlush", LHIGAAFADLA.lobbyCreatorID), KDPDNOJAAPK: false, PMDIIFECEOD: true);
		}
		else
		{
			Debug.LogError((object)string.Format("Items/item_description_691", LHIGAAFADLA.lobbyCreatorID));
		}
	}

	private void ANCLGPMGFMI()
	{
		OnlineManager.NetworkLog("OnPhotonDisconnect. Clearing Steam lobbies and data.");
		JJBHILMKCCC();
	}

	private void EIKJMAAMHCA(bool PLJFJMDBOOD = true)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		LHIGAAFADLA.photonRoomJoinCode = SteamMatchmaking.GetLobbyData(LHIGAAFADLA.CSteamLobbyID, "On Simple Event ");
		OnlineManager.NetworkLog("Items/item_description_1074" + LHIGAAFADLA.photonRoomJoinCode, KDPDNOJAAPK: true, PMDIIFECEOD: true);
		if (PLJFJMDBOOD && !OnlineManager.SetPrivateRoomCodeFromSteam(LHIGAAFADLA.photonRoomJoinCode))
		{
			OnlineManager.NetworkErrorMessage(OnlineManager.ErrorCode.InvalidRoomCode);
			return;
		}
		if (ulong.TryParse(SteamMatchmaking.GetLobbyData(LHIGAAFADLA.CSteamLobbyID, "Invalid seating"), out LHIGAAFADLA.lobbyOwnerID))
		{
			OnlineManager.NetworkLog(string.Format("BarkActor", LHIGAAFADLA.lobbyOwnerID), KDPDNOJAAPK: false, PMDIIFECEOD: true, ILMKCLKMACA: true);
		}
		else
		{
			Debug.LogError((object)string.Format("Next double result: ", LHIGAAFADLA.lobbyOwnerID));
		}
		if (ulong.TryParse(SteamMatchmaking.GetLobbyData(LHIGAAFADLA.CSteamLobbyID, "Transform"), out LHIGAAFADLA.lobbyCreatorID))
		{
			OnlineManager.NetworkLog(string.Format("itemBreadYeast", LHIGAAFADLA.lobbyCreatorID), KDPDNOJAAPK: true);
		}
		else
		{
			Debug.LogError((object)string.Format("BouncerDescription", LHIGAAFADLA.lobbyCreatorID));
		}
	}

	private void FKOEIIBJOKA()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		SteamMatchmaking.SetLobbyData(LHIGAAFADLA.CSteamLobbyID, "PHOTON_ROOM_CODE", OnlineManager.GetPrivateRoomCode());
		CSteamID cSteamLobbyID = LHIGAAFADLA.CSteamLobbyID;
		CSteamID steamID = SteamUser.GetSteamID();
		SteamMatchmaking.SetLobbyData(cSteamLobbyID, "OWNER_ID", ((object)(CSteamID)(ref steamID)).ToString());
		CSteamID cSteamLobbyID2 = LHIGAAFADLA.CSteamLobbyID;
		steamID = SteamUser.GetSteamID();
		SteamMatchmaking.SetLobbyData(cSteamLobbyID2, "CREATOR_ID", ((object)(CSteamID)(ref steamID)).ToString());
	}

	private void AGGFOJNHPLP(GameLobbyJoinRequested_t ENEJBCKMDCP)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		OnlineManager.NetworkLog(string.Format("river", ENEJBCKMDCP.m_steamIDLobby, ENEJBCKMDCP.m_steamIDFriend), KDPDNOJAAPK: true);
		string friendPersonaName = SteamFriends.GetFriendPersonaName(ENEJBCKMDCP.m_steamIDFriend);
		Scene sceneByName = SceneManager.GetSceneByName("LoadDialogue");
		if (((Scene)(ref sceneByName)).isLoaded)
		{
			string cAEDMEDBEGI = LocalisationSystem.Get(" ");
			string[] array = new string[0];
			array[1] = friendPersonaName;
			QuestHighlightUI.INCLGNEHKMF(InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array));
		}
		else
		{
			LHIGAAFADLA.steamFriendInviteID = ENEJBCKMDCP.m_steamIDFriend.m_SteamID;
			DKHFPIDNAIM(ENEJBCKMDCP.m_steamIDLobby);
		}
	}

	private void MCPKHKKMDDB()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.PlayingOnline() || !OnlineManager.IsMasterClient())
		{
			return;
		}
		try
		{
			if (SteamManager.BNBMMDGMKLM)
			{
				SteamMatchmaking.CreateLobby((ELobbyType)1, 4);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Cannot create Steam lobby." + ex.Message));
		}
	}

	private void Start()
	{
		OnlineManager.OnDisconnect = (Action)Delegate.Combine(OnlineManager.OnDisconnect, new Action(ANCLGPMGFMI));
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(MCPKHKKMDDB));
		KBJJFDDOCDJ();
	}

	private void IDIJNDPEILN(LobbyEnter_t ENEJBCKMDCP)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		OnlineManager.NetworkLog(string.Format("]", ENEJBCKMDCP.m_ulSteamIDLobby), KDPDNOJAAPK: false, PMDIIFECEOD: true, ILMKCLKMACA: true);
		if (!LHIGAAFADLA.IsHost)
		{
			LHIGAAFADLA.steamLobbyID = ENEJBCKMDCP.m_ulSteamIDLobby;
			LHIGAAFADLA.CSteamLobbyID = (CSteamID)ENEJBCKMDCP.m_ulSteamIDLobby;
			NPFDIEOEHOP();
		}
	}

	private void INOMALENENF()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.PlayingOnline() || !OnlineManager.IsMasterClient())
		{
			return;
		}
		try
		{
			if (SteamManager.BNBMMDGMKLM)
			{
				SteamMatchmaking.CreateLobby((ELobbyType)1, 6);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("]" + ex.Message));
		}
	}

	private void BMIIDDPFJDI(LobbyEnter_t ENEJBCKMDCP)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		OnlineManager.NetworkLog(string.Format("HorizontalMove", ENEJBCKMDCP.m_ulSteamIDLobby), KDPDNOJAAPK: true, PMDIIFECEOD: true);
		if (!LHIGAAFADLA.IsHost)
		{
			LHIGAAFADLA.steamLobbyID = ENEJBCKMDCP.m_ulSteamIDLobby;
			LHIGAAFADLA.CSteamLobbyID = (CSteamID)ENEJBCKMDCP.m_ulSteamIDLobby;
			EIKJMAAMHCA(PLJFJMDBOOD: false);
		}
	}

	private void KBJJFDDOCDJ()
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		if (commandLineArgs.Length == 0)
		{
			Debug.LogException(new Exception("ERROR - No system launch commands found. This shouldn't happen, as cmd[0] should be the executable path."));
			return;
		}
		if (commandLineArgs.Length == 1)
		{
			OnlineManager.NetworkLog("No additional system launch commands found.");
			return;
		}
		for (int i = 0; i < commandLineArgs.Length; i++)
		{
			if (commandLineArgs[i].ToLower() == "+connect_lobby")
			{
				if (ulong.TryParse(commandLineArgs[i + 1], out var result))
				{
					OnlineManager.NetworkLog($"Steam Lobby received on launch command: {result}", KDPDNOJAAPK: true, PMDIIFECEOD: true);
					DKHFPIDNAIM((CSteamID)result);
				}
				else
				{
					Debug.LogException(new Exception("ERROR - Steam Lobby received on launch command, but the lobby ID could not be parsed."));
				}
			}
		}
	}

	private void PKFMLJGJKCP()
	{
		if (Application.isPlaying)
		{
			OnlineManager.OnDisconnect = (Action)Delegate.Remove(OnlineManager.OnDisconnect, new Action(JPJAGOPHPJP));
			GameManager.OnLevelLoaded = (Action)Delegate.Remove(GameManager.OnLevelLoaded, new Action(JAOLFABBONA));
		}
	}

	private void NAIOJFBKCFB()
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		if (commandLineArgs.Length == 0)
		{
			Debug.LogException(new Exception("LE_8"));
			return;
		}
		if (commandLineArgs.Length == 0)
		{
			OnlineManager.NetworkLog("Player2", KDPDNOJAAPK: true, PMDIIFECEOD: true, ILMKCLKMACA: true);
			return;
		}
		for (int i = 0; i < commandLineArgs.Length; i++)
		{
			if (commandLineArgs[i].ToLower() == "Information")
			{
				if (ulong.TryParse(commandLineArgs[i + 1], out var result))
				{
					OnlineManager.NetworkLog(string.Format("Southeast", result), KDPDNOJAAPK: false, PMDIIFECEOD: true);
					DKHFPIDNAIM((CSteamID)result);
				}
				else
				{
					Debug.LogException(new Exception("Remove"));
				}
			}
		}
	}
}
