using Steamworks;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[AddComponentMenu("UI/TextMeshPro - Input Field With Console Support", 12)]
[RequireComponent(typeof(TMP_InputField))]
public class TMP_InputFieldConsoleSupport : MonoBehaviour
{
	private TMP_InputField HJGEDECNFAO;

	[SerializeField]
	[Tooltip("Some input fields, like the character creator ones, require navigation, but will become unresponsive after typing on a keyboard because the game will switch to keyboard mode.\nThis option will let us define navigation for console but disable it on non-console builds.\n OFF by default (single line input fields). Turn ON if there are multiple interactable UI elements on the content containing it.")]
	private bool disableNavigationIfNotConsole;

	[SerializeField]
	private bool selectOnEnable;

	[SerializeField]
	private bool selectOnEnableForPlayer2;

	[SerializeField]
	[Tooltip("Description which will be used in the system's keyboard to inform the player what the input is for. This is optional but recommended.")]
	public string description;

	[Tooltip("Localization system key for the input field's description, which will be used in the system keyboard to inform the player what the input is for. This is optional but recommended. This will override the description field if it's set.")]
	[SerializeField]
	private string textID;

	private string BCMLDIACGHL;

	private Callback<GamepadTextInputDismissed_t> ODIPHHGGGDE;

	private Callback<FloatingGamepadTextInputDismissed_t> OBAJPPBFNKJ;

	private void CNGELJKEHCP(string OCKBNMGOPCL)
	{
		if (Utils.ILLKGGBHMLF() == PlatformOS.WindowsSteam)
		{
			Debug.LogError((object)("UpgradeToLevel" + OCKBNMGOPCL), (Object)(object)((Component)this).gameObject);
		}
		InputFieldConsoleUtils.GDMKBCKMJNM(HJGEDECNFAO, description, (uint)HJGEDECNFAO.characterLimit);
	}

