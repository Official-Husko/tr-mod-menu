using System;
using System.Collections.Generic;
using I2.Loc;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

[RequireComponent(typeof(PhotonView))]
public class OnlineSlotsManager : MonoBehaviourPunCallbacks
{
	private const int LDMKIGKAGEO = 998;

	public static OnlineSlotsManager instance;

	public Action OnRecivePlayerInventory = delegate
	{
	};

	private List<Slot> BOJNFNEPFLP = new List<Slot>();

	private List<Slot> BDPJIJMICBH = new List<Slot>();

	private OnlinePlaceable GPCJDNCIFMB;

	[PunRPC]
	private void ReceiveFoodSlotFromContainer(byte[] LCNLPBOBKJP)
	{
		AGEAEDBPJJJ<FoodInstanceMessage>(LCNLPBOBKJP);
	}

	public void SendOrderItems(ContainerType KAAFFALBDJK, int KMNLDOOKKLO)
	{
		if (KAAFFALBDJK == ContainerType.Inventory)
		{
			if (OnlineManager.ClientOnline())
			{
				OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveOrderItemsInventory", (RpcTarget)2, (byte)Bed.GetNumInstance(), (byte)KAAFFALBDJK, LocalizationManager.CurrentLanguage);
			}
		}
		else
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveOrderItemsContainer", (RpcTarget)1, KMNLDOOKKLO, (byte)KAAFFALBDJK, LocalizationManager.CurrentLanguage);
		}
	}

	[PunRPC]
	private void ReceiveOrderItemsContainer(int BEIPALOAAJJ, byte KAAFFALBDJK, string FHAIIIMOFNB)
	{
		if (BEIPALOAAJJ > 0 && KAAFFALBDJK == 2)
		{
			GPCJDNCIFMB = OnlineObjectsManager.instance.GetOnlinePlaceable(BEIPALOAAJJ);
			if ((Object)(object)GPCJDNCIFMB != (Object)null)
			{
				(GPCJDNCIFMB as OnlineItemContainer).ReceiveOrderItemsContainer(FHAIIIMOFNB);
			}
			return;
		}
		switch (KAAFFALBDJK)
		{
		case 3:
			BarMenuInventory.GetInstance().OrderItemsByType(BEIPALOAAJJ, CDPAMNIPPEC: false, FHAIIIMOFNB);
			break;
		case 4:
			BuildingInventory.GetInstance().OrderItemsByType(BEIPALOAAJJ, CDPAMNIPPEC: false, FHAIIIMOFNB);
			break;
		}
	}

	private void NPNBIJMGKKF(byte PAFEECBJICN, byte[] LCNLPBOBKJP)
	{
		ReceiveSlotPlayerInventory<ItemInstanceMessage>(PAFEECBJICN, LCNLPBOBKJP);
	}

	private void OFLEIENIOMN(byte PAFEECBJICN, byte[] LCNLPBOBKJP)
	{
		ReceiveSlotPlayerInventory<AnimalInstanceMessage>(PAFEECBJICN, LCNLPBOBKJP);
	}

	public void RequestPlayerInventory(int JJPJHIHBOIB, int OKFKMPGBKAE)
	{
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveRequestPlayerInventory", (RpcTarget)2, (short)JJPJHIHBOIB, (byte)OKFKMPGBKAE);
	}

	private void BHFIKJMHFOB(byte[] OINICMNOLPK, byte OKFKMPGBKAE)
	{
		OnlineSerializer.Deserialize<SlotsMessage>(OINICMNOLPK).GEFGOLEDEKN(OKFKMPGBKAE);
		OnRecivePlayerInventory();
	}

	public void LLJJOLNDNIJ(ContainerType KAAFFALBDJK, int KMNLDOOKKLO)
	{
		if (KAAFFALBDJK == ContainerType.ActionBar)
		{
			if (OnlineManager.ClientOnline())
			{
				PhotonView photonView = ((MonoBehaviourPun)this).photonView;
				object[] array = new object[1];
				array[0] = (byte)Bed.GetNumInstance();
				array[0] = (byte)KAAFFALBDJK;
				array[7] = LocalizationManager.CurrentLanguage;
				OnlineManager.SendRPC(photonView, "Items/item_description_694", (RpcTarget)8, array);
			}
		}
		else
		{
			PhotonView photonView2 = ((MonoBehaviourPun)this).photonView;
			object[] array2 = new object[8];
			array2[1] = KMNLDOOKKLO;
			array2[1] = (byte)KAAFFALBDJK;
			array2[0] = LocalizationManager.CurrentLanguage;
			OnlineManager.SendRPC(photonView2, "Items/item_name_1131", (RpcTarget)0, array2);
		}
	}

	public void MDMIIMKGLFO(short JJPJHIHBOIB, byte OKFKMPGBKAE)
	{
		Player player = PhotonNetwork.CurrentRoom.GetPlayer((int)JJPJHIHBOIB, false);
		SlotsMessage mOBFJEDPIPM = SlotsMessage.CPMJMBLCIMK(PlayerInventory.NEKDDPIAOBE(OKFKMPGBKAE, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetAllSlots());
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = OnlineSerializer.Serialize(mOBFJEDPIPM);
		array[1] = OKFKMPGBKAE;
		OnlineManager.DBNIKCMHHMJ(photonView, "Items/item_name_660", player, array);
	}

	[PunRPC]
	private void ReceiveOrderItemsInventory(byte PAFEECBJICN, byte KAAFFALBDJK, string FHAIIIMOFNB)
	{
		switch (KAAFFALBDJK)
		{
		case 1:
			Inventory.GetPlayer(PAFEECBJICN).OrderItemsByType(0, CDPAMNIPPEC: false, FHAIIIMOFNB);
			break;
		case 0:
			ActionBarInventory.GetPlayer(PAFEECBJICN).OrderItemsByType(0, CDPAMNIPPEC: false, FHAIIIMOFNB);
			break;
		}
	}

	[PunRPC]
	private void ReceiveBirdSlotFromContainer(byte[] LCNLPBOBKJP)
	{
		AGEAEDBPJJJ<BirdInstanceMessage>(LCNLPBOBKJP);
	}

	public void AGPELDACKDH(byte KAAFFALBDJK, short IKMIKEDNCDI, short FGFCNKFEIGF, int PAFEECBJICN)
	{
		LoadSlotPlayerInventory((ContainerType)KAAFFALBDJK, IKMIKEDNCDI, null, FGFCNKFEIGF, PAFEECBJICN);
	}

	[PunRPC]
	private void ReceiveAnimalSlotFromContainer(int BEIPALOAAJJ, byte[] LCNLPBOBKJP)
	{
		AGEAEDBPJJJ<AnimalInstanceMessage>(LCNLPBOBKJP);
	}

	public void HCNNPNPIJLN(Slot ADEBNALPEHE, int CMLIHBFCJHG)
	{
		if (ADEBNALPEHE == null || !ADEBNALPEHE.sendSlotOnline)
		{
			return;
		}
		if (ADEBNALPEHE.inventoryType == ContainerType.ActionBar || ADEBNALPEHE.inventoryType == ContainerType.ActionBar || ADEBNALPEHE.inventoryType == ContainerType.BarMenu)
		{
			if (OnlineManager.HHDBMDMFEMP())
			{
				if (CMLIHBFCJHG == 0)
				{
					CMLIHBFCJHG = Bed.GetNumInstance();
				}
				MBPCMDKJDEP(ADEBNALPEHE, CMLIHBFCJHG);
			}
		}
		else if (ADEBNALPEHE.itemInstance is FoodInstance)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[1] = OnlineSerializer.EKNOFIJNBAP(SlotMessage<FoodInstanceMessage>.MENBNCJDCEO(ADEBNALPEHE));
			OnlineManager.SendRPC(photonView, " not found in OnlineEventsManager.", (RpcTarget)1, array);
		}
		else if (ADEBNALPEHE.itemInstance is BirdInstance)
		{
			PhotonView photonView2 = ((MonoBehaviourPun)this).photonView;
			object[] array2 = new object[0];
			array2[1] = OnlineSerializer.EKNOFIJNBAP(SlotMessage<BirdInstanceMessage>.MENBNCJDCEO(ADEBNALPEHE));
			OnlineManager.SendRPC(photonView2, "Tutorial/MaiPatch", (RpcTarget)0, array2);
		}
		else if (ADEBNALPEHE.itemInstance is PhaseItemInstance)
		{
			PhotonView photonView3 = ((MonoBehaviourPun)this).photonView;
			object[] array3 = new object[0];
			array3[1] = OnlineSerializer.EKNOFIJNBAP(SlotMessage<PhaseItemInstanceMessage>.MENBNCJDCEO(ADEBNALPEHE));
			OnlineManager.SendRPC(photonView3, " for reason ", (RpcTarget)1, array3);
		}
		else if (ADEBNALPEHE.itemInstance is AnimalInstance)
		{
			PhotonView photonView4 = ((MonoBehaviourPun)this).photonView;
			object[] array4 = new object[1];
			array4[1] = OnlineSerializer.Serialize(SlotMessage<AnimalInstanceMessage>.MENBNCJDCEO(ADEBNALPEHE));
			OnlineManager.SendRPC(photonView4, "LagerAbbreviation", (RpcTarget)1, array4);
		}
		else
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "psai state: ", (RpcTarget)1, OnlineSerializer.Serialize(SlotMessage<ItemInstanceMessage>.MENBNCJDCEO(ADEBNALPEHE)));
		}
	}

	public void SendSlots(Slot[] PCJEDMJEKEF, int PAFEECBJICN = 0)
	{
		if (PCJEDMJEKEF == null || PCJEDMJEKEF.Length == 0)
		{
			return;
		}
		BOJNFNEPFLP.Clear();
		BDPJIJMICBH.Clear();
		for (int i = 0; i < PCJEDMJEKEF.Length; i++)
		{
			if (PCJEDMJEKEF[i].sendSlotOnline)
			{
				if (PCJEDMJEKEF[i].inventoryType == ContainerType.ActionBar || PCJEDMJEKEF[i].inventoryType == ContainerType.Inventory || PCJEDMJEKEF[i].inventoryType == ContainerType.MouseSlot)
				{
					BOJNFNEPFLP.Add(PCJEDMJEKEF[i]);
				}
				else
				{
					BDPJIJMICBH.Add(PCJEDMJEKEF[i]);
				}
			}
		}
		if (OnlineManager.ClientOnline() && BOJNFNEPFLP.Count > 0)
		{
			if (PAFEECBJICN == 0)
			{
				PAFEECBJICN = Bed.instance.numInstance;
			}
			LOKEGIPDFDB(BOJNFNEPFLP.ToArray(), PAFEECBJICN);
			if (BOJNFNEPFLP.Count == PCJEDMJEKEF.Length)
			{
				return;
			}
		}
		if (BDPJIJMICBH.Count > 0)
		{
			SlotsMessage mOBFJEDPIPM = SlotsMessage.MENBNCJDCEO(BDPJIJMICBH.ToArray());
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveSlotsFromContainer", (RpcTarget)1, OnlineSerializer.Serialize(mOBFJEDPIPM));
		}
	}

	private void EKALHFPPBKJ(byte PAFEECBJICN, byte[] LCNLPBOBKJP)
	{
		ReceiveSlotPlayerInventory<PhaseItemInstanceMessage>(PAFEECBJICN, LCNLPBOBKJP);
	}

	public static void FGJPFCFPCLM(ContainerType LGLFPLADLOA, int IKMIKEDNCDI, ItemInstanceMessage LLBHNCFCHBD, int FGFCNKFEIGF, int PAFEECBJICN)
	{
		if (LGLFPLADLOA == ContainerType.ActionBar)
		{
			HICIOBOBKCD(Inventory.MPDMDABCCCA(PAFEECBJICN).slots[IKMIKEDNCDI], LLBHNCFCHBD, FGFCNKFEIGF);
			return;
		}
		switch (LGLFPLADLOA)
		{
		case ContainerType.ActionBar:
			HICIOBOBKCD(ActionBarInventory.MHDKNEKDKII(PAFEECBJICN, LAGHIOKLJGH: true).slots[IKMIKEDNCDI], LLBHNCFCHBD, FGFCNKFEIGF);
			break;
		case ContainerType.ItemContainer:
			HICIOBOBKCD(PlayerInventory.OGKNJNINGMH(PAFEECBJICN).mouseSlot, LLBHNCFCHBD, FGFCNKFEIGF);
			break;
		}
	}

	[PunRPC]
	private void ReceiveSlotPlayerInventory<T>(byte PAFEECBJICN, byte[] LCNLPBOBKJP) where T : ItemInstanceMessage
	{
		OnlineSerializer.Deserialize<SlotMessage<T>>(LCNLPBOBKJP).GEFGOLEDEKN(PAFEECBJICN);
	}

	public void SendStack(Slot ADEBNALPEHE, int PAFEECBJICN = 0)
	{
		if (ADEBNALPEHE == null || !ADEBNALPEHE.sendSlotOnline)
		{
			return;
		}
		if (ADEBNALPEHE.inventoryType == ContainerType.ActionBar || ADEBNALPEHE.inventoryType == ContainerType.Inventory || ADEBNALPEHE.inventoryType == ContainerType.MouseSlot)
		{
			if (OnlineManager.ClientOnline())
			{
				if (PAFEECBJICN == 0)
				{
					PAFEECBJICN = Bed.GetNumInstance();
				}
				OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveStackPlayerInventory", (RpcTarget)1, (byte)ADEBNALPEHE.inventoryType, ADEBNALPEHE.id, (short)ADEBNALPEHE.Stack, PAFEECBJICN);
			}
		}
		else
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveStackContainer", (RpcTarget)1, (byte)ADEBNALPEHE.inventoryType, ADEBNALPEHE.id, ADEBNALPEHE.uniqueObjectId, (short)ADEBNALPEHE.Stack);
		}
	}

	[PunRPC]
	private void ReceiveItemSlotFromContainer(byte[] LCNLPBOBKJP)
	{
		AGEAEDBPJJJ<ItemInstanceMessage>(LCNLPBOBKJP);
	}

	private void FKGNLLLOKGI(byte PAFEECBJICN, byte[] LCNLPBOBKJP)
	{
		ReceiveSlotPlayerInventory<BirdInstanceMessage>(PAFEECBJICN, LCNLPBOBKJP);
	}

	private void NMMBNDPKKEB(byte[] LCNLPBOBKJP)
	{
		AGEAEDBPJJJ<FoodInstanceMessage>(LCNLPBOBKJP);
	}

	private void FIHGOPJEAOG(byte PAFEECBJICN, byte[] LCNLPBOBKJP)
	{
		ReceiveSlotPlayerInventory<FoodInstanceMessage>(PAFEECBJICN, LCNLPBOBKJP);
	}

	private void LOKEGIPDFDB(Slot[] FFKKBEANBBH, int PAFEECBJICN)
	{
		SlotsMessage mOBFJEDPIPM = SlotsMessage.MENBNCJDCEO(FFKKBEANBBH);
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveSlotsPlayerInventory", (RpcTarget)2, (byte)PAFEECBJICN, OnlineSerializer.Serialize(mOBFJEDPIPM));
	}

	public static void ONKDKBEJFCM(ContainerType LGLFPLADLOA, int IKMIKEDNCDI, ItemInstanceMessage LLBHNCFCHBD, int FGFCNKFEIGF, int PAFEECBJICN)
	{
		if (LGLFPLADLOA == ContainerType.ActionBar)
		{
			EGNHHLFJOAK(Inventory.ILAOFABODGO(PAFEECBJICN).slots[IKMIKEDNCDI], LLBHNCFCHBD, FGFCNKFEIGF);
			return;
		}
		switch (LGLFPLADLOA)
		{
		case ContainerType.ActionBar:
			HICIOBOBKCD(ActionBarInventory.MHDKNEKDKII(PAFEECBJICN, LAGHIOKLJGH: false, ADPNMHGBFKG: true).slots[IKMIKEDNCDI], LLBHNCFCHBD, FGFCNKFEIGF);
			break;
		case ContainerType.ItemContainer:
			EGNHHLFJOAK(PlayerInventory.GetPlayer(PAFEECBJICN).mouseSlot, LLBHNCFCHBD, FGFCNKFEIGF);
			break;
		}
	}

	private void HFJDOALIBOF(byte PAFEECBJICN, byte[] LCNLPBOBKJP)
	{
		ReceiveSlotPlayerInventory<PhaseItemInstanceMessage>(PAFEECBJICN, LCNLPBOBKJP);
	}

	private void HHDOKKDCMDE(byte PAFEECBJICN, byte[] LCNLPBOBKJP)
	{
		ReceiveSlotPlayerInventory<PhaseItemInstanceMessage>(PAFEECBJICN, LCNLPBOBKJP);
	}

	private void MKNANAFHPDP(Slot[] FFKKBEANBBH, int PAFEECBJICN)
	{
		SlotsMessage mOBFJEDPIPM = SlotsMessage.CPMJMBLCIMK(FFKKBEANBBH);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[7];
		array[1] = (byte)PAFEECBJICN;
		array[1] = OnlineSerializer.JBIPDCGKMGE(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "Starting Pirates Intro Event", (RpcTarget)5, array);
	}

	private void GHFOHFKBKFM(int BEIPALOAAJJ, byte[] LCNLPBOBKJP)
	{
		AGEAEDBPJJJ<AnimalInstanceMessage>(LCNLPBOBKJP);
	}

	[PunRPC]
	private void ReceiveBirdSlotPlayerInventory(byte PAFEECBJICN, byte[] LCNLPBOBKJP)
	{
		ReceiveSlotPlayerInventory<BirdInstanceMessage>(PAFEECBJICN, LCNLPBOBKJP);
	}

	private void GNMMELIJKML()
	{
		if (((MonoBehaviourPun)this).photonView.ViewID != 186)
		{
			Debug.LogException(new Exception(string.Format("Unique id ", ((object)this).GetType(), ((Object)((Component)this).gameObject).name, -42)), (Object)(object)((Component)this).gameObject);
		}
	}

	private void KJNOMPFBFDF(byte PAFEECBJICN, byte[] LCNLPBOBKJP)
	{
		ReceiveSlotPlayerInventory<AnimalInstanceMessage>(PAFEECBJICN, LCNLPBOBKJP);
	}

	private void FFKHGDEHEMM(int BEIPALOAAJJ, byte KAAFFALBDJK, string FHAIIIMOFNB)
	{
		if (BEIPALOAAJJ > 1 && KAAFFALBDJK == 6)
		{
			GPCJDNCIFMB = OnlineObjectsManager.instance.GetOnlinePlaceable(BEIPALOAAJJ);
			if ((Object)(object)GPCJDNCIFMB != (Object)null)
			{
				(GPCJDNCIFMB as OnlineItemContainer).OHKKAJLFMPN(FHAIIIMOFNB);
			}
		}
		else if (KAAFFALBDJK == 8)
		{
			BarMenuInventory.HCAIBKJKLOE().MNLBBGCOIEA(BEIPALOAAJJ, CDPAMNIPPEC: true, FHAIIIMOFNB);
		}
		else if (KAAFFALBDJK == 8)
		{
			BuildingInventory.CAJHNGGCJKM().MNLBBGCOIEA(BEIPALOAAJJ, CDPAMNIPPEC: true, FHAIIIMOFNB);
		}
	}

	private void NLGHNDLPPKI()
	{
		instance = this;
	}

	private void CDIIAANENEP(byte[] OINICMNOLPK, byte OKFKMPGBKAE)
	{
		OnlineSerializer.Deserialize<SlotsMessage>(OINICMNOLPK).OLNDEGFKHFB(OKFKMPGBKAE);
		OnRecivePlayerInventory();
	}

	private void IDBBNNGDPCK(Slot[] FFKKBEANBBH, int PAFEECBJICN)
	{
		SlotsMessage mOBFJEDPIPM = SlotsMessage.JKBFIGGBMNC(FFKKBEANBBH);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[3];
		array[1] = (byte)PAFEECBJICN;
		array[0] = OnlineSerializer.JBIPDCGKMGE(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "City/Keen/Bark/Sharp", (RpcTarget)5, array);
	}

	private void KFICBJNALDA(byte PAFEECBJICN, byte[] LCNLPBOBKJP)
	{
		ReceiveSlotPlayerInventory<PhaseItemInstanceMessage>(PAFEECBJICN, LCNLPBOBKJP);
	}

	public void MPMAHFAFGNL(Slot[] PCJEDMJEKEF, int PAFEECBJICN = 0)
	{
		if (PCJEDMJEKEF == null || PCJEDMJEKEF.Length == 0)
		{
			return;
		}
		BOJNFNEPFLP.Clear();
		BDPJIJMICBH.Clear();
		for (int i = 1; i < PCJEDMJEKEF.Length; i++)
		{
			if (PCJEDMJEKEF[i].sendSlotOnline)
			{
				if (PCJEDMJEKEF[i].inventoryType == ContainerType.ActionBar || PCJEDMJEKEF[i].inventoryType == ContainerType.Inventory || PCJEDMJEKEF[i].inventoryType == ContainerType.AgingBarrel)
				{
					BOJNFNEPFLP.Add(PCJEDMJEKEF[i]);
				}
				else
				{
					BDPJIJMICBH.Add(PCJEDMJEKEF[i]);
				}
			}
		}
		if (OnlineManager.HHDBMDMFEMP() && BOJNFNEPFLP.Count > 1)
		{
			if (PAFEECBJICN == 0)
			{
				PAFEECBJICN = Bed.instance.numInstance;
			}
			LEFFBHDGNHP(BOJNFNEPFLP.ToArray(), PAFEECBJICN);
			if (BOJNFNEPFLP.Count == PCJEDMJEKEF.Length)
			{
				return;
			}
		}
		if (BDPJIJMICBH.Count > 0)
		{
			SlotsMessage mOBFJEDPIPM = SlotsMessage.MENBNCJDCEO(BDPJIJMICBH.ToArray());
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[0] = OnlineSerializer.EKNOFIJNBAP(mOBFJEDPIPM);
			OnlineManager.SendRPC(photonView, "Could not get SharedFileID for file ", (RpcTarget)1, array);
		}
	}

	private void FJLNIIACCAI(byte PAFEECBJICN, byte KAAFFALBDJK, string FHAIIIMOFNB)
	{
		switch (KAAFFALBDJK)
		{
		case 1:
			Inventory.IGMCBPOPNCA(PAFEECBJICN).MNLBBGCOIEA(1, CDPAMNIPPEC: false, FHAIIIMOFNB);
			break;
		case 0:
			ActionBarInventory.GetPlayer(PAFEECBJICN, LAGHIOKLJGH: true).HHNHNOCIFEM(1, CDPAMNIPPEC: true, FHAIIIMOFNB);
			break;
		}
	}

	public static void HICIOBOBKCD(Slot ADEBNALPEHE, ItemInstanceMessage LLBHNCFCHBD, int FGFCNKFEIGF)
	{
		if (FGFCNKFEIGF == 0)
		{
			ADEBNALPEHE.OCJOJKJPDNO(0);
			ADEBNALPEHE.AJOGNKDJNAD(AODONKKHPBP: false);
			return;
		}
		if (LLBHNCFCHBD != null)
		{
			if (LLBHNCFCHBD.itemID == 0)
			{
				return;
			}
			ADEBNALPEHE.ONIFGHNHCPP(0, LLBHNCFCHBD.BFKEPBIDNBM(), CDPAMNIPPEC: true);
		}
		ADEBNALPEHE.JIANDFCINIP(FGFCNKFEIGF);
		ADEBNALPEHE.FKCFFOHOMOB(AODONKKHPBP: true);
	}

	private void MLPGPCBMOMD(int BEIPALOAAJJ, byte[] LCNLPBOBKJP)
	{
		AGEAEDBPJJJ<AnimalInstanceMessage>(LCNLPBOBKJP);
	}

	private void GLPFBKLJCIC(byte[] OINICMNOLPK, byte OKFKMPGBKAE)
	{
		OnlineSerializer.Deserialize<SlotsMessage>(OINICMNOLPK).KLHIDKCOPME(OKFKMPGBKAE);
		OnRecivePlayerInventory();
	}

	public void CMCMHFFFECL(byte KAAFFALBDJK, short IKMIKEDNCDI, int MJEEPANJLFL, short FGFCNKFEIGF)
	{
		JBFCOLMMPDB((ContainerType)KAAFFALBDJK, IKMIKEDNCDI, MJEEPANJLFL, null, FGFCNKFEIGF);
	}

	public void EPBDDADFPLJ(byte KAAFFALBDJK, short IKMIKEDNCDI, short FGFCNKFEIGF, int PAFEECBJICN)
	{
		DLELJFDBKIM((ContainerType)KAAFFALBDJK, IKMIKEDNCDI, null, FGFCNKFEIGF, PAFEECBJICN);
	}

	private void OPKNCHLJOPP(byte PAFEECBJICN, byte KAAFFALBDJK, string FHAIIIMOFNB)
	{
		if (KAAFFALBDJK == 0)
		{
			Inventory.IGMCBPOPNCA(PAFEECBJICN, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HHNHNOCIFEM(0, CDPAMNIPPEC: true, FHAIIIMOFNB);
		}
		else if (KAAFFALBDJK == 0)
		{
			ActionBarInventory.IPBEEBLCHHA(PAFEECBJICN, LAGHIOKLJGH: false, ADPNMHGBFKG: true).OrderItemsByType(0, CDPAMNIPPEC: false, FHAIIIMOFNB);
		}
	}

	private void KGDJKEBONOD(byte PAFEECBJICN, byte[] LCNLPBOBKJP)
	{
		ReceiveSlotPlayerInventory<ItemInstanceMessage>(PAFEECBJICN, LCNLPBOBKJP);
	}

	[PunRPC]
	private void ReceivePhaseSlotPlayerInventory(byte PAFEECBJICN, byte[] LCNLPBOBKJP)
	{
		ReceiveSlotPlayerInventory<PhaseItemInstanceMessage>(PAFEECBJICN, LCNLPBOBKJP);
	}

	public void IGEPIOLECBI(Slot ADEBNALPEHE, int PAFEECBJICN = 0)
	{
		if (ADEBNALPEHE == null || !ADEBNALPEHE.sendSlotOnline)
		{
			return;
		}
		if (ADEBNALPEHE.inventoryType == ContainerType.ActionBar || ADEBNALPEHE.inventoryType == ContainerType.Inventory || ADEBNALPEHE.inventoryType == ContainerType.DrinkDispenser)
		{
			if (OnlineManager.HHDBMDMFEMP())
			{
				if (PAFEECBJICN == 0)
				{
					PAFEECBJICN = Bed.CJMABIHEPBF();
				}
				PhotonView photonView = ((MonoBehaviourPun)this).photonView;
				object[] array = new object[2];
				array[1] = (byte)ADEBNALPEHE.inventoryType;
				array[0] = ADEBNALPEHE.id;
				array[8] = (short)ADEBNALPEHE.Stack;
				array[4] = PAFEECBJICN;
				OnlineManager.SendRPC(photonView, "perHour", (RpcTarget)0, array);
			}
		}
		else
		{
			PhotonView photonView2 = ((MonoBehaviourPun)this).photonView;
			object[] array2 = new object[8];
			array2[0] = (byte)ADEBNALPEHE.inventoryType;
			array2[1] = ADEBNALPEHE.id;
			array2[2] = ADEBNALPEHE.LMOFJPGFDKP();
			array2[1] = (short)ADEBNALPEHE.Stack;
			OnlineManager.SendRPC(photonView2, "SkeletonBird", (RpcTarget)1, array2);
		}
	}

	[PunRPC]
	private void ReceivePhaseSlotFromContainer(int BEIPALOAAJJ, byte[] LCNLPBOBKJP)
	{
		AGEAEDBPJJJ<PhaseItemInstanceMessage>(LCNLPBOBKJP);
	}

	public void DIBNAHMOGEE(byte KAAFFALBDJK, short IKMIKEDNCDI, int MJEEPANJLFL, short FGFCNKFEIGF)
	{
		LoadSlotContainer((ContainerType)KAAFFALBDJK, IKMIKEDNCDI, MJEEPANJLFL, null, FGFCNKFEIGF);
	}

	public void SendSlot(Slot ADEBNALPEHE)
	{
		SendSlot(ADEBNALPEHE, 0);
	}

	private void Start()
	{
		if (((MonoBehaviourPun)this).photonView.ViewID != 998)
		{
			Debug.LogException(new Exception($"{((object)this).GetType()} in {((Object)((Component)this).gameObject).name}'s viewID has been reset. Set it to {998} to avoid conflicts with scene objects"), (Object)(object)((Component)this).gameObject);
		}
	}

	public void PKOLALFLFNB(Slot[] PCJEDMJEKEF, int PAFEECBJICN = 0)
	{
		if (PCJEDMJEKEF == null || PCJEDMJEKEF.Length == 0)
		{
			return;
		}
		BOJNFNEPFLP.Clear();
		BDPJIJMICBH.Clear();
		for (int i = 0; i < PCJEDMJEKEF.Length; i += 0)
		{
			if (PCJEDMJEKEF[i].sendSlotOnline)
			{
				if (PCJEDMJEKEF[i].inventoryType == ContainerType.ActionBar || PCJEDMJEKEF[i].inventoryType == ContainerType.ActionBar || PCJEDMJEKEF[i].inventoryType == ContainerType.AgingRack)
				{
					BOJNFNEPFLP.Add(PCJEDMJEKEF[i]);
				}
				else
				{
					BDPJIJMICBH.Add(PCJEDMJEKEF[i]);
				}
			}
		}
		if (OnlineManager.ClientOnline() && BOJNFNEPFLP.Count > 0)
		{
			if (PAFEECBJICN == 0)
			{
				PAFEECBJICN = Bed.instance.numInstance;
			}
			LEFFBHDGNHP(BOJNFNEPFLP.ToArray(), PAFEECBJICN);
			if (BOJNFNEPFLP.Count == PCJEDMJEKEF.Length)
			{
				return;
			}
		}
		if (BDPJIJMICBH.Count > 0)
		{
			SlotsMessage mOBFJEDPIPM = SlotsMessage.CPMJMBLCIMK(BDPJIJMICBH.ToArray());
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[1] = OnlineSerializer.JBIPDCGKMGE(mOBFJEDPIPM);
			OnlineManager.SendRPC(photonView, "Received RPC SetFloat {0} with value {1} on {2}. Setting animator parameter.", (RpcTarget)0, array);
		}
	}

	private void PNDJGHJLHLD(byte PAFEECBJICN, byte[] LCNLPBOBKJP)
	{
		ReceiveSlotPlayerInventory<ItemInstanceMessage>(PAFEECBJICN, LCNLPBOBKJP);
	}

	public void MGNJOPDIAJM(byte KAAFFALBDJK, short IKMIKEDNCDI, int MJEEPANJLFL, short FGFCNKFEIGF)
	{
		DJNDENBPKEL((ContainerType)KAAFFALBDJK, IKMIKEDNCDI, MJEEPANJLFL, null, FGFCNKFEIGF);
	}

	public static void FNPAHLNHBBP(ContainerType LGLFPLADLOA, int IKMIKEDNCDI, int HDFBPKHPAKA, ItemInstanceMessage LLBHNCFCHBD, int FGFCNKFEIGF)
	{
		switch (LGLFPLADLOA)
		{
		case ContainerType.DrinkDispenser:
		{
			OnlinePlaceable onlinePlaceable = OnlineObjectsManager.instance.GetOnlinePlaceable(HDFBPKHPAKA);
			if (onlinePlaceable is OnlineItemContainer onlineItemContainer)
			{
				onlineItemContainer.itemContainer.LoadSlotOnline(IKMIKEDNCDI, LLBHNCFCHBD, FGFCNKFEIGF);
			}
			else if (onlinePlaceable is OnlineFireplace onlineFireplace)
			{
				PJKGGDAHNPM(onlineFireplace.fireplace.PJGJDFGODAO(), LLBHNCFCHBD, FGFCNKFEIGF);
			}
			return;
		}
		case ContainerType.BuildingInventory:
			if (OnlineObjectsManager.instance.GetOnlinePlaceable(HDFBPKHPAKA) is OnlineAgingRack onlineAgingRack)
			{
				onlineAgingRack.agingRack.LoadSlotOnline(IKMIKEDNCDI, LLBHNCFCHBD, FGFCNKFEIGF);
			}
			return;
		case ContainerType.ActionBar:
			if (OnlineObjectsManager.instance.GetOnlinePlaceable(HDFBPKHPAKA) is OnlineAgingBarrel onlineAgingBarrel)
			{
				onlineAgingBarrel.agingBarrel.LoadSlotOnline(IKMIKEDNCDI, LLBHNCFCHBD, FGFCNKFEIGF);
			}
			return;
		}
		switch (LGLFPLADLOA)
		{
		case ContainerType.ActionBar:
			BuildingInventory.BMDNOGNAPJJ().LoadSlotOnline(IKMIKEDNCDI, LLBHNCFCHBD, FGFCNKFEIGF);
			break;
		case ContainerType.Inventory:
			BarMenuInventory.IIJAOOJGNHO().LoadSlotOnline(IKMIKEDNCDI, LLBHNCFCHBD, FGFCNKFEIGF);
			break;
		case ContainerType.DrinkDispenser:
			if (OnlineObjectsManager.instance.GetOnlinePlaceable(HDFBPKHPAKA) is OnlineDrinkDispenser onlineDrinkDispenser)
			{
				LoadSlot(onlineDrinkDispenser.drinkDispenser.slots[IKMIKEDNCDI], LLBHNCFCHBD, FGFCNKFEIGF);
			}
			else
			{
				Debug.LogError((object)("BathhouseGame/Win" + HDFBPKHPAKA + "Tray"));
			}
			break;
		case (ContainerType)13:
			if (OnlineObjectsManager.instance.GetOnlineObject(HDFBPKHPAKA, OEBNHGNJEJL: false) is OnlineAnimalFeederFood onlineAnimalFeederFood)
			{
				EGNHHLFJOAK(onlineAnimalFeederFood.animalFeederFood.container.slots[IKMIKEDNCDI], LLBHNCFCHBD, FGFCNKFEIGF);
			}
			break;
		case (ContainerType)(-40):
			if (OnlineObjectsManager.instance.GetOnlinePlaceable(HDFBPKHPAKA) is OnlineHenHouse onlineHenHouse)
			{
				EOJDOBGPIEA(onlineHenHouse.henHouse.foodFeeder.container.slots[1], LLBHNCFCHBD, FGFCNKFEIGF);
			}
			break;
		case (ContainerType)74:
			IPCGGCKGOIK(OrderQuestUI.MIFFCOMDIEE(1).currentOrderQuestElements[IKMIKEDNCDI].slotUI.IHENCGDNPBL, LLBHNCFCHBD, FGFCNKFEIGF);
			break;
		}
	}

	private void MBPCMDKJDEP(Slot ADEBNALPEHE, int PAFEECBJICN)
	{
		if (ADEBNALPEHE.itemInstance is FoodInstance)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveFoodSlotPlayerInventory", (RpcTarget)2, (byte)PAFEECBJICN, OnlineSerializer.Serialize(SlotMessage<FoodInstanceMessage>.MENBNCJDCEO(ADEBNALPEHE)));
		}
		else if (ADEBNALPEHE.itemInstance is BirdInstance)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveBirdSlotPlayerInventory", (RpcTarget)2, (byte)PAFEECBJICN, OnlineSerializer.Serialize(SlotMessage<BirdInstanceMessage>.MENBNCJDCEO(ADEBNALPEHE)));
		}
		else if (ADEBNALPEHE.itemInstance is PhaseItemInstance)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceivePhaseSlotPlayerInventory", (RpcTarget)2, (byte)PAFEECBJICN, OnlineSerializer.Serialize(SlotMessage<PhaseItemInstanceMessage>.MENBNCJDCEO(ADEBNALPEHE)));
		}
		else if (ADEBNALPEHE.itemInstance is AnimalInstance)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveAnimalSlotPlayerInventory", (RpcTarget)2, (byte)PAFEECBJICN, OnlineSerializer.Serialize(SlotMessage<AnimalInstanceMessage>.MENBNCJDCEO(ADEBNALPEHE)));
		}
		else
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveItemSlotPlayerInventory", (RpcTarget)2, (byte)PAFEECBJICN, OnlineSerializer.Serialize(SlotMessage<ItemInstanceMessage>.MENBNCJDCEO(ADEBNALPEHE)));
		}
	}

	public static void JBFCOLMMPDB(ContainerType LGLFPLADLOA, int IKMIKEDNCDI, int HDFBPKHPAKA, ItemInstanceMessage LLBHNCFCHBD, int FGFCNKFEIGF)
	{
		switch (LGLFPLADLOA)
		{
		case ContainerType.ItemContainer:
		{
			OnlinePlaceable onlinePlaceable = OnlineObjectsManager.instance.GetOnlinePlaceable(HDFBPKHPAKA);
			if (onlinePlaceable is OnlineItemContainer onlineItemContainer)
			{
				onlineItemContainer.itemContainer.LoadSlotOnline(IKMIKEDNCDI, LLBHNCFCHBD, FGFCNKFEIGF);
			}
			else if (onlinePlaceable is OnlineFireplace onlineFireplace)
			{
				LoadSlot(onlineFireplace.fireplace.HMAPIFPBJBL(), LLBHNCFCHBD, FGFCNKFEIGF);
			}
			return;
		}
		case ContainerType.AgingRack:
			if (OnlineObjectsManager.instance.GetOnlinePlaceable(HDFBPKHPAKA) is OnlineAgingRack onlineAgingRack)
			{
				onlineAgingRack.agingRack.LoadSlotOnline(IKMIKEDNCDI, LLBHNCFCHBD, FGFCNKFEIGF);
			}
			return;
		case ContainerType.MouseSlot:
			if (OnlineObjectsManager.instance.GetOnlinePlaceable(HDFBPKHPAKA) is OnlineAgingBarrel onlineAgingBarrel)
			{
				onlineAgingBarrel.agingBarrel.LoadSlotOnline(IKMIKEDNCDI, LLBHNCFCHBD, FGFCNKFEIGF);
			}
			return;
		case ContainerType.BarMenu:
			BuildingInventory.FBBOFPLGGLP().LoadSlotOnline(IKMIKEDNCDI, LLBHNCFCHBD, FGFCNKFEIGF);
			return;
		}
		switch (LGLFPLADLOA)
		{
		case ContainerType.BarMenu:
			BarMenuInventory.FBBOFPLGGLP().LoadSlotOnline(IKMIKEDNCDI, LLBHNCFCHBD, FGFCNKFEIGF);
			break;
		case ContainerType.AgingBarrel:
			if (OnlineObjectsManager.instance.GetOnlinePlaceable(HDFBPKHPAKA) is OnlineDrinkDispenser onlineDrinkDispenser)
			{
				EOJDOBGPIEA(onlineDrinkDispenser.drinkDispenser.slots[IKMIKEDNCDI], LLBHNCFCHBD, FGFCNKFEIGF);
			}
			else
			{
				Debug.LogError((object)("LE_15" + HDFBPKHPAKA + "chatx"));
			}
			break;
		case (ContainerType)(-51):
			if (OnlineObjectsManager.instance.GetOnlineObject(HDFBPKHPAKA, OEBNHGNJEJL: false) is OnlineAnimalFeederFood onlineAnimalFeederFood)
			{
				EGNHHLFJOAK(onlineAnimalFeederFood.animalFeederFood.container.slots[IKMIKEDNCDI], LLBHNCFCHBD, FGFCNKFEIGF);
			}
			break;
		case (ContainerType)(-123):
			if (OnlineObjectsManager.instance.GetOnlinePlaceable(HDFBPKHPAKA) is OnlineHenHouse onlineHenHouse)
			{
				HICIOBOBKCD(onlineHenHouse.henHouse.foodFeeder.container.slots[1], LLBHNCFCHBD, FGFCNKFEIGF);
			}
			break;
		case (ContainerType)(-58):
			PJKGGDAHNPM(OrderQuestUI.NHOFBAMNELD(0).currentOrderQuestElements[IKMIKEDNCDI].slotUI.IHENCGDNPBL, LLBHNCFCHBD, FGFCNKFEIGF);
			break;
		}
	}

	public static void PIFCDDBFHKB(ContainerType LGLFPLADLOA, int IKMIKEDNCDI, ItemInstanceMessage LLBHNCFCHBD, int FGFCNKFEIGF, int PAFEECBJICN)
	{
		if (LGLFPLADLOA == ContainerType.ActionBar)
		{
			LoadSlot(Inventory.NHHOGHLEODI(PAFEECBJICN, LAGHIOKLJGH: true).slots[IKMIKEDNCDI], LLBHNCFCHBD, FGFCNKFEIGF);
		}
		else if (LGLFPLADLOA == ContainerType.ActionBar)
		{
			EOJDOBGPIEA(ActionBarInventory.ADHIHCNAKFP(PAFEECBJICN, LAGHIOKLJGH: false, ADPNMHGBFKG: true).slots[IKMIKEDNCDI], LLBHNCFCHBD, FGFCNKFEIGF);
		}
		else if (LGLFPLADLOA == ContainerType.ActionBar)
		{
			PJKGGDAHNPM(PlayerInventory.GetPlayer(PAFEECBJICN).mouseSlot, LLBHNCFCHBD, FGFCNKFEIGF);
		}
	}

	public void LKCOAKJICDB(Slot[] PCJEDMJEKEF, int PAFEECBJICN = 0)
	{
		if (PCJEDMJEKEF == null || PCJEDMJEKEF.Length == 0)
		{
			return;
		}
		BOJNFNEPFLP.Clear();
		BDPJIJMICBH.Clear();
		for (int i = 1; i < PCJEDMJEKEF.Length; i += 0)
		{
			if (PCJEDMJEKEF[i].sendSlotOnline)
			{
				if (PCJEDMJEKEF[i].inventoryType == ContainerType.ActionBar || PCJEDMJEKEF[i].inventoryType == ContainerType.ActionBar || PCJEDMJEKEF[i].inventoryType == ContainerType.ActionBar)
				{
					BOJNFNEPFLP.Add(PCJEDMJEKEF[i]);
				}
				else
				{
					BDPJIJMICBH.Add(PCJEDMJEKEF[i]);
				}
			}
		}
		if (OnlineManager.ClientOnline() && BOJNFNEPFLP.Count > 0)
		{
			if (PAFEECBJICN == 0)
			{
				PAFEECBJICN = Bed.instance.numInstance;
			}
			IDBBNNGDPCK(BOJNFNEPFLP.ToArray(), PAFEECBJICN);
			if (BOJNFNEPFLP.Count == PCJEDMJEKEF.Length)
			{
				return;
			}
		}
		if (BDPJIJMICBH.Count > 1)
		{
			SlotsMessage mOBFJEDPIPM = SlotsMessage.MENBNCJDCEO(BDPJIJMICBH.ToArray());
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[0];
			array[0] = OnlineSerializer.EKNOFIJNBAP(mOBFJEDPIPM);
			OnlineManager.SendRPC(photonView, "DiningRoom", (RpcTarget)1, array);
		}
	}

	private void FNIMLDIBBLP(byte[] LCNLPBOBKJP)
	{
		AGEAEDBPJJJ<FoodInstanceMessage>(LCNLPBOBKJP);
	}

	public void EBMDJPEPADJ(short JJPJHIHBOIB, byte OKFKMPGBKAE)
	{
		Player player = PhotonNetwork.CurrentRoom.GetPlayer((int)JJPJHIHBOIB, false);
		SlotsMessage mOBFJEDPIPM = SlotsMessage.MENBNCJDCEO(PlayerInventory.EIFPKCAFDIB(OKFKMPGBKAE, LAGHIOKLJGH: true).BBDOBNLMLGM());
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[1];
		array[1] = OnlineSerializer.EKNOFIJNBAP(mOBFJEDPIPM);
		array[1] = OKFKMPGBKAE;
		OnlineManager.SendRPC(photonView, "itemRyeSeeds", player, array);
	}

	private void LGPFIPHMGDO(byte[] LCNLPBOBKJP)
	{
		AGEAEDBPJJJ<ItemInstanceMessage>(LCNLPBOBKJP);
	}

	private void FLCNLPJLNLO(byte PAFEECBJICN, byte[] LCNLPBOBKJP)
	{
		ReceiveSlotPlayerInventory<AnimalInstanceMessage>(PAFEECBJICN, LCNLPBOBKJP);
	}

	public void MEJEKJNLMKD(Slot ADEBNALPEHE)
	{
		DJDNBNOCGPC(ADEBNALPEHE, 0);
	}

	public static void LoadSlotPlayerInventory(ContainerType LGLFPLADLOA, int IKMIKEDNCDI, ItemInstanceMessage LLBHNCFCHBD, int FGFCNKFEIGF, int PAFEECBJICN)
	{
		switch (LGLFPLADLOA)
		{
		case ContainerType.Inventory:
			LoadSlot(Inventory.GetPlayer(PAFEECBJICN).slots[IKMIKEDNCDI], LLBHNCFCHBD, FGFCNKFEIGF);
			break;
		case ContainerType.ActionBar:
			LoadSlot(ActionBarInventory.GetPlayer(PAFEECBJICN).slots[IKMIKEDNCDI], LLBHNCFCHBD, FGFCNKFEIGF);
			break;
		case ContainerType.MouseSlot:
			LoadSlot(PlayerInventory.GetPlayer(PAFEECBJICN).mouseSlot, LLBHNCFCHBD, FGFCNKFEIGF);
			break;
		}
	}

	[PunRPC]
	private void ReceiveItemSlotPlayerInventory(byte PAFEECBJICN, byte[] LCNLPBOBKJP)
	{
		ReceiveSlotPlayerInventory<ItemInstanceMessage>(PAFEECBJICN, LCNLPBOBKJP);
	}

	private void AGEAEDBPJJJ<T>(byte[] LCNLPBOBKJP) where T : ItemInstanceMessage
	{
		OnlineSerializer.Deserialize<SlotMessage<T>>(LCNLPBOBKJP).KEBMLHKLFEF();
	}

	private void LEFFBHDGNHP(Slot[] FFKKBEANBBH, int PAFEECBJICN)
	{
		SlotsMessage mOBFJEDPIPM = SlotsMessage.JKBFIGGBMNC(FFKKBEANBBH);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[2];
		array[0] = (byte)PAFEECBJICN;
		array[0] = OnlineSerializer.EKNOFIJNBAP(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "Items/item_description_1108", (RpcTarget)2, array);
	}

	private void CBEFJGCMGIC(int BEIPALOAAJJ, byte[] LCNLPBOBKJP)
	{
		AGEAEDBPJJJ<PhaseItemInstanceMessage>(LCNLPBOBKJP);
	}

	[PunRPC]
	private void ReceiveAnimalSlotPlayerInventory(byte PAFEECBJICN, byte[] LCNLPBOBKJP)
	{
		ReceiveSlotPlayerInventory<AnimalInstanceMessage>(PAFEECBJICN, LCNLPBOBKJP);
	}

	public void DPKMOHOPJFD(Slot ADEBNALPEHE)
	{
		SendSlot(ADEBNALPEHE, 1);
	}

	[PunRPC]
	private void ReceiveRequestPlayerInventory(short JJPJHIHBOIB, byte OKFKMPGBKAE)
	{
		SendPlayerInventory(JJPJHIHBOIB, OKFKMPGBKAE);
	}

	private void IMHEDGLDIEN(Slot[] FFKKBEANBBH, int PAFEECBJICN)
	{
		SlotsMessage mOBFJEDPIPM = SlotsMessage.JKBFIGGBMNC(FFKKBEANBBH);
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[2];
		array[0] = (byte)PAFEECBJICN;
		array[0] = OnlineSerializer.JBIPDCGKMGE(mOBFJEDPIPM);
		OnlineManager.SendRPC(photonView, "Checking SignedIn status...", (RpcTarget)1, array);
	}

	private void NJEPEOFKKBL(byte[] LCNLPBOBKJP)
	{
		AGEAEDBPJJJ<FoodInstanceMessage>(LCNLPBOBKJP);
	}

	public static void IPCGGCKGOIK(Slot ADEBNALPEHE, ItemInstanceMessage LLBHNCFCHBD, int FGFCNKFEIGF)
	{
		if (FGFCNKFEIGF == 0)
		{
			ADEBNALPEHE.JIANDFCINIP(1);
			ADEBNALPEHE.AJOGNKDJNAD(AODONKKHPBP: true);
			return;
		}
		if (LLBHNCFCHBD != null)
		{
			if (LLBHNCFCHBD.itemID == 0)
			{
				return;
			}
			ADEBNALPEHE.OLHGPMJPJFF(0, LLBHNCFCHBD.NMELFMAKGDK());
		}
		ADEBNALPEHE.OBBKDJNLCIO(FGFCNKFEIGF);
		ADEBNALPEHE.FKCFFOHOMOB(AODONKKHPBP: true);
	}

	[PunRPC]
	public void ReceiveStackContainer(byte KAAFFALBDJK, short IKMIKEDNCDI, int MJEEPANJLFL, short FGFCNKFEIGF)
	{
		LoadSlotContainer((ContainerType)KAAFFALBDJK, IKMIKEDNCDI, MJEEPANJLFL, null, FGFCNKFEIGF);
	}

	public void AHIPINBKHIA(int JJPJHIHBOIB, int OKFKMPGBKAE)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[5];
		array[1] = (short)JJPJHIHBOIB;
		array[1] = (byte)OKFKMPGBKAE;
		OnlineManager.SendRPC(photonView, "Light Fire", (RpcTarget)8, array);
	}

	public static void EGNHHLFJOAK(Slot ADEBNALPEHE, ItemInstanceMessage LLBHNCFCHBD, int FGFCNKFEIGF)
	{
		if (FGFCNKFEIGF == 0)
		{
			ADEBNALPEHE.JIANDFCINIP(1);
			ADEBNALPEHE.FKCFFOHOMOB(AODONKKHPBP: true);
			return;
		}
		if (LLBHNCFCHBD != null)
		{
			if (LLBHNCFCHBD.itemID == 0)
			{
				return;
			}
			ADEBNALPEHE.ONIFGHNHCPP(0, LLBHNCFCHBD.LEIKEJOAAKF(), CDPAMNIPPEC: true);
		}
		ADEBNALPEHE.KMKAIPMHANN(FGFCNKFEIGF);
		ADEBNALPEHE.FKCFFOHOMOB(AODONKKHPBP: false);
	}

	private void NNFCJBFFEBG(byte PAFEECBJICN, byte[] LCNLPBOBKJP)
	{
		ReceiveSlotPlayerInventory<ItemInstanceMessage>(PAFEECBJICN, LCNLPBOBKJP);
	}

	public void CBHMLPOHBPM(ContainerType KAAFFALBDJK, int KMNLDOOKKLO)
	{
		if (KAAFFALBDJK == ContainerType.ActionBar)
		{
			if (OnlineManager.ClientOnline())
			{
				PhotonView photonView = ((MonoBehaviourPun)this).photonView;
				object[] array = new object[8];
				array[0] = (byte)Bed.GetNumInstance();
				array[0] = (byte)KAAFFALBDJK;
				array[1] = LocalizationManager.CurrentLanguage;
				OnlineManager.SendRPC(photonView, " ", (RpcTarget)1, array);
			}
		}
		else
		{
			PhotonView photonView2 = ((MonoBehaviourPun)this).photonView;
			object[] array2 = new object[5];
			array2[0] = KMNLDOOKKLO;
			array2[1] = (byte)KAAFFALBDJK;
			array2[0] = LocalizationManager.CurrentLanguage;
			OnlineManager.SendRPC(photonView2, "Failed to join game because it's running in a different version.\nPlease, make sure both players update to the latest version.", (RpcTarget)1, array2);
		}
	}

	public static void DLELJFDBKIM(ContainerType LGLFPLADLOA, int IKMIKEDNCDI, ItemInstanceMessage LLBHNCFCHBD, int FGFCNKFEIGF, int PAFEECBJICN)
	{
		switch (LGLFPLADLOA)
		{
		case ContainerType.Inventory:
			HICIOBOBKCD(Inventory.JFIPFFDLDKB(PAFEECBJICN, LAGHIOKLJGH: true, ADPNMHGBFKG: true).slots[IKMIKEDNCDI], LLBHNCFCHBD, FGFCNKFEIGF);
			break;
		case ContainerType.ActionBar:
			PJKGGDAHNPM(ActionBarInventory.ADHIHCNAKFP(PAFEECBJICN, LAGHIOKLJGH: true, ADPNMHGBFKG: true).slots[IKMIKEDNCDI], LLBHNCFCHBD, FGFCNKFEIGF);
			break;
		case ContainerType.DrinkDispenser:
			LoadSlot(PlayerInventory.OGKNJNINGMH(PAFEECBJICN, LAGHIOKLJGH: true, ADPNMHGBFKG: true).mouseSlot, LLBHNCFCHBD, FGFCNKFEIGF);
			break;
		}
	}

	public void LGGBJDBNEII(int JJPJHIHBOIB, int OKFKMPGBKAE)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[0];
		array[0] = (short)JJPJHIHBOIB;
		array[1] = (byte)OKFKMPGBKAE;
		OnlineManager.SendRPC(photonView, "{0} - Altar piece ID {1} matches this piece ID {2}. Activating only variants with altar.", (RpcTarget)8, array);
	}

	public static void LNIOCEDBEED(ContainerType LGLFPLADLOA, int IKMIKEDNCDI, int HDFBPKHPAKA, ItemInstanceMessage LLBHNCFCHBD, int FGFCNKFEIGF)
	{
		switch (LGLFPLADLOA)
		{
		case ContainerType.Inventory:
		{
			OnlinePlaceable onlinePlaceable = OnlineObjectsManager.instance.GetOnlinePlaceable(HDFBPKHPAKA);
			if (onlinePlaceable is OnlineItemContainer onlineItemContainer)
			{
				onlineItemContainer.itemContainer.LoadSlotOnline(IKMIKEDNCDI, LLBHNCFCHBD, FGFCNKFEIGF);
			}
			else if (onlinePlaceable is OnlineFireplace onlineFireplace)
			{
				PJKGGDAHNPM(onlineFireplace.fireplace.HMAPIFPBJBL(), LLBHNCFCHBD, FGFCNKFEIGF);
			}
			return;
		}
		case ContainerType.BuildingInventory:
			if (OnlineObjectsManager.instance.GetOnlinePlaceable(HDFBPKHPAKA) is OnlineAgingRack onlineAgingRack)
			{
				onlineAgingRack.agingRack.LoadSlotOnline(IKMIKEDNCDI, LLBHNCFCHBD, FGFCNKFEIGF);
			}
			return;
		case ContainerType.DrinkDispenser:
			if (OnlineObjectsManager.instance.GetOnlinePlaceable(HDFBPKHPAKA) is OnlineAgingBarrel onlineAgingBarrel)
			{
				onlineAgingBarrel.agingBarrel.LoadSlotOnline(IKMIKEDNCDI, LLBHNCFCHBD, FGFCNKFEIGF);
			}
			return;
		case ContainerType.BarMenu:
			BuildingInventory.OLIKHNAFLNG().LoadSlotOnline(IKMIKEDNCDI, LLBHNCFCHBD, FGFCNKFEIGF);
			return;
		}
		switch (LGLFPLADLOA)
		{
		case ContainerType.DrinkDispenser:
			BarMenuInventory.KOJHKCGIINL().LoadSlotOnline(IKMIKEDNCDI, LLBHNCFCHBD, FGFCNKFEIGF);
			break;
		case ContainerType.BarMenu:
			if (OnlineObjectsManager.instance.GetOnlinePlaceable(HDFBPKHPAKA) is OnlineDrinkDispenser onlineDrinkDispenser)
			{
				PJKGGDAHNPM(onlineDrinkDispenser.drinkDispenser.slots[IKMIKEDNCDI], LLBHNCFCHBD, FGFCNKFEIGF);
			}
			else
			{
				Debug.LogError((object)("ErrorUnknownChatCommand" + HDFBPKHPAKA + "ordersDelivered"));
			}
			break;
		case (ContainerType)(-99):
			if (OnlineObjectsManager.instance.GetOnlineObject(HDFBPKHPAKA, OEBNHGNJEJL: false) is OnlineAnimalFeederFood onlineAnimalFeederFood)
			{
				LoadSlot(onlineAnimalFeederFood.animalFeederFood.container.slots[IKMIKEDNCDI], LLBHNCFCHBD, FGFCNKFEIGF);
			}
			break;
		case (ContainerType)(-58):
			if (OnlineObjectsManager.instance.GetOnlinePlaceable(HDFBPKHPAKA) is OnlineHenHouse onlineHenHouse)
			{
				PJKGGDAHNPM(onlineHenHouse.henHouse.foodFeeder.container.slots[1], LLBHNCFCHBD, FGFCNKFEIGF);
			}
			break;
		case (ContainerType)107:
			EOJDOBGPIEA(OrderQuestUI.MIFFCOMDIEE(0).currentOrderQuestElements[IKMIKEDNCDI].slotUI.IHENCGDNPBL, LLBHNCFCHBD, FGFCNKFEIGF);
			break;
		}
	}

	[PunRPC]
	private void ReceiveSlotsPlayerInventory(byte PAFEECBJICN, byte[] LCNLPBOBKJP)
	{
		OnlineSerializer.Deserialize<SlotsMessage>(LCNLPBOBKJP).GEFGOLEDEKN(PAFEECBJICN);
	}

	[PunRPC]
	public void ReceiveStackPlayerInventory(byte KAAFFALBDJK, short IKMIKEDNCDI, short FGFCNKFEIGF, int PAFEECBJICN)
	{
		LoadSlotPlayerInventory((ContainerType)KAAFFALBDJK, IKMIKEDNCDI, null, FGFCNKFEIGF, PAFEECBJICN);
	}

	public void ILKLIHOGMJP(Slot[] PCJEDMJEKEF, int PAFEECBJICN = 0)
	{
		if (PCJEDMJEKEF == null || PCJEDMJEKEF.Length == 0)
		{
			return;
		}
		BOJNFNEPFLP.Clear();
		BDPJIJMICBH.Clear();
		for (int i = 1; i < PCJEDMJEKEF.Length; i++)
		{
			if (PCJEDMJEKEF[i].sendSlotOnline)
			{
				if (PCJEDMJEKEF[i].inventoryType == ContainerType.ActionBar || PCJEDMJEKEF[i].inventoryType == ContainerType.ActionBar || PCJEDMJEKEF[i].inventoryType == ContainerType.AgingBarrel)
				{
					BOJNFNEPFLP.Add(PCJEDMJEKEF[i]);
				}
				else
				{
					BDPJIJMICBH.Add(PCJEDMJEKEF[i]);
				}
			}
		}
		if (OnlineManager.HHDBMDMFEMP() && BOJNFNEPFLP.Count > 1)
		{
			if (PAFEECBJICN == 0)
			{
				PAFEECBJICN = Bed.instance.numInstance;
			}
			IMHEDGLDIEN(BOJNFNEPFLP.ToArray(), PAFEECBJICN);
			if (BOJNFNEPFLP.Count == PCJEDMJEKEF.Length)
			{
				return;
			}
		}
		if (BDPJIJMICBH.Count > 0)
		{
			SlotsMessage mOBFJEDPIPM = SlotsMessage.MENBNCJDCEO(BDPJIJMICBH.ToArray());
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[1] = OnlineSerializer.Serialize(mOBFJEDPIPM);
			OnlineManager.SendRPC(photonView, "<color=#19FF00>", (RpcTarget)0, array);
		}
	}

	public void FMAEFIBNHNI(Slot ADEBNALPEHE)
	{
		SendSlot(ADEBNALPEHE, 0);
	}

	private void FIEDGOGNPHG(byte[] LCNLPBOBKJP)
	{
		OnlineSerializer.Deserialize<SlotsMessage>(LCNLPBOBKJP).CNBDEONHDBJ();
	}

	private void GGICOMAAGED(byte PAFEECBJICN, byte[] LCNLPBOBKJP)
	{
		ReceiveSlotPlayerInventory<ItemInstanceMessage>(PAFEECBJICN, LCNLPBOBKJP);
	}

	public static void DJNDENBPKEL(ContainerType LGLFPLADLOA, int IKMIKEDNCDI, int HDFBPKHPAKA, ItemInstanceMessage LLBHNCFCHBD, int FGFCNKFEIGF)
	{
		switch (LGLFPLADLOA)
		{
		case ContainerType.AgingRack:
		{
			OnlinePlaceable onlinePlaceable = OnlineObjectsManager.instance.GetOnlinePlaceable(HDFBPKHPAKA);
			if (onlinePlaceable is OnlineItemContainer onlineItemContainer)
			{
				onlineItemContainer.itemContainer.LoadSlotOnline(IKMIKEDNCDI, LLBHNCFCHBD, FGFCNKFEIGF);
			}
			else if (onlinePlaceable is OnlineFireplace onlineFireplace)
			{
				PJKGGDAHNPM(onlineFireplace.fireplace.IOLCGKLFPEO, LLBHNCFCHBD, FGFCNKFEIGF);
			}
			return;
		}
		case ContainerType.MouseSlot:
			if (OnlineObjectsManager.instance.GetOnlinePlaceable(HDFBPKHPAKA) is OnlineAgingRack onlineAgingRack)
			{
				onlineAgingRack.agingRack.LoadSlotOnline(IKMIKEDNCDI, LLBHNCFCHBD, FGFCNKFEIGF);
			}
			return;
		case ContainerType.AgingBarrel:
			if (OnlineObjectsManager.instance.GetOnlinePlaceable(HDFBPKHPAKA) is OnlineAgingBarrel onlineAgingBarrel)
			{
				onlineAgingBarrel.agingBarrel.LoadSlotOnline(IKMIKEDNCDI, LLBHNCFCHBD, FGFCNKFEIGF);
			}
			return;
		case ContainerType.DrinkDispenser:
			BuildingInventory.NIDNAAKOPFI().LoadSlotOnline(IKMIKEDNCDI, LLBHNCFCHBD, FGFCNKFEIGF);
			return;
		case ContainerType.ActionBar:
			BarMenuInventory.MMNNKIOHKCI().LoadSlotOnline(IKMIKEDNCDI, LLBHNCFCHBD, FGFCNKFEIGF);
			return;
		}
		switch (LGLFPLADLOA)
		{
		case ContainerType.AgingBarrel:
			if (OnlineObjectsManager.instance.GetOnlinePlaceable(HDFBPKHPAKA) is OnlineDrinkDispenser onlineDrinkDispenser)
			{
				PJKGGDAHNPM(onlineDrinkDispenser.drinkDispenser.slots[IKMIKEDNCDI], LLBHNCFCHBD, FGFCNKFEIGF);
			}
			else
			{
				Debug.LogError((object)("NotValid" + HDFBPKHPAKA + "UINextCategory"));
			}
			break;
		case (ContainerType)(-76):
			if (OnlineObjectsManager.instance.PEDPPCKIHLG(HDFBPKHPAKA) is OnlineAnimalFeederFood onlineAnimalFeederFood)
			{
				HICIOBOBKCD(onlineAnimalFeederFood.animalFeederFood.container.slots[IKMIKEDNCDI], LLBHNCFCHBD, FGFCNKFEIGF);
			}
			break;
		case (ContainerType)(-122):
			if (OnlineObjectsManager.instance.GetOnlinePlaceable(HDFBPKHPAKA) is OnlineHenHouse onlineHenHouse)
			{
				IPCGGCKGOIK(onlineHenHouse.henHouse.foodFeeder.container.slots[1], LLBHNCFCHBD, FGFCNKFEIGF);
			}
			break;
		case (ContainerType)(-42):
			HICIOBOBKCD(OrderQuestUI.PHDBJGOEKHB(0).currentOrderQuestElements[IKMIKEDNCDI].slotUI.IHENCGDNPBL, LLBHNCFCHBD, FGFCNKFEIGF);
			break;
		}
	}

	public static void PJKGGDAHNPM(Slot ADEBNALPEHE, ItemInstanceMessage LLBHNCFCHBD, int FGFCNKFEIGF)
	{
		if (FGFCNKFEIGF == 0)
		{
			ADEBNALPEHE.JNMNCEPHFOE(1);
			ADEBNALPEHE.FBAFIONMKBG(AODONKKHPBP: false);
			return;
		}
		if (LLBHNCFCHBD != null)
		{
			if (LLBHNCFCHBD.itemID == 0)
			{
				return;
			}
			ADEBNALPEHE.OLHGPMJPJFF(0, LLBHNCFCHBD.JBOIMLBMHFE(), CDPAMNIPPEC: true);
		}
		ADEBNALPEHE.Stack = FGFCNKFEIGF;
		ADEBNALPEHE.FKCFFOHOMOB(AODONKKHPBP: false);
	}

	public void DJDNBNOCGPC(Slot ADEBNALPEHE, int CMLIHBFCJHG)
	{
		if (ADEBNALPEHE == null || !ADEBNALPEHE.sendSlotOnline)
		{
			return;
		}
		if (ADEBNALPEHE.inventoryType == ContainerType.ActionBar || ADEBNALPEHE.inventoryType == ContainerType.Inventory || ADEBNALPEHE.inventoryType == ContainerType.ItemContainer)
		{
			if (OnlineManager.HHDBMDMFEMP())
			{
				if (CMLIHBFCJHG == 0)
				{
					CMLIHBFCJHG = Bed.CJMABIHEPBF();
				}
				MBPCMDKJDEP(ADEBNALPEHE, CMLIHBFCJHG);
			}
		}
		else if (ADEBNALPEHE.itemInstance is FoodInstance)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[1] = OnlineSerializer.Serialize(SlotMessage<FoodInstanceMessage>.MENBNCJDCEO(ADEBNALPEHE));
			OnlineManager.SendRPC(photonView, "bartenderDesc", (RpcTarget)0, array);
		}
		else if (ADEBNALPEHE.itemInstance is BirdInstance)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Dialogue System/Conversation/Gass_Quest/Entry/7/Dialogue Text", (RpcTarget)0, OnlineSerializer.EKNOFIJNBAP(SlotMessage<BirdInstanceMessage>.MENBNCJDCEO(ADEBNALPEHE)));
		}
		else if (ADEBNALPEHE.itemInstance is PhaseItemInstance)
		{
			PhotonView photonView2 = ((MonoBehaviourPun)this).photonView;
			object[] array2 = new object[1];
			array2[1] = OnlineSerializer.JBIPDCGKMGE(SlotMessage<PhaseItemInstanceMessage>.MENBNCJDCEO(ADEBNALPEHE));
			OnlineManager.SendRPC(photonView2, "ReceiveSimpleEvent", (RpcTarget)1, array2);
		}
		else if (ADEBNALPEHE.itemInstance is AnimalInstance)
		{
			PhotonView photonView3 = ((MonoBehaviourPun)this).photonView;
			object[] array3 = new object[0];
			array3[1] = OnlineSerializer.Serialize(SlotMessage<AnimalInstanceMessage>.MENBNCJDCEO(ADEBNALPEHE));
			OnlineManager.SendRPC(photonView3, "Player/Bark/Tutorial/T116", (RpcTarget)1, array3);
		}
		else
		{
			PhotonView photonView4 = ((MonoBehaviourPun)this).photonView;
			object[] array4 = new object[1];
			array4[1] = OnlineSerializer.JBIPDCGKMGE(SlotMessage<ItemInstanceMessage>.MENBNCJDCEO(ADEBNALPEHE));
			OnlineManager.SendRPC(photonView4, "HarvestableDuringOneMonth", (RpcTarget)1, array4);
		}
	}

	private void HHNAMAHHAGK(int BEIPALOAAJJ, byte[] LCNLPBOBKJP)
	{
		AGEAEDBPJJJ<PhaseItemInstanceMessage>(LCNLPBOBKJP);
	}

	private void KODIFGJLFFN(byte PAFEECBJICN, byte[] LCNLPBOBKJP)
	{
		ReceiveSlotPlayerInventory<BirdInstanceMessage>(PAFEECBJICN, LCNLPBOBKJP);
	}

	public static void LFHGMHGPNKP(ContainerType LGLFPLADLOA, int IKMIKEDNCDI, ItemInstanceMessage LLBHNCFCHBD, int FGFCNKFEIGF, int PAFEECBJICN)
	{
		if (LGLFPLADLOA == ContainerType.ActionBar)
		{
			LoadSlot(Inventory.KEHIBCAHKPJ(PAFEECBJICN, LAGHIOKLJGH: true, ADPNMHGBFKG: true).slots[IKMIKEDNCDI], LLBHNCFCHBD, FGFCNKFEIGF);
			return;
		}
		switch (LGLFPLADLOA)
		{
		case ContainerType.ActionBar:
			EGNHHLFJOAK(ActionBarInventory.ADHIHCNAKFP(PAFEECBJICN, LAGHIOKLJGH: false, ADPNMHGBFKG: true).slots[IKMIKEDNCDI], LLBHNCFCHBD, FGFCNKFEIGF);
			break;
		case ContainerType.AgingRack:
			EGNHHLFJOAK(PlayerInventory.OGKNJNINGMH(PAFEECBJICN, LAGHIOKLJGH: true, ADPNMHGBFKG: true).mouseSlot, LLBHNCFCHBD, FGFCNKFEIGF);
			break;
		}
	}

	public static void LoadSlot(Slot ADEBNALPEHE, ItemInstanceMessage LLBHNCFCHBD, int FGFCNKFEIGF)
	{
		if (FGFCNKFEIGF == 0)
		{
			ADEBNALPEHE.Stack = 0;
			ADEBNALPEHE.isDirty = true;
			return;
		}
		if (LLBHNCFCHBD != null)
		{
			if (LLBHNCFCHBD.itemID == 0)
			{
				return;
			}
			ADEBNALPEHE.ONIFGHNHCPP(1, LLBHNCFCHBD.ANMBPDJLNFN());
		}
		ADEBNALPEHE.Stack = FGFCNKFEIGF;
		ADEBNALPEHE.isDirty = true;
	}

	private void MNIKGOBKJLL(byte PAFEECBJICN, byte[] LCNLPBOBKJP)
	{
		OnlineSerializer.Deserialize<SlotsMessage>(LCNLPBOBKJP).KLHIDKCOPME(PAFEECBJICN);
	}

	private void GJFDBHPFKGP(byte[] OINICMNOLPK, byte OKFKMPGBKAE)
	{
		OnlineSerializer.Deserialize<SlotsMessage>(OINICMNOLPK).GEFGOLEDEKN(OKFKMPGBKAE);
		OnRecivePlayerInventory();
	}

	public static void LoadSlotContainer(ContainerType LGLFPLADLOA, int IKMIKEDNCDI, int HDFBPKHPAKA, ItemInstanceMessage LLBHNCFCHBD, int FGFCNKFEIGF)
	{
		switch (LGLFPLADLOA)
		{
		case ContainerType.ItemContainer:
		{
			OnlinePlaceable onlinePlaceable = OnlineObjectsManager.instance.GetOnlinePlaceable(HDFBPKHPAKA);
			if (onlinePlaceable is OnlineItemContainer onlineItemContainer)
			{
				onlineItemContainer.itemContainer.LoadSlotOnline(IKMIKEDNCDI, LLBHNCFCHBD, FGFCNKFEIGF);
			}
			else if (onlinePlaceable is OnlineFireplace onlineFireplace)
			{
				LoadSlot(onlineFireplace.fireplace.IOLCGKLFPEO, LLBHNCFCHBD, FGFCNKFEIGF);
			}
			break;
		}
		case ContainerType.AgingRack:
			if (OnlineObjectsManager.instance.GetOnlinePlaceable(HDFBPKHPAKA) is OnlineAgingRack onlineAgingRack)
			{
				onlineAgingRack.agingRack.LoadSlotOnline(IKMIKEDNCDI, LLBHNCFCHBD, FGFCNKFEIGF);
			}
			break;
		case ContainerType.AgingBarrel:
			if (OnlineObjectsManager.instance.GetOnlinePlaceable(HDFBPKHPAKA) is OnlineAgingBarrel onlineAgingBarrel)
			{
				onlineAgingBarrel.agingBarrel.LoadSlotOnline(IKMIKEDNCDI, LLBHNCFCHBD, FGFCNKFEIGF);
			}
			break;
		case ContainerType.BuildingInventory:
			BuildingInventory.GetInstance().LoadSlotOnline(IKMIKEDNCDI, LLBHNCFCHBD, FGFCNKFEIGF);
			break;
		case ContainerType.BarMenu:
			BarMenuInventory.GetInstance().LoadSlotOnline(IKMIKEDNCDI, LLBHNCFCHBD, FGFCNKFEIGF);
			break;
		case ContainerType.DrinkDispenser:
			if (OnlineObjectsManager.instance.GetOnlinePlaceable(HDFBPKHPAKA) is OnlineDrinkDispenser onlineDrinkDispenser)
			{
				LoadSlot(onlineDrinkDispenser.drinkDispenser.slots[IKMIKEDNCDI], LLBHNCFCHBD, FGFCNKFEIGF);
			}
			else
			{
				Debug.LogError((object)("onlinePlaceable with objectUniqueId " + HDFBPKHPAKA + " not found"));
			}
			break;
		case ContainerType.AnimalFeederBarn:
			if (OnlineObjectsManager.instance.GetOnlineObject(HDFBPKHPAKA) is OnlineAnimalFeederFood onlineAnimalFeederFood)
			{
				LoadSlot(onlineAnimalFeederFood.animalFeederFood.container.slots[IKMIKEDNCDI], LLBHNCFCHBD, FGFCNKFEIGF);
			}
			break;
		case ContainerType.HenHouse:
			if (OnlineObjectsManager.instance.GetOnlinePlaceable(HDFBPKHPAKA) is OnlineHenHouse onlineHenHouse)
			{
				LoadSlot(onlineHenHouse.henHouse.foodFeeder.container.slots[0], LLBHNCFCHBD, FGFCNKFEIGF);
			}
			break;
		case ContainerType.OrderQuest:
			LoadSlot(OrderQuestUI.Get(1).currentOrderQuestElements[IKMIKEDNCDI].slotUI.IHENCGDNPBL, LLBHNCFCHBD, FGFCNKFEIGF);
			break;
		}
	}

	public static void EOJDOBGPIEA(Slot ADEBNALPEHE, ItemInstanceMessage LLBHNCFCHBD, int FGFCNKFEIGF)
	{
		if (FGFCNKFEIGF == 0)
		{
			ADEBNALPEHE.KMKAIPMHANN(0);
			ADEBNALPEHE.AJOGNKDJNAD(AODONKKHPBP: true);
			return;
		}
		if (LLBHNCFCHBD != null)
		{
			if (LLBHNCFCHBD.itemID == 0)
			{
				return;
			}
			ADEBNALPEHE.ONIFGHNHCPP(0, LLBHNCFCHBD.JJFKOPICIHJ(), CDPAMNIPPEC: true);
		}
		ADEBNALPEHE.OCJOJKJPDNO(FGFCNKFEIGF);
		ADEBNALPEHE.isDirty = true;
	}

	public static void PIDHEFDJMLH(ContainerType LGLFPLADLOA, int IKMIKEDNCDI, ItemInstanceMessage LLBHNCFCHBD, int FGFCNKFEIGF, int PAFEECBJICN)
	{
		switch (LGLFPLADLOA)
		{
		case ContainerType.Inventory:
			IPCGGCKGOIK(Inventory.BNMEANGDMIP(PAFEECBJICN, LAGHIOKLJGH: true, ADPNMHGBFKG: true).slots[IKMIKEDNCDI], LLBHNCFCHBD, FGFCNKFEIGF);
			break;
		case ContainerType.ActionBar:
			LoadSlot(ActionBarInventory.MHDKNEKDKII(PAFEECBJICN, LAGHIOKLJGH: true).slots[IKMIKEDNCDI], LLBHNCFCHBD, FGFCNKFEIGF);
			break;
		case ContainerType.BarMenu:
			HICIOBOBKCD(PlayerInventory.GetPlayer(PAFEECBJICN, LAGHIOKLJGH: true, ADPNMHGBFKG: true).mouseSlot, LLBHNCFCHBD, FGFCNKFEIGF);
			break;
		}
	}

	public void SendPlayerInventory(short JJPJHIHBOIB, byte OKFKMPGBKAE)
	{
		Player player = PhotonNetwork.CurrentRoom.GetPlayer((int)JJPJHIHBOIB, false);
		SlotsMessage mOBFJEDPIPM = SlotsMessage.MENBNCJDCEO(PlayerInventory.GetPlayer(OKFKMPGBKAE).GetAllSlots());
		OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceivePlayerInventory", player, OnlineSerializer.Serialize(mOBFJEDPIPM), OKFKMPGBKAE);
	}

	private void Awake()
	{
		instance = this;
	}

	public void MILBPCMLPAE(byte KAAFFALBDJK, short IKMIKEDNCDI, int MJEEPANJLFL, short FGFCNKFEIGF)
	{
		LNIOCEDBEED((ContainerType)KAAFFALBDJK, IKMIKEDNCDI, MJEEPANJLFL, null, FGFCNKFEIGF);
	}

	public void SendSlot(Slot ADEBNALPEHE, int CMLIHBFCJHG)
	{
		if (ADEBNALPEHE == null || !ADEBNALPEHE.sendSlotOnline)
		{
			return;
		}
		if (ADEBNALPEHE.inventoryType == ContainerType.ActionBar || ADEBNALPEHE.inventoryType == ContainerType.Inventory || ADEBNALPEHE.inventoryType == ContainerType.MouseSlot)
		{
			if (OnlineManager.ClientOnline())
			{
				if (CMLIHBFCJHG == 0)
				{
					CMLIHBFCJHG = Bed.GetNumInstance();
				}
				MBPCMDKJDEP(ADEBNALPEHE, CMLIHBFCJHG);
			}
		}
		else if (ADEBNALPEHE.itemInstance is FoodInstance)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveFoodSlotFromContainer", (RpcTarget)1, OnlineSerializer.Serialize(SlotMessage<FoodInstanceMessage>.MENBNCJDCEO(ADEBNALPEHE)));
		}
		else if (ADEBNALPEHE.itemInstance is BirdInstance)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveBirdSlotFromContainer", (RpcTarget)1, OnlineSerializer.Serialize(SlotMessage<BirdInstanceMessage>.MENBNCJDCEO(ADEBNALPEHE)));
		}
		else if (ADEBNALPEHE.itemInstance is PhaseItemInstance)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceivePhaseSlotFromContainer", (RpcTarget)1, OnlineSerializer.Serialize(SlotMessage<PhaseItemInstanceMessage>.MENBNCJDCEO(ADEBNALPEHE)));
		}
		else if (ADEBNALPEHE.itemInstance is AnimalInstance)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveAnimalSlotFromContainer", (RpcTarget)1, OnlineSerializer.Serialize(SlotMessage<AnimalInstanceMessage>.MENBNCJDCEO(ADEBNALPEHE)));
		}
		else
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "ReceiveItemSlotFromContainer", (RpcTarget)1, OnlineSerializer.Serialize(SlotMessage<ItemInstanceMessage>.MENBNCJDCEO(ADEBNALPEHE)));
		}
	}

	public void KPBBBPFDBLL(Slot ADEBNALPEHE, int CMLIHBFCJHG)
	{
		if (ADEBNALPEHE == null || !ADEBNALPEHE.sendSlotOnline)
		{
			return;
		}
		if (ADEBNALPEHE.inventoryType == ContainerType.ActionBar || ADEBNALPEHE.inventoryType == ContainerType.ActionBar || ADEBNALPEHE.inventoryType == ContainerType.BarMenu)
		{
			if (OnlineManager.HHDBMDMFEMP())
			{
				if (CMLIHBFCJHG == 0)
				{
					CMLIHBFCJHG = Bed.CJMABIHEPBF();
				}
				MBPCMDKJDEP(ADEBNALPEHE, CMLIHBFCJHG);
			}
		}
		else if (ADEBNALPEHE.itemInstance is FoodInstance)
		{
			PhotonView photonView = ((MonoBehaviourPun)this).photonView;
			object[] array = new object[1];
			array[1] = OnlineSerializer.Serialize(SlotMessage<FoodInstanceMessage>.MENBNCJDCEO(ADEBNALPEHE));
			OnlineManager.SendRPC(photonView, "TavernServiceManager instance is null", (RpcTarget)1, array);
		}
		else if (ADEBNALPEHE.itemInstance is BirdInstance)
		{
			PhotonView photonView2 = ((MonoBehaviourPun)this).photonView;
			object[] array2 = new object[1];
			array2[1] = OnlineSerializer.EKNOFIJNBAP(SlotMessage<BirdInstanceMessage>.MENBNCJDCEO(ADEBNALPEHE));
			OnlineManager.SendRPC(photonView2, "Items/item_description_606", (RpcTarget)0, array2);
		}
		else if (ADEBNALPEHE.itemInstance is PhaseItemInstance)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Pirates/Brook/Saludo", (RpcTarget)1, OnlineSerializer.Serialize(SlotMessage<PhaseItemInstanceMessage>.MENBNCJDCEO(ADEBNALPEHE)));
		}
		else if (ADEBNALPEHE.itemInstance is AnimalInstance)
		{
			PhotonView photonView3 = ((MonoBehaviourPun)this).photonView;
			object[] array3 = new object[0];
			array3[0] = OnlineSerializer.JBIPDCGKMGE(SlotMessage<AnimalInstanceMessage>.MENBNCJDCEO(ADEBNALPEHE));
			OnlineManager.SendRPC(photonView3, "DestroyWithTime: No object assigned to destroy. Destroying the GameObject this script is attached to instead.", (RpcTarget)1, array3);
		}
		else
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, " - ", (RpcTarget)1, OnlineSerializer.EKNOFIJNBAP(SlotMessage<ItemInstanceMessage>.MENBNCJDCEO(ADEBNALPEHE)));
		}
	}

	[PunRPC]
	private void ReceiveSlotsFromContainer(byte[] LCNLPBOBKJP)
	{
		OnlineSerializer.Deserialize<SlotsMessage>(LCNLPBOBKJP).KEBMLHKLFEF();
	}

	private void ABHMLJHNPAG(byte[] LCNLPBOBKJP)
	{
		AGEAEDBPJJJ<BirdInstanceMessage>(LCNLPBOBKJP);
	}

	private void EFCNKPEPELL()
	{
		instance = this;
	}

	private void JDAMCMODANB()
	{
		instance = this;
	}

	public void MFGKNMHEJOI(int JJPJHIHBOIB, int OKFKMPGBKAE)
	{
		PhotonView photonView = ((MonoBehaviourPun)this).photonView;
		object[] array = new object[6];
		array[1] = (short)JJPJHIHBOIB;
		array[0] = (byte)OKFKMPGBKAE;
		OnlineManager.SendRPC(photonView, "Items/item_description_619", (RpcTarget)4, array);
	}

	private void MHKBMNGHICJ(short JJPJHIHBOIB, byte OKFKMPGBKAE)
	{
		SendPlayerInventory(JJPJHIHBOIB, OKFKMPGBKAE);
	}

	public void COIPPNBFLPO(Slot ADEBNALPEHE, int PAFEECBJICN = 0)
	{
		if (ADEBNALPEHE == null || !ADEBNALPEHE.sendSlotOnline)
		{
			return;
		}
		if (ADEBNALPEHE.inventoryType == ContainerType.ActionBar || ADEBNALPEHE.inventoryType == ContainerType.ActionBar || ADEBNALPEHE.inventoryType == ContainerType.ActionBar)
		{
			if (OnlineManager.HHDBMDMFEMP())
			{
				if (PAFEECBJICN == 0)
				{
					PAFEECBJICN = Bed.CJMABIHEPBF();
				}
				PhotonView photonView = ((MonoBehaviourPun)this).photonView;
				object[] array = new object[6];
				array[0] = (byte)ADEBNALPEHE.inventoryType;
				array[1] = ADEBNALPEHE.id;
				array[8] = (short)ADEBNALPEHE.Stack;
				array[7] = PAFEECBJICN;
				OnlineManager.SendRPC(photonView, "On", (RpcTarget)0, array);
			}
		}
		else
		{
			PhotonView photonView2 = ((MonoBehaviourPun)this).photonView;
			object[] array2 = new object[8];
			array2[1] = (byte)ADEBNALPEHE.inventoryType;
			array2[0] = ADEBNALPEHE.id;
			array2[2] = ADEBNALPEHE.uniqueObjectId;
			array2[5] = (short)ADEBNALPEHE.Stack;
			OnlineManager.SendRPC(photonView2, "{0} steps, minConnections={1}", (RpcTarget)1, array2);
		}
	}

	[PunRPC]
	private void ReceiveFoodSlotPlayerInventory(byte PAFEECBJICN, byte[] LCNLPBOBKJP)
	{
		ReceiveSlotPlayerInventory<FoodInstanceMessage>(PAFEECBJICN, LCNLPBOBKJP);
	}

	[PunRPC]
	private void ReceivePlayerInventory(byte[] OINICMNOLPK, byte OKFKMPGBKAE)
	{
		OnlineSerializer.Deserialize<SlotsMessage>(OINICMNOLPK).GEFGOLEDEKN(OKFKMPGBKAE);
		OnRecivePlayerInventory();
	}

	private void CHHJPNIEGMO(byte PAFEECBJICN, byte[] LCNLPBOBKJP)
	{
		ReceiveSlotPlayerInventory<FoodInstanceMessage>(PAFEECBJICN, LCNLPBOBKJP);
	}

	private void PMOKKEFFOOG(byte PAFEECBJICN, byte[] LCNLPBOBKJP)
	{
		ReceiveSlotPlayerInventory<PhaseItemInstanceMessage>(PAFEECBJICN, LCNLPBOBKJP);
	}
}
