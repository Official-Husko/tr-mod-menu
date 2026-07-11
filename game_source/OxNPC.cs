using System;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class OxNPC : DialogueNPCBase
{
	private static OxNPC IADEMLIIDPC;

	public float timeBarks;

	private int HKKKNMIKPCM;

	private string HDFMHCKKJJG = "";

	public static OxNPC GGFJGHHHEJC => IADEMLIIDPC;

	public new void CheckExclamation()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
	}

	public void GBDLGKNDBIK()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(BGMJCCFNNDL().dialogueEvent))
		{
			EBAIHKJHCCA().barkDialogue = true;
			EJHDHCNILDH().mouseUpTrigger = false;
			BGMJCCFNNDL().StartConversation(0, AAFOFNEHPLC().dialogueEvent);
			JFNOOMJMHCB().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)8)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = (Direction)6;
		}
		if (disable)
		{
			content.SetActive(true);
			disable = false;
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.APGJMNHJNHN();
			}
		}
		targetWalkTo = Vector2.zero;
	}

	private void HOKAPOOCJCC()
	{
		SelectDialogueUI();
	}

	private void HOKBBFHGACN()
	{
		SelectDialogueUI();
	}

	private void KBOFHCAJELA()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GIHBNEFPDKK();
		}
	}

	public void FPOLMODHMOF()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Dig");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		}
	}

	private void DPHJPAMFAHK()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.PLAGPJAKCKL(OEBNHGNJEJL: true);
		}
	}

	private void FOJJKOJBHEI()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			PEIHKJFDLAM();
		}
	}

	public void EKKABFPJMEO(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		disable = AMEOKNOLILB;
		walkTo.HELOLJBENMK(targetWalkTo, AHDHLIECIGH: true, NGAKHGJANLO: false);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(NHCAPCCBNAL));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(NNFPNFNFCJJ));
		walkTo.PEHELKCIECB();
	}

	private void HKKDEKIFPPJ()
	{
		SelectDialogueUI();
	}

	[SpecialName]
	public static OxNPC POINNCPMEIG()
	{
		return IADEMLIIDPC;
	}

	protected override void Awake()
	{
		base.Awake();
		IADEMLIIDPC = this;
	}

	private void GIHBNEFPDKK()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.PLAGPJAKCKL();
		}
	}

	private void CFHJMNECODC()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.GOACFCOOJLK();
		}
	}

	[SpecialName]
	public static OxNPC DBJCACLEFGK()
	{
		return IADEMLIIDPC;
	}

	private void GHBEMCOFHOC()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			PEIHKJFDLAM();
		}
	}

	[SpecialName]
	public static OxNPC LADDMEMMJFP()
	{
		return IADEMLIIDPC;
	}

	public void GEAKPMEBBAI()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(EBAIHKJHCCA().dialogueEvent))
		{
			PDECKLKPKCG().barkDialogue = false;
			EBAIHKJHCCA().mouseUpTrigger = true;
			BGMJCCFNNDL().StartConversation(1, GGFJGHHHEJC.dialogueEvent, FLHBPHPKIML: true);
			KGPJPILAHDE().dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Diagonal)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = (Direction)5;
		}
		if (disable)
		{
			content.SetActive(false);
			disable = false;
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.APGJMNHJNHN();
			}
		}
		targetWalkTo = Vector2.zero;
	}

	public void JAGIEEJADMN(string emotion)
	{
		PNHHCHJCDNM().emotionsController.NMAPMPBAGMM(emotion);
	}

	public void JPPDLKEOFDF()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Selected");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		}
	}

	public void OLIDLCCMNKA(string emotion)
	{
		GGFJGHHHEJC.emotionsController.StartEmotion(emotion);
	}

	public void BCDJBMCDNBP()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Miners/Camp/Clive/Talk");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		}
	}

	private void FGJPOPCBFNE()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			OBBNJFKHANB();
		}
	}

	private void GAEDNJMJDJD()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GIHBNEFPDKK();
		}
	}

	public void ABCLGBAJPIK(string emotion)
	{
		EBAIHKJHCCA().emotionsController.GPLECKGJFKM(emotion);
	}

	public void KMFMHKIPDAL()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(POINNCPMEIG().dialogueEvent))
		{
			JFNOOMJMHCB().barkDialogue = false;
			LADDMEMMJFP().mouseUpTrigger = true;
			KPDFIEMDDCL().StartConversation(1, GGFJGHHHEJC.dialogueEvent, FLHBPHPKIML: true);
			PDECKLKPKCG().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)7)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = (Direction)7;
		}
		if (disable)
		{
			content.SetActive(true);
			disable = true;
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.SendDisableContent();
			}
		}
		targetWalkTo = Vector2.zero;
	}

	private void EHJNEHDKLAG()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			PEIHKJFDLAM();
		}
	}

	public void PPGFNGEFCPF()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Drink");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
	}

	private void CFIIEJDJFPB()
	{
		SelectDialogueUI();
	}

	public void AHNEJOFMIGI(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		disable = AMEOKNOLILB;
		walkTo.HELOLJBENMK(targetWalkTo, AHDHLIECIGH: false);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(IJKIFECCGEP));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(NNFPNFNFCJJ));
		walkTo.NOFKEMGPFEO();
	}

	[SpecialName]
	public static OxNPC KGPJPILAHDE()
	{
		return IADEMLIIDPC;
	}

	private void BPNEABGPAIB()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		NBCIKEEAFFM(targetWalkTo, endWalkDirection, AMEOKNOLILB: true);
	}

	public void FJPJHODBNIJ()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("qualityWater");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		}
	}

	private void DJEEOPKPAIK()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.PAHDHACALOH();
		}
	}

	public void GLJBJKJNHAN(string emotion)
	{
		EJHDHCNILDH().emotionsController.EMMBEAHMDHE(emotion);
	}

	public void CNIEDLKPGBK()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(JFNOOMJMHCB().dialogueEvent))
		{
			KPDFIEMDDCL().barkDialogue = true;
			MOJDNGDNCCO().mouseUpTrigger = true;
			EJHDHCNILDH().StartConversation(0, POINNCPMEIG().dialogueEvent, FLHBPHPKIML: true);
			DBJCACLEFGK().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)7)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = (Direction)8;
		}
		if (disable)
		{
			content.SetActive(true);
			disable = false;
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.SendDisableContent();
			}
		}
		targetWalkTo = Vector2.zero;
	}

	protected override void NJJCCIBDAPM()
	{
		barkDialogue = false;
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		if (EventsManager.IsActive(EventsManager.EventType.ThroneRoom))
		{
			dialogue.conversation = "SalonDelTrono/OxTalk";
		}
	}

	private void ACOJHBFFFIF()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		Walk(targetWalkTo, endWalkDirection);
	}

	public void APEGJBHIPBF(string emotion)
	{
		EBAIHKJHCCA().emotionsController.NMAPMPBAGMM(emotion);
	}

	public void ODKNNOBCILE()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(JFNOOMJMHCB().dialogueEvent))
		{
			DBJCACLEFGK().barkDialogue = true;
			BGMJCCFNNDL().mouseUpTrigger = false;
			BGMJCCFNNDL().StartConversation(0, BGMJCCFNNDL().dialogueEvent);
			LADDMEMMJFP().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)6)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = Direction.Down;
		}
		if (disable)
		{
			content.SetActive(false);
			disable = true;
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.SendDisableContent();
			}
		}
		targetWalkTo = Vector2.zero;
	}

	public void IOJEMPOAPCE()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Items/item_name_1148");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
	}

	[SpecialName]
	public static OxNPC PDECKLKPKCG()
	{
		return IADEMLIIDPC;
	}

	public void JDGOKDNEIPA(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		disable = AMEOKNOLILB;
		walkTo.GLHBJNDMIDC(targetWalkTo, AHDHLIECIGH: true, NGAKHGJANLO: false);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(IEJGDOPLBLB));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(NJDHHOOGDFI));
		walkTo.NOFKEMGPFEO();
	}

	public void IEJGDOPLBLB()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(PNHHCHJCDNM().dialogueEvent))
		{
			EJHDHCNILDH().barkDialogue = true;
			GGFJGHHHEJC.mouseUpTrigger = false;
			EJHDHCNILDH().StartConversation(0, MOJDNGDNCCO().dialogueEvent);
			KGPJPILAHDE().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)5)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = Direction.Up;
		}
		if (disable)
		{
			content.SetActive(false);
			disable = false;
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.APGJMNHJNHN();
			}
		}
		targetWalkTo = Vector2.zero;
	}

	[SpecialName]
	public static OxNPC EBAIHKJHCCA()
	{
		return IADEMLIIDPC;
	}

	public void LMOEGCLAHEK(string emotion)
	{
		GGFJGHHHEJC.emotionsController.PIOCPGKDAOF(emotion);
	}

	public void Walk(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		disable = AMEOKNOLILB;
		walkTo.FNNPPBDFBCI(targetWalkTo);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(OnActionComplete));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(ACOJHBFFFIF));
		walkTo.PEHELKCIECB();
	}

	private void PDLDELGPHMG()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		EKKABFPJMEO(targetWalkTo, endWalkDirection);
	}

	private void EOFEAJHOMDN()
	{
		if (OnlineManager.MasterOrOffline())
		{
			CFHJMNECODC();
		}
	}

	public void EFNENNELAKM(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		disable = AMEOKNOLILB;
		walkTo.DHFPOCOEONG(targetWalkTo);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(PBBBJBHFGNN));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(NNFPNFNFCJJ));
		walkTo.PEHELKCIECB();
	}

	public void BMNFEAHLBJB(string emotion)
	{
		MOJDNGDNCCO().emotionsController.GPLECKGJFKM(emotion);
	}

	public void PBBBJBHFGNN()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(PNHHCHJCDNM().dialogueEvent))
		{
			MOJDNGDNCCO().barkDialogue = true;
			DBJCACLEFGK().mouseUpTrigger = true;
			JFNOOMJMHCB().StartConversation(1, PNHHCHJCDNM().dialogueEvent);
			KPDFIEMDDCL().dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Left)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = Direction.Diagonal;
		}
		if (disable)
		{
			content.SetActive(true);
			disable = false;
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.SendDisableContent();
			}
		}
		targetWalkTo = Vector2.zero;
	}

	private void HFLCAILNOHC()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		AHNEJOFMIGI(targetWalkTo, endWalkDirection, AMEOKNOLILB: true);
	}

	[SpecialName]
	public static OxNPC MOJDNGDNCCO()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static OxNPC BGMJCCFNNDL()
	{
		return IADEMLIIDPC;
	}

	public void PALMKNNGBBI(string emotion)
	{
		POINNCPMEIG().emotionsController.PIOCPGKDAOF(emotion);
	}

	public void HNMMHJOFBGB(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		disable = AMEOKNOLILB;
		walkTo.GINPKMBGOFN(targetWalkTo, AHDHLIECIGH: true, NGAKHGJANLO: false);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(KMFMHKIPDAL));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(BPNEABGPAIB));
		walkTo.PEHELKCIECB();
	}

	private void BCKLFAGEKOJ()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.IIMEFNIECLI(OEBNHGNJEJL: true);
		}
	}

	public override DialogueNPCBase GetInstance()
	{
		return GGFJGHHHEJC;
	}

	protected override void OnConversationStart(Transform actor)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		base.OnConversationStart(actor);
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		HKKKNMIKPCM = ((Result)(ref variable)).asInt;
	}

	[SpecialName]
	public static OxNPC AAFOFNEHPLC()
	{
		return IADEMLIIDPC;
	}

	public void BLJCLIIFJBM()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Inventory full");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		}
	}

	private void NNFPNFNFCJJ()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		OIFAGKBHCAP(targetWalkTo, endWalkDirection, AMEOKNOLILB: true);
	}

	private void GPKKMEGKDHE()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.IIMEFNIECLI(OEBNHGNJEJL: true);
		}
	}

	private void NKDFMFFDGKC()
	{
		SelectDialogueUI();
	}

	public void GGOCPPNOGCD(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		disable = AMEOKNOLILB;
		walkTo.GINPKMBGOFN(targetWalkTo);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(NHCAPCCBNAL));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(DMGEKAGCEKD));
		walkTo.PEHELKCIECB();
	}

	public void AHMKELCJDAB()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Idle");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		}
	}

	private void HEDGGNKENPB()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			HGBOPJGAKEP();
		}
	}

	private void KAOLCOJBFCE()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			BCKLFAGEKOJ();
		}
	}

	public void AMDJKCNAFHJ(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		disable = AMEOKNOLILB;
		walkTo.EJPGFOEDPBG(targetWalkTo, AHDHLIECIGH: false, NGAKHGJANLO: false);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(OnActionComplete));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(PDLDELGPHMG));
		walkTo.EHDKLBLKBEO();
	}

	private void KEPJNGGNAEK()
	{
		SelectDialogueUI();
	}

	public void CKKLLIIIBEG(string emotion)
	{
		EBAIHKJHCCA().emotionsController.GPLECKGJFKM(emotion);
	}

	private void KILDJCPLOPP()
	{
		SelectDialogueUI();
	}

	private void DPOHEFNJFKK()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			IPMEFFKMPCI();
		}
	}

	public void OEPALJIDLHC(string emotion)
	{
		POINNCPMEIG().emotionsController.DCCNJLBLFGI(emotion);
	}

	public void IJBBCPGIEHI(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		disable = AMEOKNOLILB;
		walkTo.CGFMBJFGLAG(targetWalkTo, AHDHLIECIGH: false, NGAKHGJANLO: false);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(GEAKPMEBBAI));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(PDLDELGPHMG));
		walkTo.NOFKEMGPFEO();
	}

	[SpecialName]
	public static OxNPC KPDFIEMDDCL()
	{
		return IADEMLIIDPC;
	}

	protected override void OnConversationEnd(Transform actor)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		base.OnConversationEnd(actor);
		int hKKKNMIKPCM = HKKKNMIKPCM;
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		if (hKKKNMIKPCM != ((Result)(ref variable)).asInt && OnlineManager.PlayingOnline())
		{
			OnlineDialogueManager instance = OnlineDialogueManager.instance;
			string hDFMHCKKJJG = HDFMHCKKJJG;
			variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			instance.SendDialogueInfo(hDFMHCKKJJG, ((Result)(ref variable)).asInt);
		}
	}

	public void OIFAGKBHCAP(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		disable = AMEOKNOLILB;
		walkTo.HELOLJBENMK(targetWalkTo);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(DDEGJLEHDJM));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(BPNEABGPAIB));
		walkTo.PEHELKCIECB();
	}

	public void MFGLEIGBFFF()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("AttackBird");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
		}
	}

	public void BCGDKFANMMH()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("ReceiveBasics");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
	}

	public void NHCAPCCBNAL()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(MOJDNGDNCCO().dialogueEvent))
		{
			AAFOFNEHPLC().barkDialogue = true;
			LHKFIDJFPDB().mouseUpTrigger = true;
			LHKFIDJFPDB().StartConversation(0, BGMJCCFNNDL().dialogueEvent, FLHBPHPKIML: true);
			KPDFIEMDDCL().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)7)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = (Direction)5;
		}
		if (disable)
		{
			content.SetActive(true);
			disable = false;
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.APGJMNHJNHN();
			}
		}
		targetWalkTo = Vector2.zero;
	}

	private void MFMMHDPGCBO()
	{
		SelectDialogueUI(1);
	}

	private void DMGEKAGCEKD()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		PAEGFOIALNI(targetWalkTo, endWalkDirection, AMEOKNOLILB: true);
	}

	public void ONBEELLFCIH(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		disable = AMEOKNOLILB;
		walkTo.GLHBJNDMIDC(targetWalkTo, AHDHLIECIGH: false, NGAKHGJANLO: false);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(GEAKPMEBBAI));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(BPNEABGPAIB));
		walkTo.EHDKLBLKBEO();
	}

	private void NDGBBEFBJDE()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			GIHBNEFPDKK();
		}
	}

	private void NELBHAMPBPL()
	{
		SelectDialogueUI();
	}

	public void JECGJNDCMCG()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("us");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
	}

	public void FMCMAMOBOLN(string emotion)
	{
		EBAIHKJHCCA().emotionsController.NMAPMPBAGMM(emotion);
	}

	public void PIFFBOOAMED(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		disable = AMEOKNOLILB;
		walkTo.FNNPPBDFBCI(targetWalkTo, AHDHLIECIGH: false);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(GEAKPMEBBAI));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(PDLDELGPHMG));
		walkTo.PEHELKCIECB();
	}

	public void IJKIFECCGEP()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(AAFOFNEHPLC().dialogueEvent))
		{
			EJHDHCNILDH().barkDialogue = true;
			GGFJGHHHEJC.mouseUpTrigger = false;
			JFNOOMJMHCB().StartConversation(1, AAFOFNEHPLC().dialogueEvent);
			LADDMEMMJFP().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)5)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = Direction.Up;
		}
		if (disable)
		{
			content.SetActive(false);
			disable = false;
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.APGJMNHJNHN();
			}
		}
		targetWalkTo = Vector2.zero;
	}

	[SpecialName]
	public static OxNPC LHKFIDJFPDB()
	{
		return IADEMLIIDPC;
	}

	private void Start()
	{
		SelectDialogueUI();
	}

	public void GACCDKPCDMP(string emotion)
	{
		BGMJCCFNNDL().emotionsController.PIOCPGKDAOF(emotion);
	}

	public void OnActionComplete()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(GGFJGHHHEJC.dialogueEvent))
		{
			GGFJGHHHEJC.barkDialogue = false;
			GGFJGHHHEJC.mouseUpTrigger = true;
			GGFJGHHHEJC.StartConversation(1, GGFJGHHHEJC.dialogueEvent);
			GGFJGHHHEJC.dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Diagonal)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = Direction.Diagonal;
		}
		if (disable)
		{
			content.SetActive(false);
			disable = false;
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.SendDisableContent();
			}
		}
		targetWalkTo = Vector2.zero;
	}

	private void HHLDEFAJLMO()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.PAHDHACALOH(OEBNHGNJEJL: true);
		}
	}

	public void CAKMJKDLEOB()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Error_RoomZone");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
		}
	}

	public void StartEmotions(string emotion)
	{
		GGFJGHHHEJC.emotionsController.StartEmotion(emotion);
	}

	public void PFFAJBLGFDO(string emotion)
	{
		BGMJCCFNNDL().emotionsController.GPLECKGJFKM(emotion);
	}

	[SpecialName]
	public static OxNPC EJHDHCNILDH()
	{
		return IADEMLIIDPC;
	}

	public void BKOLAAFOBLF()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("popUpBuilding4");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
	}

	public void HJBBGFPGGDO(string emotion)
	{
		EBAIHKJHCCA().emotionsController.StartEmotion(emotion);
	}

	private void OILHJENGGEL()
	{
		SelectDialogueUI();
	}

	public void HHJNMFFPIKM()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("</color>");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
	}

	public void HBEPDNOMENA(string emotion)
	{
		LADDMEMMJFP().emotionsController.PIOCPGKDAOF(emotion);
	}

	private void DIKPOHPGNLG()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.IIMEFNIECLI();
		}
	}

	public void IHIDJOEEMBK()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Name...");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
	}

	public void NBCIKEEAFFM(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		disable = AMEOKNOLILB;
		walkTo.HELOLJBENMK(targetWalkTo, AHDHLIECIGH: false);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(IEJGDOPLBLB));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(PDLDELGPHMG));
		walkTo.NOFKEMGPFEO();
	}

	public void ONJOFPIPANN(string emotion)
	{
		JFNOOMJMHCB().emotionsController.StartEmotion(emotion);
	}

	private void PEIHKJFDLAM()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.PLAGPJAKCKL(OEBNHGNJEJL: true);
		}
	}

	private void KJIHKAKCKBL()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		AHNEJOFMIGI(targetWalkTo, endWalkDirection);
	}

	public void BKJFOGKLPKK(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		disable = AMEOKNOLILB;
		walkTo.DHFPOCOEONG(targetWalkTo, AHDHLIECIGH: false, NGAKHGJANLO: false);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(ODKNNOBCILE));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(NJDHHOOGDFI));
		walkTo.EHDKLBLKBEO();
	}

	private void FOIGFCMPAAO()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			OBBNJFKHANB();
		}
	}

	public void OFPDKCFLPLH()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Error_AnotherZoneInRoom");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		}
	}

	public void CDOFKJEIDAP()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Trying to add a player that's already on the list.");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
	}

	private void NDNBDEHFFJF()
	{
		SelectDialogueUI();
	}

	private void IPMEFFKMPCI()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.PAHDHACALOH();
		}
	}

	private void PCPNEJOIKAN()
	{
		if (OnlineManager.MasterOrOffline())
		{
			BCKLFAGEKOJ();
		}
	}

	private void GBIDNAGBLBF()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			OBBNJFKHANB();
		}
	}

	private void FixedUpdate()
	{
		if (OnlineManager.MasterOrOffline())
		{
			DIKPOHPGNLG();
		}
	}

	private void AHIPEAEMEAF()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.PAHDHACALOH();
		}
	}

	private void HFMJPMEALMO()
	{
		SelectDialogueUI();
	}

	private void IMIONHLAKIH()
	{
		SelectDialogueUI(1);
	}

	public void MCFCNKLOCKL(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		disable = AMEOKNOLILB;
		walkTo.GDGGABHLNOH(targetWalkTo, AHDHLIECIGH: true, NGAKHGJANLO: false);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(PBBBJBHFGNN));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(IAMOBHAIPHN));
		walkTo.PEHELKCIECB();
	}

	private void AHGPALJKOKP()
	{
		SelectDialogueUI(1);
	}

	public void IOKILGMHFNE(string emotion)
	{
		JFNOOMJMHCB().emotionsController.GPLECKGJFKM(emotion);
	}

	private void OBBNJFKHANB()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.BODEPFFAHLE(OEBNHGNJEJL: true);
		}
	}

	private void DEFIFMAOPCM()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			GIHBNEFPDKK();
		}
	}

	public void JBKHJEJAMHM()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Select");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
	}

	public void PAEGFOIALNI(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		disable = AMEOKNOLILB;
		walkTo.DHFPOCOEONG(targetWalkTo, AHDHLIECIGH: false, NGAKHGJANLO: false);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(IJKIFECCGEP));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(DMGEKAGCEKD));
		walkTo.NOFKEMGPFEO();
	}

	public void KHCNNNJAMPL()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Dialogue System/Conversation/Gass_Barks_Bye/Entry/6/Dialogue Text");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
	}

	private void DMNDKNKFELP()
	{
		if (OnlineManager.MasterOrOffline())
		{
			BCKLFAGEKOJ();
		}
	}

	public void DDEGJLEHDJM()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(KPDFIEMDDCL().dialogueEvent))
		{
			EBAIHKJHCCA().barkDialogue = false;
			KGPJPILAHDE().mouseUpTrigger = false;
			LADDMEMMJFP().StartConversation(1, EBAIHKJHCCA().dialogueEvent, FLHBPHPKIML: true);
			PNHHCHJCDNM().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)8)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = Direction.Right;
		}
		if (disable)
		{
			content.SetActive(false);
			disable = true;
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.SendDisableContent();
			}
		}
		targetWalkTo = Vector2.zero;
	}

	public void HBGMAHANFEM()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("SFXVolume");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
	}

	[SpecialName]
	public static OxNPC PNHHCHJCDNM()
	{
		return IADEMLIIDPC;
	}

	private void HGBOPJGAKEP()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.GOACFCOOJLK();
		}
	}

	private void NJDHHOOGDFI()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		Walk(targetWalkTo, endWalkDirection);
	}

	private void GHPFCKGMLDA()
	{
		SelectDialogueUI(1);
	}

	public void IGCKEKHJMPJ(string emotion)
	{
		MOJDNGDNCCO().emotionsController.PIOCPGKDAOF(emotion);
	}

	public void KIBIHBFJOJH(string emotion)
	{
		POINNCPMEIG().emotionsController.NBFIDOGMLOK(emotion);
	}

	private void KIGPIILBDAC()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GPKKMEGKDHE();
		}
	}

	public void BLDPKJOMJOK(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		disable = AMEOKNOLILB;
		walkTo.GLHBJNDMIDC(targetWalkTo, AHDHLIECIGH: true, NGAKHGJANLO: false);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(GEAKPMEBBAI));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(IAMOBHAIPHN));
		walkTo.PEHELKCIECB();
	}

	private void MNFHGEELJOP()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		AOGHLDJHBMD(targetWalkTo, endWalkDirection);
	}

	[SpecialName]
	public static OxNPC JFNOOMJMHCB()
	{
		return IADEMLIIDPC;
	}

	public void AOGHLDJHBMD(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		disable = AMEOKNOLILB;
		walkTo.GHDMBFOAAHK(targetWalkTo, AHDHLIECIGH: false);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(KMFMHKIPDAL));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(NNFPNFNFCJJ));
		walkTo.EHDKLBLKBEO();
	}

	public void LAPNEPFAECM(string emotion)
	{
		POINNCPMEIG().emotionsController.NMAPMPBAGMM(emotion);
	}

	private void IAMOBHAIPHN()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		GGOCPPNOGCD(targetWalkTo, endWalkDirection);
	}

	private void ECGANLCHOEK()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.PLAGPJAKCKL();
		}
	}
}
