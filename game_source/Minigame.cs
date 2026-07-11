using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class Minigame : MonoBehaviour
{
	public static readonly Vector3 REPLAY_CASTLE_POSITION = new Vector3(-929f, 265f, 0f);

	private Coroutine IKKHMDGLHGB;

	protected void GGAGEOJBGEN(Location BAIMHDBJPDK)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		if (GameManager.SinglePlayer() || (PlayerController.GetPlayer(1).LEOIMFNKFGA != BAIMHDBJPDK && PlayerController.GetPlayer(2).LEOIMFNKFGA != BAIMHDBJPDK))
		{
			Scene sceneByName = SceneManager.GetSceneByName(BAIMHDBJPDK.ToString());
			if (((Scene)(ref sceneByName)).isLoaded)
			{
				SceneManager.UnloadSceneAsync(BAIMHDBJPDK.ToString());
			}
		}
	}

	private void OHFPGKMNBHG(int CIFJJBHINEF)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(OHFPGKMNBHG));
		KCOCGPLPKME();
		PlayerController.TeleportPlayer(1, REPLAY_CASTLE_POSITION, Location.Castle);
		PlayerController.TeleportPlayer(2, REPLAY_CASTLE_POSITION, Location.Castle);
		LBMDAGNAFFA();
		ChallengesUI.AnyMinigameInProgress = false;
	}

	protected void BNKBGGJKLHP(bool IAPOBPCFAGN, SO_Challenges.ChallengeType NJDLOMPBEMB, float BODLJHFNFFK)
	{
		if (IKKHMDGLHGB != null)
		{
			Debug.LogError((object)"Return to castle corroutine is null");
		}
		else
		{
			IKKHMDGLHGB = ((MonoBehaviour)this).StartCoroutine(LLDHMMIKOAB(IAPOBPCFAGN, NJDLOMPBEMB, BODLJHFNFFK));
		}
	}

	protected void FJNCAMHMMAB(int GELMAIBEHDO)
	{
		PlayerInputs.EnableKeyboardInputsAndMovement(GELMAIBEHDO, (MonoBehaviour)(object)this);
	}

	public void HideUI()
	{
		HHIANNBIHJM();
		GameActionBarUI.Get(1).CloseUI();
		if (GameManager.LocalCoop())
		{
			GameActionBarUI.Get(2).CloseUI();
		}
		TavernManagerUI.HideClockAndTavernInfo();
		MissionsManager.HideObjectivesPanel();
	}

	public void OnCloseChallengeEndDialogue(bool BINEPAAJCFD, SO_Challenges.ChallengeType NJDLOMPBEMB)
	{
		if (BINEPAAJCFD)
		{
			switch (NJDLOMPBEMB)
			{
			case SO_Challenges.ChallengeType.pirates:
				PiratesGameManager.Restart();
				break;
			case SO_Challenges.ChallengeType.fishCutting:
				FishCuttingGameManager.Restart();
				break;
			case SO_Challenges.ChallengeType.bathhouse:
				BathhouseGameManager.Restart();
				break;
			}
		}
		else
		{
			CLGNJHNEJDI();
		}
	}

	protected void CKBIMIBHPGB()
	{
		if (GameManager.LocalCoop())
		{
			LocalCooperativeManager.RestoreCameraInLocalCoop();
		}
	}

	protected void PBMJLFIJNAF()
	{
		LPIDCJBFIPA();
		GameActionBarUI.Get(1).OpenUI();
		if (GameManager.LocalCoop())
		{
			GameActionBarUI.Get(2).OpenUI();
		}
		TavernManagerUI.ShowClockAndTavernInfo();
		MissionsManager.ShowObjectivesPanel();
	}

	public void SetWeather(bool DIONNMLCIIC = true)
	{
		(Weather.instance.weatherParticles[1].playerOneParticles as RainParticlesManager).MaskRain(DIONNMLCIIC);
		(Weather.instance.weatherParticles[1].playerTwoParticles as RainParticlesManager).MaskRain(DIONNMLCIIC);
	}

	protected void HHIANNBIHJM()
	{
		PlayerInputs.DisableKeyboardInputs(1, (MonoBehaviour)(object)this);
		if ((Object)(object)PlayerController.GetPlayer(2) != (Object)null)
		{
			PlayerInputs.DisableKeyboardInputs(2, (MonoBehaviour)(object)this);
		}
	}

	protected void IEFABCDIJOI(int GELMAIBEHDO)
	{
		PlayerInputs.DisableKeyboardInputsAndMovement(GELMAIBEHDO, (MonoBehaviour)(object)this);
	}

	protected void LPIDCJBFIPA()
	{
		PlayerInputs.EnableKeyboardInputs(1, (MonoBehaviour)(object)this);
		if ((Object)(object)PlayerController.GetPlayer(2) != (Object)null)
		{
			PlayerInputs.EnableKeyboardInputs(2, (MonoBehaviour)(object)this);
		}
	}

	protected void EOMPKDPCIIB()
	{
		if (GameManager.LocalCoop())
		{
			LocalCooperativeManager.FocusCameraToPlayerInLocalCoop(1);
		}
	}

	private void CLGNJHNEJDI()
	{
		TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.CastleGarden, Location.Castle).StartTravelZone(1);
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(OHFPGKMNBHG));
		if (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(2) != (Object)null)
		{
			TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.CastleGarden, Location.Castle).StartTravelZone(2);
		}
		OnlineMinigameManager.SetMinigameState(OnlineMinigameManager.PlayerState.Default);
	}

	protected abstract void KCOCGPLPKME();

	protected virtual void CLJIHBGPJKL()
	{
		PlayerInputs.DisableKeyboardInputsAndMovement(1, (MonoBehaviour)(object)this);
		if (GameManager.LocalCoop())
		{
			PlayerInputs.DisableKeyboardInputsAndMovement(2, (MonoBehaviour)(object)this);
		}
	}

	private IEnumerator LLDHMMIKOAB(bool IAPOBPCFAGN, SO_Challenges.ChallengeType NJDLOMPBEMB, float BODLJHFNFFK)
	{
		CLJIHBGPJKL();
		EventCountdownUI.ChangeText(IAPOBPCFAGN ? "Victory" : "Defeat");
		yield return CommonReferences.wait3;
		EventCountdownUI.CloseCountdown();
		yield return CommonReferences.wait025;
		ChallengeEndDialogueUI.instance.Initialize(NJDLOMPBEMB, IAPOBPCFAGN, BODLJHFNFFK);
		ChallengeEndDialogueUI.instance.OpenUI();
		IKKHMDGLHGB = null;
	}

	protected void LBMDAGNAFFA()
	{
		PlayerInputs.EnableKeyboardInputsAndMovement(1, (MonoBehaviour)(object)this);
		if (GameManager.LocalCoop())
		{
			PlayerInputs.EnableKeyboardInputsAndMovement(2, (MonoBehaviour)(object)this);
		}
	}
}
