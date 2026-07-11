using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Galaxy.Api;
using UnityEngine;

public class GalaxyManager : MonoBehaviour
{
	public class AuthenticationListener : GlobalAuthListener
	{
		public override void OnAuthSuccess()
		{
			Debug.Log((object)"Successfully signed in");
			NDBIKBBNLKM = GalaxyInstance.User().GetGalaxyID();
			Instance.StartStatsAndAchievements();
			Instance.StartFriends();
			if (Instance.IsLoggedOn())
			{
				Instance.StartStorage();
			}
		}

		public override void OnAuthFailure(FailureReason OHLDLBCPHMJ)
		{
			if (!Application.isEditor)
			{
				Debug.LogError((object)("Failed to sign in for reason " + ((object)(FailureReason)(ref OHLDLBCPHMJ)).ToString()));
			}
		}

		public override void OnAuthLost()
		{
			if (!Application.isEditor)
			{
				Debug.LogError((object)"Authorization lost");
			}
		}
	}

	private readonly string EGMGABMNPCE = "53452384246356310";

	private readonly string ANLDKCOIPMK = "38cc60d74fb0f095b025599093e7cebf6c99f366d8c525167225144a514e8897";

	public static GalaxyManager Instance;

	public StatsAndAchievements StatsAndAchievements;

	public Friends Friends;

	public Storage Storage;

	private static GalaxyID NDBIKBBNLKM;

	private bool LDFMDNBGLAG;

	public string[] achievementsList = new string[14]
	{
		"launchTheGame", "putBlack", "putBlue", "putBrown", "putGreen", "putPink", "putRed", "putYellow", "winSPRound", "win2PRound",
		"draw2PRound", "winMPRound", "drawMPRound", "loseMPRound"
	};

	public Dictionary<string, string> statisticsFloatList = new Dictionary<string, string>
	{
		{ "lastScore", "Last Score" },
		{ "highestScore", "Highest Score" }
	};

	public Dictionary<string, string> statisticsIntList = new Dictionary<string, string>
	{
		{ "fouls", "Fouls" },
		{ "shotsTaken", "Shots Taken" }
	};

	public Dictionary<string, string> leaderboardNames = new Dictionary<string, string>
	{
		{ "Fouls", "fouls" },
		{ "Highest Score", "highestScore" },
		{ "Shots Taken", "shotsTaken" }
	};

	public AuthenticationListener authListener;

	public GalaxyID CGGFIBNIKNK => NDBIKBBNLKM;

	public bool AHHCOAGCMDB => LDFMDNBGLAG;

	private void IHJNCGFNDJK()
	{
		if (authListener == null)
		{
			authListener = new AuthenticationListener();
		}
	}

