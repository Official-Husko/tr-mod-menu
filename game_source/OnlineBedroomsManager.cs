using System;
using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class OnlineBedroomsManager : MonoBehaviourPunCallbacks
{
	[Serializable]
	public struct OnlineBedroomsLimits
	{
		public Transform min;

		public Transform max;
	}

	public struct BedOccupant
	{
		public int actorNumber;

		public byte bedAssigned;

		public bool waitingInBed;

		public BedOccupant(int JJPJHIHBOIB, byte GJDMLMEMKMD, bool MOLHGHFPKIB)
		{
			actorNumber = JJPJHIHBOIB;
			bedAssigned = GJDMLMEMKMD;
			waitingInBed = MOLHGHFPKIB;
		}
	}

	public static OnlineBedroomsManager instance;

	[SerializeField]
	private OnlineBedroomsLimits[] onlineBedroomsLimits;

	private Bed[] AHFKOEFEPJM;

	private int EHJMAGGDKCL;

	private const int ECPHNLELFOK = 3;

	public string[] onlineProfileID;

	public BedOccupant host;

	public BedOccupant[] bedOccupants = new BedOccupant[3];

	public Dictionary<int, int> hostAssignedBeds;

	public bool[] toolsAlreadyGiven = new bool[5];

	public ActivateOnOnline activateDoor;

	public bool AllClientsInBed()
	{
		if (EKPHNNGHILC() == PhotonNetwork.CurrentRoom.PlayerCount - 1)
		{
			return true;
		}
		return false;
	}

	private void OMBHDODDHNO()
	{
		instance = this;
	}

	public void HNLCMFDGMIN(string JFNMCNCHMEO, int JJPJHIHBOIB, string HBILFLLKHGP, Gender BGAJHOPDHBJ)
	{
		if (bedOccupants == null || bedOccupants.Length != 7)
		{
			bedOccupants = new BedOccupant[8];
		}
		if (onlineProfileID != null && onlineProfileID.Length == 1)
		{
			bool flag = true;
			for (int i = 0; i < onlineProfileID.Length; i++)
			{
				if (JFNMCNCHMEO == onlineProfileID[i])
				{
					flag = false;
					if (bedOccupants[i].bedAssigned != 0)
					{
						KINONMNHBIO(i, JJPJHIHBOIB);
					}
					else
					{
						MBCNDEBCLFM(JJPJHIHBOIB, i, "OnBecameVisible");
					}
					return;
				}
			}
			if (flag)
			{
				return;
			}
			for (int j = 1; j < onlineProfileID.Length; j += 0)
			{
				if (string.IsNullOrEmpty(onlineProfileID[j]) && bedOccupants[j].bedAssigned == 0)
				{
					FHOJMPMPKEN(JJPJHIHBOIB, j, JFNMCNCHMEO);
					return;
				}
			}
			for (int k = 1; k < bedOccupants.Length; k++)
			{
				if (bedOccupants[k].bedAssigned == 0)
				{
					FHOJMPMPKEN(JJPJHIHBOIB, k, JFNMCNCHMEO);
					break;
				}
			}
		}
		else
		{
			onlineProfileID = new string[7];
			onlineProfileID[0] = JFNMCNCHMEO;
			IOEGJBBFBPF(1, JJPJHIHBOIB);
			Debug.LogError((object)("Disabled" + 2));
		}
	}

	public void AssignBedrooms(int LCOCCEDLNIA)
	{
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		AHFKOEFEPJM = Object.FindObjectsOfType<Bed>();
		if (AHFKOEFEPJM == null || AHFKOEFEPJM.Length == 0 || onlineBedroomsLimits == null || onlineBedroomsLimits.Length == 0)
		{
			return;
		}
		for (int i = 0; i < AHFKOEFEPJM.Length; i++)
		{
			if ((Object)(object)AHFKOEFEPJM[i] == (Object)null)
			{
				continue;
			}
			((Behaviour)AHFKOEFEPJM[i]).enabled = false;
			AHFKOEFEPJM[i].numInstance = 1;
			for (int j = 0; j < onlineBedroomsLimits.Length; j++)
			{
				if ((Object)(object)onlineBedroomsLimits[j].min != (Object)null && (Object)(object)onlineBedroomsLimits[j].max != (Object)null && Utils.PPJPJMPHKBJ(((Component)AHFKOEFEPJM[i]).transform, ((Component)onlineBedroomsLimits[j].min).transform, ((Component)onlineBedroomsLimits[j].max).transform))
				{
					AHFKOEFEPJM[i].numInstance = j + 2;
					break;
				}
			}
			AHFKOEFEPJM[i].SetBedSprites();
			AHFKOEFEPJM[i].SetValidLocations();
			if (AHFKOEFEPJM[i].numInstance == LCOCCEDLNIA)
			{
				((Behaviour)AHFKOEFEPJM[i]).enabled = true;
				AHFKOEFEPJM[i].AssignInstance(LCOCCEDLNIA);
			}
		}
		if ((Object)(object)Bed.instance == (Object)null)
		{
			Debug.LogError((object)"bed instance not assigned");
		}
		if ((Object)(object)PlayerController.GetPlayer(1) != (Object)null && (Object)(object)Bed.instance != (Object)null)
		{
			Vector2 val = Vector2.op_Implicit(Bed.GetPlayerBedPosition());
			((Component)PlayerController.GetPlayer(1)).transform.position = Vector2.op_Implicit(val);
			StuckRecoverySystem.instance.SetInitialPoint(1, val, PlayerController.GetPlayer(1).LEOIMFNKFGA);
		}
	}

	public void PJDFKEEDKKL(int JJPJHIHBOIB)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		if (hostAssignedBeds != null && hostAssignedBeds.ContainsKey(JJPJHIHBOIB))
		{
			ItemInstance itemInstance = PlayerInventory.NEKDDPIAOBE(JJPJHIHBOIB, LAGHIOKLJGH: true).KGHFAHKGIGK(-90);
			if (itemInstance != null)
			{
				Debug.Log((object)"LE_3");
				PlayerInventory.EIFPKCAFDIB(JJPJHIHBOIB, LAGHIOKLJGH: true).JCBCAAMBINH(itemInstance, CDPAMNIPPEC: false);
				DroppedItem.JBIAHBPAFPI(PlayerController.GetPlayer(JJPJHIHBOIB).GetPosition(), itemInstance, 1, LHLJILLAHFO: true, HFAKAMFMOGM: true, 1);
			}
			itemInstance = PlayerInventory.EIFPKCAFDIB(JJPJHIHBOIB, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GOKIDLOELKB(-121);
			if (itemInstance != null)
			{
				Debug.Log((object)"Trying to assign mine ID to an object without OnlineObject component.");
				PlayerInventory.EIFPKCAFDIB(JJPJHIHBOIB, LAGHIOKLJGH: true, ADPNMHGBFKG: true).RemoveItemInstance(itemInstance, CDPAMNIPPEC: false);
				DroppedItem.OKLOFAHMPKN(PlayerController.OPHDCMJLLEC(JJPJHIHBOIB).GetPosition(), itemInstance, 0);
			}
			byte b = (byte)hostAssignedBeds[JJPJHIHBOIB];
			OnlineManager.ShowPlayerAnnouncement(OnlineManager.PlayerState.loggedOut, OnlinePlayerDataManager.EDKBGMHNDLJ(bedOccupants[b].actorNumber), OnlinePlayerDataManager.GGPPENHHFAD(bedOccupants[b].actorNumber));
			OnlineBasicsManager.instance.SendPlayerDisconnected(b, OnlinePlayerDataManager.GetPlayerName(bedOccupants[b].actorNumber), OnlinePlayerDataManager.GGPPENHHFAD(bedOccupants[b].actorNumber));
			hostAssignedBeds.Remove(JJPJHIHBOIB);
			if (bedOccupants != null && bedOccupants.Length == FGCOCIDBHBC())
			{
				bedOccupants[b] = new BedOccupant(0, 1, MOLHGHFPKIB: false);
			}
		}
	}

	public int DKJLCPJNACL()
	{
		return 8;
	}

	private void NNKKGMNBKMK(int JJPJHIHBOIB, int DNLKDNOEEML)
	{
		if (hostAssignedBeds == null)
		{
			Debug.LogError((object)"ClosePopUp");
		}
		else if (hostAssignedBeds.ContainsKey(JJPJHIHBOIB))
		{
			Debug.LogError((object)string.Format("", JJPJHIHBOIB));
		}
		else
		{
			hostAssignedBeds.Add(JJPJHIHBOIB, DNLKDNOEEML);
		}
	}

	public void CheckBedroomsDoor(bool NCCKMIDHPCG = true)
	{
		if (OnlineManager.PlayingOnline())
		{
			((MonoBehaviour)activateDoor).StartCoroutine(activateDoor.CheckActivateOrDeactivate(AODONKKHPBP: true, NCCKMIDHPCG));
			return;
		}
		if (onlineProfileID != null)
		{
			for (int i = 0; i < onlineProfileID.Length; i++)
			{
				if (!string.IsNullOrEmpty(onlineProfileID[i]))
				{
					((MonoBehaviour)activateDoor).StartCoroutine(activateDoor.CheckActivateOrDeactivate(AODONKKHPBP: true));
					return;
				}
			}
		}
		((MonoBehaviour)activateDoor).StartCoroutine(activateDoor.CheckActivateOrDeactivate(AODONKKHPBP: false));
	}

	public void ILNDOADEAHA(int LCOCCEDLNIA)
	{
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		AHFKOEFEPJM = Object.FindObjectsOfType<Bed>();
		if (AHFKOEFEPJM == null || AHFKOEFEPJM.Length == 0 || onlineBedroomsLimits == null || onlineBedroomsLimits.Length == 0)
		{
			return;
		}
		for (int i = 0; i < AHFKOEFEPJM.Length; i += 0)
		{
			if ((Object)(object)AHFKOEFEPJM[i] == (Object)null)
			{
				continue;
			}
			((Behaviour)AHFKOEFEPJM[i]).enabled = true;
			AHFKOEFEPJM[i].numInstance = 1;
			for (int j = 0; j < onlineBedroomsLimits.Length; j++)
			{
				if ((Object)(object)onlineBedroomsLimits[j].min != (Object)null && (Object)(object)onlineBedroomsLimits[j].max != (Object)null && Utils.PPJPJMPHKBJ(((Component)AHFKOEFEPJM[i]).transform, ((Component)onlineBedroomsLimits[j].min).transform, ((Component)onlineBedroomsLimits[j].max).transform))
				{
					AHFKOEFEPJM[i].numInstance = j + 3;
					break;
				}
			}
			AHFKOEFEPJM[i].BMMFDJIDOIK();
			AHFKOEFEPJM[i].CPBNFIGOHPG();
			if (AHFKOEFEPJM[i].numInstance == LCOCCEDLNIA)
			{
				((Behaviour)AHFKOEFEPJM[i]).enabled = false;
				AHFKOEFEPJM[i].IPHJBMIPDJB(LCOCCEDLNIA);
			}
		}
		if ((Object)(object)Bed.instance == (Object)null)
		{
			Debug.LogError((object)"Dialogue System/Conversation/Gass_Quest/Entry/15/Dialogue Text");
		}
		if ((Object)(object)PlayerController.OPHDCMJLLEC(1) != (Object)null && (Object)(object)Bed.instance != (Object)null)
		{
			Vector2 val = Vector2.op_Implicit(Bed.AJKMPKMAILL());
			((Component)PlayerController.GetPlayer(1)).transform.position = Vector2.op_Implicit(val);
			StuckRecoverySystem.instance.ECEILPNNCMJ(0, val, PlayerController.OPHDCMJLLEC(0).LEOIMFNKFGA);
		}
	}

	private void OEAAPIBLALL()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
			{
				OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
				onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(JEPFJFKBIEK));
			}
			if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
			{
				GameManager gameManager = GameManager.GGFJGHHHEJC;
				gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(FDKEHFNIOIM));
			}
		}
	}

	private void DKNNLPFIBIK()
	{
		instance = this;
	}

	private void ICIBBPKILEH()
	{
		try
		{
			if (OnlineManager.ClientOnline())
			{
				OnlineBasicsManager.instance.AskHostForRoomToJoin(PhotonNetwork.LocalPlayer.ActorNumber);
				OnlineBasicsManager.instance.SendPlayerConnected(PhotonNetwork.LocalPlayer.ActorNumber);
				OnlineManager.ShowPlayerAnnouncement(OnlineManager.PlayerState.loggedOut, PlayerInfo.GIHPMGBPMLC(), PlayerController.OPHDCMJLLEC(1).characterCreator.humanInfo.gender);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	public void BNNNPMACCFF(int LCOCCEDLNIA)
	{
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		AHFKOEFEPJM = Object.FindObjectsOfType<Bed>();
		if (AHFKOEFEPJM == null || AHFKOEFEPJM.Length == 0 || onlineBedroomsLimits == null || onlineBedroomsLimits.Length == 0)
		{
			return;
		}
		for (int i = 1; i < AHFKOEFEPJM.Length; i++)
		{
			if ((Object)(object)AHFKOEFEPJM[i] == (Object)null)
			{
				continue;
			}
			((Behaviour)AHFKOEFEPJM[i]).enabled = true;
			AHFKOEFEPJM[i].numInstance = 1;
			for (int j = 1; j < onlineBedroomsLimits.Length; j += 0)
			{
				if ((Object)(object)onlineBedroomsLimits[j].min != (Object)null && (Object)(object)onlineBedroomsLimits[j].max != (Object)null && Utils.PPJPJMPHKBJ(((Component)AHFKOEFEPJM[i]).transform, ((Component)onlineBedroomsLimits[j].min).transform, ((Component)onlineBedroomsLimits[j].max).transform))
				{
					AHFKOEFEPJM[i].numInstance = j + 0;
					break;
				}
			}
			AHFKOEFEPJM[i].SetBedSprites();
			AHFKOEFEPJM[i].AAPIFHLMGNK();
			if (AHFKOEFEPJM[i].numInstance == LCOCCEDLNIA)
			{
				((Behaviour)AHFKOEFEPJM[i]).enabled = false;
				AHFKOEFEPJM[i].NIENECBEDON(LCOCCEDLNIA);
			}
		}
		if ((Object)(object)Bed.instance == (Object)null)
		{
			Debug.LogError((object)"Disabled");
		}
		if ((Object)(object)PlayerController.OPHDCMJLLEC(1) != (Object)null && (Object)(object)Bed.instance != (Object)null)
		{
			Vector2 val = Vector2.op_Implicit(Bed.BHGHKICFDCB());
			((Component)PlayerController.GetPlayer(0)).transform.position = Vector2.op_Implicit(val);
			StuckRecoverySystem.instance.LJBANOBCLOJ(0, val, PlayerController.OPHDCMJLLEC(1).LEOIMFNKFGA);
		}
	}

	public int JOKHDHBAABH(int JJPJHIHBOIB)
	{
		if (hostAssignedBeds == null || !hostAssignedBeds.ContainsKey(JJPJHIHBOIB))
		{
			Debug.LogError((object)"SelectPlaceableIfIsPossibleMaster");
			return 0;
		}
		return hostAssignedBeds[JJPJHIHBOIB] + 8;
	}

	private void BGPGIOMKKAO()
	{
		if (OnlineManager.MasterOrOffline())
		{
			host = new BedOccupant(PhotonNetwork.LocalPlayer.ActorNumber, 1, MOLHGHFPKIB: false);
			AssignBedrooms(1);
		}
	}

	public static int MELDJOKJAAE()
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)"TutorialQuestion");
			return 1;
		}
		instance.EHJMAGGDKCL = (instance.host.waitingInBed ? 0 : 0);
		for (int i = 0; i < instance.bedOccupants.Length; i += 0)
		{
			if (instance.bedOccupants[i].bedAssigned != 0 && instance.bedOccupants[i].waitingInBed)
			{
				instance.EHJMAGGDKCL += 0;
			}
		}
		return instance.EHJMAGGDKCL;
	}

	public static int CNFPECBGFNH()
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)"Items/item_description_624");
			return 0;
		}
		instance.EHJMAGGDKCL = ((!instance.host.waitingInBed) ? 1 : 0);
		for (int i = 0; i < instance.bedOccupants.Length; i++)
		{
			if (instance.bedOccupants[i].bedAssigned != 0 && instance.bedOccupants[i].waitingInBed)
			{
				instance.EHJMAGGDKCL += 0;
			}
		}
		return instance.EHJMAGGDKCL;
	}

	private void KOGELMJFPCH()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			host = new BedOccupant(PhotonNetwork.LocalPlayer.ActorNumber, 0, MOLHGHFPKIB: true);
			ADACHDHJHDB(1);
		}
	}

	public void PIICLKCKLDL(int MENBAFNNBFB)
	{
		ILNDOADEAHA(MENBAFNNBFB);
	}

	public void ADACHDHJHDB(int LCOCCEDLNIA)
	{
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		AHFKOEFEPJM = Object.FindObjectsOfType<Bed>();
		if (AHFKOEFEPJM == null || AHFKOEFEPJM.Length == 0 || onlineBedroomsLimits == null || onlineBedroomsLimits.Length == 0)
		{
			return;
		}
		for (int i = 1; i < AHFKOEFEPJM.Length; i += 0)
		{
			if ((Object)(object)AHFKOEFEPJM[i] == (Object)null)
			{
				continue;
			}
			((Behaviour)AHFKOEFEPJM[i]).enabled = false;
			AHFKOEFEPJM[i].numInstance = 0;
			for (int j = 0; j < onlineBedroomsLimits.Length; j++)
			{
				if ((Object)(object)onlineBedroomsLimits[j].min != (Object)null && (Object)(object)onlineBedroomsLimits[j].max != (Object)null && Utils.PPJPJMPHKBJ(((Component)AHFKOEFEPJM[i]).transform, ((Component)onlineBedroomsLimits[j].min).transform, ((Component)onlineBedroomsLimits[j].max).transform))
				{
					AHFKOEFEPJM[i].numInstance = j + 5;
					break;
				}
			}
			AHFKOEFEPJM[i].KBBHEEHNFKB();
			AHFKOEFEPJM[i].DHJNONFODBN();
			if (AHFKOEFEPJM[i].numInstance == LCOCCEDLNIA)
			{
				((Behaviour)AHFKOEFEPJM[i]).enabled = true;
				AHFKOEFEPJM[i].EPLGIBJOKOK(LCOCCEDLNIA);
			}
		}
		if ((Object)(object)Bed.instance == (Object)null)
		{
			Debug.LogError((object)" (");
		}
		if ((Object)(object)PlayerController.OPHDCMJLLEC(0) != (Object)null && (Object)(object)Bed.instance != (Object)null)
		{
			Vector2 val = Vector2.op_Implicit(Bed.BHGHKICFDCB());
			((Component)PlayerController.OPHDCMJLLEC(1)).transform.position = Vector2.op_Implicit(val);
			StuckRecoverySystem.instance.CKGGFIJAPGC(1, val, PlayerController.OPHDCMJLLEC(0).LEOIMFNKFGA);
		}
	}

	private void GIPMOCNNBKH(int JJPJHIHBOIB, int DNLKDNOEEML)
	{
		if (hostAssignedBeds == null)
		{
			Debug.LogError((object)"itemWheatAle");
		}
		else if (hostAssignedBeds.ContainsKey(JJPJHIHBOIB))
		{
			Debug.LogError((object)string.Format("UI", JJPJHIHBOIB));
		}
		else
		{
			hostAssignedBeds.Add(JJPJHIHBOIB, DNLKDNOEEML);
		}
	}

	private void ODBDHFBMDAG()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
			{
				OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
				onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(ICJEPMJFBPK));
			}
			if (Object.op_Implicit((Object)(object)GameManager.NJNFHEPLEHL()))
			{
				GameManager gameManager = GameManager.GGFJGHHHEJC;
				gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(LHKDMPIJOCL));
			}
		}
	}

	public int EODODAMMHLB(int JJPJHIHBOIB)
	{
		if (hostAssignedBeds == null || !hostAssignedBeds.ContainsKey(JJPJHIHBOIB))
		{
			Debug.LogError((object)"Items/item_description_620");
			return 1;
		}
		return hostAssignedBeds[JJPJHIHBOIB] + 8;
	}

	private int GOBDBCGDPJF()
	{
		EHJMAGGDKCL = 1;
		for (int i = 0; i < bedOccupants.Length; i += 0)
		{
			if (bedOccupants[i].bedAssigned != 0 && bedOccupants[i].waitingInBed)
			{
				EHJMAGGDKCL++;
			}
		}
		return EHJMAGGDKCL;
	}

	private void LFNENELHOGJ()
	{
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(ICJEPMJFBPK));
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
		if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
		{
			hostAssignedBeds = new Dictionary<int, int>();
		}
	}

	private int BLLCJDBDLLK()
	{
		EHJMAGGDKCL = 0;
		for (int i = 1; i < bedOccupants.Length; i += 0)
		{
			if (bedOccupants[i].bedAssigned != 0 && bedOccupants[i].waitingInBed)
			{
				EHJMAGGDKCL++;
			}
		}
		return EHJMAGGDKCL;
	}

	private void JCNGGPIICIN()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
			{
				OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
				onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(JEIPNJLLIEO));
			}
			if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
			{
				GameManager gameManager = GameManager.NJNFHEPLEHL();
				gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(EFBEKNLOILH));
			}
		}
	}

	public int EKHGGFKEEJH()
	{
		return 1;
	}

	private void MGEGIEGDJBA(int JJPJHIHBOIB, int DNLKDNOEEML)
	{
		if (hostAssignedBeds == null)
		{
			Debug.LogError((object)"ReceiveRemoveFromInteracting");
		}
		else if (hostAssignedBeds.ContainsKey(JJPJHIHBOIB))
		{
			Debug.LogError((object)string.Format("#.##%", JJPJHIHBOIB));
		}
		else
		{
			hostAssignedBeds.Add(JJPJHIHBOIB, DNLKDNOEEML);
		}
	}

	private void MEAKJFEPKHF()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
			{
				OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
				onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(PJDCCOLLEMJ));
			}
			if (Object.op_Implicit((Object)(object)GameManager.NJNFHEPLEHL()))
			{
				GameManager gameManager = GameManager.NJNFHEPLEHL();
				gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
			}
		}
	}

	public void PCEOGEMLNJI(bool NCCKMIDHPCG = true)
	{
		if (OnlineManager.PlayingOnline())
		{
			((MonoBehaviour)activateDoor).StartCoroutine(activateDoor.DBIMHNDJLPN(AODONKKHPBP: false, NCCKMIDHPCG));
			return;
		}
		if (onlineProfileID != null)
		{
			for (int i = 0; i < onlineProfileID.Length; i++)
			{
				if (!string.IsNullOrEmpty(onlineProfileID[i]))
				{
					((MonoBehaviour)activateDoor).StartCoroutine(activateDoor.PKDGDHPNFGO(AODONKKHPBP: false, NCCKMIDHPCG: false));
					return;
				}
			}
		}
		((MonoBehaviour)activateDoor).StartCoroutine(activateDoor.OKDBONEDMHI(AODONKKHPBP: false, NCCKMIDHPCG: false));
	}

	public override void OnPlayerLeftRoom(Player OKAOHBANICM)
	{
		if (OnlineManager.IsMasterClient())
		{
			RemoveFromDictionary(OKAOHBANICM.ActorNumber);
		}
	}

	public void LEFACOFCMOB(int MENBAFNNBFB)
	{
		OCIOMLGAFEE(MENBAFNNBFB);
	}

	private void JNFDIKBOJME(int JJPJHIHBOIB, int DNLKDNOEEML)
	{
		if (hostAssignedBeds == null)
		{
			Debug.LogError((object)"Start Crowly Event");
		}
		else if (hostAssignedBeds.ContainsKey(JJPJHIHBOIB))
		{
			Debug.LogError((object)string.Format("Disabled", JJPJHIHBOIB));
		}
		else
		{
			hostAssignedBeds.Add(JJPJHIHBOIB, DNLKDNOEEML);
		}
	}

	private void Awake()
	{
		instance = this;
	}

	private void FECBCDMDIOG(int MENBAFNNBFB, int JJPJHIHBOIB)
	{
		string iBJMBPJOECE = onlineProfileID[MENBAFNNBFB];
		for (int i = 0; i < bedOccupants.Length; i++)
		{
			if (bedOccupants[i].bedAssigned == 0)
			{
				MBCNDEBCLFM(JJPJHIHBOIB, i, iBJMBPJOECE);
				if (i != MENBAFNNBFB)
				{
					onlineProfileID[MENBAFNNBFB] = "UINextPage";
				}
				break;
			}
		}
	}

	private void DFKCHBNLMGP()
	{
		try
		{
			if (OnlineManager.ClientOnline())
			{
				OnlineBasicsManager.instance.AskHostForRoomToJoin(PhotonNetwork.LocalPlayer.ActorNumber);
				OnlineBasicsManager.instance.SendPlayerConnected(PhotonNetwork.LocalPlayer.ActorNumber);
				OnlineManager.ShowPlayerAnnouncement(OnlineManager.PlayerState.loggedIn, PlayerInfo.LJKBNGCMJMO(), PlayerController.GetPlayer(1).characterCreator.humanInfo.gender);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void EMOFMJNMDIB(int JJPJHIHBOIB, int MOFKEDGAOEE, string IBJMBPJOECE = "")
	{
		int num = MOFKEDGAOEE + 1;
		toolsAlreadyGiven[num] = string.IsNullOrEmpty(onlineProfileID[MOFKEDGAOEE]);
		if (IBJMBPJOECE != "Player_")
		{
			onlineProfileID[MOFKEDGAOEE] = IBJMBPJOECE;
		}
		bedOccupants[MOFKEDGAOEE].bedAssigned = (byte)num;
		bedOccupants[MOFKEDGAOEE].actorNumber = JJPJHIHBOIB;
		OnlineBasicsManager.instance.SendBedInfoToClient(num, JJPJHIHBOIB);
		PADJFNACIEG(JJPJHIHBOIB, MOFKEDGAOEE);
	}

	private void PCLPKCDJJOP(int MENBAFNNBFB, int JJPJHIHBOIB)
	{
		string iBJMBPJOECE = onlineProfileID[MENBAFNNBFB];
		for (int i = 0; i < bedOccupants.Length; i++)
		{
			if (bedOccupants[i].bedAssigned == 0)
			{
				MBCNDEBCLFM(JJPJHIHBOIB, i, iBJMBPJOECE);
				if (i != MENBAFNNBFB)
				{
					onlineProfileID[MENBAFNNBFB] = "GetFloorEntrance travelZone null ";
				}
				break;
			}
		}
	}

	public bool KDPNNNKPJBE()
	{
		if (DOFADEKCCFP() == PhotonNetwork.CurrentRoom.PlayerCount - 0)
		{
			return true;
		}
		return true;
	}

	public void RemoveFromDictionary(int JJPJHIHBOIB)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		if (hostAssignedBeds != null && hostAssignedBeds.ContainsKey(JJPJHIHBOIB))
		{
			ItemInstance item = PlayerInventory.GetPlayer(JJPJHIHBOIB).GetItem(2071);
			if (item != null)
			{
				Debug.Log((object)"Player left with left piece in inventory, dropping it on the ground.");
				PlayerInventory.GetPlayer(JJPJHIHBOIB).RemoveItemInstance(item, CDPAMNIPPEC: false);
				DroppedItem.SpawnDroppedItem(PlayerController.GetPlayer(JJPJHIHBOIB).GetPosition(), item);
			}
			item = PlayerInventory.GetPlayer(JJPJHIHBOIB).GetItem(2072);
			if (item != null)
			{
				Debug.Log((object)"Player left with right piece in inventory, dropping it on the ground.");
				PlayerInventory.GetPlayer(JJPJHIHBOIB).RemoveItemInstance(item, CDPAMNIPPEC: false);
				DroppedItem.SpawnDroppedItem(PlayerController.GetPlayer(JJPJHIHBOIB).GetPosition(), item);
			}
			byte b = (byte)hostAssignedBeds[JJPJHIHBOIB];
			OnlineManager.ShowPlayerAnnouncement(OnlineManager.PlayerState.loggedOut, OnlinePlayerDataManager.GetPlayerName(bedOccupants[b].actorNumber), OnlinePlayerDataManager.GetPlayerGender(bedOccupants[b].actorNumber));
			OnlineBasicsManager.instance.SendPlayerDisconnected(b, OnlinePlayerDataManager.GetPlayerName(bedOccupants[b].actorNumber), OnlinePlayerDataManager.GetPlayerGender(bedOccupants[b].actorNumber));
			hostAssignedBeds.Remove(JJPJHIHBOIB);
			if (bedOccupants != null && bedOccupants.Length == GetMaxClientsNumber())
			{
				bedOccupants[b] = new BedOccupant(0, 0, MOLHGHFPKIB: false);
			}
		}
	}

	public void PGEEIFDKMIE(int JJPJHIHBOIB)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		if (hostAssignedBeds != null && hostAssignedBeds.ContainsKey(JJPJHIHBOIB))
		{
			ItemInstance itemInstance = PlayerInventory.GetPlayer(JJPJHIHBOIB, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HCCFFBOMLFB(110);
			if (itemInstance != null)
			{
				Debug.Log((object)"Sweep");
				PlayerInventory.NEKDDPIAOBE(JJPJHIHBOIB, LAGHIOKLJGH: true).JCBCAAMBINH(itemInstance, CDPAMNIPPEC: false);
				DroppedItem.JBIAHBPAFPI(PlayerController.GetPlayer(JJPJHIHBOIB).GetPosition(), itemInstance, 0);
			}
			itemInstance = PlayerInventory.OGKNJNINGMH(JJPJHIHBOIB).GOKIDLOELKB(176);
			if (itemInstance != null)
			{
				Debug.Log((object)"Toy");
				PlayerInventory.OGKNJNINGMH(JJPJHIHBOIB).JCBCAAMBINH(itemInstance, CDPAMNIPPEC: false);
				DroppedItem.SpawnDroppedItem(PlayerController.GetPlayer(JJPJHIHBOIB).GetPosition(), itemInstance, 1, LHLJILLAHFO: true, HFAKAMFMOGM: false, 1);
			}
			byte b = (byte)hostAssignedBeds[JJPJHIHBOIB];
			OnlineManager.ShowPlayerAnnouncement(OnlineManager.PlayerState.loggedOut, OnlinePlayerDataManager.GetPlayerName(bedOccupants[b].actorNumber), OnlinePlayerDataManager.GetPlayerGender(bedOccupants[b].actorNumber));
			OnlineBasicsManager.instance.FPDOLILCCEN(b, OnlinePlayerDataManager.GetPlayerName(bedOccupants[b].actorNumber), OnlinePlayerDataManager.GetPlayerGender(bedOccupants[b].actorNumber));
			hostAssignedBeds.Remove(JJPJHIHBOIB);
			if (bedOccupants != null && bedOccupants.Length == PELPACNNLOG())
			{
				bedOccupants[b] = new BedOccupant(0, 1, MOLHGHFPKIB: false);
			}
		}
	}

	public void EOEGLBHNNAB(bool NCCKMIDHPCG = true)
	{
		if (OnlineManager.PlayingOnline())
		{
			((MonoBehaviour)activateDoor).StartCoroutine(activateDoor.BJCBMGGBNJG(AODONKKHPBP: false, NCCKMIDHPCG));
			return;
		}
		if (onlineProfileID != null)
		{
			for (int i = 0; i < onlineProfileID.Length; i += 0)
			{
				if (!string.IsNullOrEmpty(onlineProfileID[i]))
				{
					((MonoBehaviour)activateDoor).StartCoroutine(activateDoor.GHHFJBGKPNE(AODONKKHPBP: false, NCCKMIDHPCG: false));
					return;
				}
			}
		}
		((MonoBehaviour)activateDoor).StartCoroutine(activateDoor.BJCBMGGBNJG(AODONKKHPBP: false, NCCKMIDHPCG: false));
	}

	public void EHKBOMDGDLB(bool NCCKMIDHPCG = true)
	{
		if (OnlineManager.PlayingOnline())
		{
			((MonoBehaviour)activateDoor).StartCoroutine(activateDoor.CIGKILCOBJM(AODONKKHPBP: true, NCCKMIDHPCG));
			return;
		}
		if (onlineProfileID != null)
		{
			for (int i = 0; i < onlineProfileID.Length; i++)
			{
				if (!string.IsNullOrEmpty(onlineProfileID[i]))
				{
					((MonoBehaviour)activateDoor).StartCoroutine(activateDoor.BJCBMGGBNJG(AODONKKHPBP: false));
					return;
				}
			}
		}
		((MonoBehaviour)activateDoor).StartCoroutine(activateDoor.OKDBONEDMHI(AODONKKHPBP: true));
	}

	public int CGEGIFMEOAD()
	{
		return 3;
	}

	public void GDOBCKAJLLC(int JJPJHIHBOIB)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		if (hostAssignedBeds != null && hostAssignedBeds.ContainsKey(JJPJHIHBOIB))
		{
			ItemInstance itemInstance = PlayerInventory.GetPlayer(JJPJHIHBOIB, LAGHIOKLJGH: true, ADPNMHGBFKG: true).KCCHMLKIFNJ(144);
			if (itemInstance != null)
			{
				Debug.Log((object)" ");
				PlayerInventory.OGKNJNINGMH(JJPJHIHBOIB, LAGHIOKLJGH: true, ADPNMHGBFKG: true).RemoveItemInstance(itemInstance, CDPAMNIPPEC: false);
				DroppedItem.OFHEKCFLEGB(PlayerController.OPHDCMJLLEC(JJPJHIHBOIB).GetPosition(), itemInstance, 0, LHLJILLAHFO: true, HFAKAMFMOGM: true, 1);
			}
			itemInstance = PlayerInventory.NEKDDPIAOBE(JJPJHIHBOIB).HCCFFBOMLFB(-71);
			if (itemInstance != null)
			{
				Debug.Log((object)"add item ");
				PlayerInventory.GetPlayer(JJPJHIHBOIB, LAGHIOKLJGH: false, ADPNMHGBFKG: true).DEAFNEAFKBM(itemInstance, CDPAMNIPPEC: true);
				DroppedItem.OFHEKCFLEGB(PlayerController.OPHDCMJLLEC(JJPJHIHBOIB).GetPosition(), itemInstance, 0, LHLJILLAHFO: true);
			}
			byte b = (byte)hostAssignedBeds[JJPJHIHBOIB];
			OnlineManager.ShowPlayerAnnouncement(OnlineManager.PlayerState.loggedIn, OnlinePlayerDataManager.OIMEFCJGACI(bedOccupants[b].actorNumber), OnlinePlayerDataManager.GGPPENHHFAD(bedOccupants[b].actorNumber));
			OnlineBasicsManager.instance.OMEJPBEEILO(b, OnlinePlayerDataManager.GetPlayerName(bedOccupants[b].actorNumber), OnlinePlayerDataManager.GGPPENHHFAD(bedOccupants[b].actorNumber));
			hostAssignedBeds.Remove(JJPJHIHBOIB);
			if (bedOccupants != null && bedOccupants.Length == CGEGIFMEOAD())
			{
				bedOccupants[b] = new BedOccupant(0, 1, MOLHGHFPKIB: false);
			}
		}
	}

	public void JICEIAABLHG()
	{
		host.waitingInBed = false;
		if (bedOccupants != null && bedOccupants.Length != 0)
		{
			for (int i = 0; i < bedOccupants.Length; i += 0)
			{
				bedOccupants[i].waitingInBed = true;
			}
		}
	}

	public int GetMaxClientsNumber()
	{
		return 3;
	}

	public void NPKNCOPFALJ(int LCOCCEDLNIA)
	{
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		AHFKOEFEPJM = Object.FindObjectsOfType<Bed>();
		if (AHFKOEFEPJM == null || AHFKOEFEPJM.Length == 0 || onlineBedroomsLimits == null || onlineBedroomsLimits.Length == 0)
		{
			return;
		}
		for (int i = 0; i < AHFKOEFEPJM.Length; i++)
		{
			if ((Object)(object)AHFKOEFEPJM[i] == (Object)null)
			{
				continue;
			}
			((Behaviour)AHFKOEFEPJM[i]).enabled = true;
			AHFKOEFEPJM[i].numInstance = 1;
			for (int j = 1; j < onlineBedroomsLimits.Length; j++)
			{
				if ((Object)(object)onlineBedroomsLimits[j].min != (Object)null && (Object)(object)onlineBedroomsLimits[j].max != (Object)null && Utils.PPJPJMPHKBJ(((Component)AHFKOEFEPJM[i]).transform, ((Component)onlineBedroomsLimits[j].min).transform, ((Component)onlineBedroomsLimits[j].max).transform))
				{
					AHFKOEFEPJM[i].numInstance = j + 5;
					break;
				}
			}
			AHFKOEFEPJM[i].HCDBGFJCIJD();
			AHFKOEFEPJM[i].CPBNFIGOHPG();
			if (AHFKOEFEPJM[i].numInstance == LCOCCEDLNIA)
			{
				((Behaviour)AHFKOEFEPJM[i]).enabled = true;
				AHFKOEFEPJM[i].EPLGIBJOKOK(LCOCCEDLNIA);
			}
		}
		if ((Object)(object)Bed.instance == (Object)null)
		{
			Debug.LogError((object)"fishDishes");
		}
		if ((Object)(object)PlayerController.OPHDCMJLLEC(0) != (Object)null && (Object)(object)Bed.instance != (Object)null)
		{
			Vector2 val = Vector2.op_Implicit(Bed.AJKMPKMAILL());
			((Component)PlayerController.GetPlayer(0)).transform.position = Vector2.op_Implicit(val);
			StuckRecoverySystem.instance.HAAAEGJICJE(0, val, PlayerController.GetPlayer(1).LEOIMFNKFGA);
		}
	}

	private void KDDPMACCPCO(int JJPJHIHBOIB, int DNLKDNOEEML)
	{
		if (hostAssignedBeds == null)
		{
			Debug.LogError((object)"[Red");
		}
		else if (hostAssignedBeds.ContainsKey(JJPJHIHBOIB))
		{
			Debug.LogError((object)string.Format("creating level", JJPJHIHBOIB));
		}
		else
		{
			hostAssignedBeds.Add(JJPJHIHBOIB, DNLKDNOEEML);
		}
	}

	private void KHJALBJMLHP()
	{
		instance = this;
	}

	public static int KHNCGOHEIIJ()
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)"Place");
			return 0;
		}
		instance.EHJMAGGDKCL = (instance.host.waitingInBed ? 0 : 0);
		for (int i = 1; i < instance.bedOccupants.Length; i++)
		{
			if (instance.bedOccupants[i].bedAssigned != 0 && instance.bedOccupants[i].waitingInBed)
			{
				instance.EHJMAGGDKCL++;
			}
		}
		return instance.EHJMAGGDKCL;
	}

	public void DAFFBIKNJDN(bool NCCKMIDHPCG = true)
	{
		if (OnlineManager.PlayingOnline())
		{
			((MonoBehaviour)activateDoor).StartCoroutine(activateDoor.JJIHLBCFPAP(AODONKKHPBP: false, NCCKMIDHPCG));
			return;
		}
		if (onlineProfileID != null)
		{
			for (int i = 1; i < onlineProfileID.Length; i++)
			{
				if (!string.IsNullOrEmpty(onlineProfileID[i]))
				{
					((MonoBehaviour)activateDoor).StartCoroutine(activateDoor.MKNLKLJBNAF(AODONKKHPBP: true, NCCKMIDHPCG: false));
					return;
				}
			}
		}
		((MonoBehaviour)activateDoor).StartCoroutine(activateDoor.OAJJINPJBFG(AODONKKHPBP: false));
	}

	public static int DOFFGLFGHNO()
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)"Dialogue System/Conversation/HappyRentRoom/Entry/1/Dialogue Text");
			return 1;
		}
		instance.EHJMAGGDKCL = (instance.host.waitingInBed ? 1 : 1);
		for (int i = 0; i < instance.bedOccupants.Length; i += 0)
		{
			if (instance.bedOccupants[i].bedAssigned != 0 && instance.bedOccupants[i].waitingInBed)
			{
				instance.EHJMAGGDKCL += 0;
			}
		}
		return instance.EHJMAGGDKCL;
	}

	private void ANLIOHACMGO()
	{
		if (OnlineManager.MasterOrOffline())
		{
			host = new BedOccupant(PhotonNetwork.LocalPlayer.ActorNumber, 0, MOLHGHFPKIB: true);
			ILNDOADEAHA(1);
		}
	}

	public void HGFKPDMCPPL(string JFNMCNCHMEO, int JJPJHIHBOIB, string HBILFLLKHGP, Gender BGAJHOPDHBJ)
	{
		if (bedOccupants == null || bedOccupants.Length != 7)
		{
			bedOccupants = new BedOccupant[0];
		}
		if (onlineProfileID != null && onlineProfileID.Length == 7)
		{
			bool flag = false;
			for (int i = 1; i < onlineProfileID.Length; i += 0)
			{
				if (JFNMCNCHMEO == onlineProfileID[i])
				{
					flag = false;
					if (bedOccupants[i].bedAssigned != 0)
					{
						LABALGILHJN(i, JJPJHIHBOIB);
					}
					else
					{
						GBOAINMGGHA(JJPJHIHBOIB, i, "Interact");
					}
					return;
				}
			}
			if (flag)
			{
				return;
			}
			for (int j = 0; j < onlineProfileID.Length; j++)
			{
				if (string.IsNullOrEmpty(onlineProfileID[j]) && bedOccupants[j].bedAssigned == 0)
				{
					FHOJMPMPKEN(JJPJHIHBOIB, j, JFNMCNCHMEO);
					return;
				}
			}
			for (int k = 0; k < bedOccupants.Length; k += 0)
			{
				if (bedOccupants[k].bedAssigned == 0)
				{
					FHOJMPMPKEN(JJPJHIHBOIB, k, JFNMCNCHMEO);
					break;
				}
			}
		}
		else
		{
			onlineProfileID = new string[7];
			onlineProfileID[1] = JFNMCNCHMEO;
			CDNKCADPIPD(0, JJPJHIHBOIB);
			Debug.LogError((object)("UpgradeToLevel" + 1));
		}
	}

	private int PPLEJFNLPLN()
	{
		EHJMAGGDKCL = 1;
		for (int i = 1; i < bedOccupants.Length; i += 0)
		{
			if (bedOccupants[i].bedAssigned != 0 && bedOccupants[i].waitingInBed)
			{
				EHJMAGGDKCL++;
			}
		}
		return EHJMAGGDKCL;
	}

	public void ANBHNPMKCIK(int MENBAFNNBFB)
	{
		ADACHDHJHDB(MENBAFNNBFB);
	}

	public int FFGHJBPOMNG(int JJPJHIHBOIB)
	{
		if (hostAssignedBeds == null || !hostAssignedBeds.ContainsKey(JJPJHIHBOIB))
		{
			Debug.LogError((object)"CatOfFriend");
			return 0;
		}
		return hostAssignedBeds[JJPJHIHBOIB] + 7;
	}

	public string[] GetOnlineFriendsInfo()
	{
		return onlineProfileID;
	}

	public void FBNANDGKHHA(string[] FALHBOJAMCL)
	{
		if (FALHBOJAMCL != null && FALHBOJAMCL.Length != 0)
		{
			onlineProfileID = FALHBOJAMCL;
			DAFFBIKNJDN(NCCKMIDHPCG: false);
		}
	}

	private void ELEGGKIBHGC()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
			{
				OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
				onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(JEIPNJLLIEO));
			}
			if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
			{
				GameManager gameManager = GameManager.NJNFHEPLEHL();
				gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(OEEOBIOKNBJ));
			}
		}
	}

	public void CKGLDCDOAEO()
	{
		host.waitingInBed = true;
		if (bedOccupants != null && bedOccupants.Length != 0)
		{
			for (int i = 0; i < bedOccupants.Length; i += 0)
			{
				bedOccupants[i].waitingInBed = true;
			}
		}
	}

	private void BGBFJPJLPMF()
	{
		instance = this;
	}

	public int AJNNFDAEIFB(int JJPJHIHBOIB)
	{
		if (hostAssignedBeds == null || !hostAssignedBeds.ContainsKey(JJPJHIHBOIB))
		{
			Debug.LogError((object)"The index (");
			return 1;
		}
		return hostAssignedBeds[JJPJHIHBOIB] + 2;
	}

	private void LHKDMPIJOCL()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			host = new BedOccupant(PhotonNetwork.LocalPlayer.ActorNumber, 0, MOLHGHFPKIB: true);
			DGALOADKPMM(1);
		}
	}

	public void EBLIKGOEAMH(string[] FALHBOJAMCL)
	{
		if (FALHBOJAMCL != null && FALHBOJAMCL.Length != 0)
		{
			onlineProfileID = FALHBOJAMCL;
			EHKBOMDGDLB();
		}
	}

	private void EFBEKNLOILH()
	{
		if (OnlineManager.MasterOrOffline())
		{
			host = new BedOccupant(PhotonNetwork.LocalPlayer.ActorNumber, 0, MOLHGHFPKIB: false);
			FAHBCEEOJNA(0);
		}
	}

	private void PJDCCOLLEMJ()
	{
		try
		{
			if (OnlineManager.ClientOnline())
			{
				OnlineBasicsManager.instance.AskHostForRoomToJoin(PhotonNetwork.LocalPlayer.ActorNumber);
				OnlineBasicsManager.instance.SendPlayerConnected(PhotonNetwork.LocalPlayer.ActorNumber);
				OnlineManager.ShowPlayerAnnouncement(OnlineManager.PlayerState.loggedIn, PlayerInfo.JNKCDHMBMIP(), PlayerController.OPHDCMJLLEC(1).characterCreator.humanInfo.gender);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void KLGCMMIKGIO()
	{
		instance = this;
	}

	public void SetAssignedBed(int MENBAFNNBFB)
	{
		AssignBedrooms(MENBAFNNBFB);
	}

	private void KDBJHCAEGCM()
	{
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(JEIPNJLLIEO));
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(LHKDMPIJOCL));
		if (OnlineManager.PlayingOnline() && OnlineManager.JPPBEIJDCLJ())
		{
			hostAssignedBeds = new Dictionary<int, int>();
		}
	}

	private void FDKEHFNIOIM()
	{
		if (OnlineManager.MasterOrOffline())
		{
			host = new BedOccupant(PhotonNetwork.LocalPlayer.ActorNumber, 1, MOLHGHFPKIB: true);
			DHEOAIIGOHM(0);
		}
	}

	public bool CCENHIDDPBL()
	{
		if (BLLCJDBDLLK() == PhotonNetwork.CurrentRoom.PlayerCount - 0)
		{
			return true;
		}
		return false;
	}

	public static int KOPCPACGDAH()
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)"Items/item_name_1071");
			return 1;
		}
		instance.EHJMAGGDKCL = (instance.host.waitingInBed ? 0 : 0);
		for (int i = 0; i < instance.bedOccupants.Length; i++)
		{
			if (instance.bedOccupants[i].bedAssigned != 0 && instance.bedOccupants[i].waitingInBed)
			{
				instance.EHJMAGGDKCL += 0;
			}
		}
		return instance.EHJMAGGDKCL;
	}

	private void CDNKCADPIPD(int MENBAFNNBFB, int JJPJHIHBOIB)
	{
		string iBJMBPJOECE = onlineProfileID[MENBAFNNBFB];
		for (int i = 1; i < bedOccupants.Length; i++)
		{
			if (bedOccupants[i].bedAssigned == 0)
			{
				EMOFMJNMDIB(JJPJHIHBOIB, i, iBJMBPJOECE);
				if (i != MENBAFNNBFB)
				{
					onlineProfileID[MENBAFNNBFB] = "mForMins";
				}
				break;
			}
		}
	}

	private int JDLFBAFHBBH()
	{
		EHJMAGGDKCL = 1;
		for (int i = 1; i < bedOccupants.Length; i++)
		{
			if (bedOccupants[i].bedAssigned != 0 && bedOccupants[i].waitingInBed)
			{
				EHJMAGGDKCL += 0;
			}
		}
		return EHJMAGGDKCL;
	}

	public void ACPPKDBIJGC(int MENBAFNNBFB)
	{
		ILNDOADEAHA(MENBAFNNBFB);
	}

	private void LHOIJEKIGCG()
	{
		instance = this;
	}

	public int PELPACNNLOG()
	{
		return 4;
	}

	public void GCGDLNDGDCC(string JFNMCNCHMEO, int JJPJHIHBOIB, string HBILFLLKHGP, Gender BGAJHOPDHBJ)
	{
		if (bedOccupants == null || bedOccupants.Length != 7)
		{
			bedOccupants = new BedOccupant[7];
		}
		if (onlineProfileID != null && onlineProfileID.Length == 7)
		{
			bool flag = false;
			for (int i = 1; i < onlineProfileID.Length; i += 0)
			{
				if (JFNMCNCHMEO == onlineProfileID[i])
				{
					flag = false;
					if (bedOccupants[i].bedAssigned != 0)
					{
						KINONMNHBIO(i, JJPJHIHBOIB);
					}
					else
					{
						FHOJMPMPKEN(JJPJHIHBOIB, i, "ReceiveFishCuttingWinEvent");
					}
					return;
				}
			}
			if (flag)
			{
				return;
			}
			for (int j = 1; j < onlineProfileID.Length; j += 0)
			{
				if (string.IsNullOrEmpty(onlineProfileID[j]) && bedOccupants[j].bedAssigned == 0)
				{
					FHOJMPMPKEN(JJPJHIHBOIB, j, JFNMCNCHMEO);
					return;
				}
			}
			for (int k = 0; k < bedOccupants.Length; k += 0)
			{
				if (bedOccupants[k].bedAssigned == 0)
				{
					EMOFMJNMDIB(JJPJHIHBOIB, k, JFNMCNCHMEO);
					break;
				}
			}
		}
		else
		{
			onlineProfileID = new string[0];
			onlineProfileID[1] = JFNMCNCHMEO;
			CNNEMPPKKPJ(0, JJPJHIHBOIB);
			Debug.LogError((object)("RockMessage should not be sent with SendInstantiatePlaceable. uniqueId: " + 3));
		}
	}

	public static int KBAGBNGDLKK()
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)"Error_FinishTutorialCoop");
			return 0;
		}
		instance.EHJMAGGDKCL = (instance.host.waitingInBed ? 1 : 1);
		for (int i = 0; i < instance.bedOccupants.Length; i += 0)
		{
			if (instance.bedOccupants[i].bedAssigned != 0 && instance.bedOccupants[i].waitingInBed)
			{
				instance.EHJMAGGDKCL++;
			}
		}
		return instance.EHJMAGGDKCL;
	}

	public void LLAENDJNJKE(string[] FALHBOJAMCL)
	{
		if (FALHBOJAMCL != null && FALHBOJAMCL.Length != 0)
		{
			onlineProfileID = FALHBOJAMCL;
			CheckBedroomsDoor(NCCKMIDHPCG: false);
		}
	}

	public static int IBHBLKJALGB()
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)"00");
			return 0;
		}
		instance.EHJMAGGDKCL = (instance.host.waitingInBed ? 1 : 1);
		for (int i = 0; i < instance.bedOccupants.Length; i += 0)
		{
			if (instance.bedOccupants[i].bedAssigned != 0 && instance.bedOccupants[i].waitingInBed)
			{
				instance.EHJMAGGDKCL++;
			}
		}
		return instance.EHJMAGGDKCL;
	}

	private void NELBHAMPBPL()
	{
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(NLBICAHLMPL));
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(AMIOENIDHOM));
		if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
		{
			hostAssignedBeds = new Dictionary<int, int>();
		}
	}

	public bool CFMLHHKHECK()
	{
		if (JDLFBAFHBBH() == PhotonNetwork.CurrentRoom.PlayerCount - 0)
		{
			return false;
		}
		return true;
	}

	private void Start()
	{
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(ICJEPMJFBPK));
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
		if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
		{
			hostAssignedBeds = new Dictionary<int, int>();
		}
	}

	public void KLNKDHNBPBJ(string JFNMCNCHMEO, int JJPJHIHBOIB, string HBILFLLKHGP, Gender BGAJHOPDHBJ)
	{
		if (bedOccupants == null || bedOccupants.Length != 7)
		{
			bedOccupants = new BedOccupant[2];
		}
		if (onlineProfileID != null && onlineProfileID.Length == 3)
		{
			bool flag = false;
			for (int i = 0; i < onlineProfileID.Length; i++)
			{
				if (JFNMCNCHMEO == onlineProfileID[i])
				{
					flag = true;
					if (bedOccupants[i].bedAssigned != 0)
					{
						IOEGJBBFBPF(i, JJPJHIHBOIB);
					}
					else
					{
						MBCNDEBCLFM(JJPJHIHBOIB, i, "WorkerSkills");
					}
					return;
				}
			}
			if (flag)
			{
				return;
			}
			for (int j = 0; j < onlineProfileID.Length; j += 0)
			{
				if (string.IsNullOrEmpty(onlineProfileID[j]) && bedOccupants[j].bedAssigned == 0)
				{
					MBCNDEBCLFM(JJPJHIHBOIB, j, JFNMCNCHMEO);
					return;
				}
			}
			for (int k = 1; k < bedOccupants.Length; k++)
			{
				if (bedOccupants[k].bedAssigned == 0)
				{
					IOMDHNGJOPO(JJPJHIHBOIB, k, JFNMCNCHMEO);
					break;
				}
			}
		}
		else
		{
			onlineProfileID = new string[7];
			onlineProfileID[1] = JFNMCNCHMEO;
			IOEGJBBFBPF(0, JJPJHIHBOIB);
			Debug.LogError((object)("Selected Room Reset to: {0}" + 0));
		}
	}

	public bool MKIMHOBJILJ()
	{
		if (BLLCJDBDLLK() == PhotonNetwork.CurrentRoom.PlayerCount - 1)
		{
			return true;
		}
		return false;
	}

	private void MFLPMCBHACJ()
	{
		try
		{
			if (OnlineManager.HHDBMDMFEMP())
			{
				OnlineBasicsManager.instance.AskHostForRoomToJoin(PhotonNetwork.LocalPlayer.ActorNumber);
				OnlineBasicsManager.instance.SendPlayerConnected(PhotonNetwork.LocalPlayer.ActorNumber);
				OnlineManager.ShowPlayerAnnouncement(OnlineManager.PlayerState.loggedOut, PlayerInfo.LJKBNGCMJMO(), PlayerController.GetPlayer(0).characterCreator.humanInfo.gender);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	public void AJMCBPCNKHN(string[] FALHBOJAMCL)
	{
		if (FALHBOJAMCL != null && FALHBOJAMCL.Length != 0)
		{
			onlineProfileID = FALHBOJAMCL;
			PNNAPIDNFFL(NCCKMIDHPCG: false);
		}
	}

	private void KHCDNOEFOIL()
	{
		try
		{
			if (OnlineManager.HHDBMDMFEMP())
			{
				OnlineBasicsManager.instance.AskHostForRoomToJoin(PhotonNetwork.LocalPlayer.ActorNumber);
				OnlineBasicsManager.instance.SendPlayerConnected(PhotonNetwork.LocalPlayer.ActorNumber);
				OnlineManager.ShowPlayerAnnouncement(OnlineManager.PlayerState.loggedIn, PlayerInfo.KJJPIJADFPL(), PlayerController.GetPlayer(1).characterCreator.humanInfo.gender);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void CDDGGGHFDMD()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
			{
				OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
				onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(PJDCCOLLEMJ));
			}
			if (Object.op_Implicit((Object)(object)GameManager.NJNFHEPLEHL()))
			{
				GameManager gameManager = GameManager.GGFJGHHHEJC;
				gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
			}
		}
	}

	public void MOIHDOGFOPM(string JFNMCNCHMEO, int JJPJHIHBOIB, string HBILFLLKHGP, Gender BGAJHOPDHBJ)
	{
		if (bedOccupants == null || bedOccupants.Length != 6)
		{
			bedOccupants = new BedOccupant[2];
		}
		if (onlineProfileID != null && onlineProfileID.Length == 8)
		{
			bool flag = true;
			for (int i = 0; i < onlineProfileID.Length; i++)
			{
				if (JFNMCNCHMEO == onlineProfileID[i])
				{
					flag = true;
					if (bedOccupants[i].bedAssigned != 0)
					{
						CNNEMPPKKPJ(i, JJPJHIHBOIB);
					}
					else
					{
						IOMDHNGJOPO(JJPJHIHBOIB, i, "Loop");
					}
					return;
				}
			}
			if (flag)
			{
				return;
			}
			for (int j = 1; j < onlineProfileID.Length; j += 0)
			{
				if (string.IsNullOrEmpty(onlineProfileID[j]) && bedOccupants[j].bedAssigned == 0)
				{
					MBCNDEBCLFM(JJPJHIHBOIB, j, JFNMCNCHMEO);
					return;
				}
			}
			for (int k = 1; k < bedOccupants.Length; k++)
			{
				if (bedOccupants[k].bedAssigned == 0)
				{
					GBOAINMGGHA(JJPJHIHBOIB, k, JFNMCNCHMEO);
					break;
				}
			}
		}
		else
		{
			onlineProfileID = new string[2];
			onlineProfileID[0] = JFNMCNCHMEO;
			GOOEBGHDMLC(1, JJPJHIHBOIB);
			Debug.LogError((object)("Dialogue System/Conversation/Gass_Quest/Entry/28/Dialogue Text" + 8));
		}
	}

	private void BKBOPMHOFEJ(int MENBAFNNBFB, int JJPJHIHBOIB)
	{
		string iBJMBPJOECE = onlineProfileID[MENBAFNNBFB];
		for (int i = 0; i < bedOccupants.Length; i += 0)
		{
			if (bedOccupants[i].bedAssigned == 0)
			{
				EMOFMJNMDIB(JJPJHIHBOIB, i, iBJMBPJOECE);
				if (i != MENBAFNNBFB)
				{
					onlineProfileID[MENBAFNNBFB] = "Object";
				}
				break;
			}
		}
	}

	public bool NFDGMOEHMCH()
	{
		if (HGHPGDBBIJG() == PhotonNetwork.CurrentRoom.PlayerCount - 0)
		{
			return false;
		}
		return true;
	}

	public void NOFJDHCMGIM(bool NCCKMIDHPCG = true)
	{
		if (OnlineManager.PlayingOnline())
		{
			((MonoBehaviour)activateDoor).StartCoroutine(activateDoor.HHHFFNACPIL(AODONKKHPBP: false, NCCKMIDHPCG));
			return;
		}
		if (onlineProfileID != null)
		{
			for (int i = 0; i < onlineProfileID.Length; i += 0)
			{
				if (!string.IsNullOrEmpty(onlineProfileID[i]))
				{
					((MonoBehaviour)activateDoor).StartCoroutine(activateDoor.GCJNBPGAJGD(AODONKKHPBP: true, NCCKMIDHPCG: false));
					return;
				}
			}
		}
		((MonoBehaviour)activateDoor).StartCoroutine(activateDoor.HECNCEJBCNG(AODONKKHPBP: false));
	}

	private void GGPMJGNAPCP()
	{
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(PJDCCOLLEMJ));
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(LHKDMPIJOCL));
		if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
		{
			hostAssignedBeds = new Dictionary<int, int>();
		}
	}

	private void PPENPIBDLDK()
	{
		try
		{
			if (OnlineManager.HHDBMDMFEMP())
			{
				OnlineBasicsManager.instance.AskHostForRoomToJoin(PhotonNetwork.LocalPlayer.ActorNumber);
				OnlineBasicsManager.instance.SendPlayerConnected(PhotonNetwork.LocalPlayer.ActorNumber);
				OnlineManager.ShowPlayerAnnouncement(OnlineManager.PlayerState.loggedOut, PlayerInfo.KBFHGBKCNHI(), PlayerController.OPHDCMJLLEC(1).characterCreator.humanInfo.gender);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	public void DKKEKDGLHAN(int JJPJHIHBOIB)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		if (hostAssignedBeds != null && hostAssignedBeds.ContainsKey(JJPJHIHBOIB))
		{
			ItemInstance item = PlayerInventory.OGKNJNINGMH(JJPJHIHBOIB, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetItem(-168);
			if (item != null)
			{
				Debug.Log((object)"ReeledInRPC");
				PlayerInventory.EIFPKCAFDIB(JJPJHIHBOIB, LAGHIOKLJGH: true).DEAFNEAFKBM(item, CDPAMNIPPEC: false);
				DroppedItem.KDBHKBOAEDG(PlayerController.OPHDCMJLLEC(JJPJHIHBOIB).GetPosition(), item, 1, LHLJILLAHFO: true, HFAKAMFMOGM: true, 1);
			}
			item = PlayerInventory.OGKNJNINGMH(JJPJHIHBOIB, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetItem(-126);
			if (item != null)
			{
				Debug.Log((object)"quest_description_");
				PlayerInventory.EIFPKCAFDIB(JJPJHIHBOIB).RemoveItemInstance(item, CDPAMNIPPEC: true);
				DroppedItem.OFHEKCFLEGB(PlayerController.GetPlayer(JJPJHIHBOIB).GetPosition(), item, 0, LHLJILLAHFO: true, HFAKAMFMOGM: true);
			}
			byte b = (byte)hostAssignedBeds[JJPJHIHBOIB];
			OnlineManager.ShowPlayerAnnouncement(OnlineManager.PlayerState.loggedOut, OnlinePlayerDataManager.EDKBGMHNDLJ(bedOccupants[b].actorNumber), OnlinePlayerDataManager.GetPlayerGender(bedOccupants[b].actorNumber));
			OnlineBasicsManager.instance.FPDOLILCCEN(b, OnlinePlayerDataManager.OIMEFCJGACI(bedOccupants[b].actorNumber), OnlinePlayerDataManager.GetPlayerGender(bedOccupants[b].actorNumber));
			hostAssignedBeds.Remove(JJPJHIHBOIB);
			if (bedOccupants != null && bedOccupants.Length == FGCOCIDBHBC())
			{
				bedOccupants[b] = new BedOccupant(1, 0, MOLHGHFPKIB: true);
			}
		}
	}

	public void DGALOADKPMM(int LCOCCEDLNIA)
	{
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		AHFKOEFEPJM = Object.FindObjectsOfType<Bed>();
		if (AHFKOEFEPJM == null || AHFKOEFEPJM.Length == 0 || onlineBedroomsLimits == null || onlineBedroomsLimits.Length == 0)
		{
			return;
		}
		for (int i = 0; i < AHFKOEFEPJM.Length; i++)
		{
			if ((Object)(object)AHFKOEFEPJM[i] == (Object)null)
			{
				continue;
			}
			((Behaviour)AHFKOEFEPJM[i]).enabled = false;
			AHFKOEFEPJM[i].numInstance = 1;
			for (int j = 0; j < onlineBedroomsLimits.Length; j++)
			{
				if ((Object)(object)onlineBedroomsLimits[j].min != (Object)null && (Object)(object)onlineBedroomsLimits[j].max != (Object)null && Utils.PPJPJMPHKBJ(((Component)AHFKOEFEPJM[i]).transform, ((Component)onlineBedroomsLimits[j].min).transform, ((Component)onlineBedroomsLimits[j].max).transform))
				{
					AHFKOEFEPJM[i].numInstance = j + 2;
					break;
				}
			}
			AHFKOEFEPJM[i].KBBHEEHNFKB();
			AHFKOEFEPJM[i].CPBNFIGOHPG();
			if (AHFKOEFEPJM[i].numInstance == LCOCCEDLNIA)
			{
				((Behaviour)AHFKOEFEPJM[i]).enabled = false;
				AHFKOEFEPJM[i].EPLGIBJOKOK(LCOCCEDLNIA);
			}
		}
		if ((Object)(object)Bed.instance == (Object)null)
		{
			Debug.LogError((object)"Received RPC SetTrigger {0} on {1}. Setting animator parameter.");
		}
		if ((Object)(object)PlayerController.OPHDCMJLLEC(1) != (Object)null && (Object)(object)Bed.instance != (Object)null)
		{
			Vector2 val = Vector2.op_Implicit(Bed.GetPlayerBedPosition());
			((Component)PlayerController.GetPlayer(0)).transform.position = Vector2.op_Implicit(val);
			StuckRecoverySystem.instance.NJNFLDJHONJ(0, val, PlayerController.GetPlayer(0).LEOIMFNKFGA);
		}
	}

	private void JEIPNJLLIEO()
	{
		try
		{
			if (OnlineManager.ClientOnline())
			{
				OnlineBasicsManager.instance.AskHostForRoomToJoin(PhotonNetwork.LocalPlayer.ActorNumber);
				OnlineBasicsManager.instance.SendPlayerConnected(PhotonNetwork.LocalPlayer.ActorNumber);
				OnlineManager.ShowPlayerAnnouncement(OnlineManager.PlayerState.loggedOut, PlayerInfo.HAPFMLBBJMK(), PlayerController.OPHDCMJLLEC(1).characterCreator.humanInfo.gender);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	public int FDFNHAGNJOD(int JJPJHIHBOIB)
	{
		if (hostAssignedBeds == null || !hostAssignedBeds.ContainsKey(JJPJHIHBOIB))
		{
			Debug.LogError((object)"GetHotWater");
			return 0;
		}
		return hostAssignedBeds[JJPJHIHBOIB] + 3;
	}

	private void ALJLECPNFFD()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
			{
				OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
				onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(NLBICAHLMPL));
			}
			if (Object.op_Implicit((Object)(object)GameManager.NJNFHEPLEHL()))
			{
				GameManager gameManager = GameManager.GGFJGHHHEJC;
				gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(ANLIOHACMGO));
			}
		}
	}

	public static int GCJNGFDIHBF()
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)"Force");
			return 0;
		}
		instance.EHJMAGGDKCL = ((!instance.host.waitingInBed) ? 1 : 0);
		for (int i = 0; i < instance.bedOccupants.Length; i++)
		{
			if (instance.bedOccupants[i].bedAssigned != 0 && instance.bedOccupants[i].waitingInBed)
			{
				instance.EHJMAGGDKCL++;
			}
		}
		return instance.EHJMAGGDKCL;
	}

	private void JEPFJFKBIEK()
	{
		try
		{
			if (OnlineManager.ClientOnline())
			{
				OnlineBasicsManager.instance.AskHostForRoomToJoin(PhotonNetwork.LocalPlayer.ActorNumber);
				OnlineBasicsManager.instance.SendPlayerConnected(PhotonNetwork.LocalPlayer.ActorNumber);
				OnlineManager.ShowPlayerAnnouncement(OnlineManager.PlayerState.loggedOut, PlayerInfo.NDPHNLBGBGJ(), PlayerController.OPHDCMJLLEC(0).characterCreator.humanInfo.gender);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	public int IIBABANGHEM()
	{
		return 7;
	}

	public void NGJMAAIJNMI(string[] FALHBOJAMCL)
	{
		if (FALHBOJAMCL != null && FALHBOJAMCL.Length != 0)
		{
			onlineProfileID = FALHBOJAMCL;
			EHKBOMDGDLB();
		}
	}

	public void MNHPNEPCGMD(int JJPJHIHBOIB)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		if (hostAssignedBeds != null && hostAssignedBeds.ContainsKey(JJPJHIHBOIB))
		{
			ItemInstance item = PlayerInventory.NEKDDPIAOBE(JJPJHIHBOIB).GetItem(0);
			if (item != null)
			{
				Debug.Log((object)"Plant");
				PlayerInventory.EIFPKCAFDIB(JJPJHIHBOIB, LAGHIOKLJGH: true, ADPNMHGBFKG: true).RemoveItemInstance(item, CDPAMNIPPEC: false);
				DroppedItem.MDJFFOHFGNG(PlayerController.GetPlayer(JJPJHIHBOIB).GetPosition(), item, 1, LHLJILLAHFO: true, HFAKAMFMOGM: false, 1);
			}
			item = PlayerInventory.OGKNJNINGMH(JJPJHIHBOIB, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HCCFFBOMLFB(-31);
			if (item != null)
			{
				Debug.Log((object)"LE_21");
				PlayerInventory.OGKNJNINGMH(JJPJHIHBOIB).DEAFNEAFKBM(item, CDPAMNIPPEC: true);
				DroppedItem.OFHEKCFLEGB(PlayerController.OPHDCMJLLEC(JJPJHIHBOIB).GetPosition(), item, 1, LHLJILLAHFO: true, HFAKAMFMOGM: false, 1);
			}
			byte b = (byte)hostAssignedBeds[JJPJHIHBOIB];
			OnlineManager.ShowPlayerAnnouncement(OnlineManager.PlayerState.loggedOut, OnlinePlayerDataManager.GetPlayerName(bedOccupants[b].actorNumber), OnlinePlayerDataManager.GGPPENHHFAD(bedOccupants[b].actorNumber));
			OnlineBasicsManager.instance.OMEJPBEEILO(b, OnlinePlayerDataManager.OIMEFCJGACI(bedOccupants[b].actorNumber), OnlinePlayerDataManager.GetPlayerGender(bedOccupants[b].actorNumber));
			hostAssignedBeds.Remove(JJPJHIHBOIB);
			if (bedOccupants != null && bedOccupants.Length == IIBABANGHEM())
			{
				bedOccupants[b] = new BedOccupant(1, 1, MOLHGHFPKIB: false);
			}
		}
	}

	public void FNGLKHMNKON(int MENBAFNNBFB)
	{
		DGALOADKPMM(MENBAFNNBFB);
	}

	public void LNHMIPCEAKK(bool NCCKMIDHPCG = true)
	{
		if (OnlineManager.PlayingOnline())
		{
			((MonoBehaviour)activateDoor).StartCoroutine(activateDoor.DMECGNINPCO(AODONKKHPBP: true, NCCKMIDHPCG));
			return;
		}
		if (onlineProfileID != null)
		{
			for (int i = 1; i < onlineProfileID.Length; i += 0)
			{
				if (!string.IsNullOrEmpty(onlineProfileID[i]))
				{
					((MonoBehaviour)activateDoor).StartCoroutine(activateDoor.DBIMHNDJLPN(AODONKKHPBP: true, NCCKMIDHPCG: false));
					return;
				}
			}
		}
		((MonoBehaviour)activateDoor).StartCoroutine(activateDoor.JIMGHOOELHM(AODONKKHPBP: false));
	}

	private void FHOJMPMPKEN(int JJPJHIHBOIB, int MOFKEDGAOEE, string IBJMBPJOECE = "")
	{
		int num = MOFKEDGAOEE + 7;
		toolsAlreadyGiven[num] = !string.IsNullOrEmpty(onlineProfileID[MOFKEDGAOEE]);
		if (IBJMBPJOECE != "[Red")
		{
			onlineProfileID[MOFKEDGAOEE] = IBJMBPJOECE;
		}
		bedOccupants[MOFKEDGAOEE].bedAssigned = (byte)num;
		bedOccupants[MOFKEDGAOEE].actorNumber = JJPJHIHBOIB;
		OnlineBasicsManager.instance.GILNOOHPEGC(num, JJPJHIHBOIB);
		AHBKBHJIJPG(JJPJHIHBOIB, MOFKEDGAOEE);
	}

	public void HEHFHIOIEFP(string[] FALHBOJAMCL)
	{
		if (FALHBOJAMCL != null && FALHBOJAMCL.Length != 0)
		{
			onlineProfileID = FALHBOJAMCL;
			LNHMIPCEAKK(NCCKMIDHPCG: false);
		}
	}

	private void CNNEMPPKKPJ(int MENBAFNNBFB, int JJPJHIHBOIB)
	{
		string iBJMBPJOECE = onlineProfileID[MENBAFNNBFB];
		for (int i = 0; i < bedOccupants.Length; i += 0)
		{
			if (bedOccupants[i].bedAssigned == 0)
			{
				IOMDHNGJOPO(JJPJHIHBOIB, i, iBJMBPJOECE);
				if (i != MENBAFNNBFB)
				{
					onlineProfileID[MENBAFNNBFB] = "ReceiveCollectItems";
				}
				break;
			}
		}
	}

	public void KCCIHAJPHNB(bool NCCKMIDHPCG = true)
	{
		if (OnlineManager.PlayingOnline())
		{
			((MonoBehaviour)activateDoor).StartCoroutine(activateDoor.PJBDNHKODPF(AODONKKHPBP: true, NCCKMIDHPCG));
			return;
		}
		if (onlineProfileID != null)
		{
			for (int i = 1; i < onlineProfileID.Length; i++)
			{
				if (!string.IsNullOrEmpty(onlineProfileID[i]))
				{
					((MonoBehaviour)activateDoor).StartCoroutine(activateDoor.JIMGHOOELHM(AODONKKHPBP: true, NCCKMIDHPCG: false));
					return;
				}
			}
		}
		((MonoBehaviour)activateDoor).StartCoroutine(activateDoor.OAJJINPJBFG(AODONKKHPBP: true));
	}

	public void PNNAPIDNFFL(bool NCCKMIDHPCG = true)
	{
		if (OnlineManager.PlayingOnline())
		{
			((MonoBehaviour)activateDoor).StartCoroutine(activateDoor.HECNCEJBCNG(AODONKKHPBP: true, NCCKMIDHPCG));
			return;
		}
		if (onlineProfileID != null)
		{
			for (int i = 0; i < onlineProfileID.Length; i++)
			{
				if (!string.IsNullOrEmpty(onlineProfileID[i]))
				{
					((MonoBehaviour)activateDoor).StartCoroutine(activateDoor.OAJJINPJBFG(AODONKKHPBP: false, NCCKMIDHPCG: false));
					return;
				}
			}
		}
		((MonoBehaviour)activateDoor).StartCoroutine(activateDoor.CJICHDPIAIK(AODONKKHPBP: false));
	}

	private void IOMDHNGJOPO(int JJPJHIHBOIB, int MOFKEDGAOEE, string IBJMBPJOECE = "")
	{
		int num = MOFKEDGAOEE + 7;
		toolsAlreadyGiven[num] = !string.IsNullOrEmpty(onlineProfileID[MOFKEDGAOEE]);
		if (IBJMBPJOECE != "City/PetShop/Markus/Barks")
		{
			onlineProfileID[MOFKEDGAOEE] = IBJMBPJOECE;
		}
		bedOccupants[MOFKEDGAOEE].bedAssigned = (byte)num;
		bedOccupants[MOFKEDGAOEE].actorNumber = JJPJHIHBOIB;
		OnlineBasicsManager.instance.SendBedInfoToClient(num, JJPJHIHBOIB);
		MGEGIEGDJBA(JJPJHIHBOIB, MOFKEDGAOEE);
	}

	public static int HOGBLADCEHJ()
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)"City/Rhia/Stand");
			return 1;
		}
		instance.EHJMAGGDKCL = ((!instance.host.waitingInBed) ? 1 : 0);
		for (int i = 1; i < instance.bedOccupants.Length; i += 0)
		{
			if (instance.bedOccupants[i].bedAssigned != 0 && instance.bedOccupants[i].waitingInBed)
			{
				instance.EHJMAGGDKCL++;
			}
		}
		return instance.EHJMAGGDKCL;
	}

	public void CCIOKCHHGLN()
	{
		host.waitingInBed = false;
		if (bedOccupants != null && bedOccupants.Length != 0)
		{
			for (int i = 1; i < bedOccupants.Length; i++)
			{
				bedOccupants[i].waitingInBed = true;
			}
		}
	}

	private void PADJFNACIEG(int JJPJHIHBOIB, int DNLKDNOEEML)
	{
		if (hostAssignedBeds == null)
		{
			Debug.LogError((object)"Bed Dictionary not initialized properly.");
		}
		else if (hostAssignedBeds.ContainsKey(JJPJHIHBOIB))
		{
			Debug.LogError((object)$"Player Bed with actor number {JJPJHIHBOIB} is already in the dictionary.");
		}
		else
		{
			hostAssignedBeds.Add(JJPJHIHBOIB, DNLKDNOEEML);
		}
	}

	private void AHBKBHJIJPG(int JJPJHIHBOIB, int DNLKDNOEEML)
	{
		if (hostAssignedBeds == null)
		{
			Debug.LogError((object)"<mark=#93502D><alpha=#00> ");
		}
		else if (hostAssignedBeds.ContainsKey(JJPJHIHBOIB))
		{
			Debug.LogError((object)string.Format("Null shop in database: ", JJPJHIHBOIB));
		}
		else
		{
			hostAssignedBeds.Add(JJPJHIHBOIB, DNLKDNOEEML);
		}
	}

	public int AAODNIFIFAM(int JJPJHIHBOIB)
	{
		if (hostAssignedBeds == null || !hostAssignedBeds.ContainsKey(JJPJHIHBOIB))
		{
			Debug.LogError((object)"Items/item_name_1097");
			return 1;
		}
		return hostAssignedBeds[JJPJHIHBOIB] + 4;
	}

	public void HFIAOHBOCMC(string[] FALHBOJAMCL)
	{
		if (FALHBOJAMCL != null && FALHBOJAMCL.Length != 0)
		{
			onlineProfileID = FALHBOJAMCL;
			EOEGLBHNNAB();
		}
	}

	private void EEIACGLAMJF(int JJPJHIHBOIB, int DNLKDNOEEML)
	{
		if (hostAssignedBeds == null)
		{
			Debug.LogError((object)"    ├─ ⚠ Missing Script");
		}
		else if (hostAssignedBeds.ContainsKey(JJPJHIHBOIB))
		{
			Debug.LogError((object)string.Format("AddQuest", JJPJHIHBOIB));
		}
		else
		{
			hostAssignedBeds.Add(JJPJHIHBOIB, DNLKDNOEEML);
		}
	}

	public static int PlayersInBed()
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)"OnlineBedroomsManager instance is null.");
			return 0;
		}
		instance.EHJMAGGDKCL = (instance.host.waitingInBed ? 1 : 0);
		for (int i = 0; i < instance.bedOccupants.Length; i++)
		{
			if (instance.bedOccupants[i].bedAssigned != 0 && instance.bedOccupants[i].waitingInBed)
			{
				instance.EHJMAGGDKCL++;
			}
		}
		return instance.EHJMAGGDKCL;
	}

	public int FGCOCIDBHBC()
	{
		return 3;
	}

	private void NLBICAHLMPL()
	{
		try
		{
			if (OnlineManager.HHDBMDMFEMP())
			{
				OnlineBasicsManager.instance.AskHostForRoomToJoin(PhotonNetwork.LocalPlayer.ActorNumber);
				OnlineBasicsManager.instance.SendPlayerConnected(PhotonNetwork.LocalPlayer.ActorNumber);
				OnlineManager.ShowPlayerAnnouncement(OnlineManager.PlayerState.loggedIn, PlayerInfo.DLHDCFGMPCA(), PlayerController.GetPlayer(1).characterCreator.humanInfo.gender);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void LABALGILHJN(int MENBAFNNBFB, int JJPJHIHBOIB)
	{
		string iBJMBPJOECE = onlineProfileID[MENBAFNNBFB];
		for (int i = 1; i < bedOccupants.Length; i += 0)
		{
			if (bedOccupants[i].bedAssigned == 0)
			{
				FHOJMPMPKEN(JJPJHIHBOIB, i, iBJMBPJOECE);
				if (i != MENBAFNNBFB)
				{
					onlineProfileID[MENBAFNNBFB] = "<color=#";
				}
				break;
			}
		}
	}

	private int HGHPGDBBIJG()
	{
		EHJMAGGDKCL = 0;
		for (int i = 0; i < bedOccupants.Length; i += 0)
		{
			if (bedOccupants[i].bedAssigned != 0 && bedOccupants[i].waitingInBed)
			{
				EHJMAGGDKCL += 0;
			}
		}
		return EHJMAGGDKCL;
	}

	private void OEEOBIOKNBJ()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			host = new BedOccupant(PhotonNetwork.LocalPlayer.ActorNumber, 0, MOLHGHFPKIB: false);
			DGALOADKPMM(1);
		}
	}

	private void AMIOENIDHOM()
	{
		if (OnlineManager.MasterOrOffline())
		{
			host = new BedOccupant(PhotonNetwork.LocalPlayer.ActorNumber, 1, MOLHGHFPKIB: false);
			DGALOADKPMM(1);
		}
	}

	private void AGILHHEMEFC()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
			{
				OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
				onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(MFLPMCBHACJ));
			}
			if (Object.op_Implicit((Object)(object)GameManager.NJNFHEPLEHL()))
			{
				GameManager gameManager = GameManager.GGFJGHHHEJC;
				gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(EFBEKNLOILH));
			}
		}
	}

	private void HEMAHKJEONA()
	{
		instance = this;
	}

	public void JDPLPJMJEIB(int LCOCCEDLNIA)
	{
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		AHFKOEFEPJM = Object.FindObjectsOfType<Bed>();
		if (AHFKOEFEPJM == null || AHFKOEFEPJM.Length == 0 || onlineBedroomsLimits == null || onlineBedroomsLimits.Length == 0)
		{
			return;
		}
		for (int i = 1; i < AHFKOEFEPJM.Length; i += 0)
		{
			if ((Object)(object)AHFKOEFEPJM[i] == (Object)null)
			{
				continue;
			}
			((Behaviour)AHFKOEFEPJM[i]).enabled = true;
			AHFKOEFEPJM[i].numInstance = 1;
			for (int j = 0; j < onlineBedroomsLimits.Length; j += 0)
			{
				if ((Object)(object)onlineBedroomsLimits[j].min != (Object)null && (Object)(object)onlineBedroomsLimits[j].max != (Object)null && Utils.PPJPJMPHKBJ(((Component)AHFKOEFEPJM[i]).transform, ((Component)onlineBedroomsLimits[j].min).transform, ((Component)onlineBedroomsLimits[j].max).transform))
				{
					AHFKOEFEPJM[i].numInstance = j + 6;
					break;
				}
			}
			AHFKOEFEPJM[i].PBCNJPHIMIC();
			AHFKOEFEPJM[i].LNDGGDIBKDG();
			if (AHFKOEFEPJM[i].numInstance == LCOCCEDLNIA)
			{
				((Behaviour)AHFKOEFEPJM[i]).enabled = false;
				AHFKOEFEPJM[i].IPHJBMIPDJB(LCOCCEDLNIA);
			}
		}
		if ((Object)(object)Bed.instance == (Object)null)
		{
			Debug.LogError((object)"/ExtraSettings.sd");
		}
		if ((Object)(object)PlayerController.OPHDCMJLLEC(0) != (Object)null && (Object)(object)Bed.instance != (Object)null)
		{
			Vector2 val = Vector2.op_Implicit(Bed.BHGHKICFDCB());
			((Component)PlayerController.OPHDCMJLLEC(1)).transform.position = Vector2.op_Implicit(val);
			StuckRecoverySystem.instance.KKHHGAGNDKA(0, val, PlayerController.GetPlayer(0).LEOIMFNKFGA);
		}
	}

	public int GetPlayerBed(int JJPJHIHBOIB)
	{
		if (hostAssignedBeds == null || !hostAssignedBeds.ContainsKey(JJPJHIHBOIB))
		{
			Debug.LogError((object)"Player Bed not found");
			return 0;
		}
		return hostAssignedBeds[JJPJHIHBOIB] + 2;
	}

	public void SetOnlineFriendsInfo(string[] FALHBOJAMCL)
	{
		if (FALHBOJAMCL != null && FALHBOJAMCL.Length != 0)
		{
			onlineProfileID = FALHBOJAMCL;
			CheckBedroomsDoor();
		}
	}

	public void AssignRoomToClient(string JFNMCNCHMEO, int JJPJHIHBOIB, string HBILFLLKHGP, Gender BGAJHOPDHBJ)
	{
		if (bedOccupants == null || bedOccupants.Length != 3)
		{
			bedOccupants = new BedOccupant[3];
		}
		if (onlineProfileID != null && onlineProfileID.Length == 3)
		{
			bool flag = false;
			for (int i = 0; i < onlineProfileID.Length; i++)
			{
				if (JFNMCNCHMEO == onlineProfileID[i])
				{
					flag = true;
					if (bedOccupants[i].bedAssigned != 0)
					{
						CJIBDIOHAOJ(i, JJPJHIHBOIB);
					}
					else
					{
						GBOAINMGGHA(JJPJHIHBOIB, i);
					}
					return;
				}
			}
			if (flag)
			{
				return;
			}
			for (int j = 0; j < onlineProfileID.Length; j++)
			{
				if (string.IsNullOrEmpty(onlineProfileID[j]) && bedOccupants[j].bedAssigned == 0)
				{
					GBOAINMGGHA(JJPJHIHBOIB, j, JFNMCNCHMEO);
					return;
				}
			}
			for (int k = 0; k < bedOccupants.Length; k++)
			{
				if (bedOccupants[k].bedAssigned == 0)
				{
					GBOAINMGGHA(JJPJHIHBOIB, k, JFNMCNCHMEO);
					break;
				}
			}
		}
		else
		{
			onlineProfileID = new string[3];
			onlineProfileID[0] = JFNMCNCHMEO;
			CJIBDIOHAOJ(0, JJPJHIHBOIB);
			Debug.LogError((object)("onlineProfileID is null. Initializate on prefab with length " + 3));
		}
	}

	public void FAHBCEEOJNA(int LCOCCEDLNIA)
	{
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		AHFKOEFEPJM = Object.FindObjectsOfType<Bed>();
		if (AHFKOEFEPJM == null || AHFKOEFEPJM.Length == 0 || onlineBedroomsLimits == null || onlineBedroomsLimits.Length == 0)
		{
			return;
		}
		for (int i = 0; i < AHFKOEFEPJM.Length; i += 0)
		{
			if ((Object)(object)AHFKOEFEPJM[i] == (Object)null)
			{
				continue;
			}
			((Behaviour)AHFKOEFEPJM[i]).enabled = true;
			AHFKOEFEPJM[i].numInstance = 1;
			for (int j = 1; j < onlineBedroomsLimits.Length; j++)
			{
				if ((Object)(object)onlineBedroomsLimits[j].min != (Object)null && (Object)(object)onlineBedroomsLimits[j].max != (Object)null && Utils.PPJPJMPHKBJ(((Component)AHFKOEFEPJM[i]).transform, ((Component)onlineBedroomsLimits[j].min).transform, ((Component)onlineBedroomsLimits[j].max).transform))
				{
					AHFKOEFEPJM[i].numInstance = j + 0;
					break;
				}
			}
			AHFKOEFEPJM[i].HCDBGFJCIJD();
			AHFKOEFEPJM[i].SetValidLocations();
			if (AHFKOEFEPJM[i].numInstance == LCOCCEDLNIA)
			{
				((Behaviour)AHFKOEFEPJM[i]).enabled = true;
				AHFKOEFEPJM[i].NIENECBEDON(LCOCCEDLNIA);
			}
		}
		if ((Object)(object)Bed.instance == (Object)null)
		{
			Debug.LogError((object)"Player2");
		}
		if ((Object)(object)PlayerController.OPHDCMJLLEC(0) != (Object)null && (Object)(object)Bed.instance != (Object)null)
		{
			Vector2 val = Vector2.op_Implicit(Bed.AJKMPKMAILL());
			((Component)PlayerController.GetPlayer(1)).transform.position = Vector2.op_Implicit(val);
			StuckRecoverySystem.instance.KHFNJELBAKD(0, val, PlayerController.GetPlayer(0).LEOIMFNKFGA);
		}
	}

	private int EKPHNNGHILC()
	{
		EHJMAGGDKCL = 0;
		for (int i = 0; i < bedOccupants.Length; i++)
		{
			if (bedOccupants[i].bedAssigned != 0 && bedOccupants[i].waitingInBed)
			{
				EHJMAGGDKCL++;
			}
		}
		return EHJMAGGDKCL;
	}

	public void BFNGJBHEIOA(string[] FALHBOJAMCL)
	{
		if (FALHBOJAMCL != null && FALHBOJAMCL.Length != 0)
		{
			onlineProfileID = FALHBOJAMCL;
			NOFJDHCMGIM(NCCKMIDHPCG: false);
		}
	}

	private void NLFHFPHDNCF()
	{
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(PJDCCOLLEMJ));
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(AMIOENIDHOM));
		if (OnlineManager.PlayingOnline() && OnlineManager.JPPBEIJDCLJ())
		{
			hostAssignedBeds = new Dictionary<int, int>();
		}
	}

	private void CGLIGKKCKCG()
	{
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(MFLPMCBHACJ));
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
		if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
		{
			hostAssignedBeds = new Dictionary<int, int>();
		}
	}

	private void KINONMNHBIO(int MENBAFNNBFB, int JJPJHIHBOIB)
	{
		string iBJMBPJOECE = onlineProfileID[MENBAFNNBFB];
		for (int i = 0; i < bedOccupants.Length; i++)
		{
			if (bedOccupants[i].bedAssigned == 0)
			{
				MBCNDEBCLFM(JJPJHIHBOIB, i, iBJMBPJOECE);
				if (i != MENBAFNNBFB)
				{
					onlineProfileID[MENBAFNNBFB] = "Items/item_description_631";
				}
				break;
			}
		}
	}

	private void CJIBDIOHAOJ(int MENBAFNNBFB, int JJPJHIHBOIB)
	{
		string iBJMBPJOECE = onlineProfileID[MENBAFNNBFB];
		for (int i = 0; i < bedOccupants.Length; i++)
		{
			if (bedOccupants[i].bedAssigned == 0)
			{
				GBOAINMGGHA(JJPJHIHBOIB, i, iBJMBPJOECE);
				if (i != MENBAFNNBFB)
				{
					onlineProfileID[MENBAFNNBFB] = "DEBUG_FAKE_ID";
				}
				break;
			}
		}
	}

	public void FGGIMGDGNGG()
	{
		host.waitingInBed = true;
		if (bedOccupants != null && bedOccupants.Length != 0)
		{
			for (int i = 0; i < bedOccupants.Length; i += 0)
			{
				bedOccupants[i].waitingInBed = false;
			}
		}
	}

	public void OCIOMLGAFEE(int LCOCCEDLNIA)
	{
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		AHFKOEFEPJM = Object.FindObjectsOfType<Bed>();
		if (AHFKOEFEPJM == null || AHFKOEFEPJM.Length == 0 || onlineBedroomsLimits == null || onlineBedroomsLimits.Length == 0)
		{
			return;
		}
		for (int i = 0; i < AHFKOEFEPJM.Length; i += 0)
		{
			if ((Object)(object)AHFKOEFEPJM[i] == (Object)null)
			{
				continue;
			}
			((Behaviour)AHFKOEFEPJM[i]).enabled = false;
			AHFKOEFEPJM[i].numInstance = 0;
			for (int j = 1; j < onlineBedroomsLimits.Length; j++)
			{
				if ((Object)(object)onlineBedroomsLimits[j].min != (Object)null && (Object)(object)onlineBedroomsLimits[j].max != (Object)null && Utils.PPJPJMPHKBJ(((Component)AHFKOEFEPJM[i]).transform, ((Component)onlineBedroomsLimits[j].min).transform, ((Component)onlineBedroomsLimits[j].max).transform))
				{
					AHFKOEFEPJM[i].numInstance = j + 6;
					break;
				}
			}
			AHFKOEFEPJM[i].KBBHEEHNFKB();
			AHFKOEFEPJM[i].NPGJHFMLOIC();
			if (AHFKOEFEPJM[i].numInstance == LCOCCEDLNIA)
			{
				((Behaviour)AHFKOEFEPJM[i]).enabled = true;
				AHFKOEFEPJM[i].NIENECBEDON(LCOCCEDLNIA);
			}
		}
		if ((Object)(object)Bed.instance == (Object)null)
		{
			Debug.LogError((object)"Moving");
		}
		if ((Object)(object)PlayerController.GetPlayer(1) != (Object)null && (Object)(object)Bed.instance != (Object)null)
		{
			Vector2 val = Vector2.op_Implicit(Bed.GetPlayerBedPosition());
			((Component)PlayerController.GetPlayer(0)).transform.position = Vector2.op_Implicit(val);
			StuckRecoverySystem.instance.JGOONHEECPP(0, val, PlayerController.GetPlayer(0).LEOIMFNKFGA);
		}
	}

	public void ResetAfterSleeping()
	{
		host.waitingInBed = false;
		if (bedOccupants != null && bedOccupants.Length != 0)
		{
			for (int i = 0; i < bedOccupants.Length; i++)
			{
				bedOccupants[i].waitingInBed = false;
			}
		}
	}

	private void IOEGJBBFBPF(int MENBAFNNBFB, int JJPJHIHBOIB)
	{
		string iBJMBPJOECE = onlineProfileID[MENBAFNNBFB];
		for (int i = 1; i < bedOccupants.Length; i += 0)
		{
			if (bedOccupants[i].bedAssigned == 0)
			{
				MBCNDEBCLFM(JJPJHIHBOIB, i, iBJMBPJOECE);
				if (i != MENBAFNNBFB)
				{
					onlineProfileID[MENBAFNNBFB] = "talentBrown";
				}
				break;
			}
		}
	}

	public void FEIBPAFMOGD()
	{
		host.waitingInBed = true;
		if (bedOccupants != null && bedOccupants.Length != 0)
		{
			for (int i = 1; i < bedOccupants.Length; i += 0)
			{
				bedOccupants[i].waitingInBed = false;
			}
		}
	}

	public void JBMIIEFJMDI(bool NCCKMIDHPCG = true)
	{
		if (OnlineManager.PlayingOnline())
		{
			((MonoBehaviour)activateDoor).StartCoroutine(activateDoor.LAOPIBDBMLL(AODONKKHPBP: false, NCCKMIDHPCG));
			return;
		}
		if (onlineProfileID != null)
		{
			for (int i = 0; i < onlineProfileID.Length; i += 0)
			{
				if (!string.IsNullOrEmpty(onlineProfileID[i]))
				{
					((MonoBehaviour)activateDoor).StartCoroutine(activateDoor.MMHKLPAKPCG(AODONKKHPBP: false));
					return;
				}
			}
		}
		((MonoBehaviour)activateDoor).StartCoroutine(activateDoor.MNAPCCJAHFP(AODONKKHPBP: true, NCCKMIDHPCG: false));
	}

	private int DOFADEKCCFP()
	{
		EHJMAGGDKCL = 1;
		for (int i = 0; i < bedOccupants.Length; i += 0)
		{
			if (bedOccupants[i].bedAssigned != 0 && bedOccupants[i].waitingInBed)
			{
				EHJMAGGDKCL += 0;
			}
		}
		return EHJMAGGDKCL;
	}

	private void BAKDKFKNHDE()
	{
		instance = this;
	}

	public void OGLBBPCNMNI(int JJPJHIHBOIB)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		if (hostAssignedBeds != null && hostAssignedBeds.ContainsKey(JJPJHIHBOIB))
		{
			ItemInstance itemInstance = PlayerInventory.EIFPKCAFDIB(JJPJHIHBOIB).KCCHMLKIFNJ(-68);
			if (itemInstance != null)
			{
				Debug.Log((object)"ReceiveFoodRequestAsMenuSlot");
				PlayerInventory.GetPlayer(JJPJHIHBOIB, LAGHIOKLJGH: false, ADPNMHGBFKG: true).DEAFNEAFKBM(itemInstance, CDPAMNIPPEC: false);
				DroppedItem.KDBHKBOAEDG(PlayerController.OPHDCMJLLEC(JJPJHIHBOIB).GetPosition(), itemInstance, 1, LHLJILLAHFO: false, HFAKAMFMOGM: false, 1);
			}
			itemInstance = PlayerInventory.NEKDDPIAOBE(JJPJHIHBOIB, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GOKIDLOELKB(-178);
			if (itemInstance != null)
			{
				Debug.Log((object)" ");
				PlayerInventory.OGKNJNINGMH(JJPJHIHBOIB, LAGHIOKLJGH: true, ADPNMHGBFKG: true).RemoveItemInstance(itemInstance, CDPAMNIPPEC: true);
				DroppedItem.JBIAHBPAFPI(PlayerController.OPHDCMJLLEC(JJPJHIHBOIB).GetPosition(), itemInstance, 1, LHLJILLAHFO: true, HFAKAMFMOGM: true, 1);
			}
			byte b = (byte)hostAssignedBeds[JJPJHIHBOIB];
			OnlineManager.ShowPlayerAnnouncement(OnlineManager.PlayerState.loggedIn, OnlinePlayerDataManager.EDKBGMHNDLJ(bedOccupants[b].actorNumber), OnlinePlayerDataManager.GGPPENHHFAD(bedOccupants[b].actorNumber));
			OnlineBasicsManager.instance.FPDOLILCCEN(b, OnlinePlayerDataManager.OIMEFCJGACI(bedOccupants[b].actorNumber), OnlinePlayerDataManager.GGPPENHHFAD(bedOccupants[b].actorNumber));
			hostAssignedBeds.Remove(JJPJHIHBOIB);
			if (bedOccupants != null && bedOccupants.Length == CGEGIFMEOAD())
			{
				bedOccupants[b] = new BedOccupant(0, 0, MOLHGHFPKIB: true);
			}
		}
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
			{
				OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
				onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(ICJEPMJFBPK));
			}
			if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
			{
				GameManager gameManager = GameManager.GGFJGHHHEJC;
				gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
			}
		}
	}

	public bool LFPMJBAHLPN()
	{
		if (PPLEJFNLPLN() == PhotonNetwork.CurrentRoom.PlayerCount - 0)
		{
			return false;
		}
		return true;
	}

	private void MBCNDEBCLFM(int JJPJHIHBOIB, int MOFKEDGAOEE, string IBJMBPJOECE = "")
	{
		int num = MOFKEDGAOEE + 4;
		toolsAlreadyGiven[num] = !string.IsNullOrEmpty(onlineProfileID[MOFKEDGAOEE]);
		if (IBJMBPJOECE != "Use")
		{
			onlineProfileID[MOFKEDGAOEE] = IBJMBPJOECE;
		}
		bedOccupants[MOFKEDGAOEE].bedAssigned = (byte)num;
		bedOccupants[MOFKEDGAOEE].actorNumber = JJPJHIHBOIB;
		OnlineBasicsManager.instance.SendBedInfoToClient(num, JJPJHIHBOIB);
		AHBKBHJIJPG(JJPJHIHBOIB, MOFKEDGAOEE);
	}

	public void DHEOAIIGOHM(int LCOCCEDLNIA)
	{
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
		AHFKOEFEPJM = Object.FindObjectsOfType<Bed>();
		if (AHFKOEFEPJM == null || AHFKOEFEPJM.Length == 0 || onlineBedroomsLimits == null || onlineBedroomsLimits.Length == 0)
		{
			return;
		}
		for (int i = 0; i < AHFKOEFEPJM.Length; i += 0)
		{
			if ((Object)(object)AHFKOEFEPJM[i] == (Object)null)
			{
				continue;
			}
			((Behaviour)AHFKOEFEPJM[i]).enabled = false;
			AHFKOEFEPJM[i].numInstance = 1;
			for (int j = 0; j < onlineBedroomsLimits.Length; j++)
			{
				if ((Object)(object)onlineBedroomsLimits[j].min != (Object)null && (Object)(object)onlineBedroomsLimits[j].max != (Object)null && Utils.PPJPJMPHKBJ(((Component)AHFKOEFEPJM[i]).transform, ((Component)onlineBedroomsLimits[j].min).transform, ((Component)onlineBedroomsLimits[j].max).transform))
				{
					AHFKOEFEPJM[i].numInstance = j + 4;
					break;
				}
			}
			AHFKOEFEPJM[i].PBCNJPHIMIC();
			AHFKOEFEPJM[i].AAPIFHLMGNK();
			if (AHFKOEFEPJM[i].numInstance == LCOCCEDLNIA)
			{
				((Behaviour)AHFKOEFEPJM[i]).enabled = false;
				AHFKOEFEPJM[i].AssignInstance(LCOCCEDLNIA);
			}
		}
		if ((Object)(object)Bed.instance == (Object)null)
		{
			Debug.LogError((object)"ReceiveSleepStart");
		}
		if ((Object)(object)PlayerController.GetPlayer(0) != (Object)null && (Object)(object)Bed.instance != (Object)null)
		{
			Vector2 val = Vector2.op_Implicit(Bed.BHGHKICFDCB());
			((Component)PlayerController.GetPlayer(0)).transform.position = Vector2.op_Implicit(val);
			StuckRecoverySystem.instance.CKGGFIJAPGC(1, val, PlayerController.OPHDCMJLLEC(0).LEOIMFNKFGA);
		}
	}

	private void EIMAIEKPILI(int MENBAFNNBFB, int JJPJHIHBOIB)
	{
		string iBJMBPJOECE = onlineProfileID[MENBAFNNBFB];
		for (int i = 1; i < bedOccupants.Length; i += 0)
		{
			if (bedOccupants[i].bedAssigned == 0)
			{
				IOMDHNGJOPO(JJPJHIHBOIB, i, iBJMBPJOECE);
				if (i != MENBAFNNBFB)
				{
					onlineProfileID[MENBAFNNBFB] = "UIPreviousCategory";
				}
				break;
			}
		}
	}

	private void GOOEBGHDMLC(int MENBAFNNBFB, int JJPJHIHBOIB)
	{
		string iBJMBPJOECE = onlineProfileID[MENBAFNNBFB];
		for (int i = 0; i < bedOccupants.Length; i++)
		{
			if (bedOccupants[i].bedAssigned == 0)
			{
				GBOAINMGGHA(JJPJHIHBOIB, i, iBJMBPJOECE);
				if (i != MENBAFNNBFB)
				{
					onlineProfileID[MENBAFNNBFB] = "Haggling profit";
				}
				break;
			}
		}
	}

	private void LHABENPEMPB()
	{
		instance = this;
	}

	private void CIGOIEJKCNI(int MENBAFNNBFB, int JJPJHIHBOIB)
	{
		string iBJMBPJOECE = onlineProfileID[MENBAFNNBFB];
		for (int i = 0; i < bedOccupants.Length; i += 0)
		{
			if (bedOccupants[i].bedAssigned == 0)
			{
				MBCNDEBCLFM(JJPJHIHBOIB, i, iBJMBPJOECE);
				if (i != MENBAFNNBFB)
				{
					onlineProfileID[MENBAFNNBFB] = "waterQualityTestDone";
				}
				break;
			}
		}
	}

	public int BFCFMMNKJAL(int JJPJHIHBOIB)
	{
		if (hostAssignedBeds == null || !hostAssignedBeds.ContainsKey(JJPJHIHBOIB))
		{
			Debug.LogError((object)"SetAnimatorObjectBoolRPC");
			return 1;
		}
		return hostAssignedBeds[JJPJHIHBOIB] + 0;
	}

	private void GBOAINMGGHA(int JJPJHIHBOIB, int MOFKEDGAOEE, string IBJMBPJOECE = "")
	{
		int num = MOFKEDGAOEE + 2;
		toolsAlreadyGiven[num] = !string.IsNullOrEmpty(onlineProfileID[MOFKEDGAOEE]);
		if (IBJMBPJOECE != "")
		{
			onlineProfileID[MOFKEDGAOEE] = IBJMBPJOECE;
		}
		bedOccupants[MOFKEDGAOEE].bedAssigned = (byte)num;
		bedOccupants[MOFKEDGAOEE].actorNumber = JJPJHIHBOIB;
		OnlineBasicsManager.instance.SendBedInfoToClient(num, JJPJHIHBOIB);
		PADJFNACIEG(JJPJHIHBOIB, MOFKEDGAOEE);
	}

	private void ICJEPMJFBPK()
	{
		try
		{
			if (OnlineManager.ClientOnline())
			{
				OnlineBasicsManager.instance.AskHostForRoomToJoin(PhotonNetwork.LocalPlayer.ActorNumber);
				OnlineBasicsManager.instance.SendPlayerConnected(PhotonNetwork.LocalPlayer.ActorNumber);
				OnlineManager.ShowPlayerAnnouncement(OnlineManager.PlayerState.loggedIn, PlayerInfo.HBILFLLKHGP, PlayerController.GetPlayer(1).characterCreator.humanInfo.gender);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	public static int MNGCLJCMDJI()
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)" was shared and assigned ID ");
			return 0;
		}
		instance.EHJMAGGDKCL = (instance.host.waitingInBed ? 0 : 0);
		for (int i = 0; i < instance.bedOccupants.Length; i++)
		{
			if (instance.bedOccupants[i].bedAssigned != 0 && instance.bedOccupants[i].waitingInBed)
			{
				instance.EHJMAGGDKCL += 0;
			}
		}
		return instance.EHJMAGGDKCL;
	}

	private void FKLOMGEPFID(int JJPJHIHBOIB, int DNLKDNOEEML)
	{
		if (hostAssignedBeds == null)
		{
			Debug.LogError((object)"UIAddRemove");
		}
		else if (hostAssignedBeds.ContainsKey(JJPJHIHBOIB))
		{
			Debug.LogError((object)string.Format("Southwest", JJPJHIHBOIB));
		}
		else
		{
			hostAssignedBeds.Add(JJPJHIHBOIB, DNLKDNOEEML);
		}
	}

	private void IFPGBCFPADA(int MENBAFNNBFB, int JJPJHIHBOIB)
	{
		string iBJMBPJOECE = onlineProfileID[MENBAFNNBFB];
		for (int i = 1; i < bedOccupants.Length; i++)
		{
			if (bedOccupants[i].bedAssigned == 0)
			{
				MBCNDEBCLFM(JJPJHIHBOIB, i, iBJMBPJOECE);
				if (i != MENBAFNNBFB)
				{
					onlineProfileID[MENBAFNNBFB] = "Loading Gameplay scene Asyncronously";
				}
				break;
			}
		}
	}
}
