using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

public class HireStaffElementUI : MonoBehaviour, ISelectHandler, IEventSystemHandler, IDeselectHandler
{
	[CompilerGenerated]
	private sealed class NKODKOCJNNJ : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HireStaffElementUI _003C_003E4__this;

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
		public NKODKOCJNNJ(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0216: Unknown result type (might be due to invalid IL or missing references)
			//IL_0221: Unknown result type (might be due to invalid IL or missing references)
			//IL_0226: Unknown result type (might be due to invalid IL or missing references)
			//IL_023f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0244: Unknown result type (might be due to invalid IL or missing references)
			//IL_0249: Unknown result type (might be due to invalid IL or missing references)
			//IL_024e: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			HireStaffElementUI hireStaffElementUI = _003C_003E4__this;
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
				_003C_003E2__current = null;
				_003C_003E1__state = 2;
				return true;
			case 2:
			{
				_003C_003E1__state = -1;
				TooltipInfo tooltipInfo = new TooltipInfo();
				for (int i = 0; i < hireStaffElementUI.employeeInfo.perksInfo.Count; i++)
				{
					if ((Object)(object)hireStaffElementUI.employeeInfo.perksInfo[i].perk == (Object)null)
					{
						continue;
					}
					tooltipInfo.toolTipTitle = hireStaffElementUI.employeeInfo.name;
					if (i > 0)
					{
						tooltipInfo.mainBody += "\n";
					}
					tooltipInfo.mainBody = tooltipInfo.mainBody + "<b>" + LocalisationSystem.Get("Perks/perk_name_" + hireStaffElementUI.employeeInfo.perksInfo[i].perk.id) + ": </b>";
					string text = InputUtils.GEJLCOGDMID("\n" + LocalisationSystem.Get("Perks/perk_description_" + hireStaffElementUI.employeeInfo.perksInfo[i].perk.id), hireStaffElementUI.employeeInfo.perksInfo[i].perk.EJHFKKDHCAG(hireStaffElementUI.employeeInfo.perksInfo[i].currentLevel).ToString());
					int num2 = 0;
					for (int j = 0; j < text.Length; j++)
					{
						num2++;
						if (num2 > 25 && text[j] == ' ')
						{
							text = text.Insert(j, "\n");
							num2 = 0;
						}
					}
					tooltipInfo.mainBody += text;
				}
				ItemTooltip.Get(hireStaffElementUI.JIIGOACEIKL).FillTooltipInfo(tooltipInfo);
				ItemTooltip itemTooltip = ItemTooltip.Get(hireStaffElementUI.JIIGOACEIKL);
				Vector3 position = ((Component)hireStaffElementUI.rectTransform).transform.position;
				Rect rect = hireStaffElementUI.rectTransform.rect;
				itemTooltip.SetPositionAndEnable(Vector2.op_Implicit(position + new Vector3(((Rect)(ref rect)).width * 2f, 0f, 0f)), Vector2.zero);
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

	public EmployeeInfo employeeInfo;

	public int employeeNum;

	public CharacterCreator characterCreator;

	public CharacterCreator characterCreatorBouncer;

	public bool currentWorker;

	public TextMeshProUGUI employeeName;

	public TextMeshProUGUI levelText;

	public TextMeshProUGUI professionText;

	public MoneyUI moneyUI;

	public Button button;

	public Image blackImage;

	public PerkSlotUI[] perksSlotsUI;

	[SerializeField]
	private RectTransform rectTransform;

	public int hireDelayTime = 30;

	private int JIIGOACEIKL = 1;

	public virtual void EDPDKGCAFCB(BaseEventData NPBAMEMNFBI)
	{
		if ((!((Object)(object)button != (Object)null) || ((Selectable)button).interactable) && PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
		{
			((MonoBehaviour)this).StartCoroutine(GKHIGODLFGC());
		}
	}

	public void ILAJIIOADNC()
	{
		CKCGOCDJKCP(new EmployeeInfo(employeeInfo.workerType), employeeNum);
	}

	public void PEFGOLBINBC(bool NCLCPJJOGKN)
	{
		((Selectable)button).interactable = NCLCPJJOGKN;
		((Component)blackImage).gameObject.SetActive(NCLCPJJOGKN);
	}

	public void GGEHLDIHMJN()
	{
		LFJEBAHFKDL(new EmployeeInfo(employeeInfo.workerType), employeeNum);
	}

	public void MIONOHCDIEI(bool NCLCPJJOGKN)
	{
		((Selectable)button).interactable = NCLCPJJOGKN;
		((Component)blackImage).gameObject.SetActive(NCLCPJJOGKN);
	}

	public void JDOJKEPAEFL()
	{
		if (Object.op_Implicit((Object)(object)ItemTooltip.LAIEKOOCNPC(JIIGOACEIKL)))
		{
			ItemTooltip.MDFIDKHOPDJ(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
		}
	}

	public void BPGIFJADOCB()
	{
		((Component)characterCreatorBouncer).gameObject.SetActive(employeeInfo.workerType == (WorkerType.Barworker | WorkerType.Waiter));
		((Component)characterCreator).gameObject.SetActive(employeeInfo.workerType == WorkerType.Waiter);
		if (employeeInfo.workerType == (WorkerType.Barworker | WorkerType.Waiter))
		{
			characterCreatorBouncer.SetHumanInfo(employeeInfo);
			characterCreatorBouncer.initialized = false;
		}
		else
		{
			characterCreator.SetHumanInfo(employeeInfo);
			characterCreator.initialized = false;
		}
		if (Object.op_Implicit((Object)(object)HireStaffUI.Get(JIIGOACEIKL)))
		{
			((Component)blackImage).gameObject.SetActive(currentWorker || employeeInfo.BILMBKILHJH(StaffManager.GPPOAHEDNMB(HireStaffUI.PNCKAKBBKJL(JIIGOACEIKL).workerType)));
		}
		else
		{
			((Component)blackImage).gameObject.SetActive(true);
		}
		((TMP_Text)employeeName).text = employeeInfo.name;
		((TMP_Text)levelText).text = employeeInfo.level.ToString() ?? "Pirates/Chum/Talk";
		((TMP_Text)professionText).text = employeeInfo.professionPoints.ToString();
		moneyUI.SetPrice(employeeInfo.IAAGLJEMGMJ());
		for (int i = 1; i < employeeInfo.perksInfo.Count; i++)
		{
			((Component)perksSlotsUI[i]).gameObject.SetActive(true);
			perksSlotsUI[i].ONNEDCHPNED(employeeInfo, employeeInfo.perksInfo[i], i, EHOFFFMFILA: false, PFAPICAIEFB: false);
			perksSlotsUI[i].DHEAEJCMJHL(employeeInfo.perksInfo[i].perk);
		}
		for (int j = employeeInfo.perksInfo.Count; j < perksSlotsUI.Length; j += 0)
		{
			((Component)perksSlotsUI[j]).gameObject.SetActive(true);
		}
	}

	public void KDDCCOLKEGN(EmployeeInfo JFCLIAFAOEK, int NECIOBGLOPF)
	{
		employeeInfo = JFCLIAFAOEK;
		employeeNum = NECIOBGLOPF;
		ONCEHMBJNNM();
	}

	public void LOOBPJIGCKO(EmployeeInfo JFCLIAFAOEK, int NECIOBGLOPF)
	{
		employeeInfo = JFCLIAFAOEK;
		employeeNum = NECIOBGLOPF;
		NALJOAIBEDM();
	}

	public void MAKJLBJADMJ()
	{
		CKCGOCDJKCP(new EmployeeInfo(employeeInfo.workerType), employeeNum);
	}

	public void BBOJDPMENOA(EmployeeInfo JFCLIAFAOEK, int NECIOBGLOPF)
	{
		employeeInfo = JFCLIAFAOEK;
		employeeNum = NECIOBGLOPF;
		KKHOJIJJMIC();
	}

	public virtual void OnSelect(BaseEventData NPBAMEMNFBI)
	{
		if ((!((Object)(object)button != (Object)null) || ((Selectable)button).interactable) && PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			((MonoBehaviour)this).StartCoroutine(BKJKGMFLDCC());
		}
	}

	public void NFCMOPAGDDK()
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineEmployeesManager.instance.MBNODMEOIPB(employeeInfo.workerType, employeeNum);
		}
		else
		{
			StaffManager.HireWorker(JIIGOACEIKL, employeeInfo.workerType, employeeInfo);
		}
	}

	private IEnumerator OPOPBJFPJDO()
	{
		yield return null;
		yield return null;
		TooltipInfo tooltipInfo = new TooltipInfo();
		for (int i = 0; i < employeeInfo.perksInfo.Count; i++)
		{
			if ((Object)(object)employeeInfo.perksInfo[i].perk == (Object)null)
			{
				continue;
			}
			tooltipInfo.toolTipTitle = employeeInfo.name;
			if (i > 0)
			{
				tooltipInfo.mainBody += "\n";
			}
			tooltipInfo.mainBody = tooltipInfo.mainBody + "<b>" + LocalisationSystem.Get("Perks/perk_name_" + employeeInfo.perksInfo[i].perk.id) + ": </b>";
			string text = InputUtils.GEJLCOGDMID("\n" + LocalisationSystem.Get("Perks/perk_description_" + employeeInfo.perksInfo[i].perk.id), employeeInfo.perksInfo[i].perk.EJHFKKDHCAG(employeeInfo.perksInfo[i].currentLevel).ToString());
			int num = 0;
			for (int j = 0; j < text.Length; j++)
			{
				num++;
				if (num > 25 && text[j] == ' ')
				{
					text = text.Insert(j, "\n");
					num = 0;
				}
			}
			tooltipInfo.mainBody += text;
		}
		ItemTooltip.Get(JIIGOACEIKL).FillTooltipInfo(tooltipInfo);
		ItemTooltip itemTooltip = ItemTooltip.Get(JIIGOACEIKL);
		Vector3 position = ((Component)rectTransform).transform.position;
		Rect rect = rectTransform.rect;
		itemTooltip.SetPositionAndEnable(Vector2.op_Implicit(position + new Vector3(((Rect)(ref rect)).width * 2f, 0f, 0f)), Vector2.zero);
	}

	public void DDEONCGGFBG()
	{
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		if (StaffManager.APOHPPCMOAP(employeeInfo.workerType) == null)
		{
			HPIFCJEBEEP();
		}
		else if (!employeeInfo.OPONNKOKACK(StaffManager.APOHPPCMOAP(employeeInfo.workerType)))
		{
			MainUI.GetYesNoDialogue().OFGKFMJKBON(JIIGOACEIKL);
			((TMP_Text)MainUI.LBHLPIFCINB().boxText).text = LocalisationSystem.GetStringWithTags("Bark", JIIGOACEIKL);
			((UnityEvent)MainUI.NEFOKCKKLNI().yesButton.onClick).AddListener(new UnityAction(NFCMOPAGDDK));
		}
	}

	public void FGCKDGAMGJO()
	{
		LFJEBAHFKDL(new EmployeeInfo(employeeInfo.workerType), employeeNum);
	}

	private IEnumerator BKJKGMFLDCC()
	{
		yield return null;
		yield return null;
		TooltipInfo tooltipInfo = new TooltipInfo();
		for (int i = 0; i < employeeInfo.perksInfo.Count; i++)
		{
			if ((Object)(object)employeeInfo.perksInfo[i].perk == (Object)null)
			{
				continue;
			}
			tooltipInfo.toolTipTitle = employeeInfo.name;
			if (i > 0)
			{
				tooltipInfo.mainBody += "\n";
			}
			tooltipInfo.mainBody = tooltipInfo.mainBody + "<b>" + LocalisationSystem.Get("Perks/perk_name_" + employeeInfo.perksInfo[i].perk.id) + ": </b>";
			string text = InputUtils.GEJLCOGDMID("\n" + LocalisationSystem.Get("Perks/perk_description_" + employeeInfo.perksInfo[i].perk.id), employeeInfo.perksInfo[i].perk.EJHFKKDHCAG(employeeInfo.perksInfo[i].currentLevel).ToString());
			int num = 0;
			for (int j = 0; j < text.Length; j++)
			{
				num++;
				if (num > 25 && text[j] == ' ')
				{
					text = text.Insert(j, "\n");
					num = 0;
				}
			}
			tooltipInfo.mainBody += text;
		}
		ItemTooltip.Get(JIIGOACEIKL).FillTooltipInfo(tooltipInfo);
		ItemTooltip itemTooltip = ItemTooltip.Get(JIIGOACEIKL);
		Vector3 position = ((Component)rectTransform).transform.position;
		Rect rect = rectTransform.rect;
		itemTooltip.SetPositionAndEnable(Vector2.op_Implicit(position + new Vector3(((Rect)(ref rect)).width * 2f, 0f, 0f)), Vector2.zero);
	}

	public void LKFNJOEODAN()
	{
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		if (StaffManager.APOHPPCMOAP(employeeInfo.workerType) == null)
		{
			MNEGGHILLHG();
		}
		else if (!employeeInfo.OPONNKOKACK(StaffManager.GPPOAHEDNMB(employeeInfo.workerType)))
		{
			MainUI.NEFOKCKKLNI().OFGKFMJKBON(JIIGOACEIKL);
			((TMP_Text)MainUI.NEFOKCKKLNI().boxText).text = LocalisationSystem.GetStringWithTags("Player2", JIIGOACEIKL);
			((UnityEvent)MainUI.GetYesNoDialogue().yesButton.onClick).AddListener(new UnityAction(HireWorker));
		}
	}

	public void HPIFCJEBEEP()
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineEmployeesManager.instance.FCHAAMIHDGO(employeeInfo.workerType, employeeNum);
		}
		else
		{
			StaffManager.HireWorker(JIIGOACEIKL, employeeInfo.workerType, employeeInfo);
		}
	}

