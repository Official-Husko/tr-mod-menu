using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class OnlineBanquetEventManager : MonoBehaviourPunCallbacks
{
	public static OnlineBanquetEventManager instance;

	private FoodInstanceMessage HMFKIEJJENE;

	public void ANMIKAOBNCP(byte JJCLJKMIMBH)
	{
		BanquetOrdersManager.instance.banquetCustomers[JJCLJKMIMBH].MEMHBEIAICP();
	}

	public void NKHIAKDJBFE(int JJCLJKMIMBH, FoodInstance GCJPFFNGCJA, bool FDMHEDDIGPJ)
	{
		HMFKIEJJENE = new FoodInstanceMessage(GCJPFFNGCJA);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[8];
		array[0] = (byte)JJCLJKMIMBH;
		array[0] = OnlineSerializer.JBIPDCGKMGE(HMFKIEJJENE);
		array[3] = FDMHEDDIGPJ;
		array[1] = PhotonNetwork.LocalPlayer.ActorNumber;
		OnlineManager.SendRPC(photonView, "Dialogue System/Conversation/TavernClean/Entry/9/Dialogue Text", (RpcTarget)2, array);
	}

	public void SendDeactivateEvent()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveDeactivateEvent", (RpcTarget)1);
	}

	private void FIONNNEHBHG()
	{
		KlaynNPC.instance.FFAPCEPDOHH(GFNHAMCPEAK: false);
	}

	private void DMIOAMKGGFF()
	{
		BanquetEvent.BDCJIHKEFKG();
	}

	[PunRPC]
	public void ReceiveRemoveTableOrderBanquetCustomer(byte JJCLJKMIMBH)
	{
		BanquetOrdersManager.instance.banquetCustomers[JJCLJKMIMBH].RemoveTableOrder();
	}

	public void DJNFIGEDDHN(int JJCLJKMIMBH)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = (byte)JJCLJKMIMBH;
		OnlineManager.SendRPC(photonView, "FarmReady", (RpcTarget)0, array);
	}

	public void SendWaitingForAllPlayersPrepared(int GEEEJPJIGBB, bool GLKAOHGJANI, string HBILFLLKHGP, Gender HNLNENELPKI)
	{
		if (GLKAOHGJANI)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveStartWaitingForBanquetEvent", (RpcTarget)0, (byte)GEEEJPJIGBB);
			return;
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveStopWaitingForBanquetEvent", (RpcTarget)0, (byte)GEEEJPJIGBB, (byte)HNLNENELPKI, HBILFLLKHGP);
	}

	private void IFCDJGDODFB(byte GJDMLMEMKMD, byte HNLNENELPKI, string HBILFLLKHGP)
	{
		OnlineManager.AMDFHLPIJJC(GJDMLMEMKMD, HBILFLLKHGP, (Gender)HNLNENELPKI);
	}

	public void NDBKMDHLFFD(bool CHOPKHLMBIH)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Error_Money", (RpcTarget)1, CHOPKHLMBIH);
	}

	public void FOJHILEOLME()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "0", (RpcTarget)1);
	}

	public void GBPODDHHGGE()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Player/Bark/KlaynTavernBlock", (RpcTarget)0);
	}

	public void CEOCDDNBEDH()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, " final price: ", (RpcTarget)1);
	}

	public void SendTeleportPlayerToCastleGarden(bool CHOPKHLMBIH)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveTeleportPlayerToCastleGarden", (RpcTarget)1, CHOPKHLMBIH);
	}

	public void SendCompleteItemTransactionBanquetCustomer(int JJCLJKMIMBH, FoodInstance GCJPFFNGCJA, bool FDMHEDDIGPJ)
	{
		HMFKIEJJENE = new FoodInstanceMessage(GCJPFFNGCJA);
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveCompleteItemTransactionBanquetCustomer", (RpcTarget)2, (byte)JJCLJKMIMBH, OnlineSerializer.Serialize(HMFKIEJJENE), FDMHEDDIGPJ, PhotonNetwork.LocalPlayer.ActorNumber);
	}

	public void LPEKPACADDL(byte JJCLJKMIMBH, byte OPGEOAFCIGE)
	{
		if ((Object)(object)BanquetOrdersManager.instance == (Object)null)
		{
			Debug.LogError((object)"Walk");
		}
		else if (JJCLJKMIMBH < 1 || JJCLJKMIMBH >= BanquetOrdersManager.instance.banquetCustomers.Length)
		{
			Debug.LogError((object)("UIBack" + JJCLJKMIMBH));
		}
		else
		{
			BanquetOrdersManager.instance.banquetCustomers[JJCLJKMIMBH].banquetCustomerState = (BanquetCustomerState)OPGEOAFCIGE;
		}
	}

	private void GHCJPDLDHHF(byte GJDMLMEMKMD)
	{
		int actorNumberByBedAssigned = OnlinePlayerDataManager.GetActorNumberByBedAssigned(GJDMLMEMKMD);
		OnlineManager.AddPlayerPrepared(GJDMLMEMKMD, OnlinePlayerDataManager.GetPlayerName(actorNumberByBedAssigned), OnlinePlayerDataManager.GGPPENHHFAD(actorNumberByBedAssigned));
	}

	public void GDJDKNCHIEA(byte JJCLJKMIMBH)
	{
		BanquetOrdersManager.instance.banquetCustomers[JJCLJKMIMBH].HLEJMAOOBKC();
	}

	public void OHJLKNNFKFM(int JJCLJKMIMBH)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = (byte)JJCLJKMIMBH;
		OnlineManager.SendRPC(photonView, "ReceiveDoorInfo", (RpcTarget)0, array);
	}

	public void PAPINCNMPAK(int JJCLJKMIMBH, BanquetCustomerState OPGEOAFCIGE)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[2];
		array[1] = (byte)JJCLJKMIMBH;
		array[0] = (byte)OPGEOAFCIGE;
		OnlineManager.SendRPC(photonView, "Player/Bark/Tutorial/T100", (RpcTarget)1, array);
	}

	private void PIGJKLAJDHF()
	{
		KlaynNPC.instance.FFAPCEPDOHH(GFNHAMCPEAK: false);
	}

	public void LBNCMNHJMPK(int GEEEJPJIGBB, bool GLKAOHGJANI, string HBILFLLKHGP, Gender HNLNENELPKI)
	{
		if (GLKAOHGJANI)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Dig", (RpcTarget)0, (byte)GEEEJPJIGBB);
			return;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[7];
		array[1] = (byte)GEEEJPJIGBB;
		array[1] = (byte)HNLNENELPKI;
		array[3] = HBILFLLKHGP;
		OnlineManager.SendRPC(photonView, "</color>", (RpcTarget)1, array);
	}

	private void LDLBMMMLEDJ()
	{
		instance = this;
	}

	public void GAIDLNNKFGD(int JJCLJKMIMBH)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = (byte)JJCLJKMIMBH;
		OnlineManager.SendRPC(photonView, "next pos reached", (RpcTarget)0, array);
	}

	private void HDJCIFBEJNC()
	{
		instance = this;
	}

	public void NCCFFHCOCMC()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Walk", (RpcTarget)0);
	}

	private void KLGCMMIKGIO()
	{
		instance = this;
	}

	public void KLGFPMLDMFL()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Room missing required items", (RpcTarget)1);
	}

	private void BDAHMDMCNDE()
	{
		BanquetEvent.KMDAMABBLIP();
	}

	private void DGBJJNAADCI()
	{
		instance = this;
	}

	private void GIFCPPCNMJK()
	{
		EventRoundsManager.NextRound(CDPAMNIPPEC: false);
	}

	public void OLJPJPMLOCP(int JJCLJKMIMBH, FoodInstance GCJPFFNGCJA, bool FDMHEDDIGPJ)
	{
		HMFKIEJJENE = new FoodInstanceMessage(GCJPFFNGCJA);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[5];
		array[0] = (byte)JJCLJKMIMBH;
		array[0] = OnlineSerializer.Serialize(HMFKIEJJENE);
		array[7] = FDMHEDDIGPJ;
		array[3] = PhotonNetwork.LocalPlayer.ActorNumber;
		OnlineManager.SendRPC(photonView, "Items/item_name_652", (RpcTarget)2, array);
	}

	public void IMPNKCAJIOG()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveTrends", (RpcTarget)0);
	}

	public void GJJAPAPFPMO(int GEEEJPJIGBB, bool GLKAOHGJANI, string HBILFLLKHGP, Gender HNLNENELPKI)
	{
		if (GLKAOHGJANI)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[0] = (byte)GEEEJPJIGBB;
			OnlineManager.SendRPC(photonView, "VERSION", (RpcTarget)1, array);
		}
		else
		{
			PhotonView photonView2 = ((MonoBehaviourPun)this).photonView;
			object[] array2 = new object[8];
			array2[0] = (byte)GEEEJPJIGBB;
			array2[1] = (byte)HNLNENELPKI;
			array2[0] = HBILFLLKHGP;
			OnlineManager.SendRPC(photonView2, "Save Game Client", (RpcTarget)1, array2);
		}
	}

	private void BJNMCLLPDBC()
	{
		BanquetEvent.DeactivateBanquetEvent();
	}

	public void DDAPFJAOFCH(int JJCLJKMIMBH, FoodInstance DNLMCHDOMOK)
	{
		HMFKIEJJENE = new FoodInstanceMessage(DNLMCHDOMOK);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = (byte)JJCLJKMIMBH;
		array[1] = OnlineSerializer.EKNOFIJNBAP(HMFKIEJJENE);
		OnlineManager.SendRPC(photonView, "<mark=#000000><alpha=#00> ", (RpcTarget)1, array);
	}

	private void KHCJDKHONPK()
	{
		instance = this;
	}

	public void EFOHNAIEHGG()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, " ", (RpcTarget)0);
	}

	private void NNCBOPNEPCM(byte GJDMLMEMKMD)
	{
		int actorNumberByBedAssigned = OnlinePlayerDataManager.GetActorNumberByBedAssigned(GJDMLMEMKMD);
		OnlineManager.AddPlayerPrepared(GJDMLMEMKMD, OnlinePlayerDataManager.GetPlayerName(actorNumberByBedAssigned), OnlinePlayerDataManager.GGPPENHHFAD(actorNumberByBedAssigned));
	}

	public void CIEDJJFENLG(byte JJCLJKMIMBH)
	{
		BanquetOrdersManager.instance.banquetCustomers[JJCLJKMIMBH].MEMHBEIAICP();
	}

	public void SendRemoveTableOrderBanquetCustomer(int JJCLJKMIMBH)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveRemoveTableOrderBanquetCustomer", (RpcTarget)1, (byte)JJCLJKMIMBH);
	}

	public void BMHHFEDPPJN(byte JJCLJKMIMBH, byte OPGEOAFCIGE)
	{
		if ((Object)(object)BanquetOrdersManager.instance == (Object)null)
		{
			Debug.LogError((object)"DEBUG_FAKE_ID");
		}
		else if (JJCLJKMIMBH < 1 || JJCLJKMIMBH >= BanquetOrdersManager.instance.banquetCustomers.Length)
		{
			Debug.LogError((object)("Run" + JJCLJKMIMBH));
		}
		else
		{
			BanquetOrdersManager.instance.banquetCustomers[JJCLJKMIMBH].banquetCustomerState = (BanquetCustomerState)OPGEOAFCIGE;
		}
	}

	private void FJADIKHHEAE()
	{
		EventRoundsManager.NextRound();
	}

	public void NJDKGAKMFDD()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Occupied", (RpcTarget)0);
	}

	public void PNOJFFKMFCB(int JJCLJKMIMBH, BanquetCustomerState OPGEOAFCIGE)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "MainProgress", (RpcTarget)0, (byte)JJCLJKMIMBH, (byte)OPGEOAFCIGE, null, null, null, null, null);
	}

	private void BHBCBEGDDJH(byte GJDMLMEMKMD, byte HNLNENELPKI, string HBILFLLKHGP)
	{
		OnlineManager.AMDFHLPIJJC(GJDMLMEMKMD, HBILFLLKHGP, (Gender)HNLNENELPKI);
	}

	public void DIDJLANHDDL()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Sleep", (RpcTarget)1);
	}

	public void KIKPOIJPFLP()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "UINextCategory", (RpcTarget)0);
	}

	public void JLHHJLNGJPE(byte JJCLJKMIMBH, byte[] OINICMNOLPK)
	{
		HMFKIEJJENE = OnlineSerializer.Deserialize<FoodInstanceMessage>(OINICMNOLPK);
		BanquetOrdersManager.instance.banquetCustomers[JJCLJKMIMBH].AJBMKOKEPEE(HMFKIEJJENE.ANMBPDJLNFN(), ANHLFAANEEA: true);
	}

	private void CMEHMCGKAFF()
	{
		KlaynNPC.instance.StartKlaynDialogueOathFeast(GFNHAMCPEAK: true);
	}

	public void IBEPENJPIBC()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Disabled", (RpcTarget)1);
	}

	public void DEIMNILIKPO(int GEEEJPJIGBB, bool GLKAOHGJANI, string HBILFLLKHGP, Gender HNLNENELPKI)
	{
		if (GLKAOHGJANI)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[1] = (byte)GEEEJPJIGBB;
			OnlineManager.SendRPC(photonView, ".png", (RpcTarget)1, array);
		}
		else
		{
			PhotonView photonView2 = ((MonoBehaviourPun)this).photonView;
			object[] array2 = new object[1];
			array2[1] = (byte)GEEEJPJIGBB;
			array2[0] = (byte)HNLNENELPKI;
			array2[0] = HBILFLLKHGP;
			OnlineManager.SendRPC(photonView2, "ClosePopUp", (RpcTarget)1, array2);
		}
	}

	private void KPFCLDGDDFA()
	{
		EventRoundsManager.NextRound(CDPAMNIPPEC: false);
	}

	[PunRPC]
	public void ReceiveCompleteItemTransactionBanquetCustomer(byte JJCLJKMIMBH, byte[] BCAMKIPAINC, bool FDMHEDDIGPJ, int JJPJHIHBOIB)
	{
		if ((Object)(object)BanquetOrdersManager.instance == (Object)null)
		{
			Debug.LogError((object)"BanquetOrdersManager is not initialized.");
		}
		else if (JJCLJKMIMBH >= BanquetOrdersManager.instance.banquetCustomers.Length)
		{
			Debug.LogError((object)("Invalid banquet customer ID: " + JJCLJKMIMBH));
		}
		else if (BanquetOrdersManager.instance.banquetCustomers[JJCLJKMIMBH].currentRequest != null)
		{
			HMFKIEJJENE = OnlineSerializer.Deserialize<FoodInstanceMessage>(BCAMKIPAINC);
			BanquetOrdersManager.instance.banquetCustomers[JJCLJKMIMBH].CompleteItemTransaction(OnlinePlayerDataManager.GetBedAssignedByActorNumber(JJPJHIHBOIB), NLCDDFDGACP: true, HMFKIEJJENE.ANMBPDJLNFN(), FDMHEDDIGPJ);
		}
	}

	private void IPNLJJMMEMI()
	{
		EventRoundsManager.NextRound(CDPAMNIPPEC: false);
	}

	public void FPMDMIHAAEP()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "F2", (RpcTarget)0);
	}

	private void CAPPBMOLFHI(bool CHOPKHLMBIH)
	{
		BanquetEvent.TeleportPlayerToCastleGarden(CHOPKHLMBIH, CDPAMNIPPEC: false);
	}

	public void GBLMHDFKHGI(bool CHOPKHLMBIH)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = CHOPKHLMBIH;
		OnlineManager.SendRPC(photonView, "Items/item_name_625", (RpcTarget)0, array);
	}

	private void EEAHABKJCGI()
	{
		BanquetEvent.DeactivateBanquetEvent();
	}

	public void DBKAPGOJDOG(byte JJCLJKMIMBH, byte[] BCAMKIPAINC, bool FDMHEDDIGPJ, int JJPJHIHBOIB)
	{
		if ((Object)(object)BanquetOrdersManager.instance == (Object)null)
		{
			Debug.LogError((object)"Fortitude/MainEvent 4");
		}
		else if (JJCLJKMIMBH >= BanquetOrdersManager.instance.banquetCustomers.Length)
		{
			Debug.LogError((object)("Dialogue System/Conversation/Crowly_Barks_Shop/Entry/2/Dialogue Text" + JJCLJKMIMBH));
		}
		else if (BanquetOrdersManager.instance.banquetCustomers[JJCLJKMIMBH].currentRequest != null)
		{
			HMFKIEJJENE = OnlineSerializer.Deserialize<FoodInstanceMessage>(BCAMKIPAINC);
			BanquetOrdersManager.instance.banquetCustomers[JJCLJKMIMBH].EFNACNKJCDG(OnlinePlayerDataManager.GetBedAssignedByActorNumber(JJPJHIHBOIB), NLCDDFDGACP: false, HMFKIEJJENE.ENBNOJPJHHL(), FDMHEDDIGPJ);
		}
	}

	public void FBCDFFFPHBB()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "OnConversationStarted ", (RpcTarget)1);
	}

	private void GIJEABJDJIN()
	{
		BanquetEvent.KMDAMABBLIP();
	}

	private void BFLMHNHCAGP()
	{
		EventRoundsManager.NextRound();
	}

	[PunRPC]
	private void ReceiveStartKlaynDialogueOathFeast()
	{
		KlaynNPC.instance.StartKlaynDialogueOathFeast(GFNHAMCPEAK: false);
	}

	public void NAONGIOGBPA()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "[", (RpcTarget)1);
	}

	public void OOEJGAPLJDL()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Locked", (RpcTarget)1);
	}

	public void PPICAKDMGKM(byte JJCLJKMIMBH, byte[] OINICMNOLPK)
	{
		HMFKIEJJENE = OnlineSerializer.Deserialize<FoodInstanceMessage>(OINICMNOLPK);
		BanquetOrdersManager.instance.banquetCustomers[JJCLJKMIMBH].AJBMKOKEPEE(HMFKIEJJENE.JAEJCIJCCBN(), ANHLFAANEEA: true);
	}

	public void KKJCIGFOIMN(int JJCLJKMIMBH)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = (byte)JJCLJKMIMBH;
		OnlineManager.SendRPC(photonView, "Player 2 Join Buton Clicked, num players: ", (RpcTarget)1, array);
	}

	private void EJIEAHJCOOB()
	{
		EventRoundsManager.SkipChallenge();
	}

	public void HJBJACOHMAM(int GEEEJPJIGBB, bool GLKAOHGJANI, string HBILFLLKHGP, Gender HNLNENELPKI)
	{
		if (GLKAOHGJANI)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[0] = (byte)GEEEJPJIGBB;
			OnlineManager.SendRPC(photonView, "quest_description_17", (RpcTarget)1, array);
		}
		else
		{
			PhotonView photonView2 = ((MonoBehaviourPun)this).photonView;
			object[] array2 = new object[5];
			array2[1] = (byte)GEEEJPJIGBB;
			array2[0] = (byte)HNLNENELPKI;
			array2[7] = HBILFLLKHGP;
			OnlineManager.SendRPC(photonView2, "TucanEgg", (RpcTarget)0, array2);
		}
	}

	public void HEEECNMEMHC()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "SortByType", (RpcTarget)1);
	}

	private void JNGPKIOMGIK(bool CHOPKHLMBIH)
	{
		BanquetEvent.TeleportPlayerToCastleGarden(CHOPKHLMBIH, CDPAMNIPPEC: false);
	}

	public void FEELEJNFLKJ(int JJCLJKMIMBH, FoodInstance DNLMCHDOMOK)
	{
		HMFKIEJJENE = new FoodInstanceMessage(DNLMCHDOMOK);
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Festín del Juramento/Derrota", (RpcTarget)0, (byte)JJCLJKMIMBH, OnlineSerializer.Serialize(HMFKIEJJENE), null, null);
	}

	public void PJMNMAAGBDA()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "UIBack", (RpcTarget)1);
	}

	public void KHGBPLGOONK()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "EnterTavernNeutral", (RpcTarget)1);
	}

	private void HGPMKNILCKF(bool CHOPKHLMBIH)
	{
		BanquetEvent.TeleportPlayerToCastleGarden(CHOPKHLMBIH, CDPAMNIPPEC: false);
	}

	public void FEKHLHEMCNJ(byte JJCLJKMIMBH, byte OPGEOAFCIGE)
	{
		if ((Object)(object)BanquetOrdersManager.instance == (Object)null)
		{
			Debug.LogError((object)"ReceiveAddZone");
		}
		else if (JJCLJKMIMBH < 1 || JJCLJKMIMBH >= BanquetOrdersManager.instance.banquetCustomers.Length)
		{
			Debug.LogError((object)("Clear" + JJCLJKMIMBH));
		}
		else
		{
			BanquetOrdersManager.instance.banquetCustomers[JJCLJKMIMBH].banquetCustomerState = (BanquetCustomerState)OPGEOAFCIGE;
		}
	}

	public void DMMICDFHKMJ()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "MopRight", (RpcTarget)1);
	}

	public void CBFHIEMKOGE(int GEEEJPJIGBB, bool GLKAOHGJANI, string HBILFLLKHGP, Gender HNLNENELPKI)
	{
		if (GLKAOHGJANI)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[1] = (byte)GEEEJPJIGBB;
			OnlineManager.SendRPC(photonView, "Items/item_name_627", (RpcTarget)0, array);
		}
		else
		{
			PhotonView photonView2 = ((MonoBehaviourPun)this).photonView;
			object[] array2 = new object[6];
			array2[1] = (byte)GEEEJPJIGBB;
			array2[1] = (byte)HNLNENELPKI;
			array2[7] = HBILFLLKHGP;
			OnlineManager.SendRPC(photonView2, "info", (RpcTarget)0, array2);
		}
	}

	private void NCLIEMDLOJP(byte GJDMLMEMKMD)
	{
		int actorNumberByBedAssigned = OnlinePlayerDataManager.GetActorNumberByBedAssigned(GJDMLMEMKMD);
		OnlineManager.AddPlayerPrepared(GJDMLMEMKMD, OnlinePlayerDataManager.EDKBGMHNDLJ(actorNumberByBedAssigned), OnlinePlayerDataManager.GetPlayerGender(actorNumberByBedAssigned));
	}

	private void JOEOOJCLEDM(bool CHOPKHLMBIH)
	{
		BanquetEvent.TeleportPlayerToCastleGarden(CHOPKHLMBIH, CDPAMNIPPEC: false);
	}

	public void SendStartKlaynChallenge()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveStartKlaynChallenge", (RpcTarget)1);
	}

	private void DCGDPNDHLNB()
	{
		EventRoundsManager.NextRound();
	}

	public void NJCPIGCGONF(byte JJCLJKMIMBH)
	{
		BanquetOrdersManager.instance.banquetCustomers[JJCLJKMIMBH].MEMHBEIAICP();
	}

	private void HCIONMPHCOM()
	{
		KlaynNPC.instance.INBOCFNJOLK(GFNHAMCPEAK: false);
	}

	public void IIODOMFIIMA(byte JJCLJKMIMBH, byte OPGEOAFCIGE)
	{
		if ((Object)(object)BanquetOrdersManager.instance == (Object)null)
		{
			Debug.LogError((object)"");
		}
		else if (JJCLJKMIMBH < 0 || JJCLJKMIMBH >= BanquetOrdersManager.instance.banquetCustomers.Length)
		{
			Debug.LogError((object)("Object dropped on Bar position: " + JJCLJKMIMBH));
		}
		else
		{
			BanquetOrdersManager.instance.banquetCustomers[JJCLJKMIMBH].banquetCustomerState = (BanquetCustomerState)OPGEOAFCIGE;
		}
	}

	public void CHAOHIHFHOP(byte JJCLJKMIMBH, byte[] BCAMKIPAINC, bool FDMHEDDIGPJ, int JJPJHIHBOIB)
	{
		if ((Object)(object)BanquetOrdersManager.instance == (Object)null)
		{
			Debug.LogError((object)"chatx");
		}
		else if (JJCLJKMIMBH >= BanquetOrdersManager.instance.banquetCustomers.Length)
		{
			Debug.LogError((object)("questNameGruel" + JJCLJKMIMBH));
		}
		else if (BanquetOrdersManager.instance.banquetCustomers[JJCLJKMIMBH].currentRequest != null)
		{
			HMFKIEJJENE = OnlineSerializer.Deserialize<FoodInstanceMessage>(BCAMKIPAINC);
			BanquetOrdersManager.instance.banquetCustomers[JJCLJKMIMBH].NHHLECPCOFB(OnlinePlayerDataManager.GetBedAssignedByActorNumber(JJPJHIHBOIB), NLCDDFDGACP: true, HMFKIEJJENE.IHBKMGFGGNE(), FDMHEDDIGPJ);
		}
	}

	private void OFBJMPDAJNA(byte GJDMLMEMKMD)
	{
		int actorNumberByBedAssigned = OnlinePlayerDataManager.GetActorNumberByBedAssigned(GJDMLMEMKMD);
		OnlineManager.AddPlayerPrepared(GJDMLMEMKMD, OnlinePlayerDataManager.EDKBGMHNDLJ(actorNumberByBedAssigned), OnlinePlayerDataManager.GGPPENHHFAD(actorNumberByBedAssigned));
	}

	public void SendBanquetCustomerState(int JJCLJKMIMBH, BanquetCustomerState OPGEOAFCIGE)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveBanquetCustomerState", (RpcTarget)1, (byte)JJCLJKMIMBH, (byte)OPGEOAFCIGE);
	}

	public void CALKFDFJMIH(byte JJCLJKMIMBH, byte[] BCAMKIPAINC, bool FDMHEDDIGPJ, int JJPJHIHBOIB)
	{
		if ((Object)(object)BanquetOrdersManager.instance == (Object)null)
		{
			Debug.LogError((object)"MainProgress");
		}
		else if (JJCLJKMIMBH >= BanquetOrdersManager.instance.banquetCustomers.Length)
		{
			Debug.LogError((object)("Key2" + JJCLJKMIMBH));
		}
		else if (BanquetOrdersManager.instance.banquetCustomers[JJCLJKMIMBH].currentRequest != null)
		{
			HMFKIEJJENE = OnlineSerializer.Deserialize<FoodInstanceMessage>(BCAMKIPAINC);
			BanquetOrdersManager.instance.banquetCustomers[JJCLJKMIMBH].CompleteItemTransaction(OnlinePlayerDataManager.GetBedAssignedByActorNumber(JJPJHIHBOIB), NLCDDFDGACP: false, HMFKIEJJENE.OCNJKFGMFFK(), FDMHEDDIGPJ);
		}
	}

	public void CGEFEOCPFJD(byte JJCLJKMIMBH, byte[] OINICMNOLPK)
	{
		HMFKIEJJENE = OnlineSerializer.Deserialize<FoodInstanceMessage>(OINICMNOLPK);
		BanquetOrdersManager.instance.banquetCustomers[JJCLJKMIMBH].RequestTableOrder(HMFKIEJJENE.JJFKOPICIHJ(), ANHLFAANEEA: true);
	}

	private void MKMAOGIAGLB()
	{
		EventRoundsManager.SkipChallenge(CDPAMNIPPEC: false);
	}

	public void EHNKJAOLJEL()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "UISelectGamepad", (RpcTarget)0);
	}

	public void APLGMIDMAFF()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "cameraZoom2", (RpcTarget)1);
	}

	public void SendSkipKlaynChallenge()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveSkipKlaynChallenge", (RpcTarget)1);
	}

	public void FJDOAOLKCPH(bool CHOPKHLMBIH)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = CHOPKHLMBIH;
		OnlineManager.SendRPC(photonView, " seconds.", (RpcTarget)1, array);
	}

	public void SendActivateAndStartBanquetEvent()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveActivateAndStartBanquetEvent", (RpcTarget)1);
	}

	[PunRPC]
	public void ReceiveRequestTableOrderBanquetCustomer(byte JJCLJKMIMBH, byte[] OINICMNOLPK)
	{
		HMFKIEJJENE = OnlineSerializer.Deserialize<FoodInstanceMessage>(OINICMNOLPK);
		BanquetOrdersManager.instance.banquetCustomers[JJCLJKMIMBH].RequestTableOrder(HMFKIEJJENE.ANMBPDJLNFN());
	}

	public void AHAPLLHHMFI()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Focused", (RpcTarget)0);
	}

	public void CHGOBDEPLCB()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Tutorial/Barn_Holly", (RpcTarget)1);
	}

	public void AGLKMBHIKKC()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Dialogue System/Conversation/Crowly_Introduce/Entry/11/Dialogue Text", (RpcTarget)1);
	}

	public void KJGEOAPLFBP(byte JJCLJKMIMBH, byte[] BCAMKIPAINC, bool FDMHEDDIGPJ, int JJPJHIHBOIB)
	{
		if ((Object)(object)BanquetOrdersManager.instance == (Object)null)
		{
			Debug.LogError((object)"SetUpImportantGuest");
		}
		else if (JJCLJKMIMBH >= BanquetOrdersManager.instance.banquetCustomers.Length)
		{
			Debug.LogError((object)("ReceiveLoadMine" + JJCLJKMIMBH));
		}
		else if (BanquetOrdersManager.instance.banquetCustomers[JJCLJKMIMBH].currentRequest != null)
		{
			HMFKIEJJENE = OnlineSerializer.Deserialize<FoodInstanceMessage>(BCAMKIPAINC);
			BanquetOrdersManager.instance.banquetCustomers[JJCLJKMIMBH].AKEKMPGHJPL(OnlinePlayerDataManager.AKLPADOCHDP(JJPJHIHBOIB), NLCDDFDGACP: false, HMFKIEJJENE.JJFKOPICIHJ(), FDMHEDDIGPJ);
		}
	}

	public void LBJPOEHIDEF()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveHoeActionMaster", (RpcTarget)1);
	}

	private void GLGPIIIFJEI()
	{
		BanquetEvent.KMDAMABBLIP();
	}

	public void HLAKCKPHBAM(byte JJCLJKMIMBH, byte[] OINICMNOLPK)
	{
		HMFKIEJJENE = OnlineSerializer.Deserialize<FoodInstanceMessage>(OINICMNOLPK);
		BanquetOrdersManager.instance.banquetCustomers[JJCLJKMIMBH].RequestTableOrder(HMFKIEJJENE.NMELFMAKGDK(), ANHLFAANEEA: true);
	}

	private void DFODHGDKBIO(bool CHOPKHLMBIH)
	{
		BanquetEvent.TeleportPlayerToCastleGarden(CHOPKHLMBIH);
	}

	public void ILEFKHABFMP(int GEEEJPJIGBB, bool GLKAOHGJANI, string HBILFLLKHGP, Gender HNLNENELPKI)
	{
		if (GLKAOHGJANI)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[1] = (byte)GEEEJPJIGBB;
			OnlineManager.SendRPC(photonView, "Interact", (RpcTarget)1, array);
		}
		else
		{
			PhotonView photonView2 = ((MonoBehaviourPun)this).photonView;
			object[] array2 = new object[5];
			array2[1] = (byte)GEEEJPJIGBB;
			array2[1] = (byte)HNLNENELPKI;
			array2[3] = HBILFLLKHGP;
			OnlineManager.SendRPC(photonView2, "LE_13", (RpcTarget)1, array2);
		}
	}

	public void HFCMMFGDPFD(byte JJCLJKMIMBH, byte[] BCAMKIPAINC, bool FDMHEDDIGPJ, int JJPJHIHBOIB)
	{
		if ((Object)(object)BanquetOrdersManager.instance == (Object)null)
		{
			Debug.LogError((object)"Disabled");
		}
		else if (JJCLJKMIMBH >= BanquetOrdersManager.instance.banquetCustomers.Length)
		{
			Debug.LogError((object)("LE_10" + JJCLJKMIMBH));
		}
		else if (BanquetOrdersManager.instance.banquetCustomers[JJCLJKMIMBH].currentRequest != null)
		{
			HMFKIEJJENE = OnlineSerializer.Deserialize<FoodInstanceMessage>(BCAMKIPAINC);
			BanquetOrdersManager.instance.banquetCustomers[JJCLJKMIMBH].EFNACNKJCDG(OnlinePlayerDataManager.GetBedAssignedByActorNumber(JJPJHIHBOIB), NLCDDFDGACP: false, HMFKIEJJENE.ANMBPDJLNFN(), FDMHEDDIGPJ);
		}
	}

	private void DBNPNMNDEBG(bool CHOPKHLMBIH)
	{
		BanquetEvent.KBCPDJLMEPP(CHOPKHLMBIH);
	}

	private void FJGOIAABEAM()
	{
		EventRoundsManager.SkipChallenge(CDPAMNIPPEC: false);
	}

	private void LELOBOCAMMP(byte GJDMLMEMKMD)
	{
		int actorNumberByBedAssigned = OnlinePlayerDataManager.GetActorNumberByBedAssigned(GJDMLMEMKMD);
		OnlineManager.AddPlayerPrepared(GJDMLMEMKMD, OnlinePlayerDataManager.GetPlayerName(actorNumberByBedAssigned), OnlinePlayerDataManager.GetPlayerGender(actorNumberByBedAssigned));
	}

	public void NBLPFGMODEE(int JJCLJKMIMBH)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = (byte)JJCLJKMIMBH;
		OnlineManager.SendRPC(photonView, "Duplicate tutorial ID found!", (RpcTarget)0, array);
	}

	public void LIABCEEFKLK(int GEEEJPJIGBB, bool GLKAOHGJANI, string HBILFLLKHGP, Gender HNLNENELPKI)
	{
		if (GLKAOHGJANI)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[1] = (byte)GEEEJPJIGBB;
			OnlineManager.SendRPC(photonView, "current Segment playing", (RpcTarget)0, array);
		}
		else
		{
			PhotonView photonView2 = ((MonoBehaviourPun)this).photonView;
			object[] array2 = new object[3];
			array2[1] = (byte)GEEEJPJIGBB;
			array2[0] = (byte)HNLNENELPKI;
			array2[6] = HBILFLLKHGP;
			OnlineManager.SendRPC(photonView2, "itemRedGrapeSeeds", (RpcTarget)0, array2);
		}
	}

	public void EKDIIPAJPDB(int JJCLJKMIMBH, FoodInstance GCJPFFNGCJA, bool FDMHEDDIGPJ)
	{
		HMFKIEJJENE = new FoodInstanceMessage(GCJPFFNGCJA);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[2];
		array[1] = (byte)JJCLJKMIMBH;
		array[0] = OnlineSerializer.Serialize(HMFKIEJJENE);
		array[8] = FDMHEDDIGPJ;
		array[1] = PhotonNetwork.LocalPlayer.ActorNumber;
		OnlineManager.SendRPC(photonView, "CultivableAllYearRound", (RpcTarget)3, array);
	}

	public void HMKBGOBBFIF()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Inventory full", (RpcTarget)0);
	}

	public void NJFBJJCICKD(byte JJCLJKMIMBH, byte OPGEOAFCIGE)
	{
		if ((Object)(object)BanquetOrdersManager.instance == (Object)null)
		{
			Debug.LogError((object)"ReceiveEnableTrigger");
		}
		else if (JJCLJKMIMBH < 1 || JJCLJKMIMBH >= BanquetOrdersManager.instance.banquetCustomers.Length)
		{
			Debug.LogError((object)("Antorcha({0})" + JJCLJKMIMBH));
		}
		else
		{
			BanquetOrdersManager.instance.banquetCustomers[JJCLJKMIMBH].banquetCustomerState = (BanquetCustomerState)OPGEOAFCIGE;
		}
	}

	private void KELFOLNGHHG()
	{
		KlaynNPC.instance.KMNOOJJJCAO(GFNHAMCPEAK: false);
	}

	public void IPKPNDAFODO(int JJCLJKMIMBH, FoodInstance GCJPFFNGCJA, bool FDMHEDDIGPJ)
	{
		HMFKIEJJENE = new FoodInstanceMessage(GCJPFFNGCJA);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[6];
		array[0] = (byte)JJCLJKMIMBH;
		array[1] = OnlineSerializer.JBIPDCGKMGE(HMFKIEJJENE);
		array[8] = FDMHEDDIGPJ;
		array[1] = PhotonNetwork.LocalPlayer.ActorNumber;
		OnlineManager.SendRPC(photonView, "ActionBar10", (RpcTarget)4, array);
	}

	[PunRPC]
	private void ReceiveTeleportPlayerToCastleGarden(bool CHOPKHLMBIH)
	{
		BanquetEvent.TeleportPlayerToCastleGarden(CHOPKHLMBIH, CDPAMNIPPEC: false);
	}

	[PunRPC]
	private void ReceiveSkipKlaynChallenge()
	{
		EventRoundsManager.SkipChallenge(CDPAMNIPPEC: false);
	}

	public void JHFGIHHHJML(bool CHOPKHLMBIH)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = CHOPKHLMBIH;
		OnlineManager.SendRPC(photonView, "The mine piece ", (RpcTarget)1, array);
	}

	public void OFLFKBNOPDN(byte JJCLJKMIMBH)
	{
		BanquetOrdersManager.instance.banquetCustomers[JJCLJKMIMBH].GCKMHJLIGGJ();
	}

	public void OLGOOOEIGKN(byte JJCLJKMIMBH, byte OPGEOAFCIGE)
	{
		if ((Object)(object)BanquetOrdersManager.instance == (Object)null)
		{
			Debug.LogError((object)"</color><br>");
		}
		else if (JJCLJKMIMBH < 1 || JJCLJKMIMBH >= BanquetOrdersManager.instance.banquetCustomers.Length)
		{
			Debug.LogError((object)("ReceiveUpdateBentoOnTray" + JJCLJKMIMBH));
		}
		else
		{
			BanquetOrdersManager.instance.banquetCustomers[JJCLJKMIMBH].banquetCustomerState = (BanquetCustomerState)OPGEOAFCIGE;
		}
	}

	public void IOMCCHBNBFL(int JJCLJKMIMBH)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = (byte)JJCLJKMIMBH;
		OnlineManager.SendRPC(photonView, "SendRoomRequest", (RpcTarget)0, array);
	}

	public void SendNextRound()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveNextRound", (RpcTarget)1);
	}

	public void NIBAAINCDAE(int JJCLJKMIMBH, FoodInstance GCJPFFNGCJA, bool FDMHEDDIGPJ)
	{
		HMFKIEJJENE = new FoodInstanceMessage(GCJPFFNGCJA);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[5];
		array[0] = (byte)JJCLJKMIMBH;
		array[1] = OnlineSerializer.EKNOFIJNBAP(HMFKIEJJENE);
		array[4] = FDMHEDDIGPJ;
		array[6] = PhotonNetwork.LocalPlayer.ActorNumber;
		OnlineManager.SendRPC(photonView, "Dialogue System/Conversation/Crowly_Barks_Shop/Entry/2/Dialogue Text", (RpcTarget)8, array);
	}

	public void NEPLIHDLPPD(int GEEEJPJIGBB, bool GLKAOHGJANI, string HBILFLLKHGP, Gender HNLNENELPKI)
	{
		if (GLKAOHGJANI)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[1] = (byte)GEEEJPJIGBB;
			OnlineManager.SendRPC(photonView, "Player2", (RpcTarget)1, array);
		}
		else
		{
			PhotonView photonView2 = ((MonoBehaviourPun)this).photonView;
			object[] array2 = new object[4];
			array2[1] = (byte)GEEEJPJIGBB;
			array2[1] = (byte)HNLNENELPKI;
			array2[0] = HBILFLLKHGP;
			OnlineManager.SendRPC(photonView2, " / ", (RpcTarget)1, array2);
		}
	}

	public void SendRequestTableOrderBanquetCustomer(int JJCLJKMIMBH, FoodInstance DNLMCHDOMOK)
	{
		HMFKIEJJENE = new FoodInstanceMessage(DNLMCHDOMOK);
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveRequestTableOrderBanquetCustomer", (RpcTarget)1, (byte)JJCLJKMIMBH, OnlineSerializer.Serialize(HMFKIEJJENE));
	}

	public void JJHGJMBAAPM(bool CHOPKHLMBIH)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveUpdatePoints", (RpcTarget)1, CHOPKHLMBIH);
	}

	public void BEKGMECCKKG(int JJCLJKMIMBH, FoodInstance DNLMCHDOMOK)
	{
		HMFKIEJJENE = new FoodInstanceMessage(DNLMCHDOMOK);
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, " (", (RpcTarget)1, (byte)JJCLJKMIMBH, OnlineSerializer.JBIPDCGKMGE(HMFKIEJJENE), null, null, null);
	}

	private void BPAANFADOGH()
	{
		KlaynNPC.instance.INBOCFNJOLK(GFNHAMCPEAK: true);
	}

	[PunRPC]
	private void ReceiveStopWaitingForBanquetEvent(byte GJDMLMEMKMD, byte HNLNENELPKI, string HBILFLLKHGP)
	{
		OnlineManager.RemovePlayerPrepared(GJDMLMEMKMD, HBILFLLKHGP, (Gender)HNLNENELPKI);
	}

	public void OCAOFOFKEOB()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Tutorial", (RpcTarget)0);
	}

	public void LEBMJKBEAKP(int JJCLJKMIMBH, FoodInstance DNLMCHDOMOK)
	{
		HMFKIEJJENE = new FoodInstanceMessage(DNLMCHDOMOK);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[0] = (byte)JJCLJKMIMBH;
		array[0] = OnlineSerializer.Serialize(HMFKIEJJENE);
		OnlineManager.SendRPC(photonView, "ReceiveWorkArea", (RpcTarget)1, array);
	}

	public void NBEGADEEHHO()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "/Male/", (RpcTarget)0);
	}

	public void LOMHHOEFLOL()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, " at ", (RpcTarget)0);
	}

	public void OGDEMCGOEEM(int GEEEJPJIGBB, bool GLKAOHGJANI, string HBILFLLKHGP, Gender HNLNENELPKI)
	{
		if (GLKAOHGJANI)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[0] = (byte)GEEEJPJIGBB;
			OnlineManager.SendRPC(photonView, "StartEvent can only be called in play mode.", (RpcTarget)0, array);
		}
		else
		{
			PhotonView photonView2 = ((MonoBehaviourPun)this).photonView;
			object[] array2 = new object[1];
			array2[0] = (byte)GEEEJPJIGBB;
			array2[0] = (byte)HNLNENELPKI;
			array2[7] = HBILFLLKHGP;
			OnlineManager.SendRPC(photonView2, "tutorialPopUp80", (RpcTarget)0, array2);
		}
	}

	private void LHGEOAGMBNL()
	{
		BanquetEvent.DeactivateBanquetEvent(CDPAMNIPPEC: false);
	}

	public void GEHMBBDHGNL(int JJCLJKMIMBH, BanquetCustomerState OPGEOAFCIGE)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[3];
		array[1] = (byte)JJCLJKMIMBH;
		array[0] = (byte)OPGEOAFCIGE;
		OnlineManager.SendRPC(photonView, "UINextCategory", (RpcTarget)0, array);
	}

	public void BKDCGMFIECD(int JJCLJKMIMBH, FoodInstance DNLMCHDOMOK)
	{
		HMFKIEJJENE = new FoodInstanceMessage(DNLMCHDOMOK);
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Required Items", (RpcTarget)1, (byte)JJCLJKMIMBH, OnlineSerializer.JBIPDCGKMGE(HMFKIEJJENE), null, null, null, null, null, null);
	}

	private void BEKCPBIJBGN()
	{
		BanquetEvent.JBPGEKHNNPG(CDPAMNIPPEC: false);
	}

	private void AEKNNFLLOOD()
	{
		BanquetEvent.DeactivateBanquetEvent();
	}

	public void AOPAKBNDOKL(bool CHOPKHLMBIH)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = CHOPKHLMBIH;
		OnlineManager.SendRPC(photonView, "OnlinePlayer", (RpcTarget)1, array);
	}

	public void PCPPKIMLPFG(bool CHOPKHLMBIH)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = CHOPKHLMBIH;
		OnlineManager.SendRPC(photonView, "itemMaltedWheat", (RpcTarget)1, array);
	}

	public void FIKPACHADGN(byte JJCLJKMIMBH, byte OPGEOAFCIGE)
	{
		if ((Object)(object)BanquetOrdersManager.instance == (Object)null)
		{
			Debug.LogError((object)"Attack/MainEvent 6");
		}
		else if (JJCLJKMIMBH < 0 || JJCLJKMIMBH >= BanquetOrdersManager.instance.banquetCustomers.Length)
		{
			Debug.LogError((object)("Scripted" + JJCLJKMIMBH));
		}
		else
		{
			BanquetOrdersManager.instance.banquetCustomers[JJCLJKMIMBH].banquetCustomerState = (BanquetCustomerState)OPGEOAFCIGE;
		}
	}

	public void CKCMBHEOOND()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "[RestoreNonAltarVariant] - VariantObjects: {0} - ({1}-{2}/{3}) ", (RpcTarget)1);
	}

	public override void OnPlayerLeftRoom(Player OKAOHBANICM)
	{
		((MonoBehaviourPunCallbacks)this).OnPlayerLeftRoom(OKAOHBANICM);
		if (BanquetEvent.GGPPFKPOCLL)
		{
			ChallengeEventPointsUI.instance.HidePlayerPoints(OnlinePlayerDataManager.GetBedAssignedByActorNumber(OKAOHBANICM.ActorNumber));
		}
	}

	[PunRPC]
	private void ReceiveStartWaitingForBanquetEvent(byte GJDMLMEMKMD)
	{
		int actorNumberByBedAssigned = OnlinePlayerDataManager.GetActorNumberByBedAssigned(GJDMLMEMKMD);
		OnlineManager.AddPlayerPrepared(GJDMLMEMKMD, OnlinePlayerDataManager.GetPlayerName(actorNumberByBedAssigned), OnlinePlayerDataManager.GetPlayerGender(actorNumberByBedAssigned));
	}

	private void CEHNCNKBAJD()
	{
		EventRoundsManager.NextRound(CDPAMNIPPEC: false);
	}

	public void AGJKPFBOAGP(int JJCLJKMIMBH, FoodInstance DNLMCHDOMOK)
	{
		HMFKIEJJENE = new FoodInstanceMessage(DNLMCHDOMOK);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[8];
		array[0] = (byte)JJCLJKMIMBH;
		array[0] = OnlineSerializer.Serialize(HMFKIEJJENE);
		OnlineManager.SendRPC(photonView, "SalonDelTrono/OrwinIITalk", (RpcTarget)0, array);
	}

	[PunRPC]
	private void ReceiveNextRound()
	{
		EventRoundsManager.NextRound(CDPAMNIPPEC: false);
	}

	private void BLDJOFNAJAP(bool CHOPKHLMBIH)
	{
		BanquetEvent.TeleportPlayerToCastleGarden(CHOPKHLMBIH, CDPAMNIPPEC: false);
	}

	public void KAHDLGHDLHG(int JJCLJKMIMBH)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Disabled", (RpcTarget)1, (byte)JJCLJKMIMBH);
	}

	private void OIOLGAOPECC()
	{
		instance = this;
	}

	private void NBPEEOPDFGK()
	{
		KlaynNPC.instance.INBOCFNJOLK(GFNHAMCPEAK: true);
	}

	public void NAGNDGFKKLL(int JJCLJKMIMBH)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = (byte)JJCLJKMIMBH;
		OnlineManager.SendRPC(photonView, "ReceiveRenewCandle Unique id ", (RpcTarget)1, array);
	}

	[PunRPC]
	private void ReceiveActivateAndStartBanquetEvent()
	{
		BanquetEvent.ActivateAndStartBanquetEvent(CDPAMNIPPEC: false);
	}

	private void CLGBFOIBANN()
	{
		instance = this;
	}

	[PunRPC]
	private void ReceiveDeactivateEvent()
	{
		BanquetEvent.DeactivateBanquetEvent(CDPAMNIPPEC: false);
	}

	public void IELIKPEADJH(byte JJCLJKMIMBH, byte[] OINICMNOLPK)
	{
		HMFKIEJJENE = OnlineSerializer.Deserialize<FoodInstanceMessage>(OINICMNOLPK);
		BanquetOrdersManager.instance.banquetCustomers[JJCLJKMIMBH].RequestTableOrder(HMFKIEJJENE.MJINGJBMAIE());
	}

	public void KNHNKOHOJHN(int JJCLJKMIMBH, BanquetCustomerState OPGEOAFCIGE)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[2];
		array[0] = (byte)JJCLJKMIMBH;
		array[0] = (byte)OPGEOAFCIGE;
		OnlineManager.SendRPC(photonView, "Could not get name of achievement ", (RpcTarget)1, array);
	}

	public void BKLIMINPDKC(int GEEEJPJIGBB, bool GLKAOHGJANI, string HBILFLLKHGP, Gender HNLNENELPKI)
	{
		if (GLKAOHGJANI)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[1] = (byte)GEEEJPJIGBB;
			OnlineManager.SendRPC(photonView, "BirdInAChest_Error", (RpcTarget)1, array);
			return;
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Could not find item with id: ", (RpcTarget)1, (byte)GEEEJPJIGBB, (byte)HNLNENELPKI, null, null, null, HBILFLLKHGP, null, null);
	}

	private void LCAEHOJPIEN(byte GJDMLMEMKMD, byte HNLNENELPKI, string HBILFLLKHGP)
	{
		OnlineManager.RemovePlayerPrepared(GJDMLMEMKMD, HBILFLLKHGP, (Gender)HNLNENELPKI);
	}

	private void NAKJLDNCPJJ(byte GJDMLMEMKMD)
	{
		int actorNumberByBedAssigned = OnlinePlayerDataManager.GetActorNumberByBedAssigned(GJDMLMEMKMD);
		OnlineManager.AddPlayerPrepared(GJDMLMEMKMD, OnlinePlayerDataManager.OIMEFCJGACI(actorNumberByBedAssigned), OnlinePlayerDataManager.GetPlayerGender(actorNumberByBedAssigned));
	}

	public void IGAPMKFJFMH(int GEEEJPJIGBB, bool GLKAOHGJANI, string HBILFLLKHGP, Gender HNLNENELPKI)
	{
		if (GLKAOHGJANI)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[0] = (byte)GEEEJPJIGBB;
			OnlineManager.SendRPC(photonView, "Order", (RpcTarget)1, array);
		}
		else
		{
			PhotonView photonView2 = ((MonoBehaviourPun)this).photonView;
			object[] array2 = new object[6];
			array2[1] = (byte)GEEEJPJIGBB;
			array2[1] = (byte)HNLNENELPKI;
			array2[3] = HBILFLLKHGP;
			OnlineManager.SendRPC(photonView2, "UpgradeObjectConfirmation", (RpcTarget)1, array2);
		}
	}

	[PunRPC]
	public void ReceiveBanquetCustomerState(byte JJCLJKMIMBH, byte OPGEOAFCIGE)
	{
		if ((Object)(object)BanquetOrdersManager.instance == (Object)null)
		{
			Debug.LogError((object)"BanquetOrdersManager is not initialized.");
		}
		else if (JJCLJKMIMBH < 0 || JJCLJKMIMBH >= BanquetOrdersManager.instance.banquetCustomers.Length)
		{
			Debug.LogError((object)("Invalid banquet customer ID: " + JJCLJKMIMBH));
		}
		else
		{
			BanquetOrdersManager.instance.banquetCustomers[JJCLJKMIMBH].banquetCustomerState = (BanquetCustomerState)OPGEOAFCIGE;
		}
	}

	[PunRPC]
	private void ReceiveStartKlaynChallenge()
	{
		BanquetEvent.StartKlaynChallenge(CDPAMNIPPEC: false);
	}

	private void Awake()
	{
		instance = this;
	}

	private void GNDCOEAAHAM()
	{
		BanquetEvent.HCEKMLIDMFG();
	}

	public void KHBLCGOJINN(byte JJCLJKMIMBH, byte OPGEOAFCIGE)
	{
		if ((Object)(object)BanquetOrdersManager.instance == (Object)null)
		{
			Debug.LogError((object)"room info with code ");
		}
		else if (JJCLJKMIMBH < 1 || JJCLJKMIMBH >= BanquetOrdersManager.instance.banquetCustomers.Length)
		{
			Debug.LogError((object)("ReceiveOpenCloseTavernOnMaster" + JJCLJKMIMBH));
		}
		else
		{
			BanquetOrdersManager.instance.banquetCustomers[JJCLJKMIMBH].banquetCustomerState = (BanquetCustomerState)OPGEOAFCIGE;
		}
	}

	public void HHGEJCCLGJC(byte JJCLJKMIMBH, byte[] OINICMNOLPK)
	{
		HMFKIEJJENE = OnlineSerializer.Deserialize<FoodInstanceMessage>(OINICMNOLPK);
		BanquetOrdersManager.instance.banquetCustomers[JJCLJKMIMBH].RequestTableOrder(HMFKIEJJENE.BBELGEBEBCD(), ANHLFAANEEA: true);
	}

	private void EEEHOCJKJNL(bool CHOPKHLMBIH)
	{
		BanquetEvent.KBCPDJLMEPP(CHOPKHLMBIH, CDPAMNIPPEC: false);
	}

	private void PJCAKLNJILK()
	{
		EventRoundsManager.NextRound(CDPAMNIPPEC: false);
	}

	public void GILJMDMJPGD()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "DoYouWantToRepairIt", (RpcTarget)1);
	}

	public void NCIOCLBJEFB(int JJCLJKMIMBH)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Items/item_description_725", (RpcTarget)1, (byte)JJCLJKMIMBH);
	}

	private void GHGBIONOGJI()
	{
		KlaynNPC.instance.INBOCFNJOLK(GFNHAMCPEAK: true);
	}

	public void SendStartKlaynDialogueOathFeast()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveStartKlaynDialogueOathFeast", (RpcTarget)1);
	}
}
