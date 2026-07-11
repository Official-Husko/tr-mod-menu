using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SaveUI : UIWindow
{
	public Action OnLoadFadeOut = delegate
	{
	};

	public Action OnLoadFadeOutStart = delegate
	{
	};

	public bool loading;

	public bool tutorial;

	public CanvasGroup canvasGroup;

	private SaveSlotUI lastSlotSelected;

	private List<SaveSlotUI> saveSlotsUI;

	private int numSaveSlotsUI;

	[SerializeField]
	private SaveSlotUI saveSlotUIPrefab;

	[SerializeField]
	private GameObject saveSlotList;

	private Coroutine updateSaveSlotsCoroutine;

	[SerializeField]
	private TextMeshProUGUI title;

	[SerializeField]
	private TextMeshProUGUI newGameText;

	[SerializeField]
	private Scrollbar scrollbar;

	[SerializeField]
	private GameObject mainMenu;

	private static SaveUI _instance;

	[HideInInspector]
	public string[] allSaves;

	public bool startingNewGame;

	private bool nextFrame;

	[HideInInspector]
	public bool loadCharacterFromUI;

	public Image fillImage;

	private float holdTimeThreshold = 2f;

	private float buttonHeldTime;

	private bool actionExecuted;

	public bool initializeNewOnlineGame;

	private string _filename;

	private SaveData _oldGame;

	private SaveData.NewCharacterSave oldCharacterInfo;

	public static SaveUI instance
	{
		get
		{
			if ((Object)(object)_instance == (Object)null)
			{
				_instance = Object.FindObjectOfType<SaveUI>();
			}
			return _instance;
		}
	}

	public void SetSlotSelected(SaveSlotUI saveSlotUI)
	{
		lastSlotSelected = saveSlotUI;
	}

	protected override void Awake()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)_instance, (MonoBehaviour)(object)this))
		{
			_instance = this;
			saveSlotsUI = new List<SaveSlotUI>();
			loading = true;
			base.Awake();
		}
	}

	protected override void Start()
	{
		base.Start();
		UpdateSaveSlots();
		if (Application.isEditor && Object.op_Implicit((Object)(object)CommonReferences.GetEditorConfiguration()) && CommonReferences.GetEditorConfiguration().loadFirstSaveDataAfterPlay)
		{
			((MonoBehaviour)this).StartCoroutine(LoadingFirstSaveDataNextFrame());
		}
		if ((Object)(object)fillImage != (Object)null)
		{
			fillImage.fillAmount = 0f;
		}
	}

	private IEnumerator LoadingFirstSaveDataNextFrame()
	{
		yield return null;
		TitleScreen.GetInstance().ButtonStart();
		yield return null;
		if (saveSlotsUI.Count > 0)
		{
			Debug.Log((object)("AutoLoading first save data: " + saveSlotsUI[0].GetFileName()));
			LoadSave(saveSlotsUI[0]);
		}
	}

	public void AutoSave()
	{
		Debug.Log((object)"Autosave");
		if (OnlineManager.ClientOnline() && string.IsNullOrEmpty(GameManager.GGFJGHHHEJC.PMKCJJCGKBB))
		{
			NewSave();
		}
		else
		{
			OverrideSaveAndCheck(GameManager.GGFJGHHHEJC.PMKCJJCGKBB);
		}
	}

	protected override void Update()
	{
		base.Update();
		if (nextFrame)
		{
			nextFrame = false;
		}
		else
		{
			if (!IsOpen() || MainUI.GetYesNoDialogue().IsOpen() || MainUI.GetMultipleChoice().IsOpen() || !PlayerInputs.InputsEnabled(1) || (loading && GameManager.GGFJGHHHEJC.FFJBIGFADBJ) || !PlayerInputs.IsGamepadActive(1))
			{
				return;
			}
			if (PlayerInputs.GetPlayer(1).GetButton("UIAddRemove") && MainUI.GetCurrentOpenWindows(1).Contains(this) && (Object)(object)lastSlotSelected != (Object)null)
			{
				buttonHeldTime += Time.deltaTime;
				if ((Object)(object)fillImage != (Object)null)
				{
					fillImage.fillAmount = Mathf.Clamp01(buttonHeldTime / holdTimeThreshold);
				}
				if (buttonHeldTime >= holdTimeThreshold && !actionExecuted)
				{
					actionExecuted = true;
					lastSlotSelected.DeleteSaveSlot();
				}
			}
			else if (buttonHeldTime != 0f)
			{
				buttonHeldTime = 0f;
				actionExecuted = false;
				if ((Object)(object)fillImage != (Object)null)
				{
					fillImage.fillAmount = 0f;
				}
			}
			if (PlayerInputs.GetPlayer(1).GetButtonDown("UISelectGamepad") && MainUI.GetCurrentOpenWindows(1).Contains(this) && (Object)(object)lastSlotSelected != (Object)null)
			{
				lastSlotSelected.DuplicateSaveSlot();
			}
		}
	}

	public void NewGameClicked()
	{
		Debug.Log((object)"New Game Clicked");
		if (loading)
		{
			NewGame();
		}
		else
		{
			NewSave();
		}
	}

	private void NewGame()
	{
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected O, but got Unknown
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		if (OnlineManager.PlayingOnline())
		{
			if (OnlineManager.IsGonnaBeClient())
			{
				OnlineManager.saveSlotSelectedForOnlinePlay = null;
				OnlineManager.BeginOnlinePlay();
				return;
			}
			if (Utils.MBCCIAKKPMJ(29) || (PlayerPrefs.HasKey("tutorialCompleted") && PlayerPrefs.GetInt("tutorialCompleted") == 1))
			{
				InitializeNewOnlineGame();
				return;
			}
			YesNoDialogueUI window = MainUI.GetYesNoDialogue();
			window.windowType = EWindow.Concatenated;
			window.Open(1);
			((TMP_Text)window.boxText).text = LocalisationSystem.Get("OnlineTutorialMessage");
			window.SetYesNoButtonsText();
			((UnityEvent)window.yesButton.onClick).AddListener((UnityAction)delegate
			{
				tutorial = false;
				InitializeNewOnlineGame();
			});
			((UnityEvent)window.noButton.onClick).AddListener((UnityAction)delegate
			{
				window.CloseUI();
			});
			return;
		}
		tutorial = true;
		if (Utils.MBCCIAKKPMJ(29) || (PlayerPrefs.HasKey("tutorialCompleted") && PlayerPrefs.GetInt("tutorialCompleted") == 1))
		{
			YesNoDialogueUI window2 = MainUI.GetYesNoDialogue();
			window2.windowType = EWindow.Concatenated;
			window2.Open(1);
			((TMP_Text)window2.boxText).text = LocalisationSystem.Get("disableTutorial");
			window2.SetYesNoButtonsText(GJLPEHIIDPI: true);
			((UnityEvent)window2.yesButton.onClick).AddListener((UnityAction)delegate
			{
				tutorial = false;
				window2.SetYesNoButtonsText();
				InitializeNewGame();
				window2.windowType = EWindow.ConcatenatedOpened;
			});
			((UnityEvent)window2.noButton.onClick).AddListener((UnityAction)delegate
			{
				Utils.disableHalloweenEvent = true;
				Utils.disableChristmasEvent = true;
				window2.SetYesNoButtonsText();
				InitializeNewGame();
				window2.windowType = EWindow.ConcatenatedOpened;
			});
		}
		else
		{
			Utils.disableHalloweenEvent = true;
			Utils.disableChristmasEvent = true;
			InitializeNewGame();
		}
	}

	public void InitializeNewGameAsAClient()
	{
		Debug.Log((object)"Initialize new game as a client");
		tutorial = false;
		InitializeNewGame();
	}

	private void InitializeNewGame(bool loadingGameCreatedBeforeByClient = false)
	{
		Debug.Log((object)"InitializeNewGame");
		SceneReferences.AFEDGPJNCDN = true;
		lastSlotSelected = null;
		startingNewGame = true;
		CharacterCreatorUI.loadGame = null;
		CharacterCreatorUI.loadFilename = "";
		StartingNewGame(loadingGameCreatedBeforeByClient);
	}

	private void InitializeNewOnlineGame()
	{
		if (OnlineManager.PlayingOnline() && OnlineManager.CanJoinRoom() && !((Object)(object)OnlineManager.saveSlotSelectedForOnlinePlay != (Object)null) && !initializeNewOnlineGame)
		{
			initializeNewOnlineGame = true;
			OnlineManager.BeginOnlinePlay();
		}
	}

	public void InitializeNewOnlineGameOnRoomJoined()
	{
		tutorial = false;
		initializeNewOnlineGame = false;
		InitializeNewGame();
	}

	private void StartingNewGame(bool loadingGameCreatedBeforeByClient)
	{
		Debug.Log((object)"Starting New Game Coroutine");
		MainUI.CloseAllUIWindows(DHJFAGNJKOF: true);
		TitleScreen.ActivateLoadingBar();
		GameManager.LoadGameplayScene();
		StartFadeIntoGame(newGame: true, loadingGameCreatedBeforeByClient);
		Crafter.InitializeRepairs();
	}

	private void OnLoadSlotClicked(SaveSlotUI saveSlotUI)
	{
		if (OnlineManager.PlayingOnline())
		{
			JoinRoomOnline(saveSlotUI);
		}
		else
		{
			LoadSave(saveSlotUI);
		}
	}

	private void JoinRoomOnline(SaveSlotUI saveSlotUI)
	{
		if (OnlineManager.CanJoinRoom() && !((Object)(object)OnlineManager.saveSlotSelectedForOnlinePlay != (Object)null) && ((OnlineManager.JPFIPIEEHBA != RoomMode.JoinPublicRoom && OnlineManager.JPFIPIEEHBA != RoomMode.JoinPrivateRoom && OnlineManager.JPFIPIEEHBA != RoomMode.JoinInviteCodeRoom) || OnlineManager.RoomExists()))
		{
			Debug.Log((object)"Slot clicked (ONLINE).");
			SaveData saveData = Save.instance.GetSaveData(saveSlotUI.GetFileName());
			if (saveData != null && !saveData.LNCNDNKGOFK())
			{
				NewTutorialManager.ShowPopUp(LocalisationSystem.Get("Error_FinishTutorialFirst"));
				return;
			}
			NewTutorialManager.ClosePopUp();
			OnlineManager.saveSlotSelectedForOnlinePlay = saveSlotUI;
			OnlineManager.BeginOnlinePlay();
			MainUI.CloseAllUIWindows();
			TitleScreen.ActivateLoadingBar();
			CloseUI();
			OnlineConnectionMenu.CloseUI();
		}
	}

	public static void LoadSaveForOnline(SaveSlotUI saveSlotUI)
	{
		if ((Object)(object)saveSlotUI != (Object)null)
		{
			Debug.Log((object)"Load Save For Online, master client");
			_instance.LoadSave(saveSlotUI);
		}
		else
		{
			Debug.Log((object)"New Save For Online, master client");
			GameManager.LoadGameplayScene();
			_instance.lastSlotSelected = null;
		}
	}

	private void LoadSave(SaveSlotUI saveSlotUI)
	{
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_00ee: Expected O, but got Unknown
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected O, but got Unknown
		if (GameManager.GGFJGHHHEJC.FFJBIGFADBJ)
		{
			return;
		}
		Debug.Log((object)("Load Save " + saveSlotUI.GetFileName()));
		SaveData data = Save.instance.GetSaveData(saveSlotUI.GetFileName());
		if (data != null)
		{
			Debug.Log((object)$"Is an older version: {VersionNumberManager.IsAnOlderVersion(data.HIMELJEPBDP(), VersionNumberManager.OKIFGMKLLJL)}");
			if (!data.LNCNDNKGOFK() && VersionNumberManager.IsAnOlderVersion(data.HIMELJEPBDP(), VersionNumberManager.OKIFGMKLLJL))
			{
				MainUI.GetMultipleChoice().Setup(LocalisationSystem.Get("Error_ResetTutorial"), LocalisationSystem.Get("Restart"), (UnityAction)delegate
				{
					StartNewGameWithOldParameters(saveSlotUI.GetFileName(), data);
				}, LocalisationSystem.Get("Omit"), (UnityAction)delegate
				{
					tutorial = false;
					GameManager.GGFJGHHHEJC.HEJPPEJMPFE = data;
					GameManager.GGFJGHHHEJC.PMKCJJCGKBB = saveSlotUI.GetFileName();
					InitializeNewGame(loadingGameCreatedBeforeByClient: true);
				});
				return;
			}
			if (data.NGHACGCNMPD() && VersionNumberManager.IsAnOlderVersion(data.HIMELJEPBDP(), VersionNumberManager.IJKFKNPOINO))
			{
				_filename = saveSlotUI.GetFileName();
				_oldGame = data;
				MainUI.GetYesNoDialogue().Open(base.JIIGOACEIKL);
				((TMP_Text)MainUI.GetYesNoDialogue().boxText).text = LocalisationSystem.GetStringWithTags("ResetTutorialObstacles", base.JIIGOACEIKL);
				MainUI.GetYesNoDialogue().AddYesAction(new UnityAction(ResetSave));
				return;
			}
			if (OnlineManager.MasterOrOffline() && !data.BFOAEEJHOHH())
			{
				Debug.Log((object)"Game created from client side. Initializing new game and loading client data.");
				tutorial = false;
				GameManager.GGFJGHHHEJC.HEJPPEJMPFE = data;
				GameManager.GGFJGHHHEJC.PMKCJJCGKBB = saveSlotUI.GetFileName();
				InitializeNewGame(loadingGameCreatedBeforeByClient: true);
				return;
			}
		}
		if (IsOpen())
		{
			canvasGroup.alpha = 0f;
			canvasGroup.interactable = false;
			blackBg.SetActive(false);
			TitleScreen.ActivateLoadingBar();
		}
		SceneReferences.AFEDGPJNCDN = false;
		GameManager.LoadGameplayScene();
		_instance.lastSlotSelected = null;
		if (!string.IsNullOrEmpty(saveSlotUI.GetFileName()))
		{
			startingNewGame = false;
			Save.instance.PrepareLoadGame(saveSlotUI.GetFileName());
		}
	}

	private void ResetSave()
	{
		StartNewGameWithOldParameters(_filename, _oldGame);
	}

	private void StartNewGameWithOldParameters(string filename, SaveData oldGame)
	{
		Debug.Log((object)"Start New Game With Old Parameters");
		oldCharacterInfo = oldGame.DLOLLOFPICG();
		PlayerInfo.HBILFLLKHGP = oldCharacterInfo.name;
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(LoadOldCharacterInfo));
		InitializeNewGame();
		Save.instance.DeleteSave(filename, deleteBackup: true);
	}

	private void LoadOldCharacterInfo()
	{
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(LoadOldCharacterInfo));
		PlayerController.GetPlayer(1).characterCreator.LoadCharacter(oldCharacterInfo);
	}

	public void StartFadeIntoGame(bool newGame, bool loadingGameCreatedBeforeByClient = false)
	{
		Debug.Log((object)"StartFadeIntoGame");
		GameManager.GGFJGHHHEJC.FFJBIGFADBJ = true;
		if (newGame)
		{
			((MonoBehaviour)this).StartCoroutine(StartEnteringGame(1, loadingGameCreatedBeforeByClient));
			return;
		}
		Debug.Log((object)FadeCamera.GetPlayer(1));
		FadeCamera.GetPlayer(1).FadeOut();
		((MonoBehaviour)this).StartCoroutine(StartEnteringGame(1, loadingGameCreatedBeforeByClient));
	}

	private void OverrideSave(SaveSlotUI saveSlotUI)
	{
		OverrideSave(saveSlotUI.GetFileName());
	}

	private void OverrideSave(string fileName)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		MainUI.GetYesNoDialogue().Open(1);
		((TMP_Text)MainUI.GetYesNoDialogue().boxText).text = LocalisationSystem.Get("Override save?");
		((UnityEvent)MainUI.GetYesNoDialogue().yesButton.onClick).AddListener((UnityAction)delegate
		{
			OverrideSaveAndCheck(fileName);
		});
	}

	public void OverrideSaveAndCheck(string fileNameToDelete)
	{
		string newSaveName = Save.instance.SaveGame(isNewFile: false, Save.instance.GetFileSubfolder(fileNameToDelete));
		((MonoBehaviour)this).StartCoroutine(CheckOverrideSaveFile(newSaveName, fileNameToDelete));
		CloseUI();
	}

	private void NewSave()
	{
		string newSaveName = Save.instance.SaveGame(isNewFile: true);
		((MonoBehaviour)this).StartCoroutine(CheckNewSaveFile(newSaveName));
		CloseUI();
	}

	private IEnumerator CheckNewSaveFile(string newSaveName)
	{
		yield return CommonReferences.waitRealtime1;
		if (Save.instance.IsValidSaveData(newSaveName))
		{
			Debug.Log((object)"New save valid.");
			GameManager.GGFJGHHHEJC.PMKCJJCGKBB = newSaveName;
			yield break;
		}
		Save.instance.DeleteSave(newSaveName);
		yield return null;
		newSaveName = Save.instance.SaveGame();
		Debug.LogError((object)("Not Valid. Trying again with: " + newSaveName));
		yield return CommonReferences.waitRealtime1;
		if (Save.instance.IsValidSaveData(newSaveName))
		{
			Debug.Log((object)"New save valid.");
			GameManager.GGFJGHHHEJC.PMKCJJCGKBB = newSaveName;
		}
		else
		{
			Save.instance.DeleteSave(newSaveName);
			Debug.LogError((object)"Impossible to save a new file");
			MainUI.ShowErrorText(1, "Error while saving");
		}
	}

	private IEnumerator CheckOverrideSaveFile(string newSaveName, string fileNameToDelete)
	{
		yield return CommonReferences.waitRealtime1;
		if (Save.instance.IsValidSaveData(newSaveName))
		{
			Debug.Log((object)"Override save valid.");
			GameManager.GGFJGHHHEJC.PMKCJJCGKBB = newSaveName;
			if (!string.IsNullOrEmpty(fileNameToDelete))
			{
				if (Save.instance.GetFileSubfolder(newSaveName) == Save.instance.GetFileSubfolder(fileNameToDelete))
				{
					Save.instance.DeleteSave(fileNameToDelete);
				}
				else
				{
					Save.instance.DeleteSave(fileNameToDelete, deleteBackup: true);
				}
			}
			yield break;
		}
		Save.instance.DeleteSave(newSaveName);
		yield return null;
		newSaveName = Save.instance.SaveGame();
		Debug.LogError((object)("Not Valid. Trying again: " + newSaveName));
		yield return CommonReferences.waitRealtime1;
		if (Save.instance.IsValidSaveData(newSaveName))
		{
			Debug.Log((object)"Override save valid.");
			GameManager.GGFJGHHHEJC.PMKCJJCGKBB = newSaveName;
			if (!string.IsNullOrEmpty(fileNameToDelete))
			{
				if (Save.instance.GetFileSubfolder(newSaveName) == Save.instance.GetFileSubfolder(fileNameToDelete))
				{
					Save.instance.DeleteSave(fileNameToDelete);
				}
				else
				{
					Save.instance.DeleteSave(fileNameToDelete, deleteBackup: true);
				}
			}
		}
		else
		{
			Save.instance.DeleteSave(newSaveName);
			Debug.LogError((object)"Impossible to override the file");
			MainUI.ShowErrorText(1, LocalisationSystem.Get("ErrorWhileSaving"));
		}
	}

	public void DuplicateSave(string fileName)
	{
		if ((Object)(object)lastSlotSelected == (Object)null)
		{
			return;
		}
		string text = Save.instance.DuplicateGame(fileName);
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		((MonoBehaviour)this).StartCoroutine(CheckNewSaveFile(text));
		SaveSlotUI saveSlotUI = Object.Instantiate<SaveSlotUI>(saveSlotUIPrefab, saveSlotList.transform);
		Save.instance.GetSaveData(fileName);
		((Component)saveSlotUI).transform.SetSiblingIndex(((Component)lastSlotSelected).transform.GetSiblingIndex() + 1);
		saveSlotsUI.Insert(1, saveSlotUI);
		((Component)saveSlotUI).gameObject.SetActive(true);
		if (saveSlotUI.UpdateInfo(text))
		{
			saveSlotUI.OnSaveClicked = OnLoadSlotClicked;
			YesNoDialogueUI yesNoDialogue = MainUI.GetYesNoDialogue();
			if (!((Object)(object)yesNoDialogue == (Object)null))
			{
				yesNoDialogue.Open(1);
				((TMP_Text)yesNoDialogue.boxText).text = LocalisationSystem.Get("Saved game duplicated!");
				((Component)yesNoDialogue.noButton).gameObject.SetActive(false);
				yesNoDialogue.noButtonGamepadSprite.SetActive(false);
				Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Sound.GGFJGHHHEJC.banjoSuccessClip, HOMFPAFAOGD: true, null, null, 0.4f);
			}
		}
		else
		{
			((Component)saveSlotUI).gameObject.SetActive(false);
		}
	}

	public void DeleteSave(string fileName)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		MainUI.GetYesNoDialogue().Open(1);
		((TMP_Text)MainUI.GetYesNoDialogue().boxText).text = LocalisationSystem.Get("Delete save?");
		((UnityEvent)MainUI.GetYesNoDialogue().yesButton.onClick).AddListener((UnityAction)delegate
		{
			int num = 0;
			if (Object.op_Implicit((Object)(object)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL))
			{
				num = ((Component)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL).transform.parent.GetSiblingIndex();
			}
			int num2 = 0;
			if (PlayerInputs.IsGamepadActive(1))
			{
				for (int i = 0; i < saveSlotList.transform.childCount; i++)
				{
					if (((Component)saveSlotList.transform.GetChild(i)).gameObject.activeSelf)
					{
						num2++;
					}
				}
			}
			Save.instance.DeleteSave(fileName, deleteBackup: true);
			if (Object.op_Implicit((Object)(object)lastSlotSelected))
			{
				((Component)lastSlotSelected).transform.SetAsLastSibling();
				((Component)lastSlotSelected).gameObject.SetActive(false);
				saveSlotsUI.Remove(lastSlotSelected);
				saveSlotsUI.Add(lastSlotSelected);
				numSaveSlotsUI--;
			}
			if (PlayerInputs.IsGamepadActive(1))
			{
				if (num2 <= 1)
				{
					UpdateSaveSlots();
					OnContentActivated();
				}
				else if (num == num2 - 1)
				{
					PlayerInputs.GetPlayer(base.JIIGOACEIKL).SelectInTheNextFrame(((Component)saveSlotList.transform.GetChild(num - 1).GetChild(0)).gameObject);
				}
				else
				{
					PlayerInputs.GetPlayer(base.JIIGOACEIKL).SelectInTheNextFrame(((Component)saveSlotList.transform.GetChild(num).GetChild(0)).gameObject);
				}
			}
		});
	}

	public override void OpenUI()
	{
		if (IsOpen())
		{
			return;
		}
		mainMenu.SetActive(false);
		canvasGroup.alpha = 1f;
		canvasGroup.interactable = true;
		Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowOpen), HOMFPAFAOGD: true, null, null, 0.4f);
		lastSlotSelected = null;
		base.OpenUI();
		scrollbar.value = 1f;
		((Component)((TMP_Text)newGameText).transform.parent.parent).gameObject.SetActive(true);
		if (loading)
		{
			((TMP_Text)title).text = LocalisationSystem.Get("Load");
			string text = LocalisationSystem.Get("New");
			((TMP_Text)newGameText).text = (string.IsNullOrEmpty(text) ? "New" : text);
		}
		else
		{
			((TMP_Text)title).text = LocalisationSystem.Get("Save");
			string text2 = LocalisationSystem.Get("New Save");
			((TMP_Text)newGameText).text = (string.IsNullOrEmpty(text2) ? "New Save" : text2);
		}
		if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			GameActionBarUI.Get(1).CloseUI();
			if (GameManager.LocalCoop())
			{
				GameActionBarUI.Get(2).CloseUI();
			}
		}
		ActionBarInventory.GetPlayer(base.JIIGOACEIKL).scrollingEnabled = false;
	}

	public override void CloseUI()
	{
		if (!IsOpen() && !MainUI.closingAllUI)
		{
			return;
		}
		if (!MainUI.closingAllUI)
		{
			mainMenu.SetActive(true);
		}
		if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			MainUI.ResumeGame();
		}
		base.CloseUI();
		Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowClose), HOMFPAFAOGD: true, null, null, 0.4f);
		ActionBarInventory.GetPlayer(base.JIIGOACEIKL).scrollingEnabled = true;
		if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			GameActionBarUI.Get(1).OpenUI();
			if (GameManager.LocalCoop())
			{
				GameActionBarUI.Get(2).OpenUI();
			}
		}
		if ((Object)(object)InteractObject.GetPlayer(1) != (Object)null)
		{
			InteractObject.GetPlayer(1).EnableInteract();
		}
		if ((Object)(object)InteractObject.GetPlayer(2) != (Object)null)
		{
			InteractObject.GetPlayer(2).EnableInteract();
		}
	}

	public override void OnContentActivated()
	{
		base.OnContentActivated();
		if (OthersMenuUI.GGFJGHHHEJC.languageChanged)
		{
			ActuTextSlots();
			OthersMenuUI.GGFJGHHHEJC.languageChanged = false;
		}
		if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			MainUI.PauseGame();
		}
		if (PlayerInputs.IsGamepadActive(1))
		{
			nextFrame = true;
			if ((Object)(object)lastSlotSelected != (Object)null && saveSlotsUI.Contains(lastSlotSelected))
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)lastSlotSelected.button);
			}
			else
			{
				SelectFirstSaveSlot();
			}
		}
	}

	public void ActuTextSlots()
	{
		allSaves = Save.instance.GetAllSaveFiles();
		numSaveSlotsUI = allSaves.Length;
		for (int i = 0; i < numSaveSlotsUI; i++)
		{
			saveSlotsUI[i].UpdateInfo(allSaves[i]);
		}
	}

	public void SelectFirstSaveSlot()
	{
		if (numSaveSlotsUI > 0)
		{
			if (loading)
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)saveSlotsUI[0].button);
			}
			else
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)((TMP_Text)newGameText).transform.parent).gameObject.GetComponent<Selectable>());
			}
		}
		else
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(((Component)((TMP_Text)newGameText).transform.parent).gameObject.GetComponent<Selectable>());
		}
	}

	private IEnumerator StartEnteringGame(int playerNum, bool loadingGameCreatedBeforeAsAClient)
	{
		yield return null;
		Debug.Log((object)"StartEnteringGame - waitForGameplaySceneLoaded");
		CloseUI();
		TitleScreen.GetInstance().CloseTitleScreen();
		TitleScreen.GetInstance().WaitToLoadSeasonTiles(CAODJBLFPEB: true);
		if (GameManager.PlayingOnline())
		{
			while (OnlineManager.JBGAMJPMELP)
			{
				yield return null;
			}
		}
		else
		{
			while (GameManager.BPIHAFHNAMD != null && !GameManager.BPIHAFHNAMD.isDone)
			{
				yield return null;
			}
		}
		Debug.Log((object)"StartEnteringGame - loading game from save data");
		LoadGameFromSaveData(loadingGameCreatedBeforeAsAClient);
		if (!GameManager.GGFJGHHHEJC.NAPGPOJEEOJ && loadCharacterFromUI)
		{
			CharacterCreatorUI.Get(playerNum).SetCharacter(playerNum);
		}
		OnLoadFadeOutStart();
		OnLoadFadeOut();
		if (!startingNewGame)
		{
			PlayerController.TeleportPlayer(1, Bed.GetPlayerBedPosition(), Location.Tavern);
			if (Object.op_Implicit((Object)(object)PlayerController.GetPlayer(2)))
			{
				PlayerController.TeleportPlayer(2, Bed.GetPlayerBedPosition() + Vector3.right, Location.Tavern);
			}
			((Component)CameraTarget.GetPlayer(1)).transform.position = Bed.GetPlayerBedPosition();
			((Component)CameraTarget.GetPlayer(2)).transform.position = Bed.GetPlayerBedPosition() + Vector3.right;
			((Component)CommonReferences.GGFJGHHHEJC.GetMainCamera(1)).transform.position = new Vector3(Bed.GetPlayerBedPosition().x, Bed.GetPlayerBedPosition().y, ((Component)CommonReferences.GGFJGHHHEJC.GetMainCamera(1)).transform.position.z);
			((Component)CommonReferences.GGFJGHHHEJC.GetMainCamera(2)).transform.position = new Vector3(Bed.GetPlayerBedPosition().x + 1f, Bed.GetPlayerBedPosition().y, ((Component)CommonReferences.GGFJGHHHEJC.GetMainCamera(2)).transform.position.z);
		}
		else
		{
			SceneReferences.AFEDGPJNCDN = true;
		}
		if (!startingNewGame)
		{
			yield return CommonReferences.wait025;
			FadeCamera.GetPlayer(1).FadeInWithDelay();
			FadeCamera player = FadeCamera.GetPlayer(1);
			player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(TitleFadeInFinished));
		}
		Debug.Log((object)"StartEnteringGame coroutine FINISHED");
	}

	private void LoadGameFromSaveData(bool loadingGameCreatedBeforeAsAClient)
	{
		if (loadingGameCreatedBeforeAsAClient)
		{
			GameManager.GGFJGHHHEJC.HEJPPEJMPFE.OMKKHKNBEOP(OBEBFLBMLLE: true);
		}
		else if (startingNewGame)
		{
			if (OnlineManager.ClientOnline())
			{
				new SaveData().ENPEBDDJLCD();
			}
		}
		else if (OnlineManager.MasterOrOffline())
		{
			GameManager.GGFJGHHHEJC.HEJPPEJMPFE.KLFIFEBGDLP();
		}
		else
		{
			GameManager.GGFJGHHHEJC.HEJPPEJMPFE.OMKKHKNBEOP(OBEBFLBMLLE: false);
		}
	}

	public void TitleFadeInFinished(int playerNum)
	{
		PlayerInputs.EnableKeyboardInputs((MonoBehaviour)(object)this);
		FadeCamera player = FadeCamera.GetPlayer(playerNum);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(TitleFadeInFinished));
		GameManager.GGFJGHHHEJC.NAPGPOJEEOJ = true;
		string text = "";
		for (int i = 0; i < VersionNumberManager.instance.loadSavedGameVersionNumber.Length; i++)
		{
			text = text + VersionNumberManager.instance.loadSavedGameVersionNumber[i] + ".";
		}
		Debug.Log((object)("Loaded game version: " + text));
		Debug.Log((object)("Current game version: " + VersionNumberManager.instance.version));
	}

	public void UpdateSaveSlots(bool useCoroutine = true)
	{
		if (updateSaveSlotsCoroutine != null)
		{
			((MonoBehaviour)this).StopCoroutine(updateSaveSlotsCoroutine);
		}
		updateSaveSlotsCoroutine = ((MonoBehaviour)this).StartCoroutine(UpdateSaveSlotsCoroutine(useCoroutine));
	}

	private IEnumerator UpdateSaveSlotsCoroutine(bool useCoroutine)
	{
		yield return null;
		allSaves = Save.instance.GetAllSaveFiles();
		numSaveSlotsUI = allSaves.Length;
		int t = 0;
		for (int i = 0; i < numSaveSlotsUI; i++)
		{
			if (i >= saveSlotsUI.Count)
			{
				saveSlotsUI.Add(Object.Instantiate<SaveSlotUI>(saveSlotUIPrefab, saveSlotList.transform));
			}
			((Component)saveSlotsUI[i]).gameObject.SetActive(true);
			if (!saveSlotsUI[i].UpdateInfo(allSaves[i]))
			{
				((Component)saveSlotsUI[i]).gameObject.SetActive(false);
			}
			((Behaviour)saveSlotsUI[i].image).enabled = false;
			if (loading)
			{
				saveSlotsUI[i].OnSaveClicked = OnLoadSlotClicked;
			}
			else
			{
				saveSlotsUI[i].OnSaveClicked = OverrideSave;
			}
			if (useCoroutine)
			{
				t++;
				if (t > 2)
				{
					t = 0;
					LoadingScene.allSavesUpdatedProgress = (float)i / (float)numSaveSlotsUI;
					yield return null;
				}
			}
		}
		for (int j = numSaveSlotsUI; j < saveSlotsUI.Count; j++)
		{
			((Component)saveSlotsUI[j]).gameObject.SetActive(false);
		}
		LoadingScene.allSavesUpdatedProgress = 1f;
		LoadingScene.allSavesUpdated = true;
		updateSaveSlotsCoroutine = null;
		yield return null;
	}
}
