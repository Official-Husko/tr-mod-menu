using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class StaffManager : MonoBehaviour
{
	[Serializable]
	public struct StaffGenerationValues
	{
		public int reputation;

		public int prob1Perk;

		public Vector2Int lvlRangePerk1;

		public int prob2Perk;

		public Vector2Int lvlRangePerk2;

		public int prob3Perk;

		public Vector2Int lvlRangePerk3;
	}

	[CompilerGenerated]
	private sealed class POMDNNAMOJJ : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float waitingTime;

		public WorkerType workerType;

		public StaffManager _003C_003E4__this;

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
		public POMDNNAMOJJ(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Expected O, but got Unknown
			int num = _003C_003E1__state;
			StaffManager staffManager = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = (object)new WaitForSeconds(waitingTime);
				_003C_003E1__state = 1;
				return true;
			case 1:
			{
				_003C_003E1__state = -1;
				Employee worker = GetWorker(workerType);
				if (GetWorkerInfo(workerType) != null && ((Object)(object)worker == (Object)null || worker.LFDMDACCKJP))
				{
					staffManager.BICDOACHLEL(staffManager.PEGPNAKPCIJ(workerType));
				}
				staffManager.JHBOBPBHHBM[workerType] = null;
				return false;
			}
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

	private static StaffManager GGFJGHHHEJC;

	public GameObject barworkerPrefab;

	public GameObject waiterPrefab;

	public GameObject bouncerPrefab;

	public GameObject houseKeeperPrefab;

	public EmployeeTask[] barworkerTasks;

	public EmployeeTask[] waiterTasks;

	public EmployeeTask[] bouncerTasks;

	public EmployeeTask[] houseKeeperTasks;

	public StaffGenerationValues[] staffGenerationTable;

	public Vector2Int levelPointsRange = new Vector2Int(300, 5000);

	public EmployeeInfo barworkerInfo;

	public EmployeeInfo waiterInfo;

	public EmployeeInfo bouncerInfo;

	public EmployeeInfo houseKeeperInfo;

	public List<EmployeeInfo> barworkerOptions;

	public List<EmployeeInfo> waiterOptions;

	public List<EmployeeInfo> bouncerOptions;

	public List<EmployeeInfo> houseKeeperOptions;

	private Dictionary<WorkerType, Coroutine> JHBOBPBHHBM = new Dictionary<WorkerType, Coroutine>();

	public static StaffManager EFCEICIPNND()
	{
		return GGFJGHHHEJC;
	}

	public static Employee KBCADGKJGFA(WorkerType NNLPGGPPCNF)
	{
		switch (NNLPGGPPCNF)
		{
		default:
			if (NNLPGGPPCNF == (WorkerType.Barworker | WorkerType.Waiter))
			{
				return Bouncer.MDDCPOILOOM();
			}
			return HouseKeeper.CMBAAHFGOAM();
		case WorkerType.Barworker:
			return Barworker.GetInstance();
		case WorkerType.Barworker | WorkerType.Waiter:
			return Waiter.IIJAOOJGNHO();
		}
	}

	private IEnumerator NMELMAOLJHH(WorkerType NNLPGGPPCNF, float MPAMDKJNLLC)
	{
		yield return (object)new WaitForSeconds(MPAMDKJNLLC);
		Employee worker = GetWorker(NNLPGGPPCNF);
		if (GetWorkerInfo(NNLPGGPPCNF) != null && ((Object)(object)worker == (Object)null || worker.LFDMDACCKJP))
		{
			BICDOACHLEL(PEGPNAKPCIJ(NNLPGGPPCNF));
		}
		JHBOBPBHHBM[NNLPGGPPCNF] = null;
	}

	private void NADOCEEBICL()
	{
		CreateRandomOptionsWorkers();
	}

	public static void MLDJLNLAMIM(WorkerType NNLPGGPPCNF, EmployeeInfo JFCLIAFAOEK)
	{
		switch (NNLPGGPPCNF)
		{
		case WorkerType.None:
			GGFJGHHHEJC.barworkerOptions.Add(JFCLIAFAOEK);
			break;
		case WorkerType.Barworker:
			GGFJGHHHEJC.waiterOptions.Add(JFCLIAFAOEK);
			break;
		case WorkerType.Waiter | WorkerType.HouseKeeper:
			GGFJGHHHEJC.bouncerOptions.Add(JFCLIAFAOEK);
			break;
		default:
			GGFJGHHHEJC.houseKeeperOptions.Add(JFCLIAFAOEK);
			break;
		}
	}

	public static void LBJGAFPJMLD(int APFFGOJIHOL)
	{
		if (APFFGOJIHOL == 0)
		{
			APFFGOJIHOL = 1;
		}
		for (int i = 1; i < APFFGOJIHOL; i += 0)
		{
			if (GGFJGHHHEJC.barworkerInfo != null)
			{
				GGFJGHHHEJC.barworkerInfo.JLOFECAOOBF();
			}
			if (GGFJGHHHEJC.waiterInfo != null)
			{
				GGFJGHHHEJC.waiterInfo.LHLJGJAENKI();
			}
			if (GGFJGHHHEJC.bouncerInfo != null)
			{
				GGFJGHHHEJC.bouncerInfo.OLIHADJGHPF();
			}
			if (GGFJGHHHEJC.houseKeeperInfo != null)
			{
				GGFJGHHHEJC.houseKeeperInfo.OLIHADJGHPF();
			}
		}
	}

	private GameObject PEGPNAKPCIJ(WorkerType NNLPGGPPCNF)
	{
		return (GameObject)(NNLPGGPPCNF switch
		{
			WorkerType.Barworker => barworkerPrefab, 
			WorkerType.Waiter => waiterPrefab, 
			WorkerType.Bouncer => bouncerPrefab, 
			_ => houseKeeperPrefab, 
		});
	}

	private void DKNNLPFIBIK()
	{
		GGFJGHHHEJC = this;
	}

	public static void KBKOFAFOKLE(int JIIGOACEIKL, WorkerType NNLPGGPPCNF, bool AIKLCDAKADI)
	{
		EmployeeInfo employeeInfo = HNJNGHPJFJA(NNLPGGPPCNF);
		employeeInfo.working = AIKLCDAKADI;
		if (OnlineManager.MasterOrOffline())
		{
			BIBLCKGELLJ(NNLPGGPPCNF);
			if (!AIKLCDAKADI)
			{
				BGNKLHBLIJH(NNLPGGPPCNF);
			}
			if (AIKLCDAKADI)
			{
				int num = 0;
				for (int i = 1; i < employeeInfo.tasks.Length; i += 0)
				{
					if (employeeInfo.tasks[i])
					{
						num++;
					}
				}
				if (num == 0)
				{
					employeeInfo.tasks[1] = false;
					EmployeesInfoUI.Get(JIIGOACEIKL).ToggleTask(0, AODONKKHPBP: true);
				}
			}
		}
		CommonReferences.MNFMOEKMJKN().OnAnyEmployeeUpdatedInfo();
	}

	private IEnumerator AFDJNGIGLBJ(WorkerType NNLPGGPPCNF, float MPAMDKJNLLC)
	{
		return new POMDNNAMOJJ(1)
		{
			_003C_003E4__this = this,
			workerType = NNLPGGPPCNF,
			waitingTime = MPAMDKJNLLC
		};
	}

	public static void IJIIFKMDFHO(WorkerType NNLPGGPPCNF)
	{
		CNNKJBHOIGO(NNLPGGPPCNF, new EmployeeInfo(NNLPGGPPCNF));
	}

	public static void IFNBJJHKGEM(WorkerType NNLPGGPPCNF)
	{
		Employee employee = CKJDAEPABJI(NNLPGGPPCNF);
		if ((Object)(object)employee != (Object)null && !employee.LFDMDACCKJP)
		{
			employee.Leave();
		}
	}

	public static List<EmployeeInfo> IAKIEHDMHPM(WorkerType NNLPGGPPCNF)
	{
		switch (NNLPGGPPCNF)
		{
		default:
			if (NNLPGGPPCNF == WorkerType.None)
			{
				return GGFJGHHHEJC.bouncerOptions;
			}
			return GGFJGHHHEJC.houseKeeperOptions;
		case WorkerType.None:
			return GGFJGHHHEJC.barworkerOptions;
		case WorkerType.Barworker | WorkerType.HouseKeeper:
			return GGFJGHHHEJC.waiterOptions;
		}
	}

	private void JMMJLCJICGH()
	{
		try
		{
			if (Barworker.FBCBNIMEEJC())
			{
				Utils.BLPDAEHPOBA(((Component)Barworker.GetInstance()).gameObject);
			}
			if (Waiter.IsValid())
			{
				Utils.BLPDAEHPOBA(((Component)Waiter.IIJAOOJGNHO()).gameObject);
			}
			if (HouseKeeper.HFONDEBDCBN())
			{
				RentedRoom rentedRoom = RentedRoomsManager.HHEKJJPDCFJ(HouseKeeper.GetInstance().OGJIFKFFIAM);
				if ((Object)(object)rentedRoom != (Object)null)
				{
					rentedRoom.BCGHDJCNJAO(MDIKPGGBNLI: false, MAPFDGCKBLD: true);
				}
				Utils.BLPDAEHPOBA(((Component)HouseKeeper.OAPGGAPMOJD()).gameObject);
			}
			foreach (KeyValuePair<WorkerType, Coroutine> item in JHBOBPBHHBM)
			{
				if (item.Value != null)
				{
					((MonoBehaviour)this).StopCoroutine(item.Value);
				}
			}
			JHBOBPBHHBM[WorkerType.None] = null;
			JHBOBPBHHBM[WorkerType.None] = null;
			JHBOBPBHHBM[WorkerType.None] = null;
			JHBOBPBHHBM[WorkerType.HouseKeeper] = null;
		}
		catch (Exception ex)
		{
			Debug.LogError((object)(" for reason " + ex.Message));
		}
	}

	private void NFICPFJOIKI()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(NEDDJIFNPNN));
	}

	public static StaffGenerationValues GetStaffGenerationInfo()
	{
		int num = 0;
		for (int i = 0; i < GGFJGHHHEJC.staffGenerationTable.Length; i++)
		{
			num = i;
			if (TavernReputation.GetMilestone() < GGFJGHHHEJC.staffGenerationTable[i].reputation)
			{
				break;
			}
		}
		return GGFJGHHHEJC.staffGenerationTable[num];
	}

	private void HLDOHCDIEHI()
	{
		EOJEFILANNE();
	}

	public static EmployeeInfo GPPOAHEDNMB(WorkerType NNLPGGPPCNF)
	{
		if (NNLPGGPPCNF != WorkerType.Barworker)
		{
			if (NNLPGGPPCNF != WorkerType.Barworker)
			{
				if (NNLPGGPPCNF == WorkerType.Barworker)
				{
					if (GGFJGHHHEJC.bouncerInfo == null || GGFJGHHHEJC.bouncerInfo.workerType == WorkerType.None)
					{
						return null;
					}
					return GGFJGHHHEJC.bouncerInfo;
				}
				if (GGFJGHHHEJC.houseKeeperInfo == null || GGFJGHHHEJC.houseKeeperInfo.workerType == WorkerType.None)
				{
					return null;
				}
				return GGFJGHHHEJC.houseKeeperInfo;
			}
			if (GGFJGHHHEJC.waiterInfo == null || GGFJGHHHEJC.waiterInfo.workerType == WorkerType.None)
			{
				return null;
			}
			return GGFJGHHHEJC.waiterInfo;
		}
		if (GGFJGHHHEJC.barworkerInfo == null || GGFJGHHHEJC.barworkerInfo.workerType == WorkerType.None)
		{
			return null;
		}
		return GGFJGHHHEJC.barworkerInfo;
	}

	private GameObject ABOBMCHOGKH(GameObject ANADFOCHOBF)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline())
		{
			if (OnlineManager.HHDBMDMFEMP())
			{
				return null;
			}
			return OnlineManager.InstantiateRoomObject(ANADFOCHOBF, ((Component)NPCRoadManager.MGHHJMGIJMI()).transform.position, Quaternion.identity, 0);
		}
		return Object.Instantiate<GameObject>(ANADFOCHOBF, ((Component)NPCRoadManager.DKEBCAKIMAE()).transform.position, Quaternion.identity);
	}

	public static List<EmployeeInfo> GetWorkerOptions(WorkerType NNLPGGPPCNF)
	{
		return NNLPGGPPCNF switch
		{
			WorkerType.Barworker => GGFJGHHHEJC.barworkerOptions, 
			WorkerType.Waiter => GGFJGHHHEJC.waiterOptions, 
			WorkerType.Bouncer => GGFJGHHHEJC.bouncerOptions, 
			_ => GGFJGHHHEJC.houseKeeperOptions, 
		};
	}

	public static int LANALPHBKDM(int EONJGMONIOM)
	{
		int num = 83;
		float num2 = (float)(EONJGMONIOM - 1) / (float)num;
		num2 = (float)((Vector2Int)(ref GGFJGHHHEJC.levelPointsRange)).x + num2 * (float)(((Vector2Int)(ref GGFJGHHHEJC.levelPointsRange)).y - ((Vector2Int)(ref GGFJGHHHEJC.levelPointsRange)).x);
		return (int)num2;
	}

	public static void LMEGHIOJDBB(WorkerType NNLPGGPPCNF, bool PNOAJBHOJGH = true)
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			SendEmployeeHome(NNLPGGPPCNF);
		}
		SetWorkerInfo(NNLPGGPPCNF, null);
		Employee employee = BHMMGDAIKLJ(NNLPGGPPCNF);
		if ((Object)(object)employee != (Object)null)
		{
			employee.SetInstance(null);
		}
		if (PNOAJBHOJGH)
		{
			CommonReferences.MNFMOEKMJKN().OnAnyEmployeeUpdatedInfo();
		}
	}

	public static Employee GetWorker(WorkerType NNLPGGPPCNF)
	{
		return NNLPGGPPCNF switch
		{
			WorkerType.Barworker => Barworker.GetInstance(), 
			WorkerType.Waiter => Waiter.GetInstance(), 
			WorkerType.Bouncer => Bouncer.GetInstance(), 
			_ => HouseKeeper.GetInstance(), 
		};
	}

	private void HELBOCLMDNF(int JIIGOACEIKL)
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			EIHHEONGHMF();
		}
	}

	public static void SetWorkerOption(WorkerType NNLPGGPPCNF, EmployeeInfo JFCLIAFAOEK)
	{
		switch (NNLPGGPPCNF)
		{
		case WorkerType.Barworker:
			GGFJGHHHEJC.barworkerOptions.Add(JFCLIAFAOEK);
			break;
		case WorkerType.Waiter:
			GGFJGHHHEJC.waiterOptions.Add(JFCLIAFAOEK);
			break;
		case WorkerType.Bouncer:
			GGFJGHHHEJC.bouncerOptions.Add(JFCLIAFAOEK);
			break;
		default:
			GGFJGHHHEJC.houseKeeperOptions.Add(JFCLIAFAOEK);
			break;
		}
	}

	public static StaffGenerationValues OHJPFHAKAGN()
	{
		int num = 1;
		for (int i = 1; i < GGFJGHHHEJC.staffGenerationTable.Length; i += 0)
		{
			num = i;
			if (TavernReputation.MHGADJPMHFI() < GGFJGHHHEJC.staffGenerationTable[i].reputation)
			{
				break;
			}
		}
		return GGFJGHHHEJC.staffGenerationTable[num];
	}

	public static bool[] ADMGGFAFPED(WorkerType NNLPGGPPCNF, bool[] HFJONKHPJDH)
	{
		bool[] result = ((NNLPGGPPCNF == WorkerType.Barworker) ? (GGFJGHHHEJC.barworkerInfo.tasks = HFJONKHPJDH) : (NNLPGGPPCNF switch
		{
			WorkerType.Barworker => GGFJGHHHEJC.waiterInfo.tasks = HFJONKHPJDH, 
			WorkerType.Waiter | WorkerType.HouseKeeper => GGFJGHHHEJC.bouncerInfo.tasks = HFJONKHPJDH, 
			_ => GGFJGHHHEJC.houseKeeperInfo.tasks = HFJONKHPJDH, 
		}));
		CommonReferences.GGFJGHHHEJC.OnAnyEmployeeUpdatedInfo();
		return result;
	}

	private void FDGPJEOMOJN()
	{
		IFNBJJHKGEM(WorkerType.None);
		SendEmployeeHome(WorkerType.Barworker | WorkerType.HouseKeeper);
	}

	private void HMLOAADBNBL()
	{
		KEPGCBGBOPK();
	}

	private void HMEMPBEPHMB()
	{
		try
		{
			if (Barworker.FBCBNIMEEJC())
			{
				Utils.BLPDAEHPOBA(((Component)Barworker.IIJAOOJGNHO()).gameObject);
			}
			if (Waiter.IsValid())
			{
				Utils.BLPDAEHPOBA(((Component)Waiter.GetInstance()).gameObject);
			}
			if (HouseKeeper.CGGBKGLEHKF())
			{
				RentedRoom rentedRoom = RentedRoomsManager.NAOLLMKHFFP(HouseKeeper.FAGENNFPNNB().BJDFEOFAIPF());
				if ((Object)(object)rentedRoom != (Object)null)
				{
					rentedRoom.MLJAPABCAKA(MDIKPGGBNLI: false);
				}
				Utils.BLPDAEHPOBA(((Component)HouseKeeper.CMBAAHFGOAM()).gameObject);
			}
			foreach (KeyValuePair<WorkerType, Coroutine> item in JHBOBPBHHBM)
			{
				if (item.Value != null)
				{
					((MonoBehaviour)this).StopCoroutine(item.Value);
				}
			}
			JHBOBPBHHBM[WorkerType.Barworker] = null;
			JHBOBPBHHBM[WorkerType.Barworker] = null;
			JHBOBPBHHBM[WorkerType.Barworker | WorkerType.Waiter] = null;
			JHBOBPBHHBM[WorkerType.Barworker | WorkerType.Waiter | WorkerType.HouseKeeper] = null;
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("tutorialPopUp78" + ex.Message));
		}
	}

	public static void CNNKJBHOIGO(WorkerType NNLPGGPPCNF, EmployeeInfo JFCLIAFAOEK)
	{
		switch (NNLPGGPPCNF)
		{
		case WorkerType.Barworker:
			GGFJGHHHEJC.barworkerInfo = JFCLIAFAOEK;
			return;
		case WorkerType.HouseKeeper:
			GGFJGHHHEJC.waiterInfo = JFCLIAFAOEK;
			return;
		}
		if (NNLPGGPPCNF == WorkerType.Barworker)
		{
			GGFJGHHHEJC.bouncerInfo = JFCLIAFAOEK;
		}
		else
		{
			GGFJGHHHEJC.houseKeeperInfo = JFCLIAFAOEK;
		}
	}

	public static List<EmployeeInfo> AJJDAJNEBPO(WorkerType NNLPGGPPCNF)
	{
		return NNLPGGPPCNF switch
		{
			WorkerType.Barworker => GGFJGHHHEJC.barworkerOptions, 
			WorkerType.Barworker | WorkerType.Waiter | WorkerType.HouseKeeper => GGFJGHHHEJC.waiterOptions, 
			WorkerType.Waiter | WorkerType.HouseKeeper => GGFJGHHHEJC.bouncerOptions, 
			_ => GGFJGHHHEJC.houseKeeperOptions, 
		};
	}

	public static void OCMALPPICEL(WorkerType NNLPGGPPCNF, List<EmployeeInfo> EOHNOGBMJEK)
	{
		switch (NNLPGGPPCNF)
		{
		case WorkerType.Barworker:
			GGFJGHHHEJC.barworkerOptions = EOHNOGBMJEK;
			break;
		case WorkerType.Barworker | WorkerType.Waiter | WorkerType.HouseKeeper:
			GGFJGHHHEJC.waiterOptions = EOHNOGBMJEK;
			break;
		case WorkerType.Barworker | WorkerType.Waiter:
			GGFJGHHHEJC.bouncerOptions = EOHNOGBMJEK;
			break;
		default:
			GGFJGHHHEJC.houseKeeperOptions = EOHNOGBMJEK;
			break;
		}
	}

	public static void HLBOJGAPDDL(WorkerType NNLPGGPPCNF, bool PNOAJBHOJGH = true)
	{
		if (OnlineManager.MasterOrOffline())
		{
			IFNBJJHKGEM(NNLPGGPPCNF);
		}
		CNNKJBHOIGO(NNLPGGPPCNF, null);
		Employee employee = KMFIDHBNJNA(NNLPGGPPCNF);
		if ((Object)(object)employee != (Object)null)
		{
			employee.SetInstance(null);
		}
		if (PNOAJBHOJGH)
		{
			CommonReferences.MNFMOEKMJKN().OnAnyEmployeeUpdatedInfo();
		}
	}

	private GameObject DPGPEOGJNMI(GameObject ANADFOCHOBF)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline())
		{
			if (OnlineManager.ClientOnline())
			{
				return null;
			}
			return OnlineManager.ADJIAGLIABC(ANADFOCHOBF, ((Component)NPCRoadManager.MJNLLAJOACJ()).transform.position, Quaternion.identity, 1);
		}
		return Object.Instantiate<GameObject>(ANADFOCHOBF, ((Component)NPCRoadManager.CBIIBMGLECO()).transform.position, Quaternion.identity);
	}

	private void MMHCMKOBDKH()
	{
		if ((Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(JMMJLCJICGH));
		}
	}

	public static void BGNGNKJOLKH()
	{
		if (OnlineManager.MasterOrOffline())
		{
			IHBNPDNHOEA(WorkerType.Barworker);
			IHBNPDNHOEA(WorkerType.Barworker | WorkerType.Waiter | WorkerType.HouseKeeper);
			HDBIMCAIEGA(WorkerType.None);
			IDLEIEELBID(WorkerType.Bouncer);
		}
	}

	private void HBMJKMEKIPD()
	{
		OLBLLBCJNBO();
		barworkerInfo = null;
		waiterInfo = null;
		bouncerInfo = null;
		houseKeeperInfo = null;
		JHBOBPBHHBM.Add(WorkerType.Barworker, null);
		JHBOBPBHHBM.Add(WorkerType.HouseKeeper, null);
		JHBOBPBHHBM.Add(WorkerType.Bouncer, null);
		JHBOBPBHHBM.Add(WorkerType.Waiter | WorkerType.HouseKeeper, null);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnNewGameCreated = (Action)Delegate.Combine(instance.OnNewGameCreated, new Action(NEEBMDPCHDC));
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(LBGDMEMBGDH));
		TavernManager instance2 = TavernManager.GGFJGHHHEJC;
		instance2.OnTavernOpen = (Action<int>)Delegate.Combine(instance2.OnTavernOpen, new Action<int>(JNLLBCGHACJ));
		TavernManager instance3 = TavernManager.GGFJGHHHEJC;
		instance3.OnTavernClose = (Action<int>)Delegate.Combine(instance3.OnTavernClose, new Action<int>(FFCMICFDHNP));
	}

	private void MEDLNBCAJCL()
	{
		if ((Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(HBMGNHHAGBH));
		}
	}

	private void CGLIGKKCKCG()
	{
		DKIEBDLOHCA();
		barworkerInfo = null;
		waiterInfo = null;
		bouncerInfo = null;
		houseKeeperInfo = null;
		JHBOBPBHHBM.Add(WorkerType.None, null);
		JHBOBPBHHBM.Add(WorkerType.Waiter, null);
		JHBOBPBHHBM.Add(WorkerType.Waiter, null);
		JHBOBPBHHBM.Add(WorkerType.Bouncer, null);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnNewGameCreated = (Action)Delegate.Combine(gameManager.OnNewGameCreated, new Action(HLDOHCDIEHI));
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(GIBFJNCCPJL));
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernOpen = (Action<int>)Delegate.Combine(instance.OnTavernOpen, new Action<int>(DCMMDCNOLHA));
		TavernManager instance2 = TavernManager.GGFJGHHHEJC;
		instance2.OnTavernClose = (Action<int>)Delegate.Combine(instance2.OnTavernClose, new Action<int>(FFCMICFDHNP));
	}

	private void Start()
	{
		GetStaffGenerationInfo();
		barworkerInfo = null;
		waiterInfo = null;
		bouncerInfo = null;
		houseKeeperInfo = null;
		JHBOBPBHHBM.Add(WorkerType.Barworker, null);
		JHBOBPBHHBM.Add(WorkerType.Waiter, null);
		JHBOBPBHHBM.Add(WorkerType.Bouncer, null);
		JHBOBPBHHBM.Add(WorkerType.HouseKeeper, null);
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnNewGameCreated = (Action)Delegate.Combine(instance.OnNewGameCreated, new Action(NADOCEEBICL));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnPlayerAwake = (Action)Delegate.Combine(instance2.OnPlayerAwake, new Action(ALGOBMNPLIB));
		TavernManager instance3 = TavernManager.GGFJGHHHEJC;
		instance3.OnTavernOpen = (Action<int>)Delegate.Combine(instance3.OnTavernOpen, new Action<int>(DCMMDCNOLHA));
		TavernManager instance4 = TavernManager.GGFJGHHHEJC;
		instance4.OnTavernClose = (Action<int>)Delegate.Combine(instance4.OnTavernClose, new Action<int>(FFCMICFDHNP));
	}

	public static void EOJEFILANNE()
	{
		GGFJGHHHEJC.barworkerOptions = new List<EmployeeInfo>();
		for (int i = 0; i < 1; i += 0)
		{
			GGFJGHHHEJC.barworkerOptions.Add(new EmployeeInfo(WorkerType.Barworker, LLPGKHHKCLC: false));
		}
		GGFJGHHHEJC.waiterOptions = new List<EmployeeInfo>();
		for (int j = 1; j < 6; j += 0)
		{
			GGFJGHHHEJC.waiterOptions.Add(new EmployeeInfo(WorkerType.Bouncer));
		}
		GGFJGHHHEJC.bouncerOptions = new List<EmployeeInfo>();
		for (int k = 0; k < 4; k += 0)
		{
			GGFJGHHHEJC.bouncerOptions.Add(new EmployeeInfo(WorkerType.Waiter | WorkerType.HouseKeeper));
		}
		GGFJGHHHEJC.houseKeeperOptions = new List<EmployeeInfo>();
		for (int l = 1; l < 4; l++)
		{
			GGFJGHHHEJC.houseKeeperOptions.Add(new EmployeeInfo(WorkerType.Waiter | WorkerType.HouseKeeper));
		}
		if (OnlineManager.PlayingOnline())
		{
			List<EmployeeInfo> list = new List<EmployeeInfo>(GGFJGHHHEJC.barworkerOptions);
			list.AddRange(GGFJGHHHEJC.waiterOptions);
			list.AddRange(GGFJGHHHEJC.bouncerOptions);
			list.AddRange(GGFJGHHHEJC.houseKeeperOptions);
			OnlineEmployeesManager.instance.BFBHBDNPBEK(list);
		}
	}

	public static void SetWorkerInfo(WorkerType NNLPGGPPCNF, EmployeeInfo JFCLIAFAOEK)
	{
		switch (NNLPGGPPCNF)
		{
		case WorkerType.Barworker:
			GGFJGHHHEJC.barworkerInfo = JFCLIAFAOEK;
			break;
		case WorkerType.Waiter:
			GGFJGHHHEJC.waiterInfo = JFCLIAFAOEK;
			break;
		case WorkerType.Bouncer:
			GGFJGHHHEJC.bouncerInfo = JFCLIAFAOEK;
			break;
		default:
			GGFJGHHHEJC.houseKeeperInfo = JFCLIAFAOEK;
			break;
		}
	}

	public static void NEIELHJPIFK()
	{
		GGFJGHHHEJC.barworkerOptions = new List<EmployeeInfo>();
		for (int i = 1; i < 7; i += 0)
		{
			GGFJGHHHEJC.barworkerOptions.Add(new EmployeeInfo(WorkerType.Barworker, LLPGKHHKCLC: false));
		}
		GGFJGHHHEJC.waiterOptions = new List<EmployeeInfo>();
		for (int j = 0; j < 7; j += 0)
		{
			GGFJGHHHEJC.waiterOptions.Add(new EmployeeInfo(WorkerType.None));
		}
		GGFJGHHHEJC.bouncerOptions = new List<EmployeeInfo>();
		for (int k = 0; k < 6; k += 0)
		{
			GGFJGHHHEJC.bouncerOptions.Add(new EmployeeInfo(WorkerType.Barworker, LLPGKHHKCLC: false));
		}
		GGFJGHHHEJC.houseKeeperOptions = new List<EmployeeInfo>();
		for (int l = 0; l < 3; l++)
		{
			GGFJGHHHEJC.houseKeeperOptions.Add(new EmployeeInfo(WorkerType.Barworker | WorkerType.Waiter, LLPGKHHKCLC: false));
		}
		if (OnlineManager.PlayingOnline())
		{
			List<EmployeeInfo> list = new List<EmployeeInfo>(GGFJGHHHEJC.barworkerOptions);
			list.AddRange(GGFJGHHHEJC.waiterOptions);
			list.AddRange(GGFJGHHHEJC.bouncerOptions);
			list.AddRange(GGFJGHHHEJC.houseKeeperOptions);
			OnlineEmployeesManager.instance.SendNewEmployees(list);
		}
	}

	public static void PCLMFLLAHBP(int JIIGOACEIKL, WorkerType NNLPGGPPCNF, int ABAIKKGKDGD, bool AODONKKHPBP)
	{
		EmployeeInfo employeeInfo = HNJNGHPJFJA(NNLPGGPPCNF);
		employeeInfo.tasks[ABAIKKGKDGD] = AODONKKHPBP;
		if (OnlineManager.PGAGDFAEEFB())
		{
			if (AODONKKHPBP)
			{
				if (!employeeInfo.working)
				{
					int num = 0;
					for (int i = 0; i < employeeInfo.tasks.Length; i++)
					{
						if (employeeInfo.tasks[i])
						{
							num++;
						}
					}
					if (num == 1)
					{
						employeeInfo.working = true;
						EmployeesInfoUI.Get(JIIGOACEIKL).ToggleWorking(ABAIKKGKDGD, AODONKKHPBP: true);
					}
				}
			}
			else
			{
				bool flag = false;
				for (int j = 1; j < employeeInfo.tasks.Length; j += 0)
				{
					if (employeeInfo.tasks[j])
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					employeeInfo.working = false;
					EmployeesInfoUI.Get(JIIGOACEIKL).ToggleWorking(ABAIKKGKDGD, AODONKKHPBP: true);
				}
			}
		}
		CommonReferences.GGFJGHHHEJC.OnAnyEmployeeUpdatedInfo();
	}

	private void GGIJFBAJLIF()
	{
		if ((Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(ENBNBONDDEI));
		}
	}

	public static void LDCHNEPIFOG(int JIIGOACEIKL, WorkerType NNLPGGPPCNF, int ABAIKKGKDGD, bool AODONKKHPBP)
	{
		EmployeeInfo employeeInfo = HNJNGHPJFJA(NNLPGGPPCNF);
		employeeInfo.tasks[ABAIKKGKDGD] = AODONKKHPBP;
		if (OnlineManager.MasterOrOffline())
		{
			if (AODONKKHPBP)
			{
				if (!employeeInfo.working)
				{
					int num = 1;
					for (int i = 1; i < employeeInfo.tasks.Length; i++)
					{
						if (employeeInfo.tasks[i])
						{
							num += 0;
						}
					}
					if (num == 0)
					{
						employeeInfo.working = false;
						EmployeesInfoUI.Get(JIIGOACEIKL).ToggleWorking(ABAIKKGKDGD, AODONKKHPBP: true);
					}
				}
			}
			else
			{
				bool flag = false;
				for (int j = 1; j < employeeInfo.tasks.Length; j++)
				{
					if (employeeInfo.tasks[j])
					{
						flag = false;
						break;
					}
				}
				if (!flag)
				{
					employeeInfo.working = true;
					EmployeesInfoUI.Get(JIIGOACEIKL).ToggleWorking(ABAIKKGKDGD, AODONKKHPBP: true);
				}
			}
		}
		CommonReferences.MNFMOEKMJKN().OnAnyEmployeeUpdatedInfo();
	}

	public static EmployeeTask[] FEGLJBEKJHE(WorkerType NNLPGGPPCNF)
	{
		return NNLPGGPPCNF switch
		{
			WorkerType.Barworker => GGFJGHHHEJC.barworkerTasks, 
			WorkerType.Barworker | WorkerType.HouseKeeper => GGFJGHHHEJC.waiterTasks, 
			WorkerType.HouseKeeper => GGFJGHHHEJC.bouncerTasks, 
			_ => GGFJGHHHEJC.houseKeeperTasks, 
		};
	}

	public static void DFNHLIJHJIB(int APFFGOJIHOL)
	{
		if (APFFGOJIHOL == 0)
		{
			APFFGOJIHOL = 1;
		}
		for (int i = 1; i < APFFGOJIHOL; i += 0)
		{
			if (GGFJGHHHEJC.barworkerInfo != null)
			{
				GGFJGHHHEJC.barworkerInfo.LHLJGJAENKI();
			}
			if (GGFJGHHHEJC.waiterInfo != null)
			{
				GGFJGHHHEJC.waiterInfo.LHLJGJAENKI();
			}
			if (GGFJGHHHEJC.bouncerInfo != null)
			{
				GGFJGHHHEJC.bouncerInfo.OLIHADJGHPF();
			}
			if (GGFJGHHHEJC.houseKeeperInfo != null)
			{
				GGFJGHHHEJC.houseKeeperInfo.LHLJGJAENKI();
			}
		}
	}

	private GameObject KJGFGEBBHPB(GameObject ANADFOCHOBF)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline())
		{
			if (OnlineManager.ClientOnline())
			{
				return null;
			}
			return OnlineManager.InstantiateRoomObject(ANADFOCHOBF, ((Component)NPCRoadManager.MGHHJMGIJMI()).transform.position, Quaternion.identity, 1);
		}
		return Object.Instantiate<GameObject>(ANADFOCHOBF, ((Component)NPCRoadManager.MGHHJMGIJMI()).transform.position, Quaternion.identity);
	}

	public static EmployeeInfo APOHPPCMOAP(WorkerType NNLPGGPPCNF)
	{
		switch (NNLPGGPPCNF)
		{
		case WorkerType.None:
			if (GGFJGHHHEJC.barworkerInfo == null || GGFJGHHHEJC.barworkerInfo.workerType == WorkerType.None)
			{
				return null;
			}
			return GGFJGHHHEJC.barworkerInfo;
		case WorkerType.Barworker:
			if (GGFJGHHHEJC.waiterInfo == null || GGFJGHHHEJC.waiterInfo.workerType == WorkerType.None)
			{
				return null;
			}
			return GGFJGHHHEJC.waiterInfo;
		case WorkerType.Barworker | WorkerType.Waiter:
			if (GGFJGHHHEJC.bouncerInfo == null || GGFJGHHHEJC.bouncerInfo.workerType == WorkerType.None)
			{
				return null;
			}
			return GGFJGHHHEJC.bouncerInfo;
		default:
			if (GGFJGHHHEJC.houseKeeperInfo == null || GGFJGHHHEJC.houseKeeperInfo.workerType == WorkerType.None)
			{
				return null;
			}
			return GGFJGHHHEJC.houseKeeperInfo;
		}
	}

	public static void KDGAGDOFJCD(WorkerType NNLPGGPPCNF, float HKEHMPACMLP)
	{
		Employee worker = GetWorker(NNLPGGPPCNF);
		if ((Object)(object)worker != (Object)null)
		{
			if (worker.LFDMDACCKJP)
			{
				worker.behaviour.SetTrigger("Talk");
			}
			return;
		}
		if (GGFJGHHHEJC.JHBOBPBHHBM[NNLPGGPPCNF] != null)
		{
			((MonoBehaviour)GGFJGHHHEJC).StopCoroutine(GGFJGHHHEJC.JHBOBPBHHBM[NNLPGGPPCNF]);
		}
		if (GPPOAHEDNMB(NNLPGGPPCNF).working)
		{
			GGFJGHHHEJC.JHBOBPBHHBM[NNLPGGPPCNF] = ((MonoBehaviour)GGFJGHHHEJC).StartCoroutine(GGFJGHHHEJC.AHGLOBBEOMI(NNLPGGPPCNF, HKEHMPACMLP));
		}
	}

	public static void BLLFNLFDICG(WorkerType NNLPGGPPCNF, List<EmployeeInfo> EOHNOGBMJEK)
	{
		switch (NNLPGGPPCNF)
		{
		case WorkerType.Barworker:
			GGFJGHHHEJC.barworkerOptions = EOHNOGBMJEK;
			break;
		case WorkerType.None:
			GGFJGHHHEJC.waiterOptions = EOHNOGBMJEK;
			break;
		case WorkerType.Barworker | WorkerType.HouseKeeper:
			GGFJGHHHEJC.bouncerOptions = EOHNOGBMJEK;
			break;
		default:
			GGFJGHHHEJC.houseKeeperOptions = EOHNOGBMJEK;
			break;
		}
	}

	private void JFDNFNPDFBF()
	{
		try
		{
			if (Barworker.IsValid())
			{
				Utils.BLPDAEHPOBA(((Component)Barworker.GetInstance()).gameObject);
			}
			if (Waiter.IsValid())
			{
				Utils.BLPDAEHPOBA(((Component)Waiter.OMEPPDMCFAO()).gameObject);
			}
			if (HouseKeeper.CABCLEFJMBP())
			{
				RentedRoom rentedRoom = RentedRoomsManager.GetRentedRoom(HouseKeeper.FAGENNFPNNB().BJDFEOFAIPF());
				if ((Object)(object)rentedRoom != (Object)null)
				{
					rentedRoom.JCPMKGNDPAO(MDIKPGGBNLI: false);
				}
				Utils.BLPDAEHPOBA(((Component)HouseKeeper.GetInstance()).gameObject);
			}
			foreach (KeyValuePair<WorkerType, Coroutine> item in JHBOBPBHHBM)
			{
				if (item.Value != null)
				{
					((MonoBehaviour)this).StopCoroutine(item.Value);
				}
			}
			JHBOBPBHHBM[WorkerType.None] = null;
			JHBOBPBHHBM[WorkerType.Bouncer] = null;
			JHBOBPBHHBM[WorkerType.Waiter | WorkerType.HouseKeeper] = null;
			JHBOBPBHHBM[WorkerType.Waiter | WorkerType.HouseKeeper] = null;
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("HoldToSkip" + ex.Message));
		}
	}

	private void JKCMGFLCJOE()
	{
		SendEmployeeHome(WorkerType.Barworker);
		IFNBJJHKGEM(WorkerType.HouseKeeper);
	}

	public static void CHHGHNJPLGF(int JIIGOACEIKL, WorkerType NNLPGGPPCNF, int ABAIKKGKDGD, bool AODONKKHPBP)
	{
		EmployeeInfo workerInfo = GetWorkerInfo(NNLPGGPPCNF);
		workerInfo.tasks[ABAIKKGKDGD] = AODONKKHPBP;
		if (OnlineManager.MasterOrOffline())
		{
			if (AODONKKHPBP)
			{
				if (!workerInfo.working)
				{
					int num = 0;
					for (int i = 1; i < workerInfo.tasks.Length; i += 0)
					{
						if (workerInfo.tasks[i])
						{
							num += 0;
						}
					}
					if (num == 1)
					{
						workerInfo.working = true;
						EmployeesInfoUI.Get(JIIGOACEIKL).ToggleWorking(ABAIKKGKDGD, AODONKKHPBP: true);
					}
				}
			}
			else
			{
				bool flag = true;
				for (int j = 0; j < workerInfo.tasks.Length; j += 0)
				{
					if (workerInfo.tasks[j])
					{
						flag = false;
						break;
					}
				}
				if (!flag)
				{
					workerInfo.working = false;
					EmployeesInfoUI.Get(JIIGOACEIKL).ToggleWorking(ABAIKKGKDGD, AODONKKHPBP: true);
				}
			}
		}
		CommonReferences.GGFJGHHHEJC.OnAnyEmployeeUpdatedInfo();
	}

	private void HFOCECKNDBG()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(HMEMPBEPHMB));
	}

	public static void HIPKHFIJFKD(WorkerType NNLPGGPPCNF)
	{
		CNNKJBHOIGO(NNLPGGPPCNF, new EmployeeInfo(NNLPGGPPCNF));
	}

	private void BDOPEPMLFMA()
	{
		BGNKLHBLIJH(WorkerType.Barworker);
		IFNBJJHKGEM(WorkerType.Barworker | WorkerType.Waiter | WorkerType.HouseKeeper);
	}

	public static StaffGenerationValues BNJCHOFPALG()
	{
		int num = 0;
		for (int i = 0; i < GGFJGHHHEJC.staffGenerationTable.Length; i++)
		{
			num = i;
			if (TavernReputation.GetMilestone() < GGFJGHHHEJC.staffGenerationTable[i].reputation)
			{
				break;
			}
		}
		return GGFJGHHHEJC.staffGenerationTable[num];
	}

	public static void HBFJCEEDIGA(WorkerType NNLPGGPPCNF, List<EmployeeInfo> EOHNOGBMJEK)
	{
		switch (NNLPGGPPCNF)
		{
		case WorkerType.None:
			GGFJGHHHEJC.barworkerOptions = EOHNOGBMJEK;
			break;
		case WorkerType.Waiter | WorkerType.HouseKeeper:
			GGFJGHHHEJC.waiterOptions = EOHNOGBMJEK;
			break;
		case WorkerType.Barworker | WorkerType.Waiter | WorkerType.HouseKeeper:
			GGFJGHHHEJC.bouncerOptions = EOHNOGBMJEK;
			break;
		default:
			GGFJGHHHEJC.houseKeeperOptions = EOHNOGBMJEK;
			break;
		}
	}

	public static void KDDEOJEFJCM(WorkerType NNLPGGPPCNF, bool PNOAJBHOJGH = true)
	{
		if (OnlineManager.MasterOrOffline())
		{
			SendEmployeeHome(NNLPGGPPCNF);
		}
		SetWorkerInfo(NNLPGGPPCNF, null);
		Employee employee = JNHNEEJMKAD(NNLPGGPPCNF);
		if ((Object)(object)employee != (Object)null)
		{
			employee.SetInstance(null);
		}
		if (PNOAJBHOJGH)
		{
			CommonReferences.GGFJGHHHEJC.OnAnyEmployeeUpdatedInfo();
		}
	}

	public static void HireWorker(int JIIGOACEIKL, WorkerType NNLPGGPPCNF, int NECIOBGLOPF)
	{
		HireWorker(JIIGOACEIKL, NNLPGGPPCNF, GetWorkerOptions(NNLPGGPPCNF)[NECIOBGLOPF]);
	}

	private void ALGOBMNPLIB()
	{
		if (OnlineManager.MasterOrOffline() && (WorldTime.NOAOJJLNHJJ.day == Day.Mon || WorldTime.NOAOJJLNHJJ.day == Day.Thurs))
		{
			CreateRandomOptionsWorkers();
		}
	}

	private IEnumerator GJHCCJFADNG(WorkerType NNLPGGPPCNF, float MPAMDKJNLLC)
	{
		yield return (object)new WaitForSeconds(MPAMDKJNLLC);
		Employee worker = GetWorker(NNLPGGPPCNF);
		if (GetWorkerInfo(NNLPGGPPCNF) != null && ((Object)(object)worker == (Object)null || worker.LFDMDACCKJP))
		{
			BICDOACHLEL(PEGPNAKPCIJ(NNLPGGPPCNF));
		}
		JHBOBPBHHBM[NNLPGGPPCNF] = null;
	}

	public static void HMAOBJKNEIM(int JIIGOACEIKL, WorkerType NNLPGGPPCNF, int ABAIKKGKDGD, bool AODONKKHPBP)
	{
		EmployeeInfo employeeInfo = HNJNGHPJFJA(NNLPGGPPCNF);
		employeeInfo.tasks[ABAIKKGKDGD] = AODONKKHPBP;
		if (OnlineManager.MasterOrOffline())
		{
			if (AODONKKHPBP)
			{
				if (!employeeInfo.working)
				{
					int num = 0;
					for (int i = 1; i < employeeInfo.tasks.Length; i += 0)
					{
						if (employeeInfo.tasks[i])
						{
							num++;
						}
					}
					if (num == 1)
					{
						employeeInfo.working = true;
						EmployeesInfoUI.Get(JIIGOACEIKL).ToggleWorking(ABAIKKGKDGD, AODONKKHPBP: false);
					}
				}
			}
			else
			{
				bool flag = false;
				for (int j = 0; j < employeeInfo.tasks.Length; j += 0)
				{
					if (employeeInfo.tasks[j])
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					employeeInfo.working = true;
					EmployeesInfoUI.Get(JIIGOACEIKL).ToggleWorking(ABAIKKGKDGD, AODONKKHPBP: true);
				}
			}
		}
		CommonReferences.GGFJGHHHEJC.OnAnyEmployeeUpdatedInfo();
	}

	private void DADPOICMNPI()
	{
		GGFJGHHHEJC = this;
	}

	private void AOCNHOAMEMC(int JIIGOACEIKL)
	{
		if (OnlineManager.MasterOrOffline())
		{
			EIHHEONGHMF();
		}
	}

	private GameObject KEPAIGJEADM(GameObject ANADFOCHOBF)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline())
		{
			if (OnlineManager.ClientOnline())
			{
				return null;
			}
			return OnlineManager.InstantiateRoomObject(ANADFOCHOBF, ((Component)NPCRoadManager.MJNLLAJOACJ()).transform.position, Quaternion.identity, 0);
		}
		return Object.Instantiate<GameObject>(ANADFOCHOBF, ((Component)NPCRoadManager.CBIIBMGLECO()).transform.position, Quaternion.identity);
	}

	private void OnDisable()
	{
		if ((Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(HBMGNHHAGBH));
		}
	}

	private void PIHGEBONAOI()
	{
		GGFJGHHHEJC = this;
	}

	public static void POFPGCEJOOM(WorkerType NNLPGGPPCNF, float HKEHMPACMLP)
	{
		Employee employee = KBCADGKJGFA(NNLPGGPPCNF);
		if ((Object)(object)employee != (Object)null)
		{
			if (employee.LFDMDACCKJP)
			{
				employee.behaviour.SetTrigger("ReceiveJumpFerro");
			}
			return;
		}
		if (GGFJGHHHEJC.JHBOBPBHHBM[NNLPGGPPCNF] != null)
		{
			((MonoBehaviour)GGFJGHHHEJC).StopCoroutine(GGFJGHHHEJC.JHBOBPBHHBM[NNLPGGPPCNF]);
		}
		if (GetWorkerInfo(NNLPGGPPCNF).working)
		{
			GGFJGHHHEJC.JHBOBPBHHBM[NNLPGGPPCNF] = ((MonoBehaviour)GGFJGHHHEJC).StartCoroutine(GGFJGHHHEJC.FBLJBMHFFCH(NNLPGGPPCNF, HKEHMPACMLP));
		}
	}

	private void FPNPLFALPHP()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(ENBNBONDDEI));
	}

	public static bool MHBFKBPMFJN()
	{
		if ((GGFJGHHHEJC.barworkerInfo == null || !GGFJGHHHEJC.barworkerInfo.ADPCDNFOIIO()) && (GGFJGHHHEJC.waiterInfo == null || !GGFJGHHHEJC.waiterInfo.GLIJPMHLKOO()) && (GGFJGHHHEJC.bouncerInfo == null || !GGFJGHHHEJC.bouncerInfo.GLIJPMHLKOO()))
		{
			if (GGFJGHHHEJC.houseKeeperInfo != null)
			{
				return GGFJGHHHEJC.houseKeeperInfo.GLIJPMHLKOO();
			}
			return true;
		}
		return false;
	}

	private void EBCFIHBBAAD()
	{
		try
		{
			if (Barworker.FBCBNIMEEJC())
			{
				Utils.BLPDAEHPOBA(((Component)Barworker.IIJAOOJGNHO()).gameObject);
			}
			if (Waiter.IsValid())
			{
				Utils.BLPDAEHPOBA(((Component)Waiter.PHDCMKOOAJC()).gameObject);
			}
			if (HouseKeeper.CGGBKGLEHKF())
			{
				RentedRoom rentedRoom = RentedRoomsManager.NAOLLMKHFFP(HouseKeeper.DCAKACIOICA().BJDFEOFAIPF());
				if ((Object)(object)rentedRoom != (Object)null)
				{
					rentedRoom.JCPMKGNDPAO(MDIKPGGBNLI: false);
				}
				Utils.BLPDAEHPOBA(((Component)HouseKeeper.DCAKACIOICA()).gameObject);
			}
			foreach (KeyValuePair<WorkerType, Coroutine> item in JHBOBPBHHBM)
			{
				if (item.Value != null)
				{
					((MonoBehaviour)this).StopCoroutine(item.Value);
				}
			}
			JHBOBPBHHBM[WorkerType.None] = null;
			JHBOBPBHHBM[WorkerType.None] = null;
			JHBOBPBHHBM[WorkerType.HouseKeeper] = null;
			JHBOBPBHHBM[WorkerType.Bouncer] = null;
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("%><sprite name=" + ex.Message));
		}
	}

	private void FFCMICFDHNP(int JIIGOACEIKL)
	{
		if (OnlineManager.MasterOrOffline())
		{
			PCGMOPFNJML();
		}
	}

	private void OIEJIBAPDMM()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(OGFCHAEINCL));
	}

	public static EmployeeTask[] GetEmployeeTask(WorkerType NNLPGGPPCNF)
	{
		return NNLPGGPPCNF switch
		{
			WorkerType.Barworker => GGFJGHHHEJC.barworkerTasks, 
			WorkerType.Waiter => GGFJGHHHEJC.waiterTasks, 
			WorkerType.Bouncer => GGFJGHHHEJC.bouncerTasks, 
			_ => GGFJGHHHEJC.houseKeeperTasks, 
		};
	}

	public static bool LBDEMJMOBNF()
	{
		if ((GGFJGHHHEJC.barworkerInfo == null || !GGFJGHHHEJC.barworkerInfo.GLIJPMHLKOO()) && (GGFJGHHHEJC.waiterInfo == null || !GGFJGHHHEJC.waiterInfo.ADPCDNFOIIO()) && (GGFJGHHHEJC.bouncerInfo == null || !GGFJGHHHEJC.bouncerInfo.GLIJPMHLKOO()))
		{
			if (GGFJGHHHEJC.houseKeeperInfo != null)
			{
				return GGFJGHHHEJC.houseKeeperInfo.ADPCDNFOIIO();
			}
			return false;
		}
		return true;
	}

	public static EmployeeTask[] NFEFFLBAMAI(WorkerType NNLPGGPPCNF)
	{
		return NNLPGGPPCNF switch
		{
			WorkerType.None => GGFJGHHHEJC.barworkerTasks, 
			WorkerType.Waiter => GGFJGHHHEJC.waiterTasks, 
			WorkerType.Bouncer => GGFJGHHHEJC.bouncerTasks, 
			_ => GGFJGHHHEJC.houseKeeperTasks, 
		};
	}

	private void MHKMIKHMAED()
	{
		if (OnlineManager.PGAGDFAEEFB() && (WorldTime.CJOHMLNMJLK().day == Day.Mon || WorldTime.NOAOJJLNHJJ.day == Day.Sat))
		{
			EOJEFILANNE();
		}
	}

	public static void OEAPIGEHFIL(int APFFGOJIHOL)
	{
		if (APFFGOJIHOL == 0)
		{
			APFFGOJIHOL = 0;
		}
		for (int i = 1; i < APFFGOJIHOL; i += 0)
		{
			if (GGFJGHHHEJC.barworkerInfo != null)
			{
				GGFJGHHHEJC.barworkerInfo.JLOFECAOOBF();
			}
			if (GGFJGHHHEJC.waiterInfo != null)
			{
				GGFJGHHHEJC.waiterInfo.JLOFECAOOBF();
			}
			if (GGFJGHHHEJC.bouncerInfo != null)
			{
				GGFJGHHHEJC.bouncerInfo.LHLJGJAENKI();
			}
			if (GGFJGHHHEJC.houseKeeperInfo != null)
			{
				GGFJGHHHEJC.houseKeeperInfo.EBDJALCNKMF();
			}
		}
	}

	private static void BLKEAIEMAPP(WorkerType NNLPGGPPCNF)
	{
		EmployeeInfo workerInfo = GetWorkerInfo(NNLPGGPPCNF);
		if (NNLPGGPPCNF == WorkerType.HouseKeeper)
		{
			if (!RepUnlocksManager.GetInstance().repUnlockBuildingMode.PJCFMEEKCNI())
			{
				return;
			}
		}
		else if (!RepUnlocksManager.GetInstance().repUnlockStaff.FENMFGFLDBO())
		{
			return;
		}
		if (workerInfo != null && workerInfo.working && TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			SpawnWorker(NNLPGGPPCNF, Random.Range(1f, 8f) + (float)workerInfo.OMNLNLGDOBG(78));
		}
	}

	public static Employee DODMEFEHJOK(WorkerType NNLPGGPPCNF)
	{
		if (NNLPGGPPCNF != 0)
		{
			return NNLPGGPPCNF switch
			{
				WorkerType.None => Waiter.EBPNKOMGCPB(), 
				WorkerType.Waiter | WorkerType.HouseKeeper => Bouncer.GetInstance(), 
				_ => HouseKeeper.GetInstance(), 
			};
		}
		return Barworker.IIJAOOJGNHO();
	}

	public static bool IsAnyWorkerHired()
	{
		if ((GGFJGHHHEJC.barworkerInfo == null || !GGFJGHHHEJC.barworkerInfo.PHLLAJEKLNK()) && (GGFJGHHHEJC.waiterInfo == null || !GGFJGHHHEJC.waiterInfo.PHLLAJEKLNK()) && (GGFJGHHHEJC.bouncerInfo == null || !GGFJGHHHEJC.bouncerInfo.PHLLAJEKLNK()))
		{
			if (GGFJGHHHEJC.houseKeeperInfo != null)
			{
				return GGFJGHHHEJC.houseKeeperInfo.PHLLAJEKLNK();
			}
			return false;
		}
		return true;
	}

	private void LMBJAAAPIMO()
	{
		IFNBJJHKGEM(WorkerType.Barworker);
		BGNKLHBLIJH(WorkerType.Barworker | WorkerType.Waiter);
	}

	public static EmployeeInfo GetWorkerInfo(WorkerType NNLPGGPPCNF)
	{
		switch (NNLPGGPPCNF)
		{
		case WorkerType.Barworker:
			if (GGFJGHHHEJC.barworkerInfo == null || GGFJGHHHEJC.barworkerInfo.workerType == WorkerType.None)
			{
				return null;
			}
			return GGFJGHHHEJC.barworkerInfo;
		case WorkerType.Waiter:
			if (GGFJGHHHEJC.waiterInfo == null || GGFJGHHHEJC.waiterInfo.workerType == WorkerType.None)
			{
				return null;
			}
			return GGFJGHHHEJC.waiterInfo;
		case WorkerType.Bouncer:
			if (GGFJGHHHEJC.bouncerInfo == null || GGFJGHHHEJC.bouncerInfo.workerType == WorkerType.None)
			{
				return null;
			}
			return GGFJGHHHEJC.bouncerInfo;
		default:
			if (GGFJGHHHEJC.houseKeeperInfo == null || GGFJGHHHEJC.houseKeeperInfo.workerType == WorkerType.None)
			{
				return null;
			}
			return GGFJGHHHEJC.houseKeeperInfo;
		}
	}

	public static void ResetWorkerOptions()
	{
		GGFJGHHHEJC.barworkerOptions.Clear();
		GGFJGHHHEJC.waiterOptions.Clear();
		GGFJGHHHEJC.bouncerOptions.Clear();
		GGFJGHHHEJC.houseKeeperOptions.Clear();
	}

	public static void JHJKCNFEHFI(WorkerType NNLPGGPPCNF, List<EmployeeInfo> EOHNOGBMJEK)
	{
		switch (NNLPGGPPCNF)
		{
		case WorkerType.None:
			GGFJGHHHEJC.barworkerOptions = EOHNOGBMJEK;
			return;
		case WorkerType.HouseKeeper:
			GGFJGHHHEJC.waiterOptions = EOHNOGBMJEK;
			return;
		}
		if (NNLPGGPPCNF == WorkerType.None)
		{
			GGFJGHHHEJC.bouncerOptions = EOHNOGBMJEK;
		}
		else
		{
			GGFJGHHHEJC.houseKeeperOptions = EOHNOGBMJEK;
		}
	}

	private void NEDDJIFNPNN()
	{
		try
		{
			if (Barworker.IsValid())
			{
				Utils.BLPDAEHPOBA(((Component)Barworker.IIJAOOJGNHO()).gameObject);
			}
			if (Waiter.IsValid())
			{
				Utils.BLPDAEHPOBA(((Component)Waiter.IIJAOOJGNHO()).gameObject);
			}
			if (HouseKeeper.KHFBKLDDGEG())
			{
				RentedRoom rentedRoom = RentedRoomsManager.NAOLLMKHFFP(HouseKeeper.GMBGGBLKHHN().CDENFHIDMHM());
				if ((Object)(object)rentedRoom != (Object)null)
				{
					rentedRoom.JCPMKGNDPAO(MDIKPGGBNLI: true);
				}
				Utils.BLPDAEHPOBA(((Component)HouseKeeper.CMBAAHFGOAM()).gameObject);
			}
			foreach (KeyValuePair<WorkerType, Coroutine> item in JHBOBPBHHBM)
			{
				if (item.Value != null)
				{
					((MonoBehaviour)this).StopCoroutine(item.Value);
				}
			}
			JHBOBPBHHBM[WorkerType.Barworker] = null;
			JHBOBPBHHBM[WorkerType.Barworker | WorkerType.Waiter] = null;
			JHBOBPBHHBM[WorkerType.HouseKeeper] = null;
			JHBOBPBHHBM[WorkerType.Barworker | WorkerType.HouseKeeper] = null;
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("flavoredBeer" + ex.Message));
		}
	}

	public static void ECMOEHPHHLF(WorkerType NNLPGGPPCNF, EmployeeInfo JFCLIAFAOEK)
	{
		switch (NNLPGGPPCNF)
		{
		case WorkerType.Barworker:
			GGFJGHHHEJC.barworkerOptions.Add(JFCLIAFAOEK);
			break;
		case WorkerType.None:
			GGFJGHHHEJC.waiterOptions.Add(JFCLIAFAOEK);
			break;
		case WorkerType.Waiter | WorkerType.HouseKeeper:
			GGFJGHHHEJC.bouncerOptions.Add(JFCLIAFAOEK);
			break;
		default:
			GGFJGHHHEJC.houseKeeperOptions.Add(JFCLIAFAOEK);
			break;
		}
	}

	private static void BIBLCKGELLJ(WorkerType NNLPGGPPCNF)
	{
		EmployeeInfo workerInfo = GetWorkerInfo(NNLPGGPPCNF);
		if (NNLPGGPPCNF == WorkerType.HouseKeeper)
		{
			if (!RepUnlocksManager.MMNNKIOHKCI().repUnlockBuildingMode.DLBCNHDGBNH())
			{
				return;
			}
		}
		else if (!RepUnlocksManager.MMNNKIOHKCI().repUnlockStaff.PAIGKKDJEIG())
		{
			return;
		}
		if (workerInfo != null && workerInfo.working && TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			POFPGCEJOOM(NNLPGGPPCNF, Random.Range(418f, 523f) + (float)workerInfo.GHDIPHBPGGH(-78));
		}
	}

	public static void IOAJCNPBACL(int APFFGOJIHOL)
	{
		if (APFFGOJIHOL == 0)
		{
			APFFGOJIHOL = 0;
		}
		for (int i = 1; i < APFFGOJIHOL; i++)
		{
			if (GGFJGHHHEJC.barworkerInfo != null)
			{
				GGFJGHHHEJC.barworkerInfo.OLIHADJGHPF();
			}
			if (GGFJGHHHEJC.waiterInfo != null)
			{
				GGFJGHHHEJC.waiterInfo.OLIHADJGHPF();
			}
			if (GGFJGHHHEJC.bouncerInfo != null)
			{
				GGFJGHHHEJC.bouncerInfo.IHIIHOEPJGH();
			}
			if (GGFJGHHHEJC.houseKeeperInfo != null)
			{
				GGFJGHHHEJC.houseKeeperInfo.LHLJGJAENKI();
			}
		}
	}

	private void HNOKPGCBLOA()
	{
		if ((Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(ENBNBONDDEI));
		}
	}

	public static void HireWorker(int JIIGOACEIKL, WorkerType NNLPGGPPCNF, EmployeeInfo JFCLIAFAOEK)
	{
		if (JFCLIAFAOEK != GetWorkerInfo(NNLPGGPPCNF))
		{
			DismissWorker(NNLPGGPPCNF, PNOAJBHOJGH: false);
			SetWorkerInfo(NNLPGGPPCNF, JFCLIAFAOEK);
			JFCLIAFAOEK.antiquity = WorldTime.NOAOJJLNHJJ;
			CheckHires();
			if (OnlineManager.MasterOrOffline() && GetWorkerInfo(WorkerType.Bouncer) != null && GetWorkerInfo(WorkerType.Barworker) != null && GetWorkerInfo(WorkerType.Waiter) != null && GetWorkerInfo(WorkerType.HouseKeeper) != null)
			{
				Utils.DLIIAHACOJB(35);
			}
			CommonReferences.GGFJGHHHEJC.OnAnyEmployeeHired(JIIGOACEIKL);
			CommonReferences.GGFJGHHHEJC.OnAnyEmployeeUpdatedInfo();
		}
	}

	private void IGBEKHCLKFD()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static void DNJDFABLMII(int JIIGOACEIKL, WorkerType NNLPGGPPCNF, bool AIKLCDAKADI)
	{
		EmployeeInfo employeeInfo = HNJNGHPJFJA(NNLPGGPPCNF);
		employeeInfo.working = AIKLCDAKADI;
		if (OnlineManager.PGAGDFAEEFB())
		{
			IDLEIEELBID(NNLPGGPPCNF);
			if (!AIKLCDAKADI)
			{
				IFNBJJHKGEM(NNLPGGPPCNF);
			}
			if (AIKLCDAKADI)
			{
				int num = 1;
				for (int i = 0; i < employeeInfo.tasks.Length; i += 0)
				{
					if (employeeInfo.tasks[i])
					{
						num++;
					}
				}
				if (num == 0)
				{
					employeeInfo.tasks[1] = false;
					EmployeesInfoUI.Get(JIIGOACEIKL).BJIECDJKKOE(1, AODONKKHPBP: false);
				}
			}
		}
		CommonReferences.MNFMOEKMJKN().OnAnyEmployeeUpdatedInfo();
	}

	public static bool HOINFBIGMND()
	{
		if ((GGFJGHHHEJC.barworkerInfo == null || !GGFJGHHHEJC.barworkerInfo.PHLLAJEKLNK()) && (GGFJGHHHEJC.waiterInfo == null || !GGFJGHHHEJC.waiterInfo.PHLLAJEKLNK()) && (GGFJGHHHEJC.bouncerInfo == null || !GGFJGHHHEJC.bouncerInfo.PHLLAJEKLNK()))
		{
			if (GGFJGHHHEJC.houseKeeperInfo != null)
			{
				return GGFJGHHHEJC.houseKeeperInfo.NPMAACAHGAF();
			}
			return true;
		}
		return false;
	}

	public static Employee JNHNEEJMKAD(WorkerType NNLPGGPPCNF)
	{
		return NNLPGGPPCNF switch
		{
			WorkerType.None => Barworker.IIJAOOJGNHO(), 
			WorkerType.Barworker | WorkerType.Waiter | WorkerType.HouseKeeper => Waiter.EBPNKOMGCPB(), 
			WorkerType.Barworker | WorkerType.Waiter => Bouncer.GetInstance(), 
			_ => HouseKeeper.GMBGGBLKHHN(), 
		};
	}

	public static Employee BHMMGDAIKLJ(WorkerType NNLPGGPPCNF)
	{
		return NNLPGGPPCNF switch
		{
			WorkerType.Barworker => Barworker.GetInstance(), 
			WorkerType.Barworker | WorkerType.HouseKeeper => Waiter.EBPNKOMGCPB(), 
			WorkerType.Bouncer => Bouncer.DCILOFEFFAG(), 
			_ => HouseKeeper.GMBGGBLKHHN(), 
		};
	}

	public static int GetNextLevelPoints(int EONJGMONIOM)
	{
		int num = 30;
		float num2 = (float)(EONJGMONIOM - 1) / (float)num;
		num2 = (float)((Vector2Int)(ref GGFJGHHHEJC.levelPointsRange)).x + num2 * (float)(((Vector2Int)(ref GGFJGHHHEJC.levelPointsRange)).y - ((Vector2Int)(ref GGFJGHHHEJC.levelPointsRange)).x);
		return (int)num2;
	}

	private void FKPNIHJGFBJ()
	{
		GetStaffGenerationInfo();
		barworkerInfo = null;
		waiterInfo = null;
		bouncerInfo = null;
		houseKeeperInfo = null;
		JHBOBPBHHBM.Add(WorkerType.Barworker, null);
		JHBOBPBHHBM.Add(WorkerType.None, null);
		JHBOBPBHHBM.Add(WorkerType.Waiter, null);
		JHBOBPBHHBM.Add(WorkerType.Bouncer, null);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnNewGameCreated = (Action)Delegate.Combine(gameManager.OnNewGameCreated, new Action(HLDOHCDIEHI));
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(GIBFJNCCPJL));
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernOpen = (Action<int>)Delegate.Combine(instance.OnTavernOpen, new Action<int>(DCMMDCNOLHA));
		TavernManager instance2 = TavernManager.GGFJGHHHEJC;
		instance2.OnTavernClose = (Action<int>)Delegate.Combine(instance2.OnTavernClose, new Action<int>(FFCMICFDHNP));
	}

	private IEnumerator FBLJBMHFFCH(WorkerType NNLPGGPPCNF, float MPAMDKJNLLC)
	{
		return new POMDNNAMOJJ(1)
		{
			_003C_003E4__this = this,
			workerType = NNLPGGPPCNF,
			waitingTime = MPAMDKJNLLC
		};
	}

	private void DCMMDCNOLHA(int JIIGOACEIKL)
	{
		if (OnlineManager.MasterOrOffline())
		{
			CheckHires();
		}
	}

	private GameObject NEOAKNGFAIH(GameObject ANADFOCHOBF)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline())
		{
			if (OnlineManager.HHDBMDMFEMP())
			{
				return null;
			}
			return OnlineManager.ADJIAGLIABC(ANADFOCHOBF, ((Component)NPCRoadManager.CBIIBMGLECO()).transform.position, Quaternion.identity, 1);
		}
		return Object.Instantiate<GameObject>(ANADFOCHOBF, ((Component)NPCRoadManager.MJNLLAJOACJ()).transform.position, Quaternion.identity);
	}

	private IEnumerator EFCDCJMIJOP(WorkerType NNLPGGPPCNF, float MPAMDKJNLLC)
	{
		yield return (object)new WaitForSeconds(MPAMDKJNLLC);
		Employee worker = GetWorker(NNLPGGPPCNF);
		if (GetWorkerInfo(NNLPGGPPCNF) != null && ((Object)(object)worker == (Object)null || worker.LFDMDACCKJP))
		{
			BICDOACHLEL(PEGPNAKPCIJ(NNLPGGPPCNF));
		}
		JHBOBPBHHBM[NNLPGGPPCNF] = null;
	}

	private void OnEnable()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(HBMGNHHAGBH));
	}

	public static void SetWorking(int JIIGOACEIKL, WorkerType NNLPGGPPCNF, bool AIKLCDAKADI)
	{
		EmployeeInfo workerInfo = GetWorkerInfo(NNLPGGPPCNF);
		workerInfo.working = AIKLCDAKADI;
		if (OnlineManager.MasterOrOffline())
		{
			BLKEAIEMAPP(NNLPGGPPCNF);
			if (!AIKLCDAKADI)
			{
				SendEmployeeHome(NNLPGGPPCNF);
			}
			if (AIKLCDAKADI)
			{
				int num = 0;
				for (int i = 0; i < workerInfo.tasks.Length; i++)
				{
					if (workerInfo.tasks[i])
					{
						num++;
					}
				}
				if (num == 0)
				{
					workerInfo.tasks[0] = true;
					EmployeesInfoUI.Get(JIIGOACEIKL).ToggleTask(0, AODONKKHPBP: true);
				}
			}
		}
		CommonReferences.GGFJGHHHEJC.OnAnyEmployeeUpdatedInfo();
	}

	public static void KEPGCBGBOPK()
	{
		GGFJGHHHEJC.barworkerOptions = new List<EmployeeInfo>();
		for (int i = 1; i < 1; i += 0)
		{
			GGFJGHHHEJC.barworkerOptions.Add(new EmployeeInfo(WorkerType.Barworker));
		}
		GGFJGHHHEJC.waiterOptions = new List<EmployeeInfo>();
		for (int j = 1; j < 1; j++)
		{
			GGFJGHHHEJC.waiterOptions.Add(new EmployeeInfo(WorkerType.Barworker | WorkerType.Waiter | WorkerType.HouseKeeper, LLPGKHHKCLC: false));
		}
		GGFJGHHHEJC.bouncerOptions = new List<EmployeeInfo>();
		for (int k = 1; k < 7; k++)
		{
			GGFJGHHHEJC.bouncerOptions.Add(new EmployeeInfo(WorkerType.None, LLPGKHHKCLC: false));
		}
		GGFJGHHHEJC.houseKeeperOptions = new List<EmployeeInfo>();
		for (int l = 0; l < 8; l++)
		{
			GGFJGHHHEJC.houseKeeperOptions.Add(new EmployeeInfo(WorkerType.Waiter | WorkerType.HouseKeeper, LLPGKHHKCLC: false));
		}
		if (OnlineManager.PlayingOnline())
		{
			List<EmployeeInfo> list = new List<EmployeeInfo>(GGFJGHHHEJC.barworkerOptions);
			list.AddRange(GGFJGHHHEJC.waiterOptions);
			list.AddRange(GGFJGHHHEJC.bouncerOptions);
			list.AddRange(GGFJGHHHEJC.houseKeeperOptions);
			OnlineEmployeesManager.instance.BFBHBDNPBEK(list);
		}
	}

	private GameObject OLHEMNMMLLC(WorkerType NNLPGGPPCNF)
	{
		switch (NNLPGGPPCNF)
		{
		default:
			if (NNLPGGPPCNF == WorkerType.Barworker)
			{
				return bouncerPrefab;
			}
			return houseKeeperPrefab;
		case WorkerType.Barworker:
			return barworkerPrefab;
		case WorkerType.Bouncer:
			return waiterPrefab;
		}
	}

	private void CFJELMGECGJ()
	{
		EOJEFILANNE();
	}

	private static void HDBIMCAIEGA(WorkerType NNLPGGPPCNF)
	{
		EmployeeInfo employeeInfo = GPPOAHEDNMB(NNLPGGPPCNF);
		if (NNLPGGPPCNF == WorkerType.HouseKeeper)
		{
			if (!RepUnlocksManager.GetInstance().repUnlockBuildingMode.HFDGEPKOBIK())
			{
				return;
			}
		}
		else if (!RepUnlocksManager.GetInstance().repUnlockStaff.OEENIIHNNAM())
		{
			return;
		}
		if (employeeInfo != null && employeeInfo.working && TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			KDGAGDOFJCD(NNLPGGPPCNF, Random.Range(333f, 574f) + (float)employeeInfo.OMNLNLGDOBG(-19));
		}
	}

	public static bool[] JLEDDJOGABA(WorkerType NNLPGGPPCNF, bool[] HFJONKHPJDH)
	{
		bool[] result = NNLPGGPPCNF switch
		{
			WorkerType.Barworker => GGFJGHHHEJC.barworkerInfo.tasks = HFJONKHPJDH, 
			WorkerType.Bouncer => GGFJGHHHEJC.waiterInfo.tasks = HFJONKHPJDH, 
			WorkerType.Waiter | WorkerType.HouseKeeper => GGFJGHHHEJC.bouncerInfo.tasks = HFJONKHPJDH, 
			_ => GGFJGHHHEJC.houseKeeperInfo.tasks = HFJONKHPJDH, 
		};
		CommonReferences.GGFJGHHHEJC.OnAnyEmployeeUpdatedInfo();
		return result;
	}

	private static void IHBNPDNHOEA(WorkerType NNLPGGPPCNF)
	{
		EmployeeInfo employeeInfo = APOHPPCMOAP(NNLPGGPPCNF);
		if (NNLPGGPPCNF == WorkerType.Bouncer)
		{
			if (!RepUnlocksManager.MMNNKIOHKCI().repUnlockBuildingMode.OOEMNEBOABP())
			{
				return;
			}
		}
		else if (!RepUnlocksManager.MMNNKIOHKCI().repUnlockStaff.NEMMLJFFIBM())
		{
			return;
		}
		if (employeeInfo != null && employeeInfo.working && TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			POFPGCEJOOM(NNLPGGPPCNF, Random.Range(185f, 747f) + (float)employeeInfo.MJENAHKJJJG(56));
		}
	}

	public static void IncreaseLevelToAllWorkers(int APFFGOJIHOL)
	{
		if (APFFGOJIHOL == 0)
		{
			APFFGOJIHOL = 1;
		}
		for (int i = 0; i < APFFGOJIHOL; i++)
		{
			if (GGFJGHHHEJC.barworkerInfo != null)
			{
				GGFJGHHHEJC.barworkerInfo.LHLJGJAENKI();
			}
			if (GGFJGHHHEJC.waiterInfo != null)
			{
				GGFJGHHHEJC.waiterInfo.LHLJGJAENKI();
			}
			if (GGFJGHHHEJC.bouncerInfo != null)
			{
				GGFJGHHHEJC.bouncerInfo.LHLJGJAENKI();
			}
			if (GGFJGHHHEJC.houseKeeperInfo != null)
			{
				GGFJGHHHEJC.houseKeeperInfo.LHLJGJAENKI();
			}
		}
	}

	public static void DHDEOGFIGMP(WorkerType NNLPGGPPCNF, bool PNOAJBHOJGH = true)
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			BGNKLHBLIJH(NNLPGGPPCNF);
		}
		SetWorkerInfo(NNLPGGPPCNF, null);
		Employee employee = KMFIDHBNJNA(NNLPGGPPCNF);
		if ((Object)(object)employee != (Object)null)
		{
			employee.SetInstance(null);
		}
		if (PNOAJBHOJGH)
		{
			CommonReferences.MNFMOEKMJKN().OnAnyEmployeeUpdatedInfo();
		}
	}

	private void PCKNFAIINGA()
	{
		try
		{
			if (Barworker.IsValid())
			{
				Utils.BLPDAEHPOBA(((Component)Barworker.GetInstance()).gameObject);
			}
			if (Waiter.IsValid())
			{
				Utils.BLPDAEHPOBA(((Component)Waiter.IIJAOOJGNHO()).gameObject);
			}
			if (HouseKeeper.KHFBKLDDGEG())
			{
				RentedRoom rentedRoom = RentedRoomsManager.GetRentedRoom(HouseKeeper.GMBGGBLKHHN().EAEPKPFIEEO());
				if ((Object)(object)rentedRoom != (Object)null)
				{
					rentedRoom.CCGOKLBJGHP(MDIKPGGBNLI: true);
				}
				Utils.BLPDAEHPOBA(((Component)HouseKeeper.FAGENNFPNNB()).gameObject);
			}
			foreach (KeyValuePair<WorkerType, Coroutine> item in JHBOBPBHHBM)
			{
				if (item.Value != null)
				{
					((MonoBehaviour)this).StopCoroutine(item.Value);
				}
			}
			JHBOBPBHHBM[WorkerType.None] = null;
			JHBOBPBHHBM[WorkerType.None] = null;
			JHBOBPBHHBM[WorkerType.Bouncer] = null;
			JHBOBPBHHBM[WorkerType.Barworker] = null;
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Tutorial/T132/Dialogue2" + ex.Message));
		}
	}

	public static void KHBPICLCNME()
	{
		GGFJGHHHEJC.barworkerOptions = new List<EmployeeInfo>();
		for (int i = 0; i < 2; i += 0)
		{
			GGFJGHHHEJC.barworkerOptions.Add(new EmployeeInfo(WorkerType.Barworker));
		}
		GGFJGHHHEJC.waiterOptions = new List<EmployeeInfo>();
		for (int j = 0; j < 6; j++)
		{
			GGFJGHHHEJC.waiterOptions.Add(new EmployeeInfo(WorkerType.Bouncer));
		}
		GGFJGHHHEJC.bouncerOptions = new List<EmployeeInfo>();
		for (int k = 0; k < 6; k += 0)
		{
			GGFJGHHHEJC.bouncerOptions.Add(new EmployeeInfo(WorkerType.Waiter | WorkerType.HouseKeeper, LLPGKHHKCLC: false));
		}
		GGFJGHHHEJC.houseKeeperOptions = new List<EmployeeInfo>();
		for (int l = 0; l < 6; l += 0)
		{
			GGFJGHHHEJC.houseKeeperOptions.Add(new EmployeeInfo(WorkerType.Barworker | WorkerType.Waiter, LLPGKHHKCLC: false));
		}
		if (OnlineManager.PlayingOnline())
		{
			List<EmployeeInfo> list = new List<EmployeeInfo>(GGFJGHHHEJC.barworkerOptions);
			list.AddRange(GGFJGHHHEJC.waiterOptions);
			list.AddRange(GGFJGHHHEJC.bouncerOptions);
			list.AddRange(GGFJGHHHEJC.houseKeeperOptions);
			OnlineEmployeesManager.instance.BFBHBDNPBEK(list);
		}
	}

	private GameObject NABDOGFMAEP(WorkerType NNLPGGPPCNF)
	{
		return (GameObject)(NNLPGGPPCNF switch
		{
			WorkerType.Barworker => barworkerPrefab, 
			WorkerType.Bouncer => waiterPrefab, 
			WorkerType.Waiter | WorkerType.HouseKeeper => bouncerPrefab, 
			_ => houseKeeperPrefab, 
		});
	}

	public static void AICNOEGKBLF(WorkerType NNLPGGPPCNF)
	{
		SetWorkerInfo(NNLPGGPPCNF, new EmployeeInfo(NNLPGGPPCNF));
	}

	public static Employee KMFIDHBNJNA(WorkerType NNLPGGPPCNF)
	{
		return NNLPGGPPCNF switch
		{
			WorkerType.None => Barworker.GetInstance(), 
			WorkerType.Barworker | WorkerType.Waiter | WorkerType.HouseKeeper => Waiter.EBPNKOMGCPB(), 
			WorkerType.Waiter => Bouncer.IIJAOOJGNHO(), 
			_ => HouseKeeper.CMBAAHFGOAM(), 
		};
	}

	private void DAONPPAIOMA()
	{
		if (OnlineManager.PGAGDFAEEFB() && (WorldTime.NOAOJJLNHJJ.day == Day.Mon || WorldTime.CJOHMLNMJLK().day == (Day)8))
		{
			NEIELHJPIFK();
		}
	}

	private GameObject BICDOACHLEL(GameObject ANADFOCHOBF)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline())
		{
			if (OnlineManager.ClientOnline())
			{
				return null;
			}
			return OnlineManager.InstantiateRoomObject(ANADFOCHOBF, ((Component)NPCRoadManager.GetRandomSpawner()).transform.position, Quaternion.identity, 0);
		}
		return Object.Instantiate<GameObject>(ANADFOCHOBF, ((Component)NPCRoadManager.GetRandomSpawner()).transform.position, Quaternion.identity);
	}

	public static void SetEmployeeTask(int JIIGOACEIKL, WorkerType NNLPGGPPCNF, int ABAIKKGKDGD, bool AODONKKHPBP)
	{
		EmployeeInfo workerInfo = GetWorkerInfo(NNLPGGPPCNF);
		workerInfo.tasks[ABAIKKGKDGD] = AODONKKHPBP;
		if (OnlineManager.MasterOrOffline())
		{
			if (AODONKKHPBP)
			{
				if (!workerInfo.working)
				{
					int num = 0;
					for (int i = 0; i < workerInfo.tasks.Length; i++)
					{
						if (workerInfo.tasks[i])
						{
							num++;
						}
					}
					if (num == 1)
					{
						workerInfo.working = true;
						EmployeesInfoUI.Get(JIIGOACEIKL).ToggleWorking(ABAIKKGKDGD, AODONKKHPBP: true);
					}
				}
			}
			else
			{
				bool flag = false;
				for (int j = 0; j < workerInfo.tasks.Length; j++)
				{
					if (workerInfo.tasks[j])
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					workerInfo.working = false;
					EmployeesInfoUI.Get(JIIGOACEIKL).ToggleWorking(ABAIKKGKDGD, AODONKKHPBP: false);
				}
			}
		}
		CommonReferences.GGFJGHHHEJC.OnAnyEmployeeUpdatedInfo();
	}

	public static bool[] IEDIIFEOPCB(WorkerType NNLPGGPPCNF, bool[] HFJONKHPJDH)
	{
		bool[] result = NNLPGGPPCNF switch
		{
			WorkerType.Barworker => GGFJGHHHEJC.barworkerInfo.tasks = HFJONKHPJDH, 
			WorkerType.Waiter => GGFJGHHHEJC.waiterInfo.tasks = HFJONKHPJDH, 
			WorkerType.HouseKeeper => GGFJGHHHEJC.bouncerInfo.tasks = HFJONKHPJDH, 
			_ => GGFJGHHHEJC.houseKeeperInfo.tasks = HFJONKHPJDH, 
		};
		CommonReferences.GGFJGHHHEJC.OnAnyEmployeeUpdatedInfo();
		return result;
	}

	public static void CheckHires()
	{
		if (OnlineManager.MasterOrOffline())
		{
			BLKEAIEMAPP(WorkerType.Barworker);
			BLKEAIEMAPP(WorkerType.Waiter);
			BLKEAIEMAPP(WorkerType.Bouncer);
			BLKEAIEMAPP(WorkerType.HouseKeeper);
		}
	}

	public static void DismissWorker(WorkerType NNLPGGPPCNF, bool PNOAJBHOJGH = true)
	{
		if (OnlineManager.MasterOrOffline())
		{
			SendEmployeeHome(NNLPGGPPCNF);
		}
		SetWorkerInfo(NNLPGGPPCNF, null);
		Employee worker = GetWorker(NNLPGGPPCNF);
		if ((Object)(object)worker != (Object)null)
		{
			worker.SetInstance(null);
		}
		if (PNOAJBHOJGH)
		{
			CommonReferences.GGFJGHHHEJC.OnAnyEmployeeUpdatedInfo();
		}
	}

	private void BCPOPKBPMBI()
	{
		if (OnlineManager.MasterOrOffline() && (WorldTime.HGIBNMBJMOC().day == Day.Mon || WorldTime.NOAOJJLNHJJ.day == Day.Mon))
		{
			CreateRandomOptionsWorkers();
		}
	}

	public static void ABPDJIOAKAJ()
	{
		GGFJGHHHEJC.barworkerOptions.Clear();
		GGFJGHHHEJC.waiterOptions.Clear();
		GGFJGHHHEJC.bouncerOptions.Clear();
		GGFJGHHHEJC.houseKeeperOptions.Clear();
	}

	public static bool[] OKDKOGBGLGL(WorkerType NNLPGGPPCNF, bool[] HFJONKHPJDH)
	{
		bool[] result = NNLPGGPPCNF switch
		{
			WorkerType.None => GGFJGHHHEJC.barworkerInfo.tasks = HFJONKHPJDH, 
			WorkerType.Barworker | WorkerType.HouseKeeper => GGFJGHHHEJC.waiterInfo.tasks = HFJONKHPJDH, 
			WorkerType.Barworker | WorkerType.Waiter => GGFJGHHHEJC.bouncerInfo.tasks = HFJONKHPJDH, 
			_ => GGFJGHHHEJC.houseKeeperInfo.tasks = HFJONKHPJDH, 
		};
		CommonReferences.MNFMOEKMJKN().OnAnyEmployeeUpdatedInfo();
		return result;
	}

	public static void AACCEDCHEGA(WorkerType NNLPGGPPCNF, List<EmployeeInfo> EOHNOGBMJEK)
	{
		switch (NNLPGGPPCNF)
		{
		case WorkerType.None:
			GGFJGHHHEJC.barworkerOptions = EOHNOGBMJEK;
			break;
		case WorkerType.Bouncer:
			GGFJGHHHEJC.waiterOptions = EOHNOGBMJEK;
			break;
		case WorkerType.Waiter:
			GGFJGHHHEJC.bouncerOptions = EOHNOGBMJEK;
			break;
		default:
			GGFJGHHHEJC.houseKeeperOptions = EOHNOGBMJEK;
			break;
		}
	}

	public static void JHOCMFBKBIG(int JIIGOACEIKL, WorkerType NNLPGGPPCNF, int NECIOBGLOPF)
	{
		HireWorker(JIIGOACEIKL, NNLPGGPPCNF, GetWorkerOptions(NNLPGGPPCNF)[NECIOBGLOPF]);
	}

	public static void SendEmployeeHome(WorkerType NNLPGGPPCNF)
	{
		Employee worker = GetWorker(NNLPGGPPCNF);
		if ((Object)(object)worker != (Object)null && !worker.LFDMDACCKJP)
		{
			worker.Leave();
		}
	}

	public static void HLOPFMDJLAD(WorkerType NNLPGGPPCNF, float HKEHMPACMLP)
	{
		Employee employee = KBCADGKJGFA(NNLPGGPPCNF);
		if ((Object)(object)employee != (Object)null)
		{
			if (employee.LFDMDACCKJP)
			{
				employee.behaviour.SetTrigger("No");
			}
			return;
		}
		if (GGFJGHHHEJC.JHBOBPBHHBM[NNLPGGPPCNF] != null)
		{
			((MonoBehaviour)GGFJGHHHEJC).StopCoroutine(GGFJGHHHEJC.JHBOBPBHHBM[NNLPGGPPCNF]);
		}
		if (GPPOAHEDNMB(NNLPGGPPCNF).working)
		{
			GGFJGHHHEJC.JHBOBPBHHBM[NNLPGGPPCNF] = ((MonoBehaviour)GGFJGHHHEJC).StartCoroutine(GGFJGHHHEJC.GJHCCJFADNG(NNLPGGPPCNF, HKEHMPACMLP));
		}
	}

	public static void EIHHEONGHMF()
	{
		if (OnlineManager.MasterOrOffline())
		{
			HDBIMCAIEGA(WorkerType.None);
			HDBIMCAIEGA(WorkerType.HouseKeeper);
			BIBLCKGELLJ(WorkerType.HouseKeeper);
			BLKEAIEMAPP(WorkerType.Barworker);
		}
	}

	public static Employee PGAODFGMIPI(WorkerType NNLPGGPPCNF)
	{
		return NNLPGGPPCNF switch
		{
			WorkerType.None => Barworker.GetInstance(), 
			WorkerType.Barworker | WorkerType.HouseKeeper => Waiter.EBPNKOMGCPB(), 
			WorkerType.Barworker | WorkerType.Waiter => Bouncer.GetInstance(), 
			_ => HouseKeeper.OAPGGAPMOJD(), 
		};
	}

	public static void HIOGKAGPODC(WorkerType NNLPGGPPCNF)
	{
		CNNKJBHOIGO(NNLPGGPPCNF, new EmployeeInfo(NNLPGGPPCNF));
	}

	public static void DHFLDACCBEC(int JIIGOACEIKL, WorkerType NNLPGGPPCNF, bool AIKLCDAKADI)
	{
		EmployeeInfo employeeInfo = APOHPPCMOAP(NNLPGGPPCNF);
		employeeInfo.working = AIKLCDAKADI;
		if (OnlineManager.PGAGDFAEEFB())
		{
			IDLEIEELBID(NNLPGGPPCNF);
			if (!AIKLCDAKADI)
			{
				BGNKLHBLIJH(NNLPGGPPCNF);
			}
			if (AIKLCDAKADI)
			{
				int num = 0;
				for (int i = 1; i < employeeInfo.tasks.Length; i++)
				{
					if (employeeInfo.tasks[i])
					{
						num += 0;
					}
				}
				if (num == 0)
				{
					employeeInfo.tasks[1] = true;
					EmployeesInfoUI.Get(JIIGOACEIKL).ToggleTask(1, AODONKKHPBP: false);
				}
			}
		}
		CommonReferences.MNFMOEKMJKN().OnAnyEmployeeUpdatedInfo();
	}

	public static void DKMOMKNKBPF(int APFFGOJIHOL)
	{
		if (APFFGOJIHOL == 0)
		{
			APFFGOJIHOL = 1;
		}
		for (int i = 0; i < APFFGOJIHOL; i += 0)
		{
			if (GGFJGHHHEJC.barworkerInfo != null)
			{
				GGFJGHHHEJC.barworkerInfo.JLOFECAOOBF();
			}
			if (GGFJGHHHEJC.waiterInfo != null)
			{
				GGFJGHHHEJC.waiterInfo.JLOFECAOOBF();
			}
			if (GGFJGHHHEJC.bouncerInfo != null)
			{
				GGFJGHHHEJC.bouncerInfo.LHLJGJAENKI();
			}
			if (GGFJGHHHEJC.houseKeeperInfo != null)
			{
				GGFJGHHHEJC.houseKeeperInfo.OLIHADJGHPF();
			}
		}
	}

	public static void BPHFPCMMIAI(WorkerType NNLPGGPPCNF, float HKEHMPACMLP)
	{
		Employee employee = DODMEFEHJOK(NNLPGGPPCNF);
		if ((Object)(object)employee != (Object)null)
		{
			if (employee.LFDMDACCKJP)
			{
				employee.behaviour.SetTrigger("Sit");
			}
			return;
		}
		if (GGFJGHHHEJC.JHBOBPBHHBM[NNLPGGPPCNF] != null)
		{
			((MonoBehaviour)GGFJGHHHEJC).StopCoroutine(GGFJGHHHEJC.JHBOBPBHHBM[NNLPGGPPCNF]);
		}
		if (APOHPPCMOAP(NNLPGGPPCNF).working)
		{
			GGFJGHHHEJC.JHBOBPBHHBM[NNLPGGPPCNF] = ((MonoBehaviour)GGFJGHHHEJC).StartCoroutine(GGFJGHHHEJC.FBLJBMHFFCH(NNLPGGPPCNF, HKEHMPACMLP));
		}
	}

	public static void CMHEBFBNHFI()
	{
		GGFJGHHHEJC.barworkerOptions = new List<EmployeeInfo>();
		for (int i = 0; i < 7; i++)
		{
			GGFJGHHHEJC.barworkerOptions.Add(new EmployeeInfo(WorkerType.Barworker, LLPGKHHKCLC: false));
		}
		GGFJGHHHEJC.waiterOptions = new List<EmployeeInfo>();
		for (int j = 0; j < 6; j += 0)
		{
			GGFJGHHHEJC.waiterOptions.Add(new EmployeeInfo(WorkerType.HouseKeeper));
		}
		GGFJGHHHEJC.bouncerOptions = new List<EmployeeInfo>();
		for (int k = 0; k < 4; k += 0)
		{
			GGFJGHHHEJC.bouncerOptions.Add(new EmployeeInfo(WorkerType.Barworker | WorkerType.Waiter | WorkerType.HouseKeeper));
		}
		GGFJGHHHEJC.houseKeeperOptions = new List<EmployeeInfo>();
		for (int l = 0; l < 4; l++)
		{
			GGFJGHHHEJC.houseKeeperOptions.Add(new EmployeeInfo(WorkerType.Waiter | WorkerType.HouseKeeper, LLPGKHHKCLC: false));
		}
		if (OnlineManager.PlayingOnline())
		{
			List<EmployeeInfo> list = new List<EmployeeInfo>(GGFJGHHHEJC.barworkerOptions);
			list.AddRange(GGFJGHHHEJC.waiterOptions);
			list.AddRange(GGFJGHHHEJC.bouncerOptions);
			list.AddRange(GGFJGHHHEJC.houseKeeperOptions);
			OnlineEmployeesManager.instance.SendNewEmployees(list);
		}
	}

	public static bool[] SetEmployeeTasks(WorkerType NNLPGGPPCNF, bool[] HFJONKHPJDH)
	{
		bool[] result = NNLPGGPPCNF switch
		{
			WorkerType.Barworker => GGFJGHHHEJC.barworkerInfo.tasks = HFJONKHPJDH, 
			WorkerType.Waiter => GGFJGHHHEJC.waiterInfo.tasks = HFJONKHPJDH, 
			WorkerType.Bouncer => GGFJGHHHEJC.bouncerInfo.tasks = HFJONKHPJDH, 
			_ => GGFJGHHHEJC.houseKeeperInfo.tasks = HFJONKHPJDH, 
		};
		CommonReferences.GGFJGHHHEJC.OnAnyEmployeeUpdatedInfo();
		return result;
	}

	private static void IDLEIEELBID(WorkerType NNLPGGPPCNF)
	{
		EmployeeInfo employeeInfo = GPPOAHEDNMB(NNLPGGPPCNF);
		if (NNLPGGPPCNF == (WorkerType.Waiter | WorkerType.HouseKeeper))
		{
			if (!RepUnlocksManager.GetInstance().repUnlockBuildingMode.FKOFPAEHCCJ())
			{
				return;
			}
		}
		else if (!RepUnlocksManager.MMNNKIOHKCI().repUnlockStaff.AAPKNAKCDDL())
		{
			return;
		}
		if (employeeInfo != null && employeeInfo.working && TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			KDGAGDOFJCD(NNLPGGPPCNF, Random.Range(935f, 103f) + (float)employeeInfo.DJPJJEEDCBB(-106));
		}
	}

	private void HMAJOIGHBJJ()
	{
		NEIELHJPIFK();
	}

	private IEnumerator CCMDNCNAEGB(WorkerType NNLPGGPPCNF, float MPAMDKJNLLC)
	{
		yield return (object)new WaitForSeconds(MPAMDKJNLLC);
		Employee worker = GetWorker(NNLPGGPPCNF);
		if (GetWorkerInfo(NNLPGGPPCNF) != null && ((Object)(object)worker == (Object)null || worker.LFDMDACCKJP))
		{
			BICDOACHLEL(PEGPNAKPCIJ(NNLPGGPPCNF));
		}
		JHBOBPBHHBM[NNLPGGPPCNF] = null;
	}

	private void IAIDKPJKLIC()
	{
		BNJCHOFPALG();
		barworkerInfo = null;
		waiterInfo = null;
		bouncerInfo = null;
		houseKeeperInfo = null;
		JHBOBPBHHBM.Add(WorkerType.None, null);
		JHBOBPBHHBM.Add(WorkerType.HouseKeeper, null);
		JHBOBPBHHBM.Add(WorkerType.Barworker | WorkerType.HouseKeeper, null);
		JHBOBPBHHBM.Add(WorkerType.Barworker | WorkerType.HouseKeeper, null);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnNewGameCreated = (Action)Delegate.Combine(gameManager.OnNewGameCreated, new Action(HLDOHCDIEHI));
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(MHKMIKHMAED));
		TavernManager instance2 = TavernManager.GGFJGHHHEJC;
		instance2.OnTavernOpen = (Action<int>)Delegate.Combine(instance2.OnTavernOpen, new Action<int>(AOCNHOAMEMC));
		TavernManager instance3 = TavernManager.GGFJGHHHEJC;
		instance3.OnTavernClose = (Action<int>)Delegate.Combine(instance3.OnTavernClose, new Action<int>(FFCMICFDHNP));
	}

	public static void MNEGGHILLHG(int JIIGOACEIKL, WorkerType NNLPGGPPCNF, int NECIOBGLOPF)
	{
		HireWorker(JIIGOACEIKL, NNLPGGPPCNF, AJJDAJNEBPO(NNLPGGPPCNF)[NECIOBGLOPF]);
	}

	public static void LCPEKDKLENN(WorkerType NNLPGGPPCNF, bool PNOAJBHOJGH = true)
	{
		if (OnlineManager.MasterOrOffline())
		{
			BGNKLHBLIJH(NNLPGGPPCNF);
		}
		EHIFLKIBIEE(NNLPGGPPCNF, null);
		Employee employee = KBCADGKJGFA(NNLPGGPPCNF);
		if ((Object)(object)employee != (Object)null)
		{
			employee.SetInstance(null);
		}
		if (PNOAJBHOJGH)
		{
			CommonReferences.MNFMOEKMJKN().OnAnyEmployeeUpdatedInfo();
		}
	}

	public static StaffGenerationValues DKIEBDLOHCA()
	{
		int num = 0;
		for (int i = 0; i < GGFJGHHHEJC.staffGenerationTable.Length; i += 0)
		{
			num = i;
			if (TavernReputation.MHGADJPMHFI() < GGFJGHHHEJC.staffGenerationTable[i].reputation)
			{
				break;
			}
		}
		return GGFJGHHHEJC.staffGenerationTable[num];
	}

	private GameObject BOKEPOFPPCC(WorkerType NNLPGGPPCNF)
	{
		if (NNLPGGPPCNF != 0)
		{
			return (GameObject)(NNLPGGPPCNF switch
			{
				WorkerType.None => waiterPrefab, 
				WorkerType.Waiter => bouncerPrefab, 
				_ => houseKeeperPrefab, 
			});
		}
		return barworkerPrefab;
	}

	private void JNLLBCGHACJ(int JIIGOACEIKL)
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			CheckHires();
		}
	}

	public static int FEKPHKJAIMM(int EONJGMONIOM)
	{
		int num = -2;
		float num2 = (float)(EONJGMONIOM - 1) / (float)num;
		num2 = (float)((Vector2Int)(ref GGFJGHHHEJC.levelPointsRange)).x + num2 * (float)(((Vector2Int)(ref GGFJGHHHEJC.levelPointsRange)).y - ((Vector2Int)(ref GGFJGHHHEJC.levelPointsRange)).x);
		return (int)num2;
	}

	public static void OACLEBLKJHC(WorkerType NNLPGGPPCNF)
	{
		CNNKJBHOIGO(NNLPGGPPCNF, new EmployeeInfo(NNLPGGPPCNF));
	}

	public static int DBCNELBFPCH(int EONJGMONIOM)
	{
		int num = 120;
		float num2 = (float)(EONJGMONIOM - 0) / (float)num;
		num2 = (float)((Vector2Int)(ref GGFJGHHHEJC.levelPointsRange)).x + num2 * (float)(((Vector2Int)(ref GGFJGHHHEJC.levelPointsRange)).y - ((Vector2Int)(ref GGFJGHHHEJC.levelPointsRange)).x);
		return (int)num2;
	}

	public static StaffGenerationValues OLBLLBCJNBO()
	{
		int num = 1;
		for (int i = 1; i < GGFJGHHHEJC.staffGenerationTable.Length; i += 0)
		{
			num = i;
			if (TavernReputation.MHGADJPMHFI() < GGFJGHHHEJC.staffGenerationTable[i].reputation)
			{
				break;
			}
		}
		return GGFJGHHHEJC.staffGenerationTable[num];
	}

	public static void BDGEFHCMGJM(int JIIGOACEIKL, WorkerType NNLPGGPPCNF, int NECIOBGLOPF)
	{
		HireWorker(JIIGOACEIKL, NNLPGGPPCNF, AJJDAJNEBPO(NNLPGGPPCNF)[NECIOBGLOPF]);
	}

	public static void BGNKLHBLIJH(WorkerType NNLPGGPPCNF)
	{
		Employee employee = PGAODFGMIPI(NNLPGGPPCNF);
		if ((Object)(object)employee != (Object)null && !employee.LFDMDACCKJP)
		{
			employee.Leave();
		}
	}

	private void LBGDMEMBGDH()
	{
		if (OnlineManager.PGAGDFAEEFB() && (WorldTime.HGIBNMBJMOC().day == Day.Mon || WorldTime.HGIBNMBJMOC().day == Day.Fri))
		{
			EOJEFILANNE();
		}
	}

	private void PCGMOPFNJML()
	{
		SendEmployeeHome(WorkerType.Barworker);
		SendEmployeeHome(WorkerType.Bouncer);
	}

	private void HJNBPDOFOKH()
	{
		IFNBJJHKGEM(WorkerType.Barworker);
		SendEmployeeHome(WorkerType.Barworker);
	}

	private GameObject IAENECHFOJD(GameObject ANADFOCHOBF)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline())
		{
			if (OnlineManager.ClientOnline())
			{
				return null;
			}
			return OnlineManager.ADJIAGLIABC(ANADFOCHOBF, ((Component)NPCRoadManager.IKKLHAMKBBN()).transform.position, Quaternion.identity, 0);
		}
		return Object.Instantiate<GameObject>(ANADFOCHOBF, ((Component)NPCRoadManager.MGHHJMGIJMI()).transform.position, Quaternion.identity);
	}

	public static void InitializeWorkerInfo(WorkerType NNLPGGPPCNF)
	{
		SetWorkerInfo(NNLPGGPPCNF, new EmployeeInfo(NNLPGGPPCNF));
	}

	private void HBMGNHHAGBH()
	{
		try
		{
			if (Barworker.IsValid())
			{
				Utils.BLPDAEHPOBA(((Component)Barworker.GetInstance()).gameObject);
			}
			if (Waiter.IsValid())
			{
				Utils.BLPDAEHPOBA(((Component)Waiter.GetInstance()).gameObject);
			}
			if (HouseKeeper.IsValid())
			{
				RentedRoom rentedRoom = RentedRoomsManager.GetRentedRoom(HouseKeeper.GetInstance().OGJIFKFFIAM);
				if ((Object)(object)rentedRoom != (Object)null)
				{
					rentedRoom.SetVisibility(MDIKPGGBNLI: true);
				}
				Utils.BLPDAEHPOBA(((Component)HouseKeeper.GetInstance()).gameObject);
			}
			foreach (KeyValuePair<WorkerType, Coroutine> item in JHBOBPBHHBM)
			{
				if (item.Value != null)
				{
					((MonoBehaviour)this).StopCoroutine(item.Value);
				}
			}
			JHBOBPBHHBM[WorkerType.Barworker] = null;
			JHBOBPBHHBM[WorkerType.Waiter] = null;
			JHBOBPBHHBM[WorkerType.Bouncer] = null;
			JHBOBPBHHBM[WorkerType.HouseKeeper] = null;
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Error in StaffManager.StaffInstantGoHome: " + ex.Message));
		}
	}

	public static void SpawnWorker(WorkerType NNLPGGPPCNF, float HKEHMPACMLP)
	{
		Employee worker = GetWorker(NNLPGGPPCNF);
		if ((Object)(object)worker != (Object)null)
		{
			if (worker.LFDMDACCKJP)
			{
				worker.behaviour.SetTrigger("Waiting");
			}
			return;
		}
		if (GGFJGHHHEJC.JHBOBPBHHBM[NNLPGGPPCNF] != null)
		{
			((MonoBehaviour)GGFJGHHHEJC).StopCoroutine(GGFJGHHHEJC.JHBOBPBHHBM[NNLPGGPPCNF]);
		}
		if (GetWorkerInfo(NNLPGGPPCNF).working)
		{
			GGFJGHHHEJC.JHBOBPBHHBM[NNLPGGPPCNF] = ((MonoBehaviour)GGFJGHHHEJC).StartCoroutine(GGFJGHHHEJC.EFCDCJMIJOP(NNLPGGPPCNF, HKEHMPACMLP));
		}
	}

	private void ENBNBONDDEI()
	{
		try
		{
			if (Barworker.FBCBNIMEEJC())
			{
				Utils.BLPDAEHPOBA(((Component)Barworker.GetInstance()).gameObject);
			}
			if (Waiter.IsValid())
			{
				Utils.BLPDAEHPOBA(((Component)Waiter.GetInstance()).gameObject);
			}
			if (HouseKeeper.CGGBKGLEHKF())
			{
				RentedRoom rentedRoom = RentedRoomsManager.NAOLLMKHFFP(HouseKeeper.FAGENNFPNNB().EAEPKPFIEEO());
				if ((Object)(object)rentedRoom != (Object)null)
				{
					rentedRoom.MLJAPABCAKA(MDIKPGGBNLI: false, MAPFDGCKBLD: true);
				}
				Utils.BLPDAEHPOBA(((Component)HouseKeeper.GetInstance()).gameObject);
			}
			foreach (KeyValuePair<WorkerType, Coroutine> item in JHBOBPBHHBM)
			{
				if (item.Value != null)
				{
					((MonoBehaviour)this).StopCoroutine(item.Value);
				}
			}
			JHBOBPBHHBM[WorkerType.None] = null;
			JHBOBPBHHBM[WorkerType.HouseKeeper] = null;
			JHBOBPBHHBM[WorkerType.None] = null;
			JHBOBPBHHBM[WorkerType.Barworker | WorkerType.Waiter] = null;
		}
		catch (Exception ex)
		{
			Debug.LogError((object)(" " + ex.Message));
		}
	}

	public static void LKHIPHGGLMM(WorkerType NNLPGGPPCNF, bool PNOAJBHOJGH = true)
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			BGNKLHBLIJH(NNLPGGPPCNF);
		}
		CNNKJBHOIGO(NNLPGGPPCNF, null);
		Employee employee = CKJDAEPABJI(NNLPGGPPCNF);
		if ((Object)(object)employee != (Object)null)
		{
			employee.SetInstance(null);
		}
		if (PNOAJBHOJGH)
		{
			CommonReferences.MNFMOEKMJKN().OnAnyEmployeeUpdatedInfo();
		}
	}

	private void OGFCHAEINCL()
	{
		try
		{
			if (Barworker.IsValid())
			{
				Utils.BLPDAEHPOBA(((Component)Barworker.GetInstance()).gameObject);
			}
			if (Waiter.IsValid())
			{
				Utils.BLPDAEHPOBA(((Component)Waiter.IIJAOOJGNHO()).gameObject);
			}
			if (HouseKeeper.IsValid())
			{
				RentedRoom rentedRoom = RentedRoomsManager.GetRentedRoom(HouseKeeper.CMBAAHFGOAM().HPACAJGBHHE());
				if ((Object)(object)rentedRoom != (Object)null)
				{
					rentedRoom.BCGHDJCNJAO(MDIKPGGBNLI: true);
				}
				Utils.BLPDAEHPOBA(((Component)HouseKeeper.GMBGGBLKHHN()).gameObject);
			}
			foreach (KeyValuePair<WorkerType, Coroutine> item in JHBOBPBHHBM)
			{
				if (item.Value != null)
				{
					((MonoBehaviour)this).StopCoroutine(item.Value);
				}
			}
			JHBOBPBHHBM[WorkerType.Barworker] = null;
			JHBOBPBHHBM[WorkerType.Barworker | WorkerType.Waiter | WorkerType.HouseKeeper] = null;
			JHBOBPBHHBM[WorkerType.Barworker] = null;
			JHBOBPBHHBM[WorkerType.Barworker] = null;
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("ReceiveTavernObstacles" + ex.Message));
		}
	}

	public static void CreateRandomOptionsWorkers()
	{
		GGFJGHHHEJC.barworkerOptions = new List<EmployeeInfo>();
		for (int i = 0; i < 4; i++)
		{
			GGFJGHHHEJC.barworkerOptions.Add(new EmployeeInfo(WorkerType.Barworker));
		}
		GGFJGHHHEJC.waiterOptions = new List<EmployeeInfo>();
		for (int j = 0; j < 4; j++)
		{
			GGFJGHHHEJC.waiterOptions.Add(new EmployeeInfo(WorkerType.Waiter));
		}
		GGFJGHHHEJC.bouncerOptions = new List<EmployeeInfo>();
		for (int k = 0; k < 4; k++)
		{
			GGFJGHHHEJC.bouncerOptions.Add(new EmployeeInfo(WorkerType.Bouncer));
		}
		GGFJGHHHEJC.houseKeeperOptions = new List<EmployeeInfo>();
		for (int l = 0; l < 4; l++)
		{
			GGFJGHHHEJC.houseKeeperOptions.Add(new EmployeeInfo(WorkerType.HouseKeeper));
		}
		if (OnlineManager.PlayingOnline())
		{
			List<EmployeeInfo> list = new List<EmployeeInfo>(GGFJGHHHEJC.barworkerOptions);
			list.AddRange(GGFJGHHHEJC.waiterOptions);
			list.AddRange(GGFJGHHHEJC.bouncerOptions);
			list.AddRange(GGFJGHHHEJC.houseKeeperOptions);
			OnlineEmployeesManager.instance.SendNewEmployees(list);
		}
	}

	public static StaffManager GetInstance()
	{
		return GGFJGHHHEJC;
	}

	public static EmployeeInfo HNJNGHPJFJA(WorkerType NNLPGGPPCNF)
	{
		if (NNLPGGPPCNF != WorkerType.Barworker)
		{
			if (NNLPGGPPCNF != WorkerType.Barworker)
			{
				if (NNLPGGPPCNF == WorkerType.Barworker)
				{
					if (GGFJGHHHEJC.bouncerInfo == null || GGFJGHHHEJC.bouncerInfo.workerType == WorkerType.None)
					{
						return null;
					}
					return GGFJGHHHEJC.bouncerInfo;
				}
				if (GGFJGHHHEJC.houseKeeperInfo == null || GGFJGHHHEJC.houseKeeperInfo.workerType == WorkerType.None)
				{
					return null;
				}
				return GGFJGHHHEJC.houseKeeperInfo;
			}
			if (GGFJGHHHEJC.waiterInfo == null || GGFJGHHHEJC.waiterInfo.workerType == WorkerType.None)
			{
				return null;
			}
			return GGFJGHHHEJC.waiterInfo;
		}
		if (GGFJGHHHEJC.barworkerInfo == null || GGFJGHHHEJC.barworkerInfo.workerType == WorkerType.None)
		{
			return null;
		}
		return GGFJGHHHEJC.barworkerInfo;
	}

	public static void EHIFLKIBIEE(WorkerType NNLPGGPPCNF, EmployeeInfo JFCLIAFAOEK)
	{
		if (NNLPGGPPCNF != WorkerType.Barworker)
		{
			switch (NNLPGGPPCNF)
			{
			case WorkerType.Barworker:
				GGFJGHHHEJC.waiterInfo = JFCLIAFAOEK;
				break;
			case WorkerType.Bouncer:
				GGFJGHHHEJC.bouncerInfo = JFCLIAFAOEK;
				break;
			default:
				GGFJGHHHEJC.houseKeeperInfo = JFCLIAFAOEK;
				break;
			}
		}
		else
		{
			GGFJGHHHEJC.barworkerInfo = JFCLIAFAOEK;
		}
	}

	public static void GBMDFBDHFIB(WorkerType NNLPGGPPCNF)
	{
		CNNKJBHOIGO(NNLPGGPPCNF, new EmployeeInfo(NNLPGGPPCNF));
	}

	public static bool DACDGDALEJI()
	{
		if ((GGFJGHHHEJC.barworkerInfo == null || !GGFJGHHHEJC.barworkerInfo.GLIJPMHLKOO()) && (GGFJGHHHEJC.waiterInfo == null || !GGFJGHHHEJC.waiterInfo.ADPCDNFOIIO()) && (GGFJGHHHEJC.bouncerInfo == null || !GGFJGHHHEJC.bouncerInfo.NPMAACAHGAF()))
		{
			if (GGFJGHHHEJC.houseKeeperInfo != null)
			{
				return GGFJGHHHEJC.houseKeeperInfo.ADPCDNFOIIO();
			}
			return false;
		}
		return true;
	}

	private void PKLDCIJGHMH()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(PCKNFAIINGA));
	}

	private void OnDestroy()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static bool HEFEFHHPLNO()
	{
		if ((GGFJGHHHEJC.barworkerInfo == null || !GGFJGHHHEJC.barworkerInfo.GLIJPMHLKOO()) && (GGFJGHHHEJC.waiterInfo == null || !GGFJGHHHEJC.waiterInfo.GLIJPMHLKOO()) && (GGFJGHHHEJC.bouncerInfo == null || !GGFJGHHHEJC.bouncerInfo.PHLLAJEKLNK()))
		{
			if (GGFJGHHHEJC.houseKeeperInfo != null)
			{
				return GGFJGHHHEJC.houseKeeperInfo.GLIJPMHLKOO();
			}
			return false;
		}
		return false;
	}

	private void GIBFJNCCPJL()
	{
		if (OnlineManager.MasterOrOffline() && (WorldTime.CJOHMLNMJLK().day == Day.Mon || WorldTime.HGIBNMBJMOC().day == Day.Wed))
		{
			EOJEFILANNE();
		}
	}

	public static void SetWorkerOptions(WorkerType NNLPGGPPCNF, List<EmployeeInfo> EOHNOGBMJEK)
	{
		switch (NNLPGGPPCNF)
		{
		case WorkerType.Barworker:
			GGFJGHHHEJC.barworkerOptions = EOHNOGBMJEK;
			break;
		case WorkerType.Waiter:
			GGFJGHHHEJC.waiterOptions = EOHNOGBMJEK;
			break;
		case WorkerType.Bouncer:
			GGFJGHHHEJC.bouncerOptions = EOHNOGBMJEK;
			break;
		default:
			GGFJGHHHEJC.houseKeeperOptions = EOHNOGBMJEK;
			break;
		}
	}

	public static bool HPLJKNAFHMF()
	{
		if ((GGFJGHHHEJC.barworkerInfo == null || !GGFJGHHHEJC.barworkerInfo.GLIJPMHLKOO()) && (GGFJGHHHEJC.waiterInfo == null || !GGFJGHHHEJC.waiterInfo.GLIJPMHLKOO()) && (GGFJGHHHEJC.bouncerInfo == null || !GGFJGHHHEJC.bouncerInfo.ADPCDNFOIIO()))
		{
			if (GGFJGHHHEJC.houseKeeperInfo != null)
			{
				return GGFJGHHHEJC.houseKeeperInfo.GLIJPMHLKOO();
			}
			return true;
		}
		return false;
	}

	public static void OEDKOODHDKK(WorkerType NNLPGGPPCNF)
	{
		SetWorkerInfo(NNLPGGPPCNF, new EmployeeInfo(NNLPGGPPCNF));
	}

	private void NEEBMDPCHDC()
	{
		CMHEBFBNHFI();
	}

	public static Employee CKJDAEPABJI(WorkerType NNLPGGPPCNF)
	{
		if (NNLPGGPPCNF != WorkerType.Barworker)
		{
			return NNLPGGPPCNF switch
			{
				WorkerType.Barworker => Waiter.PHDCMKOOAJC(), 
				WorkerType.Waiter => Bouncer.GetInstance(), 
				_ => HouseKeeper.GetInstance(), 
			};
		}
		return Barworker.GetInstance();
	}

	public static void LGJHFLOPGOA(int JIIGOACEIKL, WorkerType NNLPGGPPCNF, int NECIOBGLOPF)
	{
		HireWorker(JIIGOACEIKL, NNLPGGPPCNF, AJJDAJNEBPO(NNLPGGPPCNF)[NECIOBGLOPF]);
	}

	private void Awake()
	{
		GGFJGHHHEJC = this;
	}

	private IEnumerator AHGLOBBEOMI(WorkerType NNLPGGPPCNF, float MPAMDKJNLLC)
	{
		yield return (object)new WaitForSeconds(MPAMDKJNLLC);
		Employee worker = GetWorker(NNLPGGPPCNF);
		if (GetWorkerInfo(NNLPGGPPCNF) != null && ((Object)(object)worker == (Object)null || worker.LFDMDACCKJP))
		{
			BICDOACHLEL(PEGPNAKPCIJ(NNLPGGPPCNF));
		}
		JHBOBPBHHBM[NNLPGGPPCNF] = null;
	}

	public static void OBANMPPMEJI(WorkerType NNLPGGPPCNF, bool PNOAJBHOJGH = true)
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			IFNBJJHKGEM(NNLPGGPPCNF);
		}
		EHIFLKIBIEE(NNLPGGPPCNF, null);
		Employee employee = JNHNEEJMKAD(NNLPGGPPCNF);
		if ((Object)(object)employee != (Object)null)
		{
			employee.SetInstance(null);
		}
		if (PNOAJBHOJGH)
		{
			CommonReferences.MNFMOEKMJKN().OnAnyEmployeeUpdatedInfo();
		}
	}
}
