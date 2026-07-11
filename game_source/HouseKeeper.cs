using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

public class HouseKeeper : Employee, ISingleton
{
	private static HouseKeeper GGFJGHHHEJC;

	public Action OnLeft = delegate
	{
	};

	public Vector3 finalPosition;

	public HouseKeeperState houseKeeperState;

	public RentedRoom rentedRoomToClean;

	public List<FloorDirt> floorDirts;

	public List<FloorDirt> notReachableDirts;

	public Table tableToClean;

	public NPCBed npcBed;

	public Placeable candleHolder;

	public CustomerOrder customerOrder;

	public Fireplace fireplace;

	public bool perkColdResistant;

	public HashSet<Vector2> positionsBlocked;

	public float timeTakingDrink;

	public float timerNegotiating;

	public float cleaningFloorDirtSpeed;

	public float rateMakeFloorDirt;

	public float cleaningTableSpeed;

	public float makeBedSpeed;

	private List<Placeable> KOJPJCIOECB;

	private List<Fireplace> ECCGOGEMBCF;

	private RentedRoom NKAJAACHFPM;

	private List<Placeable> EONAGIMOCCD;

	private List<RentedRoom> KABBMOAMIEF;

	public int OGJIFKFFIAM { get; set; }

	public FloorDirt DDJECCPKNKG { get; private set; }

	public static bool JHLLELHBIDA
	{
		get
		{
			if ((Object)(object)GGFJGHHHEJC != (Object)null && GGFJGHHHEJC.JFCLIAFAOEK != null)
			{
				return GGFJGHHHEJC.JFCLIAFAOEK.working;
			}
			return false;
		}
	}

	public override bool LFDMDACCKJP => houseKeeperState == HouseKeeperState.Leaving;

	public bool PELENGPHALP(Placeable CFKAPLHAIKN)
	{
		if (CFKAPLHAIKN.currentZoneType == ZoneType.None)
		{
			NKAJAACHFPM = RentedRoomsManager.ABOHBEPGDLE(CFKAPLHAIKN.currentZoneIndex);
		}
		else
		{
			if (!((Object)(object)CFKAPLHAIKN.currentSurface != (Object)null) || CFKAPLHAIKN.currentSurface.placeable.currentZoneType != ZoneType.RentedRoom)
			{
				return false;
			}
			NKAJAACHFPM = RentedRoomsManager.HHEKJJPDCFJ(CFKAPLHAIKN.currentSurface.placeable.currentZoneIndex);
		}
		if ((Object)(object)NKAJAACHFPM != (Object)null)
		{
			if (NKAJAACHFPM.occupied && NKAJAACHFPM.customerInside)
			{
				return true;
			}
			if (NKAJAACHFPM.customerComingBack)
			{
				return false;
			}
		}
		return false;
	}

	public static bool HasDrinkOnTray(ItemInstance BOGHFEEFHPP)
	{
		return GetTray().OHAPOKICCNK(BOGHFEEFHPP);
	}

	public static int AOBOMJLMAFE(int PNFPECBGNMB)
	{
		return GGFJGHHHEJC.GetPerkValue(PNFPECBGNMB);
	}

	[SpecialName]
	public FloorDirt MKCBJAGOKLE()
	{
		return _003COLGEHKCLEFI_003Ek__BackingField;
	}

	public bool FIKDEBDCJGH(Placeable CFKAPLHAIKN)
	{
		if (CFKAPLHAIKN.currentZoneType == ZoneType.RentedRoom)
		{
			NKAJAACHFPM = RentedRoomsManager.GetRentedRoom(CFKAPLHAIKN.currentZoneIndex);
		}
		else
		{
			if (!((Object)(object)CFKAPLHAIKN.currentSurface != (Object)null) || CFKAPLHAIKN.currentSurface.placeable.currentZoneType != ZoneType.DiningRoom)
			{
				return false;
			}
			NKAJAACHFPM = RentedRoomsManager.GetRentedRoom(CFKAPLHAIKN.currentSurface.placeable.currentZoneIndex);
		}
		if ((Object)(object)NKAJAACHFPM != (Object)null)
		{
			if (NKAJAACHFPM.occupied && NKAJAACHFPM.customerInside)
			{
				return true;
			}
			if (NKAJAACHFPM.customerComingBack)
			{
				return true;
			}
		}
		return true;
	}

