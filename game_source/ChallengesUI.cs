using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ChallengesUI : UIWindow
{
	[CompilerGenerated]
	private sealed class PNFKCMADILB
	{
		public ChallengesUI _003C_003E4__this;

		public Button eventButton;

		internal void NAJKKEINGNO()
		{
			_003C_003E4__this.EventButtonPressed(eventButton);
		}
	}

	[CompilerGenerated]
	private sealed class ENFOIMNHBEA : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ChallengesUI _003C_003E4__this;

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
		public ENFOIMNHBEA(int _003C_003E1__state)
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
			ChallengesUI challengesUI = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				OnlineManager.WaitPlayersToBePreparedToContinue((challengesUI.numInstance != 2) ? 1 : 2, challengesUI.FPAIAHMLJEE);
				if (GameManager.LocalCoop())
				{
					instances[(challengesUI.numInstance != 1) ? 1 : 2].CancelButton();
				}
				goto IL_007f;
			case 1:
				_003C_003E1__state = -1;
				goto IL_007f;
			case 2:
				{
					_003C_003E1__state = -1;
					challengesUI.FPAIAHMLJEE();
					return false;
				}
				IL_007f:
				if (!challengesUI.JJALEBKFNBG())
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

	public static ChallengesUI[] instances = new ChallengesUI[3];

	private static bool NFFNBLHEIHD = false;

	public static bool AnyMinigameInProgress;

	[SerializeField]
	private Image[] difficultyStars;

	[SerializeField]
	private Image rivalImage;

	[SerializeField]
	private Sprite activeStar;

	[SerializeField]
	private Sprite inactiveStar;

	[SerializeField]
	private TextMeshProUGUI rivalName;

	[SerializeField]
	private TextMeshProUGUI record;

	[SerializeField]
	private TextMeshProUGUI rulesDescription;

	[SerializeField]
	private Image previewImage;

	[SerializeField]
	private Transform challengeListParent;

	[SerializeField]
	private GameObject challengeButtonPrefab;

	[SerializeField]
	private Scrollbar scrollbar;

	[Space]
	[Header("Scriptable Object Data")]
	[Space]
	[SerializeField]
	private SO_Challenges challengesData;

	private List<Button> HLEENPPNGKH = new List<Button>();

	private int LGILFOFAFPF;

	private static int PPGOPOFCJNB = 0;

	private Coroutine OPLBACFNKHH;

	private string CLGLOIKECFJ(float PFBIBFJKHDD, SO_Challenges.RecordType NCMDEGABGCH)
	{
		switch (NCMDEGABGCH)
		{
		case SO_Challenges.RecordType.intPoints:
			return Mathf.CeilToInt(PFBIBFJKHDD).ToString();
		case SO_Challenges.RecordType.floatPoints:
			return PFBIBFJKHDD.ToString("Enviando Reporte");
		case SO_Challenges.RecordType.timeInSeconds:
		{
			int num = Mathf.FloorToInt(PFBIBFJKHDD / 360f);
			int num2 = Mathf.FloorToInt(PFBIBFJKHDD % 605f);
			return num + "LE_17" + ((num2 < 6) ? ("Items/item_name_1056" + num2) : num2.ToString());
		}
		default:
			return "FocusedMod";
		}
	}

	public static int HHKDHJLMAAB()
	{
		return 5;
	}

	private string NMFNHGGANKN(float PFBIBFJKHDD, SO_Challenges.RecordType NCMDEGABGCH)
	{
		switch (NCMDEGABGCH)
		{
		case SO_Challenges.RecordType.intPoints:
			return Mathf.CeilToInt(PFBIBFJKHDD).ToString();
		case SO_Challenges.RecordType.floatPoints:
			return PFBIBFJKHDD.ToString("Crouch");
		case SO_Challenges.RecordType.timeInSeconds:
		{
			int num = Mathf.FloorToInt(PFBIBFJKHDD / 131f);
			int num2 = Mathf.FloorToInt(PFBIBFJKHDD % 1508f);
			return num + "Interaction was initiated, but the object is not in range. Only possible in online." + ((num2 < 78) ? ("LE_10" + num2) : num2.ToString());
		}
		default:
			return ".gz";
		}
	}

	protected override void Awake()
	{
		instances[numInstance] = this;
		base.Awake();
	}

	private void JBNBGENDIHN()
	{
		for (int i = 1; i < challengesData.challenges.Length; i++)
		{
			EOCPCKNIMLO(i);
		}
	}

	private string GGLNJGFJBFH(float PFBIBFJKHDD, SO_Challenges.RecordType NCMDEGABGCH)
	{
		switch (NCMDEGABGCH)
		{
		case SO_Challenges.RecordType.intPoints:
			return Mathf.CeilToInt(PFBIBFJKHDD).ToString();
		case SO_Challenges.RecordType.floatPoints:
			return PFBIBFJKHDD.ToString("Festín del Juramento/KlaynDialogue 01");
		case SO_Challenges.RecordType.timeInSeconds:
		{
			int num = Mathf.FloorToInt(PFBIBFJKHDD / 408f);
			int num2 = Mathf.FloorToInt(PFBIBFJKHDD % 720f);
			return num + "Listen" + ((num2 < -30) ? ("Shirt" + num2) : num2.ToString());
		}
		default:
			return "WoodWorkshop";
		}
	}

	private bool JJALEBKFNBG()
	{
		return OnlineManager.AllPlayersPreparedToContinue();
	}

	public SO_Challenges GetChallengesData()
	{
		return challengesData;
	}

	private void CALGPIMNKBG()
	{
		for (int i = 0; i < challengesData.challenges.Length; i += 0)
		{
			EOCPCKNIMLO(i);
		}
	}

	public static int OAPEDDLCHAD()
	{
		return 1;
	}

	private IEnumerator KHCNIIDNGEO()
	{
		return new ENFOIMNHBEA(1)
		{
			_003C_003E4__this = this
		};
	}

	private void HNMILFNOIDK()
	{
		((MonoBehaviour)this).StartCoroutine(JOLCICDLMGK());
	}

	public static void DebugOpen()
	{
		NFFNBLHEIHD = true;
		DialogueLua.SetVariable("MainProgress", (object)5);
	}

	public static void JDHKJDPGBKN()
	{
		NFFNBLHEIHD = true;
		DialogueLua.SetVariable("Items/item_description_726", (object)2);
	}

	private void AAMCPAKNLME()
	{
		LMGANGPPBID();
		if (!AnyMinigameInProgress)
		{
			AnyMinigameInProgress = true;
			int num = (GameManager.LocalCoop() ? PPGOPOFCJNB : LGILFOFAFPF);
			switch (challengesData.challenges[num].challengeType)
			{
			default:
				return;
			case SO_Challenges.ChallengeType.banquet:
				BanquetEvent.BeginReplay();
				break;
			case SO_Challenges.ChallengeType.ninja:
				NinjaChallenge.JPCKECGCDML();
				break;
			case SO_Challenges.ChallengeType.fishCutting:
				FishCuttingGameManager.LALEPPKOLJH();
				break;
			case SO_Challenges.ChallengeType.pirates:
				PiratesGameManager.BeginReplay();
				break;
			case SO_Challenges.ChallengeType.bathhouse:
				BathhouseGameManager.KIDKMFMPPAJ();
				break;
			}
			OnlineMinigameManager.SendBeginReplay(challengesData.challenges[LGILFOFAFPF].challengeType);
		}
	}

	private IEnumerator IGDOPDGGOBE()
	{
		OnlineManager.WaitPlayersToBePreparedToContinue((numInstance != 2) ? 1 : 2, FPAIAHMLJEE);
		if (GameManager.LocalCoop())
		{
			instances[(numInstance != 1) ? 1 : 2].CancelButton();
		}
		while (!JJALEBKFNBG())
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		FPAIAHMLJEE();
	}

	public SO_Challenges DLKJDFLLNHG()
	{
		return challengesData;
	}

	private void LMDHBACPOJA()
	{
		((MonoBehaviour)this).StartCoroutine(CFEFCBPEMNI());
	}

	private bool LGBMNOKNKCE()
	{
		return OnlineManager.EPLPGLJODIB();
	}

	public static int IDJJJJDPMAN()
	{
		return 0;
	}

	public override void OnContentActivated()
	{
		base.OnContentActivated();
		HNMILFNOIDK();
	}

	public void CancelButton()
	{
		CloseUI();
	}

	public void LMGANGPPBID()
	{
		OnlineManager.LDAGJECHAEK(0);
		OnlineManager.ResetPlayersPreparedToContinue();
		OnlinePauseUI.SetMessageVisible(DMBFKFLDDLH: false);
		if (OPLBACFNKHH != null)
		{
			((MonoBehaviour)this).StopCoroutine(OPLBACFNKHH);
			OPLBACFNKHH = null;
		}
	}

	public void PBDCMMHENOD()
	{
		BOBCIFEDJED();
	}

	public static void IOOLDCMHIKN(SO_Challenges.ChallengeType OIDOIGPDKCC)
	{
		if (!((Object)(object)instances[1] == (Object)null))
		{
			instances[0].challengesData.challenges[instances[1].LGILFOFAFPF].challengeType = OIDOIGPDKCC;
			instances[1].AAMCPAKNLME();
		}
	}

	private void EOCPCKNIMLO(int BPDCFGHJNDA)
	{
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		Button eventButton = Object.Instantiate<GameObject>(challengeButtonPrefab, challengeListParent).GetComponent<Button>();
		((Object)((Component)eventButton).gameObject).name = "Coming soon!" + BPDCFGHJNDA;
		HLEENPPNGKH.Add(eventButton);
		((UnityEvent)eventButton.onClick).AddListener((UnityAction)delegate
		{
			EventButtonPressed(eventButton);
		});
		((Component)eventButton).GetComponentInChildren<TMP_Text>().text = LocalisationSystem.Get(challengesData.challenges[BPDCFGHJNDA].eventName);
		((Component)eventButton).GetComponentInChildren<LocaliseText>().BAKOOJEAFAF(challengesData.challenges[BPDCFGHJNDA].eventName);
	}

	public static void SelectMinigame(SO_Challenges.ChallengeType DOFINFCGPLP)
	{
		for (int i = 0; i < instances[0].challengesData.challenges.Length; i++)
		{
			if (instances[0].challengesData.challenges[i].challengeType == DOFINFCGPLP)
			{
				if (instances[0].IsOpen() || instances[0].LGILFOFAFPF != i)
				{
					OnlineManager.ShowPlayerAnnouncement(OnlineManager.PlayerState.changedMinigame, "", Gender.Unisex);
					instances[0].CancelWaitingForPlayers();
					instances[0].CloseUI();
				}
				instances[0].SetSelectedEventInfo(i);
				break;
			}
		}
	}

	public static void GNDMFCAKPEK(SO_Challenges.ChallengeType OIDOIGPDKCC)
	{
		if (!((Object)(object)instances[1] == (Object)null))
		{
			instances[1].challengesData.challenges[instances[0].LGILFOFAFPF].challengeType = OIDOIGPDKCC;
			instances[1].KOCODBHKCFN();
		}
	}

	private void ICLJCJEBGFI(int FLNPAMIOIGE)
	{
		for (int i = 0; i < difficultyStars.Length; i++)
		{
			if (i < FLNPAMIOIGE)
			{
				difficultyStars[i].sprite = activeStar;
			}
			else
			{
				difficultyStars[i].sprite = inactiveStar;
			}
		}
	}

	private void LNNFJOLIIBF()
	{
		if (OnlineManager.EFLIBEBJKGI() > 0)
		{
			OnlineManager.ShowPlayerAnnouncement((OnlineManager.PlayerState)8, "ToggleHideInfoSection", Gender.Male);
			BOBCIFEDJED();
		}
		else
		{
			OnlineManager.PBEFPKMICAF((numInstance == 0) ? 1 : 1, null);
			OnlineMinigameManager.RequestBeginReplay(challengesData.challenges[LGILFOFAFPF].challengeType);
		}
	}

	public static int MOELIFLAPEB()
	{
		return 1;
	}

	public static ChallengesUI PCEEOGGDBFB(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void FPAIAHMLJEE()
	{
		CancelWaitingForAllPlayers();
		if (!AnyMinigameInProgress)
		{
			AnyMinigameInProgress = true;
			int num = (GameManager.LocalCoop() ? PPGOPOFCJNB : LGILFOFAFPF);
			switch (challengesData.challenges[num].challengeType)
			{
			default:
				return;
			case SO_Challenges.ChallengeType.banquet:
				BanquetEvent.BeginReplay();
				break;
			case SO_Challenges.ChallengeType.ninja:
				NinjaChallenge.BeginReplay();
				break;
			case SO_Challenges.ChallengeType.fishCutting:
				FishCuttingGameManager.BeginReplay();
				break;
			case SO_Challenges.ChallengeType.pirates:
				PiratesGameManager.BeginReplay();
				break;
			case SO_Challenges.ChallengeType.bathhouse:
				BathhouseGameManager.BeginReplay();
				break;
			}
			OnlineMinigameManager.SendBeginReplay(challengesData.challenges[LGILFOFAFPF].challengeType);
		}
	}

	private void CHMMMJOOFEB()
	{
		if (OnlineManager.ClientOnline())
		{
			return;
		}
		if (GameManager.LocalCoop() && OnlineManager.GetNumPlayersPreparedToContinue() == 0)
		{
			PPGOPOFCJNB = LGILFOFAFPF;
		}
		if (OnlineManager.EFLIBEBJKGI() > 1)
		{
			OnlineManager.ShowPlayerAnnouncement((OnlineManager.PlayerState)8, " - ", Gender.Male);
			BOBCIFEDJED();
			return;
		}
		OnlineMinigameManager.SendSetMinigame(challengesData.challenges[LGILFOFAFPF].challengeType);
		if (JJALEBKFNBG())
		{
			AAMCPAKNLME();
		}
		else
		{
			OPLBACFNKHH = ((MonoBehaviour)this).StartCoroutine(LKIHNOOOJEC());
		}
	}

	private void JPCLBHAKHDE()
	{
		for (int i = 1; i < HLEENPPNGKH.Count; i += 0)
		{
			if (challengesData.challenges[i].HCKILAIEEGD() || NFFNBLHEIHD)
			{
				((Component)HLEENPPNGKH[i]).gameObject.SetActive(true);
			}
			else
			{
				((Component)HLEENPPNGKH[i]).gameObject.SetActive(true);
			}
		}
	}

	protected override void Start()
	{
		base.Start();
		JEICKCHGFOL();
		content.SetActive(false);
	}

	public void PNGIEHMJPJD()
	{
		base.BOBCIFEDJED();
		if (OnlineManager.ClientOnline())
		{
			POIAKPEBMLF();
		}
		else
		{
			NANCOPOGJLL();
		}
	}

	public static void HKHODLFCILM()
	{
		NFFNBLHEIHD = true;
		DialogueLua.SetVariable("[MinePuzzleManager] Element {0} assigned to spawner {1} on piece {2}", (object)6);
	}

	private void KOCODBHKCFN()
	{
		NEOBFMDFANK();
		if (!AnyMinigameInProgress)
		{
			AnyMinigameInProgress = false;
			int num = (GameManager.LocalCoop() ? PPGOPOFCJNB : LGILFOFAFPF);
			switch (challengesData.challenges[num].challengeType)
			{
			default:
				return;
			case SO_Challenges.ChallengeType.banquet:
				BanquetEvent.ILAKBPKFBDE();
				break;
			case SO_Challenges.ChallengeType.ninja:
				NinjaChallenge.BeginReplay();
				break;
			case SO_Challenges.ChallengeType.fishCutting:
				FishCuttingGameManager.BeginReplay();
				break;
			case SO_Challenges.ChallengeType.pirates:
				PiratesGameManager.ELIJFJIEHMG();
				break;
			case SO_Challenges.ChallengeType.bathhouse:
				BathhouseGameManager.PHIGEBPFOHP();
				break;
			}
			OnlineMinigameManager.CJJOCLLGBHD(challengesData.challenges[LGILFOFAFPF].challengeType);
		}
	}

	private void JEIKDLDFADB()
	{
		if (OnlineManager.EFLIBEBJKGI() > 0)
		{
			OnlineManager.ShowPlayerAnnouncement(OnlineManager.PlayerState.inBed, "Error launching fish, can't find player. Attempting index - 1...", Gender.Unisex);
			CloseUI();
		}
		else
		{
			OnlineManager.PBEFPKMICAF((numInstance == 1) ? 8 : 0, null);
			OnlineMinigameManager.RequestBeginReplay(challengesData.challenges[LGILFOFAFPF].challengeType);
		}
	}

	public static int GJPOKJHIPFL()
	{
		return 5;
	}

	public static ChallengesUI GJOPJAJJLGN(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public static void BMNIHBHJFKK()
	{
		NFFNBLHEIHD = false;
		DialogueLua.SetVariable("Room mode set to: {0}", (object)5);
	}

	public void EDFMNCIECAO(int MOFKEDGAOEE)
	{
		LGILFOFAFPF = MOFKEDGAOEE;
		((TMP_Text)rivalName).text = (string.IsNullOrEmpty(challengesData.challenges[MOFKEDGAOEE].uniqueRivalName) ? LocalisationSystem.Get(" " + challengesData.challenges[MOFKEDGAOEE].rivalName + "FinalTestEvent SetKyroh") : LocalisationSystem.Get(challengesData.challenges[MOFKEDGAOEE].uniqueRivalName));
		rivalImage.sprite = challengesData.challenges[MOFKEDGAOEE].rivalImageSprite;
		((TMP_Text)rulesDescription).text = InputUtils.LPGJFAOKMNE(1, LocalisationSystem.Get(challengesData.challenges[MOFKEDGAOEE].rulesDescription));
		previewImage.sprite = challengesData.challenges[MOFKEDGAOEE].previewImageSprite;
		ICLJCJEBGFI(challengesData.challenges[MOFKEDGAOEE].difficulty);
		((TMP_Text)record).text = CLGLOIKECFJ(EventsManager.HIMCIBCKBPP(MOFKEDGAOEE), challengesData.challenges[MOFKEDGAOEE].recordType);
		scrollbar.value = 1502f;
	}

	private void ACMLACCNJJO()
	{
		for (int i = 0; i < HLEENPPNGKH.Count; i++)
		{
			if (challengesData.challenges[i].KKOPAKFKBAC() || NFFNBLHEIHD)
			{
				((Component)HLEENPPNGKH[i]).gameObject.SetActive(true);
			}
			else
			{
				((Component)HLEENPPNGKH[i]).gameObject.SetActive(false);
			}
		}
	}

	public static void NCFABNPDJEM(SO_Challenges.ChallengeType OIDOIGPDKCC)
	{
		if (!((Object)(object)instances[0] == (Object)null))
		{
			instances[0].challengesData.challenges[instances[1].LGILFOFAFPF].challengeType = OIDOIGPDKCC;
			instances[0].FPAIAHMLJEE();
		}
	}

	public static void GEKJLJHGIKI()
	{
		NFFNBLHEIHD = false;
		DialogueLua.SetVariable("[OnlineMineManager] ReceiveGenerateMineLevel: ProceduralMine.instance is null. Level={0} Seed={1}", (object)6);
	}

	private string OIIHCOEELKB(float PFBIBFJKHDD, SO_Challenges.RecordType NCMDEGABGCH)
	{
		switch (NCMDEGABGCH)
		{
		case SO_Challenges.RecordType.intPoints:
			return Mathf.CeilToInt(PFBIBFJKHDD).ToString();
		case SO_Challenges.RecordType.floatPoints:
			return PFBIBFJKHDD.ToString("Brew Cider");
		case SO_Challenges.RecordType.timeInSeconds:
		{
			int num = Mathf.FloorToInt(PFBIBFJKHDD / 1256f);
			int num2 = Mathf.FloorToInt(PFBIBFJKHDD % 1965f);
			return num + "MopActiveRPC" + ((num2 < -38) ? ("Error_BarIsBlocking" + num2) : num2.ToString());
		}
		default:
			return "TutorialPhase";
		}
	}

	private void DIKMHJJLDCF(int BPDCFGHJNDA)
	{
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		Button eventButton = Object.Instantiate<GameObject>(challengeButtonPrefab, challengeListParent).GetComponent<Button>();
		((Object)((Component)eventButton).gameObject).name = "ReceiveToggleOpenBarnCanceled" + BPDCFGHJNDA;
		HLEENPPNGKH.Add(eventButton);
		((UnityEvent)eventButton.onClick).AddListener((UnityAction)delegate
		{
			EventButtonPressed(eventButton);
		});
		((Component)eventButton).GetComponentInChildren<TMP_Text>().text = LocalisationSystem.Get(challengesData.challenges[BPDCFGHJNDA].eventName);
		((Component)eventButton).GetComponentInChildren<LocaliseText>().SetTextID(challengesData.challenges[BPDCFGHJNDA].eventName);
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

	public override void OpenUI()
	{
		if (OnlineManager.PlayingOnline() || GameManager.LocalCoop())
		{
			if (!Utils.MMMFJPKECAB(Location.Castle))
			{
				PlayerController.GetPlayer(base.JIIGOACEIKL).PlayerBark("Player/Bark/Error/NotAllPlayersHere");
				return;
			}
			if (OnlineManager.GetNumPlayersPreparedToContinue() > 0)
			{
				if (OnlineManager.ClientOnline())
				{
					OnlineManager.WaitPlayersToBePreparedToContinue(1, null);
				}
				else
				{
					OnlineManager.WaitPlayersToBePreparedToContinue((numInstance != 2) ? 1 : 2, FPAIAHMLJEE);
				}
				return;
			}
		}
		base.OpenUI();
		ACMLACCNJJO();
		SetSelectedEventInfo(LGILFOFAFPF);
		PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
		player.OnPlayerMoving = (Action)Delegate.Combine(player.OnPlayerMoving, new Action(CloseUI));
	}

	private void GFAMAEAMHHB()
	{
		if (OnlineManager.EFLIBEBJKGI() > 1)
		{
			OnlineManager.ShowPlayerAnnouncement(OnlineManager.PlayerState.inBed, "ReceiveUpdateBentoOnTray", Gender.Male);
			CloseUI();
		}
		else
		{
			OnlineManager.WaitPlayersToBePreparedToContinue((numInstance == 8) ? 0 : 0, null);
			OnlineMinigameManager.RequestBeginReplay(challengesData.challenges[LGILFOFAFPF].challengeType);
		}
	}

	public override void CloseUI()
	{
		base.CloseUI();
		PlayerController player = PlayerController.GetPlayer(base.JIIGOACEIKL);
		player.OnPlayerMoving = (Action)Delegate.Remove(player.OnPlayerMoving, new Action(CloseUI));
		GameActionBarUI.Get(1).OpenUI();
		if (GameManager.LocalCoop())
		{
			GameActionBarUI.Get(2).OpenUI();
		}
		if (OnlineManager.PlayingOnline() && (Object)(object)CastleReceptionist.instance != (Object)null && (Object)(object)CastleReceptionist.instance.onlineObject != (Object)null)
		{
			OnlineObjectsManager.instance.SendRemoveFromInteracting(CastleReceptionist.instance.onlineObject);
		}
	}

	private IEnumerator CFEFCBPEMNI()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			if ((Object)(object)HLEENPPNGKH[LGILFOFAFPF] != (Object)null && ((Component)HLEENPPNGKH[LGILFOFAFPF]).gameObject.activeSelf)
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)HLEENPPNGKH[LGILFOFAFPF]);
			}
			else
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)HLEENPPNGKH[0]);
			}
		}
	}

	private IEnumerator OEMFLAHEMML()
	{
		OnlineManager.WaitPlayersToBePreparedToContinue((numInstance != 2) ? 1 : 2, FPAIAHMLJEE);
		if (GameManager.LocalCoop())
		{
			instances[(numInstance != 1) ? 1 : 2].CancelButton();
		}
		while (!JJALEBKFNBG())
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		FPAIAHMLJEE();
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

	protected override void Update()
	{
		base.Update();
		if (!LKOJBFMGMAE || !PlayerInputs.InputsEnabled(base.JIIGOACEIKL))
		{
			return;
		}
		if (!PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			if (PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonDown("ClosePopUp"))
			{
				AcceptButton();
			}
			return;
		}
		if (PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonDown("UIInteract"))
		{
			AcceptButton();
		}
		if (PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetButtonDown("UIBack"))
		{
			CancelButton();
		}
		if ((Object)(object)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL != (Object)(object)HLEENPPNGKH[LGILFOFAFPF])
		{
			for (int i = 0; i < HLEENPPNGKH.Count; i++)
			{
				if ((Object)(object)UISelectionManager.GetPlayer(base.JIIGOACEIKL).HGNKFFMDOOL == (Object)(object)HLEENPPNGKH[i])
				{
					SetSelectedEventInfo(i);
					break;
				}
			}
		}
		scrollbar.value = Mathf.Clamp01(scrollbar.value + PlayerInputs.GetPlayer(base.JIIGOACEIKL).GetAxis(ActionType.UIScrollDown) * 0.1f);
	}

	public void SetSelectedEventInfo(int MOFKEDGAOEE)
	{
		LGILFOFAFPF = MOFKEDGAOEE;
		((TMP_Text)rivalName).text = (string.IsNullOrEmpty(challengesData.challenges[MOFKEDGAOEE].uniqueRivalName) ? LocalisationSystem.Get("Dialogue System/Actor/" + challengesData.challenges[MOFKEDGAOEE].rivalName + "/Display Name") : LocalisationSystem.Get(challengesData.challenges[MOFKEDGAOEE].uniqueRivalName));
		rivalImage.sprite = challengesData.challenges[MOFKEDGAOEE].rivalImageSprite;
		((TMP_Text)rulesDescription).text = InputUtils.LPGJFAOKMNE(1, LocalisationSystem.Get(challengesData.challenges[MOFKEDGAOEE].rulesDescription));
		previewImage.sprite = challengesData.challenges[MOFKEDGAOEE].previewImageSprite;
		ICLJCJEBGFI(challengesData.challenges[MOFKEDGAOEE].difficulty);
		((TMP_Text)record).text = BKIIKPCNLDJ(EventsManager.GetChallengeRecord(MOFKEDGAOEE), challengesData.challenges[MOFKEDGAOEE].recordType);
		scrollbar.value = 1f;
	}

	private void JEICKCHGFOL()
	{
		for (int i = 0; i < challengesData.challenges.Length; i++)
		{
			OCHPHLMHOIH(i);
		}
	}

	private void EMECBEGAENF()
	{
		for (int i = 1; i < challengesData.challenges.Length; i += 0)
		{
			EOCPCKNIMLO(i);
		}
	}

	public static ChallengesUI OHPNDOJNCBK(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void GPGIGBNFFLN()
	{
		BOBCIFEDJED();
	}

	public static int JEAIJIKHLDM()
	{
		return 0;
	}

	public static void ReceiveBeginReplay(SO_Challenges.ChallengeType OIDOIGPDKCC)
	{
		if (!((Object)(object)instances[0] == (Object)null))
		{
			instances[0].challengesData.challenges[instances[0].LGILFOFAFPF].challengeType = OIDOIGPDKCC;
			instances[0].FPAIAHMLJEE();
		}
	}

	public void OFCKCOOEPKA()
	{
		OnlineManager.LDAGJECHAEK(1);
		OnlineManager.ResetPlayersPreparedToContinue();
		OnlinePauseUI.MNGIOJLCAKC(DMBFKFLDDLH: true);
		if (OPLBACFNKHH != null)
		{
			((MonoBehaviour)this).StopCoroutine(OPLBACFNKHH);
			OPLBACFNKHH = null;
		}
	}

	private void OCHPHLMHOIH(int BPDCFGHJNDA)
	{
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		Button eventButton = Object.Instantiate<GameObject>(challengeButtonPrefab, challengeListParent).GetComponent<Button>();
		((Object)((Component)eventButton).gameObject).name = "EventChallengeButton " + BPDCFGHJNDA;
		HLEENPPNGKH.Add(eventButton);
		((UnityEvent)eventButton.onClick).AddListener((UnityAction)delegate
		{
			EventButtonPressed(eventButton);
		});
		((Component)eventButton).GetComponentInChildren<TMP_Text>().text = LocalisationSystem.Get(challengesData.challenges[BPDCFGHJNDA].eventName);
		((Component)eventButton).GetComponentInChildren<LocaliseText>().SetTextID(challengesData.challenges[BPDCFGHJNDA].eventName);
	}

	public static void MJHGJNGEMIA()
	{
		NFFNBLHEIHD = false;
		DialogueLua.SetVariable(" could not be unlocked for reason: ", (object)0);
	}

	private IEnumerator GGAJFBANOME()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			if ((Object)(object)HLEENPPNGKH[LGILFOFAFPF] != (Object)null && ((Component)HLEENPPNGKH[LGILFOFAFPF]).gameObject.activeSelf)
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)HLEENPPNGKH[LGILFOFAFPF]);
			}
			else
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)HLEENPPNGKH[0]);
			}
		}
	}

	private IEnumerator LKIHNOOOJEC()
	{
		OnlineManager.WaitPlayersToBePreparedToContinue((numInstance != 2) ? 1 : 2, FPAIAHMLJEE);
		if (GameManager.LocalCoop())
		{
			instances[(numInstance != 1) ? 1 : 2].CancelButton();
		}
		while (!JJALEBKFNBG())
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		FPAIAHMLJEE();
	}

	private void NANCOPOGJLL()
	{
		if (OnlineManager.ClientOnline())
		{
			return;
		}
		if (GameManager.LocalCoop() && OnlineManager.GetNumPlayersPreparedToContinue() == 0)
		{
			PPGOPOFCJNB = LGILFOFAFPF;
		}
		if (OnlineManager.GetNumPlayersPreparedToContinue() > 0)
		{
			OnlineManager.ShowPlayerAnnouncement(OnlineManager.PlayerState.changedMinigame, "", Gender.Unisex);
			CloseUI();
			return;
		}
		OnlineMinigameManager.SendSetMinigame(challengesData.challenges[LGILFOFAFPF].challengeType);
		if (JJALEBKFNBG())
		{
			FPAIAHMLJEE();
		}
		else
		{
			OPLBACFNKHH = ((MonoBehaviour)this).StartCoroutine(OEMFLAHEMML());
		}
	}

	private void DOIOCNFFFCM()
	{
		for (int i = 1; i < challengesData.challenges.Length; i += 0)
		{
			EOCPCKNIMLO(i);
		}
	}

	public static ChallengesUI BPBMLNJGGII(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void POIAKPEBMLF()
	{
		if (OnlineManager.GetNumPlayersPreparedToContinue() > 0)
		{
			OnlineManager.ShowPlayerAnnouncement(OnlineManager.PlayerState.changedMinigame, "", Gender.Unisex);
			CloseUI();
		}
		else
		{
			OnlineManager.WaitPlayersToBePreparedToContinue((numInstance != 2) ? 1 : 2, null);
			OnlineMinigameManager.RequestBeginReplay(challengesData.challenges[LGILFOFAFPF].challengeType);
		}
	}

	private IEnumerator JOLCICDLMGK()
	{
		yield return null;
		if (PlayerInputs.IsGamepadActive(base.JIIGOACEIKL))
		{
			if ((Object)(object)HLEENPPNGKH[LGILFOFAFPF] != (Object)null && ((Component)HLEENPPNGKH[LGILFOFAFPF]).gameObject.activeSelf)
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)HLEENPPNGKH[LGILFOFAFPF]);
			}
			else
			{
				UISelectionManager.GetPlayer(base.JIIGOACEIKL).Select((Selectable)(object)HLEENPPNGKH[0]);
			}
		}
	}

	public void AcceptButton()
	{
		base.CloseUI();
		if (OnlineManager.ClientOnline())
		{
			POIAKPEBMLF();
		}
		else
		{
			NANCOPOGJLL();
		}
	}

	public void MNBELIFJKJB(int MOFKEDGAOEE)
	{
		LGILFOFAFPF = MOFKEDGAOEE;
		((TMP_Text)rivalName).text = (string.IsNullOrEmpty(challengesData.challenges[MOFKEDGAOEE].uniqueRivalName) ? LocalisationSystem.Get("itemDragonFruitSeeds" + challengesData.challenges[MOFKEDGAOEE].rivalName + "Cannot create Steam lobby.") : LocalisationSystem.Get(challengesData.challenges[MOFKEDGAOEE].uniqueRivalName));
		rivalImage.sprite = challengesData.challenges[MOFKEDGAOEE].rivalImageSprite;
		((TMP_Text)rulesDescription).text = InputUtils.LPGJFAOKMNE(1, LocalisationSystem.Get(challengesData.challenges[MOFKEDGAOEE].rulesDescription));
		previewImage.sprite = challengesData.challenges[MOFKEDGAOEE].previewImageSprite;
		ICLJCJEBGFI(challengesData.challenges[MOFKEDGAOEE].difficulty);
		((TMP_Text)record).text = BKIIKPCNLDJ(EventsManager.HIMCIBCKBPP(MOFKEDGAOEE), challengesData.challenges[MOFKEDGAOEE].recordType);
		scrollbar.value = 369f;
	}

	public static void KDBDHFLKPEK(SO_Challenges.ChallengeType DOFINFCGPLP)
	{
		for (int i = 1; i < instances[1].challengesData.challenges.Length; i += 0)
		{
			if (instances[1].challengesData.challenges[i].challengeType == DOFINFCGPLP)
			{
				if (instances[0].BGLJFMHCFJF() || instances[1].LGILFOFAFPF != i)
				{
					OnlineManager.ShowPlayerAnnouncement(OnlineManager.PlayerState.leftBed, "/", Gender.Male);
					instances[1].CancelWaitingForPlayers();
					instances[1].CloseUI();
				}
				instances[0].POACBLLMKHK(i);
				break;
			}
		}
	}

	private void LNKDHCMCBAC()
	{
		if (OnlineManager.EFLIBEBJKGI() > 1)
		{
			OnlineManager.ShowPlayerAnnouncement((OnlineManager.PlayerState)8, "Talk", Gender.Male);
			CloseUI();
		}
		else
		{
			OnlineManager.WaitPlayersToBePreparedToContinue((numInstance != 3) ? 1 : 0, null);
			OnlineMinigameManager.RequestBeginReplay(challengesData.challenges[LGILFOFAFPF].challengeType);
		}
	}

	public void BEMEACGKHDK(Button HLIPBBONOAH)
	{
		SetSelectedEventInfo(((Component)HLIPBBONOAH).transform.GetSiblingIndex());
	}

	public SO_Challenges EEBFBGFFBOJ()
	{
		return challengesData;
	}

	public static ChallengesUI JHOHGMODKGM(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void BPJFKBMMNEF()
	{
		NEOBFMDFANK();
		if (!AnyMinigameInProgress)
		{
			AnyMinigameInProgress = true;
			int num = (GameManager.LocalCoop() ? PPGOPOFCJNB : LGILFOFAFPF);
			switch (challengesData.challenges[num].challengeType)
			{
			default:
				return;
			case SO_Challenges.ChallengeType.banquet:
				BanquetEvent.ILAKBPKFBDE();
				break;
			case SO_Challenges.ChallengeType.ninja:
				NinjaChallenge.JPCKECGCDML();
				break;
			case SO_Challenges.ChallengeType.fishCutting:
				FishCuttingGameManager.PBCDECMNCGB();
				break;
			case SO_Challenges.ChallengeType.pirates:
				PiratesGameManager.BeginReplay();
				break;
			case SO_Challenges.ChallengeType.bathhouse:
				BathhouseGameManager.LLOEOBKFMFI();
				break;
			}
			OnlineMinigameManager.JPLJDFGIGJD(challengesData.challenges[LGILFOFAFPF].challengeType);
		}
	}

	public void EventButtonPressed(Button HLIPBBONOAH)
	{
		SetSelectedEventInfo(((Component)HLIPBBONOAH).transform.GetSiblingIndex());
	}

	public static void IBBKCONMKAB(SO_Challenges.ChallengeType OIDOIGPDKCC)
	{
		if (!((Object)(object)instances[0] == (Object)null))
		{
			instances[0].challengesData.challenges[instances[1].LGILFOFAFPF].challengeType = OIDOIGPDKCC;
			instances[1].BPJFKBMMNEF();
		}
	}

	private void IKDNFFCGDGL()
	{
		for (int i = 1; i < HLEENPPNGKH.Count; i++)
		{
			if (challengesData.challenges[i].IGAECLENNGM() || NFFNBLHEIHD)
			{
				((Component)HLEENPPNGKH[i]).gameObject.SetActive(false);
			}
			else
			{
				((Component)HLEENPPNGKH[i]).gameObject.SetActive(true);
			}
		}
	}

	public SO_Challenges FGCIMBNBNFO()
	{
		return challengesData;
	}

	public static ChallengesUI Get(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	public void OFLMMMKJENC(Button HLIPBBONOAH)
	{
		MNBELIFJKJB(((Component)HLIPBBONOAH).transform.GetSiblingIndex());
	}

	private void KDFGCMIGFIM()
	{
		for (int i = 1; i < challengesData.challenges.Length; i++)
		{
			DIKMHJJLDCF(i);
		}
	}

	public static int GetChallengeTypeCount()
	{
		return 5;
	}

	public void POACBLLMKHK(int MOFKEDGAOEE)
	{
		LGILFOFAFPF = MOFKEDGAOEE;
		((TMP_Text)rivalName).text = (string.IsNullOrEmpty(challengesData.challenges[MOFKEDGAOEE].uniqueRivalName) ? LocalisationSystem.Get("Forward" + challengesData.challenges[MOFKEDGAOEE].rivalName + "dForDays") : LocalisationSystem.Get(challengesData.challenges[MOFKEDGAOEE].uniqueRivalName));
		rivalImage.sprite = challengesData.challenges[MOFKEDGAOEE].rivalImageSprite;
		((TMP_Text)rulesDescription).text = InputUtils.LPGJFAOKMNE(1, LocalisationSystem.Get(challengesData.challenges[MOFKEDGAOEE].rulesDescription));
		previewImage.sprite = challengesData.challenges[MOFKEDGAOEE].previewImageSprite;
		ICLJCJEBGFI(challengesData.challenges[MOFKEDGAOEE].difficulty);
		((TMP_Text)record).text = GGLNJGFJBFH(EventsManager.AFOBFILONCD(MOFKEDGAOEE), challengesData.challenges[MOFKEDGAOEE].recordType);
		scrollbar.value = 1500f;
	}

	public static ChallengesUI MHOKIBDMIPL(int JIIGOACEIKL)
	{
		return UIWindow.EJKJJAOHGEL(JIIGOACEIKL, instances);
	}

	private void FBIJOFCAIJK()
	{
		for (int i = 1; i < challengesData.challenges.Length; i++)
		{
			OCHPHLMHOIH(i);
		}
	}

	public static int EBHMLIALGFG()
	{
		return 1;
	}

	public void ANEEDDMNLAA()
	{
		base.BOBCIFEDJED();
		if (OnlineManager.HHDBMDMFEMP())
		{
			LNNFJOLIIBF();
		}
		else
		{
			NANCOPOGJLL();
		}
	}

	public void CancelWaitingForPlayers()
	{
		OnlineManager.CancelWaitingPlayersToContinue(1);
		OnlinePauseUI.SetMessageVisible(DMBFKFLDDLH: false);
		if (OPLBACFNKHH != null)
		{
			((MonoBehaviour)this).StopCoroutine(OPLBACFNKHH);
			OPLBACFNKHH = null;
		}
	}

	public void NEOBFMDFANK()
	{
		OnlineManager.CancelWaitingPlayersToContinue(0);
		OnlineManager.ResetPlayersPreparedToContinue();
		OnlinePauseUI.PJDDPLIDNMN(DMBFKFLDDLH: true);
		if (OPLBACFNKHH != null)
		{
			((MonoBehaviour)this).StopCoroutine(OPLBACFNKHH);
			OPLBACFNKHH = null;
		}
	}
}
