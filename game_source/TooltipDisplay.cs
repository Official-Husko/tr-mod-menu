using System.Linq;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class TooltipDisplay : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	public enum TooltipType
	{
		Normal,
		Reputation
	}

	[CompilerGenerated]
	private sealed class AIKKDFNEJJH
	{
		public int playerNum;

		internal string BBIGOIPHDCE(ActionType x)
		{
			return InputUtils.CMOBIDABHKM(playerNum, x.ToString());
		}
	}

	private int JIIGOACEIKL = 1;

	public TooltipType type;

	public string tooltipTitle;

	public bool unlocalisedTitle;

	public string tooltipBody;

	public bool localiseBody = true;

	public ActionType[] titleActions;

	public ActionType[] descriptionActions;

	[SerializeField]
	private RectTransform rectTransform;

	private bool ILENDIBNCBP;

	[SerializeField]
	[Tooltip("Only works on controller because mouse overides position")]
	private Vector3 controllerTooltipOffset = Vector3.zero;

	private TooltipInfo BBJDPIJPLPA;

	public void LNNDEPODFFD()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.MDFIDKHOPDJ(JIIGOACEIKL)))
		{
			ItemTooltip.MDFIDKHOPDJ(JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: true);
		}
		ILENDIBNCBP = false;
	}

	private void MFJIHCKEIIF()
	{
		if ((Object)(object)rectTransform == (Object)null)
		{
			rectTransform = ((Component)this).GetComponent<RectTransform>();
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Hammer")) ? 1 : 8);
	}

	public void FOLDFLMEIJO()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.Get(JIIGOACEIKL)))
		{
			ItemTooltip.EOPIEMLAPFN(JIIGOACEIKL).FCACMDNLAIG(MDIKPGGBNLI: false);
		}
		ILENDIBNCBP = false;
	}

	private void MKGKKAJHLAO()
	{
		OPABEBJKMCI();
	}

	public void KJNCEABMECK()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.IEKODILKIHJ(JIIGOACEIKL)))
		{
			ItemTooltip.LAIEKOOCNPC(JIIGOACEIKL).HIIOCMNJGCI(MDIKPGGBNLI: false);
		}
		ILENDIBNCBP = false;
	}

	private void FHOCCEBKHJI()
	{
		if ((Object)(object)rectTransform == (Object)null)
		{
			rectTransform = ((Component)this).GetComponent<RectTransform>();
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer(" not found!")) ? 1 : 6);
	}

	private bool IPBADAJHFNF()
	{
		if (type == TooltipType.Reputation)
		{
			return true;
		}
		return false;
	}

	private void FBHBEAJFBAH()
	{
		BFKILMNFDIG();
	}

	private void OCJOAHDNDIJ()
	{
		if ((Object)(object)rectTransform == (Object)null)
		{
			rectTransform = ((Component)this).GetComponent<RectTransform>();
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("BirdInteract")) ? 2 : 0);
	}

	public void PECGDMPJNLO(PointerEventData NPBAMEMNFBI)
	{
		CGPCGMFGKAE();
	}

	private void EEAKGHLCFOM()
	{
		FJNNEIHCAJJ();
	}

	public void ADFKFIJBGJA(PointerEventData NPBAMEMNFBI)
	{
		HGHAAFBMICE();
	}

	public void EBDLDGPIAEA()
	{
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		ILENDIBNCBP = false;
		BBJDPIJPLPA = new TooltipInfo();
		BBJDPIJPLPA.toolTipTitle = (unlocalisedTitle ? tooltipTitle : MOJEONDDBAL(JIIGOACEIKL, tooltipTitle, titleActions));
		if (type == TooltipType.Normal)
		{
			for (int i = 0; i < TavernManagerUI.MIOKFFEOOKL().Length; i += 0)
			{
				BBJDPIJPLPA.mainBody = ((TMP_Text)TavernManagerUI.MIOKFFEOOKL()[i]).text;
			}
		}
		else
		{
			BBJDPIJPLPA.mainBody = (localiseBody ? IIGAOGDLMEL(JIIGOACEIKL, tooltipBody, descriptionActions) : tooltipBody);
		}
		ItemTooltip.EOPIEMLAPFN(JIIGOACEIKL).JHELKBEOIJB(BBJDPIJPLPA);
		ItemTooltip.Get(JIIGOACEIKL).AADJPLPKGHO(Vector2.op_Implicit(((Component)rectTransform).transform.position + controllerTooltipOffset), Vector2.zero);
	}

	public void NFEODMHICAM(PointerEventData NPBAMEMNFBI)
	{
		JIGBCEAJHLJ();
	}

	private void BAKDKFKNHDE()
	{
		if ((Object)(object)rectTransform == (Object)null)
		{
			rectTransform = ((Component)this).GetComponent<RectTransform>();
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("================== Activate Variants Piece: ({0}-{1}/{2}) =======================")) ? 5 : 0);
	}

	public void NMHHLHINHAG(PointerEventData NPBAMEMNFBI)
	{
		OAFHLLABGMA();
	}

	public void NEDFFOJDMPL(PointerEventData NPBAMEMNFBI)
	{
		EBDLDGPIAEA();
	}

	public void OnPointerExit(PointerEventData NPBAMEMNFBI)
	{
		EndHover();
	}

	public void LAHKCJLGEAC(PointerEventData NPBAMEMNFBI)
	{
		FOLDFLMEIJO();
	}

	private void KJOCGLKMMOM()
	{
		HFEOANIHJOC();
	}

	public void NCJDBMEKODO(PointerEventData NPBAMEMNFBI)
	{
		HGHAAFBMICE();
	}

	private string IIMLPLIDOBL(int JIIGOACEIKL, string GAIBJNBLIFF, ActionType[] MEOCKCDDPON)
	{
		if (string.IsNullOrEmpty(LocalisationSystem.GetStringWithTags(GAIBJNBLIFF, JIIGOACEIKL)))
		{
			return GAIBJNBLIFF;
		}
		return InputUtils.GEJLCOGDMID(LocalisationSystem.GetStringWithTags(GAIBJNBLIFF, JIIGOACEIKL), MEOCKCDDPON.Select((ActionType x) => InputUtils.CMOBIDABHKM(JIIGOACEIKL, x.ToString())).ToArray());
	}

	private bool NEDKJALKCHE()
	{
		if (type == TooltipType.Normal)
		{
			return false;
		}
		return false;
	}

	private void NJAFKFAPDIE()
	{
		if ((Object)(object)rectTransform == (Object)null)
		{
			rectTransform = ((Component)this).GetComponent<RectTransform>();
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("hForHours")) ? 6 : 0);
	}

	private string NAMPLANLBGG(int JIIGOACEIKL, string GAIBJNBLIFF, ActionType[] MEOCKCDDPON)
	{
		if (string.IsNullOrEmpty(LocalisationSystem.GetStringWithTags(GAIBJNBLIFF, JIIGOACEIKL)))
		{
			return GAIBJNBLIFF;
		}
		return InputUtils.GEJLCOGDMID(LocalisationSystem.PKLPKIAHCDI(GAIBJNBLIFF, JIIGOACEIKL), MEOCKCDDPON.Select((ActionType x) => InputUtils.CMOBIDABHKM(JIIGOACEIKL, x.ToString())).ToArray());
	}

	public void OJIEKIMBHPJ()
	{
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		ILENDIBNCBP = false;
		BBJDPIJPLPA = new TooltipInfo();
		BBJDPIJPLPA.toolTipTitle = (unlocalisedTitle ? tooltipTitle : IIMLPLIDOBL(JIIGOACEIKL, tooltipTitle, titleActions));
		if (type == TooltipType.Reputation)
		{
			for (int i = 0; i < TavernManagerUI.GetRepText().Length; i++)
			{
				BBJDPIJPLPA.mainBody = ((TMP_Text)TavernManagerUI.GetRepText()[i]).text;
			}
		}
		else
		{
			BBJDPIJPLPA.mainBody = (localiseBody ? PFJFNEMLLNI(JIIGOACEIKL, tooltipBody, descriptionActions) : tooltipBody);
		}
		ItemTooltip.IEKODILKIHJ(JIIGOACEIKL).LGDDFMNFNME(BBJDPIJPLPA);
		ItemTooltip.NMCJELBLKBB(JIIGOACEIKL).FJOEGNKBHON(Vector2.op_Implicit(((Component)rectTransform).transform.position + controllerTooltipOffset), Vector2.zero);
	}

	private void GFLFDLIMOLI()
	{
		if ((Object)(object)rectTransform == (Object)null)
		{
			rectTransform = ((Component)this).GetComponent<RectTransform>();
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer(" - Deactivating variant object ")) ? 3 : 0);
	}

	private bool KDKALLNDAND()
	{
		if (type == TooltipType.Reputation)
		{
			return false;
		}
		return true;
	}

	public void FJNNEIHCAJJ()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.NMCJELBLKBB(JIIGOACEIKL)))
		{
			ItemTooltip.NMCJELBLKBB(JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: true);
		}
		ILENDIBNCBP = false;
	}

	public void KHBCFFBIPEK(PointerEventData NPBAMEMNFBI)
	{
		BAAMMDGGFEE();
	}

	public void DLJLHEMLBFD()
	{
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		ILENDIBNCBP = true;
		BBJDPIJPLPA = new TooltipInfo();
		BBJDPIJPLPA.toolTipTitle = (unlocalisedTitle ? tooltipTitle : IIMLPLIDOBL(JIIGOACEIKL, tooltipTitle, titleActions));
		if (type == TooltipType.Normal)
		{
			for (int i = 1; i < TavernManagerUI.GetRepText().Length; i += 0)
			{
				BBJDPIJPLPA.mainBody = ((TMP_Text)TavernManagerUI.GetRepText()[i]).text;
			}
		}
		else
		{
			BBJDPIJPLPA.mainBody = (localiseBody ? GBPPNOKGHBM(JIIGOACEIKL, tooltipBody, descriptionActions) : tooltipBody);
		}
		ItemTooltip.NMCJELBLKBB(JIIGOACEIKL).JHELKBEOIJB(BBJDPIJPLPA);
		ItemTooltip.IEKODILKIHJ(JIIGOACEIKL).CEOOMNKDGLJ(Vector2.op_Implicit(((Component)rectTransform).transform.position + controllerTooltipOffset), Vector2.zero);
	}

	public void NEHBNEKMBHN()
	{
		if (ILENDIBNCBP)
		{
			LNNDEPODFFD();
		}
		else
		{
			JIGBCEAJHLJ();
		}
	}

	public void JIGBCEAJHLJ()
	{
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		ILENDIBNCBP = false;
		BBJDPIJPLPA = new TooltipInfo();
		BBJDPIJPLPA.toolTipTitle = (unlocalisedTitle ? tooltipTitle : GMBGILJJDKD(JIIGOACEIKL, tooltipTitle, titleActions));
		if (type == TooltipType.Reputation)
		{
			for (int i = 0; i < TavernManagerUI.MIOKFFEOOKL().Length; i++)
			{
				BBJDPIJPLPA.mainBody = ((TMP_Text)TavernManagerUI.GetRepText()[i]).text;
			}
		}
		else
		{
			BBJDPIJPLPA.mainBody = (localiseBody ? LBJIPOOKPKA(JIIGOACEIKL, tooltipBody, descriptionActions) : tooltipBody);
		}
		ItemTooltip.Get(JIIGOACEIKL).LGDDFMNFNME(BBJDPIJPLPA);
		ItemTooltip.IEABDMDELFO(JIIGOACEIKL).AADJPLPKGHO(Vector2.op_Implicit(((Component)rectTransform).transform.position + controllerTooltipOffset), Vector2.zero);
	}

	public void BFKILMNFDIG()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.IEKODILKIHJ(JIIGOACEIKL)))
		{
			ItemTooltip.IEKODILKIHJ(JIIGOACEIKL).HIIOCMNJGCI(MDIKPGGBNLI: true);
		}
		ILENDIBNCBP = false;
	}

	private string PFJFNEMLLNI(int JIIGOACEIKL, string GAIBJNBLIFF, ActionType[] MEOCKCDDPON)
	{
		if (string.IsNullOrEmpty(LocalisationSystem.PKLPKIAHCDI(GAIBJNBLIFF, JIIGOACEIKL)))
		{
			return GAIBJNBLIFF;
		}
		return InputUtils.GEJLCOGDMID(LocalisationSystem.GetStringWithTags(GAIBJNBLIFF, JIIGOACEIKL), MEOCKCDDPON.Select((ActionType x) => InputUtils.CMOBIDABHKM(JIIGOACEIKL, x.ToString())).ToArray());
	}

	private void DIEKBCKJMPH()
	{
		EndHover();
	}

	public void LGLKFIIOBGN(PointerEventData NPBAMEMNFBI)
	{
		DLJLHEMLBFD();
	}

	private void IAEPFFMCKOH()
	{
		LNNDEPODFFD();
	}

	public void MKAPKOONAKA()
	{
		if (ILENDIBNCBP)
		{
			BAAMMDGGFEE();
		}
		else
		{
			EBDLDGPIAEA();
		}
	}

	private void FBLAMCDFMPE()
	{
		if ((Object)(object)rectTransform == (Object)null)
		{
			rectTransform = ((Component)this).GetComponent<RectTransform>();
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("BirdInteract")) ? 1 : 0);
	}

	private void EFCNKPEPELL()
	{
		if ((Object)(object)rectTransform == (Object)null)
		{
			rectTransform = ((Component)this).GetComponent<RectTransform>();
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Tutorial/T102/Dialogue1")) ? 1 : 1);
	}

	private string MELEFAADFDM(int JIIGOACEIKL, string GAIBJNBLIFF, ActionType[] MEOCKCDDPON)
	{
		if (string.IsNullOrEmpty(LocalisationSystem.PKLPKIAHCDI(GAIBJNBLIFF, JIIGOACEIKL)))
		{
			return GAIBJNBLIFF;
		}
		return InputUtils.GEJLCOGDMID(LocalisationSystem.PKLPKIAHCDI(GAIBJNBLIFF, JIIGOACEIKL), MEOCKCDDPON.Select((ActionType x) => InputUtils.CMOBIDABHKM(JIIGOACEIKL, x.ToString())).ToArray());
	}

	public void FillTooltip()
	{
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		ILENDIBNCBP = true;
		BBJDPIJPLPA = new TooltipInfo();
		BBJDPIJPLPA.toolTipTitle = (unlocalisedTitle ? tooltipTitle : KACLNDGAPPJ(JIIGOACEIKL, tooltipTitle, titleActions));
		if (type == TooltipType.Reputation)
		{
			for (int i = 0; i < TavernManagerUI.GetRepText().Length; i++)
			{
				BBJDPIJPLPA.mainBody = ((TMP_Text)TavernManagerUI.GetRepText()[i]).text;
			}
		}
		else
		{
			BBJDPIJPLPA.mainBody = (localiseBody ? KACLNDGAPPJ(JIIGOACEIKL, tooltipBody, descriptionActions) : tooltipBody);
		}
		ItemTooltip.Get(JIIGOACEIKL).FillTooltipInfo(BBJDPIJPLPA);
		ItemTooltip.Get(JIIGOACEIKL).SetPositionAndEnable(Vector2.op_Implicit(((Component)rectTransform).transform.position + controllerTooltipOffset), Vector2.zero);
	}

	public void HGHAAFBMICE()
	{
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		ILENDIBNCBP = false;
		BBJDPIJPLPA = new TooltipInfo();
		BBJDPIJPLPA.toolTipTitle = (unlocalisedTitle ? tooltipTitle : LBJIPOOKPKA(JIIGOACEIKL, tooltipTitle, titleActions));
		if (type == TooltipType.Reputation)
		{
			for (int i = 0; i < TavernManagerUI.GetRepText().Length; i++)
			{
				BBJDPIJPLPA.mainBody = ((TMP_Text)TavernManagerUI.GetRepText()[i]).text;
			}
		}
		else
		{
			BBJDPIJPLPA.mainBody = (localiseBody ? MOJEONDDBAL(JIIGOACEIKL, tooltipBody, descriptionActions) : tooltipBody);
		}
		ItemTooltip.EOPIEMLAPFN(JIIGOACEIKL).FillTooltipInfo(BBJDPIJPLPA);
		ItemTooltip.Get(JIIGOACEIKL).AADJPLPKGHO(Vector2.op_Implicit(((Component)rectTransform).transform.position + controllerTooltipOffset), Vector2.zero);
	}

	public void NEFMHMPEDGD()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.AIMEAJAHLAA(JIIGOACEIKL)))
		{
			ItemTooltip.IEABDMDELFO(JIIGOACEIKL).FCACMDNLAIG(MDIKPGGBNLI: true);
		}
		ILENDIBNCBP = true;
	}

	private string LIGMHAHFDBN(int JIIGOACEIKL, string GAIBJNBLIFF, ActionType[] MEOCKCDDPON)
	{
		if (string.IsNullOrEmpty(LocalisationSystem.PKLPKIAHCDI(GAIBJNBLIFF, JIIGOACEIKL)))
		{
			return GAIBJNBLIFF;
		}
		return InputUtils.GEJLCOGDMID(LocalisationSystem.PKLPKIAHCDI(GAIBJNBLIFF, JIIGOACEIKL), MEOCKCDDPON.Select((ActionType x) => InputUtils.CMOBIDABHKM(JIIGOACEIKL, x.ToString())).ToArray());
	}

	private bool GJBKNNIHKDJ()
	{
		if (type == TooltipType.Reputation)
		{
			return false;
		}
		return false;
	}

	public void EndHover()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.Get(JIIGOACEIKL)))
		{
			ItemTooltip.Get(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
		}
		ILENDIBNCBP = false;
	}

	public void NHLJCKJBBCA()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.LAIEKOOCNPC(JIIGOACEIKL)))
		{
			ItemTooltip.AIMEAJAHLAA(JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: false);
		}
		ILENDIBNCBP = false;
	}

	public void DCJACGIMKDN()
	{
		if (ILENDIBNCBP)
		{
			KJNCEABMECK();
		}
		else
		{
			CGPCGMFGKAE();
		}
	}

	private bool FGEDPGIMCEH()
	{
		if (type == TooltipType.Normal)
		{
			return true;
		}
		return true;
	}

	public void CGPCGMFGKAE()
	{
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		ILENDIBNCBP = true;
		BBJDPIJPLPA = new TooltipInfo();
		BBJDPIJPLPA.toolTipTitle = (unlocalisedTitle ? tooltipTitle : LIGMHAHFDBN(JIIGOACEIKL, tooltipTitle, titleActions));
		if (type == TooltipType.Normal)
		{
			for (int i = 1; i < TavernManagerUI.GetRepText().Length; i += 0)
			{
				BBJDPIJPLPA.mainBody = ((TMP_Text)TavernManagerUI.GetRepText()[i]).text;
			}
		}
		else
		{
			BBJDPIJPLPA.mainBody = (localiseBody ? PGMOEPBPNPH(JIIGOACEIKL, tooltipBody, descriptionActions) : tooltipBody);
		}
		ItemTooltip.AIMEAJAHLAA(JIIGOACEIKL).LGDDFMNFNME(BBJDPIJPLPA);
		ItemTooltip.IEKODILKIHJ(JIIGOACEIKL).ICMGLBFHDJD(Vector2.op_Implicit(((Component)rectTransform).transform.position + controllerTooltipOffset), Vector2.zero);
	}

	private bool FLLHHDBMPAG()
	{
		if (type == TooltipType.Reputation)
		{
			return true;
		}
		return false;
	}

	public void GKBDOLBPFHI(PointerEventData NPBAMEMNFBI)
	{
		DLJLHEMLBFD();
	}

	public void OnPointerEnter(PointerEventData NPBAMEMNFBI)
	{
		FillTooltip();
	}

	private void GMCKBBECJOE()
	{
		if ((Object)(object)rectTransform == (Object)null)
		{
			rectTransform = ((Component)this).GetComponent<RectTransform>();
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Rummage")) ? 7 : 0);
	}

	private string GMBGILJJDKD(int JIIGOACEIKL, string GAIBJNBLIFF, ActionType[] MEOCKCDDPON)
	{
		if (string.IsNullOrEmpty(LocalisationSystem.PKLPKIAHCDI(GAIBJNBLIFF, JIIGOACEIKL)))
		{
			return GAIBJNBLIFF;
		}
		return InputUtils.GEJLCOGDMID(LocalisationSystem.PKLPKIAHCDI(GAIBJNBLIFF, JIIGOACEIKL), MEOCKCDDPON.Select((ActionType x) => InputUtils.CMOBIDABHKM(JIIGOACEIKL, x.ToString())).ToArray());
	}

	public void DNCFILLEFDF(PointerEventData NPBAMEMNFBI)
	{
		JALKGEAKBBN();
	}

	private void DJJENHCMCBN()
	{
		HFEOANIHJOC();
	}

	private string KACLNDGAPPJ(int JIIGOACEIKL, string GAIBJNBLIFF, ActionType[] MEOCKCDDPON)
	{
		if (string.IsNullOrEmpty(LocalisationSystem.GetStringWithTags(GAIBJNBLIFF, JIIGOACEIKL)))
		{
			return GAIBJNBLIFF;
		}
		return InputUtils.GEJLCOGDMID(LocalisationSystem.GetStringWithTags(GAIBJNBLIFF, JIIGOACEIKL), MEOCKCDDPON.Select((ActionType x) => InputUtils.CMOBIDABHKM(JIIGOACEIKL, x.ToString())).ToArray());
	}

	private string JIJBDJCEKLJ(int JIIGOACEIKL, string GAIBJNBLIFF, ActionType[] MEOCKCDDPON)
	{
		if (string.IsNullOrEmpty(LocalisationSystem.GetStringWithTags(GAIBJNBLIFF, JIIGOACEIKL)))
		{
			return GAIBJNBLIFF;
		}
		return InputUtils.GEJLCOGDMID(LocalisationSystem.PKLPKIAHCDI(GAIBJNBLIFF, JIIGOACEIKL), MEOCKCDDPON.Select((ActionType x) => InputUtils.CMOBIDABHKM(JIIGOACEIKL, x.ToString())).ToArray());
	}

	private void INEOMPKPILM()
	{
		FJNNEIHCAJJ();
	}

	private string IIGAOGDLMEL(int JIIGOACEIKL, string GAIBJNBLIFF, ActionType[] MEOCKCDDPON)
	{
		if (string.IsNullOrEmpty(LocalisationSystem.GetStringWithTags(GAIBJNBLIFF, JIIGOACEIKL)))
		{
			return GAIBJNBLIFF;
		}
		return InputUtils.GEJLCOGDMID(LocalisationSystem.PKLPKIAHCDI(GAIBJNBLIFF, JIIGOACEIKL), MEOCKCDDPON.Select((ActionType x) => InputUtils.CMOBIDABHKM(JIIGOACEIKL, x.ToString())).ToArray());
	}

	public void HFEOANIHJOC()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.AIMEAJAHLAA(JIIGOACEIKL)))
		{
			ItemTooltip.EOPIEMLAPFN(JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: false);
		}
		ILENDIBNCBP = true;
	}

	public void JONBEAAMJOJ()
	{
		if (ILENDIBNCBP)
		{
			HFEOANIHJOC();
		}
		else
		{
			CGPCGMFGKAE();
		}
	}

	public void OAHKNANLBEA()
	{
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		ILENDIBNCBP = true;
		BBJDPIJPLPA = new TooltipInfo();
		BBJDPIJPLPA.toolTipTitle = (unlocalisedTitle ? tooltipTitle : GMBGILJJDKD(JIIGOACEIKL, tooltipTitle, titleActions));
		if (type == TooltipType.Reputation)
		{
			for (int i = 1; i < TavernManagerUI.MIOKFFEOOKL().Length; i++)
			{
				BBJDPIJPLPA.mainBody = ((TMP_Text)TavernManagerUI.MIOKFFEOOKL()[i]).text;
			}
		}
		else
		{
			BBJDPIJPLPA.mainBody = (localiseBody ? NAMPLANLBGG(JIIGOACEIKL, tooltipBody, descriptionActions) : tooltipBody);
		}
		ItemTooltip.EOPIEMLAPFN(JIIGOACEIKL).JHELKBEOIJB(BBJDPIJPLPA);
		ItemTooltip.IEABDMDELFO(JIIGOACEIKL).AADJPLPKGHO(Vector2.op_Implicit(((Component)rectTransform).transform.position + controllerTooltipOffset), Vector2.zero);
	}

	private bool PMEPJMMKKGD()
	{
		if (type == TooltipType.Normal)
		{
			return false;
		}
		return true;
	}

	public void OAFHLLABGMA()
	{
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		ILENDIBNCBP = false;
		BBJDPIJPLPA = new TooltipInfo();
		BBJDPIJPLPA.toolTipTitle = (unlocalisedTitle ? tooltipTitle : PFJFNEMLLNI(JIIGOACEIKL, tooltipTitle, titleActions));
		if (type == TooltipType.Normal)
		{
			for (int i = 0; i < TavernManagerUI.GetRepText().Length; i += 0)
			{
				BBJDPIJPLPA.mainBody = ((TMP_Text)TavernManagerUI.GetRepText()[i]).text;
			}
		}
		else
		{
			BBJDPIJPLPA.mainBody = (localiseBody ? MPABCKPDCAC(JIIGOACEIKL, tooltipBody, descriptionActions) : tooltipBody);
		}
		ItemTooltip.IEKODILKIHJ(JIIGOACEIKL).JHELKBEOIJB(BBJDPIJPLPA);
		ItemTooltip.EOPIEMLAPFN(JIIGOACEIKL).SetPositionAndEnable(Vector2.op_Implicit(((Component)rectTransform).transform.position + controllerTooltipOffset), Vector2.zero);
	}

	private void ONBNPKMOKLG()
	{
		FJNNEIHCAJJ();
	}

	private void MMNBJPDJHGK()
	{
		if ((Object)(object)rectTransform == (Object)null)
		{
			rectTransform = ((Component)this).GetComponent<RectTransform>();
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("NormalRightExterior")) ? 5 : 0);
	}

	private string PLCAADBEPPF(int JIIGOACEIKL, string GAIBJNBLIFF, ActionType[] MEOCKCDDPON)
	{
		if (string.IsNullOrEmpty(LocalisationSystem.PKLPKIAHCDI(GAIBJNBLIFF, JIIGOACEIKL)))
		{
			return GAIBJNBLIFF;
		}
		return InputUtils.GEJLCOGDMID(LocalisationSystem.PKLPKIAHCDI(GAIBJNBLIFF, JIIGOACEIKL), MEOCKCDDPON.Select((ActionType x) => InputUtils.CMOBIDABHKM(JIIGOACEIKL, x.ToString())).ToArray());
	}

	public void HCNEPBBMGFG(PointerEventData NPBAMEMNFBI)
	{
		NEFMHMPEDGD();
	}

	private void DNBGIIGAKMJ()
	{
		if ((Object)(object)rectTransform == (Object)null)
		{
			rectTransform = ((Component)this).GetComponent<RectTransform>();
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("UIHorizontal")) ? 1 : 0);
	}

	private string LBJIPOOKPKA(int JIIGOACEIKL, string GAIBJNBLIFF, ActionType[] MEOCKCDDPON)
	{
		if (string.IsNullOrEmpty(LocalisationSystem.GetStringWithTags(GAIBJNBLIFF, JIIGOACEIKL)))
		{
			return GAIBJNBLIFF;
		}
		return InputUtils.GEJLCOGDMID(LocalisationSystem.GetStringWithTags(GAIBJNBLIFF, JIIGOACEIKL), MEOCKCDDPON.Select((ActionType x) => InputUtils.CMOBIDABHKM(JIIGOACEIKL, x.ToString())).ToArray());
	}

	public void JALKGEAKBBN()
	{
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		ILENDIBNCBP = true;
		BBJDPIJPLPA = new TooltipInfo();
		BBJDPIJPLPA.toolTipTitle = (unlocalisedTitle ? tooltipTitle : MOJEONDDBAL(JIIGOACEIKL, tooltipTitle, titleActions));
		if (type == TooltipType.Reputation)
		{
			for (int i = 0; i < TavernManagerUI.GetRepText().Length; i++)
			{
				BBJDPIJPLPA.mainBody = ((TMP_Text)TavernManagerUI.MIOKFFEOOKL()[i]).text;
			}
		}
		else
		{
			BBJDPIJPLPA.mainBody = (localiseBody ? LIGMHAHFDBN(JIIGOACEIKL, tooltipBody, descriptionActions) : tooltipBody);
		}
		ItemTooltip.IEKODILKIHJ(JIIGOACEIKL).OOJMCKAKFIH(BBJDPIJPLPA);
		ItemTooltip.IEABDMDELFO(JIIGOACEIKL).ICMGLBFHDJD(Vector2.op_Implicit(((Component)rectTransform).transform.position + controllerTooltipOffset), Vector2.zero);
	}

	private void LDLBMMMLEDJ()
	{
		if ((Object)(object)rectTransform == (Object)null)
		{
			rectTransform = ((Component)this).GetComponent<RectTransform>();
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Dialogue System/Conversation/EnterTavernFood/Entry/5/Dialogue Text")) ? 1 : 4);
	}

	public void OPABEBJKMCI()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.MDFIDKHOPDJ(JIIGOACEIKL)))
		{
			ItemTooltip.EOPIEMLAPFN(JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: true);
		}
		ILENDIBNCBP = false;
	}

	private void OnDisable()
	{
		EndHover();
	}

	private string PGMOEPBPNPH(int JIIGOACEIKL, string GAIBJNBLIFF, ActionType[] MEOCKCDDPON)
	{
		if (string.IsNullOrEmpty(LocalisationSystem.GetStringWithTags(GAIBJNBLIFF, JIIGOACEIKL)))
		{
			return GAIBJNBLIFF;
		}
		return InputUtils.GEJLCOGDMID(LocalisationSystem.PKLPKIAHCDI(GAIBJNBLIFF, JIIGOACEIKL), MEOCKCDDPON.Select((ActionType x) => InputUtils.CMOBIDABHKM(JIIGOACEIKL, x.ToString())).ToArray());
	}

	private string GBPPNOKGHBM(int JIIGOACEIKL, string GAIBJNBLIFF, ActionType[] MEOCKCDDPON)
	{
		if (string.IsNullOrEmpty(LocalisationSystem.PKLPKIAHCDI(GAIBJNBLIFF, JIIGOACEIKL)))
		{
			return GAIBJNBLIFF;
		}
		return InputUtils.GEJLCOGDMID(LocalisationSystem.PKLPKIAHCDI(GAIBJNBLIFF, JIIGOACEIKL), MEOCKCDDPON.Select((ActionType x) => InputUtils.CMOBIDABHKM(JIIGOACEIKL, x.ToString())).ToArray());
	}

	private string MOJEONDDBAL(int JIIGOACEIKL, string GAIBJNBLIFF, ActionType[] MEOCKCDDPON)
	{
		if (string.IsNullOrEmpty(LocalisationSystem.PKLPKIAHCDI(GAIBJNBLIFF, JIIGOACEIKL)))
		{
			return GAIBJNBLIFF;
		}
		return InputUtils.GEJLCOGDMID(LocalisationSystem.PKLPKIAHCDI(GAIBJNBLIFF, JIIGOACEIKL), MEOCKCDDPON.Select((ActionType x) => InputUtils.CMOBIDABHKM(JIIGOACEIKL, x.ToString())).ToArray());
	}

	private void FNDJALHNLME()
	{
		BDNKCAIGDJJ();
	}

	private void ALEAOANPHIO()
	{
		if ((Object)(object)rectTransform == (Object)null)
		{
			rectTransform = ((Component)this).GetComponent<RectTransform>();
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Tutorial/T107/Dialogue2")) ? 1 : 0);
	}

	public void CPIBCOCDAHO()
	{
		if (ILENDIBNCBP)
		{
			BDNKCAIGDJJ();
		}
		else
		{
			EBDLDGPIAEA();
		}
	}

	public void ECDFBKBKLIO(PointerEventData NPBAMEMNFBI)
	{
		JIGBCEAJHLJ();
	}

	public void FALDGLBOGKL()
	{
		if (ILENDIBNCBP)
		{
			NEFMHMPEDGD();
		}
		else
		{
			JALKGEAKBBN();
		}
	}

	private string HEAMHLCFPCI(int JIIGOACEIKL, string GAIBJNBLIFF, ActionType[] MEOCKCDDPON)
	{
		if (string.IsNullOrEmpty(LocalisationSystem.PKLPKIAHCDI(GAIBJNBLIFF, JIIGOACEIKL)))
		{
			return GAIBJNBLIFF;
		}
		return InputUtils.GEJLCOGDMID(LocalisationSystem.GetStringWithTags(GAIBJNBLIFF, JIIGOACEIKL), MEOCKCDDPON.Select((ActionType x) => InputUtils.CMOBIDABHKM(JIIGOACEIKL, x.ToString())).ToArray());
	}

	public void BAAMMDGGFEE()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.AIMEAJAHLAA(JIIGOACEIKL)))
		{
			ItemTooltip.IEABDMDELFO(JIIGOACEIKL).FCACMDNLAIG(MDIKPGGBNLI: false);
		}
		ILENDIBNCBP = true;
	}

	public void PDLLJAHLDOG()
	{
		if (ILENDIBNCBP)
		{
			FJNNEIHCAJJ();
		}
		else
		{
			JIGBCEAJHLJ();
		}
	}

	public void BDNKCAIGDJJ()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.EOPIEMLAPFN(JIIGOACEIKL)))
		{
			ItemTooltip.IEKODILKIHJ(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: true);
		}
		ILENDIBNCBP = false;
	}

	public void AEEPEBLIMJN(PointerEventData NPBAMEMNFBI)
	{
		JIGBCEAJHLJ();
	}

	private void HCCJBKKGCLJ()
	{
		if ((Object)(object)rectTransform == (Object)null)
		{
			rectTransform = ((Component)this).GetComponent<RectTransform>();
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("[SinglePlayer=")) ? 7 : 0);
	}

	private bool GIEBDBEMKDN()
	{
		if (type == TooltipType.Normal)
		{
			return true;
		}
		return true;
	}

	public void GEHOEBDJGBB()
	{
		if (ILENDIBNCBP)
		{
			FOLDFLMEIJO();
		}
		else
		{
			OJIEKIMBHPJ();
		}
	}

	public void JCLALDCNNHF(PointerEventData NPBAMEMNFBI)
	{
		DLJLHEMLBFD();
	}

	private string MPABCKPDCAC(int JIIGOACEIKL, string GAIBJNBLIFF, ActionType[] MEOCKCDDPON)
	{
		if (string.IsNullOrEmpty(LocalisationSystem.PKLPKIAHCDI(GAIBJNBLIFF, JIIGOACEIKL)))
		{
			return GAIBJNBLIFF;
		}
		return InputUtils.GEJLCOGDMID(LocalisationSystem.GetStringWithTags(GAIBJNBLIFF, JIIGOACEIKL), MEOCKCDDPON.Select((ActionType x) => InputUtils.CMOBIDABHKM(JIIGOACEIKL, x.ToString())).ToArray());
	}

	public void OLGCBLDGKGL(PointerEventData NPBAMEMNFBI)
	{
		EndHover();
	}

	private bool GIPKCNMJDFE()
	{
		if (type == TooltipType.Normal)
		{
			return false;
		}
		return false;
	}

	private void Awake()
	{
		if ((Object)(object)rectTransform == (Object)null)
		{
			rectTransform = ((Component)this).GetComponent<RectTransform>();
		}
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("UI2")) ? 1 : 2);
	}

	public void IPECKFFALBK(PointerEventData NPBAMEMNFBI)
	{
		FillTooltip();
	}

	public void AKFHCELHAIC(PointerEventData NPBAMEMNFBI)
	{
		OJIEKIMBHPJ();
	}

	public void EMNJLJADCOM()
	{
		if (ILENDIBNCBP)
		{
			FJNNEIHCAJJ();
		}
		else
		{
			JALKGEAKBBN();
		}
	}

	public void GPGGAKFAMPO()
	{
		if (ILENDIBNCBP)
		{
			BFKILMNFDIG();
		}
		else
		{
			OAFHLLABGMA();
		}
	}

	public void AFBKBHKLDID(PointerEventData NPBAMEMNFBI)
	{
		LNNDEPODFFD();
	}

	public void ToggleTooltip()
	{
		if (ILENDIBNCBP)
		{
			EndHover();
		}
		else
		{
			FillTooltip();
		}
	}

	public void GAMBBBPCJJB(PointerEventData NPBAMEMNFBI)
	{
		FOLDFLMEIJO();
	}

	public void OFEFIHNAJJM(PointerEventData NPBAMEMNFBI)
	{
		FOLDFLMEIJO();
	}

	public void DLNJCPCMONE(PointerEventData NPBAMEMNFBI)
	{
		FOLDFLMEIJO();
	}
}
