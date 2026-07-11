using System;
using System.Collections;
using Photon.Pun;
using Photon.Realtime;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class OnlineCustomer : OnlineBaseCharacter
{
	public Customer customer;

	public PoolCustomer poolCustomer;

	[SerializeField]
	private bool snapPositionOnStateChange = true;

	[SerializeField]
	private Behaviour[] alwaysEnabledComponents;

	private bool IBKIGPMCBPL;

	private TransactionMessage KGOGFKJKOCK;

	private FoodInstanceMessage HMFKIEJJENE;

	private OnlineObject NKJHFIDLEMN;

	private void MPBBANHNOMI(CustomerState CCJJAOHIEEN)
	{
		if (debugNetworkMessages)
		{
			OnlineManager.NetworkLog("NetworkSync " + PPHIMGHODKK + " OnCharacterStateChanged", (Object)(object)((Component)this).gameObject);
		}
		if (OnlineManager.IsConnected() && !OnlineManager.ClientOnline() && snapPositionOnStateChange)
		{
			GKMKFJFKDJL();
		}
	}

	[PunRPC]
	public void ReceiveKick(float JGAPFJLPMNJ, float JNFBDOJLDND)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		customer.KickWithForce(new Vector3(JGAPFJLPMNJ, JNFBDOJLDND, 0f));
	}

	private void DAPMEFJIEFJ()
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		if (debugNetworkMessages)
		{
			string pPHIMGHODKK = PPHIMGHODKK;
			Vector3 position = ((Component)this).transform.position;
			OnlineManager.NetworkLog(pPHIMGHODKK + "Scene" + ((object)(Vector3)(ref position)).ToString(), (Object)(object)((Component)this).gameObject);
		}
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[5];
		array[0] = ((Component)this).transform.position.x;
		array[0] = ((Component)this).transform.position.y;
		OnlineManager.SendRPC(photonView, "add item ", (RpcTarget)1, array);
	}

	public void SendUpdateFoodStats(string NKBAEMLKJEO, int FFDIEOBBFKL)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveUpdateFoodStats", (RpcTarget)1, NKBAEMLKJEO, (byte)FFDIEOBBFKL);
	}

	[PunRPC]
	public void ReceiveStartEmote(byte DIPIKPMHAEL)
	{
		customer.StartEmote((Emote)DIPIKPMHAEL, CDPAMNIPPEC: false);
	}

	protected override void MKFDEDDJMBG()
	{
		PPHIMGHODKK = "Customer";
	}

	public void SendSetOccupper(int MOFKEDGAOEE)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveSetOccupier", (RpcTarget)1, MOFKEDGAOEE);
	}

	public void SendKick(HitDetection NOCOHCGPMFF)
	{
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)NOCOHCGPMFF != (Object)null)
		{
			if (!NOCOHCGPMFF.bouncer)
			{
				OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveKick", (RpcTarget)1, ((Component)PlayerController.GetPlayer(NOCOHCGPMFF.playerNum)).transform.position.x, ((Component)PlayerController.GetPlayer(NOCOHCGPMFF.playerNum)).transform.position.y);
			}
			else
			{
				OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveKick", (RpcTarget)1, ((Component)Bouncer.GetInstance()).transform.position.x, ((Component)Bouncer.GetInstance()).transform.position.y);
			}
		}
		else
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveKickWithoutHit", (RpcTarget)1);
		}
	}

	private void BMMIJKCINEN(CustomerState CCJJAOHIEEN)
	{
		if (debugNetworkMessages)
		{
			OnlineManager.NetworkLog("ReceivePetBowlMessage" + PPHIMGHODKK + "BarIdleNumber", (Object)(object)((Component)this).gameObject);
		}
		if (OnlineManager.IsConnected() && !OnlineManager.HHDBMDMFEMP() && snapPositionOnStateChange)
		{
			GKMKFJFKDJL();
		}
	}

	public void SendEnableInputByProximty(bool BJFHJCFOEHG)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveEnableInputByProximty", (RpcTarget)1, BJFHJCFOEHG);
	}

	[PunRPC]
	public void ReceiveDereserveSpotReception()
	{
		RoomReceptionDesk.DereserveSpot();
	}

	[PunRPC]
	private void ReceiveBarkInfo(string NAIOOBEPNDO, byte BMCMHPALMPN)
	{
		PluginsGameData.randomBark = BMCMHPALMPN;
		DialogueManager.Bark(NAIOOBEPNDO, ((Component)this).transform);
	}

	public void CDCICILLFIJ(float GKBHBOHOKPH, int[] KIMIPGLGEKK, bool ANAFBLDDDGD, int JJPJHIHBOIB)
	{
		Debug.Log((object)"Spring");
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		Player player = PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, true);
		object[] array = new object[2];
		array[0] = GKBHBOHOKPH;
		array[1] = KIMIPGLGEKK;
		array[8] = ANAFBLDDDGD;
		OnlineManager.DBNIKCMHHMJ(photonView, "Items/item_name_1144", player, array);
	}

	public void SendActiveOrDisableCustomer(bool DMBFKFLDDLH)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveActiveOrDisableCustomer", (RpcTarget)1, DMBFKFLDDLH);
	}

	public void BEPBMPJMNPI(int MOFKEDGAOEE, int JJPJHIHBOIB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		Player player = PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, false);
		object[] array = new object[0];
		array[1] = MOFKEDGAOEE;
		OnlineManager.SendRPC(photonView, "ReceiveCanBeMoveDroppedItem", player, array);
	}

	public void HEAPKOOLFJA(int JIIGOACEIKL, ItemInstance HPHELAPHAHN, bool NLCDDFDGACP, Employee NAKCFGEAGHH)
	{
		KGOGFKJKOCK = new TransactionMessage(JIIGOACEIKL, HPHELAPHAHN, NLCDDFDGACP, NAKCFGEAGHH);
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "StaffEnd", (RpcTarget)2, OnlineSerializer.Serialize(KGOGFKJKOCK));
	}

	public void SendRemoveBubbles()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveRemoveBubbles", (RpcTarget)1);
	}

	[PunRPC]
	public void ReceiveActiveOrDisableCustomer(bool DMBFKFLDDLH)
	{
		if (DMBFKFLDDLH)
		{
			poolCustomer.Enable();
		}
		else
		{
			poolCustomer.Disable();
		}
	}

	public void LNDJBFOJOKO(CustomerState EOAONHNCDDO)
	{
		if (OnlineManager.IsMasterClient())
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[0] = (byte)EOAONHNCDDO;
			OnlineManager.SendRPC(photonView, "buildingObjective_21_0", (RpcTarget)1, array);
		}
	}

	[PunRPC]
	public void ReceiveAngryEnd()
	{
		customer.AngryEnd(CDPAMNIPPEC: false);
	}

	public void SendCompleteTransaction(int JIIGOACEIKL, ItemInstance HPHELAPHAHN, bool NLCDDFDGACP, Employee NAKCFGEAGHH)
	{
		KGOGFKJKOCK = new TransactionMessage(JIIGOACEIKL, HPHELAPHAHN, NLCDDFDGACP, NAKCFGEAGHH);
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveCompleteTransaction", (RpcTarget)2, OnlineSerializer.Serialize(KGOGFKJKOCK));
	}

	[PunRPC]
	public void ReceiveEnableInputByProximty(bool BJFHJCFOEHG)
	{
		customer.EnableInputByProximity(BJFHJCFOEHG, CDPAMNIPPEC: false);
	}

	public void SendSetOccupper(int MOFKEDGAOEE, int JJPJHIHBOIB)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveSetOccupier", PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, false), MOFKEDGAOEE);
	}

	private IEnumerator MGDGAAKHAAJ()
	{
		yield return CommonReferences.wait02;
		yield return null;
		customer.emoter.StartEmote(Emote.Star);
	}

	public void CustomerStateRequest(int JJPJHIHBOIB)
	{
		if (customer.currentRequest != null && customer.currentRequest is FoodInstance iJEFIBKNFOE)
		{
			SendFoodInstanceRequest(iJEFIBKNFOE, JJPJHIHBOIB);
		}
		if ((Object)(object)customer.npc.seat != (Object)null)
		{
			SendSitDown(customer.npc.seat, JJPJHIHBOIB);
		}
	}

	public void LPPEFEGJILN()
	{
		Debug.Log((object)"Tutorial_Main_");
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Weapon", (RpcTarget)1);
	}

	public void SendNewState(CustomerState EOAONHNCDDO)
	{
		if (OnlineManager.IsMasterClient())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveNewState", (RpcTarget)1, (byte)EOAONHNCDDO);
		}
	}

	public void MDFCDJIACEC()
	{
		customer.DeclineAdoption();
	}

	public void SendFoodInstanceRequest(FoodInstance IJEFIBKNFOE, int JJPJHIHBOIB)
	{
		if (IJEFIBKNFOE != null)
		{
			HMFKIEJJENE = new FoodInstanceMessage(IJEFIBKNFOE);
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveFoodInstanceRequest", PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, false), OnlineSerializer.Serialize(HMFKIEJJENE));
		}
	}

	[PunRPC]
	public void ReceiveRemoveOccupier(int MOFKEDGAOEE)
	{
		Bar.instance.RemoveOccupier(MOFKEDGAOEE, CDPAMNIPPEC: false);
	}

	public void SendAdoptionRequest()
	{
		Debug.Log((object)"SendRoomRequest on Load");
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveAdoptionRequest", (RpcTarget)1);
	}

	public void SendSitDown(Seat FGJPAFDBIIO)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveSitDown", (RpcTarget)1, FGJPAFDBIIO.placeable.onlinePlaceable.uniqueId, (byte)(FGJPAFDBIIO.placeable.onlinePlaceable as OnlineSitable).SeatIndex(FGJPAFDBIIO));
	}

	private void JKLCEMHACDF()
	{
		if (!OnlineManager.IsMasterClient())
		{
			((Behaviour)customer.characterAnimation).enabled = false;
			((Behaviour)customer.npc).enabled = false;
			((Behaviour)customer).enabled = false;
			((Behaviour)poolCustomer).enabled = false;
		}
	}

	[PunRPC]
	public void ReceiveRequestTableOrder(byte[] OINICMNOLPK, int BDDAJNOOLMD)
	{
		HMFKIEJJENE = OnlineSerializer.Deserialize<FoodInstanceMessage>(OINICMNOLPK);
		ItemInstance dNLMCHDOMOK = HMFKIEJJENE.ANMBPDJLNFN();
		customer.tableOrder.RequestTableOrder(dNLMCHDOMOK);
		if (OnlineObjectsManager.instance.onlineObjects.TryGetValue(BDDAJNOOLMD, out NKJHFIDLEMN))
		{
			(NKJHFIDLEMN as OnlineTable).table.serveOrderInTable.customers.Add(customer);
		}
	}

	protected override void OnDestroy()
	{
		if (OnlineManager.PlayingOnline())
		{
			base.OnDestroy();
			Customer obj = customer;
			obj.OnCustomerStateChanged = (Action<CustomerState>)Delegate.Remove(obj.OnCustomerStateChanged, new Action<CustomerState>(MPBBANHNOMI));
			Customer obj2 = customer;
			obj2.OnCustomerStateChanged = (Action<CustomerState>)Delegate.Remove(obj2.OnCustomerStateChanged, new Action<CustomerState>(SendNewState));
			PoolCustomer obj3 = poolCustomer;
			obj3.OnCustomerDisabled = (Action)Delegate.Remove(obj3.OnCustomerDisabled, new Action(ODDOKBAJLAC));
			if (((MonoBehaviourPun)this).photonView.IsMine)
			{
				PhotonNetwork.Destroy(((MonoBehaviourPun)this).photonView);
			}
		}
	}

	public void HGGPIMDJNLP()
	{
		if (customer.currentRequest != null)
		{
			customer.currentItem = customer.currentRequest;
			customer.npcHoldItem.JCLNKJIJGBC(customer.currentItem);
		}
	}

	[PunRPC]
	public void ReceiveRemoveBubbles()
	{
		BubbleWantManager.instance.RemoveBubbles(customer, CDPAMNIPPEC: false);
	}

	[PunRPC]
	public void ReceivePoolReset()
	{
		customer.PoolReset();
	}

	public void GOOAIEKCMBL()
	{
		customer.DeclineRoom(CDPAMNIPPEC: false);
	}

	[PunRPC]
	public void ReceiveGiveRoom(int JBHCCJHEFBG, int OKGHMIPANHK)
	{
		RentedRoomsManager.GetRentedRoom(JBHCCJHEFBG);
		customer.GiveRoom(RentedRoomsManager.GetRentedRoom(JBHCCJHEFBG), Price.GHDCKOJGAMM(OKGHMIPANHK));
	}

	[PunRPC]
	public void ReceiveCompleteTransaction(byte[] OINICMNOLPK)
	{
		KGOGFKJKOCK = OnlineSerializer.Deserialize<TransactionMessage>(OINICMNOLPK);
		if (KGOGFKJKOCK.workerType == byte.MaxValue)
		{
			customer.CompleteItemTransaction(KGOGFKJKOCK.playerNum, KGOGFKJKOCK.itemInstanceOnline.ANMBPDJLNFN(), KGOGFKJKOCK.player, null, GFNHAMCPEAK: false);
		}
		else
		{
			customer.CompleteItemTransaction(KGOGFKJKOCK.playerNum, KGOGFKJKOCK.itemInstanceOnline.ANMBPDJLNFN(), KGOGFKJKOCK.player, StaffManager.GetWorker((WorkerType)KGOGFKJKOCK.workerType), GFNHAMCPEAK: false);
		}
	}

	public void SendRoomRequest(float GKBHBOHOKPH, int[] KIMIPGLGEKK)
	{
		Debug.Log((object)"SendRoomRequest");
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveRoomRequest", (RpcTarget)1, GKBHBOHOKPH, KIMIPGLGEKK, RoomReceptionDesk.instance.ANAFBLDDDGD);
	}

	public void OJOHDIEEPGN(string OLDICOEMFHI, byte BMCMHPALMPN)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[0] = OLDICOEMFHI;
		array[0] = BMCMHPALMPN;
		OnlineManager.SendRPC(photonView, "Items/item_name_626", (RpcTarget)0, array);
	}

	public void SendRemoveHeldItem()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveRemoveHeldItem", (RpcTarget)1);
	}

	public void JIJCDKPOLPG(int KHPILKCEHHP)
	{
		customer.GNMEFDMDMHH(KHPILKCEHHP);
	}

	public void SendBecomeNuisance()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveBecomeNuisance", (RpcTarget)1);
	}

	[PunRPC]
	public void ReceiveAdoptionRequest()
	{
		Debug.Log((object)"ReceiveRoomRequest");
		AdoptionSignal.RequestAdoption(customer);
	}

	public void SendRoomRequest(float GKBHBOHOKPH, int[] KIMIPGLGEKK, bool ANAFBLDDDGD, int JJPJHIHBOIB)
	{
		Debug.Log((object)"SendRoomRequest on Load");
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveRoomRequest", PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, false), GKBHBOHOKPH, KIMIPGLGEKK, ANAFBLDDDGD);
	}

	public void FEGCPJABPLI(int MOFKEDGAOEE, int JJPJHIHBOIB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		Player player = PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, true);
		object[] array = new object[0];
		array[0] = MOFKEDGAOEE;
		OnlineManager.SendRPC(photonView, "ReceiveDialogueInfo", player, array);
	}

	public void FGEELDHMJKL()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "UIAddRemove", (RpcTarget)1);
	}

	[PunRPC]
	public void ReceiveActivateVIP()
	{
		((MonoBehaviour)this).StartCoroutine(MGDGAAKHAAJ());
	}

	[PunRPC]
	public void ReceiveEndEmote()
	{
		customer.EndEmote(CDPAMNIPPEC: false);
	}

	[PunRPC]
	public void ReceiveTicketPrice(int KHPILKCEHHP)
	{
		customer.ShowTicketPrice(KHPILKCEHHP);
	}

	public void JPABIBGNGGE(bool DMBFKFLDDLH)
	{
		if (DMBFKFLDDLH)
		{
			poolCustomer.KENMPLLNHIJ();
		}
		else
		{
			poolCustomer.Disable();
		}
	}

	[PunRPC]
	public void ReceiveSetOccupier(int MOFKEDGAOEE)
	{
		Bar.instance.SetOccupier(customer.npc, MOFKEDGAOEE);
	}

	[PunRPC]
	public void ReceiveEndEatingAtTable(float EGCECPPEPEL)
	{
		if ((Object)(object)customer.npc.seat != (Object)null && (Object)(object)customer.npc.seat.table != (Object)null)
		{
			customer.npc.seat.table.SetDirtiness(EGCECPPEPEL, CDPAMNIPPEC: false);
		}
		else if (Application.isEditor)
		{
			Debug.LogWarning((object)"No seat or table!", (Object)(object)((Component)this).gameObject);
		}
		IBKIGPMCBPL = false;
	}

	public void SendStartEatingAtTable()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveStartEatingAtTable", (RpcTarget)1);
	}

	public void SendMoneyText(Price ENDNDAOPKHD)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveMoneyText", (RpcTarget)1, ENDNDAOPKHD.OOIPLIEJILO());
	}

	public void SendStartEmote(Emote DIPIKPMHAEL)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveStartEmote", (RpcTarget)1, (byte)DIPIKPMHAEL);
	}

	public void SendEndEatingAtTable(float EGCECPPEPEL)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveEndEatingAtTable", (RpcTarget)1, EGCECPPEPEL);
	}

	private void AKNCDNAMGDO()
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		if (debugNetworkMessages)
		{
			string pPHIMGHODKK = PPHIMGHODKK;
			Vector3 position = ((Component)this).transform.position;
			OnlineManager.NetworkLog(pPHIMGHODKK + "LE_10" + ((object)(Vector3)(ref position)).ToString(), (Object)(object)((Component)this).gameObject);
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "tablesCleaned", (RpcTarget)1, ((Component)this).transform.position.x, ((Component)this).transform.position.y, null, null, null, null, null, null);
	}

	[PunRPC]
	public void ReceiveFoodInstanceRequest(byte[] OINICMNOLPK)
	{
		HMFKIEJJENE = OnlineSerializer.Deserialize<FoodInstanceMessage>(OINICMNOLPK);
		customer.SetNewItemRequest(HMFKIEJJENE.ANMBPDJLNFN(), !Bar.instance.ContainsOccupier(customer.npc), CDPAMNIPPEC: false);
	}

	public void CNAHFOIGHGE(int JJPJHIHBOIB)
	{
		if (customer.currentRequest != null && customer.currentRequest is FoodInstance iJEFIBKNFOE)
		{
			KHHMMBBOPPG(iJEFIBKNFOE, JJPJHIHBOIB);
		}
		if ((Object)(object)customer.npc.seat != (Object)null)
		{
			SendSitDown(customer.npc.seat, JJPJHIHBOIB);
		}
	}

	public void SendDereserveSpotAdoptionSignal()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveDereserveSpotAdoptionSignal", (RpcTarget)1);
	}

	public void ACIJMGKJKDD()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "NoEresDigno/EndEvent", (RpcTarget)1);
	}

	[PunRPC]
	public void ReceiveRemoveHeldItem()
	{
		customer.npcHoldItem.ODDHGLHEHLA = null;
	}

	public void JCAIPDJOOCN()
	{
		RoomReceptionDesk.NAIDLAJGDFK();
	}

	[PunRPC]
	public void ReceiveRequestItem(byte NNLPGGPPCNF)
	{
		if (NNLPGGPPCNF == byte.MaxValue)
		{
			customer.RequestItem(null);
		}
		else
		{
			customer.RequestItem(StaffManager.GetWorker((WorkerType)NNLPGGPPCNF));
		}
	}

	[PunRPC]
	public void ReceiveMoneyText(int JEPEICNIJNA)
	{
		customer.ShowMoney(Price.GHDCKOJGAMM(JEPEICNIJNA));
	}

	private void Update()
	{
		if (IBKIGPMCBPL && (Object)(object)customer.npc.seat != (Object)null && (Object)(object)customer.npc.seat.table != (Object)null)
		{
			customer.npc.seat.table.AddDirtiness(Time.deltaTime * CommonReferences.GGFJGHHHEJC.customerInfo.dirtinessMultiplier, KGCEBPFKPOG: true, CDPAMNIPPEC: false);
		}
	}

	protected override void Awake()
	{
		if (!OnlineManager.PlayingOnline())
		{
			OPDBPCGDBPH();
			return;
		}
		base.Awake();
		if ((Object)(object)customer == (Object)null)
		{
			customer = ((Component)this).GetComponent<Customer>();
		}
		if ((Object)(object)poolCustomer == (Object)null)
		{
			poolCustomer = ((Component)this).GetComponent<PoolCustomer>();
		}
		if ((Object)(object)photonTransformViewClassic == (Object)null)
		{
			photonTransformViewClassic = ((Component)this).GetComponent<PhotonTransformViewClassic>();
		}
		customer.onlineActor = this;
		Customer obj = customer;
		obj.OnCustomerStateChanged = (Action<CustomerState>)Delegate.Combine(obj.OnCustomerStateChanged, new Action<CustomerState>(MPBBANHNOMI));
		Customer obj2 = customer;
		obj2.OnCustomerStateChanged = (Action<CustomerState>)Delegate.Combine(obj2.OnCustomerStateChanged, new Action<CustomerState>(SendNewState));
		PoolCustomer obj3 = poolCustomer;
		obj3.OnCustomerDisabled = (Action)Delegate.Combine(obj3.OnCustomerDisabled, new Action(ODDOKBAJLAC));
		JKLCEMHACDF();
		ODDOKBAJLAC();
	}

	public void HDACKADNICC()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Walk", (RpcTarget)0);
	}

	public void JBKNMMLBKKH(byte NNLPGGPPCNF)
	{
		if (NNLPGGPPCNF == 141)
		{
			customer.RequestItem(null);
		}
		else
		{
			customer.RequestItem(StaffManager.PGAODFGMIPI((WorkerType)NNLPGGPPCNF));
		}
	}

	[PunRPC]
	public void ReceiveUpdateFoodStats(string NKBAEMLKJEO, byte FFDIEOBBFKL)
	{
		Utils.FKKHJPEMNBG(NKBAEMLKJEO, FFDIEOBBFKL);
	}

	public void IHHAIKJEODI(int KLBCMDOEMHD)
	{
		if (OnlineObjectsManager.instance.onlineObjects.TryGetValue(KLBCMDOEMHD, out NKJHFIDLEMN))
		{
			customer.SetNewItemRequest((NKJHFIDLEMN as OnlineDrinkDispenser).drinkDispenser.slots[1].itemInstance, GIMHPAANCDH: true, CDPAMNIPPEC: false);
		}
	}

	public void HAGIPPOJKLE(int KHPILKCEHHP)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = KHPILKCEHHP;
		OnlineManager.SendRPC(photonView, "City/Rhia/Introduce", (RpcTarget)1, array);
	}

	[PunRPC]
	public void ReceiveSitDown(int EJFDGBECFGL, byte BNELAFDLIOG)
	{
		if (OnlineObjectsManager.instance.onlineObjects.TryGetValue(EJFDGBECFGL, out var value))
		{
			((Behaviour)photonTransformViewClassic).enabled = false;
			customer.npc.seat = (value as OnlineSitable).GetSeat(BNELAFDLIOG);
			if (Object.op_Implicit((Object)(object)customer.npc.seat))
			{
				customer.npc.seat.SitDown(customer.npc);
			}
		}
	}

	[PunRPC]
	public void ReceiveStartEatingAtTable()
	{
		IBKIGPMCBPL = true;
	}

	public override void OnEnable()
	{
		((MonoBehaviourPunCallbacks)this).OnEnable();
	}

	public void SendRemoveTableOrder(int BDDAJNOOLMD)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveRemoveTableOrder", (RpcTarget)1, BDDAJNOOLMD);
	}

	private void ODDOKBAJLAC()
	{
		Behaviour[] array = alwaysEnabledComponents;
		for (int i = 0; i < array.Length; i++)
		{
			array[i].enabled = true;
		}
	}

	[PunRPC]
	public void ReceiveAdoptionSignal()
	{
		customer.DeclineAdoption(CDPAMNIPPEC: false);
	}

	[PunRPC]
	private void RPCSnapPosition(float EANBFHLJLJD, float BLPFFPLBPND)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		((Component)this).transform.position = new Vector3(EANBFHLJLJD, BLPFFPLBPND);
		if (debugNetworkMessages)
		{
			OnlineManager.NetworkLog($"Received {PPHIMGHODKK} position to snap to: {((Component)this).transform.position}", (Object)(object)((Component)this).gameObject);
		}
	}

	public void SendSitDown(Seat FGJPAFDBIIO, int JJPJHIHBOIB)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveSitDown", PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, false), FGJPAFDBIIO.placeable.onlinePlaceable.uniqueId, (byte)(FGJPAFDBIIO.placeable.onlinePlaceable as OnlineSitable).SeatIndex(FGJPAFDBIIO));
	}

	public void NPNENLDCMKH(byte[] OINICMNOLPK)
	{
		KGOGFKJKOCK = OnlineSerializer.Deserialize<TransactionMessage>(OINICMNOLPK);
		if (KGOGFKJKOCK.workerType == -157)
		{
			customer.CompleteItemTransaction(KGOGFKJKOCK.playerNum, KGOGFKJKOCK.itemInstanceOnline.LDFNHFAOHLB(), KGOGFKJKOCK.player, null);
		}
		else
		{
			customer.CompleteItemTransaction(KGOGFKJKOCK.playerNum, KGOGFKJKOCK.itemInstanceOnline.OJJNMENBHNI(), KGOGFKJKOCK.player, StaffManager.DODMEFEHJOK((WorkerType)KGOGFKJKOCK.workerType));
		}
	}

	public void SendActiveOrDisableCustomer(bool DMBFKFLDDLH, int JJPJHIHBOIB)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveActiveOrDisableCustomer", PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, false), DMBFKFLDDLH);
	}

	[PunRPC]
	public void ReceiveFoodRequestAsDrink(int KLBCMDOEMHD)
	{
		if (OnlineObjectsManager.instance.onlineObjects.TryGetValue(KLBCMDOEMHD, out NKJHFIDLEMN))
		{
			customer.SetNewItemRequest((NKJHFIDLEMN as OnlineDrinkDispenser).drinkDispenser.slots[0].itemInstance, GIMHPAANCDH: false, CDPAMNIPPEC: false);
		}
	}

	[PunRPC]
	public void ReceiveIdleAtTable()
	{
		customer.IdleAtTable();
	}

	public void SendTicketPrice(int KHPILKCEHHP)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveTicketPrice", (RpcTarget)1, KHPILKCEHHP);
	}

	[PunRPC]
	public void ReceiveRoomRequest(float GKBHBOHOKPH, int[] KIMIPGLGEKK, bool ANAFBLDDDGD)
	{
		Debug.Log((object)"ReceiveRoomRequest");
		customer.SetNewRoomRequest(new RoomRequest(customer, GKBHBOHOKPH, KIMIPGLGEKK[0], KIMIPGLGEKK[1], KIMIPGLGEKK[2]), CDPAMNIPPEC: false);
		RoomReceptionDesk.RequestRoom(customer);
		RoomReceptionDesk.instance.SetNegotiateRoom(ANAFBLDDDGD, CDPAMNIPPEC: false);
	}

	public void GDHNMCGKOAK(bool DMBFKFLDDLH)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[1] = DMBFKFLDDLH;
		OnlineManager.SendRPC(photonView, " ", (RpcTarget)1, array);
	}

	public void AIMADEKDMIH()
	{
		((MonoBehaviour)this).StartCoroutine(MGDGAAKHAAJ());
	}

	protected override void MNKCLHAIDPB()
	{
		base.MNKCLHAIDPB();
		customer = ((Component)this).GetComponent<Customer>();
		poolCustomer = ((Component)this).GetComponent<PoolCustomer>();
		photonTransformViewClassic = ((Component)this).GetComponent<PhotonTransformViewClassic>();
	}

	public void OKJCIMBOPAI()
	{
		customer.npcHoldItem.IIDNKLLODEB(null);
	}

	public void SendNewHeldItem(ItemInstance DNLMCHDOMOK)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveHeldItem", (RpcTarget)1);
	}

	public void SendBarkInfo(string OLDICOEMFHI, byte BMCMHPALMPN)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveBarkInfo", (RpcTarget)1, OLDICOEMFHI, BMCMHPALMPN);
	}

	public void SendActivateVIP()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveActivateVIP", (RpcTarget)1);
	}

	public void DCCHAJJFHCP(Seat FGJPAFDBIIO, int JJPJHIHBOIB)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		Player player = PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, false);
		object[] array = new object[2];
		array[1] = FGJPAFDBIIO.placeable.onlinePlaceable.uniqueId;
		array[0] = (byte)(FGJPAFDBIIO.placeable.onlinePlaceable as OnlineSitable).MPLLCKCADDI(FGJPAFDBIIO);
		OnlineManager.SendRPC(photonView, "Cat", player, array);
	}

	public void SendFoodInstanceRequest(FoodInstance IJEFIBKNFOE)
	{
		if (IJEFIBKNFOE.JEPBBEBJEFI())
		{
			for (int i = 0; i < DrinkDispensersManager.GGFJGHHHEJC.allDrinkDispensers.Count; i++)
			{
				if (!((Object)(object)DrinkDispensersManager.GGFJGHHHEJC.allDrinkDispensers[i] == (Object)null) && DrinkDispensersManager.GGFJGHHHEJC.allDrinkDispensers[i].slots[0].itemInstance != null && DrinkDispensersManager.GGFJGHHHEJC.allDrinkDispensers[i].slots[0].itemInstance.Equals(IJEFIBKNFOE))
				{
					OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveFoodRequestAsDrink", (RpcTarget)1, DrinkDispensersManager.GGFJGHHHEJC.allDrinkDispensers[i].placeable.onlinePlaceable.uniqueId);
					return;
				}
			}
		}
		else
		{
			for (int j = 0; j < BarMenuInventory.GetInstance().slots.Length; j++)
			{
				if (BarMenuInventory.GetInstance().slots[j].itemInstance != null && BarMenuInventory.GetInstance().slots[j].itemInstance.Equals(IJEFIBKNFOE))
				{
					OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveFoodRequestAsMenuSlot", (RpcTarget)1, j);
					return;
				}
			}
		}
		Debug.Log((object)"Food not found, sending a food instance message!");
		HMFKIEJJENE = new FoodInstanceMessage(IJEFIBKNFOE);
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveFoodInstanceRequest", (RpcTarget)1, OnlineSerializer.Serialize(HMFKIEJJENE));
	}

	public void SendPoolReset()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceivePoolReset", (RpcTarget)1);
	}

	public void SendUpdateMoodState(MoodState MDJMOBOLFHL)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveUpdateMoodState", (RpcTarget)1, (byte)MDJMOBOLFHL);
	}

	[PunRPC]
	public void ReceiveGetUp()
	{
		if ((Object)(object)customer.npc.seat != (Object)null)
		{
			customer.npc.seat.GetUp();
		}
		((Behaviour)photonTransformViewClassic).enabled = true;
	}

	public void SendIdleAtTable()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveIdleAtTable", (RpcTarget)1);
	}

	public void SendNewState(CustomerState EOAONHNCDDO, int JJPJHIHBOIB)
	{
		if (OnlineManager.IsMasterClient())
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveNewState", PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, false), (byte)EOAONHNCDDO);
		}
	}

	public void SendAdoptionSignal()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveAdoptionSignal", (RpcTarget)1);
	}

	[PunRPC]
	public void ReceiveKickWithoutHit()
	{
		customer.KickWithoutForce();
	}

	public void SendGiveRoom(RentedRoom DJMHPGPEFEH, Price OKGHMIPANHK)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveGiveRoom", (RpcTarget)2, DJMHPGPEFEH.JFNMCNCHMEO, OKGHMIPANHK.OOIPLIEJILO());
	}

	public void AIGDICMDEIC()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "on player sleep", (RpcTarget)0);
	}

	[PunRPC]
	public void ReceiveRemoveTableOrder(int BDDAJNOOLMD)
	{
		customer.tableOrder.RemoveTableOrder();
		if (OnlineObjectsManager.instance.onlineObjects.TryGetValue(BDDAJNOOLMD, out NKJHFIDLEMN))
		{
			(NKJHFIDLEMN as OnlineTable).table.serveOrderInTable.customers.Remove(customer);
		}
	}

	public void SendRequestTableOrder(FoodInstance DNLMCHDOMOK, int BDDAJNOOLMD)
	{
		HMFKIEJJENE = new FoodInstanceMessage(DNLMCHDOMOK);
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveRequestTableOrder", (RpcTarget)1, OnlineSerializer.Serialize(HMFKIEJJENE), BDDAJNOOLMD);
	}

	[PunRPC]
	public void ReceiveHeldItem()
	{
		if (customer.currentRequest != null)
		{
			customer.currentItem = customer.currentRequest;
			customer.npcHoldItem.ODDHGLHEHLA = customer.currentItem;
		}
	}

	public void SendAngryEnd()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveAngryEnd", (RpcTarget)1);
	}

	[PunRPC]
	public void ReceiveNewState(byte NJHMBMGKCPL)
	{
		customer.customerState = (CustomerState)NJHMBMGKCPL;
		if (customer.customerState == CustomerState.WaitingAtBar)
		{
			((Behaviour)photonTransformViewClassic).enabled = true;
		}
	}

	public void KHHMMBBOPPG(FoodInstance IJEFIBKNFOE, int JJPJHIHBOIB)
	{
		if (IJEFIBKNFOE != null)
		{
			HMFKIEJJENE = new FoodInstanceMessage(IJEFIBKNFOE);
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			Player player = PhotonNetwork.CurrentRoom.GetPlayer(JJPJHIHBOIB, false);
			object[] array = new object[0];
			array[1] = OnlineSerializer.Serialize(HMFKIEJJENE);
			OnlineManager.DBNIKCMHHMJ(photonView, "LearnBalance", player, array);
		}
	}

	public void SendDereserveSpotReception()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveDereserveSpotReception", (RpcTarget)1);
	}

	public void SendEndEmote()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveEndEmote", (RpcTarget)1);
	}

	public void SendRemoveOccupier(int MOFKEDGAOEE)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveRemoveOccupier", (RpcTarget)1, MOFKEDGAOEE);
	}

	[PunRPC]
	public void ReceiveFoodRequestAsMenuSlot(int LFIKHLNLKDO)
	{
		customer.SetNewItemRequest(BarMenuInventory.GetInstance().slots[LFIKHLNLKDO].itemInstance, GIMHPAANCDH: false, CDPAMNIPPEC: false);
	}

	[PunRPC]
	public void ReceiveUpdateDrinkColorTable()
	{
		customer.tableOrder.UpdateDrinkColorTable();
	}

	[PunRPC]
	public void ReceiveDereserveSpotAdoptionSignal()
	{
		AdoptionSignal.DereserveSpot();
	}

	private void AMOHEFDMMCK()
	{
		if (!OnlineManager.JPPBEIJDCLJ())
		{
			((Behaviour)customer.characterAnimation).enabled = false;
			((Behaviour)customer.npc).enabled = true;
			((Behaviour)customer).enabled = false;
			((Behaviour)poolCustomer).enabled = false;
		}
	}

	[PunRPC]
	public void ReceiveDeclineRoom()
	{
		customer.DeclineRoom(CDPAMNIPPEC: false);
	}

	public void GHMNPODEHPF()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "HaveGoldenTicket", (RpcTarget)0);
	}

	[PunRPC]
	public void ReceiveUpdateMoodState(byte MDJMOBOLFHL)
	{
		customer.UpdateMoodState((MoodState)MDJMOBOLFHL, CDPAMNIPPEC: false);
	}

	public void SendGetUp()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveGetUp", (RpcTarget)1);
	}

	public void SendUpdateDrinkColorTable()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveUpdateDrinkColorTable", (RpcTarget)1);
	}

	public void GPAODPLBNEI(float JGAPFJLPMNJ, float JNFBDOJLDND)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		customer.KickWithForce(new Vector3(JGAPFJLPMNJ, JNFBDOJLDND, 962f));
	}

	public void IJACJEEFAGP()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Staff", (RpcTarget)0);
	}

	public void SendRequestItem(Employee NAKCFGEAGHH)
	{
		if ((Object)(object)NAKCFGEAGHH == (Object)null)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveRequestItem", (RpcTarget)2, byte.MaxValue);
		}
		else
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveRequestItem", (RpcTarget)2, (byte)NAKCFGEAGHH.JFCLIAFAOEK.workerType);
		}
	}

	public void JMFBJBMNLIJ(int BDDAJNOOLMD)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, " : ", (RpcTarget)1, BDDAJNOOLMD);
	}

	public void SendDeclineRoom()
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveDeclineRoom", (RpcTarget)1);
	}

	private void GKMKFJFKDJL()
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		if (debugNetworkMessages)
		{
			string pPHIMGHODKK = PPHIMGHODKK;
			Vector3 position = ((Component)this).transform.position;
			OnlineManager.NetworkLog(pPHIMGHODKK + " state changed, sending snap position: " + ((object)(Vector3)(ref position)).ToString(), (Object)(object)((Component)this).gameObject);
		}
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "RPCSnapPosition", (RpcTarget)1, ((Component)this).transform.position.x, ((Component)this).transform.position.y);
	}

	[PunRPC]
	public void ReceiveBecomeNuisance()
	{
		customer.BecomeNuisance(CDPAMNIPPEC: false);
	}
}
