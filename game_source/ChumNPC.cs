using System;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class ChumNPC : DialogueNPCBase
{
	private static ChumNPC IADEMLIIDPC;

	public float timeBarks;

	private int HKKKNMIKPCM;

	private string HDFMHCKKJJG = "";

	public static ChumNPC GGFJGHHHEJC => IADEMLIIDPC;

	public void HMLFDDDGGBO()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(KMKILBCGJOI().dialogueEvent))
		{
			POINNCPMEIG().barkDialogue = false;
			KIALFDOKABP().mouseUpTrigger = true;
			KMKILBCGJOI().StartConversation(1, OACNNJCLEDE().dialogueEvent);
			KIALFDOKABP().dialogueEvent = null;
		}
		if (endWalkDirection != 0)
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
				onlineDialogue.APGJMNHJNHN();
			}
		}
		targetWalkTo = Vector2.zero;
	}

	[SpecialName]
	public static ChumNPC LKOABOAADCD()
	{
		return IADEMLIIDPC;
	}

	public void CJKKCFLCMKA(string emotion)
	{
		CHKMFEFOFKJ().emotionsController.GPLECKGJFKM(emotion);
	}

	[SpecialName]
	public static ChumNPC KIALFDOKABP()
	{
		return IADEMLIIDPC;
	}

	private void ACOJHBFFFIF()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		Walk(targetWalkTo, endWalkDirection);
	}

	public void IILNAMPPHMP()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Listen");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
	}

	private void NDPMBDKGMKA()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.GOACFCOOJLK(OEBNHGNJEJL: true);
		}
	}

	private void GHDIABALHLP()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.PLAGPJAKCKL(OEBNHGNJEJL: true);
		}
	}

	private void IAAGKLPMAMK()
	{
		SelectDialogueUI(1);
	}

	private void FKPNIHJGFBJ()
	{
		SelectDialogueUI(1);
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

	[SpecialName]
	public static ChumNPC POINNCPMEIG()
	{
		return IADEMLIIDPC;
	}

	private void GOEFOAKFDDD()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		Walk(targetWalkTo, endWalkDirection);
	}

	private void NFABFPFLNEE()
	{
		SelectDialogueUI();
	}

	public void OGBEGBJDNKJ()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(EBAIHKJHCCA().dialogueEvent))
		{
			OACNNJCLEDE().barkDialogue = false;
			KMKILBCGJOI().mouseUpTrigger = true;
			KMKILBCGJOI().StartConversation(1, KMKILBCGJOI().dialogueEvent);
			EBAIHKJHCCA().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)7)
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

	[SpecialName]
	public static ChumNPC MAIDHAPANEB()
	{
		return IADEMLIIDPC;
	}

	public void PJGJGBEADMB(string emotion)
	{
		EBAIHKJHCCA().emotionsController.PIOCPGKDAOF(emotion);
	}

	private void MJDFKJBFMPO()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		Walk(targetWalkTo, endWalkDirection, AMEOKNOLILB: true);
	}

	private void CJLGLDBNHBE()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.GOACFCOOJLK(OEBNHGNJEJL: true);
		}
	}

	public void DCLMGAKHJDP()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(OACNNJCLEDE().dialogueEvent))
		{
			KIALFDOKABP().barkDialogue = false;
			KMKILBCGJOI().mouseUpTrigger = true;
			EBAIHKJHCCA().StartConversation(1, KMKILBCGJOI().dialogueEvent);
			OACNNJCLEDE().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)5)
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

	private void DAIGKLPJCAG()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.IIMEFNIECLI(OEBNHGNJEJL: true);
		}
	}

	public void KIOMHEIDHFN(string emotion)
	{
		KIALFDOKABP().emotionsController.DCCNJLBLFGI(emotion);
	}

	public void LGOKBJEJDKK(string emotion)
	{
		LKOABOAADCD().emotionsController.GPLECKGJFKM(emotion);
	}

	private void HNEGFBCKIIJ()
	{
		SelectDialogueUI();
	}

	private void CMJJFJFDNED()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			DNMCOJNOKJA();
		}
	}

	private void GHBEMCOFHOC()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			ODAKPIBFMNP();
		}
	}

	public void HPKIOFCAOGB(string emotion)
	{
		CHKMFEFOFKJ().emotionsController.EMMBEAHMDHE(emotion);
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

	private void Start()
	{
		SelectDialogueUI();
	}

	public void JMNHCFPKOCH()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Club");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		}
	}

	public void PKCODIDOBJO()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(EBAIHKJHCCA().dialogueEvent))
		{
			MAIDHAPANEB().barkDialogue = true;
			EJHDHCNILDH().mouseUpTrigger = false;
			OACNNJCLEDE().StartConversation(0, EBAIHKJHCCA().dialogueEvent, FLHBPHPKIML: true);
			KIALFDOKABP().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)8)
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

	private void OBBNJFKHANB()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.BODEPFFAHLE();
		}
	}

	public void IOKILGMHFNE(string emotion)
	{
		KMKILBCGJOI().emotionsController.EMMBEAHMDHE(emotion);
	}

	public void LCLNGAAFKNB()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Dial was ");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
	}

	private void GOJGHOPMNDC()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.IIMEFNIECLI(OEBNHGNJEJL: true);
		}
	}

	private void IJGENAIOCHB()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		POCIILOJOJD(targetWalkTo, endWalkDirection);
	}

	public void IDBCMIMFHJC()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(POINNCPMEIG().dialogueEvent))
		{
			MAIDHAPANEB().barkDialogue = true;
			KIALFDOKABP().mouseUpTrigger = true;
			OJJDNLEFNPJ().StartConversation(1, EJHDHCNILDH().dialogueEvent, FLHBPHPKIML: true);
			EJHDHCNILDH().dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Down)
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

	public void FNGKCCMIMLA()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Up Arrow");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
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

	public void FNKIODOAHPN()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(EJHDHCNILDH().dialogueEvent))
		{
			EJHDHCNILDH().barkDialogue = true;
			POINNCPMEIG().mouseUpTrigger = false;
			POINNCPMEIG().StartConversation(1, EBAIHKJHCCA().dialogueEvent);
			KIALFDOKABP().dialogueEvent = null;
		}
		if (endWalkDirection != 0)
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

	public void IGGHGMHGECM(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		disable = AMEOKNOLILB;
		walkTo.DBHOIIIHIIM(targetWalkTo, AHDHLIECIGH: false, NGAKHGJANLO: false);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(HMLFDDDGGBO));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(EILPPGGCANE));
		walkTo.PEHELKCIECB();
	}

	private void LJHNGACLJBF()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.PAHDHACALOH();
		}
	}

	public void BFGEFKOODNA()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(LKOABOAADCD().dialogueEvent))
		{
			MAIDHAPANEB().barkDialogue = true;
			GGFJGHHHEJC.mouseUpTrigger = false;
			POINNCPMEIG().StartConversation(0, OACNNJCLEDE().dialogueEvent);
			GGFJGHHHEJC.dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)7)
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

	private void BOKOLOCCLEN()
	{
		if (OnlineManager.MasterOrOffline())
		{
			NDPMBDKGMKA();
		}
	}

	protected override void NJJCCIBDAPM()
	{
		barkDialogue = false;
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		dialogue.conversation = "Pirates/Chum/Talk";
	}

	public void StartEmotions(string emotion)
	{
		GGFJGHHHEJC.emotionsController.StartEmotion(emotion);
	}

	private void FGJPOPCBFNE()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			NDPMBDKGMKA();
		}
	}

	public void CMOKMMDCJCI()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Disabled");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		}
	}

	private void PHHHONLNAKO()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.BODEPFFAHLE();
		}
	}

	private void NODDNBFDJGO()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			DNMCOJNOKJA();
		}
	}

	public void EEPJLOBNIMM()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Player");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
		}
	}

	private void NFLOOLMJEIL()
	{
		if (OnlineManager.MasterOrOffline())
		{
			BCKLFAGEKOJ();
		}
	}

	protected override void Awake()
	{
		base.Awake();
		IADEMLIIDPC = this;
	}

	public void LMBJEGLHKBO()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("City/Agatha/Stand");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
	}

	private void EILPPGGCANE()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		POCIILOJOJD(targetWalkTo, endWalkDirection, AMEOKNOLILB: true);
	}

	[SpecialName]
	public static ChumNPC CHKMFEFOFKJ()
	{
		return IADEMLIIDPC;
	}

	public void POCIILOJOJD(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
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
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(IDBCMIMFHJC));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(GOEFOAKFDDD));
		walkTo.EHDKLBLKBEO();
	}

	[SpecialName]
	public static ChumNPC EJHDHCNILDH()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static ChumNPC EBAIHKJHCCA()
	{
		return IADEMLIIDPC;
	}

	private void DNMCOJNOKJA()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.PAHDHACALOH();
		}
	}

	public void HHECLDCGGBE(string emotion)
	{
		EBAIHKJHCCA().emotionsController.NBFIDOGMLOK(emotion);
	}

	public void PPGFNGEFCPF()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("OnUserStatsAndAchievementsStoreFailure: ");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
	}

	public void AAPBBHOHMIJ()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(EBAIHKJHCCA().dialogueEvent))
		{
			MAIDHAPANEB().barkDialogue = true;
			POINNCPMEIG().mouseUpTrigger = true;
			POINNCPMEIG().StartConversation(1, EBAIHKJHCCA().dialogueEvent);
			GGFJGHHHEJC.dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Down)
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

	private void MDKNIJCHHCE()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			NALAOJAJFMP();
		}
	}

	public void MKJDIMFOGIA()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(KMKILBCGJOI().dialogueEvent))
		{
			OACNNJCLEDE().barkDialogue = true;
			EBAIHKJHCCA().mouseUpTrigger = true;
			LKOABOAADCD().StartConversation(1, LKOABOAADCD().dialogueEvent, FLHBPHPKIML: true);
			OJJDNLEFNPJ().dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Diagonal)
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
				onlineDialogue.APGJMNHJNHN();
			}
		}
		targetWalkTo = Vector2.zero;
	}

	private void DJEEOPKPAIK()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.PLAGPJAKCKL(OEBNHGNJEJL: true);
		}
	}

	public void IOEFJEOHPHJ()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Not enough ingredients");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
		}
	}

	private void ODKGLIDMCNP()
	{
		SelectDialogueUI(1);
	}

	public void JECGJNDCMCG()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Cat");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
	}

	public void IHIDJOEEMBK()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("<size=");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		}
	}

	private void BCKLFAGEKOJ()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.GOACFCOOJLK();
		}
	}

	public void EACGIFJCIKJ()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Wilson/Bark/Bark_Shop");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
	}

	public void BPGJOFGCCIN(string emotion)
	{
		LKOABOAADCD().emotionsController.DCCNJLBLFGI(emotion);
	}

	private void MKLIAMJFHOF()
	{
		SelectDialogueUI(1);
	}

	private void OKAPGNGLOHO()
	{
		SelectDialogueUI(1);
	}

	public void ILNINHJFLBL()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(GGFJGHHHEJC.dialogueEvent))
		{
			EBAIHKJHCCA().barkDialogue = true;
			KMKILBCGJOI().mouseUpTrigger = true;
			MAIDHAPANEB().StartConversation(0, CHKMFEFOFKJ().dialogueEvent, FLHBPHPKIML: true);
			CHKMFEFOFKJ().dialogueEvent = null;
		}
		if (endWalkDirection != 0)
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

	[SpecialName]
	public static ChumNPC KMKILBCGJOI()
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

	private void EHBFECEJGCE()
	{
		if (OnlineManager.MasterOrOffline())
		{
			CJLGLDBNHBE();
		}
	}

	private void FixedUpdate()
	{
		if (OnlineManager.MasterOrOffline())
		{
			DIKPOHPGNLG();
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

	public void MMBHJICBLND(string emotion)
	{
		GGFJGHHHEJC.emotionsController.StartEmotion(emotion);
	}

	private void HKOFLOPDCEJ()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			GOJGHOPMNDC();
		}
	}

	[SpecialName]
	public static ChumNPC OJJDNLEFNPJ()
	{
		return IADEMLIIDPC;
	}

	public void PBBBJBHFGNN()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(CHKMFEFOFKJ().dialogueEvent))
		{
			POINNCPMEIG().barkDialogue = true;
			LKOABOAADCD().mouseUpTrigger = true;
			GGFJGHHHEJC.StartConversation(1, OACNNJCLEDE().dialogueEvent);
			KMKILBCGJOI().dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Left)
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

	private void GHLINOHHNJE()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.PAHDHACALOH();
		}
	}

	private void MBLOIGIMANG()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.GOACFCOOJLK();
		}
	}

	private void GAEDNJMJDJD()
	{
		if (OnlineManager.MasterOrOffline())
		{
			LJHNGACLJBF();
		}
	}

	private void NLOEGNNLKKE()
	{
		if (OnlineManager.MasterOrOffline())
		{
			MBLOIGIMANG();
		}
	}

	private void ECGANLCHOEK()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.BODEPFFAHLE(OEBNHGNJEJL: true);
		}
	}

	public void FEHGALEDJKI()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(CHKMFEFOFKJ().dialogueEvent))
		{
			LKOABOAADCD().barkDialogue = true;
			EBAIHKJHCCA().mouseUpTrigger = false;
			OACNNJCLEDE().StartConversation(0, GGFJGHHHEJC.dialogueEvent);
			OACNNJCLEDE().dialogueEvent = null;
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
				onlineDialogue.APGJMNHJNHN();
			}
		}
		targetWalkTo = Vector2.zero;
	}

	private void AHECKLFEFAB()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		EFNENNELAKM(targetWalkTo, endWalkDirection);
	}

	private void ODAKPIBFMNP()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.PLAGPJAKCKL();
		}
	}

	private void EJJKCAPPKLL()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			NALAOJAJFMP();
		}
	}

	private void GCPIEBDOLFB()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.IIMEFNIECLI();
		}
	}

	public void BLJCLIIFJBM()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable(":</color> ");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
	}

	public void KHCNNNJAMPL()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Loop");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
	}

	private void NALAOJAJFMP()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.PLAGPJAKCKL();
		}
	}

	private void HCEDMLJNOBL()
	{
		SelectDialogueUI();
	}

	public void NJGAGDCMHFO()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("UI");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
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

	public void BOJOFAFIICG()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(EJHDHCNILDH().dialogueEvent))
		{
			OJJDNLEFNPJ().barkDialogue = true;
			CHKMFEFOFKJ().mouseUpTrigger = true;
			OACNNJCLEDE().StartConversation(0, MAIDHAPANEB().dialogueEvent, FLHBPHPKIML: true);
			KIALFDOKABP().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)5)
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

	public void HPBPIGFIEED()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("EditorAction_");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
		}
	}

	public override DialogueNPCBase GetInstance()
	{
		return GGFJGHHHEJC;
	}

	[SpecialName]
	public static ChumNPC OACNNJCLEDE()
	{
		return IADEMLIIDPC;
	}

	public void EFOEDOJOFEH(string emotion)
	{
		POINNCPMEIG().emotionsController.EMMBEAHMDHE(emotion);
	}

	private void IFHLGOMBACP()
	{
		SelectDialogueUI(1);
	}

	public void EFNENNELAKM(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		disable = AMEOKNOLILB;
		walkTo.GHDMBFOAAHK(targetWalkTo);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(OGBEGBJDNKJ));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(GOEFOAKFDDD));
		walkTo.EHDKLBLKBEO();
	}
}
