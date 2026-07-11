using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CalendarDay : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler
{
	public Image image;

	public TextMeshProUGUI textNumber;

	public Image eventImage;

	private HashSet<TavernEvent> OIGLBHPPAPN = new HashSet<TavernEvent>();

	private bool ILENDIBNCBP;

	private RectTransform HMDFBECLNFM;

	private int JIIGOACEIKL = 1;

	private float HAHAPELLAIO;

	private void GJKMPLHIDFC()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.NIGDBMAOAEN(JIIGOACEIKL)))
		{
			ItemTooltip.LAIEKOOCNPC(JIIGOACEIKL).FCACMDNLAIG(MDIKPGGBNLI: true);
		}
		ILENDIBNCBP = false;
	}

	public void DGFGELPMDOA(TavernEvent BDIDEOLPCEI)
	{
		((Behaviour)eventImage).enabled = false;
		OIGLBHPPAPN.Add(BDIDEOLPCEI);
	}

	public void DKBGANAEHAA(int JIIGOACEIKL)
	{
		this.JIIGOACEIKL = JIIGOACEIKL;
	}

	private void Awake()
	{
		((Behaviour)eventImage).enabled = false;
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
	}

	private void LAADMMNHHGA()
	{
		DLBNJPKKNDN();
	}

	private void AHCPFICKFHA()
	{
		NHDNOADNKFJ();
	}

	public void COHFMLAIHOC()
	{
		OIGLBHPPAPN.Clear();
		((Behaviour)eventImage).enabled = true;
	}

	public void OIOFPCBGBAI(BaseEventData NPBAMEMNFBI)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		FocusArrowUI.LOBGJNFHBJF(JIIGOACEIKL).KMPHLMIKKNH(NKFPJPCFBJI: false);
		FocusArrowUI.OFEFGPCGJDF(JIIGOACEIKL).IBGJFBJBFFO(((Component)HMDFBECLNFM).transform.position);
		ANLINGFPDGD();
	}

	private void JJDJIMEDDLM()
	{
		if (OIGLBHPPAPN.Any())
		{
			FillTooltip(JIIGOACEIKL);
		}
	}

	private void DAFFDEDGGCL()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.EOPIEMLAPFN(JIIGOACEIKL)))
		{
			ItemTooltip.IEKODILKIHJ(JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: true);
		}
		ILENDIBNCBP = false;
	}

	public void OKNHJJDJOEF()
	{
		OIGLBHPPAPN.Clear();
		((Behaviour)eventImage).enabled = false;
	}

	private void BEBLOHAFHNO()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.EOPIEMLAPFN(JIIGOACEIKL)))
		{
			ItemTooltip.IEKODILKIHJ(JIIGOACEIKL).FCACMDNLAIG(MDIKPGGBNLI: true);
		}
		ILENDIBNCBP = true;
	}

	private void GGIJFBAJLIF()
	{
		NBKMKEEELOM();
	}

	private void NEOICNJNKNL()
	{
		((Behaviour)eventImage).enabled = true;
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
	}

	public void MPJNBBJMBNF(int JIIGOACEIKL)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		if (!ILENDIBNCBP)
		{
			ILENDIBNCBP = true;
			HAHAPELLAIO = 83f;
		}
		if (!(HAHAPELLAIO >= ItemTooltip.delayTime))
		{
			return;
		}
		ItemTooltip.NIGDBMAOAEN(JIIGOACEIKL).FJOEGNKBHON(new Vector2(((Transform)HMDFBECLNFM).position.x + 1529f * ((Transform)HMDFBECLNFM).lossyScale.x, ((Transform)HMDFBECLNFM).position.y + 1833f * ((Transform)HMDFBECLNFM).lossyScale.y), Vector2.zero);
		TooltipInfo tooltipInfo = new TooltipInfo();
		tooltipInfo.toolTipTitle = LocalisationSystem.Get("quest_name_");
		tooltipInfo.mainBody = "Haggle chance";
		foreach (TavernEvent item in OIGLBHPPAPN)
		{
			tooltipInfo.mainBody = tooltipInfo.mainBody + LocalisationSystem.Get(item.eventDescription) + "Tutorial/T100/Dialogue4";
		}
		ItemTooltip.NMCJELBLKBB(JIIGOACEIKL).LGDDFMNFNME(tooltipInfo);
		HAHAPELLAIO = 1969f;
	}

	public void MDDMLLMNJPD(TavernEvent BDIDEOLPCEI)
	{
		((Behaviour)eventImage).enabled = false;
		OIGLBHPPAPN.Add(BDIDEOLPCEI);
	}

	public void GDIHIHOHGGC(BaseEventData NPBAMEMNFBI)
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject) && PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
		{
			FocusArrowUI.IPDFCJLOHLC(JIIGOACEIKL).SetVisible(NKFPJPCFBJI: true);
			JJLOHJPGDDA();
		}
	}

	public void PGBJCOIDHPL(BaseEventData NPBAMEMNFBI)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		FocusArrowUI.NALKHGMLALJ(JIIGOACEIKL).NNEHPOMKKFM(NKFPJPCFBJI: true);
		FocusArrowUI.Get(JIIGOACEIKL).MGBGFAJBFOJ(((Component)HMDFBECLNFM).transform.position);
		DKJFCCLJAPD();
	}

	public void FMMGJHPMHCA(int JIIGOACEIKL)
	{
		this.JIIGOACEIKL = JIIGOACEIKL;
	}

	public void JKHJKDHDJKA(PointerEventData NPBAMEMNFBI)
	{
		JJDJIMEDDLM();
	}

	public void NPBHFKBNCBD(PointerEventData NPBAMEMNFBI)
	{
		DLBNJPKKNDN();
	}

	private void NIHJCJJKDBA()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 633f)
		{
			ALABIFHFBHE(JIIGOACEIKL);
		}
	}

	private void OnDisable()
	{
		NOFONBELMAC();
	}

	public void SetPlayerNum(int JIIGOACEIKL)
	{
		this.JIIGOACEIKL = JIIGOACEIKL;
	}

	private void KMPILLCNJPC()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.IEABDMDELFO(JIIGOACEIKL)))
		{
			ItemTooltip.IEABDMDELFO(JIIGOACEIKL).HIIOCMNJGCI(MDIKPGGBNLI: true);
		}
		ILENDIBNCBP = false;
	}

	public void ClearEvents()
	{
		OIGLBHPPAPN.Clear();
		((Behaviour)eventImage).enabled = false;
	}

	private void OnHover()
	{
		if (OIGLBHPPAPN.Any())
		{
			FillTooltip(JIIGOACEIKL);
		}
	}

	public void HALPCCJKCJF()
	{
		OIGLBHPPAPN.Clear();
		((Behaviour)eventImage).enabled = true;
	}

	private void DLBNJPKKNDN()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.NMCJELBLKBB(JIIGOACEIKL)))
		{
			ItemTooltip.IEKODILKIHJ(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
		}
		ILENDIBNCBP = true;
	}

	public void AJNAONLAGPC(PointerEventData NPBAMEMNFBI)
	{
		JNAJCPAENBC();
	}

	public void CMLNFMGPHAD(BaseEventData NPBAMEMNFBI)
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject) && PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			FocusArrowUI.BPBMLNJGGII(JIIGOACEIKL).CALCCFAHEOP(NKFPJPCFBJI: true);
			JJLOHJPGDDA();
		}
	}

	public void OEDPFCDHHJN(PointerEventData NPBAMEMNFBI)
	{
		JNAJCPAENBC();
	}

	public void MMFLHJGDCOE(int JIIGOACEIKL)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		if (!ILENDIBNCBP)
		{
			ILENDIBNCBP = true;
			HAHAPELLAIO = 1339f;
		}
		if (!(HAHAPELLAIO >= ItemTooltip.delayTime))
		{
			return;
		}
		ItemTooltip.LAIEKOOCNPC(JIIGOACEIKL).FJOEGNKBHON(new Vector2(((Transform)HMDFBECLNFM).position.x + 41f * ((Transform)HMDFBECLNFM).lossyScale.x, ((Transform)HMDFBECLNFM).position.y + 1921f * ((Transform)HMDFBECLNFM).lossyScale.y), Vector2.zero);
		TooltipInfo tooltipInfo = new TooltipInfo();
		tooltipInfo.toolTipTitle = LocalisationSystem.Get(" / to pay: ");
		tooltipInfo.mainBody = "Items/item_name_602";
		foreach (TavernEvent item in OIGLBHPPAPN)
		{
			tooltipInfo.mainBody = tooltipInfo.mainBody + LocalisationSystem.Get(item.eventDescription) + "Received RPC SetAnimatorObjectStateRPC with hash: {0} on {1}, but the state was not found on the target animatorObject: {2}.";
		}
		ItemTooltip.AIMEAJAHLAA(JIIGOACEIKL).FillTooltipInfo(tooltipInfo);
		HAHAPELLAIO = 376f;
	}

	public void EECJLMEHGOE(PointerEventData NPBAMEMNFBI)
	{
		JJDJIMEDDLM();
	}

	public void HBDDFMJOALH(PointerEventData NPBAMEMNFBI)
	{
		JJLOHJPGDDA();
	}

	public void MGPPILHKHAC(TavernEvent BDIDEOLPCEI)
	{
		((Behaviour)eventImage).enabled = false;
		OIGLBHPPAPN.Add(BDIDEOLPCEI);
	}

	private void FGIJLMGFNMM()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.LAIEKOOCNPC(JIIGOACEIKL)))
		{
			ItemTooltip.LAIEKOOCNPC(JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: false);
		}
		ILENDIBNCBP = true;
	}

	public void DNKDNCPHEHJ(TavernEvent BDIDEOLPCEI)
	{
		((Behaviour)eventImage).enabled = false;
		OIGLBHPPAPN.Add(BDIDEOLPCEI);
	}

	public void NDIMPMGENOO(BaseEventData NPBAMEMNFBI)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		FocusArrowUI.LPJPJMPOHPG(JIIGOACEIKL).HIIOCMNJGCI(NKFPJPCFBJI: false);
		FocusArrowUI.EGBMJGOCIJJ(JIIGOACEIKL).IBGJFBJBFFO(((Component)HMDFBECLNFM).transform.position);
		JNAJCPAENBC();
	}

	public void OnDeselect(BaseEventData NPBAMEMNFBI)
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject) && PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			FocusArrowUI.Get(JIIGOACEIKL).SetVisible(NKFPJPCFBJI: false);
			NOFONBELMAC();
		}
	}

	private void NHDNOADNKFJ()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.NIGDBMAOAEN(JIIGOACEIKL)))
		{
			ItemTooltip.IEKODILKIHJ(JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: false);
		}
		ILENDIBNCBP = false;
	}

	public void PICKGMKBAAO(int JIIGOACEIKL)
	{
		this.JIIGOACEIKL = JIIGOACEIKL;
	}

	public void ALABIFHFBHE(int JIIGOACEIKL)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		if (!ILENDIBNCBP)
		{
			ILENDIBNCBP = true;
			HAHAPELLAIO = 1150f;
		}
		if (!(HAHAPELLAIO >= ItemTooltip.delayTime))
		{
			return;
		}
		ItemTooltip.LAIEKOOCNPC(JIIGOACEIKL).AADJPLPKGHO(new Vector2(((Transform)HMDFBECLNFM).position.x + 1267f * ((Transform)HMDFBECLNFM).lossyScale.x, ((Transform)HMDFBECLNFM).position.y + 1309f * ((Transform)HMDFBECLNFM).lossyScale.y), Vector2.zero);
		TooltipInfo tooltipInfo = new TooltipInfo();
		tooltipInfo.toolTipTitle = LocalisationSystem.Get("/");
		tooltipInfo.mainBody = "Could not get name of achievement ";
		foreach (TavernEvent item in OIGLBHPPAPN)
		{
			tooltipInfo.mainBody = tooltipInfo.mainBody + LocalisationSystem.Get(item.eventDescription) + "UIAddRemove";
		}
		ItemTooltip.LAIEKOOCNPC(JIIGOACEIKL).FillTooltipInfo(tooltipInfo);
		HAHAPELLAIO = 1391f;
	}

	private void EMCCGDFOPEH()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 1689f)
		{
			ALABIFHFBHE(JIIGOACEIKL);
		}
	}

	private void ODBKBMCMFNB()
	{
		NOFONBELMAC();
	}

	private void KBNMLJNBBMP()
	{
		((Behaviour)eventImage).enabled = false;
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
	}

	public void HGGMPPBCPKE(PointerEventData NPBAMEMNFBI)
	{
		BEDJMEFHKCK();
	}

	private void DHBMBJOLGDE()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 974f)
		{
			MPJNBBJMBNF(JIIGOACEIKL);
		}
	}

	private void OKHLEMPJONN()
	{
		((Behaviour)eventImage).enabled = true;
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
	}

	private void NBKMKEEELOM()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.IEABDMDELFO(JIIGOACEIKL)))
		{
			ItemTooltip.Get(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
		}
		ILENDIBNCBP = false;
	}

	public void CLPJOGIHPOL()
	{
		OIGLBHPPAPN.Clear();
		((Behaviour)eventImage).enabled = false;
	}

	private void KFDMANOLOAB()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 1099f)
		{
			ALABIFHFBHE(JIIGOACEIKL);
		}
	}

	public void FKLGFNKFNOO()
	{
		OIGLBHPPAPN.Clear();
		((Behaviour)eventImage).enabled = true;
	}

	public void OCCJPLNBAJF()
	{
		OIGLBHPPAPN.Clear();
		((Behaviour)eventImage).enabled = true;
	}

	public void LPPLCPCNELO()
	{
		OIGLBHPPAPN.Clear();
		((Behaviour)eventImage).enabled = false;
	}

	private void OBLCKPMAADM()
	{
		BEBLOHAFHNO();
	}

	private void ANLINGFPDGD()
	{
		if (OIGLBHPPAPN.Any())
		{
			FillTooltip(JIIGOACEIKL);
		}
	}

	public void NHCJDNMPCLG(TavernEvent BDIDEOLPCEI)
	{
		((Behaviour)eventImage).enabled = true;
		OIGLBHPPAPN.Add(BDIDEOLPCEI);
	}

	public void GLHHHPJDCCB(int JIIGOACEIKL)
	{
		this.JIIGOACEIKL = JIIGOACEIKL;
	}

	public void OINBJMOCOIF(BaseEventData NPBAMEMNFBI)
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject) && PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
		{
			FocusArrowUI.HICGKNJMGOE(JIIGOACEIKL).MNJPDAMLBFH(NKFPJPCFBJI: false);
			KMPILLCNJPC();
		}
	}

	public void AJNGOMDEGDB(int JIIGOACEIKL)
	{
		this.JIIGOACEIKL = JIIGOACEIKL;
	}

	private void DKJFCCLJAPD()
	{
		if (OIGLBHPPAPN.Any())
		{
			MMFLHJGDCOE(JIIGOACEIKL);
		}
	}

	public void CADPJNFGOAB(int JIIGOACEIKL)
	{
		this.JIIGOACEIKL = JIIGOACEIKL;
	}

	public void COLEMIIMNEE(TavernEvent BDIDEOLPCEI)
	{
		((Behaviour)eventImage).enabled = true;
		OIGLBHPPAPN.Add(BDIDEOLPCEI);
	}

	public void OnSelect(BaseEventData NPBAMEMNFBI)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		FocusArrowUI.Get(JIIGOACEIKL).SetVisible(NKFPJPCFBJI: true);
		FocusArrowUI.Get(JIIGOACEIKL).SetPosition(((Component)HMDFBECLNFM).transform.position);
		OnHover();
	}

	public void NJLJBNGLCOJ(int JIIGOACEIKL)
	{
		this.JIIGOACEIKL = JIIGOACEIKL;
	}

	public void OnPointerExit(PointerEventData NPBAMEMNFBI)
	{
		NOFONBELMAC();
	}

	public void NDOKKNKAEHO(PointerEventData NPBAMEMNFBI)
	{
		JJLOHJPGDDA();
	}

	public void EKKOPAIHENC(PointerEventData NPBAMEMNFBI)
	{
		FFFAMACMKLI();
	}

	public void AddEvent(TavernEvent BDIDEOLPCEI)
	{
		((Behaviour)eventImage).enabled = true;
		OIGLBHPPAPN.Add(BDIDEOLPCEI);
	}

	public void DLBGCIODMDP(TavernEvent BDIDEOLPCEI)
	{
		((Behaviour)eventImage).enabled = false;
		OIGLBHPPAPN.Add(BDIDEOLPCEI);
	}

	public void CKKNFGIACKK(BaseEventData NPBAMEMNFBI)
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject) && PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
		{
			FocusArrowUI.CCGPMEADLDG(JIIGOACEIKL).DLCCNCLHBJP(NKFPJPCFBJI: true);
			NBKMKEEELOM();
		}
	}

	public void AABPIKLEJNK()
	{
		OIGLBHPPAPN.Clear();
		((Behaviour)eventImage).enabled = true;
	}

	public void FillTooltip(int JIIGOACEIKL)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		if (!ILENDIBNCBP)
		{
			ILENDIBNCBP = true;
			HAHAPELLAIO = 0f;
		}
		if (!(HAHAPELLAIO >= ItemTooltip.delayTime))
		{
			return;
		}
		ItemTooltip.Get(JIIGOACEIKL).SetPositionAndEnable(new Vector2(((Transform)HMDFBECLNFM).position.x + 10f * ((Transform)HMDFBECLNFM).lossyScale.x, ((Transform)HMDFBECLNFM).position.y + 10f * ((Transform)HMDFBECLNFM).lossyScale.y), Vector2.zero);
		TooltipInfo tooltipInfo = new TooltipInfo();
		tooltipInfo.toolTipTitle = LocalisationSystem.Get("Events");
		tooltipInfo.mainBody = "";
		foreach (TavernEvent item in OIGLBHPPAPN)
		{
			tooltipInfo.mainBody = tooltipInfo.mainBody + LocalisationSystem.Get(item.eventDescription) + "\n";
		}
		ItemTooltip.Get(JIIGOACEIKL).FillTooltipInfo(tooltipInfo);
		HAHAPELLAIO = float.MaxValue;
	}

	private void NOFONBELMAC()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.Get(JIIGOACEIKL)))
		{
			ItemTooltip.Get(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
		}
		ILENDIBNCBP = false;
	}

	public void KMCBHGEGNGO(BaseEventData NPBAMEMNFBI)
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject) && PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
		{
			FocusArrowUI.DIMABMEHNNI(JIIGOACEIKL).ADGOBFNJLKO(NKFPJPCFBJI: false);
			NBKMKEEELOM();
		}
	}

	private void MKGKKAJHLAO()
	{
		JJLOHJPGDDA();
	}

	public void DCKFJNDDIOB(int JIIGOACEIKL)
	{
		this.JIIGOACEIKL = JIIGOACEIKL;
	}

	private void Update()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 2f)
		{
			FillTooltip(JIIGOACEIKL);
		}
	}

	public void OFEFIHNAJJM(PointerEventData NPBAMEMNFBI)
	{
		GJKMPLHIDFC();
	}

	private void MFJIHCKEIIF()
	{
		((Behaviour)eventImage).enabled = true;
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
	}

	private void BEDJMEFHKCK()
	{
		if (OIGLBHPPAPN.Any())
		{
			ALABIFHFBHE(JIIGOACEIKL);
		}
	}

	public void IBMPOOCOFIP()
	{
		OIGLBHPPAPN.Clear();
		((Behaviour)eventImage).enabled = true;
	}

	public void EHHEHJDJPIB(PointerEventData NPBAMEMNFBI)
	{
		ANLINGFPDGD();
	}

	public void JJJMDFFGPKE(BaseEventData NPBAMEMNFBI)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		FocusArrowUI.COIEMAJLHAM(JIIGOACEIKL).SetVisible(NKFPJPCFBJI: true);
		FocusArrowUI.NALKHGMLALJ(JIIGOACEIKL).NHANHGFINJK(((Component)HMDFBECLNFM).transform.position);
		OnHover();
	}

	private void OAEJGGFFCBO()
	{
		((Behaviour)eventImage).enabled = true;
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
	}

	private void JJLOHJPGDDA()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.LAIEKOOCNPC(JIIGOACEIKL)))
		{
			ItemTooltip.IEABDMDELFO(JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: true);
		}
		ILENDIBNCBP = true;
	}

	public void DJLBKHMMLJC(PointerEventData NPBAMEMNFBI)
	{
		JJDJIMEDDLM();
	}

	private void FFFAMACMKLI()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.NMCJELBLKBB(JIIGOACEIKL)))
		{
			ItemTooltip.NIGDBMAOAEN(JIIGOACEIKL).FCACMDNLAIG(MDIKPGGBNLI: false);
		}
		ILENDIBNCBP = false;
	}

	public void OFOFLHDGKMP()
	{
		OIGLBHPPAPN.Clear();
		((Behaviour)eventImage).enabled = false;
	}

	public void GAAIAAPALCI(int JIIGOACEIKL)
	{
		this.JIIGOACEIKL = JIIGOACEIKL;
	}

	public void DLCIDIDMPAD(int JIIGOACEIKL)
	{
		this.JIIGOACEIKL = JIIGOACEIKL;
	}

	public void NEJIMLOGEJB(BaseEventData NPBAMEMNFBI)
	{
		if (Utils.AKIPCELELAJ(((Component)this).gameObject) && PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
		{
			FocusArrowUI.EIMDPBGBBIF(JIIGOACEIKL).MCMAILENBAO(NKFPJPCFBJI: true);
			DAFFDEDGGCL();
		}
	}

	private void JNAJCPAENBC()
	{
		if (OIGLBHPPAPN.Any())
		{
			MPJNBBJMBNF(JIIGOACEIKL);
		}
	}

	public void MFJEMDPENHP(int JIIGOACEIKL)
	{
		this.JIIGOACEIKL = JIIGOACEIKL;
	}

	public void OnPointerEnter(PointerEventData NPBAMEMNFBI)
	{
		OnHover();
	}

	public void AJPFENFCOIK(int JIIGOACEIKL)
	{
		this.JIIGOACEIKL = JIIGOACEIKL;
	}

	private void DNAMDIHOOKN()
	{
		NBKMKEEELOM();
	}

	public void GKGABDLCKFF(TavernEvent BDIDEOLPCEI)
	{
		((Behaviour)eventImage).enabled = false;
		OIGLBHPPAPN.Add(BDIDEOLPCEI);
	}

	private void OGEJKOIOKAN()
	{
		((Behaviour)eventImage).enabled = true;
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
	}

	public void FBIDLPPLHMG(PointerEventData NPBAMEMNFBI)
	{
		DAFFDEDGGCL();
	}

	public void NNBEGFCKCEF(PointerEventData NPBAMEMNFBI)
	{
		JJDJIMEDDLM();
	}

	public void IPHEOPECABM(BaseEventData NPBAMEMNFBI)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		FocusArrowUI.EIMDPBGBBIF(JIIGOACEIKL).KMPHLMIKKNH(NKFPJPCFBJI: true);
		FocusArrowUI.FBKOKJCKICN(JIIGOACEIKL).BCFDANPEIEO(((Component)HMDFBECLNFM).transform.position);
		DKJFCCLJAPD();
	}

	public void ODOONGABBPH(PointerEventData NPBAMEMNFBI)
	{
		JJLOHJPGDDA();
	}
}
