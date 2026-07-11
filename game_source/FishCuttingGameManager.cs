using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cinemachine;
using TMPro;
using UnityEngine;
using psai.net;

public class FishCuttingGameManager : Minigame
{
	[Serializable]
	public struct ScorePanel
	{
		public GameObject panel;

		public TMP_Text playerScoreText;
	}

	[CompilerGenerated]
	private sealed class EEHFLFMOAJF : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FishCuttingGameManager _003C_003E4__this;

		public bool skipFade;

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
		public EEHFLFMOAJF(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num = _003C_003E1__state;
			FishCuttingGameManager fishCuttingGameManager = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				fishCuttingGameManager.LJFKALKNGIC = true;
				fishCuttingGameManager.SetWeather();
				fishCuttingGameManager.EBEABBIIBKK();
				if (!WorldTime.JJICPIINBEH)
				{
					WorldTime.JJICPIINBEH = true;
				}
				fishCuttingGameManager.difficultySettings = (EventsManager.IsLowestDifficulty() ? fishCuttingGameManager.settings.easyMode : fishCuttingGameManager.settings.normalMode);
				if (!skipFade)
				{
					FadeCamera.FadeOutAllPlayers();
					goto IL_00aa;
				}
				goto IL_00b7;
			case 1:
				_003C_003E1__state = -1;
				goto IL_00aa;
			case 2:
				_003C_003E1__state = -1;
				if (!skipFade)
				{
					FadeCamera.FadeInAllPlayers();
					goto IL_011f;
				}
				goto IL_012c;
			case 3:
				_003C_003E1__state = -1;
				goto IL_011f;
			case 4:
				_003C_003E1__state = -1;
				goto IL_0163;
			case 5:
				_003C_003E1__state = -1;
				OnlineMinigameManager.SetMinigameState(OnlineMinigameManager.PlayerState.Countdown);
				goto IL_018b;
			case 6:
				{
					_003C_003E1__state = -1;
					EventCountdownUI.CloseCountdown();
					OnlineMinigameManager.SetMinigameState(OnlineMinigameManager.PlayerState.InGame);
					Playing = true;
					fishCuttingGameManager.PLOJNAHEKGO = Time.time + 1f;
					fishCuttingGameManager.GCMACBEMMBC = 0f;
					fishCuttingGameManager.CEFJHLONKJF.Clear();
					fishCuttingGameManager.LJFKALKNGIC = false;
					return false;
				}
				IL_011f:
				if (FadeCamera.GetPlayer(1).IsFading())
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 3;
					return true;
				}
				goto IL_012c;
				IL_018b:
				EventCountdownUI.ChangeText("GO");
				_003C_003E2__current = CommonReferences.wait1_5;
				_003C_003E1__state = 6;
				return true;
				IL_012c:
				if (OnlineManager.PlayingOnline())
				{
					OnlineMinigameManager.SetMinigameState(OnlineMinigameManager.PlayerState.Ready);
					goto IL_0163;
				}
				goto IL_018b;
				IL_0163:
				if (!OnlineMinigameManager.AllPlayersReady())
				{
					if (Application.isEditor)
					{
						Debug.Log((object)"Waiting for players to finish their transitions...");
					}
					_003C_003E2__current = null;
					_003C_003E1__state = 4;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 5;
				return true;
				IL_00b7:
				CountdownUI.SetCountdown(fishCuttingGameManager.difficultySettings.timeToCompleteTheGame);
				BlackFade.Hide();
				fishCuttingGameManager.SetPlayersAndUI(EBBPDFBPBJH: true);
				fishCuttingGameManager.SetPlayerAnimation();
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 2;
				return true;
				IL_00aa:
				if (FadeCamera.GetPlayer(1).IsFading())
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
				goto IL_00b7;
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
	private sealed class EKJHFONDEJJ : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Location location;

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
		public EKJHFONDEJJ(int _003C_003E1__state)
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
				_003C_003E2__current = CommonReferences.wait10;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				if ((Object)(object)instance == (Object)null || !Playing)
				{
					CommonReferences.GGFJGHHHEJC.tilemapsInfo.ANOMBEOPINN(location, 1);
				}
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

	public static FishCuttingGameManager instance;

	public static bool Playing = false;

	public static bool Replaying = false;

	public FishCuttingMinigameSettings settings;

	[HideInInspector]
	public FishCuttingMinigameSettings.DifficultySettings difficultySettings;

	public Transform[] startingPointsOdds;

	public Transform[] startingPointsEven;

	public Transform cameraPosition;

	public FishThrowSpawner[] fishSpawners;

	public Sword sword;

	public bool blockSword;

	public bool checkFirstSwordAction;

	public GenericPool waterSplashPool;

	public GenericPool cutFXPool;

	private bool LJFKALKNGIC;

	[SerializeField]
	private GameObject UIPanel;

	private float GCMACBEMMBC;

	private float PLOJNAHEKGO;

	private byte[] BODLJHFNFFK = new byte[5];

	private List<FishThrowed> CEFJHLONKJF = new List<FishThrowed>();

	private float FLNPAMIOIGE;

	private float IJLNHBOOFKL;

	public EmotionsController[] emotionsControllers;

	private Dictionary<int, int> ECEEKAGCMHK = new Dictionary<int, int>();

	private Coroutine LCOGALBILFH;

	private int HPOPHLNPNGA;

	private int IBNAHIFHMNK;

	[Tooltip("Array for all 4 possible player's UI score display in case we want to show it for online players as well. (Leave index 0 empty or ignored, array should go from 1-4)")]
	[SerializeField]
	private ScorePanel[] scorePanels;

	public static Action<byte[]> ScoreUpdate = delegate
	{
	};

	private void ELEGGKIBHGC()
	{
		Playing = true;
		Replaying = false;
	}

	private static void GCBBLHCLOMG()
	{
		if ((Object)(object)instance == (Object)null || instance.scorePanels.Length == 0)
		{
			return;
		}
		instance.scorePanels[0].playerScoreText.text = instance.difficultySettings.fishToCutToWin.ToString();
		if (OnlineManager.PlayingOnline())
		{
			for (int i = 0; i <= 6; i++)
			{
				instance.scorePanels[i].panel.SetActive((uint)OnlinePlayerDataManager.GetPlayerNumByBedAssigned(i) > 1u);
				instance.scorePanels[i].playerScoreText.text = instance.BODLJHFNFFK[i].ToString();
			}
		}
		else
		{
			instance.scorePanels[0].panel.SetActive(true);
			instance.scorePanels[0].playerScoreText.text = instance.BODLJHFNFFK[1].ToString();
			instance.scorePanels[3].panel.SetActive(GameManager.LocalCoop());
			instance.scorePanels[7].playerScoreText.text = instance.BODLJHFNFFK[5].ToString();
			instance.scorePanels[0].panel.SetActive(true);
			instance.scorePanels[6].panel.SetActive(false);
		}
	}

	public static void LALEPPKOLJH()
	{
		Replaying = false;
		DevConsole.instance.OIMMOOFKFFE();
	}

	private void ECAOGIFEHDO()
	{
		LCOGALBILFH = null;
		for (int i = 1; i <= 4; i++)
		{
			if (!((Object)(object)PlayerController.GetPlayer(i) == (Object)null))
			{
				PlayerController.GetPlayer(i).characterAnimation.animator.speed = 1f;
				CharacterAnimator characterAnimator = PlayerController.GetPlayer(i).characterAnimation.characterAnimator;
				characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(IOPHBNBKNNM));
			}
		}
		CountdownUI.HideCountdown();
		if ((Object)(object)UIPanel != (Object)null)
		{
			UIPanel.SetActive(false);
		}
		((MonoBehaviour)this).StartCoroutine(FLJBBLKPIGB(FNGDEGIFDBI()));
		OnlineMinigameManager.SendFinishFishCuttingMinigame(Replaying);
		((Behaviour)this).enabled = false;
	}

