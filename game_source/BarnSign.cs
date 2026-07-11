using System;
using UnityEngine;

public class BarnSign : MonoBehaviour, IInteractable, IHoverable, IProximity, ISelectable
{
	public bool ALACNHCEGFM(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool PickUp(int JIIGOACEIKL)
	{
		return false;
	}

	public bool OPCLGDNHJMI(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void FPPLEDOHKNB(int JIIGOACEIKL)
	{
	}

	public bool KOLGJHCLPNE(int JIIGOACEIKL)
	{
		return DecorationMode.FIHGMLABOBB(JIIGOACEIKL).IDPGEBNGDJD();
	}

	public bool INHDHCOFLJI(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && KOLGJHCLPNE(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Items/item_name_642"));
			return false;
		}
		return true;
	}

	public bool PBEPBBPAFOH(int JIIGOACEIKL)
	{
		return true;
	}

	public bool AIGDFDEMGNN(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool KNJMJGOAJFI(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool NNIGPOBLKFE(int JIIGOACEIKL)
	{
		return false;
	}

	public bool OOPEBECPHCA(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && DJCHCODJOIP(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Keg"));
			return false;
		}
		return true;
	}

	public bool PHGADHENHDF(int JIIGOACEIKL)
	{
		if (FGFPGOFNDBG(JIIGOACEIKL))
		{
			FarmBuildingInfoUI.PNBHIEINMGH(JIIGOACEIKL).farmBuilding = Barn.instance;
			FarmBuildingInfoUI.DEBKDBICLIC(JIIGOACEIKL).EDHEIFHAAKO();
			InteractObject.GNCPLNHMFHN(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
			return false;
		}
		return false;
	}

	public bool LEGFGMKPJOA(int JIIGOACEIKL)
	{
		InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = null;
		return false;
	}

	public bool IFBJHCHDHCI(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && BGAFGOLFDGI(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("[GetFallbackCandidates] Added inactive spawner {0} from piece {1}"));
			return true;
		}
		return true;
	}

	public void PJNPPBCLBCO(int JIIGOACEIKL)
	{
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public bool CONCJMINIFL(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && KCMHBADACDJ(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("itemSweetPotato"));
			return true;
		}
		return true;
	}

	public bool PJBBLEGMBAK(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool CAIOMAEKPFK(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Open"));
			return true;
		}
		return false;
	}

	public bool NHGDAEOPGOG(int JIIGOACEIKL)
	{
		return false;
	}

	public bool HGAJIMIGBIH(int JIIGOACEIKL)
	{
		return DecorationMode.IECFJGHAIDO(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public bool IOANEJAHOMG(int JIIGOACEIKL)
	{
		InteractObject.GNCPLNHMFHN(JIIGOACEIKL).interactingObject = null;
		return false;
	}

	public bool CFGOGPBMEKL(int JIIGOACEIKL)
	{
		return DecorationMode.BGINAIDHDOM(JIIGOACEIKL).GABNNLJOMHI();
	}

	public bool KCDBIMPMGON(int JIIGOACEIKL)
	{
		return true;
	}

	public bool JICELFNEHKN(int JIIGOACEIKL)
	{
		return false;
	}

	public bool IPPODLIPDPJ(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool PLJHIFHNOBD(int JIIGOACEIKL)
	{
		return false;
	}

	public void LINJNPGDLGA(int JIIGOACEIKL)
	{
	}

	public bool HADFLDNPJFP(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && FGFPGOFNDBG(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("SendInitialPosition"));
			return false;
		}
		return false;
	}

	public bool DOFBPGOCNEN(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && KCMHBADACDJ(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Items/item_name_646"));
			return false;
		}
		return false;
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void DBPLFIOGBOM(int JIIGOACEIKL)
	{
	}

	public bool KNPOMBCGKEL(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool LBNJPLCFLEE(int JIIGOACEIKL)
	{
		if (BANJNCOOACM(JIIGOACEIKL))
		{
			FarmBuildingInfoUI.BBDNJAKIBFN(JIIGOACEIKL).farmBuilding = Barn.instance;
			FarmBuildingInfoUI.FKFNANNBIAM(JIIGOACEIKL).EDHEIFHAAKO();
			InteractObject.GNCPLNHMFHN(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
			return true;
		}
		return true;
	}

	public bool BANJNCOOACM(int JIIGOACEIKL)
	{
		return !DecorationMode.OCJGHINCLJM(JIIGOACEIKL).MDOKKKHKKKE();
	}

	public bool CFMCMBHFIPK(int JIIGOACEIKL)
	{
		InteractObject.GNCPLNHMFHN(JIIGOACEIKL).interactingObject = null;
		return true;
	}

	public bool CMIOKHGJCNB(int JIIGOACEIKL)
	{
		if (BANJNCOOACM(JIIGOACEIKL))
		{
			FarmBuildingInfoUI.AANKLOIDPOA(JIIGOACEIKL).farmBuilding = Barn.instance;
			FarmBuildingInfoUI.BDJFHFHLJGN(JIIGOACEIKL).OpenUI();
			InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
			return false;
		}
		return true;
	}

	public bool HAOPENBNBFF(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && BGAFGOLFDGI(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("OnFloor"));
			return false;
		}
		return false;
	}

	public bool BOBIPFOJBKC(int JIIGOACEIKL)
	{
		return true;
	}

	public void MOBFEFJFGBE(int JIIGOACEIKL)
	{
	}

	public bool BBCJCNGNGIC(int JIIGOACEIKL)
	{
		return false;
	}

	public bool BGAFGOLFDGI(int JIIGOACEIKL)
	{
		return DecorationMode.HBDCJFLINDA(JIIGOACEIKL).MDOKKKHKKKE();
	}

	public bool BBIMBLPLMJP(int JIIGOACEIKL)
	{
		InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = null;
		return false;
	}

	public bool GLMIPLOGIBB(int JIIGOACEIKL)
	{
		InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = null;
		return true;
	}

	public bool PPJOGFFLKOL(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool AFAKDLGLBEG(int JIIGOACEIKL)
	{
		return true;
	}

	public bool OFBABFAOFEJ(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool AEEKGBMEPFF(int JIIGOACEIKL)
	{
		if (FGFPGOFNDBG(JIIGOACEIKL))
		{
			FarmBuildingInfoUI.NHOFBAMNELD(JIIGOACEIKL).farmBuilding = Barn.instance;
			FarmBuildingInfoUI.NMCJELBLKBB(JIIGOACEIKL).IDLAGJNLPJL();
			InteractObject.GNCPLNHMFHN(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
			return true;
		}
		return true;
	}

	public bool FBCDEMIAKBP(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("itemBock"));
			return false;
		}
		return true;
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			FarmBuildingInfoUI.Get(JIIGOACEIKL).farmBuilding = Barn.instance;
			FarmBuildingInfoUI.Get(JIIGOACEIKL).OpenUI();
			InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
			return true;
		}
		return false;
	}

	public void MJNNGIAAGFH(int JIIGOACEIKL)
	{
	}

	public bool EDDDDEJIEHC(int JIIGOACEIKL)
	{
		return false;
	}

	public bool KCMHBADACDJ(int JIIGOACEIKL)
	{
		return !DecorationMode.NPANPNIDKDG(JIIGOACEIKL).DFNMDDHOIJI();
	}

	public bool JJGALHCPJFM(int JIIGOACEIKL)
	{
		return true;
	}

	public bool HEGFIAIHPPD(int JIIGOACEIKL)
	{
		return true;
	}

	public bool SelectOnline(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool DAGCKCKKKCJ(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && BGAFGOLFDGI(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Pause"));
			return true;
		}
		return false;
	}

	public void KJOAMBGFFHE(int JIIGOACEIKL)
	{
	}

	public bool GHGMCIBINGB(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool Deselect(int JIIGOACEIKL)
	{
		InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = null;
		return true;
	}

	public bool IKAIGCMENPF(int JIIGOACEIKL)
	{
		if (FGFPGOFNDBG(JIIGOACEIKL))
		{
			FarmBuildingInfoUI.EAONFFENMCE(JIIGOACEIKL).farmBuilding = Barn.instance;
			FarmBuildingInfoUI.DEBKDBICLIC(JIIGOACEIKL).IDLAGJNLPJL();
			InteractObject.BBJCJFJEFKK(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
			return false;
		}
		return true;
	}

	public bool NNNKIBGDAJP(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool DCNNPBDIALP(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool FACGEEJCMEC(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool JNCIONKLFBF(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool OHLAKCMJEDJ(int JIIGOACEIKL)
	{
		InteractObject.GNCPLNHMFHN(JIIGOACEIKL).interactingObject = null;
		return true;
	}

	public bool CHEBOFEFAPD(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void MANFKPEAMLJ(int JIIGOACEIKL)
	{
	}

	public void NAHGJLOOLOI(int JIIGOACEIKL)
	{
	}

	public bool NLHJADOBPKC(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool FGONKCAKHLE(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool Select(int JIIGOACEIKL)
	{
		return false;
	}

	public bool JONCEAPNGEC(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && BGAFGOLFDGI(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Unique id "));
			return false;
		}
		return true;
	}

	public void ANHBEBGBDAG(int JIIGOACEIKL)
	{
	}

	public bool FKDFHIKHPAG(int JIIGOACEIKL)
	{
		return false;
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public bool FGFPGOFNDBG(int JIIGOACEIKL)
	{
		return DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).DFNMDDHOIJI();
	}

	public bool DJCHCODJOIP(int JIIGOACEIKL)
	{
		return !DecorationMode.NPANPNIDKDG(JIIGOACEIKL).IDPGEBNGDJD();
	}

	public bool KBLEJDFHIHJ(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && KCMHBADACDJ(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("UpgradeConfirmation"));
			return true;
		}
		return false;
	}

	public bool GAOELNCCCKG(int JIIGOACEIKL)
	{
		return false;
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}
}
