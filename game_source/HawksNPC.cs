using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class HawksNPC : DialogueNPCBase
{
	private static HawksNPC IADEMLIIDPC;

	public float timeBarks;

	private int HKKKNMIKPCM;

	private string HDFMHCKKJJG = "";

	public static HawksNPC GGFJGHHHEJC => IADEMLIIDPC;

	public void ODJDFIPJJLN()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("cinemachine empty");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		}
	}

	public void IADNFPCNELJ()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Reverence");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
	}

	private void MKLIAMJFHOF()
	{
		SelectDialogueUI();
	}

	public void LNCFHJBJIGI()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("MainProgress");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
	}

	[SpecialName]
	public static HawksNPC FOPGLLMEEDE()
	{
		return IADEMLIIDPC;
	}

	public void LAANEEHHDLL(string emotion)
	{
		ICNFHJLLHGP().emotionsController.StartEmotion(emotion);
	}

	[SpecialName]
	public static HawksNPC BIIOFAHFNPA()
	{
		return IADEMLIIDPC;
	}

	public void HIKEKHKCPLM()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Lose");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
		}
	}

	public void BPDPPBDHJEL(string emotion)
	{
		OAPOJCODNCO().emotionsController.GPLECKGJFKM(emotion);
	}

	public void LMBJEGLHKBO()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Dialogue System/Conversation/Crowly_Standar/Entry/39/Dialogue Text");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
	}

	[SpecialName]
	public static HawksNPC ABDJJBFNLBJ()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static HawksNPC BNDNMBGJEKP()
	{
		return IADEMLIIDPC;
	}

	private void LFNENELHOGJ()
	{
		SelectDialogueUI(1);
	}

	public void StartEmotions(string emotion)
	{
		GGFJGHHHEJC.emotionsController.StartEmotion(emotion);
	}

	public void BOIOLKHGNPO(string emotion)
	{
		ABDJJBFNLBJ().emotionsController.GPLECKGJFKM(emotion);
	}

	[SpecialName]
	public static HawksNPC GJFMMOPOKGJ()
	{
		return IADEMLIIDPC;
	}

	public void IOEFJEOHPHJ()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("cleanVerb");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		}
	}

	public void HBEABOLLBAC()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("AceT_Quest");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
		}
	}

	public void LCLNGAAFKNB()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("UINextCategory");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
	}

	[SpecialName]
	public static HawksNPC MIGKKKELOJO()
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

	protected override void Awake()
	{
		base.Awake();
		IADEMLIIDPC = this;
	}

	public void IKFIADANHCE(string emotion)
	{
		KNOKBLFFNLM().emotionsController.EMMBEAHMDHE(emotion);
	}

	public void HFLEIKDDPCO(string emotion)
	{
		AAFOFNEHPLC().emotionsController.PIOCPGKDAOF(emotion);
	}

	public void IAFBFHALBJH(string emotion)
	{
		HFIJHDBKCIA().emotionsController.StartEmotion(emotion);
	}

	[SpecialName]
	public static HawksNPC AAFOFNEHPLC()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static HawksNPC LANAINBEMCM()
	{
		return IADEMLIIDPC;
	}

	public void JPPDLKEOFDF()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("ListViewEntry");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
	}

	private void HNEGFBCKIIJ()
	{
		SelectDialogueUI(1);
	}

	private void MLLADNLMIMP()
	{
		SelectDialogueUI(1);
	}

	public void JPBNMAJAKDA()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Items/item_name_608");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
	}

	public void FJPJHODBNIJ()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Items/item_description_1137");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		}
	}

	public void OBNBHKHHBIN()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Player2");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
	}

	private void GJMLHECPGBP()
	{
		SelectDialogueUI();
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

	private void EEKOJEKPIMP()
	{
		SelectDialogueUI();
	}

	public void LPEAJGIHMKI()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("]");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
	}

	[SpecialName]
	public static HawksNPC HFIJHDBKCIA()
	{
		return IADEMLIIDPC;
	}

	private void KJOJLHCDFPP()
	{
		SelectDialogueUI();
	}

	[SpecialName]
	public static HawksNPC OJJDNLEFNPJ()
	{
		return IADEMLIIDPC;
	}

	private void NPMLFHDHJBE()
	{
		SelectDialogueUI();
	}

	public void JECGJNDCMCG()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("ReceiveHit");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		}
	}

	public void GFNPDMNLNAP(string emotion)
	{
		ABDJJBFNLBJ().emotionsController.DCCNJLBLFGI(emotion);
	}

	[SpecialName]
	public static HawksNPC CNDNOECMKME()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static HawksNPC AFFGPMFKEFH()
	{
		return IADEMLIIDPC;
	}

	private void JLCFNPBBKEK()
	{
		SelectDialogueUI();
	}

	protected override void NJJCCIBDAPM()
	{
		barkDialogue = false;
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		dialogue.conversation = "Castle/Talks/Hawks";
	}

	public void EEPJLOBNIMM()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("{0} does not have a valid animation with the hash {1}. ");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
	}

	public void CAHCOJNEOFG(string emotion)
	{
		NHKAFANMEJC().emotionsController.EMMBEAHMDHE(emotion);
	}

	[SpecialName]
	public static HawksNPC NHKAFANMEJC()
	{
		return IADEMLIIDPC;
	}

	private void HOKBBFHGACN()
	{
		SelectDialogueUI();
	}

	[SpecialName]
	public static HawksNPC OFLELHKKNKC()
	{
		return IADEMLIIDPC;
	}

	private void JPOLFKMLHNH()
	{
		SelectDialogueUI(1);
	}

	public override DialogueNPCBase GetInstance()
	{
		return GGFJGHHHEJC;
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
	public static HawksNPC ICNFHJLLHGP()
	{
		return IADEMLIIDPC;
	}

	public void IHIDJOEEMBK()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Items/item_description_686");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
	}

	public void CPGDOFFNPLD(string emotion)
	{
		KNOKBLFFNLM().emotionsController.GPLECKGJFKM(emotion);
	}

	public void IJDLCMNAJFG()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Player2");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
	}

	public void IFICIKEFNJJ()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Farm/Buzz/Main");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
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

	private void OILHJENGGEL()
	{
		SelectDialogueUI();
	}

	public void LIMPDEFKJLO(string emotion)
	{
		KNOKBLFFNLM().emotionsController.DCCNJLBLFGI(emotion);
	}

	private void FKPNIHJGFBJ()
	{
		SelectDialogueUI();
	}

	public void MMBHJICBLND(string emotion)
	{
		ABDJJBFNLBJ().emotionsController.DCCNJLBLFGI(emotion);
	}

	public void AAOEFHODHHA(string emotion)
	{
		OFLELHKKNKC().emotionsController.PIOCPGKDAOF(emotion);
	}

	private void AEPBFPCHGPP()
	{
		SelectDialogueUI(1);
	}

	public void CJMLIEFAPKE()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Finished Success: ");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
	}

	public void IGNCCLNIIJM(string emotion)
	{
		BDAGIEIJOOG().emotionsController.StartEmotion(emotion);
	}

	[SpecialName]
	public static HawksNPC JFNOOMJMHCB()
	{
		return IADEMLIIDPC;
	}

	public void NAFCNHPFDDN()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("ReceiveSetBool");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
	}

	public void GHHNOBDPPEP(string emotion)
	{
		MIGKKKELOJO().emotionsController.NBFIDOGMLOK(emotion);
	}

	public void PPPADNMKKIO()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("TavernManager instance is null, cannot add open tavern blocker.");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
	}

	public void NIKCFNPEDCC()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("OnlineSceneLoad");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
	}

	private void IDHCFOCEPMD()
	{
		SelectDialogueUI(1);
	}

	[SpecialName]
	public static HawksNPC KNOKBLFFNLM()
	{
		return IADEMLIIDPC;
	}

	private void BGFCHEIOKOG()
	{
		SelectDialogueUI(1);
	}

	private void EACIGGOOKGD()
	{
		SelectDialogueUI(1);
	}

	[SpecialName]
	public static HawksNPC CHKMFEFOFKJ()
	{
		return IADEMLIIDPC;
	}

	public void KDCHBIFCIBO(string emotion)
	{
		OFLELHKKNKC().emotionsController.NBFIDOGMLOK(emotion);
	}

	[SpecialName]
	public static HawksNPC BDAGIEIJOOG()
	{
		return IADEMLIIDPC;
	}

	public void LCBCGKCFFPD()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("========================================================================================");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		}
	}

	[SpecialName]
	public static HawksNPC BGMJCCFNNDL()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static HawksNPC MLPCDJPLBAC()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static HawksNPC JHMAMLIPBNN()
	{
		return IADEMLIIDPC;
	}

	public void LGGHJHKCDGA()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("LE_19");
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
		OAPOJCODNCO().emotionsController.GPLECKGJFKM(emotion);
	}

	public void OEGOAAHCOIM()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable(" not found ingredient ");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
	}

	public void OJKEDMIKKCE(string emotion)
	{
		OFLELHKKNKC().emotionsController.PIOCPGKDAOF(emotion);
	}

	public void NFNMJMIOEFN()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Play");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
	}

	[SpecialName]
	public static HawksNPC OAPOJCODNCO()
	{
		return IADEMLIIDPC;
	}

	private void MFMMHDPGCBO()
	{
		SelectDialogueUI(1);
	}

	private void Start()
	{
		SelectDialogueUI();
	}

	private void PFLBPMIEKGF()
	{
		SelectDialogueUI(1);
	}

	private void DOHLOJOIHFO()
	{
		SelectDialogueUI(1);
	}

	private void HCEDMLJNOBL()
	{
		SelectDialogueUI();
	}

	public void GLDMOAPBCPJ()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Cof");
		if (((Result)(ref variable)).asInt == 0 && NewTutorialManager.CCCLOBIOMCL)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
	}

	public void JEBPGMHDCDC(string emotion)
	{
		LANAINBEMCM().emotionsController.StartEmotion(emotion);
	}

	public void LBEIJJCJLHB(string emotion)
	{
		MLPCDJPLBAC().emotionsController.NMAPMPBAGMM(emotion);
	}

	private void IMIONHLAKIH()
	{
		SelectDialogueUI(1);
	}

	public void GMNIFLOBFMK(string emotion)
	{
		ABDJJBFNLBJ().emotionsController.NBFIDOGMLOK(emotion);
	}

	public void JAGIEEJADMN(string emotion)
	{
		LANAINBEMCM().emotionsController.NBFIDOGMLOK(emotion);
	}
}
