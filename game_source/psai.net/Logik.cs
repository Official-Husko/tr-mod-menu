using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using psai.Editor;

namespace psai.net;

internal class Logik
{
	private static readonly string PSAI_VERSION;

	internal static float COMPATIBILITY_PERCENTAGE_SAME_GROUP;

	internal static float COMPATIBILITY_PERCENTAGE_OTHER_GROUP;

	internal static readonly int PSAI_CHANNEL_COUNT;

	internal static readonly int PSAI_CHANNEL_COUNT_HIGHLIGHTS;

	internal static readonly int PSAI_FADING_UPDATE_INVERVAL_MILLIS;

	internal static readonly int PSAI_FADEOUTMILLIS_PLAYIMMEDIATELY;

	internal static readonly int PSAI_FADEOUTMILLIS_STOPMUSIC;

	internal static readonly int PSAI_FADEOUTMILLIS_HIGHLIGHT_INTERRUPTED;

	internal static readonly int SNIPPET_TYPE_MIDDLE_OR_BRIDGE;

	public static string LOGMESSAGE_TRIGGER_IGNORED;

	public static string LOGMESSAGE_TRIGGER_IGNORED_INTENSITYZEROTHEME_ALREADY_SET;

	public static string LOGMESSAGE_ABORTION_DUE_TO_INITIALIZATION_FAILURE;

	public static string LOGMESSAGE_TRIGGER_IGNORED_ZEROINTENSITY_AND_THEME_ISNT_CURRENTLY_PLAYING;

	public static string LOGMESSAGE_NO_THEME_SWITCH_THEME_OF_HIGHER_PRIORIY_IS_PLAYING;

	public static string LOGMESSAGE_TRIGGER_DENIED;

	private static Logik s_instance;

	private static Random s_random;

	internal Soundtrack m_soundtrack;

	private List<FadeData> m_fadeVoices;

	private int m_currentVoiceNumber;

	private int m_targetVoice;

	private IPlatformLayer m_platformLayer;

	private bool m_initializationFailure;

	internal string m_psaiCoreSoundtackFilepath;

	internal string m_psaiCoreSoundtrackDirectoryName;

	private static Stopwatch m_stopWatch;

	private Theme m_lastBasicMood;

	private int m_hilightVoiceIndex;

	private int m_lastRegularVoiceNumberReturned;

	private float m_psaiMasterVolume;

	private Segment m_currentSegmentPlaying;

	private int m_currentSnippetTypeRequested;

	private Theme m_effectiveTheme;

	private int m_timeStampCurrentSnippetPlaycall;

	private int m_estimatedTimestampOfTargetSnippetPlayback;

	private int m_timeStampOfLastIntensitySetForCurrentTheme;

	private int m_timeStampRestStart;

	private Segment m_targetSegment;

	private int m_targetSegmentSuitabilitiesRequested;

	private float m_currentIntensitySlope;

	private float m_lastIntensity;

	private bool m_holdIntensity;

	private float m_heldIntensity;

	private bool m_scheduleFadeoutUponSnippetPlayback;

	private float m_startOrRetriggerIntensityOfCurrentTheme;

	private int m_lastMusicDuration;

	private int m_remainingMusicDurationAtTimeOfHoldIntensity;

	private PsaiState m_psaiState;

	private PsaiState m_psaiStateIntended;

	private List<ThemeQueueEntry> m_themeQueue;

	private PsaiPlayMode m_psaiPlayMode;

	private PsaiPlayMode m_psaiPlayModeIntended;

	private bool m_returnToLastBasicMoodFlag;

	private string m_fullVersionString;

	private PlaybackChannel[] m_playbackChannels = new PlaybackChannel[PSAI_CHANNEL_COUNT];

	internal static int s_audioLayerMaximumLatencyForPlayingbackPrebufferedSounds;

	internal static int s_audioLayerMaximumLatencyForBufferingSounds;

	internal static int s_audioLayerMaximumLatencyForPlayingBackUnbufferedSounds;

	internal static int s_updateIntervalMillis;

	private PsaiTimer m_timerStartSnippetPlayback = new PsaiTimer();

	private PsaiTimer m_timerSegmentEndApproaching = new PsaiTimer();

	private PsaiTimer m_timerSegmentEndReached = new PsaiTimer();

	private PsaiTimer m_timerFades = new PsaiTimer();

	private PsaiTimer m_timerWakeUpFromRest = new PsaiTimer();

	private int m_timeStampOfLastFadeUpdate;

	private ThemeQueueEntry m_latestEndOfSegmentTriggerCall = new ThemeQueueEntry();

	private bool m_paused;

	private int m_timeStampPauseOn;

	private int m_restModeSecondsOverride;

	internal static Logik Instance
	{
		get
		{
			if (s_instance == null)
			{
				s_instance = new Logik();
			}
			return s_instance;
		}
	}

	static Logik()
	{
		PSAI_VERSION = ".NET 1.7.3";
		COMPATIBILITY_PERCENTAGE_SAME_GROUP = 1f;
		COMPATIBILITY_PERCENTAGE_OTHER_GROUP = 0.5f;
		PSAI_CHANNEL_COUNT = 9;
		PSAI_CHANNEL_COUNT_HIGHLIGHTS = 2;
		PSAI_FADING_UPDATE_INVERVAL_MILLIS = 50;
		PSAI_FADEOUTMILLIS_PLAYIMMEDIATELY = 500;
		PSAI_FADEOUTMILLIS_STOPMUSIC = 1000;
		PSAI_FADEOUTMILLIS_HIGHLIGHT_INTERRUPTED = 2000;
		SNIPPET_TYPE_MIDDLE_OR_BRIDGE = 10;
		LOGMESSAGE_TRIGGER_IGNORED = "trigger ignored! A Theme of higher priority is currently playing.";
		LOGMESSAGE_TRIGGER_IGNORED_INTENSITYZEROTHEME_ALREADY_SET = "trigger ignored ! an IntensityZeroTheme with higher priority has already been set.";
		LOGMESSAGE_ABORTION_DUE_TO_INITIALIZATION_FAILURE = "abortion due to sound device failure";
		LOGMESSAGE_TRIGGER_IGNORED_ZEROINTENSITY_AND_THEME_ISNT_CURRENTLY_PLAYING = "trigger ignored ! (triggers of zero intensity are ignored as long as the tiggered theme is not playing right now)";
		LOGMESSAGE_NO_THEME_SWITCH_THEME_OF_HIGHER_PRIORIY_IS_PLAYING = "no theme switch: a theme of higher priority is currently playing";
		LOGMESSAGE_TRIGGER_DENIED = "Trigger denied ! No compatible Segment found for the Segments that's currently playing.";
		s_audioLayerMaximumLatencyForPlayingbackPrebufferedSounds = 50;
		s_audioLayerMaximumLatencyForBufferingSounds = 200;
		s_updateIntervalMillis = 100;
		s_random = new Random();
		GetTimestampMillisElapsedSinceInitialisation();
		UpdateMaximumLatencyForPlayingBackUnbufferedSounds();
	}

	internal void Release()
	{
		for (int i = 0; i < m_playbackChannels.Length; i++)
		{
			m_playbackChannels[i].Release();
		}
		m_platformLayer.Release();
	}

	internal static int GetRandomInt(int min, int max)
	{
		return s_random.Next(min, max);
	}

	internal static float GetRandomFloat()
	{
		return (float)s_random.NextDouble();
	}

	private static void UpdateMaximumLatencyForPlayingBackUnbufferedSounds()
	{
		s_audioLayerMaximumLatencyForPlayingBackUnbufferedSounds = s_audioLayerMaximumLatencyForBufferingSounds + s_audioLayerMaximumLatencyForPlayingbackPrebufferedSounds;
	}

