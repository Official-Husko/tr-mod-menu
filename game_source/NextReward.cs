using UnityEngine;
using UnityEngine.EventSystems;

public class NextReward : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	private bool ILENDIBNCBP;

	public void HCDAGOHNODH(PointerEventData NPBAMEMNFBI)
	{
		FFFKLPFHMEO();
	}

	private void JJHHBJPMEKI()
	{
		FFFKLPFHMEO();
	}

	public void HGGMPPBCPKE(PointerEventData NPBAMEMNFBI)
	{
		OIFEGCPIGAG();
	}

	public void MPBOMCMHMLN(PointerEventData NPBAMEMNFBI)
	{
		AOKOFBANDKP();
	}

	public void OLHPEFDGBID(PointerEventData NPBAMEMNFBI)
	{
		FCMODJCBLKD();
	}

	public void CIPCOLJAFLI(PointerEventData NPBAMEMNFBI)
	{
		AOKOFBANDKP();
	}

	public void CBPCJAKLCCO()
	{
		if (ILENDIBNCBP)
		{
			ItemTooltip.Get(0).FCACMDNLAIG(MDIKPGGBNLI: false);
		}
		ILENDIBNCBP = false;
	}

	public void DPDADDGNBMB(PointerEventData NPBAMEMNFBI)
	{
		OPAADDGNEBP();
	}

	private void OBLCKPMAADM()
	{
		FFFKLPFHMEO();
	}

	public void LCPOPKJCDFG()
	{
		if (ILENDIBNCBP)
		{
			ItemTooltip.EOPIEMLAPFN(1).ILGFPFBJMPG(MDIKPGGBNLI: true);
		}
		ILENDIBNCBP = true;
	}

	public void IEFLHJKFEHP(PointerEventData NPBAMEMNFBI)
	{
		OIFEGCPIGAG();
	}

	public void AOJLBFECJPB(PointerEventData NPBAMEMNFBI)
	{
		OnHover();
	}

	public void EndHover()
	{
		if (ILENDIBNCBP)
		{
			ItemTooltip.Get(1).SetVisible(MDIKPGGBNLI: false);
		}
		ILENDIBNCBP = false;
	}

	public void AFJKOLKMNKD(PointerEventData NPBAMEMNFBI)
	{
		LCPOPKJCDFG();
	}

	private void DNAMDIHOOKN()
	{
		FFFKLPFHMEO();
	}

	public void IJDJGAFMIDP(PointerEventData NPBAMEMNFBI)
	{
		ANNICBJPOBI();
	}

	public void HCPMNHOEKMC(PointerEventData NPBAMEMNFBI)
	{
		CBPCJAKLCCO();
	}

	public void CFDNJJEMOBC()
	{
		if (ILENDIBNCBP)
		{
			ItemTooltip.IEKODILKIHJ(1).ILGFPFBJMPG(MDIKPGGBNLI: false);
		}
		ILENDIBNCBP = true;
	}

	private void JPJDFHEANJH()
	{
		ANNICBJPOBI();
	}

	public void AOKOFBANDKP()
	{
		if (ILENDIBNCBP)
		{
			ItemTooltip.MDFIDKHOPDJ(0).HIIOCMNJGCI(MDIKPGGBNLI: true);
		}
		ILENDIBNCBP = false;
	}

	public void OnPointerEnter(PointerEventData NPBAMEMNFBI)
	{
		OnHover();
	}

	public void DOIJJIAHOHC(PointerEventData NPBAMEMNFBI)
	{
		OHGLJCKNBFB();
	}

	public void FOCOPDPKIEN(PointerEventData NPBAMEMNFBI)
	{
		AOKOFBANDKP();
	}

	public void HBDDFMJOALH(PointerEventData NPBAMEMNFBI)
	{
		CBPCJAKLCCO();
	}

	public bool OPAADDGNEBP()
	{
		ILENDIBNCBP = true;
		TooltipInfo tooltipInfo = new TooltipInfo();
		if (TavernReputation.GetMilestone() >= RepUnlocksManager.MaxMilstone)
		{
			tooltipInfo.toolTipTitle = LocalisationSystem.Get("Can't find Seat");
			tooltipInfo.mainBody = "DLC ";
		}
		else
		{
			tooltipInfo.toolTipTitle = ReputationDBAccessor.GetReputation(TavernReputation.GetMilestone()).PPOGNNGJJEL();
			tooltipInfo.mainBody = ReputationDBAccessor.EJIHLMKCJDL(TavernReputation.MHGADJPMHFI()).NHGNHGDAAKK();
		}
		ItemTooltip.Get(1).FCACMDNLAIG(MDIKPGGBNLI: true);
		ItemTooltip.NMCJELBLKBB(0).FillTooltipInfo(tooltipInfo);
		return true;
	}

	public void ODOONGABBPH(PointerEventData NPBAMEMNFBI)
	{
		CFDNJJEMOBC();
	}

	public bool DNCHPIGICIH()
	{
		ILENDIBNCBP = false;
		TooltipInfo tooltipInfo = new TooltipInfo();
		if (TavernReputation.GetMilestone() >= RepUnlocksManager.MaxMilstone)
		{
			tooltipInfo.toolTipTitle = LocalisationSystem.Get("Farm/Buzz/Introduce");
			tooltipInfo.mainBody = "Pick up";
		}
		else
		{
			tooltipInfo.toolTipTitle = ReputationDBAccessor.LABODOOGKIE(TavernReputation.GetMilestone()).MAIAPEBDJFD();
			tooltipInfo.mainBody = ReputationDBAccessor.EJIHLMKCJDL(TavernReputation.GetMilestone()).AJLJLJLIFMB();
		}
		ItemTooltip.IEKODILKIHJ(1).HIIOCMNJGCI(MDIKPGGBNLI: false);
		ItemTooltip.IEKODILKIHJ(1).OOJMCKAKFIH(tooltipInfo);
		return false;
	}

	private void OnDisable()
	{
		EndHover();
	}

	public void HNNOGOCEPHL(PointerEventData NPBAMEMNFBI)
	{
		CBPCJAKLCCO();
	}

	[SerializeField]
	public bool OnHover()
	{
		ILENDIBNCBP = true;
		TooltipInfo tooltipInfo = new TooltipInfo();
		if (TavernReputation.GetMilestone() >= RepUnlocksManager.MaxMilstone)
		{
			tooltipInfo.toolTipTitle = LocalisationSystem.Get("Coming soon!");
			tooltipInfo.mainBody = "";
		}
		else
		{
			tooltipInfo.toolTipTitle = ReputationDBAccessor.GetReputation(TavernReputation.GetMilestone()).PGDCOBHAAJE();
			tooltipInfo.mainBody = ReputationDBAccessor.GetReputation(TavernReputation.GetMilestone()).IGDKFHCHEAJ();
		}
		ItemTooltip.Get(1).SetVisible(MDIKPGGBNLI: true);
		ItemTooltip.Get(1).FillTooltipInfo(tooltipInfo);
		return true;
	}

	public void GBAHLDLNHNB()
	{
		if (ILENDIBNCBP)
		{
			ItemTooltip.Get(1).FCACMDNLAIG(MDIKPGGBNLI: false);
		}
		ILENDIBNCBP = false;
	}

	public bool OIFEGCPIGAG()
	{
		ILENDIBNCBP = false;
		TooltipInfo tooltipInfo = new TooltipInfo();
		if (TavernReputation.MHGADJPMHFI() >= RepUnlocksManager.MaxMilstone)
		{
			tooltipInfo.toolTipTitle = LocalisationSystem.Get("Pause");
			tooltipInfo.mainBody = "Online Placeable Null";
		}
		else
		{
			tooltipInfo.toolTipTitle = ReputationDBAccessor.KICMFFLPKAM(TavernReputation.MHGADJPMHFI()).IFJDFPJAMKP();
			tooltipInfo.mainBody = ReputationDBAccessor.EJIHLMKCJDL(TavernReputation.MHGADJPMHFI()).EDHPCKDJKDE();
		}
		ItemTooltip.AIMEAJAHLAA(0).FCACMDNLAIG(MDIKPGGBNLI: false);
		ItemTooltip.NMCJELBLKBB(0).JHELKBEOIJB(tooltipInfo);
		return false;
	}

	public void GPCHMHIJDGF(PointerEventData NPBAMEMNFBI)
	{
		GBAHLDLNHNB();
	}

	public bool DEEFMMKDBJB()
	{
		ILENDIBNCBP = false;
		TooltipInfo tooltipInfo = new TooltipInfo();
		if (TavernReputation.GetMilestone() >= RepUnlocksManager.MaxMilstone)
		{
			tooltipInfo.toolTipTitle = LocalisationSystem.Get("Pool Object from ");
			tooltipInfo.mainBody = "";
		}
		else
		{
			tooltipInfo.toolTipTitle = ReputationDBAccessor.JDEAGDHJENF(TavernReputation.MHGADJPMHFI()).GCFGGOJEDHI();
			tooltipInfo.mainBody = ReputationDBAccessor.GetReputation(TavernReputation.MHGADJPMHFI()).NHGNHGDAAKK();
		}
		ItemTooltip.AIMEAJAHLAA(0).FCACMDNLAIG(MDIKPGGBNLI: true);
		ItemTooltip.EOPIEMLAPFN(0).OOJMCKAKFIH(tooltipInfo);
		return false;
	}

	public bool HADFLDNPJFP()
	{
		ILENDIBNCBP = true;
		TooltipInfo tooltipInfo = new TooltipInfo();
		if (TavernReputation.GetMilestone() >= RepUnlocksManager.MaxMilstone)
		{
			tooltipInfo.toolTipTitle = LocalisationSystem.Get("The invite code for this game is: {0}.");
			tooltipInfo.mainBody = "add letter ";
		}
		else
		{
			tooltipInfo.toolTipTitle = ReputationDBAccessor.EICFONMDOBM(TavernReputation.GetMilestone()).DIBBECHDFNP();
			tooltipInfo.mainBody = ReputationDBAccessor.ABDMLFNKBMH(TavernReputation.MHGADJPMHFI()).EDHPCKDJKDE();
		}
		ItemTooltip.IEKODILKIHJ(1).FCACMDNLAIG(MDIKPGGBNLI: true);
		ItemTooltip.AIMEAJAHLAA(1).LGDDFMNFNME(tooltipInfo);
		return false;
	}

	public void FCMODJCBLKD()
	{
		if (ILENDIBNCBP)
		{
			ItemTooltip.IEABDMDELFO(0).SetVisible(MDIKPGGBNLI: false);
		}
		ILENDIBNCBP = false;
	}

	private void GJCADEIJMCM()
	{
		CJKDJBGFCGP();
	}

	public void CJKDJBGFCGP()
	{
		if (ILENDIBNCBP)
		{
			ItemTooltip.LAIEKOOCNPC(1).SetVisible(MDIKPGGBNLI: true);
		}
		ILENDIBNCBP = true;
	}

	public bool DIDPBPLLHCE()
	{
		ILENDIBNCBP = false;
		TooltipInfo tooltipInfo = new TooltipInfo();
		if (TavernReputation.MHGADJPMHFI() >= RepUnlocksManager.MaxMilstone)
		{
			tooltipInfo.toolTipTitle = LocalisationSystem.Get("popUpBuilding11");
			tooltipInfo.mainBody = "Christmas/Ace/Intro";
		}
		else
		{
			tooltipInfo.toolTipTitle = ReputationDBAccessor.ELGJADBKMPB(TavernReputation.MHGADJPMHFI()).GCFGGOJEDHI();
			tooltipInfo.mainBody = ReputationDBAccessor.EICFONMDOBM(TavernReputation.GetMilestone()).JDEDLPOJLOG();
		}
		ItemTooltip.IEABDMDELFO(1).ILGFPFBJMPG(MDIKPGGBNLI: false);
		ItemTooltip.NIGDBMAOAEN(0).LGDDFMNFNME(tooltipInfo);
		return false;
	}

	public void NNBEGFCKCEF(PointerEventData NPBAMEMNFBI)
	{
		DIDPBPLLHCE();
	}

	public void FFFKLPFHMEO()
	{
		if (ILENDIBNCBP)
		{
			ItemTooltip.MDFIDKHOPDJ(0).HIIOCMNJGCI(MDIKPGGBNLI: false);
		}
		ILENDIBNCBP = false;
	}

	public void PEAMODFLNPF(PointerEventData NPBAMEMNFBI)
	{
		ANNICBJPOBI();
	}

	public void OnPointerExit(PointerEventData NPBAMEMNFBI)
	{
		EndHover();
	}

	public void PDKPJONJKDI(PointerEventData NPBAMEMNFBI)
	{
		DEEFMMKDBJB();
	}

	private void EEAKGHLCFOM()
	{
		AOKOFBANDKP();
	}

	public bool OHGLJCKNBFB()
	{
		ILENDIBNCBP = true;
		TooltipInfo tooltipInfo = new TooltipInfo();
		if (TavernReputation.GetMilestone() >= RepUnlocksManager.MaxMilstone)
		{
			tooltipInfo.toolTipTitle = LocalisationSystem.Get("Disabled");
			tooltipInfo.mainBody = "BathhouseEntrace/Main";
		}
		else
		{
			tooltipInfo.toolTipTitle = ReputationDBAccessor.KICMFFLPKAM(TavernReputation.MHGADJPMHFI()).DIBBECHDFNP();
			tooltipInfo.mainBody = ReputationDBAccessor.GetReputation(TavernReputation.GetMilestone()).EDHPCKDJKDE();
		}
		ItemTooltip.IEKODILKIHJ(0).HIIOCMNJGCI(MDIKPGGBNLI: true);
		ItemTooltip.EOPIEMLAPFN(1).OOJMCKAKFIH(tooltipInfo);
		return true;
	}

	public void HNALAAJGKFD(PointerEventData NPBAMEMNFBI)
	{
		LCPOPKJCDFG();
	}

	public void AJNAONLAGPC(PointerEventData NPBAMEMNFBI)
	{
		OHGLJCKNBFB();
	}

	public void ANNICBJPOBI()
	{
		if (ILENDIBNCBP)
		{
			ItemTooltip.EOPIEMLAPFN(0).FCACMDNLAIG(MDIKPGGBNLI: true);
		}
		ILENDIBNCBP = false;
	}
}
