using System;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class PuddingNPC : DialogueNPCBase
{
	private static PuddingNPC IADEMLIIDPC;

	public float timeBarks;

	private int HKKKNMIKPCM;

	private string HDFMHCKKJJG = "";

	public static PuddingNPC GGFJGHHHEJC => IADEMLIIDPC;

	public void GOLAJNDPNKP(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		disable = AMEOKNOLILB;
		walkTo.OGLJDLEGJAA(targetWalkTo);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(BFGEFKOODNA));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(HEADJCFMKIP));
		walkTo.NOFKEMGPFEO();
	}

	private void PLHEHGHFCJI()
	{
		SelectDialogueUI();
	}

	[SpecialName]
	public static PuddingNPC MAIDHAPANEB()
	{
		return IADEMLIIDPC;
	}

	protected override void Awake()
	{
		base.Awake();
		IADEMLIIDPC = this;
	}

	private void IDHCFOCEPMD()
	{
		SelectDialogueUI(1);
	}

	private void KINLOEAPDED()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.PLAGPJAKCKL(OEBNHGNJEJL: true);
		}
	}

	public void EBLEAJFOEJL()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(MPJJAPCFENH().dialogueEvent))
		{
			JFNOOMJMHCB().barkDialogue = false;
			MPJJAPCFENH().mouseUpTrigger = true;
			HGJMGNJOHGF().StartConversation(1, HGJMGNJOHGF().dialogueEvent, FLHBPHPKIML: true);
			JHMAMLIPBNN().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)7)
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

	private void EAMJMLCDGPF()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.GOACFCOOJLK();
		}
	}

	private void GOEFOAKFDDD()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		BLDPKJOMJOK(targetWalkTo, endWalkDirection);
	}

	private void NBOMJAKJNIK()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		Walk(targetWalkTo, endWalkDirection, AMEOKNOLILB: true);
	}

	public void EKEONJEIGPP(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
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
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(KBCKFDDDEGE));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(NBOMJAKJNIK));
		walkTo.NOFKEMGPFEO();
	}

	public void EFINHBLBFOI(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
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
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(EBLEAJFOEJL));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(AEEANHACPGH));
		walkTo.PEHELKCIECB();
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

	[SpecialName]
	public static PuddingNPC MPJJAPCFENH()
	{
		return IADEMLIIDPC;
	}

	public void ABCLGBAJPIK(string emotion)
	{
		CHKMFEFOFKJ().emotionsController.NBFIDOGMLOK(emotion);
	}

	protected override void NJJCCIBDAPM()
	{
		barkDialogue = false;
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		if (EventsManager.IsActive(EventsManager.EventType.ThroneRoom))
		{
			dialogue.conversation = "SalonDelTrono/PuddingTalk";
		}
	}

	private void HFLCAILNOHC()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		GOLAJNDPNKP(targetWalkTo, endWalkDirection);
	}

	public void GDEEGJFFBKN(string emotion)
	{
		LDBJELPPBAI().emotionsController.DCCNJLBLFGI(emotion);
	}

	[SpecialName]
	public static PuddingNPC HGJMGNJOHGF()
	{
		return IADEMLIIDPC;
	}

	public void KIDDNGOMMJH(string emotion)
	{
		LDBJELPPBAI().emotionsController.GPLECKGJFKM(emotion);
	}

	public void LGGHJHKCDGA()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("R1");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
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
		walkTo.DHFPOCOEONG(targetWalkTo, AHDHLIECIGH: true, NGAKHGJANLO: false);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(JLJEFENEFMG));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(NBOMJAKJNIK));
		walkTo.NOFKEMGPFEO();
	}

	private void AAOPMDIDFKL()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.BODEPFFAHLE();
		}
	}

	public void IFJKPCMEBLI(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
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
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(OnActionComplete));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(EHNACEHHOJK));
		walkTo.EHDKLBLKBEO();
	}

	public void LGMDDMFKIAD(string emotion)
	{
		MPJJAPCFENH().emotionsController.StartEmotion(emotion);
	}

	private void ACOJHBFFFIF()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		Walk(targetWalkTo, endWalkDirection);
	}

	private void OFHGMEMFGCI()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.PAHDHACALOH();
		}
	}

	public void FNJODLOADKA()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(CHKMFEFOFKJ().dialogueEvent))
		{
			MPFJOKOJIOO().barkDialogue = true;
			JFNOOMJMHCB().mouseUpTrigger = false;
			BNDNMBGJEKP().StartConversation(1, GGFJGHHHEJC.dialogueEvent, FLHBPHPKIML: true);
			DBJCACLEFGK().dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Diagonal)
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

	private void GBDAMMFCECP()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		ELKEAKGFAEB(targetWalkTo, endWalkDirection, AMEOKNOLILB: true);
	}

	public void PIGEJKHGCNA(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		disable = AMEOKNOLILB;
		walkTo.BDIKOLNFKGD(targetWalkTo);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(FEHGALEDJKI));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(EHNACEHHOJK));
		walkTo.EHDKLBLKBEO();
	}

	public void StartEmotions(string emotion)
	{
		GGFJGHHHEJC.emotionsController.StartEmotion(emotion);
	}

	private void MBLOIGIMANG()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.PAHDHACALOH();
		}
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

	private void EGACIHOKJLH()
	{
		SelectDialogueUI(1);
	}

	[SpecialName]
	public static PuddingNPC LDBJELPPBAI()
	{
		return IADEMLIIDPC;
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

	[SpecialName]
	public static PuddingNPC HFIJHDBKCIA()
	{
		return IADEMLIIDPC;
	}

	public void FABLJFLFDJA()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("ReceiveFishInfo");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
	}

	public void HCCFPBJNLKC(string emotion)
	{
		JFNOOMJMHCB().emotionsController.NBFIDOGMLOK(emotion);
	}

	private void MMEPKPBACMO()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.PLAGPJAKCKL(OEBNHGNJEJL: true);
		}
	}

	private void ODJPLNDJKEA()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			KABNPECIBCP();
		}
	}

	public void PPHJFALMJEG()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Need to learn previous XP increase!");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
	}

	[SpecialName]
	public static PuddingNPC JHMAMLIPBNN()
	{
		return IADEMLIIDPC;
	}

	private void GJGMDNEKAEG()
	{
		if (OnlineManager.MasterOrOffline())
		{
			MBLOIGIMANG();
		}
	}

	private void JMBOINMJEGI()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		DMIHGCBJBKG(targetWalkTo, endWalkDirection);
	}

	public void JLJEFENEFMG()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(BNDNMBGJEKP().dialogueEvent))
		{
			MAIDHAPANEB().barkDialogue = false;
			LDBJELPPBAI().mouseUpTrigger = true;
			HFIJHDBKCIA().StartConversation(1, LDBJELPPBAI().dialogueEvent);
			MAIDHAPANEB().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)7)
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
				onlineDialogue.SendDisableContent();
			}
		}
		targetWalkTo = Vector2.zero;
	}

	private void CHMHMGACCNH()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.PAHDHACALOH(OEBNHGNJEJL: true);
		}
	}

	private void NDNBDEHFFJF()
	{
		SelectDialogueUI();
	}

	private void HEADJCFMKIP()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		FAOEMFNEMGL(targetWalkTo, endWalkDirection);
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

	public void HNCEGJIJEOA()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("itemAleYeast");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
	}

	private void FFJBIMLEDNK()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.IIMEFNIECLI(OEBNHGNJEJL: true);
		}
	}

	[SpecialName]
	public static PuddingNPC MPFJOKOJIOO()
	{
		return IADEMLIIDPC;
	}

	protected override void OnConversationStart(Transform actor)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		base.OnConversationStart(actor);
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		HKKKNMIKPCM = ((Result)(ref variable)).asInt;
	}

	private void EEKFONHFOEL()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.IIMEFNIECLI();
		}
	}

	private void KAOLCOJBFCE()
	{
		if (OnlineManager.MasterOrOffline())
		{
			AAOPMDIDFKL();
		}
	}

	private void JMCJFCPCDKL()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			EAMJMLCDGPF();
		}
	}

	private void EBBAPFKABDB()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		ELKEAKGFAEB(targetWalkTo, endWalkDirection);
	}

	private void PGJJBPALEGM()
	{
		SelectDialogueUI();
	}

	private void HCDCOLFOKDB()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		PIGEJKHGCNA(targetWalkTo, endWalkDirection);
	}

	private void ECGANLCHOEK()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.GOACFCOOJLK(OEBNHGNJEJL: true);
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
		walkTo.GDGGABHLNOH(targetWalkTo, AHDHLIECIGH: false);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(FEHGALEDJKI));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(HFLCAILNOHC));
		walkTo.EHDKLBLKBEO();
	}

	private void CAOKPIIFHBJ()
	{
		SelectDialogueUI(1);
	}

	public override DialogueNPCBase GetInstance()
	{
		return GGFJGHHHEJC;
	}

	private void OIJCKGLLHKM()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		EFINHBLBFOI(targetWalkTo, endWalkDirection);
	}

	public void GLJBJIIMAMO()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("MainProgress");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
		}
	}

	private void AHIPEAEMEAF()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.PAHDHACALOH(OEBNHGNJEJL: true);
		}
	}

	public void MKJDIMFOGIA()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(LDBJELPPBAI().dialogueEvent))
		{
			JFNOOMJMHCB().barkDialogue = false;
			JHMAMLIPBNN().mouseUpTrigger = true;
			KFGKCKCDMLG().StartConversation(0, MPFJOKOJIOO().dialogueEvent, FLHBPHPKIML: true);
			LDBJELPPBAI().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)8)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = Direction.Left;
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

	public void FAOEMFNEMGL(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		disable = AMEOKNOLILB;
		walkTo.KBEENHPEOAB(targetWalkTo, AHDHLIECIGH: true, NGAKHGJANLO: false);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(OnActionComplete));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(AEEANHACPGH));
		walkTo.EHDKLBLKBEO();
	}

	private void EAEKKBEJMFC()
	{
		SelectDialogueUI();
	}

	private void IEPLNADMDJL()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		IFJKPCMEBLI(targetWalkTo, endWalkDirection, AMEOKNOLILB: true);
	}

	public void ANLDJEOCBEH()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Destroying tree at same position: ");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
		}
	}

	private void OAGCLGKAMFM()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		DMIHGCBJBKG(targetWalkTo, endWalkDirection, AMEOKNOLILB: true);
	}

	private void MPLHFJGFKJD()
	{
		if (OnlineManager.MasterOrOffline())
		{
			OFHGMEMFGCI();
		}
	}

	[SpecialName]
	public static PuddingNPC BNDNMBGJEKP()
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

	private void Start()
	{
		SelectDialogueUI();
	}

	private void JMLDAJEFMPE()
	{
		if (OnlineManager.MasterOrOffline())
		{
			DIKPOHPGNLG();
		}
	}

	private void HCEFCPBOEBP()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.GOACFCOOJLK();
		}
	}

	private void HCEDMLJNOBL()
	{
		SelectDialogueUI(1);
	}

	private void EHNACEHHOJK()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		DMIHGCBJBKG(targetWalkTo, endWalkDirection, AMEOKNOLILB: true);
	}

	private void CMELEOKAEHO()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		BLDPKJOMJOK(targetWalkTo, endWalkDirection, AMEOKNOLILB: true);
	}

	private void GHPFCKGMLDA()
	{
		SelectDialogueUI(1);
	}

	private void GNMMELIJKML()
	{
		SelectDialogueUI(1);
	}

	private void KABNPECIBCP()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.PAHDHACALOH(OEBNHGNJEJL: true);
		}
	}

	private void DJHLPCMMFPO()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.PLAGPJAKCKL();
		}
	}

	public void HACNKBFKNHH()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(HFIJHDBKCIA().dialogueEvent))
		{
			MPJJAPCFENH().barkDialogue = false;
			MPJJAPCFENH().mouseUpTrigger = true;
			BNDNMBGJEKP().StartConversation(0, BNDNMBGJEKP().dialogueEvent, FLHBPHPKIML: true);
			MPFJOKOJIOO().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)5)
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

	public void FEHGALEDJKI()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(JFNOOMJMHCB().dialogueEvent))
		{
			CHKMFEFOFKJ().barkDialogue = false;
			CHKMFEFOFKJ().mouseUpTrigger = false;
			MAIDHAPANEB().StartConversation(1, GGFJGHHHEJC.dialogueEvent, FLHBPHPKIML: true);
			DBJCACLEFGK().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)5)
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
				onlineDialogue.APGJMNHJNHN();
			}
		}
		targetWalkTo = Vector2.zero;
	}

	public void ELKEAKGFAEB(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		disable = AMEOKNOLILB;
		walkTo.CGFMBJFGLAG(targetWalkTo, AHDHLIECIGH: false);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(OnActionComplete));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(NBOMJAKJNIK));
		walkTo.NOFKEMGPFEO();
	}

	private void NJDHHOOGDFI()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		EKEONJEIGPP(targetWalkTo, endWalkDirection);
	}

	public void BFGEFKOODNA()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(MPJJAPCFENH().dialogueEvent))
		{
			DBJCACLEFGK().barkDialogue = true;
			HFIJHDBKCIA().mouseUpTrigger = true;
			HFIJHDBKCIA().StartConversation(1, DBJCACLEFGK().dialogueEvent);
			HFIJHDBKCIA().dialogueEvent = null;
		}
		if (endWalkDirection != 0)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = Direction.Down;
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

	public void ELBLAFPCJOL(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		disable = AMEOKNOLILB;
		walkTo.EJPGFOEDPBG(targetWalkTo, AHDHLIECIGH: true, NGAKHGJANLO: false);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(HACNKBFKNHH));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(MJDFKJBFMPO));
		walkTo.NOFKEMGPFEO();
	}

	public void IPHEMGPMIDI()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Collect");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
	}

	public void IHNKBFNNAML()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("CannotToggleUI IsActioningTool ");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		}
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

	private void NDGFPPOBCNP()
	{
		SelectDialogueUI();
	}

	public void IHIDJOEEMBK()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Spawn");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
	}

	public void GFLNGGGPGCF()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(MPFJOKOJIOO().dialogueEvent))
		{
			MAIDHAPANEB().barkDialogue = false;
			DBJCACLEFGK().mouseUpTrigger = true;
			JFNOOMJMHCB().StartConversation(1, GGFJGHHHEJC.dialogueEvent, FLHBPHPKIML: true);
			DBJCACLEFGK().dialogueEvent = null;
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

	private void GHDIABALHLP()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.GOACFCOOJLK(OEBNHGNJEJL: true);
		}
	}

	[SpecialName]
	public static PuddingNPC JFNOOMJMHCB()
	{
		return IADEMLIIDPC;
	}

	private void PBFGFECPPPO()
	{
		SelectDialogueUI(1);
	}

	private void JEJGIAPPCLG()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		FAOEMFNEMGL(targetWalkTo, endWalkDirection);
	}

	public void BEECLHMOEIP(string emotion)
	{
		BNDNMBGJEKP().emotionsController.DCCNJLBLFGI(emotion);
	}

	private void OIAHJHNPPCO()
	{
		SelectDialogueUI(1);
	}

	[SpecialName]
	public static PuddingNPC CHKMFEFOFKJ()
	{
		return IADEMLIIDPC;
	}

	public void KBCKFDDDEGE()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(JFNOOMJMHCB().dialogueEvent))
		{
			CHKMFEFOFKJ().barkDialogue = false;
			GGFJGHHHEJC.mouseUpTrigger = false;
			DBJCACLEFGK().StartConversation(1, DBJCACLEFGK().dialogueEvent, FLHBPHPKIML: true);
			DBJCACLEFGK().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)6)
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
				onlineDialogue.SendDisableContent();
			}
		}
		targetWalkTo = Vector2.zero;
	}

	private void MJDFKJBFMPO()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		EFINHBLBFOI(targetWalkTo, endWalkDirection);
	}

	[SpecialName]
	public static PuddingNPC KFGKCKCDMLG()
	{
		return IADEMLIIDPC;
	}

	public void HNMMHJOFBGB(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
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
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(BFGEFKOODNA));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(GOEFOAKFDDD));
		walkTo.EHDKLBLKBEO();
	}

	[SpecialName]
	public static PuddingNPC DBJCACLEFGK()
	{
		return IADEMLIIDPC;
	}

	public void BDLLGEDIHPA(string emotion)
	{
		JHMAMLIPBNN().emotionsController.DCCNJLBLFGI(emotion);
	}

	private void HAHFKJCIPKH()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			DIKPOHPGNLG();
		}
	}

	private void OKAPGNGLOHO()
	{
		SelectDialogueUI(1);
	}

	private void AEEANHACPGH()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		GOLAJNDPNKP(targetWalkTo, endWalkDirection);
	}

	public void DMIHGCBJBKG(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
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
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(MKJDIMFOGIA));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(NJDHHOOGDFI));
		walkTo.PEHELKCIECB();
	}

	private void NLOEGNNLKKE()
	{
		if (OnlineManager.MasterOrOffline())
		{
			KABNPECIBCP();
		}
	}
}
