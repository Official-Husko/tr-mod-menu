using System.Collections;
using UnityEngine;

namespace psai.net;

public class PsaiAsyncLoader : MonoBehaviour
{
	private IEnumerator m_loadSegmentAsync_Coroutine;

	private IEnumerator m_playWhenReady_Coroutine;

	public void LoadSegmentAsync(AudioPlaybackLayerChannelUnity audioPlaybackChannel)
	{
		if (LogLevel.debug <= Logger.Instance.LogLevel)
		{
			Logger.Instance.Log("LoadSegmentAsync() pathToClip=" + audioPlaybackChannel.PathToClip + "   audioPlaybackChannel.GetHashCode()=" + audioPlaybackChannel.GetHashCode(), LogLevel.debug);
		}
		if (m_loadSegmentAsync_Coroutine != null)
		{
			((MonoBehaviour)this).StopCoroutine(m_loadSegmentAsync_Coroutine);
			m_loadSegmentAsync_Coroutine = null;
		}
		if (m_playWhenReady_Coroutine != null)
		{
			((MonoBehaviour)this).StopCoroutine(m_playWhenReady_Coroutine);
			m_playWhenReady_Coroutine = null;
		}
		m_loadSegmentAsync_Coroutine = LoadSegmentAsync_Coroutine(audioPlaybackChannel);
		((MonoBehaviour)this).StartCoroutine(m_loadSegmentAsync_Coroutine);
	}

	private IEnumerator LoadSegmentAsync_Coroutine(AudioPlaybackLayerChannelUnity audioPlaybackChannel)
	{
		ResourceRequest request = Resources.LoadAsync(audioPlaybackChannel.PathToClip, typeof(AudioClip));
		yield return request;
		if (LogLevel.debug <= Logger.Instance.LogLevel)
		{
			string text = "LoadSegmentAsync_Coroutine complete, asset=" + ((request.asset == (Object)null) ? "null" : request.asset.name);
			text = text + "  PlaybackIsPending=" + audioPlaybackChannel.PlaybackIsPending + "   audioPlaybackChannel.GetHashCode()" + audioPlaybackChannel.GetHashCode();
			Logger.Instance.Log(text, LogLevel.debug);
		}
		Object asset = request.asset;
		AudioClip val = (AudioClip)(object)((asset is AudioClip) ? asset : null);
		if ((Object)(object)val == (Object)null)
		{
			if (LogLevel.errors <= Logger.Instance.LogLevel)
			{
				Logger.Instance.Log("The AudioClip '" + audioPlaybackChannel.PathToClip + "' was not found!", LogLevel.errors);
			}
			yield break;
		}
		audioPlaybackChannel.AudioClip = val;
		if (!audioPlaybackChannel.AudioClip.LoadAudioData() && (int)val.loadState == 0 && (int)val.loadType == 2 && UnityVersionComparer.CompareCurrentVersionAgainst("5.3.5p5") == UnityVersionComparer.ComparisonResult.later)
		{
			Debug.LogError((object)"LOADING FAILED! Dead user, please note that Unity versions 5.3.5p6 and later suffer from an issue in Unity's reworked streaming audio system. Please note that we cannot fix this problem on psai side. As a temporary workaround, please set the LoadType of all the Audio Clips used in your psai soundtrack to 'compressed in memory' or 'decompress on load'. Another option may be to fall back to the last working Unity version 5.3.5p5. We hope this gets sorted out soon, thanks for your patience!");
		}
		if (audioPlaybackChannel.PlaybackIsPending)
		{
			if (LogLevel.debug <= Logger.Instance.LogLevel)
			{
				Logger.Instance.Log("Playback is pending but AudioClip is not ready to play!", LogLevel.debug);
			}
			PlayWhenReady(audioPlaybackChannel);
		}
	}

	public void PlayWhenReady(AudioPlaybackLayerChannelUnity audioPlaybackChannel)
	{
		if (m_playWhenReady_Coroutine != null)
		{
			((MonoBehaviour)this).StopCoroutine(m_playWhenReady_Coroutine);
			m_playWhenReady_Coroutine = null;
		}
		m_playWhenReady_Coroutine = Coroutine_PlayWhenReady(audioPlaybackChannel);
		((MonoBehaviour)this).StartCoroutine(m_playWhenReady_Coroutine);
	}

	private IEnumerator Coroutine_PlayWhenReady(AudioPlaybackLayerChannelUnity audioPlaybackChannel)
	{
		while (!audioPlaybackChannel.IsReadyToPlay())
		{
			if ((Object)(object)audioPlaybackChannel.AudioClip == (Object)null)
			{
				yield break;
			}
			yield return null;
		}
		int num = Logik.GetTimestampMillisElapsedSinceInitialisation() - audioPlaybackChannel.TargetPlaybackTimestamp;
		if (num > 0 && Time.frameCount > 60)
		{
			if (LogLevel.warnings <= Logger.Instance.LogLevel)
			{
				Logger.Instance.Log($"playback timing problem detected! Missing milliseconds: {num} ", LogLevel.warnings);
			}
			if ((int)audioPlaybackChannel.AudioClip.loadType == 2)
			{
				Logger.Instance.Log("Please note: playback timing problems may occur when starting a Scene or when the Log Output in the PsaiCoreManager is set to Debug. If the warning shows up frequently during the game, please increase the 'Max Playback Latency' in PsaiCoreManager for the current target platform.", LogLevel.warnings);
			}
			else
			{
				Logger.Instance.Log("We highly recommend setting the 'Load Type' of all psai Audio Clips to 'Streaming'.", LogLevel.warnings);
			}
		}
		audioPlaybackChannel.PlayBufferedClip(-num);
	}
}
