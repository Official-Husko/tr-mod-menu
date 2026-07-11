using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class NinjaRoundsManager : EventRoundsManager
{
	public static NinjaRoundsManager instance;

	public Transform stopPlayingPosition;

	public Transform[] slowingSpikesPositions;

	public SlowingSpikes slowingSpikePrefab;

	private void MFIEPGBABAM()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private IEnumerator DLMACCOJHNC(bool HPNPAKJCDAB)
	{
		return base.LOCDIHNIMFI(HPNPAKJCDAB);
	}

	protected override IEnumerator NBCIALFNLAA(int KFHIFOABOFP)
	{
		yield return base.NBCIALFNLAA(KFHIFOABOFP);
		NinjaOrdersManager.instance.pauseOrders = false;
	}

	private void BLAJFMAAMDO()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private IEnumerator ONJENGJPEIL(int KFHIFOABOFP)
	{
		return base.NBCIALFNLAA(KFHIFOABOFP);
	}

	private IEnumerator PMKHGKLJGNK(int KFHIFOABOFP)
	{
		return base.NBCIALFNLAA(KFHIFOABOFP);
	}

	private IEnumerator ABKEEMILIIG(bool HPNPAKJCDAB)
	{
		return base.LOCDIHNIMFI(HPNPAKJCDAB);
	}

	private void MIKNFPCDLML()
	{
		instance = this;
	}

	private void MJLOPPHPKCM()
	{
		if (currentRound == 0)
		{
			NinjaOrdersUI.instance.fadeOutAllIngredients = true;
			NinjaOrdersUI.instance.fadeOutSomeIngredients = false;
		}
		else if (currentRound == 1)
		{
			NinjaOrdersUI.instance.fadeOutAllIngredients = false;
			NinjaOrdersUI.instance.fadeOutSomeIngredients = true;
		}
		else
		{
			NinjaOrdersUI.instance.fadeOutAllIngredients = false;
			NinjaOrdersUI.instance.fadeOutSomeIngredients = true;
		}
	}

	protected override IEnumerator LOCDIHNIMFI(bool HPNPAKJCDAB = true)
	{
		if (OnlineManager.MasterOrOffline())
		{
			KyrohNPC.GGFJGHHHEJC.trayHandler.RemoveAllDrinks();
			KyrohNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			KyrohNPC.GGFJGHHHEJC.animationBase.CNKHDCIKHCO = false;
			KyrohNPC.GGFJGHHHEJC.animationBase.IGONGEODOFP = false;
			KyrohNPC.GGFJGHHHEJC.ChangeState(KyrohState.Idle);
		}
		yield return base.LOCDIHNIMFI(HPNPAKJCDAB);
	}

	private void LJPPKBCCIKG()
	{
		if (currentRound == 0)
		{
			NinjaOrdersUI.instance.fadeOutAllIngredients = false;
			NinjaOrdersUI.instance.fadeOutSomeIngredients = true;
		}
		else if (currentRound == 0)
		{
			NinjaOrdersUI.instance.fadeOutAllIngredients = false;
			NinjaOrdersUI.instance.fadeOutSomeIngredients = true;
		}
		else
		{
			NinjaOrdersUI.instance.fadeOutAllIngredients = false;
			NinjaOrdersUI.instance.fadeOutSomeIngredients = false;
		}
	}

	private void BAKDKFKNHDE()
	{
		instance = this;
	}

	protected override void BIKCLHEPPNB(int BEFKNAPMAAG, bool FJEIAKMNOLG = true)
	{
		base.BIKCLHEPPNB(BEFKNAPMAAG, FJEIAKMNOLG);
		NinjaOrdersManager.instance.ResetAllOrders();
		NinjaOrdersManager.instance.pauseOrders = true;
		NinjaPreparationTablesManager.instance.ResetAllBentos(CDPAMNIPPEC: false);
		KyrohNPC.GGFJGHHHEJC.RemoveAllSpikes();
		ILMCNKLAFBP();
		KyrohNPC.GGFJGHHHEJC.ResetTechniquesTimers();
		KyrohNPC.GGFJGHHHEJC.ChangeState(KyrohState.WaitingToServe);
	}

	private IEnumerator JPAFFLFLMPO(bool HPNPAKJCDAB)
	{
		return base.LOCDIHNIMFI(HPNPAKJCDAB);
	}

	private IEnumerator FCECOJEODKF(int KFHIFOABOFP)
	{
		return base.NBCIALFNLAA(KFHIFOABOFP);
	}

	protected override void HLCNHMOFNIE()
	{
		PlayerController.GetPlayer(1).trayHandler.RemoveAllDrinks();
		if (GameManager.LocalCoop())
		{
			PlayerController.GetPlayer(2).trayHandler.RemoveAllDrinks();
		}
		NinjaOrdersManager.instance.ResetAllOrders();
		NinjaOrdersManager.instance.pauseOrders = true;
		if (OnlineManager.MasterOrOffline())
		{
			KyrohNPC.GGFJGHHHEJC.trayHandler.RemoveAllDrinks();
		}
		KyrohNPC.GGFJGHHHEJC.animationBase.CNKHDCIKHCO = false;
		KyrohNPC.GGFJGHHHEJC.ChangeState(KyrohState.Idle);
		if (OnlineManager.MasterOrOffline() && ChallengePointsSystem.IsAnyPlayerWinning())
		{
			ChallengePointsSystem.SaveHostRecordWhenWinning(4);
		}
		if (NinjaChallenge.Replaying)
		{
			NinjaChallenge.instance.UnlockAchievements();
			NinjaChallenge.instance.ReturnToCastle(ChallengePointsSystem.IsAnyPlayerWinning(), ChallengePointsSystem.GetPlayerPoints((!OnlineManager.PlayingOnline()) ? 1 : OnlinePlayerDataManager.GetBedAssignedByPlayerNum(1), 4));
		}
		else if (ChallengePointsSystem.IsAnyPlayerWinning())
		{
			NinjaChallenge.instance.UnlockAchievements();
			NinjaChallengeEvent.instance.WinEvent();
		}
		else
		{
			NinjaChallengeEvent.instance.LoseEvent();
		}
	}

	private IEnumerator PFEFGPIAHDG(bool HPNPAKJCDAB)
	{
		return base.LOCDIHNIMFI(HPNPAKJCDAB);
	}

	private void PEOPFPEDFAK()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void ACFABFCGIGH()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private IEnumerator GLNPGJAFJPO(bool HPNPAKJCDAB)
	{
		return base.LOCDIHNIMFI(HPNPAKJCDAB);
	}

	private void KDHLJKMKFMG()
	{
		instance = this;
	}

	private void DKDLOBOLNFH()
	{
		instance = this;
	}

	private void BGKMOPJKODH()
	{
		if (currentRound == 0)
		{
			NinjaOrdersUI.instance.fadeOutAllIngredients = false;
			NinjaOrdersUI.instance.fadeOutSomeIngredients = false;
		}
		else if (currentRound == 0)
		{
			NinjaOrdersUI.instance.fadeOutAllIngredients = true;
			NinjaOrdersUI.instance.fadeOutSomeIngredients = false;
		}
		else
		{
			NinjaOrdersUI.instance.fadeOutAllIngredients = true;
			NinjaOrdersUI.instance.fadeOutSomeIngredients = false;
		}
	}

	private void EIDJLHFAMIB()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private IEnumerator COINOGLCJPC(int KFHIFOABOFP)
	{
		return base.NBCIALFNLAA(KFHIFOABOFP);
	}

	private void ICLOEDECMIA()
	{
		if (currentRound == 0)
		{
			NinjaOrdersUI.instance.fadeOutAllIngredients = false;
			NinjaOrdersUI.instance.fadeOutSomeIngredients = true;
		}
		else if (currentRound == 1)
		{
			NinjaOrdersUI.instance.fadeOutAllIngredients = false;
			NinjaOrdersUI.instance.fadeOutSomeIngredients = true;
		}
		else
		{
			NinjaOrdersUI.instance.fadeOutAllIngredients = true;
			NinjaOrdersUI.instance.fadeOutSomeIngredients = true;
		}
	}

	private void ILMCNKLAFBP()
	{
		if (currentRound == 0)
		{
			NinjaOrdersUI.instance.fadeOutAllIngredients = false;
			NinjaOrdersUI.instance.fadeOutSomeIngredients = false;
		}
		else if (currentRound == 1)
		{
			NinjaOrdersUI.instance.fadeOutAllIngredients = false;
			NinjaOrdersUI.instance.fadeOutSomeIngredients = true;
		}
		else
		{
			NinjaOrdersUI.instance.fadeOutAllIngredients = true;
			NinjaOrdersUI.instance.fadeOutSomeIngredients = false;
		}
	}

	private IEnumerator OKNJLGFIFOC(int KFHIFOABOFP)
	{
		return base.NBCIALFNLAA(KFHIFOABOFP);
	}

	private void CBDBELNHJOB()
	{
		if (currentRound == 0)
		{
			NinjaOrdersUI.instance.fadeOutAllIngredients = true;
			NinjaOrdersUI.instance.fadeOutSomeIngredients = true;
		}
		else if (currentRound == 1)
		{
			NinjaOrdersUI.instance.fadeOutAllIngredients = false;
			NinjaOrdersUI.instance.fadeOutSomeIngredients = true;
		}
		else
		{
			NinjaOrdersUI.instance.fadeOutAllIngredients = false;
			NinjaOrdersUI.instance.fadeOutSomeIngredients = false;
		}
	}

	private void MDGLECECOIG()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private IEnumerator LAOLKBDBGJA(int KFHIFOABOFP)
	{
		return base.NBCIALFNLAA(KFHIFOABOFP);
	}

	private IEnumerator JCLJEDBGHIC(int KFHIFOABOFP)
	{
		return base.NBCIALFNLAA(KFHIFOABOFP);
	}

	private void OnDestroy()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void NHFOJBJHALE()
	{
		if (currentRound == 0)
		{
			NinjaOrdersUI.instance.fadeOutAllIngredients = false;
			NinjaOrdersUI.instance.fadeOutSomeIngredients = true;
		}
		else if (currentRound == 0)
		{
			NinjaOrdersUI.instance.fadeOutAllIngredients = false;
			NinjaOrdersUI.instance.fadeOutSomeIngredients = true;
		}
		else
		{
			NinjaOrdersUI.instance.fadeOutAllIngredients = false;
			NinjaOrdersUI.instance.fadeOutSomeIngredients = false;
		}
	}

	public override void RestartAllCharactersPositions()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		base.RestartAllCharactersPositions();
		PlayerController.TeleportPlayer(1, NinjaChallengeEvent.instance.playerPositions[Bed.instance.numInstance - 1].position, PlayerController.GetPlayer(1).LEOIMFNKFGA);
		Direction direction = ((Bed.instance.numInstance == 1) ? Direction.Left : ((Bed.instance.numInstance == 2) ? Direction.Left : ((Bed.instance.numInstance != 3) ? Direction.Right : Direction.Right)));
		PlayerController.GetPlayer(1).characterAnimation.SetDirection(direction);
		if (GameManager.LocalCoop())
		{
			PlayerController.TeleportPlayer(2, NinjaChallengeEvent.instance.playerPositions[1].position, PlayerController.GetPlayer(1).LEOIMFNKFGA);
			PlayerController.GetPlayer(2).SetDirection(Direction.Left);
		}
		((Component)KyrohNPC.GGFJGHHHEJC).transform.position = NinjaChallengeEvent.instance.movePositions[0].position;
		KyrohNPC.GGFJGHHHEJC.ChangeState(KyrohState.WaitingToServe);
		NinjaOrdersManager.instance.ResetAllOrders();
	}

	private void HMOMBAFIJAI()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void JDAMCMODANB()
	{
		instance = this;
	}

	public override void UnblockPlayers()
	{
		base.UnblockPlayers();
		GameActionBarUI.Get(1).CloseUI();
		NinjaTrayUI.Get(1).OpenUI();
		if (GameManager.LocalCoop())
		{
			NinjaTrayUI.Get(2).OpenUI();
			GameActionBarUI.Get(2).CloseUI();
		}
	}

	private void AHLAMJADBDD()
	{
		if (currentRound == 0)
		{
			NinjaOrdersUI.instance.fadeOutAllIngredients = false;
			NinjaOrdersUI.instance.fadeOutSomeIngredients = true;
		}
		else if (currentRound == 0)
		{
			NinjaOrdersUI.instance.fadeOutAllIngredients = false;
			NinjaOrdersUI.instance.fadeOutSomeIngredients = true;
		}
		else
		{
			NinjaOrdersUI.instance.fadeOutAllIngredients = false;
			NinjaOrdersUI.instance.fadeOutSomeIngredients = true;
		}
	}

	public override void BlockPlayers()
	{
		base.BlockPlayers();
		NinjaTrayUI.Get(1).CloseUI();
	}

	private void CDHBLKJEOPI()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private void PMLBFEFMNPF()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private IEnumerator LKGHCACALPO(int KFHIFOABOFP)
	{
		return base.NBCIALFNLAA(KFHIFOABOFP);
	}

	private IEnumerator KHJEGPEGLPH(bool HPNPAKJCDAB)
	{
		return base.LOCDIHNIMFI(HPNPAKJCDAB);
	}

	private void ODJFJEEIIHK()
	{
		if (currentRound == 0)
		{
			NinjaOrdersUI.instance.fadeOutAllIngredients = false;
			NinjaOrdersUI.instance.fadeOutSomeIngredients = false;
		}
		else if (currentRound == 0)
		{
			NinjaOrdersUI.instance.fadeOutAllIngredients = false;
			NinjaOrdersUI.instance.fadeOutSomeIngredients = true;
		}
		else
		{
			NinjaOrdersUI.instance.fadeOutAllIngredients = true;
			NinjaOrdersUI.instance.fadeOutSomeIngredients = false;
		}
	}

	private IEnumerator HGAANAIJGLE(bool HPNPAKJCDAB)
	{
		return base.LOCDIHNIMFI(HPNPAKJCDAB);
	}

	private void PFCLBGNIONB()
	{
		if (currentRound == 0)
		{
			NinjaOrdersUI.instance.fadeOutAllIngredients = false;
			NinjaOrdersUI.instance.fadeOutSomeIngredients = false;
		}
		else if (currentRound == 0)
		{
			NinjaOrdersUI.instance.fadeOutAllIngredients = true;
			NinjaOrdersUI.instance.fadeOutSomeIngredients = true;
		}
		else
		{
			NinjaOrdersUI.instance.fadeOutAllIngredients = false;
			NinjaOrdersUI.instance.fadeOutSomeIngredients = true;
		}
	}

	private void CLLAKJADGIH()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private IEnumerator PMNLKHFLLAA(int KFHIFOABOFP)
	{
		return base.NBCIALFNLAA(KFHIFOABOFP);
	}

	private IEnumerator FPKDJJCAKLM(bool HPNPAKJCDAB)
	{
		return base.LOCDIHNIMFI(HPNPAKJCDAB);
	}

	[DebuggerHidden]
	[CompilerGenerated]
	private IEnumerator LLIJGOCKPBB(int KFHIFOABOFP)
	{
		return base.NBCIALFNLAA(KFHIFOABOFP);
	}

	private void HINKPJCNPCF()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	[DebuggerHidden]
	[CompilerGenerated]
	private IEnumerator IBDHIPLELBI(bool HPNPAKJCDAB)
	{
		return base.LOCDIHNIMFI(HPNPAKJCDAB);
	}

	private void JAGPBGGJDGL()
	{
		if (currentRound == 0)
		{
			NinjaOrdersUI.instance.fadeOutAllIngredients = false;
			NinjaOrdersUI.instance.fadeOutSomeIngredients = false;
		}
		else if (currentRound == 0)
		{
			NinjaOrdersUI.instance.fadeOutAllIngredients = true;
			NinjaOrdersUI.instance.fadeOutSomeIngredients = false;
		}
		else
		{
			NinjaOrdersUI.instance.fadeOutAllIngredients = true;
			NinjaOrdersUI.instance.fadeOutSomeIngredients = false;
		}
	}

	private void Awake()
	{
		instance = this;
	}

	private IEnumerator ADHMHCBKNJI(bool HPNPAKJCDAB)
	{
		return base.LOCDIHNIMFI(HPNPAKJCDAB);
	}
}
