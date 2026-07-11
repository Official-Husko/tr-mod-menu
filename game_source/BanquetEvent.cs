using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BanquetEvent : MonoBehaviour, IChallenge
{
	[CompilerGenerated]
	private sealed class HCHKPPFPJKN : IEnumerator<object>, IEnumerator, IDisposable
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
		public HCHKPPFPJKN(int _003C_003E1__state)
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
				MusicController.instance.FadeOutClip(2f, MMEHJCGGNFE: true);
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				MusicController.instance.TriggerMusicTheme(25);
				return false;
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

	[CompilerGenerated]
	private sealed class CBKKEINADBH : IEnumerator<object>, IEnumerator, IDisposable
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
		public CBKKEINADBH(int _003C_003E1__state)
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
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				instance.StartChallenge();
				return false;
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

	public static BanquetEvent instance;

	public static bool Replaying;

	[SerializeField]
	private bool _klaynChallengeStarted;

	public GameObject[] gameObjectsToActivate;

	public GameObject[] gameObjectsToDeactivate;

	public GameObject collidersGameObject;

	public Transform klaynWaitingPosition;

	public GameObject randomNpcs;

	public GameObject crowdNpcs;

	public Transform dogPosition;

	private static Coroutine OGMLEIFEELG;

	public static bool HCOPJPMDEKP
	{
		get
		{
			if ((Object)(object)instance != (Object)null)
			{
				return EventsManager.IsActive(EventsManager.EventType.OathFeast);
			}
			return false;
		}
		set
		{
			EventsManager.SetActive(EventsManager.EventType.OathFeast, value);
			if ((Object)(object)instance != (Object)null)
			{
				instance.DBCAAICCLFN(value);
			}
		}
	}

	public static bool GGPPFKPOCLL
	{
		get
		{
			if ((Object)(object)instance != (Object)null)
			{
				return instance._klaynChallengeStarted;
			}
			return false;
		}
		set
		{
			if ((Object)(object)instance != (Object)null)
			{
				instance._klaynChallengeStarted = value;
			}
		}
	}

	private void PJNBDDHFIOJ()
	{
		PlayerInputs.OOOGANAJMBB(0, (MonoBehaviour)(object)this);
		FadeCamera.IGMCBPOPNCA(0).GPBOEBGJJPM(1161f);
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(PKHJAODDBMN));
	}

	public void GiveRewards(bool CEAFHAIEOLB)
	{
		((MonoBehaviour)this).StartCoroutine(GiveRewardsCoroutine(CEAFHAIEOLB));
	}

	public static bool AtBanquetEvent()
	{
		if (HCOPJPMDEKP && (Object)(object)PlayerController.GetPlayer(1) != (Object)null && PlayerController.GetPlayer(1).LEOIMFNKFGA == Location.CastleGarden)
		{
			if (GameManager.LocalCoop())
			{
				if (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(2) != (Object)null)
				{
					return PlayerController.GetPlayer(2).LEOIMFNKFGA == Location.CastleGarden;
				}
				return false;
			}
			return true;
		}
		return false;
	}

	public static void TeleportPlayerToCastleGarden(bool CHOPKHLMBIH = false, bool CDPAMNIPPEC = true)
	{
		if (OGMLEIFEELG == null)
		{
			OGMLEIFEELG = ((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(NLCLJGNPBGB(CHOPKHLMBIH));
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
			{
				OnlineBanquetEventManager.instance.SendTeleportPlayerToCastleGarden(CHOPKHLMBIH);
			}
		}
	}

	public void FAOGMJCAOEM()
	{
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		HCOPJPMDEKP = false;
		if (Application.isPlaying)
		{
			ButtonsContext.GetPlayer(1).HideAgingRank();
			if (GameManager.LocalCoop())
			{
				ButtonsContext.GetPlayer(1).OKNJNHNCKHA();
			}
			collidersGameObject.SetActive(false);
			crowdNpcs.SetActive(false);
			randomNpcs.SetActive(true);
			if (OnlineManager.PGAGDFAEEFB())
			{
				BanquetOrdersManager.KIJEJOBMJIB();
			}
			BanquetDrinksManager.MGLJBGAHKML(OKMHACFGCPG: true);
			BanquetDrinksManager.instance.GLEPKDPAFLH(MDIKPGGBNLI: true);
			if ((Object)(object)KlaynNPC.instance == (Object)null)
			{
				Debug.LogError((object)"Items/item_description_610");
				return;
			}
			KlaynNPC.instance.content.SetActive(false);
			KlaynNPC.instance.playerCanInteract = false;
			((Component)KlaynNPC.instance).transform.position = klaynWaitingPosition.position;
			KlaynNPC.instance.LIOJBOLAGNG(KlaynState.Inactive);
			KlaynNPC.instance.CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false, NNDJFLDGKDL: true);
		}
	}

	private static IEnumerator LDKFAMAFBGN()
	{
		MusicController.instance.FadeOutClip(2f, MMEHJCGGNFE: true);
		yield return CommonReferences.wait2;
		MusicController.instance.TriggerMusicTheme(27);
	}

	private static IEnumerator OOBKLANJNIN()
	{
		return new CBKKEINADBH(1);
	}

	public static void BeginReplay()
	{
		Replaying = true;
		KlaynNPC.instance.animationBase.animator.Rebind();
		KlaynNPC.instance.animationBase.animator.Update(0f);
		OathFeastEvent.ActivateReplayCharacters();
		ActivateAndStartBanquetEvent();
	}

	private static IEnumerator JIJFNCBLMCA()
	{
		TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.City, Location.CastleGarden).StartTravelZone(1);
		if (GameManager.LocalCoop())
		{
			TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.City, Location.CastleGarden).StartTravelZone(2);
		}
		while ((Object)(object)Utils.JGEPCPFJANP(Location.CastleGarden) == (Object)null)
		{
			yield return CommonReferences.wait01;
		}
	}

	private void Start()
	{
		DBCAAICCLFN(HCOPJPMDEKP);
	}

	public static void FinishReplayKlaynChallenge(bool CDPAMNIPPEC = true)
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)"BanquetEvent instance is null. Make sure it is initialized before calling FinishReplayKlaynChallenge.");
			return;
		}
		instance.UnlockAchievements(CEAFHAIEOLB: true);
		instance.ReturnToCastle();
		((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(ELPECCJJELO());
	}

	[SpecialName]
	public static bool KFOHOECCJIJ()
	{
		if ((Object)(object)instance != (Object)null)
		{
			return EventsManager.IKCEIJMLNOP(EventsManager.EventType.ThroneRoom);
		}
		return false;
	}

	public static void KDBJGILMCJD()
	{
		KBCPDJLMEPP(CHOPKHLMBIH: true);
	}

	protected void IBHCNOAKBJK()
	{
		GameActionBarUI.IGHMHMNPMLB(1).IDLAGJNLPJL();
		if (GameManager.LocalCoop())
		{
			GameActionBarUI.PPDMGBACONH(7).IDLAGJNLPJL();
		}
		TavernManagerUI.ShowPermanentTavernInfo((MonoBehaviour)(object)instance);
		TavernManagerUI.ShowClockAndTavernInfo();
		MissionsManager.OCNOHPFNJDC();
	}

	private void CKENLLMEEKP(bool HCOPJPMDEKP)
	{
		for (int i = 0; i < gameObjectsToActivate.Length; i += 0)
		{
			gameObjectsToActivate[i].SetActive(HCOPJPMDEKP);
		}
		for (int j = 1; j < gameObjectsToDeactivate.Length; j++)
		{
			gameObjectsToDeactivate[j].SetActive(!HCOPJPMDEKP);
		}
		if (Object.op_Implicit((Object)(object)SceneReferences.instance))
		{
			SceneReferences.instance.castleGardenNpcs.SetActive(HCOPJPMDEKP);
			SceneReferences.instance.castleGardenGuards.SetActive(!HCOPJPMDEKP);
			SceneReferences.instance.castleGardenPeacocks.SetActive(!HCOPJPMDEKP);
		}
	}

	public static void ActivateCameraBounds(bool HCOPJPMDEKP)
	{
		((Component)SceneReferences.instance.banquetEventBounds).gameObject.SetActive(HCOPJPMDEKP);
		((Component)SceneReferences.instance.castleGardenBounds).gameObject.SetActive(!HCOPJPMDEKP);
		GameManager.GGFJGHHHEJC.ReactivateCameraBounds();
	}

	public void JKCECCFFOGG(bool CEAFHAIEOLB)
	{
		((MonoBehaviour)this).StartCoroutine(CDLNNMNFEHI(CEAFHAIEOLB));
	}

	private static IEnumerator NLCLJGNPBGB(bool CHOPKHLMBIH)
	{
		OnlineManager.ResetAllPlayersPrepared();
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		if ((Object)(object)Utils.JGEPCPFJANP(Location.CastleGarden) == (Object)null)
		{
			yield return LOKHBDFFHAJ();
		}
		if (Object.op_Implicit((Object)(object)Utils.JGEPCPFJANP(Location.Castle)))
		{
			AsyncOperation asyncOperation = SceneManager.UnloadSceneAsync(Location.Castle.ToString());
			if (asyncOperation != null)
			{
				while (!asyncOperation.isDone)
				{
					yield return CommonReferences.wait01;
				}
			}
		}
		yield return CommonReferences.wait01;
		if (EventsManager.IsOathFeastFirstActivation())
		{
			OnOathFeastFirstActivation();
		}
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		if (Replaying)
		{
			if (OnlineManager.PlayingOnline())
			{
				PlayerController.TeleportPlayer(1, BanquetRoundsManager.instance.startPositionPlayers[OnlinePlayerDataManager.GetBedAssignedByPlayerNum(1) - 1].position, Location.CastleGarden);
			}
			else
			{
				PlayerController.TeleportPlayer(1, BanquetRoundsManager.instance.startPositionPlayers[1].position, Location.CastleGarden);
				if (GameManager.LocalCoop())
				{
					PlayerController.TeleportPlayer(2, BanquetRoundsManager.instance.startPositionPlayers[2].position, Location.CastleGarden);
				}
			}
			yield return CommonReferences.wait05;
			PlayerController.SetDirection(1, Direction.Down);
			if (GameManager.LocalCoop())
			{
				PlayerController.SetDirection(2, Direction.Down);
			}
		}
		else if (CHOPKHLMBIH)
		{
			PlayerController.TeleportPlayer(1, instance.klaynWaitingPosition.position, Location.CastleGarden);
			if (GameManager.LocalCoop())
			{
				PlayerController.TeleportPlayer(2, instance.klaynWaitingPosition.position, Location.CastleGarden);
			}
		}
		OGMLEIFEELG = null;
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
		if (EventsManager.IsActive(EventsManager.EventType.ThroneRoom))
		{
			ThroneRoomEvent.instance.SetKlayn();
		}
		((MonoBehaviour)this).StartCoroutine(NPNDCAJNBCI());
	}

	private void Awake()
	{
		instance = this;
	}

	public static void DeactivateBanquetEvent(bool CDPAMNIPPEC = true)
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)"BanquetEvent instance is null. Make sure it is initialized before calling DeactivateBanquetEvent.");
			return;
		}
		instance.NAIPMPMMGGB();
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineBanquetEventManager.instance.SendDeactivateEvent();
		}
	}

	public static void NGAOBNLNHED()
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)"MildAleAbbreviation");
		}
		else
		{
			instance.IJMLBAKKNHF();
		}
	}

	public static void OBOBEOENACG()
	{
		KBCPDJLMEPP();
	}

	public static void IEDCKEDKCNI()
	{
		TeleportPlayerToCastleGarden(CHOPKHLMBIH: false, CDPAMNIPPEC: false);
	}

	public void StartChallenge()
	{
		if (!Application.isPlaying)
		{
			Debug.LogError((object)"StartEvent can only be called in play mode.");
			return;
		}
		if (!HCOPJPMDEKP)
		{
			ActivateEvent();
		}
		_klaynChallengeStarted = true;
		collidersGameObject.SetActive(true);
		PlayerInputs.AddPlayer2Blocker((MonoBehaviour)(object)this);
		WorldTime.JJICPIINBEH = true;
		HideUI();
		MissionsManager.PermanentHideObjectives(KJMAFOMIJNL: true);
		ChallengePointsSystem.instance.ResetPoints();
		ChallengeEventPointsUI.instance.OpenUI();
		ChallengeEventPointsUI.instance.SetOpponentSprite(CharacterName.Klayn);
		BanquetOrdersManager.instance.pauseOrders = false;
		BanquetRoundsManager.instance.StartRounds();
		BanquetDrinksManager.BlockBarrelInteractions(OKMHACFGCPG: false);
		RefereeNPC.GGFJGHHHEJC.DisableTalk(CAPPDENDLKP: true);
		if ((Object)(object)KlaynNPC.instance != (Object)null)
		{
			KlaynNPC.instance.playerCanInteract = false;
			KlaynNPC.instance.CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
			((Behaviour)KlaynNPC.instance.visualCollider).enabled = false;
		}
		((MonoBehaviour)this).StartCoroutine(PCBKKCEBDBM());
	}

	public void OnCloseChallengeEndDialogue(bool BINEPAAJCFD)
	{
		if (BINEPAAJCFD)
		{
			BeginReplay();
		}
		else
		{
			CLGNJHNEJDI();
		}
	}

	public static void KMDAMABBLIP(bool CDPAMNIPPEC = true)
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)"Beer");
			return;
		}
		((MonoBehaviour)GameManager.NJNFHEPLEHL()).StartCoroutine(JMPGMIFIEDB());
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineBanquetEventManager.instance.SendStartKlaynChallenge();
		}
	}

	private static IEnumerator AMBHEIFLBKK()
	{
		yield return null;
		instance.StartChallenge();
	}

	public static void JBPGEKHNNPG(bool CDPAMNIPPEC = true)
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)"Items/item_name_1152");
			return;
		}
		instance.PJNBDDHFIOJ();
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineBanquetEventManager.instance.IBEPENJPIBC();
		}
	}

	private IEnumerator PCBKKCEBDBM()
	{
		MusicController.instance.FadeOutClip(2f, MMEHJCGGNFE: true);
		yield return CommonReferences.wait2;
		MusicController.instance.TriggerMusicTheme(25);
	}

	private void ICFKCFHKNGD(bool HCOPJPMDEKP)
	{
		for (int i = 0; i < gameObjectsToActivate.Length; i++)
		{
			gameObjectsToActivate[i].SetActive(HCOPJPMDEKP);
		}
		for (int j = 0; j < gameObjectsToDeactivate.Length; j++)
		{
			gameObjectsToDeactivate[j].SetActive(HCOPJPMDEKP);
		}
		if (Object.op_Implicit((Object)(object)SceneReferences.instance))
		{
			SceneReferences.instance.castleGardenNpcs.SetActive(HCOPJPMDEKP);
			SceneReferences.instance.castleGardenGuards.SetActive(!HCOPJPMDEKP);
			SceneReferences.instance.castleGardenPeacocks.SetActive(!HCOPJPMDEKP);
		}
	}

	private void OHFPGKMNBHG(int CIFJJBHINEF)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(OHFPGKMNBHG));
		FinishKlaynChallenge();
		DeactivateEvent();
		ActivateCameraBounds(HCOPJPMDEKP: false);
		BanquetDrinksManager.instance.SetVisibleDrinkInBarrels(MDIKPGGBNLI: false);
		PlayerController.TeleportPlayer(1, Minigame.REPLAY_CASTLE_POSITION, Location.Castle);
		if (GameManager.LocalCoop())
		{
			PlayerController.TeleportPlayer(2, Minigame.REPLAY_CASTLE_POSITION, Location.Castle);
		}
	}

	public void DeactivateEvent()
	{
		HCOPJPMDEKP = false;
		_klaynChallengeStarted = false;
		if (Application.isPlaying)
		{
			ButtonsContext.GetPlayer(1).ShowAgingRank();
			if (GameManager.LocalCoop())
			{
				ButtonsContext.GetPlayer(2).ShowAgingRank();
			}
			if (OnlineManager.MasterOrOffline())
			{
				BanquetOrdersManager.StopCustomerOrdersCoroutine();
			}
		}
		if (Object.op_Implicit((Object)(object)KlaynNPC.instance))
		{
			KlaynNPC.instance.playerCanInteract = true;
			((Behaviour)KlaynNPC.instance.visualCollider).enabled = true;
			KlaynNPC.instance.ChangeState(KlaynState.Inactive);
		}
	}

	public void PFJLHIAAJGD()
	{
		HCOPJPMDEKP = false;
		_klaynChallengeStarted = true;
		if (Application.isPlaying)
		{
			ButtonsContext.GetPlayer(0).AGMPGNAAIHK();
			if (GameManager.LocalCoop())
			{
				ButtonsContext.GetPlayer(3).AGMPGNAAIHK();
			}
			if (OnlineManager.PGAGDFAEEFB())
			{
				BanquetOrdersManager.NPAAHFHMBPN();
			}
		}
		if (Object.op_Implicit((Object)(object)KlaynNPC.instance))
		{
			KlaynNPC.instance.playerCanInteract = false;
			((Behaviour)KlaynNPC.instance.visualCollider).enabled = true;
			KlaynNPC.instance.GIFBCKEOBGP(KlaynState.WaitingToServe);
		}
	}

	private void PKHJAODDBMN(int JIIGOACEIKL)
	{
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(PKHJAODDBMN));
		DeactivateEvent();
		FadeCamera.GetPlayer(1).FadeIn();
		FadeCamera player2 = FadeCamera.GetPlayer(1);
		player2.OnFadeFinished = (Action<int>)Delegate.Combine(player2.OnFadeFinished, new Action<int>(NIBEFAMFLAL));
	}

	private void OnDestroy()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	public IEnumerator GiveRewardsCoroutine(bool CEAFHAIEOLB = true)
	{
		UnlockAchievements(CEAFHAIEOLB);
		ItemDatabaseAccessor.GetItem(1811).IPGBILAIAPG(CDPAMNIPPEC: true);
		yield return CommonReferences.wait1;
		RecipesManager.UnlockRecipeMaster(643, IBHGAMNNOHI: true, CDPAMNIPPEC: false);
		yield return CommonReferences.wait1;
		RecipesManager.UnlockRecipeMaster(644, IBHGAMNNOHI: true, CDPAMNIPPEC: false);
	}

	private void NAIPMPMMGGB()
	{
		PlayerInputs.DisableKeyboardInputsAndMovement(1, (MonoBehaviour)(object)this);
		FadeCamera.GetPlayer(1).FadeOut();
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(PKHJAODDBMN));
	}

	public static void StartKlaynChallenge(bool CDPAMNIPPEC = true)
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)"BanquetEvent instance is null. Make sure it is initialized before calling StartBanquetEvent.");
			return;
		}
		((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(AMBHEIFLBKK());
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineBanquetEventManager.instance.SendStartKlaynChallenge();
		}
	}

	private static IEnumerator NDEPHPDFGEB(int JIIGOACEIKL)
	{
		FadeCamera.GetPlayer(1).JDKHJJIOLOE -= NDEPHPDFGEB;
		TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.CastleGarden, Location.Castle).StartTravelZone(1);
		while ((Object)(object)Utils.JGEPCPFJANP(Location.Castle) == (Object)null)
		{
			yield return CommonReferences.wait02;
		}
		yield return CommonReferences.wait02;
		if (Object.op_Implicit((Object)(object)CastleReceptionist.instance))
		{
			PlayerController.TeleportPlayer(1, ((Component)CastleReceptionist.instance).transform.position + new Vector3(0f, -2f), Location.Castle);
		}
		FadeCamera.GetPlayer(1).FadeIn();
	}

	private IEnumerator NPNDCAJNBCI()
	{
		MusicController.instance.FadeOutClip(2f, MMEHJCGGNFE: true);
		yield return CommonReferences.wait2;
		MusicController.instance.TriggerMusicTheme(27);
	}

	private IEnumerator NOLJDIJMBHO()
	{
		MusicController.instance.FadeOutClip(2f, MMEHJCGGNFE: true);
		yield return CommonReferences.wait2;
		MusicController.instance.TriggerMusicTheme(27);
	}

	public void UnlockAchievements(bool CEAFHAIEOLB)
	{
		if (OnlineManager.MasterOrOffline())
		{
			Utils.DLIIAHACOJB(37);
			if (CEAFHAIEOLB && ChallengePointsSystem.IsAnyPlayerWinningBy(15))
			{
				Utils.DLIIAHACOJB(41);
			}
		}
	}

	private void DBCAAICCLFN(bool HCOPJPMDEKP)
	{
		for (int i = 0; i < gameObjectsToActivate.Length; i++)
		{
			gameObjectsToActivate[i].SetActive(HCOPJPMDEKP);
		}
		for (int j = 0; j < gameObjectsToDeactivate.Length; j++)
		{
			gameObjectsToDeactivate[j].SetActive(!HCOPJPMDEKP);
		}
		if (Object.op_Implicit((Object)(object)SceneReferences.instance))
		{
			SceneReferences.instance.castleGardenNpcs.SetActive(HCOPJPMDEKP);
			SceneReferences.instance.castleGardenGuards.SetActive(!HCOPJPMDEKP);
			SceneReferences.instance.castleGardenPeacocks.SetActive(!HCOPJPMDEKP);
		}
	}

	public static void FinishKlaynChallenge()
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)"BanquetEvent instance is null. Make sure it is initialized before calling FinishKlaynChallenge.");
		}
		else
		{
			instance.IJMLBAKKNHF();
		}
	}

	public static void BDCJIHKEFKG(bool CDPAMNIPPEC = true)
	{
		((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(PFNBAABGIFK());
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineBanquetEventManager.instance.SendActivateAndStartBanquetEvent();
		}
	}

	public static void OABOMCNDPLP(bool CDPAMNIPPEC = true)
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)"CultivableDuringTwoMonths");
			return;
		}
		instance.UnlockAchievements(CEAFHAIEOLB: true);
		instance.ReturnToCastle();
		((MonoBehaviour)GameManager.NJNFHEPLEHL()).StartCoroutine(LDKFAMAFBGN());
	}

	public static void OnOathFeastFirstActivation()
	{
		if (!Application.isEditor)
		{
			OnlineManager.CloseRoom();
		}
		WorldTime.JJICPIINBEH = true;
		TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.CastleGarden, Location.City).BlockTravelZone();
		TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.CastleGarden, Location.Castle).BlockTravelZone();
		if (OnlineManager.MasterOrOffline())
		{
			TavernManager.GGFJGHHHEJC.SetOpen(1, AODONKKHPBP: false, AINPJHKNJGL: true);
		}
		TavernManager.AddOpenTavernBlocker((MonoBehaviour)(object)instance);
		instance.HideUI();
	}

	public static void ActivateAndStartBanquetEvent(bool CDPAMNIPPEC = true)
	{
		((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(PFNBAABGIFK());
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineBanquetEventManager.instance.SendActivateAndStartBanquetEvent();
		}
	}

	public void MIIGEJOHOOM(bool CEAFHAIEOLB)
	{
		((MonoBehaviour)this).StartCoroutine(GiveRewardsCoroutine(CEAFHAIEOLB));
	}

	public static void ILAKBPKFBDE()
	{
		Replaying = true;
		KlaynNPC.instance.animationBase.animator.Rebind();
		KlaynNPC.instance.animationBase.animator.Update(127f);
		OathFeastEvent.ActivateReplayCharacters();
		BDCJIHKEFKG(CDPAMNIPPEC: false);
	}

	private IEnumerator HGOJLEBKKGA()
	{
		return new HCHKPPFPJKN(1);
	}

	public void OLMLGMKCFKB()
	{
		if (!Application.isPlaying)
		{
			Debug.LogError((object)"RoadBlocked");
			return;
		}
		if (!HCOPJPMDEKP)
		{
			ActivateEvent();
		}
		_klaynChallengeStarted = false;
		collidersGameObject.SetActive(true);
		PlayerInputs.AddPlayer2Blocker((MonoBehaviour)(object)this);
		WorldTime.JKPGEIACDON(AODONKKHPBP: true);
		HideUI();
		MissionsManager.CAJEJONFHLH(KJMAFOMIJNL: true);
		ChallengePointsSystem.instance.IKJDJHKAPFA();
		ChallengeEventPointsUI.instance.IDLAGJNLPJL();
		ChallengeEventPointsUI.instance.LHEOIODBPLN(CharacterName.Zuzzu);
		BanquetOrdersManager.instance.pauseOrders = false;
		BanquetRoundsManager.instance.StartRounds();
		BanquetDrinksManager.MGLJBGAHKML(OKMHACFGCPG: false);
		RefereeNPC.JFNOOMJMHCB().DisableTalk(CAPPDENDLKP: true);
		if ((Object)(object)KlaynNPC.instance != (Object)null)
		{
			KlaynNPC.instance.playerCanInteract = false;
			KlaynNPC.instance.CheckIfNewActivity(OGECKNMAJMI: false, CDPAMNIPPEC: false);
			((Behaviour)KlaynNPC.instance.visualCollider).enabled = true;
		}
		((MonoBehaviour)this).StartCoroutine(PCBKKCEBDBM());
	}

	private static IEnumerator JMPGMIFIEDB()
	{
		yield return null;
		instance.StartChallenge();
	}

	public void DHFAENLLJCC(bool BINEPAAJCFD)
	{
		if (BINEPAAJCFD)
		{
			ILAKBPKFBDE();
		}
		else
		{
			CLGNJHNEJDI();
		}
	}

	public static void KBCPDJLMEPP(bool CHOPKHLMBIH = false, bool CDPAMNIPPEC = true)
	{
		if (OGMLEIFEELG == null)
		{
			OGMLEIFEELG = ((MonoBehaviour)GameManager.NJNFHEPLEHL()).StartCoroutine(NLCLJGNPBGB(CHOPKHLMBIH));
			if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
			{
				OnlineBanquetEventManager.instance.AOPAKBNDOKL(CHOPKHLMBIH);
			}
		}
	}

	private void FJBNGHEFLMD(bool HCOPJPMDEKP)
	{
		for (int i = 1; i < gameObjectsToActivate.Length; i += 0)
		{
			gameObjectsToActivate[i].SetActive(HCOPJPMDEKP);
		}
		for (int j = 1; j < gameObjectsToDeactivate.Length; j++)
		{
			gameObjectsToDeactivate[j].SetActive(!HCOPJPMDEKP);
		}
		if (Object.op_Implicit((Object)(object)SceneReferences.instance))
		{
			SceneReferences.instance.castleGardenNpcs.SetActive(HCOPJPMDEKP);
			SceneReferences.instance.castleGardenGuards.SetActive(!HCOPJPMDEKP);
			SceneReferences.instance.castleGardenPeacocks.SetActive(HCOPJPMDEKP);
		}
	}

	[SpecialName]
	public static void JPEBIDNDOLD(bool AODONKKHPBP)
	{
		if ((Object)(object)instance != (Object)null)
		{
			instance._klaynChallengeStarted = AODONKKHPBP;
		}
	}

	public IEnumerator CDLNNMNFEHI(bool CEAFHAIEOLB = true)
	{
		UnlockAchievements(CEAFHAIEOLB);
		ItemDatabaseAccessor.GetItem(1811).IPGBILAIAPG(CDPAMNIPPEC: true);
		yield return CommonReferences.wait1;
		RecipesManager.UnlockRecipeMaster(643, IBHGAMNNOHI: true, CDPAMNIPPEC: false);
		yield return CommonReferences.wait1;
		RecipesManager.UnlockRecipeMaster(644, IBHGAMNNOHI: true, CDPAMNIPPEC: false);
	}

	protected void PBMJLFIJNAF()
	{
		GameActionBarUI.Get(1).OpenUI();
		if (GameManager.LocalCoop())
		{
			GameActionBarUI.Get(2).OpenUI();
		}
		TavernManagerUI.ShowPermanentTavernInfo((MonoBehaviour)(object)instance);
		TavernManagerUI.ShowClockAndTavernInfo();
		MissionsManager.ShowObjectivesPanel();
	}

	public void ReturnToCastle()
	{
		if (OnlineManager.MasterOrOffline())
		{
			UnlockAchievements(CEAFHAIEOLB: true);
		}
		Replaying = false;
		ChallengesUI.AnyMinigameInProgress = false;
		ChallengeEndDialogueUI.instance.Initialize(SO_Challenges.ChallengeType.banquet, ChallengePointsSystem.IsAnyPlayerWinning(), ChallengePointsSystem.GetPlayerPoints((!OnlineManager.PlayingOnline()) ? 1 : OnlinePlayerDataManager.GetBedAssignedByPlayerNum(1)));
		ChallengeEndDialogueUI.instance.OpenUI();
	}

	public void HideUI()
	{
		GameActionBarUI.Get(1).CloseUI();
		if (GameManager.LocalCoop())
		{
			GameActionBarUI.Get(2).CloseUI();
		}
		TavernManagerUI.HideClockAndTavernInfo();
		TavernManagerUI.HidePermanentTavernInfo((MonoBehaviour)(object)instance);
		MissionsManager.HideObjectivesPanel();
	}

	public static void OOOIEFMGCNB(bool HCOPJPMDEKP)
	{
		((Component)SceneReferences.instance.banquetEventBounds).gameObject.SetActive(HCOPJPMDEKP);
		((Component)SceneReferences.instance.castleGardenBounds).gameObject.SetActive(HCOPJPMDEKP);
		GameManager.GGFJGHHHEJC.ReactivateCameraBounds();
	}

	private static IEnumerator LOKHBDFFHAJ()
	{
		TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.City, Location.CastleGarden).StartTravelZone(1);
		if (GameManager.LocalCoop())
		{
			TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.City, Location.CastleGarden).StartTravelZone(2);
		}
		while ((Object)(object)Utils.JGEPCPFJANP(Location.CastleGarden) == (Object)null)
		{
			yield return CommonReferences.wait01;
		}
	}

	private void IMJFJGIGIMD(int JIIGOACEIKL)
	{
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(PKHJAODDBMN));
		DeactivateEvent();
		FadeCamera.EIFPKCAFDIB(1).FadeIn(1137f);
		FadeCamera player2 = FadeCamera.GetPlayer(1);
		player2.OnFadeFinished = (Action<int>)Delegate.Combine(player2.OnFadeFinished, new Action<int>(NIBEFAMFLAL));
	}

	private void NIBEFAMFLAL(int JIIGOACEIKL)
	{
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(NIBEFAMFLAL));
		PlayerInputs.EnableKeyboardInputsAndMovement(1, (MonoBehaviour)(object)this);
	}

	private static IEnumerator PFNBAABGIFK()
	{
		yield return NLCLJGNPBGB(CHOPKHLMBIH: true);
		instance.ActivateEvent();
		yield return AMBHEIFLBKK();
		yield return CommonReferences.wait05;
		GameManager.GGFJGHHHEJC.ReactivateCameraBounds();
		instance.crowdNpcs.SetActive(true);
		instance.randomNpcs.SetActive(false);
		yield return instance.PCBKKCEBDBM();
	}

	public void ActivateEvent()
	{
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		HCOPJPMDEKP = true;
		if (Application.isPlaying)
		{
			ButtonsContext.GetPlayer(1).HideAgingRank();
			if (GameManager.LocalCoop())
			{
				ButtonsContext.GetPlayer(2).HideAgingRank();
			}
			collidersGameObject.SetActive(false);
			crowdNpcs.SetActive(false);
			randomNpcs.SetActive(true);
			if (OnlineManager.MasterOrOffline())
			{
				BanquetOrdersManager.StartCustomerOrders();
			}
			BanquetDrinksManager.BlockBarrelInteractions(OKMHACFGCPG: true);
			BanquetDrinksManager.instance.SetVisibleDrinkInBarrels(MDIKPGGBNLI: false);
			if ((Object)(object)KlaynNPC.instance == (Object)null)
			{
				Debug.LogError((object)"Klayn is null");
				return;
			}
			KlaynNPC.instance.content.SetActive(true);
			KlaynNPC.instance.playerCanInteract = true;
			((Component)KlaynNPC.instance).transform.position = klaynWaitingPosition.position;
			KlaynNPC.instance.ChangeState(KlaynState.WaitingToServe);
			KlaynNPC.instance.CheckIfNewActivity(OGECKNMAJMI: true, CDPAMNIPPEC: false);
		}
	}

	private void MDGLECECOIG()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
	}

	private static IEnumerator ELPECCJJELO()
	{
		MusicController.instance.FadeOutClip(2f, MMEHJCGGNFE: true);
		yield return CommonReferences.wait2;
		MusicController.instance.TriggerMusicTheme(27);
	}

	public static void TeleportPlayerToCastleGardenWithTravelZone()
	{
		TeleportPlayerToCastleGarden(CHOPKHLMBIH: false, CDPAMNIPPEC: false);
	}

	private void IJMLBAKKNHF()
	{
		if (!Application.isPlaying)
		{
			Debug.LogError((object)"StartEvent can only be called in play mode.");
			return;
		}
		_klaynChallengeStarted = false;
		collidersGameObject.SetActive(false);
		if (!Application.isEditor)
		{
			OnlineManager.OpenRoom();
		}
		WorldTime.JJICPIINBEH = false;
		PlayerInputs.RemovePlayer2Blocker((MonoBehaviour)(object)this);
		if ((Object)(object)RefereeNPC.GGFJGHHHEJC != (Object)null)
		{
			RefereeNPC.GGFJGHHHEJC.content.SetActive(false);
			RefereeNPC.GGFJGHHHEJC.DisableTalk(CAPPDENDLKP: false);
		}
		PBMJLFIJNAF();
		MissionsManager.PermanentHideObjectives(KJMAFOMIJNL: false);
		UnlockAchievements(CEAFHAIEOLB: true);
		ChallengePointsSystem.instance.ResetPoints();
		ChallengeEventPointsUI.instance.CloseUI();
		TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.CastleGarden, Location.City).UnblockTravelZone();
		TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.CastleGarden, Location.Castle).UnblockTravelZone();
		crowdNpcs.SetActive(false);
		randomNpcs.SetActive(true);
		BanquetRoundsManager.instance.StopRounds();
		BanquetOrdersManager.instance.pauseOrders = false;
		BanquetDrinksManager.BlockBarrelInteractions(OKMHACFGCPG: true);
		TavernManager.RemoveOpenTavernBlocker((MonoBehaviour)(object)this);
		if (Object.op_Implicit((Object)(object)PlayerController.GetPlayer(1)))
		{
			((Component)PlayerController.GetPlayer(1).hitDetection).gameObject.SetActive(false);
		}
		if ((Object)(object)KlaynNPC.instance != (Object)null)
		{
			KlaynNPC.instance.playerCanInteract = true;
			KlaynNPC.instance.ChangeState(KlaynState.WaitingToServe);
		}
		if (OnlineManager.MasterOrOffline() && (Object)(object)DogNPC.instance != (Object)null && Object.op_Implicit((Object)(object)DogNPC.instance.playerFollowing))
		{
			DogNPC.instance.dogAnimation.SetBool("Sit", EGFGNGJGBOP: false);
			DogNPC.instance.ChangeState(DogState.FollowPlayer);
		}
	}

	public static void HCEKMLIDMFG(bool CDPAMNIPPEC = true)
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)"in");
			return;
		}
		instance.PJNBDDHFIOJ();
		if (CDPAMNIPPEC && OnlineManager.PlayingOnline())
		{
			OnlineBanquetEventManager.instance.NBEGADEEHHO();
		}
	}
}
