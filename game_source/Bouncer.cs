using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Bouncer : Employee
{
	[CompilerGenerated]
	private sealed class ELEIMFNFGGJ : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Bouncer _003C_003E4__this;

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
		public ELEIMFNFGGJ(int _003C_003E1__state)
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
			Bouncer bouncer = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				bouncer.characterAnimation.LookAtObject(((Component)bouncer.customer).gameObject);
				bouncer.characterAnimation.SetBool(Employee.EGJEDCPHEJH, EGFGNGJGBOP: true);
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				if (Object.op_Implicit((Object)(object)bouncer.customer))
				{
					bouncer.customer.CalmCustomer(bouncer);
				}
				bouncer.calm = true;
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
	private sealed class IDGOFPLFCEH : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Bouncer _003C_003E4__this;

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
		public IDGOFPLFCEH(int _003C_003E1__state)
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
			Bouncer bouncer = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				bouncer.workerBringingBack.behaviour.SetTrigger(Employee.IIFLFAJODIL);
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				bouncer.characterAnimation.SetBool(Employee.EGJEDCPHEJH, EGFGNGJGBOP: true);
				bouncer.behaviour.SetTrigger(Employee.IIFLFAJODIL);
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

	private static Bouncer GGFJGHHHEJC;

	public Action OnLeft = delegate
	{
	};

	public BouncerState bouncerState;

	public Customer customer;

	public Employee workerBringingBack;

	[HideInInspector]
	public bool calm;

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

	public override bool LFDMDACCKJP => bouncerState == BouncerState.Leaving;

	protected override void Awake()
	{
		GGFJGHHHEJC = this;
		if (!IgnoreDuringOnline())
		{
			base.Awake();
		}
	}

	public static int GetEmployeePerkValue(int PNFPECBGNMB)
	{
		return GGFJGHHHEJC.GetPerkValue(PNFPECBGNMB);
	}

	[SpecialName]
	public static bool GKNNBKICEAK()
	{
		if ((Object)(object)GGFJGHHHEJC != (Object)null && GGFJGHHHEJC.JFCLIAFAOEK != null)
		{
			return GGFJGHHHEJC.JFCLIAFAOEK.working;
		}
		return true;
	}

	[SpecialName]
	public static bool MFHBHANHINB()
	{
		if ((Object)(object)GGFJGHHHEJC != (Object)null && GGFJGHHHEJC.JFCLIAFAOEK != null)
		{
			return GGFJGHHHEJC.JFCLIAFAOEK.working;
		}
		return false;
	}

	public static Bouncer MDDCPOILOOM()
	{
		return GGFJGHHHEJC;
	}

	public bool StartTask()
	{
		if (base.JFCLIAFAOEK != null && base.JFCLIAFAOEK.tasks[0] && TavernManager.GGFJGHHHEJC.LKOJBFMGMAE && TavernManager.GGFJGHHHEJC.customersRowdy.Any())
		{
			customer = TavernManager.GGFJGHHHEJC.customersRowdy[0];
			if (customer.customerState == CustomerState.BeingANuisance)
			{
				behaviour.SetTrigger(Employee.DDKMKPJFKOL);
			}
			else
			{
				behaviour.SetTrigger("CalmRowdyCustomer");
			}
			return true;
		}
		if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			if ((Object)(object)customer != (Object)null)
			{
				customer = null;
			}
			Leave();
			return true;
		}
		return false;
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
		if (base.JFCLIAFAOEK != null && base.JFCLIAFAOEK.tasks[0] && TavernManager.GGFJGHHHEJC.LKOJBFMGMAE && TavernManager.GGFJGHHHEJC.customersRowdy.Any())
		{
			customer = TavernManager.GGFJGHHHEJC.customersRowdy[0];
			if (customer.customerState == CustomerState.EatingAtTable)
			{
				behaviour.SetTrigger(Employee.DDKMKPJFKOL);
			}
			else
			{
				behaviour.SetTrigger("SatisfiedCustomers");
			}
			return true;
		}
		if (!TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			if ((Object)(object)customer != (Object)null)
			{
				customer = null;
			}
			Leave();
			return false;
		}
		return false;
	}

	private void OEAAPIBLALL()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			characterAnimation.characterAnimator.OJGIKDGGNAO();
			if (Object.op_Implicit((Object)(object)Bar.instance) && Object.op_Implicit((Object)(object)Bar.instance.placeable))
			{
				Placeable placeable = Bar.instance.placeable;
				placeable.OnThisPlaceablePlaced = (Action<int>)Delegate.Remove(placeable.OnThisPlaceablePlaced, new Action<int>(EOPNCDKOMCG));
			}
			if (Object.op_Implicit((Object)(object)TavernManager.GGFJGHHHEJC))
			{
				TavernManager instance = TavernManager.GGFJGHHHEJC;
				instance.OnTavernClose = (Action<int>)Delegate.Remove(instance.OnTavernClose, new Action<int>(EOPNCDKOMCG));
			}
			OnLeft();
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
		}
	}

	public static Bouncer GetInstance()
	{
		return GGFJGHHHEJC;
	}

	public static Bouncer DCILOFEFFAG()
	{
		return GGFJGHHHEJC;
	}

	public bool POLMILHJJNO()
	{
		if (base.JFCLIAFAOEK != null && base.JFCLIAFAOEK.tasks[0] && TavernManager.GGFJGHHHEJC.LKKBHOAFMAH() && TavernManager.GGFJGHHHEJC.customersRowdy.Any())
		{
			customer = TavernManager.GGFJGHHHEJC.customersRowdy[0];
			if (customer.customerState == CustomerState.Inactive)
			{
				behaviour.SetTrigger(Employee.DDKMKPJFKOL);
			}
			else
			{
				behaviour.SetTrigger("ReceiveBeginReplay");
			}
			return true;
		}
		if (!TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			if ((Object)(object)customer != (Object)null)
			{
				customer = null;
			}
			Leave();
			return false;
		}
		return true;
	}

	public static int NADBCNFALNF(int PNFPECBGNMB)
	{
		return GGFJGHHHEJC.GetPerkValue(PNFPECBGNMB);
	}

	protected override void Update()
	{
		base.Update();
		if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE && (Object)(object)customer != (Object)null)
		{
			customer = null;
			Leave();
		}
	}

	private IEnumerator NPKFGPCOFPD()
	{
		yield return CommonReferences.wait05;
		workerBringingBack.behaviour.SetTrigger(Employee.IIFLFAJODIL);
		yield return CommonReferences.wait1;
		characterAnimation.SetBool(Employee.EGJEDCPHEJH, EGFGNGJGBOP: true);
		behaviour.SetTrigger(Employee.IIFLFAJODIL);
	}

	private IEnumerator KMDBKGKBAFD()
	{
		yield return CommonReferences.wait05;
		workerBringingBack.behaviour.SetTrigger(Employee.IIFLFAJODIL);
		yield return CommonReferences.wait1;
		characterAnimation.SetBool(Employee.EGJEDCPHEJH, EGFGNGJGBOP: true);
		behaviour.SetTrigger(Employee.IIFLFAJODIL);
	}

	public override void SetInstance(Employee NAKCFGEAGHH)
	{
		GGFJGHHHEJC = NAKCFGEAGHH as Bouncer;
	}

	[SpecialName]
	public static bool LDICGJGFBBG()
	{
		if ((Object)(object)GGFJGHHHEJC != (Object)null && GGFJGHHHEJC.JFCLIAFAOEK != null)
		{
			return GGFJGHHHEJC.JFCLIAFAOEK.working;
		}
		return false;
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			characterAnimation.characterAnimator.DeactivateCleanSprites();
			if (Object.op_Implicit((Object)(object)Bar.instance) && Object.op_Implicit((Object)(object)Bar.instance.placeable))
			{
				Placeable placeable = Bar.instance.placeable;
				placeable.OnThisPlaceablePlaced = (Action<int>)Delegate.Remove(placeable.OnThisPlaceablePlaced, new Action<int>(PLBFLBAIIMM));
			}
			if (Object.op_Implicit((Object)(object)TavernManager.GGFJGHHHEJC))
			{
				TavernManager instance = TavernManager.GGFJGHHHEJC;
				instance.OnTavernClose = (Action<int>)Delegate.Remove(instance.OnTavernClose, new Action<int>(PLBFLBAIIMM));
			}
			OnLeft();
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
		}
	}

	public void DelayGoToWork()
	{
		((MonoBehaviour)this).StartCoroutine(FBMPOEMEPGJ());
	}

	private IEnumerator GMECNAHGGIK()
	{
		characterAnimation.LookAtObject(((Component)customer).gameObject);
		characterAnimation.SetBool(Employee.EGJEDCPHEJH, EGFGNGJGBOP: true);
		yield return CommonReferences.wait1;
		if (Object.op_Implicit((Object)(object)customer))
		{
			customer.CalmCustomer(this);
		}
		calm = true;
	}

	protected override void Start()
	{
		if (!IgnoreDuringOnline())
		{
			base.Start();
			Placeable placeable = Bar.instance.placeable;
			placeable.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(placeable.OnThisPlaceablePlaced, new Action<int>(PLBFLBAIIMM));
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnTavernClose = (Action<int>)Delegate.Combine(instance.OnTavernClose, new Action<int>(PLBFLBAIIMM));
		}
	}

	public void AIFLHAHBFNK()
	{
		((MonoBehaviour)this).StartCoroutine(GMECNAHGGIK());
	}

	private IEnumerator DAICCEFGJMP()
	{
		return new IDGOFPLFCEH(1)
		{
			_003C_003E4__this = this
		};
	}

	public void DelayCalm()
	{
		((MonoBehaviour)this).StartCoroutine(GMECNAHGGIK());
	}

	public static Bouncer IIJAOOJGNHO()
	{
		return GGFJGHHHEJC;
	}

	private IEnumerator FBMPOEMEPGJ()
	{
		yield return CommonReferences.wait05;
		workerBringingBack.behaviour.SetTrigger(Employee.IIFLFAJODIL);
		yield return CommonReferences.wait1;
		characterAnimation.SetBool(Employee.EGJEDCPHEJH, EGFGNGJGBOP: true);
		behaviour.SetTrigger(Employee.IIFLFAJODIL);
	}

	public void LPHNBEHACJI()
	{
		((MonoBehaviour)this).StartCoroutine(CCDANBGCMIP());
	}

	public static bool MLGNJKMFAEN()
	{
		return (Object)(object)GGFJGHHHEJC != (Object)null;
	}

	private void EOPNCDKOMCG(int JIIGOACEIKL)
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			behaviour.SetTrigger(Employee.IIFLFAJODIL);
		}
	}

	private IEnumerator CCDANBGCMIP()
	{
		return new ELEIMFNFGGJ(1)
		{
			_003C_003E4__this = this
		};
	}

	public void NCOGIKKJNDJ()
	{
		((MonoBehaviour)this).StartCoroutine(GMECNAHGGIK());
	}

	private void PLBFLBAIIMM(int JIIGOACEIKL)
	{
		if (OnlineManager.IsMasterClient())
		{
			behaviour.SetTrigger(Employee.IIFLFAJODIL);
		}
	}

	public void HMHMLMNDHKM()
	{
		((MonoBehaviour)this).StartCoroutine(NPKFGPCOFPD());
	}

	public static bool IsValid()
	{
		return (Object)(object)GGFJGHHHEJC != (Object)null;
	}

	private void FixedUpdate()
	{
		if (!IgnoreDuringOnline() && (Object)(object)currentState != (Object)null)
		{
			currentState.JDHKHKJOKFF();
		}
	}

	public static Bouncer FFOMKKIAHKI()
	{
		return GGFJGHHHEJC;
	}
}
