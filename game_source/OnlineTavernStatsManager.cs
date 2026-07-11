using Photon.Pun;

public class OnlineTavernStatsManager : MonoBehaviourPunCallbacks
{
	public static OnlineTavernStatsManager instance;

	private TavernStatsMessage ADJLHDLLEKF;

	public void SendAddRentedRoomSaleAndAddPrice(Price ENDNDAOPKHD)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveAddRentedRoomSaleAndAddPrice", (RpcTarget)1, ENDNDAOPKHD.OOIPLIEJILO());
	}

	private void MMJKJGMNAKB(byte[] OINICMNOLPK)
	{
		ADJLHDLLEKF = OnlineSerializer.Deserialize<TavernStatsMessage>(OINICMNOLPK);
		ADJLHDLLEKF.KOBKKBLNHBB();
	}

	public void OLALHCFMIDE()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "</color><br>", (RpcTarget)0);
	}

	[PunRPC]
	private void ReceiveAddRentedRoomSaleAndAddPrice(int ENDNDAOPKHD)
	{
		TavernServiceManager.GGFJGHHHEJC.AddRentedRoomSaleAndAddPrice(Price.GHDCKOJGAMM(ENDNDAOPKHD));
	}

	private void JCHJKJENDAC(int ENDNDAOPKHD)
	{
		TavernServiceManager.HKBJIIJHBJB().LBOGKHJGOFH(Price.OMDBJINNHPC(ENDNDAOPKHD));
	}

	private void IIPKPMPGLOL()
	{
		instance = this;
	}

	[PunRPC]
	private void ReceiveAddKickedCustomer()
	{
		TavernServiceManager.GGFJGHHHEJC.AddKickedCustomer(CDPAMNIPPEC: false);
	}

	public void ABBCDNJCPGA()
	{
		ADJLHDLLEKF = new TavernStatsMessage(TavernServiceManager.JFJOKGAOPHA().OKHGKBOJABC());
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Disabled", (RpcTarget)0, OnlineSerializer.EKNOFIJNBAP(ADJLHDLLEKF));
	}

	[PunRPC]
	private void ReceiveServiceStatInfo(byte[] OINICMNOLPK)
	{
		ADJLHDLLEKF = OnlineSerializer.Deserialize<TavernStatsMessage>(OINICMNOLPK);
		ADJLHDLLEKF.HDCDEDMAPNF();
	}

	private void BAILCOKKMEF(byte[] OINICMNOLPK)
	{
		ADJLHDLLEKF = OnlineSerializer.Deserialize<TavernStatsMessage>(OINICMNOLPK);
		ADJLHDLLEKF.KFBIBLIMHEK();
	}

	public void SendTavernStatsInfo()
	{
		ADJLHDLLEKF = new TavernStatsMessage(TavernServiceManager.GGFJGHHHEJC.GetAllTavernStats());
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveTavernStatsInfo", (RpcTarget)1, OnlineSerializer.Serialize(ADJLHDLLEKF));
	}

	public void BMBBLGHNMMG()
	{
		ADJLHDLLEKF = new TavernStatsMessage(TavernServiceManager.AFFGPMFKEFH().JCOMOKJLJBB());
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = OnlineSerializer.Serialize(ADJLHDLLEKF);
		OnlineManager.SendRPC(photonView, "Dialogue System/Conversation/EnterTavernNeutral/Entry/1/Dialogue Text", (RpcTarget)1, array);
	}

	public void SendAddKickedCustomer()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveAddKickedCustomer", (RpcTarget)1);
	}

	public void IFLHODINHGA()
	{
		ADJLHDLLEKF = new TavernStatsMessage(TavernServiceManager.GGFJGHHHEJC.MAACDBIEDNH());
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = OnlineSerializer.Serialize(ADJLHDLLEKF);
		OnlineManager.SendRPC(photonView, "UI", (RpcTarget)0, array);
	}

	public void NBCEMPIGNPL()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "endconversation", (RpcTarget)1);
	}

	public void NLBGIDNEEHN()
	{
		ADJLHDLLEKF = new TavernStatsMessage(TavernServiceManager.HKBJIIJHBJB().KGJLBLOFKFK());
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = OnlineSerializer.EKNOFIJNBAP(ADJLHDLLEKF);
		OnlineManager.SendRPC(photonView, "EnterCode", (RpcTarget)1, array);
	}

	private void Awake()
	{
		instance = this;
	}

	private void FCGJJHKAPLA(byte[] OINICMNOLPK)
	{
		ADJLHDLLEKF = OnlineSerializer.Deserialize<TavernStatsMessage>(OINICMNOLPK);
		ADJLHDLLEKF.AJEILOPCKPF();
	}

	private void ABFNJMCKMLL(byte[] OINICMNOLPK)
	{
		ADJLHDLLEKF = OnlineSerializer.Deserialize<TavernStatsMessage>(OINICMNOLPK);
		ADJLHDLLEKF.OKPIDPELELJ();
	}

	private void MBGEPAHECBE(byte[] OINICMNOLPK)
	{
		ADJLHDLLEKF = OnlineSerializer.Deserialize<TavernStatsMessage>(OINICMNOLPK);
		ADJLHDLLEKF.KGNIEGOBNLD();
	}

	private void GONDLJKGLGO()
	{
		instance = this;
	}

	private void OENFJLDDLHM(byte[] OINICMNOLPK)
	{
		ADJLHDLLEKF = OnlineSerializer.Deserialize<TavernStatsMessage>(OINICMNOLPK);
		ADJLHDLLEKF.AJEILOPCKPF();
	}

	private void GPAPCBLIAEK()
	{
		TavernServiceManager.AFFGPMFKEFH().PDOLPBNBDLB(CDPAMNIPPEC: true);
	}

	private void NBKEGDOAEPA(byte[] OINICMNOLPK)
	{
		ADJLHDLLEKF = OnlineSerializer.Deserialize<TavernStatsMessage>(OINICMNOLPK);
		ADJLHDLLEKF.KGNIEGOBNLD();
	}

	private void LPDBAIJIAHI(byte[] OINICMNOLPK)
	{
		ADJLHDLLEKF = OnlineSerializer.Deserialize<TavernStatsMessage>(OINICMNOLPK);
		ADJLHDLLEKF.NLHCFFPMFIK();
	}

	[PunRPC]
	private void ReceiveTavernStatsInfo(byte[] OINICMNOLPK)
	{
		ADJLHDLLEKF = OnlineSerializer.Deserialize<TavernStatsMessage>(OINICMNOLPK);
		ADJLHDLLEKF.OEJJGDMKIDN();
	}

	private void FAJNAJKOMDD(byte[] OINICMNOLPK)
	{
		ADJLHDLLEKF = OnlineSerializer.Deserialize<TavernStatsMessage>(OINICMNOLPK);
		ADJLHDLLEKF.GMNEAMHNMPB();
	}

	public void CJEADBGGLNF()
	{
		ADJLHDLLEKF = new TavernStatsMessage(TavernServiceManager.AFFGPMFKEFH().OBKIBFKNAGJ());
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = OnlineSerializer.Serialize(ADJLHDLLEKF);
		OnlineManager.SendRPC(photonView, "Dialogue System/Conversation/Gass_Stand/Entry/16/Dialogue Text", (RpcTarget)1, array);
	}

	public void GCJJINENPDD(Price ENDNDAOPKHD)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = ENDNDAOPKHD.JHKPNCOMAHI();
		OnlineManager.SendRPC(photonView, "Player", (RpcTarget)1, array);
	}

	private void JIAJFDKNJME()
	{
		instance = this;
	}

	public void GBHGJEOMBBF(Price ENDNDAOPKHD)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = ENDNDAOPKHD.BNCMDNFMECD();
		OnlineManager.SendRPC(photonView, "Shader Model 4.1 ( DX10.1 )", (RpcTarget)0, array);
	}

	private void CMOFJNCGPEM(byte[] OINICMNOLPK)
	{
		ADJLHDLLEKF = OnlineSerializer.Deserialize<TavernStatsMessage>(OINICMNOLPK);
		ADJLHDLLEKF.OEJJGDMKIDN();
	}

	private void HJJOBNHEMOO(int ENDNDAOPKHD)
	{
		TavernServiceManager.HKBJIIJHBJB().DAPLMOGBMMG(Price.LEDHAKFAHCI(ENDNDAOPKHD));
	}
}
