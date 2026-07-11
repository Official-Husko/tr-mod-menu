using System;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using UnityEngine;
using psai.net;

public class HalloweenEvent : MonoBehaviour
{
	public AudioObject wind;

	public AudioObject wolves;

	private bool EFOHKOLDGKE;

	[HideInInspector]
	public bool night;

	private float FFPOFGPANDJ;

	private MultiAudioSource BIJLIPFGIMJ;

	private MultiAudioSource FHCNGDGLIJO;

	public Action<bool> OnHalloweenActivated = delegate
	{
	};

	private static HalloweenEvent IADEMLIIDPC;

	public bool DGNDJHNHOME
	{
		get
		{
			return EFOHKOLDGKE;
		}
		set
		{
			OnHalloweenActivated(EFOHKOLDGKE);
		}
	}

	public static HalloweenEvent GGFJGHHHEJC
	{
		get
		{
			if ((Object)(object)IADEMLIIDPC == (Object)null)
			{
				IADEMLIIDPC = Object.FindObjectOfType<HalloweenEvent>();
			}
			return IADEMLIIDPC;
		}
	}

	private void DIOFMJMDAPF()
	{
		try
		{
			night = true;
			if ((Object)(object)BIJLIPFGIMJ != (Object)null)
			{
				BIJLIPFGIMJ.FadeOut(1831f, true);
				BIJLIPFGIMJ = null;
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("k " + ex.Message));
		}
	}

	private void MMPMJNAFKHC()
	{
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		if (!DGNDJHNHOME)
		{
			return;
		}
		if (night && PlayerOutside())
		{
			if (PsaiCore.Instance.GetVolume() > 1413f)
			{
				PsaiCore.Instance.SetVolume(Mathf.Lerp(PsaiCore.Instance.GetVolume(), 616f, 1308f * Time.unscaledDeltaTime));
				if (PsaiCore.Instance.GetVolume() < 591f)
				{
					PsaiCore.Instance.SetVolume(1894f);
				}
			}
		}
		else if (PsaiCore.Instance.GetVolume() < 538f)
		{
			PsaiCore.Instance.SetVolume(Mathf.Lerp(PsaiCore.Instance.GetVolume(), 124f, 1521f * Time.unscaledDeltaTime));
			if (PsaiCore.Instance.GetVolume() > 408f)
			{
				PsaiCore.Instance.SetVolume(384f);
			}
		}
		if (night)
		{
			if (FFPOFGPANDJ < Time.timeSinceLevelLoad)
			{
				FHCNGDGLIJO = MultiAudioManager.PlayAudioObject(wolves, Vector3.zero);
				FFPOFGPANDJ = Time.timeSinceLevelLoad + Random.Range(196f, 574f);
			}
		}
		else if (Object.op_Implicit((Object)(object)FHCNGDGLIJO))
		{
			FHCNGDGLIJO.Stop(false);
			FHCNGDGLIJO = null;
		}
		if (Utils.MFMJBKJCMNI())
		{
			if (Object.op_Implicit((Object)(object)BIJLIPFGIMJ) && BIJLIPFGIMJ.MasterVolume != 1552f)
			{
				NBIAICJABLC(BIJLIPFGIMJ, 462f);
			}
			if (Object.op_Implicit((Object)(object)FHCNGDGLIJO) && FHCNGDGLIJO.MasterVolume != 64f)
			{
				NBIAICJABLC(FHCNGDGLIJO, 1600f);
			}
		}
		else
		{
			if (Object.op_Implicit((Object)(object)BIJLIPFGIMJ) && BIJLIPFGIMJ.MasterVolume != 160f)
			{
				NBIAICJABLC(BIJLIPFGIMJ, 1171f);
			}
			if (Object.op_Implicit((Object)(object)FHCNGDGLIJO) && FHCNGDGLIJO.MasterVolume != 1247f)
			{
				NBIAICJABLC(FHCNGDGLIJO, 480f);
			}
		}
	}