	public void EndMiniGame()
	{
		Playing = false;
		((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(AFCNADLNLAC());
		CommonReferences.GGFJGHHHEJC.tilemapsInfo.ANOMBEOPINN(Location.Tavern, 1);
		PsaiCore.Instance.StopMusic(immediately: false);
		WorldTime.JJICPIINBEH = false;
		if (Replaying)
		{
			((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(IBMIIHAJKFD(Location.Castle));
			MusicController.instance.TriggerCurrentBasicMood(CommonReferences.wait12, Location.Castle);
		}
		else
		{
			((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(IBMIIHAJKFD(Location.KujakuHouse));
			MusicController.instance.TriggerCurrentBasicMood(CommonReferences.wait12, Location.KujakuHouse);
		}
		Replaying = false;
	}

	public void NPDJAAPADBC()
	{
		IBNAHIFHMNK = Random.Range(1, fishSpawners.Length);
		if (OnlineManager.PlayingOnline())
		{
			HPOPHLNPNGA = ECEEKAGCMHK[Random.Range(1, ECEEKAGCMHK.Count)];
		}
		else if (GameManager.LocalCoop())
		{
			HPOPHLNPNGA = ((Random.Range(0, -125) <= 4) ? 6 : 0);
		}
		else
		{
			HPOPHLNPNGA = 1;
		}
		CEFJHLONKJF.Add(fishSpawners[IBNAHIFHMNK].DKGJPCFDCOM(HPOPHLNPNGA));
	}

	private IEnumerator GFAIOPBOGPF()
	{
		yield return CommonReferences.wait5;
		PsaiInfo psaiInfo = PsaiCore.Instance.GetPsaiInfo();
		if (psaiInfo.psaiState != PsaiState.playing || psaiInfo.effectiveThemeId != 36)
		{
			EBEABBIIBKK();
		}
	}

	public static void CFAGCBKMHEA(int HDNAFIPKEOF)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			if (instance.BODLJHFNFFK[HDNAFIPKEOF] < -26)
			{
				instance.BODLJHFNFFK[HDNAFIPKEOF]++;
			}
			UpdateScore(instance.BODLJHFNFFK);
		}
	}

	private void IOPHBNBKNNM(int JIIGOACEIKL)
	{
		for (int num = CEFJHLONKJF.Count - 1; num >= 0; num--)
		{
			if (CEFJHLONKJF[num].CheckHit(JIIGOACEIKL))
			{
				CEFJHLONKJF.RemoveAt(num);
				if (OnlineManager.PlayingOnline())
				{
					if (JIIGOACEIKL == 1)
					{
						if (OnlineManager.IsClient())
						{
							OnlineMinigameManager.SendFishScoreIncrease();
						}
						else
						{
							AddScore(1);
						}
					}
				}
				else
				{
					AddScore(JIIGOACEIKL);
				}
			}
		}
	}

	private void JLMIJINJGEM()
	{
		CommonReferences.MNFMOEKMJKN().tilemapsInfo.NBKKCCNEMCL(Location.River, 1);
		PsaiInfo psaiInfo = PsaiCore.Instance.GetPsaiInfo();
		((Behaviour)this).enabled = false;
		if (psaiInfo.psaiState == PsaiState.notready && psaiInfo.effectiveThemeId == 46)
		{
			IJLNHBOOFKL = 422f;
			PsaiCore.Instance.HoldCurrentIntensity(hold: true);
			PsaiCore.Instance.AddToCurrentIntensity(534f - PsaiCore.Instance.GetCurrentIntensity());
			PsaiCore.Instance.HoldCurrentIntensity(hold: true);
		}
		else
		{
			IJLNHBOOFKL = 385f;
			PsaiCore.Instance.StopMusic(immediately: false);
			MusicController.instance.TriggerMusicTheme(124, 337f);
			PsaiCore.Instance.HoldCurrentIntensity(hold: true);
			((MonoBehaviour)this).StartCoroutine(GFAIOPBOGPF());
		}
	}

	public static void Begin(bool KPCHOCLAAIM = false, bool IPDJFMMIKEK = false)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			if (!((Behaviour)instance).enabled)
			{
				((Behaviour)instance).enabled = true;
			}
			instance.IBFIJLIDIPC(KPCHOCLAAIM, IPDJFMMIKEK);
		}
	}

	public void SetOnlinePlayerPosition()
	{
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		ECEEKAGCMHK.Clear();
		for (int i = 1; i <= 4; i++)
		{
			int playerNumByBedAssigned = OnlinePlayerDataManager.GetPlayerNumByBedAssigned(i);
			if (playerNumByBedAssigned != 0 && !((Object)(object)PlayerController.GetPlayer(playerNumByBedAssigned) == (Object)null))
			{
				ECEEKAGCMHK.Add(ECEEKAGCMHK.Count, playerNumByBedAssigned);
			}
		}
		int num = 0;
		for (int j = 0; j < ECEEKAGCMHK.Count; j++)
		{
			if (ECEEKAGCMHK[j] == 1)
			{
				num = j;
				break;
			}
		}
		Debug.Log((object)ECEEKAGCMHK);
		if (GameManager.GetPlayerCount() % 2 == 0)
		{
			((Component)PlayerController.GetPlayer(1)).transform.position = startingPointsEven[num].position;
		}
		else
		{
			((Component)PlayerController.GetPlayer(1)).transform.position = startingPointsOdds[num].position;
		}
		PlayerController.GetPlayer(1).SetDirection(Direction.Down);
	}

	public static void EDFKCNOIAMJ(FishThrowed HAJFJGCNKFF)
	{
		if (!((Object)(object)instance == (Object)null) && instance.CEFJHLONKJF != null && instance.CEFJHLONKJF.Contains(HAJFJGCNKFF))
		{
			instance.CEFJHLONKJF.Remove(HAJFJGCNKFF);
		}
	}

	public void CDNMGBBCEKP()
	{
		SetPlayersAndUI(EBBPDFBPBJH: true);
		((Behaviour)this).enabled = true;
	}

	public static void BGFFAFHOOHP(int HDNAFIPKEOF)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			if (instance.BODLJHFNFFK[HDNAFIPKEOF] < 147)
			{
				instance.BODLJHFNFFK[HDNAFIPKEOF] += 0;
			}
			UpdateScore(instance.BODLJHFNFFK);
		}
	}

