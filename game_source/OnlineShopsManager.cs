using Photon.Pun;

public class OnlineShopsManager : MonoBehaviourPunCallbacks
{
	public static OnlineShopsManager instance;

	public void BBIGNAJNAAB(Shop OJKANJDPKNE)
	{
		ShopMsg mOBFJEDPIPM = new ShopMsg(OJKANJDPKNE);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = OnlineSerializer.Serialize(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "UIBack", (RpcTarget)1, array);
	}

	public void BOAENEHBBIL(Shop OJKANJDPKNE)
	{
		ShopMsg mOBFJEDPIPM = new ShopMsg(OJKANJDPKNE);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = OnlineSerializer.JBIPDCGKMGE(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "Items/item_name_1180", (RpcTarget)0, array);
	}

	private void BADACPLEIEM(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<ShopMsg>(OINICMNOLPK).DDNDBGKLNGF();
	}

	private void FLCHLJEBJJM(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<ShopMsg>(OINICMNOLPK).FOGLECFMPMK();
	}

	private void PMFCOOINFAL(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<ShopMsg>(OINICMNOLPK).LDGOHDMHCAA();
	}

	private void KHCJDKHONPK()
	{
		instance = this;
	}

	private void JILIGHNKKKB(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<ShopMsg>(OINICMNOLPK).JJALLOFLDAL();
	}

	private void CEOEHODJAJK()
	{
		instance = this;
	}

	public void PPOLICGOIOD(Shop OJKANJDPKNE)
	{
		ShopMsg mOBFJEDPIPM = new ShopMsg(OJKANJDPKNE);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = OnlineSerializer.Serialize(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "LoopVolume", (RpcTarget)1, array);
	}

	private void PAGCEJHICCL(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<ShopMsg>(OINICMNOLPK).OCNOCJIIKED();
	}

	private void OKHLEMPJONN()
	{
		instance = this;
	}

	private void AGLMGDNBHBF()
	{
		instance = this;
	}

	public void IFEDFFOAODD(Shop OJKANJDPKNE)
	{
		ShopMsg mOBFJEDPIPM = new ShopMsg(OJKANJDPKNE);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = OnlineSerializer.EKNOFIJNBAP(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "GetOnlinePlaceable() not found any uniqueId ", (RpcTarget)0, array);
	}

	public void PPCOIEINEKM(Shop OJKANJDPKNE)
	{
		ShopMsg mOBFJEDPIPM = new ShopMsg(OJKANJDPKNE);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = OnlineSerializer.EKNOFIJNBAP(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "DoYouWantToRepairIt", (RpcTarget)1, array);
	}

	public void BEPMFAKIDLJ(Shop OJKANJDPKNE)
	{
		ShopMsg mOBFJEDPIPM = new ShopMsg(OJKANJDPKNE);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = OnlineSerializer.JBIPDCGKMGE(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "\n", (RpcTarget)0, array);
	}

	private void BODICIENBEH()
	{
		instance = this;
	}

	private void CHPFKKKONBD(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<ShopMsg>(OINICMNOLPK).AELABIMHDNA();
	}

	private void NAOBODGBECL()
	{
		instance = this;
	}

	private void HLFNFBKHGHD(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<ShopMsg>(OINICMNOLPK).DMAAKFGEFCH();
	}

	private void COKBJNMAMDI()
	{
		instance = this;
	}

	private void BIHLOGCPCEG(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<ShopMsg>(OINICMNOLPK).KFJBKINLFLA();
	}

	private void BHAFCBHENPL()
	{
		instance = this;
	}

	private void MFMGCBPHEBG(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<ShopMsg>(OINICMNOLPK).EMFCAOMENPM();
	}

	private void NDAKLDCIOIA(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<ShopMsg>(OINICMNOLPK).OEJJGDMKIDN();
	}

	private void EHBMONGBJFI()
	{
		instance = this;
	}

	private void OMBHDODDHNO()
	{
		instance = this;
	}

	[PunRPC]
	private void ReceiveShopInfo(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<ShopMsg>(OINICMNOLPK).OEJJGDMKIDN();
	}

	private void Awake()
	{
		instance = this;
	}

	private void AAEAAEBBFKG()
	{
		instance = this;
	}

	private void PKNPALOGEHG(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<ShopMsg>(OINICMNOLPK).EMFCAOMENPM();
	}

	private void MFDLMGFOKKN(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<ShopMsg>(OINICMNOLPK).CCIIDGGKLJH();
	}

