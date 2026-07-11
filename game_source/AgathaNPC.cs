using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class AgathaNPC : DialogueNPCBase
{
	private static AgathaNPC IADEMLIIDPC;

	public float timeBarks;

	private int HKKKNMIKPCM;

	private string HDFMHCKKJJG = "LE_13";

	public static AgathaNPC GGFJGHHHEJC => IADEMLIIDPC;

	protected override void Awake()
	{
		base.Awake();
		IADEMLIIDPC = this;
	}

	public void OOJEGKJLOED(string emotion)
	{
		BGMJCCFNNDL().emotionsController.DCCNJLBLFGI(emotion);
	}

	public void OpenShop()
	{
		ShopUI.Get(GGFJGHHHEJC.EHHOHCPHAAO).shop = shop;
		ShopUI.Get(GGFJGHHHEJC.EHHOHCPHAAO).OpenUI();
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

	public void BOIOLKHGNPO(string emotion)
	{
		AGGAGCBAGLL().emotionsController.GPLECKGJFKM(emotion);
	}

	public void GMCLNBNFBCE()
	{
		CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true, NNDJFLDGKDL: true);
	}

	private void IMIONHLAKIH()
	{
		NIKCFNPEDCC();
	}

	public void CJKKCFLCMKA(string emotion)
	{
		CMIHGBHPLFP().emotionsController.StartEmotion(emotion);
	}

	public void BLJCLIIFJBM()
	{
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
	}

	private void EOGHJNGJFID()
	{
		GMCLNBNFBCE();
	}

	public void StartEmotions(string emotion)
	{
		GGFJGHHHEJC.emotionsController.StartEmotion(emotion);
	}

	public void CDFAOMBADKD()
	{
		PlayerInventory.EIFPKCAFDIB(LKOABOAADCD().EHHOHCPHAAO, LAGHIOKLJGH: true, ADPNMHGBFKG: true).LFBNOHNNFBB(ItemDatabaseAccessor.COEFFIHKMJG(-38, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), 4, HMPDLIPFBGD: true, EHGHJNOFMKF: false, APBCMCOAFDM: true, AOPGMJEMEFK: true);
		PlayerInventory.NEKDDPIAOBE(LKOABOAADCD().EHHOHCPHAAO).OJDGOADOCMG(ItemDatabaseAccessor.CPMMBEPEJLO(-163, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
		PlayerInventory.EIFPKCAFDIB(BGMJCCFNNDL().EHHOHCPHAAO, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AINJENENGFG(ItemDatabaseAccessor.INJBNHPGCIJ(192, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), 0, HMPDLIPFBGD: true);
	}

	public void BNMNCCPANOE()
	{
		PlayerInventory.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AINJENENGFG(ItemDatabaseAccessor.GetItem(-45).JMDALJBNFML(), 4);
		PlayerInventory.GetPlayer(AGGAGCBAGLL().EHHOHCPHAAO, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AddItem(ItemDatabaseAccessor.GOKIDLOELKB(-180, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
		PlayerInventory.OGKNJNINGMH(ABHIDHPMLLD().EHHOHCPHAAO, LAGHIOKLJGH: false, ADPNMHGBFKG: true).LFBNOHNNFBB(ItemDatabaseAccessor.CPMMBEPEJLO(-16, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), 7, HMPDLIPFBGD: true, EHGHJNOFMKF: false, APBCMCOAFDM: false, AOPGMJEMEFK: true);
	}

	public void GKDJCAAEOMM()
	{
		PlayerInventory.NEKDDPIAOBE(AGGAGCBAGLL().EHHOHCPHAAO, LAGHIOKLJGH: true).AddItems(ItemDatabaseAccessor.GetItem(-46).JMDALJBNFML(), 5);
		PlayerInventory.GetPlayer(ABHIDHPMLLD().EHHOHCPHAAO, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AddItem(ItemDatabaseAccessor.EABMGELAAPG(-129, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: false, EHGHJNOFMKF: false);
		PlayerInventory.EIFPKCAFDIB(CMIHGBHPLFP().EHHOHCPHAAO, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AINJENENGFG(ItemDatabaseAccessor.CPMMBEPEJLO(128, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), 6);
	}

	public void MMBHJICBLND(string emotion)
	{
		AFFGPMFKEFH().emotionsController.StartEmotion(emotion);
	}

	private void DMFMNEMDFNP()
	{
		OBNBHKHHBIN();
	}

	private void PFLBPMIEKGF()
	{
		NGNJBPHNBAL();
	}

	public void NGNJBPHNBAL()
	{
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
	}

	public void CJMLIEFAPKE()
	{
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
	}

	public void PLHBJCCCBEL()
	{
		PlayerInventory.GetPlayer(BGMJCCFNNDL().EHHOHCPHAAO, LAGHIOKLJGH: true).AddItems(ItemDatabaseAccessor.GOKIDLOELKB(-144, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), 8, HMPDLIPFBGD: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
		PlayerInventory.GetPlayer(LKOABOAADCD().EHHOHCPHAAO, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AddItem(ItemDatabaseAccessor.AFOACBIHNCL(-83, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
		PlayerInventory.NEKDDPIAOBE(OJJDNLEFNPJ().EHHOHCPHAAO, LAGHIOKLJGH: true, ADPNMHGBFKG: true).LFBNOHNNFBB(ItemDatabaseAccessor.GetItem(-73, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), 5, HMPDLIPFBGD: false, EHGHJNOFMKF: true, APBCMCOAFDM: false);
	}

	private void HNEGFBCKIIJ()
	{
		OBNBHKHHBIN();
	}

	public void KAHFDCMHINM()
	{
		PlayerInventory.OGKNJNINGMH(GGFJGHHHEJC.EHHOHCPHAAO, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AINJENENGFG(ItemDatabaseAccessor.INJBNHPGCIJ(40, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), 8, HMPDLIPFBGD: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
		PlayerInventory.EIFPKCAFDIB(ABHIDHPMLLD().EHHOHCPHAAO, LAGHIOKLJGH: true).OJDGOADOCMG(ItemDatabaseAccessor.GetItem(71, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
		PlayerInventory.NEKDDPIAOBE(AFFGPMFKEFH().EHHOHCPHAAO, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AddItems(ItemDatabaseAccessor.INJBNHPGCIJ(-157).JMDALJBNFML(), 3, HMPDLIPFBGD: true);
	}

	public void HFLEIKDDPCO(string emotion)
	{
		OJJDNLEFNPJ().emotionsController.GPLECKGJFKM(emotion);
	}

	private void NFABFPFLNEE()
	{
		OBNBHKHHBIN();
	}

	public void LEMJPOBAJPO()
	{
		ShopUI.NALKHGMLALJ(CMIHGBHPLFP().EHHOHCPHAAO).shop = shop;
		ShopUI.EPKNOMLADCL(BGMJCCFNNDL().EHHOHCPHAAO).OpenUI();
	}

	public void JAJGMGJHKLG()
	{
		ShopUI.AGNKKAPMHLN(HFIJHDBKCIA().EHHOHCPHAAO).shop = shop;
		ShopUI.EPKNOMLADCL(OJJDNLEFNPJ().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	private void CEIIFHIBIFI()
	{
		NIKCFNPEDCC();
	}

	public void MJJIMIAPNEE()
	{
		ShopUI.EAONFFENMCE(LKOABOAADCD().EHHOHCPHAAO).shop = shop;
		ShopUI.IEABDMDELFO(LKOABOAADCD().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	private void JLCFNPBBKEK()
	{
		FAHDMOFILDI();
	}

	public void FCILFGBBOKA()
	{
		PlayerInventory.OGKNJNINGMH(CMIHGBHPLFP().EHHOHCPHAAO, LAGHIOKLJGH: true, ADPNMHGBFKG: true).LFBNOHNNFBB(ItemDatabaseAccessor.CPMMBEPEJLO(-18, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), 4);
		PlayerInventory.EIFPKCAFDIB(OJJDNLEFNPJ().EHHOHCPHAAO, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AddItem(ItemDatabaseAccessor.AFOACBIHNCL(53, GGBBJNBBLMF: true).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
		PlayerInventory.GetPlayer(OJJDNLEFNPJ().EHHOHCPHAAO, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AddItems(ItemDatabaseAccessor.KMBGJEKCJFJ(125, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), 6, HMPDLIPFBGD: true, EHGHJNOFMKF: false, APBCMCOAFDM: false, AOPGMJEMEFK: true);
	}

	public void IOKILGMHFNE(string emotion)
	{
		BGMJCCFNNDL().emotionsController.NBFIDOGMLOK(emotion);
	}

	private void BDJKNKIOPIJ()
	{
		GMCLNBNFBCE();
	}

	public void ENOPPCEHFGA()
	{
		PlayerInventory.EIFPKCAFDIB(HFIJHDBKCIA().EHHOHCPHAAO).AINJENENGFG(ItemDatabaseAccessor.COEFFIHKMJG(192).JMDALJBNFML(), 7, HMPDLIPFBGD: true, EHGHJNOFMKF: false, APBCMCOAFDM: true, AOPGMJEMEFK: true);
		PlayerInventory.OGKNJNINGMH(ABHIDHPMLLD().EHHOHCPHAAO, LAGHIOKLJGH: true).AddItem(ItemDatabaseAccessor.AFOACBIHNCL(76, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: false, EHGHJNOFMKF: false);
		PlayerInventory.OGKNJNINGMH(LKOABOAADCD().EHHOHCPHAAO).LFBNOHNNFBB(ItemDatabaseAccessor.GOKIDLOELKB(20, GGBBJNBBLMF: true).JMDALJBNFML(), 3, HMPDLIPFBGD: false, EHGHJNOFMKF: true, APBCMCOAFDM: true, AOPGMJEMEFK: true);
	}

	public void GiveItems()
	{
		PlayerInventory.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).AddItems(ItemDatabaseAccessor.GetItem(1118).JMDALJBNFML(), 3, HMPDLIPFBGD: true);
		PlayerInventory.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).AddItem(ItemDatabaseAccessor.GetItem(609).JMDALJBNFML(), HMPDLIPFBGD: true);
		PlayerInventory.GetPlayer(GGFJGHHHEJC.EHHOHCPHAAO).AddItems(ItemDatabaseAccessor.GetItem(630).JMDALJBNFML(), 8, HMPDLIPFBGD: true);
	}

	[SpecialName]
	public static AgathaNPC OJJDNLEFNPJ()
	{
		return IADEMLIIDPC;
	}

	public void NKPOKACBLPK()
	{
		PlayerInventory.GetPlayer(CMIHGBHPLFP().EHHOHCPHAAO).LFBNOHNNFBB(ItemDatabaseAccessor.EABMGELAAPG(13, GGBBJNBBLMF: true).JMDALJBNFML(), 7);
		PlayerInventory.OGKNJNINGMH(GGFJGHHHEJC.EHHOHCPHAAO).OJDGOADOCMG(ItemDatabaseAccessor.AFOACBIHNCL(197, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: false);
		PlayerInventory.NEKDDPIAOBE(GGFJGHHHEJC.EHHOHCPHAAO, LAGHIOKLJGH: true).AINJENENGFG(ItemDatabaseAccessor.INJBNHPGCIJ(-93, GGBBJNBBLMF: true).JMDALJBNFML(), 3, HMPDLIPFBGD: true, EHGHJNOFMKF: false);
	}

	public new void CheckExclamation()
	{
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
	}

	public void FAHDMOFILDI()
	{
		CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
	}

	private void JPHEOLEEAPB()
	{
		FAHDMOFILDI();
	}

	public void IFDBDGAOJHH()
	{
		PlayerInventory.GetPlayer(AGGAGCBAGLL().EHHOHCPHAAO).AINJENENGFG(ItemDatabaseAccessor.AFOACBIHNCL(-168, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), 8);
		PlayerInventory.OGKNJNINGMH(BGMJCCFNNDL().EHHOHCPHAAO).AddItem(ItemDatabaseAccessor.COEFFIHKMJG(-75, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false);
		PlayerInventory.OGKNJNINGMH(ABHIDHPMLLD().EHHOHCPHAAO, LAGHIOKLJGH: false, ADPNMHGBFKG: true).LFBNOHNNFBB(ItemDatabaseAccessor.CPMMBEPEJLO(151, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), 6, HMPDLIPFBGD: true);
	}

	[SpecialName]
	public static AgathaNPC AFFGPMFKEFH()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static AgathaNPC HFIJHDBKCIA()
	{
		return IADEMLIIDPC;
	}

	public override DialogueNPCBase GetInstance()
	{
		return GGFJGHHHEJC;
	}

	private void EGACIHOKJLH()
	{
		HNCEGJIJEOA();
	}

	public void LEADONDEOIC(string emotion)
	{
		AGGAGCBAGLL().emotionsController.NMAPMPBAGMM(emotion);
	}

	public void JLFNGOAPGOM(string emotion)
	{
		ABHIDHPMLLD().emotionsController.PIOCPGKDAOF(emotion);
	}

	protected override void NJJCCIBDAPM()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		barkDialogue = false;
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
		Result variable = DialogueLua.GetVariable("LE_13");
		if (((Result)(ref variable)).asInt == 0)
		{
			dialogue.conversation = "City/Agatha/Introduce";
		}
		else
		{
			dialogue.conversation = "City/Agatha/Stand";
		}
	}

	private void Start()
	{
		CheckExclamation();
	}

	protected override void OnConversationStart(Transform actor)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		base.OnConversationStart(actor);
		Result variable = DialogueLua.GetVariable(HDFMHCKKJJG);
		HKKKNMIKPCM = ((Result)(ref variable)).asInt;
	}

	public void EFPPOOJFNJO(string emotion)
	{
		BGMJCCFNNDL().emotionsController.StartEmotion(emotion);
	}

	public void FJPJHODBNIJ()
	{
		CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: true);
	}

	public void PEOMJDDEFDD()
	{
		ShopUI.IEKODILKIHJ(BGMJCCFNNDL().EHHOHCPHAAO).shop = shop;
		ShopUI.IEABDMDELFO(LKOABOAADCD().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	public void GOKMMKLBNNJ()
	{
		PlayerInventory.EIFPKCAFDIB(OJJDNLEFNPJ().EHHOHCPHAAO).AINJENENGFG(ItemDatabaseAccessor.GOKIDLOELKB(-116, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), 4, HMPDLIPFBGD: true);
		PlayerInventory.EIFPKCAFDIB(AGGAGCBAGLL().EHHOHCPHAAO, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AddItem(ItemDatabaseAccessor.GetItem(117).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
		PlayerInventory.GetPlayer(AFFGPMFKEFH().EHHOHCPHAAO, LAGHIOKLJGH: false, ADPNMHGBFKG: true).LFBNOHNNFBB(ItemDatabaseAccessor.INJBNHPGCIJ(-102, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), 6, HMPDLIPFBGD: false, EHGHJNOFMKF: false, APBCMCOAFDM: false);
	}

	public void EAKKCCGILAG()
	{
		PlayerInventory.GetPlayer(OJJDNLEFNPJ().EHHOHCPHAAO, LAGHIOKLJGH: true, ADPNMHGBFKG: true).LFBNOHNNFBB(ItemDatabaseAccessor.INJBNHPGCIJ(183, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), 2, HMPDLIPFBGD: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
		PlayerInventory.NEKDDPIAOBE(OJJDNLEFNPJ().EHHOHCPHAAO).AddItem(ItemDatabaseAccessor.GetItem(-186, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false, EHGHJNOFMKF: false);
		PlayerInventory.GetPlayer(CMIHGBHPLFP().EHHOHCPHAAO).AINJENENGFG(ItemDatabaseAccessor.AFOACBIHNCL(-93, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), 8, HMPDLIPFBGD: true, EHGHJNOFMKF: true, APBCMCOAFDM: true, AOPGMJEMEFK: true);
	}

	public void NDIPPMFIJEC()
	{
		ShopUI.Get(OJJDNLEFNPJ().EHHOHCPHAAO).shop = shop;
		ShopUI.Get(LKOABOAADCD().EHHOHCPHAAO).EDHEIFHAAKO();
	}

	[SpecialName]
	public static AgathaNPC AGGAGCBAGLL()
	{
		return IADEMLIIDPC;
	}

	public void PJGJGBEADMB(string emotion)
	{
		HFIJHDBKCIA().emotionsController.DCCNJLBLFGI(emotion);
	}

	public void EICNDMGMPLE(string emotion)
	{
		LKOABOAADCD().emotionsController.EMMBEAHMDHE(emotion);
	}

	public void LFAPOMEEBJI()
	{
		ShopUI.AGNKKAPMHLN(OJJDNLEFNPJ().EHHOHCPHAAO).shop = shop;
		ShopUI.Get(OJJDNLEFNPJ().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	public void BJCJPLCEJCG()
	{
		ShopUI.IEABDMDELFO(BGMJCCFNNDL().EHHOHCPHAAO).shop = shop;
		ShopUI.JCBPABNCBPI(CMIHGBHPLFP().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	public void NIKCFNPEDCC()
	{
		CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
	}

	[SpecialName]
	public static AgathaNPC CMIHGBHPLFP()
	{
		return IADEMLIIDPC;
	}

	private void CAIJLMJBMLA()
	{
		HNCEGJIJEOA();
	}

	private void KDBJHCAEGCM()
	{
		NGNJBPHNBAL();
	}

	public void HFLADABKILA()
	{
		PlayerInventory.NEKDDPIAOBE(AGGAGCBAGLL().EHHOHCPHAAO, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AddItems(ItemDatabaseAccessor.GOKIDLOELKB(-105).JMDALJBNFML(), 4, HMPDLIPFBGD: true, EHGHJNOFMKF: false);
		PlayerInventory.NEKDDPIAOBE(HFIJHDBKCIA().EHHOHCPHAAO).AddItem(ItemDatabaseAccessor.COEFFIHKMJG(-99, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: false, EHGHJNOFMKF: false, APBCMCOAFDM: false);
		PlayerInventory.NEKDDPIAOBE(AFFGPMFKEFH().EHHOHCPHAAO, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AINJENENGFG(ItemDatabaseAccessor.EABMGELAAPG(13, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), 3, HMPDLIPFBGD: false, EHGHJNOFMKF: false);
	}

	public void KCKGPHEACFO()
	{
		ShopUI.EPKNOMLADCL(OJJDNLEFNPJ().EHHOHCPHAAO).shop = shop;
		ShopUI.AGNKKAPMHLN(CMIHGBHPLFP().EHHOHCPHAAO).IDLAGJNLPJL();
	}

	public void OBNBHKHHBIN()
	{
		CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
	}

	public void EJNDKGALKEL()
	{
		PlayerInventory.OGKNJNINGMH(AFFGPMFKEFH().EHHOHCPHAAO).AINJENENGFG(ItemDatabaseAccessor.INJBNHPGCIJ(147, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), 1);
		PlayerInventory.OGKNJNINGMH(AGGAGCBAGLL().EHHOHCPHAAO, LAGHIOKLJGH: true, ADPNMHGBFKG: true).OJDGOADOCMG(ItemDatabaseAccessor.EABMGELAAPG(126, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false);
		PlayerInventory.NEKDDPIAOBE(GGFJGHHHEJC.EHHOHCPHAAO, LAGHIOKLJGH: true).LFBNOHNNFBB(ItemDatabaseAccessor.KMBGJEKCJFJ(-5, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), 3, HMPDLIPFBGD: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
	}

	[SpecialName]
	public static AgathaNPC LKOABOAADCD()
	{
		return IADEMLIIDPC;
	}

	public void HNCEGJIJEOA()
	{
		CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: true);
	}

	private void IDPHKHGHJGN()
	{
		HNCEGJIJEOA();
	}

	[SpecialName]
	public static AgathaNPC BGMJCCFNNDL()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static AgathaNPC ABHIDHPMLLD()
	{
		return IADEMLIIDPC;
	}
}
