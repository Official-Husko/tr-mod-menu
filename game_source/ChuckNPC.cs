using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class ChuckNPC : DialogueNPCBase
{
	private static ChuckNPC IADEMLIIDPC;

	public Collider2D shopCollider;

	public float timeBarks;

	private int HKKKNMIKPCM;

	private string HDFMHCKKJJG = "LE_12";

	public static ChuckNPC GGFJGHHHEJC => IADEMLIIDPC;

	public void IKHIGKHJJDP()
	{
		ShopUI.EAONFFENMCE(OOKBNHMMFON().EHHOHCPHAAO).shop = shop;
		ShopUI.Get(OFLELHKKNKC().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	[SpecialName]
	public static ChuckNPC JHMAMLIPBNN()
	{
		return IADEMLIIDPC;
	}

	public void CJDOMKAALLG()
	{
		CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
	}

	public void COIIPIHLLML()
	{
		ShopUI.JCBPABNCBPI(KNLLFEJAMNN().EHHOHCPHAAO).shop = shop;
		ShopUI.NALKHGMLALJ(GJFMMOPOKGJ().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	public void GBDMLNGDHFP()
	{
		ShopUI.IEABDMDELFO(CFHEJAGKIII().EHHOHCPHAAO).shop = shop;
		ShopUI.Get(EBAIHKJHCCA().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	protected override void OnConversationStart(Transform actor)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		base.OnConversationStart(actor);
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		HKKKNMIKPCM = ((Result)(ref variable)).asInt;
	}

	private void DCKKIDMJKJM()
	{
		CJDOMKAALLG();
	}

	public void BDLLGEDIHPA(string emotion)
	{
		PCJCIHANCLE().emotionsController.StartEmotion(emotion);
	}

	private void CHIJGHPHCNA()
	{
		IHIDJOEEMBK();
	}

	private void HELHNJDFPPF()
	{
		DPKBPDKANJP();
	}

	public void FICPJMLIOFG()
	{
		ShopUI.Get(AGGAGCBAGLL().EHHOHCPHAAO).shop = shop;
		ShopUI.JCBPABNCBPI(KNLLFEJAMNN().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	[SpecialName]
	public static ChuckNPC ABHIDHPMLLD()
	{
		return IADEMLIIDPC;
	}

	public void IOKIJIHFLKJ()
	{
		ShopUI.Get(OOKBNHMMFON().EHHOHCPHAAO).shop = shop;
		ShopUI.Get(OOKBNHMMFON().EHHOHCPHAAO).IDLAGJNLPJL();
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

	public void EFPPOOJFNJO(string emotion)
	{
		KHMEGDIABBF().emotionsController.StartEmotion(emotion);
	}

	public void HMEFIIDEMOL(string emotion)
	{
		OAPOJCODNCO().emotionsController.GPLECKGJFKM(emotion);
	}

	private void NNBIAIMPNGL()
	{
		CJDOMKAALLG();
	}

	protected override void NJJCCIBDAPM()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		barkDialogue = false;
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		Result variable = DialogueLua.GetVariable("LE_12");
		if (((Result)(ref variable)).asInt == 0)
		{
			dialogue.conversation = "City/Chuck/Introduce";
		}
		else
		{
			dialogue.conversation = "City/Chuck/Stand";
		}
	}

	private void NELBHAMPBPL()
	{
		FAHDMOFILDI();
	}

	public void BFJDPHECILL(string emotion)
	{
		GGFJGHHHEJC.emotionsController.NMAPMPBAGMM(emotion);
	}

	public void NHHBFDBPPMO()
	{
		CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
	}

	[SpecialName]
	public static ChuckNPC OOKBNHMMFON()
	{
		return IADEMLIIDPC;
	}

	public void HPLEFFCOPBK()
	{
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
	}

	public void EKFJKEMGCKB()
	{
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
	}

	private void OEMIMEIDMFE()
	{
		EKFJKEMGCKB();
	}

	[SpecialName]
	public static ChuckNPC GJFMMOPOKGJ()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static ChuckNPC BDAGIEIJOOG()
	{
		return IADEMLIIDPC;
	}

	public void GMNIFLOBFMK(string emotion)
	{
		JHMAMLIPBNN().emotionsController.GPLECKGJFKM(emotion);
	}

	public void BOIOLKHGNPO(string emotion)
	{
		EBAIHKJHCCA().emotionsController.NBFIDOGMLOK(emotion);
	}

	private void EAEKKBEJMFC()
	{
		HIKEKHKCPLM();
	}

	public void MNFMLBEJBEC()
	{
		CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
	}

	public void FCHIEPKKLCP()
	{
		ShopUI.FKFNANNBIAM(AGGAGCBAGLL().EHHOHCPHAAO).shop = shop;
		ShopUI.AGNKKAPMHLN(AAFOFNEHPLC().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	[SpecialName]
	public static ChuckNPC ELGNEJNLBNO()
	{
		return IADEMLIIDPC;
	}

	public void FFHKDCECPHI()
	{
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
	}

	public void PPGFNGEFCPF()
	{
		CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
	}

	public void FAHDMOFILDI()
	{
		CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
	}

	public void EEBOKKANBEM(string emotion)
	{
		OAPOJCODNCO().emotionsController.StartEmotion(emotion);
	}

	private void OIAHJHNPPCO()
	{
		CJEECBDICOK();
	}

	public void DPKBPDKANJP()
	{
		CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
	}

	protected override void Update()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		base.Update();
		if (((Component)this).transform.position.x <= -509f && ((Component)this).transform.position.x >= -510f && ((Component)this).transform.position.y >= 99f && ((Component)this).transform.position.y <= 100f)
		{
			if (!((Behaviour)shopCollider).enabled)
			{
				((Behaviour)shopCollider).enabled = true;
			}
		}
		else if (((Behaviour)shopCollider).enabled)
		{
			((Behaviour)shopCollider).enabled = false;
		}
	}

	private void IABEJCPMJOF()
	{
		INFOFOAMCAN();
	}

	private void JPOLFKMLHNH()
	{
		HPBPIGFIEED();
	}

	public void MFGLEIGBFFF()
	{
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
	}

	public void JNKMIEOLHDD(string emotion)
	{
		KNLLFEJAMNN().emotionsController.StartEmotion(emotion);
	}

	private void GOEGBOEMHLI()
	{
		PAGOONNCBNA();
	}

	public void IOJEMPOAPCE()
	{
		CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
	}

	[SpecialName]
	public static ChuckNPC CFLBNDLLABP()
	{
		return IADEMLIIDPC;
	}

	public void NAFCNHPFDDN()
	{
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
	}

	private void GNGADDPBJDC()
	{
		DPKBPDKANJP();
	}

	public void HBEABOLLBAC()
	{
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
	}

	public void FNGKCCMIMLA()
	{
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
	}

	public void NLBFEHJDELC(string emotion)
	{
		PFHFIJDDOME().emotionsController.NMAPMPBAGMM(emotion);
	}

	private void OIBDBLCLACB()
	{
		NHHBFDBPPMO();
	}

	public void OJECLFGAAPN(string emotion)
	{
		GJFMMOPOKGJ().emotionsController.NMAPMPBAGMM(emotion);
	}

	private void JHBBABPAJJC()
	{
		CJEECBDICOK();
	}

	private void MCMKNBIBDFF()
	{
		LGGHJHKCDGA();
	}

	[SpecialName]
	public static ChuckNPC KHMEGDIABBF()
	{
		return IADEMLIIDPC;
	}

	public new void CheckExclamation()
	{
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
	}

	[SpecialName]
	public static ChuckNPC OAPOJCODNCO()
	{
		return IADEMLIIDPC;
	}

	public void HLNDPFDKCFI()
	{
		ShopUI.JCBPABNCBPI(PCJCIHANCLE().EHHOHCPHAAO).shop = shop;
		ShopUI.EAONFFENMCE(GGFJGHHHEJC.EHHOHCPHAAO).OpenUI();
	}

	public override DialogueNPCBase GetInstance()
	{
		return GGFJGHHHEJC;
	}

	public void EGLJIADCAHH()
	{
		ShopUI.NALKHGMLALJ(ABHIDHPMLLD().EHHOHCPHAAO).shop = shop;
		ShopUI.FKFNANNBIAM(BADFKMEJOKE().EHHOHCPHAAO).OpenUI();
	}

	[SpecialName]
	public static ChuckNPC CFHEJAGKIII()
	{
		return IADEMLIIDPC;
	}

	public void HHJNMFFPIKM()
	{
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
	}

	public void BEECLHMOEIP(string emotion)
	{
		OFLELHKKNKC().emotionsController.GPLECKGJFKM(emotion);
	}

	public void JFOHHPNCOIG()
	{
		ShopUI.IEKODILKIHJ(JHMAMLIPBNN().EHHOHCPHAAO).shop = shop;
		ShopUI.IEABDMDELFO(GJFMMOPOKGJ().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	public void HPBPIGFIEED()
	{
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
	}

	public void ONIGIICJBNH()
	{
		CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
	}

	public void OpenShop()
	{
		ShopUI.Get(GGFJGHHHEJC.EHHOHCPHAAO).shop = shop;
		ShopUI.Get(GGFJGHHHEJC.EHHOHCPHAAO).OpenUI();
	}

	public void AEBOCGBCMBG()
	{
		ShopUI.IEKODILKIHJ(KHMEGDIABBF().EHHOHCPHAAO).shop = shop;
		ShopUI.Get(OOKBNHMMFON().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	[SpecialName]
	public static ChuckNPC OFLELHKKNKC()
	{
		return IADEMLIIDPC;
	}

	private void HCEDMLJNOBL()
	{
		LGGHJHKCDGA();
	}

	[SpecialName]
	public static ChuckNPC LPFNKEOJJKE()
	{
		return IADEMLIIDPC;
	}

	public void DNHIHIIOINE(string emotion)
	{
		AGGAGCBAGLL().emotionsController.EMMBEAHMDHE(emotion);
	}

	[SpecialName]
	public static ChuckNPC PCJCIHANCLE()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static ChuckNPC AAFOFNEHPLC()
	{
		return IADEMLIIDPC;
	}

	public void ENJKCGDGGKM()
	{
		ShopUI.AGNKKAPMHLN(CFLBNDLLABP().EHHOHCPHAAO).shop = shop;
		ShopUI.EPKNOMLADCL(KHMEGDIABBF().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	[SpecialName]
	public static ChuckNPC EBAIHKJHCCA()
	{
		return IADEMLIIDPC;
	}

	private void FJMBOFEILBN()
	{
		APEMGJFHJAD();
	}

	[SpecialName]
	public static ChuckNPC PFHFIJDDOME()
	{
		return IADEMLIIDPC;
	}

	public void GKAFNIGIHEP()
	{
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
	}

	[SpecialName]
	public static ChuckNPC KNLLFEJAMNN()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static ChuckNPC BADFKMEJOKE()
	{
		return IADEMLIIDPC;
	}

	public void IHIDJOEEMBK()
	{
		CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
	}

	public void LLDBGFFPBKN()
	{
		CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
	}

	private void LFNENELHOGJ()
	{
		CJDOMKAALLG();
	}

	public void FOLIFEFBBJD()
	{
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
	}

	private void KDBJHCAEGCM()
	{
		FFHKDCECPHI();
	}

	public void KPHMPFCPGGI()
	{
		ShopUI.Get(PCJCIHANCLE().EHHOHCPHAAO).shop = shop;
		ShopUI.NALKHGMLALJ(GGFJGHHHEJC.EHHOHCPHAAO).EDHEIFHAAKO();
	}

	public void EFOEDOJOFEH(string emotion)
	{
		AAFOFNEHPLC().emotionsController.NBFIDOGMLOK(emotion);
	}

	private void NHGBJHMHEGD()
	{
		HPLEFFCOPBK();
	}

	public void INFOFOAMCAN()
	{
		CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
	}

	public void EHALEBEOLCF()
	{
		ShopUI.EPKNOMLADCL(BDAGIEIJOOG().EHHOHCPHAAO).shop = shop;
		ShopUI.EAONFFENMCE(LPFNKEOJJKE().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	private void CMLLBIDFNEB()
	{
		DPKBPDKANJP();
	}

	public void CAFAECPENBC()
	{
		ShopUI.JCBPABNCBPI(LANAINBEMCM().EHHOHCPHAAO).shop = shop;
		ShopUI.FKFNANNBIAM(CFHEJAGKIII().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	[SpecialName]
	public static ChuckNPC LANAINBEMCM()
	{
		return IADEMLIIDPC;
	}

	public void PKMIELNPJCF()
	{
		ShopUI.EAONFFENMCE(KHMEGDIABBF().EHHOHCPHAAO).shop = shop;
		ShopUI.IEABDMDELFO(NGPHACGDNJN().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	public void GHHNOBDPPEP(string emotion)
	{
		OFLELHKKNKC().emotionsController.PIOCPGKDAOF(emotion);
	}

	public void LGGHJHKCDGA()
	{
		CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
	}

	private void CAIJLMJBMLA()
	{
		INFOFOAMCAN();
	}

	[SpecialName]
	public static ChuckNPC OMFKNGDCJFN()
	{
		return IADEMLIIDPC;
	}

	public void APEMGJFHJAD()
	{
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
	}

	private void IDHCFOCEPMD()
	{
		NHHBFDBPPMO();
	}

	public void PAGOONNCBNA()
	{
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
	}

	public void LGMDDMFKIAD(string emotion)
	{
		PCJCIHANCLE().emotionsController.NMAPMPBAGMM(emotion);
	}

	private void GBFPCABGAII()
	{
		ONIGIICJBNH();
	}

	public void MLAEBHMJCJJ(string emotion)
	{
		PFHFIJDDOME().emotionsController.NMAPMPBAGMM(emotion);
	}

	public void KCKGPHEACFO()
	{
		ShopUI.AGNKKAPMHLN(KHMEGDIABBF().EHHOHCPHAAO).shop = shop;
		ShopUI.AGNKKAPMHLN(ABHIDHPMLLD().EHHOHCPHAAO).OpenUI();
	}

	public void CJEECBDICOK()
	{
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
	}

	private void Start()
	{
		CheckExclamation();
	}

	[SpecialName]
	public static ChuckNPC AGGAGCBAGLL()
	{
		return IADEMLIIDPC;
	}

	public void LDDOONCCFHN()
	{
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
	}

	public void JGMDDHPIFLL()
	{
		ShopUI.IEKODILKIHJ(KNLLFEJAMNN().EHHOHCPHAAO).shop = shop;
		ShopUI.FKFNANNBIAM(ILMPOAEALPP().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	public void GLKFIBIIJDP()
	{
		ShopUI.NALKHGMLALJ(OAPOJCODNCO().EHHOHCPHAAO).shop = shop;
		ShopUI.NALKHGMLALJ(ABHIDHPMLLD().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	[SpecialName]
	public static ChuckNPC ILMPOAEALPP()
	{
		return IADEMLIIDPC;
	}

	public void LMEMMBGFPII(string emotion)
	{
		LANAINBEMCM().emotionsController.DCCNJLBLFGI(emotion);
	}

	private void IFHLGOMBACP()
	{
		LLDBGFFPBKN();
	}

	public void BPKELGOKKBK()
	{
		ShopUI.EPKNOMLADCL(EBAIHKJHCCA().EHHOHCPHAAO).shop = shop;
		ShopUI.FKFNANNBIAM(BADFKMEJOKE().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	private void EBNKNEIDDDI()
	{
		PPGFNGEFCPF();
	}

	private void EOGHJNGJFID()
	{
		PAGOONNCBNA();
	}

	public void StartEmotions(string emotion)
	{
		GGFJGHHHEJC.emotionsController.StartEmotion(emotion);
	}

	[SpecialName]
	public static ChuckNPC NGPHACGDNJN()
	{
		return IADEMLIIDPC;
	}

	public void HIKEKHKCPLM()
	{
		CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
	}

	[SpecialName]
	public static ChuckNPC GAGMPCEPONF()
	{
		return IADEMLIIDPC;
	}
}
