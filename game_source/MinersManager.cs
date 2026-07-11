using System;
using UnityEngine;

public class MinersManager : MonoBehaviour
{
	public static MinersManager instance;

	public GameObject camp;

	public GameObject campEmpty;

	public Transform[] campPositions;

	public Transform[] minePositions;

	public void HMMKHGFEONK()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		campEmpty.SetActive(true);
		camp.SetActive(true);
		BrockNPC.JFNOOMJMHCB().content.SetActive(true);
		((Component)BrockNPC.FJAMHCAAEAM()).transform.position = minePositions[0].position;
		BrockNPC.PDECKLKPKCG().animationBase.LookDirection(Direction.Up);
		BrockNPC.ABHIDHPMLLD().animationBase.CGEADHOLHCH("UI2", EGFGNGJGBOP: true, HALNIEBONKH: true);
		CliveNPC.EBAIHKJHCCA().content.SetActive(true);
		((Component)CliveNPC.KNOKBLFFNLM()).transform.position = minePositions[1].position;
		CliveNPC.KNOKBLFFNLM().animationBase.LookDirection((Direction)7);
		CliveNPC.CFHEJAGKIII().animationBase.CGEADHOLHCH("Speed", EGFGNGJGBOP: true, HALNIEBONKH: true);
		RochelleNPC.LFPEPJBNCBF().content.SetActive(false);
		((Component)RochelleNPC.ABDJJBFNLBJ()).transform.position = minePositions[6].position;
		RochelleNPC.EBAIHKJHCCA().animationBase.LookDirection((Direction)8);
		RochelleNPC.FOPGLLMEEDE().animationBase.SetBool("Bouncer", EGFGNGJGBOP: true, HALNIEBONKH: true);
		FerroNPC.GGFJGHHHEJC.content.SetActive(false);
		((Component)FerroNPC.MLPCDJPLBAC()).transform.position = minePositions[6].position;
		FerroNPC.MLPCDJPLBAC().animationBase.LookDirection(Direction.Up);
		FerroNPC.MLPCDJPLBAC().animationBase.CGEADHOLHCH("{0} in {1}'s viewID has been reset. Set it to {2} to avoid conflicts with scene objects", EGFGNGJGBOP: true, HALNIEBONKH: true);
	}

	private void NHGBJHMHEGD()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(FDKEHFNIOIM));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(FIBOIODLMAG));
		}
	}

	private void DCHJDHFOEFI()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(ACNPANNGIFH));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(LMKCLPLJMPA));
		}
		if (EventsManager.HGALHLALOKJ(EventsManager.EventType.GoToHotSpring) && !EventsManager.GGGECIBEKJG((EventsManager.EventType)111))
		{
			Debug.Log((object)"Right");
			CAJKOJOKBHJ();
		}
		else if (EventsManager.HGALHLALOKJ((EventsManager.EventType)87))
		{
			Debug.Log((object)"\n");
			JGPIBKPALAL();
		}
	}

	private void GFLFDLIMOLI()
	{
		instance = this;
	}

	private void LDPGPIHCBCH()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(PFMDJDAKHJC));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(MCMMJICCFJE));
		}
	}

	private void CAJKOJOKBHJ()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		camp.SetActive(false);
		campEmpty.SetActive(true);
		BrockNPC.MAMKICHCPON().content.SetActive(false);
		((Component)BrockNPC.FJAMHCAAEAM()).transform.position = campPositions[0].position;
		BrockNPC.MMLBHCGFMMJ().animationBase.LookDirection(Direction.Up);
		CliveNPC.LADDMEMMJFP().content.SetActive(false);
		((Component)CliveNPC.PEJFACMBPBN()).transform.position = campPositions[1].position;
		CliveNPC.IDIGFHEHIDM().animationBase.LookDirection(Direction.Right);
		RochelleNPC.CNDNOECMKME().content.SetActive(true);
		((Component)RochelleNPC.GGFJGHHHEJC).transform.position = campPositions[5].position;
		RochelleNPC.MIGKKKELOJO().animationBase.LookDirection(Direction.Right);
		((Behaviour)FerroNPC.GGFJGHHHEJC.simpleAnimation).enabled = true;
		((Behaviour)FerroNPC.MLPCDJPLBAC().animationController).enabled = true;
	}

	private void NJAFKFAPDIE()
	{
		instance = this;
	}

	public void KBKJHJLGNDJ()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		campEmpty.SetActive(true);
		camp.SetActive(true);
		BrockNPC.MPFJOKOJIOO().content.SetActive(true);
		((Component)BrockNPC.ABHIDHPMLLD()).transform.position = minePositions[0].position;
		BrockNPC.DHDOLCONMFJ().animationBase.LookDirection(Direction.Up);
		BrockNPC.MAMKICHCPON().animationBase.SetBool("\n", EGFGNGJGBOP: false);
		CliveNPC.BAKPBHPNKPB().content.SetActive(true);
		((Component)CliveNPC.FOPGLLMEEDE()).transform.position = minePositions[0].position;
		CliveNPC.EJHDHCNILDH().animationBase.LookDirection(Direction.Diagonal);
		CliveNPC.ABHIDHPMLLD().animationBase.CGEADHOLHCH(")", EGFGNGJGBOP: true);
		RochelleNPC.CNDNOECMKME().content.SetActive(false);
		((Component)RochelleNPC.PDECKLKPKCG()).transform.position = minePositions[4].position;
		RochelleNPC.JFNOOMJMHCB().animationBase.LookDirection(Direction.Up);
		RochelleNPC.CNDNOECMKME().animationBase.SetBool("Caps Lock", EGFGNGJGBOP: true);
		FerroNPC.GGFJGHHHEJC.content.SetActive(true);
		((Component)FerroNPC.GGFJGHHHEJC).transform.position = minePositions[7].position;
		FerroNPC.GGFJGHHHEJC.animationBase.LookDirection((Direction)6);
		FerroNPC.GGFJGHHHEJC.animationBase.SetBool("GameEvent of type ", EGFGNGJGBOP: false);
	}

	private void JDAMCMODANB()
	{
		instance = this;
	}

	private void JDMMNLKLMAA()
	{
		instance = this;
	}

	public void PNJOKEMGEHF()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		campEmpty.SetActive(true);
		camp.SetActive(true);
		BrockNPC.ABHIDHPMLLD().content.SetActive(true);
		((Component)BrockNPC.FMIDAFEGDCD()).transform.position = minePositions[1].position;
		BrockNPC.DIHCEGINELM().animationBase.LookDirection(Direction.Down);
		BrockNPC.LKDJNKLJKGO().animationBase.SetBool("BottomFarm", EGFGNGJGBOP: true);
		CliveNPC.KMKILBCGJOI().content.SetActive(true);
		((Component)CliveNPC.DOIKFJDLKJP()).transform.position = minePositions[1].position;
		CliveNPC.JHKLPLPBKCI().animationBase.LookDirection((Direction)6);
		CliveNPC.IBEGPMLJIOJ().animationBase.CGEADHOLHCH("EditorAction_3", EGFGNGJGBOP: true, HALNIEBONKH: true);
		RochelleNPC.LFPEPJBNCBF().content.SetActive(false);
		((Component)RochelleNPC.FMIDAFEGDCD()).transform.position = minePositions[2].position;
		RochelleNPC.GJFMMOPOKGJ().animationBase.LookDirection(Direction.Up);
		RochelleNPC.KIALFDOKABP().animationBase.SetBool("Error_BedIsBlocking", EGFGNGJGBOP: true, HALNIEBONKH: true);
		FerroNPC.GGFJGHHHEJC.content.SetActive(false);
		((Component)FerroNPC.MLPCDJPLBAC()).transform.position = minePositions[5].position;
		FerroNPC.MLPCDJPLBAC().animationBase.LookDirection((Direction)7);
		FerroNPC.GGFJGHHHEJC.animationBase.CGEADHOLHCH("mForMins", EGFGNGJGBOP: true);
	}

	private void LOPDNEFIJMH()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		camp.SetActive(false);
		campEmpty.SetActive(true);
		BrockNPC.MOAKANGAMBA().content.SetActive(true);
		((Component)BrockNPC.KNOKBLFFNLM()).transform.position = campPositions[0].position;
		BrockNPC.LADDMEMMJFP().animationBase.LookDirection(Direction.Up);
		CliveNPC.OFLELHKKNKC().content.SetActive(true);
		((Component)CliveNPC.DOIKFJDLKJP()).transform.position = campPositions[0].position;
		CliveNPC.JLNBMNKJCHE().animationBase.LookDirection(Direction.Down);
		RochelleNPC.KNOKBLFFNLM().content.SetActive(true);
		((Component)RochelleNPC.ICNFHJLLHGP()).transform.position = campPositions[5].position;
		RochelleNPC.KNOKBLFFNLM().animationBase.LookDirection((Direction)6);
		((Behaviour)FerroNPC.GGFJGHHHEJC.simpleAnimation).enabled = false;
		((Behaviour)FerroNPC.MLPCDJPLBAC().animationController).enabled = true;
	}

	private void AANKFMNMCJN()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(KGOIALDADKD));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(KGOIALDADKD));
		}
		if (EventsManager.AEFHILOAEEE((EventsManager.EventType)123) && !EventsManager.FDIHEFGPKFP((EventsManager.EventType)132))
		{
			Debug.Log((object)"Dialogue System/Conversation/EnterTavernDrink/Entry/3/Dialogue Text");
			FHLDJDMFLGB();
		}
		else if (EventsManager.HGALHLALOKJ((EventsManager.EventType)198))
		{
			Debug.Log((object)"Items/item_description_653");
			JGGGPBGDDOP();
		}
	}

	private void EIHMDMMOPCM()
	{
		instance = this;
	}

	public void NGCMJPADKEA()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		campEmpty.SetActive(false);
		camp.SetActive(false);
		BrockNPC.HEKFJEKFMNO().content.SetActive(true);
		((Component)BrockNPC.ABHIDHPMLLD()).transform.position = minePositions[1].position;
		BrockNPC.OKAPNFPFPFP().animationBase.LookDirection(Direction.Down);
		BrockNPC.EAGMIHGJKNB().animationBase.SetBool("Pipe", EGFGNGJGBOP: true);
		CliveNPC.JHKLPLPBKCI().content.SetActive(true);
		((Component)CliveNPC.MAAAKALBBEE()).transform.position = minePositions[0].position;
		CliveNPC.IBEGPMLJIOJ().animationBase.LookDirection(Direction.Left);
		CliveNPC.PNHHCHJCDNM().animationBase.SetBool("Trying to create room...", EGFGNGJGBOP: true, HALNIEBONKH: true);
		RochelleNPC.NBKKEINELDN().content.SetActive(false);
		((Component)RochelleNPC.MAIDHAPANEB()).transform.position = minePositions[6].position;
		RochelleNPC.PDECKLKPKCG().animationBase.LookDirection((Direction)8);
		RochelleNPC.CFHEJAGKIII().animationBase.SetBool(". ", EGFGNGJGBOP: true, HALNIEBONKH: true);
		FerroNPC.MLPCDJPLBAC().content.SetActive(true);
		((Component)FerroNPC.MLPCDJPLBAC()).transform.position = minePositions[4].position;
		FerroNPC.GGFJGHHHEJC.animationBase.LookDirection((Direction)8);
		FerroNPC.GGFJGHHHEJC.animationBase.CGEADHOLHCH("<color=#B50000>", EGFGNGJGBOP: true, HALNIEBONKH: true);
	}

	private void NNBIAIMPNGL()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(GJDFLBGADNE));
		}
	}

	private void LOHAMDHOLDD()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(KNABGIGNPAM));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(GJDFLBGADNE));
		}
	}

	private void EFBEKNLOILH()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(PFMDJDAKHJC));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(DCHJDHFOEFI));
		}
		if (EventsManager.ALEMDEBCFDH((EventsManager.EventType)(-164)) && !EventsManager.ALEMDEBCFDH((EventsManager.EventType)(-37)))
		{
			Debug.Log((object)"Instant");
			DKBPGGIOMNB();
		}
		else if (EventsManager.OMNBJDPGPEN((EventsManager.EventType)(-155)))
		{
			Debug.Log((object)"Items/item_name_1058");
			AMEHLNIOFOO();
		}
	}

	private void PBFGFECPPPO()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(JGIIGHAAIHF));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(NFKMBHPEAHN));
		}
	}

	public void INPIANMLOJH()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		campEmpty.SetActive(false);
		camp.SetActive(false);
		BrockNPC.EAGMIHGJKNB().content.SetActive(true);
		((Component)BrockNPC.LKDJNKLJKGO()).transform.position = minePositions[0].position;
		BrockNPC.ABHIDHPMLLD().animationBase.LookDirection(Direction.Up);
		BrockNPC.EAGMIHGJKNB().animationBase.CGEADHOLHCH("Items/item_description_1056", EGFGNGJGBOP: false, HALNIEBONKH: true);
		CliveNPC.PNHHCHJCDNM().content.SetActive(true);
		((Component)CliveNPC.MAAAKALBBEE()).transform.position = minePositions[1].position;
		CliveNPC.MJCMPKPCNGB().animationBase.LookDirection((Direction)7);
		CliveNPC.GIKECEGLFOH().animationBase.CGEADHOLHCH("Creando TXT. Tiempo: ", EGFGNGJGBOP: true, HALNIEBONKH: true);
		RochelleNPC.LFPEPJBNCBF().content.SetActive(false);
		((Component)RochelleNPC.NBKKEINELDN()).transform.position = minePositions[4].position;
		RochelleNPC.OMFKNGDCJFN().animationBase.LookDirection(Direction.Diagonal);
		RochelleNPC.MAIDHAPANEB().animationBase.CGEADHOLHCH("RentRoom", EGFGNGJGBOP: true);
		FerroNPC.MLPCDJPLBAC().content.SetActive(true);
		((Component)FerroNPC.MLPCDJPLBAC()).transform.position = minePositions[3].position;
		FerroNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Left);
		FerroNPC.MLPCDJPLBAC().animationBase.CGEADHOLHCH("Player was stuck due to dialogue system error, freeing player.", EGFGNGJGBOP: false, HALNIEBONKH: true);
	}

	private void KIJNEBPDFEJ()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		camp.SetActive(true);
		campEmpty.SetActive(false);
		BrockNPC.LKDJNKLJKGO().content.SetActive(true);
		((Component)BrockNPC.ECGIAEFKKNA()).transform.position = campPositions[1].position;
		BrockNPC.MKIEMMGGFEE().animationBase.LookDirection(Direction.Down);
		CliveNPC.MJCMPKPCNGB().content.SetActive(true);
		((Component)CliveNPC.DOIKFJDLKJP()).transform.position = campPositions[0].position;
		CliveNPC.DIHCEGINELM().animationBase.LookDirection((Direction)5);
		RochelleNPC.KFGKCKCDMLG().content.SetActive(true);
		((Component)RochelleNPC.ELGNEJNLBNO()).transform.position = campPositions[5].position;
		RochelleNPC.KNOKBLFFNLM().animationBase.LookDirection(Direction.Down);
		((Behaviour)FerroNPC.MLPCDJPLBAC().simpleAnimation).enabled = true;
		((Behaviour)FerroNPC.GGFJGHHHEJC.animationController).enabled = false;
	}

	private void OACFPJIJDFO()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(ACNPANNGIFH));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(KGOIALDADKD));
		}
		if (EventsManager.ALEMDEBCFDH((EventsManager.EventType)4) && !EventsManager.AEFHILOAEEE((EventsManager.EventType)129))
		{
			Debug.Log((object)"\n<color=#822F00>");
			NOKEJLKHJKN();
		}
		else if (EventsManager.OOCOFHECMDA((EventsManager.EventType)(-157)))
		{
			Debug.Log((object)"Inventory full");
			NBCPOJHKJGJ();
		}
	}

	public void GPGIOEJMFCD()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		campEmpty.SetActive(false);
		camp.SetActive(true);
		BrockNPC.EAGMIHGJKNB().content.SetActive(true);
		((Component)BrockNPC.DICHPHEOINO()).transform.position = minePositions[0].position;
		BrockNPC.BIIOFAHFNPA().animationBase.LookDirection(Direction.Up);
		BrockNPC.EAGMIHGJKNB().animationBase.CGEADHOLHCH("ReceiveOfferingUIClosed", EGFGNGJGBOP: true, HALNIEBONKH: true);
		CliveNPC.KMKILBCGJOI().content.SetActive(true);
		((Component)CliveNPC.KNLLFEJAMNN()).transform.position = minePositions[0].position;
		CliveNPC.IFPLPBMCKLB().animationBase.LookDirection((Direction)5);
		CliveNPC.GIKECEGLFOH().animationBase.CGEADHOLHCH("ZoneFuel", EGFGNGJGBOP: true);
		RochelleNPC.CFHEJAGKIII().content.SetActive(false);
		((Component)RochelleNPC.NHKAFANMEJC()).transform.position = minePositions[4].position;
		RochelleNPC.OMFKNGDCJFN().animationBase.LookDirection(Direction.Left);
		RochelleNPC.LFPEPJBNCBF().animationBase.CGEADHOLHCH("Precision/HikariTalk", EGFGNGJGBOP: false, HALNIEBONKH: true);
		FerroNPC.MLPCDJPLBAC().content.SetActive(true);
		((Component)FerroNPC.MLPCDJPLBAC()).transform.position = minePositions[0].position;
		FerroNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Down);
		FerroNPC.GGFJGHHHEJC.animationBase.CGEADHOLHCH("SalonDelTrono/PuddingTalk", EGFGNGJGBOP: true);
	}

	private void EODPIKFPHPK()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(DCHJDHFOEFI));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(LDNEFAFMMHG));
		}
		if (EventsManager.LOFKKDNOKNF((EventsManager.EventType)131) && !EventsManager.ALEMDEBCFDH((EventsManager.EventType)113))
		{
			Debug.Log((object)"Idle");
			OJBKOLCIDBA();
		}
		else if (EventsManager.OMNBJDPGPEN((EventsManager.EventType)(-45)))
		{
			Debug.Log((object)"add item 1440");
			AMEHLNIOFOO();
		}
	}

	private void NLFHFPHDNCF()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(PFMDJDAKHJC));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(NFKMBHPEAHN));
		}
	}

	private void GNGADDPBJDC()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(EFBEKNLOILH));
		}
	}

	private void BNIKICAEIND()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(EODPIKFPHPK));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(ACNPANNGIFH));
		}
	}

	public void SetMinersInCave()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		campEmpty.SetActive(true);
		camp.SetActive(false);
		BrockNPC.GGFJGHHHEJC.content.SetActive(true);
		((Component)BrockNPC.GGFJGHHHEJC).transform.position = minePositions[0].position;
		BrockNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Down);
		BrockNPC.GGFJGHHHEJC.animationBase.SetBool("Minning", EGFGNGJGBOP: true);
		CliveNPC.GGFJGHHHEJC.content.SetActive(true);
		((Component)CliveNPC.GGFJGHHHEJC).transform.position = minePositions[1].position;
		CliveNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Right);
		CliveNPC.GGFJGHHHEJC.animationBase.SetBool("Planning", EGFGNGJGBOP: true);
		RochelleNPC.GGFJGHHHEJC.content.SetActive(true);
		((Component)RochelleNPC.GGFJGHHHEJC).transform.position = minePositions[2].position;
		RochelleNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Left);
		RochelleNPC.GGFJGHHHEJC.animationBase.SetBool("Minning", EGFGNGJGBOP: true);
		FerroNPC.GGFJGHHHEJC.content.SetActive(true);
		((Component)FerroNPC.GGFJGHHHEJC).transform.position = minePositions[3].position;
		FerroNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Right);
		FerroNPC.GGFJGHHHEJC.animationBase.SetBool("Shop", EGFGNGJGBOP: true);
	}

	private void GNGNDGCHKLK()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		camp.SetActive(true);
		campEmpty.SetActive(true);
		BrockNPC.POAGAIBEFBF().content.SetActive(true);
		((Component)BrockNPC.DCAEBALADIM()).transform.position = campPositions[0].position;
		BrockNPC.OKAPNFPFPFP().animationBase.LookDirection(Direction.Up);
		CliveNPC.LADDMEMMJFP().content.SetActive(false);
		((Component)CliveNPC.IDIGFHEHIDM()).transform.position = campPositions[0].position;
		CliveNPC.FOPGLLMEEDE().animationBase.LookDirection(Direction.Down);
		RochelleNPC.EFPJLFMBPLL().content.SetActive(false);
		((Component)RochelleNPC.NHKAFANMEJC()).transform.position = campPositions[4].position;
		RochelleNPC.POAGAIBEFBF().animationBase.LookDirection((Direction)8);
		((Behaviour)FerroNPC.GGFJGHHHEJC.simpleAnimation).enabled = true;
		((Behaviour)FerroNPC.GGFJGHHHEJC.animationController).enabled = true;
	}

	private void KJPECNGCOKK()
	{
		instance = this;
	}

	private void ACNPANNGIFH()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(FIBOIODLMAG));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(KGOIALDADKD));
		}
		if (EventsManager.FDIHEFGPKFP((EventsManager.EventType)187) && !EventsManager.HGALHLALOKJ((EventsManager.EventType)(-17)))
		{
			Debug.Log((object)"<sprite name=\"stoneIcon\">");
			CAJKOJOKBHJ();
		}
		else if (EventsManager.FDIHEFGPKFP((EventsManager.EventType)84))
		{
			Debug.Log((object)"input info");
			AMEHLNIOFOO();
		}
	}

	private void PHNJGHKBIIL()
	{
		instance = this;
	}

	private void KPIEOFOHCPO()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		camp.SetActive(true);
		campEmpty.SetActive(false);
		BrockNPC.BIIOFAHFNPA().content.SetActive(false);
		((Component)BrockNPC.MOAKANGAMBA()).transform.position = campPositions[0].position;
		BrockNPC.MPFJOKOJIOO().animationBase.LookDirection(Direction.Up);
		CliveNPC.FOPGLLMEEDE().content.SetActive(false);
		((Component)CliveNPC.ABDJJBFNLBJ()).transform.position = campPositions[1].position;
		CliveNPC.IFPLPBMCKLB().animationBase.LookDirection((Direction)8);
		RochelleNPC.CMIHGBHPLFP().content.SetActive(false);
		((Component)RochelleNPC.MIGKKKELOJO()).transform.position = campPositions[4].position;
		RochelleNPC.ELGNEJNLBNO().animationBase.LookDirection(Direction.Diagonal);
		((Behaviour)FerroNPC.MLPCDJPLBAC().simpleAnimation).enabled = false;
		((Behaviour)FerroNPC.GGFJGHHHEJC.animationController).enabled = true;
	}

	private void GHPFCKGMLDA()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(PFMDJDAKHJC));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(HKAKGAFKJEN));
		}
	}

	private void CEOEHODJAJK()
	{
		instance = this;
	}

	private void DKBPGGIOMNB()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		camp.SetActive(true);
		campEmpty.SetActive(true);
		BrockNPC.MMLBHCGFMMJ().content.SetActive(true);
		((Component)BrockNPC.HLMGBEGEAPC()).transform.position = campPositions[1].position;
		BrockNPC.MAMKICHCPON().animationBase.LookDirection(Direction.Down);
		CliveNPC.DBJCACLEFGK().content.SetActive(false);
		((Component)CliveNPC.JHKLPLPBKCI()).transform.position = campPositions[0].position;
		CliveNPC.GAGMPCEPONF().animationBase.LookDirection((Direction)5);
		RochelleNPC.KNOKBLFFNLM().content.SetActive(false);
		((Component)RochelleNPC.MAAAKALBBEE()).transform.position = campPositions[8].position;
		RochelleNPC.GJFMMOPOKGJ().animationBase.LookDirection(Direction.Diagonal);
		((Behaviour)FerroNPC.MLPCDJPLBAC().simpleAnimation).enabled = false;
		((Behaviour)FerroNPC.MLPCDJPLBAC().animationController).enabled = false;
	}

	private void JECHMEFJABD()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(PFMDJDAKHJC));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(FIBOIODLMAG));
		}
	}

	private void KJHKBGDJNDC()
	{
		instance = this;
	}

	private void PFMDJDAKHJC()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(HKAKGAFKJEN));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(OACFPJIJDFO));
		}
		if (EventsManager.ALEMDEBCFDH((EventsManager.EventType)(-125)) && !EventsManager.FDIHEFGPKFP((EventsManager.EventType)(-147)))
		{
			Debug.Log((object)"ActiveMultiDoor");
			NCKFJMLANGC();
		}
		else if (EventsManager.OMNBJDPGPEN((EventsManager.EventType)(-148)))
		{
			Debug.Log((object)"[ProceduralMine] Forced BIG SPAWNER piece {0} at block {1} (target was {2}). Path block pos: {3}");
			GBEONEGJJOB();
		}
	}

	private void CFHOODNCOLK()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(JGIIGHAAIHF));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(KGOIALDADKD));
		}
	}

	private void NHGBKNAJHOP()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(LHKDMPIJOCL));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(AANKFMNMCJN));
		}
		if (EventsManager.FDIHEFGPKFP((EventsManager.EventType)122) && !EventsManager.ALEMDEBCFDH((EventsManager.EventType)(-162)))
		{
			Debug.Log((object)"\n");
			GNGNDGCHKLK();
		}
		else if (EventsManager.HGALHLALOKJ((EventsManager.EventType)(-177)))
		{
			Debug.Log((object)"NO SOUNDTRACK LOADED\n Troubleshooting:\n1. The folder containing all psai soundtrack data must be located within the 'Resources' folder of your project.\n2. Your Scene must contain the 'Psai.prefab' Game Object with both a PsaiSoundtrackLoader and a PsaiCoreManager-Component.\n3. The PsaiSoundtrackLoader-Component needs to hold the path to the soundtrack file. Drag & Drop that file from your Soundtrack folder in the Project window.");
			GBEONEGJJOB();
		}
	}

	private void NKDFMFFDGKC()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(ACNPANNGIFH));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(ADFMHFLPNOF));
		}
	}

	private void PIHGEBONAOI()
	{
		instance = this;
	}

	private void KNABGIGNPAM()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(GGODJHIOMPK));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(NFKMBHPEAHN));
		}
		if (EventsManager.ALEMDEBCFDH((EventsManager.EventType)(-77)) && !EventsManager.DOPLDNPIBPP((EventsManager.EventType)62))
		{
			Debug.Log((object)"Attack/MainEvent 8");
			ENGAJJPHILO();
		}
		else if (EventsManager.LOFKKDNOKNF((EventsManager.EventType)(-154)))
		{
			Debug.Log((object)"Left Shift");
			JGPIBKPALAL();
		}
	}

	public void JGGGPBGDDOP()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		campEmpty.SetActive(false);
		camp.SetActive(true);
		BrockNPC.HEKFJEKFMNO().content.SetActive(false);
		((Component)BrockNPC.HLMGBEGEAPC()).transform.position = minePositions[1].position;
		BrockNPC.JFNOOMJMHCB().animationBase.LookDirection(Direction.Down);
		BrockNPC.EAGMIHGJKNB().animationBase.CGEADHOLHCH("Winner", EGFGNGJGBOP: true);
		CliveNPC.HKBJIIJHBJB().content.SetActive(true);
		((Component)CliveNPC.KMKILBCGJOI()).transform.position = minePositions[1].position;
		CliveNPC.DIHCEGINELM().animationBase.LookDirection(Direction.Diagonal);
		CliveNPC.OFLELHKKNKC().animationBase.CGEADHOLHCH("Kick out", EGFGNGJGBOP: false, HALNIEBONKH: true);
		RochelleNPC.FOPGLLMEEDE().content.SetActive(false);
		((Component)RochelleNPC.JFNOOMJMHCB()).transform.position = minePositions[8].position;
		RochelleNPC.EBAIHKJHCCA().animationBase.LookDirection(Direction.Diagonal);
		RochelleNPC.GJFMMOPOKGJ().animationBase.SetBool("Stop Music", EGFGNGJGBOP: false, HALNIEBONKH: true);
		FerroNPC.GGFJGHHHEJC.content.SetActive(true);
		((Component)FerroNPC.MLPCDJPLBAC()).transform.position = minePositions[7].position;
		FerroNPC.MLPCDJPLBAC().animationBase.LookDirection(Direction.Right);
		FerroNPC.MLPCDJPLBAC().animationBase.SetBool("Bomb", EGFGNGJGBOP: true);
	}

	private void Start()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(BGPGIOMKKAO));
		}
	}

	private void LDNEFAFMMHG()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(CCBDFPOONHE));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(OACFPJIJDFO));
		}
		if (EventsManager.DOPLDNPIBPP((EventsManager.EventType)191) && !EventsManager.IsDone((EventsManager.EventType)(-113)))
		{
			Debug.Log((object)"");
			NGNDDMBCHIK();
		}
		else if (EventsManager.DOPLDNPIBPP((EventsManager.EventType)29))
		{
			Debug.Log((object)"ReceiveAskHostForRoomToJoin");
			GBEONEGJJOB();
		}
	}

	private void LMPLLDCGKID()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		camp.SetActive(true);
		campEmpty.SetActive(false);
		BrockNPC.MPFJOKOJIOO().content.SetActive(true);
		((Component)BrockNPC.MMLBHCGFMMJ()).transform.position = campPositions[1].position;
		BrockNPC.DCAEBALADIM().animationBase.LookDirection(Direction.Down);
		CliveNPC.CFHEJAGKIII().content.SetActive(false);
		((Component)CliveNPC.CFHEJAGKIII()).transform.position = campPositions[1].position;
		CliveNPC.KCFGPDHELKP().animationBase.LookDirection((Direction)7);
		RochelleNPC.GGFJGHHHEJC.content.SetActive(true);
		((Component)RochelleNPC.ICNFHJLLHGP()).transform.position = campPositions[3].position;
		RochelleNPC.OMFKNGDCJFN().animationBase.LookDirection(Direction.Down);
		((Behaviour)FerroNPC.MLPCDJPLBAC().simpleAnimation).enabled = true;
		((Behaviour)FerroNPC.GGFJGHHHEJC.animationController).enabled = true;
	}

	private void LANGHIOBJIH()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(ADFMHFLPNOF));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(FIBOIODLMAG));
		}
	}

	private void GNNEKIPNNGC()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		camp.SetActive(false);
		campEmpty.SetActive(false);
		BrockNPC.HLMGBEGEAPC().content.SetActive(true);
		((Component)BrockNPC.DICHPHEOINO()).transform.position = campPositions[0].position;
		BrockNPC.OKAPNFPFPFP().animationBase.LookDirection(Direction.Down);
		CliveNPC.BAKPBHPNKPB().content.SetActive(false);
		((Component)CliveNPC.JHKLPLPBKCI()).transform.position = campPositions[1].position;
		CliveNPC.BAKPBHPNKPB().animationBase.LookDirection(Direction.Down);
		RochelleNPC.KNOKBLFFNLM().content.SetActive(true);
		((Component)RochelleNPC.NBKKEINELDN()).transform.position = campPositions[1].position;
		RochelleNPC.JFNOOMJMHCB().animationBase.LookDirection((Direction)5);
		((Behaviour)FerroNPC.GGFJGHHHEJC.simpleAnimation).enabled = true;
		((Behaviour)FerroNPC.GGFJGHHHEJC.animationController).enabled = true;
	}

	public void MDBICEIJPEA()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		campEmpty.SetActive(false);
		camp.SetActive(false);
		BrockNPC.DICHPHEOINO().content.SetActive(false);
		((Component)BrockNPC.EJHDHCNILDH()).transform.position = minePositions[0].position;
		BrockNPC.OLHBLKIAFOM().animationBase.LookDirection(Direction.Up);
		BrockNPC.OKAPNFPFPFP().animationBase.SetBool("Sour", EGFGNGJGBOP: true, HALNIEBONKH: true);
		CliveNPC.KNOKBLFFNLM().content.SetActive(false);
		((Component)CliveNPC.MJCMPKPCNGB()).transform.position = minePositions[1].position;
		CliveNPC.DCAEBALADIM().animationBase.LookDirection((Direction)7);
		CliveNPC.EJHDHCNILDH().animationBase.SetBool("PlayerJoined_F", EGFGNGJGBOP: true);
		RochelleNPC.CFHEJAGKIII().content.SetActive(true);
		((Component)RochelleNPC.POAGAIBEFBF()).transform.position = minePositions[8].position;
		RochelleNPC.JEEGOBGDLPE().animationBase.LookDirection(Direction.Up);
		RochelleNPC.ELGNEJNLBNO().animationBase.SetBool("itemBarleyBread", EGFGNGJGBOP: false, HALNIEBONKH: true);
		FerroNPC.MLPCDJPLBAC().content.SetActive(true);
		((Component)FerroNPC.MLPCDJPLBAC()).transform.position = minePositions[5].position;
		FerroNPC.MLPCDJPLBAC().animationBase.LookDirection(Direction.Diagonal);
		FerroNPC.MLPCDJPLBAC().animationBase.SetBool("ErrorKicked", EGFGNGJGBOP: false);
	}

	public void MMFPLHBJBAO()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		campEmpty.SetActive(true);
		camp.SetActive(false);
		BrockNPC.FJAMHCAAEAM().content.SetActive(true);
		((Component)BrockNPC.FMIDAFEGDCD()).transform.position = minePositions[1].position;
		BrockNPC.OKAPNFPFPFP().animationBase.LookDirection(Direction.Up);
		BrockNPC.DCAEBALADIM().animationBase.CGEADHOLHCH("No settings found for puzzle type {0}", EGFGNGJGBOP: false, HALNIEBONKH: true);
		CliveNPC.KCFGPDHELKP().content.SetActive(false);
		((Component)CliveNPC.MAAAKALBBEE()).transform.position = minePositions[1].position;
		CliveNPC.FOPGLLMEEDE().animationBase.LookDirection(Direction.Right);
		CliveNPC.PNHHCHJCDNM().animationBase.SetBool("popUpBuilding10", EGFGNGJGBOP: true, HALNIEBONKH: true);
		RochelleNPC.NJNFHEPLEHL().content.SetActive(true);
		((Component)RochelleNPC.KFGKCKCDMLG()).transform.position = minePositions[0].position;
		RochelleNPC.CMIHGBHPLFP().animationBase.LookDirection(Direction.Up);
		RochelleNPC.ABDJJBFNLBJ().animationBase.CGEADHOLHCH("City/Petra/Bark/Stand", EGFGNGJGBOP: false);
		FerroNPC.MLPCDJPLBAC().content.SetActive(false);
		((Component)FerroNPC.MLPCDJPLBAC()).transform.position = minePositions[6].position;
		FerroNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Diagonal);
		FerroNPC.MLPCDJPLBAC().animationBase.SetBool("AvailableQuests doesnt exist", EGFGNGJGBOP: true, HALNIEBONKH: true);
	}

	private void JHBBABPAJJC()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(NFKMBHPEAHN));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(CCBDFPOONHE));
		}
	}

	private void FIBOIODLMAG()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(CCBDFPOONHE));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(LMKCLPLJMPA));
		}
		if (EventsManager.ALEMDEBCFDH((EventsManager.EventType)(-96)) && !EventsManager.DOPLDNPIBPP((EventsManager.EventType)46))
		{
			Debug.Log((object)"buildingObjective_15_0");
			NGNDDMBCHIK();
		}
		else if (EventsManager.LOFKKDNOKNF((EventsManager.EventType)154))
		{
			Debug.Log((object)"TucanEgg");
			NGCMJPADKEA();
		}
	}

	private void IBMDFNKKPJF()
	{
		instance = this;
	}

	public void AEDBAFHLECI()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		campEmpty.SetActive(false);
		camp.SetActive(false);
		BrockNPC.FMIDAFEGDCD().content.SetActive(false);
		((Component)BrockNPC.MKIEMMGGFEE()).transform.position = minePositions[1].position;
		BrockNPC.BADFKMEJOKE().animationBase.LookDirection(Direction.Down);
		BrockNPC.HNNJEBNIPOI().animationBase.CGEADHOLHCH("Exclamation", EGFGNGJGBOP: true, HALNIEBONKH: true);
		CliveNPC.GIKECEGLFOH().content.SetActive(false);
		((Component)CliveNPC.MAAAKALBBEE()).transform.position = minePositions[1].position;
		CliveNPC.DGCNCEDIFOF().animationBase.LookDirection((Direction)5);
		CliveNPC.EJHDHCNILDH().animationBase.SetBool("Tutorial/T127/Dialogue2", EGFGNGJGBOP: true, HALNIEBONKH: true);
		RochelleNPC.PDECKLKPKCG().content.SetActive(false);
		((Component)RochelleNPC.ICNFHJLLHGP()).transform.position = minePositions[1].position;
		RochelleNPC.NBKKEINELDN().animationBase.LookDirection(Direction.Right);
		RochelleNPC.LFPEPJBNCBF().animationBase.CGEADHOLHCH("Disabled", EGFGNGJGBOP: false, HALNIEBONKH: true);
		FerroNPC.MLPCDJPLBAC().content.SetActive(false);
		((Component)FerroNPC.MLPCDJPLBAC()).transform.position = minePositions[6].position;
		FerroNPC.MLPCDJPLBAC().animationBase.LookDirection(Direction.Right);
		FerroNPC.GGFJGHHHEJC.animationBase.SetBool("\n", EGFGNGJGBOP: true);
	}

	private void HOFKJPBBLGP()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(KGOIALDADKD));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(OIBDMBKHGDF));
		}
	}

	public void BPNIEHBFDJO()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		campEmpty.SetActive(true);
		camp.SetActive(false);
		BrockNPC.HFIJHDBKCIA().content.SetActive(true);
		((Component)BrockNPC.ABHIDHPMLLD()).transform.position = minePositions[1].position;
		BrockNPC.PDECKLKPKCG().animationBase.LookDirection(Direction.Down);
		BrockNPC.NJNFHEPLEHL().animationBase.CGEADHOLHCH("ReceiveRequestCustomerOrder", EGFGNGJGBOP: true, HALNIEBONKH: true);
		CliveNPC.CFHEJAGKIII().content.SetActive(false);
		((Component)CliveNPC.KNOKBLFFNLM()).transform.position = minePositions[0].position;
		CliveNPC.GGFJGHHHEJC.animationBase.LookDirection((Direction)7);
		CliveNPC.DGCNCEDIFOF().animationBase.CGEADHOLHCH("Ach_", EGFGNGJGBOP: true, HALNIEBONKH: true);
		RochelleNPC.CNDNOECMKME().content.SetActive(true);
		((Component)RochelleNPC.MAAAKALBBEE()).transform.position = minePositions[2].position;
		RochelleNPC.CMIHGBHPLFP().animationBase.LookDirection((Direction)7);
		RochelleNPC.ELGNEJNLBNO().animationBase.CGEADHOLHCH("Inicio", EGFGNGJGBOP: false, HALNIEBONKH: true);
		FerroNPC.MLPCDJPLBAC().content.SetActive(true);
		((Component)FerroNPC.GGFJGHHHEJC).transform.position = minePositions[4].position;
		FerroNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Left);
		FerroNPC.MLPCDJPLBAC().animationBase.CGEADHOLHCH("LE_10", EGFGNGJGBOP: false, HALNIEBONKH: true);
	}

	public void HCCIKMBGLGH()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		campEmpty.SetActive(true);
		camp.SetActive(false);
		BrockNPC.DIHCEGINELM().content.SetActive(false);
		((Component)BrockNPC.MKIEMMGGFEE()).transform.position = minePositions[1].position;
		BrockNPC.NJNFHEPLEHL().animationBase.LookDirection(Direction.Down);
		BrockNPC.FMIDAFEGDCD().animationBase.CGEADHOLHCH("CraftingRoom", EGFGNGJGBOP: false, HALNIEBONKH: true);
		CliveNPC.KNOKBLFFNLM().content.SetActive(false);
		((Component)CliveNPC.DIHCEGINELM()).transform.position = minePositions[0].position;
		CliveNPC.IFPLPBMCKLB().animationBase.LookDirection((Direction)6);
		CliveNPC.ABDJJBFNLBJ().animationBase.SetBool("Sleep", EGFGNGJGBOP: true, HALNIEBONKH: true);
		RochelleNPC.NJNFHEPLEHL().content.SetActive(true);
		((Component)RochelleNPC.NHKAFANMEJC()).transform.position = minePositions[2].position;
		RochelleNPC.KIALFDOKABP().animationBase.LookDirection((Direction)8);
		RochelleNPC.NHKAFANMEJC().animationBase.CGEADHOLHCH("\n", EGFGNGJGBOP: false);
		FerroNPC.GGFJGHHHEJC.content.SetActive(false);
		((Component)FerroNPC.GGFJGHHHEJC).transform.position = minePositions[0].position;
		FerroNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Right);
		FerroNPC.MLPCDJPLBAC().animationBase.SetBool("Eating", EGFGNGJGBOP: true);
	}

	private void KGOIALDADKD()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(KNABGIGNPAM));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(LHKDMPIJOCL));
		}
		if (EventsManager.OOCOFHECMDA((EventsManager.EventType)53) && !EventsManager.ALEMDEBCFDH((EventsManager.EventType)(-30)))
		{
			Debug.Log((object)"HireWorker?");
			KPIEOFOHCPO();
		}
		else if (EventsManager.ALEMDEBCFDH((EventsManager.EventType)120))
		{
			Debug.Log((object)"MainProgress");
			MMFPLHBJBAO();
		}
	}

	private void JGIIGHAAIHF()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(OIBDMBKHGDF));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(LDNEFAFMMHG));
		}
		if (EventsManager.AEFHILOAEEE((EventsManager.EventType)108) && !EventsManager.GGGECIBEKJG((EventsManager.EventType)123))
		{
			Debug.Log((object)"Festín del Juramento/KlaynDialogue 01");
			GNNEKIPNNGC();
		}
		else if (EventsManager.IsDone(EventsManager.EventType.Scolding))
		{
			Debug.Log((object)"PlayerDisconnected");
			HMMKHGFEONK();
		}
	}

	private void NCKFJMLANGC()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		camp.SetActive(false);
		campEmpty.SetActive(false);
		BrockNPC.HFIJHDBKCIA().content.SetActive(true);
		((Component)BrockNPC.DICHPHEOINO()).transform.position = campPositions[1].position;
		BrockNPC.DHDOLCONMFJ().animationBase.LookDirection(Direction.Down);
		CliveNPC.FMIDAFEGDCD().content.SetActive(false);
		((Component)CliveNPC.DOIKFJDLKJP()).transform.position = campPositions[1].position;
		CliveNPC.OMFKNGDCJFN().animationBase.LookDirection(Direction.Down);
		RochelleNPC.JEEGOBGDLPE().content.SetActive(true);
		((Component)RochelleNPC.NGPHACGDNJN()).transform.position = campPositions[4].position;
		RochelleNPC.NJNFHEPLEHL().animationBase.LookDirection(Direction.Up);
		((Behaviour)FerroNPC.GGFJGHHHEJC.simpleAnimation).enabled = false;
		((Behaviour)FerroNPC.GGFJGHHHEJC.animationController).enabled = true;
	}

	private void OIBDMBKHGDF()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(LMKCLPLJMPA));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(PFMDJDAKHJC));
		}
		if (EventsManager.GGGECIBEKJG((EventsManager.EventType)(-63)) && !EventsManager.LOFKKDNOKNF((EventsManager.EventType)38))
		{
			Debug.Log((object)"ReceiveTalentsLoad");
			OFDNCAAIFNN();
		}
		else if (EventsManager.LOFKKDNOKNF((EventsManager.EventType)41))
		{
			Debug.Log((object)"HarvestableDuringOneMonth");
			LGMADKBOJCB();
		}
	}

	private void KJAGMKKKFPH()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		camp.SetActive(true);
		campEmpty.SetActive(true);
		BrockNPC.KNOKBLFFNLM().content.SetActive(true);
		((Component)BrockNPC.EJHDHCNILDH()).transform.position = campPositions[0].position;
		BrockNPC.IBEGPMLJIOJ().animationBase.LookDirection(Direction.Down);
		CliveNPC.FMIDAFEGDCD().content.SetActive(true);
		((Component)CliveNPC.FMIDAFEGDCD()).transform.position = campPositions[0].position;
		CliveNPC.ABDJJBFNLBJ().animationBase.LookDirection((Direction)6);
		RochelleNPC.GJFMMOPOKGJ().content.SetActive(false);
		((Component)RochelleNPC.ELGNEJNLBNO()).transform.position = campPositions[3].position;
		RochelleNPC.ABDJJBFNLBJ().animationBase.LookDirection(Direction.Right);
		((Behaviour)FerroNPC.MLPCDJPLBAC().simpleAnimation).enabled = false;
		((Behaviour)FerroNPC.MLPCDJPLBAC().animationController).enabled = false;
	}

	private void MCMMJICCFJE()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(CCBDFPOONHE));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(LHKDMPIJOCL));
		}
		if (EventsManager.DOPLDNPIBPP((EventsManager.EventType)(-138)) && !EventsManager.LOFKKDNOKNF((EventsManager.EventType)62))
		{
			Debug.Log((object)"Attack/MainEvent 8");
			KIJNEBPDFEJ();
		}
		else if (EventsManager.ALEMDEBCFDH((EventsManager.EventType)195))
		{
			Debug.Log((object)"BarIdleNumber");
			NGCMJPADKEA();
		}
	}

	private void HFFFFAJFIPB()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(JGIIGHAAIHF));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(GJDFLBGADNE));
		}
	}

	private void KJBIDNLHOMD()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(JGIIGHAAIHF));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(OACFPJIJDFO));
		}
	}

	private void DIMAPDNCBAN()
	{
		instance = this;
	}

	private void FPDPAJHNGHK()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(HKAKGAFKJEN));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(ACNPANNGIFH));
		}
	}

	public void AMEHLNIOFOO()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		campEmpty.SetActive(true);
		camp.SetActive(true);
		BrockNPC.BADFKMEJOKE().content.SetActive(false);
		((Component)BrockNPC.HNNJEBNIPOI()).transform.position = minePositions[0].position;
		BrockNPC.ECGIAEFKKNA().animationBase.LookDirection(Direction.Up);
		BrockNPC.MAMKICHCPON().animationBase.SetBool("ReceiveBarkInfo", EGFGNGJGBOP: false);
		CliveNPC.DBJCACLEFGK().content.SetActive(false);
		((Component)CliveNPC.KNLLFEJAMNN()).transform.position = minePositions[0].position;
		CliveNPC.GDAHBDMFPCB().animationBase.LookDirection(Direction.Left);
		CliveNPC.DBJCACLEFGK().animationBase.SetBool("L1", EGFGNGJGBOP: true, HALNIEBONKH: true);
		RochelleNPC.GGFJGHHHEJC.content.SetActive(false);
		((Component)RochelleNPC.LFPEPJBNCBF()).transform.position = minePositions[2].position;
		RochelleNPC.FOPGLLMEEDE().animationBase.LookDirection((Direction)8);
		RochelleNPC.KIALFDOKABP().animationBase.SetBool("player_count", EGFGNGJGBOP: false);
		FerroNPC.MLPCDJPLBAC().content.SetActive(true);
		((Component)FerroNPC.GGFJGHHHEJC).transform.position = minePositions[6].position;
		FerroNPC.MLPCDJPLBAC().animationBase.LookDirection(Direction.Down);
		FerroNPC.MLPCDJPLBAC().animationBase.CGEADHOLHCH("ReceiveEnableNPC", EGFGNGJGBOP: true);
	}

	private void GOFIDAKDBAB()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		camp.SetActive(true);
		campEmpty.SetActive(false);
		BrockNPC.MAIDHAPANEB().content.SetActive(false);
		((Component)BrockNPC.HNNJEBNIPOI()).transform.position = campPositions[0].position;
		BrockNPC.NJNFHEPLEHL().animationBase.LookDirection(Direction.Up);
		CliveNPC.KCFGPDHELKP().content.SetActive(true);
		((Component)CliveNPC.DGCNCEDIFOF()).transform.position = campPositions[1].position;
		CliveNPC.CFHEJAGKIII().animationBase.LookDirection(Direction.Up);
		RochelleNPC.ABDJJBFNLBJ().content.SetActive(false);
		((Component)RochelleNPC.FOPGLLMEEDE()).transform.position = campPositions[6].position;
		RochelleNPC.FMIDAFEGDCD().animationBase.LookDirection((Direction)6);
		((Behaviour)FerroNPC.MLPCDJPLBAC().simpleAnimation).enabled = false;
		((Behaviour)FerroNPC.GGFJGHHHEJC.animationController).enabled = true;
	}

	private void Awake()
	{
		instance = this;
	}

	private void FDKEHFNIOIM()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(KNABGIGNPAM));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(ADFMHFLPNOF));
		}
		if (EventsManager.OOCOFHECMDA((EventsManager.EventType)(-41)) && !EventsManager.OMNBJDPGPEN((EventsManager.EventType)164))
		{
			Debug.Log((object)"tutorialPopUp23");
			LOPDNEFIJMH();
		}
		else if (EventsManager.OOCOFHECMDA((EventsManager.EventType)(-161)))
		{
			Debug.Log((object)"- ");
			MDBICEIJPEA();
		}
	}

	private void MFBLNLCDOBC()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		camp.SetActive(false);
		campEmpty.SetActive(false);
		BrockNPC.PFHFIJDDOME().content.SetActive(false);
		((Component)BrockNPC.HLMGBEGEAPC()).transform.position = campPositions[0].position;
		BrockNPC.KNOKBLFFNLM().animationBase.LookDirection(Direction.Down);
		CliveNPC.OMFKNGDCJFN().content.SetActive(false);
		((Component)CliveNPC.KMKILBCGJOI()).transform.position = campPositions[1].position;
		CliveNPC.EBAIHKJHCCA().animationBase.LookDirection((Direction)7);
		RochelleNPC.CMIHGBHPLFP().content.SetActive(false);
		((Component)RochelleNPC.MAIDHAPANEB()).transform.position = campPositions[1].position;
		RochelleNPC.MAIDHAPANEB().animationBase.LookDirection((Direction)7);
		((Behaviour)FerroNPC.MLPCDJPLBAC().simpleAnimation).enabled = false;
		((Behaviour)FerroNPC.MLPCDJPLBAC().animationController).enabled = false;
	}

	private void OIAHJHNPPCO()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(GGODJHIOMPK));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(MCMMJICCFJE));
		}
	}

	public void GBEONEGJJOB()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		campEmpty.SetActive(false);
		camp.SetActive(false);
		BrockNPC.MOAKANGAMBA().content.SetActive(false);
		((Component)BrockNPC.HNNJEBNIPOI()).transform.position = minePositions[1].position;
		BrockNPC.HNNJEBNIPOI().animationBase.LookDirection(Direction.Up);
		BrockNPC.NJNFHEPLEHL().animationBase.SetBool("itemOldDoormat", EGFGNGJGBOP: true, HALNIEBONKH: true);
		CliveNPC.IBEGPMLJIOJ().content.SetActive(true);
		((Component)CliveNPC.EBAIHKJHCCA()).transform.position = minePositions[0].position;
		CliveNPC.CMIHGBHPLFP().animationBase.LookDirection(Direction.Up);
		CliveNPC.LADDMEMMJFP().animationBase.CGEADHOLHCH("", EGFGNGJGBOP: true, HALNIEBONKH: true);
		RochelleNPC.JEEGOBGDLPE().content.SetActive(false);
		((Component)RochelleNPC.POAGAIBEFBF()).transform.position = minePositions[4].position;
		RochelleNPC.FOPGLLMEEDE().animationBase.LookDirection((Direction)5);
		RochelleNPC.EFPJLFMBPLL().animationBase.CGEADHOLHCH("", EGFGNGJGBOP: true, HALNIEBONKH: true);
		FerroNPC.MLPCDJPLBAC().content.SetActive(false);
		((Component)FerroNPC.MLPCDJPLBAC()).transform.position = minePositions[0].position;
		FerroNPC.MLPCDJPLBAC().animationBase.LookDirection((Direction)7);
		FerroNPC.MLPCDJPLBAC().animationBase.CGEADHOLHCH("HarvestCut", EGFGNGJGBOP: false, HALNIEBONKH: true);
	}

	private void FHLDJDMFLGB()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		camp.SetActive(false);
		campEmpty.SetActive(true);
		BrockNPC.PDECKLKPKCG().content.SetActive(true);
		((Component)BrockNPC.MAIDHAPANEB()).transform.position = campPositions[1].position;
		BrockNPC.CNDNOECMKME().animationBase.LookDirection(Direction.Down);
		CliveNPC.BAKPBHPNKPB().content.SetActive(false);
		((Component)CliveNPC.MJCMPKPCNGB()).transform.position = campPositions[0].position;
		CliveNPC.KMKILBCGJOI().animationBase.LookDirection(Direction.Left);
		RochelleNPC.GGFJGHHHEJC.content.SetActive(true);
		((Component)RochelleNPC.NHKAFANMEJC()).transform.position = campPositions[4].position;
		RochelleNPC.POAGAIBEFBF().animationBase.LookDirection((Direction)6);
		((Behaviour)FerroNPC.GGFJGHHHEJC.simpleAnimation).enabled = false;
		((Behaviour)FerroNPC.GGFJGHHHEJC.animationController).enabled = true;
	}

	private void HPBCPENEEDK()
	{
		instance = this;
	}

	private void BGPGIOMKKAO()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(BGPGIOMKKAO));
		}
		if (EventsManager.IsDone(EventsManager.EventType.MinersDispute) && !EventsManager.IsDone(EventsManager.EventType.HotBath))
		{
			Debug.Log((object)"Miners dispute done, but not hot bath, setting miners in camp");
			PMJPLFOHLPO();
		}
		else if (EventsManager.IsDone(EventsManager.EventType.HotBath))
		{
			Debug.Log((object)"Hot bath done, setting miners in cave");
			SetMinersInCave();
		}
	}

	private void GJDFLBGADNE()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(CCBDFPOONHE));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(GGODJHIOMPK));
		}
		if (EventsManager.FDIHEFGPKFP((EventsManager.EventType)(-15)) && !EventsManager.HGALHLALOKJ((EventsManager.EventType)(-122)))
		{
			Debug.Log((object)"Building");
			DKBPGGIOMNB();
		}
		else if (EventsManager.GGGECIBEKJG((EventsManager.EventType)(-78)))
		{
			Debug.Log((object)"a");
			MDBICEIJPEA();
		}
	}

	private void PGJJBPALEGM()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(HKAKGAFKJEN));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(PFMDJDAKHJC));
		}
	}

	private void HBMDEHPHAPF()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(JGIIGHAAIHF));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(ACNPANNGIFH));
		}
	}

	private void GECHJIGBPEN()
	{
		instance = this;
	}

	private void GGODJHIOMPK()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(KNABGIGNPAM));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(PFMDJDAKHJC));
		}
		if (EventsManager.DOPLDNPIBPP((EventsManager.EventType)167) && !EventsManager.ALEMDEBCFDH((EventsManager.EventType)40))
		{
			Debug.Log((object)"Sending finish minigame");
			GNNEKIPNNGC();
		}
		else if (EventsManager.IsDone((EventsManager.EventType)52))
		{
			Debug.Log((object)"Could not request user data for reason ");
			HMMKHGFEONK();
		}
	}

	private void OFDNCAAIFNN()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		camp.SetActive(false);
		campEmpty.SetActive(true);
		BrockNPC.HFIJHDBKCIA().content.SetActive(false);
		((Component)BrockNPC.ABHIDHPMLLD()).transform.position = campPositions[0].position;
		BrockNPC.MPFJOKOJIOO().animationBase.LookDirection(Direction.Up);
		CliveNPC.HKBJIIJHBJB().content.SetActive(true);
		((Component)CliveNPC.DOIKFJDLKJP()).transform.position = campPositions[1].position;
		CliveNPC.DBJCACLEFGK().animationBase.LookDirection(Direction.Diagonal);
		RochelleNPC.OLHBLKIAFOM().content.SetActive(false);
		((Component)RochelleNPC.ELGNEJNLBNO()).transform.position = campPositions[0].position;
		RochelleNPC.CNDNOECMKME().animationBase.LookDirection(Direction.Right);
		((Behaviour)FerroNPC.GGFJGHHHEJC.simpleAnimation).enabled = true;
		((Behaviour)FerroNPC.MLPCDJPLBAC().animationController).enabled = true;
	}

	private void HKAKGAFKJEN()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(LMKCLPLJMPA));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(GGODJHIOMPK));
		}
		if (EventsManager.IsDone((EventsManager.EventType)88) && !EventsManager.FDIHEFGPKFP((EventsManager.EventType)59))
		{
			Debug.Log((object)"popUpBuilding8");
			LOPDNEFIJMH();
		}
		else if (EventsManager.OMNBJDPGPEN((EventsManager.EventType)(-160)))
		{
			Debug.Log((object)"Player Bed not found");
			PEDDGMBADDL();
		}
	}

	private void KDBJHCAEGCM()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(FDKEHFNIOIM));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(GGODJHIOMPK));
		}
	}

	private void EOGHJNGJFID()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(ACNPANNGIFH));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(BGPGIOMKKAO));
		}
	}

	private void ENGAJJPHILO()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		camp.SetActive(false);
		campEmpty.SetActive(true);
		BrockNPC.FJAMHCAAEAM().content.SetActive(false);
		((Component)BrockNPC.NBKKEINELDN()).transform.position = campPositions[0].position;
		BrockNPC.OKAPNFPFPFP().animationBase.LookDirection(Direction.Down);
		CliveNPC.IDIGFHEHIDM().content.SetActive(false);
		((Component)CliveNPC.BAKPBHPNKPB()).transform.position = campPositions[0].position;
		CliveNPC.JLNBMNKJCHE().animationBase.LookDirection(Direction.Diagonal);
		RochelleNPC.ICNFHJLLHGP().content.SetActive(false);
		((Component)RochelleNPC.NHKAFANMEJC()).transform.position = campPositions[5].position;
		RochelleNPC.MIGKKKELOJO().animationBase.LookDirection((Direction)5);
		((Behaviour)FerroNPC.GGFJGHHHEJC.simpleAnimation).enabled = false;
		((Behaviour)FerroNPC.MLPCDJPLBAC().animationController).enabled = false;
	}

	private void KMBEOPAHKGB()
	{
		instance = this;
	}

	private void OLDDEAJMHNI()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(KNABGIGNPAM));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(KNABGIGNPAM));
		}
	}

	private void FBHHPNJGNJG()
	{
		instance = this;
	}

	public void NBCPOJHKJGJ()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		campEmpty.SetActive(false);
		camp.SetActive(false);
		BrockNPC.NBKKEINELDN().content.SetActive(false);
		((Component)BrockNPC.HNNJEBNIPOI()).transform.position = minePositions[1].position;
		BrockNPC.HLMGBEGEAPC().animationBase.LookDirection(Direction.Up);
		BrockNPC.FJAMHCAAEAM().animationBase.CGEADHOLHCH("Far", EGFGNGJGBOP: true);
		CliveNPC.BIIOFAHFNPA().content.SetActive(true);
		((Component)CliveNPC.BAKPBHPNKPB()).transform.position = minePositions[0].position;
		CliveNPC.DGCNCEDIFOF().animationBase.LookDirection(Direction.Up);
		CliveNPC.KNLLFEJAMNN().animationBase.CGEADHOLHCH("0.#", EGFGNGJGBOP: true);
		RochelleNPC.ELGNEJNLBNO().content.SetActive(true);
		((Component)RochelleNPC.NBKKEINELDN()).transform.position = minePositions[6].position;
		RochelleNPC.GGFJGHHHEJC.animationBase.LookDirection((Direction)5);
		RochelleNPC.ELGNEJNLBNO().animationBase.CGEADHOLHCH(": ", EGFGNGJGBOP: false, HALNIEBONKH: true);
		FerroNPC.MLPCDJPLBAC().content.SetActive(true);
		((Component)FerroNPC.MLPCDJPLBAC()).transform.position = minePositions[4].position;
		FerroNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Left);
		FerroNPC.GGFJGHHHEJC.animationBase.CGEADHOLHCH("UI2", EGFGNGJGBOP: true, HALNIEBONKH: true);
	}

	private void BELOIFKPNMM()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(ADFMHFLPNOF));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(GJDFLBGADNE));
		}
	}

	private void NFKMBHPEAHN()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(AANKFMNMCJN));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(CCBDFPOONHE));
		}
		if (EventsManager.DOPLDNPIBPP((EventsManager.EventType)(-149)) && !EventsManager.OOCOFHECMDA((EventsManager.EventType)105))
		{
			Debug.Log((object)"UI2");
			NCKFJMLANGC();
		}
		else if (EventsManager.IsDone((EventsManager.EventType)(-126)))
		{
			Debug.Log((object)"Mine loaded for client ");
			SetMinersInCave();
		}
	}

	private void MLLADNLMIMP()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(LDNEFAFMMHG));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(MCMMJICCFJE));
		}
	}

	private void PMJPLFOHLPO()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		camp.SetActive(true);
		campEmpty.SetActive(false);
		BrockNPC.GGFJGHHHEJC.content.SetActive(true);
		((Component)BrockNPC.GGFJGHHHEJC).transform.position = campPositions[0].position;
		BrockNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Down);
		CliveNPC.GGFJGHHHEJC.content.SetActive(true);
		((Component)CliveNPC.GGFJGHHHEJC).transform.position = campPositions[1].position;
		CliveNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Right);
		RochelleNPC.GGFJGHHHEJC.content.SetActive(true);
		((Component)RochelleNPC.GGFJGHHHEJC).transform.position = campPositions[2].position;
		RochelleNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Right);
		((Behaviour)FerroNPC.GGFJGHHHEJC.simpleAnimation).enabled = false;
		((Behaviour)FerroNPC.GGFJGHHHEJC.animationController).enabled = false;
	}

	private void NOKEJLKHJKN()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		camp.SetActive(false);
		campEmpty.SetActive(false);
		BrockNPC.GGFJGHHHEJC.content.SetActive(false);
		((Component)BrockNPC.KNOKBLFFNLM()).transform.position = campPositions[1].position;
		BrockNPC.KNOKBLFFNLM().animationBase.LookDirection(Direction.Down);
		CliveNPC.OFLELHKKNKC().content.SetActive(false);
		((Component)CliveNPC.DOIKFJDLKJP()).transform.position = campPositions[0].position;
		CliveNPC.EAGMIHGJKNB().animationBase.LookDirection(Direction.Right);
		RochelleNPC.KFGKCKCDMLG().content.SetActive(false);
		((Component)RochelleNPC.LFPEPJBNCBF()).transform.position = campPositions[4].position;
		RochelleNPC.POAGAIBEFBF().animationBase.LookDirection(Direction.Diagonal);
		((Behaviour)FerroNPC.MLPCDJPLBAC().simpleAnimation).enabled = true;
		((Behaviour)FerroNPC.GGFJGHHHEJC.animationController).enabled = true;
	}

	public void DOGILJIDGPH()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		campEmpty.SetActive(true);
		camp.SetActive(false);
		BrockNPC.FMIDAFEGDCD().content.SetActive(true);
		((Component)BrockNPC.OPILDPFDFKJ()).transform.position = minePositions[1].position;
		BrockNPC.HLMGBEGEAPC().animationBase.LookDirection(Direction.Down);
		BrockNPC.MPFJOKOJIOO().animationBase.CGEADHOLHCH("UIAddRemove", EGFGNGJGBOP: false, HALNIEBONKH: true);
		CliveNPC.IDIGFHEHIDM().content.SetActive(false);
		((Component)CliveNPC.JLNBMNKJCHE()).transform.position = minePositions[1].position;
		CliveNPC.JLNBMNKJCHE().animationBase.LookDirection((Direction)6);
		CliveNPC.GAGMPCEPONF().animationBase.CGEADHOLHCH("Error_OccupiedRoom", EGFGNGJGBOP: true);
		RochelleNPC.OMFKNGDCJFN().content.SetActive(true);
		((Component)RochelleNPC.CMIHGBHPLFP()).transform.position = minePositions[7].position;
		RochelleNPC.MAIDHAPANEB().animationBase.LookDirection(Direction.Up);
		RochelleNPC.OLHBLKIAFOM().animationBase.CGEADHOLHCH("itemDIPAWort", EGFGNGJGBOP: false, HALNIEBONKH: true);
		FerroNPC.MLPCDJPLBAC().content.SetActive(false);
		((Component)FerroNPC.MLPCDJPLBAC()).transform.position = minePositions[7].position;
		FerroNPC.MLPCDJPLBAC().animationBase.LookDirection((Direction)6);
		FerroNPC.GGFJGHHHEJC.animationBase.CGEADHOLHCH("quest_description_20", EGFGNGJGBOP: true, HALNIEBONKH: true);
	}

	public void PEDDGMBADDL()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		campEmpty.SetActive(true);
		camp.SetActive(false);
		BrockNPC.NBKKEINELDN().content.SetActive(true);
		((Component)BrockNPC.DCAEBALADIM()).transform.position = minePositions[0].position;
		BrockNPC.MAMKICHCPON().animationBase.LookDirection(Direction.Down);
		BrockNPC.EAGMIHGJKNB().animationBase.SetBool("_Keybind_", EGFGNGJGBOP: false);
		CliveNPC.BIIOFAHFNPA().content.SetActive(false);
		((Component)CliveNPC.PNHHCHJCDNM()).transform.position = minePositions[1].position;
		CliveNPC.IFPLPBMCKLB().animationBase.LookDirection(Direction.Diagonal);
		CliveNPC.JHKLPLPBKCI().animationBase.SetBool("Items/item_name_677", EGFGNGJGBOP: false, HALNIEBONKH: true);
		RochelleNPC.KNOKBLFFNLM().content.SetActive(false);
		((Component)RochelleNPC.CFHEJAGKIII()).transform.position = minePositions[6].position;
		RochelleNPC.ELGNEJNLBNO().animationBase.LookDirection(Direction.Down);
		RochelleNPC.FOPGLLMEEDE().animationBase.SetBool("Sell", EGFGNGJGBOP: false);
		FerroNPC.GGFJGHHHEJC.content.SetActive(false);
		((Component)FerroNPC.GGFJGHHHEJC).transform.position = minePositions[5].position;
		FerroNPC.MLPCDJPLBAC().animationBase.LookDirection(Direction.Left);
		FerroNPC.MLPCDJPLBAC().animationBase.CGEADHOLHCH("Setup ", EGFGNGJGBOP: true, HALNIEBONKH: true);
	}

	public void BKHPEHACMJI()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		campEmpty.SetActive(true);
		camp.SetActive(true);
		BrockNPC.NBKKEINELDN().content.SetActive(false);
		((Component)BrockNPC.MOAKANGAMBA()).transform.position = minePositions[1].position;
		BrockNPC.LKDJNKLJKGO().animationBase.LookDirection(Direction.Up);
		BrockNPC.GGFJGHHHEJC.animationBase.SetBool("Walking", EGFGNGJGBOP: false, HALNIEBONKH: true);
		CliveNPC.EJHDHCNILDH().content.SetActive(false);
		((Component)CliveNPC.CFHEJAGKIII()).transform.position = minePositions[0].position;
		CliveNPC.DOIKFJDLKJP().animationBase.LookDirection((Direction)6);
		CliveNPC.CNDNOECMKME().animationBase.SetBool("OnlineBedroomsManager instance is null.", EGFGNGJGBOP: true);
		RochelleNPC.CMIHGBHPLFP().content.SetActive(false);
		((Component)RochelleNPC.LFPEPJBNCBF()).transform.position = minePositions[2].position;
		RochelleNPC.NBKKEINELDN().animationBase.LookDirection(Direction.Diagonal);
		RochelleNPC.FOPGLLMEEDE().animationBase.CGEADHOLHCH("Items/item_name_1123", EGFGNGJGBOP: true);
		FerroNPC.GGFJGHHHEJC.content.SetActive(true);
		((Component)FerroNPC.GGFJGHHHEJC).transform.position = minePositions[8].position;
		FerroNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Left);
		FerroNPC.MLPCDJPLBAC().animationBase.SetBool("CutSceneMode", EGFGNGJGBOP: true, HALNIEBONKH: true);
	}

	private void ADFMHFLPNOF()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(KGOIALDADKD));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(FDKEHFNIOIM));
		}
		if (EventsManager.OMNBJDPGPEN((EventsManager.EventType)57) && !EventsManager.GGGECIBEKJG((EventsManager.EventType)185))
		{
			Debug.Log((object)"Dialogue System/Conversation/BirdPositiveComments/Entry/8/Dialogue Text");
			MEKFDBOJMDD();
		}
		else if (EventsManager.GGGECIBEKJG(EventsManager.EventType.CastleForm))
		{
			Debug.Log((object)"Inventory full");
			JGGGPBGDDOP();
		}
	}

	private void EEKOJEKPIMP()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(EODPIKFPHPK));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(OIBDMBKHGDF));
		}
	}

	public void KCKFOOMKJBG()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		campEmpty.SetActive(true);
		camp.SetActive(false);
		BrockNPC.DIHCEGINELM().content.SetActive(true);
		((Component)BrockNPC.HNNJEBNIPOI()).transform.position = minePositions[1].position;
		BrockNPC.DCAEBALADIM().animationBase.LookDirection(Direction.Up);
		BrockNPC.DICHPHEOINO().animationBase.SetBool("Items/item_name_1193", EGFGNGJGBOP: true);
		CliveNPC.GIKECEGLFOH().content.SetActive(true);
		((Component)CliveNPC.KNOKBLFFNLM()).transform.position = minePositions[1].position;
		CliveNPC.ABHIDHPMLLD().animationBase.LookDirection((Direction)6);
		CliveNPC.GGFJGHHHEJC.animationBase.SetBool("Player/Bark/Tutorial/CantDoYet", EGFGNGJGBOP: false, HALNIEBONKH: true);
		RochelleNPC.JFNOOMJMHCB().content.SetActive(true);
		((Component)RochelleNPC.EFPJLFMBPLL()).transform.position = minePositions[3].position;
		RochelleNPC.MIGKKKELOJO().animationBase.LookDirection(Direction.Down);
		RochelleNPC.JEEGOBGDLPE().animationBase.SetBool("Error in FogManager.OnNightEnd: ", EGFGNGJGBOP: false);
		FerroNPC.MLPCDJPLBAC().content.SetActive(false);
		((Component)FerroNPC.MLPCDJPLBAC()).transform.position = minePositions[2].position;
		FerroNPC.MLPCDJPLBAC().animationBase.LookDirection(Direction.Down);
		FerroNPC.GGFJGHHHEJC.animationBase.SetBool("Dialogue System/Conversation/Crowly_Standar/Entry/8/Dialogue Text", EGFGNGJGBOP: false);
	}

	private void CCBDFPOONHE()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(KGOIALDADKD));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(JGIIGHAAIHF));
		}
		if (EventsManager.DOPLDNPIBPP((EventsManager.EventType)(-81)) && !EventsManager.OMNBJDPGPEN((EventsManager.EventType)30))
		{
			Debug.Log((object)"Dialogue System/Conversation/UnhappyRentRoom/Entry/3/Dialogue Text");
			CAJKOJOKBHJ();
		}
		else if (EventsManager.LOFKKDNOKNF((EventsManager.EventType)151))
		{
			Debug.Log((object)"travelling time +");
			MMFPLHBJBAO();
		}
	}

	public void LGMADKBOJCB()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		campEmpty.SetActive(true);
		camp.SetActive(false);
		BrockNPC.JFNOOMJMHCB().content.SetActive(true);
		((Component)BrockNPC.MAMKICHCPON()).transform.position = minePositions[0].position;
		BrockNPC.CHKMFEFOFKJ().animationBase.LookDirection(Direction.Up);
		BrockNPC.POAGAIBEFBF().animationBase.CGEADHOLHCH("Loop", EGFGNGJGBOP: true);
		CliveNPC.LADDMEMMJFP().content.SetActive(false);
		((Component)CliveNPC.KNLLFEJAMNN()).transform.position = minePositions[1].position;
		CliveNPC.CMIHGBHPLFP().animationBase.LookDirection((Direction)6);
		CliveNPC.IBEGPMLJIOJ().animationBase.SetBool("HeadToBed", EGFGNGJGBOP: true);
		RochelleNPC.ICNFHJLLHGP().content.SetActive(true);
		((Component)RochelleNPC.MAAAKALBBEE()).transform.position = minePositions[0].position;
		RochelleNPC.KFGKCKCDMLG().animationBase.LookDirection(Direction.Right);
		RochelleNPC.GGFJGHHHEJC.animationBase.CGEADHOLHCH("", EGFGNGJGBOP: false);
		FerroNPC.MLPCDJPLBAC().content.SetActive(false);
		((Component)FerroNPC.GGFJGHHHEJC).transform.position = minePositions[2].position;
		FerroNPC.MLPCDJPLBAC().animationBase.LookDirection((Direction)6);
		FerroNPC.MLPCDJPLBAC().animationBase.SetBool("Peek", EGFGNGJGBOP: true);
	}

	private void DADPOICMNPI()
	{
		instance = this;
	}

	public void FPMOOFGKFAG()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		campEmpty.SetActive(false);
		camp.SetActive(false);
		BrockNPC.FMIDAFEGDCD().content.SetActive(false);
		((Component)BrockNPC.MAMKICHCPON()).transform.position = minePositions[1].position;
		BrockNPC.HNNJEBNIPOI().animationBase.LookDirection(Direction.Down);
		BrockNPC.MKIEMMGGFEE().animationBase.SetBool("Disabled", EGFGNGJGBOP: true, HALNIEBONKH: true);
		CliveNPC.JHKLPLPBKCI().content.SetActive(false);
		((Component)CliveNPC.JHKLPLPBKCI()).transform.position = minePositions[1].position;
		CliveNPC.IDIGFHEHIDM().animationBase.LookDirection(Direction.Down);
		CliveNPC.DOIKFJDLKJP().animationBase.SetBool("ReceiveAddReputationPoints", EGFGNGJGBOP: false);
		RochelleNPC.CFHEJAGKIII().content.SetActive(true);
		((Component)RochelleNPC.LFPEPJBNCBF()).transform.position = minePositions[5].position;
		RochelleNPC.KIALFDOKABP().animationBase.LookDirection((Direction)7);
		RochelleNPC.ICNFHJLLHGP().animationBase.CGEADHOLHCH("", EGFGNGJGBOP: true);
		FerroNPC.MLPCDJPLBAC().content.SetActive(true);
		((Component)FerroNPC.MLPCDJPLBAC()).transform.position = minePositions[1].position;
		FerroNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Right);
		FerroNPC.GGFJGHHHEJC.animationBase.SetBool("ReceiveAnimalIncreaseProduction", EGFGNGJGBOP: true, HALNIEBONKH: true);
	}

	private void FCNKGINGJNM()
	{
		instance = this;
	}

	private void MEKFDBOJMDD()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		camp.SetActive(false);
		campEmpty.SetActive(true);
		BrockNPC.NJNFHEPLEHL().content.SetActive(false);
		((Component)BrockNPC.JFNOOMJMHCB()).transform.position = campPositions[1].position;
		BrockNPC.FJAMHCAAEAM().animationBase.LookDirection(Direction.Up);
		CliveNPC.IDIGFHEHIDM().content.SetActive(false);
		((Component)CliveNPC.OMFKNGDCJFN()).transform.position = campPositions[1].position;
		CliveNPC.LKDJNKLJKGO().animationBase.LookDirection(Direction.Diagonal);
		RochelleNPC.POAGAIBEFBF().content.SetActive(true);
		((Component)RochelleNPC.JFNOOMJMHCB()).transform.position = campPositions[8].position;
		RochelleNPC.PDECKLKPKCG().animationBase.LookDirection((Direction)5);
		((Behaviour)FerroNPC.GGFJGHHHEJC.simpleAnimation).enabled = true;
		((Behaviour)FerroNPC.MLPCDJPLBAC().animationController).enabled = false;
	}

	private void LHKDMPIJOCL()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(ACNPANNGIFH));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(LDNEFAFMMHG));
		}
		if (EventsManager.FDIHEFGPKFP((EventsManager.EventType)(-96)) && !EventsManager.AEFHILOAEEE((EventsManager.EventType)134))
		{
			Debug.Log((object)"Near");
			OFDNCAAIFNN();
		}
		else if (EventsManager.ALEMDEBCFDH((EventsManager.EventType)(-17)))
		{
			Debug.Log((object)"Items/item_name_666");
			JGPIBKPALAL();
		}
	}

	public void NMKKLMMLOLL()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		campEmpty.SetActive(true);
		camp.SetActive(true);
		BrockNPC.NBKKEINELDN().content.SetActive(false);
		((Component)BrockNPC.HLMGBEGEAPC()).transform.position = minePositions[0].position;
		BrockNPC.EAGMIHGJKNB().animationBase.LookDirection(Direction.Down);
		BrockNPC.IBEGPMLJIOJ().animationBase.CGEADHOLHCH("Floor_4", EGFGNGJGBOP: false);
		CliveNPC.OFLELHKKNKC().content.SetActive(false);
		((Component)CliveNPC.EJHDHCNILDH()).transform.position = minePositions[0].position;
		CliveNPC.KCFGPDHELKP().animationBase.LookDirection(Direction.Right);
		CliveNPC.DCAEBALADIM().animationBase.SetBool(" ", EGFGNGJGBOP: false);
		RochelleNPC.EFPJLFMBPLL().content.SetActive(false);
		((Component)RochelleNPC.ABDJJBFNLBJ()).transform.position = minePositions[6].position;
		RochelleNPC.EBAIHKJHCCA().animationBase.LookDirection((Direction)8);
		RochelleNPC.OLHBLKIAFOM().animationBase.SetBool("Bomb", EGFGNGJGBOP: false);
		FerroNPC.MLPCDJPLBAC().content.SetActive(true);
		((Component)FerroNPC.MLPCDJPLBAC()).transform.position = minePositions[3].position;
		FerroNPC.MLPCDJPLBAC().animationBase.LookDirection((Direction)5);
		FerroNPC.GGFJGHHHEJC.animationBase.SetBool(", ", EGFGNGJGBOP: true, HALNIEBONKH: true);
	}

	private void AGELAMLCINB()
	{
		instance = this;
	}

	private void OJBKOLCIDBA()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		camp.SetActive(false);
		campEmpty.SetActive(false);
		BrockNPC.CNDNOECMKME().content.SetActive(false);
		((Component)BrockNPC.DHDOLCONMFJ()).transform.position = campPositions[1].position;
		BrockNPC.HEKFJEKFMNO().animationBase.LookDirection(Direction.Up);
		CliveNPC.DBJCACLEFGK().content.SetActive(true);
		((Component)CliveNPC.OFLELHKKNKC()).transform.position = campPositions[1].position;
		CliveNPC.JLNBMNKJCHE().animationBase.LookDirection(Direction.Down);
		RochelleNPC.ICNFHJLLHGP().content.SetActive(false);
		((Component)RochelleNPC.KNOKBLFFNLM()).transform.position = campPositions[7].position;
		RochelleNPC.JEEGOBGDLPE().animationBase.LookDirection((Direction)6);
		((Behaviour)FerroNPC.MLPCDJPLBAC().simpleAnimation).enabled = false;
		((Behaviour)FerroNPC.GGFJGHHHEJC.animationController).enabled = false;
	}

	public void NGBLNNOCFLC()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		campEmpty.SetActive(true);
		camp.SetActive(false);
		BrockNPC.DCAEBALADIM().content.SetActive(true);
		((Component)BrockNPC.KNOKBLFFNLM()).transform.position = minePositions[0].position;
		BrockNPC.PFHFIJDDOME().animationBase.LookDirection(Direction.Down);
		BrockNPC.DICHPHEOINO().animationBase.CGEADHOLHCH("Items/item_name_1046", EGFGNGJGBOP: true);
		CliveNPC.KMKILBCGJOI().content.SetActive(true);
		((Component)CliveNPC.DCAEBALADIM()).transform.position = minePositions[1].position;
		CliveNPC.ABDJJBFNLBJ().animationBase.LookDirection((Direction)8);
		CliveNPC.KCFGPDHELKP().animationBase.CGEADHOLHCH("LE_21", EGFGNGJGBOP: true);
		RochelleNPC.CFHEJAGKIII().content.SetActive(true);
		((Component)RochelleNPC.ICNFHJLLHGP()).transform.position = minePositions[5].position;
		RochelleNPC.EFPJLFMBPLL().animationBase.LookDirection((Direction)7);
		RochelleNPC.FOPGLLMEEDE().animationBase.CGEADHOLHCH("LE_10", EGFGNGJGBOP: false, HALNIEBONKH: true);
		FerroNPC.GGFJGHHHEJC.content.SetActive(false);
		((Component)FerroNPC.GGFJGHHHEJC).transform.position = minePositions[3].position;
		FerroNPC.MLPCDJPLBAC().animationBase.LookDirection(Direction.Left);
		FerroNPC.MLPCDJPLBAC().animationBase.CGEADHOLHCH("Items/item_description_1034", EGFGNGJGBOP: false);
	}

	private void IAIDKPJKLIC()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(LMKCLPLJMPA));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(KNABGIGNPAM));
		}
	}

	public void JGPIBKPALAL()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		campEmpty.SetActive(true);
		camp.SetActive(false);
		BrockNPC.BADFKMEJOKE().content.SetActive(false);
		((Component)BrockNPC.HFIJHDBKCIA()).transform.position = minePositions[0].position;
		BrockNPC.FMIDAFEGDCD().animationBase.LookDirection(Direction.Down);
		BrockNPC.HEKFJEKFMNO().animationBase.CGEADHOLHCH("add item ", EGFGNGJGBOP: false);
		CliveNPC.DIHCEGINELM().content.SetActive(true);
		((Component)CliveNPC.JHKLPLPBKCI()).transform.position = minePositions[1].position;
		CliveNPC.DOIKFJDLKJP().animationBase.LookDirection(Direction.Down);
		CliveNPC.BIIOFAHFNPA().animationBase.CGEADHOLHCH("Farm/Event/PiedrasVioletyArthur", EGFGNGJGBOP: true);
		RochelleNPC.CNDNOECMKME().content.SetActive(true);
		((Component)RochelleNPC.OMFKNGDCJFN()).transform.position = minePositions[8].position;
		RochelleNPC.FOPGLLMEEDE().animationBase.LookDirection(Direction.Left);
		RochelleNPC.CMIHGBHPLFP().animationBase.SetBool("BanquetEvent instance is null. Make sure it is initialized before calling FinishReplayKlaynChallenge.", EGFGNGJGBOP: true, HALNIEBONKH: true);
		FerroNPC.MLPCDJPLBAC().content.SetActive(false);
		((Component)FerroNPC.MLPCDJPLBAC()).transform.position = minePositions[7].position;
		FerroNPC.GGFJGHHHEJC.animationBase.LookDirection((Direction)7);
		FerroNPC.GGFJGHHHEJC.animationBase.SetBool("ReceiveCatPosition", EGFGNGJGBOP: false, HALNIEBONKH: true);
	}

	private void NGNDDMBCHIK()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		camp.SetActive(true);
		campEmpty.SetActive(false);
		BrockNPC.DCAEBALADIM().content.SetActive(true);
		((Component)BrockNPC.MKIEMMGGFEE()).transform.position = campPositions[0].position;
		BrockNPC.KNOKBLFFNLM().animationBase.LookDirection(Direction.Down);
		CliveNPC.HKBJIIJHBJB().content.SetActive(false);
		((Component)CliveNPC.OFLELHKKNKC()).transform.position = campPositions[0].position;
		CliveNPC.OFLELHKKNKC().animationBase.LookDirection((Direction)6);
		RochelleNPC.NJNFHEPLEHL().content.SetActive(false);
		((Component)RochelleNPC.PDECKLKPKCG()).transform.position = campPositions[2].position;
		RochelleNPC.KIALFDOKABP().animationBase.LookDirection(Direction.Right);
		((Behaviour)FerroNPC.MLPCDJPLBAC().simpleAnimation).enabled = true;
		((Behaviour)FerroNPC.MLPCDJPLBAC().animationController).enabled = false;
	}

	private void LFNENELHOGJ()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(LMKCLPLJMPA));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(EFBEKNLOILH));
		}
	}

	private void LMKCLPLJMPA()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(EFBEKNLOILH));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(FIBOIODLMAG));
		}
		if (EventsManager.OMNBJDPGPEN((EventsManager.EventType)157) && !EventsManager.HGALHLALOKJ((EventsManager.EventType)(-85)))
		{
			Debug.Log((object)"Hikari/Barks_Intro");
			ENGAJJPHILO();
		}
		else if (EventsManager.LOFKKDNOKNF((EventsManager.EventType)(-168)))
		{
			Debug.Log((object)"Disabled");
			DOGILJIDGPH();
		}
	}
}
