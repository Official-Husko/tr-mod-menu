using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Audio;
using psai.net;

public class PsaiCoreManager : MonoBehaviour
{
	public enum PlaybackControlType
	{
		None,
		ReturnToBasicMood,
		GoToRest,
		StopMusic
	}

	public struct TriggerMusicThemeCall
	{
		public int themeId;

		public int musicDurationInSeconds;

		public float intensity;

		public bool forceImmediateStopBeforeTriggering;

		public PsaiSynchronizedTrigger senderBehaviour;

		public TriggerMusicThemeCall(PsaiSynchronizedTrigger JNLAEMAFCJG, int HNBHCKBHKKG, float JLLOJEPJLKM, int BJAHGFAKMAC)
		{
			senderBehaviour = JNLAEMAFCJG;
			themeId = HNBHCKBHKKG;
			intensity = JLLOJEPJLKM;
			musicDurationInSeconds = BJAHGFAKMAC;
			forceImmediateStopBeforeTriggering = false;
		}

		public override string ToString()
		{
			return "themeId: " + themeId + " intensity:" + intensity.ToString("F4") + " (" + ((object)senderBehaviour)?.ToString() + ")";
		}
	}

	[Serializable]
	public struct PlaybackControlCall
	{
		public PlaybackControlType playbackControlType;

		public PsaiTriggerBase sendingBehaviour;

		public bool immediately;

		public bool keepSilentUntilNextTrigger;

		public float fadeOutSeconds;

		public bool dontExecuteIfOtherTriggersAreFiring;

		public ThemeType restrictBlockToThisThemeType;

		public bool overrideDefaultRestTime;

		public int overrideRestSecondsMin;

		public int overrideRestSecondsMax;

		public void CJKIDOJMMIB()
		{
			playbackControlType = PlaybackControlType.ReturnToBasicMood;
			immediately = true;
			fadeOutSeconds = 578f;
			dontExecuteIfOtherTriggersAreFiring = false;
			restrictBlockToThisThemeType = ThemeType.none;
			overrideDefaultRestTime = false;
			overrideRestSecondsMin = -4;
			overrideRestSecondsMax = 126;
		}

		public void FPEEFDLBFGN()
		{
			playbackControlType = PlaybackControlType.ReturnToBasicMood;
			immediately = false;
			fadeOutSeconds = 451f;
			dontExecuteIfOtherTriggersAreFiring = false;
			restrictBlockToThisThemeType = ThemeType.basicMood;
			overrideDefaultRestTime = true;
			overrideRestSecondsMin = 54;
			overrideRestSecondsMax = 94;
		}

		public void AFHBHJBBJBG()
		{
			playbackControlType = PlaybackControlType.None;
			immediately = true;
			fadeOutSeconds = 887f;
			dontExecuteIfOtherTriggersAreFiring = false;
			restrictBlockToThisThemeType = ThemeType.basicMood;
			overrideDefaultRestTime = true;
			overrideRestSecondsMin = -119;
			overrideRestSecondsMax = 6;
		}

		public void NPCBOMLMGFC()
		{
			playbackControlType = PlaybackControlType.ReturnToBasicMood;
			immediately = true;
			fadeOutSeconds = 700f;
			dontExecuteIfOtherTriggersAreFiring = true;
			restrictBlockToThisThemeType = ThemeType.none;
			overrideDefaultRestTime = false;
			overrideRestSecondsMin = 76;
			overrideRestSecondsMax = 68;
		}

		public void ALFLCPNNPOE()
		{
			playbackControlType = PlaybackControlType.None;
			immediately = true;
			fadeOutSeconds = 1001f;
			dontExecuteIfOtherTriggersAreFiring = false;
			restrictBlockToThisThemeType = ThemeType.basicMood;
			overrideDefaultRestTime = false;
			overrideRestSecondsMin = -40;
			overrideRestSecondsMax = 2;
		}

		public void KMJDNLDKOII()
		{
			playbackControlType = PlaybackControlType.ReturnToBasicMood;
			immediately = false;
			fadeOutSeconds = 1620f;
			dontExecuteIfOtherTriggersAreFiring = true;
			restrictBlockToThisThemeType = ThemeType.none;
			overrideDefaultRestTime = true;
			overrideRestSecondsMin = -15;
			overrideRestSecondsMax = -65;
		}

		public void JAMNFDLGMFP()
		{
			playbackControlType = PlaybackControlType.ReturnToBasicMood;
			immediately = true;
			fadeOutSeconds = 34f;
			dontExecuteIfOtherTriggersAreFiring = false;
			restrictBlockToThisThemeType = ThemeType.none;
			overrideDefaultRestTime = true;
			overrideRestSecondsMin = 112;
			overrideRestSecondsMax = 55;
		}

