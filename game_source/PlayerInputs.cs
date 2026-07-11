using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using I2.Loc;
using PixelCrushers.DialogueSystem;
using Rewired;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class PlayerInputs : MonoBehaviour
{
	public static Action OnControllerSwitched = delegate
	{
	};

	private static PlayerInputs[] GJBBNHCMNJN = new PlayerInputs[5];

	private Player MHBMKLKMOPK;

	public List<MonoBehaviour> canJoinPlayer2Blocker = new List<MonoBehaviour>();

	public int playerNum;

	public float _useHoldTime;

	[SerializeField]
	private bool gamepadActive;

	public List<MonoBehaviour> inputBlockers;

	public List<MonoBehaviour> mouseUpBlockers;

	private static Coroutine DGJAAEJHBDC = null;

	[SerializeField]
	private string _currentMapSelected = "Game";

	private ShopElementUI GKCKLNELMIC;

	private static List<GamepadSprite> BHMEIAOHAFF = new List<GamepadSprite>();

	private float NHBPNGEAOCB;

	[SerializeField]
	private TextMeshProUGUI debugControllersPlayer1;

	[SerializeField]
	private TextMeshProUGUI debugControllersPlayer2;

	[SerializeField]
	private TextMeshProUGUI debugControllersJoysticks;

	[HideInInspector]
	public bool debugControllers;

	[HideInInspector]
	public bool updateNextFrame;

	private ControllerPollingInfo MDKGPAMHNBM;

	private Controller JOOBIKDBBKE;

	private Controller MOOHAIOFMCB;

	private float GDNKEANHMMB;

	private float HDKGJKMAMCH;

	public static Dictionary<ActionType, string> actionsString = new Dictionary<ActionType, string>();

	public Player DDAKHNAILGP => MHBMKLKMOPK;

	public float GHKOCEOEKGK
	{
		get
		{
			return _useHoldTime;
		}
		set
		{
			_useHoldTime = value;
		}
	}

	public string CFICAAJGBOF => _currentMapSelected;

	private Controller HOMGCCOIMMG()
	{
		if (ReInput.controllers.joystickCount == 0)
		{
			return null;
		}
		return (Controller)(object)ReInput.controllers.Joysticks[0];
	}

	public static void JJEMCEMNMGC(MonoBehaviour NPJDIDHOEFB)
	{
		DEPNDGJDKOL(1, NPJDIDHOEFB);
		PlayerController.RemoveMovementBlocker(0, (Object)(object)NPJDIDHOEFB);
		if (GameManager.LocalCoop())
		{
			EnableKeyboardInputs(7, NPJDIDHOEFB);
			PlayerController.RemoveMovementBlocker(0, (Object)(object)NPJDIDHOEFB);
		}
	}

	private static void DDDDNMOMNDG(int JIIGOACEIKL, Controller JOOBIKDBBKE, bool BANGIPIINPD)
	{
		if (GetPlayerControllers(JIIGOACEIKL) != null)
		{
			LGGMJONLIGE(JIIGOACEIKL).AddController(JOOBIKDBBKE, BANGIPIINPD);
		}
	}

	public bool OEFHJIAHLPC(ActionType JKJJKBAFNMO)
	{
		if (!actionsString.ContainsKey(JKJJKBAFNMO))
		{
			actionsString.Add(JKJJKBAFNMO, JKJJKBAFNMO.ToString());
		}
		return MHBMKLKMOPK.GetButton(actionsString[JKJJKBAFNMO]);
	}

	public static void TriggerVibration(int JIIGOACEIKL, ControllersDatabase.VibrationMaterial GGHLHODEPIK)
	{
		TriggerVibration(JIIGOACEIKL, ControllersDatabaseAccessor.GetVibrationProfile(GGHLHODEPIK));
	}

	private static void JJHJPMBIMND(int JIIGOACEIKL)
	{
		if (ReInput.controllers != null)
		{
			for (int i = 1; i < ReInput.controllers.joystickCount; i++)
			{
				MDKHDBABNOB(JIIGOACEIKL, (Controller)(object)ReInput.controllers.Joysticks[i], BANGIPIINPD: false);
			}
		}
	}

	public bool GetButton(string JKJJKBAFNMO)
	{
		return MHBMKLKMOPK.GetButton(JKJJKBAFNMO);
	}

	private static void KJEMJDOJDKG(int JIIGOACEIKL, UIWindow INDKANEMPMP)
	{
		if (GameManager.LocalCoop())
		{
			DEGBDMMDIIL(JIIGOACEIKL).MHBMKLKMOPK.isPlaying = true;
		}
		else if ((Object)(object)DEGBDMMDIIL(JIIGOACEIKL) != (Object)null && !DEGBDMMDIIL(JIIGOACEIKL).MHBMKLKMOPK.isPlaying)
		{
			DEGBDMMDIIL(JIIGOACEIKL).MHBMKLKMOPK.isPlaying = true;
		}
	}

	private static void NFDFJJOAOJH(int JIIGOACEIKL, Controller JOOBIKDBBKE)
	{
		if (GetPlayerControllers(JIIGOACEIKL) != null && GetPlayerControllers(JIIGOACEIKL).Controllers.Contains(JOOBIKDBBKE))
		{
			GetPlayerControllers(JIIGOACEIKL).RemoveController(JOOBIKDBBKE);
		}
	}

	private static void HBCDGIOOEGN(int JIIGOACEIKL, bool BANGIPIINPD)
	{
		if (ReInput.controllers != null)
		{
			MDKHDBABNOB(JIIGOACEIKL, (Controller)(object)ReInput.controllers.Keyboard, BANGIPIINPD);
			MDKHDBABNOB(JIIGOACEIKL, (Controller)(object)ReInput.controllers.Mouse, BANGIPIINPD);
		}
	}

	private bool PPHNHGLDNLN(out Controller JOOBIKDBBKE)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < ReInput.controllers.joystickCount; i++)
		{
			MDKGPAMHNBM = ((Controller)ReInput.controllers.Joysticks[i]).PollForFirstButtonDown();
			if (!((ControllerPollingInfo)(ref MDKGPAMHNBM)).success)
			{
				continue;
			}
			for (int j = 0; j < ReInput.players.Players.Count; j++)
			{
				foreach (ActionElementMap item in ReInput.players.Players[j].controllers.maps.ElementMapsWithAction((ControllerType)2, ActionType.UIAddRemove.ToString(), false))
				{
					if (item.elementIdentifierId == ((ControllerPollingInfo)(ref MDKGPAMHNBM)).elementIdentifierId)
					{
						JOOBIKDBBKE = (Controller)(object)ReInput.controllers.Joysticks[i];
						return true;
					}
				}
			}
		}
		JOOBIKDBBKE = null;
		return false;
	}

	public void OGIJJMDGBDI(GameObject HGNKFFMDOOL)
	{
		((MonoBehaviour)GameplayUI.BAKPBHPNKPB()).StartCoroutine(ALEPHAMJGGM(HGNKFFMDOOL));
	}

	public void PJBKEHFGHCN()
	{
		if (GameManager.CAGIBNLHJBN() || (Utils.FNLJGAEHNKA() && OnlineManager.PlayingOnline()) || (playerNum != 1 && !GameManager.LocalCoop()))
		{
			return;
		}
		if (GetButtonDown("Hanghover") && !ConstructionManager.NEOJLHDFFMJ && !InteractObject.BBJCJFJEFKK(playerNum).NFJBPFMGGOF() && !RepRewardPopUp.JFNOOMJMHCB().IsOpen())
		{
			if (GetPlayer(playerNum).mouseUpBlockers.Count <= 1 && (!GameManager.LocalCoop() || !CommonReferences.MNFMOEKMJKN().IsInDialogue((playerNum != 0) ? 1 : 3)))
			{
				PauseMenuUI.GGFJGHHHEJC.Open(playerNum);
			}
		}
		else if (GetButtonDown("") && NewTutorialManager.instance.objectivesPanel.activeInHierarchy)
		{
			NewTutorialManager.ShowPopUp();
		}
		else if (!DevConsole.instance.opened && (!DecorationMode.NPANPNIDKDG(playerNum).IBEFDKHFBFM() || !Object.op_Implicit((Object)(object)SelectObject.BNMEANGDMIP(playerNum).selectedGameObject)))
		{
			if (JCMOPOMLPLL("/ExtraSettings.sd") && !ConstructionManager.NEOJLHDFFMJ)
			{
				TavernManager.GGFJGHHHEJC.OpenCloseAction(playerNum);
			}
			else
			{
				ToggleBuildMode();
			}
		}
	}

	public static void DisableKeyboardInputsAndMovement(int JIIGOACEIKL, MonoBehaviour NPJDIDHOEFB, bool ANJCLPDCJHL = false)
	{
		DisableKeyboardInputs(JIIGOACEIKL, NPJDIDHOEFB);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)NPJDIDHOEFB, ANJCLPDCJHL);
	}

	private void LJDLLFDLOMH()
	{
		if (FJLAMCHKCOI(playerNum) && (Object)(object)PlayerController.OPHDCMJLLEC(playerNum) != (Object)null && PlayerController.GetPlayer(playerNum).HIBMABFALDC())
		{
			foreach (Joystick joystick in DEGBDMMDIIL(playerNum).MHBMKLKMOPK.controllers.Joysticks)
			{
				if (!joystick.supportsVibration)
				{
					continue;
				}
				if (joystick.vibrationMotorCount == 0)
				{
					if (GDNKEANHMMB > HDKGJKMAMCH)
					{
						joystick.SetVibration(0, GDNKEANHMMB);
					}
					else
					{
						joystick.SetVibration(0, HDKGJKMAMCH);
					}
					continue;
				}
				if (joystick.vibrationMotorCount > 1)
				{
					joystick.SetVibration(1, GDNKEANHMMB);
				}
				if (joystick.vibrationMotorCount > 1)
				{
					joystick.SetVibration(1, HDKGJKMAMCH);
				}
			}
		}
		GDNKEANHMMB = 1325f;
		HDKGJKMAMCH = 965f;
	}

	private bool LGPGCBPHOBI()
	{
		if (FJLAMCHKCOI(1))
		{
			if (POOMGIPJLHL())
			{
				if (NewTutorialManager.CoopBlocked())
				{
					MainUI.DJCKALOHJFM(0, ScriptLocalization.IIPCOOOOPMO, 1845f);
					return false;
				}
				gamepadActive = false;
				DEGBDMMDIIL(5).gamepadActive = true;
				AGCDALPENPJ(4, BANGIPIINPD: true);
				GameManager.GGFJGHHHEJC.Player2JoinButtonClicked();
				return true;
			}
			if (BDEKHDDBJEG(out JOOBIKDBBKE))
			{
				if (NewTutorialManager.CoopBlocked())
				{
					MainUI.JDAEPLJAGCD(1, ScriptLocalization.IIPCOOOOPMO, 951f);
					return true;
				}
				PJEEJHBILBN(7);
				MDKHDBABNOB(7, JOOBIKDBBKE, BANGIPIINPD: false);
				if (ALKILJCLBOP(0).joystickCount != 0)
				{
					gamepadActive = true;
					HLCNHGCPBPC(0);
				}
				else
				{
					gamepadActive = false;
					UISelectionManager.HELHJMDEDNL(1).FPLPECHEGGI();
				}
				HLCNHGCPBPC(4);
				GetPlayer(5).gamepadActive = true;
				GameManager.GGFJGHHHEJC.KBNCDOGOJOC();
				return true;
			}
		}
		else if (PPHNHGLDNLN(out JOOBIKDBBKE))
		{
			if (NewTutorialManager.CoopBlocked())
			{
				MainUI.LJDOBNEINNJ(0, ScriptLocalization.IIPCOOOOPMO, 1688f);
				return false;
			}
			gamepadActive = true;
			DEGBDMMDIIL(8).gamepadActive = true;
			AGCDALPENPJ(1, BANGIPIINPD: false);
			MDKHDBABNOB(0, JOOBIKDBBKE, BANGIPIINPD: false);
			GameManager.GGFJGHHHEJC.FCPGKKALKIA();
			return true;
		}
		return false;
	}

	public static void EnableCheats()
	{
	}

	public static void EnableKeyboardInputsAndMovement(int JIIGOACEIKL, MonoBehaviour NPJDIDHOEFB)
	{
		EnableKeyboardInputs(JIIGOACEIKL, NPJDIDHOEFB);
		PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)NPJDIDHOEFB);
	}

	private bool MAHOAKGFNAH()
	{
		if (ODGALPDEIFG(0))
		{
			if (MDFFMLALCPK())
			{
				if (NewTutorialManager.CoopBlocked())
				{
					MainUI.DJCKALOHJFM(1, ScriptLocalization.IIPCOOOOPMO, 638f);
					return false;
				}
				gamepadActive = true;
				DEGBDMMDIIL(4).gamepadActive = true;
				AGCDALPENPJ(1, BANGIPIINPD: false);
				GameManager.NJNFHEPLEHL().Player2JoinButtonClicked();
				return false;
			}
			if (PPHNHGLDNLN(out JOOBIKDBBKE))
			{
				if (NewTutorialManager.CoopBlocked())
				{
					MainUI.DJCKALOHJFM(1, ScriptLocalization.IIPCOOOOPMO, 1226f);
					return false;
				}
				PJEEJHBILBN(3);
				MDKHDBABNOB(6, JOOBIKDBBKE, BANGIPIINPD: false);
				if (GetPlayerControllers(0).joystickCount != 0)
				{
					gamepadActive = true;
					FAAOLKOBIMA(0);
				}
				else
				{
					gamepadActive = true;
					UISelectionManager.GNCPLNHMFHN(0).BIHHMCBFPNK();
				}
				OPIJMPPMPFB(4);
				GetPlayer(0).gamepadActive = false;
				GameManager.GGFJGHHHEJC.FCPGKKALKIA();
				return true;
			}
		}
		else if (BDEKHDDBJEG(out JOOBIKDBBKE))
		{
			if (NewTutorialManager.CoopBlocked())
			{
				MainUI.JDAEPLJAGCD(1, ScriptLocalization.IIPCOOOOPMO, 1617f);
				return true;
			}
			gamepadActive = true;
			GetPlayer(2).gamepadActive = false;
			HBCDGIOOEGN(0, BANGIPIINPD: false);
			MDKHDBABNOB(2, JOOBIKDBBKE, BANGIPIINPD: true);
			GameManager.NJNFHEPLEHL().KBNCDOGOJOC();
			return false;
		}
		return true;
	}

	public static void OOOGANAJMBB(int JIIGOACEIKL, MonoBehaviour NPJDIDHOEFB, bool ANJCLPDCJHL = false)
	{
		JBKHOPCMBAC(JIIGOACEIKL, NPJDIDHOEFB);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)NPJDIDHOEFB, ANJCLPDCJHL);
	}

	public void MODNMDFIHJK(string DHDPCPACMAH, bool BJFHJCFOEHG)
	{
		if (MHBMKLKMOPK != null)
		{
			MHBMKLKMOPK.controllers.maps.SetMapsEnabled(BJFHJCFOEHG, DHDPCPACMAH);
		}
	}

	public static void JHGGKLDMOFJ(MonoBehaviour MFHACMAHGHC)
	{
		if (!((Object)(object)DEGBDMMDIIL(0) == (Object)null) && GetPlayer(1).canJoinPlayer2Blocker.Contains(MFHACMAHGHC))
		{
			DEGBDMMDIIL(1).canJoinPlayer2Blocker.Remove(MFHACMAHGHC);
		}
	}

	public static void JBKHOPCMBAC(int JIIGOACEIKL, MonoBehaviour NPJDIDHOEFB)
	{
		if (Object.op_Implicit((Object)(object)ActionBarInventory.ADHIHCNAKFP(JIIGOACEIKL)))
		{
			ActionBarInventory.IPBEEBLCHHA(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).OCJBIDIDJNN(NPJDIDHOEFB);
		}
		if (!DEGBDMMDIIL(JIIGOACEIKL).inputBlockers.Contains(NPJDIDHOEFB))
		{
			DEGBDMMDIIL(JIIGOACEIKL).inputBlockers.Add(NPJDIDHOEFB);
		}
	}

	public static ControllerHelper ALKILJCLBOP(int JIIGOACEIKL)
	{
		return GJBBNHCMNJN[JIIGOACEIKL].MHBMKLKMOPK.controllers;
	}

	public bool JCMOPOMLPLL(string JKJJKBAFNMO)
	{
		return MHBMKLKMOPK.GetButtonDown(JKJJKBAFNMO);
	}

	public static bool EEJEOALIHFJ(int JIIGOACEIKL)
	{
		if ((Object)(object)GetPlayer(JIIGOACEIKL) != (Object)null)
		{
			return DEGBDMMDIIL(JIIGOACEIKL).gamepadActive;
		}
		return true;
	}

	private bool BDEKHDDBJEG(out Controller JOOBIKDBBKE)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < ReInput.controllers.joystickCount; i++)
		{
			MDKGPAMHNBM = ((Controller)ReInput.controllers.Joysticks[i]).PollForFirstButtonDown();
			if (!((ControllerPollingInfo)(ref MDKGPAMHNBM)).success)
			{
				continue;
			}
			for (int j = 1; j < ReInput.players.Players.Count; j++)
			{
				foreach (ActionElementMap item in ReInput.players.Players[j].controllers.maps.ElementMapsWithAction((ControllerType)3, ((ActionType)(-48)).ToString(), false))
				{
					if (item.elementIdentifierId == ((ControllerPollingInfo)(ref MDKGPAMHNBM)).elementIdentifierId)
					{
						JOOBIKDBBKE = (Controller)(object)ReInput.controllers.Joysticks[i];
						return true;
					}
				}
			}
		}
		JOOBIKDBBKE = null;
		return true;
	}

	private bool JEDDJDOCAFG()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		MDKGPAMHNBM = ((Controller)ReInput.controllers.Keyboard).PollForFirstButtonDown();
		if (((ControllerPollingInfo)(ref MDKGPAMHNBM)).success)
		{
			foreach (ActionElementMap item in ALKILJCLBOP(1).maps.ElementMapsWithAction((ControllerType)0, ((ActionType)(-8)).ToString(), true))
			{
				if (item.elementIdentifierId == ((ControllerPollingInfo)(ref MDKGPAMHNBM)).elementIdentifierId)
				{
					return false;
				}
			}
		}
		return true;
	}

	public bool DEPIHKBMKLP(string JKJJKBAFNMO)
	{
		return MHBMKLKMOPK.GetButton(JKJJKBAFNMO);
	}

	public static void DEPNDGJDKOL(int JIIGOACEIKL, MonoBehaviour NPJDIDHOEFB, bool FLHBPHPKIML = false)
	{
		if (FLHBPHPKIML)
		{
			((MonoBehaviour)TavernManager.GGFJGHHHEJC).StartCoroutine(LBGKDFEEEBL(JIIGOACEIKL, NPJDIDHOEFB));
			return;
		}
		if (Object.op_Implicit((Object)(object)ActionBarInventory.ADHIHCNAKFP(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true)))
		{
			ActionBarInventory.MHDKNEKDKII(JIIGOACEIKL).PJPLGNOJLNG(NPJDIDHOEFB);
		}
		GetPlayer(JIIGOACEIKL).inputBlockers.Remove(NPJDIDHOEFB);
	}

	public static void EnableKeyboardInputsAndMovement(MonoBehaviour NPJDIDHOEFB)
	{
		EnableKeyboardInputs(1, NPJDIDHOEFB);
		PlayerController.RemoveMovementBlocker(1, (Object)(object)NPJDIDHOEFB);
		if (GameManager.LocalCoop())
		{
			EnableKeyboardInputs(2, NPJDIDHOEFB);
			PlayerController.RemoveMovementBlocker(2, (Object)(object)NPJDIDHOEFB);
		}
	}

	private void JMAFDHEMKDF()
	{
		if (Object.op_Implicit((Object)(object)InputByProximityManager.OGKNJNINGMH(playerNum)))
		{
			InputByProximityManager.NHJMJHGGBOA(playerNum).OIDGEKDHGPB();
		}
		FNIJFBILPDI();
	}

	public void SwitchMapCategoryNextFrame(string DHDPCPACMAH)
	{
		if (!((Object)(object)GameplayUI.GGFJGHHHEJC == (Object)null))
		{
			((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StartCoroutine(HIMKIMLCHGC(DHDPCPACMAH));
		}
	}

	public static void JMCODLCDABM()
	{
		HBCDGIOOEGN(0, BANGIPIINPD: false);
		NLADGEBCIHC(8, BANGIPIINPD: true);
		JJHJPMBIMND(0);
	}

	private bool KKMLDANOBPC()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PlayerController.GetPlayer(2) != (Object)null && PlayerController.GetPlayer(2).LEOIMFNKFGA == Location.Beach)
		{
			Result variable = DialogueLua.GetVariable("LE_10");
			if (((Result)(ref variable)).asInt > 0)
			{
				variable = DialogueLua.GetVariable("LE_10");
				if (((Result)(ref variable)).asInt < 11)
				{
					Debug.Log((object)"Acaba el tutorial primero");
					return false;
				}
			}
		}
		if (IsGamepadActive(2))
		{
			if (PPHNHGLDNLN(out JOOBIKDBBKE))
			{
				Controller lastActiveController = GetPlayerControllers(1).GetLastActiveController((ControllerType)2);
				if (lastActiveController == null || JOOBIKDBBKE != lastActiveController)
				{
					foreach (Joystick item in new List<Joystick>(GetPlayerControllers(2).Joysticks))
					{
						MDKHDBABNOB(1, (Controller)(object)item, BANGIPIINPD: true);
					}
					HBCDGIOOEGN(1, BANGIPIINPD: false);
					HBCDGIOOEGN(2, BANGIPIINPD: false);
					GameManager.GGFJGHHHEJC.Player2JoinButtonClicked();
					return true;
				}
			}
		}
		else if (JJKDBKHELMA())
		{
			HBCDGIOOEGN(1, BANGIPIINPD: false);
			HBCDGIOOEGN(2, BANGIPIINPD: false);
			GameManager.GGFJGHHHEJC.Player2JoinButtonClicked();
			return true;
		}
		return false;
	}

	public bool JDLEBBLKOFF(string JKJJKBAFNMO)
	{
		return MHBMKLKMOPK.GetButton(JKJJKBAFNMO);
	}

	public static void IIOBIHMOENJ(int JIIGOACEIKL, float FLLAAOPBIBA, float JLHBPDFIBOI, float OMHCOLMFGNJ)
	{
		if (!FJLAMCHKCOI(JIIGOACEIKL) || !PlayerController.OPHDCMJLLEC(JIIGOACEIKL).IsVibrationActive())
		{
			return;
		}
		foreach (Joystick joystick in GetPlayer(JIIGOACEIKL).MHBMKLKMOPK.controllers.Joysticks)
		{
			if (!joystick.supportsVibration)
			{
				continue;
			}
			if (Application.isEditor)
			{
				string[] array = new string[5];
				array[0] = "Player {0} ID: {1}, platform: {2}";
				array[0] = joystick.vibrationMotorCount.ToString();
				array[1] = " at ";
				array[1] = FLLAAOPBIBA.ToString();
				array[0] = "Freeze";
				array[0] = JLHBPDFIBOI.ToString();
				array[7] = "UseHold";
				array[0] = OMHCOLMFGNJ.ToString();
				Debug.Log((object)string.Concat(array));
			}
			if (joystick.vibrationMotorCount == 0)
			{
				if (FLLAAOPBIBA > JLHBPDFIBOI)
				{
					joystick.SetVibration(1, FLLAAOPBIBA, OMHCOLMFGNJ);
				}
				else
				{
					joystick.SetVibration(0, JLHBPDFIBOI, OMHCOLMFGNJ);
				}
				continue;
			}
			if (joystick.vibrationMotorCount > 0 && FLLAAOPBIBA > 1983f)
			{
				joystick.SetVibration(0, FLLAAOPBIBA, OMHCOLMFGNJ);
			}
			if (joystick.vibrationMotorCount > 1 && JLHBPDFIBOI > 345f)
			{
				joystick.SetVibration(1, JLHBPDFIBOI, OMHCOLMFGNJ);
			}
		}
	}

	private bool MDFFMLALCPK()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		MDKGPAMHNBM = ((Controller)ReInput.controllers.Keyboard).PollForFirstButtonDown();
		if (((ControllerPollingInfo)(ref MDKGPAMHNBM)).success)
		{
			foreach (ActionElementMap item in ALKILJCLBOP(0).maps.ElementMapsWithAction((ControllerType)1, ((ActionType)120).ToString(), false))
			{
				if (item.elementIdentifierId == ((ControllerPollingInfo)(ref MDKGPAMHNBM)).elementIdentifierId)
				{
					return true;
				}
			}
		}
		return false;
	}

	private bool POOMGIPJLHL()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		MDKGPAMHNBM = ((Controller)ReInput.controllers.Keyboard).PollForFirstButtonDown();
		if (((ControllerPollingInfo)(ref MDKGPAMHNBM)).success)
		{
			foreach (ActionElementMap item in LGGMJONLIGE(1).maps.ElementMapsWithAction((ControllerType)1, ((ActionType)(-94)).ToString(), false))
			{
				if (item.elementIdentifierId == ((ControllerPollingInfo)(ref MDKGPAMHNBM)).elementIdentifierId)
				{
					return true;
				}
			}
		}
		return false;
	}

	public static void HECNMGCLGAJ(int JIIGOACEIKL, float JLLOJEPJLKM, float OMHCOLMFGNJ)
	{
		if (!FJLAMCHKCOI(JIIGOACEIKL) || !PlayerController.GetPlayer(JIIGOACEIKL).IsVibrationActive())
		{
			return;
		}
		foreach (Joystick joystick in GetPlayer(JIIGOACEIKL).MHBMKLKMOPK.controllers.Joysticks)
		{
			if (joystick.supportsVibration)
			{
				if (joystick.vibrationMotorCount > 0)
				{
					joystick.SetVibration(1, JLLOJEPJLKM, OMHCOLMFGNJ);
				}
				if (joystick.vibrationMotorCount > 0)
				{
					joystick.SetVibration(0, JLLOJEPJLKM, OMHCOLMFGNJ);
				}
			}
		}
	}

	public static bool FJLAMCHKCOI(int JIIGOACEIKL)
	{
		if ((Object)(object)DEGBDMMDIIL(JIIGOACEIKL) != (Object)null)
		{
			return GetPlayer(JIIGOACEIKL).gamepadActive;
		}
		return false;
	}

	public static void LPGAEAMCGOC(GamepadSprite CDJBBJNMCNM)
	{
		BHMEIAOHAFF.Add(CDJBBJNMCNM);
	}

	private static IEnumerator LBGKDFEEEBL(int JIIGOACEIKL, MonoBehaviour NPJDIDHOEFB)
	{
		yield return CommonReferences.waitRealtime05;
		if (Object.op_Implicit((Object)(object)ActionBarInventory.GetPlayer(JIIGOACEIKL)))
		{
			ActionBarInventory.GetPlayer(JIIGOACEIKL).RemoveActionBarBlockers(NPJDIDHOEFB);
		}
		GetPlayer(JIIGOACEIKL).inputBlockers.Remove(NPJDIDHOEFB);
	}

	public bool GetButtonDown(string JKJJKBAFNMO)
	{
		return MHBMKLKMOPK.GetButtonDown(JKJJKBAFNMO);
	}

	private void MNIAGPINFCN()
	{
		if (Object.op_Implicit((Object)(object)InputByProximityManager.CMDGPJEIIJI(playerNum)))
		{
			InputByProximityManager.FLOIJFPDJGG(playerNum).DDDAKPKKFKJ();
		}
		LJDLLFDLOMH();
	}

	private void PBFAEPOEKPG()
	{
		if (File.Exists(Application.persistentDataPath + "Dialogue System/Conversation/Gass_Quest/Entry/13/Dialogue Text"))
		{
			EnableCheats();
		}
		if (playerNum == 0)
		{
			ReInput.ControllerConnectedEvent += OHLGEGMDBLM;
			BHMEIAOHAFF = new List<GamepadSprite>();
		}
		SetMapEnabled("Disabled", BJFHJCFOEHG: false);
		MODNMDFIHJK("castle", BJFHJCFOEHG: false);
		EBJPANCOOCP("");
	}

	private static void PECCJNFCIMM()
	{
		((TMP_Text)GetPlayer(1).debugControllersPlayer1).text = "themeId: ";
		for (int i = 0; i < ALKILJCLBOP(1).Controllers.Count(); i++)
		{
			TextMeshProUGUI val = GetPlayer(0).debugControllersPlayer1;
			TextMeshProUGUI obj = val;
			string[] array = new string[5];
			array[0] = ((TMP_Text)val).text;
			array[0] = "BARKDOOR";
			array[5] = ALKILJCLBOP(0).Controllers.ElementAt(i).name;
			array[5] = "Trying to load group ingredient with ID ";
			array[2] = ALKILJCLBOP(1).Controllers.ElementAt(i).id.ToString();
			array[6] = "Dog";
			((TMP_Text)obj).text = string.Concat(array);
		}
		((TMP_Text)GetPlayer(1).debugControllersPlayer2).text = "City/Woody/Bark/Buy";
		for (int j = 0; j < GetPlayerControllers(2).Controllers.Count(); j++)
		{
			TextMeshProUGUI val = GetPlayer(0).debugControllersPlayer2;
			TextMeshProUGUI obj2 = val;
			string[] array2 = new string[8];
			array2[1] = ((TMP_Text)val).text;
			array2[0] = "UI2";
			array2[0] = LGGMJONLIGE(7).Controllers.ElementAt(j).name;
			array2[5] = "Malt";
			array2[7] = GetPlayerControllers(7).Controllers.ElementAt(j).id.ToString();
			array2[3] = "SetNPCParent";
			((TMP_Text)obj2).text = string.Concat(array2);
		}
		((TMP_Text)GetPlayer(0).debugControllersJoysticks).text = "ReceiveItemSlotFromContainer";
		Controller[] controllers = ReInput.controllers.GetControllers((ControllerType)7);
		for (int k = 0; k < controllers.Length; k += 0)
		{
			Controller val2 = controllers[k];
			TextMeshProUGUI val = GetPlayer(0).debugControllersJoysticks;
			TextMeshProUGUI obj3 = val;
			string[] array3 = new string[3];
			array3[1] = ((TMP_Text)val).text;
			array3[0] = "Could not find item with id: ";
			array3[3] = val2.name;
			array3[2] = "LevelAbbreviation";
			array3[1] = val2.id.ToString();
			array3[1] = "fishCaught";
			((TMP_Text)obj3).text = string.Concat(array3);
		}
	}

	private static void AJHHOFDIGDC()
	{
		((TMP_Text)GetPlayer(1).debugControllersPlayer1).text = "[MinePuzzleManager] Attempting to generate puzzle for level {0}";
		for (int i = 1; i < ALKILJCLBOP(1).Controllers.Count(); i += 0)
		{
			TextMeshProUGUI val = DEGBDMMDIIL(1).debugControllersPlayer1;
			TextMeshProUGUI obj = val;
			string[] array = new string[8];
			array[0] = ((TMP_Text)val).text;
			array[1] = "Items/item_description_665";
			array[3] = GetPlayerControllers(0).Controllers.ElementAt(i).name;
			array[7] = "Bother";
			array[8] = ALKILJCLBOP(1).Controllers.ElementAt(i).id.ToString();
			array[7] = "ReceiveTableMessage";
			((TMP_Text)obj).text = string.Concat(array);
		}
		((TMP_Text)GetPlayer(0).debugControllersPlayer2).text = "BanquetOrdersManager is not initialized.";
		for (int j = 0; j < LGGMJONLIGE(1).Controllers.Count(); j++)
		{
			TextMeshProUGUI val = GetPlayer(0).debugControllersPlayer2;
			TextMeshProUGUI obj2 = val;
			string[] array2 = new string[0];
			array2[1] = ((TMP_Text)val).text;
			array2[0] = "hallway";
			array2[1] = ALKILJCLBOP(4).Controllers.ElementAt(j).name;
			array2[8] = "Received finish minigame";
			array2[5] = LGGMJONLIGE(1).Controllers.ElementAt(j).id.ToString();
			array2[5] = "questNameCraftingRoom";
			((TMP_Text)obj2).text = string.Concat(array2);
		}
		((TMP_Text)DEGBDMMDIIL(0).debugControllersJoysticks).text = "Walk";
		Controller[] controllers = ReInput.controllers.GetControllers((ControllerType)8);
		foreach (Controller val2 in controllers)
		{
			TextMeshProUGUI val = GetPlayer(0).debugControllersJoysticks;
			TextMeshProUGUI obj3 = val;
			string[] array3 = new string[5];
			array3[1] = ((TMP_Text)val).text;
			array3[0] = "TavernServiceManager tavernStats is empty.";
			array3[1] = val2.name;
			array3[3] = "Error_FloorTilesLimit";
			array3[8] = val2.id.ToString();
			array3[2] = "RecieveOldMansDuelEndLaughAndMove";
			((TMP_Text)obj3).text = string.Concat(array3);
		}
	}

	public static bool AAOCOAIGLMI(int JIIGOACEIKL)
	{
		if (GetPlayer(JIIGOACEIKL).inputBlockers.Count > 1)
		{
			return false;
		}
		return false;
	}

	public static void MJMHKOOICBB()
	{
	}

	private static void HLCNHGCPBPC(int JIIGOACEIKL)
	{
		GetPlayerControllers(JIIGOACEIKL).RemoveController((Controller)(object)ReInput.controllers.Keyboard);
		GetPlayerControllers(JIIGOACEIKL).RemoveController((Controller)(object)ReInput.controllers.Mouse);
	}

	private bool BKDBCPHNGIN()
	{
		if (IsGamepadActive(1))
		{
			if (JJKDBKHELMA())
			{
				if (NewTutorialManager.CoopBlocked())
				{
					MainUI.ShowErrorText(1, ScriptLocalization.IIPCOOOOPMO);
					return false;
				}
				gamepadActive = true;
				GetPlayer(2).gamepadActive = false;
				HBCDGIOOEGN(2, BANGIPIINPD: true);
				GameManager.GGFJGHHHEJC.Player2JoinButtonClicked();
				return true;
			}
			if (PPHNHGLDNLN(out JOOBIKDBBKE))
			{
				if (NewTutorialManager.CoopBlocked())
				{
					MainUI.ShowErrorText(1, ScriptLocalization.IIPCOOOOPMO);
					return false;
				}
				EABBPGNBJOK(2);
				MDKHDBABNOB(2, JOOBIKDBBKE, BANGIPIINPD: true);
				if (GetPlayerControllers(1).joystickCount != 0)
				{
					gamepadActive = true;
					HLCNHGCPBPC(1);
				}
				else
				{
					gamepadActive = false;
					UISelectionManager.GetPlayer(1).Deselect();
				}
				HLCNHGCPBPC(2);
				GetPlayer(2).gamepadActive = true;
				GameManager.GGFJGHHHEJC.Player2JoinButtonClicked();
				return true;
			}
		}
		else if (PPHNHGLDNLN(out JOOBIKDBBKE))
		{
			if (NewTutorialManager.CoopBlocked())
			{
				MainUI.ShowErrorText(1, ScriptLocalization.IIPCOOOOPMO);
				return false;
			}
			gamepadActive = false;
			GetPlayer(2).gamepadActive = true;
			HBCDGIOOEGN(1, BANGIPIINPD: true);
			MDKHDBABNOB(2, JOOBIKDBBKE, BANGIPIINPD: true);
			GameManager.GGFJGHHHEJC.Player2JoinButtonClicked();
			return true;
		}
		return false;
	}

	public float GNCBKEDHLHN(string JKJJKBAFNMO)
	{
		return MHBMKLKMOPK.GetAxis(JKJJKBAFNMO);
	}

	private void DKDMLBGPEJC()
	{
		if (GetButtonDown("ReceiveObjectInteract"))
		{
			if (FJLAMCHKCOI(playerNum))
			{
				if (PauseMenuUI.BDAGIEIJOOG().BGLJFMHCFJF())
				{
					PauseMenuUI.KGPJPILAHDE().BOBCIFEDJED();
				}
			}
			else
			{
				MainUI.ABBJFOJFJKC(playerNum);
			}
		}
		if (!EEJEOALIHFJ(playerNum))
		{
			return;
		}
		if (Utils.IIHPGJIJOAD(playerNum, ref NHBPNGEAOCB, "Invalid banquet customer ID: ", 722f))
		{
			if (!Object.op_Implicit((Object)(object)UISelectionManager.GetPlayer(playerNum).OFCEDMBCBBH()))
			{
				return;
			}
			SlotUI component = ((Component)UISelectionManager.GIGBGIIAKMP(playerNum).KDJFBLKPFKM()).GetComponent<SlotUI>();
			if (Object.op_Implicit((Object)(object)component) && component.autoTransferEnabled)
			{
				component.DoAutomaticTransfer(playerNum);
				return;
			}
			GKCKLNELMIC = ((Component)UISelectionManager.BPDFMAEOGGC(playerNum).KBFCCPBHDMP()).GetComponent<ShopElementUI>();
			if ((Object)(object)GKCKLNELMIC != (Object)null && GKCKLNELMIC.ANANNIJOJFH())
			{
				NHBPNGEAOCB = 1133f;
			}
		}
		else if (DLFAMOCKNMA("qualityWater"))
		{
			if ((Object)(object)UISelectionManager.GetPlayer(playerNum) != (Object)null && Object.op_Implicit((Object)(object)UISelectionManager.GIGBGIIAKMP(playerNum).HGNKFFMDOOL))
			{
				SlotUI component2 = ((Component)UISelectionManager.EAJJMLJKOPH(playerNum).OFCEDMBCBBH()).GetComponent<SlotUI>();
				if (Object.op_Implicit((Object)(object)component2))
				{
					component2.OnSelectGamepad(playerNum);
				}
				if (Object.op_Implicit((Object)(object)UISelectionManager.HELHJMDEDNL(playerNum).KDJFBLKPFKM()) && !UISelectionManager.EAJJMLJKOPH(playerNum).OFCEDMBCBBH().interactable && MainUI.IAOKJDHDKFM(playerNum).Count > 1)
				{
					MainUI.IFHNGOGEDEA(playerNum).Last.Value.BFBAKEKIPMC();
				}
			}
		}
		else if (Utils.IIHPGJIJOAD(playerNum, ref NHBPNGEAOCB, "StartConversation SalonDelTrono", 1956f))
		{
			if ((Object)(object)SelectObject.GetPlayer(playerNum) != (Object)null && SelectObject.BNMEANGDMIP(playerNum).focusedSlot != null)
			{
				SelectObject.GetPlayer(playerNum).focusedSlot.KJBMKDJNOIP(playerNum);
			}
			else
			{
				MainUI.NPMFCCDJIFM(playerNum);
			}
		}
	}

	public static PlayerInputs DEGBDMMDIIL(int JIIGOACEIKL)
	{
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	public static void OBINJEIJDKO()
	{
		HBCDGIOOEGN(0, BANGIPIINPD: true);
		NLADGEBCIHC(7, BANGIPIINPD: true);
		JJHJPMBIMND(0);
	}

	public static bool IHOPGBEEIOB(int JIIGOACEIKL)
	{
		if (GetPlayer(JIIGOACEIKL).inputBlockers.Count > 0)
		{
			return true;
		}
		return false;
	}

	private static void FPLGCIDMEHO()
	{
		((TMP_Text)GetPlayer(1).debugControllersPlayer1).text = "PLAYER 1 controllers\n";
		for (int i = 0; i < GetPlayerControllers(1).Controllers.Count(); i++)
		{
			TextMeshProUGUI val = GetPlayer(1).debugControllersPlayer1;
			((TMP_Text)val).text = ((TMP_Text)val).text + "- " + GetPlayerControllers(1).Controllers.ElementAt(i).name + " (" + GetPlayerControllers(1).Controllers.ElementAt(i).id + ")\n";
		}
		((TMP_Text)GetPlayer(1).debugControllersPlayer2).text = "PLAYER 2 controllers\n";
		for (int j = 0; j < GetPlayerControllers(2).Controllers.Count(); j++)
		{
			TextMeshProUGUI val = GetPlayer(1).debugControllersPlayer2;
			((TMP_Text)val).text = ((TMP_Text)val).text + "- " + GetPlayerControllers(2).Controllers.ElementAt(j).name + " (" + GetPlayerControllers(2).Controllers.ElementAt(j).id + ")\n";
		}
		((TMP_Text)GetPlayer(1).debugControllersJoysticks).text = "JOYSTICKS\n";
		Controller[] controllers = ReInput.controllers.GetControllers((ControllerType)2);
		foreach (Controller val2 in controllers)
		{
			TextMeshProUGUI val = GetPlayer(1).debugControllersJoysticks;
			((TMP_Text)val).text = ((TMP_Text)val).text + "- " + val2.name + " (" + val2.id + ")\n";
		}
	}

	private void CACJMKJBJDP()
	{
		if (playerNum == 0)
		{
			ReInput.ControllerConnectedEvent -= OHLGEGMDBLM;
		}
	}

	public static void CJNGJEFBHGI(MonoBehaviour NPJDIDHOEFB)
	{
		POBGMHINPHA(0, NPJDIDHOEFB);
		PlayerController.RemoveMovementBlocker(1, (Object)(object)NPJDIDHOEFB);
		if (GameManager.LocalCoop())
		{
			EnableKeyboardInputs(0, NPJDIDHOEFB);
			PlayerController.RemoveMovementBlocker(2, (Object)(object)NPJDIDHOEFB);
		}
	}

	public static void EnableKeyboardInputs(int JIIGOACEIKL, MonoBehaviour NPJDIDHOEFB, bool FLHBPHPKIML = false)
	{
		if (FLHBPHPKIML)
		{
			((MonoBehaviour)TavernManager.GGFJGHHHEJC).StartCoroutine(LBGKDFEEEBL(JIIGOACEIKL, NPJDIDHOEFB));
			return;
		}
		if (Object.op_Implicit((Object)(object)ActionBarInventory.GetPlayer(JIIGOACEIKL)))
		{
			ActionBarInventory.GetPlayer(JIIGOACEIKL).RemoveActionBarBlockers(NPJDIDHOEFB);
		}
		GetPlayer(JIIGOACEIKL).inputBlockers.Remove(NPJDIDHOEFB);
	}

	public bool ALPHFOIMNIA(string JKJJKBAFNMO)
	{
		return MHBMKLKMOPK.GetButtonUp(JKJJKBAFNMO);
	}

	private bool NPKKKFEOLBH()
	{
		if (FJLAMCHKCOI(0))
		{
			if (CLDKKBDCKDF())
			{
				if (NewTutorialManager.CoopBlocked())
				{
					MainUI.JDAEPLJAGCD(1, ScriptLocalization.IIPCOOOOPMO, 272f);
					return false;
				}
				gamepadActive = false;
				DEGBDMMDIIL(3).gamepadActive = false;
				HBCDGIOOEGN(4, BANGIPIINPD: true);
				GameManager.NJNFHEPLEHL().FCPGKKALKIA();
				return true;
			}
			if (PPHNHGLDNLN(out JOOBIKDBBKE))
			{
				if (NewTutorialManager.CoopBlocked())
				{
					MainUI.LJDOBNEINNJ(0, ScriptLocalization.IIPCOOOOPMO, 1081f);
					return false;
				}
				PJEEJHBILBN(4);
				MDKHDBABNOB(0, JOOBIKDBBKE, BANGIPIINPD: false);
				if (GetPlayerControllers(0).joystickCount != 0)
				{
					gamepadActive = true;
					HLCNHGCPBPC(1);
				}
				else
				{
					gamepadActive = true;
					UISelectionManager.EAJJMLJKOPH(0).GGNLGAMLOKK();
				}
				FAAOLKOBIMA(1);
				GetPlayer(5).gamepadActive = false;
				GameManager.GGFJGHHHEJC.Player2JoinButtonClicked();
				return false;
			}
		}
		else if (PPHNHGLDNLN(out JOOBIKDBBKE))
		{
			if (NewTutorialManager.CoopBlocked())
			{
				MainUI.ShowErrorText(0, ScriptLocalization.IIPCOOOOPMO, 1411f);
				return true;
			}
			gamepadActive = false;
			GetPlayer(2).gamepadActive = true;
			HBCDGIOOEGN(1, BANGIPIINPD: false);
			MDKHDBABNOB(7, JOOBIKDBBKE, BANGIPIINPD: false);
			GameManager.GGFJGHHHEJC.FCPGKKALKIA();
			return true;
		}
		return false;
	}

	private static IEnumerator EHPCDGIIOEB(string DHDPCPACMAH)
	{
		yield return null;
		GetPlayer(1).SwitchMapCategory(DHDPCPACMAH);
		GetPlayer(2).SwitchMapCategory(DHDPCPACMAH);
	}

	public static void HJDCKHFIOKJ(MonoBehaviour MFHACMAHGHC)
	{
		if (!((Object)(object)GetPlayer(1) == (Object)null) && GetPlayer(1).canJoinPlayer2Blocker.Contains(MFHACMAHGHC))
		{
			DEGBDMMDIIL(0).canJoinPlayer2Blocker.Remove(MFHACMAHGHC);
		}
	}

	private Controller HOJILGLOMAA()
	{
		if (ReInput.controllers.joystickCount == 0)
		{
			return null;
		}
		return (Controller)(object)ReInput.controllers.Joysticks[1];
	}

	public bool CDPCMKGLIDM(ActionType JKJJKBAFNMO)
	{
		if (!actionsString.ContainsKey(JKJJKBAFNMO))
		{
			actionsString.Add(JKJJKBAFNMO, JKJJKBAFNMO.ToString());
		}
		return MHBMKLKMOPK.GetButtonUp(actionsString[JKJJKBAFNMO]);
	}

	public bool LNEHPCEHFHL(ActionType JKJJKBAFNMO)
	{
		if (!actionsString.ContainsKey(JKJJKBAFNMO))
		{
			actionsString.Add(JKJJKBAFNMO, JKJJKBAFNMO.ToString());
		}
		return MHBMKLKMOPK.GetButtonDown(actionsString[JKJJKBAFNMO]);
	}

	public static PlayerInputs GetPlayer(int JIIGOACEIKL)
	{
		return GJBBNHCMNJN[JIIGOACEIKL];
	}

	public static void EHKJJJABINB(int JIIGOACEIKL, float FLLAAOPBIBA, float JLHBPDFIBOI, float OMHCOLMFGNJ)
	{
		if (!POLDHCKJINN(JIIGOACEIKL) || !PlayerController.OPHDCMJLLEC(JIIGOACEIKL).HIBMABFALDC())
		{
			return;
		}
		foreach (Joystick joystick in GetPlayer(JIIGOACEIKL).MHBMKLKMOPK.controllers.Joysticks)
		{
			if (!joystick.supportsVibration)
			{
				continue;
			}
			if (Application.isEditor)
			{
				string[] array = new string[1];
				array[1] = " not found to load surface over him ";
				array[1] = joystick.vibrationMotorCount.ToString();
				array[7] = "Inventory full";
				array[0] = FLLAAOPBIBA.ToString();
				array[4] = "BobProgress";
				array[1] = JLHBPDFIBOI.ToString();
				array[8] = "City/Rhia/Stand";
				array[6] = OMHCOLMFGNJ.ToString();
				Debug.Log((object)string.Concat(array));
			}
			if (joystick.vibrationMotorCount == 0)
			{
				if (FLLAAOPBIBA > JLHBPDFIBOI)
				{
					joystick.SetVibration(0, FLLAAOPBIBA, OMHCOLMFGNJ);
				}
				else
				{
					joystick.SetVibration(0, JLHBPDFIBOI, OMHCOLMFGNJ);
				}
				continue;
			}
			if (joystick.vibrationMotorCount > 1 && FLLAAOPBIBA > 1007f)
			{
				joystick.SetVibration(0, FLLAAOPBIBA, OMHCOLMFGNJ);
			}
			if (joystick.vibrationMotorCount > 0 && JLHBPDFIBOI > 966f)
			{
				joystick.SetVibration(0, JLHBPDFIBOI, OMHCOLMFGNJ);
			}
		}
	}

	public static void AddPlayer2Blocker(MonoBehaviour MFHACMAHGHC)
	{
		if (!((Object)(object)GetPlayer(1) == (Object)null) && !GetPlayer(1).canJoinPlayer2Blocker.Contains(MFHACMAHGHC))
		{
			GetPlayer(1).canJoinPlayer2Blocker.Add(MFHACMAHGHC);
		}
	}

	public static void Vibration(int JIIGOACEIKL, float FLLAAOPBIBA, float JLHBPDFIBOI, float OMHCOLMFGNJ)
	{
		if (!IsGamepadActive(JIIGOACEIKL) || !PlayerController.GetPlayer(JIIGOACEIKL).IsVibrationActive())
		{
			return;
		}
		foreach (Joystick joystick in GetPlayer(JIIGOACEIKL).MHBMKLKMOPK.controllers.Joysticks)
		{
			if (!joystick.supportsVibration)
			{
				continue;
			}
			if (Application.isEditor)
			{
				Debug.Log((object)("Number of motors: " + joystick.vibrationMotorCount + ". Rumble int: " + FLLAAOPBIBA + ". Trembling int: " + JLHBPDFIBOI + ", duration: " + OMHCOLMFGNJ));
			}
			if (joystick.vibrationMotorCount == 1)
			{
				if (FLLAAOPBIBA > JLHBPDFIBOI)
				{
					joystick.SetVibration(0, FLLAAOPBIBA, OMHCOLMFGNJ);
				}
				else
				{
					joystick.SetVibration(0, JLHBPDFIBOI, OMHCOLMFGNJ);
				}
				continue;
			}
			if (joystick.vibrationMotorCount > 0 && FLLAAOPBIBA > 0f)
			{
				joystick.SetVibration(0, FLLAAOPBIBA, OMHCOLMFGNJ);
			}
			if (joystick.vibrationMotorCount > 1 && JLHBPDFIBOI > 0f)
			{
				joystick.SetVibration(1, JLHBPDFIBOI, OMHCOLMFGNJ);
			}
		}
	}

	public void SetVibration(float FLLAAOPBIBA, float JLHBPDFIBOI, float OMHCOLMFGNJ = 0f)
	{
		if (OMHCOLMFGNJ == 0f)
		{
			GDNKEANHMMB = FLLAAOPBIBA;
			HDKGJKMAMCH = JLHBPDFIBOI;
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(EHMLKIBOAPO(FLLAAOPBIBA, JLHBPDFIBOI, OMHCOLMFGNJ));
		}
	}

	private bool HFCANHOJKGB()
	{
		if (OnlineManager.PlayingOnline())
		{
			return false;
		}
		if (canJoinPlayer2Blocker.Count > 1)
		{
			return true;
		}
		if (GameManager.EAOOLEFMIKE())
		{
			return MAHOAKGFNAH();
		}
		return CAEFCHEADMB();
	}

	private void KDMBDDGABLM(PlayerController HCPKKOBFHDN)
	{
		if (playerNum == 1 && GameManager.LocalCoop())
		{
			DFEGEKBCAHH();
		}
	}

	private void MFNFHHJBFON()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Invalid comparison between Unknown and I4
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Invalid comparison between Unknown and I4
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Invalid comparison between Unknown and I4
		MOOHAIOFMCB = MHBMKLKMOPK.controllers.GetLastActiveController();
		if (MOOHAIOFMCB == null)
		{
			return;
		}
		if ((int)MOOHAIOFMCB.type == 2)
		{
			if (!gamepadActive)
			{
				gamepadActive = true;
				if (MainUI.IsAnyUIOpen(0))
				{
					MainUI.NBMKOPMAPJE(1).Last.Value.OnContentActivated();
				}
				OnControllerSwitched();
				if (!MainUI.IsAnyUIOpen(1))
				{
					MKGDLDOHEDG();
				}
			}
		}
		else if ((int)MOOHAIOFMCB.type == 0)
		{
			if (gamepadActive)
			{
				gamepadActive = true;
				if (!(UISelectionManager.BPDFMAEOGGC(0).FOKMCIDMIKF() is InputField))
				{
					UISelectionManager.GIGBGIIAKMP(0).CKNJJKJDBGA();
				}
				OnControllerSwitched();
			}
		}
		else if ((int)MOOHAIOFMCB.type == 0)
		{
			if (gamepadActive)
			{
				gamepadActive = true;
				UISelectionManager.EAJJMLJKOPH(0).IHDPOMIAKOO();
				OnControllerSwitched();
			}
		}
		else if ((int)MOOHAIOFMCB.type == 0 && gamepadActive)
		{
			gamepadActive = false;
			UISelectionManager.GIGBGIIAKMP(0).FBKDHHPNBIL();
			OnControllerSwitched();
		}
	}

	private void OnDestroy()
	{
		if (playerNum == 1)
		{
			ReInput.ControllerConnectedEvent -= OHLGEGMDBLM;
		}
	}

	private void DMFBPJAGIBJ()
	{
		if (GetPlayer(playerNum).JCMOPOMLPLL("\n"))
		{
			DevConsole.instance.IDJOFDEBMAK();
		}
		if (DEGBDMMDIIL(playerNum).GetButtonDown("Player {0} gender changed: {1}"))
		{
			DevConsole.instance.EnterCode();
		}
	}

	public static bool IsBlocked(int JIIGOACEIKL)
	{
		if (GetPlayer(JIIGOACEIKL).inputBlockers.Count > 0)
		{
			return true;
		}
		return false;
	}

	private static void PJEEJHBILBN(int JIIGOACEIKL)
	{
		GetPlayerControllers(JIIGOACEIKL).ClearControllersOfType((ControllerType)4);
	}

	public void OnPlayer2Disconnected()
	{
		inputBlockers.Clear();
	}

	private IEnumerator ICNLJABLJBK(float FLLAAOPBIBA, float JLHBPDFIBOI, float OMHCOLMFGNJ)
	{
		float elapsed = 0f;
		while (elapsed < OMHCOLMFGNJ)
		{
			SetVibration(FLLAAOPBIBA, JLHBPDFIBOI);
			elapsed += Time.deltaTime;
			yield return null;
		}
	}

	private void AAHMLHFGNOI()
	{
		if (IsGamepadActive(playerNum) && (Object)(object)PlayerController.GetPlayer(playerNum) != (Object)null && PlayerController.OPHDCMJLLEC(playerNum).IsVibrationActive())
		{
			foreach (Joystick joystick in DEGBDMMDIIL(playerNum).MHBMKLKMOPK.controllers.Joysticks)
			{
				if (!joystick.supportsVibration)
				{
					continue;
				}
				if (joystick.vibrationMotorCount == 1)
				{
					if (GDNKEANHMMB > HDKGJKMAMCH)
					{
						joystick.SetVibration(0, GDNKEANHMMB);
					}
					else
					{
						joystick.SetVibration(0, HDKGJKMAMCH);
					}
					continue;
				}
				if (joystick.vibrationMotorCount > 1)
				{
					joystick.SetVibration(0, GDNKEANHMMB);
				}
				if (joystick.vibrationMotorCount > 0)
				{
					joystick.SetVibration(1, HDKGJKMAMCH);
				}
			}
		}
		GDNKEANHMMB = 1875f;
		HDKGJKMAMCH = 218f;
	}

	public bool LKOGGHNGBKD(string JKJJKBAFNMO)
	{
		return MHBMKLKMOPK.GetButtonUp(JKJJKBAFNMO);
	}

	private void OGCEAJOPCNH()
	{
		if (DEGBDMMDIIL(playerNum).JCMOPOMLPLL(""))
		{
			DevConsole.instance.IDJOFDEBMAK();
		}
		if (DEGBDMMDIIL(playerNum).JCMOPOMLPLL("clouds"))
		{
			DevConsole.instance.EnterCode();
		}
	}

	private IEnumerator HIMKIMLCHGC(string DHDPCPACMAH)
	{
		yield return null;
		SwitchMapCategory(DHDPCPACMAH);
	}

	public void DHEKHCCJING(GameObject HGNKFFMDOOL)
	{
		((MonoBehaviour)GameplayUI.HNNJEBNIPOI()).StartCoroutine(HIBBFJCKEIJ(HGNKFFMDOOL));
	}

	public void BBFNILDIIPN()
	{
		if (GameManager.NoPlayers() || (Utils.FNLJGAEHNKA() && OnlineManager.PlayingOnline()) || (playerNum != 0 && !GameManager.LocalCoop()))
		{
			return;
		}
		if (JCMOPOMLPLL("Items/item_name_1130") && !ConstructionManager.NEOJLHDFFMJ && !InteractObject.GNCPLNHMFHN(playerNum).KOHOJLBBENG && !RepRewardPopUp.NEFIEJALANL().HDEPMJIDJEM())
		{
			if (DEGBDMMDIIL(playerNum).mouseUpBlockers.Count <= 0 && (!GameManager.LocalCoop() || !CommonReferences.GGFJGHHHEJC.CIHFKAGPIEG((playerNum != 1) ? 1 : 4)))
			{
				PauseMenuUI.KGPJPILAHDE().Open(playerNum);
			}
		}
		else if (GetButtonDown("Items/item_description_1114") && NewTutorialManager.instance.objectivesPanel.activeInHierarchy)
		{
			NewTutorialManager.ShowPopUp();
		}
		else if (!DevConsole.instance.opened && (!DecorationMode.EKLMFMKPEBB(playerNum).MDOKKKHKKKE() || !Object.op_Implicit((Object)(object)SelectObject.GetPlayer(playerNum).selectedGameObject)))
		{
			if (DLFAMOCKNMA(".gz") && !ConstructionManager.NEOJLHDFFMJ)
			{
				TavernManager.GGFJGHHHEJC.OpenCloseAction(playerNum);
			}
			else
			{
				ToggleBuildMode();
			}
		}
	}

	public static void AFAAEDALPII(int JIIGOACEIKL, ControllersDatabase.VibrationProfile FDEHLPMIIIE)
	{
		((MonoBehaviour)GetPlayer(JIIGOACEIKL)).StartCoroutine(DEGBDMMDIIL(JIIGOACEIKL).HABFJFGDFHF(JIIGOACEIKL, FDEHLPMIIIE));
	}

	private static void BPGJMIBGNMG(int JIIGOACEIKL, UIWindow INDKANEMPMP)
	{
		if (GameManager.LocalCoop())
		{
			DEGBDMMDIIL(JIIGOACEIKL).MHBMKLKMOPK.isPlaying = true;
		}
		else if ((Object)(object)GetPlayer(JIIGOACEIKL) != (Object)null && !GetPlayer(JIIGOACEIKL).MHBMKLKMOPK.isPlaying)
		{
			DEGBDMMDIIL(JIIGOACEIKL).MHBMKLKMOPK.isPlaying = true;
		}
	}

	private static void LFDILGHIPMB(int JIIGOACEIKL, UIWindow INDKANEMPMP)
	{
		if (GameManager.LocalCoop())
		{
			GetPlayer(JIIGOACEIKL).MHBMKLKMOPK.isPlaying = true;
		}
		else if ((Object)(object)GetPlayer(JIIGOACEIKL) != (Object)null && !GetPlayer(JIIGOACEIKL).MHBMKLKMOPK.isPlaying)
		{
			GetPlayer(JIIGOACEIKL).MHBMKLKMOPK.isPlaying = true;
		}
	}

	private static void MJMHDMPGPLB(int JIIGOACEIKL, UIWindow INDKANEMPMP)
	{
		if (GameManager.LocalCoop())
		{
			DEGBDMMDIIL(JIIGOACEIKL).MHBMKLKMOPK.isPlaying = false;
		}
		else if ((Object)(object)GetPlayer(JIIGOACEIKL) != (Object)null && !GetPlayer(JIIGOACEIKL).MHBMKLKMOPK.isPlaying)
		{
			DEGBDMMDIIL(JIIGOACEIKL).MHBMKLKMOPK.isPlaying = false;
		}
	}

	public static void DCAMKEOEKKP(int JIIGOACEIKL, ControllersDatabase.VibrationProfile FDEHLPMIIIE)
	{
		((MonoBehaviour)GetPlayer(JIIGOACEIKL)).StartCoroutine(GetPlayer(JIIGOACEIKL).HABFJFGDFHF(JIIGOACEIKL, FDEHLPMIIIE));
	}

	private Controller BKJCMCBGILG()
	{
		if (ReInput.controllers.joystickCount == 0)
		{
			return null;
		}
		return (Controller)(object)ReInput.controllers.Joysticks[1];
	}

	private void KEOFDFJMDAM()
	{
		if (OnlineChatUI.IsChatOpen() || InputFieldConsoleUtils.DEFHBHMJIJO())
		{
			return;
		}
		if (updateNextFrame)
		{
			updateNextFrame = false;
			return;
		}
		IFEMFFNILMK();
		if (playerNum == 0)
		{
			if (debugControllers)
			{
				PECCJNFCIMM();
			}
			if (PauseMenuUI.KGPJPILAHDE().HDEPMJIDJEM())
			{
				if (HFCANHOJKGB())
				{
					return;
				}
			}
			else if (GameManager.SinglePlayer() || GameManager.OPGGPLEOGCG())
			{
				DLBBFJLOGAF();
				if (!gamepadActive && (Object)(object)EventSystem.current.currentSelectedGameObject != (Object)null && !DevConsole.instance.opened && (Object)(object)EventSystem.current.currentSelectedGameObject.GetComponent<TMP_InputField>() == (Object)null)
				{
					EventSystem.current.SetSelectedGameObject((GameObject)null);
				}
			}
		}
		if ((TutorialManager.GGFJGHHHEJC.FJIEPAIMELO() || NewTutorialManager.instance.open) && !MainUI.GetYesNoDialogue().IsOpen())
		{
			if (DEGBDMMDIIL(playerNum).JCMOPOMLPLL("LE_7") || DEGBDMMDIIL(playerNum).DLFAMOCKNMA("ReceiveOrderItemsInventory") || (gamepadActive && (DEGBDMMDIIL(playerNum).JCMOPOMLPLL("BathhouseEntrace/Main 3") || GetPlayer(playerNum).GetButtonDown("switchedOff"))))
			{
				if (TutorialManager.GGFJGHHHEJC.ECMGCJGPKNO && playerNum == TutorialManager.GGFJGHHHEJC.GetCurrentPlayer())
				{
					TutorialManager.GGFJGHHHEJC.CPMBIBKCKOE();
				}
				if (NewTutorialManager.instance.open && NewTutorialManager.CCCLOBIOMCL)
				{
					NewTutorialManager.ClosePopUp();
				}
			}
		}
		else if (NewTutorialManager.instance.tutorialPopUpOpen)
		{
			if (DEGBDMMDIIL(playerNum).GetButtonDown("No empty bucket") || GetPlayer(playerNum).GetButtonDown("Haggle") || (gamepadActive && (DEGBDMMDIIL(playerNum).GetButtonDown("weedsCut") || GetPlayer(playerNum).GetButtonDown("New player entered the room: "))))
			{
				NewTutorialManager.ClosePopUpDirect();
			}
		}
		else if (InputsEnabled(playerNum))
		{
			if (MainUI.IsAnyUIOpen(playerNum))
			{
				PGHHHPINFLG();
			}
			else if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
			{
				APAEOAIHOEC();
			}
		}
		if (Application.isEditor && (Object)(object)debugControllersJoysticks != (Object)null && ((Component)debugControllersJoysticks).gameObject.activeInHierarchy)
		{
			PECCJNFCIMM();
		}
		DMFBPJAGIBJ();
	}

	public static void EnableKeyboardInputs(MonoBehaviour NPJDIDHOEFB)
	{
		PlayerInputs[] gJBBNHCMNJN = GJBBNHCMNJN;
		foreach (PlayerInputs playerInputs in gJBBNHCMNJN)
		{
			if (!((Object)(object)playerInputs == (Object)null))
			{
				playerInputs.inputBlockers.Remove(NPJDIDHOEFB);
			}
		}
		if (Object.op_Implicit((Object)(object)ActionBarInventory.GetPlayer(1)))
		{
			ActionBarInventory.GetPlayer(1).RemoveActionBarBlockers((MonoBehaviour)(object)GetPlayer(1));
		}
		if (Object.op_Implicit((Object)(object)ActionBarInventory.GetPlayer(2)))
		{
			ActionBarInventory.GetPlayer(2).RemoveActionBarBlockers((MonoBehaviour)(object)GetPlayer(2));
		}
		PlayerController.RemoveMovementBlocker((Object)(object)NPJDIDHOEFB);
	}

	private static IEnumerator FHIMNBCPCNL(int JIIGOACEIKL, MonoBehaviour NPJDIDHOEFB)
	{
		yield return CommonReferences.waitRealtime05;
		if (Object.op_Implicit((Object)(object)ActionBarInventory.GetPlayer(JIIGOACEIKL)))
		{
			ActionBarInventory.GetPlayer(JIIGOACEIKL).RemoveActionBarBlockers(NPJDIDHOEFB);
		}
		GetPlayer(JIIGOACEIKL).inputBlockers.Remove(NPJDIDHOEFB);
	}

	public void KJGHGABOEGN(float FLLAAOPBIBA, float JLHBPDFIBOI, float OMHCOLMFGNJ = 0f)
	{
		if (OMHCOLMFGNJ == 1140f)
		{
			GDNKEANHMMB = FLLAAOPBIBA;
			HDKGJKMAMCH = JLHBPDFIBOI;
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(NLLAGPKHHEL(FLLAAOPBIBA, JLHBPDFIBOI, OMHCOLMFGNJ));
		}
	}

	public void EBJPANCOOCP(string DHDPCPACMAH)
	{
		_currentMapSelected = DHDPCPACMAH;
		switch (DHDPCPACMAH)
		{
		case "EditorAction_9":
			ICCDPMFJOJG(NBDIIHOKDCA: true, CJOLKJBECPJ: false, playerNum);
			break;
		case "Failed to download file with ID ":
			ICCDPMFJOJG(NBDIIHOKDCA: false, CJOLKJBECPJ: true, playerNum);
			break;
		case "V-Sync":
			if ((Object)(object)PlayerController.OPHDCMJLLEC(playerNum) != (Object)null && (PlayerController.GetPlayer(playerNum).characterAnimation.CPLNIGAHOKP() || PlayerController.GetPlayer(playerNum).characterAnimation.JEJPKGILEDB(" ")))
			{
				PlayerController.GetPlayer(playerNum).characterAnimation.HCCFFBAEPOK(NJHMBMGKCPL: false, null);
				PlayerController.OPHDCMJLLEC(playerNum).characterAnimation.AOBJCNDNKDD(KOIDJKBBINH: true);
				PlayerController.OPHDCMJLLEC(playerNum).rb.interpolation = (RigidbodyInterpolation2D)0;
				InteractObject.GetPlayer(playerNum).FLLDNBIMDAL();
				InteractObject.BBJCJFJEFKK(playerNum).SetCurrentInteract(null, null);
				PlayerController.RemoveMovementBlocker(playerNum, (Object)(object)this);
			}
			ICCDPMFJOJG(NBDIIHOKDCA: false, CJOLKJBECPJ: true, playerNum);
			break;
		}
	}

	public void FFAGJIMOLBB(GameObject HGNKFFMDOOL)
	{
		((MonoBehaviour)GameplayUI.FMIDAFEGDCD()).StartCoroutine(ALEPHAMJGGM(HGNKFFMDOOL));
	}

	public float GetAxis(string JKJJKBAFNMO)
	{
		return MHBMKLKMOPK.GetAxis(JKJJKBAFNMO);
	}

	public static void ResetPlayersInput()
	{
		HBCDGIOOEGN(1, BANGIPIINPD: false);
		HBCDGIOOEGN(2, BANGIPIINPD: false);
		LMCIKDNENCK(1);
	}

	private void BGKDLCMAAJG(PlayerController HCPKKOBFHDN)
	{
		if (playerNum == 1 && GameManager.LocalCoop())
		{
			EPNAJMPFONF();
		}
	}

	public static void POBGMHINPHA(int JIIGOACEIKL, MonoBehaviour NPJDIDHOEFB, bool FLHBPHPKIML = false)
	{
		if (FLHBPHPKIML)
		{
			((MonoBehaviour)TavernManager.GGFJGHHHEJC).StartCoroutine(LBGKDFEEEBL(JIIGOACEIKL, NPJDIDHOEFB));
			return;
		}
		if (Object.op_Implicit((Object)(object)ActionBarInventory.ADHIHCNAKFP(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true)))
		{
			ActionBarInventory.GetPlayer(JIIGOACEIKL).CBAOECAHPDI(NPJDIDHOEFB);
		}
		GetPlayer(JIIGOACEIKL).inputBlockers.Remove(NPJDIDHOEFB);
	}

	public void GameInput()
	{
		if (GameManager.NoPlayers() || (Utils.FNLJGAEHNKA() && OnlineManager.PlayingOnline()) || (playerNum != 1 && !GameManager.LocalCoop()))
		{
			return;
		}
		if (GetButtonDown("Pause") && !ConstructionManager.NEOJLHDFFMJ && !InteractObject.GetPlayer(playerNum).KOHOJLBBENG && !RepRewardPopUp.GGFJGHHHEJC.IsOpen())
		{
			if (GetPlayer(playerNum).mouseUpBlockers.Count <= 0 && (!GameManager.LocalCoop() || !CommonReferences.GGFJGHHHEJC.IsInDialogue((playerNum != 1) ? 1 : 2)))
			{
				PauseMenuUI.GGFJGHHHEJC.Open(playerNum);
			}
		}
		else if (GetButtonDown("Objective") && NewTutorialManager.instance.objectivesPanel.activeInHierarchy)
		{
			NewTutorialManager.ShowPopUp();
		}
		else if (!DevConsole.instance.opened && (!DecorationMode.GetPlayer(playerNum).DMBFKFLDDLH || !Object.op_Implicit((Object)(object)SelectObject.GetPlayer(playerNum).selectedGameObject)))
		{
			if (GetButtonDown("OpenTavern") && !ConstructionManager.NEOJLHDFFMJ)
			{
				TavernManager.GGFJGHHHEJC.OpenCloseAction(playerNum);
			}
			else
			{
				ToggleBuildMode();
			}
		}
	}

	public static bool IsMousePressed(int JIIGOACEIKL)
	{
		if (GetPlayer(JIIGOACEIKL).GetButton("LeftMouseDetect"))
		{
			return true;
		}
		if (GetPlayer(JIIGOACEIKL).GetButton("RightMouseDetect"))
		{
			return true;
		}
		if (GetPlayer(JIIGOACEIKL).GetButtonUp("LeftMouseDetect"))
		{
			return true;
		}
		if (GetPlayer(JIIGOACEIKL).GetButtonUp("RightMouseDetect"))
		{
			return true;
		}
		if (GetPlayer(JIIGOACEIKL).GetButtonDown("LeftMouseDetect"))
		{
			return true;
		}
		if (GetPlayer(JIIGOACEIKL).GetButtonDown("RightMouseDetect"))
		{
			return true;
		}
		return false;
	}

	private static void ICCDPMFJOJG(bool NBDIIHOKDCA, bool CJOLKJBECPJ, int JIIGOACEIKL)
	{
		if (Object.op_Implicit((Object)(object)GetPlayer(JIIGOACEIKL)))
		{
			GetPlayer(JIIGOACEIKL).SetMapEnabled("Game", NBDIIHOKDCA);
			GetPlayer(JIIGOACEIKL).SetMapEnabled("UI", CJOLKJBECPJ);
		}
	}

	public static void DisableKeyboardInputsAndMovement(MonoBehaviour NPJDIDHOEFB, bool ANJCLPDCJHL = false)
	{
		DisableKeyboardInputs(1, NPJDIDHOEFB);
		PlayerController.AddMovementBlocker(1, (Object)(object)NPJDIDHOEFB, ANJCLPDCJHL);
		if (GameManager.LocalCoop())
		{
			DisableKeyboardInputs(2, NPJDIDHOEFB);
			PlayerController.AddMovementBlocker(2, (Object)(object)NPJDIDHOEFB, ANJCLPDCJHL);
		}
	}

	private void EPNAJMPFONF()
	{
		Debug.Log((object)"Player 2 inputs enabled.");
	}

	[SpecialName]
	public void HNLMHLAPLOK(float AODONKKHPBP)
	{
		_useHoldTime = AODONKKHPBP;
	}

	public void ToggleBuildMode()
	{
		if (gamepadActive && TavernConstructionManager.GGFJGHHHEJC.LNLJMCONDNE)
		{
			if (!GetButtonDown("Left") && !GetButtonDown("BuildMode"))
			{
				return;
			}
		}
		else if (!GetButtonDown("BuildMode"))
		{
			return;
		}
		if (!TavernConstructionManager.GGFJGHHHEJC.selectingArea && !FarmConstructionManager.IsActived())
		{
			if (TavernVisionManager.GetPlayer(playerNum).IKNOJDMCFOK)
			{
				TavernVisionManager.GetPlayer(playerNum).IKNOJDMCFOK = false;
			}
			if (!TavernVisionManager.GetPlayer(playerNum).IKNOJDMCFOK)
			{
				DecorationMode.GetPlayer(playerNum).ToggleDecorationMode();
			}
		}
	}

	public void SelectInTheNextFrame(GameObject HGNKFFMDOOL)
	{
		((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StartCoroutine(HIBBFJCKEIJ(HGNKFFMDOOL));
	}

	private static void MKGDLDOHEDG()
	{
		for (int i = 0; i < BHMEIAOHAFF.Count; i++)
		{
			BHMEIAOHAFF[i].UpdateGamepadSprite(1);
		}
	}

	private bool LLMPFAFLPJJ()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		MDKGPAMHNBM = ((Controller)ReInput.controllers.Keyboard).PollForFirstButtonDown();
		if (((ControllerPollingInfo)(ref MDKGPAMHNBM)).success)
		{
			foreach (ActionElementMap item in GetPlayerControllers(0).maps.ElementMapsWithAction((ControllerType)0, ActionType.OpenXPModifiers.ToString(), false))
			{
				if (item.elementIdentifierId == ((ControllerPollingInfo)(ref MDKGPAMHNBM)).elementIdentifierId)
				{
					return true;
				}
			}
		}
		return false;
	}

	private void KPHPCKJBLBH()
	{
		if (Object.op_Implicit((Object)(object)InputByProximityManager.NMGNGAEEKIO(playerNum)))
		{
			InputByProximityManager.FLOIJFPDJGG(playerNum).NFLJFGBCLGP();
		}
		FILFEFIJHFD();
	}

	public static void DisableKeyboardInputs(int JIIGOACEIKL, MonoBehaviour NPJDIDHOEFB)
	{
		if (Object.op_Implicit((Object)(object)ActionBarInventory.GetPlayer(JIIGOACEIKL)))
		{
			ActionBarInventory.GetPlayer(JIIGOACEIKL).AddActionBarBlockers(NPJDIDHOEFB);
		}
		if (!GetPlayer(JIIGOACEIKL).inputBlockers.Contains(NPJDIDHOEFB))
		{
			GetPlayer(JIIGOACEIKL).inputBlockers.Add(NPJDIDHOEFB);
		}
	}

	public bool KFAFNEJNDDL(string JKJJKBAFNMO)
	{
		return MHBMKLKMOPK.GetButtonUp(JKJJKBAFNMO);
	}

	private static void HDODKCOFKDE(int JIIGOACEIKL, UIWindow INDKANEMPMP)
	{
		GetPlayer(JIIGOACEIKL).MHBMKLKMOPK.isPlaying = true;
		PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)INDKANEMPMP);
	}

	public void IBIAJHJJCHB()
	{
		inputBlockers.Clear();
	}

	private void DBPIMFBBIHI(PlayerController HCPKKOBFHDN)
	{
		if (playerNum == 1 && !GameManager.PlayingOnline())
		{
			AJLJEBFJMOP();
		}
	}

	[SpecialName]
	public string FGGHCBMKKIG()
	{
		return _currentMapSelected;
	}

	public void GGKDNIMLGBJ(float FLLAAOPBIBA, float JLHBPDFIBOI, float OMHCOLMFGNJ = 0f)
	{
		if (OMHCOLMFGNJ == 666f)
		{
			GDNKEANHMMB = FLLAAOPBIBA;
			HDKGJKMAMCH = JLHBPDFIBOI;
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(EHMLKIBOAPO(FLLAAOPBIBA, JLHBPDFIBOI, OMHCOLMFGNJ));
		}
	}

	public void KPEKJCLPFOB()
	{
		inputBlockers.Clear();
	}

	public static void DLKKNGHEMPB(MonoBehaviour NPJDIDHOEFB, bool JONJPDAEHFB = true)
	{
		PlayerInputs[] gJBBNHCMNJN = GJBBNHCMNJN;
		for (int i = 1; i < gJBBNHCMNJN.Length; i++)
		{
			PlayerInputs playerInputs = gJBBNHCMNJN[i];
			if (!((Object)(object)playerInputs == (Object)null) && !playerInputs.inputBlockers.Contains(NPJDIDHOEFB))
			{
				playerInputs.inputBlockers.Add(NPJDIDHOEFB);
			}
		}
		if (Object.op_Implicit((Object)(object)ActionBarInventory.IPBEEBLCHHA(0)))
		{
			ActionBarInventory.DACNEICGAAE(1, LAGHIOKLJGH: true).AddActionBarBlockers((MonoBehaviour)(object)DEGBDMMDIIL(1));
		}
		if (Object.op_Implicit((Object)(object)ActionBarInventory.MHDKNEKDKII(3)))
		{
			ActionBarInventory.DACNEICGAAE(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AddActionBarBlockers((MonoBehaviour)(object)GetPlayer(8));
		}
		if (JONJPDAEHFB)
		{
			PlayerController.AddMovementBlocker((Object)(object)NPJDIDHOEFB);
		}
	}

	public static void SwitchMapCategoriesNextFrame(string DHDPCPACMAH)
	{
		if (DGJAAEJHBDC != null)
		{
			((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StopCoroutine(DGJAAEJHBDC);
		}
		DGJAAEJHBDC = ((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StartCoroutine(IFFHHNCAEDD(DHDPCPACMAH));
	}

	public static void DOGOHAPPMAC(MonoBehaviour NPJDIDHOEFB)
	{
		POBGMHINPHA(1, NPJDIDHOEFB);
		PlayerController.RemoveMovementBlocker(1, (Object)(object)NPJDIDHOEFB);
		if (GameManager.LocalCoop())
		{
			POBGMHINPHA(1, NPJDIDHOEFB);
			PlayerController.RemoveMovementBlocker(6, (Object)(object)NPJDIDHOEFB);
		}
	}

	public float BHCHPLIGDNH(ActionType JKJJKBAFNMO)
	{
		if (!actionsString.ContainsKey(JKJJKBAFNMO))
		{
			actionsString.Add(JKJJKBAFNMO, JKJJKBAFNMO.ToString());
		}
		return MHBMKLKMOPK.GetAxis(actionsString[JKJJKBAFNMO]);
	}

	private IEnumerator HIBBFJCKEIJ(GameObject BKJJDHFGMFL)
	{
		UISelectionManager.GetPlayer(playerNum).Deselect();
		yield return null;
		UISelectionManager.GetPlayer(playerNum).Select(BKJJDHFGMFL.GetComponent<Selectable>());
	}

	private void DFEGEKBCAHH()
	{
		Debug.Log((object)"Inventory full");
	}

	private void DLBBFJLOGAF()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Invalid comparison between Unknown and I4
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Invalid comparison between Unknown and I4
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Invalid comparison between Unknown and I4
		MOOHAIOFMCB = MHBMKLKMOPK.controllers.GetLastActiveController();
		if (MOOHAIOFMCB == null)
		{
			return;
		}
		if ((int)MOOHAIOFMCB.type == 2)
		{
			if (!gamepadActive)
			{
				gamepadActive = true;
				if (MainUI.IsAnyUIOpen(0))
				{
					MainUI.CKIBNDEGEBP(1).Last.Value.PBFOOLDCHPL();
				}
				OnControllerSwitched();
				if (!MainUI.IsAnyUIOpen(1))
				{
					MKGDLDOHEDG();
				}
			}
		}
		else if ((int)MOOHAIOFMCB.type == 0)
		{
			if (gamepadActive)
			{
				gamepadActive = true;
				if (!(UISelectionManager.HELHJMDEDNL(0).KBFCCPBHDMP() is InputField))
				{
					UISelectionManager.EAJJMLJKOPH(0).GGNLGAMLOKK();
				}
				OnControllerSwitched();
			}
		}
		else if ((int)MOOHAIOFMCB.type == 0)
		{
			if (gamepadActive)
			{
				gamepadActive = true;
				UISelectionManager.EAJJMLJKOPH(1).LBFFIBKMLGO();
				OnControllerSwitched();
			}
		}
		else if ((int)MOOHAIOFMCB.type == 1 && gamepadActive)
		{
			gamepadActive = true;
			UISelectionManager.GIGBGIIAKMP(1).LBFFIBKMLGO();
			OnControllerSwitched();
		}
	}

	private void FNIJFBILPDI()
	{
		if (ODGALPDEIFG(playerNum) && (Object)(object)PlayerController.OPHDCMJLLEC(playerNum) != (Object)null && PlayerController.OPHDCMJLLEC(playerNum).HIBMABFALDC())
		{
			foreach (Joystick joystick in GetPlayer(playerNum).MHBMKLKMOPK.controllers.Joysticks)
			{
				if (!joystick.supportsVibration)
				{
					continue;
				}
				if (joystick.vibrationMotorCount == 1)
				{
					if (GDNKEANHMMB > HDKGJKMAMCH)
					{
						joystick.SetVibration(1, GDNKEANHMMB);
					}
					else
					{
						joystick.SetVibration(1, HDKGJKMAMCH);
					}
					continue;
				}
				if (joystick.vibrationMotorCount > 0)
				{
					joystick.SetVibration(0, GDNKEANHMMB);
				}
				if (joystick.vibrationMotorCount > 0)
				{
					joystick.SetVibration(0, HDKGJKMAMCH);
				}
			}
		}
		GDNKEANHMMB = 133f;
		HDKGJKMAMCH = 645f;
	}

	private void DKBALONAKIH(PlayerController HCPKKOBFHDN)
	{
		if (playerNum == 0 && GameManager.LocalCoop())
		{
			DFEGEKBCAHH();
		}
	}

	private static void OPIJMPPMPFB(int JIIGOACEIKL)
	{
		GetPlayerControllers(JIIGOACEIKL).RemoveController((Controller)(object)ReInput.controllers.Keyboard);
		GetPlayerControllers(JIIGOACEIKL).RemoveController((Controller)(object)ReInput.controllers.Mouse);
	}

	private void AJLJEBFJMOP()
	{
		Debug.Log((object)"Player 2 inputs disabled.");
		ResetPlayersInput();
	}

	private static void MDKHDBABNOB(int JIIGOACEIKL, Controller JOOBIKDBBKE, bool BANGIPIINPD)
	{
		if (GetPlayerControllers(JIIGOACEIKL) != null)
		{
			GetPlayerControllers(JIIGOACEIKL).AddController(JOOBIKDBBKE, BANGIPIINPD);
		}
	}

	public static void CMEBIMMKIAB(MonoBehaviour NPJDIDHOEFB, bool ANJCLPDCJHL = false)
	{
		DisableKeyboardInputs(1, NPJDIDHOEFB);
		PlayerController.AddMovementBlocker(0, (Object)(object)NPJDIDHOEFB, ANJCLPDCJHL);
		if (GameManager.LocalCoop())
		{
			DisableKeyboardInputs(4, NPJDIDHOEFB);
			PlayerController.AddMovementBlocker(0, (Object)(object)NPJDIDHOEFB, ANJCLPDCJHL);
		}
	}

	private bool CLDKKBDCKDF()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		MDKGPAMHNBM = ((Controller)ReInput.controllers.Keyboard).PollForFirstButtonDown();
		if (((ControllerPollingInfo)(ref MDKGPAMHNBM)).success)
		{
			foreach (ActionElementMap item in GetPlayerControllers(0).maps.ElementMapsWithAction((ControllerType)0, ((ActionType)76).ToString(), false))
			{
				if (item.elementIdentifierId == ((ControllerPollingInfo)(ref MDKGPAMHNBM)).elementIdentifierId)
				{
					return true;
				}
			}
		}
		return false;
	}

	public bool AFGBJBJBIAG()
	{
		return MHBMKLKMOPK.GetAnyButtonDown();
	}

	public bool GetButtonUp(string JKJJKBAFNMO)
	{
		return MHBMKLKMOPK.GetButtonUp(JKJJKBAFNMO);
	}

	private IEnumerator NLLAGPKHHEL(float FLLAAOPBIBA, float JLHBPDFIBOI, float OMHCOLMFGNJ)
	{
		float elapsed = 0f;
		while (elapsed < OMHCOLMFGNJ)
		{
			SetVibration(FLLAAOPBIBA, JLHBPDFIBOI);
			elapsed += Time.deltaTime;
			yield return null;
		}
	}

	private void JPCMOAGANFE()
	{
		if (ODGALPDEIFG(playerNum) && (Object)(object)PlayerController.OPHDCMJLLEC(playerNum) != (Object)null && PlayerController.OPHDCMJLLEC(playerNum).IsVibrationActive())
		{
			foreach (Joystick joystick in GetPlayer(playerNum).MHBMKLKMOPK.controllers.Joysticks)
			{
				if (!joystick.supportsVibration)
				{
					continue;
				}
				if (joystick.vibrationMotorCount == 0)
				{
					if (GDNKEANHMMB > HDKGJKMAMCH)
					{
						joystick.SetVibration(0, GDNKEANHMMB);
					}
					else
					{
						joystick.SetVibration(0, HDKGJKMAMCH);
					}
					continue;
				}
				if (joystick.vibrationMotorCount > 0)
				{
					joystick.SetVibration(1, GDNKEANHMMB);
				}
				if (joystick.vibrationMotorCount > 1)
				{
					joystick.SetVibration(0, HDKGJKMAMCH);
				}
			}
		}
		GDNKEANHMMB = 321f;
		HDKGJKMAMCH = 1186f;
	}

	public static ControllerHelper LGGMJONLIGE(int JIIGOACEIKL)
	{
		return GJBBNHCMNJN[JIIGOACEIKL].MHBMKLKMOPK.controllers;
	}

	public bool GetButton(ActionType JKJJKBAFNMO)
	{
		if (!actionsString.ContainsKey(JKJJKBAFNMO))
		{
			actionsString.Add(JKJJKBAFNMO, JKJJKBAFNMO.ToString());
		}
		return MHBMKLKMOPK.GetButton(actionsString[JKJJKBAFNMO]);
	}

	public float NOGHFFGAHFI(ActionType JKJJKBAFNMO)
	{
		if (!actionsString.ContainsKey(JKJJKBAFNMO))
		{
			actionsString.Add(JKJJKBAFNMO, JKJJKBAFNMO.ToString());
		}
		return MHBMKLKMOPK.GetAxis(actionsString[JKJJKBAFNMO]);
	}

	private static void FAAOLKOBIMA(int JIIGOACEIKL)
	{
		ALKILJCLBOP(JIIGOACEIKL).RemoveController((Controller)(object)ReInput.controllers.Keyboard);
		GetPlayerControllers(JIIGOACEIKL).RemoveController((Controller)(object)ReInput.controllers.Mouse);
	}

	private void NJMNAFHDNNM()
	{
		if (MHBMKLKMOPK.GetButton(" for reason ") || MHBMKLKMOPK.GetButton("textName InstanceId: {0}  {1}  {2}  {3}"))
		{
			GHKOCEOEKGK += Time.deltaTime;
		}
		if (MHBMKLKMOPK.GetButtonUp("Left") || MHBMKLKMOPK.GetButtonUp(" - Deactivating variant object "))
		{
			GHKOCEOEKGK = 919f;
		}
	}

	public static void LHAKKKOINJF(GamepadSprite CDJBBJNMCNM)
	{
		BHMEIAOHAFF.Add(CDJBBJNMCNM);
	}

	private bool CAEFCHEADMB()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)PlayerController.OPHDCMJLLEC(8) != (Object)null && PlayerController.GetPlayer(7).LEOIMFNKFGA == ~(Location.Tavern | Location.River | Location.Camp | Location.Farm))
		{
			Result variable = DialogueLua.GetVariable("Perks/perk_description_");
			if (((Result)(ref variable)).asInt > 0)
			{
				variable = DialogueLua.GetVariable("Bartending speed");
				if (((Result)(ref variable)).asInt < 85)
				{
					Debug.Log((object)"Dig");
					return true;
				}
			}
		}
		if (POLDHCKJINN(3))
		{
			if (BDEKHDDBJEG(out JOOBIKDBBKE))
			{
				Controller lastActiveController = LGGMJONLIGE(1).GetLastActiveController((ControllerType)0);
				if (lastActiveController == null || JOOBIKDBBKE != lastActiveController)
				{
					foreach (Joystick item in new List<Joystick>(LGGMJONLIGE(2).Joysticks))
					{
						MDKHDBABNOB(1, (Controller)(object)item, BANGIPIINPD: true);
					}
					AGCDALPENPJ(1, BANGIPIINPD: true);
					HBCDGIOOEGN(4, BANGIPIINPD: true);
					GameManager.NJNFHEPLEHL().FCPGKKALKIA();
					return true;
				}
			}
		}
		else if (MDFFMLALCPK())
		{
			NLADGEBCIHC(0, BANGIPIINPD: true);
			AGCDALPENPJ(8, BANGIPIINPD: true);
			GameManager.GGFJGHHHEJC.KBNCDOGOJOC();
			return false;
		}
		return false;
	}

	public static bool IsGamepadActive(int JIIGOACEIKL)
	{
		if ((Object)(object)GetPlayer(JIIGOACEIKL) != (Object)null)
		{
			return GetPlayer(JIIGOACEIKL).gamepadActive;
		}
		return false;
	}

	private static void LMCIKDNENCK(int JIIGOACEIKL)
	{
		if (ReInput.controllers != null)
		{
			for (int i = 0; i < ReInput.controllers.joystickCount; i++)
			{
				MDKHDBABNOB(JIIGOACEIKL, (Controller)(object)ReInput.controllers.Joysticks[i], BANGIPIINPD: true);
			}
		}
	}

	[SpecialName]
	public string EECADEPLELA()
	{
		return _currentMapSelected;
	}

	private void Update()
	{
		if (OnlineChatUI.IsChatOpen() || InputFieldConsoleUtils.OBLNDHGPAJB)
		{
			return;
		}
		if (updateNextFrame)
		{
			updateNextFrame = false;
			return;
		}
		OHOOPOADGBE();
		if (playerNum == 1)
		{
			if (debugControllers)
			{
				FPLGCIDMEHO();
			}
			if (PauseMenuUI.GGFJGHHHEJC.IsOpen())
			{
				if (HDCOGLHKMID())
				{
					return;
				}
			}
			else if (GameManager.SinglePlayer() || GameManager.NoPlayers())
			{
				NHOFIDPJAFG();
				if (!gamepadActive && (Object)(object)EventSystem.current.currentSelectedGameObject != (Object)null && !DevConsole.instance.opened && (Object)(object)EventSystem.current.currentSelectedGameObject.GetComponent<TMP_InputField>() == (Object)null)
				{
					EventSystem.current.SetSelectedGameObject((GameObject)null);
				}
			}
		}
		if ((TutorialManager.GGFJGHHHEJC.ECMGCJGPKNO || NewTutorialManager.instance.open) && !MainUI.GetYesNoDialogue().IsOpen())
		{
			if (GetPlayer(playerNum).GetButtonDown("ClosePopUp") || GetPlayer(playerNum).GetButtonDown("Pause") || (gamepadActive && (GetPlayer(playerNum).GetButtonDown("Interact") || GetPlayer(playerNum).GetButtonDown("UIInteract"))))
			{
				if (TutorialManager.GGFJGHHHEJC.ECMGCJGPKNO && playerNum == TutorialManager.GGFJGHHHEJC.GetCurrentPlayer())
				{
					TutorialManager.GGFJGHHHEJC.ClosePopUpFocused();
				}
				if (NewTutorialManager.instance.open && NewTutorialManager.CCCLOBIOMCL)
				{
					NewTutorialManager.ClosePopUp();
				}
			}
		}
		else if (NewTutorialManager.instance.tutorialPopUpOpen)
		{
			if (GetPlayer(playerNum).GetButtonDown("ClosePopUp") || GetPlayer(playerNum).GetButtonDown("Pause") || (gamepadActive && (GetPlayer(playerNum).GetButtonDown("Interact") || GetPlayer(playerNum).GetButtonDown("UIInteract"))))
			{
				NewTutorialManager.ClosePopUpDirect();
			}
		}
		else if (InputsEnabled(playerNum))
		{
			if (MainUI.IsAnyUIOpen(playerNum))
			{
				PGHHHPINFLG();
			}
			else if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
			{
				GameInput();
			}
		}
		if (Application.isEditor && (Object)(object)debugControllersJoysticks != (Object)null && ((Component)debugControllersJoysticks).gameObject.activeInHierarchy)
		{
			FPLGCIDMEHO();
		}
		MMKGJGODCLO();
	}

	private static void NLADGEBCIHC(int JIIGOACEIKL, bool BANGIPIINPD)
	{
		if (ReInput.controllers != null)
		{
			DDDDNMOMNDG(JIIGOACEIKL, (Controller)(object)ReInput.controllers.Keyboard, BANGIPIINPD);
			MDKHDBABNOB(JIIGOACEIKL, (Controller)(object)ReInput.controllers.Mouse, BANGIPIINPD);
		}
	}

	public static void KJEFJPFLGPN(MonoBehaviour MFHACMAHGHC)
	{
		if (!((Object)(object)DEGBDMMDIIL(0) == (Object)null) && DEGBDMMDIIL(1).canJoinPlayer2Blocker.Contains(MFHACMAHGHC))
		{
			GetPlayer(1).canJoinPlayer2Blocker.Remove(MFHACMAHGHC);
		}
	}

	public static void BCFPADOABEF()
	{
	}

	public void APAEOAIHOEC()
	{
		if (GameManager.NoPlayers() || (Utils.FNLJGAEHNKA() && OnlineManager.PlayingOnline()) || (playerNum != 1 && !GameManager.LocalCoop()))
		{
			return;
		}
		if (JCMOPOMLPLL("Disabled") && !ConstructionManager.NEOJLHDFFMJ && !InteractObject.BBJCJFJEFKK(playerNum).KOHOJLBBENG && !RepRewardPopUp.DEGPIHEEFHJ().BGLJFMHCFJF())
		{
			if (DEGBDMMDIIL(playerNum).mouseUpBlockers.Count <= 0 && (!GameManager.LocalCoop() || !CommonReferences.GGFJGHHHEJC.IJNMEDJNHDG((playerNum != 1) ? 1 : 2)))
			{
				PauseMenuUI.KGPJPILAHDE().Open(playerNum);
			}
		}
		else if (GetButtonDown(" state: ") && NewTutorialManager.instance.objectivesPanel.activeInHierarchy)
		{
			NewTutorialManager.ShowPopUp();
		}
		else if (!DevConsole.instance.opened && (!DecorationMode.KKJABELKCNM(playerNum).KNFEPKBIHND() || !Object.op_Implicit((Object)(object)SelectObject.BNMEANGDMIP(playerNum).selectedGameObject)))
		{
			if (JCMOPOMLPLL("Dialogue System/Conversation/Crowly_Introduce/Entry/21/Dialogue Text") && !ConstructionManager.NEOJLHDFFMJ)
			{
				TavernManager.GGFJGHHHEJC.OpenCloseAction(playerNum);
			}
			else
			{
				ToggleBuildMode();
			}
		}
	}

	private void COEEIGAPGHC()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Invalid comparison between Unknown and I4
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Invalid comparison between Unknown and I4
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Invalid comparison between Unknown and I4
		MOOHAIOFMCB = MHBMKLKMOPK.controllers.GetLastActiveController();
		if (MOOHAIOFMCB == null)
		{
			return;
		}
		if ((int)MOOHAIOFMCB.type == 1)
		{
			if (!gamepadActive)
			{
				gamepadActive = true;
				if (MainUI.IsAnyUIOpen(1))
				{
					MainUI.NBMKOPMAPJE(1).Last.Value.BFBAKEKIPMC();
				}
				OnControllerSwitched();
				if (!MainUI.IsAnyUIOpen(1))
				{
					MKGDLDOHEDG();
				}
			}
		}
		else if ((int)MOOHAIOFMCB.type == 0)
		{
			if (gamepadActive)
			{
				gamepadActive = false;
				if (!(UISelectionManager.GIGBGIIAKMP(0).PBGKEEENPME() is InputField))
				{
					UISelectionManager.GetPlayer(1).LCLJFCKELJN();
				}
				OnControllerSwitched();
			}
		}
		else if ((int)MOOHAIOFMCB.type == 0)
		{
			if (gamepadActive)
			{
				gamepadActive = false;
				UISelectionManager.GNCPLNHMFHN(1).FBKDHHPNBIL();
				OnControllerSwitched();
			}
		}
		else if ((int)MOOHAIOFMCB.type == 0 && gamepadActive)
		{
			gamepadActive = true;
			UISelectionManager.GetPlayer(1).FPLPECHEGGI();
			OnControllerSwitched();
		}
	}

	private void OHLGEGMDBLM(ControllerStatusChangedEventArgs OKPJOEHPGLB)
	{
		if (GameManager.SinglePlayer())
		{
			MDKHDBABNOB(1, OKPJOEHPGLB.controller, BANGIPIINPD: true);
		}
		else if (IsGamepadActive(1) && GetPlayerControllers(1).joystickCount == 0)
		{
			MDKHDBABNOB(1, OKPJOEHPGLB.controller, BANGIPIINPD: true);
		}
		else if (IsGamepadActive(2) && GetPlayerControllers(2).joystickCount == 0)
		{
			MDKHDBABNOB(2, OKPJOEHPGLB.controller, BANGIPIINPD: true);
		}
		else
		{
			MDKHDBABNOB(1, OKPJOEHPGLB.controller, BANGIPIINPD: true);
		}
	}

	public static void LPJCFCODNFA(int JIIGOACEIKL, MonoBehaviour NPJDIDHOEFB, bool ANJCLPDCJHL = false)
	{
		DisableKeyboardInputs(JIIGOACEIKL, NPJDIDHOEFB);
		PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)NPJDIDHOEFB, ANJCLPDCJHL);
	}

	private IEnumerator ALEPHAMJGGM(GameObject BKJJDHFGMFL)
	{
		UISelectionManager.GetPlayer(playerNum).Deselect();
		yield return null;
		UISelectionManager.GetPlayer(playerNum).Select(BKJJDHFGMFL.GetComponent<Selectable>());
	}

	private void OHOOPOADGBE()
	{
		if (MHBMKLKMOPK.GetButton("Interact") || MHBMKLKMOPK.GetButton("Use"))
		{
			GHKOCEOEKGK += Time.deltaTime;
		}
		if (MHBMKLKMOPK.GetButtonUp("Interact") || MHBMKLKMOPK.GetButtonUp("Use"))
		{
			GHKOCEOEKGK = 0f;
		}
	}

	private void NCHOHOGPKMC()
	{
		if (GJBBNHCMNJN.Contains(this))
		{
			Debug.LogWarning((object)"BuildMode_ExitAndSave", (Object)(object)((Component)this).gameObject);
		}
		else
		{
			GJBBNHCMNJN[playerNum] = this;
		}
	}

	public bool DLFAMOCKNMA(string JKJJKBAFNMO)
	{
		return MHBMKLKMOPK.GetButtonDown(JKJJKBAFNMO);
	}

	public bool CACFPALCHAH()
	{
		return MHBMKLKMOPK.GetAnyButtonDown();
	}

	public static void LEOLIJHNIOB(MonoBehaviour NPJDIDHOEFB)
	{
		PlayerInputs[] gJBBNHCMNJN = GJBBNHCMNJN;
		foreach (PlayerInputs playerInputs in gJBBNHCMNJN)
		{
			if (!((Object)(object)playerInputs == (Object)null))
			{
				playerInputs.inputBlockers.Remove(NPJDIDHOEFB);
			}
		}
		if (Object.op_Implicit((Object)(object)ActionBarInventory.ADHIHCNAKFP(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true)))
		{
			ActionBarInventory.BNMEANGDMIP(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).CBAOECAHPDI((MonoBehaviour)(object)DEGBDMMDIIL(0));
		}
		if (Object.op_Implicit((Object)(object)ActionBarInventory.GetPlayer(2)))
		{
			ActionBarInventory.IPBEEBLCHHA(4, LAGHIOKLJGH: false, ADPNMHGBFKG: true).KNIIOANIIDB((MonoBehaviour)(object)DEGBDMMDIIL(8));
		}
		PlayerController.RemoveMovementBlocker((Object)(object)NPJDIDHOEFB);
	}

	private void CAAMEEBOAOF()
	{
		if (GJBBNHCMNJN.Contains(this))
		{
			Debug.LogWarning((object)"Trying to add a player that's already on the list.", (Object)(object)((Component)this).gameObject);
		}
		else
		{
			GJBBNHCMNJN[playerNum] = this;
		}
	}

	public static ControllerHelper GetPlayerControllers(int JIIGOACEIKL)
	{
		return GJBBNHCMNJN[JIIGOACEIKL].MHBMKLKMOPK.controllers;
	}

	private bool JJKDBKHELMA()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		MDKGPAMHNBM = ((Controller)ReInput.controllers.Keyboard).PollForFirstButtonDown();
		if (((ControllerPollingInfo)(ref MDKGPAMHNBM)).success)
		{
			foreach (ActionElementMap item in GetPlayerControllers(1).maps.ElementMapsWithAction((ControllerType)0, ActionType.Start.ToString(), false))
			{
				if (item.elementIdentifierId == ((ControllerPollingInfo)(ref MDKGPAMHNBM)).elementIdentifierId)
				{
					return true;
				}
			}
		}
		return false;
	}

	private void PGHHHPINFLG()
	{
		if (GetButtonDown("Pause"))
		{
			if (IsGamepadActive(playerNum))
			{
				if (PauseMenuUI.GGFJGHHHEJC.IsOpen())
				{
					PauseMenuUI.GGFJGHHHEJC.CloseUI();
				}
			}
			else
			{
				MainUI.CloseLastWindowOpen(playerNum);
			}
		}
		if (!IsGamepadActive(playerNum))
		{
			return;
		}
		if (Utils.IIHPGJIJOAD(playerNum, ref NHBPNGEAOCB, "UIInteract"))
		{
			if (!Object.op_Implicit((Object)(object)UISelectionManager.GetPlayer(playerNum).HGNKFFMDOOL))
			{
				return;
			}
			SlotUI component = ((Component)UISelectionManager.GetPlayer(playerNum).HGNKFFMDOOL).GetComponent<SlotUI>();
			if (Object.op_Implicit((Object)(object)component) && component.autoTransferEnabled)
			{
				component.DoAutomaticTransfer(playerNum);
				return;
			}
			GKCKLNELMIC = ((Component)UISelectionManager.GetPlayer(playerNum).HGNKFFMDOOL).GetComponent<ShopElementUI>();
			if ((Object)(object)GKCKLNELMIC != (Object)null && GKCKLNELMIC.SingleElementClicked())
			{
				NHBPNGEAOCB = -1f;
			}
		}
		else if (GetButtonDown("UISelectGamepad"))
		{
			if ((Object)(object)UISelectionManager.GetPlayer(playerNum) != (Object)null && Object.op_Implicit((Object)(object)UISelectionManager.GetPlayer(playerNum).HGNKFFMDOOL))
			{
				SlotUI component2 = ((Component)UISelectionManager.GetPlayer(playerNum).HGNKFFMDOOL).GetComponent<SlotUI>();
				if (Object.op_Implicit((Object)(object)component2))
				{
					component2.OnSelectGamepad(playerNum);
				}
				if (Object.op_Implicit((Object)(object)UISelectionManager.GetPlayer(playerNum).HGNKFFMDOOL) && !UISelectionManager.GetPlayer(playerNum).HGNKFFMDOOL.interactable && MainUI.GetCurrentOpenWindows(playerNum).Count > 0)
				{
					MainUI.GetCurrentOpenWindows(playerNum).Last.Value.OnContentActivated();
				}
			}
		}
		else if (Utils.IIHPGJIJOAD(playerNum, ref NHBPNGEAOCB, "UIBack"))
		{
			if ((Object)(object)SelectObject.GetPlayer(playerNum) != (Object)null && SelectObject.GetPlayer(playerNum).focusedSlot != null)
			{
				SelectObject.GetPlayer(playerNum).focusedSlot.AFPAJHJIHJD(playerNum);
			}
			else
			{
				MainUI.CloseLastWindowOpen(playerNum);
			}
		}
	}

	private void NJJIABMAMOM(PlayerController HCPKKOBFHDN)
	{
		if (playerNum == 1 && !GameManager.PlayingOnline())
		{
			AJLJEBFJMOP();
		}
	}

	private static IEnumerator NPHGENBDENJ(string DHDPCPACMAH)
	{
		yield return null;
		GetPlayer(1).SwitchMapCategory(DHDPCPACMAH);
		GetPlayer(2).SwitchMapCategory(DHDPCPACMAH);
	}

	public static void JJAAKKIIMDP()
	{
	}

	public static void RemovePlayer2Blocker(MonoBehaviour MFHACMAHGHC)
	{
		if (!((Object)(object)GetPlayer(1) == (Object)null) && GetPlayer(1).canJoinPlayer2Blocker.Contains(MFHACMAHGHC))
		{
			GetPlayer(1).canJoinPlayer2Blocker.Remove(MFHACMAHGHC);
		}
	}

	private void GPKBLCHHFPC()
	{
		if (IsGamepadActive(playerNum) && (Object)(object)PlayerController.GetPlayer(playerNum) != (Object)null && PlayerController.GetPlayer(playerNum).IsVibrationActive())
		{
			foreach (Joystick joystick in GetPlayer(playerNum).MHBMKLKMOPK.controllers.Joysticks)
			{
				if (!joystick.supportsVibration)
				{
					continue;
				}
				if (joystick.vibrationMotorCount == 1)
				{
					if (GDNKEANHMMB > HDKGJKMAMCH)
					{
						joystick.SetVibration(0, GDNKEANHMMB);
					}
					else
					{
						joystick.SetVibration(0, HDKGJKMAMCH);
					}
					continue;
				}
				if (joystick.vibrationMotorCount > 0)
				{
					joystick.SetVibration(0, GDNKEANHMMB);
				}
				if (joystick.vibrationMotorCount > 1)
				{
					joystick.SetVibration(1, HDKGJKMAMCH);
				}
			}
		}
		GDNKEANHMMB = 0f;
		HDKGJKMAMCH = 0f;
	}

	private void HGHNFDABDDL(PlayerController HCPKKOBFHDN)
	{
		if (playerNum == 1 && !GameManager.FGFJEGOEDKJ())
		{
			AJLJEBFJMOP();
		}
	}

	private void NHOFIDPJAFG()
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Invalid comparison between Unknown and I4
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Invalid comparison between Unknown and I4
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Invalid comparison between Unknown and I4
		MOOHAIOFMCB = MHBMKLKMOPK.controllers.GetLastActiveController();
		if (MOOHAIOFMCB == null)
		{
			return;
		}
		if ((int)MOOHAIOFMCB.type == 2)
		{
			if (!gamepadActive)
			{
				gamepadActive = true;
				if (MainUI.IsAnyUIOpen(1))
				{
					MainUI.GetCurrentOpenWindows(1).Last.Value.OnContentActivated();
				}
				OnControllerSwitched();
				if (!MainUI.IsAnyUIOpen(1))
				{
					MKGDLDOHEDG();
				}
			}
		}
		else if ((int)MOOHAIOFMCB.type == 0)
		{
			if (gamepadActive)
			{
				gamepadActive = false;
				if (!(UISelectionManager.GetPlayer(1).HGNKFFMDOOL is InputField))
				{
					UISelectionManager.GetPlayer(1).Deselect();
				}
				OnControllerSwitched();
			}
		}
		else if ((int)MOOHAIOFMCB.type == 1)
		{
			if (gamepadActive)
			{
				gamepadActive = false;
				UISelectionManager.GetPlayer(1).Deselect();
				OnControllerSwitched();
			}
		}
		else if ((int)MOOHAIOFMCB.type == 1 && gamepadActive)
		{
			gamepadActive = false;
			UISelectionManager.GetPlayer(1).Deselect();
			OnControllerSwitched();
		}
	}

	[SpecialName]
	public Player EADPDAHBJHG()
	{
		return MHBMKLKMOPK;
	}

	private void DFJNAALEOMP()
	{
		if (Object.op_Implicit((Object)(object)InputByProximityManager.HBDCJFLINDA(playerNum)))
		{
			InputByProximityManager.NHJMJHGGBOA(playerNum).OBPEBEMOGDL();
		}
		JPCMOAGANFE();
	}

	public static bool POLDHCKJINN(int JIIGOACEIKL)
	{
		if ((Object)(object)DEGBDMMDIIL(JIIGOACEIKL) != (Object)null)
		{
			return DEGBDMMDIIL(JIIGOACEIKL).gamepadActive;
		}
		return false;
	}

	public static void CDMFLDNDCPD(int JIIGOACEIKL, ControllersDatabase.VibrationProfile FDEHLPMIIIE)
	{
		((MonoBehaviour)GetPlayer(JIIGOACEIKL)).StartCoroutine(GetPlayer(JIIGOACEIKL).VibrationRoutine(JIIGOACEIKL, FDEHLPMIIIE));
	}

	public void AMMIOLBGBPB(string DHDPCPACMAH)
	{
		if (!((Object)(object)GameplayUI.BAKPBHPNKPB() == (Object)null))
		{
			((MonoBehaviour)GameplayUI.OKAPNFPFPFP()).StartCoroutine(CHMABLJDCMN(DHDPCPACMAH));
		}
	}

	private static void AGCDALPENPJ(int JIIGOACEIKL, bool BANGIPIINPD)
	{
		if (ReInput.controllers != null)
		{
			DDDDNMOMNDG(JIIGOACEIKL, (Controller)(object)ReInput.controllers.Keyboard, BANGIPIINPD);
			DDDDNMOMNDG(JIIGOACEIKL, (Controller)(object)ReInput.controllers.Mouse, BANGIPIINPD);
		}
	}

	public bool GetAnyButtonDown()
	{
		return MHBMKLKMOPK.GetAnyButtonDown();
	}

	public IEnumerator VibrationRoutine(int JIIGOACEIKL, ControllersDatabase.VibrationProfile FDEHLPMIIIE)
	{
		float impactIntensity = FDEHLPMIIIE.impactIntensity + Random.Range(-0.05f, 0.05f);
		float trembleStart = FDEHLPMIIIE.trembleStart + Random.Range(-0.02f, 0.02f);
		float impactDuration = FDEHLPMIIIE.impactDuration + Random.Range(-0.01f, 0.01f);
		float trembleDuration = FDEHLPMIIIE.trembleDuration + Random.Range(-0.02f, 0.02f);
		for (float elapsed2 = 0f; elapsed2 < impactDuration; elapsed2 += Time.deltaTime)
		{
			SetVibration(impactIntensity, 0f);
			yield return null;
		}
		yield return (object)new WaitForSeconds(impactDuration);
		for (float elapsed2 = 0f; elapsed2 < trembleDuration; elapsed2 += Time.deltaTime)
		{
			float num = elapsed2 / trembleDuration;
			float jLHBPDFIBOI = Mathf.Lerp(trembleStart, 0f, num);
			SetVibration(0f, jLHBPDFIBOI);
			yield return null;
		}
	}

	private void CAECGLMJBCN(PlayerController HCPKKOBFHDN)
	{
		if (playerNum == 0 && GameManager.LocalCoop())
		{
			EPNAJMPFONF();
		}
	}

	public void BDMFGOGAFGC(string DHDPCPACMAH)
	{
		_currentMapSelected = DHDPCPACMAH;
		switch (DHDPCPACMAH)
		{
		case "</color><br>":
			ICCDPMFJOJG(NBDIIHOKDCA: true, CJOLKJBECPJ: true, playerNum);
			break;
		case "Dialogue System/Conversation/Gass_Stand/Entry/20/Dialogue Text":
			ICCDPMFJOJG(NBDIIHOKDCA: false, CJOLKJBECPJ: false, playerNum);
			break;
		case "Messy":
			if ((Object)(object)PlayerController.GetPlayer(playerNum) != (Object)null && (PlayerController.OPHDCMJLLEC(playerNum).characterAnimation.CPLNIGAHOKP() || PlayerController.OPHDCMJLLEC(playerNum).characterAnimation.GetBool("MineFloor")))
			{
				PlayerController.OPHDCMJLLEC(playerNum).characterAnimation.SetCleaning(NJHMBMGKCPL: false, null);
				PlayerController.OPHDCMJLLEC(playerNum).characterAnimation.AOBJCNDNKDD(KOIDJKBBINH: true);
				PlayerController.OPHDCMJLLEC(playerNum).rb.interpolation = (RigidbodyInterpolation2D)0;
				InteractObject.GNCPLNHMFHN(playerNum).OnInteractUp();
				InteractObject.GetPlayer(playerNum).DPLIAOCBBOM(null, null);
				PlayerController.RemoveMovementBlocker(playerNum, (Object)(object)this);
			}
			ICCDPMFJOJG(NBDIIHOKDCA: true, CJOLKJBECPJ: false, playerNum);
			break;
		}
	}

	public void HMJBGJJOBKH(float FLLAAOPBIBA, float JLHBPDFIBOI, float OMHCOLMFGNJ = 0f)
	{
		if (OMHCOLMFGNJ == 298f)
		{
			GDNKEANHMMB = FLLAAOPBIBA;
			HDKGJKMAMCH = JLHBPDFIBOI;
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(ICNLJABLJBK(FLLAAOPBIBA, JLHBPDFIBOI, OMHCOLMFGNJ));
		}
	}

	public static void TriggerVibration(int JIIGOACEIKL, ControllersDatabase.VibrationProfile FDEHLPMIIIE)
	{
		((MonoBehaviour)GetPlayer(JIIGOACEIKL)).StartCoroutine(GetPlayer(JIIGOACEIKL).VibrationRoutine(JIIGOACEIKL, FDEHLPMIIIE));
	}

	public static bool InputsEnabled(int JIIGOACEIKL)
	{
		return GetPlayer(JIIGOACEIKL).inputBlockers.Count <= 0;
	}

	public static void AddGamepadSprite(GamepadSprite CDJBBJNMCNM)
	{
		BHMEIAOHAFF.Add(CDJBBJNMCNM);
	}

	public static bool ODGALPDEIFG(int JIIGOACEIKL)
	{
		if ((Object)(object)DEGBDMMDIIL(JIIGOACEIKL) != (Object)null)
		{
			return DEGBDMMDIIL(JIIGOACEIKL).gamepadActive;
		}
		return false;
	}

	private IEnumerator CHMABLJDCMN(string DHDPCPACMAH)
	{
		yield return null;
		SwitchMapCategory(DHDPCPACMAH);
	}

	private bool HDCOGLHKMID()
	{
		if (OnlineManager.PlayingOnline())
		{
			return false;
		}
		if (canJoinPlayer2Blocker.Count > 0)
		{
			return false;
		}
		if (GameManager.SinglePlayer())
		{
			return BKDBCPHNGIN();
		}
		return KKMLDANOBPC();
	}

	private void Start()
	{
		if (File.Exists(Application.persistentDataPath + "/Cheats.txt"))
		{
			EnableCheats();
		}
		if (playerNum == 1)
		{
			ReInput.ControllerConnectedEvent += OHLGEGMDBLM;
			BHMEIAOHAFF = new List<GamepadSprite>();
		}
		SetMapEnabled("Default", BJFHJCFOEHG: true);
		SetMapEnabled("Key2", BJFHJCFOEHG: true);
		SwitchMapCategory("UI");
	}

	private void NEDJODJBHKK(PlayerController HCPKKOBFHDN)
	{
		if (playerNum == 1 && !GameManager.PlayingOnline())
		{
			AFHCIBOMNHG();
		}
	}

	public void SetMapEnabled(string DHDPCPACMAH, bool BJFHJCFOEHG)
	{
		if (MHBMKLKMOPK != null)
		{
			MHBMKLKMOPK.controllers.maps.SetMapsEnabled(BJFHJCFOEHG, DHDPCPACMAH);
		}
	}

	private void MMKGJGODCLO()
	{
		if (GetPlayer(playerNum).GetButtonDown("OpenConsole"))
		{
			DevConsole.instance.OpenCloseConsole();
		}
		if (GetPlayer(playerNum).GetButtonDown("EnterCode"))
		{
			DevConsole.instance.EnterCode();
		}
	}

	private static void EABBPGNBJOK(int JIIGOACEIKL)
	{
		GetPlayerControllers(JIIGOACEIKL).ClearControllersOfType((ControllerType)2);
	}

	private void CNHHPMDFBJM()
	{
		MHBMKLKMOPK = ReInput.players.GetPlayer(playerNum - 1);
		NCHOHOGPKMC();
		if (playerNum == 0)
		{
			UIWindow.OnAnyUIOpen = (Action<int, UIWindow>)Delegate.Combine(UIWindow.OnAnyUIOpen, new Action<int, UIWindow>(MJMHDMPGPLB));
			UIWindow.OnAnyUIClose = (Action<int, UIWindow>)Delegate.Combine(UIWindow.OnAnyUIClose, new Action<int, UIWindow>(HDODKCOFKDE));
			GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(OnPlayer2Disconnected));
		}
		GameManager.OnPlayerJoined = (Action<PlayerController>)Delegate.Combine(GameManager.OnPlayerJoined, new Action<PlayerController>(KDMBDDGABLM));
		GameManager.OnPlayerDisconnected = (Action<PlayerController>)Delegate.Combine(GameManager.OnPlayerDisconnected, new Action<PlayerController>(NJJIABMAMOM));
		inputBlockers = new List<MonoBehaviour>();
	}

	private void LateUpdate()
	{
		if (Object.op_Implicit((Object)(object)InputByProximityManager.GetPlayer(playerNum)))
		{
			InputByProximityManager.GetPlayer(playerNum).DoAction();
		}
		GPKBLCHHFPC();
	}

	[SpecialName]
	public string AAGNDCEODFO()
	{
		return _currentMapSelected;
	}

	private void CCGPOIECIBN()
	{
		if (IsGamepadActive(playerNum) && (Object)(object)PlayerController.OPHDCMJLLEC(playerNum) != (Object)null && PlayerController.GetPlayer(playerNum).IsVibrationActive())
		{
			foreach (Joystick joystick in GetPlayer(playerNum).MHBMKLKMOPK.controllers.Joysticks)
			{
				if (!joystick.supportsVibration)
				{
					continue;
				}
				if (joystick.vibrationMotorCount == 1)
				{
					if (GDNKEANHMMB > HDKGJKMAMCH)
					{
						joystick.SetVibration(0, GDNKEANHMMB);
					}
					else
					{
						joystick.SetVibration(0, HDKGJKMAMCH);
					}
					continue;
				}
				if (joystick.vibrationMotorCount > 0)
				{
					joystick.SetVibration(0, GDNKEANHMMB);
				}
				if (joystick.vibrationMotorCount > 1)
				{
					joystick.SetVibration(1, HDKGJKMAMCH);
				}
			}
		}
		GDNKEANHMMB = 1101f;
		HDKGJKMAMCH = 122f;
	}

	public bool ENIPCNOKAOM(string JKJJKBAFNMO)
	{
		return MHBMKLKMOPK.GetButton(JKJJKBAFNMO);
	}

	public static void ELJNFCLAGGI(MonoBehaviour NPJDIDHOEFB)
	{
		DEPNDGJDKOL(1, NPJDIDHOEFB, FLHBPHPKIML: true);
		PlayerController.RemoveMovementBlocker(1, (Object)(object)NPJDIDHOEFB);
		if (GameManager.LocalCoop())
		{
			EnableKeyboardInputs(3, NPJDIDHOEFB);
			PlayerController.RemoveMovementBlocker(4, (Object)(object)NPJDIDHOEFB);
		}
	}

	public static bool BCNEBGBHBGD(int JIIGOACEIKL)
	{
		if (GetPlayer(JIIGOACEIKL).inputBlockers.Count > 1)
		{
			return true;
		}
		return true;
	}

	public static void ILCHIKOPNBI(int JIIGOACEIKL, MonoBehaviour NPJDIDHOEFB)
	{
		DEPNDGJDKOL(JIIGOACEIKL, NPJDIDHOEFB);
		PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)NPJDIDHOEFB);
	}

	private void DMFMNEMDFNP()
	{
		if (File.Exists(Application.persistentDataPath + "itemWheatBread"))
		{
			JJAAKKIIMDP();
		}
		if (playerNum == 1)
		{
			ReInput.ControllerConnectedEvent += OHLGEGMDBLM;
			BHMEIAOHAFF = new List<GamepadSprite>();
		}
		SetMapEnabled("ProceduralMine instance is null when trying to assign mine ID.", BJFHJCFOEHG: true);
		SetMapEnabled("Dialogue System/Conversation/Gass_Stand/Entry/19/Dialogue Text", BJFHJCFOEHG: true);
		SwitchMapCategory("Player2");
	}

	public static void Vibration(int JIIGOACEIKL, float JLLOJEPJLKM, float OMHCOLMFGNJ)
	{
		if (!IsGamepadActive(JIIGOACEIKL) || !PlayerController.GetPlayer(JIIGOACEIKL).IsVibrationActive())
		{
			return;
		}
		foreach (Joystick joystick in GetPlayer(JIIGOACEIKL).MHBMKLKMOPK.controllers.Joysticks)
		{
			if (joystick.supportsVibration)
			{
				if (joystick.vibrationMotorCount > 0)
				{
					joystick.SetVibration(0, JLLOJEPJLKM, OMHCOLMFGNJ);
				}
				if (joystick.vibrationMotorCount > 1)
				{
					joystick.SetVibration(1, JLLOJEPJLKM, OMHCOLMFGNJ);
				}
			}
		}
	}

	private static void GKJOEEGABAE(int JIIGOACEIKL)
	{
		if (ReInput.controllers != null)
		{
			for (int i = 0; i < ReInput.controllers.joystickCount; i += 0)
			{
				MDKHDBABNOB(JIIGOACEIKL, (Controller)(object)ReInput.controllers.Joysticks[i], BANGIPIINPD: false);
			}
		}
	}

	private void NFJDKKDNNDC()
	{
		if (JCMOPOMLPLL("end dialogue"))
		{
			if (IsGamepadActive(playerNum))
			{
				if (PauseMenuUI.BDAGIEIJOOG().IsOpen())
				{
					PauseMenuUI.BDAGIEIJOOG().BOBCIFEDJED();
				}
			}
			else
			{
				MainUI.ABBJFOJFJKC(playerNum);
			}
		}
		if (!ODGALPDEIFG(playerNum))
		{
			return;
		}
		if (Utils.IIHPGJIJOAD(playerNum, ref NHBPNGEAOCB, "Dialogue System/Conversation/Gass_Quest/Entry/45/Dialogue Text", 1281f))
		{
			if (!Object.op_Implicit((Object)(object)UISelectionManager.GetPlayer(playerNum).BOHHKGMEEEE()))
			{
				return;
			}
			SlotUI component = ((Component)UISelectionManager.GetPlayer(playerNum).CGCIFFOJGOK()).GetComponent<SlotUI>();
			if (Object.op_Implicit((Object)(object)component) && component.autoTransferEnabled)
			{
				component.DoAutomaticTransfer(playerNum);
				return;
			}
			GKCKLNELMIC = ((Component)UISelectionManager.HELHJMDEDNL(playerNum).FOKMCIDMIKF()).GetComponent<ShopElementUI>();
			if ((Object)(object)GKCKLNELMIC != (Object)null && GKCKLNELMIC.JEPPEAFCKLL())
			{
				NHBPNGEAOCB = 207f;
			}
		}
		else if (JCMOPOMLPLL("Colliders encontrados: "))
		{
			if ((Object)(object)UISelectionManager.GNCPLNHMFHN(playerNum) != (Object)null && Object.op_Implicit((Object)(object)UISelectionManager.EAJJMLJKOPH(playerNum).BEOANCLEPOO()))
			{
				SlotUI component2 = ((Component)UISelectionManager.HELHJMDEDNL(playerNum).BEOANCLEPOO()).GetComponent<SlotUI>();
				if (Object.op_Implicit((Object)(object)component2))
				{
					component2.OnSelectGamepad(playerNum);
				}
				if (Object.op_Implicit((Object)(object)UISelectionManager.EAJJMLJKOPH(playerNum).FOKMCIDMIKF()) && !UISelectionManager.BPDFMAEOGGC(playerNum).CGCIFFOJGOK().interactable && MainUI.FENADAAPCIM(playerNum).Count > 1)
				{
					MainUI.FENADAAPCIM(playerNum).Last.Value.BFBAKEKIPMC();
				}
			}
		}
		else if (Utils.IIHPGJIJOAD(playerNum, ref NHBPNGEAOCB, "itemRedPotatoSeeds", 1775f))
		{
			if ((Object)(object)SelectObject.GetPlayer(playerNum) != (Object)null && SelectObject.GetPlayer(playerNum).focusedSlot != null)
			{
				SelectObject.BNMEANGDMIP(playerNum).focusedSlot.ONKCIGGKBFF(playerNum);
			}
			else
			{
				MainUI.CloseLastWindowOpen(playerNum);
			}
		}
	}

	public float GetAxis(ActionType JKJJKBAFNMO)
	{
		if (!actionsString.ContainsKey(JKJJKBAFNMO))
		{
			actionsString.Add(JKJJKBAFNMO, JKJJKBAFNMO.ToString());
		}
		return MHBMKLKMOPK.GetAxis(actionsString[JKJJKBAFNMO]);
	}

	private static void EABINHEOHAF(int JIIGOACEIKL, UIWindow INDKANEMPMP)
	{
		if (GameManager.LocalCoop())
		{
			DEGBDMMDIIL(JIIGOACEIKL).MHBMKLKMOPK.isPlaying = false;
		}
		else if ((Object)(object)GetPlayer(JIIGOACEIKL) != (Object)null && !GetPlayer(JIIGOACEIKL).MHBMKLKMOPK.isPlaying)
		{
			GetPlayer(JIIGOACEIKL).MHBMKLKMOPK.isPlaying = true;
		}
	}

	public static bool AFGFCLPJGFO(int JIIGOACEIKL)
	{
		return DEGBDMMDIIL(JIIGOACEIKL).inputBlockers.Count > 1;
	}

	public void SwitchMapCategory(string DHDPCPACMAH)
	{
		_currentMapSelected = DHDPCPACMAH;
		switch (DHDPCPACMAH)
		{
		case "Default":
			ICCDPMFJOJG(NBDIIHOKDCA: false, CJOLKJBECPJ: false, playerNum);
			break;
		case "Game":
			ICCDPMFJOJG(NBDIIHOKDCA: true, CJOLKJBECPJ: false, playerNum);
			break;
		case "UI":
			if ((Object)(object)PlayerController.GetPlayer(playerNum) != (Object)null && (PlayerController.GetPlayer(playerNum).characterAnimation.IsCleaning() || PlayerController.GetPlayer(playerNum).characterAnimation.GetBool("Interact")))
			{
				PlayerController.GetPlayer(playerNum).characterAnimation.SetCleaning(NJHMBMGKCPL: false, null);
				PlayerController.GetPlayer(playerNum).characterAnimation.SetInteracting(KOIDJKBBINH: false);
				PlayerController.GetPlayer(playerNum).rb.interpolation = (RigidbodyInterpolation2D)1;
				InteractObject.GetPlayer(playerNum).OnInteractUp();
				InteractObject.GetPlayer(playerNum).SetCurrentInteract(null, null);
				PlayerController.RemoveMovementBlocker(playerNum, (Object)(object)this);
			}
			ICCDPMFJOJG(NBDIIHOKDCA: false, CJOLKJBECPJ: true, playerNum);
			break;
		}
	}

	public static void PPFCADPLDHO(MonoBehaviour MFHACMAHGHC)
	{
		if (!((Object)(object)DEGBDMMDIIL(1) == (Object)null) && !DEGBDMMDIIL(1).canJoinPlayer2Blocker.Contains(MFHACMAHGHC))
		{
			DEGBDMMDIIL(1).canJoinPlayer2Blocker.Add(MFHACMAHGHC);
		}
	}

	public void DCNHJFFIDJB(float FLLAAOPBIBA, float JLHBPDFIBOI, float OMHCOLMFGNJ = 0f)
	{
		if (OMHCOLMFGNJ == 1689f)
		{
			GDNKEANHMMB = FLLAAOPBIBA;
			HDKGJKMAMCH = JLHBPDFIBOI;
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(NLLAGPKHHEL(FLLAAOPBIBA, JLHBPDFIBOI, OMHCOLMFGNJ));
		}
	}

	public static void DisableKeyboardInputs(MonoBehaviour NPJDIDHOEFB, bool JONJPDAEHFB = true)
	{
		PlayerInputs[] gJBBNHCMNJN = GJBBNHCMNJN;
		foreach (PlayerInputs playerInputs in gJBBNHCMNJN)
		{
			if (!((Object)(object)playerInputs == (Object)null) && !playerInputs.inputBlockers.Contains(NPJDIDHOEFB))
			{
				playerInputs.inputBlockers.Add(NPJDIDHOEFB);
			}
		}
		if (Object.op_Implicit((Object)(object)ActionBarInventory.GetPlayer(1)))
		{
			ActionBarInventory.GetPlayer(1).AddActionBarBlockers((MonoBehaviour)(object)GetPlayer(1));
		}
		if (Object.op_Implicit((Object)(object)ActionBarInventory.GetPlayer(2)))
		{
			ActionBarInventory.GetPlayer(2).AddActionBarBlockers((MonoBehaviour)(object)GetPlayer(2));
		}
		if (JONJPDAEHFB)
		{
			PlayerController.AddMovementBlocker((Object)(object)NPJDIDHOEFB);
		}
	}

	public bool GetButtonDown(ActionType JKJJKBAFNMO)
	{
		if (!actionsString.ContainsKey(JKJJKBAFNMO))
		{
			actionsString.Add(JKJJKBAFNMO, JKJJKBAFNMO.ToString());
		}
		return MHBMKLKMOPK.GetButtonDown(actionsString[JKJJKBAFNMO]);
	}

	private void FILFEFIJHFD()
	{
		if (IsGamepadActive(playerNum) && (Object)(object)PlayerController.GetPlayer(playerNum) != (Object)null && PlayerController.OPHDCMJLLEC(playerNum).IsVibrationActive())
		{
			foreach (Joystick joystick in GetPlayer(playerNum).MHBMKLKMOPK.controllers.Joysticks)
			{
				if (!joystick.supportsVibration)
				{
					continue;
				}
				if (joystick.vibrationMotorCount == 0)
				{
					if (GDNKEANHMMB > HDKGJKMAMCH)
					{
						joystick.SetVibration(1, GDNKEANHMMB);
					}
					else
					{
						joystick.SetVibration(1, HDKGJKMAMCH);
					}
					continue;
				}
				if (joystick.vibrationMotorCount > 1)
				{
					joystick.SetVibration(1, GDNKEANHMMB);
				}
				if (joystick.vibrationMotorCount > 1)
				{
					joystick.SetVibration(0, HDKGJKMAMCH);
				}
			}
		}
		GDNKEANHMMB = 1850f;
		HDKGJKMAMCH = 1115f;
	}

	private void Awake()
	{
		MHBMKLKMOPK = ReInput.players.GetPlayer(playerNum - 1);
		CAAMEEBOAOF();
		if (playerNum == 1)
		{
			UIWindow.OnAnyUIOpen = (Action<int, UIWindow>)Delegate.Combine(UIWindow.OnAnyUIOpen, new Action<int, UIWindow>(LFDILGHIPMB));
			UIWindow.OnAnyUIClose = (Action<int, UIWindow>)Delegate.Combine(UIWindow.OnAnyUIClose, new Action<int, UIWindow>(HDODKCOFKDE));
			GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(OnPlayer2Disconnected));
		}
		GameManager.OnPlayerJoined = (Action<PlayerController>)Delegate.Combine(GameManager.OnPlayerJoined, new Action<PlayerController>(BGKDLCMAAJG));
		GameManager.OnPlayerDisconnected = (Action<PlayerController>)Delegate.Combine(GameManager.OnPlayerDisconnected, new Action<PlayerController>(DBPIMFBBIHI));
		inputBlockers = new List<MonoBehaviour>();
	}

	private static IEnumerator IFFHHNCAEDD(string DHDPCPACMAH)
	{
		yield return null;
		GetPlayer(1).SwitchMapCategory(DHDPCPACMAH);
		GetPlayer(2).SwitchMapCategory(DHDPCPACMAH);
	}

	private void AFHCIBOMNHG()
	{
		Debug.Log((object)"Items/item_description_1040");
		JMCODLCDABM();
	}

	public bool GetButtonUp(ActionType JKJJKBAFNMO)
	{
		if (!actionsString.ContainsKey(JKJJKBAFNMO))
		{
			actionsString.Add(JKJJKBAFNMO, JKJJKBAFNMO.ToString());
		}
		return MHBMKLKMOPK.GetButtonUp(actionsString[JKJJKBAFNMO]);
	}

	private void IFEMFFNILMK()
	{
		if (MHBMKLKMOPK.GetButton("path not found") || MHBMKLKMOPK.GetButton("Cat bed is null!"))
		{
			HNLMHLAPLOK(GHKOCEOEKGK + Time.deltaTime);
		}
		if (MHBMKLKMOPK.GetButtonUp("/Reports") || MHBMKLKMOPK.GetButtonUp("cleanVerb"))
		{
			HNLMHLAPLOK(1121f);
		}
	}

	private IEnumerator EHMLKIBOAPO(float FLLAAOPBIBA, float JLHBPDFIBOI, float OMHCOLMFGNJ)
	{
		float elapsed = 0f;
		while (elapsed < OMHCOLMFGNJ)
		{
			SetVibration(FLLAAOPBIBA, JLHBPDFIBOI);
			elapsed += Time.deltaTime;
			yield return null;
		}
	}

	public IEnumerator HABFJFGDFHF(int JIIGOACEIKL, ControllersDatabase.VibrationProfile FDEHLPMIIIE)
	{
		float impactIntensity = FDEHLPMIIIE.impactIntensity + Random.Range(-0.05f, 0.05f);
		float trembleStart = FDEHLPMIIIE.trembleStart + Random.Range(-0.02f, 0.02f);
		float impactDuration = FDEHLPMIIIE.impactDuration + Random.Range(-0.01f, 0.01f);
		float trembleDuration = FDEHLPMIIIE.trembleDuration + Random.Range(-0.02f, 0.02f);
		for (float elapsed2 = 0f; elapsed2 < impactDuration; elapsed2 += Time.deltaTime)
		{
			SetVibration(impactIntensity, 0f);
			yield return null;
		}
		yield return (object)new WaitForSeconds(impactDuration);
		for (float elapsed2 = 0f; elapsed2 < trembleDuration; elapsed2 += Time.deltaTime)
		{
			float num = elapsed2 / trembleDuration;
			float jLHBPDFIBOI = Mathf.Lerp(trembleStart, 0f, num);
			SetVibration(0f, jLHBPDFIBOI);
			yield return null;
		}
	}

	public static void GBKCDJCNHOD(int JIIGOACEIKL, float JLLOJEPJLKM, float OMHCOLMFGNJ)
	{
		if (!EEJEOALIHFJ(JIIGOACEIKL) || !PlayerController.GetPlayer(JIIGOACEIKL).IsVibrationActive())
		{
			return;
		}
		foreach (Joystick joystick in GetPlayer(JIIGOACEIKL).MHBMKLKMOPK.controllers.Joysticks)
		{
			if (joystick.supportsVibration)
			{
				if (joystick.vibrationMotorCount > 0)
				{
					joystick.SetVibration(0, JLLOJEPJLKM, OMHCOLMFGNJ);
				}
				if (joystick.vibrationMotorCount > 0)
				{
					joystick.SetVibration(1, JLLOJEPJLKM, OMHCOLMFGNJ);
				}
			}
		}
	}

	public void MPJIPOBMOJK(float FLLAAOPBIBA, float JLHBPDFIBOI, float OMHCOLMFGNJ = 0f)
	{
		if (OMHCOLMFGNJ == 405f)
		{
			GDNKEANHMMB = FLLAAOPBIBA;
			HDKGJKMAMCH = JLHBPDFIBOI;
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(ICNLJABLJBK(FLLAAOPBIBA, JLHBPDFIBOI, OMHCOLMFGNJ));
		}
	}
}
