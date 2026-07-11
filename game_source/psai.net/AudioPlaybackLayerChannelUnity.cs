using System;
using System.Text;
using UnityEngine;

namespace psai.net;

public class AudioPlaybackLayerChannelUnity : IAudioPlaybackLayerChannel
{
	private AudioSource _audioSource;

	private Segment _segmentToLoad;

	private int _timeSamples;

	private bool _playbackHasBeenInterruptedByPause;

	private PsaiAsyncLoader _psaiAsyncLoader;

	public PlaybackChannel PlaybackChannel;

	public int TargetPlaybackTimestamp { get; set; }

	public bool PlaybackIsPending { get; set; }

	public AudioClip AudioClip
	{
		get
		{
			if ((Object)(object)_audioSource != (Object)null)
			{
				return _audioSource.clip;
			}
			return null;
		}
		set
		{
			if ((Object)(object)_audioSource != (Object)null)
			{
				_audioSource.clip = value;
			}
		}
	}

	public string PathToClip { get; set; }

	public AudioPlaybackLayerChannelUnity(PlaybackChannel parentPlaybackChannel)
	{
		PlaybackChannel = parentPlaybackChannel;
		AudioSource val = ((Component)PlatformLayerUnity.PsaiGameObject.transform.Find(PlatformLayerUnity.NAME_OF_CHANNELS_CHILDNODE)).gameObject.AddComponent<AudioSource>();
		if ((Object)(object)PsaiCoreManager.HFBLDMHFBDJ.outputAudioMixerGroup != (Object)null)
		{
			val.outputAudioMixerGroup = PsaiCoreManager.HFBLDMHFBDJ.outputAudioMixerGroup;
		}
		val.loop = false;
		val.ignoreListenerVolume = true;
		val.ignoreListenerPause = true;
		_audioSource = val;
	}

	public void Release()
	{
		if ((Object)(object)_audioSource != (Object)null)
		{
			Object.DestroyImmediate((Object)(object)_audioSource);
		}
	}

	PsaiResult IAudioPlaybackLayerChannel.LoadSegment(Segment segment)
	{
		_segmentToLoad = segment;
		AudioClip = null;
		if ((Object)(object)_psaiAsyncLoader == (Object)null)
		{
			GameObject asyncLoadersNode = PsaiCoreManager.HFBLDMHFBDJ.GetAsyncLoadersNode();
			if ((Object)(object)asyncLoadersNode == (Object)null)
			{
				if (LogLevel.errors <= Logger.Instance.LogLevel)
				{
					Logger.Instance.Log("No 'Psai' object found in the Scene! Please make sure to add the Psai.prefab from the Psai.unitypackage to your Scene", LogLevel.errors);
				}
				return PsaiResult.initialization_error;
			}
			_psaiAsyncLoader = asyncLoadersNode.AddComponent<PsaiAsyncLoader>();
		}
		string psaiCoreSoundtrackDirectoryName = Logik.Instance.m_psaiCoreSoundtrackDirectoryName;
		if (psaiCoreSoundtrackDirectoryName.Length > 0)
		{
			PathToClip = psaiCoreSoundtrackDirectoryName + "/" + segment.audioData.filePathRelativeToProjectDir;
		}
		else
		{
			PathToClip = segment.audioData.filePathRelativeToProjectDir;
		}
		_audioSource.clip = null;
		_psaiAsyncLoader.LoadSegmentAsync(this);
		return PsaiResult.OK;
	}

	PsaiResult IAudioPlaybackLayerChannel.ReleaseSegment()
	{
		if ((Object)(object)_audioSource.clip != (Object)null)
		{
			Resources.UnloadAsset((Object)(object)_audioSource.clip);
			_audioSource.clip = null;
			_segmentToLoad = null;
		}
		return PsaiResult.OK;
	}

