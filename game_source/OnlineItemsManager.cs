using Photon.Pun;

public class OnlineItemsManager : MonoBehaviourPunCallbacks
{
	public static OnlineItemsManager instance;

	private void NLGHNDLPPKI()
	{
		instance = this;
	}

	private void GNAJBACLEKG()
	{
		instance = this;
	}

	private void KMEJBPOOBJK()
	{
		instance = this;
	}

	public void CCOOJIICJPO(int HLIFMPEJHKC, int MAJKOIELDNB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[7];
		array[1] = (short)HLIFMPEJHKC;
		array[1] = (short)MAJKOIELDNB;
		OnlineManager.SendRPC(photonView, "Miners/Camp/Ferro/Talk", (RpcTarget)1, array);
	}

	private void AAEAAEBBFKG()
	{
		instance = this;
	}

	public void NADCDLIGAEK(int HLIFMPEJHKC, int MAJKOIELDNB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = (short)HLIFMPEJHKC;
		array[1] = (short)MAJKOIELDNB;
		OnlineManager.SendRPC(photonView, "VERSION", (RpcTarget)1, array);
	}

	public void JODKBKMDKPH(int HLIFMPEJHKC, int MAJKOIELDNB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = (short)HLIFMPEJHKC;
		array[0] = (short)MAJKOIELDNB;
		OnlineManager.SendRPC(photonView, "Dialogue System/Conversation/TooHot/Entry/4/Dialogue Text", (RpcTarget)0, array);
	}

	private void FPNCANODJKE()
	{
		instance = this;
	}

	private void LJCHONOPGJP(short HLIFMPEJHKC, short MAJKOIELDNB)
	{
		PlayerInventory.EIFPKCAFDIB(0, LAGHIOKLJGH: true).AINJENENGFG(ItemDatabaseAccessor.CPMMBEPEJLO(HLIFMPEJHKC, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), MAJKOIELDNB, HMPDLIPFBGD: true, EHGHJNOFMKF: false, APBCMCOAFDM: false, AOPGMJEMEFK: true);
	}

	private void JLNGDCBIADJ(short HLIFMPEJHKC, short MAJKOIELDNB)
	{
		PlayerInventory.GetPlayer(0).LFBNOHNNFBB(ItemDatabaseAccessor.COEFFIHKMJG(HLIFMPEJHKC).JMDALJBNFML(), MAJKOIELDNB, HMPDLIPFBGD: true, EHGHJNOFMKF: false, APBCMCOAFDM: false, AOPGMJEMEFK: true);
	}

	private void KLFFAACDJGH(short HLIFMPEJHKC, short MAJKOIELDNB)
	{
		PlayerInventory.GetPlayer(0, LAGHIOKLJGH: true).AddItems(ItemDatabaseAccessor.COEFFIHKMJG(HLIFMPEJHKC, GGBBJNBBLMF: true).JMDALJBNFML(), MAJKOIELDNB);
	}

	private void NCPNBBCNBIM()
	{
		instance = this;
	}

	private void HPBCPENEEDK()
	{
		instance = this;
	}

	private void MFJIHCKEIIF()
	{
		instance = this;
	}

