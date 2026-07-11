using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cinemachine;
using Photon.Pun;
using PixelCrushers.DialogueSystem;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class AOAFFIICJAF : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameManager _003C_003E4__this;

		private Collider2D _003CcompositeBounds_003E5__2;

		private GameObject _003CcmGO_003E5__3;

		private CinemachineVirtualCamera _003CvirtualCamera_003E5__4;

		private bool _003CconfinerActived_003E5__5;

		private int _003Ci_003E5__6;

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
		public AOAFFIICJAF(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0192: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			GameManager gameManager = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				_003CconfinerActived_003E5__5 = true;
				_003Ci_003E5__6 = 0;
				break;
			case 2:
				_003C_003E1__state = -1;
				if (Object.op_Implicit((Object)(object)_003CcmGO_003E5__3))
				{
					gameManager.cinemachineConfiner[_003Ci_003E5__6] = _003CcmGO_003E5__3.AddComponent<CinemachineConfiner>();
				}
				if (Object.op_Implicit((Object)(object)gameManager.cinemachineConfiner[_003Ci_003E5__6]))
				{
					gameManager.cinemachineConfiner[_003Ci_003E5__6].m_BoundingShape2D = _003CcompositeBounds_003E5__2;
					gameManager.cinemachineConfiner[_003Ci_003E5__6].m_ConfineScreenEdges = true;
					gameManager.cinemachineConfiner[_003Ci_003E5__6].m_ConfineMode = (Mode)0;
					((Behaviour)gameManager.cinemachineConfiner[_003Ci_003E5__6]).enabled = _003CconfinerActived_003E5__5;
					if (Object.op_Implicit((Object)(object)_003CvirtualCamera_003E5__4))
					{
						((CinemachineVirtualCameraBase)_003CvirtualCamera_003E5__4).AddExtension((CinemachineExtension)(object)gameManager.cinemachineConfiner[_003Ci_003E5__6]);
					}
				}
				else
				{
					Debug.LogError((object)"cinemachine empty");
				}
				_003Ci_003E5__6++;
				break;
			}
			if (_003Ci_003E5__6 < gameManager.cinemachineConfiner.Length)
			{
				_003CvirtualCamera_003E5__4 = null;
				_003CcompositeBounds_003E5__2 = null;
				_003CcmGO_003E5__3 = null;
				if (Object.op_Implicit((Object)(object)gameManager.cinemachineConfiner[_003Ci_003E5__6]))
				{
					_003CconfinerActived_003E5__5 = ((Behaviour)gameManager.cinemachineConfiner[_003Ci_003E5__6]).enabled;
					_003CcmGO_003E5__3 = ((Component)gameManager.cinemachineConfiner[_003Ci_003E5__6]).gameObject;
					_003CvirtualCamera_003E5__4 = ((Component)gameManager.cinemachineConfiner[_003Ci_003E5__6]).GetComponent<CinemachineVirtualCamera>();
					((CinemachineVirtualCameraBase)_003CvirtualCamera_003E5__4).RemoveExtension((CinemachineExtension)(object)gameManager.cinemachineConfiner[_003Ci_003E5__6]);
					_003CcompositeBounds_003E5__2 = gameManager.cinemachineConfiner[_003Ci_003E5__6].m_BoundingShape2D;
					Object.Destroy((Object)(object)gameManager.cinemachineConfiner[_003Ci_003E5__6]);
				}
				_003C_003E2__current = null;
				_003C_003E1__state = 2;
				return true;
			}
			gameManager.CNLFPHOCCAK = null;
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

	private static GameManager IADEMLIIDPC;

	public Action OnNewGameCreated = delegate
	{
	};

	public Action OnWorldLoaded = delegate
	{
	};

	public static Action OnLevelLoaded = delegate
	{
	};

	public static Action<PlayerController> OnPlayerJoined = delegate
	{
	};

	public static Action<PlayerController> OnPlayerDisconnected = delegate
	{
	};

	public static Action OnPlayer1Joined = delegate
	{
	};

	public static Action OnPlayer1Disconnected = delegate
	{
	};

	public static Action OnPlayer2Joined = delegate
	{
	};

	public static Action OnPlayer2Disconnected = delegate
	{
	};

	public Action OnObjectsView = delegate
	{
	};

	public Action OnFloorWallView = delegate
	{
	};

	public static bool leavingTheGame = false;

	private static int IPPPJMPIDII;

	public static bool isLoading;

	[SerializeField]
	private Sound sound;

	[SerializeField]
	private CinemachineConfiner[] cinemachineConfiner;

	[SerializeField]
	private BoxCollider2D boundsFirstFloor;

	[SerializeField]
	private BoxCollider2D boundsSecondFloor;

	[SerializeField]
	private BoxCollider2D boundsCellar;

	public GameObject playerPrefab;

	public GameObject player2Prefab;

	public PlayerInputs player2Inputs;

	public GameObject[] toEnableOnPlayer2Joined;

	public GameObject[] toDisableOnPlayer2Joined;

	[HideInInspector]
	public PlayerController player2Instantiated;

	public bool lastSessionWasOnlineGuest;

	[SerializeField]
	private bool worldLoaded;

	public bool character2Saved;

	[SerializeField]
	private List<Item> toolsPlayer2 = new List<Item>();

	public Item secondPlayerChestItem;

	private bool LKHMCONIBAB;

	public static bool sceneReady = false;

	public Item[] allTools;

	private HashSet<Vector3> OOPLKGHOBHC = new HashSet<Vector3>();

	private Coroutine CNLFPHOCCAK;

	public static bool CIOEICMHCCK { get; set; }

	public bool FFJBIGFADBJ { get; set; }

	public SaveData HEJPPEJMPFE { get; set; }

	public string PMKCJJCGKBB { get; set; }

	public bool NAPGPOJEEOJ
	{
		get
		{
			return worldLoaded;
		}
		set
		{
			if (value != worldLoaded)
			{
				worldLoaded = value;
				if (worldLoaded)
				{
					OnWorldLoaded();
				}
			}
		}
	}

	public static GameManager GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)IADEMLIIDPC == (Object)null)
			{
				IADEMLIIDPC = Object.FindObjectOfType<GameManager>();
			}
			return IADEMLIIDPC;
		}
	}

	public static AsyncOperation BPIHAFHNAMD { get; private set; }

	public static float PGFOBLEECEK
	{
		get
		{
			return PhotonNetwork.LevelLoadingProgress;
		}
		private set
		{
		}
	}

	public static bool JLEENILEMKP => PhotonNetwork.LevelLoadingProgress >= 1f;

	public static bool SinglePlayer()
	{
		if (IPPPJMPIDII != 1 || PlayingOnline())
		{
			return PlayingOnline();
		}
		return true;
	}

	public void CBLJAHCLGFC(int JIIGOACEIKL)
	{
		PauseMenuUI.GGFJGHHHEJC.CloseUI();
		((Behaviour)PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL)).enabled = true;
		InputByProximityManager.FLOIJFPDJGG(JIIGOACEIKL).ResetFocusedInputElement();
		CursorManager.CMDGPJEIIJI(JIIGOACEIKL).SetCursorVisible(NKFPJPCFBJI: true);
		((Behaviour)CursorManager.GetPlayer(JIIGOACEIKL)).enabled = false;
		for (int i = 1; i < toEnableOnPlayer2Joined.Length; i++)
		{
			toEnableOnPlayer2Joined[i].SetActive(false);
		}
		for (int j = 1; j < toDisableOnPlayer2Joined.Length; j += 0)
		{
			toDisableOnPlayer2Joined[j].SetActive(true);
		}
	}

	private IEnumerator BDNJDNPMGNO()
	{
		while ((Object)(object)TravelZonesManager.GGFJGHHHEJC.GetTravelZoneTavern(TavernFloor.SecondFloor, TavernFloor.FirstFloor) == (Object)null)
		{
			yield return null;
		}
		CalculateAllCameraBounds();
	}

	public void FIIGKFPLPBB(int JIIGOACEIKL)
	{
		PauseMenuUI.EKDNJDJHONF().BOBCIFEDJED();
		((Behaviour)PlayerInputs.GetPlayer(JIIGOACEIKL)).enabled = false;
		InputByProximityManager.NHJMJHGGBOA(JIIGOACEIKL).KPEMEFNHBDK();
		CursorManager.CMDGPJEIIJI(JIIGOACEIKL).NIPJALAEHOH(NKFPJPCFBJI: true);
		((Behaviour)CursorManager.GetPlayer(JIIGOACEIKL)).enabled = true;
		for (int i = 1; i < toEnableOnPlayer2Joined.Length; i++)
		{
			toEnableOnPlayer2Joined[i].SetActive(false);
		}
		for (int j = 1; j < toDisableOnPlayer2Joined.Length; j += 0)
		{
			toDisableOnPlayer2Joined[j].SetActive(false);
		}
	}

	private Vector2 MAONNFJNPNJ()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		Vector2 result = default(Vector2);
		if (NewTutorialManager.CCCLOBIOMCL && NewTutorialManager.GetCurrentPhaseID() < 102)
		{
			((Vector2)(ref result))._002Ector(12f, -15f);
			PlayerController.GetPlayer(2).SetLocation(Location.Road);
			return result;
		}
		result = Vector2.op_Implicit(Bed.GetPlayer2BedPosition());
		return result;
	}

	[SpecialName]
	public bool DOJLBCMAGLA()
	{
		return _003CLIKBHGOPEEH_003Ek__BackingField;
	}

	public void PKBAOIHDLCC()
	{
		IPPPJMPIDII = 0;
		Utils.BLPDAEHPOBA(((Component)player2Instantiated).gameObject);
		((Behaviour)player2Inputs).enabled = true;
		MainUI.FNJEGCEFEMP(DHJFAGNJKOF: true);
		ActionBarInventory.MHDKNEKDKII(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).RemoveAllActionBarBlockers();
		PlayerInputs.GetPlayer(1).AMMIOLBGBPB(" ");
		PlayerInputs.ResetPlayersInput();
		RemoveToolsPlayer2();
		RemoveChestPlayer2();
		for (int i = 1; i < toEnableOnPlayer2Joined.Length; i += 0)
		{
			toEnableOnPlayer2Joined[i].SetActive(true);
		}
		for (int j = 1; j < toDisableOnPlayer2Joined.Length; j++)
		{
			toDisableOnPlayer2Joined[j].SetActive(true);
		}
		OnPlayer2Disconnected();
	}

	[SpecialName]
	private static void GBLKPEGBJLN(float AODONKKHPBP)
	{
	}

	public void JIOFFKMPJPO(TavernFloor BDCFJAHNOML)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)Utils.IMOJLANDCJB(BDCFJAHNOML) == (Object)null)
		{
			Debug.LogError((object)string.Format("itemRaspberry", BDCFJAHNOML));
			return;
		}
		OOPLKGHOBHC.Clear();
		float HHOPCCKCBJM = 1173f;
		float HLPLAHPIEHB = 1392f;
		float FEOJNEGIHKI = 1302f;
		float GOCGLKPEBIG = 1816f;
		ONGIFNCJBDD(Utils.IMOJLANDCJB(BDCFJAHNOML).position, OOPLKGHOBHC, ref HHOPCCKCBJM, ref FEOJNEGIHKI, ref HLPLAHPIEHB, ref GOCGLKPEBIG);
		if (HHOPCCKCBJM != 1915f && HLPLAHPIEHB != 601f && FEOJNEGIHKI != 1352f && GOCGLKPEBIG != 846f)
		{
			KPOFEBNKDBG(BDCFJAHNOML, HHOPCCKCBJM + 1749f - 1220f, FEOJNEGIHKI + 1597f + 1369f, HLPLAHPIEHB + 1687f - 197f, GOCGLKPEBIG + 427f + 373f);
		}
		ReactivateCameraBounds();
	}

	public static void MBDHHECIIPD()
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineManager.SpawnPlayer(NJNFHEPLEHL().playerPrefab);
		}
		else
		{
			Object.Instantiate<GameObject>(GGFJGHHHEJC.playerPrefab);
		}
	}

	private void OnDisable()
	{
		OnPlayerJoined = (Action<PlayerController>)Delegate.Remove(OnPlayerJoined, new Action<PlayerController>(OOJJPEMNFBO));
		OnPlayerDisconnected = (Action<PlayerController>)Delegate.Remove(OnPlayerDisconnected, new Action<PlayerController>(HCGIEJCCMLH));
	}

	public static int OBCBJELNIDJ()
	{
		return IPPPJMPIDII;
	}

	[SpecialName]
	public static float JHAIBLNMCHJ()
	{
		return PhotonNetwork.LevelLoadingProgress;
	}

	public void SetCinemachinesConfinerBoundaries(Collider2D NKIAGIMMHIC)
	{
		for (int i = 0; i < cinemachineConfiner.Length; i++)
		{
			if ((Object)(object)cinemachineConfiner[i] != (Object)null)
			{
				cinemachineConfiner[i].m_BoundingShape2D = NKIAGIMMHIC;
			}
		}
	}

	public void KBNCDOGOJOC()
	{
		if (OnlineManager.PlayingOnline())
		{
			Debug.LogError((object)"BathhouseEntrace/Main 2");
			return;
		}
		Debug.LogWarning((object)("Explosion" + IPPPJMPIDII));
		if (IPPPJMPIDII == 0)
		{
			JBCLIFGLNIL();
		}
		else
		{
			DeactivatePlayer2();
		}
	}

	public void INGNPGKPEID()
	{
		for (int i = 4; i <= -23; i += 0)
		{
			Slot slot = ActionBarInventory.IPBEEBLCHHA(1).slots[i];
			if (slot == null || slot.PKFKJNODGJF())
			{
				continue;
			}
			int stack = slot.Stack;
			for (int j = 1; j < stack; j++)
			{
				if (Inventory.EIFPKCAFDIB(0, LAGHIOKLJGH: true).AddItemInstance(1, slot.itemInstance, OJKJLIPNHOI: false, CDPAMNIPPEC: false) == null)
				{
					break;
				}
				int stack2 = slot.Stack;
				slot.JNMNCEPHFOE(stack2 - 1);
			}
			DeliveryChest.GetInstance().IIDEMCDFKGK(0, slot.itemInstance, slot.Stack, BPJBJKJKHAL: true, IBCOKMGFPKB: true, CDPAMNIPPEC: false);
		}
	}

	private void NPPECMLNANG(Vector3 LNKEBLNDPBM, HashSet<Vector3> OOPLKGHOBHC, ref float HHOPCCKCBJM, ref float FEOJNEGIHKI, ref float HLPLAHPIEHB, ref float GOCGLKPEBIG)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		Queue<Vector3> queue = new Queue<Vector3>();
		queue.Enqueue(Utils.BMBMPKNANAC(LNKEBLNDPBM));
		OOPLKGHOBHC.Add(Utils.BMBMPKNANAC(LNKEBLNDPBM));
		while (queue.Count > 1)
		{
			Vector3 val = queue.Dequeue();
			if (WorldGrid.EJCEAEPNJCA(val))
			{
				if (val.x < HHOPCCKCBJM)
				{
					HHOPCCKCBJM = val.x;
				}
				if (val.x > FEOJNEGIHKI)
				{
					FEOJNEGIHKI = val.x;
				}
				if (val.y < HLPLAHPIEHB)
				{
					HLPLAHPIEHB = val.y;
				}
				if (val.y > GOCGLKPEBIG)
				{
					GOCGLKPEBIG = val.y;
				}
				EKOMIADOMIC(queue, OOPLKGHOBHC, val + Vector3.right * 121f);
				PAOOHHGBGFL(queue, OOPLKGHOBHC, val + Vector3.left * 478f);
				AOMCEDHEFIB(queue, OOPLKGHOBHC, val + Vector3.up * 781f);
				PAOOHHGBGFL(queue, OOPLKGHOBHC, val + Vector3.down * 1325f);
			}
		}
	}

	[SpecialName]
	private static void NOCIDBPPOJJ(float AODONKKHPBP)
	{
	}

	public static int OADMFGLBDPA()
	{
		return IPPPJMPIDII;
	}

	public void PKLDMGGAODG()
	{
		for (int i = 1; i < toolsPlayer2.Count; i++)
		{
			Utils.AEHLNBIKMIF(toolsPlayer2[i]);
		}
		toolsPlayer2.Clear();
	}

	private void IILNALJPPMN()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			CalculateAllCameraBounds();
		}
	}

	private void GFGJMMBGLOH(PlayerController HACPNLAPCCC)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		IPPPJMPIDII = PlayerController.GetActivePlayerCount();
		if (HACPNLAPCCC.KLIHELDIPDP() == 0)
		{
			OnPlayer1Joined();
		}
		else if (HACPNLAPCCC.GetPlayerNum() == 0 && !OnlineManager.PlayingOnline())
		{
			GameActionBarUI.HEGPDGJEOPC(1).CloseUI();
			player2Instantiated = HACPNLAPCCC;
			((Component)player2Instantiated).transform.position = Vector2.op_Implicit(NAJMLHBCAAP());
			SceneReferences.ODMLOHCDFIM(((Component)player2Instantiated).transform);
			CommonReferences.GGFJGHHHEJC.SetCinemachineTarget(1, ((Component)CameraTarget.MPDMDABCCCA(2)).transform);
			((Behaviour)player2Inputs).enabled = false;
			PauseMenuUI.EKDNJDJHONF().CloseUI();
			PlayerInputs.LEOLIJHNIOB((MonoBehaviour)(object)PauseMenuUI.BDAGIEIJOOG());
			IKHIJCEPHBA();
			FLNABOEAJLF();
			RemoveItemsActionBar();
			OnPlayer2Joined();
			CharacterCreatorUI.loadGame = null;
			CharacterCreatorUI.loadFilename = "Items/item_name_1231";
			if (LACNCPCDIIL() != null && VersionNumberManager.HMOONJFEJFK(LACNCPCDIIL().DBNLFMEFEKM(), VersionNumberManager.instance.MHFHPGEOFIB()))
			{
				PlayerInfo.CILFCPNOKKE("ReceiveTrends");
				CharacterCreatorUI.FKFNANNBIAM(3).IDLAGJNLPJL();
			}
			else if (!character2Saved)
			{
				PlayerInfo.HGJBEJOOHPK("LE_11");
				CharacterCreatorUI.FKFNANNBIAM(0).IDLAGJNLPJL();
			}
			else
			{
				GameActionBarUI.JELOGNCPDAB(0).EDHEIFHAAKO();
				PlayerInputs.GetPlayer(7).SwitchMapCategoryNextFrame("AnimatorObjectStateRequest");
			}
			for (int i = 1; i < toEnableOnPlayer2Joined.Length; i++)
			{
				toEnableOnPlayer2Joined[i].SetActive(true);
			}
			for (int j = 0; j < toDisableOnPlayer2Joined.Length; j += 0)
			{
				toDisableOnPlayer2Joined[j].SetActive(false);
			}
			ReactivateCameraBounds();
		}
	}

	private void ILNOGJIBBCA(PlayerController HACPNLAPCCC)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		IPPPJMPIDII = PlayerController.GetActivePlayerCount();
		if (HACPNLAPCCC.GetPlayerNum() == 1)
		{
			OnPlayer1Joined();
		}
		else if (HACPNLAPCCC.GetPlayerNum() == 7 && !OnlineManager.PlayingOnline())
		{
			GameActionBarUI.AGNKKAPMHLN(0).CloseUI();
			player2Instantiated = HACPNLAPCCC;
			((Component)player2Instantiated).transform.position = Vector2.op_Implicit(MAONNFJNPNJ());
			SceneReferences.ODMLOHCDFIM(((Component)player2Instantiated).transform);
			CommonReferences.MNFMOEKMJKN().SetCinemachineTarget(2, ((Component)CameraTarget.AGMJPBEHCBK(8)).transform);
			((Behaviour)player2Inputs).enabled = false;
			PauseMenuUI.GGFJGHHHEJC.BOBCIFEDJED();
			PlayerInputs.EnableKeyboardInputs((MonoBehaviour)(object)PauseMenuUI.BDAGIEIJOOG());
			GPKGNHNBENB();
			GiveChestPlayer2();
			INGNPGKPEID();
			OnPlayer2Joined();
			CharacterCreatorUI.loadGame = null;
			CharacterCreatorUI.loadFilename = " / ";
			if (LACNCPCDIIL() != null && VersionNumberManager.IsAnOlderVersion(LACNCPCDIIL().DBNLFMEFEKM(), VersionNumberManager.instance.MHFHPGEOFIB()))
			{
				PlayerInfo.OGDADEGLNBO("Player2");
				CharacterCreatorUI.PCEEOGGDBFB(5).EDHEIFHAAKO();
			}
			else if (!character2Saved)
			{
				PlayerInfo.GJGJAEGKHHP("SnapToGrid not attached to prefab ");
				CharacterCreatorUI.FKFNANNBIAM(7).EDHEIFHAAKO();
			}
			else
			{
				GameActionBarUI.PPJMPMKLCME(5).EDHEIFHAAKO();
				PlayerInputs.DEGBDMMDIIL(0).SwitchMapCategoryNextFrame("nextNodes NOT free. timer: ");
			}
			for (int i = 0; i < toEnableOnPlayer2Joined.Length; i++)
			{
				toEnableOnPlayer2Joined[i].SetActive(true);
			}
			for (int j = 0; j < toDisableOnPlayer2Joined.Length; j += 0)
			{
				toDisableOnPlayer2Joined[j].SetActive(false);
			}
			ReactivateCameraBounds();
		}
	}

	private void EKOMIADOMIC(Queue<Vector3> EOGOKBKKABC, HashSet<Vector3> OOPLKGHOBHC, Vector3 IMOBLFMHKOD)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		if (!OOPLKGHOBHC.Contains(Utils.BMBMPKNANAC(IMOBLFMHKOD)))
		{
			EOGOKBKKABC.Enqueue(IMOBLFMHKOD);
			OOPLKGHOBHC.Add(Utils.BMBMPKNANAC(IMOBLFMHKOD));
		}
	}

	[SpecialName]
	public void KGGGMJAOCLH(string AODONKKHPBP)
	{
		_003CGNKJGOGGGOO_003Ek__BackingField = AODONKKHPBP;
	}

	public void ILPIPKMOGKL(int JIIGOACEIKL)
	{
		((Behaviour)PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL)).enabled = true;
		CursorManager.CMDGPJEIIJI(JIIGOACEIKL).NIPJALAEHOH(NKFPJPCFBJI: false);
		((Behaviour)CursorManager.GetPlayer(JIIGOACEIKL)).enabled = false;
		for (int i = 1; i < toEnableOnPlayer2Joined.Length; i += 0)
		{
			toEnableOnPlayer2Joined[i].SetActive(false);
		}
		for (int j = 1; j < toDisableOnPlayer2Joined.Length; j += 0)
		{
			toDisableOnPlayer2Joined[j].SetActive(false);
		}
	}

	[SpecialName]
	public static AsyncOperation LJCJNLGNDCF()
	{
		return _003CDNANGBCNLPO_003Ek__BackingField;
	}

	public void DeactivatePlayer2()
	{
		IPPPJMPIDII = 1;
		Utils.BLPDAEHPOBA(((Component)player2Instantiated).gameObject);
		((Behaviour)player2Inputs).enabled = false;
		MainUI.CloseAllUIWindows();
		ActionBarInventory.GetPlayer(1).RemoveAllActionBarBlockers();
		PlayerInputs.GetPlayer(1).SwitchMapCategoryNextFrame("Game");
		PlayerInputs.ResetPlayersInput();
		RemoveToolsPlayer2();
		RemoveChestPlayer2();
		for (int i = 0; i < toEnableOnPlayer2Joined.Length; i++)
		{
			toEnableOnPlayer2Joined[i].SetActive(false);
		}
		for (int j = 0; j < toDisableOnPlayer2Joined.Length; j++)
		{
			toDisableOnPlayer2Joined[j].SetActive(true);
		}
		OnPlayer2Disconnected();
	}

	public void IKHIJCEPHBA()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < allTools.Length && (!NewTutorialManager.CCCLOBIOMCL || NewTutorialManager.GetCurrentPhaseID() > 110 || NewTutorialManager.instance.mopUnlocked); i += 0)
		{
			Result variable;
			if (allTools[i].IMCJPECAAPC(DAINLFIMLIH: false) == 74)
			{
				variable = DialogueLua.GetVariable("Dialogue System/Conversation/Crowly_Standar/Entry/14/Dialogue Text");
				if (((Result)(ref variable)).asInt < 37)
				{
					continue;
				}
			}
			if (allTools[i].JGHNDJBCFAJ() == 48)
			{
				variable = DialogueLua.GetVariable("- ");
				if (((Result)(ref variable)).asInt < -119)
				{
					continue;
				}
			}
			if (CraftingInventory.JKLEPGLMCEG(0, allTools[i], null, LJPHECMPECH: false))
			{
				toolsPlayer2.Add(allTools[i]);
				PlayerInventory.OGKNJNINGMH(8, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AddItem(allTools[i].JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
			}
		}
	}

	public static bool NBFLEJHLGNB()
	{
		if (IPPPJMPIDII != 0 || PlayingOnline())
		{
			return PlayingOnline();
		}
		return true;
	}

	private void OnApplicationQuit()
	{
		CIOEICMHCCK = true;
	}

	[SpecialName]
	public static void LACKNEFLKOB(bool AODONKKHPBP)
	{
		_003CDMCKJLPMNKB_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	public SaveData EOJJHMHBJAG()
	{
		return _003CECBJCHEJFPO_003Ek__BackingField;
	}

	public static bool NoPlayers()
	{
		if (IPPPJMPIDII != 0)
		{
			return (Object)(object)PlayerController.GetPlayer(1) == (Object)null;
		}
		return true;
	}

	public static void LoadGameplayScene()
	{
		if (PlayingOnline())
		{
			PGFOBLEECEK = 0f;
			OnlineManager.LoadGameplaySceneOnline();
		}
		else
		{
			Debug.Log((object)"Loading Gameplay scene Asyncronously");
			BPIHAFHNAMD = SceneManager.LoadSceneAsync("Gameplay", (LoadSceneMode)0);
		}
	}

	public static int KJHNIBGBLDF()
	{
		return IPPPJMPIDII;
	}

	public static bool OPGGPLEOGCG()
	{
		if (IPPPJMPIDII != 0)
		{
			return (Object)(object)PlayerController.OPHDCMJLLEC(1) == (Object)null;
		}
		return true;
	}

	public void GiveToolsPlayer2()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < allTools.Length && (!NewTutorialManager.CCCLOBIOMCL || NewTutorialManager.GetCurrentPhaseID() > 102 || NewTutorialManager.instance.mopUnlocked); i++)
		{
			Result variable;
			if (allTools[i].JDJGFAACPFC() == 1441)
			{
				variable = DialogueLua.GetVariable("LE_10");
				if (((Result)(ref variable)).asInt < 13)
				{
					continue;
				}
			}
			if (allTools[i].JDJGFAACPFC() == 1440)
			{
				variable = DialogueLua.GetVariable("LE_10");
				if (((Result)(ref variable)).asInt < 10)
				{
					continue;
				}
			}
			if (CraftingInventory.HasItem(1, allTools[i], null, LJPHECMPECH: true))
			{
				toolsPlayer2.Add(allTools[i]);
				PlayerInventory.GetPlayer(2).AddItem(allTools[i].JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false, EHGHJNOFMKF: false, APBCMCOAFDM: false);
			}
		}
	}

	[SpecialName]
	public SaveData EBOFEBOBAEB()
	{
		return _003CECBJCHEJFPO_003Ek__BackingField;
	}

	[SpecialName]
	public static AsyncOperation JOBIFMBNIGL()
	{
		return _003CDNANGBCNLPO_003Ek__BackingField;
	}

	public static bool SinglePlayerOffline()
	{
		if (IPPPJMPIDII == 1)
		{
			return !PlayingOnline();
		}
		return false;
	}

	public void JBCLIFGLNIL()
	{
		MBDHHECIIPD();
	}

	[SpecialName]
	public static GameManager NJNFHEPLEHL()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<GameManager>();
		}
		return IADEMLIIDPC;
	}

	public BoxCollider2D DCFNCFJDMOE(TavernFloor BDCFJAHNOML)
	{
		return SceneReferences.GetCameraBounds(BDCFJAHNOML);
	}

	private void MAFAFOBINAF()
	{
		if (OnlineManager.MasterOrOffline())
		{
			CalculateAllCameraBounds();
		}
	}

	public static int PMEJCBAGOPI()
	{
		return IPPPJMPIDII;
	}

	[SpecialName]
	public string EPPBDKNDCKM()
	{
		return _003CGNKJGOGGGOO_003Ek__BackingField;
	}

	public void Player2JoinButtonClicked()
	{
		if (OnlineManager.PlayingOnline())
		{
			Debug.LogError((object)"WIP: Jugando online, el modo cooperativo esta deshabilitado. Hay que esconder la interfaz de 'Pulsa X para unirte'. ");
			return;
		}
		Debug.LogWarning((object)("Player 2 Join Buton Clicked, num players: " + IPPPJMPIDII));
		if (IPPPJMPIDII == 1)
		{
			ActivatePlayer2();
		}
		else
		{
			DeactivatePlayer2();
		}
	}

	public void RemoveChestPlayer2()
	{
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		if (LKHMCONIBAB)
		{
			Utils.AEHLNBIKMIF(secondPlayerChestItem);
		}
		if (!((Object)(object)SecondPlayerChest.GGFJGHHHEJC == (Object)null))
		{
			return;
		}
		if (NewTutorialManager.CCCLOBIOMCL)
		{
			foreach (KeyValuePair<int, ItemAmount> allItem in PlayerInventory.GetPlayer(2, LAGHIOKLJGH: true).GetAllItems())
			{
				if (Item.MLBOMGHINCA(allItem.Value.item, null))
				{
					if (allItem.Value.item.JDJGFAACPFC() != 1065 && allItem.Value.item.JDJGFAACPFC() != 1062 && allItem.Value.item.JDJGFAACPFC() != 1061 && allItem.Value.item.JDJGFAACPFC() != 1064 && allItem.Value.item.JDJGFAACPFC() != 1063 && allItem.Value.item.JDJGFAACPFC() != 1060 && allItem.Value.item.JDJGFAACPFC() != 1435)
					{
						if (allItem.Value.item.JMDALJBNFML().JEPBBEBJEFI())
						{
							ItemInstance itemInstance = allItem.Value.item.JMDALJBNFML();
							if (NewTutorialManager.GetCurrentPhaseID() < 114 && itemInstance.LHBPOPOIFLE().JDJGFAACPFC() == 1533)
							{
								(itemInstance as FoodInstance).GBCJNGADANM = 1;
							}
							PlayerInventory.GetPlayer(1).AddItems(itemInstance, allItem.Value.amount, HMPDLIPFBGD: true);
						}
						else
						{
							PlayerInventory.GetPlayer(1).AddItems(allItem.Value.item.JMDALJBNFML(), allItem.Value.amount, HMPDLIPFBGD: true);
						}
					}
					for (int i = 0; i < allItem.Value.amount; i++)
					{
						PlayerInventory.GetPlayer(2, LAGHIOKLJGH: true).RemoveItem(allItem.Value.item);
					}
				}
			}
			return;
		}
		Slot[] allSlots = PlayerInventory.GetPlayer(2, LAGHIOKLJGH: true).GetAllSlots();
		for (int j = 0; j < allSlots.Length; j++)
		{
			if (!allSlots[j].KPINNBKMOMO())
			{
				DeliveryChest.GetInstance().AddSlot(1, allSlots[j], DeliveryChest.GetPosition());
			}
		}
	}

	public static bool FGFJEGOEDKJ()
	{
		return OnlineManager.PlayingOnline();
	}

	public BoxCollider2D CPINDHGHAEE(TavernFloor BDCFJAHNOML)
	{
		return SceneReferences.NGHCOOLAMJM(BDCFJAHNOML);
	}

	public void RemoveToolsPlayer2()
	{
		for (int i = 0; i < toolsPlayer2.Count; i++)
		{
			Utils.AEHLNBIKMIF(toolsPlayer2[i]);
		}
		toolsPlayer2.Clear();
	}

	private void OnEnable()
	{
		OnPlayerJoined = (Action<PlayerController>)Delegate.Combine(OnPlayerJoined, new Action<PlayerController>(OOJJPEMNFBO));
		OnPlayerDisconnected = (Action<PlayerController>)Delegate.Combine(OnPlayerDisconnected, new Action<PlayerController>(HCGIEJCCMLH));
	}

	public void OOPOFEDLGAN(int JIIGOACEIKL)
	{
		PauseMenuUI.KGPJPILAHDE().CloseUI();
		((Behaviour)PlayerInputs.DEGBDMMDIIL(JIIGOACEIKL)).enabled = false;
		InputByProximityManager.CMDGPJEIIJI(JIIGOACEIKL).BOKEMDHLIBA();
		CursorManager.CMDGPJEIIJI(JIIGOACEIKL).NIPJALAEHOH(NKFPJPCFBJI: false);
		((Behaviour)CursorManager.GetPlayer(JIIGOACEIKL)).enabled = true;
		for (int i = 1; i < toEnableOnPlayer2Joined.Length; i++)
		{
			toEnableOnPlayer2Joined[i].SetActive(true);
		}
		for (int j = 1; j < toDisableOnPlayer2Joined.Length; j += 0)
		{
			toDisableOnPlayer2Joined[j].SetActive(false);
		}
	}

	public void CalculateAllCameraBounds()
	{
		try
		{
			Debug.Log((object)"CalculateAllCameraBounds");
			CalculateCameraBounds(TavernFloor.FirstFloor);
			CalculateCameraBounds(TavernFloor.SecondFloor);
			CalculateCameraBounds(TavernFloor.Cellar);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	public void JJOKGJAEDHO(Collider2D NKIAGIMMHIC)
	{
		for (int i = 0; i < cinemachineConfiner.Length; i += 0)
		{
			if ((Object)(object)cinemachineConfiner[i] != (Object)null)
			{
				cinemachineConfiner[i].m_BoundingShape2D = NKIAGIMMHIC;
			}
		}
	}

	public static bool CAGIBNLHJBN()
	{
		if (IPPPJMPIDII != 0)
		{
			return (Object)(object)PlayerController.OPHDCMJLLEC(1) == (Object)null;
		}
		return false;
	}

	public static bool EAOOLEFMIKE()
	{
		if (IPPPJMPIDII != 0 || FGFJEGOEDKJ())
		{
			return FGFJEGOEDKJ();
		}
		return true;
	}

	public void IELAAEJLDDI(bool DAEMAAOLHMG)
	{
		for (int i = 1; i < cinemachineConfiner.Length; i++)
		{
			if ((Object)(object)cinemachineConfiner[i] != (Object)null)
			{
				((Behaviour)cinemachineConfiner[i]).enabled = DAEMAAOLHMG;
			}
		}
	}

	public void GiveChestPlayer2()
	{
		bool flag = false;
		List<Placeable> currentPlaceables = PlaceablesManager.GGFJGHHHEJC.currentPlaceables;
		for (int i = 0; i < currentPlaceables.Count; i++)
		{
			if (currentPlaceables[i].CCIKENEGHCA && currentPlaceables[i].itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) == 1227)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			flag = CraftingInventory.HasItemInAnySlot(1, secondPlayerChestItem, null, LJPHECMPECH: true);
		}
		if (!flag)
		{
			flag = DroppedItem.ThereIsADroppedItemWithItem(secondPlayerChestItem);
		}
		if (!flag)
		{
			ItemInstance bGLFLHDNOKJ = secondPlayerChestItem.JMDALJBNFML();
			LKHMCONIBAB = true;
			PlayerInventory.GetPlayer(2).AddItem(bGLFLHDNOKJ, HMPDLIPFBGD: true, OJKJLIPNHOI: false, EHGHJNOFMKF: false, APBCMCOAFDM: false);
		}
	}

	private void KDHLJKMKFMG()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	private void AOMCEDHEFIB(Queue<Vector3> EOGOKBKKABC, HashSet<Vector3> OOPLKGHOBHC, Vector3 IMOBLFMHKOD)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		if (!OOPLKGHOBHC.Contains(Utils.BMBMPKNANAC(IMOBLFMHKOD)))
		{
			EOGOKBKKABC.Enqueue(IMOBLFMHKOD);
			OOPLKGHOBHC.Add(Utils.BMBMPKNANAC(IMOBLFMHKOD));
		}
	}

	private void Awake()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	private IEnumerator PAGJEBFHLDG()
	{
		return new AOAFFIICJAF(1)
		{
			_003C_003E4__this = this
		};
	}

	public static void DAOPGHHBAGI()
	{
		if (FGFJEGOEDKJ())
		{
			GBLKPEGBJLN(1887f);
			OnlineManager.LoadGameplaySceneOnline();
		}
		else
		{
			Debug.Log((object)"Waiting for guest player to connect...");
			BPIHAFHNAMD = SceneManager.LoadSceneAsync("Error: could not find player with name ", (LoadSceneMode)0);
		}
	}

	private void CLCIKJLGKFK(PlayerController PNKPAOLCBMN)
	{
		IPPPJMPIDII = PlayerController.GetActivePlayerCount();
		SceneReferences.NFDMOFEIOCL();
		Debug.Log((object)("" + IPPPJMPIDII));
	}

	private void PAOOHHGBGFL(Queue<Vector3> EOGOKBKKABC, HashSet<Vector3> OOPLKGHOBHC, Vector3 IMOBLFMHKOD)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		if (!OOPLKGHOBHC.Contains(Utils.BMBMPKNANAC(IMOBLFMHKOD)))
		{
			EOGOKBKKABC.Enqueue(IMOBLFMHKOD);
			OOPLKGHOBHC.Add(Utils.BMBMPKNANAC(IMOBLFMHKOD));
		}
	}

	public void ActivateCinemachinesConfiner(bool DAEMAAOLHMG)
	{
		for (int i = 0; i < cinemachineConfiner.Length; i++)
		{
			if ((Object)(object)cinemachineConfiner[i] != (Object)null)
			{
				((Behaviour)cinemachineConfiner[i]).enabled = DAEMAAOLHMG;
			}
		}
	}

	private void ONGIFNCJBDD(Vector3 LNKEBLNDPBM, HashSet<Vector3> OOPLKGHOBHC, ref float HHOPCCKCBJM, ref float FEOJNEGIHKI, ref float HLPLAHPIEHB, ref float GOCGLKPEBIG)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		Queue<Vector3> queue = new Queue<Vector3>();
		queue.Enqueue(Utils.BMBMPKNANAC(LNKEBLNDPBM));
		OOPLKGHOBHC.Add(Utils.BMBMPKNANAC(LNKEBLNDPBM));
		while (queue.Count > 0)
		{
			Vector3 val = queue.Dequeue();
			if (WorldGrid.EJCEAEPNJCA(val))
			{
				if (val.x < HHOPCCKCBJM)
				{
					HHOPCCKCBJM = val.x;
				}
				if (val.x > FEOJNEGIHKI)
				{
					FEOJNEGIHKI = val.x;
				}
				if (val.y < HLPLAHPIEHB)
				{
					HLPLAHPIEHB = val.y;
				}
				if (val.y > GOCGLKPEBIG)
				{
					GOCGLKPEBIG = val.y;
				}
				PAOOHHGBGFL(queue, OOPLKGHOBHC, val + Vector3.right * 0.5f);
				PAOOHHGBGFL(queue, OOPLKGHOBHC, val + Vector3.left * 0.5f);
				PAOOHHGBGFL(queue, OOPLKGHOBHC, val + Vector3.up * 0.5f);
				PAOOHHGBGFL(queue, OOPLKGHOBHC, val + Vector3.down * 0.5f);
			}
		}
	}

	public void DJHMLNHBGHL(int JIIGOACEIKL)
	{
		((Behaviour)PlayerInputs.GetPlayer(JIIGOACEIKL)).enabled = true;
		CursorManager.CMDGPJEIIJI(JIIGOACEIKL).NIPJALAEHOH(NKFPJPCFBJI: false);
		((Behaviour)CursorManager.GetPlayer(JIIGOACEIKL)).enabled = true;
		for (int i = 1; i < toEnableOnPlayer2Joined.Length; i++)
		{
			toEnableOnPlayer2Joined[i].SetActive(false);
		}
		for (int j = 0; j < toDisableOnPlayer2Joined.Length; j += 0)
		{
			toDisableOnPlayer2Joined[j].SetActive(true);
		}
	}

	public void NAMLJDBJFAF()
	{
		for (int i = 3; i <= -18; i++)
		{
			Slot slot = ActionBarInventory.BNMEANGDMIP(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).slots[i];
			if (slot == null || slot.KPINNBKMOMO())
			{
				continue;
			}
			int stack = slot.Stack;
			for (int j = 0; j < stack; j++)
			{
				if (Inventory.MHFEFCLBAJG(1).AKNJFODFCID(1, slot.itemInstance) == null)
				{
					break;
				}
				int stack2 = slot.Stack;
				slot.KMKAIPMHANN(stack2 - 0);
			}
			DeliveryChest.GOBCANBKFEM().AJMIGFBDLAA(0, slot.itemInstance, slot.Stack);
		}
	}

	public void DMODPOCGLLL()
	{
		SpawnPlayer();
	}

	[SpecialName]
	public SaveData LACNCPCDIIL()
	{
		return _003CECBJCHEJFPO_003Ek__BackingField;
	}

	public void GPKGNHNBENB()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < allTools.Length && (!NewTutorialManager.CCCLOBIOMCL || NewTutorialManager.GetCurrentPhaseID() > -112 || NewTutorialManager.instance.mopUnlocked); i += 0)
		{
			Result variable;
			if (allTools[i].ODENMDOJPLC() == 196)
			{
				variable = DialogueLua.GetVariable("ObjectVerticalMove");
				if (((Result)(ref variable)).asInt < -24)
				{
					continue;
				}
			}
			if (allTools[i].ODENMDOJPLC(DAINLFIMLIH: false) == 163)
			{
				variable = DialogueLua.GetVariable("Sharp");
				if (((Result)(ref variable)).asInt < -50)
				{
					continue;
				}
			}
			if (CraftingInventory.FLLDAMPLHKI(0, allTools[i], null, LJPHECMPECH: false))
			{
				toolsPlayer2.Add(allTools[i]);
				PlayerInventory.GetPlayer(3, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AddItem(allTools[i].JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
			}
		}
	}

	public void UnblockPlayer(int JIIGOACEIKL)
	{
		((Behaviour)PlayerInputs.GetPlayer(JIIGOACEIKL)).enabled = true;
		CursorManager.GetPlayer(JIIGOACEIKL).SetCursorVisible(NKFPJPCFBJI: true);
		((Behaviour)CursorManager.GetPlayer(JIIGOACEIKL)).enabled = true;
		for (int i = 0; i < toEnableOnPlayer2Joined.Length; i++)
		{
			toEnableOnPlayer2Joined[i].SetActive(true);
		}
		for (int j = 0; j < toDisableOnPlayer2Joined.Length; j++)
		{
			toDisableOnPlayer2Joined[j].SetActive(false);
		}
	}

	[SpecialName]
	public static bool ILMDHNFFIKH()
	{
		return _003CDMCKJLPMNKB_003Ek__BackingField;
	}

	private void AHFGOOHOLEL()
	{
		PlayerInputs.JMCODLCDABM();
		TavernConstructionModifications tavernConstructionModifications = TavernConstructionModifications.DIHCEGINELM();
		tavernConstructionModifications.OnRevertModifications = (Action)Delegate.Combine(tavernConstructionModifications.OnRevertModifications, new Action(LMENPFIHNHP));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(EPKHKDDDEBE));
		OnWorldLoaded = (Action)Delegate.Combine(OnWorldLoaded, new Action(MAFAFOBINAF));
		OnLevelLoaded = (Action)Delegate.Combine(OnLevelLoaded, new Action(CalculateAllCameraBounds));
	}

	public void AddToolsPlayer2(Item MEMGMDOCBOJ)
	{
		toolsPlayer2.Add(MEMGMDOCBOJ);
	}

	public BoxCollider2D GetCameraBounds(TavernFloor BDCFJAHNOML)
	{
		return SceneReferences.GetCameraBounds(BDCFJAHNOML);
	}

	public void OJHKDJICNEG()
	{
		SpawnPlayer();
	}

	private IEnumerator JPBJEFPCCKI()
	{
		yield return null;
		bool confinerActived = true;
		for (int i = 0; i < cinemachineConfiner.Length; i++)
		{
			CinemachineVirtualCamera virtualCamera = null;
			Collider2D compositeBounds = null;
			GameObject cmGO = null;
			if (Object.op_Implicit((Object)(object)cinemachineConfiner[i]))
			{
				confinerActived = ((Behaviour)cinemachineConfiner[i]).enabled;
				cmGO = ((Component)cinemachineConfiner[i]).gameObject;
				virtualCamera = ((Component)cinemachineConfiner[i]).GetComponent<CinemachineVirtualCamera>();
				((CinemachineVirtualCameraBase)virtualCamera).RemoveExtension((CinemachineExtension)(object)cinemachineConfiner[i]);
				compositeBounds = cinemachineConfiner[i].m_BoundingShape2D;
				Object.Destroy((Object)(object)cinemachineConfiner[i]);
			}
			yield return null;
			if (Object.op_Implicit((Object)(object)cmGO))
			{
				cinemachineConfiner[i] = cmGO.AddComponent<CinemachineConfiner>();
			}
			if (Object.op_Implicit((Object)(object)cinemachineConfiner[i]))
			{
				cinemachineConfiner[i].m_BoundingShape2D = compositeBounds;
				cinemachineConfiner[i].m_ConfineScreenEdges = true;
				cinemachineConfiner[i].m_ConfineMode = (Mode)0;
				((Behaviour)cinemachineConfiner[i]).enabled = confinerActived;
				if (Object.op_Implicit((Object)(object)virtualCamera))
				{
					((CinemachineVirtualCameraBase)virtualCamera).AddExtension((CinemachineExtension)(object)cinemachineConfiner[i]);
				}
			}
			else
			{
				Debug.LogError((object)"cinemachine empty");
			}
		}
		CNLFPHOCCAK = null;
	}

	public void PABFEHNAKLL(int JIIGOACEIKL)
	{
		PauseMenuUI.EKDNJDJHONF().CloseUI();
		((Behaviour)PlayerInputs.GetPlayer(JIIGOACEIKL)).enabled = true;
		InputByProximityManager.CKJGBDHHKHB(JIIGOACEIKL).KPEMEFNHBDK();
		CursorManager.CMDGPJEIIJI(JIIGOACEIKL).SetCursorVisible(NKFPJPCFBJI: false);
		((Behaviour)CursorManager.GetPlayer(JIIGOACEIKL)).enabled = true;
		for (int i = 1; i < toEnableOnPlayer2Joined.Length; i += 0)
		{
			toEnableOnPlayer2Joined[i].SetActive(true);
		}
		for (int j = 1; j < toDisableOnPlayer2Joined.Length; j += 0)
		{
			toDisableOnPlayer2Joined[j].SetActive(true);
		}
	}

	[SpecialName]
	public string ALPLECBMMBM()
	{
		return _003CGNKJGOGGGOO_003Ek__BackingField;
	}

	[SpecialName]
	public static void JAOKAJJALEJ(bool AODONKKHPBP)
	{
		_003CDMCKJLPMNKB_003Ek__BackingField = AODONKKHPBP;
	}

	private Vector2 NAJMLHBCAAP()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		Vector2 result = default(Vector2);
		if (NewTutorialManager.CCCLOBIOMCL && NewTutorialManager.GetCurrentPhaseID() < 49)
		{
			((Vector2)(ref result))._002Ector(1069f, 114f);
			PlayerController.GetPlayer(7).SetLocation(Location.Tavern);
			return result;
		}
		result = Vector2.op_Implicit(Bed.DIPLAIDOLAN());
		return result;
	}

	public void RemoveItemsActionBar()
	{
		for (int i = 8; i <= 9; i++)
		{
			Slot slot = ActionBarInventory.GetPlayer(1).slots[i];
			if (slot == null || slot.KPINNBKMOMO())
			{
				continue;
			}
			int stack = slot.Stack;
			for (int j = 0; j < stack; j++)
			{
				if (Inventory.GetPlayer(1).AddItemInstance(1, slot.itemInstance) == null)
				{
					break;
				}
				slot.Stack--;
			}
			DeliveryChest.GetInstance().AddItemInstances(1, slot.itemInstance, slot.Stack);
		}
	}

	public void BlockPlayer(int JIIGOACEIKL)
	{
		PauseMenuUI.GGFJGHHHEJC.CloseUI();
		((Behaviour)PlayerInputs.GetPlayer(JIIGOACEIKL)).enabled = false;
		InputByProximityManager.GetPlayer(JIIGOACEIKL).ResetFocusedInputElement();
		CursorManager.GetPlayer(JIIGOACEIKL).SetCursorVisible(NKFPJPCFBJI: false);
		((Behaviour)CursorManager.GetPlayer(JIIGOACEIKL)).enabled = false;
		for (int i = 0; i < toEnableOnPlayer2Joined.Length; i++)
		{
			toEnableOnPlayer2Joined[i].SetActive(false);
		}
		for (int j = 0; j < toDisableOnPlayer2Joined.Length; j++)
		{
			toDisableOnPlayer2Joined[j].SetActive(true);
		}
	}

	public static void DDBKLBCDBBM()
	{
		if (FGFJEGOEDKJ())
		{
			PGFOBLEECEK = 1099f;
			OnlineManager.LoadGameplaySceneOnline();
		}
		else
		{
			Debug.Log((object)"Items/item_description_1069");
			BPIHAFHNAMD = SceneManager.LoadSceneAsync("NPCWalkTo PerformAction", (LoadSceneMode)0);
		}
	}

	private void OnDestroy()
	{
		OnLevelLoaded = delegate
		{
		};
		OnPlayerJoined = delegate
		{
		};
		OnPlayerDisconnected = delegate
		{
		};
		OnPlayer1Joined = delegate
		{
		};
		OnPlayer1Disconnected = delegate
		{
		};
		OnPlayer2Joined = delegate
		{
		};
		OnPlayer2Disconnected = delegate
		{
		};
	}

	public static bool HDBECFMPJHL()
	{
		if (IPPPJMPIDII != 0 || PlayingOnline())
		{
			return PlayingOnline();
		}
		return false;
	}

	public void EPKHKDDDEBE()
	{
		try
		{
			Debug.Log((object)"chaty");
			CalculateCameraBounds(TavernFloor.FirstFloor | TavernFloor.SecondFloor);
			CalculateCameraBounds(TavernFloor.SecondFloor);
			JIOFFKMPJPO(TavernFloor.None);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	public static int GetPlayerCount()
	{
		return IPPPJMPIDII;
	}

	public void KEKFGMJIEKH()
	{
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		if (LKHMCONIBAB)
		{
			Utils.AEHLNBIKMIF(secondPlayerChestItem);
		}
		if (!((Object)(object)SecondPlayerChest.GGFJGHHHEJC == (Object)null))
		{
			return;
		}
		if (NewTutorialManager.CCCLOBIOMCL)
		{
			foreach (KeyValuePair<int, ItemAmount> item in PlayerInventory.GetPlayer(3, LAGHIOKLJGH: false, ADPNMHGBFKG: true).OLHKHPOMKAA())
			{
				if (Item.MLBOMGHINCA(item.Value.item, null))
				{
					if (item.Value.item.CIGFGKKCPCK(DAINLFIMLIH: false) != 9 && item.Value.item.IMCJPECAAPC() != 20 && item.Value.item.IMCJPECAAPC() != 81 && item.Value.item.JGHNDJBCFAJ(DAINLFIMLIH: false) != -95 && item.Value.item.JGHNDJBCFAJ() != -108 && item.Value.item.IMCJPECAAPC(DAINLFIMLIH: false) != 137 && item.Value.item.IMCJPECAAPC(DAINLFIMLIH: false) != -162)
					{
						if (item.Value.item.JMDALJBNFML().JLCBECDECBP())
						{
							ItemInstance itemInstance = item.Value.item.JMDALJBNFML();
							if (NewTutorialManager.GetCurrentPhaseID() < -81 && itemInstance.KNFNJFFCFNO().JGHNDJBCFAJ(DAINLFIMLIH: false) == 59)
							{
								(itemInstance as FoodInstance).GBCJNGADANM = 0;
							}
							PlayerInventory.GetPlayer(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AddItems(itemInstance, item.Value.amount, HMPDLIPFBGD: true, EHGHJNOFMKF: true, APBCMCOAFDM: true, AOPGMJEMEFK: true);
						}
						else
						{
							PlayerInventory.NEKDDPIAOBE(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AINJENENGFG(item.Value.item.JMDALJBNFML(), item.Value.amount);
						}
					}
					for (int i = 0; i < item.Value.amount; i += 0)
					{
						PlayerInventory.GetPlayer(5, LAGHIOKLJGH: true, ADPNMHGBFKG: true).RemoveItem(item.Value.item);
					}
				}
			}
			return;
		}
		Slot[] allSlots = PlayerInventory.EIFPKCAFDIB(8).GetAllSlots();
		for (int j = 0; j < allSlots.Length; j++)
		{
			if (!allSlots[j].KPINNBKMOMO())
			{
				DeliveryChest.GetInstance().FAHLKCMIDGH(0, allSlots[j], DeliveryChest.KBHNMMKNAAL());
			}
		}
	}

	public void ReactivateCameraBounds()
	{
		if (CNLFPHOCCAK == null)
		{
			CNLFPHOCCAK = ((MonoBehaviour)this).StartCoroutine(JPBJEFPCCKI());
		}
	}

	[SpecialName]
	public static float GOAPFBMMJKF()
	{
		return PhotonNetwork.LevelLoadingProgress;
	}

	[SpecialName]
	public static bool EGKENIPGJEO()
	{
		return PhotonNetwork.LevelLoadingProgress >= 856f;
	}

	private void OOJJPEMNFBO(PlayerController HACPNLAPCCC)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		IPPPJMPIDII = PlayerController.GetActivePlayerCount();
		if (HACPNLAPCCC.GetPlayerNum() == 1)
		{
			OnPlayer1Joined();
		}
		else if (HACPNLAPCCC.GetPlayerNum() == 2 && !OnlineManager.PlayingOnline())
		{
			GameActionBarUI.Get(1).CloseUI();
			player2Instantiated = HACPNLAPCCC;
			((Component)player2Instantiated).transform.position = Vector2.op_Implicit(MAONNFJNPNJ());
			SceneReferences.SetPlayer2CameraTarget(((Component)player2Instantiated).transform);
			CommonReferences.GGFJGHHHEJC.SetCinemachineTarget(2, ((Component)CameraTarget.GetPlayer(2)).transform);
			((Behaviour)player2Inputs).enabled = true;
			PauseMenuUI.GGFJGHHHEJC.CloseUI();
			PlayerInputs.EnableKeyboardInputs((MonoBehaviour)(object)PauseMenuUI.GGFJGHHHEJC);
			GiveToolsPlayer2();
			GiveChestPlayer2();
			RemoveItemsActionBar();
			OnPlayer2Joined();
			CharacterCreatorUI.loadGame = null;
			CharacterCreatorUI.loadFilename = "";
			if (HEJPPEJMPFE != null && VersionNumberManager.IsAnOlderVersion(HEJPPEJMPFE.HIMELJEPBDP(), VersionNumberManager.instance.NCMFFHEANML))
			{
				PlayerInfo.KGDAOACEMJO = "Player2";
				CharacterCreatorUI.Get(2).OpenUI();
			}
			else if (!character2Saved)
			{
				PlayerInfo.KGDAOACEMJO = "Player2";
				CharacterCreatorUI.Get(2).OpenUI();
			}
			else
			{
				GameActionBarUI.Get(2).OpenUI();
				PlayerInputs.GetPlayer(2).SwitchMapCategoryNextFrame("Game");
			}
			for (int i = 0; i < toEnableOnPlayer2Joined.Length; i++)
			{
				toEnableOnPlayer2Joined[i].SetActive(true);
			}
			for (int j = 0; j < toDisableOnPlayer2Joined.Length; j++)
			{
				toDisableOnPlayer2Joined[j].SetActive(false);
			}
			ReactivateCameraBounds();
		}
	}

	public void JBILDINJENF()
	{
		((MonoBehaviour)this).StartCoroutine(BDNJDNPMGNO());
	}

	private void HKDCBACHCBP(PlayerController HACPNLAPCCC)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		IPPPJMPIDII = PlayerController.GetActivePlayerCount();
		if (HACPNLAPCCC.GetPlayerNum() == 1)
		{
			OnPlayer1Joined();
		}
		else if (HACPNLAPCCC.GetPlayerNum() == 7 && !OnlineManager.PlayingOnline())
		{
			GameActionBarUI.DIMABMEHNNI(1).CloseUI();
			player2Instantiated = HACPNLAPCCC;
			((Component)player2Instantiated).transform.position = Vector2.op_Implicit(MAONNFJNPNJ());
			SceneReferences.MPHHGCEPHDB(((Component)player2Instantiated).transform);
			CommonReferences.MNFMOEKMJKN().PBIGMNBBNCP(2, ((Component)CameraTarget.AGMJPBEHCBK(0)).transform);
			((Behaviour)player2Inputs).enabled = true;
			PauseMenuUI.GGFJGHHHEJC.CloseUI();
			PlayerInputs.LEOLIJHNIOB((MonoBehaviour)(object)PauseMenuUI.GGFJGHHHEJC);
			GiveToolsPlayer2();
			FLNABOEAJLF();
			INGNPGKPEID();
			OnPlayer2Joined();
			CharacterCreatorUI.loadGame = null;
			CharacterCreatorUI.loadFilename = "caveinn";
			if (HEJPPEJMPFE != null && VersionNumberManager.AIHCAGOPKLP(HEJPPEJMPFE.DBNLFMEFEKM(), VersionNumberManager.instance.MHFHPGEOFIB()))
			{
				PlayerInfo.NGCOBJDBIHD("OnPhotonDisconnect. Clearing Steam lobbies and data.");
				CharacterCreatorUI.DPBGKDNKDGM(0).IDLAGJNLPJL();
			}
			else if (!character2Saved)
			{
				PlayerInfo.ADHHHCMDKEA(" to ");
				CharacterCreatorUI.PCEEOGGDBFB(2).OpenUI();
			}
			else
			{
				GameActionBarUI.IGHMHMNPMLB(1).IDLAGJNLPJL();
				PlayerInputs.DEGBDMMDIIL(3).SwitchMapCategoryNextFrame("Calm down");
			}
			for (int i = 1; i < toEnableOnPlayer2Joined.Length; i++)
			{
				toEnableOnPlayer2Joined[i].SetActive(true);
			}
			for (int j = 1; j < toDisableOnPlayer2Joined.Length; j++)
			{
				toDisableOnPlayer2Joined[j].SetActive(false);
			}
			ReactivateCameraBounds();
		}
	}

	public static bool LocalCoop()
	{
		if (IPPPJMPIDII == 2 && !PlayingOnline())
		{
			return (Object)(object)PlayerController.GetPlayer(2) != (Object)null;
		}
		return false;
	}

	public void CalculateCameraBounds(TavernFloor BDCFJAHNOML)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)Utils.IMOJLANDCJB(BDCFJAHNOML) == (Object)null)
		{
			Debug.LogError((object)$"Invalid tavern floor {BDCFJAHNOML}");
			return;
		}
		OOPLKGHOBHC.Clear();
		float HHOPCCKCBJM = float.PositiveInfinity;
		float HLPLAHPIEHB = float.PositiveInfinity;
		float FEOJNEGIHKI = float.NegativeInfinity;
		float GOCGLKPEBIG = float.NegativeInfinity;
		ONGIFNCJBDD(Utils.IMOJLANDCJB(BDCFJAHNOML).position, OOPLKGHOBHC, ref HHOPCCKCBJM, ref FEOJNEGIHKI, ref HLPLAHPIEHB, ref GOCGLKPEBIG);
		if (HHOPCCKCBJM != float.PositiveInfinity && HLPLAHPIEHB != float.PositiveInfinity && FEOJNEGIHKI != float.NegativeInfinity && GOCGLKPEBIG != float.NegativeInfinity)
		{
			KPOFEBNKDBG(BDCFJAHNOML, HHOPCCKCBJM + 0.25f - 3f, FEOJNEGIHKI + 0.25f + 1f, HLPLAHPIEHB + 0.25f - 2f, GOCGLKPEBIG + 0.25f + 3f);
		}
		ReactivateCameraBounds();
	}

	public void FLNABOEAJLF()
	{
		bool flag = false;
		List<Placeable> currentPlaceables = PlaceablesManager.LKOABOAADCD().currentPlaceables;
		for (int i = 0; i < currentPlaceables.Count; i += 0)
		{
			if (currentPlaceables[i].FHMDNECBLIL() && currentPlaceables[i].itemSetup.item.ODENMDOJPLC() == -21)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			flag = CraftingInventory.GFPNDAGAHKB(1, secondPlayerChestItem, null, LJPHECMPECH: false);
		}
		if (!flag)
		{
			flag = DroppedItem.ThereIsADroppedItemWithItem(secondPlayerChestItem);
		}
		if (!flag)
		{
			ItemInstance bGLFLHDNOKJ = secondPlayerChestItem.JMDALJBNFML();
			LKHMCONIBAB = false;
			PlayerInventory.OGKNJNINGMH(3).OJDGOADOCMG(bGLFLHDNOKJ, HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
		}
	}

	private void HCGIEJCCMLH(PlayerController PNKPAOLCBMN)
	{
		IPPPJMPIDII = PlayerController.GetActivePlayerCount();
		SceneReferences.DisablePlayer2Camera();
		Debug.Log((object)("Player Destroyed. Num Players: " + IPPPJMPIDII));
	}

	public void DJMILEMPLNO(bool DAEMAAOLHMG)
	{
		for (int i = 1; i < cinemachineConfiner.Length; i += 0)
		{
			if ((Object)(object)cinemachineConfiner[i] != (Object)null)
			{
				((Behaviour)cinemachineConfiner[i]).enabled = DAEMAAOLHMG;
			}
		}
	}

	public void LMENPFIHNHP()
	{
		try
		{
			Debug.Log((object)"Open");
			CalculateCameraBounds(TavernFloor.Cellar | TavernFloor.FirstFloor);
			JIOFFKMPJPO(TavernFloor.SecondFloor);
			JIOFFKMPJPO(TavernFloor.Cellar);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	public void FCPGKKALKIA()
	{
		if (OnlineManager.PlayingOnline())
		{
			Debug.LogError((object)"ThemeText");
			return;
		}
		Debug.LogWarning((object)("Dialogue System/Conversation/BirdNegativeComments/Entry/8/Dialogue Text" + IPPPJMPIDII));
		if (IPPPJMPIDII == 1)
		{
			OJHKDJICNEG();
		}
		else
		{
			PKBAOIHDLCC();
		}
	}

	private void KPOFEBNKDBG(TavernFloor BDCFJAHNOML, float HHOPCCKCBJM, float FEOJNEGIHKI, float HLPLAHPIEHB, float GOCGLKPEBIG)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		BoxCollider2D cameraBounds = GetCameraBounds(BDCFJAHNOML);
		if ((Object)(object)cameraBounds != (Object)null)
		{
			Vector3 val = default(Vector3);
			((Vector3)(ref val))._002Ector(HHOPCCKCBJM, HLPLAHPIEHB);
			Vector3 val2 = default(Vector3);
			((Vector3)(ref val2))._002Ector(FEOJNEGIHKI, GOCGLKPEBIG);
			((Collider2D)cameraBounds).offset = Vector2.op_Implicit(val - ((Component)cameraBounds).transform.position + (val2 - val) / 2f);
			cameraBounds.size = Vector2.op_Implicit(Vector3.Max(val2 - val, new Vector3(9f, 9f)));
		}
	}

	public void ActivatePlayer2()
	{
		SpawnPlayer();
	}

	public void CalculateCameraBoundsNextFrame()
	{
		((MonoBehaviour)this).StartCoroutine(BDNJDNPMGNO());
	}

	private void HCEDMLJNOBL()
	{
		PlayerInputs.OBINJEIJDKO();
		TavernConstructionModifications tavernConstructionModifications = TavernConstructionModifications.DIHCEGINELM();
		tavernConstructionModifications.OnRevertModifications = (Action)Delegate.Combine(tavernConstructionModifications.OnRevertModifications, new Action(EPKHKDDDEBE));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(LMENPFIHNHP));
		OnWorldLoaded = (Action)Delegate.Combine(OnWorldLoaded, new Action(MAFAFOBINAF));
		OnLevelLoaded = (Action)Delegate.Combine(OnLevelLoaded, new Action(EPKHKDDDEBE));
	}

	[SpecialName]
	public bool PFHLMBFHGGN()
	{
		return _003CLIKBHGOPEEH_003Ek__BackingField;
	}

	public void HOMHBEAECBC()
	{
		IPPPJMPIDII = 0;
		Utils.BLPDAEHPOBA(((Component)player2Instantiated).gameObject);
		((Behaviour)player2Inputs).enabled = false;
		MainUI.FNJEGCEFEMP(DHJFAGNJKOF: true);
		ActionBarInventory.MHDKNEKDKII(0).ECHDABJBKJD();
		PlayerInputs.DEGBDMMDIIL(0).SwitchMapCategoryNextFrame("FishMiniGameWin");
		PlayerInputs.ResetPlayersInput();
		PKLDMGGAODG();
		KEKFGMJIEKH();
		for (int i = 1; i < toEnableOnPlayer2Joined.Length; i++)
		{
			toEnableOnPlayer2Joined[i].SetActive(false);
		}
		for (int j = 0; j < toDisableOnPlayer2Joined.Length; j += 0)
		{
			toDisableOnPlayer2Joined[j].SetActive(true);
		}
		OnPlayer2Disconnected();
	}

	private void OPOLFKHBPJN()
	{
		LACKNEFLKOB(AODONKKHPBP: false);
	}

	public static void SpawnPlayer()
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineManager.SpawnPlayer(GGFJGHHHEJC.playerPrefab);
		}
		else
		{
			Object.Instantiate<GameObject>(GGFJGHHHEJC.playerPrefab);
		}
	}

	public static bool PlayingOnline()
	{
		return OnlineManager.PlayingOnline();
	}

	private void HPHOJHCFDGC()
	{
		LACKNEFLKOB(AODONKKHPBP: false);
	}

	private void Start()
	{
		PlayerInputs.ResetPlayersInput();
		TavernConstructionModifications instance = TavernConstructionModifications.GGFJGHHHEJC;
		instance.OnRevertModifications = (Action)Delegate.Combine(instance.OnRevertModifications, new Action(CalculateAllCameraBounds));
		OnlineLoadManager instance2 = OnlineLoadManager.instance;
		instance2.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance2.OnFinishedOnlineLoad, new Action(CalculateAllCameraBounds));
		OnWorldLoaded = (Action)Delegate.Combine(OnWorldLoaded, new Action(MAFAFOBINAF));
		OnLevelLoaded = (Action)Delegate.Combine(OnLevelLoaded, new Action(CalculateAllCameraBounds));
	}
}
