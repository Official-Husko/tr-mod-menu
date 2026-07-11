using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class BirdSellerNPC : DialogueNPCBase
{
	private static BirdSellerNPC IADEMLIIDPC;

	public BirdSellerAnimation birdSellerVisual;

	private bool MNAFHFDJPIN;

	private int HKKKNMIKPCM;

	private int GOKNJHLHBOO;

	private int FELPMINODKO;

	private int KKAODEMABNN;

	private string HDFMHCKKJJG = "LE_1";

	public static BirdSellerNPC GGFJGHHHEJC => IADEMLIIDPC;

	[SpecialName]
	public static BirdSellerNPC AMINECMFPAH()
	{
		return IADEMLIIDPC;
	}

	public void DBMPAGNJFFK(string emotion)
	{
		EAGMIHGJKNB().emotionsController.GPLECKGJFKM(emotion);
	}

	[SpecialName]
	public static BirdSellerNPC DBJCACLEFGK()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BirdSellerNPC MNFMOEKMJKN()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BirdSellerNPC ELGNEJNLBNO()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BirdSellerNPC OJJDNLEFNPJ()
	{
		return IADEMLIIDPC;
	}

	public void OIAGMNIKJIM()
	{
		ShopUI.EPKNOMLADCL(BADFKMEJOKE().EHHOHCPHAAO).shop = shop;
		ShopUI.AGNKKAPMHLN(NGPHACGDNJN().EHHOHCPHAAO).OpenUI();
	}

	public void LJGLEICKCNM()
	{
		ShopUI.Get(CHPEMJMLDCN().EHHOHCPHAAO).shop = shop;
		ShopUI.IEKODILKIHJ(DHDOLCONMFJ().EHHOHCPHAAO).OpenUI();
	}

	public void MPJBAKFMNHI()
	{
		ShopUI.IEABDMDELFO(NBENKBAIBOO().EHHOHCPHAAO).shop = shop;
		ShopUI.AGNKKAPMHLN(LADDMEMMJFP().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	[SpecialName]
	public static BirdSellerNPC EAGMIHGJKNB()
	{
		return IADEMLIIDPC;
	}

	public void EHALEBEOLCF()
	{
		ShopUI.EPKNOMLADCL(FOPGLLMEEDE().EHHOHCPHAAO).shop = shop;
		ShopUI.AGNKKAPMHLN(NBENKBAIBOO().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	[SpecialName]
	public static BirdSellerNPC OLHBLKIAFOM()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BirdSellerNPC MOJDNGDNCCO()
	{
		return IADEMLIIDPC;
	}

	protected override void NJJCCIBDAPM()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		base.NJJCCIBDAPM();
		Result variable = DialogueLua.GetVariable("LE_1");
		if (((Result)(ref variable)).asInt == 0)
		{
			dialogue.conversation = "Crowly_Introduce";
			return;
		}
		if (PlayerInventory.GetPlayer(base.EHHOHCPHAAO).HasItem(ItemDatabaseAccessor.GetItem(1225)))
		{
			dialogue.conversation = "Crowly_RaraAvis";
			MNAFHFDJPIN = true;
			return;
		}
		variable = DialogueLua.GetVariable("SkeletonBird");
		if (((Result)(ref variable)).asInt != 1)
		{
			variable = DialogueLua.GetVariable("SkeletonBird");
			if (((Result)(ref variable)).asInt != 3)
			{
				dialogue.conversation = "Crowly_Standar";
				return;
			}
		}
		dialogue.conversation = "Crowly_SkelletonBird";
	}

	public void OOJEGKJLOED(string emotion)
	{
		MPJJAPCFENH().emotionsController.GPLECKGJFKM(emotion);
	}

	public void LIMPDEFKJLO(string emotion)
	{
		GGFJGHHHEJC.emotionsController.DCCNJLBLFGI(emotion);
	}

	public void EPMNMALMHKN(string emotion)
	{
		GIKECEGLFOH().emotionsController.PIOCPGKDAOF(emotion);
	}

	public void OEPALJIDLHC(string emotion)
	{
		LFPEPJBNCBF().emotionsController.DCCNJLBLFGI(emotion);
	}

	public void EFOEDOJOFEH(string emotion)
	{
		JBBNILLDPCJ().emotionsController.PIOCPGKDAOF(emotion);
	}

	public void CDOCKCOOPIM(string emotion)
	{
		DHDOLCONMFJ().emotionsController.DCCNJLBLFGI(emotion);
	}

	[SpecialName]
	public static BirdSellerNPC LFPEPJBNCBF()
	{
		return IADEMLIIDPC;
	}

	public void CAOGIHDLAEA()
	{
		ShopUI.EAONFFENMCE(LADDMEMMJFP().EHHOHCPHAAO).shop = shop;
		ShopUI.EPKNOMLADCL(NGIMIHFFNMH().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	[SpecialName]
	public static BirdSellerNPC OPILDPFDFKJ()
	{
		return IADEMLIIDPC;
	}

	public void LFAPOMEEBJI()
	{
		ShopUI.NALKHGMLALJ(KNOKBLFFNLM().EHHOHCPHAAO).shop = shop;
		ShopUI.NALKHGMLALJ(CHPEMJMLDCN().EHHOHCPHAAO).OpenUI();
	}

	public void BOIOLKHGNPO(string emotion)
	{
		CHPEMJMLDCN().emotionsController.DCCNJLBLFGI(emotion);
	}

	[SpecialName]
	public static BirdSellerNPC BADFKMEJOKE()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BirdSellerNPC NGIMIHFFNMH()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BirdSellerNPC PCJCIHANCLE()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BirdSellerNPC DIHCEGINELM()
	{
		return IADEMLIIDPC;
	}

	public void LILJHCMANII()
	{
		ShopUI.NALKHGMLALJ(NBENKBAIBOO().EHHOHCPHAAO).shop = shop;
		ShopUI.IEABDMDELFO(GIKECEGLFOH().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	[SpecialName]
	public static BirdSellerNPC KNOKBLFFNLM()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BirdSellerNPC BIIOFAHFNPA()
	{
		return IADEMLIIDPC;
	}

	public void BKILDJBIIHL(string emotion)
	{
		CHPEMJMLDCN().emotionsController.NBFIDOGMLOK(emotion);
	}

	[SpecialName]
	public static BirdSellerNPC NHKAFANMEJC()
	{
		return IADEMLIIDPC;
	}

	public void DLAKKOCDNBI(string emotion)
	{
		BGMJCCFNNDL().emotionsController.NMAPMPBAGMM(emotion);
	}

	public void JDJGFIJPCIF(string emotion)
	{
		LFPEPJBNCBF().emotionsController.EMMBEAHMDHE(emotion);
	}

	public void IHFOJNJAALB(string emotion)
	{
		NGIMIHFFNMH().emotionsController.EMMBEAHMDHE(emotion);
	}

	[SpecialName]
	public static BirdSellerNPC EJECEDMPCOH()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BirdSellerNPC JLNBMNKJCHE()
	{
		return IADEMLIIDPC;
	}

	public void FNHBGDGAJGF()
	{
		ShopUI.IEKODILKIHJ(CHPEMJMLDCN().EHHOHCPHAAO).shop = shop;
		ShopUI.EAONFFENMCE(DHDOLCONMFJ().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	public void IDPKDDHFGBF()
	{
		ShopUI.IEABDMDELFO(LKOABOAADCD().EHHOHCPHAAO).shop = shop;
		ShopUI.NALKHGMLALJ(NHKAFANMEJC().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	[SpecialName]
	public static BirdSellerNPC IBEGPMLJIOJ()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BirdSellerNPC NBENKBAIBOO()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BirdSellerNPC KGPJPILAHDE()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BirdSellerNPC LPFNKEOJJKE()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BirdSellerNPC MPLODJJFKAM()
	{
		return IADEMLIIDPC;
	}

	protected override void OnConversationEnd(Transform actor)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		base.OnConversationEnd(actor);
		if (Time.time > birdSellerVisual.barkOutroTime)
		{
			Bark("Crowly_Barks_Bye", CDPAMNIPPEC: true, IPIKKGONHEB: true);
			birdSellerVisual.barkOutroTime = (float)Random.Range(15, 25) + Time.time;
		}
		Result variable;
		if (MNAFHFDJPIN)
		{
			PlayerInventory.GetPlayer(base.EHHOHCPHAAO).RemoveItem(ItemDatabaseAccessor.GetItem(1225));
			MNAFHFDJPIN = false;
		}
		else
		{
			variable = DialogueLua.GetVariable("Owl");
			if (((Result)(ref variable)).asBool)
			{
				if (PlayerInventory.GetPlayer(base.EHHOHCPHAAO).HasItem(ItemDatabaseAccessor.GetItem(1123)) && PlayerInventory.GetPlayer(base.EHHOHCPHAAO).GetSlotWithItem(ItemDatabaseAccessor.GetItem(1123), null).itemInstance is PhaseItemInstance phaseItemInstance)
				{
					phaseItemInstance.JKMBDADNOCD();
					phaseItemInstance.JKMBDADNOCD();
					phaseItemInstance.JKMBDADNOCD();
				}
				DialogueLua.SetVariable("Owl", (object)false);
			}
		}
		if (OnlineManager.PlayingOnline())
		{
			int hKKKNMIKPCM = HKKKNMIKPCM;
			variable = DialogueLua.GetVariable(HDFMHCKKJJG);
			if (hKKKNMIKPCM != ((Result)(ref variable)).asInt)
			{
				OnlineDialogueManager instance = OnlineDialogueManager.instance;
				string hDFMHCKKJJG = HDFMHCKKJJG;
				variable = DialogueLua.GetVariable(HDFMHCKKJJG);
				instance.SendDialogueInfo(hDFMHCKKJJG, ((Result)(ref variable)).asInt);
			}
			int gOKNJHLHBOO = GOKNJHLHBOO;
			variable = DialogueLua.GetVariable("TucanEgg");
			if (gOKNJHLHBOO != ((Result)(ref variable)).asInt)
			{
				OnlineDialogueManager instance2 = OnlineDialogueManager.instance;
				variable = DialogueLua.GetVariable("TucanEgg");
				instance2.SendDialogueInfo("TucanEgg", ((Result)(ref variable)).asInt);
			}
			int fELPMINODKO = FELPMINODKO;
			variable = DialogueLua.GetVariable("SkeletonBird");
			if (fELPMINODKO != ((Result)(ref variable)).asInt)
			{
				OnlineDialogueManager instance3 = OnlineDialogueManager.instance;
				variable = DialogueLua.GetVariable("SkeletonBird");
				instance3.SendDialogueInfo("SkeletonBird", ((Result)(ref variable)).asInt);
			}
			int kKAODEMABNN = KKAODEMABNN;
			variable = DialogueLua.GetVariable("RaraAvisDelivered");
			if (kKAODEMABNN != ((Result)(ref variable)).asInt)
			{
				OnlineDialogueManager instance4 = OnlineDialogueManager.instance;
				variable = DialogueLua.GetVariable("RaraAvisDelivered");
				instance4.SendDialogueInfo("RaraAvisDelivered", ((Result)(ref variable)).asInt);
			}
		}
	}

	public void BPDPPBDHJEL(string emotion)
	{
		BAKPBHPNKPB().emotionsController.NMAPMPBAGMM(emotion);
	}

	public void LAANEEHHDLL(string emotion)
	{
		CHPEMJMLDCN().emotionsController.DCCNJLBLFGI(emotion);
	}

	public void EHNOMMGCNHI()
	{
		ShopUI.JCBPABNCBPI(BIIOFAHFNPA().EHHOHCPHAAO).shop = shop;
		ShopUI.IEABDMDELFO(JHMAMLIPBNN().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	[SpecialName]
	public static BirdSellerNPC HNNJEBNIPOI()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BirdSellerNPC FOPGLLMEEDE()
	{
		return IADEMLIIDPC;
	}

	public void GHHNOBDPPEP(string emotion)
	{
		NBENKBAIBOO().emotionsController.GPLECKGJFKM(emotion);
	}

	[SpecialName]
	public static BirdSellerNPC LADDMEMMJFP()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BirdSellerNPC LKOABOAADCD()
	{
		return IADEMLIIDPC;
	}

	public void IKHIGKHJJDP()
	{
		ShopUI.EAONFFENMCE(BGMJCCFNNDL().EHHOHCPHAAO).shop = shop;
		ShopUI.EPKNOMLADCL(BADFKMEJOKE().EHHOHCPHAAO).OpenUI();
	}

	public void EGMMLIDHCFN()
	{
		ShopUI.EPKNOMLADCL(PCJCIHANCLE().EHHOHCPHAAO).shop = shop;
		ShopUI.EAONFFENMCE(KPDFIEMDDCL().EHHOHCPHAAO).OpenUI();
	}

	public void CFJNIKJFCPE(string emotion)
	{
		EAGMIHGJKNB().emotionsController.DCCNJLBLFGI(emotion);
	}

	[SpecialName]
	public static BirdSellerNPC DEGPIHEEFHJ()
	{
		return IADEMLIIDPC;
	}

	protected override void Awake()
	{
		base.Awake();
		IADEMLIIDPC = this;
	}

	public void MMBHJICBLND(string emotion)
	{
		MPJJAPCFENH().emotionsController.StartEmotion(emotion);
	}

	public override DialogueNPCBase GetInstance()
	{
		return GGFJGHHHEJC;
	}

	public void BCGOJIJEPLL()
	{
		ShopUI.FKFNANNBIAM(KPDFIEMDDCL().EHHOHCPHAAO).shop = shop;
		ShopUI.JCBPABNCBPI(KPDFIEMDDCL().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	[SpecialName]
	public static BirdSellerNPC JBBNILLDPCJ()
	{
		return IADEMLIIDPC;
	}

	public void OpenShop()
	{
		ShopUI.Get(GGFJGHHHEJC.EHHOHCPHAAO).shop = shop;
		ShopUI.Get(GGFJGHHHEJC.EHHOHCPHAAO).OpenUI();
	}

	[SpecialName]
	public static BirdSellerNPC DHDOLCONMFJ()
	{
		return IADEMLIIDPC;
	}

	public void OIJKIEPFMBO()
	{
		ShopUI.NALKHGMLALJ(KGPJPILAHDE().EHHOHCPHAAO).shop = shop;
		ShopUI.IEKODILKIHJ(JBBNILLDPCJ().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	public void NLBFEHJDELC(string emotion)
	{
		HGJMGNJOHGF().emotionsController.StartEmotion(emotion);
	}

	public void BEECLHMOEIP(string emotion)
	{
		IBEGPMLJIOJ().emotionsController.GPLECKGJFKM(emotion);
	}

	public void CJAOIANIGMA()
	{
		ShopUI.EAONFFENMCE(MLPCDJPLBAC().EHHOHCPHAAO).shop = shop;
		ShopUI.NALKHGMLALJ(HNNJEBNIPOI().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	[SpecialName]
	public static BirdSellerNPC NJNFHEPLEHL()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BirdSellerNPC DFJGHOHPPEL()
	{
		return IADEMLIIDPC;
	}

	public void PNBGLADEGME()
	{
		ShopUI.Get(OLHBLKIAFOM().EHHOHCPHAAO).shop = shop;
		ShopUI.EAONFFENMCE(LADDMEMMJFP().EHHOHCPHAAO).OpenUI();
	}

	public void MIKAMGHJJKO()
	{
		ShopUI.EPKNOMLADCL(MPJJAPCFENH().EHHOHCPHAAO).shop = shop;
		ShopUI.IEABDMDELFO(KGPJPILAHDE().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	[SpecialName]
	public static BirdSellerNPC JHMAMLIPBNN()
	{
		return IADEMLIIDPC;
	}

	public void DPBKPBPGCHO()
	{
		ShopUI.IEABDMDELFO(MNFMOEKMJKN().EHHOHCPHAAO).shop = shop;
		ShopUI.IEABDMDELFO(ELGNEJNLBNO().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	[SpecialName]
	public static BirdSellerNPC AHBBHCKPIIJ()
	{
		return IADEMLIIDPC;
	}

	public void NEGOMGJGHCP()
	{
		ShopUI.EAONFFENMCE(MPLODJJFKAM().EHHOHCPHAAO).shop = shop;
		ShopUI.EPKNOMLADCL(MOJDNGDNCCO().EHHOHCPHAAO).OpenUI();
	}

	public void NPDIHCNECMB()
	{
		ShopUI.AGNKKAPMHLN(DHDOLCONMFJ().EHHOHCPHAAO).shop = shop;
		ShopUI.IEABDMDELFO(HNNJEBNIPOI().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	public void FCOEGANLLCG()
	{
		ShopUI.AGNKKAPMHLN(JLNBMNKJCHE().EHHOHCPHAAO).shop = shop;
		ShopUI.FKFNANNBIAM(BIIOFAHFNPA().EHHOHCPHAAO).OpenUI();
	}

	public void AHFAJIBFKGK(string emotion)
	{
		KGPJPILAHDE().emotionsController.DCCNJLBLFGI(emotion);
	}

	[SpecialName]
	public static BirdSellerNPC HGJMGNJOHGF()
	{
		return IADEMLIIDPC;
	}

	public void LBEIJJCJLHB(string emotion)
	{
		NJNFHEPLEHL().emotionsController.NMAPMPBAGMM(emotion);
	}

	public void EIBOMLNHNLP()
	{
		ShopUI.EPKNOMLADCL(BNDNMBGJEKP().EHHOHCPHAAO).shop = shop;
		ShopUI.AGNKKAPMHLN(GGFJGHHHEJC.EHHOHCPHAAO).EDHEIFHAAKO();
	}

	public void GLJCEGJOHCB()
	{
		ShopUI.NALKHGMLALJ(MPLODJJFKAM().EHHOHCPHAAO).shop = shop;
		ShopUI.NALKHGMLALJ(EAGMIHGJKNB().EHHOHCPHAAO).OpenUI();
	}

	[SpecialName]
	public static BirdSellerNPC NGPHACGDNJN()
	{
		return IADEMLIIDPC;
	}

	public void LGJONNIEAOM(string emotion)
	{
		PCJCIHANCLE().emotionsController.NBFIDOGMLOK(emotion);
	}

	protected override void OnConversationStart(Transform actor)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		base.OnConversationStart(actor);
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		HKKKNMIKPCM = ((Result)(ref variable)).asInt;
		variable = DialogueLua.GetVariable("TucanEgg");
		GOKNJHLHBOO = ((Result)(ref variable)).asInt;
		variable = DialogueLua.GetVariable("SkeletonBird");
		FELPMINODKO = ((Result)(ref variable)).asInt;
		variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		HKKKNMIKPCM = ((Result)(ref variable)).asInt;
		variable = DialogueLua.GetVariable("TucanEgg");
		GOKNJHLHBOO = ((Result)(ref variable)).asInt;
		variable = DialogueLua.GetVariable("SkeletonBird");
		FELPMINODKO = ((Result)(ref variable)).asInt;
		variable = DialogueLua.GetVariable("RaraAvisDelivered");
		KKAODEMABNN = ((Result)(ref variable)).asInt;
		if (PlayerInventory.GetPlayer(base.EHHOHCPHAAO).HasItem(ItemDatabaseAccessor.GetItem(1123)))
		{
			DialogueLua.SetVariable("HaveStrangeEgg", (object)true);
		}
	}

	public void MNECFILCLIN()
	{
		ShopUI.Get(MNFMOEKMJKN().EHHOHCPHAAO).shop = shop;
		ShopUI.IEABDMDELFO(BNDNMBGJEKP().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	[SpecialName]
	public static BirdSellerNPC BNDNMBGJEKP()
	{
		return IADEMLIIDPC;
	}

	public void HHECLDCGGBE(string emotion)
	{
		MNFMOEKMJKN().emotionsController.EMMBEAHMDHE(emotion);
	}

	public void AEGFBPGGENM(string emotion)
	{
		NHKAFANMEJC().emotionsController.PIOCPGKDAOF(emotion);
	}

	[SpecialName]
	public static BirdSellerNPC KPDFIEMDDCL()
	{
		return IADEMLIIDPC;
	}

	public void IBOKNPCBAMO()
	{
		ShopUI.EAONFFENMCE(BADFKMEJOKE().EHHOHCPHAAO).shop = shop;
		ShopUI.JCBPABNCBPI(IBEGPMLJIOJ().EHHOHCPHAAO).OpenUI();
	}

	[SpecialName]
	public static BirdSellerNPC BAKPBHPNKPB()
	{
		return IADEMLIIDPC;
	}

	public void JHCCMJCJOBP()
	{
		ShopUI.IEABDMDELFO(OJJDNLEFNPJ().EHHOHCPHAAO).shop = shop;
		ShopUI.NALKHGMLALJ(BAKPBHPNKPB().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	public void HMEFIIDEMOL(string emotion)
	{
		GIKECEGLFOH().emotionsController.GPLECKGJFKM(emotion);
	}

	public void EFPPOOJFNJO(string emotion)
	{
		EJECEDMPCOH().emotionsController.NMAPMPBAGMM(emotion);
	}

	public void NDKHAPCBIMF()
	{
		ShopUI.EAONFFENMCE(IBEGPMLJIOJ().EHHOHCPHAAO).shop = shop;
		ShopUI.JCBPABNCBPI(OLHBLKIAFOM().EHHOHCPHAAO).OpenUI();
	}

	public void PCLHKBKNEPK()
	{
		ShopUI.IEKODILKIHJ(CHPEMJMLDCN().EHHOHCPHAAO).shop = shop;
		ShopUI.NALKHGMLALJ(HGJMGNJOHGF().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	public void KEPKAGDDLCK()
	{
		ShopUI.IEKODILKIHJ(FOPGLLMEEDE().EHHOHCPHAAO).shop = shop;
		ShopUI.EPKNOMLADCL(FOPGLLMEEDE().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	public void HFLEIKDDPCO(string emotion)
	{
		GIKECEGLFOH().emotionsController.GPLECKGJFKM(emotion);
	}

	public void GAADIDHFPGP(string emotion)
	{
		MPLODJJFKAM().emotionsController.NBFIDOGMLOK(emotion);
	}

	public void LGOKBJEJDKK(string emotion)
	{
		JLNBMNKJCHE().emotionsController.DCCNJLBLFGI(emotion);
	}

	[SpecialName]
	public static BirdSellerNPC MPJJAPCFENH()
	{
		return IADEMLIIDPC;
	}

	public void GOLGBIFLEDM(string emotion)
	{
		LKOABOAADCD().emotionsController.GPLECKGJFKM(emotion);
	}

	public void HICGHFBHDHG(string emotion)
	{
		GGFJGHHHEJC.emotionsController.PIOCPGKDAOF(emotion);
	}

	[SpecialName]
	public static BirdSellerNPC BGMJCCFNNDL()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static BirdSellerNPC CHPEMJMLDCN()
	{
		return IADEMLIIDPC;
	}

	public void DJCHJDHPCLK(string emotion)
	{
		BADFKMEJOKE().emotionsController.GPLECKGJFKM(emotion);
	}

	public void IAFBGAMAOID(string emotion)
	{
		DIHCEGINELM().emotionsController.NMAPMPBAGMM(emotion);
	}

	public void PGFPIOGKHJE(string emotion)
	{
		KPDFIEMDDCL().emotionsController.GPLECKGJFKM(emotion);
	}

	[SpecialName]
	public static BirdSellerNPC GIKECEGLFOH()
	{
		return IADEMLIIDPC;
	}

	public void JNIAOLELAED()
	{
		ShopUI.FKFNANNBIAM(KNOKBLFFNLM().EHHOHCPHAAO).shop = shop;
		ShopUI.FKFNANNBIAM(BGMJCCFNNDL().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	[SpecialName]
	public static BirdSellerNPC MLPCDJPLBAC()
	{
		return IADEMLIIDPC;
	}

	public void EJDPBEOHOFM()
	{
		ShopUI.IEABDMDELFO(BIIOFAHFNPA().EHHOHCPHAAO).shop = shop;
		ShopUI.AGNKKAPMHLN(DHDOLCONMFJ().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	public void EGLJIADCAHH()
	{
		ShopUI.NALKHGMLALJ(DHDOLCONMFJ().EHHOHCPHAAO).shop = shop;
		ShopUI.IEABDMDELFO(BGMJCCFNNDL().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	public void EEBOKKANBEM(string emotion)
	{
		OJJDNLEFNPJ().emotionsController.EMMBEAHMDHE(emotion);
	}

	public void PDNOKJKMEEJ(string emotion)
	{
		OJJDNLEFNPJ().emotionsController.StartEmotion(emotion);
	}

	public void FCHIEPKKLCP()
	{
		ShopUI.NALKHGMLALJ(MPJJAPCFENH().EHHOHCPHAAO).shop = shop;
		ShopUI.EAONFFENMCE(MNFMOEKMJKN().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	public void IGCKEKHJMPJ(string emotion)
	{
		HNNJEBNIPOI().emotionsController.EMMBEAHMDHE(emotion);
	}

	public void ONKHHNFPOEO()
	{
		ShopUI.Get(KPDFIEMDDCL().EHHOHCPHAAO).shop = shop;
		ShopUI.FKFNANNBIAM(NGIMIHFFNMH().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	[SpecialName]
	public static BirdSellerNPC HFIJHDBKCIA()
	{
		return IADEMLIIDPC;
	}

	public void GLJBJKJNHAN(string emotion)
	{
		NGIMIHFFNMH().emotionsController.StartEmotion(emotion);
	}

	public void GAPGANPHAEI(string emotion)
	{
		DFJGHOHPPEL().emotionsController.NBFIDOGMLOK(emotion);
	}

	public void FKMBKMPOMIH()
	{
		ShopUI.IEABDMDELFO(NGIMIHFFNMH().EHHOHCPHAAO).shop = shop;
		ShopUI.EAONFFENMCE(NJNFHEPLEHL().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	public void NIAHHEDHHLJ(string emotion)
	{
		HFIJHDBKCIA().emotionsController.NBFIDOGMLOK(emotion);
	}

	public void StartEmotions(string emotion)
	{
		GGFJGHHHEJC.emotionsController.StartEmotion(emotion);
	}

	public void DNHIHIIOINE(string emotion)
	{
		NHKAFANMEJC().emotionsController.NMAPMPBAGMM(emotion);
	}
}