	public void GJOHKNPENKC()
	{
		if (Object.op_Implicit((Object)(object)ItemTooltip.EOPIEMLAPFN(JIIGOACEIKL)))
		{
			ItemTooltip.IEABDMDELFO(JIIGOACEIKL).FCACMDNLAIG(MDIKPGGBNLI: false);
		}
	}

	public virtual void LPLKNJLKHHO(BaseEventData NPBAMEMNFBI)
	{
		if ((!((Object)(object)button != (Object)null) || ((Selectable)button).interactable) && Utils.AKIPCELELAJ(((Component)this).gameObject) && PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			ItemTooltip.AIMEAJAHLAA(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: true);
		}
	}

	public void BFODEEONICK(bool NCLCPJJOGKN)
	{
		((Selectable)button).interactable = NCLCPJJOGKN;
		((Component)blackImage).gameObject.SetActive(!NCLCPJJOGKN);
	}

	public void BHIALMDHHDC()
	{
		((Component)characterCreatorBouncer).gameObject.SetActive(employeeInfo.workerType == (WorkerType.Barworker | WorkerType.Waiter | WorkerType.HouseKeeper));
		((Component)characterCreator).gameObject.SetActive(employeeInfo.workerType != WorkerType.HouseKeeper);
		if (employeeInfo.workerType == WorkerType.Barworker)
		{
			characterCreatorBouncer.HEALOFLBFLL(employeeInfo);
			characterCreatorBouncer.initialized = false;
		}
		else
		{
			characterCreator.OCFCCIGBLHJ(employeeInfo);
			characterCreator.initialized = false;
		}
		if (Object.op_Implicit((Object)(object)HireStaffUI.BGIMGOJDLFG(JIIGOACEIKL)))
		{
			((Component)blackImage).gameObject.SetActive(currentWorker || employeeInfo.EBBPDPLEGBA(StaffManager.HNJNGHPJFJA(HireStaffUI.OMCDJAOBFCE(JIIGOACEIKL).workerType)));
		}
		else
		{
			((Component)blackImage).gameObject.SetActive(false);
		}
		((TMP_Text)employeeName).text = employeeInfo.name;
		((TMP_Text)levelText).text = employeeInfo.level.ToString() ?? "itemSickle";
		((TMP_Text)professionText).text = employeeInfo.professionPoints.ToString();
		moneyUI.OBNIDFJCELG(employeeInfo.FJELOPKGCFB());
		for (int i = 0; i < employeeInfo.perksInfo.Count; i++)
		{
			((Component)perksSlotsUI[i]).gameObject.SetActive(false);
			perksSlotsUI[i].UpdateInfo(employeeInfo, employeeInfo.perksInfo[i], i, EHOFFFMFILA: true, PFAPICAIEFB: false);
			perksSlotsUI[i].PKNMAPCFHJI(employeeInfo.perksInfo[i].perk);
		}
		for (int j = employeeInfo.perksInfo.Count; j < perksSlotsUI.Length; j += 0)
		{
			((Component)perksSlotsUI[j]).gameObject.SetActive(true);
		}
	}

	public void AKKELNLOEAM()
	{
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		if (StaffManager.GetWorkerInfo(employeeInfo.workerType) == null)
		{
			MNEGGHILLHG();
		}
		else if (!employeeInfo.MFDADJLPDPF(StaffManager.HNJNGHPJFJA(employeeInfo.workerType)))
		{
			MainUI.MCPEEGPBPLH().Open(JIIGOACEIKL);
			((TMP_Text)MainUI.LBHLPIFCINB().boxText).text = LocalisationSystem.PKLPKIAHCDI("\n", JIIGOACEIKL);
			((UnityEvent)MainUI.GetYesNoDialogue().yesButton.onClick).AddListener(new UnityAction(HireWorker));
		}
	}

