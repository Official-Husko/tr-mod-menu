using Photon.Pun;

public class OnlineTrendsManager : MonoBehaviourPunCallbacks
{
	public static OnlineTrendsManager instance;

	public void IABCLGMLICG()
	{
		TrendSetMessage mOBFJEDPIPM = new TrendSetMessage(Trends.KNOKBLFFNLM().allTrends[3]);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = OnlineSerializer.Serialize(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "Player/Bark/Error/NotAllPlayersHere", (RpcTarget)1, array);
	}

	private void MFGANCCJFJK()
	{
		instance = this;
	}

	private void HEMAHKJEONA()
	{
		instance = this;
	}

	private void PBIKLPJLABD(byte[] OINICMNOLPK)
	{
		Trends.GGFJGHHHEJC.BJLKNJLCLFL();
		OnlineSerializer.Deserialize<TrendSetMessage>(OINICMNOLPK).ACMBBIGKPMJ(Trends.KNOKBLFFNLM().allTrends[2]);
	}

	private void Awake()
	{
		instance = this;
	}

	private void JIAJFDKNJME()
	{
		instance = this;
	}

	private void NEOICNJNKNL()
	{
		instance = this;
	}

	public void GHIBBBOKFEJ()
	{
		TrendSetMessage mOBFJEDPIPM = new TrendSetMessage(Trends.FMIDAFEGDCD().allTrends[3]);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = OnlineSerializer.Serialize(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "Items/item_description_1122", (RpcTarget)1, array);
	}

	public void NGEJLKAOPDN()
	{
		TrendSetMessage mOBFJEDPIPM = new TrendSetMessage(Trends.KNOKBLFFNLM().allTrends[6]);
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Dialogue System/Conversation/TooHot/Entry/4/Dialogue Text", (RpcTarget)0, OnlineSerializer.Serialize(mOBFJEDPIPM));
	}

	private void KPODHCMDNJC(byte[] OINICMNOLPK)
	{
		Trends.FMIDAFEGDCD().BJLKNJLCLFL();
		OnlineSerializer.Deserialize<TrendSetMessage>(OINICMNOLPK).OHDDCBPCKOJ(Trends.FMIDAFEGDCD().allTrends[8]);
	}

	public void BNAHIGPDCDG()
	{
		TrendSetMessage mOBFJEDPIPM = new TrendSetMessage(Trends.KNOKBLFFNLM().allTrends[3]);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = OnlineSerializer.EKNOFIJNBAP(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "Too far away", (RpcTarget)1, array);
	}

	private void BHCBHFCNPCB(byte[] OINICMNOLPK)
	{
		Trends.KNOKBLFFNLM().SwapTrends();
		OnlineSerializer.Deserialize<TrendSetMessage>(OINICMNOLPK).GNPDJJGFAAC(Trends.FMIDAFEGDCD().allTrends[4]);
	}

	private void GEFKFHMHOAD(byte[] OINICMNOLPK)
	{
		Trends.GGFJGHHHEJC.SwapTrends();
		OnlineSerializer.Deserialize<TrendSetMessage>(OINICMNOLPK).DCPKNOPEMEF(Trends.KNOKBLFFNLM().allTrends[8]);
	}

	private void PCKOHAIPHFI()
	{
		instance = this;
	}

	private void CFIPDPCKOFH(byte[] OINICMNOLPK)
	{
		Trends.GGFJGHHHEJC.BJLKNJLCLFL();
		OnlineSerializer.Deserialize<TrendSetMessage>(OINICMNOLPK).BPHJPJLCICG(Trends.KNOKBLFFNLM().allTrends[7]);
	}

	public void CHKBNMAEALB()
	{
		TrendSetMessage mOBFJEDPIPM = new TrendSetMessage(Trends.KNOKBLFFNLM().allTrends[6]);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = OnlineSerializer.Serialize(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "Items/item_name_1064", (RpcTarget)1, array);
	}

	public void JFIDDPJHPCF()
	{
		TrendSetMessage mOBFJEDPIPM = new TrendSetMessage(Trends.GGFJGHHHEJC.allTrends[4]);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = OnlineSerializer.JBIPDCGKMGE(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "ActiveDecoMode", (RpcTarget)0, array);
	}

	public void SendTrends()
	{
		TrendSetMessage mOBFJEDPIPM = new TrendSetMessage(Trends.GGFJGHHHEJC.allTrends[3]);
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveTrends", (RpcTarget)1, OnlineSerializer.Serialize(mOBFJEDPIPM));
	}

