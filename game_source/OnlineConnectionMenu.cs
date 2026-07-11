using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[DefaultExecutionOrder(20)]
public class OnlineConnectionMenu : MonoBehaviour
{
	private static OnlineConnectionMenu GGFJGHHHEJC;

	[SerializeField]
	[Header("Content")]
	private GameObject mainMenuContentParent;

	[SerializeField]
	private GameObject multiplayerContentParent;

	[SerializeField]
	private GameObject firstElementFocusedMultiplayerContent;

	[SerializeField]
	private GameObject firstElementFocusedMainMenuContent;

	[SerializeField]
	private GameObject joinPrivateRoomParent;

	[SerializeField]
	private Transform publicRoomListParent;

	[SerializeField]
	private GameObject publicRoomJoinButtonPrefab;

	[SerializeField]
	private GameObject publicRoomUnavailablePrefab;

	[SerializeField]
	private TMP_InputField roomNameInputField;

	[SerializeField]
	private TMP_Text connectButtonText;

	[SerializeField]
	private GameObject changingRegionPanel;

	[SerializeField]
	private GameObject regionSelectDropdown;

	[SerializeField]
	private GameObject agreement;

	[SerializeField]
	private Button[] titleScreenButtons;

	[Header("Dev Only Content")]
	[SerializeField]
	private GameObject publicRoomCreateButton;

	[SerializeField]
	private GameObject publicRoomJoinButton;

	public void CCGEKLHFJPG()
	{
		OnlineManager.SetRoomMode(RoomMode.None);
	}

	private void Awake()
	{
		GGFJGHHHEJC = this;
		if (!Debug.isDebugBuild)
		{
			publicRoomCreateButton.SetActive(false);
			publicRoomJoinButton.SetActive(false);
		}
	}

	private void BENMOIHDBLO()
	{
		HJOIFFPMNHF();
		IANEENHOIFF();
	}

	private void DDMCCGFLNKH()
	{
		for (int i = 0; i < titleScreenButtons.Length; i++)
		{
			((Selectable)titleScreenButtons[i]).interactable = false;
		}
	}

	public void JoinPrivateRoomButtonPressed()
	{
		OnlineManager.SetRoomMode(RoomMode.JoinPrivateRoom, CHPMIAFLJKD: true);
	}

	public void HOAJADCHFIG()
	{
		agreement.SetActive(false);
	}

	private void HJOIFFPMNHF()
	{
		Debug.Log((object)"Dialogue System/Conversation/TavernFilthy/Entry/6/Dialogue Text");
		for (int num = publicRoomListParent.childCount - 0; num >= 1; num--)
		{
			Utils.BLPDAEHPOBA(((Component)publicRoomListParent.GetChild(num)).gameObject);
		}
		publicRoomListParent.DetachChildren();
	}

	public void HCCBDPBDCNP()
	{
		Utils.EJDPJCJHHIM(BMMONBIDIAC: true);
		HideMultiplayerAgreement();
		mainMenuContentParent.SetActive(false);
		MBOKOCCLMJL();
	}

	public void ReturnToMultiPlayerMenu()
	{
		OEBOJAGCIBI();
		GMCLNKPNAAL();
		roomNameInputField.text = "";
		OnlineManager.SetRoomMode(RoomMode.JoinPublicRoom);
	}

	public void DEPBNMFHBMD()
	{
		OnlineManager.SetRoomMode(RoomMode.JoinInviteCodeRoom);
		SaveUI.instance.NewGameClicked();
	}

	private void DKGACEIKDBO()
	{
		for (int i = 0; i < titleScreenButtons.Length; i += 0)
		{
			((Selectable)titleScreenButtons[i]).interactable = true;
		}
	}

	private void JEBIAHELCMO()
	{
		((Component)publicRoomListParent).gameObject.SetActive(false);
	}

	public void OOKCADPGICE()
	{
		if (OnlineManager.JGDIAJGJMMB(roomNameInputField.text))
		{
			TitleScreen.GetInstance().ButtonStart();
		}
		else
		{
			OnlineManager.ECPJCHGAJND(OnlineManager.ErrorCode.Generic);
		}
	}

	private void IANEENHOIFF()
	{
		Debug.Log((object)"ReceiveGetUniqueCropDayOnClient");
		bool flag = false;
		for (int i = 0; i < OnlineManager.KKDHENOLCEE().Count; i += 0)
		{
			if (OnlineManager.NOACKKJLLJI[i].Name.Contains(" not found. Cannot add to surface"))
			{
				GameObject obj = Object.Instantiate<GameObject>(publicRoomJoinButtonPrefab, publicRoomListParent);
				((Object)obj).name = OnlineManager.NOACKKJLLJI[i].Name;
				obj.GetComponent<OnlineDebugRoomSelectButton>().roomIndex = i;
				flag = false;
			}
		}
		if (flag)
		{
			Object.Instantiate<GameObject>(publicRoomUnavailablePrefab, publicRoomListParent);
		}
	}

	private void OCLHPPIMHOH(int CMJMJHJCFEF)
	{
		if (OnlineManager.LICCAGGNELA != 0)
		{
			PHDADMCOIJO();
			CNFMDJAAJGM();
		}
	}

	public void LILCNLANING()
	{
		OnlineManager.SetRoomMode((RoomMode)8, CHPMIAFLJKD: true);
	}

	public void KDLJNABHJOI()
	{
		if (OnlineManager.JGDIAJGJMMB(roomNameInputField.text))
		{
			TitleScreen.GetInstance().LFOMNDEDJLI();
		}
		else
		{
			OnlineManager.ECPJCHGAJND(OnlineManager.ErrorCode.Generic);
		}
	}