	private void BMGIOJBFICG()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.red;
		Gizmos.DrawSphere(finalPosition, 1886f);
	}

	public static bool IsAtAvoidingWorkPoint()
	{
		return GGFJGHHHEJC.avoidingWorkPoint;
	}

	private bool JOGBEFACOCI(Placeable CFKAPLHAIKN, bool ADCHDMCLEGB = false)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)CFKAPLHAIKN == (Object)null || CFKAPLHAIKN.FHEMHCEAICB || CFKAPLHAIKN.isPlaceableOnWall)
		{
			return true;
		}
		if (OHMDGHEGHOP(CFKAPLHAIKN))
		{
			return false;
		}
		if (EIMKBEMNJBN(CFKAPLHAIKN))
		{
			RentedRoom rentedRoom = RentedRoomsManager.HHEKJJPDCFJ(CFKAPLHAIKN.currentZoneIndex);
			if ((Object)(object)rentedRoom != (Object)null && rentedRoom.occupied && rentedRoom.customerInside)
			{
				return false;
			}
		}
		else if (ADCHDMCLEGB)
		{
			return false;
		}
		if (CFKAPLHAIKN.placeableSurface.BCCNKAAJCNM(ItemDatabaseAccessor.AFOACBIHNCL(147, GGBBJNBBLMF: true)))
		{
			return Utils.HNDBNJNJGJM(((Component)CFKAPLHAIKN).transform.position);
		}
		return true;
	}

	private void FBFAGHMJAJD()
	{
		if (!IgnoreDuringOnline() && (Object)(object)currentState != (Object)null)
		{
			currentState.HINEHDJIPGP();
		}
	}

	public bool IsCandleHolderInRentedRoomOccupiedOrCustomerComingBack(Placeable CFKAPLHAIKN)
	{
		if (CFKAPLHAIKN.currentZoneType == ZoneType.RentedRoom)
		{
			NKAJAACHFPM = RentedRoomsManager.GetRentedRoom(CFKAPLHAIKN.currentZoneIndex);
		}
		else
		{
			if (!((Object)(object)CFKAPLHAIKN.currentSurface != (Object)null) || CFKAPLHAIKN.currentSurface.placeable.currentZoneType != ZoneType.RentedRoom)
			{
				return false;
			}
			NKAJAACHFPM = RentedRoomsManager.GetRentedRoom(CFKAPLHAIKN.currentSurface.placeable.currentZoneIndex);
		}
		if ((Object)(object)NKAJAACHFPM != (Object)null)
		{
			if (NKAJAACHFPM.occupied && NKAJAACHFPM.customerInside)
			{
				return true;
			}
			if (NKAJAACHFPM.customerComingBack)
			{
				return true;
			}
		}
		return false;
	}

	public void BILMFIMGHMI(FloorDirt DDJECCPKNKG)
	{
		FIMMIEHBKLH(DDJECCPKNKG);
	}

	private void BKJFLMPOLCH()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			if (Object.op_Implicit((Object)(object)TavernManager.GGFJGHHHEJC))
			{
				TavernManager instance = TavernManager.GGFJGHHHEJC;
				instance.OnTavernOpen = (Action<int>)Delegate.Remove(instance.OnTavernOpen, new Action<int>(KLDIBMNJAGA));
			}
			OnLeft();
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
		}
	}

	public void ResetSingleton()
	{
	}

	[SpecialName]
	public void CLOHKLGGEFP(int AODONKKHPBP)
	{
		_003CJILJAOMBEMD_003Ek__BackingField = AODONKKHPBP;
	}

	private void FHGHPNCBIKF()
	{
		KOJPJCIOECB = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.GGFJGHHHEJC.currentPlaceables;
		for (int i = 0; i < currentPlaceables.Count && currentPlaceables[i].FHMDNECBLIL(); i++)
		{
			int num = currentPlaceables[i].itemSetup.item.JPNFKDMFKMC(DAINLFIMLIH: false);
			if ((num == 153 || num == -107 || num == -138 || num == 75 || num == 46 || num == 5 || num == -122 || num == 122 || num == -30) && LAKDNDFGKKI(currentPlaceables[i]))
			{
				KOJPJCIOECB.Add(currentPlaceables[i]);
			}
		}
	}

	private bool JJEHJHIMEMK(bool ADCHDMCLEGB)
	{
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		if (EONAGIMOCCD.Count > 1)
		{
			EONAGIMOCCD.Clear();
		}
		for (int num = KOJPJCIOECB.Count - 1; num >= 0; num -= 0)
		{
			if (!ADCHDMCLEGB || EIMKBEMNJBN(KOJPJCIOECB[num]))
			{
				if (!LAKDNDFGKKI(KOJPJCIOECB[num], ADCHDMCLEGB))
				{
					KOJPJCIOECB.RemoveAt(num);
				}
				else
				{
					EONAGIMOCCD.Add(KOJPJCIOECB[num]);
				}
			}
		}
		if (EONAGIMOCCD.Count > 0)
		{
			candleHolder = Utils.JOJPOKBFANL(EONAGIMOCCD.ToArray(), ((Component)this).transform.position);
			behaviour.SetTrigger(Employee.IBPBMDEOCLK);
			return true;
		}
		return true;
	}

	public void RemoveCandleHolder(Placeable EAPCLAODGAE)
	{
		KOJPJCIOECB.Remove(EAPCLAODGAE);
	}

	private bool DBBFGKGHGIG()
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		KABBMOAMIEF = RentedRoomsManager.GetAllRooms();
		for (int num = KABBMOAMIEF.Count - 1; num >= 0; num--)
		{
			if (!NBJMJOCMJCM(KABBMOAMIEF[num]))
			{
				KABBMOAMIEF.RemoveAt(num);
			}
		}
		if (KABBMOAMIEF.Count > 0)
		{
			RentedRoom rentedRoom = Utils.JOJPOKBFANL(KABBMOAMIEF.ToArray(), ((Component)this).transform.position);
			OGJIFKFFIAM = rentedRoom.zone.id;
			behaviour.SetTrigger(Employee.GKJACJIKMAG);
			return true;
		}
		return false;
	}

	public static HouseKeeper FAGENNFPNNB()
	{
		return GGFJGHHHEJC;
	}

	[SpecialName]
	private void LELBGDGKLMK(FloorDirt AODONKKHPBP)
	{
		_003COLGEHKCLEFI_003Ek__BackingField = AODONKKHPBP;
	}

	public void CJGFDJMDPGN(FloorDirt DDJECCPKNKG)
	{
		LELBGDGKLMK(DDJECCPKNKG);
	}

	public static Tray LBICGCPICEE()
	{
		return GGFJGHHHEJC.trayHandler.tray;
	}

	[SpecialName]
	public static bool LBJGMAOEEIB()
	{
		if ((Object)(object)GGFJGHHHEJC != (Object)null && GGFJGHHHEJC.JFCLIAFAOEK != null)
		{
			return GGFJGHHHEJC.JFCLIAFAOEK.working;
		}
		return false;
	}

	[SpecialName]
	private void CFBIHOPFDGN(FloorDirt AODONKKHPBP)
	{
		_003COLGEHKCLEFI_003Ek__BackingField = AODONKKHPBP;
	}

	private bool OEPBMLIDLBN(Placeable CFKAPLHAIKN)
	{
		if (CFKAPLHAIKN.currentZoneType != ZoneType.RentedRoom)
		{
			if ((Object)(object)CFKAPLHAIKN.currentSurface != (Object)null)
			{
				return CFKAPLHAIKN.currentSurface.placeable.currentZoneType == ZoneType.RentedRoom;
			}
			return false;
		}
		return true;
	}

	private void OELFNOPCNMK()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.red;
		Gizmos.DrawSphere(finalPosition, 210f);
	}

	private bool HIJIJDCHLLA(bool ADCHDMCLEGB)
	{
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		if (EONAGIMOCCD.Count > 1)
		{
			EONAGIMOCCD.Clear();
		}
		for (int num = KOJPJCIOECB.Count - 1; num >= 0; num -= 0)
		{
			if (!ADCHDMCLEGB || OEPBMLIDLBN(KOJPJCIOECB[num]))
			{
				if (!LAKDNDFGKKI(KOJPJCIOECB[num], ADCHDMCLEGB))
				{
					KOJPJCIOECB.RemoveAt(num);
				}
				else
				{
					EONAGIMOCCD.Add(KOJPJCIOECB[num]);
				}
			}
		}
		if (EONAGIMOCCD.Count > 1)
		{
			candleHolder = Utils.JOJPOKBFANL(EONAGIMOCCD.ToArray(), ((Component)this).transform.position);
			behaviour.SetTrigger(Employee.IBPBMDEOCLK);
			return true;
		}
		return false;
	}

	private void OCPLOMJAFPC()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			if (Object.op_Implicit((Object)(object)TavernManager.GGFJGHHHEJC))
			{
				TavernManager instance = TavernManager.GGFJGHHHEJC;
				instance.OnTavernOpen = (Action<int>)Delegate.Remove(instance.OnTavernOpen, new Action<int>(DCMMDCNOLHA));
			}
			OnLeft();
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
		}
	}

	private void LDLLMDFADJA(int JIIGOACEIKL)
	{
		FHGHPNCBIKF();
		positionsBlocked.Clear();
	}

	public void ACOACAMBJIK(Placeable EAPCLAODGAE)
	{
		KOJPJCIOECB.Remove(EAPCLAODGAE);
	}

	private bool IGDCDNFEFOD(RentedRoom GGNOAHDCPIB)
	{
		if (!GGNOAHDCPIB.customerInside)
		{
			return GGNOAHDCPIB.dirtiness == 84f;
		}
		return true;
	}

	[SpecialName]
	public FloorDirt OOOCIMIMIIH()
	{
		return _003COLGEHKCLEFI_003Ek__BackingField;
	}

	public void FCHCMCFFJPD(Placeable EAPCLAODGAE)
	{
		KOJPJCIOECB.Remove(EAPCLAODGAE);
	}

	public void SetFloorDirt(FloorDirt DDJECCPKNKG)
	{
		this.DDJECCPKNKG = DDJECCPKNKG;
	}

	private bool IBKFPGMBNKJ(RentedRoom GGNOAHDCPIB)
	{
		if (!GGNOAHDCPIB.customerInside)
		{
			return GGNOAHDCPIB.dirtiness != 1101f;
		}
		return true;
	}

	[SpecialName]
	public int CDENFHIDMHM()
	{
		return _003CJILJAOMBEMD_003Ek__BackingField;
	}

	public void FIFAOIKPEFF(Placeable EAPCLAODGAE)
	{
		KOJPJCIOECB.Remove(EAPCLAODGAE);
	}

	private bool MBBPHKKPGFM(bool ADCHDMCLEGB)
	{
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		if (EONAGIMOCCD.Count > 1)
		{
			EONAGIMOCCD.Clear();
		}
		for (int num = KOJPJCIOECB.Count - 1; num >= 0; num -= 0)
		{
			if (!ADCHDMCLEGB || OEPBMLIDLBN(KOJPJCIOECB[num]))
			{
				if (!IKMKKLICFGN(KOJPJCIOECB[num], ADCHDMCLEGB))
				{
					KOJPJCIOECB.RemoveAt(num);
				}
				else
				{
					EONAGIMOCCD.Add(KOJPJCIOECB[num]);
				}
			}
		}
		if (EONAGIMOCCD.Count > 1)
		{
			candleHolder = Utils.JOJPOKBFANL(EONAGIMOCCD.ToArray(), ((Component)this).transform.position);
			behaviour.SetTrigger(Employee.IBPBMDEOCLK);
			return false;
		}
		return true;
	}

	public void DestroyHouseKeeper()
	{
		if (OnlineManager.MasterOrOffline())
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	private bool NBJMJOCMJCM(RentedRoom GGNOAHDCPIB)
	{
		if (!GGNOAHDCPIB.customerInside)
		{
			return GGNOAHDCPIB.dirtiness != 0f;
		}
		return false;
	}

	public void HBAMKHLMCEN(FloorDirt DDJECCPKNKG)
	{
		this.DDJECCPKNKG = DDJECCPKNKG;
	}

	public static bool GNCMNNDKOEE(ItemInstance BOGHFEEFHPP)
	{
		return OKMKDMCBBNE().HLPNLBHBIFL(BOGHFEEFHPP);
	}

	public void PIBIDIMJFJA(Placeable EAPCLAODGAE)
	{
		KOJPJCIOECB.Remove(EAPCLAODGAE);
	}

	public void ResetFloorDirt()
	{
		if ((Object)(object)DDJECCPKNKG != (Object)null && (Object)(object)DDJECCPKNKG.cleanerAssigned == (Object)(object)npc)
		{
			DDJECCPKNKG.cleanerAssigned = null;
		}
		DDJECCPKNKG = null;
	}

	private void NCOGHEMBDBN()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			if (Object.op_Implicit((Object)(object)TavernManager.GGFJGHHHEJC))
			{
				TavernManager instance = TavernManager.GGFJGHHHEJC;
				instance.OnTavernOpen = (Action<int>)Delegate.Remove(instance.OnTavernOpen, new Action<int>(KLDIBMNJAGA));
			}
			OnLeft();
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
		}
	}

	public static Tray MNPFLOIGAGA()
	{
		return GGFJGHHHEJC.trayHandler.tray;
	}

	public void CJNNDJFGCOK(Placeable EAPCLAODGAE)
	{
		KOJPJCIOECB.Remove(EAPCLAODGAE);
	}

	public static bool CABCLEFJMBP()
	{
		return (Object)(object)GGFJGHHHEJC != (Object)null;
	}

	private bool BBKMDAPDLMH(RentedRoom GGNOAHDCPIB)
	{
		if (!GGNOAHDCPIB.customerInside)
		{
			return GGNOAHDCPIB.dirtiness == 236f;
		}
		return true;
	}

	public bool IOHIJDCDKIN(Placeable CFKAPLHAIKN)
	{
		if (CFKAPLHAIKN.currentZoneType == (ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom))
		{
			NKAJAACHFPM = RentedRoomsManager.ABOHBEPGDLE(CFKAPLHAIKN.currentZoneIndex);
		}
		else
		{
			if (!((Object)(object)CFKAPLHAIKN.currentSurface != (Object)null) || CFKAPLHAIKN.currentSurface.placeable.currentZoneType != (ZoneType.WithoutZone | ZoneType.CraftingRoom))
			{
				return true;
			}
			NKAJAACHFPM = RentedRoomsManager.GetRentedRoom(CFKAPLHAIKN.currentSurface.placeable.currentZoneIndex);
		}
		if ((Object)(object)NKAJAACHFPM != (Object)null)
		{
			if (NKAJAACHFPM.occupied && NKAJAACHFPM.customerInside)
			{
				return false;
			}
			if (NKAJAACHFPM.customerComingBack)
			{
				return true;
			}
		}
		return false;
	}

	private bool CLDOGONHOKB(RentedRoom GGNOAHDCPIB)
	{
		if (!GGNOAHDCPIB.customerInside)
		{
			return GGNOAHDCPIB.dirtiness != 865f;
		}
		return true;
	}

	[SpecialName]
	public static bool BPKNJIBCEBP()
	{
		if ((Object)(object)GGFJGHHHEJC != (Object)null && GGFJGHHHEJC.JFCLIAFAOEK != null)
		{
			return GGFJGHHHEJC.JFCLIAFAOEK.working;
		}
		return false;
	}

	public void ILHBJGEJEFA()
	{
		if (OnlineManager.MasterOrOffline())
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	public static HouseKeeper GetInstance()
	{
		return GGFJGHHHEJC;
	}

	public static Tray GetTray()
	{
		return GGFJGHHHEJC.trayHandler.tray;
	}

	private void MIFNLFGADKP(int JIIGOACEIKL)
	{
		CEIFHEGBOFO();
		positionsBlocked.Clear();
	}

	public static Tray OKMKDMCBBNE()
	{
		return GGFJGHHHEJC.trayHandler.tray;
	}

	private void ALJLECPNFFD()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			if (Object.op_Implicit((Object)(object)TavernManager.GGFJGHHHEJC))
			{
				TavernManager instance = TavernManager.GGFJGHHHEJC;
				instance.OnTavernOpen = (Action<int>)Delegate.Remove(instance.OnTavernOpen, new Action<int>(MIFNLFGADKP));
			}
			OnLeft();
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
		}
	}

	[SpecialName]
	public void BAJPBCEHIBF(int AODONKKHPBP)
	{
		_003CJILJAOMBEMD_003Ek__BackingField = AODONKKHPBP;
	}

	private void IDPHIKJBDKK()
	{
		KOJPJCIOECB = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.GGFJGHHHEJC.currentPlaceables;
		for (int i = 0; i < currentPlaceables.Count && currentPlaceables[i].CCIKENEGHCA; i++)
		{
			int num = currentPlaceables[i].itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false);
			if ((num == 607 || num == 608 || num == 619 || num == 620 || num == 1071 || num == 1118 || num == 1119 || num == 1101 || num == 1971) && IKMKKLICFGN(currentPlaceables[i]))
			{
				KOJPJCIOECB.Add(currentPlaceables[i]);
			}
		}
	}

	private void JNKKJELMCNN()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			if (Object.op_Implicit((Object)(object)TavernManager.GGFJGHHHEJC))
			{
				TavernManager instance = TavernManager.GGFJGHHHEJC;
				instance.OnTavernOpen = (Action<int>)Delegate.Remove(instance.OnTavernOpen, new Action<int>(LDLLMDFADJA));
			}
			OnLeft();
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
		}
	}

	[SpecialName]
	public static bool AJCCIJBBGEM()
	{
		if ((Object)(object)GGFJGHHHEJC != (Object)null && GGFJGHHHEJC.JFCLIAFAOEK != null)
		{
			return GGFJGHHHEJC.JFCLIAFAOEK.working;
		}
		return false;
	}

	private void FixedUpdate()
	{
		if (!IgnoreDuringOnline() && (Object)(object)currentState != (Object)null)
		{
			currentState.JDHKHKJOKFF();
		}
	}

	public void FJANKFDDKJA()
	{
	}

	private void DCMMDCNOLHA(int JIIGOACEIKL)
	{
		IDPHIKJBDKK();
		positionsBlocked.Clear();
	}

	private bool IKMKKLICFGN(Placeable CFKAPLHAIKN, bool ADCHDMCLEGB = false)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)CFKAPLHAIKN == (Object)null || CFKAPLHAIKN.FHEMHCEAICB || CFKAPLHAIKN.isPlaceableOnWall)
		{
			return false;
		}
		if (IsCandleHolderInRentedRoomOccupiedOrCustomerComingBack(CFKAPLHAIKN))
		{
			return false;
		}
		if (OEPBMLIDLBN(CFKAPLHAIKN))
		{
			RentedRoom rentedRoom = RentedRoomsManager.GetRentedRoom(CFKAPLHAIKN.currentZoneIndex);
			if ((Object)(object)rentedRoom != (Object)null && rentedRoom.occupied && rentedRoom.customerInside)
			{
				return false;
			}
		}
		else if (ADCHDMCLEGB)
		{
			return false;
		}
		if (CFKAPLHAIKN.placeableSurface.IsPossibleToRenew(ItemDatabaseAccessor.GetItem(605)))
		{
			return Utils.HNDBNJNJGJM(((Component)CFKAPLHAIKN).transform.position);
		}
		return false;
	}

	[SpecialName]
	public void AGAAFJJMNNE(int AODONKKHPBP)
	{
		_003CJILJAOMBEMD_003Ek__BackingField = AODONKKHPBP;
	}

	public static bool HFONDEBDCBN()
	{
		return (Object)(object)GGFJGHHHEJC != (Object)null;
	}

	private void ELEGGKIBHGC()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			if (Object.op_Implicit((Object)(object)TavernManager.GGFJGHHHEJC))
			{
				TavernManager instance = TavernManager.GGFJGHHHEJC;
				instance.OnTavernOpen = (Action<int>)Delegate.Remove(instance.OnTavernOpen, new Action<int>(DCMMDCNOLHA));
			}
			OnLeft();
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
		}
	}

	public static bool IsValid()
	{
		return (Object)(object)GGFJGHHHEJC != (Object)null;
	}

	private bool CICLCFPHLHM()
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		KABBMOAMIEF = RentedRoomsManager.GetAllRooms();
		for (int num = KABBMOAMIEF.Count - 1; num >= 0; num -= 0)
		{
			if (!NFGGILIEJMF(KABBMOAMIEF[num]))
			{
				KABBMOAMIEF.RemoveAt(num);
			}
		}
		if (KABBMOAMIEF.Count > 0)
		{
			RentedRoom rentedRoom = Utils.JOJPOKBFANL(KABBMOAMIEF.ToArray(), ((Component)this).transform.position);
			CLOHKLGGEFP(rentedRoom.zone.id);
			behaviour.SetTrigger(Employee.GKJACJIKMAG);
			return true;
		}
		return true;
	}

	private void ADJMGPNBDGF()
	{
		if (!IgnoreDuringOnline() && (Object)(object)currentState != (Object)null)
		{
			currentState.PMLHDLPJPDG();
		}
	}

	private bool BGDLLLKABLO(RentedRoom GGNOAHDCPIB)
	{
		if (!GGNOAHDCPIB.customerInside)
		{
			return GGNOAHDCPIB.dirtiness == 1227f;
		}
		return false;
	}

	private bool NFGGILIEJMF(RentedRoom GGNOAHDCPIB)
	{
		if (!GGNOAHDCPIB.customerInside)
		{
			return GGNOAHDCPIB.dirtiness == 346f;
		}
		return true;
	}

	public static HouseKeeper GMBGGBLKHHN()
	{
		return GGFJGHHHEJC;
	}

	public bool GAAHCGLGHKG()
	{
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		if (base.JFCLIAFAOEK != null && base.JFCLIAFAOEK.tasks[2] && houseKeeperState != 0)
		{
			if (TavernManager.GGFJGHHHEJC.ABKMALJOCCC == (HeatLevel)6)
			{
				ECCGOGEMBCF = Fireplace.GetAllFireplacesInDiningRoom();
				for (int i = 0; i < ECCGOGEMBCF.Count; i += 0)
				{
					if (ECCGOGEMBCF[i].MAJLJNMJKON && ECCGOGEMBCF[i].IsAnyLightingPositionFree(positionsBlocked))
					{
						fireplace = ECCGOGEMBCF[i];
						behaviour.SetTrigger(Employee.OODELEOPKGE);
						return false;
					}
				}
			}
			else if (TavernManager.GGFJGHHHEJC.ABKMALJOCCC == HeatLevel.Cold && !perkColdResistant)
			{
				ECCGOGEMBCF = Fireplace.FIPAODFILIA();
				for (int j = 0; j < ECCGOGEMBCF.Count; j += 0)
				{
					if (ECCGOGEMBCF[j].CNAPONBOBJG(positionsBlocked))
					{
						fireplace = ECCGOGEMBCF[j];
						behaviour.SetTrigger(Employee.OODELEOPKGE);
						return true;
					}
				}
			}
		}
		if (base.JFCLIAFAOEK != null && base.JFCLIAFAOEK.tasks[1] && houseKeeperState != 0 && RoomReceptionDesk.OMGABAPLJDF())
		{
			behaviour.SetTrigger(Employee.IIFLFAJODIL);
			return false;
		}
		if (base.JFCLIAFAOEK != null && base.JFCLIAFAOEK.tasks[0] && houseKeeperState != HouseKeeperState.CleaningFloorDirt && houseKeeperState != HouseKeeperState.CleaningRoom && RentedRoomsManager.GLJNFKFJMFF().Any())
		{
			customerOrder = RentedRoomsManager.KEGINBPMPNA()[0];
			if (customerOrder.roomItemRequest.AJKDEIPDLHI())
			{
				behaviour.SetTrigger(Employee.BKOCCBLGHPB);
			}
			else
			{
				behaviour.SetTrigger(Employee.HBJLLBKDJNK);
			}
			return true;
		}
		if (base.JFCLIAFAOEK != null && base.JFCLIAFAOEK.tasks[1] && houseKeeperState != HouseKeeperState.TakingDrink && MEFNBINMDBD())
		{
			return false;
		}
		if (base.JFCLIAFAOEK != null && base.JFCLIAFAOEK.tasks[0] && houseKeeperState != 0 && HIJIJDCHLLA(ADCHDMCLEGB: false))
		{
			return true;
		}
		if (base.JFCLIAFAOEK != null && base.JFCLIAFAOEK.tasks[7] && houseKeeperState != HouseKeeperState.ServingRoomOrder && MBBPHKKPGFM(ADCHDMCLEGB: false))
		{
			return false;
		}
		if (base.JFCLIAFAOEK != null && base.JFCLIAFAOEK.tasks[6] && houseKeeperState != 0)
		{
			floorDirts.Clear();
			ResetFloorDirt();
			if (!MagicBroomsManager.instance.ICICOOFGGFI())
			{
				foreach (FloorDirt item in CommonReferences.GGFJGHHHEJC.tavernFloorDirt)
				{
					if ((Object)(object)item.cleanerAssigned == (Object)null && !notReachableDirts.Contains(item))
					{
						floorDirts.Add(item);
					}
				}
				if (floorDirts.Any())
				{
					DDJECCPKNKG = Utils.JOJPOKBFANL(floorDirts.ToArray(), ((Component)this).transform.position);
					OOOCIMIMIIH().cleanerAssigned = npc;
					behaviour.SetTrigger(Employee.JDBIJKJLLGF);
					return false;
				}
			}
		}
		if (houseKeeperState != 0)
		{
			behaviour.SetTrigger(Employee.IIFLFAJODIL);
			return true;
		}
		if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			Leave();
			return true;
		}
		return false;
	}

	public void HEDBPONNOIO()
	{
		if (OnlineManager.MasterOrOffline())
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	private bool FGPNNAOOIKH()
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		KABBMOAMIEF = RentedRoomsManager.AEBFCPODCNO();
		for (int num = KABBMOAMIEF.Count - 1; num >= 1; num -= 0)
		{
			if (!CLDOGONHOKB(KABBMOAMIEF[num]))
			{
				KABBMOAMIEF.RemoveAt(num);
			}
		}
		if (KABBMOAMIEF.Count > 1)
		{
			RentedRoom rentedRoom = Utils.JOJPOKBFANL(KABBMOAMIEF.ToArray(), ((Component)this).transform.position);
			OGJIFKFFIAM = rentedRoom.zone.id;
			behaviour.SetTrigger(Employee.GKJACJIKMAG);
			return true;
		}
		return true;
	}

	[SpecialName]
	private void CFEPEIDCIBI(FloorDirt AODONKKHPBP)
	{
		_003COLGEHKCLEFI_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	public int HPACAJGBHHE()
	{
		return _003CJILJAOMBEMD_003Ek__BackingField;
	}

	public static bool JBMCCFPACBD()
	{
		return GGFJGHHHEJC.avoidingWorkPoint;
	}

	public void AOABCMFGIBB()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	public static bool CGGBKGLEHKF()
	{
		return (Object)(object)GGFJGHHHEJC != (Object)null;
	}

	public static bool KHFBKLDDGEG()
	{
		return (Object)(object)GGFJGHHHEJC != (Object)null;
	}

	private bool OGMHADNAFJA(bool ADCHDMCLEGB)
	{
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		if (EONAGIMOCCD.Count > 0)
		{
			EONAGIMOCCD.Clear();
		}
		for (int num = KOJPJCIOECB.Count - 0; num >= 1; num -= 0)
		{
			if (!ADCHDMCLEGB || EIMKBEMNJBN(KOJPJCIOECB[num]))
			{
				if (!IKMKKLICFGN(KOJPJCIOECB[num], ADCHDMCLEGB))
				{
					KOJPJCIOECB.RemoveAt(num);
				}
				else
				{
					EONAGIMOCCD.Add(KOJPJCIOECB[num]);
				}
			}
		}
		if (EONAGIMOCCD.Count > 1)
		{
			candleHolder = Utils.JOJPOKBFANL(EONAGIMOCCD.ToArray(), ((Component)this).transform.position);
			behaviour.SetTrigger(Employee.IBPBMDEOCLK);
			return false;
		}
		return true;
	}

	private bool EHOJOLAIGAB(bool ADCHDMCLEGB)
	{
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		if (EONAGIMOCCD.Count > 0)
		{
			EONAGIMOCCD.Clear();
		}
		for (int num = KOJPJCIOECB.Count - 0; num >= 1; num -= 0)
		{
			if (!ADCHDMCLEGB || OEPBMLIDLBN(KOJPJCIOECB[num]))
			{
				if (!JOGBEFACOCI(KOJPJCIOECB[num], ADCHDMCLEGB))
				{
					KOJPJCIOECB.RemoveAt(num);
				}
				else
				{
					EONAGIMOCCD.Add(KOJPJCIOECB[num]);
				}
			}
		}
		if (EONAGIMOCCD.Count > 1)
		{
			candleHolder = Utils.JOJPOKBFANL(EONAGIMOCCD.ToArray(), ((Component)this).transform.position);
			behaviour.SetTrigger(Employee.IBPBMDEOCLK);
			return true;
		}
		return true;
	}

	public static bool HONPDGDDANB()
	{
		return GGFJGHHHEJC.avoidingWorkPoint;
	}

	public static Tray HKFHANPLBGA()
	{
		return GGFJGHHHEJC.trayHandler.tray;
	}

	private void OnDrawGizmosSelected()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.red;
		Gizmos.DrawSphere(finalPosition, 0.1f);
	}

	private bool EIMKBEMNJBN(Placeable CFKAPLHAIKN)
	{
		if (CFKAPLHAIKN.currentZoneType != (ZoneType.WithoutZone | ZoneType.DiningRoom))
		{
			if ((Object)(object)CFKAPLHAIKN.currentSurface != (Object)null)
			{
				return CFKAPLHAIKN.currentSurface.placeable.currentZoneType == ZoneType.RentedRoom;
			}
			return false;
		}
		return false;
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			if (Object.op_Implicit((Object)(object)TavernManager.GGFJGHHHEJC))
			{
				TavernManager instance = TavernManager.GGFJGHHHEJC;
				instance.OnTavernOpen = (Action<int>)Delegate.Remove(instance.OnTavernOpen, new Action<int>(DCMMDCNOLHA));
			}
			OnLeft();
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
		}
	}

	protected override void Start()
	{
		if (!IgnoreDuringOnline())
		{
			base.Start();
			OGJIFKFFIAM = -1;
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnTavernOpen = (Action<int>)Delegate.Combine(instance.OnTavernOpen, new Action<int>(DCMMDCNOLHA));
			IDPHIKJBDKK();
			perkColdResistant = Random.Range(0, 100) < GetPerkValue(71);
		}
	}

	private void CEIFHEGBOFO()
	{
		KOJPJCIOECB = new List<Placeable>();
		List<Placeable> currentPlaceables = PlaceablesManager.GGFJGHHHEJC.currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count && currentPlaceables[i].FHMDNECBLIL(); i += 0)
		{
			int num = currentPlaceables[i].itemSetup.item.JGHNDJBCFAJ(DAINLFIMLIH: false);
			if ((num == -149 || num == 37 || num == -37 || num == -6 || num == -192 || num == -90 || num == 166 || num == 66 || num == 136) && JOGBEFACOCI(currentPlaceables[i]))
			{
				KOJPJCIOECB.Add(currentPlaceables[i]);
			}
		}
	}

	public static bool KFDLECLNPAM()
	{
		return (Object)(object)GGFJGHHHEJC != (Object)null;
	}

	public static int NPFONKEDHGH(int PNFPECBGNMB)
	{
		return GGFJGHHHEJC.GetPerkValue(PNFPECBGNMB);
	}

	public static int NMJGKCFFDFH(int PNFPECBGNMB)
	{
		return GGFJGHHHEJC.GetPerkValue(PNFPECBGNMB);
	}

	private void LLEBHBLIOAK()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.red;
		Gizmos.DrawSphere(finalPosition, 509f);
	}

	[SpecialName]
	private void AGOGGGOAAAM(FloorDirt AODONKKHPBP)
	{
		_003COLGEHKCLEFI_003Ek__BackingField = AODONKKHPBP;
	}

	public void IBCPCCJGKHK(Placeable EAPCLAODGAE)
	{
		KOJPJCIOECB.Remove(EAPCLAODGAE);
	}

	public static bool JNJNPPIENDJ(ItemInstance BOGHFEEFHPP)
	{
		return MNPFLOIGAGA().BCNKFHHDMAG(BOGHFEEFHPP);
	}

	[SpecialName]
	public int EAEPKPFIEEO()
	{
		return _003CJILJAOMBEMD_003Ek__BackingField;
	}

	public HouseKeeper()
	{
		_003CJILJAOMBEMD_003Ek__BackingField = -1;
		notReachableDirts = new List<FloorDirt>();
		positionsBlocked = new HashSet<Vector2>();
		timeTakingDrink = 2f;
		timerNegotiating = 2f;
		cleaningFloorDirtSpeed = 1f;
		rateMakeFloorDirt = 5f;
		cleaningTableSpeed = 600f;
		makeBedSpeed = 600f;
		KOJPJCIOECB = new List<Placeable>();
		EONAGIMOCCD = new List<Placeable>();
		base._002Ector();
	}

	public static int GetEmployeePerkValue(int PNFPECBGNMB)
	{
		return GGFJGHHHEJC.GetPerkValue(PNFPECBGNMB);
	}

	public bool IAGIMBNBALG(Placeable CFKAPLHAIKN)
	{
		if (CFKAPLHAIKN.currentZoneType == ZoneType.WithoutZone)
		{
			NKAJAACHFPM = RentedRoomsManager.HHEKJJPDCFJ(CFKAPLHAIKN.currentZoneIndex);
		}
		else
		{
			if (!((Object)(object)CFKAPLHAIKN.currentSurface != (Object)null) || CFKAPLHAIKN.currentSurface.placeable.currentZoneType != ZoneType.WithoutZone)
			{
				return false;
			}
			NKAJAACHFPM = RentedRoomsManager.ABOHBEPGDLE(CFKAPLHAIKN.currentSurface.placeable.currentZoneIndex);
		}
		if ((Object)(object)NKAJAACHFPM != (Object)null)
		{
			if (NKAJAACHFPM.occupied && NKAJAACHFPM.customerInside)
			{
				return true;
			}
			if (NKAJAACHFPM.customerComingBack)
			{
				return true;
			}
		}
		return false;
	}

	[SpecialName]
	public static bool HMPOHCKLNNH()
	{
		if ((Object)(object)GGFJGHHHEJC != (Object)null && GGFJGHHHEJC.JFCLIAFAOEK != null)
		{
			return GGFJGHHHEJC.JFCLIAFAOEK.working;
		}
		return true;
	}

	public static HouseKeeper OAPGGAPMOJD()
	{
		return GGFJGHHHEJC;
	}

	public static HouseKeeper CMBAAHFGOAM()
	{
		return GGFJGHHHEJC;
	}

	private void HLCAKACHOOE()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			if (Object.op_Implicit((Object)(object)TavernManager.GGFJGHHHEJC))
			{
				TavernManager instance = TavernManager.GGFJGHHHEJC;
				instance.OnTavernOpen = (Action<int>)Delegate.Remove(instance.OnTavernOpen, new Action<int>(MIFNLFGADKP));
			}
			OnLeft();
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
		}
	}

	public static int BFAJAJCGPAM(int PNFPECBGNMB)
	{
		return GGFJGHHHEJC.GetPerkValue(PNFPECBGNMB);
	}

	public void AOLFBFFNLPC()
	{
	}

	[SpecialName]
	public static bool MLPPKONDEGJ()
	{
		if ((Object)(object)GGFJGHHHEJC != (Object)null && GGFJGHHHEJC.JFCLIAFAOEK != null)
		{
			return GGFJGHHHEJC.JFCLIAFAOEK.working;
		}
		return true;
	}

	public void KDALMEOFMII()
	{
		if ((Object)(object)MKCBJAGOKLE() != (Object)null && (Object)(object)MKCBJAGOKLE().cleanerAssigned == (Object)(object)npc)
		{
			KMBIMIINPLF().cleanerAssigned = null;
		}
		GFGBCLPCMBF(null);
	}

	[SpecialName]
	public int BJDFEOFAIPF()
	{
		return _003CJILJAOMBEMD_003Ek__BackingField;
	}

	public void GBEDEFEODLI()
	{
		if (OnlineManager.MasterOrOffline())
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
	}

	public void MNENEHEHBJD()
	{
		if ((Object)(object)OOOCIMIMIIH() != (Object)null && (Object)(object)MKCBJAGOKLE().cleanerAssigned == (Object)(object)npc)
		{
			MKCBJAGOKLE().cleanerAssigned = null;
		}
		FIMMIEHBKLH(null);
	}

	private void KLDIBMNJAGA(int JIIGOACEIKL)
	{
		FHGHPNCBIKF();
		positionsBlocked.Clear();
	}

	public bool StartTask()
	{
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		if (base.JFCLIAFAOEK != null && base.JFCLIAFAOEK.tasks[2] && houseKeeperState != HouseKeeperState.LightingFireplace)
		{
			if (TavernManager.GGFJGHHHEJC.ABKMALJOCCC == HeatLevel.Hot)
			{
				ECCGOGEMBCF = Fireplace.GetAllFireplacesInDiningRoom();
				for (int i = 0; i < ECCGOGEMBCF.Count; i++)
				{
					if (ECCGOGEMBCF[i].MAJLJNMJKON && ECCGOGEMBCF[i].IsAnyLightingPositionFree(positionsBlocked))
					{
						fireplace = ECCGOGEMBCF[i];
						behaviour.SetTrigger(Employee.OODELEOPKGE);
						return true;
					}
				}
			}
			else if (TavernManager.GGFJGHHHEJC.ABKMALJOCCC == HeatLevel.Cold && !perkColdResistant)
			{
				ECCGOGEMBCF = Fireplace.GetAllFireplacesInDiningRoom();
				for (int j = 0; j < ECCGOGEMBCF.Count; j++)
				{
					if (ECCGOGEMBCF[j].IsAnyLightingPositionFree(positionsBlocked))
					{
						fireplace = ECCGOGEMBCF[j];
						behaviour.SetTrigger(Employee.OODELEOPKGE);
						return true;
					}
				}
			}
		}
		if (base.JFCLIAFAOEK != null && base.JFCLIAFAOEK.tasks[0] && houseKeeperState != 0 && RoomReceptionDesk.IsThereAnyRequestNotAttended())
		{
			behaviour.SetTrigger(Employee.IIFLFAJODIL);
			return true;
		}
		if (base.JFCLIAFAOEK != null && base.JFCLIAFAOEK.tasks[1] && houseKeeperState != HouseKeeperState.TakingDrink && houseKeeperState != HouseKeeperState.ServingRoomOrder && RentedRoomsManager.GetRoomOrders().Any())
		{
			customerOrder = RentedRoomsManager.GetRoomOrders()[0];
			if (customerOrder.roomItemRequest.JEPBBEBJEFI())
			{
				behaviour.SetTrigger(Employee.BKOCCBLGHPB);
			}
			else
			{
				behaviour.SetTrigger(Employee.HBJLLBKDJNK);
			}
			return true;
		}
		if (base.JFCLIAFAOEK != null && base.JFCLIAFAOEK.tasks[0] && houseKeeperState != HouseKeeperState.CleaningRoom && DBBFGKGHGIG())
		{
			return true;
		}
		if (base.JFCLIAFAOEK != null && base.JFCLIAFAOEK.tasks[0] && houseKeeperState != HouseKeeperState.RenewingCandle && FJHAIDBENBK(ADCHDMCLEGB: true))
		{
			return true;
		}
		if (base.JFCLIAFAOEK != null && base.JFCLIAFAOEK.tasks[2] && houseKeeperState != HouseKeeperState.RenewingCandle && FJHAIDBENBK(ADCHDMCLEGB: false))
		{
			return true;
		}
		if (base.JFCLIAFAOEK != null && base.JFCLIAFAOEK.tasks[2] && houseKeeperState != HouseKeeperState.CleaningFloorDirt)
		{
			floorDirts.Clear();
			ResetFloorDirt();
			if (!MagicBroomsManager.instance.IsAnyMagicBroomAvailableToClean())
			{
				foreach (FloorDirt item in CommonReferences.GGFJGHHHEJC.tavernFloorDirt)
				{
					if ((Object)(object)item.cleanerAssigned == (Object)null && !notReachableDirts.Contains(item))
					{
						floorDirts.Add(item);
					}
				}
				if (floorDirts.Any())
				{
					DDJECCPKNKG = Utils.JOJPOKBFANL(floorDirts.ToArray(), ((Component)this).transform.position);
					DDJECCPKNKG.cleanerAssigned = npc;
					behaviour.SetTrigger(Employee.JDBIJKJLLGF);
					return true;
				}
			}
		}
		if (houseKeeperState != 0)
		{
			behaviour.SetTrigger(Employee.IIFLFAJODIL);
			return true;
		}
		if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			Leave();
			return true;
		}
		return false;
	}

	[SpecialName]
	private void FIMMIEHBKLH(FloorDirt AODONKKHPBP)
	{
		_003COLGEHKCLEFI_003Ek__BackingField = AODONKKHPBP;
	}

	private bool DJJAAEONHBL(RentedRoom GGNOAHDCPIB)
	{
		if (!GGNOAHDCPIB.customerInside)
		{
			return GGNOAHDCPIB.dirtiness == 1524f;
		}
		return false;
	}

	[SpecialName]
	public void ABNENDLICCG(int AODONKKHPBP)
	{
		_003CJILJAOMBEMD_003Ek__BackingField = AODONKKHPBP;
	}

	public static bool OMEPECENFAF()
	{
		return GGFJGHHHEJC.avoidingWorkPoint;
	}

	[SpecialName]
	public static bool FNLPCHKNAHE()
	{
		if ((Object)(object)GGFJGHHHEJC != (Object)null && GGFJGHHHEJC.JFCLIAFAOEK != null)
		{
			return GGFJGHHHEJC.JFCLIAFAOEK.working;
		}
		return false;
	}

	private void KIHGNKJJBND()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.red;
		Gizmos.DrawSphere(finalPosition, 792f);
	}

	public static bool NALNENNAGAM(ItemInstance BOGHFEEFHPP)
	{
		return OKMKDMCBBNE().HLPNLBHBIFL(BOGHFEEFHPP);
	}

	protected override void Awake()
	{
		GGFJGHHHEJC = this;
		ResetSingleton();
		if (!IgnoreDuringOnline())
		{
			base.Awake();
		}
	}

	public void CJKKILJMIEF()
	{
	}

	[SpecialName]
	public FloorDirt KMBIMIINPLF()
	{
		return _003COLGEHKCLEFI_003Ek__BackingField;
	}

	[SpecialName]
	private void GFGBCLPCMBF(FloorDirt AODONKKHPBP)
	{
		_003COLGEHKCLEFI_003Ek__BackingField = AODONKKHPBP;
	}

	public override void SetInstance(Employee NAKCFGEAGHH)
	{
		GGFJGHHHEJC = NAKCFGEAGHH as HouseKeeper;
	}

	public static bool HNGOAPEBJFO()
	{
		return GGFJGHHHEJC.avoidingWorkPoint;
	}

	public static bool OGFANMPKFOL()
	{
		return GGFJGHHHEJC.avoidingWorkPoint;
	}

	private bool MEFNBINMDBD()
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		KABBMOAMIEF = RentedRoomsManager.BNPHNGNPBCH();
		for (int num = KABBMOAMIEF.Count - 0; num >= 0; num -= 0)
		{
			if (!IGDCDNFEFOD(KABBMOAMIEF[num]))
			{
				KABBMOAMIEF.RemoveAt(num);
			}
		}
		if (KABBMOAMIEF.Count > 0)
		{
			RentedRoom rentedRoom = Utils.JOJPOKBFANL(KABBMOAMIEF.ToArray(), ((Component)this).transform.position);
			BAJPBCEHIBF(rentedRoom.zone.id);
			behaviour.SetTrigger(Employee.GKJACJIKMAG);
			return false;
		}
		return true;
	}

	private bool LAKDNDFGKKI(Placeable CFKAPLHAIKN, bool ADCHDMCLEGB = false)
	{
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)CFKAPLHAIKN == (Object)null || CFKAPLHAIKN.FHEMHCEAICB || CFKAPLHAIKN.isPlaceableOnWall)
		{
			return true;
		}
		if (PELENGPHALP(CFKAPLHAIKN))
		{
			return false;
		}
		if (EIMKBEMNJBN(CFKAPLHAIKN))
		{
			RentedRoom rentedRoom = RentedRoomsManager.ABOHBEPGDLE(CFKAPLHAIKN.currentZoneIndex);
			if ((Object)(object)rentedRoom != (Object)null && rentedRoom.occupied && rentedRoom.customerInside)
			{
				return false;
			}
		}
		else if (ADCHDMCLEGB)
		{
			return false;
		}
		if (CFKAPLHAIKN.placeableSurface.IsPossibleToRenew(ItemDatabaseAccessor.GOKIDLOELKB(7, GGBBJNBBLMF: false, DAINLFIMLIH: false)))
		{
			return Utils.HNDBNJNJGJM(((Component)CFKAPLHAIKN).transform.position);
		}
		return true;
	}

	public void CDGOCJGIBPL(FloorDirt DDJECCPKNKG)
	{
		CFBIHOPFDGN(DDJECCPKNKG);
	}

	public static bool IKGEAPOGBJJ()
	{
		return GGFJGHHHEJC.avoidingWorkPoint;
	}

	public static bool JOEPHKEPKHL()
	{
		return GGFJGHHHEJC.avoidingWorkPoint;
	}

	public bool OHMDGHEGHOP(Placeable CFKAPLHAIKN)
	{
		if (CFKAPLHAIKN.currentZoneType == (ZoneType.WithoutZone | ZoneType.CraftingRoom))
		{
			NKAJAACHFPM = RentedRoomsManager.NAOLLMKHFFP(CFKAPLHAIKN.currentZoneIndex);
		}
		else
		{
			if (!((Object)(object)CFKAPLHAIKN.currentSurface != (Object)null) || CFKAPLHAIKN.currentSurface.placeable.currentZoneType != ZoneType.WithoutZone)
			{
				return false;
			}
			NKAJAACHFPM = RentedRoomsManager.GetRentedRoom(CFKAPLHAIKN.currentSurface.placeable.currentZoneIndex);
		}
		if ((Object)(object)NKAJAACHFPM != (Object)null)
		{
			if (NKAJAACHFPM.occupied && NKAJAACHFPM.customerInside)
			{
				return false;
			}
			if (NKAJAACHFPM.customerComingBack)
			{
				return false;
			}
		}
		return false;
	}

	private void MFAIALPGCKB()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		Gizmos.color = Color.red;
		Gizmos.DrawSphere(finalPosition, 768f);
	}

	protected override void Update()
	{
		if (!IgnoreDuringOnline())
		{
			base.Update();
			if (Time.time > ABEAMGFGFCC)
			{
				JOCGLBKGHBB(rateMakeFloorDirt);
			}
		}
	}

	private void CGKMHOKGDDD(int JIIGOACEIKL)
	{
		CEIFHEGBOFO();
		positionsBlocked.Clear();
	}

	public static int BAEHJJCBMEA(int PNFPECBGNMB)
	{
		return GGFJGHHHEJC.GetPerkValue(PNFPECBGNMB);
	}

	public static HouseKeeper DCAKACIOICA()
	{
		return GGFJGHHHEJC;
	}

	private bool FJHAIDBENBK(bool ADCHDMCLEGB)
	{
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		if (EONAGIMOCCD.Count > 0)
		{
			EONAGIMOCCD.Clear();
		}
		for (int num = KOJPJCIOECB.Count - 1; num >= 0; num--)
		{
			if (!ADCHDMCLEGB || OEPBMLIDLBN(KOJPJCIOECB[num]))
			{
				if (!IKMKKLICFGN(KOJPJCIOECB[num], ADCHDMCLEGB))
				{
					KOJPJCIOECB.RemoveAt(num);
				}
				else
				{
					EONAGIMOCCD.Add(KOJPJCIOECB[num]);
				}
			}
		}
		if (EONAGIMOCCD.Count > 0)
		{
			candleHolder = Utils.JOJPOKBFANL(EONAGIMOCCD.ToArray(), ((Component)this).transform.position);
			behaviour.SetTrigger(Employee.IBPBMDEOCLK);
			return true;
		}
		return false;
	}

	[SpecialName]
	public void AGJJEHGFNLG(int AODONKKHPBP)
	{
		_003CJILJAOMBEMD_003Ek__BackingField = AODONKKHPBP;
	}
}