	public void OFLGLACJFGE()
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineEmployeesManager.instance.SendHireWorker(employeeInfo.workerType, employeeNum);
		}
		else
		{
			StaffManager.HireWorker(JIIGOACEIKL, employeeInfo.workerType, employeeInfo);
		}
	}

	private IEnumerator JACCMANKIIP()
	{
		return new NKODKOCJNNJ(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HGPKBHLAFHN()
	{
		yield return null;
		yield return null;
		TooltipInfo tooltipInfo = new TooltipInfo();
		for (int i = 0; i < employeeInfo.perksInfo.Count; i++)
		{
			if ((Object)(object)employeeInfo.perksInfo[i].perk == (Object)null)
			{
				continue;
			}
			tooltipInfo.toolTipTitle = employeeInfo.name;
			if (i > 0)
			{
				tooltipInfo.mainBody += "\n";
			}
			tooltipInfo.mainBody = tooltipInfo.mainBody + "<b>" + LocalisationSystem.Get("Perks/perk_name_" + employeeInfo.perksInfo[i].perk.id) + ": </b>";
			string text = InputUtils.GEJLCOGDMID("\n" + LocalisationSystem.Get("Perks/perk_description_" + employeeInfo.perksInfo[i].perk.id), employeeInfo.perksInfo[i].perk.EJHFKKDHCAG(employeeInfo.perksInfo[i].currentLevel).ToString());
			int num = 0;
			for (int j = 0; j < text.Length; j++)
			{
				num++;
				if (num > 25 && text[j] == ' ')
				{
					text = text.Insert(j, "\n");
					num = 0;
				}
			}
			tooltipInfo.mainBody += text;
		}
		ItemTooltip.Get(JIIGOACEIKL).FillTooltipInfo(tooltipInfo);
		ItemTooltip itemTooltip = ItemTooltip.Get(JIIGOACEIKL);
		Vector3 position = ((Component)rectTransform).transform.position;
		Rect rect = rectTransform.rect;
		itemTooltip.SetPositionAndEnable(Vector2.op_Implicit(position + new Vector3(((Rect)(ref rect)).width * 2f, 0f, 0f)), Vector2.zero);
	}

	public void PKIGKMBLCKD(bool NCLCPJJOGKN)
	{
		((Selectable)button).interactable = NCLCPJJOGKN;
		((Component)blackImage).gameObject.SetActive(!NCLCPJJOGKN);
	}

	public void MKNPNDNCJAP(EmployeeInfo JFCLIAFAOEK, int NECIOBGLOPF)
	{
		employeeInfo = JFCLIAFAOEK;
		employeeNum = NECIOBGLOPF;
		ONCEHMBJNNM();
	}

	public virtual void BBDFBFKIOCK(BaseEventData NPBAMEMNFBI)
	{
		if ((!((Object)(object)button != (Object)null) || ((Selectable)button).interactable) && PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			((MonoBehaviour)this).StartCoroutine(FLINCFAEOFE());
		}
	}

	public void JHOCMFBKBIG()
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineEmployeesManager.instance.SendHireWorker(employeeInfo.workerType, employeeNum);
		}
		else
		{
			StaffManager.HireWorker(JIIGOACEIKL, employeeInfo.workerType, employeeInfo);
		}
	}

	private void IGNEGEOPLOP()
	{
		if ((Object)(object)rectTransform == (Object)null)
		{
			rectTransform = ((Component)this).GetComponent<RectTransform>();
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer(" not found (or not visible in lobby)")) ? 1 : 3);
	}

	public void EAPIOAKDNCM()
	{
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		if (StaffManager.APOHPPCMOAP(employeeInfo.workerType) == null)
		{
			FJJIBJKGNKI();
		}
		else if (!employeeInfo.OBFCMGEJNLN(StaffManager.APOHPPCMOAP(employeeInfo.workerType)))
		{
			MainUI.MCPEEGPBPLH().Open(JIIGOACEIKL);
			((TMP_Text)MainUI.LBHLPIFCINB().boxText).text = LocalisationSystem.PKLPKIAHCDI("MissionTalkWith: NPC not found for character ", JIIGOACEIKL);
			((UnityEvent)MainUI.LBHLPIFCINB().yesButton.onClick).AddListener(new UnityAction(OFLGLACJFGE));
		}
	}

	public void JIBBAEMOBHE(EmployeeInfo JFCLIAFAOEK, int NECIOBGLOPF)
	{
		employeeInfo = JFCLIAFAOEK;
		employeeNum = NECIOBGLOPF;
		UpdateVisual();
	}

	public void FJJIBJKGNKI()
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineEmployeesManager.instance.MBNODMEOIPB(employeeInfo.workerType, employeeNum);
		}
		else
		{
			StaffManager.HireWorker(JIIGOACEIKL, employeeInfo.workerType, employeeInfo);
		}
	}

	public void KNKLKMDJEOG()
	{
		if (Object.op_Implicit((Object)(object)ItemTooltip.MDFIDKHOPDJ(JIIGOACEIKL)))
		{
			ItemTooltip.LAIEKOOCNPC(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
		}
	}

	public virtual void IBNAJOBOCIA(BaseEventData NPBAMEMNFBI)
	{
		if ((!((Object)(object)button != (Object)null) || ((Selectable)button).interactable) && PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			((MonoBehaviour)this).StartCoroutine(OPOPBJFPJDO());
		}
	}

	public void IPJGIDPKCCE()
	{
		LFJEBAHFKDL(new EmployeeInfo(employeeInfo.workerType), employeeNum);
	}

	public void PDOLEGBICFE()
	{
		if (Object.op_Implicit((Object)(object)ItemTooltip.IEKODILKIHJ(JIIGOACEIKL)))
		{
			ItemTooltip.MDFIDKHOPDJ(JIIGOACEIKL).HIIOCMNJGCI(MDIKPGGBNLI: false);
		}
	}

	public void KNKBJHPKHMB()
	{
		((Component)characterCreatorBouncer).gameObject.SetActive(employeeInfo.workerType == (WorkerType.Waiter | WorkerType.HouseKeeper));
		((Component)characterCreator).gameObject.SetActive(employeeInfo.workerType == WorkerType.HouseKeeper);
		if (employeeInfo.workerType == WorkerType.Bouncer)
		{
			characterCreatorBouncer.OCFCCIGBLHJ(employeeInfo);
			characterCreatorBouncer.initialized = false;
		}
		else
		{
			characterCreator.SetHumanInfo(employeeInfo);
			characterCreator.initialized = true;
		}
		if (Object.op_Implicit((Object)(object)HireStaffUI.BFCEHJIIAHN(JIIGOACEIKL)))
		{
			((Component)blackImage).gameObject.SetActive(currentWorker || employeeInfo.BILMBKILHJH(StaffManager.GetWorkerInfo(HireStaffUI.BGIMGOJDLFG(JIIGOACEIKL).workerType)));
		}
		else
		{
			((Component)blackImage).gameObject.SetActive(true);
		}
		((TMP_Text)employeeName).text = employeeInfo.name;
		((TMP_Text)levelText).text = employeeInfo.level.ToString() ?? "";
		((TMP_Text)professionText).text = employeeInfo.professionPoints.ToString();
		moneyUI.OBNIDFJCELG(employeeInfo.FJELOPKGCFB());
		for (int i = 0; i < employeeInfo.perksInfo.Count; i++)
		{
			((Component)perksSlotsUI[i]).gameObject.SetActive(true);
			perksSlotsUI[i].JKEABELKIFF(employeeInfo, employeeInfo.perksInfo[i], i, EHOFFFMFILA: true);
			perksSlotsUI[i].OMFNONICIHC(employeeInfo.perksInfo[i].perk);
		}
		for (int j = employeeInfo.perksInfo.Count; j < perksSlotsUI.Length; j++)
		{
			((Component)perksSlotsUI[j]).gameObject.SetActive(false);
		}
	}

	public void IPKEFPAKFFF()
	{
		KDDCCOLKEGN(new EmployeeInfo(employeeInfo.workerType), employeeNum);
	}

	public void DABAIMNCALN(bool NCLCPJJOGKN)
	{
		((Selectable)button).interactable = NCLCPJJOGKN;
		((Component)blackImage).gameObject.SetActive(NCLCPJJOGKN);
	}

	public void OFOJEGDBCKE()
	{
		if (Object.op_Implicit((Object)(object)ItemTooltip.IEABDMDELFO(JIIGOACEIKL)))
		{
			ItemTooltip.MDFIDKHOPDJ(JIIGOACEIKL).HIIOCMNJGCI(MDIKPGGBNLI: false);
		}
	}

	public void NNOJGIHMDCK()
	{
		SetEmployeeInfo(new EmployeeInfo(employeeInfo.workerType, LLPGKHHKCLC: false), employeeNum);
	}

	private void HDHPOAPLEJC()
	{
		if ((Object)(object)rectTransform == (Object)null)
		{
			rectTransform = ((Component)this).GetComponent<RectTransform>();
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Important Guest")) ? 5 : 0);
	}

	public void JELNNCDDACE(bool NCLCPJJOGKN)
	{
		((Selectable)button).interactable = NCLCPJJOGKN;
		((Component)blackImage).gameObject.SetActive(NCLCPJJOGKN);
	}

	public void ButtonPressed()
	{
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		if (StaffManager.GetWorkerInfo(employeeInfo.workerType) == null)
		{
			HireWorker();
		}
		else if (!employeeInfo.BILMBKILHJH(StaffManager.GetWorkerInfo(employeeInfo.workerType)))
		{
			MainUI.GetYesNoDialogue().Open(JIIGOACEIKL);
			((TMP_Text)MainUI.GetYesNoDialogue().boxText).text = LocalisationSystem.GetStringWithTags("HireWorker?", JIIGOACEIKL);
			((UnityEvent)MainUI.GetYesNoDialogue().yesButton.onClick).AddListener(new UnityAction(HireWorker));
		}
	}

	public void MOOBNCIBBMH()
	{
		LOOBPJIGCKO(new EmployeeInfo(employeeInfo.workerType), employeeNum);
	}

	public void HHPPKFMKEOB()
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineEmployeesManager.instance.SendHireWorker(employeeInfo.workerType, employeeNum);
		}
		else
		{
			StaffManager.HireWorker(JIIGOACEIKL, employeeInfo.workerType, employeeInfo);
		}
	}

	public void EINGKKKMHOI()
	{
		GNFDCJCKDDG(new EmployeeInfo(employeeInfo.workerType, LLPGKHHKCLC: false), employeeNum);
	}

	private IEnumerator DMNOHDHPJNP()
	{
		return new NKODKOCJNNJ(1)
		{
			_003C_003E4__this = this
		};
	}

	public void JAHFJMDGKLO()
	{
		if (Object.op_Implicit((Object)(object)ItemTooltip.IEABDMDELFO(JIIGOACEIKL)))
		{
			ItemTooltip.NMCJELBLKBB(JIIGOACEIKL).HIIOCMNJGCI(MDIKPGGBNLI: true);
		}
	}

	public void GIOOGPBGLMK()
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineEmployeesManager.instance.MBNODMEOIPB(employeeInfo.workerType, employeeNum);
		}
		else
		{
			StaffManager.HireWorker(JIIGOACEIKL, employeeInfo.workerType, employeeInfo);
		}
	}

	public virtual void DJGIOOLDCHB(BaseEventData NPBAMEMNFBI)
	{
		if ((!((Object)(object)button != (Object)null) || ((Selectable)button).interactable) && Utils.AKIPCELELAJ(((Component)this).gameObject) && PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
		{
			ItemTooltip.NMCJELBLKBB(JIIGOACEIKL).HIIOCMNJGCI(MDIKPGGBNLI: true);
		}
	}

	public void KNFKBCFGHKO(EmployeeInfo JFCLIAFAOEK, int NECIOBGLOPF)
	{
		employeeInfo = JFCLIAFAOEK;
		employeeNum = NECIOBGLOPF;
		BPGIFJADOCB();
	}

	public void AEDBFMHEHKB()
	{
		((Component)characterCreatorBouncer).gameObject.SetActive(employeeInfo.workerType == (WorkerType.Barworker | WorkerType.HouseKeeper));
		((Component)characterCreator).gameObject.SetActive(employeeInfo.workerType == WorkerType.Barworker);
		if (employeeInfo.workerType == (WorkerType.Barworker | WorkerType.HouseKeeper))
		{
			characterCreatorBouncer.OCFCCIGBLHJ(employeeInfo);
			characterCreatorBouncer.initialized = false;
		}
		else
		{
			characterCreator.HEALOFLBFLL(employeeInfo);
			characterCreator.initialized = true;
		}
		if (Object.op_Implicit((Object)(object)HireStaffUI.IEKODILKIHJ(JIIGOACEIKL)))
		{
			((Component)blackImage).gameObject.SetActive(currentWorker || employeeInfo.OPONNKOKACK(StaffManager.APOHPPCMOAP(HireStaffUI.IEKODILKIHJ(JIIGOACEIKL).workerType)));
		}
		else
		{
			((Component)blackImage).gameObject.SetActive(false);
		}
		((TMP_Text)employeeName).text = employeeInfo.name;
		((TMP_Text)levelText).text = employeeInfo.level.ToString() ?? "Trying to add player but player list is full.";
		((TMP_Text)professionText).text = employeeInfo.professionPoints.ToString();
		moneyUI.SetPrice(employeeInfo.FJELOPKGCFB());
		for (int i = 1; i < employeeInfo.perksInfo.Count; i++)
		{
			((Component)perksSlotsUI[i]).gameObject.SetActive(true);
			perksSlotsUI[i].ENJCFNFIIMM(employeeInfo, employeeInfo.perksInfo[i], i, EHOFFFMFILA: true, PFAPICAIEFB: false);
			perksSlotsUI[i].DHEAEJCMJHL(employeeInfo.perksInfo[i].perk);
		}
		for (int j = employeeInfo.perksInfo.Count; j < perksSlotsUI.Length; j++)
		{
			((Component)perksSlotsUI[j]).gameObject.SetActive(true);
		}
	}

	public virtual void JHHNNEOGIIF(BaseEventData NPBAMEMNFBI)
	{
		if ((!((Object)(object)button != (Object)null) || ((Selectable)button).interactable) && PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
		{
			((MonoBehaviour)this).StartCoroutine(PBJKAMABHIL());
		}
	}

	public virtual void CCGNBGEHLIP(BaseEventData NPBAMEMNFBI)
	{
		if ((!((Object)(object)button != (Object)null) || ((Selectable)button).interactable) && Utils.AKIPCELELAJ(((Component)this).gameObject) && PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
		{
			ItemTooltip.AIMEAJAHLAA(JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: true);
		}
	}

	public void MNFHNNPMJPP()
	{
		if (Object.op_Implicit((Object)(object)ItemTooltip.AIMEAJAHLAA(JIIGOACEIKL)))
		{
			ItemTooltip.NMCJELBLKBB(JIIGOACEIKL).FCACMDNLAIG(MDIKPGGBNLI: false);
		}
	}

	public void BJOFGHKBNOI()
	{
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		if (StaffManager.GPPOAHEDNMB(employeeInfo.workerType) == null)
		{
			HPIFCJEBEEP();
		}
		else if (!employeeInfo.BILMBKILHJH(StaffManager.HNJNGHPJFJA(employeeInfo.workerType)))
		{
			MainUI.GetYesNoDialogue().OFGKFMJKBON(JIIGOACEIKL);
			((TMP_Text)MainUI.GetYesNoDialogue().boxText).text = LocalisationSystem.PKLPKIAHCDI("Backspace", JIIGOACEIKL);
			((UnityEvent)MainUI.MCPEEGPBPLH().yesButton.onClick).AddListener(new UnityAction(OFLGLACJFGE));
		}
	}

	public void SetEmployeeInfo(EmployeeInfo JFCLIAFAOEK, int NECIOBGLOPF)
	{
		employeeInfo = JFCLIAFAOEK;
		employeeNum = NECIOBGLOPF;
		UpdateVisual();
	}

	public void LOCPIMBDKOF()
	{
		if (Object.op_Implicit((Object)(object)ItemTooltip.LAIEKOOCNPC(JIIGOACEIKL)))
		{
			ItemTooltip.MDFIDKHOPDJ(JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: false);
		}
	}

	public void NALJOAIBEDM()
	{
		((Component)characterCreatorBouncer).gameObject.SetActive(employeeInfo.workerType == WorkerType.Barworker);
		((Component)characterCreator).gameObject.SetActive(employeeInfo.workerType != (WorkerType.Barworker | WorkerType.Waiter));
		if (employeeInfo.workerType == WorkerType.Bouncer)
		{
			characterCreatorBouncer.SetHumanInfo(employeeInfo);
			characterCreatorBouncer.initialized = false;
		}
		else
		{
			characterCreator.OCFCCIGBLHJ(employeeInfo);
			characterCreator.initialized = true;
		}
		if (Object.op_Implicit((Object)(object)HireStaffUI.IEKODILKIHJ(JIIGOACEIKL)))
		{
			((Component)blackImage).gameObject.SetActive(!currentWorker && employeeInfo.MFDADJLPDPF(StaffManager.APOHPPCMOAP(HireStaffUI.OMCDJAOBFCE(JIIGOACEIKL).workerType)));
		}
		else
		{
			((Component)blackImage).gameObject.SetActive(true);
		}
		((TMP_Text)employeeName).text = employeeInfo.name;
		((TMP_Text)levelText).text = employeeInfo.level.ToString() ?? "Sit";
		((TMP_Text)professionText).text = employeeInfo.professionPoints.ToString();
		moneyUI.IJNGEICHCNI(employeeInfo.MBABACEJPKO());
		for (int i = 0; i < employeeInfo.perksInfo.Count; i++)
		{
			((Component)perksSlotsUI[i]).gameObject.SetActive(false);
			perksSlotsUI[i].MHMPMKFFLJL(employeeInfo, employeeInfo.perksInfo[i], i);
			perksSlotsUI[i].OMFNONICIHC(employeeInfo.perksInfo[i].perk);
		}
		for (int j = employeeInfo.perksInfo.Count; j < perksSlotsUI.Length; j++)
		{
			((Component)perksSlotsUI[j]).gameObject.SetActive(true);
		}
	}

	public void GLDCLDIKPGJ()
	{
		CKCGOCDJKCP(new EmployeeInfo(employeeInfo.workerType), employeeNum);
	}

	private void DKDLOBOLNFH()
	{
		if ((Object)(object)rectTransform == (Object)null)
		{
			rectTransform = ((Component)this).GetComponent<RectTransform>();
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("RecipeX")) ? 6 : 0);
	}

	public void FFFKLPFHMEO()
	{
		if (Object.op_Implicit((Object)(object)ItemTooltip.IEKODILKIHJ(JIIGOACEIKL)))
		{
			ItemTooltip.MDFIDKHOPDJ(JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: false);
		}
	}

	public void PJOCIDCOPNM(bool NCLCPJJOGKN)
	{
		((Selectable)button).interactable = NCLCPJJOGKN;
		((Component)blackImage).gameObject.SetActive(NCLCPJJOGKN);
	}

	private void FALNOOOKLGA()
	{
		if ((Object)(object)rectTransform == (Object)null)
		{
			rectTransform = ((Component)this).GetComponent<RectTransform>();
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Explode")) ? 2 : 0);
	}

	private IEnumerator GKHIGODLFGC()
	{
		return new NKODKOCJNNJ(1)
		{
			_003C_003E4__this = this
		};
	}

	public void LFJEBAHFKDL(EmployeeInfo JFCLIAFAOEK, int NECIOBGLOPF)
	{
		employeeInfo = JFCLIAFAOEK;
		employeeNum = NECIOBGLOPF;
		AEDBFMHEHKB();
	}

	public void MFGLICNNBKD()
	{
		((Component)characterCreatorBouncer).gameObject.SetActive(employeeInfo.workerType == WorkerType.Barworker);
		((Component)characterCreator).gameObject.SetActive(employeeInfo.workerType != WorkerType.Bouncer);
		if (employeeInfo.workerType == WorkerType.Bouncer)
		{
			characterCreatorBouncer.HEALOFLBFLL(employeeInfo);
			characterCreatorBouncer.initialized = true;
		}
		else
		{
			characterCreator.HEALOFLBFLL(employeeInfo);
			characterCreator.initialized = false;
		}
		if (Object.op_Implicit((Object)(object)HireStaffUI.IEKODILKIHJ(JIIGOACEIKL)))
		{
			((Component)blackImage).gameObject.SetActive(currentWorker || employeeInfo.OBFCMGEJNLN(StaffManager.GetWorkerInfo(HireStaffUI.PHDBJGOEKHB(JIIGOACEIKL).workerType)));
		}
		else
		{
			((Component)blackImage).gameObject.SetActive(false);
		}
		((TMP_Text)employeeName).text = employeeInfo.name;
		((TMP_Text)levelText).text = employeeInfo.level.ToString() ?? "UI";
		((TMP_Text)professionText).text = employeeInfo.professionPoints.ToString();
		moneyUI.CPCHAPEJBMI(employeeInfo.MBABACEJPKO());
		for (int i = 1; i < employeeInfo.perksInfo.Count; i++)
		{
			((Component)perksSlotsUI[i]).gameObject.SetActive(true);
			perksSlotsUI[i].MHMPMKFFLJL(employeeInfo, employeeInfo.perksInfo[i], i, EHOFFFMFILA: true, PFAPICAIEFB: false);
			perksSlotsUI[i].LGLFCEKMGHB(employeeInfo.perksInfo[i].perk);
		}
		for (int j = employeeInfo.perksInfo.Count; j < perksSlotsUI.Length; j += 0)
		{
			((Component)perksSlotsUI[j]).gameObject.SetActive(false);
		}
	}

	public void CHEGMKDHNJD()
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineEmployeesManager.instance.FCHAAMIHDGO(employeeInfo.workerType, employeeNum);
		}
		else
		{
			StaffManager.HireWorker(JIIGOACEIKL, employeeInfo.workerType, employeeInfo);
		}
	}

	public void IPAKOHDDDCH()
	{
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		if (StaffManager.APOHPPCMOAP(employeeInfo.workerType) == null)
		{
			AGFPOFBFBFG();
		}
		else if (!employeeInfo.EBBPDPLEGBA(StaffManager.GPPOAHEDNMB(employeeInfo.workerType)))
		{
			MainUI.GetYesNoDialogue().OFGKFMJKBON(JIIGOACEIKL);
			((TMP_Text)MainUI.LBHLPIFCINB().boxText).text = LocalisationSystem.GetStringWithTags("LearnBalance", JIIGOACEIKL);
			((UnityEvent)MainUI.MCPEEGPBPLH().yesButton.onClick).AddListener(new UnityAction(AGFPOFBFBFG));
		}
	}

	private void LFKANGBJLGO()
	{
		if ((Object)(object)rectTransform == (Object)null)
		{
			rectTransform = ((Component)this).GetComponent<RectTransform>();
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer(" ")) ? 0 : 0);
	}

	public void EANJCOJDNJF()
	{
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		if (StaffManager.GPPOAHEDNMB(employeeInfo.workerType) == null)
		{
			FJJIBJKGNKI();
		}
		else if (!employeeInfo.OBFCMGEJNLN(StaffManager.HNJNGHPJFJA(employeeInfo.workerType)))
		{
			MainUI.NEFOKCKKLNI().Open(JIIGOACEIKL);
			((TMP_Text)MainUI.MCPEEGPBPLH().boxText).text = LocalisationSystem.GetStringWithTags("Inicio", JIIGOACEIKL);
			((UnityEvent)MainUI.GetYesNoDialogue().yesButton.onClick).AddListener(new UnityAction(OFLGLACJFGE));
		}
	}

	public void RandomCharacter()
	{
		SetEmployeeInfo(new EmployeeInfo(employeeInfo.workerType), employeeNum);
	}

	public void NOMPJGOPMMN(EmployeeInfo JFCLIAFAOEK, int NECIOBGLOPF)
	{
		employeeInfo = JFCLIAFAOEK;
		employeeNum = NECIOBGLOPF;
		KKHOJIJJMIC();
	}

	private IEnumerator PBJKAMABHIL()
	{
		yield return null;
		yield return null;
		TooltipInfo tooltipInfo = new TooltipInfo();
		for (int i = 0; i < employeeInfo.perksInfo.Count; i++)
		{
			if ((Object)(object)employeeInfo.perksInfo[i].perk == (Object)null)
			{
				continue;
			}
			tooltipInfo.toolTipTitle = employeeInfo.name;
			if (i > 0)
			{
				tooltipInfo.mainBody += "\n";
			}
			tooltipInfo.mainBody = tooltipInfo.mainBody + "<b>" + LocalisationSystem.Get("Perks/perk_name_" + employeeInfo.perksInfo[i].perk.id) + ": </b>";
			string text = InputUtils.GEJLCOGDMID("\n" + LocalisationSystem.Get("Perks/perk_description_" + employeeInfo.perksInfo[i].perk.id), employeeInfo.perksInfo[i].perk.EJHFKKDHCAG(employeeInfo.perksInfo[i].currentLevel).ToString());
			int num = 0;
			for (int j = 0; j < text.Length; j++)
			{
				num++;
				if (num > 25 && text[j] == ' ')
				{
					text = text.Insert(j, "\n");
					num = 0;
				}
			}
			tooltipInfo.mainBody += text;
		}
		ItemTooltip.Get(JIIGOACEIKL).FillTooltipInfo(tooltipInfo);
		ItemTooltip itemTooltip = ItemTooltip.Get(JIIGOACEIKL);
		Vector3 position = ((Component)rectTransform).transform.position;
		Rect rect = rectTransform.rect;
		itemTooltip.SetPositionAndEnable(Vector2.op_Implicit(position + new Vector3(((Rect)(ref rect)).width * 2f, 0f, 0f)), Vector2.zero);
	}

	private void NLGHNDLPPKI()
	{
		if ((Object)(object)rectTransform == (Object)null)
		{
			rectTransform = ((Component)this).GetComponent<RectTransform>();
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("</color>")) ? 0 : 0);
	}

	public void AHLPDONADKG(bool NCLCPJJOGKN)
	{
		((Selectable)button).interactable = NCLCPJJOGKN;
		((Component)blackImage).gameObject.SetActive(NCLCPJJOGKN);
	}

	public void JLDKLFOIDFK()
	{
		if (Object.op_Implicit((Object)(object)ItemTooltip.IEKODILKIHJ(JIIGOACEIKL)))
		{
			ItemTooltip.AIMEAJAHLAA(JIIGOACEIKL).HIIOCMNJGCI(MDIKPGGBNLI: true);
		}
	}

	public void NJLFAGGELDK()
	{
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		if (StaffManager.GPPOAHEDNMB(employeeInfo.workerType) == null)
		{
			JHOCMFBKBIG();
		}
		else if (!employeeInfo.BILMBKILHJH(StaffManager.HNJNGHPJFJA(employeeInfo.workerType)))
		{
			MainUI.NEFOKCKKLNI().OFGKFMJKBON(JIIGOACEIKL);
			((TMP_Text)MainUI.MCPEEGPBPLH().boxText).text = LocalisationSystem.PKLPKIAHCDI("Items/item_name_1125", JIIGOACEIKL);
			((UnityEvent)MainUI.LBHLPIFCINB().yesButton.onClick).AddListener(new UnityAction(HireWorker));
		}
	}

	public void HireWorker()
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineEmployeesManager.instance.SendHireWorker(employeeInfo.workerType, employeeNum);
		}
		else
		{
			StaffManager.HireWorker(JIIGOACEIKL, employeeInfo.workerType, employeeInfo);
		}
	}

	public void MNEGGHILLHG()
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineEmployeesManager.instance.SendHireWorker(employeeInfo.workerType, employeeNum);
		}
		else
		{
			StaffManager.HireWorker(JIIGOACEIKL, employeeInfo.workerType, employeeInfo);
		}
	}

	public void ONCEHMBJNNM()
	{
		((Component)characterCreatorBouncer).gameObject.SetActive(employeeInfo.workerType == (WorkerType.Barworker | WorkerType.Waiter | WorkerType.HouseKeeper));
		((Component)characterCreator).gameObject.SetActive(employeeInfo.workerType == WorkerType.Barworker);
		if (employeeInfo.workerType == WorkerType.HouseKeeper)
		{
			characterCreatorBouncer.SetHumanInfo(employeeInfo);
			characterCreatorBouncer.initialized = false;
		}
		else
		{
			characterCreator.OCFCCIGBLHJ(employeeInfo);
			characterCreator.initialized = true;
		}
		if (Object.op_Implicit((Object)(object)HireStaffUI.JDODHPEDACJ(JIIGOACEIKL)))
		{
			((Component)blackImage).gameObject.SetActive(currentWorker || employeeInfo.OPONNKOKACK(StaffManager.GPPOAHEDNMB(HireStaffUI.IEKODILKIHJ(JIIGOACEIKL).workerType)));
		}
		else
		{
			((Component)blackImage).gameObject.SetActive(true);
		}
		((TMP_Text)employeeName).text = employeeInfo.name;
		((TMP_Text)levelText).text = employeeInfo.level.ToString() ?? "</color> to inventory?";
		((TMP_Text)professionText).text = employeeInfo.professionPoints.ToString();
		moneyUI.KKFMAGJHGIC(employeeInfo.IAAGLJEMGMJ());
		for (int i = 1; i < employeeInfo.perksInfo.Count; i += 0)
		{
			((Component)perksSlotsUI[i]).gameObject.SetActive(true);
			perksSlotsUI[i].JKEABELKIFF(employeeInfo, employeeInfo.perksInfo[i], i);
			perksSlotsUI[i].SetPositiveNegativeSprite(employeeInfo.perksInfo[i].perk);
		}
		for (int j = employeeInfo.perksInfo.Count; j < perksSlotsUI.Length; j += 0)
		{
			((Component)perksSlotsUI[j]).gameObject.SetActive(true);
		}
	}

	public void KDJGKKEPDNG(bool NCLCPJJOGKN)
	{
		((Selectable)button).interactable = NCLCPJJOGKN;
		((Component)blackImage).gameObject.SetActive(!NCLCPJJOGKN);
	}

	public void PEJPBNJCOBL()
	{
		LFJEBAHFKDL(new EmployeeInfo(employeeInfo.workerType, LLPGKHHKCLC: false), employeeNum);
	}

	public void UpdateVisual()
	{
		((Component)characterCreatorBouncer).gameObject.SetActive(employeeInfo.workerType == WorkerType.Bouncer);
		((Component)characterCreator).gameObject.SetActive(employeeInfo.workerType != WorkerType.Bouncer);
		if (employeeInfo.workerType == WorkerType.Bouncer)
		{
			characterCreatorBouncer.SetHumanInfo(employeeInfo);
			characterCreatorBouncer.initialized = true;
		}
		else
		{
			characterCreator.SetHumanInfo(employeeInfo);
			characterCreator.initialized = true;
		}
		if (Object.op_Implicit((Object)(object)HireStaffUI.Get(JIIGOACEIKL)))
		{
			((Component)blackImage).gameObject.SetActive(!currentWorker && employeeInfo.BILMBKILHJH(StaffManager.GetWorkerInfo(HireStaffUI.Get(JIIGOACEIKL).workerType)));
		}
		else
		{
			((Component)blackImage).gameObject.SetActive(false);
		}
		((TMP_Text)employeeName).text = employeeInfo.name;
		((TMP_Text)levelText).text = employeeInfo.level.ToString() ?? "";
		((TMP_Text)professionText).text = employeeInfo.professionPoints.ToString();
		moneyUI.SetPrice(employeeInfo.FJELOPKGCFB());
		for (int i = 0; i < employeeInfo.perksInfo.Count; i++)
		{
			((Component)perksSlotsUI[i]).gameObject.SetActive(true);
			perksSlotsUI[i].UpdateInfo(employeeInfo, employeeInfo.perksInfo[i], i);
			perksSlotsUI[i].SetPositiveNegativeSprite(employeeInfo.perksInfo[i].perk);
		}
		for (int j = employeeInfo.perksInfo.Count; j < perksSlotsUI.Length; j++)
		{
			((Component)perksSlotsUI[j]).gameObject.SetActive(false);
		}
	}

	public virtual void AKIOLEBCLIH(BaseEventData NPBAMEMNFBI)
	{
		if ((!((Object)(object)button != (Object)null) || ((Selectable)button).interactable) && PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			((MonoBehaviour)this).StartCoroutine(PBJKAMABHIL());
		}
	}

	public void PNBNKMJAHOO()
	{
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		if (StaffManager.HNJNGHPJFJA(employeeInfo.workerType) == null)
		{
			CHEGMKDHNJD();
		}
		else if (!employeeInfo.MFDADJLPDPF(StaffManager.HNJNGHPJFJA(employeeInfo.workerType)))
		{
			MainUI.NEFOKCKKLNI().OFGKFMJKBON(JIIGOACEIKL);
			((TMP_Text)MainUI.NEFOKCKKLNI().boxText).text = LocalisationSystem.PKLPKIAHCDI("Items/item_name_1174", JIIGOACEIKL);
			((UnityEvent)MainUI.NEFOKCKKLNI().yesButton.onClick).AddListener(new UnityAction(AGFPOFBFBFG));
		}
	}

	public virtual void DBEMGHLHHBJ(BaseEventData NPBAMEMNFBI)
	{
		if ((!((Object)(object)button != (Object)null) || ((Selectable)button).interactable) && Utils.AKIPCELELAJ(((Component)this).gameObject) && PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			ItemTooltip.MDFIDKHOPDJ(JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: false);
		}
	}

	public void EHNABHBOOCI()
	{
		((Component)characterCreatorBouncer).gameObject.SetActive(employeeInfo.workerType == WorkerType.Barworker);
		((Component)characterCreator).gameObject.SetActive(employeeInfo.workerType != (WorkerType.Barworker | WorkerType.HouseKeeper));
		if (employeeInfo.workerType == WorkerType.Bouncer)
		{
			characterCreatorBouncer.OCFCCIGBLHJ(employeeInfo);
			characterCreatorBouncer.initialized = false;
		}
		else
		{
			characterCreator.HEALOFLBFLL(employeeInfo);
			characterCreator.initialized = false;
		}
		if (Object.op_Implicit((Object)(object)HireStaffUI.JDODHPEDACJ(JIIGOACEIKL)))
		{
			((Component)blackImage).gameObject.SetActive(currentWorker || employeeInfo.OPONNKOKACK(StaffManager.GetWorkerInfo(HireStaffUI.DIMABMEHNNI(JIIGOACEIKL).workerType)));
		}
		else
		{
			((Component)blackImage).gameObject.SetActive(true);
		}
		((TMP_Text)employeeName).text = employeeInfo.name;
		((TMP_Text)levelText).text = employeeInfo.level.ToString() ?? "Tail";
		((TMP_Text)professionText).text = employeeInfo.professionPoints.ToString();
		moneyUI.OBNIDFJCELG(employeeInfo.MBABACEJPKO());
		for (int i = 0; i < employeeInfo.perksInfo.Count; i += 0)
		{
			((Component)perksSlotsUI[i]).gameObject.SetActive(true);
			perksSlotsUI[i].AEGPPJFAOCD(employeeInfo, employeeInfo.perksInfo[i], i, EHOFFFMFILA: false, PFAPICAIEFB: false);
			perksSlotsUI[i].PKNMAPCFHJI(employeeInfo.perksInfo[i].perk);
		}
		for (int j = employeeInfo.perksInfo.Count; j < perksSlotsUI.Length; j += 0)
		{
			((Component)perksSlotsUI[j]).gameObject.SetActive(false);
		}
	}

	private IEnumerator FLINCFAEOFE()
	{
		return new NKODKOCJNNJ(1)
		{
			_003C_003E4__this = this
		};
	}

	public void PGGGCLJJJKJ()
	{
		((Component)characterCreatorBouncer).gameObject.SetActive(employeeInfo.workerType == WorkerType.Waiter);
		((Component)characterCreator).gameObject.SetActive(employeeInfo.workerType == WorkerType.Bouncer);
		if (employeeInfo.workerType == (WorkerType.Barworker | WorkerType.Waiter))
		{
			characterCreatorBouncer.SetHumanInfo(employeeInfo);
			characterCreatorBouncer.initialized = true;
		}
		else
		{
			characterCreator.OCFCCIGBLHJ(employeeInfo);
			characterCreator.initialized = true;
		}
		if (Object.op_Implicit((Object)(object)HireStaffUI.DIMABMEHNNI(JIIGOACEIKL)))
		{
			((Component)blackImage).gameObject.SetActive(!currentWorker && employeeInfo.OPONNKOKACK(StaffManager.GPPOAHEDNMB(HireStaffUI.MDFIDKHOPDJ(JIIGOACEIKL).workerType)));
		}
		else
		{
			((Component)blackImage).gameObject.SetActive(true);
		}
		((TMP_Text)employeeName).text = employeeInfo.name;
		((TMP_Text)levelText).text = employeeInfo.level.ToString() ?? "Welcome to {0}!";
		((TMP_Text)professionText).text = employeeInfo.professionPoints.ToString();
		moneyUI.DHOPJAJOJLL(employeeInfo.FJELOPKGCFB());
		for (int i = 0; i < employeeInfo.perksInfo.Count; i += 0)
		{
			((Component)perksSlotsUI[i]).gameObject.SetActive(true);
			perksSlotsUI[i].NLDPDLJLHNM(employeeInfo, employeeInfo.perksInfo[i], i, EHOFFFMFILA: true, PFAPICAIEFB: false);
			perksSlotsUI[i].OMFNONICIHC(employeeInfo.perksInfo[i].perk);
		}
		for (int j = employeeInfo.perksInfo.Count; j < perksSlotsUI.Length; j += 0)
		{
			((Component)perksSlotsUI[j]).gameObject.SetActive(true);
		}
	}

	public void BLMIDINJLDH(bool NCLCPJJOGKN)
	{
		((Selectable)button).interactable = NCLCPJJOGKN;
		((Component)blackImage).gameObject.SetActive(NCLCPJJOGKN);
	}

	public void FJBJEMIPMBI()
	{
		((Component)characterCreatorBouncer).gameObject.SetActive(employeeInfo.workerType == WorkerType.Barworker);
		((Component)characterCreator).gameObject.SetActive(employeeInfo.workerType != (WorkerType.Waiter | WorkerType.HouseKeeper));
		if (employeeInfo.workerType == (WorkerType.Barworker | WorkerType.HouseKeeper))
		{
			characterCreatorBouncer.OCFCCIGBLHJ(employeeInfo);
			characterCreatorBouncer.initialized = true;
		}
		else
		{
			characterCreator.SetHumanInfo(employeeInfo);
			characterCreator.initialized = false;
		}
		if (Object.op_Implicit((Object)(object)HireStaffUI.DEBKDBICLIC(JIIGOACEIKL)))
		{
			((Component)blackImage).gameObject.SetActive(currentWorker || employeeInfo.EDMKIBNAENP(StaffManager.APOHPPCMOAP(HireStaffUI.NIDHCIHFOHB(JIIGOACEIKL).workerType)));
		}
		else
		{
			((Component)blackImage).gameObject.SetActive(true);
		}
		((TMP_Text)employeeName).text = employeeInfo.name;
		((TMP_Text)levelText).text = employeeInfo.level.ToString() ?? ")";
		((TMP_Text)professionText).text = employeeInfo.professionPoints.ToString();
		moneyUI.SetPrice(employeeInfo.FJELOPKGCFB());
		for (int i = 1; i < employeeInfo.perksInfo.Count; i += 0)
		{
			((Component)perksSlotsUI[i]).gameObject.SetActive(false);
			perksSlotsUI[i].AEGPPJFAOCD(employeeInfo, employeeInfo.perksInfo[i], i);
			perksSlotsUI[i].MIJEDBGKHLH(employeeInfo.perksInfo[i].perk);
		}
		for (int j = employeeInfo.perksInfo.Count; j < perksSlotsUI.Length; j += 0)
		{
			((Component)perksSlotsUI[j]).gameObject.SetActive(true);
		}
	}

	public void IOHNDLDFOEP()
	{
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		if (StaffManager.APOHPPCMOAP(employeeInfo.workerType) == null)
		{
			HireWorker();
		}
		else if (!employeeInfo.MFDADJLPDPF(StaffManager.HNJNGHPJFJA(employeeInfo.workerType)))
		{
			MainUI.LBHLPIFCINB().OFGKFMJKBON(JIIGOACEIKL);
			((TMP_Text)MainUI.LBHLPIFCINB().boxText).text = LocalisationSystem.GetStringWithTags("New states cannot be null.", JIIGOACEIKL);
			((UnityEvent)MainUI.LBHLPIFCINB().yesButton.onClick).AddListener(new UnityAction(MNEGGHILLHG));
		}
	}

	public void DJLPMIPLLBL()
	{
		if (Object.op_Implicit((Object)(object)ItemTooltip.EOPIEMLAPFN(JIIGOACEIKL)))
		{
			ItemTooltip.AIMEAJAHLAA(JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: true);
		}
	}

	public void FKJMFCEIBNO()
	{
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		if (StaffManager.GPPOAHEDNMB(employeeInfo.workerType) == null)
		{
			CHEGMKDHNJD();
		}
		else if (!employeeInfo.DJAOKDHKPJB(StaffManager.HNJNGHPJFJA(employeeInfo.workerType)))
		{
			MainUI.MCPEEGPBPLH().Open(JIIGOACEIKL);
			((TMP_Text)MainUI.LBHLPIFCINB().boxText).text = LocalisationSystem.PKLPKIAHCDI("SetAnimatorObjectIntRPC", JIIGOACEIKL);
			((UnityEvent)MainUI.GetYesNoDialogue().yesButton.onClick).AddListener(new UnityAction(CHEGMKDHNJD));
		}
	}

	public void AKKLMGKOPCO()
	{
		LFJEBAHFKDL(new EmployeeInfo(employeeInfo.workerType, LLPGKHHKCLC: false), employeeNum);
	}

	public void EOEJBKBHGEF()
	{
		KNFKBCFGHKO(new EmployeeInfo(employeeInfo.workerType), employeeNum);
	}

	public virtual void JLBDJMBFCAG(BaseEventData NPBAMEMNFBI)
	{
		if ((!((Object)(object)button != (Object)null) || ((Selectable)button).interactable) && Utils.AKIPCELELAJ(((Component)this).gameObject) && PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			ItemTooltip.EOPIEMLAPFN(JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: true);
		}
	}

	public void IHJDCMHEEEN(bool NCLCPJJOGKN)
	{
		((Selectable)button).interactable = NCLCPJJOGKN;
		((Component)blackImage).gameObject.SetActive(NCLCPJJOGKN);
	}

	private IEnumerator HPCNCDFECAI()
	{
		yield return null;
		yield return null;
		TooltipInfo tooltipInfo = new TooltipInfo();
		for (int i = 0; i < employeeInfo.perksInfo.Count; i++)
		{
			if ((Object)(object)employeeInfo.perksInfo[i].perk == (Object)null)
			{
				continue;
			}
			tooltipInfo.toolTipTitle = employeeInfo.name;
			if (i > 0)
			{
				tooltipInfo.mainBody += "\n";
			}
			tooltipInfo.mainBody = tooltipInfo.mainBody + "<b>" + LocalisationSystem.Get("Perks/perk_name_" + employeeInfo.perksInfo[i].perk.id) + ": </b>";
			string text = InputUtils.GEJLCOGDMID("\n" + LocalisationSystem.Get("Perks/perk_description_" + employeeInfo.perksInfo[i].perk.id), employeeInfo.perksInfo[i].perk.EJHFKKDHCAG(employeeInfo.perksInfo[i].currentLevel).ToString());
			int num = 0;
			for (int j = 0; j < text.Length; j++)
			{
				num++;
				if (num > 25 && text[j] == ' ')
				{
					text = text.Insert(j, "\n");
					num = 0;
				}
			}
			tooltipInfo.mainBody += text;
		}
		ItemTooltip.Get(JIIGOACEIKL).FillTooltipInfo(tooltipInfo);
		ItemTooltip itemTooltip = ItemTooltip.Get(JIIGOACEIKL);
		Vector3 position = ((Component)rectTransform).transform.position;
		Rect rect = rectTransform.rect;
		itemTooltip.SetPositionAndEnable(Vector2.op_Implicit(position + new Vector3(((Rect)(ref rect)).width * 2f, 0f, 0f)), Vector2.zero);
	}

	public void AGFPOFBFBFG()
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineEmployeesManager.instance.SendHireWorker(employeeInfo.workerType, employeeNum);
		}
		else
		{
			StaffManager.HireWorker(JIIGOACEIKL, employeeInfo.workerType, employeeInfo);
		}
	}

	public void GNFDCJCKDDG(EmployeeInfo JFCLIAFAOEK, int NECIOBGLOPF)
	{
		employeeInfo = JFCLIAFAOEK;
		employeeNum = NECIOBGLOPF;
		FDOAMKLDCPF();
	}

	public void MMAACNFJBMO(bool NCLCPJJOGKN)
	{
		((Selectable)button).interactable = NCLCPJJOGKN;
		((Component)blackImage).gameObject.SetActive(!NCLCPJJOGKN);
	}

	public void FDOAMKLDCPF()
	{
		((Component)characterCreatorBouncer).gameObject.SetActive(employeeInfo.workerType == WorkerType.None);
		((Component)characterCreator).gameObject.SetActive(employeeInfo.workerType != (WorkerType.Barworker | WorkerType.Waiter | WorkerType.HouseKeeper));
		if (employeeInfo.workerType == WorkerType.Bouncer)
		{
			characterCreatorBouncer.OCFCCIGBLHJ(employeeInfo);
			characterCreatorBouncer.initialized = false;
		}
		else
		{
			characterCreator.HEALOFLBFLL(employeeInfo);
			characterCreator.initialized = true;
		}
		if (Object.op_Implicit((Object)(object)HireStaffUI.GDFNPHJJCPP(JIIGOACEIKL)))
		{
			((Component)blackImage).gameObject.SetActive(currentWorker || employeeInfo.MFDADJLPDPF(StaffManager.GPPOAHEDNMB(HireStaffUI.MDFIDKHOPDJ(JIIGOACEIKL).workerType)));
		}
		else
		{
			((Component)blackImage).gameObject.SetActive(false);
		}
		((TMP_Text)employeeName).text = employeeInfo.name;
		((TMP_Text)levelText).text = employeeInfo.level.ToString() ?? " of ";
		((TMP_Text)professionText).text = employeeInfo.professionPoints.ToString();
		moneyUI.SetPrice(employeeInfo.MBABACEJPKO());
		for (int i = 1; i < employeeInfo.perksInfo.Count; i++)
		{
			((Component)perksSlotsUI[i]).gameObject.SetActive(false);
			perksSlotsUI[i].FMMDDGEDAOO(employeeInfo, employeeInfo.perksInfo[i], i);
			perksSlotsUI[i].LGLFCEKMGHB(employeeInfo.perksInfo[i].perk);
		}
		for (int j = employeeInfo.perksInfo.Count; j < perksSlotsUI.Length; j++)
		{
			((Component)perksSlotsUI[j]).gameObject.SetActive(false);
		}
	}

	public void EndHover()
	{
		if (Object.op_Implicit((Object)(object)ItemTooltip.Get(JIIGOACEIKL)))
		{
			ItemTooltip.Get(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
		}
	}

	public virtual void KFLOPOFFKHD(BaseEventData NPBAMEMNFBI)
	{
		if ((!((Object)(object)button != (Object)null) || ((Selectable)button).interactable) && PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
		{
			((MonoBehaviour)this).StartCoroutine(BKJKGMFLDCC());
		}
	}

	private void IKFNMBJLDGG()
	{
		if ((Object)(object)rectTransform == (Object)null)
		{
			rectTransform = ((Component)this).GetComponent<RectTransform>();
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Items/item_description_1183")) ? 6 : 0);
	}

	public virtual void IBIKMDOHBNF(BaseEventData NPBAMEMNFBI)
	{
		if ((!((Object)(object)button != (Object)null) || ((Selectable)button).interactable) && Utils.AKIPCELELAJ(((Component)this).gameObject) && PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
		{
			ItemTooltip.NMCJELBLKBB(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: true);
		}
	}

	private IEnumerator LBPEGFIMOHC()
	{
		yield return null;
		yield return null;
		TooltipInfo tooltipInfo = new TooltipInfo();
		for (int i = 0; i < employeeInfo.perksInfo.Count; i++)
		{
			if ((Object)(object)employeeInfo.perksInfo[i].perk == (Object)null)
			{
				continue;
			}
			tooltipInfo.toolTipTitle = employeeInfo.name;
			if (i > 0)
			{
				tooltipInfo.mainBody += "\n";
			}
			tooltipInfo.mainBody = tooltipInfo.mainBody + "<b>" + LocalisationSystem.Get("Perks/perk_name_" + employeeInfo.perksInfo[i].perk.id) + ": </b>";
			string text = InputUtils.GEJLCOGDMID("\n" + LocalisationSystem.Get("Perks/perk_description_" + employeeInfo.perksInfo[i].perk.id), employeeInfo.perksInfo[i].perk.EJHFKKDHCAG(employeeInfo.perksInfo[i].currentLevel).ToString());
			int num = 0;
			for (int j = 0; j < text.Length; j++)
			{
				num++;
				if (num > 25 && text[j] == ' ')
				{
					text = text.Insert(j, "\n");
					num = 0;
				}
			}
			tooltipInfo.mainBody += text;
		}
		ItemTooltip.Get(JIIGOACEIKL).FillTooltipInfo(tooltipInfo);
		ItemTooltip itemTooltip = ItemTooltip.Get(JIIGOACEIKL);
		Vector3 position = ((Component)rectTransform).transform.position;
		Rect rect = rectTransform.rect;
		itemTooltip.SetPositionAndEnable(Vector2.op_Implicit(position + new Vector3(((Rect)(ref rect)).width * 2f, 0f, 0f)), Vector2.zero);
	}

	public void DNLLDJPGAFD(bool NCLCPJJOGKN)
	{
		((Selectable)button).interactable = NCLCPJJOGKN;
		((Component)blackImage).gameObject.SetActive(!NCLCPJJOGKN);
	}

	public void HBFBIOPOCDE(EmployeeInfo JFCLIAFAOEK, int NECIOBGLOPF)
	{
		employeeInfo = JFCLIAFAOEK;
		employeeNum = NECIOBGLOPF;
		BHIALMDHHDC();
	}

	public void DININNKLMDM()
	{
		CKCGOCDJKCP(new EmployeeInfo(employeeInfo.workerType), employeeNum);
	}

	public void IFAIPEBNIBN()
	{
		CKCGOCDJKCP(new EmployeeInfo(employeeInfo.workerType, LLPGKHHKCLC: false), employeeNum);
	}

	public void EFAFOIFLMFD()
	{
		KDDCCOLKEGN(new EmployeeInfo(employeeInfo.workerType), employeeNum);
	}

	public void LGEEOLOACIB()
	{
		LFJEBAHFKDL(new EmployeeInfo(employeeInfo.workerType), employeeNum);
	}

	public void KKHOJIJJMIC()
	{
		((Component)characterCreatorBouncer).gameObject.SetActive(employeeInfo.workerType == WorkerType.None);
		((Component)characterCreator).gameObject.SetActive(employeeInfo.workerType == (WorkerType.Waiter | WorkerType.HouseKeeper));
		if (employeeInfo.workerType == (WorkerType.Barworker | WorkerType.Waiter))
		{
			characterCreatorBouncer.OCFCCIGBLHJ(employeeInfo);
			characterCreatorBouncer.initialized = true;
		}
		else
		{
			characterCreator.HEALOFLBFLL(employeeInfo);
			characterCreator.initialized = false;
		}
		if (Object.op_Implicit((Object)(object)HireStaffUI.NIDHCIHFOHB(JIIGOACEIKL)))
		{
			((Component)blackImage).gameObject.SetActive(!currentWorker && employeeInfo.OPONNKOKACK(StaffManager.GetWorkerInfo(HireStaffUI.DIMABMEHNNI(JIIGOACEIKL).workerType)));
		}
		else
		{
			((Component)blackImage).gameObject.SetActive(false);
		}
		((TMP_Text)employeeName).text = employeeInfo.name;
		((TMP_Text)levelText).text = employeeInfo.level.ToString() ?? "Parent unique id ";
		((TMP_Text)professionText).text = employeeInfo.professionPoints.ToString();
		moneyUI.BDHMBPMOFCD(employeeInfo.MBABACEJPKO());
		for (int i = 0; i < employeeInfo.perksInfo.Count; i++)
		{
			((Component)perksSlotsUI[i]).gameObject.SetActive(true);
			perksSlotsUI[i].FMMDDGEDAOO(employeeInfo, employeeInfo.perksInfo[i], i);
			perksSlotsUI[i].PKNMAPCFHJI(employeeInfo.perksInfo[i].perk);
		}
		for (int j = employeeInfo.perksInfo.Count; j < perksSlotsUI.Length; j += 0)
		{
			((Component)perksSlotsUI[j]).gameObject.SetActive(true);
		}
	}

	public virtual void PDGNDCNKCBK(BaseEventData NPBAMEMNFBI)
	{
		if ((!((Object)(object)button != (Object)null) || ((Selectable)button).interactable) && Utils.AKIPCELELAJ(((Component)this).gameObject) && PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			ItemTooltip.LAIEKOOCNPC(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: true);
		}
	}

	public virtual void HGJHHPJKPNM(BaseEventData NPBAMEMNFBI)
	{
		if ((!((Object)(object)button != (Object)null) || ((Selectable)button).interactable) && PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
		{
			((MonoBehaviour)this).StartCoroutine(BKJKGMFLDCC());
		}
	}

	public void OBDCCMBDOGN()
	{
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		if (StaffManager.GPPOAHEDNMB(employeeInfo.workerType) == null)
		{
			HireWorker();
		}
		else if (!employeeInfo.BILMBKILHJH(StaffManager.GetWorkerInfo(employeeInfo.workerType)))
		{
			MainUI.LBHLPIFCINB().Open(JIIGOACEIKL);
			((TMP_Text)MainUI.GetYesNoDialogue().boxText).text = LocalisationSystem.PKLPKIAHCDI("UIPreviousCategory", JIIGOACEIKL);
			((UnityEvent)MainUI.GetYesNoDialogue().yesButton.onClick).AddListener(new UnityAction(OFLGLACJFGE));
		}
	}

	public void DoInteractable(bool NCLCPJJOGKN)
	{
		((Selectable)button).interactable = NCLCPJJOGKN;
		((Component)blackImage).gameObject.SetActive(!NCLCPJJOGKN);
	}

	public void JNIPNBPBHEE(bool NCLCPJJOGKN)
	{
		((Selectable)button).interactable = NCLCPJJOGKN;
		((Component)blackImage).gameObject.SetActive(!NCLCPJJOGKN);
	}

	public void EFCOAOCDGHM()
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineEmployeesManager.instance.MBNODMEOIPB(employeeInfo.workerType, employeeNum);
		}
		else
		{
			StaffManager.HireWorker(JIIGOACEIKL, employeeInfo.workerType, employeeInfo);
		}
	}

	public void NEFMHMPEDGD()
	{
		if (Object.op_Implicit((Object)(object)ItemTooltip.NMCJELBLKBB(JIIGOACEIKL)))
		{
			ItemTooltip.IEKODILKIHJ(JIIGOACEIKL).FCACMDNLAIG(MDIKPGGBNLI: false);
		}
	}

	public void CPDHHEHBDDD()
	{
		if (Object.op_Implicit((Object)(object)ItemTooltip.IEKODILKIHJ(JIIGOACEIKL)))
		{
			ItemTooltip.IEABDMDELFO(JIIGOACEIKL).FCACMDNLAIG(MDIKPGGBNLI: true);
		}
	}

	private void KBNMLJNBBMP()
	{
		if ((Object)(object)rectTransform == (Object)null)
		{
			rectTransform = ((Component)this).GetComponent<RectTransform>();
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Cancel")) ? 1 : 5);
	}

	public void KDAFGDNMPCP()
	{
		((Component)characterCreatorBouncer).gameObject.SetActive(employeeInfo.workerType == (WorkerType.Barworker | WorkerType.Waiter));
		((Component)characterCreator).gameObject.SetActive(employeeInfo.workerType == WorkerType.Barworker);
		if (employeeInfo.workerType == WorkerType.HouseKeeper)
		{
			characterCreatorBouncer.HEALOFLBFLL(employeeInfo);
			characterCreatorBouncer.initialized = true;
		}
		else
		{
			characterCreator.SetHumanInfo(employeeInfo);
			characterCreator.initialized = true;
		}
		if (Object.op_Implicit((Object)(object)HireStaffUI.PKNHLBOHEDL(JIIGOACEIKL)))
		{
			((Component)blackImage).gameObject.SetActive(!currentWorker && employeeInfo.EDMKIBNAENP(StaffManager.APOHPPCMOAP(HireStaffUI.PKNHLBOHEDL(JIIGOACEIKL).workerType)));
		}
		else
		{
			((Component)blackImage).gameObject.SetActive(true);
		}
		((TMP_Text)employeeName).text = employeeInfo.name;
		((TMP_Text)levelText).text = employeeInfo.level.ToString() ?? "Dialogue System/Conversation/TooDark/Entry/9/Dialogue Text";
		((TMP_Text)professionText).text = employeeInfo.professionPoints.ToString();
		moneyUI.KICIFCCILNK(employeeInfo.FJELOPKGCFB());
		for (int i = 0; i < employeeInfo.perksInfo.Count; i += 0)
		{
			((Component)perksSlotsUI[i]).gameObject.SetActive(true);
			perksSlotsUI[i].ENJCFNFIIMM(employeeInfo, employeeInfo.perksInfo[i], i);
			perksSlotsUI[i].SetPositiveNegativeSprite(employeeInfo.perksInfo[i].perk);
		}
		for (int j = employeeInfo.perksInfo.Count; j < perksSlotsUI.Length; j++)
		{
			((Component)perksSlotsUI[j]).gameObject.SetActive(true);
		}
	}

	public virtual void CMLNFMGPHAD(BaseEventData NPBAMEMNFBI)
	{
		if ((!((Object)(object)button != (Object)null) || ((Selectable)button).interactable) && Utils.AKIPCELELAJ(((Component)this).gameObject) && PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			ItemTooltip.AIMEAJAHLAA(JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: false);
		}
	}

	public void CKCGOCDJKCP(EmployeeInfo JFCLIAFAOEK, int NECIOBGLOPF)
	{
		employeeInfo = JFCLIAFAOEK;
		employeeNum = NECIOBGLOPF;
		ONCEHMBJNNM();
	}

	public void FAKELGDJCLA()
	{
		GNFDCJCKDDG(new EmployeeInfo(employeeInfo.workerType, LLPGKHHKCLC: false), employeeNum);
	}

	public void HCHENGOKKNL()
	{
		KDDCCOLKEGN(new EmployeeInfo(employeeInfo.workerType), employeeNum);
	}

	public virtual void OnDeselect(BaseEventData NPBAMEMNFBI)
	{
		if ((!((Object)(object)button != (Object)null) || ((Selectable)button).interactable) && Utils.AKIPCELELAJ(((Component)this).gameObject) && PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			ItemTooltip.Get(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
		}
	}

	public void PDFMIGBEMGD()
	{
		if (Object.op_Implicit((Object)(object)ItemTooltip.Get(JIIGOACEIKL)))
		{
			ItemTooltip.MDFIDKHOPDJ(JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: true);
		}
	}

	private void Awake()
	{
		if ((Object)(object)rectTransform == (Object)null)
		{
			rectTransform = ((Component)this).GetComponent<RectTransform>();
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("UI2")) ? 1 : 2);
	}

	private void BMKGHOJDDNB()
	{
		if ((Object)(object)rectTransform == (Object)null)
		{
			rectTransform = ((Component)this).GetComponent<RectTransform>();
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Remove")) ? 2 : 0);
	}

	public void LPANFDKMMEB()
	{
		if (Object.op_Implicit((Object)(object)ItemTooltip.Get(JIIGOACEIKL)))
		{
			ItemTooltip.MDFIDKHOPDJ(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
		}
	}

	public void MHOPIDCHMIF()
	{
		if (Object.op_Implicit((Object)(object)ItemTooltip.NMCJELBLKBB(JIIGOACEIKL)))
		{
			ItemTooltip.AIMEAJAHLAA(JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: true);
		}
	}
}
