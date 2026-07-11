using Photon.Pun;

public class OnlineMissionsManager : MonoBehaviourPunCallbacks
{
	public static OnlineMissionsManager instance;

	private void NEHDPGBGIHH(short EFDBKFCGNCA, byte AFJPIKKPJPB)
	{
		MissionsManager.GEBNCPGGHBB(EFDBKFCGNCA)?.KNOIJBMDJDK(AFJPIKKPJPB, BLJPGJKOLNF: false);
	}

	public void OFKLGCGHHEL(int EFDBKFCGNCA)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = (short)EFDBKFCGNCA;
		OnlineManager.SendRPC(photonView, "KlaynTakingDrink: Current request is not a drink request.", (RpcTarget)1, array);
	}

	private void OMEKEMAFAMO()
	{
		Q301ManoDePintura_Paso2.LJCPJFEJBLG(GFNHAMCPEAK: false);
	}

	private void OHDIHHMBGBE(short EFDBKFCGNCA)
	{
		MissionsManager.instance.AddCompletedMission(EFDBKFCGNCA);
	}

	public void ABHEMBOKHJO(int EFDBKFCGNCA, int AFJPIKKPJPB)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveCompleteServeNinjaCustomer", (RpcTarget)0, (short)EFDBKFCGNCA, (byte)AFJPIKKPJPB, null, null, null, null);
	}

	private void OEKINEGHOEK(short EFDBKFCGNCA)
	{
		MissionsManager.instance.AddCompletedMission(EFDBKFCGNCA);
	}

	private void ONDEOFLPBON(short EFDBKFCGNCA, byte AFJPIKKPJPB)
	{
		MissionsManager.GetActiveMission(EFDBKFCGNCA)?.MJJIHGHCDCC(AFJPIKKPJPB, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
	}

	public void EFNDNFLOBIC()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Moving", (RpcTarget)0);
	}

	public void OKJACCGCABF(int EFDBKFCGNCA)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Sound", (RpcTarget)1, (short)EFDBKFCGNCA);
	}

	public void LOABJCMLCMF()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Spring", (RpcTarget)1);
	}

	private void DOLDGHBKEAJ(short EFDBKFCGNCA, byte AFJPIKKPJPB)
	{
		MissionsManager.GetActiveMission(EFDBKFCGNCA)?.MJJIHGHCDCC(AFJPIKKPJPB);
	}

	public void LHGFEGCEDBH(int EFDBKFCGNCA)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = (short)EFDBKFCGNCA;
		OnlineManager.SendRPC(photonView, "Player2", (RpcTarget)1, array);
	}

	private void EPGBEEJFJLN(short EFDBKFCGNCA)
	{
		MissionsManager.instance.BFPLMBMJDEN(EFDBKFCGNCA);
	}

	public void EFCAMEDNFKC(int EFDBKFCGNCA)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = (short)EFDBKFCGNCA;
		OnlineManager.SendRPC(photonView, "Player sleep with right piece in inventory, dropping it on the ground.", (RpcTarget)1, array);
	}

	private void KGLGLENLDDG(short EFDBKFCGNCA)
	{
		MissionsManager.instance.BFAHLFFBCEJ(EFDBKFCGNCA, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
	}

	public void BFMEBBADACI(int EFDBKFCGNCA)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = (short)EFDBKFCGNCA;
		OnlineManager.SendRPC(photonView, ". Time since startup: ", (RpcTarget)1, array);
	}

	public void NGMBGGNOIDO(int EFDBKFCGNCA)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = (short)EFDBKFCGNCA;
		OnlineManager.SendRPC(photonView, " to inventory", (RpcTarget)1, array);
	}

	public void DACCEMIABGH(int EFDBKFCGNCA, int AFJPIKKPJPB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[2];
		array[1] = (short)EFDBKFCGNCA;
		array[1] = (byte)AFJPIKKPJPB;
		OnlineManager.SendRPC(photonView, "ClosePopUp", (RpcTarget)0, array);
	}

	private void HEMAHKJEONA()
	{
		instance = this;
	}

	public void MPEAOHPFMIB()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Right", (RpcTarget)0);
	}

	public void SendCompletedQuest301()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveCompletedQuest301", (RpcTarget)1);
	}

	public void SendCompletedMission(int EFDBKFCGNCA)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveCompletedMission", (RpcTarget)1, (short)EFDBKFCGNCA);
	}

	private void ELHIHEFGMHF(short EFDBKFCGNCA, byte AFJPIKKPJPB)
	{
		MissionsManager.GEBNCPGGHBB(EFDBKFCGNCA)?.BNGFAGIGJNE(AFJPIKKPJPB, BLJPGJKOLNF: false);
	}

	public void IJFIFHGPKHP()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ObjectVerticalMove", (RpcTarget)0);
	}

	public void NEIDIBOBIBO(int EFDBKFCGNCA, int AFJPIKKPJPB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[3];
		array[1] = (short)EFDBKFCGNCA;
		array[1] = (byte)AFJPIKKPJPB;
		OnlineManager.SendRPC(photonView, "UIAddRemove", (RpcTarget)1, array);
	}

	private void PEHCLBDILME(short EFDBKFCGNCA)
	{
		MissionsManager.instance.AddCompletedMission(EFDBKFCGNCA);
	}

	private void COAKDNJHIPD(short EFDBKFCGNCA, byte AFJPIKKPJPB)
	{
		MissionsManager.IPFHKMLLPKC(EFDBKFCGNCA)?.OGHHAGHNOCG(AFJPIKKPJPB, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
	}

	public void FMKJCDKAMMJ(int EFDBKFCGNCA)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = (short)EFDBKFCGNCA;
		OnlineManager.SendRPC(photonView, "itemSickle", (RpcTarget)1, array);
	}

	public void MLPNOKHKGAN(int EFDBKFCGNCA)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = (short)EFDBKFCGNCA;
		OnlineManager.SendRPC(photonView, "Items/item_name_1154", (RpcTarget)1, array);
	}

	public void MIODHNKMGPM(int EFDBKFCGNCA)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = (short)EFDBKFCGNCA;
		OnlineManager.SendRPC(photonView, " ", (RpcTarget)1, array);
	}

	private void IIPKPMPGLOL()
	{
		instance = this;
	}

	private void PHMKEFFOKOD(short EFDBKFCGNCA)
	{
		MissionsManager.instance.FGNLPCMEMMH(EFDBKFCGNCA, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
	}

	public void GFCLLPMLEHB(int EFDBKFCGNCA, int AFJPIKKPJPB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = (short)EFDBKFCGNCA;
		array[1] = (byte)AFJPIKKPJPB;
		OnlineManager.SendRPC(photonView, "SickleActiveRPC", (RpcTarget)1, array);
	}

	private void BFPHNINLAOL(short EFDBKFCGNCA)
	{
		MissionsManager.instance.BFPLMBMJDEN(EFDBKFCGNCA, EPJLPKAGHDM: false);
	}

	private void Awake()
	{
		instance = this;
	}

	private void MDBBEADBFDC(short EFDBKFCGNCA)
	{
		MissionsManager.instance.AddCompletedMission(EFDBKFCGNCA, CDPAMNIPPEC: false);
	}

	public void CDPABCOEHCH()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Dialogue System/Conversation/TableDirty/Entry/1/Dialogue Text", (RpcTarget)1);
	}

	private void HMJHBHMJGBE(short EFDBKFCGNCA, byte AFJPIKKPJPB)
	{
		MissionsManager.GetActiveMission(EFDBKFCGNCA)?.PFNPELJFJKA(AFJPIKKPJPB, BLJPGJKOLNF: false);
	}

	private void KKCPBLEFIDP(short EFDBKFCGNCA, byte AFJPIKKPJPB)
	{
		MissionsManager.GetActiveMission(EFDBKFCGNCA)?.PFNPELJFJKA(AFJPIKKPJPB);
	}

	[PunRPC]
	private void ReceiveStartMission(short EFDBKFCGNCA)
	{
		MissionsManager.instance.StartMission(EFDBKFCGNCA, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
	}

	public void CGDPBFGNAGP(int EFDBKFCGNCA, int AFJPIKKPJPB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[0] = (short)EFDBKFCGNCA;
		array[0] = (byte)AFJPIKKPJPB;
		OnlineManager.SendRPC(photonView, "SalonDelTrono/OxTalk", (RpcTarget)0, array);
	}

	private void OMEJEHGDBMG(short EFDBKFCGNCA)
	{
		MissionsManager.instance.AddCompletedMission(EFDBKFCGNCA, CDPAMNIPPEC: false);
	}

	public void EMEKHFNKFCO(int EFDBKFCGNCA, int AFJPIKKPJPB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[0] = (short)EFDBKFCGNCA;
		array[0] = (byte)AFJPIKKPJPB;
		OnlineManager.SendRPC(photonView, "GetOnlinePlaceable() not found any uniqueId ", (RpcTarget)1, array);
	}

	[PunRPC]
	private void ReceiveCompletedMission(short EFDBKFCGNCA)
	{
		MissionsManager.instance.AddCompletedMission(EFDBKFCGNCA, CDPAMNIPPEC: false);
	}

	private void OIHEDAPGMPK(short EFDBKFCGNCA, byte AFJPIKKPJPB)
	{
		MissionsManager.GetActiveMission(EFDBKFCGNCA)?.BNGFAGIGJNE(AFJPIKKPJPB, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
	}

	public void OKLHCDHBOIG(int EFDBKFCGNCA)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = (short)EFDBKFCGNCA;
		OnlineManager.SendRPC(photonView, "Angry", (RpcTarget)0, array);
	}

	public void SendStartMission(int EFDBKFCGNCA)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveStartMission", (RpcTarget)1, (short)EFDBKFCGNCA);
	}

	private void BDJLEABILDD(short EFDBKFCGNCA)
	{
		MissionsManager.instance.AddCompletedMission(EFDBKFCGNCA);
	}

	public void HPBJEKFCLLK()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Dialogue System/Conversation/TavernClean/Entry/4/Dialogue Text", (RpcTarget)0);
	}

	private void GNOBDKFFPOL()
	{
		instance = this;
	}

	public void SendCompleteObjective(int EFDBKFCGNCA, int AFJPIKKPJPB)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveCompleteObjective", (RpcTarget)1, (short)EFDBKFCGNCA, (byte)AFJPIKKPJPB);
	}

	public void HCDCNMPBINH()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Receive next game date from host ", (RpcTarget)1);
	}

	public void KDPKOGGLGDN(int EFDBKFCGNCA)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Left Stick Left", (RpcTarget)0, (short)EFDBKFCGNCA);
	}

	private void PDMICDHLHMD()
	{
		Q301ManoDePintura_Paso2.OECKOLMGKNO(GFNHAMCPEAK: true);
	}

	[PunRPC]
	private void ReceiveCompletedQuest301()
	{
		Q301ManoDePintura_Paso2.JGNBGECEINP(GFNHAMCPEAK: false);
	}

	public void NDDJMIFODDE(int EFDBKFCGNCA, int AFJPIKKPJPB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[3];
		array[1] = (short)EFDBKFCGNCA;
		array[0] = (byte)AFJPIKKPJPB;
		OnlineManager.SendRPC(photonView, "Empty transform for NPC. This shouldn't happen.", (RpcTarget)0, array);
	}

	public void LFCCJKGMHNB()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "", (RpcTarget)1);
	}

	private void GMCKBBECJOE()
	{
		instance = this;
	}

	public void ABOMLLDFPNE(int EFDBKFCGNCA)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Cannot instantiate dropped item at ", (RpcTarget)1, (short)EFDBKFCGNCA);
	}

	[PunRPC]
	private void ReceiveCompleteObjective(short EFDBKFCGNCA, byte AFJPIKKPJPB)
	{
		MissionsManager.GetActiveMission(EFDBKFCGNCA)?.BNGFAGIGJNE(AFJPIKKPJPB, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
	}

	public void BMOJKJLFJEL(int EFDBKFCGNCA, int AFJPIKKPJPB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[8];
		array[0] = (short)EFDBKFCGNCA;
		array[0] = (byte)AFJPIKKPJPB;
		OnlineManager.SendRPC(photonView, "itemParsleySeeds", (RpcTarget)0, array);
	}

	public void NNBDFHCDHCG(int EFDBKFCGNCA)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Items/item_description_600", (RpcTarget)1, (short)EFDBKFCGNCA);
	}

	public void LNKMIGAAFMM()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, " ", (RpcTarget)0);
	}

	private void MHHNKBCCPFM(short EFDBKFCGNCA)
	{
		MissionsManager.instance.AddCompletedMission(EFDBKFCGNCA, CDPAMNIPPEC: false);
	}

	private void FHHMEEJKJDP(short EFDBKFCGNCA, byte AFJPIKKPJPB)
	{
		MissionsManager.GEBNCPGGHBB(EFDBKFCGNCA)?.PFNPELJFJKA(AFJPIKKPJPB);
	}

	public void AJFHDGKMNMA(int EFDBKFCGNCA, int AFJPIKKPJPB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = (short)EFDBKFCGNCA;
		array[0] = (byte)AFJPIKKPJPB;
		OnlineManager.SendRPC(photonView, "ReceiveButtonPressPuzzleSolved", (RpcTarget)1, array);
	}

	public void ODEMGLLFJAP(int EFDBKFCGNCA, int AFJPIKKPJPB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[7];
		array[1] = (short)EFDBKFCGNCA;
		array[1] = (byte)AFJPIKKPJPB;
		OnlineManager.SendRPC(photonView, "position", (RpcTarget)0, array);
	}
}
