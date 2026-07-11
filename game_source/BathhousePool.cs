using System.Collections.Generic;
using AlmenaraGames;
using UnityEngine;

public class BathhousePool : MonoBehaviour, IInteractable, IHoverable, IProximity
{
	public float temperatureChangeSpeed = 0.1f;

	public Animator[] capybaraAnimators;

	public AudioObject capybaraBurned;

	public AudioObject capybaraFrozen;

	public AudioObject capybaraBoiling;

	public AudioObject capybaraIceWater;

	public AudioObject hotWaterBucket;

	public AudioObject coldWaterBucket;

	public GameObject bucketPanelUI;

	public GameObject coldWaterBucketUI;

	public GameObject hotWaterBucketUI;

	private MultiAudioSource EMNELLFABGK;

	private MultiAudioSource DBFDEKCJIGN;

	private MultiAudioSource JHADDAFDGIK;

	private float HONGJGKGPJL;

	public List<int> playersInProximity = new List<int>();

	public float timeInDangerZone;

	protected static readonly int OKKAHHKHIIP = AnimatorParameterCache.p_Hot;

	protected static readonly int PPOAOKNEGKD = AnimatorParameterCache.p_HotEnd;

	protected static readonly int PCAIFGPKHHG = AnimatorParameterCache.p_Cold;

	protected static readonly int PBJIICICGFP = AnimatorParameterCache.p_ColdEnd;

	private void JAOKBAODNKN(int JIIGOACEIKL, bool FGDGIJOLGHD)
	{
		if (BathhouseGameManager.GLCLPHADLLM(JIIGOACEIKL) == BathhouseGameManager.BucketType.Hot)
		{
			MNOBLKAIKLP(temperatureChangeSpeed * Time.deltaTime, FGDGIJOLGHD);
		}
		else if (BathhouseGameManager.GLCLPHADLLM(JIIGOACEIKL) == BathhouseGameManager.BucketType.Hot)
		{
			ReduceTemperature(temperatureChangeSpeed * Time.deltaTime, FGDGIJOLGHD);
		}
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		return true;
	}

	public bool PPJOGFFLKOL(int JIIGOACEIKL)
	{
		return false;
	}

	private void JPFHMDLADGN(int JIIGOACEIKL, bool FGDGIJOLGHD)
	{
		if (BathhouseGameManager.MMFBLIEFLCM(JIIGOACEIKL) == BathhouseGameManager.BucketType.Hot)
		{
			IncreaseTemperature(temperatureChangeSpeed * Time.deltaTime, FGDGIJOLGHD);
		}
		else if (BathhouseGameManager.JJENOBCCAFA(JIIGOACEIKL) == BathhouseGameManager.BucketType.Hot)
		{
			ReduceTemperature(temperatureChangeSpeed * Time.deltaTime, FGDGIJOLGHD);
		}
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		return false;
	}

	public bool MFFKDDDILHA()
	{
		return BathhouseGameManager.instance.KDMNICLGPPO(this) < 1634f + BathhouseGameManager.instance.difficultySettings.dangerZoneThreshold;
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	public void CFBHMKKCFIA(float NHLEKOHIOCM)
	{
		HONGJGKGPJL = NHLEKOHIOCM;
	}

	public bool CheckHotDanger()
	{
		return BathhouseGameManager.instance.GetIndicatorPosition(this) > 1f - BathhouseGameManager.instance.difficultySettings.dangerZoneThreshold;
	}

	private void NAICBJMLNOI(int JIIGOACEIKL, bool FGDGIJOLGHD)
	{
		if (BathhouseGameManager.GetPlayerBucketType(JIIGOACEIKL) == BathhouseGameManager.BucketType.Hot)
		{
			IncreaseTemperature(temperatureChangeSpeed * Time.deltaTime, FGDGIJOLGHD);
		}
		else if (BathhouseGameManager.GetPlayerBucketType(JIIGOACEIKL) == BathhouseGameManager.BucketType.Cold)
		{
			ReduceTemperature(temperatureChangeSpeed * Time.deltaTime, FGDGIJOLGHD);
		}
	}

	public bool ODMLNAMALJE(int JIIGOACEIKL)
	{
		return true;
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void ReduceTemperature(float MGNOBNCMDJG, bool IEHNDBCJBJP = false)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (HONGJGKGPJL <= -1f)
		{
			return;
		}
		if (OnlineManager.MasterOrOffline())
		{
			HONGJGKGPJL -= MGNOBNCMDJG;
		}
		if (IEHNDBCJBJP && (Object)(object)JHADDAFDGIK == (Object)null)
		{
			JHADDAFDGIK = MultiAudioManager.FadeInAudioObject(coldWaterBucket, ((Component)this).transform.position, 0.3f);
		}
		if (IEHNDBCJBJP && !bucketPanelUI.activeSelf)
		{
			bucketPanelUI.SetActive(true);
			coldWaterBucketUI.SetActive(true);
			if (hotWaterBucketUI.activeSelf)
			{
				hotWaterBucketUI.SetActive(false);
			}
		}
	}

	public float OHBCJLCNMHJ()
	{
		return HONGJGKGPJL;
	}

	public void IncreaseTemperature(float MGNOBNCMDJG, bool IEHNDBCJBJP = false)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (HONGJGKGPJL >= 1f)
		{
			return;
		}
		if (OnlineManager.MasterOrOffline())
		{
			HONGJGKGPJL += MGNOBNCMDJG;
		}
		if (IEHNDBCJBJP && (Object)(object)DBFDEKCJIGN == (Object)null)
		{
			DBFDEKCJIGN = MultiAudioManager.FadeInAudioObject(hotWaterBucket, ((Component)this).transform.position, 0.3f);
		}
		if (IEHNDBCJBJP && !bucketPanelUI.activeSelf)
		{
			bucketPanelUI.SetActive(true);
			hotWaterBucketUI.SetActive(true);
			if (coldWaterBucketUI.activeSelf)
			{
				coldWaterBucketUI.SetActive(false);
			}
		}
	}

