using UnityEngine;
using UnityEngine.EventSystems;

public class RewardSlotUI : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	private int JIIGOACEIKL = 1;

	private RectTransform HMDFBECLNFM;

	private bool ILENDIBNCBP;

	private void NLFHFPHDNCF()
	{
	}

	private void NHGBJHMHEGD()
	{
	}

	private void FPDPAJHNGHK()
	{
	}

	public void AGMAOKJAHCI(PointerEventData NPBAMEMNFBI)
	{
		int jIIGOACEIKL = ((!GameManager.LocalCoop() || PlayerInputs.POLDHCKJINN(8) || !PlayerInputs.LGGMJONLIGE(4).hasMouse) ? 1 : 5);
		FKOOKOFBKJL(jIIGOACEIKL);
	}

	public void HHHIBMBBNOG(PointerEventData NPBAMEMNFBI)
	{
		EDMDHAOGCAJ();
	}

	private void HOKAPOOCJCC()
	{
	}

	public void KDAJGEFFPJI(PointerEventData NPBAMEMNFBI)
	{
		int jIIGOACEIKL = ((GameManager.LocalCoop() && !PlayerInputs.ODGALPDEIFG(7) && PlayerInputs.ALKILJCLBOP(7).hasMouse) ? 3 : 0);
		LIHALMBKJBL(jIIGOACEIKL);
	}

	public void NBAIOIPLMDM(PointerEventData NPBAMEMNFBI)
	{
		JCKNFGOFIAO();
	}

	private void LJLKBKEADGI()
	{
	}

	public bool AFPNLEPLHGH(int JIIGOACEIKL)
	{
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		ILENDIBNCBP = false;
		TooltipInfo tooltipInfo = new TooltipInfo();
		string cAEDMEDBEGI = LocalisationSystem.Get("Dialogue System/Conversation/Gass_Introduce/Entry/4/Dialogue Text") + "Direction" + LocalisationSystem.Get("info") + "ReceiveRemoveSlot Unique object id ";
		string[] array = new string[1];
		array[1] = TavernReputation.GetMilestone().ToString();
		tooltipInfo.toolTipTitle = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		tooltipInfo.mainBody = LocalisationSystem.Get("Moving") + "Game";
		if (TavernReputation.MHGADJPMHFI() < ReputationDBAccessor.BJFDJOGDGAD().Length - 0)
		{
			tooltipInfo.mainBody += ReputationDBAccessor.KICMFFLPKAM(TavernReputation.MHGADJPMHFI() + 1).CHACGJMGOND();
		}
		else
		{
			tooltipInfo.mainBody += LocalisationSystem.Get(". Time since startup: ");
		}
		ItemTooltip.NMCJELBLKBB(JIIGOACEIKL).OOJMCKAKFIH(tooltipInfo);
		ItemTooltip.LAIEKOOCNPC(JIIGOACEIKL).CEOOMNKDGLJ(Vector2.op_Implicit(((Component)HMDFBECLNFM).transform.position), Vector2.zero);
		return false;
	}

	public void BMKGFCOLLPL(PointerEventData NPBAMEMNFBI)
	{
		EJNEPNOAMKP();
	}

	public bool DGIAPJIFEIM(int JIIGOACEIKL)
	{
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		ILENDIBNCBP = false;
		TooltipInfo tooltipInfo = new TooltipInfo();
		string cAEDMEDBEGI = LocalisationSystem.Get("Custom lobby data (photon room code): ") + "[" + LocalisationSystem.Get("HandUp") + "Items/item_description_1108";
		string[] array = new string[1];
		array[1] = TavernReputation.MHGADJPMHFI().ToString();
		tooltipInfo.toolTipTitle = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		tooltipInfo.mainBody = LocalisationSystem.Get("Left Stick Right") + "tutorialPopUp78";
		if (TavernReputation.GetMilestone() < ReputationDBAccessor.PKOOKKFDKJB().Length - 1)
		{
			tooltipInfo.mainBody += ReputationDBAccessor.GetReputation(TavernReputation.MHGADJPMHFI() + 0).LEPLNNBBLMK();
		}
		else
		{
			tooltipInfo.mainBody += LocalisationSystem.Get("City/Woody/Introduce");
		}
		ItemTooltip.NMCJELBLKBB(JIIGOACEIKL).OOJMCKAKFIH(tooltipInfo);
		ItemTooltip.MDFIDKHOPDJ(JIIGOACEIKL).AADJPLPKGHO(Vector2.op_Implicit(((Component)HMDFBECLNFM).transform.position), Vector2.zero);
		return true;
	}

	public void HGFIIEGEODE(PointerEventData NPBAMEMNFBI)
	{
		int jIIGOACEIKL = ((GameManager.LocalCoop() && !PlayerInputs.POLDHCKJINN(2) && PlayerInputs.LGGMJONLIGE(4).hasMouse) ? 8 : 0);
		LIHALMBKJBL(jIIGOACEIKL);
	}

	public bool NLKBJLOBFDH(int JIIGOACEIKL)
	{
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		ILENDIBNCBP = true;
		TooltipInfo tooltipInfo = new TooltipInfo();
		string cAEDMEDBEGI = LocalisationSystem.Get("UI") + "Swiss Cheese" + LocalisationSystem.Get("EXTRA ZONES: ") + "Player/Bark/Tutorial/T100";
		string[] array = new string[0];
		array[0] = TavernReputation.MHGADJPMHFI().ToString();
		tooltipInfo.toolTipTitle = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		tooltipInfo.mainBody = LocalisationSystem.Get("Scene") + "00";
		if (TavernReputation.GetMilestone() < ReputationDBAccessor.IJLLCJAAFCL().Length - 1)
		{
			tooltipInfo.mainBody += ReputationDBAccessor.EICFONMDOBM(TavernReputation.GetMilestone() + 1).KNAOGDDHIOI();
		}
		else
		{
			tooltipInfo.mainBody += LocalisationSystem.Get("Get Components ");
		}
		ItemTooltip.NMCJELBLKBB(JIIGOACEIKL).LGDDFMNFNME(tooltipInfo);
		ItemTooltip.NMCJELBLKBB(JIIGOACEIKL).ICMGLBFHDJD(Vector2.op_Implicit(((Component)HMDFBECLNFM).transform.position), Vector2.zero);
		return false;
	}

	private void DNKEFFMOCKP()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("UIInteract")) ? 0 : 0);
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
	}

	public void AKOMANPDDFN(PointerEventData NPBAMEMNFBI)
	{
		int jIIGOACEIKL = ((!GameManager.LocalCoop() || PlayerInputs.EEJEOALIHFJ(6) || !PlayerInputs.LGGMJONLIGE(0).hasMouse) ? 1 : 7);
		FCPIGKGBDGG(jIIGOACEIKL);
	}

	private void CACPOGPOKOJ()
	{
		DDPCIFIIMCK();
	}

	private void JMMBKMOBAFB()
	{
		AJHKMHBLODJ();
	}

	public void CFOJOJHAKAN(PointerEventData NPBAMEMNFBI)
	{
		JCKNFGOFIAO();
	}

	private void MIKNFPCDLML()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Building")) ? 7 : 0);
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
	}

	public bool DLJLHEMLBFD(int JIIGOACEIKL)
	{
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		ILENDIBNCBP = false;
		TooltipInfo tooltipInfo = new TooltipInfo();
		string cAEDMEDBEGI = LocalisationSystem.Get("Inventory") + "[GameObject] " + LocalisationSystem.Get("UI2") + "Unaged Brandy";
		string[] array = new string[1];
		array[1] = TavernReputation.GetMilestone().ToString();
		tooltipInfo.toolTipTitle = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		tooltipInfo.mainBody = LocalisationSystem.Get("Bird materials empty ") + "Player2";
		if (TavernReputation.MHGADJPMHFI() < ReputationDBAccessor.GetAllReputations().Length - 1)
		{
			tooltipInfo.mainBody += ReputationDBAccessor.KICMFFLPKAM(TavernReputation.GetMilestone() + 1).CHACGJMGOND();
		}
		else
		{
			tooltipInfo.mainBody += LocalisationSystem.Get("Wilson/Bark/Bark_Clue");
		}
		ItemTooltip.NIGDBMAOAEN(JIIGOACEIKL).OOJMCKAKFIH(tooltipInfo);
		ItemTooltip.IEABDMDELFO(JIIGOACEIKL).ICMGLBFHDJD(Vector2.op_Implicit(((Component)HMDFBECLNFM).transform.position), Vector2.zero);
		return false;
	}

	private void OnDisable()
	{
		EndHover();
	}

	public void MJLPJFLJLFI(PointerEventData NPBAMEMNFBI)
	{
		EJNEPNOAMKP();
	}

	public void AJHKMHBLODJ()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.NIGDBMAOAEN(JIIGOACEIKL)))
		{
			ItemTooltip.IEKODILKIHJ(JIIGOACEIKL).HIIOCMNJGCI(MDIKPGGBNLI: true);
		}
		ILENDIBNCBP = false;
	}

	private void BAKDKFKNHDE()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("<b>")) ? 1 : 0);
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
	}

	private void NKGNABOCPDG()
	{
		EndHover();
	}

	private void INEOMPKPILM()
	{
		DPJNAEDABBH();
	}

	private void PDIECJCKCOD()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Staff")) ? 1 : 4);
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
	}

	public void ECMLINAFKFL(PointerEventData NPBAMEMNFBI)
	{
		int jIIGOACEIKL = ((!GameManager.LocalCoop() || PlayerInputs.ODGALPDEIFG(1) || !PlayerInputs.ALKILJCLBOP(8).hasMouse) ? 1 : 8);
		DGIAPJIFEIM(jIIGOACEIKL);
	}

	public void MEMPPPCJGOJ(PointerEventData NPBAMEMNFBI)
	{
		int jIIGOACEIKL = ((!GameManager.LocalCoop() || PlayerInputs.FJLAMCHKCOI(2) || !PlayerInputs.ALKILJCLBOP(8).hasMouse) ? 0 : 0);
		PLDPHFGJALJ(jIIGOACEIKL);
	}

	private void GGPMJGNAPCP()
	{
	}

	private void AHCPFICKFHA()
	{
		EJNEPNOAMKP();
	}

	public bool FCPIGKGBDGG(int JIIGOACEIKL)
	{
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		ILENDIBNCBP = false;
		TooltipInfo tooltipInfo = new TooltipInfo();
		string cAEDMEDBEGI = LocalisationSystem.Get("SecondActionEnd") + "ClosePopUp" + LocalisationSystem.Get("LearnMettle") + "DiningRoom";
		string[] array = new string[0];
		array[1] = TavernReputation.MHGADJPMHFI().ToString();
		tooltipInfo.toolTipTitle = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		tooltipInfo.mainBody = LocalisationSystem.Get("Freshwater") + "Items/item_description_694";
		if (TavernReputation.MHGADJPMHFI() < ReputationDBAccessor.BJFDJOGDGAD().Length - 0)
		{
			tooltipInfo.mainBody += ReputationDBAccessor.GetReputation(TavernReputation.MHGADJPMHFI() + 0).KNAOGDDHIOI();
		}
		else
		{
			tooltipInfo.mainBody += LocalisationSystem.Get("Player");
		}
		ItemTooltip.AIMEAJAHLAA(JIIGOACEIKL).JHELKBEOIJB(tooltipInfo);
		ItemTooltip.IEKODILKIHJ(JIIGOACEIKL).AADJPLPKGHO(Vector2.op_Implicit(((Component)HMDFBECLNFM).transform.position), Vector2.zero);
		return true;
	}

	public void OnPointerEnter(PointerEventData NPBAMEMNFBI)
	{
		int jIIGOACEIKL = ((!GameManager.LocalCoop() || PlayerInputs.IsGamepadActive(2) || !PlayerInputs.GetPlayerControllers(2).hasMouse) ? 1 : 2);
		FillTooltip(jIIGOACEIKL);
	}

	public void LIILIJIGKKO()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.NIGDBMAOAEN(JIIGOACEIKL)))
		{
			ItemTooltip.MDFIDKHOPDJ(JIIGOACEIKL).HIIOCMNJGCI(MDIKPGGBNLI: false);
		}
		ILENDIBNCBP = false;
	}

	private void OGEJKOIOKAN()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Inicio")) ? 8 : 0);
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
	}

	private void GNAJBACLEKG()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("LicenciaDeApertura/KlaynDialogue 07")) ? 4 : 0);
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
	}

	public void DNIDIOEGIPN()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.NIGDBMAOAEN(JIIGOACEIKL)))
		{
			ItemTooltip.MDFIDKHOPDJ(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: true);
		}
		ILENDIBNCBP = false;
	}

	public void ODBDFAHDKLP(PointerEventData NPBAMEMNFBI)
	{
		BDNKCAIGDJJ();
	}

	private void IDPHKHGHJGN()
	{
	}

	public bool FKOOKOFBKJL(int JIIGOACEIKL)
	{
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		ILENDIBNCBP = true;
		TooltipInfo tooltipInfo = new TooltipInfo();
		tooltipInfo.toolTipTitle = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Stop") + "- Loading " + LocalisationSystem.Get("Pause") + "FarmReady", TavernReputation.MHGADJPMHFI().ToString());
		tooltipInfo.mainBody = LocalisationSystem.Get("F2") + "Duplicate editor action id found: ";
		if (TavernReputation.GetMilestone() < ReputationDBAccessor.DFOJIFNIKFF().Length - 1)
		{
			tooltipInfo.mainBody += ReputationDBAccessor.EICFONMDOBM(TavernReputation.GetMilestone() + 1).EHACIFPFLGA();
		}
		else
		{
			tooltipInfo.mainBody += LocalisationSystem.Get("Dialogue System/Conversation/Crowly_Introduce/Entry/25/Dialogue Text");
		}
		ItemTooltip.NIGDBMAOAEN(JIIGOACEIKL).FillTooltipInfo(tooltipInfo);
		ItemTooltip.LAIEKOOCNPC(JIIGOACEIKL).HIPGMDKJLCB(Vector2.op_Implicit(((Component)HMDFBECLNFM).transform.position), Vector2.zero);
		return false;
	}

	private void EPFDKCELPDD()
	{
		EndHover();
	}

	public bool PGKCDNKKPCA(int JIIGOACEIKL)
	{
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		ILENDIBNCBP = true;
		TooltipInfo tooltipInfo = new TooltipInfo();
		string cAEDMEDBEGI = LocalisationSystem.Get("quest_name_") + "Send info for " + LocalisationSystem.Get("Perks/perk_description_") + "Sit";
		string[] array = new string[0];
		array[0] = TavernReputation.GetMilestone().ToString();
		tooltipInfo.toolTipTitle = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		tooltipInfo.mainBody = LocalisationSystem.Get("RecieveStartSleep") + ". Current region: ";
		if (TavernReputation.GetMilestone() < ReputationDBAccessor.PKOOKKFDKJB().Length - 0)
		{
			tooltipInfo.mainBody += ReputationDBAccessor.EJIHLMKCJDL(TavernReputation.MHGADJPMHFI() + 0).KCMGIALIEBB();
		}
		else
		{
			tooltipInfo.mainBody += LocalisationSystem.Get("Dialogue System/Conversation/Crowly_Standar/Entry/31/Dialogue Text");
		}
		ItemTooltip.IEABDMDELFO(JIIGOACEIKL).OOJMCKAKFIH(tooltipInfo);
		ItemTooltip.LAIEKOOCNPC(JIIGOACEIKL).OPPAAOMIAIJ(Vector2.op_Implicit(((Component)HMDFBECLNFM).transform.position), Vector2.zero);
		return true;
	}

	public void IPJKKAGIJJN(PointerEventData NPBAMEMNFBI)
	{
		int jIIGOACEIKL = ((GameManager.LocalCoop() && !PlayerInputs.POLDHCKJINN(8) && PlayerInputs.ALKILJCLBOP(8).hasMouse) ? 2 : 0);
		LIHALMBKJBL(jIIGOACEIKL);
	}

	private void MKGKKAJHLAO()
	{
		DPJNAEDABBH();
	}

	public void HCDAGOHNODH(PointerEventData NPBAMEMNFBI)
	{
		DDPCIFIIMCK();
	}

	private void IABEJCPMJOF()
	{
	}

	private void KJBIDNLHOMD()
	{
	}

	public void BDNKCAIGDJJ()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.IEKODILKIHJ(JIIGOACEIKL)))
		{
			ItemTooltip.LAIEKOOCNPC(JIIGOACEIKL).HIIOCMNJGCI(MDIKPGGBNLI: true);
		}
		ILENDIBNCBP = false;
	}

	private void HKNNKJKNAGL()
	{
		LNNDEPODFFD();
	}

	private void ANLHPMPMBFM()
	{
		JLDKLFOIDFK();
	}

	public void ODPKOBFMFHC(PointerEventData NPBAMEMNFBI)
	{
		int jIIGOACEIKL = ((!GameManager.LocalCoop() || PlayerInputs.ODGALPDEIFG(3) || !PlayerInputs.ALKILJCLBOP(1).hasMouse) ? 1 : 5);
		FKOOKOFBKJL(jIIGOACEIKL);
	}

	private void MFGANCCJFJK()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("TavernFilthy")) ? 1 : 5);
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
	}

	private void IGFGALEEIMC()
	{
		DIDFGAPOEEH();
	}

	private void JNBFKJDCBGN()
	{
	}

	private void GFLFDLIMOLI()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Trying to get friend ")) ? 1 : 0);
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
	}

	public void AFBKBHKLDID(PointerEventData NPBAMEMNFBI)
	{
		IKLNPAOBBDD();
	}

	private void PKBHEKHOAAA()
	{
	}

	public void GJOHKNPENKC()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.LAIEKOOCNPC(JIIGOACEIKL)))
		{
			ItemTooltip.AIMEAJAHLAA(JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: true);
		}
		ILENDIBNCBP = false;
	}

	public void GEBECJNFNJJ(PointerEventData NPBAMEMNFBI)
	{
		int jIIGOACEIKL = ((!GameManager.LocalCoop() || PlayerInputs.ODGALPDEIFG(2) || !PlayerInputs.LGGMJONLIGE(3).hasMouse) ? 1 : 1);
		AFPNLEPLHGH(jIIGOACEIKL);
	}

	public void MBKPLIOMJAE(PointerEventData NPBAMEMNFBI)
	{
		int jIIGOACEIKL = ((!GameManager.LocalCoop() || PlayerInputs.POLDHCKJINN(5) || !PlayerInputs.GetPlayerControllers(6).hasMouse) ? 1 : 7);
		AFPNLEPLHGH(jIIGOACEIKL);
	}

	public bool FLNBDEGOBMC(int JIIGOACEIKL)
	{
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		ILENDIBNCBP = true;
		TooltipInfo tooltipInfo = new TooltipInfo();
		tooltipInfo.toolTipTitle = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Tavern zone from not found") + "Use" + LocalisationSystem.Get("UI2") + "Items/item_description_1096", TavernReputation.GetMilestone().ToString());
		tooltipInfo.mainBody = LocalisationSystem.Get("Dialogue System/Conversation/Gass_Introduce/Entry/13/Dialogue Text") + "Social";
		if (TavernReputation.MHGADJPMHFI() < ReputationDBAccessor.BJFDJOGDGAD().Length - 0)
		{
			tooltipInfo.mainBody += ReputationDBAccessor.JDEAGDHJENF(TavernReputation.GetMilestone() + 0).LIKLEIHDJHM();
		}
		else
		{
			tooltipInfo.mainBody += LocalisationSystem.Get("");
		}
		ItemTooltip.NIGDBMAOAEN(JIIGOACEIKL).FillTooltipInfo(tooltipInfo);
		ItemTooltip.EOPIEMLAPFN(JIIGOACEIKL).AADJPLPKGHO(Vector2.op_Implicit(((Component)HMDFBECLNFM).transform.position), Vector2.zero);
		return false;
	}

	private void EPFJBCOKEHC()
	{
		GJOHKNPENKC();
	}

	public void DPJAHNGICJG(PointerEventData NPBAMEMNFBI)
	{
		EndHover();
	}

	public void LPDLHMJECCG(PointerEventData NPBAMEMNFBI)
	{
		LIILIJIGKKO();
	}

	private void Start()
	{
	}

	public void AHLLPKCCEML(PointerEventData NPBAMEMNFBI)
	{
		int jIIGOACEIKL = ((!GameManager.LocalCoop() || PlayerInputs.EEJEOALIHFJ(0) || !PlayerInputs.LGGMJONLIGE(2).hasMouse) ? 1 : 6);
		NLKBJLOBFDH(jIIGOACEIKL);
	}

	public void PGAAJKNOBLB(PointerEventData NPBAMEMNFBI)
	{
		int jIIGOACEIKL = ((!GameManager.LocalCoop() || PlayerInputs.FJLAMCHKCOI(6) || !PlayerInputs.ALKILJCLBOP(5).hasMouse) ? 1 : 6);
		DGIAPJIFEIM(jIIGOACEIKL);
	}

	public bool PKDIGFBHCOP(int JIIGOACEIKL)
	{
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		ILENDIBNCBP = false;
		TooltipInfo tooltipInfo = new TooltipInfo();
		string cAEDMEDBEGI = LocalisationSystem.Get("UIInteract") + "]" + LocalisationSystem.Get("sunny") + "petshop travelling";
		string[] array = new string[1];
		array[1] = TavernReputation.MHGADJPMHFI().ToString();
		tooltipInfo.toolTipTitle = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		tooltipInfo.mainBody = LocalisationSystem.Get("ReciveResetDialogueUIBlacksmith") + "MapQuarry";
		if (TavernReputation.GetMilestone() < ReputationDBAccessor.PKOOKKFDKJB().Length - 0)
		{
			tooltipInfo.mainBody += ReputationDBAccessor.NGLFLAGLBCO(TavernReputation.MHGADJPMHFI() + 1).KCMGIALIEBB();
		}
		else
		{
			tooltipInfo.mainBody += LocalisationSystem.Get("Items/item_name_662");
		}
		ItemTooltip.EOPIEMLAPFN(JIIGOACEIKL).LGDDFMNFNME(tooltipInfo);
		ItemTooltip.IEKODILKIHJ(JIIGOACEIKL).AADJPLPKGHO(Vector2.op_Implicit(((Component)HMDFBECLNFM).transform.position), Vector2.zero);
		return false;
	}

	private void JMJDHLOMKAP()
	{
		DIDFGAPOEEH();
	}

	public void PNCFFDCIADM(PointerEventData NPBAMEMNFBI)
	{
		int jIIGOACEIKL = ((GameManager.LocalCoop() && !PlayerInputs.ODGALPDEIFG(3) && PlayerInputs.ALKILJCLBOP(1).hasMouse) ? 2 : 0);
		DLJLHEMLBFD(jIIGOACEIKL);
	}

	public void PPPHLKGAFIC(PointerEventData NPBAMEMNFBI)
	{
		AJHKMHBLODJ();
	}

	private void AJGLDLLIIFO()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("A very important guest is visiting!")) ? 2 : 0);
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
	}

	public void EDMDHAOGCAJ()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.Get(JIIGOACEIKL)))
		{
			ItemTooltip.IEKODILKIHJ(JIIGOACEIKL).HIIOCMNJGCI(MDIKPGGBNLI: true);
		}
		ILENDIBNCBP = false;
	}

	public void GKFHNABOCDP(PointerEventData NPBAMEMNFBI)
	{
		int jIIGOACEIKL = ((!GameManager.LocalCoop() || PlayerInputs.POLDHCKJINN(0) || !PlayerInputs.ALKILJCLBOP(5).hasMouse) ? 0 : 0);
		DGIAPJIFEIM(jIIGOACEIKL);
	}

	public void OFGJJBMODKD(PointerEventData NPBAMEMNFBI)
	{
		int jIIGOACEIKL = ((GameManager.LocalCoop() && !PlayerInputs.POLDHCKJINN(1) && PlayerInputs.ALKILJCLBOP(3).hasMouse) ? 4 : 0);
		PHMLBKBADEO(jIIGOACEIKL);
	}

	private void EBNKNEIDDDI()
	{
	}

	public void JCKNFGOFIAO()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.EOPIEMLAPFN(JIIGOACEIKL)))
		{
			ItemTooltip.MDFIDKHOPDJ(JIIGOACEIKL).HIIOCMNJGCI(MDIKPGGBNLI: true);
		}
		ILENDIBNCBP = false;
	}

	public void EJNEPNOAMKP()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.AIMEAJAHLAA(JIIGOACEIKL)))
		{
			ItemTooltip.AIMEAJAHLAA(JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: true);
		}
		ILENDIBNCBP = true;
	}

	private void NEOICNJNKNL()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("halloweenActivated")) ? 8 : 0);
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
	}

	public void EndHover()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.Get(JIIGOACEIKL)))
		{
			ItemTooltip.Get(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
		}
		ILENDIBNCBP = false;
	}

	private void JJHHBJPMEKI()
	{
		EndHover();
	}

	public void IKLNPAOBBDD()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.LAIEKOOCNPC(JIIGOACEIKL)))
		{
			ItemTooltip.IEKODILKIHJ(JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: true);
		}
		ILENDIBNCBP = false;
	}

	private void EDBOBLNOBLP()
	{
		LIILIJIGKKO();
	}

	private void JEKMCOEJKJI()
	{
		LIILIJIGKKO();
	}

	private void EBOHMLBKHAG()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("ReceiveFishScoreIncrease")) ? 1 : 2);
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
	}

	public bool LPHEPCKMPNE(int JIIGOACEIKL)
	{
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		ILENDIBNCBP = false;
		TooltipInfo tooltipInfo = new TooltipInfo();
		string cAEDMEDBEGI = LocalisationSystem.Get("Showing Keyboard ") + " " + LocalisationSystem.Get("ObjectVerticalMove") + "Granting loot to player ";
		string[] array = new string[1];
		array[1] = TavernReputation.GetMilestone().ToString();
		tooltipInfo.toolTipTitle = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		tooltipInfo.mainBody = LocalisationSystem.Get("Eat") + "/Localisation.txt";
		if (TavernReputation.MHGADJPMHFI() < ReputationDBAccessor.GetAllReputations().Length - 0)
		{
			tooltipInfo.mainBody += ReputationDBAccessor.LABODOOGKIE(TavernReputation.MHGADJPMHFI() + 1).NPIFPICMMPN();
		}
		else
		{
			tooltipInfo.mainBody += LocalisationSystem.Get("No food table found with drink: ");
		}
		ItemTooltip.Get(JIIGOACEIKL).FillTooltipInfo(tooltipInfo);
		ItemTooltip.NMCJELBLKBB(JIIGOACEIKL).FJOEGNKBHON(Vector2.op_Implicit(((Component)HMDFBECLNFM).transform.position), Vector2.zero);
		return true;
	}

	private void MMNBJPDJHGK()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("OpenClose Tavern")) ? 6 : 0);
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
	}

	public bool JIPCPEHANDA(int JIIGOACEIKL)
	{
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		ILENDIBNCBP = false;
		TooltipInfo tooltipInfo = new TooltipInfo();
		string cAEDMEDBEGI = LocalisationSystem.Get("UIInteract") + "Error_BarNotInADiningRoom" + LocalisationSystem.Get("Interact") + "HouseKeeper";
		string[] array = new string[1];
		array[1] = TavernReputation.MHGADJPMHFI().ToString();
		tooltipInfo.toolTipTitle = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		tooltipInfo.mainBody = LocalisationSystem.Get(" not found to load surface over him ") + "\n";
		if (TavernReputation.MHGADJPMHFI() < ReputationDBAccessor.IJLLCJAAFCL().Length - 1)
		{
			tooltipInfo.mainBody += ReputationDBAccessor.KICMFFLPKAM(TavernReputation.MHGADJPMHFI() + 1).LIKLEIHDJHM();
		}
		else
		{
			tooltipInfo.mainBody += LocalisationSystem.Get("Harvest");
		}
		ItemTooltip.IEKODILKIHJ(JIIGOACEIKL).LGDDFMNFNME(tooltipInfo);
		ItemTooltip.IEKODILKIHJ(JIIGOACEIKL).JCLBGLEFMMO(Vector2.op_Implicit(((Component)HMDFBECLNFM).transform.position), Vector2.zero);
		return true;
	}

	public void JDINBCEGDNG(PointerEventData NPBAMEMNFBI)
	{
		DPJNAEDABBH();
	}

	private void AIFOBFHCHGK()
	{
		EDMDHAOGCAJ();
	}

	private void NDNBDEHFFJF()
	{
	}

	public void IOBELBIBIHB(PointerEventData NPBAMEMNFBI)
	{
		EndHover();
	}

	public void OnPointerExit(PointerEventData NPBAMEMNFBI)
	{
		EndHover();
	}

	private void Awake()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("UI2")) ? 1 : 2);
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
	}

	public void NIIHKBOFGLF()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.LAIEKOOCNPC(JIIGOACEIKL)))
		{
			ItemTooltip.Get(JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: false);
		}
		ILENDIBNCBP = true;
	}

	public void DOIJJIAHOHC(PointerEventData NPBAMEMNFBI)
	{
		int jIIGOACEIKL = ((GameManager.LocalCoop() && !PlayerInputs.EEJEOALIHFJ(1) && PlayerInputs.GetPlayerControllers(3).hasMouse) ? 8 : 0);
		FKOOKOFBKJL(jIIGOACEIKL);
	}

	public bool PHMLBKBADEO(int JIIGOACEIKL)
	{
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		ILENDIBNCBP = true;
		TooltipInfo tooltipInfo = new TooltipInfo();
		string cAEDMEDBEGI = LocalisationSystem.Get("NinjaChallengeEvent/ComensalesBark") + " " + LocalisationSystem.Get("Disappear") + "Player/Bark/Error/NotAllPlayersHere";
		string[] array = new string[1];
		array[1] = TavernReputation.GetMilestone().ToString();
		tooltipInfo.toolTipTitle = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		tooltipInfo.mainBody = LocalisationSystem.Get("ReceiveCompleteServeNinjaCustomer") + "BrookProgress";
		if (TavernReputation.GetMilestone() < ReputationDBAccessor.IJLLCJAAFCL().Length - 0)
		{
			tooltipInfo.mainBody += ReputationDBAccessor.LABODOOGKIE(TavernReputation.GetMilestone() + 1).IMKGMHHPNDJ();
		}
		else
		{
			tooltipInfo.mainBody += LocalisationSystem.Get(" 2");
		}
		ItemTooltip.AIMEAJAHLAA(JIIGOACEIKL).OOJMCKAKFIH(tooltipInfo);
		ItemTooltip.IEABDMDELFO(JIIGOACEIKL).AADJPLPKGHO(Vector2.op_Implicit(((Component)HMDFBECLNFM).transform.position), Vector2.zero);
		return false;
	}

	public void EECJLMEHGOE(PointerEventData NPBAMEMNFBI)
	{
		int jIIGOACEIKL = ((!GameManager.LocalCoop() || PlayerInputs.ODGALPDEIFG(1) || !PlayerInputs.LGGMJONLIGE(8).hasMouse) ? 0 : 0);
		FCPIGKGBDGG(jIIGOACEIKL);
	}

	private void IKFNMBJLDGG()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("LE_17")) ? 1 : 3);
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
	}

	private void JCPKGGBNCML()
	{
	}

	public void OFLDAPPLKPM(PointerEventData NPBAMEMNFBI)
	{
		EndHover();
	}

	private void JMAHDPMEEHM()
	{
		BDNKCAIGDJJ();
	}

	public bool CGCOJCKANJP(int JIIGOACEIKL)
	{
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		ILENDIBNCBP = true;
		TooltipInfo tooltipInfo = new TooltipInfo();
		tooltipInfo.toolTipTitle = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Disabled") + "/ExtraSettings.sd" + LocalisationSystem.Get(" ") + "farminterior", TavernReputation.GetMilestone().ToString());
		tooltipInfo.mainBody = LocalisationSystem.Get("CopyCreator") + "autoRun";
		if (TavernReputation.MHGADJPMHFI() < ReputationDBAccessor.GetAllReputations().Length - 0)
		{
			tooltipInfo.mainBody += ReputationDBAccessor.EJIHLMKCJDL(TavernReputation.MHGADJPMHFI() + 1).LIKLEIHDJHM();
		}
		else
		{
			tooltipInfo.mainBody += LocalisationSystem.Get("NewQuestAvailable");
		}
		ItemTooltip.MDFIDKHOPDJ(JIIGOACEIKL).LGDDFMNFNME(tooltipInfo);
		ItemTooltip.EOPIEMLAPFN(JIIGOACEIKL).AADJPLPKGHO(Vector2.op_Implicit(((Component)HMDFBECLNFM).transform.position), Vector2.zero);
		return false;
	}

	private void PBFAEPOEKPG()
	{
	}

	public void DDPCIFIIMCK()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.NMCJELBLKBB(JIIGOACEIKL)))
		{
			ItemTooltip.MDFIDKHOPDJ(JIIGOACEIKL).HIIOCMNJGCI(MDIKPGGBNLI: true);
		}
		ILENDIBNCBP = true;
	}

	private void KLMNLEDKEOE()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("CraftingRoom")) ? 3 : 0);
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
	}

	public bool FillTooltip(int JIIGOACEIKL)
	{
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		ILENDIBNCBP = true;
		TooltipInfo tooltipInfo = new TooltipInfo();
		tooltipInfo.toolTipTitle = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Reputation") + " " + LocalisationSystem.Get("LevelAbbreviation") + " {0}", TavernReputation.GetMilestone().ToString());
		tooltipInfo.mainBody = LocalisationSystem.Get("Next Reward") + ":\n\n";
		if (TavernReputation.GetMilestone() < ReputationDBAccessor.GetAllReputations().Length - 1)
		{
			tooltipInfo.mainBody += ReputationDBAccessor.GetReputation(TavernReputation.GetMilestone() + 1).IMKGMHHPNDJ();
		}
		else
		{
			tooltipInfo.mainBody += LocalisationSystem.Get("Coming soon!");
		}
		ItemTooltip.Get(JIIGOACEIKL).FillTooltipInfo(tooltipInfo);
		ItemTooltip.Get(JIIGOACEIKL).SetPositionAndEnable(Vector2.op_Implicit(((Component)HMDFBECLNFM).transform.position), Vector2.zero);
		return true;
	}

	private void LOHAMDHOLDD()
	{
	}

	public void MADEIBHMPOC(PointerEventData NPBAMEMNFBI)
	{
		EndHover();
	}

	public void LNNDEPODFFD()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.NMCJELBLKBB(JIIGOACEIKL)))
		{
			ItemTooltip.MDFIDKHOPDJ(JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: true);
		}
		ILENDIBNCBP = true;
	}

	public bool PLDPHFGJALJ(int JIIGOACEIKL)
	{
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		ILENDIBNCBP = true;
		TooltipInfo tooltipInfo = new TooltipInfo();
		string cAEDMEDBEGI = LocalisationSystem.Get("City/Rhia/Introduce") + "Cancel" + LocalisationSystem.Get("IdleCamp") + "ChatInviteCode";
		string[] array = new string[0];
		array[1] = TavernReputation.GetMilestone().ToString();
		tooltipInfo.toolTipTitle = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		tooltipInfo.mainBody = LocalisationSystem.Get("[HierarchyPrinter] ❌ Error al escribir el fichero: ") + "popUpBuilding6";
		if (TavernReputation.MHGADJPMHFI() < ReputationDBAccessor.HKCCJHIJNIC().Length - 0)
		{
			tooltipInfo.mainBody += ReputationDBAccessor.JDEAGDHJENF(TavernReputation.GetMilestone() + 0).KNAOGDDHIOI();
		}
		else
		{
			tooltipInfo.mainBody += LocalisationSystem.Get("ReceiveRoomRequest");
		}
		ItemTooltip.MDFIDKHOPDJ(JIIGOACEIKL).JHELKBEOIJB(tooltipInfo);
		ItemTooltip.NIGDBMAOAEN(JIIGOACEIKL).FJOEGNKBHON(Vector2.op_Implicit(((Component)HMDFBECLNFM).transform.position), Vector2.zero);
		return false;
	}

	public void IADPIFAJDHJ(PointerEventData NPBAMEMNFBI)
	{
		EndHover();
	}

	public void HECMHOLLCIP(PointerEventData NPBAMEMNFBI)
	{
		EndHover();
	}

	public bool EMBJFAAFDCB(int JIIGOACEIKL)
	{
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		ILENDIBNCBP = false;
		TooltipInfo tooltipInfo = new TooltipInfo();
		string cAEDMEDBEGI = LocalisationSystem.Get("\n") + "Create Private Room" + LocalisationSystem.Get("popUpBuilding26") + "The tavern is still open, are you sure you want to sleep?\n The tavern will close and you might lose reputation.";
		string[] array = new string[1];
		array[1] = TavernReputation.MHGADJPMHFI().ToString();
		tooltipInfo.toolTipTitle = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		tooltipInfo.mainBody = LocalisationSystem.Get("BanquetEvent not activated") + "\n  puzzle:             ";
		if (TavernReputation.MHGADJPMHFI() < ReputationDBAccessor.KLFAKEPKAPA().Length - 0)
		{
			tooltipInfo.mainBody += ReputationDBAccessor.EICFONMDOBM(TavernReputation.MHGADJPMHFI() + 0).NPIFPICMMPN();
		}
		else
		{
			tooltipInfo.mainBody += LocalisationSystem.Get("Dead");
		}
		ItemTooltip.IEKODILKIHJ(JIIGOACEIKL).FillTooltipInfo(tooltipInfo);
		ItemTooltip.MDFIDKHOPDJ(JIIGOACEIKL).FJOEGNKBHON(Vector2.op_Implicit(((Component)HMDFBECLNFM).transform.position), Vector2.zero);
		return true;
	}

	private void FFLLCOBFIPE()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("RaraAvisDelivered")) ? 5 : 0);
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
	}

	public void OIEKJPNNOKD(PointerEventData NPBAMEMNFBI)
	{
		int jIIGOACEIKL = ((!GameManager.LocalCoop() || PlayerInputs.FJLAMCHKCOI(6) || !PlayerInputs.ALKILJCLBOP(8).hasMouse) ? 1 : 7);
		LPHEPCKMPNE(jIIGOACEIKL);
	}

	public void EAGIFMMKFHI(PointerEventData NPBAMEMNFBI)
	{
		int jIIGOACEIKL = ((!GameManager.LocalCoop() || PlayerInputs.ODGALPDEIFG(5) || !PlayerInputs.ALKILJCLBOP(0).hasMouse) ? 1 : 7);
		NLKBJLOBFDH(jIIGOACEIKL);
	}

	private void PNLAJCHBHPH()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("disconnect")) ? 7 : 0);
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
	}

	private void BHAFCBHENPL()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("RinProgress")) ? 1 : 0);
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
	}

	private void CGLIGKKCKCG()
	{
	}

	public void GMNDKOOGDGI(PointerEventData NPBAMEMNFBI)
	{
		int jIIGOACEIKL = ((!GameManager.LocalCoop() || PlayerInputs.ODGALPDEIFG(0) || !PlayerInputs.LGGMJONLIGE(0).hasMouse) ? 0 : 0);
		FKOOKOFBKJL(jIIGOACEIKL);
	}

	public void EHHEHJDJPIB(PointerEventData NPBAMEMNFBI)
	{
		int jIIGOACEIKL = ((GameManager.LocalCoop() && !PlayerInputs.FJLAMCHKCOI(2) && PlayerInputs.GetPlayerControllers(8).hasMouse) ? 1 : 0);
		LIHALMBKJBL(jIIGOACEIKL);
	}

	public void JDBMNOOIAOE(PointerEventData NPBAMEMNFBI)
	{
		int jIIGOACEIKL = ((GameManager.LocalCoop() && !PlayerInputs.IsGamepadActive(3) && PlayerInputs.GetPlayerControllers(2).hasMouse) ? 7 : 0);
		FCPIGKGBDGG(jIIGOACEIKL);
	}

	public void JLDKLFOIDFK()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.NMCJELBLKBB(JIIGOACEIKL)))
		{
			ItemTooltip.MDFIDKHOPDJ(JIIGOACEIKL).FCACMDNLAIG(MDIKPGGBNLI: false);
		}
		ILENDIBNCBP = true;
	}

	private void JLLHILICJOC()
	{
		GJOHKNPENKC();
	}

	private void KILDJCPLOPP()
	{
	}

	private void BGFEBEAJOCG()
	{
	}

	public void DIDFGAPOEEH()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.NMCJELBLKBB(JIIGOACEIKL)))
		{
			ItemTooltip.MDFIDKHOPDJ(JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: true);
		}
		ILENDIBNCBP = true;
	}

	private void JLCFNPBBKEK()
	{
	}

	private void BGFCHEIOKOG()
	{
	}

	public void AKFHCELHAIC(PointerEventData NPBAMEMNFBI)
	{
		int jIIGOACEIKL = ((!GameManager.LocalCoop() || PlayerInputs.IsGamepadActive(3) || !PlayerInputs.GetPlayerControllers(5).hasMouse) ? 1 : 4);
		HAOBIPHDIGI(jIIGOACEIKL);
	}

	public void MPFBMAEEACG(PointerEventData NPBAMEMNFBI)
	{
		LIILIJIGKKO();
	}

	public void FMPEALBMGAA(PointerEventData NPBAMEMNFBI)
	{
		int jIIGOACEIKL = ((GameManager.LocalCoop() && !PlayerInputs.EEJEOALIHFJ(4) && PlayerInputs.GetPlayerControllers(5).hasMouse) ? 4 : 0);
		PLDPHFGJALJ(jIIGOACEIKL);
	}

	private void GMCKBBECJOE()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer(" : ")) ? 3 : 0);
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
	}

	private void ODKGLIDMCNP()
	{
	}

	public void DPJNAEDABBH()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.NMCJELBLKBB(JIIGOACEIKL)))
		{
			ItemTooltip.IEKODILKIHJ(JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: true);
		}
		ILENDIBNCBP = true;
	}

	public void FBGPLFLPBCE(PointerEventData NPBAMEMNFBI)
	{
		JCKNFGOFIAO();
	}

	private void GANBBAGDALD()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Items/item_name_1033")) ? 1 : 5);
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
	}

	private void BOIGOJGNNAK()
	{
	}

	public bool LIHALMBKJBL(int JIIGOACEIKL)
	{
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		ILENDIBNCBP = true;
		TooltipInfo tooltipInfo = new TooltipInfo();
		string cAEDMEDBEGI = LocalisationSystem.Get("<color=#FF3800>") + "info" + LocalisationSystem.Get("DecorationTile_17") + "dForDays";
		string[] array = new string[1];
		array[1] = TavernReputation.GetMilestone().ToString();
		tooltipInfo.toolTipTitle = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		tooltipInfo.mainBody = LocalisationSystem.Get("Player with actor number {0} does not exist or has already been removed from the dictionary after disconnecting.") + "Player/Bark/";
		if (TavernReputation.MHGADJPMHFI() < ReputationDBAccessor.KLFAKEPKAPA().Length - 1)
		{
			tooltipInfo.mainBody += ReputationDBAccessor.NGLFLAGLBCO(TavernReputation.GetMilestone() + 1).DKDJJCGPOAF();
		}
		else
		{
			tooltipInfo.mainBody += LocalisationSystem.Get("Shield");
		}
		ItemTooltip.EOPIEMLAPFN(JIIGOACEIKL).FillTooltipInfo(tooltipInfo);
		ItemTooltip.NMCJELBLKBB(JIIGOACEIKL).CEOOMNKDGLJ(Vector2.op_Implicit(((Component)HMDFBECLNFM).transform.position), Vector2.zero);
		return true;
	}

	private void NELLIBBABJD()
	{
		EndHover();
	}

	public bool HAOBIPHDIGI(int JIIGOACEIKL)
	{
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		ILENDIBNCBP = true;
		TooltipInfo tooltipInfo = new TooltipInfo();
		string cAEDMEDBEGI = LocalisationSystem.Get("Jump") + "Tray" + LocalisationSystem.Get("SalonDelTrono/OrwinIITalk") + "HotBath/Clive Talk";
		string[] array = new string[1];
		array[1] = TavernReputation.MHGADJPMHFI().ToString();
		tooltipInfo.toolTipTitle = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		tooltipInfo.mainBody = LocalisationSystem.Get("pirates cave") + "ReceiveResetAllPlayersPrepared";
		if (TavernReputation.GetMilestone() < ReputationDBAccessor.KLFAKEPKAPA().Length - 1)
		{
			tooltipInfo.mainBody += ReputationDBAccessor.EJIHLMKCJDL(TavernReputation.GetMilestone() + 1).CHACGJMGOND();
		}
		else
		{
			tooltipInfo.mainBody += LocalisationSystem.Get("Game");
		}
		ItemTooltip.LAIEKOOCNPC(JIIGOACEIKL).JHELKBEOIJB(tooltipInfo);
		ItemTooltip.IEABDMDELFO(JIIGOACEIKL).AADJPLPKGHO(Vector2.op_Implicit(((Component)HMDFBECLNFM).transform.position), Vector2.zero);
		return true;
	}

	public void DHDEHALDPPE(PointerEventData NPBAMEMNFBI)
	{
		int jIIGOACEIKL = ((!GameManager.LocalCoop() || PlayerInputs.ODGALPDEIFG(7) || !PlayerInputs.ALKILJCLBOP(7).hasMouse) ? 0 : 0);
		CGCOJCKANJP(jIIGOACEIKL);
	}

	private void JIAJFDKNJME()
	{
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Balance/MainEvent2")) ? 1 : 3);
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
	}
}
