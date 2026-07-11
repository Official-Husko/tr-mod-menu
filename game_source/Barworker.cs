using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Barworker : Employee
{
	private static Barworker GGFJGHHHEJC;

	public Action OnLeft = delegate
	{
	};

	public BarworkerState barworkerState;

	public Customer customerServing;

	public float timeAfterServe = 0.5f;

	public float timeTakingDrink = 2f;

	private List<Customer> PGOMFIHHBNE = new List<Customer>();

	private List<ItemInstance> NPFKKFOMKJN;

	private bool KENCEPGAIIK;

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

	public override bool LFDMDACCKJP => barworkerState == BarworkerState.Leaving;

	public static bool CMAJMOMNIJI(ItemInstance BOGHFEEFHPP)
	{
		return HICGOKMALMP().FPNEGBNKILJ(BOGHFEEFHPP);
	}

	public static bool IsAtAvoidingWorkPoint()
	{
		return GGFJGHHHEJC.avoidingWorkPoint;
	}

	public static Tray GetTray()
	{
		return GGFJGHHHEJC.trayHandler.tray;
	}

	public static bool BNCOBGGKLMD()
	{
		return GGFJGHHHEJC.avoidingWorkPoint;
	}

	public static Barworker GetInstance()
	{
		return GGFJGHHHEJC;
	}

	public bool StartTask()
	{
		if (Bar.instance.waitingAtBar.Any())
		{
			customerServing = GetNextCustomerToServe();
			if ((Object)(object)customerServing != (Object)null)
			{
				if (FLONHCEKKPF(customerServing))
				{
					behaviour.SetTrigger(Employee.IIMAJJLHICE);
				}
				else if (DNAIEKENBLA(customerServing))
				{
					behaviour.SetTrigger(Employee.BKOCCBLGHPB);
				}
			}
		}
		if (barworkerState != 0)
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

	private void LALJNGFGKPA()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			if ((Object)(object)Bar.instance != (Object)null && (Object)(object)Bar.instance.placeable != (Object)null)
			{
				Placeable placeable = Bar.instance.placeable;
				placeable.OnThisPlaceablePlaced = (Action<int>)Delegate.Remove(placeable.OnThisPlaceablePlaced, new Action<int>(LBMNEDDDJJP));
			}
			OnLeft();
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
		}
	}

	public bool HNJCHEPFEHG()
	{
		if (Bar.instance.waitingAtBar.Any())
		{
			customerServing = LFADBGEIPLN();
			if ((Object)(object)customerServing != (Object)null)
			{
				if (LFPFADGNAHN(customerServing))
				{
					behaviour.SetTrigger(Employee.IIMAJJLHICE);
				}
				else if (DNAIEKENBLA(customerServing))
				{
					behaviour.SetTrigger(Employee.BKOCCBLGHPB);
				}
			}
		}
		if (barworkerState != 0)
		{
			behaviour.SetTrigger(Employee.IIFLFAJODIL);
			return true;
		}
		if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			Leave();
			return false;
		}
		return true;
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			if ((Object)(object)Bar.instance != (Object)null && (Object)(object)Bar.instance.placeable != (Object)null)
			{
				Placeable placeable = Bar.instance.placeable;
				placeable.OnThisPlaceablePlaced = (Action<int>)Delegate.Remove(placeable.OnThisPlaceablePlaced, new Action<int>(BarPlaced));
			}
			OnLeft();
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
		}
	}

	public static Tray NCMAIJGLOOB()
	{
		return GGFJGHHHEJC.trayHandler.tray;
	}

	public static Barworker IIJAOOJGNHO()
	{
		return GGFJGHHHEJC;
	}

	private void EMKKKNJBOGN(HumanNPC JEBNJPBABBA)
	{
		if ((Object)(object)customerServing != (Object)null && (Object)(object)((Component)JEBNJPBABBA).gameObject == (Object)(object)((Component)customerServing).gameObject)
		{
			customerServing = null;
		}
	}

	public static bool HasDrinkOnTray(ItemInstance BOGHFEEFHPP)
	{
		return GetTray().OHAPOKICCNK(BOGHFEEFHPP);
	}

	private bool HDDCGODGEPE(Customer PJNGMCJIHME)
	{
		if (PJNGMCJIHME.currentRequest != null && PJNGMCJIHME.currentRequest.AJKDEIPDLHI())
		{
			if (PJNGMCJIHME.currentRequest.LHBPOPOIFLE().CIGFGKKCPCK() == 149)
			{
				return true;
			}
			return (Object)(object)DrinkDispensersManager.JFNOOMJMHCB().MFJBLFKJFDM(PJNGMCJIHME.currentRequest) != (Object)null;
		}
		return true;
	}

	public Customer LFADBGEIPLN()
	{
		if (!Bar.instance.waitingAtBar.Any())
		{
			return null;
		}
		if (base.JFCLIAFAOEK != null)
		{
			if (base.JFCLIAFAOEK.tasks[0] && base.JFCLIAFAOEK.tasks[1])
			{
				for (int i = 0; i < Bar.instance.waitingAtBar.Count; i++)
				{
					if (FLONHCEKKPF(Bar.instance.waitingAtBar[i].customer))
					{
						return Bar.instance.waitingAtBar[i].customer;
					}
				}
			}
			else if (base.JFCLIAFAOEK.tasks[1])
			{
				for (int j = 0; j < Bar.instance.waitingAtBar.Count; j += 0)
				{
					if (Bar.instance.waitingAtBar[j].customer.customerState == CustomerState.BeingANuisance && LFPFADGNAHN(Bar.instance.waitingAtBar[j].customer))
					{
						return Bar.instance.waitingAtBar[j].customer;
					}
				}
			}
			else if (base.JFCLIAFAOEK.tasks[1])
			{
				for (int k = 0; k < Bar.instance.waitingAtBar.Count; k += 0)
				{
					if (Bar.instance.waitingAtBar[k].customer.customerState == (CustomerState)34 && LFPFADGNAHN(Bar.instance.waitingAtBar[k].customer))
					{
						return Bar.instance.waitingAtBar[k].customer;
					}
				}
			}
		}
		return GetAnotherCustomerWithDrinkRequest();
	}

	private bool LFPFADGNAHN(Customer PJNGMCJIHME)
	{
		if (PJNGMCJIHME.currentRequest != null && PJNGMCJIHME.currentRequest.BAHJFDHLDEI())
		{
			return trayHandler.tray.MNAILNGHBFF(PJNGMCJIHME.currentRequest);
		}
		return true;
	}

	private bool MAMFMLCDKLC(Customer PJNGMCJIHME)
	{
		if (PJNGMCJIHME.currentRequest != null && PJNGMCJIHME.currentRequest.JLCBECDECBP())
		{
			if (PJNGMCJIHME.currentRequest.PHGLMBIEOMK().JGHNDJBCFAJ() == -147)
			{
				return false;
			}
			return (Object)(object)DrinkDispensersManager.OPILDPFDFKJ().OPGNPHKFKBC(PJNGMCJIHME.currentRequest) != (Object)null;
		}
		return true;
	}

	public bool EPIANIBFBBI()
	{
		if (Bar.instance.waitingAtBar.Any())
		{
			customerServing = GetNextCustomerToServe();
			if ((Object)(object)customerServing != (Object)null)
			{
				if (FLONHCEKKPF(customerServing))
				{
					behaviour.SetTrigger(Employee.IIMAJJLHICE);
				}
				else if (CBMLKHOEGCA(customerServing))
				{
					behaviour.SetTrigger(Employee.BKOCCBLGHPB);
				}
			}
		}
		if (barworkerState != 0)
		{
			behaviour.SetTrigger(Employee.IIFLFAJODIL);
			return true;
		}
		if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			Leave();
			return false;
		}
		return true;
	}

	private bool FLONHCEKKPF(Customer PJNGMCJIHME)
	{
		if (PJNGMCJIHME.currentRequest != null && PJNGMCJIHME.currentRequest.JEPBBEBJEFI())
		{
			return trayHandler.tray.OHAPOKICCNK(PJNGMCJIHME.currentRequest);
		}
		return true;
	}

	public Customer GetAnotherCustomerWithDrinkRequest()
	{
		NPFKKFOMKJN = new List<ItemInstance>(trayHandler.tray.currentDrinks);
		if (PlayerController.GetPlayer(1).trayHandler.tray.GCJDPMOAGKP())
		{
			NPFKKFOMKJN.AddRange(PlayerController.GetPlayer(1).trayHandler.tray.currentDrinks);
		}
		if (GameManager.LocalCoop())
		{
			NPFKKFOMKJN.AddRange(PlayerController.GetPlayer(2).trayHandler.tray.currentDrinks);
		}
		if (OnlineManager.PlayingOnline())
		{
			for (int i = 2; i <= 4; i++)
			{
				if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && PlayerController.GetPlayer(i).trayHandler.tray.currentDrinks != null)
				{
					NPFKKFOMKJN.AddRange(PlayerController.GetPlayer(i).trayHandler.tray.currentDrinks);
				}
			}
		}
		if (Waiter.JHLLELHBIDA && Waiter.GetTray().GCJDPMOAGKP())
		{
			NPFKKFOMKJN.AddRange(Waiter.GetTray().currentDrinks);
		}
		PGOMFIHHBNE.Clear();
		for (int j = 0; j < Bar.instance.waitingAtBar.Count; j++)
		{
			Customer customer = Bar.instance.waitingAtBar[j].customer;
			ItemInstance currentRequest = customer.currentRequest;
			if (currentRequest != null)
			{
				bool flag = currentRequest.JEPBBEBJEFI();
				if ((base.JFCLIAFAOEK != null && base.JFCLIAFAOEK.tasks[0] && base.JFCLIAFAOEK.tasks[1]) ? flag : ((base.JFCLIAFAOEK == null || !base.JFCLIAFAOEK.tasks[0]) ? (flag && customer.customerState == CustomerState.OrderInTable) : (flag && customer.customerState == CustomerState.WaitingAtBar)))
				{
					PGOMFIHHBNE.Add(customer);
				}
			}
		}
		for (int k = 0; k < PGOMFIHHBNE.Count; k++)
		{
			if (PGOMFIHHBNE[k].currentRequest == null)
			{
				continue;
			}
			KENCEPGAIIK = false;
			for (int num = NPFKKFOMKJN.Count - 1; num >= 0; num--)
			{
				if (NPFKKFOMKJN[num].Equals(PGOMFIHHBNE[k].currentRequest))
				{
					NPFKKFOMKJN.RemoveAt(num);
					KENCEPGAIIK = true;
					break;
				}
			}
			if (!KENCEPGAIIK && DNAIEKENBLA(PGOMFIHHBNE[k]))
			{
				return PGOMFIHHBNE[k];
			}
		}
		return null;
	}

	public void LBMNEDDDJJP(int JIIGOACEIKL)
	{
		if (TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			behaviour.SetTrigger(Employee.IIFLFAJODIL);
		}
	}

	public void FixedUpdate()
	{
		if (!IgnoreDuringOnline() && (Object)(object)currentState != (Object)null)
		{
			currentState.JDHKHKJOKFF();
		}
	}

	public void AFKGJCIANOF()
	{
		if (!IgnoreDuringOnline() && (Object)(object)currentState != (Object)null)
		{
			currentState.PFNIPILPGFN();
		}
	}

	private bool HKBCCABABNI(Customer PJNGMCJIHME)
	{
		if (PJNGMCJIHME.currentRequest != null && PJNGMCJIHME.currentRequest.AJKDEIPDLHI())
		{
			if (PJNGMCJIHME.currentRequest.AFOACBIHNCL().JGHNDJBCFAJ(DAINLFIMLIH: false) == -163)
			{
				return true;
			}
			return (Object)(object)DrinkDispensersManager.OPILDPFDFKJ().PHACNOMMPGL(PJNGMCJIHME.currentRequest) != (Object)null;
		}
		return true;
	}

	public void PECEOEDMDEP(int JIIGOACEIKL)
	{
		if (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			behaviour.SetTrigger(Employee.IIFLFAJODIL);
		}
	}

	public void DEFIFMAOPCM()
	{
		if (!IgnoreDuringOnline() && (Object)(object)currentState != (Object)null)
		{
			currentState.JDHKHKJOKFF();
		}
	}

	protected override void OnDisable()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			base.OnDisable();
			if ((Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnNPCLeaveBar = (Action<HumanNPC>)Delegate.Remove(instance.OnNPCLeaveBar, new Action<HumanNPC>(EMKKKNJBOGN));
			}
		}
	}

	private void ENHDLLEDKKG(HumanNPC JEBNJPBABBA)
	{
		if ((Object)(object)customerServing != (Object)null && (Object)(object)((Component)JEBNJPBABBA).gameObject == (Object)(object)((Component)customerServing).gameObject)
		{
			customerServing = null;
		}
	}

	public static int GetEmployeePerkValue(int PNFPECBGNMB)
	{
		return GGFJGHHHEJC.GetPerkValue(PNFPECBGNMB);
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

	public bool GHMFNBDCKCA()
	{
		if (Bar.instance.waitingAtBar.Any())
		{
			customerServing = GetNextCustomerToServe();
			if ((Object)(object)customerServing != (Object)null)
			{
				if (LFPFADGNAHN(customerServing))
				{
					behaviour.SetTrigger(Employee.IIMAJJLHICE);
				}
				else if (MAMFMLCDKLC(customerServing))
				{
					behaviour.SetTrigger(Employee.BKOCCBLGHPB);
				}
			}
		}
		if (barworkerState != 0)
		{
			behaviour.SetTrigger(Employee.IIFLFAJODIL);
			return true;
		}
		if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			Leave();
			return false;
		}
		return true;
	}

	protected override void Start()
	{
		if (!IgnoreDuringOnline())
		{
			base.Start();
			Placeable placeable = Bar.instance.placeable;
			placeable.OnThisPlaceablePlaced = (Action<int>)Delegate.Combine(placeable.OnThisPlaceablePlaced, new Action<int>(BarPlaced));
		}
	}

	protected override void OnEnable()
	{
		base.OnEnable();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnNPCLeaveBar = (Action<HumanNPC>)Delegate.Combine(instance.OnNPCLeaveBar, new Action<HumanNPC>(EMKKKNJBOGN));
	}

	public static Tray HICGOKMALMP()
	{
		return GGFJGHHHEJC.trayHandler.tray;
	}

	private void BLAJFMAAMDO()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading)
		{
			if ((Object)(object)Bar.instance != (Object)null && (Object)(object)Bar.instance.placeable != (Object)null)
			{
				Placeable placeable = Bar.instance.placeable;
				placeable.OnThisPlaceablePlaced = (Action<int>)Delegate.Remove(placeable.OnThisPlaceablePlaced, new Action<int>(PECEOEDMDEP));
			}
			OnLeft();
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
		}
	}

	public bool DEABFBIHNGD()
	{
		if (Bar.instance.waitingAtBar.Any())
		{
			customerServing = LFADBGEIPLN();
			if ((Object)(object)customerServing != (Object)null)
			{
				if (LFPFADGNAHN(customerServing))
				{
					behaviour.SetTrigger(Employee.IIMAJJLHICE);
				}
				else if (HKBCCABABNI(customerServing))
				{
					behaviour.SetTrigger(Employee.BKOCCBLGHPB);
				}
			}
		}
		if (barworkerState != 0)
		{
			behaviour.SetTrigger(Employee.IIFLFAJODIL);
			return true;
		}
		if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			Leave();
			return false;
		}
		return false;
	}

	public static Tray IFCJJIKGMBN()
	{
		return GGFJGHHHEJC.trayHandler.tray;
	}

	private void ODMKLAPDDAF(HumanNPC JEBNJPBABBA)
	{
		if ((Object)(object)customerServing != (Object)null && (Object)(object)((Component)JEBNJPBABBA).gameObject == (Object)(object)((Component)customerServing).gameObject)
		{
			customerServing = null;
		}
	}

	private bool CBMLKHOEGCA(Customer PJNGMCJIHME)
	{
		if (PJNGMCJIHME.currentRequest != null && PJNGMCJIHME.currentRequest.JEPBBEBJEFI())
		{
			if (PJNGMCJIHME.currentRequest.KNFNJFFCFNO().JPNFKDMFKMC(DAINLFIMLIH: false) == 154)
			{
				return true;
			}
			return (Object)(object)DrinkDispensersManager.JFNOOMJMHCB().GetDrinkDispenser(PJNGMCJIHME.currentRequest) != (Object)null;
		}
		return false;
	}

	public static bool FBCBNIMEEJC()
	{
		return (Object)(object)GGFJGHHHEJC != (Object)null;
	}

	public bool AFGFJCLADFA()
	{
		if (Bar.instance.waitingAtBar.Any())
		{
			customerServing = LFADBGEIPLN();
			if ((Object)(object)customerServing != (Object)null)
			{
				if (LFPFADGNAHN(customerServing))
				{
					behaviour.SetTrigger(Employee.IIMAJJLHICE);
				}
				else if (MAMFMLCDKLC(customerServing))
				{
					behaviour.SetTrigger(Employee.BKOCCBLGHPB);
				}
			}
		}
		if (barworkerState != 0)
		{
			behaviour.SetTrigger(Employee.IIFLFAJODIL);
			return true;
		}
		if (!TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			Leave();
			return true;
		}
		return false;
	}

	private bool DNAIEKENBLA(Customer PJNGMCJIHME)
	{
		if (PJNGMCJIHME.currentRequest != null && PJNGMCJIHME.currentRequest.JEPBBEBJEFI())
		{
			if (PJNGMCJIHME.currentRequest.LHBPOPOIFLE().JDJGFAACPFC() == 1318)
			{
				return true;
			}
			return (Object)(object)DrinkDispensersManager.GGFJGHHHEJC.GetDrinkDispenser(PJNGMCJIHME.currentRequest) != (Object)null;
		}
		return false;
	}

	public bool NODFMKLGPME()
	{
		if (Bar.instance.waitingAtBar.Any())
		{
			customerServing = LFADBGEIPLN();
			if ((Object)(object)customerServing != (Object)null)
			{
				if (FLONHCEKKPF(customerServing))
				{
					behaviour.SetTrigger(Employee.IIMAJJLHICE);
				}
				else if (HDDCGODGEPE(customerServing))
				{
					behaviour.SetTrigger(Employee.BKOCCBLGHPB);
				}
			}
		}
		if (barworkerState != 0)
		{
			behaviour.SetTrigger(Employee.IIFLFAJODIL);
			return true;
		}
		if (!TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			Leave();
			return false;
		}
		return true;
	}

	public void BarPlaced(int JIIGOACEIKL)
	{
		if (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			behaviour.SetTrigger(Employee.IIFLFAJODIL);
		}
	}

	public override void SetInstance(Employee NAKCFGEAGHH)
	{
		GGFJGHHHEJC = NAKCFGEAGHH as Barworker;
	}

	public bool DEIGGBKICEG()
	{
		if (Bar.instance.waitingAtBar.Any())
		{
			customerServing = GetNextCustomerToServe();
			if ((Object)(object)customerServing != (Object)null)
			{
				if (FLONHCEKKPF(customerServing))
				{
					behaviour.SetTrigger(Employee.IIMAJJLHICE);
				}
				else if (CBMLKHOEGCA(customerServing))
				{
					behaviour.SetTrigger(Employee.BKOCCBLGHPB);
				}
			}
		}
		if (barworkerState != 0)
		{
			behaviour.SetTrigger(Employee.IIFLFAJODIL);
			return true;
		}
		if (!TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			Leave();
			return true;
		}
		return true;
	}

	private void OOEOGNIIAMI(HumanNPC JEBNJPBABBA)
	{
		if ((Object)(object)customerServing != (Object)null && (Object)(object)((Component)JEBNJPBABBA).gameObject == (Object)(object)((Component)customerServing).gameObject)
		{
			customerServing = null;
		}
	}

	private void PNNCHDMNIOF(HumanNPC JEBNJPBABBA)
	{
		if ((Object)(object)customerServing != (Object)null && (Object)(object)((Component)JEBNJPBABBA).gameObject == (Object)(object)((Component)customerServing).gameObject)
		{
			customerServing = null;
		}
	}

	protected override void Awake()
	{
		GGFJGHHHEJC = this;
		base.Awake();
		IgnoreDuringOnline();
	}

	public Customer GetNextCustomerToServe()
	{
		if (!Bar.instance.waitingAtBar.Any())
		{
			return null;
		}
		if (base.JFCLIAFAOEK != null)
		{
			if (base.JFCLIAFAOEK.tasks[0] && base.JFCLIAFAOEK.tasks[1])
			{
				for (int i = 0; i < Bar.instance.waitingAtBar.Count; i++)
				{
					if (FLONHCEKKPF(Bar.instance.waitingAtBar[i].customer))
					{
						return Bar.instance.waitingAtBar[i].customer;
					}
				}
			}
			else if (base.JFCLIAFAOEK.tasks[0])
			{
				for (int j = 0; j < Bar.instance.waitingAtBar.Count; j++)
				{
					if (Bar.instance.waitingAtBar[j].customer.customerState == CustomerState.WaitingAtBar && FLONHCEKKPF(Bar.instance.waitingAtBar[j].customer))
					{
						return Bar.instance.waitingAtBar[j].customer;
					}
				}
			}
			else if (base.JFCLIAFAOEK.tasks[1])
			{
				for (int k = 0; k < Bar.instance.waitingAtBar.Count; k++)
				{
					if (Bar.instance.waitingAtBar[k].customer.customerState == CustomerState.OrderInTable && FLONHCEKKPF(Bar.instance.waitingAtBar[k].customer))
					{
						return Bar.instance.waitingAtBar[k].customer;
					}
				}
			}
		}
		return GetAnotherCustomerWithDrinkRequest();
	}
}