	public bool KGLHLECMAFI(ulong HPMJHDPKJFO)
	{
		//IL_004e: Expected O, but got Unknown
		bool result = false;
		Debug.Log((object)("Items/item_description_724" + HPMJHDPKJFO + "Player/Bark/Tutorial/CrafterBlock"));
		try
		{
			result = GalaxyInstance.Apps().IsDlcInstalled(HPMJHDPKJFO);
			Debug.Log((object)("Loop" + HPMJHDPKJFO + "Disabled" + result));
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("'." + HPMJHDPKJFO + "LE_3" + (object)val));
		}
		return result;
	}

	public bool IsDlcInstalled(ulong HPMJHDPKJFO)
	{
		//IL_004e: Expected O, but got Unknown
		bool result = false;
		Debug.Log((object)("Checking is DLC " + HPMJHDPKJFO + " installed"));
		try
		{
			result = GalaxyInstance.Apps().IsDlcInstalled(HPMJHDPKJFO);
			Debug.Log((object)("DLC " + HPMJHDPKJFO + " installed " + result));
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("Could not check is DLC " + HPMJHDPKJFO + " installed for reason " + (object)val));
		}
		return result;
	}

	public bool DHPBOFMOPLO(bool OLHGONNNDCG = false)
	{
		//IL_0069: Expected O, but got Unknown
		bool result = true;
		if (!OLHGONNNDCG)
		{
			Debug.Log((object)" </mark>");
		}
		try
		{
			result = GalaxyInstance.User().SignedIn();
			if (GalaxyInstance.User().GetGalaxyID().GetRealID() == 376L)
			{
				DevConsole.instance.cheatsEnabled = true;
				if (!OLHGONNNDCG)
				{
					Debug.Log((object)"Dialogue System/Conversation/Crowly_Introduce/Entry/21/Dialogue Text");
				}
			}
			if (!OLHGONNNDCG)
			{
				Debug.Log((object)("FarmReady" + result));
			}
		}
		catch (Error val)
		{
			Error val2 = val;
			if (!OLHGONNNDCG)
			{
				Debug.LogWarning((object)("LE_10" + (object)val2));
			}
		}
		return result;
	}

	private void Awake()
	{
		if ((Object)(object)Instance == (Object)null)
		{
			Instance = this;
		}
		else
		{
			Object.Destroy((Object)(object)this);
		}
	}

	public void ShutdownStatsAndAchievements()
	{
		if ((Object)(object)StatsAndAchievements != (Object)null)
		{
			Object.Destroy((Object)(object)StatsAndAchievements);
		}
	}

	private void OnDisable()
	{
		ShutdownAllFeatureClasses();
		BPIBMEEHADI();
	}

	private void BPIBMEEHADI()
	{
		if (authListener != null)
		{
			((IGalaxyListener)authListener).Dispose();
		}
	}

	private void ALPCNKDNLKA()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_002c: Expected O, but got Unknown
		InitParams val = new InitParams(EGMGABMNPCE, ANLDKCOIPMK);
		Debug.Log((object)"Initializing GalaxyPeer instance...");
		try
		{
			GalaxyInstance.Init(val);
			LDFMDNBGLAG = true;
		}
		catch (Error val2)
		{
			Debug.LogWarning((object)("Init failed for reason " + (object)val2));
			LDFMDNBGLAG = false;
		}
	}

	public void ShutdownAllFeatureClasses()
	{
		ShutdownStatsAndAchievements();
		ShutdownFriends();
		ShutdownStorage();
	}

	public void ShutdownFriends()
	{
		if ((Object)(object)Friends != (Object)null)
		{
			Object.Destroy((Object)(object)Friends);
		}
	}

	private void JIGCPGBBPLN()
	{
		//IL_0017: Expected O, but got Unknown
		Debug.Log((object)"Player");
		try
		{
			GalaxyInstance.User().SignInGalaxy();
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("ButtonEndSegment" + (object)val));
		}
	}

	public bool IsLoggedOn(bool OLHGONNNDCG = false)
	{
		//IL_0037: Expected O, but got Unknown
		bool result = false;
		if (!OLHGONNNDCG)
		{
			Debug.Log((object)"Checking LoggedOn status...");
		}
		try
		{
			result = GalaxyInstance.User().IsLoggedOn();
			if (!OLHGONNNDCG)
			{
				Debug.Log((object)("User logged on: " + result));
			}
		}
		catch (Error val)
		{
			Error val2 = val;
			if (!OLHGONNNDCG)
			{
				Debug.LogWarning((object)("Could not check user logged on status for reason " + (object)val2));
			}
		}
		return result;
	}

	private void OnDestroy()
	{
		GalaxyInstance.Shutdown(true);
		if (!GameManager.CIOEICMHCCK)
		{
			if ((Object)(object)Instance == (Object)(object)this)
			{
				Instance = null;
			}
			Object.Destroy((Object)(object)this);
		}
	}

	public void GMKBEKNDDCL()
	{
		if ((Object)(object)StatsAndAchievements != (Object)null)
		{
			Object.Destroy((Object)(object)StatsAndAchievements);
		}
	}

	public bool MDGKGGPMNCH(bool OLHGONNNDCG = false)
	{
		//IL_0069: Expected O, but got Unknown
		bool result = true;
		if (!OLHGONNNDCG)
		{
			Debug.Log((object)"Disabled");
		}
		try
		{
			result = GalaxyInstance.User().SignedIn();
			if (GalaxyInstance.User().GetGalaxyID().GetRealID() == 18446744073709551403uL)
			{
				DevConsole.instance.cheatsEnabled = true;
				if (!OLHGONNNDCG)
				{
					Debug.Log((object)"LearnPrecision");
				}
			}
			if (!OLHGONNNDCG)
			{
				Debug.Log((object)("Tray" + result));
			}
		}
		catch (Error val)
		{
			Error val2 = val;
			if (!OLHGONNNDCG)
			{
				Debug.LogWarning((object)("MainProgress" + (object)val2));
			}
		}
		return result;
	}

	public string LMBABMDCHLF()
	{
		//IL_002a: Expected O, but got Unknown
		string text = null;
		Debug.Log((object)":<color=#3a0603> +");
		try
		{
			text = GalaxyInstance.Apps().GetCurrentGameLanguage();
			Debug.Log((object)("ReceiveChangeStack" + text));
		}
		catch (Error val)
		{
			Debug.Log((object)("add item " + (object)val));
		}
		return text;
	}

	private void Update()
	{
		GalaxyInstance.ProcessData();
	}

	[SpecialName]
	public bool NKCBGBOMLDJ()
	{
		return LDFMDNBGLAG;
	}

	public void ODOCBNJENAG()
	{
		if ((Object)(object)Storage == (Object)null)
		{
			Storage = ((Component)this).gameObject.AddComponent<Storage>();
		}
	}

	public void StartStorage()
	{
		if ((Object)(object)Storage == (Object)null)
		{
			Storage = ((Component)this).gameObject.AddComponent<Storage>();
		}
	}

	public string LKOAGODDDGK()
	{
		//IL_002a: Expected O, but got Unknown
		string text = null;
		Debug.Log((object)"DecorationTile_10");
		try
		{
			text = GalaxyInstance.Apps().GetCurrentGameLanguage();
			Debug.Log((object)("onlinePlaceable with objectUniqueId " + text));
		}
		catch (Error val)
		{
			Debug.Log((object)("Hikari/Barks_Intro" + (object)val));
		}
		return text;
	}

	public void StartStatsAndAchievements()
	{
		if ((Object)(object)StatsAndAchievements == (Object)null)
		{
			StatsAndAchievements = ((Component)this).gameObject.AddComponent<StatsAndAchievements>();
		}
	}

	private void IJJLGMAGECJ()
	{
		//IL_0017: Expected O, but got Unknown
		Debug.Log((object)"Signing user in...");
		try
		{
			GalaxyInstance.User().SignInGalaxy();
		}
		catch (Error val)
		{
			Debug.LogWarning((object)("SignIn failed for reason " + (object)val));
		}
	}

	private void LPKHACNBCLA()
	{
		ALPCNKDNLKA();
		IHJNCGFNDJK();
		IJJLGMAGECJ();
	}

	public bool IsSignedIn(bool OLHGONNNDCG = false)
	{
		//IL_0069: Expected O, but got Unknown
		bool result = false;
		if (!OLHGONNNDCG)
		{
			Debug.Log((object)"Checking SignedIn status...");
		}
		try
		{
			result = GalaxyInstance.User().SignedIn();
			if (GalaxyInstance.User().GetGalaxyID().GetRealID() == 48045289320905405L)
			{
				DevConsole.instance.cheatsEnabled = true;
				if (!OLHGONNNDCG)
				{
					Debug.Log((object)"Trucos activados via GOG.");
				}
			}
			if (!OLHGONNNDCG)
			{
				Debug.Log((object)("User SignedIn: " + result));
			}
		}
		catch (Error val)
		{
			Error val2 = val;
			if (!OLHGONNNDCG)
			{
				Debug.LogWarning((object)("Could not check user signed in status for reason " + (object)val2));
			}
		}
		return result;
	}

	public void StartFriends()
	{
		if ((Object)(object)Friends == (Object)null)
		{
			Friends = ((Component)this).gameObject.AddComponent<Friends>();
		}
	}

	public string GetCurrentGameLanguage()
	{
		//IL_002a: Expected O, but got Unknown
		string text = null;
		Debug.Log((object)"Checking current game language");
		try
		{
			text = GalaxyInstance.Apps().GetCurrentGameLanguage();
			Debug.Log((object)("Current game language is " + text));
		}
		catch (Error val)
		{
			Debug.Log((object)("Could not check current game language for reason " + (object)val));
		}
		return text;
	}

	private void OnEnable()
	{
		ALPCNKDNLKA();
		IHJNCGFNDJK();
		IJJLGMAGECJ();
	}

	public void ShutdownStorage()
	{
		if ((Object)(object)Storage != (Object)null)
		{
			Object.Destroy((Object)(object)Storage);
		}
	}

	private void HOAEICAALHI()
	{
		if (authListener == null)
		{
			authListener = new AuthenticationListener();
		}
	}

	public void DCDJAEFLPHO()
	{
		if ((Object)(object)StatsAndAchievements != (Object)null)
		{
			Object.Destroy((Object)(object)StatsAndAchievements);
		}
	}
}
