using System;
using UnityEngine;

public class Wardrobe : MonoBehaviour, IInteractable, ISelectable, IHoverable, IProximity
{
	[SerializeField]
	private Placeable placeable;

	private int JIIGOACEIKL = 1;

	public bool KLNHOHEDAFN(int JIIGOACEIKL)
	{
		if (!placeable.FHEMHCEAICB)
		{
			return !DecorationMode.GetPlayer(JIIGOACEIKL).DFNMDDHOIJI();
		}
		return true;
	}

	public bool ICDABOJKNHL(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool IDMKOACGEHF(int JIIGOACEIKL)
	{
		if (MOOCHJLACGJ(JIIGOACEIKL))
		{
			this.JIIGOACEIKL = JIIGOACEIKL;
			CharacterCreatorUI.loadGame = null;
			CharacterCreatorUI.DPBGKDNKDGM(JIIGOACEIKL).IDLAGJNLPJL();
			SelectObject.BNMEANGDMIP(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
			InteractObject.GNCPLNHMFHN(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
			PlayerController playerController = PlayerController.OPHDCMJLLEC(JIIGOACEIKL);
			playerController.OnPlayerMoving = (Action)Delegate.Combine(playerController.OnPlayerMoving, new Action(IKLOPEAPIAA));
			CharacterCreatorUI characterCreatorUI = CharacterCreatorUI.Get(JIIGOACEIKL);
			characterCreatorUI.OnUIClose = (Action<int>)Delegate.Combine(characterCreatorUI.OnUIClose, new Action<int>(GHHLMEAEMAC));
			return false;
		}
		return false;
	}

	public bool DDKLIFBPKBF(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void AILOICIGFNL()
	{
		Close(JIIGOACEIKL);
	}

	public void MHHODBJHKIK(int JIIGOACEIKL)
	{
	}

	public bool MOHNGCNKAHM(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool LHMEENAPJBF(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void MLFMFJPDEAB(int JIIGOACEIKL)
	{
		PlayerController player = PlayerController.GetPlayer(JIIGOACEIKL);
		player.OnPlayerMoving = (Action)Delegate.Remove(player.OnPlayerMoving, new Action(JPPLHEFGHEM));
		CharacterCreatorUI.FKFNANNBIAM(JIIGOACEIKL).BOBCIFEDJED();
		CharacterCreatorUI characterCreatorUI = CharacterCreatorUI.DPBGKDNKDGM(JIIGOACEIKL);
		characterCreatorUI.OnUIClose = (Action<int>)Delegate.Remove(characterCreatorUI.OnUIClose, new Action<int>(NJGFJFEGBNF));
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool MDENHNAGFPM(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool CMPEPGEMEDI(int JIIGOACEIKL)
	{
		return false;
	}

	public void IKLOPEAPIAA()
	{
		NHBBCDIDEFI(JIIGOACEIKL);
	}

	public bool MIPMHKIBHPI(int JIIGOACEIKL)
	{
		return false;
	}

	public bool NGADLDIINDJ(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool ONCPELJEPHM(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (MOOCHJLACGJ(JIIGOACEIKL) && !IIEDALMMNLI)
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(""));
			return true;
		}
		return true;
	}

	public bool CKLJAHPIFLP(int JIIGOACEIKL)
	{
		if (GIPEJKINDHI(JIIGOACEIKL))
		{
			this.JIIGOACEIKL = JIIGOACEIKL;
			CharacterCreatorUI.loadGame = null;
			CharacterCreatorUI.MENPEHNHFOA(JIIGOACEIKL).IDLAGJNLPJL();
			SelectObject.GetPlayer(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
			InteractObject.BBJCJFJEFKK(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
			PlayerController playerController = PlayerController.OPHDCMJLLEC(JIIGOACEIKL);
			playerController.OnPlayerMoving = (Action)Delegate.Combine(playerController.OnPlayerMoving, new Action(KHEMDIMKCBF));
			CharacterCreatorUI characterCreatorUI = CharacterCreatorUI.PCEEOGGDBFB(JIIGOACEIKL);
			characterCreatorUI.OnUIClose = (Action<int>)Delegate.Combine(characterCreatorUI.OnUIClose, new Action<int>(NHBBCDIDEFI));
			return true;
		}
		return false;
	}

	public bool KHMBIHKFPCE(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (MOOCHJLACGJ(JIIGOACEIKL) && !IIEDALMMNLI)
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("DebugRoom{0}"));
			return true;
		}
		return true;
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool FEEGKDKHJOE(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL) && !IIEDALMMNLI)
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Open"));
			return true;
		}
		return false;
	}

	public bool DMIMDIPKKFP(int JIIGOACEIKL)
	{
		return true;
	}

	private void ALKAHIBLFJM(int JIIGOACEIKL)
	{
	}

	public bool ONDCECMGOPE(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (EIKPGOMHKOH(JIIGOACEIKL) && !IIEDALMMNLI)
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Brook Recipe turn in"));
			return true;
		}
		return true;
	}

	public void PHCLBLFPGAF()
	{
		NHBBCDIDEFI(JIIGOACEIKL);
	}

	private void GHLJDKMLEDK(int JIIGOACEIKL)
	{
	}

	public bool CGNGIFDKHEB(int JIIGOACEIKL)
	{
		return true;
	}

	public bool NDNJPJHHKDJ(int JIIGOACEIKL)
	{
		CharacterCreatorUI.Get(JIIGOACEIKL).BOBCIFEDJED();
		InteractObject.BBJCJFJEFKK(JIIGOACEIKL).interactingObject = null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return false;
	}

	public bool LJBDLOGNBOO(int JIIGOACEIKL)
	{
		CharacterCreatorUI.Get(JIIGOACEIKL).CloseUI();
		InteractObject.BBJCJFJEFKK(JIIGOACEIKL).interactingObject = null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return false;
	}

	public bool ENEEKLIOELF(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void CEHMGOIOEKJ(int JIIGOACEIKL)
	{
	}

	public void BDOIOGAELHD(int JIIGOACEIKL)
	{
		PlayerController playerController = PlayerController.OPHDCMJLLEC(JIIGOACEIKL);
		playerController.OnPlayerMoving = (Action)Delegate.Remove(playerController.OnPlayerMoving, new Action(GCJAMDLBIHP));
		CharacterCreatorUI.MENPEHNHFOA(JIIGOACEIKL).CloseUI();
		CharacterCreatorUI characterCreatorUI = CharacterCreatorUI.FKFNANNBIAM(JIIGOACEIKL);
		characterCreatorUI.OnUIClose = (Action<int>)Delegate.Remove(characterCreatorUI.OnUIClose, new Action<int>(GHHLMEAEMAC));
	}

	public bool DIDPBPLLHCE(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (KLNHOHEDAFN(JIIGOACEIKL) && !IIEDALMMNLI)
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("report_type"));
			return false;
		}
		return true;
	}

	public void Close(int JIIGOACEIKL)
	{
		PlayerController player = PlayerController.GetPlayer(JIIGOACEIKL);
		player.OnPlayerMoving = (Action)Delegate.Remove(player.OnPlayerMoving, new Action(Close));
		CharacterCreatorUI.Get(JIIGOACEIKL).CloseUI();
		CharacterCreatorUI characterCreatorUI = CharacterCreatorUI.Get(JIIGOACEIKL);
		characterCreatorUI.OnUIClose = (Action<int>)Delegate.Remove(characterCreatorUI.OnUIClose, new Action<int>(Close));
	}

	public void GCJAMDLBIHP()
	{
		APDFEPNNPMJ(JIIGOACEIKL);
	}

	public bool EIKPGOMHKOH(int JIIGOACEIKL)
	{
		if (!placeable.FHEMHCEAICB)
		{
			return DecorationMode.GetPlayer(JIIGOACEIKL).MDOKKKHKKKE();
		}
		return true;
	}

	public bool CFJEJFCALPM(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			this.JIIGOACEIKL = JIIGOACEIKL;
			CharacterCreatorUI.loadGame = null;
			CharacterCreatorUI.DPBGKDNKDGM(JIIGOACEIKL).IDLAGJNLPJL();
			SelectObject.BNMEANGDMIP(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
			InteractObject.BBJCJFJEFKK(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
			PlayerController player = PlayerController.GetPlayer(JIIGOACEIKL);
			player.OnPlayerMoving = (Action)Delegate.Combine(player.OnPlayerMoving, new Action(PFPINDHPIEF));
			CharacterCreatorUI characterCreatorUI = CharacterCreatorUI.Get(JIIGOACEIKL);
			characterCreatorUI.OnUIClose = (Action<int>)Delegate.Combine(characterCreatorUI.OnUIClose, new Action<int>(JMEOOIFODLF));
			return false;
		}
		return false;
	}

	public bool BLOKJLKHPHL(int JIIGOACEIKL)
	{
		return true;
	}

	public bool CKOLDHCGLND(int JIIGOACEIKL)
	{
		return false;
	}

	public bool KPMOGGHEGCM(int JIIGOACEIKL)
	{
		return false;
	}

	public bool MFBIEPCFBFL(int JIIGOACEIKL)
	{
		CharacterCreatorUI.DPBGKDNKDGM(JIIGOACEIKL).CloseUI();
		InteractObject.GNCPLNHMFHN(JIIGOACEIKL).interactingObject = null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return false;
	}

	public void NLGFBHJFJMJ()
	{
		NHBBCDIDEFI(JIIGOACEIKL);
	}

	private void CNJJMFDBLBI(int JIIGOACEIKL)
	{
	}

	public void APDFEPNNPMJ(int JIIGOACEIKL)
	{
		PlayerController player = PlayerController.GetPlayer(JIIGOACEIKL);
		player.OnPlayerMoving = (Action)Delegate.Remove(player.OnPlayerMoving, new Action(KHEMDIMKCBF));
		CharacterCreatorUI.Get(JIIGOACEIKL).BOBCIFEDJED();
		CharacterCreatorUI characterCreatorUI = CharacterCreatorUI.MENPEHNHFOA(JIIGOACEIKL);
		characterCreatorUI.OnUIClose = (Action<int>)Delegate.Remove(characterCreatorUI.OnUIClose, new Action<int>(BDOIOGAELHD));
	}

	private void OPOHDGLGGMK(int JIIGOACEIKL)
	{
	}

	public bool MNHPDNLNAAB(int JIIGOACEIKL)
	{
		return false;
	}

	public bool OCOFAKALNBL(int JIIGOACEIKL)
	{
		if (!placeable.FHEMHCEAICB)
		{
			return !DecorationMode.IECFJGHAIDO(JIIGOACEIKL).DFNMDDHOIJI();
		}
		return true;
	}

	public void JPPLHEFGHEM()
	{
		Close(JIIGOACEIKL);
	}

	public bool JNCIONKLFBF(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool GIPEJKINDHI(int JIIGOACEIKL)
	{
		if (!placeable.FHEMHCEAICB)
		{
			return !DecorationMode.EKLMFMKPEBB(JIIGOACEIKL).IDPGEBNGDJD();
		}
		return true;
	}

	public bool FPHAKPOJPPJ(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void DGPCNLBJIKK(int JIIGOACEIKL)
	{
	}

	private void DCFIEEPNJCE(int JIIGOACEIKL)
	{
	}

	private void JDLHADDFCJJ(int JIIGOACEIKL)
	{
	}

	public bool LNBEOIFMEOG(int JIIGOACEIKL)
	{
		return true;
	}

	public void LFALLFNNINI(int JIIGOACEIKL)
	{
	}

	public void JMEOOIFODLF(int JIIGOACEIKL)
	{
		PlayerController player = PlayerController.GetPlayer(JIIGOACEIKL);
		player.OnPlayerMoving = (Action)Delegate.Remove(player.OnPlayerMoving, new Action(JPPLHEFGHEM));
		CharacterCreatorUI.FKFNANNBIAM(JIIGOACEIKL).BOBCIFEDJED();
		CharacterCreatorUI characterCreatorUI = CharacterCreatorUI.DPBGKDNKDGM(JIIGOACEIKL);
		characterCreatorUI.OnUIClose = (Action<int>)Delegate.Remove(characterCreatorUI.OnUIClose, new Action<int>(BDOIOGAELHD));
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if (!placeable.FHEMHCEAICB)
		{
			return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
		}
		return false;
	}

	public bool CFMCMBHFIPK(int JIIGOACEIKL)
	{
		CharacterCreatorUI.DPBGKDNKDGM(JIIGOACEIKL).CloseUI();
		InteractObject.BBJCJFJEFKK(JIIGOACEIKL).interactingObject = null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return true;
	}

	public bool UpdateWithProximity(int JIIGOACEIKL)
	{
		return true;
	}

	public bool PPPANMMFGDO(int JIIGOACEIKL)
	{
		CharacterCreatorUI.DPBGKDNKDGM(JIIGOACEIKL).CloseUI();
		InteractObject.GNCPLNHMFHN(JIIGOACEIKL).interactingObject = null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return true;
	}

	public bool LCEMHLJHCAD(int JIIGOACEIKL)
	{
		return true;
	}

	public void KMPILLCNJPC(int JIIGOACEIKL)
	{
	}

	public void NJGFJFEGBNF(int JIIGOACEIKL)
	{
		PlayerController playerController = PlayerController.OPHDCMJLLEC(JIIGOACEIKL);
		playerController.OnPlayerMoving = (Action)Delegate.Remove(playerController.OnPlayerMoving, new Action(NMFIEPNDFFO));
		CharacterCreatorUI.DPBGKDNKDGM(JIIGOACEIKL).BOBCIFEDJED();
		CharacterCreatorUI characterCreatorUI = CharacterCreatorUI.PCEEOGGDBFB(JIIGOACEIKL);
		characterCreatorUI.OnUIClose = (Action<int>)Delegate.Remove(characterCreatorUI.OnUIClose, new Action<int>(GHHLMEAEMAC));
	}

	private void HGLNJOMPFEH(int JIIGOACEIKL)
	{
	}

	public void DADJFJLHBPO()
	{
		APDFEPNNPMJ(JIIGOACEIKL);
	}

	public void NLGJCNGLFBC()
	{
		NHBBCDIDEFI(JIIGOACEIKL);
	}

	public bool POCJGFBIJDL(int JIIGOACEIKL)
	{
		if (!placeable.FHEMHCEAICB)
		{
			return !DecorationMode.KKJABELKCNM(JIIGOACEIKL).KNFEPKBIHND();
		}
		return false;
	}

	private void NDKGINONMIC(int JIIGOACEIKL)
	{
	}

	public void FGKKKMFELJH(int JIIGOACEIKL)
	{
	}

	public bool BLPDCBLMODH(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool ELCOPCJDDPD(int JIIGOACEIKL)
	{
		return false;
	}

	public void OIMEKODEFAA(int JIIGOACEIKL)
	{
	}

	public void KHEMDIMKCBF()
	{
		APDFEPNNPMJ(JIIGOACEIKL);
	}

	public bool PickUp(int JIIGOACEIKL)
	{
		return false;
	}

	public void PFPINDHPIEF()
	{
		NHBBCDIDEFI(JIIGOACEIKL);
	}

	public bool CDDJCCMHHPE(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	private void JODGNHJLEPK(int JIIGOACEIKL)
	{
	}

	public bool Select(int JIIGOACEIKL)
	{
		return false;
	}

	public bool EOBECMHBLCK(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL) && !IIEDALMMNLI)
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get(""));
			return true;
		}
		return true;
	}

	public bool NHGDAEOPGOG(int JIIGOACEIKL)
	{
		return true;
	}

	public void GCNAPIBILLG()
	{
		BDOIOGAELHD(JIIGOACEIKL);
	}

	public bool SelectOnline(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool FAFNDKCPGLK(int JIIGOACEIKL)
	{
		CharacterCreatorUI.DPBGKDNKDGM(JIIGOACEIKL).BOBCIFEDJED();
		InteractObject.GNCPLNHMFHN(JIIGOACEIKL).interactingObject = null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return false;
	}

	public void GHHLMEAEMAC(int JIIGOACEIKL)
	{
		PlayerController playerController = PlayerController.OPHDCMJLLEC(JIIGOACEIKL);
		playerController.OnPlayerMoving = (Action)Delegate.Remove(playerController.OnPlayerMoving, new Action(NLGFBHJFJMJ));
		CharacterCreatorUI.FKFNANNBIAM(JIIGOACEIKL).CloseUI();
		CharacterCreatorUI characterCreatorUI = CharacterCreatorUI.MENPEHNHFOA(JIIGOACEIKL);
		characterCreatorUI.OnUIClose = (Action<int>)Delegate.Remove(characterCreatorUI.OnUIClose, new Action<int>(MLFMFJPDEAB));
	}

	private void AHDBLNKNEBM(int JIIGOACEIKL)
	{
	}

	public bool BJDIKIKPEJE(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (KLNHOHEDAFN(JIIGOACEIKL) && !IIEDALMMNLI)
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Item "));
			return true;
		}
		return false;
	}

	public bool LGDMGLJCBJM(int JIIGOACEIKL)
	{
		if (KLNHOHEDAFN(JIIGOACEIKL))
		{
			this.JIIGOACEIKL = JIIGOACEIKL;
			CharacterCreatorUI.loadGame = null;
			CharacterCreatorUI.DPBGKDNKDGM(JIIGOACEIKL).IDLAGJNLPJL();
			SelectObject.BNMEANGDMIP(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
			InteractObject.GNCPLNHMFHN(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
			PlayerController player = PlayerController.GetPlayer(JIIGOACEIKL);
			player.OnPlayerMoving = (Action)Delegate.Combine(player.OnPlayerMoving, new Action(JPPLHEFGHEM));
			CharacterCreatorUI characterCreatorUI = CharacterCreatorUI.MENPEHNHFOA(JIIGOACEIKL);
			characterCreatorUI.OnUIClose = (Action<int>)Delegate.Combine(characterCreatorUI.OnUIClose, new Action<int>(Close));
			return false;
		}
		return false;
	}

	public bool ALGCHPCDFBM(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void Close()
	{
		Close(JIIGOACEIKL);
	}

	public void NMFIEPNDFFO()
	{
		APDFEPNNPMJ(JIIGOACEIKL);
	}

	public bool Deselect(int JIIGOACEIKL)
	{
		CharacterCreatorUI.Get(JIIGOACEIKL).CloseUI();
		InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return true;
	}

	public bool MMAPHMGNIFI(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool LAMLEBJIALP(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool MOOCHJLACGJ(int JIIGOACEIKL)
	{
		if (!placeable.FHEMHCEAICB)
		{
			return !DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).KNFEPKBIHND();
		}
		return false;
	}

	public bool FMENCNMDFNE(int JIIGOACEIKL)
	{
		CharacterCreatorUI.PCEEOGGDBFB(JIIGOACEIKL).CloseUI();
		InteractObject.GNCPLNHMFHN(JIIGOACEIKL).interactingObject = null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return false;
	}

	public void NHBBCDIDEFI(int JIIGOACEIKL)
	{
		PlayerController playerController = PlayerController.OPHDCMJLLEC(JIIGOACEIKL);
		playerController.OnPlayerMoving = (Action)Delegate.Remove(playerController.OnPlayerMoving, new Action(DADJFJLHBPO));
		CharacterCreatorUI.FKFNANNBIAM(JIIGOACEIKL).BOBCIFEDJED();
		CharacterCreatorUI characterCreatorUI = CharacterCreatorUI.PCEEOGGDBFB(JIIGOACEIKL);
		characterCreatorUI.OnUIClose = (Action<int>)Delegate.Remove(characterCreatorUI.OnUIClose, new Action<int>(GHHLMEAEMAC));
	}

	private void GOGBLIJGNNE(int JIIGOACEIKL)
	{
	}

	public bool BLKDONCHKGE(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			this.JIIGOACEIKL = JIIGOACEIKL;
			CharacterCreatorUI.loadGame = null;
			CharacterCreatorUI.Get(JIIGOACEIKL).OpenUI();
			SelectObject.GetPlayer(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
			InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
			PlayerController player = PlayerController.GetPlayer(JIIGOACEIKL);
			player.OnPlayerMoving = (Action)Delegate.Combine(player.OnPlayerMoving, new Action(Close));
			CharacterCreatorUI characterCreatorUI = CharacterCreatorUI.Get(JIIGOACEIKL);
			characterCreatorUI.OnUIClose = (Action<int>)Delegate.Combine(characterCreatorUI.OnUIClose, new Action<int>(Close));
			return true;
		}
		return false;
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public bool COMBMANAGOB(int JIIGOACEIKL)
	{
		return false;
	}

	private void KIOKKIEPNEO(int JIIGOACEIKL)
	{
	}

	void IProximity.UpdateByProximity(int JIIGOACEIKL)
	{
		//ILSpy generated this explicit interface implementation from .override directive in KIOKKIEPNEO
		this.KIOKKIEPNEO(JIIGOACEIKL);
	}
}
