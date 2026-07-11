using System;
using UnityEngine;

[Serializable]
public abstract class PsaiPlaybackControl : MonoBehaviour
{
	public PsaiCoreManager.PlaybackControlCall PlaybackControlParams;

	public abstract void OnSignal();
}
