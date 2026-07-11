using System;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class ZuzzuNPC : DialogueNPCBase
{
	private static ZuzzuNPC IADEMLIIDPC;

	public float timeBarks;

	private int HKKKNMIKPCM;

	private string HDFMHCKKJJG = "ZuzzuProgress";

	public static ZuzzuNPC GGFJGHHHEJC => IADEMLIIDPC;

	private void LCNNLMOEOEK()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.GOACFCOOJLK();
		}
	}

	public void BGAPLNMPBFP()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(LFPEPJBNCBF().dialogueEvent))
		{
			JHMAMLIPBNN().barkDialogue = false;
			PNHHCHJCDNM().mouseUpTrigger = false;
			KNLLFEJAMNN().StartConversation(1, KNLLFEJAMNN().dialogueEvent);
			PNHHCHJCDNM().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)8)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = (Direction)6;
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

	private void ELIDAFGHCGG()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.GOACFCOOJLK(OEBNHGNJEJL: true);
		}
	}

	[SpecialName]
	public static ZuzzuNPC DFJGHOHPPEL()
	{
		return IADEMLIIDPC;
	}

	public void FAOEMFNEMGL(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.ClientOnline())
		{
			targetWalkTo = NKIAGIMMHIC;
			endWalkDirection = PFJDGBNBOAM;
			disable = AMEOKNOLILB;
			walkTo.DHFPOCOEONG(targetWalkTo, AHDHLIECIGH: false, NGAKHGJANLO: false);
			walkTo.speed = speed;
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(CEDKNKOPKAH));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(OHDFLHEHING));
			walkTo.EHDKLBLKBEO();
		}
	}

	public void ELBPCLPMHHE(string emotion)
	{
		KNLLFEJAMNN().emotionsController.PIOCPGKDAOF(emotion);
	}

	private void OHDFLHEHING()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		Walk(targetWalkTo, endWalkDirection, AMEOKNOLILB: true);
	}

	private void EEKFONHFOEL()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.BODEPFFAHLE();
		}
	}

	public void GAINAOFIGGH(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.HHDBMDMFEMP())
		{
			targetWalkTo = NKIAGIMMHIC;
			endWalkDirection = PFJDGBNBOAM;
			disable = AMEOKNOLILB;
			walkTo.BDIKOLNFKGD(targetWalkTo);
			walkTo.speed = speed;
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(CNJMNBAKEEK));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(MGCPPABFAGA));
			walkTo.PEHELKCIECB();
		}
	}

	public void OOJEGKJLOED(string emotion)
	{
		KNLLFEJAMNN().emotionsController.StartEmotion(emotion);
	}

	public void MMBHJICBLND(string emotion)
	{
		JFNOOMJMHCB().emotionsController.GPLECKGJFKM(emotion);
	}

	private void KGPOCJEHHHH()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(EENNEGGNHID));
		SelectDialogueUI(1);
	}

	private void PJJMNNCEGIH()
	{
		CheckExclamationSendOnline(sendOnline: false);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(JCFPPJDJOOJ));
	}

	private void FIJOLKBMNCP()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.GOACFCOOJLK(OEBNHGNJEJL: true);
		}
	}

	protected override void Awake()
	{
		base.Awake();
		IADEMLIIDPC = this;
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

	private void EBPMNJKFNMD()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(IBJDMJBFMIO));
		SelectDialogueUI();
	}

	public void OBGLHBFDACO()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(CHKMFEFOFKJ().dialogueEvent))
		{
			AHBBHCKPIIJ().barkDialogue = false;
			GGFJGHHHEJC.mouseUpTrigger = false;
			CHKMFEFOFKJ().StartConversation(0, JHMAMLIPBNN().dialogueEvent, FLHBPHPKIML: true);
			ELGNEJNLBNO().dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Down)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = Direction.Down;
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

	private void KFKJLMOFPMO()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		HBAKBOHEGKA(targetWalkTo, endWalkDirection);
	}

	public override bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if (!playerCanInteract)
		{
			return false;
		}
		return base.IsAvailableByProximity(JIIGOACEIKL);
	}

	private void DMKNBLCAJDB()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		AMOICFMHDCO(targetWalkTo, endWalkDirection);
	}

	public void LAMKDPEEFIN(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.HHDBMDMFEMP())
		{
			targetWalkTo = NKIAGIMMHIC;
			endWalkDirection = PFJDGBNBOAM;
			disable = AMEOKNOLILB;
			walkTo.HELOLJBENMK(targetWalkTo, AHDHLIECIGH: false, NGAKHGJANLO: false);
			walkTo.speed = speed;
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(BEEDFJOOPAH));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(CJJCIBFMPKM));
			walkTo.PEHELKCIECB();
		}
	}

	private void AGFGKHAMAFP()
	{
		CheckExclamationSendOnline(sendOnline: true);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(CBHLNKHLDBG));
	}

	private void BOKOLOCCLEN()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			FFJBIMLEDNK();
		}
	}

	public void OFABJMDGBDM(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.ClientOnline())
		{
			targetWalkTo = NKIAGIMMHIC;
			endWalkDirection = PFJDGBNBOAM;
			disable = AMEOKNOLILB;
			walkTo.GDGGABHLNOH(targetWalkTo, AHDHLIECIGH: false, NGAKHGJANLO: false);
			walkTo.speed = speed;
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(CEDKNKOPKAH));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(OHDFLHEHING));
			walkTo.PEHELKCIECB();
		}
	}

	private void EBNENBFLEKB()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(CBHLNKHLDBG));
		SelectDialogueUI(1);
	}

	private void FixedUpdate()
	{
		if (OnlineManager.MasterOrOffline())
		{
			DIKPOHPGNLG();
		}
	}

	private void OAGCLGKAMFM()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		POCIILOJOJD(targetWalkTo, endWalkDirection, AMEOKNOLILB: true);
	}

	[SpecialName]
	public static ZuzzuNPC DCAEBALADIM()
	{
		return IADEMLIIDPC;
	}

	public void FIKLNLMANCH()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(OPDKAPNDBJE().dialogueEvent))
		{
			LFPEPJBNCBF().barkDialogue = false;
			GGFJGHHHEJC.mouseUpTrigger = false;
			JFNOOMJMHCB().StartConversation(0, FJAMHCAAEAM().dialogueEvent);
			JFNOOMJMHCB().dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Right)
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
				onlineDialogue.APGJMNHJNHN();
			}
		}
		targetWalkTo = Vector2.zero;
	}

	private void AHPNEDOLBII()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			FFJBIMLEDNK();
		}
	}

	public void EDDOIJHPBHM()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(EBAIHKJHCCA().dialogueEvent))
		{
			JHMAMLIPBNN().barkDialogue = true;
			OPDKAPNDBJE().mouseUpTrigger = true;
			JFJOKGAOPHA().StartConversation(0, AHBBHCKPIIJ().dialogueEvent);
			DICHPHEOINO().dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Down)
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
				onlineDialogue.SendDisableContent();
			}
		}
		targetWalkTo = Vector2.zero;
	}

	private void OEMIMEIDMFE()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(HKAKGAFKJEN));
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

	public void CNJMNBAKEEK()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(JFJOKGAOPHA().dialogueEvent))
		{
			DICHPHEOINO().barkDialogue = false;
			LFPEPJBNCBF().mouseUpTrigger = true;
			OAPOJCODNCO().StartConversation(0, EBAIHKJHCCA().dialogueEvent, FLHBPHPKIML: true);
			OPDKAPNDBJE().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)6)
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

	private void DMGEKAGCEKD()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		HBAKBOHEGKA(targetWalkTo, endWalkDirection, AMEOKNOLILB: true);
	}

	public void LAANEEHHDLL(string emotion)
	{
		JFNOOMJMHCB().emotionsController.EMMBEAHMDHE(emotion);
	}

	public void AKCJMLPHFEB(string emotion)
	{
		KNLLFEJAMNN().emotionsController.NMAPMPBAGMM(emotion);
	}

	private void DAEJLBJDEIM()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(JCFPPJDJOOJ));
		SelectDialogueUI();
	}

	private void HHLNBNGGDIF()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		LBCICHLHHJA(targetWalkTo, endWalkDirection, AMEOKNOLILB: true);
	}

	[SpecialName]
	public static ZuzzuNPC AHBBHCKPIIJ()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static ZuzzuNPC CHKMFEFOFKJ()
	{
		return IADEMLIIDPC;
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

	private void ACOJHBFFFIF()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		Walk(targetWalkTo, endWalkDirection);
	}

	private void CCBDFPOONHE()
	{
		CheckExclamationSendOnline(sendOnline: false);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(DJNEMIOEIGI));
	}

	protected override void NJJCCIBDAPM()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		barkDialogue = false;
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		Result variable = DialogueLua.GetVariable("ZuzzuProgress");
		if (((Result)(ref variable)).asInt == 0)
		{
			dialogue.conversation = "TermasInterior/Zuzzu/Intro";
			return;
		}
		if (EventsManager.IsActive(EventsManager.EventType.GoToHotSpring))
		{
			dialogue.conversation = "IrALasTermas/MainEvent";
			return;
		}
		if (EventsManager.IsActive(EventsManager.EventType.PeaceAgreement))
		{
			dialogue.conversation = "PactoDePaz/MainEvent";
			return;
		}
		if (EventsManager.IsActive(EventsManager.EventType.Balance))
		{
			dialogue.conversation = "Balance/MainEvent";
			return;
		}
		if (EventsManager.IsActive(EventsManager.EventType.BathhouseGame))
		{
			dialogue.conversation = "BathhouseGame/Talk";
			return;
		}
		variable = DialogueLua.GetVariable("ZuzzuProgress");
		if (((Result)(ref variable)).asInt > 0)
		{
			dialogue.conversation = "TermasInterior/Zuzzu/Stand";
		}
	}

	private void OMJCAMLBIAO()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.IIMEFNIECLI();
		}
	}

	private void MENCIOFBFIE()
	{
		if (OnlineManager.MasterOrOffline())
		{
			DFIDHEPABOA();
		}
	}

	[SpecialName]
	public static ZuzzuNPC CHPEMJMLDCN()
	{
		return IADEMLIIDPC;
	}

	public void POCIILOJOJD(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.HHDBMDMFEMP())
		{
			targetWalkTo = NKIAGIMMHIC;
			endWalkDirection = PFJDGBNBOAM;
			disable = AMEOKNOLILB;
			walkTo.GDGGABHLNOH(targetWalkTo, AHDHLIECIGH: false);
			walkTo.speed = speed;
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(ABMMONFHFGF));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(CJJCIBFMPKM));
			walkTo.PEHELKCIECB();
		}
	}

	private void NDADMKEDAAK()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GHLINOHHNJE();
		}
	}

	private void LNPFFJBJHJM()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.BODEPFFAHLE(OEBNHGNJEJL: true);
		}
	}

	private void HBBGCIKINDG()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.BODEPFFAHLE();
		}
	}

	private void DFIDHEPABOA()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.PLAGPJAKCKL();
		}
	}

	public void IIEGDHJEEKC()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(OAPOJCODNCO().dialogueEvent))
		{
			CHKMFEFOFKJ().barkDialogue = true;
			OPDKAPNDBJE().mouseUpTrigger = true;
			OAPOJCODNCO().StartConversation(0, OAPOJCODNCO().dialogueEvent, FLHBPHPKIML: true);
			EBAIHKJHCCA().dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Down)
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

	public void NKAMNKDKLHI()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(AHBBHCKPIIJ().dialogueEvent))
		{
			DCAEBALADIM().barkDialogue = true;
			EBAIHKJHCCA().mouseUpTrigger = true;
			JFNOOMJMHCB().StartConversation(0, FJAMHCAAEAM().dialogueEvent, FLHBPHPKIML: true);
			DCAEBALADIM().dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Diagonal)
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

	private void KLDIIKJAKIB()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		GAINAOFIGGH(targetWalkTo, endWalkDirection, AMEOKNOLILB: true);
	}

	public override DialogueNPCBase GetInstance()
	{
		return GGFJGHHHEJC;
	}

	public void KNGKEAPDNLP()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(LFPEPJBNCBF().dialogueEvent))
		{
			JFNOOMJMHCB().barkDialogue = false;
			LFPEPJBNCBF().mouseUpTrigger = true;
			AHBBHCKPIIJ().StartConversation(1, KNLLFEJAMNN().dialogueEvent, FLHBPHPKIML: true);
			DFJGHOHPPEL().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)8)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = Direction.Up;
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

	private void LFNENELHOGJ()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(HKAKGAFKJEN));
		SelectDialogueUI();
	}

	private void HELHNJDFPPF()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(DJNEMIOEIGI));
		SelectDialogueUI(1);
	}

	[SpecialName]
	public static ZuzzuNPC KNLLFEJAMNN()
	{
		return IADEMLIIDPC;
	}

	public void AMOICFMHDCO(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.ClientOnline())
		{
			targetWalkTo = NKIAGIMMHIC;
			endWalkDirection = PFJDGBNBOAM;
			disable = AMEOKNOLILB;
			walkTo.GINPKMBGOFN(targetWalkTo, AHDHLIECIGH: false);
			walkTo.speed = speed;
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(KGLFHLHBFBH));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(GJMOKBGIBEP));
			walkTo.PEHELKCIECB();
		}
	}

	public void EBLFKBEMCKL()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(PNHHCHJCDNM().dialogueEvent))
		{
			DCAEBALADIM().barkDialogue = false;
			JFJOKGAOPHA().mouseUpTrigger = true;
			JFNOOMJMHCB().StartConversation(1, OPDKAPNDBJE().dialogueEvent);
			CHKMFEFOFKJ().dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Right)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = (Direction)8;
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

	public void ONMNKLPNCAH(string emotion)
	{
		CHKMFEFOFKJ().emotionsController.EMMBEAHMDHE(emotion);
	}

	private void BDMEBLBLPIA()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(JCFPPJDJOOJ));
		SelectDialogueUI();
	}

	public void BEEDFJOOPAH()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(DICHPHEOINO().dialogueEvent))
		{
			DCAEBALADIM().barkDialogue = true;
			AHBBHCKPIIJ().mouseUpTrigger = false;
			DFJGHOHPPEL().StartConversation(0, CHKMFEFOFKJ().dialogueEvent, FLHBPHPKIML: true);
			JFJOKGAOPHA().dialogueEvent = null;
		}
		if (endWalkDirection != 0)
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

	private void DJNEMIOEIGI()
	{
		CheckExclamationSendOnline(sendOnline: true);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(CBHLNKHLDBG));
	}

	private void NFNBJANDMCC()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			PEMLFADNKOH();
		}
	}

	private void JGCCFBNHOKD()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.PLAGPJAKCKL(OEBNHGNJEJL: true);
		}
	}

	private void ADGKMLOOMBG()
	{
		CheckExclamationSendOnline(sendOnline: true);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(EBAMOAEABNH));
	}

	private void NFDKGKCANIG()
	{
		CheckExclamationSendOnline(sendOnline: false);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(IBJDMJBFMIO));
	}

	private void LBLJPOEPOMH()
	{
		if (OnlineManager.MasterOrOffline())
		{
			AAOPMDIDFKL();
		}
	}

	private void GJMOKBGIBEP()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		GAINAOFIGGH(targetWalkTo, endWalkDirection, AMEOKNOLILB: true);
	}

	public void APEGJBHIPBF(string emotion)
	{
		DFJGHOHPPEL().emotionsController.PIOCPGKDAOF(emotion);
	}

	public void IGJBOCJNLHB()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(PNHHCHJCDNM().dialogueEvent))
		{
			AHBBHCKPIIJ().barkDialogue = false;
			FJAMHCAAEAM().mouseUpTrigger = false;
			DFJGHOHPPEL().StartConversation(0, AHBBHCKPIIJ().dialogueEvent);
			JFNOOMJMHCB().dialogueEvent = null;
		}
		if (endWalkDirection != 0)
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

	private void DJBKHJFHAHL()
	{
		CheckExclamationSendOnline(sendOnline: false);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(JCFPPJDJOOJ));
	}

	private void FFJBIMLEDNK()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.IIMEFNIECLI();
		}
	}

	public void ELBLAFPCJOL(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.ClientOnline())
		{
			targetWalkTo = NKIAGIMMHIC;
			endWalkDirection = PFJDGBNBOAM;
			disable = AMEOKNOLILB;
			walkTo.GHDMBFOAAHK(targetWalkTo, AHDHLIECIGH: false, NGAKHGJANLO: false);
			walkTo.speed = speed;
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(KNGKEAPDNLP));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(OHDFLHEHING));
			walkTo.PEHELKCIECB();
		}
	}

	public void LPMIHGICGNK()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(JFNOOMJMHCB().dialogueEvent))
		{
			OAPOJCODNCO().barkDialogue = false;
			ELGNEJNLBNO().mouseUpTrigger = true;
			CHPEMJMLDCN().StartConversation(0, DICHPHEOINO().dialogueEvent, FLHBPHPKIML: true);
			JFNOOMJMHCB().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)7)
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
				onlineDialogue.SendDisableContent();
			}
		}
		targetWalkTo = Vector2.zero;
	}

	private void BGENEAOILOF()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(DJBKHJFHAHL));
		SelectDialogueUI(1);
	}

	private void DEFIFMAOPCM()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			DFIDHEPABOA();
		}
	}

	private void IBJDMJBFMIO()
	{
		CheckExclamationSendOnline(sendOnline: true);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(DJNEMIOEIGI));
	}

	public void CPKPKPGNLEO()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(EBAIHKJHCCA().dialogueEvent))
		{
			DFJGHOHPPEL().barkDialogue = false;
			DCAEBALADIM().mouseUpTrigger = true;
			EBAIHKJHCCA().StartConversation(1, DFJGHOHPPEL().dialogueEvent, FLHBPHPKIML: true);
			AHBBHCKPIIJ().dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Left)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = Direction.Up;
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

	[SpecialName]
	public static ZuzzuNPC OAPOJCODNCO()
	{
		return IADEMLIIDPC;
	}

	private void EENAJABELBJ()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			PEMLFADNKOH();
		}
	}

	[SpecialName]
	public static ZuzzuNPC LFPEPJBNCBF()
	{
		return IADEMLIIDPC;
	}

	public void BAPCIPCAEKL(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.HHDBMDMFEMP())
		{
			targetWalkTo = NKIAGIMMHIC;
			endWalkDirection = PFJDGBNBOAM;
			disable = AMEOKNOLILB;
			walkTo.DHFPOCOEONG(targetWalkTo, AHDHLIECIGH: false);
			walkTo.speed = speed;
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(BGAPLNMPBFP));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(KLDIIKJAKIB));
			walkTo.PEHELKCIECB();
		}
	}

	public void IDBCMIMFHJC()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(CHPEMJMLDCN().dialogueEvent))
		{
			ELGNEJNLBNO().barkDialogue = false;
			OPDKAPNDBJE().mouseUpTrigger = true;
			AHBBHCKPIIJ().StartConversation(0, DFJGHOHPPEL().dialogueEvent, FLHBPHPKIML: true);
			JFNOOMJMHCB().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)5)
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

	public void KGLFHLHBFBH()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(DICHPHEOINO().dialogueEvent))
		{
			KNLLFEJAMNN().barkDialogue = true;
			OPDKAPNDBJE().mouseUpTrigger = false;
			ELGNEJNLBNO().StartConversation(0, AHBBHCKPIIJ().dialogueEvent);
			CHKMFEFOFKJ().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)8)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = Direction.Up;
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

	public void HBAKBOHEGKA(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.ClientOnline())
		{
			targetWalkTo = NKIAGIMMHIC;
			endWalkDirection = PFJDGBNBOAM;
			disable = AMEOKNOLILB;
			walkTo.DHFPOCOEONG(targetWalkTo, AHDHLIECIGH: false);
			walkTo.speed = speed;
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(EBLFKBEMCKL));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(MGCPPABFAGA));
			walkTo.NOFKEMGPFEO();
		}
	}

	public void LBCICHLHHJA(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.HHDBMDMFEMP())
		{
			targetWalkTo = NKIAGIMMHIC;
			endWalkDirection = PFJDGBNBOAM;
			disable = AMEOKNOLILB;
			walkTo.GINPKMBGOFN(targetWalkTo, AHDHLIECIGH: true, NGAKHGJANLO: false);
			walkTo.speed = speed;
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(OBGLHBFDACO));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(GJMOKBGIBEP));
			walkTo.EHDKLBLKBEO();
		}
	}

	private void CBHLNKHLDBG()
	{
		CheckExclamationSendOnline(sendOnline: true);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(DJNEMIOEIGI));
	}

	private void IEPLNADMDJL()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		LBCICHLHHJA(targetWalkTo, endWalkDirection, AMEOKNOLILB: true);
	}

	[SpecialName]
	public static ZuzzuNPC JFJOKGAOPHA()
	{
		return IADEMLIIDPC;
	}

	public void PCKFLOPMMNJ(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.ClientOnline())
		{
			targetWalkTo = NKIAGIMMHIC;
			endWalkDirection = PFJDGBNBOAM;
			disable = AMEOKNOLILB;
			walkTo.GHDMBFOAAHK(targetWalkTo, AHDHLIECIGH: false, NGAKHGJANLO: false);
			walkTo.speed = speed;
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(CEDKNKOPKAH));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(OHDFLHEHING));
			walkTo.EHDKLBLKBEO();
		}
	}

	public void DHFOEHFPLNB()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(JFNOOMJMHCB().dialogueEvent))
		{
			CHPEMJMLDCN().barkDialogue = true;
			LFPEPJBNCBF().mouseUpTrigger = true;
			KNLLFEJAMNN().StartConversation(1, OPDKAPNDBJE().dialogueEvent);
			EBAIHKJHCCA().dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Diagonal)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = Direction.Up;
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

	public void DKGKJBJCADE(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.ClientOnline())
		{
			targetWalkTo = NKIAGIMMHIC;
			endWalkDirection = PFJDGBNBOAM;
			disable = AMEOKNOLILB;
			walkTo.GHDMBFOAAHK(targetWalkTo);
			walkTo.speed = speed;
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(BEEDFJOOPAH));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(KLDIIKJAKIB));
			walkTo.EHDKLBLKBEO();
		}
	}

	private void PEMLFADNKOH()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.GOACFCOOJLK(OEBNHGNJEJL: true);
		}
	}

	private void NODDNBFDJGO()
	{
		if (OnlineManager.MasterOrOffline())
		{
			JGCCFBNHOKD();
		}
	}

	private void EBAMOAEABNH()
	{
		CheckExclamationSendOnline(sendOnline: false);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(NFDKGKCANIG));
	}

	private void BDGCFCPFKKE()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(EENNEGGNHID));
		SelectDialogueUI(1);
	}

	public void BLACDDJKJAK(string emotion)
	{
		JFJOKGAOPHA().emotionsController.StartEmotion(emotion);
	}

	public void MONKBNPGGIG(string emotion)
	{
		CHPEMJMLDCN().emotionsController.DCCNJLBLFGI(emotion);
	}

	[SpecialName]
	public static ZuzzuNPC DICHPHEOINO()
	{
		return IADEMLIIDPC;
	}

	public void JEBPGMHDCDC(string emotion)
	{
		JFJOKGAOPHA().emotionsController.NMAPMPBAGMM(emotion);
	}

	private void NBNCMOAPDOG()
	{
		if (OnlineManager.MasterOrOffline())
		{
			JGCCFBNHOKD();
		}
	}

	private void JCFPPJDJOOJ()
	{
		CheckExclamationSendOnline(sendOnline: true);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(EBAMOAEABNH));
	}

	public void LMNGLLCDPIC()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(LFPEPJBNCBF().dialogueEvent))
		{
			JFNOOMJMHCB().barkDialogue = false;
			EBAIHKJHCCA().mouseUpTrigger = true;
			LFPEPJBNCBF().StartConversation(0, DCAEBALADIM().dialogueEvent, FLHBPHPKIML: true);
			DCAEBALADIM().dialogueEvent = null;
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
				onlineDialogue.SendDisableContent();
			}
		}
		targetWalkTo = Vector2.zero;
	}

	private void JIMECFNNKGE()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.BODEPFFAHLE(OEBNHGNJEJL: true);
		}
	}

	private void DNJFFMDDOHH()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		BAPCIPCAEKL(targetWalkTo, endWalkDirection, AMEOKNOLILB: true);
	}

	public void IMHAKACKFGN(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.HHDBMDMFEMP())
		{
			targetWalkTo = NKIAGIMMHIC;
			endWalkDirection = PFJDGBNBOAM;
			disable = AMEOKNOLILB;
			walkTo.CGFMBJFGLAG(targetWalkTo);
			walkTo.speed = speed;
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(KNGKEAPDNLP));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(KLDIIKJAKIB));
			walkTo.PEHELKCIECB();
		}
	}

	public void CKGFIHKADBM()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(JHMAMLIPBNN().dialogueEvent))
		{
			PNHHCHJCDNM().barkDialogue = true;
			PNHHCHJCDNM().mouseUpTrigger = false;
			DICHPHEOINO().StartConversation(0, JFNOOMJMHCB().dialogueEvent, FLHBPHPKIML: true);
			CHKMFEFOFKJ().dialogueEvent = null;
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

	[SpecialName]
	public static ZuzzuNPC ELGNEJNLBNO()
	{
		return IADEMLIIDPC;
	}

	public void Walk(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.ClientOnline())
		{
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

	private void HKAKGAFKJEN()
	{
		CheckExclamationSendOnline(sendOnline: false);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(CCBDFPOONHE));
	}

	private void MGCPPABFAGA()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		Walk(targetWalkTo, endWalkDirection);
	}

	[SpecialName]
	public static ZuzzuNPC JHMAMLIPBNN()
	{
		return IADEMLIIDPC;
	}

	private void BGPGIOMKKAO()
	{
		CheckExclamationSendOnline(sendOnline: false);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(BGPGIOMKKAO));
	}

	public override bool MouseUp(int JIIGOACEIKL)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		if (EventsManager.IsActive(EventsManager.EventType.Balance))
		{
			if (Utils.CIEPGMEEBON(((Component)this).transform.position, 10f))
			{
				return base.MouseUp(JIIGOACEIKL);
			}
			PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark("Player/Bark/Error/NotAllPlayersHere");
			return false;
		}
		return base.MouseUp(JIIGOACEIKL);
	}

	public void NHCAPCCBNAL()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(JHMAMLIPBNN().dialogueEvent))
		{
			JFJOKGAOPHA().barkDialogue = true;
			CHPEMJMLDCN().mouseUpTrigger = true;
			DICHPHEOINO().StartConversation(1, CHKMFEFOFKJ().dialogueEvent);
			JFJOKGAOPHA().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)5)
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

	private void GHLINOHHNJE()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.PAHDHACALOH();
		}
	}

	[SpecialName]
	public static ZuzzuNPC OPDKAPNDBJE()
	{
		return IADEMLIIDPC;
	}

	private void MKMFIJOCEFC()
	{
		if (OnlineManager.MasterOrOffline())
		{
			HOJAIANGLMH();
		}
	}

	public void ABMMONFHFGF()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(KNLLFEJAMNN().dialogueEvent))
		{
			AHBBHCKPIIJ().barkDialogue = false;
			PNHHCHJCDNM().mouseUpTrigger = false;
			JFNOOMJMHCB().StartConversation(0, AHBBHCKPIIJ().dialogueEvent, FLHBPHPKIML: true);
			OPDKAPNDBJE().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)5)
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

	public void KEKPJGNNHAJ(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.ClientOnline())
		{
			targetWalkTo = NKIAGIMMHIC;
			endWalkDirection = PFJDGBNBOAM;
			disable = AMEOKNOLILB;
			walkTo.DHFPOCOEONG(targetWalkTo, AHDHLIECIGH: false);
			walkTo.speed = speed;
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(KNGKEAPDNLP));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(KFKJLMOFPMO));
			walkTo.NOFKEMGPFEO();
		}
	}

	private void EENNEGGNHID()
	{
		CheckExclamationSendOnline(sendOnline: false);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(DJNEMIOEIGI));
	}

	private void Start()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(BGPGIOMKKAO));
		SelectDialogueUI();
	}

	public void NIAHHEDHHLJ(string emotion)
	{
		DCAEBALADIM().emotionsController.EMMBEAHMDHE(emotion);
	}

	private void PAGIAAKPDCE()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(CCBDFPOONHE));
		SelectDialogueUI(1);
	}

	private void JEHIMHBBAOM()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			JIMECFNNKGE();
		}
	}

	public override void CheckExclamationSendOnline(bool sendOnline)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("MainProgress");
		if (((Result)(ref variable)).asInt != 10 || EventsManager.IsDone(EventsManager.EventType.GoToHotSpring))
		{
			variable = DialogueLua.GetVariable("MainProgress");
			if (((Result)(ref variable)).asInt != 12 || EventsManager.IsDone(EventsManager.EventType.PeaceAgreement))
			{
				variable = DialogueLua.GetVariable("MainProgress");
				if (((Result)(ref variable)).asInt == 14 && !EventsManager.IsDone(EventsManager.EventType.BathhouseGame))
				{
					GGFJGHHHEJC.CheckIfNewActivity(OGECKNMAJMI: true, sendOnline, NNDJFLDGKDL: true);
				}
				else
				{
					GGFJGHHHEJC.CheckIfNewActivity(OGECKNMAJMI: false, sendOnline);
				}
				return;
			}
		}
		GGFJGHHHEJC.CheckIfNewActivity(OGECKNMAJMI: true, sendOnline);
	}

	private void HOJAIANGLMH()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.GOACFCOOJLK(OEBNHGNJEJL: true);
		}
	}

	private void HCEDMLJNOBL()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(ADGKMLOOMBG));
		SelectDialogueUI(1);
	}

	[SpecialName]
	public static ZuzzuNPC FJAMHCAAEAM()
	{
		return IADEMLIIDPC;
	}

	private void AAOPMDIDFKL()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.PAHDHACALOH();
		}
	}

	public void StartEmotions(string emotion)
	{
		GGFJGHHHEJC.emotionsController.StartEmotion(emotion);
	}

	public void CEDKNKOPKAH()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(EBAIHKJHCCA().dialogueEvent))
		{
			GGFJGHHHEJC.barkDialogue = true;
			CHKMFEFOFKJ().mouseUpTrigger = true;
			JFNOOMJMHCB().StartConversation(1, GGFJGHHHEJC.dialogueEvent, FLHBPHPKIML: true);
			LFPEPJBNCBF().dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Left)
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
				onlineDialogue.SendDisableContent();
			}
		}
		targetWalkTo = Vector2.zero;
	}

	[SpecialName]
	public static ZuzzuNPC PNHHCHJCDNM()
	{
		return IADEMLIIDPC;
	}

	private void JPHEOLEEAPB()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(NFDKGKCANIG));
		SelectDialogueUI(1);
	}

	private void CJJCIBFMPKM()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		FAOEMFNEMGL(targetWalkTo, endWalkDirection);
	}

	[SpecialName]
	public static ZuzzuNPC JFNOOMJMHCB()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static ZuzzuNPC EBAIHKJHCCA()
	{
		return IADEMLIIDPC;
	}

	public void EEKGHEKNBIM(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.ClientOnline())
		{
			targetWalkTo = NKIAGIMMHIC;
			endWalkDirection = PFJDGBNBOAM;
			disable = AMEOKNOLILB;
			walkTo.BDIKOLNFKGD(targetWalkTo);
			walkTo.speed = speed;
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(IGJBOCJNLHB));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(KFKJLMOFPMO));
			walkTo.NOFKEMGPFEO();
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

	public void GBLFKGMMBDM(string emotion)
	{
		DICHPHEOINO().emotionsController.PIOCPGKDAOF(emotion);
	}
}
