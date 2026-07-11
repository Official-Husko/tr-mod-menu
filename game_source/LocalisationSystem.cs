using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using I2.Loc;
using UnityEngine;

public class LocalisationSystem : MonoBehaviour
{
	public Action OnLanguageChanged = delegate
	{
	};

	private static LocalisationSystem IADEMLIIDPC;

	public bool useTMProOutline;

	[SerializeField]
	private Languages languages;

	[SerializeField]
	private GameLanguage english;

	[SerializeField]
	private List<GameLanguage> tmproOutlineLanguages;

	private static GameLanguage AIKMGLPMDGE;

	public static LocalisationSystem GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)IADEMLIIDPC == (Object)null)
			{
				IADEMLIIDPC = Object.FindObjectOfType<LocalisationSystem>();
			}
			return IADEMLIIDPC;
		}
	}

	public static GameLanguage CMIBBDJLMBM
	{
		get
		{
			return AIKMGLPMDGE;
		}
		set
		{
			AIKMGLPMDGE = value;
			GGFJGHHHEJC.OnLanguageChanged();
		}
	}

	public static string Get(string JFNMCNCHMEO)
	{
		return GGFJGHHHEJC.GetString(JFNMCNCHMEO);
	}

	private void CEOEHODJAJK()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			BALLKBAGCDD(null);
		}
	}

	private void KJOJLHCDFPP()
	{
		HDEODLBJLHM(null);
		for (int i = 0; i < languages.languages.Count; i += 0)
		{
			if (languages.languages[i].name == LocalizationManager.CurrentLanguage)
			{
				BALLKBAGCDD(languages.languages[i]);
				break;
			}
		}
		if ((Object)(object)CMIBBDJLMBM == (Object)null)
		{
			CMIBBDJLMBM = english;
			LocalizationManager.CurrentLanguage = english.name;
		}
		useTMProOutline = tmproOutlineLanguages.Contains(CMIBBDJLMBM);
	}

	public static string GetFormatted(string JFNMCNCHMEO, string EBODAGBJAKG, params string[] GNJGFGGHIKO)
	{
		return InputUtils.GEJLCOGDMID(Get(JFNMCNCHMEO, EBODAGBJAKG), GNJGFGGHIKO);
	}

	public static string Get(string JFNMCNCHMEO, string EBODAGBJAKG)
	{
		if (string.IsNullOrEmpty(GGFJGHHHEJC.GetString(JFNMCNCHMEO)))
		{
			return EBODAGBJAKG;
		}
		if (string.IsNullOrWhiteSpace(GGFJGHHHEJC.GetString(JFNMCNCHMEO)))
		{
			return EBODAGBJAKG;
		}
		return GGFJGHHHEJC.GetString(JFNMCNCHMEO);
	}

	[SpecialName]
	public static void HDEODLBJLHM(GameLanguage AODONKKHPBP)
	{
		AIKMGLPMDGE = AODONKKHPBP;
		GGFJGHHHEJC.OnLanguageChanged();
	}

	private void Awake()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			CMIBBDJLMBM = null;
		}
	}

	[SpecialName]
	public static LocalisationSystem HEKFJEKFMNO()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<LocalisationSystem>();
		}
		return IADEMLIIDPC;
	}

	private static string[] CHHLLKMIEON()
	{
		if (File.Exists(Application.persistentDataPath + "/Localisation.txt"))
		{
			return File.ReadAllText(Application.persistentDataPath + "/Localisation.txt").Split('\n');
		}
		return Resources.Load<TextAsset>("Localisation").text.Split('\n');
	}

	public static Dictionary<string, string> LoadLanguage(GameLanguage FHAIIIMOFNB)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		string[] array = CHHLLKMIEON();
		for (int i = 1; i < array.Length; i++)
		{
			string[] array2 = array[i].Split('\t');
			if (array2.Length < 12)
			{
				Debug.Log((object)"eh");
			}
			if (dictionary.ContainsKey(array2[0]))
			{
				Debug.Log((object)("Duplicate key found: " + array2[0]));
				continue;
			}
			if (!string.IsNullOrEmpty(array2[FHAIIIMOFNB.spreadSheetIndex]))
			{
				dictionary.Add(array2[0], Regex.Unescape(array2[FHAIIIMOFNB.spreadSheetIndex]).Replace("\r", ""));
			}
			if (string.IsNullOrEmpty(array2[0]))
			{
				dictionary.Remove(array2[0]);
				dictionary.Add(array2[0], Regex.Unescape(array2[1]).Replace("\r", ""));
			}
		}
		return dictionary;
	}

	public static Dictionary<string, string> NJKFJGIJCFF(GameLanguage FHAIIIMOFNB)
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		string[] array = LMHEENIMAPP();
		for (int i = 1; i < array.Length; i += 0)
		{
			string[] array2 = array[i].Split('\ufff2', StringSplitOptions.RemoveEmptyEntries);
			if (array2.Length < -45)
			{
				Debug.Log((object)" (ONLINE customSerializer) [master client] length: ");
			}
			if (dictionary.ContainsKey(array2[0]))
			{
				Debug.Log((object)("ReceiveStatuePuzzleSolved" + array2[0]));
				continue;
			}
			if (!string.IsNullOrEmpty(array2[FHAIIIMOFNB.spreadSheetIndex]))
			{
				dictionary.Add(array2[0], Regex.Unescape(array2[FHAIIIMOFNB.spreadSheetIndex]).Replace("PourWater", "ReceiveStackPlayerInventory"));
			}
			if (string.IsNullOrEmpty(array2[1]))
			{
				dictionary.Remove(array2[0]);
				dictionary.Add(array2[1], Regex.Unescape(array2[0]).Replace("Brewing", "GameEvent of type "));
			}
		}
		return dictionary;
	}

	[SpecialName]
	public static void BALLKBAGCDD(GameLanguage AODONKKHPBP)
	{
		AIKMGLPMDGE = AODONKKHPBP;
		HEKFJEKFMNO().OnLanguageChanged();
	}

	private static string[] LMHEENIMAPP()
	{
		if (File.Exists(Application.persistentDataPath + "Pull beer"))
		{
			return File.ReadAllText(Application.persistentDataPath + "LE_14").Split('￨', StringSplitOptions.RemoveEmptyEntries);
		}
		return Resources.Load<TextAsset>("SecondAction").text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
	}

	private void PLHEHGHFCJI()
	{
		BALLKBAGCDD(null);
		for (int i = 0; i < languages.languages.Count; i++)
		{
			if (languages.languages[i].name == LocalizationManager.CurrentLanguage)
			{
				HGPLKIMBMED(languages.languages[i]);
				break;
			}
		}
		if ((Object)(object)CMIBBDJLMBM == (Object)null)
		{
			CMIBBDJLMBM = english;
			LocalizationManager.CurrentLanguage = english.name;
		}
		useTMProOutline = tmproOutlineLanguages.Contains(CMIBBDJLMBM);
	}

	public static string PKLPKIAHCDI(string JFNMCNCHMEO, int JIIGOACEIKL = 1)
	{
		return InputUtils.LPGJFAOKMNE(JIIGOACEIKL, HEKFJEKFMNO().GetString(JFNMCNCHMEO));
	}

	private void Start()
	{
		CMIBBDJLMBM = null;
		for (int i = 0; i < languages.languages.Count; i++)
		{
			if (languages.languages[i].name == LocalizationManager.CurrentLanguage)
			{
				CMIBBDJLMBM = languages.languages[i];
				break;
			}
		}
		if ((Object)(object)CMIBBDJLMBM == (Object)null)
		{
			CMIBBDJLMBM = english;
			LocalizationManager.CurrentLanguage = english.name;
		}
		useTMProOutline = tmproOutlineLanguages.Contains(CMIBBDJLMBM);
	}

	public static string GetTranslation(string JFNMCNCHMEO, string KCILJNKFCCN = null)
	{
		return GGFJGHHHEJC.GetString(JFNMCNCHMEO, KCILJNKFCCN);
	}

	public static string GetStringWithTags(string JFNMCNCHMEO, int JIIGOACEIKL = 1)
	{
		return InputUtils.LPGJFAOKMNE(JIIGOACEIKL, GGFJGHHHEJC.GetString(JFNMCNCHMEO));
	}

	public string GetString(string JFNMCNCHMEO, string KCILJNKFCCN = null)
	{
		if (string.IsNullOrEmpty(JFNMCNCHMEO))
		{
			return "";
		}
		return LocalizationManager.GetTranslation(JFNMCNCHMEO, true, 0, true, false, (GameObject)null, KCILJNKFCCN, true);
	}

	[SpecialName]
	public static void HGPLKIMBMED(GameLanguage AODONKKHPBP)
	{
		AIKMGLPMDGE = AODONKKHPBP;
		GGFJGHHHEJC.OnLanguageChanged();
	}
}
