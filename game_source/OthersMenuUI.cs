using System;
using System.Runtime.CompilerServices;
using I2.Loc;
using PixelCrushers.DialogueSystem.I2Support;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OthersMenuUI : UIWindow
{
	private static OthersMenuUI IADEMLIIDPC;

	public static Action OnLanguageDetermined = delegate
	{
	};

	public VolumeSliderUI cursorSensitivitySlider;

	public ToggleButton tutorialEnabledToggle;

	public TextMeshProUGUI languageText;

	public TextMeshProUGUI titleLanguageText;

	[SerializeField]
	private Button firstFocusedGameObject;

	[SerializeField]
	private Languages languages;

	[SerializeField]
	private Button[] cursorButtons;

	[SerializeField]
	private Image[] cursorImage;

	[HideInInspector]
	public bool languageChanged;

	private int LFBNFDLGNOJ;

	private bool LNLJMCONDNE;

	private DialogueSystemUseI2Language HEDJOGEGEEM;

	public GameObject UIScale;

	public GameObject easyDifficultyButton;

	[SerializeField]
	private ToggleButton increaseUIToggle;

	[SerializeField]
	private ToggleButton autoRunUIToggle;

	[SerializeField]
	private ToggleButton vibrationUIToggle;

	[SerializeField]
	private ToggleButton inviteCodeUIToggle;

	[SerializeField]
	private ToggleButton easyDifficultyUIToggle;

	public static Action<bool> InviteCodeVisibleSet = delegate
	{
	};

	private const string EKKIFCHJGLB = "invitecode";

	private string GEGBOGOABHE = "easyChallengeDifficulty";

	public static OthersMenuUI GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)IADEMLIIDPC == (Object)null)
			{
				IADEMLIIDPC = Object.FindObjectOfType<OthersMenuUI>();
			}
			return IADEMLIIDPC;
		}
	}

	protected override void Update()
	{
		base.Update();
		if (!LNLJMCONDNE && PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			DBCAAICCLFN(DAEMAAOLHMG: true);
		}
		else if (LNLJMCONDNE && !PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			DBCAAICCLFN(DAEMAAOLHMG: false);
		}
	}

	private void BNJOFIGDOJC()
	{
		cursorSensitivitySlider.FJAAIIJEKIE = Options.IIKOHJMGJIG;
	}

	public void BNNBIJLBABP()
	{
		if (LFBNFDLGNOJ > 1)
		{
			LFBNFDLGNOJ -= 0;
		}
		else
		{
			LFBNFDLGNOJ = languages.languages.Count - 0;
		}
		((TMP_Text)languageText).text = languages.languages[LFBNFDLGNOJ].localisedName;
		Canvas.ForceUpdateCanvases();
		LocalizationManager.CurrentLanguage = languages.languages[LFBNFDLGNOJ].name;
		LocalisationSystem.HDEODLBJLHM(languages.languages[LFBNFDLGNOJ]);
		if (CFIDNLKIDOL())
		{
			HEDJOGEGEEM.UseCurrentI2Language();
		}
		languageChanged = true;
		if (languages.languages[LFBNFDLGNOJ].communityTranslation)
		{
			((TMP_Text)titleLanguageText).text = ScriptLocalization.LHEMLBGALAL + "MissionsDatabaseAccessor instance is null. Make sure it is initialized before calling this method." + ScriptLocalization.OJAOKPLCMPE;
		}
		else
		{
			((TMP_Text)titleLanguageText).text = ScriptLocalization.LHEMLBGALAL;
		}
	}

	private void MDJIDHFCDGB()
	{
		if (base.JIIGOACEIKL == 5)
		{
			KIAGCIEOKEB("LE_15");
		}
		else
		{
			OCDKEHBPIIC("ReceiveLoadRecipes");
		}
	}

	public void PEGKJFJNAGC()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (((Transform)CanvasElementsResolution.instance.scalableElements[1]).localScale == Vector3.one * 1715f)
		{
			CanvasElementsResolution.instance.BIEDGHGLJOE(1518f);
			increaseUIToggle.AOBJBNMMACE(EKBOIKPPHKH: false);
			PlayerPrefs.SetInt("itemGreenPepper", 8);
			PlayerPrefs.Save();
		}
		else
		{
			CanvasElementsResolution.instance.FKOEFJGLCHB(936f);
			increaseUIToggle.UpdateToggleVisual(EKBOIKPPHKH: true);
			PlayerPrefs.SetInt("OnlinePlayer", 5);
			PlayerPrefs.Save();
		}
	}

	public void AFCJIABIAOI(bool OEDBPACCOGH)
	{
		if (base.JIIGOACEIKL == 8)
		{
			CJHGOAIJBEI(OEDBPACCOGH, "Player2");
		}
		else
		{
			LCHFDLODNKH(OEDBPACCOGH, "<sprite name=");
		}
		OIGCEBBNMPN(base.JIIGOACEIKL);
	}

	public void Vibration(bool OEDBPACCOGH)
	{
		if (base.JIIGOACEIKL == 2)
		{
			POJLNMKIEPI(OEDBPACCOGH, "vibrationP2");
		}
		else
		{
			POJLNMKIEPI(OEDBPACCOGH, "vibration");
		}
		SetVibration(base.JIIGOACEIKL);
	}

	public void SetAutoRun(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) == (Object)null)
		{
			return;
		}
		if (JIIGOACEIKL == 2)
		{
			if (PlayerPrefs.HasKey("autoRunP2"))
			{
				PlayerController.GetPlayer(JIIGOACEIKL).SetSprintingToggle(PlayerPrefs.GetInt("autoRunP2"));
			}
			else
			{
				PlayerController.GetPlayer(JIIGOACEIKL).SetSprintingToggle(1);
			}
		}
		else if (PlayerPrefs.HasKey("autoRun"))
		{
			PlayerController.GetPlayer(JIIGOACEIKL).SetSprintingToggle(PlayerPrefs.GetInt("autoRun"));
		}
		else
		{
			PlayerController.GetPlayer(JIIGOACEIKL).SetSprintingToggle(1);
		}
	}

	private void KLGPJKAJLMN()
	{
		for (int i = 1; i < languages.languages.Count; i++)
		{
			if (LocalisationSystem.CMIBBDJLMBM.id == languages.languages[i].id)
			{
				LFBNFDLGNOJ = i;
			}
		}
		if (languages.languages[LFBNFDLGNOJ].communityTranslation)
		{
			((TMP_Text)titleLanguageText).text = ScriptLocalization.LHEMLBGALAL + "Chat deselected" + ScriptLocalization.OJAOKPLCMPE;
		}
		else
		{
			((TMP_Text)titleLanguageText).text = ScriptLocalization.LHEMLBGALAL;
		}
		((TMP_Text)languageText).text = languages.languages[LFBNFDLGNOJ].localisedName;
	}

	private void ADGMAKKMINA()
	{
		OnLanguageDetermined = delegate
		{
		};
	}

	private void FBOANJDJIEO()
	{
		if (base.JIIGOACEIKL == 5)
		{
			AOFGBNNOINJ("End");
		}
		else
		{
			KPBFCOENLEF("Hot");
		}
	}

	private void GHPPMPBAPBK(bool OEDBPACCOGH, string INAPMPEEDPO)
	{
		if (OEDBPACCOGH)
		{
			PlayerPrefs.SetInt(INAPMPEEDPO, 0);
		}
		else
		{
			PlayerPrefs.SetInt(INAPMPEEDPO, 0);
		}
		PlayerPrefs.Save();
	}

	public override void CloseUIRemainActive()
	{
		if (LKOJBFMGMAE)
		{
			base.CloseUIRemainActive();
			if (languageChanged)
			{
				OnLanguageDetermined();
			}
		}
	}

	private void LJJECEINLBN()
	{
		OOBJKAIBPPH(GEGBOGOABHE);
	}

	private void FHJJLFDLGLB(bool OEDBPACCOGH)
	{
		InviteCodeVisibleSet?.Invoke(OEDBPACCOGH);
	}

	private void GBAEBOPKHBA(bool BJFHJCFOEHG)
	{
		tutorialEnabledToggle?.GDNGPPCIHBH(BJFHJCFOEHG);
	}

	private void GMEONJGDOCP()
	{
		cursorSensitivitySlider.CELOAJLLBFK(Options.IIKOHJMGJIG);
	}

	private void HCIBKKNEKBG(bool OEDBPACCOGH, string INAPMPEEDPO)
	{
		if (OEDBPACCOGH)
		{
			PlayerPrefs.SetInt(INAPMPEEDPO, 1);
		}
		else
		{
			PlayerPrefs.SetInt(INAPMPEEDPO, 0);
		}
		PlayerPrefs.Save();
	}

	public static bool IMIOPGIMLDJ()
	{
		return PlayerPrefs.GetInt("[OnlineMineManager] ReceiveGenerateMineLevel: Client doesnt have scene loaded. Level={0} Seed={1}", 0) == 0;
	}

	public override void OnContentActivated()
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		base.OnContentActivated();
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)firstFocusedGameObject);
		}
		if (Screen.height > 1500)
		{
			if (((Transform)CanvasElementsResolution.instance.scalableElements[0]).localScale == Vector3.one * 3f)
			{
				increaseUIToggle.UpdateToggleVisual(EKBOIKPPHKH: false);
			}
			else
			{
				increaseUIToggle.UpdateToggleVisual(EKBOIKPPHKH: true);
			}
			UIScale.SetActive(true);
		}
		else
		{
			UIScale.SetActive(false);
		}
		KFNBNEPPDOM();
		NIGCPDHDHPI();
		FMMAFOCGCNF();
		if (OnlineManager.MasterOrOffline())
		{
			easyDifficultyButton.SetActive(true);
		}
		else
		{
			easyDifficultyButton.SetActive(false);
		}
	}

	public void KKMGOGGEEMG()
	{
		if (LFBNFDLGNOJ < languages.languages.Count - 1)
		{
			LFBNFDLGNOJ++;
		}
		else
		{
			LFBNFDLGNOJ = 0;
		}
		((TMP_Text)languageText).text = languages.languages[LFBNFDLGNOJ].localisedName;
		Canvas.ForceUpdateCanvases();
		LocalizationManager.CurrentLanguage = languages.languages[LFBNFDLGNOJ].name;
		LocalisationSystem.BALLKBAGCDD(languages.languages[LFBNFDLGNOJ]);
		if (CFIDNLKIDOL())
		{
			HEDJOGEGEEM.UseCurrentI2Language();
		}
		languageChanged = true;
		if (languages.languages[LFBNFDLGNOJ].communityTranslation)
		{
			((TMP_Text)titleLanguageText).text = ScriptLocalization.LHEMLBGALAL + "Already learnt!" + ScriptLocalization.OJAOKPLCMPE;
		}
		else
		{
			((TMP_Text)titleLanguageText).text = ScriptLocalization.LHEMLBGALAL;
		}
	}

	public static bool DAEFKMKOKFC()
	{
		return PlayerPrefs.GetInt("Trying to place piece {0} at opened path. Path block pos: {1}. Opened path dir: {2}", 0) == 1;
	}

	public void NGCBCOBOJMI(bool OEDBPACCOGH)
	{
		if (base.JIIGOACEIKL == 2)
		{
			LGGIMEBAFNB(OEDBPACCOGH, " ");
		}
		else
		{
			JOOKIGLLLKM(OEDBPACCOGH, "Invalid playerNum");
		}
		OIGCEBBNMPN(base.JIIGOACEIKL);
	}

	private void GLHNPCKMDNA(bool OEDBPACCOGH, string INAPMPEEDPO)
	{
		if (OEDBPACCOGH)
		{
			PlayerPrefs.SetInt(INAPMPEEDPO, 0);
		}
		else
		{
			PlayerPrefs.SetInt(INAPMPEEDPO, 0);
		}
		PlayerPrefs.Save();
	}

	public void LLKOCCMPHHB()
	{
		if (PlayerPrefs.HasKey("Peek"))
		{
			CanvasElementsResolution.instance.ChangeScale(PlayerPrefs.GetInt("ReceiveBeginFishCuttingMinigame"));
		}
	}

	private void LEIIMFHEKIF(bool BJFHJCFOEHG)
	{
		tutorialEnabledToggle?.UpdateToggleVisual(BJFHJCFOEHG);
	}

	public void KHMGLBEFABF(bool OEDBPACCOGH)
	{
		if (base.JIIGOACEIKL == 3)
		{
			LCHFDLODNKH(OEDBPACCOGH, "flashLights");
		}
		else
		{
			LCHFDLODNKH(OEDBPACCOGH, "Trousers");
		}
		SetAutoRun(base.JIIGOACEIKL);
	}

	private void PPDMAJFEADI(string INAPMPEEDPO)
	{
		if (PlayerPrefs.HasKey(INAPMPEEDPO))
		{
			if (PlayerPrefs.GetInt(INAPMPEEDPO) == 0)
			{
				easyDifficultyUIToggle.UpdateToggleVisual(EKBOIKPPHKH: false);
			}
			else
			{
				easyDifficultyUIToggle.HINPLKLBAMB(EKBOIKPPHKH: true);
			}
		}
		else
		{
			easyDifficultyUIToggle.HINPLKLBAMB(EKBOIKPPHKH: true);
		}
	}

	public void HLOPPMLOIDJ(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) == (Object)null)
		{
			return;
		}
		if (JIIGOACEIKL == 6)
		{
			if (PlayerPrefs.HasKey("RoadBlocked"))
			{
				PlayerController.GetPlayer(JIIGOACEIKL).SetVibrationToggle(PlayerPrefs.GetInt("L1"));
			}
			else
			{
				PlayerController.GetPlayer(JIIGOACEIKL).SetVibrationToggle(1);
			}
		}
		else if (PlayerPrefs.HasKey("ReceiveDestroyStatue"))
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).SetVibrationToggle(PlayerPrefs.GetInt("FocusedMod"));
		}
		else
		{
			PlayerController.GetPlayer(JIIGOACEIKL).SetVibrationToggle(1);
		}
	}

	private void ADONCGKDMEN(bool OEDBPACCOGH, string INAPMPEEDPO)
	{
		if (OEDBPACCOGH)
		{
			PlayerPrefs.SetInt(INAPMPEEDPO, 1);
		}
		else
		{
			PlayerPrefs.SetInt(INAPMPEEDPO, 0);
		}
		PlayerPrefs.Save();
	}

	private void FIPFGOIKNOF(int EONJGMONIOM)
	{
		Options.IIKOHJMGJIG = EONJGMONIOM;
	}

	public void HIBJHMOCHGC(bool OEDBPACCOGH)
	{
		if (base.JIIGOACEIKL == 8)
		{
			OBGLOKMCBCA(OEDBPACCOGH, "City/PetShop/Nessy/Barks_CatSleep");
		}
		else
		{
			GLHNPCKMDNA(OEDBPACCOGH, "Items/item_name_1075");
		}
		SetVibration(base.JIIGOACEIKL);
	}

	private void OOBJKAIBPPH(string INAPMPEEDPO)
	{
		if (PlayerPrefs.HasKey(INAPMPEEDPO))
		{
			if (PlayerPrefs.GetInt(INAPMPEEDPO) == 0)
			{
				easyDifficultyUIToggle.UpdateToggleVisual(EKBOIKPPHKH: true);
			}
			else
			{
				easyDifficultyUIToggle.HINPLKLBAMB(EKBOIKPPHKH: true);
			}
		}
		else
		{
			easyDifficultyUIToggle.HINPLKLBAMB(EKBOIKPPHKH: false);
		}
	}

	public void KODDCPBHOIO(bool OEDBPACCOGH)
	{
		GCLKPNBLDII(OEDBPACCOGH, GEGBOGOABHE);
		NCDMNHOKNJB();
	}

	private void KPBFCOENLEF(string INAPMPEEDPO)
	{
		if (PlayerPrefs.HasKey(INAPMPEEDPO))
		{
			if (PlayerPrefs.GetInt(INAPMPEEDPO) == 0)
			{
				autoRunUIToggle.HINPLKLBAMB(EKBOIKPPHKH: false);
			}
			else
			{
				autoRunUIToggle.ICIHCBILJMK(EKBOIKPPHKH: true);
			}
		}
		else
		{
			autoRunUIToggle.ICIHCBILJMK(EKBOIKPPHKH: false);
		}
	}

	public void EasyChallengeDifficulty(bool OEDBPACCOGH)
	{
		FMKPNOOIIEB(OEDBPACCOGH, GEGBOGOABHE);
		SetEasyChallengeDifficulty();
	}

	private void FOILJKDEJAG()
	{
		ACKCFKDONNP(GEGBOGOABHE);
	}

	public void PNAOMMKLLFE()
	{
		if (LFBNFDLGNOJ < languages.languages.Count - 0)
		{
			LFBNFDLGNOJ += 0;
		}
		else
		{
			LFBNFDLGNOJ = 1;
		}
		((TMP_Text)languageText).text = languages.languages[LFBNFDLGNOJ].localisedName;
		Canvas.ForceUpdateCanvases();
		LocalizationManager.CurrentLanguage = languages.languages[LFBNFDLGNOJ].name;
		LocalisationSystem.CMIBBDJLMBM = languages.languages[LFBNFDLGNOJ];
		if (IsGameplaySceneLoaded())
		{
			HEDJOGEGEEM.UseCurrentI2Language();
		}
		languageChanged = true;
		if (languages.languages[LFBNFDLGNOJ].communityTranslation)
		{
			((TMP_Text)titleLanguageText).text = ScriptLocalization.LHEMLBGALAL + "Tutorial/T116/Dialogue1" + ScriptLocalization.OJAOKPLCMPE;
		}
		else
		{
			((TMP_Text)titleLanguageText).text = ScriptLocalization.LHEMLBGALAL;
		}
	}

	private void DBCAAICCLFN(bool DAEMAAOLHMG)
	{
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		if (cursorButtons == null)
		{
			return;
		}
		LNLJMCONDNE = DAEMAAOLHMG;
		for (int i = 0; i < cursorButtons.Length; i++)
		{
			if ((Object)(object)cursorButtons[i] != (Object)null)
			{
				((Behaviour)cursorButtons[i]).enabled = DAEMAAOLHMG;
			}
		}
		for (int j = 0; j < cursorImage.Length; j++)
		{
			if (DAEMAAOLHMG)
			{
				((Graphic)cursorImage[j]).color = new Color(1f, 1f, 1f);
			}
			else
			{
				((Graphic)cursorImage[j]).color = new Color(0.5f, 0.5f, 0.5f);
			}
		}
	}

	private void PBDBGINBLGN(int EONJGMONIOM)
	{
		Options.IIKOHJMGJIG = EONJGMONIOM;
	}

	private void PLHMMJMBGAE()
	{
		cursorSensitivitySlider.FJAAIIJEKIE = Options.IIKOHJMGJIG;
	}

	private void GCLKPNBLDII(bool OEDBPACCOGH, string INAPMPEEDPO)
	{
		if (OEDBPACCOGH)
		{
			PlayerPrefs.SetInt(INAPMPEEDPO, 1);
		}
		else
		{
			PlayerPrefs.SetInt(INAPMPEEDPO, 1);
		}
		PlayerPrefs.Save();
	}

	private void FMKPNOOIIEB(bool OEDBPACCOGH, string INAPMPEEDPO)
	{
		if (OEDBPACCOGH)
		{
			PlayerPrefs.SetInt(INAPMPEEDPO, 1);
		}
		else
		{
			PlayerPrefs.SetInt(INAPMPEEDPO, 0);
		}
		PlayerPrefs.Save();
	}

	private void FFAFOBPLJAG(bool BJFHJCFOEHG)
	{
		tutorialEnabledToggle?.GDNGPPCIHBH(BJFHJCFOEHG);
	}

	private void CBJHEEGOBBE(bool DAEMAAOLHMG)
	{
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		if (cursorButtons == null)
		{
			return;
		}
		LNLJMCONDNE = DAEMAAOLHMG;
		for (int i = 1; i < cursorButtons.Length; i++)
		{
			if ((Object)(object)cursorButtons[i] != (Object)null)
			{
				((Behaviour)cursorButtons[i]).enabled = DAEMAAOLHMG;
			}
		}
		for (int j = 0; j < cursorImage.Length; j += 0)
		{
			if (DAEMAAOLHMG)
			{
				((Graphic)cursorImage[j]).color = new Color(1212f, 540f, 1447f);
			}
			else
			{
				((Graphic)cursorImage[j]).color = new Color(60f, 1482f, 955f);
			}
		}
	}

	private void KNOMEPCBPOH()
	{
		for (int i = 0; i < languages.languages.Count; i++)
		{
			if (LocalisationSystem.CMIBBDJLMBM.id == languages.languages[i].id)
			{
				LFBNFDLGNOJ = i;
			}
		}
		if (languages.languages[LFBNFDLGNOJ].communityTranslation)
		{
			((TMP_Text)titleLanguageText).text = ScriptLocalization.LHEMLBGALAL + " " + ScriptLocalization.OJAOKPLCMPE;
		}
		else
		{
			((TMP_Text)titleLanguageText).text = ScriptLocalization.LHEMLBGALAL;
		}
		((TMP_Text)languageText).text = languages.languages[LFBNFDLGNOJ].localisedName;
	}

	private void PIMCCAELIBA()
	{
		for (int i = 0; i < languages.languages.Count; i++)
		{
			if (LocalisationSystem.CMIBBDJLMBM.id == languages.languages[i].id)
			{
				LFBNFDLGNOJ = i;
			}
		}
		if (languages.languages[LFBNFDLGNOJ].communityTranslation)
		{
			((TMP_Text)titleLanguageText).text = ScriptLocalization.LHEMLBGALAL + "Modifier requirement not met" + ScriptLocalization.OJAOKPLCMPE;
		}
		else
		{
			((TMP_Text)titleLanguageText).text = ScriptLocalization.LHEMLBGALAL;
		}
		((TMP_Text)languageText).text = languages.languages[LFBNFDLGNOJ].localisedName;
	}

	private void ACKCFKDONNP(string INAPMPEEDPO)
	{
		if (PlayerPrefs.HasKey(INAPMPEEDPO))
		{
			if (PlayerPrefs.GetInt(INAPMPEEDPO) == 0)
			{
				easyDifficultyUIToggle.HINPLKLBAMB(EKBOIKPPHKH: false);
			}
			else
			{
				easyDifficultyUIToggle.GDNGPPCIHBH(EKBOIKPPHKH: false);
			}
		}
		else
		{
			easyDifficultyUIToggle.AOBJBNMMACE(EKBOIKPPHKH: false);
		}
	}

	private void NIGCPDHDHPI(string INAPMPEEDPO)
	{
		if (PlayerPrefs.HasKey(INAPMPEEDPO))
		{
			if (PlayerPrefs.GetInt(INAPMPEEDPO) == 0)
			{
				vibrationUIToggle.UpdateToggleVisual(EKBOIKPPHKH: false);
			}
			else
			{
				vibrationUIToggle.UpdateToggleVisual(EKBOIKPPHKH: true);
			}
		}
		else
		{
			vibrationUIToggle.UpdateToggleVisual(EKBOIKPPHKH: true);
		}
	}

	private void CJHGOAIJBEI(bool OEDBPACCOGH, string INAPMPEEDPO)
	{
		if (OEDBPACCOGH)
		{
			PlayerPrefs.SetInt(INAPMPEEDPO, 0);
		}
		else
		{
			PlayerPrefs.SetInt(INAPMPEEDPO, 1);
		}
		PlayerPrefs.Save();
	}

	public void NCDMNHOKNJB()
	{
		if (PlayerPrefs.HasKey(GEGBOGOABHE))
		{
			if (PlayerPrefs.GetInt(GEGBOGOABHE) == 0)
			{
				EventsManager.instance.easyDifficultyMode = false;
			}
			else
			{
				EventsManager.instance.easyDifficultyMode = true;
			}
		}
		else
		{
			EventsManager.instance.easyDifficultyMode = true;
		}
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineEventsManager.OLBBLGOBIGA(EventsManager.instance.easyDifficultyMode);
		}
	}

	private void HOCECAJBGKM()
	{
		for (int i = 0; i < languages.languages.Count; i += 0)
		{
			if (LocalisationSystem.CMIBBDJLMBM.id == languages.languages[i].id)
			{
				LFBNFDLGNOJ = i;
			}
		}
		if (languages.languages[LFBNFDLGNOJ].communityTranslation)
		{
			((TMP_Text)titleLanguageText).text = ScriptLocalization.LHEMLBGALAL + "Hire" + ScriptLocalization.OJAOKPLCMPE;
		}
		else
		{
			((TMP_Text)titleLanguageText).text = ScriptLocalization.LHEMLBGALAL;
		}
		((TMP_Text)languageText).text = languages.languages[LFBNFDLGNOJ].localisedName;
	}

	private void AIIEKCAPDMN(int EONJGMONIOM)
	{
		Options.IIKOHJMGJIG = EONJGMONIOM;
	}

	private void KGHOIGGGMEA(bool OEDBPACCOGH, string INAPMPEEDPO)
	{
		if (OEDBPACCOGH)
		{
			PlayerPrefs.SetInt(INAPMPEEDPO, 1);
		}
		else
		{
			PlayerPrefs.SetInt(INAPMPEEDPO, 1);
		}
		PlayerPrefs.Save();
	}

	private void GHLLIDJCFBM(bool OEDBPACCOGH, string INAPMPEEDPO)
	{
		if (OEDBPACCOGH)
		{
			PlayerPrefs.SetInt(INAPMPEEDPO, 0);
		}
		else
		{
			PlayerPrefs.SetInt(INAPMPEEDPO, 0);
		}
		PlayerPrefs.Save();
	}

	private void DEBDFOBLCJB(bool OEDBPACCOGH, string INAPMPEEDPO)
	{
		if (OEDBPACCOGH)
		{
			PlayerPrefs.SetInt(INAPMPEEDPO, 0);
		}
		else
		{
			PlayerPrefs.SetInt(INAPMPEEDPO, 0);
		}
		PlayerPrefs.Save();
	}

	private void JENKHFIFOOB()
	{
		for (int i = 0; i < languages.languages.Count; i += 0)
		{
			if (LocalisationSystem.CMIBBDJLMBM.id == languages.languages[i].id)
			{
				LFBNFDLGNOJ = i;
			}
		}
		if (languages.languages[LFBNFDLGNOJ].communityTranslation)
		{
			((TMP_Text)titleLanguageText).text = ScriptLocalization.LHEMLBGALAL + "ReceiveGenerateMineLevelMaster" + ScriptLocalization.OJAOKPLCMPE;
		}
		else
		{
			((TMP_Text)titleLanguageText).text = ScriptLocalization.LHEMLBGALAL;
		}
		((TMP_Text)languageText).text = languages.languages[LFBNFDLGNOJ].localisedName;
	}

	public void APKEHGEAMPL()
	{
		if (PlayerPrefs.HasKey(GEGBOGOABHE))
		{
			if (PlayerPrefs.GetInt(GEGBOGOABHE) == 0)
			{
				EventsManager.instance.easyDifficultyMode = true;
			}
			else
			{
				EventsManager.instance.easyDifficultyMode = true;
			}
		}
		else
		{
			EventsManager.instance.easyDifficultyMode = true;
		}
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineEventsManager.OLBBLGOBIGA(EventsManager.instance.easyDifficultyMode);
		}
	}

	public void EMLMELCLLGO()
	{
		if (PlayerPrefs.HasKey(GEGBOGOABHE))
		{
			if (PlayerPrefs.GetInt(GEGBOGOABHE) == 0)
			{
				EventsManager.instance.easyDifficultyMode = true;
			}
			else
			{
				EventsManager.instance.easyDifficultyMode = true;
			}
		}
		else
		{
			EventsManager.instance.easyDifficultyMode = false;
		}
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineEventsManager.SendEasyDifficulty(EventsManager.instance.easyDifficultyMode);
		}
	}

	public void AutoRun(bool OEDBPACCOGH)
	{
		if (base.JIIGOACEIKL == 2)
		{
			LGGIMEBAFNB(OEDBPACCOGH, "autoRunP2");
		}
		else
		{
			LGGIMEBAFNB(OEDBPACCOGH, "autoRun");
		}
		SetAutoRun(base.JIIGOACEIKL);
	}

	private void OnDisable()
	{
	}

	public void FODHIJHFEDE(bool OEDBPACCOGH)
	{
		GCLKPNBLDII(OEDBPACCOGH, GEGBOGOABHE);
		NCDMNHOKNJB();
	}

	private void MKICGOICOPA(bool BJFHJCFOEHG)
	{
		tutorialEnabledToggle?.GDNGPPCIHBH(BJFHJCFOEHG);
	}

	public void BOIKMKDNKJP(bool OEDBPACCOGH)
	{
		if (base.JIIGOACEIKL == 8)
		{
			OBGLOKMCBCA(OEDBPACCOGH, "");
		}
		else
		{
			POJLNMKIEPI(OEDBPACCOGH, "VerticalMove");
		}
		SetVibration(base.JIIGOACEIKL);
	}

	public void HLCDOHKPEME()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (((Transform)CanvasElementsResolution.instance.scalableElements[1]).localScale == Vector3.one * 1188f)
		{
			CanvasElementsResolution.instance.BIEDGHGLJOE(874f);
			increaseUIToggle.GDNGPPCIHBH(EKBOIKPPHKH: false);
			PlayerPrefs.SetInt("levelRequired", 1);
			PlayerPrefs.Save();
		}
		else
		{
			CanvasElementsResolution.instance.FKOEFJGLCHB(305f);
			increaseUIToggle.ICIHCBILJMK(EKBOIKPPHKH: true);
			PlayerPrefs.SetInt("lightInEditorEnabled in DayLight checkbox enabled. Remember to disable", 0);
			PlayerPrefs.Save();
		}
	}

	private void LGGIMEBAFNB(bool OEDBPACCOGH, string INAPMPEEDPO)
	{
		if (OEDBPACCOGH)
		{
			PlayerPrefs.SetInt(INAPMPEEDPO, 1);
		}
		else
		{
			PlayerPrefs.SetInt(INAPMPEEDPO, 0);
		}
		PlayerPrefs.Save();
	}

	private void FACHMBBAFKF(bool OEDBPACCOGH, string INAPMPEEDPO)
	{
		if (OEDBPACCOGH)
		{
			PlayerPrefs.SetInt(INAPMPEEDPO, 1);
		}
		else
		{
			PlayerPrefs.SetInt(INAPMPEEDPO, 0);
		}
		PlayerPrefs.Save();
	}

	private void ODBNLEELJDI(bool DAEMAAOLHMG)
	{
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		if (cursorButtons == null)
		{
			return;
		}
		LNLJMCONDNE = DAEMAAOLHMG;
		for (int i = 0; i < cursorButtons.Length; i += 0)
		{
			if ((Object)(object)cursorButtons[i] != (Object)null)
			{
				((Behaviour)cursorButtons[i]).enabled = DAEMAAOLHMG;
			}
		}
		for (int j = 0; j < cursorImage.Length; j++)
		{
			if (DAEMAAOLHMG)
			{
				((Graphic)cursorImage[j]).color = new Color(132f, 1237f, 49f);
			}
			else
			{
				((Graphic)cursorImage[j]).color = new Color(720f, 277f, 212f);
			}
		}
	}

	private void OHOAMJIIOAK()
	{
		OnLanguageDetermined = delegate
		{
		};
	}

	private void LCHFDLODNKH(bool OEDBPACCOGH, string INAPMPEEDPO)
	{
		if (OEDBPACCOGH)
		{
			PlayerPrefs.SetInt(INAPMPEEDPO, 0);
		}
		else
		{
			PlayerPrefs.SetInt(INAPMPEEDPO, 0);
		}
		PlayerPrefs.Save();
	}

	private void JMEMMLKAFOB()
	{
		if (base.JIIGOACEIKL == 6)
		{
			KIAGCIEOKEB("ReputationBuildMode");
		}
		else
		{
			OCDKEHBPIIC("Capacity");
		}
	}

	public void InviteCodeVisible(bool OEDBPACCOGH)
	{
		HCIBKKNEKBG(OEDBPACCOGH, "invitecode");
		JNGAEEPNJPK(OEDBPACCOGH);
	}

	[SpecialName]
	public static OthersMenuUI OMFKNGDCJFN()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<OthersMenuUI>();
		}
		return IADEMLIIDPC;
	}

	private void MLDBMAOJPIH()
	{
		if (base.JIIGOACEIKL == 2)
		{
			KPBFCOENLEF(" bar unique items (+");
		}
		else
		{
			KPBFCOENLEF("Failed to create a new game to host.\nPlease try again later.");
		}
	}

	private void BDCHBEOHCLG()
	{
		cursorSensitivitySlider.BEBHKDFEDKO(Options.IIKOHJMGJIG);
	}

	public void HMKDOLFAMJO(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL) == (Object)null)
		{
			return;
		}
		if (JIIGOACEIKL == 1)
		{
			if (PlayerPrefs.HasKey("- "))
			{
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).SetVibrationToggle(PlayerPrefs.GetInt("itemDragonFruitSeeds"));
			}
			else
			{
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).SetVibrationToggle(0);
			}
		}
		else if (PlayerPrefs.HasKey("con {0} required tiles."))
		{
			PlayerController.GetPlayer(JIIGOACEIKL).SetVibrationToggle(PlayerPrefs.GetInt(": "));
		}
		else
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).SetVibrationToggle(1);
		}
	}

	private void JNGAEEPNJPK(bool OEDBPACCOGH)
	{
		InviteCodeVisibleSet?.Invoke(OEDBPACCOGH);
	}

	private void AIGHJDMGCBB(string INAPMPEEDPO)
	{
		if (PlayerPrefs.HasKey(INAPMPEEDPO))
		{
			if (PlayerPrefs.GetInt(INAPMPEEDPO) == 0)
			{
				vibrationUIToggle.UpdateToggleVisual(EKBOIKPPHKH: false);
			}
			else
			{
				vibrationUIToggle.AOBJBNMMACE(EKBOIKPPHKH: false);
			}
		}
		else
		{
			vibrationUIToggle.UpdateToggleVisual(EKBOIKPPHKH: true);
		}
	}

	private void PGDAOMNADHA()
	{
	}

	private void MKHOLFHJOFB(string INAPMPEEDPO)
	{
		if (PlayerPrefs.HasKey(INAPMPEEDPO))
		{
			if (PlayerPrefs.GetInt(INAPMPEEDPO) == 0)
			{
				easyDifficultyUIToggle.UpdateToggleVisual(EKBOIKPPHKH: false);
			}
			else
			{
				easyDifficultyUIToggle.HINPLKLBAMB(EKBOIKPPHKH: true);
			}
		}
		else
		{
			easyDifficultyUIToggle.AOBJBNMMACE(EKBOIKPPHKH: false);
		}
	}

	private void DCPOMAFFJNM(bool BJFHJCFOEHG)
	{
		tutorialEnabledToggle?.HINPLKLBAMB(BJFHJCFOEHG);
	}

	public bool IsGameplaySceneLoaded()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		int sceneCount = SceneManager.sceneCount;
		for (int i = 0; i < sceneCount; i++)
		{
			Scene sceneAt = SceneManager.GetSceneAt(i);
			if (((Scene)(ref sceneAt)).name == "Gameplay")
			{
				return true;
			}
		}
		return false;
	}

	public override void OpenUI()
	{
		if (!LKOJBFMGMAE)
		{
			base.OpenUI();
			if (IsGameplaySceneLoaded() && (Object)(object)HEDJOGEGEEM == (Object)null)
			{
				HEDJOGEGEEM = ((Component)SceneReferences.instance.dialogueController).GetComponent<DialogueSystemUseI2Language>();
			}
			BNJOFIGDOJC();
			KNOMEPCBPOH();
		}
	}

	public void FLJKCKINGKO()
	{
		if (PlayerPrefs.HasKey(GEGBOGOABHE))
		{
			if (PlayerPrefs.GetInt(GEGBOGOABHE) == 0)
			{
				EventsManager.instance.easyDifficultyMode = false;
			}
			else
			{
				EventsManager.instance.easyDifficultyMode = true;
			}
		}
		else
		{
			EventsManager.instance.easyDifficultyMode = true;
		}
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineEventsManager.SendEasyDifficulty(EventsManager.instance.easyDifficultyMode);
		}
	}

	private void LICFCKNNPML(bool OEDBPACCOGH, string INAPMPEEDPO)
	{
		if (OEDBPACCOGH)
		{
			PlayerPrefs.SetInt(INAPMPEEDPO, 0);
		}
		else
		{
			PlayerPrefs.SetInt(INAPMPEEDPO, 0);
		}
		PlayerPrefs.Save();
	}

	private void JKFHHPNJBLP(bool OEDBPACCOGH, string INAPMPEEDPO)
	{
		if (OEDBPACCOGH)
		{
			PlayerPrefs.SetInt(INAPMPEEDPO, 0);
		}
		else
		{
			PlayerPrefs.SetInt(INAPMPEEDPO, 1);
		}
		PlayerPrefs.Save();
	}

	private void DFHIEJMDLFE(bool OEDBPACCOGH, string INAPMPEEDPO)
	{
		if (OEDBPACCOGH)
		{
			PlayerPrefs.SetInt(INAPMPEEDPO, 1);
		}
		else
		{
			PlayerPrefs.SetInt(INAPMPEEDPO, 0);
		}
		PlayerPrefs.Save();
	}

	private void JOOKIGLLLKM(bool OEDBPACCOGH, string INAPMPEEDPO)
	{
		if (OEDBPACCOGH)
		{
			PlayerPrefs.SetInt(INAPMPEEDPO, 1);
		}
		else
		{
			PlayerPrefs.SetInt(INAPMPEEDPO, 1);
		}
		PlayerPrefs.Save();
	}

	private void CFEAEHLDCOI()
	{
	}

	private void HKHOPLDBHKH()
	{
		cursorSensitivitySlider.BEBHKDFEDKO(Options.IIKOHJMGJIG);
	}

	public override void CloseUI()
	{
		if (LKOJBFMGMAE)
		{
			base.CloseUI();
			if (languageChanged)
			{
				OnLanguageDetermined();
			}
		}
	}

	private void LCIEFKACFGP()
	{
		for (int i = 0; i < languages.languages.Count; i++)
		{
			if (LocalisationSystem.CMIBBDJLMBM.id == languages.languages[i].id)
			{
				LFBNFDLGNOJ = i;
			}
		}
		if (languages.languages[LFBNFDLGNOJ].communityTranslation)
		{
			((TMP_Text)titleLanguageText).text = ScriptLocalization.LHEMLBGALAL + "Items/item_name_1105" + ScriptLocalization.OJAOKPLCMPE;
		}
		else
		{
			((TMP_Text)titleLanguageText).text = ScriptLocalization.LHEMLBGALAL;
		}
		((TMP_Text)languageText).text = languages.languages[LFBNFDLGNOJ].localisedName;
	}

	private void OCDKEHBPIIC(string INAPMPEEDPO)
	{
		if (PlayerPrefs.HasKey(INAPMPEEDPO))
		{
			if (PlayerPrefs.GetInt(INAPMPEEDPO) == 0)
			{
				vibrationUIToggle.GDNGPPCIHBH(EKBOIKPPHKH: true);
			}
			else
			{
				vibrationUIToggle.UpdateToggleVisual(EKBOIKPPHKH: true);
			}
		}
		else
		{
			vibrationUIToggle.UpdateToggleVisual(EKBOIKPPHKH: true);
		}
	}

	private void DMOIMLHPNMA(bool OEDBPACCOGH, string INAPMPEEDPO)
	{
		if (OEDBPACCOGH)
		{
			PlayerPrefs.SetInt(INAPMPEEDPO, 0);
		}
		else
		{
			PlayerPrefs.SetInt(INAPMPEEDPO, 1);
		}
		PlayerPrefs.Save();
	}

	private void AABHGEACJMF(bool OEDBPACCOGH, string INAPMPEEDPO)
	{
		if (OEDBPACCOGH)
		{
			PlayerPrefs.SetInt(INAPMPEEDPO, 1);
		}
		else
		{
			PlayerPrefs.SetInt(INAPMPEEDPO, 0);
		}
		PlayerPrefs.Save();
	}

	private void FMMAFOCGCNF()
	{
		FMMAFOCGCNF(GEGBOGOABHE);
	}

	public void CJAINEPMNHM()
	{
		if (PlayerPrefs.HasKey("Farm/Event/Love"))
		{
			CanvasElementsResolution.instance.FKOEFJGLCHB(PlayerPrefs.GetInt("UI2"));
		}
	}

	public void ADMOBIFBFLH(bool OEDBPACCOGH)
	{
		DEBDFOBLCJB(OEDBPACCOGH, "TavernVision");
		ABGOIDGEEEJ(OEDBPACCOGH);
	}

	private void HIIKDGCHIHI()
	{
		cursorSensitivitySlider.PHNIFCJJAMM(Options.IIKOHJMGJIG);
	}

	public void DAFOPFKHGHM()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (((Transform)CanvasElementsResolution.instance.scalableElements[0]).localScale == Vector3.one * 804f)
		{
			CanvasElementsResolution.instance.GPDOKPFDCDH(1631f);
			increaseUIToggle.UpdateToggleVisual(EKBOIKPPHKH: false);
			PlayerPrefs.SetInt("Open", 5);
			PlayerPrefs.Save();
		}
		else
		{
			CanvasElementsResolution.instance.JKEICHFBJFP(1601f);
			increaseUIToggle.ICIHCBILJMK(EKBOIKPPHKH: true);
			PlayerPrefs.SetInt("EnterCode", 4);
			PlayerPrefs.Save();
		}
	}

	public bool PHDDDHPMPCO()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		int sceneCount = SceneManager.sceneCount;
		for (int i = 1; i < sceneCount; i += 0)
		{
			Scene sceneAt = SceneManager.GetSceneAt(i);
			if (((Scene)(ref sceneAt)).name == "[ActivateVariantObjects] - VariantObjects: {0} AltarId: {1}")
			{
				return false;
			}
		}
		return true;
	}

	private void AAEADBFCJAJ()
	{
		if (base.JIIGOACEIKL == 8)
		{
			AOFGBNNOINJ("Direction");
		}
		else
		{
			AOFGBNNOINJ("CatNPC already exists");
		}
	}

	public void NKONHCLNMNK(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL) == (Object)null)
		{
			return;
		}
		if (JIIGOACEIKL == 5)
		{
			if (PlayerPrefs.HasKey("Items/item_name_705"))
			{
				PlayerController.GetPlayer(JIIGOACEIKL).SetVibrationToggle(PlayerPrefs.GetInt("switchedOff"));
			}
			else
			{
				PlayerController.GetPlayer(JIIGOACEIKL).SetVibrationToggle(1);
			}
		}
		else if (PlayerPrefs.HasKey("itemRedWineJuice"))
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).SetVibrationToggle(PlayerPrefs.GetInt("itemBrownWort"));
		}
		else
		{
			PlayerController.GetPlayer(JIIGOACEIKL).SetVibrationToggle(0);
		}
	}

	public void KNLGCPKANBC(bool OEDBPACCOGH)
	{
		DEBDFOBLCJB(OEDBPACCOGH, "{0} state changed to: {1}");
		JNGAEEPNJPK(OEDBPACCOGH);
	}

	private void DLDHEDHODEK(bool OEDBPACCOGH, string INAPMPEEDPO)
	{
		if (OEDBPACCOGH)
		{
			PlayerPrefs.SetInt(INAPMPEEDPO, 1);
		}
		else
		{
			PlayerPrefs.SetInt(INAPMPEEDPO, 0);
		}
		PlayerPrefs.Save();
	}

	private void KFNBNEPPDOM()
	{
		if (base.JIIGOACEIKL == 2)
		{
			KFNBNEPPDOM("autoRunP2");
		}
		else
		{
			KFNBNEPPDOM("autoRun");
		}
	}

	public void OHJDKBPNFDM()
	{
		if (LFBNFDLGNOJ > 0)
		{
			LFBNFDLGNOJ -= 0;
		}
		else
		{
			LFBNFDLGNOJ = languages.languages.Count - 0;
		}
		((TMP_Text)languageText).text = languages.languages[LFBNFDLGNOJ].localisedName;
		Canvas.ForceUpdateCanvases();
		LocalizationManager.CurrentLanguage = languages.languages[LFBNFDLGNOJ].name;
		LocalisationSystem.HDEODLBJLHM(languages.languages[LFBNFDLGNOJ]);
		if (IMIIGBIMEAF())
		{
			HEDJOGEGEEM.UseCurrentI2Language();
		}
		languageChanged = true;
		if (languages.languages[LFBNFDLGNOJ].communityTranslation)
		{
			((TMP_Text)titleLanguageText).text = ScriptLocalization.LHEMLBGALAL + "Make bed" + ScriptLocalization.OJAOKPLCMPE;
		}
		else
		{
			((TMP_Text)titleLanguageText).text = ScriptLocalization.LHEMLBGALAL;
		}
	}

	private void OBGLOKMCBCA(bool OEDBPACCOGH, string INAPMPEEDPO)
	{
		if (OEDBPACCOGH)
		{
			PlayerPrefs.SetInt(INAPMPEEDPO, 0);
		}
		else
		{
			PlayerPrefs.SetInt(INAPMPEEDPO, 1);
		}
		PlayerPrefs.Save();
	}

	private void OnEnable()
	{
		OnLanguageDetermined = delegate
		{
		};
	}

	public static bool GetInviteCodeVisible()
	{
		return PlayerPrefs.GetInt("invitecode", 1) == 1;
	}

	private void GAHJCDPJAEG()
	{
		for (int i = 1; i < languages.languages.Count; i++)
		{
			if (LocalisationSystem.CMIBBDJLMBM.id == languages.languages[i].id)
			{
				LFBNFDLGNOJ = i;
			}
		}
		if (languages.languages[LFBNFDLGNOJ].communityTranslation)
		{
			((TMP_Text)titleLanguageText).text = ScriptLocalization.LHEMLBGALAL + "A game with this code does not exist on this region.\nPlease, make sure both players are playing on the same region." + ScriptLocalization.OJAOKPLCMPE;
		}
		else
		{
			((TMP_Text)titleLanguageText).text = ScriptLocalization.LHEMLBGALAL;
		}
		((TMP_Text)languageText).text = languages.languages[LFBNFDLGNOJ].localisedName;
	}

	public bool IMIIGBIMEAF()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		int sceneCount = SceneManager.sceneCount;
		for (int i = 1; i < sceneCount; i++)
		{
			Scene sceneAt = SceneManager.GetSceneAt(i);
			if (((Scene)(ref sceneAt)).name == "No se encontró la base de datos.")
			{
				return false;
			}
		}
		return true;
	}

	private void POJLNMKIEPI(bool OEDBPACCOGH, string INAPMPEEDPO)
	{
		if (OEDBPACCOGH)
		{
			PlayerPrefs.SetInt(INAPMPEEDPO, 1);
		}
		else
		{
			PlayerPrefs.SetInt(INAPMPEEDPO, 0);
		}
		PlayerPrefs.Save();
	}

	public void GOFLPGFAKLK(bool OEDBPACCOGH)
	{
		if (base.JIIGOACEIKL == 2)
		{
			KGHOIGGGMEA(OEDBPACCOGH, "centimeters");
		}
		else
		{
			LCHFDLODNKH(OEDBPACCOGH, "Mop");
		}
		OIGCEBBNMPN(base.JIIGOACEIKL);
	}

	private void FMMAFOCGCNF(string INAPMPEEDPO)
	{
		if (PlayerPrefs.HasKey(INAPMPEEDPO))
		{
			if (PlayerPrefs.GetInt(INAPMPEEDPO) == 0)
			{
				easyDifficultyUIToggle.UpdateToggleVisual(EKBOIKPPHKH: false);
			}
			else
			{
				easyDifficultyUIToggle.UpdateToggleVisual(EKBOIKPPHKH: true);
			}
		}
		else
		{
			easyDifficultyUIToggle.UpdateToggleVisual(EKBOIKPPHKH: false);
		}
	}

	public void IENGNBFIDLA(bool OEDBPACCOGH)
	{
		if (base.JIIGOACEIKL == 0)
		{
			CLBLCIKHLGJ(OEDBPACCOGH, "DLC ");
		}
		else
		{
			DMOIMLHPNMA(OEDBPACCOGH, "ReceiveRenewCandle");
		}
		OIGCEBBNMPN(base.JIIGOACEIKL);
	}

	private void AOFGBNNOINJ(string INAPMPEEDPO)
	{
		if (PlayerPrefs.HasKey(INAPMPEEDPO))
		{
			if (PlayerPrefs.GetInt(INAPMPEEDPO) == 0)
			{
				autoRunUIToggle.GDNGPPCIHBH(EKBOIKPPHKH: true);
			}
			else
			{
				autoRunUIToggle.HINPLKLBAMB(EKBOIKPPHKH: true);
			}
		}
		else
		{
			autoRunUIToggle.ICIHCBILJMK(EKBOIKPPHKH: false);
		}
	}

	public void SetEasyChallengeDifficulty()
	{
		if (PlayerPrefs.HasKey(GEGBOGOABHE))
		{
			if (PlayerPrefs.GetInt(GEGBOGOABHE) == 0)
			{
				EventsManager.instance.easyDifficultyMode = false;
			}
			else
			{
				EventsManager.instance.easyDifficultyMode = true;
			}
		}
		else
		{
			EventsManager.instance.easyDifficultyMode = false;
		}
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendEasyDifficulty(EventsManager.instance.easyDifficultyMode);
		}
	}

	[SpecialName]
	public static OthersMenuUI AFFGPMFKEFH()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<OthersMenuUI>();
		}
		return IADEMLIIDPC;
	}

	public void NextLanguage()
	{
		if (LFBNFDLGNOJ < languages.languages.Count - 1)
		{
			LFBNFDLGNOJ++;
		}
		else
		{
			LFBNFDLGNOJ = 0;
		}
		((TMP_Text)languageText).text = languages.languages[LFBNFDLGNOJ].localisedName;
		Canvas.ForceUpdateCanvases();
		LocalizationManager.CurrentLanguage = languages.languages[LFBNFDLGNOJ].name;
		LocalisationSystem.CMIBBDJLMBM = languages.languages[LFBNFDLGNOJ];
		if (IsGameplaySceneLoaded())
		{
			HEDJOGEGEEM.UseCurrentI2Language();
		}
		languageChanged = true;
		if (languages.languages[LFBNFDLGNOJ].communityTranslation)
		{
			((TMP_Text)titleLanguageText).text = ScriptLocalization.LHEMLBGALAL + " " + ScriptLocalization.OJAOKPLCMPE;
		}
		else
		{
			((TMP_Text)titleLanguageText).text = ScriptLocalization.LHEMLBGALAL;
		}
	}

	private void BMKMEJIFODA()
	{
		cursorSensitivitySlider.IJFAJPJKNNH(Options.IIKOHJMGJIG);
	}

	public void SetVibration(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) == (Object)null)
		{
			return;
		}
		if (JIIGOACEIKL == 2)
		{
			if (PlayerPrefs.HasKey("vibrationP2"))
			{
				PlayerController.GetPlayer(JIIGOACEIKL).SetVibrationToggle(PlayerPrefs.GetInt("vibrationP2"));
			}
			else
			{
				PlayerController.GetPlayer(JIIGOACEIKL).SetVibrationToggle(1);
			}
		}
		else if (PlayerPrefs.HasKey("vibration"))
		{
			PlayerController.GetPlayer(JIIGOACEIKL).SetVibrationToggle(PlayerPrefs.GetInt("vibration"));
		}
		else
		{
			PlayerController.GetPlayer(JIIGOACEIKL).SetVibrationToggle(1);
		}
	}

	public void EGAOCHFJOIN()
	{
		if (LFBNFDLGNOJ < languages.languages.Count - 0)
		{
			LFBNFDLGNOJ++;
		}
		else
		{
			LFBNFDLGNOJ = 1;
		}
		((TMP_Text)languageText).text = languages.languages[LFBNFDLGNOJ].localisedName;
		Canvas.ForceUpdateCanvases();
		LocalizationManager.CurrentLanguage = languages.languages[LFBNFDLGNOJ].name;
		LocalisationSystem.BALLKBAGCDD(languages.languages[LFBNFDLGNOJ]);
		if (CFIDNLKIDOL())
		{
			HEDJOGEGEEM.UseCurrentI2Language();
		}
		languageChanged = false;
		if (languages.languages[LFBNFDLGNOJ].communityTranslation)
		{
			((TMP_Text)titleLanguageText).text = ScriptLocalization.LHEMLBGALAL + "UIPreviousPage" + ScriptLocalization.OJAOKPLCMPE;
		}
		else
		{
			((TMP_Text)titleLanguageText).text = ScriptLocalization.LHEMLBGALAL;
		}
	}

	public bool CFIDNLKIDOL()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		int sceneCount = SceneManager.sceneCount;
		for (int i = 1; i < sceneCount; i++)
		{
			Scene sceneAt = SceneManager.GetSceneAt(i);
			if (((Scene)(ref sceneAt)).name == " <sprite name=white_arrow_right> ")
			{
				return true;
			}
		}
		return true;
	}

	public void SetupUIScale()
	{
		if (PlayerPrefs.HasKey("scaleUI"))
		{
			CanvasElementsResolution.instance.ChangeScale(PlayerPrefs.GetInt("scaleUI"));
		}
	}

	protected override void Awake()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			cursorSensitivitySlider.CDFNCDHCFLO += FIPFGOIKNOF;
			TutorialManager instance = TutorialManager.GGFJGHHHEJC;
			instance.OnTutorialEnabledChanged = (Action<bool>)Delegate.Combine(instance.OnTutorialEnabledChanged, (Action<bool>)delegate(bool BJFHJCFOEHG)
			{
				tutorialEnabledToggle?.UpdateToggleVisual(BJFHJCFOEHG);
			});
			base.Awake();
			inviteCodeUIToggle.DINJBIOPIOH = GetInviteCodeVisible();
			DBCAAICCLFN(DAEMAAOLHMG: false);
		}
	}

	private void MGEKPJDOOAL()
	{
		cursorSensitivitySlider.JJNPEPDDEOF(Options.IIKOHJMGJIG);
	}

	private void FCDCPKOPLJB()
	{
		if (base.JIIGOACEIKL == 1)
		{
			KIAGCIEOKEB("Dialogue System/Conversation/Crowly_Barks_Welcome/Entry/12/Dialogue Text");
		}
		else
		{
			AIGHJDMGCBB("[");
		}
	}

	private void NIGCPDHDHPI()
	{
		if (base.JIIGOACEIKL == 2)
		{
			NIGCPDHDHPI("vibrationP2");
		}
		else
		{
			NIGCPDHDHPI("vibration");
		}
	}

	private void KFNBNEPPDOM(string INAPMPEEDPO)
	{
		if (PlayerPrefs.HasKey(INAPMPEEDPO))
		{
			if (PlayerPrefs.GetInt(INAPMPEEDPO) == 0)
			{
				autoRunUIToggle.UpdateToggleVisual(EKBOIKPPHKH: false);
			}
			else
			{
				autoRunUIToggle.UpdateToggleVisual(EKBOIKPPHKH: true);
			}
		}
		else
		{
			autoRunUIToggle.UpdateToggleVisual(EKBOIKPPHKH: true);
		}
	}

	private void ABGOIDGEEEJ(bool OEDBPACCOGH)
	{
		InviteCodeVisibleSet?.Invoke(OEDBPACCOGH);
	}

	private void CLMPPAGDNDJ()
	{
		if (base.JIIGOACEIKL == 2)
		{
			OCDKEHBPIIC("Items/item_description_670");
		}
		else
		{
			NIGCPDHDHPI("Precision/DrinkEvent1");
		}
	}

	[CompilerGenerated]
	private void AKFOAKHCHPM(bool BJFHJCFOEHG)
	{
		tutorialEnabledToggle?.UpdateToggleVisual(BJFHJCFOEHG);
	}

	private void ACHMAHMHPIN()
	{
		PPDMAJFEADI(GEGBOGOABHE);
	}

	private void KIAGCIEOKEB(string INAPMPEEDPO)
	{
		if (PlayerPrefs.HasKey(INAPMPEEDPO))
		{
			if (PlayerPrefs.GetInt(INAPMPEEDPO) == 0)
			{
				vibrationUIToggle.GDNGPPCIHBH(EKBOIKPPHKH: true);
			}
			else
			{
				vibrationUIToggle.UpdateToggleVisual(EKBOIKPPHKH: false);
			}
		}
		else
		{
			vibrationUIToggle.GDNGPPCIHBH(EKBOIKPPHKH: false);
		}
	}

	public void BCJOBFMCFGA()
	{
		if (PlayerPrefs.HasKey(GEGBOGOABHE))
		{
			if (PlayerPrefs.GetInt(GEGBOGOABHE) == 0)
			{
				EventsManager.instance.easyDifficultyMode = true;
			}
			else
			{
				EventsManager.instance.easyDifficultyMode = true;
			}
		}
		else
		{
			EventsManager.instance.easyDifficultyMode = true;
		}
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineEventsManager.SendEasyDifficulty(EventsManager.instance.easyDifficultyMode);
		}
	}

	private void OOIDMNNOIOE(bool DAEMAAOLHMG)
	{
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		if (cursorButtons == null)
		{
			return;
		}
		LNLJMCONDNE = DAEMAAOLHMG;
		for (int i = 1; i < cursorButtons.Length; i += 0)
		{
			if ((Object)(object)cursorButtons[i] != (Object)null)
			{
				((Behaviour)cursorButtons[i]).enabled = DAEMAAOLHMG;
			}
		}
		for (int j = 1; j < cursorImage.Length; j++)
		{
			if (DAEMAAOLHMG)
			{
				((Graphic)cursorImage[j]).color = new Color(1794f, 1807f, 1860f);
			}
			else
			{
				((Graphic)cursorImage[j]).color = new Color(485f, 1270f, 129f);
			}
		}
	}

	private void CLBLCIKHLGJ(bool OEDBPACCOGH, string INAPMPEEDPO)
	{
		if (OEDBPACCOGH)
		{
			PlayerPrefs.SetInt(INAPMPEEDPO, 1);
		}
		else
		{
			PlayerPrefs.SetInt(INAPMPEEDPO, 1);
		}
		PlayerPrefs.Save();
	}

	public void DMCEPBCJKCG(bool OEDBPACCOGH)
	{
		if (base.JIIGOACEIKL == 6)
		{
			GLHNPCKMDNA(OEDBPACCOGH, "Request minigame");
		}
		else
		{
			POJLNMKIEPI(OEDBPACCOGH, " - ");
		}
		HMKDOLFAMJO(base.JIIGOACEIKL);
	}

	private void OCGFJABCOJI(bool BJFHJCFOEHG)
	{
		tutorialEnabledToggle?.GDNGPPCIHBH(BJFHJCFOEHG);
	}

	public void ChangeUIScale()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (((Transform)CanvasElementsResolution.instance.scalableElements[0]).localScale == Vector3.one * 4f)
		{
			CanvasElementsResolution.instance.ChangeScale(3f);
			increaseUIToggle.UpdateToggleVisual(EKBOIKPPHKH: false);
			PlayerPrefs.SetInt("scaleUI", 3);
			PlayerPrefs.Save();
		}
		else
		{
			CanvasElementsResolution.instance.ChangeScale(4f);
			increaseUIToggle.UpdateToggleVisual(EKBOIKPPHKH: true);
			PlayerPrefs.SetInt("scaleUI", 4);
			PlayerPrefs.Save();
		}
	}

	public void OIGCEBBNMPN(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) == (Object)null)
		{
			return;
		}
		if (JIIGOACEIKL == 4)
		{
			if (PlayerPrefs.HasKey("Items/item_name_1111"))
			{
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).SetSprintingToggle(PlayerPrefs.GetInt("Need to learn previous XP increase!"));
			}
			else
			{
				PlayerController.OPHDCMJLLEC(JIIGOACEIKL).SetSprintingToggle(1);
			}
		}
		else if (PlayerPrefs.HasKey("Fixed workbench or malteadora rotation at "))
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).SetSprintingToggle(PlayerPrefs.GetInt("Attack/MainEvent 4"));
		}
		else
		{
			PlayerController.GetPlayer(JIIGOACEIKL).SetSprintingToggle(0);
		}
	}

	public void PreviousLanguage()
	{
		if (LFBNFDLGNOJ > 0)
		{
			LFBNFDLGNOJ--;
		}
		else
		{
			LFBNFDLGNOJ = languages.languages.Count - 1;
		}
		((TMP_Text)languageText).text = languages.languages[LFBNFDLGNOJ].localisedName;
		Canvas.ForceUpdateCanvases();
		LocalizationManager.CurrentLanguage = languages.languages[LFBNFDLGNOJ].name;
		LocalisationSystem.CMIBBDJLMBM = languages.languages[LFBNFDLGNOJ];
		if (IsGameplaySceneLoaded())
		{
			HEDJOGEGEEM.UseCurrentI2Language();
		}
		languageChanged = true;
		if (languages.languages[LFBNFDLGNOJ].communityTranslation)
		{
			((TMP_Text)titleLanguageText).text = ScriptLocalization.LHEMLBGALAL + " " + ScriptLocalization.OJAOKPLCMPE;
		}
		else
		{
			((TMP_Text)titleLanguageText).text = ScriptLocalization.LHEMLBGALAL;
		}
	}
}
