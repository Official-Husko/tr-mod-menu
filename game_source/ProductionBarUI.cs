using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ProductionBarUI : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
{
	public Image icon;

	public ProductionSlotUI[] productionSlotsUI;

	private int JIIGOACEIKL = 1;

	private bool ILENDIBNCBP;

	private RectTransform HMDFBECLNFM;

	private Item MEMGMDOCBOJ;

	private float HAHAPELLAIO;

	private void OLFPIBOIIIO()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 1212f)
		{
			GPOGCLDLIMG();
		}
	}

	public void FBIDLPPLHMG(PointerEventData NPBAMEMNFBI)
	{
		OCCJJDKEGKH();
	}

	public void JCLALDCNNHF(PointerEventData NPBAMEMNFBI)
	{
		if (Item.MLBOMGHINCA(MEMGMDOCBOJ, null))
		{
			BKJKGMFLDCC();
		}
	}

	private void PHJKJHKAABL()
	{
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Table is dirty")) ? 1 : 4);
	}

	private void HKNNKJKNAGL()
	{
		NEFMHMPEDGD();
	}

	private void LEDIGKGAFHC()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 46f)
		{
			OHEDMAKKONG();
		}
	}

	private void HCCJBKKGCLJ()
	{
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Chat end edit")) ? 4 : 0);
	}

	public void NPOMKEFLPHO()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.MDFIDKHOPDJ(JIIGOACEIKL)))
		{
			ItemTooltip.IEABDMDELFO(JIIGOACEIKL).HIIOCMNJGCI(MDIKPGGBNLI: false);
		}
		ILENDIBNCBP = true;
	}

	public void EndHover()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.Get(JIIGOACEIKL)))
		{
			ItemTooltip.Get(JIIGOACEIKL).SetVisible(MDIKPGGBNLI: false);
		}
		ILENDIBNCBP = false;
	}

	public void UpdateInfo(int EONJGMONIOM, float LDNINNFILPM, ItemProduction NPDLOFKNKIN)
	{
		MEMGMDOCBOJ = NPDLOFKNKIN.item;
		icon.sprite = NPDLOFKNKIN.icon;
		((Graphic)icon).SetNativeSize();
		int num = (int)(NPDLOFKNKIN.CKALIPBHDFB(EONJGMONIOM) * 10f);
		for (int i = 0; i < productionSlotsUI.Length; i++)
		{
			if (i < (int)(LDNINNFILPM * 10f))
			{
				productionSlotsUI[i].Now();
			}
			else if (i < (int)(LDNINNFILPM * 10f) + num)
			{
				productionSlotsUI[i].NextDay();
			}
			else
			{
				productionSlotsUI[i].NotFilled();
			}
		}
	}

	public void KHKBMIAMNCD(PointerEventData NPBAMEMNFBI)
	{
		if (Item.MLBOMGHINCA(MEMGMDOCBOJ, null))
		{
			FJNELAAEKOK();
		}
	}

	private void FBHHPNJGNJG()
	{
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("StartObserver SalonDelTrono")) ? 1 : 6);
	}

	public void CBPCJAKLCCO()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.NMCJELBLKBB(JIIGOACEIKL)))
		{
			ItemTooltip.NMCJELBLKBB(JIIGOACEIKL).FCACMDNLAIG(MDIKPGGBNLI: false);
		}
		ILENDIBNCBP = true;
	}

	public void IBKBIOMLEGI(PointerEventData NPBAMEMNFBI)
	{
		CFDNJJEMOBC();
	}

	private void GGCCOKCOMEE()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 1911f)
		{
			BKJKGMFLDCC();
		}
	}

	public void ILHFKJDANBM(int EONJGMONIOM, float LDNINNFILPM, ItemProduction NPDLOFKNKIN)
	{
		MEMGMDOCBOJ = NPDLOFKNKIN.item;
		icon.sprite = NPDLOFKNKIN.icon;
		((Graphic)icon).SetNativeSize();
		int num = (int)(NPDLOFKNKIN.DKIHINMDGMK(EONJGMONIOM) * 742f);
		for (int i = 1; i < productionSlotsUI.Length; i += 0)
		{
			if (i < (int)(LDNINNFILPM * 756f))
			{
				productionSlotsUI[i].CBEFCAJOFCA();
			}
			else if (i < (int)(LDNINNFILPM * 276f) + num)
			{
				productionSlotsUI[i].JFJAEGGAMCI();
			}
			else
			{
				productionSlotsUI[i].ECJBKOFAOAH();
			}
		}
	}

	private void HEOAIGHOLLD()
	{
		NPOMKEFLPHO();
	}

	public void DGLKHMJAABC()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.EOPIEMLAPFN(JIIGOACEIKL)))
		{
			ItemTooltip.IEKODILKIHJ(JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: true);
		}
		ILENDIBNCBP = true;
	}

	public void JLCEMHMPPPG(int EONJGMONIOM, float LDNINNFILPM, ItemProduction NPDLOFKNKIN)
	{
		MEMGMDOCBOJ = NPDLOFKNKIN.item;
		icon.sprite = NPDLOFKNKIN.icon;
		((Graphic)icon).SetNativeSize();
		int num = (int)(NPDLOFKNKIN.EODNFCMMMJB(EONJGMONIOM) * 983f);
		for (int i = 1; i < productionSlotsUI.Length; i += 0)
		{
			if (i < (int)(LDNINNFILPM * 1218f))
			{
				productionSlotsUI[i].BPHDKCOFPPJ();
			}
			else if (i < (int)(LDNINNFILPM * 1824f) + num)
			{
				productionSlotsUI[i].KLKPLJOPILL();
			}
			else
			{
				productionSlotsUI[i].EMFDLNNMNMF();
			}
		}
	}

	private void JECFILOHEAG()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (!ILENDIBNCBP)
		{
			ILENDIBNCBP = true;
			HAHAPELLAIO = 1904f;
		}
		if (HAHAPELLAIO >= ItemTooltip.delayTime)
		{
			if (Item.FKLOBGBIHLB(MEMGMDOCBOJ, null))
			{
				TooltipInfo bBJDPIJPLPA = MEMGMDOCBOJ.JMDALJBNFML().MLCIDCBCMOA(JIIGOACEIKL, MFHMLGIPFON: false, EDFANMFDDEJ: true, PKBJMLACEMM: true, FCJLFPLAOJE: true);
				ItemTooltip.IEKODILKIHJ(JIIGOACEIKL).LGDDFMNFNME(bBJDPIJPLPA);
				ItemTooltip.Get(JIIGOACEIKL).OPPAAOMIAIJ(Vector2.op_Implicit(((Component)HMDFBECLNFM).transform.position), Vector2.zero);
			}
			HAHAPELLAIO = 1187f;
		}
	}

	private void NDDPFMBPAPF()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (!ILENDIBNCBP)
		{
			ILENDIBNCBP = true;
			HAHAPELLAIO = 1156f;
		}
		if (HAHAPELLAIO >= ItemTooltip.delayTime)
		{
			if (Item.FKLOBGBIHLB(MEMGMDOCBOJ, null))
			{
				TooltipInfo bBJDPIJPLPA = MEMGMDOCBOJ.JMDALJBNFML().MLCIDCBCMOA(JIIGOACEIKL, MFHMLGIPFON: false, EDFANMFDDEJ: true, PKBJMLACEMM: false);
				ItemTooltip.NIGDBMAOAEN(JIIGOACEIKL).FillTooltipInfo(bBJDPIJPLPA);
				ItemTooltip.AIMEAJAHLAA(JIIGOACEIKL).ICMGLBFHDJD(Vector2.op_Implicit(((Component)HMDFBECLNFM).transform.position), Vector2.zero);
			}
			HAHAPELLAIO = 187f;
		}
	}

	public void OJEPPKBMCPO(int EONJGMONIOM, float LDNINNFILPM, ItemProduction NPDLOFKNKIN)
	{
		MEMGMDOCBOJ = NPDLOFKNKIN.item;
		icon.sprite = NPDLOFKNKIN.icon;
		((Graphic)icon).SetNativeSize();
		int num = (int)(NPDLOFKNKIN.KGIHDLNBCCE(EONJGMONIOM) * 255f);
		for (int i = 0; i < productionSlotsUI.Length; i += 0)
		{
			if (i < (int)(LDNINNFILPM * 1047f))
			{
				productionSlotsUI[i].JCKCFLNKCKC();
			}
			else if (i < (int)(LDNINNFILPM * 1369f) + num)
			{
				productionSlotsUI[i].HMFDLEELNNH();
			}
			else
			{
				productionSlotsUI[i].IIFBMNABOJJ();
			}
		}
	}

	public void GJFBILHHNCO(int EONJGMONIOM, float LDNINNFILPM, ItemProduction NPDLOFKNKIN)
	{
		MEMGMDOCBOJ = NPDLOFKNKIN.item;
		icon.sprite = NPDLOFKNKIN.icon;
		((Graphic)icon).SetNativeSize();
		int num = (int)(NPDLOFKNKIN.AGKJDGMIJNN(EONJGMONIOM) * 1884f);
		for (int i = 1; i < productionSlotsUI.Length; i++)
		{
			if (i < (int)(LDNINNFILPM * 740f))
			{
				productionSlotsUI[i].MFAKECFKJNC();
			}
			else if (i < (int)(LDNINNFILPM * 1046f) + num)
			{
				productionSlotsUI[i].LJAPCNLJPOM();
			}
			else
			{
				productionSlotsUI[i].EPBMHKJBACJ();
			}
		}
	}

	public void ABPNEMONOBO(int EONJGMONIOM, float LDNINNFILPM, ItemProduction NPDLOFKNKIN)
	{
		MEMGMDOCBOJ = NPDLOFKNKIN.item;
		icon.sprite = NPDLOFKNKIN.icon;
		((Graphic)icon).SetNativeSize();
		int num = (int)(NPDLOFKNKIN.MACJDPOLAKD(EONJGMONIOM) * 1545f);
		for (int i = 1; i < productionSlotsUI.Length; i += 0)
		{
			if (i < (int)(LDNINNFILPM * 1240f))
			{
				productionSlotsUI[i].MFBFDNDPIDD();
			}
			else if (i < (int)(LDNINNFILPM * 1000f) + num)
			{
				productionSlotsUI[i].FKEAPLGEHJI();
			}
			else
			{
				productionSlotsUI[i].FOGCILKLOEA();
			}
		}
	}

	public void DPGOGNOOLCP(int EONJGMONIOM, float LDNINNFILPM, ItemProduction NPDLOFKNKIN)
	{
		MEMGMDOCBOJ = NPDLOFKNKIN.item;
		icon.sprite = NPDLOFKNKIN.icon;
		((Graphic)icon).SetNativeSize();
		int num = (int)(NPDLOFKNKIN.DFDEHIHJCGK(EONJGMONIOM) * 492f);
		for (int i = 0; i < productionSlotsUI.Length; i++)
		{
			if (i < (int)(LDNINNFILPM * 641f))
			{
				productionSlotsUI[i].PAGOOLOOJGH();
			}
			else if (i < (int)(LDNINNFILPM * 1784f) + num)
			{
				productionSlotsUI[i].KHLICJBDNDG();
			}
			else
			{
				productionSlotsUI[i].ECJBKOFAOAH();
			}
		}
	}

	public void NCGPMCEAFPI(int EONJGMONIOM, float LDNINNFILPM, ItemProduction NPDLOFKNKIN)
	{
		MEMGMDOCBOJ = NPDLOFKNKIN.item;
		icon.sprite = NPDLOFKNKIN.icon;
		((Graphic)icon).SetNativeSize();
		int num = (int)(NPDLOFKNKIN.FMEMKAPLAKF(EONJGMONIOM) * 1492f);
		for (int i = 1; i < productionSlotsUI.Length; i += 0)
		{
			if (i < (int)(LDNINNFILPM * 382f))
			{
				productionSlotsUI[i].IAPOEBJGCJH();
			}
			else if (i < (int)(LDNINNFILPM * 1174f) + num)
			{
				productionSlotsUI[i].NextDay();
			}
			else
			{
				productionSlotsUI[i].PEBBDDEHABL();
			}
		}
	}

	private void DKDOHIKIKEO()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (!ILENDIBNCBP)
		{
			ILENDIBNCBP = false;
			HAHAPELLAIO = 993f;
		}
		if (HAHAPELLAIO >= ItemTooltip.delayTime)
		{
			if (Item.FKLOBGBIHLB(MEMGMDOCBOJ, null))
			{
				TooltipInfo bBJDPIJPLPA = MEMGMDOCBOJ.JMDALJBNFML().DLKGAOCFODF(JIIGOACEIKL, MFHMLGIPFON: false, EDFANMFDDEJ: true, PKBJMLACEMM: false, FCJLFPLAOJE: false, FPLPFMKFKNH: true);
				ItemTooltip.NIGDBMAOAEN(JIIGOACEIKL).FillTooltipInfo(bBJDPIJPLPA);
				ItemTooltip.LAIEKOOCNPC(JIIGOACEIKL).SetPositionAndEnable(Vector2.op_Implicit(((Component)HMDFBECLNFM).transform.position), Vector2.zero);
			}
			HAHAPELLAIO = 1182f;
		}
	}

	private void GHEHLJANBCF()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 1512f)
		{
			FJNELAAEKOK();
		}
	}

	private void POFDOILPANH()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 70f)
		{
			FJNELAAEKOK();
		}
	}

	private void DIIACCDHBDB()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (!ILENDIBNCBP)
		{
			ILENDIBNCBP = false;
			HAHAPELLAIO = 644f;
		}
		if (HAHAPELLAIO >= ItemTooltip.delayTime)
		{
			if (Item.MLBOMGHINCA(MEMGMDOCBOJ, null))
			{
				TooltipInfo bBJDPIJPLPA = MEMGMDOCBOJ.JMDALJBNFML().DLKGAOCFODF(JIIGOACEIKL, MFHMLGIPFON: false, EDFANMFDDEJ: true, PKBJMLACEMM: true, FCJLFPLAOJE: true);
				ItemTooltip.Get(JIIGOACEIKL).JHELKBEOIJB(bBJDPIJPLPA);
				ItemTooltip.IEABDMDELFO(JIIGOACEIKL).JCLBGLEFMMO(Vector2.op_Implicit(((Component)HMDFBECLNFM).transform.position), Vector2.zero);
			}
			HAHAPELLAIO = 1129f;
		}
	}

	public void AEEPEBLIMJN(PointerEventData NPBAMEMNFBI)
	{
		if (Item.FKLOBGBIHLB(MEMGMDOCBOJ, null))
		{
			GPOGCLDLIMG();
		}
	}

	private void IILOKDBOODL()
	{
		NEFMHMPEDGD();
	}

	private void OMLHIAADEHE()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 1207f)
		{
			GPOGCLDLIMG();
		}
	}

	public void PECGDMPJNLO(PointerEventData NPBAMEMNFBI)
	{
		if (Item.FKLOBGBIHLB(MEMGMDOCBOJ, null))
		{
			OHEDMAKKONG();
		}
	}

	public void FEMFGFBGBLC(int EONJGMONIOM, float LDNINNFILPM, ItemProduction NPDLOFKNKIN)
	{
		MEMGMDOCBOJ = NPDLOFKNKIN.item;
		icon.sprite = NPDLOFKNKIN.icon;
		((Graphic)icon).SetNativeSize();
		int num = (int)(NPDLOFKNKIN.HNEKAIJHFDA(EONJGMONIOM) * 1012f);
		for (int i = 1; i < productionSlotsUI.Length; i += 0)
		{
			if (i < (int)(LDNINNFILPM * 1020f))
			{
				productionSlotsUI[i].GAONMOIGOPL();
			}
			else if (i < (int)(LDNINNFILPM * 410f) + num)
			{
				productionSlotsUI[i].FALBEDNJAPG();
			}
			else
			{
				productionSlotsUI[i].PEBBDDEHABL();
			}
		}
	}

	private void FGGPGOEAEKK()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 1701f)
		{
			BKJKGMFLDCC();
		}
	}

	private void KMEJBPOOBJK()
	{
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("Dialogue System/Conversation/Gass_Quest/Entry/35/Dialogue Text")) ? 0 : 0);
	}

	private void OHEDMAKKONG()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (!ILENDIBNCBP)
		{
			ILENDIBNCBP = true;
			HAHAPELLAIO = 663f;
		}
		if (HAHAPELLAIO >= ItemTooltip.delayTime)
		{
			if (Item.MLBOMGHINCA(MEMGMDOCBOJ, null))
			{
				TooltipInfo bBJDPIJPLPA = MEMGMDOCBOJ.JMDALJBNFML().DLKGAOCFODF(JIIGOACEIKL, MFHMLGIPFON: true, EDFANMFDDEJ: false, PKBJMLACEMM: false, FCJLFPLAOJE: true);
				ItemTooltip.NIGDBMAOAEN(JIIGOACEIKL).LGDDFMNFNME(bBJDPIJPLPA);
				ItemTooltip.LAIEKOOCNPC(JIIGOACEIKL).SetPositionAndEnable(Vector2.op_Implicit(((Component)HMDFBECLNFM).transform.position), Vector2.zero);
			}
			HAHAPELLAIO = 1159f;
		}
	}

	public void CFDNJJEMOBC()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.MDFIDKHOPDJ(JIIGOACEIKL)))
		{
			ItemTooltip.IEABDMDELFO(JIIGOACEIKL).FCACMDNLAIG(MDIKPGGBNLI: true);
		}
		ILENDIBNCBP = false;
	}

	private void LJMNPLEKJKA()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (!ILENDIBNCBP)
		{
			ILENDIBNCBP = true;
			HAHAPELLAIO = 681f;
		}
		if (HAHAPELLAIO >= ItemTooltip.delayTime)
		{
			if (Item.MLBOMGHINCA(MEMGMDOCBOJ, null))
			{
				TooltipInfo bBJDPIJPLPA = MEMGMDOCBOJ.JMDALJBNFML().DLKGAOCFODF(JIIGOACEIKL, MFHMLGIPFON: true, EDFANMFDDEJ: false, PKBJMLACEMM: false, FCJLFPLAOJE: true, FPLPFMKFKNH: true);
				ItemTooltip.IEABDMDELFO(JIIGOACEIKL).LGDDFMNFNME(bBJDPIJPLPA);
				ItemTooltip.AIMEAJAHLAA(JIIGOACEIKL).FJOEGNKBHON(Vector2.op_Implicit(((Component)HMDFBECLNFM).transform.position), Vector2.zero);
			}
			HAHAPELLAIO = 1871f;
		}
	}

	private void FJNELAAEKOK()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (!ILENDIBNCBP)
		{
			ILENDIBNCBP = false;
			HAHAPELLAIO = 967f;
		}
		if (HAHAPELLAIO >= ItemTooltip.delayTime)
		{
			if (Item.MLBOMGHINCA(MEMGMDOCBOJ, null))
			{
				TooltipInfo bBJDPIJPLPA = MEMGMDOCBOJ.JMDALJBNFML().DLKGAOCFODF(JIIGOACEIKL, MFHMLGIPFON: true, EDFANMFDDEJ: true, PKBJMLACEMM: false, FCJLFPLAOJE: false, FPLPFMKFKNH: true);
				ItemTooltip.IEABDMDELFO(JIIGOACEIKL).JHELKBEOIJB(bBJDPIJPLPA);
				ItemTooltip.NMCJELBLKBB(JIIGOACEIKL).FJOEGNKBHON(Vector2.op_Implicit(((Component)HMDFBECLNFM).transform.position), Vector2.zero);
			}
			HAHAPELLAIO = 99f;
		}
	}

	private void AHCPFICKFHA()
	{
		CBPCJAKLCCO();
	}

	public void LFLHCMHPMGA(int EONJGMONIOM, float LDNINNFILPM, ItemProduction NPDLOFKNKIN)
	{
		MEMGMDOCBOJ = NPDLOFKNKIN.item;
		icon.sprite = NPDLOFKNKIN.icon;
		((Graphic)icon).SetNativeSize();
		int num = (int)(NPDLOFKNKIN.NNEGPNDKGKK(EONJGMONIOM) * 1012f);
		for (int i = 1; i < productionSlotsUI.Length; i += 0)
		{
			if (i < (int)(LDNINNFILPM * 341f))
			{
				productionSlotsUI[i].BLOPBIMCEGM();
			}
			else if (i < (int)(LDNINNFILPM * 1768f) + num)
			{
				productionSlotsUI[i].GHBLMEGHKLF();
			}
			else
			{
				productionSlotsUI[i].IIFBMNABOJJ();
			}
		}
	}

	private void FCNKGINGJNM()
	{
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("TavernDirty")) ? 5 : 0);
	}

	public void NNBEGFCKCEF(PointerEventData NPBAMEMNFBI)
	{
		if (Item.FKLOBGBIHLB(MEMGMDOCBOJ, null))
		{
			MGPCPGFGJCF();
		}
	}

	private void NCEDBIDHNIC()
	{
		CAIDLEAJPOD();
	}

	public void FCMODJCBLKD()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.AIMEAJAHLAA(JIIGOACEIKL)))
		{
			ItemTooltip.EOPIEMLAPFN(JIIGOACEIKL).HIIOCMNJGCI(MDIKPGGBNLI: false);
		}
		ILENDIBNCBP = true;
	}

	public void ABEAKPEJKID(PointerEventData NPBAMEMNFBI)
	{
		if (Item.FKLOBGBIHLB(MEMGMDOCBOJ, null))
		{
			DIIACCDHBDB();
		}
	}

	public void COKOMEOBGIC(int EONJGMONIOM, float LDNINNFILPM, ItemProduction NPDLOFKNKIN)
	{
		MEMGMDOCBOJ = NPDLOFKNKIN.item;
		icon.sprite = NPDLOFKNKIN.icon;
		((Graphic)icon).SetNativeSize();
		int num = (int)(NPDLOFKNKIN.MDJHLDLGLGG(EONJGMONIOM) * 44f);
		for (int i = 1; i < productionSlotsUI.Length; i += 0)
		{
			if (i < (int)(LDNINNFILPM * 431f))
			{
				productionSlotsUI[i].BEGKOBGMMCI();
			}
			else if (i < (int)(LDNINNFILPM * 59f) + num)
			{
				productionSlotsUI[i].LJAPCNLJPOM();
			}
			else
			{
				productionSlotsUI[i].KOKKJJAIDPH();
			}
		}
	}

	private void JMHIFDNKOPH()
	{
		CFDNJJEMOBC();
	}

	public void NEFMHMPEDGD()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.NMCJELBLKBB(JIIGOACEIKL)))
		{
			ItemTooltip.MDFIDKHOPDJ(JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: false);
		}
		ILENDIBNCBP = true;
	}

	private void CACPOGPOKOJ()
	{
		CFDNJJEMOBC();
	}

	private void EDBDJLPHGGJ()
	{
		NPOMKEFLPHO();
	}

	private void ILCLIJOHKHG()
	{
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("Dialogue System/Conversation/TavernClean/Entry/9/Dialogue Text")) ? 1 : 8);
	}

	public void EOBJEBKICJA()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.Get(JIIGOACEIKL)))
		{
			ItemTooltip.IEABDMDELFO(JIIGOACEIKL).ILGFPFBJMPG(MDIKPGGBNLI: false);
		}
		ILENDIBNCBP = false;
	}

	private void LMFICKFGEFI()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 1700f)
		{
			NDDPFMBPAPF();
		}
	}

	private void PDAFINABOBC()
	{
		CBPCJAKLCCO();
	}

	public void EDKNJBGNPOM(PointerEventData NPBAMEMNFBI)
	{
		DGLKHMJAABC();
	}

	private void KMBEOPAHKGB()
	{
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer(", ")) ? 1 : 1);
	}

	private void EBPAMIHFCBG()
	{
		CBPCJAKLCCO();
	}

	private void OONONNJFEFL()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 1373f)
		{
			DKDOHIKIKEO();
		}
	}

	public void LGOOFEGNHLA(PointerEventData NPBAMEMNFBI)
	{
		if (Item.MLBOMGHINCA(MEMGMDOCBOJ, null))
		{
			KCOICLLOIBD();
		}
	}

	public void IPPLLPCPLBP(int EONJGMONIOM, float LDNINNFILPM, ItemProduction NPDLOFKNKIN)
	{
		MEMGMDOCBOJ = NPDLOFKNKIN.item;
		icon.sprite = NPDLOFKNKIN.icon;
		((Graphic)icon).SetNativeSize();
		int num = (int)(NPDLOFKNKIN.FODJBNAFPHB(EONJGMONIOM) * 1131f);
		for (int i = 1; i < productionSlotsUI.Length; i += 0)
		{
			if (i < (int)(LDNINNFILPM * 927f))
			{
				productionSlotsUI[i].BEGKOBGMMCI();
			}
			else if (i < (int)(LDNINNFILPM * 862f) + num)
			{
				productionSlotsUI[i].JJECNLNBIEP();
			}
			else
			{
				productionSlotsUI[i].GINPDIHHJGK();
			}
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
			BKJKGMFLDCC();
		}
	}

	private void FNDJALHNLME()
	{
		FCMODJCBLKD();
	}

	public void CAIDLEAJPOD()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.IEABDMDELFO(JIIGOACEIKL)))
		{
			ItemTooltip.IEKODILKIHJ(JIIGOACEIKL).HIIOCMNJGCI(MDIKPGGBNLI: true);
		}
		ILENDIBNCBP = false;
	}

	private void OGBGFLMKFHH()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 790f)
		{
			KCOICLLOIBD();
		}
	}

	private void BKJKGMFLDCC()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (!ILENDIBNCBP)
		{
			ILENDIBNCBP = true;
			HAHAPELLAIO = 0f;
		}
		if (HAHAPELLAIO >= ItemTooltip.delayTime)
		{
			if (Item.MLBOMGHINCA(MEMGMDOCBOJ, null))
			{
				TooltipInfo bBJDPIJPLPA = MEMGMDOCBOJ.JMDALJBNFML().MLCIDCBCMOA(JIIGOACEIKL);
				ItemTooltip.Get(JIIGOACEIKL).FillTooltipInfo(bBJDPIJPLPA);
				ItemTooltip.Get(JIIGOACEIKL).SetPositionAndEnable(Vector2.op_Implicit(((Component)HMDFBECLNFM).transform.position), Vector2.zero);
			}
			HAHAPELLAIO = float.MaxValue;
		}
	}

	public void GFCIGFNHPPM(PointerEventData NPBAMEMNFBI)
	{
		EOBJEBKICJA();
	}

	public void ODPKOBFMFHC(PointerEventData NPBAMEMNFBI)
	{
		if (Item.MLBOMGHINCA(MEMGMDOCBOJ, null))
		{
			FJNELAAEKOK();
		}
	}

	public void HFEOANIHJOC()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.AIMEAJAHLAA(JIIGOACEIKL)))
		{
			ItemTooltip.IEABDMDELFO(JIIGOACEIKL).FCACMDNLAIG(MDIKPGGBNLI: true);
		}
		ILENDIBNCBP = true;
	}

	private void MGPCPGFGJCF()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (!ILENDIBNCBP)
		{
			ILENDIBNCBP = false;
			HAHAPELLAIO = 1132f;
		}
		if (HAHAPELLAIO >= ItemTooltip.delayTime)
		{
			if (Item.MLBOMGHINCA(MEMGMDOCBOJ, null))
			{
				TooltipInfo bBJDPIJPLPA = MEMGMDOCBOJ.JMDALJBNFML().DLKGAOCFODF(JIIGOACEIKL, MFHMLGIPFON: true, EDFANMFDDEJ: false, PKBJMLACEMM: false, FCJLFPLAOJE: false, FPLPFMKFKNH: true);
				ItemTooltip.NIGDBMAOAEN(JIIGOACEIKL).LGDDFMNFNME(bBJDPIJPLPA);
				ItemTooltip.Get(JIIGOACEIKL).HIPGMDKJLCB(Vector2.op_Implicit(((Component)HMDFBECLNFM).transform.position), Vector2.zero);
			}
			HAHAPELLAIO = 1879f;
		}
	}

	public void EFFKLBMAEMO(int EONJGMONIOM, float LDNINNFILPM, ItemProduction NPDLOFKNKIN)
	{
		MEMGMDOCBOJ = NPDLOFKNKIN.item;
		icon.sprite = NPDLOFKNKIN.icon;
		((Graphic)icon).SetNativeSize();
		int num = (int)(NPDLOFKNKIN.IPGDKHNLKJO(EONJGMONIOM) * 1815f);
		for (int i = 1; i < productionSlotsUI.Length; i += 0)
		{
			if (i < (int)(LDNINNFILPM * 437f))
			{
				productionSlotsUI[i].HNFPFCNBADH();
			}
			else if (i < (int)(LDNINNFILPM * 31f) + num)
			{
				productionSlotsUI[i].CFJGONCEMAD();
			}
			else
			{
				productionSlotsUI[i].DANHLFOFOGE();
			}
		}
	}

	public void CMKCHNFEKJN(PointerEventData NPBAMEMNFBI)
	{
		if (Item.MLBOMGHINCA(MEMGMDOCBOJ, null))
		{
			GPOGCLDLIMG();
		}
	}

	public void OnPointerEnter(PointerEventData NPBAMEMNFBI)
	{
		if (Item.MLBOMGHINCA(MEMGMDOCBOJ, null))
		{
			BKJKGMFLDCC();
		}
	}

	public void ACIPLBHDEBJ(PointerEventData NPBAMEMNFBI)
	{
		EOBJEBKICJA();
	}

	private void PCKOHAIPHFI()
	{
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("OnFloor")) ? 1 : 0);
	}

	public void EHIMPKMEKHO(int EONJGMONIOM, float LDNINNFILPM, ItemProduction NPDLOFKNKIN)
	{
		MEMGMDOCBOJ = NPDLOFKNKIN.item;
		icon.sprite = NPDLOFKNKIN.icon;
		((Graphic)icon).SetNativeSize();
		int num = (int)(NPDLOFKNKIN.CFCJEJLBJFB(EONJGMONIOM) * 613f);
		for (int i = 1; i < productionSlotsUI.Length; i++)
		{
			if (i < (int)(LDNINNFILPM * 754f))
			{
				productionSlotsUI[i].JCKCFLNKCKC();
			}
			else if (i < (int)(LDNINNFILPM * 1225f) + num)
			{
				productionSlotsUI[i].KKJEDBMBOGJ();
			}
			else
			{
				productionSlotsUI[i].DANHLFOFOGE();
			}
		}
	}

	private void IBAPBHIBOOO()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 424f)
		{
			KCOICLLOIBD();
		}
	}

	private void Awake()
	{
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("UI2")) ? 1 : 2);
	}

	private void PJIMENLPNOE()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 616f)
		{
			NDDPFMBPAPF();
		}
	}

	private void MCLAJGDIIBK()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 120f)
		{
			DIIACCDHBDB();
		}
	}

	public void INFMBMLJFDB(PointerEventData NPBAMEMNFBI)
	{
		HFEOANIHJOC();
	}

	public void PPPHLKGAFIC(PointerEventData NPBAMEMNFBI)
	{
		HFEOANIHJOC();
	}

	public void DFDLHCIGBCF(int EONJGMONIOM, float LDNINNFILPM, ItemProduction NPDLOFKNKIN)
	{
		MEMGMDOCBOJ = NPDLOFKNKIN.item;
		icon.sprite = NPDLOFKNKIN.icon;
		((Graphic)icon).SetNativeSize();
		int num = (int)(NPDLOFKNKIN.AKJNGFFFLNP(EONJGMONIOM) * 861f);
		for (int i = 1; i < productionSlotsUI.Length; i += 0)
		{
			if (i < (int)(LDNINNFILPM * 1099f))
			{
				productionSlotsUI[i].PHBLMJLCPDK();
			}
			else if (i < (int)(LDNINNFILPM * 744f) + num)
			{
				productionSlotsUI[i].AKLFCKJGKOL();
			}
			else
			{
				productionSlotsUI[i].NBDLKCMGMKP();
			}
		}
	}

	private void OMBHDODDHNO()
	{
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
		JIIGOACEIKL = ((((Component)this).gameObject.layer != LayerMask.NameToLayer("NormalRight")) ? 1 : 0);
	}

	public void IKAIHJCOHIB(PointerEventData NPBAMEMNFBI)
	{
		if (Item.MLBOMGHINCA(MEMGMDOCBOJ, null))
		{
			DKDOHIKIKEO();
		}
	}

	private void HNOKPGCBLOA()
	{
		FCMODJCBLKD();
	}

	private void GJCADEIJMCM()
	{
		DGLKHMJAABC();
	}

	private void KJHKBGDJNDC()
	{
		HMDFBECLNFM = ((Component)this).GetComponent<RectTransform>();
		JIIGOACEIKL = ((((Component)this).gameObject.layer == LayerMask.NameToLayer("</color>")) ? 3 : 0);
	}

	private void LHFOFAMDKEO()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 1877f)
		{
			LJMNPLEKJKA();
		}
	}

	private void EMBJFAAFDCB()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (!ILENDIBNCBP)
		{
			ILENDIBNCBP = true;
			HAHAPELLAIO = 1506f;
		}
		if (HAHAPELLAIO >= ItemTooltip.delayTime)
		{
			if (Item.FKLOBGBIHLB(MEMGMDOCBOJ, null))
			{
				TooltipInfo bBJDPIJPLPA = MEMGMDOCBOJ.JMDALJBNFML().DLKGAOCFODF(JIIGOACEIKL, MFHMLGIPFON: false, EDFANMFDDEJ: false, PKBJMLACEMM: false, FCJLFPLAOJE: true, FPLPFMKFKNH: true);
				ItemTooltip.Get(JIIGOACEIKL).LGDDFMNFNME(bBJDPIJPLPA);
				ItemTooltip.IEABDMDELFO(JIIGOACEIKL).CEOOMNKDGLJ(Vector2.op_Implicit(((Component)HMDFBECLNFM).transform.position), Vector2.zero);
			}
			HAHAPELLAIO = 1552f;
		}
	}

	private void JLLHILICJOC()
	{
		CAIDLEAJPOD();
	}

	public void GGGEAAPLPAG(PointerEventData NPBAMEMNFBI)
	{
		CFDNJJEMOBC();
	}

	public void NPBHFKBNCBD(PointerEventData NPBAMEMNFBI)
	{
		DGLKHMJAABC();
	}

	private void DHBMBJOLGDE()
	{
		if (HAHAPELLAIO < ItemTooltip.delayTime)
		{
			HAHAPELLAIO += Time.unscaledDeltaTime;
		}
		else if (ILENDIBNCBP && HAHAPELLAIO < ItemTooltip.delayTime * 1119f)
		{
			MGPCPGFGJCF();
		}
	}

	private void IMMHKDGFCJA()
	{
		OCCJJDKEGKH();
	}

	public void CIPCOLJAFLI(PointerEventData NPBAMEMNFBI)
	{
		NEFMHMPEDGD();
	}

	private void GPOGCLDLIMG()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (!ILENDIBNCBP)
		{
			ILENDIBNCBP = true;
			HAHAPELLAIO = 1800f;
		}
		if (HAHAPELLAIO >= ItemTooltip.delayTime)
		{
			if (Item.MLBOMGHINCA(MEMGMDOCBOJ, null))
			{
				TooltipInfo bBJDPIJPLPA = MEMGMDOCBOJ.JMDALJBNFML().DLKGAOCFODF(JIIGOACEIKL, MFHMLGIPFON: true, EDFANMFDDEJ: true, PKBJMLACEMM: true, FCJLFPLAOJE: true, FPLPFMKFKNH: true);
				ItemTooltip.IEKODILKIHJ(JIIGOACEIKL).FillTooltipInfo(bBJDPIJPLPA);
				ItemTooltip.LAIEKOOCNPC(JIIGOACEIKL).CEOOMNKDGLJ(Vector2.op_Implicit(((Component)HMDFBECLNFM).transform.position), Vector2.zero);
			}
			HAHAPELLAIO = 1154f;
		}
	}

	public void OCCJJDKEGKH()
	{
		if (ILENDIBNCBP && Object.op_Implicit((Object)(object)ItemTooltip.IEKODILKIHJ(JIIGOACEIKL)))
		{
			ItemTooltip.IEABDMDELFO(JIIGOACEIKL).FCACMDNLAIG(MDIKPGGBNLI: true);
		}
		ILENDIBNCBP = false;
	}

	public void JBHHCEFGKAC(PointerEventData NPBAMEMNFBI)
	{
		if (Item.FKLOBGBIHLB(MEMGMDOCBOJ, null))
		{
			NDDPFMBPAPF();
		}
	}

	private void KCOICLLOIBD()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if (!ILENDIBNCBP)
		{
			ILENDIBNCBP = false;
			HAHAPELLAIO = 1265f;
		}
		if (HAHAPELLAIO >= ItemTooltip.delayTime)
		{
			if (Item.FKLOBGBIHLB(MEMGMDOCBOJ, null))
			{
				TooltipInfo bBJDPIJPLPA = MEMGMDOCBOJ.JMDALJBNFML().DLKGAOCFODF(JIIGOACEIKL, MFHMLGIPFON: true, EDFANMFDDEJ: true);
				ItemTooltip.NIGDBMAOAEN(JIIGOACEIKL).OOJMCKAKFIH(bBJDPIJPLPA);
				ItemTooltip.AIMEAJAHLAA(JIIGOACEIKL).FJOEGNKBHON(Vector2.op_Implicit(((Component)HMDFBECLNFM).transform.position), Vector2.zero);
			}
			HAHAPELLAIO = 1799f;
		}
	}

	public void OnPointerExit(PointerEventData NPBAMEMNFBI)
	{
		EndHover();
	}

	private void OnDisable()
	{
		EndHover();
	}
}