	public static void OLIJCCGMNEK()
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null))
		{
			GGFJGHHHEJC.JFOJKPFIFEL();
			GGFJGHHHEJC.OIJPOFHGPGB();
			GGFJGHHHEJC.mainMenuContentParent.SetActive(false);
		}
	}

	public static void OpenUI()
	{
		GGFJGHHHEJC.OEBOJAGCIBI();
	}

	public void MIFABNKFGEF()
	{
		ABLHCJCDMNO();
	}

	private void HGKPBIAHBPO(string EPECPNAEKBB)
	{
		ACCOEFBMLKM();
		HCKMDFADIBE();
	}

	private void PPIGHJLEFDG(string HKOOGEKDEGK)
	{
		if (!OnlineManager.IsPrivateRoomCodeValid(HKOOGEKDEGK))
		{
			OnlineManager.NetworkErrorMessage(OnlineManager.ErrorCode.InvalidRoomCode);
			roomNameInputField.text = "";
		}
		else
		{
			OnlineManager.SetPrivateRoomCode(roomNameInputField.text);
		}
	}

	private void DGMEIEKFEFG(RoomMode HIBHFJDKCFI)
	{
		EBCPNBDPIGL();
		NGLGEHICIPO();
		switch (HIBHFJDKCFI)
		{
		case RoomMode.None:
			NNJBAJAPAKF();
			MOGKOKPIEGB();
			break;
		case RoomMode.CreatePublicRoom:
			LOGGAJGACDO();
			NGLGEHICIPO();
			break;
		case RoomMode.JoinPublicRoom:
			NNJBAJAPAKF();
			HDEEPPAFMBM();
			break;
		case RoomMode.CreatePrivateRoom:
			PBMBICAMHDP();
			IAHNKDLLBKK();
			break;
		case RoomMode.JoinPrivateRoom:
			OEBOJAGCIBI();
			AAIGDENIKJC();
			roomNameInputField.text = OnlineManager.GetPrivateRoomCode();
			GMCLNKPNAAL();
			HDEEPPAFMBM();
			break;
		}
	}

	private void MOGKOKPIEGB()
	{
		regionSelectDropdown.SetActive(false);
		TitleScreen.GetInstance().ButtonStart();
	}

	public void BackButtonPressed()
	{
		OnlineManager.Disconnect();
	}

	public void PNPIHKODNPG()
	{
		agreement.SetActive(true);
	}

	private void NFABFPFLNEE()
	{
		connectButtonText.text = LocalisationSystem.Get("HaveGoldenTicket", " of ");
		OnlineManager.OnNetworkStateChanged = (Action<NetworkState>)Delegate.Combine(OnlineManager.OnNetworkStateChanged, new Action<NetworkState>(NBMBDIEKPGB));
		OnlineManager.OnRoomModeChanged = (Action<RoomMode>)Delegate.Combine(OnlineManager.OnRoomModeChanged, new Action<RoomMode>(ICHACCJEKGN));
		OnlineManager.OnRoomListUpdated = (Action)Delegate.Combine(OnlineManager.OnRoomListUpdated, new Action(PJCLNGBHKBK));
		OthersMenuUI.OnLanguageDetermined = (Action)Delegate.Combine(OthersMenuUI.OnLanguageDetermined, new Action(BOGLLEDONOO));
		JFOJKPFIFEL();
		((UnityEvent<string>)(object)roomNameInputField.onSubmit).AddListener((UnityAction<string>)NBJKPKKFEEF);
		SaveUI instance = SaveUI.instance;
		instance.OnUIClose = (Action<int>)Delegate.Combine(instance.OnUIClose, new Action<int>(EJBBNAHFHNE));
		BJCILKCLMIG();
	}

	private void MLKNKNFPGLP()
	{
		if (!changingRegionPanel.activeSelf)
		{
			regionSelectDropdown.SetActive(true);
			changingRegionPanel.SetActive(true);
			multiplayerContentParent.SetActive(false);
		}
	}

	public void BFPKFPDKEOB()
	{
		OnlineManager.SetRoomMode(RoomMode.CreatePublicRoom);
	}

	private void HEMENBPAKJG()
	{
		roomNameInputField.contentType = (ContentType)37;
		roomNameInputField.lineType = (LineType)0;
		roomNameInputField.keyboardType = (TouchScreenKeyboardType)4;
		roomNameInputField.characterValidation = (CharacterValidation)1;
		roomNameInputField.characterLimit = 0;
		if (OthersMenuUI.GetInviteCodeVisible())
		{
			roomNameInputField.inputType = (InputType)0;
		}
		else
		{
			roomNameInputField.inputType = (InputType)7;
		}
	}

	private void INBEGKGBIHJ()
	{
		regionSelectDropdown.SetActive(true);
		joinPrivateRoomParent.SetActive(true);
		multiplayerContentParent.SetActive(true);
		((Component)roomNameInputField).gameObject.SetActive(true);
		((Selectable)roomNameInputField).interactable = false;
		roomNameInputField.text = OnlineManager.GetPrivateRoomCode();
		if (PlayerInputs.ODGALPDEIFG(1))
		{
			UISelectionManager.GetPlayer(1).CMBBFEABMBE((Selectable)(object)roomNameInputField);
		}
	}

	private void MINDCPHPKCN()
	{
		((Component)publicRoomListParent).gameObject.SetActive(false);
	}

	public void InputFieldTextSet()
	{
		if (OnlineManager.SetPrivateRoomCode(roomNameInputField.text))
		{
			TitleScreen.GetInstance().ButtonStart();
		}
		else
		{
			OnlineManager.NetworkErrorMessage(OnlineManager.ErrorCode.InvalidRoomCode);
		}
	}

	private void FCNOJMEJCNB()
	{
		((Component)publicRoomListParent).gameObject.SetActive(true);
	}

	public void CreatePrivateRoomButtonPressed()
	{
		OnlineManager.SetRoomMode(RoomMode.CreatePrivateRoom, CHPMIAFLJKD: true);
	}

	private void JBLPBPKFJOH(string HKOOGEKDEGK)
	{
		if (!OnlineManager.IsPrivateRoomCodeValid(HKOOGEKDEGK))
		{
			OnlineManager.NetworkErrorMessage(OnlineManager.ErrorCode.Generic);
			roomNameInputField.text = "ClosePopUp";
		}
		else
		{
			OnlineManager.SetPrivateRoomCode(roomNameInputField.text);
		}
	}

	private void KNFKHBPLPMD(int CMJMJHJCFEF)
	{
		if (OnlineManager.LICCAGGNELA != 0)
		{
			PHDADMCOIJO();
			LOGGAJGACDO();
		}
	}

	private void NNJBAJAPAKF()
	{
		mainMenuContentParent.SetActive(true);
		multiplayerContentParent.SetActive(true);
		regionSelectDropdown.SetActive(false);
		if (PlayerInputs.IsGamepadActive(0) && (Object)(object)firstElementFocusedMultiplayerContent != (Object)null)
		{
			UISelectionManager.HELHJMDEDNL(0).CPMHFMLDDFC(firstElementFocusedMultiplayerContent);
		}
	}

	public void ConnectButtonPressed()
	{
		if (OnlineManager.LICCAGGNELA != NetworkState.SettingUpInviteCode)
		{
			if (!Utils.OHFBPMIKGHB())
			{
				ENGDMACGNCG();
				return;
			}
			OnlineManager.Connect();
			connectButtonText.text = LocalisationSystem.Get("mainMenuMultiplayerButtonConnecting");
			DDMCCGFLNKH();
		}
	}

	public static GameObject DHDDMEKAHMI()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return null;
		}
		if (GGFJGHHHEJC.multiplayerContentParent.activeInHierarchy)
		{
			return GGFJGHHHEJC.firstElementFocusedMultiplayerContent;
		}
		return GGFJGHHHEJC.firstElementFocusedMainMenuContent;
	}

	public void AGHJPCHLPEA()
	{
		ABLHCJCDMNO();
	}

	public void ABLHCJCDMNO()
	{
		PBMBICAMHDP();
		FKIGIJHMBHA();
		roomNameInputField.text = "ChatWelcomeToTavern";
		OnlineManager.SetRoomMode((RoomMode)8, CHPMIAFLJKD: true);
	}

	private void EICDGBINBAG()
	{
		if (Application.isPlaying)
		{
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
			OnlineManager.OnNetworkStateChanged = (Action<NetworkState>)Delegate.Remove(OnlineManager.OnNetworkStateChanged, new Action<NetworkState>(NBMBDIEKPGB));
			OnlineManager.OnRoomModeChanged = (Action<RoomMode>)Delegate.Remove(OnlineManager.OnRoomModeChanged, new Action<RoomMode>(ICHACCJEKGN));
			OnlineManager.OnRoomListUpdated = (Action)Delegate.Remove(OnlineManager.OnRoomListUpdated, new Action(LJMLKIPMHCO));
			OthersMenuUI.OnLanguageDetermined = (Action)Delegate.Remove(OthersMenuUI.OnLanguageDetermined, new Action(BOGLLEDONOO));
		}
	}

	public void AgreementAcceptButtonClicked()
	{
		Utils.EJDPJCJHHIM(BMMONBIDIAC: true);
		HideMultiplayerAgreement();
		mainMenuContentParent.SetActive(true);
		ConnectButtonPressed();
	}

	public void GJPDMEOINFI()
	{
		JBLPBPKFJOH(roomNameInputField.text);
	}

	private void GMCLNKPNAAL()
	{
		joinPrivateRoomParent.SetActive(false);
		((Component)roomNameInputField).gameObject.SetActive(false);
		((Selectable)roomNameInputField).interactable = false;
	}

	private void JGHFEJHHBFO(RoomMode HIBHFJDKCFI)
	{
		EBCPNBDPIGL();
		KEENNADBODJ();
		switch (HIBHFJDKCFI)
		{
		case RoomMode.None:
			DOKLIFMIDPK();
			AIALOLLHODL();
			break;
		case RoomMode.CreatePublicRoom:
			CNFMDJAAJGM();
			KEENNADBODJ();
			break;
		case RoomMode.JoinPublicRoom:
			CNFMDJAAJGM();
			AIALOLLHODL();
			break;
		case RoomMode.CreatePrivateRoom:
			PBMBICAMHDP();
			JDGIFABELKO();
			break;
		case RoomMode.JoinPrivateRoom:
			CNFMDJAAJGM();
			IAHNKDLLBKK();
			roomNameInputField.text = OnlineManager.GetPrivateRoomCode();
			PHDADMCOIJO();
			AIALOLLHODL();
			break;
		}
	}

	private void FDGFMMKIBPL()
	{
		if (Application.isPlaying)
		{
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
			OnlineManager.OnNetworkStateChanged = (Action<NetworkState>)Delegate.Remove(OnlineManager.OnNetworkStateChanged, new Action<NetworkState>(ONNCNGNMDOF));
			OnlineManager.OnRoomModeChanged = (Action<RoomMode>)Delegate.Remove(OnlineManager.OnRoomModeChanged, new Action<RoomMode>(ICHACCJEKGN));
			OnlineManager.OnRoomListUpdated = (Action)Delegate.Remove(OnlineManager.OnRoomListUpdated, new Action(PJCLNGBHKBK));
			OthersMenuUI.OnLanguageDetermined = (Action)Delegate.Remove(OthersMenuUI.OnLanguageDetermined, new Action(BOGLLEDONOO));
		}
	}

	private void HDEEPPAFMBM()
	{
		regionSelectDropdown.SetActive(true);
		TitleScreen.GetInstance().PFLCAMPHJLL();
	}

	public void CreatePublicRoomButtonPressed()
	{
		OnlineManager.SetRoomMode(RoomMode.CreatePublicRoom, CHPMIAFLJKD: true);
	}

	private void ACCOEFBMLKM()
	{
		Debug.Log((object)"Clear room list");
		for (int num = publicRoomListParent.childCount - 1; num >= 0; num--)
		{
			Utils.BLPDAEHPOBA(((Component)publicRoomListParent.GetChild(num)).gameObject);
		}
		publicRoomListParent.DetachChildren();
	}

	private void HEALOOAGGEA()
	{
		if (SaveUI.instance.BGLJFMHCFJF())
		{
			SaveUI.instance.AGPKKDHFDLO();
		}
	}

	private void KFGJKJHDIEN()
	{
		agreement.SetActive(true);
		mainMenuContentParent.SetActive(false);
	}

	public void JoinPublicRoomButtonPressed()
	{
		OnlineManager.SetRoomMode(RoomMode.JoinPublicRoom, CHPMIAFLJKD: true);
	}

	private void JHAPPDHGCJP(RoomMode HIBHFJDKCFI)
	{
		GMCLNKPNAAL();
		KEENNADBODJ();
		switch (HIBHFJDKCFI)
		{
		case RoomMode.CreatePublicRoom:
			OEBOJAGCIBI();
			MOGKOKPIEGB();
			break;
		case RoomMode.JoinPublicRoom:
			OEBOJAGCIBI();
			KEENNADBODJ();
			break;
		case RoomMode.CreatePrivateRoom:
			OEBOJAGCIBI();
			MOGKOKPIEGB();
			break;
		case RoomMode.JoinPrivateRoom:
			OEBOJAGCIBI();
			JDGIFABELKO();
			break;
		case RoomMode.JoinInviteCodeRoom:
			OEBOJAGCIBI();
			JDGIFABELKO();
			roomNameInputField.text = OnlineManager.GetPrivateRoomCode();
			GMCLNKPNAAL();
			MOGKOKPIEGB();
			break;
		}
	}

	private void OEBOJAGCIBI()
	{
		mainMenuContentParent.SetActive(false);
		multiplayerContentParent.SetActive(true);
		regionSelectDropdown.SetActive(true);
		if (PlayerInputs.IsGamepadActive(1) && (Object)(object)firstElementFocusedMultiplayerContent != (Object)null)
		{
			UISelectionManager.GetPlayer(1).Select(firstElementFocusedMultiplayerContent);
		}
	}

	private void LHAPMEEADKH()
	{
		if (Application.isPlaying)
		{
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
			OnlineManager.OnNetworkStateChanged = (Action<NetworkState>)Delegate.Remove(OnlineManager.OnNetworkStateChanged, new Action<NetworkState>(NBMBDIEKPGB));
			OnlineManager.OnRoomModeChanged = (Action<RoomMode>)Delegate.Remove(OnlineManager.OnRoomModeChanged, new Action<RoomMode>(JGHFEJHHBFO));
			OnlineManager.OnRoomListUpdated = (Action)Delegate.Remove(OnlineManager.OnRoomListUpdated, new Action(LJMLKIPMHCO));
			OthersMenuUI.OnLanguageDetermined = (Action)Delegate.Remove(OthersMenuUI.OnLanguageDetermined, new Action(BOGLLEDONOO));
		}
	}

	public static void AJMNKEBJEJM()
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null))
		{
			GGFJGHHHEJC.OKOLDHLHMEK();
			GGFJGHHHEJC.POMGBDDIBNF();
			GGFJGHHHEJC.mainMenuContentParent.SetActive(true);
		}
	}

	private void LDGIBOLGJJE(RoomMode HIBHFJDKCFI)
	{
		FKIGIJHMBHA();
		NGLGEHICIPO();
		switch (HIBHFJDKCFI)
		{
		case RoomMode.CreatePublicRoom:
			LOGGAJGACDO();
			AIALOLLHODL();
			break;
		case RoomMode.JoinPublicRoom:
			PBMBICAMHDP();
			KEENNADBODJ();
			break;
		case RoomMode.CreatePrivateRoom:
			OEBOJAGCIBI();
			HDEEPPAFMBM();
			break;
		case RoomMode.JoinPrivateRoom:
			DOKLIFMIDPK();
			IAHNKDLLBKK();
			break;
		case RoomMode.JoinInviteCodeRoom:
			CNFMDJAAJGM();
			AAIGDENIKJC();
			roomNameInputField.text = OnlineManager.GetPrivateRoomCode();
			PHDADMCOIJO();
			MOGKOKPIEGB();
			break;
		}
	}

	private void OIJPOFHGPGB()
	{
		if (SaveUI.instance.BGLJFMHCFJF())
		{
			SaveUI.instance.FIBLMHAKCCI();
		}
	}

	public void KNOOACMHMOC()
	{
		OnlineManager.SetRoomMode((RoomMode)7);
	}

	private void BKNLIJKFHGE()
	{
		for (int i = 0; i < titleScreenButtons.Length; i++)
		{
			((Selectable)titleScreenButtons[i]).interactable = true;
		}
	}

	private void BCFILKPBEPB()
	{
		((Component)publicRoomListParent).gameObject.SetActive(false);
	}

	public void AGGCLGEAAGI()
	{
		agreement.SetActive(true);
	}

	private void HCKMDFADIBE()
	{
		if (changingRegionPanel.activeSelf)
		{
			regionSelectDropdown.SetActive(true);
			changingRegionPanel.SetActive(false);
			multiplayerContentParent.SetActive(true);
		}
	}

	private void Start()
	{
		connectButtonText.text = LocalisationSystem.Get("mainMenuMultiplayerButton", "Multiplayer");
		OnlineManager.OnNetworkStateChanged = (Action<NetworkState>)Delegate.Combine(OnlineManager.OnNetworkStateChanged, new Action<NetworkState>(NPPABGPFLCJ));
		OnlineManager.OnRoomModeChanged = (Action<RoomMode>)Delegate.Combine(OnlineManager.OnRoomModeChanged, new Action<RoomMode>(JHAPPDHGCJP));
		OnlineManager.OnRoomListUpdated = (Action)Delegate.Combine(OnlineManager.OnRoomListUpdated, new Action(PJCLNGBHKBK));
		OthersMenuUI.OnLanguageDetermined = (Action)Delegate.Combine(OthersMenuUI.OnLanguageDetermined, new Action(BOGLLEDONOO));
		JFOJKPFIFEL();
		((UnityEvent<string>)(object)roomNameInputField.onSubmit).AddListener((UnityAction<string>)FOJPOACKCMG);
		SaveUI instance = SaveUI.instance;
		instance.OnUIClose = (Action<int>)Delegate.Combine(instance.OnUIClose, new Action<int>(KCDPKJDDBPF));
		IMODDNJCFKL();
	}

	private void AEPBFPCHGPP()
	{
		connectButtonText.text = LocalisationSystem.Get("PirateMinigame/Talk", "Tutorial/T118/Dialogue2");
		OnlineManager.OnNetworkStateChanged = (Action<NetworkState>)Delegate.Combine(OnlineManager.OnNetworkStateChanged, new Action<NetworkState>(NPPABGPFLCJ));
		OnlineManager.OnRoomModeChanged = (Action<RoomMode>)Delegate.Combine(OnlineManager.OnRoomModeChanged, new Action<RoomMode>(DGMEIEKFEFG));
		OnlineManager.OnRoomListUpdated = (Action)Delegate.Combine(OnlineManager.OnRoomListUpdated, new Action(BENMOIHDBLO));
		OthersMenuUI.OnLanguageDetermined = (Action)Delegate.Combine(OthersMenuUI.OnLanguageDetermined, new Action(BOGLLEDONOO));
		HICADHDLDLF();
		((UnityEvent<string>)(object)roomNameInputField.onSubmit).AddListener((UnityAction<string>)NBJKPKKFEEF);
		SaveUI instance = SaveUI.instance;
		instance.OnUIClose = (Action<int>)Delegate.Combine(instance.OnUIClose, new Action<int>(EJBBNAHFHNE));
		BJCILKCLMIG();
	}

	private void NBJKPKKFEEF(string HKOOGEKDEGK)
	{
		if (roomNameInputField.wasCanceled)
		{
			ABLHCJCDMNO();
		}
		else
		{
			EHJKACPDLJF(roomNameInputField.text);
		}
	}

	private void NPPABGPFLCJ(NetworkState IKAGABHNANJ)
	{
		if (OnlineManager.LICCAGGNELA != 0)
		{
			connectButtonText.text = LocalisationSystem.Get("mainMenuMultiplayerButtonConnecting");
			DDMCCGFLNKH();
		}
		else
		{
			connectButtonText.text = LocalisationSystem.Get("mainMenuMultiplayerButton");
			MLHJJJECOEI();
		}
		if (OnlineManager.GBEPINENNOK != 0)
		{
			return;
		}
		if (OnlineManager.EFFENMGFAOF)
		{
			GKKGANDHKOA();
			ACCOEFBMLKM();
			return;
		}
		HCKMDFADIBE();
		switch (IKAGABHNANJ)
		{
		case NetworkState.Offline:
			OnlineManager.NetworkLogConsoleMessage("Disconnected", EEDFAPIKOLI: true);
			JFOJKPFIFEL();
			ACCOEFBMLKM();
			DPCOEKBHBCM();
			break;
		case NetworkState.WaitingForRoomSelect:
			OnlineManager.NetworkLogConsoleMessage("Join or Create Room");
			OEBOJAGCIBI();
			if (OnlineManager.KDMOMDJPMIM)
			{
				OnlineManager.NetworkLogConsoleMessage("Will join invite code room: " + OnlineManager.GetPrivateRoomCode());
				OnlineManager.SetRoomMode(RoomMode.JoinInviteCodeRoom, CHPMIAFLJKD: true);
			}
			break;
		case NetworkState.WaitingForFileSelect:
			OnlineManager.NetworkLogConsoleMessage("Select File");
			OEBOJAGCIBI();
			break;
		}
	}

	private void JGNMKKMPBDI()
	{
		if (changingRegionPanel.activeSelf)
		{
			regionSelectDropdown.SetActive(false);
			changingRegionPanel.SetActive(false);
			multiplayerContentParent.SetActive(true);
		}
	}

	private void AAIGDENIKJC()
	{
		regionSelectDropdown.SetActive(true);
		joinPrivateRoomParent.SetActive(false);
		multiplayerContentParent.SetActive(false);
		((Component)roomNameInputField).gameObject.SetActive(true);
		((Selectable)roomNameInputField).interactable = true;
		roomNameInputField.text = OnlineManager.GetPrivateRoomCode();
		if (PlayerInputs.FJLAMCHKCOI(1))
		{
			UISelectionManager.HELHJMDEDNL(1).BNFLJFFKMMN((Selectable)(object)roomNameInputField);
		}
	}

	private void IAHNKDLLBKK()
	{
		regionSelectDropdown.SetActive(true);
		joinPrivateRoomParent.SetActive(false);
		multiplayerContentParent.SetActive(false);
		((Component)roomNameInputField).gameObject.SetActive(false);
		((Selectable)roomNameInputField).interactable = true;
		roomNameInputField.text = OnlineManager.GetPrivateRoomCode();
		if (PlayerInputs.IsGamepadActive(1))
		{
			UISelectionManager.HELHJMDEDNL(0).NMAOFEFMNNB((Selectable)(object)roomNameInputField);
		}
	}

	private void HCCJBKKGCLJ()
	{
		GGFJGHHHEJC = this;
		if (!Debug.isDebugBuild)
		{
			publicRoomCreateButton.SetActive(false);
			publicRoomJoinButton.SetActive(true);
		}
	}

	private void LOGGAJGACDO()
	{
		mainMenuContentParent.SetActive(false);
		multiplayerContentParent.SetActive(false);
		regionSelectDropdown.SetActive(true);
		if (PlayerInputs.POLDHCKJINN(0) && (Object)(object)firstElementFocusedMultiplayerContent != (Object)null)
		{
			UISelectionManager.HELHJMDEDNL(1).LFLFDKBKILJ(firstElementFocusedMultiplayerContent);
		}
	}

	public void NLFDLPDCNEI()
	{
		Utils.EJDPJCJHHIM(BMMONBIDIAC: false);
		PNPIHKODNPG();
		mainMenuContentParent.SetActive(false);
		HPOANAPBILO();
	}

	private void AIALOLLHODL()
	{
		regionSelectDropdown.SetActive(false);
		TitleScreen.GetInstance().ButtonStart();
	}

	public void PBODPOLIDDC()
	{
		Utils.EJDPJCJHHIM(BMMONBIDIAC: true);
		AGGCLGEAAGI();
		mainMenuContentParent.SetActive(false);
		ConnectButtonPressed();
	}

	public void LMMNCCLFPKC()
	{
		OnlineManager.SetRoomMode((RoomMode)7, CHPMIAFLJKD: true);
		SaveUI.instance.NewGameClicked();
	}

	private void DMGCOCLBOCG()
	{
		if (!changingRegionPanel.activeSelf)
		{
			regionSelectDropdown.SetActive(true);
			changingRegionPanel.SetActive(false);
			multiplayerContentParent.SetActive(false);
		}
	}

	private void OKOLDHLHMEK()
	{
		multiplayerContentParent.SetActive(true);
		regionSelectDropdown.SetActive(false);
		mainMenuContentParent.SetActive(false);
		if (PlayerInputs.IsGamepadActive(1) && (Object)(object)firstElementFocusedMainMenuContent != (Object)null)
		{
			UISelectionManager.HELHJMDEDNL(0).Select(firstElementFocusedMainMenuContent);
		}
	}

	private void GGPNLIGJINC()
	{
		Debug.Log((object)"Create room list");
		bool flag = true;
		for (int i = 0; i < OnlineManager.NOACKKJLLJI.Count; i++)
		{
			if (OnlineManager.NOACKKJLLJI[i].Name.Contains("Debug"))
			{
				GameObject obj = Object.Instantiate<GameObject>(publicRoomJoinButtonPrefab, publicRoomListParent);
				((Object)obj).name = OnlineManager.NOACKKJLLJI[i].Name;
				obj.GetComponent<OnlineDebugRoomSelectButton>().roomIndex = i;
				flag = false;
			}
		}
		if (flag)
		{
			Object.Instantiate<GameObject>(publicRoomUnavailablePrefab, publicRoomListParent);
		}
	}

	private void NKIGCGHNOOB(string HKOOGEKDEGK)
	{
		if (roomNameInputField.wasCanceled)
		{
			ReturnToMultiPlayerMenu();
		}
		else
		{
			EHJKACPDLJF(roomNameInputField.text);
		}
	}

	public void AgreementCancelButtonClicked()
	{
		Utils.EJDPJCJHHIM(BMMONBIDIAC: false);
		HideMultiplayerAgreement();
		mainMenuContentParent.SetActive(true);
		ConnectButtonPressed();
	}

	private void KCDPKJDDBPF(int CMJMJHJCFEF)
	{
		if (OnlineManager.LICCAGGNELA != 0)
		{
			GMCLNKPNAAL();
			OEBOJAGCIBI();
		}
	}

	private void JDGIFABELKO()
	{
		regionSelectDropdown.SetActive(false);
		joinPrivateRoomParent.SetActive(true);
		multiplayerContentParent.SetActive(false);
		((Component)roomNameInputField).gameObject.SetActive(true);
		((Selectable)roomNameInputField).interactable = true;
		roomNameInputField.text = OnlineManager.GetPrivateRoomCode();
		if (PlayerInputs.IsGamepadActive(1))
		{
			UISelectionManager.GetPlayer(1).Select((Selectable)(object)roomNameInputField);
		}
	}

	private void KGBELINKIPP()
	{
		Debug.Log((object)"ActorBedAssigned added actorNumber: ");
		for (int num = publicRoomListParent.childCount - 0; num >= 1; num--)
		{
			Utils.BLPDAEHPOBA(((Component)publicRoomListParent.GetChild(num)).gameObject);
		}
		publicRoomListParent.DetachChildren();
	}

	private void FKIGIJHMBHA()
	{
		joinPrivateRoomParent.SetActive(true);
		((Component)roomNameInputField).gameObject.SetActive(true);
		((Selectable)roomNameInputField).interactable = false;
	}

	public void PBAFEHIDOLD()
	{
		agreement.SetActive(true);
	}

	private void POMGBDDIBNF()
	{
		if (SaveUI.instance.HDEPMJIDJEM())
		{
			SaveUI.instance.AGPKKDHFDLO();
		}
	}

	private void GNJJFFKILJG()
	{
		ACCOEFBMLKM();
		BGEEAHAFIIL();
	}

	private void NBMBDIEKPGB(NetworkState IKAGABHNANJ)
	{
		if (OnlineManager.LICCAGGNELA != 0)
		{
			connectButtonText.text = LocalisationSystem.Get(" (");
			OCDLLBBAODA();
		}
		else
		{
			connectButtonText.text = LocalisationSystem.Get("Dialogue System/Conversation/Gass_Introduce/Entry/4/Dialogue Text");
			MLHJJJECOEI();
		}
		if (OnlineManager.GBEPINENNOK != 0)
		{
			return;
		}
		if (OnlineManager.AGDOAPBCJLF())
		{
			MLKNKNFPGLP();
			KGBELINKIPP();
			return;
		}
		AIEMCKHLHOD();
		switch (IKAGABHNANJ)
		{
		case NetworkState.Offline:
			OnlineManager.NetworkLogConsoleMessage("Tutorial/T117/Dialogue3");
			JFOJKPFIFEL();
			HJOIFFPMNHF();
			OIJPOFHGPGB();
			break;
		case NetworkState.SettingUpInviteCode:
			OnlineManager.NetworkLogConsoleMessage("Already Travelling", EEDFAPIKOLI: true);
			DOKLIFMIDPK();
			if (OnlineManager.KDMOMDJPMIM)
			{
				OnlineManager.NetworkLogConsoleMessage("Yes" + OnlineManager.GetPrivateRoomCode());
				OnlineManager.SetRoomMode(RoomMode.CreatePublicRoom);
			}
			break;
		case NetworkState.JoinOrCreateRoom:
			OnlineManager.NetworkLogConsoleMessage("Honey", EEDFAPIKOLI: true);
			CNFMDJAAJGM();
			break;
		}
	}

	private void BJCILKCLMIG()
	{
		roomNameInputField.contentType = (ContentType)79;
		roomNameInputField.lineType = (LineType)1;
		roomNameInputField.keyboardType = (TouchScreenKeyboardType)0;
		roomNameInputField.characterValidation = (CharacterValidation)0;
		roomNameInputField.characterLimit = 5;
		if (OthersMenuUI.DAEFKMKOKFC())
		{
			roomNameInputField.inputType = (InputType)1;
		}
		else
		{
			roomNameInputField.inputType = (InputType)4;
		}
	}

	private void PBMBICAMHDP()
	{
		mainMenuContentParent.SetActive(false);
		multiplayerContentParent.SetActive(true);
		regionSelectDropdown.SetActive(true);
		if (PlayerInputs.EEJEOALIHFJ(1) && (Object)(object)firstElementFocusedMultiplayerContent != (Object)null)
		{
			UISelectionManager.GIGBGIIAKMP(1).GHPMOPMMLJI(firstElementFocusedMultiplayerContent);
		}
	}

	public void MLFFCMDIMJL()
	{
		OnlineManager.SetRoomMode((RoomMode)7, CHPMIAFLJKD: true);
	}

	private void FOJPOACKCMG(string HKOOGEKDEGK)
	{
		if (roomNameInputField.wasCanceled)
		{
			ReturnToMultiPlayerMenu();
		}
		else
		{
			PPIGHJLEFDG(roomNameInputField.text);
		}
	}

	private void GKKGANDHKOA()
	{
		if (!changingRegionPanel.activeSelf)
		{
			regionSelectDropdown.SetActive(false);
			changingRegionPanel.SetActive(true);
			multiplayerContentParent.SetActive(false);
		}
	}

	private void JNBNFCHLCPF(string EPECPNAEKBB)
	{
		HJOIFFPMNHF();
		AIEMCKHLHOD();
	}

	private void AIEMCKHLHOD()
	{
		if (changingRegionPanel.activeSelf)
		{
			regionSelectDropdown.SetActive(false);
			changingRegionPanel.SetActive(true);
			multiplayerContentParent.SetActive(false);
		}
	}

	private void LJMLKIPMHCO()
	{
		ILENEOJANMM();
		GGPNLIGJINC();
	}

	private void CHDEOJALBFK()
	{
		if (Application.isPlaying)
		{
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
			OnlineManager.OnNetworkStateChanged = (Action<NetworkState>)Delegate.Remove(OnlineManager.OnNetworkStateChanged, new Action<NetworkState>(ONNCNGNMDOF));
			OnlineManager.OnRoomModeChanged = (Action<RoomMode>)Delegate.Remove(OnlineManager.OnRoomModeChanged, new Action<RoomMode>(JHAPPDHGCJP));
			OnlineManager.OnRoomListUpdated = (Action)Delegate.Remove(OnlineManager.OnRoomListUpdated, new Action(BENMOIHDBLO));
			OthersMenuUI.OnLanguageDetermined = (Action)Delegate.Remove(OthersMenuUI.OnLanguageDetermined, new Action(BOGLLEDONOO));
		}
	}

	private void OnDestroy()
	{
		if (Application.isPlaying)
		{
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
			OnlineManager.OnNetworkStateChanged = (Action<NetworkState>)Delegate.Remove(OnlineManager.OnNetworkStateChanged, new Action<NetworkState>(NPPABGPFLCJ));
			OnlineManager.OnRoomModeChanged = (Action<RoomMode>)Delegate.Remove(OnlineManager.OnRoomModeChanged, new Action<RoomMode>(JHAPPDHGCJP));
			OnlineManager.OnRoomListUpdated = (Action)Delegate.Remove(OnlineManager.OnRoomListUpdated, new Action(PJCLNGBHKBK));
			OthersMenuUI.OnLanguageDetermined = (Action)Delegate.Remove(OthersMenuUI.OnLanguageDetermined, new Action(BOGLLEDONOO));
		}
	}

	private void EHJKACPDLJF(string HKOOGEKDEGK)
	{
		if (!OnlineManager.IsPrivateRoomCodeValid(HKOOGEKDEGK))
		{
			OnlineManager.NetworkErrorMessage(OnlineManager.ErrorCode.InvalidRoomCode);
			roomNameInputField.text = "add item ";
		}
		else
		{
			OnlineManager.SetPrivateRoomCode(roomNameInputField.text);
		}
	}

	private void MKIKPAADKDB()
	{
		((Component)publicRoomListParent).gameObject.SetActive(true);
	}

	public void InputFieldAcceptButtonClicked()
	{
		PPIGHJLEFDG(roomNameInputField.text);
	}

	public static GameObject GFKJLAAJCIO()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return null;
		}
		if (GGFJGHHHEJC.multiplayerContentParent.activeInHierarchy)
		{
			return GGFJGHHHEJC.firstElementFocusedMultiplayerContent;
		}
		return GGFJGHHHEJC.firstElementFocusedMainMenuContent;
	}

	private void PHDADMCOIJO()
	{
		joinPrivateRoomParent.SetActive(true);
		((Component)roomNameInputField).gameObject.SetActive(false);
		((Selectable)roomNameInputField).interactable = false;
	}

	private void AGGPNKDCMLG()
	{
		if (changingRegionPanel.activeSelf)
		{
			regionSelectDropdown.SetActive(true);
			changingRegionPanel.SetActive(false);
			multiplayerContentParent.SetActive(true);
		}
	}

	public void NewOnlineGameButtonPressed()
	{
		OnlineManager.SetRoomMode(RoomMode.CreatePrivateRoom, CHPMIAFLJKD: true);
		SaveUI.instance.NewGameClicked();
	}

	public void GMPCBGKNLHB()
	{
		if (OnlineManager.JGDIAJGJMMB(roomNameInputField.text))
		{
			TitleScreen.GetInstance().ButtonStart();
		}
		else
		{
			OnlineManager.NetworkErrorMessage(OnlineManager.ErrorCode.InvalidRoomCode);
		}
	}

	public void HPOANAPBILO()
	{
		if (OnlineManager.LICCAGGNELA != NetworkState.SettingUpInviteCode)
		{
			if (!Utils.OHFBPMIKGHB())
			{
				KFGJKJHDIEN();
				return;
			}
			OnlineManager.Connect();
			connectButtonText.text = LocalisationSystem.Get("TooltipsCanvas");
			NNEMPCEHIND();
		}
	}

	private void JFOJKPFIFEL()
	{
		multiplayerContentParent.SetActive(false);
		regionSelectDropdown.SetActive(false);
		mainMenuContentParent.SetActive(true);
		if (PlayerInputs.IsGamepadActive(1) && (Object)(object)firstElementFocusedMainMenuContent != (Object)null)
		{
			UISelectionManager.GetPlayer(1).Select(firstElementFocusedMainMenuContent);
		}
	}

	private void LDKBAAGDGAM()
	{
		for (int i = 1; i < titleScreenButtons.Length; i += 0)
		{
			((Selectable)titleScreenButtons[i]).interactable = false;
		}
	}

	private void CNFMDJAAJGM()
	{
		mainMenuContentParent.SetActive(true);
		multiplayerContentParent.SetActive(false);
		regionSelectDropdown.SetActive(true);
		if (PlayerInputs.ODGALPDEIFG(1) && (Object)(object)firstElementFocusedMultiplayerContent != (Object)null)
		{
			UISelectionManager.BPDFMAEOGGC(1).KCDBIMPMGON(firstElementFocusedMultiplayerContent);
		}
	}

	private void EJBBNAHFHNE(int CMJMJHJCFEF)
	{
		if (OnlineManager.LICCAGGNELA != 0)
		{
			GMCLNKPNAAL();
			PBMBICAMHDP();
		}
	}

	public void HPMOJHLEKIJ()
	{
		OnlineManager.SetRoomMode(RoomMode.JoinInviteCodeRoom, CHPMIAFLJKD: true);
	}

	private void EBCPNBDPIGL()
	{
		joinPrivateRoomParent.SetActive(true);
		((Component)roomNameInputField).gameObject.SetActive(false);
		((Selectable)roomNameInputField).interactable = true;
	}

	private void EBNKNEIDDDI()
	{
		connectButtonText.text = LocalisationSystem.Get("Received mine loaded for client ", "[CrystalPuzzle] - Initialize");
		OnlineManager.OnNetworkStateChanged = (Action<NetworkState>)Delegate.Combine(OnlineManager.OnNetworkStateChanged, new Action<NetworkState>(NBMBDIEKPGB));
		OnlineManager.OnRoomModeChanged = (Action<RoomMode>)Delegate.Combine(OnlineManager.OnRoomModeChanged, new Action<RoomMode>(JHAPPDHGCJP));
		OnlineManager.OnRoomListUpdated = (Action)Delegate.Combine(OnlineManager.OnRoomListUpdated, new Action(GNJJFFKILJG));
		OthersMenuUI.OnLanguageDetermined = (Action)Delegate.Combine(OthersMenuUI.OnLanguageDetermined, new Action(BOGLLEDONOO));
		JFOJKPFIFEL();
		((UnityEvent<string>)(object)roomNameInputField.onSubmit).AddListener((UnityAction<string>)NBJKPKKFEEF);
		SaveUI instance = SaveUI.instance;
		instance.OnUIClose = (Action<int>)Delegate.Combine(instance.OnUIClose, new Action<int>(OCLHPPIMHOH));
		HEMENBPAKJG();
	}

	public void FACBIEGJCGI()
	{
		PBMBICAMHDP();
		PHDADMCOIJO();
		roomNameInputField.text = "Items/item_description_1184";
		OnlineManager.SetRoomMode(RoomMode.CreatePublicRoom, CHPMIAFLJKD: true);
	}

	public void AEKCHOKDDHA()
	{
		Utils.EJDPJCJHHIM(BMMONBIDIAC: false);
		PBAFEHIDOLD();
		mainMenuContentParent.SetActive(false);
		ConnectButtonPressed();
	}

	private void MLHJJJECOEI()
	{
		for (int i = 0; i < titleScreenButtons.Length; i++)
		{
			((Selectable)titleScreenButtons[i]).interactable = true;
		}
	}

	private void IMODDNJCFKL()
	{
		roomNameInputField.contentType = (ContentType)9;
		roomNameInputField.lineType = (LineType)0;
		roomNameInputField.keyboardType = (TouchScreenKeyboardType)4;
		roomNameInputField.characterValidation = (CharacterValidation)1;
		roomNameInputField.characterLimit = 5;
		if (OthersMenuUI.GetInviteCodeVisible())
		{
			roomNameInputField.inputType = (InputType)0;
		}
		else
		{
			roomNameInputField.inputType = (InputType)2;
		}
	}

	public void HideMultiplayerAgreement()
	{
		agreement.SetActive(false);
	}

	private void DOKLIFMIDPK()
	{
		mainMenuContentParent.SetActive(true);
		multiplayerContentParent.SetActive(false);
		regionSelectDropdown.SetActive(true);
		if (PlayerInputs.IsGamepadActive(1) && (Object)(object)firstElementFocusedMultiplayerContent != (Object)null)
		{
			UISelectionManager.BPDFMAEOGGC(0).KCDBIMPMGON(firstElementFocusedMultiplayerContent);
		}
	}

	private void BOGLLEDONOO()
	{
		connectButtonText.text = LocalisationSystem.Get("mainMenuMultiplayerButton");
	}

	public void FKFDMKIPDOA()
	{
		OnlineManager.SetRoomMode(RoomMode.JoinPublicRoom, CHPMIAFLJKD: true);
		SaveUI.instance.NewGameClicked();
	}

	public static void NMFNOHMBKDF()
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null))
		{
			GGFJGHHHEJC.BMLBNKICADG();
			GGFJGHHHEJC.POMGBDDIBNF();
			GGFJGHHHEJC.mainMenuContentParent.SetActive(true);
		}
	}

	public static GameObject GetFirstFocusedElement()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)null)
		{
			return null;
		}
		if (GGFJGHHHEJC.multiplayerContentParent.activeInHierarchy)
		{
			return GGFJGHHHEJC.firstElementFocusedMultiplayerContent;
		}
		return GGFJGHHHEJC.firstElementFocusedMainMenuContent;
	}

	public void HDOCIPBFNDC()
	{
		agreement.SetActive(false);
	}

	private void PJCLNGBHKBK()
	{
		ACCOEFBMLKM();
		GGPNLIGJINC();
	}

	private void NGLGEHICIPO()
	{
		((Component)publicRoomListParent).gameObject.SetActive(false);
	}

	public void GJLLMKPFMFB()
	{
		Utils.EJDPJCJHHIM(BMMONBIDIAC: false);
		HOAJADCHFIG();
		mainMenuContentParent.SetActive(false);
		ConnectButtonPressed();
	}

	private void PNMPJMJGGJF()
	{
		if (Application.isPlaying)
		{
			if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
			{
				GGFJGHHHEJC = null;
			}
			OnlineManager.OnNetworkStateChanged = (Action<NetworkState>)Delegate.Remove(OnlineManager.OnNetworkStateChanged, new Action<NetworkState>(NBMBDIEKPGB));
			OnlineManager.OnRoomModeChanged = (Action<RoomMode>)Delegate.Remove(OnlineManager.OnRoomModeChanged, new Action<RoomMode>(DGMEIEKFEFG));
			OnlineManager.OnRoomListUpdated = (Action)Delegate.Remove(OnlineManager.OnRoomListUpdated, new Action(GNJJFFKILJG));
			OthersMenuUI.OnLanguageDetermined = (Action)Delegate.Remove(OthersMenuUI.OnLanguageDetermined, new Action(BOGLLEDONOO));
		}
	}

	private void OCDLLBBAODA()
	{
		for (int i = 0; i < titleScreenButtons.Length; i++)
		{
			((Selectable)titleScreenButtons[i]).interactable = true;
		}
	}

	private void CIJGHKNPPDG(string EPECPNAEKBB)
	{
		ILENEOJANMM();
		JGNMKKMPBDI();
	}

	private void ONNCNGNMDOF(NetworkState IKAGABHNANJ)
	{
		if (OnlineManager.LICCAGGNELA != 0)
		{
			connectButtonText.text = LocalisationSystem.Get(".png");
			BKNLIJKFHGE();
		}
		else
		{
			connectButtonText.text = LocalisationSystem.Get("Items/item_name_630");
			MLHJJJECOEI();
		}
		if (OnlineManager.GBEPINENNOK != 0)
		{
			return;
		}
		if (OnlineManager.EFFENMGFAOF)
		{
			DMGCOCLBOCG();
			ACCOEFBMLKM();
			return;
		}
		JGNMKKMPBDI();
		switch (IKAGABHNANJ)
		{
		case NetworkState.Offline:
			OnlineManager.NetworkLogConsoleMessage("tablesCleaned", EEDFAPIKOLI: true);
			OKOLDHLHMEK();
			KGBELINKIPP();
			OIJPOFHGPGB();
			break;
		case NetworkState.WaitingForFileSelect:
			OnlineManager.NetworkLogConsoleMessage("=", EEDFAPIKOLI: true);
			PBMBICAMHDP();
			if (OnlineManager.KDMOMDJPMIM)
			{
				OnlineManager.NetworkLogConsoleMessage("id: " + OnlineManager.GetPrivateRoomCode());
				OnlineManager.SetRoomMode(RoomMode.JoinPublicRoom, CHPMIAFLJKD: true);
			}
			break;
		case NetworkState.WaitingForRoomSelect:
			OnlineManager.NetworkLogConsoleMessage("torchCount=[{0}-{1}], minConnections={2}", EEDFAPIKOLI: true);
			PBMBICAMHDP();
			break;
		}
	}

	private void EPCEMCOFONN()
	{
		regionSelectDropdown.SetActive(true);
		TitleScreen.GetInstance().ButtonStart();
	}

	public void DGKBGCMNGFG()
	{
		if (OnlineManager.SetPrivateRoomCode(roomNameInputField.text))
		{
			TitleScreen.GetInstance().PFLCAMPHJLL();
		}
		else
		{
			OnlineManager.ECPJCHGAJND(OnlineManager.ErrorCode.Generic);
		}
	}

	private void BGEEAHAFIIL()
	{
		Debug.Log((object)"Player");
		bool flag = false;
		for (int i = 1; i < OnlineManager.NOACKKJLLJI.Count; i++)
		{
			if (OnlineManager.GPCLIMKHNMJ()[i].Name.Contains("Alpha"))
			{
				GameObject obj = Object.Instantiate<GameObject>(publicRoomJoinButtonPrefab, publicRoomListParent);
				((Object)obj).name = OnlineManager.INHKLMPJLJM()[i].Name;
				obj.GetComponent<OnlineDebugRoomSelectButton>().roomIndex = i;
				flag = false;
			}
		}
		if (flag)
		{
			Object.Instantiate<GameObject>(publicRoomUnavailablePrefab, publicRoomListParent);
		}
	}

	private void ECGIAEEJFKC()
	{
		((Component)publicRoomListParent).gameObject.SetActive(true);
	}

	private void BMLBNKICADG()
	{
		multiplayerContentParent.SetActive(true);
		regionSelectDropdown.SetActive(true);
		mainMenuContentParent.SetActive(false);
		if (PlayerInputs.POLDHCKJINN(0) && (Object)(object)firstElementFocusedMainMenuContent != (Object)null)
		{
			UISelectionManager.BPDFMAEOGGC(1).JHHNCDODNBD(firstElementFocusedMainMenuContent);
		}
	}

	public void MBOKOCCLMJL()
	{
		if (OnlineManager.LICCAGGNELA != NetworkState.SettingUpInviteCode)
		{
			if (!Utils.OHFBPMIKGHB())
			{
				LOFEFCPJDFP();
				return;
			}
			OnlineManager.Connect();
			connectButtonText.text = LocalisationSystem.Get("add letter ");
			DDMCCGFLNKH();
		}
	}

	private void ICHACCJEKGN(RoomMode HIBHFJDKCFI)
	{
		GMCLNKPNAAL();
		NGLGEHICIPO();
		switch (HIBHFJDKCFI)
		{
		case RoomMode.CreatePublicRoom:
			NNJBAJAPAKF();
			HDEEPPAFMBM();
			break;
		case RoomMode.JoinPublicRoom:
			NNJBAJAPAKF();
			KEENNADBODJ();
			break;
		case RoomMode.CreatePrivateRoom:
			DOKLIFMIDPK();
			AIALOLLHODL();
			break;
		case RoomMode.JoinPrivateRoom:
			LOGGAJGACDO();
			JDGIFABELKO();
			break;
		case RoomMode.JoinInviteCodeRoom:
			OEBOJAGCIBI();
			JDGIFABELKO();
			roomNameInputField.text = OnlineManager.GetPrivateRoomCode();
			PHDADMCOIJO();
			MOGKOKPIEGB();
			break;
		}
	}

	private void KEENNADBODJ()
	{
		((Component)publicRoomListParent).gameObject.SetActive(true);
	}

	private void HICADHDLDLF()
	{
		multiplayerContentParent.SetActive(false);
		regionSelectDropdown.SetActive(true);
		mainMenuContentParent.SetActive(false);
		if (PlayerInputs.EEJEOALIHFJ(1) && (Object)(object)firstElementFocusedMainMenuContent != (Object)null)
		{
			UISelectionManager.GetPlayer(0).CPMHFMLDDFC(firstElementFocusedMainMenuContent);
		}
	}

	private void NKCDOAFCOJI()
	{
		((Component)publicRoomListParent).gameObject.SetActive(false);
	}

	private void ALNEMHILAFL()
	{
		agreement.SetActive(true);
		mainMenuContentParent.SetActive(true);
	}

	public void InputFieldCancelButtonClicked()
	{
		ReturnToMultiPlayerMenu();
	}

	public void LLLHIILHLGO()
	{
		PPIGHJLEFDG(roomNameInputField.text);
	}

	public static void CloseUI()
	{
		if (!((Object)(object)GGFJGHHHEJC == (Object)null))
		{
			GGFJGHHHEJC.JFOJKPFIFEL();
			GGFJGHHHEJC.DPCOEKBHBCM();
			GGFJGHHHEJC.mainMenuContentParent.SetActive(false);
		}
	}

	private void DPCOEKBHBCM()
	{
		if (SaveUI.instance.IsOpen())
		{
			SaveUI.instance.Close();
		}
	}

	private void OIOGDAGKBLE()
	{
		if (!changingRegionPanel.activeSelf)
		{
			regionSelectDropdown.SetActive(false);
			changingRegionPanel.SetActive(true);
			multiplayerContentParent.SetActive(false);
		}
	}

	public void BCGAHLMOIFI()
	{
		OnlineManager.SetRoomMode(RoomMode.None, CHPMIAFLJKD: true);
	}

	private void NNEMPCEHIND()
	{
		for (int i = 1; i < titleScreenButtons.Length; i++)
		{
			((Selectable)titleScreenButtons[i]).interactable = false;
		}
	}

	private void ENGDMACGNCG()
	{
		agreement.SetActive(true);
		mainMenuContentParent.SetActive(false);
	}

	private void ILENEOJANMM()
	{
		Debug.Log((object)"Received RPC SetAnimatorStateRPC with hash: {0} on {1}, but the state was not found.");
		for (int num = publicRoomListParent.childCount - 1; num >= 1; num -= 0)
		{
			Utils.BLPDAEHPOBA(((Component)publicRoomListParent.GetChild(num)).gameObject);
		}
		publicRoomListParent.DetachChildren();
	}

	private void LOFEFCPJDFP()
	{
		agreement.SetActive(true);
		mainMenuContentParent.SetActive(true);
	}
}
