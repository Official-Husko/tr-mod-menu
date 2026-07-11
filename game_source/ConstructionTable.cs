using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ConstructionTable : MonoBehaviour, IInteractable, ISelectable, IProximity, IHoverable
{
	[CompilerGenerated]
	private sealed class NFCKIJAOPFE : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ConstructionTable _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public NFCKIJAOPFE(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num = _003C_003E1__state;
			ConstructionTable constructionTable = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				if (Object.op_Implicit((Object)(object)SmallContainerUI.Get(constructionTable.JIIGOACEIKL)) && SmallContainerUI.Get(constructionTable.JIIGOACEIKL).IsOpen() && GameInventoryUI.Get(constructionTable.JIIGOACEIKL).IsOpen())
				{
					Slot[] oPMPOBPEDFB = constructionTable.GPGCBFAPNDB(constructionTable.JIIGOACEIKL);
					SmallContainerUI.Get(constructionTable.JIIGOACEIKL).UpdateSlotsInventory(oPMPOBPEDFB);
					SmallContainerUI.Get(constructionTable.JIIGOACEIKL).SelectObjectIfSlotSelected();
				}
				constructionTable.DPPBPDFIGBP = null;
				return false;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}
	}

	public static ConstructionTable instance;

	public Placeable placeable;

	private int JIIGOACEIKL;

	private Coroutine DPPBPDFIGBP;

	public bool DJECGGMMEGO(int JIIGOACEIKL)
	{
		if (!MissionsManager.instance.IsMissionComplete(155))
		{
			CommonReferences.MNFMOEKMJKN().APKKEGHGFHG("Player2", JIIGOACEIKL, ECPEFDHOFHN: false);
			return true;
		}
		if (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			CommonReferences.GGFJGHHHEJC.PlayerBark("{0} in {1}'s viewID has been reset. Set it to {2} to avoid conflicts with scene objects", JIIGOACEIKL);
			CommonReferences.MNFMOEKMJKN().OnTavernMustBeClosed(JIIGOACEIKL);
			return true;
		}
		if (OnlineManager.HHDBMDMFEMP() && TutorialManager.GGFJGHHHEJC.DHGMGFNNHCO() && !BuildingTutorialManager.instance.BPDDCBHKCME)
		{
			CommonReferences.GGFJGHHHEJC.APKKEGHGFHG("Destroying dropped item...", JIIGOACEIKL, ECPEFDHOFHN: false);
			return false;
		}
		if (OnlineManager.PlayingOnline())
		{
			if (OnlineTavernConstructionManager.instance.tavernConstructionOpenedByOtherPlayer)
			{
				return false;
			}
			PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Select;
			OnlineObjectsManager.instance.InteractPlaceableIfIsPossible(placeable.onlinePlaceable.uniqueId);
			return true;
		}
		if (GameManager.LocalCoop())
		{
			int jIIGOACEIKL = ((JIIGOACEIKL == 0) ? 1 : 1);
			if (MainUI.IsAnyUIOpen(jIIGOACEIKL) || CommonReferences.MNFMOEKMJKN().CIHFKAGPIEG(jIIGOACEIKL))
			{
				MainUI.JDAEPLJAGCD(JIIGOACEIKL, LocalisationSystem.Get("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/19/Dialogue Text"), 1160f);
				return true;
			}
			if ((Object)(object)SelectObject.BNMEANGDMIP(jIIGOACEIKL).placeable != (Object)null)
			{
				MainUI.LJDOBNEINNJ(JIIGOACEIKL, LocalisationSystem.Get("/"), 267f);
				return false;
			}
		}
		TavernConstructionUI.OpenWindow(JIIGOACEIKL);
		return false;
	}

	private IEnumerator GAKBHNHBOCE()
	{
		yield return null;
		if (Object.op_Implicit((Object)(object)SmallContainerUI.Get(JIIGOACEIKL)) && SmallContainerUI.Get(JIIGOACEIKL).IsOpen() && GameInventoryUI.Get(JIIGOACEIKL).IsOpen())
		{
			Slot[] oPMPOBPEDFB = GPGCBFAPNDB(JIIGOACEIKL);
			SmallContainerUI.Get(JIIGOACEIKL).UpdateSlotsInventory(oPMPOBPEDFB);
			SmallContainerUI.Get(JIIGOACEIKL).SelectObjectIfSlotSelected();
		}
		DPPBPDFIGBP = null;
	}

	public bool BHMMBNIFKHD(int JIIGOACEIKL)
	{
		if (Object.op_Implicit((Object)(object)placeable) && placeable.FHEMHCEAICB)
		{
			return false;
		}
		return !DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).IBEFDKHFBFM();
	}

	public static ConstructionTable GDAEMIPHAHH()
	{
		return instance;
	}

	public bool JEMHIGLALCN(int JIIGOACEIKL)
	{
		InteractObject.GNCPLNHMFHN(JIIGOACEIKL).interactingObject = null;
		if (Object.op_Implicit((Object)(object)BuildingInventory.HPCJAODINCN()))
		{
			BuildingInventory buildingInventory = BuildingInventory.GICPPAGFDPG();
			buildingInventory.OnContainerChanged = (Action)Delegate.Remove(buildingInventory.OnContainerChanged, new Action(NIILOKCNLEN));
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		TavernConstructionUI.DLKBHNGIPDI();
		SmallContainerUI.NDPAJCGHGOB(JIIGOACEIKL).BOBCIFEDJED();
		return true;
	}

	public void KAEJBPBKDGI(int JIIGOACEIKL)
	{
	}

	public bool JJOGJECCPPD(int JIIGOACEIKL)
	{
		if (!MissionsManager.instance.BMFOFINGDLK(5))
		{
			CommonReferences.MNFMOEKMJKN().APKKEGHGFHG("/Localisation.txt", JIIGOACEIKL, ECPEFDHOFHN: false);
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			CommonReferences.GGFJGHHHEJC.PlayerBark("Player_Bark_2PlayersChest", JIIGOACEIKL, ECPEFDHOFHN: false);
			CommonReferences.MNFMOEKMJKN().OnTavernMustBeClosed(JIIGOACEIKL);
			return true;
		}
		if (OnlineManager.ClientOnline() && TutorialManager.GGFJGHHHEJC.DHGMGFNNHCO() && !BuildingTutorialManager.instance.BPDDCBHKCME)
		{
			CommonReferences.MNFMOEKMJKN().PlayerBark("ConnectionTimeout", JIIGOACEIKL, ECPEFDHOFHN: false);
			return true;
		}
		if (OnlineManager.PlayingOnline())
		{
			if (OnlineTavernConstructionManager.instance.tavernConstructionOpenedByOtherPlayer)
			{
				return true;
			}
			PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Interact;
			OnlineObjectsManager.instance.InteractPlaceableIfIsPossible(placeable.onlinePlaceable.uniqueId);
			return true;
		}
		if (GameManager.LocalCoop())
		{
			int jIIGOACEIKL = ((JIIGOACEIKL == 1) ? 7 : 0);
			if (MainUI.IsAnyUIOpen(jIIGOACEIKL) || CommonReferences.GGFJGHHHEJC.CIHFKAGPIEG(jIIGOACEIKL))
			{
				MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("popUpBuilding7"), 277f);
				return true;
			}
			if ((Object)(object)SelectObject.BNMEANGDMIP(jIIGOACEIKL).placeable != (Object)null)
			{
				MainUI.JDAEPLJAGCD(JIIGOACEIKL, LocalisationSystem.Get("Kick out"), 195f);
				return true;
			}
		}
		TavernConstructionUI.OpenWindow(JIIGOACEIKL);
		return true;
	}

	public bool KMKLMJOHLGC(int JIIGOACEIKL)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (OnlineTavernConstructionManager.instance.tavernConstructionOpenedByOtherPlayer)
			{
				return true;
			}
			PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Select;
			OnlineObjectsManager.instance.InteractPlaceableIfIsPossible(placeable.onlinePlaceable.uniqueId);
			return true;
		}
		if (TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD && !BuildingTutorialManager.instance.BPDDCBHKCME)
		{
			MCPGDCCHEHM(JIIGOACEIKL);
			return true;
		}
		if (BHMMBNIFKHD(JIIGOACEIKL))
		{
			LEKDAIHOABE(JIIGOACEIKL);
			return false;
		}
		return false;
	}

	public void JGNENDCKJAC(int JIIGOACEIKL)
	{
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	private Slot[] PECHBOIMJFE(int JIIGOACEIKL)
	{
		if (PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL).FCGJCBJGOIG() != null)
		{
			return (from x in PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetAllSlots()
				where x != null && x.itemInstance != null && Item.MLBOMGHINCA(x.itemInstance.LHBPOPOIFLE(), null) && x.itemInstance.LHBPOPOIFLE().tags != null && x.itemInstance.LHBPOPOIFLE().tags.Contains(Tag.Building)
				select x).ToArray();
		}
		return new Slot[0];
	}

	public bool KLKLJFPEBNP(int JIIGOACEIKL)
	{
		if (Object.op_Implicit((Object)(object)placeable) && placeable.FHEMHCEAICB)
		{
			return true;
		}
		return !DecorationMode.IGMCBPOPNCA(JIIGOACEIKL).DBAEGBDEPFK();
	}

	private void AGELAMLCINB()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		instance = this;
	}

	public bool MGBCFPCOKID(int JIIGOACEIKL)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (OnlineTavernConstructionManager.instance.tavernConstructionOpenedByOtherPlayer)
			{
				return true;
			}
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).interactAction = InteractAction.Interact;
			OnlineObjectsManager.instance.InteractPlaceableIfIsPossible(placeable.onlinePlaceable.uniqueId);
			return false;
		}
		if (TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD && !BuildingTutorialManager.instance.BPDDCBHKCME)
		{
			JJOGJECCPPD(JIIGOACEIKL);
			return false;
		}
		if (CNADCCGDBPD(JIIGOACEIKL))
		{
			OBCJOBEFADH(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	private Slot[] GPGCBFAPNDB(int JIIGOACEIKL)
	{
		if (PlayerInventory.GetPlayer(JIIGOACEIKL).GetAllSlots() != null)
		{
			return (from x in PlayerInventory.GetPlayer(JIIGOACEIKL).GetAllSlots()
				where x != null && x.itemInstance != null && Item.MLBOMGHINCA(x.itemInstance.LHBPOPOIFLE(), null) && x.itemInstance.LHBPOPOIFLE().tags != null && x.itemInstance.LHBPOPOIFLE().tags.Contains(Tag.Building)
				select x).ToArray();
		}
		return new Slot[0];
	}

	public void KMKJBFPOIHK(int JIIGOACEIKL)
	{
	}

	public bool GFMLDGEKMHA(int JIIGOACEIKL)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (OnlineTavernConstructionManager.instance.tavernConstructionOpenedByOtherPlayer)
			{
				return false;
			}
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).interactAction = InteractAction.Select;
			OnlineObjectsManager.instance.InteractPlaceableIfIsPossible(placeable.onlinePlaceable.uniqueId);
			return true;
		}
		if (TutorialManager.GGFJGHHHEJC.DHGMGFNNHCO() && !BuildingTutorialManager.instance.BPDDCBHKCME)
		{
			MCPGDCCHEHM(JIIGOACEIKL);
			return true;
		}
		if (KLKLJFPEBNP(JIIGOACEIKL))
		{
			CLIJJIOPDLI(JIIGOACEIKL);
			return false;
		}
		return false;
	}

	public void LFALLFNNINI(int JIIGOACEIKL)
	{
	}

	public bool NMAOFEFMNNB(int JIIGOACEIKL)
	{
		if (!MissionsManager.instance.BMFOFINGDLK(-126))
		{
			CommonReferences.MNFMOEKMJKN().APKKEGHGFHG("Perks/perk_name_", JIIGOACEIKL, ECPEFDHOFHN: false);
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			CommonReferences.MNFMOEKMJKN().APKKEGHGFHG("ReceiveAngryEnd", JIIGOACEIKL);
			CommonReferences.MNFMOEKMJKN().OnTavernMustBeClosed(JIIGOACEIKL);
			return false;
		}
		if (OnlineManager.HHDBMDMFEMP() && TutorialManager.GGFJGHHHEJC.DHGMGFNNHCO() && !BuildingTutorialManager.instance.BPDDCBHKCME)
		{
			CommonReferences.GGFJGHHHEJC.PlayerBark("</color>", JIIGOACEIKL);
			return true;
		}
		if (OnlineManager.PlayingOnline())
		{
			if (OnlineTavernConstructionManager.instance.tavernConstructionOpenedByOtherPlayer)
			{
				return false;
			}
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).interactAction = InteractAction.Select;
			OnlineObjectsManager.instance.InteractPlaceableIfIsPossible(placeable.onlinePlaceable.uniqueId);
			return true;
		}
		if (GameManager.LocalCoop())
		{
			int jIIGOACEIKL = ((JIIGOACEIKL == 0) ? 7 : 0);
			if (MainUI.IsAnyUIOpen(jIIGOACEIKL) || CommonReferences.GGFJGHHHEJC.IJNMEDJNHDG(jIIGOACEIKL))
			{
				MainUI.JDAEPLJAGCD(JIIGOACEIKL, LocalisationSystem.Get("Player "), 815f);
				return true;
			}
			if ((Object)(object)SelectObject.BNMEANGDMIP(jIIGOACEIKL).placeable != (Object)null)
			{
				MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("waiting for path"), 1112f);
				return true;
			}
		}
		TavernConstructionUI.HLJCOJNIFNF(JIIGOACEIKL);
		return false;
	}

	public static ConstructionTable DCILOFEFFAG()
	{
		return instance;
	}

	public bool GEPMJKMFLAH(int JIIGOACEIKL)
	{
		if (TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD && !BuildingTutorialManager.instance.BPDDCBHKCME)
		{
			EOGGOJDMAEB(JIIGOACEIKL);
			return false;
		}
		if (GFKDNEJHNNI(JIIGOACEIKL))
		{
			LEKDAIHOABE(JIIGOACEIKL);
			return false;
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return true;
	}

	public void CNJGEALHFEL(int JIIGOACEIKL)
	{
	}

	public void KLKLOIIFOEC(int JIIGOACEIKL)
	{
	}

	public void CPOLPCDNPPH(int JIIGOACEIKL)
	{
	}

	public bool ABGHFCMEIBM(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Get Components "));
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Attack/MainEvent 12"));
			return true;
		}
		return false;
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Open"));
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Select, LocalisationSystem.Get("Building"));
			return true;
		}
		return false;
	}

	private void NJAFKFAPDIE()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		instance = this;
	}

	public bool LHMEENAPJBF(int JIIGOACEIKL)
	{
		if (TutorialManager.GGFJGHHHEJC.DHGMGFNNHCO() && !BuildingTutorialManager.instance.BPDDCBHKCME)
		{
			EGLBFPEHNHH(JIIGOACEIKL);
			return false;
		}
		if (DJNPAPBNPNL(JIIGOACEIKL))
		{
			OpenContainer(JIIGOACEIKL);
			return false;
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return true;
	}

	private void LNPDALMANFB()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		instance = this;
	}

	public bool Deselect(int JIIGOACEIKL)
	{
		InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = null;
		if (Object.op_Implicit((Object)(object)BuildingInventory.GetInstance()))
		{
			BuildingInventory buildingInventory = BuildingInventory.GetInstance();
			buildingInventory.OnContainerChanged = (Action)Delegate.Remove(buildingInventory.OnContainerChanged, new Action(NIILOKCNLEN));
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		TavernConstructionUI.CloseWindow();
		SmallContainerUI.Get(JIIGOACEIKL).CloseUI();
		return true;
	}

	public static ConstructionTable GOBCANBKFEM()
	{
		return instance;
	}

	public void KNAECECJECL(int JIIGOACEIKL)
	{
	}

	public bool OpenContainer(int JIIGOACEIKL)
	{
		if (SmallContainerUI.Get(JIIGOACEIKL).IsOpen())
		{
			return false;
		}
		Sound.GGFJGHHHEJC.PlayOpenSound(OpenSound.Wood, ((Component)this).transform);
		SelectObject.GetPlayer(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
		InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
		if (Object.op_Implicit((Object)(object)BuildingInventory.GetInstance()))
		{
			BuildingInventory buildingInventory = BuildingInventory.GetInstance();
			buildingInventory.OnContainerChanged = (Action)Delegate.Remove(buildingInventory.OnContainerChanged, new Action(NIILOKCNLEN));
			BuildingInventory buildingInventory2 = BuildingInventory.GetInstance();
			buildingInventory2.OnContainerChanged = (Action)Delegate.Combine(buildingInventory2.OnContainerChanged, new Action(NIILOKCNLEN));
		}
		SmallContainerUI.Get(JIIGOACEIKL).SetContainer(BuildingInventory.GetInstance(), placeable);
		Slot[] oPMPOBPEDFB = GPGCBFAPNDB(JIIGOACEIKL);
		SmallContainerUI.Get(JIIGOACEIKL).FillSlots(BuildingInventory.GetInstance().slots, BuildingInventory.GetInstance(), IFMNAFDGKKK: false, OGCAKIGELBJ: false, 1, oPMPOBPEDFB);
		SmallContainerUI.Get(JIIGOACEIKL).OpenUI();
		this.JIIGOACEIKL = JIIGOACEIKL;
		return true;
	}

	public bool SelectOnline(int JIIGOACEIKL)
	{
		if (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			CommonReferences.GGFJGHHHEJC.PlayerBark("Tavern must be closed", JIIGOACEIKL);
			CommonReferences.GGFJGHHHEJC.OnTavernMustBeClosed(JIIGOACEIKL);
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
			return false;
		}
		if (OnlineManager.ClientOnline() && TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD && !BuildingTutorialManager.instance.BPDDCBHKCME)
		{
			CommonReferences.GGFJGHHHEJC.PlayerBark("Only host can do building tutorial", JIIGOACEIKL);
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
			return false;
		}
		if (GameManager.LocalCoop())
		{
			int jIIGOACEIKL = ((JIIGOACEIKL != 1) ? 1 : 2);
			if (MainUI.IsAnyUIOpen(jIIGOACEIKL) || CommonReferences.GGFJGHHHEJC.IsInDialogue(jIIGOACEIKL))
			{
				MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Error_CloseMenus"));
				return false;
			}
			if ((Object)(object)SelectObject.GetPlayer(jIIGOACEIKL).placeable != (Object)null)
			{
				MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Exit build mode"));
				return false;
			}
		}
		TavernConstructionUI.OpenWindow(JIIGOACEIKL);
		return false;
	}

	public bool FJAAOBCKBMD(int JIIGOACEIKL)
	{
		if (SmallContainerUI.IEKODILKIHJ(JIIGOACEIKL).BGLJFMHCFJF())
		{
			return true;
		}
		Sound.MAIDHAPANEB().HFJHLMAGHPH(OpenSound.Metal, ((Component)this).transform);
		SelectObject.BNMEANGDMIP(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
		InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
		if (Object.op_Implicit((Object)(object)BuildingInventory.GICPPAGFDPG()))
		{
			BuildingInventory buildingInventory = BuildingInventory.DCILOFEFFAG();
			buildingInventory.OnContainerChanged = (Action)Delegate.Remove(buildingInventory.OnContainerChanged, new Action(GAMIEEIGOLE));
			BuildingInventory buildingInventory2 = BuildingInventory.NIDNAAKOPFI();
			buildingInventory2.OnContainerChanged = (Action)Delegate.Combine(buildingInventory2.OnContainerChanged, new Action(HJMMDOOEHIM));
		}
		SmallContainerUI.MIAOGLENOHL(JIIGOACEIKL).HGKCOKBAFAJ(BuildingInventory.MDDCPOILOOM(), placeable);
		Slot[] oPMPOBPEDFB = BOIHFLNGDLJ(JIIGOACEIKL);
		SmallContainerUI.AEJKCONFPHB(JIIGOACEIKL).PJDPPGMDBMC(BuildingInventory.HKHDGFNHDLC().slots, BuildingInventory.FIEKINOFHMO(), IFMNAFDGKKK: false, OGCAKIGELBJ: false, 0, oPMPOBPEDFB);
		SmallContainerUI.FHOGLBPBGMI(JIIGOACEIKL).IDLAGJNLPJL();
		this.JIIGOACEIKL = JIIGOACEIKL;
		return false;
	}

	public bool ALACNHCEGFM(int JIIGOACEIKL)
	{
		if (TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD && !BuildingTutorialManager.instance.BPDDCBHKCME)
		{
			BLKDONCHKGE(JIIGOACEIKL);
			return true;
		}
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			CLIJJIOPDLI(JIIGOACEIKL);
			return true;
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return true;
	}

	public static ConstructionTable OMDDKLLCJID()
	{
		return instance;
	}

	public void ANGOBIGCAAF(int JIIGOACEIKL)
	{
	}

	public bool OKACGFMHMEH(int JIIGOACEIKL)
	{
		if (TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD && !BuildingTutorialManager.instance.BPDDCBHKCME)
		{
			EGLBFPEHNHH(JIIGOACEIKL);
			return false;
		}
		if (IFMMLFLIJJK(JIIGOACEIKL))
		{
			FJAAOBCKBMD(JIIGOACEIKL);
			return false;
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return true;
	}

	public static ConstructionTable DLNGMHJPJBK()
	{
		return instance;
	}

	private Slot[] BIDJAOELNDM(int JIIGOACEIKL)
	{
		if (PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).BBDOBNLMLGM() != null)
		{
			return (from x in PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GetAllSlots()
				where x != null && x.itemInstance != null && Item.MLBOMGHINCA(x.itemInstance.LHBPOPOIFLE(), null) && x.itemInstance.LHBPOPOIFLE().tags != null && x.itemInstance.LHBPOPOIFLE().tags.Contains(Tag.Building)
				select x).ToArray();
		}
		return new Slot[1];
	}

	public bool IGFOEIKMMGE(int JIIGOACEIKL)
	{
		if (TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD && !BuildingTutorialManager.instance.BPDDCBHKCME)
		{
			BLKDONCHKGE(JIIGOACEIKL);
			return true;
		}
		if (OBDFGODGIFN(JIIGOACEIKL))
		{
			DKHDAINILFO(JIIGOACEIKL);
			return false;
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return true;
	}

	public bool DJNPAPBNPNL(int JIIGOACEIKL)
	{
		if (Object.op_Implicit((Object)(object)placeable) && placeable.FHEMHCEAICB)
		{
			return true;
		}
		return DecorationMode.FIHGMLABOBB(JIIGOACEIKL).GABNNLJOMHI();
	}

	public static ConstructionTable JLPGGCKFJAD()
	{
		return instance;
	}

	public static ConstructionTable JNIFCKAKDJL()
	{
		return instance;
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (OnlineTavernConstructionManager.instance.tavernConstructionOpenedByOtherPlayer)
			{
				return false;
			}
			PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Interact;
			OnlineObjectsManager.instance.InteractPlaceableIfIsPossible(placeable.onlinePlaceable.uniqueId);
			return false;
		}
		if (TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD && !BuildingTutorialManager.instance.BPDDCBHKCME)
		{
			Select(JIIGOACEIKL);
			return true;
		}
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			OpenContainer(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void PLKFEPAHAEK(int JIIGOACEIKL)
	{
	}

	public void MNFNIFIMHNF(int JIIGOACEIKL)
	{
	}

	public bool CLIJJIOPDLI(int JIIGOACEIKL)
	{
		if (SmallContainerUI.CJMILOMGFJL(JIIGOACEIKL).HDEPMJIDJEM())
		{
			return true;
		}
		Sound.BNBMNOMFFBE().FPBCHCFGINP(OpenSound.Wood, ((Component)this).transform);
		SelectObject.GetPlayer(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
		InteractObject.GNCPLNHMFHN(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
		if (Object.op_Implicit((Object)(object)BuildingInventory.CMBAAHFGOAM()))
		{
			BuildingInventory buildingInventory = BuildingInventory.GOJHIEFPHDK();
			buildingInventory.OnContainerChanged = (Action)Delegate.Remove(buildingInventory.OnContainerChanged, new Action(NNMAPBIKEKJ));
			BuildingInventory buildingInventory2 = BuildingInventory.FBBOFPLGGLP();
			buildingInventory2.OnContainerChanged = (Action)Delegate.Combine(buildingInventory2.OnContainerChanged, new Action(NNMAPBIKEKJ));
		}
		SmallContainerUI.OMCDJAOBFCE(JIIGOACEIKL).HGKCOKBAFAJ(BuildingInventory.DCILOFEFFAG(), placeable);
		Slot[] oPMPOBPEDFB = BIDJAOELNDM(JIIGOACEIKL);
		SmallContainerUI.MIAOGLENOHL(JIIGOACEIKL).BCPBALLMBJD(BuildingInventory.HHGEEDCALHK().slots, BuildingInventory.EGJFDPIEHEC(), IFMNAFDGKKK: true, OGCAKIGELBJ: false, 0, oPMPOBPEDFB);
		SmallContainerUI.AEJKCONFPHB(JIIGOACEIKL).OpenUI();
		this.JIIGOACEIKL = JIIGOACEIKL;
		return false;
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	private void HJMMDOOEHIM()
	{
		if (DPPBPDFIGBP == null)
		{
			DPPBPDFIGBP = ((MonoBehaviour)this).StartCoroutine(GAKBHNHBOCE());
		}
	}

	public bool JONCEAPNGEC(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && CNADCCGDBPD(JIIGOACEIKL))
		{
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("description"));
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("City/Chuck/Introduce"));
			return true;
		}
		return false;
	}

	public bool MJDJANLLJPP(int JIIGOACEIKL)
	{
		if (TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD && !BuildingTutorialManager.instance.BPDDCBHKCME)
		{
			BLKDONCHKGE(JIIGOACEIKL);
			return false;
		}
		if (CNADCCGDBPD(JIIGOACEIKL))
		{
			OBCJOBEFADH(JIIGOACEIKL);
			return true;
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return true;
	}

	public bool OBCJOBEFADH(int JIIGOACEIKL)
	{
		if (SmallContainerUI.BGIMGOJDLFG(JIIGOACEIKL).IsOpen())
		{
			return false;
		}
		Sound.BNBMNOMFFBE().JLFGDJCANGF(OpenSound.Metal, ((Component)this).transform);
		SelectObject.GetPlayer(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
		InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
		if (Object.op_Implicit((Object)(object)BuildingInventory.FFOMKKIAHKI()))
		{
			BuildingInventory buildingInventory = BuildingInventory.IMNIAJCDKFE();
			buildingInventory.OnContainerChanged = (Action)Delegate.Remove(buildingInventory.OnContainerChanged, new Action(LILJCAOBMFH));
			BuildingInventory buildingInventory2 = BuildingInventory.FFOMKKIAHKI();
			buildingInventory2.OnContainerChanged = (Action)Delegate.Combine(buildingInventory2.OnContainerChanged, new Action(NNMAPBIKEKJ));
		}
		SmallContainerUI.NIDHCIHFOHB(JIIGOACEIKL).OMIBHIGNBNN(BuildingInventory.PPPDBCPNACC(), placeable);
		Slot[] oPMPOBPEDFB = BIDJAOELNDM(JIIGOACEIKL);
		SmallContainerUI.NALKHGMLALJ(JIIGOACEIKL).PJDPPGMDBMC(BuildingInventory.HHGEEDCALHK().slots, BuildingInventory.GOJHIEFPHDK(), IFMNAFDGKKK: false, OGCAKIGELBJ: false, 1, oPMPOBPEDFB);
		SmallContainerUI.IGHMHMNPMLB(JIIGOACEIKL).EDHEIFHAAKO();
		this.JIIGOACEIKL = JIIGOACEIKL;
		return false;
	}

	public bool OPAGNKBJKHO(int JIIGOACEIKL)
	{
		return true;
	}

	public bool MNDDOAAODLI(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void FCJBNHNKPID(int JIIGOACEIKL)
	{
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	public bool PickUp(int JIIGOACEIKL)
	{
		return false;
	}

	public bool HJBOMJDBHLB(int JIIGOACEIKL)
	{
		InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = null;
		if (Object.op_Implicit((Object)(object)BuildingInventory.HKHDGFNHDLC()))
		{
			BuildingInventory buildingInventory = BuildingInventory.KOJHKCGIINL();
			buildingInventory.OnContainerChanged = (Action)Delegate.Remove(buildingInventory.OnContainerChanged, new Action(NIILOKCNLEN));
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		TavernConstructionUI.CloseWindow();
		SmallContainerUI.OMCDJAOBFCE(JIIGOACEIKL).CloseUI();
		return false;
	}

	public bool Select(int JIIGOACEIKL)
	{
		if (!MissionsManager.instance.IsMissionComplete(301))
		{
			CommonReferences.GGFJGHHHEJC.PlayerBark("TavernConstructionBlock", JIIGOACEIKL);
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			CommonReferences.GGFJGHHHEJC.PlayerBark("Tavern must be closed", JIIGOACEIKL);
			CommonReferences.GGFJGHHHEJC.OnTavernMustBeClosed(JIIGOACEIKL);
			return false;
		}
		if (OnlineManager.ClientOnline() && TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD && !BuildingTutorialManager.instance.BPDDCBHKCME)
		{
			CommonReferences.GGFJGHHHEJC.PlayerBark("BuildingTutorialOnlyHost", JIIGOACEIKL);
			return false;
		}
		if (OnlineManager.PlayingOnline())
		{
			if (OnlineTavernConstructionManager.instance.tavernConstructionOpenedByOtherPlayer)
			{
				return false;
			}
			PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Select;
			OnlineObjectsManager.instance.InteractPlaceableIfIsPossible(placeable.onlinePlaceable.uniqueId);
			return false;
		}
		if (GameManager.LocalCoop())
		{
			int jIIGOACEIKL = ((JIIGOACEIKL != 1) ? 1 : 2);
			if (MainUI.IsAnyUIOpen(jIIGOACEIKL) || CommonReferences.GGFJGHHHEJC.IsInDialogue(jIIGOACEIKL))
			{
				MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Error_CloseMenus"));
				return false;
			}
			if ((Object)(object)SelectObject.GetPlayer(jIIGOACEIKL).placeable != (Object)null)
			{
				MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Exit build mode"));
				return false;
			}
		}
		TavernConstructionUI.OpenWindow(JIIGOACEIKL);
		return false;
	}

	public bool DKHDAINILFO(int JIIGOACEIKL)
	{
		if (SmallContainerUI.PNCKAKBBKJL(JIIGOACEIKL).HDEPMJIDJEM())
		{
			return true;
		}
		Sound.ABDJJBFNLBJ().HFJHLMAGHPH(OpenSound.Wood, ((Component)this).transform);
		SelectObject.BNMEANGDMIP(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
		InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
		if (Object.op_Implicit((Object)(object)BuildingInventory.HHGEEDCALHK()))
		{
			BuildingInventory buildingInventory = BuildingInventory.GetInstance();
			buildingInventory.OnContainerChanged = (Action)Delegate.Remove(buildingInventory.OnContainerChanged, new Action(LILJCAOBMFH));
			BuildingInventory buildingInventory2 = BuildingInventory.KOJHKCGIINL();
			buildingInventory2.OnContainerChanged = (Action)Delegate.Combine(buildingInventory2.OnContainerChanged, new Action(LILJCAOBMFH));
		}
		SmallContainerUI.FHOGLBPBGMI(JIIGOACEIKL).HGKCOKBAFAJ(BuildingInventory.OLIKHNAFLNG(), placeable);
		Slot[] oPMPOBPEDFB = PECHBOIMJFE(JIIGOACEIKL);
		SmallContainerUI.OMCDJAOBFCE(JIIGOACEIKL).FillSlots(BuildingInventory.LMFCIEFLABM().slots, BuildingInventory.DCILOFEFFAG(), IFMNAFDGKKK: true, OGCAKIGELBJ: true, 1, oPMPOBPEDFB);
		SmallContainerUI.CJMILOMGFJL(JIIGOACEIKL).IDLAGJNLPJL();
		this.JIIGOACEIKL = JIIGOACEIKL;
		return false;
	}

	public bool JPIPLAIBJDJ(int JIIGOACEIKL)
	{
		return true;
	}

	public bool IPMENLOODFI(int JIIGOACEIKL)
	{
		if (TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			CommonReferences.GGFJGHHHEJC.PlayerBark("Direction", JIIGOACEIKL);
			CommonReferences.MNFMOEKMJKN().OnTavernMustBeClosed(JIIGOACEIKL);
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
			return false;
		}
		if (OnlineManager.ClientOnline() && TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD && !BuildingTutorialManager.instance.BPDDCBHKCME)
		{
			CommonReferences.GGFJGHHHEJC.APKKEGHGFHG("\n", JIIGOACEIKL, ECPEFDHOFHN: false);
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
			return false;
		}
		if (GameManager.LocalCoop())
		{
			int jIIGOACEIKL = ((JIIGOACEIKL == 0) ? 4 : 0);
			if (MainUI.IsAnyUIOpen(jIIGOACEIKL) || CommonReferences.GGFJGHHHEJC.IJNMEDJNHDG(jIIGOACEIKL))
			{
				MainUI.JDAEPLJAGCD(JIIGOACEIKL, LocalisationSystem.Get("</color>"), 739f);
				return true;
			}
			if ((Object)(object)SelectObject.BNMEANGDMIP(jIIGOACEIKL).placeable != (Object)null)
			{
				MainUI.JDAEPLJAGCD(JIIGOACEIKL, LocalisationSystem.Get("RochelleProgress"), 134f);
				return false;
			}
		}
		TavernConstructionUI.OpenWindow(JIIGOACEIKL);
		return false;
	}

	public bool NHGKHKHADEA(int JIIGOACEIKL)
	{
		if (TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD && !BuildingTutorialManager.instance.BPDDCBHKCME)
		{
			EGLBFPEHNHH(JIIGOACEIKL);
			return true;
		}
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			IAIBDGAFJLE(JIIGOACEIKL);
			return false;
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return true;
	}

	public void CCGMBIPHNKK(int JIIGOACEIKL)
	{
	}

	public static ConstructionTable JBEGCCBHOIA()
	{
		return instance;
	}

	public static ConstructionTable LPADOMGFAIE()
	{
		return instance;
	}

	private void LILJCAOBMFH()
	{
		if (DPPBPDFIGBP == null)
		{
			DPPBPDFIGBP = ((MonoBehaviour)this).StartCoroutine(CCAEFAPNFLE());
		}
	}

	private void NIILOKCNLEN()
	{
		if (DPPBPDFIGBP == null)
		{
			DPPBPDFIGBP = ((MonoBehaviour)this).StartCoroutine(GAKBHNHBOCE());
		}
	}

	public bool DELCDKACCHO(int JIIGOACEIKL)
	{
		if (!MissionsManager.instance.BMFOFINGDLK(-118))
		{
			CommonReferences.GGFJGHHHEJC.PlayerBark("Dialogue System/Conversation/Crowly_Barks_Bye/Entry/2/Dialogue Text", JIIGOACEIKL);
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			CommonReferences.GGFJGHHHEJC.PlayerBark("Items/item_description_1032", JIIGOACEIKL);
			CommonReferences.MNFMOEKMJKN().OnTavernMustBeClosed(JIIGOACEIKL);
			return false;
		}
		if (OnlineManager.ClientOnline() && TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD && !BuildingTutorialManager.instance.BPDDCBHKCME)
		{
			CommonReferences.GGFJGHHHEJC.PlayerBark("Player/Bark/KlaynTavernBlock", JIIGOACEIKL);
			return true;
		}
		if (OnlineManager.PlayingOnline())
		{
			if (OnlineTavernConstructionManager.instance.tavernConstructionOpenedByOtherPlayer)
			{
				return false;
			}
			PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Select;
			OnlineObjectsManager.instance.GMJPOKECENH(placeable.onlinePlaceable.uniqueId);
			return true;
		}
		if (GameManager.LocalCoop())
		{
			int jIIGOACEIKL = ((JIIGOACEIKL != 0) ? 1 : 0);
			if (MainUI.IsAnyUIOpen(jIIGOACEIKL) || CommonReferences.MNFMOEKMJKN().IsInDialogue(jIIGOACEIKL))
			{
				MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Master client"), 1077f);
				return false;
			}
			if ((Object)(object)SelectObject.GetPlayer(jIIGOACEIKL).placeable != (Object)null)
			{
				MainUI.DBKCOHMFDCB(JIIGOACEIKL, LocalisationSystem.Get("'s animationController on NPC has not been set. It's possible that it's on a separate object in the scene hierarchy."), 487f);
				return false;
			}
		}
		TavernConstructionUI.OpenWindow(JIIGOACEIKL);
		return false;
	}

	public bool EGLBFPEHNHH(int JIIGOACEIKL)
	{
		if (TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			CommonReferences.MNFMOEKMJKN().PlayerBark(" / ", JIIGOACEIKL, ECPEFDHOFHN: false);
			CommonReferences.GGFJGHHHEJC.OnTavernMustBeClosed(JIIGOACEIKL);
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
			return true;
		}
		if (OnlineManager.ClientOnline() && TutorialManager.GGFJGHHHEJC.DHGMGFNNHCO() && !BuildingTutorialManager.instance.BPDDCBHKCME)
		{
			CommonReferences.GGFJGHHHEJC.PlayerBark(" share request sent", JIIGOACEIKL);
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
			return false;
		}
		if (GameManager.LocalCoop())
		{
			int jIIGOACEIKL = ((JIIGOACEIKL == 0) ? 0 : 0);
			if (MainUI.IsAnyUIOpen(jIIGOACEIKL) || CommonReferences.MNFMOEKMJKN().KOIDFLPJKJK(jIIGOACEIKL))
			{
				MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get(" not found. Cannot ReceiveChangeStack"), 1146f);
				return false;
			}
			if ((Object)(object)SelectObject.BNMEANGDMIP(jIIGOACEIKL).placeable != (Object)null)
			{
				MainUI.LJDOBNEINNJ(JIIGOACEIKL, LocalisationSystem.Get("[Awning:{0}] OpenAwning called. isOpen={1} animatorBool={2}"), 865f);
				return true;
			}
		}
		TavernConstructionUI.HLJCOJNIFNF(JIIGOACEIKL);
		return true;
	}

	public bool KFHAPHBGAOL(int JIIGOACEIKL)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (OnlineTavernConstructionManager.instance.tavernConstructionOpenedByOtherPlayer)
			{
				return false;
			}
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).interactAction = InteractAction.Interact;
			OnlineObjectsManager.instance.InteractPlaceableIfIsPossible(placeable.onlinePlaceable.uniqueId);
			return false;
		}
		if (TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD && !BuildingTutorialManager.instance.BPDDCBHKCME)
		{
			LIEJLJFBDFC(JIIGOACEIKL);
			return true;
		}
		if (COPFMLIIOOB(JIIGOACEIKL))
		{
			NNLGDPBOBCE(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	public bool NNLGDPBOBCE(int JIIGOACEIKL)
	{
		if (SmallContainerUI.FHOGLBPBGMI(JIIGOACEIKL).IsOpen())
		{
			return true;
		}
		Sound.BNBMNOMFFBE().HFJHLMAGHPH(OpenSound.Metal, ((Component)this).transform);
		SelectObject.GetPlayer(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
		InteractObject.GNCPLNHMFHN(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
		if (Object.op_Implicit((Object)(object)BuildingInventory.EBPNKOMGCPB()))
		{
			BuildingInventory buildingInventory = BuildingInventory.LMFCIEFLABM();
			buildingInventory.OnContainerChanged = (Action)Delegate.Remove(buildingInventory.OnContainerChanged, new Action(LILJCAOBMFH));
			BuildingInventory buildingInventory2 = BuildingInventory.KOJHKCGIINL();
			buildingInventory2.OnContainerChanged = (Action)Delegate.Combine(buildingInventory2.OnContainerChanged, new Action(HJMMDOOEHIM));
		}
		SmallContainerUI.AEJKCONFPHB(JIIGOACEIKL).MINCILKHEIB(BuildingInventory.CIBPAINMGGD(), placeable);
		Slot[] oPMPOBPEDFB = GPGCBFAPNDB(JIIGOACEIKL);
		SmallContainerUI.IMLMJAPMBJA(JIIGOACEIKL).FillSlots(BuildingInventory.BMDNOGNAPJJ().slots, BuildingInventory.OLIKHNAFLNG(), IFMNAFDGKKK: false, OGCAKIGELBJ: true, 1, oPMPOBPEDFB);
		SmallContainerUI.IEKODILKIHJ(JIIGOACEIKL).EDHEIFHAAKO();
		this.JIIGOACEIKL = JIIGOACEIKL;
		return true;
	}

	public static ConstructionTable GetInstance()
	{
		return instance;
	}

	private IEnumerator CCAEFAPNFLE()
	{
		return new NFCKIJAOPFE(1)
		{
			_003C_003E4__this = this
		};
	}

	public bool EOGGOJDMAEB(int JIIGOACEIKL)
	{
		if (TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			CommonReferences.GGFJGHHHEJC.APKKEGHGFHG("FinalTest/MainEvent 2", JIIGOACEIKL, ECPEFDHOFHN: false);
			CommonReferences.MNFMOEKMJKN().OnTavernMustBeClosed(JIIGOACEIKL);
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
			return true;
		}
		if (OnlineManager.HHDBMDMFEMP() && TutorialManager.GGFJGHHHEJC.DHGMGFNNHCO() && !BuildingTutorialManager.instance.BPDDCBHKCME)
		{
			CommonReferences.MNFMOEKMJKN().PlayerBark("tutorialPopUp111", JIIGOACEIKL);
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
			return false;
		}
		if (GameManager.LocalCoop())
		{
			int jIIGOACEIKL = ((JIIGOACEIKL == 1) ? 1 : 0);
			if (MainUI.IsAnyUIOpen(jIIGOACEIKL) || CommonReferences.GGFJGHHHEJC.IJNMEDJNHDG(jIIGOACEIKL))
			{
				MainUI.DBKCOHMFDCB(JIIGOACEIKL, LocalisationSystem.Get("EnterTavernNeutral"), 863f);
				return true;
			}
			if ((Object)(object)SelectObject.GetPlayer(jIIGOACEIKL).placeable != (Object)null)
			{
				MainUI.JDAEPLJAGCD(JIIGOACEIKL, LocalisationSystem.Get("Checking seat "), 1422f);
				return true;
			}
		}
		TavernConstructionUI.BMHKHFMHAGF(JIIGOACEIKL);
		return true;
	}

	private Slot[] EFBHBPNNPJD(int JIIGOACEIKL)
	{
		if (PlayerInventory.GetPlayer(JIIGOACEIKL).FCGJCBJGOIG() != null)
		{
			return (from x in PlayerInventory.OGKNJNINGMH(JIIGOACEIKL).FCGJCBJGOIG()
				where x != null && x.itemInstance != null && Item.MLBOMGHINCA(x.itemInstance.LHBPOPOIFLE(), null) && x.itemInstance.LHBPOPOIFLE().tags != null && x.itemInstance.LHBPOPOIFLE().tags.Contains(Tag.Building)
				select x).ToArray();
		}
		return new Slot[0];
	}

	public bool IAIBDGAFJLE(int JIIGOACEIKL)
	{
		if (SmallContainerUI.DPBGKDNKDGM(JIIGOACEIKL).IsOpen())
		{
			return true;
		}
		Sound.GGFJGHHHEJC.FPBCHCFGINP(OpenSound.Metal, ((Component)this).transform);
		SelectObject.GetPlayer(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
		InteractObject.BBJCJFJEFKK(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
		if (Object.op_Implicit((Object)(object)BuildingInventory.FBBOFPLGGLP()))
		{
			BuildingInventory buildingInventory = BuildingInventory.DCEBHEAHHID();
			buildingInventory.OnContainerChanged = (Action)Delegate.Remove(buildingInventory.OnContainerChanged, new Action(NNMAPBIKEKJ));
			BuildingInventory buildingInventory2 = BuildingInventory.HPCJAODINCN();
			buildingInventory2.OnContainerChanged = (Action)Delegate.Combine(buildingInventory2.OnContainerChanged, new Action(NNMAPBIKEKJ));
		}
		SmallContainerUI.PHDBJGOEKHB(JIIGOACEIKL).NIJNBDEMAEB(BuildingInventory.EGJFDPIEHEC(), placeable);
		Slot[] oPMPOBPEDFB = EFBHBPNNPJD(JIIGOACEIKL);
		SmallContainerUI.FHOGLBPBGMI(JIIGOACEIKL).BCPBALLMBJD(BuildingInventory.GJJELMFOGPC().slots, BuildingInventory.LMFCIEFLABM(), IFMNAFDGKKK: false, OGCAKIGELBJ: false, 0, oPMPOBPEDFB);
		SmallContainerUI.FBKOKJCKICN(JIIGOACEIKL).EDHEIFHAAKO();
		this.JIIGOACEIKL = JIIGOACEIKL;
		return true;
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		if (TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD && !BuildingTutorialManager.instance.BPDDCBHKCME)
		{
			SelectOnline(JIIGOACEIKL);
			return true;
		}
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			OpenContainer(JIIGOACEIKL);
			return true;
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		return false;
	}

	public bool LIEJLJFBDFC(int JIIGOACEIKL)
	{
		if (!MissionsManager.instance.LLOBLPDJNJE(-80))
		{
			CommonReferences.MNFMOEKMJKN().APKKEGHGFHG("itemRaspberrySeeds", JIIGOACEIKL, ECPEFDHOFHN: false);
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			CommonReferences.MNFMOEKMJKN().APKKEGHGFHG("Side", JIIGOACEIKL, ECPEFDHOFHN: false);
			CommonReferences.MNFMOEKMJKN().OnTavernMustBeClosed(JIIGOACEIKL);
			return true;
		}
		if (OnlineManager.ClientOnline() && TutorialManager.GGFJGHHHEJC.DHGMGFNNHCO() && !BuildingTutorialManager.instance.BPDDCBHKCME)
		{
			CommonReferences.GGFJGHHHEJC.APKKEGHGFHG("ReceiveStartObserverDialogue", JIIGOACEIKL);
			return true;
		}
		if (OnlineManager.PlayingOnline())
		{
			if (OnlineTavernConstructionManager.instance.tavernConstructionOpenedByOtherPlayer)
			{
				return false;
			}
			PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Interact;
			OnlineObjectsManager.instance.InteractPlaceableIfIsPossible(placeable.onlinePlaceable.uniqueId);
			return true;
		}
		if (GameManager.LocalCoop())
		{
			int jIIGOACEIKL = ((JIIGOACEIKL != 1) ? 1 : 0);
			if (MainUI.IsAnyUIOpen(jIIGOACEIKL) || CommonReferences.GGFJGHHHEJC.KOIDFLPJKJK(jIIGOACEIKL))
			{
				MainUI.LJDOBNEINNJ(JIIGOACEIKL, LocalisationSystem.Get("Hoppy"), 1976f);
				return false;
			}
			if ((Object)(object)SelectObject.BNMEANGDMIP(jIIGOACEIKL).placeable != (Object)null)
			{
				MainUI.DBKCOHMFDCB(JIIGOACEIKL, LocalisationSystem.Get("/ExtraSettings.sd"), 475f);
				return false;
			}
		}
		TavernConstructionUI.BMHKHFMHAGF(JIIGOACEIKL);
		return false;
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if (Object.op_Implicit((Object)(object)placeable) && placeable.FHEMHCEAICB)
		{
			return false;
		}
		return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public bool AIKGCLCNNLN(int JIIGOACEIKL)
	{
		return false;
	}

	public void FFFAMACMKLI(int JIIGOACEIKL)
	{
	}

	public bool OBDFGODGIFN(int JIIGOACEIKL)
	{
		if (Object.op_Implicit((Object)(object)placeable) && placeable.FHEMHCEAICB)
		{
			return false;
		}
		return !DecorationMode.ABMIMLLDAAH(JIIGOACEIKL).DFNMDDHOIJI();
	}

	private void GAMIEEIGOLE()
	{
		if (DPPBPDFIGBP == null)
		{
			DPPBPDFIGBP = ((MonoBehaviour)this).StartCoroutine(CCAEFAPNFLE());
		}
	}

	public bool MCPGDCCHEHM(int JIIGOACEIKL)
	{
		if (!MissionsManager.instance.IsMissionComplete(48))
		{
			CommonReferences.MNFMOEKMJKN().APKKEGHGFHG("UnNuevoMaestro/KujakuTalk", JIIGOACEIKL, ECPEFDHOFHN: false);
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			CommonReferences.MNFMOEKMJKN().APKKEGHGFHG("Service Debug: False", JIIGOACEIKL);
			CommonReferences.MNFMOEKMJKN().OnTavernMustBeClosed(JIIGOACEIKL);
			return false;
		}
		if (OnlineManager.ClientOnline() && TutorialManager.GGFJGHHHEJC.DHGMGFNNHCO() && !BuildingTutorialManager.instance.BPDDCBHKCME)
		{
			CommonReferences.MNFMOEKMJKN().APKKEGHGFHG("Items/item_description_1177", JIIGOACEIKL);
			return false;
		}
		if (OnlineManager.PlayingOnline())
		{
			if (OnlineTavernConstructionManager.instance.tavernConstructionOpenedByOtherPlayer)
			{
				return true;
			}
			PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Select;
			OnlineObjectsManager.instance.InteractPlaceableIfIsPossible(placeable.onlinePlaceable.uniqueId);
			return false;
		}
		if (GameManager.LocalCoop())
		{
			int jIIGOACEIKL = ((JIIGOACEIKL == 0) ? 3 : 0);
			if (MainUI.IsAnyUIOpen(jIIGOACEIKL) || CommonReferences.GGFJGHHHEJC.KOIDFLPJKJK(jIIGOACEIKL))
			{
				MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Create Private Room"), 630f);
				return false;
			}
			if ((Object)(object)SelectObject.BNMEANGDMIP(jIIGOACEIKL).placeable != (Object)null)
			{
				MainUI.JDAEPLJAGCD(JIIGOACEIKL, LocalisationSystem.Get("BathhouseEntrace/Main 2"), 372f);
				return true;
			}
		}
		TavernConstructionUI.BMHKHFMHAGF(JIIGOACEIKL);
		return false;
	}

	public bool AAGOLOPJOHJ(int JIIGOACEIKL)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (OnlineTavernConstructionManager.instance.tavernConstructionOpenedByOtherPlayer)
			{
				return true;
			}
			PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Interact;
			OnlineObjectsManager.instance.GMJPOKECENH(placeable.onlinePlaceable.uniqueId);
			return true;
		}
		if (TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD && !BuildingTutorialManager.instance.BPDDCBHKCME)
		{
			DJECGGMMEGO(JIIGOACEIKL);
			return true;
		}
		if (COPFMLIIOOB(JIIGOACEIKL))
		{
			DKHDAINILFO(JIIGOACEIKL);
			return false;
		}
		return false;
	}

	private void NNMAPBIKEKJ()
	{
		if (DPPBPDFIGBP == null)
		{
			DPPBPDFIGBP = ((MonoBehaviour)this).StartCoroutine(ANKFFMCGLFN());
		}
	}

	private IEnumerator PDHCFIGHMOH()
	{
		return new NFCKIJAOPFE(1)
		{
			_003C_003E4__this = this
		};
	}

	public bool AJNMJKJEHGK(int JIIGOACEIKL)
	{
		InteractObject.GNCPLNHMFHN(JIIGOACEIKL).interactingObject = null;
		if (Object.op_Implicit((Object)(object)BuildingInventory.EGJFDPIEHEC()))
		{
			BuildingInventory buildingInventory = BuildingInventory.DCEBHEAHHID();
			buildingInventory.OnContainerChanged = (Action)Delegate.Remove(buildingInventory.OnContainerChanged, new Action(LILJCAOBMFH));
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		TavernConstructionUI.NODJEDECCMC();
		SmallContainerUI.NIDHCIHFOHB(JIIGOACEIKL).CloseUI();
		return true;
	}

	public bool CAJMKLBCBEK(int JIIGOACEIKL)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (OnlineTavernConstructionManager.instance.tavernConstructionOpenedByOtherPlayer)
			{
				return false;
			}
			PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Select;
			OnlineObjectsManager.instance.GMJPOKECENH(placeable.onlinePlaceable.uniqueId);
			return true;
		}
		if (TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD && !BuildingTutorialManager.instance.BPDDCBHKCME)
		{
			Select(JIIGOACEIKL);
			return true;
		}
		if (COPFMLIIOOB(JIIGOACEIKL))
		{
			DKHDAINILFO(JIIGOACEIKL);
			return false;
		}
		return true;
	}

	public bool AFAKDGJEKFG(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool EKLMADBOBIM(int JIIGOACEIKL)
	{
		return false;
	}

	public bool BLKDONCHKGE(int JIIGOACEIKL)
	{
		if (TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			CommonReferences.MNFMOEKMJKN().APKKEGHGFHG("Mouse Wheel Down", JIIGOACEIKL);
			CommonReferences.MNFMOEKMJKN().OnTavernMustBeClosed(JIIGOACEIKL);
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
			return true;
		}
		if (OnlineManager.HHDBMDMFEMP() && TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD && !BuildingTutorialManager.instance.BPDDCBHKCME)
		{
			CommonReferences.MNFMOEKMJKN().APKKEGHGFHG("clouds", JIIGOACEIKL, ECPEFDHOFHN: false);
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
			return false;
		}
		if (GameManager.LocalCoop())
		{
			int jIIGOACEIKL = ((JIIGOACEIKL != 0) ? 1 : 4);
			if (MainUI.IsAnyUIOpen(jIIGOACEIKL) || CommonReferences.MNFMOEKMJKN().IsInDialogue(jIIGOACEIKL))
			{
				MainUI.DBKCOHMFDCB(JIIGOACEIKL, LocalisationSystem.Get("Items/item_name_673"), 1144f);
				return true;
			}
			if ((Object)(object)SelectObject.GetPlayer(jIIGOACEIKL).placeable != (Object)null)
			{
				MainUI.DBKCOHMFDCB(JIIGOACEIKL, LocalisationSystem.Get("Blocked"), 1526f);
				return true;
			}
		}
		TavernConstructionUI.OpenWindow(JIIGOACEIKL);
		return true;
	}

	public bool DGAGOEDDDBJ(int JIIGOACEIKL)
	{
		if (SmallContainerUI.PHDBJGOEKHB(JIIGOACEIKL).HDEPMJIDJEM())
		{
			return false;
		}
		Sound.ABDJJBFNLBJ().FPBCHCFGINP(OpenSound.Wood, ((Component)this).transform);
		SelectObject.GetPlayer(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
		InteractObject.GNCPLNHMFHN(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
		if (Object.op_Implicit((Object)(object)BuildingInventory.GJJELMFOGPC()))
		{
			BuildingInventory buildingInventory = BuildingInventory.GOJHIEFPHDK();
			buildingInventory.OnContainerChanged = (Action)Delegate.Remove(buildingInventory.OnContainerChanged, new Action(LILJCAOBMFH));
			BuildingInventory buildingInventory2 = BuildingInventory.HHGEEDCALHK();
			buildingInventory2.OnContainerChanged = (Action)Delegate.Combine(buildingInventory2.OnContainerChanged, new Action(HJMMDOOEHIM));
		}
		SmallContainerUI.FFOABBDFMNE(JIIGOACEIKL).NIJNBDEMAEB(BuildingInventory.PPPDBCPNACC(), placeable);
		Slot[] oPMPOBPEDFB = EFBHBPNNPJD(JIIGOACEIKL);
		SmallContainerUI.IMLMJAPMBJA(JIIGOACEIKL).PJDPPGMDBMC(BuildingInventory.CIBPAINMGGD().slots, BuildingInventory.GOJHIEFPHDK(), IFMNAFDGKKK: true, OGCAKIGELBJ: false, 1, oPMPOBPEDFB);
		SmallContainerUI.CJMILOMGFJL(JIIGOACEIKL).OpenUI();
		this.JIIGOACEIKL = JIIGOACEIKL;
		return false;
	}

	public void DCBLHLOFPMK(int JIIGOACEIKL)
	{
	}

	private Slot[] BOIHFLNGDLJ(int JIIGOACEIKL)
	{
		if (PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GetAllSlots() != null)
		{
			return (from x in PlayerInventory.OGKNJNINGMH(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GetAllSlots()
				where x != null && x.itemInstance != null && Item.MLBOMGHINCA(x.itemInstance.LHBPOPOIFLE(), null) && x.itemInstance.LHBPOPOIFLE().tags != null && x.itemInstance.LHBPOPOIFLE().tags.Contains(Tag.Building)
				select x).ToArray();
		}
		return new Slot[0];
	}

	private IEnumerator ANKFFMCGLFN()
	{
		return new NFCKIJAOPFE(1)
		{
			_003C_003E4__this = this
		};
	}

	public bool COPFMLIIOOB(int JIIGOACEIKL)
	{
		if (Object.op_Implicit((Object)(object)placeable) && placeable.FHEMHCEAICB)
		{
			return false;
		}
		return DecorationMode.IECFJGHAIDO(JIIGOACEIKL).MDOKKKHKKKE();
	}

	public bool KBNLCICAOCI(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool LEKDAIHOABE(int JIIGOACEIKL)
	{
		if (SmallContainerUI.CGFJPHEFFLO(JIIGOACEIKL).BGLJFMHCFJF())
		{
			return false;
		}
		Sound.OKAPNFPFPFP().HFJHLMAGHPH(OpenSound.Metal, ((Component)this).transform);
		SelectObject.GetPlayer(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
		InteractObject.BBJCJFJEFKK(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
		if (Object.op_Implicit((Object)(object)BuildingInventory.CAJHNGGCJKM()))
		{
			BuildingInventory buildingInventory = BuildingInventory.BMDNOGNAPJJ();
			buildingInventory.OnContainerChanged = (Action)Delegate.Remove(buildingInventory.OnContainerChanged, new Action(GAMIEEIGOLE));
			BuildingInventory buildingInventory2 = BuildingInventory.GDAEMIPHAHH();
			buildingInventory2.OnContainerChanged = (Action)Delegate.Combine(buildingInventory2.OnContainerChanged, new Action(NIILOKCNLEN));
		}
		SmallContainerUI.NALKHGMLALJ(JIIGOACEIKL).EDKDKKGBIPG(BuildingInventory.BMDNOGNAPJJ(), placeable);
		Slot[] oPMPOBPEDFB = BIDJAOELNDM(JIIGOACEIKL);
		SmallContainerUI.BGIMGOJDLFG(JIIGOACEIKL).FillSlots(BuildingInventory.NIDNAAKOPFI().slots, BuildingInventory.CIBPAINMGGD(), IFMNAFDGKKK: false, OGCAKIGELBJ: true, 0, oPMPOBPEDFB);
		SmallContainerUI.OMCDJAOBFCE(JIIGOACEIKL).EDHEIFHAAKO();
		this.JIIGOACEIKL = JIIGOACEIKL;
		return false;
	}

	public bool CAIOMAEKPFK(int JIIGOACEIKL)
	{
		if (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			CommonReferences.GGFJGHHHEJC.APKKEGHGFHG("[ControllerType", JIIGOACEIKL);
			CommonReferences.GGFJGHHHEJC.OnTavernMustBeClosed(JIIGOACEIKL);
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
			return false;
		}
		if (OnlineManager.ClientOnline() && TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD && !BuildingTutorialManager.instance.BPDDCBHKCME)
		{
			CommonReferences.GGFJGHHHEJC.APKKEGHGFHG("popUpBuilding2B", JIIGOACEIKL, ECPEFDHOFHN: false);
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
			return false;
		}
		if (GameManager.LocalCoop())
		{
			int jIIGOACEIKL = ((JIIGOACEIKL != 1) ? 1 : 2);
			if (MainUI.IsAnyUIOpen(jIIGOACEIKL) || CommonReferences.MNFMOEKMJKN().IsInDialogue(jIIGOACEIKL))
			{
				MainUI.DBKCOHMFDCB(JIIGOACEIKL, LocalisationSystem.Get("BackWall"), 1545f);
				return true;
			}
			if ((Object)(object)SelectObject.GetPlayer(jIIGOACEIKL).placeable != (Object)null)
			{
				MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("start ninja"), 1393f);
				return true;
			}
		}
		TavernConstructionUI.OpenWindow(JIIGOACEIKL);
		return true;
	}

	public bool LCMAHJCIOIP(int JIIGOACEIKL)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (OnlineTavernConstructionManager.instance.tavernConstructionOpenedByOtherPlayer)
			{
				return false;
			}
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).interactAction = InteractAction.Select;
			OnlineObjectsManager.instance.InteractPlaceableIfIsPossible(placeable.onlinePlaceable.uniqueId);
			return true;
		}
		if (TutorialManager.GGFJGHHHEJC.DHGMGFNNHCO() && !BuildingTutorialManager.instance.BPDDCBHKCME)
		{
			FAACDGCCFKB(JIIGOACEIKL);
			return false;
		}
		if (OBDFGODGIFN(JIIGOACEIKL))
		{
			IAIBDGAFJLE(JIIGOACEIKL);
			return false;
		}
		return true;
	}

	public bool IFGFOAAKBCF(int JIIGOACEIKL)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (OnlineTavernConstructionManager.instance.tavernConstructionOpenedByOtherPlayer)
			{
				return true;
			}
			PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Interact;
			OnlineObjectsManager.instance.InteractPlaceableIfIsPossible(placeable.onlinePlaceable.uniqueId);
			return false;
		}
		if (TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD && !BuildingTutorialManager.instance.BPDDCBHKCME)
		{
			Select(JIIGOACEIKL);
			return false;
		}
		if (OBDFGODGIFN(JIIGOACEIKL))
		{
			IAIBDGAFJLE(JIIGOACEIKL);
			return true;
		}
		return true;
	}

	public void CDOOEGGKFBB(int JIIGOACEIKL)
	{
	}

	public void COMGONICNIN(int JIIGOACEIKL)
	{
	}

	public bool LGDMGLJCBJM(int JIIGOACEIKL)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (OnlineTavernConstructionManager.instance.tavernConstructionOpenedByOtherPlayer)
			{
				return true;
			}
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).interactAction = InteractAction.Select;
			OnlineObjectsManager.instance.GMJPOKECENH(placeable.onlinePlaceable.uniqueId);
			return true;
		}
		if (TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD && !BuildingTutorialManager.instance.BPDDCBHKCME)
		{
			MCPGDCCHEHM(JIIGOACEIKL);
			return true;
		}
		if (OBDFGODGIFN(JIIGOACEIKL))
		{
			OBCJOBEFADH(JIIGOACEIKL);
			return true;
		}
		return true;
	}

	private void Awake()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		instance = this;
	}

	public bool BCGBODLPDEB(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IFMMLFLIJJK(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("</color>"));
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Rotate, LocalisationSystem.Get("City/Hallmund/Bark/Tool"));
			return true;
		}
		return false;
	}

	public bool DKJFCCLJAPD(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && KLKLJFPEBNP(JIIGOACEIKL))
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Freeze"));
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Use, LocalisationSystem.Get("Arguing"));
			return true;
		}
		return false;
	}

	private void IHICKHAABJH()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		instance = this;
	}

	public bool IFMMLFLIJJK(int JIIGOACEIKL)
	{
		if (Object.op_Implicit((Object)(object)placeable) && placeable.FHEMHCEAICB)
		{
			return false;
		}
		return DecorationMode.IECFJGHAIDO(JIIGOACEIKL).DMBFKFLDDLH;
	}

	private void JDHHJKBOJML()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		instance = this;
	}

	public bool KGPDHFFEDKP(int JIIGOACEIKL)
	{
		if (!MissionsManager.instance.BMFOFINGDLK(-9))
		{
			CommonReferences.MNFMOEKMJKN().PlayerBark("Lost connection to the server.\nPlease try again later.", JIIGOACEIKL, ECPEFDHOFHN: false);
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.LKKBHOAFMAH())
		{
			CommonReferences.GGFJGHHHEJC.PlayerBark("Inventory full", JIIGOACEIKL, ECPEFDHOFHN: false);
			CommonReferences.MNFMOEKMJKN().OnTavernMustBeClosed(JIIGOACEIKL);
			return false;
		}
		if (OnlineManager.ClientOnline() && TutorialManager.GGFJGHHHEJC.DHGMGFNNHCO() && !BuildingTutorialManager.instance.BPDDCBHKCME)
		{
			CommonReferences.MNFMOEKMJKN().APKKEGHGFHG("PirateMinigame/Win2", JIIGOACEIKL);
			return false;
		}
		if (OnlineManager.PlayingOnline())
		{
			if (OnlineTavernConstructionManager.instance.tavernConstructionOpenedByOtherPlayer)
			{
				return true;
			}
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).interactAction = InteractAction.Interact;
			OnlineObjectsManager.instance.InteractPlaceableIfIsPossible(placeable.onlinePlaceable.uniqueId);
			return true;
		}
		if (GameManager.LocalCoop())
		{
			int jIIGOACEIKL = ((JIIGOACEIKL == 1) ? 4 : 0);
			if (MainUI.IsAnyUIOpen(jIIGOACEIKL) || CommonReferences.MNFMOEKMJKN().IJNMEDJNHDG(jIIGOACEIKL))
			{
				MainUI.LJDOBNEINNJ(JIIGOACEIKL, LocalisationSystem.Get("Direction"), 1804f);
				return true;
			}
			if ((Object)(object)SelectObject.GetPlayer(jIIGOACEIKL).placeable != (Object)null)
			{
				MainUI.DJCKALOHJFM(JIIGOACEIKL, LocalisationSystem.Get("cropsHarvested"), 43f);
				return false;
			}
		}
		TavernConstructionUI.HLJCOJNIFNF(JIIGOACEIKL);
		return true;
	}

	public void IMMNGGOJINO(int JIIGOACEIKL)
	{
	}

	public bool FAACDGCCFKB(int JIIGOACEIKL)
	{
		if (!MissionsManager.instance.IsMissionComplete(167))
		{
			CommonReferences.MNFMOEKMJKN().APKKEGHGFHG("Till", JIIGOACEIKL, ECPEFDHOFHN: false);
			return true;
		}
		if (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			CommonReferences.GGFJGHHHEJC.PlayerBark("Trying to get a player's steam name but they're not playing on a steam platform", JIIGOACEIKL, ECPEFDHOFHN: false);
			CommonReferences.GGFJGHHHEJC.OnTavernMustBeClosed(JIIGOACEIKL);
			return true;
		}
		if (OnlineManager.ClientOnline() && TutorialManager.GGFJGHHHEJC.DHGMGFNNHCO() && !BuildingTutorialManager.instance.BPDDCBHKCME)
		{
			CommonReferences.MNFMOEKMJKN().PlayerBark("Shader Model 4.1 ( DX10.1 )", JIIGOACEIKL, ECPEFDHOFHN: false);
			return true;
		}
		if (OnlineManager.PlayingOnline())
		{
			if (OnlineTavernConstructionManager.instance.tavernConstructionOpenedByOtherPlayer)
			{
				return false;
			}
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).interactAction = InteractAction.Interact;
			OnlineObjectsManager.instance.InteractPlaceableIfIsPossible(placeable.onlinePlaceable.uniqueId);
			return false;
		}
		if (GameManager.LocalCoop())
		{
			int jIIGOACEIKL = ((JIIGOACEIKL == 1) ? 4 : 0);
			if (MainUI.IsAnyUIOpen(jIIGOACEIKL) || CommonReferences.GGFJGHHHEJC.CIHFKAGPIEG(jIIGOACEIKL))
			{
				MainUI.JDAEPLJAGCD(JIIGOACEIKL, LocalisationSystem.Get("Online rock with unique ID "), 1562f);
				return true;
			}
			if ((Object)(object)SelectObject.BNMEANGDMIP(jIIGOACEIKL).placeable != (Object)null)
			{
				MainUI.JDAEPLJAGCD(JIIGOACEIKL, LocalisationSystem.Get("blackModulesParent null: {0}, "), 1413f);
				return true;
			}
		}
		TavernConstructionUI.OpenWindow(JIIGOACEIKL);
		return true;
	}

	public bool GFKDNEJHNNI(int JIIGOACEIKL)
	{
		if (Object.op_Implicit((Object)(object)placeable) && placeable.FHEMHCEAICB)
		{
			return true;
		}
		return !DecorationMode.NPANPNIDKDG(JIIGOACEIKL).KNFEPKBIHND();
	}

	public bool OGBAHGLGJAP(int JIIGOACEIKL)
	{
		if (SmallContainerUI.FFOABBDFMNE(JIIGOACEIKL).IsOpen())
		{
			return false;
		}
		Sound.MAIDHAPANEB().FPBCHCFGINP(OpenSound.Metal, ((Component)this).transform);
		SelectObject.BNMEANGDMIP(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
		InteractObject.GNCPLNHMFHN(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
		if (Object.op_Implicit((Object)(object)BuildingInventory.HPCJAODINCN()))
		{
			BuildingInventory buildingInventory = BuildingInventory.GOJHIEFPHDK();
			buildingInventory.OnContainerChanged = (Action)Delegate.Remove(buildingInventory.OnContainerChanged, new Action(NIILOKCNLEN));
			BuildingInventory buildingInventory2 = BuildingInventory.MDDCPOILOOM();
			buildingInventory2.OnContainerChanged = (Action)Delegate.Combine(buildingInventory2.OnContainerChanged, new Action(LILJCAOBMFH));
		}
		SmallContainerUI.AANKLOIDPOA(JIIGOACEIKL).MINCILKHEIB(BuildingInventory.FIEKINOFHMO(), placeable);
		Slot[] oPMPOBPEDFB = BIDJAOELNDM(JIIGOACEIKL);
		SmallContainerUI.FBKOKJCKICN(JIIGOACEIKL).FillSlots(BuildingInventory.NIDNAAKOPFI().slots, BuildingInventory.MDDCPOILOOM(), IFMNAFDGKKK: true, OGCAKIGELBJ: false, 0, oPMPOBPEDFB);
		SmallContainerUI.COIEMAJLHAM(JIIGOACEIKL).IDLAGJNLPJL();
		this.JIIGOACEIKL = JIIGOACEIKL;
		return true;
	}

	public void DABGGGNLPNO(int JIIGOACEIKL)
	{
	}

	public bool EEMEHLCLGME(int JIIGOACEIKL)
	{
		InteractObject.GNCPLNHMFHN(JIIGOACEIKL).interactingObject = null;
		if (Object.op_Implicit((Object)(object)BuildingInventory.GJJELMFOGPC()))
		{
			BuildingInventory buildingInventory = BuildingInventory.MDDCPOILOOM();
			buildingInventory.OnContainerChanged = (Action)Delegate.Remove(buildingInventory.OnContainerChanged, new Action(HJMMDOOEHIM));
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		TavernConstructionUI.JDPLELLEFJC();
		SmallContainerUI.NDPAJCGHGOB(JIIGOACEIKL).BOBCIFEDJED();
		return false;
	}

	public bool GPANAJKPLPO(int JIIGOACEIKL)
	{
		if (!MissionsManager.instance.LLOBLPDJNJE(1))
		{
			CommonReferences.MNFMOEKMJKN().APKKEGHGFHG(" ", JIIGOACEIKL);
			return false;
		}
		if (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			CommonReferences.GGFJGHHHEJC.PlayerBark("Items/item_name_649", JIIGOACEIKL, ECPEFDHOFHN: false);
			CommonReferences.GGFJGHHHEJC.OnTavernMustBeClosed(JIIGOACEIKL);
			return true;
		}
		if (OnlineManager.ClientOnline() && TutorialManager.GGFJGHHHEJC.NAFMLLMLHPD && !BuildingTutorialManager.instance.BPDDCBHKCME)
		{
			CommonReferences.GGFJGHHHEJC.PlayerBark("LearnBalance", JIIGOACEIKL, ECPEFDHOFHN: false);
			return false;
		}
		if (OnlineManager.PlayingOnline())
		{
			if (OnlineTavernConstructionManager.instance.tavernConstructionOpenedByOtherPlayer)
			{
				return false;
			}
			PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Interact;
			OnlineObjectsManager.instance.InteractPlaceableIfIsPossible(placeable.onlinePlaceable.uniqueId);
			return false;
		}
		if (GameManager.LocalCoop())
		{
			int jIIGOACEIKL = ((JIIGOACEIKL == 0) ? 1 : 0);
			if (MainUI.IsAnyUIOpen(jIIGOACEIKL) || CommonReferences.MNFMOEKMJKN().CIHFKAGPIEG(jIIGOACEIKL))
			{
				MainUI.ShowErrorText(JIIGOACEIKL, LocalisationSystem.Get("Pick up"), 603f);
				return false;
			}
			if ((Object)(object)SelectObject.GetPlayer(jIIGOACEIKL).placeable != (Object)null)
			{
				MainUI.LJDOBNEINNJ(JIIGOACEIKL, LocalisationSystem.Get(" EnterState()."), 894f);
				return false;
			}
		}
		TavernConstructionUI.BMHKHFMHAGF(JIIGOACEIKL);
		return true;
	}

	public bool CNADCCGDBPD(int JIIGOACEIKL)
	{
		if (Object.op_Implicit((Object)(object)placeable) && placeable.FHEMHCEAICB)
		{
			return false;
		}
		return !DecorationMode.OCJGHINCLJM(JIIGOACEIKL).IDPGEBNGDJD();
	}

	public bool JDPLMJFBBED(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && OBDFGODGIFN(JIIGOACEIKL))
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get(" "));
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.NextItem, LocalisationSystem.Get("Ale"));
			return false;
		}
		return true;
	}

	private void GNOBDKFFPOL()
	{
		if ((Object)(object)placeable == (Object)null)
		{
			placeable = ((Component)this).GetComponent<Placeable>();
		}
		instance = this;
	}
}
