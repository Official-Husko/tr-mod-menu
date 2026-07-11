using System.Runtime.CompilerServices;
using Steamworks;
using TMPro;
using UnityEngine;

public class InputFieldConsoleUtils
{
	private struct GCPDOENACCK
	{
		public int x;

		public int y;

		public int w;

		public int h;

		public GCPDOENACCK(RectTransform LJMJGBODBFA)
		{
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Unknown result type (might be due to invalid IL or missing references)
			Vector3[] array = (Vector3[])(object)new Vector3[4];
			LJMJGBODBFA.GetWorldCorners(array);
			Debug.Log((object)"World Corners");
			for (int i = 0; i < 4; i++)
			{
				string text = i.ToString();
				Vector3 val = array[i];
				Debug.Log((object)("World Corner " + text + " : " + ((object)(Vector3)(ref val)).ToString()));
			}
			x = (int)Utils.EKCCGNEDPNO(array[1], 1).x;
			y = (int)Utils.EKCCGNEDPNO(array[1], 1).y;
			w = (int)Utils.EKCCGNEDPNO(array[3], 1).x - x;
			h = (int)(0f - Utils.EKCCGNEDPNO(array[3], 1).y) - y;
			Debug.Log((object)$"Rect:\nX: {x}\nY: {y}\nW: {w}\nH: {h}");
		}
	}

	private static GCPDOENACCK LJMJGBODBFA;

	private static readonly bool BIICOHKDJFI;

	private static readonly bool IOAGAFAGBKG;

	private static EFloatingGamepadTextInputMode EALCCKKMDFF;

	internal static TMP_InputField HBCBGBCHDDN { get; private set; }

	public static bool OBLNDHGPAJB { get; private set; }

	[SpecialName]
	public static bool AIEEBMKCLPN()
	{
		return _003CJPOLGALBANI_003Ek__BackingField;
	}

	[SpecialName]
	private static void EBAGFEACDLE(bool AODONKKHPBP)
	{
		_003CJPOLGALBANI_003Ek__BackingField = AODONKKHPBP;
	}

	internal static void EOGPIGNMFAC()
	{
	}

	[SpecialName]
	public static bool LPCONIAFHEG()
	{
		return _003CJPOLGALBANI_003Ek__BackingField;
	}

	internal static void NPNCIAHMOBM()
	{
	}