	public void ODOKKHIBDIA(Shop OJKANJDPKNE)
	{
		ShopMsg mOBFJEDPIPM = new ShopMsg(OJKANJDPKNE);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = OnlineSerializer.JBIPDCGKMGE(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "ReceiveInventoryToChest", (RpcTarget)0, array);
	}

	private void CLGBFOIBANN()
	{
		instance = this;
	}

	private void NEOICNJNKNL()
	{
		instance = this;
	}

	private void KHONOODGLBI()
	{
		instance = this;
	}

	private void NJCFBDMLABJ(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<ShopMsg>(OINICMNOLPK).KGNIEGOBNLD();
	}

	private void LNPDALMANFB()
	{
		instance = this;
	}

	private void BAKDKFKNHDE()
	{
		instance = this;
	}

	private void PCKOHAIPHFI()
	{
		instance = this;
	}

	public void SendShopInfo(Shop OJKANJDPKNE)
	{
		ShopMsg mOBFJEDPIPM = new ShopMsg(OJKANJDPKNE);
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveShopInfo", (RpcTarget)1, OnlineSerializer.Serialize(mOBFJEDPIPM));
	}

	private void GFPCCIKJODB(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<ShopMsg>(OINICMNOLPK).PFOHEFAMENI();
	}

	private void FPNCANODJKE()
	{
		instance = this;
	}

	private void HDHPOAPLEJC()
	{
		instance = this;
	}

	private void HPJBLOPJIMI()
	{
		instance = this;
	}

	public void LOMFELCEBKL(Shop OJKANJDPKNE)
	{
		ShopMsg mOBFJEDPIPM = new ShopMsg(OJKANJDPKNE);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = OnlineSerializer.JBIPDCGKMGE(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "Minigame", (RpcTarget)0, array);
	}

	private void GOPDBKMPHKE(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<ShopMsg>(OINICMNOLPK).MOEHLFOHLLO();
	}

	private void DKDLOBOLNFH()
	{
		instance = this;
	}

	public void AMEANPLHLEO(Shop OJKANJDPKNE)
	{
		ShopMsg mOBFJEDPIPM = new ShopMsg(OJKANJDPKNE);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = OnlineSerializer.Serialize(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "UnlockPerkLevel?", (RpcTarget)1, array);
	}

	public void CBEBICIADCI(Shop OJKANJDPKNE)
	{
		ShopMsg mOBFJEDPIPM = new ShopMsg(OJKANJDPKNE);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = OnlineSerializer.JBIPDCGKMGE(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "BarnBlocked", (RpcTarget)1, array);
	}

	private void DIMAPDNCBAN()
	{
		instance = this;
	}

	public void PPCKLPKDOHA(Shop OJKANJDPKNE)
	{
		ShopMsg mOBFJEDPIPM = new ShopMsg(OJKANJDPKNE);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = OnlineSerializer.JBIPDCGKMGE(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "City/PetShop/Markus/Barks_FeedDog", (RpcTarget)0, array);
	}

	public void MAMOCBNJJDO(Shop OJKANJDPKNE)
	{
		ShopMsg mOBFJEDPIPM = new ShopMsg(OJKANJDPKNE);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = OnlineSerializer.JBIPDCGKMGE(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "Items/item_name_592", (RpcTarget)1, array);
	}

	private void GFLFDLIMOLI()
	{
		instance = this;
	}

	private void JDAMCMODANB()
	{
		instance = this;
	}

	private void CKAKDIPFFAC(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<ShopMsg>(OINICMNOLPK).DDNDBGKLNGF();
	}

	private void BJAOIJBCHOH(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<ShopMsg>(OINICMNOLPK).EMFCAOMENPM();
	}

	private void GECHJIGBPEN()
	{
		instance = this;
	}

	public void GNJKJJHJLJH(Shop OJKANJDPKNE)
	{
		ShopMsg mOBFJEDPIPM = new ShopMsg(OJKANJDPKNE);
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Player2", (RpcTarget)0, OnlineSerializer.JBIPDCGKMGE(mOBFJEDPIPM));
	}

	private void FHOCCEBKHJI()
	{
		instance = this;
	}

	private void KBKEMIEENOL(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<ShopMsg>(OINICMNOLPK).DDNDBGKLNGF();
	}

	private void GMCKBBECJOE()
	{
		instance = this;
	}

	private void DPCJLJBBDEI(byte[] OINICMNOLPK)
	{
		OnlineSerializer.Deserialize<ShopMsg>(OINICMNOLPK).MOEHLFOHLLO();
	}
}