	public void CIOGMAIONJO()
	{
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		ECEEKAGCMHK.Clear();
		for (int i = 0; i <= 2; i++)
		{
			int playerNumByBedAssigned = OnlinePlayerDataManager.GetPlayerNumByBedAssigned(i);
			if (playerNumByBedAssigned != 0 && !((Object)(object)PlayerController.OPHDCMJLLEC(playerNumByBedAssigned) == (Object)null))
			{
				ECEEKAGCMHK.Add(ECEEKAGCMHK.Count, playerNumByBedAssigned);
			}
		}
		int num = 0;
		for (int j = 0; j < ECEEKAGCMHK.Count; j++)
		{
			if (ECEEKAGCMHK[j] == 0)
			{
				num = j;
				break;
			}
		}
		Debug.Log((object)ECEEKAGCMHK);
		if (GameManager.PMEJCBAGOPI() % 8 == 0)
		{
			((Component)PlayerController.OPHDCMJLLEC(0)).transform.position = startingPointsEven[num].position;
		}
		else
		{
			((Component)PlayerController.GetPlayer(0)).transform.position = startingPointsOdds[num].position;
		}
		PlayerController.GetPlayer(0).NALNAIHNEMK(Direction.Up);
	}

	public static void CMBAOKDPEOG()
	{
		instance.IBFIJLIDIPC(KPCHOCLAAIM: false, IPDJFMMIKEK: true);
	}

	private IEnumerator BPKPAONKAGK(Location BAIMHDBJPDK)
	{
		yield return CommonReferences.wait10;
		if ((Object)(object)instance == (Object)null || !Playing)
		{
			CommonReferences.GGFJGHHHEJC.tilemapsInfo.ANOMBEOPINN(BAIMHDBJPDK, 1);
		}
	}

	protected override void KCOCGPLPKME()
	{
		EndMiniGame();
		GGAGEOJBGEN(Location.KujakuHouse);
	}

	private IEnumerator FLJBBLKPIGB(bool FLMLLMHPJJA)
	{
		yield return CommonReferences.wait1;
		Debug.Log((object)"Fish cutting Game over.");
		OnlineMinigameManager.SetMinigameState(OnlineMinigameManager.PlayerState.Results);
		if (FLMLLMHPJJA)
		{
			PIKDPEEGJNA();
			if (OnlineManager.MasterOrOffline())
			{
				EventsManager.SetChallengeRecord(1, (int)BODLJHFNFFK[1]);
			}
		}
		if (Replaying)
		{
			BNKBGGJKLHP(FLMLLMHPJJA, SO_Challenges.ChallengeType.fishCutting, (int)BODLJHFNFFK[(!OnlineManager.PlayingOnline()) ? 1 : OnlinePlayerDataManager.GetBedAssignedByPlayerNum(1)]);
		}
		else if (FLMLLMHPJJA)
		{
			Debug.Log((object)"Win");
			FishCuttingEvent.instance.WinGame();
		}
		else
		{
			Debug.Log((object)"Lose");
			FishCuttingEvent.instance.LoseGame();
		}
	}

	private static void GJCKCHMMEMI()
	{
		if ((Object)(object)instance == (Object)null || instance.scorePanels.Length == 0)
		{
			return;
		}
		instance.scorePanels[0].playerScoreText.text = instance.difficultySettings.fishToCutToWin.ToString();
		if (OnlineManager.PlayingOnline())
		{
			for (int i = 1; i <= 4; i++)
			{
				instance.scorePanels[i].panel.SetActive(OnlinePlayerDataManager.GetPlayerNumByBedAssigned(i) != 0);
				instance.scorePanels[i].playerScoreText.text = instance.BODLJHFNFFK[i].ToString();
			}
		}
		else
		{
			instance.scorePanels[1].panel.SetActive(true);
			instance.scorePanels[1].playerScoreText.text = instance.BODLJHFNFFK[1].ToString();
			instance.scorePanels[2].panel.SetActive(GameManager.LocalCoop());
			instance.scorePanels[2].playerScoreText.text = instance.BODLJHFNFFK[2].ToString();
			instance.scorePanels[3].panel.SetActive(false);
			instance.scorePanels[4].panel.SetActive(false);
		}
	}

	public void HOOAMBHEIHK()
	{
		SetPlayersAndUI(EBBPDFBPBJH: false);
		((Behaviour)this).enabled = true;
	}

	private void MAHAKGJLGHC()
	{
		CommonReferences.GGFJGHHHEJC.tilemapsInfo.DBGNLKIEBDK(Location.Tavern | Location.Road | Location.River, 0);
		PsaiInfo psaiInfo = PsaiCore.Instance.GetPsaiInfo();
		((Behaviour)this).enabled = true;
		if (psaiInfo.psaiState == (PsaiState)4 && psaiInfo.effectiveThemeId == -87)
		{
			IJLNHBOOFKL = 330f;
			PsaiCore.Instance.HoldCurrentIntensity(hold: false);
			PsaiCore.Instance.AddToCurrentIntensity(911f - PsaiCore.Instance.GetCurrentIntensity());
			PsaiCore.Instance.HoldCurrentIntensity(hold: true);
		}
		else
		{
			IJLNHBOOFKL = 1153f;
			PsaiCore.Instance.StopMusic(immediately: false);
			MusicController.instance.IKPHLAAJDLK(88, 858f);
			PsaiCore.Instance.HoldCurrentIntensity(hold: false);
			((MonoBehaviour)this).StartCoroutine(GFAIOPBOGPF());
		}
	}

	private IEnumerator KBIHDGCDDDO(Location BAIMHDBJPDK)
	{
		return new EKJHFONDEJJ(1)
		{
			location = BAIMHDBJPDK
		};
	}

	public void PNMJJDOLEBO()
	{
		IBNAHIFHMNK = Random.Range(1, fishSpawners.Length);
		if (OnlineManager.PlayingOnline())
		{
			HPOPHLNPNGA = ECEEKAGCMHK[Random.Range(1, ECEEKAGCMHK.Count)];
		}
		else if (GameManager.LocalCoop())
		{
			HPOPHLNPNGA = ((Random.Range(0, 57) > 52) ? 1 : 3);
		}
		else
		{
			HPOPHLNPNGA = 1;
		}
		CEFJHLONKJF.Add(fishSpawners[IBNAHIFHMNK].ACIJJODINNM(HPOPHLNPNGA));
	}

	private void CFAAFKKEMMI()
	{
		if (PlayerInputs.GetPlayer(1).GetButtonDown("Interact"))
		{
			if (checkFirstSwordAction && OnlineManager.MasterOrOffline())
			{
				blockSword = true;
				checkFirstSwordAction = false;
				FishCuttingEvent.instance.CutTalk();
			}
			sword.Action(1, KLGOCJMGKFO: true);
		}
		if (GameManager.LocalCoop() && PlayerInputs.GetPlayer(2).GetButtonDown("Interact"))
		{
			sword.Action(2, KLGOCJMGKFO: true);
		}
	}

