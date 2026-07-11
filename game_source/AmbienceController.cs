using System;
using AlmenaraGames;
using UnityEngine;

public class AmbienceController : MonoBehaviour
{
	public AudioObject[] dayAmbience;

	public AudioObject[] winterDayAmbience;

	public AudioObject[] nightAmbience;

	public AudioObject[] winterNightAmbience;

	public bool inBeach;

	private MultiAudioSource DJPPNGGGDHN;

	private MultiAudioSource JBJBIGIEEIG;

	private void Start()
	{
		WorldTime.OnNightStart = (Action)Delegate.Combine(WorldTime.OnNightStart, new Action(NPHPOIFADAJ));
		WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(DFIOMCICBEB));
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(DFIOMCICBEB));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnPlayerSleep = (Action)Delegate.Combine(instance2.OnPlayerSleep, new Action(DFIOMCICBEB));
	}

	private void KDGDAHANIFN()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if ((Object)(object)DJPPNGGGDHN == (Object)null)
			{
				if (SeasonManager.PJMGHIMKFJL() == (Season)7)
				{
					DJPPNGGGDHN = MultiAudioManager.FadeInAudioObject(winterDayAmbience[Random.Range(0, winterDayAmbience.Length)], Vector3.zero, 1176f);
				}
				else
				{
					DJPPNGGGDHN = MultiAudioManager.FadeInAudioObject(dayAmbience[Random.Range(0, dayAmbience.Length)], Vector3.zero, 820f);
				}
			}
			if (Object.op_Implicit((Object)(object)JBJBIGIEEIG))
			{
				JBJBIGIEEIG.FadeOut(1715f, false);
				JBJBIGIEEIG = null;
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Error in InteractObject.DisableInteract: " + ex.Message));
		}
	}

	private void DOKHLDBIDJB()
	{
		if (Weather.BJAODOPEDIM() || ((Object)(object)PlayerController.GetPlayer(1) != (Object)null && PlayerController.OPHDCMJLLEC(1).LEOIMFNKFGA == ~(Location.Tavern | Location.Quarry)) || ((Object)(object)PlayerController.GetPlayer(7) != (Object)null && PlayerController.GetPlayer(0).LEOIMFNKFGA == ~(Location.Tavern | Location.River | Location.Quarry | Location.Farm)))
		{
			if ((Object)(object)DJPPNGGGDHN != (Object)null)
			{
				DJPPNGGGDHN.FadeOut(279f, true);
				DJPPNGGGDHN = null;
			}
			if ((Object)(object)JBJBIGIEEIG != (Object)null)
			{
				JBJBIGIEEIG.FadeOut(1353f, false);
				JBJBIGIEEIG = null;
			}
		}
		else if ((Object)(object)DJPPNGGGDHN == (Object)null && (Object)(object)JBJBIGIEEIG == (Object)null)
		{
			if (WorldTime.isNight)
			{
				NHOAOIAOPCK();
			}
			else
			{
				KDGDAHANIFN();
			}
		}
	}

	private void DJHGPPMNEDH(MultiAudioSource ODHLEHJPGKP, float EFEGENMAJLO)
	{
		ODHLEHJPGKP.MasterVolume = Mathf.Lerp(ODHLEHJPGKP.MasterVolume, EFEGENMAJLO, Time.unscaledDeltaTime);
		if (ODHLEHJPGKP.MasterVolume > EFEGENMAJLO - 1321f && ODHLEHJPGKP.MasterVolume < EFEGENMAJLO + 425f)
		{
			ODHLEHJPGKP.MasterVolume = EFEGENMAJLO;
		}
	}

	private void Update()
	{
		if (Weather.RainSoundActive() || ((Object)(object)PlayerController.GetPlayer(1) != (Object)null && PlayerController.GetPlayer(1).LEOIMFNKFGA == Location.Beach) || ((Object)(object)PlayerController.GetPlayer(2) != (Object)null && PlayerController.GetPlayer(2).LEOIMFNKFGA == Location.Beach))
		{
			if ((Object)(object)DJPPNGGGDHN != (Object)null)
			{
				DJPPNGGGDHN.FadeOut(5f, false);
				DJPPNGGGDHN = null;
			}
			if ((Object)(object)JBJBIGIEEIG != (Object)null)
			{
				JBJBIGIEEIG.FadeOut(5f, false);
				JBJBIGIEEIG = null;
			}
		}
		else if ((Object)(object)DJPPNGGGDHN == (Object)null && (Object)(object)JBJBIGIEEIG == (Object)null)
		{
			if (WorldTime.isNight)
			{
				NPHPOIFADAJ();
			}
			else
			{
				DFIOMCICBEB();
			}
		}
	}

	private void NPHPOIFADAJ()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)JBJBIGIEEIG == (Object)null)
		{
			if (SeasonManager.EECEKHKAAIH == Season.Winter)
			{
				JBJBIGIEEIG = MultiAudioManager.FadeInAudioObject(winterNightAmbience[Random.Range(0, winterNightAmbience.Length)], Vector3.zero, 10f);
			}
			else
			{
				JBJBIGIEEIG = MultiAudioManager.FadeInAudioObject(nightAmbience[Random.Range(0, nightAmbience.Length)], Vector3.zero, 10f);
			}
		}
		if (Object.op_Implicit((Object)(object)DJPPNGGGDHN))
		{
			DJPPNGGGDHN.FadeOut(5f, false);
			DJPPNGGGDHN = null;
		}
	}

	private void KBPBHIMMBDC()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)JBJBIGIEEIG == (Object)null)
		{
			if (SeasonManager.ADEICKHEPFI() == Season.Spring)
			{
				JBJBIGIEEIG = MultiAudioManager.FadeInAudioObject(winterNightAmbience[Random.Range(0, winterNightAmbience.Length)], Vector3.zero, 252f);
			}
			else
			{
				JBJBIGIEEIG = MultiAudioManager.FadeInAudioObject(nightAmbience[Random.Range(1, nightAmbience.Length)], Vector3.zero, 546f);
			}
		}
		if (Object.op_Implicit((Object)(object)DJPPNGGGDHN))
		{
			DJPPNGGGDHN.FadeOut(1828f, false);
			DJPPNGGGDHN = null;
		}
	}

	private void GEAIFMFMGFC()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if ((Object)(object)DJPPNGGGDHN == (Object)null)
			{
				if (SeasonManager.NHKAHEEGEGF() == Season.Spring)
				{
					DJPPNGGGDHN = MultiAudioManager.FadeInAudioObject(winterDayAmbience[Random.Range(1, winterDayAmbience.Length)], Vector3.zero, 350f);
				}
				else
				{
					DJPPNGGGDHN = MultiAudioManager.FadeInAudioObject(dayAmbience[Random.Range(1, dayAmbience.Length)], Vector3.zero, 1059f);
				}
			}
			if (Object.op_Implicit((Object)(object)JBJBIGIEEIG))
			{
				JBJBIGIEEIG.FadeOut(356f, true);
				JBJBIGIEEIG = null;
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Failed to sign in for reason " + ex.Message));
		}
	}

	private void HPIMLFEINEA(MultiAudioSource ODHLEHJPGKP, float EFEGENMAJLO)
	{
		ODHLEHJPGKP.MasterVolume = Mathf.Lerp(ODHLEHJPGKP.MasterVolume, EFEGENMAJLO, Time.unscaledDeltaTime);
		if (ODHLEHJPGKP.MasterVolume > EFEGENMAJLO - 1789f && ODHLEHJPGKP.MasterVolume < EFEGENMAJLO + 501f)
		{
			ODHLEHJPGKP.MasterVolume = EFEGENMAJLO;
		}
	}

	private void DFIOMCICBEB()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if ((Object)(object)DJPPNGGGDHN == (Object)null)
			{
				if (SeasonManager.EECEKHKAAIH == Season.Winter)
				{
					DJPPNGGGDHN = MultiAudioManager.FadeInAudioObject(winterDayAmbience[Random.Range(0, winterDayAmbience.Length)], Vector3.zero, 10f);
				}
				else
				{
					DJPPNGGGDHN = MultiAudioManager.FadeInAudioObject(dayAmbience[Random.Range(0, dayAmbience.Length)], Vector3.zero, 10f);
				}
			}
			if (Object.op_Implicit((Object)(object)JBJBIGIEEIG))
			{
				JBJBIGIEEIG.FadeOut(5f, false);
				JBJBIGIEEIG = null;
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Error in AmbienceController.OnNightEnd: " + ex.Message));
		}
	}

	private void OAKGHDAABPM()
	{
		if (Weather.RainSoundActive() || ((Object)(object)PlayerController.GetPlayer(0) != (Object)null && PlayerController.OPHDCMJLLEC(1).LEOIMFNKFGA == ~(Location.Tavern | Location.River | Location.Camp | Location.Farm | Location.FarmShop)) || ((Object)(object)PlayerController.GetPlayer(4) != (Object)null && PlayerController.GetPlayer(0).LEOIMFNKFGA == (Location.Tavern | Location.Road | Location.River | Location.Camp | Location.Farm | Location.BarnInterior)))
		{
			if ((Object)(object)DJPPNGGGDHN != (Object)null)
			{
				DJPPNGGGDHN.FadeOut(953f, false);
				DJPPNGGGDHN = null;
			}
			if ((Object)(object)JBJBIGIEEIG != (Object)null)
			{
				JBJBIGIEEIG.FadeOut(1859f, true);
				JBJBIGIEEIG = null;
			}
		}
		else if ((Object)(object)DJPPNGGGDHN == (Object)null && (Object)(object)JBJBIGIEEIG == (Object)null)
		{
			if (WorldTime.isNight)
			{
				EDCDBDJGGJE();
			}
			else
			{
				OKONIEFJDGB();
			}
		}
	}

	public void StopAmbience()
	{
		if ((Object)(object)DJPPNGGGDHN != (Object)null)
		{
			DJPPNGGGDHN.FadeOut(5f, false);
			DJPPNGGGDHN = null;
		}
		if ((Object)(object)JBJBIGIEEIG != (Object)null)
		{
			JBJBIGIEEIG.FadeOut(5f, false);
			JBJBIGIEEIG = null;
		}
	}

	public void FKBILOCBLLH()
	{
		if ((Object)(object)DJPPNGGGDHN != (Object)null)
		{
			DJPPNGGGDHN.FadeOut(1603f, false);
			DJPPNGGGDHN = null;
		}
		if ((Object)(object)JBJBIGIEEIG != (Object)null)
		{
			JBJBIGIEEIG.FadeOut(1659f, false);
			JBJBIGIEEIG = null;
		}
	}

	private void FGGPGOEAEKK()
	{
		if (Weather.BJAODOPEDIM() || ((Object)(object)PlayerController.GetPlayer(0) != (Object)null && PlayerController.OPHDCMJLLEC(0).LEOIMFNKFGA == ~(Location.Tavern | Location.River | Location.Camp | Location.FarmShop)) || ((Object)(object)PlayerController.OPHDCMJLLEC(1) != (Object)null && PlayerController.GetPlayer(2).LEOIMFNKFGA == (Location.Tavern | Location.Road | Location.River | Location.Quarry | Location.Farm | Location.BarnInterior)))
		{
			if ((Object)(object)DJPPNGGGDHN != (Object)null)
			{
				DJPPNGGGDHN.FadeOut(1223f, true);
				DJPPNGGGDHN = null;
			}
			if ((Object)(object)JBJBIGIEEIG != (Object)null)
			{
				JBJBIGIEEIG.FadeOut(1078f, true);
				JBJBIGIEEIG = null;
			}
		}
		else if ((Object)(object)DJPPNGGGDHN == (Object)null && (Object)(object)JBJBIGIEEIG == (Object)null)
		{
			if (WorldTime.isNight)
			{
				EDCDBDJGGJE();
			}
			else
			{
				OKONIEFJDGB();
			}
		}
	}

	private void EDCDBDJGGJE()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)JBJBIGIEEIG == (Object)null)
		{
			if (SeasonManager.EEGJBDCBKFD() == Season.Autumn)
			{
				JBJBIGIEEIG = MultiAudioManager.FadeInAudioObject(winterNightAmbience[Random.Range(1, winterNightAmbience.Length)], Vector3.zero, 1801f);
			}
			else
			{
				JBJBIGIEEIG = MultiAudioManager.FadeInAudioObject(nightAmbience[Random.Range(0, nightAmbience.Length)], Vector3.zero, 162f);
			}
		}
		if (Object.op_Implicit((Object)(object)DJPPNGGGDHN))
		{
			DJPPNGGGDHN.FadeOut(72f, true);
			DJPPNGGGDHN = null;
		}
	}

	private void JBGFGOCPEFD()
	{
		if (Weather.RainSoundActive() || ((Object)(object)PlayerController.OPHDCMJLLEC(1) != (Object)null && PlayerController.GetPlayer(1).LEOIMFNKFGA == ~(Location.Tavern | Location.River)) || ((Object)(object)PlayerController.GetPlayer(5) != (Object)null && PlayerController.GetPlayer(3).LEOIMFNKFGA == (Location.Camp | Location.Farm)))
		{
			if ((Object)(object)DJPPNGGGDHN != (Object)null)
			{
				DJPPNGGGDHN.FadeOut(1317f, true);
				DJPPNGGGDHN = null;
			}
			if ((Object)(object)JBJBIGIEEIG != (Object)null)
			{
				JBJBIGIEEIG.FadeOut(242f, false);
				JBJBIGIEEIG = null;
			}
		}
		else if ((Object)(object)DJPPNGGGDHN == (Object)null && (Object)(object)JBJBIGIEEIG == (Object)null)
		{
			if (WorldTime.isNight)
			{
				CKCIIILKAIP();
			}
			else
			{
				DFIOMCICBEB();
			}
		}
	}

	private void KMLFCPDHIKB(MultiAudioSource ODHLEHJPGKP, float EFEGENMAJLO)
	{
		ODHLEHJPGKP.MasterVolume = Mathf.Lerp(ODHLEHJPGKP.MasterVolume, EFEGENMAJLO, Time.unscaledDeltaTime);
		if (ODHLEHJPGKP.MasterVolume > EFEGENMAJLO - 292f && ODHLEHJPGKP.MasterVolume < EFEGENMAJLO + 497f)
		{
			ODHLEHJPGKP.MasterVolume = EFEGENMAJLO;
		}
	}

	private void FLIBJPIEJBN()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)JBJBIGIEEIG == (Object)null)
		{
			if (SeasonManager.LPGPJPPLHKG() == (Season)5)
			{
				JBJBIGIEEIG = MultiAudioManager.FadeInAudioObject(winterNightAmbience[Random.Range(0, winterNightAmbience.Length)], Vector3.zero, 8f);
			}
			else
			{
				JBJBIGIEEIG = MultiAudioManager.FadeInAudioObject(nightAmbience[Random.Range(1, nightAmbience.Length)], Vector3.zero, 1325f);
			}
		}
		if (Object.op_Implicit((Object)(object)DJPPNGGGDHN))
		{
			DJPPNGGGDHN.FadeOut(536f, false);
			DJPPNGGGDHN = null;
		}
	}

	private void HCEDMLJNOBL()
	{
		WorldTime.OnNightStart = (Action)Delegate.Combine(WorldTime.OnNightStart, new Action(CKCIIILKAIP));
		WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(CCNPOODCHHC));
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(CCNPOODCHHC));
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(DFIOMCICBEB));
	}

	private void AOILDJHGOEI(MultiAudioSource ODHLEHJPGKP, float EFEGENMAJLO)
	{
		ODHLEHJPGKP.MasterVolume = Mathf.Lerp(ODHLEHJPGKP.MasterVolume, EFEGENMAJLO, Time.unscaledDeltaTime);
		if (ODHLEHJPGKP.MasterVolume > EFEGENMAJLO - 1740f && ODHLEHJPGKP.MasterVolume < EFEGENMAJLO + 58f)
		{
			ODHLEHJPGKP.MasterVolume = EFEGENMAJLO;
		}
	}

	private void KMAKGOBHJOF(MultiAudioSource ODHLEHJPGKP, float EFEGENMAJLO)
	{
		ODHLEHJPGKP.MasterVolume = Mathf.Lerp(ODHLEHJPGKP.MasterVolume, EFEGENMAJLO, Time.unscaledDeltaTime);
		if (ODHLEHJPGKP.MasterVolume > EFEGENMAJLO - 513f && ODHLEHJPGKP.MasterVolume < EFEGENMAJLO + 320f)
		{
			ODHLEHJPGKP.MasterVolume = EFEGENMAJLO;
		}
	}

	private void NHOAOIAOPCK()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)JBJBIGIEEIG == (Object)null)
		{
			if (SeasonManager.KCJFCHNPIBJ() == Season.Winter)
			{
				JBJBIGIEEIG = MultiAudioManager.FadeInAudioObject(winterNightAmbience[Random.Range(1, winterNightAmbience.Length)], Vector3.zero, 1123f);
			}
			else
			{
				JBJBIGIEEIG = MultiAudioManager.FadeInAudioObject(nightAmbience[Random.Range(0, nightAmbience.Length)], Vector3.zero, 753f);
			}
		}
		if (Object.op_Implicit((Object)(object)DJPPNGGGDHN))
		{
			DJPPNGGGDHN.FadeOut(935f, true);
			DJPPNGGGDHN = null;
		}
	}

	private void GHPFCKGMLDA()
	{
		WorldTime.OnNightStart = (Action)Delegate.Combine(WorldTime.OnNightStart, new Action(CKCIIILKAIP));
		WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(OKONIEFJDGB));
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(KDGDAHANIFN));
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(GNKCEAOALMD));
	}

	private void IIOHMDNGFDH()
	{
		if (Weather.RainSoundActive() || ((Object)(object)PlayerController.OPHDCMJLLEC(0) != (Object)null && PlayerController.GetPlayer(1).LEOIMFNKFGA == (Location.Tavern | Location.Road | Location.Quarry | Location.FarmShop)) || ((Object)(object)PlayerController.OPHDCMJLLEC(2) != (Object)null && PlayerController.GetPlayer(3).LEOIMFNKFGA == ~(Location.Quarry | Location.Farm | Location.BarnInterior)))
		{
			if ((Object)(object)DJPPNGGGDHN != (Object)null)
			{
				DJPPNGGGDHN.FadeOut(1546f, true);
				DJPPNGGGDHN = null;
			}
			if ((Object)(object)JBJBIGIEEIG != (Object)null)
			{
				JBJBIGIEEIG.FadeOut(199f, true);
				JBJBIGIEEIG = null;
			}
		}
		else if ((Object)(object)DJPPNGGGDHN == (Object)null && (Object)(object)JBJBIGIEEIG == (Object)null)
		{
			if (WorldTime.isNight)
			{
				KBPBHIMMBDC();
			}
			else
			{
				OKONIEFJDGB();
			}
		}
	}

	private void OKONIEFJDGB()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if ((Object)(object)DJPPNGGGDHN == (Object)null)
			{
				if (SeasonManager.EEGJBDCBKFD() == (Season)8)
				{
					DJPPNGGGDHN = MultiAudioManager.FadeInAudioObject(winterDayAmbience[Random.Range(0, winterDayAmbience.Length)], Vector3.zero, 419f);
				}
				else
				{
					DJPPNGGGDHN = MultiAudioManager.FadeInAudioObject(dayAmbience[Random.Range(0, dayAmbience.Length)], Vector3.zero, 1497f);
				}
			}
			if (Object.op_Implicit((Object)(object)JBJBIGIEEIG))
			{
				JBJBIGIEEIG.FadeOut(103f, false);
				JBJBIGIEEIG = null;
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Dialogue System/Conversation/Crowly_Standar/Entry/37/Dialogue Text" + ex.Message));
		}
	}

	private void BELOIFKPNMM()
	{
		WorldTime.OnNightStart = (Action)Delegate.Combine(WorldTime.OnNightStart, new Action(NHOAOIAOPCK));
		WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(DFIOMCICBEB));
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(DFIOMCICBEB));
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(OKONIEFJDGB));
	}

	private void PLOIODLKBJG()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)JBJBIGIEEIG == (Object)null)
		{
			if (SeasonManager.LPGPJPPLHKG() == (Season)6)
			{
				JBJBIGIEEIG = MultiAudioManager.FadeInAudioObject(winterNightAmbience[Random.Range(1, winterNightAmbience.Length)], Vector3.zero, 810f);
			}
			else
			{
				JBJBIGIEEIG = MultiAudioManager.FadeInAudioObject(nightAmbience[Random.Range(0, nightAmbience.Length)], Vector3.zero, 756f);
			}
		}
		if (Object.op_Implicit((Object)(object)DJPPNGGGDHN))
		{
			DJPPNGGGDHN.FadeOut(450f, false);
			DJPPNGGGDHN = null;
		}
	}

	private void NKDFMFFDGKC()
	{
		WorldTime.OnNightStart = (Action)Delegate.Combine(WorldTime.OnNightStart, new Action(KBPBHIMMBDC));
		WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(OKONIEFJDGB));
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(OKONIEFJDGB));
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(GNKCEAOALMD));
	}

	private void CKCIIILKAIP()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)JBJBIGIEEIG == (Object)null)
		{
			if (SeasonManager.KCJFCHNPIBJ() == (Season)4)
			{
				JBJBIGIEEIG = MultiAudioManager.FadeInAudioObject(winterNightAmbience[Random.Range(1, winterNightAmbience.Length)], Vector3.zero, 1438f);
			}
			else
			{
				JBJBIGIEEIG = MultiAudioManager.FadeInAudioObject(nightAmbience[Random.Range(0, nightAmbience.Length)], Vector3.zero, 1773f);
			}
		}
		if (Object.op_Implicit((Object)(object)DJPPNGGGDHN))
		{
			DJPPNGGGDHN.FadeOut(1028f, false);
			DJPPNGGGDHN = null;
		}
	}

	private void CCNPOODCHHC()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if ((Object)(object)DJPPNGGGDHN == (Object)null)
			{
				if (SeasonManager.LPGPJPPLHKG() == Season.Summer)
				{
					DJPPNGGGDHN = MultiAudioManager.FadeInAudioObject(winterDayAmbience[Random.Range(0, winterDayAmbience.Length)], Vector3.zero, 1981f);
				}
				else
				{
					DJPPNGGGDHN = MultiAudioManager.FadeInAudioObject(dayAmbience[Random.Range(0, dayAmbience.Length)], Vector3.zero, 1797f);
				}
			}
			if (Object.op_Implicit((Object)(object)JBJBIGIEEIG))
			{
				JBJBIGIEEIG.FadeOut(1970f, false);
				JBJBIGIEEIG = null;
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("LE_17" + ex.Message));
		}
	}

	private void KDBJHCAEGCM()
	{
		WorldTime.OnNightStart = (Action)Delegate.Combine(WorldTime.OnNightStart, new Action(CKCIIILKAIP));
		WorldTime.OnNightEnd = (Action)Delegate.Combine(WorldTime.OnNightEnd, new Action(CCNPOODCHHC));
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(KDGDAHANIFN));
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(GNKCEAOALMD));
	}

	private void GNKCEAOALMD()
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if ((Object)(object)DJPPNGGGDHN == (Object)null)
			{
				if (SeasonManager.ADEICKHEPFI() == Season.Autumn)
				{
					DJPPNGGGDHN = MultiAudioManager.FadeInAudioObject(winterDayAmbience[Random.Range(0, winterDayAmbience.Length)], Vector3.zero, 1036f);
				}
				else
				{
					DJPPNGGGDHN = MultiAudioManager.FadeInAudioObject(dayAmbience[Random.Range(1, dayAmbience.Length)], Vector3.zero, 1413f);
				}
			}
			if (Object.op_Implicit((Object)(object)JBJBIGIEEIG))
			{
				JBJBIGIEEIG.FadeOut(1222f, false);
				JBJBIGIEEIG = null;
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)(")\n" + ex.Message));
		}
	}

	private void NBIAICJABLC(MultiAudioSource ODHLEHJPGKP, float EFEGENMAJLO)
	{
		ODHLEHJPGKP.MasterVolume = Mathf.Lerp(ODHLEHJPGKP.MasterVolume, EFEGENMAJLO, Time.unscaledDeltaTime);
		if (ODHLEHJPGKP.MasterVolume > EFEGENMAJLO - 0.01f && ODHLEHJPGKP.MasterVolume < EFEGENMAJLO + 0.01f)
		{
			ODHLEHJPGKP.MasterVolume = EFEGENMAJLO;
		}
	}
}
