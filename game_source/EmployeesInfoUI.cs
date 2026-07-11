using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class EmployeesInfoUI : MainPanelWindow
{
	private static EmployeesInfoUI[] GJBBNHCMNJN = new EmployeesInfoUI[3];

	public WorkerType workerType;

	private float CMGDCLIIONE;

	public int currentTab;

	[SerializeField]
	private TabUI[] tabsUI;

	public CharacterCreator characterCreator;

	public CharacterCreator characterCreatorBouncer;

	public TextMeshProUGUI employeeName;

	public TextMeshProUGUI workerTypeText;

	public TextMeshProUGUI level;

	public TextMeshProUGUI antiquity;

	public MoneyUI salary;

	public TextMeshProUGUI professionPoints;

	public CheckboxUI workingCheckbox;

	public CheckboxUI[] tasksCheckboxes;

	public PerkSlotUI[] perksSlotsUI;

	public TooltipDisplay barTooltipDisplay;

	public Image fillBar;

	public Image fillBarImage;

	public Sprite fillBarSprite;

	public Sprite fillBarMaxLevelSprite;

	public GameObject firstElementSelected;

	private void PNDCOCOCALP()
	{
		EmployeeInfo employeeInfo = StaffManager.GPPOAHEDNMB(workerType);
		salary.AAPLOOIDCGP(employeeInfo.PMPGPNHGKHE());
	}

	public void ToggleWorking(int ABAIKKGKDGD, bool AODONKKHPBP)
	{
		if (OnlineManager.MasterOrOffline())
		{
			workingCheckbox.SetActivated(AODONKKHPBP);
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineEmployeesManager.instance.SendEmployeeWorking(workerType, AODONKKHPBP);
		}
		else
		{
			StaffManager.SetWorking(base.JIIGOACEIKL, workerType, AODONKKHPBP);
		}
	}

	public void FocusAvailableTab()
	{
		int num = -1;
		if (StaffManager.GetWorkerInfo(WorkerType.Barworker) != null)
		{
			num = 0;
		}
		if (StaffManager.GetWorkerInfo(WorkerType.Waiter) != null && num == -1)
		{
			num = 1;
		}
		if (StaffManager.GetWorkerInfo(WorkerType.Bouncer) != null && num == -1)
		{
			num = 2;
		}
		if (StaffManager.GetWorkerInfo(WorkerType.HouseKeeper) != null && num == -1)
		{
			num = 3;
		}
		if (num != -1)
		{
			FocusTab(num);
		}
	}

	public static EmployeesInfoUI Get(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, GJBBNHCMNJN);
	}

	public override void CloseUIRemainActive()
	{
		if (EmployeeTreeUI.Get(base.JIIGOACEIKL).IsOpen())
		{
			EmployeeTreeUI.Get(base.JIIGOACEIKL).CloseUI();
			content.SetActive(true);
		}
		base.CloseUIRemainActive();
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyEmployeeUpdatedInfo = (Action)Delegate.Remove(instance.OnAnyEmployeeUpdatedInfo, new Action(GIBAAPHMGIO));
	}

	public IEnumerator SelectFirstElement()
	{
		yield return null;
		UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(firstElementSelected);
	}

	protected override void Start()
	{
		base.Start();
		CheckboxUI checkboxUI = workingCheckbox;
		checkboxUI.OnCheckboxChanged = (Action<int, bool>)Delegate.Combine(checkboxUI.OnCheckboxChanged, new Action<int, bool>(ToggleWorking));
		for (int i = 0; i < tasksCheckboxes.Length; i++)
		{
			CheckboxUI obj = tasksCheckboxes[i];
			obj.OnCheckboxChanged = (Action<int, bool>)Delegate.Combine(obj.OnCheckboxChanged, new Action<int, bool>(DGGMGIKLCML));
		}
		OnUIClose = (Action<int>)Delegate.Combine(OnUIClose, (Action<int>)delegate(int playerNum)
		{
			EmployeeTreeUI.Get(playerNum).CloseUI();
		});
	}

	protected override void Update()
	{
		base.Update();
		if (PlayerInputs.InputsEnabled(base.JIIGOACEIKL) && PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonUp("Staff") && StaffManager.IsAnyWorkerHired())
		{
			if (LKOJBFMGMAE && !EmployeeTreeUI.Get(base.JIIGOACEIKL).IsOpen())
			{
				ToggleUI();
			}
			else if (CCCDKINDOKC())
			{
				ToggleUI();
			}
		}
		else if (LKOJBFMGMAE && PlayerInputs.InputsEnabled(base.JIIGOACEIKL))
		{
			if (Utils.IIHPGJIJOAD(base.JIIGOACEIKL, ref CMGDCLIIONE, "UINextCategory"))
			{
				FocusNextTab(1);
			}
			else if (Utils.IIHPGJIJOAD(base.JIIGOACEIKL, ref CMGDCLIIONE, "UIPreviousCategory"))
			{
				FocusNextTab(-1);
			}
			if (PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonDown("UIAddRemove") && !EmployeeTreeUI.Get(base.JIIGOACEIKL).IsOpen())
			{
				DismissWorkerConfirmation();
			}
			if (PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonDown("UISelectGamepad") && !EmployeeTreeUI.Get(base.JIIGOACEIKL).IsOpen())
			{
				perksSlotsUI[0].OpenEmployeeTreeUI();
			}
		}
	}

	public void BJIECDJKKOE(int ABAIKKGKDGD, bool AODONKKHPBP)
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			tasksCheckboxes[ABAIKKGKDGD].GPILFCCFEAG(AODONKKHPBP);
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineEmployeesManager.instance.OAHNBEADJIP(workerType, ABAIKKGKDGD, AODONKKHPBP);
		}
		else
		{
			StaffManager.CHHGHNJPLGF(base.JIIGOACEIKL, workerType, ABAIKKGKDGD, AODONKKHPBP);
		}
	}

	public override void CloseUI()
	{
		if (EmployeeTreeUI.Get(base.JIIGOACEIKL).IsOpen())
		{
			EmployeeTreeUI.Get(base.JIIGOACEIKL).CloseUI();
			content.SetActive(true);
		}
		if (IsOpen())
		{
			base.CloseUI();
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyEmployeeUpdatedInfo = (Action)Delegate.Remove(instance.OnAnyEmployeeUpdatedInfo, new Action(GIBAAPHMGIO));
		}
	}

	public override void OnContentActivated()
	{
		base.OnContentActivated();
		UpdateAvailableTabs();
		FocusAvailableTab();
		CommonReferences.GGFJGHHHEJC.OnEmployeeInfoOpen(base.JIIGOACEIKL);
		UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			((MonoBehaviour)this).StartCoroutine(SelectFirstElement());
		}
	}

	public void ACMJIJDBCPN()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		MainUI.LBHLPIFCINB().Open(base.JIIGOACEIKL);
		((TMP_Text)MainUI.MCPEEGPBPLH().boxText).text = LocalisationSystem.GetStringWithTags("k ", base.JIIGOACEIKL);
		MainUI.MCPEEGPBPLH().HMMOMJBMPML(new UnityAction(AAFOEOCMDIA));
	}

	public IEnumerator BPKNALLBDED()
	{
		yield return null;
		UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(firstElementSelected);
	}

	private void PKBGNJJBAMK()
	{
		if (StaffManager.GetWorkerInfo(workerType) != null)
		{
			UpdateAvailableTabs();
			UpdateWorkerInfo();
		}
		else if (StaffManager.MHBFKBPMFJN())
		{
			UpdateAvailableTabs();
			FocusAvailableTab();
		}
		else
		{
			BOBCIFEDJED();
			MainPanelUI.MGLNAMHAIDG(base.JIIGOACEIKL).OAIGAIPJGDG();
			MainPanelUI.EPLOMIBMKFC(base.JIIGOACEIKL).KEMLDNDLAMI(1);
		}
	}

	public void DONNJOOBPGP(int KHEICLKLPDE)
	{
		if (Object.op_Implicit((Object)(object)ItemTooltip.IEABDMDELFO(base.JIIGOACEIKL)))
		{
			ItemTooltip.Get(base.JIIGOACEIKL).HIIOCMNJGCI(MDIKPGGBNLI: false);
		}
		currentTab = KHEICLKLPDE;
		for (int i = 1; i < tabsUI.Length; i++)
		{
			if (i == KHEICLKLPDE)
			{
				tabsUI[i].EGOAICDKBHH(base.JIIGOACEIKL);
			}
			else
			{
				tabsUI[i].DLBFFPOEBLN();
			}
		}
		switch (KHEICLKLPDE)
		{
		case 0:
			workerType = WorkerType.None;
			break;
		case 1:
			workerType = WorkerType.Barworker | WorkerType.Waiter;
			break;
		case 4:
			workerType = WorkerType.None;
			break;
		default:
			workerType = WorkerType.HouseKeeper;
			break;
		}
		UpdateWorkerInfo();
		if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL))
		{
			((MonoBehaviour)this).StartCoroutine(SelectFirstElement());
		}
	}

	private void AAFOEOCMDIA()
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineEmployeesManager.instance.SendDismissWorker(workerType);
		}
		else
		{
			StaffManager.DismissWorker(workerType);
		}
	}

	public override void OpenUI()
	{
		if (!IsOpen())
		{
			base.OpenUI();
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyEmployeeUpdatedInfo = (Action)Delegate.Combine(instance.OnAnyEmployeeUpdatedInfo, new Action(GIBAAPHMGIO));
		}
	}

	private void DGGMGIKLCML(int ABAIKKGKDGD, bool AODONKKHPBP)
	{
		ToggleTask(ABAIKKGKDGD, AODONKKHPBP);
	}

	private void OFBFOIAGKNI()
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineEmployeesManager.instance.SendDismissWorker(workerType);
		}
		else
		{
			StaffManager.KDDEOJEFJCM(workerType, PNOAJBHOJGH: false);
		}
	}

	public IEnumerator JJGDPIKFPGJ()
	{
		yield return null;
		UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(firstElementSelected);
	}

	public void JBHPPBLJKNB()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		MainUI.LBHLPIFCINB().Open(base.JIIGOACEIKL);
		((TMP_Text)MainUI.MCPEEGPBPLH().boxText).text = LocalisationSystem.PKLPKIAHCDI("Actionbar 4", base.JIIGOACEIKL);
		MainUI.LBHLPIFCINB().EIKBHDCGDAH(new UnityAction(OFBFOIAGKNI));
	}

	protected override void Awake()
	{
		GJBBNHCMNJN[numInstance] = this;
		base.Awake();
	}

	public void RandomCharacter(int KHEICLKLPDE)
	{
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
		StaffManager.InitializeWorkerInfo(workerType);
		FocusTab(KHEICLKLPDE);
	}

	public void UpdateWorkerInfo()
	{
		EmployeeInfo currentWorkerInfo = GetCurrentWorkerInfo();
		((Component)characterCreatorBouncer).gameObject.SetActive(workerType == WorkerType.Bouncer);
		((Component)characterCreator).gameObject.SetActive(workerType != WorkerType.Bouncer);
		if (workerType == WorkerType.Bouncer)
		{
			characterCreatorBouncer.SetHumanInfo(currentWorkerInfo);
		}
		else
		{
			characterCreator.SetHumanInfo(currentWorkerInfo);
		}
		if (workerType == WorkerType.Barworker)
		{
			((TMP_Text)workerTypeText).text = LocalisationSystem.GetStringWithTags("Bartender", base.JIIGOACEIKL);
		}
		else
		{
			((TMP_Text)workerTypeText).text = LocalisationSystem.GetStringWithTags(workerType.ToString(), base.JIIGOACEIKL);
		}
		((TMP_Text)employeeName).text = currentWorkerInfo.name;
		((TMP_Text)antiquity).text = currentWorkerInfo.antiquity.KBCEHEPDDHI();
		if (currentWorkerInfo.level == currentWorkerInfo.MABLJEEMEBC())
		{
			((TMP_Text)level).text = (currentWorkerInfo.level - 1).ToString();
		}
		else
		{
			((TMP_Text)level).text = currentWorkerInfo.level.ToString();
		}
		if (currentWorkerInfo.level == currentWorkerInfo.MABLJEEMEBC())
		{
			barTooltipDisplay.tooltipBody = LocalisationSystem.Get("Max");
		}
		else
		{
			barTooltipDisplay.tooltipBody = currentWorkerInfo.levelPoints + " / " + StaffManager.GetNextLevelPoints(currentWorkerInfo.level);
		}
		if (currentWorkerInfo.level == currentWorkerInfo.MABLJEEMEBC())
		{
			fillBar.fillAmount = 1f;
			fillBarImage.sprite = fillBarMaxLevelSprite;
		}
		else
		{
			fillBar.fillAmount = (float)currentWorkerInfo.levelPoints / (float)StaffManager.GetNextLevelPoints(currentWorkerInfo.level);
			fillBarImage.sprite = fillBarSprite;
		}
		((TMP_Text)professionPoints).text = currentWorkerInfo.professionPoints.ToString();
		workingCheckbox.SetActivated(currentWorkerInfo.working);
		IMCAJEIADKA();
		EmployeeTask[] employeeTask = StaffManager.GetEmployeeTask(workerType);
		for (int i = 0; i < currentWorkerInfo.tasks.Length; i++)
		{
			((Component)tasksCheckboxes[i]).gameObject.SetActive(true);
			tasksCheckboxes[i].SetActivated(currentWorkerInfo.tasks[i]);
			tasksCheckboxes[i].SetDescription(LocalisationSystem.GetStringWithTags(employeeTask[i].taskName, base.JIIGOACEIKL));
		}
		for (int j = currentWorkerInfo.tasks.Length; j < tasksCheckboxes.Length; j++)
		{
			((Component)tasksCheckboxes[j]).gameObject.SetActive(false);
		}
		for (int k = 0; k < currentWorkerInfo.perksInfo.Count; k++)
		{
			((Component)perksSlotsUI[k]).gameObject.SetActive(true);
			perksSlotsUI[k].UpdateInfo(currentWorkerInfo, currentWorkerInfo.perksInfo[k], k);
			perksSlotsUI[k].SetPositiveNegativeSprite(currentWorkerInfo.perksInfo[k].perk);
			((Selectable)perksSlotsUI[k].button).interactable = !currentWorkerInfo.perksInfo[k].perk.negative;
		}
		for (int l = currentWorkerInfo.perksInfo.Count; l < perksSlotsUI.Length; l++)
		{
			((Component)perksSlotsUI[l]).gameObject.SetActive(false);
		}
	}

	public void FocusTab(int KHEICLKLPDE)
	{
		if (Object.op_Implicit((Object)(object)ItemTooltip.Get(base.JIIGOACEIKL)))
		{
			ItemTooltip.Get(base.JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
		}
		currentTab = KHEICLKLPDE;
		for (int i = 0; i < tabsUI.Length; i++)
		{
			if (i == KHEICLKLPDE)
			{
				tabsUI[i].ShowTab(base.JIIGOACEIKL);
			}
			else
			{
				tabsUI[i].HideTab();
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
		UpdateWorkerInfo();
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			((MonoBehaviour)this).StartCoroutine(SelectFirstElement());
		}
	}

	private void IMCAJEIADKA()
	{
		EmployeeInfo workerInfo = StaffManager.GetWorkerInfo(workerType);
		salary.SetPrice(workerInfo.MFMFHEGMAKI());
	}

	public void FocusNextTab(int FCGBJEIIMBC)
	{
		for (int i = 1; i < tabsUI.Length; i++)
		{
			int num = Utils.NMLNAGFLNMC(currentTab + i * FCGBJEIIMBC, tabsUI.Length);
			if (((Component)tabsUI[num]).gameObject.activeSelf)
			{
				FocusTab(num);
				break;
			}
		}
	}

	public void DismissWorkerConfirmation()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		MainUI.GetYesNoDialogue().Open(base.JIIGOACEIKL);
		((TMP_Text)MainUI.GetYesNoDialogue().boxText).text = LocalisationSystem.GetStringWithTags("DismissWorker?", base.JIIGOACEIKL);
		MainUI.GetYesNoDialogue().AddYesAction(new UnityAction(AAFOEOCMDIA));
	}

	public EmployeeInfo GetCurrentWorkerInfo()
	{
		return StaffManager.GetWorkerInfo(workerType);
	}

	private void OIKAAHFICPP()
	{
		if (StaffManager.GPPOAHEDNMB(workerType) != null)
		{
			UpdateAvailableTabs();
			UpdateWorkerInfo();
		}
		else if (StaffManager.MHBFKBPMFJN())
		{
			UpdateAvailableTabs();
			FocusAvailableTab();
		}
		else
		{
			BOBCIFEDJED();
			MainPanelUI.PHDBJGOEKHB(base.JIIGOACEIKL).CPCDEPFKHAC();
			MainPanelUI.JDODHPEDACJ(base.JIIGOACEIKL).LNJJLHPKFPP(0);
		}
	}

	public void UpdateAvailableTabs()
	{
		((Component)tabsUI[0]).gameObject.SetActive(StaffManager.GetWorkerInfo(WorkerType.Barworker) != null);
		((Component)tabsUI[1]).gameObject.SetActive(StaffManager.GetWorkerInfo(WorkerType.Waiter) != null);
		((Component)tabsUI[2]).gameObject.SetActive(StaffManager.GetWorkerInfo(WorkerType.Bouncer) != null);
		((Component)tabsUI[3]).gameObject.SetActive(StaffManager.GetWorkerInfo(WorkerType.HouseKeeper) != null);
	}

	public void ToggleTask(int ABAIKKGKDGD, bool AODONKKHPBP)
	{
		if (OnlineManager.MasterOrOffline())
		{
			tasksCheckboxes[ABAIKKGKDGD].SetActivated(AODONKKHPBP);
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineEmployeesManager.instance.SendEmployeeTask(workerType, ABAIKKGKDGD, AODONKKHPBP);
		}
		else
		{
			StaffManager.SetEmployeeTask(base.JIIGOACEIKL, workerType, ABAIKKGKDGD, AODONKKHPBP);
		}
	}

	private void GIBAAPHMGIO()
	{
		if (StaffManager.GetWorkerInfo(workerType) != null)
		{
			UpdateAvailableTabs();
			UpdateWorkerInfo();
		}
		else if (StaffManager.IsAnyWorkerHired())
		{
			UpdateAvailableTabs();
			FocusAvailableTab();
		}
		else
		{
			CloseUI();
			MainPanelUI.Get(base.JIIGOACEIKL).UpdateAvailableTabs();
			MainPanelUI.Get(base.JIIGOACEIKL).FocusMainPanel(1);
		}
	}
}
