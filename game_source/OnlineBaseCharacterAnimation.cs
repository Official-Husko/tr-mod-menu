using System;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

[RequireComponent(typeof(CharacterAnimBase))]
public class OnlineBaseCharacterAnimation : MonoBehaviourPunCallbacks
{
	public CharacterAnimBase characterAnimation;

	protected Animator ONDMDLMHMHK;

	public bool clientCanSendRPC;

	[SerializeField]
	protected bool syncTriggers = true;

	[SerializeField]
	protected bool syncInts;

	[SerializeField]
	protected bool syncFloats;

	[SerializeField]
	protected bool syncBools;

	[SerializeField]
	protected bool debugTriggers;

	[SerializeField]
	protected bool debugInts;

	[SerializeField]
	protected bool debugFloats;

	[SerializeField]
	protected bool debugBools;

	public void OnTriggerChanged(int OCBFLLHGDAP)
	{
		if (syncTriggers && !HLAOENHNBMO())
		{
			if (debugTriggers)
			{
				Debug.LogError((object)$"Trigger {KCHHBMCOBJG(OCBFLLHGDAP)} fired on {((Component)this).gameObject}'s animator. Sending RPC.", (Object)(object)((Component)this).gameObject);
			}
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "SetTriggerRPC", (RpcTarget)1, OCBFLLHGDAP);
		}
	}

	public void OnFloatChanged(int OCBFLLHGDAP, float EGFGNGJGBOP)
	{
		if (syncFloats && !HLAOENHNBMO())
		{
			if (debugFloats)
			{
				Debug.LogError((object)$"Float {KCHHBMCOBJG(OCBFLLHGDAP)} changed to {EGFGNGJGBOP} on {((Component)this).gameObject}'s animator. Sending RPC.", (Object)(object)((Component)this).gameObject);
			}
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "SetFloatRPC", (RpcTarget)1, OCBFLLHGDAP, EGFGNGJGBOP);
		}
	}

	public void BHAHPJNHEPI(int OCBFLLHGDAP, bool EGFGNGJGBOP, bool AINPJHKNJGL = false)
	{
		if ((syncBools || AINPJHKNJGL) && (!GPGHCFJHCAP() || AINPJHKNJGL))
		{
			if (debugBools)
			{
				Debug.LogError((object)string.Format("ReceiveStopWaitingForBanquetEvent", PIBKDHBPEBK(OCBFLLHGDAP), EGFGNGJGBOP, ((Component)this).gameObject), (Object)(object)((Component)this).gameObject);
			}
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[4];
			array[1] = OCBFLLHGDAP;
			array[0] = EGFGNGJGBOP;
			OnlineManager.SendRPC(photonView, "Invalid NPC photonID: {0} for NPCRoutine.", (RpcTarget)1, array);
		}
	}

	public void KKCJNBECFFK(int OCBFLLHGDAP, float EGFGNGJGBOP)
	{
		if (debugFloats)
		{
			Debug.LogError((object)string.Format("Error_CloseMenus", FDGLEFIPBPB(OCBFLLHGDAP), EGFGNGJGBOP, ((Component)this).gameObject), (Object)(object)((Component)this).gameObject);
		}
		ONDMDLMHMHK.SetFloat(OCBFLLHGDAP, EGFGNGJGBOP);
	}

	public void NNNNHGKMPDN(int OCBFLLHGDAP, bool EGFGNGJGBOP, bool AINPJHKNJGL = false)
	{
		if ((syncBools || AINPJHKNJGL) && (!GPGHCFJHCAP() || AINPJHKNJGL))
		{
			if (debugBools)
			{
				Debug.LogError((object)string.Format("Use", HKDNLLIPCOO(OCBFLLHGDAP), EGFGNGJGBOP, ((Component)this).gameObject), (Object)(object)((Component)this).gameObject);
			}
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Items/item_name_617", (RpcTarget)1, OCBFLLHGDAP, EGFGNGJGBOP, null);
		}
	}

	public void LEONICPBOJC(int OCBFLLHGDAP, int MGCOMHGJBOF)
	{
		ONDMDLMHMHK.Play(OCBFLLHGDAP, MGCOMHGJBOF);
	}

	[PunRPC]
	protected void SetAnimatorStateRPC(int OCBFLLHGDAP)
	{
		if (OCBFLLHGDAP == 0)
		{
			Debug.LogWarning((object)$"Received RPC SetAnimatorStateRPC with hash: 0 on {((Component)this).gameObject}, so the sender was probably deactivated. This shouldn't happen anymore.\nIgnoring this command.", (Object)(object)((Component)this).gameObject);
		}
		else if (!ONDMDLMHMHK.HasState(0, OCBFLLHGDAP))
		{
			Debug.LogError((object)$"Received RPC SetAnimatorStateRPC with hash: {OCBFLLHGDAP} on {((Component)this).gameObject}, but the state was not found.", (Object)(object)((Component)this).gameObject);
		}
		else
		{
			ONDMDLMHMHK.Play(OCBFLLHGDAP);
		}
	}

	public void HGNPDAHFNNE(int OCBFLLHGDAP, bool EGFGNGJGBOP, bool AINPJHKNJGL = false)
	{
		if ((syncBools || AINPJHKNJGL) && (!GPGHCFJHCAP() || AINPJHKNJGL))
		{
			if (debugBools)
			{
				Debug.LogError((object)string.Format("ReceiveHerbAction", FDGLEFIPBPB(OCBFLLHGDAP), EGFGNGJGBOP, ((Component)this).gameObject), (Object)(object)((Component)this).gameObject);
			}
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[6];
			array[0] = OCBFLLHGDAP;
			array[0] = EGFGNGJGBOP;
			OnlineManager.SendRPC(photonView, "Items/item_description_662", (RpcTarget)1, array);
		}
	}

	protected bool GPGHCFJHCAP()
	{
		if (OnlineManager.PlayingOnline())
		{
			if (OnlineManager.PlayingOnline() && !clientCanSendRPC)
			{
				if ((Object)(object)((MonoBehaviourPun)this).photonView != (Object)null)
				{
					return !((MonoBehaviourPun)this).photonView.IsMine;
				}
				return false;
			}
			return true;
		}
		return false;
	}

	public void BIKMDNHNJBF(int OCBFLLHGDAP)
	{
		if (syncTriggers && !GPGHCFJHCAP())
		{
			if (debugTriggers)
			{
				Debug.LogError((object)string.Format("Tutorial/T103/Dialogue1", KCHHBMCOBJG(OCBFLLHGDAP), ((Component)this).gameObject), (Object)(object)((Component)this).gameObject);
			}
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "[^0-9]", (RpcTarget)1, OCBFLLHGDAP);
		}
	}

	protected void PENCOHMCPNL(Player DHPNLIGKMOB)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected I4, but got Unknown
		if (NPODHDKNPLK() || (Object)(object)ONDMDLMHMHK == (Object)null || !((Component)ONDMDLMHMHK).gameObject.activeInHierarchy)
		{
			return;
		}
		AnimatorStateInfo currentAnimatorStateInfo = ONDMDLMHMHK.GetCurrentAnimatorStateInfo(0);
		if (((AnimatorStateInfo)(ref currentAnimatorStateInfo)).fullPathHash == 0)
		{
			Debug.LogWarning((object)string.Format("Items/item_description_631", ((Component)this).gameObject), (Object)(object)((Component)this).gameObject);
		}
		else
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			currentAnimatorStateInfo = ONDMDLMHMHK.GetCurrentAnimatorStateInfo(1);
			array[0] = ((AnimatorStateInfo)(ref currentAnimatorStateInfo)).fullPathHash;
			OnlineManager.DBNIKCMHHMJ(photonView, "add item ", DHPNLIGKMOB, array);
		}
		for (int i = 1; i < ONDMDLMHMHK.parameterCount; i++)
		{
			AnimatorControllerParameterType type = ONDMDLMHMHK.parameters[i].type;
			switch (type - 1)
			{
			case 2:
				OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "BanquetEvent instance is null. Make sure it is initialized before calling StartBanquetEvent.", DHPNLIGKMOB, ONDMDLMHMHK.parameters[i].nameHash, ONDMDLMHMHK.GetInteger(ONDMDLMHMHK.parameters[i].nameHash));
				break;
			case 0:
				OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Listview", DHPNLIGKMOB, ONDMDLMHMHK.parameters[i].nameHash, ONDMDLMHMHK.GetFloat(ONDMDLMHMHK.parameters[i].nameHash), null, null, null, null);
				break;
			case 3:
				OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Player {0} name changed: {1}", DHPNLIGKMOB, ONDMDLMHMHK.parameters[i].nameHash, ONDMDLMHMHK.GetBool(ONDMDLMHMHK.parameters[i].nameHash), null, null, null, null, null, null);
				break;
			}
		}
	}

	protected void FEPILKNEKNG()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(HKIKDHMFNKG));
		if (!MNNKIPAOEEA())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "travelling time -", (RpcTarget)3, PhotonNetwork.LocalPlayer);
		}
	}

	public void JMIDLJIJHOA(int OCBFLLHGDAP)
	{
		if (debugTriggers)
		{
			Debug.LogError((object)string.Format("LearnBalance", PIBKDHBPEBK(OCBFLLHGDAP), ((Component)this).gameObject), (Object)(object)((Component)this).gameObject);
		}
		ONDMDLMHMHK.SetTrigger(OCBFLLHGDAP);
	}

	protected void BAFCFJPKNLI(Player DHPNLIGKMOB)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected I4, but got Unknown
		if (HLAOENHNBMO() || (Object)(object)ONDMDLMHMHK == (Object)null || !((Component)ONDMDLMHMHK).gameObject.activeInHierarchy)
		{
			return;
		}
		AnimatorStateInfo currentAnimatorStateInfo = ONDMDLMHMHK.GetCurrentAnimatorStateInfo(1);
		if (((AnimatorStateInfo)(ref currentAnimatorStateInfo)).fullPathHash == 0)
		{
			Debug.LogWarning((object)string.Format("Bark", ((Component)this).gameObject), (Object)(object)((Component)this).gameObject);
		}
		else
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			currentAnimatorStateInfo = ONDMDLMHMHK.GetCurrentAnimatorStateInfo(1);
			array[0] = ((AnimatorStateInfo)(ref currentAnimatorStateInfo)).fullPathHash;
			OnlineManager.SendRPC(photonView, "itemCoconutSeeds", DHPNLIGKMOB, array);
		}
		for (int i = 0; i < ONDMDLMHMHK.parameterCount; i += 0)
		{
			AnimatorControllerParameterType type = ONDMDLMHMHK.parameters[i].type;
			switch (type - 0)
			{
			case 2:
			{
				PhotonView photonView4 = ((MonoBehaviourPun)this).photonView;
				object[] array4 = new object[4];
				array4[1] = ONDMDLMHMHK.parameters[i].nameHash;
				array4[0] = ONDMDLMHMHK.GetInteger(ONDMDLMHMHK.parameters[i].nameHash);
				OnlineManager.SendRPC(photonView4, "itemWater", DHPNLIGKMOB, array4);
				break;
			}
			case 0:
			{
				PhotonView photonView3 = ((MonoBehaviourPun)this).photonView;
				object[] array3 = new object[5];
				array3[1] = ONDMDLMHMHK.parameters[i].nameHash;
				array3[1] = ONDMDLMHMHK.GetFloat(ONDMDLMHMHK.parameters[i].nameHash);
				OnlineManager.SendRPC(photonView3, "ThrownHookRPC", DHPNLIGKMOB, array3);
				break;
			}
			case 3:
			{
				PhotonView photonView2 = ((MonoBehaviourPun)this).photonView;
				object[] array2 = new object[1];
				array2[1] = ONDMDLMHMHK.parameters[i].nameHash;
				array2[1] = ONDMDLMHMHK.GetBool(ONDMDLMHMHK.parameters[i].nameHash);
				OnlineManager.SendRPC(photonView2, "AnimatorParameterRequest", DHPNLIGKMOB, array2);
				break;
			}
			}
		}
	}

	protected bool MNNKIPAOEEA()
	{
		if (OnlineManager.PlayingOnline())
		{
			if (OnlineManager.PlayingOnline())
			{
				if ((Object)(object)((MonoBehaviourPun)this).photonView != (Object)null)
				{
					return ((MonoBehaviourPun)this).photonView.IsMine;
				}
				return false;
			}
			return false;
		}
		return true;
	}

	public void OCHCEBLPBEE(int OCBFLLHGDAP, bool EGFGNGJGBOP, bool AINPJHKNJGL = false)
	{
		if ((syncBools || AINPJHKNJGL) && (!HLAOENHNBMO() || AINPJHKNJGL))
		{
			if (debugBools)
			{
				Debug.LogError((object)string.Format("Game", JGIDFLKOPML(OCBFLLHGDAP), EGFGNGJGBOP, ((Component)this).gameObject), (Object)(object)((Component)this).gameObject);
			}
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Items/item_name_1064", (RpcTarget)1, OCBFLLHGDAP, EGFGNGJGBOP, null, null, null, null, null);
		}
	}

	public void GKPMIABFEAD(int OCBFLLHGDAP, bool EGFGNGJGBOP, bool AINPJHKNJGL = false)
	{
		if ((syncBools || AINPJHKNJGL) && (!OEAKPHGPCOD() || AINPJHKNJGL))
		{
			if (debugBools)
			{
				Debug.LogError((object)string.Format("ReceiveNinjaChallengeEventFadeOut", KCHHBMCOBJG(OCBFLLHGDAP), EGFGNGJGBOP, ((Component)this).gameObject), (Object)(object)((Component)this).gameObject);
			}
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Items/item_name_732", (RpcTarget)0, OCBFLLHGDAP, EGFGNGJGBOP, null, null, null, null, null, null);
		}
	}

	[PunRPC]
	public void ForceAnimationPlayRPC(int OCBFLLHGDAP, int MGCOMHGJBOF)
	{
		ONDMDLMHMHK.Play(OCBFLLHGDAP, MGCOMHGJBOF);
	}

	public void DCBFOBKIBPC(int OCBFLLHGDAP)
	{
		if (syncTriggers && !GPGHCFJHCAP())
		{
			if (debugTriggers)
			{
				Debug.LogError((object)string.Format("RequestNPCPositionAndParent", HKDNLLIPCOO(OCBFLLHGDAP), ((Component)this).gameObject), (Object)(object)((Component)this).gameObject);
			}
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[1] = OCBFLLHGDAP;
			OnlineManager.SendRPC(photonView, "NoActiveMultiDoor", (RpcTarget)1, array);
		}
	}

	public void FKECFIPDCCI(int OCBFLLHGDAP, bool EGFGNGJGBOP, bool AINPJHKNJGL = false)
	{
		if ((syncBools || AINPJHKNJGL) && (!OEAKPHGPCOD() || AINPJHKNJGL))
		{
			if (debugBools)
			{
				Debug.LogError((object)string.Format("Additions", JGIDFLKOPML(OCBFLLHGDAP), EGFGNGJGBOP, ((Component)this).gameObject), (Object)(object)((Component)this).gameObject);
			}
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[6];
			array[0] = OCBFLLHGDAP;
			array[0] = EGFGNGJGBOP;
			OnlineManager.SendRPC(photonView, "ReceivInstantiateMiscellaneousHarvest", (RpcTarget)0, array);
		}
	}

	protected virtual void Awake()
	{
		if (!OnlineManager.PlayingOnline())
		{
			Object.Destroy((Object)(object)this);
			return;
		}
		if ((Object)(object)characterAnimation == (Object)null)
		{
			characterAnimation = ((Component)this).GetComponent<CharacterAnimBase>();
		}
		ONDMDLMHMHK = characterAnimation.animator;
		characterAnimation.onlineCharacterAnim = this;
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(HKIKDHMFNKG));
	}

	public void BCOJKPBPDFG(int OCBFLLHGDAP)
	{
		if (debugTriggers)
		{
			Debug.LogError((object)string.Format("Player", FDGLEFIPBPB(OCBFLLHGDAP), ((Component)this).gameObject), (Object)(object)((Component)this).gameObject);
		}
		ONDMDLMHMHK.SetTrigger(OCBFLLHGDAP);
	}

	[PunRPC]
	public void SetFloatRPC(int OCBFLLHGDAP, float EGFGNGJGBOP)
	{
		if (debugFloats)
		{
			Debug.LogError((object)$"Received RPC SetFloat {KCHHBMCOBJG(OCBFLLHGDAP)} with value {EGFGNGJGBOP} on {((Component)this).gameObject}. Setting animator parameter.", (Object)(object)((Component)this).gameObject);
		}
		ONDMDLMHMHK.SetFloat(OCBFLLHGDAP, EGFGNGJGBOP);
	}

	protected bool HLAOENHNBMO()
	{
		if (OnlineManager.PlayingOnline())
		{
			if (OnlineManager.PlayingOnline() && !clientCanSendRPC)
			{
				if ((Object)(object)((MonoBehaviourPun)this).photonView != (Object)null)
				{
					return !((MonoBehaviourPun)this).photonView.IsMine;
				}
				return false;
			}
			return false;
		}
		return true;
	}

	public void FELMOMIBJMG(int OCBFLLHGDAP, bool EGFGNGJGBOP)
	{
		if (debugBools)
		{
			Debug.LogError((object)string.Format("Pick up", FDGLEFIPBPB(OCBFLLHGDAP), EGFGNGJGBOP, ((Component)this).gameObject), (Object)(object)((Component)this).gameObject);
		}
		ONDMDLMHMHK.SetBool(OCBFLLHGDAP, EGFGNGJGBOP);
	}

	public void ICPPDAHGGLO(int OCBFLLHGDAP, float EGFGNGJGBOP)
	{
		if (syncFloats && !HLAOENHNBMO())
		{
			if (debugFloats)
			{
				Debug.LogError((object)string.Format("Idle", KCHHBMCOBJG(OCBFLLHGDAP), EGFGNGJGBOP, ((Component)this).gameObject), (Object)(object)((Component)this).gameObject);
			}
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[0] = OCBFLLHGDAP;
			array[1] = EGFGNGJGBOP;
			OnlineManager.SendRPC(photonView, "Dialogue System/Conversation/Crowly_Barks_Shop/Entry/4/Dialogue Text", (RpcTarget)0, array);
		}
	}

	public void OGCHGIOPEGJ(int OCBFLLHGDAP, int MGCOMHGJBOF)
	{
		if (!NPODHDKNPLK())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[0] = OCBFLLHGDAP;
			array[1] = MGCOMHGJBOF;
			OnlineManager.SendRPC(photonView, "Tutorial/T138/Dialogue2", (RpcTarget)1, array);
		}
	}

	public void GHFFLLCJICN(int OCBFLLHGDAP, int MGCOMHGJBOF)
	{
		if (!NPODHDKNPLK())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[8];
			array[0] = OCBFLLHGDAP;
			array[0] = MGCOMHGJBOF;
			OnlineManager.SendRPC(photonView, "Exit Game", (RpcTarget)0, array);
		}
	}

	protected void NIGGIDIFAND()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(NIGGIDIFAND));
		if (!KANJKEBBJBK())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[1] = PhotonNetwork.LocalPlayer;
			OnlineManager.SendRPC(photonView, "KickedCustomers", (RpcTarget)3, array);
		}
	}

	public void GEIHNFKCLPI(int OCBFLLHGDAP)
	{
		if (debugTriggers)
		{
			Debug.LogError((object)string.Format("*****", KCHHBMCOBJG(OCBFLLHGDAP), ((Component)this).gameObject), (Object)(object)((Component)this).gameObject);
		}
		ONDMDLMHMHK.SetTrigger(OCBFLLHGDAP);
	}

	public void AIDCDHELKNH(int OCBFLLHGDAP, float EGFGNGJGBOP)
	{
		if (debugFloats)
		{
			Debug.LogError((object)string.Format("add item ", FDGLEFIPBPB(OCBFLLHGDAP), EGFGNGJGBOP, ((Component)this).gameObject), (Object)(object)((Component)this).gameObject);
		}
		ONDMDLMHMHK.SetFloat(OCBFLLHGDAP, EGFGNGJGBOP);
	}

	public void HCKOCLOANEP(int OCBFLLHGDAP, float EGFGNGJGBOP)
	{
		if (debugFloats)
		{
			Debug.LogError((object)string.Format("CannotToggleUI PauseMenuUI opened", FDGLEFIPBPB(OCBFLLHGDAP), EGFGNGJGBOP, ((Component)this).gameObject), (Object)(object)((Component)this).gameObject);
		}
		ONDMDLMHMHK.SetFloat(OCBFLLHGDAP, EGFGNGJGBOP);
	}

	public void HPIGAKGMLDH(int OCBFLLHGDAP)
	{
		if (syncTriggers && !HLAOENHNBMO())
		{
			if (debugTriggers)
			{
				Debug.LogError((object)string.Format("talentStew", JGIDFLKOPML(OCBFLLHGDAP), ((Component)this).gameObject), (Object)(object)((Component)this).gameObject);
			}
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[1] = OCBFLLHGDAP;
			OnlineManager.SendRPC(photonView, "Items/item_name_1174", (RpcTarget)0, array);
		}
	}

	protected void KDFKNGOIJLI()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(FEPILKNEKNG));
		if (!KANJKEBBJBK())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[1] = PhotonNetwork.LocalPlayer;
			OnlineManager.SendRPC(photonView, "Exclamation", (RpcTarget)0, array);
		}
	}

	public void FOEOHGKCGEN(int OCBFLLHGDAP, bool EGFGNGJGBOP, bool AINPJHKNJGL = false)
	{
		if ((syncBools || AINPJHKNJGL) && (!OEAKPHGPCOD() || AINPJHKNJGL))
		{
			if (debugBools)
			{
				Debug.LogError((object)string.Format("id: ", HKDNLLIPCOO(OCBFLLHGDAP), EGFGNGJGBOP, ((Component)this).gameObject), (Object)(object)((Component)this).gameObject);
			}
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "scaleUI", (RpcTarget)1, OCBFLLHGDAP, EGFGNGJGBOP, null);
		}
	}

	[PunRPC]
	public void SetBoolRPC(int OCBFLLHGDAP, bool EGFGNGJGBOP)
	{
		if (debugBools)
		{
			Debug.LogError((object)$"Received RPC SetBool {KCHHBMCOBJG(OCBFLLHGDAP)} with value {EGFGNGJGBOP} on {((Component)this).gameObject}. Setting animator parameter.", (Object)(object)((Component)this).gameObject);
		}
		ONDMDLMHMHK.SetBool(OCBFLLHGDAP, EGFGNGJGBOP);
	}

	protected virtual void FFLLCOBFIPE()
	{
		if (!OnlineManager.PlayingOnline())
		{
			Object.Destroy((Object)(object)this);
			return;
		}
		if ((Object)(object)characterAnimation == (Object)null)
		{
			characterAnimation = ((Component)this).GetComponent<CharacterAnimBase>();
		}
		ONDMDLMHMHK = characterAnimation.animator;
		characterAnimation.onlineCharacterAnim = this;
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(FEPILKNEKNG));
	}

	public void OGHKEEBMOPJ(int OCBFLLHGDAP, bool EGFGNGJGBOP, bool AINPJHKNJGL = false)
	{
		if ((syncBools || AINPJHKNJGL) && (!HLAOENHNBMO() || AINPJHKNJGL))
		{
			if (debugBools)
			{
				Debug.LogError((object)string.Format("null sprite", FDGLEFIPBPB(OCBFLLHGDAP), EGFGNGJGBOP, ((Component)this).gameObject), (Object)(object)((Component)this).gameObject);
			}
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[4];
			array[0] = OCBFLLHGDAP;
			array[0] = EGFGNGJGBOP;
			OnlineManager.SendRPC(photonView, "LE_19", (RpcTarget)0, array);
		}
	}

	public void BIINBJHPEHC(int OCBFLLHGDAP, bool EGFGNGJGBOP, bool AINPJHKNJGL = false)
	{
		if ((syncBools || AINPJHKNJGL) && (!GPGHCFJHCAP() || AINPJHKNJGL))
		{
			if (debugBools)
			{
				Debug.LogError((object)string.Format("EnterTavernNeutral", JGIDFLKOPML(OCBFLLHGDAP), EGFGNGJGBOP, ((Component)this).gameObject), (Object)(object)((Component)this).gameObject);
			}
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "No MinePuzzleConfig found for level {0}", (RpcTarget)1, OCBFLLHGDAP, EGFGNGJGBOP, null, null, null, null, null);
		}
	}

	public void OnAnimationForcePlayed(int OCBFLLHGDAP, int MGCOMHGJBOF)
	{
		if (!HLAOENHNBMO())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ForceAnimationPlayRPC", (RpcTarget)1, OCBFLLHGDAP, MGCOMHGJBOF);
		}
	}

	[PunRPC]
	public void ReceiveTrigger(int OCBFLLHGDAP)
	{
		if (debugTriggers)
		{
			Debug.LogError((object)$"Received RPC SetTrigger {KCHHBMCOBJG(OCBFLLHGDAP)} on {((Component)this).gameObject}. Setting animator parameter.", (Object)(object)((Component)this).gameObject);
		}
		ONDMDLMHMHK.SetTrigger(OCBFLLHGDAP);
	}

	protected virtual void PGEGODAEBLC()
	{
		if (!OnlineManager.PlayingOnline())
		{
			Object.Destroy((Object)(object)this);
			return;
		}
		if ((Object)(object)characterAnimation == (Object)null)
		{
			characterAnimation = ((Component)this).GetComponent<CharacterAnimBase>();
		}
		ONDMDLMHMHK = characterAnimation.animator;
		characterAnimation.onlineCharacterAnim = this;
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(HKIKDHMFNKG));
	}

	protected void NNJNJGEAJKE(Player DHPNLIGKMOB)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected I4, but got Unknown
		if (HLAOENHNBMO() || (Object)(object)ONDMDLMHMHK == (Object)null || !((Component)ONDMDLMHMHK).gameObject.activeInHierarchy)
		{
			return;
		}
		AnimatorStateInfo currentAnimatorStateInfo = ONDMDLMHMHK.GetCurrentAnimatorStateInfo(1);
		if (((AnimatorStateInfo)(ref currentAnimatorStateInfo)).fullPathHash == 0)
		{
			Debug.LogWarning((object)string.Format("\t\t</align>", ((Component)this).gameObject), (Object)(object)((Component)this).gameObject);
		}
		else
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			currentAnimatorStateInfo = ONDMDLMHMHK.GetCurrentAnimatorStateInfo(1);
			array[1] = ((AnimatorStateInfo)(ref currentAnimatorStateInfo)).fullPathHash;
			OnlineManager.SendRPC(photonView, "BrownAleAbbreviation", DHPNLIGKMOB, array);
		}
		for (int i = 0; i < ONDMDLMHMHK.parameterCount; i++)
		{
			AnimatorControllerParameterType type = ONDMDLMHMHK.parameters[i].type;
			switch (type - 1)
			{
			case 2:
				OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "DecorationTile_21", DHPNLIGKMOB, ONDMDLMHMHK.parameters[i].nameHash, ONDMDLMHMHK.GetInteger(ONDMDLMHMHK.parameters[i].nameHash), null, null, null, null);
				break;
			case 0:
			{
				PhotonView photonView3 = ((MonoBehaviourPun)this).photonView;
				object[] array3 = new object[6];
				array3[1] = ONDMDLMHMHK.parameters[i].nameHash;
				array3[1] = ONDMDLMHMHK.GetFloat(ONDMDLMHMHK.parameters[i].nameHash);
				OnlineManager.SendRPC(photonView3, "HumanDisappear", DHPNLIGKMOB, array3);
				break;
			}
			case 3:
			{
				PhotonView photonView2 = ((MonoBehaviourPun)this).photonView;
				object[] array2 = new object[2];
				array2[1] = ONDMDLMHMHK.parameters[i].nameHash;
				array2[0] = ONDMDLMHMHK.GetBool(ONDMDLMHMHK.parameters[i].nameHash);
				OnlineManager.DBNIKCMHHMJ(photonView2, "KyrohTakingFood: Other player has advantage, going to WaitingToServe.", DHPNLIGKMOB, array2);
				break;
			}
			}
		}
	}

	public void EMEPEKJODIN(int OCBFLLHGDAP, bool EGFGNGJGBOP)
	{
		if (debugBools)
		{
			Debug.LogError((object)string.Format("LE_10", JGIDFLKOPML(OCBFLLHGDAP), EGFGNGJGBOP, ((Component)this).gameObject), (Object)(object)((Component)this).gameObject);
		}
		ONDMDLMHMHK.SetBool(OCBFLLHGDAP, EGFGNGJGBOP);
	}

	public void JEABKDPNFCN(int OCBFLLHGDAP, int EGFGNGJGBOP)
	{
		if (debugInts)
		{
			Debug.LogError((object)string.Format("Replacing Button on gameObject: ", PIBKDHBPEBK(OCBFLLHGDAP), EGFGNGJGBOP, ((Component)this).gameObject), (Object)(object)((Component)this).gameObject);
		}
		ONDMDLMHMHK.SetInteger(OCBFLLHGDAP, EGFGNGJGBOP);
	}

	public void DBGOCGOAEAI(int OCBFLLHGDAP, int EGFGNGJGBOP)
	{
		if (syncInts && !HLAOENHNBMO())
		{
			if (debugInts)
			{
				Debug.LogError((object)string.Format("ChristmasPresent", HKDNLLIPCOO(OCBFLLHGDAP), EGFGNGJGBOP, ((Component)this).gameObject), (Object)(object)((Component)this).gameObject);
			}
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[7];
			array[1] = OCBFLLHGDAP;
			array[1] = EGFGNGJGBOP;
			OnlineManager.SendRPC(photonView, "quest_name_19", (RpcTarget)0, array);
		}
	}

	private string JGIDFLKOPML(int OCBFLLHGDAP)
	{
		return AnimatorParameterCache.JLBKJNMJHOC(ONDMDLMHMHK, OCBFLLHGDAP);
	}

	public void PNLIOLJOAFK(int OCBFLLHGDAP)
	{
		if (debugTriggers)
		{
			Debug.LogError((object)string.Format("Tutorial/T107/Dialogue1", PIBKDHBPEBK(OCBFLLHGDAP), ((Component)this).gameObject), (Object)(object)((Component)this).gameObject);
		}
		ONDMDLMHMHK.SetTrigger(OCBFLLHGDAP);
	}

	protected bool OEAKPHGPCOD()
	{
		if (OnlineManager.PlayingOnline())
		{
			if (OnlineManager.PlayingOnline() && !clientCanSendRPC)
			{
				if ((Object)(object)((MonoBehaviourPun)this).photonView != (Object)null)
				{
					return ((MonoBehaviourPun)this).photonView.IsMine;
				}
				return false;
			}
			return true;
		}
		return false;
	}

	protected bool KANJKEBBJBK()
	{
		if (OnlineManager.PlayingOnline())
		{
			if (OnlineManager.PlayingOnline())
			{
				if ((Object)(object)((MonoBehaviourPun)this).photonView != (Object)null)
				{
					return ((MonoBehaviourPun)this).photonView.IsMine;
				}
				return false;
			}
			return false;
		}
		return true;
	}

	private string KCHHBMCOBJG(int OCBFLLHGDAP)
	{
		return AnimatorParameterCache.KCHHBMCOBJG(ONDMDLMHMHK, OCBFLLHGDAP);
	}

	public void DIOIHCBHEDE(int OCBFLLHGDAP, bool EGFGNGJGBOP)
	{
		if (debugBools)
		{
			Debug.LogError((object)string.Format("[HierarchyPrinter] Log dividido en {0} fragmentos para evitar truncado.", PIBKDHBPEBK(OCBFLLHGDAP), EGFGNGJGBOP, ((Component)this).gameObject), (Object)(object)((Component)this).gameObject);
		}
		ONDMDLMHMHK.SetBool(OCBFLLHGDAP, EGFGNGJGBOP);
	}

	public void SendTrigger(string GEGDHHIDEEF)
	{
		SendTrigger(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void ODINBGAOFMB(string GEGDHHIDEEF)
	{
		SendTrigger(Animator.StringToHash(GEGDHHIDEEF));
	}

	private string PIBKDHBPEBK(int OCBFLLHGDAP)
	{
		return AnimatorParameterCache.AOGFDGHKBOC(ONDMDLMHMHK, OCBFLLHGDAP);
	}

	public void EAOIBJEDEAM(int OCBFLLHGDAP, int EGFGNGJGBOP)
	{
		if (syncInts && !GPGHCFJHCAP())
		{
			if (debugInts)
			{
				Debug.LogError((object)string.Format("questRequiredTooltip", FDGLEFIPBPB(OCBFLLHGDAP), EGFGNGJGBOP, ((Component)this).gameObject), (Object)(object)((Component)this).gameObject);
			}
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[2];
			array[1] = OCBFLLHGDAP;
			array[0] = EGFGNGJGBOP;
			OnlineManager.SendRPC(photonView, "Error setting tavern name on CharacterCreatorUI: ", (RpcTarget)0, array);
		}
	}

	protected bool FFCGGLEPIOE()
	{
		if (OnlineManager.PlayingOnline())
		{
			if (OnlineManager.PlayingOnline())
			{
				if ((Object)(object)((MonoBehaviourPun)this).photonView != (Object)null)
				{
					return ((MonoBehaviourPun)this).photonView.IsMine;
				}
				return true;
			}
			return true;
		}
		return false;
	}

	protected bool NPODHDKNPLK()
	{
		if (OnlineManager.PlayingOnline())
		{
			if (OnlineManager.PlayingOnline() && !clientCanSendRPC)
			{
				if ((Object)(object)((MonoBehaviourPun)this).photonView != (Object)null)
				{
					return !((MonoBehaviourPun)this).photonView.IsMine;
				}
				return true;
			}
			return false;
		}
		return false;
	}

	public void JAJNCNPJMFA(int OCBFLLHGDAP, int EGFGNGJGBOP)
	{
		if (syncInts && !NPODHDKNPLK())
		{
			if (debugInts)
			{
				Debug.LogError((object)string.Format("UI", PIBKDHBPEBK(OCBFLLHGDAP), EGFGNGJGBOP, ((Component)this).gameObject), (Object)(object)((Component)this).gameObject);
			}
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[1] = OCBFLLHGDAP;
			array[1] = EGFGNGJGBOP;
			OnlineManager.SendRPC(photonView, "", (RpcTarget)1, array);
		}
	}

	public void PNBADCHAAHO(int OCBFLLHGDAP)
	{
		if (syncTriggers && !NPODHDKNPLK())
		{
			if (debugTriggers)
			{
				Debug.LogError((object)string.Format("Player/Bark/Tutorial/SleepBlock", JGIDFLKOPML(OCBFLLHGDAP), ((Component)this).gameObject), (Object)(object)((Component)this).gameObject);
			}
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[1] = OCBFLLHGDAP;
			OnlineManager.SendRPC(photonView, "BuildMode", (RpcTarget)0, array);
		}
	}

	private string HKDNLLIPCOO(int OCBFLLHGDAP)
	{
		return AnimatorParameterCache.ALIBCLPCEEC(ONDMDLMHMHK, OCBFLLHGDAP);
	}

	public void FOMLOLCHODB(int OCBFLLHGDAP, float EGFGNGJGBOP)
	{
		if (debugFloats)
		{
			Debug.LogError((object)string.Format("ReceiveSitDown", FDGLEFIPBPB(OCBFLLHGDAP), EGFGNGJGBOP, ((Component)this).gameObject), (Object)(object)((Component)this).gameObject);
		}
		ONDMDLMHMHK.SetFloat(OCBFLLHGDAP, EGFGNGJGBOP);
	}

	public void IPJIDKJODGF(int OCBFLLHGDAP, int MGCOMHGJBOF)
	{
		if (!OEAKPHGPCOD())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Multiplayer", (RpcTarget)0, OCBFLLHGDAP, MGCOMHGJBOF, null, null, null);
		}
	}

	public void HHKDGLAAOJO(int OCBFLLHGDAP, bool EGFGNGJGBOP)
	{
		if (debugBools)
		{
			Debug.LogError((object)string.Format("Statue0={0} | ", HKDNLLIPCOO(OCBFLLHGDAP), EGFGNGJGBOP, ((Component)this).gameObject), (Object)(object)((Component)this).gameObject);
		}
		ONDMDLMHMHK.SetBool(OCBFLLHGDAP, EGFGNGJGBOP);
	}

	private string FDGLEFIPBPB(int OCBFLLHGDAP)
	{
		return AnimatorParameterCache.OFCILOJACIK(ONDMDLMHMHK, OCBFLLHGDAP);
	}

	public void FIECHCMAALJ(int OCBFLLHGDAP, int MGCOMHGJBOF)
	{
		if (!HLAOENHNBMO())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[8];
			array[0] = OCBFLLHGDAP;
			array[0] = MGCOMHGJBOF;
			OnlineManager.SendRPC(photonView, "Items/item_name_630", (RpcTarget)0, array);
		}
	}

	[PunRPC]
	protected void AnimatorParameterRequest(Player DHPNLIGKMOB)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected I4, but got Unknown
		if (HLAOENHNBMO() || (Object)(object)ONDMDLMHMHK == (Object)null || !((Component)ONDMDLMHMHK).gameObject.activeInHierarchy)
		{
			return;
		}
		AnimatorStateInfo currentAnimatorStateInfo = ONDMDLMHMHK.GetCurrentAnimatorStateInfo(0);
		if (((AnimatorStateInfo)(ref currentAnimatorStateInfo)).fullPathHash == 0)
		{
			Debug.LogWarning((object)$"Hash is 0 on {((Component)this).gameObject}, probably because the object is deactivated, so we skip sending it.", (Object)(object)((Component)this).gameObject);
		}
		else
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			currentAnimatorStateInfo = ONDMDLMHMHK.GetCurrentAnimatorStateInfo(0);
			array[0] = ((AnimatorStateInfo)(ref currentAnimatorStateInfo)).fullPathHash;
			OnlineManager.SendRPC(photonView, "SetAnimatorStateRPC", DHPNLIGKMOB, array);
		}
		for (int i = 0; i < ONDMDLMHMHK.parameterCount; i++)
		{
			AnimatorControllerParameterType type = ONDMDLMHMHK.parameters[i].type;
			switch (type - 1)
			{
			case 2:
				OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "SetIntegerRPC", DHPNLIGKMOB, ONDMDLMHMHK.parameters[i].nameHash, ONDMDLMHMHK.GetInteger(ONDMDLMHMHK.parameters[i].nameHash));
				break;
			case 0:
				OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "SetFloatRPC", DHPNLIGKMOB, ONDMDLMHMHK.parameters[i].nameHash, ONDMDLMHMHK.GetFloat(ONDMDLMHMHK.parameters[i].nameHash));
				break;
			case 3:
				OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "SetBoolRPC", DHPNLIGKMOB, ONDMDLMHMHK.parameters[i].nameHash, ONDMDLMHMHK.GetBool(ONDMDLMHMHK.parameters[i].nameHash));
				break;
			}
		}
	}

	public void KKDBJOCNLFG(int OCBFLLHGDAP, float EGFGNGJGBOP)
	{
		if (syncFloats && !NPODHDKNPLK())
		{
			if (debugFloats)
			{
				Debug.LogError((object)string.Format("Ground", KCHHBMCOBJG(OCBFLLHGDAP), EGFGNGJGBOP, ((Component)this).gameObject), (Object)(object)((Component)this).gameObject);
			}
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[1] = OCBFLLHGDAP;
			array[1] = EGFGNGJGBOP;
			OnlineManager.SendRPC(photonView, "Dialogue System/Conversation/Crowly_Barks_OutScreen/Entry/6/Dialogue Text", (RpcTarget)1, array);
		}
	}

	[PunRPC]
	public void SetIntegerRPC(int OCBFLLHGDAP, int EGFGNGJGBOP)
	{
		if (debugInts)
		{
			Debug.LogError((object)$"Received RPC SetInteger {KCHHBMCOBJG(OCBFLLHGDAP)} with value {EGFGNGJGBOP} on {((Component)this).gameObject}. Setting animator parameter.", (Object)(object)((Component)this).gameObject);
		}
		ONDMDLMHMHK.SetInteger(OCBFLLHGDAP, EGFGNGJGBOP);
	}

	public void NHNCHJNHMJC(int OCBFLLHGDAP, bool EGFGNGJGBOP, bool AINPJHKNJGL = false)
	{
		if ((syncBools || AINPJHKNJGL) && (!NPODHDKNPLK() || AINPJHKNJGL))
		{
			if (debugBools)
			{
				Debug.LogError((object)string.Format("Trying to get an invalid Other player with playerNum: ", PIBKDHBPEBK(OCBFLLHGDAP), EGFGNGJGBOP, ((Component)this).gameObject), (Object)(object)((Component)this).gameObject);
			}
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[8];
			array[1] = OCBFLLHGDAP;
			array[0] = EGFGNGJGBOP;
			OnlineManager.SendRPC(photonView, "<br/>System Memory Size: ", (RpcTarget)0, array);
		}
	}

	public void FPIBLPODPKD(int OCBFLLHGDAP, float EGFGNGJGBOP)
	{
		if (debugFloats)
		{
			Debug.LogError((object)string.Format("Transfered ", PIBKDHBPEBK(OCBFLLHGDAP), EGFGNGJGBOP, ((Component)this).gameObject), (Object)(object)((Component)this).gameObject);
		}
		ONDMDLMHMHK.SetFloat(OCBFLLHGDAP, EGFGNGJGBOP);
	}

	protected bool ICJLBGDFOHM()
	{
		if (OnlineManager.PlayingOnline())
		{
			if (OnlineManager.PlayingOnline())
			{
				if ((Object)(object)((MonoBehaviourPun)this).photonView != (Object)null)
				{
					return ((MonoBehaviourPun)this).photonView.IsMine;
				}
				return true;
			}
			return true;
		}
		return true;
	}

	public void OLKNJKPEDIH(string GEGDHHIDEEF)
	{
		SendTrigger(Animator.StringToHash(GEGDHHIDEEF));
	}

	public void EGGILOKDFOP(int OCBFLLHGDAP, bool EGFGNGJGBOP)
	{
		if (debugBools)
		{
			Debug.LogError((object)string.Format("Toy", PIBKDHBPEBK(OCBFLLHGDAP), EGFGNGJGBOP, ((Component)this).gameObject), (Object)(object)((Component)this).gameObject);
		}
		ONDMDLMHMHK.SetBool(OCBFLLHGDAP, EGFGNGJGBOP);
	}

	public void JBKOAOIENGC(int OCBFLLHGDAP, int EGFGNGJGBOP)
	{
		if (debugInts)
		{
			Debug.LogError((object)string.Format("Dialogue System/Conversation/TavernClean/Entry/1/Dialogue Text", FDGLEFIPBPB(OCBFLLHGDAP), EGFGNGJGBOP, ((Component)this).gameObject), (Object)(object)((Component)this).gameObject);
		}
		ONDMDLMHMHK.SetInteger(OCBFLLHGDAP, EGFGNGJGBOP);
	}

	public void SendTrigger(int OCBFLLHGDAP)
	{
		if (syncTriggers)
		{
			if (debugTriggers)
			{
				Debug.Log((object)("Send trigger with hash " + OCBFLLHGDAP + " of " + ((Object)((Component)this).gameObject).name));
			}
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveTrigger", (RpcTarget)1, OCBFLLHGDAP);
		}
	}

	public void FKFCPNMDGMB(int OCBFLLHGDAP, int EGFGNGJGBOP)
	{
		if (debugInts)
		{
			Debug.LogError((object)string.Format("Items/item_name_642", HKDNLLIPCOO(OCBFLLHGDAP), EGFGNGJGBOP, ((Component)this).gameObject), (Object)(object)((Component)this).gameObject);
		}
		ONDMDLMHMHK.SetInteger(OCBFLLHGDAP, EGFGNGJGBOP);
	}

	public void HJEKGBEIGAF(int OCBFLLHGDAP)
	{
		if (debugTriggers)
		{
			Debug.LogError((object)string.Format("City/Woody/Bark/Bye", JGIDFLKOPML(OCBFLLHGDAP), ((Component)this).gameObject), (Object)(object)((Component)this).gameObject);
		}
		ONDMDLMHMHK.SetTrigger(OCBFLLHGDAP);
	}

	public void GCIJNIFBGPO(int OCBFLLHGDAP, int MGCOMHGJBOF)
	{
		ONDMDLMHMHK.Play(OCBFLLHGDAP, MGCOMHGJBOF);
	}

	public void PPKIPGFFKCI(int OCBFLLHGDAP)
	{
		if (debugTriggers)
		{
			Debug.LogError((object)string.Format("Item Age ", KCHHBMCOBJG(OCBFLLHGDAP), ((Component)this).gameObject), (Object)(object)((Component)this).gameObject);
		}
		ONDMDLMHMHK.SetTrigger(OCBFLLHGDAP);
	}

	public void EFDGIBJHOKA(int OCBFLLHGDAP, float EGFGNGJGBOP)
	{
		if (debugFloats)
		{
			Debug.LogError((object)string.Format("-", PIBKDHBPEBK(OCBFLLHGDAP), EGFGNGJGBOP, ((Component)this).gameObject), (Object)(object)((Component)this).gameObject);
		}
		ONDMDLMHMHK.SetFloat(OCBFLLHGDAP, EGFGNGJGBOP);
	}

	public void KKPMBJMLPEA(int OCBFLLHGDAP)
	{
		if (debugTriggers)
		{
			Debug.LogError((object)string.Format("SleepOpenTavern", HKDNLLIPCOO(OCBFLLHGDAP), ((Component)this).gameObject), (Object)(object)((Component)this).gameObject);
		}
		ONDMDLMHMHK.SetTrigger(OCBFLLHGDAP);
	}

	public void ABMHJHDEPKK(int OCBFLLHGDAP)
	{
		if (syncTriggers)
		{
			if (debugTriggers)
			{
				Debug.Log((object)("Piso {0}: Generando {1} rocas en {2} spawners disponibles." + OCBFLLHGDAP + "Gender: {0}\n" + ((Object)((Component)this).gameObject).name));
			}
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "tutorialPopUp81", (RpcTarget)1, OCBFLLHGDAP);
		}
	}

	public void CACLHLFFDPB(int OCBFLLHGDAP)
	{
		if (debugTriggers)
		{
			Debug.LogError((object)string.Format("Aged", HKDNLLIPCOO(OCBFLLHGDAP), ((Component)this).gameObject), (Object)(object)((Component)this).gameObject);
		}
		ONDMDLMHMHK.SetTrigger(OCBFLLHGDAP);
	}

	public void OnIntegerChanged(int OCBFLLHGDAP, int EGFGNGJGBOP)
	{
		if (syncInts && !HLAOENHNBMO())
		{
			if (debugInts)
			{
				Debug.LogError((object)$"Integer {KCHHBMCOBJG(OCBFLLHGDAP)} changed to {EGFGNGJGBOP} on {((Component)this).gameObject}'s animator. Sending RPC.", (Object)(object)((Component)this).gameObject);
			}
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "SetIntegerRPC", (RpcTarget)1, OCBFLLHGDAP, EGFGNGJGBOP);
		}
	}

	protected void HKIKDHMFNKG()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(HKIKDHMFNKG));
		if (!KANJKEBBJBK())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "AnimatorParameterRequest", (RpcTarget)2, PhotonNetwork.LocalPlayer);
		}
	}

	public void OnBoolChanged(int OCBFLLHGDAP, bool EGFGNGJGBOP, bool AINPJHKNJGL = false)
	{
		if ((syncBools || AINPJHKNJGL) && (!HLAOENHNBMO() || AINPJHKNJGL))
		{
			if (debugBools)
			{
				Debug.LogError((object)$"Bool {KCHHBMCOBJG(OCBFLLHGDAP)} changed to {EGFGNGJGBOP} on {((Component)this).gameObject}'s animator. Sending RPC.", (Object)(object)((Component)this).gameObject);
			}
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "SetBoolRPC", (RpcTarget)1, OCBFLLHGDAP, EGFGNGJGBOP);
		}
	}

	public void GGONEGCDGAK(int OCBFLLHGDAP)
	{
		if (debugTriggers)
		{
			Debug.LogError((object)string.Format("Idle", KCHHBMCOBJG(OCBFLLHGDAP), ((Component)this).gameObject), (Object)(object)((Component)this).gameObject);
		}
		ONDMDLMHMHK.SetTrigger(OCBFLLHGDAP);
	}

	[PunRPC]
	public void SetTriggerRPC(int OCBFLLHGDAP)
	{
		if (debugTriggers)
		{
			Debug.LogError((object)$"Received RPC SetTrigger {KCHHBMCOBJG(OCBFLLHGDAP)} on {((Component)this).gameObject}. Setting animator parameter.", (Object)(object)((Component)this).gameObject);
		}
		ONDMDLMHMHK.SetTrigger(OCBFLLHGDAP);
	}

	public void MOIIHPOPHLP(int OCBFLLHGDAP)
	{
		if (debugTriggers)
		{
			Debug.LogError((object)string.Format("Loading tavern floor tiles", HKDNLLIPCOO(OCBFLLHGDAP), ((Component)this).gameObject), (Object)(object)((Component)this).gameObject);
		}
		ONDMDLMHMHK.SetTrigger(OCBFLLHGDAP);
	}
}