	private void AKPGEHEBHNB(GamepadTextInputDismissed_t ENEJBCKMDCP)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)InputFieldConsoleUtils.HBCBGBCHDDN != (Object)(object)HJGEDECNFAO) && ENEJBCKMDCP.m_bSubmitted)
		{
			string text = default(string);
			if (!SteamUtils.GetEnteredGamepadTextInput(ref text, SteamUtils.GetEnteredGamepadTextLength()))
			{
				Debug.LogError((object)"There was an error reading the input text. Most likely incorrect length.");
				return;
			}
			HJGEDECNFAO.text = text;
			((UnityEvent<string>)(object)HJGEDECNFAO.onSubmit).Invoke(text);
		}
	}

	private void OLDDEAJMHNI()
	{
		HJHHBBJHMLK();
	}

	private void FAPNDDKPPJD(string OCKBNMGOPCL)
	{
		if (Utils.ILLKGGBHMLF() == PlatformOS.Linux)
		{
			Debug.LogError((object)("ChatBarkRPC" + OCKBNMGOPCL), (Object)(object)((Component)this).gameObject);
		}
		InputFieldConsoleUtils.OGLGPCNAOPL(HJGEDECNFAO, description, (uint)HJGEDECNFAO.characterLimit);
	}

	private void NBBFLJNPLEA()
	{
		IGJPFBMGJJM();
		if (PlayerInputs.EEJEOALIHFJ(1) && selectOnEnable)
		{
			UISelectionManager.GIGBGIIAKMP(0).IHFNCOGFJOJ((Selectable)(object)HJGEDECNFAO);
		}
		if (PlayerInputs.ODGALPDEIFG(2) && selectOnEnableForPlayer2)
		{
			UISelectionManager.EAJJMLJKOPH(2).NCGCKHGOJCM((Selectable)(object)HJGEDECNFAO);
		}
	}

	private void HCDIKNEMAKJ()
	{
		TMP_InputField[] array = Object.FindObjectsByType<TMP_InputField>((FindObjectsInactive)1, (FindObjectsSortMode)0);
		foreach (TMP_InputField val in array)
		{
			if ((Object)(object)((Component)val).gameObject.GetComponent<TMP_InputFieldConsoleSupport>() == (Object)null)
			{
				((Component)val).gameObject.AddComponent<TMP_InputFieldConsoleSupport>();
				Debug.Log((object)$"Added console support to input field: {((Component)val).gameObject}", (Object)(object)((Component)val).gameObject);
			}
			else
			{
				Debug.Log((object)$"Input field already has console support component: {((Component)val).gameObject}", (Object)(object)((Component)val).gameObject);
			}
		}
	}

	private void PCEFNHADDIG()
	{
		if (Application.isPlaying && Utils.NKAMHHCOEFO())
		{
			ODIPHHGGGDE?.Dispose();
			OBAJPPBFNKJ?.Dispose();
		}
	}

	private void OnDestroy()
	{
		if (Application.isPlaying && Utils.NKAMHHCOEFO())
		{
			ODIPHHGGGDE?.Dispose();
			OBAJPPBFNKJ?.Dispose();
		}
	}

	private void KMJBAAKOJOP()
	{
		if (InputFieldConsoleUtils.OBLNDHGPAJB)
		{
			BCMLDIACGHL = InputFieldConsoleUtils.KMJBAAKOJOP((uint)HJGEDECNFAO.characterLimit);
			if (Utils.ILLKGGBHMLF() == PlatformOS.Steamdeck)
			{
				Debug.LogError((object)("Input Text: " + BCMLDIACGHL));
			}
		}
	}

	private void OnEnable()
	{
		HJHHBBJHMLK();
		if (PlayerInputs.IsGamepadActive(1) && selectOnEnable)
		{
			UISelectionManager.GetPlayer(1).Select((Selectable)(object)HJGEDECNFAO);
		}
		if (PlayerInputs.IsGamepadActive(2) && selectOnEnableForPlayer2)
		{
			UISelectionManager.GetPlayer(2).Select((Selectable)(object)HJGEDECNFAO);
		}
	}

	private void IIOHMDNGFDH()
	{
	}

	private void DFCABMCADFL(FloatingGamepadTextInputDismissed_t ENEJBCKMDCP)
	{
		InputFieldConsoleUtils.KIIPLGFMLHP();
		if (!((Object)(object)InputFieldConsoleUtils.HBCBGBCHDDN != (Object)(object)HJGEDECNFAO))
		{
			Debug.LogError((object)"Dismissed");
		}
	}

	private void KIIPLGFMLHP(string IBJFCCHLAEG)
	{
		if (Utils.ILLKGGBHMLF() == PlatformOS.Steamdeck)
		{
			Debug.LogError((object)("Hiding Keyboard " + IBJFCCHLAEG), (Object)(object)((Component)this).gameObject);
		}
		InputFieldConsoleUtils.KIIPLGFMLHP(IBJFCCHLAEG);
	}

	private void GKDNCBPNEEH(string IBJFCCHLAEG)
	{
		if (Utils.ILLKGGBHMLF() == PlatformOS.Undefined)
		{
			Debug.LogError((object)(" Galaxy ID" + IBJFCCHLAEG), (Object)(object)((Component)this).gameObject);
		}
		InputFieldConsoleUtils.GEOIBJMEAOK(IBJFCCHLAEG);
	}

	private void Start()
	{
		HJHHBBJHMLK();
	}

	private void HJHHBBJHMLK()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)HJGEDECNFAO != (Object)null)
		{
			return;
		}
		HJGEDECNFAO = ((Component)this).GetComponent<TMP_InputField>();
		if (!Utils.NKAMHHCOEFO())
		{
			if (disableNavigationIfNotConsole)
			{
				TMP_InputField hJGEDECNFAO = HJGEDECNFAO;
				Navigation navigation = default(Navigation);
				((Navigation)(ref navigation)).mode = (Mode)0;
				((Selectable)hJGEDECNFAO).navigation = navigation;
			}
			Object.Destroy((Object)(object)this);
		}
		else
		{
			if (!string.IsNullOrEmpty(textID))
			{
				description = LocalisationSystem.Get(textID);
			}
			((UnityEvent<string>)(object)HJGEDECNFAO.onSelect).AddListener((UnityAction<string>)GDMKBCKMJNM);
			((UnityEvent<string>)(object)HJGEDECNFAO.onDeselect).AddListener((UnityAction<string>)KIIPLGFMLHP);
			ODIPHHGGGDE = Callback<GamepadTextInputDismissed_t>.Create((DispatchDelegate<GamepadTextInputDismissed_t>)AKPGEHEBHNB);
			OBAJPPBFNKJ = Callback<FloatingGamepadTextInputDismissed_t>.Create((DispatchDelegate<FloatingGamepadTextInputDismissed_t>)DFCABMCADFL);
		}
	}

	private void IGJPFBMGJJM()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)HJGEDECNFAO != (Object)null)
		{
			return;
		}
		HJGEDECNFAO = ((Component)this).GetComponent<TMP_InputField>();
		if (!Utils.NKAMHHCOEFO())
		{
			if (disableNavigationIfNotConsole)
			{
				TMP_InputField hJGEDECNFAO = HJGEDECNFAO;
				Navigation navigation = default(Navigation);
				((Navigation)(ref navigation)).mode = (Mode)0;
				((Selectable)hJGEDECNFAO).navigation = navigation;
			}
			Object.Destroy((Object)(object)this);
		}
		else
		{
			if (!string.IsNullOrEmpty(textID))
			{
				description = LocalisationSystem.Get(textID);
			}
			((UnityEvent<string>)(object)HJGEDECNFAO.onSelect).AddListener((UnityAction<string>)GDMKBCKMJNM);
			((UnityEvent<string>)(object)HJGEDECNFAO.onDeselect).AddListener((UnityAction<string>)KIIPLGFMLHP);
			ODIPHHGGGDE = Callback<GamepadTextInputDismissed_t>.Create((DispatchDelegate<GamepadTextInputDismissed_t>)NJPAAIHKLKG);
			OBAJPPBFNKJ = Callback<FloatingGamepadTextInputDismissed_t>.Create((DispatchDelegate<FloatingGamepadTextInputDismissed_t>)DFCABMCADFL);
		}
	}

	private void GKNBPKLIGAK()
	{
		TMP_InputField[] array = Object.FindObjectsByType<TMP_InputField>((FindObjectsInactive)0, (FindObjectsSortMode)0);
		for (int i = 1; i < array.Length; i++)
		{
			TMP_InputField val = array[i];
			if ((Object)(object)((Component)val).gameObject.GetComponent<TMP_InputFieldConsoleSupport>() == (Object)null)
			{
				((Component)val).gameObject.AddComponent<TMP_InputFieldConsoleSupport>();
				Debug.Log((object)string.Format("PirateMinigame/Talk", ((Component)val).gameObject), (Object)(object)((Component)val).gameObject);
			}
			else
			{
				Debug.Log((object)string.Format("Cellar", ((Component)val).gameObject), (Object)(object)((Component)val).gameObject);
			}
		}
	}

	private void ILCBKEIEOAN()
	{
		if (Application.isPlaying && Utils.NKAMHHCOEFO())
		{
			ODIPHHGGGDE?.Dispose();
			OBAJPPBFNKJ?.Dispose();
		}
	}

	private void MACGHGHALCK(string OJNHBLMHILA)
	{
		HJGEDECNFAO.text = BCMLDIACGHL;
		if (Utils.ILLKGGBHMLF() == PlatformOS.Steamdeck)
		{
			Debug.LogError((object)("Submit text: " + OJNHBLMHILA + "\nInternal current input text: " + BCMLDIACGHL));
		}
		KIIPLGFMLHP(OJNHBLMHILA);
	}

	private void NGGMHFNJFOH(GamepadTextInputDismissed_t ENEJBCKMDCP)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)InputFieldConsoleUtils.DJBKGOPKNHG() != (Object)(object)HJGEDECNFAO) && ENEJBCKMDCP.m_bSubmitted)
		{
			string text = default(string);
			if (!SteamUtils.GetEnteredGamepadTextInput(ref text, SteamUtils.GetEnteredGamepadTextLength()))
			{
				Debug.LogError((object)"BuildMode_ExitAndCancel");
				return;
			}
			HJGEDECNFAO.text = text;
			((UnityEvent<string>)(object)HJGEDECNFAO.onSubmit).Invoke(text);
		}
	}

	private void NJPAAIHKLKG(GamepadTextInputDismissed_t ENEJBCKMDCP)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)InputFieldConsoleUtils.KHCCPNIPPGE() != (Object)(object)HJGEDECNFAO) && ENEJBCKMDCP.m_bSubmitted)
		{
			string text = default(string);
			if (!SteamUtils.GetEnteredGamepadTextInput(ref text, SteamUtils.GetEnteredGamepadTextLength()))
			{
				Debug.LogError((object)"ReceiveActivateEatGameObjects");
				return;
			}
			HJGEDECNFAO.text = text;
			((UnityEvent<string>)(object)HJGEDECNFAO.onSubmit).Invoke(text);
		}
	}

	private void Update()
	{
	}

	private void GDMKBCKMJNM(string OCKBNMGOPCL)
	{
		if (Utils.ILLKGGBHMLF() == PlatformOS.Steamdeck)
		{
			Debug.LogError((object)("Showing Keyboard " + OCKBNMGOPCL), (Object)(object)((Component)this).gameObject);
		}
		InputFieldConsoleUtils.GDMKBCKMJNM(HJGEDECNFAO, description, (uint)HJGEDECNFAO.characterLimit);
	}
}