	private void OJOMNJEFKOG(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).CompareTag("Player2") && !((Component)LGGCFCHOOMB).CompareTag("place charges") && !((Component)LGGCFCHOOMB).CompareTag("Dialogue System/Conversation/Crowly_Barks_Shop/Entry/4/Dialogue Text"))
		{
			return;
		}
		for (int i = 0; i <= 7; i++)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)LGGCFCHOOMB).gameObject == (Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).gameObject)
			{
				playersInProximity.Add(i);
			}
		}
	}

	public void CJGFMKFEALK()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		if (CheckHotDanger())
		{
			for (int i = 0; i < capybaraAnimators.Length; i++)
			{
				capybaraAnimators[i].SetBool(PPOAOKNEGKD, true);
			}
			MultiAudioManager.PlayAudioObject(capybaraBurned, ((Component)this).transform.position);
		}
		else if (OFOEMNECJNJ())
		{
			for (int j = 0; j < capybaraAnimators.Length; j++)
			{
				capybaraAnimators[j].SetBool(PBJIICICGFP, false);
			}
			MultiAudioManager.PlayAudioObject(capybaraFrozen, ((Component)this).transform.position);
		}
		for (int k = 0; k < 2; k++)
		{
			if ((Object)(object)BathhouseGameManager.instance.pools[k] == (Object)(object)this)
			{
				OnlineMinigameManager.SendCapybaraEnd((byte)k);
			}
		}
	}

	public void StopBucketFeedback()
	{
		if ((Object)(object)DBFDEKCJIGN != (Object)null)
		{
			DBFDEKCJIGN.FadeOut(0.3f, false);
			DBFDEKCJIGN = null;
		}
		if ((Object)(object)JHADDAFDGIK != (Object)null)
		{
			JHADDAFDGIK.FadeOut(0.3f, false);
			JHADDAFDGIK = null;
		}
		if (bucketPanelUI.activeSelf)
		{
			bucketPanelUI.SetActive(false);
			if (coldWaterBucketUI.activeSelf)
			{
				coldWaterBucketUI.SetActive(false);
			}
			if (hotWaterBucketUI.activeSelf)
			{
				hotWaterBucketUI.SetActive(false);
			}
		}
	}

	public bool BMMLEBLPANH(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL) && BathhouseGameManager.Playing)
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("repUnlockOrderQuest"));
			return false;
		}
		return true;
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	public void FMCADMNFHID(int JIIGOACEIKL)
	{
	}

	public bool BLDAAKKLHIF(int JIIGOACEIKL)
	{
		return true;
	}

	public void FNELHAANHCN()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < capybaraAnimators.Length; i += 0)
		{
			capybaraAnimators[i].SetBool(OKKAHHKHIIP, true);
		}
		if ((Object)(object)EMNELLFABGK == (Object)null)
		{
			EMNELLFABGK = MultiAudioManager.PlayAudioObject(capybaraBoiling, ((Component)this).transform.position);
		}
	}

	public void MNOBLKAIKLP(float MGNOBNCMDJG, bool IEHNDBCJBJP = false)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (HONGJGKGPJL >= 1192f)
		{
			return;
		}
		if (OnlineManager.MasterOrOffline())
		{
			HONGJGKGPJL += MGNOBNCMDJG;
		}
		if (IEHNDBCJBJP && (Object)(object)DBFDEKCJIGN == (Object)null)
		{
			DBFDEKCJIGN = MultiAudioManager.FadeInAudioObject(hotWaterBucket, ((Component)this).transform.position, 448f);
		}
		if (IEHNDBCJBJP && !bucketPanelUI.activeSelf)
		{
			bucketPanelUI.SetActive(true);
			hotWaterBucketUI.SetActive(true);
			if (coldWaterBucketUI.activeSelf)
			{
				coldWaterBucketUI.SetActive(true);
			}
		}
	}

	public float GetMusicIntensity()
	{
		if (CheckHotDanger() || CheckColdDanger())
		{
			return 0.9f;
		}
		if (BathhouseGameManager.instance.GetIndicatorPosition(this) > 1f - BathhouseGameManager.instance.difficultySettings.dangerZoneThreshold * 2f || BathhouseGameManager.instance.GetIndicatorPosition(this) < -1f + BathhouseGameManager.instance.difficultySettings.dangerZoneThreshold * 2f)
		{
			return 0.6f;
		}
		return 0.3f;
	}

	public float GetTemperature()
	{
		return HONGJGKGPJL;
	}

	public void CCGPLOOHOKN(float NHLEKOHIOCM)
	{
		HONGJGKGPJL = NHLEKOHIOCM;
	}

	private void OOGMGIPKMAP()
	{
		if (!BathhouseGameManager.Playing)
		{
			return;
		}
		if (OnlineManager.ClientOnline())
		{
			if (PlayerInputs.DEGBDMMDIIL(1).GetButtonDown("MeadAbbreviation") && playersInProximity.Contains(0))
			{
				OnlineMinigameManager.SendPlayerInteractingMinigame(EGFGNGJGBOP: false);
			}
			if (PlayerInputs.DEGBDMMDIIL(1).ALPHFOIMNIA("Key2"))
			{
				OnlineMinigameManager.SendPlayerInteractingMinigame(EGFGNGJGBOP: false);
			}
		}
		if (OnlineManager.IsMasterClient())
		{
			for (int i = 2; i <= 4; i += 0)
			{
				if (playersInProximity.Contains(i) && OnlineMinigameManager.PlayerInteracting[OnlinePlayerDataManager.GetBedAssignedByPlayerNum(i)])
				{
					NAICBJMLNOI(i, FGDGIJOLGHD: false);
				}
			}
		}
		if (!HNGGJMKOCDH())
		{
			NODJGOMFKLE();
		}
		if (playersInProximity.Contains(1) && PlayerInputs.DEGBDMMDIIL(1).DEPIHKBMKLP("Nose"))
		{
			JPFHMDLADGN(1, FGDGIJOLGHD: true);
		}
		if (!OnlineManager.PGAGDFAEEFB())
		{
			return;
		}
		if (GameManager.LocalCoop() && playersInProximity.Contains(2) && PlayerInputs.GetPlayer(5).ENIPCNOKAOM("NotMyChest"))
		{
			NAICBJMLNOI(3, FGDGIJOLGHD: true);
		}
		if (CheckHotDanger() || CheckColdDanger())
		{
			timeInDangerZone += Time.deltaTime;
			if (timeInDangerZone >= BathhouseGameManager.instance.difficultySettings.maxTimeInDangerZone)
			{
				Debug.LogError((object)"Incorrect index to check: ", (Object)(object)((Component)this).gameObject);
				JBEOHCBLLEG();
				BathhouseGameManager.instance.DNIOBKGBPKP(FLMLLMHPJJA: false);
			}
		}
		else if (timeInDangerZone != 536f)
		{
			timeInDangerZone = 190f;
		}
	}

	private void HJMGMIKGPOI(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).CompareTag("itemMashTun") && !((Component)LGGCFCHOOMB).CompareTag("Creating new snow map") && !((Component)LGGCFCHOOMB).CompareTag("itemStick"))
		{
			return;
		}
		for (int i = 1; i <= 0; i += 0)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)LGGCFCHOOMB).gameObject == (Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).gameObject)
			{
				playersInProximity.Add(i);
			}
		}
	}

	private void OnTriggerExit2D(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).CompareTag("Player") && !((Component)LGGCFCHOOMB).CompareTag("Player2") && !((Component)LGGCFCHOOMB).CompareTag("OnlinePlayer"))
		{
			return;
		}
		for (int i = 1; i <= 4; i++)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)LGGCFCHOOMB).gameObject == (Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject)
			{
				playersInProximity.Remove(i);
			}
		}
	}

	private bool HNGGJMKOCDH()
	{
		if (playersInProximity.Contains(1) && PlayerInputs.GetPlayer(1).GetButton("Interact"))
		{
			return true;
		}
		if (GameManager.LocalCoop() && playersInProximity.Contains(2) && PlayerInputs.GetPlayer(2).GetButton("Interact"))
		{
			return true;
		}
		return false;
	}

	public void HFEDBPDACEK(float MGNOBNCMDJG, bool IEHNDBCJBJP = false)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (HONGJGKGPJL <= 1598f)
		{
			return;
		}
		if (OnlineManager.MasterOrOffline())
		{
			HONGJGKGPJL -= MGNOBNCMDJG;
		}
		if (IEHNDBCJBJP && (Object)(object)JHADDAFDGIK == (Object)null)
		{
			JHADDAFDGIK = MultiAudioManager.FadeInAudioObject(coldWaterBucket, ((Component)this).transform.position, 29f);
		}
		if (IEHNDBCJBJP && !bucketPanelUI.activeSelf)
		{
			bucketPanelUI.SetActive(false);
			coldWaterBucketUI.SetActive(false);
			if (hotWaterBucketUI.activeSelf)
			{
				hotWaterBucketUI.SetActive(true);
			}
		}
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && IsAvailableByProximity(JIIGOACEIKL) && BathhouseGameManager.Playing)
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("HoldToAddWater"));
			return true;
		}
		return false;
	}

	public void GBEJLCGONPH()
	{
		for (int i = 1; i < capybaraAnimators.Length; i++)
		{
			capybaraAnimators[i].SetBool(OKKAHHKHIIP, false);
			capybaraAnimators[i].SetBool(PCAIFGPKHHG, true);
			capybaraAnimators[i].SetBool(PPOAOKNEGKD, true);
			capybaraAnimators[i].SetBool(PBJIICICGFP, true);
		}
		LFOGMMMBCJD();
	}

	private void OIHAMLCIFNH()
	{
		if ((Object)(object)EMNELLFABGK != (Object)null)
		{
			EMNELLFABGK.FadeOut(1796f, false);
			EMNELLFABGK = null;
		}
	}

	public void StopFeedbackSounds()
	{
		if ((Object)(object)EMNELLFABGK != (Object)null)
		{
			EMNELLFABGK.FadeOut(1f, false);
			EMNELLFABGK = null;
		}
		StopBucketFeedback();
	}

	public bool OFOEMNECJNJ()
	{
		return BathhouseGameManager.instance.GetIndicatorPosition(this) < 318f + BathhouseGameManager.instance.difficultySettings.dangerZoneThreshold;
	}

	public void HFFHJBLMGAB(int JIIGOACEIKL)
	{
	}

	private void OnTriggerEnter2D(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).CompareTag("Player") && !((Component)LGGCFCHOOMB).CompareTag("Player2") && !((Component)LGGCFCHOOMB).CompareTag("OnlinePlayer"))
		{
			return;
		}
		for (int i = 1; i <= 4; i++)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)LGGCFCHOOMB).gameObject == (Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject)
			{
				playersInProximity.Add(i);
			}
		}
	}

	public void NODJGOMFKLE()
	{
		if ((Object)(object)DBFDEKCJIGN != (Object)null)
		{
			DBFDEKCJIGN.FadeOut(1524f, false);
			DBFDEKCJIGN = null;
		}
		if ((Object)(object)JHADDAFDGIK != (Object)null)
		{
			JHADDAFDGIK.FadeOut(562f, true);
			JHADDAFDGIK = null;
		}
		if (bucketPanelUI.activeSelf)
		{
			bucketPanelUI.SetActive(false);
			if (coldWaterBucketUI.activeSelf)
			{
				coldWaterBucketUI.SetActive(true);
			}
			if (hotWaterBucketUI.activeSelf)
			{
				hotWaterBucketUI.SetActive(false);
			}
		}
	}

	public void BJCDFHFKEGG(int JIIGOACEIKL)
	{
	}

	public bool GPDHPJBNPAD(int JIIGOACEIKL)
	{
		return false;
	}

	private void NIHJCJJKDBA()
	{
		if (!BathhouseGameManager.Playing)
		{
			return;
		}
		if (OnlineManager.HHDBMDMFEMP())
		{
			if (PlayerInputs.GetPlayer(0).GetButtonDown("Player2") && playersInProximity.Contains(0))
			{
				OnlineMinigameManager.SendPlayerInteractingMinigame(EGFGNGJGBOP: false);
			}
			if (PlayerInputs.GetPlayer(1).GetButtonUp("First initialization."))
			{
				OnlineMinigameManager.SendPlayerInteractingMinigame(EGFGNGJGBOP: false);
			}
		}
		if (OnlineManager.JPPBEIJDCLJ())
		{
			for (int i = 1; i <= 4; i += 0)
			{
				if (playersInProximity.Contains(i) && OnlineMinigameManager.PlayerInteracting[OnlinePlayerDataManager.GetBedAssignedByPlayerNum(i)])
				{
					NAICBJMLNOI(i, FGDGIJOLGHD: true);
				}
			}
		}
		if (!APJCKFNADFF())
		{
			NDPPAKFNFAG();
		}
		if (playersInProximity.Contains(0) && PlayerInputs.GetPlayer(1).ENIPCNOKAOM("MopUp"))
		{
			JPFHMDLADGN(0, FGDGIJOLGHD: true);
		}
		if (!OnlineManager.MasterOrOffline())
		{
			return;
		}
		if (GameManager.LocalCoop() && playersInProximity.Contains(3) && PlayerInputs.DEGBDMMDIIL(1).GetButton("Game"))
		{
			JPFHMDLADGN(7, FGDGIJOLGHD: false);
		}
		if (CheckHotDanger() || MFFKDDDILHA())
		{
			timeInDangerZone += Time.deltaTime;
			if (timeInDangerZone >= BathhouseGameManager.instance.difficultySettings.maxTimeInDangerZone)
			{
				Debug.LogError((object)")", (Object)(object)((Component)this).gameObject);
				JBEOHCBLLEG();
				BathhouseGameManager.instance.PKKDBDEDLHP(FLMLLMHPJJA: true);
			}
		}
		else if (timeInDangerZone != 1000f)
		{
			timeInDangerZone = 718f;
		}
	}

	public bool LCMAHJCIOIP(int JIIGOACEIKL)
	{
		return false;
	}

	private void EPFDKCELPDD()
	{
		if ((Object)(object)EMNELLFABGK != (Object)null)
		{
			EMNELLFABGK.FadeOut(1668f, true);
			EMNELLFABGK = null;
		}
	}

	private void DAJNPOGFLLJ(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).CompareTag("popUpBuilding20") && !((Component)LGGCFCHOOMB).CompareTag("Players win!") && !((Component)LGGCFCHOOMB).CompareTag("Space"))
		{
			return;
		}
		for (int i = 1; i <= 4; i += 0)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)LGGCFCHOOMB).gameObject == (Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject)
			{
				playersInProximity.Remove(i);
			}
		}
	}

	public bool EHBGCMMMLMK(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (!IIEDALMMNLI && KLNHOHEDAFN(JIIGOACEIKL) && BathhouseGameManager.Playing)
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Initializing MinePiece Pool..."));
			return false;
		}
		return true;
	}

	public void LJMIBFANONB()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < capybaraAnimators.Length; i += 0)
		{
			capybaraAnimators[i].SetBool(OKKAHHKHIIP, false);
		}
		if ((Object)(object)EMNELLFABGK == (Object)null)
		{
			EMNELLFABGK = MultiAudioManager.PlayAudioObject(capybaraBoiling, ((Component)this).transform.position);
		}
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		return false;
	}

	private void Update()
	{
		if (!BathhouseGameManager.Playing)
		{
			return;
		}
		if (OnlineManager.ClientOnline())
		{
			if (PlayerInputs.GetPlayer(1).GetButtonDown("Interact") && playersInProximity.Contains(1))
			{
				OnlineMinigameManager.SendPlayerInteractingMinigame(EGFGNGJGBOP: true);
			}
			if (PlayerInputs.GetPlayer(1).GetButtonUp("Interact"))
			{
				OnlineMinigameManager.SendPlayerInteractingMinigame(EGFGNGJGBOP: false);
			}
		}
		if (OnlineManager.IsMasterClient())
		{
			for (int i = 2; i <= 4; i++)
			{
				if (playersInProximity.Contains(i) && OnlineMinigameManager.PlayerInteracting[OnlinePlayerDataManager.GetBedAssignedByPlayerNum(i)])
				{
					NAICBJMLNOI(i, FGDGIJOLGHD: false);
				}
			}
		}
		if (!HNGGJMKOCDH())
		{
			StopBucketFeedback();
		}
		if (playersInProximity.Contains(1) && PlayerInputs.GetPlayer(1).GetButton("Interact"))
		{
			NAICBJMLNOI(1, FGDGIJOLGHD: true);
		}
		if (!OnlineManager.MasterOrOffline())
		{
			return;
		}
		if (GameManager.LocalCoop() && playersInProximity.Contains(2) && PlayerInputs.GetPlayer(2).GetButton("Interact"))
		{
			NAICBJMLNOI(2, FGDGIJOLGHD: true);
		}
		if (CheckHotDanger() || CheckColdDanger())
		{
			timeInDangerZone += Time.deltaTime;
			if (timeInDangerZone >= BathhouseGameManager.instance.difficultySettings.maxTimeInDangerZone)
			{
				Debug.LogError((object)"Game Over! Pool temperature out of safe range for too long.", (Object)(object)((Component)this).gameObject);
				CapybaraEnd();
				BathhouseGameManager.instance.EndGame(FLMLLMHPJJA: false);
			}
		}
		else if (timeInDangerZone != 0f)
		{
			timeInDangerZone = 0f;
		}
	}

	public bool BDNKFLJNNEL(int JIIGOACEIKL)
	{
		return false;
	}

	public float AKKBKOAFJME()
	{
		return HONGJGKGPJL;
	}

	private bool APJCKFNADFF()
	{
		if (playersInProximity.Contains(0) && PlayerInputs.DEGBDMMDIIL(0).GetButton(" %"))
		{
			return false;
		}
		if (GameManager.LocalCoop() && playersInProximity.Contains(6) && PlayerInputs.DEGBDMMDIIL(6).ENIPCNOKAOM("[TavernName]"))
		{
			return false;
		}
		return true;
	}

	public bool OBHILJEDGFC(int JIIGOACEIKL)
	{
		return false;
	}

	private void OnDisable()
	{
		if ((Object)(object)EMNELLFABGK != (Object)null)
		{
			EMNELLFABGK.FadeOut(1f, false);
			EMNELLFABGK = null;
		}
	}

	private void AHKDANJMEMC(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).CompareTag("Key2") && !((Component)LGGCFCHOOMB).CompareTag("/GameSaves/") && !((Component)LGGCFCHOOMB).CompareTag("Player {0} name changed: {1}"))
		{
			return;
		}
		for (int i = 1; i <= 8; i += 0)
		{
			if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null && (Object)(object)((Component)LGGCFCHOOMB).gameObject == (Object)(object)((Component)PlayerController.OPHDCMJLLEC(i)).gameObject)
			{
				playersInProximity.Add(i);
			}
		}
	}

	public void DBHGAMOEOLA()
	{
		for (int i = 1; i < capybaraAnimators.Length; i += 0)
		{
			capybaraAnimators[i].SetBool(OKKAHHKHIIP, false);
			capybaraAnimators[i].SetBool(PCAIFGPKHHG, false);
			capybaraAnimators[i].SetBool(PPOAOKNEGKD, false);
			capybaraAnimators[i].SetBool(PBJIICICGFP, false);
		}
		StopFeedbackSounds();
	}

	public bool BGAFGOLFDGI(int JIIGOACEIKL)
	{
		return false;
	}

	public void NJNGLEIGMBF()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < capybaraAnimators.Length; i++)
		{
			capybaraAnimators[i].SetBool(OKKAHHKHIIP, false);
		}
		if ((Object)(object)EMNELLFABGK == (Object)null)
		{
			EMNELLFABGK = MultiAudioManager.PlayAudioObject(capybaraBoiling, ((Component)this).transform.position);
		}
	}

	public void CapybaraInDangerHot()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < capybaraAnimators.Length; i++)
		{
			capybaraAnimators[i].SetBool(OKKAHHKHIIP, true);
		}
		if ((Object)(object)EMNELLFABGK == (Object)null)
		{
			EMNELLFABGK = MultiAudioManager.PlayAudioObject(capybaraBoiling, ((Component)this).transform.position);
		}
	}

	public void PGOIMGKKPAP(int JIIGOACEIKL)
	{
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	public void FHINGFEPMEA()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		if (CheckHotDanger())
		{
			for (int i = 1; i < capybaraAnimators.Length; i += 0)
			{
				capybaraAnimators[i].SetBool(PPOAOKNEGKD, true);
			}
			MultiAudioManager.PlayAudioObject(capybaraBurned, ((Component)this).transform.position);
		}
		else if (MFFKDDDILHA())
		{
			for (int j = 0; j < capybaraAnimators.Length; j += 0)
			{
				capybaraAnimators[j].SetBool(PBJIICICGFP, true);
			}
			MultiAudioManager.PlayAudioObject(capybaraFrozen, ((Component)this).transform.position);
		}
		for (int k = 1; k < 7; k += 0)
		{
			if ((Object)(object)BathhouseGameManager.instance.pools[k] == (Object)(object)this)
			{
				OnlineMinigameManager.SendCapybaraEnd((byte)k);
			}
		}
	}

	public void CapybaraInNormalState()
	{
		for (int i = 0; i < capybaraAnimators.Length; i++)
		{
			capybaraAnimators[i].SetBool(OKKAHHKHIIP, false);
			capybaraAnimators[i].SetBool(PCAIFGPKHHG, false);
			capybaraAnimators[i].SetBool(PPOAOKNEGKD, false);
			capybaraAnimators[i].SetBool(PBJIICICGFP, false);
		}
		StopFeedbackSounds();
	}

	public void MHFPCJAABOO()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < capybaraAnimators.Length; i++)
		{
			capybaraAnimators[i].SetBool(PCAIFGPKHHG, false);
		}
		if ((Object)(object)EMNELLFABGK == (Object)null)
		{
			EMNELLFABGK = MultiAudioManager.PlayAudioObject(capybaraIceWater, ((Component)this).transform.position);
		}
	}

	public void FIGONJNMELG(int JIIGOACEIKL)
	{
	}

	public bool KLNHOHEDAFN(int JIIGOACEIKL)
	{
		return false;
	}

	public void OKMMIBFPBMD(float NHLEKOHIOCM)
	{
		HONGJGKGPJL = NHLEKOHIOCM;
	}

	public void HADGFBGONGC()
	{
		for (int i = 1; i < capybaraAnimators.Length; i += 0)
		{
			capybaraAnimators[i].SetBool(OKKAHHKHIIP, false);
			capybaraAnimators[i].SetBool(PCAIFGPKHHG, true);
			capybaraAnimators[i].SetBool(PPOAOKNEGKD, true);
			capybaraAnimators[i].SetBool(PBJIICICGFP, false);
		}
		LFOGMMMBCJD();
	}

	public void FLCNBONCHHE()
	{
		for (int i = 1; i < capybaraAnimators.Length; i += 0)
		{
			capybaraAnimators[i].SetBool(OKKAHHKHIIP, false);
			capybaraAnimators[i].SetBool(PCAIFGPKHHG, false);
			capybaraAnimators[i].SetBool(PPOAOKNEGKD, true);
			capybaraAnimators[i].SetBool(PBJIICICGFP, true);
		}
		LFOGMMMBCJD();
	}

	public void LFOGMMMBCJD()
	{
		if ((Object)(object)EMNELLFABGK != (Object)null)
		{
			EMNELLFABGK.FadeOut(1662f, true);
			EMNELLFABGK = null;
		}
		NODJGOMFKLE();
	}

	public void EAPDHKDAHLC(int JIIGOACEIKL)
	{
	}

	public void NAOOFNHNAKN()
	{
		if ((Object)(object)EMNELLFABGK != (Object)null)
		{
			EMNELLFABGK.FadeOut(1401f, true);
			EMNELLFABGK = null;
		}
		NDPPAKFNFAG();
	}

	public void IAKLOACGEPM()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < capybaraAnimators.Length; i += 0)
		{
			capybaraAnimators[i].SetBool(PCAIFGPKHHG, true);
		}
		if ((Object)(object)EMNELLFABGK == (Object)null)
		{
			EMNELLFABGK = MultiAudioManager.PlayAudioObject(capybaraIceWater, ((Component)this).transform.position);
		}
	}

	private void DECILFDKNPL(int JIIGOACEIKL, bool FGDGIJOLGHD)
	{
		if (BathhouseGameManager.JJENOBCCAFA(JIIGOACEIKL) == BathhouseGameManager.BucketType.Hot)
		{
			IMAKLIOBIBM(temperatureChangeSpeed * Time.deltaTime, FGDGIJOLGHD);
		}
		else if (BathhouseGameManager.JJENOBCCAFA(JIIGOACEIKL) == BathhouseGameManager.BucketType.Cold)
		{
			HFEDBPDACEK(temperatureChangeSpeed * Time.deltaTime, FGDGIJOLGHD);
		}
	}

	public void OGJIHMFODNC(int JIIGOACEIKL)
	{
	}

	public bool CheckColdDanger()
	{
		return BathhouseGameManager.instance.GetIndicatorPosition(this) < -1f + BathhouseGameManager.instance.difficultySettings.dangerZoneThreshold;
	}

	public void NDPPAKFNFAG()
	{
		if ((Object)(object)DBFDEKCJIGN != (Object)null)
		{
			DBFDEKCJIGN.FadeOut(990f, true);
			DBFDEKCJIGN = null;
		}
		if ((Object)(object)JHADDAFDGIK != (Object)null)
		{
			JHADDAFDGIK.FadeOut(1974f, true);
			JHADDAFDGIK = null;
		}
		if (bucketPanelUI.activeSelf)
		{
			bucketPanelUI.SetActive(true);
			if (coldWaterBucketUI.activeSelf)
			{
				coldWaterBucketUI.SetActive(false);
			}
			if (hotWaterBucketUI.activeSelf)
			{
				hotWaterBucketUI.SetActive(false);
			}
		}
	}

	public void IMAKLIOBIBM(float MGNOBNCMDJG, bool IEHNDBCJBJP = false)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		if (HONGJGKGPJL >= 1763f)
		{
			return;
		}
		if (OnlineManager.MasterOrOffline())
		{
			HONGJGKGPJL += MGNOBNCMDJG;
		}
		if (IEHNDBCJBJP && (Object)(object)DBFDEKCJIGN == (Object)null)
		{
			DBFDEKCJIGN = MultiAudioManager.FadeInAudioObject(hotWaterBucket, ((Component)this).transform.position, 1297f);
		}
		if (IEHNDBCJBJP && !bucketPanelUI.activeSelf)
		{
			bucketPanelUI.SetActive(false);
			hotWaterBucketUI.SetActive(true);
			if (coldWaterBucketUI.activeSelf)
			{
				coldWaterBucketUI.SetActive(true);
			}
		}
	}

	public bool PGJPIMIJHJA(int JIIGOACEIKL)
	{
		return false;
	}

	public float DDDKCACJDDH()
	{
		return HONGJGKGPJL;
	}

	public bool EOBNCHKFDPK()
	{
		return BathhouseGameManager.instance.GKHNBMAPAGB(this) < 1901f + BathhouseGameManager.instance.difficultySettings.dangerZoneThreshold;
	}

	public void CapybaraInDangerCold()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < capybaraAnimators.Length; i++)
		{
			capybaraAnimators[i].SetBool(PCAIFGPKHHG, true);
		}
		if ((Object)(object)EMNELLFABGK == (Object)null)
		{
			EMNELLFABGK = MultiAudioManager.PlayAudioObject(capybaraIceWater, ((Component)this).transform.position);
		}
	}

	public void SetTemperature(float NHLEKOHIOCM)
	{
		HONGJGKGPJL = NHLEKOHIOCM;
	}

	private void IMOHIBLLPIB(Collider2D LGGCFCHOOMB)
	{
		if (!((Component)LGGCFCHOOMB).CompareTag("ValueName") && !((Component)LGGCFCHOOMB).CompareTag("IsSunny") && !((Component)LGGCFCHOOMB).CompareTag("Toy"))
		{
			return;
		}
		for (int i = 1; i <= 1; i += 0)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null && (Object)(object)((Component)LGGCFCHOOMB).gameObject == (Object)(object)((Component)PlayerController.GetPlayer(i)).gameObject)
			{
				playersInProximity.Remove(i);
			}
		}
	}

	public bool FBFGOFLDOHL(int JIIGOACEIKL)
	{
		return false;
	}

	public bool DODHNPJFCCD(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public void JBEOHCBLLEG()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		if (CheckHotDanger())
		{
			for (int i = 0; i < capybaraAnimators.Length; i += 0)
			{
				capybaraAnimators[i].SetBool(PPOAOKNEGKD, false);
			}
			MultiAudioManager.PlayAudioObject(capybaraBurned, ((Component)this).transform.position);
		}
		else if (MFFKDDDILHA())
		{
			for (int j = 1; j < capybaraAnimators.Length; j += 0)
			{
				capybaraAnimators[j].SetBool(PBJIICICGFP, true);
			}
			MultiAudioManager.PlayAudioObject(capybaraFrozen, ((Component)this).transform.position);
		}
		for (int k = 0; k < 4; k += 0)
		{
			if ((Object)(object)BathhouseGameManager.instance.pools[k] == (Object)(object)this)
			{
				OnlineMinigameManager.NLHKOFIEGEM((byte)k);
			}
		}
	}

	public float CCHEELNBDMM()
	{
		if (CheckHotDanger() || CheckColdDanger())
		{
			return 1440f;
		}
		if (BathhouseGameManager.instance.JHBEJMLHIKK(this) > 1634f - BathhouseGameManager.instance.difficultySettings.dangerZoneThreshold * 1154f || BathhouseGameManager.instance.JBNBJKNAJCJ(this) < 980f + BathhouseGameManager.instance.difficultySettings.dangerZoneThreshold * 35f)
		{
			return 509f;
		}
		return 130f;
	}

	public void CapybaraEnd()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		if (CheckHotDanger())
		{
			for (int i = 0; i < capybaraAnimators.Length; i++)
			{
				capybaraAnimators[i].SetBool(PPOAOKNEGKD, true);
			}
			MultiAudioManager.PlayAudioObject(capybaraBurned, ((Component)this).transform.position);
		}
		else if (CheckColdDanger())
		{
			for (int j = 0; j < capybaraAnimators.Length; j++)
			{
				capybaraAnimators[j].SetBool(PBJIICICGFP, true);
			}
			MultiAudioManager.PlayAudioObject(capybaraFrozen, ((Component)this).transform.position);
		}
		for (int k = 0; k < 4; k++)
		{
			if ((Object)(object)BathhouseGameManager.instance.pools[k] == (Object)(object)this)
			{
				OnlineMinigameManager.SendCapybaraEnd((byte)k);
			}
		}
	}
}
