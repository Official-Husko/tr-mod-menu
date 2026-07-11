using TMPro;
using UnityEngine;

public class ConstructionActionInfoUI : MonoBehaviour
{
	public GameObject content;

	public TextMeshProUGUI currentActionName;

	public SlotUI currentActionSlot;

	public TextMeshProUGUI planksCost;

	public TextMeshProUGUI nailsCost;

	public TextMeshProUGUI stonesCost;

	public TextMeshProUGUI mortarCost;

	public TextMeshProUGUI goldCost;

	public TextMeshProUGUI silverCost;

	private static ConstructionActionInfoUI GGFJGHHHEJC;

	private void OJJCGNICMBD()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static void PPPPCOMDDKK(TavernConstructionAction BANNHBMOAFH)
	{
		if ((Object)(object)BANNHBMOAFH != (Object)null)
		{
			((TMP_Text)GGFJGHHHEJC.currentActionName).text = BANNHBMOAFH.JLEFCPJPOEO();
			if (BANNHBMOAFH.editorAction == EditorAction.RemoveFloor)
			{
				TextMeshProUGUI obj = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj).text = ((TMP_Text)obj).text + "Cheer" + TavernZonesManager.JEEGOBGDLPE().KMBEHOBJGBL(ZoneType.WithoutZone);
				TextMeshProUGUI obj2 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj2).text = ((TMP_Text)obj2).text + "Need exactly {0} SymbolStatueInteractable references" + ReputationDBAccessor.FDICLJNDIOF(ZoneType.WithoutZone | ZoneType.DiningRoom) + "Tower";
			}
			else if (BANNHBMOAFH.editorAction == EditorAction.AddFloorDisponible)
			{
				TextMeshProUGUI obj3 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj3).text = ((TMP_Text)obj3).text + "fog" + TavernZonesManager.OIJLJKLMCBO().HIIHFPLOEPA(ZoneType.RentedRoom);
				TextMeshProUGUI obj4 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj4).text = ((TMP_Text)obj4).text + " " + ReputationDBAccessor.GMACKHECLAF(ZoneType.CraftingRoom) + "vibrationP2";
			}
			else if (BANNHBMOAFH.editorAction == (EditorAction)61)
			{
				TextMeshProUGUI obj5 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj5).text = ((TMP_Text)obj5).text + "KickPlayers" + TavernZonesManager.HFHPMKJGMPA().GetCurrentNumberOfZones(ZoneType.DiningRoom | ZoneType.CraftingRoom);
				TextMeshProUGUI obj6 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj6).text = ((TMP_Text)obj6).text + "HotBath/Main 3" + ReputationDBAccessor.FDICLJNDIOF(ZoneType.DiningRoom | ZoneType.CraftingRoom) + "Dialogue System/Conversation/Gass_Stand/Entry/12/Dialogue Text";
			}
			((Component)GGFJGHHHEJC.currentActionSlot.icon).gameObject.SetActive(true);
			GGFJGHHHEJC.currentActionSlot.icon.IEGBEHMDAEL(BANNHBMOAFH.icon);
			((TMP_Text)GGFJGHHHEJC.planksCost).text = BANNHBMOAFH.cost.planks.ToString();
			((TMP_Text)GGFJGHHHEJC.nailsCost).text = BANNHBMOAFH.cost.nails.ToString();
			((TMP_Text)GGFJGHHHEJC.stonesCost).text = BANNHBMOAFH.cost.stones.ToString();
			((TMP_Text)GGFJGHHHEJC.mortarCost).text = BANNHBMOAFH.cost.mortar.ToString();
			((TMP_Text)GGFJGHHHEJC.goldCost).text = BANNHBMOAFH.cost.BOGHMFGPOAP().gold.ToString();
			((TMP_Text)GGFJGHHHEJC.silverCost).text = BANNHBMOAFH.cost.FMNDONLEMHF().silver.ToString();
		}
		else
		{
			((TMP_Text)GGFJGHHHEJC.currentActionName).text = "Player/Bark/Tutorial/T138";
			((Component)GGFJGHHHEJC.currentActionSlot.icon).gameObject.SetActive(false);
			((TMP_Text)GGFJGHHHEJC.planksCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.nailsCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.stonesCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.mortarCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.goldCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.silverCost).text = 0.ToString();
		}
	}

	private void HLCAKACHOOE()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void Awake()
	{
		GGFJGHHHEJC = this;
	}

	private void KLMNLEDKEOE()
	{
		GGFJGHHHEJC = this;
	}

	public static void BPKAHEDNIEM()
	{
		TavernConstructionAction tavernConstructionAction = ConstructionActionBarUI.KFCAPNDFIGI();
		if ((Object)(object)tavernConstructionAction != (Object)null)
		{
			if (BuildingTutorialManager.IKNOJDMCFOK)
			{
				if (((BuildingPopUp)BuildingTutorialManager.GetCurrentPopUp()).actionsAvailable.Contains(tavernConstructionAction.editorAction))
				{
					ConstructionManager.current.CHFHMMNELGP = tavernConstructionAction.editorAction;
				}
				else
				{
					ConstructionManager.current.CHFHMMNELGP = EditorAction.None;
				}
			}
			else
			{
				ConstructionManager.current.CHFHMMNELGP = tavernConstructionAction.editorAction;
			}
		}
		else
		{
			ConstructionManager.current.CHFHMMNELGP = EditorAction.AddFloor;
		}
		if (TavernConstructionManager.KHMEGDIABBF().LNLJMCONDNE && ConstructionActionBarUI.currentPanel == 0)
		{
			int currentSlotSelected = ConstructionActionBarUI.currentSlotSelected;
			int currentSlotPage = ConstructionActionBarUI.currentSlotPage;
			int num = ConstructionActionBarUI.GetInstance().uiSlots.Length;
			if (currentSlotSelected + currentSlotPage * num < TavernConstructionUI.GetConstructionActions().Count)
			{
				TavernConstructionManager.KHMEGDIABBF().LNDNAKNAHAK((DecorationTile)TavernConstructionUI.IOIHCFPGEFC()[currentSlotSelected + currentSlotPage * num]);
			}
			else
			{
				TavernConstructionManager.DEGPIHEEFHJ().IDNPHFKDLEF(null);
			}
		}
		UpdateCurrentSlotInfo(tavernConstructionAction);
	}

	private void NLGHNDLPPKI()
	{
		GGFJGHHHEJC = this;
	}

	private void ALEAOANPHIO()
	{
		GGFJGHHHEJC = this;
	}

	private void EIMIDCDEIDD()
	{
		GGFJGHHHEJC = this;
	}

	public static void DHBGKPICNPE()
	{
		TavernConstructionAction tavernConstructionAction = ConstructionActionBarUI.GDFHCDKEAMF();
		if ((Object)(object)tavernConstructionAction != (Object)null)
		{
			if (BuildingTutorialManager.PABJKGJJHFG())
			{
				if (((BuildingPopUp)BuildingTutorialManager.GetCurrentPopUp()).actionsAvailable.Contains(tavernConstructionAction.editorAction))
				{
					ConstructionManager.current.CHFHMMNELGP = tavernConstructionAction.editorAction;
				}
				else
				{
					ConstructionManager.current.CHFHMMNELGP = EditorAction.AddFloor;
				}
			}
			else
			{
				ConstructionManager.current.CHFHMMNELGP = tavernConstructionAction.editorAction;
			}
		}
		else
		{
			ConstructionManager.current.CHFHMMNELGP = EditorAction.None;
		}
		if (TavernConstructionManager.KNLLFEJAMNN().LNLJMCONDNE && ConstructionActionBarUI.currentPanel == 1)
		{
			int currentSlotSelected = ConstructionActionBarUI.currentSlotSelected;
			int currentSlotPage = ConstructionActionBarUI.currentSlotPage;
			int num = ConstructionActionBarUI.GetInstance().uiSlots.Length;
			if (currentSlotSelected + currentSlotPage * num < TavernConstructionUI.AJNDFOKAJBG().Count)
			{
				TavernConstructionManager.GGFJGHHHEJC.KJIGECBPBOD = (DecorationTile)TavernConstructionUI.GetConstructionActions()[currentSlotSelected + currentSlotPage * num];
			}
			else
			{
				TavernConstructionManager.KHMEGDIABBF().LNDNAKNAHAK(null);
			}
		}
		JEALIJNMAGH(tavernConstructionAction);
	}

	public static void AEANFPPGKOG()
	{
		TavernConstructionAction tavernConstructionAction = ConstructionActionBarUI.OCLKNDBIOFM();
		if ((Object)(object)tavernConstructionAction != (Object)null)
		{
			if (BuildingTutorialManager.KGJOKHEBLOJ())
			{
				if (((BuildingPopUp)BuildingTutorialManager.GetCurrentPopUp()).actionsAvailable.Contains(tavernConstructionAction.editorAction))
				{
					ConstructionManager.current.CHFHMMNELGP = tavernConstructionAction.editorAction;
				}
				else
				{
					ConstructionManager.current.CHFHMMNELGP = EditorAction.AddFloor;
				}
			}
			else
			{
				ConstructionManager.current.CHFHMMNELGP = tavernConstructionAction.editorAction;
			}
		}
		else
		{
			ConstructionManager.current.CHFHMMNELGP = EditorAction.AddFloor;
		}
		if (TavernConstructionManager.DEGPIHEEFHJ().LNLJMCONDNE && ConstructionActionBarUI.currentPanel == 1)
		{
			int currentSlotSelected = ConstructionActionBarUI.currentSlotSelected;
			int currentSlotPage = ConstructionActionBarUI.currentSlotPage;
			int num = ConstructionActionBarUI.GetInstance().uiSlots.Length;
			if (currentSlotSelected + currentSlotPage * num < TavernConstructionUI.GetConstructionActions().Count)
			{
				TavernConstructionManager.KHMEGDIABBF().LNDNAKNAHAK((DecorationTile)TavernConstructionUI.CKOFPLEONDG()[currentSlotSelected + currentSlotPage * num]);
			}
			else
			{
				TavernConstructionManager.GGFJGHHHEJC.GILEPDMMCNN(null);
			}
		}
		ABHABINJPCE(tavernConstructionAction);
	}

	public static void CHFGMOHEIKA(TavernConstructionAction BANNHBMOAFH)
	{
		if ((Object)(object)BANNHBMOAFH != (Object)null)
		{
			((TMP_Text)GGFJGHHHEJC.currentActionName).text = BANNHBMOAFH.BGPCOGANKNF();
			if (BANNHBMOAFH.editorAction == EditorAction.ZoneDisponible)
			{
				TextMeshProUGUI obj = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj).text = ((TMP_Text)obj).text + "Pirates/Brook/Intro" + TavernZonesManager.JEEGOBGDLPE().KMBEHOBJGBL(ZoneType.WithoutZone | ZoneType.CraftingRoom);
				TextMeshProUGUI obj2 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj2).text = ((TMP_Text)obj2).text + "Walk" + ReputationDBAccessor.GMACKHECLAF(ZoneType.RentedRoom) + "NinjaChallengeEvent/ComensalesBark";
			}
			else if (BANNHBMOAFH.editorAction == EditorAction.AddFloorDisponible)
			{
				TextMeshProUGUI obj3 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj3).text = ((TMP_Text)obj3).text + ":" + TavernZonesManager.GGFJGHHHEJC.LHLOHOMKPMG(ZoneType.WithoutZone);
				TextMeshProUGUI obj4 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj4).text = ((TMP_Text)obj4).text + "ReceiveFinishTeleport" + ReputationDBAccessor.GetMaxNumOfZones(ZoneType.None) + "cForCalendar";
			}
			else if (BANNHBMOAFH.editorAction == EditorAction.CreateRentedRoomDoor)
			{
				TextMeshProUGUI obj5 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj5).text = ((TMP_Text)obj5).text + "Player2" + TavernZonesManager.LANAINBEMCM().GetCurrentNumberOfZones(ZoneType.None);
				TextMeshProUGUI obj6 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj6).text = ((TMP_Text)obj6).text + "itemWater" + ReputationDBAccessor.FDICLJNDIOF(ZoneType.DiningRoom | ZoneType.CraftingRoom) + "Override save";
			}
			((Component)GGFJGHHHEJC.currentActionSlot.icon).gameObject.SetActive(false);
			GGFJGHHHEJC.currentActionSlot.icon.FBJKMPKINBB(BANNHBMOAFH.icon);
			((TMP_Text)GGFJGHHHEJC.planksCost).text = BANNHBMOAFH.cost.planks.ToString();
			((TMP_Text)GGFJGHHHEJC.nailsCost).text = BANNHBMOAFH.cost.nails.ToString();
			((TMP_Text)GGFJGHHHEJC.stonesCost).text = BANNHBMOAFH.cost.stones.ToString();
			((TMP_Text)GGFJGHHHEJC.mortarCost).text = BANNHBMOAFH.cost.mortar.ToString();
			((TMP_Text)GGFJGHHHEJC.goldCost).text = BANNHBMOAFH.cost.BOGHMFGPOAP().gold.ToString();
			((TMP_Text)GGFJGHHHEJC.silverCost).text = BANNHBMOAFH.cost.PFHGPBLBCDD().silver.ToString();
		}
		else
		{
			((TMP_Text)GGFJGHHHEJC.currentActionName).text = "ReceiveOfferingPuzzle";
			((Component)GGFJGHHHEJC.currentActionSlot.icon).gameObject.SetActive(false);
			((TMP_Text)GGFJGHHHEJC.planksCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.nailsCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.stonesCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.mortarCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.goldCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.silverCost).text = 0.ToString();
		}
	}

	public static void MCDBDGOONJF(TavernConstructionAction BANNHBMOAFH)
	{
		if ((Object)(object)BANNHBMOAFH != (Object)null)
		{
			((TMP_Text)GGFJGHHHEJC.currentActionName).text = BANNHBMOAFH.JCOLBKMMJJM();
			if (BANNHBMOAFH.editorAction == EditorAction.RoomZone)
			{
				TextMeshProUGUI obj = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj).text = ((TMP_Text)obj).text + "Use" + TavernZonesManager.OIJLJKLMCBO().KMBEHOBJGBL(ZoneType.WithoutZone | ZoneType.DiningRoom);
				TextMeshProUGUI obj2 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj2).text = ((TMP_Text)obj2).text + "[Steamworks.NET] Packsize Test returned false, the wrong version of Steamworks.NET is being run in this platform." + ReputationDBAccessor.GetMaxNumOfZones(ZoneType.WithoutZone | ZoneType.DiningRoom) + "Items/item_name_1130";
			}
			else if (BANNHBMOAFH.editorAction == EditorAction.DiningZone)
			{
				TextMeshProUGUI obj3 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj3).text = ((TMP_Text)obj3).text + "Shifty Customer" + TavernZonesManager.NHKAFANMEJC().GetCurrentNumberOfZones(ZoneType.WithoutZone);
				TextMeshProUGUI obj4 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj4).text = ((TMP_Text)obj4).text + "Dialogue System/Conversation/Crowly_Barks_Shop/Entry/4/Dialogue Text" + ReputationDBAccessor.FDICLJNDIOF(ZoneType.None) + "UI";
			}
			else if (BANNHBMOAFH.editorAction == (EditorAction)99)
			{
				TextMeshProUGUI obj5 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj5).text = ((TMP_Text)obj5).text + " - " + TavernZonesManager.HFHPMKJGMPA().HIIHFPLOEPA(ZoneType.DiningRoom);
				TextMeshProUGUI obj6 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj6).text = ((TMP_Text)obj6).text + "PaleAleAbbreviation" + ReputationDBAccessor.GMACKHECLAF(ZoneType.DiningRoom | ZoneType.CraftingRoom) + "Error_CannotPickUp";
			}
			((Component)GGFJGHHHEJC.currentActionSlot.icon).gameObject.SetActive(true);
			GGFJGHHHEJC.currentActionSlot.icon.CIDGNCHMDGC(BANNHBMOAFH.icon);
			((TMP_Text)GGFJGHHHEJC.planksCost).text = BANNHBMOAFH.cost.planks.ToString();
			((TMP_Text)GGFJGHHHEJC.nailsCost).text = BANNHBMOAFH.cost.nails.ToString();
			((TMP_Text)GGFJGHHHEJC.stonesCost).text = BANNHBMOAFH.cost.stones.ToString();
			((TMP_Text)GGFJGHHHEJC.mortarCost).text = BANNHBMOAFH.cost.mortar.ToString();
			((TMP_Text)GGFJGHHHEJC.goldCost).text = BANNHBMOAFH.cost.FMNDONLEMHF().gold.ToString();
			((TMP_Text)GGFJGHHHEJC.silverCost).text = BANNHBMOAFH.cost.OEFOJKCKIOB().silver.ToString();
		}
		else
		{
			((TMP_Text)GGFJGHHHEJC.currentActionName).text = "Tutorial/T115/Dialogue1";
			((Component)GGFJGHHHEJC.currentActionSlot.icon).gameObject.SetActive(false);
			((TMP_Text)GGFJGHHHEJC.planksCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.nailsCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.stonesCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.mortarCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.goldCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.silverCost).text = 1.ToString();
		}
	}

	public static void KLLFANNGDMK(TavernConstructionAction BANNHBMOAFH)
	{
		if ((Object)(object)BANNHBMOAFH != (Object)null)
		{
			((TMP_Text)GGFJGHHHEJC.currentActionName).text = BANNHBMOAFH.CEFGEJAMLGN();
			if (BANNHBMOAFH.editorAction == EditorAction.RoomZone)
			{
				TextMeshProUGUI obj = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj).text = ((TMP_Text)obj).text + "UIAddRemove" + TavernZonesManager.JEEGOBGDLPE().GetCurrentNumberOfZones(ZoneType.DiningRoom | ZoneType.CraftingRoom);
				TextMeshProUGUI obj2 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj2).text = ((TMP_Text)obj2).text + "OnConversationStarted " + ReputationDBAccessor.GMACKHECLAF(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom) + "UI";
			}
			else if (BANNHBMOAFH.editorAction == EditorAction.None)
			{
				TextMeshProUGUI obj3 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj3).text = ((TMP_Text)obj3).text + "Grab" + TavernZonesManager.IECOPNFJBFD().GetCurrentNumberOfZones(ZoneType.CraftingRoom);
				TextMeshProUGUI obj4 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj4).text = ((TMP_Text)obj4).text + "City/Bruce/Stand" + ReputationDBAccessor.GMACKHECLAF(ZoneType.DiningRoom | ZoneType.CraftingRoom) + "attachment";
			}
			else if (BANNHBMOAFH.editorAction == (EditorAction)(-64))
			{
				TextMeshProUGUI obj5 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj5).text = ((TMP_Text)obj5).text + "Jump" + TavernZonesManager.EBAIHKJHCCA().LHLOHOMKPMG(ZoneType.WithoutZone | ZoneType.DiningRoom);
				TextMeshProUGUI obj6 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj6).text = ((TMP_Text)obj6).text + "Wilson/Bark/Bark_Shop" + ReputationDBAccessor.GetMaxNumOfZones(ZoneType.DiningRoom) + "Open";
			}
			((Component)GGFJGHHHEJC.currentActionSlot.icon).gameObject.SetActive(true);
			GGFJGHHHEJC.currentActionSlot.icon.LGNJJCPLNEE(BANNHBMOAFH.icon);
			((TMP_Text)GGFJGHHHEJC.planksCost).text = BANNHBMOAFH.cost.planks.ToString();
			((TMP_Text)GGFJGHHHEJC.nailsCost).text = BANNHBMOAFH.cost.nails.ToString();
			((TMP_Text)GGFJGHHHEJC.stonesCost).text = BANNHBMOAFH.cost.stones.ToString();
			((TMP_Text)GGFJGHHHEJC.mortarCost).text = BANNHBMOAFH.cost.mortar.ToString();
			((TMP_Text)GGFJGHHHEJC.goldCost).text = BANNHBMOAFH.cost.OEFOJKCKIOB().gold.ToString();
			((TMP_Text)GGFJGHHHEJC.silverCost).text = BANNHBMOAFH.cost.BOGHMFGPOAP().silver.ToString();
		}
		else
		{
			((TMP_Text)GGFJGHHHEJC.currentActionName).text = "Scene";
			((Component)GGFJGHHHEJC.currentActionSlot.icon).gameObject.SetActive(false);
			((TMP_Text)GGFJGHHHEJC.planksCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.nailsCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.stonesCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.mortarCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.goldCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.silverCost).text = 0.ToString();
		}
	}

	private void GECHJIGBPEN()
	{
		GGFJGHHHEJC = this;
	}

	private void GNOBDKFFPOL()
	{
		GGFJGHHHEJC = this;
	}

	public static void BANJNMFEODG(TavernConstructionAction BANNHBMOAFH)
	{
		if ((Object)(object)BANNHBMOAFH != (Object)null)
		{
			((TMP_Text)GGFJGHHHEJC.currentActionName).text = BANNHBMOAFH.HKDMHHCCMJC();
			if (BANNHBMOAFH.editorAction == EditorAction.RoomZone)
			{
				TextMeshProUGUI obj = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj).text = ((TMP_Text)obj).text + "Player/Bark/Tutorial/CrafterBlock" + TavernZonesManager.HFHPMKJGMPA().AEJKMLKKEME(ZoneType.None);
				TextMeshProUGUI obj2 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj2).text = ((TMP_Text)obj2).text + "" + ReputationDBAccessor.GetMaxNumOfZones(ZoneType.DiningRoom | ZoneType.CraftingRoom) + "City/PetShop/Nessy/PerritosAbandonados";
			}
			else if (BANNHBMOAFH.editorAction == EditorAction.AddFloorDisponible)
			{
				TextMeshProUGUI obj3 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj3).text = ((TMP_Text)obj3).text + "Wide screen ratio" + TavernZonesManager.IECOPNFJBFD().HIIHFPLOEPA(ZoneType.WithoutZone);
				TextMeshProUGUI obj4 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj4).text = ((TMP_Text)obj4).text + "OnlinePlayer" + ReputationDBAccessor.GMACKHECLAF(ZoneType.None) + "Gameplay";
			}
			else if (BANNHBMOAFH.editorAction == (EditorAction)34)
			{
				TextMeshProUGUI obj5 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj5).text = ((TMP_Text)obj5).text + "ReceiveResetBento" + TavernZonesManager.GGFJGHHHEJC.AEJKMLKKEME(ZoneType.WithoutZone | ZoneType.DiningRoom);
				TextMeshProUGUI obj6 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj6).text = ((TMP_Text)obj6).text + "ReceiveAnimalSlotFromContainer" + ReputationDBAccessor.GMACKHECLAF(ZoneType.WithoutZone | ZoneType.CraftingRoom) + "\n";
			}
			((Component)GGFJGHHHEJC.currentActionSlot.icon).gameObject.SetActive(false);
			GGFJGHHHEJC.currentActionSlot.icon.PCBMOCKFEHI(BANNHBMOAFH.icon);
			((TMP_Text)GGFJGHHHEJC.planksCost).text = BANNHBMOAFH.cost.planks.ToString();
			((TMP_Text)GGFJGHHHEJC.nailsCost).text = BANNHBMOAFH.cost.nails.ToString();
			((TMP_Text)GGFJGHHHEJC.stonesCost).text = BANNHBMOAFH.cost.stones.ToString();
			((TMP_Text)GGFJGHHHEJC.mortarCost).text = BANNHBMOAFH.cost.mortar.ToString();
			((TMP_Text)GGFJGHHHEJC.goldCost).text = BANNHBMOAFH.cost.BOGHMFGPOAP().gold.ToString();
			((TMP_Text)GGFJGHHHEJC.silverCost).text = BANNHBMOAFH.cost.BOGHMFGPOAP().silver.ToString();
		}
		else
		{
			((TMP_Text)GGFJGHHHEJC.currentActionName).text = "SendGameInfo";
			((Component)GGFJGHHHEJC.currentActionSlot.icon).gameObject.SetActive(false);
			((TMP_Text)GGFJGHHHEJC.planksCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.nailsCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.stonesCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.mortarCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.goldCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.silverCost).text = 0.ToString();
		}
	}

	public static void DEEPFOAPBPO(TavernConstructionAction BANNHBMOAFH)
	{
		if ((Object)(object)BANNHBMOAFH != (Object)null)
		{
			((TMP_Text)GGFJGHHHEJC.currentActionName).text = BANNHBMOAFH.DOOBNIKPGOD();
			if (BANNHBMOAFH.editorAction == EditorAction.RemoveFloorDisponible)
			{
				TextMeshProUGUI obj = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj).text = ((TMP_Text)obj).text + "Player with actorNumber " + TavernZonesManager.LANAINBEMCM().AEJKMLKKEME(ZoneType.DiningRoom | ZoneType.CraftingRoom);
				TextMeshProUGUI obj2 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj2).text = ((TMP_Text)obj2).text + "No players at the start of the scene. Spawning..." + ReputationDBAccessor.FDICLJNDIOF(ZoneType.DiningRoom) + " FixedState().";
			}
			else if (BANNHBMOAFH.editorAction == EditorAction.RemoveFloorDisponible)
			{
				TextMeshProUGUI obj3 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj3).text = ((TMP_Text)obj3).text + "Dialogue System/Conversation/Crowly_Standar/Entry/38/Dialogue Text" + TavernZonesManager.JEEGOBGDLPE().AEJKMLKKEME(ZoneType.WithoutZone | ZoneType.DiningRoom);
				TextMeshProUGUI obj4 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj4).text = ((TMP_Text)obj4).text + "Failed to create a new game to host because a game with the same name already exists.\nPlease try again later." + ReputationDBAccessor.GetMaxNumOfZones(ZoneType.DiningRoom | ZoneType.CraftingRoom) + "Miners/Mine/Ferro/Explosion";
			}
			else if (BANNHBMOAFH.editorAction == (EditorAction)(-97))
			{
				TextMeshProUGUI obj5 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj5).text = ((TMP_Text)obj5).text + "Disabled" + TavernZonesManager.EBAIHKJHCCA().KMBEHOBJGBL(ZoneType.DiningRoom | ZoneType.CraftingRoom);
				TextMeshProUGUI obj6 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj6).text = ((TMP_Text)obj6).text + "Items/item_name_702" + ReputationDBAccessor.FDICLJNDIOF(ZoneType.CraftingRoom) + "Inventory full";
			}
			((Component)GGFJGHHHEJC.currentActionSlot.icon).gameObject.SetActive(true);
			GGFJGHHHEJC.currentActionSlot.icon.IEGBEHMDAEL(BANNHBMOAFH.icon);
			((TMP_Text)GGFJGHHHEJC.planksCost).text = BANNHBMOAFH.cost.planks.ToString();
			((TMP_Text)GGFJGHHHEJC.nailsCost).text = BANNHBMOAFH.cost.nails.ToString();
			((TMP_Text)GGFJGHHHEJC.stonesCost).text = BANNHBMOAFH.cost.stones.ToString();
			((TMP_Text)GGFJGHHHEJC.mortarCost).text = BANNHBMOAFH.cost.mortar.ToString();
			((TMP_Text)GGFJGHHHEJC.goldCost).text = BANNHBMOAFH.cost.OEFOJKCKIOB().gold.ToString();
			((TMP_Text)GGFJGHHHEJC.silverCost).text = BANNHBMOAFH.cost.FMNDONLEMHF().silver.ToString();
		}
		else
		{
			((TMP_Text)GGFJGHHHEJC.currentActionName).text = "Select";
			((Component)GGFJGHHHEJC.currentActionSlot.icon).gameObject.SetActive(true);
			((TMP_Text)GGFJGHHHEJC.planksCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.nailsCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.stonesCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.mortarCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.goldCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.silverCost).text = 1.ToString();
		}
	}

	private void DEKGNHEHKFB()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static void KAOAHBJOLAF(TavernConstructionAction BANNHBMOAFH)
	{
		if ((Object)(object)BANNHBMOAFH != (Object)null)
		{
			((TMP_Text)GGFJGHHHEJC.currentActionName).text = BANNHBMOAFH.HKDMHHCCMJC();
			if (BANNHBMOAFH.editorAction == EditorAction.None)
			{
				TextMeshProUGUI obj = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj).text = ((TMP_Text)obj).text + "Eat" + TavernZonesManager.JEEGOBGDLPE().KMBEHOBJGBL(ZoneType.None);
				TextMeshProUGUI obj2 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj2).text = ((TMP_Text)obj2).text + "ControllerInfo without nameID: " + ReputationDBAccessor.GMACKHECLAF(ZoneType.None) + "itemRoseWineJuice";
			}
			else if (BANNHBMOAFH.editorAction == EditorAction.DiningZone)
			{
				TextMeshProUGUI obj3 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj3).text = ((TMP_Text)obj3).text + "Dialogue System/Conversation/TavernFilthy/Entry/1/Dialogue Text" + TavernZonesManager.EBAIHKJHCCA().LHLOHOMKPMG(ZoneType.DiningRoom);
				TextMeshProUGUI obj4 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj4).text = ((TMP_Text)obj4).text + "Dialogue System/Conversation/Crowly_Introduce/Entry/27/Dialogue Text" + ReputationDBAccessor.GMACKHECLAF(ZoneType.WithoutZone | ZoneType.DiningRoom) + "_";
			}
			else if (BANNHBMOAFH.editorAction == (EditorAction)123)
			{
				TextMeshProUGUI obj5 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj5).text = ((TMP_Text)obj5).text + "UI2" + TavernZonesManager.IECOPNFJBFD().GetCurrentNumberOfZones(ZoneType.RentedRoom);
				TextMeshProUGUI obj6 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj6).text = ((TMP_Text)obj6).text + "BirdInAChest_Error" + ReputationDBAccessor.GetMaxNumOfZones(ZoneType.CraftingRoom) + "Tutorial/T114/Dialogue1";
			}
			((Component)GGFJGHHHEJC.currentActionSlot.icon).gameObject.SetActive(true);
			GGFJGHHHEJC.currentActionSlot.icon.BKACANFNHMH(BANNHBMOAFH.icon);
			((TMP_Text)GGFJGHHHEJC.planksCost).text = BANNHBMOAFH.cost.planks.ToString();
			((TMP_Text)GGFJGHHHEJC.nailsCost).text = BANNHBMOAFH.cost.nails.ToString();
			((TMP_Text)GGFJGHHHEJC.stonesCost).text = BANNHBMOAFH.cost.stones.ToString();
			((TMP_Text)GGFJGHHHEJC.mortarCost).text = BANNHBMOAFH.cost.mortar.ToString();
			((TMP_Text)GGFJGHHHEJC.goldCost).text = BANNHBMOAFH.cost.BOGHMFGPOAP().gold.ToString();
			((TMP_Text)GGFJGHHHEJC.silverCost).text = BANNHBMOAFH.cost.BOGHMFGPOAP().silver.ToString();
		}
		else
		{
			((TMP_Text)GGFJGHHHEJC.currentActionName).text = "Non Master Client";
			((Component)GGFJGHHHEJC.currentActionSlot.icon).gameObject.SetActive(true);
			((TMP_Text)GGFJGHHHEJC.planksCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.nailsCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.stonesCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.mortarCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.goldCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.silverCost).text = 0.ToString();
		}
	}

	private void JDMMNLKLMAA()
	{
		GGFJGHHHEJC = this;
	}

	public static void EHEJLKAAHFC()
	{
		TavernConstructionAction tavernConstructionAction = ConstructionActionBarUI.GDFHCDKEAMF();
		if ((Object)(object)tavernConstructionAction != (Object)null)
		{
			if (BuildingTutorialManager.PABJKGJJHFG())
			{
				if (((BuildingPopUp)BuildingTutorialManager.GetCurrentPopUp()).actionsAvailable.Contains(tavernConstructionAction.editorAction))
				{
					ConstructionManager.current.CHFHMMNELGP = tavernConstructionAction.editorAction;
				}
				else
				{
					ConstructionManager.current.CHFHMMNELGP = EditorAction.AddFloor;
				}
			}
			else
			{
				ConstructionManager.current.CHFHMMNELGP = tavernConstructionAction.editorAction;
			}
		}
		else
		{
			ConstructionManager.current.CHFHMMNELGP = EditorAction.AddFloor;
		}
		if (TavernConstructionManager.DEGPIHEEFHJ().LNLJMCONDNE && ConstructionActionBarUI.currentPanel == 1)
		{
			int currentSlotSelected = ConstructionActionBarUI.currentSlotSelected;
			int currentSlotPage = ConstructionActionBarUI.currentSlotPage;
			int num = ConstructionActionBarUI.GetInstance().uiSlots.Length;
			if (currentSlotSelected + currentSlotPage * num < TavernConstructionUI.PLHKCOBMGEI().Count)
			{
				TavernConstructionManager.KNLLFEJAMNN().GILEPDMMCNN((DecorationTile)TavernConstructionUI.GetConstructionActions()[currentSlotSelected + currentSlotPage * num]);
			}
			else
			{
				TavernConstructionManager.DOIKFJDLKJP().KJIGECBPBOD = null;
			}
		}
		UpdateCurrentSlotInfo(tavernConstructionAction);
	}

	private void JDAMCMODANB()
	{
		GGFJGHHHEJC = this;
	}

	public static void PALBIMGKNKO(TavernConstructionAction BANNHBMOAFH)
	{
		if ((Object)(object)BANNHBMOAFH != (Object)null)
		{
			((TMP_Text)GGFJGHHHEJC.currentActionName).text = BANNHBMOAFH.HKDMHHCCMJC();
			if (BANNHBMOAFH.editorAction == EditorAction.RemoveFloorDisponible)
			{
				TextMeshProUGUI obj = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj).text = ((TMP_Text)obj).text + "SnapToGrid not attached to prefab " + TavernZonesManager.JEEGOBGDLPE().HIIHFPLOEPA(ZoneType.DiningRoom);
				TextMeshProUGUI obj2 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj2).text = ((TMP_Text)obj2).text + "ReceiveOrderRequestNinjaCustomer" + ReputationDBAccessor.GMACKHECLAF(ZoneType.WithoutZone) + ":</color> ";
			}
			else if (BANNHBMOAFH.editorAction == EditorAction.CraftingZone)
			{
				TextMeshProUGUI obj3 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj3).text = ((TMP_Text)obj3).text + "ButtonPause" + TavernZonesManager.IECOPNFJBFD().GetCurrentNumberOfZones(ZoneType.DiningRoom);
				TextMeshProUGUI obj4 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj4).text = ((TMP_Text)obj4).text + " " + ReputationDBAccessor.GMACKHECLAF(ZoneType.WithoutZone | ZoneType.CraftingRoom) + "Error in CatRelationship.CheckRelationship: ";
			}
			else if (BANNHBMOAFH.editorAction == (EditorAction)111)
			{
				TextMeshProUGUI obj5 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj5).text = ((TMP_Text)obj5).text + "Dialogue System/Conversation/NeutralInTavern/Entry/11/Dialogue Text" + TavernZonesManager.EBAIHKJHCCA().GetCurrentNumberOfZones(ZoneType.WithoutZone | ZoneType.CraftingRoom);
				TextMeshProUGUI obj6 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj6).text = ((TMP_Text)obj6).text + "" + ReputationDBAccessor.FDICLJNDIOF(ZoneType.None) + "Dialogue System/Conversation/Gass_Quest/Entry/44/Dialogue Text";
			}
			((Component)GGFJGHHHEJC.currentActionSlot.icon).gameObject.SetActive(false);
			GGFJGHHHEJC.currentActionSlot.icon.FBJKMPKINBB(BANNHBMOAFH.icon);
			((TMP_Text)GGFJGHHHEJC.planksCost).text = BANNHBMOAFH.cost.planks.ToString();
			((TMP_Text)GGFJGHHHEJC.nailsCost).text = BANNHBMOAFH.cost.nails.ToString();
			((TMP_Text)GGFJGHHHEJC.stonesCost).text = BANNHBMOAFH.cost.stones.ToString();
			((TMP_Text)GGFJGHHHEJC.mortarCost).text = BANNHBMOAFH.cost.mortar.ToString();
			((TMP_Text)GGFJGHHHEJC.goldCost).text = BANNHBMOAFH.cost.FMNDONLEMHF().gold.ToString();
			((TMP_Text)GGFJGHHHEJC.silverCost).text = BANNHBMOAFH.cost.OEFOJKCKIOB().silver.ToString();
		}
		else
		{
			((TMP_Text)GGFJGHHHEJC.currentActionName).text = "Player Not Waiting To Start Event";
			((Component)GGFJGHHHEJC.currentActionSlot.icon).gameObject.SetActive(true);
			((TMP_Text)GGFJGHHHEJC.planksCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.nailsCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.stonesCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.mortarCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.goldCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.silverCost).text = 1.ToString();
		}
	}

	private void NMKGOAJLMDG()
	{
		GGFJGHHHEJC = this;
	}

	private void KLHIMJFCHPD()
	{
		GGFJGHHHEJC = this;
	}

	public static void UpdateCurrentEditorAction()
	{
		TavernConstructionAction editorActionInfo = ConstructionActionBarUI.GetEditorActionInfo();
		if ((Object)(object)editorActionInfo != (Object)null)
		{
			if (BuildingTutorialManager.IKNOJDMCFOK)
			{
				if (((BuildingPopUp)BuildingTutorialManager.GetCurrentPopUp()).actionsAvailable.Contains(editorActionInfo.editorAction))
				{
					ConstructionManager.current.CHFHMMNELGP = editorActionInfo.editorAction;
				}
				else
				{
					ConstructionManager.current.CHFHMMNELGP = EditorAction.None;
				}
			}
			else
			{
				ConstructionManager.current.CHFHMMNELGP = editorActionInfo.editorAction;
			}
		}
		else
		{
			ConstructionManager.current.CHFHMMNELGP = EditorAction.None;
		}
		if (TavernConstructionManager.GGFJGHHHEJC.LNLJMCONDNE && ConstructionActionBarUI.currentPanel == 1)
		{
			int currentSlotSelected = ConstructionActionBarUI.currentSlotSelected;
			int currentSlotPage = ConstructionActionBarUI.currentSlotPage;
			int num = ConstructionActionBarUI.GetInstance().uiSlots.Length;
			if (currentSlotSelected + currentSlotPage * num < TavernConstructionUI.GetConstructionActions().Count)
			{
				TavernConstructionManager.GGFJGHHHEJC.KJIGECBPBOD = (DecorationTile)TavernConstructionUI.GetConstructionActions()[currentSlotSelected + currentSlotPage * num];
			}
			else
			{
				TavernConstructionManager.GGFJGHHHEJC.KJIGECBPBOD = null;
			}
		}
		UpdateCurrentSlotInfo(editorActionInfo);
	}

	private void HNNBAAJAHEN()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static void NBLBOEFJEAH()
	{
		TavernConstructionAction editorActionInfo = ConstructionActionBarUI.GetEditorActionInfo();
		if ((Object)(object)editorActionInfo != (Object)null)
		{
			if (BuildingTutorialManager.KGJOKHEBLOJ())
			{
				if (((BuildingPopUp)BuildingTutorialManager.GetCurrentPopUp()).actionsAvailable.Contains(editorActionInfo.editorAction))
				{
					ConstructionManager.current.CHFHMMNELGP = editorActionInfo.editorAction;
				}
				else
				{
					ConstructionManager.current.CHFHMMNELGP = EditorAction.None;
				}
			}
			else
			{
				ConstructionManager.current.CHFHMMNELGP = editorActionInfo.editorAction;
			}
		}
		else
		{
			ConstructionManager.current.CHFHMMNELGP = EditorAction.AddFloor;
		}
		if (TavernConstructionManager.GGFJGHHHEJC.LNLJMCONDNE && ConstructionActionBarUI.currentPanel == 1)
		{
			int currentSlotSelected = ConstructionActionBarUI.currentSlotSelected;
			int currentSlotPage = ConstructionActionBarUI.currentSlotPage;
			int num = ConstructionActionBarUI.GetInstance().uiSlots.Length;
			if (currentSlotSelected + currentSlotPage * num < TavernConstructionUI.AJNDFOKAJBG().Count)
			{
				TavernConstructionManager.KHMEGDIABBF().LNDNAKNAHAK((DecorationTile)TavernConstructionUI.GetConstructionActions()[currentSlotSelected + currentSlotPage * num]);
			}
			else
			{
				TavernConstructionManager.KNLLFEJAMNN().GILEPDMMCNN(null);
			}
		}
		ALDLCHPPKHM(editorActionInfo);
	}

	private void FJBPFOIALMK()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static void DFJIABHEFDG(TavernConstructionAction BANNHBMOAFH)
	{
		if ((Object)(object)BANNHBMOAFH != (Object)null)
		{
			((TMP_Text)GGFJGHHHEJC.currentActionName).text = BANNHBMOAFH.JCOLBKMMJJM();
			if (BANNHBMOAFH.editorAction == EditorAction.None)
			{
				TextMeshProUGUI obj = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj).text = ((TMP_Text)obj).text + "Unsaved progress will be lost." + TavernZonesManager.LANAINBEMCM().KMBEHOBJGBL(ZoneType.DiningRoom | ZoneType.CraftingRoom);
				TextMeshProUGUI obj2 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj2).text = ((TMP_Text)obj2).text + "HeadToBed" + ReputationDBAccessor.FDICLJNDIOF(ZoneType.RentedRoom) + "Normal";
			}
			else if (BANNHBMOAFH.editorAction == EditorAction.AddFloorDisponible)
			{
				TextMeshProUGUI obj3 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj3).text = ((TMP_Text)obj3).text + "TavernServiceManager instance is null" + TavernZonesManager.HFHPMKJGMPA().GetCurrentNumberOfZones(ZoneType.WithoutZone | ZoneType.CraftingRoom);
				TextMeshProUGUI obj4 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj4).text = ((TMP_Text)obj4).text + "UI" + ReputationDBAccessor.GetMaxNumOfZones(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom) + "ToggleHideInfoSection";
			}
			else if (BANNHBMOAFH.editorAction == (EditorAction)(-12))
			{
				TextMeshProUGUI obj5 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj5).text = ((TMP_Text)obj5).text + "[SelectSpawnersByMaxDistance] Step {0}: Selected {1} at {2} with score {3:F1}" + TavernZonesManager.IECOPNFJBFD().HIIHFPLOEPA(ZoneType.WithoutZone | ZoneType.DiningRoom);
				TextMeshProUGUI obj6 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj6).text = ((TMP_Text)obj6).text + "Gass_Introduce" + ReputationDBAccessor.GMACKHECLAF(ZoneType.WithoutZone) + "Player/Bark/Tutorial/SleepBlock";
			}
			((Component)GGFJGHHHEJC.currentActionSlot.icon).gameObject.SetActive(true);
			GGFJGHHHEJC.currentActionSlot.icon.PCBMOCKFEHI(BANNHBMOAFH.icon);
			((TMP_Text)GGFJGHHHEJC.planksCost).text = BANNHBMOAFH.cost.planks.ToString();
			((TMP_Text)GGFJGHHHEJC.nailsCost).text = BANNHBMOAFH.cost.nails.ToString();
			((TMP_Text)GGFJGHHHEJC.stonesCost).text = BANNHBMOAFH.cost.stones.ToString();
			((TMP_Text)GGFJGHHHEJC.mortarCost).text = BANNHBMOAFH.cost.mortar.ToString();
			((TMP_Text)GGFJGHHHEJC.goldCost).text = BANNHBMOAFH.cost.PFHGPBLBCDD().gold.ToString();
			((TMP_Text)GGFJGHHHEJC.silverCost).text = BANNHBMOAFH.cost.FMNDONLEMHF().silver.ToString();
		}
		else
		{
			((TMP_Text)GGFJGHHHEJC.currentActionName).text = "cliffs";
			((Component)GGFJGHHHEJC.currentActionSlot.icon).gameObject.SetActive(false);
			((TMP_Text)GGFJGHHHEJC.planksCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.nailsCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.stonesCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.mortarCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.goldCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.silverCost).text = 0.ToString();
		}
	}

	public static void UpdateCurrentSlotInfo(TavernConstructionAction BANNHBMOAFH)
	{
		if ((Object)(object)BANNHBMOAFH != (Object)null)
		{
			((TMP_Text)GGFJGHHHEJC.currentActionName).text = BANNHBMOAFH.IABAKHPEOAF();
			if (BANNHBMOAFH.editorAction == EditorAction.DiningZone)
			{
				TextMeshProUGUI obj = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj).text = ((TMP_Text)obj).text + " (" + TavernZonesManager.GGFJGHHHEJC.GetCurrentNumberOfZones(ZoneType.DiningRoom);
				TextMeshProUGUI obj2 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj2).text = ((TMP_Text)obj2).text + "/" + ReputationDBAccessor.GetMaxNumOfZones(ZoneType.DiningRoom) + ")";
			}
			else if (BANNHBMOAFH.editorAction == EditorAction.CraftingZone)
			{
				TextMeshProUGUI obj3 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj3).text = ((TMP_Text)obj3).text + " (" + TavernZonesManager.GGFJGHHHEJC.GetCurrentNumberOfZones(ZoneType.CraftingRoom);
				TextMeshProUGUI obj4 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj4).text = ((TMP_Text)obj4).text + "/" + ReputationDBAccessor.GetMaxNumOfZones(ZoneType.CraftingRoom) + ")";
			}
			else if (BANNHBMOAFH.editorAction == EditorAction.CreateRentedRoomDoor)
			{
				TextMeshProUGUI obj5 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj5).text = ((TMP_Text)obj5).text + " (" + TavernZonesManager.GGFJGHHHEJC.GetCurrentNumberOfZones(ZoneType.RentedRoom);
				TextMeshProUGUI obj6 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj6).text = ((TMP_Text)obj6).text + "/" + ReputationDBAccessor.GetMaxNumOfZones(ZoneType.RentedRoom) + ")";
			}
			((Component)GGFJGHHHEJC.currentActionSlot.icon).gameObject.SetActive(true);
			GGFJGHHHEJC.currentActionSlot.icon.SetSprite(BANNHBMOAFH.icon);
			((TMP_Text)GGFJGHHHEJC.planksCost).text = BANNHBMOAFH.cost.planks.ToString();
			((TMP_Text)GGFJGHHHEJC.nailsCost).text = BANNHBMOAFH.cost.nails.ToString();
			((TMP_Text)GGFJGHHHEJC.stonesCost).text = BANNHBMOAFH.cost.stones.ToString();
			((TMP_Text)GGFJGHHHEJC.mortarCost).text = BANNHBMOAFH.cost.mortar.ToString();
			((TMP_Text)GGFJGHHHEJC.goldCost).text = BANNHBMOAFH.cost.PFHGPBLBCDD().gold.ToString();
			((TMP_Text)GGFJGHHHEJC.silverCost).text = BANNHBMOAFH.cost.PFHGPBLBCDD().silver.ToString();
		}
		else
		{
			((TMP_Text)GGFJGHHHEJC.currentActionName).text = "";
			((Component)GGFJGHHHEJC.currentActionSlot.icon).gameObject.SetActive(false);
			((TMP_Text)GGFJGHHHEJC.planksCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.nailsCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.stonesCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.mortarCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.goldCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.silverCost).text = 0.ToString();
		}
	}

	private void DKDLOBOLNFH()
	{
		GGFJGHHHEJC = this;
	}

	public static void MOCOJNMKEKI()
	{
		TavernConstructionAction editorActionInfo = ConstructionActionBarUI.GetEditorActionInfo();
		if ((Object)(object)editorActionInfo != (Object)null)
		{
			if (BuildingTutorialManager.IKNOJDMCFOK)
			{
				if (((BuildingPopUp)BuildingTutorialManager.FINEAEFBPLK()).actionsAvailable.Contains(editorActionInfo.editorAction))
				{
					ConstructionManager.current.CHFHMMNELGP = editorActionInfo.editorAction;
				}
				else
				{
					ConstructionManager.current.CHFHMMNELGP = EditorAction.AddFloor;
				}
			}
			else
			{
				ConstructionManager.current.CHFHMMNELGP = editorActionInfo.editorAction;
			}
		}
		else
		{
			ConstructionManager.current.CHFHMMNELGP = EditorAction.None;
		}
		if (TavernConstructionManager.KHMEGDIABBF().LNLJMCONDNE && ConstructionActionBarUI.currentPanel == 0)
		{
			int currentSlotSelected = ConstructionActionBarUI.currentSlotSelected;
			int currentSlotPage = ConstructionActionBarUI.currentSlotPage;
			int num = ConstructionActionBarUI.GetInstance().uiSlots.Length;
			if (currentSlotSelected + currentSlotPage * num < TavernConstructionUI.AJNDFOKAJBG().Count)
			{
				TavernConstructionManager.DOIKFJDLKJP().IDNPHFKDLEF((DecorationTile)TavernConstructionUI.AJNDFOKAJBG()[currentSlotSelected + currentSlotPage * num]);
			}
			else
			{
				TavernConstructionManager.DEGPIHEEFHJ().GILEPDMMCNN(null);
			}
		}
		LLCDJHLCOED(editorActionInfo);
	}

	private void IIPKPMPGLOL()
	{
		GGFJGHHHEJC = this;
	}

	public static void KGDHHPLKNPL(TavernConstructionAction BANNHBMOAFH)
	{
		if ((Object)(object)BANNHBMOAFH != (Object)null)
		{
			((TMP_Text)GGFJGHHHEJC.currentActionName).text = BANNHBMOAFH.BGPCOGANKNF();
			if (BANNHBMOAFH.editorAction == EditorAction.RoomZone)
			{
				TextMeshProUGUI obj = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj).text = ((TMP_Text)obj).text + "itemDripTray" + TavernZonesManager.JEEGOBGDLPE().KMBEHOBJGBL(ZoneType.WithoutZone);
				TextMeshProUGUI obj2 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj2).text = ((TMP_Text)obj2).text + "Dialogue System/Conversation/Gass_Quest/Entry/27/Dialogue Text" + ReputationDBAccessor.FDICLJNDIOF(ZoneType.None) + "UIPreviousCategory";
			}
			else if (BANNHBMOAFH.editorAction == EditorAction.AddFloor)
			{
				TextMeshProUGUI obj3 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj3).text = ((TMP_Text)obj3).text + "ReceiveResetAllTalents" + TavernZonesManager.OIJLJKLMCBO().AEJKMLKKEME(ZoneType.WithoutZone | ZoneType.CraftingRoom);
				TextMeshProUGUI obj4 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj4).text = ((TMP_Text)obj4).text + "<sprite name=" + ReputationDBAccessor.GMACKHECLAF(ZoneType.CraftingRoom) + "Loop";
			}
			else if (BANNHBMOAFH.editorAction == (EditorAction)38)
			{
				TextMeshProUGUI obj5 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj5).text = ((TMP_Text)obj5).text + "Minigame" + TavernZonesManager.EBAIHKJHCCA().AEJKMLKKEME(ZoneType.None);
				TextMeshProUGUI obj6 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj6).text = ((TMP_Text)obj6).text + "Error_OccupiedRoom" + ReputationDBAccessor.FDICLJNDIOF(ZoneType.CraftingRoom) + "talents";
			}
			((Component)GGFJGHHHEJC.currentActionSlot.icon).gameObject.SetActive(true);
			GGFJGHHHEJC.currentActionSlot.icon.BKACANFNHMH(BANNHBMOAFH.icon);
			((TMP_Text)GGFJGHHHEJC.planksCost).text = BANNHBMOAFH.cost.planks.ToString();
			((TMP_Text)GGFJGHHHEJC.nailsCost).text = BANNHBMOAFH.cost.nails.ToString();
			((TMP_Text)GGFJGHHHEJC.stonesCost).text = BANNHBMOAFH.cost.stones.ToString();
			((TMP_Text)GGFJGHHHEJC.mortarCost).text = BANNHBMOAFH.cost.mortar.ToString();
			((TMP_Text)GGFJGHHHEJC.goldCost).text = BANNHBMOAFH.cost.BOGHMFGPOAP().gold.ToString();
			((TMP_Text)GGFJGHHHEJC.silverCost).text = BANNHBMOAFH.cost.BOGHMFGPOAP().silver.ToString();
		}
		else
		{
			((TMP_Text)GGFJGHHHEJC.currentActionName).text = "MineFloor";
			((Component)GGFJGHHHEJC.currentActionSlot.icon).gameObject.SetActive(true);
			((TMP_Text)GGFJGHHHEJC.planksCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.nailsCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.stonesCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.mortarCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.goldCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.silverCost).text = 0.ToString();
		}
	}

	private void AGLMGDNBHBF()
	{
		GGFJGHHHEJC = this;
	}

	public static void POMAHFLLGLK()
	{
		TavernConstructionAction tavernConstructionAction = ConstructionActionBarUI.OCLKNDBIOFM();
		if ((Object)(object)tavernConstructionAction != (Object)null)
		{
			if (BuildingTutorialManager.KGJOKHEBLOJ())
			{
				if (((BuildingPopUp)BuildingTutorialManager.GetCurrentPopUp()).actionsAvailable.Contains(tavernConstructionAction.editorAction))
				{
					ConstructionManager.current.CHFHMMNELGP = tavernConstructionAction.editorAction;
				}
				else
				{
					ConstructionManager.current.CHFHMMNELGP = EditorAction.AddFloor;
				}
			}
			else
			{
				ConstructionManager.current.CHFHMMNELGP = tavernConstructionAction.editorAction;
			}
		}
		else
		{
			ConstructionManager.current.CHFHMMNELGP = EditorAction.None;
		}
		if (TavernConstructionManager.KHMEGDIABBF().LNLJMCONDNE && ConstructionActionBarUI.currentPanel == 1)
		{
			int currentSlotSelected = ConstructionActionBarUI.currentSlotSelected;
			int currentSlotPage = ConstructionActionBarUI.currentSlotPage;
			int num = ConstructionActionBarUI.GetInstance().uiSlots.Length;
			if (currentSlotSelected + currentSlotPage * num < TavernConstructionUI.PCFNIELMCLN().Count)
			{
				TavernConstructionManager.DEGPIHEEFHJ().KJIGECBPBOD = (DecorationTile)TavernConstructionUI.IOIHCFPGEFC()[currentSlotSelected + currentSlotPage * num];
			}
			else
			{
				TavernConstructionManager.KNLLFEJAMNN().LNDNAKNAHAK(null);
			}
		}
		JECPODDGBNA(tavernConstructionAction);
	}

	private void EFCNKPEPELL()
	{
		GGFJGHHHEJC = this;
	}

	public static void ENLENBPBFNN()
	{
		TavernConstructionAction tavernConstructionAction = ConstructionActionBarUI.OCLKNDBIOFM();
		if ((Object)(object)tavernConstructionAction != (Object)null)
		{
			if (BuildingTutorialManager.KGJOKHEBLOJ())
			{
				if (((BuildingPopUp)BuildingTutorialManager.FINEAEFBPLK()).actionsAvailable.Contains(tavernConstructionAction.editorAction))
				{
					ConstructionManager.current.CHFHMMNELGP = tavernConstructionAction.editorAction;
				}
				else
				{
					ConstructionManager.current.CHFHMMNELGP = EditorAction.None;
				}
			}
			else
			{
				ConstructionManager.current.CHFHMMNELGP = tavernConstructionAction.editorAction;
			}
		}
		else
		{
			ConstructionManager.current.CHFHMMNELGP = EditorAction.None;
		}
		if (TavernConstructionManager.KHMEGDIABBF().LNLJMCONDNE && ConstructionActionBarUI.currentPanel == 0)
		{
			int currentSlotSelected = ConstructionActionBarUI.currentSlotSelected;
			int currentSlotPage = ConstructionActionBarUI.currentSlotPage;
			int num = ConstructionActionBarUI.GetInstance().uiSlots.Length;
			if (currentSlotSelected + currentSlotPage * num < TavernConstructionUI.GetConstructionActions().Count)
			{
				TavernConstructionManager.KHMEGDIABBF().GILEPDMMCNN((DecorationTile)TavernConstructionUI.PCFNIELMCLN()[currentSlotSelected + currentSlotPage * num]);
			}
			else
			{
				TavernConstructionManager.DOIKFJDLKJP().KJIGECBPBOD = null;
			}
		}
		UpdateCurrentSlotInfo(tavernConstructionAction);
	}

	public static void PBPNGADPJLI(TavernConstructionAction BANNHBMOAFH)
	{
		if ((Object)(object)BANNHBMOAFH != (Object)null)
		{
			((TMP_Text)GGFJGHHHEJC.currentActionName).text = BANNHBMOAFH.GHJLPCCHDJO();
			if (BANNHBMOAFH.editorAction == EditorAction.DiningZone)
			{
				TextMeshProUGUI obj = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj).text = ((TMP_Text)obj).text + "itemAvocadoSeeds" + TavernZonesManager.OIJLJKLMCBO().GetCurrentNumberOfZones(ZoneType.WithoutZone);
				TextMeshProUGUI obj2 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj2).text = ((TMP_Text)obj2).text + "Error_UnableToBeReached" + ReputationDBAccessor.GMACKHECLAF(ZoneType.RentedRoom) + "Crafters";
			}
			else if (BANNHBMOAFH.editorAction == EditorAction.AddFloorDisponible)
			{
				TextMeshProUGUI obj3 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj3).text = ((TMP_Text)obj3).text + "Failed to create a new game to host because a game with the same name already exists.\nPlease try again later." + TavernZonesManager.NHKAFANMEJC().GetCurrentNumberOfZones(ZoneType.RentedRoom);
				TextMeshProUGUI obj4 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj4).text = ((TMP_Text)obj4).text + "Press {0} to continue" + ReputationDBAccessor.GMACKHECLAF(ZoneType.WithoutZone | ZoneType.DiningRoom) + "UI";
			}
			else if (BANNHBMOAFH.editorAction == (EditorAction)(-10))
			{
				TextMeshProUGUI obj5 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj5).text = ((TMP_Text)obj5).text + "Open Calendar" + TavernZonesManager.JEEGOBGDLPE().GetCurrentNumberOfZones(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom);
				TextMeshProUGUI obj6 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj6).text = ((TMP_Text)obj6).text + "BuildMode" + ReputationDBAccessor.GetMaxNumOfZones(ZoneType.WithoutZone) + "Water Bowl";
			}
			((Component)GGFJGHHHEJC.currentActionSlot.icon).gameObject.SetActive(true);
			GGFJGHHHEJC.currentActionSlot.icon.BKDLIMOMKEB(BANNHBMOAFH.icon);
			((TMP_Text)GGFJGHHHEJC.planksCost).text = BANNHBMOAFH.cost.planks.ToString();
			((TMP_Text)GGFJGHHHEJC.nailsCost).text = BANNHBMOAFH.cost.nails.ToString();
			((TMP_Text)GGFJGHHHEJC.stonesCost).text = BANNHBMOAFH.cost.stones.ToString();
			((TMP_Text)GGFJGHHHEJC.mortarCost).text = BANNHBMOAFH.cost.mortar.ToString();
			((TMP_Text)GGFJGHHHEJC.goldCost).text = BANNHBMOAFH.cost.FMNDONLEMHF().gold.ToString();
			((TMP_Text)GGFJGHHHEJC.silverCost).text = BANNHBMOAFH.cost.BOGHMFGPOAP().silver.ToString();
		}
		else
		{
			((TMP_Text)GGFJGHHHEJC.currentActionName).text = "distillingRepUnlock";
			((Component)GGFJGHHHEJC.currentActionSlot.icon).gameObject.SetActive(true);
			((TMP_Text)GGFJGHHHEJC.planksCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.nailsCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.stonesCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.mortarCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.goldCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.silverCost).text = 0.ToString();
		}
	}

	public static void GCMEDALACPO()
	{
		TavernConstructionAction editorActionInfo = ConstructionActionBarUI.GetEditorActionInfo();
		if ((Object)(object)editorActionInfo != (Object)null)
		{
			if (BuildingTutorialManager.PABJKGJJHFG())
			{
				if (((BuildingPopUp)BuildingTutorialManager.GetCurrentPopUp()).actionsAvailable.Contains(editorActionInfo.editorAction))
				{
					ConstructionManager.current.CHFHMMNELGP = editorActionInfo.editorAction;
				}
				else
				{
					ConstructionManager.current.CHFHMMNELGP = EditorAction.AddFloor;
				}
			}
			else
			{
				ConstructionManager.current.CHFHMMNELGP = editorActionInfo.editorAction;
			}
		}
		else
		{
			ConstructionManager.current.CHFHMMNELGP = EditorAction.AddFloor;
		}
		if (TavernConstructionManager.KHMEGDIABBF().LNLJMCONDNE && ConstructionActionBarUI.currentPanel == 1)
		{
			int currentSlotSelected = ConstructionActionBarUI.currentSlotSelected;
			int currentSlotPage = ConstructionActionBarUI.currentSlotPage;
			int num = ConstructionActionBarUI.GetInstance().uiSlots.Length;
			if (currentSlotSelected + currentSlotPage * num < TavernConstructionUI.GetConstructionActions().Count)
			{
				TavernConstructionManager.KHMEGDIABBF().GILEPDMMCNN((DecorationTile)TavernConstructionUI.IOIHCFPGEFC()[currentSlotSelected + currentSlotPage * num]);
			}
			else
			{
				TavernConstructionManager.GGFJGHHHEJC.GILEPDMMCNN(null);
			}
		}
		JHFKIIKIICO(editorActionInfo);
	}

	public static void IJAOECOMHHP(TavernConstructionAction BANNHBMOAFH)
	{
		if ((Object)(object)BANNHBMOAFH != (Object)null)
		{
			((TMP_Text)GGFJGHHHEJC.currentActionName).text = BANNHBMOAFH.KHGEECPHPMO();
			if (BANNHBMOAFH.editorAction == EditorAction.RemoveFloorDisponible)
			{
				TextMeshProUGUI obj = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj).text = ((TMP_Text)obj).text + "Close" + TavernZonesManager.GGFJGHHHEJC.KMBEHOBJGBL(ZoneType.RentedRoom);
				TextMeshProUGUI obj2 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj2).text = ((TMP_Text)obj2).text + "-" + ReputationDBAccessor.GMACKHECLAF(ZoneType.WithoutZone | ZoneType.DiningRoom) + "Gameplay";
			}
			else if (BANNHBMOAFH.editorAction == EditorAction.AddFloor)
			{
				TextMeshProUGUI obj3 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj3).text = ((TMP_Text)obj3).text + "DontWalk2" + TavernZonesManager.NHKAFANMEJC().HIIHFPLOEPA(ZoneType.DiningRoom | ZoneType.CraftingRoom);
				TextMeshProUGUI obj4 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj4).text = ((TMP_Text)obj4).text + "Walk" + ReputationDBAccessor.GMACKHECLAF(ZoneType.WithoutZone | ZoneType.DiningRoom) + "Sharp";
			}
			else if (BANNHBMOAFH.editorAction == (EditorAction)66)
			{
				TextMeshProUGUI obj5 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj5).text = ((TMP_Text)obj5).text + "Hat" + TavernZonesManager.JEEGOBGDLPE().GetCurrentNumberOfZones(ZoneType.WithoutZone | ZoneType.CraftingRoom);
				TextMeshProUGUI obj6 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj6).text = ((TMP_Text)obj6).text + "Collect water" + ReputationDBAccessor.GMACKHECLAF(ZoneType.WithoutZone | ZoneType.CraftingRoom) + "add item ";
			}
			((Component)GGFJGHHHEJC.currentActionSlot.icon).gameObject.SetActive(false);
			GGFJGHHHEJC.currentActionSlot.icon.IEGBEHMDAEL(BANNHBMOAFH.icon);
			((TMP_Text)GGFJGHHHEJC.planksCost).text = BANNHBMOAFH.cost.planks.ToString();
			((TMP_Text)GGFJGHHHEJC.nailsCost).text = BANNHBMOAFH.cost.nails.ToString();
			((TMP_Text)GGFJGHHHEJC.stonesCost).text = BANNHBMOAFH.cost.stones.ToString();
			((TMP_Text)GGFJGHHHEJC.mortarCost).text = BANNHBMOAFH.cost.mortar.ToString();
			((TMP_Text)GGFJGHHHEJC.goldCost).text = BANNHBMOAFH.cost.FMNDONLEMHF().gold.ToString();
			((TMP_Text)GGFJGHHHEJC.silverCost).text = BANNHBMOAFH.cost.FMNDONLEMHF().silver.ToString();
		}
		else
		{
			((TMP_Text)GGFJGHHHEJC.currentActionName).text = "Game Over! ";
			((Component)GGFJGHHHEJC.currentActionSlot.icon).gameObject.SetActive(false);
			((TMP_Text)GGFJGHHHEJC.planksCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.nailsCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.stonesCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.mortarCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.goldCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.silverCost).text = 1.ToString();
		}
	}

	public static void KOFMOHEEKEL(TavernConstructionAction BANNHBMOAFH)
	{
		if ((Object)(object)BANNHBMOAFH != (Object)null)
		{
			((TMP_Text)GGFJGHHHEJC.currentActionName).text = BANNHBMOAFH.OOCFLCEHNEH();
			if (BANNHBMOAFH.editorAction == EditorAction.AddFloor)
			{
				TextMeshProUGUI obj = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj).text = ((TMP_Text)obj).text + "Submit text: " + TavernZonesManager.NHKAFANMEJC().KMBEHOBJGBL(ZoneType.WithoutZone | ZoneType.CraftingRoom);
				TextMeshProUGUI obj2 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj2).text = ((TMP_Text)obj2).text + "</color> to inventory?" + ReputationDBAccessor.FDICLJNDIOF(ZoneType.DiningRoom | ZoneType.CraftingRoom) + " aging rank (";
			}
			else if (BANNHBMOAFH.editorAction == EditorAction.AddFloorDisponible)
			{
				TextMeshProUGUI obj3 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj3).text = ((TMP_Text)obj3).text + "Writing file " + TavernZonesManager.IECOPNFJBFD().AEJKMLKKEME(ZoneType.None);
				TextMeshProUGUI obj4 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj4).text = ((TMP_Text)obj4).text + "- " + ReputationDBAccessor.GetMaxNumOfZones(ZoneType.None) + "Sleep";
			}
			else if (BANNHBMOAFH.editorAction == (EditorAction)(-31))
			{
				TextMeshProUGUI obj5 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj5).text = ((TMP_Text)obj5).text + "VerticalMove" + TavernZonesManager.OIJLJKLMCBO().LHLOHOMKPMG(ZoneType.WithoutZone | ZoneType.CraftingRoom);
				TextMeshProUGUI obj6 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj6).text = ((TMP_Text)obj6).text + "0" + ReputationDBAccessor.FDICLJNDIOF(ZoneType.WithoutZone | ZoneType.CraftingRoom) + "On Simple Event ";
			}
			((Component)GGFJGHHHEJC.currentActionSlot.icon).gameObject.SetActive(false);
			GGFJGHHHEJC.currentActionSlot.icon.CIDGNCHMDGC(BANNHBMOAFH.icon);
			((TMP_Text)GGFJGHHHEJC.planksCost).text = BANNHBMOAFH.cost.planks.ToString();
			((TMP_Text)GGFJGHHHEJC.nailsCost).text = BANNHBMOAFH.cost.nails.ToString();
			((TMP_Text)GGFJGHHHEJC.stonesCost).text = BANNHBMOAFH.cost.stones.ToString();
			((TMP_Text)GGFJGHHHEJC.mortarCost).text = BANNHBMOAFH.cost.mortar.ToString();
			((TMP_Text)GGFJGHHHEJC.goldCost).text = BANNHBMOAFH.cost.OEFOJKCKIOB().gold.ToString();
			((TMP_Text)GGFJGHHHEJC.silverCost).text = BANNHBMOAFH.cost.BOGHMFGPOAP().silver.ToString();
		}
		else
		{
			((TMP_Text)GGFJGHHHEJC.currentActionName).text = "Items/item_description_654";
			((Component)GGFJGHHHEJC.currentActionSlot.icon).gameObject.SetActive(false);
			((TMP_Text)GGFJGHHHEJC.planksCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.nailsCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.stonesCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.mortarCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.goldCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.silverCost).text = 0.ToString();
		}
	}

	public static void JECPODDGBNA(TavernConstructionAction BANNHBMOAFH)
	{
		if ((Object)(object)BANNHBMOAFH != (Object)null)
		{
			((TMP_Text)GGFJGHHHEJC.currentActionName).text = BANNHBMOAFH.HKDMHHCCMJC();
			if (BANNHBMOAFH.editorAction == EditorAction.ZoneDisponible)
			{
				TextMeshProUGUI obj = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj).text = ((TMP_Text)obj).text + "LeftMouseDetect" + TavernZonesManager.JEEGOBGDLPE().AEJKMLKKEME(ZoneType.None);
				TextMeshProUGUI obj2 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj2).text = ((TMP_Text)obj2).text + "Idle" + ReputationDBAccessor.GMACKHECLAF(ZoneType.WithoutZone | ZoneType.CraftingRoom) + "LE_14";
			}
			else if (BANNHBMOAFH.editorAction == EditorAction.ZoneDisponible)
			{
				TextMeshProUGUI obj3 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj3).text = ((TMP_Text)obj3).text + "Unaged Swiss" + TavernZonesManager.OIJLJKLMCBO().HIIHFPLOEPA(ZoneType.None);
				TextMeshProUGUI obj4 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj4).text = ((TMP_Text)obj4).text + "Could not get value of statistic " + ReputationDBAccessor.GMACKHECLAF(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom) + "UIBack";
			}
			else if (BANNHBMOAFH.editorAction == (EditorAction)(-51))
			{
				TextMeshProUGUI obj5 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj5).text = ((TMP_Text)obj5).text + "xpModDescBartending" + TavernZonesManager.HFHPMKJGMPA().HIIHFPLOEPA(ZoneType.None);
				TextMeshProUGUI obj6 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj6).text = ((TMP_Text)obj6).text + " " + ReputationDBAccessor.FDICLJNDIOF(ZoneType.DiningRoom) + "Tutorial/T128/Dialogue1";
			}
			((Component)GGFJGHHHEJC.currentActionSlot.icon).gameObject.SetActive(true);
			GGFJGHHHEJC.currentActionSlot.icon.SetSprite(BANNHBMOAFH.icon);
			((TMP_Text)GGFJGHHHEJC.planksCost).text = BANNHBMOAFH.cost.planks.ToString();
			((TMP_Text)GGFJGHHHEJC.nailsCost).text = BANNHBMOAFH.cost.nails.ToString();
			((TMP_Text)GGFJGHHHEJC.stonesCost).text = BANNHBMOAFH.cost.stones.ToString();
			((TMP_Text)GGFJGHHHEJC.mortarCost).text = BANNHBMOAFH.cost.mortar.ToString();
			((TMP_Text)GGFJGHHHEJC.goldCost).text = BANNHBMOAFH.cost.PFHGPBLBCDD().gold.ToString();
			((TMP_Text)GGFJGHHHEJC.silverCost).text = BANNHBMOAFH.cost.FMNDONLEMHF().silver.ToString();
		}
		else
		{
			((TMP_Text)GGFJGHHHEJC.currentActionName).text = "0";
			((Component)GGFJGHHHEJC.currentActionSlot.icon).gameObject.SetActive(false);
			((TMP_Text)GGFJGHHHEJC.planksCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.nailsCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.stonesCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.mortarCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.goldCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.silverCost).text = 0.ToString();
		}
	}

	public static void CEJIJDOLAEF()
	{
		TavernConstructionAction editorActionInfo = ConstructionActionBarUI.GetEditorActionInfo();
		if ((Object)(object)editorActionInfo != (Object)null)
		{
			if (BuildingTutorialManager.PABJKGJJHFG())
			{
				if (((BuildingPopUp)BuildingTutorialManager.GetCurrentPopUp()).actionsAvailable.Contains(editorActionInfo.editorAction))
				{
					ConstructionManager.current.CHFHMMNELGP = editorActionInfo.editorAction;
				}
				else
				{
					ConstructionManager.current.CHFHMMNELGP = EditorAction.None;
				}
			}
			else
			{
				ConstructionManager.current.CHFHMMNELGP = editorActionInfo.editorAction;
			}
		}
		else
		{
			ConstructionManager.current.CHFHMMNELGP = EditorAction.AddFloor;
		}
		if (TavernConstructionManager.DEGPIHEEFHJ().LNLJMCONDNE && ConstructionActionBarUI.currentPanel == 0)
		{
			int currentSlotSelected = ConstructionActionBarUI.currentSlotSelected;
			int currentSlotPage = ConstructionActionBarUI.currentSlotPage;
			int num = ConstructionActionBarUI.GetInstance().uiSlots.Length;
			if (currentSlotSelected + currentSlotPage * num < TavernConstructionUI.IOIHCFPGEFC().Count)
			{
				TavernConstructionManager.KNLLFEJAMNN().IDNPHFKDLEF((DecorationTile)TavernConstructionUI.AJNDFOKAJBG()[currentSlotSelected + currentSlotPage * num]);
			}
			else
			{
				TavernConstructionManager.KNLLFEJAMNN().KJIGECBPBOD = null;
			}
		}
		UpdateCurrentSlotInfo(editorActionInfo);
	}

	public static void JHFKIIKIICO(TavernConstructionAction BANNHBMOAFH)
	{
		if ((Object)(object)BANNHBMOAFH != (Object)null)
		{
			((TMP_Text)GGFJGHHHEJC.currentActionName).text = BANNHBMOAFH.JLEFCPJPOEO();
			if (BANNHBMOAFH.editorAction == EditorAction.CraftingZone)
			{
				TextMeshProUGUI obj = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj).text = ((TMP_Text)obj).text + "Dialogue System/Conversation/EnterTavernDrink/Entry/5/Dialogue Text" + TavernZonesManager.IECOPNFJBFD().GetCurrentNumberOfZones(ZoneType.None);
				TextMeshProUGUI obj2 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj2).text = ((TMP_Text)obj2).text + "Stay" + ReputationDBAccessor.FDICLJNDIOF(ZoneType.DiningRoom) + "cameraZoom";
			}
			else if (BANNHBMOAFH.editorAction == EditorAction.None)
			{
				TextMeshProUGUI obj3 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj3).text = ((TMP_Text)obj3).text + "FarmReady" + TavernZonesManager.EBAIHKJHCCA().KMBEHOBJGBL(ZoneType.CraftingRoom);
				TextMeshProUGUI obj4 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj4).text = ((TMP_Text)obj4).text + "UI" + ReputationDBAccessor.FDICLJNDIOF(ZoneType.CraftingRoom) + "talent_name_116";
			}
			else if (BANNHBMOAFH.editorAction == (EditorAction)115)
			{
				TextMeshProUGUI obj5 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj5).text = ((TMP_Text)obj5).text + "dog " + TavernZonesManager.EBAIHKJHCCA().GetCurrentNumberOfZones(ZoneType.DiningRoom | ZoneType.CraftingRoom);
				TextMeshProUGUI obj6 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj6).text = ((TMP_Text)obj6).text + "itemChilliSeeds" + ReputationDBAccessor.GMACKHECLAF(ZoneType.DiningRoom | ZoneType.CraftingRoom) + "Pause";
			}
			((Component)GGFJGHHHEJC.currentActionSlot.icon).gameObject.SetActive(true);
			GGFJGHHHEJC.currentActionSlot.icon.PCBMOCKFEHI(BANNHBMOAFH.icon);
			((TMP_Text)GGFJGHHHEJC.planksCost).text = BANNHBMOAFH.cost.planks.ToString();
			((TMP_Text)GGFJGHHHEJC.nailsCost).text = BANNHBMOAFH.cost.nails.ToString();
			((TMP_Text)GGFJGHHHEJC.stonesCost).text = BANNHBMOAFH.cost.stones.ToString();
			((TMP_Text)GGFJGHHHEJC.mortarCost).text = BANNHBMOAFH.cost.mortar.ToString();
			((TMP_Text)GGFJGHHHEJC.goldCost).text = BANNHBMOAFH.cost.BOGHMFGPOAP().gold.ToString();
			((TMP_Text)GGFJGHHHEJC.silverCost).text = BANNHBMOAFH.cost.OEFOJKCKIOB().silver.ToString();
		}
		else
		{
			((TMP_Text)GGFJGHHHEJC.currentActionName).text = "Hurt";
			((Component)GGFJGHHHEJC.currentActionSlot.icon).gameObject.SetActive(false);
			((TMP_Text)GGFJGHHHEJC.planksCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.nailsCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.stonesCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.mortarCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.goldCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.silverCost).text = 0.ToString();
		}
	}

	public static void DLIJCLOJIIE()
	{
		TavernConstructionAction editorActionInfo = ConstructionActionBarUI.GetEditorActionInfo();
		if ((Object)(object)editorActionInfo != (Object)null)
		{
			if (BuildingTutorialManager.PABJKGJJHFG())
			{
				if (((BuildingPopUp)BuildingTutorialManager.GetCurrentPopUp()).actionsAvailable.Contains(editorActionInfo.editorAction))
				{
					ConstructionManager.current.CHFHMMNELGP = editorActionInfo.editorAction;
				}
				else
				{
					ConstructionManager.current.CHFHMMNELGP = EditorAction.AddFloor;
				}
			}
			else
			{
				ConstructionManager.current.CHFHMMNELGP = editorActionInfo.editorAction;
			}
		}
		else
		{
			ConstructionManager.current.CHFHMMNELGP = EditorAction.AddFloor;
		}
		if (TavernConstructionManager.KHMEGDIABBF().LNLJMCONDNE && ConstructionActionBarUI.currentPanel == 0)
		{
			int currentSlotSelected = ConstructionActionBarUI.currentSlotSelected;
			int currentSlotPage = ConstructionActionBarUI.currentSlotPage;
			int num = ConstructionActionBarUI.GetInstance().uiSlots.Length;
			if (currentSlotSelected + currentSlotPage * num < TavernConstructionUI.IOIHCFPGEFC().Count)
			{
				TavernConstructionManager.KHMEGDIABBF().GILEPDMMCNN((DecorationTile)TavernConstructionUI.AJNDFOKAJBG()[currentSlotSelected + currentSlotPage * num]);
			}
			else
			{
				TavernConstructionManager.DOIKFJDLKJP().LNDNAKNAHAK(null);
			}
		}
		ALDLCHPPKHM(editorActionInfo);
	}

	private void OGEJKOIOKAN()
	{
		GGFJGHHHEJC = this;
	}

	private void HCCJBKKGCLJ()
	{
		GGFJGHHHEJC = this;
	}

	public static void ABHABINJPCE(TavernConstructionAction BANNHBMOAFH)
	{
		if ((Object)(object)BANNHBMOAFH != (Object)null)
		{
			((TMP_Text)GGFJGHHHEJC.currentActionName).text = BANNHBMOAFH.GDBLECDHLHF();
			if (BANNHBMOAFH.editorAction == EditorAction.RemoveFloor)
			{
				TextMeshProUGUI obj = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj).text = ((TMP_Text)obj).text + "\"" + TavernZonesManager.NHKAFANMEJC().GetCurrentNumberOfZones(ZoneType.WithoutZone | ZoneType.CraftingRoom);
				TextMeshProUGUI obj2 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj2).text = ((TMP_Text)obj2).text + "]" + ReputationDBAccessor.FDICLJNDIOF(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom) + "HorizontalMove";
			}
			else if (BANNHBMOAFH.editorAction == EditorAction.AddFloorDisponible)
			{
				TextMeshProUGUI obj3 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj3).text = ((TMP_Text)obj3).text + "Cat" + TavernZonesManager.NHKAFANMEJC().GetCurrentNumberOfZones(ZoneType.CraftingRoom);
				TextMeshProUGUI obj4 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj4).text = ((TMP_Text)obj4).text + "Dialogue System/Conversation/Crowly_Standar/Entry/39/Dialogue Text" + ReputationDBAccessor.FDICLJNDIOF(ZoneType.WithoutZone | ZoneType.CraftingRoom) + "Trying to add player but player list is full.";
			}
			else if (BANNHBMOAFH.editorAction == (EditorAction)95)
			{
				TextMeshProUGUI obj5 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj5).text = ((TMP_Text)obj5).text + "unlock all recipes" + TavernZonesManager.OIJLJKLMCBO().HIIHFPLOEPA(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom);
				TextMeshProUGUI obj6 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj6).text = ((TMP_Text)obj6).text + "Dialogue System/Conversation/Gass_Introduce/Entry/15/Dialogue Text" + ReputationDBAccessor.FDICLJNDIOF(ZoneType.DiningRoom | ZoneType.CraftingRoom) + " (";
			}
			((Component)GGFJGHHHEJC.currentActionSlot.icon).gameObject.SetActive(false);
			GGFJGHHHEJC.currentActionSlot.icon.SetSprite(BANNHBMOAFH.icon);
			((TMP_Text)GGFJGHHHEJC.planksCost).text = BANNHBMOAFH.cost.planks.ToString();
			((TMP_Text)GGFJGHHHEJC.nailsCost).text = BANNHBMOAFH.cost.nails.ToString();
			((TMP_Text)GGFJGHHHEJC.stonesCost).text = BANNHBMOAFH.cost.stones.ToString();
			((TMP_Text)GGFJGHHHEJC.mortarCost).text = BANNHBMOAFH.cost.mortar.ToString();
			((TMP_Text)GGFJGHHHEJC.goldCost).text = BANNHBMOAFH.cost.FMNDONLEMHF().gold.ToString();
			((TMP_Text)GGFJGHHHEJC.silverCost).text = BANNHBMOAFH.cost.OEFOJKCKIOB().silver.ToString();
		}
		else
		{
			((TMP_Text)GGFJGHHHEJC.currentActionName).text = "Select";
			((Component)GGFJGHHHEJC.currentActionSlot.icon).gameObject.SetActive(true);
			((TMP_Text)GGFJGHHHEJC.planksCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.nailsCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.stonesCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.mortarCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.goldCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.silverCost).text = 0.ToString();
		}
	}

	public static void NADCFLFDNDN(TavernConstructionAction BANNHBMOAFH)
	{
		if ((Object)(object)BANNHBMOAFH != (Object)null)
		{
			((TMP_Text)GGFJGHHHEJC.currentActionName).text = BANNHBMOAFH.NAMHLLJOPAI();
			if (BANNHBMOAFH.editorAction == EditorAction.ZoneDisponible)
			{
				TextMeshProUGUI obj = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj).text = ((TMP_Text)obj).text + "SwitchFood" + TavernZonesManager.HFHPMKJGMPA().KMBEHOBJGBL(ZoneType.WithoutZone | ZoneType.DiningRoom);
				TextMeshProUGUI obj2 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj2).text = ((TMP_Text)obj2).text + "RentedRoom" + ReputationDBAccessor.GMACKHECLAF(ZoneType.DiningRoom) + "OneShotVolume";
			}
			else if (BANNHBMOAFH.editorAction == EditorAction.CraftingZone)
			{
				TextMeshProUGUI obj3 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj3).text = ((TMP_Text)obj3).text + "ReceiveUpdateDrinkColorTable" + TavernZonesManager.LANAINBEMCM().GetCurrentNumberOfZones(ZoneType.CraftingRoom);
				TextMeshProUGUI obj4 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj4).text = ((TMP_Text)obj4).text + "GuestConnecting" + ReputationDBAccessor.FDICLJNDIOF(ZoneType.None) + "Granting item ";
			}
			else if (BANNHBMOAFH.editorAction == (EditorAction)111)
			{
				TextMeshProUGUI obj5 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj5).text = ((TMP_Text)obj5).text + "Month" + TavernZonesManager.EBAIHKJHCCA().GetCurrentNumberOfZones(ZoneType.DiningRoom);
				TextMeshProUGUI obj6 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj6).text = ((TMP_Text)obj6).text + "itemDragonFruitSeeds" + ReputationDBAccessor.GetMaxNumOfZones(ZoneType.CraftingRoom) + " ";
			}
			((Component)GGFJGHHHEJC.currentActionSlot.icon).gameObject.SetActive(true);
			GGFJGHHHEJC.currentActionSlot.icon.JKDAHFEIJHA(BANNHBMOAFH.icon);
			((TMP_Text)GGFJGHHHEJC.planksCost).text = BANNHBMOAFH.cost.planks.ToString();
			((TMP_Text)GGFJGHHHEJC.nailsCost).text = BANNHBMOAFH.cost.nails.ToString();
			((TMP_Text)GGFJGHHHEJC.stonesCost).text = BANNHBMOAFH.cost.stones.ToString();
			((TMP_Text)GGFJGHHHEJC.mortarCost).text = BANNHBMOAFH.cost.mortar.ToString();
			((TMP_Text)GGFJGHHHEJC.goldCost).text = BANNHBMOAFH.cost.BOGHMFGPOAP().gold.ToString();
			((TMP_Text)GGFJGHHHEJC.silverCost).text = BANNHBMOAFH.cost.BOGHMFGPOAP().silver.ToString();
		}
		else
		{
			((TMP_Text)GGFJGHHHEJC.currentActionName).text = "</color>";
			((Component)GGFJGHHHEJC.currentActionSlot.icon).gameObject.SetActive(true);
			((TMP_Text)GGFJGHHHEJC.planksCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.nailsCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.stonesCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.mortarCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.goldCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.silverCost).text = 1.ToString();
		}
	}

	public static void LEFLEPJENNG()
	{
		TavernConstructionAction tavernConstructionAction = ConstructionActionBarUI.OCLKNDBIOFM();
		if ((Object)(object)tavernConstructionAction != (Object)null)
		{
			if (BuildingTutorialManager.KGJOKHEBLOJ())
			{
				if (((BuildingPopUp)BuildingTutorialManager.GetCurrentPopUp()).actionsAvailable.Contains(tavernConstructionAction.editorAction))
				{
					ConstructionManager.current.CHFHMMNELGP = tavernConstructionAction.editorAction;
				}
				else
				{
					ConstructionManager.current.CHFHMMNELGP = EditorAction.None;
				}
			}
			else
			{
				ConstructionManager.current.CHFHMMNELGP = tavernConstructionAction.editorAction;
			}
		}
		else
		{
			ConstructionManager.current.CHFHMMNELGP = EditorAction.AddFloor;
		}
		if (TavernConstructionManager.KHMEGDIABBF().LNLJMCONDNE && ConstructionActionBarUI.currentPanel == 0)
		{
			int currentSlotSelected = ConstructionActionBarUI.currentSlotSelected;
			int currentSlotPage = ConstructionActionBarUI.currentSlotPage;
			int num = ConstructionActionBarUI.GetInstance().uiSlots.Length;
			if (currentSlotSelected + currentSlotPage * num < TavernConstructionUI.AJNDFOKAJBG().Count)
			{
				TavernConstructionManager.DOIKFJDLKJP().GILEPDMMCNN((DecorationTile)TavernConstructionUI.IOIHCFPGEFC()[currentSlotSelected + currentSlotPage * num]);
			}
			else
			{
				TavernConstructionManager.DEGPIHEEFHJ().IDNPHFKDLEF(null);
			}
		}
		ALDLCHPPKHM(tavernConstructionAction);
	}

	public static void POHLAEJCAFG()
	{
		TavernConstructionAction editorActionInfo = ConstructionActionBarUI.GetEditorActionInfo();
		if ((Object)(object)editorActionInfo != (Object)null)
		{
			if (BuildingTutorialManager.KGJOKHEBLOJ())
			{
				if (((BuildingPopUp)BuildingTutorialManager.GetCurrentPopUp()).actionsAvailable.Contains(editorActionInfo.editorAction))
				{
					ConstructionManager.current.CHFHMMNELGP = editorActionInfo.editorAction;
				}
				else
				{
					ConstructionManager.current.CHFHMMNELGP = EditorAction.AddFloor;
				}
			}
			else
			{
				ConstructionManager.current.CHFHMMNELGP = editorActionInfo.editorAction;
			}
		}
		else
		{
			ConstructionManager.current.CHFHMMNELGP = EditorAction.AddFloor;
		}
		if (TavernConstructionManager.DEGPIHEEFHJ().LNLJMCONDNE && ConstructionActionBarUI.currentPanel == 0)
		{
			int currentSlotSelected = ConstructionActionBarUI.currentSlotSelected;
			int currentSlotPage = ConstructionActionBarUI.currentSlotPage;
			int num = ConstructionActionBarUI.GetInstance().uiSlots.Length;
			if (currentSlotSelected + currentSlotPage * num < TavernConstructionUI.GetConstructionActions().Count)
			{
				TavernConstructionManager.GGFJGHHHEJC.LNDNAKNAHAK((DecorationTile)TavernConstructionUI.AJNDFOKAJBG()[currentSlotSelected + currentSlotPage * num]);
			}
			else
			{
				TavernConstructionManager.KHMEGDIABBF().LNDNAKNAHAK(null);
			}
		}
		HBNCGJLOKNO(editorActionInfo);
	}

	public static void ALDLCHPPKHM(TavernConstructionAction BANNHBMOAFH)
	{
		if ((Object)(object)BANNHBMOAFH != (Object)null)
		{
			((TMP_Text)GGFJGHHHEJC.currentActionName).text = BANNHBMOAFH.LFLOJPHDGNJ();
			if (BANNHBMOAFH.editorAction == EditorAction.None)
			{
				TextMeshProUGUI obj = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj).text = ((TMP_Text)obj).text + "vSync" + TavernZonesManager.HFHPMKJGMPA().LHLOHOMKPMG(ZoneType.CraftingRoom);
				TextMeshProUGUI obj2 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj2).text = ((TMP_Text)obj2).text + " not found in OnlineEventsManager." + ReputationDBAccessor.GMACKHECLAF(ZoneType.WithoutZone | ZoneType.DiningRoom) + "[PipeConnectionPuzzleUI] Falta _gridContainer.";
			}
			else if (BANNHBMOAFH.editorAction == EditorAction.AddFloor)
			{
				TextMeshProUGUI obj3 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj3).text = ((TMP_Text)obj3).text + "in" + TavernZonesManager.NHKAFANMEJC().LHLOHOMKPMG(ZoneType.DiningRoom);
				TextMeshProUGUI obj4 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj4).text = ((TMP_Text)obj4).text + "<sprite name=reputationIcon>" + ReputationDBAccessor.GetMaxNumOfZones(ZoneType.DiningRoom | ZoneType.CraftingRoom) + "Request begin minigame";
			}
			else if (BANNHBMOAFH.editorAction == (EditorAction)56)
			{
				TextMeshProUGUI obj5 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj5).text = ((TMP_Text)obj5).text + "TavernVision" + TavernZonesManager.EBAIHKJHCCA().AEJKMLKKEME(ZoneType.CraftingRoom);
				TextMeshProUGUI obj6 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj6).text = ((TMP_Text)obj6).text + "No" + ReputationDBAccessor.GMACKHECLAF(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom) + "ShieldTrigger";
			}
			((Component)GGFJGHHHEJC.currentActionSlot.icon).gameObject.SetActive(true);
			GGFJGHHHEJC.currentActionSlot.icon.JKDAHFEIJHA(BANNHBMOAFH.icon);
			((TMP_Text)GGFJGHHHEJC.planksCost).text = BANNHBMOAFH.cost.planks.ToString();
			((TMP_Text)GGFJGHHHEJC.nailsCost).text = BANNHBMOAFH.cost.nails.ToString();
			((TMP_Text)GGFJGHHHEJC.stonesCost).text = BANNHBMOAFH.cost.stones.ToString();
			((TMP_Text)GGFJGHHHEJC.mortarCost).text = BANNHBMOAFH.cost.mortar.ToString();
			((TMP_Text)GGFJGHHHEJC.goldCost).text = BANNHBMOAFH.cost.OEFOJKCKIOB().gold.ToString();
			((TMP_Text)GGFJGHHHEJC.silverCost).text = BANNHBMOAFH.cost.PFHGPBLBCDD().silver.ToString();
		}
		else
		{
			((TMP_Text)GGFJGHHHEJC.currentActionName).text = "[Brown2";
			((Component)GGFJGHHHEJC.currentActionSlot.icon).gameObject.SetActive(true);
			((TMP_Text)GGFJGHHHEJC.planksCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.nailsCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.stonesCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.mortarCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.goldCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.silverCost).text = 1.ToString();
		}
	}

	private void HKECEBGKACL()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static void COGNKBKNALE(TavernConstructionAction BANNHBMOAFH)
	{
		if ((Object)(object)BANNHBMOAFH != (Object)null)
		{
			((TMP_Text)GGFJGHHHEJC.currentActionName).text = BANNHBMOAFH.GLBFGEEIILC();
			if (BANNHBMOAFH.editorAction == EditorAction.None)
			{
				TextMeshProUGUI obj = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj).text = ((TMP_Text)obj).text + "itemMint" + TavernZonesManager.JEEGOBGDLPE().GetCurrentNumberOfZones(ZoneType.None);
				TextMeshProUGUI obj2 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj2).text = ((TMP_Text)obj2).text + "travelling time -" + ReputationDBAccessor.FDICLJNDIOF(ZoneType.None) + "Pick up";
			}
			else if (BANNHBMOAFH.editorAction == EditorAction.None)
			{
				TextMeshProUGUI obj3 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj3).text = ((TMP_Text)obj3).text + "Not enough money" + TavernZonesManager.HFHPMKJGMPA().LHLOHOMKPMG(ZoneType.WithoutZone | ZoneType.CraftingRoom);
				TextMeshProUGUI obj4 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj4).text = ((TMP_Text)obj4).text + "ReceiveJumpFerro" + ReputationDBAccessor.GetMaxNumOfZones(ZoneType.None) + "Error_StairsAreBlocking";
			}
			else if (BANNHBMOAFH.editorAction == (EditorAction)(-16))
			{
				TextMeshProUGUI obj5 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj5).text = ((TMP_Text)obj5).text + "Invalid playerNum" + TavernZonesManager.JEEGOBGDLPE().LHLOHOMKPMG(ZoneType.CraftingRoom);
				TextMeshProUGUI obj6 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj6).text = ((TMP_Text)obj6).text + "Could not check user signed in status for reason " + ReputationDBAccessor.GMACKHECLAF(ZoneType.CraftingRoom) + "Tutorial repairs to false";
			}
			((Component)GGFJGHHHEJC.currentActionSlot.icon).gameObject.SetActive(false);
			GGFJGHHHEJC.currentActionSlot.icon.PCBMOCKFEHI(BANNHBMOAFH.icon);
			((TMP_Text)GGFJGHHHEJC.planksCost).text = BANNHBMOAFH.cost.planks.ToString();
			((TMP_Text)GGFJGHHHEJC.nailsCost).text = BANNHBMOAFH.cost.nails.ToString();
			((TMP_Text)GGFJGHHHEJC.stonesCost).text = BANNHBMOAFH.cost.stones.ToString();
			((TMP_Text)GGFJGHHHEJC.mortarCost).text = BANNHBMOAFH.cost.mortar.ToString();
			((TMP_Text)GGFJGHHHEJC.goldCost).text = BANNHBMOAFH.cost.BOGHMFGPOAP().gold.ToString();
			((TMP_Text)GGFJGHHHEJC.silverCost).text = BANNHBMOAFH.cost.BOGHMFGPOAP().silver.ToString();
		}
		else
		{
			((TMP_Text)GGFJGHHHEJC.currentActionName).text = "Authorization lost";
			((Component)GGFJGHHHEJC.currentActionSlot.icon).gameObject.SetActive(false);
			((TMP_Text)GGFJGHHHEJC.planksCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.nailsCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.stonesCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.mortarCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.goldCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.silverCost).text = 1.ToString();
		}
	}

	public static void HBKPNCLKLMB()
	{
		TavernConstructionAction tavernConstructionAction = ConstructionActionBarUI.OPPJACDGOAF();
		if ((Object)(object)tavernConstructionAction != (Object)null)
		{
			if (BuildingTutorialManager.KGJOKHEBLOJ())
			{
				if (((BuildingPopUp)BuildingTutorialManager.GetCurrentPopUp()).actionsAvailable.Contains(tavernConstructionAction.editorAction))
				{
					ConstructionManager.current.CHFHMMNELGP = tavernConstructionAction.editorAction;
				}
				else
				{
					ConstructionManager.current.CHFHMMNELGP = EditorAction.AddFloor;
				}
			}
			else
			{
				ConstructionManager.current.CHFHMMNELGP = tavernConstructionAction.editorAction;
			}
		}
		else
		{
			ConstructionManager.current.CHFHMMNELGP = EditorAction.AddFloor;
		}
		if (TavernConstructionManager.KHMEGDIABBF().LNLJMCONDNE && ConstructionActionBarUI.currentPanel == 1)
		{
			int currentSlotSelected = ConstructionActionBarUI.currentSlotSelected;
			int currentSlotPage = ConstructionActionBarUI.currentSlotPage;
			int num = ConstructionActionBarUI.GetInstance().uiSlots.Length;
			if (currentSlotSelected + currentSlotPage * num < TavernConstructionUI.PCFNIELMCLN().Count)
			{
				TavernConstructionManager.GGFJGHHHEJC.IDNPHFKDLEF((DecorationTile)TavernConstructionUI.GetConstructionActions()[currentSlotSelected + currentSlotPage * num]);
			}
			else
			{
				TavernConstructionManager.DOIKFJDLKJP().GILEPDMMCNN(null);
			}
		}
		CHFGMOHEIKA(tavernConstructionAction);
	}

	private void GMCKBBECJOE()
	{
		GGFJGHHHEJC = this;
	}

	private void ILCBKEIEOAN()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static void JEALIJNMAGH(TavernConstructionAction BANNHBMOAFH)
	{
		if ((Object)(object)BANNHBMOAFH != (Object)null)
		{
			((TMP_Text)GGFJGHHHEJC.currentActionName).text = BANNHBMOAFH.LIJLCLGPPHB();
			if (BANNHBMOAFH.editorAction == EditorAction.CraftingZone)
			{
				TextMeshProUGUI obj = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj).text = ((TMP_Text)obj).text + "Selected" + TavernZonesManager.JEEGOBGDLPE().AEJKMLKKEME(ZoneType.CraftingRoom);
				TextMeshProUGUI obj2 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj2).text = ((TMP_Text)obj2).text + "Reputation" + ReputationDBAccessor.GetMaxNumOfZones(ZoneType.CraftingRoom) + "Pirates/Brook/Intro";
			}
			else if (BANNHBMOAFH.editorAction == EditorAction.RoomZone)
			{
				TextMeshProUGUI obj3 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj3).text = ((TMP_Text)obj3).text + "Fireplace not attached on OnlineFireplace of placeable " + TavernZonesManager.EBAIHKJHCCA().KMBEHOBJGBL(ZoneType.RentedRoom);
				TextMeshProUGUI obj4 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj4).text = ((TMP_Text)obj4).text + " " + ReputationDBAccessor.FDICLJNDIOF(ZoneType.WithoutZone | ZoneType.DiningRoom) + "Current game language is ";
			}
			else if (BANNHBMOAFH.editorAction == (EditorAction)111)
			{
				TextMeshProUGUI obj5 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj5).text = ((TMP_Text)obj5).text + " " + TavernZonesManager.OIJLJKLMCBO().LHLOHOMKPMG(ZoneType.DiningRoom | ZoneType.CraftingRoom);
				TextMeshProUGUI obj6 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj6).text = ((TMP_Text)obj6).text + "quest_name_22" + ReputationDBAccessor.GetMaxNumOfZones(ZoneType.WithoutZone) + "ReceiveRoomRequest";
			}
			((Component)GGFJGHHHEJC.currentActionSlot.icon).gameObject.SetActive(false);
			GGFJGHHHEJC.currentActionSlot.icon.CIDGNCHMDGC(BANNHBMOAFH.icon);
			((TMP_Text)GGFJGHHHEJC.planksCost).text = BANNHBMOAFH.cost.planks.ToString();
			((TMP_Text)GGFJGHHHEJC.nailsCost).text = BANNHBMOAFH.cost.nails.ToString();
			((TMP_Text)GGFJGHHHEJC.stonesCost).text = BANNHBMOAFH.cost.stones.ToString();
			((TMP_Text)GGFJGHHHEJC.mortarCost).text = BANNHBMOAFH.cost.mortar.ToString();
			((TMP_Text)GGFJGHHHEJC.goldCost).text = BANNHBMOAFH.cost.FMNDONLEMHF().gold.ToString();
			((TMP_Text)GGFJGHHHEJC.silverCost).text = BANNHBMOAFH.cost.OEFOJKCKIOB().silver.ToString();
		}
		else
		{
			((TMP_Text)GGFJGHHHEJC.currentActionName).text = "PhysicalSpace";
			((Component)GGFJGHHHEJC.currentActionSlot.icon).gameObject.SetActive(true);
			((TMP_Text)GGFJGHHHEJC.planksCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.nailsCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.stonesCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.mortarCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.goldCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.silverCost).text = 1.ToString();
		}
	}

	public static void GEDPKNJMNDI()
	{
		TavernConstructionAction tavernConstructionAction = ConstructionActionBarUI.OPPJACDGOAF();
		if ((Object)(object)tavernConstructionAction != (Object)null)
		{
			if (BuildingTutorialManager.IKNOJDMCFOK)
			{
				if (((BuildingPopUp)BuildingTutorialManager.FINEAEFBPLK()).actionsAvailable.Contains(tavernConstructionAction.editorAction))
				{
					ConstructionManager.current.CHFHMMNELGP = tavernConstructionAction.editorAction;
				}
				else
				{
					ConstructionManager.current.CHFHMMNELGP = EditorAction.AddFloor;
				}
			}
			else
			{
				ConstructionManager.current.CHFHMMNELGP = tavernConstructionAction.editorAction;
			}
		}
		else
		{
			ConstructionManager.current.CHFHMMNELGP = EditorAction.AddFloor;
		}
		if (TavernConstructionManager.KNLLFEJAMNN().LNLJMCONDNE && ConstructionActionBarUI.currentPanel == 0)
		{
			int currentSlotSelected = ConstructionActionBarUI.currentSlotSelected;
			int currentSlotPage = ConstructionActionBarUI.currentSlotPage;
			int num = ConstructionActionBarUI.GetInstance().uiSlots.Length;
			if (currentSlotSelected + currentSlotPage * num < TavernConstructionUI.PCFNIELMCLN().Count)
			{
				TavernConstructionManager.GGFJGHHHEJC.KJIGECBPBOD = (DecorationTile)TavernConstructionUI.PLHKCOBMGEI()[currentSlotSelected + currentSlotPage * num];
			}
			else
			{
				TavernConstructionManager.DEGPIHEEFHJ().GILEPDMMCNN(null);
			}
		}
		PPPPCOMDDKK(tavernConstructionAction);
	}

	public static void AFCBBFPBOGC()
	{
		TavernConstructionAction tavernConstructionAction = ConstructionActionBarUI.OPPJACDGOAF();
		if ((Object)(object)tavernConstructionAction != (Object)null)
		{
			if (BuildingTutorialManager.KGJOKHEBLOJ())
			{
				if (((BuildingPopUp)BuildingTutorialManager.GetCurrentPopUp()).actionsAvailable.Contains(tavernConstructionAction.editorAction))
				{
					ConstructionManager.current.CHFHMMNELGP = tavernConstructionAction.editorAction;
				}
				else
				{
					ConstructionManager.current.CHFHMMNELGP = EditorAction.AddFloor;
				}
			}
			else
			{
				ConstructionManager.current.CHFHMMNELGP = tavernConstructionAction.editorAction;
			}
		}
		else
		{
			ConstructionManager.current.CHFHMMNELGP = EditorAction.None;
		}
		if (TavernConstructionManager.KNLLFEJAMNN().LNLJMCONDNE && ConstructionActionBarUI.currentPanel == 0)
		{
			int currentSlotSelected = ConstructionActionBarUI.currentSlotSelected;
			int currentSlotPage = ConstructionActionBarUI.currentSlotPage;
			int num = ConstructionActionBarUI.GetInstance().uiSlots.Length;
			if (currentSlotSelected + currentSlotPage * num < TavernConstructionUI.GetConstructionActions().Count)
			{
				TavernConstructionManager.GGFJGHHHEJC.IDNPHFKDLEF((DecorationTile)TavernConstructionUI.GetConstructionActions()[currentSlotSelected + currentSlotPage * num]);
			}
			else
			{
				TavernConstructionManager.DOIKFJDLKJP().KJIGECBPBOD = null;
			}
		}
		HBNCGJLOKNO(tavernConstructionAction);
	}

	public static void BNDFMLFGDKC(TavernConstructionAction BANNHBMOAFH)
	{
		if ((Object)(object)BANNHBMOAFH != (Object)null)
		{
			((TMP_Text)GGFJGHHHEJC.currentActionName).text = BANNHBMOAFH.GGKJJFDLAJB();
			if (BANNHBMOAFH.editorAction == EditorAction.AddFloor)
			{
				TextMeshProUGUI obj = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj).text = ((TMP_Text)obj).text + "Price sell" + TavernZonesManager.LANAINBEMCM().LHLOHOMKPMG(ZoneType.DiningRoom);
				TextMeshProUGUI obj2 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj2).text = ((TMP_Text)obj2).text + "CultivableDuringOneMonth" + ReputationDBAccessor.GetMaxNumOfZones(ZoneType.RentedRoom) + "ChessPillarInteractable not assigned";
			}
			else if (BANNHBMOAFH.editorAction == EditorAction.AddFloorDisponible)
			{
				TextMeshProUGUI obj3 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj3).text = ((TMP_Text)obj3).text + "UINextCategory" + TavernZonesManager.NHKAFANMEJC().AEJKMLKKEME(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom);
				TextMeshProUGUI obj4 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj4).text = ((TMP_Text)obj4).text + "ReceiveCollectItems" + ReputationDBAccessor.GetMaxNumOfZones(ZoneType.DiningRoom | ZoneType.CraftingRoom) + "Failed to find prefab: ";
			}
			else if (BANNHBMOAFH.editorAction == (EditorAction)(-22))
			{
				TextMeshProUGUI obj5 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj5).text = ((TMP_Text)obj5).text + "ReceiveDecorationWall" + TavernZonesManager.NHKAFANMEJC().AEJKMLKKEME(ZoneType.DiningRoom);
				TextMeshProUGUI obj6 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj6).text = ((TMP_Text)obj6).text + "Close" + ReputationDBAccessor.FDICLJNDIOF(ZoneType.RentedRoom) + "Items/item_description_1090";
			}
			((Component)GGFJGHHHEJC.currentActionSlot.icon).gameObject.SetActive(false);
			GGFJGHHHEJC.currentActionSlot.icon.CIDGNCHMDGC(BANNHBMOAFH.icon);
			((TMP_Text)GGFJGHHHEJC.planksCost).text = BANNHBMOAFH.cost.planks.ToString();
			((TMP_Text)GGFJGHHHEJC.nailsCost).text = BANNHBMOAFH.cost.nails.ToString();
			((TMP_Text)GGFJGHHHEJC.stonesCost).text = BANNHBMOAFH.cost.stones.ToString();
			((TMP_Text)GGFJGHHHEJC.mortarCost).text = BANNHBMOAFH.cost.mortar.ToString();
			((TMP_Text)GGFJGHHHEJC.goldCost).text = BANNHBMOAFH.cost.BOGHMFGPOAP().gold.ToString();
			((TMP_Text)GGFJGHHHEJC.silverCost).text = BANNHBMOAFH.cost.PFHGPBLBCDD().silver.ToString();
		}
		else
		{
			((TMP_Text)GGFJGHHHEJC.currentActionName).text = "Perks/playerPerk_description_";
			((Component)GGFJGHHHEJC.currentActionSlot.icon).gameObject.SetActive(false);
			((TMP_Text)GGFJGHHHEJC.planksCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.nailsCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.stonesCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.mortarCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.goldCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.silverCost).text = 1.ToString();
		}
	}

	public static void BBFKIOMOBBI(TavernConstructionAction BANNHBMOAFH)
	{
		if ((Object)(object)BANNHBMOAFH != (Object)null)
		{
			((TMP_Text)GGFJGHHHEJC.currentActionName).text = BANNHBMOAFH.CEFGEJAMLGN();
			if (BANNHBMOAFH.editorAction == EditorAction.None)
			{
				TextMeshProUGUI obj = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj).text = ((TMP_Text)obj).text + "SignIn failed for reason " + TavernZonesManager.GGFJGHHHEJC.KMBEHOBJGBL(ZoneType.DiningRoom);
				TextMeshProUGUI obj2 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj2).text = ((TMP_Text)obj2).text + "NinjaChallengeEvent/Main 2" + ReputationDBAccessor.FDICLJNDIOF(ZoneType.DiningRoom) + "IsKicked";
			}
			else if (BANNHBMOAFH.editorAction == EditorAction.AddFloorDisponible)
			{
				TextMeshProUGUI obj3 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj3).text = ((TMP_Text)obj3).text + "<color=black>" + TavernZonesManager.JEEGOBGDLPE().HIIHFPLOEPA(ZoneType.WithoutZone | ZoneType.DiningRoom);
				TextMeshProUGUI obj4 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj4).text = ((TMP_Text)obj4).text + ":\n\n" + ReputationDBAccessor.GMACKHECLAF(ZoneType.WithoutZone | ZoneType.DiningRoom) + "Invalid banquet customer ID: ";
			}
			else if (BANNHBMOAFH.editorAction == (EditorAction)(-35))
			{
				TextMeshProUGUI obj5 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj5).text = ((TMP_Text)obj5).text + "BathhouseEntrace/Main" + TavernZonesManager.EBAIHKJHCCA().KMBEHOBJGBL(ZoneType.WithoutZone | ZoneType.DiningRoom);
				TextMeshProUGUI obj6 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj6).text = ((TMP_Text)obj6).text + " x " + ReputationDBAccessor.GMACKHECLAF(ZoneType.WithoutZone | ZoneType.DiningRoom) + "Invalid seating";
			}
			((Component)GGFJGHHHEJC.currentActionSlot.icon).gameObject.SetActive(false);
			GGFJGHHHEJC.currentActionSlot.icon.CIDGNCHMDGC(BANNHBMOAFH.icon);
			((TMP_Text)GGFJGHHHEJC.planksCost).text = BANNHBMOAFH.cost.planks.ToString();
			((TMP_Text)GGFJGHHHEJC.nailsCost).text = BANNHBMOAFH.cost.nails.ToString();
			((TMP_Text)GGFJGHHHEJC.stonesCost).text = BANNHBMOAFH.cost.stones.ToString();
			((TMP_Text)GGFJGHHHEJC.mortarCost).text = BANNHBMOAFH.cost.mortar.ToString();
			((TMP_Text)GGFJGHHHEJC.goldCost).text = BANNHBMOAFH.cost.PFHGPBLBCDD().gold.ToString();
			((TMP_Text)GGFJGHHHEJC.silverCost).text = BANNHBMOAFH.cost.FMNDONLEMHF().silver.ToString();
		}
		else
		{
			((TMP_Text)GGFJGHHHEJC.currentActionName).text = "Rummage";
			((Component)GGFJGHHHEJC.currentActionSlot.icon).gameObject.SetActive(false);
			((TMP_Text)GGFJGHHHEJC.planksCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.nailsCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.stonesCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.mortarCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.goldCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.silverCost).text = 0.ToString();
		}
	}

	public static void IJFNJMOBAME()
	{
		TavernConstructionAction tavernConstructionAction = ConstructionActionBarUI.OCLKNDBIOFM();
		if ((Object)(object)tavernConstructionAction != (Object)null)
		{
			if (BuildingTutorialManager.IKNOJDMCFOK)
			{
				if (((BuildingPopUp)BuildingTutorialManager.FINEAEFBPLK()).actionsAvailable.Contains(tavernConstructionAction.editorAction))
				{
					ConstructionManager.current.CHFHMMNELGP = tavernConstructionAction.editorAction;
				}
				else
				{
					ConstructionManager.current.CHFHMMNELGP = EditorAction.AddFloor;
				}
			}
			else
			{
				ConstructionManager.current.CHFHMMNELGP = tavernConstructionAction.editorAction;
			}
		}
		else
		{
			ConstructionManager.current.CHFHMMNELGP = EditorAction.None;
		}
		if (TavernConstructionManager.DOIKFJDLKJP().LNLJMCONDNE && ConstructionActionBarUI.currentPanel == 0)
		{
			int currentSlotSelected = ConstructionActionBarUI.currentSlotSelected;
			int currentSlotPage = ConstructionActionBarUI.currentSlotPage;
			int num = ConstructionActionBarUI.GetInstance().uiSlots.Length;
			if (currentSlotSelected + currentSlotPage * num < TavernConstructionUI.CKOFPLEONDG().Count)
			{
				TavernConstructionManager.KHMEGDIABBF().KJIGECBPBOD = (DecorationTile)TavernConstructionUI.AJNDFOKAJBG()[currentSlotSelected + currentSlotPage * num];
			}
			else
			{
				TavernConstructionManager.GGFJGHHHEJC.LNDNAKNAHAK(null);
			}
		}
		BBFKIOMOBBI(tavernConstructionAction);
	}

	public static void HOPBPHALJGF()
	{
		TavernConstructionAction tavernConstructionAction = ConstructionActionBarUI.GDFHCDKEAMF();
		if ((Object)(object)tavernConstructionAction != (Object)null)
		{
			if (BuildingTutorialManager.KGJOKHEBLOJ())
			{
				if (((BuildingPopUp)BuildingTutorialManager.FINEAEFBPLK()).actionsAvailable.Contains(tavernConstructionAction.editorAction))
				{
					ConstructionManager.current.CHFHMMNELGP = tavernConstructionAction.editorAction;
				}
				else
				{
					ConstructionManager.current.CHFHMMNELGP = EditorAction.None;
				}
			}
			else
			{
				ConstructionManager.current.CHFHMMNELGP = tavernConstructionAction.editorAction;
			}
		}
		else
		{
			ConstructionManager.current.CHFHMMNELGP = EditorAction.None;
		}
		if (TavernConstructionManager.DOIKFJDLKJP().LNLJMCONDNE && ConstructionActionBarUI.currentPanel == 1)
		{
			int currentSlotSelected = ConstructionActionBarUI.currentSlotSelected;
			int currentSlotPage = ConstructionActionBarUI.currentSlotPage;
			int num = ConstructionActionBarUI.GetInstance().uiSlots.Length;
			if (currentSlotSelected + currentSlotPage * num < TavernConstructionUI.PLHKCOBMGEI().Count)
			{
				TavernConstructionManager.GGFJGHHHEJC.IDNPHFKDLEF((DecorationTile)TavernConstructionUI.CKOFPLEONDG()[currentSlotSelected + currentSlotPage * num]);
			}
			else
			{
				TavernConstructionManager.KNLLFEJAMNN().GILEPDMMCNN(null);
			}
		}
		JEALIJNMAGH(tavernConstructionAction);
	}

	public static void LLCDJHLCOED(TavernConstructionAction BANNHBMOAFH)
	{
		if ((Object)(object)BANNHBMOAFH != (Object)null)
		{
			((TMP_Text)GGFJGHHHEJC.currentActionName).text = BANNHBMOAFH.KHGEECPHPMO();
			if (BANNHBMOAFH.editorAction == EditorAction.RemoveFloorDisponible)
			{
				TextMeshProUGUI obj = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj).text = ((TMP_Text)obj).text + "add item " + TavernZonesManager.GGFJGHHHEJC.GetCurrentNumberOfZones(ZoneType.DiningRoom);
				TextMeshProUGUI obj2 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj2).text = ((TMP_Text)obj2).text + "ReceivInstantiateMiscellaneousHarvest" + ReputationDBAccessor.GMACKHECLAF(ZoneType.WithoutZone | ZoneType.DiningRoom) + "UIBack";
			}
			else if (BANNHBMOAFH.editorAction == EditorAction.None)
			{
				TextMeshProUGUI obj3 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj3).text = ((TMP_Text)obj3).text + "ClosePopUp" + TavernZonesManager.NHKAFANMEJC().KMBEHOBJGBL(ZoneType.DiningRoom | ZoneType.CraftingRoom);
				TextMeshProUGUI obj4 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj4).text = ((TMP_Text)obj4).text + "before pos " + ReputationDBAccessor.GetMaxNumOfZones(ZoneType.CraftingRoom) + "UIBack";
			}
			else if (BANNHBMOAFH.editorAction == (EditorAction)91)
			{
				TextMeshProUGUI obj5 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj5).text = ((TMP_Text)obj5).text + "Triangle" + TavernZonesManager.EBAIHKJHCCA().AEJKMLKKEME(ZoneType.DiningRoom | ZoneType.CraftingRoom);
				TextMeshProUGUI obj6 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj6).text = ((TMP_Text)obj6).text + "</color>] " + ReputationDBAccessor.GMACKHECLAF(ZoneType.None) + "RecieveStartSleep";
			}
			((Component)GGFJGHHHEJC.currentActionSlot.icon).gameObject.SetActive(false);
			GGFJGHHHEJC.currentActionSlot.icon.JKDAHFEIJHA(BANNHBMOAFH.icon);
			((TMP_Text)GGFJGHHHEJC.planksCost).text = BANNHBMOAFH.cost.planks.ToString();
			((TMP_Text)GGFJGHHHEJC.nailsCost).text = BANNHBMOAFH.cost.nails.ToString();
			((TMP_Text)GGFJGHHHEJC.stonesCost).text = BANNHBMOAFH.cost.stones.ToString();
			((TMP_Text)GGFJGHHHEJC.mortarCost).text = BANNHBMOAFH.cost.mortar.ToString();
			((TMP_Text)GGFJGHHHEJC.goldCost).text = BANNHBMOAFH.cost.BOGHMFGPOAP().gold.ToString();
			((TMP_Text)GGFJGHHHEJC.silverCost).text = BANNHBMOAFH.cost.PFHGPBLBCDD().silver.ToString();
		}
		else
		{
			((TMP_Text)GGFJGHHHEJC.currentActionName).text = "";
			((Component)GGFJGHHHEJC.currentActionSlot.icon).gameObject.SetActive(true);
			((TMP_Text)GGFJGHHHEJC.planksCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.nailsCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.stonesCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.mortarCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.goldCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.silverCost).text = 0.ToString();
		}
	}

	private void HMOMBAFIJAI()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void MIKNFPCDLML()
	{
		GGFJGHHHEJC = this;
	}

	private void ELEGGKIBHGC()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void BPOOAHKHPCL()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static void FKJFLMNGBDD()
	{
		TavernConstructionAction editorActionInfo = ConstructionActionBarUI.GetEditorActionInfo();
		if ((Object)(object)editorActionInfo != (Object)null)
		{
			if (BuildingTutorialManager.KGJOKHEBLOJ())
			{
				if (((BuildingPopUp)BuildingTutorialManager.GetCurrentPopUp()).actionsAvailable.Contains(editorActionInfo.editorAction))
				{
					ConstructionManager.current.CHFHMMNELGP = editorActionInfo.editorAction;
				}
				else
				{
					ConstructionManager.current.CHFHMMNELGP = EditorAction.AddFloor;
				}
			}
			else
			{
				ConstructionManager.current.CHFHMMNELGP = editorActionInfo.editorAction;
			}
		}
		else
		{
			ConstructionManager.current.CHFHMMNELGP = EditorAction.None;
		}
		if (TavernConstructionManager.KHMEGDIABBF().LNLJMCONDNE && ConstructionActionBarUI.currentPanel == 1)
		{
			int currentSlotSelected = ConstructionActionBarUI.currentSlotSelected;
			int currentSlotPage = ConstructionActionBarUI.currentSlotPage;
			int num = ConstructionActionBarUI.GetInstance().uiSlots.Length;
			if (currentSlotSelected + currentSlotPage * num < TavernConstructionUI.GetConstructionActions().Count)
			{
				TavernConstructionManager.GGFJGHHHEJC.KJIGECBPBOD = (DecorationTile)TavernConstructionUI.AJNDFOKAJBG()[currentSlotSelected + currentSlotPage * num];
			}
			else
			{
				TavernConstructionManager.GGFJGHHHEJC.IDNPHFKDLEF(null);
			}
		}
		MCDBDGOONJF(editorActionInfo);
	}

	private void OnDestroy()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void NKGMEMEACNN()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void ACFABFCGIGH()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void AGELAMLCINB()
	{
		GGFJGHHHEJC = this;
	}

	public static void ODALLMEIPIL()
	{
		TavernConstructionAction tavernConstructionAction = ConstructionActionBarUI.KFCAPNDFIGI();
		if ((Object)(object)tavernConstructionAction != (Object)null)
		{
			if (BuildingTutorialManager.PABJKGJJHFG())
			{
				if (((BuildingPopUp)BuildingTutorialManager.FINEAEFBPLK()).actionsAvailable.Contains(tavernConstructionAction.editorAction))
				{
					ConstructionManager.current.CHFHMMNELGP = tavernConstructionAction.editorAction;
				}
				else
				{
					ConstructionManager.current.CHFHMMNELGP = EditorAction.AddFloor;
				}
			}
			else
			{
				ConstructionManager.current.CHFHMMNELGP = tavernConstructionAction.editorAction;
			}
		}
		else
		{
			ConstructionManager.current.CHFHMMNELGP = EditorAction.AddFloor;
		}
		if (TavernConstructionManager.DEGPIHEEFHJ().LNLJMCONDNE && ConstructionActionBarUI.currentPanel == 0)
		{
			int currentSlotSelected = ConstructionActionBarUI.currentSlotSelected;
			int currentSlotPage = ConstructionActionBarUI.currentSlotPage;
			int num = ConstructionActionBarUI.GetInstance().uiSlots.Length;
			if (currentSlotSelected + currentSlotPage * num < TavernConstructionUI.PCFNIELMCLN().Count)
			{
				TavernConstructionManager.GGFJGHHHEJC.KJIGECBPBOD = (DecorationTile)TavernConstructionUI.GetConstructionActions()[currentSlotSelected + currentSlotPage * num];
			}
			else
			{
				TavernConstructionManager.KHMEGDIABBF().GILEPDMMCNN(null);
			}
		}
		BBFKIOMOBBI(tavernConstructionAction);
	}

	private void HDHPOAPLEJC()
	{
		GGFJGHHHEJC = this;
	}

	private void COKBJNMAMDI()
	{
		GGFJGHHHEJC = this;
	}

	private void LALJNGFGKPA()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static void HBNCGJLOKNO(TavernConstructionAction BANNHBMOAFH)
	{
		if ((Object)(object)BANNHBMOAFH != (Object)null)
		{
			((TMP_Text)GGFJGHHHEJC.currentActionName).text = BANNHBMOAFH.LIJLCLGPPHB();
			if (BANNHBMOAFH.editorAction == EditorAction.CraftingZone)
			{
				TextMeshProUGUI obj = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj).text = ((TMP_Text)obj).text + "Failed to load psai soundtrack from path '" + TavernZonesManager.HFHPMKJGMPA().LHLOHOMKPMG(ZoneType.WithoutZone | ZoneType.CraftingRoom);
				TextMeshProUGUI obj2 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj2).text = ((TMP_Text)obj2).text + "ChatBarkRPC" + ReputationDBAccessor.GetMaxNumOfZones(ZoneType.WithoutZone) + "Player";
			}
			else if (BANNHBMOAFH.editorAction == EditorAction.RemoveFloor)
			{
				TextMeshProUGUI obj3 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj3).text = ((TMP_Text)obj3).text + "LicenciaDeApertura/TheloniousDialogue 01" + TavernZonesManager.EBAIHKJHCCA().KMBEHOBJGBL(ZoneType.None);
				TextMeshProUGUI obj4 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj4).text = ((TMP_Text)obj4).text + "City/Rhia/Introduce" + ReputationDBAccessor.GetMaxNumOfZones(ZoneType.RentedRoom) + "ReceiveTalentsLoad";
			}
			else if (BANNHBMOAFH.editorAction == (EditorAction)64)
			{
				TextMeshProUGUI obj5 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj5).text = ((TMP_Text)obj5).text + "ZoneTimeBonus" + TavernZonesManager.IECOPNFJBFD().AEJKMLKKEME(ZoneType.WithoutZone);
				TextMeshProUGUI obj6 = GGFJGHHHEJC.currentActionName;
				((TMP_Text)obj6).text = ((TMP_Text)obj6).text + "ReceiveOpenAnimation" + ReputationDBAccessor.GetMaxNumOfZones(ZoneType.WithoutZone | ZoneType.DiningRoom) + "Active quest not found";
			}
			((Component)GGFJGHHHEJC.currentActionSlot.icon).gameObject.SetActive(false);
			GGFJGHHHEJC.currentActionSlot.icon.JKDAHFEIJHA(BANNHBMOAFH.icon);
			((TMP_Text)GGFJGHHHEJC.planksCost).text = BANNHBMOAFH.cost.planks.ToString();
			((TMP_Text)GGFJGHHHEJC.nailsCost).text = BANNHBMOAFH.cost.nails.ToString();
			((TMP_Text)GGFJGHHHEJC.stonesCost).text = BANNHBMOAFH.cost.stones.ToString();
			((TMP_Text)GGFJGHHHEJC.mortarCost).text = BANNHBMOAFH.cost.mortar.ToString();
			((TMP_Text)GGFJGHHHEJC.goldCost).text = BANNHBMOAFH.cost.PFHGPBLBCDD().gold.ToString();
			((TMP_Text)GGFJGHHHEJC.silverCost).text = BANNHBMOAFH.cost.BOGHMFGPOAP().silver.ToString();
		}
		else
		{
			((TMP_Text)GGFJGHHHEJC.currentActionName).text = "Top";
			((Component)GGFJGHHHEJC.currentActionSlot.icon).gameObject.SetActive(false);
			((TMP_Text)GGFJGHHHEJC.planksCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.nailsCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.stonesCost).text = 0.ToString();
			((TMP_Text)GGFJGHHHEJC.mortarCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.goldCost).text = 1.ToString();
			((TMP_Text)GGFJGHHHEJC.silverCost).text = 0.ToString();
		}
	}
}