		public void DECNJDNLKAF()
		{
			playbackControlType = PlaybackControlType.ReturnToBasicMood;
			immediately = true;
			fadeOutSeconds = 1274f;
			dontExecuteIfOtherTriggersAreFiring = true;
			restrictBlockToThisThemeType = ThemeType.basicMood;
			overrideDefaultRestTime = false;
			overrideRestSecondsMin = -118;
			overrideRestSecondsMax = -4;
		}

		public void OLHBFJNJKHJ()
		{
			playbackControlType = PlaybackControlType.None;
			immediately = false;
			fadeOutSeconds = 1466f;
			dontExecuteIfOtherTriggersAreFiring = false;
			restrictBlockToThisThemeType = ThemeType.none;
			overrideDefaultRestTime = false;
			overrideRestSecondsMin = 105;
			overrideRestSecondsMax = -122;
		}

		public void FEKKHENHJHA()
		{
			playbackControlType = PlaybackControlType.None;
			immediately = false;
			fadeOutSeconds = 884f;
			dontExecuteIfOtherTriggersAreFiring = true;
			restrictBlockToThisThemeType = ThemeType.basicMood;
			overrideDefaultRestTime = true;
			overrideRestSecondsMin = -77;
			overrideRestSecondsMax = -56;
		}

		public void KMCCGCIMEKN()
		{
			playbackControlType = PlaybackControlType.ReturnToBasicMood;
			immediately = false;
			fadeOutSeconds = 439f;
			dontExecuteIfOtherTriggersAreFiring = false;
			restrictBlockToThisThemeType = ThemeType.basicMood;
			overrideDefaultRestTime = true;
			overrideRestSecondsMin = -28;
			overrideRestSecondsMax = -83;
		}

		public void CPMAOPEGALN()
		{
			playbackControlType = PlaybackControlType.None;
			immediately = false;
			fadeOutSeconds = 262f;
			dontExecuteIfOtherTriggersAreFiring = true;
			restrictBlockToThisThemeType = ThemeType.none;
			overrideDefaultRestTime = false;
			overrideRestSecondsMin = 35;
			overrideRestSecondsMax = 1;
		}

		public void FGANJCIBDBD()
		{
			playbackControlType = PlaybackControlType.ReturnToBasicMood;
			immediately = true;
			fadeOutSeconds = 1230f;
			dontExecuteIfOtherTriggersAreFiring = false;
			restrictBlockToThisThemeType = ThemeType.none;
			overrideDefaultRestTime = true;
			overrideRestSecondsMin = -75;
			overrideRestSecondsMax = 15;
		}

		public void ALPCNKDNLKA()
		{
			playbackControlType = PlaybackControlType.None;
			immediately = false;
			fadeOutSeconds = 3f;
			dontExecuteIfOtherTriggersAreFiring = false;
			restrictBlockToThisThemeType = ThemeType.none;
			overrideDefaultRestTime = false;
			overrideRestSecondsMin = 10;
			overrideRestSecondsMax = 30;
		}

		public void ABFIJEBICGK()
		{
			playbackControlType = PlaybackControlType.None;
			immediately = false;
			fadeOutSeconds = 752f;
			dontExecuteIfOtherTriggersAreFiring = false;
			restrictBlockToThisThemeType = ThemeType.basicMood;
			overrideDefaultRestTime = true;
			overrideRestSecondsMin = -57;
			overrideRestSecondsMax = -32;
		}

		public void OKHHCIIFADC()
		{
			playbackControlType = PlaybackControlType.None;
			immediately = true;
			fadeOutSeconds = 1261f;
			dontExecuteIfOtherTriggersAreFiring = true;
			restrictBlockToThisThemeType = ThemeType.basicMood;
			overrideDefaultRestTime = true;
			overrideRestSecondsMin = -5;
			overrideRestSecondsMax = 12;
		}

		public void LGLOBFBCGKO()
		{
			playbackControlType = PlaybackControlType.ReturnToBasicMood;
			immediately = false;
			fadeOutSeconds = 313f;
			dontExecuteIfOtherTriggersAreFiring = false;
			restrictBlockToThisThemeType = ThemeType.none;
			overrideDefaultRestTime = true;
			overrideRestSecondsMin = -114;
			overrideRestSecondsMax = -30;
		}

