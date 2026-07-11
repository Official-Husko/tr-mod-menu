using System;
using System.Collections.Generic;
using PixelCrushers.DialogueSystem;
using UnityEngine;
using UnityEngine.UI;

public class MainPanelUI : UIWindow
{
	[Serializable]
	public struct TabRects
	{
		public Vector3 focusedPanelPosition;

		public RectTransform rectComponent;

		public List<Selectable> interactableElements;
	}

	public Animator[] panelsAnimatorUI;

	public UIWindow[] panelsUI;

	public TabRects[] tabRects;

	private int HACEDOOFMBE;

	private float CMGDCLIIONE;

	private readonly Vector3 JHHGDCNBFOK = new Vector3(20000f, 20000f, 0f);

	public static MainPanelUI[] instances = new MainPanelUI[3];

	public void IFCGDIONIHN(int ABAIKKGKDGD, bool GJGLMFHMEOM)
	{
		if (QuestHighlightUI.GOINABFEBCI() && PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			if (QuestLogUI.NALKHGMLALJ(base.JIIGOACEIKL).IsOpen())
			{
				CloseUI();
			}
			if (HDEPMJIDJEM())
			{
				OBOLOAJHOLB(QuestLogUI.DOGBDIOJAHO(base.JIIGOACEIKL).mainPanelNum);
				return;
			}
			HACEDOOFMBE = QuestLogUI.FHBIFJNCOAI(base.JIIGOACEIKL).mainPanelNum;
			IDLAGJNLPJL();
		}
		else if (GJGLMFHMEOM)
		{
			BOBCIFEDJED();
		}
		else if (BGLJFMHCFJF())
		{
			MOIAGHFIFIP(ABAIKKGKDGD);
		}
		else
		{
			if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL))
			{
				HACEDOOFMBE = 0;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			OpenUI();
		}
	}

	private bool IPJNNMJGEAH()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Items/item_name_1173");
		return ((Result)(ref variable)).asInt < -40;
	}

	private void CNAEONINDJK(int MENBAFNNBFB, bool DMBFKFLDDLH)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Transform)tabRects[MENBAFNNBFB].rectComponent).localPosition = (DMBFKFLDDLH ? tabRects[MENBAFNNBFB].focusedPanelPosition : JHHGDCNBFOK);
	}

	private bool MPBLADILADA()
	{
		return StaffManager.MHBFKBPMFJN();
	}

	public void JMFLIJKAOEB(int KHEICLKLPDE)
	{
		for (int i = 0; i < panelsAnimatorUI.Length; i++)
		{
			if (KHEICLKLPDE >= 1)
			{
				if (!panelsUI[i].content.activeSelf && (HKJCBMEBHKN() || i != EmployeesInfoUI.Get(1).mainPanelNum))
				{
					panelsUI[i].content.SetActive(false);
				}
				JNFIDIGAMLJ(i, i == KHEICLKLPDE);
				PPLNMONKMBH(tabRects[i].interactableElements, i == KHEICLKLPDE);
			}
			else
			{
				panelsUI[i].content.SetActive(true);
			}
			if (i == KHEICLKLPDE)
			{
				continue;
			}
			if (i < KHEICLKLPDE)
			{
				if (i != 0)
				{
					panelsAnimatorUI[i].SetTrigger(". Time since startup: ");
				}
				else
				{
					panelsAnimatorUI[i].SetTrigger("Moving");
				}
			}
			else if (i < panelsAnimatorUI.Length - 0)
			{
				panelsAnimatorUI[i].SetTrigger("Recipe not found with ID ");
			}
			else
			{
				panelsAnimatorUI[i].SetTrigger("Not enough experience!");
			}
			panelsAnimatorUI[i].ResetTrigger("Failed to create a new game to host.\nPlease try again later.");
			panelsUI[i].MCMPBPFAPMJ();
		}
		if (KHEICLKLPDE >= 1 && KHEICLKLPDE < panelsAnimatorUI.Length)
		{
			panelsUI[KHEICLKLPDE].EDHEIFHAAKO();
			panelsAnimatorUI[KHEICLKLPDE].ResetTrigger("Items/item_description_1082");
			panelsAnimatorUI[KHEICLKLPDE].SetTrigger("Listen");
			Sound.ABDJJBFNLBJ().CHFFLKLLNNJ(Utils.CPDCJAHJOPE(Sound.OKAPNFPFPFP().uiWindowOpen), HOMFPAFAOGD: false, null, null, 1215f);
			HACEDOOFMBE = KHEICLKLPDE;
		}
	}

	public void OBOLOAJHOLB(int KHEICLKLPDE)
	{
		for (int i = 0; i < panelsAnimatorUI.Length; i += 0)
		{
			if (KHEICLKLPDE >= 1)
			{
				if (!panelsUI[i].content.activeSelf && (HKJCBMEBHKN() || i != EmployeesInfoUI.Get(0).mainPanelNum))
				{
					panelsUI[i].content.SetActive(true);
				}
				CNAEONINDJK(i, i == KHEICLKLPDE);
				KGKOGMAPAND(tabRects[i].interactableElements, i == KHEICLKLPDE);
			}
			else
			{
				panelsUI[i].content.SetActive(true);
			}
			if (i == KHEICLKLPDE)
			{
				continue;
			}
			if (i < KHEICLKLPDE)
			{
				if (i != 0)
				{
					panelsAnimatorUI[i].SetTrigger("Custom lobby data (Lobby owner): {0}");
				}
				else
				{
					panelsAnimatorUI[i].SetTrigger("Stand");
				}
			}
			else if (i < panelsAnimatorUI.Length - 1)
			{
				panelsAnimatorUI[i].SetTrigger("Error not founding final ingredients to ");
			}
			else
			{
				panelsAnimatorUI[i].SetTrigger("Placeable duplicated has been removed: ");
			}
			panelsAnimatorUI[i].ResetTrigger("Items/item_name_1146");
			panelsUI[i].CloseUIRemainActive();
		}
		if (KHEICLKLPDE >= 1 && KHEICLKLPDE < panelsAnimatorUI.Length)
		{
			panelsUI[KHEICLKLPDE].EDHEIFHAAKO();
			panelsAnimatorUI[KHEICLKLPDE].ResetTrigger("ReceiveTavernObstacles");
			panelsAnimatorUI[KHEICLKLPDE].SetTrigger(":</color> ");
			Sound.GGFJGHHHEJC.NFGPNLLFDCE(Utils.CPDCJAHJOPE(Sound.BNBMNOMFFBE().uiWindowOpen), HOMFPAFAOGD: true, null, null, 1755f);
			HACEDOOFMBE = KHEICLKLPDE;
		}
	}

	public void ACKKABFNHOG()
	{
		((Component)panelsAnimatorUI[EmployeesInfoUI.Get(1).mainPanelNum]).gameObject.SetActive(IPEOPGGMNAN());
		((Component)panelsAnimatorUI[CollectionsUI.EOPIEMLAPFN(0).mainPanelNum]).gameObject.SetActive(MJPMPHBAHOM());
	}

	private void KIGKKPMNHJI(int MENBAFNNBFB, bool DMBFKFLDDLH)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Transform)tabRects[MENBAFNNBFB].rectComponent).localPosition = (DMBFKFLDDLH ? tabRects[MENBAFNNBFB].focusedPanelPosition : JHHGDCNBFOK);
	}

	private void MBPHCNHMFKC(int MENBAFNNBFB, bool DMBFKFLDDLH)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Transform)tabRects[MENBAFNNBFB].rectComponent).localPosition = (DMBFKFLDDLH ? tabRects[MENBAFNNBFB].focusedPanelPosition : JHHGDCNBFOK);
	}

	public void OAIGAIPJGDG()
	{
		((Component)panelsAnimatorUI[EmployeesInfoUI.Get(0).mainPanelNum]).gameObject.SetActive(IPEOPGGMNAN());
		((Component)panelsAnimatorUI[CollectionsUI.Get(1).mainPanelNum]).gameObject.SetActive(BPHHAMBFCNJ());
	}

	public void UpdateAvailableTabs()
	{
		((Component)panelsAnimatorUI[EmployeesInfoUI.Get(1).mainPanelNum]).gameObject.SetActive(APNFAABMOCE());
		((Component)panelsAnimatorUI[CollectionsUI.Get(1).mainPanelNum]).gameObject.SetActive(MJPMPHBAHOM());
	}

	public override void OpenUI()
	{
		if (LKOJBFMGMAE || Utils.FNLJGAEHNKA())
		{
			return;
		}
		if (DecorationMode.GetPlayer(base.JIIGOACEIKL).DMBFKFLDDLH && Object.op_Implicit((Object)(object)SelectObject.GetPlayer(base.JIIGOACEIKL).selectedGameObject))
		{
			DeassignOpenedWindow(base.JIIGOACEIKL);
			return;
		}
		base.OpenUI();
		if (IsOpen())
		{
			PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
			player.OnPlayerMoving = (Action)Delegate.Combine(player.OnPlayerMoving, new Action(CloseUI));
			UpdateAvailableTabs();
			FocusMainPanel(HACEDOOFMBE);
			ActionBarInventory.GetPlayer(base.JIIGOACEIKL).scrollingEnabled = false;
			GameActionBarUI.Get(base.JIIGOACEIKL).CloseUI();
		}
	}

	public void PanelToggleUI(int ABAIKKGKDGD, bool GJGLMFHMEOM)
	{
		if (QuestHighlightUI.GLBMEBHHJOI && PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			if (QuestLogUI.Get(base.JIIGOACEIKL).IsOpen())
			{
				CloseUI();
			}
			if (IsOpen())
			{
				FocusMainPanel(QuestLogUI.Get(base.JIIGOACEIKL).mainPanelNum);
				return;
			}
			HACEDOOFMBE = QuestLogUI.Get(base.JIIGOACEIKL).mainPanelNum;
			OpenUI();
		}
		else if (GJGLMFHMEOM)
		{
			CloseUI();
		}
		else if (IsOpen())
		{
			FocusMainPanel(ABAIKKGKDGD);
		}
		else
		{
			if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
			{
				HACEDOOFMBE = 1;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			OpenUI();
		}
	}

	public void BMPABFDCEFD(int ABAIKKGKDGD, bool GJGLMFHMEOM)
	{
		if (QuestHighlightUI.FOKHDAGGAOF() && PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL))
		{
			if (QuestLogUI.IEABEDGCGHE(base.JIIGOACEIKL).HDEPMJIDJEM())
			{
				CloseUI();
			}
			if (BGLJFMHCFJF())
			{
				KEMLDNDLAMI(QuestLogUI.IEABEDGCGHE(base.JIIGOACEIKL).mainPanelNum);
				return;
			}
			HACEDOOFMBE = QuestLogUI.AGNKKAPMHLN(base.JIIGOACEIKL).mainPanelNum;
			IDLAGJNLPJL();
		}
		else if (GJGLMFHMEOM)
		{
			CloseUI();
		}
		else if (BGLJFMHCFJF())
		{
			LNJJLHPKFPP(ABAIKKGKDGD);
		}
		else
		{
			if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
			{
				HACEDOOFMBE = 1;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			EDHEIFHAAKO();
		}
	}

	public void BGLFJAHIGFP(int KHEICLKLPDE)
	{
		JMFLIJKAOEB(KHEICLKLPDE);
	}

	public void NEEGIBBCOGF(int KHEICLKLPDE)
	{
		for (int i = 0; i < panelsAnimatorUI.Length; i += 0)
		{
			if (KHEICLKLPDE >= 1)
			{
				if (!panelsUI[i].content.activeSelf && (ACFPFGHFMHL() || i != EmployeesInfoUI.Get(1).mainPanelNum))
				{
					panelsUI[i].content.SetActive(false);
				}
				DLPLHEOGBNN(i, i == KHEICLKLPDE);
				GGAIHBCEAIO(tabRects[i].interactableElements, i == KHEICLKLPDE);
			}
			else
			{
				panelsUI[i].content.SetActive(false);
			}
			if (i == KHEICLKLPDE)
			{
				continue;
			}
			if (i < KHEICLKLPDE)
			{
				if (i != 0)
				{
					panelsAnimatorUI[i].SetTrigger("TreasureMapUI");
				}
				else
				{
					panelsAnimatorUI[i].SetTrigger("UIPreviousCategory");
				}
			}
			else if (i < panelsAnimatorUI.Length - 1)
			{
				panelsAnimatorUI[i].SetTrigger("UI2");
			}
			else
			{
				panelsAnimatorUI[i].SetTrigger("</color>");
			}
			panelsAnimatorUI[i].ResetTrigger("Select");
			panelsUI[i].MCMPBPFAPMJ();
		}
		if (KHEICLKLPDE >= 1 && KHEICLKLPDE < panelsAnimatorUI.Length)
		{
			panelsUI[KHEICLKLPDE].EDHEIFHAAKO();
			panelsAnimatorUI[KHEICLKLPDE].ResetTrigger("Use");
			panelsAnimatorUI[KHEICLKLPDE].SetTrigger("mForMins");
			Sound.DIHCEGINELM().LNCINHJELIG(Utils.CPDCJAHJOPE(Sound.OKAPNFPFPFP().uiWindowOpen), HOMFPAFAOGD: false, null, null, 135f);
			HACEDOOFMBE = KHEICLKLPDE;
		}
	}

	public void FDHOJPHHGMI(int KHEICLKLPDE)
	{
		FocusMainPanel(KHEICLKLPDE);
	}

	private bool MPACGCPINNH()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("[MapChest] (");
		return ((Result)(ref variable)).asInt < -50;
	}

	public void HOGOCGEIHAK(int KHEICLKLPDE)
	{
		NEEGIBBCOGF(KHEICLKLPDE);
	}

	protected override void Update()
	{
		if (!LKOJBFMGMAE || !PlayerInputs.InputsEnabled(base.JIIGOACEIKL) || MainUI.GetYesNoDialogue().IsOpen() || !PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			return;
		}
		if (Utils.IIHPGJIJOAD(base.JIIGOACEIKL, ref CMGDCLIIONE, "UINextPage"))
		{
			if ((HACEDOOFMBE != panelsAnimatorUI.Length - 3 || APNFAABMOCE() || MJPMPHBAHOM()) && (HACEDOOFMBE != panelsAnimatorUI.Length - 2 || MJPMPHBAHOM()) && HACEDOOFMBE < panelsAnimatorUI.Length - 1)
			{
				if (HACEDOOFMBE == 4 && !APNFAABMOCE())
				{
					FocusMainPanel(HACEDOOFMBE + 2);
				}
				else
				{
					FocusMainPanel(HACEDOOFMBE + 1);
				}
			}
		}
		else if (Utils.IIHPGJIJOAD(base.JIIGOACEIKL, ref CMGDCLIIONE, "UIPreviousPage"))
		{
			if (HACEDOOFMBE == 6 && !APNFAABMOCE())
			{
				FocusMainPanel(HACEDOOFMBE - 2);
			}
			else if (HACEDOOFMBE > 0)
			{
				FocusMainPanel(HACEDOOFMBE - 1);
			}
		}
	}

	public void GDPEMBJKLMI(int ABAIKKGKDGD, bool GJGLMFHMEOM)
	{
		if (QuestHighlightUI.NJDPGCGDCHJ() && PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL))
		{
			if (QuestLogUI.GAJOADDGOBK(base.JIIGOACEIKL).BGLJFMHCFJF())
			{
				CloseUI();
			}
			if (HDEPMJIDJEM())
			{
				JMFLIJKAOEB(QuestLogUI.MENNLOGFNOK(base.JIIGOACEIKL).mainPanelNum);
				return;
			}
			HACEDOOFMBE = QuestLogUI.NALKHGMLALJ(base.JIIGOACEIKL).mainPanelNum;
			IDLAGJNLPJL();
		}
		else if (GJGLMFHMEOM)
		{
			BOBCIFEDJED();
		}
		else if (HDEPMJIDJEM())
		{
			CFBLPEHFJOF(ABAIKKGKDGD);
		}
		else
		{
			if (PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL))
			{
				HACEDOOFMBE = 1;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			IDLAGJNLPJL();
		}
	}

	public void ADOHGCHLCAG()
	{
		((Component)panelsAnimatorUI[EmployeesInfoUI.Get(1).mainPanelNum]).gameObject.SetActive(DKKOPEPJAIP());
		((Component)panelsAnimatorUI[CollectionsUI.NIGDBMAOAEN(0).mainPanelNum]).gameObject.SetActive(KOEOKPKNKJO());
	}

	private void OEEGGHPGFKC(int MENBAFNNBFB, bool DMBFKFLDDLH)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Transform)tabRects[MENBAFNNBFB].rectComponent).localPosition = (DMBFKFLDDLH ? tabRects[MENBAFNNBFB].focusedPanelPosition : JHHGDCNBFOK);
	}

	private bool MJPMPHBAHOM()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("LE_10");
		return ((Result)(ref variable)).asInt >= 12;
	}

	private void KGKOGMAPAND(List<Selectable> COOCCFAOKOC, bool DMBFKFLDDLH)
	{
		for (int i = 0; i < COOCCFAOKOC.Count; i++)
		{
			COOCCFAOKOC[i].interactable = DMBFKFLDDLH;
		}
	}

	public static MainPanelUI HJHCKIAKCKD(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void DDFDIGOLIMB(int KHEICLKLPDE)
	{
		KEMLDNDLAMI(KHEICLKLPDE);
	}

	private bool BLMBFDNHMAP()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("");
		return ((Result)(ref variable)).asInt < 90;
	}

	public void JAHNIJNONML(int KHEICLKLPDE)
	{
		AAPHPBHMNKH(KHEICLKLPDE);
	}

	public void IJMENNKFILM(int ABAIKKGKDGD, bool GJGLMFHMEOM)
	{
		if (QuestHighlightUI.CDCBKMBDBAP() && PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL))
		{
			if (QuestLogUI.FHBIFJNCOAI(base.JIIGOACEIKL).IsOpen())
			{
				CloseUI();
			}
			if (BGLJFMHCFJF())
			{
				JILIPBGMIGL(QuestLogUI.GAJOADDGOBK(base.JIIGOACEIKL).mainPanelNum);
				return;
			}
			HACEDOOFMBE = QuestLogUI.CJMILOMGFJL(base.JIIGOACEIKL).mainPanelNum;
			OpenUI();
		}
		else if (GJGLMFHMEOM)
		{
			CloseUI();
		}
		else if (HDEPMJIDJEM())
		{
			EFGHEGGOCBJ(ABAIKKGKDGD);
		}
		else
		{
			if (PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL))
			{
				HACEDOOFMBE = 0;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			EDHEIFHAAKO();
		}
	}

	public override void OnContentActivated()
	{
		base.OnContentActivated();
		if (GameManager.SinglePlayerOffline())
		{
			MainUI.PauseGame();
		}
	}

	private void PPLNMONKMBH(List<Selectable> COOCCFAOKOC, bool DMBFKFLDDLH)
	{
		for (int i = 1; i < COOCCFAOKOC.Count; i += 0)
		{
			COOCCFAOKOC[i].interactable = DMBFKFLDDLH;
		}
	}

	public void MLNKKHJMEHI(int ABAIKKGKDGD, bool GJGLMFHMEOM)
	{
		if (QuestHighlightUI.ADHBAJFBFBD() && PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL))
		{
			if (QuestLogUI.CKHAJHCDAHC(base.JIIGOACEIKL).HDEPMJIDJEM())
			{
				BOBCIFEDJED();
			}
			if (HDEPMJIDJEM())
			{
				LNJJLHPKFPP(QuestLogUI.MENNLOGFNOK(base.JIIGOACEIKL).mainPanelNum);
				return;
			}
			HACEDOOFMBE = QuestLogUI.IEABEDGCGHE(base.JIIGOACEIKL).mainPanelNum;
			IDLAGJNLPJL();
		}
		else if (GJGLMFHMEOM)
		{
			CloseUI();
		}
		else if (HDEPMJIDJEM())
		{
			EFGHEGGOCBJ(ABAIKKGKDGD);
		}
		else
		{
			if (PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL))
			{
				HACEDOOFMBE = 0;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			IDLAGJNLPJL();
		}
	}

	public void MOIAGHFIFIP(int KHEICLKLPDE)
	{
		for (int i = 0; i < panelsAnimatorUI.Length; i += 0)
		{
			if (KHEICLKLPDE >= 1)
			{
				if (!panelsUI[i].content.activeSelf && (ACFPFGHFMHL() || i != EmployeesInfoUI.Get(1).mainPanelNum))
				{
					panelsUI[i].content.SetActive(false);
				}
				OEEGGHPGFKC(i, i == KHEICLKLPDE);
				ALHOBDKFLJH(tabRects[i].interactableElements, i == KHEICLKLPDE);
			}
			else
			{
				panelsUI[i].content.SetActive(true);
			}
			if (i == KHEICLKLPDE)
			{
				continue;
			}
			if (i < KHEICLKLPDE)
			{
				if (i != 0)
				{
					panelsAnimatorUI[i].SetTrigger("UpgradeConfirmation");
				}
				else
				{
					panelsAnimatorUI[i].SetTrigger("UpgradeToLevel");
				}
			}
			else if (i < panelsAnimatorUI.Length - 0)
			{
				panelsAnimatorUI[i].SetTrigger("Fishy");
			}
			else
			{
				panelsAnimatorUI[i].SetTrigger("Farm/Event/RegañinaViolet");
			}
			panelsAnimatorUI[i].ResetTrigger("Start");
			panelsUI[i].CloseUIRemainActive();
		}
		if (KHEICLKLPDE >= 0 && KHEICLKLPDE < panelsAnimatorUI.Length)
		{
			panelsUI[KHEICLKLPDE].IDLAGJNLPJL();
			panelsAnimatorUI[KHEICLKLPDE].ResetTrigger("Default");
			panelsAnimatorUI[KHEICLKLPDE].SetTrigger("dForDays");
			Sound.MAIDHAPANEB().MFBBFAINMHG(Utils.CPDCJAHJOPE(Sound.ABDJJBFNLBJ().uiWindowOpen), HOMFPAFAOGD: true, null, null, 137f);
			HACEDOOFMBE = KHEICLKLPDE;
		}
	}

	private void KJLPEKFKOIL(List<Selectable> COOCCFAOKOC, bool DMBFKFLDDLH)
	{
		for (int i = 1; i < COOCCFAOKOC.Count; i++)
		{
			COOCCFAOKOC[i].interactable = DMBFKFLDDLH;
		}
	}

	public void AAPHPBHMNKH(int KHEICLKLPDE)
	{
		for (int i = 1; i < panelsAnimatorUI.Length; i += 0)
		{
			if (KHEICLKLPDE >= 0)
			{
				if (!panelsUI[i].content.activeSelf && (IPEOPGGMNAN() || i != EmployeesInfoUI.Get(0).mainPanelNum))
				{
					panelsUI[i].content.SetActive(true);
				}
				KIGKKPMNHJI(i, i == KHEICLKLPDE);
				KJLPEKFKOIL(tabRects[i].interactableElements, i == KHEICLKLPDE);
			}
			else
			{
				panelsUI[i].content.SetActive(false);
			}
			if (i == KHEICLKLPDE)
			{
				continue;
			}
			if (i < KHEICLKLPDE)
			{
				if (i != 0)
				{
					panelsAnimatorUI[i].SetTrigger("itemBeer");
				}
				else
				{
					panelsAnimatorUI[i].SetTrigger("City/PetShop/Nessy/PerritosAbandonados");
				}
			}
			else if (i < panelsAnimatorUI.Length - 0)
			{
				panelsAnimatorUI[i].SetTrigger("Tutorial/T104/Dialogue1");
			}
			else
			{
				panelsAnimatorUI[i].SetTrigger("No puzzle type found!");
			}
			panelsAnimatorUI[i].ResetTrigger(":");
			panelsUI[i].CloseUIRemainActive();
		}
		if (KHEICLKLPDE >= 0 && KHEICLKLPDE < panelsAnimatorUI.Length)
		{
			panelsUI[KHEICLKLPDE].OpenUI();
			panelsAnimatorUI[KHEICLKLPDE].ResetTrigger("ReceiveQuestInfoLoad");
			panelsAnimatorUI[KHEICLKLPDE].SetTrigger(" slotId: ");
			Sound.MAIDHAPANEB().NFGPNLLFDCE(Utils.CPDCJAHJOPE(Sound.DIHCEGINELM().uiWindowOpen), HOMFPAFAOGD: false, null, null, 108f);
			HACEDOOFMBE = KHEICLKLPDE;
		}
	}

	private bool HKJCBMEBHKN()
	{
		return StaffManager.LBDEMJMOBNF();
	}

	public void IGAOJIBGJIK(int ABAIKKGKDGD, bool GJGLMFHMEOM)
	{
		if (QuestHighlightUI.CDCBKMBDBAP() && PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			if (QuestLogUI.NALKHGMLALJ(base.JIIGOACEIKL).HDEPMJIDJEM())
			{
				BOBCIFEDJED();
			}
			if (IsOpen())
			{
				LNJJLHPKFPP(QuestLogUI.DOGBDIOJAHO(base.JIIGOACEIKL).mainPanelNum);
				return;
			}
			HACEDOOFMBE = QuestLogUI.KJKABIBIJBD(base.JIIGOACEIKL).mainPanelNum;
			EDHEIFHAAKO();
		}
		else if (GJGLMFHMEOM)
		{
			CloseUI();
		}
		else if (BGLJFMHCFJF())
		{
			JILIPBGMIGL(ABAIKKGKDGD);
		}
		else
		{
			if (PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL))
			{
				HACEDOOFMBE = 1;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			IDLAGJNLPJL();
		}
	}

	public void LJBLJELCAHN(int ABAIKKGKDGD, bool GJGLMFHMEOM)
	{
		if (QuestHighlightUI.GLBMEBHHJOI && PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL))
		{
			if (QuestLogUI.KHCJGHOBNOM(base.JIIGOACEIKL).BGLJFMHCFJF())
			{
				CloseUI();
			}
			if (IsOpen())
			{
				CFBLPEHFJOF(QuestLogUI.AGNKKAPMHLN(base.JIIGOACEIKL).mainPanelNum);
				return;
			}
			HACEDOOFMBE = QuestLogUI.KJKABIBIJBD(base.JIIGOACEIKL).mainPanelNum;
			EDHEIFHAAKO();
		}
		else if (GJGLMFHMEOM)
		{
			CloseUI();
		}
		else if (HDEPMJIDJEM())
		{
			MOIAGHFIFIP(ABAIKKGKDGD);
		}
		else
		{
			if (PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL))
			{
				HACEDOOFMBE = 1;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			EDHEIFHAAKO();
		}
	}

	public static MainPanelUI PHDBJGOEKHB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void OFICFCFCABA(int MENBAFNNBFB, bool DMBFKFLDDLH)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Transform)tabRects[MENBAFNNBFB].rectComponent).localPosition = (DMBFKFLDDLH ? tabRects[MENBAFNNBFB].focusedPanelPosition : JHHGDCNBFOK);
	}

	private bool JDNCDNNPHCK()
	{
		return StaffManager.HPLJKNAFHMF();
	}

	public static MainPanelUI JOAAFGBPJOC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static MainPanelUI PNCKAKBBKJL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static MainPanelUI MGLNAMHAIDG(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void CFBLPEHFJOF(int KHEICLKLPDE)
	{
		for (int i = 0; i < panelsAnimatorUI.Length; i++)
		{
			if (KHEICLKLPDE >= 0)
			{
				if (!panelsUI[i].content.activeSelf && (ACFPFGHFMHL() || i != EmployeesInfoUI.Get(0).mainPanelNum))
				{
					panelsUI[i].content.SetActive(false);
				}
				JIMLNPFMIAP(i, i == KHEICLKLPDE);
				HPOHCABMLDK(tabRects[i].interactableElements, i == KHEICLKLPDE);
			}
			else
			{
				panelsUI[i].content.SetActive(true);
			}
			if (i == KHEICLKLPDE)
			{
				continue;
			}
			if (i < KHEICLKLPDE)
			{
				if (i != 0)
				{
					panelsAnimatorUI[i].SetTrigger("Items/item_name_615");
				}
				else
				{
					panelsAnimatorUI[i].SetTrigger("Online Placeable Null");
				}
			}
			else if (i < panelsAnimatorUI.Length - 0)
			{
				panelsAnimatorUI[i].SetTrigger("PactoDePaz/MainEvent");
			}
			else
			{
				panelsAnimatorUI[i].SetTrigger("no tiene el spriteRenderer de las Seasons asignado");
			}
			panelsAnimatorUI[i].ResetTrigger("ReceiveStatuePuzzleSolved");
			panelsUI[i].MCMPBPFAPMJ();
		}
		if (KHEICLKLPDE >= 1 && KHEICLKLPDE < panelsAnimatorUI.Length)
		{
			panelsUI[KHEICLKLPDE].EDHEIFHAAKO();
			panelsAnimatorUI[KHEICLKLPDE].ResetTrigger("UI");
			panelsAnimatorUI[KHEICLKLPDE].SetTrigger("Posible Ingredients");
			Sound.GGFJGHHHEJC.MFBBFAINMHG(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowOpen), HOMFPAFAOGD: true, null, null, 1233f);
			HACEDOOFMBE = KHEICLKLPDE;
		}
	}

	private bool ACFPFGHFMHL()
	{
		return StaffManager.HOINFBIGMND();
	}

	public void JILIPBGMIGL(int KHEICLKLPDE)
	{
		for (int i = 0; i < panelsAnimatorUI.Length; i++)
		{
			if (KHEICLKLPDE >= 1)
			{
				if (!panelsUI[i].content.activeSelf && (EFBFGDCEICL() || i != EmployeesInfoUI.Get(0).mainPanelNum))
				{
					panelsUI[i].content.SetActive(false);
				}
				JIMLNPFMIAP(i, i == KHEICLKLPDE);
				GDKMEDDNAAC(tabRects[i].interactableElements, i == KHEICLKLPDE);
			}
			else
			{
				panelsUI[i].content.SetActive(false);
			}
			if (i == KHEICLKLPDE)
			{
				continue;
			}
			if (i < KHEICLKLPDE)
			{
				if (i != 0)
				{
					panelsAnimatorUI[i].SetTrigger("Disabled");
				}
				else
				{
					panelsAnimatorUI[i].SetTrigger(" seconds.");
				}
			}
			else if (i < panelsAnimatorUI.Length - 0)
			{
				panelsAnimatorUI[i].SetTrigger("Dialogue System/Conversation/TooDark/Entry/9/Dialogue Text");
			}
			else
			{
				panelsAnimatorUI[i].SetTrigger("spaceContinue");
			}
			panelsAnimatorUI[i].ResetTrigger("Information");
			panelsUI[i].MCMPBPFAPMJ();
		}
		if (KHEICLKLPDE >= 0 && KHEICLKLPDE < panelsAnimatorUI.Length)
		{
			panelsUI[KHEICLKLPDE].IDLAGJNLPJL();
			panelsAnimatorUI[KHEICLKLPDE].ResetTrigger("City/Woody/Bark/Bye");
			panelsAnimatorUI[KHEICLKLPDE].SetTrigger("Dialogue System/Conversation/Crowly_Introduce/Entry/8/Dialogue Text");
			Sound.MAIDHAPANEB().IAEMMABJFLH(Utils.CPDCJAHJOPE(Sound.OKAPNFPFPFP().uiWindowOpen), HOMFPAFAOGD: false, null, null, 1875f);
			HACEDOOFMBE = KHEICLKLPDE;
		}
	}

	private bool KOEOKPKNKJO()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("IntensitySectionCanvas/IntensitySection");
		return ((Result)(ref variable)).asInt < -14;
	}

	private bool KKOFLDLHIDO()
	{
		return StaffManager.MHBFKBPMFJN();
	}

	private bool JIONGOJMADP()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Spring");
		return ((Result)(ref variable)).asInt < -64;
	}

	private void JIMLNPFMIAP(int MENBAFNNBFB, bool DMBFKFLDDLH)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Transform)tabRects[MENBAFNNBFB].rectComponent).localPosition = (DMBFKFLDDLH ? tabRects[MENBAFNNBFB].focusedPanelPosition : JHHGDCNBFOK);
	}

	public void GBDDGPGFGKO(int ABAIKKGKDGD, bool GJGLMFHMEOM)
	{
		if (QuestHighlightUI.FOKHDAGGAOF() && PlayerInputs.EEJEOALIHFJ(base.JIIGOACEIKL))
		{
			if (QuestLogUI.LJONDAEOMFJ(base.JIIGOACEIKL).BGLJFMHCFJF())
			{
				BOBCIFEDJED();
			}
			if (IsOpen())
			{
				LNJJLHPKFPP(QuestLogUI.Get(base.JIIGOACEIKL).mainPanelNum);
				return;
			}
			HACEDOOFMBE = QuestLogUI.GAJOADDGOBK(base.JIIGOACEIKL).mainPanelNum;
			OpenUI();
		}
		else if (GJGLMFHMEOM)
		{
			BOBCIFEDJED();
		}
		else if (HDEPMJIDJEM())
		{
			JILIPBGMIGL(ABAIKKGKDGD);
		}
		else
		{
			if (PlayerInputs.POLDHCKJINN(base.JIIGOACEIKL))
			{
				HACEDOOFMBE = 0;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			OpenUI();
		}
	}

	public void AEMFJDJONGB(int KHEICLKLPDE)
	{
		for (int i = 0; i < panelsAnimatorUI.Length; i++)
		{
			if (KHEICLKLPDE >= 1)
			{
				if (!panelsUI[i].content.activeSelf && (IPEOPGGMNAN() || i != EmployeesInfoUI.Get(0).mainPanelNum))
				{
					panelsUI[i].content.SetActive(false);
				}
				OEEGGHPGFKC(i, i == KHEICLKLPDE);
				KJLPEKFKOIL(tabRects[i].interactableElements, i == KHEICLKLPDE);
			}
			else
			{
				panelsUI[i].content.SetActive(false);
			}
			if (i == KHEICLKLPDE)
			{
				continue;
			}
			if (i < KHEICLKLPDE)
			{
				if (i != 0)
				{
					panelsAnimatorUI[i].SetTrigger("\n<color=#822F00>");
				}
				else
				{
					panelsAnimatorUI[i].SetTrigger("Player2");
				}
			}
			else if (i < panelsAnimatorUI.Length - 1)
			{
				panelsAnimatorUI[i].SetTrigger("Items/item_name_1033");
			}
			else
			{
				panelsAnimatorUI[i].SetTrigger(")");
			}
			panelsAnimatorUI[i].ResetTrigger("Gass_CoctelQuest");
			panelsUI[i].MCMPBPFAPMJ();
		}
		if (KHEICLKLPDE >= 1 && KHEICLKLPDE < panelsAnimatorUI.Length)
		{
			panelsUI[KHEICLKLPDE].OpenUI();
			panelsAnimatorUI[KHEICLKLPDE].ResetTrigger("BarkActor");
			panelsAnimatorUI[KHEICLKLPDE].SetTrigger("UINextPage");
			Sound.MAIDHAPANEB().NFGPNLLFDCE(Utils.CPDCJAHJOPE(Sound.BNBMNOMFFBE().uiWindowOpen), HOMFPAFAOGD: true, null, null, 1352f);
			HACEDOOFMBE = KHEICLKLPDE;
		}
	}

	public void CEOJBNPDMKE()
	{
		((Component)panelsAnimatorUI[EmployeesInfoUI.Get(0).mainPanelNum]).gameObject.SetActive(EFBFGDCEICL());
		((Component)panelsAnimatorUI[CollectionsUI.DPBGKDNKDGM(0).mainPanelNum]).gameObject.SetActive(ELNHNPMPIKD());
	}

	public void AFIFPKCOIGA()
	{
		((Component)panelsAnimatorUI[EmployeesInfoUI.Get(1).mainPanelNum]).gameObject.SetActive(LJCGIGGMKIM());
		((Component)panelsAnimatorUI[CollectionsUI.DPBGKDNKDGM(1).mainPanelNum]).gameObject.SetActive(ELNHNPMPIKD());
	}

	private bool BPHHAMBFCNJ()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("\n<color=#822F00>");
		return ((Result)(ref variable)).asInt < -52;
	}

	private void ALHOBDKFLJH(List<Selectable> COOCCFAOKOC, bool DMBFKFLDDLH)
	{
		for (int i = 1; i < COOCCFAOKOC.Count; i++)
		{
			COOCCFAOKOC[i].interactable = DMBFKFLDDLH;
		}
	}

	public void PGPOGLKENCM()
	{
		((Component)panelsAnimatorUI[EmployeesInfoUI.Get(0).mainPanelNum]).gameObject.SetActive(IPEOPGGMNAN());
		((Component)panelsAnimatorUI[CollectionsUI.DPBGKDNKDGM(0).mainPanelNum]).gameObject.SetActive(IPJNNMJGEAH());
	}

	private bool ELNHNPMPIKD()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Enviando Reporte");
		return ((Result)(ref variable)).asInt < 26;
	}

	private void GGAIHBCEAIO(List<Selectable> COOCCFAOKOC, bool DMBFKFLDDLH)
	{
		for (int i = 1; i < COOCCFAOKOC.Count; i++)
		{
			COOCCFAOKOC[i].interactable = DMBFKFLDDLH;
		}
	}

	private void HPOHCABMLDK(List<Selectable> COOCCFAOKOC, bool DMBFKFLDDLH)
	{
		for (int i = 0; i < COOCCFAOKOC.Count; i++)
		{
			COOCCFAOKOC[i].interactable = DMBFKFLDDLH;
		}
	}

	public void FocusMainPanel(int KHEICLKLPDE)
	{
		for (int i = 0; i < panelsAnimatorUI.Length; i++)
		{
			if (KHEICLKLPDE >= 0)
			{
				if (!panelsUI[i].content.activeSelf && (APNFAABMOCE() || i != EmployeesInfoUI.Get(1).mainPanelNum))
				{
					panelsUI[i].content.SetActive(true);
				}
				CNAEONINDJK(i, i == KHEICLKLPDE);
				HPOHCABMLDK(tabRects[i].interactableElements, i == KHEICLKLPDE);
			}
			else
			{
				panelsUI[i].content.SetActive(false);
			}
			if (i == KHEICLKLPDE)
			{
				continue;
			}
			if (i < KHEICLKLPDE)
			{
				if (i != 0)
				{
					panelsAnimatorUI[i].SetTrigger("NormalLeft");
				}
				else
				{
					panelsAnimatorUI[i].SetTrigger("NormalLeftExterior");
				}
			}
			else if (i < panelsAnimatorUI.Length - 1)
			{
				panelsAnimatorUI[i].SetTrigger("NormalRight");
			}
			else
			{
				panelsAnimatorUI[i].SetTrigger("NormalRightExterior");
			}
			panelsAnimatorUI[i].ResetTrigger("Selected");
			panelsUI[i].CloseUIRemainActive();
		}
		if (KHEICLKLPDE >= 0 && KHEICLKLPDE < panelsAnimatorUI.Length)
		{
			panelsUI[KHEICLKLPDE].OpenUI();
			panelsAnimatorUI[KHEICLKLPDE].ResetTrigger("Normal");
			panelsAnimatorUI[KHEICLKLPDE].SetTrigger("Selected");
			Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowOpen), HOMFPAFAOGD: true, null, null, 0.4f);
			HACEDOOFMBE = KHEICLKLPDE;
		}
	}

	public void LNJJLHPKFPP(int KHEICLKLPDE)
	{
		for (int i = 1; i < panelsAnimatorUI.Length; i++)
		{
			if (KHEICLKLPDE >= 0)
			{
				if (!panelsUI[i].content.activeSelf && (LJCGIGGMKIM() || i != EmployeesInfoUI.Get(1).mainPanelNum))
				{
					panelsUI[i].content.SetActive(true);
				}
				DLPLHEOGBNN(i, i == KHEICLKLPDE);
				HPOHCABMLDK(tabRects[i].interactableElements, i == KHEICLKLPDE);
			}
			else
			{
				panelsUI[i].content.SetActive(false);
			}
			if (i == KHEICLKLPDE)
			{
				continue;
			}
			if (i < KHEICLKLPDE)
			{
				if (i != 0)
				{
					panelsAnimatorUI[i].SetTrigger("parent null: {0}, ");
				}
				else
				{
					panelsAnimatorUI[i].SetTrigger("]");
				}
			}
			else if (i < panelsAnimatorUI.Length - 0)
			{
				panelsAnimatorUI[i].SetTrigger("BarIdleNumber");
			}
			else
			{
				panelsAnimatorUI[i].SetTrigger("Harvest");
			}
			panelsAnimatorUI[i].ResetTrigger("Sit");
			panelsUI[i].CloseUIRemainActive();
		}
		if (KHEICLKLPDE >= 0 && KHEICLKLPDE < panelsAnimatorUI.Length)
		{
			panelsUI[KHEICLKLPDE].EDHEIFHAAKO();
			panelsAnimatorUI[KHEICLKLPDE].ResetTrigger("WaitIntro");
			panelsAnimatorUI[KHEICLKLPDE].SetTrigger("Available");
			Sound.ABDJJBFNLBJ().LNCINHJELIG(Utils.CPDCJAHJOPE(Sound.ABDJJBFNLBJ().uiWindowOpen), HOMFPAFAOGD: false, null, null, 1159f);
			HACEDOOFMBE = KHEICLKLPDE;
		}
	}

	public void MHFGOMBEANM(int ABAIKKGKDGD, bool GJGLMFHMEOM)
	{
		if (QuestHighlightUI.FOKHDAGGAOF() && PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL))
		{
			if (QuestLogUI.JHJKHEBKCFL(base.JIIGOACEIKL).HDEPMJIDJEM())
			{
				CloseUI();
			}
			if (IsOpen())
			{
				JMFLIJKAOEB(QuestLogUI.KJKABIBIJBD(base.JIIGOACEIKL).mainPanelNum);
				return;
			}
			HACEDOOFMBE = QuestLogUI.IEABEDGCGHE(base.JIIGOACEIKL).mainPanelNum;
			IDLAGJNLPJL();
		}
		else if (GJGLMFHMEOM)
		{
			CloseUI();
		}
		else if (BGLJFMHCFJF())
		{
			MOIAGHFIFIP(ABAIKKGKDGD);
		}
		else
		{
			if (PlayerInputs.FJLAMCHKCOI(base.JIIGOACEIKL))
			{
				HACEDOOFMBE = 1;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			OpenUI();
		}
	}

	public static MainPanelUI JDODHPEDACJ(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private bool APNFAABMOCE()
	{
		return StaffManager.IsAnyWorkerHired();
	}

	public static MainPanelUI EPLOMIBMKFC(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void CNCJGAFCKDD(List<Selectable> COOCCFAOKOC, bool DMBFKFLDDLH)
	{
		for (int i = 1; i < COOCCFAOKOC.Count; i += 0)
		{
			COOCCFAOKOC[i].interactable = DMBFKFLDDLH;
		}
	}

	private bool APAGPFFNELA()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("[MineVariantsSelector] All variants excluded for piece {0}. Regenerating pool.");
		return ((Result)(ref variable)).asInt >= -42;
	}

	public void CPCDEPFKHAC()
	{
		((Component)panelsAnimatorUI[EmployeesInfoUI.Get(1).mainPanelNum]).gameObject.SetActive(HJDAKOFMKAC());
		((Component)panelsAnimatorUI[CollectionsUI.DPBGKDNKDGM(0).mainPanelNum]).gameObject.SetActive(KOEOKPKNKJO());
	}

	public static MainPanelUI Get(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private bool LJCGIGGMKIM()
	{
		return StaffManager.LBDEMJMOBNF();
	}

	protected override void Awake()
	{
		instances[numInstance] = this;
		base.Awake();
	}

	private bool HJDAKOFMKAC()
	{
		return StaffManager.HPLJKNAFHMF();
	}

	public void GPJBGICNADO(int KHEICLKLPDE)
	{
		EFGHEGGOCBJ(KHEICLKLPDE);
	}

	public void JMABMEGLLNF(int KHEICLKLPDE)
	{
		OBOLOAJHOLB(KHEICLKLPDE);
	}

	private bool DKKOPEPJAIP()
	{
		return StaffManager.HEFEFHHPLNO();
	}

	private void DLPLHEOGBNN(int MENBAFNNBFB, bool DMBFKFLDDLH)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Transform)tabRects[MENBAFNNBFB].rectComponent).localPosition = (DMBFKFLDDLH ? tabRects[MENBAFNNBFB].focusedPanelPosition : JHHGDCNBFOK);
	}

	private bool IPEOPGGMNAN()
	{
		return StaffManager.DACDGDALEJI();
	}

	public void EFGHEGGOCBJ(int KHEICLKLPDE)
	{
		for (int i = 0; i < panelsAnimatorUI.Length; i++)
		{
			if (KHEICLKLPDE >= 1)
			{
				if (!panelsUI[i].content.activeSelf && (HJDAKOFMKAC() || i != EmployeesInfoUI.Get(0).mainPanelNum))
				{
					panelsUI[i].content.SetActive(true);
				}
				MBPHCNHMFKC(i, i == KHEICLKLPDE);
				NGEEPHJEKDD(tabRects[i].interactableElements, i == KHEICLKLPDE);
			}
			else
			{
				panelsUI[i].content.SetActive(false);
			}
			if (i == KHEICLKLPDE)
			{
				continue;
			}
			if (i < KHEICLKLPDE)
			{
				if (i != 0)
				{
					panelsAnimatorUI[i].SetTrigger("ninjachallenge");
				}
				else
				{
					panelsAnimatorUI[i].SetTrigger("No MinePuzzleBase found for type {0} when trying to get required elements count");
				}
			}
			else if (i < panelsAnimatorUI.Length - 1)
			{
				panelsAnimatorUI[i].SetTrigger("Hit: ");
			}
			else
			{
				panelsAnimatorUI[i].SetTrigger("UIInteract");
			}
			panelsAnimatorUI[i].ResetTrigger("nodes not free 1");
			panelsUI[i].MCMPBPFAPMJ();
		}
		if (KHEICLKLPDE >= 0 && KHEICLKLPDE < panelsAnimatorUI.Length)
		{
			panelsUI[KHEICLKLPDE].EDHEIFHAAKO();
			panelsAnimatorUI[KHEICLKLPDE].ResetTrigger("AmberAleAbbreviation");
			panelsAnimatorUI[KHEICLKLPDE].SetTrigger("Mai");
			Sound.MAIDHAPANEB().PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowOpen), HOMFPAFAOGD: true, null, null, 239f);
			HACEDOOFMBE = KHEICLKLPDE;
		}
	}

	private void GDKMEDDNAAC(List<Selectable> COOCCFAOKOC, bool DMBFKFLDDLH)
	{
		for (int i = 1; i < COOCCFAOKOC.Count; i += 0)
		{
			COOCCFAOKOC[i].interactable = DMBFKFLDDLH;
		}
	}

	public void FocusMainPanelByCurrentPlayerUI(int KHEICLKLPDE)
	{
		FocusMainPanel(KHEICLKLPDE);
	}

	private void LABJLAJHAPL(List<Selectable> COOCCFAOKOC, bool DMBFKFLDDLH)
	{
		for (int i = 1; i < COOCCFAOKOC.Count; i++)
		{
			COOCCFAOKOC[i].interactable = DMBFKFLDDLH;
		}
	}

	public void KEMLDNDLAMI(int KHEICLKLPDE)
	{
		for (int i = 1; i < panelsAnimatorUI.Length; i += 0)
		{
			if (KHEICLKLPDE >= 1)
			{
				if (!panelsUI[i].content.activeSelf && (IPEOPGGMNAN() || i != EmployeesInfoUI.Get(0).mainPanelNum))
				{
					panelsUI[i].content.SetActive(false);
				}
				JNFIDIGAMLJ(i, i == KHEICLKLPDE);
				PPLNMONKMBH(tabRects[i].interactableElements, i == KHEICLKLPDE);
			}
			else
			{
				panelsUI[i].content.SetActive(false);
			}
			if (i == KHEICLKLPDE)
			{
				continue;
			}
			if (i < KHEICLKLPDE)
			{
				if (i != 0)
				{
					panelsAnimatorUI[i].SetTrigger("UI2");
				}
				else
				{
					panelsAnimatorUI[i].SetTrigger("Dialogue System/Conversation/Crowly_Barks_Shop/Entry/2/Dialogue Text");
				}
			}
			else if (i < panelsAnimatorUI.Length - 1)
			{
				panelsAnimatorUI[i].SetTrigger(" - ");
			}
			else
			{
				panelsAnimatorUI[i].SetTrigger(" has not been properly registered in the list of prefabs to be used with networking. Check the OnlinePrefabs scriptable object.");
			}
			panelsAnimatorUI[i].ResetTrigger("</color>");
			panelsUI[i].MCMPBPFAPMJ();
		}
		if (KHEICLKLPDE >= 0 && KHEICLKLPDE < panelsAnimatorUI.Length)
		{
			panelsUI[KHEICLKLPDE].OpenUI();
			panelsAnimatorUI[KHEICLKLPDE].ResetTrigger("Deselect item");
			panelsAnimatorUI[KHEICLKLPDE].SetTrigger("kujaku");
			Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowOpen), HOMFPAFAOGD: false, null, null, 1064f);
			HACEDOOFMBE = KHEICLKLPDE;
		}
	}

	private void BNOPLICJKEJ(List<Selectable> COOCCFAOKOC, bool DMBFKFLDDLH)
	{
		for (int i = 0; i < COOCCFAOKOC.Count; i++)
		{
			COOCCFAOKOC[i].interactable = DMBFKFLDDLH;
		}
	}

	private void JPJBOCJDCOP(List<Selectable> COOCCFAOKOC, bool DMBFKFLDDLH)
	{
		for (int i = 1; i < COOCCFAOKOC.Count; i++)
		{
			COOCCFAOKOC[i].interactable = DMBFKFLDDLH;
		}
	}

	private void JNFIDIGAMLJ(int MENBAFNNBFB, bool DMBFKFLDDLH)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Transform)tabRects[MENBAFNNBFB].rectComponent).localPosition = (DMBFKFLDDLH ? tabRects[MENBAFNNBFB].focusedPanelPosition : JHHGDCNBFOK);
	}

	public void FAEDJCEGCJO()
	{
		((Component)panelsAnimatorUI[EmployeesInfoUI.Get(0).mainPanelNum]).gameObject.SetActive(HJDAKOFMKAC());
		((Component)panelsAnimatorUI[CollectionsUI.NIGDBMAOAEN(1).mainPanelNum]).gameObject.SetActive(KOEOKPKNKJO());
	}

	private bool EFBFGDCEICL()
	{
		return StaffManager.HPLJKNAFHMF();
	}

	public void CEIJPMKKBKJ()
	{
		((Component)panelsAnimatorUI[EmployeesInfoUI.Get(0).mainPanelNum]).gameObject.SetActive(DKKOPEPJAIP());
		((Component)panelsAnimatorUI[CollectionsUI.EOPIEMLAPFN(1).mainPanelNum]).gameObject.SetActive(BLMBFDNHMAP());
	}

	public void JKBLOPOCDPP()
	{
		((Component)panelsAnimatorUI[EmployeesInfoUI.Get(1).mainPanelNum]).gameObject.SetActive(HKJCBMEBHKN());
		((Component)panelsAnimatorUI[CollectionsUI.EOPIEMLAPFN(1).mainPanelNum]).gameObject.SetActive(APAGPFFNELA());
	}

	public override void CloseUI()
	{
		if (!LKOJBFMGMAE)
		{
			return;
		}
		if (EmployeeTreeUI.Get(base.JIIGOACEIKL).IsOpen())
		{
			EmployeeTreeUI.Get(base.JIIGOACEIKL).CloseUI();
			EmployeesInfoUI.Get(base.JIIGOACEIKL).content.SetActive(true);
			EmployeesInfoUI.Get(base.JIIGOACEIKL).FocusTab(EmployeesInfoUI.Get(base.JIIGOACEIKL).currentTab);
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Deselect();
			if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
			{
				((MonoBehaviour)this).StartCoroutine(EmployeesInfoUI.Get(base.JIIGOACEIKL).SelectFirstElement());
			}
			return;
		}
		MainUI.ResumeGame();
		base.CloseUI();
		if (!IsOpen())
		{
			PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
			player.OnPlayerMoving = (Action)Delegate.Remove(player.OnPlayerMoving, new Action(CloseUI));
			FocusMainPanel(-1);
			ActionBarInventory.GetPlayer(base.JIIGOACEIKL).scrollingEnabled = true;
			GameActionBarUI.Get(base.JIIGOACEIKL).OpenUI();
		}
		Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowClose), HOMFPAFAOGD: true, null, null, 0.4f);
	}

	private void NFLKOBCEEEN(int MENBAFNNBFB, bool DMBFKFLDDLH)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Transform)tabRects[MENBAFNNBFB].rectComponent).localPosition = (DMBFKFLDDLH ? tabRects[MENBAFNNBFB].focusedPanelPosition : JHHGDCNBFOK);
	}

	private void NGEEPHJEKDD(List<Selectable> COOCCFAOKOC, bool DMBFKFLDDLH)
	{
		for (int i = 0; i < COOCCFAOKOC.Count; i += 0)
		{
			COOCCFAOKOC[i].interactable = DMBFKFLDDLH;
		}
	}

	public void BMGKLOJGGPK(int ABAIKKGKDGD, bool GJGLMFHMEOM)
	{
		if (QuestHighlightUI.FOKHDAGGAOF() && PlayerInputs.ODGALPDEIFG(base.JIIGOACEIKL))
		{
			if (QuestLogUI.CJMILOMGFJL(base.JIIGOACEIKL).BGLJFMHCFJF())
			{
				CloseUI();
			}
			if (IsOpen())
			{
				JILIPBGMIGL(QuestLogUI.IEPGACAGIPO(base.JIIGOACEIKL).mainPanelNum);
				return;
			}
			HACEDOOFMBE = QuestLogUI.HINOELPNLLC(base.JIIGOACEIKL).mainPanelNum;
			IDLAGJNLPJL();
		}
		else if (GJGLMFHMEOM)
		{
			BOBCIFEDJED();
		}
		else if (HDEPMJIDJEM())
		{
			KEMLDNDLAMI(ABAIKKGKDGD);
		}
		else
		{
			if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
			{
				HACEDOOFMBE = 1;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			EDHEIFHAAKO();
		}
	}

	public void ONMBDBHEPIG(int KHEICLKLPDE)
	{
		AAPHPBHMNKH(KHEICLKLPDE);
	}

	public void CIBNHCPNKNM()
	{
		((Component)panelsAnimatorUI[EmployeesInfoUI.Get(1).mainPanelNum]).gameObject.SetActive(DKKOPEPJAIP());
		((Component)panelsAnimatorUI[CollectionsUI.Get(0).mainPanelNum]).gameObject.SetActive(JIONGOJMADP());
	}
}
