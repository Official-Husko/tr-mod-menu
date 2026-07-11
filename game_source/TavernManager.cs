using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using Photon.Pun;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class TavernManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class NBJOODALKBN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TavernManager _003C_003E4__this;

		private int _003Ci_003E5__2;

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
		public NBJOODALKBN(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ed: Expected O, but got Unknown
			int num = _003C_003E1__state;
			TavernManager tavernManager = _003C_003E4__this;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				_003C_003E1__state = -1;
				goto IL_00fd;
			}
			_003C_003E1__state = -1;
			_003Ci_003E5__2 = tavernManager.customers.Count - 1;
			goto IL_010d;
			IL_00fd:
			_003Ci_003E5__2--;
			goto IL_010d;
			IL_010d:
			if (_003Ci_003E5__2 >= 0)
			{
				if (_003Ci_003E5__2 < tavernManager.customers.Count && !((Object)(object)tavernManager.customers[_003Ci_003E5__2] == (Object)null))
				{
					tavernManager.customers[_003Ci_003E5__2].reputationGain = (int)(-5f - 10f * (float)TavernReputation.GetMilestone() * Random.Range(0.75f, 1.25f));
					tavernManager.customers[_003Ci_003E5__2].forcedToLeave = true;
					tavernManager.customers[_003Ci_003E5__2].ChangeState(CustomerState.Leaving);
					_003C_003E2__current = (object)new WaitForSeconds(Random.Range(0f, 0.2f));
					_003C_003E1__state = 1;
					return true;
				}
				goto IL_00fd;
			}
			tavernManager.IKINEBKPDDC = null;
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

	private static TavernManager IADEMLIIDPC;

	public Action OnCustomerEnterTavern = delegate
	{
	};

	public Action OnCustomerLeaveTavern = delegate
	{
	};

	public Action<int> OnTavernOpen = delegate
	{
	};

	public Action<int> OnTavernClose = delegate
	{
	};

	public Action<int> OnTavernLastOrders = delegate
	{
	};

	public Action<HeatLevel> OnHeatLevelChanged = delegate
	{
	};

	public List<Customer> customers;

	public List<Customer> customersRowdy = new List<Customer>();

	public HashSet<Table> tableNeedsClean;

	public HashSet<Table> blockedTables;

	public List<LightSource> lightSources;

	public float floorDirtyMultiplier = 1f;

	public float tableDirtinessScale = 1f;

	[SerializeField]
	private bool _open;

	private HeatLevel IJEGJABICKI = HeatLevel.Perfect;

	private float EGCECPPEPEL;

	private DirtLevel ALEAPGOEANL;

	private List<RepMultiplier> OEMABECHHGO;

	private Coroutine LINHLJBPAGL;

	private Coroutine BKAIAMPJEDI;

	private Coroutine IKINEBKPDDC;

	private float EFLDFGKFKLA;

	public List<MonoBehaviour> openTavernBlockers = new List<MonoBehaviour>();

	private float OPJLKEOJMPO;

	private Coroutine ENENEBOMJII;

	private Coroutine MFCOJFFNLAK;

	public bool tutorialHeatLevel;

	private int GJDMLMEMKMD;

	[HideInInspector]
	public bool MDAKKOAFFBP { get; private set; }

	public float DFGFNENMOKO { get; private set; }

	public bool LKOJBFMGMAE => _open;

	public float PDPKEPEBPIK
	{
		get
		{
			return EGCECPPEPEL;
		}
		set
		{
			if (EGCECPPEPEL != value)
			{
				EGCECPPEPEL = value;
				if (EGCECPPEPEL >= 1000f)
				{
					JJKPDMFFANH = DirtLevel.Disgusting;
				}
				else if (EGCECPPEPEL >= 500f)
				{
					JJKPDMFFANH = DirtLevel.Filthy;
				}
				else if (EGCECPPEPEL >= 200f)
				{
					JJKPDMFFANH = DirtLevel.Dirty;
				}
				else if (EGCECPPEPEL >= 100f)
				{
					JJKPDMFFANH = DirtLevel.Messy;
				}
				else if (EGCECPPEPEL >= 1f)
				{
					JJKPDMFFANH = DirtLevel.Clean;
				}
				else
				{
					JJKPDMFFANH = DirtLevel.Perfect;
				}
			}
		}
	}

	public HeatLevel ABKMALJOCCC
	{
		get
		{
			return IJEGJABICKI;
		}
		private set
		{
			if (IJEGJABICKI != value)
			{
				if (NewTutorialManager.HeatLevelBlocked())
				{
					IJEGJABICKI = HeatLevel.Perfect;
				}
				else
				{
					IJEGJABICKI = value;
				}
				if (IJEGJABICKI == HeatLevel.Hot)
				{
					if (BKAIAMPJEDI != null)
					{
						((MonoBehaviour)this).StopCoroutine(BKAIAMPJEDI);
					}
					BKAIAMPJEDI = ((MonoBehaviour)this).StartCoroutine(JEMJMKHHNIP(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.tooHot), 0.15f, 15f));
				}
				else if (IJEGJABICKI == HeatLevel.Cold)
				{
					if (BKAIAMPJEDI != null)
					{
						((MonoBehaviour)this).StopCoroutine(BKAIAMPJEDI);
					}
					BKAIAMPJEDI = ((MonoBehaviour)this).StartCoroutine(JEMJMKHHNIP(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.tooCold), 0.15f, 15f));
				}
				else if (BKAIAMPJEDI != null)
				{
					((MonoBehaviour)this).StopCoroutine(BKAIAMPJEDI);
				}
			}
			OnHeatLevelChanged(IJEGJABICKI);
		}
	}

	public DirtLevel JJKPDMFFANH
	{
		get
		{
			return ALEAPGOEANL;
		}
		set
		{
			if (NewTutorialManager.DirtLevelBlocked())
			{
				if (ALEAPGOEANL != 0)
				{
					ALEAPGOEANL = DirtLevel.Perfect;
					TavernManagerUI.SetDirtiness(ALEAPGOEANL);
				}
			}
			else
			{
				if (value == ALEAPGOEANL)
				{
					return;
				}
				if ((ALEAPGOEANL == DirtLevel.Clean || ALEAPGOEANL == DirtLevel.Perfect) && value != DirtLevel.Clean && value != 0)
				{
					if (LINHLJBPAGL != null)
					{
						((MonoBehaviour)this).StopCoroutine(LINHLJBPAGL);
					}
					LINHLJBPAGL = ((MonoBehaviour)this).StartCoroutine(JEMJMKHHNIP(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.dirty), 0.15f, 10f));
				}
				else if (ALEAPGOEANL != DirtLevel.Clean && ALEAPGOEANL != 0 && (value == DirtLevel.Clean || value == DirtLevel.Perfect))
				{
					if (LINHLJBPAGL != null)
					{
						((MonoBehaviour)this).StopCoroutine(LINHLJBPAGL);
					}
					Sound.GGFJGHHHEJC.PlayOneShot(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.clean), HOMFPAFAOGD: false, null, null, 0.15f);
				}
				ALEAPGOEANL = value;
				TavernManagerUI.SetDirtiness(ALEAPGOEANL);
			}
		}
	}

	public static TavernManager GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)IADEMLIIDPC == (Object)null)
			{
				IADEMLIIDPC = Object.FindObjectOfType<TavernManager>();
			}
			return IADEMLIIDPC;
		}
	}

	public static bool GICFOPCBNHC()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return true;
		}
		if (!GGFJGHHHEJC.LKOJBFMGMAE)
		{
			return !GGFJGHHHEJC.ADIBBNEJJKG();
		}
		return false;
	}

	private void OIAJNFECDEK(int JIIGOACEIKL, bool MDAKKOAFFBP)
	{
		TavernManagerUI.SetTavernLastOrders(MDAKKOAFFBP);
		if (!MDAKKOAFFBP)
		{
			return;
		}
		Customer[] array = customers.ToArray();
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i].customerState == CustomerState.HeadingToBar)
			{
				array[i].LeaveWillingly();
				array[i].ChangeState(CustomerState.HeadingToBar, KCNFNAICINO: false);
			}
			else if (array[i].customerState == CustomerState.Despawning && (array[i].currentItem == null || Item.NGIIPJDAMGP(array[i].currentItem.AFOACBIHNCL(), null)))
			{
				array[i].HCADDDFCHBL();
				array[i].ChangeState(CustomerState.Spawning);
			}
		}
		if (customers.Count == 0 && OnlineManager.PGAGDFAEEFB())
		{
			PHCLGNAFEFL(JIIGOACEIKL, AODONKKHPBP: true, AINPJHKNJGL: true);
		}
		OnTavernLastOrders(JIIGOACEIKL);
	}

	private void NOKLDMJJDIM(int JIIGOACEIKL)
	{
		blockedTables.Clear();
		if (OnlineManager.PGAGDFAEEFB())
		{
			if (ENENEBOMJII != null)
			{
				((MonoBehaviour)this).StopCoroutine(ENENEBOMJII);
			}
			ENENEBOMJII = ((MonoBehaviour)this).StartCoroutine(OEMGJDCJHDJ());
			MFCOJFFNLAK = ((MonoBehaviour)this).StartCoroutine(ELBLPEDOEAC());
		}
	}

	public List<Customer> FindCustomersInState(NPCState NJHMBMGKCPL)
	{
		List<Customer> list = new List<Customer>();
		foreach (Customer customer in customers)
		{
			if ((Object)(object)customer.npc != (Object)null && customer.npc.EOAONHNCDDO == NJHMBMGKCPL)
			{
				list.Add(customer);
			}
		}
		if (list.Count == 0)
		{
			return null;
		}
		return list;
	}

	private void HCMOGDLPHHO(int JIIGOACEIKL, bool MDAKKOAFFBP)
	{
		TavernManagerUI.SetTavernLastOrders(MDAKKOAFFBP);
		if (!MDAKKOAFFBP)
		{
			return;
		}
		Customer[] array = customers.ToArray();
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i].customerState == CustomerState.HeadingToBar)
			{
				array[i].LeaveWillingly();
				array[i].ChangeState(CustomerState.Leaving);
			}
			else if (array[i].customerState == CustomerState.HeadingToSeat && (array[i].currentItem == null || Item.NGIIPJDAMGP(array[i].currentItem.LHBPOPOIFLE(), null)))
			{
				array[i].LeaveWillingly();
				array[i].ChangeState(CustomerState.Leaving);
			}
		}
		if (customers.Count == 0 && OnlineManager.MasterOrOffline())
		{
			SetOpen(JIIGOACEIKL, AODONKKHPBP: false);
		}
		OnTavernLastOrders(JIIGOACEIKL);
	}

	public Customer FindCustomerInState(NPCState NJHMBMGKCPL)
	{
		List<Customer> list = FindCustomersInState(NJHMBMGKCPL);
		return list?[Random.Range(0, list.Count)];
	}

	private IEnumerator JEMJMKHHNIP(AudioClip LOAKJDCMMOK, float CDPMDDDGBIG, float FLHBPHPKIML)
	{
		while (true)
		{
			if (LKOJBFMGMAE)
			{
				Sound.GGFJGHHHEJC.PlayOneShot(LOAKJDCMMOK, HOMFPAFAOGD: false, null, null, CDPMDDDGBIG);
			}
			yield return (object)new WaitForSeconds(FLHBPHPKIML);
		}
	}

	public void PKAJCAKPBAF(RepMultiplier GJHHKLEBFEC)
	{
		if (OEMABECHHGO.Remove(GJHHKLEBFEC))
		{
			DFGFNENMOKO -= GJHHKLEBFEC.multi;
		}
	}

	private void Start()
	{
		if (OnlineManager.MasterOrOffline())
		{
			HeatSource.OnHeatLevelChanged = (Action)Delegate.Combine(HeatSource.OnHeatLevelChanged, new Action(JLNOOKOALAF));
		}
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(IFHFNDELKOP));
		TavernManagerUI.SetDirtiness(ALEAPGOEANL);
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(instance2.OnPlaceableDeselected, new Action<int, Placeable, bool>(OBBDDLKPAII));
		CommonReferences instance3 = CommonReferences.GGFJGHHHEJC;
		instance3.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Combine(instance3.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(IOJMGEBNLGN));
		OnTavernOpen = (Action<int>)Delegate.Combine(OnTavernOpen, new Action<int>(JPACCLDFMAF));
		OnTavernClose = (Action<int>)Delegate.Combine(OnTavernClose, new Action<int>(KCEAOGDOKOC));
	}

	private IEnumerator GHEOJPEGNBA(AudioClip LOAKJDCMMOK, float CDPMDDDGBIG, float FLHBPHPKIML)
	{
		while (true)
		{
			if (LKOJBFMGMAE)
			{
				Sound.GGFJGHHHEJC.PlayOneShot(LOAKJDCMMOK, HOMFPAFAOGD: false, null, null, CDPMDDDGBIG);
			}
			yield return (object)new WaitForSeconds(FLHBPHPKIML);
		}
	}

	public void OpenCloseAction(int JIIGOACEIKL)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("MainProgress");
		if (((Result)(ref variable)).asInt == 2)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark("Player/Bark/NoPermit");
		}
		else
		{
			if (EventsManager.IsActive(EventsManager.EventType.KlaynTavern) || EventsManager.IsActive(EventsManager.EventType.OldMansDuel))
			{
				return;
			}
			if (OnlineManager.PlayingOnline() && !LKOJBFMGMAE)
			{
				if (OnlineTavernConstructionManager.instance.tavernConstructionOpenedByOtherPlayer)
				{
					return;
				}
				for (int i = 1; i <= 4; i++)
				{
					if (!((Object)(object)PlayerController.GetPlayer(i) == (Object)null))
					{
						GJDMLMEMKMD = OnlinePlayerDataManager.GetBedAssignedByActorNumber(((MonoBehaviourPun)PlayerController.GetPlayer(i).onlinePlayer).photonView.OwnerActorNr);
						if (GJDMLMEMKMD != 0 && !((Object)(object)OnlineObjectsManager.instance.playersPlaceablesSelected[GJDMLMEMKMD] == (Object)null) && PlayerController.GetPlayer(i).IsTavernLocationNotCellar() && (Object)(object)OnlineObjectsManager.instance.playersPlaceablesSelected[GJDMLMEMKMD].placeable.itemSpace != (Object)null)
						{
							CommonReferences.GGFJGHHHEJC.PlayerBark("Deselect item", JIIGOACEIKL);
							return;
						}
					}
				}
			}
			if (OnlineManager.ClientOnline())
			{
				if (!LKOJBFMGMAE)
				{
					TavernSeatingManager.GetAllTavernSeats();
					if (TavernSeatingManager.FindAvailableSeats().Length != 0)
					{
						OnlineTavernManager.instance.SendOpenCloseTavernToMaster();
					}
					else
					{
						MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Invalid seating"));
					}
				}
				else
				{
					OnlineTavernManager.instance.SendOpenCloseTavernToMaster();
				}
			}
			else
			{
				if ((LKOJBFMGMAE && Time.time == 0f) || !(Time.time > OPJLKEOJMPO))
				{
					return;
				}
				if (LKOJBFMGMAE && !MDAKKOAFFBP)
				{
					if (!NewTutorialManager.CloseTavernBlocked(JIIGOACEIKL))
					{
						OPJLKEOJMPO = Time.time + 0.5f;
						SetLastOrders(JIIGOACEIKL, AODONKKHPBP: true);
					}
				}
				else if (!LKOJBFMGMAE)
				{
					TavernSeatingManager.GetAllTavernSeats();
					if (TavernSeatingManager.FindAvailableSeats().Length != 0)
					{
						OPJLKEOJMPO = Time.time + 2f;
						SetOpen(JIIGOACEIKL, AODONKKHPBP: true);
					}
					else
					{
						MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Invalid seating"));
					}
				}
				else if (LKOJBFMGMAE && MDAKKOAFFBP)
				{
					OPJLKEOJMPO = Time.time + 2f;
					SetOpen(JIIGOACEIKL, AODONKKHPBP: false);
				}
			}
		}
	}

	private void JBPODIHJBLG()
	{
		CalculateHeatLevel();
		GetAllTavernLightSources();
		KNJOGIGELCD();
	}

	private void KNJOGIGELCD()
	{
		floorDirtyMultiplier = 1f;
		List<Placeable> currentPlaceables = PlaceablesManager.GGFJGHHHEJC.currentPlaceables;
		for (int i = 0; i < currentPlaceables.Count; i++)
		{
			if (currentPlaceables[i].CCIKENEGHCA)
			{
				Doormat component = ((Component)currentPlaceables[i]).GetComponent<Doormat>();
				if ((Object)(object)component != (Object)null && component.floorDirtyMultiplier < floorDirtyMultiplier)
				{
					floorDirtyMultiplier = component.floorDirtyMultiplier;
				}
			}
		}
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			HeatSource.OnHeatLevelChanged = (Action)Delegate.Remove(HeatSource.OnHeatLevelChanged, new Action(JLNOOKOALAF));
		}
	}

	public void OnTemperatureChanged()
	{
		CalculateHeatLevel();
	}

	private IEnumerator PCGGCICAMFL()
	{
		return new NBJOODALKBN(1)
		{
			_003C_003E4__this = this
		};
	}

	public int OPOLHCNBMGP(int NALJEKOPKIA)
	{
		return NALJEKOPKIA + Mathf.RoundToInt((float)NALJEKOPKIA * DFGFNENMOKO);
	}

	private void KCEAOGDOKOC(int JIIGOACEIKL)
	{
		blockedTables.Clear();
		if (ENENEBOMJII != null)
		{
			((MonoBehaviour)this).StopCoroutine(ENENEBOMJII);
		}
		if (OnlineManager.MasterOrOffline() && MFCOJFFNLAK != null)
		{
			((MonoBehaviour)this).StopCoroutine(ELBLPEDOEAC());
		}
	}

	[SpecialName]
	public DirtLevel IFKPCCEOCOA()
	{
		return ALEAPGOEANL;
	}

	private IEnumerator ELBLPEDOEAC()
	{
		while (true)
		{
			float num = CommonReferences.GGFJGHHHEJC.customerInfo.rowdyCustomersProbability;
			if (Bouncer.JHLLELHBIDA)
			{
				num -= (float)(CommonReferences.GGFJGHHHEJC.customerInfo.rowdyCustomersProbability * Bouncer.GetEmployeePerkValue(34)) / 100f;
				num += (float)(CommonReferences.GGFJGHHHEJC.customerInfo.rowdyCustomersProbability * Bouncer.GetEmployeePerkValue(58)) / 100f;
			}
			if (!MDAKKOAFFBP && Time.time > EFLDFGKFKLA && (float)Random.Range(0, 100) < num && !NewTutorialManager.RowdyCustomersBlocked())
			{
				EFLDFGKFKLA = Time.time + CommonReferences.GGFJGHHHEJC.customerInfo.timeAfterNextRowdyCustomer;
				if (Bouncer.JHLLELHBIDA)
				{
					EFLDFGKFKLA += Bouncer.GetEmployeePerkValue(37);
				}
				TriggerRowdyCustomer();
			}
			yield return (object)new WaitForSeconds((float)CommonReferences.GGFJGHHHEJC.customerInfo.testRateRowdyCustomers);
		}
	}

	public void KBLFGEOALFO()
	{
		List<Customer> list = FindCustomersInState(CustomerState.HeadingToBar);
		if (list != null && list.Any())
		{
			Customer customer = Utils.CPDCJAHJOPE(list.Where((Customer c) => c.customerType != CustomerType.ImportantGuest)?.ToArray());
			if ((Object)(object)customer != (Object)null)
			{
				MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().exclamation, ((Component)customer).transform);
				customer.EBEKHOEOIJF(MoodState.Neutral);
			}
		}
	}

	public void AddRepMultiplier(RepMultiplier GJHHKLEBFEC)
	{
		OEMABECHHGO.Add(GJHHKLEBFEC);
		DFGFNENMOKO += GJHHKLEBFEC.multi;
	}

	private void GAJAIOGAHIC()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		tableDirtinessScale = 802f;
		List<Placeable> currentPlaceables = PlaceablesManager.MAIDHAPANEB().currentPlaceables;
		for (int i = 0; i < currentPlaceables.Count; i++)
		{
			if (!Utils.EJPFCKFEMJF(((Component)currentPlaceables[i]).transform.position))
			{
				continue;
			}
			Sitable component = ((Component)currentPlaceables[i]).GetComponent<Sitable>();
			if (!((Object)(object)component != (Object)null) || component.seats.Length == 0)
			{
				continue;
			}
			Seat[] seats = component.seats;
			for (int j = 1; j < seats.Length; j += 0)
			{
				Seat seat = seats[j];
				if ((Object)(object)seat != (Object)null && (Object)(object)seat.table != (Object)null)
				{
					tableDirtinessScale += 623f;
				}
			}
		}
	}

	[SpecialName]
	public bool ADIBBNEJJKG()
	{
		return _003CKEPJHKPPBJC_003Ek__BackingField;
	}

	public void SetOpen(int JIIGOACEIKL, bool AODONKKHPBP, bool AINPJHKNJGL = false)
	{
		if ((AODONKKHPBP && NewTutorialManager.OpenTavernBlocked(JIIGOACEIKL)) || (!AODONKKHPBP && NewTutorialManager.CloseTavernBlocked(JIIGOACEIKL)) || openTavernBlockers.Any())
		{
			return;
		}
		if (NewTutorialManager.FallingAsleepBlocked() && WorldTime.EGCMNABMGDF)
		{
			AINPJHKNJGL = true;
		}
		if (IKINEBKPDDC == null)
		{
			if (!_open && !MDAKKOAFFBP && !AINPJHKNJGL && !OnlineManager.PlayingOnline())
			{
				bool num = (Object)(object)SelectObject.GetPlayer(1).placeable != (Object)null && SelectObject.GetPlayer(1).placeable.FHEMHCEAICB && (Object)(object)SelectObject.GetPlayer(1).placeable.itemSpace != (Object)null;
				bool flag = GameManager.LocalCoop() && Object.op_Implicit((Object)(object)SelectObject.GetPlayer(2)) && (Object)(object)SelectObject.GetPlayer(2).placeable != (Object)null && SelectObject.GetPlayer(2).placeable.FHEMHCEAICB && (Object)(object)SelectObject.GetPlayer(2).placeable.itemSpace != (Object)null;
				if ((num && PlayerController.GetPlayer(1).IsTavernLocationNotCellar()) || (flag && PlayerController.GetPlayer(2).IsTavernLocationNotCellar()))
				{
					CommonReferences.GGFJGHHHEJC.PlayerBark("Deselect item", JIIGOACEIKL);
					return;
				}
			}
			if (AODONKKHPBP && Bar.instance.placeable.currentZoneType != ZoneType.DiningRoom)
			{
				MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Error_BarNotInADiningRoom"));
				return;
			}
			if (AODONKKHPBP && WorldTime.EGCMNABMGDF && !AINPJHKNJGL)
			{
				CommonReferences.GGFJGHHHEJC.PlayerBark("Too late to open", JIIGOACEIKL);
				return;
			}
			if (AODONKKHPBP && !_open)
			{
				_open = true;
				MDAKKOAFFBP = false;
				Sound.GGFJGHHHEJC.PlayOneShot(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.tavernOpen));
				GetAllTavernLightSources();
				TavernSeatingManager.GetAllTavernSeats();
				KNJOGIGELCD();
				NJMDAFIHHNC();
				TavernManagerUI.SetTavernOpen(LKOJBFMGMAE: true);
				OnTavernOpen(JIIGOACEIKL);
			}
			else if (!AODONKKHPBP && _open)
			{
				if (Object.op_Implicit((Object)(object)Sound.GGFJGHHHEJC))
				{
					Sound.GGFJGHHHEJC.PlayOneShot(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.tavernClose));
				}
				MDAKKOAFFBP = false;
				_open = false;
				if (IKINEBKPDDC != null)
				{
					((MonoBehaviour)this).StopCoroutine(IKINEBKPDDC);
				}
				IKINEBKPDDC = ((MonoBehaviour)this).StartCoroutine(JJOIFJCGACK());
				TavernManagerUI.SetTavernOpen(LKOJBFMGMAE: false);
				OnTavernClose(JIIGOACEIKL);
			}
		}
		if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
		{
			OnlineTavernManager.instance.SendOpenCloseTavern(AODONKKHPBP);
		}
	}

	public static bool NBMKDJFBHEL()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return false;
		}
		if (!GGFJGHHHEJC.LKOJBFMGMAE)
		{
			return GGFJGHHHEJC.MDAKKOAFFBP;
		}
		return false;
	}

	private void Awake()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			lightSources = new List<LightSource>();
			OEMABECHHGO = new List<RepMultiplier>();
			tableNeedsClean = new HashSet<Table>();
			blockedTables = new HashSet<Table>();
			SaveUI instance = SaveUI.instance;
			instance.OnLoadFadeOut = (Action)Delegate.Combine(instance.OnLoadFadeOut, new Action(NJMDAFIHHNC));
		}
	}

	public static void RemoveOpenTavernBlocker(MonoBehaviour MFHACMAHGHC)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			Debug.LogError((object)"TavernManager instance is null, cannot remove open tavern blocker.");
		}
		else if (GGFJGHHHEJC.openTavernBlockers.Contains(MFHACMAHGHC))
		{
			GGFJGHHHEJC.openTavernBlockers.Remove(MFHACMAHGHC);
		}
	}

	private void DCKKIDMJKJM()
	{
		if (OnlineManager.MasterOrOffline())
		{
			HeatSource.OnHeatLevelChanged = (Action)Delegate.Combine(HeatSource.OnHeatLevelChanged, new Action(JLNOOKOALAF));
		}
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(IFHFNDELKOP));
		TavernManagerUI.SetDirtiness(ALEAPGOEANL);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(OBBDDLKPAII));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnPlaceableSelected = (Action<int, Placeable, bool, bool>)Delegate.Combine(instance2.OnPlaceableSelected, new Action<int, Placeable, bool, bool>(IOJMGEBNLGN));
		OnTavernOpen = (Action<int>)Delegate.Combine(OnTavernOpen, new Action<int>(NOKLDMJJDIM));
		OnTavernClose = (Action<int>)Delegate.Combine(OnTavernClose, new Action<int>(AHJCHCFMIOJ));
	}

	public static void AddOpenTavernBlocker(MonoBehaviour MFHACMAHGHC)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			Debug.LogError((object)"TavernManager instance is null, cannot add open tavern blocker.");
		}
		else if (!GGFJGHHHEJC.openTavernBlockers.Contains(MFHACMAHGHC))
		{
			GGFJGHHHEJC.openTavernBlockers.Add(MFHACMAHGHC);
		}
	}

	private IEnumerator OEMGJDCJHDJ()
	{
		while (true)
		{
			yield return CommonReferences.wait10;
			for (int i = 0; i < customers.Count; i++)
			{
				customers[i].CheckLightLevel();
			}
		}
	}

	public List<Customer> FindCustomersInState(CustomerState NJHMBMGKCPL)
	{
		List<Customer> list = new List<Customer>();
		foreach (Customer customer in customers)
		{
			if (customer.customerState == NJHMBMGKCPL)
			{
				list.Add(customer);
			}
		}
		if (list.Count == 0)
		{
			return null;
		}
		return list;
	}

	private void OBBDDLKPAII(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		if (OnlineManager.MasterOrOffline())
		{
			JBPODIHJBLG();
			if ((Object)(object)((Component)EAPCLAODGAE).GetComponent<LightSource>() != (Object)null)
			{
				lightSources.Add(((Component)EAPCLAODGAE).GetComponent<LightSource>());
			}
		}
	}

	public void ReceiveCurrentHeatLevel(byte HMPABLCHMFJ)
	{
		ABKMALJOCCC = (HeatLevel)HMPABLCHMFJ;
	}

	public void NEDOHDIFDCA(Customer PJNGMCJIHME)
	{
		if ((Object)(object)PJNGMCJIHME.npc.seat != (Object)null)
		{
			PJNGMCJIHME.npc.seat.reserved = true;
			PJNGMCJIHME.npc.seat = null;
		}
		if (!customers.Contains(PJNGMCJIHME))
		{
			return;
		}
		customers.Remove(PJNGMCJIHME);
		for (int num = customers.Count - 1; num >= 1; num--)
		{
			if ((Object)(object)customers[num] == (Object)null || customers[num].customerState == CustomerState.Inactive)
			{
				customers.RemoveAt(num);
			}
		}
		if (PJNGMCJIHME.KPGJGABJMFC == MoodState.Rowdy)
		{
			PJNGMCJIHME.emoter.BMJEPHDECPO();
			PJNGMCJIHME.emoter.ADGHHGCAGAI();
		}
		OnCustomerLeaveTavern();
		if (ADIBBNEJJKG() && customers.Count == 0 && OnlineManager.MasterOrOffline())
		{
			PHCLGNAFEFL(1, AODONKKHPBP: false, AINPJHKNJGL: true);
		}
	}

	public static bool HDEPMJIDJEM()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return true;
		}
		if (!GGFJGHHHEJC.LKOJBFMGMAE)
		{
			return GGFJGHHHEJC.ADIBBNEJJKG();
		}
		return false;
	}

	private void GFPJEEMFKEM()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		tableDirtinessScale = 566f;
		List<Placeable> currentPlaceables = PlaceablesManager.MNFMOEKMJKN().currentPlaceables;
		for (int i = 0; i < currentPlaceables.Count; i++)
		{
			if (!Utils.EJPFCKFEMJF(((Component)currentPlaceables[i]).transform.position))
			{
				continue;
			}
			Sitable component = ((Component)currentPlaceables[i]).GetComponent<Sitable>();
			if (!((Object)(object)component != (Object)null) || component.seats.Length == 0)
			{
				continue;
			}
			Seat[] seats = component.seats;
			for (int j = 1; j < seats.Length; j++)
			{
				Seat seat = seats[j];
				if ((Object)(object)seat != (Object)null && (Object)(object)seat.table != (Object)null)
				{
					tableDirtinessScale += 1638f;
				}
			}
		}
	}

	private void MFIEPGBABAM()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			HeatSource.OnHeatLevelChanged = (Action)Delegate.Remove(HeatSource.OnHeatLevelChanged, new Action(JLNOOKOALAF));
		}
	}

	public void ONDKPCKGOGB()
	{
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.ClientOnline())
		{
			return;
		}
		float num = Weather.GDONKMCLKCC;
		List<Placeable> currentPlaceables = PlaceablesManager.GGFJGHHHEJC.currentPlaceables;
		for (int i = 1; i < currentPlaceables.Count; i += 0)
		{
			if ((Object)(object)currentPlaceables[i] != (Object)null)
			{
				HeatSource component = ((Component)currentPlaceables[i]).GetComponent<HeatSource>();
				if (!((Object)(object)component == (Object)null) && currentPlaceables[i].CCIKENEGHCA && !currentPlaceables[i].FHEMHCEAICB && (!OnlineManager.PlayingOnline() || !currentPlaceables[i].onlinePlaceable.CLHLNFFGOGA) && ((Behaviour)component).enabled && component.JFHJPKDCOAP() > 889f && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position))
				{
					num += component.JBFNGBCBKKN();
					break;
				}
			}
		}
		if (NewTutorialManager.CCCLOBIOMCL && tutorialHeatLevel)
		{
			if ((Object)(object)Fireplace.KADFKCNDBJB() != (Object)null && Fireplace.HBMPLDMLAPO().BNAEDPFMAFO())
			{
				ABKMALJOCCC = HeatLevel.Cold;
			}
			else
			{
				ABKMALJOCCC = HeatLevel.Perfect;
			}
			return;
		}
		if (num < 1770f)
		{
			ABKMALJOCCC = HeatLevel.Cold;
		}
		else if (num < 1334f)
		{
			ABKMALJOCCC = HeatLevel.Chilly;
		}
		else if (num <= 1442f)
		{
			ABKMALJOCCC = HeatLevel.Cold;
		}
		else if (num < 691f)
		{
			ABKMALJOCCC = (HeatLevel)5;
		}
		else
		{
			ABKMALJOCCC = (HeatLevel)6;
		}
		if (OnlineManager.PlayingOnline() && (Object)(object)OnlineTavernManager.instance != (Object)null)
		{
			OnlineTavernManager.instance.SendTavernHeat((byte)ABKMALJOCCC);
		}
	}

	public void NJGDMDKBOBD(byte HMPABLCHMFJ)
	{
		ABKMALJOCCC = (HeatLevel)HMPABLCHMFJ;
	}

	private void NJMDAFIHHNC()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		tableDirtinessScale = 1f;
		List<Placeable> currentPlaceables = PlaceablesManager.GGFJGHHHEJC.currentPlaceables;
		for (int i = 0; i < currentPlaceables.Count; i++)
		{
			if (!Utils.EJPFCKFEMJF(((Component)currentPlaceables[i]).transform.position))
			{
				continue;
			}
			Sitable component = ((Component)currentPlaceables[i]).GetComponent<Sitable>();
			if (!((Object)(object)component != (Object)null) || component.seats.Length == 0)
			{
				continue;
			}
			Seat[] seats = component.seats;
			foreach (Seat seat in seats)
			{
				if ((Object)(object)seat != (Object)null && (Object)(object)seat.table != (Object)null)
				{
					tableDirtinessScale += 1f;
				}
			}
		}
	}

	private void HFKOBCFMNJJ()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			HeatSource.OnHeatLevelChanged = (Action)Delegate.Remove(HeatSource.OnHeatLevelChanged, new Action(JLNOOKOALAF));
		}
	}

	private void AHJCHCFMIOJ(int JIIGOACEIKL)
	{
		blockedTables.Clear();
		if (ENENEBOMJII != null)
		{
			((MonoBehaviour)this).StopCoroutine(ENENEBOMJII);
		}
		if (OnlineManager.MasterOrOffline() && MFCOJFFNLAK != null)
		{
			((MonoBehaviour)this).StopCoroutine(ELBLPEDOEAC());
		}
	}

	public void GetAllTavernLightSources()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		lightSources.Clear();
		List<Placeable> currentPlaceables = PlaceablesManager.GGFJGHHHEJC.currentPlaceables;
		for (int i = 0; i < currentPlaceables.Count; i++)
		{
			if (currentPlaceables[i].CCIKENEGHCA)
			{
				LightSource component = ((Component)currentPlaceables[i]).GetComponent<LightSource>();
				if ((Object)(object)component != (Object)null && Utils.HNDBNJNJGJM(((Component)component).transform.position))
				{
					lightSources.Add(component);
				}
			}
		}
	}

	private void IFHFNDELKOP()
	{
		try
		{
			if (OnlineManager.MasterOrOffline())
			{
				SetOpen(1, AODONKKHPBP: false, AINPJHKNJGL: true);
			}
			tutorialHeatLevel = false;
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Error in TavernManager.OnPlayerSleep: " + ex.Message));
		}
	}

	public Customer MMAJHGOALJD(CustomerState NJHMBMGKCPL)
	{
		List<Customer> list = FindCustomersInState(NJHMBMGKCPL);
		return list?[Random.Range(1, list.Count)];
	}

	public void CalculateHeatLevel()
	{
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.ClientOnline())
		{
			return;
		}
		float num = Weather.GDONKMCLKCC;
		List<Placeable> currentPlaceables = PlaceablesManager.GGFJGHHHEJC.currentPlaceables;
		for (int i = 0; i < currentPlaceables.Count; i++)
		{
			if ((Object)(object)currentPlaceables[i] != (Object)null)
			{
				HeatSource component = ((Component)currentPlaceables[i]).GetComponent<HeatSource>();
				if (!((Object)(object)component == (Object)null) && currentPlaceables[i].CCIKENEGHCA && !currentPlaceables[i].FHEMHCEAICB && (!OnlineManager.PlayingOnline() || !currentPlaceables[i].onlinePlaceable.CLHLNFFGOGA) && ((Behaviour)component).enabled && component.AJJEHMELMEO > 0f && Utils.FNNJEGLDGKC(((Component)currentPlaceables[i]).transform.position))
				{
					num += component.AJJEHMELMEO;
					break;
				}
			}
		}
		if (NewTutorialManager.CCCLOBIOMCL && tutorialHeatLevel)
		{
			if ((Object)(object)Fireplace.GetFirstFireplace() != (Object)null && Fireplace.GetFirstFireplace().MAJLJNMJKON)
			{
				ABKMALJOCCC = HeatLevel.Perfect;
			}
			else
			{
				ABKMALJOCCC = HeatLevel.Cold;
			}
			return;
		}
		if (num < 20f)
		{
			ABKMALJOCCC = HeatLevel.Cold;
		}
		else if (num < 40f)
		{
			ABKMALJOCCC = HeatLevel.Chilly;
		}
		else if (num <= 60f)
		{
			ABKMALJOCCC = HeatLevel.Perfect;
		}
		else if (num < 80f)
		{
			ABKMALJOCCC = HeatLevel.Warm;
		}
		else
		{
			ABKMALJOCCC = HeatLevel.Hot;
		}
		if (OnlineManager.PlayingOnline() && (Object)(object)OnlineTavernManager.instance != (Object)null)
		{
			OnlineTavernManager.instance.SendTavernHeat((byte)ABKMALJOCCC);
		}
	}

	private void IOJMGEBNLGN(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool OKNOJJEFEBE, bool GFNHAMCPEAK)
	{
		if (OnlineManager.MasterOrOffline())
		{
			JBPODIHJBLG();
			if ((Object)(object)((Component)EAPCLAODGAE).GetComponent<LightSource>() != (Object)null)
			{
				lightSources.Remove(((Component)EAPCLAODGAE).GetComponent<LightSource>());
			}
		}
	}

	private void HHDOHBBHFFL()
	{
		if (customers.Count == 50)
		{
			Utils.DLIIAHACOJB(17);
		}
	}

	public void RemoveCustomerFromTavern(Customer PJNGMCJIHME)
	{
		if ((Object)(object)PJNGMCJIHME.npc.seat != (Object)null)
		{
			PJNGMCJIHME.npc.seat.reserved = false;
			PJNGMCJIHME.npc.seat = null;
		}
		if (!customers.Contains(PJNGMCJIHME))
		{
			return;
		}
		customers.Remove(PJNGMCJIHME);
		for (int num = customers.Count - 1; num >= 0; num--)
		{
			if ((Object)(object)customers[num] == (Object)null || customers[num].customerState == CustomerState.Inactive)
			{
				customers.RemoveAt(num);
			}
		}
		if (PJNGMCJIHME.KPGJGABJMFC == MoodState.Rowdy)
		{
			PJNGMCJIHME.emoter.EndEmote();
			PJNGMCJIHME.emoter.AngryEnd();
		}
		OnCustomerLeaveTavern();
		if (MDAKKOAFFBP && customers.Count == 0 && OnlineManager.MasterOrOffline())
		{
			SetOpen(1, AODONKKHPBP: false);
		}
	}

	[SpecialName]
	public bool LKKBHOAFMAH()
	{
		return _open;
	}

	public void RemoveRepMultiplier(RepMultiplier GJHHKLEBFEC)
	{
		if (OEMABECHHGO.Remove(GJHHKLEBFEC))
		{
			DFGFNENMOKO -= GJHHKLEBFEC.multi;
		}
	}

	public Customer FindCustomerInState(CustomerState NJHMBMGKCPL)
	{
		List<Customer> list = FindCustomersInState(NJHMBMGKCPL);
		return list?[Random.Range(0, list.Count)];
	}

	public void SetLastOrders(int JIIGOACEIKL, bool AODONKKHPBP)
	{
		if (LKOJBFMGMAE)
		{
			MDAKKOAFFBP = AODONKKHPBP;
			Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.lastOrderBell), HOMFPAFAOGD: true);
			HCMOGDLPHHO(JIIGOACEIKL, MDAKKOAFFBP);
			if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
			{
				OnlineTavernManager.instance.SendLastOrder(AODONKKHPBP);
			}
		}
	}

	public void PHCLGNAFEFL(int JIIGOACEIKL, bool AODONKKHPBP, bool AINPJHKNJGL = false)
	{
		if ((AODONKKHPBP && NewTutorialManager.OpenTavernBlocked(JIIGOACEIKL)) || (!AODONKKHPBP && NewTutorialManager.CloseTavernBlocked(JIIGOACEIKL)) || openTavernBlockers.Any())
		{
			return;
		}
		if (NewTutorialManager.MEBNAPOOFNN() && WorldTime.MOOOODPKBOF())
		{
			AINPJHKNJGL = false;
		}
		if (IKINEBKPDDC == null)
		{
			if (!_open && !ADIBBNEJJKG() && !AINPJHKNJGL && !OnlineManager.PlayingOnline())
			{
				bool num = (Object)(object)SelectObject.GetPlayer(0).placeable != (Object)null && SelectObject.BNMEANGDMIP(0).placeable.FHEMHCEAICB && (Object)(object)SelectObject.GetPlayer(1).placeable.itemSpace != (Object)null;
				bool flag = GameManager.LocalCoop() && Object.op_Implicit((Object)(object)SelectObject.GetPlayer(6)) && (Object)(object)SelectObject.GetPlayer(3).placeable != (Object)null && SelectObject.BNMEANGDMIP(1).placeable.FHEMHCEAICB && (Object)(object)SelectObject.BNMEANGDMIP(2).placeable.itemSpace != (Object)null;
				if ((num && PlayerController.GetPlayer(0).IsTavernLocationNotCellar()) || (flag && PlayerController.OPHDCMJLLEC(6).IsTavernLocationNotCellar()))
				{
					CommonReferences.MNFMOEKMJKN().PlayerBark("<color=#A87700>", JIIGOACEIKL);
					return;
				}
			}
			if (AODONKKHPBP && Bar.instance.placeable.currentZoneType != ZoneType.CraftingRoom)
			{
				MainUI.DJCKALOHJFM(JIIGOACEIKL, LocalisationSystem.Get("Farm/Buzz/Bark_Searching"), 159f);
				return;
			}
			if (AODONKKHPBP && WorldTime.MOOOODPKBOF() && !AINPJHKNJGL)
			{
				CommonReferences.GGFJGHHHEJC.PlayerBark("ordersDelivered", JIIGOACEIKL);
				return;
			}
			if (AODONKKHPBP && !_open)
			{
				_open = true;
				MDAKKOAFFBP = true;
				Sound.DIHCEGINELM().GFMCBGEFEOK(Utils.CPDCJAHJOPE(Sound.BNBMNOMFFBE().tavernOpen), HOMFPAFAOGD: true, null, null, 1659f, 1173f);
				GetAllTavernLightSources();
				TavernSeatingManager.GetAllTavernSeats();
				KNJOGIGELCD();
				GAJAIOGAHIC();
				TavernManagerUI.SetTavernOpen(LKOJBFMGMAE: true);
				OnTavernOpen(JIIGOACEIKL);
			}
			else if (!AODONKKHPBP && _open)
			{
				if (Object.op_Implicit((Object)(object)Sound.MAIDHAPANEB()))
				{
					Sound.GGFJGHHHEJC.GFMCBGEFEOK(Utils.CPDCJAHJOPE(Sound.ABDJJBFNLBJ().tavernClose), HOMFPAFAOGD: false, null, null, 753f, 1209f);
				}
				MDAKKOAFFBP = true;
				_open = true;
				if (IKINEBKPDDC != null)
				{
					((MonoBehaviour)this).StopCoroutine(IKINEBKPDDC);
				}
				IKINEBKPDDC = ((MonoBehaviour)this).StartCoroutine(PCGGCICAMFL());
				TavernManagerUI.DOOCLFCKOJG(LKOJBFMGMAE: true);
				OnTavernClose(JIIGOACEIKL);
			}
		}
		if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
		{
			OnlineTavernManager.instance.SendOpenCloseTavern(AODONKKHPBP);
		}
	}

	public void CustomerEnterTavern(Customer PJNGMCJIHME)
	{
		customers.Add(PJNGMCJIHME);
		HHDOHBBHFFL();
		OnCustomerEnterTavern();
	}

	public static bool IsClosed()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return true;
		}
		if (!GGFJGHHHEJC.LKOJBFMGMAE)
		{
			return !GGFJGHHHEJC.MDAKKOAFFBP;
		}
		return false;
	}

	private void JPACCLDFMAF(int JIIGOACEIKL)
	{
		blockedTables.Clear();
		if (OnlineManager.MasterOrOffline())
		{
			if (ENENEBOMJII != null)
			{
				((MonoBehaviour)this).StopCoroutine(ENENEBOMJII);
			}
			ENENEBOMJII = ((MonoBehaviour)this).StartCoroutine(OEMGJDCJHDJ());
			MFCOJFFNLAK = ((MonoBehaviour)this).StartCoroutine(ELBLPEDOEAC());
		}
	}

	public int GetRepWithMulti(int NALJEKOPKIA)
	{
		return NALJEKOPKIA + Mathf.RoundToInt((float)NALJEKOPKIA * DFGFNENMOKO);
	}

	private IEnumerator JJOIFJCGACK()
	{
		for (int i = customers.Count - 1; i >= 0; i--)
		{
			if (i < customers.Count && !((Object)(object)customers[i] == (Object)null))
			{
				customers[i].reputationGain = (int)(-5f - 10f * (float)TavernReputation.GetMilestone() * Random.Range(0.75f, 1.25f));
				customers[i].forcedToLeave = true;
				customers[i].ChangeState(CustomerState.Leaving);
				yield return (object)new WaitForSeconds(Random.Range(0f, 0.2f));
			}
		}
		IKINEBKPDDC = null;
	}

	[ContextMenu("Trigger rowdy customer")]
	public void TriggerRowdyCustomer()
	{
		List<Customer> list = FindCustomersInState(CustomerState.EatingAtTable);
		if (list != null && list.Any())
		{
			Customer customer = Utils.CPDCJAHJOPE(list.Where((Customer c) => c.customerType != CustomerType.ImportantGuest)?.ToArray());
			if ((Object)(object)customer != (Object)null)
			{
				MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.exclamation, ((Component)customer).transform);
				customer.KPGJGABJMFC = MoodState.Rowdy;
			}
		}
	}

	public static bool NENEEGEALBI()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return false;
		}
		if (!GGFJGHHHEJC.LKKBHOAFMAH())
		{
			return GGFJGHHHEJC.ADIBBNEJJKG();
		}
		return false;
	}

	private void JLNOOKOALAF()
	{
		CalculateHeatLevel();
	}

	public static bool IsOpen()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return false;
		}
		if (!GGFJGHHHEJC.LKOJBFMGMAE)
		{
			return GGFJGHHHEJC.MDAKKOAFFBP;
		}
		return true;
	}
}