	public bool IsReadyToPlay()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Invalid comparison between Unknown and I4
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		if ((Object)(object)_audioSource.clip != (Object)null)
		{
			flag = (int)_audioSource.clip.loadState == 2;
		}
		if (!flag)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("readyToPlay returning false. _audioSource.clip=");
			stringBuilder.Append(Object.op_Implicit((Object)(object)_audioSource.clip));
			if ((Object)(object)_audioSource.clip != (Object)null)
			{
				stringBuilder.Append("  _audioSource.clip.loadState=");
				stringBuilder.Append(_audioSource.clip.loadState);
			}
			Logger.Instance.Log(stringBuilder.ToString(), LogLevel.debug);
		}
		return flag;
	}

	public void PlayBufferedClip(int delayMillis)
	{
		if (LogLevel.debug <= Logger.Instance.LogLevel)
		{
			string text = $"PlayBufferedClip()  _audioSource._clip: {_audioSource.clip}  delayMillis: {delayMillis}";
			text = text + " IsReadToPlay=" + IsReadyToPlay();
			Logger.Instance.Log(text, LogLevel.debug);
		}
		if (delayMillis == 0)
		{
			_audioSource.timeSamples = 0;
			_audioSource.Play();
			PlaybackChannel.OnPlaybackHasStarted();
		}
		else if (delayMillis > 0)
		{
			try
			{
				_audioSource.timeSamples = 0;
				_audioSource.PlayDelayed((float)(uint)delayMillis * 0.001f);
			}
			catch (Exception ex)
			{
				Debug.LogError((object)("_audioSource.PlayDelayed threw an exception: " + ex.ToString()));
				Debug.LogWarning((object)("_audioSource.clip=" + ((object)_audioSource.clip)?.ToString() + "  delayMillis: " + delayMillis + "  IsReadyToPlay():" + IsReadyToPlay()));
			}
		}
		else
		{
			_audioSource.timeSamples = Mathf.Min(PlaybackChannel.Segment.audioData.GetSampleCountByMilliseconds(Mathf.Abs(delayMillis)), PlaybackChannel.Segment.audioData.sampleCountTotal - 1);
			if (_audioSource.timeSamples < 0 || _audioSource.timeSamples >= PlaybackChannel.Segment.audioData.sampleCountTotal)
			{
				string argText = $"Timesamples {_audioSource.timeSamples} must be between 0 and {PlaybackChannel.Segment.audioData.sampleCountTotal}. Delay Ms {delayMillis}";
				Logger.Instance.Log(argText, LogLevel.errors);
			}
			_audioSource.Play();
			PlaybackChannel.OnPlaybackHasStarted();
		}
		PlaybackIsPending = false;
	}

	PsaiResult IAudioPlaybackLayerChannel.ScheduleSegmentPlayback(Segment segment, int delayMilliseconds)
	{
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		if (_segmentToLoad != null && _segmentToLoad.Id == segment.Id)
		{
			bool flag = IsReadyToPlay();
			if (LogLevel.debug <= Logger.Instance.LogLevel)
			{
				Logger.Instance.Log($"ScheduleSegmentPlayback() Segment: {segment.Name}  isReadyToPlay: {flag}   delayMilliseconds: {delayMilliseconds}", LogLevel.debug);
			}
			if (flag)
			{
				PlayBufferedClip(delayMilliseconds);
				if (LogLevel.debug <= Logger.Instance.LogLevel)
				{
					Logger.Instance.Log($"_audioSource.PlayDelayed() fired, delayInMs:{delayMilliseconds}", LogLevel.debug);
				}
				return PsaiResult.OK;
			}
			TargetPlaybackTimestamp = Logik.GetTimestampMillisElapsedSinceInitialisation() + delayMilliseconds;
			PlaybackIsPending = true;
			if (LogLevel.debug <= Logger.Instance.LogLevel)
			{
				Logger.Instance.Log("... play has not fired yet, PlaybackIsPending is now set to true.  TargetPlaybackTimestamp=" + TargetPlaybackTimestamp, LogLevel.debug);
			}
			if (delayMilliseconds <= 0)
			{
				if (LogLevel.errors <= Logger.Instance.LogLevel)
				{
					StringBuilder stringBuilder = new StringBuilder();
					stringBuilder.Append("Channel is not ready to play!");
					stringBuilder.Append("_audioSource.clip: ");
					stringBuilder.Append(Object.op_Implicit((Object)(object)_audioSource.clip));
					if ((Object)(object)_audioSource.clip != (Object)null)
					{
						stringBuilder.Append("  loadState: ");
						stringBuilder.Append(_audioSource.clip.loadState);
					}
					Logger.Instance.Log(stringBuilder.ToString(), LogLevel.errors);
				}
				_psaiAsyncLoader.PlayWhenReady(this);
			}
			return PsaiResult.OK;
		}
		Logger.Instance.Log("ScheduleSegmentPlayback(): COULD NOT PLAY! No Segment loaded, or Segment Id to play did not match! Segment loaded: " + _segmentToLoad, LogLevel.errors);
		return PsaiResult.notReady;
	}

	PsaiResult IAudioPlaybackLayerChannel.StopChannel()
	{
		_audioSource.volume = 0f;
		_audioSource.Stop();
		return PsaiResult.OK;
	}

	PsaiResult IAudioPlaybackLayerChannel.SetVolume(float volume)
	{
		if ((Object)(object)_audioSource != (Object)null)
		{
			_audioSource.volume = volume;
			return PsaiResult.OK;
		}
		if (LogLevel.errors <= Logger.Instance.LogLevel)
		{
			Logger.Instance.Log("SetVolume() failed, _audioSource is NULL!", LogLevel.errors);
		}
		return PsaiResult.notReady;
	}

	PsaiResult IAudioPlaybackLayerChannel.SetPaused(bool paused)
	{
		if (paused)
		{
			if (_audioSource.isPlaying)
			{
				_playbackHasBeenInterruptedByPause = true;
				_audioSource.Pause();
			}
		}
		else if (_playbackHasBeenInterruptedByPause)
		{
			_audioSource.Play();
			_playbackHasBeenInterruptedByPause = false;
		}
		return PsaiResult.OK;
	}
}
