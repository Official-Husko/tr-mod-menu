using UnityEngine;

public abstract class PsaiSynchronizedTrigger : PsaiTriggerBase
{
	protected bool PGNDCDCGANJ;

	private float KBFJEAGEJEB;

	public bool addUpIntensities;

	public float limitIntensitySum = 1f;

	public bool interruptAnyTheme;

	private bool HFFHDPGGADK;

	protected void PBIABMHBDCA()
	{
		if (EvaluateAllTriggerConditions())
		{
			if (PsaiCoreManager.HFBLDMHFBDJ.logTriggerScripts)
			{
				Debug.Log((object)$"psai [{(int)(Time.timeSinceLevelLoad * 1000f)}]: firing synchronized One-Shot Trigger: {this}");
			}
			if (TriggerType == PsaiTriggerType.triggerMusicTheme)
			{
				float jLLOJEPJLKM = CalculateTriggerIntensity();
				KCALEAPCKOB(jLLOJEPJLKM);
			}
			else
			{
				PsaiCoreManager.HFBLDMHFBDJ.RegisterSynchronizedOneShotPlaybackCommandForNextTick(this);
			}
		}
	}

	public virtual void OnEnable()
	{
		if (PGNDCDCGANJ || fireContinuously)
		{
			PsaiCoreManager instance = PsaiCoreManager.HFBLDMHFBDJ;
			if ((Object)(object)instance != (Object)null)
			{
				instance.RegisterContinuousTrigger(this);
				HFFHDPGGADK = true;
			}
		}
		LFAMLALJJLN = ((Component)this).gameObject.GetComponents<PsaiTriggerCondition>();
	}

	public virtual void OnDisable()
	{
		if (HFFHDPGGADK)
		{
			PsaiCoreManager instance = PsaiCoreManager.HFBLDMHFBDJ;
			if ((Object)(object)instance != (Object)null)
			{
				instance.UnregisterContinuousTrigger(this);
				HFFHDPGGADK = false;
			}
		}
		if (resetHasFiredStateOnDisable)
		{
			hasFired = false;
		}
	}

	private void KCALEAPCKOB(float JLLOJEPJLKM)
	{
		PsaiCoreManager.TriggerMusicThemeCall eHKBHFEBMOK = new PsaiCoreManager.TriggerMusicThemeCall(this, themeId, JLLOJEPJLKM, 0);
		eHKBHFEBMOK.forceImmediateStopBeforeTriggering = interruptAnyTheme;
		if (overrideMusicDurationInSeconds && musicDurationInSeconds > 0)
		{
			eHKBHFEBMOK.musicDurationInSeconds = musicDurationInSeconds;
		}
		PsaiCoreManager.HFBLDMHFBDJ.RegisterOneShotTriggerCall(eHKBHFEBMOK);
	}

	protected void Update()
	{
		if (PGNDCDCGANJ && !HFFHDPGGADK)
		{
			KBFJEAGEJEB += Time.deltaTime;
			if (KBFJEAGEJEB > PsaiCoreManager.HFBLDMHFBDJ.triggerEvaluationIntervalInSeconds)
			{
				KBFJEAGEJEB -= PsaiCoreManager.HFBLDMHFBDJ.triggerEvaluationIntervalInSeconds;
				PBIABMHBDCA();
			}
		}
	}
}