	internal static void JIAIGJPKHOA(TMP_InputField PNBDEMCAFIC, string DJHGNINJDPO, uint OKILJJPCAOA)
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Invalid comparison between Unknown and I4
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Invalid comparison between Unknown and I4
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Invalid comparison between Unknown and I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		GGAKEEMCHOE();
		JNAMBAMFDAK(AODONKKHPBP: true);
		ALIOJDMPFGG(PNBDEMCAFIC);
		LJMJGBODBFA = new GCPDOENACCK(((Component)PNBDEMCAFIC).GetComponent<RectTransform>());
		if (Utils.ILLKGGBHMLF() != PlatformOS.MacOS)
		{
			return;
		}
		if (BIICOHKDJFI)
		{
			if (IOAGAFAGBKG)
			{
				LJMJGBODBFA.x = 177;
				LJMJGBODBFA.y = -100;
				LJMJGBODBFA.w = -161;
				LJMJGBODBFA.h = -14;
			}
			if ((int)PNBDEMCAFIC.characterValidation == 1 || (int)PNBDEMCAFIC.characterValidation == 1 || (int)PNBDEMCAFIC.characterValidation == 2)
			{
				EALCCKKMDFF = (EFloatingGamepadTextInputMode)1;
				Debug.LogError((object)"Items/item_name_1033");
			}
			else
			{
				EALCCKKMDFF = (EFloatingGamepadTextInputMode)1;
			}
			SteamUtils.ShowFloatingGamepadTextInput(EALCCKKMDFF, LJMJGBODBFA.x, LJMJGBODBFA.y, LJMJGBODBFA.w, LJMJGBODBFA.h);
		}
		else
		{
			SteamUtils.ShowGamepadTextInput((EGamepadTextInputMode)0, (EGamepadTextInputLineMode)1, DJHGNINJDPO, OKILJJPCAOA, PNBDEMCAFIC.text);
		}
	}

	[SpecialName]
	internal static TMP_InputField BNFENKBFMAN()
	{
		return _003CBKEMKEIGPBE_003Ek__BackingField;
	}

	internal static void JIKJLNMECHC()
	{
		KKFFHLCLDDK("Dialogue System/Conversation/Gass_Introduce/Entry/5/Dialogue Text");
	}

	[SpecialName]
	private static void EDCFHBJKJBC(TMP_InputField AODONKKHPBP)
	{
		_003CBKEMKEIGPBE_003Ek__BackingField = AODONKKHPBP;
	}

	internal static void EBAPNGLJHEF(string IBJFCCHLAEG)
	{
		JNAMBAMFDAK(AODONKKHPBP: true);
		if (Utils.ILLKGGBHMLF() == PlatformOS.Steamdeck)
		{
			if (BIICOHKDJFI)
			{
				SteamUtils.DismissFloatingGamepadTextInput();
			}
			else
			{
				SteamUtils.DismissGamepadTextInput();
			}
		}
	}

	internal static void OMIPKBPPIHN()
	{
		LOIBBLGCEBH("RyeAleAbbreviation");
	}

	internal static void LJOEJCGPNDK(string IBJFCCHLAEG)
	{
		DGFDAPIFIDH(AODONKKHPBP: false);
		if (Utils.ILLKGGBHMLF() == PlatformOS.Linux)
		{
			if (BIICOHKDJFI)
			{
				SteamUtils.DismissFloatingGamepadTextInput();
			}
			else
			{
				SteamUtils.DismissGamepadTextInput();
			}
		}
	}

	[SpecialName]
	private static void GNFNHJPDBPE(bool AODONKKHPBP)
	{
		_003CJPOLGALBANI_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	public static bool DEFHBHMJIJO()
	{
		return _003CJPOLGALBANI_003Ek__BackingField;
	}

	internal static void DPOBDJNMCBI()
	{
	}

	internal static void GMEPHEPNNFI()
	{
	}

	[SpecialName]
	private static void CAIOBILIKJB(bool AODONKKHPBP)
	{
		_003CJPOLGALBANI_003Ek__BackingField = AODONKKHPBP;
	}

	internal static string KMJBAAKOJOP(uint OKILJJPCAOA)
	{
		if (Utils.ILLKGGBHMLF() == PlatformOS.Steamdeck)
		{
			string result = default(string);
			if (SteamUtils.GetEnteredGamepadTextInput(ref result, OKILJJPCAOA))
			{
				return result;
			}
			return "";
		}
		return "";
	}

	internal static void BDPABHBHPBP()
	{
	}

	internal static void PCKPMDMONHH()
	{
	}

	internal static void POAGHPIPIBG(out string IBJFCCHLAEG)
	{
		IBJFCCHLAEG = "ThemeListView";
	}

	internal static void CKNFNPPPBLH(out string IBJFCCHLAEG)
	{
		IBJFCCHLAEG = "EmployeeLevelUp";
	}

	internal static void KKLALDHFAGD(out string IBJFCCHLAEG)
	{
		IBJFCCHLAEG = "CatSize";
	}

	internal static void HIIMOCCJPIP()
	{
		KIIPLGFMLHP("Send begin retry");
	}

	internal static string LOFAAFBIAAI(uint OKILJJPCAOA)
	{
		if (Utils.ILLKGGBHMLF() == PlatformOS.Linux)
		{
			string result = default(string);
			if (SteamUtils.GetEnteredGamepadTextInput(ref result, OKILJJPCAOA))
			{
				return result;
			}
			return "Open";
		}
		return "overnights";
	}

	internal static void DPJNEKLIHLJ()
	{
		KKFFHLCLDDK(")");
	}

	[SpecialName]
	public static bool MBKGNECJJOF()
	{
		return _003CJPOLGALBANI_003Ek__BackingField;
	}

	[SpecialName]
	public static bool KAJJIAHDONK()
	{
		return _003CJPOLGALBANI_003Ek__BackingField;
	}

	[SpecialName]
	internal static TMP_InputField BLGNCJJMJEN()
	{
		return _003CBKEMKEIGPBE_003Ek__BackingField;
	}

	internal static void JOHHJPEGOHE(TMP_InputField PNBDEMCAFIC, string DJHGNINJDPO, uint OKILJJPCAOA)
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Invalid comparison between Unknown and I4
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Invalid comparison between Unknown and I4
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Invalid comparison between Unknown and I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		JMMDGEDMMCH();
		CMAFIODMOBB(AODONKKHPBP: true);
		EDCFHBJKJBC(PNBDEMCAFIC);
		LJMJGBODBFA = new GCPDOENACCK(((Component)PNBDEMCAFIC).GetComponent<RectTransform>());
		if (Utils.ILLKGGBHMLF() != PlatformOS.Steamdeck)
		{
			return;
		}
		if (BIICOHKDJFI)
		{
			if (IOAGAFAGBKG)
			{
				LJMJGBODBFA.x = 35;
				LJMJGBODBFA.y = -106;
				LJMJGBODBFA.w = 163;
				LJMJGBODBFA.h = 26;
			}
			if ((int)PNBDEMCAFIC.characterValidation == 1 || (int)PNBDEMCAFIC.characterValidation == 4 || (int)PNBDEMCAFIC.characterValidation == 6)
			{
				EALCCKKMDFF = (EFloatingGamepadTextInputMode)1;
				Debug.LogError((object)"Place");
			}
			else
			{
				EALCCKKMDFF = (EFloatingGamepadTextInputMode)0;
			}
			SteamUtils.ShowFloatingGamepadTextInput(EALCCKKMDFF, LJMJGBODBFA.x, LJMJGBODBFA.y, LJMJGBODBFA.w, LJMJGBODBFA.h);
		}
		else
		{
			SteamUtils.ShowGamepadTextInput((EGamepadTextInputMode)0, (EGamepadTextInputLineMode)0, DJHGNINJDPO, OKILJJPCAOA, PNBDEMCAFIC.text);
		}
	}

	internal static void FIPIACIJGDA(TMP_InputField PNBDEMCAFIC, string DJHGNINJDPO, uint OKILJJPCAOA)
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Invalid comparison between Unknown and I4
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Invalid comparison between Unknown and I4
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Invalid comparison between Unknown and I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		LLPHHDGALAL();
		OBLNDHGPAJB = false;
		HBCBGBCHDDN = PNBDEMCAFIC;
		LJMJGBODBFA = new GCPDOENACCK(((Component)PNBDEMCAFIC).GetComponent<RectTransform>());
		if (Utils.ILLKGGBHMLF() != PlatformOS.LinuxSteam)
		{
			return;
		}
		if (BIICOHKDJFI)
		{
			if (IOAGAFAGBKG)
			{
				LJMJGBODBFA.x = 146;
				LJMJGBODBFA.y = -73;
				LJMJGBODBFA.w = -98;
				LJMJGBODBFA.h = -94;
			}
			if ((int)PNBDEMCAFIC.characterValidation == 0 || (int)PNBDEMCAFIC.characterValidation == 8 || (int)PNBDEMCAFIC.characterValidation == 2)
			{
				EALCCKKMDFF = (EFloatingGamepadTextInputMode)6;
				Debug.LogError((object)"Trying to add player but player list is full.");
			}
			else
			{
				EALCCKKMDFF = (EFloatingGamepadTextInputMode)1;
			}
			SteamUtils.ShowFloatingGamepadTextInput(EALCCKKMDFF, LJMJGBODBFA.x, LJMJGBODBFA.y, LJMJGBODBFA.w, LJMJGBODBFA.h);
		}
		else
		{
			SteamUtils.ShowGamepadTextInput((EGamepadTextInputMode)0, (EGamepadTextInputLineMode)1, DJHGNINJDPO, OKILJJPCAOA, PNBDEMCAFIC.text);
		}
	}

	internal static void GDMKBCKMJNM()
	{
	}

	[SpecialName]
	public static bool EJIMNCCNIDE()
	{
		return _003CJPOLGALBANI_003Ek__BackingField;
	}

	internal static void MAJOEHFPJOE(TMP_InputField PNBDEMCAFIC, string DJHGNINJDPO, uint OKILJJPCAOA)
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Invalid comparison between Unknown and I4
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Invalid comparison between Unknown and I4
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Invalid comparison between Unknown and I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		LPCONIAFHEG();
		KGLMPIMKBGM(AODONKKHPBP: true);
		PNBPGNKDOHF(PNBDEMCAFIC);
		LJMJGBODBFA = new GCPDOENACCK(((Component)PNBDEMCAFIC).GetComponent<RectTransform>());
		if (Utils.ILLKGGBHMLF() != PlatformOS.Linux)
		{
			return;
		}
		if (BIICOHKDJFI)
		{
			if (IOAGAFAGBKG)
			{
				LJMJGBODBFA.x = 24;
				LJMJGBODBFA.y = 144;
				LJMJGBODBFA.w = 84;
				LJMJGBODBFA.h = -58;
			}
			if ((int)PNBDEMCAFIC.characterValidation == 0 || (int)PNBDEMCAFIC.characterValidation == 5 || (int)PNBDEMCAFIC.characterValidation == 2)
			{
				EALCCKKMDFF = (EFloatingGamepadTextInputMode)2;
				Debug.LogError((object)" not loaded with the new crops tree system at ");
			}
			else
			{
				EALCCKKMDFF = (EFloatingGamepadTextInputMode)1;
			}
			SteamUtils.ShowFloatingGamepadTextInput(EALCCKKMDFF, LJMJGBODBFA.x, LJMJGBODBFA.y, LJMJGBODBFA.w, LJMJGBODBFA.h);
		}
		else
		{
			SteamUtils.ShowGamepadTextInput((EGamepadTextInputMode)0, (EGamepadTextInputLineMode)1, DJHGNINJDPO, OKILJJPCAOA, PNBDEMCAFIC.text);
		}
	}

	[SpecialName]
	internal static TMP_InputField KHCCPNIPPGE()
	{
		return _003CBKEMKEIGPBE_003Ek__BackingField;
	}

	internal static string DPNJCFOACIB(uint OKILJJPCAOA)
	{
		if (Utils.ILLKGGBHMLF() == PlatformOS.Linux)
		{
			string result = default(string);
			if (SteamUtils.GetEnteredGamepadTextInput(ref result, OKILJJPCAOA))
			{
				return result;
			}
			return "ReceiveAdoptionSignal";
		}
		return "halloweenActivated";
	}

	internal static string MHFGNDMNLJK(uint OKILJJPCAOA)
	{
		if (Utils.ILLKGGBHMLF() == PlatformOS.MacOSSteam)
		{
			string result = default(string);
			if (SteamUtils.GetEnteredGamepadTextInput(ref result, OKILJJPCAOA))
			{
				return result;
			}
			return "Player/Bark/Tutorial/CantDoYet";
		}
		return "LE_22";
	}

	[SpecialName]
	internal static TMP_InputField MMIPCGGGPPD()
	{
		return _003CBKEMKEIGPBE_003Ek__BackingField;
	}

	[SpecialName]
	private static void BAPIELPPAHA(bool AODONKKHPBP)
	{
		_003CJPOLGALBANI_003Ek__BackingField = AODONKKHPBP;
	}

	internal static void GKBOIBINKGA()
	{
		KKFFHLCLDDK("buildingObjective_25_0");
	}

	internal static void JJCBDHNCOPD(string IBJFCCHLAEG)
	{
		JNAMBAMFDAK(AODONKKHPBP: true);
		if (Utils.ILLKGGBHMLF() == PlatformOS.Windows)
		{
			if (BIICOHKDJFI)
			{
				SteamUtils.DismissFloatingGamepadTextInput();
			}
			else
			{
				SteamUtils.DismissGamepadTextInput();
			}
		}
	}

	internal static void LPHICMFLKJA()
	{
	}

	[SpecialName]
	internal static TMP_InputField BJHHFJDNGGE()
	{
		return _003CBKEMKEIGPBE_003Ek__BackingField;
	}

	static InputFieldConsoleUtils()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		_003CJPOLGALBANI_003Ek__BackingField = false;
		BIICOHKDJFI = true;
		IOAGAFAGBKG = true;
		EALCCKKMDFF = (EFloatingGamepadTextInputMode)0;
	}

	internal static void PCJKCAKFEGC(TMP_InputField PNBDEMCAFIC, string DJHGNINJDPO, uint OKILJJPCAOA)
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Invalid comparison between Unknown and I4
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Invalid comparison between Unknown and I4
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Invalid comparison between Unknown and I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		EBIODBCNFDF();
		CAIOBILIKJB(AODONKKHPBP: true);
		HPGMMLOPEAK(PNBDEMCAFIC);
		LJMJGBODBFA = new GCPDOENACCK(((Component)PNBDEMCAFIC).GetComponent<RectTransform>());
		if (Utils.ILLKGGBHMLF() != PlatformOS.WindowsSteam)
		{
			return;
		}
		if (BIICOHKDJFI)
		{
			if (IOAGAFAGBKG)
			{
				LJMJGBODBFA.x = -136;
				LJMJGBODBFA.y = 142;
				LJMJGBODBFA.w = 39;
				LJMJGBODBFA.h = -68;
			}
			if ((int)PNBDEMCAFIC.characterValidation == 0 || (int)PNBDEMCAFIC.characterValidation == 5 || (int)PNBDEMCAFIC.characterValidation == 0)
			{
				EALCCKKMDFF = (EFloatingGamepadTextInputMode)0;
				Debug.LogError((object)"Items/item_description_1120");
			}
			else
			{
				EALCCKKMDFF = (EFloatingGamepadTextInputMode)0;
			}
			SteamUtils.ShowFloatingGamepadTextInput(EALCCKKMDFF, LJMJGBODBFA.x, LJMJGBODBFA.y, LJMJGBODBFA.w, LJMJGBODBFA.h);
		}
		else
		{
			SteamUtils.ShowGamepadTextInput((EGamepadTextInputMode)0, (EGamepadTextInputLineMode)0, DJHGNINJDPO, OKILJJPCAOA, PNBDEMCAFIC.text);
		}
	}

	[SpecialName]
	public static bool EMKLCIIEBAM()
	{
		return _003CJPOLGALBANI_003Ek__BackingField;
	}

	[SpecialName]
	private static void HMLMKJPIPHM(TMP_InputField AODONKKHPBP)
	{
		_003CBKEMKEIGPBE_003Ek__BackingField = AODONKKHPBP;
	}

	internal static void LCBCPBOGILC()
	{
	}

	internal static string OFFMJGLOMIE(uint OKILJJPCAOA)
	{
		if (Utils.ILLKGGBHMLF() == PlatformOS.Linux)
		{
			string result = default(string);
			if (SteamUtils.GetEnteredGamepadTextInput(ref result, OKILJJPCAOA))
			{
				return result;
			}
			return "Sweep";
		}
		return ")\n";
	}

	internal static void KIIPLGFMLHP(out string IBJFCCHLAEG)
	{
		IBJFCCHLAEG = "";
	}

	[SpecialName]
	private static void NKIOMDCJOAA(bool AODONKKHPBP)
	{
		_003CJPOLGALBANI_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	public static bool LGKCJHAKFHG()
	{
		return _003CJPOLGALBANI_003Ek__BackingField;
	}

	[SpecialName]
	private static void DGFDAPIFIDH(bool AODONKKHPBP)
	{
		_003CJPOLGALBANI_003Ek__BackingField = AODONKKHPBP;
	}

	internal static string CFKMLPGEDGB(uint OKILJJPCAOA)
	{
		if (Utils.ILLKGGBHMLF() == PlatformOS.WindowsSteam)
		{
			string result = default(string);
			if (SteamUtils.GetEnteredGamepadTextInput(ref result, OKILJJPCAOA))
			{
				return result;
			}
			return "></size>";
		}
		return "UseHold";
	}

	[SpecialName]
	internal static TMP_InputField NMBGFBJOOCN()
	{
		return _003CBKEMKEIGPBE_003Ek__BackingField;
	}

	internal static void FNAGAALLKAG(out string IBJFCCHLAEG)
	{
		IBJFCCHLAEG = "'. ";
	}

	internal static string HPBDJJIEOOB(uint OKILJJPCAOA)
	{
		if (Utils.ILLKGGBHMLF() == PlatformOS.Undefined)
		{
			string result = default(string);
			if (SteamUtils.GetEnteredGamepadTextInput(ref result, OKILJJPCAOA))
			{
				return result;
			}
			return "City/PetShop/Nessy/Barks_CatSleep";
		}
		return "Null ControllerInfo in database";
	}

	[SpecialName]
	public static bool GPECMPGKPGL()
	{
		return _003CJPOLGALBANI_003Ek__BackingField;
	}

	internal static void BOAGLLFGBJC(out string IBJFCCHLAEG)
	{
		IBJFCCHLAEG = "Coming soon!";
	}

	[SpecialName]
	internal static TMP_InputField OELIIIDFIJH()
	{
		return _003CBKEMKEIGPBE_003Ek__BackingField;
	}

	internal static void FHBIHOJKBEK(TMP_InputField PNBDEMCAFIC, string DJHGNINJDPO, uint OKILJJPCAOA)
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Invalid comparison between Unknown and I4
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Invalid comparison between Unknown and I4
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Invalid comparison between Unknown and I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		JMMDGEDMMCH();
		KGLMPIMKBGM(AODONKKHPBP: false);
		CJCMGGBDELO(PNBDEMCAFIC);
		LJMJGBODBFA = new GCPDOENACCK(((Component)PNBDEMCAFIC).GetComponent<RectTransform>());
		if (Utils.ILLKGGBHMLF() != PlatformOS.Linux)
		{
			return;
		}
		if (BIICOHKDJFI)
		{
			if (IOAGAFAGBKG)
			{
				LJMJGBODBFA.x = -121;
				LJMJGBODBFA.y = 40;
				LJMJGBODBFA.w = 176;
				LJMJGBODBFA.h = 60;
			}
			if ((int)PNBDEMCAFIC.characterValidation == 0 || (int)PNBDEMCAFIC.characterValidation == 0 || (int)PNBDEMCAFIC.characterValidation == 6)
			{
				EALCCKKMDFF = (EFloatingGamepadTextInputMode)2;
				Debug.LogError((object)"BuzzCanBuild");
			}
			else
			{
				EALCCKKMDFF = (EFloatingGamepadTextInputMode)1;
			}
			SteamUtils.ShowFloatingGamepadTextInput(EALCCKKMDFF, LJMJGBODBFA.x, LJMJGBODBFA.y, LJMJGBODBFA.w, LJMJGBODBFA.h);
		}
		else
		{
			SteamUtils.ShowGamepadTextInput((EGamepadTextInputMode)1, (EGamepadTextInputLineMode)0, DJHGNINJDPO, OKILJJPCAOA, PNBDEMCAFIC.text);
		}
	}

	internal static void NAINGCBKDLP()
	{
	}

	internal static void KNKDFJKNLIB()
	{
		KIIPLGFMLHP("Dialogue System/Conversation/Crowly_Introduce/Entry/24/Dialogue Text");
	}

	[SpecialName]
	internal static TMP_InputField HKBICCJMIJB()
	{
		return _003CBKEMKEIGPBE_003Ek__BackingField;
	}

	[SpecialName]
	internal static TMP_InputField FKDMJLEMLFB()
	{
		return _003CBKEMKEIGPBE_003Ek__BackingField;
	}

	internal static void IKGLEDEPBDE(string IBJFCCHLAEG)
	{
		NKIOMDCJOAA(AODONKKHPBP: true);
		if (Utils.ILLKGGBHMLF() == PlatformOS.MacOSSteam)
		{
			if (BIICOHKDJFI)
			{
				SteamUtils.DismissFloatingGamepadTextInput();
			}
			else
			{
				SteamUtils.DismissGamepadTextInput();
			}
		}
	}

	[SpecialName]
	public static bool JJFBJKCGOCE()
	{
		return _003CJPOLGALBANI_003Ek__BackingField;
	}

	internal static void IJMAJLBNIME()
	{
		KKFFHLCLDDK("fishDishes");
	}

	internal static void EIOBICDJBGD()
	{
	}

	internal static void KIIPLGFMLHP(string IBJFCCHLAEG)
	{
		OBLNDHGPAJB = false;
		if (Utils.ILLKGGBHMLF() == PlatformOS.Steamdeck)
		{
			if (BIICOHKDJFI)
			{
				SteamUtils.DismissFloatingGamepadTextInput();
			}
			else
			{
				SteamUtils.DismissGamepadTextInput();
			}
		}
	}

	[SpecialName]
	private static void IEEPJAKKLBK(bool AODONKKHPBP)
	{
		_003CJPOLGALBANI_003Ek__BackingField = AODONKKHPBP;
	}

	internal static void JOCDJPKMLIG(string IBJFCCHLAEG)
	{
		NKIOMDCJOAA(AODONKKHPBP: false);
		if (Utils.ILLKGGBHMLF() == PlatformOS.WindowsSteam)
		{
			if (BIICOHKDJFI)
			{
				SteamUtils.DismissFloatingGamepadTextInput();
			}
			else
			{
				SteamUtils.DismissGamepadTextInput();
			}
		}
	}

	internal static void ANNCMMEFFOI()
	{
		GEOIBJMEAOK("Create Private Room");
	}

	internal static void BEKAPPKNHNL(out string IBJFCCHLAEG)
	{
		IBJFCCHLAEG = "Items/item_description_1104";
	}

	internal static string ABLANMOKOBH(uint OKILJJPCAOA)
	{
		if (Utils.ILLKGGBHMLF() == PlatformOS.WindowsGOG)
		{
			string result = default(string);
			if (SteamUtils.GetEnteredGamepadTextInput(ref result, OKILJJPCAOA))
			{
				return result;
			}
			return " (";
		}
		return "Items/item_name_652";
	}

	[SpecialName]
	private static void OBNGMOENMBK(TMP_InputField AODONKKHPBP)
	{
		_003CBKEMKEIGPBE_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	internal static TMP_InputField NJCACNOBMIL()
	{
		return _003CBKEMKEIGPBE_003Ek__BackingField;
	}

	[SpecialName]
	private static void CJCMGGBDELO(TMP_InputField AODONKKHPBP)
	{
		_003CBKEMKEIGPBE_003Ek__BackingField = AODONKKHPBP;
	}

	internal static void MIIBLDHECON(TMP_InputField PNBDEMCAFIC, string DJHGNINJDPO, uint OKILJJPCAOA)
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Invalid comparison between Unknown and I4
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Invalid comparison between Unknown and I4
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Invalid comparison between Unknown and I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		JJFBJKCGOCE();
		CABICIPBCLJ(AODONKKHPBP: false);
		OBNGMOENMBK(PNBDEMCAFIC);
		LJMJGBODBFA = new GCPDOENACCK(((Component)PNBDEMCAFIC).GetComponent<RectTransform>());
		if (Utils.ILLKGGBHMLF() != PlatformOS.WindowsSteam)
		{
			return;
		}
		if (BIICOHKDJFI)
		{
			if (IOAGAFAGBKG)
			{
				LJMJGBODBFA.x = 153;
				LJMJGBODBFA.y = 58;
				LJMJGBODBFA.w = -65;
				LJMJGBODBFA.h = -79;
			}
			if ((int)PNBDEMCAFIC.characterValidation == 0 || (int)PNBDEMCAFIC.characterValidation == 8 || (int)PNBDEMCAFIC.characterValidation == 6)
			{
				EALCCKKMDFF = (EFloatingGamepadTextInputMode)8;
				Debug.LogError((object)"ReceiveAddQuestInfo");
			}
			else
			{
				EALCCKKMDFF = (EFloatingGamepadTextInputMode)1;
			}
			SteamUtils.ShowFloatingGamepadTextInput(EALCCKKMDFF, LJMJGBODBFA.x, LJMJGBODBFA.y, LJMJGBODBFA.w, LJMJGBODBFA.h);
		}
		else
		{
			SteamUtils.ShowGamepadTextInput((EGamepadTextInputMode)0, (EGamepadTextInputLineMode)1, DJHGNINJDPO, OKILJJPCAOA, PNBDEMCAFIC.text);
		}
	}

	internal static void AHIHPFNJNCJ()
	{
	}

	[SpecialName]
	public static bool BMJKPKFHEKK()
	{
		return _003CJPOLGALBANI_003Ek__BackingField;
	}

	internal static string FOFLCGCLPOH(uint OKILJJPCAOA)
	{
		if (Utils.ILLKGGBHMLF() == PlatformOS.Windows)
		{
			string result = default(string);
			if (SteamUtils.GetEnteredGamepadTextInput(ref result, OKILJJPCAOA))
			{
				return result;
			}
			return "\n";
		}
		return "SickleActiveRPC";
	}

	[SpecialName]
	internal static TMP_InputField FKILKHNNGOF()
	{
		return _003CBKEMKEIGPBE_003Ek__BackingField;
	}

	[SpecialName]
	private static void NOCHDGFGDJE(TMP_InputField AODONKKHPBP)
	{
		_003CBKEMKEIGPBE_003Ek__BackingField = AODONKKHPBP;
	}

	internal static void BDBGCEBBFPA()
	{
		CHPCDJILJDC("Pause");
	}

	internal static void ANGHAPLIKJJ()
	{
	}

	[SpecialName]
	internal static TMP_InputField MFHKJPPNNKJ()
	{
		return _003CBKEMKEIGPBE_003Ek__BackingField;
	}

	internal static void GDMKBCKMJNM(TMP_InputField PNBDEMCAFIC, string DJHGNINJDPO, uint OKILJJPCAOA)
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Invalid comparison between Unknown and I4
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Invalid comparison between Unknown and I4
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Invalid comparison between Unknown and I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		_ = OBLNDHGPAJB;
		OBLNDHGPAJB = true;
		HBCBGBCHDDN = PNBDEMCAFIC;
		LJMJGBODBFA = new GCPDOENACCK(((Component)PNBDEMCAFIC).GetComponent<RectTransform>());
		if (Utils.ILLKGGBHMLF() != PlatformOS.Steamdeck)
		{
			return;
		}
		if (BIICOHKDJFI)
		{
			if (IOAGAFAGBKG)
			{
				LJMJGBODBFA.x = 420;
				LJMJGBODBFA.y = 401;
				LJMJGBODBFA.w = 440;
				LJMJGBODBFA.h = 68;
			}
			if ((int)PNBDEMCAFIC.characterValidation == 1 || (int)PNBDEMCAFIC.characterValidation == 2 || (int)PNBDEMCAFIC.characterValidation == 3)
			{
				EALCCKKMDFF = (EFloatingGamepadTextInputMode)3;
				Debug.LogError((object)"Numeric");
			}
			else
			{
				EALCCKKMDFF = (EFloatingGamepadTextInputMode)0;
			}
			SteamUtils.ShowFloatingGamepadTextInput(EALCCKKMDFF, LJMJGBODBFA.x, LJMJGBODBFA.y, LJMJGBODBFA.w, LJMJGBODBFA.h);
		}
		else
		{
			SteamUtils.ShowGamepadTextInput((EGamepadTextInputMode)0, (EGamepadTextInputLineMode)0, DJHGNINJDPO, OKILJJPCAOA, PNBDEMCAFIC.text);
		}
	}

	internal static void MGFCKMIOFED()
	{
		KKFFHLCLDDK("Dialogue System/Conversation/Crowly_Introduce/Entry/34/Dialogue Text");
	}

	internal static void FBBMMPKKHAF(out string IBJFCCHLAEG)
	{
		IBJFCCHLAEG = "next resolution";
	}

	[SpecialName]
	private static void JNAMBAMFDAK(bool AODONKKHPBP)
	{
		_003CJPOLGALBANI_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	private static void ALIOJDMPFGG(TMP_InputField AODONKKHPBP)
	{
		_003CBKEMKEIGPBE_003Ek__BackingField = AODONKKHPBP;
	}

	internal static void KOHIOCCONHL()
	{
		EBAPNGLJHEF("Items/item_description_1109");
	}

	internal static string HBEFPIODKNH(uint OKILJJPCAOA)
	{
		if (Utils.ILLKGGBHMLF() == PlatformOS.WindowsSteam)
		{
			string result = default(string);
			if (SteamUtils.GetEnteredGamepadTextInput(ref result, OKILJJPCAOA))
			{
				return result;
			}
			return " ";
		}
		return "add quest ";
	}

	internal static void LMDIACHODLA(TMP_InputField PNBDEMCAFIC, string DJHGNINJDPO, uint OKILJJPCAOA)
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Invalid comparison between Unknown and I4
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Invalid comparison between Unknown and I4
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Invalid comparison between Unknown and I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		BFDGMBFLMOI();
		IEEPJAKKLBK(AODONKKHPBP: false);
		KOAKGOGNHMN(PNBDEMCAFIC);
		LJMJGBODBFA = new GCPDOENACCK(((Component)PNBDEMCAFIC).GetComponent<RectTransform>());
		if (Utils.ILLKGGBHMLF() != PlatformOS.Windows)
		{
			return;
		}
		if (BIICOHKDJFI)
		{
			if (IOAGAFAGBKG)
			{
				LJMJGBODBFA.x = -174;
				LJMJGBODBFA.y = 104;
				LJMJGBODBFA.w = -47;
				LJMJGBODBFA.h = 2;
			}
			if ((int)PNBDEMCAFIC.characterValidation == 1 || (int)PNBDEMCAFIC.characterValidation == 5 || (int)PNBDEMCAFIC.characterValidation == 5)
			{
				EALCCKKMDFF = (EFloatingGamepadTextInputMode)3;
				Debug.LogError((object)"Perks/playerPerk_name_");
			}
			else
			{
				EALCCKKMDFF = (EFloatingGamepadTextInputMode)0;
			}
			SteamUtils.ShowFloatingGamepadTextInput(EALCCKKMDFF, LJMJGBODBFA.x, LJMJGBODBFA.y, LJMJGBODBFA.w, LJMJGBODBFA.h);
		}
		else
		{
			SteamUtils.ShowGamepadTextInput((EGamepadTextInputMode)0, (EGamepadTextInputLineMode)1, DJHGNINJDPO, OKILJJPCAOA, PNBDEMCAFIC.text);
		}
	}

	internal static void FKMDBGNPNGF(TMP_InputField PNBDEMCAFIC, string DJHGNINJDPO, uint OKILJJPCAOA)
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Invalid comparison between Unknown and I4
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Invalid comparison between Unknown and I4
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Invalid comparison between Unknown and I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		IAMBJKBABAP();
		CABICIPBCLJ(AODONKKHPBP: false);
		CJCMGGBDELO(PNBDEMCAFIC);
		LJMJGBODBFA = new GCPDOENACCK(((Component)PNBDEMCAFIC).GetComponent<RectTransform>());
		if (Utils.ILLKGGBHMLF() != 0)
		{
			return;
		}
		if (BIICOHKDJFI)
		{
			if (IOAGAFAGBKG)
			{
				LJMJGBODBFA.x = 67;
				LJMJGBODBFA.y = 195;
				LJMJGBODBFA.w = 166;
				LJMJGBODBFA.h = 112;
			}
			if ((int)PNBDEMCAFIC.characterValidation == 1 || (int)PNBDEMCAFIC.characterValidation == 6 || (int)PNBDEMCAFIC.characterValidation == 4)
			{
				EALCCKKMDFF = (EFloatingGamepadTextInputMode)6;
				Debug.LogError((object)"SetAnimatorObjectIntRPC");
			}
			else
			{
				EALCCKKMDFF = (EFloatingGamepadTextInputMode)1;
			}
			SteamUtils.ShowFloatingGamepadTextInput(EALCCKKMDFF, LJMJGBODBFA.x, LJMJGBODBFA.y, LJMJGBODBFA.w, LJMJGBODBFA.h);
		}
		else
		{
			SteamUtils.ShowGamepadTextInput((EGamepadTextInputMode)1, (EGamepadTextInputLineMode)0, DJHGNINJDPO, OKILJJPCAOA, PNBDEMCAFIC.text);
		}
	}

	internal static void LNPEOPHJEPH(out string IBJFCCHLAEG)
	{
		IBJFCCHLAEG = "Moving";
	}

	internal static void LOEJNMAMOBG()
	{
	}

	[SpecialName]
	public static bool ELLHJEBADPK()
	{
		return _003CJPOLGALBANI_003Ek__BackingField;
	}

	internal static void FIGMJHGAHEK()
	{
	}

	internal static void GIOEBLKHGLE(string IBJFCCHLAEG)
	{
		NKIOMDCJOAA(AODONKKHPBP: false);
		if (Utils.ILLKGGBHMLF() == PlatformOS.Windows)
		{
			if (BIICOHKDJFI)
			{
				SteamUtils.DismissFloatingGamepadTextInput();
			}
			else
			{
				SteamUtils.DismissGamepadTextInput();
			}
		}
	}

	internal static void LMPHJKPJDNB()
	{
		JOCDJPKMLIG("Items/item_description_1052");
	}

	internal static string NGEAMHMKCNI(uint OKILJJPCAOA)
	{
		if (Utils.ILLKGGBHMLF() == PlatformOS.Linux)
		{
			string result = default(string);
			if (SteamUtils.GetEnteredGamepadTextInput(ref result, OKILJJPCAOA))
			{
				return result;
			}
			return "Error_BedIsBlocking";
		}
		return "popUpBuilding2B";
	}

	internal static void BIMFHFEFBEI(out string IBJFCCHLAEG)
	{
		IBJFCCHLAEG = "Dialogue System/Conversation/Gass_Quest/Entry/32/Dialogue Text";
	}

	internal static void MBEJLHCGENB(out string IBJFCCHLAEG)
	{
		IBJFCCHLAEG = "Ax Level Low";
	}

	[SpecialName]
	internal static TMP_InputField LLGJDIHOHBE()
	{
		return _003CBKEMKEIGPBE_003Ek__BackingField;
	}

	internal static void BNCABECLJCI(string IBJFCCHLAEG)
	{
		GNFNHJPDBPE(AODONKKHPBP: false);
		if (Utils.ILLKGGBHMLF() == PlatformOS.MacOS)
		{
			if (BIICOHKDJFI)
			{
				SteamUtils.DismissFloatingGamepadTextInput();
			}
			else
			{
				SteamUtils.DismissGamepadTextInput();
			}
		}
	}

	[SpecialName]
	private static void JELFBCMHLCG(bool AODONKKHPBP)
	{
		_003CJPOLGALBANI_003Ek__BackingField = AODONKKHPBP;
	}

	internal static string JFIAMMKCKCB(uint OKILJJPCAOA)
	{
		if (Utils.ILLKGGBHMLF() == PlatformOS.Windows)
		{
			string result = default(string);
			if (SteamUtils.GetEnteredGamepadTextInput(ref result, OKILJJPCAOA))
			{
				return result;
			}
			return " / to pay: ";
		}
		return "qualityWater";
	}

	[SpecialName]
	private static void PINCLPELCFB(bool AODONKKHPBP)
	{
		_003CJPOLGALBANI_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	public static bool BFDGMBFLMOI()
	{
		return _003CJPOLGALBANI_003Ek__BackingField;
	}

	[SpecialName]
	private static void BFNIEANGNDF(TMP_InputField AODONKKHPBP)
	{
		_003CBKEMKEIGPBE_003Ek__BackingField = AODONKKHPBP;
	}

	internal static void JGNLGAIMDFD(out string IBJFCCHLAEG)
	{
		IBJFCCHLAEG = "{0}\nPlayers: {1}/{2}";
	}

	[SpecialName]
	private static void CABICIPBCLJ(bool AODONKKHPBP)
	{
		_003CJPOLGALBANI_003Ek__BackingField = AODONKKHPBP;
	}

	internal static void APIMPFOENEK(string IBJFCCHLAEG)
	{
		GNFNHJPDBPE(AODONKKHPBP: false);
		if (Utils.ILLKGGBHMLF() == PlatformOS.Windows)
		{
			if (BIICOHKDJFI)
			{
				SteamUtils.DismissFloatingGamepadTextInput();
			}
			else
			{
				SteamUtils.DismissGamepadTextInput();
			}
		}
	}

	internal static void AMMDIJHIPOM(TMP_InputField PNBDEMCAFIC, string DJHGNINJDPO, uint OKILJJPCAOA)
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Invalid comparison between Unknown and I4
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Invalid comparison between Unknown and I4
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Invalid comparison between Unknown and I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		JJFBJKCGOCE();
		GNFNHJPDBPE(AODONKKHPBP: true);
		EDCFHBJKJBC(PNBDEMCAFIC);
		LJMJGBODBFA = new GCPDOENACCK(((Component)PNBDEMCAFIC).GetComponent<RectTransform>());
		if (Utils.ILLKGGBHMLF() != PlatformOS.WindowsSteam)
		{
			return;
		}
		if (BIICOHKDJFI)
		{
			if (IOAGAFAGBKG)
			{
				LJMJGBODBFA.x = 48;
				LJMJGBODBFA.y = -120;
				LJMJGBODBFA.w = 69;
				LJMJGBODBFA.h = -12;
			}
			if ((int)PNBDEMCAFIC.characterValidation == 1 || (int)PNBDEMCAFIC.characterValidation == 4 || (int)PNBDEMCAFIC.characterValidation == 1)
			{
				EALCCKKMDFF = (EFloatingGamepadTextInputMode)3;
				Debug.LogError((object)"bob");
			}
			else
			{
				EALCCKKMDFF = (EFloatingGamepadTextInputMode)1;
			}
			SteamUtils.ShowFloatingGamepadTextInput(EALCCKKMDFF, LJMJGBODBFA.x, LJMJGBODBFA.y, LJMJGBODBFA.w, LJMJGBODBFA.h);
		}
		else
		{
			SteamUtils.ShowGamepadTextInput((EGamepadTextInputMode)0, (EGamepadTextInputLineMode)0, DJHGNINJDPO, OKILJJPCAOA, PNBDEMCAFIC.text);
		}
	}

	internal static void IJGAMMCHODO()
	{
	}

	internal static void KKFFHLCLDDK(string IBJFCCHLAEG)
	{
		KGLMPIMKBGM(AODONKKHPBP: false);
		if (Utils.ILLKGGBHMLF() == PlatformOS.Undefined)
		{
			if (BIICOHKDJFI)
			{
				SteamUtils.DismissFloatingGamepadTextInput();
			}
			else
			{
				SteamUtils.DismissGamepadTextInput();
			}
		}
	}

	[SpecialName]
	internal static TMP_InputField NJMLEBLLLNH()
	{
		return _003CBKEMKEIGPBE_003Ek__BackingField;
	}

	internal static void LOIBBLGCEBH(string IBJFCCHLAEG)
	{
		CAIOBILIKJB(AODONKKHPBP: false);
		if (Utils.ILLKGGBHMLF() == PlatformOS.LinuxSteam)
		{
			if (BIICOHKDJFI)
			{
				SteamUtils.DismissFloatingGamepadTextInput();
			}
			else
			{
				SteamUtils.DismissGamepadTextInput();
			}
		}
	}

	internal static void LDAHFDAILGN(string IBJFCCHLAEG)
	{
		IEEPJAKKLBK(AODONKKHPBP: false);
		if (Utils.ILLKGGBHMLF() == PlatformOS.Undefined)
		{
			if (BIICOHKDJFI)
			{
				SteamUtils.DismissFloatingGamepadTextInput();
			}
			else
			{
				SteamUtils.DismissGamepadTextInput();
			}
		}
	}

	internal static void FOPNCEKJFEH(TMP_InputField PNBDEMCAFIC, string DJHGNINJDPO, uint OKILJJPCAOA)
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Invalid comparison between Unknown and I4
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Invalid comparison between Unknown and I4
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Invalid comparison between Unknown and I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		BFDGMBFLMOI();
		BAPIELPPAHA(AODONKKHPBP: false);
		EDCFHBJKJBC(PNBDEMCAFIC);
		LJMJGBODBFA = new GCPDOENACCK(((Component)PNBDEMCAFIC).GetComponent<RectTransform>());
		if (Utils.ILLKGGBHMLF() != PlatformOS.Windows)
		{
			return;
		}
		if (BIICOHKDJFI)
		{
			if (IOAGAFAGBKG)
			{
				LJMJGBODBFA.x = -68;
				LJMJGBODBFA.y = -178;
				LJMJGBODBFA.w = 25;
				LJMJGBODBFA.h = -17;
			}
			if ((int)PNBDEMCAFIC.characterValidation == 0 || (int)PNBDEMCAFIC.characterValidation == 5 || (int)PNBDEMCAFIC.characterValidation == 6)
			{
				EALCCKKMDFF = (EFloatingGamepadTextInputMode)4;
				Debug.LogError((object)"ReceiveInfoTerrain");
			}
			else
			{
				EALCCKKMDFF = (EFloatingGamepadTextInputMode)1;
			}
			SteamUtils.ShowFloatingGamepadTextInput(EALCCKKMDFF, LJMJGBODBFA.x, LJMJGBODBFA.y, LJMJGBODBFA.w, LJMJGBODBFA.h);
		}
		else
		{
			SteamUtils.ShowGamepadTextInput((EGamepadTextInputMode)1, (EGamepadTextInputLineMode)1, DJHGNINJDPO, OKILJJPCAOA, PNBDEMCAFIC.text);
		}
	}

	internal static void JHHGCIMMBMM(TMP_InputField PNBDEMCAFIC, string DJHGNINJDPO, uint OKILJJPCAOA)
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Invalid comparison between Unknown and I4
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Invalid comparison between Unknown and I4
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Invalid comparison between Unknown and I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		EMKLCIIEBAM();
		GNFNHJPDBPE(AODONKKHPBP: false);
		KOAKGOGNHMN(PNBDEMCAFIC);
		LJMJGBODBFA = new GCPDOENACCK(((Component)PNBDEMCAFIC).GetComponent<RectTransform>());
		if (Utils.ILLKGGBHMLF() != PlatformOS.Steamdeck)
		{
			return;
		}
		if (BIICOHKDJFI)
		{
			if (IOAGAFAGBKG)
			{
				LJMJGBODBFA.x = 126;
				LJMJGBODBFA.y = 98;
				LJMJGBODBFA.w = 28;
				LJMJGBODBFA.h = 76;
			}
			if ((int)PNBDEMCAFIC.characterValidation == 0 || (int)PNBDEMCAFIC.characterValidation == 3 || (int)PNBDEMCAFIC.characterValidation == 6)
			{
				EALCCKKMDFF = (EFloatingGamepadTextInputMode)4;
				Debug.LogError((object)". Tavern level:");
			}
			else
			{
				EALCCKKMDFF = (EFloatingGamepadTextInputMode)0;
			}
			SteamUtils.ShowFloatingGamepadTextInput(EALCCKKMDFF, LJMJGBODBFA.x, LJMJGBODBFA.y, LJMJGBODBFA.w, LJMJGBODBFA.h);
		}
		else
		{
			SteamUtils.ShowGamepadTextInput((EGamepadTextInputMode)1, (EGamepadTextInputLineMode)1, DJHGNINJDPO, OKILJJPCAOA, PNBDEMCAFIC.text);
		}
	}

	internal static void CNGELJKEHCP()
	{
	}

	internal static void CHPCDJILJDC(string IBJFCCHLAEG)
	{
		OBLNDHGPAJB = false;
		if (Utils.ILLKGGBHMLF() == PlatformOS.MacOS)
		{
			if (BIICOHKDJFI)
			{
				SteamUtils.DismissFloatingGamepadTextInput();
			}
			else
			{
				SteamUtils.DismissGamepadTextInput();
			}
		}
	}

	[SpecialName]
	internal static TMP_InputField DJBKGOPKNHG()
	{
		return _003CBKEMKEIGPBE_003Ek__BackingField;
	}

	internal static void FFFCGJMBJFH()
	{
	}

	[SpecialName]
	private static void HPGMMLOPEAK(TMP_InputField AODONKKHPBP)
	{
		_003CBKEMKEIGPBE_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	public static bool LLPHHDGALAL()
	{
		return _003CJPOLGALBANI_003Ek__BackingField;
	}

	internal static void HAJJBMMLKFO(out string IBJFCCHLAEG)
	{
		IBJFCCHLAEG = "LE_11";
	}

	[SpecialName]
	private static void NJILNINHFHF(bool AODONKKHPBP)
	{
		_003CJPOLGALBANI_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	public static bool IAMBJKBABAP()
	{
		return _003CJPOLGALBANI_003Ek__BackingField;
	}

	[SpecialName]
	private static void BKPIJHBGKNA(bool AODONKKHPBP)
	{
		_003CJPOLGALBANI_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	private static void KGLMPIMKBGM(bool AODONKKHPBP)
	{
		_003CJPOLGALBANI_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	private static void PNBPGNKDOHF(TMP_InputField AODONKKHPBP)
	{
		_003CBKEMKEIGPBE_003Ek__BackingField = AODONKKHPBP;
	}

	internal static void IBCLFDJDJIH()
	{
		LDAHFDAILGN("Items/item_description_1092");
	}

	internal static void CDKBMJGEODM(string IBJFCCHLAEG)
	{
		PINCLPELCFB(AODONKKHPBP: true);
		if (Utils.ILLKGGBHMLF() == PlatformOS.MacOS)
		{
			if (BIICOHKDJFI)
			{
				SteamUtils.DismissFloatingGamepadTextInput();
			}
			else
			{
				SteamUtils.DismissGamepadTextInput();
			}
		}
	}

	internal static void KIIPLGFMLHP()
	{
		KIIPLGFMLHP("");
	}

	internal static void AIFNEHCBNBL(TMP_InputField PNBDEMCAFIC, string DJHGNINJDPO, uint OKILJJPCAOA)
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Invalid comparison between Unknown and I4
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Invalid comparison between Unknown and I4
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Invalid comparison between Unknown and I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		LLPHHDGALAL();
		BAPIELPPAHA(AODONKKHPBP: true);
		PNBPGNKDOHF(PNBDEMCAFIC);
		LJMJGBODBFA = new GCPDOENACCK(((Component)PNBDEMCAFIC).GetComponent<RectTransform>());
		if (Utils.ILLKGGBHMLF() != PlatformOS.WindowsGOG)
		{
			return;
		}
		if (BIICOHKDJFI)
		{
			if (IOAGAFAGBKG)
			{
				LJMJGBODBFA.x = -121;
				LJMJGBODBFA.y = 186;
				LJMJGBODBFA.w = 154;
				LJMJGBODBFA.h = -45;
			}
			if ((int)PNBDEMCAFIC.characterValidation == 0 || (int)PNBDEMCAFIC.characterValidation == 6 || (int)PNBDEMCAFIC.characterValidation == 2)
			{
				EALCCKKMDFF = (EFloatingGamepadTextInputMode)8;
				Debug.LogError((object)".gz");
			}
			else
			{
				EALCCKKMDFF = (EFloatingGamepadTextInputMode)0;
			}
			SteamUtils.ShowFloatingGamepadTextInput(EALCCKKMDFF, LJMJGBODBFA.x, LJMJGBODBFA.y, LJMJGBODBFA.w, LJMJGBODBFA.h);
		}
		else
		{
			SteamUtils.ShowGamepadTextInput((EGamepadTextInputMode)0, (EGamepadTextInputLineMode)1, DJHGNINJDPO, OKILJJPCAOA, PNBDEMCAFIC.text);
		}
	}

	internal static void OGANKDKAHHN()
	{
		APIMPFOENEK("Start water quality test");
	}

	[SpecialName]
	public static bool JMMDGEDMMCH()
	{
		return _003CJPOLGALBANI_003Ek__BackingField;
	}

	internal static void EPFDMKDPNLI(TMP_InputField PNBDEMCAFIC, string DJHGNINJDPO, uint OKILJJPCAOA)
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Invalid comparison between Unknown and I4
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Invalid comparison between Unknown and I4
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Invalid comparison between Unknown and I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		LGKCJHAKFHG();
		OBLNDHGPAJB = false;
		PNBPGNKDOHF(PNBDEMCAFIC);
		LJMJGBODBFA = new GCPDOENACCK(((Component)PNBDEMCAFIC).GetComponent<RectTransform>());
		if (Utils.ILLKGGBHMLF() != PlatformOS.LinuxSteam)
		{
			return;
		}
		if (BIICOHKDJFI)
		{
			if (IOAGAFAGBKG)
			{
				LJMJGBODBFA.x = 25;
				LJMJGBODBFA.y = -124;
				LJMJGBODBFA.w = 6;
				LJMJGBODBFA.h = -84;
			}
			if ((int)PNBDEMCAFIC.characterValidation == 1 || (int)PNBDEMCAFIC.characterValidation == 6 || (int)PNBDEMCAFIC.characterValidation == 5)
			{
				EALCCKKMDFF = (EFloatingGamepadTextInputMode)3;
				Debug.LogError((object)"Received upgrade tool RPC for toolID: ");
			}
			else
			{
				EALCCKKMDFF = (EFloatingGamepadTextInputMode)1;
			}
			SteamUtils.ShowFloatingGamepadTextInput(EALCCKKMDFF, LJMJGBODBFA.x, LJMJGBODBFA.y, LJMJGBODBFA.w, LJMJGBODBFA.h);
		}
		else
		{
			SteamUtils.ShowGamepadTextInput((EGamepadTextInputMode)1, (EGamepadTextInputLineMode)0, DJHGNINJDPO, OKILJJPCAOA, PNBDEMCAFIC.text);
		}
	}

	internal static void OGLGPCNAOPL(TMP_InputField PNBDEMCAFIC, string DJHGNINJDPO, uint OKILJJPCAOA)
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Invalid comparison between Unknown and I4
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Invalid comparison between Unknown and I4
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Invalid comparison between Unknown and I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		JJFBJKCGOCE();
		GNFNHJPDBPE(AODONKKHPBP: false);
		HMLMKJPIPHM(PNBDEMCAFIC);
		LJMJGBODBFA = new GCPDOENACCK(((Component)PNBDEMCAFIC).GetComponent<RectTransform>());
		if (Utils.ILLKGGBHMLF() != PlatformOS.Steamdeck)
		{
			return;
		}
		if (BIICOHKDJFI)
		{
			if (IOAGAFAGBKG)
			{
				LJMJGBODBFA.x = 35;
				LJMJGBODBFA.y = -195;
				LJMJGBODBFA.w = -91;
				LJMJGBODBFA.h = 65;
			}
			if ((int)PNBDEMCAFIC.characterValidation == 0 || (int)PNBDEMCAFIC.characterValidation == 0 || (int)PNBDEMCAFIC.characterValidation == 0)
			{
				EALCCKKMDFF = (EFloatingGamepadTextInputMode)2;
				Debug.LogError((object)"LE_12");
			}
			else
			{
				EALCCKKMDFF = (EFloatingGamepadTextInputMode)1;
			}
			SteamUtils.ShowFloatingGamepadTextInput(EALCCKKMDFF, LJMJGBODBFA.x, LJMJGBODBFA.y, LJMJGBODBFA.w, LJMJGBODBFA.h);
		}
		else
		{
			SteamUtils.ShowGamepadTextInput((EGamepadTextInputMode)0, (EGamepadTextInputLineMode)0, DJHGNINJDPO, OKILJJPCAOA, PNBDEMCAFIC.text);
		}
	}

	[SpecialName]
	public static bool EBIODBCNFDF()
	{
		return _003CJPOLGALBANI_003Ek__BackingField;
	}

	internal static void CLAPCGGKNOP()
	{
		IKGLEDEPBDE("You have to assign a UI camera!");
	}

	[SpecialName]
	internal static TMP_InputField GFBOGCADFJH()
	{
		return _003CBKEMKEIGPBE_003Ek__BackingField;
	}

	[SpecialName]
	private static void NIDPFDNEJOP(TMP_InputField AODONKKHPBP)
	{
		_003CBKEMKEIGPBE_003Ek__BackingField = AODONKKHPBP;
	}

	internal static string OMCFJJGKGAN(uint OKILJJPCAOA)
	{
		if (Utils.ILLKGGBHMLF() == PlatformOS.LinuxSteam)
		{
			string result = default(string);
			if (SteamUtils.GetEnteredGamepadTextInput(ref result, OKILJJPCAOA))
			{
				return result;
			}
			return "Talk";
		}
		return " - ";
	}

	internal static void EAIOODADLHE(TMP_InputField PNBDEMCAFIC, string DJHGNINJDPO, uint OKILJJPCAOA)
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Invalid comparison between Unknown and I4
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Invalid comparison between Unknown and I4
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Invalid comparison between Unknown and I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		EMKLCIIEBAM();
		IEEPJAKKLBK(AODONKKHPBP: false);
		PNBPGNKDOHF(PNBDEMCAFIC);
		LJMJGBODBFA = new GCPDOENACCK(((Component)PNBDEMCAFIC).GetComponent<RectTransform>());
		if (Utils.ILLKGGBHMLF() != PlatformOS.LinuxSteam)
		{
			return;
		}
		if (BIICOHKDJFI)
		{
			if (IOAGAFAGBKG)
			{
				LJMJGBODBFA.x = -164;
				LJMJGBODBFA.y = -198;
				LJMJGBODBFA.w = -71;
				LJMJGBODBFA.h = -13;
			}
			if ((int)PNBDEMCAFIC.characterValidation == 0 || (int)PNBDEMCAFIC.characterValidation == 5 || (int)PNBDEMCAFIC.characterValidation == 8)
			{
				EALCCKKMDFF = (EFloatingGamepadTextInputMode)1;
				Debug.LogError((object)"Not found ingredients for trends ");
			}
			else
			{
				EALCCKKMDFF = (EFloatingGamepadTextInputMode)0;
			}
			SteamUtils.ShowFloatingGamepadTextInput(EALCCKKMDFF, LJMJGBODBFA.x, LJMJGBODBFA.y, LJMJGBODBFA.w, LJMJGBODBFA.h);
		}
		else
		{
			SteamUtils.ShowGamepadTextInput((EGamepadTextInputMode)0, (EGamepadTextInputLineMode)0, DJHGNINJDPO, OKILJJPCAOA, PNBDEMCAFIC.text);
		}
	}

	[SpecialName]
	public static bool GGAKEEMCHOE()
	{
		return _003CJPOLGALBANI_003Ek__BackingField;
	}

	[SpecialName]
	private static void KOAKGOGNHMN(TMP_InputField AODONKKHPBP)
	{
		_003CBKEMKEIGPBE_003Ek__BackingField = AODONKKHPBP;
	}

	[SpecialName]
	private static void CMAFIODMOBB(bool AODONKKHPBP)
	{
		_003CJPOLGALBANI_003Ek__BackingField = AODONKKHPBP;
	}

	internal static void GIHLMBCACJI(TMP_InputField PNBDEMCAFIC, string DJHGNINJDPO, uint OKILJJPCAOA)
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Invalid comparison between Unknown and I4
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Invalid comparison between Unknown and I4
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Invalid comparison between Unknown and I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		_ = OBLNDHGPAJB;
		NKIOMDCJOAA(AODONKKHPBP: false);
		PNBPGNKDOHF(PNBDEMCAFIC);
		LJMJGBODBFA = new GCPDOENACCK(((Component)PNBDEMCAFIC).GetComponent<RectTransform>());
		if (Utils.ILLKGGBHMLF() != PlatformOS.WindowsSteam)
		{
			return;
		}
		if (BIICOHKDJFI)
		{
			if (IOAGAFAGBKG)
			{
				LJMJGBODBFA.x = -104;
				LJMJGBODBFA.y = -7;
				LJMJGBODBFA.w = 145;
				LJMJGBODBFA.h = 37;
			}
			if ((int)PNBDEMCAFIC.characterValidation == 0 || (int)PNBDEMCAFIC.characterValidation == 5 || (int)PNBDEMCAFIC.characterValidation == 2)
			{
				EALCCKKMDFF = (EFloatingGamepadTextInputMode)8;
				Debug.LogError((object)"Items/item_name_650");
			}
			else
			{
				EALCCKKMDFF = (EFloatingGamepadTextInputMode)1;
			}
			SteamUtils.ShowFloatingGamepadTextInput(EALCCKKMDFF, LJMJGBODBFA.x, LJMJGBODBFA.y, LJMJGBODBFA.w, LJMJGBODBFA.h);
		}
		else
		{
			SteamUtils.ShowGamepadTextInput((EGamepadTextInputMode)0, (EGamepadTextInputLineMode)0, DJHGNINJDPO, OKILJJPCAOA, PNBDEMCAFIC.text);
		}
	}

	internal static void GEOIBJMEAOK(string IBJFCCHLAEG)
	{
		JNAMBAMFDAK(AODONKKHPBP: false);
		if (Utils.ILLKGGBHMLF() == PlatformOS.Windows)
		{
			if (BIICOHKDJFI)
			{
				SteamUtils.DismissFloatingGamepadTextInput();
			}
			else
			{
				SteamUtils.DismissGamepadTextInput();
			}
		}
	}

	internal static string BIBKMLHDCOA(uint OKILJJPCAOA)
	{
		if (Utils.ILLKGGBHMLF() == PlatformOS.Undefined)
		{
			string result = default(string);
			if (SteamUtils.GetEnteredGamepadTextInput(ref result, OKILJJPCAOA))
			{
				return result;
			}
			return ".gz";
		}
		return "ChatWelcomeToTavern";
	}
}
