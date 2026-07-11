using System;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class OrwinIINPC : DialogueNPCBase
{
	private static OrwinIINPC IADEMLIIDPC;

	public float timeBarks;

	private int HKKKNMIKPCM;

	private string HDFMHCKKJJG = "";

	public static OrwinIINPC GGFJGHHHEJC => IADEMLIIDPC;

	public void JHLPNDEKCPK()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Received RPC SetTrigger {0} on {1}. Setting animator parameter.");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
	}

	public void LACDAMFANIM()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(KFGKCKCDMLG().dialogueEvent))
		{
			HGJMGNJOHGF().barkDialogue = false;
			KEJMJMKEEGA().mouseUpTrigger = true;
			OOKBNHMMFON().StartConversation(1, JHMAMLIPBNN().dialogueEvent);
			DOIKFJDLKJP().dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Diagonal)
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

	[SpecialName]
	public static OrwinIINPC DOIKFJDLKJP()
	{
		return IADEMLIIDPC;
	}

	private void BFMBEDNIGAB()
	{
		SelectDialogueUI();
	}

	public void PPPADNMKKIO()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Items/item_name_1180");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		}
	}

	public void GIHKIILJDFF()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Precision/DrinkEvent1");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		}
	}

	[SpecialName]
	public static OrwinIINPC MIGKKKELOJO()
	{
		return IADEMLIIDPC;
	}

	private void EGDIINMEMGE()
	{
		SelectDialogueUI();
	}

	public void JEPBPABEDGE()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(MOJDNGDNCCO().dialogueEvent))
		{
			NBKKEINELDN().barkDialogue = true;
			EAGMIHGJKNB().mouseUpTrigger = true;
			NHKAFANMEJC().StartConversation(1, KEJMJMKEEGA().dialogueEvent);
			MOJDNGDNCCO().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)8)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = (Direction)7;
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

	public void PKCODIDOBJO()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(JHMAMLIPBNN().dialogueEvent))
		{
			MOJDNGDNCCO().barkDialogue = true;
			JLNBMNKJCHE().mouseUpTrigger = true;
			KEJMJMKEEGA().StartConversation(0, JLNBMNKJCHE().dialogueEvent, FLHBPHPKIML: true);
			DOIKFJDLKJP().dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Diagonal)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = Direction.Right;
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

	public void AHFAJIBFKGK(string emotion)
	{
		EAGMIHGJKNB().emotionsController.GPLECKGJFKM(emotion);
	}

	private void PBFAEPOEKPG()
	{
		SelectDialogueUI(1);
	}

	[SpecialName]
	public static OrwinIINPC MOJDNGDNCCO()
	{
		return IADEMLIIDPC;
	}

	public void KPOIBPDHLPE(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		disable = AMEOKNOLILB;
		walkTo.CGFMBJFGLAG(targetWalkTo, AHDHLIECIGH: true, NGAKHGJANLO: false);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(PKCODIDOBJO));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(GJIJGACIOKK));
		walkTo.EHDKLBLKBEO();
	}

	private void MKNKEDELDAK()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.GOACFCOOJLK();
		}
	}

	private void ANKACHJAGAM()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.IIMEFNIECLI(OEBNHGNJEJL: true);
		}
	}

	private void DPHJPAMFAHK()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.GOACFCOOJLK(OEBNHGNJEJL: true);
		}
	}

	private void EBNKNEIDDDI()
	{
		SelectDialogueUI(1);
	}

	private void ELPFAGMEFJP()
	{
		SelectDialogueUI(1);
	}

	public void PBBBJBHFGNN()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(JHMAMLIPBNN().dialogueEvent))
		{
			EAGMIHGJKNB().barkDialogue = true;
			KFGKCKCDMLG().mouseUpTrigger = false;
			ACPHFLBLJAA().StartConversation(0, EAGMIHGJKNB().dialogueEvent);
			KCFGPDHELKP().dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Left)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = (Direction)5;
		}
		if (disable)
		{
			content.SetActive(true);
			disable = true;
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.APGJMNHJNHN();
			}
		}
		targetWalkTo = Vector2.zero;
	}

	public void NHCAPCCBNAL()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(MOJDNGDNCCO().dialogueEvent))
		{
			KFGKCKCDMLG().barkDialogue = true;
			MOJDNGDNCCO().mouseUpTrigger = false;
			KCFGPDHELKP().StartConversation(0, MOJDNGDNCCO().dialogueEvent);
			EAGMIHGJKNB().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)7)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = (Direction)6;
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

	[SpecialName]
	public static OrwinIINPC IBEGPMLJIOJ()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static OrwinIINPC DPJEGJBHBNP()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static OrwinIINPC JHMAMLIPBNN()
	{
		return IADEMLIIDPC;
	}

	public void MAOACOAHDHF(string emotion)
	{
		DPJEGJBHBNP().emotionsController.GPLECKGJFKM(emotion);
	}

	public void OELABGFLPBN()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Rest");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
	}

	public void PJGJGBEADMB(string emotion)
	{
		IBEGPMLJIOJ().emotionsController.DCCNJLBLFGI(emotion);
	}

	public void FLNBKOCCECK()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Open");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
		}
	}

	private void PKBHEKHOAAA()
	{
		SelectDialogueUI(1);
	}

	[SpecialName]
	public static OrwinIINPC KFGKCKCDMLG()
	{
		return IADEMLIIDPC;
	}

	public void OPBHGODNODN()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(HGJMGNJOHGF().dialogueEvent))
		{
			MOJDNGDNCCO().barkDialogue = false;
			MIGKKKELOJO().mouseUpTrigger = true;
			JHMAMLIPBNN().StartConversation(1, NHKAFANMEJC().dialogueEvent, FLHBPHPKIML: true);
			NHKAFANMEJC().dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Left)
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
				onlineDialogue.SendDisableContent();
			}
		}
		targetWalkTo = Vector2.zero;
	}

	private void ENHPMGIOBLL()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			IFOJNAECHEI();
		}
	}

	private void Start()
	{
		SelectDialogueUI();
	}

	public void MONKBNPGGIG(string emotion)
	{
		HGJMGNJOHGF().emotionsController.NMAPMPBAGMM(emotion);
	}

	protected override void NJJCCIBDAPM()
	{
		barkDialogue = false;
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		if (EventsManager.IsActive(EventsManager.EventType.ThroneRoom))
		{
			dialogue.conversation = "SalonDelTrono/OrwinIITalk";
		}
	}

	[SpecialName]
	public static OrwinIINPC NHKAFANMEJC()
	{
		return IADEMLIIDPC;
	}

	public void JECGJNDCMCG()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("blacksmith");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
	}

	public void BFNAPCFJKKB()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(JHMAMLIPBNN().dialogueEvent))
		{
			JLNBMNKJCHE().barkDialogue = false;
			ELGNEJNLBNO().mouseUpTrigger = false;
			MIGKKKELOJO().StartConversation(1, MOJDNGDNCCO().dialogueEvent);
			ACPHFLBLJAA().dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Down)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = Direction.Diagonal;
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

	public void OPAGDKFGFLL(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		disable = AMEOKNOLILB;
		walkTo.DBHOIIIHIIM(targetWalkTo);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(MDOEDAKBFKO));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(BIGHFOIJPGN));
		walkTo.EHDKLBLKBEO();
	}

	private void NDGBBEFBJDE()
	{
		if (OnlineManager.MasterOrOffline())
		{
			MKNKEDELDAK();
		}
	}

	public void MMPGIKGMFMA()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(HGJMGNJOHGF().dialogueEvent))
		{
			DOIKFJDLKJP().barkDialogue = false;
			ACPHFLBLJAA().mouseUpTrigger = false;
			JLNBMNKJCHE().StartConversation(0, PEJFACMBPBN().dialogueEvent);
			PEJFACMBPBN().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)7)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = (Direction)5;
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

	public void MKIONOKDHPA(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
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
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(MDOEDAKBFKO));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(LHEHNNJGINH));
		walkTo.NOFKEMGPFEO();
	}

	[SpecialName]
	public static OrwinIINPC HGJMGNJOHGF()
	{
		return IADEMLIIDPC;
	}

	private void HHLBFDBHDMC()
	{
		SelectDialogueUI();
	}

	public void BLDPKJOMJOK(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		disable = AMEOKNOLILB;
		walkTo.KBEENHPEOAB(targetWalkTo, AHDHLIECIGH: false);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(HACNKBFKNHH));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(GJIJGACIOKK));
		walkTo.EHDKLBLKBEO();
	}

	private void PIEAKAIHNNN()
	{
		if (OnlineManager.MasterOrOffline())
		{
			LCBLBPIGJLL();
		}
	}

	[SpecialName]
	public static OrwinIINPC JLNBMNKJCHE()
	{
		return IADEMLIIDPC;
	}

	private void HFFFFAJFIPB()
	{
		SelectDialogueUI(1);
	}

	public void JLOAGFDMLIM(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
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
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(LACDAMFANIM));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(LHEHNNJGINH));
		walkTo.PEHELKCIECB();
	}

	private void AHNEAEKDBED()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		Walk(targetWalkTo, endWalkDirection, AMEOKNOLILB: true);
	}

	public void IPKFEPKJIJE()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(MKIEMMGGFEE().dialogueEvent))
		{
			EKGMDIHLEEH().barkDialogue = true;
			HGJMGNJOHGF().mouseUpTrigger = true;
			EAGMIHGJKNB().StartConversation(0, OOKBNHMMFON().dialogueEvent);
			OOKBNHMMFON().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)6)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = (Direction)8;
		}
		if (disable)
		{
			content.SetActive(true);
			disable = true;
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.APGJMNHJNHN();
			}
		}
		targetWalkTo = Vector2.zero;
	}

	[SpecialName]
	public static OrwinIINPC ELGNEJNLBNO()
	{
		return IADEMLIIDPC;
	}

	private void FPDPAJHNGHK()
	{
		SelectDialogueUI();
	}

	public void EACGIFJCIKJ()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("LE_20");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
	}

	public void PPGFNGEFCPF()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("ChatInviteCode");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
	}

	public void GIFNIPDANAI(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		disable = AMEOKNOLILB;
		walkTo.KBEENHPEOAB(targetWalkTo, AHDHLIECIGH: false, NGAKHGJANLO: false);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(OPBHGODNODN));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(LHEHNNJGINH));
		walkTo.NOFKEMGPFEO();
	}

	[SpecialName]
	public static OrwinIINPC NBKKEINELDN()
	{
		return IADEMLIIDPC;
	}

	public void LPMIHGICGNK()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(PEJFACMBPBN().dialogueEvent))
		{
			MKIEMMGGFEE().barkDialogue = true;
			PEJFACMBPBN().mouseUpTrigger = false;
			KFGKCKCDMLG().StartConversation(0, NHKAFANMEJC().dialogueEvent);
			MKIEMMGGFEE().dialogueEvent = null;
		}
		if (endWalkDirection != 0)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = (Direction)7;
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

	public void BAOAJDFKEEJ()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("autoHireDesc");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		}
	}

	protected override void Awake()
	{
		base.Awake();
		IADEMLIIDPC = this;
	}

	private void DMNDKNKFELP()
	{
		if (OnlineManager.MasterOrOffline())
		{
			DIKPOHPGNLG();
		}
	}

	private void KBOFHCAJELA()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			LCBLBPIGJLL();
		}
	}

	private void CAIJLMJBMLA()
	{
		SelectDialogueUI(1);
	}

	public void JLFNGOAPGOM(string emotion)
	{
		OOKBNHMMFON().emotionsController.PIOCPGKDAOF(emotion);
	}

	[SpecialName]
	public static OrwinIINPC EKGMDIHLEEH()
	{
		return IADEMLIIDPC;
	}

	private void MDILLGFCCMI()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		BLDPKJOMJOK(targetWalkTo, endWalkDirection);
	}

	[SpecialName]
	public static OrwinIINPC ACPHFLBLJAA()
	{
		return IADEMLIIDPC;
	}

	public void IOKILGMHFNE(string emotion)
	{
		GGFJGHHHEJC.emotionsController.NBFIDOGMLOK(emotion);
	}

	public void ELBLAFPCJOL(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		disable = AMEOKNOLILB;
		walkTo.GINPKMBGOFN(targetWalkTo, AHDHLIECIGH: false, NGAKHGJANLO: false);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(IPKFEPKJIJE));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(MDILLGFCCMI));
		walkTo.NOFKEMGPFEO();
	}

	public void HACNKBFKNHH()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(IBEGPMLJIOJ().dialogueEvent))
		{
			IBEGPMLJIOJ().barkDialogue = false;
			MKIEMMGGFEE().mouseUpTrigger = false;
			JHMAMLIPBNN().StartConversation(0, KFGKCKCDMLG().dialogueEvent, FLHBPHPKIML: true);
			IBEGPMLJIOJ().dialogueEvent = null;
		}
		if (endWalkDirection != 0)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = (Direction)7;
		}
		if (disable)
		{
			content.SetActive(false);
			disable = true;
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.APGJMNHJNHN();
			}
		}
		targetWalkTo = Vector2.zero;
	}

	private void GFEOBIGKDMG()
	{
		SelectDialogueUI(1);
	}

	private void NMMHEFGFMCC()
	{
		SelectDialogueUI(1);
	}

	public void IGOGKMLCLPI()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(MIGKKKELOJO().dialogueEvent))
		{
			PEJFACMBPBN().barkDialogue = false;
			MKIEMMGGFEE().mouseUpTrigger = true;
			GGFJGHHHEJC.StartConversation(1, ELGNEJNLBNO().dialogueEvent, FLHBPHPKIML: true);
			ACPHFLBLJAA().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)6)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = Direction.Down;
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

	private void BGFEBEAJOCG()
	{
		SelectDialogueUI();
	}

	private void OKJHBJMMCFF()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.GOACFCOOJLK();
		}
	}

	private void PGJLFLKDLAE()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			BLIHMNIAENP();
		}
	}

	public void KCIEEKNFHGN(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		disable = AMEOKNOLILB;
		walkTo.GDGGABHLNOH(targetWalkTo);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(NHCAPCCBNAL));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(LHEHNNJGINH));
		walkTo.EHDKLBLKBEO();
	}

	public void APGLLOHDPHO()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(DPJEGJBHBNP().dialogueEvent))
		{
			NBKKEINELDN().barkDialogue = false;
			EKGMDIHLEEH().mouseUpTrigger = false;
			EKGMDIHLEEH().StartConversation(0, DOIKFJDLKJP().dialogueEvent);
			ACPHFLBLJAA().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)8)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = Direction.Right;
		}
		if (disable)
		{
			content.SetActive(true);
			disable = true;
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.APGJMNHJNHN();
			}
		}
		targetWalkTo = Vector2.zero;
	}

	public void AKCJMLPHFEB(string emotion)
	{
		KCFGPDHELKP().emotionsController.DCCNJLBLFGI(emotion);
	}

	private void OKABHFANCHC()
	{
		if (OnlineManager.MasterOrOffline())
		{
			OKJHBJMMCFF();
		}
	}

	private void LCBLBPIGJLL()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.IIMEFNIECLI();
		}
	}

	public void DNNMEFPKCPF()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(NHKAFANMEJC().dialogueEvent))
		{
			OOKBNHMMFON().barkDialogue = true;
			EKGMDIHLEEH().mouseUpTrigger = false;
			OOKBNHMMFON().StartConversation(1, MIGKKKELOJO().dialogueEvent, FLHBPHPKIML: true);
			NBKKEINELDN().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)7)
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
				onlineDialogue.SendDisableContent();
			}
		}
		targetWalkTo = Vector2.zero;
	}

	private void KDBJHCAEGCM()
	{
		SelectDialogueUI(1);
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

	private void EBIDKDLNKHD()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			MKNKEDELDAK();
		}
	}

	private void KLHAAFJOOMC()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			IFOJNAECHEI();
		}
	}

	[SpecialName]
	public static OrwinIINPC MKIEMMGGFEE()
	{
		return IADEMLIIDPC;
	}

	public void NNDPBLBDNCI(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		disable = AMEOKNOLILB;
		walkTo.FNNPPBDFBCI(targetWalkTo, AHDHLIECIGH: false, NGAKHGJANLO: false);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(FEHGALEDJKI));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(OIJCKGLLHKM));
		walkTo.PEHELKCIECB();
	}

	[SpecialName]
	public static OrwinIINPC OOKBNHMMFON()
	{
		return IADEMLIIDPC;
	}

	private void BIGHFOIJPGN()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		MKIONOKDHPA(targetWalkTo, endWalkDirection);
	}

	[SpecialName]
	public static OrwinIINPC EAGMIHGJKNB()
	{
		return IADEMLIIDPC;
	}

	private void FixedUpdate()
	{
		if (OnlineManager.MasterOrOffline())
		{
			DIKPOHPGNLG();
		}
	}

	private void HEADJCFMKIP()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		PIPIAOLJIGE(targetWalkTo, endWalkDirection, AMEOKNOLILB: true);
	}

	private void IKHEIENFDMF()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		GIFNIPDANAI(targetWalkTo, endWalkDirection);
	}

	private void EGACIHOKJLH()
	{
		SelectDialogueUI(1);
	}

	public void FMBEGDCIHHH(string emotion)
	{
		KCFGPDHELKP().emotionsController.GPLECKGJFKM(emotion);
	}

	public void IHLOBJKMODB()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("South");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		}
	}

	public void IEJGDOPLBLB()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(MIGKKKELOJO().dialogueEvent))
		{
			DOIKFJDLKJP().barkDialogue = true;
			MIGKKKELOJO().mouseUpTrigger = false;
			DPJEGJBHBNP().StartConversation(1, EKGMDIHLEEH().dialogueEvent);
			JLNBMNKJCHE().dialogueEvent = null;
		}
		if (endWalkDirection != 0)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = Direction.Up;
		}
		if (disable)
		{
			content.SetActive(true);
			disable = true;
			if (OnlineManager.PlayingOnline())
			{
				onlineDialogue.APGJMNHJNHN();
			}
		}
		targetWalkTo = Vector2.zero;
	}

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

	private void LDPGPIHCBCH()
	{
		SelectDialogueUI();
	}

	private void JAPFDIEHKPI()
	{
		if (OnlineManager.MasterOrOffline())
		{
			DIKPOHPGNLG();
		}
	}

	private void KEPJNGGNAEK()
	{
		SelectDialogueUI();
	}

	protected override void OnConversationStart(Transform actor)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		base.OnConversationStart(actor);
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		HKKKNMIKPCM = ((Result)(ref variable)).asInt;
	}

	public void CKBHDNNKEBI(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		disable = AMEOKNOLILB;
		walkTo.JJDCANFBFMK(targetWalkTo, AHDHLIECIGH: true, NGAKHGJANLO: false);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(IPKFEPKJIJE));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(AEOBJMKNACK));
		walkTo.NOFKEMGPFEO();
	}

	private void OFHGMEMFGCI()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.IIMEFNIECLI();
		}
	}

	public void FAHDMOFILDI()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("LE_14");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		}
	}

	private void JPHEOLEEAPB()
	{
		SelectDialogueUI();
	}

	private void IIDPFCKPCDC()
	{
		SelectDialogueUI(1);
	}

	[SpecialName]
	public static OrwinIINPC PEJFACMBPBN()
	{
		return IADEMLIIDPC;
	}

	public void KGLFHLHBFBH()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(DOIKFJDLKJP().dialogueEvent))
		{
			NBKKEINELDN().barkDialogue = false;
			IBEGPMLJIOJ().mouseUpTrigger = false;
			NHKAFANMEJC().StartConversation(1, IBEGPMLJIOJ().dialogueEvent, FLHBPHPKIML: true);
			MOJDNGDNCCO().dialogueEvent = null;
		}
		if (endWalkDirection != 0)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = Direction.Left;
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

	public void KNNALICIDEN()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(EKGMDIHLEEH().dialogueEvent))
		{
			KCFGPDHELKP().barkDialogue = true;
			MKIEMMGGFEE().mouseUpTrigger = true;
			KCFGPDHELKP().StartConversation(0, DPJEGJBHBNP().dialogueEvent);
			OOKBNHMMFON().dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Right)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = Direction.Diagonal;
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

	private void GJIJGACIOKK()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		OPAGDKFGFLL(targetWalkTo, endWalkDirection, AMEOKNOLILB: true);
	}

	private void AEOBJMKNACK()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		CKBHDNNKEBI(targetWalkTo, endWalkDirection);
	}

	private void MPLHFJGFKJD()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			MKNKEDELDAK();
		}
	}

	public void FEHGALEDJKI()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(ACPHFLBLJAA().dialogueEvent))
		{
			IBEGPMLJIOJ().barkDialogue = false;
			IBEGPMLJIOJ().mouseUpTrigger = true;
			PEJFACMBPBN().StartConversation(1, DPJEGJBHBNP().dialogueEvent, FLHBPHPKIML: true);
			KCFGPDHELKP().dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Down)
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

	public void PIPIAOLJIGE(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
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
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(LACDAMFANIM));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(AHNEAEKDBED));
		walkTo.PEHELKCIECB();
	}

	public void BMLJMLBEAOO(string emotion)
	{
		PEJFACMBPBN().emotionsController.PIOCPGKDAOF(emotion);
	}

	private void LHEHNNJGINH()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		IDPLNAELIMF(targetWalkTo, endWalkDirection);
	}

	private void FAIKJIICNOI()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.PAHDHACALOH(OEBNHGNJEJL: true);
		}
	}

	public void GEAKPMEBBAI()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(EKGMDIHLEEH().dialogueEvent))
		{
			KCFGPDHELKP().barkDialogue = false;
			KFGKCKCDMLG().mouseUpTrigger = true;
			NHKAFANMEJC().StartConversation(1, HGJMGNJOHGF().dialogueEvent);
			IBEGPMLJIOJ().dialogueEvent = null;
		}
		if (endWalkDirection != 0)
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

	public void EFOEDOJOFEH(string emotion)
	{
		JHMAMLIPBNN().emotionsController.NBFIDOGMLOK(emotion);
	}

	private void OIJCKGLLHKM()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		GIFNIPDANAI(targetWalkTo, endWalkDirection, AMEOKNOLILB: true);
	}

	private void GADMODGCHDM()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.GOACFCOOJLK();
		}
	}

	private void BFGODODJJOD()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		Walk(targetWalkTo, endWalkDirection);
	}

	public void INFOFOAMCAN()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("ActiveDecoMode");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
	}

	public void NLIFFPNNMMG(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		disable = AMEOKNOLILB;
		walkTo.FNNPPBDFBCI(targetWalkTo, AHDHLIECIGH: false, NGAKHGJANLO: false);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(PKCODIDOBJO));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(AHNEAEKDBED));
		walkTo.PEHELKCIECB();
	}

	public void KIMEBNLKFBK()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(ELGNEJNLBNO().dialogueEvent))
		{
			JLNBMNKJCHE().barkDialogue = true;
			ACPHFLBLJAA().mouseUpTrigger = true;
			NHKAFANMEJC().StartConversation(1, DPJEGJBHBNP().dialogueEvent);
			NBKKEINELDN().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)8)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = Direction.Left;
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

	public void LMBJEGLHKBO()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Tavern");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
	}

	public void HNFMJFJPDNN()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(EKGMDIHLEEH().dialogueEvent))
		{
			DPJEGJBHBNP().barkDialogue = false;
			KEJMJMKEEGA().mouseUpTrigger = true;
			ACPHFLBLJAA().StartConversation(1, JHMAMLIPBNN().dialogueEvent);
			NBKKEINELDN().dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Down)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = Direction.Down;
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

	private void FJMBOFEILBN()
	{
		SelectDialogueUI(1);
	}

	public void StartEmotions(string emotion)
	{
		GGFJGHHHEJC.emotionsController.StartEmotion(emotion);
	}

	[SpecialName]
	public static OrwinIINPC KCFGPDHELKP()
	{
		return IADEMLIIDPC;
	}

	public void HFDCAMKIKNL()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Sit");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
		}
	}

	public void NPCLLPAJCGG()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(DPJEGJBHBNP().dialogueEvent))
		{
			ACPHFLBLJAA().barkDialogue = false;
			ELGNEJNLBNO().mouseUpTrigger = true;
			IBEGPMLJIOJ().StartConversation(0, DPJEGJBHBNP().dialogueEvent, FLHBPHPKIML: true);
			ACPHFLBLJAA().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)8)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = (Direction)6;
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

	public void PKIBNCNNDJJ(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		disable = AMEOKNOLILB;
		walkTo.GLHBJNDMIDC(targetWalkTo);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(NHCAPCCBNAL));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(BOOBKGLCDFK));
		walkTo.NOFKEMGPFEO();
	}

	private void CGONFNBEOHF()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.GOACFCOOJLK(OEBNHGNJEJL: true);
		}
	}

	public void MDOEDAKBFKO()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(MOJDNGDNCCO().dialogueEvent))
		{
			NHKAFANMEJC().barkDialogue = true;
			MKIEMMGGFEE().mouseUpTrigger = false;
			JHMAMLIPBNN().StartConversation(0, EKGMDIHLEEH().dialogueEvent, FLHBPHPKIML: true);
			IBEGPMLJIOJ().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)8)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = Direction.Diagonal;
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

	private void ADHFFJDEBMK()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			BLIHMNIAENP();
		}
	}

	private void AHFGOOHOLEL()
	{
		SelectDialogueUI();
	}

	private void BLIHMNIAENP()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.PAHDHACALOH(OEBNHGNJEJL: true);
		}
	}

	private void BOOBKGLCDFK()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		KPOIBPDHLPE(targetWalkTo, endWalkDirection, AMEOKNOLILB: true);
	}

	private void AAOPMDIDFKL()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.GOACFCOOJLK(OEBNHGNJEJL: true);
		}
	}

	private void JDCHPCOKHMJ()
	{
		if (OnlineManager.MasterOrOffline())
		{
			BMOBBJOGBJE();
		}
	}

	private void IFOJNAECHEI()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.GOACFCOOJLK(OEBNHGNJEJL: true);
		}
	}

	public override DialogueNPCBase GetInstance()
	{
		return GGFJGHHHEJC;
	}

	private void FOHGHCPODBJ()
	{
		SelectDialogueUI(1);
	}

	private void BMOBBJOGBJE()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.IIMEFNIECLI(OEBNHGNJEJL: true);
		}
	}

	[SpecialName]
	public static OrwinIINPC KEJMJMKEEGA()
	{
		return IADEMLIIDPC;
	}

	public void IDPLNAELIMF(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
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
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(FEHGALEDJKI));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(GJIJGACIOKK));
		walkTo.EHDKLBLKBEO();
	}

	private void ACOJHBFFFIF()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		Walk(targetWalkTo, endWalkDirection);
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

	public void EDDFAALFNGB()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(NHKAFANMEJC().dialogueEvent))
		{
			HGJMGNJOHGF().barkDialogue = false;
			KFGKCKCDMLG().mouseUpTrigger = true;
			MIGKKKELOJO().StartConversation(0, GGFJGHHHEJC.dialogueEvent);
			OOKBNHMMFON().dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Right)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = (Direction)7;
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
}
