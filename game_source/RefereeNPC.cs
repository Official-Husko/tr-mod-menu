using System;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class RefereeNPC : DialogueNPCBase
{
	private static RefereeNPC IADEMLIIDPC;

	public float timeBarks;

	private int HKKKNMIKPCM;

	private string HDFMHCKKJJG = "";

	public BarrelJudge barrel;

	public static RefereeNPC GGFJGHHHEJC => IADEMLIIDPC;

	public void EFOEDOJOFEH(string emotion)
	{
		OPILDPFDFKJ().emotionsController.EMMBEAHMDHE(emotion);
	}

	public void GDDDHHDLDMK(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		walkTo.GLHBJNDMIDC(targetWalkTo, AHDHLIECIGH: false, NGAKHGJANLO: false);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(IGOGKMLCLPI));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(BIGHFOIJPGN));
		walkTo.EHDKLBLKBEO();
	}

	public void MMHIOJMIJMP()
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(KIALFDOKABP().dialogueEvent))
		{
			OPILDPFDFKJ().barkDialogue = false;
			MPJJAPCFENH().mouseUpTrigger = false;
			OMFKNGDCJFN().StartConversation(0, MPJJAPCFENH().dialogueEvent);
			NGIMIHFFNMH().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)5)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = (Direction)5;
		}
		if (disable)
		{
			content.SetActive(true);
			disable = true;
		}
		targetWalkTo = Vector2.zero;
	}

	[SpecialName]
	public static RefereeNPC MPJJAPCFENH()
	{
		return IADEMLIIDPC;
	}

	public void KGLIEFBOLPF()
	{
		OathFeastEvent.instance.ActiveBarrelIntro();
	}

	public void FOEBEJHKEKE()
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(OMFKNGDCJFN().dialogueEvent))
		{
			OPILDPFDFKJ().barkDialogue = true;
			OMFKNGDCJFN().mouseUpTrigger = false;
			MPJJAPCFENH().StartConversation(0, KIALFDOKABP().dialogueEvent, FLHBPHPKIML: true);
			NGIMIHFFNMH().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)7)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = Direction.Right;
		}
		if (disable)
		{
			content.SetActive(true);
			disable = false;
		}
		targetWalkTo = Vector2.zero;
	}

	public void PPGFNGEFCPF()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Comfort");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
	}

	public void PPPADNMKKIO()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Tutorial/Barn_Holly");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
	}

	private void OKAPGNGLOHO()
	{
		SelectDialogueUI();
	}

	public void BHODODMDGOM()
	{
		OathFeastEvent.instance.ActiveBarrelIntro();
	}

	public void CJFCMOBFFNF(string emotion)
	{
		DOIKFJDLKJP().emotionsController.StartEmotion(emotion);
	}

	private void ACOJHBFFFIF()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		Walk(targetWalkTo, endWalkDirection);
	}

	public void MMAAOFHFPNP(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		walkTo.JJDCANFBFMK(targetWalkTo, AHDHLIECIGH: false);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(GMCINBCEPJO));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(OFEMFGCBLBH));
		walkTo.NOFKEMGPFEO();
	}

	private void DEFIFMAOPCM()
	{
		FAIKJIICNOI();
	}

	public void APLNODFEIGF(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		walkTo.FNNPPBDFBCI(targetWalkTo, AHDHLIECIGH: false, NGAKHGJANLO: false);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(HMOPLHDOPKK));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(MGCPPABFAGA));
		walkTo.NOFKEMGPFEO();
	}

	[SpecialName]
	public static RefereeNPC NGIMIHFFNMH()
	{
		return IADEMLIIDPC;
	}

	public void FJNPFILECCM()
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(KIALFDOKABP().dialogueEvent))
		{
			GGFJGHHHEJC.barkDialogue = false;
			JFNOOMJMHCB().mouseUpTrigger = true;
			EJHDHCNILDH().StartConversation(0, JFNOOMJMHCB().dialogueEvent);
			DOIKFJDLKJP().dialogueEvent = null;
		}
		if (endWalkDirection != 0)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = (Direction)8;
		}
		if (disable)
		{
			content.SetActive(false);
			disable = true;
		}
		targetWalkTo = Vector2.zero;
	}

	private void OFEMFGCBLBH()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		BAPCIPCAEKL(targetWalkTo, endWalkDirection);
	}

	private void FAIKJIICNOI()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.GOACFCOOJLK(OEBNHGNJEJL: true);
		}
	}

	private void DCNBJDFIOPG()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.BODEPFFAHLE(OEBNHGNJEJL: true);
		}
	}

	private void PHHHONLNAKO()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.IIMEFNIECLI();
		}
	}

	public void LMEMMBGFPII(string emotion)
	{
		GGFJGHHHEJC.emotionsController.NBFIDOGMLOK(emotion);
	}

	public void HMOPLHDOPKK()
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(EJHDHCNILDH().dialogueEvent))
		{
			GGFJGHHHEJC.barkDialogue = true;
			MPJJAPCFENH().mouseUpTrigger = true;
			OAPOJCODNCO().StartConversation(1, JFNOOMJMHCB().dialogueEvent, FLHBPHPKIML: true);
			NGIMIHFFNMH().dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Right)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = (Direction)7;
		}
		if (disable)
		{
			content.SetActive(false);
			disable = false;
		}
		targetWalkTo = Vector2.zero;
	}

	public void AHJAFGLGKJL(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		walkTo.FNNPPBDFBCI(targetWalkTo);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(GEAKPMEBBAI));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(BIGHFOIJPGN));
		walkTo.NOFKEMGPFEO();
	}

	public void CJFIDPLGOMB(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		walkTo.DBHOIIIHIIM(targetWalkTo);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(FOEBEJHKEKE));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(MGCPPABFAGA));
		walkTo.NOFKEMGPFEO();
	}

	public void HNMMHJOFBGB(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		walkTo.GINPKMBGOFN(targetWalkTo, AHDHLIECIGH: false);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(HMOPLHDOPKK));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(MGCPPABFAGA));
		walkTo.EHDKLBLKBEO();
	}

	private void CFHOODNCOLK()
	{
		SelectDialogueUI(1);
	}

	private void FHEGBNMJADG()
	{
		SelectDialogueUI();
	}

	private void KKDJEKACAIE()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		KPOIBPDHLPE(targetWalkTo, endWalkDirection);
	}

	public void ActiveBarrelIntro()
	{
		OathFeastEvent.instance.ActiveBarrelIntro();
	}

	private void JBABHOJPFPG()
	{
		IIJKBJOKNBD();
	}

	private void HEDGGNKENPB()
	{
		HJHHKHAFHJE();
	}

	private void ECPINCPHACH()
	{
		NDPMBDKGMKA();
	}

	private void NPMLFHDHJBE()
	{
		SelectDialogueUI();
	}

	protected override void NJJCCIBDAPM()
	{
		barkDialogue = false;
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
	}

	private void BIGHFOIJPGN()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		AOGHLDJHBMD(targetWalkTo, endWalkDirection);
	}

	[SpecialName]
	public static RefereeNPC JFNOOMJMHCB()
	{
		return IADEMLIIDPC;
	}

	public void LMBJEGLHKBO()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Create Public Room");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
	}

	public void HICGHFBHDHG(string emotion)
	{
		GGFJGHHHEJC.emotionsController.GPLECKGJFKM(emotion);
	}

	public void LHOHMGDCHHA(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		walkTo.DBHOIIIHIIM(targetWalkTo, AHDHLIECIGH: false);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(FJNPFILECCM));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(BIGHFOIJPGN));
		walkTo.NOFKEMGPFEO();
	}

	[SpecialName]
	public static RefereeNPC OAPOJCODNCO()
	{
		return IADEMLIIDPC;
	}

	public void JNEJLAIEJMG()
	{
		OathFeastEvent.instance.EEJOCNJJBNL(BFLCJPHHDJM: false);
	}

	public void OnActionComplete()
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
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
		}
		targetWalkTo = Vector2.zero;
	}

	private void FixedUpdate()
	{
		DIKPOHPGNLG();
	}

	protected override void OnConversationStart(Transform actor)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		base.OnConversationStart(actor);
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		HKKKNMIKPCM = ((Result)(ref variable)).asInt;
	}

	private void DFCKAJCMPFL()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.IIMEFNIECLI(OEBNHGNJEJL: true);
		}
	}

	public void AOGHLDJHBMD(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		walkTo.FNNPPBDFBCI(targetWalkTo, AHDHLIECIGH: false);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(GMCINBCEPJO));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(BIGHFOIJPGN));
		walkTo.PEHELKCIECB();
	}

	private void KBOFHCAJELA()
	{
		IPNKKDOIANF();
	}

	private void JHBBABPAJJC()
	{
		SelectDialogueUI(1);
	}

	public void COACMHKHDBL()
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(NGIMIHFFNMH().dialogueEvent))
		{
			MPJJAPCFENH().barkDialogue = false;
			DOIKFJDLKJP().mouseUpTrigger = true;
			GGFJGHHHEJC.StartConversation(0, OAPOJCODNCO().dialogueEvent);
			OPILDPFDFKJ().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)7)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = (Direction)7;
		}
		if (disable)
		{
			content.SetActive(false);
			disable = true;
		}
		targetWalkTo = Vector2.zero;
	}

	public void GEAKPMEBBAI()
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(KIALFDOKABP().dialogueEvent))
		{
			NGIMIHFFNMH().barkDialogue = true;
			EJHDHCNILDH().mouseUpTrigger = false;
			KIALFDOKABP().StartConversation(0, OAPOJCODNCO().dialogueEvent, FLHBPHPKIML: true);
			KIALFDOKABP().dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Diagonal)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = Direction.Right;
		}
		if (disable)
		{
			content.SetActive(true);
			disable = true;
		}
		targetWalkTo = Vector2.zero;
	}

	public void Walk(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		walkTo.FNNPPBDFBCI(targetWalkTo);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(OnActionComplete));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(ACOJHBFFFIF));
		walkTo.PEHELKCIECB();
	}

	public void IDBCMIMFHJC()
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(JFNOOMJMHCB().dialogueEvent))
		{
			KIALFDOKABP().barkDialogue = true;
			OAPOJCODNCO().mouseUpTrigger = true;
			JFNOOMJMHCB().StartConversation(1, OPILDPFDFKJ().dialogueEvent);
			DOIKFJDLKJP().dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Diagonal)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = (Direction)6;
		}
		if (disable)
		{
			content.SetActive(true);
			disable = false;
		}
		targetWalkTo = Vector2.zero;
	}

	private void HOKAPOOCJCC()
	{
		SelectDialogueUI(1);
	}

	public void ELBPCLPMHHE(string emotion)
	{
		OAPOJCODNCO().emotionsController.PIOCPGKDAOF(emotion);
	}

	public void GNDGOIENBNA(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		walkTo.EJPGFOEDPBG(targetWalkTo, AHDHLIECIGH: true, NGAKHGJANLO: false);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(HMOPLHDOPKK));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(ACOJHBFFFIF));
		walkTo.EHDKLBLKBEO();
	}

	public void LEKBFCCFCDB()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("[MinePuzzleManager] Adding {0} puzzle spawners from piece {1} (maxPuzzleSpawners: {2})");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
	}

	public void NBCIKEEAFFM(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		walkTo.DBHOIIIHIIM(targetWalkTo, AHDHLIECIGH: false, NGAKHGJANLO: false);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(IDBCMIMFHJC));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(ACOJHBFFFIF));
		walkTo.EHDKLBLKBEO();
	}

	public void MBGBGAIMAFD(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		walkTo.GLHBJNDMIDC(targetWalkTo);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(IGOGKMLCLPI));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(CJJCIBFMPKM));
		walkTo.EHDKLBLKBEO();
	}

	public void IOKILGMHFNE(string emotion)
	{
		DOIKFJDLKJP().emotionsController.StartEmotion(emotion);
	}

	public void AAOEFHODHHA(string emotion)
	{
		DOIKFJDLKJP().emotionsController.NMAPMPBAGMM(emotion);
	}

	public void IIEGDHJEEKC()
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(EJHDHCNILDH().dialogueEvent))
		{
			NGIMIHFFNMH().barkDialogue = true;
			DOIKFJDLKJP().mouseUpTrigger = true;
			EJHDHCNILDH().StartConversation(1, JFNOOMJMHCB().dialogueEvent);
			EJHDHCNILDH().dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Right)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = Direction.Diagonal;
		}
		if (disable)
		{
			content.SetActive(true);
			disable = false;
		}
		targetWalkTo = Vector2.zero;
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

	private void HOFKJPBBLGP()
	{
		SelectDialogueUI();
	}

	public void GIFNIPDANAI(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		walkTo.BDIKOLNFKGD(targetWalkTo, AHDHLIECIGH: false);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(COACMHKHDBL));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(CJJCIBFMPKM));
		walkTo.EHDKLBLKBEO();
	}

	private void HDNHNMJHOJM()
	{
		IPNKKDOIANF();
	}

	private void FCGOHAPNMHN()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.GOACFCOOJLK(OEBNHGNJEJL: true);
		}
	}

	private void NDPMBDKGMKA()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.BODEPFFAHLE();
		}
	}

	protected override void Awake()
	{
		base.Awake();
		IADEMLIIDPC = this;
	}

	public void FACKKGAODPO(string emotion)
	{
		EJHDHCNILDH().emotionsController.NMAPMPBAGMM(emotion);
	}

	private void DOHLOJOIHFO()
	{
		SelectDialogueUI();
	}

	private void IPNKKDOIANF()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.IIMEFNIECLI(OEBNHGNJEJL: true);
		}
	}

	public void CIIANCAEDOA()
	{
		OathFeastEvent.instance.HAONCDNFKCA(BFLCJPHHDJM: false);
	}

	[SpecialName]
	public static RefereeNPC DOIKFJDLKJP()
	{
		return IADEMLIIDPC;
	}

	public void PIBMIDIMPHP()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Freeze");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
	}

	public void BAPCIPCAEKL(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		walkTo.GINPKMBGOFN(targetWalkTo);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(IGOGKMLCLPI));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(BIGHFOIJPGN));
		walkTo.NOFKEMGPFEO();
	}

	private void CJJCIBFMPKM()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		BAPCIPCAEKL(targetWalkTo, endWalkDirection);
	}

	public void EDBDHJIGLIL(string emotion)
	{
		KIALFDOKABP().emotionsController.DCCNJLBLFGI(emotion);
	}

	private void ICFHPJHBPDN()
	{
		SelectDialogueUI();
	}

	public void ONKCGNIAAKH()
	{
		OathFeastEvent.instance.LKPBLNCLIIB();
	}

	private void KDBJHCAEGCM()
	{
		SelectDialogueUI();
	}

	private void HJHHKHAFHJE()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.GOACFCOOJLK();
		}
	}

	public void IGOGKMLCLPI()
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(MPJJAPCFENH().dialogueEvent))
		{
			OAPOJCODNCO().barkDialogue = false;
			DOIKFJDLKJP().mouseUpTrigger = false;
			KIALFDOKABP().StartConversation(0, NGIMIHFFNMH().dialogueEvent);
			DOIKFJDLKJP().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)6)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = (Direction)7;
		}
		if (disable)
		{
			content.SetActive(false);
			disable = true;
		}
		targetWalkTo = Vector2.zero;
	}

	private void AHFGOOHOLEL()
	{
		SelectDialogueUI();
	}

	private void LOEGLBHJGEP()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.PAHDHACALOH(OEBNHGNJEJL: true);
		}
	}

	public void FFHKDCECPHI()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("SinglePlayer");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
	}

	private void NCIBKMLIIAJ()
	{
		SelectDialogueUI(1);
	}

	private void KIGPIILBDAC()
	{
		IIJKBJOKNBD();
	}

	[SpecialName]
	public static RefereeNPC OMFKNGDCJFN()
	{
		return IADEMLIIDPC;
	}

	private void LHLLJMANKMF()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.IIMEFNIECLI(OEBNHGNJEJL: true);
		}
	}

	public void NLIFFPNNMMG(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		walkTo.GHDMBFOAAHK(targetWalkTo);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(IGOGKMLCLPI));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(BIGHFOIJPGN));
		walkTo.EHDKLBLKBEO();
	}

	private void CHMHMGACCNH()
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

	private void NALAOJAJFMP()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.PLAGPJAKCKL(OEBNHGNJEJL: true);
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

	public void KIBIHBFJOJH(string emotion)
	{
		GGFJGHHHEJC.emotionsController.EMMBEAHMDHE(emotion);
	}

	private void JLCFNPBBKEK()
	{
		SelectDialogueUI(1);
	}

	public void FFMBPOJAEDA(string emotion)
	{
		EJHDHCNILDH().emotionsController.StartEmotion(emotion);
	}

	private void PIEAKAIHNNN()
	{
		NDPMBDKGMKA();
	}

	public void JDGOKDNEIPA(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		walkTo.HELOLJBENMK(targetWalkTo, AHDHLIECIGH: false);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(CAEDALACKDD));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(MGCPPABFAGA));
		walkTo.EHDKLBLKBEO();
	}

	public override DialogueNPCBase GetInstance()
	{
		return GGFJGHHHEJC;
	}

	[SpecialName]
	public static RefereeNPC KIALFDOKABP()
	{
		return IADEMLIIDPC;
	}

	private void MGCPPABFAGA()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		CJFIDPLGOMB(targetWalkTo, endWalkDirection);
	}

	[SpecialName]
	public static RefereeNPC EJHDHCNILDH()
	{
		return IADEMLIIDPC;
	}

	public void DLHALHHJELB()
	{
		OathFeastEvent.instance.LKPBLNCLIIB(BFLCJPHHDJM: false);
	}

	public void KPOIBPDHLPE(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		walkTo.GHDMBFOAAHK(targetWalkTo, AHDHLIECIGH: true, NGAKHGJANLO: false);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(OnActionComplete));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(KKDJEKACAIE));
		walkTo.PEHELKCIECB();
	}

	public void GMCINBCEPJO()
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(JFNOOMJMHCB().dialogueEvent))
		{
			GGFJGHHHEJC.barkDialogue = false;
			NGIMIHFFNMH().mouseUpTrigger = false;
			KIALFDOKABP().StartConversation(0, NGIMIHFFNMH().dialogueEvent, FLHBPHPKIML: true);
			NGIMIHFFNMH().dialogueEvent = null;
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
		}
		targetWalkTo = Vector2.zero;
	}

	private void Start()
	{
		SelectDialogueUI();
	}

	public new void CheckExclamation()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("LE_13");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
	}

	private void FKIEEDDAGKG()
	{
		NALAOJAJFMP();
	}

	public void KCALIEDHPAN(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		walkTo.DHFPOCOEONG(targetWalkTo);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(IIEGDHJEEKC));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(KKDJEKACAIE));
		walkTo.NOFKEMGPFEO();
	}

	private void LBLJPOEPOMH()
	{
		IIJKBJOKNBD();
	}

	public void CAEDALACKDD()
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(OAPOJCODNCO().dialogueEvent))
		{
			OMFKNGDCJFN().barkDialogue = false;
			MPJJAPCFENH().mouseUpTrigger = false;
			DOIKFJDLKJP().StartConversation(0, MPJJAPCFENH().dialogueEvent);
			JFNOOMJMHCB().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)5)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = (Direction)6;
		}
		if (disable)
		{
			content.SetActive(true);
			disable = false;
		}
		targetWalkTo = Vector2.zero;
	}

	[SpecialName]
	public static RefereeNPC OPILDPFDFKJ()
	{
		return IADEMLIIDPC;
	}

	private void NLFHFPHDNCF()
	{
		SelectDialogueUI();
	}

	private void IIJKBJOKNBD()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.IIMEFNIECLI();
		}
	}

	private void EEKOJEKPIMP()
	{
		SelectDialogueUI(1);
	}
}
