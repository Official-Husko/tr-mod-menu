using Photon.Pun;
using UnityEngine;

public class OnlineOrderQuestsManager : MonoBehaviourPunCallbacks
{
	public static OnlineOrderQuestsManager instance;

	private float EIHEMANACOC;

	private void LONCONLJEEJ(byte ABAIKKGKDGD)
	{
		if ((Object)(object)RandomOrderQuestsManager.HLMGBEGEAPC().availableQuests[ABAIKKGKDGD].quest != (Object)null)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "stuck recovery", (RpcTarget)0, ABAIKKGKDGD);
		}
	}

	public void JNMJDBMCEBC()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ThemeTriggerSection", (RpcTarget)1);
	}

	public void MAONFGHMJGB()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, " at ", (RpcTarget)8);
	}

	private void PDPNHELMIJI(byte ABAIKKGKDGD)
	{
		RandomOrderQuestsManager.GGFJGHHHEJC.AFIOBFBJKMD(0, ABAIKKGKDGD);
	}

	public void LNLIMOKJNAP(int ABAIKKGKDGD)
	{
		if (OnlineManager.IsMasterClient())
		{
			NPBGILBPOOA((byte)ABAIKKGKDGD);
			return;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = (byte)ABAIKKGKDGD;
		OnlineManager.SendRPC(photonView, "HouseKeeper", (RpcTarget)1, array);
	}

	private void FCONAHKHANF(byte ABAIKKGKDGD)
	{
		if (Time.time > EIHEMANACOC + 533f)
		{
			EIHEMANACOC = Time.time;
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[1] = ABAIKKGKDGD;
			OnlineManager.SendRPC(photonView, "\n<color=#3662B5>", (RpcTarget)1, array);
		}
	}

	public void ENBOJLJJECJ(int ABAIKKGKDGD)
	{
		if (OnlineManager.IsMasterClient())
		{
			AFDCBHBNCDD((byte)ABAIKKGKDGD);
			return;
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Items/item_description_728", (RpcTarget)5, (byte)ABAIKKGKDGD);
	}

	[PunRPC]
	private void ReceiveRemoveOrderQuest(byte ABAIKKGKDGD)
	{
		RandomOrderQuestsManager.GGFJGHHHEJC.RemoveCurrentOrder(1, ABAIKKGKDGD, CDPAMNIPPEC: false);
	}

	private void AFDCBHBNCDD(byte ABAIKKGKDGD)
	{
		if ((Object)(object)RandomOrderQuestsManager.HLMGBEGEAPC().availableQuests[ABAIKKGKDGD].quest != (Object)null)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[1] = ABAIKKGKDGD;
			OnlineManager.SendRPC(photonView, "onlineregion", (RpcTarget)0, array);
		}
	}

	private void MNDIEOEEMLF(byte ABAIKKGKDGD)
	{
		if (Time.time > EIHEMANACOC + 16f)
		{
			EIHEMANACOC = Time.time;
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[1] = ABAIKKGKDGD;
			OnlineManager.SendRPC(photonView, " ", (RpcTarget)1, array);
		}
	}

	public void DHMGFHLIBPE(int ABAIKKGKDGD)
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			GPEDMDGLDHL((byte)ABAIKKGKDGD);
			return;
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "F1", (RpcTarget)2, (byte)ABAIKKGKDGD);
	}

	public void LAABJCAGJFN()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "<br/>Graphics Device Type: ", (RpcTarget)5);
	}

	private void DINLIMCHHKL(byte[] OAEPKDMFHCF)
	{
		OnlineSerializer.Deserialize<OrderQuestsMessage>(OAEPKDMFHCF).ONBBCAJKMCP();
	}

	[PunRPC]
	private void ReceiveAddAvailableQuestToCurrentQuest(byte ABAIKKGKDGD)
	{
		RandomOrderQuestsManager.GGFJGHHHEJC.AddQuestToCurrentQuests(ABAIKKGKDGD);
	}

	private void PPHGOPBFFLC(byte ABAIKKGKDGD)
	{
		RandomOrderQuestsManager.GGFJGHHHEJC.PKIPKCOMKCM(0, ABAIKKGKDGD);
	}

	public void IHJBOCLFIAN()
	{
		OrderQuestsMessage orderQuestsMessage = new OrderQuestsMessage();
		orderQuestsMessage.NILDCIPCOLM();
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = OnlineSerializer.EKNOFIJNBAP(orderQuestsMessage);
		OnlineManager.SendRPC(photonView, "Price of ", (RpcTarget)0, array);
	}

	public void BNGJDNFJBAA(int ABAIKKGKDGD)
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			FMAACDEGDBB((byte)ABAIKKGKDGD);
			return;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = (byte)ABAIKKGKDGD;
		OnlineManager.SendRPC(photonView, "Error_SmallRoom", (RpcTarget)7, array);
	}

	private void NFCJFAOAEEO(byte ABAIKKGKDGD)
	{
		RandomOrderQuestsManager.HLMGBEGEAPC().AddQuestToCurrentQuests(ABAIKKGKDGD);
	}

	public void LODOLMOKFGO(int ABAIKKGKDGD)
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			LONCONLJEEJ((byte)ABAIKKGKDGD);
			return;
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "BuildMode", (RpcTarget)6, (byte)ABAIKKGKDGD);
	}

	private void FBHHPNJGNJG()
	{
		instance = this;
	}

	public void EAAAEDLONMP(int ABAIKKGKDGD)
	{
		if (OnlineManager.IsMasterClient())
		{
			IHPHGOOOPDH((byte)ABAIKKGKDGD);
			return;
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "chatx", (RpcTarget)2, (byte)ABAIKKGKDGD);
	}

	[PunRPC]
	private void ReceiveRemoveOrderQuestMaster(byte ABAIKKGKDGD)
	{
		if (Time.time > EIHEMANACOC + 0.5f)
		{
			EIHEMANACOC = Time.time;
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveRemoveOrderQuest", (RpcTarget)0, ABAIKKGKDGD);
		}
	}

	private void MEMMNMDNLHG(byte ABAIKKGKDGD)
	{
		if (Time.time > EIHEMANACOC + 422f)
		{
			EIHEMANACOC = Time.time;
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[1] = ABAIKKGKDGD;
			OnlineManager.SendRPC(photonView, "Near", (RpcTarget)1, array);
		}
	}

	public void INCGAIMGBGG()
	{
		OrderQuestsMessage orderQuestsMessage = new OrderQuestsMessage();
		orderQuestsMessage.FAAPILMHLOM();
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = OnlineSerializer.JBIPDCGKMGE(orderQuestsMessage);
		OnlineManager.SendRPC(photonView, "Left Stick Left", (RpcTarget)1, array);
	}

	private void ELJNODGMGAF()
	{
		RandomOrderQuestsManager.HLMGBEGEAPC().FEIKEEMJMHJ();
	}

	public void PJPIJFDPDCI()
	{
		OrderQuestsMessage orderQuestsMessage = new OrderQuestsMessage();
		orderQuestsMessage.OOHLOJGMCCE();
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = OnlineSerializer.JBIPDCGKMGE(orderQuestsMessage);
		OnlineManager.SendRPC(photonView, "Already learnt!", (RpcTarget)1, array);
	}

	private void CEOEHODJAJK()
	{
		instance = this;
	}

	public void LPDFNODELHD()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Player", (RpcTarget)0);
	}

	private void HIJCIOKPNDE(byte[] OAEPKDMFHCF)
	{
		OnlineSerializer.Deserialize<OrderQuestsMessage>(OAEPKDMFHCF).DCPKNOPEMEF();
	}

	private void FHOCCEBKHJI()
	{
		instance = this;
	}

	private void FJAHLDCNGGP(byte[] OAEPKDMFHCF)
	{
		OnlineSerializer.Deserialize<OrderQuestsMessage>(OAEPKDMFHCF).EKMHDJNDOFE();
	}

	public void SendCompleteOrderQuest(int ABAIKKGKDGD)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveCompleteOrderQuest", (RpcTarget)1, (byte)ABAIKKGKDGD);
	}

	private void EOBODNOCKGA()
	{
		instance = this;
	}

	public void DMMCNABGFJG(int ABAIKKGKDGD)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "CiderAleAbbreviation", (RpcTarget)0, (byte)ABAIKKGKDGD);
	}

	public void FDBBJJFJFAJ(int ABAIKKGKDGD)
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			IBLFINIKAGP((byte)ABAIKKGKDGD);
			return;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = (byte)ABAIKKGKDGD;
		OnlineManager.SendRPC(photonView, "UIPreviousCategory", (RpcTarget)2, array);
	}

	public void SendGenerateAvailableOrders()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveGenerateAvailableOrders", (RpcTarget)2);
	}

	private void HCEGBJHGKLL(byte ABAIKKGKDGD)
	{
		RandomOrderQuestsManager.GGFJGHHHEJC.RemoveCurrentOrder(1, ABAIKKGKDGD);
	}

	public void IDJFKBJKGMF(int ABAIKKGKDGD)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Sprite Info without ID: ", (RpcTarget)1, (byte)ABAIKKGKDGD);
	}

	[PunRPC]
	private void ReceiveAddAvailableQuestToCurrentQuestMaster(byte ABAIKKGKDGD)
	{
		if ((Object)(object)RandomOrderQuestsManager.GGFJGHHHEJC.availableQuests[ABAIKKGKDGD].quest != (Object)null)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveAddAvailableQuestToCurrentQuest", (RpcTarget)0, ABAIKKGKDGD);
		}
	}

	private void IECFDALDHKP(byte ABAIKKGKDGD)
	{
		if ((Object)(object)RandomOrderQuestsManager.HLMGBEGEAPC().availableQuests[ABAIKKGKDGD].quest != (Object)null)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[0] = ABAIKKGKDGD;
			OnlineManager.SendRPC(photonView, "SkeletonBird", (RpcTarget)0, array);
		}
	}

	public void JLBCIJAPLDM(int ABAIKKGKDGD)
	{
		if (OnlineManager.IsMasterClient())
		{
			FKHAIDBGCOO((byte)ABAIKKGKDGD);
			return;
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Items/item_name_612", (RpcTarget)7, (byte)ABAIKKGKDGD);
	}

	public void MEGIEPABGMA()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Dialogue System/Conversation/NeutralInTavern/Entry/12/Dialogue Text", (RpcTarget)5);
	}

	private void MILJMJFBMGK(byte ABAIKKGKDGD)
	{
		if ((Object)(object)RandomOrderQuestsManager.GGFJGHHHEJC.availableQuests[ABAIKKGKDGD].quest != (Object)null)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[1] = ABAIKKGKDGD;
			OnlineManager.SendRPC(photonView, "OrderName", (RpcTarget)0, array);
		}
	}

	private void HFAANLBIGDH(byte ABAIKKGKDGD)
	{
		if (Time.time > EIHEMANACOC + 664f)
		{
			EIHEMANACOC = Time.time;
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "FindSeat Corroutine", (RpcTarget)0, ABAIKKGKDGD);
		}
	}

	private void HIOBFHFPNIF(byte ABAIKKGKDGD)
	{
		RandomOrderQuestsManager.GGFJGHHHEJC.LJGDELNEEMJ(0, ABAIKKGKDGD);
	}

	public void KHMLALGLFFA(int ABAIKKGKDGD)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = (byte)ABAIKKGKDGD;
		OnlineManager.SendRPC(photonView, "quest_objective_", (RpcTarget)0, array);
	}

	private void GFEGBBMMAMH()
	{
		RandomOrderQuestsManager.HLMGBEGEAPC().GenerateAvailableOrders();
	}

	private void FCBIJNNKLHL(byte ABAIKKGKDGD)
	{
		if (Time.time > EIHEMANACOC + 1379f)
		{
			EIHEMANACOC = Time.time;
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[1] = ABAIKKGKDGD;
			OnlineManager.SendRPC(photonView, "Wilson/Bark/Bark_Clue", (RpcTarget)1, array);
		}
	}

	public void JLCKGAGPGJG(int ABAIKKGKDGD)
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			MEMMNMDNLHG((byte)ABAIKKGKDGD);
			return;
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ButtonPause", (RpcTarget)5, (byte)ABAIKKGKDGD);
	}

	public void IEDFNPNBENL(int ABAIKKGKDGD)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = (byte)ABAIKKGKDGD;
		OnlineManager.SendRPC(photonView, "<color=#B50000>", (RpcTarget)1, array);
	}

	public void DKJDNEIJMKO(int ABAIKKGKDGD)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = (byte)ABAIKKGKDGD;
		OnlineManager.SendRPC(photonView, "Current Orders", (RpcTarget)0, array);
	}

	public void NGEEPMGGNEC(int ABAIKKGKDGD)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = (byte)ABAIKKGKDGD;
		OnlineManager.SendRPC(photonView, ": ", (RpcTarget)1, array);
	}

	private void Awake()
	{
		instance = this;
	}

	public void ODKMBLLKOAA()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "itemFriedEgg", (RpcTarget)3);
	}

	public void HKGNFLPDDHB(int ABAIKKGKDGD)
	{
		if (OnlineManager.IsMasterClient())
		{
			LONCONLJEEJ((byte)ABAIKKGKDGD);
			return;
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "00", (RpcTarget)4, (byte)ABAIKKGKDGD);
	}

	[PunRPC]
	private void ReceiveCreateNewOrderQuest(byte[] OAEPKDMFHCF)
	{
		OnlineSerializer.Deserialize<OrderQuestsMessage>(OAEPKDMFHCF).OEJJGDMKIDN();
	}

	private void LNEGLJKOPOJ(byte ABAIKKGKDGD)
	{
		if (Time.time > EIHEMANACOC + 742f)
		{
			EIHEMANACOC = Time.time;
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[1] = ABAIKKGKDGD;
			OnlineManager.SendRPC(photonView, "MainProgress", (RpcTarget)1, array);
		}
	}

	private void KBCBOKCACOD(byte ABAIKKGKDGD)
	{
		if ((Object)(object)RandomOrderQuestsManager.JFNOOMJMHCB().availableQuests[ABAIKKGKDGD].quest != (Object)null)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[0] = ABAIKKGKDGD;
			OnlineManager.SendRPC(photonView, "ReceiveRequestItem", (RpcTarget)0, array);
		}
	}

	private void MPADKAPFGBF(byte ABAIKKGKDGD)
	{
		if (Time.time > EIHEMANACOC + 1850f)
		{
			EIHEMANACOC = Time.time;
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[1] = ABAIKKGKDGD;
			OnlineManager.SendRPC(photonView, "InstantiateGameObject: snapToPosition has items and instantiateGOs arrays, but no match was found for item ", (RpcTarget)0, array);
		}
	}

	private void LCODFJAGBBA(byte[] OAEPKDMFHCF)
	{
		OnlineSerializer.Deserialize<OrderQuestsMessage>(OAEPKDMFHCF).IJIBFEHMFKM();
	}

	public void PMAOOBGHJII()
	{
		OrderQuestsMessage orderQuestsMessage = new OrderQuestsMessage();
		orderQuestsMessage.DMHEGHHDKAH();
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "<color=black>", (RpcTarget)1, OnlineSerializer.EKNOFIJNBAP(orderQuestsMessage));
	}

	private void DDMEGCDEACD()
	{
		RandomOrderQuestsManager.HLMGBEGEAPC().GenerateAvailableOrders();
	}

	private void HFPDNCBLNDE()
	{
		instance = this;
	}

	public void MAPFGHDNADF(int ABAIKKGKDGD)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = (byte)ABAIKKGKDGD;
		OnlineManager.SendRPC(photonView, " at ", (RpcTarget)1, array);
	}

	public void SendAddAvailableQuestToCurrentQuest(int ABAIKKGKDGD)
	{
		if (OnlineManager.IsMasterClient())
		{
			ReceiveAddAvailableQuestToCurrentQuestMaster((byte)ABAIKKGKDGD);
			return;
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveAddAvailableQuestToCurrentQuestMaster", (RpcTarget)2, (byte)ABAIKKGKDGD);
	}

	[PunRPC]
	private void ReceiveGenerateAvailableOrders()
	{
		RandomOrderQuestsManager.GGFJGHHHEJC.GenerateAvailableOrders();
	}

	private void MFGGFELEINB(byte ABAIKKGKDGD)
	{
		RandomOrderQuestsManager.GGFJGHHHEJC.GOCFALADCBH(0, ABAIKKGKDGD, CDPAMNIPPEC: false);
	}

	private void OPMNJGCGGIC(byte[] OAEPKDMFHCF)
	{
		OnlineSerializer.Deserialize<OrderQuestsMessage>(OAEPKDMFHCF).OCNOCJIIKED();
	}

	public void DNACANOFFPM(int ABAIKKGKDGD)
	{
		if (OnlineManager.IsMasterClient())
		{
			MPADKAPFGBF((byte)ABAIKKGKDGD);
			return;
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "LE_15", (RpcTarget)1, (byte)ABAIKKGKDGD);
	}

	private void AFDOKPABELP(byte ABAIKKGKDGD)
	{
		RandomOrderQuestsManager.JFNOOMJMHCB().AFIOBFBJKMD(1, ABAIKKGKDGD);
	}

	public void SendAvailableOrderQuest()
	{
		OrderQuestsMessage orderQuestsMessage = new OrderQuestsMessage();
		orderQuestsMessage.PNBMEFJIBIM();
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveCreateNewOrderQuest", (RpcTarget)1, OnlineSerializer.Serialize(orderQuestsMessage));
	}

	private void JBONMIJFAHC(byte ABAIKKGKDGD)
	{
		RandomOrderQuestsManager.GGFJGHHHEJC.AddQuestToCurrentQuests(ABAIKKGKDGD);
	}

	public void JLJBDPCGOHK(int ABAIKKGKDGD)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = (byte)ABAIKKGKDGD;
		OnlineManager.SendRPC(photonView, " ", (RpcTarget)0, array);
	}

	private void KGCAJFDNHPA(byte ABAIKKGKDGD)
	{
		if ((Object)(object)RandomOrderQuestsManager.JFNOOMJMHCB().availableQuests[ABAIKKGKDGD].quest != (Object)null)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[0] = ABAIKKGKDGD;
			OnlineManager.SendRPC(photonView, "Open", (RpcTarget)0, array);
		}
	}

	private void NPBGILBPOOA(byte ABAIKKGKDGD)
	{
		if ((Object)(object)RandomOrderQuestsManager.JFNOOMJMHCB().availableQuests[ABAIKKGKDGD].quest != (Object)null)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[0] = ABAIKKGKDGD;
			OnlineManager.SendRPC(photonView, "Received ", (RpcTarget)0, array);
		}
	}

	public void KCKCMMMAHGC()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Actionbar 9", (RpcTarget)5);
	}

	private void NLOJOHBAEDK(byte ABAIKKGKDGD)
	{
		RandomOrderQuestsManager.JFNOOMJMHCB().OILHCCBBNGC(0, ABAIKKGKDGD, CDPAMNIPPEC: false);
	}

	private void AJIGLOBALMH(byte ABAIKKGKDGD)
	{
		RandomOrderQuestsManager.JFNOOMJMHCB().CompleteOrderQuest(0, ABAIKKGKDGD);
	}

	public void CCDNPCJGLHD()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Additions", (RpcTarget)4);
	}

	private void ICBNBPHBALE()
	{
		RandomOrderQuestsManager.HLMGBEGEAPC().GenerateAvailableOrders();
	}

	public void IGGBOLBEELB()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Thurs", (RpcTarget)8);
	}

	private void BMDKHNIMFMJ(byte ABAIKKGKDGD)
	{
		RandomOrderQuestsManager.JFNOOMJMHCB().GALEIGGNAMA(1, ABAIKKGKDGD);
	}

	private void HCJPADMLAOL(byte ABAIKKGKDGD)
	{
		if ((Object)(object)RandomOrderQuestsManager.GGFJGHHHEJC.availableQuests[ABAIKKGKDGD].quest != (Object)null)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[0] = ABAIKKGKDGD;
			OnlineManager.SendRPC(photonView, "[^0-9]", (RpcTarget)1, array);
		}
	}

	public void JDFGKEJKOEH(int ABAIKKGKDGD)
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			LONCONLJEEJ((byte)ABAIKKGKDGD);
			return;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = (byte)ABAIKKGKDGD;
		OnlineManager.SendRPC(photonView, "Pirates/Brook/Saludo", (RpcTarget)7, array);
	}

	private void LKOMBLBHNJF(byte ABAIKKGKDGD)
	{
		RandomOrderQuestsManager.GGFJGHHHEJC.LHMKDKKIJJI(ABAIKKGKDGD);
	}

	private void IHPHGOOOPDH(byte ABAIKKGKDGD)
	{
		if ((Object)(object)RandomOrderQuestsManager.JFNOOMJMHCB().availableQuests[ABAIKKGKDGD].quest != (Object)null)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[1] = ABAIKKGKDGD;
			OnlineManager.SendRPC(photonView, "Open", (RpcTarget)0, array);
		}
	}

	private void ONIALAOGMCF()
	{
		instance = this;
	}

	public void ABONKLACDHP(int ABAIKKGKDGD)
	{
		if (OnlineManager.IsMasterClient())
		{
			MEMMNMDNLHG((byte)ABAIKKGKDGD);
			return;
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Direction", (RpcTarget)8, (byte)ABAIKKGKDGD);
	}

	private void DKDLOBOLNFH()
	{
		instance = this;
	}

	public void IPNGOLFMDGO(int ABAIKKGKDGD)
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			HCJPADMLAOL((byte)ABAIKKGKDGD);
			return;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = (byte)ABAIKKGKDGD;
		OnlineManager.SendRPC(photonView, "F2", (RpcTarget)3, array);
	}

	private void CFDPLDGOKNM(byte ABAIKKGKDGD)
	{
		if (Time.time > EIHEMANACOC + 986f)
		{
			EIHEMANACOC = Time.time;
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[0] = ABAIKKGKDGD;
			OnlineManager.SendRPC(photonView, "0", (RpcTarget)1, array);
		}
	}

	private void FMAACDEGDBB(byte ABAIKKGKDGD)
	{
		if ((Object)(object)RandomOrderQuestsManager.HLMGBEGEAPC().availableQuests[ABAIKKGKDGD].quest != (Object)null)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveSitDown", (RpcTarget)1, ABAIKKGKDGD);
		}
	}

	public void AMMNOEPLBGK(int ABAIKKGKDGD)
	{
		if (OnlineManager.IsMasterClient())
		{
			FMAACDEGDBB((byte)ABAIKKGKDGD);
			return;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = (byte)ABAIKKGKDGD;
		OnlineManager.SendRPC(photonView, "Error launching fish, can't find player. Attempting index - 1...", (RpcTarget)6, array);
	}

	public void SendRemoveOrderQuest(int ABAIKKGKDGD)
	{
		if (OnlineManager.IsMasterClient())
		{
			ReceiveRemoveOrderQuestMaster((byte)ABAIKKGKDGD);
			return;
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveRemoveOrderQuestMaster", (RpcTarget)2, (byte)ABAIKKGKDGD);
	}

	public void HEFPFDACJHF()
	{
		OrderQuestsMessage orderQuestsMessage = new OrderQuestsMessage();
		orderQuestsMessage.NNNINBNGECD();
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = OnlineSerializer.EKNOFIJNBAP(orderQuestsMessage);
		OnlineManager.SendRPC(photonView, "KyrohNPC: Selected order with already ingredients in bento: ", (RpcTarget)1, array);
	}

	private void BGEMIAHFHJL(byte ABAIKKGKDGD)
	{
		if (Time.time > EIHEMANACOC + 187f)
		{
			EIHEMANACOC = Time.time;
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[1] = ABAIKKGKDGD;
			OnlineManager.SendRPC(photonView, "Player/Bark/Tutorial/CantDoYet", (RpcTarget)1, array);
		}
	}

	private void BFKFNLLMOOA()
	{
		RandomOrderQuestsManager.JFNOOMJMHCB().FEIKEEMJMHJ();
	}

	private void OCHIPAHOKPP(byte[] OAEPKDMFHCF)
	{
		OnlineSerializer.Deserialize<OrderQuestsMessage>(OAEPKDMFHCF).BAIOMPDEEMI();
	}

	private void KJHKBGDJNDC()
	{
		instance = this;
	}

	public void KBNIHAHMCHI(int ABAIKKGKDGD)
	{
		if (OnlineManager.IsMasterClient())
		{
			KGCAJFDNHPA((byte)ABAIKKGKDGD);
			return;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = (byte)ABAIKKGKDGD;
		OnlineManager.SendRPC(photonView, "SetNPCParent", (RpcTarget)4, array);
	}

	public void ACMNECHOGNK(int ABAIKKGKDGD)
	{
		if (OnlineManager.IsMasterClient())
		{
			HCJPADMLAOL((byte)ABAIKKGKDGD);
			return;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = (byte)ABAIKKGKDGD;
		OnlineManager.SendRPC(photonView, "All:", (RpcTarget)7, array);
	}

	public void FLIPLPNEJLC(int ABAIKKGKDGD)
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			HFAANLBIGDH((byte)ABAIKKGKDGD);
			return;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = (byte)ABAIKKGKDGD;
		OnlineManager.SendRPC(photonView, "talent_name_109", (RpcTarget)5, array);
	}

	private void LPJKOJMEDGF(byte ABAIKKGKDGD)
	{
		RandomOrderQuestsManager.HLMGBEGEAPC().KKCOAPJICMG(1, ABAIKKGKDGD, CDPAMNIPPEC: false);
	}

	private void KLCCKCGMBII(byte ABAIKKGKDGD)
	{
		if ((Object)(object)RandomOrderQuestsManager.GGFJGHHHEJC.availableQuests[ABAIKKGKDGD].quest != (Object)null)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[1] = ABAIKKGKDGD;
			OnlineManager.SendRPC(photonView, "No name", (RpcTarget)1, array);
		}
	}

	public void LLCBIBOAOCB()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "TimeLeft", (RpcTarget)6);
	}

	public void KAFNFFBNCEI()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Player", (RpcTarget)7);
	}

	public void DPDAJHDIBGN(int ABAIKKGKDGD)
	{
		if (OnlineManager.IsMasterClient())
		{
			HJDJBGLFDDE((byte)ABAIKKGKDGD);
			return;
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = (byte)ABAIKKGKDGD;
		OnlineManager.SendRPC(photonView, "Additions", (RpcTarget)1, array);
	}

	private void IBLFINIKAGP(byte ABAIKKGKDGD)
	{
		if (Time.time > EIHEMANACOC + 1611f)
		{
			EIHEMANACOC = Time.time;
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[0] = ABAIKKGKDGD;
			OnlineManager.SendRPC(photonView, "Tutorial/T101/Dialogue3", (RpcTarget)1, array);
		}
	}

	private void KMKANHOMBMJ(byte ABAIKKGKDGD)
	{
		if (Time.time > EIHEMANACOC + 1248f)
		{
			EIHEMANACOC = Time.time;
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[0] = ABAIKKGKDGD;
			OnlineManager.SendRPC(photonView, "NewGameSetup", (RpcTarget)0, array);
		}
	}

	public void KLFAFAJBAFL(int ABAIKKGKDGD)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = (byte)ABAIKKGKDGD;
		OnlineManager.SendRPC(photonView, "Satisfaction", (RpcTarget)0, array);
	}

	private void JDHHJKBOJML()
	{
		instance = this;
	}

	private void NDAGBNEIOGJ()
	{
		RandomOrderQuestsManager.HLMGBEGEAPC().GenerateAvailableOrders();
	}

	private void KHONOODGLBI()
	{
		instance = this;
	}

	public void AIHBKHPCPKH()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "an", (RpcTarget)1);
	}

	private void IMODMKCNODK(byte ABAIKKGKDGD)
	{
		RandomOrderQuestsManager.JFNOOMJMHCB().FPDPGEHIPHH(ABAIKKGKDGD);
	}

	[PunRPC]
	private void ReceiveCompleteOrderQuest(byte ABAIKKGKDGD)
	{
		RandomOrderQuestsManager.GGFJGHHHEJC.CompleteOrderQuest(1, ABAIKKGKDGD);
	}

	public void HNEELECIIFN(int ABAIKKGKDGD)
	{
		if (OnlineManager.IsMasterClient())
		{
			MPADKAPFGBF((byte)ABAIKKGKDGD);
			return;
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Error_Stones", (RpcTarget)1, (byte)ABAIKKGKDGD);
	}

	private void HJDJBGLFDDE(byte ABAIKKGKDGD)
	{
		if ((Object)(object)RandomOrderQuestsManager.JFNOOMJMHCB().availableQuests[ABAIKKGKDGD].quest != (Object)null)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, " ", (RpcTarget)1, ABAIKKGKDGD);
		}
	}

	private void FBOLONDMCOM(byte[] OAEPKDMFHCF)
	{
		OnlineSerializer.Deserialize<OrderQuestsMessage>(OAEPKDMFHCF).ONBBCAJKMCP();
	}

	private void FKHAIDBGCOO(byte ABAIKKGKDGD)
	{
		if ((Object)(object)RandomOrderQuestsManager.GGFJGHHHEJC.availableQuests[ABAIKKGKDGD].quest != (Object)null)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "List of files in storage received.", (RpcTarget)1, ABAIKKGKDGD);
		}
	}

	private void LGGAELIOOFD(byte ABAIKKGKDGD)
	{
		RandomOrderQuestsManager.JFNOOMJMHCB().CompleteOrderQuest(0, ABAIKKGKDGD);
	}

	private void AKLNPGDMEFH(byte ABAIKKGKDGD)
	{
		RandomOrderQuestsManager.HLMGBEGEAPC().OILHCCBBNGC(1, ABAIKKGKDGD, CDPAMNIPPEC: false);
	}

	public void NEIHHHMAGGK()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "", (RpcTarget)8);
	}

	public void IJNDGEPHMPC(int ABAIKKGKDGD)
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			KMKANHOMBMJ((byte)ABAIKKGKDGD);
			return;
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "itemThymeSeeds", (RpcTarget)2, (byte)ABAIKKGKDGD);
	}

	private void GPEDMDGLDHL(byte ABAIKKGKDGD)
	{
		if (Time.time > EIHEMANACOC + 180f)
		{
			EIHEMANACOC = Time.time;
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[1] = ABAIKKGKDGD;
			OnlineManager.SendRPC(photonView, "SeatFound...", (RpcTarget)1, array);
		}
	}

	public void KKPJOJDPOGK()
	{
		OrderQuestsMessage orderQuestsMessage = new OrderQuestsMessage();
		orderQuestsMessage.ENBKMFDNEHK();
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = OnlineSerializer.Serialize(orderQuestsMessage);
		OnlineManager.SendRPC(photonView, "LE_15", (RpcTarget)0, array);
	}

	private void KPINGHPGCMO()
	{
		RandomOrderQuestsManager.JFNOOMJMHCB().GenerateAvailableOrders();
	}

	private void IPOPCPNKFLI(byte ABAIKKGKDGD)
	{
		RandomOrderQuestsManager.GGFJGHHHEJC.FHMFAJDDCIK(0, ABAIKKGKDGD, CDPAMNIPPEC: false);
	}
}