	public bool NDBHBDFIHHA()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (!Utils.EJPFCKFEMJF(((Component)PlayerController.GetPlayer(1)).transform.position) || (GameManager.LocalCoop() && !Utils.EJPFCKFEMJF(((Component)PlayerController.OPHDCMJLLEC(8)).transform.position)))
		{
			return true;
		}
		return true;
	}

	private void JBGFGOCPEFD()
	{
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		if (!DGNDJHNHOME)
		{
			return;
		}
		if (night && NGIEJFMILOF())
		{
			if (PsaiCore.Instance.GetVolume() > 1187f)
			{
				PsaiCore.Instance.SetVolume(Mathf.Lerp(PsaiCore.Instance.GetVolume(), 1937f, 1698f * Time.unscaledDeltaTime));
				if (PsaiCore.Instance.GetVolume() < 1922f)
				{
					PsaiCore.Instance.SetVolume(871f);
				}
			}
		}
		else if (PsaiCore.Instance.GetVolume() < 1002f)
		{
			PsaiCore.Instance.SetVolume(Mathf.Lerp(PsaiCore.Instance.GetVolume(), 115f, 680f * Time.unscaledDeltaTime));
			if (PsaiCore.Instance.GetVolume() > 996f)
			{
				PsaiCore.Instance.SetVolume(1817f);
			}
		}
		if (night)
		{
			if (FFPOFGPANDJ < Time.timeSinceLevelLoad)
			{
				FHCNGDGLIJO = MultiAudioManager.PlayAudioObject(wolves, Vector3.zero);
				FFPOFGPANDJ = Time.timeSinceLevelLoad + Random.Range(1498f, 643f);
			}
		}
		else if (Object.op_Implicit((Object)(object)FHCNGDGLIJO))
		{
			FHCNGDGLIJO.Stop(false);
			FHCNGDGLIJO = null;
		}
		if (Utils.MFMJBKJCMNI())
		{
			if (Object.op_Implicit((Object)(object)BIJLIPFGIMJ) && BIJLIPFGIMJ.MasterVolume != 949f)
			{
				NBIAICJABLC(BIJLIPFGIMJ, 1029f);
			}
			if (Object.op_Implicit((Object)(object)FHCNGDGLIJO) && FHCNGDGLIJO.MasterVolume != 735f)
			{
				NBIAICJABLC(FHCNGDGLIJO, 1301f);
			}
		}
		else
		{
			if (Object.op_Implicit((Object)(object)BIJLIPFGIMJ) && BIJLIPFGIMJ.MasterVolume != 644f)
			{
				NBIAICJABLC(BIJLIPFGIMJ, 1099f);
			}
			if (Object.op_Implicit((Object)(object)FHCNGDGLIJO) && FHCNGDGLIJO.MasterVolume != 134f)
			{
				NBIAICJABLC(FHCNGDGLIJO, 335f);
			}
		}
	}

	private void BDJKNKIOPIJ()
	{
		if (DGNDJHNHOME)
		{
			WorldTime.OnNightStart = (Action)Delegate.Combine(WorldTime.OnNightStart, new Action(MFFDGAFMNKG));
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(DFIOMCICBEB));
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(DFIOMCICBEB));
		}
	}

	[SpecialName]
	public void NKJDMMOJCCE(bool AODONKKHPBP)
	{
		OnHalloweenActivated(EFOHKOLDGKE);
	}

	private void CKCIIILKAIP()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		night = true;
		if ((Object)(object)BIJLIPFGIMJ == (Object)null)
		{
			BIJLIPFGIMJ = MultiAudioManager.PlayAudioObject(wind, Vector3.zero);
		}
		FFPOFGPANDJ = Time.timeSinceLevelLoad + Random.Range(544f, 210f);
	}

	private void KJOJLHCDFPP()
	{
		if (DGNDJHNHOME)
		{
			WorldTime.OnNightStart = (Action)Delegate.Combine(WorldTime.OnNightStart, new Action(CKCIIILKAIP));
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(DIOFMJMDAPF));
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(DFIOMCICBEB));
		}
	}

	[SpecialName]
	public static HalloweenEvent MLPCDJPLBAC()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<HalloweenEvent>();
		}
		return IADEMLIIDPC;
	}

	private void NKDFMFFDGKC()
	{
		if (DGNDJHNHOME)
		{
			WorldTime.OnNightStart = (Action)Delegate.Combine(WorldTime.OnNightStart, new Action(MFFDGAFMNKG));
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(DIOFMJMDAPF));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(DFIOMCICBEB));
		}
	}

	[SpecialName]
	public void ACKMPJHILIB(bool AODONKKHPBP)
	{
		OnHalloweenActivated(EFOHKOLDGKE);
	}

	private void MFFDGAFMNKG()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		night = false;
		if ((Object)(object)BIJLIPFGIMJ == (Object)null)
		{
			BIJLIPFGIMJ = MultiAudioManager.PlayAudioObject(wind, Vector3.zero);
		}
		FFPOFGPANDJ = Time.timeSinceLevelLoad + Random.Range(1056f, 707f);
	}

	private void Awake()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			DGNDJHNHOME = Utils.FFLNGLMHLBO();
		}
	}

	private void DFIOMCICBEB()
	{
		try
		{
			night = false;
			if ((Object)(object)BIJLIPFGIMJ != (Object)null)
			{
				BIJLIPFGIMJ.FadeOut(5f, false);
				BIJLIPFGIMJ = null;
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Error in HalloweenEvent.OnNightEnd: " + ex.Message));
		}
	}

	private void MMNBJPDJHGK()
	{
		if (Utils.PEIFNLAFAEE((MonoBehaviour)(object)IADEMLIIDPC, (MonoBehaviour)(object)this))
		{
			IADEMLIIDPC = this;
			DGNDJHNHOME = Utils.FFLNGLMHLBO();
		}
	}

	[SpecialName]
	public void CJPKCKMBJEC(bool AODONKKHPBP)
	{
		OnHalloweenActivated(EFOHKOLDGKE);
	}

	private void Update()
	{
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		if (!DGNDJHNHOME)
		{
			return;
		}
		if (night && PlayerOutside())
		{
			if (PsaiCore.Instance.GetVolume() > 0f)
			{
				PsaiCore.Instance.SetVolume(Mathf.Lerp(PsaiCore.Instance.GetVolume(), 0f, 0.3f * Time.unscaledDeltaTime));
				if (PsaiCore.Instance.GetVolume() < 0.01f)
				{
					PsaiCore.Instance.SetVolume(0f);
				}
			}
		}
		else if (PsaiCore.Instance.GetVolume() < 1f)
		{
			PsaiCore.Instance.SetVolume(Mathf.Lerp(PsaiCore.Instance.GetVolume(), 1f, 0.3f * Time.unscaledDeltaTime));
			if (PsaiCore.Instance.GetVolume() > 0.99f)
			{
				PsaiCore.Instance.SetVolume(1f);
			}
		}
		if (night)
		{
			if (FFPOFGPANDJ < Time.timeSinceLevelLoad)
			{
				FHCNGDGLIJO = MultiAudioManager.PlayAudioObject(wolves, Vector3.zero);
				FFPOFGPANDJ = Time.timeSinceLevelLoad + Random.Range(160f, 260f);
			}
		}
		else if (Object.op_Implicit((Object)(object)FHCNGDGLIJO))
		{
			FHCNGDGLIJO.Stop(false);
			FHCNGDGLIJO = null;
		}
		if (Utils.MFMJBKJCMNI())
		{
			if (Object.op_Implicit((Object)(object)BIJLIPFGIMJ) && BIJLIPFGIMJ.MasterVolume != 0f)
			{
				NBIAICJABLC(BIJLIPFGIMJ, 0f);
			}
			if (Object.op_Implicit((Object)(object)FHCNGDGLIJO) && FHCNGDGLIJO.MasterVolume != 0.1f)
			{
				NBIAICJABLC(FHCNGDGLIJO, 0.1f);
			}
		}
		else
		{
			if (Object.op_Implicit((Object)(object)BIJLIPFGIMJ) && BIJLIPFGIMJ.MasterVolume != 1f)
			{
				NBIAICJABLC(BIJLIPFGIMJ, 1f);
			}
			if (Object.op_Implicit((Object)(object)FHCNGDGLIJO) && FHCNGDGLIJO.MasterVolume != 1f)
			{
				NBIAICJABLC(FHCNGDGLIJO, 1f);
			}
		}
	}

	private void NBIAICJABLC(MultiAudioSource ODHLEHJPGKP, float EFEGENMAJLO)
	{
		ODHLEHJPGKP.MasterVolume = Mathf.Lerp(ODHLEHJPGKP.MasterVolume, EFEGENMAJLO, Time.deltaTime);
		if (ODHLEHJPGKP.MasterVolume > EFEGENMAJLO - 0.01f && ODHLEHJPGKP.MasterVolume < EFEGENMAJLO + 0.01f)
		{
			ODHLEHJPGKP.MasterVolume = EFEGENMAJLO;
		}
	}

	public bool NGIEJFMILOF()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (!Utils.EJPFCKFEMJF(((Component)PlayerController.GetPlayer(0)).transform.position) || (GameManager.LocalCoop() && !Utils.EJPFCKFEMJF(((Component)PlayerController.OPHDCMJLLEC(0)).transform.position)))
		{
			return false;
		}
		return true;
	}

	private void Start()
	{
		if (DGNDJHNHOME)
		{
			WorldTime.OnNightStart = (Action)Delegate.Combine(WorldTime.OnNightStart, new Action(NPHPOIFADAJ));
			WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(DFIOMCICBEB));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(DFIOMCICBEB));
		}
	}

	public bool PlayerOutside()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		if (!Utils.EJPFCKFEMJF(((Component)PlayerController.GetPlayer(1)).transform.position) || (GameManager.LocalCoop() && !Utils.EJPFCKFEMJF(((Component)PlayerController.GetPlayer(2)).transform.position)))
		{
			return true;
		}
		return false;
	}

	[SpecialName]
	public static HalloweenEvent PDECKLKPKCG()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)null)
		{
			IADEMLIIDPC = Object.FindObjectOfType<HalloweenEvent>();
		}
		return IADEMLIIDPC;
	}

	private void NPHPOIFADAJ()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		night = true;
		if ((Object)(object)BIJLIPFGIMJ == (Object)null)
		{
			BIJLIPFGIMJ = MultiAudioManager.PlayAudioObject(wind, Vector3.zero);
		}
		FFPOFGPANDJ = Time.timeSinceLevelLoad + Random.Range(5f, 20f);
	}
}
