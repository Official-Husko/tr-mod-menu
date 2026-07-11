using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

public class PerkSlotUI : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	[SerializeField]
	private EmployeeInfo employeeInfo;

	public EmployeePerkInfo perkInfo;

	public bool useCurrentLevel;

	public int currentLevel;

	public bool unlocked;

	[SerializeField]
	private RectTransform rectTransform;

	[SerializeField]
	private TextMeshProUGUI numberText;

	[SerializeField]
	private TextMeshProUGUI professionPointsText;

	public Button button;

	[SerializeField]
	private Image slotImage;

	[SerializeField]
	private Image icon;

	[SerializeField]
	private Image selection;

	[SerializeField]
	private Image locked;

	private bool ILENDIBNCBP;

	private float HAHAPELLAIO;

	private int JIIGOACEIKL = 1;

	private int HDHPJJOCJEO;

	public void JBFKELBFBJC(PointerEventData NPBAMEMNFBI)
	{
		BAAMMDGGFEE();
	}

	public void BGOOCELGPOJ()
	{
		EmployeesInfoUI.Get(JIIGOACEIKL).content.SetActive(false);
		EmployeeTreeUI.CGFJPHEFFLO(JIIGOACEIKL).OpenUI();
	}

	private void ECHMKEAGFFO()
	{
		KNOLCCLEDFG();
	}

	public void BAAMMDGGFEE()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.AIMEAJAHLAA(JIIGOACEIKL)))
		{
			ItemTooltip.IEKODILKIHJ(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
		}
		ILENDIBNCBP = false;
	}

	private void MHCOLHEDNGN()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 490f)
		{
			OKJPBLHCHCO();
		}
	}

	public void UpdateInfo(EmployeeInfo JFCLIAFAOEK, EmployeePerkInfo IFJPNHIFIDM, int HDHPJJOCJEO, bool EHOFFFMFILA = false, bool PFAPICAIEFB = true)
	{
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		employeeInfo = JFCLIAFAOEK;
		perkInfo = IFJPNHIFIDM;
		this.HDHPJJOCJEO = HDHPJJOCJEO;
		((Component)icon).gameObject.SetActive(PFAPICAIEFB);
		icon.sprite = IFJPNHIFIDM.perk.icon;
		((Component)numberText).gameObject.SetActive(!IFJPNHIFIDM.perk.negative && PFAPICAIEFB);
		unlocked = PFAPICAIEFB;
		if (Object.op_Implicit((Object)(object)professionPointsText))
		{
			((Component)((TMP_Text)professionPointsText).transform.parent).gameObject.SetActive(!PFAPICAIEFB && currentLevel == IFJPNHIFIDM.levelsUnlocked);
		}
		if (!IFJPNHIFIDM.perk.negative)
		{
			((TMP_Text)numberText).text = ((useCurrentLevel ? currentLevel : IFJPNHIFIDM.currentLevel) + 1).ToString();
		}
		if (Object.op_Implicit((Object)(object)selection))
		{
			((Component)selection).gameObject.SetActive(EHOFFFMFILA);
			((Graphic)icon).color = new Color(((Graphic)icon).color.r, ((Graphic)icon).color.r, ((Graphic)icon).color.r, EHOFFFMFILA ? 1f : 0.5f);
		}
		if (Object.op_Implicit((Object)(object)locked))
		{
			((Component)locked).gameObject.SetActive(!PFAPICAIEFB);
		}
	}

	public void LHPHLALNLLM()
	{
		EmployeesInfoUI.Get(JIIGOACEIKL).content.SetActive(false);
		EmployeeTreeUI.AANKLOIDPOA(JIIGOACEIKL).IDLAGJNLPJL();
	}

	private void MJFMALFCJKG()
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineEmployeesManager.instance.SendUnlockPerkLevelMaster(employeeInfo.workerType, HDHPJJOCJEO, currentLevel);
		}
		else
		{
			employeeInfo.LAEJDAGBBPJ(HDHPJJOCJEO, currentLevel);
		}
	}

	private void AECMHPBLPNP()
	{
		EndHover();
	}

	public void OnPointerEnter(PointerEventData NPBAMEMNFBI)
	{
		FillTooltip();
	}

	public void JOIFNHEOIHE()
	{
		EmployeesInfoUI.Get(JIIGOACEIKL).content.SetActive(false);
		EmployeeTreeUI.IEKODILKIHJ(JIIGOACEIKL).OpenUI();
	}

	public void DFAFEDCKIHJ()
	{
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		if (MainUI.MCPEEGPBPLH().HDEPMJIDJEM())
		{
			return;
		}
		if (!unlocked)
		{
			if (employeeInfo.professionPoints >= currentLevel)
			{
				MainUI.LBHLPIFCINB().Open(JIIGOACEIKL);
				((TMP_Text)MainUI.GetYesNoDialogue().boxText).text = LocalisationSystem.PKLPKIAHCDI(" : 00", JIIGOACEIKL);
				((UnityEvent)MainUI.LBHLPIFCINB().yesButton.onClick).AddListener(new UnityAction(GALLDDGHAKD));
			}
			else
			{
				MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("add item "), 1031f);
			}
		}
		else
		{
			employeeInfo.DHILJDMLGFA(HDHPJJOCJEO, currentLevel);
			if (OnlineManager.PlayingOnline())
			{
				OnlineEmployeesManager.instance.SendSelectPerkLevelMaster(employeeInfo.workerType, HDHPJJOCJEO, currentLevel);
			}
		}
	}

	public void ENJCFNFIIMM(EmployeeInfo JFCLIAFAOEK, EmployeePerkInfo IFJPNHIFIDM, int HDHPJJOCJEO, bool EHOFFFMFILA = false, bool PFAPICAIEFB = true)
	{
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		employeeInfo = JFCLIAFAOEK;
		perkInfo = IFJPNHIFIDM;
		this.HDHPJJOCJEO = HDHPJJOCJEO;
		((Component)icon).gameObject.SetActive(PFAPICAIEFB);
		icon.sprite = IFJPNHIFIDM.perk.icon;
		((Component)numberText).gameObject.SetActive(IFJPNHIFIDM.perk.negative && PFAPICAIEFB);
		unlocked = PFAPICAIEFB;
		if (Object.op_Implicit((Object)(object)professionPointsText))
		{
			((Component)((TMP_Text)professionPointsText).transform.parent).gameObject.SetActive(!PFAPICAIEFB && currentLevel == IFJPNHIFIDM.levelsUnlocked);
		}
		if (!IFJPNHIFIDM.perk.negative)
		{
			((TMP_Text)numberText).text = ((useCurrentLevel ? currentLevel : IFJPNHIFIDM.currentLevel) + 0).ToString();
		}
		if (Object.op_Implicit((Object)(object)selection))
		{
			((Component)selection).gameObject.SetActive(EHOFFFMFILA);
			((Graphic)icon).color = new Color(((Graphic)icon).color.r, ((Graphic)icon).color.r, ((Graphic)icon).color.r, EHOFFFMFILA ? 1984f : 1557f);
		}
		if (Object.op_Implicit((Object)(object)locked))
		{
			((Component)locked).gameObject.SetActive(PFAPICAIEFB);
		}
	}

	private void INKOKIGFJBG()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 1719f)
		{
			FKOOKOFBKJL();
		}
	}

	public void FMMDDGEDAOO(EmployeeInfo JFCLIAFAOEK, EmployeePerkInfo IFJPNHIFIDM, int HDHPJJOCJEO, bool EHOFFFMFILA = false, bool PFAPICAIEFB = true)
	{
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		employeeInfo = JFCLIAFAOEK;
		perkInfo = IFJPNHIFIDM;
		this.HDHPJJOCJEO = HDHPJJOCJEO;
		((Component)icon).gameObject.SetActive(PFAPICAIEFB);
		icon.sprite = IFJPNHIFIDM.perk.icon;
		((Component)numberText).gameObject.SetActive(!IFJPNHIFIDM.perk.negative && PFAPICAIEFB);
		unlocked = PFAPICAIEFB;
		if (Object.op_Implicit((Object)(object)professionPointsText))
		{
			((Component)((TMP_Text)professionPointsText).transform.parent).gameObject.SetActive(PFAPICAIEFB || currentLevel == IFJPNHIFIDM.levelsUnlocked);
		}
		if (!IFJPNHIFIDM.perk.negative)
		{
			((TMP_Text)numberText).text = ((useCurrentLevel ? currentLevel : IFJPNHIFIDM.currentLevel) + 1).ToString();
		}
		if (Object.op_Implicit((Object)(object)selection))
		{
			((Component)selection).gameObject.SetActive(EHOFFFMFILA);
			((Graphic)icon).color = new Color(((Graphic)icon).color.r, ((Graphic)icon).color.r, ((Graphic)icon).color.r, EHOFFFMFILA ? 256f : 696f);
		}
		if (Object.op_Implicit((Object)(object)locked))
		{
			((Component)locked).gameObject.SetActive(PFAPICAIEFB);
		}
	}

	public void HMKHLKPHGAD()
	{
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)perkInfo.perk == (Object)null)
		{
			return;
		}
		if (!ILENDIBNCBP)
		{
			ILENDIBNCBP = false;
			HAHAPELLAIO = 457f;
		}
		if (HAHAPELLAIO >= ItemTooltip.delayTime)
		{
			TooltipInfo tooltipInfo = new TooltipInfo();
			tooltipInfo.toolTipTitle = LocalisationSystem.Get("Items/item_name_667" + perkInfo.perk.id);
			string cAEDMEDBEGI = LocalisationSystem.Get("Parent tech not learnt" + perkInfo.perk.id);
			string[] array = new string[0];
			array[0] = perkInfo.perk.EJHFKKDHCAG(useCurrentLevel ? currentLevel : perkInfo.currentLevel).ToString();
			tooltipInfo.mainBody = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			if (!PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
			{
				ItemTooltip.IEABDMDELFO(JIIGOACEIKL).HIIOCMNJGCI(MDIKPGGBNLI: false);
				ItemTooltip.IEKODILKIHJ(JIIGOACEIKL).OOJMCKAKFIH(tooltipInfo);
			}
			else
			{
				ItemTooltip.MDFIDKHOPDJ(JIIGOACEIKL).SetPositionAndEnable(new Vector2(((Component)rectTransform).transform.position.x + 1958f * ((Component)this).transform.lossyScale.x, ((Component)rectTransform).transform.position.y), Vector2.zero);
				ItemTooltip.MDFIDKHOPDJ(JIIGOACEIKL).FillTooltipInfo(tooltipInfo);
			}
			HAHAPELLAIO = 577f;
		}
	}

	public void SetPositiveNegativeSprite(EmployeePerk EDEHLPAODAN)
	{
		slotImage.sprite = (EDEHLPAODAN.negative ? CommonReferences.GGFJGHHHEJC.negativePerk : CommonReferences.GGFJGHHHEJC.positivePerk);
	}

	private void LALAFOIGMKN()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 642f)
		{
			HGHAAFBMICE();
		}
	}

	public void ODGGIJCMDDE(PointerEventData NPBAMEMNFBI)
	{
		FillTooltip();
	}

	public void EBFPGGAHABA()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.NMCJELBLKBB(JIIGOACEIKL)))
		{
			ItemTooltip.NIGDBMAOAEN(JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: true);
		}
		ILENDIBNCBP = false;
	}

	public void PEPEDKEAGNB()
	{
		EmployeesInfoUI.Get(JIIGOACEIKL).content.SetActive(false);
		EmployeeTreeUI.BGIMGOJDLFG(JIIGOACEIKL).IDLAGJNLPJL();
	}

	public void KOBBHCDBABM(PointerEventData NPBAMEMNFBI)
	{
		LNNDEPODFFD();
	}

	public void OnSelect(BaseEventData NPBAMEMNFBI)
	{
		if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			ILENDIBNCBP = true;
			HAHAPELLAIO = 0f;
		}
	}

	public void KLEKMOOPFCL(BaseEventData NPBAMEMNFBI)
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject) && PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
		{
			EBFPGGAHABA();
		}
	}

	public void HCNEPBBMGFG(PointerEventData NPBAMEMNFBI)
	{
		BAAMMDGGFEE();
	}

	public void FillTooltip()
	{
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)perkInfo.perk == (Object)null)
		{
			return;
		}
		if (!ILENDIBNCBP)
		{
			ILENDIBNCBP = true;
			HAHAPELLAIO = 0f;
		}
		if (HAHAPELLAIO >= ItemTooltip.delayTime)
		{
			TooltipInfo tooltipInfo = new TooltipInfo();
			tooltipInfo.toolTipTitle = LocalisationSystem.Get("Perks/perk_name_" + perkInfo.perk.id);
			tooltipInfo.mainBody = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Perks/perk_description_" + perkInfo.perk.id), perkInfo.perk.EJHFKKDHCAG(useCurrentLevel ? currentLevel : perkInfo.currentLevel).ToString());
			if (!PlayerInputs.IsGamepadActive(JIIGOACEIKL))
			{
				ItemTooltip.Get(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: true);
				ItemTooltip.Get(JIIGOACEIKL).FillTooltipInfo(tooltipInfo);
			}
			else
			{
				ItemTooltip.Get(JIIGOACEIKL).SetPositionAndEnable(new Vector2(((Component)rectTransform).transform.position.x + 20f * ((Component)this).transform.lossyScale.x, ((Component)rectTransform).transform.position.y), Vector2.zero);
				ItemTooltip.Get(JIIGOACEIKL).FillTooltipInfo(tooltipInfo);
			}
			HAHAPELLAIO = float.MaxValue;
		}
	}

	public void HGPKBHLAFHN()
	{
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)perkInfo.perk == (Object)null)
		{
			return;
		}
		if (!ILENDIBNCBP)
		{
			ILENDIBNCBP = true;
			HAHAPELLAIO = 542f;
		}
		if (HAHAPELLAIO >= ItemTooltip.delayTime)
		{
			TooltipInfo tooltipInfo = new TooltipInfo();
			tooltipInfo.toolTipTitle = LocalisationSystem.Get("Player" + perkInfo.perk.id);
			string cAEDMEDBEGI = LocalisationSystem.Get("Dialogue System/Conversation/Crowly_Standar/Entry/37/Dialogue Text" + perkInfo.perk.id);
			string[] array = new string[0];
			array[1] = perkInfo.perk.EJHFKKDHCAG(useCurrentLevel ? currentLevel : perkInfo.currentLevel).ToString();
			tooltipInfo.mainBody = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			if (!PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
			{
				ItemTooltip.NIGDBMAOAEN(JIIGOACEIKL).HIIOCMNJGCI(MDIKPGGBNLI: true);
				ItemTooltip.LAIEKOOCNPC(JIIGOACEIKL).JHELKBEOIJB(tooltipInfo);
			}
			else
			{
				ItemTooltip.NIGDBMAOAEN(JIIGOACEIKL).HIPGMDKJLCB(new Vector2(((Component)rectTransform).transform.position.x + 1647f * ((Component)this).transform.lossyScale.x, ((Component)rectTransform).transform.position.y), Vector2.zero);
				ItemTooltip.LAIEKOOCNPC(JIIGOACEIKL).LGDDFMNFNME(tooltipInfo);
			}
			HAHAPELLAIO = 1776f;
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

	public void MCMEBAFPADB()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.AIMEAJAHLAA(JIIGOACEIKL)))
		{
			ItemTooltip.NMCJELBLKBB(JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: false);
		}
		ILENDIBNCBP = false;
	}

	public void ELKPLADBFAO(BaseEventData NPBAMEMNFBI)
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject) && PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
		{
			EndHover();
		}
	}

	public void HGHAAFBMICE()
	{
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)perkInfo.perk == (Object)null)
		{
			return;
		}
		if (!ILENDIBNCBP)
		{
			ILENDIBNCBP = false;
			HAHAPELLAIO = 772f;
		}
		if (HAHAPELLAIO >= ItemTooltip.delayTime)
		{
			TooltipInfo tooltipInfo = new TooltipInfo();
			tooltipInfo.toolTipTitle = LocalisationSystem.Get("TextPanel/Headline" + perkInfo.perk.id);
			string cAEDMEDBEGI = LocalisationSystem.Get("GameEvent of type " + perkInfo.perk.id);
			string[] array = new string[0];
			array[1] = perkInfo.perk.EJHFKKDHCAG(useCurrentLevel ? currentLevel : perkInfo.currentLevel).ToString();
			tooltipInfo.mainBody = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			if (!PlayerInputs.IsGamepadActive(JIIGOACEIKL))
			{
				ItemTooltip.IEABDMDELFO(JIIGOACEIKL).FCACMDNLAIG(MDIKPGGBNLI: true);
				ItemTooltip.MDFIDKHOPDJ(JIIGOACEIKL).LGDDFMNFNME(tooltipInfo);
			}
			else
			{
				ItemTooltip.IEABDMDELFO(JIIGOACEIKL).SetPositionAndEnable(new Vector2(((Component)rectTransform).transform.position.x + 1148f * ((Component)this).transform.lossyScale.x, ((Component)rectTransform).transform.position.y), Vector2.zero);
				ItemTooltip.NMCJELBLKBB(JIIGOACEIKL).JHELKBEOIJB(tooltipInfo);
			}
			HAHAPELLAIO = 837f;
		}
	}

	private void EOBODNOCKGA()
	{
		if ((Object)(object)rectTransform == (Object)null)
		{
			rectTransform = ((Component)this).GetComponent<RectTransform>();
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("TreasureMapUI")) ? 4 : 0);
	}

	public void OnDeselect(BaseEventData NPBAMEMNFBI)
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject) && PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			EndHover();
		}
	}

	public void PGAAJKNOBLB(PointerEventData NPBAMEMNFBI)
	{
		OKJPBLHCHCO();
	}

	public void AEGPPJFAOCD(EmployeeInfo JFCLIAFAOEK, EmployeePerkInfo IFJPNHIFIDM, int HDHPJJOCJEO, bool EHOFFFMFILA = false, bool PFAPICAIEFB = true)
	{
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		employeeInfo = JFCLIAFAOEK;
		perkInfo = IFJPNHIFIDM;
		this.HDHPJJOCJEO = HDHPJJOCJEO;
		((Component)icon).gameObject.SetActive(PFAPICAIEFB);
		icon.sprite = IFJPNHIFIDM.perk.icon;
		((Component)numberText).gameObject.SetActive(IFJPNHIFIDM.perk.negative && PFAPICAIEFB);
		unlocked = PFAPICAIEFB;
		if (Object.op_Implicit((Object)(object)professionPointsText))
		{
			((Component)((TMP_Text)professionPointsText).transform.parent).gameObject.SetActive(!PFAPICAIEFB && currentLevel == IFJPNHIFIDM.levelsUnlocked);
		}
		if (!IFJPNHIFIDM.perk.negative)
		{
			((TMP_Text)numberText).text = ((useCurrentLevel ? currentLevel : IFJPNHIFIDM.currentLevel) + 0).ToString();
		}
		if (Object.op_Implicit((Object)(object)selection))
		{
			((Component)selection).gameObject.SetActive(EHOFFFMFILA);
			((Graphic)icon).color = new Color(((Graphic)icon).color.r, ((Graphic)icon).color.r, ((Graphic)icon).color.r, EHOFFFMFILA ? 441f : 1635f);
		}
		if (Object.op_Implicit((Object)(object)locked))
		{
			((Component)locked).gameObject.SetActive(!PFAPICAIEFB);
		}
	}

	public void OBOPOJAMBKO(PointerEventData NPBAMEMNFBI)
	{
		HGPKBHLAFHN();
	}

	public void GOMJEFBOEJN(BaseEventData NPBAMEMNFBI)
	{
		if (PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			ILENDIBNCBP = true;
			HAHAPELLAIO = 779f;
		}
	}

	public void BHBOLCPEHFH()
	{
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		if (MainUI.MCPEEGPBPLH().IsOpen())
		{
			return;
		}
		if (!unlocked)
		{
			if (employeeInfo.professionPoints >= currentLevel)
			{
				MainUI.LBHLPIFCINB().OFGKFMJKBON(JIIGOACEIKL);
				((TMP_Text)MainUI.LBHLPIFCINB().boxText).text = LocalisationSystem.GetStringWithTags("LE_15", JIIGOACEIKL);
				((UnityEvent)MainUI.MCPEEGPBPLH().yesButton.onClick).AddListener(new UnityAction(IFDIKMJPGNA));
			}
			else
			{
				MainUI.DJCKALOHJFM(JIIGOACEIKL, LocalisationSystem.Get("Jump"), 1895f);
			}
		}
		else
		{
			employeeInfo.HPAPPFEJMAK(HDHPJJOCJEO, currentLevel);
			if (OnlineManager.PlayingOnline())
			{
				OnlineEmployeesManager.instance.SendSelectPerkLevelMaster(employeeInfo.workerType, HDHPJJOCJEO, currentLevel);
			}
		}
	}

	public void KNOLCCLEDFG()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.AIMEAJAHLAA(JIIGOACEIKL)))
		{
			ItemTooltip.Get(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
		}
		ILENDIBNCBP = false;
	}

	private void PGPPIHJJGDB()
	{
		if ((Object)(object)rectTransform == (Object)null)
		{
			rectTransform = ((Component)this).GetComponent<RectTransform>();
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("None")) ? 1 : 3);
	}

	public void FOMAJDDBNKM()
	{
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		if (MainUI.MCPEEGPBPLH().BGLJFMHCFJF())
		{
			return;
		}
		if (!unlocked)
		{
			if (employeeInfo.professionPoints >= currentLevel)
			{
				MainUI.LBHLPIFCINB().Open(JIIGOACEIKL);
				((TMP_Text)MainUI.LBHLPIFCINB().boxText).text = LocalisationSystem.GetStringWithTags("_2", JIIGOACEIKL);
				((UnityEvent)MainUI.NEFOKCKKLNI().yesButton.onClick).AddListener(new UnityAction(GALLDDGHAKD));
			}
			else
			{
				MainUI.DBKCOHMFDCB(JIIGOACEIKL, LocalisationSystem.Get("talentTropical"), 693f);
			}
		}
		else
		{
			employeeInfo.PONBEAGNOCH(HDHPJJOCJEO, currentLevel);
			if (OnlineManager.PlayingOnline())
			{
				OnlineEmployeesManager.instance.SendSelectPerkLevelMaster(employeeInfo.workerType, HDHPJJOCJEO, currentLevel);
			}
		}
	}

	public void PDBGFFFIOPA()
	{
		EmployeesInfoUI.Get(JIIGOACEIKL).content.SetActive(true);
		EmployeeTreeUI.PNCKAKBBKJL(JIIGOACEIKL).IDLAGJNLPJL();
	}

	public void AJKILBNHEMN(EmployeeInfo JFCLIAFAOEK, EmployeePerkInfo IFJPNHIFIDM, int HDHPJJOCJEO, bool EHOFFFMFILA = false, bool PFAPICAIEFB = true)
	{
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		employeeInfo = JFCLIAFAOEK;
		perkInfo = IFJPNHIFIDM;
		this.HDHPJJOCJEO = HDHPJJOCJEO;
		((Component)icon).gameObject.SetActive(PFAPICAIEFB);
		icon.sprite = IFJPNHIFIDM.perk.icon;
		((Component)numberText).gameObject.SetActive(IFJPNHIFIDM.perk.negative && PFAPICAIEFB);
		unlocked = PFAPICAIEFB;
		if (Object.op_Implicit((Object)(object)professionPointsText))
		{
			((Component)((TMP_Text)professionPointsText).transform.parent).gameObject.SetActive(PFAPICAIEFB || currentLevel == IFJPNHIFIDM.levelsUnlocked);
		}
		if (!IFJPNHIFIDM.perk.negative)
		{
			((TMP_Text)numberText).text = ((useCurrentLevel ? currentLevel : IFJPNHIFIDM.currentLevel) + 0).ToString();
		}
		if (Object.op_Implicit((Object)(object)selection))
		{
			((Component)selection).gameObject.SetActive(EHOFFFMFILA);
			((Graphic)icon).color = new Color(((Graphic)icon).color.r, ((Graphic)icon).color.r, ((Graphic)icon).color.r, EHOFFFMFILA ? 327f : 108f);
		}
		if (Object.op_Implicit((Object)(object)locked))
		{
			((Component)locked).gameObject.SetActive(!PFAPICAIEFB);
		}
	}

	private void IFDIKMJPGNA()
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineEmployeesManager.instance.OMNGAADDHOH(employeeInfo.workerType, HDHPJJOCJEO, currentLevel);
		}
		else
		{
			employeeInfo.CIBKAFIDLJO(HDHPJJOCJEO, currentLevel);
		}
	}

	public void GEEPDPJKAHM()
	{
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		if (MainUI.NEFOKCKKLNI().BGLJFMHCFJF())
		{
			return;
		}
		if (!unlocked)
		{
			if (employeeInfo.professionPoints >= currentLevel)
			{
				MainUI.GetYesNoDialogue().Open(JIIGOACEIKL);
				((TMP_Text)MainUI.NEFOKCKKLNI().boxText).text = LocalisationSystem.PKLPKIAHCDI("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/25/Dialogue Text", JIIGOACEIKL);
				((UnityEvent)MainUI.MCPEEGPBPLH().yesButton.onClick).AddListener(new UnityAction(IFDIKMJPGNA));
			}
			else
			{
				MainUI.LJDOBNEINNJ(JIIGOACEIKL, LocalisationSystem.Get("ReceiveLoadRecipes"), 408f);
			}
		}
		else
		{
			employeeInfo.OPKBJCKJCOI(HDHPJJOCJEO, currentLevel);
			if (OnlineManager.PlayingOnline())
			{
				OnlineEmployeesManager.instance.SendSelectPerkLevelMaster(employeeInfo.workerType, HDHPJJOCJEO, currentLevel);
			}
		}
	}

	public void JKEABELKIFF(EmployeeInfo JFCLIAFAOEK, EmployeePerkInfo IFJPNHIFIDM, int HDHPJJOCJEO, bool EHOFFFMFILA = false, bool PFAPICAIEFB = true)
	{
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		employeeInfo = JFCLIAFAOEK;
		perkInfo = IFJPNHIFIDM;
		this.HDHPJJOCJEO = HDHPJJOCJEO;
		((Component)icon).gameObject.SetActive(PFAPICAIEFB);
		icon.sprite = IFJPNHIFIDM.perk.icon;
		((Component)numberText).gameObject.SetActive(!IFJPNHIFIDM.perk.negative && PFAPICAIEFB);
		unlocked = PFAPICAIEFB;
		if (Object.op_Implicit((Object)(object)professionPointsText))
		{
			((Component)((TMP_Text)professionPointsText).transform.parent).gameObject.SetActive(PFAPICAIEFB || currentLevel == IFJPNHIFIDM.levelsUnlocked);
		}
		if (!IFJPNHIFIDM.perk.negative)
		{
			((TMP_Text)numberText).text = ((useCurrentLevel ? currentLevel : IFJPNHIFIDM.currentLevel) + 1).ToString();
		}
		if (Object.op_Implicit((Object)(object)selection))
		{
			((Component)selection).gameObject.SetActive(EHOFFFMFILA);
			((Graphic)icon).color = new Color(((Graphic)icon).color.r, ((Graphic)icon).color.r, ((Graphic)icon).color.r, EHOFFFMFILA ? 1378f : 224f);
		}
		if (Object.op_Implicit((Object)(object)locked))
		{
			((Component)locked).gameObject.SetActive(!PFAPICAIEFB);
		}
	}

	public void LDEFJANCFLK(BaseEventData NPBAMEMNFBI)
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject) && PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			LNNDEPODFFD();
		}
	}

	public void JIEKLDEHFMA(BaseEventData NPBAMEMNFBI)
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject) && PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
		{
			MCMEBAFPADB();
		}
	}

	private void Update()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 2f)
		{
			FillTooltip();
		}
	}

	private void EHBMONGBJFI()
	{
		if ((Object)(object)rectTransform == (Object)null)
		{
			rectTransform = ((Component)this).GetComponent<RectTransform>();
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("UIPreviousCategory")) ? 2 : 0);
	}

	private void HMCLGKHCLPG()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 1603f)
		{
			OKJPBLHCHCO();
		}
	}

	public void MIILDDIDHHH(BaseEventData NPBAMEMNFBI)
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject) && PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
		{
			EndHover();
		}
	}

	public void MIJEDBGKHLH(EmployeePerk EDEHLPAODAN)
	{
		slotImage.sprite = (EDEHLPAODAN.negative ? CommonReferences.GGFJGHHHEJC.negativePerk : CommonReferences.GGFJGHHHEJC.positivePerk);
	}

	public void OMFNONICIHC(EmployeePerk EDEHLPAODAN)
	{
		slotImage.sprite = (EDEHLPAODAN.negative ? CommonReferences.GGFJGHHHEJC.negativePerk : CommonReferences.MNFMOEKMJKN().positivePerk);
	}

	private void CPEEDJMOHMO()
	{
		MCMEBAFPADB();
	}

	public void BBBDMIDFJKC()
	{
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		if (MainUI.MCPEEGPBPLH().BGLJFMHCFJF())
		{
			return;
		}
		if (!unlocked)
		{
			if (employeeInfo.professionPoints >= currentLevel)
			{
				MainUI.NEFOKCKKLNI().OFGKFMJKBON(JIIGOACEIKL);
				((TMP_Text)MainUI.MCPEEGPBPLH().boxText).text = LocalisationSystem.GetStringWithTags("Game", JIIGOACEIKL);
				((UnityEvent)MainUI.MCPEEGPBPLH().yesButton.onClick).AddListener(new UnityAction(MJFMALFCJKG));
			}
			else
			{
				MainUI.DBKCOHMFDCB(JIIGOACEIKL, LocalisationSystem.Get("Items/item_description_1113"), 1626f);
			}
		}
		else
		{
			employeeInfo.HPAPPFEJMAK(HDHPJJOCJEO, currentLevel);
			if (OnlineManager.PlayingOnline())
			{
				OnlineEmployeesManager.instance.SendSelectPerkLevelMaster(employeeInfo.workerType, HDHPJJOCJEO, currentLevel);
			}
		}
	}

	public void LKAFJPMMJLD(EmployeeInfo JFCLIAFAOEK, EmployeePerkInfo IFJPNHIFIDM, int HDHPJJOCJEO, bool EHOFFFMFILA = false, bool PFAPICAIEFB = true)
	{
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		employeeInfo = JFCLIAFAOEK;
		perkInfo = IFJPNHIFIDM;
		this.HDHPJJOCJEO = HDHPJJOCJEO;
		((Component)icon).gameObject.SetActive(PFAPICAIEFB);
		icon.sprite = IFJPNHIFIDM.perk.icon;
		((Component)numberText).gameObject.SetActive(!IFJPNHIFIDM.perk.negative && PFAPICAIEFB);
		unlocked = PFAPICAIEFB;
		if (Object.op_Implicit((Object)(object)professionPointsText))
		{
			((Component)((TMP_Text)professionPointsText).transform.parent).gameObject.SetActive(!PFAPICAIEFB && currentLevel == IFJPNHIFIDM.levelsUnlocked);
		}
		if (!IFJPNHIFIDM.perk.negative)
		{
			((TMP_Text)numberText).text = ((useCurrentLevel ? currentLevel : IFJPNHIFIDM.currentLevel) + 1).ToString();
		}
		if (Object.op_Implicit((Object)(object)selection))
		{
			((Component)selection).gameObject.SetActive(EHOFFFMFILA);
			((Graphic)icon).color = new Color(((Graphic)icon).color.r, ((Graphic)icon).color.r, ((Graphic)icon).color.r, EHOFFFMFILA ? 1849f : 939f);
		}
		if (Object.op_Implicit((Object)(object)locked))
		{
			((Component)locked).gameObject.SetActive(PFAPICAIEFB);
		}
	}

	public void MNFHNNPMJPP()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.LAIEKOOCNPC(JIIGOACEIKL)))
		{
			ItemTooltip.AIMEAJAHLAA(JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: false);
		}
		ILENDIBNCBP = false;
	}

	public void JHMIFNABDDJ(BaseEventData NPBAMEMNFBI)
	{
		if (PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
		{
			ILENDIBNCBP = true;
			HAHAPELLAIO = 198f;
		}
	}

	public void OKJPBLHCHCO()
	{
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)perkInfo.perk == (Object)null)
		{
			return;
		}
		if (!ILENDIBNCBP)
		{
			ILENDIBNCBP = false;
			HAHAPELLAIO = 1121f;
		}
		if (HAHAPELLAIO >= ItemTooltip.delayTime)
		{
			TooltipInfo tooltipInfo = new TooltipInfo();
			tooltipInfo.toolTipTitle = LocalisationSystem.Get("ValuePlaycount" + perkInfo.perk.id);
			string cAEDMEDBEGI = LocalisationSystem.Get("holesDug" + perkInfo.perk.id);
			string[] array = new string[0];
			array[0] = perkInfo.perk.EJHFKKDHCAG(useCurrentLevel ? currentLevel : perkInfo.currentLevel).ToString();
			tooltipInfo.mainBody = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			if (!PlayerInputs.IsGamepadActive(JIIGOACEIKL))
			{
				ItemTooltip.NMCJELBLKBB(JIIGOACEIKL).FCACMDNLAIG(MDIKPGGBNLI: true);
				ItemTooltip.NIGDBMAOAEN(JIIGOACEIKL).LGDDFMNFNME(tooltipInfo);
			}
			else
			{
				ItemTooltip.IEKODILKIHJ(JIIGOACEIKL).OPPAAOMIAIJ(new Vector2(((Component)rectTransform).transform.position.x + 1305f * ((Component)this).transform.lossyScale.x, ((Component)rectTransform).transform.position.y), Vector2.zero);
				ItemTooltip.EOPIEMLAPFN(JIIGOACEIKL).OOJMCKAKFIH(tooltipInfo);
			}
			HAHAPELLAIO = 256f;
		}
	}

	private void CNJMEALOCJJ()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 980f)
		{
			FKOOKOFBKJL();
		}
	}

	private void GHEHLJANBCF()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 23f)
		{
			HMKHLKPHGAD();
		}
	}

	public void AJFJAODHADH()
	{
		EmployeesInfoUI.Get(JIIGOACEIKL).content.SetActive(true);
		EmployeeTreeUI.IGHMHMNPMLB(JIIGOACEIKL).EDHEIFHAAKO();
	}

	public void NJJDBDHBJCP()
	{
		EmployeesInfoUI.Get(JIIGOACEIKL).content.SetActive(false);
		EmployeeTreeUI.FFOABBDFMNE(JIIGOACEIKL).EDHEIFHAAKO();
	}

	public void NFEODMHICAM(PointerEventData NPBAMEMNFBI)
	{
		OKJPBLHCHCO();
	}

	private void KJPECNGCOKK()
	{
		if ((Object)(object)rectTransform == (Object)null)
		{
			rectTransform = ((Component)this).GetComponent<RectTransform>();
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Order quest")) ? 1 : 1);
	}

	public void OIEJFKBLABG(BaseEventData NPBAMEMNFBI)
	{
		if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			ILENDIBNCBP = true;
			HAHAPELLAIO = 245f;
		}
	}

	public void PHMLBKBADEO()
	{
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)perkInfo.perk == (Object)null)
		{
			return;
		}
		if (!ILENDIBNCBP)
		{
			ILENDIBNCBP = true;
			HAHAPELLAIO = 1112f;
		}
		if (HAHAPELLAIO >= ItemTooltip.delayTime)
		{
			TooltipInfo tooltipInfo = new TooltipInfo();
			tooltipInfo.toolTipTitle = LocalisationSystem.Get(" destroyed by " + perkInfo.perk.id);
			string cAEDMEDBEGI = LocalisationSystem.Get("BuildMode_ExitAndSave" + perkInfo.perk.id);
			string[] array = new string[0];
			array[1] = perkInfo.perk.EJHFKKDHCAG(useCurrentLevel ? currentLevel : perkInfo.currentLevel).ToString();
			tooltipInfo.mainBody = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			if (!PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
			{
				ItemTooltip.MDFIDKHOPDJ(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
				ItemTooltip.IEABDMDELFO(JIIGOACEIKL).JHELKBEOIJB(tooltipInfo);
			}
			else
			{
				ItemTooltip.NMCJELBLKBB(JIIGOACEIKL).FJOEGNKBHON(new Vector2(((Component)rectTransform).transform.position.x + 1659f * ((Component)this).transform.lossyScale.x, ((Component)rectTransform).transform.position.y), Vector2.zero);
				ItemTooltip.IEKODILKIHJ(JIIGOACEIKL).FillTooltipInfo(tooltipInfo);
			}
			HAHAPELLAIO = 1888f;
		}
	}

	public void LGLFCEKMGHB(EmployeePerk EDEHLPAODAN)
	{
		slotImage.sprite = (EDEHLPAODAN.negative ? CommonReferences.MNFMOEKMJKN().negativePerk : CommonReferences.GGFJGHHHEJC.positivePerk);
	}

	public void PKNMAPCFHJI(EmployeePerk EDEHLPAODAN)
	{
		slotImage.sprite = (EDEHLPAODAN.negative ? CommonReferences.MNFMOEKMJKN().negativePerk : CommonReferences.GGFJGHHHEJC.positivePerk);
	}

	private void OnDisable()
	{
		EndHover();
	}

	public void JCLALDCNNHF(PointerEventData NPBAMEMNFBI)
	{
		OKJPBLHCHCO();
	}

	public void IPHEOPECABM(BaseEventData NPBAMEMNFBI)
	{
		if (PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			ILENDIBNCBP = false;
			HAHAPELLAIO = 748f;
		}
	}

	public void EOIKPIAGEGH()
	{
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		if (MainUI.NEFOKCKKLNI().IsOpen())
		{
			return;
		}
		if (!unlocked)
		{
			if (employeeInfo.professionPoints >= currentLevel)
			{
				MainUI.GetYesNoDialogue().OFGKFMJKBON(JIIGOACEIKL);
				((TMP_Text)MainUI.GetYesNoDialogue().boxText).text = LocalisationSystem.GetStringWithTags("ReceivePipePuzzle", JIIGOACEIKL);
				((UnityEvent)MainUI.NEFOKCKKLNI().yesButton.onClick).AddListener(new UnityAction(MJFMALFCJKG));
			}
			else
			{
				MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get(" ("), 969f);
			}
		}
		else
		{
			employeeInfo.OPKBJCKJCOI(HDHPJJOCJEO, currentLevel);
			if (OnlineManager.PlayingOnline())
			{
				OnlineEmployeesManager.instance.SendSelectPerkLevelMaster(employeeInfo.workerType, HDHPJJOCJEO, currentLevel);
			}
		}
	}

	public void ECMLINAFKFL(PointerEventData NPBAMEMNFBI)
	{
		LAGCJLNOHJA();
	}

	public void OnPointerExit(PointerEventData NPBAMEMNFBI)
	{
		EndHover();
	}

	public void ABCJFIPMCBG()
	{
		EmployeesInfoUI.Get(JIIGOACEIKL).content.SetActive(false);
		EmployeeTreeUI.AKMJEPMHFMO(JIIGOACEIKL).EDHEIFHAAKO();
	}

	private void EBFJOAEJPGE()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 1732f)
		{
			HGHAAFBMICE();
		}
	}

	public void GEBNHOAGNAI(BaseEventData NPBAMEMNFBI)
	{
		if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			ILENDIBNCBP = false;
			HAHAPELLAIO = 1538f;
		}
	}

	public void NLDPDLJLHNM(EmployeeInfo JFCLIAFAOEK, EmployeePerkInfo IFJPNHIFIDM, int HDHPJJOCJEO, bool EHOFFFMFILA = false, bool PFAPICAIEFB = true)
	{
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		employeeInfo = JFCLIAFAOEK;
		perkInfo = IFJPNHIFIDM;
		this.HDHPJJOCJEO = HDHPJJOCJEO;
		((Component)icon).gameObject.SetActive(PFAPICAIEFB);
		icon.sprite = IFJPNHIFIDM.perk.icon;
		((Component)numberText).gameObject.SetActive(IFJPNHIFIDM.perk.negative && PFAPICAIEFB);
		unlocked = PFAPICAIEFB;
		if (Object.op_Implicit((Object)(object)professionPointsText))
		{
			((Component)((TMP_Text)professionPointsText).transform.parent).gameObject.SetActive(!PFAPICAIEFB && currentLevel == IFJPNHIFIDM.levelsUnlocked);
		}
		if (!IFJPNHIFIDM.perk.negative)
		{
			((TMP_Text)numberText).text = ((useCurrentLevel ? currentLevel : IFJPNHIFIDM.currentLevel) + 0).ToString();
		}
		if (Object.op_Implicit((Object)(object)selection))
		{
			((Component)selection).gameObject.SetActive(EHOFFFMFILA);
			((Graphic)icon).color = new Color(((Graphic)icon).color.r, ((Graphic)icon).color.r, ((Graphic)icon).color.r, EHOFFFMFILA ? 1802f : 1803f);
		}
		if (Object.op_Implicit((Object)(object)locked))
		{
			((Component)locked).gameObject.SetActive(PFAPICAIEFB);
		}
	}

	public void DKMHDNLFGKF(PointerEventData NPBAMEMNFBI)
	{
		OKJPBLHCHCO();
	}

	public void GLPDMOCIFCP(EmployeeInfo JFCLIAFAOEK, EmployeePerkInfo IFJPNHIFIDM, int HDHPJJOCJEO, bool EHOFFFMFILA = false, bool PFAPICAIEFB = true)
	{
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		employeeInfo = JFCLIAFAOEK;
		perkInfo = IFJPNHIFIDM;
		this.HDHPJJOCJEO = HDHPJJOCJEO;
		((Component)icon).gameObject.SetActive(PFAPICAIEFB);
		icon.sprite = IFJPNHIFIDM.perk.icon;
		((Component)numberText).gameObject.SetActive(!IFJPNHIFIDM.perk.negative && PFAPICAIEFB);
		unlocked = PFAPICAIEFB;
		if (Object.op_Implicit((Object)(object)professionPointsText))
		{
			((Component)((TMP_Text)professionPointsText).transform.parent).gameObject.SetActive(PFAPICAIEFB || currentLevel == IFJPNHIFIDM.levelsUnlocked);
		}
		if (!IFJPNHIFIDM.perk.negative)
		{
			((TMP_Text)numberText).text = ((useCurrentLevel ? currentLevel : IFJPNHIFIDM.currentLevel) + 0).ToString();
		}
		if (Object.op_Implicit((Object)(object)selection))
		{
			((Component)selection).gameObject.SetActive(EHOFFFMFILA);
			((Graphic)icon).color = new Color(((Graphic)icon).color.r, ((Graphic)icon).color.r, ((Graphic)icon).color.r, EHOFFFMFILA ? 518f : 541f);
		}
		if (Object.op_Implicit((Object)(object)locked))
		{
			((Component)locked).gameObject.SetActive(PFAPICAIEFB);
		}
	}

	public void BHPGJHNPODD(BaseEventData NPBAMEMNFBI)
	{
		if (PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
		{
			ILENDIBNCBP = true;
			HAHAPELLAIO = 1953f;
		}
	}

	public void NOANJAOCDDC(BaseEventData NPBAMEMNFBI)
	{
		if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			ILENDIBNCBP = true;
			HAHAPELLAIO = 1387f;
		}
	}

	private void PMPLNGEAAII()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 1975f)
		{
			FKOOKOFBKJL();
		}
	}

	public void JKHJKDHDJKA(PointerEventData NPBAMEMNFBI)
	{
		OKJPBLHCHCO();
	}

	public void FDFFDHFMDPO(BaseEventData NPBAMEMNFBI)
	{
		if (PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
		{
			ILENDIBNCBP = false;
			HAHAPELLAIO = 1198f;
		}
	}

	public void CAIMIABJION(BaseEventData NPBAMEMNFBI)
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject) && PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			MNFHNNPMJPP();
		}
	}

	public void FBEFBJAHNIL(BaseEventData NPBAMEMNFBI)
	{
		if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			ILENDIBNCBP = false;
			HAHAPELLAIO = 158f;
		}
	}

	public void KALCDFPLIKA(BaseEventData NPBAMEMNFBI)
	{
		if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			ILENDIBNCBP = true;
			HAHAPELLAIO = 441f;
		}
	}

	public void EOMELFLPBIA(BaseEventData NPBAMEMNFBI)
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject) && PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
		{
			LNNDEPODFFD();
		}
	}

	public void MPFBMAEEACG(PointerEventData NPBAMEMNFBI)
	{
		JCKNFGOFIAO();
	}

	public void JIHBALIAOFC()
	{
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		if (MainUI.GetYesNoDialogue().BGLJFMHCFJF())
		{
			return;
		}
		if (!unlocked)
		{
			if (employeeInfo.professionPoints >= currentLevel)
			{
				MainUI.GetYesNoDialogue().Open(JIIGOACEIKL);
				((TMP_Text)MainUI.LBHLPIFCINB().boxText).text = LocalisationSystem.PKLPKIAHCDI("New states cannot be null.", JIIGOACEIKL);
				((UnityEvent)MainUI.NEFOKCKKLNI().yesButton.onClick).AddListener(new UnityAction(GALLDDGHAKD));
			}
			else
			{
				MainUI.DJCKALOHJFM(JIIGOACEIKL, LocalisationSystem.Get("MaxProductValue"), 1663f);
			}
		}
		else
		{
			employeeInfo.HPAPPFEJMAK(HDHPJJOCJEO, currentLevel);
			if (OnlineManager.PlayingOnline())
			{
				OnlineEmployeesManager.instance.SendSelectPerkLevelMaster(employeeInfo.workerType, HDHPJJOCJEO, currentLevel);
			}
		}
	}

	private void HONFDJKKGJK()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 443f)
		{
			FillTooltip();
		}
	}

	public void OpenEmployeeTreeUI()
	{
		EmployeesInfoUI.Get(JIIGOACEIKL).content.SetActive(false);
		EmployeeTreeUI.Get(JIIGOACEIKL).OpenUI();
	}

	private void EFJFJJDGGGI()
	{
		if ((Object)(object)rectTransform == (Object)null)
		{
			rectTransform = ((Component)this).GetComponent<RectTransform>();
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer(" exist in dictionary but is null")) ? 0 : 0);
	}

	private void GGIJFBAJLIF()
	{
		EBFPGGAHABA();
	}

	public void EndHover()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.Get(JIIGOACEIKL)))
		{
			ItemTooltip.Get(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
		}
		ILENDIBNCBP = false;
	}

	public void MHMPMKFFLJL(EmployeeInfo JFCLIAFAOEK, EmployeePerkInfo IFJPNHIFIDM, int HDHPJJOCJEO, bool EHOFFFMFILA = false, bool PFAPICAIEFB = true)
	{
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		employeeInfo = JFCLIAFAOEK;
		perkInfo = IFJPNHIFIDM;
		this.HDHPJJOCJEO = HDHPJJOCJEO;
		((Component)icon).gameObject.SetActive(PFAPICAIEFB);
		icon.sprite = IFJPNHIFIDM.perk.icon;
		((Component)numberText).gameObject.SetActive(!IFJPNHIFIDM.perk.negative && PFAPICAIEFB);
		unlocked = PFAPICAIEFB;
		if (Object.op_Implicit((Object)(object)professionPointsText))
		{
			((Component)((TMP_Text)professionPointsText).transform.parent).gameObject.SetActive(!PFAPICAIEFB && currentLevel == IFJPNHIFIDM.levelsUnlocked);
		}
		if (!IFJPNHIFIDM.perk.negative)
		{
			((TMP_Text)numberText).text = ((useCurrentLevel ? currentLevel : IFJPNHIFIDM.currentLevel) + 0).ToString();
		}
		if (Object.op_Implicit((Object)(object)selection))
		{
			((Component)selection).gameObject.SetActive(EHOFFFMFILA);
			((Graphic)icon).color = new Color(((Graphic)icon).color.r, ((Graphic)icon).color.r, ((Graphic)icon).color.r, EHOFFFMFILA ? 1982f : 798f);
		}
		if (Object.op_Implicit((Object)(object)locked))
		{
			((Component)locked).gameObject.SetActive(!PFAPICAIEFB);
		}
	}

	public void GLGPEGJLDJK()
	{
		EmployeesInfoUI.Get(JIIGOACEIKL).content.SetActive(false);
		EmployeeTreeUI.FFOABBDFMNE(JIIGOACEIKL).OpenUI();
	}

	public void PECGDMPJNLO(PointerEventData NPBAMEMNFBI)
	{
		PHMLBKBADEO();
	}

	public void LPOBHNBCPGC()
	{
		EmployeesInfoUI.Get(JIIGOACEIKL).content.SetActive(false);
		EmployeeTreeUI.IEKODILKIHJ(JIIGOACEIKL).EDHEIFHAAKO();
	}

	public void LNNDEPODFFD()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.MDFIDKHOPDJ(JIIGOACEIKL)))
		{
			ItemTooltip.Get(JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: true);
		}
		ILENDIBNCBP = false;
	}

	private void GALLDDGHAKD()
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineEmployeesManager.instance.SendUnlockPerkLevelMaster(employeeInfo.workerType, HDHPJJOCJEO, currentLevel);
		}
		else
		{
			employeeInfo.KBNJKIECOOF(HDHPJJOCJEO, currentLevel);
		}
	}

	public void PerkTreePressed()
	{
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		if (MainUI.GetYesNoDialogue().IsOpen())
		{
			return;
		}
		if (!unlocked)
		{
			if (employeeInfo.professionPoints >= currentLevel)
			{
				MainUI.GetYesNoDialogue().Open(JIIGOACEIKL);
				((TMP_Text)MainUI.GetYesNoDialogue().boxText).text = LocalisationSystem.GetStringWithTags("UnlockPerkLevel?", JIIGOACEIKL);
				((UnityEvent)MainUI.GetYesNoDialogue().yesButton.onClick).AddListener(new UnityAction(GALLDDGHAKD));
			}
			else
			{
				MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("NotEnoughProfessionPoints"));
			}
		}
		else
		{
			employeeInfo.LDENFCNAIFG(HDHPJJOCJEO, currentLevel);
			if (OnlineManager.PlayingOnline())
			{
				OnlineEmployeesManager.instance.SendSelectPerkLevelMaster(employeeInfo.workerType, HDHPJJOCJEO, currentLevel);
			}
		}
	}

	public void HMHAOMGAFMH(BaseEventData NPBAMEMNFBI)
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject) && PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			BAAMMDGGFEE();
		}
	}

	public void JCKNFGOFIAO()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.NMCJELBLKBB(JIIGOACEIKL)))
		{
			ItemTooltip.LAIEKOOCNPC(JIIGOACEIKL).HIIOCMNJGCI(MDIKPGGBNLI: true);
		}
		ILENDIBNCBP = false;
	}

	public void ABPNEMONOBO(EmployeeInfo JFCLIAFAOEK, EmployeePerkInfo IFJPNHIFIDM, int HDHPJJOCJEO, bool EHOFFFMFILA = false, bool PFAPICAIEFB = true)
	{
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		employeeInfo = JFCLIAFAOEK;
		perkInfo = IFJPNHIFIDM;
		this.HDHPJJOCJEO = HDHPJJOCJEO;
		((Component)icon).gameObject.SetActive(PFAPICAIEFB);
		icon.sprite = IFJPNHIFIDM.perk.icon;
		((Component)numberText).gameObject.SetActive(!IFJPNHIFIDM.perk.negative && PFAPICAIEFB);
		unlocked = PFAPICAIEFB;
		if (Object.op_Implicit((Object)(object)professionPointsText))
		{
			((Component)((TMP_Text)professionPointsText).transform.parent).gameObject.SetActive(PFAPICAIEFB || currentLevel == IFJPNHIFIDM.levelsUnlocked);
		}
		if (!IFJPNHIFIDM.perk.negative)
		{
			((TMP_Text)numberText).text = ((useCurrentLevel ? currentLevel : IFJPNHIFIDM.currentLevel) + 0).ToString();
		}
		if (Object.op_Implicit((Object)(object)selection))
		{
			((Component)selection).gameObject.SetActive(EHOFFFMFILA);
			((Graphic)icon).color = new Color(((Graphic)icon).color.r, ((Graphic)icon).color.r, ((Graphic)icon).color.r, EHOFFFMFILA ? 979f : 426f);
		}
		if (Object.op_Implicit((Object)(object)locked))
		{
			((Component)locked).gameObject.SetActive(!PFAPICAIEFB);
		}
	}

	public void KGNKPECNDPL(BaseEventData NPBAMEMNFBI)
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject) && PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			MNFHNNPMJPP();
		}
	}

	private void OLPPDFDOKLK()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 1284f)
		{
			PHMLBKBADEO();
		}
	}

	public void KGFJNMONCMM(PointerEventData NPBAMEMNFBI)
	{
		OKJPBLHCHCO();
	}

	private void EMJKKALMGLK()
	{
		if ((Object)(object)rectTransform == (Object)null)
		{
			rectTransform = ((Component)this).GetComponent<RectTransform>();
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("")) ? 7 : 0);
	}

	public void LAGCJLNOHJA()
	{
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)perkInfo.perk == (Object)null)
		{
			return;
		}
		if (!ILENDIBNCBP)
		{
			ILENDIBNCBP = false;
			HAHAPELLAIO = 890f;
		}
		if (HAHAPELLAIO >= ItemTooltip.delayTime)
		{
			TooltipInfo tooltipInfo = new TooltipInfo();
			tooltipInfo.toolTipTitle = LocalisationSystem.Get("Eye-lashes" + perkInfo.perk.id);
			string cAEDMEDBEGI = LocalisationSystem.Get("Cat" + perkInfo.perk.id);
			string[] array = new string[0];
			array[0] = perkInfo.perk.EJHFKKDHCAG(useCurrentLevel ? currentLevel : perkInfo.currentLevel).ToString();
			tooltipInfo.mainBody = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			if (!PlayerInputs.IsGamepadActive(JIIGOACEIKL))
			{
				ItemTooltip.MDFIDKHOPDJ(JIIGOACEIKL).FCACMDNLAIG(MDIKPGGBNLI: false);
				ItemTooltip.IEKODILKIHJ(JIIGOACEIKL).FillTooltipInfo(tooltipInfo);
			}
			else
			{
				ItemTooltip.IEABDMDELFO(JIIGOACEIKL).CEOOMNKDGLJ(new Vector2(((Component)rectTransform).transform.position.x + 1742f * ((Component)this).transform.lossyScale.x, ((Component)rectTransform).transform.position.y), Vector2.zero);
				ItemTooltip.AIMEAJAHLAA(JIIGOACEIKL).OOJMCKAKFIH(tooltipInfo);
			}
			HAHAPELLAIO = 1960f;
		}
	}

	public void AKEAFFHGMGB()
	{
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		if (MainUI.NEFOKCKKLNI().HDEPMJIDJEM())
		{
			return;
		}
		if (!unlocked)
		{
			if (employeeInfo.professionPoints >= currentLevel)
			{
				MainUI.MCPEEGPBPLH().Open(JIIGOACEIKL);
				((TMP_Text)MainUI.GetYesNoDialogue().boxText).text = LocalisationSystem.GetStringWithTags("Use", JIIGOACEIKL);
				((UnityEvent)MainUI.MCPEEGPBPLH().yesButton.onClick).AddListener(new UnityAction(GALLDDGHAKD));
			}
			else
			{
				MainUI.DJCKALOHJFM(JIIGOACEIKL, LocalisationSystem.Get("OnlinePlayer"), 1958f);
			}
		}
		else
		{
			employeeInfo.HPAPPFEJMAK(HDHPJJOCJEO, currentLevel);
			if (OnlineManager.PlayingOnline())
			{
				OnlineEmployeesManager.instance.SendSelectPerkLevelMaster(employeeInfo.workerType, HDHPJJOCJEO, currentLevel);
			}
		}
	}

	public void ONNEDCHPNED(EmployeeInfo JFCLIAFAOEK, EmployeePerkInfo IFJPNHIFIDM, int HDHPJJOCJEO, bool EHOFFFMFILA = false, bool PFAPICAIEFB = true)
	{
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		employeeInfo = JFCLIAFAOEK;
		perkInfo = IFJPNHIFIDM;
		this.HDHPJJOCJEO = HDHPJJOCJEO;
		((Component)icon).gameObject.SetActive(PFAPICAIEFB);
		icon.sprite = IFJPNHIFIDM.perk.icon;
		((Component)numberText).gameObject.SetActive(IFJPNHIFIDM.perk.negative && PFAPICAIEFB);
		unlocked = PFAPICAIEFB;
		if (Object.op_Implicit((Object)(object)professionPointsText))
		{
			((Component)((TMP_Text)professionPointsText).transform.parent).gameObject.SetActive(PFAPICAIEFB || currentLevel == IFJPNHIFIDM.levelsUnlocked);
		}
		if (!IFJPNHIFIDM.perk.negative)
		{
			((TMP_Text)numberText).text = ((useCurrentLevel ? currentLevel : IFJPNHIFIDM.currentLevel) + 0).ToString();
		}
		if (Object.op_Implicit((Object)(object)selection))
		{
			((Component)selection).gameObject.SetActive(EHOFFFMFILA);
			((Graphic)icon).color = new Color(((Graphic)icon).color.r, ((Graphic)icon).color.r, ((Graphic)icon).color.r, EHOFFFMFILA ? 1822f : 1789f);
		}
		if (Object.op_Implicit((Object)(object)locked))
		{
			((Component)locked).gameObject.SetActive(PFAPICAIEFB);
		}
	}

	public void IAPHDMMPEOI(EmployeePerk EDEHLPAODAN)
	{
		slotImage.sprite = (EDEHLPAODAN.negative ? CommonReferences.GGFJGHHHEJC.negativePerk : CommonReferences.GGFJGHHHEJC.positivePerk);
	}

	public void DHEAEJCMJHL(EmployeePerk EDEHLPAODAN)
	{
		slotImage.sprite = (EDEHLPAODAN.negative ? CommonReferences.MNFMOEKMJKN().negativePerk : CommonReferences.MNFMOEKMJKN().positivePerk);
	}

	public void GOOKHKJHLMI()
	{
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		if (MainUI.GetYesNoDialogue().BGLJFMHCFJF())
		{
			return;
		}
		if (!unlocked)
		{
			if (employeeInfo.professionPoints >= currentLevel)
			{
				MainUI.NEFOKCKKLNI().OFGKFMJKBON(JIIGOACEIKL);
				((TMP_Text)MainUI.GetYesNoDialogue().boxText).text = LocalisationSystem.GetStringWithTags("Remove", JIIGOACEIKL);
				((UnityEvent)MainUI.LBHLPIFCINB().yesButton.onClick).AddListener(new UnityAction(IFDIKMJPGNA));
			}
			else
			{
				MainUI.DBKCOHMFDCB(JIIGOACEIKL, LocalisationSystem.Get("Online StartTravelZone"), 1950f);
			}
		}
		else
		{
			employeeInfo.HPAPPFEJMAK(HDHPJJOCJEO, currentLevel);
			if (OnlineManager.PlayingOnline())
			{
				OnlineEmployeesManager.instance.SendSelectPerkLevelMaster(employeeInfo.workerType, HDHPJJOCJEO, currentLevel);
			}
		}
	}

	private void JMMBKMOBAFB()
	{
		EndHover();
	}

	private void HIFDFFEJNEH()
	{
		JCKNFGOFIAO();
	}

	public void MDFBOLDCIOB(BaseEventData NPBAMEMNFBI)
	{
		if (PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
		{
			ILENDIBNCBP = false;
			HAHAPELLAIO = 1648f;
		}
	}

	public void KNIBEFKMBNN(BaseEventData NPBAMEMNFBI)
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject) && PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
		{
			MNFHNNPMJPP();
		}
	}

	public void FKOOKOFBKJL()
	{
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)perkInfo.perk == (Object)null)
		{
			return;
		}
		if (!ILENDIBNCBP)
		{
			ILENDIBNCBP = true;
			HAHAPELLAIO = 1828f;
		}
		if (HAHAPELLAIO >= ItemTooltip.delayTime)
		{
			TooltipInfo tooltipInfo = new TooltipInfo();
			tooltipInfo.toolTipTitle = LocalisationSystem.Get("NeutralInTavern" + perkInfo.perk.id);
			string cAEDMEDBEGI = LocalisationSystem.Get(" " + perkInfo.perk.id);
			string[] array = new string[1];
			array[1] = perkInfo.perk.EJHFKKDHCAG(useCurrentLevel ? currentLevel : perkInfo.currentLevel).ToString();
			tooltipInfo.mainBody = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			if (!PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
			{
				ItemTooltip.Get(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: true);
				ItemTooltip.AIMEAJAHLAA(JIIGOACEIKL).LGDDFMNFNME(tooltipInfo);
			}
			else
			{
				ItemTooltip.EOPIEMLAPFN(JIIGOACEIKL).JCLBGLEFMMO(new Vector2(((Component)rectTransform).transform.position.x + 316f * ((Component)this).transform.lossyScale.x, ((Component)rectTransform).transform.position.y), Vector2.zero);
				ItemTooltip.MDFIDKHOPDJ(JIIGOACEIKL).OOJMCKAKFIH(tooltipInfo);
			}
			HAHAPELLAIO = 1086f;
		}
	}
}