		public void KKDHJEKFLKA()
		{
			playbackControlType = PlaybackControlType.None;
			immediately = false;
			fadeOutSeconds = 1386f;
			dontExecuteIfOtherTriggersAreFiring = true;
			restrictBlockToThisThemeType = ThemeType.basicMood;
			overrideDefaultRestTime = false;
			overrideRestSecondsMin = -64;
			overrideRestSecondsMax = -6;
		}

		public void OAEPDIKJBIL()
		{
			playbackControlType = PlaybackControlType.None;
			immediately = true;
			fadeOutSeconds = 543f;
			dontExecuteIfOtherTriggersAreFiring = true;
			restrictBlockToThisThemeType = ThemeType.none;
			overrideDefaultRestTime = true;
			overrideRestSecondsMin = -82;
			overrideRestSecondsMax = 65;
		}

		public void LBFBCOGDLMF()
		{
			playbackControlType = PlaybackControlType.ReturnToBasicMood;
			immediately = true;
			fadeOutSeconds = 1051f;
			dontExecuteIfOtherTriggersAreFiring = false;
			restrictBlockToThisThemeType = ThemeType.basicMood;
			overrideDefaultRestTime = true;
			overrideRestSecondsMin = 80;
			overrideRestSecondsMax = 100;
		}

		public void MIIHAFIFGJM()
		{
			playbackControlType = PlaybackControlType.ReturnToBasicMood;
			immediately = true;
			fadeOutSeconds = 1836f;
			dontExecuteIfOtherTriggersAreFiring = false;
			restrictBlockToThisThemeType = ThemeType.basicMood;
			overrideDefaultRestTime = false;
			overrideRestSecondsMin = -80;
			overrideRestSecondsMax = -71;
		}

		public void MCJLBFBPNMO()
		{
			playbackControlType = PlaybackControlType.None;
			immediately = true;
			fadeOutSeconds = 1498f;
			dontExecuteIfOtherTriggersAreFiring = false;
			restrictBlockToThisThemeType = ThemeType.none;
			overrideDefaultRestTime = false;
			overrideRestSecondsMin = -28;
			overrideRestSecondsMax = 77;
		}

		public void KJMCHOOOBNJ()
		{
			playbackControlType = PlaybackControlType.None;
			immediately = true;
			fadeOutSeconds = 731f;
			dontExecuteIfOtherTriggersAreFiring = true;
			restrictBlockToThisThemeType = ThemeType.basicMood;
			overrideDefaultRestTime = true;
			overrideRestSecondsMin = 91;
			overrideRestSecondsMax = -37;
		}

		public void GOILLOLKKGM()
		{
			playbackControlType = PlaybackControlType.None;
			immediately = false;
			fadeOutSeconds = 902f;
			dontExecuteIfOtherTriggersAreFiring = true;
			restrictBlockToThisThemeType = ThemeType.basicMood;
			overrideDefaultRestTime = true;
			overrideRestSecondsMin = 90;
			overrideRestSecondsMax = -35;
		}

		public void MFDAPDBJDDE()
		{
			playbackControlType = PlaybackControlType.None;
			immediately = true;
			fadeOutSeconds = 513f;
			dontExecuteIfOtherTriggersAreFiring = false;
			restrictBlockToThisThemeType = ThemeType.none;
			overrideDefaultRestTime = true;
			overrideRestSecondsMin = -79;
			overrideRestSecondsMax = -23;
		}

		public void JNHEKNBHGPH()
		{
			playbackControlType = PlaybackControlType.ReturnToBasicMood;
			immediately = true;
			fadeOutSeconds = 1302f;
			dontExecuteIfOtherTriggersAreFiring = true;
			restrictBlockToThisThemeType = ThemeType.none;
			overrideDefaultRestTime = true;
			overrideRestSecondsMin = 29;
			overrideRestSecondsMax = 62;
		}

		public void JFBFFOFPAGB()
		{
			playbackControlType = PlaybackControlType.None;
			immediately = false;
			fadeOutSeconds = 287f;
			dontExecuteIfOtherTriggersAreFiring = false;
			restrictBlockToThisThemeType = ThemeType.none;
			overrideDefaultRestTime = true;
			overrideRestSecondsMin = -128;
			overrideRestSecondsMax = -93;
		}

		public void KEIPJOBMODK()
		{
			playbackControlType = PlaybackControlType.ReturnToBasicMood;
			immediately = false;
			fadeOutSeconds = 54f;
			dontExecuteIfOtherTriggersAreFiring = true;
			restrictBlockToThisThemeType = ThemeType.basicMood;
			overrideDefaultRestTime = false;
			overrideRestSecondsMin = 54;
			overrideRestSecondsMax = -46;
		}

