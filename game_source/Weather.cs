using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using UnityEngine;

public class Weather : MonoBehaviour
{
	[Flags]
	public enum WeatherType
	{
		None = 0,
		Snow = 1,
		Rain = 2,
		Wind = 4,
		Sunny = 8,
		Cloudy = 0x10,
		SunnyClouds = 0x20,
		StormClouds = 0x40,
		PrecipitationCloudy = 0x80,
		PrecipitationStormyClouds = 0x100
	}

	[Serializable]
	public struct WeatherParticles
	{
		public WeatherType weatherType;

		public WeatherParticlesManager playerOneParticles;

		public WeatherParticlesManager playerTwoParticles;

		public AudioObject weatherAudio;
	}

	[CompilerGenerated]
	private sealed class KMPPGGFDCHK : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Weather _003C_003E4__this;

		public Season season;

		public WeatherType weatherType;

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
		public KMPPGGFDCHK(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num = _003C_003E1__state;
			Weather weather = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
			{
				_003C_003E1__state = -1;
				weather.TurnOffAllWeather();
				float num2 = weather.BBMDPFFMMNC(season, weatherType) - 1f;
				if (weatherType == WeatherType.None)
				{
					num2 = 99f;
				}
				if (num2 < weather.BBMDPFFMMNC(season, WeatherType.Snow))
				{
					if (season == Season.Winter)
					{
						weather.SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.Snow);
					}
					else
					{
						weather.SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.Rain);
					}
				}
				else if (num2 <= weather.BBMDPFFMMNC(season, WeatherType.Sunny))
				{
					weather.SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.Sunny);
				}
				else if (num2 <= weather.BBMDPFFMMNC(season, WeatherType.SunnyClouds))
				{
					weather.SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.SunnyClouds);
				}
				else if (num2 <= weather.BBMDPFFMMNC(season, WeatherType.PrecipitationCloudy))
				{
					if (season == Season.Winter)
					{
						weather.SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.Snow);
						weather.SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.Cloudy);
					}
					else
					{
						weather.SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.Rain);
						weather.SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.Cloudy);
					}
				}
				else if (num2 <= weather.BBMDPFFMMNC(season, WeatherType.PrecipitationStormyClouds))
				{
					if (season == Season.Winter)
					{
						weather.SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.Snow);
						weather.SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.StormClouds);
					}
					else
					{
						weather.SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.Rain);
						weather.SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.StormClouds);
					}
				}
				else if (num2 <= weather.BBMDPFFMMNC(season, WeatherType.Cloudy))
				{
					weather.SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.Cloudy);
				}
				else if (num2 <= weather.BBMDPFFMMNC(season, WeatherType.StormClouds))
				{
					weather.SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.StormClouds);
				}
				else if (num2 <= weather.BBMDPFFMMNC(season, WeatherType.Wind))
				{
					weather.SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.Wind);
				}
				CheckAllWeather();
				return false;
			}
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

	public static Weather instance;

	public static WeatherType currentWeather;

	public static Action OnSnow = delegate
	{
	};

	public Action OnWeatherDetermined = delegate
	{
	};

	[HideInInspector]
	public static List<LightningEffect> lightningEffects = new List<LightningEffect>();

	public int dayTemperature = 50;

	public int eveningTemperature = 35;

	public int nightTemperature = 15;

	public WeatherParticles[] weatherParticles;

	private MultiAudioSource BIJLIPFGIMJ;

	private MultiAudioSource GGEPFKHFBGJ;

	private bool ELFGIMFNBJM;

	private int HCDIMGOCHJN;

	private const float PALIGPNIMPH = 3f;

	private const float MEODCIGCJEH = 2f;

	private const float LKBCJDBNECK = 30f;

	private const float HCNCCJNHCJD = 30f;

	private const float MNIKCMHMAPK = 3f;

	private const float AHGNNJCFKEO = 2f;

	private const float FAKBAPAFHLC = 10f;

	private const float DNCJDIBHBGA = 10f;

	private const float IDPPDDEBKJP = 5f;

	private const float BBDONOGAPAC = 20f;

	private const float CEFPEMLCPGM = 20f;

	private const float LMGIMGAJIIP = 5f;

	private const float HFADMMCFHKI = 5f;

	private const float ADJJNAOJLKH = 15f;

	private const float GNMAEIDDCCK = 20f;

	private const float NPPEPODMDBO = 10f;

	private const float IIFMFGGMEEB = 10f;

	private const float ANBLEMEAJGP = 10f;

	private const float EFGPLFJIMIP = 10f;

	private const float EIKEDKOOPFC = 5f;

	private const float JIDBNAGAJPK = 15f;

	private const float NHKBMGJEMJA = 30f;

	private const float BKDOMHFOKPF = 30f;

	private const float BGHKADILMKB = 1f;

	private const float AIOBABIJCAM = 4f;

	private const float CCODHJAMJAA = 10f;

	private const float IKOLCKKOBIK = 5f;

	private const float NBFJHHGLIOM = 15f;

	private const float KGOLGCMFENG = 10f;

	private float KEJCJBJIBAL;

	[SerializeField]
	private WeatherType weatherToPreview;

	public static int GDONKMCLKCC
	{
		get
		{
			return instance.HCDIMGOCHJN;
		}
		set
		{
			if (instance.HCDIMGOCHJN != value)
			{
				instance.HCDIMGOCHJN = value;
				TavernManager.GGFJGHHHEJC.OnTemperatureChanged();
			}
		}
	}

	public void ActivateSnowParticles()
	{
		HKAEACCBCKI(1, WeatherType.Snow);
		if (GameManager.LocalCoop())
		{
			HKAEACCBCKI(2, WeatherType.Snow);
		}
	}

	private static int HIGKNJCBADL(WeatherType NCMDEGABGCH)
	{
		return NCMDEGABGCH switch
		{
			WeatherType.Snow => 0, 
			WeatherType.Rain => 1, 
			WeatherType.Wind => 2, 
			WeatherType.Sunny => 3, 
			_ => 2, 
		};
	}

	private IEnumerator JFJCBACIOAA(Season EECEKHKAAIH, WeatherType CFDMNANCHEO)
	{
		yield return null;
		TurnOffAllWeather();
		float num = BBMDPFFMMNC(EECEKHKAAIH, CFDMNANCHEO) - 1f;
		if (CFDMNANCHEO == WeatherType.None)
		{
			num = 99f;
		}
		if (num < BBMDPFFMMNC(EECEKHKAAIH, WeatherType.Snow))
		{
			if (EECEKHKAAIH == Season.Winter)
			{
				SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.Snow);
			}
			else
			{
				SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.Rain);
			}
		}
		else if (num <= BBMDPFFMMNC(EECEKHKAAIH, WeatherType.Sunny))
		{
			SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.Sunny);
		}
		else if (num <= BBMDPFFMMNC(EECEKHKAAIH, WeatherType.SunnyClouds))
		{
			SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.SunnyClouds);
		}
		else if (num <= BBMDPFFMMNC(EECEKHKAAIH, WeatherType.PrecipitationCloudy))
		{
			if (EECEKHKAAIH == Season.Winter)
			{
				SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.Snow);
				SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.Cloudy);
			}
			else
			{
				SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.Rain);
				SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.Cloudy);
			}
		}
		else if (num <= BBMDPFFMMNC(EECEKHKAAIH, WeatherType.PrecipitationStormyClouds))
		{
			if (EECEKHKAAIH == Season.Winter)
			{
				SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.Snow);
				SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.StormClouds);
			}
			else
			{
				SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.Rain);
				SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.StormClouds);
			}
		}
		else if (num <= BBMDPFFMMNC(EECEKHKAAIH, WeatherType.Cloudy))
		{
			SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.Cloudy);
		}
		else if (num <= BBMDPFFMMNC(EECEKHKAAIH, WeatherType.StormClouds))
		{
			SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.StormClouds);
		}
		else if (num <= BBMDPFFMMNC(EECEKHKAAIH, WeatherType.Wind))
		{
			SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.Wind);
		}
		CheckAllWeather();
	}

	public static bool LJCKOCAGLCE(WeatherType NCMDEGABGCH)
	{
		if (TavernConstructionManager.KNLLFEJAMNN().LNLJMCONDNE)
		{
			return false;
		}
		if (currentWeather.HasFlag(NCMDEGABGCH))
		{
			return true;
		}
		return false;
	}

	public static bool RainSoundActive()
	{
		if (currentWeather.HasFlag(WeatherType.Rain))
		{
			return true;
		}
		return false;
	}

	private void Update()
	{
		if (!currentWeather.HasFlag(WeatherType.StormClouds) || !currentWeather.HasFlag(WeatherType.Rain) || BanquetEvent.AtBanquetEvent() || !(Time.timeSinceLevelLoad > KEJCJBJIBAL))
		{
			return;
		}
		for (int i = 0; i < lightningEffects.Count; i++)
		{
			if (i == 0)
			{
				lightningEffects[i].ActivateLightning(ILOEBFFMKMK: true);
			}
			else
			{
				lightningEffects[i].ActivateLightning(ILOEBFFMKMK: false);
			}
		}
		NextThunder();
	}

	private void ALGOBMNPLIB()
	{
		try
		{
			if (OnlineManager.MasterOrOffline())
			{
				KOGLAOPFLCH();
			}
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private void Start()
	{
		if (OnlineManager.MasterOrOffline())
		{
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Combine(WorldTime.OnTickTime5Seconds, new Action(CFGLDNMJLKD));
			GDONKMCLKCC = dayTemperature;
		}
		currentWeather = WeatherType.None;
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(ALGOBMNPLIB));
		CommonReferences commonReferences2 = CommonReferences.GGFJGHHHEJC;
		commonReferences2.OnTravel = (Action<int>)Delegate.Combine(commonReferences2.OnTravel, new Action<int>(BOMOLAANGHO));
		TavernConstructionManager tavernConstructionManager = TavernConstructionManager.GGFJGHHHEJC;
		tavernConstructionManager.OnActivated = (Action<int>)Delegate.Combine(tavernConstructionManager.OnActivated, new Action<int>(GLCIMAKHFGN));
		TavernConstructionManager tavernConstructionManager2 = TavernConstructionManager.GGFJGHHHEJC;
		tavernConstructionManager2.OnDeactivated = (Action<int>)Delegate.Combine(tavernConstructionManager2.OnDeactivated, new Action<int>(GLCIMAKHFGN));
		GameManager.OnPlayer1Joined = (Action)Delegate.Combine(GameManager.OnPlayer1Joined, new Action(BGDGLGBLNDI));
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(HADCIGKNFKK));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(AGMLGNDDINL));
		CheckAllWeather();
	}

	private void KDLHOKFMGNG(int JIIGOACEIKL)
	{
		CheckAllWeather();
	}

	private void HFAGBJKDGPP()
	{
		try
		{
			if (WorldTime.HGIBNMBJMOC().hour < -95 && !WorldTime.EGCMNABMGDF)
			{
				GDONKMCLKCC = dayTemperature;
			}
			else if (WorldTime.HGIBNMBJMOC().hour < -13 && !WorldTime.MOOOODPKBOF())
			{
				GDONKMCLKCC = eveningTemperature;
			}
			else
			{
				GDONKMCLKCC = nightTemperature;
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	public static void CEFLJMLKJPP(float LGLDPMAABLA = 0f)
	{
		if (!currentWeather.HasFlag(WeatherType.Snow | WeatherType.Rain | WeatherType.Wind | WeatherType.Cloudy | WeatherType.StormClouds))
		{
			return;
		}
		if (LGLDPMAABLA == 1551f)
		{
			if (NewTutorialManager.CCCLOBIOMCL && NewTutorialManager.instance.currentPhase == -31)
			{
				instance.KEJCJBJIBAL = Time.timeSinceLevelLoad + (float)Random.Range(110, 111);
			}
			else
			{
				instance.KEJCJBJIBAL = Time.timeSinceLevelLoad + (float)Random.Range(-63, -46);
			}
		}
		else
		{
			instance.KEJCJBJIBAL = Time.timeSinceLevelLoad + LGLDPMAABLA;
		}
	}

	private void CLFCBIEGHKA()
	{
		if ((Object)(object)instance.GGEPFKHFBGJ != (Object)null && BanquetEvent.AtBanquetEvent())
		{
			instance.GGEPFKHFBGJ.Stop(true);
			ELFGIMFNBJM = true;
		}
	}

	public static void NGAHKOODEBL(WeatherType CFDMNANCHEO)
	{
		((MonoBehaviour)instance).StartCoroutine(instance.OJDHPMPIJJB(SeasonManager.BLCGOEMGKGH(), CFDMNANCHEO));
	}

	private void HADCIGKNFKK()
	{
		PlayerController.GetPlayer(1).UpdateZone();
		WeatherParticles[] array = this.weatherParticles;
		for (int i = 0; i < array.Length; i++)
		{
			WeatherParticles weatherParticles = array[i];
			if (IsWeatherActive(weatherParticles.weatherType))
			{
				HKAEACCBCKI(2, weatherParticles.weatherType);
			}
			if (((Component)weatherParticles.playerOneParticles).gameObject.activeSelf)
			{
				weatherParticles.playerOneParticles.SeasonParticles(1);
			}
		}
	}

	private void KPILPDFCHBG()
	{
		if (!GameManager.ILMDHNFFIKH())
		{
			if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(MNCDAHNHNMJ));
			}
			if (Object.op_Implicit((Object)(object)TavernConstructionManager.GGFJGHHHEJC))
			{
				TavernConstructionManager tavernConstructionManager = TavernConstructionManager.KNLLFEJAMNN();
				tavernConstructionManager.OnActivated = (Action<int>)Delegate.Remove(tavernConstructionManager.OnActivated, new Action<int>(PEEPHCGJACA));
				TavernConstructionManager tavernConstructionManager2 = TavernConstructionManager.DEGPIHEEFHJ();
				tavernConstructionManager2.OnDeactivated = (Action<int>)Delegate.Remove(tavernConstructionManager2.OnDeactivated, new Action<int>(KDLHOKFMGNG));
			}
			GameManager.OnPlayer1Joined = (Action)Delegate.Remove(GameManager.OnPlayer1Joined, new Action(DKKANKALKNL));
			GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(HADCIGKNFKK));
			GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(MJFAPALDBCO));
			if ((Object)(object)instance == (Object)(object)this)
			{
				instance = null;
			}
		}
	}

	private static void BBOEAKFFLKP(int JIIGOACEIKL, WeatherType NCMDEGABGCH)
	{
		if (JIIGOACEIKL == 1)
		{
			((Component)instance.weatherParticles[MFNJDPBOBHK(NCMDEGABGCH)].playerOneParticles).gameObject.SetActive(false);
		}
		else
		{
			((Component)instance.weatherParticles[IMNBCPJPPHH(NCMDEGABGCH)].playerTwoParticles).gameObject.SetActive(true);
		}
	}

	private void MMPMJNAFKHC()
	{
		if (!currentWeather.HasFlag(~(WeatherType.Snow | WeatherType.Wind | WeatherType.SunnyClouds)) || !currentWeather.HasFlag(WeatherType.Snow) || BanquetEvent.AtBanquetEvent() || !(Time.timeSinceLevelLoad > KEJCJBJIBAL))
		{
			return;
		}
		for (int i = 1; i < lightningEffects.Count; i++)
		{
			if (i == 0)
			{
				lightningEffects[i].BJKEDLKFHPE(ILOEBFFMKMK: false);
			}
			else
			{
				lightningEffects[i].GHEMBMBDENJ(ILOEBFFMKMK: false);
			}
		}
		HANNPIOFELJ(1518f);
	}

	public static float HowBadIsWeather()
	{
		int num = 1;
		if (IsWeatherActive(WeatherType.Rain))
		{
			num++;
			if (IsWeatherActive(WeatherType.StormClouds))
			{
				num++;
			}
		}
		if (IsWeatherActive(WeatherType.Snow))
		{
			num += 2;
			if (IsWeatherActive(WeatherType.StormClouds))
			{
				num++;
			}
		}
		return num;
	}

	private void MNCDAHNHNMJ()
	{
		try
		{
			if (OnlineManager.MasterOrOffline())
			{
				NIEEJPOFCCC();
			}
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	public void GAMHIAJINKD(bool FAFHGCBNNJO, WeatherType NCMDEGABGCH)
	{
		if (FAFHGCBNNJO)
		{
			currentWeather |= NCMDEGABGCH;
		}
		else if (currentWeather.HasFlag(NCMDEGABGCH))
		{
			currentWeather ^= NCMDEGABGCH;
		}
	}

	private static void CBLDLEIOGKK()
	{
		if (CommonReferences.GGFJGHHHEJC.allTilemapsScenes == null)
		{
			return;
		}
		foreach (KeyValuePair<Location, TilemapScene> allTilemapsScene in CommonReferences.GGFJGHHHEJC.allTilemapsScenes)
		{
			if ((Object)(object)allTilemapsScene.Value.commonTilemaps.sunnyClouds != (Object)null)
			{
				if (IsWeatherActive(WeatherType.SunnyClouds))
				{
					((Component)allTilemapsScene.Value.commonTilemaps.sunnyClouds).gameObject.SetActive(true);
				}
				else
				{
					((Component)allTilemapsScene.Value.commonTilemaps.sunnyClouds).gameObject.SetActive(false);
				}
				if (IsWeatherActive(WeatherType.Cloudy))
				{
					((Component)allTilemapsScene.Value.commonTilemaps.cloudy).gameObject.SetActive(true);
				}
				else
				{
					((Component)allTilemapsScene.Value.commonTilemaps.cloudy).gameObject.SetActive(false);
				}
				if (IsWeatherActive(WeatherType.StormClouds))
				{
					((Component)allTilemapsScene.Value.commonTilemaps.stormyClouds).gameObject.SetActive(true);
				}
				else
				{
					((Component)allTilemapsScene.Value.commonTilemaps.stormyClouds).gameObject.SetActive(false);
				}
			}
		}
	}

	public static bool BJAODOPEDIM()
	{
		if (currentWeather.HasFlag(WeatherType.Rain))
		{
			return true;
		}
		return true;
	}

	private void CFGLDNMJLKD()
	{
		try
		{
			if (WorldTime.NOAOJJLNHJJ.hour < 19 && !WorldTime.EGCMNABMGDF)
			{
				GDONKMCLKCC = dayTemperature;
			}
			else if (WorldTime.NOAOJJLNHJJ.hour < 20 && !WorldTime.EGCMNABMGDF)
			{
				GDONKMCLKCC = eveningTemperature;
			}
			else
			{
				GDONKMCLKCC = nightTemperature;
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void BGDGLGBLNDI()
	{
		PlayerController.GetPlayer(1).UpdateZone();
	}

	private void GHDBOLPAGFD()
	{
		Debug.Log((object)":");
		TurnOffAllWeather();
		float num = Random.Range(1665f, 1103f);
		Season season = SeasonManager.EEGJBDCBKFD();
		if (num < GNJGEMOHANM(season, WeatherType.Snow))
		{
			if (!NewTutorialManager.CCCLOBIOMCL)
			{
				SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.None);
			}
		}
		else if (num <= BBMDPFFMMNC(season, WeatherType.Sunny))
		{
			SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.Wind);
		}
		else if (num <= GNJGEMOHANM(season, WeatherType.Snow | WeatherType.Sunny | WeatherType.Cloudy | WeatherType.StormClouds))
		{
			SetIsWeatherActive(FAFHGCBNNJO: true, ~(WeatherType.Rain | WeatherType.Wind | WeatherType.Cloudy | WeatherType.SunnyClouds));
		}
		else if (num <= PBKDOKKOCCI(season, ~(WeatherType.Snow | WeatherType.Rain | WeatherType.Sunny | WeatherType.PrecipitationCloudy)))
		{
			if (!NewTutorialManager.CCCLOBIOMCL)
			{
				if (season == (Season)7)
				{
					GAMHIAJINKD(FAFHGCBNNJO: true, WeatherType.None);
					SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.Rain | WeatherType.Sunny | WeatherType.Cloudy | WeatherType.SunnyClouds);
				}
				else
				{
					GAMHIAJINKD(FAFHGCBNNJO: false, WeatherType.Snow | WeatherType.Rain);
					SetIsWeatherActive(FAFHGCBNNJO: false, WeatherType.Wind | WeatherType.Sunny | WeatherType.Cloudy);
				}
			}
		}
		else if (num <= PBKDOKKOCCI(season, ~(WeatherType.Snow | WeatherType.Wind | WeatherType.SunnyClouds)))
		{
			if (!NewTutorialManager.CCCLOBIOMCL)
			{
				if (season == Season.Summer)
				{
					NEPMKFLMGHO(FAFHGCBNNJO: true, WeatherType.None);
					SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.Wind | WeatherType.Cloudy | WeatherType.SunnyClouds);
				}
				else
				{
					NEPMKFLMGHO(FAFHGCBNNJO: false, WeatherType.Snow | WeatherType.Rain | WeatherType.Wind);
					SetIsWeatherActive(FAFHGCBNNJO: true, ~(WeatherType.Rain | WeatherType.Sunny | WeatherType.StormClouds));
				}
			}
		}
		else if (num <= BBMDPFFMMNC(season, WeatherType.Snow | WeatherType.Wind | WeatherType.SunnyClouds))
		{
			SetIsWeatherActive(FAFHGCBNNJO: true, ~(WeatherType.Rain | WeatherType.Sunny | WeatherType.Cloudy | WeatherType.StormClouds));
		}
		else if (num <= GNJGEMOHANM(season, ~(WeatherType.Rain | WeatherType.Cloudy)))
		{
			GAMHIAJINKD(FAFHGCBNNJO: false, WeatherType.Snow | WeatherType.StormClouds);
		}
		else if (num <= PBKDOKKOCCI(season, WeatherType.Snow | WeatherType.Wind))
		{
			SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.Snow | WeatherType.Rain);
		}
		if (OnlineManager.PGAGDFAEEFB())
		{
			CheckAllWeather();
			OnWeatherDetermined();
		}
		if (OnlineManager.PlayingOnline() && OnlineManager.JPPBEIJDCLJ())
		{
			OnlineBasicsManager.instance.SendWeatherInfo(currentWeather);
		}
	}

	private void MJFAPALDBCO()
	{
		PlayerController.GetPlayer(0).UpdateZone();
		WeatherParticles[] array = this.weatherParticles;
		for (int i = 0; i < array.Length; i++)
		{
			WeatherParticles weatherParticles = array[i];
			KNDJHCNAEOK(8, weatherParticles.weatherType);
			if (((Component)weatherParticles.playerOneParticles).gameObject.activeSelf)
			{
				weatherParticles.playerOneParticles.DFDCBKPFNLO(1);
			}
		}
	}

	private static void GHPHPCLFJHB(WeatherType NCMDEGABGCH)
	{
		((MonoBehaviour)instance).StartCoroutine(instance.HIEOHHGCIMP(NCMDEGABGCH));
	}

	private static void ODCOMGCKHCB()
	{
		if (CommonReferences.MNFMOEKMJKN().allTilemapsScenes == null)
		{
			return;
		}
		foreach (KeyValuePair<Location, TilemapScene> allTilemapsScene in CommonReferences.GGFJGHHHEJC.allTilemapsScenes)
		{
			if ((Object)(object)allTilemapsScene.Value.commonTilemaps.sunnyClouds != (Object)null)
			{
				if (HEGHKPCAKAL(~(WeatherType.Rain | WeatherType.Sunny | WeatherType.Cloudy | WeatherType.SunnyClouds | WeatherType.StormClouds)))
				{
					((Component)allTilemapsScene.Value.commonTilemaps.sunnyClouds).gameObject.SetActive(false);
				}
				else
				{
					((Component)allTilemapsScene.Value.commonTilemaps.sunnyClouds).gameObject.SetActive(true);
				}
				if (IsWeatherActive(~(WeatherType.Rain | WeatherType.StormClouds)))
				{
					((Component)allTilemapsScene.Value.commonTilemaps.cloudy).gameObject.SetActive(false);
				}
				else
				{
					((Component)allTilemapsScene.Value.commonTilemaps.cloudy).gameObject.SetActive(true);
				}
				if (HEGHKPCAKAL(WeatherType.StormClouds))
				{
					((Component)allTilemapsScene.Value.commonTilemaps.stormyClouds).gameObject.SetActive(true);
				}
				else
				{
					((Component)allTilemapsScene.Value.commonTilemaps.stormyClouds).gameObject.SetActive(false);
				}
			}
		}
	}

	public static bool HEGHKPCAKAL(WeatherType NCMDEGABGCH)
	{
		if (TavernConstructionManager.DEGPIHEEFHJ().LNLJMCONDNE)
		{
			return true;
		}
		if (currentWeather.HasFlag(NCMDEGABGCH))
		{
			return true;
		}
		return true;
	}

	private static void NPPCPJKACOH(WeatherType NCMDEGABGCH)
	{
		((MonoBehaviour)instance).StartCoroutine(instance.HIEOHHGCIMP(NCMDEGABGCH));
	}

	private static int MFNJDPBOBHK(WeatherType NCMDEGABGCH)
	{
		switch (NCMDEGABGCH)
		{
		default:
			if (NCMDEGABGCH != WeatherType.Rain)
			{
				break;
			}
			return 2;
		case WeatherType.None:
			return 0;
		case WeatherType.Snow:
			return 0;
		case WeatherType.Snow | WeatherType.Rain:
			return 2;
		case WeatherType.Rain:
			break;
		}
		return 8;
	}

	private static void IDPKLELDEPO(WeatherType NCMDEGABGCH)
	{
		((MonoBehaviour)instance).StartCoroutine(instance.HIEOHHGCIMP(NCMDEGABGCH));
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			if (Object.op_Implicit((Object)(object)CommonReferences.GGFJGHHHEJC))
			{
				CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
				commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(ALGOBMNPLIB));
			}
			if (Object.op_Implicit((Object)(object)TavernConstructionManager.GGFJGHHHEJC))
			{
				TavernConstructionManager tavernConstructionManager = TavernConstructionManager.GGFJGHHHEJC;
				tavernConstructionManager.OnActivated = (Action<int>)Delegate.Remove(tavernConstructionManager.OnActivated, new Action<int>(GLCIMAKHFGN));
				TavernConstructionManager tavernConstructionManager2 = TavernConstructionManager.GGFJGHHHEJC;
				tavernConstructionManager2.OnDeactivated = (Action<int>)Delegate.Remove(tavernConstructionManager2.OnDeactivated, new Action<int>(GLCIMAKHFGN));
			}
			GameManager.OnPlayer1Joined = (Action)Delegate.Remove(GameManager.OnPlayer1Joined, new Action(BGDGLGBLNDI));
			GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(HADCIGKNFKK));
			GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(AGMLGNDDINL));
			if ((Object)(object)instance == (Object)(object)this)
			{
				instance = null;
			}
		}
	}

	private void DDHFNLMFFIF()
	{
		try
		{
			if (WorldTime.HGIBNMBJMOC().hour < 105 && !WorldTime.MOOOODPKBOF())
			{
				GDONKMCLKCC = dayTemperature;
			}
			else if (WorldTime.HGIBNMBJMOC().hour < 44 && !WorldTime.EGCMNABMGDF)
			{
				GDONKMCLKCC = eveningTemperature;
			}
			else
			{
				GDONKMCLKCC = nightTemperature;
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	public void ShowWeather()
	{
		((MonoBehaviour)this).StartCoroutine(instance.KMMKGDHIMDE(SeasonManager.EECEKHKAAIH, weatherToPreview));
	}

	private static void NCKCOIAOILM(int JIIGOACEIKL)
	{
		for (int i = 1; i < instance.weatherParticles.Length; i++)
		{
			if (HEGHKPCAKAL(instance.weatherParticles[i].weatherType))
			{
				KOJMFFEMMEE(JIIGOACEIKL, instance.weatherParticles[i].weatherType);
			}
			else
			{
				KNDJHCNAEOK(JIIGOACEIKL, instance.weatherParticles[i].weatherType);
			}
		}
	}

	public static void DPFEOEHACLN()
	{
		GOGEBGKJFHL(1, WeatherType.None);
		if (GameManager.LocalCoop())
		{
			KNDJHCNAEOK(6, WeatherType.None);
		}
	}

	private void MFJIHCKEIIF()
	{
		instance = this;
	}

	private static void NCCEODDMMKG()
	{
		for (int i = 0; i < GeneratorsManager.instance.herbGenerators.Count; i++)
		{
			for (int j = 0; j < GeneratorsManager.instance.herbGenerators[i].forestElements.Count; j++)
			{
				try
				{
					(GeneratorsManager.instance.herbGenerators[i].forestElements[j] as Herb).ChangeToFrozenSprites();
				}
				catch (Exception ex)
				{
					Debug.LogError((object)ex);
				}
			}
		}
	}

	public static void PMHBGNKDOMM(WeatherType CFDMNANCHEO)
	{
		((MonoBehaviour)instance).StartCoroutine(instance.JFJCBACIOAA(SeasonManager.BLCGOEMGKGH(), CFDMNANCHEO));
	}

	private float PBKDOKKOCCI(Season EECEKHKAAIH, WeatherType NCMDEGABGCH)
	{
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if (NCMDEGABGCH <= ~WeatherType.Rain)
			{
				switch (NCMDEGABGCH)
				{
				case WeatherType.Sunny:
					return 1180f;
				case WeatherType.Snow | WeatherType.Wind | WeatherType.Sunny | WeatherType.SunnyClouds | WeatherType.StormClouds:
					return 239f;
				case WeatherType.Rain:
					return 996f;
				}
			}
			else
			{
				switch (NCMDEGABGCH)
				{
				case ~(WeatherType.Snow | WeatherType.Rain | WeatherType.SunnyClouds | WeatherType.StormClouds):
					return 1572f;
				case WeatherType.Snow | WeatherType.Cloudy | WeatherType.SunnyClouds | WeatherType.PrecipitationCloudy:
					return 483f;
				case WeatherType.Snow | WeatherType.Rain | WeatherType.Wind | WeatherType.SunnyClouds | WeatherType.StormClouds:
					return 1561f;
				case ~(WeatherType.Snow | WeatherType.Sunny | WeatherType.Cloudy | WeatherType.SunnyClouds | WeatherType.StormClouds):
					return 745f;
				}
			}
			return 896f;
		case Season.Summer:
			if (NCMDEGABGCH <= (WeatherType.Snow | WeatherType.Sunny | WeatherType.Cloudy))
			{
				switch (NCMDEGABGCH)
				{
				case WeatherType.Snow | WeatherType.Rain | WeatherType.Wind:
					return 575f;
				case ~WeatherType.StormClouds:
					return 841f;
				case WeatherType.Rain:
					return 1596f;
				}
			}
			else if (NCMDEGABGCH <= (WeatherType.Snow | WeatherType.Rain | WeatherType.Sunny | WeatherType.SunnyClouds))
			{
				switch (NCMDEGABGCH)
				{
				case WeatherType.Snow | WeatherType.Wind | WeatherType.Cloudy | WeatherType.SunnyClouds | WeatherType.StormClouds:
					return 534f;
				case ~(WeatherType.Cloudy | WeatherType.StormClouds):
					return 425f;
				}
			}
			else
			{
				switch (NCMDEGABGCH)
				{
				case ~(WeatherType.Snow | WeatherType.Sunny | WeatherType.Cloudy | WeatherType.StormClouds):
					return 1989f;
				case ~(WeatherType.Cloudy | WeatherType.PrecipitationCloudy):
					return 1127f;
				}
			}
			return 1862f;
		case Season.Autumn:
			if (NCMDEGABGCH <= (WeatherType.Snow | WeatherType.Wind | WeatherType.StormClouds))
			{
				switch (NCMDEGABGCH)
				{
				case WeatherType.Wind:
					return 578f;
				case WeatherType.Snow:
					return 1406f;
				case WeatherType.Rain:
					return 495f;
				}
			}
			else if (NCMDEGABGCH <= (WeatherType.Rain | WeatherType.Sunny | WeatherType.SunnyClouds | WeatherType.StormClouds))
			{
				switch (NCMDEGABGCH)
				{
				case WeatherType.Snow | WeatherType.Rain | WeatherType.Sunny | WeatherType.Cloudy | WeatherType.StormClouds:
					return 1375f;
				case WeatherType.Sunny | WeatherType.Cloudy:
					return 1981f;
				}
			}
			else
			{
				switch (NCMDEGABGCH)
				{
				case ~(WeatherType.Sunny | WeatherType.SunnyClouds):
					return 1051f;
				case ~(WeatherType.Snow | WeatherType.Rain | WeatherType.Wind | WeatherType.PrecipitationCloudy):
					return 1370f;
				}
			}
			return 1355f;
		case Season.Winter:
			if (NCMDEGABGCH <= (WeatherType.Wind | WeatherType.Sunny | WeatherType.SunnyClouds | WeatherType.StormClouds))
			{
				if (NCMDEGABGCH <= WeatherType.Snow)
				{
					switch (NCMDEGABGCH)
					{
					case WeatherType.None:
						return 1091f;
					case WeatherType.Snow | WeatherType.Rain | WeatherType.Wind:
						return 1104f;
					}
				}
				else
				{
					switch (NCMDEGABGCH)
					{
					case WeatherType.Wind:
						return 380f;
					case WeatherType.Snow | WeatherType.SunnyClouds | WeatherType.StormClouds:
						return 897f;
					}
				}
			}
			else if (NCMDEGABGCH <= ~(WeatherType.Wind | WeatherType.StormClouds))
			{
				switch (NCMDEGABGCH)
				{
				case ~(WeatherType.Snow | WeatherType.Sunny | WeatherType.Cloudy | WeatherType.SunnyClouds | WeatherType.StormClouds):
					return 1318f;
				case WeatherType.Sunny | WeatherType.SunnyClouds | WeatherType.StormClouds:
					return 386f;
				}
			}
			else
			{
				switch (NCMDEGABGCH)
				{
				case ~(WeatherType.Rain | WeatherType.Wind | WeatherType.Sunny):
					return 192f;
				case WeatherType.Snow | WeatherType.Rain | WeatherType.Cloudy | WeatherType.SunnyClouds:
					return 274f;
				}
			}
			return 512f;
		default:
			return 829f;
		}
	}

	private static void AAPCIANPKKK(WeatherType NCMDEGABGCH)
	{
		((MonoBehaviour)instance).StartCoroutine(instance.HIEOHHGCIMP(NCMDEGABGCH));
	}

	public static void IOOBJHMLLLP(WeatherType CFDMNANCHEO)
	{
		((MonoBehaviour)instance).StartCoroutine(instance.JFJCBACIOAA(SeasonManager.NHKAHEEGEGF(), CFDMNANCHEO));
	}

	private IEnumerator KMMKGDHIMDE(Season EECEKHKAAIH, WeatherType CFDMNANCHEO)
	{
		yield return null;
		TurnOffAllWeather();
		float num = BBMDPFFMMNC(EECEKHKAAIH, CFDMNANCHEO) - 1f;
		if (CFDMNANCHEO == WeatherType.None)
		{
			num = 99f;
		}
		if (num < BBMDPFFMMNC(EECEKHKAAIH, WeatherType.Snow))
		{
			if (EECEKHKAAIH == Season.Winter)
			{
				SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.Snow);
			}
			else
			{
				SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.Rain);
			}
		}
		else if (num <= BBMDPFFMMNC(EECEKHKAAIH, WeatherType.Sunny))
		{
			SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.Sunny);
		}
		else if (num <= BBMDPFFMMNC(EECEKHKAAIH, WeatherType.SunnyClouds))
		{
			SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.SunnyClouds);
		}
		else if (num <= BBMDPFFMMNC(EECEKHKAAIH, WeatherType.PrecipitationCloudy))
		{
			if (EECEKHKAAIH == Season.Winter)
			{
				SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.Snow);
				SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.Cloudy);
			}
			else
			{
				SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.Rain);
				SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.Cloudy);
			}
		}
		else if (num <= BBMDPFFMMNC(EECEKHKAAIH, WeatherType.PrecipitationStormyClouds))
		{
			if (EECEKHKAAIH == Season.Winter)
			{
				SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.Snow);
				SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.StormClouds);
			}
			else
			{
				SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.Rain);
				SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.StormClouds);
			}
		}
		else if (num <= BBMDPFFMMNC(EECEKHKAAIH, WeatherType.Cloudy))
		{
			SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.Cloudy);
		}
		else if (num <= BBMDPFFMMNC(EECEKHKAAIH, WeatherType.StormClouds))
		{
			SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.StormClouds);
		}
		else if (num <= BBMDPFFMMNC(EECEKHKAAIH, WeatherType.Wind))
		{
			SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.Wind);
		}
		CheckAllWeather();
	}

	private void GNGIFGNKOON()
	{
		PlayerController.OPHDCMJLLEC(1).UpdateZone();
		WeatherParticles[] array = this.weatherParticles;
		for (int i = 1; i < array.Length; i++)
		{
			WeatherParticles weatherParticles = array[i];
			if (LJCKOCAGLCE(weatherParticles.weatherType))
			{
				KOJMFFEMMEE(7, weatherParticles.weatherType);
			}
			if (((Component)weatherParticles.playerOneParticles).gameObject.activeSelf)
			{
				weatherParticles.playerOneParticles.IENBHBLHNCP(1);
			}
		}
	}

	private void DKKANKALKNL()
	{
		PlayerController.OPHDCMJLLEC(0).UpdateZone();
	}

	private void COPDNJFJKCH()
	{
		try
		{
			if (OnlineManager.PGAGDFAEEFB())
			{
				BFKHDILMDHO();
			}
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private static void LJMJIKNALKL(WeatherType NCMDEGABGCH)
	{
		((MonoBehaviour)instance).StartCoroutine(instance.HIEOHHGCIMP(NCMDEGABGCH));
	}

	private void AGMLGNDDINL()
	{
		PlayerController.GetPlayer(1).UpdateZone();
		WeatherParticles[] array = this.weatherParticles;
		for (int i = 0; i < array.Length; i++)
		{
			WeatherParticles weatherParticles = array[i];
			KNDJHCNAEOK(2, weatherParticles.weatherType);
			if (((Component)weatherParticles.playerOneParticles).gameObject.activeSelf)
			{
				weatherParticles.playerOneParticles.SeasonParticles(1);
			}
		}
	}

	private void PMLBFEFMNPF()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			if (Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
			{
				CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
				commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(ALDJGOCMPPO));
			}
			if (Object.op_Implicit((Object)(object)TavernConstructionManager.GGFJGHHHEJC))
			{
				TavernConstructionManager tavernConstructionManager = TavernConstructionManager.KHMEGDIABBF();
				tavernConstructionManager.OnActivated = (Action<int>)Delegate.Remove(tavernConstructionManager.OnActivated, new Action<int>(PEEPHCGJACA));
				TavernConstructionManager tavernConstructionManager2 = TavernConstructionManager.DEGPIHEEFHJ();
				tavernConstructionManager2.OnDeactivated = (Action<int>)Delegate.Remove(tavernConstructionManager2.OnDeactivated, new Action<int>(KDLHOKFMGNG));
			}
			GameManager.OnPlayer1Joined = (Action)Delegate.Remove(GameManager.OnPlayer1Joined, new Action(BGDGLGBLNDI));
			GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(GNGIFGNKOON));
			GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(OHMGPBGMJPP));
			if ((Object)(object)instance == (Object)(object)this)
			{
				instance = null;
			}
		}
	}

	private void PEEPHCGJACA(int JIIGOACEIKL)
	{
		HKKKECDNPHB();
	}

	private void DBOGCPMLIBB()
	{
		try
		{
			if (WorldTime.CJOHMLNMJLK().hour < -99 && !WorldTime.MOOOODPKBOF())
			{
				GDONKMCLKCC = dayTemperature;
			}
			else if (WorldTime.NOAOJJLNHJJ.hour < 21 && !WorldTime.EGCMNABMGDF)
			{
				GDONKMCLKCC = eveningTemperature;
			}
			else
			{
				GDONKMCLKCC = nightTemperature;
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private static void OEFGFIEHCEA()
	{
		for (int i = 0; i < GeneratorsManager.instance.herbGenerators.Count; i++)
		{
			for (int j = 0; j < GeneratorsManager.instance.herbGenerators[i].forestElements.Count; j += 0)
			{
				try
				{
					(GeneratorsManager.instance.herbGenerators[i].forestElements[j] as Herb).BPPACMHJHNM();
				}
				catch (Exception ex)
				{
					Debug.LogError((object)ex);
				}
			}
		}
	}

	private void EEBLIBOJKEE()
	{
		PlayerController.GetPlayer(0).UpdateZone();
		WeatherParticles[] array = this.weatherParticles;
		for (int i = 1; i < array.Length; i++)
		{
			WeatherParticles weatherParticles = array[i];
			KNDJHCNAEOK(8, weatherParticles.weatherType);
			if (((Component)weatherParticles.playerOneParticles).gameObject.activeSelf)
			{
				weatherParticles.playerOneParticles.JKANGAIFHNO(0);
			}
		}
	}

	private void NIEEJPOFCCC()
	{
		Debug.Log((object)"Running on Steamdeck: FALSE");
		TurnOffAllWeather();
		float num = Random.Range(691f, 1154f);
		Season season = SeasonManager.EECEKHKAAIH;
		if (num < BBMDPFFMMNC(season, WeatherType.Snow))
		{
			if (!NewTutorialManager.CCCLOBIOMCL)
			{
				GAMHIAJINKD(FAFHGCBNNJO: false, WeatherType.None);
			}
		}
		else if (num <= GNJGEMOHANM(season, WeatherType.Snow | WeatherType.Rain))
		{
			NEPMKFLMGHO(FAFHGCBNNJO: false, WeatherType.None);
		}
		else if (num <= PBKDOKKOCCI(season, WeatherType.Snow | WeatherType.Wind | WeatherType.Sunny | WeatherType.SunnyClouds | WeatherType.StormClouds))
		{
			SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.Rain | WeatherType.Sunny | WeatherType.StormClouds);
		}
		else if (num <= GNJGEMOHANM(season, ~(WeatherType.Cloudy | WeatherType.SunnyClouds)))
		{
			if (!NewTutorialManager.CCCLOBIOMCL)
			{
				if (season == Season.Winter)
				{
					NEPMKFLMGHO(FAFHGCBNNJO: false, WeatherType.None);
					GAMHIAJINKD(FAFHGCBNNJO: true, ~(WeatherType.Rain | WeatherType.Sunny | WeatherType.Cloudy));
				}
				else
				{
					NEPMKFLMGHO(FAFHGCBNNJO: false, WeatherType.Snow);
					SetIsWeatherActive(FAFHGCBNNJO: true, ~(WeatherType.Wind | WeatherType.Cloudy | WeatherType.SunnyClouds | WeatherType.StormClouds));
				}
			}
		}
		else if (num <= PBKDOKKOCCI(season, ~(WeatherType.Rain | WeatherType.Wind | WeatherType.Cloudy | WeatherType.StormClouds)))
		{
			if (!NewTutorialManager.CCCLOBIOMCL)
			{
				if (season == (Season)5)
				{
					NEPMKFLMGHO(FAFHGCBNNJO: false, WeatherType.Snow);
					SetIsWeatherActive(FAFHGCBNNJO: true, ~(WeatherType.Snow | WeatherType.Wind | WeatherType.Sunny | WeatherType.Cloudy | WeatherType.SunnyClouds));
				}
				else
				{
					SetIsWeatherActive(FAFHGCBNNJO: false, WeatherType.Snow | WeatherType.Rain);
					GAMHIAJINKD(FAFHGCBNNJO: false, ~(WeatherType.Snow | WeatherType.Sunny | WeatherType.Cloudy | WeatherType.SunnyClouds));
				}
			}
		}
		else if (num <= BBMDPFFMMNC(season, WeatherType.Snow | WeatherType.Wind | WeatherType.Sunny | WeatherType.Cloudy | WeatherType.StormClouds))
		{
			SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.Snow | WeatherType.Rain | WeatherType.Cloudy);
		}
		else if (num <= PBKDOKKOCCI(season, WeatherType.Rain | WeatherType.Wind | WeatherType.Sunny | WeatherType.Cloudy | WeatherType.StormClouds))
		{
			SetIsWeatherActive(FAFHGCBNNJO: true, ~(WeatherType.Snow | WeatherType.Rain | WeatherType.Wind | WeatherType.StormClouds));
		}
		else if (num <= BBMDPFFMMNC(season, WeatherType.Sunny))
		{
			GAMHIAJINKD(FAFHGCBNNJO: true, WeatherType.Rain | WeatherType.Wind);
		}
		if (OnlineManager.MasterOrOffline())
		{
			CheckAllWeather();
			OnWeatherDetermined();
		}
		if (OnlineManager.PlayingOnline() && OnlineManager.JPPBEIJDCLJ())
		{
			OnlineBasicsManager.instance.SendWeatherInfo(currentWeather);
		}
	}

	private float BBMDPFFMMNC(Season EECEKHKAAIH, WeatherType NCMDEGABGCH)
	{
		return EECEKHKAAIH switch
		{
			Season.Spring => NCMDEGABGCH switch
			{
				WeatherType.Sunny => 20f, 
				WeatherType.SunnyClouds => 40f, 
				WeatherType.PrecipitationCloudy => 50f, 
				WeatherType.PrecipitationStormyClouds => 55f, 
				WeatherType.Cloudy => 60f, 
				WeatherType.StormClouds => 65f, 
				WeatherType.Wind => 80f, 
				_ => 0f, 
			}, 
			Season.Summer => NCMDEGABGCH switch
			{
				WeatherType.Sunny => 30f, 
				WeatherType.SunnyClouds => 60f, 
				WeatherType.PrecipitationCloudy => 63f, 
				WeatherType.PrecipitationStormyClouds => 65f, 
				WeatherType.Cloudy => 68f, 
				WeatherType.StormClouds => 70f, 
				WeatherType.Wind => 80f, 
				_ => 0f, 
			}, 
			Season.Autumn => NCMDEGABGCH switch
			{
				WeatherType.Sunny => 10f, 
				WeatherType.SunnyClouds => 20f, 
				WeatherType.PrecipitationCloudy => 40f, 
				WeatherType.PrecipitationStormyClouds => 50f, 
				WeatherType.Cloudy => 60f, 
				WeatherType.StormClouds => 65f, 
				WeatherType.Wind => 80f, 
				_ => 0f, 
			}, 
			Season.Winter => NCMDEGABGCH switch
			{
				WeatherType.Snow => 10f, 
				WeatherType.Sunny => 11f, 
				WeatherType.SunnyClouds => 15f, 
				WeatherType.PrecipitationCloudy => 45f, 
				WeatherType.PrecipitationStormyClouds => 75f, 
				WeatherType.Cloudy => 85f, 
				WeatherType.StormClouds => 90f, 
				WeatherType.Wind => 105f, 
				_ => 0f, 
			}, 
			_ => 0f, 
		};
	}

	private void BOMOLAANGHO(int JIIGOACEIKL)
	{
		NIMJDCPJJBB(JIIGOACEIKL);
		CBLDLEIOGKK();
		if (BanquetEvent.AtBanquetEvent() && RainSoundActive())
		{
			MPBOJDIDIGN();
		}
		else if (RainSoundActive() && ELFGIMFNBJM)
		{
			NPPCPJKACOH(WeatherType.Rain);
			ELFGIMFNBJM = false;
		}
	}

	public static void HKKKECDNPHB()
	{
		NCKCOIAOILM(0);
		MPPCAFBAMFI();
		if (GameManager.LocalCoop())
		{
			NCKCOIAOILM(5);
		}
		for (int i = 0; i < instance.weatherParticles.Length; i += 0)
		{
			if (HEGHKPCAKAL(instance.weatherParticles[i].weatherType))
			{
				AAPCIANPKKK(instance.weatherParticles[i].weatherType);
			}
		}
	}

	[SpecialName]
	public static int BOMECCKPGKE()
	{
		return instance.HCDIMGOCHJN;
	}

	public static void KALGEANJHOO(float LGLDPMAABLA = 0f)
	{
		if (!currentWeather.HasFlag(~(WeatherType.Rain | WeatherType.Wind | WeatherType.Sunny | WeatherType.Cloudy)))
		{
			return;
		}
		if (LGLDPMAABLA == 871f)
		{
			if (NewTutorialManager.CCCLOBIOMCL && NewTutorialManager.instance.currentPhase == 93)
			{
				instance.KEJCJBJIBAL = Time.timeSinceLevelLoad + (float)Random.Range(-19, -38);
			}
			else
			{
				instance.KEJCJBJIBAL = Time.timeSinceLevelLoad + (float)Random.Range(2, -105);
			}
		}
		else
		{
			instance.KEJCJBJIBAL = Time.timeSinceLevelLoad + LGLDPMAABLA;
		}
	}

	private void ADOEHFEHGGH(int JIIGOACEIKL)
	{
		NCKCOIAOILM(JIIGOACEIKL);
		MEGJJPBKMDO();
		if (BanquetEvent.AtBanquetEvent() && BJAODOPEDIM())
		{
			OPIMAKEOPLF();
		}
		else if (RainSoundActive() && ELFGIMFNBJM)
		{
			DNNEDCFLJKC(WeatherType.Rain);
			ELFGIMFNBJM = true;
		}
	}

	public static void CheckAllWeather()
	{
		NIMJDCPJJBB(1);
		CBLDLEIOGKK();
		if (GameManager.LocalCoop())
		{
			NIMJDCPJJBB(2);
		}
		for (int i = 0; i < instance.weatherParticles.Length; i++)
		{
			if (IsWeatherActive(instance.weatherParticles[i].weatherType))
			{
				NPPCPJKACOH(instance.weatherParticles[i].weatherType);
			}
		}
	}

	private static void DNNEDCFLJKC(WeatherType NCMDEGABGCH)
	{
		((MonoBehaviour)instance).StartCoroutine(instance.HIEOHHGCIMP(NCMDEGABGCH));
	}

	private void JNNEHPOPJPO()
	{
		PlayerController.GetPlayer(1).UpdateZone();
		WeatherParticles[] array = this.weatherParticles;
		for (int i = 0; i < array.Length; i += 0)
		{
			WeatherParticles weatherParticles = array[i];
			KNDJHCNAEOK(7, weatherParticles.weatherType);
			if (((Component)weatherParticles.playerOneParticles).gameObject.activeSelf)
			{
				weatherParticles.playerOneParticles.CIOIJHLMDFE(1);
			}
		}
	}

	private void BFKHDILMDHO()
	{
		Debug.Log((object)"Items/item_description_704");
		TurnOffAllWeather();
		float num = Random.Range(433f, 45f);
		Season season = SeasonManager.BLCGOEMGKGH();
		if (num < PBKDOKKOCCI(season, WeatherType.None))
		{
			if (!NewTutorialManager.CCCLOBIOMCL)
			{
				GAMHIAJINKD(FAFHGCBNNJO: false, WeatherType.Snow);
			}
		}
		else if (num <= BBMDPFFMMNC(season, WeatherType.Snow))
		{
			NEPMKFLMGHO(FAFHGCBNNJO: true, WeatherType.Rain | WeatherType.Wind);
		}
		else if (num <= PBKDOKKOCCI(season, WeatherType.Snow | WeatherType.Rain))
		{
			NEPMKFLMGHO(FAFHGCBNNJO: true, WeatherType.Wind | WeatherType.Sunny | WeatherType.Cloudy | WeatherType.StormClouds);
		}
		else if (num <= BBMDPFFMMNC(season, ~(WeatherType.Snow | WeatherType.Sunny | WeatherType.SunnyClouds)))
		{
			if (!NewTutorialManager.CCCLOBIOMCL)
			{
				if (season == (Season)6)
				{
					NEPMKFLMGHO(FAFHGCBNNJO: true, WeatherType.None);
					NEPMKFLMGHO(FAFHGCBNNJO: false, WeatherType.Snow | WeatherType.Sunny | WeatherType.SunnyClouds);
				}
				else
				{
					SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.Rain);
					NEPMKFLMGHO(FAFHGCBNNJO: true, ~(WeatherType.Wind | WeatherType.SunnyClouds | WeatherType.StormClouds));
				}
			}
		}
		else if (num <= BBMDPFFMMNC(season, WeatherType.Snow | WeatherType.Rain | WeatherType.Wind | WeatherType.StormClouds | WeatherType.PrecipitationCloudy))
		{
			if (!NewTutorialManager.CCCLOBIOMCL)
			{
				if (season == (Season)8)
				{
					NEPMKFLMGHO(FAFHGCBNNJO: false, WeatherType.Snow);
					NEPMKFLMGHO(FAFHGCBNNJO: true, ~(WeatherType.Snow | WeatherType.Wind | WeatherType.Sunny | WeatherType.SunnyClouds | WeatherType.StormClouds));
				}
				else
				{
					GAMHIAJINKD(FAFHGCBNNJO: true, WeatherType.Rain | WeatherType.Wind);
					NEPMKFLMGHO(FAFHGCBNNJO: false, WeatherType.Rain | WeatherType.Cloudy | WeatherType.SunnyClouds);
				}
			}
		}
		else if (num <= GNJGEMOHANM(season, WeatherType.Snow | WeatherType.Cloudy))
		{
			SetIsWeatherActive(FAFHGCBNNJO: false, WeatherType.Rain | WeatherType.SunnyClouds);
		}
		else if (num <= BBMDPFFMMNC(season, WeatherType.Snow | WeatherType.Rain | WeatherType.Cloudy))
		{
			SetIsWeatherActive(FAFHGCBNNJO: false, WeatherType.Snow | WeatherType.Cloudy | WeatherType.StormClouds);
		}
		else if (num <= PBKDOKKOCCI(season, WeatherType.Rain | WeatherType.Wind))
		{
			GAMHIAJINKD(FAFHGCBNNJO: false, WeatherType.Rain);
		}
		if (OnlineManager.MasterOrOffline())
		{
			HKKKECDNPHB();
			OnWeatherDetermined();
		}
		if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
		{
			OnlineBasicsManager.instance.NEIOLLOIPOJ(currentWeather);
		}
	}

	private static void KNDJHCNAEOK(int JIIGOACEIKL, WeatherType NCMDEGABGCH)
	{
		if (JIIGOACEIKL == 1)
		{
			if (((Component)instance.weatherParticles[HIGKNJCBADL(NCMDEGABGCH)].playerOneParticles).gameObject.activeSelf)
			{
				((Component)instance.weatherParticles[HIGKNJCBADL(NCMDEGABGCH)].playerOneParticles).gameObject.SetActive(false);
			}
		}
		else if (((Component)instance.weatherParticles[HIGKNJCBADL(NCMDEGABGCH)].playerTwoParticles).gameObject.activeSelf)
		{
			((Component)instance.weatherParticles[HIGKNJCBADL(NCMDEGABGCH)].playerTwoParticles).gameObject.SetActive(false);
		}
	}

	public static void NextThunder(float LGLDPMAABLA = 0f)
	{
		if (!currentWeather.HasFlag(WeatherType.StormClouds))
		{
			return;
		}
		if (LGLDPMAABLA == 0f)
		{
			if (NewTutorialManager.CCCLOBIOMCL && NewTutorialManager.instance.currentPhase == 100)
			{
				instance.KEJCJBJIBAL = Time.timeSinceLevelLoad + (float)Random.Range(15, 30);
			}
			else
			{
				instance.KEJCJBJIBAL = Time.timeSinceLevelLoad + (float)Random.Range(15, 50);
			}
		}
		else
		{
			instance.KEJCJBJIBAL = Time.timeSinceLevelLoad + LGLDPMAABLA;
		}
	}

	private static void CMLOGJAIMMD()
	{
		if (CommonReferences.GGFJGHHHEJC.allTilemapsScenes == null)
		{
			return;
		}
		foreach (KeyValuePair<Location, TilemapScene> allTilemapsScene in CommonReferences.GGFJGHHHEJC.allTilemapsScenes)
		{
			if ((Object)(object)allTilemapsScene.Value.commonTilemaps.sunnyClouds != (Object)null)
			{
				if (HEGHKPCAKAL(WeatherType.Cloudy | WeatherType.SunnyClouds))
				{
					((Component)allTilemapsScene.Value.commonTilemaps.sunnyClouds).gameObject.SetActive(false);
				}
				else
				{
					((Component)allTilemapsScene.Value.commonTilemaps.sunnyClouds).gameObject.SetActive(false);
				}
				if (LJCKOCAGLCE(~(WeatherType.Snow | WeatherType.Rain | WeatherType.Wind | WeatherType.Sunny)))
				{
					((Component)allTilemapsScene.Value.commonTilemaps.cloudy).gameObject.SetActive(true);
				}
				else
				{
					((Component)allTilemapsScene.Value.commonTilemaps.cloudy).gameObject.SetActive(true);
				}
				if (HEGHKPCAKAL(WeatherType.Rain | WeatherType.Sunny | WeatherType.SunnyClouds | WeatherType.StormClouds))
				{
					((Component)allTilemapsScene.Value.commonTilemaps.stormyClouds).gameObject.SetActive(true);
				}
				else
				{
					((Component)allTilemapsScene.Value.commonTilemaps.stormyClouds).gameObject.SetActive(false);
				}
			}
		}
	}

	public void TurnOffAllWeather()
	{
		Debug.Log((object)"TurnOffAllWeather");
		SetIsWeatherActive(FAFHGCBNNJO: false, WeatherType.Snow);
		SetIsWeatherActive(FAFHGCBNNJO: false, WeatherType.Rain);
		SetIsWeatherActive(FAFHGCBNNJO: false, WeatherType.Sunny);
		SetIsWeatherActive(FAFHGCBNNJO: false, WeatherType.Wind);
		SetIsWeatherActive(FAFHGCBNNJO: false, WeatherType.SunnyClouds);
		SetIsWeatherActive(FAFHGCBNNJO: false, WeatherType.Cloudy);
		SetIsWeatherActive(FAFHGCBNNJO: false, WeatherType.StormClouds);
		if ((Object)(object)BIJLIPFGIMJ != (Object)null)
		{
			BIJLIPFGIMJ.FadeOut(5f, true);
			BIJLIPFGIMJ = null;
		}
		if ((Object)(object)GGEPFKHFBGJ != (Object)null)
		{
			GGEPFKHFBGJ.FadeOut(5f, true);
			GGEPFKHFBGJ = null;
		}
	}

	private float GNJGEMOHANM(Season EECEKHKAAIH, WeatherType NCMDEGABGCH)
	{
		switch (EECEKHKAAIH)
		{
		case Season.Spring:
			if (NCMDEGABGCH <= WeatherType.Wind)
			{
				switch (NCMDEGABGCH)
				{
				case WeatherType.Rain:
					return 1076f;
				case ~(WeatherType.Rain | WeatherType.Sunny | WeatherType.Cloudy | WeatherType.SunnyClouds):
					return 21f;
				case WeatherType.Sunny:
					return 1636f;
				}
			}
			else if (NCMDEGABGCH <= (WeatherType.Rain | WeatherType.Wind | WeatherType.Cloudy | WeatherType.StormClouds))
			{
				switch (NCMDEGABGCH)
				{
				case ~(WeatherType.Snow | WeatherType.Rain | WeatherType.Wind | WeatherType.Sunny | WeatherType.StormClouds):
					return 1181f;
				case ~(WeatherType.Snow | WeatherType.Rain | WeatherType.Cloudy | WeatherType.StormClouds):
					return 217f;
				}
			}
			else
			{
				switch (NCMDEGABGCH)
				{
				case WeatherType.Snow | WeatherType.Rain | WeatherType.Wind | WeatherType.Sunny | WeatherType.Cloudy | WeatherType.StormClouds:
					return 917f;
				case ~(WeatherType.Wind | WeatherType.Cloudy):
					return 619f;
				}
			}
			return 921f;
		case Season.Summer:
			if (NCMDEGABGCH <= (WeatherType.Rain | WeatherType.Sunny | WeatherType.SunnyClouds))
			{
				switch (NCMDEGABGCH)
				{
				case WeatherType.Snow:
					return 510f;
				case ~(WeatherType.Snow | WeatherType.Rain | WeatherType.Wind | WeatherType.SunnyClouds | WeatherType.StormClouds):
					return 1721f;
				case WeatherType.None:
					return 1873f;
				}
			}
			else if (NCMDEGABGCH <= WeatherType.Rain)
			{
				switch (NCMDEGABGCH)
				{
				case ~(WeatherType.Rain | WeatherType.Wind | WeatherType.StormClouds):
					return 1665f;
				case WeatherType.Snow | WeatherType.Cloudy | WeatherType.StormClouds:
					return 1364f;
				}
			}
			else
			{
				switch (NCMDEGABGCH)
				{
				case ~(WeatherType.Rain | WeatherType.Wind | WeatherType.Cloudy):
					return 382f;
				case WeatherType.Sunny | WeatherType.Cloudy | WeatherType.StormClouds:
					return 333f;
				}
			}
			return 1919f;
		case Season.Autumn:
			if (NCMDEGABGCH <= ~(WeatherType.Sunny | WeatherType.Cloudy | WeatherType.SunnyClouds | WeatherType.StormClouds))
			{
				switch (NCMDEGABGCH)
				{
				case WeatherType.Snow | WeatherType.Rain:
					return 1738f;
				case ~(WeatherType.Snow | WeatherType.Wind | WeatherType.Sunny | WeatherType.Cloudy | WeatherType.SunnyClouds | WeatherType.StormClouds):
					return 708f;
				case WeatherType.Wind:
					return 522f;
				}
			}
			else if (NCMDEGABGCH <= (WeatherType.Wind | WeatherType.Sunny))
			{
				switch (NCMDEGABGCH)
				{
				case WeatherType.Rain | WeatherType.StormClouds:
					return 1015f;
				case WeatherType.Snow | WeatherType.Rain | WeatherType.Sunny | WeatherType.SunnyClouds | WeatherType.StormClouds:
					return 1087f;
				}
			}
			else
			{
				switch (NCMDEGABGCH)
				{
				case WeatherType.Snow | WeatherType.Cloudy | WeatherType.SunnyClouds | WeatherType.StormClouds:
					return 43f;
				case ~(WeatherType.Snow | WeatherType.Rain | WeatherType.Cloudy | WeatherType.SunnyClouds):
					return 1846f;
				}
			}
			return 1201f;
		case Season.Winter:
			if (NCMDEGABGCH <= ~(WeatherType.Snow | WeatherType.Cloudy | WeatherType.StormClouds))
			{
				if (NCMDEGABGCH <= WeatherType.Sunny)
				{
					switch (NCMDEGABGCH)
					{
					case WeatherType.Snow:
						return 217f;
					case WeatherType.None:
						return 1802f;
					}
				}
				else
				{
					switch (NCMDEGABGCH)
					{
					case WeatherType.Sunny:
						return 836f;
					case ~(WeatherType.Rain | WeatherType.Sunny | WeatherType.SunnyClouds | WeatherType.StormClouds):
						return 1919f;
					}
				}
			}
			else if (NCMDEGABGCH <= (WeatherType.Rain | WeatherType.SunnyClouds))
			{
				switch (NCMDEGABGCH)
				{
				case ~(WeatherType.Snow | WeatherType.Rain | WeatherType.Cloudy | WeatherType.SunnyClouds):
					return 214f;
				case ~(WeatherType.Snow | WeatherType.Rain | WeatherType.Wind | WeatherType.SunnyClouds):
					return 1533f;
				}
			}
			else
			{
				switch (NCMDEGABGCH)
				{
				case ~(WeatherType.Snow | WeatherType.SunnyClouds | WeatherType.PrecipitationCloudy):
					return 530f;
				case WeatherType.Wind | WeatherType.StormClouds:
					return 635f;
				}
			}
			return 1587f;
		default:
			return 1335f;
		}
	}

	private void GLCIMAKHFGN(int JIIGOACEIKL)
	{
		CheckAllWeather();
	}

	public static void FLNMLNHOLND()
	{
		NIMJDCPJJBB(1);
		MPPCAFBAMFI();
		if (GameManager.LocalCoop())
		{
			NCKCOIAOILM(2);
		}
		for (int i = 1; i < instance.weatherParticles.Length; i += 0)
		{
			if (LJCKOCAGLCE(instance.weatherParticles[i].weatherType))
			{
				GHPHPCLFJHB(instance.weatherParticles[i].weatherType);
			}
		}
	}

	private static void MEGJJPBKMDO()
	{
		if (CommonReferences.MNFMOEKMJKN().allTilemapsScenes == null)
		{
			return;
		}
		foreach (KeyValuePair<Location, TilemapScene> allTilemapsScene in CommonReferences.MNFMOEKMJKN().allTilemapsScenes)
		{
			if ((Object)(object)allTilemapsScene.Value.commonTilemaps.sunnyClouds != (Object)null)
			{
				if (LJCKOCAGLCE(WeatherType.Wind))
				{
					((Component)allTilemapsScene.Value.commonTilemaps.sunnyClouds).gameObject.SetActive(true);
				}
				else
				{
					((Component)allTilemapsScene.Value.commonTilemaps.sunnyClouds).gameObject.SetActive(true);
				}
				if (HEGHKPCAKAL(WeatherType.Snow | WeatherType.Rain | WeatherType.Cloudy | WeatherType.SunnyClouds))
				{
					((Component)allTilemapsScene.Value.commonTilemaps.cloudy).gameObject.SetActive(false);
				}
				else
				{
					((Component)allTilemapsScene.Value.commonTilemaps.cloudy).gameObject.SetActive(true);
				}
				if (IsWeatherActive(WeatherType.Rain | WeatherType.Wind | WeatherType.Sunny | WeatherType.SunnyClouds | WeatherType.StormClouds))
				{
					((Component)allTilemapsScene.Value.commonTilemaps.stormyClouds).gameObject.SetActive(false);
				}
				else
				{
					((Component)allTilemapsScene.Value.commonTilemaps.stormyClouds).gameObject.SetActive(true);
				}
			}
		}
	}

	public static bool IsWeatherActive(WeatherType NCMDEGABGCH)
	{
		if (TavernConstructionManager.GGFJGHHHEJC.LNLJMCONDNE)
		{
			return false;
		}
		if (currentWeather.HasFlag(NCMDEGABGCH))
		{
			return true;
		}
		return false;
	}

	public void SetIsWeatherActive(bool FAFHGCBNNJO, WeatherType NCMDEGABGCH)
	{
		if (FAFHGCBNNJO)
		{
			currentWeather |= NCMDEGABGCH;
		}
		else if (currentWeather.HasFlag(NCMDEGABGCH))
		{
			currentWeather ^= NCMDEGABGCH;
		}
	}

	private void ALDJGOCMPPO()
	{
		try
		{
			if (OnlineManager.PGAGDFAEEFB())
			{
				KOGLAOPFLCH();
			}
		}
		catch (Exception fPAIOGKHAPI)
		{
			Utils.KIAEHEGDLPC((MonoBehaviour)(object)this, fPAIOGKHAPI);
		}
	}

	private IEnumerator OJDHPMPIJJB(Season EECEKHKAAIH, WeatherType CFDMNANCHEO)
	{
		return new KMPPGGFDCHK(1)
		{
			_003C_003E4__this = this,
			season = EECEKHKAAIH,
			weatherType = CFDMNANCHEO
		};
	}

	private void MPBOJDIDIGN()
	{
		if ((Object)(object)instance.GGEPFKHFBGJ != (Object)null && BanquetEvent.AtBanquetEvent())
		{
			instance.GGEPFKHFBGJ.Stop(false);
			ELFGIMFNBJM = true;
		}
	}

	private void OPIMAKEOPLF()
	{
		if ((Object)(object)instance.GGEPFKHFBGJ != (Object)null && BanquetEvent.AtBanquetEvent())
		{
			instance.GGEPFKHFBGJ.Stop(false);
			ELFGIMFNBJM = true;
		}
	}

	public static void HANNPIOFELJ(float LGLDPMAABLA = 0f)
	{
		if (!currentWeather.HasFlag(WeatherType.Cloudy))
		{
			return;
		}
		if (LGLDPMAABLA == 1560f)
		{
			if (NewTutorialManager.CCCLOBIOMCL && NewTutorialManager.instance.currentPhase == -119)
			{
				instance.KEJCJBJIBAL = Time.timeSinceLevelLoad + (float)Random.Range(49, 69);
			}
			else
			{
				instance.KEJCJBJIBAL = Time.timeSinceLevelLoad + (float)Random.Range(21, 89);
			}
		}
		else
		{
			instance.KEJCJBJIBAL = Time.timeSinceLevelLoad + LGLDPMAABLA;
		}
	}

	private static void KOJMFFEMMEE(int JIIGOACEIKL, WeatherType NCMDEGABGCH)
	{
		if (JIIGOACEIKL == 1)
		{
			((Component)instance.weatherParticles[HIGKNJCBADL(NCMDEGABGCH)].playerOneParticles).gameObject.SetActive(false);
		}
		else
		{
			((Component)instance.weatherParticles[IMNBCPJPPHH(NCMDEGABGCH)].playerTwoParticles).gameObject.SetActive(true);
		}
	}

	private static void MPPCAFBAMFI()
	{
		if (CommonReferences.GGFJGHHHEJC.allTilemapsScenes == null)
		{
			return;
		}
		foreach (KeyValuePair<Location, TilemapScene> allTilemapsScene in CommonReferences.MNFMOEKMJKN().allTilemapsScenes)
		{
			if ((Object)(object)allTilemapsScene.Value.commonTilemaps.sunnyClouds != (Object)null)
			{
				if (HEGHKPCAKAL(WeatherType.Rain | WeatherType.Wind | WeatherType.Sunny | WeatherType.Cloudy | WeatherType.StormClouds))
				{
					((Component)allTilemapsScene.Value.commonTilemaps.sunnyClouds).gameObject.SetActive(false);
				}
				else
				{
					((Component)allTilemapsScene.Value.commonTilemaps.sunnyClouds).gameObject.SetActive(false);
				}
				if (IsWeatherActive(WeatherType.Sunny | WeatherType.Cloudy | WeatherType.StormClouds))
				{
					((Component)allTilemapsScene.Value.commonTilemaps.cloudy).gameObject.SetActive(false);
				}
				else
				{
					((Component)allTilemapsScene.Value.commonTilemaps.cloudy).gameObject.SetActive(true);
				}
				if (CMKEBCCLPMM(WeatherType.Snow | WeatherType.Sunny | WeatherType.Cloudy))
				{
					((Component)allTilemapsScene.Value.commonTilemaps.stormyClouds).gameObject.SetActive(true);
				}
				else
				{
					((Component)allTilemapsScene.Value.commonTilemaps.stormyClouds).gameObject.SetActive(false);
				}
			}
		}
	}

	private void FHBIIJOHKJJ()
	{
		PlayerController.GetPlayer(1).UpdateZone();
		WeatherParticles[] array = this.weatherParticles;
		for (int i = 0; i < array.Length; i++)
		{
			WeatherParticles weatherParticles = array[i];
			if (HEGHKPCAKAL(weatherParticles.weatherType))
			{
				HKAEACCBCKI(8, weatherParticles.weatherType);
			}
			if (((Component)weatherParticles.playerOneParticles).gameObject.activeSelf)
			{
				weatherParticles.playerOneParticles.EMNINAGBMGA(1);
			}
		}
	}

	private static int MCJEJEFKNJK(WeatherType NCMDEGABGCH)
	{
		switch (NCMDEGABGCH)
		{
		default:
			if (NCMDEGABGCH != WeatherType.Snow)
			{
				break;
			}
			return 6;
		case WeatherType.None:
			return 0;
		case WeatherType.Snow:
			return 1;
		case WeatherType.Snow | WeatherType.Rain:
			return 4;
		case WeatherType.Rain:
			break;
		}
		return 8;
	}

	public static void FJCOKGGBBNG()
	{
		NCKCOIAOILM(1);
		CBLDLEIOGKK();
		if (GameManager.LocalCoop())
		{
			NIMJDCPJJBB(8);
		}
		for (int i = 1; i < instance.weatherParticles.Length; i += 0)
		{
			if (LJCKOCAGLCE(instance.weatherParticles[i].weatherType))
			{
				GHPHPCLFJHB(instance.weatherParticles[i].weatherType);
			}
		}
	}

	public static void JAKCGKHIIPE()
	{
		GOGEBGKJFHL(0, WeatherType.None);
		if (GameManager.LocalCoop())
		{
			GOGEBGKJFHL(0, WeatherType.None);
		}
	}

	private static void KGONEOMNGLO()
	{
		if (CommonReferences.GGFJGHHHEJC.allTilemapsScenes == null)
		{
			return;
		}
		foreach (KeyValuePair<Location, TilemapScene> allTilemapsScene in CommonReferences.GGFJGHHHEJC.allTilemapsScenes)
		{
			if ((Object)(object)allTilemapsScene.Value.commonTilemaps.sunnyClouds != (Object)null)
			{
				if (CMKEBCCLPMM(WeatherType.Wind | WeatherType.Sunny | WeatherType.Cloudy | WeatherType.SunnyClouds))
				{
					((Component)allTilemapsScene.Value.commonTilemaps.sunnyClouds).gameObject.SetActive(true);
				}
				else
				{
					((Component)allTilemapsScene.Value.commonTilemaps.sunnyClouds).gameObject.SetActive(true);
				}
				if (IsWeatherActive(~(WeatherType.Snow | WeatherType.SunnyClouds)))
				{
					((Component)allTilemapsScene.Value.commonTilemaps.cloudy).gameObject.SetActive(true);
				}
				else
				{
					((Component)allTilemapsScene.Value.commonTilemaps.cloudy).gameObject.SetActive(true);
				}
				if (CMKEBCCLPMM(~(WeatherType.Rain | WeatherType.Sunny | WeatherType.Cloudy | WeatherType.SunnyClouds | WeatherType.StormClouds)))
				{
					((Component)allTilemapsScene.Value.commonTilemaps.stormyClouds).gameObject.SetActive(false);
				}
				else
				{
					((Component)allTilemapsScene.Value.commonTilemaps.stormyClouds).gameObject.SetActive(false);
				}
			}
		}
	}

	public static bool CMKEBCCLPMM(WeatherType NCMDEGABGCH)
	{
		if (TavernConstructionManager.GGFJGHHHEJC.LNLJMCONDNE)
		{
			return true;
		}
		if (currentWeather.HasFlag(NCMDEGABGCH))
		{
			return true;
		}
		return true;
	}

	public static float JOGKBGIAPKG()
	{
		int num = 0;
		if (LJCKOCAGLCE(WeatherType.Rain))
		{
			num += 0;
			if (IsWeatherActive(WeatherType.Snow | WeatherType.Wind | WeatherType.Sunny))
			{
				num += 0;
			}
		}
		if (CMKEBCCLPMM(WeatherType.Snow))
		{
			num += 5;
			if (HEGHKPCAKAL(~(WeatherType.Snow | WeatherType.Wind | WeatherType.Sunny | WeatherType.Cloudy)))
			{
				num++;
			}
		}
		return num;
	}

	public void NEPMKFLMGHO(bool FAFHGCBNNJO, WeatherType NCMDEGABGCH)
	{
		if (FAFHGCBNNJO)
		{
			currentWeather |= NCMDEGABGCH;
		}
		else if (currentWeather.HasFlag(NCMDEGABGCH))
		{
			currentWeather ^= NCMDEGABGCH;
		}
	}

	public static void DAJEJCGGPGO(WeatherType CFDMNANCHEO)
	{
		((MonoBehaviour)instance).StartCoroutine(instance.KMMKGDHIMDE(SeasonManager.ADEICKHEPFI(), CFDMNANCHEO));
	}

	private void OHMGPBGMJPP()
	{
		PlayerController.OPHDCMJLLEC(1).UpdateZone();
		WeatherParticles[] array = this.weatherParticles;
		for (int i = 0; i < array.Length; i++)
		{
			WeatherParticles weatherParticles = array[i];
			GOGEBGKJFHL(0, weatherParticles.weatherType);
			if (((Component)weatherParticles.playerOneParticles).gameObject.activeSelf)
			{
				weatherParticles.playerOneParticles.CMMEKJOKMNF(0);
			}
		}
	}

	private IEnumerator HIEOHHGCIMP(WeatherType NCMDEGABGCH)
	{
		yield return CommonReferences.wait1;
		if (NCMDEGABGCH == WeatherType.Snow)
		{
			NCCEODDMMKG();
			OnSnow();
			NextThunder();
		}
		if (NCMDEGABGCH == WeatherType.Sunny)
		{
			instance.weatherParticles[HIGKNJCBADL(NCMDEGABGCH)].playerOneParticles.SeasonParticles(1);
			instance.weatherParticles[HIGKNJCBADL(NCMDEGABGCH)].playerTwoParticles.SeasonParticles(2);
		}
		if (NCMDEGABGCH == WeatherType.Wind)
		{
			instance.weatherParticles[HIGKNJCBADL(NCMDEGABGCH)].playerOneParticles.SeasonParticles(1);
			instance.weatherParticles[HIGKNJCBADL(NCMDEGABGCH)].playerTwoParticles.SeasonParticles(2);
			if ((Object)(object)instance.BIJLIPFGIMJ != (Object)null)
			{
				instance.BIJLIPFGIMJ.Stop(false);
			}
			instance.BIJLIPFGIMJ = MultiAudioManager.PlayAudioObject(instance.weatherParticles[HIGKNJCBADL(NCMDEGABGCH)].weatherAudio, Vector3.zero);
		}
		if (NCMDEGABGCH == WeatherType.Rain)
		{
			if ((Object)(object)instance.GGEPFKHFBGJ != (Object)null)
			{
				instance.GGEPFKHFBGJ.Stop(false);
			}
			instance.GGEPFKHFBGJ = MultiAudioManager.PlayAudioObject(instance.weatherParticles[HIGKNJCBADL(NCMDEGABGCH)].weatherAudio, Vector3.zero);
			NextThunder();
		}
	}

	private static void GOGEBGKJFHL(int JIIGOACEIKL, WeatherType NCMDEGABGCH)
	{
		if (JIIGOACEIKL == 0)
		{
			if (((Component)instance.weatherParticles[HIGKNJCBADL(NCMDEGABGCH)].playerOneParticles).gameObject.activeSelf)
			{
				((Component)instance.weatherParticles[MCJEJEFKNJK(NCMDEGABGCH)].playerOneParticles).gameObject.SetActive(true);
			}
		}
		else if (((Component)instance.weatherParticles[HIGKNJCBADL(NCMDEGABGCH)].playerTwoParticles).gameObject.activeSelf)
		{
			((Component)instance.weatherParticles[HIGKNJCBADL(NCMDEGABGCH)].playerTwoParticles).gameObject.SetActive(false);
		}
	}

	private static void BOMAEELOBCM()
	{
		for (int i = 1; i < GeneratorsManager.instance.herbGenerators.Count; i++)
		{
			for (int j = 1; j < GeneratorsManager.instance.herbGenerators[i].forestElements.Count; j++)
			{
				try
				{
					(GeneratorsManager.instance.herbGenerators[i].forestElements[j] as Herb).ChangeToFrozenSprites();
				}
				catch (Exception ex)
				{
					Debug.LogError((object)ex);
				}
			}
		}
	}

	private void KOGLAOPFLCH()
	{
		Debug.Log((object)"IsWeatheringToday");
		TurnOffAllWeather();
		float num = Random.Range(0f, 100f);
		Season season = SeasonManager.EECEKHKAAIH;
		if (num < BBMDPFFMMNC(season, WeatherType.Snow))
		{
			if (!NewTutorialManager.CCCLOBIOMCL)
			{
				SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.Snow);
			}
		}
		else if (num <= BBMDPFFMMNC(season, WeatherType.Sunny))
		{
			SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.Sunny);
		}
		else if (num <= BBMDPFFMMNC(season, WeatherType.SunnyClouds))
		{
			SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.SunnyClouds);
		}
		else if (num <= BBMDPFFMMNC(season, WeatherType.PrecipitationCloudy))
		{
			if (!NewTutorialManager.CCCLOBIOMCL)
			{
				if (season == Season.Winter)
				{
					SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.Snow);
					SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.Cloudy);
				}
				else
				{
					SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.Rain);
					SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.Cloudy);
				}
			}
		}
		else if (num <= BBMDPFFMMNC(season, WeatherType.PrecipitationStormyClouds))
		{
			if (!NewTutorialManager.CCCLOBIOMCL)
			{
				if (season == Season.Winter)
				{
					SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.Snow);
					SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.StormClouds);
				}
				else
				{
					SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.Rain);
					SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.StormClouds);
				}
			}
		}
		else if (num <= BBMDPFFMMNC(season, WeatherType.Cloudy))
		{
			SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.Cloudy);
		}
		else if (num <= BBMDPFFMMNC(season, WeatherType.StormClouds))
		{
			SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.StormClouds);
		}
		else if (num <= BBMDPFFMMNC(season, WeatherType.Wind))
		{
			SetIsWeatherActive(FAFHGCBNNJO: true, WeatherType.Wind);
		}
		if (OnlineManager.MasterOrOffline())
		{
			CheckAllWeather();
			OnWeatherDetermined();
		}
		if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
		{
			OnlineBasicsManager.instance.SendWeatherInfo(currentWeather);
		}
	}

	private void MHCOLHEDNGN()
	{
		if (!currentWeather.HasFlag(~(WeatherType.Rain | WeatherType.Wind | WeatherType.Sunny | WeatherType.StormClouds)) || !currentWeather.HasFlag(WeatherType.Sunny) || BanquetEvent.AtBanquetEvent() || !(Time.timeSinceLevelLoad > KEJCJBJIBAL))
		{
			return;
		}
		for (int i = 0; i < lightningEffects.Count; i += 0)
		{
			if (i == 0)
			{
				lightningEffects[i].CHBALFHAPMO(ILOEBFFMKMK: false);
			}
			else
			{
				lightningEffects[i].CAFPGNFLLCC(ILOEBFFMKMK: false);
			}
		}
		KALGEANJHOO(1548f);
	}

	private void Awake()
	{
		instance = this;
	}

	private static void NIMJDCPJJBB(int JIIGOACEIKL)
	{
		for (int i = 0; i < instance.weatherParticles.Length; i++)
		{
			if (IsWeatherActive(instance.weatherParticles[i].weatherType))
			{
				HKAEACCBCKI(JIIGOACEIKL, instance.weatherParticles[i].weatherType);
			}
			else
			{
				KNDJHCNAEOK(JIIGOACEIKL, instance.weatherParticles[i].weatherType);
			}
		}
	}

	public static void ShowWeather(WeatherType CFDMNANCHEO)
	{
		((MonoBehaviour)instance).StartCoroutine(instance.KMMKGDHIMDE(SeasonManager.EECEKHKAAIH, CFDMNANCHEO));
	}

	private void MFIEPGBABAM()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			if (Object.op_Implicit((Object)(object)CommonReferences.MNFMOEKMJKN()))
			{
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(COPDNJFJKCH));
			}
			if (Object.op_Implicit((Object)(object)TavernConstructionManager.DEGPIHEEFHJ()))
			{
				TavernConstructionManager tavernConstructionManager = TavernConstructionManager.KNLLFEJAMNN();
				tavernConstructionManager.OnActivated = (Action<int>)Delegate.Remove(tavernConstructionManager.OnActivated, new Action<int>(PEEPHCGJACA));
				TavernConstructionManager tavernConstructionManager2 = TavernConstructionManager.DOIKFJDLKJP();
				tavernConstructionManager2.OnDeactivated = (Action<int>)Delegate.Remove(tavernConstructionManager2.OnDeactivated, new Action<int>(PEEPHCGJACA));
			}
			GameManager.OnPlayer1Joined = (Action)Delegate.Remove(GameManager.OnPlayer1Joined, new Action(BGDGLGBLNDI));
			GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(HADCIGKNFKK));
			GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(AGMLGNDDINL));
			if ((Object)(object)instance == (Object)(object)this)
			{
				instance = null;
			}
		}
	}

	private static void HKAEACCBCKI(int JIIGOACEIKL, WeatherType NCMDEGABGCH)
	{
		if (JIIGOACEIKL == 1)
		{
			((Component)instance.weatherParticles[HIGKNJCBADL(NCMDEGABGCH)].playerOneParticles).gameObject.SetActive(true);
		}
		else
		{
			((Component)instance.weatherParticles[HIGKNJCBADL(NCMDEGABGCH)].playerTwoParticles).gameObject.SetActive(true);
		}
	}

	private static int IMNBCPJPPHH(WeatherType NCMDEGABGCH)
	{
		switch (NCMDEGABGCH)
		{
		default:
			if (NCMDEGABGCH != WeatherType.Wind)
			{
				break;
			}
			return 1;
		case WeatherType.Snow:
			return 0;
		case WeatherType.Rain:
			return 0;
		case WeatherType.Wind:
			return 1;
		case WeatherType.Snow | WeatherType.Rain:
			break;
		}
		return 2;
	}

	public static void DeactivateSnowParticles()
	{
		KNDJHCNAEOK(1, WeatherType.Snow);
		if (GameManager.LocalCoop())
		{
			KNDJHCNAEOK(2, WeatherType.Snow);
		}
	}
}
