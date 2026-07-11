using System;
using System.Collections;
using UnityEngine;

public abstract class EventRoundsManager : MonoBehaviour
{
	public static bool forceNextRound;

	public static bool forceSkipChallenge;

	[SerializeField]
	protected float roundTime = 120f;

	[SerializeField]
	protected float roundEndTime;

	[SerializeField]
	protected int currentRound;

	public Transform[] startPositionPlayers;

	private Coroutine IMAKIAFKFMD;

	private bool EBHEPFILNBG;

	public void RestartAllCharactersPositionsWaitingPlayers()
	{
		((MonoBehaviour)this).StartCoroutine(IHGEPGIIAEA());
	}

	protected IEnumerator KMMJNLFOGGK()
	{
		forceSkipChallenge = false;
		yield return OBBOHOIJJAI(0, FJEIAKMNOLG: false);
		if (!forceSkipChallenge)
		{
			yield return OBBOHOIJJAI(1);
		}
		if (!forceSkipChallenge)
		{
			yield return OBBOHOIJJAI(2, FJEIAKMNOLG: true, HPNPAKJCDAB: false);
		}
		HLCNHMOFNIE();
	}

	private IEnumerator OBBOHOIJJAI(int KFHIFOABOFP, bool FJEIAKMNOLG = true, bool HPNPAKJCDAB = true)
	{
		BanquetOrdersManager.instance.pauseOrders = true;
		BIKCLHEPPNB(KFHIFOABOFP, FJEIAKMNOLG);
		yield return NBCIALFNLAA(KFHIFOABOFP);
		yield return BIIIHNOONMM();
		yield return LOCDIHNIMFI(HPNPAKJCDAB);
	}

	public virtual void RestartAllCharactersPositions()
	{
		EBHEPFILNBG = true;
	}

	public virtual void BlockPlayers()
	{
		PlayerInputs.DisableKeyboardInputsAndMovement(1, (MonoBehaviour)(object)this);
		GameActionBarUI.Get(1).CloseUI();
		if (GameManager.LocalCoop())
		{
			PlayerInputs.DisableKeyboardInputsAndMovement(2, (MonoBehaviour)(object)this);
			GameActionBarUI.Get(2).CloseUI();
		}
	}

	public void StopRounds()
	{
		if (IMAKIAFKFMD != null)
		{
			((MonoBehaviour)this).StopCoroutine(IMAKIAFKFMD);
		}
	}

	private IEnumerator IHGEPGIIAEA()
	{
		yield return OnlineManager.WaitForAllPlayers();
		RestartAllCharactersPositions();
	}

	public virtual void UnblockPlayers()
	{
		PlayerInputs.EnableKeyboardInputsAndMovement(1, (MonoBehaviour)(object)this);
		GameActionBarUI.Get(1).OpenUI();
		if (GameManager.LocalCoop())
		{
			PlayerInputs.EnableKeyboardInputsAndMovement(2, (MonoBehaviour)(object)this);
			GameActionBarUI.Get(2).OpenUI();
		}
	}

	public void StartRounds()
	{
		StopRounds();
		IMAKIAFKFMD = ((MonoBehaviour)this).StartCoroutine(KMMJNLFOGGK());
	}

	protected virtual void BIKCLHEPPNB(int BEFKNAPMAAG, bool FJEIAKMNOLG = true)
	{
		if (FJEIAKMNOLG)
		{
			FadeCamera.FadeInAllPlayers();
		}
		if (Application.isEditor)
		{
			Debug.Log((object)("Preparing Round " + BEFKNAPMAAG));
		}
		currentRound = BEFKNAPMAAG;
		forceNextRound = false;
		roundEndTime = Time.time + roundTime;
		PlayerController.GetPlayer(1).trayHandler.RemoveAllDrinks();
		if (GameManager.LocalCoop())
		{
			PlayerController.GetPlayer(2).trayHandler.RemoveAllDrinks();
		}
		BlockPlayers();
	}

	protected virtual IEnumerator NBCIALFNLAA(int KFHIFOABOFP)
	{
		yield return CommonReferences.wait2;
		yield return OnlineManager.WaitForAllPlayers();
		EventCountdownUI.ChangeText("Round " + (KFHIFOABOFP + 1));
		CountdownUI.SetCountdown(roundTime);
		yield return CommonReferences.wait2;
		EventCountdownUI.CloseCountdown();
		yield return null;
		EventCountdownUI.ChangeText("GO");
		yield return CommonReferences.wait1;
		EventCountdownUI.CloseCountdown();
		UnblockPlayers();
	}

	protected virtual IEnumerator LOCDIHNIMFI(bool HPNPAKJCDAB = true)
	{
		CountdownUI.SetCountdownText(0f);
		CountdownUI.HideCountdown();
		EBHEPFILNBG = false;
		BlockPlayers();
		EventCountdownUI.ChangeText("Time's up!");
		yield return CommonReferences.wait2;
		EventCountdownUI.CloseCountdown();
		if (HPNPAKJCDAB)
		{
			FadeCamera player = FadeCamera.GetPlayer(1);
			player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(OKPIONFMGEI));
			FadeCamera.FadeOutAllPlayers();
			while (!EBHEPFILNBG)
			{
				yield return CommonReferences.wait02;
			}
			yield return CommonReferences.wait05;
		}
		UnblockPlayers();
	}

	public static void NextRound(bool CDPAMNIPPEC = true)
	{
		forceNextRound = true;
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineBanquetEventManager.instance.SendNextRound();
		}
	}

	protected abstract void HLCNHMOFNIE();

	protected virtual IEnumerator BIIIHNOONMM()
	{
		float remainingTime = roundTime;
		while (remainingTime > 0f && !forceNextRound && !forceSkipChallenge)
		{
			CountdownUI.SetCountdownText(remainingTime);
			yield return CommonReferences.wait1;
			remainingTime -= 1f;
		}
	}

	private void OKPIONFMGEI(int JIIGOACEIKL)
	{
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(OKPIONFMGEI));
		RestartAllCharactersPositions();
	}

	public static void SkipChallenge(bool CDPAMNIPPEC = true)
	{
		forceSkipChallenge = true;
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineBanquetEventManager.instance.SendSkipKlaynChallenge();
		}
	}
}