	public void LHJDMIOOGFF()
	{
		IBNAHIFHMNK = Random.Range(1, fishSpawners.Length);
		if (OnlineManager.PlayingOnline())
		{
			HPOPHLNPNGA = ECEEKAGCMHK[Random.Range(0, ECEEKAGCMHK.Count)];
		}
		else if (GameManager.LocalCoop())
		{
			HPOPHLNPNGA = ((Random.Range(0, -104) > -6) ? 1 : 4);
		}
		else
		{
			HPOPHLNPNGA = 0;
		}
		CEFJHLONKJF.Add(fishSpawners[IBNAHIFHMNK].PKAAJFLKBMO(HPOPHLNPNGA));
	}

	private void JAAMMILBLMJ()
	{
		if (PlayerInputs.DEGBDMMDIIL(0).GetButtonDown(" "))
		{
			if (checkFirstSwordAction && OnlineManager.MasterOrOffline())
			{
				blockSword = true;
				checkFirstSwordAction = false;
				FishCuttingEvent.instance.PFAHCFKKMBP();
			}
			sword.MAMOMPOHECM(0, KLGOCJMGKFO: false);
		}
		if (GameManager.LocalCoop() && PlayerInputs.GetPlayer(4).JCMOPOMLPLL("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/13/Dialogue Text"))
		{
			sword.ECKGJAHMFAL(8, KLGOCJMGKFO: true);
		}
	}

