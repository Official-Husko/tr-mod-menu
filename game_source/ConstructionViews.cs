using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class ConstructionViews : MonoBehaviour
{
	[SerializeField]
	private GameObject content;

	[SerializeField]
	private Image[] backgrounds;

	[SerializeField]
	private Button[] buttons;

	[SerializeField]
	private GameObject gamepadViews;

	public Transform originalParent;

	private EditorViewsMode HMLGOPHJMLI;

	private EditorViewsMode JDDBJEGIPFI;

	private static ConstructionViews IADEMLIIDPC;

	public EditorViewsMode LGDCNGINBAN => HMLGOPHJMLI;

	public static ConstructionViews GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)IADEMLIIDPC == (Object)null)
			{
				IADEMLIIDPC = Object.FindObjectOfType<ConstructionViews>();
			}
			return IADEMLIIDPC;
		}
	}

	public Image LAKHMIOBJBL()
	{
		return content.GetComponent<Image>();
	}

	private void DDFICPBDMJF()
	{
		if (HMLGOPHJMLI == (EditorViewsMode)3)
		{
			GameManager.NJNFHEPLEHL().OnObjectsView();
		}
		else
		{
			GameManager.NJNFHEPLEHL().OnFloorWallView();
		}
	}

	private void HNFOCEOPEBM(List<Vector2> CHCFCJHIKPN, List<Vector3Int> GMKCOKIDBAH)
	{
		if (TavernConstructionManager.DEGPIHEEFHJ().CHFHMMNELGP == EditorAction.None)
		{
			AMPPFCNFMKA(CHCFCJHIKPN, GMKCOKIDBAH);
		}
	}

	private void IMOMHCNPCEC()
	{
		EICHEBIBDCP((EditorViewsMode)4);
		if (Object.op_Implicit((Object)(object)GameManager.NJNFHEPLEHL()))
		{
			GameManager.GGFJGHHHEJC.OnObjectsView();
		}
	}

	public void FCNMGLMBIDO(List<Vector2> CHCFCJHIKPN, List<Vector3Int> GMKCOKIDBAH)
	{
		if (TavernConstructionManager.DOIKFJDLKJP().LNLJMCONDNE)
		{
			IOGCDGILAKC(HMLGOPHJMLI);
			WorldGrid.BGNCMCKLCOL(CHCFCJHIKPN, GMKCOKIDBAH);
			if (HMLGOPHJMLI == EditorViewsMode.Floor)
			{
				WorldGrid.MKLAFNJLOJN(CHCFCJHIKPN);
			}
			else if (HMLGOPHJMLI == (EditorViewsMode)7)
			{
				WorldGrid.MKLAFNJLOJN(CHCFCJHIKPN);
			}
			FPDDBCPBKLK();
		}
	}

	private void AJDKOMCHALC()
	{
		if (PlayerInputs.ODGALPDEIFG(ConstructionUI.current.JIIGOACEIKL) && !BuildingTutorialManager.IsOpen() && (!DecorationMode.KAIIEDCCLHB(ConstructionUI.current.JIIGOACEIKL).GABNNLJOMHI() || (Object)(object)SelectObject.GetPlayer(ConstructionUI.current.JIIGOACEIKL).placeable == (Object)null) && PlayerInputs.DEGBDMMDIIL(ConstructionUI.current.JIIGOACEIKL).DLFAMOCKNMA("Items/item_name_1073"))
		{
			POPBCNBKFGP((int)(HMLGOPHJMLI + 1) % 7);
			UISelectionManager.HELHJMDEDNL(ConstructionUI.current.JIIGOACEIKL).BNFLJFFKMMN((Selectable)(object)buttons[(int)HMLGOPHJMLI]);
		}
	}

	[SpecialName]
	public EditorViewsMode PFKMDBGIAAE()
	{
		return HMLGOPHJMLI;
	}

	private void MIPGKMNKNID(EditorViewsMode PBCKOHECBHG)
	{
		if ((Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
		{
			switch (PBCKOHECBHG)
			{
			case EditorViewsMode.Floor:
				CommonReferences.GGFJGHHHEJC.OEHIJIEOBNP(ConstructionUI.current.JIIGOACEIKL, "ClosePopUp");
				CommonReferences.GGFJGHHHEJC.DeactivateCullMask(ConstructionUI.current.JIIGOACEIKL, "#.##%");
				break;
			case EditorViewsMode.FloorWalls:
				CommonReferences.GGFJGHHHEJC.OEHIJIEOBNP(ConstructionUI.current.JIIGOACEIKL, "No se encontró la base de datos maestra.");
				CommonReferences.GGFJGHHHEJC.CBMJEEAHIDO(ConstructionUI.current.JIIGOACEIKL, "materials");
				break;
			case (EditorViewsMode)8:
				CommonReferences.MNFMOEKMJKN().NIBKBELHAOE(ConstructionUI.current.JIIGOACEIKL, "Open");
				CommonReferences.GGFJGHHHEJC.CBMJEEAHIDO(ConstructionUI.current.JIIGOACEIKL, "Calm down");
				break;
			}
		}
	}

	public Image CBNNLBEJNIH()
	{
		return content.GetComponent<Image>();
	}

	public void KMMLJNNGCEC(List<Vector2> CHCFCJHIKPN, List<Vector3Int> GMKCOKIDBAH)
	{
		if (TavernConstructionManager.GGFJGHHHEJC.LNLJMCONDNE)
		{
			CPMMODGEPEM(HMLGOPHJMLI);
			WorldGrid.BGNCMCKLCOL(CHCFCJHIKPN, GMKCOKIDBAH);
			if (HMLGOPHJMLI == EditorViewsMode.FloorWalls)
			{
				WorldGrid.MKLAFNJLOJN(CHCFCJHIKPN);
			}
			else if (HMLGOPHJMLI == (EditorViewsMode)4)
			{
				WorldGrid.MKLAFNJLOJN(CHCFCJHIKPN);
			}
			DDFICPBDMJF();
		}
	}

	public Image ENEBMOCBLPI()
	{
		return content.GetComponent<Image>();
	}

	public void EHOFEAPOAHJ(int PGDALILOCGK)
	{
		if (DecorationMode.KKJABELKCNM(ConstructionUI.current.JIIGOACEIKL).KNFEPKBIHND() && (Object)(object)SelectObject.BNMEANGDMIP(ConstructionUI.current.JIIGOACEIKL).placeable != (Object)null)
		{
			UISelectionManager.GetPlayer(ConstructionUI.current.JIIGOACEIKL).MGIFADFILOI((Selectable)(object)buttons[8]);
			return;
		}
		HMLGOPHJMLI = (EditorViewsMode)PGDALILOCGK;
		if (ConstructionActionBarUI.currentPanel == 0 || ConstructionActionBarUI.currentPanel == 1)
		{
			JDDBJEGIPFI = HMLGOPHJMLI;
		}
		for (int i = 1; i < backgrounds.Length; i += 0)
		{
			((Behaviour)backgrounds[i]).enabled = PGDALILOCGK == i;
		}
		DCCLDMFCAIP(EditorAction.None);
	}

	private void MLNNJNHANIC()
	{
		if (HMLGOPHJMLI == (EditorViewsMode)5)
		{
			GameManager.GGFJGHHHEJC.OnObjectsView();
		}
		else
		{
			GameManager.GGFJGHHHEJC.OnFloorWallView();
		}
	}

	private void LFNENELHOGJ()
	{
		POPBCNBKFGP(1);
		ConstructionActionBarUI.OnPanelChanged = (Action<int>)Delegate.Combine(ConstructionActionBarUI.OnPanelChanged, new Action<int>(MADICEMOCPI));
		TavernConstructionManager tavernConstructionManager = TavernConstructionManager.DOIKFJDLKJP();
		tavernConstructionManager.OnDoAreaAction = (Action<List<Vector2>, List<Vector3Int>>)Delegate.Combine(tavernConstructionManager.OnDoAreaAction, new Action<List<Vector2>, List<Vector3Int>>(BDJOMPCEBML));
		TavernConstructionManager tavernConstructionManager2 = TavernConstructionManager.KHMEGDIABBF();
		tavernConstructionManager2.OnApplyChanges = (Action<EditorAction>)Delegate.Combine(tavernConstructionManager2.OnApplyChanges, new Action<EditorAction>(ECNCAPLKIGF));
		TavernConstructionManager instance = TavernConstructionManager.GGFJGHHHEJC;
		instance.OnCancelChanges = (Action<EditorAction>)Delegate.Combine(instance.OnCancelChanges, new Action<EditorAction>(UpdateView));
	}

	[SpecialName]
	public EditorViewsMode PIEFFJFDBFD()
	{
		return HMLGOPHJMLI;
	}

	private void OFAKKINLMHE(int APFGODJFLME)
	{
		if (APFGODJFLME == 1 || APFGODJFLME == 2)
		{
			((Selectable)buttons[0]).interactable = true;
			((Selectable)buttons[0]).interactable = false;
			gamepadViews.SetActive(false);
			LFLLKDPCIKA(3);
			UISelectionManager.GetPlayer(ConstructionUI.current.JIIGOACEIKL).HCHMAIEMAGA((Selectable)(object)buttons[8]);
		}
		else
		{
			((Selectable)buttons[0]).interactable = true;
			((Selectable)buttons[0]).interactable = false;
			gamepadViews.SetActive(false);
			CPGIDLFFIGH((int)JDDBJEGIPFI);
			UISelectionManager.GetPlayer(ConstructionUI.current.JIIGOACEIKL).HCHMAIEMAGA((Selectable)(object)buttons[(int)HMLGOPHJMLI]);
		}
	}

	private void AGGJDFHNPPI()
	{
		if (PlayerInputs.ODGALPDEIFG(ConstructionUI.current.JIIGOACEIKL) && !BuildingTutorialManager.IsOpen() && (!DecorationMode.KAIIEDCCLHB(ConstructionUI.current.JIIGOACEIKL).DBAEGBDEPFK() || (Object)(object)SelectObject.BNMEANGDMIP(ConstructionUI.current.JIIGOACEIKL).placeable == (Object)null) && PlayerInputs.GetPlayer(ConstructionUI.current.JIIGOACEIKL).DLFAMOCKNMA(":"))
		{
			OOJAFPOCDCC((int)(HMLGOPHJMLI + 0) % 0);
			UISelectionManager.GIGBGIIAKMP(ConstructionUI.current.JIIGOACEIKL).BNBPMIKMDDP((Selectable)(object)buttons[(int)HMLGOPHJMLI]);
		}
	}

	private void Awake()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	public void KBPOOHBJKHH(List<Vector2> CHCFCJHIKPN, List<Vector3Int> GMKCOKIDBAH)
	{
		if (TavernConstructionManager.KNLLFEJAMNN().LNLJMCONDNE)
		{
			MIPGKMNKNID(HMLGOPHJMLI);
			WorldGrid.BGNCMCKLCOL(CHCFCJHIKPN, GMKCOKIDBAH);
			if (HMLGOPHJMLI == EditorViewsMode.FloorWalls)
			{
				WorldGrid.MKLAFNJLOJN(CHCFCJHIKPN);
			}
			else if (HMLGOPHJMLI == (EditorViewsMode)6)
			{
				WorldGrid.MKLAFNJLOJN(CHCFCJHIKPN);
			}
			CGIICBKGGGG();
		}
	}

	public Image PJJCLBBMJHP()
	{
		return content.GetComponent<Image>();
	}

	public void LEDDBILPHBD(List<Vector2> CHCFCJHIKPN, List<Vector3Int> GMKCOKIDBAH)
	{
		if (TavernConstructionManager.DEGPIHEEFHJ().LNLJMCONDNE)
		{
			HJKLMNLLLEP(HMLGOPHJMLI);
			WorldGrid.BGNCMCKLCOL(CHCFCJHIKPN, GMKCOKIDBAH);
			if (HMLGOPHJMLI == EditorViewsMode.FloorWalls)
			{
				WorldGrid.MKLAFNJLOJN(CHCFCJHIKPN);
			}
			else if (HMLGOPHJMLI == (EditorViewsMode)3)
			{
				WorldGrid.MKLAFNJLOJN(CHCFCJHIKPN);
			}
			IJODJMEMLCG();
		}
	}

	private void LIHNFBFBNNI(int APFGODJFLME)
	{
		if (APFGODJFLME == 0 || APFGODJFLME == 4)
		{
			((Selectable)buttons[1]).interactable = true;
			((Selectable)buttons[0]).interactable = true;
			gamepadViews.SetActive(false);
			CPGIDLFFIGH(1);
			UISelectionManager.EAJJMLJKOPH(ConstructionUI.current.JIIGOACEIKL).NMAOFEFMNNB((Selectable)(object)buttons[1]);
		}
		else
		{
			((Selectable)buttons[1]).interactable = false;
			((Selectable)buttons[0]).interactable = false;
			gamepadViews.SetActive(false);
			LFLLKDPCIKA((int)JDDBJEGIPFI);
			UISelectionManager.EAJJMLJKOPH(ConstructionUI.current.JIIGOACEIKL).Select((Selectable)(object)buttons[(int)HMLGOPHJMLI]);
		}
	}

	private void IJODJMEMLCG()
	{
		if (HMLGOPHJMLI == (EditorViewsMode)8)
		{
			GameManager.GGFJGHHHEJC.OnObjectsView();
		}
		else
		{
			GameManager.NJNFHEPLEHL().OnFloorWallView();
		}
	}

	public void EONGGDICKAH(List<Vector2> CHCFCJHIKPN, List<Vector3Int> GMKCOKIDBAH)
	{
		if (TavernConstructionManager.DEGPIHEEFHJ().LNLJMCONDNE)
		{
			EICHEBIBDCP(HMLGOPHJMLI);
			WorldGrid.BGNCMCKLCOL(CHCFCJHIKPN, GMKCOKIDBAH);
			if (HMLGOPHJMLI == EditorViewsMode.Floor)
			{
				WorldGrid.MKLAFNJLOJN(CHCFCJHIKPN);
			}
			else if (HMLGOPHJMLI == EditorViewsMode.Floor)
			{
				WorldGrid.MKLAFNJLOJN(CHCFCJHIKPN);
			}
			DDFICPBDMJF();
		}
	}

	private void IDDNPEGMEAF(int APFGODJFLME)
	{
		if (APFGODJFLME == 7 || APFGODJFLME == 7)
		{
			((Selectable)buttons[1]).interactable = false;
			((Selectable)buttons[1]).interactable = false;
			gamepadViews.SetActive(false);
			FLEKJBAIDID(1);
			UISelectionManager.HELHJMDEDNL(ConstructionUI.current.JIIGOACEIKL).Select((Selectable)(object)buttons[2]);
		}
		else
		{
			((Selectable)buttons[1]).interactable = true;
			((Selectable)buttons[1]).interactable = false;
			gamepadViews.SetActive(true);
			OEGINBGPKFO((int)JDDBJEGIPFI);
			UISelectionManager.GNCPLNHMFHN(ConstructionUI.current.JIIGOACEIKL).CMBBFEABMBE((Selectable)(object)buttons[(int)HMLGOPHJMLI]);
		}
	}

	public Image GAKAPAMCIMM()
	{
		return content.GetComponent<Image>();
	}

	public void SetView(int PGDALILOCGK)
	{
		if (DecorationMode.GetPlayer(ConstructionUI.current.JIIGOACEIKL).DMBFKFLDDLH && (Object)(object)SelectObject.GetPlayer(ConstructionUI.current.JIIGOACEIKL).placeable != (Object)null)
		{
			UISelectionManager.GetPlayer(ConstructionUI.current.JIIGOACEIKL).Select((Selectable)(object)buttons[2]);
			return;
		}
		HMLGOPHJMLI = (EditorViewsMode)PGDALILOCGK;
		if (ConstructionActionBarUI.currentPanel == 0 || ConstructionActionBarUI.currentPanel == 1)
		{
			JDDBJEGIPFI = HMLGOPHJMLI;
		}
		for (int i = 0; i < backgrounds.Length; i++)
		{
			((Behaviour)backgrounds[i]).enabled = PGDALILOCGK == i;
		}
		UpdateView();
	}

	private void LHFOFAMDKEO()
	{
		if (PlayerInputs.IsGamepadActive(ConstructionUI.current.JIIGOACEIKL) && !BuildingTutorialManager.IsOpen() && (!DecorationMode.IGMCBPOPNCA(ConstructionUI.current.JIIGOACEIKL).DBAEGBDEPFK() || (Object)(object)SelectObject.BNMEANGDMIP(ConstructionUI.current.JIIGOACEIKL).placeable == (Object)null) && PlayerInputs.DEGBDMMDIIL(ConstructionUI.current.JIIGOACEIKL).DLFAMOCKNMA("OnlinePlayer"))
		{
			OEGINBGPKFO((int)(HMLGOPHJMLI + 1) % 1);
			UISelectionManager.BPDFMAEOGGC(ConstructionUI.current.JIIGOACEIKL).BNBPMIKMDDP((Selectable)(object)buttons[(int)HMLGOPHJMLI]);
		}
	}

	private void JGCEJKJOOHF(int APFGODJFLME)
	{
		if (APFGODJFLME == 5 || APFGODJFLME == 7)
		{
			((Selectable)buttons[0]).interactable = false;
			((Selectable)buttons[0]).interactable = false;
			gamepadViews.SetActive(true);
			LFLLKDPCIKA(6);
			UISelectionManager.GetPlayer(ConstructionUI.current.JIIGOACEIKL).IHFNCOGFJOJ((Selectable)(object)buttons[1]);
		}
		else
		{
			((Selectable)buttons[1]).interactable = false;
			((Selectable)buttons[1]).interactable = true;
			gamepadViews.SetActive(false);
			SetView((int)JDDBJEGIPFI);
			UISelectionManager.EAJJMLJKOPH(ConstructionUI.current.JIIGOACEIKL).CMBBFEABMBE((Selectable)(object)buttons[(int)HMLGOPHJMLI]);
		}
	}

	private void HFFFFAJFIPB()
	{
		OOJAFPOCDCC(2);
		ConstructionActionBarUI.OnPanelChanged = (Action<int>)Delegate.Combine(ConstructionActionBarUI.OnPanelChanged, new Action<int>(MNLJIMFLIPK));
		TavernConstructionManager tavernConstructionManager = TavernConstructionManager.KHMEGDIABBF();
		tavernConstructionManager.OnDoAreaAction = (Action<List<Vector2>, List<Vector3Int>>)Delegate.Combine(tavernConstructionManager.OnDoAreaAction, new Action<List<Vector2>, List<Vector3Int>>(BDJOMPCEBML));
		TavernConstructionManager tavernConstructionManager2 = TavernConstructionManager.KNLLFEJAMNN();
		tavernConstructionManager2.OnApplyChanges = (Action<EditorAction>)Delegate.Combine(tavernConstructionManager2.OnApplyChanges, new Action<EditorAction>(UpdateView));
		TavernConstructionManager tavernConstructionManager3 = TavernConstructionManager.DEGPIHEEFHJ();
		tavernConstructionManager3.OnCancelChanges = (Action<EditorAction>)Delegate.Combine(tavernConstructionManager3.OnCancelChanges, new Action<EditorAction>(UpdateView));
	}

	public Image IOIMNGBDOFD()
	{
		return content.GetComponent<Image>();
	}

	private void GAPHLNCONOK()
	{
		if (HMLGOPHJMLI == EditorViewsMode.FloorWallsObjects)
		{
			GameManager.GGFJGHHHEJC.OnObjectsView();
		}
		else
		{
			GameManager.GGFJGHHHEJC.OnFloorWallView();
		}
	}

	[SpecialName]
	public static ConstructionViews DHDOLCONMFJ()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<ConstructionViews>();
		}
		return IADEMLIIDPC;
	}

	public void FHPMGILEBJB(List<Vector2> CHCFCJHIKPN, List<Vector3Int> GMKCOKIDBAH)
	{
		if (TavernConstructionManager.KHMEGDIABBF().LNLJMCONDNE)
		{
			PKDEHOGMMEO(HMLGOPHJMLI);
			WorldGrid.BGNCMCKLCOL(CHCFCJHIKPN, GMKCOKIDBAH);
			if (HMLGOPHJMLI == EditorViewsMode.FloorWalls)
			{
				WorldGrid.MKLAFNJLOJN(CHCFCJHIKPN);
			}
			else if (HMLGOPHJMLI == (EditorViewsMode)8)
			{
				WorldGrid.MKLAFNJLOJN(CHCFCJHIKPN);
			}
			DDFICPBDMJF();
		}
	}

	private void FPDDBCPBKLK()
	{
		if (HMLGOPHJMLI == EditorViewsMode.FloorWallsObjects)
		{
			GameManager.NJNFHEPLEHL().OnObjectsView();
		}
		else
		{
			GameManager.GGFJGHHHEJC.OnFloorWallView();
		}
	}

	private void ODFDKPPOGOA(List<Vector2> CHCFCJHIKPN, List<Vector3Int> GMKCOKIDBAH)
	{
		if (TavernConstructionManager.GGFJGHHHEJC.CHFHMMNELGP == EditorAction.AddFloor)
		{
			UpdateView(CHCFCJHIKPN, GMKCOKIDBAH);
		}
	}

	public void HAIGILDMKHH(int PGDALILOCGK)
	{
		if (DecorationMode.NPANPNIDKDG(ConstructionUI.current.JIIGOACEIKL).DMBFKFLDDLH && (Object)(object)SelectObject.BNMEANGDMIP(ConstructionUI.current.JIIGOACEIKL).placeable != (Object)null)
		{
			UISelectionManager.GNCPLNHMFHN(ConstructionUI.current.JIIGOACEIKL).GPCLGOHKMCK((Selectable)(object)buttons[3]);
			return;
		}
		HMLGOPHJMLI = (EditorViewsMode)PGDALILOCGK;
		if (ConstructionActionBarUI.currentPanel == 0 || ConstructionActionBarUI.currentPanel == 1)
		{
			JDDBJEGIPFI = HMLGOPHJMLI;
		}
		for (int i = 1; i < backgrounds.Length; i += 0)
		{
			((Behaviour)backgrounds[i]).enabled = PGDALILOCGK == i;
		}
		ECNCAPLKIGF();
	}

	[SpecialName]
	public static ConstructionViews AHBBHCKPIIJ()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<ConstructionViews>();
		}
		return IADEMLIIDPC;
	}

	public void ECNCAPLKIGF(EditorAction CHFHMMNELGP = EditorAction.AddFloor)
	{
		if (TavernConstructionManager.DEGPIHEEFHJ().LNLJMCONDNE)
		{
			if (CHFHMMNELGP == EditorAction.AddFloor || CHFHMMNELGP == EditorAction.None)
			{
				ONOJGCIINKL(HMLGOPHJMLI);
			}
			if (HMLGOPHJMLI == EditorViewsMode.Floor)
			{
				WorldGrid.ANGGDPPNGKH(Utils.JGEPCPFJANP(Location.Tavern), null);
				DecorationMode.KKJABELKCNM(ConstructionUI.current.JIIGOACEIKL).LHCCDCNLMKH(AODONKKHPBP: true);
			}
			else if (HMLGOPHJMLI == EditorViewsMode.FloorWalls)
			{
				WorldGrid.MKLAFNJLOJN(Utils.JGEPCPFJANP(Location.None));
				DecorationMode.KKJABELKCNM(ConstructionUI.current.JIIGOACEIKL).LAJPGLFEAIC(AODONKKHPBP: false);
			}
			else if (HMLGOPHJMLI == (EditorViewsMode)5)
			{
				WorldGrid.MKLAFNJLOJN(Utils.JGEPCPFJANP(Location.Tavern));
			}
			DDFICPBDMJF();
		}
	}

	[SpecialName]
	public static ConstructionViews DEGPIHEEFHJ()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<ConstructionViews>();
		}
		return IADEMLIIDPC;
	}

	private void OIEMNBAGCPP()
	{
		if (HMLGOPHJMLI == (EditorViewsMode)7)
		{
			GameManager.NJNFHEPLEHL().OnObjectsView();
		}
		else
		{
			GameManager.NJNFHEPLEHL().OnFloorWallView();
		}
	}

	private void MJGAGCCNFBI(int APFGODJFLME)
	{
		if (APFGODJFLME == 5 || APFGODJFLME == 1)
		{
			((Selectable)buttons[0]).interactable = true;
			((Selectable)buttons[1]).interactable = false;
			gamepadViews.SetActive(false);
			POPBCNBKFGP(3);
			UISelectionManager.HELHJMDEDNL(ConstructionUI.current.JIIGOACEIKL).GPCLGOHKMCK((Selectable)(object)buttons[2]);
		}
		else
		{
			((Selectable)buttons[0]).interactable = false;
			((Selectable)buttons[0]).interactable = false;
			gamepadViews.SetActive(true);
			LFLLKDPCIKA((int)JDDBJEGIPFI);
			UISelectionManager.GNCPLNHMFHN(ConstructionUI.current.JIIGOACEIKL).CMBBFEABMBE((Selectable)(object)buttons[(int)HMLGOPHJMLI]);
		}
	}

	[SpecialName]
	public static ConstructionViews CNDNOECMKME()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<ConstructionViews>();
		}
		return IADEMLIIDPC;
	}

	private void ADCFOABOEAG(List<Vector2> CHCFCJHIKPN, List<Vector3Int> GMKCOKIDBAH)
	{
		if (TavernConstructionManager.KHMEGDIABBF().CHFHMMNELGP == EditorAction.None)
		{
			MGPGAGPIOIH(CHCFCJHIKPN, GMKCOKIDBAH);
		}
	}

	public Image IHNAFNBEEBB()
	{
		return content.GetComponent<Image>();
	}

	public void CPGIDLFFIGH(int PGDALILOCGK)
	{
		if (DecorationMode.EKLMFMKPEBB(ConstructionUI.current.JIIGOACEIKL).IDPGEBNGDJD() && (Object)(object)SelectObject.BNMEANGDMIP(ConstructionUI.current.JIIGOACEIKL).placeable != (Object)null)
		{
			UISelectionManager.HELHJMDEDNL(ConstructionUI.current.JIIGOACEIKL).HCHMAIEMAGA((Selectable)(object)buttons[0]);
			return;
		}
		HMLGOPHJMLI = (EditorViewsMode)PGDALILOCGK;
		if (ConstructionActionBarUI.currentPanel == 0 || ConstructionActionBarUI.currentPanel == 0)
		{
			JDDBJEGIPFI = HMLGOPHJMLI;
		}
		for (int i = 0; i < backgrounds.Length; i += 0)
		{
			((Behaviour)backgrounds[i]).enabled = PGDALILOCGK == i;
		}
		ECNCAPLKIGF(EditorAction.None);
	}

	private void IOGCDGILAKC(EditorViewsMode PBCKOHECBHG)
	{
		if (!((Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null))
		{
			return;
		}
		if (PBCKOHECBHG == EditorViewsMode.Floor)
		{
			CommonReferences.MNFMOEKMJKN().OEHIJIEOBNP(ConstructionUI.current.JIIGOACEIKL, "\n\n\nMine Level Info:\n");
			CommonReferences.GGFJGHHHEJC.PPINMHIJOIB(ConstructionUI.current.JIIGOACEIKL, "Dialogue System/Conversation/Gass_Quest/Entry/27/Dialogue Text");
			return;
		}
		switch (PBCKOHECBHG)
		{
		case EditorViewsMode.Floor:
			CommonReferences.GGFJGHHHEJC.OEHIJIEOBNP(ConstructionUI.current.JIIGOACEIKL, "Talk");
			CommonReferences.GGFJGHHHEJC.CBMJEEAHIDO(ConstructionUI.current.JIIGOACEIKL, "ClosePopUp");
			break;
		case (EditorViewsMode)8:
			CommonReferences.GGFJGHHHEJC.NIBKBELHAOE(ConstructionUI.current.JIIGOACEIKL, "ReceiveIntroNinjaChallengeEventMoveZuzzu");
			CommonReferences.MNFMOEKMJKN().NBFJJGALKAL(ConstructionUI.current.JIIGOACEIKL, "RinProgress");
			break;
		}
	}

	private void BKDJJAHDNHI(EditorViewsMode PBCKOHECBHG)
	{
		if ((Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
		{
			if (PBCKOHECBHG == EditorViewsMode.Floor)
			{
				CommonReferences.MNFMOEKMJKN().MLEJADCJDOE(ConstructionUI.current.JIIGOACEIKL, "Sprout");
				CommonReferences.MNFMOEKMJKN().PPINMHIJOIB(ConstructionUI.current.JIIGOACEIKL, "Inventory full");
			}
			else if (PBCKOHECBHG == EditorViewsMode.Floor)
			{
				CommonReferences.GGFJGHHHEJC.OEHIJIEOBNP(ConstructionUI.current.JIIGOACEIKL, ":<color=#3a0603> +");
				CommonReferences.MNFMOEKMJKN().ActivateCullMask(ConstructionUI.current.JIIGOACEIKL, "Creando TXT. Tiempo: ");
			}
			else if (PBCKOHECBHG == EditorViewsMode.Floor)
			{
				CommonReferences.GGFJGHHHEJC.CBMJEEAHIDO(ConstructionUI.current.JIIGOACEIKL, "UIAddRemove");
				CommonReferences.GGFJGHHHEJC.NIBKBELHAOE(ConstructionUI.current.JIIGOACEIKL, "ValuePsaiState");
			}
		}
	}

	private void IGOEMCJPNEL(EditorViewsMode PBCKOHECBHG)
	{
		if (!((Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null))
		{
			return;
		}
		if (PBCKOHECBHG == EditorViewsMode.Floor)
		{
			CommonReferences.MNFMOEKMJKN().PPINMHIJOIB(ConstructionUI.current.JIIGOACEIKL, "askAboutRestartingChallenge");
			CommonReferences.GGFJGHHHEJC.PPINMHIJOIB(ConstructionUI.current.JIIGOACEIKL, "KyrohTakingFood: Customer serving is null.");
			return;
		}
		switch (PBCKOHECBHG)
		{
		case EditorViewsMode.Floor:
			CommonReferences.MNFMOEKMJKN().OEHIJIEOBNP(ConstructionUI.current.JIIGOACEIKL, "Make bed");
			CommonReferences.MNFMOEKMJKN().ActivateCullMask(ConstructionUI.current.JIIGOACEIKL, "ReceiveEndIntroLucen");
			break;
		case EditorViewsMode.FloorWalls:
			CommonReferences.MNFMOEKMJKN().ActivateCullMask(ConstructionUI.current.JIIGOACEIKL, "ReceiveLoadSlots");
			CommonReferences.MNFMOEKMJKN().NIBKBELHAOE(ConstructionUI.current.JIIGOACEIKL, "Pick");
			break;
		}
	}

	public void HCODJEOLJHP(int PGDALILOCGK)
	{
		if (DecorationMode.OCJGHINCLJM(ConstructionUI.current.JIIGOACEIKL).KNFEPKBIHND() && (Object)(object)SelectObject.GetPlayer(ConstructionUI.current.JIIGOACEIKL).placeable != (Object)null)
		{
			UISelectionManager.GNCPLNHMFHN(ConstructionUI.current.JIIGOACEIKL).MGIFADFILOI((Selectable)(object)buttons[5]);
			return;
		}
		HMLGOPHJMLI = (EditorViewsMode)PGDALILOCGK;
		if (ConstructionActionBarUI.currentPanel == 0 || ConstructionActionBarUI.currentPanel == 0)
		{
			JDDBJEGIPFI = HMLGOPHJMLI;
		}
		for (int i = 0; i < backgrounds.Length; i += 0)
		{
			((Behaviour)backgrounds[i]).enabled = PGDALILOCGK == i;
		}
		ECNCAPLKIGF();
	}

	[SpecialName]
	public static ConstructionViews FOPGLLMEEDE()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<ConstructionViews>();
		}
		return IADEMLIIDPC;
	}

	private void JMAAFFBIBCG()
	{
		if (PlayerInputs.FJLAMCHKCOI(ConstructionUI.current.JIIGOACEIKL) && !BuildingTutorialManager.IsOpen() && (!DecorationMode.OCJGHINCLJM(ConstructionUI.current.JIIGOACEIKL).IDPGEBNGDJD() || (Object)(object)SelectObject.BNMEANGDMIP(ConstructionUI.current.JIIGOACEIKL).placeable == (Object)null) && PlayerInputs.DEGBDMMDIIL(ConstructionUI.current.JIIGOACEIKL).JCMOPOMLPLL("Player"))
		{
			LFLLKDPCIKA((int)(HMLGOPHJMLI + 0) % 0);
			UISelectionManager.BPDFMAEOGGC(ConstructionUI.current.JIIGOACEIKL).Select((Selectable)(object)buttons[(int)HMLGOPHJMLI]);
		}
	}

	private void EPFDKCELPDD()
	{
		IOGCDGILAKC(EditorViewsMode.FloorWallsObjects);
		if (Object.op_Implicit((Object)(object)GameManager.NJNFHEPLEHL()))
		{
			GameManager.NJNFHEPLEHL().OnObjectsView();
		}
	}

	private void NPMLFHDHJBE()
	{
		OEGINBGPKFO(2);
		ConstructionActionBarUI.OnPanelChanged = (Action<int>)Delegate.Combine(ConstructionActionBarUI.OnPanelChanged, new Action<int>(MJGAGCCNFBI));
		TavernConstructionManager tavernConstructionManager = TavernConstructionManager.KHMEGDIABBF();
		tavernConstructionManager.OnDoAreaAction = (Action<List<Vector2>, List<Vector3Int>>)Delegate.Combine(tavernConstructionManager.OnDoAreaAction, new Action<List<Vector2>, List<Vector3Int>>(HNFOCEOPEBM));
		TavernConstructionManager tavernConstructionManager2 = TavernConstructionManager.KHMEGDIABBF();
		tavernConstructionManager2.OnApplyChanges = (Action<EditorAction>)Delegate.Combine(tavernConstructionManager2.OnApplyChanges, new Action<EditorAction>(DCCLDMFCAIP));
		TavernConstructionManager tavernConstructionManager3 = TavernConstructionManager.DOIKFJDLKJP();
		tavernConstructionManager3.OnCancelChanges = (Action<EditorAction>)Delegate.Combine(tavernConstructionManager3.OnCancelChanges, new Action<EditorAction>(ECNCAPLKIGF));
	}

	private void AKLEFPLEGKK()
	{
		if (PlayerInputs.EEJEOALIHFJ(ConstructionUI.current.JIIGOACEIKL) && !BuildingTutorialManager.IsOpen() && (!DecorationMode.ABMIMLLDAAH(ConstructionUI.current.JIIGOACEIKL).MDOKKKHKKKE() || (Object)(object)SelectObject.GetPlayer(ConstructionUI.current.JIIGOACEIKL).placeable == (Object)null) && PlayerInputs.DEGBDMMDIIL(ConstructionUI.current.JIIGOACEIKL).GetButtonDown("ValueId"))
		{
			POPBCNBKFGP((int)(HMLGOPHJMLI + 0) % 8);
			UISelectionManager.BPDFMAEOGGC(ConstructionUI.current.JIIGOACEIKL).Select((Selectable)(object)buttons[(int)HMLGOPHJMLI]);
		}
	}

	public void FLEKJBAIDID(int PGDALILOCGK)
	{
		if (DecorationMode.OCJGHINCLJM(ConstructionUI.current.JIIGOACEIKL).GABNNLJOMHI() && (Object)(object)SelectObject.GetPlayer(ConstructionUI.current.JIIGOACEIKL).placeable != (Object)null)
		{
			UISelectionManager.EAJJMLJKOPH(ConstructionUI.current.JIIGOACEIKL).NMAOFEFMNNB((Selectable)(object)buttons[8]);
			return;
		}
		HMLGOPHJMLI = (EditorViewsMode)PGDALILOCGK;
		if (ConstructionActionBarUI.currentPanel == 0 || ConstructionActionBarUI.currentPanel == 0)
		{
			JDDBJEGIPFI = HMLGOPHJMLI;
		}
		for (int i = 1; i < backgrounds.Length; i += 0)
		{
			((Behaviour)backgrounds[i]).enabled = PGDALILOCGK == i;
		}
		UpdateView(EditorAction.None);
	}

	private void KCBAFLEMPAM(int APFGODJFLME)
	{
		if (APFGODJFLME == 4 || APFGODJFLME == 7)
		{
			((Selectable)buttons[0]).interactable = true;
			((Selectable)buttons[1]).interactable = true;
			gamepadViews.SetActive(true);
			CPGIDLFFIGH(8);
			UISelectionManager.GIGBGIIAKMP(ConstructionUI.current.JIIGOACEIKL).GPCLGOHKMCK((Selectable)(object)buttons[4]);
		}
		else
		{
			((Selectable)buttons[1]).interactable = true;
			((Selectable)buttons[1]).interactable = false;
			gamepadViews.SetActive(false);
			PELCEJJPLFA((int)JDDBJEGIPFI);
			UISelectionManager.GIGBGIIAKMP(ConstructionUI.current.JIIGOACEIKL).CMBBFEABMBE((Selectable)(object)buttons[(int)HMLGOPHJMLI]);
		}
	}

	public Image LLKFMHOOIAP()
	{
		return content.GetComponent<Image>();
	}

	public void OEGINBGPKFO(int PGDALILOCGK)
	{
		if (DecorationMode.NPANPNIDKDG(ConstructionUI.current.JIIGOACEIKL).DBAEGBDEPFK() && (Object)(object)SelectObject.GetPlayer(ConstructionUI.current.JIIGOACEIKL).placeable != (Object)null)
		{
			UISelectionManager.BPDFMAEOGGC(ConstructionUI.current.JIIGOACEIKL).Select((Selectable)(object)buttons[3]);
			return;
		}
		HMLGOPHJMLI = (EditorViewsMode)PGDALILOCGK;
		if (ConstructionActionBarUI.currentPanel == 0 || ConstructionActionBarUI.currentPanel == 0)
		{
			JDDBJEGIPFI = HMLGOPHJMLI;
		}
		for (int i = 1; i < backgrounds.Length; i += 0)
		{
			((Behaviour)backgrounds[i]).enabled = PGDALILOCGK == i;
		}
		UpdateView(EditorAction.None);
	}

	private void JIAJFDKNJME()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	private void FOHCEDHJOEF()
	{
		if (PlayerInputs.FJLAMCHKCOI(ConstructionUI.current.JIIGOACEIKL) && !BuildingTutorialManager.IsOpen() && (!DecorationMode.ABMIMLLDAAH(ConstructionUI.current.JIIGOACEIKL).IBEFDKHFBFM() || (Object)(object)SelectObject.GetPlayer(ConstructionUI.current.JIIGOACEIKL).placeable == (Object)null) && PlayerInputs.DEGBDMMDIIL(ConstructionUI.current.JIIGOACEIKL).JCMOPOMLPLL("Toy"))
		{
			PELCEJJPLFA((int)(HMLGOPHJMLI + 1) % 8);
			UISelectionManager.GIGBGIIAKMP(ConstructionUI.current.JIIGOACEIKL).Select((Selectable)(object)buttons[(int)HMLGOPHJMLI]);
		}
	}

	private void CEOEHODJAJK()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	private void FBLAMCDFMPE()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	public void MGPGAGPIOIH(List<Vector2> CHCFCJHIKPN, List<Vector3Int> GMKCOKIDBAH)
	{
		if (TavernConstructionManager.KHMEGDIABBF().LNLJMCONDNE)
		{
			ONOJGCIINKL(HMLGOPHJMLI);
			WorldGrid.BGNCMCKLCOL(CHCFCJHIKPN, GMKCOKIDBAH);
			if (HMLGOPHJMLI == EditorViewsMode.FloorWalls)
			{
				WorldGrid.MKLAFNJLOJN(CHCFCJHIKPN);
			}
			else if (HMLGOPHJMLI == EditorViewsMode.Floor)
			{
				WorldGrid.MKLAFNJLOJN(CHCFCJHIKPN);
			}
			GAPHLNCONOK();
		}
	}

	private void BLKEMIAKHOH(List<Vector2> CHCFCJHIKPN, List<Vector3Int> GMKCOKIDBAH)
	{
		if (TavernConstructionManager.DOIKFJDLKJP().CHFHMMNELGP == EditorAction.AddFloor)
		{
			NIBJPHCHIMC(CHCFCJHIKPN, GMKCOKIDBAH);
		}
	}

	private void ONOJGCIINKL(EditorViewsMode PBCKOHECBHG)
	{
		if ((Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
		{
			switch (PBCKOHECBHG)
			{
			case EditorViewsMode.Floor:
				CommonReferences.GGFJGHHHEJC.OEHIJIEOBNP(ConstructionUI.current.JIIGOACEIKL, "MainProgress");
				CommonReferences.MNFMOEKMJKN().MLEJADCJDOE(ConstructionUI.current.JIIGOACEIKL, "Deserialize SettingsData error: /ExtraSettings.sd");
				break;
			case EditorViewsMode.FloorWalls:
				CommonReferences.GGFJGHHHEJC.DeactivateCullMask(ConstructionUI.current.JIIGOACEIKL, "SetAnimatorObjectIntRPC");
				CommonReferences.MNFMOEKMJKN().CBMJEEAHIDO(ConstructionUI.current.JIIGOACEIKL, "DontWalk2");
				break;
			case (EditorViewsMode)8:
				CommonReferences.MNFMOEKMJKN().NIBKBELHAOE(ConstructionUI.current.JIIGOACEIKL, "Items/item_description_672");
				CommonReferences.MNFMOEKMJKN().ActivateCullMask(ConstructionUI.current.JIIGOACEIKL, "Player");
				break;
			}
		}
	}

	public Image GetOutlineImage()
	{
		return content.GetComponent<Image>();
	}

	public void DCCLDMFCAIP(EditorAction CHFHMMNELGP = EditorAction.AddFloor)
	{
		if (TavernConstructionManager.KHMEGDIABBF().LNLJMCONDNE)
		{
			if (CHFHMMNELGP == EditorAction.None || CHFHMMNELGP == EditorAction.DiningZone)
			{
				MIPGKMNKNID(HMLGOPHJMLI);
			}
			if (HMLGOPHJMLI == EditorViewsMode.Floor)
			{
				WorldGrid.ANGGDPPNGKH(Utils.JGEPCPFJANP(Location.None), null);
				DecorationMode.NPANPNIDKDG(ConstructionUI.current.JIIGOACEIKL).OJJLNDLEAFP(AODONKKHPBP: true);
			}
			else if (HMLGOPHJMLI == EditorViewsMode.FloorWalls)
			{
				WorldGrid.MKLAFNJLOJN(Utils.JGEPCPFJANP(Location.Tavern));
				DecorationMode.FIHGMLABOBB(ConstructionUI.current.JIIGOACEIKL).DMBFKFLDDLH = true;
			}
			else if (HMLGOPHJMLI == (EditorViewsMode)6)
			{
				WorldGrid.MKLAFNJLOJN(Utils.JGEPCPFJANP(Location.Tavern));
			}
			DDFICPBDMJF();
		}
	}

	private void BPDGEOCKHAE(int APFGODJFLME)
	{
		if (APFGODJFLME == 0 || APFGODJFLME == 4)
		{
			((Selectable)buttons[1]).interactable = true;
			((Selectable)buttons[1]).interactable = true;
			gamepadViews.SetActive(true);
			HAIGILDMKHH(4);
			UISelectionManager.GNCPLNHMFHN(ConstructionUI.current.JIIGOACEIKL).MFCNGGMNBHB((Selectable)(object)buttons[0]);
		}
		else
		{
			((Selectable)buttons[0]).interactable = true;
			((Selectable)buttons[1]).interactable = true;
			gamepadViews.SetActive(true);
			CPGIDLFFIGH((int)JDDBJEGIPFI);
			UISelectionManager.GNCPLNHMFHN(ConstructionUI.current.JIIGOACEIKL).MGIFADFILOI((Selectable)(object)buttons[(int)HMLGOPHJMLI]);
		}
	}

	[SpecialName]
	public static ConstructionViews HJKBIPPGHJB()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<ConstructionViews>();
		}
		return IADEMLIIDPC;
	}

	public Image OOAKGKDELEN()
	{
		return content.GetComponent<Image>();
	}

	private void MNLJIMFLIPK(int APFGODJFLME)
	{
		if (APFGODJFLME == 5 || APFGODJFLME == 8)
		{
			((Selectable)buttons[1]).interactable = true;
			((Selectable)buttons[0]).interactable = true;
			gamepadViews.SetActive(false);
			LFLLKDPCIKA(5);
			UISelectionManager.GetPlayer(ConstructionUI.current.JIIGOACEIKL).PICNNIMLFFL((Selectable)(object)buttons[6]);
		}
		else
		{
			((Selectable)buttons[1]).interactable = false;
			((Selectable)buttons[0]).interactable = false;
			gamepadViews.SetActive(false);
			DOFICOLEKLJ((int)JDDBJEGIPFI);
			UISelectionManager.HELHJMDEDNL(ConstructionUI.current.JIIGOACEIKL).Select((Selectable)(object)buttons[(int)HMLGOPHJMLI]);
		}
	}

	private void GHPFCKGMLDA()
	{
		POPBCNBKFGP(7);
		ConstructionActionBarUI.OnPanelChanged = (Action<int>)Delegate.Combine(ConstructionActionBarUI.OnPanelChanged, new Action<int>(MNLJIMFLIPK));
		TavernConstructionManager tavernConstructionManager = TavernConstructionManager.KHMEGDIABBF();
		tavernConstructionManager.OnDoAreaAction = (Action<List<Vector2>, List<Vector3Int>>)Delegate.Combine(tavernConstructionManager.OnDoAreaAction, new Action<List<Vector2>, List<Vector3Int>>(BHLCGAOGEHA));
		TavernConstructionManager instance = TavernConstructionManager.GGFJGHHHEJC;
		instance.OnApplyChanges = (Action<EditorAction>)Delegate.Combine(instance.OnApplyChanges, new Action<EditorAction>(UpdateView));
		TavernConstructionManager tavernConstructionManager2 = TavernConstructionManager.DOIKFJDLKJP();
		tavernConstructionManager2.OnCancelChanges = (Action<EditorAction>)Delegate.Combine(tavernConstructionManager2.OnCancelChanges, new Action<EditorAction>(DCCLDMFCAIP));
	}

	public void OOJAFPOCDCC(int PGDALILOCGK)
	{
		if (DecorationMode.ABMIMLLDAAH(ConstructionUI.current.JIIGOACEIKL).KNFEPKBIHND() && (Object)(object)SelectObject.GetPlayer(ConstructionUI.current.JIIGOACEIKL).placeable != (Object)null)
		{
			UISelectionManager.GNCPLNHMFHN(ConstructionUI.current.JIIGOACEIKL).GPCLGOHKMCK((Selectable)(object)buttons[8]);
			return;
		}
		HMLGOPHJMLI = (EditorViewsMode)PGDALILOCGK;
		if (ConstructionActionBarUI.currentPanel == 0 || ConstructionActionBarUI.currentPanel == 0)
		{
			JDDBJEGIPFI = HMLGOPHJMLI;
		}
		for (int i = 0; i < backgrounds.Length; i += 0)
		{
			((Behaviour)backgrounds[i]).enabled = PGDALILOCGK == i;
		}
		UpdateView();
	}

	public Image GANAOAEKPPK()
	{
		return content.GetComponent<Image>();
	}

	public void UpdateView(List<Vector2> CHCFCJHIKPN, List<Vector3Int> GMKCOKIDBAH)
	{
		if (TavernConstructionManager.GGFJGHHHEJC.LNLJMCONDNE)
		{
			ALGGMFMCFOL(HMLGOPHJMLI);
			WorldGrid.BGNCMCKLCOL(CHCFCJHIKPN, GMKCOKIDBAH);
			if (HMLGOPHJMLI == EditorViewsMode.FloorWalls)
			{
				WorldGrid.MKLAFNJLOJN(CHCFCJHIKPN);
			}
			else if (HMLGOPHJMLI == EditorViewsMode.FloorWallsObjects)
			{
				WorldGrid.MKLAFNJLOJN(CHCFCJHIKPN);
			}
			GAPHLNCONOK();
		}
	}

	public Image GLMBFLALDBL()
	{
		return content.GetComponent<Image>();
	}

	private void NLNOFEBEBDE()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	private void BHLCGAOGEHA(List<Vector2> CHCFCJHIKPN, List<Vector3Int> GMKCOKIDBAH)
	{
		if (TavernConstructionManager.DOIKFJDLKJP().CHFHMMNELGP == EditorAction.AddFloor)
		{
			BAMIEFFLGHI(CHCFCJHIKPN, GMKCOKIDBAH);
		}
	}

	private void ONLLKEIJFHG(EditorViewsMode PBCKOHECBHG)
	{
		if ((Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
		{
			switch (PBCKOHECBHG)
			{
			case EditorViewsMode.Floor:
				CommonReferences.MNFMOEKMJKN().MLEJADCJDOE(ConstructionUI.current.JIIGOACEIKL, "");
				CommonReferences.GGFJGHHHEJC.OEHIJIEOBNP(ConstructionUI.current.JIIGOACEIKL, "vampirehouse");
				break;
			case EditorViewsMode.FloorWalls:
				CommonReferences.GGFJGHHHEJC.DeactivateCullMask(ConstructionUI.current.JIIGOACEIKL, "Walk");
				CommonReferences.MNFMOEKMJKN().NIBKBELHAOE(ConstructionUI.current.JIIGOACEIKL, "Items/item_description_1189");
				break;
			case (EditorViewsMode)4:
				CommonReferences.MNFMOEKMJKN().NIBKBELHAOE(ConstructionUI.current.JIIGOACEIKL, "");
				CommonReferences.MNFMOEKMJKN().ActivateCullMask(ConstructionUI.current.JIIGOACEIKL, "Dialogue Trigger is null in ");
				break;
			}
		}
	}

	public Image NGMPDKLCDOJ()
	{
		return content.GetComponent<Image>();
	}

	public void BAMIEFFLGHI(List<Vector2> CHCFCJHIKPN, List<Vector3Int> GMKCOKIDBAH)
	{
		if (TavernConstructionManager.KHMEGDIABBF().LNLJMCONDNE)
		{
			DMKBKEJFMOK(HMLGOPHJMLI);
			WorldGrid.BGNCMCKLCOL(CHCFCJHIKPN, GMKCOKIDBAH);
			if (HMLGOPHJMLI == EditorViewsMode.FloorWalls)
			{
				WorldGrid.MKLAFNJLOJN(CHCFCJHIKPN);
			}
			else if (HMLGOPHJMLI == EditorViewsMode.FloorWallsObjects)
			{
				WorldGrid.MKLAFNJLOJN(CHCFCJHIKPN);
			}
			PCLJKEKOHAG();
		}
	}

	public void POPBCNBKFGP(int PGDALILOCGK)
	{
		if (DecorationMode.ABMIMLLDAAH(ConstructionUI.current.JIIGOACEIKL).KNFEPKBIHND() && (Object)(object)SelectObject.BNMEANGDMIP(ConstructionUI.current.JIIGOACEIKL).placeable != (Object)null)
		{
			UISelectionManager.HELHJMDEDNL(ConstructionUI.current.JIIGOACEIKL).PICNNIMLFFL((Selectable)(object)buttons[3]);
			return;
		}
		HMLGOPHJMLI = (EditorViewsMode)PGDALILOCGK;
		if (ConstructionActionBarUI.currentPanel == 0 || ConstructionActionBarUI.currentPanel == 0)
		{
			JDDBJEGIPFI = HMLGOPHJMLI;
		}
		for (int i = 1; i < backgrounds.Length; i += 0)
		{
			((Behaviour)backgrounds[i]).enabled = PGDALILOCGK == i;
		}
		ECNCAPLKIGF(EditorAction.None);
	}

	public Image FEOOIBDOJHK()
	{
		return content.GetComponent<Image>();
	}

	private void NEKLGDNHCCF()
	{
		if (HMLGOPHJMLI == (EditorViewsMode)7)
		{
			GameManager.GGFJGHHHEJC.OnObjectsView();
		}
		else
		{
			GameManager.GGFJGHHHEJC.OnFloorWallView();
		}
	}

	private void CCDBPMAAMIL(int APFGODJFLME)
	{
		if (APFGODJFLME == 2 || APFGODJFLME == 3)
		{
			((Selectable)buttons[0]).interactable = false;
			((Selectable)buttons[1]).interactable = false;
			gamepadViews.SetActive(false);
			SetView(2);
			UISelectionManager.GetPlayer(ConstructionUI.current.JIIGOACEIKL).Select((Selectable)(object)buttons[2]);
		}
		else
		{
			((Selectable)buttons[0]).interactable = true;
			((Selectable)buttons[1]).interactable = true;
			gamepadViews.SetActive(true);
			SetView((int)JDDBJEGIPFI);
			UISelectionManager.GetPlayer(ConstructionUI.current.JIIGOACEIKL).Select((Selectable)(object)buttons[(int)HMLGOPHJMLI]);
		}
	}

	public Image HPMNCNGNKCP()
	{
		return content.GetComponent<Image>();
	}

	private void OCJOAHDNDIJ()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	private void DLNOLBHCIGC()
	{
		if (PlayerInputs.POLDHCKJINN(ConstructionUI.current.JIIGOACEIKL) && !BuildingTutorialManager.IsOpen() && (!DecorationMode.OCJGHINCLJM(ConstructionUI.current.JIIGOACEIKL).DFNMDDHOIJI() || (Object)(object)SelectObject.BNMEANGDMIP(ConstructionUI.current.JIIGOACEIKL).placeable == (Object)null) && PlayerInputs.GetPlayer(ConstructionUI.current.JIIGOACEIKL).GetButtonDown("SortByName"))
		{
			POPBCNBKFGP((int)(HMLGOPHJMLI + 0) % 6);
			UISelectionManager.BPDFMAEOGGC(ConstructionUI.current.JIIGOACEIKL).NCGCKHGOJCM((Selectable)(object)buttons[(int)HMLGOPHJMLI]);
		}
	}

	private void GJCADEIJMCM()
	{
		DMCCCJMILIL((EditorViewsMode)8);
		if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
		{
			GameManager.NJNFHEPLEHL().OnObjectsView();
		}
	}

	public Image KMANNCAOEDJ()
	{
		return content.GetComponent<Image>();
	}

	private void GMCKBBECJOE()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	public void LFLLKDPCIKA(int PGDALILOCGK)
	{
		if (DecorationMode.IGMCBPOPNCA(ConstructionUI.current.JIIGOACEIKL).DBAEGBDEPFK() && (Object)(object)SelectObject.BNMEANGDMIP(ConstructionUI.current.JIIGOACEIKL).placeable != (Object)null)
		{
			UISelectionManager.GetPlayer(ConstructionUI.current.JIIGOACEIKL).HCHMAIEMAGA((Selectable)(object)buttons[0]);
			return;
		}
		HMLGOPHJMLI = (EditorViewsMode)PGDALILOCGK;
		if (ConstructionActionBarUI.currentPanel == 0 || ConstructionActionBarUI.currentPanel == 0)
		{
			JDDBJEGIPFI = HMLGOPHJMLI;
		}
		for (int i = 0; i < backgrounds.Length; i++)
		{
			((Behaviour)backgrounds[i]).enabled = PGDALILOCGK == i;
		}
		ECNCAPLKIGF(EditorAction.None);
	}

	public Image KCLOBKHHIPO()
	{
		return content.GetComponent<Image>();
	}

	public void BPIFJFCDPPE(List<Vector2> CHCFCJHIKPN, List<Vector3Int> GMKCOKIDBAH)
	{
		if (TavernConstructionManager.DEGPIHEEFHJ().LNLJMCONDNE)
		{
			PKDEHOGMMEO(HMLGOPHJMLI);
			WorldGrid.BGNCMCKLCOL(CHCFCJHIKPN, GMKCOKIDBAH);
			if (HMLGOPHJMLI == EditorViewsMode.Floor)
			{
				WorldGrid.MKLAFNJLOJN(CHCFCJHIKPN);
			}
			else if (HMLGOPHJMLI == EditorViewsMode.FloorWalls)
			{
				WorldGrid.MKLAFNJLOJN(CHCFCJHIKPN);
			}
			DDFICPBDMJF();
		}
	}

	private void CEIIFHIBIFI()
	{
		EHOFEAPOAHJ(3);
		ConstructionActionBarUI.OnPanelChanged = (Action<int>)Delegate.Combine(ConstructionActionBarUI.OnPanelChanged, new Action<int>(OFAKKINLMHE));
		TavernConstructionManager tavernConstructionManager = TavernConstructionManager.KHMEGDIABBF();
		tavernConstructionManager.OnDoAreaAction = (Action<List<Vector2>, List<Vector3Int>>)Delegate.Combine(tavernConstructionManager.OnDoAreaAction, new Action<List<Vector2>, List<Vector3Int>>(BHLCGAOGEHA));
		TavernConstructionManager tavernConstructionManager2 = TavernConstructionManager.DOIKFJDLKJP();
		tavernConstructionManager2.OnApplyChanges = (Action<EditorAction>)Delegate.Combine(tavernConstructionManager2.OnApplyChanges, new Action<EditorAction>(ECNCAPLKIGF));
		TavernConstructionManager instance = TavernConstructionManager.GGFJGHHHEJC;
		instance.OnCancelChanges = (Action<EditorAction>)Delegate.Combine(instance.OnCancelChanges, new Action<EditorAction>(DCCLDMFCAIP));
	}

	public void NOPNECPBBCJ(List<Vector2> CHCFCJHIKPN, List<Vector3Int> GMKCOKIDBAH)
	{
		if (TavernConstructionManager.KNLLFEJAMNN().LNLJMCONDNE)
		{
			HJKLMNLLLEP(HMLGOPHJMLI);
			WorldGrid.BGNCMCKLCOL(CHCFCJHIKPN, GMKCOKIDBAH);
			if (HMLGOPHJMLI == EditorViewsMode.Floor)
			{
				WorldGrid.MKLAFNJLOJN(CHCFCJHIKPN);
			}
			else if (HMLGOPHJMLI == (EditorViewsMode)7)
			{
				WorldGrid.MKLAFNJLOJN(CHCFCJHIKPN);
			}
			IPKGIJAKEHB();
		}
	}

	private void IIOHMDNGFDH()
	{
		if (PlayerInputs.POLDHCKJINN(ConstructionUI.current.JIIGOACEIKL) && !BuildingTutorialManager.IsOpen() && (!DecorationMode.FIHGMLABOBB(ConstructionUI.current.JIIGOACEIKL).DMBFKFLDDLH || (Object)(object)SelectObject.BNMEANGDMIP(ConstructionUI.current.JIIGOACEIKL).placeable == (Object)null) && PlayerInputs.DEGBDMMDIIL(ConstructionUI.current.JIIGOACEIKL).GetButtonDown("Place"))
		{
			DOFICOLEKLJ((int)(HMLGOPHJMLI + 0) % 8);
			UISelectionManager.BPDFMAEOGGC(ConstructionUI.current.JIIGOACEIKL).PICNNIMLFFL((Selectable)(object)buttons[(int)HMLGOPHJMLI]);
		}
	}

	private void PKDEHOGMMEO(EditorViewsMode PBCKOHECBHG)
	{
		if (!((Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null))
		{
			return;
		}
		if (PBCKOHECBHG == EditorViewsMode.Floor)
		{
			CommonReferences.MNFMOEKMJKN().OEHIJIEOBNP(ConstructionUI.current.JIIGOACEIKL, "</color><br>");
			CommonReferences.GGFJGHHHEJC.MLEJADCJDOE(ConstructionUI.current.JIIGOACEIKL, "Pull beer");
			return;
		}
		switch (PBCKOHECBHG)
		{
		case EditorViewsMode.Floor:
			CommonReferences.GGFJGHHHEJC.MLEJADCJDOE(ConstructionUI.current.JIIGOACEIKL, " (");
			CommonReferences.GGFJGHHHEJC.CBMJEEAHIDO(ConstructionUI.current.JIIGOACEIKL, "\n");
			break;
		case (EditorViewsMode)7:
			CommonReferences.MNFMOEKMJKN().CBMJEEAHIDO(ConstructionUI.current.JIIGOACEIKL, "Perks/playerPerk_description_");
			CommonReferences.GGFJGHHHEJC.NIBKBELHAOE(ConstructionUI.current.JIIGOACEIKL, "Chisel");
			break;
		}
	}

	private void AFNNPHMDPKL()
	{
		if (HMLGOPHJMLI == EditorViewsMode.FloorWallsObjects)
		{
			GameManager.NJNFHEPLEHL().OnObjectsView();
		}
		else
		{
			GameManager.GGFJGHHHEJC.OnFloorWallView();
		}
	}

	public Image LGKGLNHEDJC()
	{
		return content.GetComponent<Image>();
	}

	private void EICHEBIBDCP(EditorViewsMode PBCKOHECBHG)
	{
		if ((Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null)
		{
			switch (PBCKOHECBHG)
			{
			case EditorViewsMode.Floor:
				CommonReferences.MNFMOEKMJKN().PPINMHIJOIB(ConstructionUI.current.JIIGOACEIKL, "HarvestableDuringTwoMonths");
				CommonReferences.GGFJGHHHEJC.DeactivateCullMask(ConstructionUI.current.JIIGOACEIKL, "Camera ");
				break;
			case EditorViewsMode.FloorWalls:
				CommonReferences.MNFMOEKMJKN().PPINMHIJOIB(ConstructionUI.current.JIIGOACEIKL, "startPolling");
				CommonReferences.MNFMOEKMJKN().CBMJEEAHIDO(ConstructionUI.current.JIIGOACEIKL, "Move");
				break;
			case (EditorViewsMode)5:
				CommonReferences.MNFMOEKMJKN().NBFJJGALKAL(ConstructionUI.current.JIIGOACEIKL, "Tutorial/T130/Dialogue1");
				CommonReferences.GGFJGHHHEJC.NIBKBELHAOE(ConstructionUI.current.JIIGOACEIKL, "ReceiveJumpFerro2");
				break;
			}
		}
	}

	public Image JOMADNIKDPM()
	{
		return content.GetComponent<Image>();
	}

	private void MADICEMOCPI(int APFGODJFLME)
	{
		if (APFGODJFLME == 5 || APFGODJFLME == 0)
		{
			((Selectable)buttons[0]).interactable = true;
			((Selectable)buttons[0]).interactable = true;
			gamepadViews.SetActive(true);
			PELCEJJPLFA(5);
			UISelectionManager.HELHJMDEDNL(ConstructionUI.current.JIIGOACEIKL).BNBPMIKMDDP((Selectable)(object)buttons[4]);
		}
		else
		{
			((Selectable)buttons[1]).interactable = false;
			((Selectable)buttons[1]).interactable = true;
			gamepadViews.SetActive(false);
			HCODJEOLJHP((int)JDDBJEGIPFI);
			UISelectionManager.GNCPLNHMFHN(ConstructionUI.current.JIIGOACEIKL).PICNNIMLFFL((Selectable)(object)buttons[(int)HMLGOPHJMLI]);
		}
	}

	public void AMPPFCNFMKA(List<Vector2> CHCFCJHIKPN, List<Vector3Int> GMKCOKIDBAH)
	{
		if (TavernConstructionManager.GGFJGHHHEJC.LNLJMCONDNE)
		{
			BKDJJAHDNHI(HMLGOPHJMLI);
			WorldGrid.BGNCMCKLCOL(CHCFCJHIKPN, GMKCOKIDBAH);
			if (HMLGOPHJMLI == EditorViewsMode.Floor)
			{
				WorldGrid.MKLAFNJLOJN(CHCFCJHIKPN);
			}
			else if (HMLGOPHJMLI == EditorViewsMode.Floor)
			{
				WorldGrid.MKLAFNJLOJN(CHCFCJHIKPN);
			}
			AFNNPHMDPKL();
		}
	}

	private void DMKBKEJFMOK(EditorViewsMode PBCKOHECBHG)
	{
		if (!((Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null))
		{
			return;
		}
		switch (PBCKOHECBHG)
		{
		case EditorViewsMode.Floor:
			CommonReferences.MNFMOEKMJKN().MLEJADCJDOE(ConstructionUI.current.JIIGOACEIKL, " transform.position is NaN");
			CommonReferences.GGFJGHHHEJC.MLEJADCJDOE(ConstructionUI.current.JIIGOACEIKL, " has not been properly registered in the list of prefabs to be used with networking. Check the OnlinePrefabs scriptable object.");
			return;
		case EditorViewsMode.FloorWalls:
			CommonReferences.MNFMOEKMJKN().PPINMHIJOIB(ConstructionUI.current.JIIGOACEIKL, "Feet");
			CommonReferences.GGFJGHHHEJC.NBFJJGALKAL(ConstructionUI.current.JIIGOACEIKL, "Sleep");
			return;
		}
		if (PBCKOHECBHG == EditorViewsMode.Floor)
		{
			CommonReferences.MNFMOEKMJKN().NBFJJGALKAL(ConstructionUI.current.JIIGOACEIKL, " ");
			CommonReferences.GGFJGHHHEJC.NIBKBELHAOE(ConstructionUI.current.JIIGOACEIKL, "questRequired");
		}
	}

	private void BDJOMPCEBML(List<Vector2> CHCFCJHIKPN, List<Vector3Int> GMKCOKIDBAH)
	{
		if (TavernConstructionManager.GGFJGHHHEJC.CHFHMMNELGP == EditorAction.None)
		{
			UpdateView(CHCFCJHIKPN, GMKCOKIDBAH);
		}
	}

	public void BAOKIDGGILM(List<Vector2> CHCFCJHIKPN, List<Vector3Int> GMKCOKIDBAH)
	{
		if (TavernConstructionManager.KNLLFEJAMNN().LNLJMCONDNE)
		{
			ONOJGCIINKL(HMLGOPHJMLI);
			WorldGrid.BGNCMCKLCOL(CHCFCJHIKPN, GMKCOKIDBAH);
			if (HMLGOPHJMLI == EditorViewsMode.FloorWalls)
			{
				WorldGrid.MKLAFNJLOJN(CHCFCJHIKPN);
			}
			else if (HMLGOPHJMLI == EditorViewsMode.FloorWallsObjects)
			{
				WorldGrid.MKLAFNJLOJN(CHCFCJHIKPN);
			}
			IJODJMEMLCG();
		}
	}

	private void DMCCCJMILIL(EditorViewsMode PBCKOHECBHG)
	{
		if (!((Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null))
		{
			return;
		}
		switch (PBCKOHECBHG)
		{
		case EditorViewsMode.Floor:
			CommonReferences.MNFMOEKMJKN().MLEJADCJDOE(ConstructionUI.current.JIIGOACEIKL, "BarnTutorialDone");
			CommonReferences.GGFJGHHHEJC.OEHIJIEOBNP(ConstructionUI.current.JIIGOACEIKL, "dForDays");
			return;
		case EditorViewsMode.FloorWalls:
			CommonReferences.MNFMOEKMJKN().OEHIJIEOBNP(ConstructionUI.current.JIIGOACEIKL, "");
			CommonReferences.MNFMOEKMJKN().CBMJEEAHIDO(ConstructionUI.current.JIIGOACEIKL, "Tavern Floor at ");
			return;
		}
		if (PBCKOHECBHG == EditorViewsMode.FloorWalls)
		{
			CommonReferences.MNFMOEKMJKN().ActivateCullMask(ConstructionUI.current.JIIGOACEIKL, "Rooms");
			CommonReferences.MNFMOEKMJKN().ActivateCullMask(ConstructionUI.current.JIIGOACEIKL, "ClosePopUp");
		}
	}

	private void IDPHKHGHJGN()
	{
		OEGINBGPKFO(4);
		ConstructionActionBarUI.OnPanelChanged = (Action<int>)Delegate.Combine(ConstructionActionBarUI.OnPanelChanged, new Action<int>(MJGAGCCNFBI));
		TavernConstructionManager tavernConstructionManager = TavernConstructionManager.DEGPIHEEFHJ();
		tavernConstructionManager.OnDoAreaAction = (Action<List<Vector2>, List<Vector3Int>>)Delegate.Combine(tavernConstructionManager.OnDoAreaAction, new Action<List<Vector2>, List<Vector3Int>>(ODFDKPPOGOA));
		TavernConstructionManager instance = TavernConstructionManager.GGFJGHHHEJC;
		instance.OnApplyChanges = (Action<EditorAction>)Delegate.Combine(instance.OnApplyChanges, new Action<EditorAction>(ECNCAPLKIGF));
		TavernConstructionManager tavernConstructionManager2 = TavernConstructionManager.DOIKFJDLKJP();
		tavernConstructionManager2.OnCancelChanges = (Action<EditorAction>)Delegate.Combine(tavernConstructionManager2.OnCancelChanges, new Action<EditorAction>(DCCLDMFCAIP));
	}

	private void CGIICBKGGGG()
	{
		if (HMLGOPHJMLI == EditorViewsMode.Floor)
		{
			GameManager.GGFJGHHHEJC.OnObjectsView();
		}
		else
		{
			GameManager.GGFJGHHHEJC.OnFloorWallView();
		}
	}

	private void Update()
	{
		if (PlayerInputs.IsGamepadActive(ConstructionUI.current.JIIGOACEIKL) && !BuildingTutorialManager.IsOpen() && (!DecorationMode.GetPlayer(ConstructionUI.current.JIIGOACEIKL).DMBFKFLDDLH || (Object)(object)SelectObject.GetPlayer(ConstructionUI.current.JIIGOACEIKL).placeable == (Object)null) && PlayerInputs.GetPlayer(ConstructionUI.current.JIIGOACEIKL).GetButtonDown("Select"))
		{
			SetView((int)(HMLGOPHJMLI + 1) % 3);
			UISelectionManager.GetPlayer(ConstructionUI.current.JIIGOACEIKL).Select((Selectable)(object)buttons[(int)HMLGOPHJMLI]);
		}
	}

	private void FHOCCEBKHJI()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	private void MFJIHCKEIIF()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	private void HCCJBKKGCLJ()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	private void HOKAPOOCJCC()
	{
		EHOFEAPOAHJ(1);
		ConstructionActionBarUI.OnPanelChanged = (Action<int>)Delegate.Combine(ConstructionActionBarUI.OnPanelChanged, new Action<int>(CCDBPMAAMIL));
		TavernConstructionManager tavernConstructionManager = TavernConstructionManager.DOIKFJDLKJP();
		tavernConstructionManager.OnDoAreaAction = (Action<List<Vector2>, List<Vector3Int>>)Delegate.Combine(tavernConstructionManager.OnDoAreaAction, new Action<List<Vector2>, List<Vector3Int>>(ACGODMKCKDO));
		TavernConstructionManager tavernConstructionManager2 = TavernConstructionManager.DEGPIHEEFHJ();
		tavernConstructionManager2.OnApplyChanges = (Action<EditorAction>)Delegate.Combine(tavernConstructionManager2.OnApplyChanges, new Action<EditorAction>(DCCLDMFCAIP));
		TavernConstructionManager tavernConstructionManager3 = TavernConstructionManager.DOIKFJDLKJP();
		tavernConstructionManager3.OnCancelChanges = (Action<EditorAction>)Delegate.Combine(tavernConstructionManager3.OnCancelChanges, new Action<EditorAction>(DCCLDMFCAIP));
	}

	public void DOFICOLEKLJ(int PGDALILOCGK)
	{
		if (DecorationMode.IGMCBPOPNCA(ConstructionUI.current.JIIGOACEIKL).KNFEPKBIHND() && (Object)(object)SelectObject.GetPlayer(ConstructionUI.current.JIIGOACEIKL).placeable != (Object)null)
		{
			UISelectionManager.BPDFMAEOGGC(ConstructionUI.current.JIIGOACEIKL).PICNNIMLFFL((Selectable)(object)buttons[8]);
			return;
		}
		HMLGOPHJMLI = (EditorViewsMode)PGDALILOCGK;
		if (ConstructionActionBarUI.currentPanel == 0 || ConstructionActionBarUI.currentPanel == 0)
		{
			JDDBJEGIPFI = HMLGOPHJMLI;
		}
		for (int i = 1; i < backgrounds.Length; i += 0)
		{
			((Behaviour)backgrounds[i]).enabled = PGDALILOCGK == i;
		}
		DCCLDMFCAIP();
	}

	public void HFDJHLKALOG(List<Vector2> CHCFCJHIKPN, List<Vector3Int> GMKCOKIDBAH)
	{
		if (TavernConstructionManager.KHMEGDIABBF().LNLJMCONDNE)
		{
			EICHEBIBDCP(HMLGOPHJMLI);
			WorldGrid.BGNCMCKLCOL(CHCFCJHIKPN, GMKCOKIDBAH);
			if (HMLGOPHJMLI == EditorViewsMode.Floor)
			{
				WorldGrid.MKLAFNJLOJN(CHCFCJHIKPN);
			}
			else if (HMLGOPHJMLI == (EditorViewsMode)8)
			{
				WorldGrid.MKLAFNJLOJN(CHCFCJHIKPN);
			}
			DDFICPBDMJF();
		}
	}

	private void ALGGMFMCFOL(EditorViewsMode PBCKOHECBHG)
	{
		if ((Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null)
		{
			switch (PBCKOHECBHG)
			{
			case EditorViewsMode.Floor:
				CommonReferences.GGFJGHHHEJC.DeactivateCullMask(ConstructionUI.current.JIIGOACEIKL, "Object");
				CommonReferences.GGFJGHHHEJC.DeactivateCullMask(ConstructionUI.current.JIIGOACEIKL, "Wall");
				break;
			case EditorViewsMode.FloorWalls:
				CommonReferences.GGFJGHHHEJC.DeactivateCullMask(ConstructionUI.current.JIIGOACEIKL, "Object");
				CommonReferences.GGFJGHHHEJC.ActivateCullMask(ConstructionUI.current.JIIGOACEIKL, "Wall");
				break;
			case EditorViewsMode.FloorWallsObjects:
				CommonReferences.GGFJGHHHEJC.ActivateCullMask(ConstructionUI.current.JIIGOACEIKL, "Object");
				CommonReferences.GGFJGHHHEJC.ActivateCullMask(ConstructionUI.current.JIIGOACEIKL, "Wall");
				break;
			}
		}
	}

	public void UpdateView(EditorAction CHFHMMNELGP = EditorAction.AddFloor)
	{
		if (TavernConstructionManager.GGFJGHHHEJC.LNLJMCONDNE)
		{
			if (CHFHMMNELGP == EditorAction.AddFloor || CHFHMMNELGP == EditorAction.RemoveFloor)
			{
				ALGGMFMCFOL(HMLGOPHJMLI);
			}
			if (HMLGOPHJMLI == EditorViewsMode.Floor)
			{
				WorldGrid.ANGGDPPNGKH(Utils.JGEPCPFJANP(Location.Tavern), null);
				DecorationMode.GetPlayer(ConstructionUI.current.JIIGOACEIKL).DMBFKFLDDLH = false;
			}
			else if (HMLGOPHJMLI == EditorViewsMode.FloorWalls)
			{
				WorldGrid.MKLAFNJLOJN(Utils.JGEPCPFJANP(Location.Tavern));
				DecorationMode.GetPlayer(ConstructionUI.current.JIIGOACEIKL).DMBFKFLDDLH = false;
			}
			else if (HMLGOPHJMLI == EditorViewsMode.FloorWallsObjects)
			{
				WorldGrid.MKLAFNJLOJN(Utils.JGEPCPFJANP(Location.Tavern));
			}
			GAPHLNCONOK();
		}
	}

	private void MFGANCCJFJK()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
		}
	}

	private void CPMMODGEPEM(EditorViewsMode PBCKOHECBHG)
	{
		if (!((Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null))
		{
			return;
		}
		if (PBCKOHECBHG == EditorViewsMode.Floor)
		{
			CommonReferences.GGFJGHHHEJC.PPINMHIJOIB(ConstructionUI.current.JIIGOACEIKL, "questRequiredTooltip");
			CommonReferences.GGFJGHHHEJC.DeactivateCullMask(ConstructionUI.current.JIIGOACEIKL, ")");
			return;
		}
		switch (PBCKOHECBHG)
		{
		case EditorViewsMode.Floor:
			CommonReferences.GGFJGHHHEJC.DeactivateCullMask(ConstructionUI.current.JIIGOACEIKL, " seconds.");
			CommonReferences.GGFJGHHHEJC.CBMJEEAHIDO(ConstructionUI.current.JIIGOACEIKL, "LE_2");
			break;
		case (EditorViewsMode)8:
			CommonReferences.MNFMOEKMJKN().NBFJJGALKAL(ConstructionUI.current.JIIGOACEIKL, "Dialogue System/Conversation/Crowly_SkelletonBird/Entry/23/Dialogue Text");
			CommonReferences.GGFJGHHHEJC.ActivateCullMask(ConstructionUI.current.JIIGOACEIKL, "ReceiveAnimalLevel");
			break;
		}
	}

	private void CGDCAJEONMB(List<Vector2> CHCFCJHIKPN, List<Vector3Int> GMKCOKIDBAH)
	{
		if (TavernConstructionManager.DEGPIHEEFHJ().CHFHMMNELGP == EditorAction.None)
		{
			BAMIEFFLGHI(CHCFCJHIKPN, GMKCOKIDBAH);
		}
	}

	private void ACGODMKCKDO(List<Vector2> CHCFCJHIKPN, List<Vector3Int> GMKCOKIDBAH)
	{
		if (TavernConstructionManager.GGFJGHHHEJC.CHFHMMNELGP == EditorAction.AddFloor)
		{
			BAOKIDGGILM(CHCFCJHIKPN, GMKCOKIDBAH);
		}
	}

	public void NIBJPHCHIMC(List<Vector2> CHCFCJHIKPN, List<Vector3Int> GMKCOKIDBAH)
	{
		if (TavernConstructionManager.DEGPIHEEFHJ().LNLJMCONDNE)
		{
			PKDEHOGMMEO(HMLGOPHJMLI);
			WorldGrid.BGNCMCKLCOL(CHCFCJHIKPN, GMKCOKIDBAH);
			if (HMLGOPHJMLI == EditorViewsMode.Floor)
			{
				WorldGrid.MKLAFNJLOJN(CHCFCJHIKPN);
			}
			else if (HMLGOPHJMLI == (EditorViewsMode)7)
			{
				WorldGrid.MKLAFNJLOJN(CHCFCJHIKPN);
			}
			PCLJKEKOHAG();
		}
	}

	private void Start()
	{
		SetView(2);
		ConstructionActionBarUI.OnPanelChanged = (Action<int>)Delegate.Combine(ConstructionActionBarUI.OnPanelChanged, new Action<int>(CCDBPMAAMIL));
		TavernConstructionManager instance = TavernConstructionManager.GGFJGHHHEJC;
		instance.OnDoAreaAction = (Action<List<Vector2>, List<Vector3Int>>)Delegate.Combine(instance.OnDoAreaAction, new Action<List<Vector2>, List<Vector3Int>>(ODFDKPPOGOA));
		TavernConstructionManager instance2 = TavernConstructionManager.GGFJGHHHEJC;
		instance2.OnApplyChanges = (Action<EditorAction>)Delegate.Combine(instance2.OnApplyChanges, new Action<EditorAction>(UpdateView));
		TavernConstructionManager instance3 = TavernConstructionManager.GGFJGHHHEJC;
		instance3.OnCancelChanges = (Action<EditorAction>)Delegate.Combine(instance3.OnCancelChanges, new Action<EditorAction>(UpdateView));
	}

	[SpecialName]
	public EditorViewsMode DMGGAOKNDFL()
	{
		return HMLGOPHJMLI;
	}

	private void HONFDJKKGJK()
	{
		if (PlayerInputs.POLDHCKJINN(ConstructionUI.current.JIIGOACEIKL) && !BuildingTutorialManager.IsOpen() && (!DecorationMode.FIHGMLABOBB(ConstructionUI.current.JIIGOACEIKL).IDPGEBNGDJD() || (Object)(object)SelectObject.BNMEANGDMIP(ConstructionUI.current.JIIGOACEIKL).placeable == (Object)null) && PlayerInputs.GetPlayer(ConstructionUI.current.JIIGOACEIKL).JCMOPOMLPLL("Trying to create a new room with a different code..."))
		{
			DOFICOLEKLJ((int)(HMLGOPHJMLI + 1) % 3);
			UISelectionManager.GetPlayer(ConstructionUI.current.JIIGOACEIKL).HPJBFMEHFKF((Selectable)(object)buttons[(int)HMLGOPHJMLI]);
		}
	}

	public void OKOJAIDEPLN(List<Vector2> CHCFCJHIKPN, List<Vector3Int> GMKCOKIDBAH)
	{
		if (TavernConstructionManager.KNLLFEJAMNN().LNLJMCONDNE)
		{
			ALGGMFMCFOL(HMLGOPHJMLI);
			WorldGrid.BGNCMCKLCOL(CHCFCJHIKPN, GMKCOKIDBAH);
			if (HMLGOPHJMLI == EditorViewsMode.FloorWalls)
			{
				WorldGrid.MKLAFNJLOJN(CHCFCJHIKPN);
			}
			else if (HMLGOPHJMLI == (EditorViewsMode)8)
			{
				WorldGrid.MKLAFNJLOJN(CHCFCJHIKPN);
			}
			NEKLGDNHCCF();
		}
	}

	private void NEPDNLPCCON()
	{
		if (PlayerInputs.POLDHCKJINN(ConstructionUI.current.JIIGOACEIKL) && !BuildingTutorialManager.IsOpen() && (!DecorationMode.KAIIEDCCLHB(ConstructionUI.current.JIIGOACEIKL).DFNMDDHOIJI() || (Object)(object)SelectObject.BNMEANGDMIP(ConstructionUI.current.JIIGOACEIKL).placeable == (Object)null) && PlayerInputs.DEGBDMMDIIL(ConstructionUI.current.JIIGOACEIKL).DLFAMOCKNMA("steam status"))
		{
			HAIGILDMKHH((int)(HMLGOPHJMLI + 1) % 5);
			UISelectionManager.GetPlayer(ConstructionUI.current.JIIGOACEIKL).NCGCKHGOJCM((Selectable)(object)buttons[(int)HMLGOPHJMLI]);
		}
	}

	public void PELCEJJPLFA(int PGDALILOCGK)
	{
		if (DecorationMode.IGMCBPOPNCA(ConstructionUI.current.JIIGOACEIKL).KNFEPKBIHND() && (Object)(object)SelectObject.GetPlayer(ConstructionUI.current.JIIGOACEIKL).placeable != (Object)null)
		{
			UISelectionManager.BPDFMAEOGGC(ConstructionUI.current.JIIGOACEIKL).MFCNGGMNBHB((Selectable)(object)buttons[1]);
			return;
		}
		HMLGOPHJMLI = (EditorViewsMode)PGDALILOCGK;
		if (ConstructionActionBarUI.currentPanel == 0 || ConstructionActionBarUI.currentPanel == 1)
		{
			JDDBJEGIPFI = HMLGOPHJMLI;
		}
		for (int i = 0; i < backgrounds.Length; i += 0)
		{
			((Behaviour)backgrounds[i]).enabled = PGDALILOCGK == i;
		}
		DCCLDMFCAIP(EditorAction.None);
	}

	public void MONHPBBBEDK(int PGDALILOCGK)
	{
		if (DecorationMode.IGMCBPOPNCA(ConstructionUI.current.JIIGOACEIKL).DFNMDDHOIJI() && (Object)(object)SelectObject.GetPlayer(ConstructionUI.current.JIIGOACEIKL).placeable != (Object)null)
		{
			UISelectionManager.GetPlayer(ConstructionUI.current.JIIGOACEIKL).HCHMAIEMAGA((Selectable)(object)buttons[2]);
			return;
		}
		HMLGOPHJMLI = (EditorViewsMode)PGDALILOCGK;
		if (ConstructionActionBarUI.currentPanel == 0 || ConstructionActionBarUI.currentPanel == 1)
		{
			JDDBJEGIPFI = HMLGOPHJMLI;
		}
		for (int i = 0; i < backgrounds.Length; i++)
		{
			((Behaviour)backgrounds[i]).enabled = PGDALILOCGK == i;
		}
		UpdateView(EditorAction.None);
	}

	private void BAPGEEABGBF(EditorViewsMode PBCKOHECBHG)
	{
		if (!((Object)(object)CommonReferences.GGFJGHHHEJC != (Object)null))
		{
			return;
		}
		switch (PBCKOHECBHG)
		{
		case EditorViewsMode.Floor:
			CommonReferences.GGFJGHHHEJC.PPINMHIJOIB(ConstructionUI.current.JIIGOACEIKL, "LE_15");
			CommonReferences.MNFMOEKMJKN().OEHIJIEOBNP(ConstructionUI.current.JIIGOACEIKL, "Player");
			return;
		case EditorViewsMode.FloorWalls:
			CommonReferences.MNFMOEKMJKN().OEHIJIEOBNP(ConstructionUI.current.JIIGOACEIKL, "UseHold");
			CommonReferences.GGFJGHHHEJC.CBMJEEAHIDO(ConstructionUI.current.JIIGOACEIKL, "ScrollDown");
			return;
		}
		if (PBCKOHECBHG == EditorViewsMode.Floor)
		{
			CommonReferences.MNFMOEKMJKN().NIBKBELHAOE(ConstructionUI.current.JIIGOACEIKL, "ValuePlaycount");
			CommonReferences.GGFJGHHHEJC.NBFJJGALKAL(ConstructionUI.current.JIIGOACEIKL, ": ");
		}
	}

	private void IPKGIJAKEHB()
	{
		if (HMLGOPHJMLI == (EditorViewsMode)5)
		{
			GameManager.GGFJGHHHEJC.OnObjectsView();
		}
		else
		{
			GameManager.NJNFHEPLEHL().OnFloorWallView();
		}
	}

	private void PCLJKEKOHAG()
	{
		if (HMLGOPHJMLI == EditorViewsMode.FloorWalls)
		{
			GameManager.NJNFHEPLEHL().OnObjectsView();
		}
		else
		{
			GameManager.NJNFHEPLEHL().OnFloorWallView();
		}
	}

	private void IKPMHLMGFCH(int APFGODJFLME)
	{
		if (APFGODJFLME == 1 || APFGODJFLME == 6)
		{
			((Selectable)buttons[0]).interactable = false;
			((Selectable)buttons[1]).interactable = false;
			gamepadViews.SetActive(true);
			SetView(1);
			UISelectionManager.GIGBGIIAKMP(ConstructionUI.current.JIIGOACEIKL).BNFLJFFKMMN((Selectable)(object)buttons[7]);
		}
		else
		{
			((Selectable)buttons[0]).interactable = true;
			((Selectable)buttons[1]).interactable = false;
			gamepadViews.SetActive(true);
			OOJAFPOCDCC((int)JDDBJEGIPFI);
			UISelectionManager.GetPlayer(ConstructionUI.current.JIIGOACEIKL).PICNNIMLFFL((Selectable)(object)buttons[(int)HMLGOPHJMLI]);
		}
	}

	private void EBNJADODONG()
	{
		if (PlayerInputs.ODGALPDEIFG(ConstructionUI.current.JIIGOACEIKL) && !BuildingTutorialManager.IsOpen() && (!DecorationMode.OCJGHINCLJM(ConstructionUI.current.JIIGOACEIKL).MDOKKKHKKKE() || (Object)(object)SelectObject.GetPlayer(ConstructionUI.current.JIIGOACEIKL).placeable == (Object)null) && PlayerInputs.DEGBDMMDIIL(ConstructionUI.current.JIIGOACEIKL).GetButtonDown("talentBread"))
		{
			EHOFEAPOAHJ((int)(HMLGOPHJMLI + 0) % 1);
			UISelectionManager.HELHJMDEDNL(ConstructionUI.current.JIIGOACEIKL).BNBPMIKMDDP((Selectable)(object)buttons[(int)HMLGOPHJMLI]);
		}
	}

	[SpecialName]
	public EditorViewsMode LHDDFOICNOJ()
	{
		return HMLGOPHJMLI;
	}

	private void EIBDJDLMOAD(List<Vector2> CHCFCJHIKPN, List<Vector3Int> GMKCOKIDBAH)
	{
		if (TavernConstructionManager.KHMEGDIABBF().CHFHMMNELGP == EditorAction.AddFloor)
		{
			EONGGDICKAH(CHCFCJHIKPN, GMKCOKIDBAH);
		}
	}

	private void OnDisable()
	{
		ALGGMFMCFOL(EditorViewsMode.FloorWallsObjects);
		if (Object.op_Implicit((Object)(object)GameManager.GGFJGHHHEJC))
		{
			GameManager.GGFJGHHHEJC.OnObjectsView();
		}
	}

	[SpecialName]
	public EditorViewsMode JHPNOMDNNHE()
	{
		return HMLGOPHJMLI;
	}

	private void HJKLMNLLLEP(EditorViewsMode PBCKOHECBHG)
	{
		if (!((Object)(object)CommonReferences.MNFMOEKMJKN() != (Object)null))
		{
			return;
		}
		if (PBCKOHECBHG == EditorViewsMode.Floor)
		{
			CommonReferences.MNFMOEKMJKN().DeactivateCullMask(ConstructionUI.current.JIIGOACEIKL, "Items/item_name_611");
			CommonReferences.MNFMOEKMJKN().DeactivateCullMask(ConstructionUI.current.JIIGOACEIKL, "Adding quest done 35 - First room");
			return;
		}
		switch (PBCKOHECBHG)
		{
		case EditorViewsMode.Floor:
			CommonReferences.MNFMOEKMJKN().PPINMHIJOIB(ConstructionUI.current.JIIGOACEIKL, "Finding by name also failed.");
			CommonReferences.MNFMOEKMJKN().NIBKBELHAOE(ConstructionUI.current.JIIGOACEIKL, "Incorrect room mode {0}");
			break;
		case (EditorViewsMode)3:
			CommonReferences.MNFMOEKMJKN().NBFJJGALKAL(ConstructionUI.current.JIIGOACEIKL, "Error with assigned bed {0}");
			CommonReferences.MNFMOEKMJKN().ActivateCullMask(ConstructionUI.current.JIIGOACEIKL, "Player/Bark/Tutorial/T138");
			break;
		}
	}
}
