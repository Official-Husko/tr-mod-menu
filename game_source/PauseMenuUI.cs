using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenuUI : UIWindow, ISingleton
{
	[CompilerGenerated]
	private sealed class OMIKDFGPGAJ : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public OMIKDFGPGAJ(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				if (OnlineManager.PlayingOnline())
				{
					OnlineManager.SendReturningToMainMenu();
					_003C_003E2__current = CommonReferences.waitRealtime1;
					_003C_003E1__state = 1;
					return true;
				}
				break;
			case 1:
				_003C_003E1__state = -1;
				OnlineManager.Disconnect();
				break;
			}
			if (!Application.isEditor)
			{
				Process.GetCurrentProcess().Kill();
			}
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}
	}

	[CompilerGenerated]
	private sealed class HAKPEHKNLDP : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private float _003CstartTime_003E5__2;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public HAKPEHKNLDP(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0109: Unknown result type (might be due to invalid IL or missing references)
			//IL_010e: Unknown result type (might be due to invalid IL or missing references)
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				GameManager.leavingTheGame = true;
				CommonReferences.GGFJGHHHEJC.tilemapsInfo.ANOMBEOPINN(Location.Tavern, 1);
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				if (OnlineManager.PlayingOnline())
				{
					OnlineManager.SendReturningToMainMenu();
					_003C_003E2__current = CommonReferences.waitRealtime1;
					_003C_003E1__state = 2;
					return true;
				}
				break;
			case 2:
				_003C_003E1__state = -1;
				OnlineManager.Disconnect();
				_003CstartTime_003E5__2 = Time.realtimeSinceStartup;
				goto IL_00a4;
			case 3:
				{
					_003C_003E1__state = -1;
					goto IL_00a4;
				}
				IL_00a4:
				if (OnlineManager.PlayingOnline() && Time.realtimeSinceStartup - _003CstartTime_003E5__2 < 5f)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 3;
					return true;
				}
				break;
			}
			if ((Object)(object)GameManager.GGFJGHHHEJC.player2Instantiated != (Object)null)
			{
				GameManager.GGFJGHHHEJC.DeactivatePlayer2();
			}
			OnBeforeSceneReload?.Invoke();
			Time.timeScale = 1f;
			Sound.GGFJGHHHEJC.UnmuteLoops();
			GameManager.isLoading = true;
			Scene sceneByName = SceneManager.GetSceneByName("Inicio");
			if (((Scene)(ref sceneByName)).isLoaded)
			{
				Debug.Log((object)"Menu scene is loaded, unloading...");
				SceneManager.UnloadSceneAsync("Inicio");
			}
			SceneManager.LoadScene(0);
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}
	}

	public static Action OnBeforeSceneReload = delegate
	{
	};

	private static PauseMenuUI IADEMLIIDPC;

	[SerializeField]
	private YesNoDialogueUI yesNoDialogue;

	[SerializeField]
	private GameObject backgroundImage;

	[SerializeField]
	private Button firstElementFocused;

	[SerializeField]
	private TextMeshProUGUI textPlayer2Join;

	[SerializeField]
	private TextMeshProUGUI versionNumberText;

	[SerializeField]
	[Header("Online Mode UI Elements")]
	private GameObject multiplayerRoomPanel;

	[SerializeField]
	private TMP_Text multiplayerRoomText;

	public GameObject player2Connection;

	private string DMMFIOMOKGH;

	private string AAGBELBPBEP;

	private int MMJFCNBMDBA;

	private Sprite HEJNLFCKOKE;

	private string INAPMPEEDPO;

	public static PauseMenuUI GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)IADEMLIIDPC == (Object)null)
			{
				IADEMLIIDPC = Object.FindObjectOfType<PauseMenuUI>();
			}
			return IADEMLIIDPC;
		}
	}

	protected override void Start()
	{
		((TMP_Text)versionNumberText).text = VersionNumberManager.instance.version;
		OthersMenuUI.InviteCodeVisibleSet = (Action<bool>)Delegate.Combine(OthersMenuUI.InviteCodeVisibleSet, new Action<bool>(JCHDCAOCCDI));
	}

	[SpecialName]
	public static PauseMenuUI BDAGIEIJOOG()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<PauseMenuUI>();
		}
		return IADEMLIIDPC;
	}

	private void JCHDCAOCCDI(bool MDIKPGGBNLI)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (MDIKPGGBNLI)
			{
				multiplayerRoomText.text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("pauseMenuRoomCode"), OnlineManager.GetPrivateRoomCode());
			}
			else
			{
				multiplayerRoomText.text = InputUtils.GEJLCOGDMID(LocalisationSystem.Get("pauseMenuRoomCode"), "*****");
			}
		}
	}

	private void FKBPGPOMLBN()
	{
		((MonoBehaviour)this).StartCoroutine(DAOJNOBDAJN());
	}

	public void GoToTitleScreen()
	{
		((MonoBehaviour)this).StartCoroutine(GoToTitleScreenCoroutine());
	}

	[SpecialName]
	public static PauseMenuUI KGPJPILAHDE()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<PauseMenuUI>();
		}
		return IADEMLIIDPC;
	}

	public void BugReportClicked()
	{
		BugReportsUI.GGFJGHHHEJC.Open(base.JIIGOACEIKL);
	}

	private void CLLAKJADGIH()
	{
		if (Application.isPlaying)
		{
			OthersMenuUI.InviteCodeVisibleSet = (Action<bool>)Delegate.Remove(OthersMenuUI.InviteCodeVisibleSet, new Action<bool>(DMODAGAMEJM));
		}
	}

	public void ResumeClicked()
	{
		CloseUI();
	}

	private string PDLMMEHEAEH(out int MMJFCNBMDBA)
	{
		INAPMPEEDPO = InputUtils.CMOBIDABHKM(7, (ControllerType)0, ActionType.PrevNext);
		if (string.IsNullOrEmpty(INAPMPEEDPO))
		{
			INAPMPEEDPO = InputUtils.CMOBIDABHKM(0, (ControllerType)1, (ActionType)(-98));
			MMJFCNBMDBA = 0;
		}
		else
		{
			MMJFCNBMDBA = 7;
		}
		return INAPMPEEDPO;
	}

	private void EBICJPOCLKK()
	{
		DMMFIOMOKGH = GJINBFBIANP(out MMJFCNBMDBA);
		if (GameManager.EAOOLEFMIKE())
		{
			if (ReInput.controllers.joystickCount == 0)
			{
				AAGBELBPBEP = LocalisationSystem.Get("IrALasTermas/MainEvent");
				AAGBELBPBEP = (string.IsNullOrEmpty(AAGBELBPBEP) ? "Key2" : AAGBELBPBEP);
				((TMP_Text)textPlayer2Join).text = InputUtils.LPGJFAOKMNE(MMJFCNBMDBA, AAGBELBPBEP);
			}
			else
			{
				AAGBELBPBEP = LocalisationSystem.Get("dForDays");
				AAGBELBPBEP = (string.IsNullOrEmpty(AAGBELBPBEP) ? ("" + DMMFIOMOKGH + " ") : InputUtils.GEJLCOGDMID(AAGBELBPBEP, DMMFIOMOKGH));
				((TMP_Text)textPlayer2Join).text = InputUtils.LPGJFAOKMNE(MMJFCNBMDBA, AAGBELBPBEP);
			}
		}
		else
		{
			AAGBELBPBEP = LocalisationSystem.Get("tutorialPopUp76");
			AAGBELBPBEP = (string.IsNullOrEmpty(AAGBELBPBEP) ? ("Eat" + DMMFIOMOKGH + "before pos ") : InputUtils.GEJLCOGDMID(AAGBELBPBEP, DMMFIOMOKGH));
			((TMP_Text)textPlayer2Join).text = InputUtils.LPGJFAOKMNE(3, AAGBELBPBEP);
		}
	}

	private IEnumerator CBNKPNNAGPH()
	{
		return new OMIKDFGPGAJ(1);
	}

	public void IBPAOCBHMBL()
	{
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		yesNoDialogue.Open(base.JIIGOACEIKL);
		if (Object.op_Implicit((Object)(object)yesNoDialogue.boxText))
		{
			((TMP_Text)yesNoDialogue.boxText).text = LocalisationSystem.Get("Idle") + (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ ? ("UIAddRemove" + LocalisationSystem.Get("Grain Ferment")) : " ");
		}
		else if (Object.op_Implicit((Object)(object)yesNoDialogue.boxText))
		{
			((TMP_Text)yesNoDialogue.boxText).text = LocalisationSystem.Get("Could not get name of achievement ") + (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ ? ("FallRight" + LocalisationSystem.Get("ListViewEntry")) : " ");
		}
		yesNoDialogue.PNFHLPDOOID(new UnityAction(KHHCJKMAJAC));
	}

	public void FPLDEAMPBFL()
	{
		OptionsMenuUI.BDAGIEIJOOG().OFGKFMJKBON(base.JIIGOACEIKL);
	}

	public void OGBMMDNOMBF()
	{
		KeybindUI.GGFJGHHHEJC.OFGKFMJKBON(base.JIIGOACEIKL);
	}

	private void OnDestroy()
	{
		if (Application.isPlaying)
		{
			OthersMenuUI.InviteCodeVisibleSet = (Action<bool>)Delegate.Remove(OthersMenuUI.InviteCodeVisibleSet, new Action<bool>(JCHDCAOCCDI));
		}
	}

	protected override void Awake()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			base.Awake();
			ResetSingleton();
		}
	}

	public void ControlsClicked()
	{
		KeybindUI.GGFJGHHHEJC.Open(base.JIIGOACEIKL);
	}

	public IEnumerator OGOBODACDDN()
	{
		GameManager.leavingTheGame = true;
		CommonReferences.GGFJGHHHEJC.tilemapsInfo.ANOMBEOPINN(Location.Tavern, 1);
		yield return null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineManager.SendReturningToMainMenu();
			yield return CommonReferences.waitRealtime1;
			OnlineManager.Disconnect();
			float startTime = Time.realtimeSinceStartup;
			while (OnlineManager.PlayingOnline() && Time.realtimeSinceStartup - startTime < 5f)
			{
				yield return null;
			}
		}
		if ((Object)(object)GameManager.GGFJGHHHEJC.player2Instantiated != (Object)null)
		{
			GameManager.GGFJGHHHEJC.DeactivatePlayer2();
		}
		OnBeforeSceneReload?.Invoke();
		Time.timeScale = 1f;
		Sound.GGFJGHHHEJC.UnmuteLoops();
		GameManager.isLoading = true;
		Scene sceneByName = SceneManager.GetSceneByName("Inicio");
		if (((Scene)(ref sceneByName)).isLoaded)
		{
			Debug.Log((object)"Menu scene is loaded, unloading...");
			SceneManager.UnloadSceneAsync("Inicio");
		}
		SceneManager.LoadScene(0);
	}

	private string NNPBGMCMMMB(out int MMJFCNBMDBA)
	{
		HEJNLFCKOKE = ButtonsContext.GetPlayer(2).GetSpriteWithActionType(ActionType.UIAddRemove);
		if ((Object)(object)HEJNLFCKOKE == (Object)null)
		{
			HEJNLFCKOKE = ButtonsContext.GetPlayer(1).GetSpriteWithActionType(ActionType.UIAddRemove);
			MMJFCNBMDBA = 1;
		}
		else
		{
			MMJFCNBMDBA = 2;
		}
		if (Object.op_Implicit((Object)(object)HEJNLFCKOKE))
		{
			return "<sprite name=" + ((Object)HEJNLFCKOKE).name + ">";
		}
		return "SPACE";
	}

	public void JFOJAPMNLNL()
	{
		KeybindUI.DEGPIHEEFHJ().Open(base.JIIGOACEIKL);
	}

	public void IMNKMCBPCGF()
	{
		((MonoBehaviour)this).StartCoroutine(KECMFNHCHBP());
	}

	public void CopyMultiplayerRoomCode()
	{
		Utils.OKJMFGIFMMB(OnlineManager.GetPrivateRoomCode());
	}

	private void NCHNEAMMDHC()
	{
		DMMFIOMOKGH = JOJCEBLOFIB(out MMJFCNBMDBA);
		if (GameManager.SinglePlayer())
		{
			if (ReInput.controllers.joystickCount == 0)
			{
				AAGBELBPBEP = LocalisationSystem.Get("Walk");
				AAGBELBPBEP = (string.IsNullOrEmpty(AAGBELBPBEP) ? "<color=#B50000>" : AAGBELBPBEP);
				((TMP_Text)textPlayer2Join).text = InputUtils.LPGJFAOKMNE(MMJFCNBMDBA, AAGBELBPBEP);
				return;
			}
			AAGBELBPBEP = LocalisationSystem.Get("Invalid playerNum");
			string aAGBELBPBEP2;
			if (!string.IsNullOrEmpty(AAGBELBPBEP))
			{
				string aAGBELBPBEP = AAGBELBPBEP;
				string[] array = new string[0];
				array[0] = DMMFIOMOKGH;
				aAGBELBPBEP2 = InputUtils.GEJLCOGDMID(aAGBELBPBEP, array);
			}
			else
			{
				aAGBELBPBEP2 = "Player2" + DMMFIOMOKGH + "ReceiveRecord";
			}
			AAGBELBPBEP = aAGBELBPBEP2;
			((TMP_Text)textPlayer2Join).text = InputUtils.LPGJFAOKMNE(MMJFCNBMDBA, AAGBELBPBEP);
		}
		else
		{
			AAGBELBPBEP = LocalisationSystem.Get("Inventory full");
			AAGBELBPBEP = (string.IsNullOrEmpty(AAGBELBPBEP) ? ("MaximumReached" + DMMFIOMOKGH + ".xml") : InputUtils.GEJLCOGDMID(AAGBELBPBEP, DMMFIOMOKGH));
			((TMP_Text)textPlayer2Join).text = InputUtils.LPGJFAOKMNE(8, AAGBELBPBEP);
		}
	}

	public void BIAHJMBENIP()
	{
		((MonoBehaviour)this).StartCoroutine(GoToTitleScreenCoroutine());
	}

	private IEnumerator DAOJNOBDAJN()
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineManager.SendReturningToMainMenu();
			yield return CommonReferences.waitRealtime1;
			OnlineManager.Disconnect();
		}
		if (!Application.isEditor)
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	public void ECFBGBJLDCP()
	{
		OnlineSteamCallbacks.OpenSteamInviteUI();
	}

	public override void OnContentActivated()
	{
		base.OnContentActivated();
		if (!GameManager.PlayingOnline())
		{
			Time.timeScale = 0f;
		}
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)firstElementFocused);
		}
	}

	public void QuitClicked()
	{
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
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

	private void DMODAGAMEJM(bool MDIKPGGBNLI)
	{
		if (OnlineManager.PlayingOnline())
		{
			if (MDIKPGGBNLI)
			{
				TMP_Text obj = multiplayerRoomText;
				string cAEDMEDBEGI = LocalisationSystem.Get("ReceivePlantCrop");
				string[] array = new string[0];
				array[1] = OnlineManager.GetPrivateRoomCode();
				obj.text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI, array);
			}
			else
			{
				TMP_Text obj2 = multiplayerRoomText;
				string cAEDMEDBEGI2 = LocalisationSystem.Get("</color>");
				string[] array2 = new string[0];
				array2[1] = "Staff";
				obj2.text = InputUtils.GEJLCOGDMID(cAEDMEDBEGI2, array2);
			}
		}
	}

	public void IEJNENDPNPL()
	{
		OnlineSteamCallbacks.NHAAJBAIJBM();
	}

	private void IHBGODEIIEP()
	{
		DMMFIOMOKGH = CFIGJHPPJID(out MMJFCNBMDBA);
		if (GameManager.SinglePlayer())
		{
			if (ReInput.controllers.joystickCount == 0)
			{
				AAGBELBPBEP = LocalisationSystem.Get("ThemeTriggerSection");
				AAGBELBPBEP = (string.IsNullOrEmpty(AAGBELBPBEP) ? "GO" : AAGBELBPBEP);
				((TMP_Text)textPlayer2Join).text = InputUtils.LPGJFAOKMNE(MMJFCNBMDBA, AAGBELBPBEP);
				return;
			}
			AAGBELBPBEP = LocalisationSystem.Get("ReceivePlayerInventory");
			string aAGBELBPBEP2;
			if (!string.IsNullOrEmpty(AAGBELBPBEP))
			{
				string aAGBELBPBEP = AAGBELBPBEP;
				string[] array = new string[0];
				array[1] = DMMFIOMOKGH;
				aAGBELBPBEP2 = InputUtils.GEJLCOGDMID(aAGBELBPBEP, array);
			}
			else
			{
				aAGBELBPBEP2 = "Float {0} changed to {1} on {2}'s animator. Sending RPC." + DMMFIOMOKGH + "itemWatermelon";
			}
			AAGBELBPBEP = aAGBELBPBEP2;
			((TMP_Text)textPlayer2Join).text = InputUtils.LPGJFAOKMNE(MMJFCNBMDBA, AAGBELBPBEP);
		}
		else
		{
			AAGBELBPBEP = LocalisationSystem.Get("ReceiveSymbolPuzzleSolved");
			string aAGBELBPBEP4;
			if (!string.IsNullOrEmpty(AAGBELBPBEP))
			{
				string aAGBELBPBEP3 = AAGBELBPBEP;
				string[] array2 = new string[0];
				array2[1] = DMMFIOMOKGH;
				aAGBELBPBEP4 = InputUtils.GEJLCOGDMID(aAGBELBPBEP3, array2);
			}
			else
			{
				aAGBELBPBEP4 = "." + DMMFIOMOKGH + "Trying to set rich presence key ";
			}
			AAGBELBPBEP = aAGBELBPBEP4;
			((TMP_Text)textPlayer2Join).text = InputUtils.LPGJFAOKMNE(7, AAGBELBPBEP);
		}
	}

	private void LMHHKHJDNKG()
	{
		((MonoBehaviour)this).StartCoroutine(HCGFLADJHHC());
	}

	public void KHHCJKMAJAC()
	{
		((MonoBehaviour)this).StartCoroutine(KECMFNHCHBP());
	}

	public override void OpenUI()
	{
		if (!GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			DeassignOpenedWindow(base.JIIGOACEIKL);
			return;
		}
		if (Intro.instance.pauseMenuBlock)
		{
			DeassignOpenedWindow(base.JIIGOACEIKL);
			return;
		}
		if (LKOJBFMGMAE || CommonReferences.GGFJGHHHEJC.travelZoneBeingUsed || CommonReferences.GGFJGHHHEJC.travelZoneBeingUsed2 || CommonReferences.GGFJGHHHEJC.anySelected || CommonReferences.GGFJGHHHEJC.anyPlaceableSelected.Count > 0 || TutorialManager.GGFJGHHHEJC.GCEHLDLKOIC)
		{
			DeassignOpenedWindow(base.JIIGOACEIKL);
			return;
		}
		if (SelectObject.GetPlayer(base.JIIGOACEIKL).selected != null)
		{
			DeassignOpenedWindow(base.JIIGOACEIKL);
			return;
		}
		base.OpenUI();
		OptionsMenuUI.GGFJGHHHEJC.SetPlayerNum(base.JIIGOACEIKL);
		EncyclopediaUI.GGFJGHHHEJC.SetPlayerNum(base.JIIGOACEIKL);
		backgroundImage.SetActive(true);
		Sound.GGFJGHHHEJC.MuteLoops();
		SelectObject.GetPlayer(1).Deselect();
		if (Object.op_Implicit((Object)(object)SelectObject.GetPlayer(2)))
		{
			SelectObject.GetPlayer(2).Deselect();
		}
		if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			MainUI.HideUI();
		}
		Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowOpen), HOMFPAFAOGD: true, null, null, 0.4f);
		LOJCPJBELDN();
		if (OnlineManager.PlayingOnline())
		{
			player2Connection.SetActive(false);
		}
		else
		{
			player2Connection.SetActive(true);
		}
	}

	private string JOJCEBLOFIB(out int MMJFCNBMDBA)
	{
		if (GameManager.SinglePlayer())
		{
			if (PlayerInputs.IsGamepadActive(1))
			{
				if (ReInput.controllers.joystickCount > 1)
				{
					return NNPBGMCMMMB(out MMJFCNBMDBA);
				}
				return BMKEPPJOGHH(out MMJFCNBMDBA);
			}
			return NNPBGMCMMMB(out MMJFCNBMDBA);
		}
		if (PlayerInputs.IsGamepadActive(2))
		{
			return NNPBGMCMMMB(out MMJFCNBMDBA);
		}
		return BMKEPPJOGHH(out MMJFCNBMDBA);
	}

	public void IEDCDGPCHDB()
	{
		OptionsMenuUI.DEGPIHEEFHJ().OFGKFMJKBON(base.JIIGOACEIKL);
	}

	private void LOJCPJBELDN()
	{
		multiplayerRoomPanel.SetActive(OnlineManager.PlayingOnline());
		if (OnlineManager.PlayingOnline())
		{
			JCHDCAOCCDI(OthersMenuUI.GetInviteCodeVisible());
		}
	}

	private void OJNNHNPDBHP()
	{
		((MonoBehaviour)this).StartCoroutine(DAOJNOBDAJN());
	}

	public override void CloseUI()
	{
		if (IsOpen())
		{
			base.CloseUI();
			backgroundImage.SetActive(false);
			Sound.GGFJGHHHEJC.UnmuteLoops();
			Time.timeScale = 1f;
			SelectObject.GetPlayer(1).Deselect();
			if (Object.op_Implicit((Object)(object)SelectObject.GetPlayer(2)))
			{
				SelectObject.GetPlayer(2).Deselect();
			}
			MainUI.ShowUI();
			Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowClose), HOMFPAFAOGD: true, null, null, 0.4f);
		}
	}

	public void BDPINNBAJDH()
	{
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		yesNoDialogue.Open(base.JIIGOACEIKL);
		if (Object.op_Implicit((Object)(object)yesNoDialogue.boxText))
		{
			((TMP_Text)yesNoDialogue.boxText).text = LocalisationSystem.Get("Fishing Update: Recipe fragments updated from ") + (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ ? ("FerroProgress" + LocalisationSystem.Get(" to actorNumber ")) : "Items/item_name_604");
		}
		else if (Object.op_Implicit((Object)(object)yesNoDialogue.boxText))
		{
			((TMP_Text)yesNoDialogue.boxText).text = LocalisationSystem.Get("City/Petra/Bark/Stand") + (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ ? ("Farm/Event/RegañinaViolet" + LocalisationSystem.Get("CannotToggleUI RentRoomUI opened")) : "MainProgress");
		}
		yesNoDialogue.KHJIHCFKONP(new UnityAction(IMNKMCBPCGF));
	}

	public void ResetSingleton()
	{
		OnBeforeSceneReload = delegate
		{
		};
	}

	private IEnumerator DDHIHOPKABK()
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineManager.SendReturningToMainMenu();
			yield return CommonReferences.waitRealtime1;
			OnlineManager.Disconnect();
		}
		if (!Application.isEditor)
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	public void AJCCCBBDENO()
	{
		Utils.OKJMFGIFMMB(OnlineManager.GetPrivateRoomCode());
	}

	private void DGOGKLMHJEG()
	{
		if (Application.isPlaying)
		{
			OthersMenuUI.InviteCodeVisibleSet = (Action<bool>)Delegate.Remove(OthersMenuUI.InviteCodeVisibleSet, new Action<bool>(DMODAGAMEJM));
		}
	}

	private string GJINBFBIANP(out int MMJFCNBMDBA)
	{
		if (GameManager.SinglePlayer())
		{
			if (PlayerInputs.EEJEOALIHFJ(0))
			{
				if (ReInput.controllers.joystickCount > 0)
				{
					return JKJJLFELKLL(out MMJFCNBMDBA);
				}
				return GJHFLLJABLK(out MMJFCNBMDBA);
			}
			return NNPBGMCMMMB(out MMJFCNBMDBA);
		}
		if (PlayerInputs.ODGALPDEIFG(4))
		{
			return NNPBGMCMMMB(out MMJFCNBMDBA);
		}
		return BMKEPPJOGHH(out MMJFCNBMDBA);
	}

	public void TitleClicked()
	{
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		yesNoDialogue.Open(base.JIIGOACEIKL);
		if (Object.op_Implicit((Object)(object)yesNoDialogue.boxText))
		{
			((TMP_Text)yesNoDialogue.boxText).text = LocalisationSystem.Get("Quit to title screen?") + (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ ? ("\n" + LocalisationSystem.Get("Unsaved progress will be lost.")) : "");
		}
		else if (Object.op_Implicit((Object)(object)yesNoDialogue.boxText))
		{
			((TMP_Text)yesNoDialogue.boxText).text = LocalisationSystem.Get("Quit to title screen?") + (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ ? ("\n" + LocalisationSystem.Get("Unsaved progress will be lost.")) : "");
		}
		yesNoDialogue.AddYesAction(new UnityAction(GoToTitleScreen));
	}

	public void OptionsClicked()
	{
		OptionsMenuUI.GGFJGHHHEJC.Open(base.JIIGOACEIKL);
	}

	public void IJGCLDIDILM()
	{
		EncyclopediaUI.GGFJGHHHEJC.Open(base.JIIGOACEIKL);
	}

	public void HKONNKBNLEB()
	{
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		yesNoDialogue.Open(base.JIIGOACEIKL);
		if (Object.op_Implicit((Object)(object)yesNoDialogue.boxText))
		{
			((TMP_Text)yesNoDialogue.boxText).text = LocalisationSystem.Get(" downloaded, written with name ") + (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ ? (" / " + LocalisationSystem.Get("decrease reputation")) : "Items/item_description_614");
		}
		else if (Object.op_Implicit((Object)(object)yesNoDialogue.boxText))
		{
			((TMP_Text)yesNoDialogue.boxText).text = LocalisationSystem.Get("UI2") + (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ ? ("Current map: " + LocalisationSystem.Get("Dialogue System/Conversation/NeutralInTavern/Entry/10/Dialogue Text")) : "Dialogue System/Conversation/Crowly_Barks_Bye/Entry/5/Dialogue Text");
		}
		yesNoDialogue.KHJIHCFKONP(new UnityAction(FKBPGPOMLBN));
	}

	private string CFIGJHPPJID(out int MMJFCNBMDBA)
	{
		if (GameManager.SinglePlayer())
		{
			if (PlayerInputs.ODGALPDEIFG(0))
			{
				if (ReInput.controllers.joystickCount > 0)
				{
					return NNPBGMCMMMB(out MMJFCNBMDBA);
				}
				return PDLMMEHEAEH(out MMJFCNBMDBA);
			}
			return NNPBGMCMMMB(out MMJFCNBMDBA);
		}
		if (PlayerInputs.POLDHCKJINN(1))
		{
			return NNPBGMCMMMB(out MMJFCNBMDBA);
		}
		return GJHFLLJABLK(out MMJFCNBMDBA);
	}

	private string MGKLOJDPPBO(out int MMJFCNBMDBA)
	{
		if (GameManager.SinglePlayer())
		{
			if (PlayerInputs.FJLAMCHKCOI(1))
			{
				if (ReInput.controllers.joystickCount > 1)
				{
					return NNPBGMCMMMB(out MMJFCNBMDBA);
				}
				return BMKEPPJOGHH(out MMJFCNBMDBA);
			}
			return JKJJLFELKLL(out MMJFCNBMDBA);
		}
		if (PlayerInputs.POLDHCKJINN(4))
		{
			return JKJJLFELKLL(out MMJFCNBMDBA);
		}
		return PDLMMEHEAEH(out MMJFCNBMDBA);
	}

	private void KNPMACCFPIP()
	{
		multiplayerRoomPanel.SetActive(OnlineManager.PlayingOnline());
		if (OnlineManager.PlayingOnline())
		{
			DMODAGAMEJM(OthersMenuUI.IMIOPGIMLDJ());
		}
	}

	public void JENMOCOJFKP()
	{
		OnlineSteamCallbacks.OpenSteamInviteUI();
	}

	public void IOBABIKCPKH()
	{
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		yesNoDialogue.Open(base.JIIGOACEIKL);
		if (Object.op_Implicit((Object)(object)yesNoDialogue.boxText))
		{
			((TMP_Text)yesNoDialogue.boxText).text = LocalisationSystem.Get("Disabled") + (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ ? ("Changing zoom " + LocalisationSystem.Get("========================================================================================")) : "BarIdleNumber");
		}
		else if (Object.op_Implicit((Object)(object)yesNoDialogue.boxText))
		{
			((TMP_Text)yesNoDialogue.boxText).text = LocalisationSystem.Get("/") + (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ ? ("Sell" + LocalisationSystem.Get("ReceiveAddKickedCustomer")) : "Hair");
		}
		yesNoDialogue.BPLGICNEGKG(new UnityAction(BIAHJMBENIP));
	}

	private void IICNDILOKJA()
	{
		DMMFIOMOKGH = GJINBFBIANP(out MMJFCNBMDBA);
		if (GameManager.NBFLEJHLGNB())
		{
			if (ReInput.controllers.joystickCount == 0)
			{
				AAGBELBPBEP = LocalisationSystem.Get("Items/item_name_1140");
				AAGBELBPBEP = (string.IsNullOrEmpty(AAGBELBPBEP) ? "Dialogue System/Conversation/TooDark/Entry/9/Dialogue Text" : AAGBELBPBEP);
				((TMP_Text)textPlayer2Join).text = InputUtils.LPGJFAOKMNE(MMJFCNBMDBA, AAGBELBPBEP);
				return;
			}
			AAGBELBPBEP = LocalisationSystem.Get("Farm/Buzz/Introduce");
			string aAGBELBPBEP2;
			if (!string.IsNullOrEmpty(AAGBELBPBEP))
			{
				string aAGBELBPBEP = AAGBELBPBEP;
				string[] array = new string[0];
				array[0] = DMMFIOMOKGH;
				aAGBELBPBEP2 = InputUtils.GEJLCOGDMID(aAGBELBPBEP, array);
			}
			else
			{
				aAGBELBPBEP2 = "Floor_7" + DMMFIOMOKGH + "BirdInAChest_Error";
			}
			AAGBELBPBEP = aAGBELBPBEP2;
			((TMP_Text)textPlayer2Join).text = InputUtils.LPGJFAOKMNE(MMJFCNBMDBA, AAGBELBPBEP);
		}
		else
		{
			AAGBELBPBEP = LocalisationSystem.Get("Hurt");
			string aAGBELBPBEP4;
			if (!string.IsNullOrEmpty(AAGBELBPBEP))
			{
				string aAGBELBPBEP3 = AAGBELBPBEP;
				string[] array2 = new string[0];
				array2[1] = DMMFIOMOKGH;
				aAGBELBPBEP4 = InputUtils.GEJLCOGDMID(aAGBELBPBEP3, array2);
			}
			else
			{
				aAGBELBPBEP4 = "Dialogue System/Conversation/Crowly_Introduce/Entry/20/Dialogue Text" + DMMFIOMOKGH + "BarkActor";
			}
			AAGBELBPBEP = aAGBELBPBEP4;
			((TMP_Text)textPlayer2Join).text = InputUtils.LPGJFAOKMNE(4, AAGBELBPBEP);
		}
	}

	protected override void Update()
	{
		base.Update();
		if (IsOpen())
		{
			EPHJBODBMHP();
		}
	}

	public void ANNBHLJMBIC()
	{
		Utils.OKJMFGIFMMB(OnlineManager.GetPrivateRoomCode());
	}

	public void NLEPCACPJON()
	{
		EncyclopediaUI.AGGAGCBAGLL().OFGKFMJKBON(base.JIIGOACEIKL);
	}

	public void EncyclopediaClicked()
	{
		EncyclopediaUI.GGFJGHHHEJC.Open(base.JIIGOACEIKL);
	}

	public IEnumerator GoToTitleScreenCoroutine()
	{
		GameManager.leavingTheGame = true;
		CommonReferences.GGFJGHHHEJC.tilemapsInfo.ANOMBEOPINN(Location.Tavern, 1);
		yield return null;
		if (OnlineManager.PlayingOnline())
		{
			OnlineManager.SendReturningToMainMenu();
			yield return CommonReferences.waitRealtime1;
			OnlineManager.Disconnect();
			float startTime = Time.realtimeSinceStartup;
			while (OnlineManager.PlayingOnline() && Time.realtimeSinceStartup - startTime < 5f)
			{
				yield return null;
			}
		}
		if ((Object)(object)GameManager.GGFJGHHHEJC.player2Instantiated != (Object)null)
		{
			GameManager.GGFJGHHHEJC.DeactivatePlayer2();
		}
		OnBeforeSceneReload?.Invoke();
		Time.timeScale = 1f;
		Sound.GGFJGHHHEJC.UnmuteLoops();
		GameManager.isLoading = true;
		Scene sceneByName = SceneManager.GetSceneByName("Inicio");
		if (((Scene)(ref sceneByName)).isLoaded)
		{
			Debug.Log((object)"Menu scene is loaded, unloading...");
			SceneManager.UnloadSceneAsync("Inicio");
		}
		SceneManager.LoadScene(0);
	}

	public void GABOIKLKNKG()
	{
		BugReportsUI.GGFJGHHHEJC.Open(base.JIIGOACEIKL);
	}

	[SpecialName]
	public static PauseMenuUI EKDNJDJHONF()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<PauseMenuUI>();
		}
		return IADEMLIIDPC;
	}

	public void OpenDiscord()
	{
		Application.OpenURL("https://discord.gg/7rBtuZb");
	}

	public void CJKCKCHLJCC()
	{
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		yesNoDialogue.OFGKFMJKBON(base.JIIGOACEIKL);
		if (Object.op_Implicit((Object)(object)yesNoDialogue.boxText))
		{
			((TMP_Text)yesNoDialogue.boxText).text = LocalisationSystem.Get("Attack/MainEvent 2") + (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ ? ("Items/item_description_630" + LocalisationSystem.Get("Player")) : "Interact");
		}
		else if (Object.op_Implicit((Object)(object)yesNoDialogue.boxText))
		{
			((TMP_Text)yesNoDialogue.boxText).text = LocalisationSystem.Get("ErrorMessageTooLong") + (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ ? ("Dialogue System/Conversation/BirdPositiveComments/Entry/1/Dialogue Text" + LocalisationSystem.Get(" not found. Cannot set isSelected to ")) : "WeaponEnd");
		}
		yesNoDialogue.OEMOCFFOHJJ(new UnityAction(BIAHJMBENIP));
	}

	private string BMKEPPJOGHH(out int MMJFCNBMDBA)
	{
		INAPMPEEDPO = InputUtils.CMOBIDABHKM(2, (ControllerType)0, ActionType.Start);
		if (string.IsNullOrEmpty(INAPMPEEDPO))
		{
			INAPMPEEDPO = InputUtils.CMOBIDABHKM(1, (ControllerType)0, ActionType.Start);
			MMJFCNBMDBA = 1;
		}
		else
		{
			MMJFCNBMDBA = 2;
		}
		return INAPMPEEDPO;
	}

	private void EPHJBODBMHP()
	{
		DMMFIOMOKGH = JOJCEBLOFIB(out MMJFCNBMDBA);
		if (GameManager.SinglePlayer())
		{
			if (ReInput.controllers.joystickCount == 0)
			{
				AAGBELBPBEP = LocalisationSystem.Get("player2ConnectGamepad");
				AAGBELBPBEP = (string.IsNullOrEmpty(AAGBELBPBEP) ? "Connect a gamepad to play with player 2" : AAGBELBPBEP);
				((TMP_Text)textPlayer2Join).text = InputUtils.LPGJFAOKMNE(MMJFCNBMDBA, AAGBELBPBEP);
			}
			else
			{
				AAGBELBPBEP = LocalisationSystem.Get("player2ToJoinGame");
				AAGBELBPBEP = (string.IsNullOrEmpty(AAGBELBPBEP) ? ("(Player 2) Press " + DMMFIOMOKGH + " to join the game") : InputUtils.GEJLCOGDMID(AAGBELBPBEP, DMMFIOMOKGH));
				((TMP_Text)textPlayer2Join).text = InputUtils.LPGJFAOKMNE(MMJFCNBMDBA, AAGBELBPBEP);
			}
		}
		else
		{
			AAGBELBPBEP = LocalisationSystem.Get("player2ToDisconnectFromGame");
			AAGBELBPBEP = (string.IsNullOrEmpty(AAGBELBPBEP) ? ("(Player 2) Press " + DMMFIOMOKGH + " to disconnect from the game") : InputUtils.GEJLCOGDMID(AAGBELBPBEP, DMMFIOMOKGH));
			((TMP_Text)textPlayer2Join).text = InputUtils.LPGJFAOKMNE(2, AAGBELBPBEP);
		}
	}

	public void AEPCBDEFGCM()
	{
		BugReportsUI.GGFJGHHHEJC.Open(base.JIIGOACEIKL);
	}

	private IEnumerator MFPNADFBGFG()
	{
		return new OMIKDFGPGAJ(1);
	}

	private string GJHFLLJABLK(out int MMJFCNBMDBA)
	{
		INAPMPEEDPO = InputUtils.CMOBIDABHKM(1, (ControllerType)0, (ActionType)(-85));
		if (string.IsNullOrEmpty(INAPMPEEDPO))
		{
			INAPMPEEDPO = InputUtils.CMOBIDABHKM(1, (ControllerType)0, ActionType.Right);
			MMJFCNBMDBA = 0;
		}
		else
		{
			MMJFCNBMDBA = 4;
		}
		return INAPMPEEDPO;
	}

	private void KNFGIHIEOCM()
	{
		multiplayerRoomPanel.SetActive(OnlineManager.PlayingOnline());
		if (OnlineManager.PlayingOnline())
		{
			JCHDCAOCCDI(OthersMenuUI.IMIOPGIMLDJ());
		}
	}

	public void APHCEJMIFJE()
	{
		CloseUI();
	}

	private IEnumerator LHCDAGADCAJ()
	{
		if (OnlineManager.PlayingOnline())
		{
			OnlineManager.SendReturningToMainMenu();
			yield return CommonReferences.waitRealtime1;
			OnlineManager.Disconnect();
		}
		if (!Application.isEditor)
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	public void InviteFriendButtonClicked()
	{
		OnlineSteamCallbacks.OpenSteamInviteUI();
	}

	private string JKJJLFELKLL(out int MMJFCNBMDBA)
	{
		HEJNLFCKOKE = ButtonsContext.GetPlayer(8).GetSpriteWithActionType((ActionType)118);
		if ((Object)(object)HEJNLFCKOKE == (Object)null)
		{
			HEJNLFCKOKE = ButtonsContext.GetPlayer(0).GetSpriteWithActionType((ActionType)109);
			MMJFCNBMDBA = 1;
		}
		else
		{
			MMJFCNBMDBA = 1;
		}
		if (Object.op_Implicit((Object)(object)HEJNLFCKOKE))
		{
			return "Stop" + ((Object)HEJNLFCKOKE).name + "ErrorJoinRoomFull";
		}
		return "{0} HumanInfo string:\n";
	}

	private IEnumerator HCGFLADJHHC()
	{
		return new OMIKDFGPGAJ(1);
	}

	public void OEJNALEDGLF()
	{
		BugReportsUI.GGFJGHHHEJC.Open(base.JIIGOACEIKL);
	}

	public void IEJCPEJAAAC()
	{
		OnlineSteamCallbacks.NHAAJBAIJBM();
	}

	public IEnumerator KECMFNHCHBP()
	{
		return new HAKPEHKNLDP(1);
	}

	private void NKGMEMEACNN()
	{
		if (Application.isPlaying)
		{
			OthersMenuUI.InviteCodeVisibleSet = (Action<bool>)Delegate.Remove(OthersMenuUI.InviteCodeVisibleSet, new Action<bool>(JCHDCAOCCDI));
		}
	}

	public void APEPEAOLNJO()
	{
		Application.OpenURL("ReceiveTavernEventsLoad");
	}
}