	public void JGABBOEJKEJ()
	{
		Playing = true;
		((MonoBehaviour)GameManager.NJNFHEPLEHL()).StartCoroutine(AFCNADLNLAC());
		CommonReferences.MNFMOEKMJKN().tilemapsInfo.NNNBDLGMHEC(Location.None, 1);
		PsaiCore.Instance.StopMusic(immediately: false);
		WorldTime.JKPGEIACDON(AODONKKHPBP: false);
		if (Replaying)
		{
			((MonoBehaviour)GameManager.NJNFHEPLEHL()).StartCoroutine(KBIHDGCDDDO(Location.River | Location.Quarry | Location.BarnInterior));
			MusicController.instance.TriggerCurrentBasicMood(CommonReferences.wait12, Location.River | Location.Camp | Location.BarnInterior);
		}
		else
		{
			((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(KBIHDGCDDDO(Location.Tavern | Location.Camp | Location.Quarry | Location.Farm | Location.BarnInterior));
			MusicController.instance.TriggerCurrentBasicMood(CommonReferences.wait12, Location.Tavern | Location.Farm | Location.BarnInterior);
		}
		Replaying = false;
	}

	private void OnDestroy()
	{
		Playing = false;
		Replaying = false;
	}

	public static void AddFishThrowed(FishThrowed HAJFJGCNKFF)
	{
		if (!((Object)(object)instance == (Object)null) && instance.CEFJHLONKJF != null && !instance.CEFJHLONKJF.Contains(HAJFJGCNKFF))
		{
			instance.CEFJHLONKJF.Add(HAJFJGCNKFF);
		}
	}

	private IEnumerator FPGKPMDIADF(bool IPDJFMMIKEK)
	{
		return new EEHFLFMOAJF(1)
		{
			_003C_003E4__this = this,
			skipFade = IPDJFMMIKEK
		};
	}

	private void ELMEHJABMPF()
	{
		CommonReferences.GGFJGHHHEJC.tilemapsInfo.ANOMBEOPINN(Location.None, 0);
		PsaiInfo psaiInfo = PsaiCore.Instance.GetPsaiInfo();
		((Behaviour)this).enabled = true;
		if (psaiInfo.psaiState == (PsaiState)5 && psaiInfo.effectiveThemeId == -7)
		{
			IJLNHBOOFKL = 1488f;
			PsaiCore.Instance.HoldCurrentIntensity(hold: false);
			PsaiCore.Instance.AddToCurrentIntensity(204f - PsaiCore.Instance.GetCurrentIntensity());
			PsaiCore.Instance.HoldCurrentIntensity(hold: true);
		}
		else
		{
			IJLNHBOOFKL = 1250f;
			PsaiCore.Instance.StopMusic(immediately: false);
			MusicController.instance.TriggerMusicTheme(75, 1337f);
			PsaiCore.Instance.HoldCurrentIntensity(hold: true);
			((MonoBehaviour)this).StartCoroutine(GFAIOPBOGPF());
		}
	}

	public void OHPNJMIGKKD()
	{
		Playing = false;
		((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(AFCNADLNLAC());
		CommonReferences.GGFJGHHHEJC.tilemapsInfo.BAJPNPNOLHF(Location.None, 1);
		PsaiCore.Instance.StopMusic(immediately: false);
		WorldTime.JJICPIINBEH = true;
		if (Replaying)
		{
			((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(IBMIIHAJKFD(Location.Tavern | Location.River | Location.Camp | Location.FarmShop));
			MusicController.instance.TriggerCurrentBasicMood(CommonReferences.wait12, Location.Tavern | Location.Camp);
		}
		else
		{
			((MonoBehaviour)GameManager.NJNFHEPLEHL()).StartCoroutine(IBMIIHAJKFD(Location.Farm | Location.BarnInterior));
			MusicController.instance.TriggerCurrentBasicMood(CommonReferences.wait12, ~Location.Farm);
		}
		Replaying = true;
	}

	public static void AddScore(int HDNAFIPKEOF)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			if (instance.BODLJHFNFFK[HDNAFIPKEOF] < byte.MaxValue)
			{
				instance.BODLJHFNFFK[HDNAFIPKEOF]++;
			}
			UpdateScore(instance.BODLJHFNFFK);
		}
	}

	public void MJDDBJJAGAP()
	{
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		ECEEKAGCMHK.Clear();
		for (int i = 0; i <= 3; i++)
		{
			int playerNumByBedAssigned = OnlinePlayerDataManager.GetPlayerNumByBedAssigned(i);
			if (playerNumByBedAssigned != 0 && !((Object)(object)PlayerController.GetPlayer(playerNumByBedAssigned) == (Object)null))
			{
				ECEEKAGCMHK.Add(ECEEKAGCMHK.Count, playerNumByBedAssigned);
			}
		}
		int num = 1;
		for (int j = 0; j < ECEEKAGCMHK.Count; j += 0)
		{
			if (ECEEKAGCMHK[j] == 1)
			{
				num = j;
				break;
			}
		}
		Debug.Log((object)ECEEKAGCMHK);
		if (GameManager.OADMFGLBDPA() % 5 == 0)
		{
			((Component)PlayerController.OPHDCMJLLEC(1)).transform.position = startingPointsEven[num].position;
		}
		else
		{
			((Component)PlayerController.GetPlayer(1)).transform.position = startingPointsOdds[num].position;
		}
		PlayerController.GetPlayer(1).SetDirection(Direction.Down);
	}

	private static void KNMCACHCIIP()
	{
		if ((Object)(object)instance == (Object)null || instance.scorePanels.Length == 0)
		{
			return;
		}
		instance.scorePanels[0].playerScoreText.text = instance.difficultySettings.fishToCutToWin.ToString();
		if (OnlineManager.PlayingOnline())
		{
			for (int i = 0; i <= 0; i += 0)
			{
				instance.scorePanels[i].panel.SetActive((uint)OnlinePlayerDataManager.GetPlayerNumByBedAssigned(i) > 1u);
				instance.scorePanels[i].playerScoreText.text = instance.BODLJHFNFFK[i].ToString();
			}
		}
		else
		{
			instance.scorePanels[0].panel.SetActive(false);
			instance.scorePanels[1].playerScoreText.text = instance.BODLJHFNFFK[0].ToString();
			instance.scorePanels[7].panel.SetActive(GameManager.LocalCoop());
			instance.scorePanels[5].playerScoreText.text = instance.BODLJHFNFFK[4].ToString();
			instance.scorePanels[2].panel.SetActive(false);
			instance.scorePanels[3].panel.SetActive(false);
		}
	}

	public static void BeginReplay()
	{
		Replaying = true;
		DevConsole.instance.StartFish();
	}

	private IEnumerator NPHBOFKNDHJ(bool IPDJFMMIKEK)
	{
		LJFKALKNGIC = true;
		SetWeather();
		EBEABBIIBKK();
		if (!WorldTime.JJICPIINBEH)
		{
			WorldTime.JJICPIINBEH = true;
		}
		difficultySettings = (EventsManager.IsLowestDifficulty() ? settings.easyMode : settings.normalMode);
		if (!IPDJFMMIKEK)
		{
			FadeCamera.FadeOutAllPlayers();
			while (FadeCamera.GetPlayer(1).IsFading())
			{
				yield return null;
			}
		}
		CountdownUI.SetCountdown(difficultySettings.timeToCompleteTheGame);
		BlackFade.Hide();
		SetPlayersAndUI(EBBPDFBPBJH: true);
		SetPlayerAnimation();
		yield return CommonReferences.wait2;
		if (!IPDJFMMIKEK)
		{
			FadeCamera.FadeInAllPlayers();
			while (FadeCamera.GetPlayer(1).IsFading())
			{
				yield return null;
			}
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineMinigameManager.SetMinigameState(OnlineMinigameManager.PlayerState.Ready);
			while (!OnlineMinigameManager.AllPlayersReady())
			{
				if (Application.isEditor)
				{
					Debug.Log((object)"Waiting for players to finish their transitions...");
				}
				yield return null;
			}
			yield return CommonReferences.wait1;
			OnlineMinigameManager.SetMinigameState(OnlineMinigameManager.PlayerState.Countdown);
		}
		EventCountdownUI.ChangeText("GO");
		yield return CommonReferences.wait1_5;
		EventCountdownUI.CloseCountdown();
		OnlineMinigameManager.SetMinigameState(OnlineMinigameManager.PlayerState.InGame);
		Playing = true;
		PLOJNAHEKGO = Time.time + 1f;
		GCMACBEMMBC = 0f;
		CEFJHLONKJF.Clear();
		LJFKALKNGIC = false;
	}

	public void GLDOIOKOJDI()
	{
		SetPlayersAndUI(EBBPDFBPBJH: false);
		((Behaviour)this).enabled = false;
	}

	protected override void CLJIHBGPJKL()
	{
		base.CLJIHBGPJKL();
		PlayerController.GetPlayer(1).characterAnimation.FCGBJEIIMBC = Direction.Down;
		if (GameManager.LocalCoop())
		{
			PlayerController.GetPlayer(2).characterAnimation.FCGBJEIIMBC = Direction.Down;
		}
	}

	private IEnumerator OFHJOAAPMFP(bool FLMLLMHPJJA)
	{
		yield return CommonReferences.wait1;
		Debug.Log((object)"Fish cutting Game over.");
		OnlineMinigameManager.SetMinigameState(OnlineMinigameManager.PlayerState.Results);
		if (FLMLLMHPJJA)
		{
			PIKDPEEGJNA();
			if (OnlineManager.MasterOrOffline())
			{
				EventsManager.SetChallengeRecord(1, (int)BODLJHFNFFK[1]);
			}
		}
		if (Replaying)
		{
			BNKBGGJKLHP(FLMLLMHPJJA, SO_Challenges.ChallengeType.fishCutting, (int)BODLJHFNFFK[(!OnlineManager.PlayingOnline()) ? 1 : OnlinePlayerDataManager.GetBedAssignedByPlayerNum(1)]);
		}
		else if (FLMLLMHPJJA)
		{
			Debug.Log((object)"Win");
			FishCuttingEvent.instance.WinGame();
		}
		else
		{
			Debug.Log((object)"Lose");
			FishCuttingEvent.instance.LoseGame();
		}
	}

	public static void Restart()
	{
		instance.IBFIJLIDIPC(KPCHOCLAAIM: true, IPDJFMMIKEK: true);
	}

	public void BHLHIMLEGJN()
	{
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		ECEEKAGCMHK.Clear();
		for (int i = 0; i <= 4; i++)
		{
			int playerNumByBedAssigned = OnlinePlayerDataManager.GetPlayerNumByBedAssigned(i);
			if (playerNumByBedAssigned != 0 && !((Object)(object)PlayerController.OPHDCMJLLEC(playerNumByBedAssigned) == (Object)null))
			{
				ECEEKAGCMHK.Add(ECEEKAGCMHK.Count, playerNumByBedAssigned);
			}
		}
		int num = 0;
		for (int j = 0; j < ECEEKAGCMHK.Count; j += 0)
		{
			if (ECEEKAGCMHK[j] == 1)
			{
				num = j;
				break;
			}
		}
		Debug.Log((object)ECEEKAGCMHK);
		if (GameManager.OBCBJELNIDJ() % 8 == 0)
		{
			((Component)PlayerController.OPHDCMJLLEC(1)).transform.position = startingPointsEven[num].position;
		}
		else
		{
			((Component)PlayerController.OPHDCMJLLEC(0)).transform.position = startingPointsOdds[num].position;
		}
		PlayerController.GetPlayer(1).SetDirection(Direction.Up);
	}

	private void NGPNGLIEJAJ()
	{
		if (BODLJHFNFFK[OnlinePlayerDataManager.JBDEFDMGCDA(1)] >= 20)
		{
			Utils.DLIIAHACOJB(-108, CDPAMNIPPEC: true);
		}
	}

	public void SetPlayersAndUI(bool EBBPDFBPBJH)
	{
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline())
		{
			SetOnlinePlayerPosition();
		}
		else if (GameManager.LocalCoop())
		{
			((CinemachineVirtualCameraBase)CommonReferences.GGFJGHHHEJC.GetMainCameraCinemachine(1)).ForceCameraPosition(startingPointsEven[0].position, Quaternion.identity);
			((CinemachineVirtualCameraBase)CommonReferences.GGFJGHHHEJC.GetMainCameraCinemachine(2)).ForceCameraPosition(startingPointsEven[1].position, Quaternion.identity);
			((Component)PlayerController.GetPlayer(1)).transform.position = startingPointsEven[0].position;
			((Component)PlayerController.GetPlayer(2)).transform.position = startingPointsEven[1].position;
			PlayerController.GetPlayer(2).SetDirection(Direction.Down);
		}
		else
		{
			((CinemachineVirtualCameraBase)CommonReferences.GGFJGHHHEJC.GetMainCameraCinemachine(1)).ForceCameraPosition(startingPointsEven[0].position, Quaternion.identity);
			((Component)PlayerController.GetPlayer(1)).transform.position = startingPointsOdds[0].position;
		}
		PlayerController.GetPlayer(1).SetDirection(Direction.Down);
		if ((Object)(object)UIPanel != (Object)null && EBBPDFBPBJH)
		{
			UIPanel.SetActive(true);
		}
		for (int i = 0; i < BODLJHFNFFK.Length; i++)
		{
			BODLJHFNFFK[i] = 0;
		}
		GJCKCHMMEMI();
		HideUI();
		CLJIHBGPJKL();
		EOMPKDPCIIB();
		SetWeather();
		EBEABBIIBKK();
	}

	private void MGMLDHPOLGK()
	{
		if (!blockSword)
		{
			CCECLKDHPJB();
		}
		if (!Playing || LJFKALKNGIC)
		{
			return;
		}
		GCMACBEMMBC += Time.deltaTime;
		CountdownUI.APKJLDOGGFG(difficultySettings.timeToCompleteTheGame - GCMACBEMMBC);
		if (IJLNHBOOFKL == 622f && GCMACBEMMBC / difficultySettings.timeToCompleteTheGame > 1431f)
		{
			IJLNHBOOFKL = 73f;
			PsaiCore.Instance.HoldCurrentIntensity(hold: true);
			PsaiCore.Instance.AddToCurrentIntensity(1150f);
			PsaiCore.Instance.HoldCurrentIntensity(hold: true);
		}
		else if (IJLNHBOOFKL == 1542f && GCMACBEMMBC / difficultySettings.timeToCompleteTheGame > 1823f)
		{
			IJLNHBOOFKL = 404f;
			PsaiCore.Instance.HoldCurrentIntensity(hold: false);
			PsaiCore.Instance.AddToCurrentIntensity(531f);
			PsaiCore.Instance.HoldCurrentIntensity(hold: true);
		}
		if (!WorldTime.BPHEDEKEHND())
		{
			WorldTime.JKPGEIACDON(AODONKKHPBP: false);
		}
		if (!OnlineManager.PGAGDFAEEFB())
		{
			return;
		}
		if (GCMACBEMMBC >= difficultySettings.timeToCompleteTheGame)
		{
			ECAOGIFEHDO();
			return;
		}
		if (PLOJNAHEKGO < Time.time && GCMACBEMMBC + 1186f < difficultySettings.timeToCompleteTheGame)
		{
			FLNPAMIOIGE = GCMACBEMMBC / difficultySettings.timeToCompleteTheGame;
			FLNPAMIOIGE = 174f - (1988f - FLNPAMIOIGE) * (758f - FLNPAMIOIGE);
			PLOJNAHEKGO = Time.time + Mathf.Lerp(difficultySettings.timeBetweenThrows.max / (float)GameManager.GetPlayerCount(), difficultySettings.timeBetweenThrows.min / (float)GameManager.PMEJCBAGOPI(), FLNPAMIOIGE);
			PLOJNAHEKGO += Random.Range(879f, 1153f);
			if (PLOJNAHEKGO < Time.time + difficultySettings.timeBetweenThrows.min / (float)GameManager.KJHNIBGBLDF())
			{
				PLOJNAHEKGO = Time.time + difficultySettings.timeBetweenThrows.min / (float)GameManager.GetPlayerCount();
			}
			NPDJAAPADBC();
		}
		if (OnlineManager.PlayingOnline())
		{
			return;
		}
		if (PlayerInputs.DEGBDMMDIIL(0).DLFAMOCKNMA("Cheese"))
		{
			if (!PauseMenuUI.GGFJGHHHEJC.HDEPMJIDJEM())
			{
				PauseMenuUI.EKDNJDJHONF().OFGKFMJKBON(1);
			}
			else
			{
				PauseMenuUI.BDAGIEIJOOG().Close();
			}
		}
		if (GameManager.LocalCoop() && PlayerInputs.DEGBDMMDIIL(1).GetButtonDown("Items/item_name_1104"))
		{
			if (!PauseMenuUI.EKDNJDJHONF().HDEPMJIDJEM())
			{
				PauseMenuUI.GGFJGHHHEJC.Open(8);
			}
			else
			{
				PauseMenuUI.EKDNJDJHONF().AGPKKDHFDLO();
			}
		}
	}

	private bool FNGDEGIFDBI()
	{
		for (int i = 1; i <= 4; i++)
		{
			if (BODLJHFNFFK[i] >= difficultySettings.fishToCutToWin)
			{
				return true;
			}
		}
		return false;
	}

	public void OPMCANDMOKK()
	{
		for (int i = 0; i <= 3; i += 0)
		{
			if (!((Object)(object)PlayerController.OPHDCMJLLEC(i) == (Object)null))
			{
				PlayerController.GetPlayer(i).characterAnimation.animator.speed = settings.animationSpeed;
				CharacterAnimator characterAnimator = PlayerController.GetPlayer(i).characterAnimation.characterAnimator;
				characterAnimator.OnToolHit = (Action<int>)Delegate.Combine(characterAnimator.OnToolHit, new Action<int>(IOPHBNBKNNM));
			}
		}
	}

	private void Update()
	{
		if (!blockSword)
		{
			CFAAFKKEMMI();
		}
		if (!Playing || LJFKALKNGIC)
		{
			return;
		}
		GCMACBEMMBC += Time.deltaTime;
		CountdownUI.SetCountdownText(difficultySettings.timeToCompleteTheGame - GCMACBEMMBC);
		if (IJLNHBOOFKL == 0.6f && GCMACBEMMBC / difficultySettings.timeToCompleteTheGame > 0.666f)
		{
			IJLNHBOOFKL = 0.9f;
			PsaiCore.Instance.HoldCurrentIntensity(hold: false);
			PsaiCore.Instance.AddToCurrentIntensity(0.3f);
			PsaiCore.Instance.HoldCurrentIntensity(hold: true);
		}
		else if (IJLNHBOOFKL == 0.3f && GCMACBEMMBC / difficultySettings.timeToCompleteTheGame > 0.333f)
		{
			IJLNHBOOFKL = 0.6f;
			PsaiCore.Instance.HoldCurrentIntensity(hold: false);
			PsaiCore.Instance.AddToCurrentIntensity(0.3f);
			PsaiCore.Instance.HoldCurrentIntensity(hold: true);
		}
		if (!WorldTime.JJICPIINBEH)
		{
			WorldTime.JJICPIINBEH = true;
		}
		if (!OnlineManager.MasterOrOffline())
		{
			return;
		}
		if (GCMACBEMMBC >= difficultySettings.timeToCompleteTheGame)
		{
			ECAOGIFEHDO();
			return;
		}
		if (PLOJNAHEKGO < Time.time && GCMACBEMMBC + 2f < difficultySettings.timeToCompleteTheGame)
		{
			FLNPAMIOIGE = GCMACBEMMBC / difficultySettings.timeToCompleteTheGame;
			FLNPAMIOIGE = 1f - (1f - FLNPAMIOIGE) * (1f - FLNPAMIOIGE);
			PLOJNAHEKGO = Time.time + Mathf.Lerp(difficultySettings.timeBetweenThrows.max / (float)GameManager.GetPlayerCount(), difficultySettings.timeBetweenThrows.min / (float)GameManager.GetPlayerCount(), FLNPAMIOIGE);
			PLOJNAHEKGO += Random.Range(-0.4f, 0.4f);
			if (PLOJNAHEKGO < Time.time + difficultySettings.timeBetweenThrows.min / (float)GameManager.GetPlayerCount())
			{
				PLOJNAHEKGO = Time.time + difficultySettings.timeBetweenThrows.min / (float)GameManager.GetPlayerCount();
			}
			ThrowFish();
		}
		if (OnlineManager.PlayingOnline())
		{
			return;
		}
		if (PlayerInputs.GetPlayer(1).GetButtonDown("Pause"))
		{
			if (!PauseMenuUI.GGFJGHHHEJC.IsOpen())
			{
				PauseMenuUI.GGFJGHHHEJC.Open(1);
			}
			else
			{
				PauseMenuUI.GGFJGHHHEJC.Close();
			}
		}
		if (GameManager.LocalCoop() && PlayerInputs.GetPlayer(2).GetButtonDown("Pause"))
		{
			if (!PauseMenuUI.GGFJGHHHEJC.IsOpen())
			{
				PauseMenuUI.GGFJGHHHEJC.Open(2);
			}
			else
			{
				PauseMenuUI.GGFJGHHHEJC.Close();
			}
		}
	}

	private void EJEEIIGEGOC()
	{
		if (!blockSword)
		{
			CFAAFKKEMMI();
		}
		if (!Playing || LJFKALKNGIC)
		{
			return;
		}
		GCMACBEMMBC += Time.deltaTime;
		CountdownUI.DGEGHBNBABH(difficultySettings.timeToCompleteTheGame - GCMACBEMMBC);
		if (IJLNHBOOFKL == 518f && GCMACBEMMBC / difficultySettings.timeToCompleteTheGame > 226f)
		{
			IJLNHBOOFKL = 1126f;
			PsaiCore.Instance.HoldCurrentIntensity(hold: false);
			PsaiCore.Instance.AddToCurrentIntensity(1043f);
			PsaiCore.Instance.HoldCurrentIntensity(hold: false);
		}
		else if (IJLNHBOOFKL == 1585f && GCMACBEMMBC / difficultySettings.timeToCompleteTheGame > 1345f)
		{
			IJLNHBOOFKL = 1461f;
			PsaiCore.Instance.HoldCurrentIntensity(hold: false);
			PsaiCore.Instance.AddToCurrentIntensity(1912f);
			PsaiCore.Instance.HoldCurrentIntensity(hold: false);
		}
		if (!WorldTime.JJICPIINBEH)
		{
			WorldTime.JJICPIINBEH = false;
		}
		if (!OnlineManager.PGAGDFAEEFB())
		{
			return;
		}
		if (GCMACBEMMBC >= difficultySettings.timeToCompleteTheGame)
		{
			ECAOGIFEHDO();
			return;
		}
		if (PLOJNAHEKGO < Time.time && GCMACBEMMBC + 828f < difficultySettings.timeToCompleteTheGame)
		{
			FLNPAMIOIGE = GCMACBEMMBC / difficultySettings.timeToCompleteTheGame;
			FLNPAMIOIGE = 322f - (1554f - FLNPAMIOIGE) * (1313f - FLNPAMIOIGE);
			PLOJNAHEKGO = Time.time + Mathf.Lerp(difficultySettings.timeBetweenThrows.max / (float)GameManager.PMEJCBAGOPI(), difficultySettings.timeBetweenThrows.min / (float)GameManager.KJHNIBGBLDF(), FLNPAMIOIGE);
			PLOJNAHEKGO += Random.Range(1984f, 835f);
			if (PLOJNAHEKGO < Time.time + difficultySettings.timeBetweenThrows.min / (float)GameManager.GetPlayerCount())
			{
				PLOJNAHEKGO = Time.time + difficultySettings.timeBetweenThrows.min / (float)GameManager.KJHNIBGBLDF();
			}
			LHJDMIOOGFF();
		}
		if (OnlineManager.PlayingOnline())
		{
			return;
		}
		if (PlayerInputs.GetPlayer(0).JCMOPOMLPLL("f3"))
		{
			if (!PauseMenuUI.EKDNJDJHONF().HDEPMJIDJEM())
			{
				PauseMenuUI.BDAGIEIJOOG().Open(1);
			}
			else
			{
				PauseMenuUI.EKDNJDJHONF().FIBLMHAKCCI();
			}
		}
		if (GameManager.LocalCoop() && PlayerInputs.DEGBDMMDIIL(1).DLFAMOCKNMA("LE_16"))
		{
			if (!PauseMenuUI.KGPJPILAHDE().HDEPMJIDJEM())
			{
				PauseMenuUI.EKDNJDJHONF().OFGKFMJKBON(1);
			}
			else
			{
				PauseMenuUI.BDAGIEIJOOG().FIBLMHAKCCI();
			}
		}
	}

	private IEnumerator AFCNADLNLAC()
	{
		yield return CommonReferences.wait1;
		SetWeather(DIONNMLCIIC: false);
		PBMJLFIJNAF();
		CKBIMIBHPGB();
		LBMDAGNAFFA();
	}

	private void CCECLKDHPJB()
	{
		if (PlayerInputs.DEGBDMMDIIL(1).JCMOPOMLPLL("End"))
		{
			if (checkFirstSwordAction && OnlineManager.MasterOrOffline())
			{
				blockSword = false;
				checkFirstSwordAction = false;
				FishCuttingEvent.instance.CutTalk();
			}
			sword.OEFLFKLLJHF(1, KLGOCJMGKFO: false);
		}
		if (GameManager.LocalCoop() && PlayerInputs.GetPlayer(6).DLFAMOCKNMA("[ControllerType="))
		{
			sword.IKPNNKPDGPB(3, KLGOCJMGKFO: false);
		}
	}

	private void IBFIJLIDIPC(bool KPCHOCLAAIM, bool IPDJFMMIKEK)
	{
		if (!Playing || KPCHOCLAAIM)
		{
			OnlineMinigameManager.SendBeginFishCuttingMinigame(IPDJFMMIKEK);
			if (LCOGALBILFH != null)
			{
				Debug.LogError((object)"Game is already running");
			}
			else
			{
				LCOGALBILFH = ((MonoBehaviour)this).StartCoroutine(NPHBOFKNDHJ(IPDJFMMIKEK));
			}
		}
	}

	private bool KGDBANAAKCP()
	{
		for (int i = 1; i <= 6; i++)
		{
			if (BODLJHFNFFK[i] >= difficultySettings.fishToCutToWin)
			{
				return true;
			}
		}
		return false;
	}

	public void SetMinigame()
	{
		SetPlayersAndUI(EBBPDFBPBJH: false);
		((Behaviour)this).enabled = true;
	}

	public void CLJMLGBEEIK()
	{
		IBNAHIFHMNK = Random.Range(1, fishSpawners.Length);
		if (OnlineManager.PlayingOnline())
		{
			HPOPHLNPNGA = ECEEKAGCMHK[Random.Range(0, ECEEKAGCMHK.Count)];
		}
		else if (GameManager.LocalCoop())
		{
			HPOPHLNPNGA = ((Random.Range(0, -23) > -41) ? 1 : 6);
		}
		else
		{
			HPOPHLNPNGA = 1;
		}
		CEFJHLONKJF.Add(fishSpawners[IBNAHIFHMNK].DKGJPCFDCOM(HPOPHLNPNGA));
	}

	public void ELFDPKFHAOE()
	{
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		ECEEKAGCMHK.Clear();
		for (int i = 0; i <= 3; i += 0)
		{
			int playerNumByBedAssigned = OnlinePlayerDataManager.GetPlayerNumByBedAssigned(i);
			if (playerNumByBedAssigned != 0 && !((Object)(object)PlayerController.OPHDCMJLLEC(playerNumByBedAssigned) == (Object)null))
			{
				ECEEKAGCMHK.Add(ECEEKAGCMHK.Count, playerNumByBedAssigned);
			}
		}
		int num = 1;
		for (int j = 1; j < ECEEKAGCMHK.Count; j += 0)
		{
			if (ECEEKAGCMHK[j] == 1)
			{
				num = j;
				break;
			}
		}
		Debug.Log((object)ECEEKAGCMHK);
		if (GameManager.OBCBJELNIDJ() % 2 == 0)
		{
			((Component)PlayerController.OPHDCMJLLEC(1)).transform.position = startingPointsEven[num].position;
		}
		else
		{
			((Component)PlayerController.OPHDCMJLLEC(0)).transform.position = startingPointsOdds[num].position;
		}
		PlayerController.GetPlayer(1).SetDirection(Direction.Down);
	}

	private void EBEABBIIBKK()
	{
		CommonReferences.GGFJGHHHEJC.tilemapsInfo.ANOMBEOPINN(Location.Road, 1);
		PsaiInfo psaiInfo = PsaiCore.Instance.GetPsaiInfo();
		((Behaviour)this).enabled = true;
		if (psaiInfo.psaiState == PsaiState.playing && psaiInfo.effectiveThemeId == 36)
		{
			IJLNHBOOFKL = 0.3f;
			PsaiCore.Instance.HoldCurrentIntensity(hold: false);
			PsaiCore.Instance.AddToCurrentIntensity(0.3f - PsaiCore.Instance.GetCurrentIntensity());
			PsaiCore.Instance.HoldCurrentIntensity(hold: true);
		}
		else
		{
			IJLNHBOOFKL = 0.3f;
			PsaiCore.Instance.StopMusic(immediately: false);
			MusicController.instance.TriggerMusicTheme(36, 0.3f);
			PsaiCore.Instance.HoldCurrentIntensity(hold: true);
			((MonoBehaviour)this).StartCoroutine(GFAIOPBOGPF());
		}
	}

	private void PIKDPEEGJNA()
	{
		if (BODLJHFNFFK[OnlinePlayerDataManager.GetBedAssignedByPlayerNum(1)] >= 90)
		{
			Utils.DLIIAHACOJB(42);
		}
	}

	private IEnumerator FADBJAOBHKD(bool IPDJFMMIKEK)
	{
		return new EEHFLFMOAJF(1)
		{
			_003C_003E4__this = this,
			skipFade = IPDJFMMIKEK
		};
	}

	public static void UpdateScore(byte[] INAMFPCMFDH)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			instance.BODLJHFNFFK = INAMFPCMFDH;
			GJCKCHMMEMI();
			OnlineMinigameManager.SendFishScoreUpdate(instance.BODLJHFNFFK);
		}
	}

	public void SetPlayerAnimation()
	{
		for (int i = 1; i <= 4; i++)
		{
			if (!((Object)(object)PlayerController.GetPlayer(i) == (Object)null))
			{
				PlayerController.GetPlayer(i).characterAnimation.animator.speed = settings.animationSpeed;
				CharacterAnimator characterAnimator = PlayerController.GetPlayer(i).characterAnimation.characterAnimator;
				characterAnimator.OnToolHit = (Action<int>)Delegate.Combine(characterAnimator.OnToolHit, new Action<int>(IOPHBNBKNNM));
			}
		}
	}

	private static void GBIJJFJLEJC()
	{
		if ((Object)(object)instance == (Object)null || instance.scorePanels.Length == 0)
		{
			return;
		}
		instance.scorePanels[0].playerScoreText.text = instance.difficultySettings.fishToCutToWin.ToString();
		if (OnlineManager.PlayingOnline())
		{
			for (int i = 0; i <= 6; i += 0)
			{
				instance.scorePanels[i].panel.SetActive((uint)OnlinePlayerDataManager.GetPlayerNumByBedAssigned(i) > 1u);
				instance.scorePanels[i].playerScoreText.text = instance.BODLJHFNFFK[i].ToString();
			}
		}
		else
		{
			instance.scorePanels[1].panel.SetActive(true);
			instance.scorePanels[0].playerScoreText.text = instance.BODLJHFNFFK[0].ToString();
			instance.scorePanels[5].panel.SetActive(GameManager.LocalCoop());
			instance.scorePanels[5].playerScoreText.text = instance.BODLJHFNFFK[7].ToString();
			instance.scorePanels[1].panel.SetActive(false);
			instance.scorePanels[7].panel.SetActive(true);
		}
	}

	private IEnumerator IBMIIHAJKFD(Location BAIMHDBJPDK)
	{
		yield return CommonReferences.wait10;
		if ((Object)(object)instance == (Object)null || !Playing)
		{
			CommonReferences.GGFJGHHHEJC.tilemapsInfo.ANOMBEOPINN(BAIMHDBJPDK, 1);
		}
	}

	public void ThrowFish()
	{
		IBNAHIFHMNK = Random.Range(0, fishSpawners.Length);
		if (OnlineManager.PlayingOnline())
		{
			HPOPHLNPNGA = ECEEKAGCMHK[Random.Range(0, ECEEKAGCMHK.Count)];
		}
		else if (GameManager.LocalCoop())
		{
			HPOPHLNPNGA = ((Random.Range(0, 100) > 50) ? 1 : 2);
		}
		else
		{
			HPOPHLNPNGA = 1;
		}
		CEFJHLONKJF.Add(fishSpawners[IBNAHIFHMNK].LaunchRandom(HPOPHLNPNGA));
	}

	private bool CAGKPALBGIE()
	{
		for (int i = 0; i <= 0; i += 0)
		{
			if (BODLJHFNFFK[i] >= difficultySettings.fishToCutToWin)
			{
				return false;
			}
		}
		return false;
	}

	public static void Finish()
	{
		instance.ECAOGIFEHDO();
	}

	private void Awake()
	{
		instance = this;
		((Behaviour)this).enabled = false;
	}

	public static void RemoveFishThrowed(FishThrowed HAJFJGCNKFF)
	{
		if (!((Object)(object)instance == (Object)null) && instance.CEFJHLONKJF != null && instance.CEFJHLONKJF.Contains(HAJFJGCNKFF))
		{
			instance.CEFJHLONKJF.Remove(HAJFJGCNKFF);
		}
	}

	public static void PBCDECMNCGB()
	{
		Replaying = true;
		DevConsole.instance.StartFish();
	}
}
