using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class NinjaChallenge : MonoBehaviour, IChallenge
{
	[CompilerGenerated]
	private sealed class PKBADGGNDBI : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public PKBADGGNDBI(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				if ((Object)(object)Utils.JGEPCPFJANP(Location.BathhouseInterior) == (Object)null)
				{
					_003C_003E2__current = BKFKOFAMLOP();
					_003C_003E1__state = 1;
					return true;
				}
				goto IL_004f;
			case 1:
				_003C_003E1__state = -1;
				goto IL_004f;
			case 2:
				{
					_003C_003E1__state = -1;
					if (Object.op_Implicit((Object)(object)instance))
					{
						instance.FKNCGBGMCOC();
					}
					PlayerInputs.EnableKeyboardInputsAndMovement(1, (MonoBehaviour)(object)GameManager.GGFJGHHHEJC);
					return false;
				}
				IL_004f:
				_003C_003E2__current = CommonReferences.wait01;
				_003C_003E1__state = 2;
				return true;
			}
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
			throw new NotSupportedException();
		}
	}

	public static NinjaChallenge instance;

	public static bool Replaying;

	[SerializeField]
	private bool _challengeStarted;

	private Coroutine IKKHMDGLHGB;

	public static bool ADDLIAMDPBL
	{
		get
		{
			if ((Object)(object)instance != (Object)null)
			{
				return instance._challengeStarted;
			}
			return false;
		}
		set
		{
			if ((Object)(object)instance != (Object)null)
			{
				instance._challengeStarted = value;
			}
		}
	}

	private IEnumerator LLDHMMIKOAB(bool IAPOBPCFAGN, float BODLJHFNFFK)
	{
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		EventCountdownUI.ChangeText(IAPOBPCFAGN ? "Victory" : "Defeat");
		yield return CommonReferences.wait3;
		EventCountdownUI.CloseCountdown();
		yield return CommonReferences.wait025;
		ChallengeEndDialogueUI.instance.Initialize(SO_Challenges.ChallengeType.ninja, IAPOBPCFAGN, BODLJHFNFFK);
		ChallengeEndDialogueUI.instance.OpenUI();
		IKKHMDGLHGB = null;
	}

	private static void LJABDHLJDBF(bool CDPAMNIPPEC = true)
	{
		((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(CEJIFCMPMKN());
	}

	protected void Awake()
	{
		instance = this;
	}

	public void BFJPDENLLKN()
	{
		if (OnlineManager.MasterOrOffline())
		{
			Utils.DLIIAHACOJB(-99);
			if (ChallengePointsSystem.BNAGLJCBMEL(0))
			{
				Utils.DLIIAHACOJB(22, CDPAMNIPPEC: true);
			}
		}
	}

	public static void KDCNDOENIMP()
	{
		Replaying = false;
		KyrohNPC.KADHMEPDIKM().animationBase.animator.Rebind();
		KyrohNPC.OAPOJCODNCO().animationBase.animator.Update(1320f);
		StartChallengeEvent(CDPAMNIPPEC: false);
	}

	public void PKPJCPILMBH()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		IJMLBAKKNHF();
		KyrohNPC.AGGAGCBAGLL().FIOKAPKBCOD(KyrohState.Inactive);
		NinjaChallengeEvent.instance.ActivateEvent();
		PlayerController.CLEIAKPOGMM(0, NinjaRoundsManager.instance.stopPlayingPosition.position, ~(Location.Road | Location.Quarry | Location.Farm | Location.BarnInterior));
		if (GameManager.LocalCoop())
		{
			PlayerController.CLEIAKPOGMM(6, NinjaRoundsManager.instance.stopPlayingPosition.position + new Vector3(228f, 1926f), ~(Location.Tavern | Location.River | Location.Camp | Location.BarnInterior));
		}
		ANFOKGPKAIM();
		((MonoBehaviour)GameManager.NJNFHEPLEHL()).StartCoroutine(PlayMusic(-14));
	}

	private static IEnumerator BKFKOFAMLOP()
	{
		TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Bathhouse, Location.BathhouseInterior).StartTravelZone(1);
		if (GameManager.LocalCoop())
		{
			TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Bathhouse, Location.BathhouseInterior).StartTravelZone(2);
		}
		while ((Object)(object)Utils.JGEPCPFJANP(Location.BathhouseInterior) == (Object)null)
		{
			yield return CommonReferences.wait01;
		}
	}

	private void MACFNJNMFGK()
	{
		LocalCooperativeManager.RestoreCameraInLocalCoop();
		PlayerInputs.ELJNFCLAGGI((MonoBehaviour)(object)instance);
		WorldTime.JKPGEIACDON(AODONKKHPBP: true);
		PlayerInputs.KJEFJPFLGPN((MonoBehaviour)(object)this);
		NinjaRoundsManager.instance.StopRounds();
		NinjaOrdersManager.PENCGAEACAK();
		TavernManagerUI.ShowPermanentTavernInfo((MonoBehaviour)(object)this);
		TavernManagerUI.ShowClockAndTavernInfo();
	}

	public void ReturnToCastle(bool IAPOBPCFAGN, float BODLJHFNFFK)
	{
		Replaying = false;
		if (IKKHMDGLHGB == null)
		{
			IKKHMDGLHGB = ((MonoBehaviour)this).StartCoroutine(LLDHMMIKOAB(IAPOBPCFAGN, BODLJHFNFFK));
		}
	}

	public static void StartChallengeEvent(bool CDPAMNIPPEC = true)
	{
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineNinjaManager.instance.SendStartNinjaChallenge();
		}
		if ((Object)(object)NinjaRoundsManager.instance == (Object)null)
		{
			LJABDHLJDBF(CDPAMNIPPEC);
		}
		else
		{
			instance.FKNCGBGMCOC();
		}
	}

	private void JFHJCFJEAPH()
	{
		LocalCooperativeManager.OLCIIHKGDNP();
		PlayerInputs.ELJNFCLAGGI((MonoBehaviour)(object)instance);
		WorldTime.JKPGEIACDON(AODONKKHPBP: true);
		PlayerInputs.KJEFJPFLGPN((MonoBehaviour)(object)this);
		NinjaRoundsManager.instance.StopRounds();
		NinjaOrdersManager.StopCustomerOrdersCoroutine();
		TavernManagerUI.BKMMFCHDJMA((MonoBehaviour)(object)this);
		TavernManagerUI.ShowClockAndTavernInfo();
	}

	public void MEPGKMGJADJ()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		IJMLBAKKNHF();
		KyrohNPC.KADHMEPDIKM().ChangeState(KyrohState.Inactive);
		NinjaChallengeEvent.instance.ActivateEvent();
		PlayerController.TeleportPlayer(1, NinjaRoundsManager.instance.stopPlayingPosition.position, ~(Location.Road | Location.River | Location.Quarry | Location.Farm | Location.BarnInterior));
		if (GameManager.LocalCoop())
		{
			PlayerController.CLEIAKPOGMM(4, NinjaRoundsManager.instance.stopPlayingPosition.position + new Vector3(820f, 244f), ~(Location.Tavern | Location.River | Location.Camp | Location.Quarry | Location.BarnInterior));
		}
		JFHJCFJEAPH();
		((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(PlayMusic(-37));
	}

	private void IJBIMPDAEBJ()
	{
		IJMLBAKKNHF();
		ANFOKGPKAIM();
	}

	public void GiveRewards()
	{
		UnlockAchievements();
		ItemDatabaseAccessor.GetItem(1812).IPGBILAIAPG(CDPAMNIPPEC: false);
		if (OnlineManager.MasterOrOffline())
		{
			PlayerInventory.GetPlayer(1).AddItem(ItemDatabaseAccessor.GetItem(1816).JMDALJBNFML(), HMPDLIPFBGD: true);
		}
		RecipesManager.UnlockRecipeMaster(514, IBHGAMNNOHI: true, CDPAMNIPPEC: false);
		RecipesManager.UnlockRecipeMaster(645, IBHGAMNNOHI: true, CDPAMNIPPEC: false);
	}

	private static IEnumerator AMBAMCFBEKH()
	{
		return new PKBADGGNDBI(1);
	}

	private IEnumerator CLGNJHNEJDI()
	{
		TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.CastleGarden, Location.Castle).StartTravelZone(1);
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(OHFPGKMNBHG));
		if (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(2) != (Object)null)
		{
			TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.CastleGarden, Location.Castle).StartTravelZone(2);
		}
		yield return CommonReferences.wait2;
		AttackEvent.instance.SetSleepEvent();
	}

	private static void JAMBKPGAGIJ(bool CDPAMNIPPEC = true)
	{
		((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(CEJIFCMPMKN());
	}

	public void OnCloseChallengeEndDialogue(bool BINEPAAJCFD)
	{
		if (BINEPAAJCFD)
		{
			PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
			BeginReplay();
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(CLGNJHNEJDI());
		}
	}

	public void IBJCKJEBLCC(bool BINEPAAJCFD)
	{
		if (BINEPAAJCFD)
		{
			PlayerInputs.ELJNFCLAGGI((MonoBehaviour)(object)instance);
			KDCNDOENIMP();
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(CLGNJHNEJDI());
		}
	}

	public void FinishChallengeWhenEventIsLost()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		IJMLBAKKNHF();
		KyrohNPC.GGFJGHHHEJC.ChangeState(KyrohState.Idle);
		NinjaChallengeEvent.instance.ActivateEvent();
		PlayerController.TeleportPlayer(1, NinjaRoundsManager.instance.stopPlayingPosition.position, Location.BathhouseInterior);
		if (GameManager.LocalCoop())
		{
			PlayerController.TeleportPlayer(2, NinjaRoundsManager.instance.stopPlayingPosition.position + new Vector3(0.5f, 0f), Location.BathhouseInterior);
		}
		ANFOKGPKAIM();
		((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(PlayMusic(30));
	}

	public void UnlockAchievements()
	{
		if (OnlineManager.MasterOrOffline())
		{
			Utils.DLIIAHACOJB(40);
			if (ChallengePointsSystem.IsAnyPlayerWinningBy(5))
			{
				Utils.DLIIAHACOJB(45);
			}
		}
	}

	private void FKNCGBGMCOC()
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		ADDLIAMDPBL = true;
		if (OnlineManager.MasterOrOffline())
		{
			TavernManager.GGFJGHHHEJC.SetOpen(1, AODONKKHPBP: false, AINPJHKNJGL: true);
		}
		TavernManager.AddOpenTavernBlocker((MonoBehaviour)(object)instance);
		ChallengePointsSystem.instance.ResetPoints();
		ChallengeEventPointsUI.instance.OpenUI();
		ChallengeEventPointsUI.instance.SetOpponentSprite(CharacterName.Kyroh);
		NinjaPreparationTablesManager.instance.ActivatePreparationTables();
		if (OnlineManager.MasterOrOffline())
		{
			NinjaFoodTablesManager.RandomiseFood();
			NinjaOrdersManager.StartCustomerOrders();
		}
		PlayerInputs.AddPlayer2Blocker((MonoBehaviour)(object)this);
		WorldTime.JJICPIINBEH = true;
		TavernManagerUI.HideClockAndTavernInfo();
		TavernManagerUI.HidePermanentTavernInfo((MonoBehaviour)(object)this);
		MissionsManager.PermanentHideObjectives(KJMAFOMIJNL: true);
		NinjaRoundsManager.instance.StartRounds();
		NinjaRoundsManager.instance.RestartAllCharactersPositions();
		if (Utils.HJPCBBGHPDA(Vector2.op_Implicit(((Component)KyrohNPC.GGFJGHHHEJC).transform.position)) != Location.BathhouseInterior)
		{
			((Component)KyrohNPC.GGFJGHHHEJC).transform.position = NinjaChallengeEvent.instance.movePositions[0].position;
		}
		KyrohNPC.GGFJGHHHEJC.playerCanInteract = false;
		((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(PlayMusic(34));
		if (OnlineManager.MasterOrOffline())
		{
			KyrohNPC.GGFJGHHHEJC.trayHandler.InitializeBento();
			KyrohNPC.GGFJGHHHEJC.ChangeState(KyrohState.WaitingToServe);
		}
	}

	private void KCOCGPLPKME()
	{
		IJMLBAKKNHF();
		ANFOKGPKAIM();
	}

	[SpecialName]
	public static void EAEBGNAJLBL(bool AODONKKHPBP)
	{
		if ((Object)(object)instance != (Object)null)
		{
			instance._challengeStarted = AODONKKHPBP;
		}
	}

	public void FinishChallengeWhenEventIsWon()
	{
		IJMLBAKKNHF();
		PlayerInputs.RemovePlayer2Blocker((MonoBehaviour)(object)this);
	}

	public void HABPLAJDLFH()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		IJMLBAKKNHF();
		KyrohNPC.PBJDFFEFMKM().ChangeState(KyrohState.Idle);
		NinjaChallengeEvent.instance.ActivateEvent();
		PlayerController.CLEIAKPOGMM(1, NinjaRoundsManager.instance.stopPlayingPosition.position, Location.Tavern | Location.Quarry | Location.FarmShop);
		if (GameManager.LocalCoop())
		{
			PlayerController.TeleportPlayer(6, NinjaRoundsManager.instance.stopPlayingPosition.position + new Vector3(348f, 1286f), Location.Road | Location.Quarry);
		}
		JFHJCFJEAPH();
		((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(PlayMusic(78));
	}

	private void ANFOKGPKAIM()
	{
		LocalCooperativeManager.RestoreCameraInLocalCoop();
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		WorldTime.JJICPIINBEH = false;
		PlayerInputs.RemovePlayer2Blocker((MonoBehaviour)(object)this);
		NinjaRoundsManager.instance.StopRounds();
		NinjaOrdersManager.StopCustomerOrdersCoroutine();
		TavernManagerUI.ShowPermanentTavernInfo((MonoBehaviour)(object)this);
		TavernManagerUI.ShowClockAndTavernInfo();
	}

	private void IJMLBAKKNHF()
	{
		ChallengesUI.AnyMinigameInProgress = false;
		ADDLIAMDPBL = false;
		ChallengePointsSystem.instance.ResetPoints();
		ChallengeEventPointsUI.instance.CloseUI();
		CountdownUI.SetCountdownText(0f);
		CountdownUI.HideCountdown();
		TavernManager.RemoveOpenTavernBlocker((MonoBehaviour)(object)this);
		GameActionBarUI.Get(1).Open(1);
		if (GameManager.LocalCoop())
		{
			GameActionBarUI.Get(2).Open(1);
		}
		NinjaPreparationTablesManager.instance.ResetAllBentos(CDPAMNIPPEC: false);
		KyrohNPC.GGFJGHHHEJC.playerCanInteract = true;
	}

	public void KIALKGMBLFI()
	{
		IJMLBAKKNHF();
		PlayerInputs.KJEFJPFLGPN((MonoBehaviour)(object)this);
	}

	public IEnumerator PlayMusic(int DCFNIMCMFEM)
	{
		MusicController.instance.FadeOutClip(2f, MMEHJCGGNFE: true, DCFNIMCMFEM);
		yield return CommonReferences.wait2;
		MusicController.instance.TriggerMusicTheme(DCFNIMCMFEM);
	}

	public static void BeginReplay()
	{
		Replaying = true;
		KyrohNPC.GGFJGHHHEJC.animationBase.animator.Rebind();
		KyrohNPC.GGFJGHHHEJC.animationBase.animator.Update(0f);
		StartChallengeEvent();
	}

	private static IEnumerator CEJIFCMPMKN()
	{
		if ((Object)(object)Utils.JGEPCPFJANP(Location.BathhouseInterior) == (Object)null)
		{
			yield return BKFKOFAMLOP();
		}
		yield return CommonReferences.wait01;
		if (Object.op_Implicit((Object)(object)instance))
		{
			instance.FKNCGBGMCOC();
		}
		PlayerInputs.EnableKeyboardInputsAndMovement(1, (MonoBehaviour)(object)GameManager.GGFJGHHHEJC);
	}

	private void OHFPGKMNBHG(int CIFJJBHINEF)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(OHFPGKMNBHG));
		KCOCGPLPKME();
		PlayerController.TeleportPlayer(1, Minigame.REPLAY_CASTLE_POSITION, Location.Castle);
		PlayerController.TeleportPlayer(2, Minigame.REPLAY_CASTLE_POSITION, Location.Castle);
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
	}

	public static void JPCKECGCDML()
	{
		Replaying = false;
		KyrohNPC.KFGKCKCDMLG().animationBase.animator.Rebind();
		KyrohNPC.AGGAGCBAGLL().animationBase.animator.Update(867f);
		StartChallengeEvent(CDPAMNIPPEC: false);
	}
}
