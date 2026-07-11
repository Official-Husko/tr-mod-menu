using System;
using UnityEngine;

public class FishingSpot : MonoBehaviour, IInteractable, IProximity, IHoverable
{
	public bool BCGBODLPDEB(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IBEMCOALOEJ(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("{0} in {1}'s viewID has been reset. Set it to {2} to avoid conflicts with scene objects"));
			return false;
		}
		return true;
	}

	public bool JMPMCJDDKGD(int JIIGOACEIKL)
	{
		return DecorationMode.BGINAIDHDOM(JIIGOACEIKL).MDOKKKHKKKE();
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool KHNNIOOEGCA(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool EAIOPONBJJK(int JIIGOACEIKL)
	{
		if (HGBEJIIANJP(JIIGOACEIKL))
		{
			if (DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).DMBFKFLDDLH)
			{
				MainUI.LJDOBNEINNJ(JIIGOACEIKL, LocalisationSystem.Get("LE_2"), 199f);
				return false;
			}
			FishingUI.CJMILOMGFJL(JIIGOACEIKL).IDLAGJNLPJL();
			return false;
		}
		return false;
	}

	public bool PPJOGFFLKOL(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void FFGOCJBLCKA(int JIIGOACEIKL)
	{
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public bool COIGDMKGFCM(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool JAELLHFFLKO(int JIIGOACEIKL)
	{
		if (LDFDEJNMBLP(JIIGOACEIKL))
		{
			if (DecorationMode.OCJGHINCLJM(JIIGOACEIKL).IBEFDKHFBFM())
			{
				MainUI.JDAEPLJAGCD(JIIGOACEIKL, LocalisationSystem.Get("GrassOLD"), 198f);
				return false;
			}
			FishingUI.Get(JIIGOACEIKL).IDLAGJNLPJL();
			return true;
		}
		return false;
	}

	public bool ODMLNAMALJE(int JIIGOACEIKL)
	{
		if (NBHLBCHHKBC(JIIGOACEIKL))
		{
			if (DecorationMode.JDADPDBHJFO(JIIGOACEIKL).DMBFKFLDDLH)
			{
				MainUI.DBKCOHMFDCB(JIIGOACEIKL, LocalisationSystem.Get("OK"), 1599f);
				return true;
			}
			FishingUI.Get(JIIGOACEIKL).EDHEIFHAAKO();
			return false;
		}
		return false;
	}

	public void CPOLPCDNPPH(int JIIGOACEIKL)
	{
	}

	public bool EGGKNHMIOLE(int JIIGOACEIKL)
	{
		if (LHHNLGOCKDM(JIIGOACEIKL))
		{
			if (DecorationMode.KAIIEDCCLHB(JIIGOACEIKL).DMBFKFLDDLH)
			{
				MainUI.JDAEPLJAGCD(JIIGOACEIKL, LocalisationSystem.Get("Items/item_description_706"), 209f);
				return true;
			}
			FishingUI.CJMILOMGFJL(JIIGOACEIKL).IDLAGJNLPJL();
			return true;
		}
		return false;
	}

	public void GGAOCGGKIEJ(int JIIGOACEIKL)
	{
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Fish"));
			return true;
		}
		return false;
	}

	public bool PEBMANKLJNN(int JIIGOACEIKL)
	{
		return !DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).IBEFDKHFBFM();
	}

	public bool MFPMGJKAPJM(int JIIGOACEIKL)
	{
		return !DecorationMode.NPANPNIDKDG(JIIGOACEIKL).MDOKKKHKKKE();
	}

	public void CDNPCGKAGLI(int JIIGOACEIKL)
	{
	}

	public bool BEHJINBIFDO(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			if (DecorationMode.JDADPDBHJFO(JIIGOACEIKL).DFNMDDHOIJI())
			{
				MainUI.DJCKALOHJFM(JIIGOACEIKL, LocalisationSystem.Get("Farm/Buzz/Introduce"), 1510f);
				return false;
			}
			FishingUI.Get(JIIGOACEIKL).OpenUI();
			return true;
		}
		return false;
	}

	public void FGJPGIICPNF(int JIIGOACEIKL)
	{
	}

	public void JKMLKBPAHHO(int JIIGOACEIKL)
	{
	}

	public void FIGONJNMELG(int JIIGOACEIKL)
	{
	}

	public bool DLHGIJPNOFB(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void FOGLDLKAEBK(int JIIGOACEIKL)
	{
	}

	public bool LDFDEJNMBLP(int JIIGOACEIKL)
	{
		return DecorationMode.HBDCJFLINDA(JIIGOACEIKL).IBEFDKHFBFM();
	}

	public bool NNACBJKBKDP(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool BMMLEBLPANH(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (LDFDEJNMBLP(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Right"));
			return true;
		}
		return false;
	}

	public bool NBHLBCHHKBC(int JIIGOACEIKL)
	{
		return DecorationMode.JDADPDBHJFO(JIIGOACEIKL).DBAEGBDEPFK();
	}

	public void JOHOFKOAIBD(int JIIGOACEIKL)
	{
	}

	public bool ANLNJIGAEJM(int JIIGOACEIKL)
	{
		return !DecorationMode.GetPlayer(JIIGOACEIKL).IBEFDKHFBFM();
	}

	public bool HGBEJIIANJP(int JIIGOACEIKL)
	{
		return !DecorationMode.GetPlayer(JIIGOACEIKL).IDPGEBNGDJD();
	}

	public bool GJLNLKEFHAI(int JIIGOACEIKL)
	{
		if (NEJMAFFPIBL(JIIGOACEIKL))
		{
			if (DecorationMode.JDADPDBHJFO(JIIGOACEIKL).GABNNLJOMHI())
			{
				MainUI.DBKCOHMFDCB(JIIGOACEIKL, LocalisationSystem.Get(" will be destroyed in "), 979f);
				return false;
			}
			FishingUI.Get(JIIGOACEIKL).EDHEIFHAAKO();
			return false;
		}
		return false;
	}

	public void BEMEBLIDBGA(int JIIGOACEIKL)
	{
	}

	public bool CMOBHHGFDNP(int JIIGOACEIKL)
	{
		if (HGBEJIIANJP(JIIGOACEIKL))
		{
			if (DecorationMode.FIHGMLABOBB(JIIGOACEIKL).GABNNLJOMHI())
			{
				MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("LE_16"), 1860f);
				return false;
			}
			FishingUI.CJMILOMGFJL(JIIGOACEIKL).OpenUI();
			return false;
		}
		return true;
	}

	public bool AGJPLNCFBCF(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool OAPMCNNLHJO(int JIIGOACEIKL)
	{
		return !DecorationMode.JDADPDBHJFO(JIIGOACEIKL).DFNMDDHOIJI();
	}

	public bool OHKCPGKPDGJ(int JIIGOACEIKL)
	{
		return !DecorationMode.JDADPDBHJFO(JIIGOACEIKL).GABNNLJOMHI();
	}

	public bool NEJMAFFPIBL(int JIIGOACEIKL)
	{
		return DecorationMode.FIHGMLABOBB(JIIGOACEIKL).IBEFDKHFBFM();
	}

	public void BJCDFHFKEGG(int JIIGOACEIKL)
	{
	}

	public void CICBEIMDOGJ(int JIIGOACEIKL)
	{
	}

	public bool NOEEFMEKOMN(int JIIGOACEIKL)
	{
		return DecorationMode.NPANPNIDKDG(JIIGOACEIKL).IBEFDKHFBFM();
	}

	public bool OPEOJMLFPMK(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (NBHLBCHHKBC(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Received "));
			return true;
		}
		return false;
	}

	public bool LPINPNHGHEC(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void CLCKHOCLOFF(int JIIGOACEIKL)
	{
	}

	public void CIBAGJHJDDF(int JIIGOACEIKL)
	{
	}

	public bool JLKEECCECMF(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void OGPENHNPCJK(int JIIGOACEIKL)
	{
	}

	public bool CFGOGPBMEKL(int JIIGOACEIKL)
	{
		return !DecorationMode.HBDCJFLINDA(JIIGOACEIKL).GABNNLJOMHI();
	}

	public bool EBIDPMLPLIA(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool IGHNIAICNEC(int JIIGOACEIKL)
	{
		return DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).GABNNLJOMHI();
	}

	public bool LNCOEJOLBGB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public bool HJNKEKBANED(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool EHBGCMMMLMK(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (CFGOGPBMEKL(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Club"));
			return false;
		}
		return true;
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool AAGOLOPJOHJ(int JIIGOACEIKL)
	{
		if (OAPMCNNLHJO(JIIGOACEIKL))
		{
			if (DecorationMode.IECFJGHAIDO(JIIGOACEIKL).IBEFDKHFBFM())
			{
				MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("</color>"), 201f);
				return false;
			}
			FishingUI.CJMILOMGFJL(JIIGOACEIKL).IDLAGJNLPJL();
			return true;
		}
		return false;
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			if (DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH)
			{
				MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Exit build mode"));
				return false;
			}
			FishingUI.Get(JIIGOACEIKL).OpenUI();
			return true;
		}
		return false;
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	public bool GPHHMPEOCEJ(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IGHNIAICNEC(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("</color>"));
			return true;
		}
		return true;
	}

	public bool ACLPKJGGPFD(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool CONCJMINIFL(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (JMPMCJDDKGD(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Arguing"));
			return false;
		}
		return false;
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public void HDBKHJKPJCD(int JIIGOACEIKL)
	{
	}

	public bool JGKPIMAGPAK(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool CKBNJEEGDLK(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void DLBNJPKKNDN(int JIIGOACEIKL)
	{
	}

	public void NLLENLLOBLH(int JIIGOACEIKL)
	{
	}

	public bool MPOEJJLMJEK(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IBEMCOALOEJ(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("City/Hallmund/Bark/Buy"));
			return false;
		}
		return true;
	}

	public bool BKGFMLPODHD(int JIIGOACEIKL)
	{
		if (JMPMCJDDKGD(JIIGOACEIKL))
		{
			if (DecorationMode.KKJABELKCNM(JIIGOACEIKL).DBAEGBDEPFK())
			{
				MainUI.JDAEPLJAGCD(JIIGOACEIKL, LocalisationSystem.Get("MainProgress"), 1748f);
				return true;
			}
			FishingUI.CJMILOMGFJL(JIIGOACEIKL).OpenUI();
			return true;
		}
		return true;
	}

	public bool POCJGFBIJDL(int JIIGOACEIKL)
	{
		return !DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).MDOKKKHKKKE();
	}

	public bool DFHNFGMFGLH(int JIIGOACEIKL)
	{
		if (IBEMCOALOEJ(JIIGOACEIKL))
		{
			if (DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).KNFEPKBIHND())
			{
				MainUI.JDAEPLJAGCD(JIIGOACEIKL, LocalisationSystem.Get("Dialogue System/Conversation/Gass_Stand/Entry/15/Dialogue Text"), 1783f);
				return false;
			}
			FishingUI.CJMILOMGFJL(JIIGOACEIKL).EDHEIFHAAKO();
			return false;
		}
		return false;
	}

	public void LGFDLJLHEOJ(int JIIGOACEIKL)
	{
	}

	public bool LHHNLGOCKDM(int JIIGOACEIKL)
	{
		return !DecorationMode.OCJGHINCLJM(JIIGOACEIKL).DFNMDDHOIJI();
	}

	public bool AGDJBEKJHMD(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool IBEMCOALOEJ(int JIIGOACEIKL)
	{
		return DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public bool LJHHANBIACF(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void MMLJLLAPOGK(int JIIGOACEIKL)
	{
	}

	public bool KLNHOHEDAFN(int JIIGOACEIKL)
	{
		return DecorationMode.HBDCJFLINDA(JIIGOACEIKL).DFNMDDHOIJI();
	}

	public bool DJPAEAOBLHD(int JIIGOACEIKL)
	{
		if (HGBEJIIANJP(JIIGOACEIKL))
		{
			if (DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).DBAEGBDEPFK())
			{
				MainUI.LJDOBNEINNJ(JIIGOACEIKL, LocalisationSystem.Get("overnights"), 1805f);
				return false;
			}
			FishingUI.Get(JIIGOACEIKL).EDHEIFHAAKO();
			return true;
		}
		return true;
	}

	public void BJEHMFGABIK(int JIIGOACEIKL)
	{
	}

	public bool HOCCIDFOPHN(int JIIGOACEIKL)
	{
		return !DecorationMode.FIHGMLABOBB(JIIGOACEIKL).IDPGEBNGDJD();
	}

	public void FGIJLMGFNMM(int JIIGOACEIKL)
	{
	}

	public void LJLHGJDHFOJ(int JIIGOACEIKL)
	{
	}
}
