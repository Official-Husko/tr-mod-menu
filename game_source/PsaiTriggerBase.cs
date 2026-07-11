using System;
using UnityEngine;
using psai.net;

public abstract class PsaiTriggerBase : MonoBehaviour
{
	[Serializable]
	public enum PsaiTriggerType
	{
		triggerMusicTheme,
		returnToLastBasicMood,
		stopMusic
	}

	public PsaiTriggerType TriggerType;

	public int themeId = 1;

	public bool _immediately;

	public bool _keepSilentUntilNextTrigger = true;

	public bool _overrideDefaultFadeoutTime;

	public float _fadeOutSeconds = 3f;

	public bool _dontExecuteIfOtherTriggersAreFiring;

	public ThemeType _restrictBlockToThisThemeType;

	public bool _overrideDefaultRestTime;

	public int _overrideRestSecondsMin = 30;

	public int _overrideRestSecondsMax = 60;

	public bool overrideMusicDurationInSeconds;

	public int musicDurationInSeconds = 10;

	protected PsaiTriggerCondition[] LFAMLALJJLN;

	public bool fireContinuously;

	public bool deactivateAfterFiringOnce;

	public bool hasFired;

	public bool resetHasFiredStateOnDisable;

	protected void Awake()
	{
		LFAMLALJJLN = ((Component)this).gameObject.GetComponents<PsaiTriggerCondition>();
	}

	public abstract float CalculateTriggerIntensity();

	public bool EvaluateAllTriggerConditions()
	{
		if (!fireContinuously && deactivateAfterFiringOnce && hasFired)
		{
			return false;
		}
		for (int i = 0; i < LFAMLALJJLN.Length; i++)
		{
			if (!LFAMLALJJLN[i].EvaluateTriggerCondition())
			{
				return false;
			}
		}
		return EvaluateTriggerCondition();
	}

	public virtual bool EvaluateTriggerCondition()
	{
		return true;
	}

	public void FireDirectOneShotTrigger()
	{
		switch (TriggerType)
		{
		case PsaiTriggerType.triggerMusicTheme:
		{
			float intensity = CalculateTriggerIntensity();
			if (overrideMusicDurationInSeconds && musicDurationInSeconds > 0)
			{
				PsaiCore.Instance.TriggerMusicTheme(themeId, intensity, musicDurationInSeconds);
			}
			else
			{
				PsaiCore.Instance.TriggerMusicTheme(themeId, intensity);
			}
			break;
		}
		case PsaiTriggerType.returnToLastBasicMood:
			PsaiCore.Instance.ReturnToLastBasicMood(_immediately);
			break;
		case PsaiTriggerType.stopMusic:
			if (_keepSilentUntilNextTrigger)
			{
				PsaiCore.Instance.StopMusic(_immediately, _fadeOutSeconds);
			}
			else if (_overrideDefaultRestTime)
			{
				PsaiCore.Instance.GoToRest(_immediately, _fadeOutSeconds, _overrideRestSecondsMin * 1000, _overrideRestSecondsMax * 1000);
			}
			else
			{
				PsaiCore.Instance.GoToRest(_immediately, _fadeOutSeconds);
			}
			break;
		}
		if (PsaiCoreManager.HFBLDMHFBDJ.logTriggerScripts)
		{
			Debug.Log((object)$"psai [{(int)(Time.timeSinceLevelLoad * 1000f)}]: Trigger fired: {this}");
		}
		hasFired = true;
	}

	public void TryToFireDirectOneShotTrigger()
	{
		if (EvaluateAllTriggerConditions())
		{
			FireDirectOneShotTrigger();
		}
	}
}