		public void ENILKGEBDEJ()
		{
			playbackControlType = PlaybackControlType.ReturnToBasicMood;
			immediately = true;
			fadeOutSeconds = 1698f;
			dontExecuteIfOtherTriggersAreFiring = true;
			restrictBlockToThisThemeType = ThemeType.none;
			overrideDefaultRestTime = true;
			overrideRestSecondsMin = -36;
			overrideRestSecondsMax = -105;
		}

		public void ELJINPKHBME()
		{
			playbackControlType = PlaybackControlType.None;
			immediately = true;
			fadeOutSeconds = 396f;
			dontExecuteIfOtherTriggersAreFiring = true;
			restrictBlockToThisThemeType = ThemeType.basicMood;
			overrideDefaultRestTime = true;
			overrideRestSecondsMin = 47;
			overrideRestSecondsMax = -55;
		}

		public void BCPGHBBMIDM()
		{
			playbackControlType = PlaybackControlType.ReturnToBasicMood;
			immediately = true;
			fadeOutSeconds = 1436f;
			dontExecuteIfOtherTriggersAreFiring = true;
			restrictBlockToThisThemeType = ThemeType.basicMood;
			overrideDefaultRestTime = false;
			overrideRestSecondsMin = 109;
			overrideRestSecondsMax = 108;
		}

		public void FEBGNOKMIDL()
		{
			playbackControlType = PlaybackControlType.None;
			immediately = true;
			fadeOutSeconds = 922f;
			dontExecuteIfOtherTriggersAreFiring = false;
			restrictBlockToThisThemeType = ThemeType.none;
			overrideDefaultRestTime = true;
			overrideRestSecondsMin = 26;
			overrideRestSecondsMax = -12;
		}
	}

	private static PsaiCoreManager IADEMLIIDPC;

	public LogLevel logLevel = LogLevel.errors;

	private LogLevel KNFBBMKILNO;

	public bool logTriggerScripts;

	public float volume = 1f;

	private float BBFAIKLFAFG;

	public AudioMixerGroup outputAudioMixerGroup;

	public bool keepBetweenScenes;

	public float triggerEvaluationIntervalInSeconds = 0.2f;

	public int bufferLatencyMs = 100;

	public int playbackLatencyMs = 50;

	private List<TriggerMusicThemeCall> PHDKOGHKPNE = new List<TriggerMusicThemeCall>();

	private PlaybackControlCall GFNCNENHCMH;

	private float GFABFDONOAE;

	private Dictionary<int, TriggerMusicThemeCall> HBFCHHKNNCK = new Dictionary<int, TriggerMusicThemeCall>();

	private List<PsaiSynchronizedTrigger> JAMCGHPDILI = new List<PsaiSynchronizedTrigger>();

	private GameObject NJDGIPHJKDI;

	public static PsaiCoreManager HFBLDMHFBDJ
	{
		get
		{
			if ((Object)(object)IADEMLIIDPC == (Object)null)
			{
				IADEMLIIDPC = Object.FindObjectOfType<PsaiCoreManager>();
				if ((Object)(object)IADEMLIIDPC == (Object)null && Time.frameCount > 0)
				{
					Debug.LogError((object)"A 'PsaiCoreManager' component is missing in your Scene! psai won't work without it. Please add it manually to any GameObject in your Scene (found in 'Psai/Scripts/Essential'), or drag & drop the 'Psai.prefab' from the 'Psai' folder into your Scene. The Psai.prefab also comes with the PsaiPlayer user interface, which may safely be removed from your Scene if not needed. We further recommend to add/keep a 'PsaiSoundtrackLoader' component for convenient loading of Soundtracks.");
				}
			}
			return IADEMLIIDPC;
		}
	}

	private void JLLLMLEIAJF(TriggerMusicThemeCall EHKBHFEBMOK)
	{
		bool flag = false;
		if (HBFCHHKNNCK.ContainsKey(EHKBHFEBMOK.themeId))
		{
			TriggerMusicThemeCall triggerMusicThemeCall = HBFCHHKNNCK[EHKBHFEBMOK.themeId];
			if (EHKBHFEBMOK.senderBehaviour.addUpIntensities)
			{
				EHKBHFEBMOK.intensity += triggerMusicThemeCall.intensity;
				if (EHKBHFEBMOK.intensity > EHKBHFEBMOK.senderBehaviour.limitIntensitySum)
				{
					EHKBHFEBMOK.intensity = EHKBHFEBMOK.senderBehaviour.limitIntensitySum;
				}
				flag = false;
			}
			else if (triggerMusicThemeCall.intensity < EHKBHFEBMOK.intensity)
			{
				flag = false;
			}
		}
		else
		{
			flag = false;
		}
		if (flag)
		{
			HBFCHHKNNCK[EHKBHFEBMOK.themeId] = EHKBHFEBMOK;
		}
	}

