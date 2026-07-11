using System;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class CliveNPC : DialogueNPCBase
{
	private static CliveNPC IADEMLIIDPC;

	public SimpleAnimationController simpleAnimation;

	public AnimationController animationController;

	public float timeBarks;

	public bool ferroEvent;

	private int HKKKNMIKPCM;

	private string HDFMHCKKJJG = "CliveProgress";

	public static CliveNPC GGFJGHHHEJC => IADEMLIIDPC;

	private void JDFDLEEELFH()
	{
		CheckExclamationSendOnline(sendOnline: true);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(KEIICPHCIIF));
	}

	[SpecialName]
	public static CliveNPC ABHIDHPMLLD()
	{
		return IADEMLIIDPC;
	}

	public void MOEBKNMCBMP()
	{
		ShopUI.NALKHGMLALJ(CFHEJAGKIII().EHHOHCPHAAO).shop = shop;
		ShopUI.JCBPABNCBPI(HKBJIIJHBJB().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	private void PHAGPPHHOKC()
	{
		CheckExclamationSendOnline(sendOnline: true);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(EAKMJDFKKMB));
	}

	public void EFOEDOJOFEH(string emotion)
	{
		IDIGFHEHIDM().emotionsController.StartEmotion(emotion);
	}

	private void LCHKONDHINE()
	{
		SelectDialogueUI();
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(PMHNOIOIKOH));
	}

	public void BCCBAJJCODB()
	{
		ShopUI.AGNKKAPMHLN(EAGMIHGJKNB().EHHOHCPHAAO).shop = shop;
		ShopUI.EPKNOMLADCL(LKDJNKLJKGO().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	public void PAIMGGCBBMB(string emotion)
	{
		KNLLFEJAMNN().emotionsController.EMMBEAHMDHE(emotion);
	}

	private void MFMMHDPGCBO()
	{
		SelectDialogueUI();
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(GGODJHIOMPK));
	}

	public void MJECIOCNDAE()
	{
		ShopUI.JCBPABNCBPI(EAGMIHGJKNB().EHHOHCPHAAO).shop = shop;
		ShopUI.JCBPABNCBPI(PNHHCHJCDNM().EHHOHCPHAAO).OpenUI();
	}

	[SpecialName]
	public static CliveNPC CMIHGBHPLFP()
	{
		return IADEMLIIDPC;
	}

	public void OHJFDAKNOPE()
	{
		ShopUI.IEKODILKIHJ(GAGMPCEPONF().EHHOHCPHAAO).shop = shop;
		ShopUI.AGNKKAPMHLN(MAAAKALBBEE().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	[SpecialName]
	public static CliveNPC PEJFACMBPBN()
	{
		return IADEMLIIDPC;
	}

	public void APPNAMFJDOA(string emotion)
	{
		BAKPBHPNKPB().emotionsController.NMAPMPBAGMM(emotion);
	}

	public void EFPPOOJFNJO(string emotion)
	{
		GIKECEGLFOH().emotionsController.StartEmotion(emotion);
	}

	public void PPMKNLKOLPG()
	{
		ShopUI.IEKODILKIHJ(OMFKNGDCJFN().EHHOHCPHAAO).shop = shop;
		ShopUI.AGNKKAPMHLN(ABDJJBFNLBJ().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	private void JBLNPNKPNIN()
	{
		CheckExclamationSendOnline(sendOnline: true);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(NNODOACIKOO));
	}

	public void AKCJMLPHFEB(string emotion)
	{
		DIHCEGINELM().emotionsController.PIOCPGKDAOF(emotion);
	}

	public void ONKHHNFPOEO()
	{
		ShopUI.Get(BAKPBHPNKPB().EHHOHCPHAAO).shop = shop;
		ShopUI.EAONFFENMCE(ABDJJBFNLBJ().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	private void KGPOCJEHHHH()
	{
		SelectDialogueUI(1);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(PCMJOOALNFC));
	}

	private void NNODOACIKOO()
	{
		CheckExclamationSendOnline(sendOnline: true);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(LJBFGDCCAFG));
	}

	[SpecialName]
	public static CliveNPC PNHHCHJCDNM()
	{
		return IADEMLIIDPC;
	}

	private void EFBEKNLOILH()
	{
		CheckExclamationSendOnline(sendOnline: false);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(ILJPINCGGFG));
	}

	public void FACKKGAODPO(string emotion)
	{
		KCFGPDHELKP().emotionsController.StartEmotion(emotion);
	}

	private void HLLCOCEAGHK()
	{
		CheckExclamationSendOnline(sendOnline: false);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(ANLIOHACMGO));
	}

	[SpecialName]
	public static CliveNPC EAGMIHGJKNB()
	{
		return IADEMLIIDPC;
	}

	public void LBEIJJCJLHB(string emotion)
	{
		DCAEBALADIM().emotionsController.EMMBEAHMDHE(emotion);
	}

	[SpecialName]
	public static CliveNPC GDAHBDMFPCB()
	{
		return IADEMLIIDPC;
	}

	private void NHGBKNAJHOP()
	{
		CheckExclamationSendOnline(sendOnline: true);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(GGODJHIOMPK));
	}

	private void LJBFGDCCAFG()
	{
		CheckExclamationSendOnline(sendOnline: true);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(EFBEKNLOILH));
	}

	public void KIDDNGOMMJH(string emotion)
	{
		LADDMEMMJFP().emotionsController.NMAPMPBAGMM(emotion);
	}

	private void EAEKKBEJMFC()
	{
		SelectDialogueUI(1);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(ILJPINCGGFG));
	}

	public void PFFAJBLGFDO(string emotion)
	{
		KMKILBCGJOI().emotionsController.PIOCPGKDAOF(emotion);
	}

	private void PCMJOOALNFC()
	{
		CheckExclamationSendOnline(sendOnline: false);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
	}

	public override void CheckExclamationSendOnline(bool sendOnline)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		if (EventsManager.IsDone(EventsManager.EventType.HotBath))
		{
			Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			if (((Result)(ref variable)).asInt == 0 && !ferroEvent)
			{
				GGFJGHHHEJC.CheckIfNewActivity(OGECKNMAJMI: true, sendOnline);
				return;
			}
		}
		GGFJGHHHEJC.CheckIfNewActivity(OGECKNMAJMI: false, sendOnline);
	}

	public void LCKBHNEANNL(string emotion)
	{
		OMFKNGDCJFN().emotionsController.PIOCPGKDAOF(emotion);
	}

	public void GIEIIFJDBIB()
	{
		ShopUI.IEABDMDELFO(KNLLFEJAMNN().EHHOHCPHAAO).shop = shop;
		ShopUI.FKFNANNBIAM(ABDJJBFNLBJ().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	private void OLEPHIJMLPB()
	{
		CheckExclamationSendOnline(sendOnline: false);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(OACFPJIJDFO));
	}

	private void BGPGIOMKKAO()
	{
		CheckExclamationSendOnline(sendOnline: false);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(BGPGIOMKKAO));
	}

	public override DialogueNPCBase GetInstance()
	{
		return GGFJGHHHEJC;
	}

	public void HOIILEFGDHF()
	{
		ShopUI.EPKNOMLADCL(LADDMEMMJFP().EHHOHCPHAAO).shop = shop;
		ShopUI.NALKHGMLALJ(EAGMIHGJKNB().EHHOHCPHAAO).OpenUI();
	}

	protected override void NJJCCIBDAPM()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		barkDialogue = false;
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		if (ferroEvent)
		{
			dialogue.conversation = "HotBath/Clive Talk";
			return;
		}
		Result variable = DialogueLua.GetVariable("MineState");
		if (((Result)(ref variable)).asInt <= 1 && !EventsManager.IsDone(EventsManager.EventType.HotBath))
		{
			dialogue.conversation = "Miners/Camp/Clive/Talk";
			return;
		}
		variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		if (((Result)(ref variable)).asInt == 0)
		{
			dialogue.conversation = "Miners/Mine/Clive/Intro";
		}
		else
		{
			dialogue.conversation = "Miners/Mine/Clive/Talk";
		}
	}

	public void FMBEGDCIHHH(string emotion)
	{
		FMIDAFEGDCD().emotionsController.NMAPMPBAGMM(emotion);
	}

	public void MMBHJICBLND(string emotion)
	{
		IFPLPBMCKLB().emotionsController.NMAPMPBAGMM(emotion);
	}

	private void GFEOBIGKDMG()
	{
		SelectDialogueUI();
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(PMHNOIOIKOH));
	}

	[SpecialName]
	public static CliveNPC KNOKBLFFNLM()
	{
		return IADEMLIIDPC;
	}

	private void FEMEFCNMOOL()
	{
		CheckExclamationSendOnline(sendOnline: true);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(JBLNPNKPNIN));
	}

	public void PFOFAALHDJA(string emotion)
	{
		ABDJJBFNLBJ().emotionsController.EMMBEAHMDHE(emotion);
	}

	private void ILJPINCGGFG()
	{
		CheckExclamationSendOnline(sendOnline: true);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(ANLIOHACMGO));
	}

	private void FHNFCPLIMOB()
	{
		CheckExclamationSendOnline(sendOnline: true);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(IDODLLIMEMO));
	}

	protected override void OnConversationStart(Transform actor)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		base.OnConversationStart(actor);
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		HKKKNMIKPCM = ((Result)(ref variable)).asInt;
	}

	public void AEBOCGBCMBG()
	{
		ShopUI.EAONFFENMCE(GAGMPCEPONF().EHHOHCPHAAO).shop = shop;
		ShopUI.EPKNOMLADCL(DOIKFJDLKJP().EHHOHCPHAAO).OpenUI();
	}

	private void PLHPEMNDAFB()
	{
		SelectDialogueUI();
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(FEMEFCNMOOL));
	}

	private void ODKGLIDMCNP()
	{
		SelectDialogueUI();
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(JBLNPNKPNIN));
	}

	[SpecialName]
	public static CliveNPC KNLLFEJAMNN()
	{
		return IADEMLIIDPC;
	}

	private void HJDLNCOAKIK()
	{
		SelectDialogueUI(1);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(EFBEKNLOILH));
	}

	[SpecialName]
	public static CliveNPC JLNBMNKJCHE()
	{
		return IADEMLIIDPC;
	}

	private void Start()
	{
		SelectDialogueUI();
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(BGPGIOMKKAO));
	}

	[SpecialName]
	public static CliveNPC CFHEJAGKIII()
	{
		return IADEMLIIDPC;
	}

	public void IKPDMGNNNNH()
	{
		ShopUI.EPKNOMLADCL(EJHDHCNILDH().EHHOHCPHAAO).shop = shop;
		ShopUI.EPKNOMLADCL(DGCNCEDIFOF().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	[SpecialName]
	public static CliveNPC KPDFIEMDDCL()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static CliveNPC JHKLPLPBKCI()
	{
		return IADEMLIIDPC;
	}

	public void ADDHKOEGHJI()
	{
		ShopUI.AGNKKAPMHLN(ABDJJBFNLBJ().EHHOHCPHAAO).shop = shop;
		ShopUI.Get(EBAIHKJHCCA().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	[SpecialName]
	public static CliveNPC DIHCEGINELM()
	{
		return IADEMLIIDPC;
	}

	public void IAOIJKJNPNH(string emotion)
	{
		CMIHGBHPLFP().emotionsController.NMAPMPBAGMM(emotion);
	}

	[SpecialName]
	public static CliveNPC HKBJIIJHBJB()
	{
		return IADEMLIIDPC;
	}

	public void LAPNEPFAECM(string emotion)
	{
		KMKILBCGJOI().emotionsController.EMMBEAHMDHE(emotion);
	}

	private void IDHCFOCEPMD()
	{
		SelectDialogueUI(1);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(IDODLLIMEMO));
	}

	public void ONMNKLPNCAH(string emotion)
	{
		DOIKFJDLKJP().emotionsController.PIOCPGKDAOF(emotion);
	}

	private void OACFPJIJDFO()
	{
		CheckExclamationSendOnline(sendOnline: true);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(EAKMJDFKKMB));
	}

	public void HFAAGMKHODN(string emotion)
	{
		FMIDAFEGDCD().emotionsController.DCCNJLBLFGI(emotion);
	}

	private void EGACIHOKJLH()
	{
		SelectDialogueUI(1);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(FEMEFCNMOOL));
	}

	private void PGGEKIONLIE()
	{
		CheckExclamationSendOnline(sendOnline: false);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(ILJPINCGGFG));
	}

	private void HELHNJDFPPF()
	{
		SelectDialogueUI(1);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(FHNFCPLIMOB));
	}

	private void PFMDJDAKHJC()
	{
		CheckExclamationSendOnline(sendOnline: true);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(CGHONFBKJEA));
	}

	[SpecialName]
	public static CliveNPC LADDMEMMJFP()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static CliveNPC ABDJJBFNLBJ()
	{
		return IADEMLIIDPC;
	}

	private void GGODJHIOMPK()
	{
		CheckExclamationSendOnline(sendOnline: false);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(CGHONFBKJEA));
	}

	[SpecialName]
	public static CliveNPC MAAAKALBBEE()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static CliveNPC OMFKNGDCJFN()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static CliveNPC IFPLPBMCKLB()
	{
		return IADEMLIIDPC;
	}

	public void FICPJMLIOFG()
	{
		ShopUI.NALKHGMLALJ(FMIDAFEGDCD().EHHOHCPHAAO).shop = shop;
		ShopUI.IEABDMDELFO(CMIHGBHPLFP().EHHOHCPHAAO).OpenUI();
	}

	public void EICNDMGMPLE(string emotion)
	{
		EJHDHCNILDH().emotionsController.NBFIDOGMLOK(emotion);
	}

	public void BEECLHMOEIP(string emotion)
	{
		KMKILBCGJOI().emotionsController.PIOCPGKDAOF(emotion);
	}

	private void HPIMHEMJMAA()
	{
		SelectDialogueUI(1);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(NNODOACIKOO));
	}

	[SpecialName]
	public static CliveNPC FMIDAFEGDCD()
	{
		return IADEMLIIDPC;
	}

	public void EHALEBEOLCF()
	{
		ShopUI.IEABDMDELFO(IFPLPBMCKLB().EHHOHCPHAAO).shop = shop;
		ShopUI.FKFNANNBIAM(KMKILBCGJOI().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	public void IAFBFHALBJH(string emotion)
	{
		EJHDHCNILDH().emotionsController.NMAPMPBAGMM(emotion);
	}

	[SpecialName]
	public static CliveNPC OFLELHKKNKC()
	{
		return IADEMLIIDPC;
	}

	public void DOCHPOEOOAL(string emotion)
	{
		EAGMIHGJKNB().emotionsController.EMMBEAHMDHE(emotion);
	}

	[SpecialName]
	public static CliveNPC CNDNOECMKME()
	{
		return IADEMLIIDPC;
	}

	private void PMHNOIOIKOH()
	{
		CheckExclamationSendOnline(sendOnline: true);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(FHNFCPLIMOB));
	}

	[SpecialName]
	public static CliveNPC LKDJNKLJKGO()
	{
		return IADEMLIIDPC;
	}

	public void IGNCCLNIIJM(string emotion)
	{
		DOIKFJDLKJP().emotionsController.DCCNJLBLFGI(emotion);
	}

	[SpecialName]
	public static CliveNPC GIKECEGLFOH()
	{
		return IADEMLIIDPC;
	}

	public void GMNIFLOBFMK(string emotion)
	{
		IBEGPMLJIOJ().emotionsController.DCCNJLBLFGI(emotion);
	}

	private void DOHLOJOIHFO()
	{
		SelectDialogueUI(1);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(ANLIOHACMGO));
	}

	public void GAADIDHFPGP(string emotion)
	{
		BIIOFAHFNPA().emotionsController.EMMBEAHMDHE(emotion);
	}

	public void GFNPDMNLNAP(string emotion)
	{
		CNDNOECMKME().emotionsController.StartEmotion(emotion);
	}

	private void IDODLLIMEMO()
	{
		CheckExclamationSendOnline(sendOnline: true);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(CGHONFBKJEA));
	}

	public void OIAGMNIKJIM()
	{
		ShopUI.AGNKKAPMHLN(LKDJNKLJKGO().EHHOHCPHAAO).shop = shop;
		ShopUI.EPKNOMLADCL(ABHIDHPMLLD().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	private void KEIICPHCIIF()
	{
		CheckExclamationSendOnline(sendOnline: true);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(EAKMJDFKKMB));
	}

	[SpecialName]
	public static CliveNPC FOPGLLMEEDE()
	{
		return IADEMLIIDPC;
	}

	private void ANLIOHACMGO()
	{
		CheckExclamationSendOnline(sendOnline: false);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(OACFPJIJDFO));
	}

	public void HMEFIIDEMOL(string emotion)
	{
		HKBJIIJHBJB().emotionsController.NMAPMPBAGMM(emotion);
	}

	public void FCOEGANLLCG()
	{
		ShopUI.IEABDMDELFO(GDAHBDMFPCB().EHHOHCPHAAO).shop = shop;
		ShopUI.EPKNOMLADCL(CFHEJAGKIII().EHHOHCPHAAO).OpenUI();
	}

	private void EBNKNEIDDDI()
	{
		SelectDialogueUI(1);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(ILJPINCGGFG));
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

	protected override void Awake()
	{
		base.Awake();
		IADEMLIIDPC = this;
	}

	public void LLIEPKCNOIG()
	{
		ShopUI.NALKHGMLALJ(LADDMEMMJFP().EHHOHCPHAAO).shop = shop;
		ShopUI.IEABDMDELFO(KCFGPDHELKP().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	[SpecialName]
	public static CliveNPC IBEGPMLJIOJ()
	{
		return IADEMLIIDPC;
	}

	private void HEHNBONKMGJ()
	{
		SelectDialogueUI(1);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(JBLNPNKPNIN));
	}

	public void GIHMILAFOFO()
	{
		ShopUI.AGNKKAPMHLN(CNDNOECMKME().EHHOHCPHAAO).shop = shop;
		ShopUI.NALKHGMLALJ(GGFJGHHHEJC.EHHOHCPHAAO).IDLAGJNLPJL();
	}

	public void LEADONDEOIC(string emotion)
	{
		KMKILBCGJOI().emotionsController.NBFIDOGMLOK(emotion);
	}

	public void FPKLJCGJBPL(string emotion)
	{
		GDAHBDMFPCB().emotionsController.PIOCPGKDAOF(emotion);
	}

	public void OpenShop()
	{
		ShopUI.Get(GGFJGHHHEJC.EHHOHCPHAAO).shop = shop;
		ShopUI.Get(GGFJGHHHEJC.EHHOHCPHAAO).OpenUI();
	}

	[SpecialName]
	public static CliveNPC DGCNCEDIFOF()
	{
		return IADEMLIIDPC;
	}

	private void BIPOBGNDFCK()
	{
		SelectDialogueUI(1);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(JBLNPNKPNIN));
	}

	private void JCFPPJDJOOJ()
	{
		CheckExclamationSendOnline(sendOnline: true);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(PGGEKIONLIE));
	}

	public void JAJGMGJHKLG()
	{
		ShopUI.Get(EJHDHCNILDH().EHHOHCPHAAO).shop = shop;
		ShopUI.IEKODILKIHJ(HKBJIIJHBJB().EHHOHCPHAAO).OpenUI();
	}

	[SpecialName]
	public static CliveNPC KCFGPDHELKP()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static CliveNPC GAGMPCEPONF()
	{
		return IADEMLIIDPC;
	}

	public void StartEmotions(string emotion)
	{
		GGFJGHHHEJC.emotionsController.StartEmotion(emotion);
	}

	[SpecialName]
	public static CliveNPC EBAIHKJHCCA()
	{
		return IADEMLIIDPC;
	}

	private void DHOMCKHIGNF()
	{
		CheckExclamationSendOnline(sendOnline: true);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(FHNFCPLIMOB));
	}

	private void HBMDEHPHAPF()
	{
		SelectDialogueUI(1);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(CGHONFBKJEA));
	}

	public void OPGHBDIBDPC()
	{
		ShopUI.IEKODILKIHJ(BIIOFAHFNPA().EHHOHCPHAAO).shop = shop;
		ShopUI.IEKODILKIHJ(PEJFACMBPBN().EHHOHCPHAAO).OpenUI();
	}

	public void JGMDDHPIFLL()
	{
		ShopUI.Get(JLNBMNKJCHE().EHHOHCPHAAO).shop = shop;
		ShopUI.IEKODILKIHJ(GDAHBDMFPCB().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	public void CJAOIANIGMA()
	{
		ShopUI.NALKHGMLALJ(DOIKFJDLKJP().EHHOHCPHAAO).shop = shop;
		ShopUI.IEABDMDELFO(KNOKBLFFNLM().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	[SpecialName]
	public static CliveNPC KMKILBCGJOI()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static CliveNPC BIIOFAHFNPA()
	{
		return IADEMLIIDPC;
	}

	public void HPKIOFCAOGB(string emotion)
	{
		FOPGLLMEEDE().emotionsController.NMAPMPBAGMM(emotion);
	}

	[SpecialName]
	public static CliveNPC IDIGFHEHIDM()
	{
		return IADEMLIIDPC;
	}

	public void LAANEEHHDLL(string emotion)
	{
		EAGMIHGJKNB().emotionsController.NBFIDOGMLOK(emotion);
	}

	public void NCFFCBOMFKB()
	{
		ShopUI.IEABDMDELFO(HKBJIIJHBJB().EHHOHCPHAAO).shop = shop;
		ShopUI.Get(GDAHBDMFPCB().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	public void BJOILGMEFGD(string emotion)
	{
		CFHEJAGKIII().emotionsController.NMAPMPBAGMM(emotion);
	}

	private void CGHONFBKJEA()
	{
		CheckExclamationSendOnline(sendOnline: true);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(PGGEKIONLIE));
	}

	public void HFLEIKDDPCO(string emotion)
	{
		BIIOFAHFNPA().emotionsController.DCCNJLBLFGI(emotion);
	}

	public void CMCPHCDHFAM()
	{
		ShopUI.IEKODILKIHJ(GDAHBDMFPCB().EHHOHCPHAAO).shop = shop;
		ShopUI.NALKHGMLALJ(GDAHBDMFPCB().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	public void FFOPDJPHLEF()
	{
		ShopUI.Get(KPDFIEMDDCL().EHHOHCPHAAO).shop = shop;
		ShopUI.AGNKKAPMHLN(IFPLPBMCKLB().EHHOHCPHAAO).OpenUI();
	}

	private void NKDFMFFDGKC()
	{
		SelectDialogueUI(1);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
	}

	[SpecialName]
	public static CliveNPC MJCMPKPCNGB()
	{
		return IADEMLIIDPC;
	}

	public void LGMDDMFKIAD(string emotion)
	{
		JLNBMNKJCHE().emotionsController.GPLECKGJFKM(emotion);
	}

	private void LFPGDGAKPBD()
	{
		SelectDialogueUI(1);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(OLEPHIJMLPB));
	}

	public void EIBOMLNHNLP()
	{
		ShopUI.JCBPABNCBPI(KMKILBCGJOI().EHHOHCPHAAO).shop = shop;
		ShopUI.AGNKKAPMHLN(KNOKBLFFNLM().EHHOHCPHAAO).OpenUI();
	}

	[SpecialName]
	public static CliveNPC EJHDHCNILDH()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static CliveNPC BAKPBHPNKPB()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static CliveNPC DBJCACLEFGK()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static CliveNPC DCAEBALADIM()
	{
		return IADEMLIIDPC;
	}

	private void EAKMJDFKKMB()
	{
		CheckExclamationSendOnline(sendOnline: true);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(GGODJHIOMPK));
	}

	public void JAGIEEJADMN(string emotion)
	{
		KNLLFEJAMNN().emotionsController.DCCNJLBLFGI(emotion);
	}

	public void ELBPCLPMHHE(string emotion)
	{
		FOPGLLMEEDE().emotionsController.StartEmotion(emotion);
	}

	public void EJDPBEOHOFM()
	{
		ShopUI.EAONFFENMCE(GGFJGHHHEJC.EHHOHCPHAAO).shop = shop;
		ShopUI.JCBPABNCBPI(GIKECEGLFOH().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	[SpecialName]
	public static CliveNPC DOIKFJDLKJP()
	{
		return IADEMLIIDPC;
	}
}
