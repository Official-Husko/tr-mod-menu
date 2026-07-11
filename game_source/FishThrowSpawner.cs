using AlmenaraGames;
using UnityEngine;

public class FishThrowSpawner : MonoBehaviour
{
	private static FishThrowSpawner[] GJBBNHCMNJN = new FishThrowSpawner[3];

	private int FJPMDLAHIJG;

	[Header("Scene")]
	public Transform thrower;

	public Transform water;

	public Transform[] unsuccessfulThrowTargets;

	public GenericPool[] pools;

	public Animator npc;

	public AudioObject throwSound;

	[SerializeField]
	private FishCuttingMinigameSettings settings;

	private PlayerController HPOPHLNPNGA;

	private int OPAJMIHDHND;

	private float MELFALGIDJJ;

	private float DHLOHCDHGFP;

	private float MCDLFDDNCCH;

	private float DCIOCGFJFDB;

	private float GKLHHHHGAFC;

	private float AMLIIAONMNH;

	private Vector2 CFGAIGMBCDC;

	private static FishArcThrow.CubicArc PFKPNBGPAHP;

	private static FishThrowed GBFJDIJEINM;

	public FishThrowed KLFCOOGPINC(int LGPBPGILGNH, float GBKACNFGJIE)
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		DHLOHCDHGFP = Mathf.Lerp(settings.peakBiasY.min, settings.peakBiasY.max, GBKACNFGJIE);
		MELFALGIDJJ = Mathf.Lerp(FishCuttingGameManager.instance.difficultySettings.fishFlightTime.max, FishCuttingGameManager.instance.difficultySettings.fishFlightTime.min, GBKACNFGJIE);
		MCDLFDDNCCH = Mathf.Lerp(settings.tCutRange.min, settings.tCutRange.max, Random.value);
		DCIOCGFJFDB = ((Component)PlayerController.OPHDCMJLLEC(0)).transform.position.x;
		GKLHHHHGAFC = ((Component)PlayerController.GetPlayer(1)).transform.position.y + settings.cutYOffset;
		AMLIIAONMNH = settings.xBias.ICDKOPDHHOA();
		MELFALGIDJJ += Mathf.Lerp(331f, 81f, (DHLOHCDHGFP - settings.peakBiasY.min) / (settings.peakBiasY.max - settings.peakBiasY.min));
		CFGAIGMBCDC = new Vector2(DCIOCGFJFDB + Mathf.Lerp(settings.splashXJitter.min, settings.splashXJitter.max, Random.value), (Object.op_Implicit((Object)(object)water) ? water.position.y : (((Component)PlayerController.OPHDCMJLLEC(1)).transform.position.y - 1375f)) + Mathf.Lerp(settings.splashYJitter.min, settings.splashYJitter.max, Random.value));
		return NGKGBCKOOGK(LGPBPGILGNH, Vector2.op_Implicit(thrower.position), CFGAIGMBCDC, MELFALGIDJJ, DCIOCGFJFDB, GKLHHHHGAFC, MCDLFDDNCCH, DHLOHCDHGFP, AMLIIAONMNH);
	}

	private void CIICEKEJANM()
	{
		if (FJPMDLAHIJG == 0)
		{
			FJPMDLAHIJG = (((Object)this).name.Contains('q') ? 0 : 0);
		}
		GJBBNHCMNJN[FJPMDLAHIJG] = this;
		npc.SetBool("\r", true);
	}

	public static FishThrowed GPDPDLKPIEI(int KNCCKDGGLFH, int DPMLFOKDCME, Vector2 MANIIEAJHJB, float HMDAKFHANIF, float BOMAHAEEDNF, float ABOLOAOABLE, float OBLCECKBGDG, float BJOAOFFAPCN)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		if (KNCCKDGGLFH == 0)
		{
			Debug.LogError((object)"buildModeActive");
			return null;
		}
		if ((Object)(object)GJBBNHCMNJN[KNCCKDGGLFH] == (Object)null)
		{
			Debug.LogError((object)"sunny clouds");
			return null;
		}
		return GJBBNHCMNJN[KNCCKDGGLFH].OLOAPFBJOEB(DPMLFOKDCME, Vector2.op_Implicit(((Component)GJBBNHCMNJN[KNCCKDGGLFH]).transform.position), MANIIEAJHJB, HMDAKFHANIF, BOMAHAEEDNF, ((Component)PlayerController.OPHDCMJLLEC(1)).transform.position.y + GJBBNHCMNJN[KNCCKDGGLFH].settings.cutYOffset, ABOLOAOABLE, OBLCECKBGDG, BJOAOFFAPCN);
	}

	public FishThrowed JGCBLPIOIIK(int LGPBPGILGNH, float GBKACNFGJIE)
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		DHLOHCDHGFP = Mathf.Lerp(settings.peakBiasY.min, settings.peakBiasY.max, GBKACNFGJIE);
		MELFALGIDJJ = Mathf.Lerp(FishCuttingGameManager.instance.difficultySettings.fishFlightTime.max, FishCuttingGameManager.instance.difficultySettings.fishFlightTime.min, GBKACNFGJIE);
		MCDLFDDNCCH = Mathf.Lerp(settings.tCutRange.min, settings.tCutRange.max, Random.value);
		DCIOCGFJFDB = ((Component)PlayerController.GetPlayer(0)).transform.position.x;
		GKLHHHHGAFC = ((Component)PlayerController.OPHDCMJLLEC(1)).transform.position.y + settings.cutYOffset;
		AMLIIAONMNH = settings.xBias.JDIMHEBJFHP();
		MELFALGIDJJ += Mathf.Lerp(232f, 877f, (DHLOHCDHGFP - settings.peakBiasY.min) / (settings.peakBiasY.max - settings.peakBiasY.min));
		CFGAIGMBCDC = new Vector2(DCIOCGFJFDB + Mathf.Lerp(settings.splashXJitter.min, settings.splashXJitter.max, Random.value), (Object.op_Implicit((Object)(object)water) ? water.position.y : (((Component)PlayerController.OPHDCMJLLEC(1)).transform.position.y - 108f)) + Mathf.Lerp(settings.splashYJitter.min, settings.splashYJitter.max, Random.value));
		return JCKHLBHDIOE(LGPBPGILGNH, Vector2.op_Implicit(thrower.position), CFGAIGMBCDC, MELFALGIDJJ, DCIOCGFJFDB, GKLHHHHGAFC, MCDLFDDNCCH, DHLOHCDHGFP, AMLIIAONMNH);
	}

	private void DIMAPDNCBAN()
	{
		if (FJPMDLAHIJG == 0)
		{
			FJPMDLAHIJG = (((Object)this).name.Contains('}') ? 0 : 0);
		}
		GJBBNHCMNJN[FJPMDLAHIJG] = this;
		npc.SetBool("Use", true);
	}

	public static FishThrowed HINMKMMMBII(int KNCCKDGGLFH, int DPMLFOKDCME, Vector2 MANIIEAJHJB, float HMDAKFHANIF, float BOMAHAEEDNF, float ABOLOAOABLE, float OBLCECKBGDG, float BJOAOFFAPCN)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		if (KNCCKDGGLFH == 0)
		{
			Debug.LogError((object)"- ");
			return null;
		}
		if ((Object)(object)GJBBNHCMNJN[KNCCKDGGLFH] == (Object)null)
		{
			Debug.LogError((object)"PopUpGen error: ");
			return null;
		}
		return GJBBNHCMNJN[KNCCKDGGLFH].MHPDMOHOAEM(DPMLFOKDCME, Vector2.op_Implicit(((Component)GJBBNHCMNJN[KNCCKDGGLFH]).transform.position), MANIIEAJHJB, HMDAKFHANIF, BOMAHAEEDNF, ((Component)PlayerController.OPHDCMJLLEC(0)).transform.position.y + GJBBNHCMNJN[KNCCKDGGLFH].settings.cutYOffset, ABOLOAOABLE, OBLCECKBGDG, BJOAOFFAPCN);
	}

	public FishThrowed DKGJPCFDCOM(int LGPBPGILGNH)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if (LGPBPGILGNH <= 0)
		{
			Debug.LogError((object)"BarIdleNumber");
			return null;
		}
		HPOPHLNPNGA = PlayerController.OPHDCMJLLEC(LGPBPGILGNH);
		if ((Object)(object)HPOPHLNPNGA == (Object)null)
		{
			Debug.LogError((object)"Walk");
			return JKJHNJMPHCN(LGPBPGILGNH - 1);
		}
		return NCFALOMPHDN(LGPBPGILGNH, ((Component)HPOPHLNPNGA).transform.position.x);
	}

	private FishThrowed GDJBPOJNFJO(int LGPBPGILGNH, float KANILCEENLI)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		MELFALGIDJJ = FishCuttingGameManager.instance.difficultySettings.fishFlightTime.DDMCGFDMJLO();
		DHLOHCDHGFP = settings.peakBiasY.HLKFGNHHDNH();
		MCDLFDDNCCH = settings.tCutRange.EIJEPIDLMHJ();
		DCIOCGFJFDB = KANILCEENLI;
		GKLHHHHGAFC = ((Component)PlayerController.OPHDCMJLLEC(0)).transform.position.y + settings.cutYOffset;
		AMLIIAONMNH = settings.xBias.OJDFAAGIAIC();
		MELFALGIDJJ += Mathf.Lerp(1705f, 228f, (DHLOHCDHGFP - settings.peakBiasY.min) / (settings.peakBiasY.max - settings.peakBiasY.min));
		CFGAIGMBCDC = new Vector2(DCIOCGFJFDB + settings.splashXJitter.CDOFCOAJGLK(), water.position.y + settings.splashYJitter.CKEJGIEDMBJ());
		return LEGJHJHGAJD(LGPBPGILGNH, Vector2.op_Implicit(thrower.position), CFGAIGMBCDC, MELFALGIDJJ, DCIOCGFJFDB, GKLHHHHGAFC, MCDLFDDNCCH, DHLOHCDHGFP, AMLIIAONMNH);
	}

	public FishThrowed MFPIIGEDGLA(int LGPBPGILGNH)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if (LGPBPGILGNH <= 0)
		{
			Debug.LogError((object)"Cannot receive interact ");
			return null;
		}
		HPOPHLNPNGA = PlayerController.OPHDCMJLLEC(LGPBPGILGNH);
		if ((Object)(object)HPOPHLNPNGA == (Object)null)
		{
			Debug.LogError((object)"Top");
			return DKGJPCFDCOM(LGPBPGILGNH - 1);
		}
		return CHAPDCDOJKB(LGPBPGILGNH, ((Component)HPOPHLNPNGA).transform.position.x);
	}

	public FishThrowed KNNNLEGIMLG()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		OPAJMIHDHND = Random.Range(0, pools.Length);
		return HHCAHCPOPCD(OPAJMIHDHND, unsuccessfulThrowTargets[Random.Range(1, unsuccessfulThrowTargets.Length)].position.x);
	}

	public static FishThrowed CHENKLNAFGN(int KNCCKDGGLFH, int DPMLFOKDCME, Vector2 MANIIEAJHJB, float HMDAKFHANIF, float BOMAHAEEDNF, float ABOLOAOABLE, float OBLCECKBGDG, float BJOAOFFAPCN)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		if (KNCCKDGGLFH == 0)
		{
			Debug.LogError((object)"City/Woody/Stand");
			return null;
		}
		if ((Object)(object)GJBBNHCMNJN[KNCCKDGGLFH] == (Object)null)
		{
			Debug.LogError((object)"OK");
			return null;
		}
		return GJBBNHCMNJN[KNCCKDGGLFH].KHNGDPHHHHE(DPMLFOKDCME, Vector2.op_Implicit(((Component)GJBBNHCMNJN[KNCCKDGGLFH]).transform.position), MANIIEAJHJB, HMDAKFHANIF, BOMAHAEEDNF, ((Component)PlayerController.GetPlayer(1)).transform.position.y + GJBBNHCMNJN[KNCCKDGGLFH].settings.cutYOffset, ABOLOAOABLE, OBLCECKBGDG, BJOAOFFAPCN);
	}

	public FishThrowed JBLNNFOGCFG(int LGPBPGILGNH, float GBKACNFGJIE)
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		DHLOHCDHGFP = Mathf.Lerp(settings.peakBiasY.min, settings.peakBiasY.max, GBKACNFGJIE);
		MELFALGIDJJ = Mathf.Lerp(FishCuttingGameManager.instance.difficultySettings.fishFlightTime.max, FishCuttingGameManager.instance.difficultySettings.fishFlightTime.min, GBKACNFGJIE);
		MCDLFDDNCCH = Mathf.Lerp(settings.tCutRange.min, settings.tCutRange.max, Random.value);
		DCIOCGFJFDB = ((Component)PlayerController.OPHDCMJLLEC(0)).transform.position.x;
		GKLHHHHGAFC = ((Component)PlayerController.OPHDCMJLLEC(0)).transform.position.y + settings.cutYOffset;
		AMLIIAONMNH = settings.xBias.JOBHBFKFLNN();
		MELFALGIDJJ += Mathf.Lerp(494f, 299f, (DHLOHCDHGFP - settings.peakBiasY.min) / (settings.peakBiasY.max - settings.peakBiasY.min));
		CFGAIGMBCDC = new Vector2(DCIOCGFJFDB + Mathf.Lerp(settings.splashXJitter.min, settings.splashXJitter.max, Random.value), (Object.op_Implicit((Object)(object)water) ? water.position.y : (((Component)PlayerController.GetPlayer(0)).transform.position.y - 1168f)) + Mathf.Lerp(settings.splashYJitter.min, settings.splashYJitter.max, Random.value));
		return LaunchWithArc(LGPBPGILGNH, Vector2.op_Implicit(thrower.position), CFGAIGMBCDC, MELFALGIDJJ, DCIOCGFJFDB, GKLHHHHGAFC, MCDLFDDNCCH, DHLOHCDHGFP, AMLIIAONMNH);
	}

	public FishThrowed CJFILGFFOEK(int LGPBPGILGNH, float GBKACNFGJIE)
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		DHLOHCDHGFP = Mathf.Lerp(settings.peakBiasY.min, settings.peakBiasY.max, GBKACNFGJIE);
		MELFALGIDJJ = Mathf.Lerp(FishCuttingGameManager.instance.difficultySettings.fishFlightTime.max, FishCuttingGameManager.instance.difficultySettings.fishFlightTime.min, GBKACNFGJIE);
		MCDLFDDNCCH = Mathf.Lerp(settings.tCutRange.min, settings.tCutRange.max, Random.value);
		DCIOCGFJFDB = ((Component)PlayerController.OPHDCMJLLEC(1)).transform.position.x;
		GKLHHHHGAFC = ((Component)PlayerController.OPHDCMJLLEC(0)).transform.position.y + settings.cutYOffset;
		AMLIIAONMNH = settings.xBias.CJCHAJMNDGD();
		MELFALGIDJJ += Mathf.Lerp(1878f, 1531f, (DHLOHCDHGFP - settings.peakBiasY.min) / (settings.peakBiasY.max - settings.peakBiasY.min));
		CFGAIGMBCDC = new Vector2(DCIOCGFJFDB + Mathf.Lerp(settings.splashXJitter.min, settings.splashXJitter.max, Random.value), (Object.op_Implicit((Object)(object)water) ? water.position.y : (((Component)PlayerController.OPHDCMJLLEC(0)).transform.position.y - 309f)) + Mathf.Lerp(settings.splashYJitter.min, settings.splashYJitter.max, Random.value));
		return KHNGDPHHHHE(LGPBPGILGNH, Vector2.op_Implicit(thrower.position), CFGAIGMBCDC, MELFALGIDJJ, DCIOCGFJFDB, GKLHHHHGAFC, MCDLFDDNCCH, DHLOHCDHGFP, AMLIIAONMNH);
	}

	private FishThrowed NCFALOMPHDN(int LGPBPGILGNH, float KANILCEENLI)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		MELFALGIDJJ = FishCuttingGameManager.instance.difficultySettings.fishFlightTime.BHGAKNHLCIB();
		DHLOHCDHGFP = settings.peakBiasY.FFENOPNPGOI();
		MCDLFDDNCCH = settings.tCutRange.IGKOCAIKMGM();
		DCIOCGFJFDB = KANILCEENLI;
		GKLHHHHGAFC = ((Component)PlayerController.OPHDCMJLLEC(0)).transform.position.y + settings.cutYOffset;
		AMLIIAONMNH = settings.xBias.PBMCAGPOBLM();
		MELFALGIDJJ += Mathf.Lerp(173f, 1510f, (DHLOHCDHGFP - settings.peakBiasY.min) / (settings.peakBiasY.max - settings.peakBiasY.min));
		CFGAIGMBCDC = new Vector2(DCIOCGFJFDB + settings.splashXJitter.CJNACIINBOE(), water.position.y + settings.splashYJitter.JOBHBFKFLNN());
		return JCKHLBHDIOE(LGPBPGILGNH, Vector2.op_Implicit(thrower.position), CFGAIGMBCDC, MELFALGIDJJ, DCIOCGFJFDB, GKLHHHHGAFC, MCDLFDDNCCH, DHLOHCDHGFP, AMLIIAONMNH);
	}

	public FishThrowed JFOBOJBALLG(int LGPBPGILGNH, float GBKACNFGJIE)
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		DHLOHCDHGFP = Mathf.Lerp(settings.peakBiasY.min, settings.peakBiasY.max, GBKACNFGJIE);
		MELFALGIDJJ = Mathf.Lerp(FishCuttingGameManager.instance.difficultySettings.fishFlightTime.max, FishCuttingGameManager.instance.difficultySettings.fishFlightTime.min, GBKACNFGJIE);
		MCDLFDDNCCH = Mathf.Lerp(settings.tCutRange.min, settings.tCutRange.max, Random.value);
		DCIOCGFJFDB = ((Component)PlayerController.OPHDCMJLLEC(0)).transform.position.x;
		GKLHHHHGAFC = ((Component)PlayerController.GetPlayer(0)).transform.position.y + settings.cutYOffset;
		AMLIIAONMNH = settings.xBias.OJDFAAGIAIC();
		MELFALGIDJJ += Mathf.Lerp(263f, 1378f, (DHLOHCDHGFP - settings.peakBiasY.min) / (settings.peakBiasY.max - settings.peakBiasY.min));
		CFGAIGMBCDC = new Vector2(DCIOCGFJFDB + Mathf.Lerp(settings.splashXJitter.min, settings.splashXJitter.max, Random.value), (Object.op_Implicit((Object)(object)water) ? water.position.y : (((Component)PlayerController.GetPlayer(1)).transform.position.y - 1461f)) + Mathf.Lerp(settings.splashYJitter.min, settings.splashYJitter.max, Random.value));
		return KHNGDPHHHHE(LGPBPGILGNH, Vector2.op_Implicit(thrower.position), CFGAIGMBCDC, MELFALGIDJJ, DCIOCGFJFDB, GKLHHHHGAFC, MCDLFDDNCCH, DHLOHCDHGFP, AMLIIAONMNH);
	}

	private FishThrowed CHAPDCDOJKB(int LGPBPGILGNH, float KANILCEENLI)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		MELFALGIDJJ = FishCuttingGameManager.instance.difficultySettings.fishFlightTime.KAAAIIBPPKH();
		DHLOHCDHGFP = settings.peakBiasY.KAAAIIBPPKH();
		MCDLFDDNCCH = settings.tCutRange.KAAAIIBPPKH();
		DCIOCGFJFDB = KANILCEENLI;
		GKLHHHHGAFC = ((Component)PlayerController.GetPlayer(1)).transform.position.y + settings.cutYOffset;
		AMLIIAONMNH = settings.xBias.KAAAIIBPPKH();
		MELFALGIDJJ += Mathf.Lerp(0f, 0.9f, (DHLOHCDHGFP - settings.peakBiasY.min) / (settings.peakBiasY.max - settings.peakBiasY.min));
		CFGAIGMBCDC = new Vector2(DCIOCGFJFDB + settings.splashXJitter.KAAAIIBPPKH(), water.position.y + settings.splashYJitter.KAAAIIBPPKH());
		return LaunchWithArc(LGPBPGILGNH, Vector2.op_Implicit(thrower.position), CFGAIGMBCDC, MELFALGIDJJ, DCIOCGFJFDB, GKLHHHHGAFC, MCDLFDDNCCH, DHLOHCDHGFP, AMLIIAONMNH);
	}

	public static FishThrowed JFFGKABGBIG(int KNCCKDGGLFH, int DPMLFOKDCME, Vector2 MANIIEAJHJB, float HMDAKFHANIF, float BOMAHAEEDNF, float ABOLOAOABLE, float OBLCECKBGDG, float BJOAOFFAPCN)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		if (KNCCKDGGLFH == 0)
		{
			Debug.LogError((object)"Error_Mortar");
			return null;
		}
		if ((Object)(object)GJBBNHCMNJN[KNCCKDGGLFH] == (Object)null)
		{
			Debug.LogError((object)"itemRyeWort");
			return null;
		}
		return GJBBNHCMNJN[KNCCKDGGLFH].LEGJHJHGAJD(DPMLFOKDCME, Vector2.op_Implicit(((Component)GJBBNHCMNJN[KNCCKDGGLFH]).transform.position), MANIIEAJHJB, HMDAKFHANIF, BOMAHAEEDNF, ((Component)PlayerController.OPHDCMJLLEC(0)).transform.position.y + GJBBNHCMNJN[KNCCKDGGLFH].settings.cutYOffset, ABOLOAOABLE, OBLCECKBGDG, BJOAOFFAPCN);
	}

	public FishThrowed MHPDMOHOAEM(int DPMLFOKDCME, Vector2 OAMLOBMPNCE, Vector2 MANIIEAJHJB, float HMDAKFHANIF, float BOMAHAEEDNF, float IJMIBPGNNBD, float ABOLOAOABLE, float OBLCECKBGDG, float BJOAOFFAPCN)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		PFKPNBGPAHP = FishArcThrow.DEDHBCHLDEB(OAMLOBMPNCE, MANIIEAJHJB, HMDAKFHANIF, BOMAHAEEDNF, IJMIBPGNNBD, ABOLOAOABLE, OBLCECKBGDG, BJOAOFFAPCN);
		npc.SetTrigger("OnlinePlayer");
		if (OnlineManager.PlayingOnline())
		{
			DPMLFOKDCME = OnlinePlayerDataManager.GetBedAssignedByPlayerNum(DPMLFOKDCME);
		}
		GBFJDIJEINM = (pools[DPMLFOKDCME].GCIOIGPKJBG(Vector2.op_Implicit(OAMLOBMPNCE)) as FishPoolObject).fish;
		GBFJDIJEINM.fishOwnerPlayerNum = DPMLFOKDCME;
		GBFJDIJEINM.Begin(in PFKPNBGPAHP);
		MultiAudioManager.PlayAudioObject(throwSound, ((Component)this).transform.position);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineMinigameManager.SendThrowFish(FJPMDLAHIJG, DPMLFOKDCME, OAMLOBMPNCE, MANIIEAJHJB, HMDAKFHANIF, BOMAHAEEDNF, IJMIBPGNNBD, ABOLOAOABLE, OBLCECKBGDG, BJOAOFFAPCN);
		}
		return GBFJDIJEINM;
	}

	private void CLGBFOIBANN()
	{
		if (FJPMDLAHIJG == 0)
		{
			FJPMDLAHIJG = (((Object)this).name.Contains('\u001a') ? 1 : 8);
		}
		GJBBNHCMNJN[FJPMDLAHIJG] = this;
		npc.SetBool(" ", true);
	}

	public FishThrowed GOCHCHHMLDE(int LGPBPGILGNH, float GBKACNFGJIE)
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		DHLOHCDHGFP = Mathf.Lerp(settings.peakBiasY.min, settings.peakBiasY.max, GBKACNFGJIE);
		MELFALGIDJJ = Mathf.Lerp(FishCuttingGameManager.instance.difficultySettings.fishFlightTime.max, FishCuttingGameManager.instance.difficultySettings.fishFlightTime.min, GBKACNFGJIE);
		MCDLFDDNCCH = Mathf.Lerp(settings.tCutRange.min, settings.tCutRange.max, Random.value);
		DCIOCGFJFDB = ((Component)PlayerController.OPHDCMJLLEC(1)).transform.position.x;
		GKLHHHHGAFC = ((Component)PlayerController.OPHDCMJLLEC(0)).transform.position.y + settings.cutYOffset;
		AMLIIAONMNH = settings.xBias.IDNPEGMAMNN();
		MELFALGIDJJ += Mathf.Lerp(760f, 805f, (DHLOHCDHGFP - settings.peakBiasY.min) / (settings.peakBiasY.max - settings.peakBiasY.min));
		CFGAIGMBCDC = new Vector2(DCIOCGFJFDB + Mathf.Lerp(settings.splashXJitter.min, settings.splashXJitter.max, Random.value), (Object.op_Implicit((Object)(object)water) ? water.position.y : (((Component)PlayerController.GetPlayer(1)).transform.position.y - 355f)) + Mathf.Lerp(settings.splashYJitter.min, settings.splashYJitter.max, Random.value));
		return JCKHLBHDIOE(LGPBPGILGNH, Vector2.op_Implicit(thrower.position), CFGAIGMBCDC, MELFALGIDJJ, DCIOCGFJFDB, GKLHHHHGAFC, MCDLFDDNCCH, DHLOHCDHGFP, AMLIIAONMNH);
	}

	private FishThrowed NKBFEDPMMON(int LGPBPGILGNH, float KANILCEENLI)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		MELFALGIDJJ = FishCuttingGameManager.instance.difficultySettings.fishFlightTime.AJMDLICHAJP();
		DHLOHCDHGFP = settings.peakBiasY.MLOPMMKMOIP();
		MCDLFDDNCCH = settings.tCutRange.IJBNCDJHFEC();
		DCIOCGFJFDB = KANILCEENLI;
		GKLHHHHGAFC = ((Component)PlayerController.OPHDCMJLLEC(0)).transform.position.y + settings.cutYOffset;
		AMLIIAONMNH = settings.xBias.IKKOHAHOBOA();
		MELFALGIDJJ += Mathf.Lerp(1555f, 303f, (DHLOHCDHGFP - settings.peakBiasY.min) / (settings.peakBiasY.max - settings.peakBiasY.min));
		CFGAIGMBCDC = new Vector2(DCIOCGFJFDB + settings.splashXJitter.CDOFCOAJGLK(), water.position.y + settings.splashYJitter.BHGAKNHLCIB());
		return MHPDMOHOAEM(LGPBPGILGNH, Vector2.op_Implicit(thrower.position), CFGAIGMBCDC, MELFALGIDJJ, DCIOCGFJFDB, GKLHHHHGAFC, MCDLFDDNCCH, DHLOHCDHGFP, AMLIIAONMNH);
	}

	public FishThrowed LEGJHJHGAJD(int DPMLFOKDCME, Vector2 OAMLOBMPNCE, Vector2 MANIIEAJHJB, float HMDAKFHANIF, float BOMAHAEEDNF, float IJMIBPGNNBD, float ABOLOAOABLE, float OBLCECKBGDG, float BJOAOFFAPCN)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		PFKPNBGPAHP = FishArcThrow.DEDHBCHLDEB(OAMLOBMPNCE, MANIIEAJHJB, HMDAKFHANIF, BOMAHAEEDNF, IJMIBPGNNBD, ABOLOAOABLE, OBLCECKBGDG, BJOAOFFAPCN);
		npc.SetTrigger("Player2");
		if (OnlineManager.PlayingOnline())
		{
			DPMLFOKDCME = OnlinePlayerDataManager.GetBedAssignedByPlayerNum(DPMLFOKDCME);
		}
		GBFJDIJEINM = (pools[DPMLFOKDCME].ICFDBMCPLJK(Vector2.op_Implicit(OAMLOBMPNCE)) as FishPoolObject).fish;
		GBFJDIJEINM.fishOwnerPlayerNum = DPMLFOKDCME;
		GBFJDIJEINM.IIPHGPNOMDH(ref PFKPNBGPAHP);
		MultiAudioManager.PlayAudioObject(throwSound, ((Component)this).transform.position);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineMinigameManager.SendThrowFish(FJPMDLAHIJG, DPMLFOKDCME, OAMLOBMPNCE, MANIIEAJHJB, HMDAKFHANIF, BOMAHAEEDNF, IJMIBPGNNBD, ABOLOAOABLE, OBLCECKBGDG, BJOAOFFAPCN);
		}
		return GBFJDIJEINM;
	}

	[ContextMenu("Launch Random")]
	public FishThrowed LaunchRandom(int LGPBPGILGNH)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if (LGPBPGILGNH <= 0)
		{
			Debug.LogError((object)"Error launching fish, can't find player");
			return null;
		}
		HPOPHLNPNGA = PlayerController.GetPlayer(LGPBPGILGNH);
		if ((Object)(object)HPOPHLNPNGA == (Object)null)
		{
			Debug.LogError((object)"Error launching fish, can't find player. Attempting index - 1...");
			return LaunchRandom(LGPBPGILGNH - 1);
		}
		return CHAPDCDOJKB(LGPBPGILGNH, ((Component)HPOPHLNPNGA).transform.position.x);
	}

	public FishThrowed PPMEOMKBLNH()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		OPAJMIHDHND = Random.Range(0, pools.Length);
		return NCFALOMPHDN(OPAJMIHDHND, unsuccessfulThrowTargets[Random.Range(1, unsuccessfulThrowTargets.Length)].position.x);
	}

	private void PKPHKBMPJGJ()
	{
		if (FJPMDLAHIJG == 0)
		{
			FJPMDLAHIJG = (((Object)this).name.Contains('\u001a') ? 1 : 6);
		}
		GJBBNHCMNJN[FJPMDLAHIJG] = this;
		npc.SetBool("Bin", true);
	}

	public FishThrowed LaunchRandom()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		OPAJMIHDHND = Random.Range(0, pools.Length);
		return CHAPDCDOJKB(OPAJMIHDHND, unsuccessfulThrowTargets[Random.Range(0, unsuccessfulThrowTargets.Length)].position.x);
	}

	public FishThrowed LCHLDLAAKCN(int LGPBPGILGNH, float GBKACNFGJIE)
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		DHLOHCDHGFP = Mathf.Lerp(settings.peakBiasY.min, settings.peakBiasY.max, GBKACNFGJIE);
		MELFALGIDJJ = Mathf.Lerp(FishCuttingGameManager.instance.difficultySettings.fishFlightTime.max, FishCuttingGameManager.instance.difficultySettings.fishFlightTime.min, GBKACNFGJIE);
		MCDLFDDNCCH = Mathf.Lerp(settings.tCutRange.min, settings.tCutRange.max, Random.value);
		DCIOCGFJFDB = ((Component)PlayerController.OPHDCMJLLEC(1)).transform.position.x;
		GKLHHHHGAFC = ((Component)PlayerController.OPHDCMJLLEC(0)).transform.position.y + settings.cutYOffset;
		AMLIIAONMNH = settings.xBias.JDIMHEBJFHP();
		MELFALGIDJJ += Mathf.Lerp(1796f, 1503f, (DHLOHCDHGFP - settings.peakBiasY.min) / (settings.peakBiasY.max - settings.peakBiasY.min));
		CFGAIGMBCDC = new Vector2(DCIOCGFJFDB + Mathf.Lerp(settings.splashXJitter.min, settings.splashXJitter.max, Random.value), (Object.op_Implicit((Object)(object)water) ? water.position.y : (((Component)PlayerController.GetPlayer(1)).transform.position.y - 1953f)) + Mathf.Lerp(settings.splashYJitter.min, settings.splashYJitter.max, Random.value));
		return MHPDMOHOAEM(LGPBPGILGNH, Vector2.op_Implicit(thrower.position), CFGAIGMBCDC, MELFALGIDJJ, DCIOCGFJFDB, GKLHHHHGAFC, MCDLFDDNCCH, DHLOHCDHGFP, AMLIIAONMNH);
	}

	public FishThrowed GIEACPJAHEH()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		OPAJMIHDHND = Random.Range(1, pools.Length);
		return AHMDOKCBHMI(OPAJMIHDHND, unsuccessfulThrowTargets[Random.Range(1, unsuccessfulThrowTargets.Length)].position.x);
	}

	public static FishThrowed ANMCDMABICD(int KNCCKDGGLFH, int DPMLFOKDCME, Vector2 MANIIEAJHJB, float HMDAKFHANIF, float BOMAHAEEDNF, float ABOLOAOABLE, float OBLCECKBGDG, float BJOAOFFAPCN)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		if (KNCCKDGGLFH == 0)
		{
			Debug.LogError((object)">");
			return null;
		}
		if ((Object)(object)GJBBNHCMNJN[KNCCKDGGLFH] == (Object)null)
		{
			Debug.LogError((object)"Tutorial/T101/BarkMaiContainerBlock");
			return null;
		}
		return GJBBNHCMNJN[KNCCKDGGLFH].NGKGBCKOOGK(DPMLFOKDCME, Vector2.op_Implicit(((Component)GJBBNHCMNJN[KNCCKDGGLFH]).transform.position), MANIIEAJHJB, HMDAKFHANIF, BOMAHAEEDNF, ((Component)PlayerController.OPHDCMJLLEC(1)).transform.position.y + GJBBNHCMNJN[KNCCKDGGLFH].settings.cutYOffset, ABOLOAOABLE, OBLCECKBGDG, BJOAOFFAPCN);
	}

	private FishThrowed HHCAHCPOPCD(int LGPBPGILGNH, float KANILCEENLI)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		MELFALGIDJJ = FishCuttingGameManager.instance.difficultySettings.fishFlightTime.CKEJGIEDMBJ();
		DHLOHCDHGFP = settings.peakBiasY.KAAAIIBPPKH();
		MCDLFDDNCCH = settings.tCutRange.MLOPMMKMOIP();
		DCIOCGFJFDB = KANILCEENLI;
		GKLHHHHGAFC = ((Component)PlayerController.GetPlayer(1)).transform.position.y + settings.cutYOffset;
		AMLIIAONMNH = settings.xBias.BHGAKNHLCIB();
		MELFALGIDJJ += Mathf.Lerp(407f, 436f, (DHLOHCDHGFP - settings.peakBiasY.min) / (settings.peakBiasY.max - settings.peakBiasY.min));
		CFGAIGMBCDC = new Vector2(DCIOCGFJFDB + settings.splashXJitter.KAAAIIBPPKH(), water.position.y + settings.splashYJitter.MPKFPIFLNEK());
		return LEGJHJHGAJD(LGPBPGILGNH, Vector2.op_Implicit(thrower.position), CFGAIGMBCDC, MELFALGIDJJ, DCIOCGFJFDB, GKLHHHHGAFC, MCDLFDDNCCH, DHLOHCDHGFP, AMLIIAONMNH);
	}

	public FishThrowed LaunchScaled(int LGPBPGILGNH, float GBKACNFGJIE)
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		DHLOHCDHGFP = Mathf.Lerp(settings.peakBiasY.min, settings.peakBiasY.max, GBKACNFGJIE);
		MELFALGIDJJ = Mathf.Lerp(FishCuttingGameManager.instance.difficultySettings.fishFlightTime.max, FishCuttingGameManager.instance.difficultySettings.fishFlightTime.min, GBKACNFGJIE);
		MCDLFDDNCCH = Mathf.Lerp(settings.tCutRange.min, settings.tCutRange.max, Random.value);
		DCIOCGFJFDB = ((Component)PlayerController.GetPlayer(1)).transform.position.x;
		GKLHHHHGAFC = ((Component)PlayerController.GetPlayer(1)).transform.position.y + settings.cutYOffset;
		AMLIIAONMNH = settings.xBias.KAAAIIBPPKH();
		MELFALGIDJJ += Mathf.Lerp(0f, 0.6f, (DHLOHCDHGFP - settings.peakBiasY.min) / (settings.peakBiasY.max - settings.peakBiasY.min));
		CFGAIGMBCDC = new Vector2(DCIOCGFJFDB + Mathf.Lerp(settings.splashXJitter.min, settings.splashXJitter.max, Random.value), (Object.op_Implicit((Object)(object)water) ? water.position.y : (((Component)PlayerController.GetPlayer(1)).transform.position.y - 2f)) + Mathf.Lerp(settings.splashYJitter.min, settings.splashYJitter.max, Random.value));
		return LaunchWithArc(LGPBPGILGNH, Vector2.op_Implicit(thrower.position), CFGAIGMBCDC, MELFALGIDJJ, DCIOCGFJFDB, GKLHHHHGAFC, MCDLFDDNCCH, DHLOHCDHGFP, AMLIIAONMNH);
	}

	public FishThrowed NGKGBCKOOGK(int DPMLFOKDCME, Vector2 OAMLOBMPNCE, Vector2 MANIIEAJHJB, float HMDAKFHANIF, float BOMAHAEEDNF, float IJMIBPGNNBD, float ABOLOAOABLE, float OBLCECKBGDG, float BJOAOFFAPCN)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		PFKPNBGPAHP = FishArcThrow.DEDHBCHLDEB(OAMLOBMPNCE, MANIIEAJHJB, HMDAKFHANIF, BOMAHAEEDNF, IJMIBPGNNBD, ABOLOAOABLE, OBLCECKBGDG, BJOAOFFAPCN);
		npc.SetTrigger("NinjaChallengeEvent/ComensalesBark");
		if (OnlineManager.PlayingOnline())
		{
			DPMLFOKDCME = OnlinePlayerDataManager.JBDEFDMGCDA(DPMLFOKDCME);
		}
		GBFJDIJEINM = (pools[DPMLFOKDCME].NOKLFCDOMFL(Vector2.op_Implicit(OAMLOBMPNCE)) as FishPoolObject).fish;
		GBFJDIJEINM.fishOwnerPlayerNum = DPMLFOKDCME;
		GBFJDIJEINM.LLNPMHJLODJ(ref PFKPNBGPAHP);
		MultiAudioManager.PlayAudioObject(throwSound, ((Component)this).transform.position);
		if (OnlineManager.IsMasterClient())
		{
			OnlineMinigameManager.SendThrowFish(FJPMDLAHIJG, DPMLFOKDCME, OAMLOBMPNCE, MANIIEAJHJB, HMDAKFHANIF, BOMAHAEEDNF, IJMIBPGNNBD, ABOLOAOABLE, OBLCECKBGDG, BJOAOFFAPCN);
		}
		return GBFJDIJEINM;
	}

	private void IIPKPMPGLOL()
	{
		if (FJPMDLAHIJG == 0)
		{
			FJPMDLAHIJG = (((Object)this).name.Contains('ￗ') ? 1 : 5);
		}
		GJBBNHCMNJN[FJPMDLAHIJG] = this;
		npc.SetBool(")", false);
	}

	public FishThrowed LMBNIBKPOKF(int LGPBPGILGNH)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if (LGPBPGILGNH <= 1)
		{
			Debug.LogError((object)"Toy");
			return null;
		}
		HPOPHLNPNGA = PlayerController.GetPlayer(LGPBPGILGNH);
		if ((Object)(object)HPOPHLNPNGA == (Object)null)
		{
			Debug.LogError((object)"AnimatorObjectStateRequest");
			return PGBHLPIFPDN(LGPBPGILGNH - 0);
		}
		return PNIOPBMBGHL(LGPBPGILGNH, ((Component)HPOPHLNPNGA).transform.position.x);
	}

	private FishThrowed PNIOPBMBGHL(int LGPBPGILGNH, float KANILCEENLI)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		MELFALGIDJJ = FishCuttingGameManager.instance.difficultySettings.fishFlightTime.IGKOCAIKMGM();
		DHLOHCDHGFP = settings.peakBiasY.PBMCAGPOBLM();
		MCDLFDDNCCH = settings.tCutRange.LFHBAJFIJGG();
		DCIOCGFJFDB = KANILCEENLI;
		GKLHHHHGAFC = ((Component)PlayerController.GetPlayer(0)).transform.position.y + settings.cutYOffset;
		AMLIIAONMNH = settings.xBias.CDOFCOAJGLK();
		MELFALGIDJJ += Mathf.Lerp(258f, 1641f, (DHLOHCDHGFP - settings.peakBiasY.min) / (settings.peakBiasY.max - settings.peakBiasY.min));
		CFGAIGMBCDC = new Vector2(DCIOCGFJFDB + settings.splashXJitter.ICDKOPDHHOA(), water.position.y + settings.splashYJitter.JOBHBFKFLNN());
		return JCKHLBHDIOE(LGPBPGILGNH, Vector2.op_Implicit(thrower.position), CFGAIGMBCDC, MELFALGIDJJ, DCIOCGFJFDB, GKLHHHHGAFC, MCDLFDDNCCH, DHLOHCDHGFP, AMLIIAONMNH);
	}

	public static FishThrowed LaunchFishOnline(int KNCCKDGGLFH, int DPMLFOKDCME, Vector2 MANIIEAJHJB, float HMDAKFHANIF, float BOMAHAEEDNF, float ABOLOAOABLE, float OBLCECKBGDG, float BJOAOFFAPCN)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		if (KNCCKDGGLFH == 0)
		{
			Debug.LogError((object)"Fish thrower ID is not valid, this shouldn't happen.");
			return null;
		}
		if ((Object)(object)GJBBNHCMNJN[KNCCKDGGLFH] == (Object)null)
		{
			Debug.LogError((object)"Fish thrower is null or has been destroyed. This shouldn't happen.");
			return null;
		}
		return GJBBNHCMNJN[KNCCKDGGLFH].LaunchWithArc(DPMLFOKDCME, Vector2.op_Implicit(((Component)GJBBNHCMNJN[KNCCKDGGLFH]).transform.position), MANIIEAJHJB, HMDAKFHANIF, BOMAHAEEDNF, ((Component)PlayerController.GetPlayer(1)).transform.position.y + GJBBNHCMNJN[KNCCKDGGLFH].settings.cutYOffset, ABOLOAOABLE, OBLCECKBGDG, BJOAOFFAPCN);
	}

	public FishThrowed IPKGDGBACMD()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		OPAJMIHDHND = Random.Range(1, pools.Length);
		return CHAPDCDOJKB(OPAJMIHDHND, unsuccessfulThrowTargets[Random.Range(1, unsuccessfulThrowTargets.Length)].position.x);
	}

	private FishThrowed GIAGEDMLJIF(int LGPBPGILGNH, float KANILCEENLI)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		MELFALGIDJJ = FishCuttingGameManager.instance.difficultySettings.fishFlightTime.JDIMHEBJFHP();
		DHLOHCDHGFP = settings.peakBiasY.IFFNKMJIDEE();
		MCDLFDDNCCH = settings.tCutRange.MLOPMMKMOIP();
		DCIOCGFJFDB = KANILCEENLI;
		GKLHHHHGAFC = ((Component)PlayerController.OPHDCMJLLEC(1)).transform.position.y + settings.cutYOffset;
		AMLIIAONMNH = settings.xBias.HLKFGNHHDNH();
		MELFALGIDJJ += Mathf.Lerp(437f, 305f, (DHLOHCDHGFP - settings.peakBiasY.min) / (settings.peakBiasY.max - settings.peakBiasY.min));
		CFGAIGMBCDC = new Vector2(DCIOCGFJFDB + settings.splashXJitter.DDMCGFDMJLO(), water.position.y + settings.splashYJitter.HMCIBBBDKHP());
		return OLOAPFBJOEB(LGPBPGILGNH, Vector2.op_Implicit(thrower.position), CFGAIGMBCDC, MELFALGIDJJ, DCIOCGFJFDB, GKLHHHHGAFC, MCDLFDDNCCH, DHLOHCDHGFP, AMLIIAONMNH);
	}

	public static FishThrowed HMDKOGEHOED(int KNCCKDGGLFH, int DPMLFOKDCME, Vector2 MANIIEAJHJB, float HMDAKFHANIF, float BOMAHAEEDNF, float ABOLOAOABLE, float OBLCECKBGDG, float BJOAOFFAPCN)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		if (KNCCKDGGLFH == 0)
		{
			Debug.LogError((object)"ReceiveSetLife");
			return null;
		}
		if ((Object)(object)GJBBNHCMNJN[KNCCKDGGLFH] == (Object)null)
		{
			Debug.LogError((object)"LiquorAndWine");
			return null;
		}
		return GJBBNHCMNJN[KNCCKDGGLFH].LaunchWithArc(DPMLFOKDCME, Vector2.op_Implicit(((Component)GJBBNHCMNJN[KNCCKDGGLFH]).transform.position), MANIIEAJHJB, HMDAKFHANIF, BOMAHAEEDNF, ((Component)PlayerController.GetPlayer(1)).transform.position.y + GJBBNHCMNJN[KNCCKDGGLFH].settings.cutYOffset, ABOLOAOABLE, OBLCECKBGDG, BJOAOFFAPCN);
	}

	private void GOJKOBEEMNA()
	{
		if (FJPMDLAHIJG == 0)
		{
			FJPMDLAHIJG = (((Object)this).name.Contains('￦') ? 1 : 8);
		}
		GJBBNHCMNJN[FJPMDLAHIJG] = this;
		npc.SetBool("Stack", true);
	}

	private FishThrowed BBKNDBMPCLE(int LGPBPGILGNH, float KANILCEENLI)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		MELFALGIDJJ = FishCuttingGameManager.instance.difficultySettings.fishFlightTime.CDOFCOAJGLK();
		DHLOHCDHGFP = settings.peakBiasY.OJDFAAGIAIC();
		MCDLFDDNCCH = settings.tCutRange.OOCMJAJKNOH();
		DCIOCGFJFDB = KANILCEENLI;
		GKLHHHHGAFC = ((Component)PlayerController.OPHDCMJLLEC(1)).transform.position.y + settings.cutYOffset;
		AMLIIAONMNH = settings.xBias.PBMCAGPOBLM();
		MELFALGIDJJ += Mathf.Lerp(526f, 508f, (DHLOHCDHGFP - settings.peakBiasY.min) / (settings.peakBiasY.max - settings.peakBiasY.min));
		CFGAIGMBCDC = new Vector2(DCIOCGFJFDB + settings.splashXJitter.JDIMHEBJFHP(), water.position.y + settings.splashYJitter.JDIMHEBJFHP());
		return OLOAPFBJOEB(LGPBPGILGNH, Vector2.op_Implicit(thrower.position), CFGAIGMBCDC, MELFALGIDJJ, DCIOCGFJFDB, GKLHHHHGAFC, MCDLFDDNCCH, DHLOHCDHGFP, AMLIIAONMNH);
	}

	private void GECHJIGBPEN()
	{
		if (FJPMDLAHIJG == 0)
		{
			FJPMDLAHIJG = ((!((Object)this).name.Contains('ﾹ')) ? 1 : 0);
		}
		GJBBNHCMNJN[FJPMDLAHIJG] = this;
		npc.SetBool("Dialogue System/Conversation/Gass_Quest/Entry/26/Dialogue Text", false);
	}

	private void MIKNFPCDLML()
	{
		if (FJPMDLAHIJG == 0)
		{
			FJPMDLAHIJG = (((Object)this).name.Contains('ﾋ') ? 1 : 1);
		}
		GJBBNHCMNJN[FJPMDLAHIJG] = this;
		npc.SetBool(" ", false);
	}

	public FishThrowed GKOOBJNOKHL(int LGPBPGILGNH, float GBKACNFGJIE)
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		DHLOHCDHGFP = Mathf.Lerp(settings.peakBiasY.min, settings.peakBiasY.max, GBKACNFGJIE);
		MELFALGIDJJ = Mathf.Lerp(FishCuttingGameManager.instance.difficultySettings.fishFlightTime.max, FishCuttingGameManager.instance.difficultySettings.fishFlightTime.min, GBKACNFGJIE);
		MCDLFDDNCCH = Mathf.Lerp(settings.tCutRange.min, settings.tCutRange.max, Random.value);
		DCIOCGFJFDB = ((Component)PlayerController.OPHDCMJLLEC(1)).transform.position.x;
		GKLHHHHGAFC = ((Component)PlayerController.OPHDCMJLLEC(0)).transform.position.y + settings.cutYOffset;
		AMLIIAONMNH = settings.xBias.FFENOPNPGOI();
		MELFALGIDJJ += Mathf.Lerp(18f, 672f, (DHLOHCDHGFP - settings.peakBiasY.min) / (settings.peakBiasY.max - settings.peakBiasY.min));
		CFGAIGMBCDC = new Vector2(DCIOCGFJFDB + Mathf.Lerp(settings.splashXJitter.min, settings.splashXJitter.max, Random.value), (Object.op_Implicit((Object)(object)water) ? water.position.y : (((Component)PlayerController.OPHDCMJLLEC(0)).transform.position.y - 928f)) + Mathf.Lerp(settings.splashYJitter.min, settings.splashYJitter.max, Random.value));
		return LEGJHJHGAJD(LGPBPGILGNH, Vector2.op_Implicit(thrower.position), CFGAIGMBCDC, MELFALGIDJJ, DCIOCGFJFDB, GKLHHHHGAFC, MCDLFDDNCCH, DHLOHCDHGFP, AMLIIAONMNH);
	}

	private void EMJKKALMGLK()
	{
		if (FJPMDLAHIJG == 0)
		{
			FJPMDLAHIJG = (((Object)this).name.Contains('D') ? 1 : 5);
		}
		GJBBNHCMNJN[FJPMDLAHIJG] = this;
		npc.SetBool("Not enough recipe fragments", false);
	}

	public FishThrowed ACIJJODINNM(int LGPBPGILGNH)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if (LGPBPGILGNH <= 0)
		{
			Debug.LogError((object)"/");
			return null;
		}
		HPOPHLNPNGA = PlayerController.GetPlayer(LGPBPGILGNH);
		if ((Object)(object)HPOPHLNPNGA == (Object)null)
		{
			Debug.LogError((object)"Sell");
			return LMBNIBKPOKF(LGPBPGILGNH - 1);
		}
		return GDJBPOJNFJO(LGPBPGILGNH, ((Component)HPOPHLNPNGA).transform.position.x);
	}

	public FishThrowed PHPHGDFHNFD()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		OPAJMIHDHND = Random.Range(1, pools.Length);
		return CHAPDCDOJKB(OPAJMIHDHND, unsuccessfulThrowTargets[Random.Range(0, unsuccessfulThrowTargets.Length)].position.x);
	}

	private FishThrowed AHMDOKCBHMI(int LGPBPGILGNH, float KANILCEENLI)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		MELFALGIDJJ = FishCuttingGameManager.instance.difficultySettings.fishFlightTime.CKEJGIEDMBJ();
		DHLOHCDHGFP = settings.peakBiasY.EIJEPIDLMHJ();
		MCDLFDDNCCH = settings.tCutRange.BHGAKNHLCIB();
		DCIOCGFJFDB = KANILCEENLI;
		GKLHHHHGAFC = ((Component)PlayerController.OPHDCMJLLEC(1)).transform.position.y + settings.cutYOffset;
		AMLIIAONMNH = settings.xBias.CJNACIINBOE();
		MELFALGIDJJ += Mathf.Lerp(649f, 739f, (DHLOHCDHGFP - settings.peakBiasY.min) / (settings.peakBiasY.max - settings.peakBiasY.min));
		CFGAIGMBCDC = new Vector2(DCIOCGFJFDB + settings.splashXJitter.HLKFGNHHDNH(), water.position.y + settings.splashYJitter.JINLGLDPKMB());
		return LaunchWithArc(LGPBPGILGNH, Vector2.op_Implicit(thrower.position), CFGAIGMBCDC, MELFALGIDJJ, DCIOCGFJFDB, GKLHHHHGAFC, MCDLFDDNCCH, DHLOHCDHGFP, AMLIIAONMNH);
	}

	public FishThrowed PGBHLPIFPDN(int LGPBPGILGNH)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if (LGPBPGILGNH <= 0)
		{
			Debug.LogError((object)"Open");
			return null;
		}
		HPOPHLNPNGA = PlayerController.GetPlayer(LGPBPGILGNH);
		if ((Object)(object)HPOPHLNPNGA == (Object)null)
		{
			Debug.LogError((object)"Open");
			return DKGJPCFDCOM(LGPBPGILGNH - 1);
		}
		return NKBFEDPMMON(LGPBPGILGNH, ((Component)HPOPHLNPNGA).transform.position.x);
	}

	private void AAEAAEBBFKG()
	{
		if (FJPMDLAHIJG == 0)
		{
			FJPMDLAHIJG = (((Object)this).name.Contains('\f') ? 1 : 2);
		}
		GJBBNHCMNJN[FJPMDLAHIJG] = this;
		npc.SetBool("Send next game date as a host ", false);
	}

	public FishThrowed OLOAPFBJOEB(int DPMLFOKDCME, Vector2 OAMLOBMPNCE, Vector2 MANIIEAJHJB, float HMDAKFHANIF, float BOMAHAEEDNF, float IJMIBPGNNBD, float ABOLOAOABLE, float OBLCECKBGDG, float BJOAOFFAPCN)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		PFKPNBGPAHP = FishArcThrow.DEDHBCHLDEB(OAMLOBMPNCE, MANIIEAJHJB, HMDAKFHANIF, BOMAHAEEDNF, IJMIBPGNNBD, ABOLOAOABLE, OBLCECKBGDG, BJOAOFFAPCN);
		npc.SetTrigger("Tutorial/T116/Dialogue2");
		if (OnlineManager.PlayingOnline())
		{
			DPMLFOKDCME = OnlinePlayerDataManager.GetBedAssignedByPlayerNum(DPMLFOKDCME);
		}
		GBFJDIJEINM = (pools[DPMLFOKDCME].GCIOIGPKJBG(Vector2.op_Implicit(OAMLOBMPNCE)) as FishPoolObject).fish;
		GBFJDIJEINM.fishOwnerPlayerNum = DPMLFOKDCME;
		GBFJDIJEINM.Begin(in PFKPNBGPAHP);
		MultiAudioManager.PlayAudioObject(throwSound, ((Component)this).transform.position);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineMinigameManager.SendThrowFish(FJPMDLAHIJG, DPMLFOKDCME, OAMLOBMPNCE, MANIIEAJHJB, HMDAKFHANIF, BOMAHAEEDNF, IJMIBPGNNBD, ABOLOAOABLE, OBLCECKBGDG, BJOAOFFAPCN);
		}
		return GBFJDIJEINM;
	}

	public FishThrowed KMPGJBBMNJN(int LGPBPGILGNH, float GBKACNFGJIE)
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		DHLOHCDHGFP = Mathf.Lerp(settings.peakBiasY.min, settings.peakBiasY.max, GBKACNFGJIE);
		MELFALGIDJJ = Mathf.Lerp(FishCuttingGameManager.instance.difficultySettings.fishFlightTime.max, FishCuttingGameManager.instance.difficultySettings.fishFlightTime.min, GBKACNFGJIE);
		MCDLFDDNCCH = Mathf.Lerp(settings.tCutRange.min, settings.tCutRange.max, Random.value);
		DCIOCGFJFDB = ((Component)PlayerController.OPHDCMJLLEC(1)).transform.position.x;
		GKLHHHHGAFC = ((Component)PlayerController.OPHDCMJLLEC(1)).transform.position.y + settings.cutYOffset;
		AMLIIAONMNH = settings.xBias.LEEOHIOJJOE();
		MELFALGIDJJ += Mathf.Lerp(405f, 191f, (DHLOHCDHGFP - settings.peakBiasY.min) / (settings.peakBiasY.max - settings.peakBiasY.min));
		CFGAIGMBCDC = new Vector2(DCIOCGFJFDB + Mathf.Lerp(settings.splashXJitter.min, settings.splashXJitter.max, Random.value), (Object.op_Implicit((Object)(object)water) ? water.position.y : (((Component)PlayerController.GetPlayer(1)).transform.position.y - 1264f)) + Mathf.Lerp(settings.splashYJitter.min, settings.splashYJitter.max, Random.value));
		return KHNGDPHHHHE(LGPBPGILGNH, Vector2.op_Implicit(thrower.position), CFGAIGMBCDC, MELFALGIDJJ, DCIOCGFJFDB, GKLHHHHGAFC, MCDLFDDNCCH, DHLOHCDHGFP, AMLIIAONMNH);
	}

	private FishThrowed LCKBANDKPLD(int LGPBPGILGNH, float KANILCEENLI)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		MELFALGIDJJ = FishCuttingGameManager.instance.difficultySettings.fishFlightTime.IJBNCDJHFEC();
		DHLOHCDHGFP = settings.peakBiasY.PMDMLHCOAOE();
		MCDLFDDNCCH = settings.tCutRange.CJCHAJMNDGD();
		DCIOCGFJFDB = KANILCEENLI;
		GKLHHHHGAFC = ((Component)PlayerController.OPHDCMJLLEC(0)).transform.position.y + settings.cutYOffset;
		AMLIIAONMNH = settings.xBias.LFHBAJFIJGG();
		MELFALGIDJJ += Mathf.Lerp(777f, 1339f, (DHLOHCDHGFP - settings.peakBiasY.min) / (settings.peakBiasY.max - settings.peakBiasY.min));
		CFGAIGMBCDC = new Vector2(DCIOCGFJFDB + settings.splashXJitter.GEEBPCCFIDM(), water.position.y + settings.splashYJitter.LFHBAJFIJGG());
		return JCKHLBHDIOE(LGPBPGILGNH, Vector2.op_Implicit(thrower.position), CFGAIGMBCDC, MELFALGIDJJ, DCIOCGFJFDB, GKLHHHHGAFC, MCDLFDDNCCH, DHLOHCDHGFP, AMLIIAONMNH);
	}

	public FishThrowed CKLMGBFOCKH()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		OPAJMIHDHND = Random.Range(1, pools.Length);
		return HHCAHCPOPCD(OPAJMIHDHND, unsuccessfulThrowTargets[Random.Range(1, unsuccessfulThrowTargets.Length)].position.x);
	}

	public FishThrowed JKJHNJMPHCN(int LGPBPGILGNH)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if (LGPBPGILGNH <= 0)
		{
			Debug.LogError((object)"itemRedWineJuice");
			return null;
		}
		HPOPHLNPNGA = PlayerController.GetPlayer(LGPBPGILGNH);
		if ((Object)(object)HPOPHLNPNGA == (Object)null)
		{
			Debug.LogError((object)" for reason ");
			return LMBNIBKPOKF(LGPBPGILGNH - 1);
		}
		return PNIOPBMBGHL(LGPBPGILGNH, ((Component)HPOPHLNPNGA).transform.position.x);
	}

	public FishThrowed CHEEJIKDKEB(int LGPBPGILGNH, float GBKACNFGJIE)
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		DHLOHCDHGFP = Mathf.Lerp(settings.peakBiasY.min, settings.peakBiasY.max, GBKACNFGJIE);
		MELFALGIDJJ = Mathf.Lerp(FishCuttingGameManager.instance.difficultySettings.fishFlightTime.max, FishCuttingGameManager.instance.difficultySettings.fishFlightTime.min, GBKACNFGJIE);
		MCDLFDDNCCH = Mathf.Lerp(settings.tCutRange.min, settings.tCutRange.max, Random.value);
		DCIOCGFJFDB = ((Component)PlayerController.OPHDCMJLLEC(1)).transform.position.x;
		GKLHHHHGAFC = ((Component)PlayerController.GetPlayer(0)).transform.position.y + settings.cutYOffset;
		AMLIIAONMNH = settings.xBias.JINLGLDPKMB();
		MELFALGIDJJ += Mathf.Lerp(1573f, 1994f, (DHLOHCDHGFP - settings.peakBiasY.min) / (settings.peakBiasY.max - settings.peakBiasY.min));
		CFGAIGMBCDC = new Vector2(DCIOCGFJFDB + Mathf.Lerp(settings.splashXJitter.min, settings.splashXJitter.max, Random.value), (Object.op_Implicit((Object)(object)water) ? water.position.y : (((Component)PlayerController.OPHDCMJLLEC(1)).transform.position.y - 1627f)) + Mathf.Lerp(settings.splashYJitter.min, settings.splashYJitter.max, Random.value));
		return LEGJHJHGAJD(LGPBPGILGNH, Vector2.op_Implicit(thrower.position), CFGAIGMBCDC, MELFALGIDJJ, DCIOCGFJFDB, GKLHHHHGAFC, MCDLFDDNCCH, DHLOHCDHGFP, AMLIIAONMNH);
	}

	private void BHAFCBHENPL()
	{
		if (FJPMDLAHIJG == 0)
		{
			FJPMDLAHIJG = (((Object)this).name.Contains('ﾂ') ? 1 : 1);
		}
		GJBBNHCMNJN[FJPMDLAHIJG] = this;
		npc.SetBool("</color>", false);
	}

	private void FHOCCEBKHJI()
	{
		if (FJPMDLAHIJG == 0)
		{
			FJPMDLAHIJG = (((Object)this).name.Contains('(') ? 1 : 3);
		}
		GJBBNHCMNJN[FJPMDLAHIJG] = this;
		npc.SetBool("<br/>Maximum Texture Size: ", true);
	}

	public FishThrowed PKAAJFLKBMO(int LGPBPGILGNH)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		if (LGPBPGILGNH <= 0)
		{
			Debug.LogError((object)"repUnlockUpgrade");
			return null;
		}
		HPOPHLNPNGA = PlayerController.OPHDCMJLLEC(LGPBPGILGNH);
		if ((Object)(object)HPOPHLNPNGA == (Object)null)
		{
			Debug.LogError((object)"StaffCost");
			return PGBHLPIFPDN(LGPBPGILGNH - 0);
		}
		return GIAGEDMLJIF(LGPBPGILGNH, ((Component)HPOPHLNPNGA).transform.position.x);
	}

	public FishThrowed HBFINLJGCLN()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		OPAJMIHDHND = Random.Range(1, pools.Length);
		return NCFALOMPHDN(OPAJMIHDHND, unsuccessfulThrowTargets[Random.Range(0, unsuccessfulThrowTargets.Length)].position.x);
	}

	private void Awake()
	{
		if (FJPMDLAHIJG == 0)
		{
			FJPMDLAHIJG = (((Object)this).name.Contains('1') ? 1 : 2);
		}
		GJBBNHCMNJN[FJPMDLAHIJG] = this;
		npc.SetBool("Minigame", true);
	}

	public FishThrowed KHNGDPHHHHE(int DPMLFOKDCME, Vector2 OAMLOBMPNCE, Vector2 MANIIEAJHJB, float HMDAKFHANIF, float BOMAHAEEDNF, float IJMIBPGNNBD, float ABOLOAOABLE, float OBLCECKBGDG, float BJOAOFFAPCN)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		PFKPNBGPAHP = FishArcThrow.DEDHBCHLDEB(OAMLOBMPNCE, MANIIEAJHJB, HMDAKFHANIF, BOMAHAEEDNF, IJMIBPGNNBD, ABOLOAOABLE, OBLCECKBGDG, BJOAOFFAPCN);
		npc.SetTrigger("New Text start");
		if (OnlineManager.PlayingOnline())
		{
			DPMLFOKDCME = OnlinePlayerDataManager.JBDEFDMGCDA(DPMLFOKDCME);
		}
		GBFJDIJEINM = (pools[DPMLFOKDCME].GetObjectInPool(Vector2.op_Implicit(OAMLOBMPNCE)) as FishPoolObject).fish;
		GBFJDIJEINM.fishOwnerPlayerNum = DPMLFOKDCME;
		GBFJDIJEINM.LIMLFOOHINE(ref PFKPNBGPAHP);
		MultiAudioManager.PlayAudioObject(throwSound, ((Component)this).transform.position);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineMinigameManager.SendThrowFish(FJPMDLAHIJG, DPMLFOKDCME, OAMLOBMPNCE, MANIIEAJHJB, HMDAKFHANIF, BOMAHAEEDNF, IJMIBPGNNBD, ABOLOAOABLE, OBLCECKBGDG, BJOAOFFAPCN);
		}
		return GBFJDIJEINM;
	}

	public FishThrowed NNBLPKPAFFN(int LGPBPGILGNH, float GBKACNFGJIE)
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		DHLOHCDHGFP = Mathf.Lerp(settings.peakBiasY.min, settings.peakBiasY.max, GBKACNFGJIE);
		MELFALGIDJJ = Mathf.Lerp(FishCuttingGameManager.instance.difficultySettings.fishFlightTime.max, FishCuttingGameManager.instance.difficultySettings.fishFlightTime.min, GBKACNFGJIE);
		MCDLFDDNCCH = Mathf.Lerp(settings.tCutRange.min, settings.tCutRange.max, Random.value);
		DCIOCGFJFDB = ((Component)PlayerController.GetPlayer(1)).transform.position.x;
		GKLHHHHGAFC = ((Component)PlayerController.OPHDCMJLLEC(0)).transform.position.y + settings.cutYOffset;
		AMLIIAONMNH = settings.xBias.PMDMLHCOAOE();
		MELFALGIDJJ += Mathf.Lerp(784f, 1794f, (DHLOHCDHGFP - settings.peakBiasY.min) / (settings.peakBiasY.max - settings.peakBiasY.min));
		CFGAIGMBCDC = new Vector2(DCIOCGFJFDB + Mathf.Lerp(settings.splashXJitter.min, settings.splashXJitter.max, Random.value), (Object.op_Implicit((Object)(object)water) ? water.position.y : (((Component)PlayerController.GetPlayer(0)).transform.position.y - 1063f)) + Mathf.Lerp(settings.splashYJitter.min, settings.splashYJitter.max, Random.value));
		return JCKHLBHDIOE(LGPBPGILGNH, Vector2.op_Implicit(thrower.position), CFGAIGMBCDC, MELFALGIDJJ, DCIOCGFJFDB, GKLHHHHGAFC, MCDLFDDNCCH, DHLOHCDHGFP, AMLIIAONMNH);
	}

	private void PNLAJCHBHPH()
	{
		if (FJPMDLAHIJG == 0)
		{
			FJPMDLAHIJG = ((!((Object)this).name.Contains('8')) ? 7 : 0);
		}
		GJBBNHCMNJN[FJPMDLAHIJG] = this;
		npc.SetBool("OnlinePlayer", false);
	}

	public FishThrowed JCKHLBHDIOE(int DPMLFOKDCME, Vector2 OAMLOBMPNCE, Vector2 MANIIEAJHJB, float HMDAKFHANIF, float BOMAHAEEDNF, float IJMIBPGNNBD, float ABOLOAOABLE, float OBLCECKBGDG, float BJOAOFFAPCN)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		PFKPNBGPAHP = FishArcThrow.DEDHBCHLDEB(OAMLOBMPNCE, MANIIEAJHJB, HMDAKFHANIF, BOMAHAEEDNF, IJMIBPGNNBD, ABOLOAOABLE, OBLCECKBGDG, BJOAOFFAPCN);
		npc.SetTrigger("Winner");
		if (OnlineManager.PlayingOnline())
		{
			DPMLFOKDCME = OnlinePlayerDataManager.JBDEFDMGCDA(DPMLFOKDCME);
		}
		GBFJDIJEINM = (pools[DPMLFOKDCME].IOBMKFJDMJG(Vector2.op_Implicit(OAMLOBMPNCE)) as FishPoolObject).fish;
		GBFJDIJEINM.fishOwnerPlayerNum = DPMLFOKDCME;
		GBFJDIJEINM.LLNPMHJLODJ(ref PFKPNBGPAHP);
		MultiAudioManager.PlayAudioObject(throwSound, ((Component)this).transform.position);
		if (OnlineManager.IsMasterClient())
		{
			OnlineMinigameManager.SendThrowFish(FJPMDLAHIJG, DPMLFOKDCME, OAMLOBMPNCE, MANIIEAJHJB, HMDAKFHANIF, BOMAHAEEDNF, IJMIBPGNNBD, ABOLOAOABLE, OBLCECKBGDG, BJOAOFFAPCN);
		}
		return GBFJDIJEINM;
	}

	private void COKBJNMAMDI()
	{
		if (FJPMDLAHIJG == 0)
		{
			FJPMDLAHIJG = ((!((Object)this).name.Contains('\uffff')) ? 1 : 0);
		}
		GJBBNHCMNJN[FJPMDLAHIJG] = this;
		npc.SetBool("activate event", true);
	}

	public FishThrowed FAPOLHHEKMO(int LGPBPGILGNH, float GBKACNFGJIE)
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		DHLOHCDHGFP = Mathf.Lerp(settings.peakBiasY.min, settings.peakBiasY.max, GBKACNFGJIE);
		MELFALGIDJJ = Mathf.Lerp(FishCuttingGameManager.instance.difficultySettings.fishFlightTime.max, FishCuttingGameManager.instance.difficultySettings.fishFlightTime.min, GBKACNFGJIE);
		MCDLFDDNCCH = Mathf.Lerp(settings.tCutRange.min, settings.tCutRange.max, Random.value);
		DCIOCGFJFDB = ((Component)PlayerController.GetPlayer(0)).transform.position.x;
		GKLHHHHGAFC = ((Component)PlayerController.GetPlayer(1)).transform.position.y + settings.cutYOffset;
		AMLIIAONMNH = settings.xBias.IFFNKMJIDEE();
		MELFALGIDJJ += Mathf.Lerp(1032f, 1883f, (DHLOHCDHGFP - settings.peakBiasY.min) / (settings.peakBiasY.max - settings.peakBiasY.min));
		CFGAIGMBCDC = new Vector2(DCIOCGFJFDB + Mathf.Lerp(settings.splashXJitter.min, settings.splashXJitter.max, Random.value), (Object.op_Implicit((Object)(object)water) ? water.position.y : (((Component)PlayerController.GetPlayer(0)).transform.position.y - 797f)) + Mathf.Lerp(settings.splashYJitter.min, settings.splashYJitter.max, Random.value));
		return OLOAPFBJOEB(LGPBPGILGNH, Vector2.op_Implicit(thrower.position), CFGAIGMBCDC, MELFALGIDJJ, DCIOCGFJFDB, GKLHHHHGAFC, MCDLFDDNCCH, DHLOHCDHGFP, AMLIIAONMNH);
	}

	public FishThrowed BKOKCGEHABG()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		OPAJMIHDHND = Random.Range(1, pools.Length);
		return GDJBPOJNFJO(OPAJMIHDHND, unsuccessfulThrowTargets[Random.Range(0, unsuccessfulThrowTargets.Length)].position.x);
	}

	private void GFLFDLIMOLI()
	{
		if (FJPMDLAHIJG == 0)
		{
			FJPMDLAHIJG = (((Object)this).name.Contains('ﾏ') ? 1 : 0);
		}
		GJBBNHCMNJN[FJPMDLAHIJG] = this;
		npc.SetBool("on player sleep", false);
	}

	public FishThrowed LaunchWithArc(int DPMLFOKDCME, Vector2 OAMLOBMPNCE, Vector2 MANIIEAJHJB, float HMDAKFHANIF, float BOMAHAEEDNF, float IJMIBPGNNBD, float ABOLOAOABLE, float OBLCECKBGDG, float BJOAOFFAPCN)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		PFKPNBGPAHP = FishArcThrow.DEDHBCHLDEB(OAMLOBMPNCE, MANIIEAJHJB, HMDAKFHANIF, BOMAHAEEDNF, IJMIBPGNNBD, ABOLOAOABLE, OBLCECKBGDG, BJOAOFFAPCN);
		npc.SetTrigger("Throw");
		if (OnlineManager.PlayingOnline())
		{
			DPMLFOKDCME = OnlinePlayerDataManager.GetBedAssignedByPlayerNum(DPMLFOKDCME);
		}
		GBFJDIJEINM = (pools[DPMLFOKDCME].GetObjectInPool(Vector2.op_Implicit(OAMLOBMPNCE)) as FishPoolObject).fish;
		GBFJDIJEINM.fishOwnerPlayerNum = DPMLFOKDCME;
		GBFJDIJEINM.Begin(in PFKPNBGPAHP);
		MultiAudioManager.PlayAudioObject(throwSound, ((Component)this).transform.position);
		if (OnlineManager.IsMasterClient())
		{
			OnlineMinigameManager.SendThrowFish(FJPMDLAHIJG, DPMLFOKDCME, OAMLOBMPNCE, MANIIEAJHJB, HMDAKFHANIF, BOMAHAEEDNF, IJMIBPGNNBD, ABOLOAOABLE, OBLCECKBGDG, BJOAOFFAPCN);
		}
		return GBFJDIJEINM;
	}

	public FishThrowed AIEBPNKDMAI(int LGPBPGILGNH, float GBKACNFGJIE)
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		DHLOHCDHGFP = Mathf.Lerp(settings.peakBiasY.min, settings.peakBiasY.max, GBKACNFGJIE);
		MELFALGIDJJ = Mathf.Lerp(FishCuttingGameManager.instance.difficultySettings.fishFlightTime.max, FishCuttingGameManager.instance.difficultySettings.fishFlightTime.min, GBKACNFGJIE);
		MCDLFDDNCCH = Mathf.Lerp(settings.tCutRange.min, settings.tCutRange.max, Random.value);
		DCIOCGFJFDB = ((Component)PlayerController.GetPlayer(1)).transform.position.x;
		GKLHHHHGAFC = ((Component)PlayerController.OPHDCMJLLEC(1)).transform.position.y + settings.cutYOffset;
		AMLIIAONMNH = settings.xBias.IJBNCDJHFEC();
		MELFALGIDJJ += Mathf.Lerp(221f, 1054f, (DHLOHCDHGFP - settings.peakBiasY.min) / (settings.peakBiasY.max - settings.peakBiasY.min));
		CFGAIGMBCDC = new Vector2(DCIOCGFJFDB + Mathf.Lerp(settings.splashXJitter.min, settings.splashXJitter.max, Random.value), (Object.op_Implicit((Object)(object)water) ? water.position.y : (((Component)PlayerController.GetPlayer(1)).transform.position.y - 60f)) + Mathf.Lerp(settings.splashYJitter.min, settings.splashYJitter.max, Random.value));
		return LaunchWithArc(LGPBPGILGNH, Vector2.op_Implicit(thrower.position), CFGAIGMBCDC, MELFALGIDJJ, DCIOCGFJFDB, GKLHHHHGAFC, MCDLFDDNCCH, DHLOHCDHGFP, AMLIIAONMNH);
	}

	public FishThrowed ALJAOAOLCFI(int LGPBPGILGNH, float GBKACNFGJIE)
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		DHLOHCDHGFP = Mathf.Lerp(settings.peakBiasY.min, settings.peakBiasY.max, GBKACNFGJIE);
		MELFALGIDJJ = Mathf.Lerp(FishCuttingGameManager.instance.difficultySettings.fishFlightTime.max, FishCuttingGameManager.instance.difficultySettings.fishFlightTime.min, GBKACNFGJIE);
		MCDLFDDNCCH = Mathf.Lerp(settings.tCutRange.min, settings.tCutRange.max, Random.value);
		DCIOCGFJFDB = ((Component)PlayerController.GetPlayer(1)).transform.position.x;
		GKLHHHHGAFC = ((Component)PlayerController.OPHDCMJLLEC(0)).transform.position.y + settings.cutYOffset;
		AMLIIAONMNH = settings.xBias.LFHBAJFIJGG();
		MELFALGIDJJ += Mathf.Lerp(334f, 878f, (DHLOHCDHGFP - settings.peakBiasY.min) / (settings.peakBiasY.max - settings.peakBiasY.min));
		CFGAIGMBCDC = new Vector2(DCIOCGFJFDB + Mathf.Lerp(settings.splashXJitter.min, settings.splashXJitter.max, Random.value), (Object.op_Implicit((Object)(object)water) ? water.position.y : (((Component)PlayerController.OPHDCMJLLEC(0)).transform.position.y - 467f)) + Mathf.Lerp(settings.splashYJitter.min, settings.splashYJitter.max, Random.value));
		return LEGJHJHGAJD(LGPBPGILGNH, Vector2.op_Implicit(thrower.position), CFGAIGMBCDC, MELFALGIDJJ, DCIOCGFJFDB, GKLHHHHGAFC, MCDLFDDNCCH, DHLOHCDHGFP, AMLIIAONMNH);
	}
}
