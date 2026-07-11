using System.Collections.Generic;
using System.Linq;
using Photon.Pun;
using Sirenix.Utilities;
using UnityEngine;

public class OnlineNinjaManager : MonoBehaviourPunCallbacks
{
	public static OnlineNinjaManager instance;

	public void IHJANLAHPAJ(int[] EBFDPBLGGPC)
	{
		NinjaFoodTablesManager.instance.GKOKFNOHHNH(EBFDPBLGGPC, CDPAMNIPPEC: true);
	}

	public void FHINICBMGFG(int JJCLJKMIMBH)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Player2", (RpcTarget)1, (byte)JJCLJKMIMBH);
	}

	[PunRPC]
	public void ReceiveOrderRequestNinjaCustomer(byte JJCLJKMIMBH, int[] CAHDMAALOJL, int[] HAALFBGCOJB)
	{
		Item[] pHNKKAHPIAO = CAHDMAALOJL.Select((int x) => ItemDatabaseAccessor.GetItem(x)).ToArray();
		NinjaOrdersManager.instance.customers[JJCLJKMIMBH].RequestTableOrder(pHNKKAHPIAO, HAALFBGCOJB);
	}

	private void DALLEMALDIK()
	{
		KyrohNPC.KFGKCKCDMLG().KKBBBGEMMCA();
	}

	public void FCLANEEAIOG(int[] EBFDPBLGGPC)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = EBFDPBLGGPC;
		OnlineManager.SendRPC(photonView, "Hole harvested with spade level ", (RpcTarget)1, array);
	}

	public void SendSwitchFoodAtTables(int[] AGBAAJFOMOA, int[] EBFDPBLGGPC)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveSwitchFoodAtTables", (RpcTarget)1, AGBAAJFOMOA, EBFDPBLGGPC);
	}

	public void JFIIAHDADIH(int[] EBFDPBLGGPC)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = EBFDPBLGGPC;
		OnlineManager.SendRPC(photonView, "Init failed for reason ", (RpcTarget)1, array);
	}

	[PunRPC]
	public void ReceiveRemoveOrderNinjaCustomer(byte JJCLJKMIMBH)
	{
		NinjaOrdersManager.instance.customers[JJCLJKMIMBH].RemoveOrder();
	}

	public void PEKIKMMEDPK(int[] EBFDPBLGGPC)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = EBFDPBLGGPC;
		OnlineManager.SendRPC(photonView, "Player/Bark/Tutorial/CrafterBlock", (RpcTarget)0, array);
	}

	public void FAEGJDLLNEE(int[] AFECMCLFIPH)
	{
		if (AFECMCLFIPH.Length != 0)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[1] = AFECMCLFIPH;
			OnlineManager.SendRPC(photonView, "MainProgress", (RpcTarget)1, array);
		}
	}

	private void JDJNEIKCJBK()
	{
		KyrohNPC.JFNOOMJMHCB().CJALDIHJDGC();
	}

	public void BMNJBDCJBPJ(byte GJDMLMEMKMD, int MNBNGGHHMBB)
	{
		NinjaPreparationTablesManager.instance.preparationTables[GJDMLMEMKMD].OFCPMCGCNHN(ItemDatabaseAccessor.CPMMBEPEJLO(MNBNGGHHMBB, GGBBJNBBLMF: true, DAINLFIMLIH: false), CDPAMNIPPEC: true);
	}

	public void SendNinjaSoundPreparation()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveNinjaSoundPreparation", (RpcTarget)1);
	}

	[PunRPC]
	public void ReceiveSwitchFoodAtTables(int[] AGBAAJFOMOA, int[] EBFDPBLGGPC)
	{
		NinjaFoodTablesManager.instance.ReceiveSwitchFood(AGBAAJFOMOA, EBFDPBLGGPC);
	}

	public void PJEFPLFLHFM(int GJDMLMEMKMD)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Sending ", (RpcTarget)0, (byte)GJDMLMEMKMD);
	}

	public void CDINEICGCMK(int[] AFECMCLFIPH)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < AFECMCLFIPH.Length; i++)
		{
			Vector2 val = Vector2.op_Implicit(NinjaRoundsManager.instance.slowingSpikesPositions[AFECMCLFIPH[i]].position);
			Object.Instantiate<SlowingSpikes>(NinjaRoundsManager.instance.slowingSpikePrefab, Vector2.op_Implicit(val), Quaternion.identity);
		}
	}

	private void DDLCKMKOOBO()
	{
		NinjaChallenge.StartChallengeEvent();
	}

	public void SendCompleteServeNinjaCustomer(int JJOBHKDKGHB, Item[] MIJANIALBBL, bool FDMHEDDIGPJ)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveCompleteServeNinjaCustomer", (RpcTarget)2, (byte)JJOBHKDKGHB, MIJANIALBBL.Select((Item x) => x.JDJGFAACPFC()).ToArray(), FDMHEDDIGPJ, (byte)Bed.instance.numInstance);
	}

	public void MDNHJELDDKP(int[] AGBAAJFOMOA, int[] EBFDPBLGGPC)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, " not found. Can no instantiate online placeable", (RpcTarget)0, AGBAAJFOMOA, EBFDPBLGGPC, null, null, null, null, null);
	}

	public void EAGBJCPGHPP(int GJDMLMEMKMD, Item MEMGMDOCBOJ)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Tree", (RpcTarget)1, (byte)GJDMLMEMKMD, MEMGMDOCBOJ.JDJGFAACPFC(), null, null, null, null, null, null);
	}

	public void DMGOJHNBBFC(int[] EBFDPBLGGPC)
	{
		NinjaFoodTablesManager.instance.SetFoodTablesIDs(EBFDPBLGGPC, CDPAMNIPPEC: false);
	}

	private void KMDDIGGHMJO()
	{
		KyrohNPC.AGGAGCBAGLL().GKPMOABPBGL();
	}

	[PunRPC]
	private void ReceiveStartNinjaChallenge()
	{
		NinjaChallenge.StartChallengeEvent(CDPAMNIPPEC: false);
	}

	public void SendRequestOrderNinjaCustomer(int JJCLJKMIMBH, Item[] ANJJPJICLDA, int[] HAALFBGCOJB)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveOrderRequestNinjaCustomer", (RpcTarget)1, (byte)JJCLJKMIMBH, ANJJPJICLDA.Select((Item x) => x.JDJGFAACPFC()).ToArray(), HAALFBGCOJB);
	}

	public void NJBOEMEJGDN()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, " ", (RpcTarget)1);
	}

	private void Awake()
	{
		instance = this;
	}

	public void DAGHIGKAFDH(int[] AGBAAJFOMOA, int[] EBFDPBLGGPC)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Error al crear blackModulesParent", (RpcTarget)0, AGBAAJFOMOA, EBFDPBLGGPC, null, null);
	}

	public void KKAJJPBLPIM(byte JJCLJKMIMBH, int[] CAHDMAALOJL, int[] HAALFBGCOJB)
	{
		Item[] pHNKKAHPIAO = CAHDMAALOJL.Select((int x) => ItemDatabaseAccessor.GetItem(x)).ToArray();
		NinjaOrdersManager.instance.customers[JJCLJKMIMBH].AJBMKOKEPEE(pHNKKAHPIAO, HAALFBGCOJB);
	}

	private void ENGNGNOLFAC()
	{
		NinjaChallenge.StartChallengeEvent(CDPAMNIPPEC: false);
	}

	public void OADKABKFLJB(int JJCLJKMIMBH, Item[] ANJJPJICLDA, int[] HAALFBGCOJB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[8];
		array[0] = (byte)JJCLJKMIMBH;
		array[0] = ANJJPJICLDA.Select((Item x) => x.JDJGFAACPFC()).ToArray();
		array[8] = HAALFBGCOJB;
		OnlineManager.SendRPC(photonView, "Leave immediately", (RpcTarget)0, array);
	}

	public void KEHNDPJGGGK(int JJOBHKDKGHB, Item[] MIJANIALBBL, bool FDMHEDDIGPJ)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[8];
		array[1] = (byte)JJOBHKDKGHB;
		array[1] = MIJANIALBBL.Select((Item x) => x.JDJGFAACPFC()).ToArray();
		array[1] = FDMHEDDIGPJ;
		array[4] = (byte)Bed.instance.numInstance;
		OnlineManager.SendRPC(photonView, "itemTurnip", (RpcTarget)7, array);
	}

	[PunRPC]
	public void ReceiveSyncFoodTables(int[] EBFDPBLGGPC)
	{
		NinjaFoodTablesManager.instance.SetFoodTablesIDs(EBFDPBLGGPC, CDPAMNIPPEC: false);
	}

	public void KKABMBEEKNK(int[] AGBAAJFOMOA, int[] EBFDPBLGGPC)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[4];
		array[1] = AGBAAJFOMOA;
		array[0] = EBFDPBLGGPC;
		OnlineManager.SendRPC(photonView, "player2ToDisconnectFromGame", (RpcTarget)0, array);
	}

	public void KJKOLFLKAEH()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "RecalculatingAllWallTiles (ONLINE) [client]", (RpcTarget)1);
	}

	public void NDICLFDHOKP()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "FloorTiles", (RpcTarget)0);
	}

	public void NJLGGCNKLPO(int[] EBFDPBLGGPC)
	{
		NinjaFoodTablesManager.instance.MKAEANAFFPD(EBFDPBLGGPC, CDPAMNIPPEC: false);
	}

	public void OCMHFMALDAE(int JJCLJKMIMBH, Item[] ANJJPJICLDA, int[] HAALFBGCOJB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[3];
		array[0] = (byte)JJCLJKMIMBH;
		array[0] = ANJJPJICLDA.Select((Item x) => x.JDJGFAACPFC()).ToArray();
		array[2] = HAALFBGCOJB;
		OnlineManager.SendRPC(photonView, "Player", (RpcTarget)0, array);
	}

	public void AHOKFPJHFBK(int JJOBHKDKGHB, Item[] MIJANIALBBL, bool FDMHEDDIGPJ)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[0] = (byte)JJOBHKDKGHB;
		array[1] = MIJANIALBBL.Select((Item x) => x.JDJGFAACPFC()).ToArray();
		array[6] = FDMHEDDIGPJ;
		array[1] = (byte)Bed.instance.numInstance;
		OnlineManager.SendRPC(photonView, "Items/item_description_734", (RpcTarget)4, array);
	}

	public void CCNLMJCBKKN(int GJDMLMEMKMD, Item MEMGMDOCBOJ)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = (byte)GJDMLMEMKMD;
		array[1] = MEMGMDOCBOJ.JDJGFAACPFC();
		OnlineManager.SendRPC(photonView, "SendStatus", (RpcTarget)0, array);
	}

	private void MJHAIDKIKDA()
	{
		KyrohNPC.AGGAGCBAGLL().DIJJHPGCAHG();
	}

	[PunRPC]
	public void ReceiveThrowSlowingSpikes(int[] AFECMCLFIPH)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < AFECMCLFIPH.Length; i++)
		{
			Vector2 val = Vector2.op_Implicit(NinjaRoundsManager.instance.slowingSpikesPositions[AFECMCLFIPH[i]].position);
			Object.Instantiate<SlowingSpikes>(NinjaRoundsManager.instance.slowingSpikePrefab, Vector2.op_Implicit(val), Quaternion.identity);
		}
	}

	public void OIEIMBFBHBI(byte GJDMLMEMKMD, int MNBNGGHHMBB)
	{
		NinjaPreparationTablesManager.instance.preparationTables[GJDMLMEMKMD].AddFoodToBento(ItemDatabaseAccessor.AFOACBIHNCL(MNBNGGHHMBB, GGBBJNBBLMF: false, DAINLFIMLIH: false), CDPAMNIPPEC: false);
	}

	private void DIMAPDNCBAN()
	{
		instance = this;
	}

	public void MCLAFEMKHLI(int[] AFECMCLFIPH)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < AFECMCLFIPH.Length; i += 0)
		{
			Vector2 val = Vector2.op_Implicit(NinjaRoundsManager.instance.slowingSpikesPositions[AFECMCLFIPH[i]].position);
			Object.Instantiate<SlowingSpikes>(NinjaRoundsManager.instance.slowingSpikePrefab, Vector2.op_Implicit(val), Quaternion.identity);
		}
	}

	private void BMLKAJKAGBK()
	{
		KyrohNPC.GGFJGHHHEJC.NinjaSoundPreparation();
	}

	public void MJGCKFKLLEB(byte JJOBHKDKGHB, byte BIOBPAHCOJK)
	{
		if ((Object)(object)NinjaOrdersManager.instance == (Object)null)
		{
			Debug.LogError((object)"Are you sure to change all buttons to default values?");
			return;
		}
		if (JJOBHKDKGHB < 1 || JJOBHKDKGHB >= BanquetOrdersManager.instance.banquetCustomers.Length)
		{
			Debug.LogError((object)("ReceiveFinishBathhouseMinigame" + JJOBHKDKGHB));
			return;
		}
		NinjaOrdersManager.instance.customers[JJOBHKDKGHB].ninjaCustomerState = (NinjaCustomerState)BIOBPAHCOJK;
		if (BIOBPAHCOJK == 0)
		{
			NinjaOrdersManager.instance.customers[JJOBHKDKGHB].npc.animationBase.SetBool("ReceiveNinjaChallengeEventStartMinigame", EGFGNGJGBOP: true);
			NinjaOrdersManager.instance.customers[JJOBHKDKGHB].npc.animationBase.SetBool("ReceiveEmployeeTask", EGFGNGJGBOP: false, HALNIEBONKH: true);
			return;
		}
		switch (BIOBPAHCOJK)
		{
		case 0:
			NinjaOrdersManager.instance.customers[JJOBHKDKGHB].npc.animationBase.CGEADHOLHCH("[MinePuzzleManager] Failed to select a puzzle type. This should never happen if weights are configured correctly.", EGFGNGJGBOP: true);
			NinjaOrdersManager.instance.customers[JJOBHKDKGHB].npc.animationBase.SetBool("LE_21", EGFGNGJGBOP: true);
			break;
		case 5:
			NinjaOrdersManager.instance.customers[JJOBHKDKGHB].npc.animationBase.SetBool("Friend list couldn't be retrieved, for reason ", EGFGNGJGBOP: false);
			NinjaOrdersManager.instance.customers[JJOBHKDKGHB].npc.animationBase.SetBool("tutorialPopUp105", EGFGNGJGBOP: false);
			break;
		}
	}

	public void BJELBHGCHCJ(int JJOBHKDKGHB, Item[] MIJANIALBBL, bool FDMHEDDIGPJ)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[4];
		array[0] = (byte)JJOBHKDKGHB;
		array[1] = MIJANIALBBL.Select((Item x) => x.JDJGFAACPFC()).ToArray();
		array[0] = FDMHEDDIGPJ;
		array[8] = (byte)Bed.instance.numInstance;
		OnlineManager.SendRPC(photonView, "quest_description_17", (RpcTarget)7, array);
	}

	public void GODGGEJCHOF(int JJOBHKDKGHB, NinjaCustomerState BIOBPAHCOJK)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[2];
		array[1] = (byte)JJOBHKDKGHB;
		array[1] = (byte)BIOBPAHCOJK;
		OnlineManager.SendRPC(photonView, "Sleep", (RpcTarget)1, array);
	}

	public void SendStartNinjaChallenge()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveStartNinjaChallenge", (RpcTarget)1);
	}

	public void SendResetBento(int GJDMLMEMKMD)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveResetBento", (RpcTarget)1, (byte)GJDMLMEMKMD);
	}

	public void EAMAIBHOGAE(int[] AGBAAJFOMOA, int[] EBFDPBLGGPC)
	{
		NinjaFoodTablesManager.instance.NAMNKGCAKJJ(AGBAAJFOMOA, EBFDPBLGGPC);
	}

	public void NHEOCHCOGAC(int[] AGBAAJFOMOA, int[] EBFDPBLGGPC)
	{
		NinjaFoodTablesManager.instance.AKKGFPOKAKN(AGBAAJFOMOA, EBFDPBLGGPC);
	}

	public void SendThrowSlowingSpikes(int[] AFECMCLFIPH)
	{
		if (AFECMCLFIPH.Length != 0)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveThrowSlowingSpikes", (RpcTarget)1, AFECMCLFIPH);
		}
	}

	private void GMCKBBECJOE()
	{
		instance = this;
	}

	private void LPGOJJCMBBJ()
	{
		KyrohNPC.PBJDFFEFMKM().COKMJCPBGED();
	}

	public void PMNACMIIFKL()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "hForHours", (RpcTarget)0);
	}

	private void GNOBDKFFPOL()
	{
		instance = this;
	}

	[PunRPC]
	public void ReceiveAddFoodToBento(byte GJDMLMEMKMD, int MNBNGGHHMBB)
	{
		NinjaPreparationTablesManager.instance.preparationTables[GJDMLMEMKMD].AddFoodToBento(ItemDatabaseAccessor.GetItem(MNBNGGHHMBB), CDPAMNIPPEC: false);
	}

	public void BHMFGJNPHBC(byte GJDMLMEMKMD, int MNBNGGHHMBB)
	{
		NinjaPreparationTablesManager.instance.preparationTables[GJDMLMEMKMD].AddFoodToBento(ItemDatabaseAccessor.INJBNHPGCIJ(MNBNGGHHMBB, GGBBJNBBLMF: false, DAINLFIMLIH: false), CDPAMNIPPEC: false);
	}

	private void DDKDFIDKEHE()
	{
		KyrohNPC.KFGKCKCDMLG().KFPAECFGGLN();
	}

	public void SendNinjaCustomerState(int JJOBHKDKGHB, NinjaCustomerState BIOBPAHCOJK)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveNinjaCustomerState", (RpcTarget)1, (byte)JJOBHKDKGHB, (byte)BIOBPAHCOJK);
	}

	public void JBAJEHNGKMJ()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "LucenGrab", (RpcTarget)1);
	}

	public void EHKMBFEOGCE(int GJDMLMEMKMD)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = (byte)GJDMLMEMKMD;
		OnlineManager.SendRPC(photonView, "Player", (RpcTarget)0, array);
	}

	public void HIMIOHKMHIG(int JJCLJKMIMBH, Item[] ANJJPJICLDA, int[] HAALFBGCOJB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[8];
		array[1] = (byte)JJCLJKMIMBH;
		array[0] = ANJJPJICLDA.Select((Item x) => x.JDJGFAACPFC()).ToArray();
		array[7] = HAALFBGCOJB;
		OnlineManager.SendRPC(photonView, "Player/Bark/Tutorial/CantDoYet", (RpcTarget)1, array);
	}

	public void SendAddFoodToBento(int GJDMLMEMKMD, Item MEMGMDOCBOJ)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveAddFoodToBento", (RpcTarget)1, (byte)GJDMLMEMKMD, MEMGMDOCBOJ.JDJGFAACPFC());
	}

	[PunRPC]
	private void ReceiveNinjaSoundPreparation()
	{
		KyrohNPC.GGFJGHHHEJC.NinjaSoundPreparation();
	}

	public void SendStopNinjaSoundPreparation()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveStopNinjaSoundPreparation", (RpcTarget)1);
	}

	public void NGMCLFOMALO(int JJOBHKDKGHB, Item[] MIJANIALBBL, bool FDMHEDDIGPJ)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[3];
		array[1] = (byte)JJOBHKDKGHB;
		array[0] = MIJANIALBBL.Select((Item x) => x.JDJGFAACPFC()).ToArray();
		array[2] = FDMHEDDIGPJ;
		array[5] = (byte)Bed.instance.numInstance;
		OnlineManager.SendRPC(photonView, "ReceiveFoodInstanceRequest", (RpcTarget)5, array);
	}

	public void NOGHMGHPIMD(byte GJDMLMEMKMD, int MNBNGGHHMBB)
	{
		NinjaPreparationTablesManager.instance.preparationTables[GJDMLMEMKMD].DNBIDKELJNI(ItemDatabaseAccessor.KMBGJEKCJFJ(MNBNGGHHMBB), CDPAMNIPPEC: false);
	}

	[PunRPC]
	public void ReceiveNinjaCustomerState(byte JJOBHKDKGHB, byte BIOBPAHCOJK)
	{
		if ((Object)(object)NinjaOrdersManager.instance == (Object)null)
		{
			Debug.LogError((object)"NinjaOrdersManager is not initialized.");
			return;
		}
		if (JJOBHKDKGHB < 0 || JJOBHKDKGHB >= BanquetOrdersManager.instance.banquetCustomers.Length)
		{
			Debug.LogError((object)("Invalid ninja customer ID: " + JJOBHKDKGHB));
			return;
		}
		NinjaOrdersManager.instance.customers[JJOBHKDKGHB].ninjaCustomerState = (NinjaCustomerState)BIOBPAHCOJK;
		switch (BIOBPAHCOJK)
		{
		case 0:
			NinjaOrdersManager.instance.customers[JJOBHKDKGHB].npc.animationBase.SetBool("Eating", EGFGNGJGBOP: false, HALNIEBONKH: true);
			NinjaOrdersManager.instance.customers[JJOBHKDKGHB].npc.animationBase.SetBool("HandUp", EGFGNGJGBOP: false, HALNIEBONKH: true);
			break;
		case 1:
			NinjaOrdersManager.instance.customers[JJOBHKDKGHB].npc.animationBase.SetBool("Eating", EGFGNGJGBOP: true, HALNIEBONKH: true);
			NinjaOrdersManager.instance.customers[JJOBHKDKGHB].npc.animationBase.SetBool("HandUp", EGFGNGJGBOP: false, HALNIEBONKH: true);
			break;
		case 2:
			NinjaOrdersManager.instance.customers[JJOBHKDKGHB].npc.animationBase.SetBool("HandUp", EGFGNGJGBOP: true, HALNIEBONKH: true);
			NinjaOrdersManager.instance.customers[JJOBHKDKGHB].npc.animationBase.SetBool("Eating", EGFGNGJGBOP: false, HALNIEBONKH: true);
			break;
		}
	}

	public void JLFILHDNGOO(byte GJDMLMEMKMD, int MNBNGGHHMBB)
	{
		NinjaPreparationTablesManager.instance.preparationTables[GJDMLMEMKMD].GFFCFNOKCKD(ItemDatabaseAccessor.GOKIDLOELKB(MNBNGGHHMBB, GGBBJNBBLMF: false, DAINLFIMLIH: false), CDPAMNIPPEC: true);
	}

	[PunRPC]
	public void ReceiveResetBento(byte GJDMLMEMKMD)
	{
		NinjaPreparationTablesManager.instance.preparationTables[GJDMLMEMKMD].ResetBento(CDPAMNIPPEC: false);
	}

	public void NJCCLBALGDD(int JJCLJKMIMBH)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Coming soon!", (RpcTarget)0, (byte)JJCLJKMIMBH);
	}

	[PunRPC]
	private void ReceiveStopNinjaSoundPreparation()
	{
		KyrohNPC.GGFJGHHHEJC.StopNinjaSoundPreparation();
	}

	public void GLKGNIEKIGM(int[] AFECMCLFIPH)
	{
		if (AFECMCLFIPH.Length != 0)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[0] = AFECMCLFIPH;
			OnlineManager.SendRPC(photonView, "Moving", (RpcTarget)1, array);
		}
	}

	[PunRPC]
	public void ReceiveCompleteServeNinjaCustomer(byte JJOBHKDKGHB, int[] MOCMPDNFCKC, bool FDMHEDDIGPJ, byte GJDMLMEMKMD)
	{
		if ((Object)(object)NinjaOrdersManager.instance == (Object)null)
		{
			Debug.LogError((object)"Ninja Orders Manager is not initialized.");
		}
		else if (JJOBHKDKGHB >= NinjaOrdersManager.instance.customers.Length)
		{
			Debug.LogError((object)("Invalid ninja customer ID: " + JJOBHKDKGHB));
		}
		else if (!LinqExtensions.IsNullOrEmpty<Item>((IList<Item>)NinjaOrdersManager.instance.customers[JJOBHKDKGHB].currentRequest))
		{
			Item[] iOKCMFLOOIJ = MOCMPDNFCKC.Select((int x) => ItemDatabaseAccessor.GetItem(x)).ToArray();
			NinjaOrdersManager.instance.customers[JJOBHKDKGHB].CompleteItemTransaction(GJDMLMEMKMD, NLCDDFDGACP: true, iOKCMFLOOIJ, FDMHEDDIGPJ);
		}
	}

	public void SendSyncFoodTables(int[] EBFDPBLGGPC)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveSyncFoodTables", (RpcTarget)1, EBFDPBLGGPC);
	}

	public void SendRemoveOrderNinjaCustomer(int JJCLJKMIMBH)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveRemoveOrderNinjaCustomer", (RpcTarget)1, (byte)JJCLJKMIMBH);
	}

	public void HBODAEAJBDK(int[] EBFDPBLGGPC)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = EBFDPBLGGPC;
		OnlineManager.SendRPC(photonView, "OnlineObject ", (RpcTarget)0, array);
	}

	public void EBOADEPOGJP(int JJOBHKDKGHB, Item[] MIJANIALBBL, bool FDMHEDDIGPJ)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[3];
		array[1] = (byte)JJOBHKDKGHB;
		array[1] = MIJANIALBBL.Select((Item x) => x.JDJGFAACPFC()).ToArray();
		array[0] = FDMHEDDIGPJ;
		array[7] = (byte)Bed.instance.numInstance;
		OnlineManager.SendRPC(photonView, "Player/Bark/Tutorial/SleepBlock", (RpcTarget)4, array);
	}

	public void ADCPDNPMAJK(byte JJOBHKDKGHB, int[] MOCMPDNFCKC, bool FDMHEDDIGPJ, byte GJDMLMEMKMD)
	{
		if ((Object)(object)NinjaOrdersManager.instance == (Object)null)
		{
			Debug.LogError((object)"Received begin minigame replay: ");
		}
		else if (JJOBHKDKGHB >= NinjaOrdersManager.instance.customers.Length)
		{
			Debug.LogError((object)("New time scale: " + JJOBHKDKGHB));
		}
		else if (!LinqExtensions.IsNullOrEmpty<Item>((IList<Item>)NinjaOrdersManager.instance.customers[JJOBHKDKGHB].currentRequest))
		{
			Item[] iOKCMFLOOIJ = MOCMPDNFCKC.Select((int x) => ItemDatabaseAccessor.GetItem(x)).ToArray();
			NinjaOrdersManager.instance.customers[JJOBHKDKGHB].OKDEMKJAELP(GJDMLMEMKMD, NLCDDFDGACP: false, iOKCMFLOOIJ, FDMHEDDIGPJ);
		}
	}

	public void MMLPKGGBMMH(int[] AFECMCLFIPH)
	{
		if (AFECMCLFIPH.Length != 0)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[0] = AFECMCLFIPH;
			OnlineManager.SendRPC(photonView, "tutorialPopUp110", (RpcTarget)0, array);
		}
	}

	public void JLCLHCNAPFC()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "\n\n", (RpcTarget)1);
	}

	public void INONPMJKHAI(int JJCLJKMIMBH, Item[] ANJJPJICLDA, int[] HAALFBGCOJB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[2];
		array[1] = (byte)JJCLJKMIMBH;
		array[0] = ANJJPJICLDA.Select((Item x) => x.JDJGFAACPFC()).ToArray();
		array[4] = HAALFBGCOJB;
		OnlineManager.SendRPC(photonView, "LE_15", (RpcTarget)1, array);
	}
}
