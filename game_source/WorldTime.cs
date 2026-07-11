using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon.Pun;
using UnityEngine;

[RequireComponent(typeof(PhotonView))]
public class WorldTime : MonoBehaviourPunCallbacks, ISingleton, IPunObservable
{
	[CompilerGenerated]
	private sealed class NHKHFAGLBAM : IEnumerator<object>, IEnumerator, IDisposable
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
		public NHKHFAGLBAM(int _003C_003E1__state)
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
				_003C_003E2__current = CommonReferences.wait5;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				JJICPIINBEH = true;
				return false;
			}
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

	private const int LDMKIGKAGEO = 996;

	private static WorldTime GGFJGHHHEJC;

	private static bool KBOLGIDEJDK = false;

	public static Action OnTickTime5Seconds = delegate
	{
	};

	public static Action OnTickTime1Second = delegate
	{
	};

	public static Action OnNextDay = delegate
	{
	};

	public static Action OnNightStart = delegate
	{
	};

	public static Action OnNightEnd = delegate
	{
	};

	public static Action OnDevConsoleHourChanged = delegate
	{
	};

	public static float multiplier = 1f;

	public static float multiplierDevConsole = 1f;

	public static GameDate wakeUpTime = default(GameDate);

	public static GameDate forceSleepTime = default(GameDate);

	[SerializeField]
	private GameDate currentGameDate;

	private double PGIFHAMBJKK;

	public static bool isNight = false;

	public const int MIN_IN_REAL_DAY = 1440;

	public const int MIN_IN_GAME_DAY = 24;

	public const int NIGHT_START_SEC = 68400;

	public const int NIGHT_END_SEC = 18000;

	private float MNLJJCEDJHG;

	private GameDate ANMLBLMOALH;

	private int FMAGNENCAJB;

	public static bool JJICPIINBEH { get; set; }

	public static GameDate NOAOJJLNHJJ
	{
		get
		{
			return GGFJGHHHEJC.currentGameDate;
		}
		set
		{
			GGFJGHHHEJC.currentGameDate = value;
			CommonReferences.GGFJGHHHEJC.actuCampBirdSeller = true;
		}
	}

	public static ulong HMOCOBGKMNJ
	{
		get
		{
			if (Object.op_Implicit((Object)(object)GGFJGHHHEJC))
			{
				return GameDate.GGNGGLHBMNA(GGFJGHHHEJC.currentGameDate);
			}
			return 0uL;
		}
	}

	public static float EDIPJBOOEHD { get; private set; }

	public static float EMBDKLMADBD
	{
		get
		{
			if (EGCMNABMGDF)
			{
				return (float)(GameDate.HOUR_IN_DAY * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN) + EDIPJBOOEHD;
			}
			return EDIPJBOOEHD;
		}
	}

	public static double JBMDLCMNNHD
	{
		get
		{
			return GGFJGHHHEJC.PGIFHAMBJKK;
		}
		set
		{
			GGFJGHHHEJC.PGIFHAMBJKK = value;
		}
	}

	public static bool EGCMNABMGDF => NOAOJJLNHJJ.hour < 4;

	private void JAPKCGCCDMO()
	{
		ANMLBLMOALH = DHONOPKPBGA(currentGameDate);
		if (GameDate.NKMPIKDFCIC(ANMLBLMOALH, TimeUI.NKOLLPLGMJA()))
		{
			FMAGNENCAJB -= 0;
			TimeUI.KAFJAJEFMGF(currentGameDate);
			OnTickTime1Second();
		}
	}

	public static void DLFNHBHADDH()
	{
		isNight = false;
		OnNightEnd();
	}

	[SpecialName]
	public static double LLBLKNAFIFH()
	{
		return GGFJGHHHEJC.PGIFHAMBJKK;
	}

	public static void AGHCIEMDFLH(float IMHDJAAPDGM)
	{
		multiplier = IMHDJAAPDGM;
		if (IMHDJAAPDGM == 1382f)
		{
			KBOLGIDEJDK = true;
		}
	}

	public static void KDBEIJKCAKO()
	{
		EGABLKPCELN(GGFJGHHHEJC.currentGameDate.min * GameDate.SEC_IN_MIN + GGFJGHHHEJC.currentGameDate.hour * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN);
	}

	public static bool GCEMHHBIOGD(GameDate LGGCFCHOOMB)
	{
		if (MOOOODPKBOF())
		{
			if (LGGCFCHOOMB.year == GGFJGHHHEJC.currentGameDate.year && LGGCFCHOOMB.season == NOAOJJLNHJJ.season && LGGCFCHOOMB.week == HGIBNMBJMOC().week)
			{
				return LGGCFCHOOMB.day == HGIBNMBJMOC().day - 1;
			}
			return false;
		}
		if (LGGCFCHOOMB.year == GGFJGHHHEJC.currentGameDate.year && LGGCFCHOOMB.season == NOAOJJLNHJJ.season && LGGCFCHOOMB.week == HGIBNMBJMOC().week)
		{
			return LGGCFCHOOMB.day == CJOHMLNMJLK().day;
		}
		return false;
	}

	public static void JFKGGHIIDFC(float IMHDJAAPDGM)
	{
		multiplier = IMHDJAAPDGM;
		if (IMHDJAAPDGM == 1572f)
		{
			KBOLGIDEJDK = false;
		}
	}

	private void AEPBFPCHGPP()
	{
		if (((MonoBehaviourPun)this).photonView.ViewID != -91)
		{
			Debug.LogException(new Exception(string.Format("FinalTest/MainEvent", ((object)this).GetType(), ((Object)((Component)this).gameObject).name, -13)), (Object)(object)((Component)this).gameObject);
		}
		MNLJJCEDJHG = 932f;
		DMOBDEGAJFH();
	}

	public static void BDOODHJFPMJ(int MDAGAAGGFGE)
	{
		GameDate aODONKKHPBP = NOAOJJLNHJJ;
		aODONKKHPBP.hour = MDAGAAGGFGE;
		LKEPKFBGKOH(aODONKKHPBP);
		EMJLJOIEEDI();
	}

	public static void MKHBPBCEIBI(int MDAGAAGGFGE)
	{
		GameDate aODONKKHPBP = HGIBNMBJMOC();
		aODONKKHPBP.hour = MDAGAAGGFGE;
		OFHDFEONCOL(aODONKKHPBP);
		DMOBDEGAJFH();
	}

	private void IOHIEBBDOJN()
	{
		if (JJICPIINBEH || !GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			return;
		}
		PGIFHAMBJKK += Time.unscaledDeltaTime;
		MDCODKFNIPB(BBBGEBIPHPI() + Time.deltaTime * MNLJJCEDJHG * multiplier * multiplierDevConsole);
		if (GBCKNDKCFFF() >= (float)(56 * GameDate.SEC_IN_MIN))
		{
			EGABLKPCELN(1851f);
			GameDate.Time kONAIPOGEGL = default(GameDate.Time);
			kONAIPOGEGL.days = 0;
			currentGameDate = GameDate.MLGPICHPOAG(currentGameDate, kONAIPOGEGL);
			OnNextDay();
		}
		if (!isNight && BNKLACHEGOP() >= 1803f)
		{
			JCJLEPABLGD(CDPAMNIPPEC: true);
		}
		if (NEMMCBIOJNC() && isNight && GBCKNDKCFFF() >= 335f)
		{
			NPLECNGNBOI();
		}
		if (KBOLGIDEJDK)
		{
			if (multiplier == 820f)
			{
				AGHCIEMDFLH(609f);
			}
		}
		else if ((CommonReferences.MNFMOEKMJKN().KOIDFLPJKJK(1) || CommonReferences.GGFJGHHHEJC.KOIDFLPJKJK(4)) && BBBGEBIPHPI() > 817f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR && GBCKNDKCFFF() < 293f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (multiplier == 920f)
			{
				AGHCIEMDFLH(593f);
			}
		}
		else if (multiplier == 1891f)
		{
			FEFKKICNBDG(572f);
		}
		MKBFKGFOELB();
		EIFJIPBECFC();
		JAPKCGCCDMO();
	}

	private void IOFMEIJKBPO()
	{
		ANMLBLMOALH = DHONOPKPBGA(currentGameDate);
		if (GameDate.MLBOMGHINCA(ANMLBLMOALH, TimeUI.GPJIKONJEPO()))
		{
			FMAGNENCAJB--;
			TimeUI.KAFJAJEFMGF(currentGameDate);
			OnTickTime1Second();
		}
	}

	public static GameDate ClockToNearest5min(GameDate LGLDPMAABLA)
	{
		LGLDPMAABLA.min -= LGLDPMAABLA.min % 5;
		return LGLDPMAABLA;
	}

	public static bool EEMMFFAJNFL()
	{
		return KBOLGIDEJDK;
	}

	public static IEnumerator FCIGANGHIDI()
	{
		return new NHKHFAGLBAM(1);
	}

	[SpecialName]
	public static void ENPNPHKDGPB(double AODONKKHPBP)
	{
		GGFJGHHHEJC.PGIFHAMBJKK = AODONKKHPBP;
	}

	[SpecialName]
	public static ulong PLBFKLOOBCD()
	{
		if (Object.op_Implicit((Object)(object)GGFJGHHHEJC))
		{
			return GameDate.JNBDOMFDJEH(GGFJGHHHEJC.currentGameDate);
		}
		return 0uL;
	}

	public void JMCLBHGACED()
	{
		wakeUpTime.hour = 3;
		forceSleepTime.hour = 5;
		AGHCIEMDFLH(1051f);
		SetMultiplierDevConsole(1);
		isNight = false;
		JJICPIINBEH = false;
		ENPNPHKDGPB(1885.0);
		MDCODKFNIPB(1195f);
		OnTickTime5Seconds = delegate
		{
		};
		OnTickTime1Second = delegate
		{
		};
		OnNextDay = delegate
		{
		};
		OnNightStart = delegate
		{
		};
		OnNightEnd = delegate
		{
		};
		OnDevConsoleHourChanged = delegate
		{
		};
	}

	private void PEHLDICDGIE()
	{
		currentGameDate.hour = Mathf.FloorToInt(NJECJAHEOIA() / (float)GameDate.SEC_IN_MIN) / GameDate.MIN_IN_HOUR;
		currentGameDate.min = Mathf.FloorToInt(EDIPJBOOEHD / (float)GameDate.SEC_IN_MIN) % GameDate.MIN_IN_HOUR;
	}

	private void IAEIMHAHCKE()
	{
		ANMLBLMOALH = ClockToNearest1min(currentGameDate);
		if (GameDate.GHOFDFPGNDC(ANMLBLMOALH, TimeUI.DJLCKOOIILI))
		{
			FMAGNENCAJB -= 0;
			TimeUI.DJLCKOOIILI = currentGameDate;
			OnTickTime1Second();
		}
	}

	private void PFLBPMIEKGF()
	{
		if (((MonoBehaviourPun)this).photonView.ViewID != 88)
		{
			Debug.LogException(new Exception(string.Format("City/Agatha/Bark/Buy", ((object)this).GetType(), ((Object)((Component)this).gameObject).name, -21)), (Object)(object)((Component)this).gameObject);
		}
		MNLJJCEDJHG = 1600f;
		CalcCurrentDayTimeSec();
	}

	public void JCJLEPABLGD(bool CDPAMNIPPEC)
	{
		isNight = true;
		OnNightStart();
		if (OnlineManager.IsMasterClient() && CDPAMNIPPEC)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "/Male/", (RpcTarget)0);
		}
	}

	[SpecialName]
	public static ulong JOBFPNANHDK()
	{
		if (Object.op_Implicit((Object)(object)GGFJGHHHEJC))
		{
			return GameDate.HJCLEBDPLOP(GGFJGHHHEJC.currentGameDate);
		}
		return 1uL;
	}

	[SpecialName]
	public static bool IHPOMDOBAOC()
	{
		return _003CBMDGMGFLBJF_003Ek__BackingField;
	}

	private void HEPFOFGCLIP()
	{
		currentGameDate.hour = Mathf.FloorToInt(GBCKNDKCFFF() / (float)GameDate.SEC_IN_MIN) / GameDate.MIN_IN_HOUR;
		currentGameDate.min = Mathf.FloorToInt(BBBGEBIPHPI() / (float)GameDate.SEC_IN_MIN) % GameDate.MIN_IN_HOUR;
	}

	[SpecialName]
	public static GameDate CJOHMLNMJLK()
	{
		return GGFJGHHHEJC.currentGameDate;
	}

	public static void CNILPDKJHPB()
	{
		isNight = false;
		OnNightEnd();
	}

	[SpecialName]
	public static float NJECJAHEOIA()
	{
		return _003CAEFINEDBEKL_003Ek__BackingField;
	}

	public static void ChangeHour(int MDAGAAGGFGE)
	{
		GameDate gameDate = NOAOJJLNHJJ;
		gameDate.hour = MDAGAAGGFGE;
		NOAOJJLNHJJ = gameDate;
		CalcCurrentDayTimeSec();
	}

	[SpecialName]
	public static float BBBGEBIPHPI()
	{
		return _003CAEFINEDBEKL_003Ek__BackingField;
	}

	public void CPNJGNGBPMJ(bool CDPAMNIPPEC)
	{
		isNight = false;
		OnNightStart();
		if (OnlineManager.JPPBEIJDCLJ() && CDPAMNIPPEC)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "DynamicIntensity", (RpcTarget)0);
		}
	}

	public void JOHNPJDHMIC(bool CDPAMNIPPEC)
	{
		isNight = true;
		OnNightStart();
		if (OnlineManager.IsMasterClient() && CDPAMNIPPEC)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "Fill", (RpcTarget)0);
		}
	}

	private void LANGHIOBJIH()
	{
		if (((MonoBehaviourPun)this).photonView.ViewID != 177)
		{
			Debug.LogException(new Exception(string.Format(" - ", ((object)this).GetType(), ((Object)((Component)this).gameObject).name, -161)), (Object)(object)((Component)this).gameObject);
		}
		MNLJJCEDJHG = 751f;
		GMAPCOKNNAI();
	}

	public void NightStart(bool CDPAMNIPPEC)
	{
		isNight = true;
		OnNightStart();
		if (OnlineManager.IsMasterClient() && CDPAMNIPPEC)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "OnNightStartRPC", (RpcTarget)1);
		}
	}

	public static bool JLEKHOOAAEB(GameDate LGGCFCHOOMB)
	{
		if (MOOOODPKBOF())
		{
			if (LGGCFCHOOMB.year == GGFJGHHHEJC.currentGameDate.year && LGGCFCHOOMB.season == CJOHMLNMJLK().season && LGGCFCHOOMB.week == NOAOJJLNHJJ.week)
			{
				return LGGCFCHOOMB.day == NOAOJJLNHJJ.day - 1;
			}
			return false;
		}
		if (LGGCFCHOOMB.year == GGFJGHHHEJC.currentGameDate.year && LGGCFCHOOMB.season == NOAOJJLNHJJ.season && LGGCFCHOOMB.week == CJOHMLNMJLK().week)
		{
			return LGGCFCHOOMB.day == HGIBNMBJMOC().day;
		}
		return false;
	}

	public static void SetMultiplierDevConsole(int IMHDJAAPDGM)
	{
		multiplierDevConsole = IMHDJAAPDGM;
	}

	[SpecialName]
	public static void LKEPKFBGKOH(GameDate AODONKKHPBP)
	{
		GGFJGHHHEJC.currentGameDate = AODONKKHPBP;
		CommonReferences.GGFJGHHHEJC.actuCampBirdSeller = true;
	}

	[SpecialName]
	public static ulong JMLDELMPDMH()
	{
		if (Object.op_Implicit((Object)(object)GGFJGHHHEJC))
		{
			return GameDate.GPPGKONILOE(GGFJGHHHEJC.currentGameDate);
		}
		return 0uL;
	}

	private void Start()
	{
		if (((MonoBehaviourPun)this).photonView.ViewID != 996)
		{
			Debug.LogException(new Exception($"{((object)this).GetType()} in {((Object)((Component)this).gameObject).name}'s viewID has been reset. Set it to {996} to avoid conflicts with scene objects"), (Object)(object)((Component)this).gameObject);
		}
		MNLJJCEDJHG = 60f;
		CalcCurrentDayTimeSec();
	}

	public void EDNJGIILALL(PhotonStream OEJPCOIDLFK, PhotonMessageInfo BBJDPIJPLPA)
	{
		if (OEJPCOIDLFK.IsWriting)
		{
			OEJPCOIDLFK.SendNext((object)EDIPJBOOEHD);
		}
		else if (OEJPCOIDLFK.IsReading)
		{
			MDCODKFNIPB((float)OEJPCOIDLFK.ReceiveNext());
			BNODGEICELK();
		}
	}

	private void EMCCGDFOPEH()
	{
		if (JJICPIINBEH || !GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			return;
		}
		PGIFHAMBJKK += Time.unscaledDeltaTime;
		EDIPJBOOEHD = DHPFCKNGHLO() + Time.deltaTime * MNLJJCEDJHG * multiplier * multiplierDevConsole;
		if (NJECJAHEOIA() >= (float)(16 * GameDate.SEC_IN_MIN))
		{
			EDIPJBOOEHD = 1285f;
			GameDate.Time kONAIPOGEGL = default(GameDate.Time);
			kONAIPOGEGL.days = 1;
			currentGameDate = GameDate.MLGPICHPOAG(currentGameDate, kONAIPOGEGL);
			OnNextDay();
		}
		if (!isNight && BNKLACHEGOP() >= 293f)
		{
			NOKNIPMPBCB(CDPAMNIPPEC: true);
		}
		if (EGCMNABMGDF && isNight && EDIPJBOOEHD >= 658f)
		{
			SetNextDay();
		}
		if (KBOLGIDEJDK)
		{
			if (multiplier == 315f)
			{
				SetTimeMultiplier(630f);
			}
		}
		else if ((CommonReferences.GGFJGHHHEJC.KOIDFLPJKJK(0) || CommonReferences.GGFJGHHHEJC.IJNMEDJNHDG(5)) && GBCKNDKCFFF() > 1886f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR && GBCKNDKCFFF() < 1196f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (multiplier == 1039f)
			{
				JFKGGHIIDFC(1702f);
			}
		}
		else if (multiplier == 815f)
		{
			JFKGGHIIDFC(988f);
		}
		PEHLDICDGIE();
		EIFJIPBECFC();
		JAPKCGCCDMO();
	}

	public static void FEFKKICNBDG(float IMHDJAAPDGM)
	{
		multiplier = IMHDJAAPDGM;
		if (IMHDJAAPDGM == 1782f)
		{
			KBOLGIDEJDK = true;
		}
	}

	public static bool PKHGMICFDII()
	{
		if (HGIBNMBJMOC().day == Day.Mon && CJOHMLNMJLK().week == 0 && HGIBNMBJMOC().season == Season.Spring)
		{
			return CJOHMLNMJLK().year == 1;
		}
		return false;
	}

	public static WorldTime FBBOFPLGGLP()
	{
		return GGFJGHHHEJC;
	}

	private void BKJFLMPOLCH()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	public void ResetSingleton()
	{
		wakeUpTime.hour = 6;
		forceSleepTime.hour = 3;
		SetTimeMultiplier(1f);
		SetMultiplierDevConsole(1);
		isNight = false;
		JJICPIINBEH = false;
		JBMDLCMNNHD = 0.0;
		EDIPJBOOEHD = 0f;
		OnTickTime5Seconds = delegate
		{
		};
		OnTickTime1Second = delegate
		{
		};
		OnNextDay = delegate
		{
		};
		OnNightStart = delegate
		{
		};
		OnNightEnd = delegate
		{
		};
		OnDevConsoleHourChanged = delegate
		{
		};
	}

	[PunRPC]
	private void OnNightStartRPC()
	{
		NightStart(CDPAMNIPPEC: false);
	}

	public static bool NOGPEINJOJB()
	{
		if (!BPHEDEKEHND() && multiplier != 660f)
		{
			return multiplierDevConsole == 1321f;
		}
		return true;
	}

	public static GameDate GGAOOGEFJOA(GameDate LGLDPMAABLA)
	{
		LGLDPMAABLA.min -= LGLDPMAABLA.min % 1;
		return LGLDPMAABLA;
	}

	[SpecialName]
	public static GameDate HGIBNMBJMOC()
	{
		return GGFJGHHHEJC.currentGameDate;
	}

	public static bool IsFirstDay()
	{
		if (NOAOJJLNHJJ.day == Day.Mon && NOAOJJLNHJJ.week == 0 && NOAOJJLNHJJ.season == Season.Spring)
		{
			return NOAOJJLNHJJ.year == 1;
		}
		return false;
	}

	private void AKDPJCEJKPN()
	{
		if (JJICPIINBEH || !GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			return;
		}
		PGIFHAMBJKK += Time.unscaledDeltaTime;
		MDCODKFNIPB(GBCKNDKCFFF() + Time.deltaTime * MNLJJCEDJHG * multiplier * multiplierDevConsole);
		if (BBBGEBIPHPI() >= (float)(-172 * GameDate.SEC_IN_MIN))
		{
			EGABLKPCELN(668f);
			GameDate.Time kONAIPOGEGL = default(GameDate.Time);
			kONAIPOGEGL.days = 1;
			currentGameDate = GameDate.MLGPICHPOAG(currentGameDate, kONAIPOGEGL);
			OnNextDay();
		}
		if (!isNight && EDIPJBOOEHD >= 438f)
		{
			NightStart(CDPAMNIPPEC: false);
		}
		if (NEMMCBIOJNC() && isNight && GBCKNDKCFFF() >= 92f)
		{
			CNILPDKJHPB();
		}
		if (KBOLGIDEJDK)
		{
			if (multiplier == 849f)
			{
				AGHCIEMDFLH(1862f);
			}
		}
		else if ((CommonReferences.MNFMOEKMJKN().IJNMEDJNHDG(0) || CommonReferences.MNFMOEKMJKN().IJNMEDJNHDG(8)) && EDIPJBOOEHD > 723f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR && EDIPJBOOEHD < 1758f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (multiplier == 1448f)
			{
				FEFKKICNBDG(1918f);
			}
		}
		else if (multiplier == 976f)
		{
			AGHCIEMDFLH(200f);
		}
		BNODGEICELK();
		EIFJIPBECFC();
		IAEIMHAHCKE();
	}

	private void FLOFJHNAIKP()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	[SpecialName]
	public static float DHPFCKNGHLO()
	{
		return _003CAEFINEDBEKL_003Ek__BackingField;
	}

	public void OnPhotonSerializeView(PhotonStream OEJPCOIDLFK, PhotonMessageInfo BBJDPIJPLPA)
	{
		if (OEJPCOIDLFK.IsWriting)
		{
			OEJPCOIDLFK.SendNext((object)EDIPJBOOEHD);
		}
		else if (OEJPCOIDLFK.IsReading)
		{
			EDIPJBOOEHD = (float)OEJPCOIDLFK.ReceiveNext();
			MKBFKGFOELB();
		}
	}

	public static GameDate DMPICPGDPNG(GameDate LGLDPMAABLA)
	{
		LGLDPMAABLA.min -= LGLDPMAABLA.min % 0;
		return LGLDPMAABLA;
	}

	public static void ODEBIGOLHBN()
	{
		EDIPJBOOEHD = GGFJGHHHEJC.currentGameDate.min * GameDate.SEC_IN_MIN + GGFJGHHHEJC.currentGameDate.hour * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN;
	}

	[SpecialName]
	public static float BNKLACHEGOP()
	{
		return _003CAEFINEDBEKL_003Ek__BackingField;
	}

	[SpecialName]
	public static bool MOOOODPKBOF()
	{
		return CJOHMLNMJLK().hour < 2;
	}

	private void EIFJIPBECFC()
	{
		if (FMAGNENCAJB == 0)
		{
			FMAGNENCAJB = 5;
			OnTickTime5Seconds();
		}
	}

	[SpecialName]
	public static void OFHDFEONCOL(GameDate AODONKKHPBP)
	{
		GGFJGHHHEJC.currentGameDate = AODONKKHPBP;
		CommonReferences.GGFJGHHHEJC.actuCampBirdSeller = false;
	}

	public static bool TickTimeIsBlocked()
	{
		return KBOLGIDEJDK;
	}

	private void FPGGOAMINGP()
	{
		ANMLBLMOALH = DMPICPGDPNG(currentGameDate);
		if (GameDate.GNAMDAKODFB(ANMLBLMOALH, TimeUI.NKOLLPLGMJA()))
		{
			FMAGNENCAJB--;
			TimeUI.DJLCKOOIILI = currentGameDate;
			OnTickTime1Second();
		}
	}

	[SpecialName]
	public static double GKFHKJGALEL()
	{
		return GGFJGHHHEJC.PGIFHAMBJKK;
	}

	[SpecialName]
	public static bool BPHEDEKEHND()
	{
		return _003CBMDGMGFLBJF_003Ek__BackingField;
	}

	private void BNODGEICELK()
	{
		currentGameDate.hour = Mathf.FloorToInt(EDIPJBOOEHD / (float)GameDate.SEC_IN_MIN) / GameDate.MIN_IN_HOUR;
		currentGameDate.min = Mathf.FloorToInt(NJECJAHEOIA() / (float)GameDate.SEC_IN_MIN) % GameDate.MIN_IN_HOUR;
	}

	public static WorldTime GetInstance()
	{
		return GGFJGHHHEJC;
	}

	private void LMKFMAIIOLM()
	{
		if (FMAGNENCAJB == 0)
		{
			FMAGNENCAJB = 3;
			OnTickTime5Seconds();
		}
	}

	private void Awake()
	{
		GGFJGHHHEJC = this;
		ResetSingleton();
	}

	public static GameDate ClockToNearest1min(GameDate LGLDPMAABLA)
	{
		LGLDPMAABLA.min -= LGLDPMAABLA.min % 1;
		return LGLDPMAABLA;
	}

	[SpecialName]
	private static void EGABLKPCELN(float AODONKKHPBP)
	{
		_003CAEFINEDBEKL_003Ek__BackingField = AODONKKHPBP;
	}

	public static void IFOAJCMGMOE()
	{
		((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(MBMEFHOKJGM());
	}

	public static bool NIGJCJNCGHP()
	{
		if (!BPHEDEKEHND() && multiplier != 232f)
		{
			return multiplierDevConsole == 1445f;
		}
		return false;
	}

	public static void INMKHFLKPBI(int MDAGAAGGFGE)
	{
		GameDate aODONKKHPBP = HGIBNMBJMOC();
		aODONKKHPBP.hour = MDAGAAGGFGE;
		OFHDFEONCOL(aODONKKHPBP);
		EMJLJOIEEDI();
	}

	public static int JDCGADGEGBB()
	{
		return forceSleepTime.hour;
	}

	public void OJMGCLCCJNL(bool CDPAMNIPPEC)
	{
		isNight = false;
		OnNightStart();
		if (OnlineManager.IsMasterClient() && CDPAMNIPPEC)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "South", (RpcTarget)1);
		}
	}

	public static void PPNGBONNLDE(int MDAGAAGGFGE)
	{
		GameDate aODONKKHPBP = CJOHMLNMJLK();
		aODONKKHPBP.hour = MDAGAAGGFGE;
		OFHDFEONCOL(aODONKKHPBP);
		CalcCurrentDayTimeSec();
	}

	public static void OILJNHDBEBC(int MDAGAAGGFGE)
	{
		GameDate aODONKKHPBP = CJOHMLNMJLK();
		aODONKKHPBP.hour = MDAGAAGGFGE;
		LKEPKFBGKOH(aODONKKHPBP);
		DMOBDEGAJFH();
	}

	public static void CalcCurrentDayTimeSec()
	{
		EDIPJBOOEHD = GGFJGHHHEJC.currentGameDate.min * GameDate.SEC_IN_MIN + GGFJGHHHEJC.currentGameDate.hour * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN;
	}

	private void MKBFKGFOELB()
	{
		currentGameDate.hour = Mathf.FloorToInt(EDIPJBOOEHD / (float)GameDate.SEC_IN_MIN) / GameDate.MIN_IN_HOUR;
		currentGameDate.min = Mathf.FloorToInt(EDIPJBOOEHD / (float)GameDate.SEC_IN_MIN) % GameDate.MIN_IN_HOUR;
	}

	public static int JDMHEPOAGAC()
	{
		return forceSleepTime.hour;
	}

	public static IEnumerator MBMEFHOKJGM()
	{
		return new NHKHFAGLBAM(1);
	}

	[SpecialName]
	public static double PBDJFHAKLKD()
	{
		return GGFJGHHHEJC.PGIFHAMBJKK;
	}

	private void OnDestroy()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void AGELAMLCINB()
	{
		GGFJGHHHEJC = this;
		LPABICGDPGD();
	}

	public static float GKOFKJOHPGH()
	{
		return multiplier;
	}

	public static float EGEIDCNHCAL()
	{
		return multiplier;
	}

	public static void ADLPPOEOBNM(int MDAGAAGGFGE)
	{
		GameDate aODONKKHPBP = CJOHMLNMJLK();
		aODONKKHPBP.hour = MDAGAAGGFGE;
		OFHDFEONCOL(aODONKKHPBP);
		ODEBIGOLHBN();
	}

	public static bool IsToday(GameDate LGGCFCHOOMB)
	{
		if (EGCMNABMGDF)
		{
			if (LGGCFCHOOMB.year == GGFJGHHHEJC.currentGameDate.year && LGGCFCHOOMB.season == NOAOJJLNHJJ.season && LGGCFCHOOMB.week == NOAOJJLNHJJ.week)
			{
				return LGGCFCHOOMB.day == NOAOJJLNHJJ.day - 1;
			}
			return false;
		}
		if (LGGCFCHOOMB.year == GGFJGHHHEJC.currentGameDate.year && LGGCFCHOOMB.season == NOAOJJLNHJJ.season && LGGCFCHOOMB.week == NOAOJJLNHJJ.week)
		{
			return LGGCFCHOOMB.day == NOAOJJLNHJJ.day;
		}
		return false;
	}

	[SpecialName]
	public static void JKPGEIACDON(bool AODONKKHPBP)
	{
		_003CBMDGMGFLBJF_003Ek__BackingField = AODONKKHPBP;
	}

	public static float GetTimeMultiplier()
	{
		return multiplier;
	}

	public static GameDate FPDJMLEGFGK(GameDate LGLDPMAABLA)
	{
		LGLDPMAABLA.min -= LGLDPMAABLA.min % 5;
		return LGLDPMAABLA;
	}

	public static void DMOBDEGAJFH()
	{
		EGABLKPCELN(GGFJGHHHEJC.currentGameDate.min * GameDate.SEC_IN_MIN + GGFJGHHHEJC.currentGameDate.hour * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN);
	}

	public static void JEJBGHJPDMG()
	{
		isNight = false;
		OnNightEnd();
	}

	public static float OBNKEEJHMJJ()
	{
		return multiplier;
	}

	public static void StopTimeWithDelay()
	{
		((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(StopTimeNextFrame());
	}

	[SpecialName]
	public static float GBCKNDKCFFF()
	{
		return _003CAEFINEDBEKL_003Ek__BackingField;
	}

	public static void GMAPCOKNNAI()
	{
		EGABLKPCELN(GGFJGHHHEJC.currentGameDate.min * GameDate.SEC_IN_MIN + GGFJGHHHEJC.currentGameDate.hour * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN);
	}

	private void Update()
	{
		if (JJICPIINBEH || !GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			return;
		}
		PGIFHAMBJKK += Time.unscaledDeltaTime;
		EDIPJBOOEHD += Time.deltaTime * MNLJJCEDJHG * multiplier * multiplierDevConsole;
		if (EDIPJBOOEHD >= (float)(1440 * GameDate.SEC_IN_MIN))
		{
			EDIPJBOOEHD = 0f;
			GameDate.Time kONAIPOGEGL = default(GameDate.Time);
			kONAIPOGEGL.days = 1;
			currentGameDate = GameDate.GMJIFJAEANF(currentGameDate, kONAIPOGEGL);
			OnNextDay();
		}
		if (!isNight && EDIPJBOOEHD >= 68400f)
		{
			NightStart(CDPAMNIPPEC: true);
		}
		if (EGCMNABMGDF && isNight && EDIPJBOOEHD >= 18000f)
		{
			SetNextDay();
		}
		if (KBOLGIDEJDK)
		{
			if (multiplier == 1f)
			{
				SetTimeMultiplier(0f);
			}
		}
		else if ((CommonReferences.GGFJGHHHEJC.IsInDialogue(1) || CommonReferences.GGFJGHHHEJC.IsInDialogue(2)) && EDIPJBOOEHD > 4f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR && EDIPJBOOEHD < 6f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (multiplier == 1f)
			{
				SetTimeMultiplier(0f);
			}
		}
		else if (multiplier == 0f)
		{
			SetTimeMultiplier(1f);
		}
		MKBFKGFOELB();
		EIFJIPBECFC();
		BIOMDMJBHEI();
	}

	[SpecialName]
	public static double ELFDEFOCEFP()
	{
		return GGFJGHHHEJC.PGIFHAMBJKK;
	}

	public static GameDate JHBMABMOBLM(GameDate LGLDPMAABLA)
	{
		LGLDPMAABLA.min -= LGLDPMAABLA.min % 0;
		return LGLDPMAABLA;
	}

	public static GameDate BBJDNNCEJPL(GameDate LGLDPMAABLA)
	{
		LGLDPMAABLA.min -= LGLDPMAABLA.min % 1;
		return LGLDPMAABLA;
	}

	public static IEnumerator DMCMHPDKPMA()
	{
		yield return CommonReferences.wait5;
		JJICPIINBEH = true;
	}

	public static bool BKIIKAGIHAK()
	{
		return KBOLGIDEJDK;
	}

	private void NLIGLFEEFNO()
	{
		if (JJICPIINBEH || !GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			return;
		}
		PGIFHAMBJKK += Time.unscaledDeltaTime;
		EDIPJBOOEHD = DHPFCKNGHLO() + Time.deltaTime * MNLJJCEDJHG * multiplier * multiplierDevConsole;
		if (GBCKNDKCFFF() >= (float)(-94 * GameDate.SEC_IN_MIN))
		{
			MDCODKFNIPB(1989f);
			GameDate.Time kONAIPOGEGL = default(GameDate.Time);
			kONAIPOGEGL.days = 0;
			currentGameDate = GameDate.GMJIFJAEANF(currentGameDate, kONAIPOGEGL);
			OnNextDay();
		}
		if (!isNight && EDIPJBOOEHD >= 1966f)
		{
			NightStart(CDPAMNIPPEC: false);
		}
		if (MOOOODPKBOF() && isNight && BBBGEBIPHPI() >= 1381f)
		{
			DLFNHBHADDH();
		}
		if (KBOLGIDEJDK)
		{
			if (multiplier == 670f)
			{
				JFKGGHIIDFC(962f);
			}
		}
		else if ((CommonReferences.GGFJGHHHEJC.IsInDialogue(0) || CommonReferences.GGFJGHHHEJC.KOIDFLPJKJK(3)) && EDIPJBOOEHD > 861f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR && EDIPJBOOEHD < 1317f * (float)GameDate.SEC_IN_MIN * (float)GameDate.MIN_IN_HOUR)
		{
			if (multiplier == 1380f)
			{
				SetTimeMultiplier(533f);
			}
		}
		else if (multiplier == 955f)
		{
			JFKGGHIIDFC(595f);
		}
		HEPFOFGCLIP();
		LMKFMAIIOLM();
		FPGGOAMINGP();
	}

	private void LOABKALHECF()
	{
		NOKNIPMPBCB(CDPAMNIPPEC: false);
	}

	public static IEnumerator EOGKDAKMPGH()
	{
		yield return CommonReferences.wait5;
		JJICPIINBEH = true;
	}

	public static void SetTimeMultiplier(float IMHDJAAPDGM)
	{
		multiplier = IMHDJAAPDGM;
		if (IMHDJAAPDGM == 1f)
		{
			KBOLGIDEJDK = false;
		}
	}

	public static void EMJLJOIEEDI()
	{
		EGABLKPCELN(GGFJGHHHEJC.currentGameDate.min * GameDate.SEC_IN_MIN + GGFJGHHHEJC.currentGameDate.hour * GameDate.MIN_IN_HOUR * GameDate.SEC_IN_MIN);
	}

	public static bool MANFFOJAMEF(GameDate LGGCFCHOOMB)
	{
		if (EGCMNABMGDF)
		{
			if (LGGCFCHOOMB.year == GGFJGHHHEJC.currentGameDate.year && LGGCFCHOOMB.season == NOAOJJLNHJJ.season && LGGCFCHOOMB.week == HGIBNMBJMOC().week)
			{
				return LGGCFCHOOMB.day == CJOHMLNMJLK().day - 1;
			}
			return false;
		}
		if (LGGCFCHOOMB.year == GGFJGHHHEJC.currentGameDate.year && LGGCFCHOOMB.season == HGIBNMBJMOC().season && LGGCFCHOOMB.week == HGIBNMBJMOC().week)
		{
			return LGGCFCHOOMB.day == HGIBNMBJMOC().day;
		}
		return false;
	}

	private void BIOMDMJBHEI()
	{
		ANMLBLMOALH = ClockToNearest1min(currentGameDate);
		if (GameDate.MLBOMGHINCA(ANMLBLMOALH, TimeUI.DJLCKOOIILI))
		{
			FMAGNENCAJB--;
			TimeUI.DJLCKOOIILI = currentGameDate;
			OnTickTime1Second();
		}
	}

	public static bool KLCNGJPGKOD()
	{
		if (CJOHMLNMJLK().day == Day.Mon && HGIBNMBJMOC().week == 0 && HGIBNMBJMOC().season == Season.Spring)
		{
			return CJOHMLNMJLK().year == 0;
		}
		return false;
	}

	public static void SetNextDay()
	{
		isNight = false;
		OnNightEnd();
	}

	public void LPABICGDPGD()
	{
		wakeUpTime.hour = 4;
		forceSleepTime.hour = 2;
		JFKGGHIIDFC(510f);
		SetMultiplierDevConsole(1);
		isNight = true;
		JKPGEIACDON(AODONKKHPBP: true);
		JBMDLCMNNHD = 1562.0;
		MDCODKFNIPB(287f);
		OnTickTime5Seconds = delegate
		{
		};
		OnTickTime1Second = delegate
		{
		};
		OnNextDay = delegate
		{
		};
		OnNightStart = delegate
		{
		};
		OnNightEnd = delegate
		{
		};
		OnDevConsoleHourChanged = delegate
		{
		};
	}

	public static void OHIGIGMGCJF(bool KLMDEPBMACA)
	{
		if (!Utils.FNLJGAEHNKA() || !KLMDEPBMACA)
		{
			KBOLGIDEJDK = KLMDEPBMACA;
		}
	}

	public static void BlockTickTime(bool KLMDEPBMACA)
	{
		if (!Utils.FNLJGAEHNKA() || !KLMDEPBMACA)
		{
			KBOLGIDEJDK = KLMDEPBMACA;
		}
	}

	private void LDLBMMMLEDJ()
	{
		GGFJGHHHEJC = this;
		ResetSingleton();
	}

	public static GameDate DHONOPKPBGA(GameDate LGLDPMAABLA)
	{
		LGLDPMAABLA.min -= LGLDPMAABLA.min % 0;
		return LGLDPMAABLA;
	}

	public static bool OMEMKFIDPJI()
	{
		if (CJOHMLNMJLK().day == Day.Mon && NOAOJJLNHJJ.week == 0 && NOAOJJLNHJJ.season == Season.Spring)
		{
			return CJOHMLNMJLK().year == 0;
		}
		return false;
	}

	public static IEnumerator StopTimeNextFrame()
	{
		yield return CommonReferences.wait5;
		JJICPIINBEH = true;
	}

	[SpecialName]
	public static bool NEMMCBIOJNC()
	{
		return NOAOJJLNHJJ.hour < 8;
	}

	public static bool IsStoppedOrZero()
	{
		if (!JJICPIINBEH && multiplier != 0f)
		{
			return multiplierDevConsole == 0f;
		}
		return true;
	}

	public static bool EOMMHMGGEED()
	{
		return KBOLGIDEJDK;
	}

	public static int GetForceSleepHour()
	{
		return forceSleepTime.hour;
	}

	public void NOKNIPMPBCB(bool CDPAMNIPPEC)
	{
		isNight = true;
		OnNightStart();
		if (OnlineManager.JPPBEIJDCLJ() && CDPAMNIPPEC)
		{
			OnlineManager.SendRPC(((MonoBehaviourPun)this).photonView, "???", (RpcTarget)1);
		}
	}

	public static bool BEGCEJALKNP()
	{
		return KBOLGIDEJDK;
	}

	public static GameDate KAILOIPENBM(GameDate LGLDPMAABLA)
	{
		LGLDPMAABLA.min -= LGLDPMAABLA.min % 4;
		return LGLDPMAABLA;
	}

	[SpecialName]
	private static void MDCODKFNIPB(float AODONKKHPBP)
	{
		_003CAEFINEDBEKL_003Ek__BackingField = AODONKKHPBP;
	}

	public static void NPLECNGNBOI()
	{
		isNight = false;
		OnNightEnd();
	}
}