	internal PsaiResult SetMaximumLatencyNeededByPlatformToBufferSounddata(int latencyInMilliseconds)
	{
		if (latencyInMilliseconds >= 0)
		{
			s_audioLayerMaximumLatencyForBufferingSounds = latencyInMilliseconds;
			UpdateMaximumLatencyForPlayingBackUnbufferedSounds();
			if (LogLevel.info <= Logger.Instance.LogLevel)
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append("Maximum latency needed by platform for buffering audio data set to ");
				stringBuilder.Append(latencyInMilliseconds);
				Logger.Instance.Log(stringBuilder.ToString(), LogLevel.info);
			}
			return PsaiResult.OK;
		}
		return PsaiResult.invalidParam;
	}

	internal PsaiResult SetMaximumLatencyNeededByPlatformToPlayBackBufferedSounds(int latencyInMilliseconds)
	{
		if (latencyInMilliseconds >= 0)
		{
			s_audioLayerMaximumLatencyForBufferingSounds = latencyInMilliseconds;
			UpdateMaximumLatencyForPlayingBackUnbufferedSounds();
			if (LogLevel.info <= Logger.Instance.LogLevel)
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append("Maximum latency needed by platform for playing back buffered audio data set to ");
				stringBuilder.Append(latencyInMilliseconds);
				Logger.Instance.Log(stringBuilder.ToString(), LogLevel.info);
			}
			return PsaiResult.OK;
		}
		return PsaiResult.invalidParam;
	}

	internal Logik()
	{
		m_platformLayer = new PlatformLayerUnity();
		m_platformLayer.Initialize();
		m_soundtrack = new Soundtrack();
		m_themeQueue = new List<ThemeQueueEntry>();
		m_fadeVoices = new List<FadeData>();
		for (int i = 0; i < PSAI_CHANNEL_COUNT; i++)
		{
			if (i < PSAI_CHANNEL_COUNT - PSAI_CHANNEL_COUNT_HIGHLIGHTS)
			{
				m_playbackChannels[i] = new PlaybackChannel(this, isMainChannel: true);
			}
			else
			{
				m_playbackChannels[i] = new PlaybackChannel(this, isMainChannel: false);
			}
		}
		m_hilightVoiceIndex = -1;
		m_lastRegularVoiceNumberReturned = -1;
		m_currentVoiceNumber = -1;
		m_targetVoice = -1;
		m_psaiMasterVolume = 1f;
		m_effectiveTheme = null;
		m_currentSegmentPlaying = null;
		m_currentSnippetTypeRequested = 0;
		m_targetSegment = null;
		m_targetSegmentSuitabilitiesRequested = 0;
		m_psaiState = PsaiState.notready;
		m_psaiStateIntended = PsaiState.notready;
		m_paused = false;
		m_fullVersionString = "psai Version " + PSAI_VERSION;
		Logger.Instance.LogLevel = LogLevel.info;
		Logger.Instance.Log(m_fullVersionString, LogLevel.info);
		s_instance = this;
	}

	~Logik()
	{
	}

	internal PsaiResult LoadSoundtrackFromProjectFile(string pathToProjectFile)
	{
		PsaiProject psaiProject = null;
		m_psaiCoreSoundtackFilepath = pathToProjectFile;
		m_psaiCoreSoundtrackDirectoryName = Path.GetDirectoryName(pathToProjectFile);
		m_initializationFailure = false;
		using Stream stream = m_platformLayer.GetStreamOnPsaiSoundtrackFile(m_psaiCoreSoundtackFilepath);
		if (stream == null)
		{
			Logger.Instance.Log("File not found.", LogLevel.errors);
			return PsaiResult.file_notFound;
		}
		psaiProject = PsaiProject.LoadProjectFromStream(stream);
		if (psaiProject != null)
		{
			return LoadSoundtrackByPsaiProject(psaiProject, pathToProjectFile);
		}
		Logger.Instance.Log("Project deserialization failed!", LogLevel.errors);
		return PsaiResult.error_file;
	}

	public PsaiResult LoadSoundtrackByPsaiProject(PsaiProject psaiProject, string fullProjectPath)
	{
		m_soundtrack = psaiProject.BuildPsaiDotNetSoundtrackFromProject();
		m_psaiCoreSoundtackFilepath = fullProjectPath;
		m_psaiCoreSoundtrackDirectoryName = Path.GetDirectoryName(fullProjectPath);
		InitMembersAfterSoundtrackHasLoaded();
		if (LogLevel.info <= Logger.Instance.LogLevel)
		{
			Logger.Instance.Log("Soundtrack deserialization succeeded", LogLevel.info);
		}
		return PsaiResult.OK;
	}

	private void InitMembersAfterSoundtrackHasLoaded()
	{
		m_themeQueue.Clear();
		m_fadeVoices.Clear();
		foreach (Segment value in m_soundtrack.m_snippets.Values)
		{
			value.audioData.filePathRelativeToProjectDir = m_platformLayer.ConvertFilePathForPlatform(value.audioData.filePathRelativeToProjectDir);
			if (LogLevel.debug <= Logger.Instance.LogLevel)
			{
				Logger.Instance.Log("converted path of segment " + value.Name + " to " + value.audioData.filePathRelativeToProjectDir, LogLevel.debug);
			}
		}
		m_soundtrack.UpdateMaxPreBeatMsOfCompatibleMiddleOrBridgeSnippets();
		m_lastBasicMood = m_soundtrack.getThemeById(GetLastBasicMoodId());
		m_psaiState = PsaiState.silence;
		m_psaiStateIntended = PsaiState.silence;
		m_psaiPlayMode = PsaiPlayMode.regular;
		m_psaiPlayModeIntended = PsaiPlayMode.regular;
		m_returnToLastBasicMoodFlag = false;
		m_holdIntensity = false;
		m_latestEndOfSegmentTriggerCall.themeId = -1;
		m_soundtrack.BuildAllIndirectionSequences();
	}

	internal void setLogLevel(LogLevel newLogLevel)
	{
		if (LogLevel.debug <= newLogLevel)
		{
			Logger.Instance.Log("setLogLevel() " + newLogLevel, LogLevel.debug);
		}
		Logger.Instance.LogLevel = newLogLevel;
	}

	internal int GetLastBasicMoodId()
	{
		if (m_lastBasicMood != null)
		{
			return m_lastBasicMood.id;
		}
		return -1;
	}

	public void SetLastBasicMood(int themeId)
	{
		Theme themeById = m_soundtrack.getThemeById(themeId);
		if (themeById != null)
		{
			SetThemeAsLastBasicMood(themeById);
		}
		else
		{
			m_lastBasicMood = null;
		}
	}

	internal static bool CheckIfFileExists(string filepath)
	{
		return File.Exists(filepath);
	}

	private int GetRemainingMusicDurationSecondsOfCurrentTheme()
	{
		int num = GetTimestampMillisElapsedSinceInitialisation() - m_timeStampOfLastIntensitySetForCurrentTheme;
		int num2 = m_lastMusicDuration - num / 1000;
		if (LogLevel.debug <= Logger.Instance.LogLevel)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("GetRemainingMusicDurationSecondsOfCurrentTheme=");
			stringBuilder.Append(num2);
			stringBuilder.Append("  millisElapsedSinceLastRetrigger=");
			stringBuilder.Append(num);
			stringBuilder.Append("  m_lastMusicDuration=");
			stringBuilder.Append(m_lastMusicDuration);
			Logger.Instance.Log(stringBuilder.ToString(), LogLevel.debug);
		}
		return num2;
	}

	internal static int GetTimestampMillisElapsedSinceInitialisation()
	{
		if (m_stopWatch == null)
		{
			m_stopWatch = new Stopwatch();
			m_stopWatch.Start();
		}
		return (int)m_stopWatch.ElapsedMilliseconds;
	}

	internal string getVersion()
	{
		return m_fullVersionString;
	}

	internal long GetCurrentSystemTimeMillis()
	{
		return GetTimestampMillisElapsedSinceInitialisation();
	}

	private void startFade(int voiceId, int fadeoutMillis, int timeOffsetMillis)
	{
		if (voiceId <= -1)
		{
			return;
		}
		if (LogLevel.debug <= Logger.Instance.LogLevel)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("startFade()  voiceId=");
			stringBuilder.Append(voiceId);
			stringBuilder.Append("  fadeoutMillis=");
			stringBuilder.Append(fadeoutMillis);
			stringBuilder.Append("  timeOffsetMillis=");
			stringBuilder.Append(timeOffsetMillis);
			stringBuilder.Append("  channelState=");
			stringBuilder.Append(m_playbackChannels[voiceId].GetCurrentChannelState());
			Logger.Instance.Log(stringBuilder.ToString(), LogLevel.debug);
		}
		float fadeOutVolume = m_playbackChannels[voiceId].FadeOutVolume;
		for (int i = 0; i < m_fadeVoices.Count; i++)
		{
			FadeData fadeData = m_fadeVoices[i];
			if (fadeData.voiceNumber == voiceId)
			{
				fadeData.delayMillis = 0;
				fadeData.fadeoutDeltaVolumePerUpdate = fadeOutVolume / ((float)fadeoutMillis / (float)PSAI_FADING_UPDATE_INVERVAL_MILLIS);
				fadeData.currentVolume = fadeOutVolume;
				return;
			}
		}
		if (fadeOutVolume > 0f)
		{
			AddFadeData(voiceId, fadeoutMillis, fadeOutVolume, timeOffsetMillis);
			if (!m_timerFades.IsSet())
			{
				if (LogLevel.debug <= Logger.Instance.LogLevel)
				{
					Logger.Instance.Log("setting timerFades", LogLevel.debug);
				}
				m_timeStampOfLastFadeUpdate = GetTimestampMillisElapsedSinceInitialisation();
				m_timerFades.SetTimer(PSAI_FADING_UPDATE_INVERVAL_MILLIS, 0);
			}
			else if (LogLevel.debug <= Logger.Instance.LogLevel)
			{
				Logger.Instance.Log("timer PSAI_TIMER_FADES is already set", LogLevel.debug);
			}
		}
		else if (LogLevel.debug <= Logger.Instance.LogLevel)
		{
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("INTERNAL WARNING: startFade() ignored: m_audioPlaybackLayer->getVolume() returned currentVol=");
			stringBuilder2.Append(fadeOutVolume);
			Logger.Instance.Log(stringBuilder2.ToString(), LogLevel.debug);
		}
	}

	private void AddFadeData(int voiceNumber, int fadeoutMillis, float currentVolume, int delayMillis)
	{
		FadeData fadeData = new FadeData();
		fadeData.voiceNumber = voiceNumber;
		fadeData.fadeoutDeltaVolumePerUpdate = currentVolume / ((float)fadeoutMillis / (float)PSAI_FADING_UPDATE_INVERVAL_MILLIS);
		fadeData.currentVolume = currentVolume;
		fadeData.delayMillis = delayMillis;
		m_fadeVoices.Add(fadeData);
	}

	internal int getNextVoiceNumber(bool forHighlight)
	{
		int num = 0;
		if (!forHighlight)
		{
			num = m_lastRegularVoiceNumberReturned + 1;
			if (num >= PSAI_CHANNEL_COUNT - PSAI_CHANNEL_COUNT_HIGHLIGHTS)
			{
				num = 0;
			}
			m_lastRegularVoiceNumberReturned = num;
		}
		else
		{
			num = m_hilightVoiceIndex + 1;
			if (num == 0 || num == PSAI_CHANNEL_COUNT)
			{
				num = PSAI_CHANNEL_COUNT - PSAI_CHANNEL_COUNT_HIGHLIGHTS;
			}
		}
		return num;
	}

	private void PsaiErrorCheck(PsaiResult result, string infoAboutLastCall)
	{
		if (result != PsaiResult.OK)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("PSAI error!");
			stringBuilder.AppendLine(infoAboutLastCall);
			stringBuilder.Append("PsaiResult=");
			stringBuilder.Append(result);
			Logger.Instance.Log(stringBuilder.ToString(), LogLevel.errors);
		}
	}

	private int GetMillisElapsedAfterCurrentSnippetPlaycall()
	{
		if (m_currentSegmentPlaying != null)
		{
			if (!m_paused)
			{
				return GetTimestampMillisElapsedSinceInitialisation() - m_timeStampCurrentSnippetPlaycall;
			}
			return m_timeStampPauseOn - m_timeStampCurrentSnippetPlaycall;
		}
		return 0;
	}

	internal PsaiResult setPaused(bool setPaused)
	{
		if (LogLevel.debug <= Logger.Instance.LogLevel)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("Logik.setPaused(");
			stringBuilder.Append(setPaused);
			stringBuilder.Append(") ");
			Logger.Instance.Log(stringBuilder.ToString(), LogLevel.debug);
		}
		if ((setPaused && !m_paused) || (!setPaused && m_paused))
		{
			m_paused = setPaused;
			PlaybackChannel[] playbackChannels = m_playbackChannels;
			for (int i = 0; i < playbackChannels.Length; i++)
			{
				playbackChannels[i].Paused = setPaused;
			}
			m_timerStartSnippetPlayback.SetPaused(setPaused);
			m_timerSegmentEndApproaching.SetPaused(setPaused);
			m_timerSegmentEndReached.SetPaused(setPaused);
			m_timerWakeUpFromRest.SetPaused(setPaused);
			if (setPaused)
			{
				m_timeStampPauseOn = GetTimestampMillisElapsedSinceInitialisation();
				m_lastIntensity = getCurrentIntensity();
			}
			else
			{
				int num = GetTimestampMillisElapsedSinceInitialisation() - m_timeStampPauseOn;
				int num2 = m_timeStampPauseOn - m_timeStampCurrentSnippetPlaycall;
				m_timeStampCurrentSnippetPlaycall = GetTimestampMillisElapsedSinceInitialisation() - num2;
				m_timeStampOfLastIntensitySetForCurrentTheme += num;
				m_estimatedTimestampOfTargetSnippetPlayback += num;
				if (LogLevel.debug <= Logger.Instance.LogLevel)
				{
					StringBuilder stringBuilder2 = new StringBuilder();
					stringBuilder2.Append("pausePeriod=");
					stringBuilder2.Append(num);
					stringBuilder2.Append(" m_estimatedTimestampOfTargetSnippetPlayback=");
					stringBuilder2.Append(m_estimatedTimestampOfTargetSnippetPlayback);
					Logger.Instance.Log(stringBuilder2.ToString(), LogLevel.debug);
				}
			}
			return PsaiResult.OK;
		}
		if (LogLevel.info <= Logger.Instance.LogLevel)
		{
			StringBuilder stringBuilder3 = new StringBuilder();
			stringBuilder3.Append("setPaused() has been ignored, as psai was already in the given state.");
			stringBuilder3.Append(" m_paused=");
			stringBuilder3.Append(m_paused);
			stringBuilder3.Append(" setPaused=");
			stringBuilder3.Append(setPaused);
			Logger.Instance.Log(stringBuilder3.ToString(), LogLevel.info);
		}
		return PsaiResult.commandIgnored;
	}

	internal PsaiResult Update()
	{
		if (!m_paused)
		{
			if (m_timerStartSnippetPlayback.ThresholdHasBeenReached())
			{
				m_timerStartSnippetPlayback.Stop();
				PlayTargetSegmentImmediately();
			}
			if (m_timerSegmentEndApproaching.ThresholdHasBeenReached())
			{
				m_timerSegmentEndApproaching.Stop();
				SegmentEndApproachingHandler();
			}
			if (m_timerSegmentEndReached.ThresholdHasBeenReached())
			{
				m_timerSegmentEndReached.Stop();
				SegmentEndReachedHandler();
			}
			if (m_timerWakeUpFromRest.ThresholdHasBeenReached())
			{
				m_timerWakeUpFromRest.Stop();
				WakeUpFromRestHandler();
			}
			if (m_timerFades.ThresholdHasBeenReached())
			{
				m_timerFades.Stop();
				updateFades();
			}
		}
		return PsaiResult.OK;
	}

	private void SetThemeAsLastBasicMood(Theme latestBasicMood)
	{
		if (latestBasicMood != null)
		{
			if ((m_lastBasicMood == null || (m_lastBasicMood != null && m_lastBasicMood != latestBasicMood)) && LogLevel.info <= Logger.Instance.LogLevel)
			{
				Logger.Instance.Log("Setting Theme " + latestBasicMood.id + " as the Last Basic Mood", LogLevel.info);
			}
			m_lastBasicMood = latestBasicMood;
		}
		else if (LogLevel.warnings <= Logger.Instance.LogLevel)
		{
			Logger.Instance.Log("SetThemeAsLatestBasicMood(): invalid theme argument ! ", LogLevel.warnings);
		}
	}

	private bool CheckIfAnyThemeIsCurrentlyPlaying()
	{
		if (m_psaiState == PsaiState.playing && m_currentSegmentPlaying != null && m_effectiveTheme != null)
		{
			return true;
		}
		return false;
	}

	internal PsaiResult ReturnToLastBasicMood(bool immediately)
	{
		if (LogLevel.info <= Logger.Instance.LogLevel)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("ReturnToBasicMood(");
			stringBuilder.Append(immediately);
			stringBuilder.Append(")  m_psaiState=");
			stringBuilder.Append(m_psaiState);
			stringBuilder.Append("  m_currentSnippetTypesRequested=");
			stringBuilder.Append(Segment.GetStringFromSegmentSuitabilities(m_currentSnippetTypeRequested));
			Logger.Instance.Log(stringBuilder.ToString(), LogLevel.info);
		}
		if (m_initializationFailure)
		{
			return PsaiResult.initialization_error;
		}
		if (m_lastBasicMood == null)
		{
			return PsaiResult.no_basicmood_set;
		}
		if (m_paused)
		{
			setPaused(setPaused: false);
		}
		if (m_psaiPlayModeIntended == PsaiPlayMode.regular)
		{
			switch (m_psaiState)
			{
			case PsaiState.playing:
				m_themeQueue.Clear();
				m_holdIntensity = false;
				m_latestEndOfSegmentTriggerCall.themeId = -1;
				if (m_currentSegmentPlaying != null && m_effectiveTheme.themeType != ThemeType.basicMood)
				{
					bool flag = false;
					if (!immediately)
					{
						flag = CheckIfThereIsAPathToEndSegmentForEffectiveSegmentAndLogWarningIfThereIsnt();
					}
					if (immediately || !flag)
					{
						PlayThemeNowOrAtEndOfCurrentSegmentAndStartEvaluation(GetLastBasicMoodId(), m_lastBasicMood.intensityAfterRest, m_lastBasicMood.musicDurationGeneral, immediately: true, holdIntensity: false);
					}
					else
					{
						m_psaiStateIntended = PsaiState.playing;
						m_returnToLastBasicMoodFlag = true;
					}
					return PsaiResult.OK;
				}
				if (LogLevel.warnings <= Logger.Instance.LogLevel)
				{
					Logger.Instance.Log("ReturnToLastBasicMood() ignored: base theme is already playing", LogLevel.warnings);
				}
				return PsaiResult.commandIgnored;
			case PsaiState.silence:
			case PsaiState.rest:
				PlayThemeNowOrAtEndOfCurrentSegmentAndStartEvaluation(GetLastBasicMoodId(), m_lastBasicMood.intensityAfterRest, m_lastBasicMood.musicDurationGeneral, immediately: true, holdIntensity: false);
				return PsaiResult.OK;
			default:
				if (LogLevel.debug <= Logger.Instance.LogLevel)
				{
					StringBuilder stringBuilder2 = new StringBuilder();
					stringBuilder2.Append("INTERNAL ERROR: unconsidered psaiState in ReturnToLastBasicMood()! m_psaiState=");
					stringBuilder2.Append(m_psaiState);
					Logger.Instance.Log(stringBuilder2.ToString(), LogLevel.debug);
				}
				return PsaiResult.internal_error;
			}
		}
		if (m_psaiPlayModeIntended == PsaiPlayMode.menuMode)
		{
			if (LogLevel.warnings <= Logger.Instance.LogLevel)
			{
				Logger.Instance.Log("ReturnToLastBasicMood() ignored: MenuMode is active. Call MenuModeLeave() first.", LogLevel.warnings);
			}
			return PsaiResult.commandIgnoredMenuModeActive;
		}
		if (m_psaiPlayModeIntended == PsaiPlayMode.cutScene)
		{
			if (LogLevel.warnings <= Logger.Instance.LogLevel)
			{
				Logger.Instance.Log("ReturnToLastBasicMood() ignored: CutScene is active. Call CutsceneLeave() first.", LogLevel.warnings);
			}
			return PsaiResult.commandIgnoredCutsceneActive;
		}
		return PsaiResult.internal_error;
	}

	internal int getUpcomingThemeId()
	{
		if (m_psaiState == PsaiState.playing)
		{
			if (m_latestEndOfSegmentTriggerCall.themeId != -1)
			{
				return m_latestEndOfSegmentTriggerCall.themeId;
			}
			ThemeQueueEntry followingThemeQueueEntry = getFollowingThemeQueueEntry();
			if (followingThemeQueueEntry != null)
			{
				return followingThemeQueueEntry.themeId;
			}
		}
		return -1;
	}

	internal PsaiResult TriggerMusicTheme(int argThemeId, float argIntensity)
	{
		Theme themeById = m_soundtrack.getThemeById(argThemeId);
		if (themeById == null)
		{
			if (LogLevel.errors <= Logger.Instance.LogLevel)
			{
				Logger.Instance.Log($"TriggerMusicTheme() - Theme not found ! themeId={argThemeId}", LogLevel.errors);
			}
			return PsaiResult.unknown_theme;
		}
		if (themeById.m_segments.Count == 0)
		{
			if (LogLevel.errors <= Logger.Instance.LogLevel)
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append("TriggerMusicTheme() - Theme ");
				stringBuilder.Append(themeById.Name);
				stringBuilder.Append(" contains no Segments! ");
				Logger.Instance.Log(stringBuilder.ToString(), LogLevel.errors);
			}
			return PsaiResult.essential_segment_missing;
		}
		if (LogLevel.info <= Logger.Instance.LogLevel)
		{
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("TriggerMusicTheme() argThemeId=");
			stringBuilder2.Append(argThemeId);
			stringBuilder2.Append(" argIntensity=");
			stringBuilder2.Append(argIntensity);
			stringBuilder2.Append("  [");
			stringBuilder2.Append(themeById.Name);
			stringBuilder2.Append("]");
			Logger.Instance.Log(stringBuilder2.ToString(), LogLevel.info);
		}
		return TriggerMusicTheme(themeById, argIntensity, themeById.musicDurationGeneral);
	}

	internal PsaiResult TriggerMusicTheme(int argThemeId, float argIntensity, int argMusicDuration)
	{
		Theme themeById = m_soundtrack.getThemeById(argThemeId);
		if (themeById == null)
		{
			if (LogLevel.warnings <= Logger.Instance.LogLevel)
			{
				Logger.Instance.Log("TriggerMusicTheme() - theme not found ! themeId=" + argThemeId, LogLevel.warnings);
			}
			return PsaiResult.unknown_theme;
		}
		if (LogLevel.info <= Logger.Instance.LogLevel)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("TriggerMusicTheme() argThemeId=");
			stringBuilder.Append(argThemeId);
			stringBuilder.Append(" argIntensity=");
			stringBuilder.Append(argIntensity);
			stringBuilder.Append("  [");
			stringBuilder.Append(themeById.Name);
			stringBuilder.Append("]");
			stringBuilder.Append("  argMusicDurationInSeconds=");
			stringBuilder.Append(argMusicDuration);
			Logger.Instance.Log(stringBuilder.ToString(), LogLevel.info);
		}
		return TriggerMusicTheme(themeById, argIntensity, argMusicDuration);
	}

	internal PsaiResult TriggerMusicTheme(Theme argTheme, float argIntensity, int argMusicDuration)
	{
		if (m_initializationFailure)
		{
			if (LogLevel.errors <= Logger.Instance.LogLevel)
			{
				Logger.Instance.Log(LOGMESSAGE_ABORTION_DUE_TO_INITIALIZATION_FAILURE, LogLevel.errors);
			}
			return PsaiResult.initialization_error;
		}
		if (m_paused)
		{
			setPaused(setPaused: false);
		}
		if (argIntensity > 1f)
		{
			argIntensity = 1f;
			if (LogLevel.warnings <= Logger.Instance.LogLevel)
			{
				Logger.Instance.Log("argIntensity was > 1 and has been clamped to 1.0f", LogLevel.warnings);
			}
		}
		else if (argIntensity < 0f)
		{
			argIntensity = 0f;
			if (LogLevel.warnings <= Logger.Instance.LogLevel)
			{
				Logger.Instance.Log("argIntensity < 0 and has been clamped to 0.0f", LogLevel.warnings);
			}
		}
		if (m_psaiPlayMode == PsaiPlayMode.menuMode)
		{
			if (LogLevel.warnings <= Logger.Instance.LogLevel)
			{
				Logger.Instance.Log("TriggerMusicTheme() ignored: Menu Mode is active", LogLevel.warnings);
			}
			return PsaiResult.commandIgnoredMenuModeActive;
		}
		if (m_psaiPlayModeIntended == PsaiPlayMode.cutScene)
		{
			if (LogLevel.warnings <= Logger.Instance.LogLevel)
			{
				Logger.Instance.Log("TriggerMusicTheme() ignored: Cutscene is active", LogLevel.warnings);
			}
			return PsaiResult.commandIgnoredCutsceneActive;
		}
		if (m_psaiPlayMode == PsaiPlayMode.cutScene && m_psaiStateIntended == PsaiState.silence && m_currentSegmentPlaying != null)
		{
			if (LogLevel.info <= Logger.Instance.LogLevel)
			{
				Logger.Instance.Log("special case: Cutscene Theme is still playing, continuing with theme " + argTheme.Name, LogLevel.info);
			}
			m_psaiState = PsaiState.playing;
			m_psaiStateIntended = PsaiState.playing;
			return PlayThemeNowOrAtEndOfCurrentSegmentAndStartEvaluation(argTheme.id, argIntensity, argMusicDuration, immediately: true, holdIntensity: false);
		}
		Segment effectiveSegment = GetEffectiveSegment();
		if (argTheme.themeType == ThemeType.highlightLayer)
		{
			if (effectiveSegment != null && m_effectiveTheme != null && effectiveSegment != null && !effectiveSegment.CheckIfAtLeastOneDirectTransitionOrLayeringIsPossible(m_soundtrack, argTheme.id))
			{
				Logger.Instance.Log(LOGMESSAGE_TRIGGER_DENIED, LogLevel.warnings);
				return PsaiResult.triggerDenied;
			}
			return startHighlight(argTheme);
		}
		if (m_returnToLastBasicMoodFlag && argTheme.themeType != ThemeType.basicMood)
		{
			m_returnToLastBasicMoodFlag = false;
		}
		if (argTheme.themeType == ThemeType.basicMood)
		{
			SetThemeAsLastBasicMood(argTheme);
		}
		if (effectiveSegment == null || m_psaiState == PsaiState.silence || m_psaiState == PsaiState.rest)
		{
			return PlayThemeNowOrAtEndOfCurrentSegmentAndStartEvaluation(argTheme.id, argIntensity, argMusicDuration, immediately: true, holdIntensity: false);
		}
		Theme themeById = m_soundtrack.getThemeById(effectiveSegment.ThemeId);
		if (m_psaiStateIntended == PsaiState.silence && effectiveSegment != null)
		{
			ThemeInterruptionBehavior themeInterruptionBehavior = Theme.GetThemeInterruptionBehavior(themeById.themeType, argTheme.themeType);
			if (themeInterruptionBehavior == ThemeInterruptionBehavior.at_end_of_current_snippet || themeInterruptionBehavior == ThemeInterruptionBehavior.never)
			{
				m_psaiStateIntended = PsaiState.playing;
				return PlayThemeNowOrAtEndOfCurrentSegmentAndStartEvaluation(argTheme.id, argIntensity, argMusicDuration, immediately: false, holdIntensity: false);
			}
		}
		if (effectiveSegment.ThemeId == argTheme.id)
		{
			m_latestEndOfSegmentTriggerCall.themeId = -1;
			SetCurrentIntensityAndMusicDuration(argIntensity, argMusicDuration, recalculateIntensitySlope: true);
			m_psaiStateIntended = PsaiState.playing;
			return PsaiResult.OK;
		}
		switch (argTheme.themeType)
		{
		case ThemeType.basicMood:
			switch (themeById.themeType)
			{
			case ThemeType.basicMood:
				return PlayThemeAtEndOfCurrentSegment(argTheme, argIntensity, argMusicDuration);
			case ThemeType.basicMoodAlt:
				return PsaiResult.OK;
			case ThemeType.dramaticEvent:
				return PsaiResult.OK;
			case ThemeType.action:
				return PsaiResult.OK;
			case ThemeType.shock:
				return PsaiResult.OK;
			}
			break;
		case ThemeType.basicMoodAlt:
			switch (themeById.themeType)
			{
			case ThemeType.basicMood:
				return PlayThemeAtEndOfCurrentSegment(argTheme, argIntensity, argMusicDuration);
			case ThemeType.basicMoodAlt:
				return PlayThemeAtEndOfCurrentSegment(argTheme, argIntensity, argMusicDuration);
			case ThemeType.dramaticEvent:
				return PlayThemeAtEndOfCurrentSegment(argTheme, argIntensity, argMusicDuration);
			case ThemeType.action:
				return PsaiResult.triggerIgnoredLowPriority;
			case ThemeType.shock:
				if (getThemeTypeOfFirstThemeQueueEntry() == ThemeType.action)
				{
					return PsaiResult.triggerIgnoredLowPriority;
				}
				return PlayThemeAtEndOfCurrentSegment(argTheme, argIntensity, argMusicDuration);
			}
			break;
		case ThemeType.dramaticEvent:
			switch (themeById.themeType)
			{
			case ThemeType.basicMood:
				return PlayThemeNowOrAtEndOfCurrentSegmentAndStartEvaluation(argTheme.id, argIntensity, argMusicDuration, immediately: true, holdIntensity: false);
			case ThemeType.basicMoodAlt:
				return PlayThemeNowOrAtEndOfCurrentSegmentAndStartEvaluation(argTheme.id, argIntensity, argMusicDuration, immediately: true, holdIntensity: false);
			case ThemeType.dramaticEvent:
				return PlayThemeAtEndOfCurrentSegment(argTheme, argIntensity, argMusicDuration);
			case ThemeType.action:
				return PsaiResult.triggerIgnoredLowPriority;
			case ThemeType.shock:
				if (getThemeTypeOfFirstThemeQueueEntry() == ThemeType.action)
				{
					return PsaiResult.triggerIgnoredLowPriority;
				}
				return PlayThemeAtEndOfCurrentTheme(argTheme, argIntensity, argMusicDuration);
			}
			break;
		case ThemeType.action:
			switch (themeById.themeType)
			{
			case ThemeType.basicMood:
				ClearLatestEndOfSegmentTriggerCall();
				return PlayThemeNowOrAtEndOfCurrentSegmentAndStartEvaluation(argTheme.id, argIntensity, argMusicDuration, immediately: true, holdIntensity: false);
			case ThemeType.basicMoodAlt:
				ClearLatestEndOfSegmentTriggerCall();
				return PlayThemeNowOrAtEndOfCurrentSegmentAndStartEvaluation(argTheme.id, argIntensity, argMusicDuration, immediately: true, holdIntensity: false);
			case ThemeType.dramaticEvent:
				ClearLatestEndOfSegmentTriggerCall();
				return PlayThemeNowOrAtEndOfCurrentSegmentAndStartEvaluation(argTheme.id, argIntensity, argMusicDuration, immediately: true, holdIntensity: false);
			case ThemeType.action:
				return PlayThemeAtEndOfCurrentSegment(argTheme, argIntensity, argMusicDuration);
			case ThemeType.shock:
				return PlayThemeAtEndOfCurrentTheme(argTheme, argIntensity, argMusicDuration);
			}
			break;
		case ThemeType.shock:
			switch (themeById.themeType)
			{
			case ThemeType.basicMood:
				return PlayThemeNowOrAtEndOfCurrentSegmentAndStartEvaluation(argTheme.id, argIntensity, argMusicDuration, immediately: true, holdIntensity: false);
			case ThemeType.basicMoodAlt:
				return PlayThemeNowOrAtEndOfCurrentSegmentAndStartEvaluation(argTheme.id, argIntensity, argMusicDuration, immediately: true, holdIntensity: false);
			case ThemeType.dramaticEvent:
				return PlayThemeNowOrAtEndOfCurrentSegmentAndStartEvaluation(argTheme.id, argIntensity, argMusicDuration, immediately: true, holdIntensity: false);
			case ThemeType.action:
				ClearQueuedTheme();
				PushEffectiveThemeToThemeQueue(PsaiPlayMode.regular);
				return PlayThemeNowOrAtEndOfCurrentSegmentAndStartEvaluation(argTheme.id, argIntensity, argMusicDuration, immediately: true, holdIntensity: false);
			case ThemeType.shock:
				return PlayThemeAtEndOfCurrentSegment(argTheme, argIntensity, argMusicDuration);
			}
			break;
		}
		if (LogLevel.errors <= Logger.Instance.LogLevel)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("INTERNAL ERROR: end of TriggerMusicTheme() reached without returning a proper returnCode. ");
			stringBuilder.Append("argThemeId=");
			stringBuilder.Append(argTheme.id);
			stringBuilder.Append(" m_currentTheme=");
			stringBuilder.Append(m_effectiveTheme);
			if (m_effectiveTheme != null)
			{
				stringBuilder.Append(" m_currentTheme id=");
				stringBuilder.Append(m_effectiveTheme.id);
				stringBuilder.Append("  m_currentTheme themeType=");
				stringBuilder.Append(m_effectiveTheme.themeType);
			}
			Logger.Instance.Log(stringBuilder.ToString(), LogLevel.errors);
		}
		return PsaiResult.internal_error;
	}

	internal static float ClampPercentValue(float argValue)
	{
		if (argValue > 1f)
		{
			return 1f;
		}
		if (argValue < 0f)
		{
			return 0f;
		}
		return argValue;
	}

	internal PsaiResult AddToCurrentIntensity(float deltaIntensity, bool resetIntensityFalloffToFullMusicDuration)
	{
		if (LogLevel.debug <= Logger.Instance.LogLevel)
		{
			Logger.Instance.Log("AddToCurrentIntensity(" + deltaIntensity + ")", LogLevel.debug);
		}
		if (m_psaiState == PsaiState.playing && m_psaiPlayMode == PsaiPlayMode.regular)
		{
			if (m_latestEndOfSegmentTriggerCall.themeId != -1)
			{
				m_latestEndOfSegmentTriggerCall.startIntensity = ClampPercentValue(m_latestEndOfSegmentTriggerCall.startIntensity + deltaIntensity);
				Logger.Instance.Log("AddToCurrentIntensity(" + deltaIntensity + ") adding to nonInterruptingTrigger.startIntensity=" + m_latestEndOfSegmentTriggerCall.startIntensity, LogLevel.debug);
			}
			else
			{
				float intensity = ClampPercentValue(getCurrentIntensity() + deltaIntensity);
				SetCurrentIntensityAndMusicDuration(intensity, m_lastMusicDuration, resetIntensityFalloffToFullMusicDuration);
			}
			return PsaiResult.OK;
		}
		return PsaiResult.notReady;
	}

	internal PsaiResult PlaySegmentLayeredAndImmediately(int segmentId)
	{
		Segment segmentById = m_soundtrack.GetSegmentById(segmentId);
		if (segmentById != null)
		{
			PlaySegmentLayeredAndImmediately(segmentById);
		}
		return PsaiResult.invalidHandle;
	}

	internal void PlaySegmentLayeredAndImmediately(Segment segment)
	{
		m_hilightVoiceIndex = getNextVoiceNumber(forHighlight: true);
		m_playbackChannels[m_hilightVoiceIndex].StopChannel();
		m_playbackChannels[m_hilightVoiceIndex].ReleaseSegment();
		m_playbackChannels[m_hilightVoiceIndex].FadeOutVolume = 1f;
		m_playbackChannels[m_hilightVoiceIndex].ScheduleSegmentPlayback(segment, s_audioLayerMaximumLatencyForBufferingSounds + s_audioLayerMaximumLatencyForPlayingbackPrebufferedSounds);
	}

	private PsaiResult startHighlight(Theme highlightTheme)
	{
		if (LogLevel.debug <= Logger.Instance.LogLevel)
		{
			Logger.Instance.Log("startHighlight()", LogLevel.debug);
		}
		if (highlightTheme.m_segments.Count > 0)
		{
			Segment segment;
			if (m_currentSegmentPlaying != null)
			{
				segment = GetBestCompatibleSegment(m_currentSegmentPlaying, highlightTheme.id, getCurrentIntensity(), 15);
			}
			else
			{
				int randomInt = GetRandomInt(0, highlightTheme.m_segments.Count);
				segment = m_soundtrack.GetSegmentById(highlightTheme.m_segments[randomInt].Id);
			}
			if (segment != null)
			{
				PlaySegmentLayeredAndImmediately(segment);
				segment.Playcount++;
				return PsaiResult.OK;
			}
			if (LogLevel.warnings <= Logger.Instance.LogLevel)
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append("the triggered Highlight Layer ");
				stringBuilder.Append(highlightTheme.id);
				stringBuilder.Append(" does not contain a compatible Highlight Segment.");
				if (m_currentSegmentPlaying != null)
				{
					stringBuilder.Append(" Current Segment playing:");
					stringBuilder.Append(m_currentSegmentPlaying.Name);
				}
				else
				{
					stringBuilder.Append(" (No Segment is currently playing.)");
				}
				Logger.Instance.Log(stringBuilder.ToString(), LogLevel.warnings);
			}
			return PsaiResult.essential_segment_missing;
		}
		if (LogLevel.warnings <= Logger.Instance.LogLevel)
		{
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("the triggered Highlight Theme ");
			stringBuilder2.Append(highlightTheme.id);
			stringBuilder2.Append(" does not contain any Segments.");
			Logger.Instance.Log(stringBuilder2.ToString(), LogLevel.warnings);
		}
		return PsaiResult.essential_segment_missing;
	}

	private void ClearLatestEndOfSegmentTriggerCall()
	{
		m_latestEndOfSegmentTriggerCall.themeId = -1;
	}

	private void ClearQueuedTheme()
	{
		m_themeQueue.Clear();
	}

	private bool pushThemeToThemeQueue(int themeId, float intensity, int musicDuration, bool clearThemeQueue, int restTimeMillis, PsaiPlayMode playMode, bool holdIntensity)
	{
		if (LogLevel.info <= Logger.Instance.LogLevel)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("setting the Following Theme to ");
			stringBuilder.Append(themeId);
			if (LogLevel.debug <= Logger.Instance.LogLevel)
			{
				stringBuilder.Append("  intensity= ");
				stringBuilder.Append(intensity);
				stringBuilder.Append("  clearThemeQueue=");
				stringBuilder.Append(clearThemeQueue);
				stringBuilder.Append("  playmode=");
				stringBuilder.Append(playMode);
				stringBuilder.Append("  holdIntensity=");
				stringBuilder.Append(holdIntensity);
				stringBuilder.Append("  musicDuration=");
				stringBuilder.Append(musicDuration);
			}
			Logger.Instance.Log(stringBuilder.ToString(), LogLevel.info);
		}
		if (clearThemeQueue)
		{
			m_themeQueue.Clear();
		}
		if (m_soundtrack.getThemeById(themeId) != null)
		{
			ThemeQueueEntry themeQueueEntry = new ThemeQueueEntry();
			themeQueueEntry.themeId = themeId;
			themeQueueEntry.startIntensity = intensity;
			themeQueueEntry.musicDuration = musicDuration;
			themeQueueEntry.restTimeMillis = restTimeMillis;
			themeQueueEntry.playmode = playMode;
			themeQueueEntry.holdIntensity = holdIntensity;
			if (LogLevel.debug <= Logger.Instance.LogLevel)
			{
				StringBuilder stringBuilder2 = new StringBuilder();
				stringBuilder2.Append(" m_themeQueue.size() [before] =");
				stringBuilder2.Append(m_themeQueue.Count);
				for (int i = 0; i < m_themeQueue.Count; i++)
				{
					ThemeQueueEntry themeQueueEntry2 = m_themeQueue[i];
					stringBuilder2.Append("   [");
					stringBuilder2.Append(i);
					stringBuilder2.Append("] themeId=");
					stringBuilder2.Append(themeQueueEntry2.themeId);
					stringBuilder2.Append(" startIntensity=");
					stringBuilder2.Append(themeQueueEntry2.startIntensity);
				}
				Logger.Instance.Log(stringBuilder2.ToString(), LogLevel.debug);
			}
			m_themeQueue.Insert(0, themeQueueEntry);
			m_psaiStateIntended = PsaiState.playing;
			return true;
		}
		return false;
	}

	private ThemeType getThemeTypeOfFirstThemeQueueEntry()
	{
		ThemeQueueEntry followingThemeQueueEntry = getFollowingThemeQueueEntry();
		if (followingThemeQueueEntry != null)
		{
			Theme themeById = m_soundtrack.getThemeById(followingThemeQueueEntry.themeId);
			if (themeById != null)
			{
				return themeById.themeType;
			}
		}
		return ThemeType.none;
	}

	internal float getUpcomingIntensity()
	{
		if (m_psaiState == PsaiState.playing && m_latestEndOfSegmentTriggerCall.themeId != -1)
		{
			return m_latestEndOfSegmentTriggerCall.startIntensity;
		}
		return getCurrentIntensity();
	}

	internal float getCurrentIntensity()
	{
		if (m_paused)
		{
			return m_lastIntensity;
		}
		if (m_psaiState == PsaiState.playing && m_psaiStateIntended == PsaiState.playing && !m_returnToLastBasicMoodFlag)
		{
			if (m_holdIntensity)
			{
				return m_heldIntensity;
			}
			float num = 0f;
			if (m_effectiveTheme == null)
			{
				num = 0f;
			}
			else
			{
				if (m_targetSegment != null && (m_currentSegmentPlaying == null || m_currentSegmentPlaying.ThemeId != m_targetSegment.ThemeId))
				{
					return m_targetSegment.Intensity;
				}
				int num2 = GetTimestampMillisElapsedSinceInitialisation() - m_timeStampOfLastIntensitySetForCurrentTheme;
				num = m_startOrRetriggerIntensityOfCurrentTheme - (float)num2 * m_currentIntensitySlope / 1000f;
				if (num < 0f)
				{
					num = 0f;
				}
			}
			m_lastIntensity = num;
			return num;
		}
		return 0f;
	}

	private PsaiResult PlaySegment(Segment targetSnippet, bool immediately)
	{
		if (LogLevel.debug <= Logger.Instance.LogLevel)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("PlaySegment() name=");
			stringBuilder.Append(targetSnippet.Name);
			stringBuilder.Append("  immediately=");
			stringBuilder.Append(immediately);
			Logger.Instance.Log(stringBuilder.ToString(), LogLevel.debug);
		}
		if (m_initializationFailure)
		{
			Logger.Instance.Log("PlaySegment() - abortion due to initialization failure", LogLevel.errors);
			return PsaiResult.initialization_error;
		}
		m_timerSegmentEndApproaching.Stop();
		m_timerStartSnippetPlayback.Stop();
		m_targetVoice = getNextVoiceNumber(forHighlight: false);
		PsaiResult psaiResult = LoadSegment(targetSnippet, m_targetVoice);
		PsaiErrorCheck(psaiResult, "LoadSegment()");
		if (psaiResult != PsaiResult.OK)
		{
			string argText = string.Format("LoadSegment failed. {0} was the current segment {1} was the theme", (m_currentSegmentPlaying == null) ? "null" : m_currentSegmentPlaying.Name, (m_effectiveTheme == null) ? "null" : m_effectiveTheme.Name);
			Logger.Instance.Log(argText, LogLevel.errors);
			return psaiResult;
		}
		int num = 0;
		m_targetSegment = targetSnippet;
		if (immediately || m_currentSegmentPlaying == null)
		{
			if (m_playbackChannels[m_targetVoice].CheckIfSegmentHadEnoughTimeToLoad())
			{
				m_estimatedTimestampOfTargetSnippetPlayback = GetTimestampMillisElapsedSinceInitialisation() + s_audioLayerMaximumLatencyForPlayingbackPrebufferedSounds;
			}
			else
			{
				m_estimatedTimestampOfTargetSnippetPlayback = GetTimestampMillisElapsedSinceInitialisation() + s_audioLayerMaximumLatencyForPlayingBackUnbufferedSounds;
			}
			PlayTargetSegmentImmediately();
		}
		else
		{
			int millisElapsedAfterCurrentSnippetPlaycall = GetMillisElapsedAfterCurrentSnippetPlaycall();
			num = m_currentSegmentPlaying.audioData.GetFullLengthInMilliseconds() - m_currentSegmentPlaying.audioData.GetPostBeatZoneInMilliseconds() - targetSnippet.audioData.GetPreBeatZoneInMilliseconds() - millisElapsedAfterCurrentSnippetPlaycall;
			if (num > s_audioLayerMaximumLatencyForPlayingBackUnbufferedSounds)
			{
				m_estimatedTimestampOfTargetSnippetPlayback = GetTimestampMillisElapsedSinceInitialisation() + num;
				m_timerStartSnippetPlayback.SetTimer(num, s_audioLayerMaximumLatencyForPlayingbackPrebufferedSounds);
				if (LogLevel.debug <= Logger.Instance.LogLevel)
				{
					StringBuilder stringBuilder2 = new StringBuilder();
					stringBuilder2.Append("m_timerStartSnippetPlayback set to ");
					stringBuilder2.Append(num);
					stringBuilder2.Append("  m_estimatedTimestampOfTargetSnippetPlayback set to ");
					stringBuilder2.Append(m_estimatedTimestampOfTargetSnippetPlayback);
					stringBuilder2.Append("  millisElapsed after current snippet playcall=");
					stringBuilder2.Append(millisElapsedAfterCurrentSnippetPlaycall);
					Logger.Instance.Log(stringBuilder2.ToString(), LogLevel.debug);
				}
			}
			else
			{
				if (LogLevel.debug <= Logger.Instance.LogLevel)
				{
					StringBuilder stringBuilder3 = new StringBuilder();
					stringBuilder3.Append("!!! millisUntilNextSnippetPlayback=");
					stringBuilder3.Append(num);
					stringBuilder3.Append("  so we're playing immediately !");
					stringBuilder3.Append("  s_audioLayerMaximumLatencyForPlayingBackUnbufferedSounds=");
					stringBuilder3.Append(s_audioLayerMaximumLatencyForPlayingBackUnbufferedSounds);
					stringBuilder3.Append("  m_currentSegmentPlaying->FullLengthInMs=");
					stringBuilder3.Append(m_currentSegmentPlaying.audioData.GetFullLengthInMilliseconds());
					stringBuilder3.Append("  m_currentSnippetPlaying->PostBeatMs=");
					stringBuilder3.Append(m_currentSegmentPlaying.audioData.GetPostBeatZoneInMilliseconds());
					stringBuilder3.Append("  targetSnippet->PreBeatMs=");
					stringBuilder3.Append(targetSnippet.audioData.GetPreBeatZoneInMilliseconds());
					stringBuilder3.Append("  m_timeStampCurrentSnippetPlaycall=");
					stringBuilder3.Append(m_timeStampCurrentSnippetPlaycall);
					Logger.Instance.Log(stringBuilder3.ToString(), LogLevel.debug);
				}
				m_estimatedTimestampOfTargetSnippetPlayback = GetTimestampMillisElapsedSinceInitialisation() + s_audioLayerMaximumLatencyForPlayingbackPrebufferedSounds;
				PlayTargetSegmentImmediately();
			}
		}
		return PsaiResult.OK;
	}

	private PsaiResult LoadSegment(Segment snippet, int channelIndex)
	{
		if (snippet == null || channelIndex >= PSAI_CHANNEL_COUNT)
		{
			return PsaiResult.invalidHandle;
		}
		m_playbackChannels[channelIndex].LoadSegment(snippet);
		return PsaiResult.OK;
	}

	private void PlayTargetSegmentImmediately()
	{
		if (LogLevel.debug <= Logger.Instance.LogLevel)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("PlayTargetSegmentImmediately()  m_targetSegmentTypesRequested=");
			stringBuilder.Append(Segment.GetStringFromSegmentSuitabilities(m_targetSegmentSuitabilitiesRequested));
			stringBuilder.Append("  targetSegment=");
			stringBuilder.Append(m_targetSegment.Name);
			stringBuilder.Append("  id=");
			stringBuilder.Append(m_targetSegment.Id);
			stringBuilder.Append("  m_targetVoice=");
			stringBuilder.Append(m_targetVoice);
			stringBuilder.Append("  themeId=");
			stringBuilder.Append(m_targetSegment.ThemeId);
			stringBuilder.Append("  playbackChannel.Segment=");
			stringBuilder.Append(m_playbackChannels[m_targetVoice].Segment.Name);
			stringBuilder.Append("  millisSinceSegmentLoad=");
			stringBuilder.Append(m_playbackChannels[m_targetVoice].GetMillisecondsSinceSegmentLoad());
			Logger.Instance.Log(stringBuilder.ToString(), LogLevel.debug);
		}
		int num = 0;
		if (m_playbackChannels[m_targetVoice].CheckIfSegmentHadEnoughTimeToLoad())
		{
			num = m_estimatedTimestampOfTargetSnippetPlayback - GetTimestampMillisElapsedSinceInitialisation();
			if (LogLevel.debug <= Logger.Instance.LogLevel)
			{
				Logger.Instance.Log("Segment had enough time to load.   m_estimatedTimestampOfTargetSnippetPlayback=" + m_estimatedTimestampOfTargetSnippetPlayback, LogLevel.debug);
			}
		}
		else
		{
			int millisecondsUntilLoadingWillHaveFinished = m_playbackChannels[m_targetVoice].GetMillisecondsUntilLoadingWillHaveFinished();
			if (LogLevel.debug <= Logger.Instance.LogLevel)
			{
				Logger.Instance.Log("Segment DID NOT have enough time to load!  missing milliSeconds=" + millisecondsUntilLoadingWillHaveFinished, LogLevel.debug);
			}
			num = millisecondsUntilLoadingWillHaveFinished + s_audioLayerMaximumLatencyForPlayingbackPrebufferedSounds;
		}
		m_playbackChannels[m_targetVoice].FadeOutVolume = 1f;
		m_playbackChannels[m_targetVoice].ScheduleSegmentPlayback(m_targetSegment, num);
		if (m_scheduleFadeoutUponSnippetPlayback)
		{
			startFade(m_currentVoiceNumber, PSAI_FADEOUTMILLIS_PLAYIMMEDIATELY, m_targetSegment.audioData.GetPreBeatZoneInMilliseconds() + num);
			m_scheduleFadeoutUponSnippetPlayback = false;
		}
		m_psaiPlayMode = m_psaiPlayModeIntended;
		m_currentVoiceNumber = m_targetVoice;
		m_currentSegmentPlaying = m_targetSegment;
		m_currentSnippetTypeRequested = m_targetSegmentSuitabilitiesRequested;
		m_currentSegmentPlaying.Playcount++;
		SetSegmentEndApproachingAndReachedTimersAfterPlaybackHasStarted(num);
		m_targetSegment = null;
		m_psaiState = PsaiState.playing;
	}

	internal void SetSegmentEndApproachingAndReachedTimersAfterPlaybackHasStarted(int snippetPlaybackDelayMillis)
	{
		m_timeStampCurrentSnippetPlaycall = GetTimestampMillisElapsedSinceInitialisation() + snippetPlaybackDelayMillis;
		int num = m_currentSegmentPlaying.audioData.GetFullLengthInMilliseconds() + snippetPlaybackDelayMillis;
		int num2 = num - m_currentSegmentPlaying.audioData.GetPostBeatZoneInMilliseconds() - m_currentSegmentPlaying.MaxPreBeatMsOfCompatibleSnippetsWithinSameTheme - s_audioLayerMaximumLatencyForPlayingBackUnbufferedSounds - 2 * s_updateIntervalMillis;
		if (num2 < 0)
		{
			if (LogLevel.warnings <= Logger.Instance.LogLevel)
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append(" psai did not have enough time to evaluate the next Segment in time (missing milliseconds: ");
				stringBuilder.Append(num2);
				stringBuilder.Append(").");
				stringBuilder.Append(" This means that either 1.) Your playback and buffer latency settings are set too high (in Unity: see PsaiCoreManager) , or 2.) The main region of Segment '");
				stringBuilder.Append(m_currentSegmentPlaying.Name);
				stringBuilder.Append("' (ThemeId=");
				stringBuilder.Append(m_currentSegmentPlaying.ThemeId);
				stringBuilder.Append(") is too short, or 3.) The Prebeat region of at least one of its compatible Segments is too long. ");
				stringBuilder.Append("See the 'best practice' section in the psai manual for more information.");
				Logger.Instance.Log(stringBuilder.ToString(), LogLevel.warnings);
			}
			num2 = 0;
		}
		m_timerSegmentEndApproaching.SetTimer(num2, s_updateIntervalMillis);
		m_timerSegmentEndReached.SetTimer(num, 0);
	}

	internal float getVolume()
	{
		return m_psaiMasterVolume;
	}

	internal void setVolume(float vol)
	{
		m_psaiMasterVolume = vol;
		if ((double)vol > 1.0)
		{
			m_psaiMasterVolume = 1f;
			Logger.Instance.Log("Invalid volume level! please enter values between 0.0 and 1.0. Volume was set to 1.0f.", LogLevel.warnings);
		}
		else if (vol < 0f)
		{
			m_psaiMasterVolume = 0f;
			Logger.Instance.Log("Invalid volume level! please enter values between 0.0 and 1.0. Volume was set to 0.0f.", LogLevel.warnings);
		}
		for (int i = 0; i < m_playbackChannels.Length; i++)
		{
			m_playbackChannels[i].MasterVolume = m_psaiMasterVolume;
		}
	}

	private PsaiResult PlayThemeNowOrAtEndOfCurrentSegmentAndStartEvaluation(ThemeQueueEntry tqe, bool immediately)
	{
		return PlayThemeNowOrAtEndOfCurrentSegmentAndStartEvaluation(tqe.themeId, tqe.startIntensity, tqe.musicDuration, immediately, tqe.holdIntensity);
	}

	private PsaiResult PlayThemeNowOrAtEndOfCurrentSegmentAndStartEvaluation(int themeId, float intensity, int musicDuration, bool immediately, bool holdIntensity)
	{
		if (LogLevel.debug <= Logger.Instance.LogLevel)
		{
			Theme themeById = m_soundtrack.getThemeById(themeId);
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("PlayThemeNowOrAtEndOfCurrentSegment()  themeId=");
			stringBuilder.Append(themeId);
			if (themeById == null)
			{
				stringBuilder.Append("THEME NOT FOUND!");
			}
			else
			{
				stringBuilder.Append(" [");
				stringBuilder.Append(themeById.Name);
				stringBuilder.Append("]  themeType=");
				stringBuilder.Append(themeById.themeType);
			}
			stringBuilder.Append(" intensity=");
			stringBuilder.Append(intensity);
			stringBuilder.Append(" immediately=");
			stringBuilder.Append(immediately);
			stringBuilder.Append(" holdIntensity=");
			stringBuilder.Append(holdIntensity);
			stringBuilder.Append(" musicDuration=");
			stringBuilder.Append(musicDuration);
			stringBuilder.Append(" m_currentSegmentPlaying=");
			stringBuilder.Append(m_currentSegmentPlaying);
			Logger.Instance.Log(stringBuilder.ToString(), LogLevel.debug);
		}
		SetCurrentIntensityAndMusicDuration(intensity, musicDuration, recalculateIntensitySlope: true);
		m_psaiStateIntended = PsaiState.playing;
		m_heldIntensity = intensity;
		if (m_psaiState == PsaiState.rest)
		{
			m_timerWakeUpFromRest.Stop();
		}
		m_targetSegmentSuitabilitiesRequested = 1;
		if (m_psaiState == PsaiState.playing && m_currentSegmentPlaying != null)
		{
			if (m_currentSegmentPlaying.IsUsableOnlyAs(SegmentSuitability.end))
			{
				m_targetSegmentSuitabilitiesRequested = 1;
			}
			else if (getEffectiveThemeId() == themeId)
			{
				m_targetSegmentSuitabilitiesRequested = 2;
			}
			else
			{
				m_targetSegmentSuitabilitiesRequested = SNIPPET_TYPE_MIDDLE_OR_BRIDGE;
			}
		}
		m_effectiveTheme = m_soundtrack.getThemeById(themeId);
		Segment segment = (((m_targetSegmentSuitabilitiesRequested & 1) <= 0 && GetEffectiveSegment() != null) ? GetBestCompatibleSegment(GetEffectiveSegment(), themeId, intensity, m_targetSegmentSuitabilitiesRequested) : GetBestStartSegmentForTheme(themeId, intensity));
		if (segment == null)
		{
			Logger.Instance.Log("essential Segment could not be found! Trying to substitute...", LogLevel.errors);
			segment = substituteSegment(themeId);
			if (segment == null)
			{
				Logger.Instance.Log("failed to substitute Segment. Stopping music.", LogLevel.errors);
				StopMusic(immediately: true);
				return PsaiResult.essential_segment_missing;
			}
		}
		m_holdIntensity = holdIntensity;
		if (immediately && GetEffectiveSegment() != null)
		{
			m_scheduleFadeoutUponSnippetPlayback = true;
		}
		if (segment != null)
		{
			return PlaySegment(segment, immediately);
		}
		Logger.Instance.Log("fatal internal error! entered code section in PlayTheme that is supposed to be unreachable!", LogLevel.errors);
		return PsaiResult.internal_error;
	}

	internal PsaiResult StopMusic(bool immediately)
	{
		return StopMusic(immediately, PSAI_FADEOUTMILLIS_STOPMUSIC);
	}

	internal PsaiResult StopMusic(bool immediately, int fadeOutMilliSeconds)
	{
		if (LogLevel.info <= Logger.Instance.LogLevel)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("StopMusic(");
			stringBuilder.Append(immediately);
			stringBuilder.Append(") called. ");
			if (immediately)
			{
				stringBuilder.Append("  fadeout-time (ms): " + fadeOutMilliSeconds);
			}
			Logger.Instance.Log(stringBuilder.ToString(), LogLevel.info);
		}
		if (immediately && fadeOutMilliSeconds <= 0)
		{
			fadeOutMilliSeconds = PSAI_FADEOUTMILLIS_STOPMUSIC;
			if (LogLevel.warnings <= Logger.Instance.LogLevel)
			{
				StringBuilder stringBuilder2 = new StringBuilder();
				stringBuilder2.Append("invalid argument: the StopMusic fadeout-time was negative, and thus has been set to the default value of ");
				stringBuilder2.Append(fadeOutMilliSeconds);
				stringBuilder2.Append(" ms.");
				Logger.Instance.Log(stringBuilder2.ToString(), LogLevel.warnings);
			}
		}
		if (m_paused)
		{
			setPaused(setPaused: false);
		}
		ClearLatestEndOfSegmentTriggerCall();
		ClearQueuedTheme();
		if (m_psaiPlayMode == PsaiPlayMode.menuMode)
		{
			if (LogLevel.warnings <= Logger.Instance.LogLevel)
			{
				Logger.Instance.Log("StopMusic() ignored: Menu Mode is active", LogLevel.warnings);
			}
			return PsaiResult.commandIgnoredMenuModeActive;
		}
		if (m_psaiPlayModeIntended == PsaiPlayMode.cutScene)
		{
			if (LogLevel.info <= Logger.Instance.LogLevel)
			{
				Logger.Instance.Log("StopMusic() ignored: Cutscene is active", LogLevel.info);
			}
			return PsaiResult.commandIgnoredCutsceneActive;
		}
		if (m_initializationFailure)
		{
			Logger.Instance.Log(LOGMESSAGE_ABORTION_DUE_TO_INITIALIZATION_FAILURE, LogLevel.errors);
			return PsaiResult.initialization_error;
		}
		if (m_psaiStateIntended == PsaiState.silence && !immediately)
		{
			if (LogLevel.info <= Logger.Instance.LogLevel)
			{
				Logger.Instance.Log("StopMusic() ignored - psai is currently already in silent mode", LogLevel.info);
			}
			return PsaiResult.commandIgnored;
		}
		m_returnToLastBasicMoodFlag = false;
		m_holdIntensity = false;
		switch (m_psaiState)
		{
		case PsaiState.silence:
		case PsaiState.playing:
		{
			if (GetEffectiveSegment() == null)
			{
				break;
			}
			bool flag = false;
			if (!immediately)
			{
				flag = CheckIfThereIsAPathToEndSegmentForEffectiveSegmentAndLogWarningIfThereIsnt();
			}
			if (immediately || !flag)
			{
				startFade(m_currentVoiceNumber, fadeOutMilliSeconds, 0);
				EnterSilenceMode();
				break;
			}
			WriteLogWarningIfThereIsNoDirectPathForEffectiveSnippetToEndSnippet();
			if (m_latestEndOfSegmentTriggerCall.themeId != -1)
			{
				m_latestEndOfSegmentTriggerCall.themeId = -1;
				if (LogLevel.debug <= Logger.Instance.LogLevel)
				{
					Logger.Instance.Log("cleared noninterrupting trigger", LogLevel.debug);
				}
			}
			m_psaiStateIntended = PsaiState.silence;
			break;
		}
		case PsaiState.rest:
			EnterSilenceMode();
			break;
		}
		return PsaiResult.OK;
	}

	private void WriteLogWarningIfThereIsNoDirectPathForEffectiveSnippetToEndSnippet()
	{
		if (LogLevel.warnings <= Logger.Instance.LogLevel)
		{
			Segment effectiveSegment = GetEffectiveSegment();
			if (effectiveSegment == null)
			{
				Logger.Instance.Log("INTERNAL WARNING: WriteLogWarningIfThereIsNoDirectPathForEffectiveSnippetToEndSnippet() effectiveSnippet is NULL.", LogLevel.debug);
			}
			else if (effectiveSegment.nextSnippetToShortestEndSequence == null)
			{
				Logger.Instance.Log("INTERNAL WARNING: WriteLogWarningIfThereIsNoDirectPathForEffectiveSnippetToEndSnippet() effectiveSnippet->nextSnippetToShortestEndSequence is NULL.", LogLevel.debug);
			}
			else if ((effectiveSegment.nextSnippetToShortestEndSequence.SnippetTypeBitfield & 4) == 0)
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append("There is no direct path to an END-Segment from the current Segment, thus psai will play an indirection via Segment: ");
				stringBuilder.Append(effectiveSegment.nextSnippetToShortestEndSequence.Name);
				stringBuilder.Append(" Please add a direct compatible Transition to an END-Segment for Segment ");
				stringBuilder.Append(effectiveSegment.Name);
				stringBuilder.Append(" to have psai end the Theme more quickly.");
				Logger.Instance.Log(stringBuilder.ToString(), LogLevel.warnings);
			}
		}
	}

	private bool CheckIfThereIsAPathToEndSegmentForEffectiveSegmentAndLogWarningIfThereIsnt()
	{
		Segment effectiveSegment = GetEffectiveSegment();
		if (!effectiveSegment.IsUsableAs(SegmentSuitability.end) && effectiveSegment.nextSnippetToShortestEndSequence == null)
		{
			if (LogLevel.warnings <= Logger.Instance.LogLevel)
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append("There is no direct or indirect path to an END-Segment from the Segment currently playing, thus psai has to fade out immediately. Please add a compatible transition to an END-Segment for Segment: ");
				stringBuilder.Append(effectiveSegment.Name);
				Logger.Instance.Log(stringBuilder.ToString(), LogLevel.warnings);
			}
			return false;
		}
		return true;
	}

	private void updateFades()
	{
		bool flag = false;
		int num = GetTimestampMillisElapsedSinceInitialisation() - m_timeStampOfLastFadeUpdate;
		m_timeStampOfLastFadeUpdate = GetTimestampMillisElapsedSinceInitialisation();
		int num2 = 0;
		while (num2 < m_fadeVoices.Count)
		{
			FadeData fadeData = m_fadeVoices[num2];
			if (fadeData.delayMillis > 0)
			{
				fadeData.delayMillis -= num;
				if (fadeData.delayMillis <= 0)
				{
					fadeData.delayMillis = 0;
				}
				flag = true;
				num2++;
				continue;
			}
			float num3 = fadeData.currentVolume - fadeData.fadeoutDeltaVolumePerUpdate;
			if (num3 > 0f)
			{
				flag = true;
				fadeData.currentVolume = num3;
				m_playbackChannels[fadeData.voiceNumber].FadeOutVolume = num3;
				num2++;
				continue;
			}
			int voiceNumber = fadeData.voiceNumber;
			if (m_playbackChannels[voiceNumber].IsPlaying())
			{
				m_playbackChannels[voiceNumber].StopChannel();
				m_playbackChannels[voiceNumber].ReleaseSegment();
				m_fadeVoices.RemoveAt(num2);
			}
			else
			{
				m_fadeVoices.RemoveAt(num2);
			}
		}
		if (flag)
		{
			m_timerFades.SetTimer(PSAI_FADING_UPDATE_INVERVAL_MILLIS, 0);
		}
	}

	internal PsaiResult HoldCurrentIntensity(bool hold)
	{
		if (LogLevel.info <= Logger.Instance.LogLevel)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("HoldCurrentIntensity() hold=");
			stringBuilder.Append(hold);
			Logger.Instance.Log(stringBuilder.ToString(), LogLevel.info);
		}
		switch (m_psaiPlayModeIntended)
		{
		case PsaiPlayMode.cutScene:
			return PsaiResult.commandIgnoredCutsceneActive;
		case PsaiPlayMode.menuMode:
			return PsaiResult.commandIgnoredMenuModeActive;
		case PsaiPlayMode.regular:
			if (hold && m_holdIntensity)
			{
				if (LogLevel.warnings <= Logger.Instance.LogLevel)
				{
					Logger.Instance.Log("HoldCurrentIntensity(true) - ignored because the intensity is already being held", LogLevel.warnings);
				}
				return PsaiResult.commandIgnored;
			}
			if (!hold && !m_holdIntensity)
			{
				if (LogLevel.warnings <= Logger.Instance.LogLevel)
				{
					Logger.Instance.Log("HoldCurrentIntensity(false) - ignored because the intensity is already decreasing", LogLevel.warnings);
				}
				return PsaiResult.commandIgnored;
			}
			if (hold)
			{
				if (LogLevel.info <= Logger.Instance.LogLevel)
				{
					Logger.Instance.Log("intensity for the current Theme is being held on a constant level", LogLevel.info);
				}
				m_remainingMusicDurationAtTimeOfHoldIntensity = GetRemainingMusicDurationSecondsOfCurrentTheme();
				if (LogLevel.debug <= Logger.Instance.LogLevel)
				{
					StringBuilder stringBuilder2 = new StringBuilder();
					stringBuilder2.Append("m_remainingMusicDurationAtTimeOfHoldIntensity=");
					stringBuilder2.Append(m_remainingMusicDurationAtTimeOfHoldIntensity);
					Logger.Instance.Log(stringBuilder2.ToString(), LogLevel.debug);
				}
				m_heldIntensity = getCurrentIntensity();
				m_holdIntensity = true;
			}
			else
			{
				if (LogLevel.info <= Logger.Instance.LogLevel)
				{
					StringBuilder stringBuilder3 = new StringBuilder();
					stringBuilder3.Append("automatic descrease of intensity is reactivated, remaining music duration=");
					stringBuilder3.Append(m_remainingMusicDurationAtTimeOfHoldIntensity);
					Logger.Instance.Log(stringBuilder3.ToString(), LogLevel.info);
				}
				SetCurrentIntensityAndMusicDuration(m_heldIntensity, m_remainingMusicDurationAtTimeOfHoldIntensity, recalculateIntensitySlope: false);
				m_holdIntensity = false;
			}
			return PsaiResult.OK;
		default:
			return PsaiResult.internal_error;
		}
	}

	private void SetCurrentIntensityAndMusicDuration(float intensity, int musicDuration, bool recalculateIntensitySlope)
	{
		if (LogLevel.debug <= Logger.Instance.LogLevel)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("SetCurrentIntensityAndMusicDuration()  intensity=");
			stringBuilder.Append(intensity);
			stringBuilder.Append("  musicDuration=");
			stringBuilder.Append(musicDuration);
			stringBuilder.Append("  recalculateIntensitySlope=");
			stringBuilder.Append(recalculateIntensitySlope);
			Logger.Instance.Log(stringBuilder.ToString(), LogLevel.debug);
		}
		m_timeStampOfLastIntensitySetForCurrentTheme = GetTimestampMillisElapsedSinceInitialisation();
		m_lastMusicDuration = musicDuration;
		if (recalculateIntensitySlope)
		{
			m_currentIntensitySlope = intensity / (float)musicDuration;
		}
		m_startOrRetriggerIntensityOfCurrentTheme = intensity;
	}

	private void SegmentEndApproachingHandler()
	{
		if (LogLevel.debug <= Logger.Instance.LogLevel)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("--- SegmentEndApproachingHandler()  m_psaiStateIntended=");
			stringBuilder.Append(m_psaiStateIntended);
			stringBuilder.Append("  m_nonInterruptingTriggerOfHighestPriority.themeId=");
			stringBuilder.Append(m_latestEndOfSegmentTriggerCall.themeId);
			Logger.Instance.Log(stringBuilder.ToString(), LogLevel.debug);
		}
		if (m_latestEndOfSegmentTriggerCall.themeId != -1)
		{
			m_psaiState = PsaiState.playing;
			m_psaiStateIntended = PsaiState.playing;
		}
		switch (m_psaiStateIntended)
		{
		case PsaiState.silence:
			if (m_currentSegmentPlaying == null || m_currentSegmentPlaying.IsUsableAs(SegmentSuitability.end))
			{
				EnterSilenceMode();
			}
			else
			{
				PlaySegment(m_currentSegmentPlaying.nextSnippetToShortestEndSequence, immediately: false);
			}
			return;
		case PsaiState.rest:
			if (m_currentSegmentPlaying == null || m_currentSegmentPlaying.IsUsableAs(SegmentSuitability.end))
			{
				if (m_psaiState != PsaiState.rest)
				{
					EnterRestMode(GetLastBasicMoodId(), getEffectiveThemeId());
				}
			}
			else
			{
				PlaySegment(m_currentSegmentPlaying.nextSnippetToShortestEndSequence, immediately: false);
			}
			return;
		}
		if (m_returnToLastBasicMoodFlag)
		{
			if (LogLevel.debug <= Logger.Instance.LogLevel)
			{
				Logger.Instance.Log("returnToLastBasicMoodFlag was set", LogLevel.debug);
			}
			if ((m_currentSegmentPlaying.SnippetTypeBitfield & 4) == 0 && CheckIfThereIsAPathToEndSegmentForEffectiveSegmentAndLogWarningIfThereIsnt())
			{
				WriteLogWarningIfThereIsNoDirectPathForEffectiveSnippetToEndSnippet();
				PlaySegment(m_currentSegmentPlaying.nextSnippetToShortestEndSequence, immediately: false);
			}
			else
			{
				PlayThemeNowOrAtEndOfCurrentSegmentAndStartEvaluation(GetLastBasicMoodId(), m_lastBasicMood.intensityAfterRest, m_lastBasicMood.musicDurationGeneral, immediately: false, holdIntensity: false);
				m_returnToLastBasicMoodFlag = false;
			}
		}
		else if (m_psaiPlayMode == PsaiPlayMode.regular && m_latestEndOfSegmentTriggerCall.themeId != -1)
		{
			Theme themeById = m_soundtrack.getThemeById(m_latestEndOfSegmentTriggerCall.themeId);
			if (m_currentSegmentPlaying.CheckIfAtLeastOneDirectTransitionOrLayeringIsPossible(m_soundtrack, themeById.id))
			{
				PlayThemeNowOrAtEndOfCurrentSegmentAndStartEvaluation(m_latestEndOfSegmentTriggerCall.themeId, m_latestEndOfSegmentTriggerCall.startIntensity, m_latestEndOfSegmentTriggerCall.musicDuration, immediately: false, m_latestEndOfSegmentTriggerCall.holdIntensity);
				m_latestEndOfSegmentTriggerCall.themeId = -1;
			}
			else if (m_currentSegmentPlaying.MapOfNextTransitionSegmentToTheme.ContainsKey(themeById.id))
			{
				if (LogLevel.info <= Logger.Instance.LogLevel)
				{
					StringBuilder stringBuilder2 = new StringBuilder();
					stringBuilder2.Append("No direct transition exists from Segment ");
					stringBuilder2.Append(m_currentSegmentPlaying.Name);
					stringBuilder2.Append(" to any MIDDLE or BRIDGE Segment of Theme ");
					stringBuilder2.Append(themeById.Name);
					stringBuilder2.Append(", psai is therefore playing an indirect transition via the shortest path of compatible Segments. The next one will be ");
					stringBuilder2.Append(m_currentSegmentPlaying.MapOfNextTransitionSegmentToTheme[themeById.id]);
					Logger.Instance.Log(stringBuilder2.ToString(), LogLevel.info);
				}
				PlaySegment(m_currentSegmentPlaying.MapOfNextTransitionSegmentToTheme[themeById.id], immediately: false);
			}
			else
			{
				if (LogLevel.warnings <= Logger.Instance.LogLevel)
				{
					StringBuilder stringBuilder3 = new StringBuilder();
					stringBuilder3.Append("Could not perform any transition from Segment ");
					stringBuilder3.Append(m_currentSegmentPlaying.Name);
					stringBuilder3.Append(" to Theme ");
					stringBuilder3.Append(themeById.Name);
					stringBuilder3.Append(" as no direct or indirect path of compatible Segments exists. Psai is therefore switching Themes by crossfading.");
					Logger.Instance.Log(stringBuilder3.ToString(), LogLevel.warnings);
				}
				PlayThemeNowOrAtEndOfCurrentSegmentAndStartEvaluation(m_latestEndOfSegmentTriggerCall.themeId, m_latestEndOfSegmentTriggerCall.startIntensity, m_latestEndOfSegmentTriggerCall.musicDuration, immediately: true, m_latestEndOfSegmentTriggerCall.holdIntensity);
				m_latestEndOfSegmentTriggerCall.themeId = -1;
			}
		}
		else if (getCurrentIntensity() > 0f)
		{
			m_latestEndOfSegmentTriggerCall.themeId = -1;
			PlaySegmentOfCurrentTheme(SegmentSuitability.middle);
		}
		else
		{
			IntensityZeroHandler();
		}
	}

	private PsaiResult PlayThemeAtEndOfCurrentSegment(Theme argTheme, float intensity, int musicDuration)
	{
		if (LogLevel.debug <= Logger.Instance.LogLevel)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("PlayThemeAtEndOfCurrentSegment() argTheme=");
			stringBuilder.Append(argTheme.Name);
			stringBuilder.Append("  intensity=");
			stringBuilder.Append(intensity);
			stringBuilder.Append("  musicDuration=");
			stringBuilder.Append(musicDuration);
			Logger.Instance.Log(stringBuilder.ToString(), LogLevel.debug);
		}
		m_latestEndOfSegmentTriggerCall.themeId = argTheme.id;
		m_latestEndOfSegmentTriggerCall.startIntensity = intensity;
		m_latestEndOfSegmentTriggerCall.musicDuration = musicDuration;
		m_psaiStateIntended = PsaiState.playing;
		return PsaiResult.OK;
	}

	private PsaiResult PlayThemeAtEndOfCurrentTheme(Theme argTheme, float argIntensity, int argMusicDuration)
	{
		ClearLatestEndOfSegmentTriggerCall();
		ClearQueuedTheme();
		pushThemeToThemeQueue(argTheme.id, argIntensity, argMusicDuration, clearThemeQueue: false, 1, PsaiPlayMode.regular, holdIntensity: false);
		return PsaiResult.OK;
	}

	private void SegmentEndReachedHandler()
	{
		if (LogLevel.debug <= Logger.Instance.LogLevel)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("SegmentEndReachedHandler() m_psaiStateIntended=");
			stringBuilder.Append(m_psaiStateIntended);
			Logger.Instance.Log(stringBuilder.ToString(), LogLevel.debug);
		}
		if (m_targetSegment == null)
		{
			m_currentSegmentPlaying = null;
		}
	}

	private void InitiateTransitionToRestOrSilence(PsaiState psaiStateIntended)
	{
		if (psaiStateIntended == PsaiState.rest || psaiStateIntended == PsaiState.silence)
		{
			if (m_currentSegmentPlaying != null)
			{
				if (m_currentSegmentPlaying.IsUsableAs(SegmentSuitability.end))
				{
					EnterRestMode(GetLastBasicMoodId(), getEffectiveThemeId());
				}
				else if (!CheckIfThereIsAPathToEndSegmentForEffectiveSegmentAndLogWarningIfThereIsnt())
				{
					startFade(m_currentVoiceNumber, GetRemainingMillisecondsOfCurrentSegmentPlayback(), 0);
					EnterRestMode(GetLastBasicMoodId(), getEffectiveThemeId());
				}
				else
				{
					WriteLogWarningIfThereIsNoDirectPathForEffectiveSnippetToEndSnippet();
					PlaySegment(m_currentSegmentPlaying.nextSnippetToShortestEndSequence, immediately: false);
					m_psaiStateIntended = psaiStateIntended;
				}
			}
		}
		else if (LogLevel.errors <= Logger.Instance.LogLevel)
		{
			Logger.Instance.Log("internal error: wrong argument", LogLevel.errors);
		}
	}

	private void InitiateTransitionToRestMode()
	{
		if (LogLevel.info <= Logger.Instance.LogLevel)
		{
			Logger.Instance.Log("initiating transition to rest", LogLevel.info);
		}
		InitiateTransitionToRestOrSilence(PsaiState.rest);
	}

	private void IntensityZeroHandler()
	{
		if (LogLevel.debug <= Logger.Instance.LogLevel)
		{
			Logger.Instance.Log("IntensityZeroHandler()", LogLevel.debug);
		}
		if (m_currentSegmentPlaying == null)
		{
			return;
		}
		switch (m_soundtrack.getThemeById(m_currentSegmentPlaying.ThemeId).themeType)
		{
		case ThemeType.basicMood:
			InitiateTransitionToRestMode();
			break;
		case ThemeType.action:
			if (m_lastBasicMood == null)
			{
				InitiateTransitionToRestOrSilence(PsaiState.silence);
			}
			else
			{
				InitiateTransitionToRestMode();
			}
			break;
		case ThemeType.basicMoodAlt:
		case ThemeType.dramaticEvent:
			if (m_lastBasicMood != null)
			{
				PlayThemeNowOrAtEndOfCurrentSegmentAndStartEvaluation(m_lastBasicMood.id, m_lastBasicMood.intensityAfterRest, m_lastBasicMood.musicDurationAfterRest, immediately: false, holdIntensity: false);
				break;
			}
			Logger.Instance.Log("m_lastBasicMood is null", LogLevel.debug);
			InitiateTransitionToRestOrSilence(PsaiState.silence);
			break;
		case ThemeType.shock:
		{
			ThemeQueueEntry followingThemeQueueEntry = getFollowingThemeQueueEntry();
			if (followingThemeQueueEntry != null)
			{
				if (LogLevel.debug <= Logger.Instance.LogLevel)
				{
					string value = "NOT FOUND";
					Theme themeById = m_soundtrack.getThemeById(followingThemeQueueEntry.themeId);
					if (themeById != null)
					{
						value = themeById.Name;
					}
					StringBuilder stringBuilder = new StringBuilder();
					stringBuilder.Append("found following Theme Queue Entry: themeId=");
					stringBuilder.Append(followingThemeQueueEntry.themeId);
					stringBuilder.Append(" [");
					stringBuilder.Append(value);
					stringBuilder.Append("] ");
					stringBuilder.Append(" musicDuration=");
					stringBuilder.Append(followingThemeQueueEntry.musicDuration);
					stringBuilder.Append(" startIntensity=");
					stringBuilder.Append(followingThemeQueueEntry.startIntensity);
					stringBuilder.Append(" playMode=");
					stringBuilder.Append(followingThemeQueueEntry.playmode);
					stringBuilder.Append(" restTimeMillis=");
					stringBuilder.Append(followingThemeQueueEntry.restTimeMillis);
					Logger.Instance.Log(stringBuilder.ToString(), LogLevel.debug);
				}
				if (m_currentSegmentPlaying.CheckIfAnyDirectOrIndirectTransitionIsPossible(m_soundtrack, followingThemeQueueEntry.themeId))
				{
					PopAndPlayNextFollowingTheme(immediately: false);
					break;
				}
				if (LogLevel.debug <= Logger.Instance.LogLevel)
				{
					StringBuilder stringBuilder2 = new StringBuilder();
					stringBuilder2.Append("no transition is possible from current Segment (");
					stringBuilder2.Append(m_currentSegmentPlaying.Id);
					stringBuilder2.Append(") to following theme (themeId=");
					stringBuilder2.Append(followingThemeQueueEntry.themeId);
					stringBuilder2.Append(") ");
					stringBuilder2.Append(" -> Play an End-Segment and go to rest.");
					Logger.Instance.Log(stringBuilder2.ToString(), LogLevel.debug);
				}
				InitiateTransitionToRestMode();
			}
			else
			{
				if (LogLevel.debug <= Logger.Instance.LogLevel)
				{
					Logger.Instance.Log("No Following Theme is set. Play an End-Segment and go to rest.", LogLevel.debug);
				}
				InitiateTransitionToRestMode();
			}
			break;
		}
		case (ThemeType)4:
		case ThemeType.highlightLayer:
			break;
		}
	}

	public PsaiResult GoToRest(bool immediately, int fadeOutMilliSeconds)
	{
		return GoToRest(immediately, fadeOutMilliSeconds, -1, -1);
	}

	public PsaiResult GoToRest(bool immediately, int fadeOutMilliSeconds, int restSecondsOverrideMin, int restSecondsOverrideMax)
	{
		if (restSecondsOverrideMin > restSecondsOverrideMax)
		{
			if (LogLevel.errors <= Logger.Instance.LogLevel)
			{
				Logger.Instance.Log("restSecondsOverrideMin needs to be greater or equal to restSecondsOverrideMax", LogLevel.errors);
			}
			return PsaiResult.invalidParam;
		}
		if (fadeOutMilliSeconds < 0)
		{
			if (LogLevel.errors <= Logger.Instance.LogLevel)
			{
				Logger.Instance.Log("negative parameters are not allowed", LogLevel.errors);
			}
			return PsaiResult.invalidParam;
		}
		if (restSecondsOverrideMin >= 0 && restSecondsOverrideMax >= 0)
		{
			m_restModeSecondsOverride = GetRandomInt(restSecondsOverrideMin, restSecondsOverrideMax);
		}
		else
		{
			m_restModeSecondsOverride = -1;
		}
		if (!immediately)
		{
			InitiateTransitionToRestMode();
		}
		else
		{
			startFade(m_currentVoiceNumber, fadeOutMilliSeconds, 0);
			EnterRestMode(GetLastBasicMoodId(), getEffectiveThemeId());
		}
		return PsaiResult.OK;
	}

	private void EnterRestMode(int themeIdToWakeUpWith, int themeIdToUseForRestingTimeCalculation)
	{
		if (LogLevel.info <= Logger.Instance.LogLevel)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("--- Entering rest mode. Will wake up with Theme ");
			stringBuilder.Append(themeIdToWakeUpWith);
			Logger.Instance.Log(stringBuilder.ToString(), LogLevel.info);
		}
		m_psaiState = PsaiState.rest;
		m_holdIntensity = false;
		m_timerStartSnippetPlayback.Stop();
		m_timerSegmentEndApproaching.Stop();
		m_timerWakeUpFromRest.Stop();
		m_effectiveTheme = m_soundtrack.getThemeById(themeIdToWakeUpWith);
		if (m_effectiveTheme != null)
		{
			int num = 0;
			if (m_restModeSecondsOverride > 0)
			{
				if (LogLevel.info <= Logger.Instance.LogLevel)
				{
					StringBuilder stringBuilder2 = new StringBuilder();
					stringBuilder2.Append("--- resting time is based on override values.");
					Logger.Instance.Log(stringBuilder2.ToString(), LogLevel.info);
				}
				num = m_restModeSecondsOverride;
				m_restModeSecondsOverride = -1;
			}
			else
			{
				Theme themeById = m_soundtrack.getThemeById(themeIdToUseForRestingTimeCalculation);
				if (themeById != null)
				{
					if (LogLevel.info <= Logger.Instance.LogLevel)
					{
						StringBuilder stringBuilder3 = new StringBuilder();
						stringBuilder3.Append("--- resting time is based on Theme ");
						stringBuilder3.Append(themeById.Name);
						Logger.Instance.Log(stringBuilder3.ToString(), LogLevel.info);
					}
					num = GetRandomInt(themeById.restSecondsMin, themeById.restSecondsMax) * 1000;
				}
				else
				{
					if (LogLevel.warnings <= Logger.Instance.LogLevel)
					{
						StringBuilder stringBuilder4 = new StringBuilder();
						stringBuilder4.Append("--- resting time is based on Theme ");
						stringBuilder4.Append(m_effectiveTheme.Name);
						stringBuilder4.Append("(themeIdToUseForRestingTimeCalculation was not found: ");
						stringBuilder4.Append(themeIdToUseForRestingTimeCalculation);
						stringBuilder4.Append(" )");
						Logger.Instance.Log(stringBuilder4.ToString(), LogLevel.warnings);
					}
					num = GetRandomInt(m_effectiveTheme.restSecondsMin, m_effectiveTheme.restSecondsMax) * 1000;
				}
			}
			if (num > 0)
			{
				m_timeStampRestStart = GetTimestampMillisElapsedSinceInitialisation();
				if (LogLevel.info <= Logger.Instance.LogLevel)
				{
					StringBuilder stringBuilder5 = new StringBuilder();
					stringBuilder5.Append("...resting for ");
					stringBuilder5.Append(num);
					stringBuilder5.Append(" ms");
					Logger.Instance.Log(stringBuilder5.ToString(), LogLevel.info);
				}
				m_timerWakeUpFromRest.SetTimer(num, 0);
			}
			else
			{
				if (LogLevel.info <= Logger.Instance.LogLevel)
				{
					Logger.Instance.Log("resting time is zero, starting again immediately.", LogLevel.info);
				}
				WakeUpFromRestHandler();
			}
		}
		else if (LogLevel.errors <= Logger.Instance.LogLevel)
		{
			Logger.Instance.Log("can't go to rest because Theme wasn't found!", LogLevel.errors);
		}
	}

	private void WakeUpFromRestHandler()
	{
		if (LogLevel.info <= Logger.Instance.LogLevel)
		{
			Logger.Instance.Log("waking up from musical rest", LogLevel.info);
		}
		if (m_effectiveTheme != null)
		{
			PlayThemeNowOrAtEndOfCurrentSegmentAndStartEvaluation(m_effectiveTheme.id, m_effectiveTheme.intensityAfterRest, m_effectiveTheme.musicDurationAfterRest, immediately: true, holdIntensity: false);
			m_psaiState = PsaiState.playing;
			m_psaiStateIntended = PsaiState.playing;
		}
	}

	private Segment GetBestCompatibleSegment(Segment sourceSegment, int targetThemeId, float intensity, int allowedSegmentSuitabilities)
	{
		float num = 0f;
		int num2 = 0;
		int num3 = 0;
		if (sourceSegment == null)
		{
			return null;
		}
		List<Follower> list = new List<Follower>();
		int count = sourceSegment.Followers.Count;
		for (int i = 0; i < count; i++)
		{
			int snippetId = sourceSegment.Followers[i].snippetId;
			Segment segmentById = m_soundtrack.GetSegmentById(snippetId);
			if (segmentById != null && (allowedSegmentSuitabilities & segmentById.SnippetTypeBitfield) > 0 && segmentById.ThemeId == targetThemeId)
			{
				if (i == 0)
				{
					num2 = segmentById.Playcount;
				}
				else if (segmentById.Playcount < num2)
				{
					num2 = segmentById.Playcount;
				}
				if (segmentById.Playcount > num3)
				{
					num3 = segmentById.Playcount;
				}
				float num4 = intensity - segmentById.Intensity;
				if (num4 < 0f)
				{
					num4 *= -1f;
				}
				if (num4 > num)
				{
					num = num4;
				}
				list.Add(sourceSegment.Followers[i]);
			}
		}
		if (list.Count == 0)
		{
			if (LogLevel.errors <= Logger.Instance.LogLevel)
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append("no Segment of type ");
				stringBuilder.Append(Segment.GetStringFromSegmentSuitabilities(allowedSegmentSuitabilities));
				stringBuilder.Append(" found for Theme ");
				stringBuilder.Append(targetThemeId);
				stringBuilder.Append(" , that would be a compatible follower/layer of Segment ");
				stringBuilder.Append(sourceSegment.Name);
				Logger.Instance.Log(stringBuilder.ToString(), LogLevel.errors);
			}
			return null;
		}
		Weighting weighting = null;
		Theme themeById = m_soundtrack.getThemeById(targetThemeId);
		if (themeById != null)
		{
			weighting = themeById.weightings;
		}
		return ChooseBestSegmentFromList(list, weighting, intensity, num3, num2, num);
	}

	private Segment GetBestStartSegmentForTheme(int themeId, float intensity)
	{
		Theme themeById = m_soundtrack.getThemeById(themeId);
		if (themeById == null)
		{
			return null;
		}
		return GetBestStartSegmentForTheme_internal(themeById, intensity);
	}

	private Segment GetBestStartSegmentForTheme_internal(Theme theme, float intensity)
	{
		float num = 0f;
		int num2 = 0;
		int num3 = 0;
		List<Follower> list = new List<Follower>();
		int count = theme.m_segments.Count;
		for (int i = 0; i < count; i++)
		{
			Segment segment = theme.m_segments[i];
			if (segment != null)
			{
				if ((1 & segment.SnippetTypeBitfield) > 0)
				{
					if (i == 0)
					{
						num2 = segment.Playcount;
					}
					else if (segment.Playcount < num2)
					{
						num2 = segment.Playcount;
					}
					if (segment.Playcount > num3)
					{
						num3 = segment.Playcount;
					}
					float num4 = intensity - segment.Intensity;
					if (num4 < 0f)
					{
						num4 *= -1f;
					}
					if (num4 > num)
					{
						num = num4;
					}
					Follower follower = new Follower();
					follower.snippetId = segment.Id;
					follower.compatibility = 1f;
					list.Add(follower);
				}
			}
			else if (LogLevel.errors <= Logger.Instance.LogLevel)
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append("INTERNAL ERROR ! GetBestStartSegmentForTheme_internal() - a Segment with id ");
				stringBuilder.Append(segment.Id);
				stringBuilder.Append(" could not be found!");
				Logger.Instance.Log(stringBuilder.ToString(), LogLevel.errors);
			}
		}
		Weighting weightings = theme.weightings;
		return ChooseBestSegmentFromList(list, weightings, intensity, num3, num2, num);
	}

	private Segment ChooseBestSegmentFromList(List<Follower> segmentList, Weighting weighting, float intensity, int maxPlaycount, int minPlaycount, float maxDeltaIntensity)
	{
		if (LogLevel.debug <= Logger.Instance.LogLevel)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("ChooseBestSegmentFromList() snippetList.size()=");
			stringBuilder.Append(segmentList.Count);
			stringBuilder.Append(" intensity=");
			stringBuilder.Append(intensity);
			stringBuilder.Append("  maxPlaycount=");
			stringBuilder.Append(maxPlaycount);
			stringBuilder.Append("  minPlaycount=");
			stringBuilder.Append(minPlaycount);
			stringBuilder.Append("  maxDeltaIntensity=");
			stringBuilder.Append(maxDeltaIntensity);
			stringBuilder.Append("  weighting.switchGroups=");
			stringBuilder.Append(weighting.switchGroups);
			stringBuilder.Append("  weighting.intensityVsVariety=");
			stringBuilder.Append(weighting.intensityVsVariety);
			stringBuilder.Append("  weightingLowPlaycountVsRandom=");
			stringBuilder.Append(weighting.lowPlaycountVsRandom);
			Logger.Instance.Log(stringBuilder.ToString(), LogLevel.debug);
		}
		Segment segment = null;
		if (segmentList.Count == 0)
		{
			if (LogLevel.debug <= Logger.Instance.LogLevel)
			{
				Logger.Instance.Log("ChooseBestSegmentFromList() empty segment list ! returning null", LogLevel.debug);
			}
			return null;
		}
		float num = 1f;
		float num2 = 1f;
		int num3 = maxPlaycount - minPlaycount;
		num = ((num3 <= 0) ? 0f : (1f / (float)num3));
		num2 = ((!(maxDeltaIntensity > 0f)) ? 0f : (1f / maxDeltaIntensity));
		float num4 = 0f;
		int count = segmentList.Count;
		for (int i = 0; i < count; i++)
		{
			if (segmentList[i] != null)
			{
				Segment segmentById = m_soundtrack.GetSegmentById(segmentList[i].snippetId);
				float num5 = 1f - weighting.switchGroups;
				float num6 = 1f - weighting.intensityVsVariety;
				float intensityVsVariety = weighting.intensityVsVariety;
				float num7 = 1f - weighting.lowPlaycountVsRandom;
				float lowPlaycountVsRandom = weighting.lowPlaycountVsRandom;
				float num8 = segmentList[i].compatibility * num5;
				float num9 = intensity - segmentById.Intensity;
				if (num9 < 0f)
				{
					num9 *= -1f;
				}
				float num10 = (1f - num9 * num2) * num6;
				float num11 = (float)(segmentById.Playcount - minPlaycount) * num;
				float num12 = (1f - num11) * num7;
				float num13 = GetRandomFloat() * lowPlaycountVsRandom;
				float num14 = (num12 + num13) * intensityVsVariety / 2f;
				float num15 = num8 + num10 + num14;
				if (segment == null || num15 > num4)
				{
					segment = segmentById;
					num4 = num15;
				}
			}
		}
		if (LogLevel.debug <= Logger.Instance.LogLevel)
		{
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append(" ...returning Segment id=");
			stringBuilder2.Append(segment.Id);
			stringBuilder2.Append("  themeId=");
			stringBuilder2.Append(segment.ThemeId);
			stringBuilder2.Append("  playbackCount=");
			stringBuilder2.Append(segment.Playcount);
			stringBuilder2.Append("  intensity=");
			stringBuilder2.Append(segment.Intensity);
			stringBuilder2.Append("  bestSegmentScore=");
			stringBuilder2.Append(num4);
			Logger.Instance.Log(stringBuilder2.ToString(), LogLevel.debug);
		}
		return segment;
	}

	private void PlaySegmentOfCurrentTheme(SegmentSuitability snippetType)
	{
		if (LogLevel.debug <= Logger.Instance.LogLevel)
		{
			Logger.Instance.Log("PlaySegmentOfCurrentTheme() " + snippetType, LogLevel.debug);
		}
		if (m_effectiveTheme == null)
		{
			return;
		}
		float currentIntensity = getCurrentIntensity();
		if (m_currentSegmentPlaying != null)
		{
			Segment segment = GetBestCompatibleSegment(m_currentSegmentPlaying, m_effectiveTheme.id, currentIntensity, (int)snippetType);
			m_targetSegmentSuitabilitiesRequested = (int)snippetType;
			if (segment == null)
			{
				if (LogLevel.warnings <= Logger.Instance.LogLevel)
				{
					StringBuilder stringBuilder = new StringBuilder();
					stringBuilder.Append("No compatible Segment of suitability ");
					stringBuilder.Append(snippetType);
					stringBuilder.Append(" found for Segment ");
					stringBuilder.Append(m_currentSegmentPlaying.Name);
					stringBuilder.Append("  Trying to substitute..!");
					Logger.Instance.Log(stringBuilder.ToString(), LogLevel.warnings);
				}
				segment = substituteSegment(m_effectiveTheme.id);
			}
			if (segment != null)
			{
				PlaySegment(segment, immediately: false);
			}
		}
		else if (LogLevel.errors <= Logger.Instance.LogLevel)
		{
			Logger.Instance.Log("INTERNAL ERROR! PlayEndSegmentOfCurrentTheme() - m_currentSegmentPlaying was NULL", LogLevel.errors);
		}
	}

	private Segment substituteSegment(int themeId)
	{
		if (LogLevel.info <= Logger.Instance.LogLevel)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("substituteSegment() themeId=");
			stringBuilder.Append(themeId);
			Logger.Instance.Log(stringBuilder.ToString(), LogLevel.info);
		}
		Segment segment = null;
		Theme themeById = m_soundtrack.getThemeById(themeId);
		if (themeById != null && themeById.m_segments.Count > 0)
		{
			segment = themeById.m_segments[0];
		}
		if (segment == null)
		{
			if (LogLevel.errors <= Logger.Instance.LogLevel)
			{
				Logger.Instance.Log("Failed to substiture Segment - No Segment found within the same Theme!", LogLevel.errors);
			}
		}
		else if (LogLevel.warnings <= Logger.Instance.LogLevel)
		{
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("Segment was substituted by Segment ");
			stringBuilder2.Append(segment.Id);
			Logger.Instance.Log(stringBuilder2.ToString(), LogLevel.warnings);
		}
		return segment;
	}

	private void EnterSilenceMode()
	{
		if (LogLevel.info <= Logger.Instance.LogLevel)
		{
			Logger.Instance.Log("entering Silence Mode", LogLevel.info);
		}
		m_timerStartSnippetPlayback.Stop();
		m_timerSegmentEndApproaching.Stop();
		m_timerWakeUpFromRest.Stop();
		m_targetSegment = null;
		m_effectiveTheme = null;
		m_scheduleFadeoutUponSnippetPlayback = false;
		m_psaiStateIntended = PsaiState.silence;
		m_psaiState = PsaiState.silence;
	}

	internal bool menuModeIsActive()
	{
		return m_psaiPlayMode == PsaiPlayMode.menuMode;
	}

	internal bool cutSceneIsActive()
	{
		return m_psaiPlayModeIntended == PsaiPlayMode.cutScene;
	}

	internal PsaiResult MenuModeEnter(int menuThemeId, float menuIntensity)
	{
		if (LogLevel.info <= Logger.Instance.LogLevel)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("entering Menu Mode, menuTheme id=");
			stringBuilder.Append(menuThemeId);
			stringBuilder.Append("  , intensity=");
			stringBuilder.Append(menuIntensity);
			Logger.Instance.Log(stringBuilder.ToString(), LogLevel.info);
		}
		if (LogLevel.debug <= Logger.Instance.LogLevel)
		{
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("MenuModeEnter()  m_themeQueue.size()=");
			stringBuilder2.Append(m_themeQueue.Count);
			Logger.Instance.Log(stringBuilder2.ToString(), LogLevel.debug);
		}
		if (m_initializationFailure)
		{
			return PsaiResult.initialization_error;
		}
		if (m_paused)
		{
			setPaused(setPaused: false);
		}
		if (m_psaiPlayMode != PsaiPlayMode.menuMode)
		{
			if (m_psaiPlayMode == PsaiPlayMode.cutScene && m_psaiPlayModeIntended == PsaiPlayMode.regular)
			{
				if (LogLevel.debug <= Logger.Instance.LogLevel)
				{
					StringBuilder stringBuilder3 = new StringBuilder();
					stringBuilder3.Append("special case: Menu Mode entered when we were just returning from the cutscene.");
					stringBuilder3.Append("  m_currentTheme->id=");
					stringBuilder3.Append(m_effectiveTheme.id);
					stringBuilder3.Append("  m_targetSegment=");
					stringBuilder3.Append(m_targetSegment);
					Logger.Instance.Log(stringBuilder3.ToString(), LogLevel.debug);
				}
				PushEffectiveThemeToThemeQueue(m_psaiPlayModeIntended);
			}
			else if (m_psaiState == PsaiState.playing)
			{
				PushEffectiveThemeToThemeQueue(m_psaiPlayMode);
			}
			if (m_soundtrack.getThemeById(menuThemeId) != null)
			{
				PlayThemeNowOrAtEndOfCurrentSegmentAndStartEvaluation(menuThemeId, menuIntensity, 666, immediately: true, holdIntensity: true);
			}
			else
			{
				setPaused(setPaused: false);
				if (LogLevel.warnings <= Logger.Instance.LogLevel)
				{
					StringBuilder stringBuilder4 = new StringBuilder();
					stringBuilder4.Append("No Menu Theme has been set -> pausing");
					Logger.Instance.Log(stringBuilder4.ToString(), LogLevel.warnings);
				}
			}
			SetPlayMode(PsaiPlayMode.menuMode);
			m_psaiPlayModeIntended = PsaiPlayMode.menuMode;
			return PsaiResult.OK;
		}
		if (LogLevel.warnings <= Logger.Instance.LogLevel)
		{
			Logger.Instance.Log("Menu Mode already active", LogLevel.warnings);
		}
		return PsaiResult.commandIgnoredMenuModeActive;
	}

	internal PsaiResult MenuModeLeave()
	{
		if (LogLevel.info <= Logger.Instance.LogLevel)
		{
			Logger.Instance.Log("MenuModeLeave", LogLevel.info);
		}
		if (LogLevel.debug <= Logger.Instance.LogLevel)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(" m_themeQueue.size()=");
			stringBuilder.Append(m_themeQueue.Count);
			Logger.Instance.Log(stringBuilder.ToString(), LogLevel.debug);
		}
		if (m_initializationFailure)
		{
			Logger.Instance.Log(LOGMESSAGE_ABORTION_DUE_TO_INITIALIZATION_FAILURE, LogLevel.errors);
			return PsaiResult.initialization_error;
		}
		if (m_paused)
		{
			setPaused(setPaused: false);
		}
		if (m_psaiPlayMode == PsaiPlayMode.menuMode)
		{
			if (getFollowingThemeQueueEntry() != null)
			{
				PopAndPlayNextFollowingTheme(immediately: true);
				return PsaiResult.OK;
			}
			m_psaiStateIntended = PsaiState.silence;
			m_psaiState = PsaiState.silence;
			SetPlayMode(PsaiPlayMode.regular);
			m_psaiPlayModeIntended = PsaiPlayMode.regular;
			StopMusic(immediately: true);
			return PsaiResult.OK;
		}
		if (LogLevel.warnings <= Logger.Instance.LogLevel)
		{
			Logger.Instance.Log("MenuModeLeave() ignored - MenuMode wasn't active. Call MenuModeEnter() first !", LogLevel.warnings);
		}
		return PsaiResult.commandIgnored;
	}

	internal PsaiResult CutSceneEnter(int themeId, float intensity)
	{
		if (LogLevel.info <= Logger.Instance.LogLevel)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("CutSceneEnter(), theme id=");
			stringBuilder.Append(themeId);
			stringBuilder.Append("  , intensity=");
			stringBuilder.Append(intensity);
			Logger.Instance.Log(stringBuilder.ToString(), LogLevel.info);
		}
		if (LogLevel.debug <= Logger.Instance.LogLevel)
		{
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("  m_themeQueue.size()=");
			stringBuilder2.Append(m_themeQueue.Count);
			Logger.Instance.Log(stringBuilder2.ToString(), LogLevel.debug);
		}
		if (m_initializationFailure)
		{
			Logger.Instance.Log(LOGMESSAGE_ABORTION_DUE_TO_INITIALIZATION_FAILURE, LogLevel.errors);
			return PsaiResult.initialization_error;
		}
		switch (m_psaiPlayModeIntended)
		{
		case PsaiPlayMode.cutScene:
			if (LogLevel.warnings <= Logger.Instance.LogLevel)
			{
				Logger.Instance.Log("Cutscene Mode already active - command ignored !", LogLevel.warnings);
			}
			return PsaiResult.commandIgnoredCutsceneActive;
		case PsaiPlayMode.menuMode:
			if (LogLevel.warnings <= Logger.Instance.LogLevel)
			{
				Logger.Instance.Log("MenuMode active - command ignored !", LogLevel.warnings);
			}
			return PsaiResult.commandIgnoredMenuModeActive;
		default:
		{
			PushEffectiveThemeToThemeQueue(PsaiPlayMode.regular);
			Theme themeById = m_soundtrack.getThemeById(themeId);
			SetPlayMode(PsaiPlayMode.cutScene);
			m_psaiPlayModeIntended = PsaiPlayMode.cutScene;
			if (themeById != null)
			{
				PlayThemeNowOrAtEndOfCurrentSegmentAndStartEvaluation(themeId, intensity, themeById.musicDurationGeneral, immediately: true, holdIntensity: true);
				return PsaiResult.OK;
			}
			PlayThemeNowOrAtEndOfCurrentSegmentAndStartEvaluation(m_lastBasicMood.id, intensity, m_lastBasicMood.musicDurationGeneral, immediately: true, holdIntensity: true);
			return PsaiResult.unknown_theme;
		}
		}
	}

	internal PsaiResult CutSceneLeave(bool immediately, bool reset)
	{
		if (LogLevel.info <= Logger.Instance.LogLevel)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("CutSceneLeave()  immediately=");
			stringBuilder.Append(immediately);
			stringBuilder.Append("  reset=");
			stringBuilder.Append(reset);
			Logger.Instance.Log(stringBuilder.ToString(), LogLevel.info);
		}
		if (LogLevel.debug <= Logger.Instance.LogLevel)
		{
			StringBuilder stringBuilder2 = new StringBuilder();
			stringBuilder2.Append("  m_themeQueue.size()=");
			stringBuilder2.Append(m_themeQueue.Count);
			Logger.Instance.Log(stringBuilder2.ToString(), LogLevel.debug);
		}
		if (m_initializationFailure)
		{
			Logger.Instance.Log(LOGMESSAGE_ABORTION_DUE_TO_INITIALIZATION_FAILURE, LogLevel.errors);
			return PsaiResult.initialization_error;
		}
		if (m_psaiPlayMode == PsaiPlayMode.cutScene && m_psaiPlayModeIntended == PsaiPlayMode.cutScene)
		{
			if (reset)
			{
				m_themeQueue.Clear();
				if (LogLevel.debug <= Logger.Instance.LogLevel)
				{
					Logger.Instance.Log("m_themeQueue cleared", LogLevel.debug);
				}
			}
			if (getFollowingThemeQueueEntry() != null)
			{
				m_psaiPlayModeIntended = PsaiPlayMode.regular;
				PopAndPlayNextFollowingTheme(immediately);
				return PsaiResult.OK;
			}
			m_psaiStateIntended = PsaiState.silence;
			m_psaiState = PsaiState.silence;
			m_psaiPlayModeIntended = PsaiPlayMode.regular;
			StopMusic(immediately);
			return PsaiResult.OK;
		}
		if (LogLevel.warnings <= Logger.Instance.LogLevel)
		{
			Logger.Instance.Log("CutSceneLeave() ignored - no CutScene was active. Call CutSceneEnter() first!", LogLevel.warnings);
		}
		return PsaiResult.commandIgnored;
	}

	private ThemeQueueEntry getFollowingThemeQueueEntry()
	{
		if (m_themeQueue.Count > 0)
		{
			return m_themeQueue[0];
		}
		return null;
	}

	private void SetPlayMode(PsaiPlayMode playMode)
	{
		if (LogLevel.debug <= Logger.Instance.LogLevel)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("SetPlayMode() ");
			stringBuilder.Append(playMode);
			Logger.Instance.Log(stringBuilder.ToString(), LogLevel.debug);
		}
		m_psaiPlayMode = playMode;
	}

	private void PushEffectiveThemeToThemeQueue(PsaiPlayMode playModeToReturnTo)
	{
		if (LogLevel.debug <= Logger.Instance.LogLevel)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("PushEffectiveThemeToThemeQueue()  playModeToReturnTo=");
			stringBuilder.Append(playModeToReturnTo);
			stringBuilder.Append("  m_nonInterruptingTriggerCallOfHighestPriority.themeId=");
			stringBuilder.Append(m_latestEndOfSegmentTriggerCall.themeId);
			stringBuilder.Append("  m_currentSegmentPlaying=");
			if (m_currentSegmentPlaying != null)
			{
				stringBuilder.Append(m_currentSegmentPlaying.Name);
			}
			else
			{
				stringBuilder.Append("null");
			}
			stringBuilder.Append("  m_targetSegment=");
			if (m_targetSegment != null)
			{
				stringBuilder.Append(m_targetSegment.Name);
			}
			else
			{
				stringBuilder.Append("null");
			}
			Logger.Instance.Log(stringBuilder.ToString(), LogLevel.debug);
		}
		if (m_psaiState == PsaiState.rest)
		{
			int restTimeMillis = GetTimestampMillisElapsedSinceInitialisation() - m_timeStampRestStart;
			m_timerWakeUpFromRest.Stop();
			if (LogLevel.debug <= Logger.Instance.LogLevel)
			{
				Logger.Instance.Log(".. we were in Rest Mode, restModeRemainingMillis=" + restTimeMillis, LogLevel.debug);
			}
			pushThemeToThemeQueue(m_lastBasicMood.id, m_lastBasicMood.intensityAfterRest, 0, clearThemeQueue: true, restTimeMillis, PsaiPlayMode.regular, holdIntensity: false);
			return;
		}
		if (m_latestEndOfSegmentTriggerCall.themeId != -1)
		{
			if (LogLevel.debug <= Logger.Instance.LogLevel)
			{
				StringBuilder stringBuilder2 = new StringBuilder();
				stringBuilder2.Append("...m_nonInterruptingTrigger was set, themeId=");
				stringBuilder2.Append(m_latestEndOfSegmentTriggerCall.themeId);
				Logger.Instance.Log(stringBuilder2.ToString(), LogLevel.debug);
			}
			Theme themeById = m_soundtrack.getThemeById(m_latestEndOfSegmentTriggerCall.themeId);
			pushThemeToThemeQueue(themeById.id, m_latestEndOfSegmentTriggerCall.startIntensity, m_latestEndOfSegmentTriggerCall.musicDuration, clearThemeQueue: false, 0, PsaiPlayMode.regular, holdIntensity: false);
			m_latestEndOfSegmentTriggerCall.themeId = -1;
			return;
		}
		Segment effectiveSegment = GetEffectiveSegment();
		if (effectiveSegment != null)
		{
			if ((effectiveSegment == m_targetSegment && m_currentSegmentPlaying == null) || (m_targetSegment != null && m_currentSegmentPlaying != null && m_targetSegment.ThemeId != m_currentSegmentPlaying.ThemeId))
			{
				if (LogLevel.debug <= Logger.Instance.LogLevel)
				{
					StringBuilder stringBuilder3 = new StringBuilder();
					stringBuilder3.Append("setting targetSegment.themeId as the following Theme, storing full music duration of themeId=");
					stringBuilder3.Append(effectiveSegment.ThemeId);
					Logger.Instance.Log(stringBuilder3.ToString(), LogLevel.debug);
				}
				Theme themeById2 = m_soundtrack.getThemeById(m_targetSegment.ThemeId);
				pushThemeToThemeQueue(m_targetSegment.ThemeId, getUpcomingIntensity(), themeById2.musicDurationGeneral, clearThemeQueue: false, 0, playModeToReturnTo, m_holdIntensity);
			}
			else
			{
				if (LogLevel.debug <= Logger.Instance.LogLevel)
				{
					StringBuilder stringBuilder4 = new StringBuilder();
					stringBuilder4.Append("pushing themeId of the Effective Segment to Theme Queue, themeId=");
					stringBuilder4.Append(effectiveSegment.ThemeId);
					Logger.Instance.Log(stringBuilder4.ToString(), LogLevel.debug);
				}
				pushThemeToThemeQueue(effectiveSegment.ThemeId, getCurrentIntensity(), GetRemainingMusicDurationSecondsOfCurrentTheme(), clearThemeQueue: false, 0, playModeToReturnTo, m_holdIntensity);
			}
		}
		else if (LogLevel.debug <= Logger.Instance.LogLevel)
		{
			StringBuilder stringBuilder5 = new StringBuilder();
			stringBuilder5.Append("not pushing anything to themeQueue. effectiveSegment=");
			stringBuilder5.Append(GetEffectiveSegment());
			stringBuilder5.Append("  m_targetSegment=");
			stringBuilder5.Append(m_targetSegment);
			Logger.Instance.Log(stringBuilder5.ToString(), LogLevel.debug);
		}
	}

	private Segment GetEffectiveSegment()
	{
		if (m_targetSegment != null)
		{
			return m_targetSegment;
		}
		if (m_currentSegmentPlaying != null)
		{
			return m_currentSegmentPlaying;
		}
		return null;
	}

	internal int getEffectiveThemeId()
	{
		if (m_effectiveTheme != null)
		{
			return m_effectiveTheme.id;
		}
		return -1;
	}

	private int GetEffectiveSegmentSuitabilitiesRequested()
	{
		if (m_targetSegment != null)
		{
			return m_targetSegmentSuitabilitiesRequested;
		}
		return m_currentSnippetTypeRequested;
	}

	private void PopAndPlayNextFollowingTheme(bool immediately)
	{
		if (LogLevel.debug <= Logger.Instance.LogLevel)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("PopAndPlayNextFollowingTheme()  m_themeQueue.size()=");
			stringBuilder.Append(m_themeQueue.Count);
			stringBuilder.Append("  immediately=");
			stringBuilder.Append(immediately);
			Logger.Instance.Log(stringBuilder.ToString(), LogLevel.debug);
		}
		if (getFollowingThemeQueueEntry() != null)
		{
			ThemeQueueEntry followingThemeQueueEntry = getFollowingThemeQueueEntry();
			m_psaiPlayModeIntended = followingThemeQueueEntry.playmode;
			if (LogLevel.debug <= Logger.Instance.LogLevel)
			{
				StringBuilder stringBuilder2 = new StringBuilder();
				stringBuilder2.Append("first ThemeQueueEntry: ");
				stringBuilder2.Append(followingThemeQueueEntry.ToString());
				Logger.Instance.Log(stringBuilder2.ToString(), LogLevel.debug);
			}
			switch (m_psaiPlayModeIntended)
			{
			case PsaiPlayMode.regular:
				PlayThemeNowOrAtEndOfCurrentSegmentAndStartEvaluation(followingThemeQueueEntry, immediately);
				break;
			case PsaiPlayMode.cutScene:
				PlayThemeNowOrAtEndOfCurrentSegmentAndStartEvaluation(followingThemeQueueEntry.themeId, followingThemeQueueEntry.startIntensity, followingThemeQueueEntry.musicDuration, immediately, followingThemeQueueEntry.holdIntensity);
				break;
			case PsaiPlayMode.menuMode:
				PlayThemeNowOrAtEndOfCurrentSegmentAndStartEvaluation(followingThemeQueueEntry.themeId, followingThemeQueueEntry.startIntensity, followingThemeQueueEntry.musicDuration, immediately, followingThemeQueueEntry.holdIntensity);
				break;
			default:
				if (LogLevel.errors <= Logger.Instance.LogLevel)
				{
					Logger.Instance.Log("unkown PSAIPLAYMODE !", LogLevel.errors);
				}
				break;
			}
			removeFirstFollowingThemeQueueEntry();
		}
		else if (LogLevel.errors <= Logger.Instance.LogLevel)
		{
			StringBuilder stringBuilder3 = new StringBuilder();
			stringBuilder3.Append("PopAndPlayNextFollowingTheme() - themeQueue is empty!");
			Logger.Instance.Log(stringBuilder3.ToString(), LogLevel.errors);
		}
	}

	private void removeFirstFollowingThemeQueueEntry()
	{
		if (m_themeQueue.Count > 0)
		{
			m_themeQueue.RemoveAt(0);
		}
	}

	internal PsaiInfo getPsaiInfo()
	{
		PsaiInfo psaiInfo = new PsaiInfo();
		psaiInfo.psaiState = m_psaiState;
		psaiInfo.upcomingPsaiState = m_psaiStateIntended;
		if (m_lastBasicMood != null)
		{
			psaiInfo.lastBasicMoodThemeId = m_lastBasicMood.id;
		}
		else
		{
			psaiInfo.lastBasicMoodThemeId = -1;
		}
		psaiInfo.effectiveThemeId = getEffectiveThemeId();
		psaiInfo.upcomingThemeId = getUpcomingThemeId();
		psaiInfo.currentIntensity = getCurrentIntensity();
		psaiInfo.upcomingIntensity = getUpcomingIntensity();
		psaiInfo.intensityIsHeld = m_holdIntensity;
		psaiInfo.themesQueued = m_themeQueue.Count;
		psaiInfo.returningToLastBasicMood = m_returnToLastBasicMoodFlag;
		psaiInfo.paused = m_paused;
		if (m_targetSegment != null)
		{
			psaiInfo.targetSegmentId = m_targetSegment.Id;
		}
		else
		{
			psaiInfo.targetSegmentId = -1;
		}
		if (m_timerWakeUpFromRest.IsSet())
		{
			psaiInfo.remainingMillisecondsInRestMode = m_timerWakeUpFromRest.GetRemainingMillisToFireTime();
		}
		return psaiInfo;
	}

	internal int getCurrentSnippetId()
	{
		if (m_currentSegmentPlaying != null)
		{
			return m_currentSegmentPlaying.Id;
		}
		return -1;
	}

	internal int GetRemainingMillisecondsOfCurrentSegmentPlayback()
	{
		if (m_currentSegmentPlaying != null)
		{
			return m_currentSegmentPlaying.audioData.GetFullLengthInMilliseconds() - GetMillisElapsedAfterCurrentSnippetPlaycall();
		}
		return -1;
	}

	internal int GetRemainingMillisecondsUntilNextSegmentStart()
	{
		if (m_timerStartSnippetPlayback.IsSet() && m_timerStartSnippetPlayback.IsSet())
		{
			return m_timerStartSnippetPlayback.GetRemainingMillisToFireTime();
		}
		return -1;
	}

	internal bool CheckIfAtLeastOneDirectTransitionOrLayeringIsPossible(int sourceSegmentId, int targetThemeId)
	{
		return m_soundtrack.GetSegmentById(sourceSegmentId)?.CheckIfAtLeastOneDirectTransitionOrLayeringIsPossible(m_soundtrack, targetThemeId) ?? false;
	}

	internal void AddLoggerOutput(LoggerOutput loggerOutput)
	{
		if (!Logger.Instance.LoggerOutputs.Contains(loggerOutput))
		{
			Logger.Instance.LoggerOutputs.Add(loggerOutput);
		}
	}
}