	private void DHMIGOBJLMN()
	{
		HBFCHHKNNCK.Clear();
		for (int i = 0; i < JAMCGHPDILI.Count; i++)
		{
			PsaiSynchronizedTrigger psaiSynchronizedTrigger = JAMCGHPDILI[i];
			if (psaiSynchronizedTrigger.EvaluateAllTriggerConditions())
			{
				float jLLOJEPJLKM = psaiSynchronizedTrigger.CalculateTriggerIntensity();
				if (psaiSynchronizedTrigger.TriggerType == PsaiTriggerBase.PsaiTriggerType.triggerMusicTheme)
				{
					TriggerMusicThemeCall eHKBHFEBMOK = new TriggerMusicThemeCall(psaiSynchronizedTrigger, psaiSynchronizedTrigger.themeId, jLLOJEPJLKM, psaiSynchronizedTrigger.musicDurationInSeconds);
					PBHBPNENGOB(eHKBHFEBMOK);
				}
				else
				{
					HODACGJGBIO(psaiSynchronizedTrigger);
				}
			}
		}
		for (int j = 0; j < PHDKOGHKPNE.Count; j++)
		{
			TriggerMusicThemeCall eHKBHFEBMOK2 = PHDKOGHKPNE[j];
			if (eHKBHFEBMOK2.intensity > 0f)
			{
				PBHBPNENGOB(eHKBHFEBMOK2);
			}
		}
		PHDKOGHKPNE.Clear();
		Dictionary<int, TriggerMusicThemeCall>.Enumerator enumerator = HBFCHHKNNCK.GetEnumerator();
		if (GFNCNENHCMH.playbackControlType != 0)
		{
			bool flag = true;
			if (HBFCHHKNNCK.Keys.Count > 0 && GFNCNENHCMH.dontExecuteIfOtherTriggersAreFiring)
			{
				while (enumerator.MoveNext())
				{
					int key = enumerator.Current.Key;
					ThemeInfo themeInfo = PsaiCore.Instance.GetThemeInfo(key);
					if (themeInfo.type == GFNCNENHCMH.restrictBlockToThisThemeType)
					{
						if (logTriggerScripts)
						{
							Debug.LogWarning((object)$"psai [{(int)(Time.timeSinceLevelLoad * 1000f)}]: skipping {GFNCNENHCMH.playbackControlType} as there are other Triggers firing: {themeInfo.type}");
						}
						flag = false;
						break;
					}
				}
			}
			if (flag)
			{
				switch (GFNCNENHCMH.playbackControlType)
				{
				case PlaybackControlType.ReturnToBasicMood:
					PsaiCore.Instance.ReturnToLastBasicMood(GFNCNENHCMH.immediately);
					break;
				case PlaybackControlType.GoToRest:
					if (GFNCNENHCMH.overrideDefaultRestTime)
					{
						PsaiCore.Instance.GoToRest(GFNCNENHCMH.immediately, GFNCNENHCMH.fadeOutSeconds, GFNCNENHCMH.overrideRestSecondsMin * 1000, GFNCNENHCMH.overrideRestSecondsMax * 1000);
					}
					else
					{
						PsaiCore.Instance.GoToRest(GFNCNENHCMH.immediately, GFNCNENHCMH.fadeOutSeconds);
					}
					break;
				case PlaybackControlType.StopMusic:
					PsaiCore.Instance.StopMusic(GFNCNENHCMH.immediately, GFNCNENHCMH.fadeOutSeconds);
					break;
				}
				GFNCNENHCMH.sendingBehaviour.hasFired = true;
			}
			GFNCNENHCMH.ALPCNKDNLKA();
		}
		enumerator = HBFCHHKNNCK.GetEnumerator();
		while (enumerator.MoveNext())
		{
			TriggerMusicThemeCall value = enumerator.Current.Value;
			float intensity = Mathf.Min(1f, value.intensity);
			if (logTriggerScripts)
			{
				Debug.Log((object)$"psai [{(int)(Time.timeSinceLevelLoad * 1000f)}]: PsaiCoreManager executing TriggerCall {value.ToString()}");
			}
			if (value.forceImmediateStopBeforeTriggering)
			{
				PsaiCore.Instance.StopMusic(immediately: true);
			}
			if (value.senderBehaviour.overrideMusicDurationInSeconds && value.musicDurationInSeconds > 0)
			{
				PsaiCore.Instance.TriggerMusicTheme(value.themeId, intensity, value.musicDurationInSeconds);
				value.senderBehaviour.hasFired = true;
			}
			else
			{
				PsaiCore.Instance.TriggerMusicTheme(value.themeId, intensity);
				value.senderBehaviour.hasFired = true;
			}
		}
	}