	private void IKIAEDDMBCA(byte[] OINICMNOLPK)
	{
		Trends.FMIDAFEGDCD().IHAGGMCPHDI();
		OnlineSerializer.Deserialize<TrendSetMessage>(OINICMNOLPK).KKAOBLHGGKM(Trends.GGFJGHHHEJC.allTrends[1]);
	}

	public void MENFFLONNLD()
	{
		TrendSetMessage mOBFJEDPIPM = new TrendSetMessage(Trends.FMIDAFEGDCD().allTrends[1]);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = OnlineSerializer.JBIPDCGKMGE(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "Items/item_description_666", (RpcTarget)1, array);
	}

	public void OIFAPGGHLNP()
	{
		TrendSetMessage mOBFJEDPIPM = new TrendSetMessage(Trends.GGFJGHHHEJC.allTrends[5]);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = OnlineSerializer.EKNOFIJNBAP(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "El prefab '{0}' del item '{1}' (ID: {2}) no tiene el componente ItemSetup.", (RpcTarget)1, array);
	}

	public void EPJOJCKHCHO()
	{
		TrendSetMessage mOBFJEDPIPM = new TrendSetMessage(Trends.GGFJGHHHEJC.allTrends[4]);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = OnlineSerializer.EKNOFIJNBAP(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "ReceiveTalentsLoad", (RpcTarget)1, array);
	}

	private void HCCJBKKGCLJ()
	{
		instance = this;
	}

	private void OKHLEMPJONN()
	{
		instance = this;
	}

	public void LOLAGEFCLDD()
	{
		TrendSetMessage mOBFJEDPIPM = new TrendSetMessage(Trends.FMIDAFEGDCD().allTrends[7]);
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Sit", (RpcTarget)1, OnlineSerializer.EKNOFIJNBAP(mOBFJEDPIPM));
	}

	[PunRPC]
	private void ReceiveTrends(byte[] OINICMNOLPK)
	{
		Trends.GGFJGHHHEJC.SwapTrends();
		OnlineSerializer.Deserialize<TrendSetMessage>(OINICMNOLPK).OEJJGDMKIDN(Trends.GGFJGHHHEJC.allTrends[3]);
	}

	private void PHGLOCOJNCP(byte[] OINICMNOLPK)
	{
		Trends.GGFJGHHHEJC.SwapTrends();
		OnlineSerializer.Deserialize<TrendSetMessage>(OINICMNOLPK).DJPAGKEHFPB(Trends.KNOKBLFFNLM().allTrends[0]);
	}

	private void HPJBLOPJIMI()
	{
		instance = this;
	}

	private void KBKJOJHHBAJ(byte[] OINICMNOLPK)
	{
		Trends.KNOKBLFFNLM().SwapTrends();
		OnlineSerializer.Deserialize<TrendSetMessage>(OINICMNOLPK).OHDDCBPCKOJ(Trends.KNOKBLFFNLM().allTrends[1]);
	}

	public void PGJLFBAEMMB()
	{
		TrendSetMessage mOBFJEDPIPM = new TrendSetMessage(Trends.FMIDAFEGDCD().allTrends[2]);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = OnlineSerializer.Serialize(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "Direction", (RpcTarget)0, array);
	}

	public void NHEGLINPDAC()
	{
		TrendSetMessage mOBFJEDPIPM = new TrendSetMessage(Trends.GGFJGHHHEJC.allTrends[8]);
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Wilson/Introduce", (RpcTarget)0, OnlineSerializer.Serialize(mOBFJEDPIPM));
	}

	private void DIFCDKEBFFL(byte[] OINICMNOLPK)
	{
		Trends.KNOKBLFFNLM().SwapTrends();
		OnlineSerializer.Deserialize<TrendSetMessage>(OINICMNOLPK).MEPGGCFIKHL(Trends.GGFJGHHHEJC.allTrends[2]);
	}

	public void BDIJFCADNED()
	{
		TrendSetMessage mOBFJEDPIPM = new TrendSetMessage(Trends.KNOKBLFFNLM().allTrends[8]);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = OnlineSerializer.EKNOFIJNBAP(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, ", ", (RpcTarget)1, array);
	}

	private void GONDLJKGLGO()
	{
		instance = this;
	}

	private void BAKDKFKNHDE()
	{
		instance = this;
	}
}
