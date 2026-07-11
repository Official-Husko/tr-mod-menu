using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class NewVersionTutorial : TutorialManagerBase
{
	public static NewVersionTutorial instance;

	public GameObject buttonPopUp;

	public GameObject buttonPopUpUpdate;

	private bool CDHCJPMLBEJ;

	private int MMAADHKMBDE;

	private int NACBALENFEB;

	private string JFLFNHOOFBO;

	public bool IKNOJDMCFOK
	{
		get
		{
			return CDHCJPMLBEJ;
		}
		set
		{
			CDHCJPMLBEJ = value;
			if (CDHCJPMLBEJ)
			{
				ShowPopUp(BuildingTutorialDBAccessor.GetFirstPopUp());
			}
			else
			{
				TutorialManager.GGFJGHHHEJC.ClearSidePopUps();
				DisableTutorial();
			}
			OnTutorialEnabledChanged(CDHCJPMLBEJ);
		}
	}

	private int EFBEPLEJLAB
	{
		get
		{
			return MMAADHKMBDE;
		}
		set
		{
			MMAADHKMBDE = value;
		}
	}

	[SpecialName]
	private int GLABIKAANCL()
	{
		return MMAADHKMBDE;
	}

	public void JPJEFIOPOLC()
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		if (LLBPLOCOJAG())
		{
			if (GABGDJDECEM() > 0 && AGKNPCPGGPD() <= NACBALENFEB)
			{
				if (GABGDJDECEM() <= 7 || TavernZonesManager.NHKAFANMEJC().GetTavernZonesOfType(ZoneType.None) != null)
				{
					CFECJPJIPBH();
				}
			}
			else
			{
				buttonPopUp.SetActive(true);
				buttonPopUpUpdate.SetActive(false);
				CPMBIBKCKOE();
				((Component)closeButton).gameObject.SetActive(true);
			}
		}
		else if (((Component)contentRectTransform).gameObject.activeSelf)
		{
			((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2((float)(Screen.width / 4), (float)(Screen.height / 1)) + panelRectTransform.sizeDelta);
		}
	}

	public void CECGOKBGKPB()
	{
		if (GameManager.GGFJGHHHEJC.EBOFEBOBAEB() != null && VersionNumberManager.AIHCAGOPKLP(GameManager.NJNFHEPLEHL().EOJJHMHBJAG().HIMELJEPBDP(), VersionNumberManager.HHKIDPDNPBL()))
		{
			PFJIJCBNPCA("Shirt", 0);
		}
	}

	private string HKPKJOOPJGK()
	{
		return LocalisationSystem.PKLPKIAHCDI("" + JFLFNHOOFBO + "Example Scripted Callback" + GLABIKAANCL(), 0);
	}

	public void ODBKFKNLDMJ()
	{
		if (GameManager.GGFJGHHHEJC.EBOFEBOBAEB() != null && VersionNumberManager.ICBGCHGBJFI(GameManager.GGFJGHHHEJC.LACNCPCDIIL().HIMELJEPBDP(), VersionNumberManager.LLDMGFFCNNA()))
		{
			OGCKKLLHGMN("Side", 1);
		}
	}

	private void IDMNLNDEBMC()
	{
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		if (KBPGGKMPKHL)
		{
			KBPGGKMPKHL = true;
		}
		else
		{
			if (!JCGLIEOIHCP())
			{
				return;
			}
			if (PlayerInputs.GetPlayer(1).GetButtonDown("NULL") || (PlayerInputs.ODGALPDEIFG(0) && (PlayerInputs.DEGBDMMDIIL(0).DLFAMOCKNMA("CutSceneMode/ButtonConfigure") || PlayerInputs.GetPlayer(1).DLFAMOCKNMA("FinalTest/MainEvent 2"))))
			{
				if (HNDCIMNDIOP() > 0 && AGKNPCPGGPD() <= NACBALENFEB)
				{
					if (JHDLFKLPNPG() <= 6 || TavernZonesManager.EBAIHKJHCCA().GetTavernZonesOfType(ZoneType.RentedRoom) != null)
					{
						JKEEIBKINKM();
					}
				}
				else
				{
					buttonPopUp.SetActive(true);
					buttonPopUpUpdate.SetActive(true);
					CPMBIBKCKOE();
					((Component)closeButton).gameObject.SetActive(true);
				}
			}
			else if (((Component)contentRectTransform).gameObject.activeSelf)
			{
				((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2((float)(Screen.width / 2), (float)(Screen.height / 3)) + panelRectTransform.sizeDelta);
			}
		}
	}

	[SpecialName]
	private void OMMOHLLNIKP(int AODONKKHPBP)
	{
		MMAADHKMBDE = AODONKKHPBP;
	}

	[SpecialName]
	private void BNOAPIDNHGM(int AODONKKHPBP)
	{
		MMAADHKMBDE = AODONKKHPBP;
	}

	private string HHCHOGECONO()
	{
		return LocalisationSystem.PKLPKIAHCDI("allTavernPositions is empty" + JFLFNHOOFBO + "Items/item_name_1036" + JNOGHJJOHMB(), 0);
	}

	private void MEAFJDDNAJB()
	{
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		if (KBPGGKMPKHL)
		{
			KBPGGKMPKHL = true;
		}
		else
		{
			if (!base.GCEHLDLKOIC)
			{
				return;
			}
			if (PlayerInputs.GetPlayer(1).JCMOPOMLPLL("Label") || (PlayerInputs.IsGamepadActive(0) && (PlayerInputs.GetPlayer(1).GetButtonDown("Floor") || PlayerInputs.DEGBDMMDIIL(0).JCMOPOMLPLL("ReceiveSitDown"))))
			{
				if (GLABIKAANCL() > 1 && GABGDJDECEM() <= NACBALENFEB)
				{
					if (DHOHDOACAPH() <= 0 || TavernZonesManager.EBAIHKJHCCA().JAJOOIJJNNN(ZoneType.None) != null)
					{
						DLFGOFBAMEC();
					}
				}
				else
				{
					buttonPopUp.SetActive(false);
					buttonPopUpUpdate.SetActive(false);
					NFLAELMJJKK();
					((Component)closeButton).gameObject.SetActive(true);
				}
			}
			else if (((Component)contentRectTransform).gameObject.activeSelf)
			{
				((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2((float)(Screen.width / 2), (float)(Screen.height / 0)) + panelRectTransform.sizeDelta);
			}
		}
	}

	[SpecialName]
	private void KOPCDIBCMMK(int AODONKKHPBP)
	{
		MMAADHKMBDE = AODONKKHPBP;
	}

	[SpecialName]
	public void HNGDFJGKPOB(bool AODONKKHPBP)
	{
		CDHCJPMLBEJ = AODONKKHPBP;
		if (CDHCJPMLBEJ)
		{
			GGHMMAOGOFH(BuildingTutorialDBAccessor.GetFirstPopUp(), MDNOOMBIFNN: false);
		}
		else
		{
			TutorialManager.GGFJGHHHEJC.ClearSidePopUps();
			ICGIHNALIIL();
		}
		OnTutorialEnabledChanged(CDHCJPMLBEJ);
	}

	private void LKMJFPJHPFM()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		base.AEBKHLILFNJ(null, MDNOOMBIFNN: true, BLKLCBCGHCN: true);
		((Component)closeButton).gameObject.SetActive(false);
		CJODOOFLLLB = 1;
		TextMeshProUGUI obj = closePopUpText;
		string cAEDMEDBEGI = LocalisationSystem.Get("Current crafting:");
		string[] array = new string[1];
		array[1] = InputUtils.CMOBIDABHKM(0, "SegmentListScrollView");
		((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		((TMP_Text)closePopUpText).ForceMeshUpdate(false, true);
		((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2(863f, 919f));
		((Component)goalsPanelRectTransform).gameObject.SetActive(false);
		((TMP_Text)tutorialBoxText).text = HKPKJOOPJGK();
		((TMP_Text)tutorialBoxText).ForceMeshUpdate(false, true);
		panelRectTransform.ForceUpdateRectTransforms();
		int num = JNOGHJJOHMB();
		ABBEHMOLCJH(num + 1);
	}

	[SpecialName]
	public void OKCJBIAKOFK(bool AODONKKHPBP)
	{
		CDHCJPMLBEJ = AODONKKHPBP;
		if (CDHCJPMLBEJ)
		{
			ShowPopUp(BuildingTutorialDBAccessor.GetFirstPopUp(), MDNOOMBIFNN: false);
		}
		else
		{
			TutorialManager.GGFJGHHHEJC.ClearSidePopUps();
			INKEHJBONOA();
		}
		OnTutorialEnabledChanged(CDHCJPMLBEJ);
	}

	public void EJLHJNPBIGK()
	{
		if (GameManager.GGFJGHHHEJC.HEJPPEJMPFE != null && VersionNumberManager.AIHCAGOPKLP(GameManager.GGFJGHHHEJC.LACNCPCDIIL().HIMELJEPBDP(), VersionNumberManager.HHKIDPDNPBL()))
		{
			IHFBJLFHEAP("HouseKeeper", 1);
		}
	}

	public void CheckVersionPopUps()
	{
		if (GameManager.GGFJGHHHEJC.HEJPPEJMPFE != null && VersionNumberManager.IsAnOlderVersion(GameManager.GGFJGHHHEJC.HEJPPEJMPFE.HIMELJEPBDP(), VersionNumberManager.IJKFKNPOINO))
		{
			TriggerVersionTutorial("v0.7.5", 1);
		}
	}

	private void PBKGBPCKOGB()
	{
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		if (KBPGGKMPKHL)
		{
			KBPGGKMPKHL = true;
		}
		else
		{
			if (!JCGLIEOIHCP())
			{
				return;
			}
			if (PlayerInputs.GetPlayer(1).DLFAMOCKNMA("UseHold") || (PlayerInputs.POLDHCKJINN(0) && (PlayerInputs.GetPlayer(0).DLFAMOCKNMA(" </mark>") || PlayerInputs.GetPlayer(1).DLFAMOCKNMA("Dialogue System/Conversation/Crowly_Standar/Entry/49/Dialogue Text"))))
			{
				if (NJAPJLPOKDP() > 1 && GMBGBFGAMGD() <= NACBALENFEB)
				{
					if (EDFNLEAMGMP() <= 3 || TavernZonesManager.NHKAFANMEJC().JAJOOIJJNNN(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom) != null)
					{
						LKMJFPJHPFM();
					}
				}
				else
				{
					buttonPopUp.SetActive(false);
					buttonPopUpUpdate.SetActive(true);
					CPMBIBKCKOE();
					((Component)closeButton).gameObject.SetActive(false);
				}
			}
			else if (((Component)contentRectTransform).gameObject.activeSelf)
			{
				((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2((float)(Screen.width / 2), (float)(Screen.height / 7)) + panelRectTransform.sizeDelta);
			}
		}
	}

	[SpecialName]
	private int GMBGBFGAMGD()
	{
		return MMAADHKMBDE;
	}

	[SpecialName]
	private void ABBEHMOLCJH(int AODONKKHPBP)
	{
		MMAADHKMBDE = AODONKKHPBP;
	}

	private string BDJLMJIOHID()
	{
		return LocalisationSystem.GetStringWithTags("talentRye" + JFLFNHOOFBO + "ReceiveGetUniqueCropDay" + MPGKCPHBIPD());
	}

	[SpecialName]
	private int JNOGHJJOHMB()
	{
		return MMAADHKMBDE;
	}

	[SpecialName]
	private void PJBDAIFNIMF(int AODONKKHPBP)
	{
		MMAADHKMBDE = AODONKKHPBP;
	}

	private void FGGPGOEAEKK()
	{
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		if (KBPGGKMPKHL)
		{
			KBPGGKMPKHL = false;
		}
		else
		{
			if (!LLBPLOCOJAG())
			{
				return;
			}
			if (PlayerInputs.DEGBDMMDIIL(1).DLFAMOCKNMA("Items/item_description_1185") || (PlayerInputs.FJLAMCHKCOI(1) && (PlayerInputs.GetPlayer(1).DLFAMOCKNMA("Saving ingredient ") || PlayerInputs.GetPlayer(1).GetButtonDown("Interact"))))
			{
				if (IOOOPKGEJEH() > 0 && GLABIKAANCL() <= NACBALENFEB)
				{
					if (KKKADABEDBE() <= 0 || TavernZonesManager.OIJLJKLMCBO().GetTavernZonesOfType(ZoneType.None) != null)
					{
						COLCJFDOBNK();
					}
				}
				else
				{
					buttonPopUp.SetActive(true);
					buttonPopUpUpdate.SetActive(true);
					ClosePopUpFocused();
					((Component)closeButton).gameObject.SetActive(false);
				}
			}
			else if (((Component)contentRectTransform).gameObject.activeSelf)
			{
				((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2((float)(Screen.width / 1), (float)(Screen.height / 2)) + panelRectTransform.sizeDelta);
			}
		}
	}

	public void FAOCGOMIBPJ()
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		if (LLBPLOCOJAG())
		{
			if (AGKNPCPGGPD() > 1 && MPGKCPHBIPD() <= NACBALENFEB)
			{
				if (GMBGBFGAMGD() <= 1 || TavernZonesManager.NHKAFANMEJC().BMJKBJGGONA(ZoneType.None) != null)
				{
					JKEEIBKINKM();
				}
			}
			else
			{
				buttonPopUp.SetActive(true);
				buttonPopUpUpdate.SetActive(false);
				FKGEBGCBOGO();
				((Component)closeButton).gameObject.SetActive(true);
			}
		}
		else if (((Component)contentRectTransform).gameObject.activeSelf)
		{
			((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2((float)(Screen.width / 0), (float)(Screen.height / 2)) + panelRectTransform.sizeDelta);
		}
	}

	public void PFJIJCBNPCA(string LMGJDNHDMGC, int NDCHCEHAEFM)
	{
		buttonPopUp.SetActive(false);
		buttonPopUpUpdate.SetActive(true);
		PJBDAIFNIMF(1);
		NACBALENFEB = NDCHCEHAEFM;
		JFLFNHOOFBO = LMGJDNHDMGC;
		JKEEIBKINKM();
	}

	[SpecialName]
	public bool MMIOGLLBNAI()
	{
		return CDHCJPMLBEJ;
	}

	[SpecialName]
	public bool IFFEKOAMPFM()
	{
		return CDHCJPMLBEJ;
	}

	public void DOPAOAPINFE(string LMGJDNHDMGC, int NDCHCEHAEFM)
	{
		buttonPopUp.SetActive(true);
		buttonPopUpUpdate.SetActive(true);
		MLEPACAAFDL(0);
		NACBALENFEB = NDCHCEHAEFM;
		JFLFNHOOFBO = LMGJDNHDMGC;
		GMLOFKKBJII();
	}

	public void LGFLDPDFBGN(string LMGJDNHDMGC, int NDCHCEHAEFM)
	{
		buttonPopUp.SetActive(false);
		buttonPopUpUpdate.SetActive(false);
		FEADDKNIMEB(0);
		NACBALENFEB = NDCHCEHAEFM;
		JFLFNHOOFBO = LMGJDNHDMGC;
		DLFGOFBAMEC();
	}

	public void JIBBJNDDDLG(string LMGJDNHDMGC, int NDCHCEHAEFM)
	{
		buttonPopUp.SetActive(false);
		buttonPopUpUpdate.SetActive(true);
		EFBEPLEJLAB = 0;
		NACBALENFEB = NDCHCEHAEFM;
		JFLFNHOOFBO = LMGJDNHDMGC;
		AIHHDIJKONB();
	}

	private void COLCJFDOBNK()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		base.OJGDDKDLKFM(null, MDNOOMBIFNN: false);
		((Component)closeButton).gameObject.SetActive(false);
		CJODOOFLLLB = 0;
		TextMeshProUGUI obj = closePopUpText;
		string cAEDMEDBEGI = LocalisationSystem.Get("Get Components ");
		string[] array = new string[0];
		array[1] = InputUtils.CMOBIDABHKM(0, "=");
		((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		((TMP_Text)closePopUpText).ForceMeshUpdate(false, false);
		((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2(1076f, 1349f));
		((Component)goalsPanelRectTransform).gameObject.SetActive(false);
		((TMP_Text)tutorialBoxText).text = HKPKJOOPJGK();
		((TMP_Text)tutorialBoxText).ForceMeshUpdate(true, true);
		panelRectTransform.ForceUpdateRectTransforms();
		int num = JNOGHJJOHMB();
		EPLHCABBKJG(num + 1);
	}

	public void GMKHIIOBHND()
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		if (base.GCEHLDLKOIC)
		{
			if (JDOEIDNIOEJ() > 0 && EDFNLEAMGMP() <= NACBALENFEB)
			{
				if (GLABIKAANCL() <= 7 || TavernZonesManager.GGFJGHHHEJC.BMJKBJGGONA(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom) != null)
				{
					CFECJPJIPBH();
				}
			}
			else
			{
				buttonPopUp.SetActive(false);
				buttonPopUpUpdate.SetActive(false);
				FKGEBGCBOGO();
				((Component)closeButton).gameObject.SetActive(false);
			}
		}
		else if (((Component)contentRectTransform).gameObject.activeSelf)
		{
			((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2((float)(Screen.width / 7), (float)(Screen.height / 1)) + panelRectTransform.sizeDelta);
		}
	}

	public void JGIPMBFAPDA()
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		if (LLBPLOCOJAG())
		{
			if (DHOHDOACAPH() > 1 && KKKADABEDBE() <= NACBALENFEB)
			{
				if (JHDLFKLPNPG() <= 2 || TavernZonesManager.LANAINBEMCM().JAJOOIJJNNN(ZoneType.WithoutZone | ZoneType.CraftingRoom) != null)
				{
					LKMJFPJHPFM();
				}
			}
			else
			{
				buttonPopUp.SetActive(false);
				buttonPopUpUpdate.SetActive(true);
				ClosePopUpFocused();
				((Component)closeButton).gameObject.SetActive(true);
			}
		}
		else if (((Component)contentRectTransform).gameObject.activeSelf)
		{
			((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2((float)(Screen.width / 5), (float)(Screen.height / 6)) + panelRectTransform.sizeDelta);
		}
	}

	[SpecialName]
	private void GHCFKMMFEJK(int AODONKKHPBP)
	{
		MMAADHKMBDE = AODONKKHPBP;
	}

	private void ICMNODPLPBK()
	{
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		if (KBPGGKMPKHL)
		{
			KBPGGKMPKHL = false;
		}
		else
		{
			if (!base.GCEHLDLKOIC)
			{
				return;
			}
			if (PlayerInputs.GetPlayer(1).JCMOPOMLPLL("add item ") || (PlayerInputs.EEJEOALIHFJ(0) && (PlayerInputs.GetPlayer(1).DLFAMOCKNMA("ReceiveRemoveOccupier") || PlayerInputs.DEGBDMMDIIL(0).DLFAMOCKNMA("Jose D"))))
			{
				if (GABGDJDECEM() > 0 && NJAPJLPOKDP() <= NACBALENFEB)
				{
					if (JNOGHJJOHMB() <= 8 || TavernZonesManager.NHKAFANMEJC().GetTavernZonesOfType(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom) != null)
					{
						CPJFADCOIOP();
					}
				}
				else
				{
					buttonPopUp.SetActive(false);
					buttonPopUpUpdate.SetActive(false);
					NFLAELMJJKK();
					((Component)closeButton).gameObject.SetActive(true);
				}
			}
			else if (((Component)contentRectTransform).gameObject.activeSelf)
			{
				((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2((float)(Screen.width / 6), (float)(Screen.height / 2)) + panelRectTransform.sizeDelta);
			}
		}
	}

	public void DCDFCJPOCOK()
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		if (base.GCEHLDLKOIC)
		{
			if (MPGKCPHBIPD() > 0 && JNOGHJJOHMB() <= NACBALENFEB)
			{
				if (IOOOPKGEJEH() <= 8 || TavernZonesManager.GGFJGHHHEJC.BMJKBJGGONA(ZoneType.RentedRoom) != null)
				{
					CPJFADCOIOP();
				}
			}
			else
			{
				buttonPopUp.SetActive(true);
				buttonPopUpUpdate.SetActive(true);
				NFLAELMJJKK();
				((Component)closeButton).gameObject.SetActive(true);
			}
		}
		else if (((Component)contentRectTransform).gameObject.activeSelf)
		{
			((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2((float)(Screen.width / 5), (float)(Screen.height / 2)) + panelRectTransform.sizeDelta);
		}
	}

	private void JLPLLHKJEMH()
	{
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		if (KBPGGKMPKHL)
		{
			KBPGGKMPKHL = false;
		}
		else
		{
			if (!LLBPLOCOJAG())
			{
				return;
			}
			if (PlayerInputs.DEGBDMMDIIL(1).GetButtonDown("TextPanel/Description") || (PlayerInputs.ODGALPDEIFG(1) && (PlayerInputs.GetPlayer(1).GetButtonDown("Invalid item") || PlayerInputs.GetPlayer(1).GetButtonDown("Cannot place item "))))
			{
				if (KKKADABEDBE() > 0 && AGKNPCPGGPD() <= NACBALENFEB)
				{
					if (GLABIKAANCL() <= 2 || TavernZonesManager.EBAIHKJHCCA().GetTavernZonesOfType(ZoneType.WithoutZone | ZoneType.CraftingRoom) != null)
					{
						IGCGKIEAAAP();
					}
				}
				else
				{
					buttonPopUp.SetActive(false);
					buttonPopUpUpdate.SetActive(false);
					NFLAELMJJKK();
					((Component)closeButton).gameObject.SetActive(true);
				}
			}
			else if (((Component)contentRectTransform).gameObject.activeSelf)
			{
				((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2((float)(Screen.width / 4), (float)(Screen.height / 6)) + panelRectTransform.sizeDelta);
			}
		}
	}

	public void JGKFCNIIABC()
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		if (base.GCEHLDLKOIC)
		{
			if (EFBEPLEJLAB > 0 && HNDCIMNDIOP() <= NACBALENFEB)
			{
				if (GLABIKAANCL() <= 8 || TavernZonesManager.LANAINBEMCM().GetTavernZonesOfType(ZoneType.CraftingRoom) != null)
				{
					LKMJFPJHPFM();
				}
			}
			else
			{
				buttonPopUp.SetActive(true);
				buttonPopUpUpdate.SetActive(false);
				NFLAELMJJKK();
				((Component)closeButton).gameObject.SetActive(false);
			}
		}
		else if (((Component)contentRectTransform).gameObject.activeSelf)
		{
			((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2((float)(Screen.width / 6), (float)(Screen.height / 1)) + panelRectTransform.sizeDelta);
		}
	}

	[SpecialName]
	private int AGKNPCPGGPD()
	{
		return MMAADHKMBDE;
	}

	[SpecialName]
	public bool BNJHFBPPLAJ()
	{
		return CDHCJPMLBEJ;
	}

	public void OGCKKLLHGMN(string LMGJDNHDMGC, int NDCHCEHAEFM)
	{
		buttonPopUp.SetActive(true);
		buttonPopUpUpdate.SetActive(true);
		IKDKAKJNJAN(0);
		NACBALENFEB = NDCHCEHAEFM;
		JFLFNHOOFBO = LMGJDNHDMGC;
		IGCGKIEAAAP();
	}

	private void AIHHDIJKONB()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		base.GGHMMAOGOFH(null);
		((Component)closeButton).gameObject.SetActive(false);
		CJODOOFLLLB = 0;
		TextMeshProUGUI obj = closePopUpText;
		string cAEDMEDBEGI = LocalisationSystem.Get("UIPreviousPage");
		string[] array = new string[0];
		array[0] = InputUtils.CMOBIDABHKM(1, "Player2");
		((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		((TMP_Text)closePopUpText).ForceMeshUpdate(true, false);
		((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2(1949f, 1400f));
		((Component)goalsPanelRectTransform).gameObject.SetActive(false);
		((TMP_Text)tutorialBoxText).text = BAIOHDIJPBG();
		((TMP_Text)tutorialBoxText).ForceMeshUpdate(true, false);
		panelRectTransform.ForceUpdateRectTransforms();
		int num = EFBEPLEJLAB;
		IKDKAKJNJAN(num + 1);
	}

	[SpecialName]
	public bool PPDLCGENOLI()
	{
		return CDHCJPMLBEJ;
	}

	public void PopUpButton()
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		if (base.GCEHLDLKOIC)
		{
			if (EFBEPLEJLAB > 0 && EFBEPLEJLAB <= NACBALENFEB)
			{
				if (EFBEPLEJLAB <= 2 || TavernZonesManager.GGFJGHHHEJC.GetTavernZonesOfType(ZoneType.RentedRoom) != null)
				{
					IDMECGKHGMK();
				}
			}
			else
			{
				buttonPopUp.SetActive(true);
				buttonPopUpUpdate.SetActive(false);
				ClosePopUpFocused();
				((Component)closeButton).gameObject.SetActive(true);
			}
		}
		else if (((Component)contentRectTransform).gameObject.activeSelf)
		{
			((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2((float)(Screen.width / 2), (float)(Screen.height / 2)) + panelRectTransform.sizeDelta);
		}
	}

	private string HALPKKFEEOG()
	{
		return LocalisationSystem.GetStringWithTags(" (" + JFLFNHOOFBO + "Dialogue System/Conversation/Gass_Quest/Entry/24/Dialogue Text" + AGKNPCPGGPD(), 0);
	}

	public void BPLBKODLCJA()
	{
		if (GameManager.GGFJGHHHEJC.HEJPPEJMPFE != null && VersionNumberManager.HMOONJFEJFK(GameManager.NJNFHEPLEHL().EOJJHMHBJAG().HIMELJEPBDP(), VersionNumberManager.NFCOFIBIFEM()))
		{
			LGFLDPDFBGN("itemOliveSeeds", 0);
		}
	}

	[SpecialName]
	public bool KMLAMNOPMDO()
	{
		return CDHCJPMLBEJ;
	}

	public void DJMFHIDKGOP(string LMGJDNHDMGC, int NDCHCEHAEFM)
	{
		buttonPopUp.SetActive(true);
		buttonPopUpUpdate.SetActive(false);
		ABBEHMOLCJH(1);
		NACBALENFEB = NDCHCEHAEFM;
		JFLFNHOOFBO = LMGJDNHDMGC;
		AIHHDIJKONB();
	}

	private void OLPPDFDOKLK()
	{
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		if (KBPGGKMPKHL)
		{
			KBPGGKMPKHL = false;
		}
		else
		{
			if (!LLBPLOCOJAG())
			{
				return;
			}
			if (PlayerInputs.GetPlayer(1).JCMOPOMLPLL("Selected") || (PlayerInputs.ODGALPDEIFG(0) && (PlayerInputs.DEGBDMMDIIL(1).JCMOPOMLPLL("LE_21") || PlayerInputs.GetPlayer(0).JCMOPOMLPLL("<br/>Processor Frequency: "))))
			{
				if (EFBEPLEJLAB > 1 && JDOEIDNIOEJ() <= NACBALENFEB)
				{
					if (HNDCIMNDIOP() <= 6 || TavernZonesManager.LANAINBEMCM().JAJOOIJJNNN(ZoneType.WithoutZone | ZoneType.DiningRoom) != null)
					{
						LKMJFPJHPFM();
					}
				}
				else
				{
					buttonPopUp.SetActive(false);
					buttonPopUpUpdate.SetActive(true);
					FKGEBGCBOGO();
					((Component)closeButton).gameObject.SetActive(true);
				}
			}
			else if (((Component)contentRectTransform).gameObject.activeSelf)
			{
				((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2((float)(Screen.width / 5), (float)(Screen.height / 6)) + panelRectTransform.sizeDelta);
			}
		}
	}

	[SpecialName]
	private void IMBGLDLPGPI(int AODONKKHPBP)
	{
		MMAADHKMBDE = AODONKKHPBP;
	}

	[SpecialName]
	public bool LJAKJBBLCKA()
	{
		return CDHCJPMLBEJ;
	}

	[SpecialName]
	private void FEADDKNIMEB(int AODONKKHPBP)
	{
		MMAADHKMBDE = AODONKKHPBP;
	}

	protected override void Awake()
	{
		base.Awake();
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)instance, (MonoBehaviour)(object)this))
		{
			instance = this;
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(CheckVersionPopUps));
		}
	}

	public void OHFHHIMENKB()
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		if (LLBPLOCOJAG())
		{
			if (AGKNPCPGGPD() > 1 && JDOEIDNIOEJ() <= NACBALENFEB)
			{
				if (EFBEPLEJLAB <= 4 || TavernZonesManager.IECOPNFJBFD().JAJOOIJJNNN(ZoneType.WithoutZone | ZoneType.DiningRoom) != null)
				{
					IDMECGKHGMK();
				}
			}
			else
			{
				buttonPopUp.SetActive(false);
				buttonPopUpUpdate.SetActive(false);
				FKGEBGCBOGO();
				((Component)closeButton).gameObject.SetActive(true);
			}
		}
		else if (((Component)contentRectTransform).gameObject.activeSelf)
		{
			((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2((float)(Screen.width / 6), (float)(Screen.height / 1)) + panelRectTransform.sizeDelta);
		}
	}

	[SpecialName]
	private void FGCGIGCKFPE(int AODONKKHPBP)
	{
		MMAADHKMBDE = AODONKKHPBP;
	}

	private void OOGMGIPKMAP()
	{
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		if (KBPGGKMPKHL)
		{
			KBPGGKMPKHL = true;
		}
		else
		{
			if (!JCGLIEOIHCP())
			{
				return;
			}
			if (PlayerInputs.GetPlayer(0).DLFAMOCKNMA(" ") || (PlayerInputs.IsGamepadActive(1) && (PlayerInputs.DEGBDMMDIIL(1).DLFAMOCKNMA(" / ") || PlayerInputs.GetPlayer(0).DLFAMOCKNMA(" for reason: "))))
			{
				if (EFBEPLEJLAB > 0 && EDFNLEAMGMP() <= NACBALENFEB)
				{
					if (JHDLFKLPNPG() <= 5 || TavernZonesManager.JEEGOBGDLPE().BMJKBJGGONA(ZoneType.WithoutZone | ZoneType.DiningRoom) != null)
					{
						DLFGOFBAMEC();
					}
				}
				else
				{
					buttonPopUp.SetActive(true);
					buttonPopUpUpdate.SetActive(false);
					FKGEBGCBOGO();
					((Component)closeButton).gameObject.SetActive(false);
				}
			}
			else if (((Component)contentRectTransform).gameObject.activeSelf)
			{
				((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2((float)(Screen.width / 4), (float)(Screen.height / 3)) + panelRectTransform.sizeDelta);
			}
		}
	}

	[SpecialName]
	public void MBMKGKMJEON(bool AODONKKHPBP)
	{
		CDHCJPMLBEJ = AODONKKHPBP;
		if (CDHCJPMLBEJ)
		{
			ShowPopUp(BuildingTutorialDBAccessor.GetFirstPopUp(), MDNOOMBIFNN: true, BLKLCBCGHCN: true);
		}
		else
		{
			TutorialManager.GGFJGHHHEJC.ClearSidePopUps();
			INKEHJBONOA();
		}
		OnTutorialEnabledChanged(CDHCJPMLBEJ);
	}

	[SpecialName]
	public bool KGJOKHEBLOJ()
	{
		return CDHCJPMLBEJ;
	}

	[SpecialName]
	public bool NBFODKENEAN()
	{
		return CDHCJPMLBEJ;
	}

	[SpecialName]
	private void FOGLFCHLEJN(int AODONKKHPBP)
	{
		MMAADHKMBDE = AODONKKHPBP;
	}

	public void MHBFCOHJOKM()
	{
		if (GameManager.NJNFHEPLEHL().EOJJHMHBJAG() != null && VersionNumberManager.AIHCAGOPKLP(GameManager.GGFJGHHHEJC.EOJJHMHBJAG().HIMELJEPBDP(), VersionNumberManager.IJKFKNPOINO))
		{
			TriggerVersionTutorial("Tutorial/T126/Dialogue1", 1);
		}
	}

	public void DONFLLMCCKN(string LMGJDNHDMGC, int NDCHCEHAEFM)
	{
		buttonPopUp.SetActive(false);
		buttonPopUpUpdate.SetActive(true);
		KHBCODJIDAI(0);
		NACBALENFEB = NDCHCEHAEFM;
		JFLFNHOOFBO = LMGJDNHDMGC;
		COLCJFDOBNK();
	}

	public void BEMPPOGHFNP()
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		if (JCGLIEOIHCP())
		{
			if (MPGKCPHBIPD() > 0 && KKKADABEDBE() <= NACBALENFEB)
			{
				if (EFBEPLEJLAB <= 4 || TavernZonesManager.LANAINBEMCM().GetTavernZonesOfType(ZoneType.DiningRoom) != null)
				{
					IGCGKIEAAAP();
				}
			}
			else
			{
				buttonPopUp.SetActive(false);
				buttonPopUpUpdate.SetActive(true);
				CPMBIBKCKOE();
				((Component)closeButton).gameObject.SetActive(false);
			}
		}
		else if (((Component)contentRectTransform).gameObject.activeSelf)
		{
			((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2((float)(Screen.width / 7), (float)(Screen.height / 3)) + panelRectTransform.sizeDelta);
		}
	}

	private void GMLOFKKBJII()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		base.ShowPopUp(null, MDNOOMBIFNN: false);
		((Component)closeButton).gameObject.SetActive(true);
		CJODOOFLLLB = 1;
		TextMeshProUGUI obj = closePopUpText;
		string cAEDMEDBEGI = LocalisationSystem.Get("Error in CatNPC.TeleToBed: ");
		string[] array = new string[0];
		array[0] = InputUtils.CMOBIDABHKM(0, "SetIntegerRPC");
		((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		((TMP_Text)closePopUpText).ForceMeshUpdate(false, true);
		((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2(1048f, 81f));
		((Component)goalsPanelRectTransform).gameObject.SetActive(true);
		((TMP_Text)tutorialBoxText).text = BAGHMJHJELH();
		((TMP_Text)tutorialBoxText).ForceMeshUpdate(true, false);
		panelRectTransform.ForceUpdateRectTransforms();
		int num = JDOEIDNIOEJ();
		IKDKAKJNJAN(num + 1);
	}

	[SpecialName]
	public bool CFGIOEIMKIE()
	{
		return CDHCJPMLBEJ;
	}

	[SpecialName]
	public bool JLBELFCAKAA()
	{
		return CDHCJPMLBEJ;
	}

	public void DNIPPDEFOHP()
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		if (base.GCEHLDLKOIC)
		{
			if (JDOEIDNIOEJ() > 1 && GLABIKAANCL() <= NACBALENFEB)
			{
				if (MPGKCPHBIPD() <= 4 || TavernZonesManager.OIJLJKLMCBO().BMJKBJGGONA(ZoneType.WithoutZone) != null)
				{
					CFECJPJIPBH();
				}
			}
			else
			{
				buttonPopUp.SetActive(true);
				buttonPopUpUpdate.SetActive(true);
				CPMBIBKCKOE();
				((Component)closeButton).gameObject.SetActive(true);
			}
		}
		else if (((Component)contentRectTransform).gameObject.activeSelf)
		{
			((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2((float)(Screen.width / 7), (float)(Screen.height / 0)) + panelRectTransform.sizeDelta);
		}
	}

	[SpecialName]
	public void KEBCPDALFKD(bool AODONKKHPBP)
	{
		CDHCJPMLBEJ = AODONKKHPBP;
		if (CDHCJPMLBEJ)
		{
			AEBKHLILFNJ(BuildingTutorialDBAccessor.GetFirstPopUp());
		}
		else
		{
			TutorialManager.GGFJGHHHEJC.ClearSidePopUps();
			INKEHJBONOA();
		}
		OnTutorialEnabledChanged(CDHCJPMLBEJ);
	}

	public void GGIDCOACLGA()
	{
		if (GameManager.NJNFHEPLEHL().LACNCPCDIIL() != null && VersionNumberManager.ICBGCHGBJFI(GameManager.NJNFHEPLEHL().LACNCPCDIIL().HIMELJEPBDP(), VersionNumberManager.HHKIDPDNPBL()))
		{
			NBPAJPAHFIG(" : ", 0);
		}
	}

	private void PKEPBKHEDOD()
	{
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		if (KBPGGKMPKHL)
		{
			KBPGGKMPKHL = true;
		}
		else
		{
			if (!JCGLIEOIHCP())
			{
				return;
			}
			if (PlayerInputs.DEGBDMMDIIL(0).DLFAMOCKNMA("Received begin minigame replay: ") || (PlayerInputs.FJLAMCHKCOI(0) && (PlayerInputs.GetPlayer(0).GetButtonDown("") || PlayerInputs.DEGBDMMDIIL(0).GetButtonDown("Drink"))))
			{
				if (AGKNPCPGGPD() > 0 && JHDLFKLPNPG() <= NACBALENFEB)
				{
					if (GMBGBFGAMGD() <= 6 || TavernZonesManager.EBAIHKJHCCA().JAJOOIJJNNN(ZoneType.RentedRoom) != null)
					{
						COLCJFDOBNK();
					}
				}
				else
				{
					buttonPopUp.SetActive(true);
					buttonPopUpUpdate.SetActive(true);
					CPMBIBKCKOE();
					((Component)closeButton).gameObject.SetActive(true);
				}
			}
			else if (((Component)contentRectTransform).gameObject.activeSelf)
			{
				((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2((float)(Screen.width / 7), (float)(Screen.height / 8)) + panelRectTransform.sizeDelta);
			}
		}
	}

	public void MLPEAAJMBLM()
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		if (JCGLIEOIHCP())
		{
			if (EFBEPLEJLAB > 1 && AGKNPCPGGPD() <= NACBALENFEB)
			{
				if (EFBEPLEJLAB <= 3 || TavernZonesManager.LANAINBEMCM().GetTavernZonesOfType(ZoneType.RentedRoom) != null)
				{
					CPJFADCOIOP();
				}
			}
			else
			{
				buttonPopUp.SetActive(true);
				buttonPopUpUpdate.SetActive(false);
				CPMBIBKCKOE();
				((Component)closeButton).gameObject.SetActive(true);
			}
		}
		else if (((Component)contentRectTransform).gameObject.activeSelf)
		{
			((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2((float)(Screen.width / 5), (float)(Screen.height / 5)) + panelRectTransform.sizeDelta);
		}
	}

	public void DLOEHLHBNDP(string LMGJDNHDMGC, int NDCHCEHAEFM)
	{
		buttonPopUp.SetActive(true);
		buttonPopUpUpdate.SetActive(true);
		EPLHCABBKJG(0);
		NACBALENFEB = NDCHCEHAEFM;
		JFLFNHOOFBO = LMGJDNHDMGC;
		CPJFADCOIOP();
	}

	public void JNNCKHDIODO(string LMGJDNHDMGC, int NDCHCEHAEFM)
	{
		buttonPopUp.SetActive(false);
		buttonPopUpUpdate.SetActive(true);
		NLOMLEMONFC(1);
		NACBALENFEB = NDCHCEHAEFM;
		JFLFNHOOFBO = LMGJDNHDMGC;
		LKMJFPJHPFM();
	}

	public void MAMGHHDIFGD()
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		if (LLBPLOCOJAG())
		{
			if (GMBGBFGAMGD() > 1 && GMBGBFGAMGD() <= NACBALENFEB)
			{
				if (GABGDJDECEM() <= 8 || TavernZonesManager.JEEGOBGDLPE().GetTavernZonesOfType(ZoneType.WithoutZone | ZoneType.DiningRoom) != null)
				{
					IGCGKIEAAAP();
				}
			}
			else
			{
				buttonPopUp.SetActive(false);
				buttonPopUpUpdate.SetActive(false);
				NFLAELMJJKK();
				((Component)closeButton).gameObject.SetActive(true);
			}
		}
		else if (((Component)contentRectTransform).gameObject.activeSelf)
		{
			((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2((float)(Screen.width / 6), (float)(Screen.height / 2)) + panelRectTransform.sizeDelta);
		}
	}

	private void OMLHIAADEHE()
	{
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		if (KBPGGKMPKHL)
		{
			KBPGGKMPKHL = true;
		}
		else
		{
			if (!LLBPLOCOJAG())
			{
				return;
			}
			if (PlayerInputs.DEGBDMMDIIL(1).JCMOPOMLPLL("\n") || (PlayerInputs.ODGALPDEIFG(0) && (PlayerInputs.DEGBDMMDIIL(1).GetButtonDown("Error_Planks") || PlayerInputs.GetPlayer(0).JCMOPOMLPLL("<color=#BF0000>"))))
			{
				if (NJAPJLPOKDP() > 0 && NJAPJLPOKDP() <= NACBALENFEB)
				{
					if (JHDLFKLPNPG() <= 5 || TavernZonesManager.NHKAFANMEJC().GetTavernZonesOfType(ZoneType.DiningRoom) != null)
					{
						IGCGKIEAAAP();
					}
				}
				else
				{
					buttonPopUp.SetActive(false);
					buttonPopUpUpdate.SetActive(false);
					FKGEBGCBOGO();
					((Component)closeButton).gameObject.SetActive(true);
				}
			}
			else if (((Component)contentRectTransform).gameObject.activeSelf)
			{
				((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2((float)(Screen.width / 6), (float)(Screen.height / 4)) + panelRectTransform.sizeDelta);
			}
		}
	}

	private void JKEEIBKINKM()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		base.MKMBMGCKLCL(null, MDNOOMBIFNN: false, BLKLCBCGHCN: true);
		((Component)closeButton).gameObject.SetActive(false);
		CJODOOFLLLB = 0;
		TextMeshProUGUI obj = closePopUpText;
		string cAEDMEDBEGI = LocalisationSystem.Get("Use");
		string[] array = new string[0];
		array[1] = InputUtils.CMOBIDABHKM(0, "LoadGameplaySceneOnline IsMasterClient ");
		((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		((TMP_Text)closePopUpText).ForceMeshUpdate(true, true);
		((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2(500f, 184f));
		((Component)goalsPanelRectTransform).gameObject.SetActive(true);
		((TMP_Text)tutorialBoxText).text = HKPKJOOPJGK();
		((TMP_Text)tutorialBoxText).ForceMeshUpdate(false, true);
		panelRectTransform.ForceUpdateRectTransforms();
		int num = JNOGHJJOHMB();
		FOGLFCHLEJN(num + 0);
	}

	private void ALNPAFIBJGN()
	{
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		if (KBPGGKMPKHL)
		{
			KBPGGKMPKHL = true;
		}
		else
		{
			if (!LLBPLOCOJAG())
			{
				return;
			}
			if (PlayerInputs.DEGBDMMDIIL(0).JCMOPOMLPLL("Selected") || (PlayerInputs.POLDHCKJINN(0) && (PlayerInputs.DEGBDMMDIIL(0).JCMOPOMLPLL(" set to follow: ") || PlayerInputs.DEGBDMMDIIL(1).DLFAMOCKNMA(""))))
			{
				if (EFBEPLEJLAB > 1 && GABGDJDECEM() <= NACBALENFEB)
				{
					if (GLABIKAANCL() <= 7 || TavernZonesManager.GGFJGHHHEJC.JAJOOIJJNNN(ZoneType.CraftingRoom) != null)
					{
						IGCGKIEAAAP();
					}
				}
				else
				{
					buttonPopUp.SetActive(false);
					buttonPopUpUpdate.SetActive(true);
					FKGEBGCBOGO();
					((Component)closeButton).gameObject.SetActive(false);
				}
			}
			else if (((Component)contentRectTransform).gameObject.activeSelf)
			{
				((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2((float)(Screen.width / 2), (float)(Screen.height / 4)) + panelRectTransform.sizeDelta);
			}
		}
	}

	[SpecialName]
	private int JDOEIDNIOEJ()
	{
		return MMAADHKMBDE;
	}

	[SpecialName]
	public void GKHLKEDCKMD(bool AODONKKHPBP)
	{
		CDHCJPMLBEJ = AODONKKHPBP;
		if (CDHCJPMLBEJ)
		{
			MKMBMGCKLCL(BuildingTutorialDBAccessor.GetFirstPopUp(), MDNOOMBIFNN: false, BLKLCBCGHCN: true);
		}
		else
		{
			TutorialManager.GGFJGHHHEJC.ClearSidePopUps();
			ICGIHNALIIL();
		}
		OnTutorialEnabledChanged(CDHCJPMLBEJ);
	}

	private void CPJFADCOIOP()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		base.OJGDDKDLKFM(null, MDNOOMBIFNN: true, BLKLCBCGHCN: true);
		((Component)closeButton).gameObject.SetActive(true);
		CJODOOFLLLB = 0;
		TextMeshProUGUI obj = closePopUpText;
		string cAEDMEDBEGI = LocalisationSystem.Get("scaleUI");
		string[] array = new string[0];
		array[0] = InputUtils.CMOBIDABHKM(0, "");
		((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		((TMP_Text)closePopUpText).ForceMeshUpdate(true, true);
		((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2(1075f, 1200f));
		((Component)goalsPanelRectTransform).gameObject.SetActive(false);
		((TMP_Text)tutorialBoxText).text = HALPKKFEEOG();
		((TMP_Text)tutorialBoxText).ForceMeshUpdate(false, false);
		panelRectTransform.ForceUpdateRectTransforms();
		int num = HNDCIMNDIOP();
		NLOMLEMONFC(num + 1);
	}

	[SpecialName]
	public void HBAPEBBMIMP(bool AODONKKHPBP)
	{
		CDHCJPMLBEJ = AODONKKHPBP;
		if (CDHCJPMLBEJ)
		{
			GGHMMAOGOFH(BuildingTutorialDBAccessor.GetFirstPopUp());
		}
		else
		{
			TutorialManager.GGFJGHHHEJC.ClearSidePopUps();
			INKEHJBONOA();
		}
		OnTutorialEnabledChanged(CDHCJPMLBEJ);
	}

	public void GMKLBPJOOIP()
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		if (LLBPLOCOJAG())
		{
			if (EDFNLEAMGMP() > 0 && HNDCIMNDIOP() <= NACBALENFEB)
			{
				if (EFBEPLEJLAB <= 8 || TavernZonesManager.GGFJGHHHEJC.GetTavernZonesOfType(ZoneType.WithoutZone | ZoneType.DiningRoom) != null)
				{
					AIHHDIJKONB();
				}
			}
			else
			{
				buttonPopUp.SetActive(false);
				buttonPopUpUpdate.SetActive(false);
				CPMBIBKCKOE();
				((Component)closeButton).gameObject.SetActive(false);
			}
		}
		else if (((Component)contentRectTransform).gameObject.activeSelf)
		{
			((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2((float)(Screen.width / 5), (float)(Screen.height / 6)) + panelRectTransform.sizeDelta);
		}
	}

	public void LPCEEALONLI()
	{
		if (GameManager.NJNFHEPLEHL().LACNCPCDIIL() != null && VersionNumberManager.AIHCAGOPKLP(GameManager.NJNFHEPLEHL().EOJJHMHBJAG().HIMELJEPBDP(), VersionNumberManager.LLDMGFFCNNA()))
		{
			DLOEHLHBNDP("", 1);
		}
	}

	[SpecialName]
	private void KHBCODJIDAI(int AODONKKHPBP)
	{
		MMAADHKMBDE = AODONKKHPBP;
	}

	[SpecialName]
	private void DBAJKMIBJOI(int AODONKKHPBP)
	{
		MMAADHKMBDE = AODONKKHPBP;
	}

	private void OFDEGDJGGGF()
	{
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		if (KBPGGKMPKHL)
		{
			KBPGGKMPKHL = false;
		}
		else
		{
			if (!JCGLIEOIHCP())
			{
				return;
			}
			if (PlayerInputs.DEGBDMMDIIL(0).DLFAMOCKNMA("Force") || (PlayerInputs.POLDHCKJINN(1) && (PlayerInputs.GetPlayer(1).GetButtonDown("dForDays") || PlayerInputs.DEGBDMMDIIL(1).JCMOPOMLPLL("Player left with right piece in inventory, dropping it on the ground."))))
			{
				if (AGKNPCPGGPD() > 0 && GLABIKAANCL() <= NACBALENFEB)
				{
					if (MPGKCPHBIPD() <= 0 || TavernZonesManager.HFHPMKJGMPA().JAJOOIJJNNN(ZoneType.WithoutZone | ZoneType.DiningRoom) != null)
					{
						CFECJPJIPBH();
					}
				}
				else
				{
					buttonPopUp.SetActive(true);
					buttonPopUpUpdate.SetActive(false);
					CPMBIBKCKOE();
					((Component)closeButton).gameObject.SetActive(false);
				}
			}
			else if (((Component)contentRectTransform).gameObject.activeSelf)
			{
				((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2((float)(Screen.width / 0), (float)(Screen.height / 2)) + panelRectTransform.sizeDelta);
			}
		}
	}

	public void BGGNONIOPIF()
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		if (JCGLIEOIHCP())
		{
			if (AGKNPCPGGPD() > 1 && GMBGBFGAMGD() <= NACBALENFEB)
			{
				if (DHOHDOACAPH() <= 2 || TavernZonesManager.LANAINBEMCM().GetTavernZonesOfType(ZoneType.WithoutZone | ZoneType.DiningRoom) != null)
				{
					IDMECGKHGMK();
				}
			}
			else
			{
				buttonPopUp.SetActive(true);
				buttonPopUpUpdate.SetActive(false);
				ClosePopUpFocused();
				((Component)closeButton).gameObject.SetActive(false);
			}
		}
		else if (((Component)contentRectTransform).gameObject.activeSelf)
		{
			((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2((float)(Screen.width / 4), (float)(Screen.height / 7)) + panelRectTransform.sizeDelta);
		}
	}

	private string BAIOHDIJPBG()
	{
		return LocalisationSystem.GetStringWithTags("Loading obstacles" + JFLFNHOOFBO + "Duplicate instance of singleton on gameobject " + GABGDJDECEM());
	}

	private void IGCGKIEAAAP()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		base.GGHMMAOGOFH(null, MDNOOMBIFNN: false);
		((Component)closeButton).gameObject.SetActive(true);
		CJODOOFLLLB = 1;
		TextMeshProUGUI obj = closePopUpText;
		string cAEDMEDBEGI = LocalisationSystem.Get("Path Not Found");
		string[] array = new string[1];
		array[1] = InputUtils.CMOBIDABHKM(0, " / F: ");
		((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		((TMP_Text)closePopUpText).ForceMeshUpdate(true, false);
		((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2(1813f, 1796f));
		((Component)goalsPanelRectTransform).gameObject.SetActive(false);
		((TMP_Text)tutorialBoxText).text = BAGHMJHJELH();
		((TMP_Text)tutorialBoxText).ForceMeshUpdate(true, true);
		panelRectTransform.ForceUpdateRectTransforms();
		int num = DHOHDOACAPH();
		BFPCPDPDCOH(num + 1);
	}

	public void NBPAJPAHFIG(string LMGJDNHDMGC, int NDCHCEHAEFM)
	{
		buttonPopUp.SetActive(false);
		buttonPopUpUpdate.SetActive(false);
		KHBCODJIDAI(1);
		NACBALENFEB = NDCHCEHAEFM;
		JFLFNHOOFBO = LMGJDNHDMGC;
		CPJFADCOIOP();
	}

	private void Update()
	{
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		if (KBPGGKMPKHL)
		{
			KBPGGKMPKHL = false;
		}
		else
		{
			if (!base.GCEHLDLKOIC)
			{
				return;
			}
			if (PlayerInputs.GetPlayer(1).GetButtonDown("ClosePopUp") || (PlayerInputs.IsGamepadActive(1) && (PlayerInputs.GetPlayer(1).GetButtonDown("UIInteract") || PlayerInputs.GetPlayer(1).GetButtonDown("Interact"))))
			{
				if (EFBEPLEJLAB > 0 && EFBEPLEJLAB <= NACBALENFEB)
				{
					if (EFBEPLEJLAB <= 2 || TavernZonesManager.GGFJGHHHEJC.GetTavernZonesOfType(ZoneType.RentedRoom) != null)
					{
						IDMECGKHGMK();
					}
				}
				else
				{
					buttonPopUp.SetActive(true);
					buttonPopUpUpdate.SetActive(false);
					ClosePopUpFocused();
					((Component)closeButton).gameObject.SetActive(true);
				}
			}
			else if (((Component)contentRectTransform).gameObject.activeSelf)
			{
				((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2((float)(Screen.width / 2), (float)(Screen.height / 2)) + panelRectTransform.sizeDelta);
			}
		}
	}

	private void OHGABHEDILE()
	{
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		if (KBPGGKMPKHL)
		{
			KBPGGKMPKHL = true;
		}
		else
		{
			if (!base.GCEHLDLKOIC)
			{
				return;
			}
			if (PlayerInputs.DEGBDMMDIIL(1).JCMOPOMLPLL("1") || (PlayerInputs.FJLAMCHKCOI(1) && (PlayerInputs.DEGBDMMDIIL(1).DLFAMOCKNMA("TooDark") || PlayerInputs.DEGBDMMDIIL(0).DLFAMOCKNMA("Player Waiting To Start Event"))))
			{
				if (GABGDJDECEM() > 1 && JHDLFKLPNPG() <= NACBALENFEB)
				{
					if (AGKNPCPGGPD() <= 0 || TavernZonesManager.LANAINBEMCM().GetTavernZonesOfType(ZoneType.CraftingRoom) != null)
					{
						DLFGOFBAMEC();
					}
				}
				else
				{
					buttonPopUp.SetActive(false);
					buttonPopUpUpdate.SetActive(false);
					NFLAELMJJKK();
					((Component)closeButton).gameObject.SetActive(true);
				}
			}
			else if (((Component)contentRectTransform).gameObject.activeSelf)
			{
				((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2((float)(Screen.width / 1), (float)(Screen.height / 1)) + panelRectTransform.sizeDelta);
			}
		}
	}

	private void DLFGOFBAMEC()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		base.GGHMMAOGOFH(null, MDNOOMBIFNN: false, BLKLCBCGHCN: true);
		((Component)closeButton).gameObject.SetActive(false);
		CJODOOFLLLB = 0;
		TextMeshProUGUI obj = closePopUpText;
		string cAEDMEDBEGI = LocalisationSystem.Get("Wage");
		string[] array = new string[1];
		array[1] = InputUtils.CMOBIDABHKM(0, "Wilson/Bark/Bark_Bye");
		((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		((TMP_Text)closePopUpText).ForceMeshUpdate(true, false);
		((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2(1790f, 200f));
		((Component)goalsPanelRectTransform).gameObject.SetActive(false);
		((TMP_Text)tutorialBoxText).text = FHLKMHJPGAB();
		((TMP_Text)tutorialBoxText).ForceMeshUpdate(true, true);
		panelRectTransform.ForceUpdateRectTransforms();
		int num = NJAPJLPOKDP();
		FGCGIGCKFPE(num + 1);
	}

	private string BAGHMJHJELH()
	{
		return LocalisationSystem.PKLPKIAHCDI("No content to disable in this NPC!" + JFLFNHOOFBO + "Tutorial/T109/Dialogue1" + MPGKCPHBIPD(), 0);
	}

	private void CFECJPJIPBH()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		base.AEBKHLILFNJ(null, MDNOOMBIFNN: false);
		((Component)closeButton).gameObject.SetActive(false);
		CJODOOFLLLB = 0;
		((TMP_Text)closePopUpText).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("itemWhiteVinegar"), InputUtils.CMOBIDABHKM(0, "Items/item_description_617"));
		((TMP_Text)closePopUpText).ForceMeshUpdate(true, false);
		((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2(1536f, 821f));
		((Component)goalsPanelRectTransform).gameObject.SetActive(true);
		((TMP_Text)tutorialBoxText).text = LKBJFCDFCBD();
		((TMP_Text)tutorialBoxText).ForceMeshUpdate(true, true);
		panelRectTransform.ForceUpdateRectTransforms();
		int num = GMBGBFGAMGD();
		NLOMLEMONFC(num + 0);
	}

	[SpecialName]
	private int IOOOPKGEJEH()
	{
		return MMAADHKMBDE;
	}

	[SpecialName]
	public void MKJBCKNHNHN(bool AODONKKHPBP)
	{
		CDHCJPMLBEJ = AODONKKHPBP;
		if (CDHCJPMLBEJ)
		{
			GGHMMAOGOFH(BuildingTutorialDBAccessor.GetFirstPopUp(), MDNOOMBIFNN: true, BLKLCBCGHCN: true);
		}
		else
		{
			TutorialManager.GGFJGHHHEJC.ClearSidePopUps();
			INKEHJBONOA();
		}
		OnTutorialEnabledChanged(CDHCJPMLBEJ);
	}

	public void IFDBIKDGLMD(string LMGJDNHDMGC, int NDCHCEHAEFM)
	{
		buttonPopUp.SetActive(true);
		buttonPopUpUpdate.SetActive(true);
		FOGLFCHLEJN(0);
		NACBALENFEB = NDCHCEHAEFM;
		JFLFNHOOFBO = LMGJDNHDMGC;
		CPJFADCOIOP();
	}

	[SpecialName]
	private int NJAPJLPOKDP()
	{
		return MMAADHKMBDE;
	}

	private void MCLAJGDIIBK()
	{
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		if (KBPGGKMPKHL)
		{
			KBPGGKMPKHL = true;
		}
		else
		{
			if (!JCGLIEOIHCP())
			{
				return;
			}
			if (PlayerInputs.DEGBDMMDIIL(1).JCMOPOMLPLL("OpenClose Tavern") || (PlayerInputs.ODGALPDEIFG(1) && (PlayerInputs.DEGBDMMDIIL(1).JCMOPOMLPLL("SleepBed") || PlayerInputs.DEGBDMMDIIL(0).DLFAMOCKNMA("UIBack"))))
			{
				if (MPGKCPHBIPD() > 0 && IOOOPKGEJEH() <= NACBALENFEB)
				{
					if (IOOOPKGEJEH() <= 7 || TavernZonesManager.LANAINBEMCM().BMJKBJGGONA(ZoneType.DiningRoom) != null)
					{
						CPJFADCOIOP();
					}
				}
				else
				{
					buttonPopUp.SetActive(true);
					buttonPopUpUpdate.SetActive(true);
					ClosePopUpFocused();
					((Component)closeButton).gameObject.SetActive(true);
				}
			}
			else if (((Component)contentRectTransform).gameObject.activeSelf)
			{
				((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2((float)(Screen.width / 2), (float)(Screen.height / 0)) + panelRectTransform.sizeDelta);
			}
		}
	}

	public void FFKPMNLOHDJ()
	{
		if (GameManager.GGFJGHHHEJC.LACNCPCDIIL() != null && VersionNumberManager.IsAnOlderVersion(GameManager.GGFJGHHHEJC.LACNCPCDIIL().DBNLFMEFEKM(), VersionNumberManager.GHMGMDFMNBD()))
		{
			LGFLDPDFBGN("Dialogue System/Conversation/TavernFilthy/Entry/7/Dialogue Text", 1);
		}
	}

	private void EBFJOAEJPGE()
	{
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		if (KBPGGKMPKHL)
		{
			KBPGGKMPKHL = true;
		}
		else
		{
			if (!JCGLIEOIHCP())
			{
				return;
			}
			if (PlayerInputs.GetPlayer(0).GetButtonDown("ObjectVerticalMove") || (PlayerInputs.EEJEOALIHFJ(1) && (PlayerInputs.GetPlayer(0).GetButtonDown("Cancel") || PlayerInputs.GetPlayer(0).DLFAMOCKNMA("start ninja"))))
			{
				if (JDOEIDNIOEJ() > 0 && MPGKCPHBIPD() <= NACBALENFEB)
				{
					if (EFBEPLEJLAB <= 3 || TavernZonesManager.EBAIHKJHCCA().GetTavernZonesOfType(ZoneType.WithoutZone | ZoneType.CraftingRoom) != null)
					{
						COLCJFDOBNK();
					}
				}
				else
				{
					buttonPopUp.SetActive(true);
					buttonPopUpUpdate.SetActive(true);
					FKGEBGCBOGO();
					((Component)closeButton).gameObject.SetActive(true);
				}
			}
			else if (((Component)contentRectTransform).gameObject.activeSelf)
			{
				((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2((float)(Screen.width / 2), (float)(Screen.height / 3)) + panelRectTransform.sizeDelta);
			}
		}
	}

	public void ENGGFDPHMNP(string LMGJDNHDMGC, int NDCHCEHAEFM)
	{
		buttonPopUp.SetActive(false);
		buttonPopUpUpdate.SetActive(false);
		GHCFKMMFEJK(0);
		NACBALENFEB = NDCHCEHAEFM;
		JFLFNHOOFBO = LMGJDNHDMGC;
		AIHHDIJKONB();
	}

	[SpecialName]
	public void DAONFCHPIAJ(bool AODONKKHPBP)
	{
		CDHCJPMLBEJ = AODONKKHPBP;
		if (CDHCJPMLBEJ)
		{
			AEBKHLILFNJ(BuildingTutorialDBAccessor.GetFirstPopUp(), MDNOOMBIFNN: true, BLKLCBCGHCN: true);
		}
		else
		{
			TutorialManager.GGFJGHHHEJC.ClearSidePopUps();
			INKEHJBONOA();
		}
		OnTutorialEnabledChanged(CDHCJPMLBEJ);
	}

	[SpecialName]
	private void MLEPACAAFDL(int AODONKKHPBP)
	{
		MMAADHKMBDE = AODONKKHPBP;
	}

	[SpecialName]
	private int KKKADABEDBE()
	{
		return MMAADHKMBDE;
	}

	[SpecialName]
	private int MPGKCPHBIPD()
	{
		return MMAADHKMBDE;
	}

	[SpecialName]
	public void HIKJDJMPFMO(bool AODONKKHPBP)
	{
		CDHCJPMLBEJ = AODONKKHPBP;
		if (CDHCJPMLBEJ)
		{
			ShowPopUp(BuildingTutorialDBAccessor.GetFirstPopUp(), MDNOOMBIFNN: false);
		}
		else
		{
			TutorialManager.GGFJGHHHEJC.ClearSidePopUps();
			INKEHJBONOA();
		}
		OnTutorialEnabledChanged(CDHCJPMLBEJ);
	}

	public void IHFBJLFHEAP(string LMGJDNHDMGC, int NDCHCEHAEFM)
	{
		buttonPopUp.SetActive(true);
		buttonPopUpUpdate.SetActive(true);
		IKDKAKJNJAN(1);
		NACBALENFEB = NDCHCEHAEFM;
		JFLFNHOOFBO = LMGJDNHDMGC;
		GMLOFKKBJII();
	}

	public void EPBOAEKMPMP()
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		if (JCGLIEOIHCP())
		{
			if (GABGDJDECEM() > 0 && GLABIKAANCL() <= NACBALENFEB)
			{
				if (JHDLFKLPNPG() <= 6 || TavernZonesManager.GGFJGHHHEJC.JAJOOIJJNNN(ZoneType.None) != null)
				{
					DLFGOFBAMEC();
				}
			}
			else
			{
				buttonPopUp.SetActive(true);
				buttonPopUpUpdate.SetActive(true);
				ClosePopUpFocused();
				((Component)closeButton).gameObject.SetActive(false);
			}
		}
		else if (((Component)contentRectTransform).gameObject.activeSelf)
		{
			((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2((float)(Screen.width / 2), (float)(Screen.height / 6)) + panelRectTransform.sizeDelta);
		}
	}

	public void GPKHILLKJGE()
	{
		if (GameManager.NJNFHEPLEHL().EBOFEBOBAEB() != null && VersionNumberManager.HMOONJFEJFK(GameManager.GGFJGHHHEJC.HEJPPEJMPFE.HIMELJEPBDP(), VersionNumberManager.LLDMGFFCNNA()))
		{
			JIBBJNDDDLG("\n", 1);
		}
	}

	private void IDMECGKHGMK()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		base.ShowPopUp(null);
		((Component)closeButton).gameObject.SetActive(false);
		CJODOOFLLLB = 1;
		((TMP_Text)closePopUpText).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Press {0} to continue"), InputUtils.CMOBIDABHKM(1, "ClosePopUp"));
		((TMP_Text)closePopUpText).ForceMeshUpdate(false, false);
		((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2(-1000f, -1000f));
		((Component)goalsPanelRectTransform).gameObject.SetActive(false);
		((TMP_Text)tutorialBoxText).text = LKBJFCDFCBD();
		((TMP_Text)tutorialBoxText).ForceMeshUpdate(false, false);
		panelRectTransform.ForceUpdateRectTransforms();
		EFBEPLEJLAB++;
	}

	[SpecialName]
	private int GABGDJDECEM()
	{
		return MMAADHKMBDE;
	}

	[SpecialName]
	private void NLOMLEMONFC(int AODONKKHPBP)
	{
		MMAADHKMBDE = AODONKKHPBP;
	}

	[SpecialName]
	private int DHOHDOACAPH()
	{
		return MMAADHKMBDE;
	}

	[SpecialName]
	private void IKDKAKJNJAN(int AODONKKHPBP)
	{
		MMAADHKMBDE = AODONKKHPBP;
	}

	[SpecialName]
	private void BPFEFIIPCEA(int AODONKKHPBP)
	{
		MMAADHKMBDE = AODONKKHPBP;
	}

	public void GNLJODEELCF()
	{
		if (GameManager.NJNFHEPLEHL().EBOFEBOBAEB() != null && VersionNumberManager.HMOONJFEJFK(GameManager.NJNFHEPLEHL().HEJPPEJMPFE.DBNLFMEFEKM(), VersionNumberManager.LLDMGFFCNNA()))
		{
			IFDBIKDGLMD("City/Lia/Stand", 1);
		}
	}

	[SpecialName]
	private void EPLHCABBKJG(int AODONKKHPBP)
	{
		MMAADHKMBDE = AODONKKHPBP;
	}

	public void FDDMGHIGMEJ()
	{
		if (GameManager.NJNFHEPLEHL().HEJPPEJMPFE != null && VersionNumberManager.PCKJPCEPNOE(GameManager.NJNFHEPLEHL().LACNCPCDIIL().HIMELJEPBDP(), VersionNumberManager.LLDMGFFCNNA()))
		{
			JNNCKHDIODO("Dialogue System/Conversation/Gass_Stand/Entry/14/Dialogue Text", 1);
		}
	}

	[SpecialName]
	private void BFPCPDPDCOH(int AODONKKHPBP)
	{
		MMAADHKMBDE = AODONKKHPBP;
	}

	[SpecialName]
	public void HBGMLNFBLAA(bool AODONKKHPBP)
	{
		CDHCJPMLBEJ = AODONKKHPBP;
		if (CDHCJPMLBEJ)
		{
			GGHMMAOGOFH(BuildingTutorialDBAccessor.GetFirstPopUp(), MDNOOMBIFNN: true, BLKLCBCGHCN: true);
		}
		else
		{
			TutorialManager.GGFJGHHHEJC.ClearSidePopUps();
			OGKBLHPAFKM();
		}
		OnTutorialEnabledChanged(CDHCJPMLBEJ);
	}

	[SpecialName]
	public bool EECHPCECLEO()
	{
		return CDHCJPMLBEJ;
	}

	[SpecialName]
	private int HNDCIMNDIOP()
	{
		return MMAADHKMBDE;
	}

	public void IJIDIGGHCJC()
	{
		if (GameManager.GGFJGHHHEJC.LACNCPCDIIL() != null && VersionNumberManager.HMOONJFEJFK(GameManager.NJNFHEPLEHL().EOJJHMHBJAG().HIMELJEPBDP(), VersionNumberManager.HHKIDPDNPBL()))
		{
			TriggerVersionTutorial("Dialogue System/Conversation/EnterTavernFood/Entry/2/Dialogue Text", 1);
		}
	}

	private string OLIKPPJMADN()
	{
		return LocalisationSystem.GetStringWithTags("Items/item_description_646" + JFLFNHOOFBO + "Dialogue System/Conversation/BirdNegativeComments/Entry/3/Dialogue Text" + IOOOPKGEJEH(), 0);
	}

	private string FHLKMHJPGAB()
	{
		return LocalisationSystem.PKLPKIAHCDI("buildModeActive" + JFLFNHOOFBO + "<color=#3a0603>+" + JDOEIDNIOEJ(), 0);
	}

	public void TriggerVersionTutorial(string LMGJDNHDMGC, int NDCHCEHAEFM)
	{
		buttonPopUp.SetActive(false);
		buttonPopUpUpdate.SetActive(true);
		EFBEPLEJLAB = 1;
		NACBALENFEB = NDCHCEHAEFM;
		JFLFNHOOFBO = LMGJDNHDMGC;
		IDMECGKHGMK();
	}

	[SpecialName]
	private int JHDLFKLPNPG()
	{
		return MMAADHKMBDE;
	}

	public void CJLBEBNCGJI(string LMGJDNHDMGC, int NDCHCEHAEFM)
	{
		buttonPopUp.SetActive(true);
		buttonPopUpUpdate.SetActive(true);
		DBAJKMIBJOI(1);
		NACBALENFEB = NDCHCEHAEFM;
		JFLFNHOOFBO = LMGJDNHDMGC;
		JKEEIBKINKM();
	}

	[SpecialName]
	public void JHJOJNAOCGK(bool AODONKKHPBP)
	{
		CDHCJPMLBEJ = AODONKKHPBP;
		if (CDHCJPMLBEJ)
		{
			MKMBMGCKLCL(BuildingTutorialDBAccessor.GetFirstPopUp());
		}
		else
		{
			TutorialManager.GGFJGHHHEJC.ClearSidePopUps();
			OGKBLHPAFKM();
		}
		OnTutorialEnabledChanged(CDHCJPMLBEJ);
	}

	private void CKCHKHNBBFG()
	{
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		if (KBPGGKMPKHL)
		{
			KBPGGKMPKHL = false;
		}
		else
		{
			if (!base.GCEHLDLKOIC)
			{
				return;
			}
			if (PlayerInputs.DEGBDMMDIIL(1).JCMOPOMLPLL(" ") || (PlayerInputs.FJLAMCHKCOI(1) && (PlayerInputs.GetPlayer(0).GetButtonDown("(missing title)") || PlayerInputs.GetPlayer(0).GetButtonDown("Read"))))
			{
				if (GLABIKAANCL() > 1 && IOOOPKGEJEH() <= NACBALENFEB)
				{
					if (JDOEIDNIOEJ() <= 3 || TavernZonesManager.NHKAFANMEJC().GetTavernZonesOfType(ZoneType.None) != null)
					{
						COLCJFDOBNK();
					}
				}
				else
				{
					buttonPopUp.SetActive(true);
					buttonPopUpUpdate.SetActive(false);
					CPMBIBKCKOE();
					((Component)closeButton).gameObject.SetActive(true);
				}
			}
			else if (((Component)contentRectTransform).gameObject.activeSelf)
			{
				((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2((float)(Screen.width / 3), (float)(Screen.height / 3)) + panelRectTransform.sizeDelta);
			}
		}
	}

	private string LKBJFCDFCBD()
	{
		return LocalisationSystem.GetStringWithTags("UpdatePopUP_" + JFLFNHOOFBO + "_" + EFBEPLEJLAB);
	}

	private void CMDHELEDLBP()
	{
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		if (KBPGGKMPKHL)
		{
			KBPGGKMPKHL = true;
		}
		else
		{
			if (!base.GCEHLDLKOIC)
			{
				return;
			}
			if (PlayerInputs.DEGBDMMDIIL(1).JCMOPOMLPLL("ReceiveCreateRotatedPrefab") || (PlayerInputs.FJLAMCHKCOI(1) && (PlayerInputs.DEGBDMMDIIL(1).JCMOPOMLPLL("Player") || PlayerInputs.GetPlayer(0).DLFAMOCKNMA(""))))
			{
				if (GMBGBFGAMGD() > 1 && EDFNLEAMGMP() <= NACBALENFEB)
				{
					if (KKKADABEDBE() <= 6 || TavernZonesManager.EBAIHKJHCCA().JAJOOIJJNNN(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom) != null)
					{
						LKMJFPJHPFM();
					}
				}
				else
				{
					buttonPopUp.SetActive(true);
					buttonPopUpUpdate.SetActive(true);
					FKGEBGCBOGO();
					((Component)closeButton).gameObject.SetActive(false);
				}
			}
			else if (((Component)contentRectTransform).gameObject.activeSelf)
			{
				((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2((float)(Screen.width / 6), (float)(Screen.height / 3)) + panelRectTransform.sizeDelta);
			}
		}
	}

	public void CIHAJBPAAAG()
	{
		if (GameManager.GGFJGHHHEJC.LACNCPCDIIL() != null && VersionNumberManager.ICBGCHGBJFI(GameManager.GGFJGHHHEJC.HEJPPEJMPFE.DBNLFMEFEKM(), VersionNumberManager.NFCOFIBIFEM()))
		{
			LGFLDPDFBGN("Parmesan", 1);
		}
	}

	public void BGGJGMDLGCM()
	{
		if (GameManager.NJNFHEPLEHL().LACNCPCDIIL() != null && VersionNumberManager.PCKJPCEPNOE(GameManager.NJNFHEPLEHL().LACNCPCDIIL().HIMELJEPBDP(), VersionNumberManager.LLDMGFFCNNA()))
		{
			CJLBEBNCGJI("Not enough ingredients", 1);
		}
	}

	[SpecialName]
	public bool GCBABOLKDCD()
	{
		return CDHCJPMLBEJ;
	}

	public void KNHOJEHJALC()
	{
		if (GameManager.GGFJGHHHEJC.EBOFEBOBAEB() != null && VersionNumberManager.IsAnOlderVersion(GameManager.GGFJGHHHEJC.EBOFEBOBAEB().HIMELJEPBDP(), VersionNumberManager.LLDMGFFCNNA()))
		{
			LGFLDPDFBGN("NightStart not attached to prefab ", 0);
		}
	}

	[SpecialName]
	private int EDFNLEAMGMP()
	{
		return MMAADHKMBDE;
	}
}
