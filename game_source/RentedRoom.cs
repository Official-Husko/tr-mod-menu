using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RentedRoom : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class IOPAGMHMNJE : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int playerNum;

		public RentedRoom _003C_003E4__this;

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
		public IOPAGMHMNJE(int _003C_003E1__state)
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
			RentedRoom mOBFJEDPIPM = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait075;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				PlayerController.RemoveMovementBlocker(playerNum, (Object)(object)mOBFJEDPIPM);
				return false;
			}
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

	[CompilerGenerated]
	private sealed class CEPJFGIJHHI : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RentedRoom _003C_003E4__this;

		private int _003CcomeBackHour_003E5__2;

		private int _003CcomeBackMinutes_003E5__3;

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
		public CEPJFGIJHHI(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Expected O, but got Unknown
			int num = _003C_003E1__state;
			RentedRoom rentedRoom = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003CcomeBackHour_003E5__2 = RentedRoomsManager.HourComeBackRange();
				_003CcomeBackMinutes_003E5__3 = Random.Range(0, 55);
				goto IL_0042;
			case 1:
				_003C_003E1__state = -1;
				if (rentedRoom.dirtiness == 0f)
				{
					_003C_003E2__current = (object)new WaitForSeconds((float)Random.Range(30, 70));
					_003C_003E1__state = 2;
					return true;
				}
				if (WorldTime.NOAOJJLNHJJ.hour >= _003CcomeBackHour_003E5__2 && WorldTime.NOAOJJLNHJJ.min >= _003CcomeBackMinutes_003E5__3)
				{
					rentedRoom.EKGMKMLNMKA();
					break;
				}
				goto IL_0042;
			case 2:
				{
					_003C_003E1__state = -1;
					rentedRoom.EKGMKMLNMKA();
					break;
				}
				IL_0042:
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 1;
				return true;
			}
			rentedRoom.KOMFNKJBEED = null;
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

	[CompilerGenerated]
	private sealed class MAGAKBHLGII : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RentedRoom _003C_003E4__this;

		public bool instantLeave;

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
		public MAGAKBHLGII(int _003C_003E1__state)
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
			RentedRoom rentedRoom = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				goto IL_0046;
			case 1:
				_003C_003E1__state = -1;
				goto IL_0046;
			case 2:
				_003C_003E1__state = -1;
				goto IL_0072;
			case 3:
				{
					_003C_003E1__state = -1;
					rentedRoom.door.knock = false;
					rentedRoom.readyToLeave = false;
					rentedRoom.SetVisibility(MDIKPGGBNLI: true, MAPFDGCKBLD: true);
					if (!instantLeave)
					{
						if (OnlineManager.MasterOrOffline())
						{
							rentedRoom.AKFDKMMOCNJ();
						}
						if (rentedRoom.remainingDays > 0)
						{
							rentedRoom.occupied = true;
							rentedRoom.needsToBeClean = true;
							if (OnlineManager.MasterOrOffline())
							{
								rentedRoom.KOMFNKJBEED = ((MonoBehaviour)rentedRoom).StartCoroutine(rentedRoom.LCDIDBBAAFF());
							}
						}
						else
						{
							rentedRoom.occupied = false;
							rentedRoom.needsToBeClean = false;
							rentedRoom.KKGAHDNMLDD(null, rentedRoom.zone.placeables);
							if (OnlineManager.MasterOrOffline())
							{
								rentedRoom.PJNGMCJIHME.customerSpeech.ImmediatelyBark("HappyRentRoom");
							}
						}
					}
					else
					{
						if (rentedRoom.remainingDays <= 0)
						{
							rentedRoom.occupied = false;
						}
						rentedRoom.needsToBeClean = false;
						rentedRoom.KKGAHDNMLDD(null, rentedRoom.zone.placeables);
					}
					rentedRoom.customerInside = false;
					rentedRoom.customerComingBack = false;
					if (rentedRoom.dirtiness == 0f)
					{
						rentedRoom.HIANOOFNFOA();
					}
					break;
				}
				IL_0072:
				if (OnlineTavernConstructionManager.instance.tavernConstructionOpenedByOtherPlayer)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 2;
					return true;
				}
				goto IL_007e;
				IL_007e:
				if (rentedRoom.door.HGPPJMCLOKH && rentedRoom.readyToLeave)
				{
					WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(rentedRoom.NJOLEJEIPOJ));
					rentedRoom.door.HGPPJMCLOKH = false;
					rentedRoom.door.knock = false;
					rentedRoom.door.OpenCloseAction(DBCDEKIEHMG: true);
					RentedRoomDoor door = rentedRoom.door;
					door.OnKnock = (Action)Delegate.Remove(door.OnKnock, new Action(rentedRoom.HDDBOMDBEDF));
					_003C_003E2__current = CommonReferences.wait05;
					_003C_003E1__state = 3;
					return true;
				}
				break;
				IL_0046:
				if (TavernConstructionManager.GGFJGHHHEJC.LNLJMCONDNE)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
				if (OnlineManager.PlayingOnline())
				{
					goto IL_0072;
				}
				goto IL_007e;
			}
			rentedRoom.CBNPEEEEMHC = null;
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

	public Action OnContentsChanged = delegate
	{
	};

	public List<FloorDirt> allFloorDirt = new List<FloorDirt>();

	private bool LIFGOFBGECO;

	public bool isValid = true;

	public float dirtiness;

	public bool hasBed;

	public bool hasLight;

	public bool hasTable;

	public bool hasChair;

	public string roomName = "Room Name";

	public bool occupied;

	public bool customerInside;

	public bool customerComingBack;

	public int symbolID = -1;

	public int remainingDays;

	public TavernZone zone;

	public bool needsToBeClean;

	public CustomerOrder customerOrder;

	public HumanInfo humanInfo;

	public float repPositiveMultiplier = 1f;

	public List<Table> tables = new List<Table>();

	public List<NPCBed> beds = new List<NPCBed>();

	public RentedRoomDoor door;

	[SerializeField]
	private Placeable placeable;

	[HideInInspector]
	public bool readyToLeave;

	public int leaveHour;

	private int CKIIFGALADN;

	private Customer PJNGMCJIHME;

	private Coroutine KOMFNKJBEED;

	private Coroutine CBNPEEEEMHC;

	private Coroutine HJPANLBMCJP;

	public bool BAKBJEOMLHN
	{
		get
		{
			return LIFGOFBGECO;
		}
		set
		{
			LIFGOFBGECO = value;
			door.SetAnimationSprites(BAKBJEOMLHN);
		}
	}

	public int JFNMCNCHMEO => zone.id;

	private void HIANOOFNFOA()
	{
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		foreach (Placeable item in DJPNHKENKHM())
		{
			if (!((Object)(object)item == (Object)null))
			{
				Table component = ((Component)item).GetComponent<Table>();
				if ((Object)(object)component != (Object)null)
				{
					component.AddDirtiness(2000f, KGCEBPFKPOG: true, CDPAMNIPPEC: false);
				}
				NPCBed component2 = ((Component)item).GetComponent<NPCBed>();
				if ((Object)(object)component2 != (Object)null)
				{
					component2.SetBedMade(NBBELPFDLJG: false, CDPAMNIPPEC: false);
				}
			}
		}
		if (OnlineManager.MasterOrOffline())
		{
			IEnumerable<Vector2> source = zone.positions.Where((Vector2 p) => WorldGrid.NGDHDMAMGPI(Vector2.op_Implicit(p)) && WorldGrid.NGDHDMAMGPI(Vector2.op_Implicit(p + Vector2.down * 0.5f)));
			int num = Random.Range(1, GetNumFloorTiles() / 3);
			if (source.Count() < num)
			{
				source = zone.positions.Where((Vector2 p) => WorldGrid.NGDHDMAMGPI(Vector2.op_Implicit(p)));
			}
			if (source.Count() < num)
			{
				source = zone.positions;
			}
			if (source.Count() > 0)
			{
				for (int i = 0; i < num; i++)
				{
					Vector3 val = Vector2.op_Implicit(source.ElementAt(Random.Range(0, source.Count())));
					Object.Instantiate<GameObject>(CommonReferences.GGFJGHHHEJC.dirtPrefab, Utils.BMBMPKNANAC(val + new Vector3(0.25f, 0.25f, 0f)), Quaternion.identity).GetComponent<FloorDirt>();
				}
			}
			UpdateContentsNextFrame(CDPAMNIPPEC: false);
		}
		else
		{
			GONMHLNBHLH();
		}
	}

	public GameDate ODGCIBDDABE()
	{
		return GameDate.DLECFAIEMNA(WorldTime.NOAOJJLNHJJ, new GameDate(1, Season.Spring, 0, (Day)remainingDays, 1, 0));
	}

	public void RemoveRoomZone()
	{
		if ((Object)(object)TavernZonesManager.GGFJGHHHEJC == (Object)null)
		{
			return;
		}
		CheckVisibility();
		if (zone.id != -1)
		{
			Debug.Log((object)"Removing Rented Room Zone!");
			if (TavernZonesManager.GGFJGHHHEJC.ExistsTavernZone(zone.id))
			{
				TavernZonesManager.GGFJGHHHEJC.RemoveTavernZone(zone.id);
			}
			zone.id = -1;
		}
	}

	private void PELEMHHGMBO()
	{
		if (door.HGPPJMCLOKH)
		{
			ELEDNGNNCIF(1);
			if (GameManager.LocalCoop())
			{
				ELEDNGNNCIF(2);
			}
		}
	}

	private void IFCAKALCICP()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		PJNGMCJIHME = CustomerPool.MMKHMMELDDP().customer;
		((Component)PJNGMCJIHME).transform.position = KKHABFMEHFE();
		if (humanInfo != null)
		{
			PJNGMCJIHME.npc.characterCreator.HEALOFLBFLL(humanInfo);
		}
		else
		{
			Debug.Log((object)"");
		}
		PJNGMCJIHME.customerType = (CustomerType)4;
		PJNGMCJIHME.hasBeenServed = false;
		PJNGMCJIHME.ChangeState(CustomerState.Leaving, KCNFNAICINO: false);
	}

	public bool IDJBCGNMHCJ()
	{
		if (!occupied && dirtiness == 77f)
		{
			return isValid;
		}
		return false;
	}

	private IEnumerator KBJOKIGFPFJ()
	{
		yield return CommonReferences.wait1;
		UpdateContents();
	}

	public bool GFPBMPMPLOB()
	{
		if (door.KPFPEDKCOGA() && occupied)
		{
			return customerInside;
		}
		return true;
	}

	private bool PLCHGPBMBHO(Placeable EAPCLAODGAE)
	{
		if ((Object)(object)EAPCLAODGAE == (Object)null)
		{
			return true;
		}
		if (Object.op_Implicit((Object)(object)((Component)EAPCLAODGAE).GetComponent<LightSource>()))
		{
			return false;
		}
		if ((Object)(object)EAPCLAODGAE.placeableSurface != (Object)null)
		{
			for (int i = 0; i < EAPCLAODGAE.placeableSurface.placeablesOnSurface.Count; i++)
			{
				if (!EAPCLAODGAE.placeableSurface.placeablesOnSurface[i].FHEMHCEAICB && PLCHGPBMBHO(EAPCLAODGAE.placeableSurface.placeablesOnSurface[i]))
				{
					return false;
				}
			}
		}
		return false;
	}

	public void GCKMAHDJMPM(Placeable EAPCLAODGAE)
	{
		NPCBed component = ((Component)EAPCLAODGAE).GetComponent<NPCBed>();
		if ((Object)(object)component != (Object)null)
		{
			beds.Remove(component);
			component.OnBedMade = (Action)Delegate.Remove(component.OnBedMade, new Action(IPHEFEMLOLJ));
			component.OnBedUnmade = (Action)Delegate.Remove(component.OnBedUnmade, new Action(GLGAOFGNKCN));
		}
		Table component2 = ((Component)EAPCLAODGAE).GetComponent<Table>();
		if ((Object)(object)component2 != (Object)null)
		{
			tables.Remove(component2);
			component2.OnBecomeClean = (Action)Delegate.Remove(component2.OnBecomeClean, new Action(GLGAOFGNKCN));
		}
		GLGAOFGNKCN();
	}

	private IEnumerator FPFMAJNAEGP(int JIIGOACEIKL)
	{
		return new IOPAGMHMNJE(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public void DKGEOKBHAGO(bool CDPAMNIPPEC = true)
	{
		BGHGJBCKGMN(ANDBJBCIAJG: false, CDPAMNIPPEC);
	}

	public bool CNGADJIHJOJ()
	{
		if (door.KPFPEDKCOGA() && occupied)
		{
			return customerInside;
		}
		return false;
	}

	private void FLFIBNKOJMC()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && !GameManager.leavingTheGame)
		{
			if ((Object)(object)GameManager.NJNFHEPLEHL() != (Object)null)
			{
				GameManager gameManager = GameManager.NJNFHEPLEHL();
				gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(UpdateContentsNextFrame));
			}
			if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
			{
				OnlineLoadManager instance = OnlineLoadManager.instance;
				instance.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance.OnFinishedOnlineLoad, new Action(UpdateContentsNextFrame));
			}
			if (zone.id != -1)
			{
				zone.IFLMEBGHLNE(MDIKPGGBNLI: false);
			}
		}
	}

	private void HMPHACKFPJA(int JIIGOACEIKL)
	{
		if (customerOrder.requesting)
		{
			customerOrder.KPHNAJEGMDL();
		}
	}

	public int PMDPEDGIABG()
	{
		return zone.positions.Count / 2;
	}

	private void GADEGOPBNGC()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.leavingTheGame)
		{
			if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(ALGOBMNPLIB));
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(IFHFNDELKOP));
				CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
				commonReferences2.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(commonReferences2.OnPlaceablePlaced, new Action<int, Placeable>(JMEOLLBLIKH));
				CommonReferences commonReferences3 = CommonReferences.MNFMOEKMJKN();
				commonReferences3.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Remove(commonReferences3.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(PBNDOKJMNGH));
				CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
				instance2.OnAnyTableDirtLevelChanged = (Action<TableDirtLevel>)Delegate.Remove(instance2.OnAnyTableDirtLevelChanged, new Action<TableDirtLevel>(LHECJHHNOGM));
			}
			RentedRoomsManager.CMFEKFACCPC(symbolID);
			if (Object.op_Implicit((Object)(object)TavernManager.GGFJGHHHEJC))
			{
				TavernManager instance3 = TavernManager.GGFJGHHHEJC;
				instance3.OnTavernClose = (Action<int>)Delegate.Remove(instance3.OnTavernClose, new Action<int>(KPEAKIHONDI));
			}
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(KEAIDPGIPDP));
		}
	}

	private void HJDLNCOAKIK()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(ALGOBMNPLIB));
		CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
		commonReferences2.OnPlayerSleep = (Action)Delegate.Combine(commonReferences2.OnPlayerSleep, new Action(JMNBECMKICD));
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Combine(instance.OnPlaceablePlaced, new Action<int, Placeable>(JJPLHHIMNMI));
		CommonReferences commonReferences3 = CommonReferences.MNFMOEKMJKN();
		commonReferences3.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Combine(commonReferences3.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(PBNDOKJMNGH));
		CommonReferences commonReferences4 = CommonReferences.MNFMOEKMJKN();
		commonReferences4.OnAnyTableDirtLevelChanged = (Action<TableDirtLevel>)Delegate.Combine(commonReferences4.OnAnyTableDirtLevelChanged, new Action<TableDirtLevel>(FGFLCOLJFEI));
		if (symbolID == -1)
		{
			symbolID = RentedRoomsManager.NKMLALMKMHC();
		}
		TavernManager instance2 = TavernManager.GGFJGHHHEJC;
		instance2.OnTavernClose = (Action<int>)Delegate.Combine(instance2.OnTavernClose, new Action<int>(FFCMICFDHNP));
	}

	public void AGIOCPDIOPF()
	{
		SetCustomerInRoom(CDPAMNIPPEC: true);
		readyToLeave = false;
		remainingDays -= 0;
		if (remainingDays <= 1)
		{
			door.knock = false;
			RentedRoomDoor rentedRoomDoor = door;
			rentedRoomDoor.OnKnock = (Action)Delegate.Combine(rentedRoomDoor.OnKnock, new Action(AKMIBFCIGBA));
			leaveHour = RentedRoomsManager.DHKBALCKAKN();
		}
		else
		{
			door.knock = true;
			leaveHour = RentedRoomsManager.NEOAIGPNCAA();
		}
		CKIIFGALADN = Random.Range(1, 7);
		if (OnlineManager.MasterOrOffline())
		{
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Combine(WorldTime.OnTickTime5Seconds, new Action(NJOLEJEIPOJ));
		}
	}

	private void EOGADPHEGGF()
	{
		Customer customer = NPCRoadManager.HFLIOBAFGBP();
		if (humanInfo != null)
		{
			customer.npc.characterCreator.SetHumanInfo(humanInfo);
		}
		else
		{
			Debug.Log((object)": ");
		}
		customerComingBack = false;
		customer.hasBeenServed = false;
		customer.rentedRoom = this;
		customer.ChangeState((CustomerState)(-109), KCNFNAICINO: false);
	}

	public void UpdateContentsNextFrame()
	{
		try
		{
			UpdateContentsNextFrame(CDPAMNIPPEC: false);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void OnDisable()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && !GameManager.leavingTheGame)
		{
			if ((Object)(object)GameManager.GGFJGHHHEJC != (Object)null)
			{
				GameManager instance = GameManager.GGFJGHHHEJC;
				instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(UpdateContentsNextFrame));
			}
			if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
			{
				OnlineLoadManager instance2 = OnlineLoadManager.instance;
				instance2.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance2.OnFinishedOnlineLoad, new Action(UpdateContentsNextFrame));
			}
			if (zone.id != -1)
			{
				zone.PNANPLFPBNP(MDIKPGGBNLI: true);
			}
		}
	}

	private IEnumerator LCDIDBBAAFF()
	{
		int comeBackHour = RentedRoomsManager.HourComeBackRange();
		int comeBackMinutes = Random.Range(0, 55);
		while (true)
		{
			yield return CommonReferences.wait1;
			if (dirtiness == 0f)
			{
				yield return (object)new WaitForSeconds((float)Random.Range(30, 70));
				EKGMKMLNMKA();
				break;
			}
			if (WorldTime.NOAOJJLNHJJ.hour >= comeBackHour && WorldTime.NOAOJJLNHJJ.min >= comeBackMinutes)
			{
				EKGMKMLNMKA();
				break;
			}
		}
		KOMFNKJBEED = null;
	}

	public void ACMFFBBDNEG()
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		if (IsValid(out var GDFIONOLFIB, KIKDLKGBCOC: false))
		{
			zone = TavernZonesManager.NHKAFANMEJC().LPMJIJKNMPB(ZoneType.RentedRoom, this);
			TavernZone tavernZone = zone;
			tavernZone.OnPlaceableAdded = (Action<Placeable>)Delegate.Combine(tavernZone.OnPlaceableAdded, new Action<Placeable>(AddPlaceable));
			TavernZone tavernZone2 = zone;
			tavernZone2.OnPlaceableRemoved = (Action<Placeable>)Delegate.Combine(tavernZone2.OnPlaceableRemoved, new Action<Placeable>(IPAMEGNNPAN));
			for (int i = 0; i < GDFIONOLFIB.Count; i++)
			{
				TavernZonesManager.HFHPMKJGMPA().MBDKPCIEDDN(Vector2.op_Implicit(GDFIONOLFIB[i]), zone.id);
			}
			UpdateContentsNextFrame();
			NCMJLNHHNIG(MAPFDGCKBLD: true);
		}
		else
		{
			zone.id = -1;
		}
	}

	public Vector3 KKHABFMEHFE()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (BAKBJEOMLHN)
		{
			return ((Component)this).transform.position - Vector3.up * 1901f;
		}
		return ((Component)this).transform.position + Vector3.up * 1319f;
	}

	public void DOGMDAIGEKC(bool CDPAMNIPPEC = false)
	{
		if (HJPANLBMCJP == null && (Object)(object)GameplayUI.DICHPHEOINO() != (Object)null)
		{
			HJPANLBMCJP = ((MonoBehaviour)GameplayUI.ELGNEJNLBNO()).StartCoroutine(BMMIPJLMEPN());
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.GAGNJEMNFIA(placeable.onlinePlaceable.uniqueId);
		}
	}

	private void ELEDNGNNCIF(int JIIGOACEIKL)
	{
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		PlayerController.GetPlayer(JIIGOACEIKL).UpdateZone();
		if (PlayerController.GetPlayer(JIIGOACEIKL).NNMHEPDJOHK == ZoneType.RentedRoom && PlayerController.GetPlayer(JIIGOACEIKL).zoneIndex == zone.id)
		{
			if (BAKBJEOMLHN)
			{
				((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position = placeable.itemSpace.buildSquares[1].GetCentrePosition() + Vector3.up;
			}
			else
			{
				((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position = placeable.itemSpace.buildSquares[0].GetCentrePosition();
			}
			PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)this);
			((MonoBehaviour)this).StartCoroutine(LNFPCGEBPKH(JIIGOACEIKL));
			PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.SetCleaning(NJHMBMGKCPL: false, null);
			InteractObject.GetPlayer(JIIGOACEIKL).SetCurrentInteract(null, null);
		}
	}

	public void IPHEFEMLOLJ()
	{
		try
		{
			DOGMDAIGEKC(CDPAMNIPPEC: true);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	public void RemovePlaceable(Placeable EAPCLAODGAE)
	{
		NPCBed component = ((Component)EAPCLAODGAE).GetComponent<NPCBed>();
		if ((Object)(object)component != (Object)null)
		{
			beds.Remove(component);
			component.OnBedMade = (Action)Delegate.Remove(component.OnBedMade, new Action(UpdateContentsNextFrame));
			component.OnBedUnmade = (Action)Delegate.Remove(component.OnBedUnmade, new Action(UpdateContentsNextFrame));
		}
		Table component2 = ((Component)EAPCLAODGAE).GetComponent<Table>();
		if ((Object)(object)component2 != (Object)null)
		{
			tables.Remove(component2);
			component2.OnBecomeClean = (Action)Delegate.Remove(component2.OnBecomeClean, new Action(UpdateContentsNextFrame));
		}
		UpdateContentsNextFrame();
	}

	public void SetCustomerInRoom(bool CDPAMNIPPEC = false)
	{
		occupied = true;
		customerInside = true;
		customerComingBack = false;
		door.HGPPJMCLOKH = true;
		door.OpenCloseAction(DBCDEKIEHMG: false, CDPAMNIPPEC: false);
		repPositiveMultiplier = 1f;
		PELEMHHGMBO();
		((MonoBehaviour)this).Invoke("PELEMHHGMBO", 1f);
		if (OnlineManager.MasterOrOffline())
		{
			CleanRoom(DNJLKIIJLFN: false);
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendSetOccupierInRoom(placeable.onlinePlaceable.uniqueId);
		}
	}

	public GameDate GCDALKPMODC()
	{
		return GameDate.OPINCAFMBEI(WorldTime.NOAOJJLNHJJ, new GameDate(1, Season.Summer, 1, (Day)remainingDays, 0, 1));
	}

	public Vector3 GetEnterLocation()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (BAKBJEOMLHN)
		{
			return ((Component)this).transform.position - Vector3.up * 0.5f;
		}
		return ((Component)this).transform.position + Vector3.up * 0.5f;
	}

	private IEnumerator AAJCFMIEOCH(bool ANDBJBCIAJG)
	{
		while (TavernConstructionManager.GGFJGHHHEJC.LNLJMCONDNE)
		{
			yield return null;
		}
		if (OnlineManager.PlayingOnline())
		{
			while (OnlineTavernConstructionManager.instance.tavernConstructionOpenedByOtherPlayer)
			{
				yield return null;
			}
		}
		if (door.HGPPJMCLOKH && readyToLeave)
		{
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(NJOLEJEIPOJ));
			door.HGPPJMCLOKH = false;
			door.knock = false;
			door.OpenCloseAction(DBCDEKIEHMG: true);
			RentedRoomDoor rentedRoomDoor = door;
			rentedRoomDoor.OnKnock = (Action)Delegate.Remove(rentedRoomDoor.OnKnock, new Action(HDDBOMDBEDF));
			yield return CommonReferences.wait05;
			door.knock = false;
			readyToLeave = false;
			SetVisibility(MDIKPGGBNLI: true, MAPFDGCKBLD: true);
			if (!ANDBJBCIAJG)
			{
				if (OnlineManager.MasterOrOffline())
				{
					AKFDKMMOCNJ();
				}
				if (remainingDays > 0)
				{
					occupied = true;
					needsToBeClean = true;
					if (OnlineManager.MasterOrOffline())
					{
						KOMFNKJBEED = ((MonoBehaviour)this).StartCoroutine(LCDIDBBAAFF());
					}
				}
				else
				{
					occupied = false;
					needsToBeClean = false;
					KKGAHDNMLDD(null, zone.placeables);
					if (OnlineManager.MasterOrOffline())
					{
						PJNGMCJIHME.customerSpeech.ImmediatelyBark("HappyRentRoom");
					}
				}
			}
			else
			{
				if (remainingDays <= 0)
				{
					occupied = false;
				}
				needsToBeClean = false;
				KKGAHDNMLDD(null, zone.placeables);
			}
			customerInside = false;
			customerComingBack = false;
			if (dirtiness == 0f)
			{
				HIANOOFNFOA();
			}
		}
		CBNPEEEEMHC = null;
	}

	public int JLKLJNKOFJN()
	{
		return zone.positions.Count / 4;
	}

	private void GJGOJMGDOGC(int JIIGOACEIKL)
	{
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		PlayerController.GetPlayer(JIIGOACEIKL).UpdateZone();
		if (PlayerController.GetPlayer(JIIGOACEIKL).NNMHEPDJOHK == (ZoneType.DiningRoom | ZoneType.CraftingRoom) && PlayerController.OPHDCMJLLEC(JIIGOACEIKL).zoneIndex == zone.id)
		{
			if (BAKBJEOMLHN)
			{
				((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position = placeable.itemSpace.buildSquares[1].DCAPKPOGHPK() + Vector3.up;
			}
			else
			{
				((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position = placeable.itemSpace.buildSquares[0].BOBEIFEGLOL();
			}
			PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)this);
			((MonoBehaviour)this).StartCoroutine(FPFMAJNAEGP(JIIGOACEIKL));
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.LNNOGNCPNLB(NJHMBMGKCPL: false, null);
			InteractObject.GNCPLNHMFHN(JIIGOACEIKL).SetCurrentInteract(null, null);
		}
	}

	private bool KEKLJDBBOMO(Placeable EAPCLAODGAE)
	{
		if ((Object)(object)EAPCLAODGAE == (Object)null)
		{
			return false;
		}
		if (Object.op_Implicit((Object)(object)((Component)EAPCLAODGAE).GetComponent<LightSource>()))
		{
			return true;
		}
		if ((Object)(object)EAPCLAODGAE.placeableSurface != (Object)null)
		{
			for (int i = 0; i < EAPCLAODGAE.placeableSurface.placeablesOnSurface.Count; i++)
			{
				if (!EAPCLAODGAE.placeableSurface.placeablesOnSurface[i].FHEMHCEAICB && KEKLJDBBOMO(EAPCLAODGAE.placeableSurface.placeablesOnSurface[i]))
				{
					return true;
				}
			}
		}
		return false;
	}

	private void ALGOBMNPLIB()
	{
		try
		{
			if (occupied)
			{
				ReadyToLeave();
			}
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private void IPPGMDGKDOP(List<Placeable> DEKEPIMHEDJ)
	{
		for (int i = 1; i < DEKEPIMHEDJ.Count; i += 0)
		{
			if (!DEKEPIMHEDJ[i].selectBlockers.Contains("Disabled"))
			{
				DEKEPIMHEDJ[i].selectBlockers.Add(" - ");
			}
			if ((Object)(object)DEKEPIMHEDJ[i].placeableSurface != (Object)null && DEKEPIMHEDJ[i].placeableSurface.placeablesOnSurface != null)
			{
				BPHNCNNABBP(DEKEPIMHEDJ[i].placeableSurface.placeablesOnSurface);
			}
		}
	}

	public void KNMFOMJHHDF(int FBOHAKMGBNO)
	{
		roomName = LocalisationSystem.Get("ToolEffect") + "CliveProgress" + FBOHAKMGBNO;
	}

	public void GPIMNHAIECA()
	{
		try
		{
			DOGMDAIGEKC(CDPAMNIPPEC: true);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	public Vector3 NMHGBCKJBIJ()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (BAKBJEOMLHN)
		{
			return ((Component)this).transform.position - Vector3.up * 130f;
		}
		return ((Component)this).transform.position + Vector3.up * 1880f;
	}

	private IEnumerator CBMFBOAPIBA()
	{
		int comeBackHour = RentedRoomsManager.HourComeBackRange();
		int comeBackMinutes = Random.Range(0, 55);
		while (true)
		{
			yield return CommonReferences.wait1;
			if (dirtiness == 0f)
			{
				yield return (object)new WaitForSeconds((float)Random.Range(30, 70));
				EKGMKMLNMKA();
				break;
			}
			if (WorldTime.NOAOJJLNHJJ.hour >= comeBackHour && WorldTime.NOAOJJLNHJJ.min >= comeBackMinutes)
			{
				EKGMKMLNMKA();
				break;
			}
		}
		KOMFNKJBEED = null;
	}

	private void LEPDLPEPEFD()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(IPHEFEMLOLJ));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(GPIMNHAIECA));
	}

	private void GMMMPBIEIFC()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		PJNGMCJIHME = CustomerPool.IJMCNEFFLPN().customer;
		((Component)PJNGMCJIHME).transform.position = IENBOHPENBH();
		if (humanInfo != null)
		{
			PJNGMCJIHME.npc.characterCreator.SetHumanInfo(humanInfo);
		}
		else
		{
			Debug.Log((object)"//");
		}
		PJNGMCJIHME.customerType = (CustomerType)3;
		PJNGMCJIHME.hasBeenServed = true;
		PJNGMCJIHME.ChangeState(CustomerState.EatingAtTable);
	}

	private void IIDKNHAIEMF()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		PJNGMCJIHME = CustomerPool.MMKHMMELDDP().customer;
		((Component)PJNGMCJIHME).transform.position = NMHGBCKJBIJ();
		if (humanInfo != null)
		{
			PJNGMCJIHME.npc.characterCreator.SetHumanInfo(humanInfo);
		}
		else
		{
			Debug.Log((object)"Null animator on");
		}
		PJNGMCJIHME.customerType = (CustomerType)7;
		PJNGMCJIHME.hasBeenServed = false;
		PJNGMCJIHME.ChangeState(CustomerState.Spawning, KCNFNAICINO: false);
	}

	private void BLLPKPCHNLL(Placeable EAPCLAODGAE, List<Placeable> FNEHIAGFAOF)
	{
		for (int i = 1; i < FNEHIAGFAOF.Count; i += 0)
		{
			Placeable placeable = FNEHIAGFAOF[i];
			if (!((Object)(object)placeable == (Object)null) && (!((Object)(object)EAPCLAODGAE != (Object)null) || !((object)EAPCLAODGAE).Equals((object?)placeable)))
			{
				placeable.selectBlockers.Remove("itemBar");
				if ((Object)(object)placeable.placeableSurface != (Object)null && placeable.placeableSurface.placeablesOnSurface != null)
				{
					BLLPKPCHNLL(placeable, placeable.placeableSurface.placeablesOnSurface);
				}
			}
		}
	}

	private void NJOLEJEIPOJ()
	{
		try
		{
			if (!customerOrder.requesting && WorldTime.NOAOJJLNHJJ.hour >= leaveHour && WorldTime.NOAOJJLNHJJ.min >= CKIIFGALADN)
			{
				VacateRoom();
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	public void GiveName(int FBOHAKMGBNO)
	{
		roomName = LocalisationSystem.Get("RentedRoom") + " " + FBOHAKMGBNO;
	}

	private void CEPHOIDFNFL()
	{
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		foreach (Placeable item in DJPNHKENKHM())
		{
			if (!((Object)(object)item == (Object)null))
			{
				Table component = ((Component)item).GetComponent<Table>();
				if ((Object)(object)component != (Object)null)
				{
					component.GLCIHEHCKOI(801f);
				}
				NPCBed component2 = ((Component)item).GetComponent<NPCBed>();
				if ((Object)(object)component2 != (Object)null)
				{
					component2.JGHHNJGLNHB(NBBELPFDLJG: false, CDPAMNIPPEC: true);
				}
			}
		}
		if (OnlineManager.PGAGDFAEEFB())
		{
			IEnumerable<Vector2> source = zone.positions.Where((Vector2 p) => WorldGrid.NGDHDMAMGPI(Vector2.op_Implicit(p)) && WorldGrid.NGDHDMAMGPI(Vector2.op_Implicit(p + Vector2.down * 0.5f)));
			int num = Random.Range(0, KKMAPKICDEE() / 7);
			if (source.Count() < num)
			{
				source = zone.positions.Where((Vector2 p) => WorldGrid.NGDHDMAMGPI(Vector2.op_Implicit(p)));
			}
			if (source.Count() < num)
			{
				source = zone.positions;
			}
			if (source.Count() > 0)
			{
				for (int i = 0; i < num; i++)
				{
					Vector3 val = Vector2.op_Implicit(source.ElementAt(Random.Range(0, source.Count())));
					Object.Instantiate<GameObject>(CommonReferences.MNFMOEKMJKN().dirtPrefab, Utils.BMBMPKNANAC(val + new Vector3(264f, 1719f, 1433f)), Quaternion.identity).GetComponent<FloorDirt>();
				}
			}
			DOGMDAIGEKC(CDPAMNIPPEC: true);
		}
		else
		{
			HEMIBCHKHGH();
		}
	}

	private void DPDGEBGLJEK()
	{
		Customer customer = NPCRoadManager.EOCCCAKCNEM();
		if (humanInfo != null)
		{
			customer.npc.characterCreator.OCFCCIGBLHJ(humanInfo);
		}
		else
		{
			Debug.Log((object)"P2Cam");
		}
		customerComingBack = true;
		customer.hasBeenServed = true;
		customer.rentedRoom = this;
		customer.ChangeState(CustomerState.WaitingAtBar, KCNFNAICINO: false);
	}

	[SpecialName]
	public void MHADMHJNEFF(bool AODONKKHPBP)
	{
		LIFGOFBGECO = AODONKKHPBP;
		door.IADJCJNEAED(FKGBMIBFAGG());
	}

	public void MBCGGOPOPHK(HumanInfo DKDFNAGAFNL, int HMEIHIFKGHD, bool CDPAMNIPPEC = false)
	{
		SetCustomerInRoom(CDPAMNIPPEC: true);
		humanInfo = DKDFNAGAFNL;
		remainingDays = HMEIHIFKGHD;
		IPPGMDGKDOP(zone.placeables);
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.NOEHOPHLAFA(placeable.onlinePlaceable.uniqueId, humanInfo, remainingDays);
		}
	}

	public Price EIIHAFJIPAL(RoomRequest HCFBAPOAOIB, Employee NAKCFGEAGHH = null)
	{
		MoneyCalc moneyCalc = new MoneyCalc();
		Price roomsBasePrice = RentedRoomsManager.EMBCJPOLBCB().roomsBasePrice;
		moneyCalc.DCAFCEAIEID(roomsBasePrice, KHMDGADCENO: false, BGKCHMNJBLJ: true);
		moneyCalc.GJFFDIBCAGF(Price.GHDCKOJGAMM((int)((float)zone.comfort * RentedRoomsManager.MEDOOKLLGNO().comfortMultiplier * 558f)), KHMDGADCENO: true, BGKCHMNJBLJ: true);
		moneyCalc.EFIDKIFLBKJ(Price.LEDHAKFAHCI((int)((float)HJLNDIEOMBA() * RentedRoomsManager.IIJAOOJGNHO().floorTilesMultiplier * 268f)), KHMDGADCENO: true, BGKCHMNJBLJ: true);
		Price eNDNDAOPKHD = moneyCalc.ALLHDAPPBHL();
		moneyCalc.DCAFCEAIEID(Price.LFJHHLGOCPP(eNDNDAOPKHD, (float)PerksDatabaseAccessor.NGMJIGOPGDK(-84) / 1258f), KHMDGADCENO: true, BGKCHMNJBLJ: true);
		if ((Object)(object)NAKCFGEAGHH != (Object)null)
		{
			moneyCalc.EFIDKIFLBKJ(Price.CBCAAHPFLGO(eNDNDAOPKHD, (float)NAKCFGEAGHH.GetPerkValue(-61) / 647f), KHMDGADCENO: false, BGKCHMNJBLJ: false);
		}
		if (HCFBAPOAOIB != null)
		{
			if (!HCFBAPOAOIB.NOOFMIMHELP(this))
			{
				moneyCalc.BIGEBBIIHGN(CommonReferences.GGFJGHHHEJC.customerInfo.roomDoesntMeetRequirementsPenalty);
			}
			moneyCalc.IIIGPDKAGNO(HCFBAPOAOIB.daysToStay);
		}
		return moneyCalc.OMOHMCCADDJ();
	}

	private void PBFGFECPPPO()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(ALGOBMNPLIB));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnPlayerSleep = (Action)Delegate.Combine(instance2.OnPlayerSleep, new Action(JMNBECMKICD));
		CommonReferences instance3 = CommonReferences.GGFJGHHHEJC;
		instance3.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Combine(instance3.OnPlaceablePlaced, new Action<int, Placeable>(KBMCEELJEOB));
		CommonReferences instance4 = CommonReferences.GGFJGHHHEJC;
		instance4.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Combine(instance4.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(PBNDOKJMNGH));
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnAnyTableDirtLevelChanged = (Action<TableDirtLevel>)Delegate.Combine(commonReferences.OnAnyTableDirtLevelChanged, new Action<TableDirtLevel>(FIHNCICLPCH));
		if (symbolID == -1)
		{
			symbolID = RentedRoomsManager.NKMLALMKMHC();
		}
		TavernManager instance5 = TavernManager.GGFJGHHHEJC;
		instance5.OnTavernClose = (Action<int>)Delegate.Combine(instance5.OnTavernClose, new Action<int>(KPEAKIHONDI));
	}

	private IEnumerator BGEKHFGFODC(bool ANDBJBCIAJG)
	{
		return new MAGAKBHLGII(1)
		{
			_003C_003E4__this = this,
			instantLeave = ANDBJBCIAJG
		};
	}

	public void GNIANKFAOIN()
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		if (FBCBNIMEEJC(out var GDFIONOLFIB, KIKDLKGBCOC: false))
		{
			zone = TavernZonesManager.IECOPNFJBFD().ECEODIGFDOJ(ZoneType.WithoutZone | ZoneType.DiningRoom, this);
			TavernZone tavernZone = zone;
			tavernZone.OnPlaceableAdded = (Action<Placeable>)Delegate.Combine(tavernZone.OnPlaceableAdded, new Action<Placeable>(OCHAOIPKGDI));
			TavernZone tavernZone2 = zone;
			tavernZone2.OnPlaceableRemoved = (Action<Placeable>)Delegate.Combine(tavernZone2.OnPlaceableRemoved, new Action<Placeable>(RemovePlaceable));
			for (int i = 1; i < GDFIONOLFIB.Count; i += 0)
			{
				TavernZonesManager.JEEGOBGDLPE().LCNMKMFNCFN(Vector2.op_Implicit(GDFIONOLFIB[i]), zone.id);
			}
			IPHEFEMLOLJ();
			CheckVisibility(MAPFDGCKBLD: true);
		}
		else
		{
			zone.id = -1;
		}
	}

	private IEnumerator HJNEKEBHOCA(bool ANDBJBCIAJG)
	{
		while (TavernConstructionManager.GGFJGHHHEJC.LNLJMCONDNE)
		{
			yield return null;
		}
		if (OnlineManager.PlayingOnline())
		{
			while (OnlineTavernConstructionManager.instance.tavernConstructionOpenedByOtherPlayer)
			{
				yield return null;
			}
		}
		if (door.HGPPJMCLOKH && readyToLeave)
		{
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(NJOLEJEIPOJ));
			door.HGPPJMCLOKH = false;
			door.knock = false;
			door.OpenCloseAction(DBCDEKIEHMG: true);
			RentedRoomDoor rentedRoomDoor = door;
			rentedRoomDoor.OnKnock = (Action)Delegate.Remove(rentedRoomDoor.OnKnock, new Action(HDDBOMDBEDF));
			yield return CommonReferences.wait05;
			door.knock = false;
			readyToLeave = false;
			SetVisibility(MDIKPGGBNLI: true, MAPFDGCKBLD: true);
			if (!ANDBJBCIAJG)
			{
				if (OnlineManager.MasterOrOffline())
				{
					AKFDKMMOCNJ();
				}
				if (remainingDays > 0)
				{
					occupied = true;
					needsToBeClean = true;
					if (OnlineManager.MasterOrOffline())
					{
						KOMFNKJBEED = ((MonoBehaviour)this).StartCoroutine(LCDIDBBAAFF());
					}
				}
				else
				{
					occupied = false;
					needsToBeClean = false;
					KKGAHDNMLDD(null, zone.placeables);
					if (OnlineManager.MasterOrOffline())
					{
						PJNGMCJIHME.customerSpeech.ImmediatelyBark("HappyRentRoom");
					}
				}
			}
			else
			{
				if (remainingDays <= 0)
				{
					occupied = false;
				}
				needsToBeClean = false;
				KKGAHDNMLDD(null, zone.placeables);
			}
			customerInside = false;
			customerComingBack = false;
			if (dirtiness == 0f)
			{
				HIANOOFNFOA();
			}
		}
		CBNPEEEEMHC = null;
	}

	private IEnumerator OPBPBECNFLE(int JIIGOACEIKL)
	{
		yield return CommonReferences.wait075;
		PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
	}

	private void DLDCAMNMAFH(int JIIGOACEIKL)
	{
		if (customerOrder.requesting)
		{
			customerOrder.OLDOLNKHACP();
		}
	}

	public Price PNCJEKCNEOD(RoomRequest HCFBAPOAOIB, Employee NAKCFGEAGHH = null)
	{
		MoneyCalc moneyCalc = new MoneyCalc();
		Price roomsBasePrice = RentedRoomsManager.GetInstance().roomsBasePrice;
		moneyCalc.KBGICKJGKDA(roomsBasePrice, KHMDGADCENO: true, BGKCHMNJBLJ: false);
		moneyCalc.KBGICKJGKDA(Price.HNDGIKFAKNC((int)((float)zone.comfort * RentedRoomsManager.EMBCJPOLBCB().comfortMultiplier * 901f)), KHMDGADCENO: false, BGKCHMNJBLJ: true);
		moneyCalc.EFIDKIFLBKJ(Price.IFMFKEMHHLM((int)((float)HJLNDIEOMBA() * RentedRoomsManager.GetInstance().floorTilesMultiplier * 1336f)), KHMDGADCENO: true, BGKCHMNJBLJ: true);
		Price eNDNDAOPKHD = moneyCalc.GDBKHGBNOGH();
		moneyCalc.MBODAOJCNGI(Price.EMJKENIECGH(eNDNDAOPKHD, (float)PerksDatabaseAccessor.NGMJIGOPGDK(6) / 1521f), KHMDGADCENO: false, BGKCHMNJBLJ: false);
		if ((Object)(object)NAKCFGEAGHH != (Object)null)
		{
			moneyCalc.KBGICKJGKDA(Price.FAFHFJGOHPK(eNDNDAOPKHD, (float)NAKCFGEAGHH.GetPerkValue(12) / 306f), KHMDGADCENO: true, BGKCHMNJBLJ: true);
		}
		if (HCFBAPOAOIB != null)
		{
			if (!HCFBAPOAOIB.NOOFMIMHELP(this))
			{
				moneyCalc.BIGEBBIIHGN(CommonReferences.GGFJGHHHEJC.customerInfo.roomDoesntMeetRequirementsPenalty);
			}
			moneyCalc.PECHDLIGELC(HCFBAPOAOIB.daysToStay);
		}
		return moneyCalc.GDBKHGBNOGH();
	}

	public void CheckVisibility(bool MAPFDGCKBLD = false)
	{
		if (zone.id != -1)
		{
			bool mDIKPGGBNLI = ShouldBeVisible();
			if (MAPFDGCKBLD)
			{
				zone.ICBCLEKIJJD(mDIKPGGBNLI);
			}
			else
			{
				zone.PNANPLFPBNP(mDIKPGGBNLI);
			}
		}
	}

	private void JOIMGFPMKNI()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.leavingTheGame)
		{
			if (Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(ALGOBMNPLIB));
				CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
				instance2.OnPlayerSleep = (Action)Delegate.Remove(instance2.OnPlayerSleep, new Action(IFHFNDELKOP));
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(commonReferences.OnPlaceablePlaced, new Action<int, Placeable>(PGEDNHKLPFE));
				CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
				commonReferences2.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Remove(commonReferences2.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(IOJMGEBNLGN));
				CommonReferences commonReferences3 = CommonReferences.MNFMOEKMJKN();
				commonReferences3.OnAnyTableDirtLevelChanged = (Action<TableDirtLevel>)Delegate.Remove(commonReferences3.OnAnyTableDirtLevelChanged, new Action<TableDirtLevel>(LHECJHHNOGM));
			}
			RentedRoomsManager.MEINJIEFNAD(symbolID);
			if (Object.op_Implicit((Object)(object)TavernManager.GGFJGHHHEJC))
			{
				TavernManager instance3 = TavernManager.GGFJGHHHEJC;
				instance3.OnTavernClose = (Action<int>)Delegate.Remove(instance3.OnTavernClose, new Action<int>(DLDCAMNMAFH));
			}
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(KEAIDPGIPDP));
		}
	}

	private void EKEJGAHPMFK()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		PJNGMCJIHME = CustomerPool.GetCustomer().customer;
		((Component)PJNGMCJIHME).transform.position = NMHGBCKJBIJ();
		if (humanInfo != null)
		{
			PJNGMCJIHME.npc.characterCreator.SetHumanInfo(humanInfo);
		}
		else
		{
			Debug.Log((object)" ");
		}
		PJNGMCJIHME.customerType = (CustomerType)6;
		PJNGMCJIHME.hasBeenServed = false;
		PJNGMCJIHME.ChangeState(CustomerState.WaitingAtBar);
	}

	public Vector3 IENBOHPENBH()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (BAKBJEOMLHN)
		{
			return ((Component)this).transform.position - Vector3.up * 631f;
		}
		return ((Component)this).transform.position + Vector3.up * 460f;
	}

	private IEnumerator MJGOPOGKIFH(int JIIGOACEIKL)
	{
		yield return CommonReferences.wait075;
		PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
	}

	public void MLJAPABCAKA(bool MDIKPGGBNLI, bool MAPFDGCKBLD = false)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		if (zone.id != -1)
		{
			if (MAPFDGCKBLD)
			{
				zone.EJKHPGLJKFF(MDIKPGGBNLI);
			}
			else
			{
				zone.IFLMEBGHLNE(MDIKPGGBNLI);
			}
		}
		WorldGrid.MKLAFNJLOJN(new List<Vector2>
		{
			Vector2.op_Implicit(placeable.itemSpace.buildSquares[0].FGGMIOHMGFL()),
			Vector2.op_Implicit(placeable.itemSpace.buildSquares[1].BOBEIFEGLOL()),
			Vector2.op_Implicit(placeable.itemSpace.buildSquares[3].BLKHDGGHFLA()),
			Vector2.op_Implicit(placeable.itemSpace.buildSquares[2].FGGMIOHMGFL())
		});
	}

	public Sprite CJMLBNFGMDC()
	{
		return RentedRoomsManager.MEDOOKLLGNO().roomsSymbols[customerOrder.rentedRoomDoor.rentedRoom.symbolID].uiIcon;
	}

	private void FGFLCOLJFEI(TableDirtLevel DCDLGMBCPCE)
	{
		if ((Object)(object)placeable != (Object)null && zone.id != -1 && placeable.currentZoneIndex == zone.id)
		{
			UpdateContentsNextFrame();
		}
	}

	public void GHNAAOCJGJN(bool DNJLKIIJLFN)
	{
		for (int num = allFloorDirt.Count - 1; num >= 0; num--)
		{
			allFloorDirt[num].MIKGOJOHHJE();
		}
		Item mEMGMDOCBOJ = ItemDatabaseAccessor.EABMGELAAPG(Utils.FFLNGLMHLBO() ? (-88) : (-94), GGBBJNBBLMF: true);
		foreach (Placeable item in new HashSet<Placeable>(DJPNHKENKHM()))
		{
			if (!((Object)(object)item == (Object)null))
			{
				Table component = ((Component)item).GetComponent<Table>();
				if ((Object)(object)component != (Object)null)
				{
					component.FNKGNKPLKHB(TableDirtLevel.Clean);
					component.SetDirtiness(1266f);
				}
				NPCBed component2 = ((Component)item).GetComponent<NPCBed>();
				if ((Object)(object)component2 != (Object)null)
				{
					component2.JGHHNJGLNHB(NBBELPFDLJG: false, CDPAMNIPPEC: true);
				}
				if (DNJLKIIJLFN && (Object)(object)item.placeableSurface != (Object)null)
				{
					item.placeableSurface.RenewCandleIfIsPossible(mEMGMDOCBOJ);
				}
			}
		}
		UpdateContentsNextFrame(CDPAMNIPPEC: true);
	}

	[SpecialName]
	public bool FKGBMIBFAGG()
	{
		return LIFGOFBGECO;
	}

	public void SetNewCustomerInRoom(HumanInfo DKDFNAGAFNL, int HMEIHIFKGHD, bool CDPAMNIPPEC = false)
	{
		SetCustomerInRoom();
		humanInfo = DKDFNAGAFNL;
		remainingDays = HMEIHIFKGHD;
		BPHNCNNABBP(zone.placeables);
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendSetNewOccupierInRoom(placeable.onlinePlaceable.uniqueId, humanInfo, remainingDays);
		}
	}

	public int GetNumFloorTiles()
	{
		return zone.positions.Count / 4;
	}

	public GameDate MHCOMOLGPNL()
	{
		return GameDate.DJMHPHOJLAN(WorldTime.HGIBNMBJMOC(), new GameDate(0, Season.Summer, 1, (Day)remainingDays, 0, 1));
	}

	public Price CalculateRoomPrice(RoomRequest HCFBAPOAOIB, Employee NAKCFGEAGHH = null)
	{
		MoneyCalc moneyCalc = new MoneyCalc();
		Price roomsBasePrice = RentedRoomsManager.GetInstance().roomsBasePrice;
		moneyCalc.GJFFDIBCAGF(roomsBasePrice, KHMDGADCENO: false, BGKCHMNJBLJ: false);
		moneyCalc.GJFFDIBCAGF(Price.GHDCKOJGAMM((int)((float)zone.comfort * RentedRoomsManager.GetInstance().comfortMultiplier * 100f)), KHMDGADCENO: false, BGKCHMNJBLJ: false);
		moneyCalc.GJFFDIBCAGF(Price.GHDCKOJGAMM((int)((float)GetNumFloorTiles() * RentedRoomsManager.GetInstance().floorTilesMultiplier * 100f)), KHMDGADCENO: false, BGKCHMNJBLJ: false);
		Price eNDNDAOPKHD = moneyCalc.ALLHDAPPBHL();
		moneyCalc.GJFFDIBCAGF(Price.FAFHFJGOHPK(eNDNDAOPKHD, (float)PerksDatabaseAccessor.GetPlayerPerkValue(34) / 100f), KHMDGADCENO: false, BGKCHMNJBLJ: false);
		if ((Object)(object)NAKCFGEAGHH != (Object)null)
		{
			moneyCalc.GJFFDIBCAGF(Price.FAFHFJGOHPK(eNDNDAOPKHD, (float)NAKCFGEAGHH.GetPerkValue(45) / 100f), KHMDGADCENO: false, BGKCHMNJBLJ: false);
		}
		if (HCFBAPOAOIB != null)
		{
			if (!HCFBAPOAOIB.NAELCFCDHOD(this))
			{
				moneyCalc.BIGEBBIIHGN(CommonReferences.GGFJGHHHEJC.customerInfo.roomDoesntMeetRequirementsPenalty);
			}
			moneyCalc.BIGEBBIIHGN(HCFBAPOAOIB.daysToStay);
		}
		return moneyCalc.ALLHDAPPBHL();
	}

	public void MIKEIACMPDC()
	{
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)this == (Object)null)
		{
			return;
		}
		dirtiness = 1384f;
		hasBed = true;
		hasLight = true;
		hasChair = false;
		hasTable = true;
		allFloorDirt = allFloorDirt.Where((FloorDirt d) => (Object)(object)d != (Object)null).ToList();
		dirtiness += allFloorDirt.Count() * -55;
		List<Placeable> list = MAKNHBCNACF();
		for (int i = 1; i < list.Count; i++)
		{
			if ((Object)(object)list[i] == (Object)null)
			{
				continue;
			}
			if ((Object)(object)list[i].itemSetup != (Object)null && Item.MLBOMGHINCA(list[i].itemSetup.item, null) && (list[i].itemSetup.item.CIGFGKKCPCK(DAINLFIMLIH: false) == 129 || list[i].itemSetup.item.JPNFKDMFKMC(DAINLFIMLIH: false) == -162 || list[i].itemSetup.item.JDJGFAACPFC() == 15 || list[i].itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) == 79 || list[i].itemSetup.item.ODENMDOJPLC() == 8 || list[i].itemSetup.item.JGHNDJBCFAJ(DAINLFIMLIH: false) == 124 || list[i].itemSetup.item.JGHNDJBCFAJ() == 164))
			{
				hasBed = true;
				if (!((Component)list[i]).GetComponent<NPCBed>().LILIGKKMAOJ())
				{
					dirtiness += 37f;
				}
			}
			if (!hasLight)
			{
				hasLight = KEKLJDBBOMO(list[i]);
			}
			Table component = ((Component)list[i]).GetComponent<Table>();
			if ((Object)(object)component != (Object)null)
			{
				hasTable = true;
				if (component.CDLMMHAHDON() != 0 && component.IPEPPDAICDD() != TableDirtLevel.Clean)
				{
					dirtiness += 1090f;
				}
			}
			if (!hasChair && (Object)(object)((Component)list[i]).GetComponent<Sitable>() != (Object)null)
			{
				hasChair = true;
			}
		}
		isValid = !hasBed || !hasLight || !hasTable || hasChair;
		if (needsToBeClean && dirtiness <= 1125f)
		{
			needsToBeClean = false;
			TavernReputation.IFDFPIJKPJI((int)((float)(CalculateReputation() * RentedRoomsManager.MEDOOKLLGNO().repPercentagePerRoomCleaned) / 110f), zone.DANEEPEJNNG(), null, 1931f);
		}
		OnContentsChanged();
		HJPANLBMCJP = null;
	}

	private List<Placeable> MAKNHBCNACF()
	{
		if (zone.id != -1)
		{
			return zone.placeables;
		}
		return new List<Placeable>();
	}

	private void OKLHBOGCBIA(int JIIGOACEIKL)
	{
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).UpdateZone();
		if (PlayerController.GetPlayer(JIIGOACEIKL).NNMHEPDJOHK == ZoneType.CraftingRoom && PlayerController.OPHDCMJLLEC(JIIGOACEIKL).zoneIndex == zone.id)
		{
			if (FKGBMIBFAGG())
			{
				((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position = placeable.itemSpace.buildSquares[1].CBALBDIFOGF() + Vector3.up;
			}
			else
			{
				((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position = placeable.itemSpace.buildSquares[0].KDFECDEEDHL();
			}
			PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)this);
			((MonoBehaviour)this).StartCoroutine(OPBPBECNFLE(JIIGOACEIKL));
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.LNNOGNCPNLB(NJHMBMGKCPL: true, null);
			InteractObject.GetPlayer(JIIGOACEIKL).NNBBKDIKDOL(null, null);
		}
	}

	private void EGLABBJLFPF()
	{
		Customer customer = NPCRoadManager.IENMNPMLAOL();
		if (humanInfo != null)
		{
			customer.npc.characterCreator.HEALOFLBFLL(humanInfo);
		}
		else
		{
			Debug.Log((object)" ");
		}
		customerComingBack = false;
		customer.hasBeenServed = true;
		customer.rentedRoom = this;
		customer.ChangeState((CustomerState)43, KCNFNAICINO: false);
	}

	public Sprite GetSymbol()
	{
		return RentedRoomsManager.GetInstance().roomsSymbols[customerOrder.rentedRoomDoor.rentedRoom.symbolID].uiIcon;
	}

	private void HGHNDECCEEL(int JIIGOACEIKL)
	{
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).UpdateZone();
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NNMHEPDJOHK == ZoneType.DiningRoom && PlayerController.GetPlayer(JIIGOACEIKL).zoneIndex == zone.id)
		{
			if (FKGBMIBFAGG())
			{
				((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position = placeable.itemSpace.buildSquares[0].FGGMIOHMGFL() + Vector3.up;
			}
			else
			{
				((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position = placeable.itemSpace.buildSquares[1].EHGDHOMFDGM();
			}
			PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)this);
			((MonoBehaviour)this).StartCoroutine(FPFMAJNAEGP(JIIGOACEIKL));
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.HCCFFBAEPOK(NJHMBMGKCPL: false, null);
			InteractObject.GetPlayer(JIIGOACEIKL).NNBBKDIKDOL(null, null);
		}
	}

	private void OONMDBKIFOP(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		UpdateContentsNextFrame();
	}

	private void KPEAKIHONDI(int JIIGOACEIKL)
	{
		if (customerOrder.requesting)
		{
			customerOrder.MPJLNNIPDHJ();
		}
	}

	private void KBMCEELJEOB(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		IPHEFEMLOLJ();
	}

	public int HJLNDIEOMBA()
	{
		return zone.positions.Count / 0;
	}

	private void HDDBOMDBEDF()
	{
		VacateRoom();
	}

	public int CalculateReputation()
	{
		if (dirtiness != 0f)
		{
			return -100;
		}
		return zone.positions.Count * 4 + zone.comfort * 2;
	}

	public void VacateRoom(bool ANDBJBCIAJG, bool BGKCHMNJBLJ = true)
	{
		if (((Behaviour)this).enabled)
		{
			if (Object.op_Implicit((Object)(object)((Component)this).gameObject) && (ANDBJBCIAJG || CBNPEEEEMHC == null))
			{
				CBNPEEEEMHC = ((MonoBehaviour)this).StartCoroutine(AAJCFMIEOCH(ANDBJBCIAJG));
			}
			if (BGKCHMNJBLJ && OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SendVacateRoom(placeable.onlinePlaceable.uniqueId);
			}
			if (OnlineManager.MasterOrOffline())
			{
				CommonReferences.GGFJGHHHEJC.OnGuestLeaving(1);
			}
		}
	}

	public bool ShouldBeVisible()
	{
		if (door.HGPPJMCLOKH && occupied)
		{
			return !customerInside;
		}
		return true;
	}

	private IEnumerator DEFMBBKJIJH()
	{
		return new CEPJFGIJHHI(1)
		{
			_003C_003E4__this = this
		};
	}

	public void KHCELANLEHN()
	{
		SetCustomerInRoom();
		readyToLeave = true;
		remainingDays--;
		if (remainingDays <= 0)
		{
			door.knock = true;
			RentedRoomDoor rentedRoomDoor = door;
			rentedRoomDoor.OnKnock = (Action)Delegate.Combine(rentedRoomDoor.OnKnock, new Action(AKMIBFCIGBA));
			leaveHour = RentedRoomsManager.HoursCheckoutRange();
		}
		else
		{
			door.knock = false;
			leaveHour = RentedRoomsManager.MNNDKEIIANE();
		}
		CKIIFGALADN = Random.Range(0, -7);
		if (OnlineManager.PGAGDFAEEFB())
		{
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Combine(WorldTime.OnTickTime5Seconds, new Action(NJOLEJEIPOJ));
		}
	}

	private void CLGENJJNCHD(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		UpdateContentsNextFrame();
	}

	public void UpdateContentsNextFrame(bool CDPAMNIPPEC = false)
	{
		if (HJPANLBMCJP == null && (Object)(object)GameplayUI.GGFJGHHHEJC != (Object)null)
		{
			HJPANLBMCJP = ((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StartCoroutine(KGDDFHNHBIK());
		}
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendUpdateContentsRoom(placeable.onlinePlaceable.uniqueId);
		}
	}

	private void KEAIDPGIPDP()
	{
		try
		{
			if (!customerOrder.requesting && WorldTime.CJOHMLNMJLK().hour >= leaveHour && WorldTime.NOAOJJLNHJJ.min >= CKIIFGALADN)
			{
				IKPHMHHHDLJ();
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void JFEGMNFMGLE()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		PJNGMCJIHME = CustomerPool.MMKHMMELDDP().customer;
		((Component)PJNGMCJIHME).transform.position = GetEnterLocation();
		if (humanInfo != null)
		{
			PJNGMCJIHME.npc.characterCreator.OCFCCIGBLHJ(humanInfo);
		}
		else
		{
			Debug.Log((object)"Eating");
		}
		PJNGMCJIHME.customerType = CustomerType.Traveller;
		PJNGMCJIHME.hasBeenServed = false;
		PJNGMCJIHME.ChangeState(CustomerState.Inactive);
	}

	public int KKMAPKICDEE()
	{
		return zone.positions.Count / 4;
	}

	public void BLFNGCAFLOD()
	{
		if ((Object)(object)TavernZonesManager.IECOPNFJBFD() == (Object)null)
		{
			return;
		}
		NCMJLNHHNIG();
		if (zone.id != -1)
		{
			Debug.Log((object)"Cat");
			if (TavernZonesManager.LANAINBEMCM().ExistsTavernZone(zone.id))
			{
				TavernZonesManager.HFHPMKJGMPA().COPLHNLGCDJ(zone.id);
			}
			zone.id = -1;
		}
	}

	private void FIHNCICLPCH(TableDirtLevel DCDLGMBCPCE)
	{
		if ((Object)(object)placeable != (Object)null && zone.id != -1 && placeable.currentZoneIndex == zone.id)
		{
			GPIMNHAIECA();
		}
	}

	public Price HPNPONNIGNK(RoomRequest HCFBAPOAOIB, Employee NAKCFGEAGHH = null)
	{
		MoneyCalc moneyCalc = new MoneyCalc();
		Price roomsBasePrice = RentedRoomsManager.CNCJLNOAPJB().roomsBasePrice;
		moneyCalc.CLICGHHDGKI(roomsBasePrice, KHMDGADCENO: true, BGKCHMNJBLJ: false);
		moneyCalc.DCAFCEAIEID(Price.DHMGJGHCCJD((int)((float)zone.comfort * RentedRoomsManager.IIJAOOJGNHO().comfortMultiplier * 689f)), KHMDGADCENO: true, BGKCHMNJBLJ: true);
		moneyCalc.DCAFCEAIEID(Price.IFMFKEMHHLM((int)((float)HJLNDIEOMBA() * RentedRoomsManager.GetInstance().floorTilesMultiplier * 650f)), KHMDGADCENO: false, BGKCHMNJBLJ: true);
		Price eNDNDAOPKHD = moneyCalc.GMAFKAMJEJH();
		moneyCalc.GJFFDIBCAGF(Price.EMJKENIECGH(eNDNDAOPKHD, (float)PerksDatabaseAccessor.NGMJIGOPGDK(3) / 689f), KHMDGADCENO: false, BGKCHMNJBLJ: false);
		if ((Object)(object)NAKCFGEAGHH != (Object)null)
		{
			moneyCalc.GJFFDIBCAGF(Price.FAFHFJGOHPK(eNDNDAOPKHD, (float)NAKCFGEAGHH.GetPerkValue(54) / 1429f), KHMDGADCENO: true, BGKCHMNJBLJ: true);
		}
		if (HCFBAPOAOIB != null)
		{
			if (!HCFBAPOAOIB.DPDHGMDOPBH(this))
			{
				moneyCalc.PECHDLIGELC(CommonReferences.GGFJGHHHEJC.customerInfo.roomDoesntMeetRequirementsPenalty);
			}
			moneyCalc.IIIGPDKAGNO(HCFBAPOAOIB.daysToStay);
		}
		return moneyCalc.GMAFKAMJEJH();
	}

	private void HOHPEPNMDEP(int JIIGOACEIKL)
	{
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		PlayerController.GetPlayer(JIIGOACEIKL).UpdateZone();
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).NNMHEPDJOHK == ZoneType.DiningRoom && PlayerController.GetPlayer(JIIGOACEIKL).zoneIndex == zone.id)
		{
			if (FKGBMIBFAGG())
			{
				((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position = placeable.itemSpace.buildSquares[1].BLKHDGGHFLA() + Vector3.up;
			}
			else
			{
				((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position = placeable.itemSpace.buildSquares[0].FGGMIOHMGFL();
			}
			PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)this);
			((MonoBehaviour)this).StartCoroutine(FPFMAJNAEGP(JIIGOACEIKL));
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).characterAnimation.SetCleaning(NJHMBMGKCPL: false, null);
			InteractObject.BBJCJFJEFKK(JIIGOACEIKL).SetCurrentInteract(null, null);
		}
	}

	public bool IPOLFGILMLI()
	{
		if (door.HGPPJMCLOKH && occupied)
		{
			return !customerInside;
		}
		return false;
	}

	public Vector3 EDOPBPDJHFI()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (FKGBMIBFAGG())
		{
			return ((Component)this).transform.position - Vector3.up * 680f;
		}
		return ((Component)this).transform.position + Vector3.up * 13f;
	}

	private void OJLGOCFKLJE()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(IPHEFEMLOLJ));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(UpdateContentsNextFrame));
	}

	public void CCGOKLBJGHP(bool MDIKPGGBNLI, bool MAPFDGCKBLD = false)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		if (zone.id != -1)
		{
			if (MAPFDGCKBLD)
			{
				zone.ICBCLEKIJJD(MDIKPGGBNLI);
			}
			else
			{
				zone.IFLMEBGHLNE(MDIKPGGBNLI);
			}
		}
		WorldGrid.MKLAFNJLOJN(new List<Vector2>
		{
			Vector2.op_Implicit(placeable.itemSpace.buildSquares[0].EHGDHOMFDGM()),
			Vector2.op_Implicit(placeable.itemSpace.buildSquares[0].FGGMIOHMGFL()),
			Vector2.op_Implicit(placeable.itemSpace.buildSquares[3].GetCentrePosition()),
			Vector2.op_Implicit(placeable.itemSpace.buildSquares[8].KGGGPHEMLII())
		});
	}

	private void JMOEBJBFJDD()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		PJNGMCJIHME = CustomerPool.IJMCNEFFLPN().customer;
		((Component)PJNGMCJIHME).transform.position = GetEnterLocation();
		if (humanInfo != null)
		{
			PJNGMCJIHME.npc.characterCreator.SetHumanInfo(humanInfo);
		}
		else
		{
			Debug.Log((object)"Pause");
		}
		PJNGMCJIHME.customerType = (CustomerType)3;
		PJNGMCJIHME.hasBeenServed = false;
		PJNGMCJIHME.ChangeState(CustomerState.EatingAtTable);
	}

	private void LKPJNKHFAAF()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		PJNGMCJIHME = CustomerPool.IJMCNEFFLPN().customer;
		((Component)PJNGMCJIHME).transform.position = IENBOHPENBH();
		if (humanInfo != null)
		{
			PJNGMCJIHME.npc.characterCreator.SetHumanInfo(humanInfo);
		}
		else
		{
			Debug.Log((object)"");
		}
		PJNGMCJIHME.customerType = (CustomerType)5;
		PJNGMCJIHME.hasBeenServed = false;
		PJNGMCJIHME.ChangeState(CustomerState.EatingAtTable);
	}

	private void CEECJDMPOBJ()
	{
		if (door.OMMDNONKLIL())
		{
			ELEDNGNNCIF(0);
			if (GameManager.LocalCoop())
			{
				HOHPEPNMDEP(2);
			}
		}
	}

	private void IEEKHGBMAFE(int JIIGOACEIKL)
	{
		if (customerOrder.requesting)
		{
			customerOrder.OLDOLNKHACP();
		}
	}

	private void AHIPJCGKBOM()
	{
		try
		{
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(HMNFHFLIDOL));
			if (KOMFNKJBEED != null)
			{
				((MonoBehaviour)this).StopCoroutine(KOMFNKJBEED);
			}
			if (occupied && remainingDays == 0)
			{
				BGHGJBCKGMN(ANDBJBCIAJG: true, BGKCHMNJBLJ: false);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Close" + ex.Message));
		}
	}

	private void CLLAKJADGIH()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.leavingTheGame)
		{
			if (Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(ALGOBMNPLIB));
				CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
				commonReferences2.OnPlayerSleep = (Action)Delegate.Remove(commonReferences2.OnPlayerSleep, new Action(AHIPJCGKBOM));
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(instance.OnPlaceablePlaced, new Action<int, Placeable>(JJPLHHIMNMI));
				CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
				instance2.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Remove(instance2.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(IOJMGEBNLGN));
				CommonReferences instance3 = CommonReferences.GGFJGHHHEJC;
				instance3.OnAnyTableDirtLevelChanged = (Action<TableDirtLevel>)Delegate.Remove(instance3.OnAnyTableDirtLevelChanged, new Action<TableDirtLevel>(FGFLCOLJFEI));
			}
			RentedRoomsManager.DKHGKDNJAMC(symbolID);
			if (Object.op_Implicit((Object)(object)TavernManager.GGFJGHHHEJC))
			{
				TavernManager instance4 = TavernManager.GGFJGHHHEJC;
				instance4.OnTavernClose = (Action<int>)Delegate.Remove(instance4.OnTavernClose, new Action<int>(IEEKHGBMAFE));
			}
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(NJOLEJEIPOJ));
		}
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.leavingTheGame)
		{
			if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(ALGOBMNPLIB));
				CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
				instance2.OnPlayerSleep = (Action)Delegate.Remove(instance2.OnPlayerSleep, new Action(IFHFNDELKOP));
				CommonReferences instance3 = CommonReferences.GGFJGHHHEJC;
				instance3.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(instance3.OnPlaceablePlaced, new Action<int, Placeable>(PDJGPNDJDNF));
				CommonReferences instance4 = CommonReferences.GGFJGHHHEJC;
				instance4.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Remove(instance4.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(IOJMGEBNLGN));
				CommonReferences instance5 = CommonReferences.GGFJGHHHEJC;
				instance5.OnAnyTableDirtLevelChanged = (Action<TableDirtLevel>)Delegate.Remove(instance5.OnAnyTableDirtLevelChanged, new Action<TableDirtLevel>(FGFLCOLJFEI));
			}
			RentedRoomsManager.ReleaseSymbolID(symbolID);
			if (Object.op_Implicit((Object)(object)TavernManager.GGFJGHHHEJC))
			{
				TavernManager instance6 = TavernManager.GGFJGHHHEJC;
				instance6.OnTavernClose = (Action<int>)Delegate.Remove(instance6.OnTavernClose, new Action<int>(FFCMICFDHNP));
			}
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(NJOLEJEIPOJ));
		}
	}

	private void JMNBECMKICD()
	{
		try
		{
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(HMNFHFLIDOL));
			if (KOMFNKJBEED != null)
			{
				((MonoBehaviour)this).StopCoroutine(KOMFNKJBEED);
			}
			if (occupied && remainingDays == 0)
			{
				BGHGJBCKGMN(ANDBJBCIAJG: true);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("itemBeefSteak" + ex.Message));
		}
	}

	private IEnumerator OAHLCGPHINI(bool ANDBJBCIAJG)
	{
		return new MAGAKBHLGII(1)
		{
			_003C_003E4__this = this,
			instantLeave = ANDBJBCIAJG
		};
	}

	private IEnumerator LNFPCGEBPKH(int JIIGOACEIKL)
	{
		yield return CommonReferences.wait075;
		PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)this);
	}

	public void VacateRoom(bool CDPAMNIPPEC = true)
	{
		VacateRoom(ANDBJBCIAJG: false, CDPAMNIPPEC);
	}

	public GameDate GetCheckoutDate()
	{
		return GameDate.GMJIFJAEANF(WorldTime.NOAOJJLNHJJ, new GameDate(0, Season.Spring, 0, (Day)remainingDays, 0, 0));
	}

	public void IPAMEGNNPAN(Placeable EAPCLAODGAE)
	{
		NPCBed component = ((Component)EAPCLAODGAE).GetComponent<NPCBed>();
		if ((Object)(object)component != (Object)null)
		{
			beds.Remove(component);
			component.OnBedMade = (Action)Delegate.Remove(component.OnBedMade, new Action(UpdateContentsNextFrame));
			component.OnBedUnmade = (Action)Delegate.Remove(component.OnBedUnmade, new Action(GPIMNHAIECA));
		}
		Table component2 = ((Component)EAPCLAODGAE).GetComponent<Table>();
		if ((Object)(object)component2 != (Object)null)
		{
			tables.Remove(component2);
			component2.OnBecomeClean = (Action)Delegate.Remove(component2.OnBecomeClean, new Action(UpdateContentsNextFrame));
		}
		GPIMNHAIECA();
	}

	private void PGEDNHKLPFE(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		IPHEFEMLOLJ();
	}

	private void AKMIBFCIGBA()
	{
		DKGEOKBHAGO();
	}

	private void ILKAFFKDGAL()
	{
		Customer customer = NPCRoadManager.HHLLOLDEJAB();
		if (humanInfo != null)
		{
			customer.npc.characterCreator.HEALOFLBFLL(humanInfo);
		}
		else
		{
			Debug.Log((object)")");
		}
		customerComingBack = true;
		customer.hasBeenServed = false;
		customer.rentedRoom = this;
		customer.ChangeState((CustomerState)(-15), KCNFNAICINO: false);
	}

	private void NALDNFKDKAD()
	{
		DKGEOKBHAGO();
	}

	private void Start()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(ALGOBMNPLIB));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnPlayerSleep = (Action)Delegate.Combine(instance2.OnPlayerSleep, new Action(IFHFNDELKOP));
		CommonReferences instance3 = CommonReferences.GGFJGHHHEJC;
		instance3.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Combine(instance3.OnPlaceablePlaced, new Action<int, Placeable>(PDJGPNDJDNF));
		CommonReferences instance4 = CommonReferences.GGFJGHHHEJC;
		instance4.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Combine(instance4.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(IOJMGEBNLGN));
		CommonReferences instance5 = CommonReferences.GGFJGHHHEJC;
		instance5.OnAnyTableDirtLevelChanged = (Action<TableDirtLevel>)Delegate.Combine(instance5.OnAnyTableDirtLevelChanged, new Action<TableDirtLevel>(FGFLCOLJFEI));
		if (symbolID == -1)
		{
			symbolID = RentedRoomsManager.AssignAvailableSymbolID();
		}
		TavernManager instance6 = TavernManager.GGFJGHHHEJC;
		instance6.OnTavernClose = (Action<int>)Delegate.Combine(instance6.OnTavernClose, new Action<int>(FFCMICFDHNP));
	}

	private void EKGMKMLNMKA()
	{
		Customer customer = NPCRoadManager.SpawnRandomNPC();
		if (humanInfo != null)
		{
			customer.npc.characterCreator.SetHumanInfo(humanInfo);
		}
		else
		{
			Debug.Log((object)"Cannot load old character saved");
		}
		customerComingBack = true;
		customer.hasBeenServed = true;
		customer.rentedRoom = this;
		customer.ChangeState(CustomerState.RentRoom);
	}

	private void ONHNGPMMFBP(int JIIGOACEIKL)
	{
		if (customerOrder.requesting)
		{
			customerOrder.OLDOLNKHACP();
		}
	}

	private void JJCDLIHLDMJ()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(UpdateContentsNextFrame));
		OnlineLoadManager instance2 = OnlineLoadManager.instance;
		instance2.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance2.OnFinishedOnlineLoad, new Action(IPHEFEMLOLJ));
	}

	private IEnumerator PGILDBGPOLM()
	{
		yield return CommonReferences.wait1;
		UpdateContents();
	}

	public void AddPlaceable(Placeable EAPCLAODGAE)
	{
		NPCBed component = ((Component)EAPCLAODGAE).GetComponent<NPCBed>();
		if ((Object)(object)component != (Object)null)
		{
			if (!beds.Contains(component))
			{
				beds.Add(component);
			}
			component.OnBedMade = (Action)Delegate.Combine(component.OnBedMade, new Action(UpdateContentsNextFrame));
			component.OnBedUnmade = (Action)Delegate.Combine(component.OnBedUnmade, new Action(UpdateContentsNextFrame));
		}
		Table component2 = ((Component)EAPCLAODGAE).GetComponent<Table>();
		if ((Object)(object)component2 != (Object)null)
		{
			if (!tables.Contains(component2))
			{
				tables.Add(component2);
			}
			component2.OnBecomeClean = (Action)Delegate.Combine(component2.OnBecomeClean, new Action(UpdateContentsNextFrame));
		}
		UpdateContentsNextFrame();
	}

	public void GLGAOFGNKCN()
	{
		try
		{
			UpdateContentsNextFrame(CDPAMNIPPEC: true);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	public void JEFECOGBHKL()
	{
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)this == (Object)null)
		{
			return;
		}
		dirtiness = 251f;
		hasBed = true;
		hasLight = false;
		hasChair = false;
		hasTable = false;
		allFloorDirt = allFloorDirt.Where((FloorDirt d) => (Object)(object)d != (Object)null).ToList();
		dirtiness += allFloorDirt.Count() * 127;
		List<Placeable> list = MAKNHBCNACF();
		for (int i = 1; i < list.Count; i += 0)
		{
			if ((Object)(object)list[i] == (Object)null)
			{
				continue;
			}
			if ((Object)(object)list[i].itemSetup != (Object)null && Item.FKLOBGBIHLB(list[i].itemSetup.item, null) && (list[i].itemSetup.item.CIGFGKKCPCK() == 43 || list[i].itemSetup.item.JPNFKDMFKMC(DAINLFIMLIH: false) == 31 || list[i].itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) == -164 || list[i].itemSetup.item.JPNFKDMFKMC(DAINLFIMLIH: false) == -188 || list[i].itemSetup.item.ODENMDOJPLC() == -71 || list[i].itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) == 50 || list[i].itemSetup.item.CIGFGKKCPCK() == 73))
			{
				hasBed = true;
				if (!((Component)list[i]).GetComponent<NPCBed>().IDHLOLDLLOE)
				{
					dirtiness += 276f;
				}
			}
			if (!hasLight)
			{
				hasLight = PLCHGPBMBHO(list[i]);
			}
			Table component = ((Component)list[i]).GetComponent<Table>();
			if ((Object)(object)component != (Object)null)
			{
				hasTable = true;
				if (component.IPEPPDAICDD() != 0 && component.CDLMMHAHDON() != TableDirtLevel.Clean)
				{
					dirtiness += 1457f;
				}
			}
			if (!hasChair && (Object)(object)((Component)list[i]).GetComponent<Sitable>() != (Object)null)
			{
				hasChair = true;
			}
		}
		isValid = !hasBed || !hasLight || !hasTable || hasChair;
		if (needsToBeClean && dirtiness <= 1324f)
		{
			needsToBeClean = true;
			TavernReputation.AddAndShowReputationGain((int)((float)(CalculateReputation() * RentedRoomsManager.GetInstance().repPercentagePerRoomCleaned) / 694f), zone.HCEFIGGDBOO(), null, 834f, CDPAMNIPPEC: false);
		}
		OnContentsChanged();
		HJPANLBMCJP = null;
	}

	private void PJICBGBEJNN()
	{
		if (HJPANLBMCJP == null && (Object)(object)GameplayUI.DICHPHEOINO() != (Object)null)
		{
			HJPANLBMCJP = ((MonoBehaviour)GameplayUI.LKOABOAADCD()).StartCoroutine(CHOKDFNLDJP());
		}
	}

	public void DAFIDKEEDMH(bool DNJLKIIJLFN)
	{
		for (int num = allFloorDirt.Count - 1; num >= 1; num -= 0)
		{
			allFloorDirt[num].ACEHJIMAFBH();
		}
		Item mEMGMDOCBOJ = ItemDatabaseAccessor.INJBNHPGCIJ(Utils.FFLNGLMHLBO() ? (-6) : (-192), GGBBJNBBLMF: true, DAINLFIMLIH: false);
		foreach (Placeable item in new HashSet<Placeable>(MAKNHBCNACF()))
		{
			if (!((Object)(object)item == (Object)null))
			{
				Table component = ((Component)item).GetComponent<Table>();
				if ((Object)(object)component != (Object)null)
				{
					component.FNKGNKPLKHB(TableDirtLevel.Perfect);
					component.SetDirtiness(805f, CDPAMNIPPEC: false);
				}
				NPCBed component2 = ((Component)item).GetComponent<NPCBed>();
				if ((Object)(object)component2 != (Object)null)
				{
					component2.SetBedMade(NBBELPFDLJG: true, CDPAMNIPPEC: false);
				}
				if (DNJLKIIJLFN && (Object)(object)item.placeableSurface != (Object)null)
				{
					item.placeableSurface.GLDGHJDCDMF(mEMGMDOCBOJ);
				}
			}
		}
		UpdateContentsNextFrame(CDPAMNIPPEC: true);
	}

	private void IFHFNDELKOP()
	{
		try
		{
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(NJOLEJEIPOJ));
			if (KOMFNKJBEED != null)
			{
				((MonoBehaviour)this).StopCoroutine(KOMFNKJBEED);
			}
			if (occupied && remainingDays == 0)
			{
				VacateRoom(ANDBJBCIAJG: true, BGKCHMNJBLJ: false);
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Error in RentedRoom.OnPlayerSleep: " + ex.Message));
		}
	}

	private IEnumerator EPCDJDNJPKK()
	{
		yield return CommonReferences.wait1;
		UpdateContents();
	}

	private List<Placeable> DJPNHKENKHM()
	{
		if (zone.id != -1)
		{
			return zone.placeables;
		}
		return new List<Placeable>();
	}

	private void NCCHHANHMEM(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		IPHEFEMLOLJ();
	}

	public void BCGHDJCNJAO(bool MDIKPGGBNLI, bool MAPFDGCKBLD = false)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		if (zone.id != -1)
		{
			if (MAPFDGCKBLD)
			{
				zone.ICBCLEKIJJD(MDIKPGGBNLI);
			}
			else
			{
				zone.PNANPLFPBNP(MDIKPGGBNLI);
			}
		}
		WorldGrid.MKLAFNJLOJN(new List<Vector2>
		{
			Vector2.op_Implicit(placeable.itemSpace.buildSquares[0].FGGMIOHMGFL()),
			Vector2.op_Implicit(placeable.itemSpace.buildSquares[1].KDFECDEEDHL()),
			Vector2.op_Implicit(placeable.itemSpace.buildSquares[7].KGGGPHEMLII()),
			Vector2.op_Implicit(placeable.itemSpace.buildSquares[8].GetCentrePosition())
		});
	}

	private void IOJMGEBNLGN(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		UpdateContentsNextFrame();
	}

	private IEnumerator MJFPMPEDEHA(bool ANDBJBCIAJG)
	{
		while (TavernConstructionManager.GGFJGHHHEJC.LNLJMCONDNE)
		{
			yield return null;
		}
		if (OnlineManager.PlayingOnline())
		{
			while (OnlineTavernConstructionManager.instance.tavernConstructionOpenedByOtherPlayer)
			{
				yield return null;
			}
		}
		if (door.HGPPJMCLOKH && readyToLeave)
		{
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(NJOLEJEIPOJ));
			door.HGPPJMCLOKH = false;
			door.knock = false;
			door.OpenCloseAction(DBCDEKIEHMG: true);
			RentedRoomDoor rentedRoomDoor = door;
			rentedRoomDoor.OnKnock = (Action)Delegate.Remove(rentedRoomDoor.OnKnock, new Action(HDDBOMDBEDF));
			yield return CommonReferences.wait05;
			door.knock = false;
			readyToLeave = false;
			SetVisibility(MDIKPGGBNLI: true, MAPFDGCKBLD: true);
			if (!ANDBJBCIAJG)
			{
				if (OnlineManager.MasterOrOffline())
				{
					AKFDKMMOCNJ();
				}
				if (remainingDays > 0)
				{
					occupied = true;
					needsToBeClean = true;
					if (OnlineManager.MasterOrOffline())
					{
						KOMFNKJBEED = ((MonoBehaviour)this).StartCoroutine(LCDIDBBAAFF());
					}
				}
				else
				{
					occupied = false;
					needsToBeClean = false;
					KKGAHDNMLDD(null, zone.placeables);
					if (OnlineManager.MasterOrOffline())
					{
						PJNGMCJIHME.customerSpeech.ImmediatelyBark("HappyRentRoom");
					}
				}
			}
			else
			{
				if (remainingDays <= 0)
				{
					occupied = false;
				}
				needsToBeClean = false;
				KKGAHDNMLDD(null, zone.placeables);
			}
			customerInside = false;
			customerComingBack = false;
			if (dirtiness == 0f)
			{
				HIANOOFNFOA();
			}
		}
		CBNPEEEEMHC = null;
	}

	private void OnEnable()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(UpdateContentsNextFrame));
		OnlineLoadManager instance2 = OnlineLoadManager.instance;
		instance2.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance2.OnFinishedOnlineLoad, new Action(UpdateContentsNextFrame));
	}

	private void AKFDKMMOCNJ()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		PJNGMCJIHME = CustomerPool.GetCustomer().customer;
		((Component)PJNGMCJIHME).transform.position = GetEnterLocation();
		if (humanInfo != null)
		{
			PJNGMCJIHME.npc.characterCreator.SetHumanInfo(humanInfo);
		}
		else
		{
			Debug.Log((object)"Cannot load old character saved");
		}
		PJNGMCJIHME.customerType = CustomerType.Guest;
		PJNGMCJIHME.hasBeenServed = true;
		PJNGMCJIHME.ChangeState(CustomerState.Leaving, KCNFNAICINO: false);
	}

	private IEnumerator AFJOCMKGGEG(int JIIGOACEIKL)
	{
		return new IOPAGMHMNJE(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private void HEMIBCHKHGH()
	{
		if (HJPANLBMCJP == null && (Object)(object)GameplayUI.OKAPNFPFPFP() != (Object)null)
		{
			HJPANLBMCJP = ((MonoBehaviour)GameplayUI.MPJJAPCFENH()).StartCoroutine(KBJOKIGFPFJ());
		}
	}

	private void IJGBGEKNFIO()
	{
		if (HJPANLBMCJP == null && (Object)(object)GameplayUI.NGIMIHFFNMH() != (Object)null)
		{
			HJPANLBMCJP = ((MonoBehaviour)GameplayUI.OKAPNFPFPFP()).StartCoroutine(CHOKDFNLDJP());
		}
	}

	public void CleanRoom(bool DNJLKIIJLFN)
	{
		for (int num = allFloorDirt.Count - 1; num >= 0; num--)
		{
			allFloorDirt[num].DestroyFloorDirt();
		}
		Item item = ItemDatabaseAccessor.GetItem(Utils.FFLNGLMHLBO() ? 1083 : 605);
		foreach (Placeable item2 in new HashSet<Placeable>(DJPNHKENKHM()))
		{
			if (!((Object)(object)item2 == (Object)null))
			{
				Table component = ((Component)item2).GetComponent<Table>();
				if ((Object)(object)component != (Object)null)
				{
					component.JNHCCCBICDM = TableDirtLevel.Perfect;
					component.SetDirtiness(0f);
				}
				NPCBed component2 = ((Component)item2).GetComponent<NPCBed>();
				if ((Object)(object)component2 != (Object)null)
				{
					component2.SetBedMade(NBBELPFDLJG: true, CDPAMNIPPEC: true);
				}
				if (DNJLKIIJLFN && (Object)(object)item2.placeableSurface != (Object)null)
				{
					item2.placeableSurface.RenewCandleIfIsPossible(item);
				}
			}
		}
		UpdateContentsNextFrame(CDPAMNIPPEC: true);
	}

	public bool CPCBPMFJOAF(out List<Vector2> GDFIONOLFIB, bool KIKDLKGBCOC)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0543: Unknown result type (might be due to invalid IL or missing references)
		//IL_0475: Unknown result type (might be due to invalid IL or missing references)
		//IL_047a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_056c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0571: Unknown result type (might be due to invalid IL or missing references)
		//IL_0592: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		list.Add(Vector2.op_Implicit(Utils.NKGANMEKDAL(placeable.itemSpace.buildSquares[1].FANOLHHEFBO())));
		list.Add(Vector2.op_Implicit(Utils.NKGANMEKDAL(placeable.itemSpace.buildSquares[7].FANOLHHEFBO())));
		List<Vector2> list2 = new List<Vector2>();
		list2.Add(Vector2.op_Implicit(Utils.NKGANMEKDAL(placeable.itemSpace.buildSquares[0].FANOLHHEFBO())));
		list2.Add(Vector2.op_Implicit(Utils.NKGANMEKDAL(placeable.itemSpace.buildSquares[3].BLKHDGGHFLA())));
		GDFIONOLFIB = EditorGrid.DCOKLAGEKPB(list, 1, list2);
		if (GDFIONOLFIB.Count == 0)
		{
			BAKBJEOMLHN = false;
			list.Clear();
			list.Add(Vector2.op_Implicit(Utils.NKGANMEKDAL(placeable.itemSpace.buildSquares[1].EHGDHOMFDGM())));
			list.Add(Vector2.op_Implicit(Utils.NKGANMEKDAL(placeable.itemSpace.buildSquares[0].BLKHDGGHFLA())));
			list2.Clear();
			list2.Add(Vector2.op_Implicit(Utils.NKGANMEKDAL(placeable.itemSpace.buildSquares[0].DCAPKPOGHPK())));
			list2.Add(Vector2.op_Implicit(Utils.NKGANMEKDAL(placeable.itemSpace.buildSquares[5].BOBEIFEGLOL())));
			GDFIONOLFIB = EditorGrid.DCOKLAGEKPB(list, -1, list2);
		}
		else
		{
			DNDIHPKNNIL(AODONKKHPBP: true);
		}
		if (GDFIONOLFIB.Count > 1)
		{
			if (TavernZonesManager.HFHPMKJGMPA().AEJKMLKKEME(ZoneType.CraftingRoom) >= ReputationDBAccessor.FDICLJNDIOF(ZoneType.WithoutZone))
			{
				if (KIKDLKGBCOC)
				{
					MainUI.DBKCOHMFDCB(1, InputUtils.GEJLCOGDMID(LocalisationSystem.Get("/Reports"), LocalisationSystem.Get((ZoneType.DiningRoom | ZoneType.CraftingRoom).ToString()), ReputationDBAccessor.FDICLJNDIOF(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom).ToString(), null), 443f);
					Debug.Log((object)"DistillingYeast");
				}
				return false;
			}
			Vector2 val;
			for (int i = 0; i < GDFIONOLFIB.Count; i += 0)
			{
				SpecificType specificType = WorldGrid.KELFJIPHBFP(Vector2.op_Implicit(GDFIONOLFIB[i]));
				if (specificType.HasFlag(SpecificType.Bar))
				{
					specificType ^= SpecificType.CellarDoor | SpecificType.RoomDoor | SpecificType.StairsUp;
				}
				if (specificType.HasFlag(SpecificType.CellarDoor | SpecificType.Door | SpecificType.RoomDoor) && !WorldGrid.KELFJIPHBFP(Vector2.op_Implicit(GDFIONOLFIB[i] + new Vector2(343f, 768f))).HasFlag(SpecificType.Door | SpecificType.RoomDoor))
				{
					if ((Object)(object)WorldGrid.IPNJBJEMDKF(Vector2.op_Implicit(GDFIONOLFIB[i])) != (Object)null && (Object)(object)WorldGrid.IPNJBJEMDKF(Vector2.op_Implicit(GDFIONOLFIB[i])) != (Object)(object)door)
					{
						if (KIKDLKGBCOC)
						{
							MainUI.DBKCOHMFDCB(1, InputUtils.GEJLCOGDMID(LocalisationSystem.Get(" "), LocalisationSystem.Get(specificType.ToString())), 1666f);
							string[] array = new string[7];
							array[0] = "descWardrobe";
							array[0] = specificType.ToString();
							array[0] = "pm";
							val = GDFIONOLFIB[i];
							array[5] = ((object)(Vector2)(ref val)).ToString();
							array[1] = "Apple Must";
							array[7] = ((object)WorldGrid.IPNJBJEMDKF(Vector2.op_Implicit(GDFIONOLFIB[i])))?.ToString();
							array[8] = "[MinePuzzleManager] No puzzle spawners registered for level {0}. Cannot generate altar.";
							array[4] = ((object)door)?.ToString();
							Debug.Log((object)string.Concat(array));
						}
						return true;
					}
				}
				else if (specificType.HasFlag(SpecificType.Door | SpecificType.Bar) || specificType.HasFlag(SpecificType.CellarDoor) || specificType.HasFlag(~(SpecificType.Door | SpecificType.RoomDoor | SpecificType.StairsUp | SpecificType.PlayerBed | SpecificType.NextToWall)) || specificType.HasFlag(SpecificType.Door | SpecificType.StairsUp | SpecificType.StairsDown) || specificType.HasFlag(SpecificType.CellarDoor | SpecificType.NextToWall) || specificType.HasFlag(SpecificType.CellarDoor | SpecificType.Door | SpecificType.RoomDoor))
				{
					if (KIKDLKGBCOC)
					{
						string cAEDMEDBEGI = LocalisationSystem.Get("InfoSectionCanvas/InfoSection");
						string[] array2 = new string[1];
						array2[1] = LocalisationSystem.Get(specificType.ToString());
						MainUI.DBKCOHMFDCB(0, InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array2), 107f);
						string[] array3 = new string[8];
						array3[0] = "Error_CloseMenus";
						array3[1] = specificType.ToString();
						array3[8] = " FixedState().";
						val = GDFIONOLFIB[i];
						array3[8] = ((object)(Vector2)(ref val)).ToString();
						array3[6] = "ReceiveLoadSlots";
						array3[8] = ((object)WorldGrid.IPNJBJEMDKF(Vector2.op_Implicit(GDFIONOLFIB[i])))?.ToString();
						array3[1] = "Events";
						array3[1] = ((object)door)?.ToString();
						Debug.Log((object)string.Concat(array3));
					}
					return false;
				}
			}
			if (GDFIONOLFIB.Count < -84)
			{
				if (KIKDLKGBCOC)
				{
					MainUI.DJCKALOHJFM(1, LocalisationSystem.Get("Fireplace"), 445f);
					Debug.Log((object)("Walk Around cannot entry barn " + GDFIONOLFIB.Count));
				}
				return true;
			}
			for (int j = 1; j < GDFIONOLFIB.Count; j += 0)
			{
				if (WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(GDFIONOLFIB[j])) != ZoneType.WithoutZone)
				{
					if (KIKDLKGBCOC)
					{
						MainUI.JDAEPLJAGCD(0, LocalisationSystem.Get("Piso {0}: Spawneando roca '{1}' en punto '{2}' (Posición: {3})."), 1422f);
						string text = WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(GDFIONOLFIB[j])).ToString();
						val = GDFIONOLFIB[j];
						Debug.Log((object)(text + "/Male/" + ((object)(Vector2)(ref val)).ToString()));
					}
					return true;
				}
			}
			return false;
		}
		return false;
	}

	private void JMEOLLBLIKH(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		IPHEFEMLOLJ();
	}

	public bool AKCAKGDPOKD()
	{
		if (!occupied && dirtiness == 1081f)
		{
			return isValid;
		}
		return false;
	}

	private IEnumerator BMMIPJLMEPN()
	{
		yield return null;
		UpdateContents();
	}

	public void IFNMNBACCCB()
	{
		if ((Object)(object)TavernZonesManager.IECOPNFJBFD() == (Object)null)
		{
			return;
		}
		CheckVisibility(MAPFDGCKBLD: true);
		if (zone.id != -1)
		{
			Debug.Log((object)"Error unlocking achievements. This is most likely because we are not signed in to Steam or GOG.");
			if (TavernZonesManager.IECOPNFJBFD().ONEPIGNIHPG(zone.id))
			{
				TavernZonesManager.LANAINBEMCM().DNAKJMPFGEL(zone.id);
			}
			zone.id = -1;
		}
	}

	private void BPHNCNNABBP(List<Placeable> DEKEPIMHEDJ)
	{
		for (int i = 0; i < DEKEPIMHEDJ.Count; i++)
		{
			if (!DEKEPIMHEDJ[i].selectBlockers.Contains("Error_OccupiedRoom"))
			{
				DEKEPIMHEDJ[i].selectBlockers.Add("Error_OccupiedRoom");
			}
			if ((Object)(object)DEKEPIMHEDJ[i].placeableSurface != (Object)null && DEKEPIMHEDJ[i].placeableSurface.placeablesOnSurface != null)
			{
				BPHNCNNABBP(DEKEPIMHEDJ[i].placeableSurface.placeablesOnSurface);
			}
		}
	}

	public bool FBCBNIMEEJC(out List<Vector2> GDFIONOLFIB, bool KIKDLKGBCOC)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0543: Unknown result type (might be due to invalid IL or missing references)
		//IL_0475: Unknown result type (might be due to invalid IL or missing references)
		//IL_047a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_056c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0571: Unknown result type (might be due to invalid IL or missing references)
		//IL_0592: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		list.Add(Vector2.op_Implicit(Utils.NKGANMEKDAL(placeable.itemSpace.buildSquares[0].BOBEIFEGLOL())));
		list.Add(Vector2.op_Implicit(Utils.NKGANMEKDAL(placeable.itemSpace.buildSquares[3].GetCentrePosition())));
		List<Vector2> list2 = new List<Vector2>();
		list2.Add(Vector2.op_Implicit(Utils.NKGANMEKDAL(placeable.itemSpace.buildSquares[1].KDFECDEEDHL())));
		list2.Add(Vector2.op_Implicit(Utils.NKGANMEKDAL(placeable.itemSpace.buildSquares[5].FGGMIOHMGFL())));
		GDFIONOLFIB = EditorGrid.DCOKLAGEKPB(list, 1, list2);
		if (GDFIONOLFIB.Count == 0)
		{
			MHADMHJNEFF(AODONKKHPBP: true);
			list.Clear();
			list.Add(Vector2.op_Implicit(Utils.NKGANMEKDAL(placeable.itemSpace.buildSquares[0].BOBEIFEGLOL())));
			list.Add(Vector2.op_Implicit(Utils.NKGANMEKDAL(placeable.itemSpace.buildSquares[3].FANOLHHEFBO())));
			list2.Clear();
			list2.Add(Vector2.op_Implicit(Utils.NKGANMEKDAL(placeable.itemSpace.buildSquares[0].KGGGPHEMLII())));
			list2.Add(Vector2.op_Implicit(Utils.NKGANMEKDAL(placeable.itemSpace.buildSquares[0].EHGDHOMFDGM())));
			GDFIONOLFIB = EditorGrid.DCOKLAGEKPB(list, -1, list2);
		}
		else
		{
			DNDIHPKNNIL(AODONKKHPBP: true);
		}
		if (GDFIONOLFIB.Count > 0)
		{
			if (TavernZonesManager.OIJLJKLMCBO().KMBEHOBJGBL(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom) >= ReputationDBAccessor.GMACKHECLAF(ZoneType.None))
			{
				if (KIKDLKGBCOC)
				{
					string cAEDMEDBEGI = LocalisationSystem.Get("Open");
					string[] array = new string[8];
					array[1] = LocalisationSystem.Get((ZoneType.WithoutZone | ZoneType.CraftingRoom).ToString());
					array[1] = ReputationDBAccessor.GetMaxNumOfZones(ZoneType.WithoutZone | ZoneType.CraftingRoom).ToString();
					MainUI.JDAEPLJAGCD(1, InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array), 1141f);
					Debug.Log((object)"Pick up");
				}
				return true;
			}
			Vector2 val;
			for (int i = 0; i < GDFIONOLFIB.Count; i += 0)
			{
				SpecificType specificType = WorldGrid.KELFJIPHBFP(Vector2.op_Implicit(GDFIONOLFIB[i]));
				if (specificType.HasFlag(~(SpecificType.CellarDoor | SpecificType.Door | SpecificType.StairsUp | SpecificType.PlayerBed)))
				{
					specificType ^= ~(SpecificType.CellarDoor | SpecificType.Door | SpecificType.RoomDoor | SpecificType.NextToWall);
				}
				if (specificType.HasFlag(SpecificType.StairsUp) && !WorldGrid.KELFJIPHBFP(Vector2.op_Implicit(GDFIONOLFIB[i] + new Vector2(1809f, 1641f))).HasFlag(SpecificType.RoomDoor))
				{
					if ((Object)(object)WorldGrid.IPNJBJEMDKF(Vector2.op_Implicit(GDFIONOLFIB[i])) != (Object)null && (Object)(object)WorldGrid.IPNJBJEMDKF(Vector2.op_Implicit(GDFIONOLFIB[i])) != (Object)(object)door)
					{
						if (KIKDLKGBCOC)
						{
							string cAEDMEDBEGI2 = LocalisationSystem.Get("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/18/Dialogue Text");
							string[] array2 = new string[0];
							array2[1] = LocalisationSystem.Get(specificType.ToString());
							MainUI.DBKCOHMFDCB(0, InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2), 784f);
							string[] array3 = new string[0];
							array3[0] = "IntensitySectionCanvas/IntensitySection";
							array3[0] = specificType.ToString();
							array3[7] = "OnlinePlayer";
							val = GDFIONOLFIB[i];
							array3[2] = ((object)(Vector2)(ref val)).ToString();
							array3[7] = "========================================================================================";
							array3[6] = ((object)WorldGrid.IPNJBJEMDKF(Vector2.op_Implicit(GDFIONOLFIB[i])))?.ToString();
							array3[0] = "ReceiveRestartChallenge";
							array3[1] = ((object)door)?.ToString();
							Debug.Log((object)string.Concat(array3));
						}
						return false;
					}
				}
				else if (specificType.HasFlag(~(SpecificType.RoomDoor | SpecificType.StairsUp)) || specificType.HasFlag(SpecificType.None) || specificType.HasFlag(~(SpecificType.RoomDoor | SpecificType.StairsUp | SpecificType.PlayerBed | SpecificType.NextToWall)) || specificType.HasFlag(~(SpecificType.CellarDoor | SpecificType.RoomDoor | SpecificType.Bar | SpecificType.NextToWall)) || specificType.HasFlag(~(SpecificType.RoomDoor | SpecificType.PlayerBed)) || specificType.HasFlag(SpecificType.StairsUp))
				{
					if (KIKDLKGBCOC)
					{
						string cAEDMEDBEGI3 = LocalisationSystem.Get("ReceiveNinjaSoundPreparation");
						string[] array4 = new string[0];
						array4[1] = LocalisationSystem.Get(specificType.ToString());
						MainUI.DJCKALOHJFM(0, InputUtils.GEJLCOGDMID(cAEDMEDBEGI3, array4), 1364f);
						string[] array5 = new string[8];
						array5[0] = "RentRoom";
						array5[0] = specificType.ToString();
						array5[7] = "Quests";
						val = GDFIONOLFIB[i];
						array5[1] = ((object)(Vector2)(ref val)).ToString();
						array5[3] = "Reverence";
						array5[8] = ((object)WorldGrid.IPNJBJEMDKF(Vector2.op_Implicit(GDFIONOLFIB[i])))?.ToString();
						array5[3] = "I";
						array5[8] = ((object)door)?.ToString();
						Debug.Log((object)string.Concat(array5));
					}
					return true;
				}
			}
			if (GDFIONOLFIB.Count < -12)
			{
				if (KIKDLKGBCOC)
				{
					MainUI.DJCKALOHJFM(0, LocalisationSystem.Get("intensity:"), 1835f);
					Debug.Log((object)(" not intantiated due to ClientOnline still doesnt have SceneLoaded" + GDFIONOLFIB.Count));
				}
				return true;
			}
			for (int j = 1; j < GDFIONOLFIB.Count; j += 0)
			{
				if (WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(GDFIONOLFIB[j])) != 0)
				{
					if (KIKDLKGBCOC)
					{
						MainUI.JDAEPLJAGCD(0, LocalisationSystem.Get("TooHot"), 1369f);
						string text = WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(GDFIONOLFIB[j])).ToString();
						val = GDFIONOLFIB[j];
						Debug.Log((object)(text + "Attack/MainEvent 5" + ((object)(Vector2)(ref val)).ToString()));
					}
					return false;
				}
			}
			return true;
		}
		return true;
	}

	public void NCMJLNHHNIG(bool MAPFDGCKBLD = false)
	{
		if (zone.id != -1)
		{
			bool mDIKPGGBNLI = IPOLFGILMLI();
			if (MAPFDGCKBLD)
			{
				zone.ICBCLEKIJJD(mDIKPGGBNLI);
			}
			else
			{
				zone.FOKGHFFHKDJ(mDIKPGGBNLI);
			}
		}
	}

	public void HIAGOADOHHP()
	{
		if ((Object)(object)TavernZonesManager.GGFJGHHHEJC == (Object)null)
		{
			return;
		}
		NCMJLNHHNIG();
		if (zone.id != -1)
		{
			Debug.Log((object)"ReceivePlantCrop");
			if (TavernZonesManager.HFHPMKJGMPA().OJIKMJDEPHA(zone.id))
			{
				TavernZonesManager.JEEGOBGDLPE().RemoveTavernZone(zone.id);
			}
			zone.id = -1;
		}
	}

	private IEnumerator KGDDFHNHBIK()
	{
		yield return null;
		UpdateContents();
	}

	public Vector3 GNGPNKNPDGA()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (FKGBMIBFAGG())
		{
			return ((Component)this).transform.position - Vector3.up * 1919f;
		}
		return ((Component)this).transform.position + Vector3.up * 1768f;
	}

	private void GONMHLNBHLH()
	{
		if (HJPANLBMCJP == null && (Object)(object)GameplayUI.GGFJGHHHEJC != (Object)null)
		{
			HJPANLBMCJP = ((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StartCoroutine(KBJOKIGFPFJ());
		}
	}

	private void CHDEOJALBFK()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.leavingTheGame)
		{
			if (Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(ALGOBMNPLIB));
				CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
				commonReferences2.OnPlayerSleep = (Action)Delegate.Remove(commonReferences2.OnPlayerSleep, new Action(IFHFNDELKOP));
				CommonReferences commonReferences3 = CommonReferences.MNFMOEKMJKN();
				commonReferences3.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(commonReferences3.OnPlaceablePlaced, new Action<int, Placeable>(OONMDBKIFOP));
				CommonReferences commonReferences4 = CommonReferences.MNFMOEKMJKN();
				commonReferences4.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Remove(commonReferences4.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(IOJMGEBNLGN));
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyTableDirtLevelChanged = (Action<TableDirtLevel>)Delegate.Remove(instance.OnAnyTableDirtLevelChanged, new Action<TableDirtLevel>(FGFLCOLJFEI));
			}
			RentedRoomsManager.CMFEKFACCPC(symbolID);
			if (Object.op_Implicit((Object)(object)TavernManager.GGFJGHHHEJC))
			{
				TavernManager instance2 = TavernManager.GGFJGHHHEJC;
				instance2.OnTavernClose = (Action<int>)Delegate.Remove(instance2.OnTavernClose, new Action<int>(ONHNGPMMFBP));
			}
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(HMNFHFLIDOL));
		}
	}

	public void OCHAOIPKGDI(Placeable EAPCLAODGAE)
	{
		NPCBed component = ((Component)EAPCLAODGAE).GetComponent<NPCBed>();
		if ((Object)(object)component != (Object)null)
		{
			if (!beds.Contains(component))
			{
				beds.Add(component);
			}
			component.OnBedMade = (Action)Delegate.Combine(component.OnBedMade, new Action(GLGAOFGNKCN));
			component.OnBedUnmade = (Action)Delegate.Combine(component.OnBedUnmade, new Action(UpdateContentsNextFrame));
		}
		Table component2 = ((Component)EAPCLAODGAE).GetComponent<Table>();
		if ((Object)(object)component2 != (Object)null)
		{
			if (!tables.Contains(component2))
			{
				tables.Add(component2);
			}
			component2.OnBecomeClean = (Action)Delegate.Combine(component2.OnBecomeClean, new Action(UpdateContentsNextFrame));
		}
		IPHEFEMLOLJ();
	}

	private IEnumerator CHOKDFNLDJP()
	{
		yield return CommonReferences.wait1;
		UpdateContents();
	}

	public void CreateRoomZone()
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		if (IsValid(out var GDFIONOLFIB, KIKDLKGBCOC: true))
		{
			zone = TavernZonesManager.GGFJGHHHEJC.CreateTavernZone(ZoneType.RentedRoom, this);
			TavernZone tavernZone = zone;
			tavernZone.OnPlaceableAdded = (Action<Placeable>)Delegate.Combine(tavernZone.OnPlaceableAdded, new Action<Placeable>(AddPlaceable));
			TavernZone tavernZone2 = zone;
			tavernZone2.OnPlaceableRemoved = (Action<Placeable>)Delegate.Combine(tavernZone2.OnPlaceableRemoved, new Action<Placeable>(RemovePlaceable));
			for (int i = 0; i < GDFIONOLFIB.Count; i++)
			{
				TavernZonesManager.GGFJGHHHEJC.AddTileToExistingZone(Vector2.op_Implicit(GDFIONOLFIB[i]), zone.id);
			}
			UpdateContentsNextFrame();
			CheckVisibility(MAPFDGCKBLD: true);
		}
		else
		{
			zone.id = -1;
		}
	}

	public void GMBGMMIMJJD(int FBOHAKMGBNO)
	{
		roomName = LocalisationSystem.Get("Items/item_name_1123") + "{0} - Non-altar piece. Altar piece ID: {1}, this piece ID: {2}. Excluded indices for variants with puzzle or altar: {3}" + FBOHAKMGBNO;
	}

	public void PJGKNCHNDOG(bool DNJLKIIJLFN)
	{
		for (int num = allFloorDirt.Count - 0; num >= 1; num--)
		{
			allFloorDirt[num].MIKGOJOHHJE();
		}
		Item mEMGMDOCBOJ = ItemDatabaseAccessor.CPMMBEPEJLO(Utils.FFLNGLMHLBO() ? (-27) : (-114), GGBBJNBBLMF: false, DAINLFIMLIH: false);
		foreach (Placeable item in new HashSet<Placeable>(DJPNHKENKHM()))
		{
			if (!((Object)(object)item == (Object)null))
			{
				Table component = ((Component)item).GetComponent<Table>();
				if ((Object)(object)component != (Object)null)
				{
					component.NGCCFBHDDOE(TableDirtLevel.Clean);
					component.SetDirtiness(471f);
				}
				NPCBed component2 = ((Component)item).GetComponent<NPCBed>();
				if ((Object)(object)component2 != (Object)null)
				{
					component2.JGHHNJGLNHB(NBBELPFDLJG: false, CDPAMNIPPEC: true);
				}
				if (DNJLKIIJLFN && (Object)(object)item.placeableSurface != (Object)null)
				{
					item.placeableSurface.CFLAPCBOGJD(mEMGMDOCBOJ);
				}
			}
		}
		DOGMDAIGEKC(CDPAMNIPPEC: true);
	}

	private void HJHJMDAILFH(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		GLGAOFGNKCN();
	}

	public void SetVisibility(bool MDIKPGGBNLI, bool MAPFDGCKBLD = false)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		if (zone.id != -1)
		{
			if (MAPFDGCKBLD)
			{
				zone.ICBCLEKIJJD(MDIKPGGBNLI);
			}
			else
			{
				zone.PNANPLFPBNP(MDIKPGGBNLI);
			}
		}
		WorldGrid.MKLAFNJLOJN(new List<Vector2>
		{
			Vector2.op_Implicit(placeable.itemSpace.buildSquares[0].GetCentrePosition()),
			Vector2.op_Implicit(placeable.itemSpace.buildSquares[1].GetCentrePosition()),
			Vector2.op_Implicit(placeable.itemSpace.buildSquares[2].GetCentrePosition()),
			Vector2.op_Implicit(placeable.itemSpace.buildSquares[3].GetCentrePosition())
		});
	}

	private void BPHGADINMAN()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(IPHEFEMLOLJ));
		OnlineLoadManager instance = OnlineLoadManager.instance;
		instance.OnFinishedOnlineLoad = (Action)Delegate.Combine(instance.OnFinishedOnlineLoad, new Action(GPIMNHAIECA));
	}

	private void HMNFHFLIDOL()
	{
		try
		{
			if (!customerOrder.requesting && WorldTime.NOAOJJLNHJJ.hour >= leaveHour && WorldTime.NOAOJJLNHJJ.min >= CKIIFGALADN)
			{
				VacateRoom();
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void IBFNOKCBEOB(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		UpdateContentsNextFrame();
	}

	private void NKGMEMEACNN()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.leavingTheGame)
		{
			if (Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(ALGOBMNPLIB));
				CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
				commonReferences2.OnPlayerSleep = (Action)Delegate.Remove(commonReferences2.OnPlayerSleep, new Action(IFHFNDELKOP));
				CommonReferences commonReferences3 = CommonReferences.MNFMOEKMJKN();
				commonReferences3.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(commonReferences3.OnPlaceablePlaced, new Action<int, Placeable>(KBMCEELJEOB));
				CommonReferences commonReferences4 = CommonReferences.MNFMOEKMJKN();
				commonReferences4.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Remove(commonReferences4.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(PBNDOKJMNGH));
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyTableDirtLevelChanged = (Action<TableDirtLevel>)Delegate.Remove(instance.OnAnyTableDirtLevelChanged, new Action<TableDirtLevel>(FIHNCICLPCH));
			}
			RentedRoomsManager.MEINJIEFNAD(symbolID);
			if (Object.op_Implicit((Object)(object)TavernManager.GGFJGHHHEJC))
			{
				TavernManager instance2 = TavernManager.GGFJGHHHEJC;
				instance2.OnTavernClose = (Action<int>)Delegate.Remove(instance2.OnTavernClose, new Action<int>(KPEAKIHONDI));
			}
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(HMNFHFLIDOL));
		}
	}

	[SpecialName]
	public void DNDIHPKNNIL(bool AODONKKHPBP)
	{
		LIFGOFBGECO = AODONKKHPBP;
		door.AFBHGCDBNFE(BAKBJEOMLHN);
	}

	private void LFCDFFBBJFG()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && !GameManager.leavingTheGame)
		{
			if ((Object)(object)GameManager.GGFJGHHHEJC != (Object)null)
			{
				GameManager instance = GameManager.GGFJGHHHEJC;
				instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(UpdateContentsNextFrame));
			}
			if (Object.op_Implicit((Object)(object)OnlineLoadManager.instance))
			{
				OnlineLoadManager instance2 = OnlineLoadManager.instance;
				instance2.OnFinishedOnlineLoad = (Action)Delegate.Remove(instance2.OnFinishedOnlineLoad, new Action(IPHEFEMLOLJ));
			}
			if (zone.id != -1)
			{
				zone.FOKGHFFHKDJ(MDIKPGGBNLI: true);
			}
		}
	}

	public void DJBGGNMIKNF(bool ANDBJBCIAJG, bool BGKCHMNJBLJ = true)
	{
		if (((Behaviour)this).enabled)
		{
			if (Object.op_Implicit((Object)(object)((Component)this).gameObject) && (ANDBJBCIAJG || CBNPEEEEMHC == null))
			{
				CBNPEEEEMHC = ((MonoBehaviour)this).StartCoroutine(BGEKHFGFODC(ANDBJBCIAJG));
			}
			if (BGKCHMNJBLJ && OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.SendVacateRoom(placeable.onlinePlaceable.uniqueId);
			}
			if (OnlineManager.MasterOrOffline())
			{
				CommonReferences.MNFMOEKMJKN().OnGuestLeaving(0);
			}
		}
	}

	private void KKGAHDNMLDD(Placeable EAPCLAODGAE, List<Placeable> FNEHIAGFAOF)
	{
		for (int i = 0; i < FNEHIAGFAOF.Count; i++)
		{
			Placeable placeable = FNEHIAGFAOF[i];
			if (!((Object)(object)placeable == (Object)null) && (!((Object)(object)EAPCLAODGAE != (Object)null) || !((object)EAPCLAODGAE).Equals((object?)placeable)))
			{
				placeable.selectBlockers.Remove("Error_OccupiedRoom");
				if ((Object)(object)placeable.placeableSurface != (Object)null && placeable.placeableSurface.placeablesOnSurface != null)
				{
					KKGAHDNMLDD(placeable, placeable.placeableSurface.placeablesOnSurface);
				}
			}
		}
	}

	public void BGHGJBCKGMN(bool ANDBJBCIAJG, bool BGKCHMNJBLJ = true)
	{
		if (((Behaviour)this).enabled)
		{
			if (Object.op_Implicit((Object)(object)((Component)this).gameObject) && (ANDBJBCIAJG || CBNPEEEEMHC == null))
			{
				CBNPEEEEMHC = ((MonoBehaviour)this).StartCoroutine(HJNEKEBHOCA(ANDBJBCIAJG));
			}
			if (BGKCHMNJBLJ && OnlineManager.PlayingOnline())
			{
				OnlineObjectsManager.instance.OIACGIOPNEE(placeable.onlinePlaceable.uniqueId);
			}
			if (OnlineManager.PGAGDFAEEFB())
			{
				CommonReferences.GGFJGHHHEJC.OnGuestLeaving(1);
			}
		}
	}

	public bool ABNNAJHLGPB()
	{
		if (!occupied && dirtiness == 1097f)
		{
			return isValid;
		}
		return false;
	}

	public void ReadyToLeave()
	{
		SetCustomerInRoom();
		readyToLeave = true;
		remainingDays--;
		if (remainingDays <= 0)
		{
			door.knock = true;
			RentedRoomDoor rentedRoomDoor = door;
			rentedRoomDoor.OnKnock = (Action)Delegate.Combine(rentedRoomDoor.OnKnock, new Action(HDDBOMDBEDF));
			leaveHour = RentedRoomsManager.HoursCheckoutRange();
		}
		else
		{
			door.knock = false;
			leaveHour = RentedRoomsManager.HoursToLeaveNormalDayRange();
		}
		CKIIFGALADN = Random.Range(0, 55);
		if (OnlineManager.MasterOrOffline())
		{
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Combine(WorldTime.OnTickTime5Seconds, new Action(NJOLEJEIPOJ));
		}
	}

	public bool GDPINKMJDIB()
	{
		if (!occupied && dirtiness == 1208f)
		{
			return isValid;
		}
		return false;
	}

	private void PDJGPNDJDNF(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		UpdateContentsNextFrame();
	}

	private void PMLBFEFMNPF()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.leavingTheGame)
		{
			if (Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(ALGOBMNPLIB));
				CommonReferences commonReferences2 = CommonReferences.MNFMOEKMJKN();
				commonReferences2.OnPlayerSleep = (Action)Delegate.Remove(commonReferences2.OnPlayerSleep, new Action(AHIPJCGKBOM));
				CommonReferences commonReferences3 = CommonReferences.MNFMOEKMJKN();
				commonReferences3.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(commonReferences3.OnPlaceablePlaced, new Action<int, Placeable>(HJHJMDAILFH));
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Remove(instance.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(PBNDOKJMNGH));
				CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
				instance2.OnAnyTableDirtLevelChanged = (Action<TableDirtLevel>)Delegate.Remove(instance2.OnAnyTableDirtLevelChanged, new Action<TableDirtLevel>(LHECJHHNOGM));
			}
			RentedRoomsManager.NKOMGBOMAAK(symbolID);
			if (Object.op_Implicit((Object)(object)TavernManager.GGFJGHHHEJC))
			{
				TavernManager instance3 = TavernManager.GGFJGHHHEJC;
				instance3.OnTavernClose = (Action<int>)Delegate.Remove(instance3.OnTavernClose, new Action<int>(ONHNGPMMFBP));
			}
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(KEAIDPGIPDP));
		}
	}

	public bool IsRentable()
	{
		if (!occupied && dirtiness == 0f)
		{
			return isValid;
		}
		return false;
	}

	private void LHECJHHNOGM(TableDirtLevel DCDLGMBCPCE)
	{
		if ((Object)(object)placeable != (Object)null && zone.id != -1 && placeable.currentZoneIndex == zone.id)
		{
			GLGAOFGNKCN();
		}
	}

	private void FFCMICFDHNP(int JIIGOACEIKL)
	{
		if (customerOrder.requesting)
		{
			customerOrder.RemoveRoomOrder();
		}
	}

	public void OOAFIFBABCD()
	{
		if ((Object)(object)TavernZonesManager.EBAIHKJHCCA() == (Object)null)
		{
			return;
		}
		NCMJLNHHNIG(MAPFDGCKBLD: true);
		if (zone.id != -1)
		{
			Debug.Log((object)"");
			if (TavernZonesManager.GGFJGHHHEJC.BCMOMADFBEN(zone.id))
			{
				TavernZonesManager.GGFJGHHHEJC.MLKNNDLBIEI(zone.id);
			}
			zone.id = -1;
		}
	}

	public void IKPHMHHHDLJ(bool CDPAMNIPPEC = true)
	{
		BGHGJBCKGMN(ANDBJBCIAJG: false, CDPAMNIPPEC);
	}

	private void JJPLHHIMNMI(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		IPHEFEMLOLJ();
	}

	private IEnumerator AIJICALHIKB()
	{
		yield return null;
		UpdateContents();
	}

	public bool IsValid(out List<Vector2> GDFIONOLFIB, bool KIKDLKGBCOC)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0543: Unknown result type (might be due to invalid IL or missing references)
		//IL_0475: Unknown result type (might be due to invalid IL or missing references)
		//IL_047a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_056c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0571: Unknown result type (might be due to invalid IL or missing references)
		//IL_0592: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		List<Vector2> list = new List<Vector2>();
		list.Add(Vector2.op_Implicit(Utils.NKGANMEKDAL(placeable.itemSpace.buildSquares[1].GetCentrePosition())));
		list.Add(Vector2.op_Implicit(Utils.NKGANMEKDAL(placeable.itemSpace.buildSquares[3].GetCentrePosition())));
		List<Vector2> list2 = new List<Vector2>();
		list2.Add(Vector2.op_Implicit(Utils.NKGANMEKDAL(placeable.itemSpace.buildSquares[0].GetCentrePosition())));
		list2.Add(Vector2.op_Implicit(Utils.NKGANMEKDAL(placeable.itemSpace.buildSquares[2].GetCentrePosition())));
		GDFIONOLFIB = EditorGrid.DCOKLAGEKPB(list, 1, list2);
		if (GDFIONOLFIB.Count == 0)
		{
			BAKBJEOMLHN = true;
			list.Clear();
			list.Add(Vector2.op_Implicit(Utils.NKGANMEKDAL(placeable.itemSpace.buildSquares[0].GetCentrePosition())));
			list.Add(Vector2.op_Implicit(Utils.NKGANMEKDAL(placeable.itemSpace.buildSquares[2].GetCentrePosition())));
			list2.Clear();
			list2.Add(Vector2.op_Implicit(Utils.NKGANMEKDAL(placeable.itemSpace.buildSquares[1].GetCentrePosition())));
			list2.Add(Vector2.op_Implicit(Utils.NKGANMEKDAL(placeable.itemSpace.buildSquares[3].GetCentrePosition())));
			GDFIONOLFIB = EditorGrid.DCOKLAGEKPB(list, -1, list2);
		}
		else
		{
			BAKBJEOMLHN = false;
		}
		if (GDFIONOLFIB.Count > 0)
		{
			if (TavernZonesManager.GGFJGHHHEJC.GetCurrentNumberOfZones(ZoneType.RentedRoom) >= ReputationDBAccessor.GetMaxNumOfZones(ZoneType.RentedRoom))
			{
				if (KIKDLKGBCOC)
				{
					MainUI.ShowErrorText(1, InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Error_MaxZones"), LocalisationSystem.Get(ZoneType.RentedRoom.ToString()), ReputationDBAccessor.GetMaxNumOfZones(ZoneType.RentedRoom).ToString()));
					Debug.Log((object)"Error max zones");
				}
				return false;
			}
			Vector2 val;
			for (int i = 0; i < GDFIONOLFIB.Count; i++)
			{
				SpecificType specificType = WorldGrid.KELFJIPHBFP(Vector2.op_Implicit(GDFIONOLFIB[i]));
				if (specificType.HasFlag(SpecificType.NextToWall))
				{
					specificType ^= SpecificType.NextToWall;
				}
				if (specificType.HasFlag(SpecificType.RoomDoor) && !WorldGrid.KELFJIPHBFP(Vector2.op_Implicit(GDFIONOLFIB[i] + new Vector2(0f, 0.5f))).HasFlag(SpecificType.RoomDoor))
				{
					if ((Object)(object)WorldGrid.IPNJBJEMDKF(Vector2.op_Implicit(GDFIONOLFIB[i])) != (Object)null && (Object)(object)WorldGrid.IPNJBJEMDKF(Vector2.op_Implicit(GDFIONOLFIB[i])) != (Object)(object)door)
					{
						if (KIKDLKGBCOC)
						{
							MainUI.ShowErrorText(1, InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Error_IsBlockingChanges"), LocalisationSystem.Get(specificType.ToString())));
							string[] obj = new string[8]
							{
								"Error ",
								specificType.ToString(),
								" blocking at ",
								null,
								null,
								null,
								null,
								null
							};
							val = GDFIONOLFIB[i];
							obj[3] = ((object)(Vector2)(ref val)).ToString();
							obj[4] = "world door: ";
							obj[5] = ((object)WorldGrid.IPNJBJEMDKF(Vector2.op_Implicit(GDFIONOLFIB[i])))?.ToString();
							obj[6] = " door: ";
							obj[7] = ((object)door)?.ToString();
							Debug.Log((object)string.Concat(obj));
						}
						return false;
					}
				}
				else if (specificType.HasFlag(SpecificType.Bar) || specificType.HasFlag(SpecificType.CellarDoor) || specificType.HasFlag(SpecificType.PlayerBed) || specificType.HasFlag(SpecificType.StairsDown) || specificType.HasFlag(SpecificType.StairsDown) || specificType.HasFlag(SpecificType.StairsUp))
				{
					if (KIKDLKGBCOC)
					{
						MainUI.ShowErrorText(1, InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Error_IsBlockingChanges"), LocalisationSystem.Get(specificType.ToString())));
						string[] obj2 = new string[8]
						{
							"Error ",
							specificType.ToString(),
							" blocking at ",
							null,
							null,
							null,
							null,
							null
						};
						val = GDFIONOLFIB[i];
						obj2[3] = ((object)(Vector2)(ref val)).ToString();
						obj2[4] = " world door: ";
						obj2[5] = ((object)WorldGrid.IPNJBJEMDKF(Vector2.op_Implicit(GDFIONOLFIB[i])))?.ToString();
						obj2[6] = " door: ";
						obj2[7] = ((object)door)?.ToString();
						Debug.Log((object)string.Concat(obj2));
					}
					return false;
				}
			}
			if (GDFIONOLFIB.Count < 24)
			{
				if (KIKDLKGBCOC)
				{
					MainUI.ShowErrorText(1, LocalisationSystem.Get("Error_SmallRoom"));
					Debug.Log((object)("Small room " + GDFIONOLFIB.Count));
				}
				return false;
			}
			for (int j = 0; j < GDFIONOLFIB.Count; j++)
			{
				if (WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(GDFIONOLFIB[j])) != ZoneType.WithoutZone)
				{
					if (KIKDLKGBCOC)
					{
						MainUI.ShowErrorText(1, LocalisationSystem.Get("Error_AnotherZoneInRoom"));
						string text = WorldGrid.AGKGGAFFFGM(Vector2.op_Implicit(GDFIONOLFIB[j])).ToString();
						val = GDFIONOLFIB[j];
						Debug.Log((object)(text + " at " + ((object)(Vector2)(ref val)).ToString()));
					}
					return false;
				}
			}
			return true;
		}
		return false;
	}

	private void PBNDOKJMNGH(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		IPHEFEMLOLJ();
	}

	public void JCPMKGNDPAO(bool MDIKPGGBNLI, bool MAPFDGCKBLD = false)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		if (zone.id != -1)
		{
			if (MAPFDGCKBLD)
			{
				zone.EJKHPGLJKFF(MDIKPGGBNLI);
			}
			else
			{
				zone.FOKGHFFHKDJ(MDIKPGGBNLI);
			}
		}
		WorldGrid.MKLAFNJLOJN(new List<Vector2>
		{
			Vector2.op_Implicit(placeable.itemSpace.buildSquares[0].BOBEIFEGLOL()),
			Vector2.op_Implicit(placeable.itemSpace.buildSquares[0].FGGMIOHMGFL()),
			Vector2.op_Implicit(placeable.itemSpace.buildSquares[5].GetCentrePosition()),
			Vector2.op_Implicit(placeable.itemSpace.buildSquares[4].CBALBDIFOGF())
		});
	}

	public void UpdateContents()
	{
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)this == (Object)null)
		{
			return;
		}
		dirtiness = 0f;
		hasBed = false;
		hasLight = false;
		hasChair = false;
		hasTable = false;
		allFloorDirt = allFloorDirt.Where((FloorDirt d) => (Object)(object)d != (Object)null).ToList();
		dirtiness += allFloorDirt.Count() * 10;
		List<Placeable> list = DJPNHKENKHM();
		for (int i = 0; i < list.Count; i++)
		{
			if ((Object)(object)list[i] == (Object)null)
			{
				continue;
			}
			if ((Object)(object)list[i].itemSetup != (Object)null && Item.MLBOMGHINCA(list[i].itemSetup.item, null) && (list[i].itemSetup.item.JDJGFAACPFC() == 635 || list[i].itemSetup.item.JDJGFAACPFC() == 1647 || list[i].itemSetup.item.JDJGFAACPFC() == 1795 || list[i].itemSetup.item.JDJGFAACPFC() == 1821 || list[i].itemSetup.item.JDJGFAACPFC() == 1822 || list[i].itemSetup.item.JDJGFAACPFC() == 1823 || list[i].itemSetup.item.JDJGFAACPFC() == 2148))
			{
				hasBed = true;
				if (!((Component)list[i]).GetComponent<NPCBed>().IDHLOLDLLOE)
				{
					dirtiness += 50f;
				}
			}
			if (!hasLight)
			{
				hasLight = KEKLJDBBOMO(list[i]);
			}
			Table component = ((Component)list[i]).GetComponent<Table>();
			if ((Object)(object)component != (Object)null)
			{
				hasTable = true;
				if (component.JNHCCCBICDM != 0 && component.JNHCCCBICDM != TableDirtLevel.Clean)
				{
					dirtiness += 10f;
				}
			}
			if (!hasChair && (Object)(object)((Component)list[i]).GetComponent<Sitable>() != (Object)null)
			{
				hasChair = true;
			}
		}
		isValid = hasBed && hasLight && hasTable && hasChair;
		if (needsToBeClean && dirtiness <= 0f)
		{
			needsToBeClean = false;
			TavernReputation.AddAndShowReputationGain((int)((float)(CalculateReputation() * RentedRoomsManager.GetInstance().repPercentagePerRoomCleaned) / 100f), zone.HCEFIGGDBOO(), null, 0f, CDPAMNIPPEC: false);
		}
		OnContentsChanged();
		HJPANLBMCJP = null;
	}
}
