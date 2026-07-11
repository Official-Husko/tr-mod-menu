using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Waiter : Employee
{
	[CompilerGenerated]
	private sealed class GJAGBBEHPPI : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Waiter _003C_003E4__this;

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
		public GJAGBBEHPPI(int _003C_003E1__state)
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
			Waiter waiter = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				break;
			case 2:
				_003C_003E1__state = -1;
				break;
			}
			if (waiter.characterAnimation.characterAnimator.MLBGEKOIALK)
			{
				_003C_003E2__current = null;
				_003C_003E1__state = 2;
				return true;
			}
			waiter.behaviour.SetTrigger(Employee.IIFLFAJODIL);
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
	private sealed class OMLFJFIPGIO : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Waiter _003C_003E4__this;

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
		public OMLFJFIPGIO(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected O, but got Unknown
			int num = _003C_003E1__state;
			Waiter waiter = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = (object)new WaitForSeconds(0.7f);
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				((Employee)waiter).Leave();
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

	private static Waiter GGFJGHHHEJC;

	public Action OnLeft = delegate
	{
	};

	public Table tableServing;

	public bool cleaningTable;

	public CustomerOrder tableOrder;

	public List<FloorDirt> notReachableDirts = new List<FloorDirt>();

	public List<FloorDirt> floorDirts = new List<FloorDirt>();

	public WaiterState waiterState;

	public HashSet<Vector2> positionsBlocked = new HashSet<Vector2>();

	public float cleaningTableSpeed = 500f;

	public float cleaningFloorDirtSpeed = 1f;

	public float rateMakeFloorDirt = 5f;

	private List<Table> CDOMBGKOPFA = new List<Table>();

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

	public override bool LFDMDACCKJP => waiterState == WaiterState.Leaving;

	public void JMACINFOBCA(FloorDirt DDJECCPKNKG)
	{
		CIDKGNGDPAE(DDJECCPKNKG);
	}

	public void ADGFCNENBMO()
	{
		if ((Object)(object)BGPFFODAEJJ() != (Object)null && (Object)(object)DDJECCPKNKG.cleanerAssigned == (Object)(object)npc)
		{
			DDJECCPKNKG.cleanerAssigned = null;
		}
		FBLHHNEDMPG(null);
	}

	public static bool IsAtAvoidingWorkPoint()
	{
		return GGFJGHHHEJC.avoidingWorkPoint;
	}

	public static bool HasDrinkOnTray(ItemInstance BOGHFEEFHPP)
	{
		return GetTray().OHAPOKICCNK(BOGHFEEFHPP);
	}

	public static int NMJGKCFFDFH(int PNFPECBGNMB)
	{
		return GGFJGHHHEJC.GetPerkValue(PNFPECBGNMB);
	}

	private void KFMOMAOLKCP()
	{
		base.Leave();
	}

	protected override void Start()
	{
		if (!IgnoreDuringOnline())
		{
			base.Start();
			Placeable placeable = Bar.instance.placeable;
			placeable.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(placeable.OnThisPlaceablePlaced, new Action<int>(PLBFLBAIIMM));
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnTavernOpen = (Action<int>)Delegate.Combine(instance.OnTavernOpen, new Action<int>(DCMMDCNOLHA));
			TavernManager instance2 = TavernManager.GGFJGHHHEJC;
			instance2.OnTavernClose = (Action<int>)Delegate.Combine(instance2.OnTavernClose, new Action<int>(PLBFLBAIIMM));
		}
	}

	public static Waiter PHDCMKOOAJC()
	{
		return GGFJGHHHEJC;
	}

	private IEnumerator DNEKNFAFKDM()
	{
		return new OMLFJFIPGIO(1)
		{
			_003C_003E4__this = this
		};
	}

	public static Waiter OMEPPDMCFAO()
	{
		return GGFJGHHHEJC;
	}

	public static int GetEmployeePerkValue(int PNFPECBGNMB)
	{
		return GGFJGHHHEJC.GetPerkValue(PNFPECBGNMB);
	}

	private void HKECEBGKACL()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			characterAnimation.characterAnimator.DeactivateCleanSprites();
			if ((Object)(object)Bar.instance != (Object)null && (Object)(object)Bar.instance.placeable != (Object)null)
			{
				Placeable placeable = Bar.instance.placeable;
				placeable.OnThisPlaceablePlaced = (Action<int>)Delegate.Remove(placeable.OnThisPlaceablePlaced, new Action<int>(JEAMCAFDHBH));
			}
			if ((Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
			{
				TavernManager instance = TavernManager.GGFJGHHHEJC;
				instance.OnTavernOpen = (Action<int>)Delegate.Remove(instance.OnTavernOpen, new Action<int>(DCMMDCNOLHA));
				TavernManager instance2 = TavernManager.GGFJGHHHEJC;
				instance2.OnTavernClose = (Action<int>)Delegate.Remove(instance2.OnTavernClose, new Action<int>(PLBFLBAIIMM));
			}
			OnLeft();
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
		}
	}

	public static Waiter GetInstance()
	{
		return GGFJGHHHEJC;
	}

	public bool StartTask()
	{
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		if (trayHandler.tray.GCJDPMOAGKP())
		{
			behaviour.SetTrigger(Employee.NHBJKHNBDPH);
			return true;
		}
		if (base.JFCLIAFAOEK != null && base.JFCLIAFAOEK.tasks[0] && DrinksTable.instance.currentDrinks.Any())
		{
			behaviour.SetTrigger(Employee.IBLCDBJDFKA);
			return true;
		}
		tableServing = null;
		if (base.JFCLIAFAOEK != null && base.JFCLIAFAOEK.tasks[1])
		{
			if (TavernManager.GGFJGHHHEJC.tableNeedsClean.Any())
			{
				CDOMBGKOPFA.Clear();
				foreach (Table item in TavernManager.GGFJGHHHEJC.tableNeedsClean)
				{
					if (item.IsAnyPositionToCleanAvailable(positionsBlocked))
					{
						if (item.GetNumberOfDirtyDishes() >= GetPerkValue(65))
						{
							CDOMBGKOPFA.Add(item);
						}
					}
					else
					{
						TavernManager.GGFJGHHHEJC.blockedTables.Add(tableServing);
					}
				}
				if (CDOMBGKOPFA.Count > 0)
				{
					tableServing = Utils.JOJPOKBFANL(CDOMBGKOPFA.ToArray(), ((Component)this).transform.position);
				}
			}
			ResetFloorDirt();
			floorDirts.Clear();
			if (!MagicBroomsManager.instance.IsAnyMagicBroomAvailableToClean())
			{
				foreach (FloorDirt item2 in CommonReferences.GGFJGHHHEJC.tavernFloorDirt)
				{
					if ((Object)(object)item2.cleanerAssigned == (Object)null && !notReachableDirts.Contains(item2))
					{
						floorDirts.Add(item2);
					}
				}
				if (floorDirts.Any())
				{
					DDJECCPKNKG = Utils.JOJPOKBFANL(floorDirts.ToArray(), ((Component)this).transform.position);
				}
			}
			if (Object.op_Implicit((Object)(object)tableServing) && Object.op_Implicit((Object)(object)DDJECCPKNKG))
			{
				if (Vector3.Distance(((Component)tableServing).transform.position, ((Component)this).transform.position) < Vector3.Distance(((Component)DDJECCPKNKG).transform.position, ((Component)this).transform.position))
				{
					ResetFloorDirt();
					behaviour.SetTrigger(Employee.NHMLEJGLJDC);
					return true;
				}
				tableServing = null;
				DDJECCPKNKG.cleanerAssigned = npc;
				behaviour.SetTrigger(Employee.JDBIJKJLLGF);
				return true;
			}
			if (Object.op_Implicit((Object)(object)tableServing))
			{
				behaviour.SetTrigger(Employee.NHMLEJGLJDC);
				return true;
			}
			if (Object.op_Implicit((Object)(object)DDJECCPKNKG))
			{
				DDJECCPKNKG.cleanerAssigned = npc;
				behaviour.SetTrigger(Employee.JDBIJKJLLGF);
				return true;
			}
		}
		if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			Leave();
			return true;
		}
		return false;
	}

	public static Tray NBGCDPLJLOJ()
	{
		return GGFJGHHHEJC.trayHandler.tray;
	}

	private IEnumerator DBHEIPGCPDC()
	{
		yield return null;
		while (characterAnimation.characterAnimator.MLBGEKOIALK)
		{
			yield return null;
		}
		behaviour.SetTrigger(Employee.IIFLFAJODIL);
	}

	private void DCMMDCNOLHA(int JIIGOACEIKL)
	{
		positionsBlocked.Clear();
	}

	private IEnumerator MNNLPAMOBAN()
	{
		return new GJAGBBEHPPI(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator IOFFLAHEFBP()
	{
		yield return null;
		while (characterAnimation.characterAnimator.MLBGEKOIALK)
		{
			yield return null;
		}
		behaviour.SetTrigger(Employee.IIFLFAJODIL);
	}

	public bool OJBNEDECGFJ()
	{
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		if (trayHandler.tray.GMIFAAKDDGL())
		{
			behaviour.SetTrigger(Employee.NHBJKHNBDPH);
			return true;
		}
		if (base.JFCLIAFAOEK != null && base.JFCLIAFAOEK.tasks[1] && DrinksTable.instance.currentDrinks.Any())
		{
			behaviour.SetTrigger(Employee.IBLCDBJDFKA);
			return true;
		}
		tableServing = null;
		if (base.JFCLIAFAOEK != null && base.JFCLIAFAOEK.tasks[0])
		{
			if (TavernManager.GGFJGHHHEJC.tableNeedsClean.Any())
			{
				CDOMBGKOPFA.Clear();
				foreach (Table item in TavernManager.GGFJGHHHEJC.tableNeedsClean)
				{
					if (item.IsAnyPositionToCleanAvailable(positionsBlocked))
					{
						if (item.GetNumberOfDirtyDishes() >= GetPerkValue(123))
						{
							CDOMBGKOPFA.Add(item);
						}
					}
					else
					{
						TavernManager.GGFJGHHHEJC.blockedTables.Add(tableServing);
					}
				}
				if (CDOMBGKOPFA.Count > 0)
				{
					tableServing = Utils.JOJPOKBFANL(CDOMBGKOPFA.ToArray(), ((Component)this).transform.position);
				}
			}
			ADGFCNENBMO();
			floorDirts.Clear();
			if (!MagicBroomsManager.instance.HNHIOIBDOGA())
			{
				foreach (FloorDirt item2 in CommonReferences.GGFJGHHHEJC.tavernFloorDirt)
				{
					if ((Object)(object)item2.cleanerAssigned == (Object)null && !notReachableDirts.Contains(item2))
					{
						floorDirts.Add(item2);
					}
				}
				if (floorDirts.Any())
				{
					DDJECCPKNKG = Utils.JOJPOKBFANL(floorDirts.ToArray(), ((Component)this).transform.position);
				}
			}
			if (Object.op_Implicit((Object)(object)tableServing) && Object.op_Implicit((Object)(object)DDJECCPKNKG))
			{
				if (Vector3.Distance(((Component)tableServing).transform.position, ((Component)this).transform.position) < Vector3.Distance(((Component)BGPFFODAEJJ()).transform.position, ((Component)this).transform.position))
				{
					ADGFCNENBMO();
					behaviour.SetTrigger(Employee.NHMLEJGLJDC);
					return false;
				}
				tableServing = null;
				BGPFFODAEJJ().cleanerAssigned = npc;
				behaviour.SetTrigger(Employee.JDBIJKJLLGF);
				return false;
			}
			if (Object.op_Implicit((Object)(object)tableServing))
			{
				behaviour.SetTrigger(Employee.NHMLEJGLJDC);
				return false;
			}
			if (Object.op_Implicit((Object)(object)DDJECCPKNKG))
			{
				DDJECCPKNKG.cleanerAssigned = npc;
				behaviour.SetTrigger(Employee.JDBIJKJLLGF);
				return false;
			}
		}
		if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			Leave();
			return true;
		}
		return false;
	}

	public static Waiter EBPNKOMGCPB()
	{
		return GGFJGHHHEJC;
	}

	public void SetFloorDirt(FloorDirt DDJECCPKNKG)
	{
		this.DDJECCPKNKG = DDJECCPKNKG;
	}

	public static Waiter IIJAOOJGNHO()
	{
		return GGFJGHHHEJC;
	}

	[DebuggerHidden]
	[CompilerGenerated]
	private void LLIJGOCKPBB()
	{
		base.Leave();
	}

	public void CILNELBIPLF(FloorDirt DDJECCPKNKG)
	{
		this.DDJECCPKNKG = DDJECCPKNKG;
	}

	private void NKGMEMEACNN()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			characterAnimation.characterAnimator.OJGIKDGGNAO();
			if ((Object)(object)Bar.instance != (Object)null && (Object)(object)Bar.instance.placeable != (Object)null)
			{
				Placeable placeable = Bar.instance.placeable;
				placeable.OnThisPlaceablePlaced = (Action<int>)Delegate.Remove(placeable.OnThisPlaceablePlaced, new Action<int>(HFFGLGOONLC));
			}
			if ((Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
			{
				TavernManager instance = TavernManager.GGFJGHHHEJC;
				instance.OnTavernOpen = (Action<int>)Delegate.Remove(instance.OnTavernOpen, new Action<int>(DCMMDCNOLHA));
				TavernManager instance2 = TavernManager.GGFJGHHHEJC;
				instance2.OnTavernClose = (Action<int>)Delegate.Remove(instance2.OnTavernClose, new Action<int>(HFFGLGOONLC));
			}
			OnLeft();
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
		}
	}

	private void JEAMCAFDHBH(int JIIGOACEIKL)
	{
		behaviour.SetTrigger(Employee.IIFLFAJODIL);
	}

	[SpecialName]
	private void FBLHHNEDMPG(FloorDirt AODONKKHPBP)
	{
		_003COLGEHKCLEFI_003Ek__BackingField = AODONKKHPBP;
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			characterAnimation.characterAnimator.DeactivateCleanSprites();
			if ((Object)(object)Bar.instance != (Object)null && (Object)(object)Bar.instance.placeable != (Object)null)
			{
				Placeable placeable = Bar.instance.placeable;
				placeable.OnThisPlaceablePlaced = (Action<int>)Delegate.Remove(placeable.OnThisPlaceablePlaced, new Action<int>(PLBFLBAIIMM));
			}
			if ((Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
			{
				TavernManager instance = TavernManager.GGFJGHHHEJC;
				instance.OnTavernOpen = (Action<int>)Delegate.Remove(instance.OnTavernOpen, new Action<int>(DCMMDCNOLHA));
				TavernManager instance2 = TavernManager.GGFJGHHHEJC;
				instance2.OnTavernClose = (Action<int>)Delegate.Remove(instance2.OnTavernClose, new Action<int>(PLBFLBAIIMM));
			}
			OnLeft();
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
		}
	}

	public static Tray PILCPMLFMLK()
	{
		return GGFJGHHHEJC.trayHandler.tray;
	}

	private void ONNKEGELIHC(int JIIGOACEIKL)
	{
		behaviour.SetTrigger(Employee.IIFLFAJODIL);
	}

	private IEnumerator NILFNMFJIFB()
	{
		yield return (object)new WaitForSeconds(0.7f);
		base.Leave();
	}

	private void CLLAKJADGIH()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			characterAnimation.characterAnimator.OJGIKDGGNAO();
			if ((Object)(object)Bar.instance != (Object)null && (Object)(object)Bar.instance.placeable != (Object)null)
			{
				Placeable placeable = Bar.instance.placeable;
				placeable.OnThisPlaceablePlaced = (Action<int>)Delegate.Remove(placeable.OnThisPlaceablePlaced, new Action<int>(PLBFLBAIIMM));
			}
			if ((Object)(object)TavernManager.GGFJGHHHEJC != (Object)null)
			{
				TavernManager instance = TavernManager.GGFJGHHHEJC;
				instance.OnTavernOpen = (Action<int>)Delegate.Remove(instance.OnTavernOpen, new Action<int>(DCMMDCNOLHA));
				TavernManager instance2 = TavernManager.GGFJGHHHEJC;
				instance2.OnTavernClose = (Action<int>)Delegate.Remove(instance2.OnTavernClose, new Action<int>(ONNKEGELIHC));
			}
			OnLeft();
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
		}
	}

	protected override void Awake()
	{
		GGFJGHHHEJC = this;
		if (!IgnoreDuringOnline())
		{
			base.Awake();
		}
	}

	private void AJNMGNCCABC()
	{
		base.Leave();
	}

	private void FixedUpdate()
	{
		if (!IgnoreDuringOnline() && (Object)(object)currentState != (Object)null)
		{
			currentState.JDHKHKJOKFF();
		}
	}

	[SpecialName]
	public static bool FPGHBOFLFGP()
	{
		if ((Object)(object)GGFJGHHHEJC != (Object)null && GGFJGHHHEJC.JFCLIAFAOEK != null)
		{
			return GGFJGHHHEJC.JFCLIAFAOEK.working;
		}
		return false;
	}

	public static bool IsValid()
	{
		return (Object)(object)GGFJGHHHEJC != (Object)null;
	}

	private void PLBFLBAIIMM(int JIIGOACEIKL)
	{
		behaviour.SetTrigger(Employee.IIFLFAJODIL);
	}

	private IEnumerator CPGNAAJAPBB()
	{
		yield return (object)new WaitForSeconds(0.7f);
		base.Leave();
	}

	public static Tray GetTray()
	{
		return GGFJGHHHEJC.trayHandler.tray;
	}

	[SpecialName]
	private void CIDKGNGDPAE(FloorDirt AODONKKHPBP)
	{
		_003COLGEHKCLEFI_003Ek__BackingField = AODONKKHPBP;
	}

	public override void SetInstance(Employee NAKCFGEAGHH)
	{
		GGFJGHHHEJC = NAKCFGEAGHH as Waiter;
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
			if (waiterState == WaiterState.CleaningTable && (Object)(object)tableServing != (Object)null && !TavernManager.GGFJGHHHEJC.tableNeedsClean.Contains(tableServing))
			{
				characterAnimation.SetCleaning(NJHMBMGKCPL: false, tableServing.placeable.placeableSurface);
				((MonoBehaviour)this).StartCoroutine(IOFFLAHEFBP());
			}
		}
	}

	public bool AFGFJCLADFA()
	{
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		if (trayHandler.tray.ALFLJAEOFDF())
		{
			behaviour.SetTrigger(Employee.NHBJKHNBDPH);
			return false;
		}
		if (base.JFCLIAFAOEK != null && base.JFCLIAFAOEK.tasks[1] && DrinksTable.instance.currentDrinks.Any())
		{
			behaviour.SetTrigger(Employee.IBLCDBJDFKA);
			return false;
		}
		tableServing = null;
		if (base.JFCLIAFAOEK != null && base.JFCLIAFAOEK.tasks[1])
		{
			if (TavernManager.GGFJGHHHEJC.tableNeedsClean.Any())
			{
				CDOMBGKOPFA.Clear();
				foreach (Table item in TavernManager.GGFJGHHHEJC.tableNeedsClean)
				{
					if (item.IsAnyPositionToCleanAvailable(positionsBlocked))
					{
						if (item.GetNumberOfDirtyDishes() >= GetPerkValue(38))
						{
							CDOMBGKOPFA.Add(item);
						}
					}
					else
					{
						TavernManager.GGFJGHHHEJC.blockedTables.Add(tableServing);
					}
				}
				if (CDOMBGKOPFA.Count > 0)
				{
					tableServing = Utils.JOJPOKBFANL(CDOMBGKOPFA.ToArray(), ((Component)this).transform.position);
				}
			}
			ADGFCNENBMO();
			floorDirts.Clear();
			if (!MagicBroomsManager.instance.JEPGJNIGCIC())
			{
				foreach (FloorDirt item2 in CommonReferences.GGFJGHHHEJC.tavernFloorDirt)
				{
					if ((Object)(object)item2.cleanerAssigned == (Object)null && !notReachableDirts.Contains(item2))
					{
						floorDirts.Add(item2);
					}
				}
				if (floorDirts.Any())
				{
					CIDKGNGDPAE(Utils.JOJPOKBFANL(floorDirts.ToArray(), ((Component)this).transform.position));
				}
			}
			if (Object.op_Implicit((Object)(object)tableServing) && Object.op_Implicit((Object)(object)BGPFFODAEJJ()))
			{
				if (Vector3.Distance(((Component)tableServing).transform.position, ((Component)this).transform.position) < Vector3.Distance(((Component)DDJECCPKNKG).transform.position, ((Component)this).transform.position))
				{
					ADGFCNENBMO();
					behaviour.SetTrigger(Employee.NHMLEJGLJDC);
					return true;
				}
				tableServing = null;
				DDJECCPKNKG.cleanerAssigned = npc;
				behaviour.SetTrigger(Employee.JDBIJKJLLGF);
				return false;
			}
			if (Object.op_Implicit((Object)(object)tableServing))
			{
				behaviour.SetTrigger(Employee.NHMLEJGLJDC);
				return false;
			}
			if (Object.op_Implicit((Object)(object)BGPFFODAEJJ()))
			{
				BGPFFODAEJJ().cleanerAssigned = npc;
				behaviour.SetTrigger(Employee.JDBIJKJLLGF);
				return false;
			}
		}
		if (!TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			Leave();
			return false;
		}
		return true;
	}

	public override void Leave()
	{
		if (waiterState == WaiterState.CleaningTable)
		{
			characterAnimation.SetCleaning(NJHMBMGKCPL: false, tableServing.placeable.placeableSurface);
			((MonoBehaviour)this).StartCoroutine(CPGNAAJAPBB());
		}
		else
		{
			base.Leave();
		}
	}

	[SpecialName]
	public static bool INOKIOHEDEH()
	{
		if ((Object)(object)GGFJGHHHEJC != (Object)null && GGFJGHHHEJC.JFCLIAFAOEK != null)
		{
			return GGFJGHHHEJC.JFCLIAFAOEK.working;
		}
		return false;
	}

	public bool DEIGGBKICEG()
	{
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		if (trayHandler.tray.HHLGOKFGKGA())
		{
			behaviour.SetTrigger(Employee.NHBJKHNBDPH);
			return false;
		}
		if (base.JFCLIAFAOEK != null && base.JFCLIAFAOEK.tasks[0] && DrinksTable.instance.currentDrinks.Any())
		{
			behaviour.SetTrigger(Employee.IBLCDBJDFKA);
			return true;
		}
		tableServing = null;
		if (base.JFCLIAFAOEK != null && base.JFCLIAFAOEK.tasks[0])
		{
			if (TavernManager.GGFJGHHHEJC.tableNeedsClean.Any())
			{
				CDOMBGKOPFA.Clear();
				foreach (Table item in TavernManager.GGFJGHHHEJC.tableNeedsClean)
				{
					if (item.IsAnyPositionToCleanAvailable(positionsBlocked))
					{
						if (item.GetNumberOfDirtyDishes() >= GetPerkValue(58))
						{
							CDOMBGKOPFA.Add(item);
						}
					}
					else
					{
						TavernManager.GGFJGHHHEJC.blockedTables.Add(tableServing);
					}
				}
				if (CDOMBGKOPFA.Count > 0)
				{
					tableServing = Utils.JOJPOKBFANL(CDOMBGKOPFA.ToArray(), ((Component)this).transform.position);
				}
			}
			ResetFloorDirt();
			floorDirts.Clear();
			if (!MagicBroomsManager.instance.HNHIOIBDOGA())
			{
				foreach (FloorDirt item2 in CommonReferences.GGFJGHHHEJC.tavernFloorDirt)
				{
					if ((Object)(object)item2.cleanerAssigned == (Object)null && !notReachableDirts.Contains(item2))
					{
						floorDirts.Add(item2);
					}
				}
				if (floorDirts.Any())
				{
					CIDKGNGDPAE(Utils.JOJPOKBFANL(floorDirts.ToArray(), ((Component)this).transform.position));
				}
			}
			if (Object.op_Implicit((Object)(object)tableServing) && Object.op_Implicit((Object)(object)DDJECCPKNKG))
			{
				if (Vector3.Distance(((Component)tableServing).transform.position, ((Component)this).transform.position) < Vector3.Distance(((Component)DDJECCPKNKG).transform.position, ((Component)this).transform.position))
				{
					ResetFloorDirt();
					behaviour.SetTrigger(Employee.NHMLEJGLJDC);
					return true;
				}
				tableServing = null;
				DDJECCPKNKG.cleanerAssigned = npc;
				behaviour.SetTrigger(Employee.JDBIJKJLLGF);
				return true;
			}
			if (Object.op_Implicit((Object)(object)tableServing))
			{
				behaviour.SetTrigger(Employee.NHMLEJGLJDC);
				return false;
			}
			if (Object.op_Implicit((Object)(object)DDJECCPKNKG))
			{
				BGPFFODAEJJ().cleanerAssigned = npc;
				behaviour.SetTrigger(Employee.JDBIJKJLLGF);
				return true;
			}
		}
		if (!TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			Leave();
			return true;
		}
		return false;
	}

	public void ResetFloorDirt()
	{
		if ((Object)(object)DDJECCPKNKG != (Object)null && (Object)(object)DDJECCPKNKG.cleanerAssigned == (Object)(object)npc)
		{
			DDJECCPKNKG.cleanerAssigned = null;
		}
		DDJECCPKNKG = null;
	}

	[SpecialName]
	public FloorDirt BGPFFODAEJJ()
	{
		return _003COLGEHKCLEFI_003Ek__BackingField;
	}

	private void HFFGLGOONLC(int JIIGOACEIKL)
	{
		behaviour.SetTrigger(Employee.IIFLFAJODIL);
	}

	public void GCIJLMOGHAF(FloorDirt DDJECCPKNKG)
	{
		FBLHHNEDMPG(DDJECCPKNKG);
	}
}
