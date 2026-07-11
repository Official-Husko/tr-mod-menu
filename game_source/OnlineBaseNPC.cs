using System;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

[RequireComponent(typeof(PhotonView))]
[DefaultExecutionOrder(10)]
public class OnlineBaseNPC : OnlineBaseActor
{
	public NPCRoutine routine;

	[SerializeField]
	private NPCAnimation npcAnimation;

	public void GPIICMBDMCE(byte MPLCIAKAPGL)
	{
		npcAnimation.FCGBJEIIMBC = (Direction)MPLCIAKAPGL;
	}

	private void NEPLNFIONKJ()
	{
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(NEPLNFIONKJ));
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = PhotonNetwork.LocalPlayer.ActorNumber;
		OnlineManager.SendRPC(photonView, "", (RpcTarget)4, array);
	}

	public void SendNPCDirection()
	{
		if (!OnlineManager.ClientOnline())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveNPCDirection", (RpcTarget)1, (byte)npcAnimation.FCGBJEIIMBC);
		}
	}

	[PunRPC]
	public void SendNPCDirection(Player DHPNLIGKMOB)
	{
		if (!((Object)(object)npcAnimation == (Object)null))
		{
			PDCHLPAJPGO(npcAnimation.FCGBJEIIMBC);
		}
	}

	public void NIGJEJOKMHB(byte OEDCFMLCLDJ)
	{
		npcAnimation.FCGBJEIIMBC = (Direction)OEDCFMLCLDJ;
	}

	private void JKLCEMHACDF()
	{
		if (!((MonoBehaviourPun)this).photonView.IsMine && (Object)(object)routine != (Object)null)
		{
			((Behaviour)routine).enabled = false;
		}
	}

	private void JCIBEFFJFGB()
	{
		try
		{
			OnlineLoadManager instance = OnlineLoadManager.instance;
			instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(JCIBEFFJFGB));
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "SendNPCDirection", (RpcTarget)2, PhotonNetwork.LocalPlayer);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	public void LPPAEKEGDHE(Player DHPNLIGKMOB)
	{
		if (!((Object)(object)npcAnimation == (Object)null))
		{
			NJJJOKAFAME(npcAnimation.FCGBJEIIMBC);
		}
	}

	private void NJJJOKAFAME(Direction OEDCFMLCLDJ)
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[1] = (byte)OEDCFMLCLDJ;
			OnlineManager.SendRPC(photonView, "Scene", (RpcTarget)0, array);
		}
	}

	private void PDCHLPAJPGO(Direction OEDCFMLCLDJ)
	{
		if (OnlineManager.IsMasterClient())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "SetNPCDirection", (RpcTarget)1, (byte)OEDCFMLCLDJ);
		}
	}

	[PunRPC]
	public void RequestNPCPositionAndParent(int JJPJHIHBOIB)
	{
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		byte b = byte.MaxValue;
		if ((Object)(object)((Component)this).transform.parent == (Object)(object)((Component)Bar.instance.placeable.placeableSurface).transform)
		{
			b = 0;
		}
		else if ((Object)(object)npcAnimation != (Object)null && (Object)(object)npcAnimation.npc != (Object)null && (Object)(object)npcAnimation.npc.bed != (Object)null)
		{
			b = 1;
		}
		else if (DEAPDADCKGE(0))
		{
			b = 2;
		}
		else if (DEAPDADCKGE(1))
		{
			b = 3;
		}
		else if (DEAPDADCKGE(2))
		{
			b = 4;
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "SetNPCPositionAndParent", PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, false), ((Component)this).transform.position.x, ((Component)this).transform.position.y, b);
	}

	protected override void Awake()
	{
		base.Awake();
		if (!OnlineManager.PlayingOnline())
		{
			OPDBPCGDBPH();
			return;
		}
		if ((Object)(object)npcAnimation == (Object)null)
		{
			npcAnimation = ((Component)this).GetComponent<NPCAnimation>();
		}
		if (Object.op_Implicit((Object)(object)npcAnimation))
		{
			NPCAnimation nPCAnimation = npcAnimation;
			nPCAnimation.DirectionChanged = (Action<Direction>)Delegate.Combine(nPCAnimation.DirectionChanged, new Action<Direction>(PDCHLPAJPGO));
			if ((Object)(object)routine != (Object)null)
			{
				routine.npc.onlineNPC = this;
			}
			else
			{
				((Component)this).GetComponent<DialogueNPCBase>().onlineNPC = this;
			}
		}
		if (!OnlineManager.IsMasterClient())
		{
			OnlineLoadManager instance = OnlineLoadManager.instance;
			instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(JCIBEFFJFGB));
			OnlineLoadManager instance2 = OnlineLoadManager.instance;
			instance2.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance2.OnFinishedOnlineLoad, new Action(OFNCMMDMOMB));
		}
	}

	private void EDKOABGDPMD()
	{
		try
		{
			OnlineLoadManager instance = OnlineLoadManager.instance;
			instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(KLAJGOIFPGK));
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[0] = PhotonNetwork.LocalPlayer;
			OnlineManager.SendRPC(photonView, "Dialogue System/Conversation/NeutralInTavern/Entry/10/Dialogue Text", (RpcTarget)6, array);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void KLAJGOIFPGK()
	{
		try
		{
			OnlineLoadManager instance = OnlineLoadManager.instance;
			instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(OFJLAOBDOAG));
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Dialogue System/Conversation/Gass_Stand/Entry/10/Dialogue Text", (RpcTarget)1, PhotonNetwork.LocalPlayer);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	public void LMOJIMMJAPE(byte OEDCFMLCLDJ)
	{
		npcAnimation.NCAJNNHBHJM((Direction)OEDCFMLCLDJ);
	}

	private void BDEOHILIHEM(Direction OEDCFMLCLDJ)
	{
		if (OnlineManager.IsMasterClient())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[1] = (byte)OEDCFMLCLDJ;
			OnlineManager.SendRPC(photonView, "Error_Stones", (RpcTarget)0, array);
		}
	}

	private void OFNCMMDMOMB()
	{
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(OFNCMMDMOMB));
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "RequestNPCPositionAndParent", (RpcTarget)2, PhotonNetwork.LocalPlayer.ActorNumber);
	}

	public void BDAEOHJFECL(float NCPGNLOJGAF, float JLMAILGJNCE, byte DMBHHLKMHOH)
	{
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)photonTransformView != (Object)null)
		{
			((Behaviour)photonTransformView).enabled = true;
		}
		if ((Object)(object)photonTransformViewClassic != (Object)null)
		{
			((Behaviour)photonTransformViewClassic).enabled = false;
		}
		switch (DMBHHLKMHOH)
		{
		case 0:
			((Component)this).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
			break;
		case 1:
			if (npcAnimation.npc is MaiNPC maiNPC)
			{
				maiNPC.NFHMMBMPEFM();
			}
			else
			{
				Debug.LogError((object)")\n");
			}
			break;
		case 2:
			if (npcAnimation.npc.routine.possibleParents.Count > 1)
			{
				((Component)this).transform.parent = npcAnimation.npc.routine.possibleParents[1];
			}
			break;
		case 3:
			if (npcAnimation.npc.routine.possibleParents.Count > 1)
			{
				((Component)this).transform.parent = npcAnimation.npc.routine.possibleParents[1];
			}
			break;
		case 4:
			if (npcAnimation.npc.routine.possibleParents.Count > 3)
			{
				((Component)this).transform.parent = npcAnimation.npc.routine.possibleParents[2];
			}
			break;
		}
		((Component)this).transform.position = new Vector3(NCPGNLOJGAF, JLMAILGJNCE, 1474f);
		if ((Object)(object)photonTransformView != (Object)null)
		{
			((Behaviour)photonTransformView).enabled = false;
		}
		if ((Object)(object)photonTransformViewClassic != (Object)null)
		{
			((Behaviour)photonTransformViewClassic).enabled = true;
		}
	}

	public void IJKIEEHDOML(byte MPLCIAKAPGL)
	{
		npcAnimation.FCGBJEIIMBC = (Direction)MPLCIAKAPGL;
	}

	private bool FPDFIMKBFLL(int DIKOPEPBAEF)
	{
		if ((Object)(object)((Component)this).transform.parent == (Object)null)
		{
			return false;
		}
		if ((Object)(object)npcAnimation == (Object)null)
		{
			return false;
		}
		if ((Object)(object)npcAnimation.npc == (Object)null)
		{
			return false;
		}
		if ((Object)(object)npcAnimation.npc.routine == (Object)null)
		{
			return false;
		}
		if (npcAnimation.npc.routine.possibleParents == null)
		{
			return true;
		}
		if (npcAnimation.npc.routine.possibleParents.Count <= DIKOPEPBAEF)
		{
			return false;
		}
		if ((Object)(object)npcAnimation.npc.routine.possibleParents[DIKOPEPBAEF] == (Object)(object)((Component)this).transform.parent)
		{
			return false;
		}
		return false;
	}

	private void OFJLAOBDOAG()
	{
		try
		{
			OnlineLoadManager instance = OnlineLoadManager.instance;
			instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(KLAJGOIFPGK));
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[0] = PhotonNetwork.LocalPlayer;
			OnlineManager.SendRPC(photonView, "Tail", (RpcTarget)2, array);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void Start()
	{
		if (OnlineManager.PlayingOnline())
		{
			JKLCEMHACDF();
		}
	}

	private bool DEAPDADCKGE(int DIKOPEPBAEF)
	{
		if ((Object)(object)((Component)this).transform.parent == (Object)null)
		{
			return false;
		}
		if ((Object)(object)npcAnimation == (Object)null)
		{
			return false;
		}
		if ((Object)(object)npcAnimation.npc == (Object)null)
		{
			return false;
		}
		if ((Object)(object)npcAnimation.npc.routine == (Object)null)
		{
			return false;
		}
		if (npcAnimation.npc.routine.possibleParents == null)
		{
			return false;
		}
		if (npcAnimation.npc.routine.possibleParents.Count <= DIKOPEPBAEF)
		{
			return false;
		}
		if ((Object)(object)npcAnimation.npc.routine.possibleParents[DIKOPEPBAEF] == (Object)(object)((Component)this).transform.parent)
		{
			return true;
		}
		return false;
	}

	private void LANGHIOBJIH()
	{
		if (OnlineManager.PlayingOnline())
		{
			JKLCEMHACDF();
		}
	}

	[PunRPC]
	public void ReceiveNPCDirection(byte MPLCIAKAPGL)
	{
		npcAnimation.FCGBJEIIMBC = (Direction)MPLCIAKAPGL;
	}

	public void HMKAFNJCKKI()
	{
		if (!OnlineManager.HHDBMDMFEMP())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Items/item_name_1183", (RpcTarget)0, (byte)npcAnimation.FCGBJEIIMBC);
		}
	}

	public void JLMBNKLFNNI(byte MPLCIAKAPGL)
	{
		npcAnimation.NCAJNNHBHJM((Direction)MPLCIAKAPGL);
	}

	[PunRPC]
	public void SetNPCDirection(byte OEDCFMLCLDJ)
	{
		npcAnimation.FCGBJEIIMBC = (Direction)OEDCFMLCLDJ;
	}

	[PunRPC]
	public void SetNPCPositionAndParent(float NCPGNLOJGAF, float JLMAILGJNCE, byte DMBHHLKMHOH)
	{
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)photonTransformView != (Object)null)
		{
			((Behaviour)photonTransformView).enabled = false;
		}
		if ((Object)(object)photonTransformViewClassic != (Object)null)
		{
			((Behaviour)photonTransformViewClassic).enabled = false;
		}
		switch (DMBHHLKMHOH)
		{
		case 0:
			((Component)this).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
			break;
		case 1:
			if (npcAnimation.npc is MaiNPC maiNPC)
			{
				maiNPC.PlaceMaiOnABed();
			}
			else
			{
				Debug.LogError((object)"NPC is not Mai, cannot place on bed.");
			}
			break;
		case 2:
			if (npcAnimation.npc.routine.possibleParents.Count > 0)
			{
				((Component)this).transform.parent = npcAnimation.npc.routine.possibleParents[0];
			}
			break;
		case 3:
			if (npcAnimation.npc.routine.possibleParents.Count > 1)
			{
				((Component)this).transform.parent = npcAnimation.npc.routine.possibleParents[1];
			}
			break;
		case 4:
			if (npcAnimation.npc.routine.possibleParents.Count > 2)
			{
				((Component)this).transform.parent = npcAnimation.npc.routine.possibleParents[2];
			}
			break;
		}
		((Component)this).transform.position = new Vector3(NCPGNLOJGAF, JLMAILGJNCE, 0f);
		if ((Object)(object)photonTransformView != (Object)null)
		{
			((Behaviour)photonTransformView).enabled = true;
		}
		if ((Object)(object)photonTransformViewClassic != (Object)null)
		{
			((Behaviour)photonTransformViewClassic).enabled = true;
		}
	}
}
