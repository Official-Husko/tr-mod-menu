using System;
using UnityEngine;

public class Calendar : MonoBehaviour, IInteractable, ISelectable, IProximity, IHoverable
{
	[SerializeField]
	private Placeable placeable;

	public bool MDOKMENGIGJ(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool KDKCLGIABEO(int JIIGOACEIKL)
	{
		return true;
	}

	public bool CHAGCELLLOJ(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && DIDJLLMCNMH(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(""));
			return true;
		}
		return false;
	}

	public bool MGIFADFILOI(int JIIGOACEIKL)
	{
		return true;
	}

	public bool HEICGOJPPCB(int JIIGOACEIKL)
	{
		CalendarUI.LAIEKOOCNPC(JIIGOACEIKL).BOBCIFEDJED();
		InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return true;
	}

	public bool BOALDJKKBLD(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool FCLHFAJMLBO(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			SelectObject.GetPlayer(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
			InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
			CalendarUI.PIOIOJFDDNF(JIIGOACEIKL).openedFromNoticeBoard = false;
			CalendarUI.BFCEHJIIAHN(JIIGOACEIKL).EDHEIFHAAKO();
			return false;
		}
		return false;
	}

	public bool KOIBLHNPOCO(int JIIGOACEIKL)
	{
		return false;
	}

	public bool BNPJHDGDFOF(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			SelectObject.BNMEANGDMIP(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
			InteractObject.GNCPLNHMFHN(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
			CalendarUI.PIOIOJFDDNF(JIIGOACEIKL).openedFromNoticeBoard = true;
			CalendarUI.Get(JIIGOACEIKL).OpenUI();
			return false;
		}
		return true;
	}

	public bool IAADPNPGOJG(int JIIGOACEIKL)
	{
		return false;
	}

	public bool NLFAOKPFHFJ(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool JPDMPGABGAD(int JIIGOACEIKL)
	{
		if (!placeable.FHEMHCEAICB)
		{
			return DecorationMode.FIHGMLABOBB(JIIGOACEIKL).DBAEGBDEPFK();
		}
		return true;
	}

	public void EBMLHKMPGHL(int JIIGOACEIKL)
	{
	}

	public bool IPOBMHIPCAC(int JIIGOACEIKL)
	{
		return true;
	}

	public bool LBFONHFFLCH(int JIIGOACEIKL)
	{
		return false;
	}

	public bool LDFBGJOFCHB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool POMKPBKCMFN(int JIIGOACEIKL)
	{
		if (!placeable.FHEMHCEAICB)
		{
			return DecorationMode.KKJABELKCNM(JIIGOACEIKL).DMBFKFLDDLH;
		}
		return false;
	}

	public bool SelectOnline(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void ANHBEBGBDAG(int JIIGOACEIKL)
	{
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if (!placeable.FHEMHCEAICB)
		{
			return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
		}
		return false;
	}

	public bool KAHCMAEPNLK(int JIIGOACEIKL)
	{
		return true;
	}

	public bool DKJMKJKHKNC(int JIIGOACEIKL)
	{
		CalendarUI.NDPAJCGHGOB(JIIGOACEIKL).CloseUI();
		InteractObject.BBJCJFJEFKK(JIIGOACEIKL).interactingObject = null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return false;
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

	public bool Deselect(int JIIGOACEIKL)
	{
		CalendarUI.Get(JIIGOACEIKL).CloseUI();
		InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return true;
	}

	public bool GCBJNGNEIFH(int JIIGOACEIKL)
	{
		return true;
	}

	public void FGKKKMFELJH(int JIIGOACEIKL)
	{
	}

	public bool GBGFGEHMBOO(int JIIGOACEIKL)
	{
		return true;
	}

	public void FOGLDLKAEBK(int JIIGOACEIKL)
	{
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool HADFLDNPJFP(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && EIKPGOMHKOH(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Ingredient"));
			return true;
		}
		return false;
	}

	public bool DIDJLLMCNMH(int JIIGOACEIKL)
	{
		if (!placeable.FHEMHCEAICB)
		{
			return !DecorationMode.KKJABELKCNM(JIIGOACEIKL).DFNMDDHOIJI();
		}
		return true;
	}

	public bool LDFBAJAHNLA(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool OOJPCIDDGCN(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			SelectObject.BNMEANGDMIP(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
			InteractObject.BBJCJFJEFKK(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
			CalendarUI.JHOHGMODKGM(JIIGOACEIKL).openedFromNoticeBoard = true;
			CalendarUI.HKCAIFFKBMH(JIIGOACEIKL).EDHEIFHAAKO();
			return true;
		}
		return true;
	}

	public bool BMMJFGMBDLG(int JIIGOACEIKL)
	{
		return true;
	}

	public bool PKMCGOIEGJK(int JIIGOACEIKL)
	{
		return true;
	}

	public bool Select(int JIIGOACEIKL)
	{
		return false;
	}

	public bool NMAOFEFMNNB(int JIIGOACEIKL)
	{
		return false;
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			SelectObject.GetPlayer(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
			InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
			CalendarUI.Get(JIIGOACEIKL).openedFromNoticeBoard = false;
			CalendarUI.Get(JIIGOACEIKL).OpenUI();
			return true;
		}
		return false;
	}

	public bool MNHPDNLNAAB(int JIIGOACEIKL)
	{
		return true;
	}

	public bool JGAKCPNGEFG(int JIIGOACEIKL)
	{
		return true;
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public bool AGJPLNCFBCF(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void LJOLGDBKLGH(int JIIGOACEIKL)
	{
	}

	public bool LCLJFCKELJN(int JIIGOACEIKL)
	{
		CalendarUI.BFCEHJIIAHN(JIIGOACEIKL).CloseUI();
		InteractObject.BBJCJFJEFKK(JIIGOACEIKL).interactingObject = null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return false;
	}

	public void GGCCMCLILLH(int JIIGOACEIKL)
	{
	}

	public bool LFPIKHDHIEM(int JIIGOACEIKL)
	{
		return true;
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	public void NAKPCICILDA(int JIIGOACEIKL)
	{
	}

	public bool CAJMKLBCBEK(int JIIGOACEIKL)
	{
		if (HLDFEKIDJAK(JIIGOACEIKL))
		{
			SelectObject.BNMEANGDMIP(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
			InteractObject.BBJCJFJEFKK(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
			CalendarUI.NDPAJCGHGOB(JIIGOACEIKL).openedFromNoticeBoard = false;
			CalendarUI.JHOHGMODKGM(JIIGOACEIKL).EDHEIFHAAKO();
			return false;
		}
		return true;
	}

	public void CPMBHEGDAMB(int JIIGOACEIKL)
	{
	}

	public bool HDLNAIBNIHM(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool DODHNPJFCCD(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void CJOLCLDGFMB(int JIIGOACEIKL)
	{
	}

	public bool CAPOGEMJEHI(int JIIGOACEIKL)
	{
		if (POMKPBKCMFN(JIIGOACEIKL))
		{
			SelectObject.GetPlayer(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
			InteractObject.GNCPLNHMFHN(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
			CalendarUI.EPLOMIBMKFC(JIIGOACEIKL).openedFromNoticeBoard = false;
			CalendarUI.JHOHGMODKGM(JIIGOACEIKL).IDLAGJNLPJL();
			return false;
		}
		return false;
	}

	public bool IJNMMFDHDJC(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool MPOEJJLMJEK(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && HLDFEKIDJAK(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Reputation"));
			return true;
		}
		return false;
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool NKHLGGKOKKA(int JIIGOACEIKL)
	{
		if (!placeable.FHEMHCEAICB)
		{
			return !DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).GABNNLJOMHI();
		}
		return false;
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public bool PickUp(int JIIGOACEIKL)
	{
		return false;
	}

	public bool DKLAKIBJKID(int JIIGOACEIKL)
	{
		if (HLDFEKIDJAK(JIIGOACEIKL))
		{
			SelectObject.GetPlayer(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
			InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
			CalendarUI.HKCAIFFKBMH(JIIGOACEIKL).openedFromNoticeBoard = true;
			CalendarUI.PIOIOJFDDNF(JIIGOACEIKL).IDLAGJNLPJL();
			return false;
		}
		return false;
	}

	public bool HLDFEKIDJAK(int JIIGOACEIKL)
	{
		if (!placeable.FHEMHCEAICB)
		{
			return !DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).GABNNLJOMHI();
		}
		return false;
	}

	public bool KPMOGGHEGCM(int JIIGOACEIKL)
	{
		return false;
	}

	public bool EIKPGOMHKOH(int JIIGOACEIKL)
	{
		if (!placeable.FHEMHCEAICB)
		{
			return DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).MDOKKKHKKKE();
		}
		return true;
	}
}
