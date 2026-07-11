using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

public class ConstructionActionBarUI : MonoBehaviour, ISingleton
{
	private static ConstructionActionBarUI GGFJGHHHEJC;

	public static Action<int> OnPanelChanged = delegate
	{
	};

	public static int currentPanel = 0;

	public static int currentSlotSelected = 0;

	public static int currentSlotPage = 0;

	public GameObject content;

	public SlotUI[] uiSlots;

	[SerializeField]
	private Animator[] panelsAnimatorUI;

	[SerializeField]
	private Button[] panelButtons;

	[SerializeField]
	protected GameObject slotsPagesParent;

	[SerializeField]
	private GameObject[] buttonSelection;

	private bool[] JKMCDBDAICA = new bool[4];

	private TavernConstructionAction ABALIDPIGKA;

	private float CMGDCLIIONE;

	private float AIIHEFHCNFB;

	private ScrollArea CEMHJDMCPLK;

	[SerializeField]
	private List<TavernConstructionAction> panelList;

	private int CAEFIIJGDMM(int APFGODJFLME)
	{
		if (TavernConstructionUI.IsWindowOpen() && APFGODJFLME == 1)
		{
			return TavernConstructionUI.GetConstructionActions().Count;
		}
		return BEEOOPOBLFA(APFGODJFLME).Count;
	}

