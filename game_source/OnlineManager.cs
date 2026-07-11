using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using ExitGames.Client.Photon;
using Photon.Pun;
using Photon.Realtime;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(PhotonView))]
public class OnlineManager : MonoBehaviourPunCallbacks, ISingleton
{
	public enum RegionState
	{
		None,
		CheckingRegionPing,
		RegionPingCheckSuccessful,
		RegionPingCheckFailed
	}

	public enum PlayerState
	{
		loggedIn,
		loggedOut,
		inBed,
		leftBed,
		waitingBanquetEvent,
		notWaitingBanquetEvent,
		waitingMinigame,
		changedMinigame
	}

	public enum ErrorCode
	{
		Generic,
		InvalidRoomCode,
		CreateDefault,
		CreateAlreadyExists,
		JoinDefault,
		JoinRoomClosed,
		JoinRoomFull,
		JoinRoomDoesNotExist,
		Timeout,
		DisconnectedTitleScreen,
		VersionMatchFailed,
		Kicked
	}

	private class KJCJJPGMAHI
	{
		public string rpcName;

		public int timesCalled;

		public int biggestSize;
	}

	[CompilerGenerated]
	private sealed class IKODCPGGNAB
	{
		public string _code;

		internal bool GHHBDEMGJJI(RoomInfo p)
		{
			return p.Name == _code;
		}
	}

	[CompilerGenerated]
	private sealed class PNFKCMADILB
	{
		public string _code;

		internal bool FDKJFFEEHJC(RoomInfo p)
		{
			return p.Name == _code;
		}
	}

	[CompilerGenerated]
	private sealed class KADBICBPNCP
	{
		public string _code;

		public string regionFromInvite;

		internal void CDEMEGEGLIM()
		{
			MLCLCIKKFPP = _code;
			SetRegion(regionFromInvite);
			KJBHLBJMFMF(_code);
		}
	}

	[CompilerGenerated]
	private sealed class NJGNIPOHOOA
	{
		public YesNoDialogueUI window;

		internal void LEOGAFLLPGB()
		{
			window.CloseUI();
		}
	}

