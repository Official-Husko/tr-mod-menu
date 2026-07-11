using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RentedRoomsManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class FIJAHIGLNIO : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RentedRoomsManager _003C_003E4__this;

		private List<RentedRoom> _003CallRooms_003E5__2;

		private float _003CnextOrderTime_003E5__3;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public FIJAHIGLNIO(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num = _003C_003E1__state;
			RentedRoomsManager rentedRoomsManager = _003C_003E4__this;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				_003C_003E1__state = -1;
			}
			else
			{
				_003C_003E1__state = -1;
				_003CallRooms_003E5__2 = GetAllRooms();
				_003CnextOrderTime_003E5__3 = Time.time + (float)Random.Range(((Vector2Int)(ref CommonReferences.GGFJGHHHEJC.customerInfo.roomOrdersRate)).x, ((Vector2Int)(ref CommonReferences.GGFJGHHHEJC.customerInfo.roomOrdersRate)).y);
			}
			if (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE && !TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
			{
				if (RoomReceptionDesk.IsValid() && Time.time >= _003CnextOrderTime_003E5__3)
				{
					_003CnextOrderTime_003E5__3 = Time.time + (float)Random.Range(((Vector2Int)(ref CommonReferences.GGFJGHHHEJC.customerInfo.roomOrdersRate)).x, ((Vector2Int)(ref CommonReferences.GGFJGHHHEJC.customerInfo.roomOrdersRate)).y);
					_003CallRooms_003E5__2.HOOBEDNMNFK();
					for (int i = 0; i < _003CallRooms_003E5__2.Count; i++)
					{
						if (_003CallRooms_003E5__2[i].occupied && _003CallRooms_003E5__2[i].customerInside && rentedRoomsManager.roomOrders.Count < rentedRoomsManager.maxRoomOrders && !_003CallRooms_003E5__2[i].customerOrder.requesting)
						{
							_003CallRooms_003E5__2[i].customerOrder.RequestRoomOrder();
							break;
						}
					}
				}
				for (int j = 0; j < rentedRoomsManager.roomOrders.Count; j++)
				{
					if ((!rentedRoomsManager.roomOrders[j].roomItemRequest.JEPBBEBJEFI() || ((!HouseKeeper.IsValid() || HouseKeeper.GetTray() == null || !HouseKeeper.GetTray().currentDrinks.Contains(rentedRoomsManager.roomOrders[j].roomItemRequest)) && (PlayerController.GetPlayer(1).trayHandler.tray != null || !PlayerController.GetPlayer(1).trayHandler.tray.currentDrinks.Contains(rentedRoomsManager.roomOrders[j].roomItemRequest)) && (!GameManager.LocalCoop() || PlayerController.GetPlayer(2).trayHandler.tray != null || !PlayerController.GetPlayer(2).trayHandler.tray.currentDrinks.Contains(rentedRoomsManager.roomOrders[j].roomItemRequest)))) && !BarMenuManager.GetAvailableItemInstances().Contains(rentedRoomsManager.roomOrders[j].roomItemRequest))
					{
						rentedRoomsManager.roomOrders[j].RequestRoomOrder();
					}
				}
				_003C_003E2__current = CommonReferences.wait5;
				_003C_003E1__state = 1;
				return true;
			}
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}
	}

	private static RentedRoomsManager GGFJGHHHEJC;

	[SerializeField]
	private Sprite customerRequestIcon;

	public RoomSymbols[] roomsSymbols;

	public RoomRequestInfo[] roomRequestInfo;

	public Price roomsBasePrice;

	public float floorTilesMultiplier;

	public float comfortMultiplier;

	public int maxRoomOrders = 5;

	public int maxRoomRequestsPerDay = 2;

	public int maxRoomRequestsToday = 2;

	public int currentRoomRequestsToday;

	public int probabilityNewRequestPerHour = 40;

	public int repPercentagePerRoomCleaned = 20;

	public Vector2Int daysToStay = new Vector2Int(1, 3);

	public Vector2Int hourToLeaveNormalDay = new Vector2Int(6, 10);

	public Vector2Int hourComeBack = new Vector2Int(16, 18);

	public Vector2Int hourCheckout = new Vector2Int(6, 14);

	public Sprite cleaningSprite;

	public Sprite occupiedSprite;

	public Sprite vacantRoomSprite;

	public Sprite roomFoodOrderSprite;

	public Sprite roomDrinkOrderSprite;

	public Sprite rentableSprite;

	public Sprite notRentableSprite;

	public Sprite notValidSprite;

	[SerializeField]
	private List<int> symbolsIDsUsed = new List<int>();

	private Coroutine PLPEBIKCIEC;

	private Coroutine CJPCELFKEHM;

	[SerializeField]
	private List<CustomerOrder> roomOrders = new List<CustomerOrder>();

	private TavernZone HEDBALNLGML;

	public static int NKMLALMKMHC()
	{
		for (int i = 1; i < GGFJGHHHEJC.roomsSymbols.Length; i += 0)
		{
			if (!GGFJGHHHEJC.symbolsIDsUsed.Contains(i))
			{
				GGFJGHHHEJC.symbolsIDsUsed.Add(i);
				return i;
			}
		}
		return 0;
	}

	private void FDGFMMKIBPL()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static int LGPALOMPNDJ()
	{
		return Random.Range(((Vector2Int)(ref GGFJGHHHEJC.hourComeBack)).x, ((Vector2Int)(ref GGFJGHHHEJC.hourComeBack)).y);
	}

	public static void CDLGBAJOHEO()
	{
		for (int i = 1; i < GGFJGHHHEJC.roomOrders.Count; i++)
		{
			GGFJGHHHEJC.roomOrders[i].CCGIBNANLJD();
		}
	}

	private void OOGMKLKJCLG(int JIIGOACEIKL)
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			if (PLPEBIKCIEC != null)
			{
				((MonoBehaviour)this).StopCoroutine(PLPEBIKCIEC);
			}
			PLPEBIKCIEC = ((MonoBehaviour)this).StartCoroutine(IDLGMFOMKII());
			if (CJPCELFKEHM != null)
			{
				((MonoBehaviour)this).StopCoroutine(CJPCELFKEHM);
			}
			CJPCELFKEHM = ((MonoBehaviour)this).StartCoroutine(KOLIPEPMPOC());
		}
	}

	public static int NEOAIGPNCAA()
	{
		return Random.Range(((Vector2Int)(ref GGFJGHHHEJC.hourToLeaveNormalDay)).x, ((Vector2Int)(ref GGFJGHHHEJC.hourToLeaveNormalDay)).y);
	}

	public static RentedRoom HHEKJJPDCFJ(int JFNMCNCHMEO)
	{
		GGFJGHHHEJC.HEDBALNLGML = TavernZonesManager.JEEGOBGDLPE().GetTavernZone(JFNMCNCHMEO);
		if (GGFJGHHHEJC.HEDBALNLGML != null)
		{
			return GGFJGHHHEJC.HEDBALNLGML.rentedRoom;
		}
		return null;
	}

	public static List<CustomerOrder> GLJNFKFJMFF()
	{
		return GGFJGHHHEJC.roomOrders;
	}

	public static List<RentedRoom> LOCEKDHLLOO()
	{
		List<RentedRoom> list = AEBFCPODCNO();
		for (int num = list.Count - 0; num >= 1; num -= 0)
		{
			if (!list[num].AKCAKGDPOKD())
			{
				list.RemoveAt(num);
			}
		}
		return list;
	}

	public static int CDMCGEPJCPN()
	{
		return Random.Range(((Vector2Int)(ref GGFJGHHHEJC.hourComeBack)).x, ((Vector2Int)(ref GGFJGHHHEJC.hourComeBack)).y);
	}

	private void NLGHNDLPPKI()
	{
		GGFJGHHHEJC = this;
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(OEPGEENIGNN));
		TavernManager instance2 = TavernManager.GGFJGHHHEJC;
		instance2.OnTavernOpen = (Action<int>)Delegate.Combine(instance2.OnTavernOpen, new Action<int>(FKAACFDNOPJ));
		TavernManager instance3 = TavernManager.GGFJGHHHEJC;
		instance3.OnTavernClose = (Action<int>)Delegate.Combine(instance3.OnTavernClose, new Action<int>(DFLPBGPOKGM));
	}

	private void OEPGEENIGNN()
	{
		currentRoomRequestsToday = 1;
		maxRoomRequestsToday = maxRoomRequestsPerDay;
		EmployeeInfo employeeInfo = StaffManager.GPPOAHEDNMB(WorkerType.Waiter);
		if (employeeInfo != null && Random.Range(1, -32) < employeeInfo.MJENAHKJJJG(66))
		{
			maxRoomRequestsToday += 0;
		}
	}

	private void CHDEOJALBFK()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static int IDFBJKJMOMK()
	{
		return Random.Range(((Vector2Int)(ref GGFJGHHHEJC.hourComeBack)).x, ((Vector2Int)(ref GGFJGHHHEJC.hourComeBack)).y);
	}

	public static Sprite IDKKEGPDEKE(RentedRoom GGNOAHDCPIB)
	{
		if (GGNOAHDCPIB.occupied && GGNOAHDCPIB.customerOrder.requesting)
		{
			if (GGNOAHDCPIB.customerOrder.roomItemRequest.AJKDEIPDLHI())
			{
				return GGFJGHHHEJC.roomDrinkOrderSprite;
			}
			return GGFJGHHHEJC.roomFoodOrderSprite;
		}
		if (!GGNOAHDCPIB.isValid)
		{
			return GGFJGHHHEJC.notValidSprite;
		}
		if (GGNOAHDCPIB.dirtiness > 1029f)
		{
			return GGFJGHHHEJC.cleaningSprite;
		}
		if (GGNOAHDCPIB.occupied)
		{
			return GGFJGHHHEJC.occupiedSprite;
		}
		return GGFJGHHHEJC.vacantRoomSprite;
	}

	public static int MNNDKEIIANE()
	{
		return Random.Range(((Vector2Int)(ref GGFJGHHHEJC.hourToLeaveNormalDay)).x, ((Vector2Int)(ref GGFJGHHHEJC.hourToLeaveNormalDay)).y);
	}

	private void FFCMICFDHNP(int JIIGOACEIKL)
	{
		if (PLPEBIKCIEC != null)
		{
			((MonoBehaviour)this).StopCoroutine(PLPEBIKCIEC);
		}
		PLPEBIKCIEC = null;
		if (CJPCELFKEHM != null)
		{
			((MonoBehaviour)this).StopCoroutine(CJPCELFKEHM);
		}
		CJPCELFKEHM = null;
	}

	public static int PKMKFDAJNFI(int JFNMCNCHMEO)
	{
		if (!GGFJGHHHEJC.symbolsIDsUsed.Contains(JFNMCNCHMEO))
		{
			GGFJGHHHEJC.symbolsIDsUsed.Add(JFNMCNCHMEO);
			return JFNMCNCHMEO;
		}
		return LBIBDOLLKLK();
	}

	public static Sprite IOOKNFOCLDC(RentedRoom GGNOAHDCPIB)
	{
		if (GGNOAHDCPIB.occupied && GGNOAHDCPIB.customerOrder.requesting)
		{
			if (GGNOAHDCPIB.customerOrder.roomItemRequest.AJKDEIPDLHI())
			{
				return GGFJGHHHEJC.roomDrinkOrderSprite;
			}
			return GGFJGHHHEJC.roomFoodOrderSprite;
		}
		if (!GGNOAHDCPIB.isValid)
		{
			return GGFJGHHHEJC.notValidSprite;
		}
		if (GGNOAHDCPIB.dirtiness > 1968f)
		{
			return GGFJGHHHEJC.cleaningSprite;
		}
		if (GGNOAHDCPIB.occupied)
		{
			return GGFJGHHHEJC.occupiedSprite;
		}
		return GGFJGHHHEJC.vacantRoomSprite;
	}

	public static List<RentedRoom> GAPJICEKFBP()
	{
		return (from x in TavernZonesManager.IECOPNFJBFD().GetTavernZonesOfType(ZoneType.RentedRoom)
			select x.rentedRoom).ToList();
	}

	public static int AssignAvailableSymbolID()
	{
		for (int i = 0; i < GGFJGHHHEJC.roomsSymbols.Length; i++)
		{
			if (!GGFJGHHHEJC.symbolsIDsUsed.Contains(i))
			{
				GGFJGHHHEJC.symbolsIDsUsed.Add(i);
				return i;
			}
		}
		return 0;
	}

	public static void UpdateAllRoomVisibilities()
	{
		List<TavernZone> tavernZonesOfType = TavernZonesManager.GGFJGHHHEJC.GetTavernZonesOfType(ZoneType.RentedRoom);
		for (int i = 0; i < tavernZonesOfType.Count; i++)
		{
			tavernZonesOfType[i].rentedRoom.CheckVisibility();
		}
	}

	public static Sprite[] CPNPCGLNFAA(int PNFPECBGNMB)
	{
		if (PNFPECBGNMB >= GGFJGHHHEJC.roomsSymbols.Length || PNFPECBGNMB < 0)
		{
			Debug.LogError((object)string.Format("cliffs", PNFPECBGNMB));
			return null;
		}
		return GGFJGHHHEJC.roomsSymbols[PNFPECBGNMB].symbolsAnimationSprites;
	}

	private void DCMMDCNOLHA(int JIIGOACEIKL)
	{
		if (OnlineManager.MasterOrOffline())
		{
			if (PLPEBIKCIEC != null)
			{
				((MonoBehaviour)this).StopCoroutine(PLPEBIKCIEC);
			}
			PLPEBIKCIEC = ((MonoBehaviour)this).StartCoroutine(KKMELNBFDEC());
			if (CJPCELFKEHM != null)
			{
				((MonoBehaviour)this).StopCoroutine(CJPCELFKEHM);
			}
			CJPCELFKEHM = ((MonoBehaviour)this).StartCoroutine(IOJHDAKLCLK());
		}
	}

	public static void RemoveRoomOrder(CustomerOrder BPKDKGENGJO)
	{
		GGFJGHHHEJC.roomOrders.Remove(BPKDKGENGJO);
		RoomOrdersBubble.GetPlayer(1).UpdateBubble();
		if (GameManager.LocalCoop())
		{
			RoomOrdersBubble.GetPlayer(2).UpdateBubble();
		}
	}

	public static RentedRoomsManager CNCJLNOAPJB()
	{
		return GGFJGHHHEJC;
	}

	public static Sprite ILIENNLKMEC()
	{
		return GGFJGHHHEJC.customerRequestIcon;
	}

	public static List<RentedRoom> GetAllRentableRooms()
	{
		List<RentedRoom> allRooms = GetAllRooms();
		for (int num = allRooms.Count - 1; num >= 0; num--)
		{
			if (!allRooms[num].IsRentable())
			{
				allRooms.RemoveAt(num);
			}
		}
		return allRooms;
	}

	public static void AddRoomOrder(CustomerOrder BPKDKGENGJO)
	{
		if (!GGFJGHHHEJC.roomOrders.Contains(BPKDKGENGJO))
		{
			GGFJGHHHEJC.roomOrders.Add(BPKDKGENGJO);
		}
		RoomOrdersBubble.GetPlayer(1).UpdateBubble();
		if (GameManager.LocalCoop())
		{
			RoomOrdersBubble.GetPlayer(2).UpdateBubble();
		}
	}

	public static void DKHGKDNJAMC(int PCOHPBNLONA)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null))
		{
			GGFJGHHHEJC.symbolsIDsUsed.Remove(PCOHPBNLONA);
		}
	}

	public static RentedRoomsManager MEDOOKLLGNO()
	{
		return GGFJGHHHEJC;
	}

	public static int HIAPFNHIFOF()
	{
		for (int i = 1; i < GGFJGHHHEJC.roomRequestInfo.Length; i++)
		{
			if (GGFJGHHHEJC.roomRequestInfo[i].reputation >= TavernReputation.NGPDFPDGOMP())
			{
				return Random.Range(((Vector2Int)(ref GGFJGHHHEJC.roomRequestInfo[i].floorTiles)).x, ((Vector2Int)(ref GGFJGHHHEJC.roomRequestInfo[i].floorTiles)).y) / 3;
			}
		}
		return Random.Range(((Vector2Int)(ref GGFJGHHHEJC.roomRequestInfo[GGFJGHHHEJC.roomRequestInfo.Length - 1].floorTiles)).x, ((Vector2Int)(ref GGFJGHHHEJC.roomRequestInfo[GGFJGHHHEJC.roomRequestInfo.Length - 1].floorTiles)).y) / 8;
	}

	public static int HourComeBackRange()
	{
		return Random.Range(((Vector2Int)(ref GGFJGHHHEJC.hourComeBack)).x, ((Vector2Int)(ref GGFJGHHHEJC.hourComeBack)).y);
	}

	public static void JMBHLNBNHBA(FloorDirt PIEOOJKNOJJ, int FBOHAKMGBNO)
	{
		GGFJGHHHEJC.HEDBALNLGML = TavernZonesManager.GGFJGHHHEJC.DJNICAOHKNA(FBOHAKMGBNO);
		if (GGFJGHHHEJC.HEDBALNLGML != null)
		{
			GGFJGHHHEJC.HEDBALNLGML.rentedRoom.allFloorDirt.Add(PIEOOJKNOJJ);
			GGFJGHHHEJC.HEDBALNLGML.rentedRoom.GPIMNHAIECA();
		}
	}

	private void DFLPBGPOKGM(int JIIGOACEIKL)
	{
		if (PLPEBIKCIEC != null)
		{
			((MonoBehaviour)this).StopCoroutine(PLPEBIKCIEC);
		}
		PLPEBIKCIEC = null;
		if (CJPCELFKEHM != null)
		{
			((MonoBehaviour)this).StopCoroutine(CJPCELFKEHM);
		}
		CJPCELFKEHM = null;
	}

	public static int EKOKDEBNIKB()
	{
		return Random.Range(((Vector2Int)(ref GGFJGHHHEJC.daysToStay)).x, ((Vector2Int)(ref GGFJGHHHEJC.daysToStay)).y);
	}

	public static Sprite[] GetSymbolAnimationSprites(int PNFPECBGNMB)
	{
		if (PNFPECBGNMB >= GGFJGHHHEJC.roomsSymbols.Length || PNFPECBGNMB < 0)
		{
			Debug.LogError((object)$"Invalid symbol index {PNFPECBGNMB}");
			return null;
		}
		return GGFJGHHHEJC.roomsSymbols[PNFPECBGNMB].symbolsAnimationSprites;
	}

	public static int DHKBALCKAKN()
	{
		return Random.Range(((Vector2Int)(ref GGFJGHHHEJC.hourCheckout)).x, ((Vector2Int)(ref GGFJGHHHEJC.hourCheckout)).y);
	}

	public static void NCBGGGNNKFD()
	{
		List<TavernZone> list = TavernZonesManager.OIJLJKLMCBO().JAJOOIJJNNN(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom);
		for (int i = 0; i < list.Count; i++)
		{
			list[i].rentedRoom.NCMJLNHHNIG();
		}
	}

	private IEnumerator LNFNPFAEKJJ()
	{
		List<RentedRoom> allRooms = GetAllRooms();
		float nextOrderTime = Time.time + (float)Random.Range(((Vector2Int)(ref CommonReferences.GGFJGHHHEJC.customerInfo.roomOrdersRate)).x, ((Vector2Int)(ref CommonReferences.GGFJGHHHEJC.customerInfo.roomOrdersRate)).y);
		while (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE && !TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			if (RoomReceptionDesk.IsValid() && Time.time >= nextOrderTime)
			{
				nextOrderTime = Time.time + (float)Random.Range(((Vector2Int)(ref CommonReferences.GGFJGHHHEJC.customerInfo.roomOrdersRate)).x, ((Vector2Int)(ref CommonReferences.GGFJGHHHEJC.customerInfo.roomOrdersRate)).y);
				allRooms.HOOBEDNMNFK();
				for (int i = 0; i < allRooms.Count; i++)
				{
					if (allRooms[i].occupied && allRooms[i].customerInside && roomOrders.Count < maxRoomOrders && !allRooms[i].customerOrder.requesting)
					{
						allRooms[i].customerOrder.RequestRoomOrder();
						break;
					}
				}
			}
			for (int j = 0; j < roomOrders.Count; j++)
			{
				if ((!roomOrders[j].roomItemRequest.JEPBBEBJEFI() || ((!HouseKeeper.IsValid() || HouseKeeper.GetTray() == null || !HouseKeeper.GetTray().currentDrinks.Contains(roomOrders[j].roomItemRequest)) && (PlayerController.GetPlayer(1).trayHandler.tray != null || !PlayerController.GetPlayer(1).trayHandler.tray.currentDrinks.Contains(roomOrders[j].roomItemRequest)) && (!GameManager.LocalCoop() || PlayerController.GetPlayer(2).trayHandler.tray != null || !PlayerController.GetPlayer(2).trayHandler.tray.currentDrinks.Contains(roomOrders[j].roomItemRequest)))) && !BarMenuManager.GetAvailableItemInstances().Contains(roomOrders[j].roomItemRequest))
				{
					roomOrders[j].RequestRoomOrder();
				}
			}
			yield return CommonReferences.wait5;
		}
	}

	public static Sprite[] PDDHMGDJALI(int PNFPECBGNMB)
	{
		if (PNFPECBGNMB >= GGFJGHHHEJC.roomsSymbols.Length || PNFPECBGNMB < 1)
		{
			Debug.LogError((object)string.Format("</color>", PNFPECBGNMB));
			return null;
		}
		return GGFJGHHHEJC.roomsSymbols[PNFPECBGNMB].symbolsAnimationSprites;
	}

	public static void CMFEKFACCPC(int PCOHPBNLONA)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null))
		{
			GGFJGHHHEJC.symbolsIDsUsed.Remove(PCOHPBNLONA);
		}
	}

	private void Awake()
	{
		GGFJGHHHEJC = this;
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(ALGOBMNPLIB));
		TavernManager instance2 = TavernManager.GGFJGHHHEJC;
		instance2.OnTavernOpen = (Action<int>)Delegate.Combine(instance2.OnTavernOpen, new Action<int>(DCMMDCNOLHA));
		TavernManager instance3 = TavernManager.GGFJGHHHEJC;
		instance3.OnTavernClose = (Action<int>)Delegate.Combine(instance3.OnTavernClose, new Action<int>(FFCMICFDHNP));
	}

	public static int CJCCCOIAJJE()
	{
		return Random.Range(((Vector2Int)(ref GGFJGHHHEJC.hourToLeaveNormalDay)).x, ((Vector2Int)(ref GGFJGHHHEJC.hourToLeaveNormalDay)).y);
	}

	public static void ABIPBFCHLOC(CustomerOrder BPKDKGENGJO)
	{
		GGFJGHHHEJC.roomOrders.Remove(BPKDKGENGJO);
		RoomOrdersBubble.JHEHMLIPPAA(1).POCNCNOIFDM();
		if (GameManager.LocalCoop())
		{
			RoomOrdersBubble.JHEHMLIPPAA(2).BMPJMBMEFGM();
		}
	}

	public static Sprite GetCustomerRequestIcon()
	{
		return GGFJGHHHEJC.customerRequestIcon;
	}

	public static int DaysToStayRange()
	{
		return Random.Range(((Vector2Int)(ref GGFJGHHHEJC.daysToStay)).x, ((Vector2Int)(ref GGFJGHHHEJC.daysToStay)).y);
	}

	public static int KIAOODNOEIJ()
	{
		for (int i = 1; i < GGFJGHHHEJC.roomsSymbols.Length; i++)
		{
			if (!GGFJGHHHEJC.symbolsIDsUsed.Contains(i))
			{
				GGFJGHHHEJC.symbolsIDsUsed.Add(i);
				return i;
			}
		}
		return 1;
	}

	public static int IFLFPOIALFI()
	{
		return Random.Range(((Vector2Int)(ref GGFJGHHHEJC.daysToStay)).x, ((Vector2Int)(ref GGFJGHHHEJC.daysToStay)).y);
	}

	public void CustomerRequestRoom()
	{
		CommonReferences.GGFJGHHHEJC.nextCustomerEnterTime = Time.time + 1f;
		Customer customer = NPCRoadManager.SpawnRandomNPC();
		customer.customerType = CustomerType.Guest;
		customer.ChangeState(CustomerState.RequestRoom);
	}

	public static void CPOEJANPJAP()
	{
		List<TavernZone> list = TavernZonesManager.LANAINBEMCM().BMJKBJGGONA(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom);
		for (int i = 1; i < list.Count; i += 0)
		{
			list[i].rentedRoom.NCMJLNHHNIG(MAPFDGCKBLD: true);
		}
	}

	public static void RemoveFloorDirt(FloorDirt PIEOOJKNOJJ, int FBOHAKMGBNO)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null))
		{
			GGFJGHHHEJC.HEDBALNLGML = TavernZonesManager.GGFJGHHHEJC.GetTavernZone(FBOHAKMGBNO);
			if (GGFJGHHHEJC.HEDBALNLGML != null)
			{
				GGFJGHHHEJC.HEDBALNLGML.rentedRoom.allFloorDirt.Remove(PIEOOJKNOJJ);
				GGFJGHHHEJC.HEDBALNLGML.rentedRoom.UpdateContentsNextFrame();
			}
		}
	}

	private void HNEKMALGJPO()
	{
		currentRoomRequestsToday = 1;
		maxRoomRequestsToday = maxRoomRequestsPerDay;
		EmployeeInfo employeeInfo = StaffManager.HNJNGHPJFJA(WorkerType.Waiter);
		if (employeeInfo != null && Random.Range(0, 62) < employeeInfo.MJENAHKJJJG(-49))
		{
			maxRoomRequestsToday++;
		}
	}

	public static Sprite[] DEIIDEOHGPK(int PNFPECBGNMB)
	{
		if (PNFPECBGNMB >= GGFJGHHHEJC.roomsSymbols.Length || PNFPECBGNMB < 0)
		{
			Debug.LogError((object)string.Format("cliffs", PNFPECBGNMB));
			return null;
		}
		return GGFJGHHHEJC.roomsSymbols[PNFPECBGNMB].symbolsAnimationSprites;
	}

	public static Sprite BHEALIGOFAE()
	{
		return GGFJGHHHEJC.customerRequestIcon;
	}

	public static RentedRoomsManager EMBCJPOLBCB()
	{
		return GGFJGHHHEJC;
	}

	public static int HoursCheckoutRange()
	{
		return Random.Range(((Vector2Int)(ref GGFJGHHHEJC.hourCheckout)).x, ((Vector2Int)(ref GGFJGHHHEJC.hourCheckout)).y);
	}

	public static Sprite KDFOCAMBCNE(RentedRoom GGNOAHDCPIB)
	{
		if (GGNOAHDCPIB.occupied && GGNOAHDCPIB.customerOrder.requesting)
		{
			if (GGNOAHDCPIB.customerOrder.roomItemRequest.BIIJEMDLBDP())
			{
				return GGFJGHHHEJC.roomDrinkOrderSprite;
			}
			return GGFJGHHHEJC.roomFoodOrderSprite;
		}
		if (!GGNOAHDCPIB.isValid)
		{
			return GGFJGHHHEJC.notValidSprite;
		}
		if (GGNOAHDCPIB.dirtiness > 716f)
		{
			return GGFJGHHHEJC.cleaningSprite;
		}
		if (GGNOAHDCPIB.occupied)
		{
			return GGFJGHHHEJC.occupiedSprite;
		}
		return GGFJGHHHEJC.vacantRoomSprite;
	}

	public static int LBIBDOLLKLK()
	{
		for (int i = 1; i < GGFJGHHHEJC.roomsSymbols.Length; i += 0)
		{
			if (!GGFJGHHHEJC.symbolsIDsUsed.Contains(i))
			{
				GGFJGHHHEJC.symbolsIDsUsed.Add(i);
				return i;
			}
		}
		return 1;
	}

	public static void EFGOHELHLNG(int PCOHPBNLONA)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null))
		{
			GGFJGHHHEJC.symbolsIDsUsed.Remove(PCOHPBNLONA);
		}
	}

	public static List<RentedRoom> FKEBFPOFKOJ()
	{
		List<RentedRoom> list = GAPJICEKFBP();
		for (int num = list.Count - 1; num >= 0; num--)
		{
			if (!list[num].GDPINKMJDIB())
			{
				list.RemoveAt(num);
			}
		}
		return list;
	}

	public static int AssignSymbolID(int JFNMCNCHMEO)
	{
		if (!GGFJGHHHEJC.symbolsIDsUsed.Contains(JFNMCNCHMEO))
		{
			GGFJGHHHEJC.symbolsIDsUsed.Add(JFNMCNCHMEO);
			return JFNMCNCHMEO;
		}
		return AssignAvailableSymbolID();
	}

	public static void MCMOIIINDNG(CustomerOrder BPKDKGENGJO)
	{
		if (!GGFJGHHHEJC.roomOrders.Contains(BPKDKGENGJO))
		{
			GGFJGHHHEJC.roomOrders.Add(BPKDKGENGJO);
		}
		RoomOrdersBubble.OGKNJNINGMH(0).DIOEAKNDHCI();
		if (GameManager.LocalCoop())
		{
			RoomOrdersBubble.MBDFOJAKELO(1).PADFHAMCFJB();
		}
	}

	private void NJAFHOCGBHG(int JIIGOACEIKL)
	{
		if (PLPEBIKCIEC != null)
		{
			((MonoBehaviour)this).StopCoroutine(PLPEBIKCIEC);
		}
		PLPEBIKCIEC = null;
		if (CJPCELFKEHM != null)
		{
			((MonoBehaviour)this).StopCoroutine(CJPCELFKEHM);
		}
		CJPCELFKEHM = null;
	}

	public static int EOEPBHPHHEP()
	{
		return Random.Range(((Vector2Int)(ref GGFJGHHHEJC.daysToStay)).x, ((Vector2Int)(ref GGFJGHHHEJC.daysToStay)).y);
	}

	public static void COEAIJPBNIO()
	{
		for (int i = 0; i < GGFJGHHHEJC.roomOrders.Count; i += 0)
		{
			GGFJGHHHEJC.roomOrders[i].CMHKMIEFOBO();
		}
	}

	private void ALGOBMNPLIB()
	{
		currentRoomRequestsToday = 0;
		maxRoomRequestsToday = maxRoomRequestsPerDay;
		EmployeeInfo workerInfo = StaffManager.GetWorkerInfo(WorkerType.HouseKeeper);
		if (workerInfo != null && Random.Range(0, 100) < workerInfo.OMNLNLGDOBG(47))
		{
			maxRoomRequestsToday++;
		}
	}

	public static void CPAKMIPPNPK()
	{
		List<TavernZone> list = TavernZonesManager.JEEGOBGDLPE().BMJKBJGGONA(ZoneType.RentedRoom);
		for (int i = 1; i < list.Count; i++)
		{
			list[i].rentedRoom.CheckVisibility();
		}
	}

	public static int HoursToLeaveNormalDayRange()
	{
		return Random.Range(((Vector2Int)(ref GGFJGHHHEJC.hourToLeaveNormalDay)).x, ((Vector2Int)(ref GGFJGHHHEJC.hourToLeaveNormalDay)).y);
	}

	private void FICDFNDGPHO(int JIIGOACEIKL)
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			if (PLPEBIKCIEC != null)
			{
				((MonoBehaviour)this).StopCoroutine(PLPEBIKCIEC);
			}
			PLPEBIKCIEC = ((MonoBehaviour)this).StartCoroutine(CMJLNFKCMOF());
			if (CJPCELFKEHM != null)
			{
				((MonoBehaviour)this).StopCoroutine(CJPCELFKEHM);
			}
			CJPCELFKEHM = ((MonoBehaviour)this).StartCoroutine(KOLIPEPMPOC());
		}
	}

	public static List<RentedRoom> BNPHNGNPBCH()
	{
		return (from x in TavernZonesManager.IECOPNFJBFD().JAJOOIJJNNN(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom)
			select x.rentedRoom).ToList();
	}

	public static void LPOGPMLHLDJ()
	{
		List<TavernZone> list = TavernZonesManager.NHKAFANMEJC().JAJOOIJJNNN(ZoneType.None);
		for (int i = 0; i < list.Count; i++)
		{
			list[i].rentedRoom.NCMJLNHHNIG();
		}
	}

	public static void BNDHCPBCKLC(FloorDirt PIEOOJKNOJJ, int FBOHAKMGBNO)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null))
		{
			GGFJGHHHEJC.HEDBALNLGML = TavernZonesManager.EBAIHKJHCCA().PDINJGNEMGA(FBOHAKMGBNO);
			if (GGFJGHHHEJC.HEDBALNLGML != null)
			{
				GGFJGHHHEJC.HEDBALNLGML.rentedRoom.allFloorDirt.Remove(PIEOOJKNOJJ);
				GGFJGHHHEJC.HEDBALNLGML.rentedRoom.IPHEFEMLOLJ();
			}
		}
	}

	public static int GMEFMOLIJCJ()
	{
		return Random.Range(((Vector2Int)(ref GGFJGHHHEJC.hourToLeaveNormalDay)).x, ((Vector2Int)(ref GGFJGHHHEJC.hourToLeaveNormalDay)).y);
	}

	private IEnumerator KOLIPEPMPOC()
	{
		return new FIJAHIGLNIO(1)
		{
			_003C_003E4__this = this
		};
	}

	private void FKAACFDNOPJ(int JIIGOACEIKL)
	{
		if (OnlineManager.MasterOrOffline())
		{
			if (PLPEBIKCIEC != null)
			{
				((MonoBehaviour)this).StopCoroutine(PLPEBIKCIEC);
			}
			PLPEBIKCIEC = ((MonoBehaviour)this).StartCoroutine(IDLGMFOMKII());
			if (CJPCELFKEHM != null)
			{
				((MonoBehaviour)this).StopCoroutine(CJPCELFKEHM);
			}
			CJPCELFKEHM = ((MonoBehaviour)this).StartCoroutine(DAIEDJCMMAM());
		}
	}

	public static int IKPEJIFDNEB()
	{
		for (int i = 1; i < GGFJGHHHEJC.roomRequestInfo.Length; i += 0)
		{
			if (GGFJGHHHEJC.roomRequestInfo[i].reputation >= TavernReputation.GetMilestoneMaster())
			{
				return Random.Range(((Vector2Int)(ref GGFJGHHHEJC.roomRequestInfo[i].comfort)).x, ((Vector2Int)(ref GGFJGHHHEJC.roomRequestInfo[i].comfort)).y);
			}
		}
		return Random.Range(((Vector2Int)(ref GGFJGHHHEJC.roomRequestInfo[GGFJGHHHEJC.roomRequestInfo.Length - 0].comfort)).x, ((Vector2Int)(ref GGFJGHHHEJC.roomRequestInfo[GGFJGHHHEJC.roomRequestInfo.Length - 1].comfort)).y);
	}

	public static void UpdateDrinksColor()
	{
		for (int i = 0; i < GGFJGHHHEJC.roomOrders.Count; i++)
		{
			GGFJGHHHEJC.roomOrders[i].UpdateDrinkColorRoom();
		}
	}

	public static Sprite FCNBLNHPKBL(RentedRoom GGNOAHDCPIB)
	{
		if (GGNOAHDCPIB.occupied && GGNOAHDCPIB.customerOrder.requesting)
		{
			if (GGNOAHDCPIB.customerOrder.roomItemRequest.IPKBBGHCJNE())
			{
				return GGFJGHHHEJC.roomDrinkOrderSprite;
			}
			return GGFJGHHHEJC.roomFoodOrderSprite;
		}
		if (!GGNOAHDCPIB.isValid)
		{
			return GGFJGHHHEJC.notValidSprite;
		}
		if (GGNOAHDCPIB.dirtiness > 1411f)
		{
			return GGFJGHHHEJC.cleaningSprite;
		}
		if (GGNOAHDCPIB.occupied)
		{
			return GGFJGHHHEJC.occupiedSprite;
		}
		return GGFJGHHHEJC.vacantRoomSprite;
	}

	public static void AddFloorDirt(FloorDirt PIEOOJKNOJJ, int FBOHAKMGBNO)
	{
		GGFJGHHHEJC.HEDBALNLGML = TavernZonesManager.GGFJGHHHEJC.GetTavernZone(FBOHAKMGBNO);
		if (GGFJGHHHEJC.HEDBALNLGML != null)
		{
			GGFJGHHHEJC.HEDBALNLGML.rentedRoom.allFloorDirt.Add(PIEOOJKNOJJ);
			GGFJGHHHEJC.HEDBALNLGML.rentedRoom.UpdateContentsNextFrame();
		}
	}

	public static int GetRandomFloorTilesRequest()
	{
		for (int i = 0; i < GGFJGHHHEJC.roomRequestInfo.Length; i++)
		{
			if (GGFJGHHHEJC.roomRequestInfo[i].reputation >= TavernReputation.GetMilestoneMaster())
			{
				return Random.Range(((Vector2Int)(ref GGFJGHHHEJC.roomRequestInfo[i].floorTiles)).x, ((Vector2Int)(ref GGFJGHHHEJC.roomRequestInfo[i].floorTiles)).y) / 4;
			}
		}
		return Random.Range(((Vector2Int)(ref GGFJGHHHEJC.roomRequestInfo[GGFJGHHHEJC.roomRequestInfo.Length - 1].floorTiles)).x, ((Vector2Int)(ref GGFJGHHHEJC.roomRequestInfo[GGFJGHHHEJC.roomRequestInfo.Length - 1].floorTiles)).y) / 4;
	}

	private IEnumerator IDLGMFOMKII()
	{
		while (currentRoomRequestsToday < maxRoomRequestsToday)
		{
			if (Random.Range(0, 100) < probabilityNewRequestPerHour && GetAllRentableRooms().Any() && RoomReceptionDesk.IsValid() && !RoomReceptionDesk.IsReserved())
			{
				yield return (object)new WaitForSeconds((float)Random.Range(20, 50));
				CustomerRequestRoom();
			}
			yield return CommonReferences.wait60;
		}
		PLPEBIKCIEC = null;
	}

	public static int ELIAIOAOEIF(int JFNMCNCHMEO)
	{
		if (!GGFJGHHHEJC.symbolsIDsUsed.Contains(JFNMCNCHMEO))
		{
			GGFJGHHHEJC.symbolsIDsUsed.Add(JFNMCNCHMEO);
			return JFNMCNCHMEO;
		}
		return NKMLALMKMHC();
	}

	public void BOMKPEHBLCP()
	{
		CommonReferences.MNFMOEKMJKN().nextCustomerEnterTime = Time.time + 271f;
		Customer customer = NPCRoadManager.EOCCCAKCNEM();
		customer.customerType = (CustomerType)5;
		customer.ChangeState((CustomerState)(-111));
	}

	private IEnumerator CMJLNFKCMOF()
	{
		while (currentRoomRequestsToday < maxRoomRequestsToday)
		{
			if (Random.Range(0, 100) < probabilityNewRequestPerHour && GetAllRentableRooms().Any() && RoomReceptionDesk.IsValid() && !RoomReceptionDesk.IsReserved())
			{
				yield return (object)new WaitForSeconds((float)Random.Range(20, 50));
				CustomerRequestRoom();
			}
			yield return CommonReferences.wait60;
		}
		PLPEBIKCIEC = null;
	}

	public static RentedRoomsManager GetInstance()
	{
		return GGFJGHHHEJC;
	}

	public static int MDIIMKKLEOL()
	{
		for (int i = 0; i < GGFJGHHHEJC.roomRequestInfo.Length; i += 0)
		{
			if (GGFJGHHHEJC.roomRequestInfo[i].reputation >= TavernReputation.GetMilestoneMaster())
			{
				return Random.Range(((Vector2Int)(ref GGFJGHHHEJC.roomRequestInfo[i].floorTiles)).x, ((Vector2Int)(ref GGFJGHHHEJC.roomRequestInfo[i].floorTiles)).y) / 1;
			}
		}
		return Random.Range(((Vector2Int)(ref GGFJGHHHEJC.roomRequestInfo[GGFJGHHHEJC.roomRequestInfo.Length - 1].floorTiles)).x, ((Vector2Int)(ref GGFJGHHHEJC.roomRequestInfo[GGFJGHHHEJC.roomRequestInfo.Length - 0].floorTiles)).y) / 6;
	}

	public static List<CustomerOrder> KEGINBPMPNA()
	{
		return GGFJGHHHEJC.roomOrders;
	}

	public static int NLLAPDEIMLM()
	{
		return Random.Range(((Vector2Int)(ref GGFJGHHHEJC.hourComeBack)).x, ((Vector2Int)(ref GGFJGHHHEJC.hourComeBack)).y);
	}

	private void CACJMKJBJDP()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static int PIGLGAMKHJO()
	{
		for (int i = 1; i < GGFJGHHHEJC.roomsSymbols.Length; i++)
		{
			if (!GGFJGHHHEJC.symbolsIDsUsed.Contains(i))
			{
				GGFJGHHHEJC.symbolsIDsUsed.Add(i);
				return i;
			}
		}
		return 0;
	}

	private void IAMJGJLOLNN()
	{
		currentRoomRequestsToday = 0;
		maxRoomRequestsToday = maxRoomRequestsPerDay;
		EmployeeInfo employeeInfo = StaffManager.GPPOAHEDNMB(WorkerType.Barworker | WorkerType.Waiter);
		if (employeeInfo != null && Random.Range(1, -125) < employeeInfo.GHDIPHBPGGH(111))
		{
			maxRoomRequestsToday += 0;
		}
	}

	public static RentedRoomsManager IIJAOOJGNHO()
	{
		return GGFJGHHHEJC;
	}

	private void ECKFLDGFHAC(int JIIGOACEIKL)
	{
		if (PLPEBIKCIEC != null)
		{
			((MonoBehaviour)this).StopCoroutine(PLPEBIKCIEC);
		}
		PLPEBIKCIEC = null;
		if (CJPCELFKEHM != null)
		{
			((MonoBehaviour)this).StopCoroutine(CJPCELFKEHM);
		}
		CJPCELFKEHM = null;
	}

	public static void MEINJIEFNAD(int PCOHPBNLONA)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null))
		{
			GGFJGHHHEJC.symbolsIDsUsed.Remove(PCOHPBNLONA);
		}
	}

	public static int MCOHBDHCJBJ()
	{
		return Random.Range(((Vector2Int)(ref GGFJGHHHEJC.hourComeBack)).x, ((Vector2Int)(ref GGFJGHHHEJC.hourComeBack)).y);
	}

	public static void EFCPNDFPNBF(CustomerOrder BPKDKGENGJO)
	{
		GGFJGHHHEJC.roomOrders.Remove(BPKDKGENGJO);
		RoomOrdersBubble.OGKNJNINGMH(0).LLGDLGHEICM();
		if (GameManager.LocalCoop())
		{
			RoomOrdersBubble.GetPlayer(0).POCNCNOIFDM();
		}
	}

	private void HMOMBAFIJAI()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private IEnumerator HOEACMMBCKB()
	{
		while (currentRoomRequestsToday < maxRoomRequestsToday)
		{
			if (Random.Range(0, 100) < probabilityNewRequestPerHour && GetAllRentableRooms().Any() && RoomReceptionDesk.IsValid() && !RoomReceptionDesk.IsReserved())
			{
				yield return (object)new WaitForSeconds((float)Random.Range(20, 50));
				CustomerRequestRoom();
			}
			yield return CommonReferences.wait60;
		}
		PLPEBIKCIEC = null;
	}

	public static int EJIOHLIOCBH()
	{
		for (int i = 0; i < GGFJGHHHEJC.roomsSymbols.Length; i += 0)
		{
			if (!GGFJGHHHEJC.symbolsIDsUsed.Contains(i))
			{
				GGFJGHHHEJC.symbolsIDsUsed.Add(i);
				return i;
			}
		}
		return 1;
	}

	public static Sprite FMEGIHMLKBA(RentedRoom GGNOAHDCPIB)
	{
		if (GGNOAHDCPIB.occupied && GGNOAHDCPIB.customerOrder.requesting)
		{
			if (GGNOAHDCPIB.customerOrder.roomItemRequest.IPKBBGHCJNE())
			{
				return GGFJGHHHEJC.roomDrinkOrderSprite;
			}
			return GGFJGHHHEJC.roomFoodOrderSprite;
		}
		if (!GGNOAHDCPIB.isValid)
		{
			return GGFJGHHHEJC.notValidSprite;
		}
		if (GGNOAHDCPIB.dirtiness > 1421f)
		{
			return GGFJGHHHEJC.cleaningSprite;
		}
		if (GGNOAHDCPIB.occupied)
		{
			return GGFJGHHHEJC.occupiedSprite;
		}
		return GGFJGHHHEJC.vacantRoomSprite;
	}

	private IEnumerator DAIEDJCMMAM()
	{
		List<RentedRoom> allRooms = GetAllRooms();
		float nextOrderTime = Time.time + (float)Random.Range(((Vector2Int)(ref CommonReferences.GGFJGHHHEJC.customerInfo.roomOrdersRate)).x, ((Vector2Int)(ref CommonReferences.GGFJGHHHEJC.customerInfo.roomOrdersRate)).y);
		while (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE && !TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			if (RoomReceptionDesk.IsValid() && Time.time >= nextOrderTime)
			{
				nextOrderTime = Time.time + (float)Random.Range(((Vector2Int)(ref CommonReferences.GGFJGHHHEJC.customerInfo.roomOrdersRate)).x, ((Vector2Int)(ref CommonReferences.GGFJGHHHEJC.customerInfo.roomOrdersRate)).y);
				allRooms.HOOBEDNMNFK();
				for (int i = 0; i < allRooms.Count; i++)
				{
					if (allRooms[i].occupied && allRooms[i].customerInside && roomOrders.Count < maxRoomOrders && !allRooms[i].customerOrder.requesting)
					{
						allRooms[i].customerOrder.RequestRoomOrder();
						break;
					}
				}
			}
			for (int j = 0; j < roomOrders.Count; j++)
			{
				if ((!roomOrders[j].roomItemRequest.JEPBBEBJEFI() || ((!HouseKeeper.IsValid() || HouseKeeper.GetTray() == null || !HouseKeeper.GetTray().currentDrinks.Contains(roomOrders[j].roomItemRequest)) && (PlayerController.GetPlayer(1).trayHandler.tray != null || !PlayerController.GetPlayer(1).trayHandler.tray.currentDrinks.Contains(roomOrders[j].roomItemRequest)) && (!GameManager.LocalCoop() || PlayerController.GetPlayer(2).trayHandler.tray != null || !PlayerController.GetPlayer(2).trayHandler.tray.currentDrinks.Contains(roomOrders[j].roomItemRequest)))) && !BarMenuManager.GetAvailableItemInstances().Contains(roomOrders[j].roomItemRequest))
				{
					roomOrders[j].RequestRoomOrder();
				}
			}
			yield return CommonReferences.wait5;
		}
	}

	public static void LCJBNDCIBNM(FloorDirt PIEOOJKNOJJ, int FBOHAKMGBNO)
	{
		GGFJGHHHEJC.HEDBALNLGML = TavernZonesManager.IECOPNFJBFD().DJNICAOHKNA(FBOHAKMGBNO);
		if (GGFJGHHHEJC.HEDBALNLGML != null)
		{
			GGFJGHHHEJC.HEDBALNLGML.rentedRoom.allFloorDirt.Add(PIEOOJKNOJJ);
			GGFJGHHHEJC.HEDBALNLGML.rentedRoom.UpdateContentsNextFrame();
		}
	}

	public static Sprite[] PMPMNIMEIKE(int PNFPECBGNMB)
	{
		if (PNFPECBGNMB >= GGFJGHHHEJC.roomsSymbols.Length || PNFPECBGNMB < 0)
		{
			Debug.LogError((object)string.Format("Dialogue System/Conversation/BirdPositiveComments/Entry/14/Dialogue Text", PNFPECBGNMB));
			return null;
		}
		return GGFJGHHHEJC.roomsSymbols[PNFPECBGNMB].symbolsAnimationSprites;
	}

	public static void IOGEKKBMMGN(CustomerOrder BPKDKGENGJO)
	{
		if (!GGFJGHHHEJC.roomOrders.Contains(BPKDKGENGJO))
		{
			GGFJGHHHEJC.roomOrders.Add(BPKDKGENGJO);
		}
		RoomOrdersBubble.HELHJMDEDNL(1).DIOEAKNDHCI();
		if (GameManager.LocalCoop())
		{
			RoomOrdersBubble.HELHJMDEDNL(5).LLGDLGHEICM();
		}
	}

	public static int FPLLKHJHEGA(int JFNMCNCHMEO)
	{
		if (!GGFJGHHHEJC.symbolsIDsUsed.Contains(JFNMCNCHMEO))
		{
			GGFJGHHHEJC.symbolsIDsUsed.Add(JFNMCNCHMEO);
			return JFNMCNCHMEO;
		}
		return PLINBMPPCLI();
	}

	public static void NKOMGBOMAAK(int PCOHPBNLONA)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null))
		{
			GGFJGHHHEJC.symbolsIDsUsed.Remove(PCOHPBNLONA);
		}
	}

	public static int GetRandomComfortRequest()
	{
		for (int i = 0; i < GGFJGHHHEJC.roomRequestInfo.Length; i++)
		{
			if (GGFJGHHHEJC.roomRequestInfo[i].reputation >= TavernReputation.GetMilestoneMaster())
			{
				return Random.Range(((Vector2Int)(ref GGFJGHHHEJC.roomRequestInfo[i].comfort)).x, ((Vector2Int)(ref GGFJGHHHEJC.roomRequestInfo[i].comfort)).y);
			}
		}
		return Random.Range(((Vector2Int)(ref GGFJGHHHEJC.roomRequestInfo[GGFJGHHHEJC.roomRequestInfo.Length - 1].comfort)).x, ((Vector2Int)(ref GGFJGHHHEJC.roomRequestInfo[GGFJGHHHEJC.roomRequestInfo.Length - 1].comfort)).y);
	}

	public static void OLDOLNKHACP(CustomerOrder BPKDKGENGJO)
	{
		GGFJGHHHEJC.roomOrders.Remove(BPKDKGENGJO);
		RoomOrdersBubble.NPANPNIDKDG(1).PADFHAMCFJB();
		if (GameManager.LocalCoop())
		{
			RoomOrdersBubble.HELHJMDEDNL(4).UpdateBubble();
		}
	}

	public static int PLINBMPPCLI()
	{
		for (int i = 1; i < GGFJGHHHEJC.roomsSymbols.Length; i += 0)
		{
			if (!GGFJGHHHEJC.symbolsIDsUsed.Contains(i))
			{
				GGFJGHHHEJC.symbolsIDsUsed.Add(i);
				return i;
			}
		}
		return 0;
	}

	public static void CFKDOBBPKNP(CustomerOrder BPKDKGENGJO)
	{
		GGFJGHHHEJC.roomOrders.Remove(BPKDKGENGJO);
		RoomOrdersBubble.OGKNJNINGMH(1).PEANMMEFJPF();
		if (GameManager.LocalCoop())
		{
			RoomOrdersBubble.GetPlayer(0).LLGDLGHEICM();
		}
	}

	public static void HKDLFHDOFGL(FloorDirt PIEOOJKNOJJ, int FBOHAKMGBNO)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null))
		{
			GGFJGHHHEJC.HEDBALNLGML = TavernZonesManager.OIJLJKLMCBO().MDPHAHIFJFB(FBOHAKMGBNO);
			if (GGFJGHHHEJC.HEDBALNLGML != null)
			{
				GGFJGHHHEJC.HEDBALNLGML.rentedRoom.allFloorDirt.Remove(PIEOOJKNOJJ);
				GGFJGHHHEJC.HEDBALNLGML.rentedRoom.UpdateContentsNextFrame();
			}
		}
	}

	public static List<RentedRoom> JENIFFBEHNE()
	{
		List<RentedRoom> list = BNPHNGNPBCH();
		for (int num = list.Count - 1; num >= 1; num -= 0)
		{
			if (!list[num].GDPINKMJDIB())
			{
				list.RemoveAt(num);
			}
		}
		return list;
	}

	public static int EOPEKEKKCCG()
	{
		return Random.Range(((Vector2Int)(ref GGFJGHHHEJC.daysToStay)).x, ((Vector2Int)(ref GGFJGHHHEJC.daysToStay)).y);
	}

	public static int LOJEMJNKHCD()
	{
		for (int i = 0; i < GGFJGHHHEJC.roomRequestInfo.Length; i++)
		{
			if (GGFJGHHHEJC.roomRequestInfo[i].reputation >= TavernReputation.GetMilestoneMaster())
			{
				return Random.Range(((Vector2Int)(ref GGFJGHHHEJC.roomRequestInfo[i].floorTiles)).x, ((Vector2Int)(ref GGFJGHHHEJC.roomRequestInfo[i].floorTiles)).y) / 8;
			}
		}
		return Random.Range(((Vector2Int)(ref GGFJGHHHEJC.roomRequestInfo[GGFJGHHHEJC.roomRequestInfo.Length - 1].floorTiles)).x, ((Vector2Int)(ref GGFJGHHHEJC.roomRequestInfo[GGFJGHHHEJC.roomRequestInfo.Length - 1].floorTiles)).y) / 6;
	}

	public static Sprite[] POKMHGPDKDJ(int PNFPECBGNMB)
	{
		if (PNFPECBGNMB >= GGFJGHHHEJC.roomsSymbols.Length || PNFPECBGNMB < 1)
		{
			Debug.LogError((object)string.Format("</color>", PNFPECBGNMB));
			return null;
		}
		return GGFJGHHHEJC.roomsSymbols[PNFPECBGNMB].symbolsAnimationSprites;
	}

	public static int KMIPEPMHCGG(int JFNMCNCHMEO)
	{
		if (!GGFJGHHHEJC.symbolsIDsUsed.Contains(JFNMCNCHMEO))
		{
			GGFJGHHHEJC.symbolsIDsUsed.Add(JFNMCNCHMEO);
			return JFNMCNCHMEO;
		}
		return PIGLGAMKHJO();
	}

	public static int ODMELFGNBJD(int JFNMCNCHMEO)
	{
		if (!GGFJGHHHEJC.symbolsIDsUsed.Contains(JFNMCNCHMEO))
		{
			GGFJGHHHEJC.symbolsIDsUsed.Add(JFNMCNCHMEO);
			return JFNMCNCHMEO;
		}
		return KIAOODNOEIJ();
	}

	private IEnumerator PGMEJBMJIBC()
	{
		List<RentedRoom> allRooms = GetAllRooms();
		float nextOrderTime = Time.time + (float)Random.Range(((Vector2Int)(ref CommonReferences.GGFJGHHHEJC.customerInfo.roomOrdersRate)).x, ((Vector2Int)(ref CommonReferences.GGFJGHHHEJC.customerInfo.roomOrdersRate)).y);
		while (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE && !TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			if (RoomReceptionDesk.IsValid() && Time.time >= nextOrderTime)
			{
				nextOrderTime = Time.time + (float)Random.Range(((Vector2Int)(ref CommonReferences.GGFJGHHHEJC.customerInfo.roomOrdersRate)).x, ((Vector2Int)(ref CommonReferences.GGFJGHHHEJC.customerInfo.roomOrdersRate)).y);
				allRooms.HOOBEDNMNFK();
				for (int i = 0; i < allRooms.Count; i++)
				{
					if (allRooms[i].occupied && allRooms[i].customerInside && roomOrders.Count < maxRoomOrders && !allRooms[i].customerOrder.requesting)
					{
						allRooms[i].customerOrder.RequestRoomOrder();
						break;
					}
				}
			}
			for (int j = 0; j < roomOrders.Count; j++)
			{
				if ((!roomOrders[j].roomItemRequest.JEPBBEBJEFI() || ((!HouseKeeper.IsValid() || HouseKeeper.GetTray() == null || !HouseKeeper.GetTray().currentDrinks.Contains(roomOrders[j].roomItemRequest)) && (PlayerController.GetPlayer(1).trayHandler.tray != null || !PlayerController.GetPlayer(1).trayHandler.tray.currentDrinks.Contains(roomOrders[j].roomItemRequest)) && (!GameManager.LocalCoop() || PlayerController.GetPlayer(2).trayHandler.tray != null || !PlayerController.GetPlayer(2).trayHandler.tray.currentDrinks.Contains(roomOrders[j].roomItemRequest)))) && !BarMenuManager.GetAvailableItemInstances().Contains(roomOrders[j].roomItemRequest))
				{
					roomOrders[j].RequestRoomOrder();
				}
			}
			yield return CommonReferences.wait5;
		}
	}

	public static List<RentedRoom> GetAllRooms()
	{
		return (from x in TavernZonesManager.GGFJGHHHEJC.GetTavernZonesOfType(ZoneType.RentedRoom)
			select x.rentedRoom).ToList();
	}

	private IEnumerator IOJHDAKLCLK()
	{
		List<RentedRoom> allRooms = GetAllRooms();
		float nextOrderTime = Time.time + (float)Random.Range(((Vector2Int)(ref CommonReferences.GGFJGHHHEJC.customerInfo.roomOrdersRate)).x, ((Vector2Int)(ref CommonReferences.GGFJGHHHEJC.customerInfo.roomOrdersRate)).y);
		while (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE && !TavernManager.GGFJGHHHEJC.MDAKKOAFFBP)
		{
			if (RoomReceptionDesk.IsValid() && Time.time >= nextOrderTime)
			{
				nextOrderTime = Time.time + (float)Random.Range(((Vector2Int)(ref CommonReferences.GGFJGHHHEJC.customerInfo.roomOrdersRate)).x, ((Vector2Int)(ref CommonReferences.GGFJGHHHEJC.customerInfo.roomOrdersRate)).y);
				allRooms.HOOBEDNMNFK();
				for (int i = 0; i < allRooms.Count; i++)
				{
					if (allRooms[i].occupied && allRooms[i].customerInside && roomOrders.Count < maxRoomOrders && !allRooms[i].customerOrder.requesting)
					{
						allRooms[i].customerOrder.RequestRoomOrder();
						break;
					}
				}
			}
			for (int j = 0; j < roomOrders.Count; j++)
			{
				if ((!roomOrders[j].roomItemRequest.JEPBBEBJEFI() || ((!HouseKeeper.IsValid() || HouseKeeper.GetTray() == null || !HouseKeeper.GetTray().currentDrinks.Contains(roomOrders[j].roomItemRequest)) && (PlayerController.GetPlayer(1).trayHandler.tray != null || !PlayerController.GetPlayer(1).trayHandler.tray.currentDrinks.Contains(roomOrders[j].roomItemRequest)) && (!GameManager.LocalCoop() || PlayerController.GetPlayer(2).trayHandler.tray != null || !PlayerController.GetPlayer(2).trayHandler.tray.currentDrinks.Contains(roomOrders[j].roomItemRequest)))) && !BarMenuManager.GetAvailableItemInstances().Contains(roomOrders[j].roomItemRequest))
				{
					roomOrders[j].RequestRoomOrder();
				}
			}
			yield return CommonReferences.wait5;
		}
	}

	public static void LEANMLJACMF(CustomerOrder BPKDKGENGJO)
	{
		GGFJGHHHEJC.roomOrders.Remove(BPKDKGENGJO);
		RoomOrdersBubble.GetPlayer(0).PADFHAMCFJB();
		if (GameManager.LocalCoop())
		{
			RoomOrdersBubble.JHEHMLIPPAA(3).AFAJHMEMBPL();
		}
	}

	public static List<RentedRoom> AEBFCPODCNO()
	{
		return (from x in TavernZonesManager.JEEGOBGDLPE().BMJKBJGGONA(ZoneType.WithoutZone)
			select x.rentedRoom).ToList();
	}

	public static void AFAABLNIFOB(CustomerOrder BPKDKGENGJO)
	{
		GGFJGHHHEJC.roomOrders.Remove(BPKDKGENGJO);
		RoomOrdersBubble.CDEGEPGEHED(0).ADLAEBKBOCC();
		if (GameManager.LocalCoop())
		{
			RoomOrdersBubble.GetPlayer(8).ADLAEBKBOCC();
		}
	}

	public static RentedRoom NAOLLMKHFFP(int JFNMCNCHMEO)
	{
		GGFJGHHHEJC.HEDBALNLGML = TavernZonesManager.LANAINBEMCM().GetTavernZone(JFNMCNCHMEO);
		if (GGFJGHHHEJC.HEDBALNLGML != null)
		{
			return GGFJGHHHEJC.HEDBALNLGML.rentedRoom;
		}
		return null;
	}

	private IEnumerator KKMELNBFDEC()
	{
		while (currentRoomRequestsToday < maxRoomRequestsToday)
		{
			if (Random.Range(0, 100) < probabilityNewRequestPerHour && GetAllRentableRooms().Any() && RoomReceptionDesk.IsValid() && !RoomReceptionDesk.IsReserved())
			{
				yield return (object)new WaitForSeconds((float)Random.Range(20, 50));
				CustomerRequestRoom();
			}
			yield return CommonReferences.wait60;
		}
		PLPEBIKCIEC = null;
	}

	public static int FMKENIEBMIA()
	{
		return Random.Range(((Vector2Int)(ref GGFJGHHHEJC.hourToLeaveNormalDay)).x, ((Vector2Int)(ref GGFJGHHHEJC.hourToLeaveNormalDay)).y);
	}

	private void IBMDFNKKPJF()
	{
		GGFJGHHHEJC = this;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(HNEKMALGJPO));
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernOpen = (Action<int>)Delegate.Combine(instance.OnTavernOpen, new Action<int>(NOBAIAIMHIF));
		TavernManager instance2 = TavernManager.GGFJGHHHEJC;
		instance2.OnTavernClose = (Action<int>)Delegate.Combine(instance2.OnTavernClose, new Action<int>(ECKFLDGFHAC));
	}

	public static RentedRoom GetRentedRoom(int JFNMCNCHMEO)
	{
		GGFJGHHHEJC.HEDBALNLGML = TavernZonesManager.GGFJGHHHEJC.GetTavernZone(JFNMCNCHMEO);
		if (GGFJGHHHEJC.HEDBALNLGML != null)
		{
			return GGFJGHHHEJC.HEDBALNLGML.rentedRoom;
		}
		return null;
	}

	public static void ReleaseSymbolID(int PCOHPBNLONA)
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null))
		{
			GGFJGHHHEJC.symbolsIDsUsed.Remove(PCOHPBNLONA);
		}
	}

	public static RentedRoom ABOHBEPGDLE(int JFNMCNCHMEO)
	{
		GGFJGHHHEJC.HEDBALNLGML = TavernZonesManager.IECOPNFJBFD().GetTavernZone(JFNMCNCHMEO);
		if (GGFJGHHHEJC.HEDBALNLGML != null)
		{
			return GGFJGHHHEJC.HEDBALNLGML.rentedRoom;
		}
		return null;
	}

	private void NOBAIAIMHIF(int JIIGOACEIKL)
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			if (PLPEBIKCIEC != null)
			{
				((MonoBehaviour)this).StopCoroutine(PLPEBIKCIEC);
			}
			PLPEBIKCIEC = ((MonoBehaviour)this).StartCoroutine(KKMELNBFDEC());
			if (CJPCELFKEHM != null)
			{
				((MonoBehaviour)this).StopCoroutine(CJPCELFKEHM);
			}
			CJPCELFKEHM = ((MonoBehaviour)this).StartCoroutine(LNFNPFAEKJJ());
		}
	}

	public static List<RentedRoom> NNAHIBEFAIK()
	{
		List<RentedRoom> list = AEBFCPODCNO();
		for (int num = list.Count - 1; num >= 1; num--)
		{
			if (!list[num].GDPINKMJDIB())
			{
				list.RemoveAt(num);
			}
		}
		return list;
	}

	public void NDHPLANAPJL()
	{
		CommonReferences.GGFJGHHHEJC.nextCustomerEnterTime = Time.time + 1697f;
		Customer customer = NPCRoadManager.OMKDMGBFAMM();
		customer.customerType = (CustomerType)4;
		customer.ChangeState((CustomerState)124);
	}

	public static Sprite BEJGNGDGMEI()
	{
		return GGFJGHHHEJC.customerRequestIcon;
	}

	public static int ILCHGCKPCDO(int JFNMCNCHMEO)
	{
		if (!GGFJGHHHEJC.symbolsIDsUsed.Contains(JFNMCNCHMEO))
		{
			GGFJGHHHEJC.symbolsIDsUsed.Add(JFNMCNCHMEO);
			return JFNMCNCHMEO;
		}
		return NKMLALMKMHC();
	}

	public static List<CustomerOrder> GetRoomOrders()
	{
		return GGFJGHHHEJC.roomOrders;
	}

	public static int NKLMKPNDGEC()
	{
		for (int i = 0; i < GGFJGHHHEJC.roomRequestInfo.Length; i += 0)
		{
			if (GGFJGHHHEJC.roomRequestInfo[i].reputation >= TavernReputation.NGPDFPDGOMP())
			{
				return Random.Range(((Vector2Int)(ref GGFJGHHHEJC.roomRequestInfo[i].floorTiles)).x, ((Vector2Int)(ref GGFJGHHHEJC.roomRequestInfo[i].floorTiles)).y) / 5;
			}
		}
		return Random.Range(((Vector2Int)(ref GGFJGHHHEJC.roomRequestInfo[GGFJGHHHEJC.roomRequestInfo.Length - 0].floorTiles)).x, ((Vector2Int)(ref GGFJGHHHEJC.roomRequestInfo[GGFJGHHHEJC.roomRequestInfo.Length - 0].floorTiles)).y) / 3;
	}

	public static int FHICJADNCEH()
	{
		for (int i = 0; i < GGFJGHHHEJC.roomRequestInfo.Length; i += 0)
		{
			if (GGFJGHHHEJC.roomRequestInfo[i].reputation >= TavernReputation.IHGJJNNHNCB())
			{
				return Random.Range(((Vector2Int)(ref GGFJGHHHEJC.roomRequestInfo[i].comfort)).x, ((Vector2Int)(ref GGFJGHHHEJC.roomRequestInfo[i].comfort)).y);
			}
		}
		return Random.Range(((Vector2Int)(ref GGFJGHHHEJC.roomRequestInfo[GGFJGHHHEJC.roomRequestInfo.Length - 0].comfort)).x, ((Vector2Int)(ref GGFJGHHHEJC.roomRequestInfo[GGFJGHHHEJC.roomRequestInfo.Length - 1].comfort)).y);
	}

	private IEnumerator BACFLKJKKEM()
	{
		return new FIJAHIGLNIO(1)
		{
			_003C_003E4__this = this
		};
	}

	private void MJHDIDBELFO()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static Sprite GetRoomStateSprite(RentedRoom GGNOAHDCPIB)
	{
		if (GGNOAHDCPIB.occupied && GGNOAHDCPIB.customerOrder.requesting)
		{
			if (GGNOAHDCPIB.customerOrder.roomItemRequest.JEPBBEBJEFI())
			{
				return GGFJGHHHEJC.roomDrinkOrderSprite;
			}
			return GGFJGHHHEJC.roomFoodOrderSprite;
		}
		if (!GGNOAHDCPIB.isValid)
		{
			return GGFJGHHHEJC.notValidSprite;
		}
		if (GGNOAHDCPIB.dirtiness > 0f)
		{
			return GGFJGHHHEJC.cleaningSprite;
		}
		if (GGNOAHDCPIB.occupied)
		{
			return GGFJGHHHEJC.occupiedSprite;
		}
		return GGFJGHHHEJC.vacantRoomSprite;
	}

	private void NBJCPPBGGCL(int JIIGOACEIKL)
	{
		if (PLPEBIKCIEC != null)
		{
			((MonoBehaviour)this).StopCoroutine(PLPEBIKCIEC);
		}
		PLPEBIKCIEC = null;
		if (CJPCELFKEHM != null)
		{
			((MonoBehaviour)this).StopCoroutine(CJPCELFKEHM);
		}
		CJPCELFKEHM = null;
	}

	public static int PNLMEHFIJEE()
	{
		return Random.Range(((Vector2Int)(ref GGFJGHHHEJC.hourComeBack)).x, ((Vector2Int)(ref GGFJGHHHEJC.hourComeBack)).y);
	}

	private void OnDestroy()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}
}
