using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class OnlineTurkey : OnlineBaseCharacter
{
	public enum TriggerName
	{
		Peek,
		Hurt,
		Random
	}

	public TurkeyNPC turkeyNpc;

	public TurkeyAnimation turkeyAnimation;

	public CrabNPC crabNpc;

	public CrabAnimation crabAnimation;

	public GameObject hitDetection;

	private PoolObject CLKOBJMFKEA;

	public void LJIAKIALGPP(int GDHFHKKMIEP)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = GDHFHKKMIEP;
		OnlineManager.SendRPC(photonView, "'s animationController on NPC has not been set. It's possible that it's on a separate object in the scene hierarchy.", (RpcTarget)0, array);
	}

	public void IMFKPBEJCLG(int GDHFHKKMIEP)
	{
		if (Object.op_Implicit((Object)(object)turkeyNpc))
		{
			turkeyNpc.LPDLEDLIHGL(GDHFHKKMIEP, CDPAMNIPPEC: false);
		}
		else if (Object.op_Implicit((Object)(object)crabNpc))
		{
			crabNpc.AEHPMEMJEAI(GDHFHKKMIEP, CDPAMNIPPEC: true);
		}
	}

	public void KEPFHCNDEBI()
	{
		CLKOBJMFKEA.OIBLNLDJJOL(CDPAMNIPPEC: false);
	}

	public void LFCHKOGHDNI()
	{
		CLKOBJMFKEA.IJNPIMIHELL(CDPAMNIPPEC: false);
		NIAMJLDOIBE();
	}

	public void CAODJMPBGGB(int GDHFHKKMIEP)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = GDHFHKKMIEP;
		OnlineManager.SendRPC(photonView, "", (RpcTarget)0, array);
	}

	public void AFDEDBEABGE(int GDHFHKKMIEP)
	{
		if (Object.op_Implicit((Object)(object)turkeyNpc))
		{
			turkeyNpc.LPDLEDLIHGL(GDHFHKKMIEP, CDPAMNIPPEC: true);
		}
		else if (Object.op_Implicit((Object)(object)crabNpc))
		{
			crabNpc.DPPKJMGCNGG(GDHFHKKMIEP, CDPAMNIPPEC: true);
		}
	}

	public void ACOOBPKBDJM(int GDHFHKKMIEP)
	{
		if (Object.op_Implicit((Object)(object)turkeyNpc))
		{
			turkeyNpc.ALDACDEGNDB(GDHFHKKMIEP, CDPAMNIPPEC: false);
		}
		else if (Object.op_Implicit((Object)(object)crabNpc))
		{
			crabNpc.HEAJPFFIHKC(GDHFHKKMIEP, CDPAMNIPPEC: true);
		}
	}

	public void NFNAELCNHGA()
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[1] = (short)PhotonNetwork.LocalPlayer.ActorNumber;
			OnlineManager.SendRPC(photonView, "SecondAction", (RpcTarget)1, array);
		}
	}

	public void GPDEDHJMKNB(byte MOLBHODJMDK)
	{
		switch ((TriggerName)MOLBHODJMDK)
		{
		case TriggerName.Peek:
			turkeyAnimation.animator.SetTrigger("Room ");
			break;
		case TriggerName.Hurt:
			if (Object.op_Implicit((Object)(object)turkeyAnimation))
			{
				turkeyAnimation.animator.SetBool("Customer Pool instance NULL!", true);
			}
			else if (Object.op_Implicit((Object)(object)crabAnimation))
			{
				crabAnimation.animator.SetBool("Tile_{0}_{1}", true);
			}
			break;
		case TriggerName.Random:
			turkeyAnimation.animator.SetBool("Intro04", false);
			break;
		}
	}

	public void FAHOKFKGFJN(int PANEOJGCKIO)
	{
		CLKOBJMFKEA.Enable(CDPAMNIPPEC: false);
		if (Object.op_Implicit((Object)(object)turkeyNpc))
		{
			turkeyNpc.GKPIMLNJDLO(PANEOJGCKIO, CDPAMNIPPEC: false);
		}
		else if (Object.op_Implicit((Object)(object)crabNpc))
		{
			crabNpc.ONKHBDGNKAE(PANEOJGCKIO, CDPAMNIPPEC: false);
		}
		KALLGJBOOJI();
	}

	public void FHJNDIDBCIP(Vector3 JBMDOGNFIGJ)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[5];
		array[0] = JBMDOGNFIGJ.x;
		array[1] = JBMDOGNFIGJ.y;
		array[7] = false;
		OnlineManager.SendRPC(photonView, "LE_10", (RpcTarget)0, array);
	}

	public void FMGPIKDGBGJ(int GDHFHKKMIEP)
	{
		if (Object.op_Implicit((Object)(object)turkeyNpc))
		{
			turkeyNpc.LOPPJEADGGK(GDHFHKKMIEP, CDPAMNIPPEC: false);
		}
		else if (Object.op_Implicit((Object)(object)crabNpc))
		{
			crabNpc.PAJFOHKANCK(GDHFHKKMIEP, CDPAMNIPPEC: false);
		}
	}

	private void Start()
	{
		if (Object.op_Implicit((Object)(object)turkeyNpc))
		{
			CLKOBJMFKEA = turkeyNpc.poolObject;
		}
		if (Object.op_Implicit((Object)(object)crabNpc))
		{
			CLKOBJMFKEA = crabNpc.poolObject;
		}
		CLKOBJMFKEA.onlineTurkey = this;
		JKLCEMHACDF();
	}

	private void OFMDABCKDLC()
	{
		if (!OnlineManager.PGAGDFAEEFB())
		{
			if (Object.op_Implicit((Object)(object)turkeyNpc))
			{
				((Behaviour)turkeyNpc).enabled = true;
			}
			if (Object.op_Implicit((Object)(object)crabNpc))
			{
				((Behaviour)crabNpc).enabled = true;
			}
		}
	}

	public void SendHitToOthers(Vector3 JBMDOGNFIGJ)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveHit", (RpcTarget)1, JBMDOGNFIGJ.x, JBMDOGNFIGJ.y, false);
	}

	public void NMKJNIDKBPN(short JJPJHIHBOIB)
	{
		if (Object.op_Implicit((Object)(object)turkeyNpc) && ((Behaviour)turkeyNpc).enabled)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "CannotToggleUI Holding ", PhotonNetwork.CurrentRoom.GetPlayer((int)JJPJHIHBOIB, true), turkeyNpc.ENJONALDAHE());
		}
		if (Object.op_Implicit((Object)(object)crabNpc) && ((Behaviour)crabNpc).enabled)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			Player player = PhotonNetwork.CurrentRoom.GetPlayer((int)JJPJHIHBOIB, true);
			object[] array = new object[1];
			array[1] = crabNpc.IAGFJODCDBJ();
			OnlineManager.SendRPC(photonView, "LE_17", player, array);
		}
	}

	public void ILCOBOECIDB(int GDHFHKKMIEP)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = GDHFHKKMIEP;
		OnlineManager.SendRPC(photonView, "_", (RpcTarget)0, array);
	}

	public void EGKJJNEDFNO(float NCPGNLOJGAF, float JLMAILGJNCE, bool CDPAMNIPPEC)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)turkeyNpc))
		{
			turkeyNpc.BLHEKDCEDHN(new Vector3(NCPGNLOJGAF, JLMAILGJNCE, 616f), CDPAMNIPPEC);
		}
		else if (Object.op_Implicit((Object)(object)crabNpc))
		{
			crabNpc.Run(new Vector3(NCPGNLOJGAF, JLMAILGJNCE, 131f), CDPAMNIPPEC);
		}
	}

	public void LEFDLNIOELM(TriggerName MOLBHODJMDK)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Screen width: ", (RpcTarget)1, (byte)MOLBHODJMDK);
	}

	public void BPPPJHPCDLN(TriggerName MOLBHODJMDK)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = (byte)MOLBHODJMDK;
		OnlineManager.SendRPC(photonView, "Direction", (RpcTarget)1, array);
	}

	public void PANGIAFLIJH(int GDHFHKKMIEP)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = GDHFHKKMIEP;
		OnlineManager.SendRPC(photonView, "Lose", (RpcTarget)1, array);
	}

	public void KANBOPINMPG(short JJPJHIHBOIB)
	{
		if (Object.op_Implicit((Object)(object)turkeyNpc) && ((Behaviour)turkeyNpc).enabled)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			Player player = PhotonNetwork.CurrentRoom.GetPlayer((int)JJPJHIHBOIB, true);
			object[] array = new object[0];
			array[0] = turkeyNpc.MFDIPEAFJFO();
			OnlineManager.DBNIKCMHHMJ(photonView, "Sending upgrade tool collect RPC", player, array);
		}
		if (Object.op_Implicit((Object)(object)crabNpc) && ((Behaviour)crabNpc).enabled)
		{
			PhotonView photonView2 = ((MonoBehaviourPun)this).photonView;
			Player player2 = PhotonNetwork.CurrentRoom.GetPlayer((int)JJPJHIHBOIB, false);
			object[] array2 = new object[0];
			array2[0] = crabNpc.IAGFJODCDBJ();
			OnlineManager.SendRPC(photonView2, "Sweep", player2, array2);
		}
	}

	public void GJMPCLLPPMK(int GDHFHKKMIEP)
	{
		if (Object.op_Implicit((Object)(object)turkeyNpc))
		{
			turkeyNpc.LOPPJEADGGK(GDHFHKKMIEP, CDPAMNIPPEC: false);
		}
		else if (Object.op_Implicit((Object)(object)crabNpc))
		{
			crabNpc.DPPKJMGCNGG(GDHFHKKMIEP, CDPAMNIPPEC: false);
		}
	}

	public void CBCCFFJMNGD(Vector3 JBMDOGNFIGJ)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = JBMDOGNFIGJ.x;
		array[0] = JBMDOGNFIGJ.y;
		array[4] = false;
		OnlineManager.SendRPC(photonView, "controllers", (RpcTarget)0, array);
	}

	[PunRPC]
	public void ReceiveTrigger(byte MOLBHODJMDK)
	{
		switch ((TriggerName)MOLBHODJMDK)
		{
		case TriggerName.Peek:
			turkeyAnimation.animator.SetTrigger("Peek");
			break;
		case TriggerName.Hurt:
			if (Object.op_Implicit((Object)(object)turkeyAnimation))
			{
				turkeyAnimation.animator.SetBool("Hurt", true);
			}
			else if (Object.op_Implicit((Object)(object)crabAnimation))
			{
				crabAnimation.animator.SetBool("Hurt", true);
			}
			break;
		case TriggerName.Random:
			turkeyAnimation.animator.SetBool("Random", true);
			break;
		}
	}

	public void HHIGHIEPKMG(bool DMBFKFLDDLH)
	{
		if (Object.op_Implicit((Object)(object)turkeyAnimation))
		{
			turkeyAnimation.animator.SetBool("F1", DMBFKFLDDLH);
		}
		else if (Object.op_Implicit((Object)(object)crabAnimation))
		{
			crabAnimation.animator.SetBool("popUpBuilding7", DMBFKFLDDLH);
		}
	}

	public void HFKHJFNMPPA()
	{
		CLKOBJMFKEA.HPFHNKCCHGF();
	}

	public void OABFILFANMH()
	{
		CLKOBJMFKEA.MFCJOLENOFO();
		OJNJOJKNBPE();
	}

	[PunRPC]
	public void ReceiveStatus(int PANEOJGCKIO)
	{
		CLKOBJMFKEA.Enable(CDPAMNIPPEC: false);
		if (Object.op_Implicit((Object)(object)turkeyNpc))
		{
			turkeyNpc.SetLife(PANEOJGCKIO, CDPAMNIPPEC: false);
		}
		else if (Object.op_Implicit((Object)(object)crabNpc))
		{
			crabNpc.SetLife(PANEOJGCKIO, CDPAMNIPPEC: false);
		}
		JKLCEMHACDF();
	}

	public void GJENKGNLLMG(TriggerName MOLBHODJMDK)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Left Stick Button", (RpcTarget)1, (byte)MOLBHODJMDK);
	}

	public void EFFBLPMJDDM(bool DMBFKFLDDLH)
	{
		if (Object.op_Implicit((Object)(object)turkeyAnimation))
		{
			turkeyAnimation.animator.SetBool("shopOpen", DMBFKFLDDLH);
		}
		else if (Object.op_Implicit((Object)(object)crabAnimation))
		{
			crabAnimation.animator.SetBool("Items/item_description_1059", DMBFKFLDDLH);
		}
	}

	public void FKAPJNLLIAA(short JJPJHIHBOIB)
	{
		if (Object.op_Implicit((Object)(object)turkeyNpc) && ((Behaviour)turkeyNpc).enabled)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			Player player = PhotonNetwork.CurrentRoom.GetPlayer((int)JJPJHIHBOIB, false);
			object[] array = new object[0];
			array[0] = turkeyNpc.MFDIPEAFJFO();
			OnlineManager.SendRPC(photonView, "The game took too long to connect to the server.\nPlease, try again later.", player, array);
		}
		if (Object.op_Implicit((Object)(object)crabNpc) && ((Behaviour)crabNpc).enabled)
		{
			OnlineManager.DBNIKCMHHMJ(((MonoBehaviourPun)this).photonView, "Items/item_name_664", PhotonNetwork.CurrentRoom.GetPlayer((int)JJPJHIHBOIB, false), new object[1] { crabNpc.IAGFJODCDBJ() });
		}
	}

	public void JFKAMOHJLHH(bool DMBFKFLDDLH)
	{
		if (Object.op_Implicit((Object)(object)turkeyAnimation))
		{
			turkeyAnimation.animator.SetBool("Disabled", DMBFKFLDDLH);
		}
		else if (Object.op_Implicit((Object)(object)crabAnimation))
		{
			crabAnimation.animator.SetBool("/", DMBFKFLDDLH);
		}
	}

	public void CDLCPOJFLCJ()
	{
		if (OnlineManager.ClientOnline())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, ".", (RpcTarget)5, (short)PhotonNetwork.LocalPlayer.ActorNumber);
		}
	}

	public void DCCCHEGCHII(bool DMBFKFLDDLH)
	{
		if (Object.op_Implicit((Object)(object)turkeyAnimation))
		{
			turkeyAnimation.animator.SetBool("TermasInterior/Rin/Intro", DMBFKFLDDLH);
		}
		else if (Object.op_Implicit((Object)(object)crabAnimation))
		{
			crabAnimation.animator.SetBool("Dialogue System/Conversation/Crowly_Standar/Entry/15/Dialogue Text", DMBFKFLDDLH);
		}
	}

	public void JGDALHDACDC(int GDHFHKKMIEP)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = GDHFHKKMIEP;
		OnlineManager.SendRPC(photonView, "Label", (RpcTarget)0, array);
	}

	public void CCLGNGGGJND(bool DMBFKFLDDLH)
	{
		if (Object.op_Implicit((Object)(object)turkeyAnimation))
		{
			turkeyAnimation.animator.SetBool("Game", DMBFKFLDDLH);
		}
		else if (Object.op_Implicit((Object)(object)crabAnimation))
		{
			crabAnimation.animator.SetBool("daysLeft", DMBFKFLDDLH);
		}
	}

	public void OCLLNDCAIOP()
	{
		CLKOBJMFKEA.HPFHNKCCHGF(CDPAMNIPPEC: false);
	}

	public override void OnJoinedRoom()
	{
		((MonoBehaviourPunCallbacks)this).OnJoinedRoom();
		RequestStatus();
	}

	public void GAMHJKNKKEC()
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[1] = (short)PhotonNetwork.LocalPlayer.ActorNumber;
			OnlineManager.SendRPC(photonView, "ReceiveTorchPuzzle", (RpcTarget)1, array);
		}
	}

	public void BEBCPOPNFGN(byte MOLBHODJMDK)
	{
		switch ((TriggerName)MOLBHODJMDK)
		{
		case TriggerName.Peek:
			turkeyAnimation.animator.SetTrigger("Room ");
			break;
		case TriggerName.Hurt:
			if (Object.op_Implicit((Object)(object)turkeyAnimation))
			{
				turkeyAnimation.animator.SetBool("No camera found! Is a camera available in the scene?", false);
			}
			else if (Object.op_Implicit((Object)(object)crabAnimation))
			{
				crabAnimation.animator.SetBool("Player", true);
			}
			break;
		case TriggerName.Random:
			turkeyAnimation.animator.SetBool("ReceiveTrends", true);
			break;
		}
	}

	public void JJLMBELIPGE(int PANEOJGCKIO)
	{
		CLKOBJMFKEA.IJNPIMIHELL(CDPAMNIPPEC: false);
		if (Object.op_Implicit((Object)(object)turkeyNpc))
		{
			turkeyNpc.GKPIMLNJDLO(PANEOJGCKIO, CDPAMNIPPEC: false);
		}
		else if (Object.op_Implicit((Object)(object)crabNpc))
		{
			crabNpc.APAEBDOGJMN(PANEOJGCKIO, CDPAMNIPPEC: false);
		}
		JKLCEMHACDF();
	}

	public void HBPLADEEBHK()
	{
		CLKOBJMFKEA.BFMDPEIGJDO();
		ILGCNEDAPNM();
	}

	public void ACJIELGLAJB(Vector3 JBMDOGNFIGJ)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Error_IsBlockingChanges", (RpcTarget)1, JBMDOGNFIGJ.x, JBMDOGNFIGJ.y, null, null, null, null, true);
	}

	public void AHMDDNJGAFE(Vector3 JBMDOGNFIGJ)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[8];
		array[0] = JBMDOGNFIGJ.x;
		array[0] = JBMDOGNFIGJ.y;
		array[3] = false;
		OnlineManager.SendRPC(photonView, ":<color=#3a0603> +", (RpcTarget)3, array);
	}

	public void GBFJNIBGABF(float NCPGNLOJGAF, float JLMAILGJNCE, bool CDPAMNIPPEC)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)turkeyNpc))
		{
			turkeyNpc.KPEMDKAOANI(new Vector3(NCPGNLOJGAF, JLMAILGJNCE, 792f), CDPAMNIPPEC);
		}
		else if (Object.op_Implicit((Object)(object)crabNpc))
		{
			crabNpc.KPEMDKAOANI(new Vector3(NCPGNLOJGAF, JLMAILGJNCE, 516f), CDPAMNIPPEC);
		}
	}

	public void IGKLNKMLMMK()
	{
		CLKOBJMFKEA.HPFHNKCCHGF();
	}

	public void DJNIGDCGOFM(int GDHFHKKMIEP)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = GDHFHKKMIEP;
		OnlineManager.SendRPC(photonView, "TavernDirty", (RpcTarget)0, array);
	}

	public void OBLLBGGKIGH(int GDHFHKKMIEP)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = GDHFHKKMIEP;
		OnlineManager.SendRPC(photonView, "Run", (RpcTarget)0, array);
	}

	public void EEBFPKLCMAF(int PANEOJGCKIO)
	{
		CLKOBJMFKEA.MFCJOLENOFO(CDPAMNIPPEC: false);
		if (Object.op_Implicit((Object)(object)turkeyNpc))
		{
			turkeyNpc.DAFOLIIBHPP(PANEOJGCKIO, CDPAMNIPPEC: true);
		}
		else if (Object.op_Implicit((Object)(object)crabNpc))
		{
			crabNpc.AEHPMEMJEAI(PANEOJGCKIO, CDPAMNIPPEC: false);
		}
		NGBFLJFAPCK();
	}

	public void JBDJOIACLKJ(TriggerName MOLBHODJMDK)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Chat deselected", (RpcTarget)1, (byte)MOLBHODJMDK);
	}

	private void DIBFBOOMMPP()
	{
		if (!OnlineManager.MasterOrOffline())
		{
			if (Object.op_Implicit((Object)(object)turkeyNpc))
			{
				((Behaviour)turkeyNpc).enabled = false;
			}
			if (Object.op_Implicit((Object)(object)crabNpc))
			{
				((Behaviour)crabNpc).enabled = false;
			}
		}
	}

	public void MCCBAFAEMFL(int GDHFHKKMIEP)
	{
		if (Object.op_Implicit((Object)(object)turkeyNpc))
		{
			turkeyNpc.SetLife(GDHFHKKMIEP, CDPAMNIPPEC: true);
		}
		else if (Object.op_Implicit((Object)(object)crabNpc))
		{
			crabNpc.DIECPKPDHAC(GDHFHKKMIEP, CDPAMNIPPEC: true);
		}
	}

	private void BDJKNKIOPIJ()
	{
		if (Object.op_Implicit((Object)(object)turkeyNpc))
		{
			CLKOBJMFKEA = turkeyNpc.poolObject;
		}
		if (Object.op_Implicit((Object)(object)crabNpc))
		{
			CLKOBJMFKEA = crabNpc.poolObject;
		}
		CLKOBJMFKEA.onlineTurkey = this;
		OFMDABCKDLC();
	}

	public void LGHGEJCFOOH(Vector3 JBMDOGNFIGJ)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = JBMDOGNFIGJ.x;
		array[0] = JBMDOGNFIGJ.y;
		array[8] = true;
		OnlineManager.SendRPC(photonView, "Player", (RpcTarget)1, array);
	}

	public void BBJPJFIPJDL(int GDHFHKKMIEP)
	{
		if (Object.op_Implicit((Object)(object)turkeyNpc))
		{
			turkeyNpc.LPDLEDLIHGL(GDHFHKKMIEP, CDPAMNIPPEC: true);
		}
		else if (Object.op_Implicit((Object)(object)crabNpc))
		{
			crabNpc.DPPKJMGCNGG(GDHFHKKMIEP, CDPAMNIPPEC: true);
		}
	}

	public void EGEKGKHCFON(int PANEOJGCKIO)
	{
		CLKOBJMFKEA.Enable();
		if (Object.op_Implicit((Object)(object)turkeyNpc))
		{
			turkeyNpc.GKPIMLNJDLO(PANEOJGCKIO, CDPAMNIPPEC: false);
		}
		else if (Object.op_Implicit((Object)(object)crabNpc))
		{
			crabNpc.ONKHBDGNKAE(PANEOJGCKIO, CDPAMNIPPEC: false);
		}
		ILGCNEDAPNM();
	}

	public void COMHPHBBLOH(TriggerName MOLBHODJMDK)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = (byte)MOLBHODJMDK;
		OnlineManager.SendRPC(photonView, "Precision/DrinkEvent5", (RpcTarget)1, array);
	}

	public void MCHIMNKHDME(bool DMBFKFLDDLH)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = DMBFKFLDDLH;
		OnlineManager.SendRPC(photonView, "Items/item_description_1114", (RpcTarget)0, array);
	}

	public void OHCHFJDNCOC(Vector3 JBMDOGNFIGJ)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[8];
		array[1] = JBMDOGNFIGJ.x;
		array[0] = JBMDOGNFIGJ.y;
		array[4] = false;
		OnlineManager.SendRPC(photonView, "Shader Model 5.0 ( DX11.0 )", (RpcTarget)1, array);
	}

	public void MHMGKIJCLCD(Vector3 JBMDOGNFIGJ)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = JBMDOGNFIGJ.x;
		array[1] = JBMDOGNFIGJ.y;
		array[8] = true;
		OnlineManager.SendRPC(photonView, "Can't add more than {0} options.", (RpcTarget)0, array);
	}

	public void HPKMPHNGIBF(short JJPJHIHBOIB)
	{
		if (Object.op_Implicit((Object)(object)turkeyNpc) && ((Behaviour)turkeyNpc).enabled)
		{
			OnlineManager.DBNIKCMHHMJ(((MonoBehaviourPun)this).photonView, "ReceiveDisableContent", PhotonNetwork.CurrentRoom.GetPlayer((int)JJPJHIHBOIB, false), new object[1] { turkeyNpc.EFGHIDBEKKL() });
		}
		if (Object.op_Implicit((Object)(object)crabNpc) && ((Behaviour)crabNpc).enabled)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "- ", PhotonNetwork.CurrentRoom.GetPlayer((int)JJPJHIHBOIB, true), crabNpc.IAGFJODCDBJ());
		}
	}

	public void OEHHBPOAFOA()
	{
		CLKOBJMFKEA.PGPDMODLGFD();
		KALLGJBOOJI();
	}

	public void NNOLGPDBFML(bool DMBFKFLDDLH)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = DMBFKFLDDLH;
		OnlineManager.SendRPC(photonView, "BARKBUZZ", (RpcTarget)0, array);
	}

	[PunRPC]
	public void ReceiveEnable()
	{
		CLKOBJMFKEA.Enable(CDPAMNIPPEC: false);
		JKLCEMHACDF();
	}

	public void AKJJGDJHFIE(int GDHFHKKMIEP)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = GDHFHKKMIEP;
		OnlineManager.SendRPC(photonView, "Path Found", (RpcTarget)0, array);
	}

	private void ILGCNEDAPNM()
	{
		if (!OnlineManager.PGAGDFAEEFB())
		{
			if (Object.op_Implicit((Object)(object)turkeyNpc))
			{
				((Behaviour)turkeyNpc).enabled = true;
			}
			if (Object.op_Implicit((Object)(object)crabNpc))
			{
				((Behaviour)crabNpc).enabled = false;
			}
		}
	}

	public void FJPFELOLMCO(bool OEDBPACCOGH)
	{
		if (OEDBPACCOGH)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "<sprite name=reputationIcon>", (RpcTarget)0);
		}
		else
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "MissionsManager instance has not been initialized properly, this could be a false positive.", (RpcTarget)1);
		}
	}

	public void EMEJJDCGOPF(bool DMBFKFLDDLH)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ValuePlaycount", (RpcTarget)1, DMBFKFLDDLH);
	}

	protected override void MKFDEDDJMBG()
	{
		PPHIMGHODKK = "Turkey";
	}

	public void RequestStatus()
	{
		if (OnlineManager.ClientOnline())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "SendStatus", (RpcTarget)2, (short)PhotonNetwork.LocalPlayer.ActorNumber);
		}
	}

	private void OJNJOJKNBPE()
	{
		if (!OnlineManager.MasterOrOffline())
		{
			if (Object.op_Implicit((Object)(object)turkeyNpc))
			{
				((Behaviour)turkeyNpc).enabled = true;
			}
			if (Object.op_Implicit((Object)(object)crabNpc))
			{
				((Behaviour)crabNpc).enabled = true;
			}
		}
	}

	public void NEKEFIOOOCG(int GDHFHKKMIEP)
	{
		if (Object.op_Implicit((Object)(object)turkeyNpc))
		{
			turkeyNpc.LOPPJEADGGK(GDHFHKKMIEP, CDPAMNIPPEC: true);
		}
		else if (Object.op_Implicit((Object)(object)crabNpc))
		{
			crabNpc.HEAJPFFIHKC(GDHFHKKMIEP, CDPAMNIPPEC: false);
		}
	}

	public void HFCMJBKLCCO(bool OEDBPACCOGH)
	{
		if (OEDBPACCOGH)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Items/item_name_1182", (RpcTarget)0);
		}
		else
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ActorBedAssigned removed actorNumber: ", (RpcTarget)1);
		}
	}

	public void IMKOOOLLAOF(Vector3 JBMDOGNFIGJ)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[3];
		array[0] = JBMDOGNFIGJ.x;
		array[0] = JBMDOGNFIGJ.y;
		array[4] = false;
		OnlineManager.SendRPC(photonView, "Close", (RpcTarget)3, array);
	}

	public void SendBool(bool DMBFKFLDDLH)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveBool", (RpcTarget)1, DMBFKFLDDLH);
	}

	public void AELJPCJIEHL(byte MOLBHODJMDK)
	{
		switch ((TriggerName)MOLBHODJMDK)
		{
		case TriggerName.Peek:
			turkeyAnimation.animator.SetTrigger("Master client");
			break;
		case TriggerName.Hurt:
			if (Object.op_Implicit((Object)(object)turkeyAnimation))
			{
				turkeyAnimation.animator.SetBool("itemLargeRock", true);
			}
			else if (Object.op_Implicit((Object)(object)crabAnimation))
			{
				crabAnimation.animator.SetBool("KyrohNPC: Selected order with already ingredients in bento: ", false);
			}
			break;
		case TriggerName.Random:
			turkeyAnimation.animator.SetBool("quest_description_", true);
			break;
		}
	}

	public void CAGMIALCHFL(int GDHFHKKMIEP)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = GDHFHKKMIEP;
		OnlineManager.SendRPC(photonView, "Intro20", (RpcTarget)0, array);
	}

	[PunRPC]
	public void SendStatus(short JJPJHIHBOIB)
	{
		if (Object.op_Implicit((Object)(object)turkeyNpc) && ((Behaviour)turkeyNpc).enabled)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveStatus", PhotonNetwork.CurrentRoom.GetPlayer((int)JJPJHIHBOIB, false), turkeyNpc.GetLives());
		}
		if (Object.op_Implicit((Object)(object)crabNpc) && ((Behaviour)crabNpc).enabled)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveStatus", PhotonNetwork.CurrentRoom.GetPlayer((int)JJPJHIHBOIB, false), crabNpc.GetLives());
		}
	}

	public void POOBOLNBDJN(Vector3 JBMDOGNFIGJ)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = JBMDOGNFIGJ.x;
		array[1] = JBMDOGNFIGJ.y;
		array[2] = false;
		OnlineManager.SendRPC(photonView, "- ", (RpcTarget)1, array);
	}

	public void JAIAAHFAFCD()
	{
		CLKOBJMFKEA.BFMDPEIGJDO();
		NGBFLJFAPCK();
	}

	public void LKJONCOJPHI(bool OEDBPACCOGH)
	{
		if (OEDBPACCOGH)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveItemSlotFromContainer", (RpcTarget)0);
		}
		else
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "xp", (RpcTarget)1);
		}
	}

	[PunRPC]
	public void ReceiveHit(float NCPGNLOJGAF, float JLMAILGJNCE, bool CDPAMNIPPEC)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)turkeyNpc))
		{
			turkeyNpc.Run(new Vector3(NCPGNLOJGAF, JLMAILGJNCE, 0f), CDPAMNIPPEC);
		}
		else if (Object.op_Implicit((Object)(object)crabNpc))
		{
			crabNpc.Run(new Vector3(NCPGNLOJGAF, JLMAILGJNCE, 0f), CDPAMNIPPEC);
		}
	}

	public void DNJCILJIPLN()
	{
		CLKOBJMFKEA.HPFHNKCCHGF();
	}

	public void DCKPFFOKEHG()
	{
		CLKOBJMFKEA.PGPDMODLGFD();
		OFMDABCKDLC();
	}

	public void DMDKIMJEKNN(Vector3 JBMDOGNFIGJ)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "DecorationTile_7", (RpcTarget)1, JBMDOGNFIGJ.x, JBMDOGNFIGJ.y, false, null, null);
	}

	public void FLAPICKOOGH()
	{
		CLKOBJMFKEA.MFCJOLENOFO(CDPAMNIPPEC: false);
		ILGCNEDAPNM();
	}

	private void KALLGJBOOJI()
	{
		if (!OnlineManager.MasterOrOffline())
		{
			if (Object.op_Implicit((Object)(object)turkeyNpc))
			{
				((Behaviour)turkeyNpc).enabled = true;
			}
			if (Object.op_Implicit((Object)(object)crabNpc))
			{
				((Behaviour)crabNpc).enabled = false;
			}
		}
	}

	public void KJMHOIHEHHL()
	{
		if (OnlineManager.ClientOnline())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[1] = (short)PhotonNetwork.LocalPlayer.ActorNumber;
			OnlineManager.SendRPC(photonView, "Interact", (RpcTarget)1, array);
		}
	}

	public void FHDNOCICFOE(float NCPGNLOJGAF, float JLMAILGJNCE, bool CDPAMNIPPEC)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)turkeyNpc))
		{
			turkeyNpc.LJDIKGJKMBD(new Vector3(NCPGNLOJGAF, JLMAILGJNCE, 46f), CDPAMNIPPEC);
		}
		else if (Object.op_Implicit((Object)(object)crabNpc))
		{
			crabNpc.CDCGNLAKHNM(new Vector3(NCPGNLOJGAF, JLMAILGJNCE, 878f), CDPAMNIPPEC);
		}
	}

	public void CFAPFBFHCGF(byte MOLBHODJMDK)
	{
		switch ((TriggerName)MOLBHODJMDK)
		{
		case TriggerName.Peek:
			turkeyAnimation.animator.SetTrigger("talentSausages");
			break;
		case TriggerName.Hurt:
			if (Object.op_Implicit((Object)(object)turkeyAnimation))
			{
				turkeyAnimation.animator.SetBool("Error in T101_Dormir.CheckOnPlayerSleep: ", true);
			}
			else if (Object.op_Implicit((Object)(object)crabAnimation))
			{
				crabAnimation.animator.SetBool("itemMelon", true);
			}
			break;
		case TriggerName.Random:
			turkeyAnimation.animator.SetBool("<sprite name=reputationIcon>", false);
			break;
		}
	}

	public void KKHGNGKLCGF(int PANEOJGCKIO)
	{
		CLKOBJMFKEA.IJNPIMIHELL();
		if (Object.op_Implicit((Object)(object)turkeyNpc))
		{
			turkeyNpc.LPDLEDLIHGL(PANEOJGCKIO, CDPAMNIPPEC: true);
		}
		else if (Object.op_Implicit((Object)(object)crabNpc))
		{
			crabNpc.HEAJPFFIHKC(PANEOJGCKIO, CDPAMNIPPEC: true);
		}
		KALLGJBOOJI();
	}

	public void FEDLEKGBEKO(int GDHFHKKMIEP)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = GDHFHKKMIEP;
		OnlineManager.SendRPC(photonView, " with state \"", (RpcTarget)0, array);
	}

	public void EOPKDCBHCFE()
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[0] = (short)PhotonNetwork.LocalPlayer.ActorNumber;
			OnlineManager.SendRPC(photonView, ")", (RpcTarget)4, array);
		}
	}

	public void IAKJKAGBMGL(int PANEOJGCKIO)
	{
		CLKOBJMFKEA.MFCJOLENOFO();
		if (Object.op_Implicit((Object)(object)turkeyNpc))
		{
			turkeyNpc.LPDLEDLIHGL(PANEOJGCKIO, CDPAMNIPPEC: true);
		}
		else if (Object.op_Implicit((Object)(object)crabNpc))
		{
			crabNpc.EFLGMHJJMJF(PANEOJGCKIO, CDPAMNIPPEC: false);
		}
		DIBFBOOMMPP();
	}

	public void KLOBLHLOPLB(float NCPGNLOJGAF, float JLMAILGJNCE, bool CDPAMNIPPEC)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)turkeyNpc))
		{
			turkeyNpc.NMGBKFBOEGI(new Vector3(NCPGNLOJGAF, JLMAILGJNCE, 1539f), CDPAMNIPPEC);
		}
		else if (Object.op_Implicit((Object)(object)crabNpc))
		{
			crabNpc.PADLLFOACJM(new Vector3(NCPGNLOJGAF, JLMAILGJNCE, 781f), CDPAMNIPPEC);
		}
	}

	public void LICOHCCNNOI()
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[1] = (short)PhotonNetwork.LocalPlayer.ActorNumber;
			OnlineManager.SendRPC(photonView, "Items/item_name_670", (RpcTarget)8, array);
		}
	}

	public void KEDJMHMHKPP(int GDHFHKKMIEP)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = GDHFHKKMIEP;
		OnlineManager.SendRPC(photonView, "BuildMode_ExitAndSave", (RpcTarget)0, array);
	}

	public void IFPGELEBJNN(Vector3 JBMDOGNFIGJ)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[7];
		array[1] = JBMDOGNFIGJ.x;
		array[0] = JBMDOGNFIGJ.y;
		array[5] = true;
		OnlineManager.SendRPC(photonView, "roomsRented", (RpcTarget)1, array);
	}

	public void MCDFLHCJLGM()
	{
		CLKOBJMFKEA.CEOHLAJIPBD(CDPAMNIPPEC: false);
	}

	public void GMJDHEANFGH(bool DMBFKFLDDLH)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = DMBFKFLDDLH;
		OnlineManager.SendRPC(photonView, "Selected", (RpcTarget)0, array);
	}

	[PunRPC]
	public void ReceiveDisable()
	{
		CLKOBJMFKEA.Disable(CDPAMNIPPEC: false);
	}

	public void CKHLFDKBKPB(bool OEDBPACCOGH)
	{
		if (OEDBPACCOGH)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "LoopVolume", (RpcTarget)1);
		}
		else
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "AllTimeStats", (RpcTarget)0);
		}
	}

	public void DLGEKEDJFLM(TriggerName MOLBHODJMDK)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = (byte)MOLBHODJMDK;
		OnlineManager.SendRPC(photonView, "ReceiveSetVitamins", (RpcTarget)0, array);
	}

	public void OGECCJPBDPC(TriggerName MOLBHODJMDK)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = (byte)MOLBHODJMDK;
		OnlineManager.SendRPC(photonView, "tutorialPopUp102", (RpcTarget)0, array);
	}

	public void DBDFCOBILPL(int GDHFHKKMIEP)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "City/Kujaku/Bark/Buy", (RpcTarget)1, GDHFHKKMIEP);
	}

	private void JKLCEMHACDF()
	{
		if (!OnlineManager.MasterOrOffline())
		{
			if (Object.op_Implicit((Object)(object)turkeyNpc))
			{
				((Behaviour)turkeyNpc).enabled = false;
			}
			if (Object.op_Implicit((Object)(object)crabNpc))
			{
				((Behaviour)crabNpc).enabled = false;
			}
		}
	}

	public void AMBDCFMCJNB()
	{
		CLKOBJMFKEA.IJNPIMIHELL();
		ILGCNEDAPNM();
	}

	public void SendHit(Vector3 JBMDOGNFIGJ)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveHit", (RpcTarget)2, JBMDOGNFIGJ.x, JBMDOGNFIGJ.y, true);
	}

	public void KCJECFFFDPM(int GDHFHKKMIEP)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = GDHFHKKMIEP;
		OnlineManager.SendRPC(photonView, "NO SOUNDTRACK LOADED\n\n Troubleshooting:\n\n1. The folder containing all psai soundtrack data must be located within the 'Resources' folder of your project.\n2. Your Scene must contain the 'Psai.prefab' Game Object with both a PsaiSoundtrackLoader and a PsaiCoreManager-Component.\n3. The PsaiSoundtrackLoader-Component needs to hold the path to the soundtrack file. Drag & Drop that file from your Soundtrack folder in your Project window onto the PsaiPlayerUi component.\n\nPlease see the log output window for more information.", (RpcTarget)0, array);
	}

	public void HNOCHEHKJPC(bool DMBFKFLDDLH)
	{
		if (Object.op_Implicit((Object)(object)turkeyAnimation))
		{
			turkeyAnimation.animator.SetBool("Walk", DMBFKFLDDLH);
		}
		else if (Object.op_Implicit((Object)(object)crabAnimation))
		{
			crabAnimation.animator.SetBool("Southwest", DMBFKFLDDLH);
		}
	}

	private void IABEJCPMJOF()
	{
		if (Object.op_Implicit((Object)(object)turkeyNpc))
		{
			CLKOBJMFKEA = turkeyNpc.poolObject;
		}
		if (Object.op_Implicit((Object)(object)crabNpc))
		{
			CLKOBJMFKEA = crabNpc.poolObject;
		}
		CLKOBJMFKEA.onlineTurkey = this;
		OJNJOJKNBPE();
	}

	public void HNJIPIAJBFI(float NCPGNLOJGAF, float JLMAILGJNCE, bool CDPAMNIPPEC)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)turkeyNpc))
		{
			turkeyNpc.IJFDGKDAEGC(new Vector3(NCPGNLOJGAF, JLMAILGJNCE, 1594f), CDPAMNIPPEC);
		}
		else if (Object.op_Implicit((Object)(object)crabNpc))
		{
			crabNpc.EEBNOILEJAC(new Vector3(NCPGNLOJGAF, JLMAILGJNCE, 1931f), CDPAMNIPPEC);
		}
	}

	public void ANLLDAMCGAJ(bool DMBFKFLDDLH)
	{
		if (Object.op_Implicit((Object)(object)turkeyAnimation))
		{
			turkeyAnimation.animator.SetBool("UIPreviousCategory", DMBFKFLDDLH);
		}
		else if (Object.op_Implicit((Object)(object)crabAnimation))
		{
			crabAnimation.animator.SetBool("Happy", DMBFKFLDDLH);
		}
	}

	public void IPBBGJHIAAE(bool DMBFKFLDDLH)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "BarnTutorialDone", (RpcTarget)1, DMBFKFLDDLH);
	}

	public void SendTrigger(TriggerName MOLBHODJMDK)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveTrigger", (RpcTarget)1, (byte)MOLBHODJMDK);
	}

	public void EGIJOBCFDLJ()
	{
		CLKOBJMFKEA.OIBLNLDJJOL(CDPAMNIPPEC: false);
	}

	public void CLHAOJKJGOL(int GDHFHKKMIEP)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = GDHFHKKMIEP;
		OnlineManager.SendRPC(photonView, "Items/item_name_1038", (RpcTarget)1, array);
	}

	public void PFPCOCIFAOA()
	{
		CLKOBJMFKEA.CNAFDKGAPPI();
	}

	public void CCELKOCICJE(float NCPGNLOJGAF, float JLMAILGJNCE, bool CDPAMNIPPEC)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		if (Object.op_Implicit((Object)(object)turkeyNpc))
		{
			turkeyNpc.KPEMDKAOANI(new Vector3(NCPGNLOJGAF, JLMAILGJNCE, 139f), CDPAMNIPPEC);
		}
		else if (Object.op_Implicit((Object)(object)crabNpc))
		{
			crabNpc.PHCHKDFJJOI(new Vector3(NCPGNLOJGAF, JLMAILGJNCE, 1912f), CDPAMNIPPEC);
		}
	}

	public void OBNDAKLELFF(byte MOLBHODJMDK)
	{
		switch ((TriggerName)MOLBHODJMDK)
		{
		case TriggerName.Peek:
			turkeyAnimation.animator.SetTrigger(" ");
			break;
		case TriggerName.Hurt:
			if (Object.op_Implicit((Object)(object)turkeyAnimation))
			{
				turkeyAnimation.animator.SetBool("on player sleep", true);
			}
			else if (Object.op_Implicit((Object)(object)crabAnimation))
			{
				crabAnimation.animator.SetBool(" get price serve customer ", true);
			}
			break;
		case TriggerName.Random:
			turkeyAnimation.animator.SetBool("ReceiveGetUniqueCropHarvestableOnClient", false);
			break;
		}
	}

	public void FJIMOOMFBOK(Vector3 JBMDOGNFIGJ)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[7];
		array[0] = JBMDOGNFIGJ.x;
		array[0] = JBMDOGNFIGJ.y;
		array[3] = false;
		OnlineManager.SendRPC(photonView, "questNameGruel", (RpcTarget)0, array);
	}

	private void NIAMJLDOIBE()
	{
		if (!OnlineManager.PGAGDFAEEFB())
		{
			if (Object.op_Implicit((Object)(object)turkeyNpc))
			{
				((Behaviour)turkeyNpc).enabled = false;
			}
			if (Object.op_Implicit((Object)(object)crabNpc))
			{
				((Behaviour)crabNpc).enabled = false;
			}
		}
	}

	[PunRPC]
	public void ReceiveSetLife(int GDHFHKKMIEP)
	{
		if (Object.op_Implicit((Object)(object)turkeyNpc))
		{
			turkeyNpc.SetLife(GDHFHKKMIEP, CDPAMNIPPEC: false);
		}
		else if (Object.op_Implicit((Object)(object)crabNpc))
		{
			crabNpc.SetLife(GDHFHKKMIEP, CDPAMNIPPEC: false);
		}
	}

	private void FJMBOFEILBN()
	{
		if (Object.op_Implicit((Object)(object)turkeyNpc))
		{
			CLKOBJMFKEA = turkeyNpc.poolObject;
		}
		if (Object.op_Implicit((Object)(object)crabNpc))
		{
			CLKOBJMFKEA = crabNpc.poolObject;
		}
		CLKOBJMFKEA.onlineTurkey = this;
		ILGCNEDAPNM();
	}

	public void SendSetLife(int GDHFHKKMIEP)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveSetLife", (RpcTarget)1, GDHFHKKMIEP);
	}

	public void SendEnable(bool OEDBPACCOGH)
	{
		if (OEDBPACCOGH)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveEnable", (RpcTarget)1);
		}
		else
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveDisable", (RpcTarget)1);
		}
	}

	public void GOKJEMIKKDD(bool OEDBPACCOGH)
	{
		if (OEDBPACCOGH)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Loop", (RpcTarget)1);
		}
		else
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Crop needs a harvested replace by item ", (RpcTarget)0);
		}
	}

	public void OJHOBCGEJDJ(bool OEDBPACCOGH)
	{
		if (OEDBPACCOGH)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Minigame", (RpcTarget)0);
		}
		else
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Festín del Juramento/JudgeDialogue 02", (RpcTarget)0);
		}
	}

	private void IAIDKPJKLIC()
	{
		if (Object.op_Implicit((Object)(object)turkeyNpc))
		{
			CLKOBJMFKEA = turkeyNpc.poolObject;
		}
		if (Object.op_Implicit((Object)(object)crabNpc))
		{
			CLKOBJMFKEA = crabNpc.poolObject;
		}
		CLKOBJMFKEA.onlineTurkey = this;
		OFMDABCKDLC();
	}

	public void MICLDCIGCCE(bool DMBFKFLDDLH)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = DMBFKFLDDLH;
		OnlineManager.SendRPC(photonView, "Abandon quest?", (RpcTarget)1, array);
	}

	public void OAMHHHKGAHG(int GDHFHKKMIEP)
	{
		if (Object.op_Implicit((Object)(object)turkeyNpc))
		{
			turkeyNpc.DAFOLIIBHPP(GDHFHKKMIEP, CDPAMNIPPEC: false);
		}
		else if (Object.op_Implicit((Object)(object)crabNpc))
		{
			crabNpc.MANFMMAOKNE(GDHFHKKMIEP, CDPAMNIPPEC: true);
		}
	}

	public void DIKALIMFPPL(bool OEDBPACCOGH)
	{
		if (OEDBPACCOGH)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveGenerateMineLevel", (RpcTarget)0);
		}
		else
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Tutorial/T100/Dialogue3", (RpcTarget)1);
		}
	}

	public void HNINNFAHGLJ(int GDHFHKKMIEP)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = GDHFHKKMIEP;
		OnlineManager.SendRPC(photonView, "Looking up current user name...", (RpcTarget)0, array);
	}

	public void IFGFKKDLACB(Vector3 JBMDOGNFIGJ)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[5];
		array[0] = JBMDOGNFIGJ.x;
		array[1] = JBMDOGNFIGJ.y;
		array[0] = true;
		OnlineManager.SendRPC(photonView, "Items/item_description_1078", (RpcTarget)1, array);
	}

	[PunRPC]
	public void ReceiveBool(bool DMBFKFLDDLH)
	{
		if (Object.op_Implicit((Object)(object)turkeyAnimation))
		{
			turkeyAnimation.animator.SetBool("Hurt", DMBFKFLDDLH);
		}
		else if (Object.op_Implicit((Object)(object)crabAnimation))
		{
			crabAnimation.animator.SetBool("Hurt", DMBFKFLDDLH);
		}
	}

	public void GMJOJMOIAND(short JJPJHIHBOIB)
	{
		if (Object.op_Implicit((Object)(object)turkeyNpc) && ((Behaviour)turkeyNpc).enabled)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Error in ProceduralMine.OnPlayerSleep: ", PhotonNetwork.CurrentRoom.GetPlayer((int)JJPJHIHBOIB, false), turkeyNpc.EFGHIDBEKKL());
		}
		if (Object.op_Implicit((Object)(object)crabNpc) && ((Behaviour)crabNpc).enabled)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			Player player = PhotonNetwork.CurrentRoom.GetPlayer((int)JJPJHIHBOIB, true);
			object[] array = new object[0];
			array[1] = crabNpc.HGBEAHBFAJL();
			OnlineManager.DBNIKCMHHMJ(photonView, "StartObserverDialogueWhenItIsPossible ", player, array);
		}
	}

	public void FFBINOHPIEN()
	{
		if (OnlineManager.HHDBMDMFEMP())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Save Game", (RpcTarget)8, (short)PhotonNetwork.LocalPlayer.ActorNumber);
		}
	}

	public void LCGMINGAELE(bool DMBFKFLDDLH)
	{
		if (Object.op_Implicit((Object)(object)turkeyAnimation))
		{
			turkeyAnimation.animator.SetBool("", DMBFKFLDDLH);
		}
		else if (Object.op_Implicit((Object)(object)crabAnimation))
		{
			crabAnimation.animator.SetBool("AddToSurface ", DMBFKFLDDLH);
		}
	}

	private void MLLADNLMIMP()
	{
		if (Object.op_Implicit((Object)(object)turkeyNpc))
		{
			CLKOBJMFKEA = turkeyNpc.poolObject;
		}
		if (Object.op_Implicit((Object)(object)crabNpc))
		{
			CLKOBJMFKEA = crabNpc.poolObject;
		}
		CLKOBJMFKEA.onlineTurkey = this;
		KALLGJBOOJI();
	}

	public void BDPDCNKJMMF(int GDHFHKKMIEP)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "alcoholContentWarning", (RpcTarget)0, GDHFHKKMIEP);
	}

	public void FANGKFNHAPC(TriggerName MOLBHODJMDK)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = (byte)MOLBHODJMDK;
		OnlineManager.SendRPC(photonView, "DoYouWantToRepairIt", (RpcTarget)1, array);
	}

	private void NGBFLJFAPCK()
	{
		if (!OnlineManager.PGAGDFAEEFB())
		{
			if (Object.op_Implicit((Object)(object)turkeyNpc))
			{
				((Behaviour)turkeyNpc).enabled = false;
			}
			if (Object.op_Implicit((Object)(object)crabNpc))
			{
				((Behaviour)crabNpc).enabled = false;
			}
		}
	}
}