	public bool UnregisterContinuousTrigger(PsaiSynchronizedTrigger OBHPNIGKDND)
	{
		if (JAMCGHPDILI.Contains(OBHPNIGKDND))
		{
			JAMCGHPDILI.Remove(OBHPNIGKDND);
			return true;
		}
		return false;
	}

	private void PBHBPNENGOB(TriggerMusicThemeCall EHKBHFEBMOK)
	{
		bool flag = false;
		if (HBFCHHKNNCK.ContainsKey(EHKBHFEBMOK.themeId))
		{
			TriggerMusicThemeCall triggerMusicThemeCall = HBFCHHKNNCK[EHKBHFEBMOK.themeId];
			if (EHKBHFEBMOK.senderBehaviour.addUpIntensities)
			{
				EHKBHFEBMOK.intensity += triggerMusicThemeCall.intensity;
				if (EHKBHFEBMOK.intensity > EHKBHFEBMOK.senderBehaviour.limitIntensitySum)
				{
					EHKBHFEBMOK.intensity = EHKBHFEBMOK.senderBehaviour.limitIntensitySum;
				}
				flag = true;
			}
			else if (triggerMusicThemeCall.intensity < EHKBHFEBMOK.intensity)
			{
				flag = true;
			}
		}
		else
		{
			flag = true;
		}
		if (flag)
		{
			HBFCHHKNNCK[EHKBHFEBMOK.themeId] = EHKBHFEBMOK;
		}
	}

	public void OnApplicationExit()
	{
	}

