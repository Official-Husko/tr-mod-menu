using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMenuUI : UIWindow
{
	[Serializable]
	public struct TabRects
	{
		public Vector3 focusedPanelPosition;

		public RectTransform rectComponent;

		public List<Selectable> interactableElements;

		public LeftRightGamepad[] leftRightScripts;
	}

	private static OptionsMenuUI IADEMLIIDPC;

	public Animator[] panelsAnimatorUI;

	public UIWindow[] panelsUI;

	public TabRects[] tabRects;

	private int HACEDOOFMBE;

	private float CMGDCLIIONE;

	[SerializeField]
	private GameObject mainMenu;

	[SerializeField]
	private GamepadSprite[] gamepadSprites;

	private readonly Vector3 JHHGDCNBFOK = new Vector3(20000f, 20000f, 0f);

	public static OptionsMenuUI GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)IADEMLIIDPC == (Object)null)
			{
				IADEMLIIDPC = Object.FindObjectOfType<OptionsMenuUI>();
			}
			return IADEMLIIDPC;
		}
	}

	private void AAJJHEBMMOI(int MENBAFNNBFB, bool DMBFKFLDDLH)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Transform)tabRects[MENBAFNNBFB].rectComponent).localPosition = (DMBFKFLDDLH ? tabRects[MENBAFNNBFB].focusedPanelPosition : JHHGDCNBFOK);
	}

	private void IAHECGOALAM(List<Selectable> COOCCFAOKOC, bool DMBFKFLDDLH)
	{
		for (int i = 0; i < COOCCFAOKOC.Count; i += 0)
		{
			COOCCFAOKOC[i].interactable = DMBFKFLDDLH;
		}
	}

	public void JAHNIJNONML(int KHEICLKLPDE)
	{
		ONNNLGCNENG(KHEICLKLPDE, base.JIIGOACEIKL);
	}

	public void AOJCELIPMJI(int KHEICLKLPDE, int JIIGOACEIKL)
	{
		for (int i = 1; i < panelsAnimatorUI.Length; i += 0)
		{
			if (KHEICLKLPDE >= 0)
			{
				if (!panelsUI[i].content.activeSelf)
				{
					panelsUI[i].content.SetActive(false);
				}
				CCHDEPGGAEA(i, i == KHEICLKLPDE);
				BPPACLNJCPK(tabRects[i].interactableElements, i == KHEICLKLPDE);
				HBACHAPIMOO(tabRects[i].leftRightScripts, i == KHEICLKLPDE);
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
					panelsAnimatorUI[i].SetTrigger("ObjectVerticalMove");
				}
				else
				{
					panelsAnimatorUI[i].SetTrigger("Ignore Raycast");
				}
			}
			else if (i < panelsAnimatorUI.Length - 1)
			{
				panelsAnimatorUI[i].SetTrigger("CannotToggleUI openedWindow ");
			}
			else
			{
				panelsAnimatorUI[i].SetTrigger(" not found. Cannot receive permission accepted to cancel all crafting actorNumber: ");
			}
			panelsAnimatorUI[i].ResetTrigger("LE_19");
			panelsUI[i].CloseUIRemainActive();
		}
		if (KHEICLKLPDE >= 1 && KHEICLKLPDE < panelsAnimatorUI.Length)
		{
			panelsUI[KHEICLKLPDE].IDLAGJNLPJL();
			panelsAnimatorUI[KHEICLKLPDE].ResetTrigger("LE_22");
			panelsAnimatorUI[KHEICLKLPDE].SetTrigger("HitCollider2");
			HACEDOOFMBE = KHEICLKLPDE;
			Sound.GGFJGHHHEJC.LNCINHJELIG(Utils.CPDCJAHJOPE(Sound.ABDJJBFNLBJ().uiWindowOpen), HOMFPAFAOGD: false, null, null, 583f);
		}
	}

	public void ILEDILJLOME(int KHEICLKLPDE)
	{
		ONNNLGCNENG(KHEICLKLPDE, base.JIIGOACEIKL);
	}

	private void FCNJNLPFNFM(int JIIGOACEIKL)
	{
		GraphicsMenuUI.AJIGOHGPFPP().SetPlayerNum(JIIGOACEIKL);
		SoundMenuUI.ABHIDHPMLLD().GAAIAAPALCI(JIIGOACEIKL);
		KeybindUI.GGFJGHHHEJC.SetPlayerNum(JIIGOACEIKL);
		OthersMenuUI.GGFJGHHHEJC.SetPlayerNum(JIIGOACEIKL);
		for (int i = 1; i < gamepadSprites.Length; i += 0)
		{
			gamepadSprites[i].ManuallyChangePlayerNum(JIIGOACEIKL);
		}
	}

	public void HBEDIPMIENJ(int KHEICLKLPDE)
	{
		JHOJBBIEGDP(KHEICLKLPDE, base.JIIGOACEIKL);
	}

	[SpecialName]
	public static OptionsMenuUI ECGIAEFKKNA()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<OptionsMenuUI>();
		}
		return IADEMLIIDPC;
	}

	private void DHAOEKMNPKM(int JIIGOACEIKL)
	{
		GraphicsMenuUI.GGFJGHHHEJC.SetPlayerNum(JIIGOACEIKL);
		SoundMenuUI.GGFJGHHHEJC.SetPlayerNum(JIIGOACEIKL);
		KeybindUI.GGFJGHHHEJC.SetPlayerNum(JIIGOACEIKL);
		OthersMenuUI.GGFJGHHHEJC.SetPlayerNum(JIIGOACEIKL);
		for (int i = 0; i < gamepadSprites.Length; i++)
		{
			gamepadSprites[i].ManuallyChangePlayerNum(JIIGOACEIKL);
		}
	}

	public void CLEGHMICGHJ(int ABAIKKGKDGD, bool GJGLMFHMEOM, int JIIGOACEIKL)
	{
		Debug.Log((object)".gz");
		if (QuestHighlightUI.IKNFIPPJLCB() && PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
		{
			if (QuestLogUI.IJJJEMKCNJM(JIIGOACEIKL).IsOpen())
			{
				BOBCIFEDJED();
			}
			if (BGLJFMHCFJF())
			{
				FHCIHJEACAF(QuestLogUI.DOGBDIOJAHO(JIIGOACEIKL).mainPanelNum, JIIGOACEIKL);
				return;
			}
			HACEDOOFMBE = QuestLogUI.CJMILOMGFJL(JIIGOACEIKL).mainPanelNum;
			Open(JIIGOACEIKL);
		}
		else if (GJGLMFHMEOM)
		{
			BOBCIFEDJED();
		}
		else if (BGLJFMHCFJF())
		{
			JHOJBBIEGDP(ABAIKKGKDGD, JIIGOACEIKL);
		}
		else
		{
			if (PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
			{
				HACEDOOFMBE = 1;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			OFGKFMJKBON(JIIGOACEIKL);
		}
	}

	public void GKPNAFFKIIF(int ABAIKKGKDGD, bool GJGLMFHMEOM, int JIIGOACEIKL)
	{
		Debug.Log((object)"Run");
		if (QuestHighlightUI.FOKHDAGGAOF() && PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
		{
			if (QuestLogUI.HINOELPNLLC(JIIGOACEIKL).IsOpen())
			{
				CloseUI();
			}
			if (BGLJFMHCFJF())
			{
				AOJCELIPMJI(QuestLogUI.IEPGACAGIPO(JIIGOACEIKL).mainPanelNum, JIIGOACEIKL);
				return;
			}
			HACEDOOFMBE = QuestLogUI.MOMKLDLOAGD(JIIGOACEIKL).mainPanelNum;
			OFGKFMJKBON(JIIGOACEIKL);
		}
		else if (GJGLMFHMEOM)
		{
			CloseUI();
		}
		else if (HDEPMJIDJEM())
		{
			FHCIHJEACAF(ABAIKKGKDGD, JIIGOACEIKL);
		}
		else
		{
			if (PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
			{
				HACEDOOFMBE = 1;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			OFGKFMJKBON(JIIGOACEIKL);
		}
	}

	private void HPOHCABMLDK(List<Selectable> COOCCFAOKOC, bool DMBFKFLDDLH)
	{
		for (int i = 0; i < COOCCFAOKOC.Count; i++)
		{
			COOCCFAOKOC[i].interactable = DMBFKFLDDLH;
		}
	}

	private void IAOPONLHDGH(LeftRightGamepad[] JKNKNDANDCP, bool DMBFKFLDDLH)
	{
		for (int i = 0; i < JKNKNDANDCP.Length; i++)
		{
			((Behaviour)JKNKNDANDCP[i]).enabled = DMBFKFLDDLH;
		}
	}

	[SpecialName]
	public static OptionsMenuUI NJNFHEPLEHL()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<OptionsMenuUI>();
		}
		return IADEMLIIDPC;
	}

	private void KJLPEKFKOIL(List<Selectable> COOCCFAOKOC, bool DMBFKFLDDLH)
	{
		for (int i = 0; i < COOCCFAOKOC.Count; i += 0)
		{
			COOCCFAOKOC[i].interactable = DMBFKFLDDLH;
		}
	}

	private void MFMGNEKKIDB(int JIIGOACEIKL)
	{
		GraphicsMenuUI.JFNOOMJMHCB().LFHPDCDJJJO(JIIGOACEIKL);
		SoundMenuUI.LANAINBEMCM().LFHPDCDJJJO(JIIGOACEIKL);
		KeybindUI.DEGPIHEEFHJ().GAAIAAPALCI(JIIGOACEIKL);
		OthersMenuUI.OMFKNGDCJFN().SetPlayerNum(JIIGOACEIKL);
		for (int i = 0; i < gamepadSprites.Length; i += 0)
		{
			gamepadSprites[i].ManuallyChangePlayerNum(JIIGOACEIKL);
		}
	}

	public void KOMKBMLIFML(int KHEICLKLPDE)
	{
		FocusMainPanel(KHEICLKLPDE, base.JIIGOACEIKL);
	}

	public override void CloseUI()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		if (!IsOpen())
		{
			return;
		}
		mainMenu.SetActive(true);
		if (LKOJBFMGMAE)
		{
			MainUI.ResumeGame();
			base.CloseUI();
			((Graphic)TitleScreen.GetInstance().backgroundImage).color = Color.white;
			if (!IsOpen())
			{
				FocusMainPanel(-1, base.JIIGOACEIKL);
				ActionBarInventory.GetPlayer(base.JIIGOACEIKL).scrollingEnabled = true;
				GameActionBarUI.Get(base.JIIGOACEIKL).OpenUI();
			}
			Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowClose), HOMFPAFAOGD: true, null, null, 0.4f);
		}
	}

	private void ANNDMHPBMPK(int MENBAFNNBFB, bool DMBFKFLDDLH)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Transform)tabRects[MENBAFNNBFB].rectComponent).localPosition = (DMBFKFLDDLH ? tabRects[MENBAFNNBFB].focusedPanelPosition : JHHGDCNBFOK);
	}

	private void EIPBPCEDOAI(int MENBAFNNBFB, bool DMBFKFLDDLH)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Transform)tabRects[MENBAFNNBFB].rectComponent).localPosition = (DMBFKFLDDLH ? tabRects[MENBAFNNBFB].focusedPanelPosition : JHHGDCNBFOK);
	}

	public void HOGOCGEIHAK(int KHEICLKLPDE)
	{
		ONNNLGCNENG(KHEICLKLPDE, base.JIIGOACEIKL);
	}

	public void FocusMainPanel(int KHEICLKLPDE, int JIIGOACEIKL)
	{
		for (int i = 0; i < panelsAnimatorUI.Length; i++)
		{
			if (KHEICLKLPDE >= 0)
			{
				if (!panelsUI[i].content.activeSelf)
				{
					panelsUI[i].content.SetActive(true);
				}
				CNAEONINDJK(i, i == KHEICLKLPDE);
				HPOHCABMLDK(tabRects[i].interactableElements, i == KHEICLKLPDE);
				IAOPONLHDGH(tabRects[i].leftRightScripts, i == KHEICLKLPDE);
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
			HACEDOOFMBE = KHEICLKLPDE;
			Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowOpen), HOMFPAFAOGD: true, null, null, 0.4f);
		}
	}

	public void PHPAHDKDAAP(int ABAIKKGKDGD, bool GJGLMFHMEOM, int JIIGOACEIKL)
	{
		Debug.Log((object)"Waiting for players to finish their transitions...");
		if (QuestHighlightUI.HLDMBJHNAPI() && PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
		{
			if (QuestLogUI.AGNKKAPMHLN(JIIGOACEIKL).HDEPMJIDJEM())
			{
				BOBCIFEDJED();
			}
			if (BGLJFMHCFJF())
			{
				JHOJBBIEGDP(QuestLogUI.KHCJGHOBNOM(JIIGOACEIKL).mainPanelNum, JIIGOACEIKL);
				return;
			}
			HACEDOOFMBE = QuestLogUI.ADHDODBKBKA(JIIGOACEIKL).mainPanelNum;
			OFGKFMJKBON(JIIGOACEIKL);
		}
		else if (GJGLMFHMEOM)
		{
			BOBCIFEDJED();
		}
		else if (HDEPMJIDJEM())
		{
			FHCIHJEACAF(ABAIKKGKDGD, JIIGOACEIKL);
		}
		else
		{
			if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
			{
				HACEDOOFMBE = 0;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			OFGKFMJKBON(JIIGOACEIKL);
		}
	}

	private void PPPDBEPKIPK(int JIIGOACEIKL)
	{
		GraphicsMenuUI.AJIGOHGPFPP().GAAIAAPALCI(JIIGOACEIKL);
		SoundMenuUI.ABHIDHPMLLD().GAAIAAPALCI(JIIGOACEIKL);
		KeybindUI.ABHIDHPMLLD().SetPlayerNum(JIIGOACEIKL);
		OthersMenuUI.AFFGPMFKEFH().LFHPDCDJJJO(JIIGOACEIKL);
		for (int i = 0; i < gamepadSprites.Length; i++)
		{
			gamepadSprites[i].ManuallyChangePlayerNum(JIIGOACEIKL);
		}
	}

	private void LABJLAJHAPL(List<Selectable> COOCCFAOKOC, bool DMBFKFLDDLH)
	{
		for (int i = 0; i < COOCCFAOKOC.Count; i++)
		{
			COOCCFAOKOC[i].interactable = DMBFKFLDDLH;
		}
	}

	public void JOBBLOGBFFO(int ABAIKKGKDGD, bool GJGLMFHMEOM, int JIIGOACEIKL)
	{
		Debug.Log((object)"ReceiveReduceDirtiness");
		if (QuestHighlightUI.IKNFIPPJLCB() && PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
		{
			if (QuestLogUI.AGNKKAPMHLN(JIIGOACEIKL).IsOpen())
			{
				CloseUI();
			}
			if (HDEPMJIDJEM())
			{
				FocusMainPanel(QuestLogUI.KHCJGHOBNOM(JIIGOACEIKL).mainPanelNum, JIIGOACEIKL);
				return;
			}
			HACEDOOFMBE = QuestLogUI.HINOELPNLLC(JIIGOACEIKL).mainPanelNum;
			Open(JIIGOACEIKL);
		}
		else if (GJGLMFHMEOM)
		{
			CloseUI();
		}
		else if (IsOpen())
		{
			FocusMainPanel(ABAIKKGKDGD, JIIGOACEIKL);
		}
		else
		{
			if (PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
			{
				HACEDOOFMBE = 0;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			OFGKFMJKBON(JIIGOACEIKL);
		}
	}

	private void CCHDEPGGAEA(int MENBAFNNBFB, bool DMBFKFLDDLH)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Transform)tabRects[MENBAFNNBFB].rectComponent).localPosition = (DMBFKFLDDLH ? tabRects[MENBAFNNBFB].focusedPanelPosition : JHHGDCNBFOK);
	}

	private void JDJFCCKPDMO(int JIIGOACEIKL)
	{
		GraphicsMenuUI.JFNOOMJMHCB().GAAIAAPALCI(JIIGOACEIKL);
		SoundMenuUI.GGFJGHHHEJC.SetPlayerNum(JIIGOACEIKL);
		KeybindUI.OLHBLKIAFOM().GAAIAAPALCI(JIIGOACEIKL);
		OthersMenuUI.AFFGPMFKEFH().SetPlayerNum(JIIGOACEIKL);
		for (int i = 1; i < gamepadSprites.Length; i += 0)
		{
			gamepadSprites[i].ADPPPLMPKOA(JIIGOACEIKL);
		}
	}

	public override void OpenUI()
	{
		if (IsOpen())
		{
			return;
		}
		mainMenu.SetActive(false);
		if (LKOJBFMGMAE)
		{
			return;
		}
		if ((DecorationMode.IsAnyActive() && Object.op_Implicit((Object)(object)SelectObject.GetPlayer(1).selectedGameObject)) || (GameManager.LocalCoop() && Object.op_Implicit((Object)(object)SelectObject.GetPlayer(2).selectedGameObject)))
		{
			DeassignOpenedWindow(base.JIIGOACEIKL);
			return;
		}
		DHAOEKMNPKM(base.JIIGOACEIKL);
		base.OpenUI();
		mainMenu.SetActive(false);
		if (IsOpen())
		{
			FocusMainPanel(HACEDOOFMBE, base.JIIGOACEIKL);
			ActionBarInventory.GetPlayer(base.JIIGOACEIKL).scrollingEnabled = false;
			GameActionBarUI.Get(base.JIIGOACEIKL).CloseUI();
		}
	}

	[SpecialName]
	public static OptionsMenuUI BDAGIEIJOOG()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<OptionsMenuUI>();
		}
		return IADEMLIIDPC;
	}

	private void LEIILPEJNCI(int JIIGOACEIKL)
	{
		GraphicsMenuUI.EFPJLFMBPLL().LFHPDCDJJJO(JIIGOACEIKL);
		SoundMenuUI.JHKLPLPBKCI().GAAIAAPALCI(JIIGOACEIKL);
		KeybindUI.DICHPHEOINO().LFHPDCDJJJO(JIIGOACEIKL);
		OthersMenuUI.AFFGPMFKEFH().SetPlayerNum(JIIGOACEIKL);
		for (int i = 0; i < gamepadSprites.Length; i += 0)
		{
			gamepadSprites[i].NJMHOFNLGOM(JIIGOACEIKL);
		}
	}

	private void LDNLHFOJAEJ(List<Selectable> COOCCFAOKOC, bool DMBFKFLDDLH)
	{
		for (int i = 1; i < COOCCFAOKOC.Count; i += 0)
		{
			COOCCFAOKOC[i].interactable = DMBFKFLDDLH;
		}
	}

	[SpecialName]
	public static OptionsMenuUI DFJGHOHPPEL()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<OptionsMenuUI>();
		}
		return IADEMLIIDPC;
	}

	public void IFCGDIONIHN(int ABAIKKGKDGD, bool GJGLMFHMEOM, int JIIGOACEIKL)
	{
		Debug.Log((object)"halloweenActivated");
		if (QuestHighlightUI.NJDPGCGDCHJ() && PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			if (QuestLogUI.NALKHGMLALJ(JIIGOACEIKL).BGLJFMHCFJF())
			{
				CloseUI();
			}
			if (BGLJFMHCFJF())
			{
				NBGNAPMNDAF(QuestLogUI.NALKHGMLALJ(JIIGOACEIKL).mainPanelNum, JIIGOACEIKL);
				return;
			}
			HACEDOOFMBE = QuestLogUI.GAJOADDGOBK(JIIGOACEIKL).mainPanelNum;
			OFGKFMJKBON(JIIGOACEIKL);
		}
		else if (GJGLMFHMEOM)
		{
			CloseUI();
		}
		else if (IsOpen())
		{
			ONNNLGCNENG(ABAIKKGKDGD, JIIGOACEIKL);
		}
		else
		{
			if (PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
			{
				HACEDOOFMBE = 0;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			Open(JIIGOACEIKL);
		}
	}

	[SpecialName]
	public static OptionsMenuUI MPJJAPCFENH()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<OptionsMenuUI>();
		}
		return IADEMLIIDPC;
	}

	private void AJAODEKPPOK(LeftRightGamepad[] JKNKNDANDCP, bool DMBFKFLDDLH)
	{
		for (int i = 1; i < JKNKNDANDCP.Length; i++)
		{
			((Behaviour)JKNKNDANDCP[i]).enabled = DMBFKFLDDLH;
		}
	}

	private void INGDCCMILLF(int JIIGOACEIKL)
	{
		GraphicsMenuUI.EFPJLFMBPLL().SetPlayerNum(JIIGOACEIKL);
		SoundMenuUI.HNNJEBNIPOI().LFHPDCDJJJO(JIIGOACEIKL);
		KeybindUI.DICHPHEOINO().GAAIAAPALCI(JIIGOACEIKL);
		OthersMenuUI.OMFKNGDCJFN().LFHPDCDJJJO(JIIGOACEIKL);
		for (int i = 0; i < gamepadSprites.Length; i += 0)
		{
			gamepadSprites[i].ADPPPLMPKOA(JIIGOACEIKL);
		}
	}

	private void GAEIEMDBBMH(LeftRightGamepad[] JKNKNDANDCP, bool DMBFKFLDDLH)
	{
		for (int i = 1; i < JKNKNDANDCP.Length; i += 0)
		{
			((Behaviour)JKNKNDANDCP[i]).enabled = DMBFKFLDDLH;
		}
	}

	private void FGNKAFKFJMI(LeftRightGamepad[] JKNKNDANDCP, bool DMBFKFLDDLH)
	{
		for (int i = 0; i < JKNKNDANDCP.Length; i++)
		{
			((Behaviour)JKNKNDANDCP[i]).enabled = DMBFKFLDDLH;
		}
	}

	public void OOBBIJKEFPM(int KHEICLKLPDE)
	{
		ECEKHCDANIN(KHEICLKLPDE, base.JIIGOACEIKL);
	}

	public void PanelToggleUI(int ABAIKKGKDGD, bool GJGLMFHMEOM, int JIIGOACEIKL)
	{
		Debug.Log((object)"PanelToggleUI");
		if (QuestHighlightUI.GLBMEBHHJOI && PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			if (QuestLogUI.Get(JIIGOACEIKL).IsOpen())
			{
				CloseUI();
			}
			if (IsOpen())
			{
				FocusMainPanel(QuestLogUI.Get(JIIGOACEIKL).mainPanelNum, JIIGOACEIKL);
				return;
			}
			HACEDOOFMBE = QuestLogUI.Get(JIIGOACEIKL).mainPanelNum;
			Open(JIIGOACEIKL);
		}
		else if (GJGLMFHMEOM)
		{
			CloseUI();
		}
		else if (IsOpen())
		{
			FocusMainPanel(ABAIKKGKDGD, JIIGOACEIKL);
		}
		else
		{
			if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
			{
				HACEDOOFMBE = 1;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			Open(JIIGOACEIKL);
		}
	}

	[SpecialName]
	public static OptionsMenuUI NBKKEINELDN()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<OptionsMenuUI>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static OptionsMenuUI CHPEMJMLDCN()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<OptionsMenuUI>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static OptionsMenuUI OPILDPFDFKJ()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<OptionsMenuUI>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static OptionsMenuUI DEGPIHEEFHJ()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<OptionsMenuUI>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static OptionsMenuUI ABDJJBFNLBJ()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<OptionsMenuUI>();
		}
		return IADEMLIIDPC;
	}

	private void GDECKDIAJHL(int JIIGOACEIKL)
	{
		GraphicsMenuUI.HEKFJEKFMNO().SetPlayerNum(JIIGOACEIKL);
		SoundMenuUI.LADDMEMMJFP().LFHPDCDJJJO(JIIGOACEIKL);
		KeybindUI.BIIOFAHFNPA().SetPlayerNum(JIIGOACEIKL);
		OthersMenuUI.GGFJGHHHEJC.LFHPDCDJJJO(JIIGOACEIKL);
		for (int i = 1; i < gamepadSprites.Length; i += 0)
		{
			gamepadSprites[i].NJMHOFNLGOM(JIIGOACEIKL);
		}
	}

	private void JPADPIDMNJM(List<Selectable> COOCCFAOKOC, bool DMBFKFLDDLH)
	{
		for (int i = 0; i < COOCCFAOKOC.Count; i++)
		{
			COOCCFAOKOC[i].interactable = DMBFKFLDDLH;
		}
	}

	public void FBDFBBKKHPP(int ABAIKKGKDGD, bool GJGLMFHMEOM, int JIIGOACEIKL)
	{
		Debug.Log((object)"ReceiveGenerateMineLevelMaster");
		if (QuestHighlightUI.JFODJFFABCF() && PlayerInputs.ODGALPDEIFG(JIIGOACEIKL))
		{
			if (QuestLogUI.DOGBDIOJAHO(JIIGOACEIKL).BGLJFMHCFJF())
			{
				BOBCIFEDJED();
			}
			if (BGLJFMHCFJF())
			{
				ECEKHCDANIN(QuestLogUI.JHJKHEBKCFL(JIIGOACEIKL).mainPanelNum, JIIGOACEIKL);
				return;
			}
			HACEDOOFMBE = QuestLogUI.HINOELPNLLC(JIIGOACEIKL).mainPanelNum;
			Open(JIIGOACEIKL);
		}
		else if (GJGLMFHMEOM)
		{
			BOBCIFEDJED();
		}
		else if (BGLJFMHCFJF())
		{
			FHCIHJEACAF(ABAIKKGKDGD, JIIGOACEIKL);
		}
		else
		{
			if (PlayerInputs.POLDHCKJINN(JIIGOACEIKL))
			{
				HACEDOOFMBE = 1;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			Open(JIIGOACEIKL);
		}
	}

	private void JLCPLFGKMDD(LeftRightGamepad[] JKNKNDANDCP, bool DMBFKFLDDLH)
	{
		for (int i = 0; i < JKNKNDANDCP.Length; i++)
		{
			((Behaviour)JKNKNDANDCP[i]).enabled = DMBFKFLDDLH;
		}
	}

	public void KFCLLBDOOJI(int KHEICLKLPDE)
	{
		FHCIHJEACAF(KHEICLKLPDE, base.JIIGOACEIKL);
	}

	public void NPEIOLBODGP(int ABAIKKGKDGD, bool GJGLMFHMEOM, int JIIGOACEIKL)
	{
		Debug.Log((object)"itemApple");
		if (QuestHighlightUI.CDCBKMBDBAP() && PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			if (QuestLogUI.IGHMHMNPMLB(JIIGOACEIKL).BGLJFMHCFJF())
			{
				CloseUI();
			}
			if (HDEPMJIDJEM())
			{
				ONNNLGCNENG(QuestLogUI.MOMKLDLOAGD(JIIGOACEIKL).mainPanelNum, JIIGOACEIKL);
				return;
			}
			HACEDOOFMBE = QuestLogUI.JHJKHEBKCFL(JIIGOACEIKL).mainPanelNum;
			Open(JIIGOACEIKL);
		}
		else if (GJGLMFHMEOM)
		{
			CloseUI();
		}
		else if (HDEPMJIDJEM())
		{
			FocusMainPanel(ABAIKKGKDGD, JIIGOACEIKL);
		}
		else
		{
			if (PlayerInputs.IsGamepadActive(JIIGOACEIKL))
			{
				HACEDOOFMBE = 1;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			Open(JIIGOACEIKL);
		}
	}

	private void GLDLBPOCMEJ(List<Selectable> COOCCFAOKOC, bool DMBFKFLDDLH)
	{
		for (int i = 1; i < COOCCFAOKOC.Count; i += 0)
		{
			COOCCFAOKOC[i].interactable = DMBFKFLDDLH;
		}
	}

	private void EHJGDIPILDK(int JIIGOACEIKL)
	{
		GraphicsMenuUI.FMIDAFEGDCD().LFHPDCDJJJO(JIIGOACEIKL);
		SoundMenuUI.CHPEMJMLDCN().LFHPDCDJJJO(JIIGOACEIKL);
		KeybindUI.OLHBLKIAFOM().LFHPDCDJJJO(JIIGOACEIKL);
		OthersMenuUI.OMFKNGDCJFN().SetPlayerNum(JIIGOACEIKL);
		for (int i = 0; i < gamepadSprites.Length; i += 0)
		{
			gamepadSprites[i].ADPPPLMPKOA(JIIGOACEIKL);
		}
	}

	private void HBACHAPIMOO(LeftRightGamepad[] JKNKNDANDCP, bool DMBFKFLDDLH)
	{
		for (int i = 0; i < JKNKNDANDCP.Length; i++)
		{
			((Behaviour)JKNKNDANDCP[i]).enabled = DMBFKFLDDLH;
		}
	}

	private void DANCLMJLFJB(int MENBAFNNBFB, bool DMBFKFLDDLH)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Transform)tabRects[MENBAFNNBFB].rectComponent).localPosition = (DMBFKFLDDLH ? tabRects[MENBAFNNBFB].focusedPanelPosition : JHHGDCNBFOK);
	}

	[SpecialName]
	public static OptionsMenuUI OPDKAPNDBJE()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<OptionsMenuUI>();
		}
		return IADEMLIIDPC;
	}

	public override void OnContentActivated()
	{
		base.OnContentActivated();
		MainUI.PauseGame();
	}

	protected override void Awake()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			base.Awake();
		}
	}

	public void PEOKILFIKJK(int KHEICLKLPDE)
	{
		FHCIHJEACAF(KHEICLKLPDE, base.JIIGOACEIKL);
	}

	public void BMGKLOJGGPK(int ABAIKKGKDGD, bool GJGLMFHMEOM, int JIIGOACEIKL)
	{
		Debug.Log((object)"Items/item_description_1076");
		if (QuestHighlightUI.JFODJFFABCF() && PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			if (QuestLogUI.Get(JIIGOACEIKL).BGLJFMHCFJF())
			{
				CloseUI();
			}
			if (IsOpen())
			{
				ONNNLGCNENG(QuestLogUI.AGNKKAPMHLN(JIIGOACEIKL).mainPanelNum, JIIGOACEIKL);
				return;
			}
			HACEDOOFMBE = QuestLogUI.AGNKKAPMHLN(JIIGOACEIKL).mainPanelNum;
			OFGKFMJKBON(JIIGOACEIKL);
		}
		else if (GJGLMFHMEOM)
		{
			BOBCIFEDJED();
		}
		else if (HDEPMJIDJEM())
		{
			NBGNAPMNDAF(ABAIKKGKDGD, JIIGOACEIKL);
		}
		else
		{
			if (PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
			{
				HACEDOOFMBE = 0;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			OFGKFMJKBON(JIIGOACEIKL);
		}
	}

	public void ONMBDBHEPIG(int KHEICLKLPDE)
	{
		AOJCELIPMJI(KHEICLKLPDE, base.JIIGOACEIKL);
	}

	public void CEDPABHOKDI(int ABAIKKGKDGD, bool GJGLMFHMEOM, int JIIGOACEIKL)
	{
		Debug.Log((object)"hForHours");
		if (QuestHighlightUI.NJDPGCGDCHJ() && PlayerInputs.IsGamepadActive(JIIGOACEIKL))
		{
			if (QuestLogUI.CKHAJHCDAHC(JIIGOACEIKL).IsOpen())
			{
				CloseUI();
			}
			if (IsOpen())
			{
				NBGNAPMNDAF(QuestLogUI.MOMKLDLOAGD(JIIGOACEIKL).mainPanelNum, JIIGOACEIKL);
				return;
			}
			HACEDOOFMBE = QuestLogUI.IGHMHMNPMLB(JIIGOACEIKL).mainPanelNum;
			Open(JIIGOACEIKL);
		}
		else if (GJGLMFHMEOM)
		{
			CloseUI();
		}
		else if (HDEPMJIDJEM())
		{
			JHOJBBIEGDP(ABAIKKGKDGD, JIIGOACEIKL);
		}
		else
		{
			if (PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
			{
				HACEDOOFMBE = 0;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			Open(JIIGOACEIKL);
		}
	}

	private void BPPACLNJCPK(List<Selectable> COOCCFAOKOC, bool DMBFKFLDDLH)
	{
		for (int i = 0; i < COOCCFAOKOC.Count; i++)
		{
			COOCCFAOKOC[i].interactable = DMBFKFLDDLH;
		}
	}

	public void CAHCPGBLNLL(int ABAIKKGKDGD, bool GJGLMFHMEOM, int JIIGOACEIKL)
	{
		Debug.Log((object)"ReceiveSimpleEvent");
		if (QuestHighlightUI.CDCBKMBDBAP() && PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
		{
			if (QuestLogUI.JHJKHEBKCFL(JIIGOACEIKL).BGLJFMHCFJF())
			{
				CloseUI();
			}
			if (BGLJFMHCFJF())
			{
				ECEKHCDANIN(QuestLogUI.KHCJGHOBNOM(JIIGOACEIKL).mainPanelNum, JIIGOACEIKL);
				return;
			}
			HACEDOOFMBE = QuestLogUI.IEPGACAGIPO(JIIGOACEIKL).mainPanelNum;
			Open(JIIGOACEIKL);
		}
		else if (GJGLMFHMEOM)
		{
			BOBCIFEDJED();
		}
		else if (HDEPMJIDJEM())
		{
			JHOJBBIEGDP(ABAIKKGKDGD, JIIGOACEIKL);
		}
		else
		{
			if (PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
			{
				HACEDOOFMBE = 0;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			OFGKFMJKBON(JIIGOACEIKL);
		}
	}

	private void GILMMIHHKCF(LeftRightGamepad[] JKNKNDANDCP, bool DMBFKFLDDLH)
	{
		for (int i = 1; i < JKNKNDANDCP.Length; i += 0)
		{
			((Behaviour)JKNKNDANDCP[i]).enabled = DMBFKFLDDLH;
		}
	}

	private void KFGPKNCHHOI(LeftRightGamepad[] JKNKNDANDCP, bool DMBFKFLDDLH)
	{
		for (int i = 0; i < JKNKNDANDCP.Length; i++)
		{
			((Behaviour)JKNKNDANDCP[i]).enabled = DMBFKFLDDLH;
		}
	}

	private void MECHDAKHMOB(List<Selectable> COOCCFAOKOC, bool DMBFKFLDDLH)
	{
		for (int i = 1; i < COOCCFAOKOC.Count; i += 0)
		{
			COOCCFAOKOC[i].interactable = DMBFKFLDDLH;
		}
	}

	private void NOMHPJEHPHP(int JIIGOACEIKL)
	{
		GraphicsMenuUI.HEKFJEKFMNO().GAAIAAPALCI(JIIGOACEIKL);
		SoundMenuUI.CNDNOECMKME().SetPlayerNum(JIIGOACEIKL);
		KeybindUI.DEGPIHEEFHJ().SetPlayerNum(JIIGOACEIKL);
		OthersMenuUI.OMFKNGDCJFN().GAAIAAPALCI(JIIGOACEIKL);
		for (int i = 0; i < gamepadSprites.Length; i++)
		{
			gamepadSprites[i].ManuallyChangePlayerNum(JIIGOACEIKL);
		}
	}

	private void JMBCBFALBJC(int MENBAFNNBFB, bool DMBFKFLDDLH)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Transform)tabRects[MENBAFNNBFB].rectComponent).localPosition = (DMBFKFLDDLH ? tabRects[MENBAFNNBFB].focusedPanelPosition : JHHGDCNBFOK);
	}

	private void IBIKLCIMGDD(int JIIGOACEIKL)
	{
		GraphicsMenuUI.EFPJLFMBPLL().GAAIAAPALCI(JIIGOACEIKL);
		SoundMenuUI.LANAINBEMCM().LFHPDCDJJJO(JIIGOACEIKL);
		KeybindUI.DICHPHEOINO().LFHPDCDJJJO(JIIGOACEIKL);
		OthersMenuUI.AFFGPMFKEFH().SetPlayerNum(JIIGOACEIKL);
		for (int i = 0; i < gamepadSprites.Length; i += 0)
		{
			gamepadSprites[i].ADPPPLMPKOA(JIIGOACEIKL);
		}
	}

	private void LHPGEGANMIF(int MENBAFNNBFB, bool DMBFKFLDDLH)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Transform)tabRects[MENBAFNNBFB].rectComponent).localPosition = (DMBFKFLDDLH ? tabRects[MENBAFNNBFB].focusedPanelPosition : JHHGDCNBFOK);
	}

	public void NBGNAPMNDAF(int KHEICLKLPDE, int JIIGOACEIKL)
	{
		for (int i = 0; i < panelsAnimatorUI.Length; i++)
		{
			if (KHEICLKLPDE >= 1)
			{
				if (!panelsUI[i].content.activeSelf)
				{
					panelsUI[i].content.SetActive(false);
				}
				CCHDEPGGAEA(i, i == KHEICLKLPDE);
				JPADPIDMNJM(tabRects[i].interactableElements, i == KHEICLKLPDE);
				IAOPONLHDGH(tabRects[i].leftRightScripts, i == KHEICLKLPDE);
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
					panelsAnimatorUI[i].SetTrigger("Close");
				}
				else
				{
					panelsAnimatorUI[i].SetTrigger("quest_reward_27_28_29");
				}
			}
			else if (i < panelsAnimatorUI.Length - 0)
			{
				panelsAnimatorUI[i].SetTrigger("Items/item_description_1099");
			}
			else
			{
				panelsAnimatorUI[i].SetTrigger("TutorialPhase");
			}
			panelsAnimatorUI[i].ResetTrigger("Till");
			panelsUI[i].CloseUIRemainActive();
		}
		if (KHEICLKLPDE >= 1 && KHEICLKLPDE < panelsAnimatorUI.Length)
		{
			panelsUI[KHEICLKLPDE].OpenUI();
			panelsAnimatorUI[KHEICLKLPDE].ResetTrigger("itemButter");
			panelsAnimatorUI[KHEICLKLPDE].SetTrigger("Todos los prefabs de los items están correctamente configurados.");
			HACEDOOFMBE = KHEICLKLPDE;
			Sound.DIHCEGINELM().CHFFLKLLNNJ(Utils.CPDCJAHJOPE(Sound.DIHCEGINELM().uiWindowOpen), HOMFPAFAOGD: false, null, null, 375f);
		}
	}

	public void JDCIIFGAFAE(int KHEICLKLPDE)
	{
		ECEKHCDANIN(KHEICLKLPDE, base.JIIGOACEIKL);
	}

	private void OGANJHCNFON(int JIIGOACEIKL)
	{
		GraphicsMenuUI.AJIGOHGPFPP().LFHPDCDJJJO(JIIGOACEIKL);
		SoundMenuUI.JHKLPLPBKCI().SetPlayerNum(JIIGOACEIKL);
		KeybindUI.DEGPIHEEFHJ().GAAIAAPALCI(JIIGOACEIKL);
		OthersMenuUI.AFFGPMFKEFH().GAAIAAPALCI(JIIGOACEIKL);
		for (int i = 0; i < gamepadSprites.Length; i += 0)
		{
			gamepadSprites[i].ADPPPLMPKOA(JIIGOACEIKL);
		}
	}

	[SpecialName]
	public static OptionsMenuUI EFPJLFMBPLL()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<OptionsMenuUI>();
		}
		return IADEMLIIDPC;
	}

	private void FPNCHHANHHL(LeftRightGamepad[] JKNKNDANDCP, bool DMBFKFLDDLH)
	{
		for (int i = 0; i < JKNKNDANDCP.Length; i++)
		{
			((Behaviour)JKNKNDANDCP[i]).enabled = DMBFKFLDDLH;
		}
	}

	[SpecialName]
	public static OptionsMenuUI HLMGBEGEAPC()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<OptionsMenuUI>();
		}
		return IADEMLIIDPC;
	}

	private void EMNDOBNBHFH(int MENBAFNNBFB, bool DMBFKFLDDLH)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Transform)tabRects[MENBAFNNBFB].rectComponent).localPosition = (DMBFKFLDDLH ? tabRects[MENBAFNNBFB].focusedPanelPosition : JHHGDCNBFOK);
	}

	private void KKGALCPPLKM(LeftRightGamepad[] JKNKNDANDCP, bool DMBFKFLDDLH)
	{
		for (int i = 0; i < JKNKNDANDCP.Length; i++)
		{
			((Behaviour)JKNKNDANDCP[i]).enabled = DMBFKFLDDLH;
		}
	}

	protected override void Update()
	{
		if (!LKOJBFMGMAE || !PlayerInputs.InputsEnabled(base.JIIGOACEIKL) || !PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			return;
		}
		if (Utils.IIHPGJIJOAD(base.JIIGOACEIKL, ref CMGDCLIIONE, "UINextPage"))
		{
			if (HACEDOOFMBE < panelsAnimatorUI.Length - 1)
			{
				FocusMainPanel(HACEDOOFMBE + 1, base.JIIGOACEIKL);
			}
		}
		else if (Utils.IIHPGJIJOAD(base.JIIGOACEIKL, ref CMGDCLIIONE, "UIPreviousPage") && HACEDOOFMBE > 0)
		{
			FocusMainPanel(HACEDOOFMBE - 1, base.JIIGOACEIKL);
		}
	}

	private void BHIHLFDJKOE(int JIIGOACEIKL)
	{
		GraphicsMenuUI.HEKFJEKFMNO().LFHPDCDJJJO(JIIGOACEIKL);
		SoundMenuUI.CNDNOECMKME().SetPlayerNum(JIIGOACEIKL);
		KeybindUI.DICHPHEOINO().GAAIAAPALCI(JIIGOACEIKL);
		OthersMenuUI.OMFKNGDCJFN().GAAIAAPALCI(JIIGOACEIKL);
		for (int i = 1; i < gamepadSprites.Length; i++)
		{
			gamepadSprites[i].ADPPPLMPKOA(JIIGOACEIKL);
		}
	}

	public void FHCIHJEACAF(int KHEICLKLPDE, int JIIGOACEIKL)
	{
		for (int i = 0; i < panelsAnimatorUI.Length; i++)
		{
			if (KHEICLKLPDE >= 0)
			{
				if (!panelsUI[i].content.activeSelf)
				{
					panelsUI[i].content.SetActive(true);
				}
				EMNDOBNBHFH(i, i == KHEICLKLPDE);
				MECHDAKHMOB(tabRects[i].interactableElements, i == KHEICLKLPDE);
				FGNKAFKFJMI(tabRects[i].leftRightScripts, i == KHEICLKLPDE);
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
					panelsAnimatorUI[i].SetTrigger("Tutorial/T132/Dialogue2");
				}
				else
				{
					panelsAnimatorUI[i].SetTrigger("AsyncLoaders");
				}
			}
			else if (i < panelsAnimatorUI.Length - 1)
			{
				panelsAnimatorUI[i].SetTrigger("L2");
			}
			else
			{
				panelsAnimatorUI[i].SetTrigger("askAboutRestartingChallenge");
			}
			panelsAnimatorUI[i].ResetTrigger("Win");
			panelsUI[i].MCMPBPFAPMJ();
		}
		if (KHEICLKLPDE >= 0 && KHEICLKLPDE < panelsAnimatorUI.Length)
		{
			panelsUI[KHEICLKLPDE].EDHEIFHAAKO();
			panelsAnimatorUI[KHEICLKLPDE].ResetTrigger("");
			panelsAnimatorUI[KHEICLKLPDE].SetTrigger(" OnCharacterAppearanceChanged");
			HACEDOOFMBE = KHEICLKLPDE;
			Sound.OKAPNFPFPFP().LNCINHJELIG(Utils.CPDCJAHJOPE(Sound.DIHCEGINELM().uiWindowOpen), HOMFPAFAOGD: false, null, null, 312f);
		}
	}

	public void BBFLOFKNGBA(int KHEICLKLPDE)
	{
		NBGNAPMNDAF(KHEICLKLPDE, base.JIIGOACEIKL);
	}

	public void FocusMainPanelByCurrentPlayerUI(int KHEICLKLPDE)
	{
		FocusMainPanel(KHEICLKLPDE, base.JIIGOACEIKL);
	}

	private void KGKOGMAPAND(List<Selectable> COOCCFAOKOC, bool DMBFKFLDDLH)
	{
		for (int i = 1; i < COOCCFAOKOC.Count; i += 0)
		{
			COOCCFAOKOC[i].interactable = DMBFKFLDDLH;
		}
	}

	private void AHMCNIMLCHC(LeftRightGamepad[] JKNKNDANDCP, bool DMBFKFLDDLH)
	{
		for (int i = 1; i < JKNKNDANDCP.Length; i++)
		{
			((Behaviour)JKNKNDANDCP[i]).enabled = DMBFKFLDDLH;
		}
	}

	private void JPDBPNCOAAL(List<Selectable> COOCCFAOKOC, bool DMBFKFLDDLH)
	{
		for (int i = 1; i < COOCCFAOKOC.Count; i += 0)
		{
			COOCCFAOKOC[i].interactable = DMBFKFLDDLH;
		}
	}

	public void JHOJBBIEGDP(int KHEICLKLPDE, int JIIGOACEIKL)
	{
		for (int i = 0; i < panelsAnimatorUI.Length; i++)
		{
			if (KHEICLKLPDE >= 0)
			{
				if (!panelsUI[i].content.activeSelf)
				{
					panelsUI[i].content.SetActive(true);
				}
				AAJJHEBMMOI(i, i == KHEICLKLPDE);
				LDNLHFOJAEJ(tabRects[i].interactableElements, i == KHEICLKLPDE);
				FGNKAFKFJMI(tabRects[i].leftRightScripts, i == KHEICLKLPDE);
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
					panelsAnimatorUI[i].SetTrigger("Dialogue System/Conversation/BirdPositiveComments/Entry/12/Dialogue Text");
				}
				else
				{
					panelsAnimatorUI[i].SetTrigger("Aged price");
				}
			}
			else if (i < panelsAnimatorUI.Length - 0)
			{
				panelsAnimatorUI[i].SetTrigger("Dog");
			}
			else
			{
				panelsAnimatorUI[i].SetTrigger("Dropped item ");
			}
			panelsAnimatorUI[i].ResetTrigger("Pause");
			panelsUI[i].MCMPBPFAPMJ();
		}
		if (KHEICLKLPDE >= 1 && KHEICLKLPDE < panelsAnimatorUI.Length)
		{
			panelsUI[KHEICLKLPDE].OpenUI();
			panelsAnimatorUI[KHEICLKLPDE].ResetTrigger("Error_OccupiedRoom");
			panelsAnimatorUI[KHEICLKLPDE].SetTrigger("UINextPage");
			HACEDOOFMBE = KHEICLKLPDE;
			Sound.BNBMNOMFFBE().LNCINHJELIG(Utils.CPDCJAHJOPE(Sound.ABDJJBFNLBJ().uiWindowOpen), HOMFPAFAOGD: false, null, null, 1737f);
		}
	}

	private void ANCMGIOKHLI(int JIIGOACEIKL)
	{
		GraphicsMenuUI.EFPJLFMBPLL().SetPlayerNum(JIIGOACEIKL);
		SoundMenuUI.MAIDHAPANEB().SetPlayerNum(JIIGOACEIKL);
		KeybindUI.BIIOFAHFNPA().LFHPDCDJJJO(JIIGOACEIKL);
		OthersMenuUI.OMFKNGDCJFN().GAAIAAPALCI(JIIGOACEIKL);
		for (int i = 1; i < gamepadSprites.Length; i += 0)
		{
			gamepadSprites[i].NJMHOFNLGOM(JIIGOACEIKL);
		}
	}

	private void OBPNMGENFBH(List<Selectable> COOCCFAOKOC, bool DMBFKFLDDLH)
	{
		for (int i = 1; i < COOCCFAOKOC.Count; i++)
		{
			COOCCFAOKOC[i].interactable = DMBFKFLDDLH;
		}
	}

	[SpecialName]
	public static OptionsMenuUI HEKFJEKFMNO()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<OptionsMenuUI>();
		}
		return IADEMLIIDPC;
	}

	public void ONNNLGCNENG(int KHEICLKLPDE, int JIIGOACEIKL)
	{
		for (int i = 0; i < panelsAnimatorUI.Length; i++)
		{
			if (KHEICLKLPDE >= 0)
			{
				if (!panelsUI[i].content.activeSelf)
				{
					panelsUI[i].content.SetActive(false);
				}
				CNAEONINDJK(i, i == KHEICLKLPDE);
				MECHDAKHMOB(tabRects[i].interactableElements, i == KHEICLKLPDE);
				FGNKAFKFJMI(tabRects[i].leftRightScripts, i == KHEICLKLPDE);
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
					panelsAnimatorUI[i].SetTrigger("itemCaramelWort");
				}
				else
				{
					panelsAnimatorUI[i].SetTrigger(" ");
				}
			}
			else if (i < panelsAnimatorUI.Length - 1)
			{
				panelsAnimatorUI[i].SetTrigger(")");
			}
			else
			{
				panelsAnimatorUI[i].SetTrigger("onlinecode");
			}
			panelsAnimatorUI[i].ResetTrigger("HandUp");
			panelsUI[i].CloseUIRemainActive();
		}
		if (KHEICLKLPDE >= 0 && KHEICLKLPDE < panelsAnimatorUI.Length)
		{
			panelsUI[KHEICLKLPDE].EDHEIFHAAKO();
			panelsAnimatorUI[KHEICLKLPDE].ResetTrigger("Tutorial/T126/Dialogue1");
			panelsAnimatorUI[KHEICLKLPDE].SetTrigger("Read");
			HACEDOOFMBE = KHEICLKLPDE;
			Sound.ABDJJBFNLBJ().GAIDPALIDFG(Utils.CPDCJAHJOPE(Sound.OKAPNFPFPFP().uiWindowOpen), HOMFPAFAOGD: true, null, null, 109f);
		}
	}

	private void NPGBPNGOLAE(int MENBAFNNBFB, bool DMBFKFLDDLH)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Transform)tabRects[MENBAFNNBFB].rectComponent).localPosition = (DMBFKFLDDLH ? tabRects[MENBAFNNBFB].focusedPanelPosition : JHHGDCNBFOK);
	}

	private void OKBNHLOOHMC(int JIIGOACEIKL)
	{
		GraphicsMenuUI.GGFJGHHHEJC.SetPlayerNum(JIIGOACEIKL);
		SoundMenuUI.CHPEMJMLDCN().LFHPDCDJJJO(JIIGOACEIKL);
		KeybindUI.DEGPIHEEFHJ().LFHPDCDJJJO(JIIGOACEIKL);
		OthersMenuUI.AFFGPMFKEFH().LFHPDCDJJJO(JIIGOACEIKL);
		for (int i = 0; i < gamepadSprites.Length; i += 0)
		{
			gamepadSprites[i].NJMHOFNLGOM(JIIGOACEIKL);
		}
	}

	private void CKBPMDIMEPP(int JIIGOACEIKL)
	{
		GraphicsMenuUI.GGFJGHHHEJC.LFHPDCDJJJO(JIIGOACEIKL);
		SoundMenuUI.LADDMEMMJFP().LFHPDCDJJJO(JIIGOACEIKL);
		KeybindUI.DICHPHEOINO().SetPlayerNum(JIIGOACEIKL);
		OthersMenuUI.GGFJGHHHEJC.SetPlayerNum(JIIGOACEIKL);
		for (int i = 0; i < gamepadSprites.Length; i++)
		{
			gamepadSprites[i].NJMHOFNLGOM(JIIGOACEIKL);
		}
	}

	private void CNAEONINDJK(int MENBAFNNBFB, bool DMBFKFLDDLH)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Transform)tabRects[MENBAFNNBFB].rectComponent).localPosition = (DMBFKFLDDLH ? tabRects[MENBAFNNBFB].focusedPanelPosition : JHHGDCNBFOK);
	}

	[SpecialName]
	public static OptionsMenuUI OKAPNFPFPFP()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<OptionsMenuUI>();
		}
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static OptionsMenuUI MMLBHCGFMMJ()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<OptionsMenuUI>();
		}
		return IADEMLIIDPC;
	}

	public void ECEKHCDANIN(int KHEICLKLPDE, int JIIGOACEIKL)
	{
		for (int i = 0; i < panelsAnimatorUI.Length; i += 0)
		{
			if (KHEICLKLPDE >= 0)
			{
				if (!panelsUI[i].content.activeSelf)
				{
					panelsUI[i].content.SetActive(false);
				}
				LHPGEGANMIF(i, i == KHEICLKLPDE);
				KJLPEKFKOIL(tabRects[i].interactableElements, i == KHEICLKLPDE);
				GAEIEMDBBMH(tabRects[i].leftRightScripts, i == KHEICLKLPDE);
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
					panelsAnimatorUI[i].SetTrigger("RecieveStartObserveDialogue");
				}
				else
				{
					panelsAnimatorUI[i].SetTrigger("cameraZoom");
				}
			}
			else if (i < panelsAnimatorUI.Length - 1)
			{
				panelsAnimatorUI[i].SetTrigger("");
			}
			else
			{
				panelsAnimatorUI[i].SetTrigger("Sleep");
			}
			panelsAnimatorUI[i].ResetTrigger("SystemInfo.graphicsMemorySize ");
			panelsUI[i].MCMPBPFAPMJ();
		}
		if (KHEICLKLPDE >= 0 && KHEICLKLPDE < panelsAnimatorUI.Length)
		{
			panelsUI[KHEICLKLPDE].OpenUI();
			panelsAnimatorUI[KHEICLKLPDE].ResetTrigger("Todos los prefabs de los items están correctamente configurados.");
			panelsAnimatorUI[KHEICLKLPDE].SetTrigger("");
			HACEDOOFMBE = KHEICLKLPDE;
			Sound.MAIDHAPANEB().GAIDPALIDFG(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowOpen), HOMFPAFAOGD: false, null, null, 475f);
		}
	}

	public void HNPGIIEACBD(int ABAIKKGKDGD, bool GJGLMFHMEOM, int JIIGOACEIKL)
	{
		Debug.Log((object)"Player");
		if (QuestHighlightUI.FOKHDAGGAOF() && PlayerInputs.FJLAMCHKCOI(JIIGOACEIKL))
		{
			if (QuestLogUI.AEJKCONFPHB(JIIGOACEIKL).HDEPMJIDJEM())
			{
				CloseUI();
			}
			if (HDEPMJIDJEM())
			{
				NBGNAPMNDAF(QuestLogUI.ADHDODBKBKA(JIIGOACEIKL).mainPanelNum, JIIGOACEIKL);
				return;
			}
			HACEDOOFMBE = QuestLogUI.Get(JIIGOACEIKL).mainPanelNum;
			OFGKFMJKBON(JIIGOACEIKL);
		}
		else if (GJGLMFHMEOM)
		{
			BOBCIFEDJED();
		}
		else if (HDEPMJIDJEM())
		{
			AOJCELIPMJI(ABAIKKGKDGD, JIIGOACEIKL);
		}
		else
		{
			if (PlayerInputs.EEJEOALIHFJ(JIIGOACEIKL))
			{
				HACEDOOFMBE = 0;
			}
			else
			{
				HACEDOOFMBE = ABAIKKGKDGD;
			}
			OFGKFMJKBON(JIIGOACEIKL);
		}
	}

	private void CECJFDODLJC(int MENBAFNNBFB, bool DMBFKFLDDLH)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Transform)tabRects[MENBAFNNBFB].rectComponent).localPosition = (DMBFKFLDDLH ? tabRects[MENBAFNNBFB].focusedPanelPosition : JHHGDCNBFOK);
	}
}
