using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using I2.Loc;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TitleScreen : UIWindow, ISingleton
{
	private static TitleScreen GGFJGHHHEJC;

	public static Action OnLoadingBarFinished = delegate
	{
	};

	public bool goneToSleep;

	public static bool needsSaveIcon;

	[SerializeField]
	private TextMeshProUGUI pressAnyKeyGo;

	public Image backgroundImage;

	[SerializeField]
	private RectTransform backgroundRect;

	[SerializeField]
	private GameObject logoPanel;

	[SerializeField]
	private GameObject beerPlushieEventGO;

	[SerializeField]
	private TextMeshProUGUI[] beerPlushieLeftTime;

	[SerializeField]
	private YesNoDialogueUI yesNoDialogue;

	[SerializeField]
	private Button firstElementFocused;

	[SerializeField]
	private GameObject mainMenu;

	[SerializeField]
	private Sprite normalBackground;

	[SerializeField]
	private Sprite halloweenBackground;

	[SerializeField]
	private Sprite christmasBackground;

	[SerializeField]
	private TextMeshProUGUI versionText;

	[SerializeField]
	private Slider slider;

	[SerializeField]
	private GameObject christmasToggleButton;

	[SerializeField]
	private GameObject halloweenToggleButton;

	[SerializeField]
	private CanvasGroup saveIcon;

	private int BNNLEANIBKN;

	private Coroutine HJGMDCKKECH;

	public bool allTerrainUpdated;

	public float allTerrainUpdatedProgress;

	private bool FHNKOMMLMEI = true;

	[SerializeField]
	private bool seasonChanges;

	public bool waitingForSeasonChanges = true;

	public bool KFEPKOLPIHF { get; private set; }

	protected override void Awake()
	{
		GGFJGHHHEJC = this;
		ResetSingleton();
		logoPanel.SetActive(true);
		((Component)slider).gameObject.SetActive(false);
		BNNLEANIBKN = ((Component)this).transform.GetSiblingIndex();
	}

	public void ButtonQuit()
	{
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		if (OnlineManager.LICCAGGNELA != NetworkState.SettingUpInviteCode)
		{
			yesNoDialogue.Open(base.JIIGOACEIKL);
			if (Object.op_Implicit((Object)(object)yesNoDialogue.boxText))
			{
				((TMP_Text)yesNoDialogue.boxText).text = LocalisationSystem.Get("Quit to desktop?") + (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ ? ("\n" + LocalisationSystem.Get("Unsaved progress will be lost.")) : "");
			}
			else if (Object.op_Implicit((Object)(object)yesNoDialogue.boxText))
			{
				((TMP_Text)yesNoDialogue.boxText).text = LocalisationSystem.Get("Quit to desktop?") + (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ ? ("\n" + LocalisationSystem.Get("Unsaved progress will be lost.")) : "");
			}
			yesNoDialogue.AddYesAction(new UnityAction(FKBPGPOMLBN));
		}
	}

	private void EDMKFHJFPFD(bool HCOPJPMDEKP)
	{
		MKFEBKKAPBM();
	}

	public override void OnContentActivated()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		base.OnContentActivated();
		FHNKOMMLMEI = true;
		((Graphic)backgroundImage).color = Color.white;
		logoPanel.SetActive(true);
		CNJCBCLADCL();
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select(OnlineConnectionMenu.GetFirstFocusedElement());
		}
	}

	[SpecialName]
	public bool FAGIDCPDALI()
	{
		return _003CBAPEDBOPHKC_003Ek__BackingField;
	}

	private void FCPABDBCOJE(bool HCOPJPMDEKP)
	{
		FKIPJBBNNHM();
	}

	private void FDMFOKFMLFN(int JIIGOACEIKL)
	{
		FadeCamera player = FadeCamera.GetPlayer(0);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(FDMFOKFMLFN));
		GFKKLKOEODD(AODONKKHPBP: true);
		SaveUI.instance.TitleFadeInFinished(JIIGOACEIKL);
		TavernServiceManager.JFJOKGAOPHA().HBEGAFENFPK();
		if (OnlineManager.HHDBMDMFEMP())
		{
			CharacterCreatorUI.FKFNANNBIAM(0).firstStart = true;
			CharacterCreatorUI.Get(1).OFGKFMJKBON(1);
		}
	}

	private bool ICJPJJOJCLM()
	{
		if (OnlineManager.IsMasterClient())
		{
			return GameManager.JLEENILEMKP;
		}
		return OnlineLoadManager.SceneLoaded;
	}

	private bool KEPOPFDNJHA()
	{
		if (!GameManager.PlayingOnline() && GameManager.BPIHAFHNAMD != null)
		{
			return !GameManager.BPIHAFHNAMD.isDone;
		}
		return false;
	}

	private void FMGIGHCDHCO()
	{
		SaveUI instance = SaveUI.instance;
		instance.OnLoadFadeOut = (Action)Delegate.Remove(instance.OnLoadFadeOut, new Action(FMGIGHCDHCO));
		CloseTitleScreen();
	}

	public static void ActivateLoadingBar()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		GGFJGHHHEJC.slider.value = 0f;
		((Component)GGFJGHHHEJC.slider).gameObject.SetActive(true);
		GGFJGHHHEJC.logoPanel.SetActive(true);
		((Graphic)GGFJGHHHEJC.backgroundImage).color = Color.white;
		GGFJGHHHEJC.christmasToggleButton.SetActive(false);
		GGFJGHHHEJC.halloweenToggleButton.SetActive(false);
	}

	private void KCINGPBCMMB(int JIIGOACEIKL, UIWindow INDKANEMPMP)
	{
		if (!((Object)(object)CharacterCreatorUI.Get(1) == (Object)null))
		{
			christmasToggleButton.SetActive(Utils.AKDEMLPGIPH() && CharacterCreatorUI.Get(0).IsOpen());
			halloweenToggleButton.SetActive(!Utils.GPJOIALPOLC() || !CharacterCreatorUI.Get(1).BGLJFMHCFJF());
		}
	}

	public void LFOMNDEDJLI()
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		SaveUI.instance.loading = false;
		SaveUI.instance.Open(1);
		SaveUI instance = SaveUI.instance;
		instance.OnLoadFadeOut = (Action)Delegate.Remove(instance.OnLoadFadeOut, new Action(BLJDEPMNMJB));
		SaveUI instance2 = SaveUI.instance;
		instance2.OnLoadFadeOut = (Action)Delegate.Combine(instance2.OnLoadFadeOut, new Action(BLJDEPMNMJB));
		((Graphic)backgroundImage).color = new Color(1737f, 1448f, 425f);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(LKDEKKBDFAN));
	}

	private void LKDEKKBDFAN()
	{
		if (MainUI.IsAnyUIOpen(0))
		{
			PlayerInputs.GetPlayer(1).SwitchMapCategoryNextFrame("popUpBuilding15");
		}
		else
		{
			PlayerInputs.GetPlayer(0).SwitchMapCategoryNextFrame("Null ingredient!");
		}
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(MNKLPOKBGOH));
		MainUI.IMBPLDIPGOM();
		GameActionBarUI.DIMABMEHNNI(1).LMKCLPLJMPA();
	}

	private void MKFEBKKAPBM()
	{
		if (Utils.BDHBLGMBBCO())
		{
			if ((Object)(object)beerPlushieEventGO != (Object)null)
			{
				beerPlushieEventGO.SetActive(true);
			}
			HJGMDCKKECH = ((MonoBehaviour)this).StartCoroutine(OHAOELNJCIK());
			GameManager instance = GameManager.GGFJGHHHEJC;
			instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(PDCJIJKLELE));
		}
		else if ((Object)(object)beerPlushieEventGO != (Object)null)
		{
			beerPlushieEventGO.SetActive(false);
		}
		if (Utils.GBPMJDEKDEB())
		{
			if ((Object)(object)beerPlushieEventGO != (Object)null)
			{
				beerPlushieEventGO.SetActive(false);
			}
			HJGMDCKKECH = ((MonoBehaviour)this).StartCoroutine(ENCNFPOIJAE());
			GameManager instance2 = GameManager.GGFJGHHHEJC;
			instance2.OnWorldLoaded = (Action)Delegate.Combine(instance2.OnWorldLoaded, new Action(BNEMLPECNKC));
		}
		else if ((Object)(object)beerPlushieEventGO != (Object)null)
		{
			beerPlushieEventGO.SetActive(false);
		}
		if (Utils.FFLNGLMHLBO())
		{
			backgroundImage.sprite = halloweenBackground;
			((TMP_Text)versionText).text = VersionNumberManager.instance.version + "Items/item_name_725" + LocalizationManager.GetTranslation("", true, 0, true, false, (GameObject)null, (string)null, true);
		}
		else if (Utils.EGIBECKKIJJ())
		{
			backgroundImage.sprite = christmasBackground;
			((TMP_Text)versionText).text = VersionNumberManager.instance.version + "Hierarchy_" + LocalizationManager.GetTranslation("FarmReady", true, 1, true, false, (GameObject)null, (string)null, true);
		}
		else
		{
			backgroundImage.sprite = normalBackground;
			((TMP_Text)versionText).text = VersionNumberManager.instance.version;
		}
	}

	public void GKOMNDHKDHD()
	{
		goneToSleep = false;
		needsSaveIcon = false;
		OnLoadingBarFinished = delegate
		{
		};
	}

	public void ResetSingleton()
	{
		goneToSleep = false;
		needsSaveIcon = false;
		OnLoadingBarFinished = delegate
		{
		};
	}

	private void OMPAHBFCNLM(int JIIGOACEIKL, UIWindow INDKANEMPMP)
	{
		if (!((Object)(object)CharacterCreatorUI.Get(1) == (Object)null))
		{
			christmasToggleButton.SetActive(Utils.AKDEMLPGIPH() && !CharacterCreatorUI.Get(1).IsOpen());
			halloweenToggleButton.SetActive(Utils.GPJOIALPOLC() && !CharacterCreatorUI.Get(1).IsOpen());
		}
	}

	private void IFHFNDELKOP()
	{
		try
		{
			WaitToLoadSeasonTiles(CAODJBLFPEB: false);
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Error in TitleScreen.OnPlayerSleep: " + ex.Message));
		}
	}

	[SpecialName]
	public bool BIALNJEJMIO()
	{
		return _003CBAPEDBOPHKC_003Ek__BackingField;
	}

	private void FKIPJBBNNHM()
	{
		if (Utils.BDHBLGMBBCO())
		{
			if ((Object)(object)beerPlushieEventGO != (Object)null)
			{
				beerPlushieEventGO.SetActive(true);
			}
			HJGMDCKKECH = ((MonoBehaviour)this).StartCoroutine(OHAOELNJCIK());
			GameManager instance = GameManager.GGFJGHHHEJC;
			instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(KDLCDGIBCGN));
		}
		else if ((Object)(object)beerPlushieEventGO != (Object)null)
		{
			beerPlushieEventGO.SetActive(false);
		}
		if (Utils.GBPMJDEKDEB())
		{
			if ((Object)(object)beerPlushieEventGO != (Object)null)
			{
				beerPlushieEventGO.SetActive(true);
			}
			HJGMDCKKECH = ((MonoBehaviour)this).StartCoroutine(ENCNFPOIJAE());
			GameManager instance2 = GameManager.GGFJGHHHEJC;
			instance2.OnWorldLoaded = (Action)Delegate.Combine(instance2.OnWorldLoaded, new Action(BNEMLPECNKC));
		}
		else if ((Object)(object)beerPlushieEventGO != (Object)null)
		{
			beerPlushieEventGO.SetActive(false);
		}
		if (Utils.FFLNGLMHLBO())
		{
			backgroundImage.sprite = halloweenBackground;
			((TMP_Text)versionText).text = VersionNumberManager.instance.version + " - <b><color=#8C78BA>" + LocalizationManager.GetTranslation("HalloweenEvent", true, 0, true, false, (GameObject)null, (string)null, true);
		}
		else if (Utils.EGIBECKKIJJ())
		{
			backgroundImage.sprite = christmasBackground;
			((TMP_Text)versionText).text = VersionNumberManager.instance.version + " - <b><color=#0BC800>" + LocalizationManager.GetTranslation("ChristmasEvent", true, 0, true, false, (GameObject)null, (string)null, true);
		}
		else
		{
			backgroundImage.sprite = normalBackground;
			((TMP_Text)versionText).text = VersionNumberManager.instance.version;
		}
	}

	public static void IHBOPKAIPEE()
	{
		GGFJGHHHEJC.goneToSleep = false;
	}

	public void FLCHOEDIPED()
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		SaveUI.instance.loading = false;
		SaveUI.instance.Open(1);
		SaveUI instance = SaveUI.instance;
		instance.OnLoadFadeOut = (Action)Delegate.Remove(instance.OnLoadFadeOut, new Action(BLJDEPMNMJB));
		SaveUI instance2 = SaveUI.instance;
		instance2.OnLoadFadeOut = (Action)Delegate.Combine(instance2.OnLoadFadeOut, new Action(FMGIGHCDHCO));
		((Graphic)backgroundImage).color = new Color(1684f, 1745f, 365f);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(LKDEKKBDFAN));
	}

	private void JKFCOHFEIFH()
	{
		mainMenu.SetActive(true);
	}

	private void AJHNBIILBLO()
	{
		if (!Application.isEditor)
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	private void MNKLPOKBGOH()
	{
		if (MainUI.IsAnyUIOpen(1))
		{
			PlayerInputs.DEGBDMMDIIL(0).SwitchMapCategoryNextFrame("ProductValue");
		}
		else
		{
			PlayerInputs.DEGBDMMDIIL(0).AMMIOLBGBPB("RentedRoom");
		}
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(NAPGPOJEEOJ));
		MainUI.Show();
		GameActionBarUI.NDPAJCGHGOB(1).OnWorldLoaded();
	}

	public static void JJGBOLADCNK()
	{
		GGFJGHHHEJC.slider.value = 1177f;
		((Component)GGFJGHHHEJC.slider).gameObject.SetActive(false);
		GGFJGHHHEJC.logoPanel.SetActive(false);
		GGFJGHHHEJC.christmasToggleButton.SetActive(Utils.AKDEMLPGIPH());
		GGFJGHHHEJC.halloweenToggleButton.SetActive(Utils.GPJOIALPOLC());
	}

	private void PDCJIJKLELE()
	{
		if (HJGMDCKKECH != null)
		{
			((MonoBehaviour)this).StopCoroutine(HJGMDCKKECH);
		}
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(KDLCDGIBCGN));
	}

	private void CNJCBCLADCL()
	{
		if (Utils.FFLNGLMHLBO())
		{
			((TMP_Text)versionText).text = VersionNumberManager.instance.version + " - <b><color=#8C78BA>" + LocalizationManager.GetTranslation("HalloweenEvent", true, 0, true, false, (GameObject)null, (string)null, true);
		}
	}

	public static TitleScreen GetInstance()
	{
		return GGFJGHHHEJC;
	}

	public static void BackgroundSize()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		GGFJGHHHEJC.backgroundRect.sizeDelta = new Vector2((float)Screen.width, (float)Screen.height);
		float num = Screen.height / 9 * 16;
		if (num < (float)Screen.width)
		{
			GGFJGHHHEJC.backgroundRect.anchoredPosition = new Vector2(((float)Screen.width - num) / 2f, 0f);
			return;
		}
		GGFJGHHHEJC.backgroundRect.anchoredPosition = Vector2.zero;
		if ((float)(Screen.width / 16 * 9) < (float)Screen.height)
		{
			GGFJGHHHEJC.backgroundRect.sizeDelta = new Vector2(num + num % 9f, (float)Screen.height);
		}
	}

	private bool PNJLIBGKJLM()
	{
		if (OnlineManager.IsMasterClient())
		{
			return GameManager.JLEENILEMKP;
		}
		return OnlineLoadManager.SceneLoaded;
	}

	public void PFLCAMPHJLL()
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		SaveUI.instance.loading = true;
		SaveUI.instance.OFGKFMJKBON(0);
		SaveUI instance = SaveUI.instance;
		instance.OnLoadFadeOut = (Action)Delegate.Remove(instance.OnLoadFadeOut, new Action(BLJDEPMNMJB));
		SaveUI instance2 = SaveUI.instance;
		instance2.OnLoadFadeOut = (Action)Delegate.Combine(instance2.OnLoadFadeOut, new Action(FMGIGHCDHCO));
		((Graphic)backgroundImage).color = new Color(1039f, 1567f, 1670f);
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(LKDEKKBDFAN));
	}

	public static void PBIIABMONHB()
	{
		GGFJGHHHEJC.goneToSleep = false;
	}

	private void KDLCDGIBCGN()
	{
		if (HJGMDCKKECH != null)
		{
			((MonoBehaviour)this).StopCoroutine(HJGMDCKKECH);
		}
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(KDLCDGIBCGN));
	}

	public void DAKBEAIGAOD()
	{
		goneToSleep = true;
		needsSaveIcon = true;
		OnLoadingBarFinished = delegate
		{
		};
	}

	private bool PNJOGELKMOG()
	{
		if (!GameManager.FGFJEGOEDKJ() && GameManager.JOBIFMBNIGL() != null)
		{
			return !GameManager.JOBIFMBNIGL().isDone;
		}
		return true;
	}

	private void NADOCEEBICL()
	{
		KFEPKOLPIHF = true;
		((MonoBehaviour)this).StartCoroutine(KIJDLBFJLHB());
	}

	private void BLJDEPMNMJB()
	{
		SaveUI instance = SaveUI.instance;
		instance.OnLoadFadeOut = (Action)Delegate.Remove(instance.OnLoadFadeOut, new Action(FMGIGHCDHCO));
		CloseTitleScreen();
	}

	private void BLGIGPCNFND(bool HCOPJPMDEKP)
	{
		FKIPJBBNNHM();
	}

	private IEnumerator ENCNFPOIJAE()
	{
		while (Utils.GBPMJDEKDEB())
		{
			((TMP_Text)beerPlushieLeftTime[0]).text = Utils.HJAPIJDKAME();
			((TMP_Text)beerPlushieLeftTime[1]).text = ((TMP_Text)beerPlushieLeftTime[0]).text;
			yield return CommonReferences.waitRealtime1;
		}
		beerPlushieEventGO.SetActive(false);
		HJGMDCKKECH = null;
	}

	private void NAPGPOJEEOJ()
	{
		if (MainUI.IsAnyUIOpen(1))
		{
			PlayerInputs.GetPlayer(1).SwitchMapCategoryNextFrame("UI");
		}
		else
		{
			PlayerInputs.GetPlayer(1).SwitchMapCategoryNextFrame("Game");
		}
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(NAPGPOJEEOJ));
		MainUI.Show();
		GameActionBarUI.Get(1).OnWorldLoaded();
	}

	[SpecialName]
	private void GFKKLKOEODD(bool AODONKKHPBP)
	{
		_003CBAPEDBOPHKC_003Ek__BackingField = AODONKKHPBP;
	}

	private void LHNJHKDHOGC(int JIIGOACEIKL)
	{
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(LHNJHKDHOGC));
		KFEPKOLPIHF = false;
		SaveUI.instance.TitleFadeInFinished(JIIGOACEIKL);
		TavernServiceManager.GGFJGHHHEJC.NewDay();
		if (OnlineManager.ClientOnline())
		{
			CharacterCreatorUI.Get(1).firstStart = true;
			CharacterCreatorUI.Get(1).Open(1);
		}
	}

	private IEnumerator MMMEPILFBCP()
	{
		Debug.Log((object)"LoadingOnNewGameCreated");
		ActivateLoadingBar();
		((Component)this).transform.SetAsLastSibling();
		FadeCamera.GetPlayer(1).InstantFadeIn();
		if (GameManager.PlayingOnline())
		{
			while (OnlineManager.JBGAMJPMELP)
			{
				yield return null;
			}
		}
		else
		{
			while (!GameManager.BPIHAFHNAMD.isDone)
			{
				yield return null;
			}
		}
		float fakeDelay = 0f;
		while (fakeDelay < 2f)
		{
			fakeDelay += Time.deltaTime;
			slider.value = Mathf.Clamp01(fakeDelay / 2f);
			yield return null;
		}
		DeactivateLoadingBar();
		((Component)this).transform.SetSiblingIndex(BNNLEANIBKN);
		PlayerInputs.EnableKeyboardInputs((MonoBehaviour)(object)this);
		FadeCamera.GetPlayer(1).FadeIn();
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(LHNJHKDHOGC));
		if (OnlineManager.MasterOrOffline() && (!Application.isEditor || DevConsole.instance.forceIntro))
		{
			Intro.instance.StartIntro();
		}
	}

	protected override void Update()
	{
		if (FHNKOMMLMEI)
		{
			FHNKOMMLMEI = false;
		}
		else if (IsOpen() && PlayerInputs.IsGamepadActive(1) && PlayerInputs.GetPlayer(1).GetButtonUp("UIAddRemove") && Utils.GBPMJDEKDEB())
		{
			OpenMakeshipCampaign();
		}
	}

	public void DJFFKNGKPAF()
	{
		Application.OpenURL("ClosePopUp");
	}

	private void OnDestroy()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
		if (!GameManager.CIOEICMHCCK)
		{
			ChristmasEvent.OnChristmasActivated = (Action<bool>)Delegate.Remove(ChristmasEvent.OnChristmasActivated, new Action<bool>(BFKECDBMBGH));
			UIWindow.OnAnyUIOpen = (Action<int, UIWindow>)Delegate.Remove(UIWindow.OnAnyUIOpen, new Action<int, UIWindow>(OMPAHBFCNLM));
			UIWindow.OnAnyUIClose = (Action<int, UIWindow>)Delegate.Remove(UIWindow.OnAnyUIClose, new Action<int, UIWindow>(OKDGLJHOMDN));
		}
	}

	private void KMNCBOAONKE()
	{
		if (Utils.FFLNGLMHLBO())
		{
			((TMP_Text)versionText).text = VersionNumberManager.instance.version + "talent_name_116" + LocalizationManager.GetTranslation("MissionTalkWith: NPC not found for character ", true, 0, true, true, (GameObject)null, (string)null, true);
		}
	}

	private void MGIKPEJCAGN(Season EECEKHKAAIH)
	{
		Debug.Log((object)"ShieldTrigger");
		GGFJGHHHEJC.waitingForSeasonChanges = true;
		seasonChanges = true;
	}

	private void IEHDLNPLLCM(int JIIGOACEIKL, UIWindow INDKANEMPMP)
	{
		if (!((Object)(object)CharacterCreatorUI.PCEEOGGDBFB(0) == (Object)null))
		{
			christmasToggleButton.SetActive(!Utils.AKDEMLPGIPH() || CharacterCreatorUI.Get(1).HDEPMJIDJEM());
			halloweenToggleButton.SetActive(Utils.GPJOIALPOLC() && !CharacterCreatorUI.PCEEOGGDBFB(1).IsOpen());
		}
	}

	public void ButtonOptions()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.LICCAGGNELA != NetworkState.SettingUpInviteCode)
		{
			OptionsMenuUI.GGFJGHHHEJC.Open(base.JIIGOACEIKL);
			((Graphic)backgroundImage).color = new Color(0.2f, 0.2f, 0.2f);
		}
	}

	private void ECGHNOFOEAB()
	{
		if (Utils.BDHBLGMBBCO())
		{
			if ((Object)(object)beerPlushieEventGO != (Object)null)
			{
				beerPlushieEventGO.SetActive(true);
			}
			HJGMDCKKECH = ((MonoBehaviour)this).StartCoroutine(OHAOELNJCIK());
			GameManager instance = GameManager.GGFJGHHHEJC;
			instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(KDLCDGIBCGN));
		}
		else if ((Object)(object)beerPlushieEventGO != (Object)null)
		{
			beerPlushieEventGO.SetActive(false);
		}
		if (Utils.GBPMJDEKDEB())
		{
			if ((Object)(object)beerPlushieEventGO != (Object)null)
			{
				beerPlushieEventGO.SetActive(false);
			}
			HJGMDCKKECH = ((MonoBehaviour)this).StartCoroutine(ENCNFPOIJAE());
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(BNEMLPECNKC));
		}
		else if ((Object)(object)beerPlushieEventGO != (Object)null)
		{
			beerPlushieEventGO.SetActive(true);
		}
		if (Utils.FFLNGLMHLBO())
		{
			backgroundImage.sprite = halloweenBackground;
			((TMP_Text)versionText).text = VersionNumberManager.instance.version + "Description of " + LocalizationManager.GetTranslation("F3", false, 0, false, false, (GameObject)null, (string)null, true);
		}
		else if (Utils.EGIBECKKIJJ())
		{
			backgroundImage.sprite = christmasBackground;
			((TMP_Text)versionText).text = VersionNumberManager.instance.version + "</color>" + LocalizationManager.GetTranslation("DecorationTile_15", true, 0, false, false, (GameObject)null, (string)null, true);
		}
		else
		{
			backgroundImage.sprite = normalBackground;
			((TMP_Text)versionText).text = VersionNumberManager.instance.version;
		}
	}

	public static void DeactivateLoadingBar()
	{
		GGFJGHHHEJC.slider.value = 0f;
		((Component)GGFJGHHHEJC.slider).gameObject.SetActive(false);
		GGFJGHHHEJC.logoPanel.SetActive(false);
		GGFJGHHHEJC.christmasToggleButton.SetActive(Utils.AKDEMLPGIPH());
		GGFJGHHHEJC.halloweenToggleButton.SetActive(Utils.GPJOIALPOLC());
	}

	private void BONAHDEKFPC(int JIIGOACEIKL, UIWindow INDKANEMPMP)
	{
		if (!((Object)(object)CharacterCreatorUI.DPBGKDNKDGM(1) == (Object)null))
		{
			christmasToggleButton.SetActive(!Utils.AKDEMLPGIPH() || CharacterCreatorUI.MENPEHNHFOA(1).BGLJFMHCFJF());
			halloweenToggleButton.SetActive(Utils.GPJOIALPOLC() && CharacterCreatorUI.DPBGKDNKDGM(0).HDEPMJIDJEM());
		}
	}

	private void GPIJGGNMNDH(Season EECEKHKAAIH)
	{
		Debug.Log((object)"Waiting for season change done");
		GGFJGHHHEJC.waitingForSeasonChanges = false;
		seasonChanges = true;
	}

	public void ButtonStart()
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		SaveUI.instance.loading = true;
		SaveUI.instance.Open(1);
		SaveUI instance = SaveUI.instance;
		instance.OnLoadFadeOut = (Action)Delegate.Remove(instance.OnLoadFadeOut, new Action(FMGIGHCDHCO));
		SaveUI instance2 = SaveUI.instance;
		instance2.OnLoadFadeOut = (Action)Delegate.Combine(instance2.OnLoadFadeOut, new Action(FMGIGHCDHCO));
		((Graphic)backgroundImage).color = new Color(0.2f, 0.2f, 0.2f);
		GameManager instance3 = GameManager.GGFJGHHHEJC;
		instance3.OnWorldLoaded = (Action)Delegate.Combine(instance3.OnWorldLoaded, new Action(NAPGPOJEEOJ));
	}

	public void WaitToLoadSeasonTiles(bool CAODJBLFPEB)
	{
		if (KFEPKOLPIHF)
		{
			if (Application.isEditor && !Utils.DPFCPGIEJDF())
			{
				SaveUI.instance.loading = false;
				SaveUI.instance.UpdateSaveSlots();
				SaveUI.instance.Open(1);
			}
		}
		else
		{
			seasonChanges = false;
			((MonoBehaviour)this).StartCoroutine(LoadingSeasonTilesProgressBar(CAODJBLFPEB));
		}
	}

	private void CCFGCNEOEBE(Season EECEKHKAAIH)
	{
		Debug.Log((object)"talentRoasting");
		GGFJGHHHEJC.waitingForSeasonChanges = false;
		seasonChanges = true;
	}

	private void FKBPGPOMLBN()
	{
		if (!Application.isEditor)
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	public void GGCKENMNHPD(bool CAODJBLFPEB)
	{
		if (BIALNJEJMIO())
		{
			if (Application.isEditor && !Utils.DPFCPGIEJDF())
			{
				SaveUI.instance.loading = false;
				SaveUI.instance.UpdateSaveSlots();
				SaveUI.instance.OFGKFMJKBON(1);
			}
		}
		else
		{
			seasonChanges = true;
			((MonoBehaviour)this).StartCoroutine(LoadingSeasonTilesProgressBar(CAODJBLFPEB));
		}
	}

	private IEnumerator KIJDLBFJLHB()
	{
		Debug.Log((object)"LoadingOnNewGameCreated");
		ActivateLoadingBar();
		((Component)this).transform.SetAsLastSibling();
		FadeCamera.GetPlayer(1).InstantFadeIn();
		if (GameManager.PlayingOnline())
		{
			while (OnlineManager.JBGAMJPMELP)
			{
				yield return null;
			}
		}
		else
		{
			while (!GameManager.BPIHAFHNAMD.isDone)
			{
				yield return null;
			}
		}
		float fakeDelay = 0f;
		while (fakeDelay < 2f)
		{
			fakeDelay += Time.deltaTime;
			slider.value = Mathf.Clamp01(fakeDelay / 2f);
			yield return null;
		}
		DeactivateLoadingBar();
		((Component)this).transform.SetSiblingIndex(BNNLEANIBKN);
		PlayerInputs.EnableKeyboardInputs((MonoBehaviour)(object)this);
		FadeCamera.GetPlayer(1).FadeIn();
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(LHNJHKDHOGC));
		if (OnlineManager.MasterOrOffline() && (!Application.isEditor || DevConsole.instance.forceIntro))
		{
			Intro.instance.StartIntro();
		}
	}

	public void OpenMakeshipCampaign()
	{
		Application.OpenURL("https://www.makeship.com/products/bob-plush-2");
	}

	private IEnumerator BFLBNJADECK()
	{
		Debug.Log((object)"LoadingOnNewGameCreated");
		ActivateLoadingBar();
		((Component)this).transform.SetAsLastSibling();
		FadeCamera.GetPlayer(1).InstantFadeIn();
		if (GameManager.PlayingOnline())
		{
			while (OnlineManager.JBGAMJPMELP)
			{
				yield return null;
			}
		}
		else
		{
			while (!GameManager.BPIHAFHNAMD.isDone)
			{
				yield return null;
			}
		}
		float fakeDelay = 0f;
		while (fakeDelay < 2f)
		{
			fakeDelay += Time.deltaTime;
			slider.value = Mathf.Clamp01(fakeDelay / 2f);
			yield return null;
		}
		DeactivateLoadingBar();
		((Component)this).transform.SetSiblingIndex(BNNLEANIBKN);
		PlayerInputs.EnableKeyboardInputs((MonoBehaviour)(object)this);
		FadeCamera.GetPlayer(1).FadeIn();
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(LHNJHKDHOGC));
		if (OnlineManager.MasterOrOffline() && (!Application.isEditor || DevConsole.instance.forceIntro))
		{
			Intro.instance.StartIntro();
		}
	}

	public void CloseTitleScreen()
	{
		MainUI.RemoveWindow(this);
		LKOJBFMGMAE = false;
		content.SetActive(false);
		Debug.Log((object)"CloseTitleScreen");
	}

	private void OKDGLJHOMDN(int JIIGOACEIKL, UIWindow INDKANEMPMP)
	{
		if (!((Object)(object)CharacterCreatorUI.Get(1) == (Object)null))
		{
			christmasToggleButton.SetActive(Utils.AKDEMLPGIPH() && !CharacterCreatorUI.Get(1).IsOpen());
			halloweenToggleButton.SetActive(Utils.GPJOIALPOLC() && !CharacterCreatorUI.Get(1).IsOpen());
		}
	}

	private void BFKECDBMBGH(bool HCOPJPMDEKP)
	{
		FKIPJBBNNHM();
	}

	public static void WakeUp()
	{
		GGFJGHHHEJC.goneToSleep = true;
	}

	public IEnumerator LoadingSeasonTilesProgressBar(bool CAODJBLFPEB)
	{
		ActivateLoadingBar();
		((Component)this).transform.SetAsLastSibling();
		if (GameManager.LocalCoop())
		{
			PlayerInputs.DisableKeyboardInputsAndMovement(2, (MonoBehaviour)(object)this);
		}
		PlayerInputs.DisableKeyboardInputsAndMovement(1, (MonoBehaviour)(object)this);
		float t = 0f;
		allTerrainUpdated = false;
		allTerrainUpdatedProgress = 0f;
		if (!DevConsole.instance.onPlayerSleepFromDevConsole)
		{
			while ((OnlineManager.MasterOrOffline() && !allTerrainUpdated && seasonChanges) || (t < 1f && !seasonChanges) || (CAODJBLFPEB && (KEPOPFDNJHA() || (GameManager.PlayingOnline() && !PNJLIBGKJLM()))))
			{
				if (CAODJBLFPEB)
				{
					if (!GameManager.PlayingOnline())
					{
						if (GameManager.BPIHAFHNAMD == null || GameManager.BPIHAFHNAMD.isDone)
						{
							slider.value = 0.1f;
						}
						else
						{
							slider.value = Mathf.Clamp01(GameManager.BPIHAFHNAMD.progress) * 0.1f;
						}
					}
					else if (PNJLIBGKJLM())
					{
						slider.value = 0.1f;
					}
					else
					{
						slider.value = Mathf.Clamp01(GameManager.PGFOBLEECEK) * 0.1f;
					}
				}
				else
				{
					slider.value = 0f;
				}
				if (seasonChanges)
				{
					Slider obj = slider;
					obj.value += Mathf.Clamp01(allTerrainUpdatedProgress) * (goneToSleep ? 1f : 0.5f);
				}
				else if (goneToSleep)
				{
					t += 0.4f * Time.unscaledDeltaTime;
					Slider obj2 = slider;
					obj2.value += Mathf.Clamp01(t);
				}
				else
				{
					t += 0.15f * Time.unscaledDeltaTime;
					Slider obj3 = slider;
					obj3.value += Mathf.Clamp01(t) * 0.5f;
				}
				if (needsSaveIcon && slider.value > 0.2f)
				{
					if (!((Component)saveIcon).gameObject.activeInHierarchy)
					{
						((Component)saveIcon).gameObject.SetActive(true);
						saveIcon.alpha = 1f;
					}
					else if (slider.value > 0.8f)
					{
						saveIcon.alpha = Mathf.Lerp(1f, 0f, (slider.value - 0.8f) * 5f);
					}
				}
				yield return null;
			}
		}
		while (waitingForSeasonChanges)
		{
			yield return null;
		}
		waitingForSeasonChanges = true;
		if (OnlineManager.ClientOnline())
		{
			slider.value = 1f;
		}
		else
		{
			while (!allTerrainUpdated && seasonChanges && !goneToSleep)
			{
				slider.value = 0.6f + 0.4f * (allTerrainUpdatedProgress + 0.05f);
				yield return null;
			}
		}
		DeactivateLoadingBar();
		((Component)this).transform.SetSiblingIndex(BNNLEANIBKN);
		if (GameManager.LocalCoop())
		{
			PlayerInputs.EnableKeyboardInputsAndMovement(2, (MonoBehaviour)(object)this);
		}
		PlayerInputs.EnableKeyboardInputsAndMovement(1, (MonoBehaviour)(object)this);
		if (needsSaveIcon)
		{
			((Component)saveIcon).gameObject.SetActive(false);
			needsSaveIcon = false;
		}
		if (goneToSleep)
		{
			if (Application.isEditor && !Utils.DPFCPGIEJDF())
			{
				SaveUI.instance.loading = false;
				SaveUI.instance.UpdateSaveSlots();
				SaveUI.instance.Open(1);
			}
			((Component)saveIcon).gameObject.SetActive(false);
			goneToSleep = false;
		}
		OnLoadingBarFinished();
	}

	private bool GODJCDBBDAN()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			return GameManager.EGKENIPGJEO();
		}
		return OnlineLoadManager.SceneLoaded;
	}

	protected override void Start()
	{
		Open(1);
		if (Application.isEditor)
		{
			JKFCOHFEIFH();
		}
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnLoadMenuScene = (Action)Delegate.Combine(instance.OnLoadMenuScene, new Action(JKFCOHFEIFH));
		GameManager instance2 = GameManager.GGFJGHHHEJC;
		instance2.OnNewGameCreated = (Action)Delegate.Combine(instance2.OnNewGameCreated, new Action(NADOCEEBICL));
		CommonReferences instance3 = CommonReferences.GGFJGHHHEJC;
		instance3.OnPlayerSleep = (Action)Delegate.Combine(instance3.OnPlayerSleep, new Action(IFHFNDELKOP));
		SeasonManager instance4 = SeasonManager.instance;
		instance4.OnSeasonChanged = (Action<Season>)Delegate.Combine(instance4.OnSeasonChanged, new Action<Season>(GPIJGGNMNDH));
		ChristmasEvent.OnChristmasActivated = (Action<bool>)Delegate.Combine(ChristmasEvent.OnChristmasActivated, new Action<bool>(BFKECDBMBGH));
		HalloweenEvent instance5 = HalloweenEvent.GGFJGHHHEJC;
		instance5.OnHalloweenActivated = (Action<bool>)Delegate.Combine(instance5.OnHalloweenActivated, new Action<bool>(FCPABDBCOJE));
		UIWindow.OnAnyUIOpen = (Action<int, UIWindow>)Delegate.Combine(UIWindow.OnAnyUIOpen, new Action<int, UIWindow>(OMPAHBFCNLM));
		UIWindow.OnAnyUIClose = (Action<int, UIWindow>)Delegate.Combine(UIWindow.OnAnyUIClose, new Action<int, UIWindow>(OKDGLJHOMDN));
		((TMP_Text)versionText).text = VersionNumberManager.instance.version;
		FKIPJBBNNHM();
		PlayerInputs.GetPlayer(1).SwitchMapCategory("UI");
		PlayerInputs.GetPlayer(2).SwitchMapCategory("UI");
		GameActionBarUI.Get(1).CloseUI();
		GameActionBarUI.Get(2).CloseUI();
		christmasToggleButton.SetActive(Utils.AKDEMLPGIPH());
		halloweenToggleButton.SetActive(Utils.GPJOIALPOLC());
		PlayerInputs.OnControllerSwitched = (Action)Delegate.Combine(PlayerInputs.OnControllerSwitched, new Action(CNJCBCLADCL));
		LocalisationSystem instance6 = LocalisationSystem.GGFJGHHHEJC;
		instance6.OnLanguageChanged = (Action)Delegate.Combine(instance6.OnLanguageChanged, new Action(CNJCBCLADCL));
		BackgroundSize();
	}

	private IEnumerator OHAOELNJCIK()
	{
		while (Utils.BDHBLGMBBCO())
		{
			((TMP_Text)beerPlushieLeftTime[0]).text = Utils.OHNBGHCNBLI();
			((TMP_Text)beerPlushieLeftTime[1]).text = ((TMP_Text)beerPlushieLeftTime[0]).text;
			yield return CommonReferences.waitRealtime1;
		}
		beerPlushieEventGO.SetActive(false);
		HJGMDCKKECH = null;
	}

	private void BNEMLPECNKC()
	{
		if (HJGMDCKKECH != null)
		{
			((MonoBehaviour)this).StopCoroutine(HJGMDCKKECH);
		}
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(BNEMLPECNKC));
	}
}
