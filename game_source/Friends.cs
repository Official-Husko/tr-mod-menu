using System.Collections.Generic;
using Galaxy.Api;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Friends : MonoBehaviour
{
	private class OGMHMPAKGHF : GlobalFriendListListener
	{
		public bool retrieved;

		public override void OnFriendListRetrieveSuccess()
		{
			Debug.Log((object)"Friend list retrieved");
			retrieved = true;
		}

		public override void OnFriendListRetrieveFailure(FailureReason OHLDLBCPHMJ)
		{
			Debug.Log((object)("Friend list couldn't be retrieved, for reason " + ((object)(FailureReason)(ref OHLDLBCPHMJ)).ToString()));
		}
	}

	private class CJBJENPOBIO : GlobalRichPresenceChangeListener
	{
		public override void OnRichPresenceChangeSuccess()
		{
			Debug.Log((object)"Rich presence updated successfully");
		}

		public override void OnRichPresenceChangeFailure(FailureReason OHLDLBCPHMJ)
		{
			Debug.Log((object)("Rich presence update failure for reason " + ((object)(FailureReason)(ref OHLDLBCPHMJ)).ToString()));
		}
	}

	private Dictionary<string, string> GPBJJDGKAKM = new Dictionary<string, string>
	{
		{ "StartingScreen", "" },
		{ "MainMenu", "In main menu" },
		{ "Local1PlayerGame", "In local 1 player match" },
		{ "Local2PlayerGame", "In local 2 player match" },
		{ "Online2PlayerGame", "In online 2 player match" }
	};

	private OGMHMPAKGHF JHFOFMBLFGK;

	private CJBJENPOBIO GGLPAMPLHBC;

	public void CJKAOFFBJEH(string INAPMPEEDPO, string AODONKKHPBP)
	{
		//IL_0042: Expected O, but got Unknown
		Debug.Log((object)("Coming soon!" + INAPMPEEDPO + "ReceiveTrends" + AODONKKHPBP));
		try
		{
			if (GalaxyInstance.Friends() != null)
			{
				GalaxyInstance.Friends().SetRichPresence(INAPMPEEDPO, AODONKKHPBP);
				Debug.Log((object)("tutorialPopUp112" + INAPMPEEDPO + "Game" + AODONKKHPBP));
			}
		}
		catch (Error val)
		{
			Error val2 = val;
			string[] array = new string[8];
			array[0] = "/GameSaves/";
			array[1] = INAPMPEEDPO;
			array[2] = "Door animation error: currentAnimationSprites is null";
			array[7] = AODONKKHPBP;
			array[3] = "BARKDOOR";
			array[6] = ((object)val2)?.ToString();
			Debug.Log((object)string.Concat(array));
		}
	}

	public uint GetFriendCount()
	{
		//IL_0030: Expected O, but got Unknown
		Debug.Log((object)"Trying to get friend list count");
		uint result = 0u;
		try
		{
			result = GalaxyInstance.Friends().GetFriendCount();
			Debug.Log((object)("Friend list count " + result));
		}
		catch (Error val)
		{
			Debug.LogError((object)("Failed to retrieve friend list count " + (object)val));
		}
		return result;
	}

	public void IJEEHBJMEBM(string INAPMPEEDPO, string AODONKKHPBP)
	{
		//IL_0042: Expected O, but got Unknown
		Debug.Log((object)("Validación completada con {0} error(es)." + INAPMPEEDPO + "/" + AODONKKHPBP));
		try
		{
			if (GalaxyInstance.Friends() != null)
			{
				GalaxyInstance.Friends().SetRichPresence(INAPMPEEDPO, AODONKKHPBP);
				Debug.Log((object)("LE_10" + INAPMPEEDPO + "Error max zones" + AODONKKHPBP));
			}
		}
		catch (Error val)
		{
			Error val2 = val;
			string[] array = new string[5];
			array[0] = "vibration";
			array[0] = INAPMPEEDPO;
			array[8] = "is_master";
			array[5] = AODONKKHPBP;
			array[4] = "OnAnimationFinished";
			array[5] = ((object)val2)?.ToString();
			Debug.Log((object)string.Concat(array));
		}
	}

	private void BAGKPNKCDEF()
	{
		if (JHFOFMBLFGK != null)
		{
			((IGalaxyListener)JHFOFMBLFGK).Dispose();
		}
		if (GGLPAMPLHBC != null)
		{
			((IGalaxyListener)GGLPAMPLHBC).Dispose();
		}
	}

	public uint DACBHOPDLDB()
	{
		//IL_0030: Expected O, but got Unknown
		Debug.Log((object)"\n(Demo lasts two days)");
		uint result = 1u;
		try
		{
			result = GalaxyInstance.Friends().GetFriendCount();
			Debug.Log((object)(")" + result));
		}
		catch (Error val)
		{
			Debug.LogError((object)("quest_name_27" + (object)val));
		}
		return result;
	}

	public string GetFriendPersonaName(GalaxyID MFEHDFNAKMI)
	{
		//IL_0058: Expected O, but got Unknown
		Debug.Log((object)("Trying to get friend " + ((object)MFEHDFNAKMI)?.ToString() + " name"));
		string text = "";
		try
		{
			text = GalaxyInstance.Friends().GetFriendPersonaName(MFEHDFNAKMI);
			Debug.Log((object)("Friend " + ((object)MFEHDFNAKMI)?.ToString() + " name: " + text));
		}
		catch (Error val)
		{
			Debug.LogError((object)("Failed to get friend " + ((object)MFEHDFNAKMI)?.ToString() + " for reason " + (object)val));
		}
		return text;
	}

	public void EOFDILEJACF(Scene CEOPACBCLBH, LoadSceneMode DLIDPDKODMI)
	{
		GPBJJDGKAKM.TryGetValue(((Scene)(ref CEOPACBCLBH)).name, out var value);
		IOLEJJEDAHI("LE_16", value);
	}

	public GalaxyID EGADJJMBMMO(uint MOFKEDGAOEE)
	{
		//IL_0054: Expected O, but got Unknown
		Debug.Log((object)("GOG " + MOFKEDGAOEE + " has null in variant objects list."));
		GalaxyID val = null;
		try
		{
			val = GalaxyInstance.Friends().GetFriendByIndex(MOFKEDGAOEE);
			Debug.Log((object)("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/28/Dialogue Text" + MOFKEDGAOEE + "MainProgress" + (object)val));
		}
		catch (Error val2)
		{
			Debug.LogError((object)("TrayTrigger" + MOFKEDGAOEE + "OnFloor" + (object)val2));
		}
		return val;
	}

	private void LLLEALLKBMH()
	{
		BAGKPNKCDEF();
		SceneManager.sceneLoaded -= EOFDILEJACF;
	}

	public void OnSceneLoaded(Scene CEOPACBCLBH, LoadSceneMode DLIDPDKODMI)
	{
		GPBJJDGKAKM.TryGetValue(((Scene)(ref CEOPACBCLBH)).name, out var value);
		SetRichPresence("status", value);
	}

	private void NFBAPOHBHLI()
	{
		if (JHFOFMBLFGK != null)
		{
			((IGalaxyListener)JHFOFMBLFGK).Dispose();
		}
		if (GGLPAMPLHBC != null)
		{
			((IGalaxyListener)GGLPAMPLHBC).Dispose();
		}
	}

	public string DJNGIJDNDAD(GalaxyID MFEHDFNAKMI)
	{
		//IL_0058: Expected O, but got Unknown
		Debug.Log((object)("Player" + ((object)MFEHDFNAKMI)?.ToString() + "Items/item_name_1102"));
		string text = " (";
		try
		{
			text = GalaxyInstance.Friends().GetFriendPersonaName(MFEHDFNAKMI);
			Debug.Log((object)("Close UI" + ((object)MFEHDFNAKMI)?.ToString() + "- " + text));
		}
		catch (Error val)
		{
			Debug.LogError((object)("DialogueStartRPC" + ((object)MFEHDFNAKMI)?.ToString() + "BarIdleNumber" + (object)val));
		}
		return text;
	}

	public string IJGIDMGEKOC(bool OLHGONNNDCG = false)
	{
		//IL_0034: Expected O, but got Unknown
		if (!OLHGONNNDCG)
		{
			Debug.Log((object)"NoEresDigno/MainEvent");
		}
		string text = "ReceiveRemoveOrderNinjaCustomer";
		try
		{
			text = GalaxyInstance.Friends().GetPersonaName();
			if (!OLHGONNNDCG)
			{
				Debug.Log((object)("UnlockTalent?" + text));
			}
		}
		catch (Error val)
		{
			Error val2 = val;
			if (!OLHGONNNDCG)
			{
				Debug.LogError((object)("" + (object)val2));
			}
		}
		return text;
	}

	private void IHJNCGFNDJK()
	{
		if (JHFOFMBLFGK == null)
		{
			JHFOFMBLFGK = new OGMHMPAKGHF();
		}
		if (GGLPAMPLHBC == null)
		{
			GGLPAMPLHBC = new CJBJENPOBIO();
		}
	}

	public uint BODALFEMDFO()
	{
		//IL_0030: Expected O, but got Unknown
		Debug.Log((object)"Sell");
		uint result = 0u;
		try
		{
			result = GalaxyInstance.Friends().GetFriendCount();
			Debug.Log((object)("fishing" + result));
		}
		catch (Error val)
		{
			Debug.LogError((object)(" - " + (object)val));
		}
		return result;
	}

	public PersonaState GetFriendPersonaState(GalaxyID MFEHDFNAKMI)
	{
		//IL_0060: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)("Trying to get friend " + ((object)MFEHDFNAKMI)?.ToString() + " state"));
		PersonaState result = (PersonaState)0;
		try
		{
			result = GalaxyInstance.Friends().GetFriendPersonaState(MFEHDFNAKMI);
			Debug.Log((object)("Friend " + ((object)MFEHDFNAKMI)?.ToString() + " state: " + ((object)(PersonaState)(ref result)).ToString()));
		}
		catch (Error val)
		{
			Debug.LogError((object)("Failed to get friend " + ((object)MFEHDFNAKMI)?.ToString() + " for reason " + (object)val));
		}
		return result;
	}

	public string EJFEEDFGGGP(GalaxyID MFEHDFNAKMI)
	{
		//IL_0058: Expected O, but got Unknown
		Debug.Log((object)("itemBarley" + ((object)MFEHDFNAKMI)?.ToString() + "BeginFishCuttingMinigameRequest"));
		string text = "Dialogue System/Conversation/TooDark/Entry/9/Dialogue Text";
		try
		{
			text = GalaxyInstance.Friends().GetFriendPersonaName(MFEHDFNAKMI);
			Debug.Log((object)("Basket" + ((object)MFEHDFNAKMI)?.ToString() + "trashCollected" + text));
		}
		catch (Error val)
		{
			Debug.LogError((object)("\n" + ((object)MFEHDFNAKMI)?.ToString() + "LearnPrecision" + (object)val));
		}
		return text;
	}

	public string GetMyUsername(bool OLHGONNNDCG = false)
	{
		//IL_0034: Expected O, but got Unknown
		if (!OLHGONNNDCG)
		{
			Debug.Log((object)"Looking up current user name...");
		}
		string text = "";
		try
		{
			text = GalaxyInstance.Friends().GetPersonaName();
			if (!OLHGONNNDCG)
			{
				Debug.Log((object)("Current user name: " + text));
			}
		}
		catch (Error val)
		{
			Error val2 = val;
			if (!OLHGONNNDCG)
			{
				Debug.LogError((object)("Failed to get current user name for reason " + (object)val2));
			}
		}
		return text;
	}

	private void OFMFGGOGGNF()
	{
		if (JHFOFMBLFGK != null)
		{
			((IGalaxyListener)JHFOFMBLFGK).Dispose();
		}
		if (GGLPAMPLHBC != null)
		{
			((IGalaxyListener)GGLPAMPLHBC).Dispose();
		}
	}

	public GalaxyID GetFriendByIndex(uint MOFKEDGAOEE)
	{
		//IL_0054: Expected O, but got Unknown
		Debug.Log((object)("Trying to get friend " + MOFKEDGAOEE + " Galaxy ID"));
		GalaxyID val = null;
		try
		{
			val = GalaxyInstance.Friends().GetFriendByIndex(MOFKEDGAOEE);
			Debug.Log((object)("Friend " + MOFKEDGAOEE + " Galaxy ID: " + (object)val));
		}
		catch (Error val2)
		{
			Debug.LogError((object)("Failed to get friend by index " + MOFKEDGAOEE + " for reason " + (object)val2));
		}
		return val;
	}

	private void OnEnable()
	{
		IHJNCGFNDJK();
		SceneManager.sceneLoaded += OnSceneLoaded;
	}

	private void IMAMCIEGNFF()
	{
		if (JHFOFMBLFGK != null)
		{
			((IGalaxyListener)JHFOFMBLFGK).Dispose();
		}
		if (GGLPAMPLHBC != null)
		{
			((IGalaxyListener)GGLPAMPLHBC).Dispose();
		}
	}

	public GalaxyID FAJAGKLDMNB(uint MOFKEDGAOEE)
	{
		//IL_0054: Expected O, but got Unknown
		Debug.Log((object)("OnLobbyEnter \nLobby: {0}" + MOFKEDGAOEE + " "));
		GalaxyID val = null;
		try
		{
			val = GalaxyInstance.Friends().GetFriendByIndex(MOFKEDGAOEE);
			Debug.Log((object)("Not ready to create room" + MOFKEDGAOEE + " totalMsgs: " + (object)val));
		}
		catch (Error val2)
		{
			Debug.LogError((object)("ValueId" + MOFKEDGAOEE + " " + (object)val2));
		}
		return val;
	}

	public void IOLEJJEDAHI(string INAPMPEEDPO, string AODONKKHPBP)
	{
		//IL_0042: Expected O, but got Unknown
		Debug.Log((object)("ReceiveFishInfo" + INAPMPEEDPO + " - " + AODONKKHPBP));
		try
		{
			if (GalaxyInstance.Friends() != null)
			{
				GalaxyInstance.Friends().SetRichPresence(INAPMPEEDPO, AODONKKHPBP);
				Debug.Log((object)("tavern" + INAPMPEEDPO + "Example Method With Custom ID" + AODONKKHPBP));
			}
		}
		catch (Error val)
		{
			Error val2 = val;
			string[] array = new string[6];
			array[0] = "UIInteract";
			array[0] = INAPMPEEDPO;
			array[6] = "";
			array[4] = AODONKKHPBP;
			array[4] = "Bait";
			array[7] = ((object)val2)?.ToString();
			Debug.Log((object)string.Concat(array));
		}
	}

	private void BPIBMEEHADI()
	{
		if (JHFOFMBLFGK != null)
		{
			((IGalaxyListener)JHFOFMBLFGK).Dispose();
		}
		if (GGLPAMPLHBC != null)
		{
			((IGalaxyListener)GGLPAMPLHBC).Dispose();
		}
	}

	public string CDJEHNMENKD(bool OLHGONNNDCG = false)
	{
		//IL_0034: Expected O, but got Unknown
		if (!OLHGONNNDCG)
		{
			Debug.Log((object)"Items/item_name_");
		}
		string text = "RecieveActivateEvent";
		try
		{
			text = GalaxyInstance.Friends().GetPersonaName();
			if (!OLHGONNNDCG)
			{
				Debug.Log((object)("Waiting for other players" + text));
			}
		}
		catch (Error val)
		{
			Error val2 = val;
			if (!OLHGONNNDCG)
			{
				Debug.LogError((object)("vibrationP2" + (object)val2));
			}
		}
		return text;
	}

	private void OnDisable()
	{
		BPIBMEEHADI();
		SceneManager.sceneLoaded -= OnSceneLoaded;
	}

	public void SetRichPresence(string INAPMPEEDPO, string AODONKKHPBP)
	{
		//IL_0042: Expected O, but got Unknown
		Debug.Log((object)("Trying to set rich presence key " + INAPMPEEDPO + " value " + AODONKKHPBP));
		try
		{
			if (GalaxyInstance.Friends() != null)
			{
				GalaxyInstance.Friends().SetRichPresence(INAPMPEEDPO, AODONKKHPBP);
				Debug.Log((object)("Rich presence " + INAPMPEEDPO + " set to value " + AODONKKHPBP));
			}
		}
		catch (Error val)
		{
			Error val2 = val;
			Debug.Log((object)("Failed to set rich presence key " + INAPMPEEDPO + " value " + AODONKKHPBP + " for reason " + (object)val2));
		}
	}

	public string OPFIACCNDCC(GalaxyID MFEHDFNAKMI)
	{
		//IL_0058: Expected O, but got Unknown
		Debug.Log((object)("steam status" + ((object)MFEHDFNAKMI)?.ToString() + "Friend list couldn't be retrieved, for reason "));
		string text = "Close";
		try
		{
			text = GalaxyInstance.Friends().GetFriendPersonaName(MFEHDFNAKMI);
			Debug.Log((object)("SeatFound..." + ((object)MFEHDFNAKMI)?.ToString() + "Player/Bark/Tutorial/CrafterBlock" + text));
		}
		catch (Error val)
		{
			Debug.LogError((object)("Klayn not find path to banquet barrel at " + ((object)MFEHDFNAKMI)?.ToString() + " - " + (object)val));
		}
		return text;
	}

	private void MMAMJDLONFA()
	{
		OFMFGGOGGNF();
		SceneManager.sceneLoaded -= OnSceneLoaded;
	}
}
