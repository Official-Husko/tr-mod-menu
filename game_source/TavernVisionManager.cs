using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TavernVisionManager : MonoBehaviour
{
	public Action<int, bool> OnVisionActivate = delegate
	{
	};

	private static TavernVisionManager IADEMLIIDPC;

	private static TavernVisionManager BBINLIGKIPE;

	public bool visionActive;

	private bool DMBFKFLDDLH;

	private int JIIGOACEIKL;

	public bool IKNOJDMCFOK
	{
		get
		{
			return DMBFKFLDDLH;
		}
		set
		{
		}
	}

	public void LPHEKLFOGIC()
	{
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA == Location.None || PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA == Location.Tavern)
		{
			PDBCIDFPLOA(KHJOICBMIKN());
		}
		else if (FGOPFDOIDJG())
		{
			HHBFBOCNPCO(AODONKKHPBP: false);
		}
	}

	[SpecialName]
	public void OIMMJEEIOLA(bool AODONKKHPBP)
	{
	}

	public void OFOLLHLGCMC()
	{
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA == Location.Tavern || PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA == (Location.Tavern | Location.Road))
		{
			KEBCPDALFKD(EOAJCBCCBBM());
		}
		else if (MODDEIIHAGB())
		{
			KEBCPDALFKD(AODONKKHPBP: false);
		}
	}

	[SpecialName]
	public void NIIOPJDKCEI(bool AODONKKHPBP)
	{
	}

	public void ABMCMEPBLLA()
	{
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA == Location.Tavern || PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA == (Location.Road | Location.River))
		{
			LAOBOEHHMHG(EDGJGLAHKBI());
		}
		else if (EOAJCBCCBBM())
		{
			PEEDKBPOHJE(AODONKKHPBP: true);
		}
	}

	public void BFFAMHCNNKA()
	{
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA == Location.Tavern || PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA == (Location.Tavern | Location.Road | Location.River))
		{
			OIMMJEEIOLA(!GBELBKHAJGG());
		}
		else if (EGPEHBKMIOE())
		{
			NEHFPMJGBLG(AODONKKHPBP: true);
		}
	}

	[SpecialName]
	public bool NJNLDBFONEA()
	{
		return DMBFKFLDDLH;
	}

	[SpecialName]
	public bool GENBKJNGEAB()
	{
		return DMBFKFLDDLH;
	}

	[SpecialName]
	public bool LKBKNFBAOCP()
	{
		return DMBFKFLDDLH;
	}

	public void PMMMFGCBLNN()
	{
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA == Location.Tavern || PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA == (Location.Tavern | Location.River))
		{
			GNCLKGFGHMO(!KOLINMJFBMC());
		}
		else if (KHJOICBMIKN())
		{
			BEIGCCMDJHD(AODONKKHPBP: true);
		}
	}

	public static TavernVisionManager IKAEFEPNADI(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			return IADEMLIIDPC;
		}
		return BBINLIGKIPE;
	}

	private void FCNKGINGJNM()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().KLIHELDIPDP();
		if (JIIGOACEIKL == 1)
		{
			if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
			{
				IADEMLIIDPC = this;
			}
		}
		else
		{
			BBINLIGKIPE = this;
		}
	}

	private void MFGANCCJFJK()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().KLIHELDIPDP();
		if (JIIGOACEIKL == 1)
		{
			if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
			{
				IADEMLIIDPC = this;
			}
		}
		else
		{
			BBINLIGKIPE = this;
		}
	}

	private void MLLDECPJBLK()
	{
		visionActive = false;
		CommonReferences.MNFMOEKMJKN().ActivateCullMask(JIIGOACEIKL, "BarkActor");
		OnVisionActivate(JIIGOACEIKL, arg2: false);
		Sound.OKAPNFPFPFP().GFMCBGEFEOK(Utils.CPDCJAHJOPE(Sound.DIHCEGINELM().uiClickPos), HOMFPAFAOGD: false, null, null, 1802f, 56f);
	}

	[SpecialName]
	public void MIJOLFANIMD(bool AODONKKHPBP)
	{
	}

	[SpecialName]
	public bool EOAJCBCCBBM()
	{
		return DMBFKFLDDLH;
	}

	public void ToggleTavernVision()
	{
		if (PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA == Location.Tavern || PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA == Location.Road)
		{
			IKNOJDMCFOK = !IKNOJDMCFOK;
		}
		else if (IKNOJDMCFOK)
		{
			IKNOJDMCFOK = false;
		}
	}

	private void INBILJEONEG()
	{
		visionActive = true;
		CommonReferences.GGFJGHHHEJC.CBMJEEAHIDO(JIIGOACEIKL, "UIBack");
		OnVisionActivate(JIIGOACEIKL, arg2: false);
		Sound.GGFJGHHHEJC.GFMCBGEFEOK(Utils.CPDCJAHJOPE(Sound.BNBMNOMFFBE().uiClickPos), HOMFPAFAOGD: true, null, null, 1789f, 1800f);
	}

	public void IICCFOGKCBB()
	{
		if (PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA == Location.None || PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA == (Location.Road | Location.River))
		{
			HHBFBOCNPCO(!ALHHOHLOLBO());
		}
		else if (KCBNLHJFKIE())
		{
			PDBCIDFPLOA(AODONKKHPBP: false);
		}
	}

	private void HCCJBKKGCLJ()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().GetPlayerNum();
		if (JIIGOACEIKL == 1)
		{
			if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
			{
				IADEMLIIDPC = this;
			}
		}
		else
		{
			BBINLIGKIPE = this;
		}
	}

	private void GONDLJKGLGO()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().KLIHELDIPDP();
		if (JIIGOACEIKL == 1)
		{
			if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
			{
				IADEMLIIDPC = this;
			}
		}
		else
		{
			BBINLIGKIPE = this;
		}
	}

	[SpecialName]
	public bool HOBKFONNEJI()
	{
		return DMBFKFLDDLH;
	}

	private void AGMCDFEGAOD()
	{
		visionActive = true;
		CommonReferences.MNFMOEKMJKN().ActivateCullMask(JIIGOACEIKL, "SprintHoldAction");
		OnVisionActivate(JIIGOACEIKL, arg2: true);
		Sound.BNBMNOMFFBE().PlayOneShot(Utils.CPDCJAHJOPE(Sound.MAIDHAPANEB().uiClickPos), HOMFPAFAOGD: true, null, null, 406f, 621f);
	}

	public static TavernVisionManager GBBEJMADEJC(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			return IADEMLIIDPC;
		}
		return BBINLIGKIPE;
	}

	public static TavernVisionManager IGMCBPOPNCA(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			return IADEMLIIDPC;
		}
		return BBINLIGKIPE;
	}

	[SpecialName]
	public bool EGPEHBKMIOE()
	{
		return DMBFKFLDDLH;
	}

	private void NMMKNIGKBAC()
	{
		visionActive = true;
		CommonReferences.MNFMOEKMJKN().NBFJJGALKAL(JIIGOACEIKL, "[Player2Name]");
		OnVisionActivate(JIIGOACEIKL, arg2: true);
		Sound.ABDJJBFNLBJ().FDEMPPFKAFK(Utils.CPDCJAHJOPE(Sound.BNBMNOMFFBE().uiClickPos), HOMFPAFAOGD: false, null, null, 384f, 684f);
	}

	private void OOIHNJHMBMC()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().KLIHELDIPDP();
		if (JIIGOACEIKL == 1)
		{
			if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
			{
				IADEMLIIDPC = this;
			}
		}
		else
		{
			BBINLIGKIPE = this;
		}
	}

	public static TavernVisionManager MBNPLLPECCM(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return IADEMLIIDPC;
		}
		return BBINLIGKIPE;
	}

	[SpecialName]
	public bool EDGJGLAHKBI()
	{
		return DMBFKFLDDLH;
	}

	[SpecialName]
	public bool KCBNLHJFKIE()
	{
		return DMBFKFLDDLH;
	}

	[SpecialName]
	public bool FGOPFDOIDJG()
	{
		return DMBFKFLDDLH;
	}

	private void KLMNLEDKEOE()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().GetPlayerNum();
		if (JIIGOACEIKL == 0)
		{
			if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
			{
				IADEMLIIDPC = this;
			}
		}
		else
		{
			BBINLIGKIPE = this;
		}
	}

	private void KCKCADEIOPF()
	{
		visionActive = false;
		CommonReferences.MNFMOEKMJKN().ActivateCullMask(JIIGOACEIKL, "No se encuentra el valor ");
		OnVisionActivate(JIIGOACEIKL, arg2: true);
		Sound.OKAPNFPFPFP().GFMCBGEFEOK(Utils.CPDCJAHJOPE(Sound.MAIDHAPANEB().uiClickPos), HOMFPAFAOGD: false, null, null, 282f, 1249f);
	}

	private void EKOIOOGLFJN()
	{
		visionActive = false;
		CommonReferences.MNFMOEKMJKN().ActivateCullMask(JIIGOACEIKL, "Items/item_description_660");
		OnVisionActivate(JIIGOACEIKL, arg2: false);
		Sound.OKAPNFPFPFP().PlayOneShot(Utils.CPDCJAHJOPE(Sound.DIHCEGINELM().uiClickPos), HOMFPAFAOGD: true, null, null, 904f, 720f);
	}

	private void JDHHJKBOJML()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().KLIHELDIPDP();
		if (JIIGOACEIKL == 0)
		{
			if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
			{
				IADEMLIIDPC = this;
			}
		}
		else
		{
			BBINLIGKIPE = this;
		}
	}

	[SpecialName]
	public bool ABKOAIKBFIF()
	{
		return DMBFKFLDDLH;
	}

	[SpecialName]
	public void BBELJAFIJBL(bool AODONKKHPBP)
	{
	}

	public static TavernVisionManager CPOONCIFDIC(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return IADEMLIIDPC;
		}
		return BBINLIGKIPE;
	}

	[SpecialName]
	public bool MODDEIIHAGB()
	{
		return DMBFKFLDDLH;
	}

	private void EFCNKPEPELL()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().GetPlayerNum();
		if (JIIGOACEIKL == 0)
		{
			if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
			{
				IADEMLIIDPC = this;
			}
		}
		else
		{
			BBINLIGKIPE = this;
		}
	}

	public void HCIBLEBGOLC()
	{
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA == Location.None || PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA == Location.Road)
		{
			FJDHDFCIDPA(MODDEIIHAGB());
		}
		else if (EDGJGLAHKBI())
		{
			BEIGCCMDJHD(AODONKKHPBP: false);
		}
	}

	private void OGODLCABKAA()
	{
		visionActive = true;
		CommonReferences.GGFJGHHHEJC.CBMJEEAHIDO(JIIGOACEIKL, ".");
		OnVisionActivate(JIIGOACEIKL, arg2: true);
		Sound.BNBMNOMFFBE().INPNDHPDFNC(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiClickPos), HOMFPAFAOGD: true, null, null, 1327f, 1481f);
	}

	[SpecialName]
	public bool LKAALEEMINC()
	{
		return DMBFKFLDDLH;
	}

	public static TavernVisionManager LJCKMLJJLKA(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return IADEMLIIDPC;
		}
		return BBINLIGKIPE;
	}

	[SpecialName]
	public void BEIGCCMDJHD(bool AODONKKHPBP)
	{
	}

	public static TavernVisionManager DAEEJGKLOCF(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			return IADEMLIIDPC;
		}
		return BBINLIGKIPE;
	}

	[SpecialName]
	public void GNCLKGFGHMO(bool AODONKKHPBP)
	{
	}

	public void KDJJCFJEHGA()
	{
		if (PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA == Location.Tavern || PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA == Location.Camp)
		{
			OIMMJEEIOLA(!EGPEHBKMIOE());
		}
		else if (MODDEIIHAGB())
		{
			NIIOPJDKCEI(AODONKKHPBP: false);
		}
	}

	private void MDLJAPKDDOA()
	{
		visionActive = true;
		CommonReferences.MNFMOEKMJKN().NBFJJGALKAL(JIIGOACEIKL, "- ");
		OnVisionActivate(JIIGOACEIKL, arg2: false);
		Sound.ABDJJBFNLBJ().PlayOneShot(Utils.CPDCJAHJOPE(Sound.DIHCEGINELM().uiClickPos), HOMFPAFAOGD: false, null, null, 1341f, 1538f);
	}

	[SpecialName]
	public void APNPEKEKJLA(bool AODONKKHPBP)
	{
	}

	public void CFINBMJJEJI()
	{
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA == Location.Tavern || PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA == (Location.Tavern | Location.Road))
		{
			DMJBIAHCHJJ(ALHHOHLOLBO());
		}
		else if (LKAALEEMINC())
		{
			FJDHDFCIDPA(AODONKKHPBP: true);
		}
	}

	[SpecialName]
	public bool KHJOICBMIKN()
	{
		return DMBFKFLDDLH;
	}

	private void MFOBIJJKOIJ()
	{
		visionActive = true;
		CommonReferences.MNFMOEKMJKN().NIBKBELHAOE(JIIGOACEIKL, ")");
		OnVisionActivate(JIIGOACEIKL, arg2: false);
		Sound.OKAPNFPFPFP().PlayOneShot(Utils.CPDCJAHJOPE(Sound.ABDJJBFNLBJ().uiClickPos), HOMFPAFAOGD: true, null, null, 1767f, 1914f);
	}

	public static TavernVisionManager GetPlayer(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return IADEMLIIDPC;
		}
		return BBINLIGKIPE;
	}

	[SpecialName]
	public void HHBFBOCNPCO(bool AODONKKHPBP)
	{
	}

	private void Awake()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().GetPlayerNum();
		if (JIIGOACEIKL == 1)
		{
			if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
			{
				IADEMLIIDPC = this;
			}
		}
		else
		{
			BBINLIGKIPE = this;
		}
	}

	[SpecialName]
	public void PEEDKBPOHJE(bool AODONKKHPBP)
	{
	}

	[SpecialName]
	public bool IFFEKOAMPFM()
	{
		return DMBFKFLDDLH;
	}

	private void FPEPMCPIOPM()
	{
		visionActive = true;
		CommonReferences.MNFMOEKMJKN().CBMJEEAHIDO(JIIGOACEIKL, "in");
		OnVisionActivate(JIIGOACEIKL, arg2: true);
		Sound.GGFJGHHHEJC.PlayOneShot(Utils.CPDCJAHJOPE(Sound.DIHCEGINELM().uiClickPos), HOMFPAFAOGD: false, null, null, 1036f, 685f);
	}

	[SpecialName]
	public void NEHFPMJGBLG(bool AODONKKHPBP)
	{
	}

	[SpecialName]
	public bool FCLDELKPOFE()
	{
		return DMBFKFLDDLH;
	}

	[SpecialName]
	public void PDBCIDFPLOA(bool AODONKKHPBP)
	{
	}

	public void HPEDMPEDHHC()
	{
		if (PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA == Location.None || PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA == (Location.Tavern | Location.River))
		{
			LAOBOEHHMHG(!HOBKFONNEJI());
		}
		else if (LKBKNFBAOCP())
		{
			NEHFPMJGBLG(AODONKKHPBP: false);
		}
	}

	[SpecialName]
	public void LAOBOEHHMHG(bool AODONKKHPBP)
	{
	}

	private void MGIEOHDHHKI()
	{
		visionActive = true;
		CommonReferences.GGFJGHHHEJC.ActivateCullMask(JIIGOACEIKL, "TavernVision");
		OnVisionActivate(JIIGOACEIKL, arg2: true);
		Sound.GGFJGHHHEJC.PlayOneShot(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiClickPos), HOMFPAFAOGD: true);
	}

	[SpecialName]
	public void AGGDOKOKMFE(bool AODONKKHPBP)
	{
	}

	public static TavernVisionManager KBJLDHILLKH(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			return IADEMLIIDPC;
		}
		return BBINLIGKIPE;
	}

	private void HDIPKHAEKDL()
	{
		visionActive = false;
		CommonReferences.MNFMOEKMJKN().CBMJEEAHIDO(JIIGOACEIKL, "Left");
		OnVisionActivate(JIIGOACEIKL, arg2: false);
		Sound.BNBMNOMFFBE().INPNDHPDFNC(Utils.CPDCJAHJOPE(Sound.OKAPNFPFPFP().uiClickPos), HOMFPAFAOGD: false, null, null, 35f, 1966f);
	}

	[SpecialName]
	public bool GBELBKHAJGG()
	{
		return DMBFKFLDDLH;
	}

	private void DNBGIIGAKMJ()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().GetPlayerNum();
		if (JIIGOACEIKL == 1)
		{
			if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
			{
				IADEMLIIDPC = this;
			}
		}
		else
		{
			BBINLIGKIPE = this;
		}
	}

	[SpecialName]
	public void KEBCPDALFKD(bool AODONKKHPBP)
	{
	}

	public void IBDNFJICLCI()
	{
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA == Location.None || PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA == Location.None)
		{
			MIGLPECLDAI(!LJAKJBBLCKA());
		}
		else if (MODDEIIHAGB())
		{
			HHBFBOCNPCO(AODONKKHPBP: false);
		}
	}

	private void HJAEOKNOCKB()
	{
		visionActive = false;
		CommonReferences.GGFJGHHHEJC.ActivateCullMask(JIIGOACEIKL, "WorkerSkills");
		OnVisionActivate(JIIGOACEIKL, arg2: true);
		Sound.BNBMNOMFFBE().INPNDHPDFNC(Utils.CPDCJAHJOPE(Sound.BNBMNOMFFBE().uiClickPos), HOMFPAFAOGD: true, null, null, 1999f, 867f);
	}

	private void EHBMONGBJFI()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().GetPlayerNum();
		if (JIIGOACEIKL == 0)
		{
			if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
			{
				IADEMLIIDPC = this;
			}
		}
		else
		{
			BBINLIGKIPE = this;
		}
	}

	public void OIABJMKNBHK()
	{
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA == Location.Tavern || PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA == (Location.Tavern | Location.River))
		{
			PEEDKBPOHJE(FCLDELKPOFE());
		}
		else if (NBFODKENEAN())
		{
			NEHFPMJGBLG(AODONKKHPBP: true);
		}
	}

	public static TavernVisionManager IPBEEBLCHHA(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return IADEMLIIDPC;
		}
		return BBINLIGKIPE;
	}

	public static TavernVisionManager CMDGPJEIIJI(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return IADEMLIIDPC;
		}
		return BBINLIGKIPE;
	}

	[SpecialName]
	public void DMJBIAHCHJJ(bool AODONKKHPBP)
	{
	}

	[SpecialName]
	public bool KOLINMJFBMC()
	{
		return DMBFKFLDDLH;
	}

	[SpecialName]
	public bool NBFODKENEAN()
	{
		return DMBFKFLDDLH;
	}

	[SpecialName]
	public void MIGLPECLDAI(bool AODONKKHPBP)
	{
	}

	public static TavernVisionManager BPDFMAEOGGC(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return IADEMLIIDPC;
		}
		return BBINLIGKIPE;
	}

	public void HCLLGFMNOII()
	{
		if (PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA == Location.None || PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA == Location.Camp)
		{
			IKNOJDMCFOK = LKBKNFBAOCP();
		}
		else if (HOBKFONNEJI())
		{
			MIGLPECLDAI(AODONKKHPBP: false);
		}
	}

	private void BEANJBPFKMO()
	{
		visionActive = true;
		CommonReferences.MNFMOEKMJKN().CBMJEEAHIDO(JIIGOACEIKL, "Items/item_description_731");
		OnVisionActivate(JIIGOACEIKL, arg2: true);
		Sound.ABDJJBFNLBJ().INPNDHPDFNC(Utils.CPDCJAHJOPE(Sound.OKAPNFPFPFP().uiClickPos), HOMFPAFAOGD: false, null, null, 1755f, 420f);
	}

	[SpecialName]
	public bool LJAKJBBLCKA()
	{
		return DMBFKFLDDLH;
	}

	[SpecialName]
	public bool ALHHOHLOLBO()
	{
		return DMBFKFLDDLH;
	}

	public void MNDJEILCNLA()
	{
		if (PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA == Location.None || PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA == Location.Road)
		{
			AGGDOKOKMFE(FCLDELKPOFE());
		}
		else if (IKNOJDMCFOK)
		{
			APNPEKEKJLA(AODONKKHPBP: false);
		}
	}

	private void AGELAMLCINB()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().KLIHELDIPDP();
		if (JIIGOACEIKL == 1)
		{
			if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
			{
				IADEMLIIDPC = this;
			}
		}
		else
		{
			BBINLIGKIPE = this;
		}
	}

	private void PIHGEBONAOI()
	{
		JIIGOACEIKL = ((Component)this).GetComponent<PlayerController>().GetPlayerNum();
		if (JIIGOACEIKL == 0)
		{
			if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
			{
				IADEMLIIDPC = this;
			}
		}
		else
		{
			BBINLIGKIPE = this;
		}
	}

	public static TavernVisionManager IFGBDFBGAED(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return IADEMLIIDPC;
		}
		return BBINLIGKIPE;
	}

	private void PNMLIILELAG()
	{
		visionActive = true;
		CommonReferences.MNFMOEKMJKN().NIBKBELHAOE(JIIGOACEIKL, "Could not find recipe with id: ");
		OnVisionActivate(JIIGOACEIKL, arg2: false);
		Sound.GGFJGHHHEJC.FDEMPPFKAFK(Utils.CPDCJAHJOPE(Sound.DIHCEGINELM().uiClickPos), HOMFPAFAOGD: true, null, null, 52f, 418f);
	}

	public static TavernVisionManager BCIIIGAFBMB(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return IADEMLIIDPC;
		}
		return BBINLIGKIPE;
	}

	[SpecialName]
	public void FJDHDFCIDPA(bool AODONKKHPBP)
	{
	}

	public static TavernVisionManager HNFFIIOOJLN(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return IADEMLIIDPC;
		}
		return BBINLIGKIPE;
	}

	public static TavernVisionManager JOFDIPFMIHF(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			return IADEMLIIDPC;
		}
		return BBINLIGKIPE;
	}

	public void MHJOCBOAFAO()
	{
		if (PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA == Location.Tavern || PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA == Location.Road)
		{
			NIIOPJDKCEI(!LKAALEEMINC());
		}
		else if (ALHHOHLOLBO())
		{
			GNCLKGFGHMO(AODONKKHPBP: false);
		}
	}
}