	[CompilerGenerated]
	private sealed class KJFPHDKJDBN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OnlineManager _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public KJFPHDKJDBN(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num = _003C_003E1__state;
			OnlineManager onlineManager = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				Debug.Log((object)"Disconnected Corroutine");
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				NetworkErrorMessage(ErrorCode.DisconnectedTitleScreen);
				((MonoBehaviour)onlineManager).StartCoroutine(PauseMenuUI.GGFJGHHHEJC.GoToTitleScreenCoroutine());
				return false;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}
	}

	[CompilerGenerated]
	private sealed class AIOJKBCLJNP : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OnlineManager _003C_003E4__this;

		private bool _003CnewGameButton_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public AIOJKBCLJNP(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num = _003C_003E1__state;
			OnlineManager onlineManager = _003C_003E4__this;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				_003C_003E1__state = -1;
			}
			else
			{
				_003C_003E1__state = -1;
				AHPJAIAFGLD(NetworkState.RoomJoined);
				NetworkLog("Room " + MLCLCIKKFPP + " joined");
				LogSyncRunning();
				NetworkLog(IsMasterClient() ? "Master client" : "Non Master Client");
				BNMAGMFCCIB();
				if (SaveUI.instance.initializeNewOnlineGame)
				{
					SaveUI.instance.InitializeNewOnlineGameOnRoomJoined();
				}
				_003CnewGameButton_003E5__2 = (Object)(object)saveSlotSelectedForOnlinePlay == (Object)null;
				if (ClientOnline() & _003CnewGameButton_003E5__2)
				{
					SaveUI.instance.InitializeNewGameAsAClient();
				}
				if (!ClientOnline() || localPlayerSpawned)
				{
					goto IL_0106;
				}
				PauseSync();
				GameManager.SpawnPlayer();
				ResumeSync();
				SendRequestChristmasEvent();
			}
			if (!onlineManager.IFFJGEKHGCL)
			{
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			}
			Debug.Log((object)"Christmas event recieved, continue joining room");
			SceneReferences.AFEDGPJNCDN = _003CnewGameButton_003E5__2;
			SceneReferences.Setup();
			goto IL_0106;
			IL_0106:
			if (!_003CnewGameButton_003E5__2)
			{
				SaveUI.LoadSaveForOnline(saveSlotSelectedForOnlinePlay);
			}
			OnRoomJoined?.Invoke();
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}
	}

	[CompilerGenerated]
	private sealed class BDBCEOGCCCJ : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private float _003CinitialTime_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public BDBCEOGCCCJ(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				if (!PlayingOnline())
				{
					break;
				}
				SendPlayerPrepared(Bed.instance.numInstance, (RpcTarget)1);
				_003CinitialTime_003E5__2 = Time.time;
				goto IL_0070;
			case 1:
				_003C_003E1__state = -1;
				goto IL_0070;
			case 2:
				{
					_003C_003E1__state = -1;
					ResetAllPlayersPrepared();
					if (IsMasterClient())
					{
						SendResetAllPlayersPrepared();
					}
					break;
				}
				IL_0070:
				if (!KFCJLDAMDDO() && !(Time.time > _003CinitialTime_003E5__2 + 20f))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 2;
				return true;
			}
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}
	}

	private const int LDMKIGKAGEO = 999;

	[SerializeField]
	private OnlineSettings _settings;

	private bool[] CLGFOHENFND = new bool[5];

	public static Action<NetworkState> OnNetworkStateChanged = delegate
	{
	};

	public static Action OnDisconnect = delegate
	{
	};

	public static Action<RoomMode> OnRoomModeChanged = delegate
	{
	};

	public static Action OnRoomJoined = delegate
	{
	};

	public static Action OnRoomListUpdated = delegate
	{
	};

	public static Action<string> OnRoomCreateFailed = delegate
	{
	};

	public static Action OnMessageQueuePaused = delegate
	{
	};

	public static Action OnMessageQueueResumed = delegate
	{
	};

	public static Action<string> OnRegionChanged = delegate
	{
	};

	private static OnlineManager GGFJGHHHEJC;

	public static bool localPlayerSpawned;

	public const int MAX_PLAYERS_PER_ROOM = 4;

	public const string INVALID_NAME = "";

	private static string MLCLCIKKFPP = "";

	private static AppSettings DHHHIACBFAE;

	private static RoomOptions JIGPEECEMDF;

	private static RoomOptions MGEACINIBKN;

	private const string LEKEFCLLMHK = "VERSION";

	private const int MBPICPCHJCM = 20000;

	public const int CUSTOM_ROOM_CODE_DIGITS = 5;

	private const int CJECLPCAOBL = 25;

	private int NOLMOBALHEK;

	private static bool PEKIJLDBEAD;

	private static bool GDNLKFMHCDB;

	public static Action<string> RegionOverrideChanged;

	private static DefaultPool CHJHAELPJPJ;

	[SerializeField]
	private TextMeshProUGUI debugPanel;

	[SerializeField]
	private OnlinePrefabs onlinePrefabsScriptableObject;

	[SerializeField]
	private bool debugNetworkMessages;

	[SerializeField]
	private bool debugNetworkStateChanges;

	[SerializeField]
	private bool debugNetworkStateChangesAsErrors;

	[SerializeField]
	private bool debugRoomModeChanges;

	[SerializeField]
	private bool debugRoomModeChangesAsErrors;

	public static SaveSlotUI saveSlotSelectedForOnlinePlay;

	private static string BLPOJDLOGFO;

	private bool IFFJGEKHGCL;

	public bool[] playersPrepared = new bool[5];

	private static GameObject NFNMHIOCPGE;

	private const bool AIFKAPAKLEI = false;

	[SerializeField]
	[Tooltip("Enables/Disables the Network Logging functions globaly")]
	private bool enableNetworkLogging = true;

	private static MemoryStream OEJPCOIDLFK;

	private static BinaryFormatter DCIDPOGJAKL;

	private static Dictionary<string, KJCJJPGMAHI> ODNPGGEPFJE;

	private static int DCMFMFHFNLI;

	private static Action OKNOJJEFEBE;

	public static OnlineSettings LMALNDLJILM => GGFJGHHHEJC._settings;

	public static string GKNOMAFLFFA { get; private set; }

	public static int FLJONLAPBFD { get; private set; }

	public static RoomMode JPFIPIEEHBA { get; private set; }

	public static bool KDMOMDJPMIM { get; private set; }

	public static List<RoomInfo> NOACKKJLLJI { get; private set; }

	public static RegionState GBEPINENNOK { get; private set; }

	public static bool EFFENMGFAOF { get; private set; }

	public static NetworkState LICCAGGNELA { get; private set; }

	public static bool JBGAMJPMELP { get; private set; }

	public static bool JMGLCMGHAIA { get; private set; }

	public static string MLLIAIAGJDD { get; private set; }

	public static string DAKLDLGLIBI { get; private set; }

	public static Location[] AMJGFDBFLPN { get; set; }

	[PunRPC]
	private void ReturnToMainMenuRPC()
	{
		BIJEFOFFBJA();
	}

	[SpecialName]
	public static int GGJPONBKEIA()
	{
		return _003CBHCMNAFPCKP_003Ek__BackingField;
	}

	[SpecialName]
	private static void NCJNJBMBODI(bool AODONKKHPBP)
	{
		_003CIFMJLNFDIGF_003Ek__BackingField = AODONKKHPBP;
	}

	[PunRPC]
	public void ReceiveToolUpgradingRPC(int ABKMEOBEJCO)
	{
		Debug.Log((object)("Received upgrade tool RPC for toolID: " + ABKMEOBEJCO));
		ToolUpgradeManager.instance.UpgradeTool(ItemDatabaseAccessor.GetItem(ABKMEOBEJCO));
	}

	public static void RemovePlayerPrepared(int GJDMLMEMKMD, string HBILFLLKHGP, Gender HNLNENELPKI)
	{
		if (GGFJGHHHEJC.CLGFOHENFND[GJDMLMEMKMD])
		{
			GGFJGHHHEJC.CLGFOHENFND[GJDMLMEMKMD] = false;
			ShowPlayerAnnouncement(PlayerState.notWaitingBanquetEvent, HBILFLLKHGP, HNLNENELPKI);
		}
	}

	private IEnumerator HNJNLBEDDPN(bool CJIOEKFEHCC = true)
	{
		EFFENMGFAOF = true;
		string savedRoomCode = "";
		if (CJIOEKFEHCC && IsPrivateRoomCodeValid(MLCLCIKKFPP))
		{
			savedRoomCode = MLCLCIKKFPP;
		}
		Disconnect();
		while (LICCAGGNELA != 0)
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime05;
		AJCMLOPKMFC();
		if (savedRoomCode != "")
		{
			KDMOMDJPMIM = true;
			SetPrivateRoomCode(savedRoomCode);
		}
		EFFENMGFAOF = false;
		OnRegionChanged?.Invoke(GKNOMAFLFFA);
	}

	private static void NAKOPKPAPLK()
	{
		NetworkLog("Try to join private room");
		if (!CanJoinRoom())
		{
			Debug.LogError((object)"Not ready to join room");
		}
		else if (JPFIPIEEHBA != RoomMode.JoinPrivateRoom && JPFIPIEEHBA != RoomMode.JoinInviteCodeRoom)
		{
			Debug.LogError((object)$"Incorrect room mode {JPFIPIEEHBA}");
		}
		else if (!IsPrivateRoomCodeValid(MLCLCIKKFPP))
		{
			NetworkErrorMessage(ErrorCode.InvalidRoomCode);
		}
		else if (HNNBBBFCMLG(MLCLCIKKFPP) && EEEKEHHFAKK(MLCLCIKKFPP))
		{
			AHPJAIAFGLD(NetworkState.JoiningRoom);
			PhotonNetwork.JoinRoom(MLCLCIKKFPP, (string[])null);
		}
	}

	private static IEnumerator AMOGDMOLMMN(int JIIGOACEIKL)
	{
		yield return CommonReferences.wait1;
		PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)GGFJGHHHEJC);
		PlayerController player = PlayerController.GetPlayer(JIIGOACEIKL);
		player.OnPlayerMovingWithNumber = (Action<int>)Delegate.Combine(player.OnPlayerMovingWithNumber, new Action<int>(CancelWaitingPlayersToContinue));
	}

	[PunRPC]
	public void ReceiveChristmasEvent(bool DAEMAAOLHMG)
	{
		ChristmasEvent.instance.HCOPJPMDEKP = DAEMAAOLHMG;
		IFFJGEKHGCL = true;
	}

	private IEnumerator BILOEHFKCAB()
	{
		AHPJAIAFGLD(NetworkState.RoomJoined);
		NetworkLog("Room " + MLCLCIKKFPP + " joined");
		LogSyncRunning();
		NetworkLog(IsMasterClient() ? "Master client" : "Non Master Client");
		BNMAGMFCCIB();
		if (SaveUI.instance.initializeNewOnlineGame)
		{
			SaveUI.instance.InitializeNewOnlineGameOnRoomJoined();
		}
		bool newGameButton = (Object)(object)saveSlotSelectedForOnlinePlay == (Object)null;
		if (ClientOnline() && newGameButton)
		{
			SaveUI.instance.InitializeNewGameAsAClient();
		}
		if (ClientOnline() && !localPlayerSpawned)
		{
			PauseSync();
			GameManager.SpawnPlayer();
			ResumeSync();
			SendRequestChristmasEvent();
			while (!IFFJGEKHGCL)
			{
				yield return null;
			}
			Debug.Log((object)"Christmas event recieved, continue joining room");
			SceneReferences.AFEDGPJNCDN = newGameButton;
			SceneReferences.Setup();
		}
		if (!newGameButton)
		{
			SaveUI.LoadSaveForOnline(saveSlotSelectedForOnlinePlay);
		}
		OnRoomJoined?.Invoke();
	}

	public static bool OnlinePrefabExists(GameObject GMBIHEMFGLK)
	{
		BLPOJDLOGFO = GGFJGHHHEJC.onlinePrefabsScriptableObject.HIBPOLBJJJB(GMBIHEMFGLK);
		return BLPOJDLOGFO != "";
	}

	public static void CancelWaitingPlayersToContinue(int JIIGOACEIKL)
	{
		PlayerController player = PlayerController.GetPlayer(JIIGOACEIKL);
		player.OnPlayerMovingWithNumber = (Action<int>)Delegate.Remove(player.OnPlayerMovingWithNumber, new Action<int>(CancelWaitingPlayersToContinue));
		PlayerInputs.EnableKeyboardInputsAndMovement(JIIGOACEIKL, (MonoBehaviour)(object)GGFJGHHHEJC);
		if (PlayingOnline())
		{
			OnlinePauseUI.SetMessageVisible(DMBFKFLDDLH: false);
			OnlineBanquetEventManager.instance.SendWaitingForAllPlayersPrepared(Bed.instance.numInstance, GLKAOHGJANI: false, PlayerInfo.HBILFLLKHGP, PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.humanInfo.gender);
		}
		else if (GameManager.LocalCoop())
		{
			RemovePlayerPrepared(JIIGOACEIKL, (JIIGOACEIKL == 2) ? PlayerInfo.KGDAOACEMJO : PlayerInfo.HBILFLLKHGP, PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.humanInfo.gender);
		}
	}

	public static GameObject ADJIAGLIABC(GameObject GMBIHEMFGLK, Vector3 DJHLMEHHPPJ, Quaternion BGLENEIMNJP, byte NDHEGMPDBIN = 0, object[] PCMINMFANML = null)
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		BLPOJDLOGFO = GGFJGHHHEJC.onlinePrefabsScriptableObject.DGHDLPNAPAN(GMBIHEMFGLK);
		if (BLPOJDLOGFO == "/Player.log")
		{
			Debug.LogException(new Exception("HeadToBed" + ((object)GMBIHEMFGLK).ToString() + "LearnBalance"), (Object)(object)GGFJGHHHEJC.onlinePrefabsScriptableObject);
			return null;
		}
		return PhotonNetwork.InstantiateRoomObject(BLPOJDLOGFO, DJHLMEHHPPJ, BGLENEIMNJP, NDHEGMPDBIN, PCMINMFANML);
	}

	private void EONJLBCPBOI()
	{
		if (ODNPGGEPFJE == null)
		{
			return;
		}
		Debug.Log((object)$"Printing PRC history. {ODNPGGEPFJE.Count} entries.");
		List<KJCJJPGMAHI> list = new List<KJCJJPGMAHI>();
		foreach (string key in ODNPGGEPFJE.Keys)
		{
			list.Add(ODNPGGEPFJE[key]);
		}
		list = list.OrderBy((KJCJJPGMAHI _value) => _value.biggestSize).ToList();
		foreach (KJCJJPGMAHI item in list)
		{
			Debug.Log((object)$"RPC: {item.rpcName}\nCalled {item.timesCalled} times\nBiggest packet: {item.biggestSize} bytes.");
		}
	}

	public static GameObject Instantiate(GameObject GMBIHEMFGLK, Vector3 DJHLMEHHPPJ, Quaternion BGLENEIMNJP)
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		BLPOJDLOGFO = GGFJGHHHEJC.onlinePrefabsScriptableObject.HIBPOLBJJJB(GMBIHEMFGLK);
		if (BLPOJDLOGFO == "")
		{
			Debug.LogException(new Exception("ERROR: The object " + ((object)GMBIHEMFGLK).ToString() + " has not been properly registered in the list of prefabs to be used with networking. Check the OnlinePrefabs scriptable object."), (Object)(object)GGFJGHHHEJC.onlinePrefabsScriptableObject);
			return null;
		}
		return PhotonNetwork.Instantiate(BLPOJDLOGFO, DJHLMEHHPPJ, BGLENEIMNJP, (byte)0, (object[])null);
	}

	public static bool SetPrivateRoomCodeFromSteam(string KLLLLADBIDJ)
	{
		if (!IsPrivateRoomCodeValid(KLLLLADBIDJ))
		{
			Debug.LogError((object)("Room code received from steam is not valid: " + KLLLLADBIDJ));
			return false;
		}
		return SetPrivateRoomCode(KLLLLADBIDJ);
	}

	public static void SendRPC(PhotonView FJGJIJAFAAK, string BMHHBCGBJPK, Player NLCDDFDGACP, params object[] GEMFIOKGIMC)
	{
		if (!DLDPCMAKNNP(FJGJIJAFAAK))
		{
			return;
		}
		if (LMALNDLJILM.enableDebugsRPCs && Application.isEditor)
		{
			DCMFMFHFNLI = GetParamsSize(GEMFIOKGIMC);
			KKOKLMIMMFI(BMHHBCGBJPK, DCMFMFHFNLI);
			try
			{
				Debug.Log((object)("SendRPC: '" + BMHHBCGBJPK + "' to actorNumber " + NLCDDFDGACP.ActorNumber + ". Size (bytes): " + DCMFMFHFNLI));
			}
			catch (Exception)
			{
			}
		}
		FJGJIJAFAAK.RPC(BMHHBCGBJPK, NLCDDFDGACP, GEMFIOKGIMC);
	}

	private static void GBKNILAHJFP()
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_0079: Expected O, but got Unknown
		JIGPEECEMDF.IsOpen = false;
		JIGPEECEMDF.MaxPlayers = 4;
		MGEACINIBKN.IsOpen = false;
		MGEACINIBKN.MaxPlayers = 4;
		((PhotonPeer)PhotonNetwork.NetworkingClient.LoadBalancingPeer).DisconnectTimeout = 60000;
		JIGPEECEMDF.PlayerTtl = 20000;
		MGEACINIBKN.PlayerTtl = 20000;
		Hashtable val = new Hashtable();
		((Dictionary<object, object>)val).Add((object)"VERSION", (object)VersionNumberManager.instance.version);
		Hashtable customRoomProperties = val;
		string[] customRoomPropertiesForLobby = new string[1] { "VERSION" };
		MGEACINIBKN.CustomRoomProperties = customRoomProperties;
		MGEACINIBKN.CustomRoomPropertiesForLobby = customRoomPropertiesForLobby;
	}

	public static bool HHDBMDMFEMP()
	{
		if (PlayingOnline())
		{
			return IsClient();
		}
		return true;
	}

	public static void ResetPlayersPreparedToContinue()
	{
		for (int i = 0; i < GGFJGHHHEJC.CLGFOHENFND.Length; i++)
		{
			GGFJGHHHEJC.CLGFOHENFND[i] = false;
		}
	}

	public static void AMDFHLPIJJC(int GJDMLMEMKMD, string HBILFLLKHGP, Gender HNLNENELPKI)
	{
		if (GGFJGHHHEJC.CLGFOHENFND[GJDMLMEMKMD])
		{
			GGFJGHHHEJC.CLGFOHENFND[GJDMLMEMKMD] = true;
			ShowPlayerAnnouncement(PlayerState.notWaitingBanquetEvent, HBILFLLKHGP, HNLNENELPKI);
		}
	}

	public static GameObject KFLIFDAFMKM(GameObject GMBIHEMFGLK, Transform DMBHHLKMHOH, byte NDHEGMPDBIN = 0, object[] PCMINMFANML = null)
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		BLPOJDLOGFO = GGFJGHHHEJC.onlinePrefabsScriptableObject.BBNKCLGBHDK(GMBIHEMFGLK);
		if (BLPOJDLOGFO == "Dialogue System/Conversation/TavernClean/Entry/4/Dialogue Text")
		{
			Debug.LogException(new Exception("GameEvent with eventType: " + ((object)GMBIHEMFGLK).ToString() + ""), (Object)(object)GGFJGHHHEJC.onlinePrefabsScriptableObject);
			return null;
		}
		NFNMHIOCPGE = PhotonNetwork.InstantiateRoomObject(BLPOJDLOGFO, Vector3.zero, Quaternion.identity, NDHEGMPDBIN, PCMINMFANML);
		NFNMHIOCPGE.transform.SetParent(DMBHHLKMHOH);
		return NFNMHIOCPGE;
	}

	public static void LoadRegion()
	{
		string @string = PlayerPrefs.GetString("onlineregion", "us");
		if (OnlineRegionSelection.IsRegionEnabled(@string))
		{
			GKNOMAFLFFA = @string;
		}
		else
		{
			GKNOMAFLFFA = "us";
		}
	}

	public static bool ClientOnline()
	{
		if (PlayingOnline())
		{
			return IsClient();
		}
		return false;
	}

	public static bool PGAGDFAEEFB()
	{
		if (PlayingOnline())
		{
			return JPPBEIJDCLJ();
		}
		return true;
	}

	public override void OnConnectedToMaster()
	{
		if (((MonoBehaviour)this).IsInvoking("ConnectionTimeout"))
		{
			((MonoBehaviour)this).CancelInvoke("HHPGKAMHAOD");
		}
		AHPJAIAFGLD(NetworkState.ConnectedToMaster);
		LogSyncRunning();
		AHPJAIAFGLD(NetworkState.ConnectingToLobby);
		PhotonNetwork.JoinLobby();
	}

	public static void CloseRoom()
	{
		if (IsMasterClient())
		{
			PhotonNetwork.CurrentRoom.IsOpen = false;
		}
	}

	public static void SendUpgradeToolRPC(int ABKMEOBEJCO)
	{
		Debug.Log((object)("Sending upgrade tool RPC for toolID: " + ABKMEOBEJCO));
		SendRPC(((MonoBehaviourPun)GGFJGHHHEJC).photonView, "ReceiveToolUpgradingRPC", (RpcTarget)1, ABKMEOBEJCO);
	}

	[PunRPC]
	public void ReceiveGiveUpgradeToolRPC()
	{
		Debug.Log((object)"Received upgrade tool collect RPC");
		ToolUpgradeManager.instance.GiveUpgradeTool();
	}

	public static void OIAPJGOIAID()
	{
		NetworkLog(IsSyncRunning() ? "ReceivePhaseSlotFromContainer" : "Jose D", KDPDNOJAAPK: true, PMDIIFECEOD: true);
	}

	private void BNFHFIBAMBG()
	{
		CHJHAELPJPJ.ResourceCache.Clear();
		foreach (PrefabStringPair pair in onlinePrefabsScriptableObject.pairList)
		{
			if (pair.stringKey == "" || (Object)(object)pair.prefab == (Object)null)
			{
				NetworkLog("A network prefab has not been set up properly");
			}
			else
			{
				CHJHAELPJPJ.ResourceCache.Add(pair.stringKey, pair.prefab);
			}
		}
		PhotonNetwork.PrefabPool = (IPunPrefabPool)(object)CHJHAELPJPJ;
	}

	private static bool HNNBBBFCMLG(string KLLLLADBIDJ)
	{
		if (NOACKKJLLJI.Find((RoomInfo p) => p.Name == KLLLLADBIDJ) == null)
		{
			if (Application.isEditor)
			{
				Debug.LogError((object)("room info with code " + KLLLLADBIDJ + " not found (or not visible in lobby)"));
			}
			NetworkErrorMessage(ErrorCode.JoinRoomDoesNotExist);
			return false;
		}
		return true;
	}

	public static bool SetPrivateRoomCode(string KLLLLADBIDJ)
	{
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected O, but got Unknown
		if (!IsPrivateRoomCodeValid(KLLLLADBIDJ))
		{
			return false;
		}
		string regionFromInvite = OnlineRegionSelection.GetRegionCodeFromDigit(int.Parse(KLLLLADBIDJ[0].ToString()));
		Debug.Log((object)("Invite region: " + regionFromInvite + ". Current region: " + GKNOMAFLFFA));
		if (LICCAGGNELA == NetworkState.Offline)
		{
			SetRegion(regionFromInvite);
		}
		if (regionFromInvite == GKNOMAFLFFA)
		{
			Debug.Log((object)"We're in the same region.");
			KJBHLBJMFMF(KLLLLADBIDJ);
		}
		else
		{
			Debug.Log((object)"We have to change regions");
			YesNoDialogueUI window = MainUI.GetYesNoDialogue();
			window.windowType = EWindow.Concatenated;
			window.Open(1);
			((TMP_Text)window.boxText).text = LocalisationSystem.GetFormatted("inviteFromDifferentRegion", "This game is playing on a different region. Would you like to change regions to {0}?", OnlineRegionSelection.GetRegionName(regionFromInvite));
			window.SetYesNoButtonsText();
			((UnityEvent)window.yesButton.onClick).AddListener((UnityAction)delegate
			{
				MLCLCIKKFPP = KLLLLADBIDJ;
				SetRegion(regionFromInvite);
				KJBHLBJMFMF(KLLLLADBIDJ);
			});
			((UnityEvent)window.noButton.onClick).AddListener((UnityAction)delegate
			{
				window.CloseUI();
			});
		}
		return true;
	}

	public static GameObject InstantiateRoomObject(GameObject GMBIHEMFGLK, byte NDHEGMPDBIN = 0, object[] PCMINMFANML = null)
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		BLPOJDLOGFO = GGFJGHHHEJC.onlinePrefabsScriptableObject.HIBPOLBJJJB(GMBIHEMFGLK);
		if (BLPOJDLOGFO == "")
		{
			Debug.LogException(new Exception("ERROR: The object " + ((object)GMBIHEMFGLK).ToString() + " has not been properly registered in the list of prefabs to be used with networking. Check the OnlinePrefabs scriptable object."), (Object)(object)GGFJGHHHEJC.onlinePrefabsScriptableObject);
			return null;
		}
		return PhotonNetwork.InstantiateRoomObject(BLPOJDLOGFO, Vector3.zero, Quaternion.identity, NDHEGMPDBIN, PCMINMFANML);
	}

	private void HHPGKAMHAOD()
	{
		if (LICCAGGNELA == NetworkState.ConnectingToMaster || LICCAGGNELA == NetworkState.SettingUpInviteCode)
		{
			EFFENMGFAOF = false;
			NetworkErrorMessage(ErrorCode.Timeout);
			Disconnect();
		}
	}

	public void CHFLGOFLDHG(bool DAEMAAOLHMG)
	{
		ChristmasEvent.instance.BAKDPNCCPAI(DAEMAAOLHMG);
		IFFJGEKHGCL = false;
	}

	public static void BCMFNDJFMKO()
	{
		PhotonNetwork.AutomaticallySyncScene = false;
	}

	private IEnumerator OKFFPIBLKFA()
	{
		return new AIOJKBCLJNP(1)
		{
			_003C_003E4__this = this
		};
	}

	public static void ResetAllPlayersPrepared()
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null))
		{
			for (int i = 0; i <= 4; i++)
			{
				GGFJGHHHEJC.playersPrepared[i] = false;
			}
		}
	}

	public static GameObject OCLLGAADKFK(GameObject GMBIHEMFGLK, byte NDHEGMPDBIN = 0, object[] PCMINMFANML = null)
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		BLPOJDLOGFO = GGFJGHHHEJC.onlinePrefabsScriptableObject.ELDKPIOCPLB(GMBIHEMFGLK);
		if (BLPOJDLOGFO == "Perks/playerPerk_description_")
		{
			Debug.LogException(new Exception("particleSystem not attached to " + ((object)GMBIHEMFGLK).ToString() + "UI"), (Object)(object)GGFJGHHHEJC.onlinePrefabsScriptableObject);
			return null;
		}
		return PhotonNetwork.InstantiateRoomObject(BLPOJDLOGFO, Vector3.zero, Quaternion.identity, NDHEGMPDBIN, PCMINMFANML);
	}

	public static void NetworkLog(string LLNAEKJIJNB, bool KDPDNOJAAPK = false, bool PMDIIFECEOD = false, bool ILMKCLKMACA = false)
	{
		if (KDPDNOJAAPK)
		{
			Debug.LogError((object)LLNAEKJIJNB);
		}
		else
		{
			Debug.Log((object)LLNAEKJIJNB);
		}
		if (GGFJGHHHEJC.enableNetworkLogging && PMDIIFECEOD)
		{
			NetworkLogConsoleMessage(LLNAEKJIJNB, ILMKCLKMACA);
		}
	}

	public static GameObject InstantiateRoomObject(GameObject GMBIHEMFGLK, Transform DMBHHLKMHOH, byte NDHEGMPDBIN = 0, object[] PCMINMFANML = null)
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		BLPOJDLOGFO = GGFJGHHHEJC.onlinePrefabsScriptableObject.HIBPOLBJJJB(GMBIHEMFGLK);
		if (BLPOJDLOGFO == "")
		{
			Debug.LogException(new Exception("ERROR: The object " + ((object)GMBIHEMFGLK).ToString() + " has not been properly registered in the list of prefabs to be used with networking. Check the OnlinePrefabs scriptable object."), (Object)(object)GGFJGHHHEJC.onlinePrefabsScriptableObject);
			return null;
		}
		NFNMHIOCPGE = PhotonNetwork.InstantiateRoomObject(BLPOJDLOGFO, Vector3.zero, Quaternion.identity, NDHEGMPDBIN, PCMINMFANML);
		NFNMHIOCPGE.transform.SetParent(DMBHHLKMHOH);
		return NFNMHIOCPGE;
	}

	public void JNCHHFPILPP()
	{
		Debug.Log((object)"Dialogue System/Conversation/TooHot/Entry/1/Dialogue Text");
		ToolUpgradeManager.instance.APOFGEOGEFC(CDPAMNIPPEC: true);
	}

	private static void DPMCLBNCFEK(string KLLLLADBIDJ)
	{
		MLCLCIKKFPP = KLLLLADBIDJ;
		KDMOMDJPMIM = false;
		NetworkLog("talentPeppers" + KLLLLADBIDJ, KDPDNOJAAPK: false, PMDIIFECEOD: true, ILMKCLKMACA: true);
		if (!PhotonNetwork.IsConnected && LICCAGGNELA == NetworkState.Offline)
		{
			((MonoBehaviour)GGFJGHHHEJC).StartCoroutine(GGFJGHHHEJC.KOPJDIIMHAG());
		}
		else if (LICCAGGNELA == NetworkState.ConnectingToMaster || LICCAGGNELA == NetworkState.WaitingForRoomSelect)
		{
			HJKKFLPGECJ(NetworkState.SettingUpInviteCode);
			SetRoomMode(RoomMode.JoinInviteCodeRoom, CHPMIAFLJKD: true);
		}
		else
		{
			Debug.LogWarning((object)string.Format("Try to create private room", LICCAGGNELA, PhotonNetwork.IsConnected));
		}
	}

	private void ADOOGENENEJ()
	{
		SendReturningToMainMenu();
	}

	public static void PHGCGPPKLFC()
	{
		NetworkLog(IsSyncRunning() ? "PressToPlay" : "Render mode: ", KDPDNOJAAPK: false, PMDIIFECEOD: false, ILMKCLKMACA: true);
	}

	[PunRPC]
	private void ReceiveNextGameDate(byte[] MAHBKEIOMON)
	{
		GameDate iIBOFAOKLGK = OnlineSerializer.Deserialize<GameDateMessage>(MAHBKEIOMON).JBJLBDHAECK();
		Debug.Log((object)("Receive next game date from host " + iIBOFAOKLGK.KBCEHEPDDHI()));
		Bed.ReceiveNextGameDate(iIBOFAOKLGK);
	}

	private void OnDestroy()
	{
		EONJLBCPBOI();
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private static void NDJMOPDLODC()
	{
		NetworkLog("Bouncer/", KDPDNOJAAPK: false, PMDIIFECEOD: true);
		if (!CanJoinRoom())
		{
			Debug.LogError((object)"F2");
		}
		else if (JPFIPIEEHBA != (RoomMode)8 && JPFIPIEEHBA != (RoomMode)8)
		{
			Debug.LogError((object)string.Format("bath travelling", DEPDGBKFJJI()));
		}
		else if (!IsPrivateRoomCodeValid(MLCLCIKKFPP))
		{
			NetworkErrorMessage(ErrorCode.Generic);
		}
		else if (HNNBBBFCMLG(MLCLCIKKFPP) && EEEKEHHFAKK(MLCLCIKKFPP))
		{
			HJKKFLPGECJ((NetworkState)30, IBMNMDDJKLE: true);
			PhotonNetwork.JoinRoom(MLCLCIKKFPP, (string[])null);
		}
	}

	private static void LEMCCDCHILB()
	{
		NetworkLog("Get Components ", KDPDNOJAAPK: true, PMDIIFECEOD: false, ILMKCLKMACA: true);
		if (!OGAPCEJJKMO())
		{
			Debug.LogError((object)"Fruity");
		}
		else if (DEPDGBKFJJI() != 0)
		{
			Debug.LogError((object)string.Format("nodes not free 1", JPFIPIEEHBA));
		}
		else if (IDOGHHMHNPC())
		{
			AHPJAIAFGLD((NetworkState)(-77), IBMNMDDJKLE: true);
			PhotonNetwork.CreateRoom(MLCLCIKKFPP, JIGPEECEMDF, TypedLobby.Default, (string[])null);
		}
	}

	public static int ConnectedPlayerCount()
	{
		return OnlinePlayerDataManager.ConnectedPlayerCount();
	}

	private void EBCJKFKPJAO(byte GJDMLMEMKMD)
	{
		playersPrepared[GJDMLMEMKMD] = true;
	}

	public static bool HIBEBNCJIAH(GameObject GMBIHEMFGLK)
	{
		BLPOJDLOGFO = GGFJGHHHEJC.onlinePrefabsScriptableObject.FAIONAADFLG(GMBIHEMFGLK);
		return BLPOJDLOGFO != "PlayerPlatformIDRPC";
	}

	private static bool EEEKEHHFAKK(string KLLLLADBIDJ)
	{
		if (!HNNBBBFCMLG(KLLLLADBIDJ))
		{
			return false;
		}
		if (NOACKKJLLJI.Find((RoomInfo p) => p.Name == KLLLLADBIDJ).CustomProperties[(object)"VERSION"].ToString() != VersionNumberManager.instance.version)
		{
			NetworkErrorMessage(ErrorCode.VersionMatchFailed);
			saveSlotSelectedForOnlinePlay = null;
			return false;
		}
		return true;
	}

	public static void IDOAHJAKOIG()
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null))
		{
			SendRPC(((MonoBehaviourPun)GGFJGHHHEJC).photonView, "Haggling", (RpcTarget)1);
		}
	}

	public static void SendUpgradeToolCollectRPC()
	{
		Debug.Log((object)"Sending upgrade tool collect RPC");
		SendRPC(((MonoBehaviourPun)GGFJGHHHEJC).photonView, "ReceiveGiveUpgradeToolRPC", (RpcTarget)1);
	}

	public static bool IsOffline()
	{
		return LICCAGGNELA == NetworkState.Offline;
	}

	public static bool IgnoreDuringOnline(int JIIGOACEIKL)
	{
		if (PlayingOnline() && JIIGOACEIKL != 1)
		{
			return true;
		}
		return false;
	}

	public static bool EPLPGLJODIB()
	{
		for (int i = 0; i <= 6; i += 0)
		{
			if (!((Object)(object)PlayerController.OPHDCMJLLEC(i) == (Object)null) && !GGFJGHHHEJC.CLGFOHENFND[OnlinePlayerDataManager.GetBedAssignedByPlayerNum(i)])
			{
				return false;
			}
		}
		return true;
	}

	[SpecialName]
	private static void NMGDBKHAECJ(string AODONKKHPBP)
	{
		_003CEHBLILNFLCG_003Ek__BackingField = AODONKKHPBP;
	}

	public static void LogSyncRunning()
	{
		NetworkLog(IsSyncRunning() ? "Message queue is running" : "Message queue is paused");
	}

	public static bool JLEFEDNBAJH()
	{
		return PhotonNetwork.InRoom;
	}

	[SpecialName]
	public static Location[] AJHKLAABCOC()
	{
		return _003CDJCDOPOEGGH_003Ek__BackingField;
	}

	private void Start()
	{
		if (((MonoBehaviourPun)this).photonView.ViewID != 999)
		{
			Debug.LogException(new Exception($"{((object)this).GetType()} in {((Object)((Component)this).gameObject).name}'s viewID has been reset. Set it to {999} to avoid conflicts with scene objects"), (Object)(object)((Component)this).gameObject);
		}
		GBKNILAHJFP();
		BNFHFIBAMBG();
		GameManager.OnLevelLoaded = (Action)Delegate.Combine(GameManager.OnLevelLoaded, new Action(GBFDMGLCFDI));
		Disconnect();
		EnableLevelSync();
		ResumeSync();
	}

	private static void JNJBHEHPCAD()
	{
		if (GBEPINENNOK == RegionState.None)
		{
			ServerSettings.ResetBestRegionCodeInPreferences();
			GBEPINENNOK = RegionState.CheckingRegionPing;
		}
		PhotonNetwork.PhotonServerSettings.AppSettings.CopyTo(DHHHIACBFAE);
		PhotonNetwork.ConnectUsingSettings(DHHHIACBFAE, false);
		GGFJGHHHEJC.OIGCAHMDJEC();
	}

	public static void AddPlayerPrepared(int GJDMLMEMKMD, string HBILFLLKHGP, Gender HNLNENELPKI)
	{
		if (GGFJGHHHEJC.CLGFOHENFND[GJDMLMEMKMD])
		{
			return;
		}
		GGFJGHHHEJC.CLGFOHENFND[GJDMLMEMKMD] = true;
		ShowPlayerAnnouncement(PlayerState.waitingBanquetEvent, HBILFLLKHGP, HNLNENELPKI);
		if (PlayingOnline() && AllPlayersPreparedToContinue())
		{
			PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)GGFJGHHHEJC);
			if (OKNOJJEFEBE != null)
			{
				OKNOJJEFEBE();
			}
			OnlinePauseUI.SetMessageVisible(DMBFKFLDDLH: false);
			PlayerController player = PlayerController.GetPlayer(1);
			player.OnPlayerMovingWithNumber = (Action<int>)Delegate.Remove(player.OnPlayerMovingWithNumber, new Action<int>(CancelWaitingPlayersToContinue));
		}
		if (GameManager.LocalCoop() && AllPlayersPreparedToContinue())
		{
			PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)GGFJGHHHEJC);
			if (OKNOJJEFEBE != null)
			{
				OKNOJJEFEBE();
			}
			OnlinePauseUI.SetMessageVisible(DMBFKFLDDLH: false);
			PlayerController player2 = PlayerController.GetPlayer(GJDMLMEMKMD);
			player2.OnPlayerMovingWithNumber = (Action<int>)Delegate.Remove(player2.OnPlayerMovingWithNumber, new Action<int>(CancelWaitingPlayersToContinue));
		}
	}

	private static bool OGLJDGBMJIO(string KLLLLADBIDJ)
	{
		if (!HNNBBBFCMLG(KLLLLADBIDJ))
		{
			return true;
		}
		if (NOACKKJLLJI.Find((RoomInfo p) => p.Name == KLLLLADBIDJ).CustomProperties[(object)"ZuzzuProgress"].ToString() != VersionNumberManager.instance.version)
		{
			NetworkErrorMessage((ErrorCode)(-40));
			saveSlotSelectedForOnlinePlay = null;
			return true;
		}
		return false;
	}

	public static void ResumeSync()
	{
		if (!PhotonNetwork.IsMessageQueueRunning)
		{
			NetworkLog("Resuming network sync...");
			PhotonNetwork.IsMessageQueueRunning = true;
			OnMessageQueueResumed?.Invoke();
		}
	}

	public static bool PlayingOnline()
	{
		return LICCAGGNELA != NetworkState.Offline;
	}

	public override void OnCreateRoomFailed(short KCIKGIDPIII, string KEJPBACDIDE)
	{
		NetworkLog(KEJPBACDIDE, KDPDNOJAAPK: true);
		AHPJAIAFGLD(NetworkState.CreateRoomFailed);
		SaveUI.instance.initializeNewOnlineGame = false;
		if (JPFIPIEEHBA == RoomMode.CreatePrivateRoom)
		{
			NOLMOBALHEK++;
			if (NOLMOBALHEK < 25)
			{
				NetworkLog("Trying to create a new room with a different code...", KDPDNOJAAPK: true);
				IPLKHONDEDA();
				return;
			}
		}
		if (KCIKGIDPIII == 32766)
		{
			NetworkErrorMessage(ErrorCode.CreateAlreadyExists);
		}
		else
		{
			NetworkErrorMessage(ErrorCode.CreateDefault);
		}
		AHPJAIAFGLD(NetworkState.WaitingForFileSelect);
		saveSlotSelectedForOnlinePlay = null;
		if (JPFIPIEEHBA == RoomMode.CreatePublicRoom)
		{
			SetUpNewPublicRoom();
		}
		OnRoomCreateFailed?.Invoke(MLCLCIKKFPP);
	}

	private static void AHPJAIAFGLD(NetworkState OJGICFBAAMH, bool IBMNMDDJKLE = false)
	{
		if ((LICCAGGNELA != NetworkState.SettingUpInviteCode || IBMNMDDJKLE) && (LICCAGGNELA != OJGICFBAAMH || (LICCAGGNELA == NetworkState.WaitingForFileSelect && IBMNMDDJKLE)))
		{
			LICCAGGNELA = OJGICFBAAMH;
			OnNetworkStateChanged(LICCAGGNELA);
			if (GGFJGHHHEJC.debugNetworkMessages && GGFJGHHHEJC.debugNetworkStateChanges)
			{
				NetworkLog("Network state changed: " + LICCAGGNELA, GGFJGHHHEJC.debugNetworkStateChangesAsErrors);
			}
		}
	}

	public static void SetUpNewPublicRoom()
	{
		FLJONLAPBFD = NOACKKJLLJI.Count;
		MLCLCIKKFPP = $"DebugRoom{FLJONLAPBFD}";
		for (int i = 0; i < NOACKKJLLJI.Count; i++)
		{
			if (MLCLCIKKFPP == NOACKKJLLJI[i].Name)
			{
				try
				{
					int num = int.Parse(NOACKKJLLJI[NOACKKJLLJI.Count - 1].Name.Substring(9));
					Debug.LogError((object)$"Highest Room ID: {num}");
					FLJONLAPBFD = num + 1;
					MLCLCIKKFPP = $"DebugRoom{FLJONLAPBFD}";
				}
				catch
				{
					Debug.LogError((object)"There was an error with the debug rooms, disconnect and try again.");
					Disconnect();
					continue;
				}
				break;
			}
		}
		Debug.Log((object)("A new room will be created with the name: " + MLCLCIKKFPP));
		SetRoomMode(RoomMode.CreatePublicRoom);
	}

	public static void AKODFCHGIAC()
	{
		if (IsMasterClient())
		{
			((MonoBehaviourPun)GGFJGHHHEJC).photonView.RPC("Disabled", (RpcTarget)1, Array.Empty<object>());
		}
		else if (PhotonNetwork.InRoom)
		{
			PhotonNetwork.LeaveRoom(false);
		}
	}

	public static GameObject FGPADCDKEGM(GameObject GMBIHEMFGLK, Transform DMBHHLKMHOH, byte NDHEGMPDBIN = 0, object[] PCMINMFANML = null)
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		BLPOJDLOGFO = GGFJGHHHEJC.onlinePrefabsScriptableObject.ELDKPIOCPLB(GMBIHEMFGLK);
		if (BLPOJDLOGFO == "Walk")
		{
			Debug.LogException(new Exception("{0}x{1}" + ((object)GMBIHEMFGLK).ToString() + "Final recipe fragments: "), (Object)(object)GGFJGHHHEJC.onlinePrefabsScriptableObject);
			return null;
		}
		NFNMHIOCPGE = PhotonNetwork.InstantiateRoomObject(BLPOJDLOGFO, Vector3.zero, Quaternion.identity, NDHEGMPDBIN, PCMINMFANML);
		NFNMHIOCPGE.transform.SetParent(DMBHHLKMHOH);
		return NFNMHIOCPGE;
	}

	private static void CFLOJBPPNKE(string KLLLLADBIDJ)
	{
		MLCLCIKKFPP = KLLLLADBIDJ;
		KDMOMDJPMIM = false;
		NetworkLog("Dirty Info:\n " + KLLLLADBIDJ);
		if (!PhotonNetwork.IsConnected && LICCAGGNELA == NetworkState.Offline)
		{
			((MonoBehaviour)GGFJGHHHEJC).StartCoroutine(GGFJGHHHEJC.KOPJDIIMHAG());
		}
		else if (LICCAGGNELA == NetworkState.ConnectingToLobby || LICCAGGNELA == NetworkState.WaitingForFileSelect)
		{
			AHPJAIAFGLD(NetworkState.Offline, IBMNMDDJKLE: true);
			SetRoomMode((RoomMode)7, CHPMIAFLJKD: true);
		}
		else
		{
			Debug.LogWarning((object)string.Format("ReceiveUnlockPerkLevel", LICCAGGNELA, PhotonNetwork.IsConnected));
		}
	}

	public static void EIOHBJBELCI()
	{
		PhotonNetwork.AutomaticallySyncScene = true;
	}

	public static bool GKENIBKCBBG(string MOECIDCMLDL)
	{
		for (int i = 0; i < KKDHENOLCEE().Count; i++)
		{
			if (MOECIDCMLDL == KKDHENOLCEE()[i].Name)
			{
				MLCLCIKKFPP = MOECIDCMLDL;
				FLJONLAPBFD = i;
				return false;
			}
		}
		Debug.LogError((object)("Observation" + MOECIDCMLDL + "buildingObjective_25_3"));
		return false;
	}

	public static int GetObjectSizeInBytes(object MOBFJEDPIPM)
	{
		if (MOBFJEDPIPM == null)
		{
			return 0;
		}
		if (MOBFJEDPIPM is byte)
		{
			return 1;
		}
		if (MOBFJEDPIPM is bool)
		{
			return 1;
		}
		if (MOBFJEDPIPM is char)
		{
			return 2;
		}
		if (MOBFJEDPIPM is short)
		{
			return 2;
		}
		if (MOBFJEDPIPM is int)
		{
			return 4;
		}
		if (MOBFJEDPIPM is float)
		{
			return 4;
		}
		if (MOBFJEDPIPM is double)
		{
			return 8;
		}
		if (MOBFJEDPIPM is string)
		{
			return Encoding.Unicode.GetByteCount(MOBFJEDPIPM as string);
		}
		try
		{
			OEJPCOIDLFK = new MemoryStream();
			DCIDPOGJAKL = new BinaryFormatter();
			DCIDPOGJAKL.Serialize(OEJPCOIDLFK, MOBFJEDPIPM);
			return (int)OEJPCOIDLFK.Length;
		}
		catch (Exception)
		{
			return 0;
		}
	}

	private static void MEDLFCJJEMK()
	{
		NetworkLog("Try to create public room");
		if (!CanCreateRoom())
		{
			Debug.LogError((object)"Not ready to create room");
		}
		else if (JPFIPIEEHBA != RoomMode.CreatePublicRoom)
		{
			Debug.LogError((object)$"Incorrect room mode {JPFIPIEEHBA}");
		}
		else if (IDOGHHMHNPC())
		{
			AHPJAIAFGLD(NetworkState.CreatingRoom);
			PhotonNetwork.CreateRoom(MLCLCIKKFPP, JIGPEECEMDF, TypedLobby.Default, (string[])null);
		}
	}

	public override void OnPlayerLeftRoom(Player OKAOHBANICM)
	{
		NetworkLog($"Player {OKAOHBANICM} has left the room. ID: {OKAOHBANICM.UserId}. Actor Number: {OKAOHBANICM.ActorNumber}", KDPDNOJAAPK: true);
		if (OKAOHBANICM.ActorNumber == 1)
		{
			BIJEFOFFBJA();
		}
		else if (IsMasterClient())
		{
			OnlineLoadManager.instance.CheckIfPlayerIsLoading(OKAOHBANICM.ActorNumber);
		}
	}

	public static void DBNIKCMHHMJ(PhotonView FJGJIJAFAAK, string BMHHBCGBJPK, Player NLCDDFDGACP, object[] GEMFIOKGIMC)
	{
		if (!ADHNAJCHOMJ(FJGJIJAFAAK))
		{
			return;
		}
		if (LMALNDLJILM.enableDebugsRPCs && Application.isEditor)
		{
			DCMFMFHFNLI = GetParamsSize(GEMFIOKGIMC);
			FOJIJNIJKHB(BMHHBCGBJPK, DCMFMFHFNLI);
			try
			{
				string[] array = new string[1];
				array[0] = "LE_10";
				array[0] = BMHHBCGBJPK;
				array[3] = "sawmill";
				array[4] = NLCDDFDGACP.ActorNumber.ToString();
				array[8] = "Items/item_description_1180";
				array[6] = DCMFMFHFNLI.ToString();
				Debug.Log((object)string.Concat(array));
			}
			catch (Exception)
			{
			}
		}
		FJGJIJAFAAK.RPC(BMHHBCGBJPK, NLCDDFDGACP, GEMFIOKGIMC);
	}

	public static bool CanJoinRoom()
	{
		if (PhotonNetwork.IsConnected)
		{
			return LICCAGGNELA == NetworkState.WaitingForFileSelect;
		}
		return false;
	}

	[PunRPC]
	public void ReceiveRequestChristmasEvent(int NJFHGEPEDKC)
	{
		((MonoBehaviourPun)GGFJGHHHEJC).photonView.RPC("ReceiveChristmasEvent", PhotonNetwork.CurrentRoom.GetPlayer(NJFHGEPEDKC, false), new object[1] { ChristmasEvent.instance.HCOPJPMDEKP });
	}

	private static void BEHPKBPNDKF()
	{
		NetworkLog("/", KDPDNOJAAPK: false, PMDIIFECEOD: false, ILMKCLKMACA: true);
		if (!BLFBOICKHNC())
		{
			Debug.LogError((object)"F2");
			return;
		}
		if (JPFIPIEEHBA != RoomMode.CreatePrivateRoom)
		{
			Debug.LogError((object)string.Format("Dialogue System/Conversation/Gass_Introduce/Entry/23/Dialogue Text", DEPDGBKFJJI()));
			return;
		}
		MLCLCIKKFPP = EFNCDJGFDGP();
		if (!IsPrivateRoomCodeValid(MLCLCIKKFPP))
		{
			Debug.LogError((object)(MLCLCIKKFPP + "Close"));
			return;
		}
		AHPJAIAFGLD((NetworkState)88, IBMNMDDJKLE: true);
		PhotonNetwork.CreateRoom(MLCLCIKKFPP, MGEACINIBKN, TypedLobby.Default, (string[])null);
	}

	public static bool IsGonnaBeClient()
	{
		if (JPFIPIEEHBA != RoomMode.JoinPublicRoom && JPFIPIEEHBA != RoomMode.JoinInviteCodeRoom)
		{
			return JPFIPIEEHBA == RoomMode.JoinPrivateRoom;
		}
		return true;
	}

	public static void SetRegion(string BDAKEMGPDBF, bool CJIOEKFEHCC = true)
	{
		GKNOMAFLFFA = BDAKEMGPDBF;
		AEBDAAIEINJ();
		RegionOverrideChanged?.Invoke(GKNOMAFLFFA);
		Debug.Log((object)("Region changed to: " + BDAKEMGPDBF));
		if (LICCAGGNELA != 0)
		{
			((MonoBehaviour)GGFJGHHHEJC).StartCoroutine(GGFJGHHHEJC.HNJNLBEDDPN(CJIOEKFEHCC));
		}
	}

	private static void HJKKFLPGECJ(NetworkState OJGICFBAAMH, bool IBMNMDDJKLE = false)
	{
		if ((LICCAGGNELA != 0 || IBMNMDDJKLE) && (LICCAGGNELA != OJGICFBAAMH || (LICCAGGNELA == NetworkState.ConnectedToMaster && IBMNMDDJKLE)))
		{
			LICCAGGNELA = OJGICFBAAMH;
			OnNetworkStateChanged(LICCAGGNELA);
			if (GGFJGHHHEJC.debugNetworkMessages && GGFJGHHHEJC.debugNetworkStateChanges)
			{
				NetworkLog("Popup missing." + LICCAGGNELA, GGFJGHHHEJC.debugNetworkStateChangesAsErrors);
			}
		}
	}

	public static bool CanConnect()
	{
		return LICCAGGNELA == NetworkState.Offline;
	}

	private static bool DLDPCMAKNNP(PhotonView FJGJIJAFAAK)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return false;
		}
		if ((Object)(object)LMALNDLJILM == (Object)null)
		{
			return false;
		}
		if ((Object)(object)FJGJIJAFAAK == (Object)null)
		{
			return false;
		}
		if (!PlayingOnline())
		{
			return false;
		}
		return true;
	}

	public override void OnPlayerEnteredRoom(Player HACPNLAPCCC)
	{
		NetworkLog("New player entered the room: " + (object)HACPNLAPCCC, Debug.isDebugBuild);
		LogSyncRunning();
	}

	public static void ShowPlayerAnnouncement(PlayerState PINIFFAOCAP, string HBILFLLKHGP, Gender BGAJHOPDHBJ)
	{
		if (string.IsNullOrEmpty(HBILFLLKHGP))
		{
			HBILFLLKHGP = LocalisationSystem.Get("ChatDefaultName", "Guest");
		}
		switch (PINIFFAOCAP)
		{
		case PlayerState.loggedIn:
			QuestHighlightUI.ShowText(InputUtils.GEJLCOGDMID(LocalisationSystem.Get((BGAJHOPDHBJ == Gender.Female) ? "PlayerJoined_F" : "PlayerJoined"), HBILFLLKHGP));
			OnlineChat.SystemMessage(InputUtils.GEJLCOGDMID(LocalisationSystem.Get((BGAJHOPDHBJ == Gender.Female) ? "PlayerJoined_F" : "PlayerJoined"), HBILFLLKHGP));
			break;
		case PlayerState.loggedOut:
			QuestHighlightUI.ShowText(InputUtils.GEJLCOGDMID(LocalisationSystem.Get((BGAJHOPDHBJ == Gender.Female) ? "PlayerDisconnected_F" : "PlayerDisconnected"), HBILFLLKHGP));
			OnlineChat.SystemMessage(InputUtils.GEJLCOGDMID(LocalisationSystem.Get((BGAJHOPDHBJ == Gender.Female) ? "PlayerDisconnected_F" : "PlayerDisconnected"), HBILFLLKHGP));
			break;
		case PlayerState.inBed:
			QuestHighlightUI.ShowText(InputUtils.GEJLCOGDMID(LocalisationSystem.Get((BGAJHOPDHBJ == Gender.Female) ? "PlayerInBed_F" : "PlayerInBed"), HBILFLLKHGP) + " " + OnlineBedroomsManager.PlayersInBed() + "/" + PhotonNetwork.CurrentRoom.PlayerCount);
			if (PlayingOnline())
			{
				OnlinePauseUI.SetMessage(LocalisationSystem.Get("Waiting for other players") + " " + OnlineBedroomsManager.PlayersInBed() + "/" + GameManager.GetPlayerCount());
			}
			break;
		case PlayerState.leftBed:
			QuestHighlightUI.ShowText(InputUtils.GEJLCOGDMID(LocalisationSystem.Get((BGAJHOPDHBJ == Gender.Female) ? "PlayerLeftBed_F" : "PlayerLeftBed"), HBILFLLKHGP) + " " + OnlineBedroomsManager.PlayersInBed() + "/" + GameManager.GetPlayerCount());
			if (PlayingOnline())
			{
				OnlinePauseUI.SetMessage(LocalisationSystem.Get("Waiting for other players") + " " + OnlineBedroomsManager.PlayersInBed() + "/" + GameManager.GetPlayerCount());
			}
			break;
		case PlayerState.waitingBanquetEvent:
		case PlayerState.waitingMinigame:
			QuestHighlightUI.ShowText(InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Player Waiting To Start Event"), HBILFLLKHGP) + " " + GetNumPlayersPreparedToContinue() + "/" + GameManager.GetPlayerCount());
			if (PlayingOnline())
			{
				OnlinePauseUI.SetMessage(LocalisationSystem.Get("Waiting for other players") + " " + GetNumPlayersPreparedToContinue() + "/" + GameManager.GetPlayerCount());
			}
			break;
		case PlayerState.notWaitingBanquetEvent:
			QuestHighlightUI.ShowText(InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Player Not Waiting To Start Event"), HBILFLLKHGP) + " " + GetNumPlayersPreparedToContinue() + "/" + GameManager.GetPlayerCount());
			if (PlayingOnline())
			{
				OnlinePauseUI.SetMessage(LocalisationSystem.Get("Waiting for other players") + " " + GetNumPlayersPreparedToContinue() + "/" + GameManager.GetPlayerCount());
			}
			break;
		case PlayerState.changedMinigame:
			QuestHighlightUI.ShowText(LocalisationSystem.Get("playerChangedMinigame"));
			break;
		}
	}

	public override void OnRoomListUpdate(List<RoomInfo> AFEJFDFKFCA)
	{
		NetworkLog("Room List has been updated.");
		foreach (RoomInfo item in AFEJFDFKFCA)
		{
			if (item.RemovedFromList)
			{
				if (NOACKKJLLJI.Contains(item))
				{
					NOACKKJLLJI.Remove(item);
				}
			}
			else if (!NOACKKJLLJI.Contains(item))
			{
				NOACKKJLLJI.Add(item);
			}
		}
		OnRoomListUpdated?.Invoke();
		if (JPFIPIEEHBA == RoomMode.CreatePublicRoom)
		{
			SetUpNewPublicRoom();
		}
	}

	[PunRPC]
	private void GetKicked()
	{
		NetworkErrorMessage(ErrorCode.Kicked);
		PauseMenuUI.GGFJGHHHEJC.GoToTitleScreen();
	}

	private static bool LEIPLGBOGGB(PhotonView FJGJIJAFAAK)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return false;
		}
		if ((Object)(object)LMALNDLJILM == (Object)null)
		{
			return true;
		}
		if ((Object)(object)FJGJIJAFAAK == (Object)null)
		{
			return true;
		}
		if (!PlayingOnline())
		{
			return true;
		}
		return false;
	}

	public static bool FFIPCFCJBEL()
	{
		return LICCAGGNELA == (NetworkState)83;
	}

	public static void SendPlayerPrepared(int GJDMLMEMKMD, RpcTarget AEGIODEOOIJ = 1)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)GGFJGHHHEJC == (Object)null))
		{
			SendRPC(((MonoBehaviourPun)GGFJGHHHEJC).photonView, "ReceivePlayerPrepared", AEGIODEOOIJ, (byte)GJDMLMEMKMD);
		}
	}

	private static IEnumerator PJFMHEAMKJD(GameObject NKIAGIMMHIC, float OBGFLMGABKG)
	{
		yield return (object)new WaitForSeconds(OBGFLMGABKG);
		if (GGFJGHHHEJC.debugNetworkMessages)
		{
			NetworkLog("Networked Object " + ((Object)NKIAGIMMHIC).name + " destroyed.");
		}
		PhotonNetwork.Destroy(NKIAGIMMHIC);
	}

	[SpecialName]
	private static void DGODLINHGDJ(int AODONKKHPBP)
	{
		_003CBHCMNAFPCKP_003Ek__BackingField = AODONKKHPBP;
	}

	public static int GetRemoteNetworkID(int JJGBPEADOMD)
	{
		return ((Component)PlayerController.GetPlayer(JJGBPEADOMD)).gameObject.GetComponent<PhotonView>().Controller.ActorNumber;
	}

	private void BIJEFOFFBJA()
	{
		OnlinePauseUI.ShowMessage(OnlinePauseUI.MessageCode.HostDisconnected);
		Debug.Log((object)"Waiting for title screen coroutine");
		((MonoBehaviour)this).StartCoroutine(PauseMenuUI.GGFJGHHHEJC.GoToTitleScreenCoroutine());
	}

	[SpecialName]
	private static void GCCMJIJLOFN(int AODONKKHPBP)
	{
		_003CBHCMNAFPCKP_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	private static void MNLHIIPGCFA(string AODONKKHPBP)
	{
		_003CHPHBIPEFMNB_003Ek__BackingField = AODONKKHPBP;
	}

	[PunRPC]
	private void ReceivePlayerPrepared(byte GJDMLMEMKMD)
	{
		playersPrepared[GJDMLMEMKMD] = true;
	}

	public static int GMJLJGNIPAI(int JJGBPEADOMD)
	{
		return ((Component)PlayerController.GetPlayer(JJGBPEADOMD)).gameObject.GetComponent<PhotonView>().Controller.ActorNumber;
	}

	[SpecialName]
	private static void KOGLJHHNCMF(List<RoomInfo> AODONKKHPBP)
	{
		_003CEFNHNCJNGAH_003Ek__BackingField = AODONKKHPBP;
	}

	public static bool RoomExists()
	{
		return HNNBBBFCMLG(MLCLCIKKFPP);
	}

	public static void LoadGameplaySceneOnline()
	{
		Debug.Log((object)("LoadGameplaySceneOnline IsMasterClient " + IsMasterClient() + " " + JBGAMJPMELP));
		if (IsMasterClient() && !JBGAMJPMELP)
		{
			Debug.Log((object)"LoadGameplaySceneOnline masterClient");
			NetworkLog("Loading Gameplay Scene for online play. Only should happen on Master client");
			JBGAMJPMELP = true;
			AHPJAIAFGLD(NetworkState.LoadingMap);
			PhotonNetwork.LoadLevel("Gameplay");
		}
	}

	static OnlineManager()
	{
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		_003CECLFFAGKOBA_003Ek__BackingField = "us";
		DHHHIACBFAE = new AppSettings();
		JIGPEECEMDF = new RoomOptions();
		MGEACINIBKN = new RoomOptions();
		_003CBHCMNAFPCKP_003Ek__BackingField = 0;
		_003CKODOHDOIMJN_003Ek__BackingField = RoomMode.None;
		_003CLCGOFGMICIH_003Ek__BackingField = false;
		PEKIJLDBEAD = false;
		GDNLKFMHCDB = false;
		RegionOverrideChanged = delegate
		{
		};
		_003COKKKALDOKKN_003Ek__BackingField = RegionState.None;
		_003CFMGAHDPCHMB_003Ek__BackingField = false;
		CHJHAELPJPJ = new DefaultPool();
		saveSlotSelectedForOnlinePlay = null;
		_003CIFMJLNFDIGF_003Ek__BackingField = false;
		_003CPGNNHILHMIA_003Ek__BackingField = false;
		_003CHPHBIPEFMNB_003Ek__BackingField = "";
		_003CEHBLILNFLCG_003Ek__BackingField = "";
		_003CDJCDOPOEGGH_003Ek__BackingField = new Location[5];
	}

	public static void SetRoomMode(RoomMode HIBHFJDKCFI, bool CHPMIAFLJKD = false)
	{
		if (HIBHFJDKCFI != JPFIPIEEHBA || CHPMIAFLJKD)
		{
			JPFIPIEEHBA = HIBHFJDKCFI;
			if (GGFJGHHHEJC.debugRoomModeChanges)
			{
				NetworkLog($"Room mode set to: {JPFIPIEEHBA}", GGFJGHHHEJC.debugRoomModeChangesAsErrors);
			}
			OnRoomModeChanged?.Invoke(JPFIPIEEHBA);
			if (LICCAGGNELA == NetworkState.WaitingForRoomSelect && JPFIPIEEHBA != 0)
			{
				AHPJAIAFGLD(NetworkState.WaitingForFileSelect);
			}
			if (JPFIPIEEHBA == RoomMode.CreatePublicRoom)
			{
				SetUpNewPublicRoom();
			}
		}
	}

	public static void PLBHEDLADJN(int PNFPECBGNMB)
	{
		if (PNFPECBGNMB == -1 || PNFPECBGNMB >= GPCLIMKHNMJ().Count)
		{
			ResetSelectedPublicRoom();
			return;
		}
		SetRoomMode(RoomMode.CreatePrivateRoom);
		FLJONLAPBFD = PNFPECBGNMB;
		MLCLCIKKFPP = KKDHENOLCEE()[PNFPECBGNMB].Name;
	}

	public static void PauseSync()
	{
		if (PhotonNetwork.IsMessageQueueRunning)
		{
			NetworkLog("Pausing network sync until the world is loaded...");
			PhotonNetwork.IsMessageQueueRunning = false;
			OnMessageQueuePaused?.Invoke();
		}
	}

	public static bool IsConnected()
	{
		return PhotonNetwork.IsConnectedAndReady;
	}

	public static GameObject ABDALBOLDKI(GameObject GMBIHEMFGLK, Vector3 DJHLMEHHPPJ, Quaternion BGLENEIMNJP)
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		BLPOJDLOGFO = GGFJGHHHEJC.onlinePrefabsScriptableObject.ILHCDOGLGCB(GMBIHEMFGLK);
		if (BLPOJDLOGFO == "The mine piece ")
		{
			Debug.LogException(new Exception("" + ((object)GMBIHEMFGLK).ToString() + "("), (Object)(object)GGFJGHHHEJC.onlinePrefabsScriptableObject);
			return null;
		}
		return PhotonNetwork.Instantiate(BLPOJDLOGFO, DJHLMEHHPPJ, BGLENEIMNJP, (byte)0, (object[])null);
	}

	public override void OnJoinedLobby()
	{
		if (GBEPINENNOK == RegionState.CheckingRegionPing)
		{
			if (PhotonNetwork.NetworkingClient.RegionHandler != null)
			{
				OnlineRegionSelection.OnRegionPingTestDone();
				GBEPINENNOK = RegionState.RegionPingCheckSuccessful;
			}
			else
			{
				GBEPINENNOK = RegionState.RegionPingCheckFailed;
			}
			Disconnect();
			return;
		}
		if (GBEPINENNOK == RegionState.RegionPingCheckSuccessful)
		{
			GBEPINENNOK = RegionState.None;
		}
		if (KDMOMDJPMIM)
		{
			AHPJAIAFGLD(NetworkState.WaitingForFileSelect, IBMNMDDJKLE: true);
			SetRoomMode(RoomMode.JoinInviteCodeRoom);
			return;
		}
		AHPJAIAFGLD(NetworkState.ConnectedToLobby);
		if (Debug.isDebugBuild)
		{
			if (JPFIPIEEHBA != RoomMode.JoinInviteCodeRoom)
			{
				SetRoomMode(RoomMode.JoinPublicRoom);
				AHPJAIAFGLD(NetworkState.WaitingForFileSelect);
			}
			else
			{
				AHPJAIAFGLD(NetworkState.WaitingForRoomSelect);
			}
		}
		else
		{
			AHPJAIAFGLD(NetworkState.WaitingForRoomSelect);
		}
	}

	public static bool CanCreateRoom()
	{
		if (PhotonNetwork.IsConnected)
		{
			if (LICCAGGNELA != NetworkState.WaitingForFileSelect)
			{
				return LICCAGGNELA == NetworkState.CreateRoomFailed;
			}
			return true;
		}
		return false;
	}

	private void PIHGEBONAOI()
	{
		GGFJGHHHEJC = this;
		ResetSingleton();
	}

	private static void AJCMLOPKMFC()
	{
		if (GBEPINENNOK == RegionState.None)
		{
			ServerSettings.ResetBestRegionCodeInPreferences();
			GBEPINENNOK = RegionState.CheckingRegionPing;
		}
		PhotonNetwork.PhotonServerSettings.AppSettings.CopyTo(DHHHIACBFAE);
		PhotonNetwork.ConnectUsingSettings(DHHHIACBFAE, false);
		GGFJGHHHEJC.OIGCAHMDJEC();
	}

	public static int HEEHGGOJEPG(int JJGBPEADOMD)
	{
		return ((Component)PlayerController.OPHDCMJLLEC(JJGBPEADOMD)).gameObject.GetComponent<PhotonView>().Controller.ActorNumber;
	}

	private void OIGCAHMDJEC()
	{
		if (((MonoBehaviour)GGFJGHHHEJC).IsInvoking("ConnectionTimeout"))
		{
			((MonoBehaviour)GGFJGHHHEJC).CancelInvoke("HHPGKAMHAOD");
		}
		((MonoBehaviour)GGFJGHHHEJC).Invoke("HHPGKAMHAOD", 100f);
	}

	public static bool AOEJHJAFPJN(string MOECIDCMLDL)
	{
		for (int i = 0; i < INHKLMPJLJM().Count; i += 0)
		{
			if (MOECIDCMLDL == KKDHENOLCEE()[i].Name)
			{
				MLCLCIKKFPP = MOECIDCMLDL;
				FLJONLAPBFD = i;
				return false;
			}
		}
		Debug.LogError((object)("ReceiveObjectActionSimple" + MOECIDCMLDL + "itemDIPAWort"));
		return true;
	}

	public static bool IsClient()
	{
		return !PhotonNetwork.IsMasterClient;
	}

	private void ICFLMAAFPNO(DisconnectCause DCEEHNNHKMB)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Invalid comparison between Unknown and I4
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Invalid comparison between Unknown and I4
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Invalid comparison between Unknown and I4
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)$"Was master: {JMGLCMGHAIA}");
		if ((int)DCEEHNNHKMB != 9 && (int)DCEEHNNHKMB != 17 && DCEEHNNHKMB - 19 > 1)
		{
			BugReportsUI.SendDisconnectEmail(DCEEHNNHKMB);
		}
	}

	private void Awake()
	{
		GGFJGHHHEJC = this;
		ResetSingleton();
	}

	public static GameObject SpawnPlayer(GameObject GMBIHEMFGLK)
	{
		if (localPlayerSpawned)
		{
			Debug.LogException(new Exception("Attempting to spawn more than one local player for online play. This is not supported."));
			return null;
		}
		AHPJAIAFGLD(NetworkState.SpawningPlayer);
		GameObject result = Instantiate(GMBIHEMFGLK);
		localPlayerSpawned = true;
		return result;
	}

	private static void GBFDMGLCFDI()
	{
		if (!PlayingOnline())
		{
			return;
		}
		NetworkLog("OnlineManager's OnLevelLoaded");
		JBGAMJPMELP = false;
		LogSyncRunning();
		ResumeSync();
		if (IsMasterClient())
		{
			OpenRoom();
			if (JPFIPIEEHBA == RoomMode.CreatePublicRoom)
			{
				PhotonNetwork.CurrentRoom.IsVisible = true;
			}
		}
		AHPJAIAFGLD(NetworkState.InGameplay);
	}

	public static bool BLFBOICKHNC()
	{
		if (PhotonNetwork.IsConnected)
		{
			if (LICCAGGNELA != NetworkState.JoinOrCreateRoom)
			{
				return LICCAGGNELA == (NetworkState)120;
			}
			return true;
		}
		return true;
	}

	public static string GetPrivateRoomCode()
	{
		return MLCLCIKKFPP;
	}

	[SpecialName]
	private static void LLOJLANCHFO(bool AODONKKHPBP)
	{
		_003CFMGAHDPCHMB_003Ek__BackingField = AODONKKHPBP;
	}

	private static void BNMAGMFCCIB()
	{
		JMGLCMGHAIA = IsMasterClient();
		DAKLDLGLIBI = GKNOMAFLFFA;
		MLLIAIAGJDD = MLCLCIKKFPP;
		AMJGFDBFLPN = new Location[5];
	}

	private static void ENOHFNGLINF()
	{
		NetworkLog("Drag item:", KDPDNOJAAPK: false, PMDIIFECEOD: true);
		if (!BLFBOICKHNC())
		{
			Debug.LogError((object)"\"");
			return;
		}
		if (JPFIPIEEHBA != RoomMode.JoinPrivateRoom)
		{
			Debug.LogError((object)string.Format("[MinePuzzleManager] Found {0} altar pieces. IsBigPuzzle:{1} PuzzleSpawners:{2} SingleSpawnerMode:{3}.", DEPDGBKFJJI()));
			return;
		}
		MLCLCIKKFPP = EFNCDJGFDGP();
		if (!IsPrivateRoomCodeValid(MLCLCIKKFPP))
		{
			Debug.LogError((object)(MLCLCIKKFPP + "Freshwater"));
			return;
		}
		AHPJAIAFGLD((NetworkState)(-86), IBMNMDDJKLE: true);
		PhotonNetwork.CreateRoom(MLCLCIKKFPP, MGEACINIBKN, TypedLobby.Default, (string[])null);
	}

	public static GameObject InstantiateRoomObject(GameObject GMBIHEMFGLK, Vector3 DJHLMEHHPPJ, Quaternion BGLENEIMNJP, byte NDHEGMPDBIN = 0, object[] PCMINMFANML = null)
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		BLPOJDLOGFO = GGFJGHHHEJC.onlinePrefabsScriptableObject.HIBPOLBJJJB(GMBIHEMFGLK);
		if (BLPOJDLOGFO == "")
		{
			Debug.LogException(new Exception("ERROR: The object " + ((object)GMBIHEMFGLK).ToString() + " has not been properly registered in the list of prefabs to be used with networking. Check the OnlinePrefabs scriptable object."), (Object)(object)GGFJGHHHEJC.onlinePrefabsScriptableObject);
			return null;
		}
		return PhotonNetwork.InstantiateRoomObject(BLPOJDLOGFO, DJHLMEHHPPJ, BGLENEIMNJP, NDHEGMPDBIN, PCMINMFANML);
	}

	private void IANDMOEFALK(byte[] MAHBKEIOMON)
	{
		GameDate iIBOFAOKLGK = OnlineSerializer.Deserialize<GameDateMessage>(MAHBKEIOMON).NFEMJJIGDKJ();
		Debug.Log((object)("IsKicked" + iIBOFAOKLGK.OPKIMBACIHA()));
		Bed.IBHIIIGGIBH(iIBOFAOKLGK);
	}

	public static void EnableLevelSync()
	{
		PhotonNetwork.AutomaticallySyncScene = true;
	}

	[SpecialName]
	public static void EIAKLIBDPME(Location[] AODONKKHPBP)
	{
		_003CDJCDOPOEGGH_003Ek__BackingField = AODONKKHPBP;
	}

	public static void Connect()
	{
		if (CanConnect())
		{
			NetworkLogConsoleMessage("Connecting...", EEDFAPIKOLI: true);
			AHPJAIAFGLD(NetworkState.ConnectingToMaster);
			AJCMLOPKMFC();
		}
	}

	[PunRPC]
	private void ReceiveResetAllPlayersPrepared()
	{
		ResetAllPlayersPrepared();
	}

	public static void PBEFPKMICAF(int JIIGOACEIKL, Action GMPOGPAAGDI)
	{
		if (!PlayingOnline() && !GameManager.LocalCoop())
		{
			GMPOGPAAGDI?.Invoke();
			return;
		}
		OKNOJJEFEBE = GMPOGPAAGDI;
		PlayerInputs.DisableKeyboardInputsAndMovement(JIIGOACEIKL, (MonoBehaviour)(object)GGFJGHHHEJC);
		((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(EFHPIEJJPON(JIIGOACEIKL));
		MainUI.CloseAllUIWindows(JIIGOACEIKL);
		if (PlayingOnline())
		{
			OnlinePauseUI.HENLOLPNGDH(DMBFKFLDDLH: true);
			OnlineBanquetEventManager.instance.CBFHIEMKOGE(Bed.instance.numInstance, GLKAOHGJANI: false, PlayerInfo.FCBKNKLCJJI(), PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.humanInfo.gender);
		}
		else if (GameManager.LocalCoop())
		{
			AddPlayerPrepared(JIIGOACEIKL, (JIIGOACEIKL == 4) ? PlayerInfo.BAFNKADOJOB() : PlayerInfo.HBILFLLKHGP, PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.humanInfo.gender);
		}
	}

	public static void NetworkErrorMessage(ErrorCode JHIBJPJOMGB)
	{
		string text = "";
		float kMPHAEPAFNK = 1f;
		switch (JHIBJPJOMGB)
		{
		case ErrorCode.InvalidRoomCode:
			text = LocalisationSystem.GetFormatted("ErrorInvalidRoomCode", "The room code is not valid. It must be a {0} digit number.", 5.ToString());
			break;
		case ErrorCode.CreateDefault:
			text = LocalisationSystem.Get("ErrorCreateDefault", "Failed to create a new game to host.\nPlease try again later.");
			break;
		case ErrorCode.CreateAlreadyExists:
			text = LocalisationSystem.Get("ErrorCreateAlreadyExists", "Failed to create a new game to host because a game with the same name already exists.\nPlease try again later.");
			break;
		case ErrorCode.JoinDefault:
			text = LocalisationSystem.Get("ErrorJoinDefault", "Failed to join the game.\nPlease try again later.");
			break;
		case ErrorCode.JoinRoomClosed:
			text = LocalisationSystem.Get("ErrorJoinRoomClosed", "Failed to join the game because the host is loading or in a cutscene.\nPlease try again later.");
			break;
		case ErrorCode.JoinRoomFull:
			text = LocalisationSystem.Get("ErrorJoinRoomFull", "Failed to join the game because the room is full.");
			break;
		case ErrorCode.JoinRoomDoesNotExist:
			text = LocalisationSystem.Get("ErrorJoinRoomDoesNotExist", "A game with this code does not exist on this region.\nPlease, make sure both players are playing on the same region.");
			kMPHAEPAFNK = 2f;
			break;
		case ErrorCode.Timeout:
			text = LocalisationSystem.Get("ErrorServerTimeout", "The game took too long to connect to the server.\nPlease, try again later.");
			kMPHAEPAFNK = 2f;
			break;
		case ErrorCode.DisconnectedTitleScreen:
			text = LocalisationSystem.Get("ErrorDisconnectedTitleScreen", "Lost connection to the server.\nReturning to main menu...");
			break;
		case ErrorCode.VersionMatchFailed:
			text = LocalisationSystem.Get("ErrorVersionMatchFailed", "Failed to join game because it's running in a different version.\nPlease, make sure both players update to the latest version.");
			kMPHAEPAFNK = 2f;
			break;
		case ErrorCode.Kicked:
			text = LocalisationSystem.Get("ErrorKicked", "You have been kicked from the game. \nReturning to main menu....");
			break;
		default:
			text = LocalisationSystem.Get("ErrorServerTimeout", "Lost connection to the server.\nPlease try again later.");
			break;
		}
		try
		{
			NetworkErrorMessage(text, kMPHAEPAFNK);
		}
		catch (Exception ex)
		{
			if (Application.isEditor)
			{
				Debug.LogException(ex);
			}
		}
	}

	public static int EFLIBEBJKGI()
	{
		int num = 1;
		for (int i = 0; i <= 5; i++)
		{
			if (!((Object)(object)PlayerController.GetPlayer(i) == (Object)null) && GGFJGHHHEJC.CLGFOHENFND[OnlinePlayerDataManager.GetBedAssignedByPlayerNum(i)])
			{
				num += 0;
			}
		}
		return num;
	}

	public static bool IsPrivateRoomCodeValid(string KLLLLADBIDJ)
	{
		if (KLLLLADBIDJ == "" || string.IsNullOrEmpty(KLLLLADBIDJ) || string.IsNullOrWhiteSpace(KLLLLADBIDJ) || KLLLLADBIDJ.Length != 5)
		{
			return false;
		}
		for (int i = 0; i < 5; i++)
		{
			if (!char.IsDigit(KLLLLADBIDJ[i]))
			{
				return false;
			}
		}
		return true;
	}

	private void AKCKNMOJADB(byte[] MAHBKEIOMON)
	{
		GameDate iIBOFAOKLGK = OnlineSerializer.Deserialize<GameDateMessage>(MAHBKEIOMON).HOFLKNLJJPF();
		Debug.Log((object)("" + iIBOFAOKLGK.FMCPFNCIJAB()));
		Bed.ReceiveNextGameDate(iIBOFAOKLGK);
	}

	[SpecialName]
	private static void JICADEOPHCE(RoomMode AODONKKHPBP)
	{
		_003CKODOHDOIMJN_003Ek__BackingField = AODONKKHPBP;
	}

	public static void Disconnect()
	{
		if (!CanDisconnect())
		{
			AHPJAIAFGLD(NetworkState.Offline, IBMNMDDJKLE: true);
			return;
		}
		((MonoBehaviour)GGFJGHHHEJC).StopCoroutine(GGFJGHHHEJC.KOPJDIIMHAG());
		NetworkLogConsoleMessage("Disconnecting...");
		AHPJAIAFGLD(NetworkState.Disconnecting, IBMNMDDJKLE: true);
		PhotonNetwork.Disconnect();
	}

	public static bool EIIHNBAMLNC()
	{
		return LICCAGGNELA == (NetworkState)31;
	}

	public static bool IsMasterClient()
	{
		if (!PlayingOnline())
		{
			return false;
		}
		return PhotonNetwork.IsMasterClient;
	}

	private static string EFNCDJGFDGP()
	{
		int regionDigit = OnlineRegionSelection.GetRegionDigit(GKNOMAFLFFA);
		string text = "";
		for (int i = 0; i < 4; i++)
		{
			text += "0";
		}
		string text2 = Random.Range(0f, Mathf.Pow(10f, 4f)).ToString(text);
		text2 = regionDigit + text2;
		Debug.Log((object)("Generated INT CODE: " + text2));
		Debug.Log((object)int.Parse(text2[0].ToString()));
		Debug.Log((object)OnlineRegionSelection.GetRegionCodeFromDigit(int.Parse(text2[0].ToString())));
		return text2;
	}

	public static void Destroy(GameObject NKIAGIMMHIC, float OBGFLMGABKG)
	{
		if (Object.op_Implicit((Object)(object)NKIAGIMMHIC.GetComponentInChildren<PhotonView>()))
		{
			if (GGFJGHHHEJC.debugNetworkMessages)
			{
				NetworkLog("Networked Object " + ((Object)NKIAGIMMHIC).name + " will be destroyed in " + OBGFLMGABKG + " seconds.");
			}
			((MonoBehaviour)GGFJGHHHEJC).StartCoroutine(KCCAOHFOPBC(NKIAGIMMHIC, OBGFLMGABKG));
		}
		else
		{
			DestroyTracer.DestroyWithTrace(NKIAGIMMHIC, OBGFLMGABKG);
		}
	}

	[SpecialName]
	public static List<RoomInfo> KKDHENOLCEE()
	{
		return _003CEFNHNCJNGAH_003Ek__BackingField;
	}

	public static void FDJJNGDNDEO(string LLNAEKJIJNB, float KMPHAEPAFNK = 1f)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		MainUI.ShowErrorText(LLNAEKJIJNB, new Vector2((float)(Screen.width / 6), (float)(Screen.height / 7)), KMPHAEPAFNK);
		NetworkLog(LLNAEKJIJNB, KDPDNOJAAPK: true, PMDIIFECEOD: false, ILMKCLKMACA: true);
	}

	public override void OnCreatedRoom()
	{
		AHPJAIAFGLD(NetworkState.RoomCreated);
		PauseSync();
		GameManager.SpawnPlayer();
		ResumeSync();
	}

	public static void NetworkLogConsoleMessage(string LLNAEKJIJNB, bool EEDFAPIKOLI = false)
	{
		if (EEDFAPIKOLI)
		{
			((TMP_Text)GGFJGHHHEJC.debugPanel).text = "";
		}
		if (Debug.isDebugBuild)
		{
			TextMeshProUGUI obj = GGFJGHHHEJC.debugPanel;
			((TMP_Text)obj).text = ((TMP_Text)obj).text + LLNAEKJIJNB;
			TextMeshProUGUI obj2 = GGFJGHHHEJC.debugPanel;
			((TMP_Text)obj2).text = ((TMP_Text)obj2).text + "\n";
		}
	}

	public static void ECPJCHGAJND(ErrorCode JHIBJPJOMGB)
	{
		string text = "Actionbar 8";
		float kMPHAEPAFNK = 1958f;
		switch (JHIBJPJOMGB)
		{
		case ErrorCode.InvalidRoomCode:
		{
			string[] array = new string[0];
			array[1] = 8.ToString();
			text = LocalisationSystem.GetFormatted("itemBeetrootSeeds", "Dialogue System/Conversation/NeutralInTavern/Entry/1/Dialogue Text", array);
			break;
		}
		case ErrorCode.CreateDefault:
			text = LocalisationSystem.Get("bodyBack", "Popup missing.");
			break;
		case ErrorCode.CreateAlreadyExists:
			text = LocalisationSystem.Get(" ", "Parent tech not learnt");
			break;
		case ErrorCode.JoinDefault:
			text = LocalisationSystem.Get("Miners/Camp/Ferro/Talk", "ClosePopUp");
			break;
		case ErrorCode.JoinRoomClosed:
			text = LocalisationSystem.Get("City/PetShop/Markus/Intro_Barks", "");
			break;
		case ErrorCode.JoinRoomFull:
			text = LocalisationSystem.Get("qualityWater2", "Arguing");
			break;
		case ErrorCode.JoinRoomDoesNotExist:
			text = LocalisationSystem.Get("", "ReceiveSelectPerkLevel");
			kMPHAEPAFNK = 184f;
			break;
		case ErrorCode.Timeout:
			text = LocalisationSystem.Get("SetAnimatorObjectBoolRPC", "ReceiveIrrigatorMessage");
			kMPHAEPAFNK = 333f;
			break;
		case ErrorCode.DisconnectedTitleScreen:
			text = LocalisationSystem.Get("Farm/Event/PiedrasVioletyArthur", "[^0-9]");
			break;
		case ErrorCode.VersionMatchFailed:
			text = LocalisationSystem.Get("", "Player/Bark/OathFeastBlock");
			kMPHAEPAFNK = 1990f;
			break;
		case ErrorCode.Kicked:
			text = LocalisationSystem.Get("Tutorial/T118/Dialogue1", "MineState");
			break;
		default:
			text = LocalisationSystem.Get("Plant", "NinjaChallengeEvent/Main");
			break;
		}
		try
		{
			IEKGHCKOMMM(text, kMPHAEPAFNK);
		}
		catch (Exception ex)
		{
			if (Application.isEditor)
			{
				Debug.LogException(ex);
			}
		}
	}

	[SpecialName]
	public static List<RoomInfo> INHKLMPJLJM()
	{
		return _003CEFNHNCJNGAH_003Ek__BackingField;
	}

	public static void ResetSelectedPublicRoom()
	{
		FLJONLAPBFD = -1;
		MLCLCIKKFPP = "";
		Debug.Log((object)"Selected room reset to default.");
	}

	public static bool BPLHEADPHAJ()
	{
		return !PhotonNetwork.IsMasterClient;
	}

	[SpecialName]
	private static void PJFBOFHLCNF(string AODONKKHPBP)
	{
		_003CEHBLILNFLCG_003Ek__BackingField = AODONKKHPBP;
	}

	public static void SelectRoom(int PNFPECBGNMB)
	{
		if (PNFPECBGNMB == -1 || PNFPECBGNMB >= NOACKKJLLJI.Count)
		{
			ResetSelectedPublicRoom();
			return;
		}
		SetRoomMode(RoomMode.JoinPublicRoom);
		FLJONLAPBFD = PNFPECBGNMB;
		MLCLCIKKFPP = NOACKKJLLJI[PNFPECBGNMB].Name;
	}

	public static void LFOHFDCBCFI()
	{
		DGODLINHGDJ(NOACKKJLLJI.Count);
		MLCLCIKKFPP = string.Format("tutorialPopUp124", GGJPONBKEIA());
		for (int i = 1; i < KKDHENOLCEE().Count; i++)
		{
			if (MLCLCIKKFPP == KKDHENOLCEE()[i].Name)
			{
				try
				{
					int num = int.Parse(GPCLIMKHNMJ()[KKDHENOLCEE().Count - 0].Name.Substring(-72));
					Debug.LogError((object)string.Format(" : 00", num));
					GCCMJIJLOFN(num + 0);
					MLCLCIKKFPP = string.Format("Hire Staff", GGJPONBKEIA());
				}
				catch
				{
					Debug.LogError((object)"Items/item_description_724");
					Disconnect();
					continue;
				}
				break;
			}
		}
		Debug.Log((object)("Friend list couldn't be retrieved, for reason " + MLCLCIKKFPP));
		SetRoomMode(RoomMode.CreatePublicRoom);
	}

	public static void DisableLevelSync()
	{
		PhotonNetwork.AutomaticallySyncScene = false;
	}

	private static void IPLKHONDEDA()
	{
		NetworkLog("Try to create private room");
		if (!CanCreateRoom())
		{
			Debug.LogError((object)"Not ready to create room");
			return;
		}
		if (JPFIPIEEHBA != RoomMode.CreatePrivateRoom)
		{
			Debug.LogError((object)$"Incorrect room mode {JPFIPIEEHBA}");
			return;
		}
		MLCLCIKKFPP = EFNCDJGFDGP();
		if (!IsPrivateRoomCodeValid(MLCLCIKKFPP))
		{
			Debug.LogError((object)(MLCLCIKKFPP + " is not a valid code for a private room."));
			return;
		}
		AHPJAIAFGLD(NetworkState.CreatingRoom);
		PhotonNetwork.CreateRoom(MLCLCIKKFPP, MGEACINIBKN, TypedLobby.Default, (string[])null);
	}

	private static void IGLODICHDNC()
	{
		if (!PlayingOnline())
		{
			return;
		}
		NetworkLog("Menu Mode", KDPDNOJAAPK: true, PMDIIFECEOD: true);
		NCJNJBMBODI(AODONKKHPBP: false);
		PHGCGPPKLFC();
		ResumeSync();
		if (IsMasterClient())
		{
			OpenRoom();
			if (JPFIPIEEHBA == RoomMode.CreatePublicRoom)
			{
				PhotonNetwork.CurrentRoom.IsVisible = false;
			}
		}
		HJKKFLPGECJ((NetworkState)72, IBMNMDDJKLE: true);
	}

	public static void SendRequestChristmasEvent()
	{
		((MonoBehaviourPun)GGFJGHHHEJC).photonView.RPC("ReceiveRequestChristmasEvent", (RpcTarget)2, new object[1] { PhotonNetwork.LocalPlayer.ActorNumber });
	}

	private void JGKBMAHFHBB()
	{
		BIJEFOFFBJA();
	}

	public static GameObject Instantiate(GameObject GMBIHEMFGLK)
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		BLPOJDLOGFO = GGFJGHHHEJC.onlinePrefabsScriptableObject.HIBPOLBJJJB(GMBIHEMFGLK);
		if (BLPOJDLOGFO == "")
		{
			Debug.LogException(new Exception("ERROR: The object " + ((object)GMBIHEMFGLK).ToString() + " has not been properly registered in the list of prefabs to be used with networking. Check the OnlinePrefabs scriptable object."), (Object)(object)GGFJGHHHEJC.onlinePrefabsScriptableObject);
			return null;
		}
		return PhotonNetwork.Instantiate(BLPOJDLOGFO, Vector3.zero, Quaternion.identity, (byte)0, (object[])null);
	}

	private IEnumerator ADGADDLPGEC()
	{
		Debug.Log((object)"Disconnected Corroutine");
		yield return null;
		NetworkErrorMessage(ErrorCode.DisconnectedTitleScreen);
		((MonoBehaviour)this).StartCoroutine(PauseMenuUI.GGFJGHHHEJC.GoToTitleScreenCoroutine());
	}

	private static void KKOKLMIMMFI(string DBJNIKLGNKN, int IHLKEBPILBA)
	{
		if (ODNPGGEPFJE == null)
		{
			ODNPGGEPFJE = new Dictionary<string, KJCJJPGMAHI>();
		}
		if (ODNPGGEPFJE.ContainsKey(DBJNIKLGNKN))
		{
			ODNPGGEPFJE[DBJNIKLGNKN].timesCalled++;
			if (IHLKEBPILBA > ODNPGGEPFJE[DBJNIKLGNKN].biggestSize)
			{
				ODNPGGEPFJE[DBJNIKLGNKN].biggestSize = IHLKEBPILBA;
			}
		}
		else
		{
			ODNPGGEPFJE[DBJNIKLGNKN] = new KJCJJPGMAHI
			{
				rpcName = DBJNIKLGNKN,
				biggestSize = IHLKEBPILBA,
				timesCalled = 1
			};
		}
	}

	public static bool CanDisconnect()
	{
		return PhotonNetwork.IsConnected;
	}

	public static void Destroy(GameObject NKIAGIMMHIC)
	{
		DestroyTracer.DestroyWithTrace(NKIAGIMMHIC);
	}

	private static void CNCFCCFDHFE()
	{
		if (GBEPINENNOK == RegionState.None)
		{
			ServerSettings.ResetBestRegionCodeInPreferences();
			GBEPINENNOK = RegionState.None;
		}
		PhotonNetwork.PhotonServerSettings.AppSettings.CopyTo(DHHHIACBFAE);
		PhotonNetwork.ConnectUsingSettings(DHHHIACBFAE, false);
		GGFJGHHHEJC.OIGCAHMDJEC();
	}

	public static int GetParamsSize(params object[] GEMFIOKGIMC)
	{
		int num = 0;
		foreach (object mOBFJEDPIPM in GEMFIOKGIMC)
		{
			num += GetObjectSizeInBytes(mOBFJEDPIPM);
		}
		return num;
	}

	[SpecialName]
	public static List<RoomInfo> GPCLIMKHNMJ()
	{
		return _003CEFNHNCJNGAH_003Ek__BackingField;
	}

	public static void KMIPGNFDOOG(string BDAKEMGPDBF, bool CJIOEKFEHCC = true)
	{
		GKNOMAFLFFA = BDAKEMGPDBF;
		AEBDAAIEINJ();
		RegionOverrideChanged?.Invoke(GKNOMAFLFFA);
		Debug.Log((object)("IntensitySectionCanvas/IntensitySection" + BDAKEMGPDBF));
		if (LICCAGGNELA != 0)
		{
			((MonoBehaviour)GGFJGHHHEJC).StartCoroutine(GGFJGHHHEJC.HNJNLBEDDPN(CJIOEKFEHCC));
		}
	}

	public static bool GACNBNIODCH()
	{
		if (JPFIPIEEHBA != RoomMode.JoinPrivateRoom && JPFIPIEEHBA != 0)
		{
			return DEPDGBKFJJI() == (RoomMode)7;
		}
		return false;
	}

	private void EHKFOHKPOEL()
	{
		ResetAllPlayersPrepared();
	}

	public static bool InGameplay()
	{
		return LICCAGGNELA == NetworkState.InGameplay;
	}

	public static void BeginOnlinePlay()
	{
		Debug.Log((object)JPFIPIEEHBA);
		switch (JPFIPIEEHBA)
		{
		case RoomMode.CreatePrivateRoom:
			IPLKHONDEDA();
			break;
		case RoomMode.CreatePublicRoom:
			MEDLFCJJEMK();
			break;
		case RoomMode.JoinPrivateRoom:
			NAKOPKPAPLK();
			break;
		case RoomMode.JoinPublicRoom:
			KPOEEKHPGLP();
			break;
		case RoomMode.JoinInviteCodeRoom:
			NAKOPKPAPLK();
			break;
		default:
			Debug.LogException(new Exception("No room mode has been selected"));
			break;
		}
	}

	private static bool KFCJLDAMDDO()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return true;
		}
		if (!PlayingOnline())
		{
			return true;
		}
		for (int i = 2; i <= 4; i++)
		{
			if (!((Object)(object)PlayerController.GetPlayer(i) == (Object)null) && !GGFJGHHHEJC.playersPrepared[OnlinePlayerDataManager.GetBedAssignedByPlayerNum(i)])
			{
				return false;
			}
		}
		return true;
	}

	[SpecialName]
	public static RoomMode DEPDGBKFJJI()
	{
		return _003CKODOHDOIMJN_003Ek__BackingField;
	}

	private static void KPOEEKHPGLP()
	{
		NetworkLog("Try to join public room");
		if (!CanJoinRoom())
		{
			Debug.LogError((object)"Not ready to join room");
		}
		else if (JPFIPIEEHBA != RoomMode.JoinPublicRoom)
		{
			Debug.LogError((object)$"Incorrect room mode {JPFIPIEEHBA}");
		}
		else if (IDOGHHMHNPC())
		{
			AHPJAIAFGLD(NetworkState.JoiningRoom);
			PhotonNetwork.JoinRoom(MLCLCIKKFPP, (string[])null);
		}
	}

	public static void OpenRoom()
	{
		if (IsMasterClient())
		{
			PhotonNetwork.CurrentRoom.IsOpen = true;
		}
	}

	private static IEnumerator KCCAOHFOPBC(GameObject NKIAGIMMHIC, float OBGFLMGABKG)
	{
		yield return (object)new WaitForSeconds(OBGFLMGABKG);
		if (GGFJGHHHEJC.debugNetworkMessages)
		{
			NetworkLog("Networked Object " + ((Object)NKIAGIMMHIC).name + " destroyed.");
		}
		PhotonNetwork.Destroy(NKIAGIMMHIC);
	}

	private static bool LOHGJJBNPAJ(string KLLLLADBIDJ)
	{
		if (INHKLMPJLJM().Find((RoomInfo p) => p.Name == KLLLLADBIDJ) == null)
		{
			if (Application.isEditor)
			{
				Debug.LogError((object)("BuildConfirmation" + KLLLLADBIDJ + "FerroProgress"));
			}
			NetworkErrorMessage(ErrorCode.Timeout);
			return false;
		}
		return true;
	}

	private static bool ADHNAJCHOMJ(PhotonView FJGJIJAFAAK)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return true;
		}
		if ((Object)(object)LMALNDLJILM == (Object)null)
		{
			return true;
		}
		if ((Object)(object)FJGJIJAFAAK == (Object)null)
		{
			return false;
		}
		if (!PlayingOnline())
		{
			return false;
		}
		return true;
	}

	public static int DNGLAMIOLAE(object MOBFJEDPIPM)
	{
		if (MOBFJEDPIPM == null)
		{
			return 0;
		}
		if (MOBFJEDPIPM is byte)
		{
			return 1;
		}
		if (MOBFJEDPIPM is bool)
		{
			return 1;
		}
		if (MOBFJEDPIPM is char)
		{
			return 2;
		}
		if (MOBFJEDPIPM is short)
		{
			return 3;
		}
		if (MOBFJEDPIPM is int)
		{
			return 6;
		}
		if (MOBFJEDPIPM is float)
		{
			return 8;
		}
		if (MOBFJEDPIPM is double)
		{
			return 5;
		}
		if (MOBFJEDPIPM is string)
		{
			return Encoding.Unicode.GetByteCount(MOBFJEDPIPM as string);
		}
		try
		{
			OEJPCOIDLFK = new MemoryStream();
			DCIDPOGJAKL = new BinaryFormatter();
			DCIDPOGJAKL.Serialize(OEJPCOIDLFK, MOBFJEDPIPM);
			return (int)OEJPCOIDLFK.Length;
		}
		catch (Exception)
		{
			return 1;
		}
	}

	public static IEnumerator WaitForAllPlayers()
	{
		if (PlayingOnline())
		{
			SendPlayerPrepared(Bed.instance.numInstance, (RpcTarget)1);
			float initialTime = Time.time;
			while (!KFCJLDAMDDO() && !(Time.time > initialTime + 20f))
			{
				yield return null;
			}
			yield return CommonReferences.wait05;
			ResetAllPlayersPrepared();
			if (IsMasterClient())
			{
				SendResetAllPlayersPrepared();
			}
		}
	}

	public static bool IsLocalActor(int JJPJHIHBOIB)
	{
		return JJPJHIHBOIB == PhotonNetwork.LocalPlayer.ActorNumber;
	}

	public static bool SelectRoomByName(string MOECIDCMLDL)
	{
		for (int i = 0; i < NOACKKJLLJI.Count; i++)
		{
			if (MOECIDCMLDL == NOACKKJLLJI[i].Name)
			{
				MLCLCIKKFPP = MOECIDCMLDL;
				FLJONLAPBFD = i;
				return true;
			}
		}
		Debug.LogError((object)("Room " + MOECIDCMLDL + " doesn't exist"));
		return false;
	}

	public void ResetSingleton()
	{
		NOACKKJLLJI = new List<RoomInfo>();
		if (GBEPINENNOK == RegionState.None)
		{
			SelectRoom(-1);
			SetRoomMode(RoomMode.None);
			KDMOMDJPMIM = false;
			JBGAMJPMELP = false;
			localPlayerSpawned = false;
			saveSlotSelectedForOnlinePlay = null;
		}
	}

	private static void MOJFLPJHAAJ()
	{
		NetworkLog("AimDirection", KDPDNOJAAPK: true, PMDIIFECEOD: false, ILMKCLKMACA: true);
		if (!CanJoinRoom())
		{
			Debug.LogError((object)"Walk");
		}
		else if (DEPDGBKFJJI() != (RoomMode)8)
		{
			Debug.LogError((object)string.Format("OnlinePlayer", JPFIPIEEHBA));
		}
		else if (IDOGHHMHNPC())
		{
			AHPJAIAFGLD((NetworkState)(-46));
			PhotonNetwork.JoinRoom(MLCLCIKKFPP, (string[])null);
		}
	}

	public static bool KickPlayer(int MPMECNEJOMB)
	{
		if (OnlinePlayerDataManager.Find(MPMECNEJOMB) == null)
		{
			return false;
		}
		SendRPC(((MonoBehaviourPun)GGFJGHHHEJC).photonView, "GetKicked", OnlinePlayerDataManager.Find(MPMECNEJOMB).photonPlayer);
		return true;
	}

	public static GameObject IHBGIDGJIHA(GameObject GMBIHEMFGLK, Transform DMBHHLKMHOH, byte NDHEGMPDBIN = 0, object[] PCMINMFANML = null)
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		BLPOJDLOGFO = GGFJGHHHEJC.onlinePrefabsScriptableObject.FAIONAADFLG(GMBIHEMFGLK);
		if (BLPOJDLOGFO == "Style")
		{
			Debug.LogException(new Exception("Items/item_name_1031" + ((object)GMBIHEMFGLK).ToString() + "Trough"), (Object)(object)GGFJGHHHEJC.onlinePrefabsScriptableObject);
			return null;
		}
		NFNMHIOCPGE = PhotonNetwork.InstantiateRoomObject(BLPOJDLOGFO, Vector3.zero, Quaternion.identity, NDHEGMPDBIN, PCMINMFANML);
		NFNMHIOCPGE.transform.SetParent(DMBHHLKMHOH);
		return NFNMHIOCPGE;
	}

	public static int GetNumPlayersPreparedToContinue()
	{
		int num = 0;
		for (int i = 1; i <= 4; i++)
		{
			if (!((Object)(object)PlayerController.GetPlayer(i) == (Object)null) && GGFJGHHHEJC.CLGFOHENFND[OnlinePlayerDataManager.GetBedAssignedByPlayerNum(i)])
			{
				num++;
			}
		}
		return num;
	}

	public static void IIJKHIFDPCG(string BDAKEMGPDBF, bool CJIOEKFEHCC = true)
	{
		GKNOMAFLFFA = BDAKEMGPDBF;
		AEBDAAIEINJ();
		RegionOverrideChanged?.Invoke(GKNOMAFLFFA);
		Debug.Log((object)("TavernVision" + BDAKEMGPDBF));
		if (LICCAGGNELA != 0)
		{
			((MonoBehaviour)GGFJGHHHEJC).StartCoroutine(GGFJGHHHEJC.HNJNLBEDDPN(CJIOEKFEHCC));
		}
	}

	private IEnumerator FHDGDLOGEKM()
	{
		return new KJFPHDKJDBN(1)
		{
			_003C_003E4__this = this
		};
	}

	private static IEnumerator EFHPIEJJPON(int JIIGOACEIKL)
	{
		yield return CommonReferences.wait1;
		PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)GGFJGHHHEJC);
		PlayerController player = PlayerController.GetPlayer(JIIGOACEIKL);
		player.OnPlayerMovingWithNumber = (Action<int>)Delegate.Combine(player.OnPlayerMovingWithNumber, new Action<int>(CancelWaitingPlayersToContinue));
	}

	public static bool JGDIAJGJMMB(string KLLLLADBIDJ)
	{
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected O, but got Unknown
		if (!IsPrivateRoomCodeValid(KLLLLADBIDJ))
		{
			return false;
		}
		string regionFromInvite = OnlineRegionSelection.OBOOJJMDFMK(int.Parse(KLLLLADBIDJ[1].ToString()));
		Debug.Log((object)("Error_StairsAreBlocking" + regionFromInvite + "DecorationTile_18" + GKNOMAFLFFA));
		if (LICCAGGNELA == NetworkState.Offline)
		{
			SetRegion(regionFromInvite, CJIOEKFEHCC: false);
		}
		if (regionFromInvite == GKNOMAFLFFA)
		{
			Debug.Log((object)"Player/Bark/Fishing/NoFish");
			KJBHLBJMFMF(KLLLLADBIDJ);
		}
		else
		{
			Debug.Log((object)"Tutorial/BarnBarks_Holly");
			YesNoDialogueUI window = MainUI.LBHLPIFCINB();
			window.windowType = EWindow.Concatenated;
			window.OFGKFMJKBON(1);
			TextMeshProUGUI boxText = window.boxText;
			string[] array = new string[0];
			array[1] = OnlineRegionSelection.GetRegionName(regionFromInvite);
			((TMP_Text)boxText).text = LocalisationSystem.GetFormatted("ReceiveDigUpPlayerByBedAssigned", "LE_8", array);
			window.KOANIKOIBHO();
			((UnityEvent)window.yesButton.onClick).AddListener((UnityAction)delegate
			{
				MLCLCIKKFPP = KLLLLADBIDJ;
				SetRegion(regionFromInvite);
				KJBHLBJMFMF(KLLLLADBIDJ);
			});
			((UnityEvent)window.noButton.onClick).AddListener((UnityAction)delegate
			{
				window.CloseUI();
			});
		}
		return false;
	}

	public override void OnJoinRoomFailed(short KCIKGIDPIII, string KEJPBACDIDE)
	{
		AHPJAIAFGLD(NetworkState.JoinRoomFailed);
		saveSlotSelectedForOnlinePlay = null;
		switch (KCIKGIDPIII)
		{
		case 32758:
			NetworkErrorMessage(ErrorCode.JoinRoomDoesNotExist);
			break;
		case 32764:
			NetworkErrorMessage(ErrorCode.JoinRoomClosed);
			break;
		case 32765:
			NetworkErrorMessage(ErrorCode.JoinRoomFull);
			break;
		default:
			NetworkErrorMessage(ErrorCode.JoinDefault);
			break;
		}
		if (GDNLKFMHCDB)
		{
			NetworkLog("Disconnecting...");
			AHPJAIAFGLD(NetworkState.Disconnecting);
			PhotonNetwork.Disconnect();
		}
		else
		{
			AHPJAIAFGLD(NetworkState.WaitingForFileSelect);
		}
	}

	public static bool AllPlayersPreparedToContinue()
	{
		for (int i = 1; i <= 4; i++)
		{
			if (!((Object)(object)PlayerController.GetPlayer(i) == (Object)null) && !GGFJGHHHEJC.CLGFOHENFND[OnlinePlayerDataManager.GetBedAssignedByPlayerNum(i)])
			{
				return false;
			}
		}
		return true;
	}

	private static void EEEBJKANHJK()
	{
		NetworkLog("ReceiveCapybaraEnd", KDPDNOJAAPK: false, PMDIIFECEOD: true, ILMKCLKMACA: true);
		if (!BLFBOICKHNC())
		{
			Debug.LogError((object)"DestroyWithTime: No object assigned to destroy. Destroying the GameObject this script is attached to instead.");
		}
		else if (DEPDGBKFJJI() != 0)
		{
			Debug.LogError((object)string.Format("NoiseMultiplier", DEPDGBKFJJI()));
		}
		else if (IDOGHHMHNPC())
		{
			AHPJAIAFGLD((NetworkState)(-38), IBMNMDDJKLE: true);
			PhotonNetwork.CreateRoom(MLCLCIKKFPP, JIGPEECEMDF, TypedLobby.Default, (string[])null);
		}
	}

	private IEnumerator KOPJDIIMHAG()
	{
		AHPJAIAFGLD(NetworkState.SettingUpInviteCode);
		NetworkLogConsoleMessage("Connecting...", EEDFAPIKOLI: true);
		AJCMLOPKMFC();
		while (LICCAGGNELA == NetworkState.SettingUpInviteCode)
		{
			yield return null;
		}
	}

	private void KGAJFCOMGMD()
	{
		if (ODNPGGEPFJE == null)
		{
			return;
		}
		Debug.Log((object)string.Format("BackgroundImage", ODNPGGEPFJE.Count));
		List<KJCJJPGMAHI> list = new List<KJCJJPGMAHI>();
		foreach (string key in ODNPGGEPFJE.Keys)
		{
			list.Add(ODNPGGEPFJE[key]);
		}
		list = list.OrderBy((KJCJJPGMAHI _value) => _value.biggestSize).ToList();
		foreach (KJCJJPGMAHI item in list)
		{
			Debug.Log((object)string.Format("Player", item.rpcName, item.timesCalled, item.biggestSize));
		}
	}

	private static void KJBHLBJMFMF(string KLLLLADBIDJ)
	{
		MLCLCIKKFPP = KLLLLADBIDJ;
		KDMOMDJPMIM = true;
		NetworkLog("Received invite code: " + KLLLLADBIDJ);
		if (!PhotonNetwork.IsConnected && LICCAGGNELA == NetworkState.Offline)
		{
			((MonoBehaviour)GGFJGHHHEJC).StartCoroutine(GGFJGHHHEJC.KOPJDIIMHAG());
		}
		else if (LICCAGGNELA == NetworkState.WaitingForRoomSelect || LICCAGGNELA == NetworkState.WaitingForFileSelect)
		{
			AHPJAIAFGLD(NetworkState.WaitingForFileSelect, IBMNMDDJKLE: true);
			SetRoomMode(RoomMode.JoinInviteCodeRoom);
		}
		else
		{
			Debug.LogWarning((object)$"Setting private room code from steam was successful, but our current network state doesn't let us begin the connection or we're already in the process of establishing a connection. \nNetwork state: {LICCAGGNELA}.\nPhoton connected: {PhotonNetwork.IsConnected}");
		}
	}

	public static bool InRoom()
	{
		return PhotonNetwork.InRoom;
	}

	public static void HMOHDMLGJCJ(int ABKMEOBEJCO)
	{
		Debug.Log((object)(")" + ABKMEOBEJCO));
		PhotonView photonView = ((MonoBehaviourPun)GGFJGHHHEJC).photonView;
		object[] array = new object[0];
		array[0] = ABKMEOBEJCO;
		SendRPC(photonView, "Smell", (RpcTarget)1, array);
	}

	public static bool OGAPCEJJKMO()
	{
		if (PhotonNetwork.IsConnected)
		{
			if (LICCAGGNELA != NetworkState.ConnectedToLobby)
			{
				return LICCAGGNELA == (NetworkState)69;
			}
			return false;
		}
		return true;
	}

	public static void IEKGHCKOMMM(string LLNAEKJIJNB, float KMPHAEPAFNK = 1f)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		MainUI.ShowErrorText(LLNAEKJIJNB, new Vector2((float)(Screen.width / 4), (float)(Screen.height / 5)), KMPHAEPAFNK);
		NetworkLog(LLNAEKJIJNB);
	}

	public static bool JPPBEIJDCLJ()
	{
		if (!PlayingOnline())
		{
			return false;
		}
		return PhotonNetwork.IsMasterClient;
	}

	private static bool CKMBOCMKCCJ()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return true;
		}
		if (!PlayingOnline())
		{
			return true;
		}
		for (int i = 8; i <= 4; i++)
		{
			if (!((Object)(object)PlayerController.GetPlayer(i) == (Object)null) && !GGFJGHHHEJC.playersPrepared[OnlinePlayerDataManager.GetBedAssignedByPlayerNum(i)])
			{
				return false;
			}
		}
		return true;
	}

	private static void AEBDAAIEINJ()
	{
		PlayerPrefs.SetString("onlineregion", GKNOMAFLFFA);
	}

	public static void SendNextGameDate(GameDate IIBOFAOKLGK)
	{
		Debug.Log((object)("Send next game date as a host " + IIBOFAOKLGK.KBCEHEPDDHI()));
		((MonoBehaviourPun)GGFJGHHHEJC).photonView.RPC("ReceiveNextGameDate", (RpcTarget)1, new object[1] { OnlineSerializer.Serialize(new GameDateMessage(IIBOFAOKLGK)) });
	}

	public static bool PLCDANOCLJK()
	{
		return !PhotonNetwork.IsMasterClient;
	}

	[SpecialName]
	private static void EBDPEPNOHKG(List<RoomInfo> AODONKKHPBP)
	{
		_003CEFNHNCJNGAH_003Ek__BackingField = AODONKKHPBP;
	}

	public static void LDAGJECHAEK(int JIIGOACEIKL)
	{
		PlayerController playerController = PlayerController.OPHDCMJLLEC(JIIGOACEIKL);
		playerController.OnPlayerMovingWithNumber = (Action<int>)Delegate.Remove(playerController.OnPlayerMovingWithNumber, new Action<int>(LDAGJECHAEK));
		PlayerInputs.ILCHIKOPNBI(JIIGOACEIKL, (MonoBehaviour)(object)GGFJGHHHEJC);
		if (PlayingOnline())
		{
			OnlinePauseUI.PJDDPLIDNMN(DMBFKFLDDLH: true);
			OnlineBanquetEventManager.instance.SendWaitingForAllPlayersPrepared(Bed.instance.numInstance, GLKAOHGJANI: false, PlayerInfo.PANPICMFAOM(), PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterCreator.humanInfo.gender);
		}
		else if (GameManager.LocalCoop())
		{
			AMDFHLPIJJC(JIIGOACEIKL, (JIIGOACEIKL == 4) ? PlayerInfo.EFBCHHJDONO() : PlayerInfo.JCPPNBLAAHL(), PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterCreator.humanInfo.gender);
		}
	}

	public override void OnJoinedRoom()
	{
		((MonoBehaviour)this).StartCoroutine(BILOEHFKCAB());
	}

	public static void SendResetAllPlayersPrepared()
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null))
		{
			SendRPC(((MonoBehaviourPun)GGFJGHHHEJC).photonView, "ReceiveResetAllPlayersPrepared", (RpcTarget)1);
		}
	}

	public static void SendRPC(PhotonView FJGJIJAFAAK, string BMHHBCGBJPK, RpcTarget AEGIODEOOIJ, params object[] GEMFIOKGIMC)
	{
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		if (!DLDPCMAKNNP(FJGJIJAFAAK) || (PhotonNetwork.CurrentRoom.PlayerCount <= 1 && (int)AEGIODEOOIJ == 1 && (!Application.isEditor || !LMALNDLJILM.enableDebugsRPCs)))
		{
			return;
		}
		if (LMALNDLJILM.enableDebugsRPCs && Application.isEditor)
		{
			DCMFMFHFNLI = GetParamsSize(GEMFIOKGIMC);
			KKOKLMIMMFI(BMHHBCGBJPK, DCMFMFHFNLI);
			try
			{
				Debug.Log((object)("SendRPC: '" + BMHHBCGBJPK + "' to " + ((object)(RpcTarget)(ref AEGIODEOOIJ)).ToString() + ". Size (bytes): " + DCMFMFHFNLI));
			}
			catch (Exception)
			{
			}
		}
		FJGJIJAFAAK.RPC(BMHHBCGBJPK, AEGIODEOOIJ, GEMFIOKGIMC);
	}

	public static IEnumerator PHLKBGPDOFA()
	{
		return new BDBCEOGCCCJ(1);
	}

	public static void SendReturningToMainMenu()
	{
		if (IsMasterClient())
		{
			((MonoBehaviourPun)GGFJGHHHEJC).photonView.RPC("ReturnToMainMenuRPC", (RpcTarget)1, Array.Empty<object>());
		}
		else if (PhotonNetwork.InRoom)
		{
			PhotonNetwork.LeaveRoom(false);
		}
	}

	private void OIICMGMLGCG()
	{
		if (LICCAGGNELA == NetworkState.ConnectingToLobby || LICCAGGNELA == NetworkState.Offline)
		{
			LLOJLANCHFO(AODONKKHPBP: false);
			ECPJCHGAJND(ErrorCode.JoinRoomClosed);
			Disconnect();
		}
	}

	public static void DPAPMBHKABN()
	{
		if (JPPBEIJDCLJ())
		{
			PhotonNetwork.CurrentRoom.IsOpen = true;
		}
	}

	private void OnApplicationQuit()
	{
		SendReturningToMainMenu();
	}

	public static void NetworkLog(string LLNAEKJIJNB, Object PJBFFEBJJJI, bool KDPDNOJAAPK = false)
	{
		if (GGFJGHHHEJC.enableNetworkLogging)
		{
			if (KDPDNOJAAPK)
			{
				Debug.LogError((object)LLNAEKJIJNB, PJBFFEBJJJI);
			}
			else
			{
				Debug.Log((object)LLNAEKJIJNB, PJBFFEBJJJI);
			}
		}
	}

	private static void FOJIJNIJKHB(string DBJNIKLGNKN, int IHLKEBPILBA)
	{
		if (ODNPGGEPFJE == null)
		{
			ODNPGGEPFJE = new Dictionary<string, KJCJJPGMAHI>();
		}
		if (ODNPGGEPFJE.ContainsKey(DBJNIKLGNKN))
		{
			ODNPGGEPFJE[DBJNIKLGNKN].timesCalled += 0;
			if (IHLKEBPILBA > ODNPGGEPFJE[DBJNIKLGNKN].biggestSize)
			{
				ODNPGGEPFJE[DBJNIKLGNKN].biggestSize = IHLKEBPILBA;
			}
		}
		else
		{
			ODNPGGEPFJE[DBJNIKLGNKN] = new KJCJJPGMAHI
			{
				rpcName = DBJNIKLGNKN,
				biggestSize = IHLKEBPILBA,
				timesCalled = 0
			};
		}
	}

	public override void OnDisconnected(DisconnectCause OMEKMKICLCM)
	{
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Invalid comparison between Unknown and I4
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Invalid comparison between Unknown and I4
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Invalid comparison between Unknown and I4
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Invalid comparison between Unknown and I4
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Invalid comparison between Unknown and I4
		if (debugNetworkMessages)
		{
			NetworkLog("Disconnected from network. Cause: " + ((object)(DisconnectCause)(ref OMEKMKICLCM)).ToString());
		}
		Debug.Log((object)("Disconnected from network. Cause: " + ((object)(DisconnectCause)(ref OMEKMKICLCM)).ToString()));
		NOACKKJLLJI.Clear();
		if (GBEPINENNOK == RegionState.RegionPingCheckSuccessful)
		{
			DHHHIACBFAE.FixedRegion = GKNOMAFLFFA;
			PhotonNetwork.ConnectUsingSettings(DHHHIACBFAE, false);
			return;
		}
		if (GBEPINENNOK == RegionState.RegionPingCheckFailed)
		{
			Debug.LogException(new Exception("Region check failed"));
			GBEPINENNOK = RegionState.None;
			return;
		}
		if ((int)OMEKMKICLCM <= 9)
		{
			if (OMEKMKICLCM - 7 > 1)
			{
				if ((int)OMEKMKICLCM != 9)
				{
					goto IL_00b5;
				}
			}
			else
			{
				NetworkErrorMessage(ErrorCode.Timeout);
			}
		}
		else if ((int)OMEKMKICLCM != 17 && (int)OMEKMKICLCM != 20)
		{
			goto IL_00b5;
		}
		goto IL_00bb;
		IL_00bb:
		ICFLMAAFPNO(OMEKMKICLCM);
		Scene sceneByName = SceneManager.GetSceneByName("Gameplay");
		if (((Scene)(ref sceneByName)).isLoaded)
		{
			((MonoBehaviour)this).StartCoroutine(ADGADDLPGEC());
		}
		AHPJAIAFGLD(NetworkState.Offline, IBMNMDDJKLE: true);
		OnDisconnect?.Invoke();
		ResetSingleton();
		return;
		IL_00b5:
		NetworkErrorMessage(ErrorCode.Generic);
		goto IL_00bb;
	}

	public static int NCEICBGNNPM(int JJGBPEADOMD)
	{
		return ((Component)PlayerController.GetPlayer(JJGBPEADOMD)).gameObject.GetComponent<PhotonView>().Controller.ActorNumber;
	}

	public static bool MasterOrOffline()
	{
		if (PlayingOnline())
		{
			return IsMasterClient();
		}
		return true;
	}

	public static bool WaitingForPlayerSpawn()
	{
		return LICCAGGNELA == NetworkState.WaitingForFileSelect;
	}

	private static bool IDOGHHMHNPC()
	{
		return MLCLCIKKFPP != "";
	}

	public static void DAFCCJGPMJL()
	{
		((MonoBehaviourPun)GGFJGHHHEJC).photonView.RPC("BuzzBuildExit", (RpcTarget)4, new object[1] { PhotonNetwork.LocalPlayer.ActorNumber });
	}

	private void LLEAEDMKHFE()
	{
		CHJHAELPJPJ.ResourceCache.Clear();
		foreach (PrefabStringPair pair in onlinePrefabsScriptableObject.pairList)
		{
			if (pair.stringKey == "ReceiveItemContainerColor" || (Object)(object)pair.prefab == (Object)null)
			{
				NetworkLog("LE_14", KDPDNOJAAPK: false, PMDIIFECEOD: true);
			}
			else
			{
				CHJHAELPJPJ.ResourceCache.Add(pair.stringKey, pair.prefab);
			}
		}
		PhotonNetwork.PrefabPool = (IPunPrefabPool)(object)CHJHAELPJPJ;
	}

	public static void NetworkErrorMessage(string LLNAEKJIJNB, float KMPHAEPAFNK = 1f)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		MainUI.ShowErrorText(LLNAEKJIJNB, new Vector2((float)(Screen.width / 2), (float)(Screen.height / 2)), KMPHAEPAFNK);
		NetworkLog(LLNAEKJIJNB, KDPDNOJAAPK: true, PMDIIFECEOD: true, ILMKCLKMACA: true);
	}

	public static bool BLGCACDAEHL(int JIIGOACEIKL)
	{
		if (PlayingOnline() && JIIGOACEIKL != 1)
		{
			return false;
		}
		return false;
	}

	public static bool IsSyncRunning()
	{
		return PhotonNetwork.IsMessageQueueRunning;
	}

	public static void WaitPlayersToBePreparedToContinue(int JIIGOACEIKL, Action GMPOGPAAGDI)
	{
		if (!PlayingOnline() && !GameManager.LocalCoop())
		{
			GMPOGPAAGDI?.Invoke();
			return;
		}
		OKNOJJEFEBE = GMPOGPAAGDI;
		PlayerInputs.DisableKeyboardInputsAndMovement(JIIGOACEIKL, (MonoBehaviour)(object)GGFJGHHHEJC);
		((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(EFHPIEJJPON(JIIGOACEIKL));
		MainUI.CloseAllUIWindows(JIIGOACEIKL);
		if (PlayingOnline())
		{
			OnlinePauseUI.SetMessageVisible(DMBFKFLDDLH: true);
			OnlineBanquetEventManager.instance.SendWaitingForAllPlayersPrepared(Bed.instance.numInstance, GLKAOHGJANI: true, PlayerInfo.HBILFLLKHGP, PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.humanInfo.gender);
		}
		else if (GameManager.LocalCoop())
		{
			AddPlayerPrepared(JIIGOACEIKL, (JIIGOACEIKL == 2) ? PlayerInfo.KGDAOACEMJO : PlayerInfo.HBILFLLKHGP, PlayerController.GetPlayer(JIIGOACEIKL).characterCreator.humanInfo.gender);
		}
	}

	private static void KENLGLNJBHJ()
	{
		if (GBEPINENNOK == RegionState.None)
		{
			ServerSettings.ResetBestRegionCodeInPreferences();
			GBEPINENNOK = RegionState.CheckingRegionPing;
		}
		PhotonNetwork.PhotonServerSettings.AppSettings.CopyTo(DHHHIACBFAE);
		PhotonNetwork.ConnectUsingSettings(DHHHIACBFAE, false);
		GGFJGHHHEJC.OIGCAHMDJEC();
	}

	[SpecialName]
	public static bool AGDOAPBCJLF()
	{
		return _003CFMGAHDPCHMB_003Ek__BackingField;
	}
}
