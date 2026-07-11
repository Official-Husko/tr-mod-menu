using System;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class RinNPC : DialogueNPCBase
{
	private static RinNPC IADEMLIIDPC;

	public float timeBarks;

	private int HKKKNMIKPCM;

	private string HDFMHCKKJJG = "RinProgress";

	public static RinNPC GGFJGHHHEJC => IADEMLIIDPC;

	protected override void OnConversationStart(Transform actor)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		base.OnConversationStart(actor);
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		HKKKNMIKPCM = ((Result)(ref variable)).asInt;
	}

	public void ACMMENIGKLK(string emotion)
	{
		KNLLFEJAMNN().emotionsController.DCCNJLBLFGI(emotion);
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

	public override DialogueNPCBase GetInstance()
	{
		return GGFJGHHHEJC;
	}

	private void GAEDNJMJDJD()
	{
		if (OnlineManager.MasterOrOffline())
		{
			EEKFONHFOEL();
		}
	}

	public void FFDDJNEHKBC()
	{
	}

	private void INNIKIJEMAO()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		APLNODFEIGF(targetWalkTo, endWalkDirection, AMEOKNOLILB: true);
	}

	private void OIJCKGLLHKM()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		APLNODFEIGF(targetWalkTo, endWalkDirection);
	}

	public void EFNENNELAKM(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.HHDBMDMFEMP())
		{
			targetWalkTo = NKIAGIMMHIC;
			endWalkDirection = PFJDGBNBOAM;
			disable = AMEOKNOLILB;
			walkTo.JJDCANFBFMK(targetWalkTo, AHDHLIECIGH: false);
			walkTo.speed = speed;
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(OKHDMEMEIEJ));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(EIOKFNLDEEB));
			walkTo.NOFKEMGPFEO();
		}
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

	[SpecialName]
	public static RinNPC AFFGPMFKEFH()
	{
		return IADEMLIIDPC;
	}

	public void AGLOLKAIAMG()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(BNBMNOMFFBE().dialogueEvent))
		{
			ABHIDHPMLLD().barkDialogue = false;
			OJJDNLEFNPJ().mouseUpTrigger = false;
			POAGAIBEFBF().StartConversation(0, OJJDNLEFNPJ().dialogueEvent, FLHBPHPKIML: true);
			OJJDNLEFNPJ().dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Diagonal)
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

	public void CEDKNKOPKAH()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(EBAIHKJHCCA().dialogueEvent))
		{
			OJJDNLEFNPJ().barkDialogue = true;
			KNLLFEJAMNN().mouseUpTrigger = false;
			GGFJGHHHEJC.StartConversation(0, POAGAIBEFBF().dialogueEvent);
			OPILDPFDFKJ().dialogueEvent = null;
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

	private void PGJLFLKDLAE()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			AAOPMDIDFKL();
		}
	}

	public void OIFAGKBHCAP(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.ClientOnline())
		{
			targetWalkTo = NKIAGIMMHIC;
			endWalkDirection = PFJDGBNBOAM;
			disable = AMEOKNOLILB;
			walkTo.OGLJDLEGJAA(targetWalkTo, AHDHLIECIGH: true, NGAKHGJANLO: false);
			walkTo.speed = speed;
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(KBCKFDDDEGE));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(JMBOINMJEGI));
			walkTo.EHDKLBLKBEO();
		}
	}

	private void ACLOFACNPDP()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		PIFFBOOAMED(targetWalkTo, endWalkDirection);
	}

	private void LANGHIOBJIH()
	{
		SelectDialogueUI(1);
	}

	public void KBCKFDDDEGE()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(POAGAIBEFBF().dialogueEvent))
		{
			ABHIDHPMLLD().barkDialogue = false;
			GGFJGHHHEJC.mouseUpTrigger = false;
			EBAIHKJHCCA().StartConversation(0, KNLLFEJAMNN().dialogueEvent, FLHBPHPKIML: true);
			BNBMNOMFFBE().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)6)
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

	private void OKAPGNGLOHO()
	{
		SelectDialogueUI(1);
	}

	public void StartEmotions(string emotion)
	{
		GGFJGHHHEJC.emotionsController.StartEmotion(emotion);
	}

	private void HNEGFBCKIIJ()
	{
		SelectDialogueUI();
	}

	public void HBEPDNOMENA(string emotion)
	{
		GGFJGHHHEJC.emotionsController.GPLECKGJFKM(emotion);
	}

	private void PGGHHNCDBFC()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		MBGBGAIMAFD(targetWalkTo, endWalkDirection, AMEOKNOLILB: true);
	}

	[SpecialName]
	public static RinNPC ABHIDHPMLLD()
	{
		return IADEMLIIDPC;
	}

	public void FJNPFILECCM()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(OPILDPFDFKJ().dialogueEvent))
		{
			BNBMNOMFFBE().barkDialogue = true;
			AFFGPMFKEFH().mouseUpTrigger = false;
			AFFGPMFKEFH().StartConversation(0, OJJDNLEFNPJ().dialogueEvent, FLHBPHPKIML: true);
			OPILDPFDFKJ().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)8)
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

	public void MCEJEEJFDKB(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.ClientOnline())
		{
			targetWalkTo = NKIAGIMMHIC;
			endWalkDirection = PFJDGBNBOAM;
			disable = AMEOKNOLILB;
			walkTo.GLHBJNDMIDC(targetWalkTo, AHDHLIECIGH: true, NGAKHGJANLO: false);
			walkTo.speed = speed;
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(APGLLOHDPHO));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(BHKLMNJGLFN));
			walkTo.EHDKLBLKBEO();
		}
	}

	public void NPCLLPAJCGG()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(OJJDNLEFNPJ().dialogueEvent))
		{
			OPILDPFDFKJ().barkDialogue = false;
			POAGAIBEFBF().mouseUpTrigger = false;
			EBAIHKJHCCA().StartConversation(1, OPILDPFDFKJ().dialogueEvent, FLHBPHPKIML: true);
			KNLLFEJAMNN().dialogueEvent = null;
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

	private void COACILFOCEK()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.GOACFCOOJLK(OEBNHGNJEJL: true);
		}
	}

	public void ONIGIICJBNH()
	{
	}

	private void ACOJHBFFFIF()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		Walk(targetWalkTo, endWalkDirection);
	}

	private void NNBIAIMPNGL()
	{
		SelectDialogueUI();
	}

	private void MKLIAMJFHOF()
	{
		SelectDialogueUI(1);
	}

	public void EICNDMGMPLE(string emotion)
	{
		BNBMNOMFFBE().emotionsController.PIOCPGKDAOF(emotion);
	}

	public void HBAKBOHEGKA(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.HHDBMDMFEMP())
		{
			targetWalkTo = NKIAGIMMHIC;
			endWalkDirection = PFJDGBNBOAM;
			disable = AMEOKNOLILB;
			walkTo.GLHBJNDMIDC(targetWalkTo, AHDHLIECIGH: false);
			walkTo.speed = speed;
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(NPCLLPAJCGG));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(BHKLMNJGLFN));
			walkTo.EHDKLBLKBEO();
		}
	}

	private void EIOFKDODGKK()
	{
		if (OnlineManager.MasterOrOffline())
		{
			MFDJLGHGEJH();
		}
	}

	public void MBGBGAIMAFD(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
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
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(FJNPFILECCM));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(GMFONHHLBIO));
			walkTo.EHDKLBLKBEO();
		}
	}

	public void PJGJGBEADMB(string emotion)
	{
		OJJDNLEFNPJ().emotionsController.NBFIDOGMLOK(emotion);
	}

	private void IGNLHLAAMMN()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GHLINOHHNJE();
		}
	}

	public void FABLJFLFDJA()
	{
	}

	private void IBIHOAPEONB()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		OIFAGKBHCAP(targetWalkTo, endWalkDirection);
	}

	public void BGHNKPEDCBH()
	{
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

	public void FPKLJCGJBPL(string emotion)
	{
		OPILDPFDFKJ().emotionsController.DCCNJLBLFGI(emotion);
	}

	public void JMNHCFPKOCH()
	{
	}

	public void CAAIEPEHFDI(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.HHDBMDMFEMP())
		{
			targetWalkTo = NKIAGIMMHIC;
			endWalkDirection = PFJDGBNBOAM;
			disable = AMEOKNOLILB;
			walkTo.GHDMBFOAAHK(targetWalkTo, AHDHLIECIGH: true, NGAKHGJANLO: false);
			walkTo.speed = speed;
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(FJNPFILECCM));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(HKGKJCOKLLD));
			walkTo.NOFKEMGPFEO();
		}
	}

	public void APLNODFEIGF(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.HHDBMDMFEMP())
		{
			targetWalkTo = NKIAGIMMHIC;
			endWalkDirection = PFJDGBNBOAM;
			disable = AMEOKNOLILB;
			walkTo.BDIKOLNFKGD(targetWalkTo, AHDHLIECIGH: false, NGAKHGJANLO: false);
			walkTo.speed = speed;
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(GBDLGKNDBIK));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(PGGHHNCDBFC));
			walkTo.NOFKEMGPFEO();
		}
	}

	private void Start()
	{
		SelectDialogueUI();
	}

	public void CAEDALACKDD()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(POAGAIBEFBF().dialogueEvent))
		{
			OJJDNLEFNPJ().barkDialogue = true;
			OJJDNLEFNPJ().mouseUpTrigger = true;
			BNBMNOMFFBE().StartConversation(0, AFFGPMFKEFH().dialogueEvent);
			POAGAIBEFBF().dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Left)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = (Direction)7;
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

	private void IDHCFOCEPMD()
	{
		SelectDialogueUI();
	}

	public void PFFAJBLGFDO(string emotion)
	{
		OJJDNLEFNPJ().emotionsController.EMMBEAHMDHE(emotion);
	}

	private void GOEGBOEMHLI()
	{
		SelectDialogueUI(1);
	}

	protected override void Awake()
	{
		base.Awake();
		IADEMLIIDPC = this;
	}

	private void IFHLGOMBACP()
	{
		SelectDialogueUI();
	}

	private void DJHLPCMMFPO()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.BODEPFFAHLE();
		}
	}

	private void OIAHJHNPPCO()
	{
		SelectDialogueUI(1);
	}

	private void FixedUpdate()
	{
		if (OnlineManager.MasterOrOffline())
		{
			DIKPOHPGNLG();
		}
	}

	private void EIOKFNLDEEB()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		CAAIEPEHFDI(targetWalkTo, endWalkDirection);
	}

	public void KIOMHEIDHFN(string emotion)
	{
		OPILDPFDFKJ().emotionsController.PIOCPGKDAOF(emotion);
	}

	public void OKHDMEMEIEJ()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(POAGAIBEFBF().dialogueEvent))
		{
			OJJDNLEFNPJ().barkDialogue = true;
			BNBMNOMFFBE().mouseUpTrigger = false;
			KNLLFEJAMNN().StartConversation(1, AFFGPMFKEFH().dialogueEvent, FLHBPHPKIML: true);
			AFFGPMFKEFH().dialogueEvent = null;
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

	[SpecialName]
	public static RinNPC BNBMNOMFFBE()
	{
		return IADEMLIIDPC;
	}

	private void DOHLOJOIHFO()
	{
		SelectDialogueUI();
	}

	public void PIFFBOOAMED(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
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
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(FJNPFILECCM));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(OIJCKGLLHKM));
			walkTo.EHDKLBLKBEO();
		}
	}

	private void JMBOINMJEGI()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		OIFAGKBHCAP(targetWalkTo, endWalkDirection);
	}

	[SpecialName]
	public static RinNPC EBAIHKJHCCA()
	{
		return IADEMLIIDPC;
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

	public void EEPJLOBNIMM()
	{
	}

	public void CJMLIEFAPKE()
	{
	}

	public new void CheckExclamation()
	{
	}

	private void HKGKJCOKLLD()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		MCEJEEJFDKB(targetWalkTo, endWalkDirection, AMEOKNOLILB: true);
	}

	public void LDDOONCCFHN()
	{
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

	public void GACCDKPCDMP(string emotion)
	{
		KNLLFEJAMNN().emotionsController.GPLECKGJFKM(emotion);
	}

	private void OHJIFGGCDAN()
	{
		if (OnlineManager.MasterOrOffline())
		{
			DPHMBAIBFJB();
		}
	}

	private void ALEEFHFLAIK()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		EEKGHEKNBIM(targetWalkTo, endWalkDirection, AMEOKNOLILB: true);
	}

	private void LBLJPOEPOMH()
	{
		if (OnlineManager.MasterOrOffline())
		{
			AAOPMDIDFKL();
		}
	}

	public void GBDLGKNDBIK()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(ABHIDHPMLLD().dialogueEvent))
		{
			OJJDNLEFNPJ().barkDialogue = true;
			GGFJGHHHEJC.mouseUpTrigger = true;
			BNBMNOMFFBE().StartConversation(1, ABHIDHPMLLD().dialogueEvent, FLHBPHPKIML: true);
			AFFGPMFKEFH().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)6)
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
				onlineDialogue.APGJMNHJNHN();
			}
		}
		targetWalkTo = Vector2.zero;
	}

	private void GMFONHHLBIO()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		HBAKBOHEGKA(targetWalkTo, endWalkDirection);
	}

	[SpecialName]
	public static RinNPC OJJDNLEFNPJ()
	{
		return IADEMLIIDPC;
	}

	private void EEKFONHFOEL()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.BODEPFFAHLE(OEBNHGNJEJL: true);
		}
	}

	private void BABJAGOPCOA()
	{
		if (OnlineManager.MasterOrOffline())
		{
			DPHMBAIBFJB();
		}
	}

	[SpecialName]
	public static RinNPC OPILDPFDFKJ()
	{
		return IADEMLIIDPC;
	}

	private void IAAGKLPMAMK()
	{
		SelectDialogueUI();
	}

	private void IMIONHLAKIH()
	{
		SelectDialogueUI();
	}

	public void NDJEJLOECNE()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(GGFJGHHHEJC.dialogueEvent))
		{
			EBAIHKJHCCA().barkDialogue = false;
			GGFJGHHHEJC.mouseUpTrigger = false;
			POAGAIBEFBF().StartConversation(0, BNBMNOMFFBE().dialogueEvent, FLHBPHPKIML: true);
			AFFGPMFKEFH().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)7)
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

	[SpecialName]
	public static RinNPC KNLLFEJAMNN()
	{
		return IADEMLIIDPC;
	}

	private void NFABFPFLNEE()
	{
		SelectDialogueUI(1);
	}

	public void LACDAMFANIM()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(ABHIDHPMLLD().dialogueEvent))
		{
			BNBMNOMFFBE().barkDialogue = false;
			BNBMNOMFFBE().mouseUpTrigger = false;
			AFFGPMFKEFH().StartConversation(0, ABHIDHPMLLD().dialogueEvent);
			OJJDNLEFNPJ().dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Right)
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
				onlineDialogue.SendDisableContent();
			}
		}
		targetWalkTo = Vector2.zero;
	}

	private void BHKLMNJGLFN()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		APLNODFEIGF(targetWalkTo, endWalkDirection, AMEOKNOLILB: true);
	}

	private void CNHEMKHJPPN()
	{
		if (OnlineManager.MasterOrOffline())
		{
			DPHMBAIBFJB();
		}
	}

	private void HPIMHEMJMAA()
	{
		SelectDialogueUI();
	}

	private void DPHMBAIBFJB()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.GOACFCOOJLK(OEBNHGNJEJL: true);
		}
	}

	[SpecialName]
	public static RinNPC POAGAIBEFBF()
	{
		return IADEMLIIDPC;
	}

	private void KLHAAFJOOMC()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			DJHLPCMMFPO();
		}
	}

	private void GHLINOHHNJE()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.IIMEFNIECLI(OEBNHGNJEJL: true);
		}
	}

	public void MKIONOKDHPA(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
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
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(OnActionComplete));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(ALEEFHFLAIK));
			walkTo.NOFKEMGPFEO();
		}
	}

	public void APGLLOHDPHO()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(OJJDNLEFNPJ().dialogueEvent))
		{
			AFFGPMFKEFH().barkDialogue = false;
			OPILDPFDFKJ().mouseUpTrigger = false;
			ABHIDHPMLLD().StartConversation(1, GGFJGHHHEJC.dialogueEvent, FLHBPHPKIML: true);
			ABHIDHPMLLD().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)5)
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

	private void PPBLPFDOBGD()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		MCEJEEJFDKB(targetWalkTo, endWalkDirection);
	}

	private void ADJMGPNBDGF()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			GHLINOHHNJE();
		}
	}

	private void MFDJLGHGEJH()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.GOACFCOOJLK(OEBNHGNJEJL: true);
		}
	}

	private void GONBDDJHANF()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		EFNENNELAKM(targetWalkTo, endWalkDirection, AMEOKNOLILB: true);
	}

	public void IPHEMGPMIDI()
	{
	}

	private void EJJKCAPPKLL()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			COACILFOCEK();
		}
	}

	private void DEFIFMAOPCM()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			DIKPOHPGNLG();
		}
	}

	private void BNIKICAEIND()
	{
		SelectDialogueUI();
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
			walkTo.GHDMBFOAAHK(targetWalkTo, AHDHLIECIGH: true, NGAKHGJANLO: false);
			walkTo.speed = speed;
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(APGLLOHDPHO));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(PPBLPFDOBGD));
			walkTo.EHDKLBLKBEO();
		}
	}

	protected override void NJJCCIBDAPM()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		barkDialogue = false;
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		if (EventsManager.IsActive(EventsManager.EventType.OldMansDuel))
		{
			dialogue.conversation = "DueloDeViejos/RinTalk";
			return;
		}
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		if (((Result)(ref variable)).asInt == 0)
		{
			dialogue.conversation = "TermasInterior/Rin/Intro";
			return;
		}
		variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		if (((Result)(ref variable)).asInt >= 0)
		{
			dialogue.conversation = "TermasInterior/Rin/Stand";
		}
	}
}
