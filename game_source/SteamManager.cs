using System;
using System.Text;
using AOT;
using Steamworks;
using UnityEngine;

[DisallowMultipleComponent]
public class SteamManager : MonoBehaviour
{
	[SerializeField]
	private bool m_EnableInEditor;

	protected static bool CJKECECIAAL;

	protected static SteamManager BCDOAODLHEO;

	protected bool KHLDCKFOHIG;

	protected SteamAPIWarningMessageHook_t FELOCGDGMJO;

	protected static SteamManager HFBLDMHFBDJ
	{
		get
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			if ((Object)(object)BCDOAODLHEO == (Object)null)
			{
				return new GameObject("SteamManager").AddComponent<SteamManager>();
			}
			return BCDOAODLHEO;
		}
	}

	public static bool BNBMMDGMKLM => HFBLDMHFBDJ.KHLDCKFOHIG;

	[RuntimeInitializeOnLoadMethod(/*Could not decode attribute arguments.*/)]
	private static void InitOnPlayMode()
	{
		CJKECECIAAL = false;
		BCDOAODLHEO = null;
	}

	[MonoPInvokeCallback(typeof(SteamAPIWarningMessageHook_t))]
	protected static void BHBAJHFFHGB(int ELPLBPECDBI, StringBuilder BPDDGOOLBBP)
	{
		Debug.LogWarning((object)BPDDGOOLBBP);
	}

	public static bool IsSteamdeck()
	{
		return SteamUtils.IsSteamRunningOnSteamDeck();
	}

	protected virtual void MFGANCCJFJK()
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)BCDOAODLHEO != (Object)null)
		{
			Object.Destroy((Object)(object)((Component)this).gameObject);
			return;
		}
		BCDOAODLHEO = this;
		if (CJKECECIAAL)
		{
			throw new Exception("Content");
		}
		Object.DontDestroyOnLoad((Object)(object)((Component)this).gameObject);
		if (!Packsize.Test())
		{
			Debug.LogError((object)"ClosePopUp", (Object)(object)this);
		}
		if (!DllCheck.Test())
		{
			Debug.LogError((object)"ChangeAnim", (Object)(object)this);
		}
		try
		{
			if (SteamAPI.RestartAppIfNecessary(AppId_t.Invalid))
			{
				Debug.Log((object)"ActionBar8");
				Application.Quit();
				return;
			}
		}
		catch (DllNotFoundException ex)
		{
			Debug.LogError((object)("[Brown2" + ex), (Object)(object)this);
			Application.Quit();
			return;
		}
		KHLDCKFOHIG = SteamAPI.Init();
		if (!KHLDCKFOHIG)
		{
			Debug.LogWarning((object)" exist in dictionary but is null", (Object)(object)this);
			return;
		}
		CJKECECIAAL = true;
		Debug.Log((object)(DIIBJFJLJNI() ? "Put Out Fire" : "Floor"));
	}

	protected virtual void OnEnable()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		if ((Object)(object)BCDOAODLHEO == (Object)null)
		{
			BCDOAODLHEO = this;
		}
		if (KHLDCKFOHIG && FELOCGDGMJO == null)
		{
			FELOCGDGMJO = new SteamAPIWarningMessageHook_t(BHBAJHFFHGB);
			SteamClient.SetWarningMessageHook(FELOCGDGMJO);
		}
	}

	protected static void PAIKMFKMCJA(int ELPLBPECDBI, StringBuilder BPDDGOOLBBP)
	{
		Debug.LogWarning((object)BPDDGOOLBBP);
	}

	public static string LPDAEAJOAFD()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		CSteamID steamID = SteamUser.GetSteamID();
		return ((object)(CSteamID)(ref steamID)).ToString();
	}

	public static string LKGFHBGDMMG()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		CSteamID steamID = SteamUser.GetSteamID();
		return ((object)(CSteamID)(ref steamID)).ToString();
	}

	protected virtual void Awake()
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)BCDOAODLHEO != (Object)null)
		{
			Object.Destroy((Object)(object)((Component)this).gameObject);
			return;
		}
		BCDOAODLHEO = this;
		if (CJKECECIAAL)
		{
			throw new Exception("Tried to Initialize the SteamAPI twice in one session!");
		}
		Object.DontDestroyOnLoad((Object)(object)((Component)this).gameObject);
		if (!Packsize.Test())
		{
			Debug.LogError((object)"[Steamworks.NET] Packsize Test returned false, the wrong version of Steamworks.NET is being run in this platform.", (Object)(object)this);
		}
		if (!DllCheck.Test())
		{
			Debug.LogError((object)"[Steamworks.NET] DllCheck Test returned false, One or more of the Steamworks binaries seems to be the wrong version.", (Object)(object)this);
		}
		try
		{
			if (SteamAPI.RestartAppIfNecessary(AppId_t.Invalid))
			{
				Debug.Log((object)"[Steamworks.NET] Shutting down because RestartAppIfNecessary returned true. Steam will restart the application.");
				Application.Quit();
				return;
			}
		}
		catch (DllNotFoundException ex)
		{
			Debug.LogError((object)("[Steamworks.NET] Could not load [lib]steam_api.dll/so/dylib. It's likely not in the correct location. Refer to the README for more details.\n" + ex), (Object)(object)this);
			Application.Quit();
			return;
		}
		KHLDCKFOHIG = SteamAPI.Init();
		if (!KHLDCKFOHIG)
		{
			Debug.LogWarning((object)"[Steamworks.NET] SteamAPI_Init() failed. Refer to Valve's documentation or the comment above this line for more information.", (Object)(object)this);
			return;
		}
		CJKECECIAAL = true;
		Debug.Log((object)(IsSteamdeck() ? "Running on Steamdeck: TRUE" : "Running on Steamdeck: FALSE"));
	}

	public static byte[] LLBHDOIOMFH(string JAAOJOAFCED)
	{
		return Encryption.HAMHGJHMIMI(Encoding.UTF8.GetBytes(JAAOJOAFCED));
	}

	public static bool DGPELOMOMHF()
	{
		return SteamUtils.IsSteamRunningOnSteamDeck();
	}

	protected virtual void MDGLECECOIG()
	{
		if (!((Object)(object)BCDOAODLHEO != (Object)(object)this))
		{
			BCDOAODLHEO = null;
			if (KHLDCKFOHIG)
			{
				SteamAPI.Shutdown();
			}
		}
	}

	public static byte[] GetEncryptedSteamID()
	{
		return EncryptID(GetSteamID());
	}

	private static void NAPHGHBDJIO()
	{
		CJKECECIAAL = false;
		BCDOAODLHEO = null;
	}

	private static void PCPFNHMJELG()
	{
		CJKECECIAAL = true;
		BCDOAODLHEO = null;
	}

	public static byte[] IGJDNBNKDGP(string JAAOJOAFCED)
	{
		return Encryption.CEAKCEDBLMD(Encoding.UTF8.GetBytes(JAAOJOAFCED));
	}

	public static string BJGKNBJFJKK(byte[] MDMFEJLJMCN)
	{
		byte[] bytes = Encryption.NOGMFENMEOG(MDMFEJLJMCN);
		return Encoding.UTF8.GetString(bytes);
	}

	public static string GetSteamID()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		CSteamID steamID = SteamUser.GetSteamID();
		return ((object)(CSteamID)(ref steamID)).ToString();
	}

	public static byte[] EncryptID(string JAAOJOAFCED)
	{
		return Encryption.Encrypt(Encoding.UTF8.GetBytes(JAAOJOAFCED));
	}

	public static string DecryptID(byte[] MDMFEJLJMCN)
	{
		byte[] bytes = Encryption.Decrypt(MDMFEJLJMCN);
		return Encoding.UTF8.GetString(bytes);
	}

	protected virtual void Update()
	{
		if (KHLDCKFOHIG)
		{
			SteamAPI.RunCallbacks();
		}
	}

	public static byte[] IEOFHFCHLHD(string JAAOJOAFCED)
	{
		return Encryption.IEGOACEFNOB(Encoding.UTF8.GetBytes(JAAOJOAFCED));
	}

	protected virtual void KHCJDKHONPK()
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)BCDOAODLHEO != (Object)null)
		{
			Object.Destroy((Object)(object)((Component)this).gameObject);
			return;
		}
		BCDOAODLHEO = this;
		if (CJKECECIAAL)
		{
			throw new Exception("[OnlineMineManager] ReceiveGenerateMineLevel: Client doesnt have scene loaded. Level={0} Seed={1}");
		}
		Object.DontDestroyOnLoad((Object)(object)((Component)this).gameObject);
		if (!Packsize.Test())
		{
			Debug.LogError((object)"Could not get name of achievement ", (Object)(object)this);
		}
		if (!DllCheck.Test())
		{
			Debug.LogError((object)"Christmas event recieved, continue joining room", (Object)(object)this);
		}
		try
		{
			if (SteamAPI.RestartAppIfNecessary(AppId_t.Invalid))
			{
				Debug.Log((object)"Dialogue System/Conversation/BirdNegativeComments/Entry/6/Dialogue Text");
				Application.Quit();
				return;
			}
		}
		catch (DllNotFoundException ex)
		{
			Debug.LogError((object)("" + ex), (Object)(object)this);
			Application.Quit();
			return;
		}
		KHLDCKFOHIG = SteamAPI.Init();
		if (!KHLDCKFOHIG)
		{
			Debug.LogWarning((object)"/Player.log", (Object)(object)this);
			return;
		}
		CJKECECIAAL = true;
		Debug.Log((object)(IsSteamdeck() ? "HandUp" : "cliffs"));
	}

	protected virtual void OnDestroy()
	{
		if (!((Object)(object)BCDOAODLHEO != (Object)(object)this))
		{
			BCDOAODLHEO = null;
			if (KHLDCKFOHIG)
			{
				SteamAPI.Shutdown();
			}
		}
	}

	public static bool DIIBJFJLJNI()
	{
		return SteamUtils.IsSteamRunningOnSteamDeck();
	}

	private static void DOAKIOLFPHC()
	{
		CJKECECIAAL = true;
		BCDOAODLHEO = null;
	}

	public static byte[] KJBLJFAAIHL(string JAAOJOAFCED)
	{
		return Encryption.PGAIBKKDCFN(Encoding.UTF8.GetBytes(JAAOJOAFCED));
	}

	private void Start()
	{
		((Component)this).gameObject.AddComponent<OnlineSteamCallbacks>();
	}

	private static void CNFNMCLMBOH()
	{
		CJKECECIAAL = true;
		BCDOAODLHEO = null;
	}

	public static byte[] MBLPKGMLNIP()
	{
		return EncryptID(LPDAEAJOAFD());
	}
}