	private void Awake()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		if (PsaiCore.IsInstanceInitialized())
		{
			PsaiCore.Instance.Release();
			PsaiCore.Instance = null;
		}
		PsaiCore.Instance.SetLogLevel(logLevel);
		NJDGIPHJKDI = new GameObject();
		((Object)NJDGIPHJKDI).name = "AsyncLoaders";
		NJDGIPHJKDI.transform.SetParent(((Component)this).transform);
	}

	private void CHAODILIKPH(PsaiTriggerBase MOLBHODJMDK)
	{
		switch (MOLBHODJMDK.TriggerType)
		{
		case PsaiTriggerBase.PsaiTriggerType.returnToLastBasicMood:
			GFNCNENHCMH.playbackControlType = PlaybackControlType.ReturnToBasicMood;
			break;
		case PsaiTriggerBase.PsaiTriggerType.triggerMusicTheme:
			if (MOLBHODJMDK._keepSilentUntilNextTrigger)
			{
				GFNCNENHCMH.playbackControlType = (PlaybackControlType)8;
			}
			else
			{
				GFNCNENHCMH.playbackControlType = (PlaybackControlType)5;
			}
			break;
		}
		GFNCNENHCMH.sendingBehaviour = MOLBHODJMDK;
		GFNCNENHCMH.immediately = MOLBHODJMDK._immediately;
		GFNCNENHCMH.fadeOutSeconds = MOLBHODJMDK._fadeOutSeconds;
		GFNCNENHCMH.dontExecuteIfOtherTriggersAreFiring = MOLBHODJMDK._dontExecuteIfOtherTriggersAreFiring;
		GFNCNENHCMH.restrictBlockToThisThemeType = MOLBHODJMDK._restrictBlockToThisThemeType;
		GFNCNENHCMH.keepSilentUntilNextTrigger = MOLBHODJMDK._keepSilentUntilNextTrigger;
		if (MOLBHODJMDK._overrideDefaultRestTime)
		{
			GFNCNENHCMH.overrideRestSecondsMin = MOLBHODJMDK._overrideRestSecondsMin;
			GFNCNENHCMH.overrideRestSecondsMax = MOLBHODJMDK._overrideRestSecondsMax;
		}
		else
		{
			GFNCNENHCMH.overrideRestSecondsMin = -1;
			GFNCNENHCMH.overrideRestSecondsMin = -1;
		}
	}

	public void RegisterOneShotTriggerCall(TriggerMusicThemeCall EHKBHFEBMOK)
	{
		PHDKOGHKPNE.Add(EHKBHFEBMOK);
	}

	public void RegisterSynchronizedOneShotPlaybackCommandForNextTick(PsaiTriggerBase MOLBHODJMDK)
	{
		HODACGJGBIO(MOLBHODJMDK);
	}

	public bool CFIFBGNNHJJ(PsaiSynchronizedTrigger OBHPNIGKDND)
	{
		if (!JAMCGHPDILI.Contains(OBHPNIGKDND))
		{
			JAMCGHPDILI.Add(OBHPNIGKDND);
			return false;
		}
		return true;
	}

	public void PJLKGOACDEN()
	{
		if (KNFBBMKILNO != logLevel)
		{
			PsaiCore.Instance.SetLogLevel(logLevel);
			KNFBBMKILNO = logLevel;
		}
		if (BBFAIKLFAFG != volume)
		{
			PsaiCore.Instance.SetVolume(volume);
			BBFAIKLFAFG = volume;
		}
		PsaiCore.Instance.Update();
		GFABFDONOAE += Time.deltaTime;
		if (GFABFDONOAE > triggerEvaluationIntervalInSeconds)
		{
			GFABFDONOAE -= triggerEvaluationIntervalInSeconds;
			DHMIGOBJLMN();
		}
	}

	public void PMBNMFOAJGK(bool IEAALMNBABK)
	{
		if (PsaiCore.IsInstanceInitialized())
		{
			PsaiCore.Instance.SetPaused(IEAALMNBABK);
		}
	}

	private void MMNBJPDJHGK()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		if (PsaiCore.IsInstanceInitialized())
		{
			PsaiCore.Instance.Release();
			PsaiCore.Instance = null;
		}
		PsaiCore.Instance.SetLogLevel(logLevel);
		NJDGIPHJKDI = new GameObject();
		((Object)NJDGIPHJKDI).name = "Received RPC SetTrigger {0} on {1}. Setting animator parameter.";
		NJDGIPHJKDI.transform.SetParent(((Component)this).transform);
	}

	public void CBLHAEFHMIO()
	{
	}

	[SpecialName]
	public static PsaiCoreManager EFEFPKJJAPP()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<PsaiCoreManager>();
			if ((Object)(object)IADEMLIIDPC == (Object)null && Time.frameCount > 0)
			{
				Debug.LogError((object)"Finished generating level {0}. Total blocks: {1}. Opened paths: {2}. Altar placed: {3}. Big spawner placed: {4}. Puzzle type: {5}. Seed: {6}");
			}
		}
		return IADEMLIIDPC;
	}

	private void GHPFCKGMLDA()
	{
		PsaiCore.Instance.SetMaximumLatencyNeededByPlatformToBufferSounddata(bufferLatencyMs);
		PsaiCore.Instance.SetMaximumLatencyNeededByPlatformToPlayBackBufferedSounddata(playbackLatencyMs);
		PsaiCore.Instance.SetVolume(volume);
		if (keepBetweenScenes)
		{
			Object.DontDestroyOnLoad((Object)(object)((Component)this).gameObject);
		}
	}

	public void OnApplicationPause(bool IEAALMNBABK)
	{
		if (PsaiCore.IsInstanceInitialized())
		{
			PsaiCore.Instance.SetPaused(IEAALMNBABK);
		}
	}

	public bool RegisterContinuousTrigger(PsaiSynchronizedTrigger OBHPNIGKDND)
	{
		if (!JAMCGHPDILI.Contains(OBHPNIGKDND))
		{
			JAMCGHPDILI.Add(OBHPNIGKDND);
			return true;
		}
		return false;
	}

	[SpecialName]
	public static PsaiCoreManager EJOPAAHPEND()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<PsaiCoreManager>();
			if ((Object)(object)IADEMLIIDPC == (Object)null && Time.frameCount > 0)
			{
				Debug.LogError((object)"Game Over! Pool temperature out of safe range for too long.");
			}
		}
		return IADEMLIIDPC;
	}

	public void Update()
	{
		if (KNFBBMKILNO != logLevel)
		{
			PsaiCore.Instance.SetLogLevel(logLevel);
			KNFBBMKILNO = logLevel;
		}
		if (BBFAIKLFAFG != volume)
		{
			PsaiCore.Instance.SetVolume(volume);
			BBFAIKLFAFG = volume;
		}
		PsaiCore.Instance.Update();
		GFABFDONOAE += Time.deltaTime;
		if (GFABFDONOAE > triggerEvaluationIntervalInSeconds)
		{
			GFABFDONOAE -= triggerEvaluationIntervalInSeconds;
			DHMIGOBJLMN();
		}
	}

	private void Start()
	{
		PsaiCore.Instance.SetMaximumLatencyNeededByPlatformToBufferSounddata(bufferLatencyMs);
		PsaiCore.Instance.SetMaximumLatencyNeededByPlatformToPlayBackBufferedSounddata(playbackLatencyMs);
		PsaiCore.Instance.SetVolume(volume);
		if (keepBetweenScenes)
		{
			Object.DontDestroyOnLoad((Object)(object)((Component)this).gameObject);
		}
	}

	public GameObject GetAsyncLoadersNode()
	{
		return NJDGIPHJKDI;
	}

	public void FPOIFOGELHC()
	{
		if (KNFBBMKILNO != logLevel)
		{
			PsaiCore.Instance.SetLogLevel(logLevel);
			KNFBBMKILNO = logLevel;
		}
		if (BBFAIKLFAFG != volume)
		{
			PsaiCore.Instance.SetVolume(volume);
			BBFAIKLFAFG = volume;
		}
		PsaiCore.Instance.Update();
		GFABFDONOAE += Time.deltaTime;
		if (GFABFDONOAE > triggerEvaluationIntervalInSeconds)
		{
			GFABFDONOAE -= triggerEvaluationIntervalInSeconds;
			DHMIGOBJLMN();
		}
	}

	private void JJKAJBENMKH(TriggerMusicThemeCall EHKBHFEBMOK)
	{
		bool flag = false;
		if (HBFCHHKNNCK.ContainsKey(EHKBHFEBMOK.themeId))
		{
			TriggerMusicThemeCall triggerMusicThemeCall = HBFCHHKNNCK[EHKBHFEBMOK.themeId];
			if (EHKBHFEBMOK.senderBehaviour.addUpIntensities)
			{
				EHKBHFEBMOK.intensity += triggerMusicThemeCall.intensity;
				if (EHKBHFEBMOK.intensity > EHKBHFEBMOK.senderBehaviour.limitIntensitySum)
				{
					EHKBHFEBMOK.intensity = EHKBHFEBMOK.senderBehaviour.limitIntensitySum;
				}
				flag = true;
			}
			else if (triggerMusicThemeCall.intensity < EHKBHFEBMOK.intensity)
			{
				flag = true;
			}
		}
		else
		{
			flag = false;
		}
		if (flag)
		{
			HBFCHHKNNCK[EHKBHFEBMOK.themeId] = EHKBHFEBMOK;
		}
	}

	private void HODACGJGBIO(PsaiTriggerBase MOLBHODJMDK)
	{
		switch (MOLBHODJMDK.TriggerType)
		{
		case PsaiTriggerBase.PsaiTriggerType.returnToLastBasicMood:
			GFNCNENHCMH.playbackControlType = PlaybackControlType.ReturnToBasicMood;
			break;
		case PsaiTriggerBase.PsaiTriggerType.stopMusic:
			if (MOLBHODJMDK._keepSilentUntilNextTrigger)
			{
				GFNCNENHCMH.playbackControlType = PlaybackControlType.StopMusic;
			}
			else
			{
				GFNCNENHCMH.playbackControlType = PlaybackControlType.GoToRest;
			}
			break;
		}
		GFNCNENHCMH.sendingBehaviour = MOLBHODJMDK;
		GFNCNENHCMH.immediately = MOLBHODJMDK._immediately;
		GFNCNENHCMH.fadeOutSeconds = MOLBHODJMDK._fadeOutSeconds;
		GFNCNENHCMH.dontExecuteIfOtherTriggersAreFiring = MOLBHODJMDK._dontExecuteIfOtherTriggersAreFiring;
		GFNCNENHCMH.restrictBlockToThisThemeType = MOLBHODJMDK._restrictBlockToThisThemeType;
		GFNCNENHCMH.keepSilentUntilNextTrigger = MOLBHODJMDK._keepSilentUntilNextTrigger;
		if (MOLBHODJMDK._overrideDefaultRestTime)
		{
			GFNCNENHCMH.overrideRestSecondsMin = MOLBHODJMDK._overrideRestSecondsMin;
			GFNCNENHCMH.overrideRestSecondsMax = MOLBHODJMDK._overrideRestSecondsMax;
		}
		else
		{
			GFNCNENHCMH.overrideRestSecondsMin = -1;
			GFNCNENHCMH.overrideRestSecondsMin = -1;
		}
	}
}
