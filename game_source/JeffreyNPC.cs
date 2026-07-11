using System;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class JeffreyNPC : DialogueNPCBase
{
	private static JeffreyNPC IADEMLIIDPC;

	public float timeBarks;

	private int HKKKNMIKPCM;

	private string HDFMHCKKJJG = "";

	public static JeffreyNPC GGFJGHHHEJC => IADEMLIIDPC;

	[SpecialName]
	public static JeffreyNPC DIHCEGINELM()
	{
		return IADEMLIIDPC;
	}

	private void PKHCLKIKMCD()
	{
		SelectDialogueUI(1);
	}

	public void CJFCMOBFFNF(string emotion)
	{
		CHPEMJMLDCN().emotionsController.DCCNJLBLFGI(emotion);
	}

	private void DNIPPGPKHLC()
	{
		SelectDialogueUI();
	}

	private void IMBHCJNIPGE()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		PPLNNNHHNMK(targetWalkTo, endWalkDirection);
	}

	private void JKCMIAOCEHG()
	{
		IMPOBDAAPHB();
	}

	private void ECPINCPHACH()
	{
		DPHMBAIBFJB();
	}

	private void DJADNFCFHAG()
	{
		SelectDialogueUI(1);
	}

	public void GACCDKPCDMP(string emotion)
	{
		MAAAKALBBEE().emotionsController.NBFIDOGMLOK(emotion);
	}

	[SpecialName]
	public static JeffreyNPC OPILDPFDFKJ()
	{
		return IADEMLIIDPC;
	}

	private void DLMIOKHMLOP()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.PAHDHACALOH();
		}
	}

	private void IPNKKDOIANF()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.BODEPFFAHLE(OEBNHGNJEJL: true);
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

	public void AJJIICECMDO()
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(JCMKNNOEONP().dialogueEvent))
		{
			JHKLPLPBKCI().barkDialogue = false;
			DHDOLCONMFJ().mouseUpTrigger = true;
			JCMKNNOEONP().StartConversation(1, DIHCEGINELM().dialogueEvent, FLHBPHPKIML: true);
			DIHCEGINELM().dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Left)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = (Direction)8;
		}
		if (disable)
		{
			content.SetActive(true);
			disable = true;
		}
		targetWalkTo = Vector2.zero;
	}

	private void LHPNDAMNECD()
	{
		JPOEIKICFFC();
	}

	private void BCIMMPHOOFM()
	{
		EFMPDEDCPED();
	}

	public void GLDMOAPBCPJ()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("<mark=#000000><alpha=#00> ");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		}
	}

	public void EJKODBLIOKD(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.HHDBMDMFEMP())
		{
			targetWalkTo = NKIAGIMMHIC;
			endWalkDirection = PFJDGBNBOAM;
			walkTo.GDGGABHLNOH(targetWalkTo, AHDHLIECIGH: true, NGAKHGJANLO: false);
			walkTo.speed = speed;
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(APGLLOHDPHO));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(OFEMFGCBLBH));
			walkTo.EHDKLBLKBEO();
		}
	}

	private void LOHAMDHOLDD()
	{
		SelectDialogueUI();
	}

	private void HFIFFJBIDKP()
	{
		JPOEIKICFFC();
	}

	private void JDICCBJJDNK()
	{
		DCNBJDFIOPG();
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

	public void FCBBLACAOHH()
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(JCMKNNOEONP().dialogueEvent))
		{
			JHKLPLPBKCI().barkDialogue = true;
			GGFJGHHHEJC.mouseUpTrigger = false;
			JCMKNNOEONP().StartConversation(0, DHDOLCONMFJ().dialogueEvent, FLHBPHPKIML: true);
			JHKLPLPBKCI().dialogueEvent = null;
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
		}
		targetWalkTo = Vector2.zero;
	}

	public void DIHKIFGMKPB()
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(HEKFJEKFMNO().dialogueEvent))
		{
			IFPLPBMCKLB().barkDialogue = true;
			OPILDPFDFKJ().mouseUpTrigger = true;
			ILMPOAEALPP().StartConversation(0, DHDOLCONMFJ().dialogueEvent, FLHBPHPKIML: true);
			PBJDFFEFMKM().dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Down)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = (Direction)7;
		}
		if (disable)
		{
			content.SetActive(true);
			disable = false;
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

	public void POBFFGPDKLE()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("ReceiveShopInfoLoad");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		}
	}

	public void GOLAJNDPNKP(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.HHDBMDMFEMP())
		{
			targetWalkTo = NKIAGIMMHIC;
			endWalkDirection = PFJDGBNBOAM;
			walkTo.KBEENHPEOAB(targetWalkTo);
			walkTo.speed = speed;
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(LKDCNMHNMCP));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(BNFLGDPJPJJ));
			walkTo.PEHELKCIECB();
		}
	}

	public void HCCFPBJNLKC(string emotion)
	{
		JCMKNNOEONP().emotionsController.NMAPMPBAGMM(emotion);
	}

	public void KNIBOAEFGPJ()
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(DEGPIHEEFHJ().dialogueEvent))
		{
			DEGPIHEEFHJ().barkDialogue = false;
			DEGPIHEEFHJ().mouseUpTrigger = false;
			OLHBLKIAFOM().StartConversation(1, JHKLPLPBKCI().dialogueEvent);
			HEKFJEKFMNO().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)8)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = (Direction)7;
		}
		if (disable)
		{
			content.SetActive(true);
			disable = true;
		}
		targetWalkTo = Vector2.zero;
	}

	private void BNFLGDPJPJJ()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		Walk(targetWalkTo, endWalkDirection);
	}

	public void CAAIEPEHFDI(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.HHDBMDMFEMP())
		{
			targetWalkTo = NKIAGIMMHIC;
			endWalkDirection = PFJDGBNBOAM;
			walkTo.JJDCANFBFMK(targetWalkTo);
			walkTo.speed = speed;
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(HEEOHKBPMAI));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(BIIIHFOBADE));
			walkTo.NOFKEMGPFEO();
		}
	}

	private void GKAALFJNHFA()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		GHODMKBECBD(targetWalkTo, endWalkDirection);
	}

	private void FixedUpdate()
	{
		DIKPOHPGNLG();
	}

	private void CPBPGLIBJNP()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		LKFGGKOMJJC(targetWalkTo, endWalkDirection);
	}

	private void CFALCMFKOKO()
	{
		OOPMLMCDOPA();
	}

	public void LCLNGAAFKNB()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		}
	}

	private void PDMHOEICGAD()
	{
		JPOEIKICFFC();
	}

	public void HFDCAMKIKNL()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("itemBlackWort");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
	}

	private void GHBEMCOFHOC()
	{
		DIPFMNJEKBI();
	}

	public void CODGAACCGGB(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.ClientOnline())
		{
			targetWalkTo = NKIAGIMMHIC;
			endWalkDirection = PFJDGBNBOAM;
			walkTo.BDIKOLNFKGD(targetWalkTo, AHDHLIECIGH: false);
			walkTo.speed = speed;
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(HEEOHKBPMAI));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(JMLELHEJBPJ));
			walkTo.PEHELKCIECB();
		}
	}

	public void IADNFPCNELJ()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Items/item_name_1121");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
	}

	public void GHODMKBECBD(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.HHDBMDMFEMP())
		{
			targetWalkTo = NKIAGIMMHIC;
			endWalkDirection = PFJDGBNBOAM;
			walkTo.JDHMPOJKOLF(targetWalkTo, AHDHLIECIGH: false);
			walkTo.speed = speed;
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(FNJODLOADKA));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(IMBHCJNIPGE));
			walkTo.EHDKLBLKBEO();
		}
	}

	private void OOPMLMCDOPA()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.GOACFCOOJLK(OEBNHGNJEJL: true);
		}
	}

	public void MFGLEIGBFFF()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable(" photon awake");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		}
	}

	public void BPDPPBDHJEL(string emotion)
	{
		OPILDPFDFKJ().emotionsController.PIOCPGKDAOF(emotion);
	}

	public void NODKOAHMPFM(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.ClientOnline())
		{
			targetWalkTo = NKIAGIMMHIC;
			endWalkDirection = PFJDGBNBOAM;
			walkTo.EJPGFOEDPBG(targetWalkTo, AHDHLIECIGH: false, NGAKHGJANLO: false);
			walkTo.speed = speed;
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(FNJODLOADKA));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(CPBPGLIBJNP));
			walkTo.EHDKLBLKBEO();
		}
	}

	protected override void NJJCCIBDAPM()
	{
		barkDialogue = false;
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
	}

	public void HHBLDGKJACK()
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(DEGPIHEEFHJ().dialogueEvent))
		{
			ILMPOAEALPP().barkDialogue = true;
			OLHBLKIAFOM().mouseUpTrigger = true;
			ILMPOAEALPP().StartConversation(0, DEGPIHEEFHJ().dialogueEvent);
			DIHCEGINELM().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)7)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = Direction.Diagonal;
		}
		if (disable)
		{
			content.SetActive(false);
			disable = true;
		}
		targetWalkTo = Vector2.zero;
	}

	public void GLJBJIIMAMO()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Send next game date as a host ");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		}
	}

	public void FFAHHKEJGJN()
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(CHPEMJMLDCN().dialogueEvent))
		{
			GGFJGHHHEJC.barkDialogue = true;
			MAAAKALBBEE().mouseUpTrigger = true;
			ILMPOAEALPP().StartConversation(0, OPILDPFDFKJ().dialogueEvent, FLHBPHPKIML: true);
			MAAAKALBBEE().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)5)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = (Direction)7;
		}
		if (disable)
		{
			content.SetActive(true);
			disable = true;
		}
		targetWalkTo = Vector2.zero;
	}

	private void GPLBFGENJDM()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.IIMEFNIECLI(OEBNHGNJEJL: true);
		}
	}

	private void JMLELHEJBPJ()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		NODKOAHMPFM(targetWalkTo, endWalkDirection);
	}

	public void LIMPDEFKJLO(string emotion)
	{
		DHDOLCONMFJ().emotionsController.DCCNJLBLFGI(emotion);
	}

	private void NDNBDEHFFJF()
	{
		SelectDialogueUI(1);
	}

	public void HEEOHKBPMAI()
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(POAGAIBEFBF().dialogueEvent))
		{
			MAAAKALBBEE().barkDialogue = false;
			PBJDFFEFMKM().mouseUpTrigger = true;
			OPILDPFDFKJ().StartConversation(1, POAGAIBEFBF().dialogueEvent, FLHBPHPKIML: true);
			DIHCEGINELM().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)8)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = Direction.Left;
		}
		if (disable)
		{
			content.SetActive(false);
			disable = false;
		}
		targetWalkTo = Vector2.zero;
	}

	private void JPOEIKICFFC()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.IIMEFNIECLI(OEBNHGNJEJL: true);
		}
	}

	public void FIKLNLMANCH()
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(OLHBLKIAFOM().dialogueEvent))
		{
			JHKLPLPBKCI().barkDialogue = false;
			JCMKNNOEONP().mouseUpTrigger = false;
			CHPEMJMLDCN().StartConversation(0, ILMPOAEALPP().dialogueEvent, FLHBPHPKIML: true);
			JHKLPLPBKCI().dialogueEvent = null;
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
		}
		targetWalkTo = Vector2.zero;
	}

	public void GINJDLKFNMB(string emotion)
	{
		IFPLPBMCKLB().emotionsController.DCCNJLBLFGI(emotion);
	}

	public void PPLNNNHHNMK(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.ClientOnline())
		{
			targetWalkTo = NKIAGIMMHIC;
			endWalkDirection = PFJDGBNBOAM;
			walkTo.JDHMPOJKOLF(targetWalkTo, AHDHLIECIGH: false);
			walkTo.speed = speed;
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(KPMCGMJJBEA));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(IMBHCJNIPGE));
			walkTo.EHDKLBLKBEO();
		}
	}

	[SpecialName]
	public static JeffreyNPC OLHBLKIAFOM()
	{
		return IADEMLIIDPC;
	}

	private void OBBNJFKHANB()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.PLAGPJAKCKL(OEBNHGNJEJL: true);
		}
	}

	public void BKOLAAFOBLF()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Boots_L");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
		}
	}

	private void IOOOOOECBNP()
	{
		DIKPOHPGNLG();
	}

	private void FKCOPHFELKD()
	{
		BMOBBJOGBJE();
	}

	private void BOKOLOCCLEN()
	{
		DPHMBAIBFJB();
	}

	private void EEKOJEKPIMP()
	{
		SelectDialogueUI();
	}

	public void MAOACOAHDHF(string emotion)
	{
		GGFJGHHHEJC.emotionsController.NBFIDOGMLOK(emotion);
	}

	public void JHCONAJDBHG(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.HHDBMDMFEMP())
		{
			targetWalkTo = NKIAGIMMHIC;
			endWalkDirection = PFJDGBNBOAM;
			walkTo.CGFMBJFGLAG(targetWalkTo, AHDHLIECIGH: true, NGAKHGJANLO: false);
			walkTo.speed = speed;
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(DIHKIFGMKPB));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(GKAALFJNHFA));
			walkTo.PEHELKCIECB();
		}
	}

	private void EFMPDEDCPED()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.BODEPFFAHLE(OEBNHGNJEJL: true);
		}
	}

	private void ACOJHBFFFIF()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		Walk(targetWalkTo, endWalkDirection);
	}

	private void DBHNAJDDGDE()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.PAHDHACALOH();
		}
	}

	[SpecialName]
	public static JeffreyNPC PBJDFFEFMKM()
	{
		return IADEMLIIDPC;
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

	[SpecialName]
	public static JeffreyNPC JHKLPLPBKCI()
	{
		return IADEMLIIDPC;
	}

	private void BIIIHFOBADE()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		PPLNNNHHNMK(targetWalkTo, endWalkDirection);
	}

	public void LKDCNMHNMCP()
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(OPILDPFDFKJ().dialogueEvent))
		{
			JHKLPLPBKCI().barkDialogue = false;
			JHKLPLPBKCI().mouseUpTrigger = false;
			PBJDFFEFMKM().StartConversation(1, MAAAKALBBEE().dialogueEvent, FLHBPHPKIML: true);
			GGFJGHHHEJC.dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)6)
		{
			animationBase.SetDirection(endWalkDirection);
			endWalkDirection = (Direction)5;
		}
		if (disable)
		{
			content.SetActive(true);
			disable = false;
		}
		targetWalkTo = Vector2.zero;
	}

	public void ONMNKLPNCAH(string emotion)
	{
		CHPEMJMLDCN().emotionsController.NMAPMPBAGMM(emotion);
	}

	public void DLAKKOCDNBI(string emotion)
	{
		JHKLPLPBKCI().emotionsController.NMAPMPBAGMM(emotion);
	}

	private void HNEGFBCKIIJ()
	{
		SelectDialogueUI(1);
	}

	private void ODKGLIDMCNP()
	{
		SelectDialogueUI(1);
	}

	public void PGMPDGONPLL()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable(" seconds.");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
	}

	private void LPDGIHLLJLO()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		GOLAJNDPNKP(targetWalkTo, endWalkDirection);
	}

	protected override void OnConversationStart(Transform actor)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		base.OnConversationStart(actor);
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		HKKKNMIKPCM = ((Result)(ref variable)).asInt;
	}

	private void MENCIOFBFIE()
	{
		JPOEIKICFFC();
	}

	private void Start()
	{
		SelectDialogueUI();
	}

	private void KLDIIKJAKIB()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		GHODMKBECBD(targetWalkTo, endWalkDirection);
	}

	public void FNJODLOADKA()
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(PBJDFFEFMKM().dialogueEvent))
		{
			ILMPOAEALPP().barkDialogue = true;
			DEGPIHEEFHJ().mouseUpTrigger = false;
			JCMKNNOEONP().StartConversation(0, MAAAKALBBEE().dialogueEvent);
			ILMPOAEALPP().dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Left)
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

	public void APGLLOHDPHO()
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(CHPEMJMLDCN().dialogueEvent))
		{
			MAAAKALBBEE().barkDialogue = true;
			MAAAKALBBEE().mouseUpTrigger = false;
			DIHCEGINELM().StartConversation(0, GGFJGHHHEJC.dialogueEvent, FLHBPHPKIML: true);
			GIKECEGLFOH().dialogueEvent = null;
		}
		if (endWalkDirection != Direction.Down)
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

	private void NONECPIELOP()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		CAAIEPEHFDI(targetWalkTo, endWalkDirection);
	}

	public void POCIILOJOJD(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.HHDBMDMFEMP())
		{
			targetWalkTo = NKIAGIMMHIC;
			endWalkDirection = PFJDGBNBOAM;
			walkTo.CGFMBJFGLAG(targetWalkTo, AHDHLIECIGH: true, NGAKHGJANLO: false);
			walkTo.speed = speed;
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(OnActionComplete));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(OFEMFGCBLBH));
			walkTo.EHDKLBLKBEO();
		}
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
	public static JeffreyNPC DHDOLCONMFJ()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static JeffreyNPC IFPLPBMCKLB()
	{
		return IADEMLIIDPC;
	}

	public override DialogueNPCBase GetInstance()
	{
		return GGFJGHHHEJC;
	}

	[SpecialName]
	public static JeffreyNPC HEKFJEKFMNO()
	{
		return IADEMLIIDPC;
	}

	private void BMOBBJOGBJE()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.PAHDHACALOH(OEBNHGNJEJL: true);
		}
	}

	private void LNPFFJBJHJM()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.PAHDHACALOH(OEBNHGNJEJL: true);
		}
	}

	public void FIKPFMFAIJJ()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("ReceiveBirdMessage");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
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

	private void FAFLOANGNLE()
	{
		DCNBJDFIOPG();
	}

	private void MKNKEDELDAK()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.BODEPFFAHLE();
		}
	}

	private void OHJIFGGCDAN()
	{
		DJEEOPKPAIK();
	}

	private void AGCPLBKPFPE()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		JHCONAJDBHG(targetWalkTo, endWalkDirection);
	}

	public void EEBOKKANBEM(string emotion)
	{
		ILMPOAEALPP().emotionsController.DCCNJLBLFGI(emotion);
	}

	public void LGGHJHKCDGA()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("OnFloor");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		}
	}

	public void LLGDPOAGOJI(string emotion)
	{
		GGFJGHHHEJC.emotionsController.GPLECKGJFKM(emotion);
	}

	private void MAOJJPECDAG()
	{
		SelectDialogueUI();
	}

	private void OLDDEAJMHNI()
	{
		SelectDialogueUI();
	}

	public void BFBEEAMKPID(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.ClientOnline())
		{
			targetWalkTo = NKIAGIMMHIC;
			endWalkDirection = PFJDGBNBOAM;
			walkTo.GLHBJNDMIDC(targetWalkTo, AHDHLIECIGH: false, NGAKHGJANLO: false);
			walkTo.speed = speed;
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(FFAHHKEJGJN));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(ACOJHBFFFIF));
			walkTo.EHDKLBLKBEO();
		}
	}

	public void BLACDDJKJAK(string emotion)
	{
		GGFJGHHHEJC.emotionsController.PIOCPGKDAOF(emotion);
	}

	public void MONKBNPGGIG(string emotion)
	{
		JCMKNNOEONP().emotionsController.StartEmotion(emotion);
	}

	private void IMPOBDAAPHB()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.GOACFCOOJLK();
		}
	}

	private void EDFFBEGFDDJ()
	{
		IPNKKDOIANF();
	}

	private void EOFEAJHOMDN()
	{
		EFMPDEDCPED();
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

	public void MHHPCCNNNOJ()
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
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
		}
	}

	private void GNMMELIJKML()
	{
		SelectDialogueUI(1);
	}

	public void KPMCGMJJBEA()
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(HEKFJEKFMNO().dialogueEvent))
		{
			DIHCEGINELM().barkDialogue = false;
			CHPEMJMLDCN().mouseUpTrigger = true;
			CHPEMJMLDCN().StartConversation(1, MAAAKALBBEE().dialogueEvent);
			CHPEMJMLDCN().dialogueEvent = null;
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
		}
		targetWalkTo = Vector2.zero;
	}

	private void HBBGCIKINDG()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.PLAGPJAKCKL();
		}
	}

	[SpecialName]
	public static JeffreyNPC JCMKNNOEONP()
	{
		return IADEMLIIDPC;
	}

	public void LKFGGKOMJJC(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.ClientOnline())
		{
			targetWalkTo = NKIAGIMMHIC;
			endWalkDirection = PFJDGBNBOAM;
			walkTo.FNNPPBDFBCI(targetWalkTo, AHDHLIECIGH: true, NGAKHGJANLO: false);
			walkTo.speed = speed;
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(APGLLOHDPHO));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(BIIIHFOBADE));
			walkTo.PEHELKCIECB();
		}
	}

	[SpecialName]
	public static JeffreyNPC ILMPOAEALPP()
	{
		return IADEMLIIDPC;
	}

	private void LONNPEINNAD()
	{
		OOPMLMCDOPA();
	}

	protected override void Awake()
	{
		base.Awake();
		IADEMLIIDPC = this;
	}

	private void ENOEOGABPIC()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		GGOCPPNOGCD(targetWalkTo, endWalkDirection);
	}

	[SpecialName]
	public static JeffreyNPC DEGPIHEEFHJ()
	{
		return IADEMLIIDPC;
	}

	private void BDCHLODNJAN()
	{
		OBBNJFKHANB();
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
	public static JeffreyNPC CHPEMJMLDCN()
	{
		return IADEMLIIDPC;
	}

	public void KCINDOCIKAI()
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(DHDOLCONMFJ().dialogueEvent))
		{
			DIHCEGINELM().barkDialogue = false;
			ILMPOAEALPP().mouseUpTrigger = true;
			DEGPIHEEFHJ().StartConversation(1, HEKFJEKFMNO().dialogueEvent);
			CHPEMJMLDCN().dialogueEvent = null;
		}
		if (endWalkDirection != (Direction)6)
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

	[SpecialName]
	public static JeffreyNPC GIKECEGLFOH()
	{
		return IADEMLIIDPC;
	}

	private void GHPFCKGMLDA()
	{
		SelectDialogueUI(1);
	}

	public void Walk(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.ClientOnline())
		{
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
	}

	private void DCNBJDFIOPG()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.GOACFCOOJLK(OEBNHGNJEJL: true);
		}
	}

	public void GGOCPPNOGCD(Vector2 NKIAGIMMHIC, Direction PFJDGBNBOAM = Direction.Down)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		if (!OnlineManager.ClientOnline())
		{
			targetWalkTo = NKIAGIMMHIC;
			endWalkDirection = PFJDGBNBOAM;
			walkTo.JJDCANFBFMK(targetWalkTo, AHDHLIECIGH: false);
			walkTo.speed = speed;
			NPCWalkTo nPCWalkTo = walkTo;
			nPCWalkTo.OnActionComplete = (Action)Delegate.Combine(nPCWalkTo.OnActionComplete, new Action(HEEOHKBPMAI));
			NPCWalkTo nPCWalkTo2 = walkTo;
			nPCWalkTo2.OnFailStart = (Action)Delegate.Combine(nPCWalkTo2.OnFailStart, new Action(NONECPIELOP));
			walkTo.NOFKEMGPFEO();
		}
	}

	private void DIPFMNJEKBI()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.GOACFCOOJLK(OEBNHGNJEJL: true);
		}
	}

	private void NLOEGNNLKKE()
	{
		DIPFMNJEKBI();
	}

	public void StartEmotions(string emotion)
	{
		GGFJGHHHEJC.emotionsController.StartEmotion(emotion);
	}

	[SpecialName]
	public static JeffreyNPC POAGAIBEFBF()
	{
		return IADEMLIIDPC;
	}

	public void HIKEKHKCPLM()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Items/item_description_605");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
	}

	public void CAKMJKDLEOB()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable(" => ");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
		}
	}

	private void OCBPECIEPMI()
	{
		MKNKEDELDAK();
	}

	public void BCDJBMCDNBP()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("DiscusionMineros/Main");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
	}

	private void OIBDBLCLACB()
	{
		SelectDialogueUI();
	}

	public void IAKNIJJHCHP()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Near");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
	}

	private void FDCPJNLLNGN()
	{
		DPHMBAIBFJB();
	}

	public void GMNIFLOBFMK(string emotion)
	{
		ILMPOAEALPP().emotionsController.GPLECKGJFKM(emotion);
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

	private void DOHLOJOIHFO()
	{
		SelectDialogueUI(1);
	}

	private void HEHNBONKMGJ()
	{
		SelectDialogueUI();
	}

	private void ACLFJCPNBFB()
	{
		JPOEIKICFFC();
	}

	private void MDLHDGDLANK()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		BFBEEAMKPID(targetWalkTo, endWalkDirection);
	}

	private void OFEMFGCBLBH()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		PPLNNNHHNMK(targetWalkTo, endWalkDirection);
	}

	public void FJOAKDCFMAG()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("LE_9");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
		}
	}

	public void BMNFEAHLBJB(string emotion)
	{
		POAGAIBEFBF().emotionsController.GPLECKGJFKM(emotion);
	}

	public void CJEECBDICOK()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("path not found");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
	}

	[SpecialName]
	public static JeffreyNPC MAAAKALBBEE()
	{
		return IADEMLIIDPC;
	}

	private void BCKLFAGEKOJ()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (targetWalkTo != Vector2.zero)
		{
			walkTo.GOACFCOOJLK(OEBNHGNJEJL: true);
		}
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

	private void KJBIDNLHOMD()
	{
		SelectDialogueUI();
	}

	private void KBCFNPHJMJO()
	{
		LNPFFJBJHJM();
	}

	public void HFLEIKDDPCO(string emotion)
	{
		JHKLPLPBKCI().emotionsController.EMMBEAHMDHE(emotion);
	}
}
