using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ChallengeEndDialogueUI : UIWindow
{
	[CompilerGenerated]
	private sealed class LONIOAAAAMJ : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ChallengeEndDialogueUI _003C_003E4__this;

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
		public LONIOAAAAMJ(int _003C_003E1__state)
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
			ChallengeEndDialogueUI challengeEndDialogueUI = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				OnlineManager.WaitPlayersToBePreparedToContinue((challengeEndDialogueUI.numInstance != 2) ? 1 : 2, challengeEndDialogueUI.BeginRetry);
				goto IL_0060;
			case 1:
				_003C_003E1__state = -1;
				goto IL_0060;
			case 2:
				{
					_003C_003E1__state = -1;
					challengeEndDialogueUI.BeginRetry();
					return false;
				}
				IL_0060:
				if (!OnlineManager.AllPlayersPreparedToContinue())
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait2;
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

	[SerializeField]
	private Button retryButton;

	[SerializeField]
	private Button exitButton;

	[SerializeField]
	private GameObject noButtonGamepadSprite;

	private SO_Challenges.ChallengeType GMNPIMGLCKM;

	[SerializeField]
	private TextMeshProUGUI winOrLoseText;

	[SerializeField]
	private TextMeshProUGUI scoreText;

	[SerializeField]
	private TextMeshProUGUI recordText;

	public static ChallengeEndDialogueUI instance;

	private bool EOPFIKEDIGD;

	private Coroutine OPLBACFNKHH;

	public void DNNGLPLEEMJ(SO_Challenges.ChallengeType NJDLOMPBEMB, bool ACDPGJOHGBE, float BODLJHFNFFK)
	{
		GMNPIMGLCKM = NJDLOMPBEMB;
		((TMP_Text)winOrLoseText).text = InputUtils.LPGJFAOKMNE(1, LocalisationSystem.Get(ACDPGJOHGBE ? " " : "</color>"));
		((TMP_Text)scoreText).text = PJJIFNMEFFF(BODLJHFNFFK, ChallengesUI.instances[0].DLKJDFLLNHG().challenges[LMEIFIEHNFH(NJDLOMPBEMB)].recordType);
		((TMP_Text)recordText).text = GGLNJGFJBFH(EventsManager.PPCDICPHFEF(EAHOKOHAFLM(NJDLOMPBEMB)), ChallengesUI.instances[1].EEBFBGFFBOJ().challenges[BNOEJKCKEJB(NJDLOMPBEMB)].recordType);
	}

	public void Initialize(SO_Challenges.ChallengeType NJDLOMPBEMB, bool ACDPGJOHGBE, float BODLJHFNFFK)
	{
		GMNPIMGLCKM = NJDLOMPBEMB;
		((TMP_Text)winOrLoseText).text = InputUtils.LPGJFAOKMNE(1, LocalisationSystem.Get(ACDPGJOHGBE ? "Victory" : "You Lose"));
		((TMP_Text)scoreText).text = BKIIKPCNLDJ(BODLJHFNFFK, ChallengesUI.instances[0].GetChallengesData().challenges[BNOEJKCKEJB(NJDLOMPBEMB)].recordType);
		((TMP_Text)recordText).text = BKIIKPCNLDJ(EventsManager.GetChallengeRecord(BNOEJKCKEJB(NJDLOMPBEMB)), ChallengesUI.instances[0].GetChallengesData().challenges[BNOEJKCKEJB(NJDLOMPBEMB)].recordType);
	}

	public void CancelWaitingForAllPlayers()
	{
		OnlineManager.CancelWaitingPlayersToContinue(1);
		OnlineManager.ResetPlayersPreparedToContinue();
		OnlinePauseUI.SetMessageVisible(DMBFKFLDDLH: false);
		if (OPLBACFNKHH != null)
		{
			((MonoBehaviour)this).StopCoroutine(OPLBACFNKHH);
			OPLBACFNKHH = null;
		}
	}

	public void GFMIFFNJEMK(SO_Challenges.ChallengeType NJDLOMPBEMB, bool ACDPGJOHGBE, float BODLJHFNFFK)
	{
		GMNPIMGLCKM = NJDLOMPBEMB;
		((TMP_Text)winOrLoseText).text = InputUtils.LPGJFAOKMNE(0, LocalisationSystem.Get(ACDPGJOHGBE ? "ActionBar9" : "k"));
		((TMP_Text)scoreText).text = PJJIFNMEFFF(BODLJHFNFFK, ChallengesUI.instances[1].GetChallengesData().challenges[LMEIFIEHNFH(NJDLOMPBEMB)].recordType);
		((TMP_Text)recordText).text = BKIIKPCNLDJ(EventsManager.HIMCIBCKBPP(LMEIFIEHNFH(NJDLOMPBEMB)), ChallengesUI.instances[0].DLKJDFLLNHG().challenges[BNOEJKCKEJB(NJDLOMPBEMB)].recordType);
	}

	public void LMGANGPPBID()
	{
		OnlineManager.LDAGJECHAEK(1);
		OnlineManager.ResetPlayersPreparedToContinue();
		OnlinePauseUI.HENLOLPNGDH(DMBFKFLDDLH: true);
		if (OPLBACFNKHH != null)
		{
			((MonoBehaviour)this).StopCoroutine(OPLBACFNKHH);
			OPLBACFNKHH = null;
		}
	}

	private void LAKKHJGLJBM()
	{
		if (!OnlineManager.HHDBMDMFEMP())
		{
			if (!OnlineManager.PlayingOnline())
			{
				GKJGCENDLEI();
			}
			else if (OnlineManager.GetNumPlayersPreparedToContinue() == OnlineManager.ConnectedPlayerCount() - 1)
			{
				GKJGCENDLEI();
			}
			else
			{
				OPLBACFNKHH = ((MonoBehaviour)this).StartCoroutine(LFHFNNHHNMP());
			}
		}
	}

	public void OCAMGNJKLAP(SO_Challenges.ChallengeType NJDLOMPBEMB, bool ACDPGJOHGBE, float BODLJHFNFFK)
	{
		GMNPIMGLCKM = NJDLOMPBEMB;
		((TMP_Text)winOrLoseText).text = InputUtils.LPGJFAOKMNE(0, LocalisationSystem.Get(ACDPGJOHGBE ? "ReceiveActiveOrDisableCustomer" : "Null item in database: "));
		((TMP_Text)scoreText).text = PJJIFNMEFFF(BODLJHFNFFK, ChallengesUI.instances[1].EEBFBGFFBOJ().challenges[EAHOKOHAFLM(NJDLOMPBEMB)].recordType);
		((TMP_Text)recordText).text = BKIIKPCNLDJ(EventsManager.ONJOPGKIJLL(EAHOKOHAFLM(NJDLOMPBEMB)), ChallengesUI.instances[1].GetChallengesData().challenges[BNOEJKCKEJB(NJDLOMPBEMB)].recordType);
	}

	public override void OpenUI()
	{
		if (!IsOpen())
		{
			base.OpenUI();
			EOPFIKEDIGD = false;
			((Component)exitButton).gameObject.SetActive(true);
			if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
			{
				noButtonGamepadSprite.SetActive(true);
			}
			else
			{
				noButtonGamepadSprite.SetActive(false);
			}
			InputModuleBlocker.instance.inputModuleBlockers.Add((Object)(object)this);
			PlayerController.AddMovementBlocker((Object)(object)this);
			Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowOpen), HOMFPAFAOGD: true, null, null, 0.4f);
		}
	}

	private int LMEIFIEHNFH(SO_Challenges.ChallengeType NJDLOMPBEMB)
	{
		return NJDLOMPBEMB switch
		{
			SO_Challenges.ChallengeType.banquet => 1, 
			SO_Challenges.ChallengeType.fishCutting => 0, 
			SO_Challenges.ChallengeType.bathhouse => 3, 
			SO_Challenges.ChallengeType.pirates => 5, 
			SO_Challenges.ChallengeType.ninja => 1, 
			_ => (int)NJDLOMPBEMB, 
		};
	}

	private IEnumerator DNGHJLPBMEN()
	{
		OnlineManager.WaitPlayersToBePreparedToContinue((numInstance != 2) ? 1 : 2, BeginRetry);
		while (!OnlineManager.AllPlayersPreparedToContinue())
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		BeginRetry();
	}

	public void HGBCHJLPGIF(bool CDPAMNIPPEC = true)
	{
		CancelWaitingForAllPlayers();
		IBJCKJEBLCC(BINEPAAJCFD: false);
		if (CDPAMNIPPEC)
		{
			OnlineMinigameManager.SendCancelRetry();
		}
	}

	private void FCNBODDMPCD(bool BINEPAAJCFD)
	{
		switch (GMNPIMGLCKM)
		{
		case SO_Challenges.ChallengeType.banquet:
			BanquetEvent.instance.OnCloseChallengeEndDialogue(BINEPAAJCFD);
			break;
		case SO_Challenges.ChallengeType.pirates:
			PiratesGameManager.instance.OnCloseChallengeEndDialogue(BINEPAAJCFD, SO_Challenges.ChallengeType.pirates);
			break;
		case SO_Challenges.ChallengeType.fishCutting:
			FishCuttingGameManager.instance.OnCloseChallengeEndDialogue(BINEPAAJCFD, SO_Challenges.ChallengeType.fishCutting);
			break;
		case SO_Challenges.ChallengeType.bathhouse:
			BathhouseGameManager.instance.OnCloseChallengeEndDialogue(BINEPAAJCFD, SO_Challenges.ChallengeType.bathhouse);
			break;
		case SO_Challenges.ChallengeType.ninja:
			NinjaChallenge.instance.OnCloseChallengeEndDialogue(BINEPAAJCFD);
			break;
		}
	}

	private int EAHOKOHAFLM(SO_Challenges.ChallengeType NJDLOMPBEMB)
	{
		return NJDLOMPBEMB switch
		{
			SO_Challenges.ChallengeType.banquet => 1, 
			SO_Challenges.ChallengeType.fishCutting => 0, 
			SO_Challenges.ChallengeType.bathhouse => 6, 
			SO_Challenges.ChallengeType.pirates => 4, 
			SO_Challenges.ChallengeType.ninja => 2, 
			_ => (int)NJDLOMPBEMB, 
		};
	}

	public void BBEEJAJIAEB(bool BINEPAAJCFD)
	{
		if (!BINEPAAJCFD)
		{
			CancelRetry(CDPAMNIPPEC: false);
			return;
		}
		EOPFIKEDIGD = true;
		CloseUI();
		if (OnlineManager.ClientOnline())
		{
			NBFMAMHBFML();
		}
		else
		{
			NFGCHLJAGNM();
		}
	}

	private IEnumerator KHCNIIDNGEO()
	{
		OnlineManager.WaitPlayersToBePreparedToContinue((numInstance != 2) ? 1 : 2, BeginRetry);
		while (!OnlineManager.AllPlayersPreparedToContinue())
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		BeginRetry();
	}

	private void CPEAEPKFFDD()
	{
		OnlineManager.WaitPlayersToBePreparedToContinue((numInstance != 2) ? 1 : 2, null);
	}

	private int BNOEJKCKEJB(SO_Challenges.ChallengeType NJDLOMPBEMB)
	{
		return NJDLOMPBEMB switch
		{
			SO_Challenges.ChallengeType.banquet => 0, 
			SO_Challenges.ChallengeType.fishCutting => 1, 
			SO_Challenges.ChallengeType.bathhouse => 2, 
			SO_Challenges.ChallengeType.pirates => 3, 
			SO_Challenges.ChallengeType.ninja => 4, 
			_ => (int)NJDLOMPBEMB, 
		};
	}

	private IEnumerator KMOLHFPKJID()
	{
		return new LONIOAAAAMJ(1)
		{
			_003C_003E4__this = this
		};
	}

	private void NBFMAMHBFML()
	{
		OnlineManager.PBEFPKMICAF((numInstance == 3) ? 2 : 0, null);
	}

	public void GKJGCENDLEI()
	{
		LMGANGPPBID();
		LHLFJNMBPCG(BINEPAAJCFD: false);
		OnlineMinigameManager.SendBeginRetry(GMNPIMGLCKM);
	}

	public override void CloseUI()
	{
		if (IsOpen())
		{
			PlayerController.RemoveMovementBlocker((Object)(object)this);
			InputModuleBlocker.instance.inputModuleBlockers.Remove((Object)(object)this);
			base.CloseUI();
			if (!EOPFIKEDIGD)
			{
				RetryChallenge(BINEPAAJCFD: false);
			}
			Sound.GGFJGHHHEJC.PlayOneShotRandomPitch(Utils.CPDCJAHJOPE(Sound.GGFJGHHHEJC.uiWindowClose), HOMFPAFAOGD: true, null, null, 0.4f);
		}
	}

	public void CancelRetry(bool CDPAMNIPPEC = true)
	{
		CancelWaitingForAllPlayers();
		FCNBODDMPCD(BINEPAAJCFD: false);
		if (CDPAMNIPPEC)
		{
			OnlineMinigameManager.SendCancelRetry();
		}
	}

	private void IBJCKJEBLCC(bool BINEPAAJCFD)
	{
		switch (GMNPIMGLCKM)
		{
		case SO_Challenges.ChallengeType.banquet:
			BanquetEvent.instance.OnCloseChallengeEndDialogue(BINEPAAJCFD);
			break;
		case SO_Challenges.ChallengeType.pirates:
			PiratesGameManager.instance.OnCloseChallengeEndDialogue(BINEPAAJCFD, SO_Challenges.ChallengeType.banquet);
			break;
		case SO_Challenges.ChallengeType.fishCutting:
			FishCuttingGameManager.instance.OnCloseChallengeEndDialogue(BINEPAAJCFD, (SO_Challenges.ChallengeType)6);
			break;
		case SO_Challenges.ChallengeType.bathhouse:
			BathhouseGameManager.instance.OnCloseChallengeEndDialogue(BINEPAAJCFD, (SO_Challenges.ChallengeType)8);
			break;
		case SO_Challenges.ChallengeType.ninja:
			NinjaChallenge.instance.IBJCKJEBLCC(BINEPAAJCFD);
			break;
		}
	}

	private IEnumerator FAGMFPAHPID()
	{
		return new LONIOAAAAMJ(1)
		{
			_003C_003E4__this = this
		};
	}

	public void BeginRetry()
	{
		CancelWaitingForAllPlayers();
		FCNBODDMPCD(BINEPAAJCFD: true);
		OnlineMinigameManager.SendBeginRetry(GMNPIMGLCKM);
	}

	public void MEIDKNBMLEE(SO_Challenges.ChallengeType NJDLOMPBEMB, bool ACDPGJOHGBE, float BODLJHFNFFK)
	{
		GMNPIMGLCKM = NJDLOMPBEMB;
		((TMP_Text)winOrLoseText).text = InputUtils.LPGJFAOKMNE(1, LocalisationSystem.Get(ACDPGJOHGBE ? " from actor " : "ReceiveEventActor"));
		((TMP_Text)scoreText).text = BKIIKPCNLDJ(BODLJHFNFFK, ChallengesUI.instances[0].GetChallengesData().challenges[LMEIFIEHNFH(NJDLOMPBEMB)].recordType);
		((TMP_Text)recordText).text = BKIIKPCNLDJ(EventsManager.GetChallengeRecord(EAHOKOHAFLM(NJDLOMPBEMB)), ChallengesUI.instances[0].EEBFBGFFBOJ().challenges[BNOEJKCKEJB(NJDLOMPBEMB)].recordType);
	}

	private IEnumerator OEMFLAHEMML()
	{
		OnlineManager.WaitPlayersToBePreparedToContinue((numInstance != 2) ? 1 : 2, BeginRetry);
		while (!OnlineManager.AllPlayersPreparedToContinue())
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		BeginRetry();
	}

	private IEnumerator LFHFNNHHNMP()
	{
		OnlineManager.WaitPlayersToBePreparedToContinue((numInstance != 2) ? 1 : 2, BeginRetry);
		while (!OnlineManager.AllPlayersPreparedToContinue())
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		BeginRetry();
	}

	public void RetryChallenge(bool BINEPAAJCFD)
	{
		if (!BINEPAAJCFD)
		{
			CancelRetry();
			return;
		}
		EOPFIKEDIGD = true;
		CloseUI();
		if (OnlineManager.ClientOnline())
		{
			CPEAEPKFFDD();
		}
		else
		{
			NFGCHLJAGNM();
		}
	}

	private void NFGCHLJAGNM()
	{
		if (!OnlineManager.ClientOnline())
		{
			if (!OnlineManager.PlayingOnline())
			{
				BeginRetry();
			}
			else if (OnlineManager.GetNumPlayersPreparedToContinue() == OnlineManager.ConnectedPlayerCount() - 1)
			{
				BeginRetry();
			}
			else
			{
				OPLBACFNKHH = ((MonoBehaviour)this).StartCoroutine(OEMFLAHEMML());
			}
		}
	}

	protected override void Update()
	{
		if (!IsOpen())
		{
			return;
		}
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			if (PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonDown("UIInteract"))
			{
				((UnityEvent)retryButton.onClick).Invoke();
			}
			if (PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonDown("UIBack"))
			{
				((UnityEvent)exitButton.onClick).Invoke();
			}
		}
		else
		{
			if (PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonDown("ClosePopUp"))
			{
				((UnityEvent)retryButton.onClick).Invoke();
			}
			if (PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonDown("Pause"))
			{
				((UnityEvent)exitButton.onClick).Invoke();
			}
		}
	}

	private IEnumerator PACAMNOMANN()
	{
		OnlineManager.WaitPlayersToBePreparedToContinue((numInstance != 2) ? 1 : 2, BeginRetry);
		while (!OnlineManager.AllPlayersPreparedToContinue())
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		BeginRetry();
	}

	protected override void Awake()
	{
		instance = this;
		base.Awake();
	}

	private IEnumerator FGHJFEPGLNN()
	{
		OnlineManager.WaitPlayersToBePreparedToContinue((numInstance != 2) ? 1 : 2, BeginRetry);
		while (!OnlineManager.AllPlayersPreparedToContinue())
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		BeginRetry();
	}

	private string BKIIKPCNLDJ(float PFBIBFJKHDD, SO_Challenges.RecordType NCMDEGABGCH)
	{
		switch (NCMDEGABGCH)
		{
		case SO_Challenges.RecordType.intPoints:
			return Mathf.CeilToInt(PFBIBFJKHDD).ToString();
		case SO_Challenges.RecordType.floatPoints:
			return PFBIBFJKHDD.ToString("F1");
		case SO_Challenges.RecordType.timeInSeconds:
		{
			int num = Mathf.FloorToInt(PFBIBFJKHDD / 60f);
			int num2 = Mathf.FloorToInt(PFBIBFJKHDD % 60f);
			return num + ":" + ((num2 < 10) ? ("0" + num2) : num2.ToString());
		}
		default:
			return "";
		}
	}

	private string PJJIFNMEFFF(float PFBIBFJKHDD, SO_Challenges.RecordType NCMDEGABGCH)
	{
		switch (NCMDEGABGCH)
		{
		case SO_Challenges.RecordType.intPoints:
			return Mathf.CeilToInt(PFBIBFJKHDD).ToString();
		case SO_Challenges.RecordType.floatPoints:
			return PFBIBFJKHDD.ToString("Farm/Event/SwordVioletArthur");
		case SO_Challenges.RecordType.timeInSeconds:
		{
			int num = Mathf.FloorToInt(PFBIBFJKHDD / 1289f);
			int num2 = Mathf.FloorToInt(PFBIBFJKHDD % 1809f);
			return num + "OldMansDuelEvent OnTravelZoneTo" + ((num2 < 64) ? ("Items/item_name_1063" + num2) : num2.ToString());
		}
		default:
			return "LE_11";
		}
	}

	public void OKBHHNADNEA(bool BINEPAAJCFD)
	{
		if (!BINEPAAJCFD)
		{
			CancelRetry(CDPAMNIPPEC: false);
			return;
		}
		EOPFIKEDIGD = true;
		BOBCIFEDJED();
		if (OnlineManager.ClientOnline())
		{
			CGPDFMHKKBD();
		}
		else
		{
			LAKKHJGLJBM();
		}
	}

	public void ENPJHFLIALN(SO_Challenges.ChallengeType NJDLOMPBEMB, bool ACDPGJOHGBE, float BODLJHFNFFK)
	{
		GMNPIMGLCKM = NJDLOMPBEMB;
		((TMP_Text)winOrLoseText).text = InputUtils.LPGJFAOKMNE(1, LocalisationSystem.Get(ACDPGJOHGBE ? "Moving" : "StopMusic/ButtonEndSegment"));
		((TMP_Text)scoreText).text = GGLNJGFJBFH(BODLJHFNFFK, ChallengesUI.instances[1].EEBFBGFFBOJ().challenges[BNOEJKCKEJB(NJDLOMPBEMB)].recordType);
		((TMP_Text)recordText).text = PJJIFNMEFFF(EventsManager.HMKICLOHAGO(EAHOKOHAFLM(NJDLOMPBEMB)), ChallengesUI.instances[0].DLKJDFLLNHG().challenges[BNOEJKCKEJB(NJDLOMPBEMB)].recordType);
	}

	private string GGLNJGFJBFH(float PFBIBFJKHDD, SO_Challenges.RecordType NCMDEGABGCH)
	{
		switch (NCMDEGABGCH)
		{
		case SO_Challenges.RecordType.intPoints:
			return Mathf.CeilToInt(PFBIBFJKHDD).ToString();
		case SO_Challenges.RecordType.floatPoints:
			return PFBIBFJKHDD.ToString("NoEresDigno/KyrohTalks");
		case SO_Challenges.RecordType.timeInSeconds:
		{
			int num = Mathf.FloorToInt(PFBIBFJKHDD / 982f);
			int num2 = Mathf.FloorToInt(PFBIBFJKHDD % 332f);
			return num + "Farm/Event/Love" + ((num2 < 49) ? ("qualityWater2" + num2) : num2.ToString());
		}
		default:
			return "Dialogue System/Conversation/EnterTavernFood/Entry/5/Dialogue Text";
		}
	}

	private void CGPDFMHKKBD()
	{
		OnlineManager.PBEFPKMICAF((numInstance != 7) ? 1 : 4, null);
	}

	private void LHLFJNMBPCG(bool BINEPAAJCFD)
	{
		switch (GMNPIMGLCKM)
		{
		case SO_Challenges.ChallengeType.banquet:
			BanquetEvent.instance.DHFAENLLJCC(BINEPAAJCFD);
			break;
		case SO_Challenges.ChallengeType.pirates:
			PiratesGameManager.instance.OnCloseChallengeEndDialogue(BINEPAAJCFD, SO_Challenges.ChallengeType.banquet);
			break;
		case SO_Challenges.ChallengeType.fishCutting:
			FishCuttingGameManager.instance.OnCloseChallengeEndDialogue(BINEPAAJCFD, (SO_Challenges.ChallengeType)8);
			break;
		case SO_Challenges.ChallengeType.bathhouse:
			BathhouseGameManager.instance.OnCloseChallengeEndDialogue(BINEPAAJCFD, SO_Challenges.ChallengeType.banquet);
			break;
		case SO_Challenges.ChallengeType.ninja:
			NinjaChallenge.instance.IBJCKJEBLCC(BINEPAAJCFD);
			break;
		}
	}
}
