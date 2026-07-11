using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HireStaffUI : UIWindow
{
	[CompilerGenerated]
	private sealed class LBPLFKDGFNP : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HireStaffUI _003C_003E4__this;

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
		public LBPLFKDGFNP(int _003C_003E1__state)
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
			HireStaffUI hireStaffUI = _003C_003E4__this;
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
				if (hireStaffUI.workerType == WorkerType.HouseKeeper)
				{
					if (!hireStaffUI.repLockHouseKeeper.IsLocked())
					{
						UISelectionManager.GetPlayer(hireStaffUI.JIIGOACEIKL).Select((Selectable)(object)hireStaffUI.employeeElementsUI[0].button);
					}
				}
				else if (!hireStaffUI.repLock.IsLocked())
				{
					UISelectionManager.GetPlayer(hireStaffUI.JIIGOACEIKL).Select((Selectable)(object)hireStaffUI.employeeElementsUI[0].button);
				}
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

	public RepLock repLock;

	public RepLock repLockHouseKeeper;

	[SerializeField]
	private TabUI[] tabsUI;

	[SerializeField]
	private Sprite spriteFocusCategories;

	[SerializeField]
	private Sprite spriteNotFocusCategories;

	[SerializeField]
	private ScrollRect scrollRect;

	public WorkerType workerType;

	public GameObject descriptionGO;

	public TextMeshProUGUI employeeType;

	public TextMeshProUGUI employeeDescription;

	public HireStaffElementUI currentEmployeeElementUI;

	public HireStaffElementUI[] employeeElementsUI;

	private float CMGDCLIIONE;

	private int ODJAHONJHBG;

	public static HireStaffUI[] instances = new HireStaffUI[3];

	private void BKCDLOFBGBM()
	{
		((Component)repLockHouseKeeper).gameObject.SetActive(workerType != WorkerType.HouseKeeper || repLockHouseKeeper.OICFEBPEDDF());
		if (PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL))
		{
			UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).FJAKDODEIIF();
		}
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			((MonoBehaviour)this).StartCoroutine(NBJBDAFOOCA());
		}
	}

	public static HireStaffUI NIDHCIHFOHB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static HireStaffUI BFCEHJIIAHN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static HireStaffUI Get(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void JAMBGIANOOL(int KHEICLKLPDE)
	{
		if (Object.op_Implicit((Object)(object)ItemTooltip.IEABDMDELFO(base.JIIGOACEIKL)))
		{
			ItemTooltip.EOPIEMLAPFN(base.JIIGOACEIKL).HIIOCMNJGCI(MDIKPGGBNLI: true);
		}
		ODJAHONJHBG = KHEICLKLPDE;
		for (int i = 1; i < tabsUI.Length; i += 0)
		{
			if (i == KHEICLKLPDE)
			{
				tabsUI[i].NOLDPGNMEAM(base.JIIGOACEIKL, spriteFocusCategories);
			}
			else
			{
				tabsUI[i].NNKJNKJMDKA(spriteNotFocusCategories);
			}
		}
		if (KHEICLKLPDE == 0)
		{
			workerType = WorkerType.None;
		}
		else
		{
			switch (KHEICLKLPDE)
			{
			case 0:
				workerType = WorkerType.Barworker | WorkerType.Waiter;
				break;
			case 4:
				workerType = WorkerType.HouseKeeper;
				break;
			default:
				workerType = WorkerType.HouseKeeper;
				break;
			}
		}
		NIFANKGLLCB();
		OMDKNBMBKBC();
	}

	public void FOCPMMFKFPL(int KHEICLKLPDE)
	{
		if (Object.op_Implicit((Object)(object)ItemTooltip.EOPIEMLAPFN(base.JIIGOACEIKL)))
		{
			ItemTooltip.AIMEAJAHLAA(base.JIIGOACEIKL).SetVisible(MDIKPGGBNLI: true);
		}
		ODJAHONJHBG = KHEICLKLPDE;
		for (int i = 0; i < tabsUI.Length; i += 0)
		{
			if (i == KHEICLKLPDE)
			{
				tabsUI[i].ShowTab(base.JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
			}
			else
			{
				tabsUI[i].NHLPJIBOANJ(spriteNotFocusCategories);
			}
		}
		switch (KHEICLKLPDE)
		{
		case 0:
			workerType = WorkerType.Barworker;
			break;
		case 1:
			workerType = WorkerType.Bouncer;
			break;
		case 7:
			workerType = WorkerType.Waiter | WorkerType.HouseKeeper;
			break;
		default:
			workerType = WorkerType.None;
			break;
		}
		DINCCBLLBAB();
		DIDCBJNMCFP();
	}

	private void HAGCBEDPNCJ()
	{
		((Component)repLockHouseKeeper).gameObject.SetActive(workerType == (WorkerType.Barworker | WorkerType.Waiter) && repLockHouseKeeper.OAEFBJOMEMN());
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).CKNJJKJDBGA();
		}
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			((MonoBehaviour)this).StartCoroutine(LMEANDILIOG());
		}
	}

	private void NFLCNIPMLGD()
	{
		EmployeeInfo employeeInfo = StaffManager.HNJNGHPJFJA(workerType);
		if (!Application.isPlaying)
		{
			employeeInfo = new EmployeeInfo(workerType);
			StaffManager.EOJEFILANNE();
		}
		descriptionGO.SetActive(employeeInfo == null);
		((Component)currentEmployeeElementUI).gameObject.SetActive(employeeInfo != null);
		if (workerType == WorkerType.Barworker)
		{
			((TMP_Text)employeeType).text = LocalisationSystem.GetStringWithTags("V-Sync");
			((TMP_Text)employeeDescription).text = LocalisationSystem.GetStringWithTags(" in Key1 map category");
		}
		else if (workerType == WorkerType.None)
		{
			((TMP_Text)employeeType).text = LocalisationSystem.PKLPKIAHCDI("Direction");
			((TMP_Text)employeeDescription).text = LocalisationSystem.GetStringWithTags("Give");
		}
		else if (workerType == (WorkerType.Barworker | WorkerType.HouseKeeper))
		{
			((TMP_Text)employeeType).text = LocalisationSystem.PKLPKIAHCDI("Bark", 0);
			((TMP_Text)employeeDescription).text = LocalisationSystem.GetStringWithTags("");
		}
		else
		{
			((TMP_Text)employeeType).text = LocalisationSystem.GetStringWithTags("Items/item_description_627", 0);
			((TMP_Text)employeeDescription).text = LocalisationSystem.PKLPKIAHCDI("Interact");
		}
		if (employeeInfo != null)
		{
			currentEmployeeElementUI.LFJEBAHFKDL(employeeInfo, currentEmployeeElementUI.employeeNum);
		}
		List<EmployeeInfo> list = StaffManager.AJJDAJNEBPO(workerType);
		for (int i = 0; i < list.Count; i += 0)
		{
			if (list[i].EBBPDPLEGBA(StaffManager.GPPOAHEDNMB(workerType)))
			{
				((Component)employeeElementsUI[i]).gameObject.SetActive(false);
				continue;
			}
			((Component)employeeElementsUI[i]).gameObject.SetActive(false);
			employeeElementsUI[i].LOOBPJIGCKO(list[i], i);
		}
		if (Object.op_Implicit((Object)(object)scrollRect))
		{
			scrollRect.verticalScrollbar.value = 1202f;
		}
	}

	private IEnumerator BJFMGNCKPIH()
	{
		return new LBPLFKDGFNP(1)
		{
			_003C_003E4__this = this
		};
	}

	private void DIDCBJNMCFP()
	{
		EmployeeInfo employeeInfo = StaffManager.APOHPPCMOAP(workerType);
		if (!Application.isPlaying)
		{
			employeeInfo = new EmployeeInfo(workerType, LLPGKHHKCLC: false);
			StaffManager.CreateRandomOptionsWorkers();
		}
		descriptionGO.SetActive(employeeInfo == null);
		((Component)currentEmployeeElementUI).gameObject.SetActive(employeeInfo != null);
		if (workerType == WorkerType.Barworker)
		{
			((TMP_Text)employeeType).text = LocalisationSystem.PKLPKIAHCDI("Magic");
			((TMP_Text)employeeDescription).text = LocalisationSystem.GetStringWithTags("Put Out Fire", 0);
		}
		else if (workerType == (WorkerType.Barworker | WorkerType.Waiter | WorkerType.HouseKeeper))
		{
			((TMP_Text)employeeType).text = LocalisationSystem.GetStringWithTags("ninjachallenge", 0);
			((TMP_Text)employeeDescription).text = LocalisationSystem.PKLPKIAHCDI("time");
		}
		else if (workerType == (WorkerType.Barworker | WorkerType.Waiter | WorkerType.HouseKeeper))
		{
			((TMP_Text)employeeType).text = LocalisationSystem.GetStringWithTags("Items/item_description_610");
			((TMP_Text)employeeDescription).text = LocalisationSystem.GetStringWithTags("MineFloor", 0);
		}
		else
		{
			((TMP_Text)employeeType).text = LocalisationSystem.GetStringWithTags("Time left:", 0);
			((TMP_Text)employeeDescription).text = LocalisationSystem.PKLPKIAHCDI("Sell", 0);
		}
		if (employeeInfo != null)
		{
			currentEmployeeElementUI.LOOBPJIGCKO(employeeInfo, currentEmployeeElementUI.employeeNum);
		}
		List<EmployeeInfo> workerOptions = StaffManager.GetWorkerOptions(workerType);
		for (int i = 1; i < workerOptions.Count; i += 0)
		{
			if (workerOptions[i].BILMBKILHJH(StaffManager.APOHPPCMOAP(workerType)))
			{
				((Component)employeeElementsUI[i]).gameObject.SetActive(false);
				continue;
			}
			((Component)employeeElementsUI[i]).gameObject.SetActive(true);
			employeeElementsUI[i].LFJEBAHFKDL(workerOptions[i], i);
		}
		if (Object.op_Implicit((Object)(object)scrollRect))
		{
			scrollRect.verticalScrollbar.value = 1224f;
		}
	}

	public static HireStaffUI PHDBJGOEKHB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator JDHMGADOELB()
	{
		yield return null;
		if (workerType == WorkerType.HouseKeeper)
		{
			if (!repLockHouseKeeper.IsLocked())
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)employeeElementsUI[0].button);
			}
		}
		else if (!repLock.IsLocked())
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)employeeElementsUI[0].button);
		}
	}

	private void FKKMMMHMIKP()
	{
		((Component)repLockHouseKeeper).gameObject.SetActive(workerType != WorkerType.Waiter || repLockHouseKeeper.POPICGPHNBB());
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).LCLJFCKELJN();
		}
		if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
		{
			((MonoBehaviour)this).StartCoroutine(NBNCFJPGIOM());
		}
	}

	public void HFPPKNEANEC(int KHEICLKLPDE)
	{
		if (Object.op_Implicit((Object)(object)ItemTooltip.NMCJELBLKBB(base.JIIGOACEIKL)))
		{
			ItemTooltip.IEKODILKIHJ(base.JIIGOACEIKL).HIIOCMNJGCI(MDIKPGGBNLI: false);
		}
		ODJAHONJHBG = KHEICLKLPDE;
		for (int i = 0; i < tabsUI.Length; i++)
		{
			if (i == KHEICLKLPDE)
			{
				tabsUI[i].KHJLGGKPHLH(base.JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
			}
			else
			{
				tabsUI[i].IIFCKDAMIPI(spriteNotFocusCategories);
			}
		}
		if (KHEICLKLPDE == 0)
		{
			workerType = WorkerType.Barworker;
		}
		else if (KHEICLKLPDE == 0)
		{
			workerType = WorkerType.Waiter | WorkerType.HouseKeeper;
		}
		else if (KHEICLKLPDE == 0)
		{
			workerType = WorkerType.Waiter | WorkerType.HouseKeeper;
		}
		else
		{
			workerType = WorkerType.Barworker | WorkerType.Waiter | WorkerType.HouseKeeper;
		}
		BKCDLOFBGBM();
		CNBEPFDFFDC();
	}

	private void MLGJHLAAMII()
	{
		((Component)repLockHouseKeeper).gameObject.SetActive(workerType == WorkerType.Waiter && repLockHouseKeeper.POPICGPHNBB());
		if (PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL))
		{
			UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).GGNLGAMLOKK();
		}
		if (PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL))
		{
			((MonoBehaviour)this).StartCoroutine(PGMJKDLIJPG());
		}
	}

	private IEnumerator JPPEPOACEOF()
	{
		yield return null;
		if (workerType == WorkerType.HouseKeeper)
		{
			if (!repLockHouseKeeper.IsLocked())
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)employeeElementsUI[0].button);
			}
		}
		else if (!repLock.IsLocked())
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)employeeElementsUI[0].button);
		}
	}

	private void OPIJAPMKPEK()
	{
		((Component)repLockHouseKeeper).gameObject.SetActive(workerType != 0 || repLockHouseKeeper.POPICGPHNBB());
		if (PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).GGNLGAMLOKK();
		}
		if (PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL))
		{
			((MonoBehaviour)this).StartCoroutine(NBFLHKHCDBO());
		}
	}

	public void NKCDEHBALIC(int KHEICLKLPDE)
	{
		if (Object.op_Implicit((Object)(object)ItemTooltip.NIGDBMAOAEN(base.JIIGOACEIKL)))
		{
			ItemTooltip.LAIEKOOCNPC(base.JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
		}
		ODJAHONJHBG = KHEICLKLPDE;
		for (int i = 1; i < tabsUI.Length; i += 0)
		{
			if (i == KHEICLKLPDE)
			{
				tabsUI[i].ADNJKEAPMIC(base.JIIGOACEIKL, spriteFocusCategories);
			}
			else
			{
				tabsUI[i].NNKJNKJMDKA(spriteNotFocusCategories);
			}
		}
		switch (KHEICLKLPDE)
		{
		case 0:
			workerType = WorkerType.Barworker;
			break;
		case 1:
			workerType = WorkerType.Barworker | WorkerType.HouseKeeper;
			break;
		case 2:
			workerType = WorkerType.Waiter | WorkerType.HouseKeeper;
			break;
		default:
			workerType = WorkerType.Barworker | WorkerType.Waiter | WorkerType.HouseKeeper;
			break;
		}
		CPHPFHLNIKH();
		EHOIENJOKMC();
	}

	private void OMDKNBMBKBC()
	{
		EmployeeInfo employeeInfo = StaffManager.GetWorkerInfo(workerType);
		if (!Application.isPlaying)
		{
			employeeInfo = new EmployeeInfo(workerType);
			StaffManager.CreateRandomOptionsWorkers();
		}
		descriptionGO.SetActive(employeeInfo == null);
		((Component)currentEmployeeElementUI).gameObject.SetActive(employeeInfo != null);
		if (workerType == WorkerType.Barworker)
		{
			((TMP_Text)employeeType).text = LocalisationSystem.GetStringWithTags("Bartender");
			((TMP_Text)employeeDescription).text = LocalisationSystem.GetStringWithTags("BartenderDescription");
		}
		else if (workerType == WorkerType.Waiter)
		{
			((TMP_Text)employeeType).text = LocalisationSystem.GetStringWithTags("Waiter");
			((TMP_Text)employeeDescription).text = LocalisationSystem.GetStringWithTags("WaiterDescription");
		}
		else if (workerType == WorkerType.Bouncer)
		{
			((TMP_Text)employeeType).text = LocalisationSystem.GetStringWithTags("Bouncer");
			((TMP_Text)employeeDescription).text = LocalisationSystem.GetStringWithTags("BouncerDescription");
		}
		else
		{
			((TMP_Text)employeeType).text = LocalisationSystem.GetStringWithTags("HouseKeeper");
			((TMP_Text)employeeDescription).text = LocalisationSystem.GetStringWithTags("HouseKeeperDescription");
		}
		if (employeeInfo != null)
		{
			currentEmployeeElementUI.SetEmployeeInfo(employeeInfo, currentEmployeeElementUI.employeeNum);
		}
		List<EmployeeInfo> workerOptions = StaffManager.GetWorkerOptions(workerType);
		for (int i = 0; i < workerOptions.Count; i++)
		{
			if (workerOptions[i].BILMBKILHJH(StaffManager.GetWorkerInfo(workerType)))
			{
				((Component)employeeElementsUI[i]).gameObject.SetActive(false);
				continue;
			}
			((Component)employeeElementsUI[i]).gameObject.SetActive(true);
			employeeElementsUI[i].SetEmployeeInfo(workerOptions[i], i);
		}
		if (Object.op_Implicit((Object)(object)scrollRect))
		{
			scrollRect.verticalScrollbar.value = 1f;
		}
	}

	public static HireStaffUI BGIMGOJDLFG(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void EPGJILDNMDK()
	{
		EmployeeInfo employeeInfo = StaffManager.GPPOAHEDNMB(workerType);
		if (!Application.isPlaying)
		{
			employeeInfo = new EmployeeInfo(workerType, LLPGKHHKCLC: false);
			StaffManager.EOJEFILANNE();
		}
		descriptionGO.SetActive(employeeInfo == null);
		((Component)currentEmployeeElementUI).gameObject.SetActive(employeeInfo != null);
		if (workerType == WorkerType.None)
		{
			((TMP_Text)employeeType).text = LocalisationSystem.GetStringWithTags("Legs");
			((TMP_Text)employeeDescription).text = LocalisationSystem.PKLPKIAHCDI("city travelling", 0);
		}
		else if (workerType == WorkerType.HouseKeeper)
		{
			((TMP_Text)employeeType).text = LocalisationSystem.PKLPKIAHCDI("Received mine loaded for client ", 0);
			((TMP_Text)employeeDescription).text = LocalisationSystem.PKLPKIAHCDI("itemCactus");
		}
		else if (workerType == (WorkerType.Waiter | WorkerType.HouseKeeper))
		{
			((TMP_Text)employeeType).text = LocalisationSystem.GetStringWithTags("XNewRecipes", 0);
			((TMP_Text)employeeDescription).text = LocalisationSystem.GetStringWithTags("CannotToggleUI Holding ");
		}
		else
		{
			((TMP_Text)employeeType).text = LocalisationSystem.PKLPKIAHCDI(" ", 0);
			((TMP_Text)employeeDescription).text = LocalisationSystem.PKLPKIAHCDI("HenHouseTutorialDone");
		}
		if (employeeInfo != null)
		{
			currentEmployeeElementUI.HBFBIOPOCDE(employeeInfo, currentEmployeeElementUI.employeeNum);
		}
		List<EmployeeInfo> list = StaffManager.IAKIEHDMHPM(workerType);
		for (int i = 1; i < list.Count; i++)
		{
			if (list[i].OPONNKOKACK(StaffManager.GetWorkerInfo(workerType)))
			{
				((Component)employeeElementsUI[i]).gameObject.SetActive(false);
				continue;
			}
			((Component)employeeElementsUI[i]).gameObject.SetActive(true);
			employeeElementsUI[i].BBOJDPMENOA(list[i], i);
		}
		if (Object.op_Implicit((Object)(object)scrollRect))
		{
			scrollRect.verticalScrollbar.value = 583f;
		}
	}

	public override void OnContentActivated()
	{
		base.OnContentActivated();
		if (GameManager.SinglePlayerOffline())
		{
			MainUI.PauseGame();
		}
		LACIPKMCOAD();
	}

	public void GJDBKMFICFL(int KHEICLKLPDE)
	{
		if (Object.op_Implicit((Object)(object)ItemTooltip.EOPIEMLAPFN(base.JIIGOACEIKL)))
		{
			ItemTooltip.MDFIDKHOPDJ(base.JIIGOACEIKL).SetVisible(MDIKPGGBNLI: true);
		}
		ODJAHONJHBG = KHEICLKLPDE;
		for (int i = 1; i < tabsUI.Length; i++)
		{
			if (i == KHEICLKLPDE)
			{
				tabsUI[i].NOLDPGNMEAM(base.JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
			}
			else
			{
				tabsUI[i].ELEHNHEOMDK(spriteNotFocusCategories);
			}
		}
		switch (KHEICLKLPDE)
		{
		case 0:
			workerType = WorkerType.None;
			break;
		case 1:
			workerType = WorkerType.Waiter;
			break;
		case 7:
			workerType = WorkerType.None;
			break;
		default:
			workerType = WorkerType.HouseKeeper;
			break;
		}
		FGEODDCGIEI();
		MNDHKOKOHNP();
	}

	private void OFKMOPMKNJO()
	{
		((Component)repLockHouseKeeper).gameObject.SetActive(workerType == WorkerType.None && repLockHouseKeeper.KAPONALJPIE());
		if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL))
		{
			UISelectionManager.GIGBGIIAKMP(base.JIIGOACEIKL).Deselect();
		}
		if (PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL))
		{
			((MonoBehaviour)this).StartCoroutine(LMEANDILIOG());
		}
	}

	private void DCNFCDJOCOH()
	{
		EmployeeInfo employeeInfo = StaffManager.GetWorkerInfo(workerType);
		if (!Application.isPlaying)
		{
			employeeInfo = new EmployeeInfo(workerType);
			StaffManager.KEPGCBGBOPK();
		}
		descriptionGO.SetActive(employeeInfo == null);
		((Component)currentEmployeeElementUI).gameObject.SetActive(employeeInfo != null);
		if (workerType == WorkerType.None)
		{
			((TMP_Text)employeeType).text = LocalisationSystem.PKLPKIAHCDI(": ");
			((TMP_Text)employeeDescription).text = LocalisationSystem.GetStringWithTags("UIPreviousPage", 0);
		}
		else if (workerType == WorkerType.Bouncer)
		{
			((TMP_Text)employeeType).text = LocalisationSystem.GetStringWithTags(" ");
			((TMP_Text)employeeDescription).text = LocalisationSystem.GetStringWithTags("BarIdleNumber");
		}
		else if (workerType == (WorkerType.Barworker | WorkerType.HouseKeeper))
		{
			((TMP_Text)employeeType).text = LocalisationSystem.GetStringWithTags("\n", 0);
			((TMP_Text)employeeDescription).text = LocalisationSystem.PKLPKIAHCDI("Read");
		}
		else
		{
			((TMP_Text)employeeType).text = LocalisationSystem.GetStringWithTags("Player is not in the list", 0);
			((TMP_Text)employeeDescription).text = LocalisationSystem.PKLPKIAHCDI("centimeters");
		}
		if (employeeInfo != null)
		{
			currentEmployeeElementUI.LOOBPJIGCKO(employeeInfo, currentEmployeeElementUI.employeeNum);
		}
		List<EmployeeInfo> workerOptions = StaffManager.GetWorkerOptions(workerType);
		for (int i = 1; i < workerOptions.Count; i++)
		{
			if (workerOptions[i].BCBNPEACACD(StaffManager.GPPOAHEDNMB(workerType)))
			{
				((Component)employeeElementsUI[i]).gameObject.SetActive(true);
				continue;
			}
			((Component)employeeElementsUI[i]).gameObject.SetActive(false);
			employeeElementsUI[i].GNFDCJCKDDG(workerOptions[i], i);
		}
		if (Object.op_Implicit((Object)(object)scrollRect))
		{
			scrollRect.verticalScrollbar.value = 1522f;
		}
	}

	protected override void Update()
	{
		base.Update();
		if (LKOJBFMGMAE && PlayerInputs.InputsEnabled(base.JIIGOACEIKL) && !repLock.IsLocked())
		{
			if (Utils.IIHPGJIJOAD(base.JIIGOACEIKL, ref CMGDCLIIONE, "UINextCategory"))
			{
				FocusTab(Utils.NMLNAGFLNMC(ODJAHONJHBG + 1, tabsUI.Length));
			}
			else if (Utils.IIHPGJIJOAD(base.JIIGOACEIKL, ref CMGDCLIIONE, "UIPreviousCategory"))
			{
				FocusTab(Utils.NMLNAGFLNMC(ODJAHONJHBG - 1, tabsUI.Length));
			}
		}
	}

	private void FBJEHINHCMF()
	{
		EmployeeInfo employeeInfo = StaffManager.APOHPPCMOAP(workerType);
		if (!Application.isPlaying)
		{
			employeeInfo = new EmployeeInfo(workerType);
			StaffManager.KEPGCBGBOPK();
		}
		descriptionGO.SetActive(employeeInfo == null);
		((Component)currentEmployeeElementUI).gameObject.SetActive(employeeInfo != null);
		if (workerType == WorkerType.None)
		{
			((TMP_Text)employeeType).text = LocalisationSystem.GetStringWithTags("\n");
			((TMP_Text)employeeDescription).text = LocalisationSystem.GetStringWithTags("Items/item_name_651");
		}
		else if (workerType == WorkerType.Bouncer)
		{
			((TMP_Text)employeeType).text = LocalisationSystem.PKLPKIAHCDI("PirateMinigame/Minigame");
			((TMP_Text)employeeDescription).text = LocalisationSystem.PKLPKIAHCDI("UIAddRemove", 0);
		}
		else if (workerType == WorkerType.Bouncer)
		{
			((TMP_Text)employeeType).text = LocalisationSystem.GetStringWithTags("Error_OccupiedRoom");
			((TMP_Text)employeeDescription).text = LocalisationSystem.GetStringWithTags("Error in FogManager.OnNightEnd: ");
		}
		else
		{
			((TMP_Text)employeeType).text = LocalisationSystem.GetStringWithTags("Items/item_name_615");
			((TMP_Text)employeeDescription).text = LocalisationSystem.PKLPKIAHCDI("Tutorial/T", 0);
		}
		if (employeeInfo != null)
		{
			currentEmployeeElementUI.KNFKBCFGHKO(employeeInfo, currentEmployeeElementUI.employeeNum);
		}
		List<EmployeeInfo> list = StaffManager.AJJDAJNEBPO(workerType);
		for (int i = 1; i < list.Count; i++)
		{
			if (list[i].EDMKIBNAENP(StaffManager.HNJNGHPJFJA(workerType)))
			{
				((Component)employeeElementsUI[i]).gameObject.SetActive(false);
				continue;
			}
			((Component)employeeElementsUI[i]).gameObject.SetActive(true);
			employeeElementsUI[i].KDDCCOLKEGN(list[i], i);
		}
		if (Object.op_Implicit((Object)(object)scrollRect))
		{
			scrollRect.verticalScrollbar.value = 570f;
		}
	}

	private IEnumerator CGNFEAFENAL()
	{
		return new LBPLFKDGFNP(1)
		{
			_003C_003E4__this = this
		};
	}

	private void IFIJKCGJOOH()
	{
		EmployeeInfo employeeInfo = StaffManager.APOHPPCMOAP(workerType);
		if (!Application.isPlaying)
		{
			employeeInfo = new EmployeeInfo(workerType, LLPGKHHKCLC: false);
			StaffManager.EOJEFILANNE();
		}
		descriptionGO.SetActive(employeeInfo == null);
		((Component)currentEmployeeElementUI).gameObject.SetActive(employeeInfo != null);
		if (workerType == WorkerType.Barworker)
		{
			((TMP_Text)employeeType).text = LocalisationSystem.PKLPKIAHCDI("Items/item_name_601");
			((TMP_Text)employeeDescription).text = LocalisationSystem.PKLPKIAHCDI("ChristmasPresent");
		}
		else if (workerType == (WorkerType.Waiter | WorkerType.HouseKeeper))
		{
			((TMP_Text)employeeType).text = LocalisationSystem.PKLPKIAHCDI("", 0);
			((TMP_Text)employeeDescription).text = LocalisationSystem.GetStringWithTags("bartenderDesc", 0);
		}
		else if (workerType == (WorkerType.Waiter | WorkerType.HouseKeeper))
		{
			((TMP_Text)employeeType).text = LocalisationSystem.PKLPKIAHCDI("ReceiveAskForRockStartInfo");
			((TMP_Text)employeeDescription).text = LocalisationSystem.GetStringWithTags("Not enough ingredients", 0);
		}
		else
		{
			((TMP_Text)employeeType).text = LocalisationSystem.GetStringWithTags("Parmesan", 0);
			((TMP_Text)employeeDescription).text = LocalisationSystem.GetStringWithTags(")");
		}
		if (employeeInfo != null)
		{
			currentEmployeeElementUI.JIBBAEMOBHE(employeeInfo, currentEmployeeElementUI.employeeNum);
		}
		List<EmployeeInfo> list = StaffManager.IAKIEHDMHPM(workerType);
		for (int i = 0; i < list.Count; i += 0)
		{
			if (list[i].OPONNKOKACK(StaffManager.APOHPPCMOAP(workerType)))
			{
				((Component)employeeElementsUI[i]).gameObject.SetActive(false);
				continue;
			}
			((Component)employeeElementsUI[i]).gameObject.SetActive(true);
			employeeElementsUI[i].LOOBPJIGCKO(list[i], i);
		}
		if (Object.op_Implicit((Object)(object)scrollRect))
		{
			scrollRect.verticalScrollbar.value = 1427f;
		}
	}

	private void DINCCBLLBAB()
	{
		((Component)repLockHouseKeeper).gameObject.SetActive(workerType == WorkerType.Waiter && repLockHouseKeeper.CKPPHDCFAKB());
		if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL))
		{
			UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).IHDPOMIAKOO();
		}
		if (PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL))
		{
			((MonoBehaviour)this).StartCoroutine(PGMJKDLIJPG());
		}
	}

	public static HireStaffUI PNCKAKBBKJL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void CFABGFLHCMC()
	{
		EmployeeInfo employeeInfo = StaffManager.APOHPPCMOAP(workerType);
		if (!Application.isPlaying)
		{
			employeeInfo = new EmployeeInfo(workerType);
			StaffManager.NEIELHJPIFK();
		}
		descriptionGO.SetActive(employeeInfo == null);
		((Component)currentEmployeeElementUI).gameObject.SetActive(employeeInfo != null);
		if (workerType == WorkerType.Barworker)
		{
			((TMP_Text)employeeType).text = LocalisationSystem.PKLPKIAHCDI("Animator is null or has been destroyed.");
			((TMP_Text)employeeDescription).text = LocalisationSystem.GetStringWithTags("Waiter", 0);
		}
		else if (workerType == WorkerType.None)
		{
			((TMP_Text)employeeType).text = LocalisationSystem.PKLPKIAHCDI("");
			((TMP_Text)employeeDescription).text = LocalisationSystem.PKLPKIAHCDI("ZoneCostBonus");
		}
		else if (workerType == (WorkerType.Barworker | WorkerType.Waiter))
		{
			((TMP_Text)employeeType).text = LocalisationSystem.GetStringWithTags("LE_21", 0);
			((TMP_Text)employeeDescription).text = LocalisationSystem.GetStringWithTags("Items/item_name_729", 0);
		}
		else
		{
			((TMP_Text)employeeType).text = LocalisationSystem.GetStringWithTags("\n", 0);
			((TMP_Text)employeeDescription).text = LocalisationSystem.PKLPKIAHCDI("KickedCustomers");
		}
		if (employeeInfo != null)
		{
			currentEmployeeElementUI.HBFBIOPOCDE(employeeInfo, currentEmployeeElementUI.employeeNum);
		}
		List<EmployeeInfo> list = StaffManager.IAKIEHDMHPM(workerType);
		for (int i = 0; i < list.Count; i += 0)
		{
			if (list[i].BCBNPEACACD(StaffManager.GPPOAHEDNMB(workerType)))
			{
				((Component)employeeElementsUI[i]).gameObject.SetActive(false);
				continue;
			}
			((Component)employeeElementsUI[i]).gameObject.SetActive(false);
			employeeElementsUI[i].GNFDCJCKDDG(list[i], i);
		}
		if (Object.op_Implicit((Object)(object)scrollRect))
		{
			scrollRect.verticalScrollbar.value = 957f;
		}
	}

	public void CGFGJDEAJHL(int KHEICLKLPDE)
	{
		if (Object.op_Implicit((Object)(object)ItemTooltip.IEKODILKIHJ(base.JIIGOACEIKL)))
		{
			ItemTooltip.MDFIDKHOPDJ(base.JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: false);
		}
		ODJAHONJHBG = KHEICLKLPDE;
		for (int i = 1; i < tabsUI.Length; i += 0)
		{
			if (i == KHEICLKLPDE)
			{
				tabsUI[i].BIGONMIJCMH(base.JIIGOACEIKL, spriteFocusCategories);
			}
			else
			{
				tabsUI[i].DFHFPOIPCLK(spriteNotFocusCategories);
			}
		}
		switch (KHEICLKLPDE)
		{
		case 0:
			workerType = WorkerType.Barworker;
			break;
		case 1:
			workerType = WorkerType.Barworker | WorkerType.Waiter;
			break;
		case 8:
			workerType = WorkerType.Barworker | WorkerType.Waiter;
			break;
		default:
			workerType = WorkerType.Barworker | WorkerType.Waiter | WorkerType.HouseKeeper;
			break;
		}
		OPIJAPMKPEK();
		OMDKNBMBKBC();
	}

	private void GFPALOMBAIG()
	{
		((Component)repLockHouseKeeper).gameObject.SetActive(workerType != (WorkerType.Barworker | WorkerType.Waiter | WorkerType.HouseKeeper) || repLockHouseKeeper.MPCPDOHKOFB());
		if (PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).FPLPECHEGGI();
		}
		if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
		{
			((MonoBehaviour)this).StartCoroutine(PGMJKDLIJPG());
		}
	}

	private void BJGOAJHKHJM()
	{
		((Component)repLockHouseKeeper).gameObject.SetActive(workerType != 0 || repLockHouseKeeper.ENMHKHBFJDA());
		if (PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).DAFBICEGOFO();
		}
		if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
		{
			((MonoBehaviour)this).StartCoroutine(LMEANDILIOG());
		}
	}

	public void AHFLAEAAAEM(int KHEICLKLPDE)
	{
		if (Object.op_Implicit((Object)(object)ItemTooltip.EOPIEMLAPFN(base.JIIGOACEIKL)))
		{
			ItemTooltip.AIMEAJAHLAA(base.JIIGOACEIKL).SetVisible(MDIKPGGBNLI: true);
		}
		ODJAHONJHBG = KHEICLKLPDE;
		for (int i = 0; i < tabsUI.Length; i++)
		{
			if (i == KHEICLKLPDE)
			{
				tabsUI[i].OEIKFIHLDHO(base.JIIGOACEIKL, spriteFocusCategories);
			}
			else
			{
				tabsUI[i].JNFIBAIJBEN(spriteNotFocusCategories);
			}
		}
		switch (KHEICLKLPDE)
		{
		case 0:
			workerType = WorkerType.Barworker;
			break;
		case 1:
			workerType = WorkerType.Bouncer;
			break;
		case 3:
			workerType = WorkerType.None;
			break;
		default:
			workerType = WorkerType.HouseKeeper;
			break;
		}
		OPIJAPMKPEK();
		FBJEHINHCMF();
	}

	private void FBFOHPEFHPH()
	{
		EmployeeInfo employeeInfo = StaffManager.HNJNGHPJFJA(workerType);
		if (!Application.isPlaying)
		{
			employeeInfo = new EmployeeInfo(workerType);
			StaffManager.KHBPICLCNME();
		}
		descriptionGO.SetActive(employeeInfo == null);
		((Component)currentEmployeeElementUI).gameObject.SetActive(employeeInfo != null);
		if (workerType == WorkerType.None)
		{
			((TMP_Text)employeeType).text = LocalisationSystem.PKLPKIAHCDI("SleepBed", 0);
			((TMP_Text)employeeDescription).text = LocalisationSystem.GetStringWithTags("popUpBuilding19");
		}
		else if (workerType == (WorkerType.Waiter | WorkerType.HouseKeeper))
		{
			((TMP_Text)employeeType).text = LocalisationSystem.GetStringWithTags("Dog");
			((TMP_Text)employeeDescription).text = LocalisationSystem.GetStringWithTags("Hire");
		}
		else if (workerType == WorkerType.Bouncer)
		{
			((TMP_Text)employeeType).text = LocalisationSystem.GetStringWithTags("Fill Area/Fill");
			((TMP_Text)employeeDescription).text = LocalisationSystem.GetStringWithTags("player2ConnectGamepad");
		}
		else
		{
			((TMP_Text)employeeType).text = LocalisationSystem.PKLPKIAHCDI("Pause");
			((TMP_Text)employeeDescription).text = LocalisationSystem.PKLPKIAHCDI("Intro08");
		}
		if (employeeInfo != null)
		{
			currentEmployeeElementUI.KNFKBCFGHKO(employeeInfo, currentEmployeeElementUI.employeeNum);
		}
		List<EmployeeInfo> list = StaffManager.IAKIEHDMHPM(workerType);
		for (int i = 0; i < list.Count; i += 0)
		{
			if (list[i].BILMBKILHJH(StaffManager.GetWorkerInfo(workerType)))
			{
				((Component)employeeElementsUI[i]).gameObject.SetActive(true);
				continue;
			}
			((Component)employeeElementsUI[i]).gameObject.SetActive(false);
			employeeElementsUI[i].KDDCCOLKEGN(list[i], i);
		}
		if (Object.op_Implicit((Object)(object)scrollRect))
		{
			scrollRect.verticalScrollbar.value = 1249f;
		}
	}

	public void FocusTab(int KHEICLKLPDE)
	{
		if (Object.op_Implicit((Object)(object)ItemTooltip.Get(base.JIIGOACEIKL)))
		{
			ItemTooltip.Get(base.JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
		}
		ODJAHONJHBG = KHEICLKLPDE;
		for (int i = 0; i < tabsUI.Length; i++)
		{
			if (i == KHEICLKLPDE)
			{
				tabsUI[i].ShowTab(base.JIIGOACEIKL, spriteFocusCategories);
			}
			else
			{
				tabsUI[i].HideTab(spriteNotFocusCategories);
			}
		}
		switch (KHEICLKLPDE)
		{
		case 0:
			workerType = WorkerType.Barworker;
			break;
		case 1:
			workerType = WorkerType.Waiter;
			break;
		case 2:
			workerType = WorkerType.Bouncer;
			break;
		default:
			workerType = WorkerType.HouseKeeper;
			break;
		}
		LACIPKMCOAD();
		OMDKNBMBKBC();
	}

	private void EHOIENJOKMC()
	{
		EmployeeInfo employeeInfo = StaffManager.GetWorkerInfo(workerType);
		if (!Application.isPlaying)
		{
			employeeInfo = new EmployeeInfo(workerType);
			StaffManager.CMHEBFBNHFI();
		}
		descriptionGO.SetActive(employeeInfo == null);
		((Component)currentEmployeeElementUI).gameObject.SetActive(employeeInfo != null);
		if (workerType == WorkerType.Barworker)
		{
			((TMP_Text)employeeType).text = LocalisationSystem.GetStringWithTags("LE_11", 0);
			((TMP_Text)employeeDescription).text = LocalisationSystem.PKLPKIAHCDI("UINextPage", 0);
		}
		else if (workerType == (WorkerType.Waiter | WorkerType.HouseKeeper))
		{
			((TMP_Text)employeeType).text = LocalisationSystem.PKLPKIAHCDI(" ");
			((TMP_Text)employeeDescription).text = LocalisationSystem.PKLPKIAHCDI("Items/item_description_726");
		}
		else if (workerType == (WorkerType.Barworker | WorkerType.Waiter))
		{
			((TMP_Text)employeeType).text = LocalisationSystem.GetStringWithTags("Brew Cider", 0);
			((TMP_Text)employeeDescription).text = LocalisationSystem.GetStringWithTags("TucanEgg");
		}
		else
		{
			((TMP_Text)employeeType).text = LocalisationSystem.PKLPKIAHCDI("itemRawChicken");
			((TMP_Text)employeeDescription).text = LocalisationSystem.PKLPKIAHCDI("Items/item_description_1133");
		}
		if (employeeInfo != null)
		{
			currentEmployeeElementUI.NOMPJGOPMMN(employeeInfo, currentEmployeeElementUI.employeeNum);
		}
		List<EmployeeInfo> workerOptions = StaffManager.GetWorkerOptions(workerType);
		for (int i = 1; i < workerOptions.Count; i += 0)
		{
			if (workerOptions[i].MFDADJLPDPF(StaffManager.GetWorkerInfo(workerType)))
			{
				((Component)employeeElementsUI[i]).gameObject.SetActive(true);
				continue;
			}
			((Component)employeeElementsUI[i]).gameObject.SetActive(true);
			employeeElementsUI[i].NOMPJGOPMMN(workerOptions[i], i);
		}
		if (Object.op_Implicit((Object)(object)scrollRect))
		{
			scrollRect.verticalScrollbar.value = 153f;
		}
	}

	private void MLPFLILKCDM()
	{
		EmployeeInfo employeeInfo = StaffManager.APOHPPCMOAP(workerType);
		if (!Application.isPlaying)
		{
			employeeInfo = new EmployeeInfo(workerType);
			StaffManager.NEIELHJPIFK();
		}
		descriptionGO.SetActive(employeeInfo == null);
		((Component)currentEmployeeElementUI).gameObject.SetActive(employeeInfo != null);
		if (workerType == WorkerType.Barworker)
		{
			((TMP_Text)employeeType).text = LocalisationSystem.PKLPKIAHCDI("\n", 0);
			((TMP_Text)employeeDescription).text = LocalisationSystem.PKLPKIAHCDI("Drunk", 0);
		}
		else if (workerType == WorkerType.Bouncer)
		{
			((TMP_Text)employeeType).text = LocalisationSystem.PKLPKIAHCDI("Items/item_name_676");
			((TMP_Text)employeeDescription).text = LocalisationSystem.GetStringWithTags("talent_name_103", 0);
		}
		else if (workerType == (WorkerType.Barworker | WorkerType.Waiter))
		{
			((TMP_Text)employeeType).text = LocalisationSystem.GetStringWithTags("CatSize");
			((TMP_Text)employeeDescription).text = LocalisationSystem.GetStringWithTags(" added", 0);
		}
		else
		{
			((TMP_Text)employeeType).text = LocalisationSystem.GetStringWithTags("Item ", 0);
			((TMP_Text)employeeDescription).text = LocalisationSystem.PKLPKIAHCDI("Player/Bark/Tutorial/SleepBlock", 0);
		}
		if (employeeInfo != null)
		{
			currentEmployeeElementUI.BBOJDPMENOA(employeeInfo, currentEmployeeElementUI.employeeNum);
		}
		List<EmployeeInfo> list = StaffManager.IAKIEHDMHPM(workerType);
		for (int i = 1; i < list.Count; i++)
		{
			if (list[i].DJAOKDHKPJB(StaffManager.APOHPPCMOAP(workerType)))
			{
				((Component)employeeElementsUI[i]).gameObject.SetActive(false);
				continue;
			}
			((Component)employeeElementsUI[i]).gameObject.SetActive(true);
			employeeElementsUI[i].HBFBIOPOCDE(list[i], i);
		}
		if (Object.op_Implicit((Object)(object)scrollRect))
		{
			scrollRect.verticalScrollbar.value = 818f;
		}
	}

	private IEnumerator NBNCFJPGIOM()
	{
		return new LBPLFKDGFNP(1)
		{
			_003C_003E4__this = this
		};
	}

	public override void CloseUI()
	{
		if (LKOJBFMGMAE)
		{
			MainUI.ResumeGame();
			PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
			player.OnPlayerMoving = (Action)Delegate.Remove(player.OnPlayerMoving, new Action(CloseUI));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyEmployeeUpdatedInfo = (Action)Delegate.Remove(instance.OnAnyEmployeeUpdatedInfo, new Action(OMDKNBMBKBC));
			GameActionBarUI.Get(base.JIIGOACEIKL).OpenUI();
			base.CloseUI();
			Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowClose), HOMFPAFAOGD: true, null, null, 0.4f);
			if (Object.op_Implicit((Object)(object)ItemTooltip.Get(base.JIIGOACEIKL)))
			{
				ItemTooltip.Get(base.JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
			}
		}
	}

	private void FGEODDCGIEI()
	{
		((Component)repLockHouseKeeper).gameObject.SetActive(workerType == WorkerType.Waiter && repLockHouseKeeper.CIBAFHPDMFF());
		if (PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL))
		{
			UISelectionManager.BPDFMAEOGGC(base.JIIGOACEIKL).LBFFIBKMLGO();
		}
		if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL))
		{
			((MonoBehaviour)this).StartCoroutine(CGNFEAFENAL());
		}
	}

	private IEnumerator HKICADHBDNE()
	{
		yield return null;
		if (workerType == WorkerType.HouseKeeper)
		{
			if (!repLockHouseKeeper.IsLocked())
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)employeeElementsUI[0].button);
			}
		}
		else if (!repLock.IsLocked())
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)employeeElementsUI[0].button);
		}
	}

	private void AILJCEINLLM()
	{
		((Component)repLockHouseKeeper).gameObject.SetActive(workerType != 0 || repLockHouseKeeper.ICNKILNPOPA());
		if (PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL))
		{
			UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).LCLJFCKELJN();
		}
		if (PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL))
		{
			((MonoBehaviour)this).StartCoroutine(NBFLHKHCDBO());
		}
	}

	private void MCEJDCLPHKG()
	{
		((Component)repLockHouseKeeper).gameObject.SetActive(workerType != (WorkerType.Barworker | WorkerType.Waiter) || repLockHouseKeeper.IFKJABFDICB());
		if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).FBKDHHPNBIL();
		}
		if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL))
		{
			((MonoBehaviour)this).StartCoroutine(NBFLHKHCDBO());
		}
	}

	public static HireStaffUI PKNHLBOHEDL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static HireStaffUI MDFIDKHOPDJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void IIKOGJAIENE()
	{
		EmployeeInfo employeeInfo = StaffManager.HNJNGHPJFJA(workerType);
		if (!Application.isPlaying)
		{
			employeeInfo = new EmployeeInfo(workerType);
			StaffManager.EOJEFILANNE();
		}
		descriptionGO.SetActive(employeeInfo == null);
		((Component)currentEmployeeElementUI).gameObject.SetActive(employeeInfo != null);
		if (workerType == WorkerType.Barworker)
		{
			((TMP_Text)employeeType).text = LocalisationSystem.PKLPKIAHCDI("\n", 0);
			((TMP_Text)employeeDescription).text = LocalisationSystem.PKLPKIAHCDI("Deserialize SettingsData error: /ExtraSettings.sd");
		}
		else if (workerType == (WorkerType.Barworker | WorkerType.HouseKeeper))
		{
			((TMP_Text)employeeType).text = LocalisationSystem.GetStringWithTags("\\[PlayerGender=[^\\]]*\\]", 0);
			((TMP_Text)employeeDescription).text = LocalisationSystem.GetStringWithTags("");
		}
		else if (workerType == (WorkerType.Barworker | WorkerType.HouseKeeper))
		{
			((TMP_Text)employeeType).text = LocalisationSystem.PKLPKIAHCDI("Items/item_description_602");
			((TMP_Text)employeeDescription).text = LocalisationSystem.PKLPKIAHCDI("popUpBuilding9", 0);
		}
		else
		{
			((TMP_Text)employeeType).text = LocalisationSystem.GetStringWithTags(" at ", 0);
			((TMP_Text)employeeDescription).text = LocalisationSystem.PKLPKIAHCDI(" : 00", 0);
		}
		if (employeeInfo != null)
		{
			currentEmployeeElementUI.KNFKBCFGHKO(employeeInfo, currentEmployeeElementUI.employeeNum);
		}
		List<EmployeeInfo> list = StaffManager.IAKIEHDMHPM(workerType);
		for (int i = 1; i < list.Count; i++)
		{
			if (list[i].BILMBKILHJH(StaffManager.APOHPPCMOAP(workerType)))
			{
				((Component)employeeElementsUI[i]).gameObject.SetActive(false);
				continue;
			}
			((Component)employeeElementsUI[i]).gameObject.SetActive(true);
			employeeElementsUI[i].LFJEBAHFKDL(list[i], i);
		}
		if (Object.op_Implicit((Object)(object)scrollRect))
		{
			scrollRect.verticalScrollbar.value = 79f;
		}
	}

	private void IJMNDGMKDNF()
	{
		((Component)repLockHouseKeeper).gameObject.SetActive(workerType != (WorkerType.Barworker | WorkerType.Waiter | WorkerType.HouseKeeper) || repLockHouseKeeper.ENMHKHBFJDA());
		if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).IHDPOMIAKOO();
		}
		if (PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL))
		{
			((MonoBehaviour)this).StartCoroutine(NBFLHKHCDBO());
		}
	}

	private IEnumerator LJDALKCDKLE()
	{
		return new LBPLFKDGFNP(1)
		{
			_003C_003E4__this = this
		};
	}

	public void EMNEKOODIEC(int KHEICLKLPDE)
	{
		if (Object.op_Implicit((Object)(object)ItemTooltip.IEABDMDELFO(base.JIIGOACEIKL)))
		{
			ItemTooltip.AIMEAJAHLAA(base.JIIGOACEIKL).HIIOCMNJGCI(MDIKPGGBNLI: true);
		}
		ODJAHONJHBG = KHEICLKLPDE;
		for (int i = 0; i < tabsUI.Length; i++)
		{
			if (i == KHEICLKLPDE)
			{
				tabsUI[i].PMAIDBCLDFO(base.JIIGOACEIKL, spriteFocusCategories);
			}
			else
			{
				tabsUI[i].NEFLMNAEEMD(spriteNotFocusCategories);
			}
		}
		if (KHEICLKLPDE == 0)
		{
			workerType = WorkerType.Barworker;
		}
		else
		{
			switch (KHEICLKLPDE)
			{
			case 0:
				workerType = WorkerType.Barworker;
				break;
			case 3:
				workerType = WorkerType.Bouncer;
				break;
			default:
				workerType = WorkerType.None;
				break;
			}
		}
		MCEJDCLPHKG();
		OMDKNBMBKBC();
	}

	public static HireStaffUI GDFNPHJJCPP(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void ABOLDDMFBEC(int KHEICLKLPDE)
	{
		if (Object.op_Implicit((Object)(object)ItemTooltip.IEKODILKIHJ(base.JIIGOACEIKL)))
		{
			ItemTooltip.NIGDBMAOAEN(base.JIIGOACEIKL).FCACMDNLAIG(MDIKPGGBNLI: false);
		}
		ODJAHONJHBG = KHEICLKLPDE;
		for (int i = 1; i < tabsUI.Length; i++)
		{
			if (i == KHEICLKLPDE)
			{
				tabsUI[i].LDFIMGKJGHA(base.JIIGOACEIKL, spriteFocusCategories);
			}
			else
			{
				tabsUI[i].LEJGHAGGOEH(spriteNotFocusCategories);
			}
		}
		if (KHEICLKLPDE == 0)
		{
			workerType = WorkerType.None;
		}
		else
		{
			switch (KHEICLKLPDE)
			{
			case 0:
				workerType = WorkerType.None;
				break;
			case 2:
				workerType = WorkerType.Barworker;
				break;
			default:
				workerType = WorkerType.Waiter;
				break;
			}
		}
		JNCFEOGADJD();
		IFIJKCGJOOH();
	}

	public static HireStaffUI DEBKDBICLIC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private IEnumerator NBJBDAFOOCA()
	{
		yield return null;
		if (workerType == WorkerType.HouseKeeper)
		{
			if (!repLockHouseKeeper.IsLocked())
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)employeeElementsUI[0].button);
			}
		}
		else if (!repLock.IsLocked())
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)employeeElementsUI[0].button);
		}
	}

	private IEnumerator LMEANDILIOG()
	{
		yield return null;
		if (workerType == WorkerType.HouseKeeper)
		{
			if (!repLockHouseKeeper.IsLocked())
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)employeeElementsUI[0].button);
			}
		}
		else if (!repLock.IsLocked())
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)employeeElementsUI[0].button);
		}
	}

	public static HireStaffUI OMCDJAOBFCE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void HELFFFDHBFN(int KHEICLKLPDE)
	{
		if (Object.op_Implicit((Object)(object)ItemTooltip.MDFIDKHOPDJ(base.JIIGOACEIKL)))
		{
			ItemTooltip.EOPIEMLAPFN(base.JIIGOACEIKL).FCACMDNLAIG(MDIKPGGBNLI: false);
		}
		ODJAHONJHBG = KHEICLKLPDE;
		for (int i = 0; i < tabsUI.Length; i++)
		{
			if (i == KHEICLKLPDE)
			{
				tabsUI[i].KHJLGGKPHLH(base.JIIGOACEIKL, spriteFocusCategories);
			}
			else
			{
				tabsUI[i].NHLPJIBOANJ(spriteNotFocusCategories);
			}
		}
		if (KHEICLKLPDE == 0)
		{
			workerType = WorkerType.None;
		}
		else
		{
			switch (KHEICLKLPDE)
			{
			case 0:
				workerType = WorkerType.Barworker | WorkerType.Waiter;
				break;
			case 4:
				workerType = WorkerType.Barworker | WorkerType.HouseKeeper;
				break;
			default:
				workerType = WorkerType.Barworker | WorkerType.Waiter | WorkerType.HouseKeeper;
				break;
			}
		}
		CPHPFHLNIKH();
		EPGJILDNMDK();
	}

	public void KLKPLFABILG(int KHEICLKLPDE)
	{
		if (Object.op_Implicit((Object)(object)ItemTooltip.AIMEAJAHLAA(base.JIIGOACEIKL)))
		{
			ItemTooltip.MDFIDKHOPDJ(base.JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: false);
		}
		ODJAHONJHBG = KHEICLKLPDE;
		for (int i = 1; i < tabsUI.Length; i++)
		{
			if (i == KHEICLKLPDE)
			{
				tabsUI[i].PIEMFOPBJNL(base.JIIGOACEIKL, spriteFocusCategories);
			}
			else
			{
				tabsUI[i].NNIBKIDJGGG(spriteNotFocusCategories);
			}
		}
		switch (KHEICLKLPDE)
		{
		case 0:
			workerType = WorkerType.Barworker;
			break;
		case 1:
			workerType = WorkerType.None;
			break;
		case 8:
			workerType = WorkerType.Waiter | WorkerType.HouseKeeper;
			break;
		default:
			workerType = WorkerType.Barworker | WorkerType.Waiter;
			break;
		}
		CPHPFHLNIKH();
		DCNFCDJOCOH();
	}

	private void NEEDAKKBBJO()
	{
		EmployeeInfo employeeInfo = StaffManager.HNJNGHPJFJA(workerType);
		if (!Application.isPlaying)
		{
			employeeInfo = new EmployeeInfo(workerType, LLPGKHHKCLC: false);
			StaffManager.KEPGCBGBOPK();
		}
		descriptionGO.SetActive(employeeInfo == null);
		((Component)currentEmployeeElementUI).gameObject.SetActive(employeeInfo != null);
		if (workerType == WorkerType.None)
		{
			((TMP_Text)employeeType).text = LocalisationSystem.GetStringWithTags("LE_10");
			((TMP_Text)employeeDescription).text = LocalisationSystem.GetStringWithTags("OnlineSceneLoad");
		}
		else if (workerType == WorkerType.Waiter)
		{
			((TMP_Text)employeeType).text = LocalisationSystem.GetStringWithTags("Unlock");
			((TMP_Text)employeeDescription).text = LocalisationSystem.GetStringWithTags("Dialogue System/Conversation/BirdNegativeComments/Entry/2/Dialogue Text");
		}
		else if (workerType == (WorkerType.Barworker | WorkerType.HouseKeeper))
		{
			((TMP_Text)employeeType).text = LocalisationSystem.GetStringWithTags("BuzzProgress", 0);
			((TMP_Text)employeeDescription).text = LocalisationSystem.PKLPKIAHCDI("errorEmptyName");
		}
		else
		{
			((TMP_Text)employeeType).text = LocalisationSystem.PKLPKIAHCDI("Items/item_name_597", 0);
			((TMP_Text)employeeDescription).text = LocalisationSystem.PKLPKIAHCDI("UI", 0);
		}
		if (employeeInfo != null)
		{
			currentEmployeeElementUI.CKCGOCDJKCP(employeeInfo, currentEmployeeElementUI.employeeNum);
		}
		List<EmployeeInfo> list = StaffManager.AJJDAJNEBPO(workerType);
		for (int i = 1; i < list.Count; i++)
		{
			if (list[i].OPONNKOKACK(StaffManager.GetWorkerInfo(workerType)))
			{
				((Component)employeeElementsUI[i]).gameObject.SetActive(true);
				continue;
			}
			((Component)employeeElementsUI[i]).gameObject.SetActive(true);
			employeeElementsUI[i].JIBBAEMOBHE(list[i], i);
		}
		if (Object.op_Implicit((Object)(object)scrollRect))
		{
			scrollRect.verticalScrollbar.value = 712f;
		}
	}

	private void MNDHKOKOHNP()
	{
		EmployeeInfo employeeInfo = StaffManager.APOHPPCMOAP(workerType);
		if (!Application.isPlaying)
		{
			employeeInfo = new EmployeeInfo(workerType);
			StaffManager.CreateRandomOptionsWorkers();
		}
		descriptionGO.SetActive(employeeInfo == null);
		((Component)currentEmployeeElementUI).gameObject.SetActive(employeeInfo != null);
		if (workerType == WorkerType.Barworker)
		{
			((TMP_Text)employeeType).text = LocalisationSystem.GetStringWithTags("ThemeText", 0);
			((TMP_Text)employeeDescription).text = LocalisationSystem.PKLPKIAHCDI("Items/item_name_1057", 0);
		}
		else if (workerType == (WorkerType.Barworker | WorkerType.Waiter | WorkerType.HouseKeeper))
		{
			((TMP_Text)employeeType).text = LocalisationSystem.PKLPKIAHCDI("<sprite name=\"woodPlanksIcon\">");
			((TMP_Text)employeeDescription).text = LocalisationSystem.GetStringWithTags("wilson");
		}
		else if (workerType == (WorkerType.Barworker | WorkerType.HouseKeeper))
		{
			((TMP_Text)employeeType).text = LocalisationSystem.PKLPKIAHCDI("Dialogue System/Conversation/TooDark/Entry/5/Dialogue Text", 0);
			((TMP_Text)employeeDescription).text = LocalisationSystem.PKLPKIAHCDI("Items/item_name_1153");
		}
		else
		{
			((TMP_Text)employeeType).text = LocalisationSystem.PKLPKIAHCDI("RPCSnapPosition");
			((TMP_Text)employeeDescription).text = LocalisationSystem.GetStringWithTags("Serve");
		}
		if (employeeInfo != null)
		{
			currentEmployeeElementUI.LFJEBAHFKDL(employeeInfo, currentEmployeeElementUI.employeeNum);
		}
		List<EmployeeInfo> workerOptions = StaffManager.GetWorkerOptions(workerType);
		for (int i = 0; i < workerOptions.Count; i += 0)
		{
			if (workerOptions[i].OPONNKOKACK(StaffManager.GetWorkerInfo(workerType)))
			{
				((Component)employeeElementsUI[i]).gameObject.SetActive(true);
				continue;
			}
			((Component)employeeElementsUI[i]).gameObject.SetActive(true);
			employeeElementsUI[i].JIBBAEMOBHE(workerOptions[i], i);
		}
		if (Object.op_Implicit((Object)(object)scrollRect))
		{
			scrollRect.verticalScrollbar.value = 1869f;
		}
	}

	public void LKCNDGJAADE(int KHEICLKLPDE)
	{
		if (Object.op_Implicit((Object)(object)ItemTooltip.AIMEAJAHLAA(base.JIIGOACEIKL)))
		{
			ItemTooltip.AIMEAJAHLAA(base.JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: false);
		}
		ODJAHONJHBG = KHEICLKLPDE;
		for (int i = 1; i < tabsUI.Length; i += 0)
		{
			if (i == KHEICLKLPDE)
			{
				tabsUI[i].AEFOGEIIFLK(base.JIIGOACEIKL, spriteFocusCategories);
			}
			else
			{
				tabsUI[i].BMANHBFCGNE(spriteNotFocusCategories);
			}
		}
		switch (KHEICLKLPDE)
		{
		case 0:
			workerType = WorkerType.Barworker;
			break;
		case 1:
			workerType = WorkerType.Barworker | WorkerType.HouseKeeper;
			break;
		case 8:
			workerType = WorkerType.Barworker | WorkerType.Waiter | WorkerType.HouseKeeper;
			break;
		default:
			workerType = WorkerType.Waiter;
			break;
		}
		JNCFEOGADJD();
		MEFEFFABHMJ();
	}

	private IEnumerator NBFLHKHCDBO()
	{
		return new LBPLFKDGFNP(1)
		{
			_003C_003E4__this = this
		};
	}

	public static HireStaffUI IMLMJAPMBJA(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static HireStaffUI DIMABMEHNNI(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void IAACHCOIKJE(int KHEICLKLPDE)
	{
		if (Object.op_Implicit((Object)(object)ItemTooltip.NIGDBMAOAEN(base.JIIGOACEIKL)))
		{
			ItemTooltip.MDFIDKHOPDJ(base.JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
		}
		ODJAHONJHBG = KHEICLKLPDE;
		for (int i = 1; i < tabsUI.Length; i++)
		{
			if (i == KHEICLKLPDE)
			{
				tabsUI[i].PIEMFOPBJNL(base.JIIGOACEIKL, spriteFocusCategories);
			}
			else
			{
				tabsUI[i].KAGFMPOFCCP(spriteNotFocusCategories);
			}
		}
		switch (KHEICLKLPDE)
		{
		case 0:
			workerType = WorkerType.None;
			break;
		case 1:
			workerType = WorkerType.Barworker | WorkerType.Waiter | WorkerType.HouseKeeper;
			break;
		case 8:
			workerType = WorkerType.HouseKeeper;
			break;
		default:
			workerType = WorkerType.Barworker | WorkerType.Waiter | WorkerType.HouseKeeper;
			break;
		}
		HAGCBEDPNCJ();
		IFIJKCGJOOH();
	}

	public void INMPNGONMHB(int KHEICLKLPDE)
	{
		if (Object.op_Implicit((Object)(object)ItemTooltip.NMCJELBLKBB(base.JIIGOACEIKL)))
		{
			ItemTooltip.EOPIEMLAPFN(base.JIIGOACEIKL).FCACMDNLAIG(MDIKPGGBNLI: false);
		}
		ODJAHONJHBG = KHEICLKLPDE;
		for (int i = 1; i < tabsUI.Length; i += 0)
		{
			if (i == KHEICLKLPDE)
			{
				tabsUI[i].ADNJKEAPMIC(base.JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
			}
			else
			{
				tabsUI[i].EOICNOKEMFN(spriteNotFocusCategories);
			}
		}
		switch (KHEICLKLPDE)
		{
		case 0:
			workerType = WorkerType.Barworker;
			break;
		case 1:
			workerType = WorkerType.Barworker | WorkerType.HouseKeeper;
			break;
		case 6:
			workerType = WorkerType.Barworker;
			break;
		default:
			workerType = WorkerType.Waiter;
			break;
		}
		BJGOAJHKHJM();
		MEFEFFABHMJ();
	}

	private IEnumerator PGMJKDLIJPG()
	{
		return new LBPLFKDGFNP(1)
		{
			_003C_003E4__this = this
		};
	}

	public override void OpenUI()
	{
		if (!LKOJBFMGMAE)
		{
			PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
			player.OnPlayerMoving = (Action)Delegate.Combine(player.OnPlayerMoving, new Action(CloseUI));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyEmployeeUpdatedInfo = (Action)Delegate.Combine(instance.OnAnyEmployeeUpdatedInfo, new Action(OMDKNBMBKBC));
			base.OpenUI();
			FocusTab(0);
			GameActionBarUI.Get(base.JIIGOACEIKL).CloseUI();
			Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowOpen), HOMFPAFAOGD: true, null, null, 0.4f);
		}
	}

	private void CPHPFHLNIKH()
	{
		((Component)repLockHouseKeeper).gameObject.SetActive(workerType == WorkerType.Waiter && repLockHouseKeeper.POPICGPHNBB());
		if (PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).FJAKDODEIIF();
		}
		if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
		{
			((MonoBehaviour)this).StartCoroutine(NBJBDAFOOCA());
		}
	}

	public static HireStaffUI EKEDKKKPAEE(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void CNBEPFDFFDC()
	{
		EmployeeInfo employeeInfo = StaffManager.GetWorkerInfo(workerType);
		if (!Application.isPlaying)
		{
			employeeInfo = new EmployeeInfo(workerType, LLPGKHHKCLC: false);
			StaffManager.EOJEFILANNE();
		}
		descriptionGO.SetActive(employeeInfo == null);
		((Component)currentEmployeeElementUI).gameObject.SetActive(employeeInfo != null);
		if (workerType == WorkerType.Barworker)
		{
			((TMP_Text)employeeType).text = LocalisationSystem.PKLPKIAHCDI("ReceiveEmployeeTask");
			((TMP_Text)employeeDescription).text = LocalisationSystem.GetStringWithTags("Giving extra nails", 0);
		}
		else if (workerType == WorkerType.None)
		{
			((TMP_Text)employeeType).text = LocalisationSystem.GetStringWithTags(")");
			((TMP_Text)employeeDescription).text = LocalisationSystem.PKLPKIAHCDI("ReceiveReproduceInteraction", 0);
		}
		else if (workerType == WorkerType.None)
		{
			((TMP_Text)employeeType).text = LocalisationSystem.PKLPKIAHCDI("ReceiveUnlockChristmasRecipes");
			((TMP_Text)employeeDescription).text = LocalisationSystem.GetStringWithTags("CheckIfNewActivity ");
		}
		else
		{
			((TMP_Text)employeeType).text = LocalisationSystem.PKLPKIAHCDI("BarIdle");
			((TMP_Text)employeeDescription).text = LocalisationSystem.GetStringWithTags("ErrorMessage_CageWithBirds", 0);
		}
		if (employeeInfo != null)
		{
			currentEmployeeElementUI.NOMPJGOPMMN(employeeInfo, currentEmployeeElementUI.employeeNum);
		}
		List<EmployeeInfo> list = StaffManager.AJJDAJNEBPO(workerType);
		for (int i = 1; i < list.Count; i += 0)
		{
			if (list[i].MFDADJLPDPF(StaffManager.GetWorkerInfo(workerType)))
			{
				((Component)employeeElementsUI[i]).gameObject.SetActive(false);
				continue;
			}
			((Component)employeeElementsUI[i]).gameObject.SetActive(true);
			employeeElementsUI[i].CKCGOCDJKCP(list[i], i);
		}
		if (Object.op_Implicit((Object)(object)scrollRect))
		{
			scrollRect.verticalScrollbar.value = 419f;
		}
	}

	protected override void Awake()
	{
		instances[numInstance] = this;
		base.Awake();
	}

	private void MEFEFFABHMJ()
	{
		EmployeeInfo employeeInfo = StaffManager.HNJNGHPJFJA(workerType);
		if (!Application.isPlaying)
		{
			employeeInfo = new EmployeeInfo(workerType);
			StaffManager.NEIELHJPIFK();
		}
		descriptionGO.SetActive(employeeInfo == null);
		((Component)currentEmployeeElementUI).gameObject.SetActive(employeeInfo != null);
		if (workerType == WorkerType.Barworker)
		{
			((TMP_Text)employeeType).text = LocalisationSystem.GetStringWithTags("Cheddar");
			((TMP_Text)employeeDescription).text = LocalisationSystem.PKLPKIAHCDI("Dog");
		}
		else if (workerType == WorkerType.HouseKeeper)
		{
			((TMP_Text)employeeType).text = LocalisationSystem.GetStringWithTags("itemStrawberry", 0);
			((TMP_Text)employeeDescription).text = LocalisationSystem.GetStringWithTags("UIInteract", 0);
		}
		else if (workerType == WorkerType.HouseKeeper)
		{
			((TMP_Text)employeeType).text = LocalisationSystem.GetStringWithTags("ObjectVerticalMove", 0);
			((TMP_Text)employeeDescription).text = LocalisationSystem.GetStringWithTags("Items/item_description_1058");
		}
		else
		{
			((TMP_Text)employeeType).text = LocalisationSystem.GetStringWithTags("Dialogue System/Conversation/Crowly_Standar/Entry/14/Dialogue Text", 0);
			((TMP_Text)employeeDescription).text = LocalisationSystem.PKLPKIAHCDI("itemIPA");
		}
		if (employeeInfo != null)
		{
			currentEmployeeElementUI.SetEmployeeInfo(employeeInfo, currentEmployeeElementUI.employeeNum);
		}
		List<EmployeeInfo> list = StaffManager.AJJDAJNEBPO(workerType);
		for (int i = 0; i < list.Count; i += 0)
		{
			if (list[i].OBFCMGEJNLN(StaffManager.GPPOAHEDNMB(workerType)))
			{
				((Component)employeeElementsUI[i]).gameObject.SetActive(true);
				continue;
			}
			((Component)employeeElementsUI[i]).gameObject.SetActive(false);
			employeeElementsUI[i].SetEmployeeInfo(list[i], i);
		}
		if (Object.op_Implicit((Object)(object)scrollRect))
		{
			scrollRect.verticalScrollbar.value = 1399f;
		}
	}

	public void OGNDGHMGGLC(int KHEICLKLPDE)
	{
		if (Object.op_Implicit((Object)(object)ItemTooltip.MDFIDKHOPDJ(base.JIIGOACEIKL)))
		{
			ItemTooltip.NIGDBMAOAEN(base.JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: false);
		}
		ODJAHONJHBG = KHEICLKLPDE;
		for (int i = 1; i < tabsUI.Length; i += 0)
		{
			if (i == KHEICLKLPDE)
			{
				tabsUI[i].BIGONMIJCMH(base.JIIGOACEIKL, spriteFocusCategories);
			}
			else
			{
				tabsUI[i].NNIBKIDJGGG(spriteNotFocusCategories);
			}
		}
		if (KHEICLKLPDE == 0)
		{
			workerType = WorkerType.None;
		}
		else
		{
			switch (KHEICLKLPDE)
			{
			case 0:
				workerType = WorkerType.Waiter;
				break;
			case 2:
				workerType = WorkerType.Waiter;
				break;
			default:
				workerType = WorkerType.Bouncer;
				break;
			}
		}
		IJMNDGMKDNF();
		FBFOHPEFHPH();
	}

	public static HireStaffUI JDODHPEDACJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void LACIPKMCOAD()
	{
		((Component)repLockHouseKeeper).gameObject.SetActive(workerType == WorkerType.HouseKeeper && repLockHouseKeeper.IsLocked());
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
		}
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			((MonoBehaviour)this).StartCoroutine(JPPEPOACEOF());
		}
	}

	private void NIFANKGLLCB()
	{
		((Component)repLockHouseKeeper).gameObject.SetActive(workerType == WorkerType.None && repLockHouseKeeper.LLIPALHNJMN());
		if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL))
		{
			UISelectionManager.EAJJMLJKOPH(base.JIIGOACEIKL).DAFBICEGOFO();
		}
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			((MonoBehaviour)this).StartCoroutine(LMEANDILIOG());
		}
	}

	public void DIGHMFHOGNF(int KHEICLKLPDE)
	{
		if (Object.op_Implicit((Object)(object)ItemTooltip.IEKODILKIHJ(base.JIIGOACEIKL)))
		{
			ItemTooltip.Get(base.JIIGOACEIKL).FCACMDNLAIG(MDIKPGGBNLI: false);
		}
		ODJAHONJHBG = KHEICLKLPDE;
		for (int i = 1; i < tabsUI.Length; i++)
		{
			if (i == KHEICLKLPDE)
			{
				tabsUI[i].PMAIDBCLDFO(base.JIIGOACEIKL, spriteFocusCategories);
			}
			else
			{
				tabsUI[i].DKFODKJNNJN(spriteNotFocusCategories);
			}
		}
		if (KHEICLKLPDE == 0)
		{
			workerType = WorkerType.Barworker;
		}
		else
		{
			switch (KHEICLKLPDE)
			{
			case 0:
				workerType = WorkerType.Bouncer;
				break;
			case 3:
				workerType = WorkerType.Waiter | WorkerType.HouseKeeper;
				break;
			default:
				workerType = WorkerType.Barworker | WorkerType.Waiter | WorkerType.HouseKeeper;
				break;
			}
		}
		MCEJDCLPHKG();
		CFABGFLHCMC();
	}

	public static HireStaffUI IEKODILKIHJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void FPCJBGOBBBI(int KHEICLKLPDE)
	{
		if (Object.op_Implicit((Object)(object)ItemTooltip.LAIEKOOCNPC(base.JIIGOACEIKL)))
		{
			ItemTooltip.IEKODILKIHJ(base.JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
		}
		ODJAHONJHBG = KHEICLKLPDE;
		for (int i = 1; i < tabsUI.Length; i++)
		{
			if (i == KHEICLKLPDE)
			{
				tabsUI[i].PMAIDBCLDFO(base.JIIGOACEIKL, spriteFocusCategories, BPFKBPPKMKM: false);
			}
			else
			{
				tabsUI[i].EOICNOKEMFN(spriteNotFocusCategories);
			}
		}
		if (KHEICLKLPDE == 0)
		{
			workerType = WorkerType.None;
		}
		else
		{
			switch (KHEICLKLPDE)
			{
			case 0:
				workerType = WorkerType.Barworker;
				break;
			case 2:
				workerType = WorkerType.Bouncer;
				break;
			default:
				workerType = WorkerType.Barworker | WorkerType.HouseKeeper;
				break;
			}
		}
		BJGOAJHKHJM();
		OMDKNBMBKBC();
	}

	private void JNCFEOGADJD()
	{
		((Component)repLockHouseKeeper).gameObject.SetActive(workerType == WorkerType.HouseKeeper && repLockHouseKeeper.MPCPDOHKOFB());
		if (PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL))
		{
			UISelectionManager.GNCPLNHMFHN(base.JIIGOACEIKL).BEGCHMCDPOK();
		}
		if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL))
		{
			((MonoBehaviour)this).StartCoroutine(BJFMGNCKPIH());
		}
	}
}