	private void BDNNCBPAHGP(short HLIFMPEJHKC, short MAJKOIELDNB)
	{
		PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: true).LFBNOHNNFBB(ItemDatabaseAccessor.GetItem(HLIFMPEJHKC, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), MAJKOIELDNB, HMPDLIPFBGD: true, EHGHJNOFMKF: false, APBCMCOAFDM: false, AOPGMJEMEFK: true);
	}

	private void HANBILGDBDE(short HLIFMPEJHKC, short MAJKOIELDNB)
	{
		PlayerInventory.EIFPKCAFDIB(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AINJENENGFG(ItemDatabaseAccessor.AFOACBIHNCL(HLIFMPEJHKC, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), MAJKOIELDNB, HMPDLIPFBGD: true, EHGHJNOFMKF: false);
	}

	public void NABIOLIBPKD(int HLIFMPEJHKC, int MAJKOIELDNB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[4];
		array[1] = (short)HLIFMPEJHKC;
		array[1] = (short)MAJKOIELDNB;
		OnlineManager.SendRPC(photonView, "veggieDishes", (RpcTarget)1, array);
	}

	private void OONCGNNNMCC(short HLIFMPEJHKC, short MAJKOIELDNB)
	{
		PlayerInventory.NEKDDPIAOBE(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AINJENENGFG(ItemDatabaseAccessor.AFOACBIHNCL(HLIFMPEJHKC).JMDALJBNFML(), MAJKOIELDNB, HMPDLIPFBGD: true, EHGHJNOFMKF: true, APBCMCOAFDM: false, AOPGMJEMEFK: true);
	}

	public void IBNOPGFCDPI(int HLIFMPEJHKC, int MAJKOIELDNB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[5];
		array[1] = (short)HLIFMPEJHKC;
		array[1] = (short)MAJKOIELDNB;
		OnlineManager.SendRPC(photonView, "d2", (RpcTarget)0, array);
	}

	private void LBHFIFJIEJJ(short HLIFMPEJHKC, short MAJKOIELDNB)
	{
		PlayerInventory.OGKNJNINGMH(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AddItems(ItemDatabaseAccessor.CPMMBEPEJLO(HLIFMPEJHKC, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), MAJKOIELDNB, HMPDLIPFBGD: true, EHGHJNOFMKF: false, APBCMCOAFDM: true, AOPGMJEMEFK: true);
	}

	private void MFKOFHPBHEI(short HLIFMPEJHKC, short MAJKOIELDNB)
	{
		PlayerInventory.OGKNJNINGMH(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).LFBNOHNNFBB(ItemDatabaseAccessor.INJBNHPGCIJ(HLIFMPEJHKC, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), MAJKOIELDNB);
	}

	public void AALEPAMLLGO(int HLIFMPEJHKC, int MAJKOIELDNB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[2];
		array[1] = (short)HLIFMPEJHKC;
		array[0] = (short)MAJKOIELDNB;
		OnlineManager.SendRPC(photonView, "Object with itemID ", (RpcTarget)0, array);
	}

	private void KDHLJKMKFMG()
	{
		instance = this;
	}

	public void NJDIAJCGPEP(int HLIFMPEJHKC, int MAJKOIELDNB)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "GO", (RpcTarget)0, (short)HLIFMPEJHKC, (short)MAJKOIELDNB, null);
	}

	public void MJPCEJBPLNK(int HLIFMPEJHKC, int MAJKOIELDNB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[5];
		array[0] = (short)HLIFMPEJHKC;
		array[0] = (short)MAJKOIELDNB;
		OnlineManager.SendRPC(photonView, "HairShadow", (RpcTarget)0, array);
	}

	private void PNLAJCHBHPH()
	{
		instance = this;
	}

	public void GAEIFHHAKDK(int HLIFMPEJHKC, int MAJKOIELDNB)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, " : 00", (RpcTarget)0, (short)HLIFMPEJHKC, (short)MAJKOIELDNB, null);
	}

	private void AIHCKEOOIBC(short HLIFMPEJHKC, short MAJKOIELDNB)
	{
		PlayerInventory.GetPlayer(0, LAGHIOKLJGH: true).AddItems(ItemDatabaseAccessor.INJBNHPGCIJ(HLIFMPEJHKC).JMDALJBNFML(), MAJKOIELDNB, HMPDLIPFBGD: false, EHGHJNOFMKF: true, APBCMCOAFDM: true, AOPGMJEMEFK: true);
	}

	public void EFAJMCHDMID(int HLIFMPEJHKC, int MAJKOIELDNB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = (short)HLIFMPEJHKC;
		array[0] = (short)MAJKOIELDNB;
		OnlineManager.SendRPC(photonView, "Speed", (RpcTarget)1, array);
	}

	private void AGEDPIBCMOO(short HLIFMPEJHKC, short MAJKOIELDNB)
	{
		PlayerInventory.NEKDDPIAOBE(1).AddItems(ItemDatabaseAccessor.GetItem(HLIFMPEJHKC).JMDALJBNFML(), MAJKOIELDNB, HMPDLIPFBGD: true, EHGHJNOFMKF: true, APBCMCOAFDM: false, AOPGMJEMEFK: true);
	}

	public void LLGLALACOOK(int HLIFMPEJHKC, int MAJKOIELDNB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[2];
		array[0] = (short)HLIFMPEJHKC;
		array[0] = (short)MAJKOIELDNB;
		OnlineManager.SendRPC(photonView, "OnlyABird", (RpcTarget)0, array);
	}

	private void CFCICCFDAOH(short HLIFMPEJHKC, short MAJKOIELDNB)
	{
		PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AINJENENGFG(ItemDatabaseAccessor.INJBNHPGCIJ(HLIFMPEJHKC, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), MAJKOIELDNB, HMPDLIPFBGD: false, EHGHJNOFMKF: false, APBCMCOAFDM: false, AOPGMJEMEFK: true);
	}

	private void MMHEPLFFAEH(short HLIFMPEJHKC, short MAJKOIELDNB)
	{
		PlayerInventory.GetPlayer(0).LFBNOHNNFBB(ItemDatabaseAccessor.KMBGJEKCJFJ(HLIFMPEJHKC, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), MAJKOIELDNB, HMPDLIPFBGD: false, EHGHJNOFMKF: true, APBCMCOAFDM: false);
	}

	public void GBBGKILFLGJ(int HLIFMPEJHKC, int MAJKOIELDNB)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "", (RpcTarget)1, (short)HLIFMPEJHKC, (short)MAJKOIELDNB, null);
	}

	private void LJIADJKCFFN(short HLIFMPEJHKC, short MAJKOIELDNB)
	{
		PlayerInventory.OGKNJNINGMH(1).AINJENENGFG(ItemDatabaseAccessor.EABMGELAAPG(HLIFMPEJHKC, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), MAJKOIELDNB, HMPDLIPFBGD: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
	}

	public void JHKKEIJMDJJ(int HLIFMPEJHKC, int MAJKOIELDNB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = (short)HLIFMPEJHKC;
		array[0] = (short)MAJKOIELDNB;
		OnlineManager.SendRPC(photonView, "Mouth", (RpcTarget)0, array);
	}

	private void MNOCOCMFHOF(short HLIFMPEJHKC, short MAJKOIELDNB)
	{
		PlayerInventory.GetPlayer(1, LAGHIOKLJGH: true).AINJENENGFG(ItemDatabaseAccessor.CPMMBEPEJLO(HLIFMPEJHKC, GGBBJNBBLMF: true).JMDALJBNFML(), MAJKOIELDNB, HMPDLIPFBGD: true, EHGHJNOFMKF: true, APBCMCOAFDM: false, AOPGMJEMEFK: true);
	}

	private void DNBGIIGAKMJ()
	{
		instance = this;
	}

	private void KBNMLJNBBMP()
	{
		instance = this;
	}

	private void AAENCDNIBFJ()
	{
		instance = this;
	}

	private void JIAJFDKNJME()
	{
		instance = this;
	}

	private void NAOBODGBECL()
	{
		instance = this;
	}

	private void OCLMCGKNEAA(short HLIFMPEJHKC, short MAJKOIELDNB)
	{
		PlayerInventory.NEKDDPIAOBE(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AddItems(ItemDatabaseAccessor.GetItem(HLIFMPEJHKC, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), MAJKOIELDNB, HMPDLIPFBGD: true, EHGHJNOFMKF: false);
	}

	private void PCKOHAIPHFI()
	{
		instance = this;
	}

	private void PGEGODAEBLC()
	{
		instance = this;
	}

	public void MEGNOGAJKDG(int HLIFMPEJHKC, int MAJKOIELDNB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[4];
		array[1] = (short)HLIFMPEJHKC;
		array[1] = (short)MAJKOIELDNB;
		OnlineManager.SendRPC(photonView, "Items/item_description_649", (RpcTarget)0, array);
	}

	public void KBALDHMJDJO(int HLIFMPEJHKC, int MAJKOIELDNB)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Send next game date as a host ", (RpcTarget)1, (short)HLIFMPEJHKC, (short)MAJKOIELDNB, null, null, null, null, null);
	}

	private void KNBEOFOFCEG(short HLIFMPEJHKC, short MAJKOIELDNB)
	{
		PlayerInventory.NEKDDPIAOBE(0).LFBNOHNNFBB(ItemDatabaseAccessor.AFOACBIHNCL(HLIFMPEJHKC, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), MAJKOIELDNB, HMPDLIPFBGD: false, EHGHJNOFMKF: false);
	}

	public void FNBCPIIEAPH(int HLIFMPEJHKC, int MAJKOIELDNB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = (short)HLIFMPEJHKC;
		array[0] = (short)MAJKOIELDNB;
		OnlineManager.SendRPC(photonView, "", (RpcTarget)0, array);
	}

	public void CKHFLJGCCJN(int HLIFMPEJHKC, int MAJKOIELDNB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[4];
		array[0] = (short)HLIFMPEJHKC;
		array[0] = (short)MAJKOIELDNB;
		OnlineManager.SendRPC(photonView, "Pool Parent ", (RpcTarget)1, array);
	}

	[PunRPC]
	private void ReceiveItemsFromOtherPlayer(short HLIFMPEJHKC, short MAJKOIELDNB)
	{
		PlayerInventory.GetPlayer(1).AddItems(ItemDatabaseAccessor.GetItem(HLIFMPEJHKC).JMDALJBNFML(), MAJKOIELDNB, HMPDLIPFBGD: true);
	}

	public void BFHJGLGJCMB(int HLIFMPEJHKC, int MAJKOIELDNB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[2];
		array[0] = (short)HLIFMPEJHKC;
		array[0] = (short)MAJKOIELDNB;
		OnlineManager.SendRPC(photonView, " EnterState().", (RpcTarget)0, array);
	}

	private void ANHMMJEBFBO(short HLIFMPEJHKC, short MAJKOIELDNB)
	{
		PlayerInventory.NEKDDPIAOBE(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AINJENENGFG(ItemDatabaseAccessor.CPMMBEPEJLO(HLIFMPEJHKC).JMDALJBNFML(), MAJKOIELDNB, HMPDLIPFBGD: false, EHGHJNOFMKF: true, APBCMCOAFDM: false);
	}

	private void PKLHKJPCMJH(short HLIFMPEJHKC, short MAJKOIELDNB)
	{
		PlayerInventory.OGKNJNINGMH(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).LFBNOHNNFBB(ItemDatabaseAccessor.EABMGELAAPG(HLIFMPEJHKC, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), MAJKOIELDNB, HMPDLIPFBGD: false, EHGHJNOFMKF: false);
	}

	private void FNNMONIICAB(short HLIFMPEJHKC, short MAJKOIELDNB)
	{
		PlayerInventory.OGKNJNINGMH(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).LFBNOHNNFBB(ItemDatabaseAccessor.AFOACBIHNCL(HLIFMPEJHKC, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), MAJKOIELDNB, HMPDLIPFBGD: false, EHGHJNOFMKF: true, APBCMCOAFDM: false, AOPGMJEMEFK: true);
	}

	private void KLGCMMIKGIO()
	{
		instance = this;
	}

	private void EHBMONGBJFI()
	{
		instance = this;
	}

	private void JDFNODJCHAC(short HLIFMPEJHKC, short MAJKOIELDNB)
	{
		PlayerInventory.NEKDDPIAOBE(0).AINJENENGFG(ItemDatabaseAccessor.KMBGJEKCJFJ(HLIFMPEJHKC, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), MAJKOIELDNB, HMPDLIPFBGD: true, EHGHJNOFMKF: false, APBCMCOAFDM: true, AOPGMJEMEFK: true);
	}

	private void LFKANGBJLGO()
	{
		instance = this;
	}

	public void APADHDBOFGN(int HLIFMPEJHKC, int MAJKOIELDNB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = (short)HLIFMPEJHKC;
		array[1] = (short)MAJKOIELDNB;
		OnlineManager.SendRPC(photonView, "Intro08", (RpcTarget)1, array);
	}

	public void KHFDAGDACPA(int HLIFMPEJHKC, int MAJKOIELDNB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = (short)HLIFMPEJHKC;
		array[0] = (short)MAJKOIELDNB;
		OnlineManager.SendRPC(photonView, "HarvestableAllYearRound", (RpcTarget)1, array);
	}

	private void KMBEOPAHKGB()
	{
		instance = this;
	}

	public void GBLECDOGDEM(int HLIFMPEJHKC, int MAJKOIELDNB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[7];
		array[0] = (short)HLIFMPEJHKC;
		array[0] = (short)MAJKOIELDNB;
		OnlineManager.SendRPC(photonView, "Get Components ", (RpcTarget)1, array);
	}

	private void CLLPDGPFAPI(short HLIFMPEJHKC, short MAJKOIELDNB)
	{
		PlayerInventory.NEKDDPIAOBE(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AINJENENGFG(ItemDatabaseAccessor.AFOACBIHNCL(HLIFMPEJHKC, GGBBJNBBLMF: true).JMDALJBNFML(), MAJKOIELDNB, HMPDLIPFBGD: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
	}

	public void AMGADPDLJLC(int HLIFMPEJHKC, int MAJKOIELDNB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[8];
		array[1] = (short)HLIFMPEJHKC;
		array[0] = (short)MAJKOIELDNB;
		OnlineManager.SendRPC(photonView, "Tutorial/T", (RpcTarget)1, array);
	}

	public void FJKIEDBAAAJ(int HLIFMPEJHKC, int MAJKOIELDNB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[4];
		array[0] = (short)HLIFMPEJHKC;
		array[0] = (short)MAJKOIELDNB;
		OnlineManager.SendRPC(photonView, "Sleep", (RpcTarget)0, array);
	}

	public void AOFLPICCJJL(int HLIFMPEJHKC, int MAJKOIELDNB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[3];
		array[1] = (short)HLIFMPEJHKC;
		array[0] = (short)MAJKOIELDNB;
		OnlineManager.SendRPC(photonView, "ZoneCostBonus", (RpcTarget)1, array);
	}

	private void AHLJHBIODDA(short HLIFMPEJHKC, short MAJKOIELDNB)
	{
		PlayerInventory.GetPlayer(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AINJENENGFG(ItemDatabaseAccessor.INJBNHPGCIJ(HLIFMPEJHKC, GGBBJNBBLMF: true).JMDALJBNFML(), MAJKOIELDNB, HMPDLIPFBGD: false, EHGHJNOFMKF: false, APBCMCOAFDM: false, AOPGMJEMEFK: true);
	}

	public void GDMIPHJKFKE(int HLIFMPEJHKC, int MAJKOIELDNB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[6];
		array[1] = (short)HLIFMPEJHKC;
		array[1] = (short)MAJKOIELDNB;
		OnlineManager.SendRPC(photonView, "  Profundidad: hasta nivel {0}", (RpcTarget)1, array);
	}

	private void BDAFMIFENOH(short HLIFMPEJHKC, short MAJKOIELDNB)
	{
		PlayerInventory.GetPlayer(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AddItems(ItemDatabaseAccessor.KMBGJEKCJFJ(HLIFMPEJHKC, GGBBJNBBLMF: true).JMDALJBNFML(), MAJKOIELDNB, HMPDLIPFBGD: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
	}

	public void KCNAICPHNLP(int HLIFMPEJHKC, int MAJKOIELDNB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[2];
		array[0] = (short)HLIFMPEJHKC;
		array[0] = (short)MAJKOIELDNB;
		OnlineManager.SendRPC(photonView, "Toy", (RpcTarget)0, array);
	}

	private void NBFNKDAFELD(short HLIFMPEJHKC, short MAJKOIELDNB)
	{
		PlayerInventory.OGKNJNINGMH(0).AINJENENGFG(ItemDatabaseAccessor.GOKIDLOELKB(HLIFMPEJHKC, GGBBJNBBLMF: true).JMDALJBNFML(), MAJKOIELDNB, HMPDLIPFBGD: true, EHGHJNOFMKF: false, APBCMCOAFDM: true, AOPGMJEMEFK: true);
	}

	private void HPJBLOPJIMI()
	{
		instance = this;
	}

	private void HMHNMFKOHNC(short HLIFMPEJHKC, short MAJKOIELDNB)
	{
		PlayerInventory.NEKDDPIAOBE(0, LAGHIOKLJGH: true).LFBNOHNNFBB(ItemDatabaseAccessor.KMBGJEKCJFJ(HLIFMPEJHKC, GGBBJNBBLMF: true).JMDALJBNFML(), MAJKOIELDNB, HMPDLIPFBGD: false, EHGHJNOFMKF: false, APBCMCOAFDM: false);
	}

	private void KHLDNJOMAIB(short HLIFMPEJHKC, short MAJKOIELDNB)
	{
		PlayerInventory.NEKDDPIAOBE(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AddItems(ItemDatabaseAccessor.EABMGELAAPG(HLIFMPEJHKC, GGBBJNBBLMF: true).JMDALJBNFML(), MAJKOIELDNB, HMPDLIPFBGD: false, EHGHJNOFMKF: false, APBCMCOAFDM: false);
	}

	private void PGPPIHJJGDB()
	{
		instance = this;
	}

	private void JDHHJKBOJML()
	{
		instance = this;
	}

	private void FBADFFLGADO(short HLIFMPEJHKC, short MAJKOIELDNB)
	{
		PlayerInventory.OGKNJNINGMH(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).LFBNOHNNFBB(ItemDatabaseAccessor.EABMGELAAPG(HLIFMPEJHKC, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), MAJKOIELDNB, HMPDLIPFBGD: false, EHGHJNOFMKF: true, APBCMCOAFDM: true, AOPGMJEMEFK: true);
	}

	public void EGNLKICLIBD(int HLIFMPEJHKC, int MAJKOIELDNB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[7];
		array[0] = (short)HLIFMPEJHKC;
		array[0] = (short)MAJKOIELDNB;
		OnlineManager.SendRPC(photonView, "[MinePipePuzzle] Recibido swap online: {0} <-> {1}", (RpcTarget)0, array);
	}

	public void FLIJCEMJEOB(int HLIFMPEJHKC, int MAJKOIELDNB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[6];
		array[1] = (short)HLIFMPEJHKC;
		array[0] = (short)MAJKOIELDNB;
		OnlineManager.SendRPC(photonView, "Meditation", (RpcTarget)1, array);
	}

	public void LHHECAJMADF(int HLIFMPEJHKC, int MAJKOIELDNB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[6];
		array[1] = (short)HLIFMPEJHKC;
		array[0] = (short)MAJKOIELDNB;
		OnlineManager.SendRPC(photonView, "Items/item_name_1045", (RpcTarget)1, array);
	}

	private void KHCJDKHONPK()
	{
		instance = this;
	}

	public void ICPBPPGAHBL(int HLIFMPEJHKC, int MAJKOIELDNB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[8];
		array[1] = (short)HLIFMPEJHKC;
		array[0] = (short)MAJKOIELDNB;
		OnlineManager.SendRPC(photonView, "", (RpcTarget)1, array);
	}

	private void BHAFCBHENPL()
	{
		instance = this;
	}

	public void JGDKFAKFJJD(int HLIFMPEJHKC, int MAJKOIELDNB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = (short)HLIFMPEJHKC;
		array[1] = (short)MAJKOIELDNB;
		OnlineManager.SendRPC(photonView, "Pick up", (RpcTarget)1, array);
	}

	private void OCGIJMGIGDB(short HLIFMPEJHKC, short MAJKOIELDNB)
	{
		PlayerInventory.OGKNJNINGMH(1, LAGHIOKLJGH: true).LFBNOHNNFBB(ItemDatabaseAccessor.COEFFIHKMJG(HLIFMPEJHKC, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), MAJKOIELDNB, HMPDLIPFBGD: false, EHGHJNOFMKF: true, APBCMCOAFDM: false, AOPGMJEMEFK: true);
	}

	public void BPEDLPCBGLO(int HLIFMPEJHKC, int MAJKOIELDNB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[8];
		array[1] = (short)HLIFMPEJHKC;
		array[0] = (short)MAJKOIELDNB;
		OnlineManager.SendRPC(photonView, " (", (RpcTarget)0, array);
	}

	private void LBKKDMMINMK(short HLIFMPEJHKC, short MAJKOIELDNB)
	{
		PlayerInventory.NEKDDPIAOBE(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).LFBNOHNNFBB(ItemDatabaseAccessor.KMBGJEKCJFJ(HLIFMPEJHKC, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), MAJKOIELDNB, HMPDLIPFBGD: true);
	}

	private void IOKFIHJHLAE(short HLIFMPEJHKC, short MAJKOIELDNB)
	{
		PlayerInventory.EIFPKCAFDIB(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).LFBNOHNNFBB(ItemDatabaseAccessor.AFOACBIHNCL(HLIFMPEJHKC, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), MAJKOIELDNB, HMPDLIPFBGD: false, EHGHJNOFMKF: false, APBCMCOAFDM: false, AOPGMJEMEFK: true);
	}

	public void OBMMDGHBGMD(int HLIFMPEJHKC, int MAJKOIELDNB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[8];
		array[1] = (short)HLIFMPEJHKC;
		array[1] = (short)MAJKOIELDNB;
		OnlineManager.SendRPC(photonView, "FocusedMod", (RpcTarget)0, array);
	}

	public void SendItemsToOtherPlayers(int HLIFMPEJHKC, int MAJKOIELDNB)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveItemsFromOtherPlayer", (RpcTarget)1, (short)HLIFMPEJHKC, (short)MAJKOIELDNB);
	}

	private void HKDGCMPCIKB(short HLIFMPEJHKC, short MAJKOIELDNB)
	{
		PlayerInventory.GetPlayer(0, LAGHIOKLJGH: true).LFBNOHNNFBB(ItemDatabaseAccessor.INJBNHPGCIJ(HLIFMPEJHKC).JMDALJBNFML(), MAJKOIELDNB, HMPDLIPFBGD: false, EHGHJNOFMKF: false, APBCMCOAFDM: false);
	}

	public void HLGDEIBDJFJ(int HLIFMPEJHKC, int MAJKOIELDNB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[0] = (short)HLIFMPEJHKC;
		array[1] = (short)MAJKOIELDNB;
		OnlineManager.SendRPC(photonView, "Error_PlaceItInChickenCoop", (RpcTarget)1, array);
	}

	private void CFLKKIBFMAO(short HLIFMPEJHKC, short MAJKOIELDNB)
	{
		PlayerInventory.NEKDDPIAOBE(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).LFBNOHNNFBB(ItemDatabaseAccessor.AFOACBIHNCL(HLIFMPEJHKC).JMDALJBNFML(), MAJKOIELDNB, HMPDLIPFBGD: false, EHGHJNOFMKF: false);
	}

	public void CLDHMNBPBOH(int HLIFMPEJHKC, int MAJKOIELDNB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[4];
		array[1] = (short)HLIFMPEJHKC;
		array[0] = (short)MAJKOIELDNB;
		OnlineManager.SendRPC(photonView, "Items/item_description_1100", (RpcTarget)0, array);
	}

	public void DBFADIFKNDC(int HLIFMPEJHKC, int MAJKOIELDNB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[7];
		array[1] = (short)HLIFMPEJHKC;
		array[0] = (short)MAJKOIELDNB;
		OnlineManager.SendRPC(photonView, "cornHarvested", (RpcTarget)0, array);
	}

	private void HMHCLIBLKLN()
	{
		instance = this;
	}

	public void DMGECLBNHKG(int HLIFMPEJHKC, int MAJKOIELDNB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[3];
		array[1] = (short)HLIFMPEJHKC;
		array[0] = (short)MAJKOIELDNB;
		OnlineManager.SendRPC(photonView, "Items/item_description_600", (RpcTarget)0, array);
	}

	private void GFLFDLIMOLI()
	{
		instance = this;
	}

	private void IIPKPMPGLOL()
	{
		instance = this;
	}

	private void AHKBNMOECGA(short HLIFMPEJHKC, short MAJKOIELDNB)
	{
		PlayerInventory.NEKDDPIAOBE(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AddItems(ItemDatabaseAccessor.AFOACBIHNCL(HLIFMPEJHKC, GGBBJNBBLMF: true).JMDALJBNFML(), MAJKOIELDNB, HMPDLIPFBGD: false, EHGHJNOFMKF: false);
	}

	private void NNEBAHFHINE()
	{
		instance = this;
	}

	private void DNKEFFMOCKP()
	{
		instance = this;
	}

	public void BGFKDAKDLIO(int HLIFMPEJHKC, int MAJKOIELDNB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[4];
		array[0] = (short)HLIFMPEJHKC;
		array[0] = (short)MAJKOIELDNB;
		OnlineManager.SendRPC(photonView, "ChatCommandKickDescription", (RpcTarget)1, array);
	}

	public void OMDLOALIKEN(int HLIFMPEJHKC, int MAJKOIELDNB)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, ":", (RpcTarget)0, (short)HLIFMPEJHKC, (short)MAJKOIELDNB);
	}

	private void Awake()
	{
		instance = this;
	}

	private void HINGJCAGGKC(short HLIFMPEJHKC, short MAJKOIELDNB)
	{
		PlayerInventory.OGKNJNINGMH(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AINJENENGFG(ItemDatabaseAccessor.KMBGJEKCJFJ(HLIFMPEJHKC, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), MAJKOIELDNB, HMPDLIPFBGD: false, EHGHJNOFMKF: true, APBCMCOAFDM: false);
	}

	public void DLAIAIOINCN(int HLIFMPEJHKC, int MAJKOIELDNB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = (short)HLIFMPEJHKC;
		array[1] = (short)MAJKOIELDNB;
		OnlineManager.SendRPC(photonView, "BuildMode_ExitAndCancel", (RpcTarget)1, array);
	}

	public void FAAAALKEHNH(int HLIFMPEJHKC, int MAJKOIELDNB)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Plant", (RpcTarget)0, (short)HLIFMPEJHKC, (short)MAJKOIELDNB, null, null, null, null);
	}

	private void HMANFAEHJCA()
	{
		instance = this;
	}

	private void JKGAILEDDAO(short HLIFMPEJHKC, short MAJKOIELDNB)
	{
		PlayerInventory.OGKNJNINGMH(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AddItems(ItemDatabaseAccessor.KMBGJEKCJFJ(HLIFMPEJHKC, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), MAJKOIELDNB, HMPDLIPFBGD: false, EHGHJNOFMKF: true, APBCMCOAFDM: false, AOPGMJEMEFK: true);
	}

	public void JEPDPFOBPKN(int HLIFMPEJHKC, int MAJKOIELDNB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[6];
		array[0] = (short)HLIFMPEJHKC;
		array[0] = (short)MAJKOIELDNB;
		OnlineManager.SendRPC(photonView, "Right Stick Up", (RpcTarget)1, array);
	}

	public void NPHJNEPODAI(int HLIFMPEJHKC, int MAJKOIELDNB)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveMineLoadedForClient", (RpcTarget)0, (short)HLIFMPEJHKC, (short)MAJKOIELDNB, null, null, null, null, null);
	}

	public void CEEBOPFLNFK(int HLIFMPEJHKC, int MAJKOIELDNB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[5];
		array[1] = (short)HLIFMPEJHKC;
		array[0] = (short)MAJKOIELDNB;
		OnlineManager.SendRPC(photonView, "itemMelon", (RpcTarget)0, array);
	}

	private void IJJGKEKEHEI(short HLIFMPEJHKC, short MAJKOIELDNB)
	{
		PlayerInventory.OGKNJNINGMH(1).LFBNOHNNFBB(ItemDatabaseAccessor.CPMMBEPEJLO(HLIFMPEJHKC, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), MAJKOIELDNB, HMPDLIPFBGD: false, EHGHJNOFMKF: true, APBCMCOAFDM: false);
	}

	private void OOIHNJHMBMC()
	{
		instance = this;
	}

	public void PHMDHDLOPBK(int HLIFMPEJHKC, int MAJKOIELDNB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[2];
		array[1] = (short)HLIFMPEJHKC;
		array[1] = (short)MAJKOIELDNB;
		OnlineManager.SendRPC(photonView, "</color>", (RpcTarget)0, array);
	}

	private void KNFNDFPDIBG(short HLIFMPEJHKC, short MAJKOIELDNB)
	{
		PlayerInventory.NEKDDPIAOBE(0, LAGHIOKLJGH: true).LFBNOHNNFBB(ItemDatabaseAccessor.AFOACBIHNCL(HLIFMPEJHKC, GGBBJNBBLMF: true).JMDALJBNFML(), MAJKOIELDNB, HMPDLIPFBGD: true, EHGHJNOFMKF: false, APBCMCOAFDM: true, AOPGMJEMEFK: true);
	}

	private void ONIALAOGMCF()
	{
		instance = this;
	}

	private void PBKGIGGDPOJ(short HLIFMPEJHKC, short MAJKOIELDNB)
	{
		PlayerInventory.NEKDDPIAOBE(0, LAGHIOKLJGH: true).LFBNOHNNFBB(ItemDatabaseAccessor.GetItem(HLIFMPEJHKC, GGBBJNBBLMF: true).JMDALJBNFML(), MAJKOIELDNB, HMPDLIPFBGD: false, EHGHJNOFMKF: false, APBCMCOAFDM: false, AOPGMJEMEFK: true);
	}

	private void OMBHDODDHNO()
	{
		instance = this;
	}

	private void DLEFJCKPLIC(short HLIFMPEJHKC, short MAJKOIELDNB)
	{
		PlayerInventory.OGKNJNINGMH(0).AINJENENGFG(ItemDatabaseAccessor.CPMMBEPEJLO(HLIFMPEJHKC, GGBBJNBBLMF: true).JMDALJBNFML(), MAJKOIELDNB, HMPDLIPFBGD: true, EHGHJNOFMKF: false);
	}

	public void JNKKEKOABEE(int HLIFMPEJHKC, int MAJKOIELDNB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = (short)HLIFMPEJHKC;
		array[1] = (short)MAJKOIELDNB;
		OnlineManager.SendRPC(photonView, " : 00", (RpcTarget)0, array);
	}

	private void OGEJKOIOKAN()
	{
		instance = this;
	}

	public void PKODIMGEJNG(int HLIFMPEJHKC, int MAJKOIELDNB)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Player", (RpcTarget)0, (short)HLIFMPEJHKC, (short)MAJKOIELDNB, null);
	}

	public void BOOALAHEJAJ(int HLIFMPEJHKC, int MAJKOIELDNB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[3];
		array[0] = (short)HLIFMPEJHKC;
		array[0] = (short)MAJKOIELDNB;
		OnlineManager.SendRPC(photonView, "[MinePuzzleManager] Activating puzzle of type {0}", (RpcTarget)1, array);
	}

	public void MFCEBNJPFNM(int HLIFMPEJHKC, int MAJKOIELDNB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[6];
		array[0] = (short)HLIFMPEJHKC;
		array[0] = (short)MAJKOIELDNB;
		OnlineManager.SendRPC(photonView, "DefaultSettings", (RpcTarget)1, array);
	}

	public void JPLBNNJAOGE(int HLIFMPEJHKC, int MAJKOIELDNB)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Player2", (RpcTarget)1, (short)HLIFMPEJHKC, (short)MAJKOIELDNB);
	}
}
