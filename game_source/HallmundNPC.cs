using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class HallmundNPC : DialogueNPCBase
{
	private static HallmundNPC IADEMLIIDPC;

	public float timeBarks;

	private int HKKKNMIKPCM;

	private string HDFMHCKKJJG = "LE_19";

	public static HallmundNPC GGFJGHHHEJC => IADEMLIIDPC;

	private void Start()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("LE_19");
		if (((Result)(ref variable)).asInt == 0)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
	}

	private void BELOIFKPNMM()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Items/item_description_635");
		if (((Result)(ref variable)).asInt == 0)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		}
	}

	public void HCCFPBJNLKC(string emotion)
	{
		MPJJAPCFENH().emotionsController.NBFIDOGMLOK(emotion);
	}

	public void KDCHBIFCIBO(string emotion)
	{
		BAKPBHPNKPB().emotionsController.DCCNJLBLFGI(emotion);
	}

	public void AAMMPNHILOM()
	{
		ToolUpgradeUI.COIEMAJLHAM(KIALFDOKABP().EHHOHCPHAAO).OpenUI();
	}

	public void KGCFJBOAOID()
	{
		ToolUpgradeManager.instance.GDPPBPAILEF();
	}

	private void OILHJENGGEL()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("qualityWater");
		if (((Result)(ref variable)).asInt == 0)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		}
	}

	public void NACAGDEBFBL()
	{
		ShopUI.IEABDMDELFO(DCAEBALADIM().EHHOHCPHAAO).shop = shop;
		ShopUI.EAONFFENMCE(OFLELHKKNKC().EHHOHCPHAAO).OpenUI();
	}

	public void DNHIHIIOINE(string emotion)
	{
		ACPHFLBLJAA().emotionsController.EMMBEAHMDHE(emotion);
	}

	public void OLONNMHBENO()
	{
		ToolUpgradeManager.instance.IOKBEDIDLDO(CDPAMNIPPEC: true);
	}

	public void GHNJPPNCFDD()
	{
		ToolUpgradeUI.MIFFCOMDIEE(EKDNJDJHONF().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	private void GHPFCKGMLDA()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("yyyy-MM-dd_HH-mm-ss");
		if (((Result)(ref variable)).asInt == 0)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
	}

	private void APEIPGIHEKP()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Bouncer");
		if (((Result)(ref variable)).asInt == 0)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
	}

	private void JECHMEFJABD()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Walk");
		if (((Result)(ref variable)).asInt == 0)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
	}

	[SpecialName]
	public static HallmundNPC MPJJAPCFENH()
	{
		return IADEMLIIDPC;
	}

	public void INKEIEJFKHM()
	{
		ToolUpgradeManager.instance.APOFGEOGEFC(CDPAMNIPPEC: true);
	}

	public void GLALAEICJHF()
	{
		ToolUpgradeManager.instance.GDPPBPAILEF(CDPAMNIPPEC: true);
	}

	private void HHLBFDBHDMC()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable(": ");
		if (((Result)(ref variable)).asInt == 0)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
	}

	public void JABJGHAKJJB()
	{
		ToolUpgradeUI.LAMFGLIGLOP(ACPHFLBLJAA().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	public void ALMHNMBHEPP()
	{
		ShopUI.IEABDMDELFO(ACPHFLBLJAA().EHHOHCPHAAO).shop = shop;
		ShopUI.IEKODILKIHJ(KIALFDOKABP().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	protected override void OnConversationStart(Transform actor)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		base.OnConversationStart(actor);
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		HKKKNMIKPCM = ((Result)(ref variable)).asInt;
	}

	public void NDKHAPCBIMF()
	{
		ShopUI.Get(MPJJAPCFENH().EHHOHCPHAAO).shop = shop;
		ShopUI.EAONFFENMCE(AFFGPMFKEFH().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	public void FBBPLNKEFJE()
	{
		ToolUpgradeManager.instance.KGCFJBOAOID();
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

	public void MPEKNBHGAIE()
	{
		ToolUpgradeUI.MIAOGLENOHL(BDAGIEIJOOG().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	[SpecialName]
	public static HallmundNPC KIALFDOKABP()
	{
		return IADEMLIIDPC;
	}

	public void HEALBINHLIB()
	{
		ToolUpgradeUI.MIFFCOMDIEE(KIALFDOKABP().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	public void PJGJGBEADMB(string emotion)
	{
		NEFIEJALANL().emotionsController.StartEmotion(emotion);
	}

	protected override void NJJCCIBDAPM()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		barkDialogue = false;
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		if (EventsManager.IsDone(EventsManager.EventType.HotBath))
		{
			Result variable = DialogueLua.GetVariable("MineState");
			if (((Result)(ref variable)).asInt < 2)
			{
				DialogueLua.SetVariable("MineState", (object)2);
			}
		}
		if (ToolUpgradeManager.instance.canCollect)
		{
			dialogue.conversation = "City/Hallmund/Talk/GiveTool";
		}
		else if (Item.MLBOMGHINCA(ToolUpgradeManager.instance.item, null))
		{
			dialogue.conversation = "City/Hallmund/Talk/ForgeTool";
		}
		else
		{
			dialogue.conversation = "City/Hallmund/Stand";
		}
	}

	public void CBIMHLGDJFN()
	{
		ToolUpgradeUI.LAMFGLIGLOP(PFHFIJDDOME().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	protected override void Awake()
	{
		base.Awake();
		IADEMLIIDPC = this;
	}

	[SpecialName]
	public static HallmundNPC KNOKBLFFNLM()
	{
		return IADEMLIIDPC;
	}

	public void BPJMGLLMHDL()
	{
		ToolUpgradeUI.MIFFCOMDIEE(EKDNJDJHONF().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	public void LJFLICPLPAE(string emotion)
	{
		OFLELHKKNKC().emotionsController.PIOCPGKDAOF(emotion);
	}

	public void LGMDDMFKIAD(string emotion)
	{
		AFFGPMFKEFH().emotionsController.PIOCPGKDAOF(emotion);
	}

	[SpecialName]
	public static HallmundNPC BAKPBHPNKPB()
	{
		return IADEMLIIDPC;
	}

	public void LFAPOMEEBJI()
	{
		ShopUI.AGNKKAPMHLN(KIALFDOKABP().EHHOHCPHAAO).shop = shop;
		ShopUI.JCBPABNCBPI(AFFGPMFKEFH().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	public void IDPKDDHFGBF()
	{
		ShopUI.EAONFFENMCE(BAKPBHPNKPB().EHHOHCPHAAO).shop = shop;
		ShopUI.JCBPABNCBPI(KNOKBLFFNLM().EHHOHCPHAAO).OpenUI();
	}

	public void CMKDGOODNHB()
	{
		ToolUpgradeManager.instance.APOFGEOGEFC(CDPAMNIPPEC: true);
	}

	public void PKMIELNPJCF()
	{
		ShopUI.FKFNANNBIAM(DCAEBALADIM().EHHOHCPHAAO).shop = shop;
		ShopUI.JCBPABNCBPI(AFFGPMFKEFH().EHHOHCPHAAO).OpenUI();
	}

	public void EOPOJCGNAAC()
	{
		ToolUpgradeUI.LAMFGLIGLOP(BAKPBHPNKPB().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	[SpecialName]
	public static HallmundNPC BDAGIEIJOOG()
	{
		return IADEMLIIDPC;
	}

	public void BPGJOFGCCIN(string emotion)
	{
		PFHFIJDDOME().emotionsController.PIOCPGKDAOF(emotion);
	}

	public void OpenUpgradeToolUI()
	{
		ToolUpgradeUI.Get(GGFJGHHHEJC.EHHOHCPHAAO).OpenUI();
	}

	public void LLKAMENMGLA()
	{
		ToolUpgradeManager.instance.LBECHJECPIF();
	}

	public void JJJMGKMNECG()
	{
		ShopUI.EAONFFENMCE(MPJJAPCFENH().EHHOHCPHAAO).shop = shop;
		ShopUI.JCBPABNCBPI(DCAEBALADIM().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	public void LILHBLEFJMM(string emotion)
	{
		ACPHFLBLJAA().emotionsController.NBFIDOGMLOK(emotion);
	}

	public void MFAFAHGLEHE()
	{
		ToolUpgradeManager.instance.LBOFAHOCMKD(CDPAMNIPPEC: true);
	}

	public void MPHNHNACBCO()
	{
		ToolUpgradeManager.instance.FMACNNLHMGH();
	}

	public void AKNIJKAKKFD(string emotion)
	{
		OFLELHKKNKC().emotionsController.StartEmotion(emotion);
	}

	public void PNBGLADEGME()
	{
		ShopUI.EAONFFENMCE(EKDNJDJHONF().EHHOHCPHAAO).shop = shop;
		ShopUI.AGNKKAPMHLN(PFHFIJDDOME().EHHOHCPHAAO).OpenUI();
	}

	public void OpenShop()
	{
		ShopUI.Get(GGFJGHHHEJC.EHHOHCPHAAO).shop = shop;
		ShopUI.Get(GGFJGHHHEJC.EHHOHCPHAAO).OpenUI();
	}

	public void GiveUpgradeTool()
	{
		ToolUpgradeManager.instance.GiveUpgradeTool(CDPAMNIPPEC: true);
	}

	public void OICKOMOCGOC()
	{
		ToolUpgradeManager.instance.JBDCEBBPBLH(CDPAMNIPPEC: true);
	}

	public void LDGGCLHPCFO()
	{
		ToolUpgradeManager.instance.AEDJHIGHFJM(CDPAMNIPPEC: true);
	}

	public void BJCJPLCEJCG()
	{
		ShopUI.Get(BDAGIEIJOOG().EHHOHCPHAAO).shop = shop;
		ShopUI.Get(GGFJGHHHEJC.EHHOHCPHAAO).IDLAGJNLPJL();
	}

	[SpecialName]
	public static HallmundNPC NEFIEJALANL()
	{
		return IADEMLIIDPC;
	}

	public void PLPDCAIPCHI()
	{
		ToolUpgradeManager.instance.IFLKLKCKJMJ(CDPAMNIPPEC: true);
	}

	[SpecialName]
	public static HallmundNPC PFHFIJDDOME()
	{
		return IADEMLIIDPC;
	}

	public void ADJJJHNJPKD()
	{
		ToolUpgradeUI.MIFFCOMDIEE(AFFGPMFKEFH().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	public void FACKKGAODPO(string emotion)
	{
		BAKPBHPNKPB().emotionsController.GPLECKGJFKM(emotion);
	}

	public void LMEMMBGFPII(string emotion)
	{
		AFFGPMFKEFH().emotionsController.GPLECKGJFKM(emotion);
	}

	private void HBMDEHPHAPF()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("BuildMode_ExitAndSave");
		if (((Result)(ref variable)).asInt == 0)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
	}

	private void CFIIEJDJFPB()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Dialogue System/Conversation/Crowly_Barks_Bye/Entry/3/Dialogue Text");
		if (((Result)(ref variable)).asInt == 0)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
	}

	[SpecialName]
	public static HallmundNPC DCAEBALADIM()
	{
		return IADEMLIIDPC;
	}

	private void CAIJLMJBMLA()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable(")...");
		if (((Result)(ref variable)).asInt == 0)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
	}

	public void BPDPPBDHJEL(string emotion)
	{
		ACPHFLBLJAA().emotionsController.EMMBEAHMDHE(emotion);
	}

	public void NIGNDFGMJFM()
	{
		ToolUpgradeUI.NALKHGMLALJ(BDAGIEIJOOG().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	[SpecialName]
	public static HallmundNPC OFLELHKKNKC()
	{
		return IADEMLIIDPC;
	}

	public override DialogueNPCBase GetInstance()
	{
		return GGFJGHHHEJC;
	}

	private void OKAPGNGLOHO()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("talentLagerAdv.");
		if (((Result)(ref variable)).asInt == 0)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
	}

	[SpecialName]
	public static HallmundNPC ACPHFLBLJAA()
	{
		return IADEMLIIDPC;
	}

	public void GCIBPFCAKLD()
	{
		ToolUpgradeManager.instance.JBDCEBBPBLH(CDPAMNIPPEC: true);
	}

	public void APPNAMFJDOA(string emotion)
	{
		MPJJAPCFENH().emotionsController.PIOCPGKDAOF(emotion);
	}

	private void BDMEBLBLPIA()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("ReceiveBuildingStyle");
		if (((Result)(ref variable)).asInt == 0)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		}
	}

	private void NKDFMFFDGKC()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Perks/playerPerk_description_");
		if (((Result)(ref variable)).asInt == 0)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
	}

	private void NNBIAIMPNGL()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("itemAromaHopsSeeds");
		if (((Result)(ref variable)).asInt == 0)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
	}

	private void EBNENBFLEKB()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("end conversation");
		if (((Result)(ref variable)).asInt == 0)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
	}

	public void KLLFAKBBBJC()
	{
		ShopUI.Get(KIALFDOKABP().EHHOHCPHAAO).shop = shop;
		ShopUI.EPKNOMLADCL(ACPHFLBLJAA().EHHOHCPHAAO).OpenUI();
	}

	[SpecialName]
	public static HallmundNPC EKDNJDJHONF()
	{
		return IADEMLIIDPC;
	}

	public void LKDHHGPMBFM()
	{
		ShopUI.NALKHGMLALJ(BDAGIEIJOOG().EHHOHCPHAAO).shop = shop;
		ShopUI.EPKNOMLADCL(OFLELHKKNKC().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	public void BPLCCEPMHCE()
	{
		ToolUpgradeManager.instance.BOCPIKCDMAK(CDPAMNIPPEC: true);
	}

	[SpecialName]
	public static HallmundNPC AFFGPMFKEFH()
	{
		return IADEMLIIDPC;
	}

	public void GBLFKGMMBDM(string emotion)
	{
		BAKPBHPNKPB().emotionsController.NMAPMPBAGMM(emotion);
	}

	public void IHFOJNJAALB(string emotion)
	{
		PFHFIJDDOME().emotionsController.DCCNJLBLFGI(emotion);
	}

	public void IBDHCOEBDPF(string emotion)
	{
		GGFJGHHHEJC.emotionsController.GPLECKGJFKM(emotion);
	}

	public void JAJGMGJHKLG()
	{
		ShopUI.Get(ACPHFLBLJAA().EHHOHCPHAAO).shop = shop;
		ShopUI.JCBPABNCBPI(PFHFIJDDOME().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	private void NPMLFHDHJBE()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Player");
		if (((Result)(ref variable)).asInt == 0)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
	}

	public void StartEmotions(string emotion)
	{
		GGFJGHHHEJC.emotionsController.StartEmotion(emotion);
	}

	public void OKGHHPHFNFI()
	{
		ToolUpgradeManager.instance.EIANGNCAJMB();
	}

	public void ACMMENIGKLK(string emotion)
	{
		ACPHFLBLJAA().emotionsController.NMAPMPBAGMM(emotion);
	}

	public void HKCMDLLKBHD()
	{
		ShopUI.EAONFFENMCE(KNOKBLFFNLM().EHHOHCPHAAO).shop = shop;
		ShopUI.FKFNANNBIAM(KNOKBLFFNLM().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	public void JANECLIIBMI()
	{
		ToolUpgradeManager.instance.PBAHAOOOEHG(CDPAMNIPPEC: true);
	}

	private void HCEDMLJNOBL()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("add item 1448 20");
		if (((Result)(ref variable)).asInt == 0)
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
		}
	}

	public void EGLJIADCAHH()
	{
		ShopUI.NALKHGMLALJ(EKDNJDJHONF().EHHOHCPHAAO).shop = shop;
		ShopUI.FKFNANNBIAM(AFFGPMFKEFH().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	private void IAAGKLPMAMK()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("");
		if (((Result)(ref variable)).asInt == 0)
		{
			CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
		}
		else
		{
			CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
	}

	public void JPNMAFDGBBE()
	{
		ToolUpgradeManager.instance.GNDEFCAEJEL(CDPAMNIPPEC: true);
	}

	public void BOCPIKCDMAK()
	{
		ToolUpgradeManager.instance.FMACNNLHMGH();
	}

	public void HBOGKBICFEI()
	{
		ToolUpgradeManager.instance.ILLAHEFHLFP();
	}

	public void HLFLPNOOMNF()
	{
		ShopUI.EPKNOMLADCL(NEFIEJALANL().EHHOHCPHAAO).shop = shop;
		ShopUI.AGNKKAPMHLN(DCAEBALADIM().EHHOHCPHAAO).EDHEIFHAAKO();
	}
}
