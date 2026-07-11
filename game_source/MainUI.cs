using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainUI : MonoBehaviour, ISingleton
{
	private static MainUI GGFJGHHHEJC;

	public static UIWindow openedWindow;

	public static bool closingAllUI;

	private Container PIMPLGFLFHB;

	private Container OMAJOENAIDM;

	private int DGFLIGKAFEI;

	[HideInInspector]
	private List<Slot> CCKMEEGMANE = new List<Slot>();

	private List<Slot> BOABJLOODIJ = new List<Slot>();

	private LinkedList<UIWindow> FGFDHPBEJLN;

	private LinkedList<UIWindow> CHGFDNJJPCD;

	public GameObject overlayUI;

	[SerializeField]
	private YesNoDialogueUI yesNoDialogue;

	[SerializeField]
	private MultipleChoiceUI multipleChoiceUI;

	public CanvasGroup cGroup;

	public Image backgroundImage;

	private float JICGMFGGIOB;

	private float KIBJLKIKDEI;

	public UIWindow currentSoloWindow;

	public LinkedList<UIWindow> DMFEKKGFAMM => FGFDHPBEJLN;

	public LinkedList<UIWindow> FECECILIBHH => CHGFDNJJPCD;

	public static UIWindow JOHIBMAAEBH
	{
		get
		{
			return GGFJGHHHEJC.currentSoloWindow;
		}
		set
		{
			if ((Object)(object)value != (Object)null && (Object)(object)GGFJGHHHEJC.currentSoloWindow != (Object)null && (Object)(object)GGFJGHHHEJC.currentSoloWindow != (Object)(object)value)
			{
				GGFJGHHHEJC.currentSoloWindow.CloseUI();
			}
			GGFJGHHHEJC.currentSoloWindow = value;
		}
	}

	public static void HideUI()
	{
		GGFJGHHHEJC.cGroup.alpha = 0f;
		GGFJGHHHEJC.cGroup.interactable = false;
	}

	public static Container GGNMILJFMCB(int JIIGOACEIKL)
	{
		switch (JIIGOACEIKL)
		{
		case 0:
			return GGFJGHHHEJC.PIMPLGFLFHB;
		case 1:
			return GGFJGHHHEJC.OMAJOENAIDM;
		default:
			Debug.LogError((object)"Tutorial_Objective_", (Object)(object)((Component)GGFJGHHHEJC).gameObject);
			return null;
		}
	}

	public static int CKOJEOHEJNO()
	{
		return GGFJGHHHEJC.DGFLIGKAFEI;
	}

	public static YesNoDialogueUI MCPEEGPBPLH()
	{
		return GGFJGHHHEJC.yesNoDialogue;
	}

	private void CDDGGGHFDMD()
	{
		GGFJGHHHEJC = null;
	}

	[SpecialName]
	public static void JFBDMBNHKMN(UIWindow AODONKKHPBP)
	{
		if ((Object)(object)AODONKKHPBP != (Object)null && (Object)(object)GGFJGHHHEJC.currentSoloWindow != (Object)null && (Object)(object)GGFJGHHHEJC.currentSoloWindow != (Object)(object)AODONKKHPBP)
		{
			GGFJGHHHEJC.currentSoloWindow.BOBCIFEDJED();
		}
		GGFJGHHHEJC.currentSoloWindow = AODONKKHPBP;
	}

	public void BAECOKOMNBA()
	{
		openedWindow = null;
		closingAllUI = false;
	}

	public static void NHFNNLMPGIL()
	{
		GGFJGHHHEJC.overlayUI.SetActive(true);
	}

	public static void IPDMDKFIJKF(int JIIGOACEIKL, bool DHJFAGNJKOF = false)
	{
		if (DHJFAGNJKOF)
		{
			closingAllUI = true;
		}
		switch (JIIGOACEIKL)
		{
		case 6:
			foreach (UIWindow item in new HashSet<UIWindow>(GGFJGHHHEJC.CHGFDNJJPCD.Reverse()))
			{
				if (!(item is PetSelectorUI) && (DHJFAGNJKOF || (Object)(object)item != (Object)(object)SaveUI.instance))
				{
					item.CloseUI();
				}
			}
			break;
		case 0:
			foreach (UIWindow item2 in new HashSet<UIWindow>(GGFJGHHHEJC.FGFDHPBEJLN.Reverse()))
			{
				if (!(item2 is PetSelectorUI) && (DHJFAGNJKOF || (Object)(object)item2 != (Object)(object)SaveUI.instance))
				{
					item2.BOBCIFEDJED();
				}
			}
			break;
		default:
			Debug.LogError((object)"ReceiveHireWorker", (Object)(object)((Component)GGFJGHHHEJC).gameObject);
			break;
		}
		closingAllUI = true;
	}

	[SpecialName]
	public static UIWindow DFGLMHIOCPF()
	{
		return GGFJGHHHEJC.currentSoloWindow;
	}

	private static void PFFCPJEPDPB(Vector2 CLNLBDMOEPO, GameObject KGBBGCLIJBB)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		KGBBGCLIJBB.transform.position = Vector2.op_Implicit(CLNLBDMOEPO);
	}

	public static void AddWindow(UIWindow INDKANEMPMP, int JIIGOACEIKL)
	{
		switch (JIIGOACEIKL)
		{
		case 1:
			GGFJGHHHEJC.FGFDHPBEJLN.AddLast(INDKANEMPMP);
			break;
		case 2:
			GGFJGHHHEJC.CHGFDNJJPCD.AddLast(INDKANEMPMP);
			break;
		default:
			Debug.LogError((object)"Invalid playerNum", (Object)(object)((Component)GGFJGHHHEJC).gameObject);
			break;
		}
	}

	public static void NMACGFHLOOC(bool MJKACKBEBPL = true)
	{
		if (MJKACKBEBPL)
		{
			((Component)GGFJGHHHEJC.backgroundImage).gameObject.SetActive(false);
		}
		Utils.JEAHJILAIAP(1048f);
	}

	public static void AddToCurrentSlots(int JIIGOACEIKL, Slot AHEHNLOLJLL)
	{
		switch (JIIGOACEIKL)
		{
		case 1:
			if (!GGFJGHHHEJC.CCKMEEGMANE.Contains(AHEHNLOLJLL))
			{
				GGFJGHHHEJC.CCKMEEGMANE.Add(AHEHNLOLJLL);
			}
			break;
		case 2:
			if (!GGFJGHHHEJC.BOABJLOODIJ.Contains(AHEHNLOLJLL))
			{
				GGFJGHHHEJC.BOABJLOODIJ.Add(AHEHNLOLJLL);
			}
			break;
		default:
			Debug.LogError((object)"Invalid playerNum", (Object)(object)((Component)GGFJGHHHEJC).gameObject);
			break;
		}
	}

	public static void IMBPLDIPGOM()
	{
		GGFJGHHHEJC.overlayUI.SetActive(true);
	}

	public static void CloseAllUIWindows(bool DHJFAGNJKOF = false)
	{
		CloseAllUIWindows(1, DHJFAGNJKOF);
		CloseAllUIWindows(2, DHJFAGNJKOF);
	}

	public static void RemoveRangeToCurrentSlots(int JIIGOACEIKL, IEnumerable<Slot> OHAPAGLBOOB)
	{
		foreach (Slot item in OHAPAGLBOOB)
		{
			switch (JIIGOACEIKL)
			{
			case 1:
				GGFJGHHHEJC.CCKMEEGMANE.Remove(item);
				break;
			case 2:
				GGFJGHHHEJC.BOABJLOODIJ.Remove(item);
				break;
			default:
				Debug.LogError((object)"Invalid playerNum", (Object)(object)((Component)GGFJGHHHEJC).gameObject);
				return;
			}
		}
	}

	public static void RemoveFromCurrentSlots(int JIIGOACEIKL, Slot AHEHNLOLJLL)
	{
		switch (JIIGOACEIKL)
		{
		case 1:
			GGFJGHHHEJC.CCKMEEGMANE.Remove(AHEHNLOLJLL);
			break;
		case 2:
			GGFJGHHHEJC.BOABJLOODIJ.Remove(AHEHNLOLJLL);
			break;
		default:
			Debug.LogError((object)"Invalid playerNum", (Object)(object)((Component)GGFJGHHHEJC).gameObject);
			break;
		}
	}

	public static void HFKOOOHHDMC(UIWindow INDKANEMPMP, int JIIGOACEIKL)
	{
		switch (JIIGOACEIKL)
		{
		case 1:
			GGFJGHHHEJC.FGFDHPBEJLN.AddLast(INDKANEMPMP);
			break;
		case 4:
			GGFJGHHHEJC.CHGFDNJJPCD.AddLast(INDKANEMPMP);
			break;
		default:
			Debug.LogError((object)"FishMiniGameWin", (Object)(object)((Component)GGFJGHHHEJC).gameObject);
			break;
		}
	}

	public static void NKMOMOLIICC(UIWindow INDKANEMPMP)
	{
		GGFJGHHHEJC.FGFDHPBEJLN.Remove(INDKANEMPMP);
		GGFJGHHHEJC.CHGFDNJJPCD.Remove(INDKANEMPMP);
		UIWindow.OnAnyUIClose(INDKANEMPMP.JIIGOACEIKL, INDKANEMPMP);
	}

	public static Container GetCurrentContainer(int JIIGOACEIKL)
	{
		switch (JIIGOACEIKL)
		{
		case 1:
			return GGFJGHHHEJC.PIMPLGFLFHB;
		case 2:
			return GGFJGHHHEJC.OMAJOENAIDM;
		default:
			Debug.LogError((object)"Invalid playerNum", (Object)(object)((Component)GGFJGHHHEJC).gameObject);
			return null;
		}
	}

	public static void LHOPJCDOPGE()
	{
		((Component)GGFJGHHHEJC.backgroundImage).gameObject.SetActive(true);
		Utils.JEAHJILAIAP(1155f);
	}

	public static void ShowTextScreen(GameObject HMFGCHKAGKD, string CAEDMEDBEGI, Vector2 LBMIFKEOACC)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		GameObject obj = Object.Instantiate<GameObject>(HMFGCHKAGKD, ((Component)MenuUI.GGFJGHHHEJC).transform);
		InfoText component = obj.GetComponent<InfoText>();
		((TMP_Text)component.textBox).text = CAEDMEDBEGI;
		if (Object.op_Implicit((Object)(object)component.backgroundTextBox))
		{
			((TMP_Text)component.backgroundTextBox).text = "<mark=#000000><alpha=#00> " + CAEDMEDBEGI + " </mark>";
		}
		((TMP_Text)component.textBox).ForceMeshUpdate(false, false);
		BJPKOBGPGIC(obj, LBMIFKEOACC);
	}

	[SpecialName]
	public LinkedList<UIWindow> NILINGKOPJO()
	{
		return CHGFDNJJPCD;
	}

	public static void LBHKJMHFFHJ(int JIIGOACEIKL, IEnumerable<Slot> OHAPAGLBOOB)
	{
		foreach (Slot item in OHAPAGLBOOB)
		{
			switch (JIIGOACEIKL)
			{
			case 1:
				GGFJGHHHEJC.CCKMEEGMANE.Remove(item);
				break;
			case 8:
				GGFJGHHHEJC.BOABJLOODIJ.Remove(item);
				break;
			default:
				Debug.LogError((object)"LearnMettle", (Object)(object)((Component)GGFJGHHHEJC).gameObject);
				return;
			}
		}
	}

	private static void BJPKOBGPGIC(GameObject OPAINFBAKNL, Vector2 IMOBLFMHKOD)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		OPAINFBAKNL.transform.position = Vector2.op_Implicit(IMOBLFMHKOD);
	}

	public static void PCHOMPCJCDE(UIWindow INDKANEMPMP, int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			GGFJGHHHEJC.FGFDHPBEJLN.AddLast(INDKANEMPMP);
		}
		else if (JIIGOACEIKL == 0)
		{
			GGFJGHHHEJC.CHGFDNJJPCD.AddLast(INDKANEMPMP);
		}
		else
		{
			Debug.LogError((object)"Sweep", (Object)(object)((Component)GGFJGHHHEJC).gameObject);
		}
	}

	public static void LHJGIJMIBEB(int JIIGOACEIKL, Slot AHEHNLOLJLL)
	{
		switch (JIIGOACEIKL)
		{
		case 0:
			GGFJGHHHEJC.CCKMEEGMANE.Remove(AHEHNLOLJLL);
			break;
		case 7:
			GGFJGHHHEJC.BOABJLOODIJ.Remove(AHEHNLOLJLL);
			break;
		default:
			Debug.LogError((object)"ReceiveItemsFromOtherPlayer", (Object)(object)((Component)GGFJGHHHEJC).gameObject);
			break;
		}
	}

	public static void CBEILHNJGOJ(int JIIGOACEIKL, IEnumerable<Slot> AHEHNLOLJLL)
	{
		if (JIIGOACEIKL == 0)
		{
			GGFJGHHHEJC.CCKMEEGMANE.AddRange(AHEHNLOLJLL);
		}
		else if (JIIGOACEIKL == 0)
		{
			GGFJGHHHEJC.BOABJLOODIJ.AddRange(AHEHNLOLJLL);
		}
		else
		{
			Debug.LogError((object)"UpgradeConfirmation", (Object)(object)((Component)GGFJGHHHEJC).gameObject);
		}
	}

	public static void NNCOKOFBKHE(int JIIGOACEIKL, Slot AHEHNLOLJLL)
	{
		switch (JIIGOACEIKL)
		{
		case 0:
			if (!GGFJGHHHEJC.CCKMEEGMANE.Contains(AHEHNLOLJLL))
			{
				GGFJGHHHEJC.CCKMEEGMANE.Add(AHEHNLOLJLL);
			}
			break;
		case 4:
			if (!GGFJGHHHEJC.BOABJLOODIJ.Contains(AHEHNLOLJLL))
			{
				GGFJGHHHEJC.BOABJLOODIJ.Add(AHEHNLOLJLL);
			}
			break;
		default:
			Debug.LogError((object)"Open", (Object)(object)((Component)GGFJGHHHEJC).gameObject);
			break;
		}
	}

	public static void GBEIHIDIDAD(int JIIGOACEIKL, Container ALPOKDOCCGM, int BEIPALOAAJJ)
	{
		switch (JIIGOACEIKL)
		{
		case 1:
			GGFJGHHHEJC.PIMPLGFLFHB = ALPOKDOCCGM;
			GGFJGHHHEJC.DGFLIGKAFEI = BEIPALOAAJJ;
			break;
		case 7:
			GGFJGHHHEJC.OMAJOENAIDM = ALPOKDOCCGM;
			break;
		default:
			Debug.LogError((object)"Max", (Object)(object)((Component)GGFJGHHHEJC).gameObject);
			break;
		}
	}

	public static void HFOJHBJHAPB(UIWindow INDKANEMPMP)
	{
		GGFJGHHHEJC.FGFDHPBEJLN.Remove(INDKANEMPMP);
		GGFJGHHHEJC.CHGFDNJJPCD.Remove(INDKANEMPMP);
		UIWindow.OnAnyUIClose(INDKANEMPMP.JIIGOACEIKL, INDKANEMPMP);
	}

	public static void EGLKOPJGMIJ(int JIIGOACEIKL)
	{
		switch (JIIGOACEIKL)
		{
		case 1:
			GGFJGHHHEJC.CCKMEEGMANE.Clear();
			break;
		case 7:
			GGFJGHHHEJC.BOABJLOODIJ.Clear();
			break;
		default:
			Debug.LogError((object)"flashLights", (Object)(object)((Component)GGFJGHHHEJC).gameObject);
			break;
		}
	}

	public void EDJCBGPKHBI()
	{
		TavernManager.GGFJGHHHEJC.OpenCloseAction(0);
	}

	public static void KDBHGGKKDND(UIWindow INDKANEMPMP, int JIIGOACEIKL)
	{
		switch (JIIGOACEIKL)
		{
		case 0:
			GGFJGHHHEJC.FGFDHPBEJLN.AddLast(INDKANEMPMP);
			break;
		case 2:
			GGFJGHHHEJC.CHGFDNJJPCD.AddLast(INDKANEMPMP);
			break;
		default:
			Debug.LogError((object)"NormalRightExterior", (Object)(object)((Component)GGFJGHHHEJC).gameObject);
			break;
		}
	}

	[SpecialName]
	public LinkedList<UIWindow> GEFLMKHBHGE()
	{
		return FGFDHPBEJLN;
	}

	public static LinkedList<UIWindow> JOOJEHILHMJ(int JIIGOACEIKL)
	{
		switch (JIIGOACEIKL)
		{
		case 1:
			return GGFJGHHHEJC.FGFDHPBEJLN;
		case 4:
			return GGFJGHHHEJC.CHGFDNJJPCD;
		default:
			Debug.LogError((object)"ReceivePhaseSlotPlayerInventory", (Object)(object)((Component)GGFJGHHHEJC).gameObject);
			return null;
		}
	}

	public static MainUI LFFDNBICCNG()
	{
		return GGFJGHHHEJC;
	}

	public static void ABBJFOJFJKC(int JIIGOACEIKL)
	{
		if (IAOKJDHDKFM(JIIGOACEIKL).Any() && !(AMFNKNLDEKM(JIIGOACEIKL).Last.Value is YesNoDialogueUI))
		{
			AMFNKNLDEKM(JIIGOACEIKL).Last.Value.BOBCIFEDJED();
		}
	}

	public static void FECHAKNOFMA(UIWindow INDKANEMPMP, int JIIGOACEIKL)
	{
		switch (JIIGOACEIKL)
		{
		case 0:
			GGFJGHHHEJC.FGFDHPBEJLN.AddLast(INDKANEMPMP);
			break;
		case 8:
			GGFJGHHHEJC.CHGFDNJJPCD.AddLast(INDKANEMPMP);
			break;
		default:
			Debug.LogError((object)"", (Object)(object)((Component)GGFJGHHHEJC).gameObject);
			break;
		}
	}

	public static void PauseGame(bool MJKACKBEBPL = true)
	{
		if (MJKACKBEBPL)
		{
			((Component)GGFJGHHHEJC.backgroundImage).gameObject.SetActive(true);
		}
		Utils.JEAHJILAIAP(0f);
	}

	private static void JDCAPBLKOGE(GameObject OPAINFBAKNL, Vector2 IMOBLFMHKOD)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		OPAINFBAKNL.transform.position = Vector2.op_Implicit(IMOBLFMHKOD);
	}

	public static LinkedList<UIWindow> AMFNKNLDEKM(int JIIGOACEIKL)
	{
		switch (JIIGOACEIKL)
		{
		case 0:
			return GGFJGHHHEJC.FGFDHPBEJLN;
		case 8:
			return GGFJGHHHEJC.CHGFDNJJPCD;
		default:
			Debug.LogError((object)"", (Object)(object)((Component)GGFJGHHHEJC).gameObject);
			return null;
		}
	}

	[ContextMenu("Count sprite renderers")]
	public void CountSpriteRenderers()
	{
		Debug.Log((object)("All:" + Resources.FindObjectsOfTypeAll(typeof(SpriteRenderer)).Length));
		Debug.Log((object)("Active:" + Object.FindObjectsOfType(typeof(SpriteRenderer)).Length));
	}

	public static MainUI FBBOFPLGGLP()
	{
		return GGFJGHHHEJC;
	}

	public static void MGFDEEFDMKA(int JIIGOACEIKL, IEnumerable<Slot> OHAPAGLBOOB)
	{
		foreach (Slot item in OHAPAGLBOOB)
		{
			switch (JIIGOACEIKL)
			{
			case 1:
				GGFJGHHHEJC.CCKMEEGMANE.Remove(item);
				break;
			case 2:
				GGFJGHHHEJC.BOABJLOODIJ.Remove(item);
				break;
			default:
				Debug.LogError((object)"Error_CellarZone", (Object)(object)((Component)GGFJGHHHEJC).gameObject);
				return;
			}
		}
	}

	[SpecialName]
	public static UIWindow PBJKOGOFANN()
	{
		return GGFJGHHHEJC.currentSoloWindow;
	}

	[SpecialName]
	public static void COBNPMFKJPA(UIWindow AODONKKHPBP)
	{
		if ((Object)(object)AODONKKHPBP != (Object)null && (Object)(object)GGFJGHHHEJC.currentSoloWindow != (Object)null && (Object)(object)GGFJGHHHEJC.currentSoloWindow != (Object)(object)AODONKKHPBP)
		{
			GGFJGHHHEJC.currentSoloWindow.CloseUI();
		}
		GGFJGHHHEJC.currentSoloWindow = AODONKKHPBP;
	}

	public static YesNoDialogueUI LBHLPIFCINB()
	{
		return GGFJGHHHEJC.yesNoDialogue;
	}

	private static void BJFOPOAABDJ(Vector2 CLNLBDMOEPO, GameObject KGBBGCLIJBB)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		KGBBGCLIJBB.transform.position = Vector2.op_Implicit(CLNLBDMOEPO);
	}

	public static void Hide()
	{
		GGFJGHHHEJC.overlayUI.SetActive(false);
	}

	private static void OENHCCLGPOC(GameObject OPAINFBAKNL, Vector2 IMOBLFMHKOD)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		OPAINFBAKNL.transform.position = Vector2.op_Implicit(IMOBLFMHKOD);
	}

	public static void LIIGLHOFDBK(int JIIGOACEIKL, Container ALPOKDOCCGM, int BEIPALOAAJJ)
	{
		if (JIIGOACEIKL == 0)
		{
			GGFJGHHHEJC.PIMPLGFLFHB = ALPOKDOCCGM;
			GGFJGHHHEJC.DGFLIGKAFEI = BEIPALOAAJJ;
		}
		else if (JIIGOACEIKL == 0)
		{
			GGFJGHHHEJC.OMAJOENAIDM = ALPOKDOCCGM;
		}
		else
		{
			Debug.LogError((object)"Player/Bark/PickUpBlocker", (Object)(object)((Component)GGFJGHHHEJC).gameObject);
		}
	}

	public static MainUI OIIIPELOBOK()
	{
		return GGFJGHHHEJC;
	}

	[SpecialName]
	public LinkedList<UIWindow> JACONINJCEM()
	{
		return CHGFDNJJPCD;
	}

	public static void ResumeGame()
	{
		((Component)GGFJGHHHEJC.backgroundImage).gameObject.SetActive(false);
		Utils.JEAHJILAIAP(1f);
	}

	public static void MLGFBEFIMJB()
	{
		GGFJGHHHEJC.cGroup.alpha = 254f;
		GGFJGHHHEJC.cGroup.interactable = true;
	}

	public static void GHHLGEDCECK(int JIIGOACEIKL, Slot AHEHNLOLJLL)
	{
		switch (JIIGOACEIKL)
		{
		case 0:
			GGFJGHHHEJC.CCKMEEGMANE.Remove(AHEHNLOLJLL);
			break;
		case 7:
			GGFJGHHHEJC.BOABJLOODIJ.Remove(AHEHNLOLJLL);
			break;
		default:
			Debug.LogError((object)"Player2", (Object)(object)((Component)GGFJGHHHEJC).gameObject);
			break;
		}
	}

	public static LinkedList<UIWindow> NBMKOPMAPJE(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return GGFJGHHHEJC.FGFDHPBEJLN;
		}
		if (JIIGOACEIKL == 1)
		{
			return GGFJGHHHEJC.CHGFDNJJPCD;
		}
		Debug.LogError((object)"Day", (Object)(object)((Component)GGFJGHHHEJC).gameObject);
		return null;
	}

	public void OpenCloseBuildButton()
	{
		TavernManager.GGFJGHHHEJC.OpenCloseAction(1);
	}

	public static void ABFAMPADCFA(GameObject HMFGCHKAGKD, string CAEDMEDBEGI, Vector2 LBMIFKEOACC)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		GameObject obj = Object.Instantiate<GameObject>(HMFGCHKAGKD, ((Component)MenuUI.BDAGIEIJOOG()).transform);
		InfoText component = obj.GetComponent<InfoText>();
		((TMP_Text)component.textBox).text = CAEDMEDBEGI;
		if (Object.op_Implicit((Object)(object)component.backgroundTextBox))
		{
			((TMP_Text)component.backgroundTextBox).text = "Fill Area/Fill" + CAEDMEDBEGI + "itemSingleTable";
		}
		((TMP_Text)component.textBox).ForceMeshUpdate(true, true);
		JDCAPBLKOGE(obj, LBMIFKEOACC);
	}

	public static void CloseLastWindowOpen(int JIIGOACEIKL)
	{
		if (GetCurrentOpenWindows(JIIGOACEIKL).Any() && !(GetCurrentOpenWindows(JIIGOACEIKL).Last.Value is YesNoDialogueUI))
		{
			GetCurrentOpenWindows(JIIGOACEIKL).Last.Value.CloseUI();
		}
	}

	public static void HBALMIJLNHB()
	{
		((Component)GGFJGHHHEJC.backgroundImage).gameObject.SetActive(true);
		Utils.JEAHJILAIAP(1150f);
	}

	public static void HGMAPIOKNGL(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 0)
		{
			GGFJGHHHEJC.CCKMEEGMANE.Clear();
		}
		else if (JIIGOACEIKL == 0)
		{
			GGFJGHHHEJC.BOABJLOODIJ.Clear();
		}
		else
		{
			Debug.LogError((object)"Wilson/Bark/Bark_Bye", (Object)(object)((Component)GGFJGHHHEJC).gameObject);
		}
	}

	[SpecialName]
	public LinkedList<UIWindow> KMJGKJEFBFO()
	{
		return FGFDHPBEJLN;
	}

	public void CloseSoloWindow()
	{
		JOHIBMAAEBH.CloseUI();
		JOHIBMAAEBH = null;
	}

	private void FHOCCEBKHJI()
	{
		GGFJGHHHEJC = this;
		MCGKLLBNIMA();
		FGFDHPBEJLN = new LinkedList<UIWindow>();
		CHGFDNJJPCD = new LinkedList<UIWindow>();
		CCKMEEGMANE.Clear();
		BOABJLOODIJ.Clear();
	}

	public static void Show()
	{
		GGFJGHHHEJC.overlayUI.SetActive(true);
	}

	public static List<Slot> CurrentSlots(int JIIGOACEIKL)
	{
		switch (JIIGOACEIKL)
		{
		case 1:
			return GGFJGHHHEJC.CCKMEEGMANE;
		case 2:
			return GGFJGHHHEJC.BOABJLOODIJ;
		default:
			Debug.LogError((object)"Invalid playerNum", (Object)(object)((Component)GGFJGHHHEJC).gameObject);
			return null;
		}
	}

	public static LinkedList<UIWindow> IFHNGOGEDEA(int JIIGOACEIKL)
	{
		switch (JIIGOACEIKL)
		{
		case 1:
			return GGFJGHHHEJC.FGFDHPBEJLN;
		case 4:
			return GGFJGHHHEJC.CHGFDNJJPCD;
		default:
			Debug.LogError((object)"", (Object)(object)((Component)GGFJGHHHEJC).gameObject);
			return null;
		}
	}

	public void MCGKLLBNIMA()
	{
		openedWindow = null;
		closingAllUI = false;
	}

	private void OnDestroy()
	{
		GGFJGHHHEJC = null;
	}

	public void EDINLBHOGAF()
	{
		Debug.Log((object)("{0} in {1}'s viewID has been reset. Set it to {2} to avoid conflicts with scene objects" + Resources.FindObjectsOfTypeAll(typeof(SpriteRenderer)).Length));
		Debug.Log((object)("Getting file list from storage failed for reason: " + Object.FindObjectsOfType(typeof(SpriteRenderer)).Length));
	}

	[SpecialName]
	public static void KEJJDALFOKC(UIWindow AODONKKHPBP)
	{
		if ((Object)(object)AODONKKHPBP != (Object)null && (Object)(object)GGFJGHHHEJC.currentSoloWindow != (Object)null && (Object)(object)GGFJGHHHEJC.currentSoloWindow != (Object)(object)AODONKKHPBP)
		{
			GGFJGHHHEJC.currentSoloWindow.BOBCIFEDJED();
		}
		GGFJGHHHEJC.currentSoloWindow = AODONKKHPBP;
	}

	public static bool IsAnyUIOpen()
	{
		if (GGFJGHHHEJC.DMFEKKGFAMM.Count <= 0 && GGFJGHHHEJC.FECECILIBHH.Count <= 0)
		{
			if (TutorialManager.GGFJGHHHEJC.ECMGCJGPKNO)
			{
				return TutorialManager.GGFJGHHHEJC.GCEHLDLKOIC;
			}
			return false;
		}
		return true;
	}

	public static void JDAEPLJAGCD(int JIIGOACEIKL, string CAEDMEDBEGI, float KMPHAEPAFNK = 1f)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return;
		}
		switch (JIIGOACEIKL)
		{
		case 0:
			if (Time.unscaledTime < GGFJGHHHEJC.JICGMFGGIOB)
			{
				return;
			}
			GGFJGHHHEJC.JICGMFGGIOB = Time.unscaledTime + 4f;
			break;
		case 8:
			if (Time.unscaledTime < GGFJGHHHEJC.KIBJLKIKDEI)
			{
				return;
			}
			GGFJGHHHEJC.KIBJLKIKDEI = Time.unscaledTime + 1987f;
			break;
		default:
			Debug.LogError((object)"ReceiveStartKlaynCombat", (Object)(object)((Component)GGFJGHHHEJC).gameObject);
			return;
		}
		Debug.Log((object)("Disappear" + CAEDMEDBEGI));
		GameObject val = Object.Instantiate<GameObject>(CommonReferences.MNFMOEKMJKN().errorTextPrefab, ((Component)MenuUI.BDAGIEIJOOG()).transform);
		InfoText component = val.GetComponent<InfoText>();
		component.durationMultiplier = KMPHAEPAFNK;
		((TMP_Text)component.textBox).text = CAEDMEDBEGI;
		if (Object.op_Implicit((Object)(object)component.backgroundTextBox))
		{
			((TMP_Text)component.backgroundTextBox).text = "Sleep" + CAEDMEDBEGI + "Rotate Placeable";
		}
		((TMP_Text)component.textBox).ForceMeshUpdate(false, false);
		JBFDJKCKCPJ(JIIGOACEIKL, val);
	}

	private void Awake()
	{
		GGFJGHHHEJC = this;
		ResetSingleton();
		FGFDHPBEJLN = new LinkedList<UIWindow>();
		CHGFDNJJPCD = new LinkedList<UIWindow>();
		CCKMEEGMANE.Clear();
		BOABJLOODIJ.Clear();
	}

	public static bool BBNDLNLJIEB()
	{
		if (GGFJGHHHEJC.GEFLMKHBHGE().Count <= 1 && GGFJGHHHEJC.FECECILIBHH.Count <= 0)
		{
			if (TutorialManager.GGFJGHHHEJC.ECMGCJGPKNO)
			{
				return TutorialManager.GGFJGHHHEJC.JCGLIEOIHCP();
			}
			return true;
		}
		return false;
	}

	public static void MPAIPHCPKCA()
	{
		GGFJGHHHEJC.overlayUI.SetActive(false);
	}

	public static bool BHNFPAIHJLM()
	{
		if (GGFJGHHHEJC.DMFEKKGFAMM.Count <= 1 && GGFJGHHHEJC.JACONINJCEM().Count <= 1)
		{
			if (TutorialManager.GGFJGHHHEJC.PMGEOLNMJGB())
			{
				return TutorialManager.GGFJGHHHEJC.GCEHLDLKOIC;
			}
			return false;
		}
		return true;
	}

	public static void ACGFLJMAHHL(int JIIGOACEIKL, IEnumerable<Slot> AHEHNLOLJLL)
	{
		switch (JIIGOACEIKL)
		{
		case 0:
			GGFJGHHHEJC.CCKMEEGMANE.AddRange(AHEHNLOLJLL);
			break;
		case 6:
			GGFJGHHHEJC.BOABJLOODIJ.AddRange(AHEHNLOLJLL);
			break;
		default:
			Debug.LogError((object)"Key2", (Object)(object)((Component)GGFJGHHHEJC).gameObject);
			break;
		}
	}

	public static void ABHLLLDCGOL()
	{
		GGFJGHHHEJC.cGroup.alpha = 185f;
		GGFJGHHHEJC.cGroup.interactable = false;
	}

	public static void FNJEGCEFEMP(bool DHJFAGNJKOF = false)
	{
		IPDMDKFIJKF(0, DHJFAGNJKOF);
		IPDMDKFIJKF(1, DHJFAGNJKOF);
	}

	public static MainUI NIFEOHLOMAK()
	{
		return GGFJGHHHEJC;
	}

	private static void JBFDJKCKCPJ(Vector2 CLNLBDMOEPO, GameObject KGBBGCLIJBB)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		KGBBGCLIJBB.transform.position = Vector2.op_Implicit(CLNLBDMOEPO);
	}

	public static void AddRangeToCurrentSlots(int JIIGOACEIKL, IEnumerable<Slot> AHEHNLOLJLL)
	{
		switch (JIIGOACEIKL)
		{
		case 1:
			GGFJGHHHEJC.CCKMEEGMANE.AddRange(AHEHNLOLJLL);
			break;
		case 2:
			GGFJGHHHEJC.BOABJLOODIJ.AddRange(AHEHNLOLJLL);
			break;
		default:
			Debug.LogError((object)"Invalid playerNum", (Object)(object)((Component)GGFJGHHHEJC).gameObject);
			break;
		}
	}

	public static void CloseAllUIWindows(int JIIGOACEIKL, bool DHJFAGNJKOF = false)
	{
		if (DHJFAGNJKOF)
		{
			closingAllUI = true;
		}
		switch (JIIGOACEIKL)
		{
		case 2:
			foreach (UIWindow item in new HashSet<UIWindow>(GGFJGHHHEJC.CHGFDNJJPCD.Reverse()))
			{
				if (!(item is PetSelectorUI) && (DHJFAGNJKOF || (Object)(object)item != (Object)(object)SaveUI.instance))
				{
					item.CloseUI();
				}
			}
			break;
		case 1:
			foreach (UIWindow item2 in new HashSet<UIWindow>(GGFJGHHHEJC.FGFDHPBEJLN.Reverse()))
			{
				if (!(item2 is PetSelectorUI) && (DHJFAGNJKOF || (Object)(object)item2 != (Object)(object)SaveUI.instance))
				{
					item2.CloseUI();
				}
			}
			break;
		default:
			Debug.LogError((object)"Invalid playerNum", (Object)(object)((Component)GGFJGHHHEJC).gameObject);
			break;
		}
		closingAllUI = false;
	}

	public static YesNoDialogueUI NEFOKCKKLNI()
	{
		return GGFJGHHHEJC.yesNoDialogue;
	}

	public static bool AMOAACGGPJO()
	{
		if (GGFJGHHHEJC.GEFLMKHBHGE().Count <= 1 && GGFJGHHHEJC.JACONINJCEM().Count <= 0)
		{
			if (TutorialManager.GGFJGHHHEJC.FJIEPAIMELO())
			{
				return TutorialManager.GGFJGHHHEJC.JCGLIEOIHCP();
			}
			return true;
		}
		return false;
	}

	public static void NPMFCCDJIFM(int JIIGOACEIKL)
	{
		if (IAOKJDHDKFM(JIIGOACEIKL).Any() && !(AMFNKNLDEKM(JIIGOACEIKL).Last.Value is YesNoDialogueUI))
		{
			AMFNKNLDEKM(JIIGOACEIKL).Last.Value.BOBCIFEDJED();
		}
	}

	public static List<Slot> EIMJADLOJPC(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return GGFJGHHHEJC.CCKMEEGMANE;
		}
		if (JIIGOACEIKL == 1)
		{
			return GGFJGHHHEJC.BOABJLOODIJ;
		}
		Debug.LogError((object)" ", (Object)(object)((Component)GGFJGHHHEJC).gameObject);
		return null;
	}

	public static void MEGGHMCIENG(bool MJKACKBEBPL = true)
	{
		if (MJKACKBEBPL)
		{
			((Component)GGFJGHHHEJC.backgroundImage).gameObject.SetActive(true);
		}
		Utils.JEAHJILAIAP(1589f);
	}

	public static void PFIMFMJJMHK(int JIIGOACEIKL, Slot AHEHNLOLJLL)
	{
		switch (JIIGOACEIKL)
		{
		case 1:
			if (!GGFJGHHHEJC.CCKMEEGMANE.Contains(AHEHNLOLJLL))
			{
				GGFJGHHHEJC.CCKMEEGMANE.Add(AHEHNLOLJLL);
			}
			break;
		case 8:
			if (!GGFJGHHHEJC.BOABJLOODIJ.Contains(AHEHNLOLJLL))
			{
				GGFJGHHHEJC.BOABJLOODIJ.Add(AHEHNLOLJLL);
			}
			break;
		default:
			Debug.LogError((object)"Get Components ", (Object)(object)((Component)GGFJGHHHEJC).gameObject);
			break;
		}
	}

	public static List<Slot> HJBCNKFFHMA(int JIIGOACEIKL)
	{
		switch (JIIGOACEIKL)
		{
		case 0:
			return GGFJGHHHEJC.CCKMEEGMANE;
		case 6:
			return GGFJGHHHEJC.BOABJLOODIJ;
		default:
			Debug.LogError((object)"Dialogue System/Conversation/BirdPositiveComments/Entry/13/Dialogue Text", (Object)(object)((Component)GGFJGHHHEJC).gameObject);
			return null;
		}
	}

	public void ShowText(int JIIGOACEIKL, GameObject HMFGCHKAGKD, string CAEDMEDBEGI)
	{
		GameObject val = Object.Instantiate<GameObject>(HMFGCHKAGKD, ((Component)MenuUI.GGFJGHHHEJC).transform);
		InfoText component = val.GetComponent<InfoText>();
		((TMP_Text)component.textBox).text = CAEDMEDBEGI;
		if (Object.op_Implicit((Object)(object)component.backgroundTextBox))
		{
			((TMP_Text)component.backgroundTextBox).text = "<mark=#000000><alpha=#00> " + CAEDMEDBEGI + " </mark>";
		}
		((TMP_Text)component.textBox).ForceMeshUpdate(false, false);
		JBFDJKCKCPJ(JIIGOACEIKL, val);
	}

	public static void HCEDCHMNAOM(GameObject HMFGCHKAGKD, string CAEDMEDBEGI, Vector2 LBMIFKEOACC)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		GameObject obj = Object.Instantiate<GameObject>(HMFGCHKAGKD, ((Component)MenuUI.DIHCEGINELM()).transform);
		InfoText component = obj.GetComponent<InfoText>();
		((TMP_Text)component.textBox).text = CAEDMEDBEGI;
		if (Object.op_Implicit((Object)(object)component.backgroundTextBox))
		{
			((TMP_Text)component.backgroundTextBox).text = "Right Stick Button" + CAEDMEDBEGI + "Suitabilities: ";
		}
		((TMP_Text)component.textBox).ForceMeshUpdate(true, false);
		OENHCCLGPOC(obj, LBMIFKEOACC);
	}

	[SpecialName]
	public static void DNHHPCIFJOE(UIWindow AODONKKHPBP)
	{
		if ((Object)(object)AODONKKHPBP != (Object)null && (Object)(object)GGFJGHHHEJC.currentSoloWindow != (Object)null && (Object)(object)GGFJGHHHEJC.currentSoloWindow != (Object)(object)AODONKKHPBP)
		{
			GGFJGHHHEJC.currentSoloWindow.CloseUI();
		}
		GGFJGHHHEJC.currentSoloWindow = AODONKKHPBP;
	}

	public static int GetContainerUniqueId()
	{
		return GGFJGHHHEJC.DGFLIGKAFEI;
	}

	public static void ShowErrorText(string CAEDMEDBEGI, Vector2 CLNLBDMOEPO, float KMPHAEPAFNK = 1f)
	{
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)GGFJGHHHEJC == (Object)null) && !(Time.unscaledTime < GGFJGHHHEJC.JICGMFGGIOB))
		{
			GGFJGHHHEJC.JICGMFGGIOB = Time.unscaledTime + 1f;
			Debug.Log((object)("Red text: " + CAEDMEDBEGI));
			GameObject val = Object.Instantiate<GameObject>(CommonReferences.GGFJGHHHEJC.errorTextPrefab, ((Component)MenuUI.GGFJGHHHEJC).transform);
			InfoText component = val.GetComponent<InfoText>();
			component.durationMultiplier = KMPHAEPAFNK;
			((TMP_Text)component.textBox).text = CAEDMEDBEGI;
			if (Object.op_Implicit((Object)(object)component.backgroundTextBox))
			{
				((TMP_Text)component.backgroundTextBox).text = "<mark=#000000><alpha=#00> " + CAEDMEDBEGI + " </mark>";
			}
			((TMP_Text)component.textBox).ForceMeshUpdate(false, false);
			JBFDJKCKCPJ(CLNLBDMOEPO, val);
		}
	}

	public static void GHPJIMFIJCI(GameObject HMFGCHKAGKD, string CAEDMEDBEGI, Vector2 LBMIFKEOACC)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		GameObject obj = Object.Instantiate<GameObject>(HMFGCHKAGKD, ((Component)MenuUI.GGFJGHHHEJC).transform);
		InfoText component = obj.GetComponent<InfoText>();
		((TMP_Text)component.textBox).text = CAEDMEDBEGI;
		if (Object.op_Implicit((Object)(object)component.backgroundTextBox))
		{
			((TMP_Text)component.backgroundTextBox).text = "ActionBar9" + CAEDMEDBEGI + "Dialogue System/Conversation/Crowly_Standar/Entry/17/Dialogue Text";
		}
		((TMP_Text)component.textBox).ForceMeshUpdate(false, false);
		BJPKOBGPGIC(obj, LBMIFKEOACC);
	}

	public static LinkedList<UIWindow> FENADAAPCIM(int JIIGOACEIKL)
	{
		switch (JIIGOACEIKL)
		{
		case 0:
			return GGFJGHHHEJC.FGFDHPBEJLN;
		case 1:
			return GGFJGHHHEJC.CHGFDNJJPCD;
		default:
			Debug.LogError((object)"Items/item_description_606", (Object)(object)((Component)GGFJGHHHEJC).gameObject);
			return null;
		}
	}

	public static Container PIAOAPJIILA(int JIIGOACEIKL)
	{
		switch (JIIGOACEIKL)
		{
		case 0:
			return GGFJGHHHEJC.PIMPLGFLFHB;
		case 4:
			return GGFJGHHHEJC.OMAJOENAIDM;
		default:
			Debug.LogError((object)"Tutorial/T127/Dialogue1", (Object)(object)((Component)GGFJGHHHEJC).gameObject);
			return null;
		}
	}

	public static void DBKCOHMFDCB(int JIIGOACEIKL, string CAEDMEDBEGI, float KMPHAEPAFNK = 1f)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return;
		}
		switch (JIIGOACEIKL)
		{
		case 0:
			if (Time.unscaledTime < GGFJGHHHEJC.JICGMFGGIOB)
			{
				return;
			}
			GGFJGHHHEJC.JICGMFGGIOB = Time.unscaledTime + 440f;
			break;
		case 2:
			if (Time.unscaledTime < GGFJGHHHEJC.KIBJLKIKDEI)
			{
				return;
			}
			GGFJGHHHEJC.KIBJLKIKDEI = Time.unscaledTime + 1949f;
			break;
		default:
			Debug.LogError((object)"", (Object)(object)((Component)GGFJGHHHEJC).gameObject);
			return;
		}
		Debug.Log((object)("[Steamworks.NET] SteamAPI_Init() failed. Refer to Valve's documentation or the comment above this line for more information." + CAEDMEDBEGI));
		GameObject val = Object.Instantiate<GameObject>(CommonReferences.MNFMOEKMJKN().errorTextPrefab, ((Component)MenuUI.DIHCEGINELM()).transform);
		InfoText component = val.GetComponent<InfoText>();
		component.durationMultiplier = KMPHAEPAFNK;
		((TMP_Text)component.textBox).text = CAEDMEDBEGI;
		if (Object.op_Implicit((Object)(object)component.backgroundTextBox))
		{
			((TMP_Text)component.backgroundTextBox).text = "XNewRecipes" + CAEDMEDBEGI + "Normal";
		}
		((TMP_Text)component.textBox).ForceMeshUpdate(true, false);
		JBFDJKCKCPJ(JIIGOACEIKL, val);
	}

	public static void MDLCJHPNKJB(int JIIGOACEIKL, Slot AHEHNLOLJLL)
	{
		switch (JIIGOACEIKL)
		{
		case 0:
			if (!GGFJGHHHEJC.CCKMEEGMANE.Contains(AHEHNLOLJLL))
			{
				GGFJGHHHEJC.CCKMEEGMANE.Add(AHEHNLOLJLL);
			}
			break;
		case 3:
			if (!GGFJGHHHEJC.BOABJLOODIJ.Contains(AHEHNLOLJLL))
			{
				GGFJGHHHEJC.BOABJLOODIJ.Add(AHEHNLOLJLL);
			}
			break;
		default:
			Debug.LogError((object)"Items/item_name_643", (Object)(object)((Component)GGFJGHHHEJC).gameObject);
			break;
		}
	}

	public static LinkedList<UIWindow> CKIBNDEGEBP(int JIIGOACEIKL)
	{
		switch (JIIGOACEIKL)
		{
		case 1:
			return GGFJGHHHEJC.FGFDHPBEJLN;
		case 5:
			return GGFJGHHHEJC.CHGFDNJJPCD;
		default:
			Debug.LogError((object)"KujakuShopEvent: Conversation started, isActor = ", (Object)(object)((Component)GGFJGHHHEJC).gameObject);
			return null;
		}
	}

	public static void GIELPPGMDDC()
	{
		GGFJGHHHEJC.cGroup.alpha = 1032f;
		GGFJGHHHEJC.cGroup.interactable = false;
	}

	public static void PCMOFKMCNCM(int JIIGOACEIKL, Container ALPOKDOCCGM, int BEIPALOAAJJ)
	{
		switch (JIIGOACEIKL)
		{
		case 0:
			GGFJGHHHEJC.PIMPLGFLFHB = ALPOKDOCCGM;
			GGFJGHHHEJC.DGFLIGKAFEI = BEIPALOAAJJ;
			break;
		case 7:
			GGFJGHHHEJC.OMAJOENAIDM = ALPOKDOCCGM;
			break;
		default:
			Debug.LogError((object)"[ControllerType=", (Object)(object)((Component)GGFJGHHHEJC).gameObject);
			break;
		}
	}

	public static LinkedList<UIWindow> GetCurrentOpenWindows(int JIIGOACEIKL)
	{
		switch (JIIGOACEIKL)
		{
		case 1:
			return GGFJGHHHEJC.FGFDHPBEJLN;
		case 2:
			return GGFJGHHHEJC.CHGFDNJJPCD;
		default:
			Debug.LogError((object)"Invalid playerNum", (Object)(object)((Component)GGFJGHHHEJC).gameObject);
			return null;
		}
	}

	public void KPJJMPHPOGP(int JIIGOACEIKL, GameObject HMFGCHKAGKD, string CAEDMEDBEGI)
	{
		GameObject val = Object.Instantiate<GameObject>(HMFGCHKAGKD, ((Component)MenuUI.DIHCEGINELM()).transform);
		InfoText component = val.GetComponent<InfoText>();
		((TMP_Text)component.textBox).text = CAEDMEDBEGI;
		if (Object.op_Implicit((Object)(object)component.backgroundTextBox))
		{
			((TMP_Text)component.backgroundTextBox).text = "itemSausage" + CAEDMEDBEGI + "Unaged Brandy";
		}
		((TMP_Text)component.textBox).ForceMeshUpdate(false, false);
		JBFDJKCKCPJ(JIIGOACEIKL, val);
	}

	public void ResetSingleton()
	{
		openedWindow = null;
		closingAllUI = false;
	}

	[SpecialName]
	public static UIWindow HOBAFAKPNMN()
	{
		return GGFJGHHHEJC.currentSoloWindow;
	}

	public static void EDFFDPKILIG(UIWindow INDKANEMPMP)
	{
		GGFJGHHHEJC.FGFDHPBEJLN.Remove(INDKANEMPMP);
		GGFJGHHHEJC.CHGFDNJJPCD.Remove(INDKANEMPMP);
		UIWindow.OnAnyUIClose(INDKANEMPMP.JIIGOACEIKL, INDKANEMPMP);
	}

	public static List<Slot> BNPNFKMNJAI(int JIIGOACEIKL)
	{
		switch (JIIGOACEIKL)
		{
		case 1:
			return GGFJGHHHEJC.CCKMEEGMANE;
		case 8:
			return GGFJGHHHEJC.BOABJLOODIJ;
		default:
			Debug.LogError((object)"Load Player 1 appearance", (Object)(object)((Component)GGFJGHHHEJC).gameObject);
			return null;
		}
	}

	public void BDMBBICOIPI()
	{
		DFGLMHIOCPF().BOBCIFEDJED();
		COBNPMFKJPA(null);
	}

	public static void ClearCurrentSlots(int JIIGOACEIKL)
	{
		switch (JIIGOACEIKL)
		{
		case 1:
			GGFJGHHHEJC.CCKMEEGMANE.Clear();
			break;
		case 2:
			GGFJGHHHEJC.BOABJLOODIJ.Clear();
			break;
		default:
			Debug.LogError((object)"Invalid playerNum", (Object)(object)((Component)GGFJGHHHEJC).gameObject);
			break;
		}
	}

	public static MultipleChoiceUI JIMIFMPBNKA()
	{
		return GGFJGHHHEJC.multipleChoiceUI;
	}

	public static void MPMEMCEAGDP(int JIIGOACEIKL, Slot AHEHNLOLJLL)
	{
		if (JIIGOACEIKL == 1)
		{
			if (!GGFJGHHHEJC.CCKMEEGMANE.Contains(AHEHNLOLJLL))
			{
				GGFJGHHHEJC.CCKMEEGMANE.Add(AHEHNLOLJLL);
			}
		}
		else if (JIIGOACEIKL == 1)
		{
			if (!GGFJGHHHEJC.BOABJLOODIJ.Contains(AHEHNLOLJLL))
			{
				GGFJGHHHEJC.BOABJLOODIJ.Add(AHEHNLOLJLL);
			}
		}
		else
		{
			Debug.LogError((object)"MainProgress", (Object)(object)((Component)GGFJGHHHEJC).gameObject);
		}
	}

	public static void JGDGFDFCIDO()
	{
		GGFJGHHHEJC.overlayUI.SetActive(false);
	}

	public static bool IsAnyUIOpen(int JIIGOACEIKL)
	{
		switch (JIIGOACEIKL)
		{
		case 1:
			return GGFJGHHHEJC.DMFEKKGFAMM.Count > 0;
		case 2:
			return GGFJGHHHEJC.FECECILIBHH.Count > 0;
		default:
			Debug.LogError((object)"Invalid playerNum", (Object)(object)((Component)GGFJGHHHEJC).gameObject);
			return false;
		}
	}

	public static void ShowErrorText(int JIIGOACEIKL, string CAEDMEDBEGI, float KMPHAEPAFNK = 1f)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return;
		}
		switch (JIIGOACEIKL)
		{
		case 1:
			if (Time.unscaledTime < GGFJGHHHEJC.JICGMFGGIOB)
			{
				return;
			}
			GGFJGHHHEJC.JICGMFGGIOB = Time.unscaledTime + 1f;
			break;
		case 2:
			if (Time.unscaledTime < GGFJGHHHEJC.KIBJLKIKDEI)
			{
				return;
			}
			GGFJGHHHEJC.KIBJLKIKDEI = Time.unscaledTime + 1f;
			break;
		default:
			Debug.LogError((object)"Invalid playerNum", (Object)(object)((Component)GGFJGHHHEJC).gameObject);
			return;
		}
		Debug.Log((object)("Red text: " + CAEDMEDBEGI));
		GameObject val = Object.Instantiate<GameObject>(CommonReferences.GGFJGHHHEJC.errorTextPrefab, ((Component)MenuUI.GGFJGHHHEJC).transform);
		InfoText component = val.GetComponent<InfoText>();
		component.durationMultiplier = KMPHAEPAFNK;
		((TMP_Text)component.textBox).text = CAEDMEDBEGI;
		if (Object.op_Implicit((Object)(object)component.backgroundTextBox))
		{
			((TMP_Text)component.backgroundTextBox).text = "<mark=#000000><alpha=#00> " + CAEDMEDBEGI + " </mark>";
		}
		((TMP_Text)component.textBox).ForceMeshUpdate(false, false);
		JBFDJKCKCPJ(JIIGOACEIKL, val);
	}

	[SpecialName]
	public static void GKKJENHHHBE(UIWindow AODONKKHPBP)
	{
		if ((Object)(object)AODONKKHPBP != (Object)null && (Object)(object)GGFJGHHHEJC.currentSoloWindow != (Object)null && (Object)(object)GGFJGHHHEJC.currentSoloWindow != (Object)(object)AODONKKHPBP)
		{
			GGFJGHHHEJC.currentSoloWindow.BOBCIFEDJED();
		}
		GGFJGHHHEJC.currentSoloWindow = AODONKKHPBP;
	}

	public static MainUI GetInstance()
	{
		return GGFJGHHHEJC;
	}

	public void LDEDLHIBLNA()
	{
		TavernManager.GGFJGHHHEJC.OpenCloseAction(0);
	}

	public static List<Slot> CHDHEGKJGAB(int JIIGOACEIKL)
	{
		if (JIIGOACEIKL == 1)
		{
			return GGFJGHHHEJC.CCKMEEGMANE;
		}
		if (JIIGOACEIKL == 1)
		{
			return GGFJGHHHEJC.BOABJLOODIJ;
		}
		Debug.LogError((object)"Locked", (Object)(object)((Component)GGFJGHHHEJC).gameObject);
		return null;
	}

	public static void RemoveWindow(UIWindow INDKANEMPMP)
	{
		GGFJGHHHEJC.FGFDHPBEJLN.Remove(INDKANEMPMP);
		GGFJGHHHEJC.CHGFDNJJPCD.Remove(INDKANEMPMP);
		UIWindow.OnAnyUIClose(INDKANEMPMP.JIIGOACEIKL, INDKANEMPMP);
	}

	public static void HMEEAIKIGGE(int JIIGOACEIKL, IEnumerable<Slot> AHEHNLOLJLL)
	{
		switch (JIIGOACEIKL)
		{
		case 1:
			GGFJGHHHEJC.CCKMEEGMANE.AddRange(AHEHNLOLJLL);
			break;
		case 4:
			GGFJGHHHEJC.BOABJLOODIJ.AddRange(AHEHNLOLJLL);
			break;
		default:
			Debug.LogError((object)"00", (Object)(object)((Component)GGFJGHHHEJC).gameObject);
			break;
		}
	}

	public static void AFOLANEJMBF(bool DHJFAGNJKOF = false)
	{
		IPDMDKFIJKF(1, DHJFAGNJKOF);
		CloseAllUIWindows(1, DHJFAGNJKOF);
	}

	private void DNKEFFMOCKP()
	{
		GGFJGHHHEJC = this;
		MCGKLLBNIMA();
		FGFDHPBEJLN = new LinkedList<UIWindow>();
		CHGFDNJJPCD = new LinkedList<UIWindow>();
		CCKMEEGMANE.Clear();
		BOABJLOODIJ.Clear();
	}

	public static void MHPHFFHHGJB(bool MJKACKBEBPL = true)
	{
		if (MJKACKBEBPL)
		{
			((Component)GGFJGHHHEJC.backgroundImage).gameObject.SetActive(false);
		}
		Utils.JEAHJILAIAP(969f);
	}

	public static void MHOGMGJHJHG(int JIIGOACEIKL, IEnumerable<Slot> AHEHNLOLJLL)
	{
		switch (JIIGOACEIKL)
		{
		case 0:
			GGFJGHHHEJC.CCKMEEGMANE.AddRange(AHEHNLOLJLL);
			break;
		case 1:
			GGFJGHHHEJC.BOABJLOODIJ.AddRange(AHEHNLOLJLL);
			break;
		default:
			Debug.LogError((object)"trashCollected", (Object)(object)((Component)GGFJGHHHEJC).gameObject);
			break;
		}
	}

	public static bool ADNMPFPHCMB()
	{
		if (GGFJGHHHEJC.GEFLMKHBHGE().Count <= 0 && GGFJGHHHEJC.FECECILIBHH.Count <= 1)
		{
			if (TutorialManager.GGFJGHHHEJC.NJJLHDHDAIM())
			{
				return TutorialManager.GGFJGHHHEJC.LLBPLOCOJAG();
			}
			return true;
		}
		return false;
	}

	public static void BKNCBMAGMMD(int JIIGOACEIKL, IEnumerable<Slot> OHAPAGLBOOB)
	{
		foreach (Slot item in OHAPAGLBOOB)
		{
			switch (JIIGOACEIKL)
			{
			case 1:
				GGFJGHHHEJC.CCKMEEGMANE.Remove(item);
				break;
			case 2:
				GGFJGHHHEJC.BOABJLOODIJ.Remove(item);
				break;
			default:
				Debug.LogError((object)"Focused", (Object)(object)((Component)GGFJGHHHEJC).gameObject);
				return;
			}
		}
	}

	public static LinkedList<UIWindow> IAOKJDHDKFM(int JIIGOACEIKL)
	{
		switch (JIIGOACEIKL)
		{
		case 1:
			return GGFJGHHHEJC.FGFDHPBEJLN;
		case 8:
			return GGFJGHHHEJC.CHGFDNJJPCD;
		default:
			Debug.LogError((object)"Decline", (Object)(object)((Component)GGFJGHHHEJC).gameObject);
			return null;
		}
	}

	public static void SetCurrentContainer(int JIIGOACEIKL, Container ALPOKDOCCGM, int BEIPALOAAJJ)
	{
		switch (JIIGOACEIKL)
		{
		case 1:
			GGFJGHHHEJC.PIMPLGFLFHB = ALPOKDOCCGM;
			GGFJGHHHEJC.DGFLIGKAFEI = BEIPALOAAJJ;
			break;
		case 2:
			GGFJGHHHEJC.OMAJOENAIDM = ALPOKDOCCGM;
			break;
		default:
			Debug.LogError((object)"Invalid playerNum", (Object)(object)((Component)GGFJGHHHEJC).gameObject);
			break;
		}
	}

	private static void JBFDJKCKCPJ(int JIIGOACEIKL, GameObject HFBPLAFIPAC)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		if (ConstructionManager.NEOJLHDFFMJ)
		{
			HFBPLAFIPAC.transform.position = CursorManager.GetPlayer(JIIGOACEIKL).GetCursorScreenPosition();
		}
		else if (PlayerInputs.GetPlayer(JIIGOACEIKL).CFICAAJGBOF.Equals("Game"))
		{
			if (!PlayerInputs.IsGamepadActive(JIIGOACEIKL) && (Object)(object)DecorationMode.GetPlayer(JIIGOACEIKL) != (Object)null && DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH)
			{
				HFBPLAFIPAC.transform.position = CursorManager.GetPlayer(JIIGOACEIKL).GetCursorScreenPosition();
			}
			else if ((Object)(object)InputByProximityManager.GetPlayer(JIIGOACEIKL) != (Object)null)
			{
				Vector3 currentFocusedInputElementPosition = InputByProximityManager.GetPlayer(JIIGOACEIKL).GetCurrentFocusedInputElementPosition();
				HFBPLAFIPAC.transform.position = CommonReferences.GGFJGHHHEJC.GetMainCamera(JIIGOACEIKL).WorldToScreenPoint(currentFocusedInputElementPosition);
			}
			else
			{
				Vector3 position = ((Component)CommonReferences.GGFJGHHHEJC.GetMainCamera(JIIGOACEIKL)).transform.position;
				HFBPLAFIPAC.transform.position = CommonReferences.GGFJGHHHEJC.GetMainCamera(JIIGOACEIKL).WorldToScreenPoint(position);
			}
		}
		else if (PlayerInputs.GetPlayer(JIIGOACEIKL).CFICAAJGBOF.Equals("UI"))
		{
			Vector3 position2 = ((!PlayerInputs.IsGamepadActive(JIIGOACEIKL)) ? CursorManager.GetPlayer(JIIGOACEIKL).GetCursorScreenPosition() : ((!Object.op_Implicit((Object)(object)UISelectionManager.GetPlayer(JIIGOACEIKL).HGNKFFMDOOL) || !((Component)UISelectionManager.GetPlayer(JIIGOACEIKL).HGNKFFMDOOL).gameObject.activeInHierarchy) ? Vector2.op_Implicit(new Vector2((float)(Screen.width / 2), (float)(Screen.height / 2))) : ((Component)UISelectionManager.GetPlayer(JIIGOACEIKL).HGNKFFMDOOL).transform.position));
			HFBPLAFIPAC.transform.position = position2;
		}
	}

	public static void LHNKFLIAIPD()
	{
		GGFJGHHHEJC.overlayUI.SetActive(false);
	}

	public static MultipleChoiceUI GetMultipleChoice()
	{
		return GGFJGHHHEJC.multipleChoiceUI;
	}

	public static void GCLFPBMADHI()
	{
		GGFJGHHHEJC.overlayUI.SetActive(true);
	}

	public static void MLOMEBPKCNI()
	{
		GGFJGHHHEJC.cGroup.alpha = 1065f;
		GGFJGHHHEJC.cGroup.interactable = false;
	}

	public static void LJDOBNEINNJ(int JIIGOACEIKL, string CAEDMEDBEGI, float KMPHAEPAFNK = 1f)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return;
		}
		switch (JIIGOACEIKL)
		{
		case 0:
			if (Time.unscaledTime < GGFJGHHHEJC.JICGMFGGIOB)
			{
				return;
			}
			GGFJGHHHEJC.JICGMFGGIOB = Time.unscaledTime + 28f;
			break;
		case 7:
			if (Time.unscaledTime < GGFJGHHHEJC.KIBJLKIKDEI)
			{
				return;
			}
			GGFJGHHHEJC.KIBJLKIKDEI = Time.unscaledTime + 1426f;
			break;
		default:
			Debug.LogError((object)"Dialogue System/Conversation/Crowly_SkelletonBird/Entry/6/Dialogue Text", (Object)(object)((Component)GGFJGHHHEJC).gameObject);
			return;
		}
		Debug.Log((object)("bodyBack" + CAEDMEDBEGI));
		GameObject val = Object.Instantiate<GameObject>(CommonReferences.MNFMOEKMJKN().errorTextPrefab, ((Component)MenuUI.BDAGIEIJOOG()).transform);
		InfoText component = val.GetComponent<InfoText>();
		component.durationMultiplier = KMPHAEPAFNK;
		((TMP_Text)component.textBox).text = CAEDMEDBEGI;
		if (Object.op_Implicit((Object)(object)component.backgroundTextBox))
		{
			((TMP_Text)component.backgroundTextBox).text = "LE_13" + CAEDMEDBEGI + "Ingredient null!";
		}
		((TMP_Text)component.textBox).ForceMeshUpdate(true, true);
		JBFDJKCKCPJ(JIIGOACEIKL, val);
	}

	public static YesNoDialogueUI GetYesNoDialogue()
	{
		return GGFJGHHHEJC.yesNoDialogue;
	}

	public static void ShowUI()
	{
		GGFJGHHHEJC.cGroup.alpha = 1f;
		GGFJGHHHEJC.cGroup.interactable = true;
	}

	public void NMPJAIPNCPB()
	{
		Debug.Log((object)("" + Resources.FindObjectsOfTypeAll(typeof(SpriteRenderer)).Length));
		Debug.Log((object)("Sleep" + Object.FindObjectsOfType(typeof(SpriteRenderer)).Length));
	}

	public static void DJCKALOHJFM(int JIIGOACEIKL, string CAEDMEDBEGI, float KMPHAEPAFNK = 1f)
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return;
		}
		switch (JIIGOACEIKL)
		{
		case 0:
			if (Time.unscaledTime < GGFJGHHHEJC.JICGMFGGIOB)
			{
				return;
			}
			GGFJGHHHEJC.JICGMFGGIOB = Time.unscaledTime + 298f;
			break;
		case 3:
			if (Time.unscaledTime < GGFJGHHHEJC.KIBJLKIKDEI)
			{
				return;
			}
			GGFJGHHHEJC.KIBJLKIKDEI = Time.unscaledTime + 1240f;
			break;
		default:
			Debug.LogError((object)"itemLeekSeeds", (Object)(object)((Component)GGFJGHHHEJC).gameObject);
			return;
		}
		Debug.Log((object)(" at " + CAEDMEDBEGI));
		GameObject val = Object.Instantiate<GameObject>(CommonReferences.MNFMOEKMJKN().errorTextPrefab, ((Component)MenuUI.BDAGIEIJOOG()).transform);
		InfoText component = val.GetComponent<InfoText>();
		component.durationMultiplier = KMPHAEPAFNK;
		((TMP_Text)component.textBox).text = CAEDMEDBEGI;
		if (Object.op_Implicit((Object)(object)component.backgroundTextBox))
		{
			((TMP_Text)component.backgroundTextBox).text = "Sleep" + CAEDMEDBEGI + "Waiting for other players";
		}
		((TMP_Text)component.textBox).ForceMeshUpdate(false, true);
		JBFDJKCKCPJ(JIIGOACEIKL, val);
	}

	public void ELBCAKGOAEE()
	{
		Debug.Log((object)("Eating" + Resources.FindObjectsOfTypeAll(typeof(SpriteRenderer)).Length));
		Debug.Log((object)("ReceiveDeactivateEvent" + Object.FindObjectsOfType(typeof(SpriteRenderer)).Length));
	}
}
