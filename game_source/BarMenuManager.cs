using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BarMenuManager : MonoBehaviour, IInteractable, ISelectable, IProximity, IHoverable
{
	public static BarMenuManager instance;

	[SerializeField]
	private SpriteRenderer outline1SR;

	[SerializeField]
	private SpriteRenderer outline2SR;

	public GameObject generalDropPosition;

	public Placeable placeable;

	private int JIIGOACEIKL = 1;

	[SerializeField]
	private Transform _barmanRoot;

	[SerializeField]
	private Transform _waiterRoot;

	[SerializeField]
	private Transform _bouncerRoot;

	private static int IFNLFODEMOL;

	public Transform AFKCGIPOHFP
	{
		get
		{
			return _barmanRoot;
		}
		set
		{
			_barmanRoot = value;
		}
	}

	public static Transform PJLOPCHGEMM
	{
		get
		{
			return instance._waiterRoot;
		}
		set
		{
			instance._waiterRoot = value;
		}
	}

	public Transform GNHJEAGEFEC
	{
		get
		{
			return _bouncerRoot;
		}
		set
		{
			_bouncerRoot = value;
		}
	}

	public bool COEICHCJEMG(int JIIGOACEIKL)
	{
		return false;
	}

	[ContextMenu("Get item instances")]
	public static List<ItemInstance> GetAvailableItemInstances()
	{
		List<ItemInstance> list = BarMenuInventory.GetInstance().GetAllItemInstances().ToList();
		list.AddRange(DrinkDispensersManager.GGFJGHHHEJC.GetAllDrinks());
		for (int i = 1; i < 5; i++)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null)
			{
				list.AddRange(PlayerController.GetPlayer(i).trayHandler.tray.currentDrinks);
			}
		}
		return list;
	}

	public void MJPOHFEDIHI(int JIIGOACEIKL)
	{
	}

	private void ALEAOANPHIO()
	{
		instance = this;
	}

	public static List<ItemInstance> GIFDOGOMAFL()
	{
		List<ItemInstance> list = BarMenuInventory.HPCJAODINCN().FCHHLGCBMJC().ToList();
		list.AddRange(DrinkDispensersManager.JFNOOMJMHCB().GetAllDrinks());
		for (int i = 0; i < 0; i += 0)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null)
			{
				list.AddRange(PlayerController.OPHDCMJLLEC(i).trayHandler.tray.currentDrinks);
			}
		}
		return list;
	}

	public static Vector3 JCJKLILKPMM()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		return instance.generalDropPosition.transform.position;
	}

	public void FMOLFKKGDDM(int JIIGOACEIKL)
	{
	}

	public bool ANGDFBJCFBB(int JIIGOACEIKL)
	{
		return true;
	}

	public bool Select(int JIIGOACEIKL)
	{
		return false;
	}

	public bool CFJEJFCALPM(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Interact;
				OnlineObjectsManager.instance.GMJPOKECENH(placeable.onlinePlaceable.uniqueId);
				return false;
			}
			IDJKOCEIEAG(JIIGOACEIKL);
			return false;
		}
		return true;
	}

	public bool OPAADDGNEBP(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			if (JIIGOACEIKL == 0)
			{
				((Component)outline1SR).gameObject.SetActive(false);
			}
			else
			{
				((Component)outline2SR).gameObject.SetActive(false);
			}
			ButtonsContext.IJKLIHJIOEN(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("hForHours"));
			return true;
		}
		return true;
	}

	private void CGIMPDBFMBI(int JIIGOACEIKL)
	{
		BigContainerUI.Get(JIIGOACEIKL).SetTrendsButtonVisible(NKFPJPCFBJI: true);
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Interact;
				OnlineObjectsManager.instance.InteractPlaceableIfIsPossible(placeable.onlinePlaceable.uniqueId);
				return false;
			}
			OpenContainer(JIIGOACEIKL);
			return true;
		}
		return false;
	}

	public static BoxCollider2D OIIPHLOFPFC()
	{
		return ((Component)instance).GetComponent<BoxCollider2D>();
	}

	public static List<FoodInstance> DMCCEPCKABF()
	{
		return AMKCBEBBFMO().OfType<FoodInstance>().Where(delegate(FoodInstance ii)
		{
			if (ii.JEPBBEBJEFI())
			{
				Food food = ii.LHBPOPOIFLE();
				if (food != null)
				{
					return food.halloweenFood;
				}
			}
			return false;
		}).ToList();
	}

	private void PPMBLACKLAC()
	{
		Slot[] oPMPOBPEDFB = DHPIHECMLHN(JIIGOACEIKL);
		BigContainerUI.MDFIDKHOPDJ(JIIGOACEIKL).FBEFMNPKOBB(oPMPOBPEDFB);
	}

	public static BoxCollider2D GetCollider()
	{
		return ((Component)instance).GetComponent<BoxCollider2D>();
	}

	private void BFJOEMCBJJO()
	{
		instance = this;
	}

	private void OnDestroy()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
		if (Object.op_Implicit((Object)(object)BarMenuInventory.GetInstance()))
		{
			BarMenuInventory barMenuInventory = BarMenuInventory.GetInstance();
			barMenuInventory.OnItemInstanceChanged = (Action)Delegate.Remove(barMenuInventory.OnItemInstanceChanged, new Action(KMOPPGPDGDB));
		}
		if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
		{
			CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
			commonReferences.OnBarOpened = (Action<int>)Delegate.Remove(commonReferences.OnBarOpened, new Action<int>(CGIMPDBFMBI));
			CommonReferences commonReferences2 = CommonReferences.GGFJGHHHEJC;
			commonReferences2.OnBarClosed = (Action<int>)Delegate.Remove(commonReferences2.OnBarClosed, new Action<int>(FLKIFDEDGCD));
		}
	}

	[SpecialName]
	public Transform OMPJBCEPLDA()
	{
		return _bouncerRoot;
	}

	private void KMOPPGPDGDB()
	{
		if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			CommonReferences.GGFJGHHHEJC.OnBarStockChanged();
		}
	}

	public static List<FoodInstance> GetAllDrinksInstances()
	{
		return (from ii in GetAvailableItemInstances().OfType<FoodInstance>()
			where ii.JEPBBEBJEFI()
			select ii).ToList();
	}

	private void HCJPOPKHEAF(int JIIGOACEIKL)
	{
		BigContainerUI.MDFIDKHOPDJ(JIIGOACEIKL).NGNIPBLJNHL(NKFPJPCFBJI: false);
	}

	private void Awake()
	{
		instance = this;
	}

	public void EGBOBCAAAEH(int JIIGOACEIKL)
	{
	}

	public static void OpenBarTrends(int JIIGOACEIKL)
	{
		TrendUI.Get(JIIGOACEIKL).OpenUI();
		if (TavernReputation.GetMilestoneMaster() >= RepUnlocksManager.GetInstance().repUnlockTrends.repNumber)
		{
			CommonReferences.GGFJGHHHEJC.OnBarOpenWithTrends(JIIGOACEIKL);
		}
	}

	public bool Deselect(int JIIGOACEIKL)
	{
		InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(placeable.onlinePlaceable);
		}
		BarMenuInventory barMenuInventory = BarMenuInventory.GetInstance();
		barMenuInventory.OnContainerChanged = (Action)Delegate.Remove(barMenuInventory.OnContainerChanged, new Action(NLJMBNIHLAK));
		BigContainerUI.Get(JIIGOACEIKL).CloseUI();
		CommonReferences.GGFJGHHHEJC.OnBarClosed(JIIGOACEIKL);
		GameActionBarUI.Get(JIIGOACEIKL).OpenUI();
		return true;
	}

	public static Vector3 PDDDHMNJCLL()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		return instance.generalDropPosition.transform.position;
	}

	public static List<FoodInstance> GetAllFoodInstances()
	{
		return (from ii in GetAvailableItemInstances().OfType<FoodInstance>()
			where !ii.JEPBBEBJEFI()
			select ii).ToList();
	}

	private Slot[] DHPIHECMLHN(int JIIGOACEIKL)
	{
		return (from x in PlayerInventory.GetPlayer(JIIGOACEIKL).GetAllSlots()
			where x.itemInstance != null && Utils.DOOILKJLDHD(x.itemInstance, BarMenuInventory.GetInstance())
			select x).ToArray();
	}

	public bool PickUp(int JIIGOACEIKL)
	{
		return false;
	}

	public static List<FoodInstance> FLBOIKAEPNC()
	{
		return AMKCBEBBFMO().OfType<FoodInstance>().Where(delegate(FoodInstance ii)
		{
			if (ii.JEPBBEBJEFI())
			{
				Food food = ii.LHBPOPOIFLE();
				if (food != null)
				{
					return food.halloweenFood;
				}
			}
			return false;
		}).ToList();
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL))
		{
			if (JIIGOACEIKL == 1)
			{
				((Component)outline1SR).gameObject.SetActive(true);
			}
			else
			{
				((Component)outline2SR).gameObject.SetActive(true);
			}
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Open"));
			return true;
		}
		return false;
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool JIHFNGMCBOB(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL))
		{
			if (OnlineManager.PlayingOnline())
			{
				PlayerController.GetPlayer(JIIGOACEIKL).interactAction = InteractAction.Select;
				OnlineObjectsManager.instance.InteractPlaceableIfIsPossible(placeable.onlinePlaceable.uniqueId);
				return true;
			}
			OpenContainer(JIIGOACEIKL);
			return false;
		}
		return false;
	}

	private void Start()
	{
		BarMenuInventory barMenuInventory = BarMenuInventory.GetInstance();
		barMenuInventory.OnItemInstanceChanged = (Action)Delegate.Combine(barMenuInventory.OnItemInstanceChanged, new Action(KMOPPGPDGDB));
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnBarOpened = (Action<int>)Delegate.Combine(commonReferences.OnBarOpened, new Action<int>(CGIMPDBFMBI));
		CommonReferences commonReferences2 = CommonReferences.GGFJGHHHEJC;
		commonReferences2.OnBarClosed = (Action<int>)Delegate.Combine(commonReferences2.OnBarClosed, new Action<int>(FLKIFDEDGCD));
		BigContainerUI.Get(1).SetTrendsButtonVisible(NKFPJPCFBJI: false);
		BigContainerUI.Get(2).SetTrendsButtonVisible(NKFPJPCFBJI: false);
	}

	public bool SelectOnline(int JIIGOACEIKL)
	{
		return false;
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public void OffHover(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			((Component)outline1SR).gameObject.SetActive(false);
		}
		else
		{
			((Component)outline2SR).gameObject.SetActive(false);
		}
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
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

	public static List<FoodInstance> GetAllDrinksInstancesHalloween()
	{
		return GetAvailableItemInstances().OfType<FoodInstance>().Where(delegate(FoodInstance ii)
		{
			if (ii.JEPBBEBJEFI())
			{
				Food food = ii.LHBPOPOIFLE();
				if (food != null)
				{
					return food.halloweenFood;
				}
			}
			return false;
		}).ToList();
	}

	private void NLJMBNIHLAK()
	{
		Slot[] oPMPOBPEDFB = DHPIHECMLHN(JIIGOACEIKL);
		BigContainerUI.Get(JIIGOACEIKL).UpdateSlotsInventory(oPMPOBPEDFB);
	}

	public bool OpenContainer(int JIIGOACEIKL)
	{
		if (SmallContainerUI.Get(JIIGOACEIKL).IsOpen())
		{
			return false;
		}
		SelectObject.GetPlayer(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
		InteractObject.GetPlayer(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
		this.JIIGOACEIKL = JIIGOACEIKL;
		GameActionBarUI.Get(JIIGOACEIKL).CloseUI();
		BigContainerUI.Get(JIIGOACEIKL).SetContainer(BarMenuInventory.GetInstance());
		BarMenuInventory barMenuInventory = BarMenuInventory.GetInstance();
		barMenuInventory.OnContainerChanged = (Action)Delegate.Remove(barMenuInventory.OnContainerChanged, new Action(NLJMBNIHLAK));
		BarMenuInventory barMenuInventory2 = BarMenuInventory.GetInstance();
		barMenuInventory2.OnContainerChanged = (Action)Delegate.Combine(barMenuInventory2.OnContainerChanged, new Action(NLJMBNIHLAK));
		Slot[] oPMPOBPEDFB = DHPIHECMLHN(JIIGOACEIKL);
		BigContainerUI.Get(JIIGOACEIKL).FillSlots(BarMenuInventory.GetInstance().slots, BarMenuInventory.GetInstance(), IFMNAFDGKKK: false, OGCAKIGELBJ: true, 5, oPMPOBPEDFB);
		BigContainerUI.Get(JIIGOACEIKL).OpenUI();
		CommonReferences.GGFJGHHHEJC.OnBarOpened(JIIGOACEIKL);
		return true;
	}

	public static List<FoodInstance> PJIFIOFJFBI()
	{
		return (from ii in GetAvailableItemInstances().OfType<FoodInstance>()
			where !ii.JEPBBEBJEFI()
			select ii).ToList();
	}

	[SpecialName]
	public static void MFKCADLAHMC(Transform AODONKKHPBP)
	{
		instance._waiterRoot = AODONKKHPBP;
	}

	public static List<ItemInstance> AMKCBEBBFMO()
	{
		List<ItemInstance> list = BarMenuInventory.EOCHAGBPHCC().PIHLGKJPABI().ToList();
		list.AddRange(DrinkDispensersManager.BNDNMBGJEKP().JBFCMIIPHLJ());
		for (int i = 1; i < 6; i++)
		{
			if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null)
			{
				list.AddRange(PlayerController.GetPlayer(i).trayHandler.tray.currentDrinks);
			}
		}
		return list;
	}

	public static Vector3 GetGeneralDropPosition()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		return instance.generalDropPosition.transform.position;
	}

	private void MKPPMABKEKL(int JIIGOACEIKL)
	{
		BigContainerUI.IGHMHMNPMLB(JIIGOACEIKL).DPOLOLACDDJ(NKFPJPCFBJI: false);
	}

	[SpecialName]
	public Transform EPMNHIJODJO()
	{
		return _barmanRoot;
	}

	public bool MDENHNAGFPM(int JIIGOACEIKL)
	{
		return true;
	}

	public bool IDJKOCEIEAG(int JIIGOACEIKL)
	{
		if (SmallContainerUI.FBKOKJCKICN(JIIGOACEIKL).HDEPMJIDJEM())
		{
			return true;
		}
		SelectObject.GetPlayer(JIIGOACEIKL).SetSelected(this, ((Component)this).gameObject, placeable);
		InteractObject.BBJCJFJEFKK(JIIGOACEIKL).interactingObject = ((Component)this).gameObject;
		this.JIIGOACEIKL = JIIGOACEIKL;
		GameActionBarUI.PJIGCLMPHKP(JIIGOACEIKL).BOBCIFEDJED();
		BigContainerUI.FHBIFJNCOAI(JIIGOACEIKL).PJLJDDKELHA(BarMenuInventory.DCEBHEAHHID());
		BarMenuInventory barMenuInventory = BarMenuInventory.GetInstance();
		barMenuInventory.OnContainerChanged = (Action)Delegate.Remove(barMenuInventory.OnContainerChanged, new Action(NLJMBNIHLAK));
		BarMenuInventory barMenuInventory2 = BarMenuInventory.JLPGGCKFJAD();
		barMenuInventory2.OnContainerChanged = (Action)Delegate.Combine(barMenuInventory2.OnContainerChanged, new Action(PPMBLACKLAC));
		Slot[] oPMPOBPEDFB = DHPIHECMLHN(JIIGOACEIKL);
		BigContainerUI.AIMEAJAHLAA(JIIGOACEIKL).PJDPPGMDBMC(BarMenuInventory.EHBMJNBPGIC().slots, BarMenuInventory.MKIDJFENNPN(), IFMNAFDGKKK: false, OGCAKIGELBJ: true, 5, oPMPOBPEDFB);
		BigContainerUI.JGNOJMLHPOK(JIIGOACEIKL).IDLAGJNLPJL();
		CommonReferences.GGFJGHHHEJC.OnBarOpened(JIIGOACEIKL);
		return false;
	}

	[SpecialName]
	public static void NJHCGMPDING(Transform AODONKKHPBP)
	{
		instance._waiterRoot = AODONKKHPBP;
	}

	private void FLKIFDEDGCD(int JIIGOACEIKL)
	{
		BigContainerUI.Get(JIIGOACEIKL).SetTrendsButtonVisible(NKFPJPCFBJI: false);
	}

	public bool ELJEJOADKCI(int JIIGOACEIKL)
	{
		return false;
	}

	public static int GetAvailableItemsCount()
	{
		IFNLFODEMOL = BarMenuInventory.GetInstance().GetAllItems().Count;
		IFNLFODEMOL += DrinkDispensersManager.GGFJGHHHEJC.GetAllDrinks().Count;
		return IFNLFODEMOL;
	}

	public void DAFFDEDGGCL(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			((Component)outline1SR).gameObject.SetActive(true);
		}
		else
		{
			((Component)outline2SR).gameObject.SetActive(false);
		}
	}
}
