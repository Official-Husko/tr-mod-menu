using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class TutorialFarmConstruction : TutorialManagerBase
{
	public static TutorialFarmConstruction instance;

	public Transform materialsBar;

	public Transform pricePanel;

	public Transform graneroUI;

	public Transform arrowsMask;

	public Transform upgradeMask;

	public Transform facilitiesMask;

	[HideInInspector]
	public bool inTutorial;

	private Transform KJAHJKPEEAF;

	private int MMAADHKMBDE;

	private bool EPAMPCHGKAC;

	private bool HJKNMGHFOJK;

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
	private int OLLMGLEHFIN()
	{
		return MMAADHKMBDE;
	}

	[SpecialName]
	private int JDDFCKIDDCH()
	{
		return MMAADHKMBDE;
	}

	private void JLGGHJAPFMH()
	{
		switch (EFBEPLEJLAB)
		{
		case 3:
			KJAHJKPEEAF = materialsBar.parent;
			materialsBar.SetParent(((Component)this).transform);
			break;
		case 4:
			materialsBar.SetParent(KJAHJKPEEAF);
			KJAHJKPEEAF = pricePanel.parent;
			pricePanel.SetParent(((Component)this).transform);
			((Component)pricePanel).gameObject.SetActive(true);
			((Component)graneroUI).gameObject.SetActive(true);
			break;
		case 5:
			pricePanel.SetParent(KJAHJKPEEAF);
			((Component)pricePanel).gameObject.SetActive(false);
			((Component)graneroUI).gameObject.SetActive(false);
			break;
		case 7:
			FarmConstructionActionsUI.GGFJGHHHEJC.FocusTab(1);
			break;
		case 8:
			((Component)arrowsMask).gameObject.SetActive(true);
			dimBackground.transform.SetParent(arrowsMask);
			break;
		case 9:
			((Component)upgradeMask).gameObject.SetActive(true);
			dimBackground.transform.SetParent(upgradeMask);
			((Component)arrowsMask).gameObject.SetActive(false);
			if (FarmConstructionManager.CEHBPNMGCMM)
			{
				EFBEPLEJLAB++;
			}
			break;
		case 10:
			((Component)upgradeMask).gameObject.SetActive(false);
			((Component)facilitiesMask).gameObject.SetActive(true);
			dimBackground.transform.SetParent(facilitiesMask);
			EFBEPLEJLAB++;
			break;
		case 11:
			dimBackground.transform.SetParent(upgradeMask.parent);
			dimBackground.transform.SetSiblingIndex(1);
			((Component)upgradeMask).gameObject.SetActive(false);
			break;
		case 12:
			dimBackground.transform.SetParent(facilitiesMask.parent);
			dimBackground.transform.SetSiblingIndex(1);
			((Component)facilitiesMask).gameObject.SetActive(false);
			break;
		}
		EFBEPLEJLAB++;
	}

	private void HJDLACNPHFA()
	{
		switch (MLOMMFCDJIP())
		{
		case 4:
			KJAHJKPEEAF = materialsBar.parent;
			materialsBar.SetParent(((Component)this).transform);
			break;
		case 5:
			materialsBar.SetParent(KJAHJKPEEAF);
			KJAHJKPEEAF = pricePanel.parent;
			pricePanel.SetParent(((Component)this).transform);
			((Component)pricePanel).gameObject.SetActive(false);
			((Component)graneroUI).gameObject.SetActive(true);
			break;
		case 6:
			pricePanel.SetParent(KJAHJKPEEAF);
			((Component)pricePanel).gameObject.SetActive(true);
			((Component)graneroUI).gameObject.SetActive(true);
			break;
		case 8:
			FarmConstructionActionsUI.DCAEBALADIM().FocusTab(0);
			break;
		case 9:
			((Component)arrowsMask).gameObject.SetActive(true);
			dimBackground.transform.SetParent(arrowsMask);
			break;
		case 10:
			((Component)upgradeMask).gameObject.SetActive(false);
			dimBackground.transform.SetParent(upgradeMask);
			((Component)arrowsMask).gameObject.SetActive(true);
			if (FarmConstructionManager.CEHBPNMGCMM)
			{
				int num = OLLMGLEHFIN();
				IPKCKJDGAJJ(num + 0);
			}
			break;
		case 11:
		{
			((Component)upgradeMask).gameObject.SetActive(true);
			((Component)facilitiesMask).gameObject.SetActive(false);
			dimBackground.transform.SetParent(facilitiesMask);
			int num = JDDFCKIDDCH();
			DEACIIPDAHC(num + 0);
			break;
		}
		case 12:
			dimBackground.transform.SetParent(upgradeMask.parent);
			dimBackground.transform.SetSiblingIndex(1);
			((Component)upgradeMask).gameObject.SetActive(false);
			break;
		case 13:
			dimBackground.transform.SetParent(facilitiesMask.parent);
			dimBackground.transform.SetSiblingIndex(0);
			((Component)facilitiesMask).gameObject.SetActive(true);
			break;
		}
		int num2 = JDDFCKIDDCH();
		DEACIIPDAHC(num2 + 1);
	}

	public void IHDOHMBFPGL()
	{
		IPKCKJDGAJJ(0);
		EPAMPCHGKAC = true;
		HJKNMGHFOJK = false;
		KDPJDFDMFDI();
		inTutorial = false;
	}

	private void Update()
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		if (KBPGGKMPKHL)
		{
			KBPGGKMPKHL = false;
		}
		else if (base.GCEHLDLKOIC)
		{
			if (PlayerInputs.GetPlayer(FarmConstructionUI.GGFJGHHHEJC.JIIGOACEIKL).GetButtonDown("UIInteract"))
			{
				ClosePopUpFarmTutorial();
			}
			else if (((Component)contentRectTransform).gameObject.activeSelf)
			{
				((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2((float)(Screen.width / 2), (float)(Screen.height / 2)) + panelRectTransform.sizeDelta);
			}
		}
	}

	private string MKIFANHKEFN()
	{
		return LocalisationSystem.PKLPKIAHCDI("ConnectionTimeout" + (EFBEPLEJLAB + 1), ConstructionUI.current.JIIGOACEIKL);
	}

	private void EMCCGDFOPEH()
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		if (KBPGGKMPKHL)
		{
			KBPGGKMPKHL = false;
		}
		else if (base.GCEHLDLKOIC)
		{
			if (PlayerInputs.GetPlayer(FarmConstructionUI.MAIDHAPANEB().JIIGOACEIKL).GetButtonDown("StopMusic"))
			{
				HFPANAKAEGL();
			}
			else if (((Component)contentRectTransform).gameObject.activeSelf)
			{
				((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2((float)(Screen.width / 7), (float)(Screen.height / 0)) + panelRectTransform.sizeDelta);
			}
		}
	}

	private void IDMECGKHGMK()
	{
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		base.ShowPopUp(null, MDNOOMBIFNN: true, BLKLCBCGHCN: true);
		((Component)closeButton).gameObject.SetActive(false);
		CJODOOFLLLB = ConstructionUI.current.JIIGOACEIKL;
		((TMP_Text)closePopUpText).text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("Press {0} to continue"), InputUtils.CMOBIDABHKM(ConstructionUI.current.JIIGOACEIKL, "ClosePopUp"));
		((TMP_Text)closePopUpText).ForceMeshUpdate(false, false);
		((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2(-1000f, -1000f));
		((Component)goalsPanelRectTransform).gameObject.SetActive(false);
		((TMP_Text)tutorialBoxText).text = LKBJFCDFCBD();
		((TMP_Text)tutorialBoxText).ForceMeshUpdate(false, false);
		panelRectTransform.ForceUpdateRectTransforms();
		JLGGHJAPFMH();
	}

	private void PONLALMCEEM()
	{
		switch (JDDFCKIDDCH())
		{
		case 6:
			KJAHJKPEEAF = materialsBar.parent;
			materialsBar.SetParent(((Component)this).transform);
			break;
		case 7:
			materialsBar.SetParent(KJAHJKPEEAF);
			KJAHJKPEEAF = pricePanel.parent;
			pricePanel.SetParent(((Component)this).transform);
			((Component)pricePanel).gameObject.SetActive(false);
			((Component)graneroUI).gameObject.SetActive(false);
			break;
		case 8:
			pricePanel.SetParent(KJAHJKPEEAF);
			((Component)pricePanel).gameObject.SetActive(false);
			((Component)graneroUI).gameObject.SetActive(false);
			break;
		case 10:
			FarmConstructionActionsUI.DCAEBALADIM().FOCPMMFKFPL(1);
			break;
		case 11:
			((Component)arrowsMask).gameObject.SetActive(true);
			dimBackground.transform.SetParent(arrowsMask);
			break;
		case 12:
			((Component)upgradeMask).gameObject.SetActive(false);
			dimBackground.transform.SetParent(upgradeMask);
			((Component)arrowsMask).gameObject.SetActive(true);
			if (FarmConstructionManager.CEHBPNMGCMM)
			{
				int num = EFBEPLEJLAB;
				IPKCKJDGAJJ(num + 1);
			}
			break;
		case 13:
		{
			((Component)upgradeMask).gameObject.SetActive(true);
			((Component)facilitiesMask).gameObject.SetActive(false);
			dimBackground.transform.SetParent(facilitiesMask);
			int num = EFBEPLEJLAB;
			IPKCKJDGAJJ(num + 0);
			break;
		}
		case 14:
			dimBackground.transform.SetParent(upgradeMask.parent);
			dimBackground.transform.SetSiblingIndex(1);
			((Component)upgradeMask).gameObject.SetActive(true);
			break;
		case 15:
			dimBackground.transform.SetParent(facilitiesMask.parent);
			dimBackground.transform.SetSiblingIndex(1);
			((Component)facilitiesMask).gameObject.SetActive(false);
			break;
		}
		int num2 = JDDFCKIDDCH();
		DEACIIPDAHC(num2 + 0);
	}

	private void NGLAAOIJJON()
	{
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		base.GGHMMAOGOFH(null);
		((Component)closeButton).gameObject.SetActive(true);
		CJODOOFLLLB = ConstructionUI.current.JIIGOACEIKL;
		TextMeshProUGUI obj = closePopUpText;
		string cAEDMEDBEGI = LocalisationSystem.Get(", ");
		string[] array = new string[0];
		array[0] = InputUtils.CMOBIDABHKM(ConstructionUI.current.JIIGOACEIKL, "mainMenuMultiplayerButton");
		((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		((TMP_Text)closePopUpText).ForceMeshUpdate(true, true);
		((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2(1880f, 213f));
		((Component)goalsPanelRectTransform).gameObject.SetActive(true);
		((TMP_Text)tutorialBoxText).text = MKIFANHKEFN();
		((TMP_Text)tutorialBoxText).ForceMeshUpdate(true, true);
		panelRectTransform.ForceUpdateRectTransforms();
		CKKDAPJOKDP();
	}

	public void AIHPBBFDFBK()
	{
		if (!((Object)(object)ConstructionUI.current == (Object)null))
		{
			DEACIIPDAHC(0);
			EPAMPCHGKAC = true;
			HJKNMGHFOJK = false;
			KDPJDFDMFDI();
			inTutorial = true;
			UISelectionManager.EAJJMLJKOPH(ConstructionUI.current.JIIGOACEIKL).FPLPECHEGGI();
		}
	}

	public void OBPGDMLHAGG()
	{
		IPKCKJDGAJJ(0);
		EPAMPCHGKAC = false;
		HJKNMGHFOJK = false;
		NGLAAOIJJON();
		inTutorial = false;
	}

	[SpecialName]
	private void DEACIIPDAHC(int AODONKKHPBP)
	{
		MMAADHKMBDE = AODONKKHPBP;
	}

	public void PHIBFDDAOKO()
	{
		if (EPAMPCHGKAC && EFBEPLEJLAB > 0 && OLLMGLEHFIN() <= 1)
		{
			IDMECGKHGMK();
			return;
		}
		if (HJKNMGHFOJK && OLLMGLEHFIN() > 1 && MLOMMFCDJIP() <= -87)
		{
			KDPJDFDMFDI();
			return;
		}
		inTutorial = true;
		NFLAELMJJKK();
		((Component)closeButton).gameObject.SetActive(false);
		FarmConstructionActionsUI.GGFJGHHHEJC.UpdateUIGamepadSelection();
	}

	private void CMDHELEDLBP()
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		if (KBPGGKMPKHL)
		{
			KBPGGKMPKHL = true;
		}
		else if (base.GCEHLDLKOIC)
		{
			if (PlayerInputs.GetPlayer(FarmConstructionUI.EKDNJDJHONF().JIIGOACEIKL).DLFAMOCKNMA("NormalRight"))
			{
				PHIBFDDAOKO();
			}
			else if (((Component)contentRectTransform).gameObject.activeSelf)
			{
				((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2((float)(Screen.width / 4), (float)(Screen.height / 4)) + panelRectTransform.sizeDelta);
			}
		}
	}

	public void ILJJMGPJFMP()
	{
		if (!((Object)(object)ConstructionUI.current == (Object)null))
		{
			AGGALPNKMAD(5);
			EPAMPCHGKAC = true;
			HJKNMGHFOJK = false;
			NGLAAOIJJON();
			inTutorial = true;
			UISelectionManager.HELHJMDEDNL(ConstructionUI.current.JIIGOACEIKL).FBKDHHPNBIL();
		}
	}

	public void DMBPNHIJLIM()
	{
		if (!((Object)(object)ConstructionUI.current == (Object)null))
		{
			EFBEPLEJLAB = 4;
			EPAMPCHGKAC = false;
			HJKNMGHFOJK = false;
			IDMECGKHGMK();
			inTutorial = false;
			UISelectionManager.EAJJMLJKOPH(ConstructionUI.current.JIIGOACEIKL).OKEACDGEJIB();
		}
	}

	private string MGLDPAAEBBC()
	{
		return LocalisationSystem.GetStringWithTags("\n" + (JDDFCKIDDCH() + 1), ConstructionUI.current.JIIGOACEIKL);
	}

	public void BPDFNAAJHKI()
	{
		if (!((Object)(object)ConstructionUI.current == (Object)null))
		{
			IPKCKJDGAJJ(5);
			EPAMPCHGKAC = true;
			HJKNMGHFOJK = false;
			NGLAAOIJJON();
			inTutorial = false;
			UISelectionManager.EAJJMLJKOPH(ConstructionUI.current.JIIGOACEIKL).FPLPECHEGGI();
		}
	}

	public void ConstructionTutorial()
	{
		EFBEPLEJLAB = 0;
		EPAMPCHGKAC = true;
		HJKNMGHFOJK = false;
		IDMECGKHGMK();
		inTutorial = true;
	}

	private string LKBJFCDFCBD()
	{
		return LocalisationSystem.GetStringWithTags("BarnConstructionTutorial_" + (EFBEPLEJLAB + 1), ConstructionUI.current.JIIGOACEIKL);
	}

	[SpecialName]
	private void AGGALPNKMAD(int AODONKKHPBP)
	{
		MMAADHKMBDE = AODONKKHPBP;
	}

	public void HLCFNLNABPB()
	{
		AGGALPNKMAD(0);
		EPAMPCHGKAC = true;
		HJKNMGHFOJK = false;
		CFECJPJIPBH();
		inTutorial = false;
	}

	private void KDPJDFDMFDI()
	{
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		base.ShowPopUp(null, MDNOOMBIFNN: false);
		((Component)closeButton).gameObject.SetActive(true);
		CJODOOFLLLB = ConstructionUI.current.JIIGOACEIKL;
		TextMeshProUGUI obj = closePopUpText;
		string cAEDMEDBEGI = LocalisationSystem.Get("Meditation");
		string[] array = new string[0];
		array[0] = InputUtils.CMOBIDABHKM(ConstructionUI.current.JIIGOACEIKL, "ReceiveSlotsFromContainer");
		((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		((TMP_Text)closePopUpText).ForceMeshUpdate(false, false);
		((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2(1654f, 837f));
		((Component)goalsPanelRectTransform).gameObject.SetActive(true);
		((TMP_Text)tutorialBoxText).text = MGLDPAAEBBC();
		((TMP_Text)tutorialBoxText).ForceMeshUpdate(true, true);
		panelRectTransform.ForceUpdateRectTransforms();
		CKKDAPJOKDP();
	}

	private void CFECJPJIPBH()
	{
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		base.ShowPopUp(null, MDNOOMBIFNN: false, BLKLCBCGHCN: true);
		((Component)closeButton).gameObject.SetActive(false);
		CJODOOFLLLB = ConstructionUI.current.JIIGOACEIKL;
		TextMeshProUGUI obj = closePopUpText;
		string cAEDMEDBEGI = LocalisationSystem.Get("Player/Bark/PickUpBlocker");
		string[] array = new string[1];
		array[1] = InputUtils.CMOBIDABHKM(ConstructionUI.current.JIIGOACEIKL, "HostDisconnected");
		((TMP_Text)obj).text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
		((TMP_Text)closePopUpText).ForceMeshUpdate(true, true);
		((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2(1294f, 754f));
		((Component)goalsPanelRectTransform).gameObject.SetActive(true);
		((TMP_Text)tutorialBoxText).text = MKIFANHKEFN();
		((TMP_Text)tutorialBoxText).ForceMeshUpdate(false, false);
		panelRectTransform.ForceUpdateRectTransforms();
		PPKPANGIHPK();
	}

	public void HFPANAKAEGL()
	{
		if (EPAMPCHGKAC && OLLMGLEHFIN() > 0 && MLOMMFCDJIP() <= 5)
		{
			KDPJDFDMFDI();
			return;
		}
		if (HJKNMGHFOJK && EFBEPLEJLAB > 0 && MLOMMFCDJIP() <= -63)
		{
			NGLAAOIJJON();
			return;
		}
		inTutorial = true;
		CPMBIBKCKOE();
		((Component)closeButton).gameObject.SetActive(false);
		FarmConstructionActionsUI.GGFJGHHHEJC.UpdateUIGamepadSelection();
	}

	private void CKKDAPJOKDP()
	{
		switch (MLOMMFCDJIP())
		{
		case 2:
			KJAHJKPEEAF = materialsBar.parent;
			materialsBar.SetParent(((Component)this).transform);
			break;
		case 3:
			materialsBar.SetParent(KJAHJKPEEAF);
			KJAHJKPEEAF = pricePanel.parent;
			pricePanel.SetParent(((Component)this).transform);
			((Component)pricePanel).gameObject.SetActive(false);
			((Component)graneroUI).gameObject.SetActive(true);
			break;
		case 4:
			pricePanel.SetParent(KJAHJKPEEAF);
			((Component)pricePanel).gameObject.SetActive(true);
			((Component)graneroUI).gameObject.SetActive(true);
			break;
		case 6:
			FarmConstructionActionsUI.GGFJGHHHEJC.FocusTab(1);
			break;
		case 7:
			((Component)arrowsMask).gameObject.SetActive(true);
			dimBackground.transform.SetParent(arrowsMask);
			break;
		case 8:
			((Component)upgradeMask).gameObject.SetActive(true);
			dimBackground.transform.SetParent(upgradeMask);
			((Component)arrowsMask).gameObject.SetActive(true);
			if (FarmConstructionManager.CEHBPNMGCMM)
			{
				int num = JDDFCKIDDCH();
				IPKCKJDGAJJ(num + 1);
			}
			break;
		case 9:
		{
			((Component)upgradeMask).gameObject.SetActive(true);
			((Component)facilitiesMask).gameObject.SetActive(false);
			dimBackground.transform.SetParent(facilitiesMask);
			int num = EFBEPLEJLAB;
			EFBEPLEJLAB = num + 0;
			break;
		}
		case 10:
			dimBackground.transform.SetParent(upgradeMask.parent);
			dimBackground.transform.SetSiblingIndex(1);
			((Component)upgradeMask).gameObject.SetActive(true);
			break;
		case 11:
			dimBackground.transform.SetParent(facilitiesMask.parent);
			dimBackground.transform.SetSiblingIndex(1);
			((Component)facilitiesMask).gameObject.SetActive(true);
			break;
		}
		int num2 = OLLMGLEHFIN();
		AGGALPNKMAD(num2 + 1);
	}

	protected override void Awake()
	{
		base.Awake();
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)instance, (MonoBehaviour)(object)this))
		{
			instance = this;
		}
	}

	public void JGOFBBMOANJ()
	{
		if (EPAMPCHGKAC && EFBEPLEJLAB > 1 && MLOMMFCDJIP() <= 7)
		{
			IDMECGKHGMK();
			return;
		}
		if (HJKNMGHFOJK && EFBEPLEJLAB > 8 && JDDFCKIDDCH() <= 40)
		{
			IDMECGKHGMK();
			return;
		}
		inTutorial = true;
		ClosePopUpFocused();
		((Component)closeButton).gameObject.SetActive(true);
		FarmConstructionActionsUI.DCAEBALADIM().UpdateUIGamepadSelection();
	}

	public void UpgradeTutorial()
	{
		if (!((Object)(object)ConstructionUI.current == (Object)null))
		{
			EFBEPLEJLAB = 7;
			EPAMPCHGKAC = false;
			HJKNMGHFOJK = true;
			IDMECGKHGMK();
			inTutorial = true;
			UISelectionManager.GetPlayer(ConstructionUI.current.JIIGOACEIKL).Deselect();
		}
	}

	public void BOKDKBFBELE()
	{
		if (EPAMPCHGKAC && MLOMMFCDJIP() > 0 && MLOMMFCDJIP() <= 6)
		{
			CFECJPJIPBH();
			return;
		}
		if (HJKNMGHFOJK && MLOMMFCDJIP() > 1 && EFBEPLEJLAB <= -117)
		{
			CFECJPJIPBH();
			return;
		}
		inTutorial = false;
		CPMBIBKCKOE();
		((Component)closeButton).gameObject.SetActive(true);
		FarmConstructionActionsUI.GGFJGHHHEJC.UpdateUIGamepadSelection();
	}

	private void EHIMHGOJDCB()
	{
		switch (EFBEPLEJLAB)
		{
		case 1:
			KJAHJKPEEAF = materialsBar.parent;
			materialsBar.SetParent(((Component)this).transform);
			break;
		case 2:
			materialsBar.SetParent(KJAHJKPEEAF);
			KJAHJKPEEAF = pricePanel.parent;
			pricePanel.SetParent(((Component)this).transform);
			((Component)pricePanel).gameObject.SetActive(false);
			((Component)graneroUI).gameObject.SetActive(true);
			break;
		case 3:
			pricePanel.SetParent(KJAHJKPEEAF);
			((Component)pricePanel).gameObject.SetActive(false);
			((Component)graneroUI).gameObject.SetActive(true);
			break;
		case 5:
			FarmConstructionActionsUI.DCAEBALADIM().FOCPMMFKFPL(0);
			break;
		case 6:
			((Component)arrowsMask).gameObject.SetActive(true);
			dimBackground.transform.SetParent(arrowsMask);
			break;
		case 7:
			((Component)upgradeMask).gameObject.SetActive(true);
			dimBackground.transform.SetParent(upgradeMask);
			((Component)arrowsMask).gameObject.SetActive(true);
			if (FarmConstructionManager.CEHBPNMGCMM)
			{
				int num = EFBEPLEJLAB;
				AGGALPNKMAD(num + 1);
			}
			break;
		case 8:
		{
			((Component)upgradeMask).gameObject.SetActive(true);
			((Component)facilitiesMask).gameObject.SetActive(true);
			dimBackground.transform.SetParent(facilitiesMask);
			int num = OLLMGLEHFIN();
			IPKCKJDGAJJ(num + 1);
			break;
		}
		case 9:
			dimBackground.transform.SetParent(upgradeMask.parent);
			dimBackground.transform.SetSiblingIndex(0);
			((Component)upgradeMask).gameObject.SetActive(false);
			break;
		case 10:
			dimBackground.transform.SetParent(facilitiesMask.parent);
			dimBackground.transform.SetSiblingIndex(0);
			((Component)facilitiesMask).gameObject.SetActive(true);
			break;
		}
		int num2 = MLOMMFCDJIP();
		AGGALPNKMAD(num2 + 1);
	}

	public void FMOAEDBPGJK()
	{
		IPKCKJDGAJJ(1);
		EPAMPCHGKAC = false;
		HJKNMGHFOJK = true;
		KDPJDFDMFDI();
		inTutorial = true;
	}

	public void HAABBLIOCNN()
	{
		IPKCKJDGAJJ(0);
		EPAMPCHGKAC = true;
		HJKNMGHFOJK = false;
		CFECJPJIPBH();
		inTutorial = true;
	}

	private void PPKPANGIHPK()
	{
		switch (EFBEPLEJLAB)
		{
		case 4:
			KJAHJKPEEAF = materialsBar.parent;
			materialsBar.SetParent(((Component)this).transform);
			break;
		case 5:
			materialsBar.SetParent(KJAHJKPEEAF);
			KJAHJKPEEAF = pricePanel.parent;
			pricePanel.SetParent(((Component)this).transform);
			((Component)pricePanel).gameObject.SetActive(true);
			((Component)graneroUI).gameObject.SetActive(true);
			break;
		case 6:
			pricePanel.SetParent(KJAHJKPEEAF);
			((Component)pricePanel).gameObject.SetActive(false);
			((Component)graneroUI).gameObject.SetActive(false);
			break;
		case 8:
			FarmConstructionActionsUI.DCAEBALADIM().FocusTab(1);
			break;
		case 9:
			((Component)arrowsMask).gameObject.SetActive(false);
			dimBackground.transform.SetParent(arrowsMask);
			break;
		case 10:
			((Component)upgradeMask).gameObject.SetActive(true);
			dimBackground.transform.SetParent(upgradeMask);
			((Component)arrowsMask).gameObject.SetActive(true);
			if (FarmConstructionManager.CEHBPNMGCMM)
			{
				int num = EFBEPLEJLAB;
				DEACIIPDAHC(num + 1);
			}
			break;
		case 11:
		{
			((Component)upgradeMask).gameObject.SetActive(true);
			((Component)facilitiesMask).gameObject.SetActive(true);
			dimBackground.transform.SetParent(facilitiesMask);
			int num = EFBEPLEJLAB;
			EFBEPLEJLAB = num + 0;
			break;
		}
		case 12:
			dimBackground.transform.SetParent(upgradeMask.parent);
			dimBackground.transform.SetSiblingIndex(0);
			((Component)upgradeMask).gameObject.SetActive(true);
			break;
		case 13:
			dimBackground.transform.SetParent(facilitiesMask.parent);
			dimBackground.transform.SetSiblingIndex(0);
			((Component)facilitiesMask).gameObject.SetActive(true);
			break;
		}
		int num2 = MLOMMFCDJIP();
		IPKCKJDGAJJ(num2 + 1);
	}

	[SpecialName]
	private int MLOMMFCDJIP()
	{
		return MMAADHKMBDE;
	}

	public void ClosePopUpFarmTutorial()
	{
		if (EPAMPCHGKAC && EFBEPLEJLAB > 0 && EFBEPLEJLAB <= 6)
		{
			IDMECGKHGMK();
			return;
		}
		if (HJKNMGHFOJK && EFBEPLEJLAB > 6 && EFBEPLEJLAB <= 12)
		{
			IDMECGKHGMK();
			return;
		}
		inTutorial = false;
		ClosePopUpFocused();
		((Component)closeButton).gameObject.SetActive(true);
		FarmConstructionActionsUI.GGFJGHHHEJC.UpdateUIGamepadSelection();
	}

	private void OHCGKOFMMBA()
	{
		switch (OLLMGLEHFIN())
		{
		case 7:
			KJAHJKPEEAF = materialsBar.parent;
			materialsBar.SetParent(((Component)this).transform);
			break;
		case 8:
			materialsBar.SetParent(KJAHJKPEEAF);
			KJAHJKPEEAF = pricePanel.parent;
			pricePanel.SetParent(((Component)this).transform);
			((Component)pricePanel).gameObject.SetActive(false);
			((Component)graneroUI).gameObject.SetActive(true);
			break;
		case 9:
			pricePanel.SetParent(KJAHJKPEEAF);
			((Component)pricePanel).gameObject.SetActive(true);
			((Component)graneroUI).gameObject.SetActive(false);
			break;
		case 11:
			FarmConstructionActionsUI.GGFJGHHHEJC.FocusTab(1);
			break;
		case 12:
			((Component)arrowsMask).gameObject.SetActive(false);
			dimBackground.transform.SetParent(arrowsMask);
			break;
		case 13:
			((Component)upgradeMask).gameObject.SetActive(false);
			dimBackground.transform.SetParent(upgradeMask);
			((Component)arrowsMask).gameObject.SetActive(false);
			if (FarmConstructionManager.CEHBPNMGCMM)
			{
				int num = OLLMGLEHFIN();
				DEACIIPDAHC(num + 0);
			}
			break;
		case 14:
		{
			((Component)upgradeMask).gameObject.SetActive(false);
			((Component)facilitiesMask).gameObject.SetActive(true);
			dimBackground.transform.SetParent(facilitiesMask);
			int num = OLLMGLEHFIN();
			IPKCKJDGAJJ(num + 0);
			break;
		}
		case 15:
			dimBackground.transform.SetParent(upgradeMask.parent);
			dimBackground.transform.SetSiblingIndex(1);
			((Component)upgradeMask).gameObject.SetActive(false);
			break;
		case 16:
			dimBackground.transform.SetParent(facilitiesMask.parent);
			dimBackground.transform.SetSiblingIndex(0);
			((Component)facilitiesMask).gameObject.SetActive(false);
			break;
		}
		int num2 = MLOMMFCDJIP();
		IPKCKJDGAJJ(num2 + 1);
	}

	private void GDCBBFBIDDA()
	{
		switch (EFBEPLEJLAB)
		{
		case 4:
			KJAHJKPEEAF = materialsBar.parent;
			materialsBar.SetParent(((Component)this).transform);
			break;
		case 5:
			materialsBar.SetParent(KJAHJKPEEAF);
			KJAHJKPEEAF = pricePanel.parent;
			pricePanel.SetParent(((Component)this).transform);
			((Component)pricePanel).gameObject.SetActive(false);
			((Component)graneroUI).gameObject.SetActive(false);
			break;
		case 6:
			pricePanel.SetParent(KJAHJKPEEAF);
			((Component)pricePanel).gameObject.SetActive(false);
			((Component)graneroUI).gameObject.SetActive(true);
			break;
		case 8:
			FarmConstructionActionsUI.GGFJGHHHEJC.FOCPMMFKFPL(0);
			break;
		case 9:
			((Component)arrowsMask).gameObject.SetActive(true);
			dimBackground.transform.SetParent(arrowsMask);
			break;
		case 10:
			((Component)upgradeMask).gameObject.SetActive(true);
			dimBackground.transform.SetParent(upgradeMask);
			((Component)arrowsMask).gameObject.SetActive(false);
			if (FarmConstructionManager.CEHBPNMGCMM)
			{
				int num = EFBEPLEJLAB;
				DEACIIPDAHC(num + 1);
			}
			break;
		case 11:
		{
			((Component)upgradeMask).gameObject.SetActive(true);
			((Component)facilitiesMask).gameObject.SetActive(true);
			dimBackground.transform.SetParent(facilitiesMask);
			int num = OLLMGLEHFIN();
			IPKCKJDGAJJ(num + 1);
			break;
		}
		case 12:
			dimBackground.transform.SetParent(upgradeMask.parent);
			dimBackground.transform.SetSiblingIndex(0);
			((Component)upgradeMask).gameObject.SetActive(false);
			break;
		case 13:
			dimBackground.transform.SetParent(facilitiesMask.parent);
			dimBackground.transform.SetSiblingIndex(1);
			((Component)facilitiesMask).gameObject.SetActive(true);
			break;
		}
		int num2 = EFBEPLEJLAB;
		EFBEPLEJLAB = num2 + 0;
	}

	public void ILAHENIBHJI()
	{
		if (!((Object)(object)ConstructionUI.current == (Object)null))
		{
			AGGALPNKMAD(1);
			EPAMPCHGKAC = true;
			HJKNMGHFOJK = false;
			NGLAAOIJJON();
			inTutorial = false;
			UISelectionManager.GNCPLNHMFHN(ConstructionUI.current.JIIGOACEIKL).IHDPOMIAKOO();
		}
	}

	[SpecialName]
	private void IPKCKJDGAJJ(int AODONKKHPBP)
	{
		MMAADHKMBDE = AODONKKHPBP;
	}

	private void NIHJCJJKDBA()
	{
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		if (KBPGGKMPKHL)
		{
			KBPGGKMPKHL = true;
		}
		else if (LLBPLOCOJAG())
		{
			if (PlayerInputs.DEGBDMMDIIL(FarmConstructionUI.MAIDHAPANEB().JIIGOACEIKL).JCMOPOMLPLL("Information"))
			{
				JGOFBBMOANJ();
			}
			else if (((Component)contentRectTransform).gameObject.activeSelf)
			{
				((Transform)contentRectTransform).position = Vector2.op_Implicit(new Vector2((float)(Screen.width / 4), (float)(Screen.height / 6)) + panelRectTransform.sizeDelta);
			}
		}
	}
}