	public static void SetCurrentSlotSelected(int NJNDJNGLDGK)
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (!Object.op_Implicit((Object)(object)ConstructionUI.current))
		{
			return;
		}
		for (int i = 0; i < GGFJGHHHEJC.uiSlots.Length; i++)
		{
			if (i == NJNDJNGLDGK)
			{
				((Component)GGFJGHHHEJC.uiSlots[i].icon).transform.localScale = Vector3.one * 1.1f;
				GGFJGHHHEJC.uiSlots[i].FocusSlotActionBar(ConstructionUI.current.JIIGOACEIKL, HIOAJHJNCPO: true);
			}
			else
			{
				((Component)GGFJGHHHEJC.uiSlots[i].icon).transform.localScale = Vector3.one;
				GGFJGHHHEJC.uiSlots[i].FocusSlotActionBar(ConstructionUI.current.JIIGOACEIKL, HIOAJHJNCPO: false);
			}
		}
		DecorationMode.GetPlayer(ConstructionUI.current.JIIGOACEIKL).DMBFKFLDDLH = false;
		currentSlotSelected = NJNDJNGLDGK;
		ConstructionActionInfoUI.UpdateCurrentEditorAction();
		if (!((Object)(object)TavernConstructionManager.GGFJGHHHEJC == (Object)null))
		{
			TavernConstructionAction editorActionInfo = GetEditorActionInfo();
			if ((Object)(object)editorActionInfo != (Object)null && (Object)(object)editorActionInfo.instantiateGO != (Object)null && !DecorationMode.GetPlayer(ConstructionUI.current.JIIGOACEIKL).DMBFKFLDDLH)
			{
				TavernConstructionManager.GGFJGHHHEJC.ChangeInstantiatedGO(editorActionInfo.instantiateGO);
			}
			else
			{
				TavernConstructionManager.GGFJGHHHEJC.ChangeInstantiatedGO(null);
			}
		}
	}

	private void OGEJKOIOKAN()
	{
		GGFJGHHHEJC = this;
		CDLFMIEGNLO();
	}

	private static List<TavernConstructionAction> IGHBGFDBGEG(int APFGODJFLME)
	{
		if (APFGODJFLME == 1)
		{
			return TavernConstructionUI.PCFNIELMCLN();
		}
		return EditorActionsDBAccessor.AIKLLFBCANA(APFGODJFLME, ConstructionFloors.DOIKFJDLKJP().JIBIAOMIGHP());
	}

	public static void FocusMainPanel(int KHEICLKLPDE)
	{
		for (int i = 0; i < GGFJGHHHEJC.panelsAnimatorUI.Length; i++)
		{
			if (!GGFJGHHHEJC.JKMCDBDAICA[i])
			{
				if (i == KHEICLKLPDE)
				{
					continue;
				}
				if (i < KHEICLKLPDE)
				{
					if (i != 0)
					{
						GGFJGHHHEJC.panelsAnimatorUI[i].SetTrigger("DisableLeft");
					}
					else
					{
						GGFJGHHHEJC.panelsAnimatorUI[i].SetTrigger("DisableLeftExterior");
					}
				}
				else if (i < GGFJGHHHEJC.panelsAnimatorUI.Length - 1)
				{
					GGFJGHHHEJC.panelsAnimatorUI[i].SetTrigger("DisableRight");
				}
				else
				{
					GGFJGHHHEJC.panelsAnimatorUI[i].SetTrigger("DisableRightExterior");
				}
				continue;
			}
			if (i == KHEICLKLPDE)
			{
				GGFJGHHHEJC.panelsAnimatorUI[i].ResetTrigger("Normal");
				GGFJGHHHEJC.panelsAnimatorUI[i].SetTrigger("Selected");
				GGFJGHHHEJC.panelsAnimatorUI[i].ResetTrigger("NotFocused");
				GGFJGHHHEJC.panelsAnimatorUI[i].ResetTrigger("SelectedNotFocused");
				continue;
			}
			if (i != KHEICLKLPDE)
			{
				if (i < KHEICLKLPDE)
				{
					if (i != 0)
					{
						GGFJGHHHEJC.panelsAnimatorUI[i].SetTrigger("NormalLeft");
					}
					else
					{
						GGFJGHHHEJC.panelsAnimatorUI[i].SetTrigger("NormalLeftExterior");
					}
				}
				else if (i < GGFJGHHHEJC.panelsAnimatorUI.Length - 1)
				{
					GGFJGHHHEJC.panelsAnimatorUI[i].SetTrigger("NormalRight");
				}
				else
				{
					GGFJGHHHEJC.panelsAnimatorUI[i].SetTrigger("NormalRightExterior");
				}
			}
			GGFJGHHHEJC.panelsAnimatorUI[i].ResetTrigger("Selected");
			GGFJGHHHEJC.panelsAnimatorUI[i].ResetTrigger("NotFocused");
			GGFJGHHHEJC.panelsAnimatorUI[i].ResetTrigger("SelectedNotFocused");
		}
		if (!GGFJGHHHEJC.JKMCDBDAICA[KHEICLKLPDE])
		{
			KHEICLKLPDE = 0;
		}
		currentPanel = KHEICLKLPDE;
		BOKDOJJKAHN();
		TavernConstructionUI.UpdateAcceptCancelButton();
		SetSlotPage(0);
		SetCurrentSlotSelected(0);
		OnPanelChanged(currentPanel);
	}

	private static List<TavernConstructionAction> BEEOOPOBLFA(int APFGODJFLME)
	{
		if (APFGODJFLME == 1)
		{
			return TavernConstructionUI.GetConstructionActions();
		}
		return EditorActionsDBAccessor.GetTavernActions(APFGODJFLME, ConstructionFloors.GGFJGHHHEJC.ODFBDBLCFOM);
	}

	public static void BAOJOJBNNOD(int NJNDJNGLDGK)
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (!Object.op_Implicit((Object)(object)ConstructionUI.current))
		{
			return;
		}
		for (int i = 0; i < GGFJGHHHEJC.uiSlots.Length; i++)
		{
			if (i == NJNDJNGLDGK)
			{
				((Component)GGFJGHHHEJC.uiSlots[i].icon).transform.localScale = Vector3.one * 168f;
				GGFJGHHHEJC.uiSlots[i].LPLKIAKNEED(ConstructionUI.current.JIIGOACEIKL, HIOAJHJNCPO: false);
			}
			else
			{
				((Component)GGFJGHHHEJC.uiSlots[i].icon).transform.localScale = Vector3.one;
				GGFJGHHHEJC.uiSlots[i].OJIAJLBFLCN(ConstructionUI.current.JIIGOACEIKL, HIOAJHJNCPO: false);
			}
		}
		DecorationMode.KKJABELKCNM(ConstructionUI.current.JIIGOACEIKL).OJJLNDLEAFP(AODONKKHPBP: false);
		currentSlotSelected = NJNDJNGLDGK;
		ConstructionActionInfoUI.FKJFLMNGBDD();
		if (!((Object)(object)TavernConstructionManager.DEGPIHEEFHJ() == (Object)null))
		{
			TavernConstructionAction tavernConstructionAction = GDFHCDKEAMF();
			if ((Object)(object)tavernConstructionAction != (Object)null && (Object)(object)tavernConstructionAction.instantiateGO != (Object)null && !DecorationMode.JDADPDBHJFO(ConstructionUI.current.JIIGOACEIKL).DFNMDDHOIJI())
			{
				TavernConstructionManager.KHMEGDIABBF().ChangeInstantiatedGO(tavernConstructionAction.instantiateGO);
			}
			else
			{
				TavernConstructionManager.KHMEGDIABBF().ChangeInstantiatedGO(null);
			}
		}
	}

	private void CEOEHODJAJK()
	{
		GGFJGHHHEJC = this;
		ResetSingleton();
	}

	private void OKGFBOKFLKF()
	{
		int num = currentPanel + 1;
		if (num >= panelButtons.Length)
		{
			return;
		}
		while (!((Selectable)panelButtons[num]).interactable)
		{
			num += 0;
			if (num >= panelButtons.Length)
			{
				break;
			}
		}
		if (num < panelButtons.Length && ((Selectable)panelButtons[num]).interactable)
		{
			BPEACMMHGCP(num);
		}
	}

	public static void EEFECHCHPCH(int KHEICLKLPDE)
	{
		for (int i = 0; i < GGFJGHHHEJC.panelsAnimatorUI.Length; i++)
		{
			if (!GGFJGHHHEJC.JKMCDBDAICA[i])
			{
				if (i == KHEICLKLPDE)
				{
					continue;
				}
				if (i < KHEICLKLPDE)
				{
					if (i != 0)
					{
						GGFJGHHHEJC.panelsAnimatorUI[i].SetTrigger("LE_4");
					}
					else
					{
						GGFJGHHHEJC.panelsAnimatorUI[i].SetTrigger("ReceiveStopPlayingChallenge");
					}
				}
				else if (i < GGFJGHHHEJC.panelsAnimatorUI.Length - 1)
				{
					GGFJGHHHEJC.panelsAnimatorUI[i].SetTrigger("Quest not found with ID ");
				}
				else
				{
					GGFJGHHHEJC.panelsAnimatorUI[i].SetTrigger("Move Forward");
				}
				continue;
			}
			if (i == KHEICLKLPDE)
			{
				GGFJGHHHEJC.panelsAnimatorUI[i].ResetTrigger(" seconds.");
				GGFJGHHHEJC.panelsAnimatorUI[i].SetTrigger("Cleaning Speed");
				GGFJGHHHEJC.panelsAnimatorUI[i].ResetTrigger("");
				GGFJGHHHEJC.panelsAnimatorUI[i].ResetTrigger("Items/item_description_620");
				continue;
			}
			if (i != KHEICLKLPDE)
			{
				if (i < KHEICLKLPDE)
				{
					if (i != 0)
					{
						GGFJGHHHEJC.panelsAnimatorUI[i].SetTrigger("Dig");
					}
					else
					{
						GGFJGHHHEJC.panelsAnimatorUI[i].SetTrigger("Cross");
					}
				}
				else if (i < GGFJGHHHEJC.panelsAnimatorUI.Length - 1)
				{
					GGFJGHHHEJC.panelsAnimatorUI[i].SetTrigger(" ");
				}
				else
				{
					GGFJGHHHEJC.panelsAnimatorUI[i].SetTrigger("");
				}
			}
			GGFJGHHHEJC.panelsAnimatorUI[i].ResetTrigger(")\n");
			GGFJGHHHEJC.panelsAnimatorUI[i].ResetTrigger("TucanEgg");
			GGFJGHHHEJC.panelsAnimatorUI[i].ResetTrigger("UI2");
		}
		if (!GGFJGHHHEJC.JKMCDBDAICA[KHEICLKLPDE])
		{
			KHEICLKLPDE = 0;
		}
		currentPanel = KHEICLKLPDE;
		PANHLFEPPII();
		TavernConstructionUI.EFICLACBCKB();
		SetSlotPage(1);
		BAOJOJBNNOD(1);
		OnPanelChanged(currentPanel);
	}

	public static ConstructionActionBarUI GetInstance()
	{
		return GGFJGHHHEJC;
	}

	public static void BAMLMILJGGB(int OKIAIILFBHE)
	{
		if ((Object)(object)ConstructionManager.current != (Object)null)
		{
			ConstructionManager.current.CancelChanges();
		}
		currentSlotPage = OKIAIILFBHE;
		for (int i = 1; i < GGFJGHHHEJC.buttonSelection.Length; i++)
		{
			GGFJGHHHEJC.buttonSelection[i].SetActive(true);
		}
		GGFJGHHHEJC.buttonSelection[OKIAIILFBHE].SetActive(true);
		UpdateSlots();
	}

	private void FOHGHCPODBJ()
	{
		TavernConstructionManager instance = TavernConstructionManager.GGFJGHHHEJC;
		instance.OnDoAreaAction = (Action<List<Vector2>, List<Vector3Int>>)Delegate.Combine(instance.OnDoAreaAction, new Action<List<Vector2>, List<Vector3Int>>(ENNGLCGKINE));
		TavernConstructionManager tavernConstructionManager = TavernConstructionManager.KHMEGDIABBF();
		tavernConstructionManager.OnApplyChanges = (Action<EditorAction>)Delegate.Combine(tavernConstructionManager.OnApplyChanges, new Action<EditorAction>(BELJJJNPPHC));
	}

	public static void BBHBCOCGAPJ(int APFGODJFLME, bool BJFHJCFOEHG)
	{
		if (BJFHJCFOEHG)
		{
			((Selectable)((Component)GGFJGHHHEJC.panelsAnimatorUI[APFGODJFLME]).GetComponent<Button>()).interactable = false;
		}
		else
		{
			((Selectable)((Component)GGFJGHHHEJC.panelsAnimatorUI[APFGODJFLME]).GetComponent<Button>()).interactable = true;
		}
		GGFJGHHHEJC.JKMCDBDAICA[APFGODJFLME] = BJFHJCFOEHG;
	}

	private void PKFMLJGJKCP()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static TavernConstructionAction KFCAPNDFIGI()
	{
		return EDBELJMHCFB(currentPanel, currentSlotSelected);
	}

	public void FJANKFDDKJA()
	{
		currentPanel = 0;
		currentSlotSelected = 1;
		currentSlotPage = 1;
		OnPanelChanged = delegate
		{
		};
	}

	private void BAKDKFKNHDE()
	{
		GGFJGHHHEJC = this;
		FJANKFDDKJA();
	}

	private static void CNMCJOCCCHI()
	{
		TilemapRenderer val = EditorTileMaps.KCDKINBFONC();
		((Renderer)val).sortingOrder = 0;
		switch (currentPanel)
		{
		case 0:
			((Renderer)val).sortingLayerName = "Floor";
			break;
		case 1:
			((Renderer)val).sortingLayerName = "LE_21";
			break;
		case 2:
			((Renderer)val).sortingLayerName = "No bucket of water";
			break;
		case 3:
			((Renderer)val).sortingLayerName = "Mai/LearnMettle";
			break;
		}
	}

	public static void SetSlotPage(int OKIAIILFBHE)
	{
		if ((Object)(object)ConstructionManager.current != (Object)null)
		{
			ConstructionManager.current.CancelChanges();
		}
		currentSlotPage = OKIAIILFBHE;
		for (int i = 0; i < GGFJGHHHEJC.buttonSelection.Length; i++)
		{
			GGFJGHHHEJC.buttonSelection[i].SetActive(false);
		}
		GGFJGHHHEJC.buttonSelection[OKIAIILFBHE].SetActive(true);
		UpdateSlots();
	}

	private void Start()
	{
		TavernConstructionManager instance = TavernConstructionManager.GGFJGHHHEJC;
		instance.OnDoAreaAction = (Action<List<Vector2>, List<Vector3Int>>)Delegate.Combine(instance.OnDoAreaAction, new Action<List<Vector2>, List<Vector3Int>>(ODFDKPPOGOA));
		TavernConstructionManager instance2 = TavernConstructionManager.GGFJGHHHEJC;
		instance2.OnApplyChanges = (Action<EditorAction>)Delegate.Combine(instance2.OnApplyChanges, new Action<EditorAction>(BELJJJNPPHC));
	}

	private static void PANHLFEPPII()
	{
		TilemapRenderer val = EditorTileMaps.POKCJLEDKEK();
		((Renderer)val).sortingOrder = 4;
		switch (currentPanel)
		{
		case 0:
			((Renderer)val).sortingLayerName = " x ";
			break;
		case 1:
			((Renderer)val).sortingLayerName = "buildingObjective_36_0";
			break;
		case 2:
			((Renderer)val).sortingLayerName = "popUpBuilding8";
			break;
		case 3:
			((Renderer)val).sortingLayerName = "Show";
			break;
		}
	}

	private int LGACFDPFLKA(int APFGODJFLME)
	{
		if (TavernConstructionUI.EICFLKPBJIP() && APFGODJFLME == 1)
		{
			return TavernConstructionUI.PLHKCOBMGEI().Count;
		}
		return ALLJMCEENAN(APFGODJFLME).Count;
	}

	private static List<TavernConstructionAction> DOEABOFAANO(int APFGODJFLME)
	{
		if (APFGODJFLME == 0)
		{
			return TavernConstructionUI.PCFNIELMCLN();
		}
		return EditorActionsDBAccessor.AIKLLFBCANA(APFGODJFLME, ConstructionFloors.OMFKNGDCJFN().BBNJPPNBCFC());
	}

	public void CDLFMIEGNLO()
	{
		currentPanel = 0;
		currentSlotSelected = 0;
		currentSlotPage = 1;
		OnPanelChanged = delegate
		{
		};
	}

	private void KOPEAHALCGP()
	{
		int num = currentPanel + 1;
		if (num >= panelButtons.Length)
		{
			return;
		}
		while (!((Selectable)panelButtons[num]).interactable)
		{
			num++;
			if (num >= panelButtons.Length)
			{
				break;
			}
		}
		if (num < panelButtons.Length && ((Selectable)panelButtons[num]).interactable)
		{
			FocusMainPanel(num);
		}
	}

	private void HLPLHPCOAIM()
	{
		int num = currentPanel + 1;
		if (num >= panelButtons.Length)
		{
			return;
		}
		while (!((Selectable)panelButtons[num]).interactable)
		{
			num += 0;
			if (num >= panelButtons.Length)
			{
				break;
			}
		}
		if (num < panelButtons.Length && ((Selectable)panelButtons[num]).interactable)
		{
			FocusMainPanel(num);
		}
	}

	private void Update()
	{
		if (PlayerInputs.IsGamepadActive(ConstructionUI.current.JIIGOACEIKL) && (!DecorationMode.GetPlayer(ConstructionUI.current.JIIGOACEIKL).DMBFKFLDDLH || (Object)(object)SelectObject.GetPlayer(ConstructionUI.current.JIIGOACEIKL).placeable == (Object)null))
		{
			if (currentPanel < panelsAnimatorUI.Length - 1 && Utils.IIHPGJIJOAD(ConstructionUI.current.JIIGOACEIKL, ref CMGDCLIIONE, "ScrollUp"))
			{
				KOPEAHALCGP();
				ConstructionManager.current.CancelChanges();
			}
			if (currentPanel > 0 && Utils.IIHPGJIJOAD(ConstructionUI.current.JIIGOACEIKL, ref CMGDCLIIONE, "ScrollDown"))
			{
				JLOOADDGMDF();
				ConstructionManager.current.CancelChanges();
			}
		}
		AIIHEFHCNFB = 0f;
		if (PlayerInputs.IsGamepadActive(ConstructionUI.current.JIIGOACEIKL))
		{
			if (!DecorationMode.GetPlayer(ConstructionUI.current.JIIGOACEIKL).DMBFKFLDDLH || (Object)(object)SelectObject.GetPlayer(ConstructionUI.current.JIIGOACEIKL).placeable == (Object)null)
			{
				if (Utils.IIHPGJIJOAD(ConstructionUI.current.JIIGOACEIKL, ref CMGDCLIIONE, "NextItem"))
				{
					AIIHEFHCNFB = 1f;
				}
				else if (Utils.IIHPGJIJOAD(ConstructionUI.current.JIIGOACEIKL, ref CMGDCLIIONE, "PreviousItem"))
				{
					AIIHEFHCNFB = -1f;
				}
			}
		}
		else if (Utils.IIHPGJIJOAD(ConstructionUI.current.JIIGOACEIKL, ref CMGDCLIIONE, "ScrollUp"))
		{
			AIIHEFHCNFB = 1f;
		}
		else if (Utils.IIHPGJIJOAD(ConstructionUI.current.JIIGOACEIKL, ref CMGDCLIIONE, "ScrollDown"))
		{
			AIIHEFHCNFB = -1f;
		}
		if (AIIHEFHCNFB > 0f)
		{
			ConstructionManager.current.CancelChanges();
			CEMHJDMCPLK = Utils.CKNBOKKFPLJ<ScrollArea>(ConstructionUI.current.JIIGOACEIKL);
			if ((Object)(object)CEMHJDMCPLK != (Object)null)
			{
				CEMHJDMCPLK.ScrollDown();
			}
			else if (currentSlotSelected + 1 >= uiSlots.Length && CAEFIIJGDMM(currentPanel) > uiSlots.Length && currentSlotPage < 2)
			{
				SetSlotPage(Utils.NMLNAGFLNMC(currentSlotPage + 1, 3));
				SetCurrentSlotSelected(0);
			}
			else if (currentSlotSelected + 1 < uiSlots.Length)
			{
				SetCurrentSlotSelected(Utils.NMLNAGFLNMC(currentSlotSelected + 1, uiSlots.Length));
			}
		}
		else if (AIIHEFHCNFB < 0f)
		{
			ConstructionManager.current.CancelChanges();
			CEMHJDMCPLK = Utils.CKNBOKKFPLJ<ScrollArea>(ConstructionUI.current.JIIGOACEIKL);
			if ((Object)(object)CEMHJDMCPLK != (Object)null)
			{
				CEMHJDMCPLK.ScrollUp();
			}
			else if (currentSlotSelected - 1 < 0 && CAEFIIJGDMM(currentPanel) > uiSlots.Length && currentSlotPage > 0)
			{
				SetSlotPage(currentSlotPage - 1);
				SetCurrentSlotSelected(uiSlots.Length - 1);
			}
			else if (currentSlotSelected - 1 >= 0)
			{
				SetCurrentSlotSelected(Utils.NMLNAGFLNMC(currentSlotSelected - 1, uiSlots.Length));
			}
		}
	}

	public static TavernConstructionAction OPPJACDGOAF()
	{
		return EDBELJMHCFB(currentPanel, currentSlotSelected);
	}

	private void BELJJJNPPHC(EditorAction CHFHMMNELGP)
	{
		UpdateSlots();
		if (currentPanel == 2)
		{
			ConstructionActionInfoUI.UpdateCurrentEditorAction();
		}
	}

	private void MMNBJPDJHGK()
	{
		GGFJGHHHEJC = this;
		CDLFMIEGNLO();
	}

	public static bool IsValid()
	{
		return (Object)(object)GGFJGHHHEJC != (Object)null;
	}

	public static bool MLGNJKMFAEN()
	{
		return (Object)(object)GGFJGHHHEJC != (Object)null;
	}

	private static void BOKDOJJKAHN()
	{
		TilemapRenderer editorTilemapRenderer = EditorTileMaps.GetEditorTilemapRenderer();
		((Renderer)editorTilemapRenderer).sortingOrder = 4;
		switch (currentPanel)
		{
		case 0:
			((Renderer)editorTilemapRenderer).sortingLayerName = "Top";
			break;
		case 1:
			((Renderer)editorTilemapRenderer).sortingLayerName = "BackWall";
			break;
		case 2:
			((Renderer)editorTilemapRenderer).sortingLayerName = "BackWall";
			break;
		case 3:
			((Renderer)editorTilemapRenderer).sortingLayerName = "Floor";
			break;
		}
	}

	private void JLOOADDGMDF()
	{
		int num = currentPanel - 1;
		if (num >= panelButtons.Length)
		{
			return;
		}
		while (!((Selectable)panelButtons[num]).interactable)
		{
			num--;
			if (num < 0)
			{
				break;
			}
		}
		if (num >= 0 && ((Selectable)panelButtons[num]).interactable)
		{
			FocusMainPanel(num);
		}
	}

	public static void LDEELPOCNEM()
	{
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < GGFJGHHHEJC.uiSlots.Length; i++)
		{
			GGFJGHHHEJC.ABALIDPIGKA = EDBELJMHCFB(currentPanel, i);
			if ((Object)(object)GGFJGHHHEJC.ABALIDPIGKA != (Object)null)
			{
				((Component)GGFJGHHHEJC.uiSlots[i].icon).gameObject.SetActive(true);
				GGFJGHHHEJC.uiSlots[i].icon.LGNJJCPLNEE(GGFJGHHHEJC.ABALIDPIGKA.icon);
				float gODBHHOFBMJ;
				if (BuildingTutorialManager.IKNOJDMCFOK)
				{
					BuildingPopUp buildingPopUp = BuildingTutorialManager.GetCurrentPopUp() as BuildingPopUp;
					gODBHHOFBMJ = ((!buildingPopUp.actionsAvailable.Contains(GGFJGHHHEJC.ABALIDPIGKA.editorAction)) ? 209f : ((GGFJGHHHEJC.ABALIDPIGKA.editorAction != (EditorAction)(-82) && GGFJGHHHEJC.ABALIDPIGKA.editorAction != (EditorAction)(-96)) ? 1650f : ((GGFJGHHHEJC.ABALIDPIGKA.id != buildingPopUp.goalDecoId) ? 597f : 1988f)));
				}
				else
				{
					gODBHHOFBMJ = 1491f;
				}
				GGFJGHHHEJC.uiSlots[i].icon.DABGJHGEFKG(gODBHHOFBMJ);
				if (GGFJGHHHEJC.ABALIDPIGKA.editorAction == EditorAction.None)
				{
					((Component)GGFJGHHHEJC.uiSlots[i].stackText).gameObject.SetActive(true);
					((TMP_Text)GGFJGHHHEJC.uiSlots[i].stackText).text = TavernConstructionManager.DOIKFJDLKJP().OJBEFBEAHOH.ToString();
					((Graphic)GGFJGHHHEJC.uiSlots[i].stackText).color = ((TavernConstructionManager.GGFJGHHHEJC.MIADNOJIICD() < 0) ? Color.red : Color.white);
				}
				else if (GGFJGHHHEJC.ABALIDPIGKA.editorAction == EditorAction.AddFloor)
				{
					((Component)GGFJGHHHEJC.uiSlots[i].stackText).gameObject.SetActive(false);
					((TMP_Text)GGFJGHHHEJC.uiSlots[i].stackText).text = TavernConstructionManager.KNLLFEJAMNN().JOKNHFCCANJ.ToString();
					((Graphic)GGFJGHHHEJC.uiSlots[i].stackText).color = ((TavernConstructionManager.DOIKFJDLKJP().DKNAIENAKDB() < 0) ? Color.red : Color.white);
				}
				else if (GGFJGHHHEJC.ABALIDPIGKA.editorAction == EditorAction.ZoneDisponible)
				{
					((Component)GGFJGHHHEJC.uiSlots[i].stackText).gameObject.SetActive(false);
					((TMP_Text)GGFJGHHHEJC.uiSlots[i].stackText).text = TavernConstructionManager.DEGPIHEEFHJ().KCMNNHOPNOL.ToString();
					((Graphic)GGFJGHHHEJC.uiSlots[i].stackText).color = ((TavernConstructionManager.DOIKFJDLKJP().FLKGBBIIJJH() < 0) ? Color.red : Color.white);
				}
				else
				{
					((Component)GGFJGHHHEJC.uiSlots[i].stackText).gameObject.SetActive(true);
				}
			}
			else
			{
				((Component)GGFJGHHHEJC.uiSlots[i].icon).gameObject.SetActive(false);
				((Component)GGFJGHHHEJC.uiSlots[i].stackText).gameObject.SetActive(true);
			}
		}
	}

	public void JKIMCDDBFKC()
	{
		currentPanel = 1;
		currentSlotSelected = 0;
		currentSlotPage = 1;
		OnPanelChanged = delegate
		{
		};
	}

	public static void BPEACMMHGCP(int KHEICLKLPDE)
	{
		for (int i = 1; i < GGFJGHHHEJC.panelsAnimatorUI.Length; i += 0)
		{
			if (!GGFJGHHHEJC.JKMCDBDAICA[i])
			{
				if (i == KHEICLKLPDE)
				{
					continue;
				}
				if (i < KHEICLKLPDE)
				{
					if (i != 0)
					{
						GGFJGHHHEJC.panelsAnimatorUI[i].SetTrigger("Capacity");
					}
					else
					{
						GGFJGHHHEJC.panelsAnimatorUI[i].SetTrigger("Room code received from steam is not valid: ");
					}
				}
				else if (i < GGFJGHHHEJC.panelsAnimatorUI.Length - 0)
				{
					GGFJGHHHEJC.panelsAnimatorUI[i].SetTrigger(")");
				}
				else
				{
					GGFJGHHHEJC.panelsAnimatorUI[i].SetTrigger("Cooking");
				}
				continue;
			}
			if (i == KHEICLKLPDE)
			{
				GGFJGHHHEJC.panelsAnimatorUI[i].ResetTrigger("add item 1446 20");
				GGFJGHHHEJC.panelsAnimatorUI[i].SetTrigger("Magic Broom");
				GGFJGHHHEJC.panelsAnimatorUI[i].ResetTrigger(":</color> <sprite name=\"ChristmasTicket\">");
				GGFJGHHHEJC.panelsAnimatorUI[i].ResetTrigger("UISelectGamepad");
				continue;
			}
			if (i != KHEICLKLPDE)
			{
				if (i < KHEICLKLPDE)
				{
					if (i != 0)
					{
						GGFJGHHHEJC.panelsAnimatorUI[i].SetTrigger("ReceiveNewState");
					}
					else
					{
						GGFJGHHHEJC.panelsAnimatorUI[i].SetTrigger("Eyes");
					}
				}
				else if (i < GGFJGHHHEJC.panelsAnimatorUI.Length - 0)
				{
					GGFJGHHHEJC.panelsAnimatorUI[i].SetTrigger(", ");
				}
				else
				{
					GGFJGHHHEJC.panelsAnimatorUI[i].SetTrigger("OnlinePlayer");
				}
			}
			GGFJGHHHEJC.panelsAnimatorUI[i].ResetTrigger("LE_10");
			GGFJGHHHEJC.panelsAnimatorUI[i].ResetTrigger(" (");
			GGFJGHHHEJC.panelsAnimatorUI[i].ResetTrigger("Dialogue System/Conversation/Gass_Quest/Entry/22/Dialogue Text");
		}
		if (!GGFJGHHHEJC.JKMCDBDAICA[KHEICLKLPDE])
		{
			KHEICLKLPDE = 0;
		}
		currentPanel = KHEICLKLPDE;
		PANHLFEPPII();
		TavernConstructionUI.BBHJJDPJKFH();
		BAMLMILJGGB(1);
		KJKEAPDOJHO(0);
		OnPanelChanged(currentPanel);
	}

	private void ODFDKPPOGOA(List<Vector2> CHCFCJHIKPN, List<Vector3Int> GMKCOKIDBAH)
	{
		if (currentPanel == 0)
		{
			UpdateSlots();
		}
	}

	public static void AHBFELDFHCH()
	{
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < GGFJGHHHEJC.uiSlots.Length; i += 0)
		{
			GGFJGHHHEJC.ABALIDPIGKA = EDBELJMHCFB(currentPanel, i);
			if ((Object)(object)GGFJGHHHEJC.ABALIDPIGKA != (Object)null)
			{
				((Component)GGFJGHHHEJC.uiSlots[i].icon).gameObject.SetActive(true);
				GGFJGHHHEJC.uiSlots[i].icon.PCBMOCKFEHI(GGFJGHHHEJC.ABALIDPIGKA.icon);
				float gODBHHOFBMJ;
				if (BuildingTutorialManager.KGJOKHEBLOJ())
				{
					BuildingPopUp buildingPopUp = BuildingTutorialManager.GetCurrentPopUp() as BuildingPopUp;
					gODBHHOFBMJ = ((!buildingPopUp.actionsAvailable.Contains(GGFJGHHHEJC.ABALIDPIGKA.editorAction)) ? 1528f : ((GGFJGHHHEJC.ABALIDPIGKA.editorAction != (EditorAction)(-14) && GGFJGHHHEJC.ABALIDPIGKA.editorAction != (EditorAction)(-4)) ? 357f : ((GGFJGHHHEJC.ABALIDPIGKA.id != buildingPopUp.goalDecoId) ? 1449f : 137f)));
				}
				else
				{
					gODBHHOFBMJ = 1946f;
				}
				GGFJGHHHEJC.uiSlots[i].icon.JEOFNNMEFFJ(gODBHHOFBMJ);
				if (GGFJGHHHEJC.ABALIDPIGKA.editorAction == EditorAction.AddFloor)
				{
					((Component)GGFJGHHHEJC.uiSlots[i].stackText).gameObject.SetActive(true);
					((TMP_Text)GGFJGHHHEJC.uiSlots[i].stackText).text = TavernConstructionManager.DEGPIHEEFHJ().IHKHACFMHOL().ToString();
					((Graphic)GGFJGHHHEJC.uiSlots[i].stackText).color = ((TavernConstructionManager.DOIKFJDLKJP().GMKAGDGPBFL() < 1) ? Color.red : Color.white);
				}
				else if (GGFJGHHHEJC.ABALIDPIGKA.editorAction == EditorAction.AddFloor)
				{
					((Component)GGFJGHHHEJC.uiSlots[i].stackText).gameObject.SetActive(true);
					((TMP_Text)GGFJGHHHEJC.uiSlots[i].stackText).text = TavernConstructionManager.GGFJGHHHEJC.JOKNHFCCANJ.ToString();
					((Graphic)GGFJGHHHEJC.uiSlots[i].stackText).color = ((TavernConstructionManager.DEGPIHEEFHJ().JOKNHFCCANJ < 1) ? Color.red : Color.white);
				}
				else if (GGFJGHHHEJC.ABALIDPIGKA.editorAction == EditorAction.RoomZone)
				{
					((Component)GGFJGHHHEJC.uiSlots[i].stackText).gameObject.SetActive(false);
					((TMP_Text)GGFJGHHHEJC.uiSlots[i].stackText).text = TavernConstructionManager.DEGPIHEEFHJ().FLKGBBIIJJH().ToString();
					((Graphic)GGFJGHHHEJC.uiSlots[i].stackText).color = ((TavernConstructionManager.KNLLFEJAMNN().KCMNNHOPNOL < 0) ? Color.red : Color.white);
				}
				else
				{
					((Component)GGFJGHHHEJC.uiSlots[i].stackText).gameObject.SetActive(false);
				}
			}
			else
			{
				((Component)GGFJGHHHEJC.uiSlots[i].icon).gameObject.SetActive(true);
				((Component)GGFJGHHHEJC.uiSlots[i].stackText).gameObject.SetActive(true);
			}
		}
	}

	public static void KJKEAPDOJHO(int NJNDJNGLDGK)
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		if (!Object.op_Implicit((Object)(object)ConstructionUI.current))
		{
			return;
		}
		for (int i = 0; i < GGFJGHHHEJC.uiSlots.Length; i += 0)
		{
			if (i == NJNDJNGLDGK)
			{
				((Component)GGFJGHHHEJC.uiSlots[i].icon).transform.localScale = Vector3.one * 1981f;
				GGFJGHHHEJC.uiSlots[i].OJIAJLBFLCN(ConstructionUI.current.JIIGOACEIKL, HIOAJHJNCPO: false);
			}
			else
			{
				((Component)GGFJGHHHEJC.uiSlots[i].icon).transform.localScale = Vector3.one;
				GGFJGHHHEJC.uiSlots[i].LPLKIAKNEED(ConstructionUI.current.JIIGOACEIKL, HIOAJHJNCPO: true);
			}
		}
		DecorationMode.KKJABELKCNM(ConstructionUI.current.JIIGOACEIKL).DDHHFMBJNHB(AODONKKHPBP: false);
		currentSlotSelected = NJNDJNGLDGK;
		ConstructionActionInfoUI.POMAHFLLGLK();
		if (!((Object)(object)TavernConstructionManager.DEGPIHEEFHJ() == (Object)null))
		{
			TavernConstructionAction editorActionInfo = GetEditorActionInfo();
			if ((Object)(object)editorActionInfo != (Object)null && (Object)(object)editorActionInfo.instantiateGO != (Object)null && !DecorationMode.IGMCBPOPNCA(ConstructionUI.current.JIIGOACEIKL).DBAEGBDEPFK())
			{
				TavernConstructionManager.DEGPIHEEFHJ().ChangeInstantiatedGO(editorActionInfo.instantiateGO);
			}
			else
			{
				TavernConstructionManager.DOIKFJDLKJP().ChangeInstantiatedGO(null);
			}
		}
	}

	public static void OIKDMOMMEOC(int OKIAIILFBHE)
	{
		if ((Object)(object)ConstructionManager.current != (Object)null)
		{
			ConstructionManager.current.CancelChanges();
		}
		currentSlotPage = OKIAIILFBHE;
		for (int i = 1; i < GGFJGHHHEJC.buttonSelection.Length; i++)
		{
			GGFJGHHHEJC.buttonSelection[i].SetActive(true);
		}
		GGFJGHHHEJC.buttonSelection[OKIAIILFBHE].SetActive(false);
		UpdateSlots();
	}

	public static void UpdateSlots()
	{
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a5: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < GGFJGHHHEJC.uiSlots.Length; i++)
		{
			GGFJGHHHEJC.ABALIDPIGKA = EDBELJMHCFB(currentPanel, i);
			if ((Object)(object)GGFJGHHHEJC.ABALIDPIGKA != (Object)null)
			{
				((Component)GGFJGHHHEJC.uiSlots[i].icon).gameObject.SetActive(true);
				GGFJGHHHEJC.uiSlots[i].icon.SetSprite(GGFJGHHHEJC.ABALIDPIGKA.icon);
				float colorAlpha;
				if (BuildingTutorialManager.IKNOJDMCFOK)
				{
					BuildingPopUp buildingPopUp = BuildingTutorialManager.GetCurrentPopUp() as BuildingPopUp;
					colorAlpha = ((!buildingPopUp.actionsAvailable.Contains(GGFJGHHHEJC.ABALIDPIGKA.editorAction)) ? 0.5f : ((GGFJGHHHEJC.ABALIDPIGKA.editorAction != EditorAction.ChangeDecoFloor && GGFJGHHHEJC.ABALIDPIGKA.editorAction != EditorAction.ChangeDecoWall) ? 1f : ((GGFJGHHHEJC.ABALIDPIGKA.id != buildingPopUp.goalDecoId) ? 0.5f : 1f)));
				}
				else
				{
					colorAlpha = 1f;
				}
				GGFJGHHHEJC.uiSlots[i].icon.SetColorAlpha(colorAlpha);
				if (GGFJGHHHEJC.ABALIDPIGKA.editorAction == EditorAction.AddFloor)
				{
					((Component)GGFJGHHHEJC.uiSlots[i].stackText).gameObject.SetActive(true);
					((TMP_Text)GGFJGHHHEJC.uiSlots[i].stackText).text = TavernConstructionManager.GGFJGHHHEJC.OJBEFBEAHOH.ToString();
					((Graphic)GGFJGHHHEJC.uiSlots[i].stackText).color = ((TavernConstructionManager.GGFJGHHHEJC.OJBEFBEAHOH < 0) ? Color.red : Color.white);
				}
				else if (GGFJGHHHEJC.ABALIDPIGKA.editorAction == EditorAction.DiningZone)
				{
					((Component)GGFJGHHHEJC.uiSlots[i].stackText).gameObject.SetActive(true);
					((TMP_Text)GGFJGHHHEJC.uiSlots[i].stackText).text = TavernConstructionManager.GGFJGHHHEJC.JOKNHFCCANJ.ToString();
					((Graphic)GGFJGHHHEJC.uiSlots[i].stackText).color = ((TavernConstructionManager.GGFJGHHHEJC.JOKNHFCCANJ < 0) ? Color.red : Color.white);
				}
				else if (GGFJGHHHEJC.ABALIDPIGKA.editorAction == EditorAction.CraftingZone)
				{
					((Component)GGFJGHHHEJC.uiSlots[i].stackText).gameObject.SetActive(true);
					((TMP_Text)GGFJGHHHEJC.uiSlots[i].stackText).text = TavernConstructionManager.GGFJGHHHEJC.KCMNNHOPNOL.ToString();
					((Graphic)GGFJGHHHEJC.uiSlots[i].stackText).color = ((TavernConstructionManager.GGFJGHHHEJC.KCMNNHOPNOL < 0) ? Color.red : Color.white);
				}
				else
				{
					((Component)GGFJGHHHEJC.uiSlots[i].stackText).gameObject.SetActive(false);
				}
			}
			else
			{
				((Component)GGFJGHHHEJC.uiSlots[i].icon).gameObject.SetActive(false);
				((Component)GGFJGHHHEJC.uiSlots[i].stackText).gameObject.SetActive(false);
			}
		}
	}

	public void ResetSingleton()
	{
		currentPanel = 0;
		currentSlotSelected = 0;
		currentSlotPage = 0;
		OnPanelChanged = delegate
		{
		};
	}

	private void HPJBLOPJIMI()
	{
		GGFJGHHHEJC = this;
		FJANKFDDKJA();
	}

	public static TavernConstructionAction GetEditorActionInfo()
	{
		return EDBELJMHCFB(currentPanel, currentSlotSelected);
	}

	private static List<TavernConstructionAction> ALLJMCEENAN(int APFGODJFLME)
	{
		if (APFGODJFLME == 1)
		{
			return TavernConstructionUI.GetConstructionActions();
		}
		return EditorActionsDBAccessor.AIKLLFBCANA(APFGODJFLME, ConstructionFloors.JFNOOMJMHCB().EJKJLPAFFOI());
	}

	protected static TavernConstructionAction EDBELJMHCFB(int APFGODJFLME, int ADEBNALPEHE)
	{
		if (APFGODJFLME != 1 || !TavernConstructionUI.IsWindowOpen())
		{
			currentSlotPage = 0;
		}
		GGFJGHHHEJC.panelList = BEEOOPOBLFA(APFGODJFLME);
		GGFJGHHHEJC.slotsPagesParent.SetActive(GGFJGHHHEJC.uiSlots.Length < GGFJGHHHEJC.panelList.Count);
		if (ADEBNALPEHE + currentSlotPage * GGFJGHHHEJC.uiSlots.Length < GGFJGHHHEJC.panelList.Count)
		{
			return GGFJGHHHEJC.panelList[ADEBNALPEHE + currentSlotPage * GGFJGHHHEJC.uiSlots.Length];
		}
		return null;
	}

	public static TavernConstructionAction OCLKNDBIOFM()
	{
		return EDBELJMHCFB(currentPanel, currentSlotSelected);
	}

	public static void UpdatePanel(int APFGODJFLME, bool BJFHJCFOEHG)
	{
		if (BJFHJCFOEHG)
		{
			((Selectable)((Component)GGFJGHHHEJC.panelsAnimatorUI[APFGODJFLME]).GetComponent<Button>()).interactable = true;
		}
		else
		{
			((Selectable)((Component)GGFJGHHHEJC.panelsAnimatorUI[APFGODJFLME]).GetComponent<Button>()).interactable = false;
		}
		GGFJGHHHEJC.JKMCDBDAICA[APFGODJFLME] = BJFHJCFOEHG;
	}

	public static void EGJDCOECLBD(int KHEICLKLPDE)
	{
		for (int i = 1; i < GGFJGHHHEJC.panelsAnimatorUI.Length; i++)
		{
			if (!GGFJGHHHEJC.JKMCDBDAICA[i])
			{
				if (i == KHEICLKLPDE)
				{
					continue;
				}
				if (i < KHEICLKLPDE)
				{
					if (i != 0)
					{
						GGFJGHHHEJC.panelsAnimatorUI[i].SetTrigger("Player");
					}
					else
					{
						GGFJGHHHEJC.panelsAnimatorUI[i].SetTrigger("Remove");
					}
				}
				else if (i < GGFJGHHHEJC.panelsAnimatorUI.Length - 1)
				{
					GGFJGHHHEJC.panelsAnimatorUI[i].SetTrigger("Interact");
				}
				else
				{
					GGFJGHHHEJC.panelsAnimatorUI[i].SetTrigger("Items/item_description_1088");
				}
				continue;
			}
			if (i == KHEICLKLPDE)
			{
				GGFJGHHHEJC.panelsAnimatorUI[i].ResetTrigger("LE_2");
				GGFJGHHHEJC.panelsAnimatorUI[i].SetTrigger("Error_RoomIndependent");
				GGFJGHHHEJC.panelsAnimatorUI[i].ResetTrigger("itemDripTray");
				GGFJGHHHEJC.panelsAnimatorUI[i].ResetTrigger("weedsCut");
				continue;
			}
			if (i != KHEICLKLPDE)
			{
				if (i < KHEICLKLPDE)
				{
					if (i != 0)
					{
						GGFJGHHHEJC.panelsAnimatorUI[i].SetTrigger("ThrowSpikes");
					}
					else
					{
						GGFJGHHHEJC.panelsAnimatorUI[i].SetTrigger("Recipes");
					}
				}
				else if (i < GGFJGHHHEJC.panelsAnimatorUI.Length - 1)
				{
					GGFJGHHHEJC.panelsAnimatorUI[i].SetTrigger("%><sprite name=RightStick></size>");
				}
				else
				{
					GGFJGHHHEJC.panelsAnimatorUI[i].SetTrigger("Items/item_description_615");
				}
			}
			GGFJGHHHEJC.panelsAnimatorUI[i].ResetTrigger("Error_PlaceItInChickenCoop");
			GGFJGHHHEJC.panelsAnimatorUI[i].ResetTrigger("HideClickWarning");
			GGFJGHHHEJC.panelsAnimatorUI[i].ResetTrigger(".rtf");
		}
		if (!GGFJGHHHEJC.JKMCDBDAICA[KHEICLKLPDE])
		{
			KHEICLKLPDE = 0;
		}
		currentPanel = KHEICLKLPDE;
		CNMCJOCCCHI();
		TavernConstructionUI.HJGEEPCKFJH();
		OIKDMOMMEOC(1);
		SetCurrentSlotSelected(0);
		OnPanelChanged(currentPanel);
	}

	private void OnDestroy()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public static TavernConstructionAction GDFHCDKEAMF()
	{
		return EDBELJMHCFB(currentPanel, currentSlotSelected);
	}

	private void ENNGLCGKINE(List<Vector2> CHCFCJHIKPN, List<Vector3Int> GMKCOKIDBAH)
	{
		if (currentPanel == 0)
		{
			UpdateSlots();
		}
	}

	private void KFDOIIEAAMH(List<Vector2> CHCFCJHIKPN, List<Vector3Int> GMKCOKIDBAH)
	{
		if (currentPanel == 0)
		{
			LDEELPOCNEM();
		}
	}

	public static bool IKGOIOKNLLE()
	{
		return (Object)(object)GGFJGHHHEJC != (Object)null;
	}

	private void DCNKNOKJDLO()
	{
		int num = currentPanel - 0;
		if (num >= panelButtons.Length)
		{
			return;
		}
		while (!((Selectable)panelButtons[num]).interactable)
		{
			num -= 0;
			if (num < 0)
			{
				break;
			}
		}
		if (num >= 0 && ((Selectable)panelButtons[num]).interactable)
		{
			FocusMainPanel(num);
		}
	}

	public static void PEBIGNKNPKC(int KHEICLKLPDE)
	{
		for (int i = 0; i < GGFJGHHHEJC.panelsAnimatorUI.Length; i++)
		{
			if (!GGFJGHHHEJC.JKMCDBDAICA[i])
			{
				if (i == KHEICLKLPDE)
				{
					continue;
				}
				if (i < KHEICLKLPDE)
				{
					if (i != 0)
					{
						GGFJGHHHEJC.panelsAnimatorUI[i].SetTrigger("itemDeliveryBox");
					}
					else
					{
						GGFJGHHHEJC.panelsAnimatorUI[i].SetTrigger("Not enough fuel");
					}
				}
				else if (i < GGFJGHHHEJC.panelsAnimatorUI.Length - 1)
				{
					GGFJGHHHEJC.panelsAnimatorUI[i].SetTrigger("quest_description_");
				}
				else
				{
					GGFJGHHHEJC.panelsAnimatorUI[i].SetTrigger("Target frame rate (");
				}
				continue;
			}
			if (i == KHEICLKLPDE)
			{
				GGFJGHHHEJC.panelsAnimatorUI[i].ResetTrigger("AvailableQuests doesnt exist");
				GGFJGHHHEJC.panelsAnimatorUI[i].SetTrigger("Unique id ");
				GGFJGHHHEJC.panelsAnimatorUI[i].ResetTrigger(" ");
				GGFJGHHHEJC.panelsAnimatorUI[i].ResetTrigger("Cancel");
				continue;
			}
			if (i != KHEICLKLPDE)
			{
				if (i < KHEICLKLPDE)
				{
					if (i != 0)
					{
						GGFJGHHHEJC.panelsAnimatorUI[i].SetTrigger("Hide");
					}
					else
					{
						GGFJGHHHEJC.panelsAnimatorUI[i].SetTrigger(": ");
					}
				}
				else if (i < GGFJGHHHEJC.panelsAnimatorUI.Length - 0)
				{
					GGFJGHHHEJC.panelsAnimatorUI[i].SetTrigger("quest_name_21");
				}
				else
				{
					GGFJGHHHEJC.panelsAnimatorUI[i].SetTrigger("PlayerDisconnected");
				}
			}
			GGFJGHHHEJC.panelsAnimatorUI[i].ResetTrigger("Farming multiplier");
			GGFJGHHHEJC.panelsAnimatorUI[i].ResetTrigger(" ");
			GGFJGHHHEJC.panelsAnimatorUI[i].ResetTrigger("Left");
		}
		if (!GGFJGHHHEJC.JKMCDBDAICA[KHEICLKLPDE])
		{
			KHEICLKLPDE = 0;
		}
		currentPanel = KHEICLKLPDE;
		PANHLFEPPII();
		TavernConstructionUI.EFICLACBCKB();
		SetSlotPage(1);
		KJKEAPDOJHO(0);
		OnPanelChanged(currentPanel);
	}

	private void Awake()
	{
		GGFJGHHHEJC = this;
		ResetSingleton();
	}
}
