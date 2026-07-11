using System;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class RibellaNPC : DialogueNPCBase
{
	private static RibellaNPC IADEMLIIDPC;

	public float timeBarks;

	private int HKKKNMIKPCM;

	private string HDFMHCKKJJG = "";

	public static RibellaNPC GGFJGHHHEJC => IADEMLIIDPC;

	private void IMBHCJNIPGE()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		ELBLAFPCJOL(targetWalkTo, endWalkDirection);
	}

	[SpecialName]
	public static RibellaNPC MOJDNGDNCCO()
	{
		return IADEMLIIDPC;
	}

	public void DDEGJLEHDJM()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(PDECKLKPKCG().dialogueEvent))
		{
			BAKPBHPNKPB().barkDialogue = true;
			KHMEGDIABBF().mouseUpTrigger = true;
			PDECKLKPKCG().StartConversation(1, MIGKKKELOJO().dialogueEvent, FLHBPHPKIML: true);
			GGFJGHHHEJC.dialogueEvent = null;
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

	public void LFAOGOCJMEK()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("MineFloor");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		}
	}

	public void BAPCIPCAEKL(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
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
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(AHPFECCLOBB));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(LFBMFAHPBIM));
		walkTo.EHDKLBLKBEO();
	}

	private void Start()
	{
		SelectDialogueUI();
	}

	private void KILDJCPLOPP()
	{
		SelectDialogueUI();
	}

	private void EACIGGOOKGD()
	{
		SelectDialogueUI();
	}

	private void LDPGPIHCBCH()
	{
		SelectDialogueUI(1);
	}

	private void DEFIFMAOPCM()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			IJLCFABJEKH();
		}
	}

	public void OEGOAAHCOIM()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable(")\n");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
	}

	public void CBDGMDBCFLO(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
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
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(GFLNGGGPGCF));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(DMKNBLCAJDB));
		walkTo.PEHELKCIECB();
	}

	private void JECHMEFJABD()
	{
		SelectDialogueUI(1);
	}

	private void HCEDMLJNOBL()
	{
		SelectDialogueUI(1);
	}

	private void FFJBIMLEDNK()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.GOACFCOOJLK();
		}
	}

	private void GCPIEBDOLFB()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.PAHDHACALOH(OEBNHGNJEJL: true);
		}
	}

	private void EJMJOKOIBMI()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		MCEJEEJFDKB(targetWalkTo, endWalkDirection, AMEOKNOLILB: true);
	}

	public void OIFAGKBHCAP(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		disable = AMEOKNOLILB;
		walkTo.GLHBJNDMIDC(targetWalkTo, AHDHLIECIGH: false);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(IJCLNLKKIAF));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(EJMJOKOIBMI));
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
		walkTo.GHDMBFOAAHK(targetWalkTo, AHDHLIECIGH: true, NGAKHGJANLO: false);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(PCFNCMPNBDI));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(INACOMEAINH));
		walkTo.EHDKLBLKBEO();
	}

	private void EHBFECEJGCE()
	{
		if (OnlineManager.MasterOrOffline())
		{
			DILMMFFGHMD();
		}
	}

	public void DLFBDNPEKAE()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(CNDNOECMKME().dialogueEvent))
		{
			JCMKNNOEONP().barkDialogue = false;
			GJFMMOPOKGJ().mouseUpTrigger = false;
			MOJDNGDNCCO().StartConversation(1, DEGPIHEEFHJ().dialogueEvent);
			DCAEBALADIM().dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Right)
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

	public void LKDCNMHNMCP()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(KHMEGDIABBF().dialogueEvent))
		{
			JCMKNNOEONP().barkDialogue = false;
			PDECKLKPKCG().mouseUpTrigger = true;
			EBAIHKJHCCA().StartConversation(1, BAKPBHPNKPB().dialogueEvent);
			GJFMMOPOKGJ().dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Diagonal)
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
				onlineDialogue.APGJMNHJNHN();
			}
		}
		targetWalkTo = Vector2.zero;
	}

	private void BGENEAOILOF()
	{
		SelectDialogueUI(1);
	}

	[SpecialName]
	public static RibellaNPC EBAIHKJHCCA()
	{
		return IADEMLIIDPC;
	}

	public void StartEmotions(string emotion)
	{
		GGFJGHHHEJC.emotionsController.StartEmotion(emotion);
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

	public void PKIBNCNNDJJ(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
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
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(DLFBDNPEKAE));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(ACOJHBFFFIF));
		walkTo.NOFKEMGPFEO();
	}

	private void KJOJLHCDFPP()
	{
		SelectDialogueUI();
	}

	public void DOJBBCMKKDL(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
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
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(ODKNNOBCILE));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(JMBOINMJEGI));
		walkTo.PEHELKCIECB();
	}

	private void FixedUpdate()
	{
		if (OnlineManager.MasterOrOffline())
		{
			DIKPOHPGNLG();
		}
	}

	private void DBHNAJDDGDE()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.IIMEFNIECLI();
		}
	}

	public void ILNINHJFLBL()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(DEGPIHEEFHJ().dialogueEvent))
		{
			GGFJGHHHEJC.barkDialogue = false;
			JCMKNNOEONP().mouseUpTrigger = true;
			MIGKKKELOJO().StartConversation(0, BAKPBHPNKPB().dialogueEvent, FLHBPHPKIML: true);
			DEGPIHEEFHJ().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)6)
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

	public void FFHKDCECPHI()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("UIInteract");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
	}

	[SpecialName]
	public static RibellaNPC JCMKNNOEONP()
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

	private void ACOJHBFFFIF()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		Walk(targetWalkTo, endWalkDirection);
	}

	public void JCNKIPBPOFC(string emotion)
	{
		BAKPBHPNKPB().emotionsController.EMMBEAHMDHE(emotion);
	}

	public void CJFCMOBFFNF(string emotion)
	{
		BADFKMEJOKE().emotionsController.GPLECKGJFKM(emotion);
	}

	private void GJGMDNEKAEG()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GCPIEBDOLFB();
		}
	}

	public override DialogueNPCBase GetInstance()
	{
		return GGFJGHHHEJC;
	}

	public void PPHJFALMJEG()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("NinjaChallengeEvent/Win 3");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		}
	}

	public void AHPFECCLOBB()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(DCAEBALADIM().dialogueEvent))
		{
			PDECKLKPKCG().barkDialogue = true;
			JCMKNNOEONP().mouseUpTrigger = true;
			GGFJGHHHEJC.StartConversation(0, DCAEBALADIM().dialogueEvent);
			JEEGOBGDLPE().dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Right)
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
				onlineDialogue.APGJMNHJNHN();
			}
		}
		targetWalkTo = Vector2.zero;
	}

	public void FCBBLACAOHH()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(CNDNOECMKME().dialogueEvent))
		{
			JEEGOBGDLPE().barkDialogue = false;
			MOJDNGDNCCO().mouseUpTrigger = false;
			DEGPIHEEFHJ().StartConversation(1, GJFMMOPOKGJ().dialogueEvent);
			EBAIHKJHCCA().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)8)
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
				onlineDialogue.SendDisableContent();
			}
		}
		targetWalkTo = Vector2.zero;
	}

	private void BHKLMNJGLFN()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		ELBLAFPCJOL(targetWalkTo, endWalkDirection);
	}

	[SpecialName]
	public static RibellaNPC BAKPBHPNKPB()
	{
		return IADEMLIIDPC;
	}

	public void BKILDJBIIHL(string emotion)
	{
		GJFMMOPOKGJ().emotionsController.StartEmotion(emotion);
	}

	public void ODKNNOBCILE()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(EBAIHKJHCCA().dialogueEvent))
		{
			PDECKLKPKCG().barkDialogue = true;
			CNDNOECMKME().mouseUpTrigger = true;
			EBAIHKJHCCA().StartConversation(0, BADFKMEJOKE().dialogueEvent);
			DEGPIHEEFHJ().dialogueEvent = null;
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

	public void LMJILDPFOEF(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		disable = AMEOKNOLILB;
		walkTo.OGLJDLEGJAA(targetWalkTo, AHDHLIECIGH: false, NGAKHGJANLO: false);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(ODKNNOBCILE));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(JMBOINMJEGI));
		walkTo.EHDKLBLKBEO();
	}

	public void IHFOJNJAALB(string emotion)
	{
		DCAEBALADIM().emotionsController.PIOCPGKDAOF(emotion);
	}

	public void IJKIFECCGEP()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(MOJDNGDNCCO().dialogueEvent))
		{
			DEGPIHEEFHJ().barkDialogue = false;
			JCMKNNOEONP().mouseUpTrigger = true;
			KHMEGDIABBF().StartConversation(0, JCMKNNOEONP().dialogueEvent);
			EBAIHKJHCCA().dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Right)
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
				onlineDialogue.SendDisableContent();
			}
		}
		targetWalkTo = Vector2.zero;
	}

	private void JMCPPIAJMHL()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.BODEPFFAHLE();
		}
	}

	private void BIGHFOIJPGN()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		PKIBNCNNDJJ(targetWalkTo, endWalkDirection);
	}

	[SpecialName]
	public static RibellaNPC PDECKLKPKCG()
	{
		return IADEMLIIDPC;
	}

	protected override void Awake()
	{
		base.Awake();
		IADEMLIIDPC = this;
	}

	private void NNBIAIMPNGL()
	{
		SelectDialogueUI();
	}

	private void GJIJGACIOKK()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		CBDGMDBCFLO(targetWalkTo, endWalkDirection, AMEOKNOLILB: true);
	}

	[SpecialName]
	public static RibellaNPC MIGKKKELOJO()
	{
		return IADEMLIIDPC;
	}

	public void FJGFEOIDCPC(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
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
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(CLOEFOFKDFC));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(GJIJGACIOKK));
		walkTo.EHDKLBLKBEO();
	}

	private void MPLHFJGFKJD()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			BCKLFAGEKOJ();
		}
	}

	private void OEMIMEIDMFE()
	{
		SelectDialogueUI();
	}

	private void NLADNLEHGCA()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		BAPCIPCAEKL(targetWalkTo, endWalkDirection, AMEOKNOLILB: true);
	}

	public void PCFNCMPNBDI()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(GJFMMOPOKGJ().dialogueEvent))
		{
			JCMKNNOEONP().barkDialogue = false;
			PDECKLKPKCG().mouseUpTrigger = true;
			GJFMMOPOKGJ().StartConversation(1, PDECKLKPKCG().dialogueEvent, FLHBPHPKIML: true);
			DEGPIHEEFHJ().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)7)
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

	private void FIFEIDAMIIG()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		MLACFFDPKPA(targetWalkTo, endWalkDirection);
	}

	public void HMOPLHDOPKK()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(GGFJGHHHEJC.dialogueEvent))
		{
			JEEGOBGDLPE().barkDialogue = false;
			KHMEGDIABBF().mouseUpTrigger = false;
			EBAIHKJHCCA().StartConversation(0, MIGKKKELOJO().dialogueEvent);
			JEEGOBGDLPE().dialogueEvent = null;
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
				onlineDialogue.APGJMNHJNHN();
			}
		}
		targetWalkTo = Vector2.zero;
	}

	public void DINEBCGMLDI()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("ReceiveInfoCrops");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
	}

	private void MDKNIJCHHCE()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			NDPMBDKGMKA();
		}
	}

	public void MLACFFDPKPA(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
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
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(ILNINHJFLBL));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(JLPDGFJJNAK));
		walkTo.PEHELKCIECB();
	}

	private void NLOEGNNLKKE()
	{
		if (OnlineManager.MasterOrOffline())
		{
			MKNKEDELDAK();
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

	private void KJOBHAJDCOC()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.PLAGPJAKCKL();
		}
	}

	public void KPMCGMJJBEA()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(MIGKKKELOJO().dialogueEvent))
		{
			GJFMMOPOKGJ().barkDialogue = true;
			EBAIHKJHCCA().mouseUpTrigger = true;
			JEEGOBGDLPE().StartConversation(0, BADFKMEJOKE().dialogueEvent);
			JCMKNNOEONP().dialogueEvent = null;
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
				onlineDialogue.SendDisableContent();
			}
		}
		targetWalkTo = Vector2.zero;
	}

	public void PJGJGBEADMB(string emotion)
	{
		JEEGOBGDLPE().emotionsController.NMAPMPBAGMM(emotion);
	}

	private void HDDBJBECDPP()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			IJLCFABJEKH();
		}
	}

	public void DBMPAGNJFFK(string emotion)
	{
		BAKPBHPNKPB().emotionsController.DCCNJLBLFGI(emotion);
	}

	public void CODGAACCGGB(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
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
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(LKDCNMHNMCP));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(GJIJGACIOKK));
		walkTo.EHDKLBLKBEO();
	}

	private void DILMMFFGHMD()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.PLAGPJAKCKL();
		}
	}

	private void ADJMGPNBDGF()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			IKFKBBFMJEL();
		}
	}

	private void PMKEDEBOFBA()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.GOACFCOOJLK();
		}
	}

	protected override void NJJCCIBDAPM()
	{
		barkDialogue = false;
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		if (EventsManager.IsActive(EventsManager.EventType.ThroneRoom))
		{
			dialogue.conversation = "SalonDelTrono/RibellaTalk";
		}
	}

	private void IKFKBBFMJEL()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.BODEPFFAHLE();
		}
	}

	public void AMOICFMHDCO(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		disable = AMEOKNOLILB;
		walkTo.DBHOIIIHIIM(targetWalkTo, AHDHLIECIGH: false);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(IKOIKCHBBNG));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(INACOMEAINH));
		walkTo.PEHELKCIECB();
	}

	public void IKOIKCHBBNG()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(CNDNOECMKME().dialogueEvent))
		{
			JCMKNNOEONP().barkDialogue = true;
			JCMKNNOEONP().mouseUpTrigger = false;
			BADFKMEJOKE().StartConversation(1, BADFKMEJOKE().dialogueEvent, FLHBPHPKIML: true);
			JEEGOBGDLPE().dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Left)
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
				onlineDialogue.APGJMNHJNHN();
			}
		}
		targetWalkTo = Vector2.zero;
	}

	private void OOBDKJHKPEP()
	{
		if (OnlineManager.MasterOrOffline())
		{
			DBHNAJDDGDE();
		}
	}

	public void EBLFKBEMCKL()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(MIGKKKELOJO().dialogueEvent))
		{
			GJFMMOPOKGJ().barkDialogue = true;
			JCMKNNOEONP().mouseUpTrigger = true;
			DEGPIHEEFHJ().StartConversation(0, JEEGOBGDLPE().dialogueEvent, FLHBPHPKIML: true);
			MIGKKKELOJO().dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Down)
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

	public void ELBLAFPCJOL(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
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
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(HMOPLHDOPKK));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(BHKLMNJGLFN));
		walkTo.EHDKLBLKBEO();
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

	public void AELJHENDCBB(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
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
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(ODKNNOBCILE));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(DMKNBLCAJDB));
		walkTo.NOFKEMGPFEO();
	}

	private void LALGIJBMOMI()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			LCGCIOGIMHE();
		}
	}

	private void LCGCIOGIMHE()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.PAHDHACALOH();
		}
	}

	public void FABLJFLFDJA()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Dialogue System/Conversation/TavernClean/Entry/7/Dialogue Text");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
	}

	private void IJLCFABJEKH()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.IIMEFNIECLI(OEBNHGNJEJL: true);
		}
	}

	public void CLOEFOFKDFC()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(JEEGOBGDLPE().dialogueEvent))
		{
			BAKPBHPNKPB().barkDialogue = true;
			BADFKMEJOKE().mouseUpTrigger = false;
			DEGPIHEEFHJ().StartConversation(0, PDECKLKPKCG().dialogueEvent);
			EBAIHKJHCCA().dialogueEvent = null;
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
				onlineDialogue.APGJMNHJNHN();
			}
		}
		targetWalkTo = Vector2.zero;
	}

	private void OAGCLGKAMFM()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		OIFAGKBHCAP(targetWalkTo, endWalkDirection, AMEOKNOLILB: true);
	}

	private void INACOMEAINH()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		EFINHBLBFOI(targetWalkTo, endWalkDirection, AMEOKNOLILB: true);
	}

	public void EFPPOOJFNJO(string emotion)
	{
		MIGKKKELOJO().emotionsController.StartEmotion(emotion);
	}

	private void JMBOINMJEGI()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		MLACFFDPKPA(targetWalkTo, endWalkDirection, AMEOKNOLILB: true);
	}

	public void IJCLNLKKIAF()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(KHMEGDIABBF().dialogueEvent))
		{
			BADFKMEJOKE().barkDialogue = true;
			MIGKKKELOJO().mouseUpTrigger = false;
			DEGPIHEEFHJ().StartConversation(0, KHMEGDIABBF().dialogueEvent);
			DCAEBALADIM().dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Diagonal)
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

	private void LFBMFAHPBIM()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		BKJFOGKLPKK(targetWalkTo, endWalkDirection);
	}

	private void JLPDGFJJNAK()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		MCEJEEJFDKB(targetWalkTo, endWalkDirection, AMEOKNOLILB: true);
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
	public static RibellaNPC DEGPIHEEFHJ()
	{
		return IADEMLIIDPC;
	}

	private void EILPPGGCANE()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		FJGFEOIDCPC(targetWalkTo, endWalkDirection);
	}

	public void JIGIEIOLEBC()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("<color=#C65314>");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
	}

	[SpecialName]
	public static RibellaNPC CNDNOECMKME()
	{
		return IADEMLIIDPC;
	}

	private void DMKNBLCAJDB()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		FJGFEOIDCPC(targetWalkTo, endWalkDirection, AMEOKNOLILB: true);
	}

	[SpecialName]
	public static RibellaNPC GJFMMOPOKGJ()
	{
		return IADEMLIIDPC;
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

	[SpecialName]
	public static RibellaNPC BADFKMEJOKE()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static RibellaNPC KHMEGDIABBF()
	{
		return IADEMLIIDPC;
	}

	public void CPGDOFFNPLD(string emotion)
	{
		JEEGOBGDLPE().emotionsController.PIOCPGKDAOF(emotion);
	}

	private void CPGEGLBCPJG()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.GOACFCOOJLK(OEBNHGNJEJL: true);
		}
	}

	public void GJEIKBHJPCH()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Dialogue System/Conversation/Crowly_Introduce/Entry/19/Dialogue Text");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
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

	private void EOFEAJHOMDN()
	{
		if (OnlineManager.MasterOrOffline())
		{
			KJOBHAJDCOC();
		}
	}

	private void FHBDMCBANPF()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.PAHDHACALOH(OEBNHGNJEJL: true);
		}
	}

	public void IGKDGOCCEAJ(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
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
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(CAHIIFMAAEA));
		walkTo.PEHELKCIECB();
	}

	public void HCCFPBJNLKC(string emotion)
	{
		KHMEGDIABBF().emotionsController.EMMBEAHMDHE(emotion);
	}

	public void BKJFOGKLPKK(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
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
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(DLFBDNPEKAE));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(DMKNBLCAJDB));
		walkTo.PEHELKCIECB();
	}

	private void CAHIIFMAAEA()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		EFINHBLBFOI(targetWalkTo, endWalkDirection, AMEOKNOLILB: true);
	}

	public void BMLJMLBEAOO(string emotion)
	{
		DCAEBALADIM().emotionsController.GPLECKGJFKM(emotion);
	}

	public void IGJGKEJCBAC(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
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
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(ODKNNOBCILE));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(JMBOINMJEGI));
		walkTo.NOFKEMGPFEO();
	}

	public void ONMNKLPNCAH(string emotion)
	{
		MIGKKKELOJO().emotionsController.GPLECKGJFKM(emotion);
	}

	[SpecialName]
	public static RibellaNPC DCAEBALADIM()
	{
		return IADEMLIIDPC;
	}

	private void FPDPAJHNGHK()
	{
		SelectDialogueUI();
	}

	private void MKNKEDELDAK()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.GOACFCOOJLK(OEBNHGNJEJL: true);
		}
	}

	private void EDFFBEGFDDJ()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			DILMMFFGHMD();
		}
	}

	public void JHLPNDEKCPK()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Setup ");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		}
	}

	public void GFLNGGGPGCF()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(PDECKLKPKCG().dialogueEvent))
		{
			MOJDNGDNCCO().barkDialogue = true;
			DCAEBALADIM().mouseUpTrigger = false;
			MIGKKKELOJO().StartConversation(1, DEGPIHEEFHJ().dialogueEvent, FLHBPHPKIML: true);
			KHMEGDIABBF().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)7)
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

	private void BCKLFAGEKOJ()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.PAHDHACALOH();
		}
	}

	public void GAINAOFIGGH(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		disable = AMEOKNOLILB;
		walkTo.JDHMPOJKOLF(targetWalkTo, AHDHLIECIGH: false, NGAKHGJANLO: false);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(GFLNGGGPGCF));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(GJIJGACIOKK));
		walkTo.EHDKLBLKBEO();
	}

	public void JEPBPABEDGE()
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(JCMKNNOEONP().dialogueEvent))
		{
			MOJDNGDNCCO().barkDialogue = false;
			DEGPIHEEFHJ().mouseUpTrigger = false;
			GGFJGHHHEJC.StartConversation(0, BAKPBHPNKPB().dialogueEvent);
			JCMKNNOEONP().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)6)
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

	public void LPNFLPMGHBP(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		disable = AMEOKNOLILB;
		walkTo.GINPKMBGOFN(targetWalkTo, AHDHLIECIGH: false);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(EBLFKBEMCKL));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(EILPPGGCANE));
		walkTo.PEHELKCIECB();
	}

	public void MGEDICPPMHE(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		targetWalkTo = NKIAGIMMHIC;
		endWalkDirection = PFJDGBNBOAM;
		disable = AMEOKNOLILB;
		walkTo.CGFMBJFGLAG(targetWalkTo);
		walkTo.speed = speed;
		NPCWalkTo nPCWalkTo = walkTo;
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(IKOIKCHBBNG));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(ACOJHBFFFIF));
		walkTo.NOFKEMGPFEO();
	}

	[SpecialName]
	public static RibellaNPC JEEGOBGDLPE()
	{
		return IADEMLIIDPC;
	}

	public void MCEJEEJFDKB(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down, bool AMEOKNOLILB = false)
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
		nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(JEPBPABEDGE));
		NPCWalkTo nPCWalkTo2 = walkTo;
		nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(JMBOINMJEGI));
		walkTo.PEHELKCIECB();
	}

	private void NPMLFHDHJBE()
	{
		SelectDialogueUI(1);
	}
}
