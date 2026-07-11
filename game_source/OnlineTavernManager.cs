using System;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

[RequireComponent(typeof(PhotonView))]
public class OnlineTavernManager : MonoBehaviourPunCallbacks
{
	private const int LDMKIGKAGEO = 998;

	public static OnlineTavernManager instance;

	private FoodInstanceMessage HMFKIEJJENE;

	public void SendCalculateRandomPositionsInTavern()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveCalculateRandomPositionsInTavernMaster", (RpcTarget)2);
	}

	private void Start()
	{
		if (((MonoBehaviourPun)this).photonView.ViewID != 998)
		{
			Debug.LogException(new Exception($"{((object)this).GetType()} in {((Object)((Component)this).gameObject).name}'s viewID has been reset. Set it to {998} to avoid conflicts with scene objects"), (Object)(object)((Component)this).gameObject);
		}
	}

	public void PLNCBBFIKNL(bool DBCDEKIEHMG)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = DBCDEKIEHMG;
		OnlineManager.SendRPC(photonView, "ClosePopUp", (RpcTarget)1, array);
	}

	public void ODEEEBBFGFG(bool DBCDEKIEHMG)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = DBCDEKIEHMG;
		OnlineManager.SendRPC(photonView, "Waiting for season change done", (RpcTarget)0, array);
	}

	public void SendOpenCloseTavernToMaster()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveOpenCloseTavernOnMaster", (RpcTarget)2);
	}

	private void AMKLCLLIKFD()
	{
		Utils.MBODDLPENFB();
	}

	private void GNMIOIHHHEF(bool DBCDEKIEHMG)
	{
		if (!((Object)(object)TavernManager.GGFJGHHHEJC == (Object)null))
		{
			TavernManager.GGFJGHHHEJC.SetOpen(1, DBCDEKIEHMG);
		}
	}

	public void NIMPJOPJCLC(byte HMPABLCHMFJ)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = HMPABLCHMFJ;
		OnlineManager.SendRPC(photonView, "Use", (RpcTarget)1, array);
	}

	private void LPNICHKFIOO(byte EKLFMOIHMFA, object[] GEMFIOKGIMC)
	{
		_ = (Object)(object)TavernManager.GGFJGHHHEJC == (Object)null;
	}

	private void IHICKHAABJH()
	{
		instance = this;
	}

	private void DCKKIDMJKJM()
	{
		if (((MonoBehaviourPun)this).photonView.ViewID != 125)
		{
			Debug.LogException(new Exception(string.Format("Open", ((object)this).GetType(), ((Object)((Component)this).gameObject).name, 135)), (Object)(object)((Component)this).gameObject);
		}
	}

	public void MFNDGKAMDLK(bool DBCDEKIEHMG)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = DBCDEKIEHMG;
		OnlineManager.SendRPC(photonView, "Tavern", (RpcTarget)0, array);
	}

	public void IDOGNIOIIFJ(FoodInstance GCJPFFNGCJA, int GGPJBIPJLEO)
	{
		HMFKIEJJENE = new FoodInstanceMessage(GCJPFFNGCJA);
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "autoRunP2", (RpcTarget)1, OnlineSerializer.Serialize(HMFKIEJJENE), GGPJBIPJLEO, null, null);
	}

	[PunRPC]
	private void ReceiveOpenCloseTavern(bool DBCDEKIEHMG)
	{
		if (!((Object)(object)TavernManager.GGFJGHHHEJC == (Object)null))
		{
			TavernManager.GGFJGHHHEJC.SetOpen(1, DBCDEKIEHMG);
		}
	}

	public void SendLastOrder(bool DBCDEKIEHMG, int JJPJHIHBOIB)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveLastOrder", PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, false), DBCDEKIEHMG);
	}

	public void OJNGHIHINGB(int GGPJBIPJLEO)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = GGPJBIPJLEO;
		OnlineManager.SendRPC(photonView, "CellarUnlockMessage", (RpcTarget)0, array);
	}

	public void HBLENALBHFL(bool DBCDEKIEHMG, int JJPJHIHBOIB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		Player player = PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, true);
		object[] array = new object[0];
		array[1] = DBCDEKIEHMG;
		OnlineManager.DBNIKCMHHMJ(photonView, "MineFloor", player, array);
	}

	public void EKANIINHAPA(TavernActionOnline KLPENAKBAPA, object[] GEMFIOKGIMC)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[8];
		array[1] = (byte)KLPENAKBAPA;
		array[0] = GEMFIOKGIMC;
		OnlineManager.SendRPC(photonView, "NEW IMPORTANT CUSTOMER EVENT", (RpcTarget)1, array);
	}

	public void KIDBPEDHGFK(byte[] OINICMNOLPK, int GGPJBIPJLEO)
	{
		HMFKIEJJENE = OnlineSerializer.Deserialize<FoodInstanceMessage>(OINICMNOLPK);
		DrinksTable.instance.CAGAEJECCLG(HMFKIEJJENE.ENBNOJPJHHL(), CDPAMNIPPEC: true, GGPJBIPJLEO);
	}

	private void IKAAHLKIDHB()
	{
		Utils.MBODDLPENFB();
	}

	private void HMODGBCOKDP(bool DBCDEKIEHMG)
	{
		if (!((Object)(object)TavernManager.GGFJGHHHEJC == (Object)null))
		{
			TavernManager.GGFJGHHHEJC.PHCLGNAFEFL(0, DBCDEKIEHMG, AINPJHKNJGL: true);
		}
	}

	public void NNLFNNHHINB(byte[] OINICMNOLPK, int GGPJBIPJLEO)
	{
		HMFKIEJJENE = OnlineSerializer.Deserialize<FoodInstanceMessage>(OINICMNOLPK);
		DrinksTable.instance.IPMMKNNAPLH(HMFKIEJJENE.ANMBPDJLNFN(), CDPAMNIPPEC: true, GGPJBIPJLEO);
	}

	private void CMLLBIDFNEB()
	{
		if (((MonoBehaviourPun)this).photonView.ViewID != 135)
		{
			Debug.LogException(new Exception(string.Format("Hammer", ((object)this).GetType(), ((Object)((Component)this).gameObject).name, 14)), (Object)(object)((Component)this).gameObject);
		}
	}

	public void ANIHMAFBFCP()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "\" and value \"", (RpcTarget)5);
	}

	private void JEMAINIMJFH(short POCCLFCJBBO)
	{
		TavernAmbienceController.POINNCPMEIG().numberOfCustomers = POCCLFCJBBO;
		TavernAmbienceController.MAMKICHCPON().EEMDJHPCHGN();
	}

	public void HLFKEDCOIHO(byte[] OINICMNOLPK, int GGPJBIPJLEO)
	{
		HMFKIEJJENE = OnlineSerializer.Deserialize<FoodInstanceMessage>(OINICMNOLPK);
		DrinksTable.instance.EMJCFIECCOC(HMFKIEJJENE.NMELFMAKGDK(), CDPAMNIPPEC: false, GGPJBIPJLEO);
	}

	public void ILCKNBMMIOD(FoodInstance GCJPFFNGCJA, int GGPJBIPJLEO)
	{
		HMFKIEJJENE = new FoodInstanceMessage(GCJPFFNGCJA);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = OnlineSerializer.Serialize(HMFKIEJJENE);
		array[1] = GGPJBIPJLEO;
		OnlineManager.SendRPC(photonView, "ReceiveTavernObstacles", (RpcTarget)0, array);
	}

	private void IDHCFOCEPMD()
	{
		if (((MonoBehaviourPun)this).photonView.ViewID != -16)
		{
			Debug.LogException(new Exception(string.Format("Error_BarIsBlocking", ((object)this).GetType(), ((Object)((Component)this).gameObject).name, 16)), (Object)(object)((Component)this).gameObject);
		}
	}

	private void KJHKBGDJNDC()
	{
		instance = this;
	}

	public void NABPEOEIFBK(bool DBCDEKIEHMG)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = DBCDEKIEHMG;
		OnlineManager.SendRPC(photonView, "</color>", (RpcTarget)1, array);
	}

	public void FBCCOHCAMLD()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "EnableNPC", (RpcTarget)1);
	}

	[PunRPC]
	private void RecieveSetAmbience(short POCCLFCJBBO)
	{
		TavernAmbienceController.GGFJGHHHEJC.numberOfCustomers = POCCLFCJBBO;
		TavernAmbienceController.GGFJGHHHEJC.SetAmbience();
	}

	public void GBEPEHECNAH(int LMBBLHKDJEN)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = (short)LMBBLHKDJEN;
		OnlineManager.SendRPC(photonView, "Disabled", (RpcTarget)0, array);
	}

	public void LLHAECPDCNA()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "quest_name_18", (RpcTarget)1);
	}

	public void LLEDDBFJCCH(bool DBCDEKIEHMG, int JJPJHIHBOIB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		Player player = PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, false);
		object[] array = new object[0];
		array[1] = DBCDEKIEHMG;
		OnlineManager.DBNIKCMHHMJ(photonView, "UIBack", player, array);
	}

	public void NFHCLOBLHHG(byte HMPABLCHMFJ)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = HMPABLCHMFJ;
		OnlineManager.SendRPC(photonView, "No se encontró una entrada con ID {0} en la conversación '{1}'.", (RpcTarget)1, array);
	}

	public void LHONIGOOKHL(bool DBCDEKIEHMG)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = DBCDEKIEHMG;
		OnlineManager.SendRPC(photonView, "D-Pad Down", (RpcTarget)0, array);
	}

	public void SendOpenCloseTavern(bool DBCDEKIEHMG, int JJPJHIHBOIB)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveOpenCloseTavern", PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, false), DBCDEKIEHMG);
	}

	public void PNIMBMIPBFN(bool DBCDEKIEHMG, int JJPJHIHBOIB)
	{
		OnlineManager.DBNIKCMHHMJ(((MonoBehaviourPun)this).photonView, "xp", PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, true), new object[1] { DBCDEKIEHMG });
	}

	[PunRPC]
	public void ReceiveRemoveDrink(int GGPJBIPJLEO)
	{
		DrinksTable.instance.RemoveDrink(GGPJBIPJLEO, CDPAMNIPPEC: false);
	}

	public void NPMGAOMNFND(int GGPJBIPJLEO)
	{
		DrinksTable.instance.HEAGJKOIALF(GGPJBIPJLEO, CDPAMNIPPEC: true);
	}

	public void JOPDOJEOEAG(byte[] OINICMNOLPK, int GGPJBIPJLEO)
	{
		HMFKIEJJENE = OnlineSerializer.Deserialize<FoodInstanceMessage>(OINICMNOLPK);
		DrinksTable.instance.CAAIJKJKAOI(HMFKIEJJENE.ENBNOJPJHHL(), CDPAMNIPPEC: false, GGPJBIPJLEO);
	}

	private void Awake()
	{
		instance = this;
	}

	public void BMHKKDCHGPP(bool DBCDEKIEHMG, int JJPJHIHBOIB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		Player player = PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, true);
		object[] array = new object[0];
		array[0] = DBCDEKIEHMG;
		OnlineManager.SendRPC(photonView, "Error in FogManager.OnNightEnd: ", player, array);
	}

	public void GDLGMDFIJJP(FoodInstance GCJPFFNGCJA, int GGPJBIPJLEO)
	{
		HMFKIEJJENE = new FoodInstanceMessage(GCJPFFNGCJA);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[0] = OnlineSerializer.Serialize(HMFKIEJJENE);
		array[0] = GGPJBIPJLEO;
		OnlineManager.SendRPC(photonView, "Game", (RpcTarget)1, array);
	}

	public void EPGCILDBCBI(int GGPJBIPJLEO)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "City/Carpenters/Oak/Bark/Stand", (RpcTarget)0, GGPJBIPJLEO);
	}

	public void KFIEEOFDAFD(int LMBBLHKDJEN)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = (short)LMBBLHKDJEN;
		OnlineManager.SendRPC(photonView, "TermasInterior/Kenta/Intro", (RpcTarget)1, array);
	}

	[PunRPC]
	private void ReceiveTavernAction(byte EKLFMOIHMFA, params object[] GEMFIOKGIMC)
	{
		_ = (Object)(object)TavernManager.GGFJGHHHEJC == (Object)null;
	}

	public void INMLPGNIMEK(bool DBCDEKIEHMG, int JJPJHIHBOIB)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Beach", PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, false), DBCDEKIEHMG);
	}

	public void CKAPFFKBLEG(int GGPJBIPJLEO)
	{
		DrinksTable.instance.CACAEHKBPED(GGPJBIPJLEO, CDPAMNIPPEC: true);
	}

	public void AJMFMCHMAKP(int GGPJBIPJLEO)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = GGPJBIPJLEO;
		OnlineManager.SendRPC(photonView, "OnlinePlayer", (RpcTarget)0, array);
	}

	[PunRPC]
	private void ReceiveCalculateRandomPositionsInTavernMaster()
	{
		Utils.MBODDLPENFB();
	}

	private void BJKPCCJPIBN(bool DBCDEKIEHMG)
	{
		if (!((Object)(object)TavernManager.GGFJGHHHEJC == (Object)null))
		{
			if (DBCDEKIEHMG && !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
			{
				TavernManager.GGFJGHHHEJC.SetOpen(0, DBCDEKIEHMG, AINPJHKNJGL: true);
			}
			TavernManager.GGFJGHHHEJC.SetLastOrders(1, DBCDEKIEHMG);
		}
	}

	[PunRPC]
	private void ReceiveTavernHeat(byte HMPABLCHMFJ)
	{
		if (!((Object)(object)TavernManager.GGFJGHHHEJC == (Object)null))
		{
			TavernManager.GGFJGHHHEJC.ReceiveCurrentHeatLevel(HMPABLCHMFJ);
		}
	}

	public void GEHMFGNAPFJ()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "", (RpcTarget)3);
	}

	private void CJIHFIGOKHM(short POCCLFCJBBO)
	{
		TavernAmbienceController.FMIDAFEGDCD().numberOfCustomers = POCCLFCJBBO;
		TavernAmbienceController.PDECKLKPKCG().IJDGGAGMEFM();
	}

	private void KBCAAKFCLPN(byte HMPABLCHMFJ)
	{
		if (!((Object)(object)TavernManager.GGFJGHHHEJC == (Object)null))
		{
			TavernManager.GGFJGHHHEJC.NJGDMDKBOBD(HMPABLCHMFJ);
		}
	}

	public void HPHGKIDGIOM(bool DBCDEKIEHMG, int JJPJHIHBOIB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		Player player = PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, true);
		object[] array = new object[1];
		array[1] = DBCDEKIEHMG;
		OnlineManager.SendRPC(photonView, "ReceiveRandomOrderQuests", player, array);
	}

	private void NCIBKMLIIAJ()
	{
		if (((MonoBehaviourPun)this).photonView.ViewID != -70)
		{
			Debug.LogException(new Exception(string.Format("itemGreenbeanSeeds", ((object)this).GetType(), ((Object)((Component)this).gameObject).name, -135)), (Object)(object)((Component)this).gameObject);
		}
	}

	public void NHEBMMADBGA(bool DBCDEKIEHMG, int JJPJHIHBOIB)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "distillingRepUnlock", PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, false), DBCDEKIEHMG);
	}

	private void AHHDICHJEKB()
	{
		Utils.MBODDLPENFB();
	}

	public void BEFHFPLKDLL(FoodInstance GCJPFFNGCJA, int GGPJBIPJLEO)
	{
		HMFKIEJJENE = new FoodInstanceMessage(GCJPFFNGCJA);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = OnlineSerializer.EKNOFIJNBAP(HMFKIEJJENE);
		array[1] = GGPJBIPJLEO;
		OnlineManager.SendRPC(photonView, "Unique id ", (RpcTarget)1, array);
	}

	public void SendOpenCloseTavern(bool DBCDEKIEHMG)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveOpenCloseTavern", (RpcTarget)1, DBCDEKIEHMG);
	}

	private void BNIJMIOAHJN(bool DBCDEKIEHMG)
	{
		if (!((Object)(object)TavernManager.GGFJGHHHEJC == (Object)null))
		{
			if (DBCDEKIEHMG && !TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
			{
				TavernManager.GGFJGHHHEJC.PHCLGNAFEFL(0, DBCDEKIEHMG);
			}
			TavernManager.GGFJGHHHEJC.SetLastOrders(0, DBCDEKIEHMG);
		}
	}

	public void BLLBLAJOCEK(bool DBCDEKIEHMG, int JJPJHIHBOIB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		Player player = PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, true);
		object[] array = new object[1];
		array[1] = DBCDEKIEHMG;
		OnlineManager.DBNIKCMHHMJ(photonView, "{0} is not active.", player, array);
	}

	private void HINGECEDJAP()
	{
		instance = this;
	}

	private void KABGDGMOJPM()
	{
		Utils.MBODDLPENFB();
	}

	private void FPIDBDCMFCO(bool DBCDEKIEHMG)
	{
		if (!((Object)(object)TavernManager.GGFJGHHHEJC == (Object)null))
		{
			TavernManager.GGFJGHHHEJC.PHCLGNAFEFL(1, DBCDEKIEHMG);
		}
	}

	public void ECELJPIOJDP(int LMBBLHKDJEN)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = (short)LMBBLHKDJEN;
		OnlineManager.SendRPC(photonView, "<size=", (RpcTarget)0, array);
	}

	private void CLFFMNFEIPF(short POCCLFCJBBO)
	{
		TavernAmbienceController.LHKFIDJFPDB().numberOfCustomers = POCCLFCJBBO;
		TavernAmbienceController.HEKFJEKFMNO().IJDGGAGMEFM();
	}

	public void KANDMDJEAGF()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, ", ", (RpcTarget)3);
	}

	public void SendTavernHeat(byte HMPABLCHMFJ)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveTavernHeat", (RpcTarget)1, HMPABLCHMFJ);
	}

	public void LNDHKCFIMPB(TavernActionOnline KLPENAKBAPA, object[] GEMFIOKGIMC)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[2];
		array[1] = (byte)KLPENAKBAPA;
		array[0] = GEMFIOKGIMC;
		OnlineManager.SendRPC(photonView, "Actionbar 4", (RpcTarget)1, array);
	}

	public void HDDALELCCCA(bool DBCDEKIEHMG, int JJPJHIHBOIB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		Player player = PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, false);
		object[] array = new object[0];
		array[1] = DBCDEKIEHMG;
		OnlineManager.DBNIKCMHHMJ(photonView, "Items/item_name_674", player, array);
	}

	public void IBAHKGKJHCB(int LMBBLHKDJEN)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = (short)LMBBLHKDJEN;
		OnlineManager.SendRPC(photonView, "", (RpcTarget)1, array);
	}

	public void CPDEDKLBBCJ(byte HMPABLCHMFJ)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = HMPABLCHMFJ;
		OnlineManager.SendRPC(photonView, "Sleep", (RpcTarget)0, array);
	}

	public void LHJOBGOFHCC(bool DBCDEKIEHMG)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = DBCDEKIEHMG;
		OnlineManager.SendRPC(photonView, "dForDays", (RpcTarget)0, array);
	}

	[PunRPC]
	public void ReceiveAddDrink(byte[] OINICMNOLPK, int GGPJBIPJLEO)
	{
		HMFKIEJJENE = OnlineSerializer.Deserialize<FoodInstanceMessage>(OINICMNOLPK);
		DrinksTable.instance.AddDrink(HMFKIEJJENE.ANMBPDJLNFN(), CDPAMNIPPEC: false, GGPJBIPJLEO);
	}

	private void PEDBBKFPJKM()
	{
		Utils.MBODDLPENFB();
	}

	private void NIDOJBIMLHM(byte EKLFMOIHMFA, object[] GEMFIOKGIMC)
	{
		_ = (Object)(object)TavernManager.GGFJGHHHEJC == (Object)null;
	}

	public void OEPMHGGAKMN(byte HMPABLCHMFJ)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = HMPABLCHMFJ;
		OnlineManager.SendRPC(photonView, "Disconnected Corroutine", (RpcTarget)0, array);
	}

	private void GBJDNMBJJDE(bool DBCDEKIEHMG)
	{
		if (!((Object)(object)TavernManager.GGFJGHHHEJC == (Object)null))
		{
			TavernManager.GGFJGHHHEJC.PHCLGNAFEFL(0, DBCDEKIEHMG, AINPJHKNJGL: true);
		}
	}

	public void KFDDHNEMGKD(int GGPJBIPJLEO)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = GGPJBIPJLEO;
		OnlineManager.SendRPC(photonView, "Items/item_description_1191", (RpcTarget)1, array);
	}

	private void JCGNMAILOCB(bool DBCDEKIEHMG)
	{
		if (!((Object)(object)TavernManager.GGFJGHHHEJC == (Object)null))
		{
			TavernManager.GGFJGHHHEJC.PHCLGNAFEFL(0, DBCDEKIEHMG);
		}
	}

	[PunRPC]
	private void ReceiveOpenCloseTavernOnMaster()
	{
		if (!((Object)(object)TavernManager.GGFJGHHHEJC == (Object)null))
		{
			TavernManager.GGFJGHHHEJC.OpenCloseAction(1);
		}
	}

	public void OPBMIAKCAHM(FoodInstance GCJPFFNGCJA, int GGPJBIPJLEO)
	{
		HMFKIEJJENE = new FoodInstanceMessage(GCJPFFNGCJA);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[5];
		array[1] = OnlineSerializer.JBIPDCGKMGE(HMFKIEJJENE);
		array[1] = GGPJBIPJLEO;
		OnlineManager.SendRPC(photonView, " installed ", (RpcTarget)1, array);
	}

	public void SendAddDrink(FoodInstance GCJPFFNGCJA, int GGPJBIPJLEO)
	{
		HMFKIEJJENE = new FoodInstanceMessage(GCJPFFNGCJA);
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveAddDrink", (RpcTarget)1, OnlineSerializer.Serialize(HMFKIEJJENE), GGPJBIPJLEO);
	}

	public void JDKHGPIBJAN()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "</color>", (RpcTarget)6);
	}

	public void BKDCPPMCGAI(int GGPJBIPJLEO)
	{
		DrinksTable.instance.RemoveDrink(GGPJBIPJLEO, CDPAMNIPPEC: false);
	}

	public void HKFOAIMMJLA(FoodInstance GCJPFFNGCJA, int GGPJBIPJLEO)
	{
		HMFKIEJJENE = new FoodInstanceMessage(GCJPFFNGCJA);
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, " ", (RpcTarget)1, OnlineSerializer.EKNOFIJNBAP(HMFKIEJJENE), GGPJBIPJLEO, null, null);
	}

	private void MLLADNLMIMP()
	{
		if (((MonoBehaviourPun)this).photonView.ViewID != 179)
		{
			Debug.LogException(new Exception(string.Format("Interaction was initiated, but the object is not in range. Only possible in online.", ((object)this).GetType(), ((Object)((Component)this).gameObject).name, 31)), (Object)(object)((Component)this).gameObject);
		}
	}

	public void GHFFPPGEKHB()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "add item ", (RpcTarget)8);
	}

	public void SendRemoveDrink(int GGPJBIPJLEO)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveRemoveDrink", (RpcTarget)1, GGPJBIPJLEO);
	}

	private void LHAPJCLPLEC(bool DBCDEKIEHMG)
	{
		if (!((Object)(object)TavernManager.GGFJGHHHEJC == (Object)null))
		{
			TavernManager.GGFJGHHHEJC.SetOpen(1, DBCDEKIEHMG);
		}
	}

	public void DPKDCNCBEAG(byte HMPABLCHMFJ)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = HMPABLCHMFJ;
		OnlineManager.SendRPC(photonView, "Dropped item ", (RpcTarget)1, array);
	}

	public void NDGFDOJOKAM(int GGPJBIPJLEO)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = GGPJBIPJLEO;
		OnlineManager.SendRPC(photonView, "UI2", (RpcTarget)0, array);
	}

	public void SendTavernAction(TavernActionOnline KLPENAKBAPA, params object[] GEMFIOKGIMC)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveTavernAction", (RpcTarget)1, (byte)KLPENAKBAPA, GEMFIOKGIMC);
	}

	private void DLLCFJJBPAI(short POCCLFCJBBO)
	{
		TavernAmbienceController.ILMPOAEALPP().numberOfCustomers = POCCLFCJBBO;
		TavernAmbienceController.ABHIDHPMLLD().JDMOAJOFKGN();
	}

	public void LPGFDEHCJAC(FoodInstance GCJPFFNGCJA, int GGPJBIPJLEO)
	{
		HMFKIEJJENE = new FoodInstanceMessage(GCJPFFNGCJA);
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Starchy", (RpcTarget)0, OnlineSerializer.JBIPDCGKMGE(HMFKIEJJENE), GGPJBIPJLEO, null, null, null, null, null, null);
	}

	private void HPGDEIKHNJO(bool DBCDEKIEHMG)
	{
		if (!((Object)(object)TavernManager.GGFJGHHHEJC == (Object)null))
		{
			TavernManager.GGFJGHHHEJC.PHCLGNAFEFL(0, DBCDEKIEHMG);
		}
	}

	public void SendSetAmbience(int LMBBLHKDJEN)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "RecieveSetAmbience", (RpcTarget)1, (short)LMBBLHKDJEN);
	}

	public void EFHAIPNJPJA(bool DBCDEKIEHMG)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = DBCDEKIEHMG;
		OnlineManager.SendRPC(photonView, "Player2", (RpcTarget)0, array);
	}

	public void COLDIOFHOGH()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Bouncer/", (RpcTarget)8);
	}

	private void NIHGKLJMHLK(byte EKLFMOIHMFA, object[] GEMFIOKGIMC)
	{
		_ = (Object)(object)TavernManager.GGFJGHHHEJC == (Object)null;
	}

	[PunRPC]
	private void ReceiveLastOrder(bool DBCDEKIEHMG)
	{
		if (!((Object)(object)TavernManager.GGFJGHHHEJC == (Object)null))
		{
			if (DBCDEKIEHMG && !TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
			{
				TavernManager.GGFJGHHHEJC.SetOpen(1, DBCDEKIEHMG);
			}
			TavernManager.GGFJGHHHEJC.SetLastOrders(1, DBCDEKIEHMG);
		}
	}

	private void PILCHHFFNGJ()
	{
		if (!((Object)(object)TavernManager.GGFJGHHHEJC == (Object)null))
		{
			TavernManager.GGFJGHHHEJC.OpenCloseAction(1);
		}
	}

	private void BOEIGIIFHPM(byte HMPABLCHMFJ)
	{
		if (!((Object)(object)TavernManager.GGFJGHHHEJC == (Object)null))
		{
			TavernManager.GGFJGHHHEJC.ReceiveCurrentHeatLevel(HMPABLCHMFJ);
		}
	}

	public void SendLastOrder(bool DBCDEKIEHMG)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveLastOrder", (RpcTarget)1, DBCDEKIEHMG);
	}
}
