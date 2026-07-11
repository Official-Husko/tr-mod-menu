using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using I2.Loc;
using PixelCrushers.DialogueSystem;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Intro : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class IDBALKNIBKA : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Intro _003C_003E4__this;

		private float _003C_currentLerpTime_003E5__2;

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
		public IDBALKNIBKA(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			Intro intro = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_currentLerpTime_003E5__2 = 0f;
				break;
			case 1:
				_003C_003E1__state = -1;
				break;
			}
			if (_003C_currentLerpTime_003E5__2 < 8f)
			{
				_003C_currentLerpTime_003E5__2 += Time.deltaTime;
				float num2 = _003C_currentLerpTime_003E5__2 / 8f;
				for (int i = 0; i < intro.drunkEffectCharacters.Length; i++)
				{
					((Graphic)intro.drunkEffectCharacters[i]).color = new Color(1f, 1f, 1f, Mathf.Lerp(0f, 0.3f, num2));
				}
				((Graphic)intro.shadowDrunkEffect).color = new Color(1f, 1f, 1f, Mathf.Lerp(0f, 1f, num2));
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			}
			return false;
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
	private sealed class MCIHONOCMGJ : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Intro _003C_003E4__this;

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
		public MCIHONOCMGJ(int _003C_003E1__state)
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
			Intro intro = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				intro.AFMFHCAHEFO = 1f;
				intro.DBEFBFPAOAA = 0f;
				break;
			case 1:
				_003C_003E1__state = -1;
				break;
			}
			if (intro.DBEFBFPAOAA < intro.AFMFHCAHEFO)
			{
				intro.FNBKNIHOPNB(intro.blackScreen);
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			}
			intro.pauseMenuBlock = false;
			intro.NJGDKPLIAHG = false;
			intro.OMPPLBMNKJP();
			return false;
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
	private sealed class PPDINNLFBCN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Intro _003C_003E4__this;

		private float _003C_currentLerpTime_003E5__2;

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
		public PPDINNLFBCN(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			Intro intro = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_currentLerpTime_003E5__2 = 0f;
				break;
			case 1:
				_003C_003E1__state = -1;
				break;
			}
			if (_003C_currentLerpTime_003E5__2 < 0.5f)
			{
				_003C_currentLerpTime_003E5__2 += Time.deltaTime;
				intro.DCGBADKLANM = _003C_currentLerpTime_003E5__2 / 0.5f;
				intro.DCGBADKLANM = Mathf.Sin(intro.DCGBADKLANM * MathF.PI * 0.5f);
				intro.hand.anchoredPosition = new Vector2(intro.hand.anchoredPosition.x, Mathf.Lerp(50f, 0f, intro.DCGBADKLANM));
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			}
			return false;
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
	private sealed class HHBFFKKFOAH : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Intro _003C_003E4__this;

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
		public HHBFFKKFOAH(int _003C_003E1__state)
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
			Intro intro = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				intro.pauseMenuBlock = true;
				((Component)((Component)intro).transform.GetChild(0)).gameObject.SetActive(true);
				intro.blackScreen.alpha = 1f;
				intro.tavern.SetActive(true);
				intro.character.alpha = 0f;
				SceneReferences.GetSceneReferences().dialogueController.DialogueUI = (IDialogueUI)(object)SceneReferences.GetSceneReferences().dialogueUIIntro;
				MusicController.instance.PauseBasicMood(IEAALMNBABK: true);
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				intro.AFMFHCAHEFO = 2f;
				intro.DBEFBFPAOAA = 0f;
				goto IL_0135;
			case 2:
				_003C_003E1__state = -1;
				goto IL_0135;
			case 3:
				_003C_003E1__state = -1;
				MusicController.instance.TriggerMusicTheme(22);
				intro.NMDHAJEFNOB();
				intro.dialogue.conversation = "Intro/TavernAlone";
				intro.dialogue.OnUse();
				goto IL_01a9;
			case 4:
				_003C_003E1__state = -1;
				goto IL_01a9;
			case 5:
				_003C_003E1__state = -1;
				intro.AFMFHCAHEFO = 2f;
				intro.DBEFBFPAOAA = 0f;
				goto IL_0207;
			case 6:
				_003C_003E1__state = -1;
				goto IL_0207;
			case 7:
				_003C_003E1__state = -1;
				intro.dialogue.conversation = "Intro/FirstConversation";
				intro.dialogue.OnUse();
				goto IL_0264;
			case 8:
				_003C_003E1__state = -1;
				goto IL_0264;
			case 9:
				_003C_003E1__state = -1;
				goto IL_02a8;
			case 10:
				_003C_003E1__state = -1;
				goto IL_0457;
			case 11:
				_003C_003E1__state = -1;
				goto IL_044c;
			case 12:
				_003C_003E1__state = -1;
				goto IL_04c2;
			case 13:
				_003C_003E1__state = -1;
				goto IL_0516;
			case 14:
				_003C_003E1__state = -1;
				goto IL_055a;
			case 15:
				_003C_003E1__state = -1;
				goto IL_05c9;
			case 16:
				_003C_003E1__state = -1;
				goto IL_060d;
			case 17:
				_003C_003E1__state = -1;
				goto IL_060d;
			case 18:
				_003C_003E1__state = -1;
				intro.tavern.SetActive(true);
				intro.agreement.SetActive(false);
				intro.dialogue.conversation = "Intro/ThirdConversation";
				intro.dialogue.OnUse();
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 19;
				return true;
			case 19:
				_003C_003E1__state = -1;
				intro.ActivateDrunkEffect();
				break;
			case 20:
				{
					_003C_003E1__state = -1;
					break;
				}
				IL_060d:
				if (!PlayerInputs.GetPlayer(1).GetAnyButtonDown())
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 17;
					return true;
				}
				intro.sign.SetActive(true);
				MultiAudioManager.PlayAudioObject(intro.introStory.signature, ((Component)intro).transform);
				_003C_003E2__current = CommonReferences.wait2_5;
				_003C_003E1__state = 18;
				return true;
				IL_0264:
				if (!intro.scrollIntroStart)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 8;
					return true;
				}
				intro.AFMFHCAHEFO = 2f;
				intro.DBEFBFPAOAA = 0f;
				goto IL_02a8;
				IL_0135:
				if (intro.DBEFBFPAOAA < intro.AFMFHCAHEFO)
				{
					intro.DMNLFBAAMMK(intro.blackScreen);
					_003C_003E2__current = null;
					_003C_003E1__state = 2;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 3;
				return true;
				IL_02a8:
				if (intro.DBEFBFPAOAA < intro.AFMFHCAHEFO)
				{
					intro.FNBKNIHOPNB(intro.blackScreen);
					_003C_003E2__current = null;
					_003C_003E1__state = 9;
					return true;
				}
				intro.tavern.SetActive(false);
				intro.introStory.StartIntro();
				goto IL_044c;
				IL_044c:
				if (!intro.scrollIntroEnd)
				{
					if (PlayerInputs.GetPlayer(1).GetAnyButtonDown() && !((Component)intro.holdToSkip).gameObject.activeInHierarchy)
					{
						((Component)intro.holdToSkip).gameObject.SetActive(true);
						((TMP_Text)intro.holdToSkip).text = InputUtils.LPGJFAOKMNE(1, LocalizationManager.GetTranslation("HoldToSkip", true, 0, true, false, (GameObject)null, (string)null, true));
					}
					if (PlayerInputs.GetPlayer(1).GetButton(ActionType.Pause) || PlayerInputs.GetPlayer(1).GetButton(ActionType.UIBack) || PlayerInputs.GetPlayer(1).GetButton(ActionType.Cancel))
					{
						intro.LJAMOPAKFPL += Time.unscaledDeltaTime;
						if (intro.LJAMOPAKFPL > 2f)
						{
							intro.introStory.SkipIntro();
							((MonoBehaviour)intro).StartCoroutine(intro.IFEGBGMIBFJ());
							((MonoBehaviour)intro).StopCoroutine(intro.NAPOPPGIHJF);
							intro.LJAMOPAKFPL = 0f;
							_003C_003E2__current = null;
							_003C_003E1__state = 10;
							return true;
						}
					}
					else
					{
						if (intro.LJAMOPAKFPL != 0f)
						{
							intro.LJAMOPAKFPL = 0f;
						}
						if (((Component)intro.holdToSkip).gameObject.activeInHierarchy)
						{
							intro.OBIMGJCLPML += Time.unscaledDeltaTime;
							if (intro.OBIMGJCLPML > 5f)
							{
								((Component)intro.holdToSkip).gameObject.SetActive(false);
								((TMP_Text)intro.holdToSkip).text = "";
								intro.OBIMGJCLPML = 0f;
							}
						}
					}
					_003C_003E2__current = null;
					_003C_003E1__state = 11;
					return true;
				}
				goto IL_0457;
				IL_0457:
				if (((Component)intro.holdToSkip).gameObject.activeInHierarchy)
				{
					((Component)intro.holdToSkip).gameObject.SetActive(false);
				}
				intro.tavern.SetActive(true);
				intro.AFMFHCAHEFO = 2f;
				intro.DBEFBFPAOAA = 0f;
				goto IL_04c2;
				IL_0207:
				if (intro.DBEFBFPAOAA < intro.AFMFHCAHEFO)
				{
					intro.FNBKNIHOPNB(intro.character);
					_003C_003E2__current = null;
					_003C_003E1__state = 6;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 7;
				return true;
				IL_04c2:
				if (intro.DBEFBFPAOAA < intro.AFMFHCAHEFO)
				{
					intro.DMNLFBAAMMK(intro.blackScreen);
					_003C_003E2__current = null;
					_003C_003E1__state = 12;
					return true;
				}
				MusicController.instance.TriggerMusicTheme(22);
				intro.dialogue.conversation = "Intro/SecondConversation";
				intro.dialogue.OnUse();
				goto IL_0516;
				IL_0516:
				if (!intro.agreementStart)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 13;
					return true;
				}
				intro.AFMFHCAHEFO = 0.3f;
				intro.DBEFBFPAOAA = 0f;
				goto IL_055a;
				IL_055a:
				if (intro.DBEFBFPAOAA < intro.AFMFHCAHEFO)
				{
					intro.FNBKNIHOPNB(intro.blackScreen);
					_003C_003E2__current = null;
					_003C_003E1__state = 14;
					return true;
				}
				intro.tavern.SetActive(false);
				intro.agreement.SetActive(true);
				((MonoBehaviour)intro).StartCoroutine(intro.JKHFDJJCIML());
				intro.AFMFHCAHEFO = 0.3f;
				intro.DBEFBFPAOAA = 0f;
				goto IL_05c9;
				IL_01a9:
				if (!intro.characterShowsUp)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 4;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 5;
				return true;
				IL_05c9:
				if (intro.DBEFBFPAOAA < intro.AFMFHCAHEFO)
				{
					intro.DMNLFBAAMMK(intro.blackScreen);
					_003C_003E2__current = null;
					_003C_003E1__state = 15;
					return true;
				}
				_003C_003E2__current = CommonReferences.waitRealtime05;
				_003C_003E1__state = 16;
				return true;
			}
			if (!intro.introEnd)
			{
				_003C_003E2__current = null;
				_003C_003E1__state = 20;
				return true;
			}
			((MonoBehaviour)intro).StartCoroutine(intro.IFEGBGMIBFJ());
			return false;
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
	private sealed class GFGEEAGLPOA : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Intro _003C_003E4__this;

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
		public GFGEEAGLPOA(int _003C_003E1__state)
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
			Intro intro = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				NewTutorialManager.instance.AddAllSupplies();
				RecipesManager.GiveAllRecipesAvailable(EAANKCNNNJK: false);
				LettersManager.instance.lettersSaved = new List<PostBox.LetterSaveData>();
				LettersManager.instance.AddNewReceivedLetter(1000, LKAALEJKLPA: true, AJPCNKCBDEI: true, new GameDate(0, Season.Summer, 0, Day.Thurs, 0, 0));
				LettersManager.instance.AddNewReceivedLetter(1001, LKAALEJKLPA: true, AJPCNKCBDEI: true, new GameDate(0, Season.Autumn, 0, Day.Tue, 0, 0));
				LettersManager.instance.AddNewReceivedLetter(1002, LKAALEJKLPA: true, AJPCNKCBDEI: true, new GameDate(0, Season.Winter, 1, Day.Wed, 0, 0));
				LettersManager.instance.AddNewReceivedLetter(1003, LKAALEJKLPA: false, AJPCNKCBDEI: true, new GameDate(0, Season.Winter, 3, Day.Sun, 0, 0));
				intro.AFMFHCAHEFO = 2f;
				intro.DBEFBFPAOAA = 0f;
				goto IL_00f3;
			case 1:
				_003C_003E1__state = -1;
				goto IL_00f3;
			case 2:
				{
					_003C_003E1__state = -1;
					ChristmasEvent.instance.OnLoadingBarFinished();
					((Component)intro).gameObject.SetActive(false);
					if (GameManager.GGFJGHHHEJC.HEJPPEJMPFE == null)
					{
						CharacterCreatorUI.Get(1).firstStart = true;
						CharacterCreatorUI.Get(1).OpenUI();
					}
					NewTutorialManager.instance.ActivateTutorialObjects(DAEMAAOLHMG: true);
					MaiNPC.GGFJGHHHEJC.NoTutorialMaiDialogue();
					return false;
				}
				IL_00f3:
				if (intro.DBEFBFPAOAA < intro.AFMFHCAHEFO)
				{
					intro.DMNLFBAAMMK(intro.blackScreen);
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait1;
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

	[CompilerGenerated]
	private sealed class EPIPPINDBLO : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Intro _003C_003E4__this;

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
		public EPIPPINDBLO(int _003C_003E1__state)
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
			Intro intro = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				NewTutorialManager.instance.StartTutorial();
				intro.AFMFHCAHEFO = 2f;
				intro.DBEFBFPAOAA = 0f;
				goto IL_006e;
			case 1:
				_003C_003E1__state = -1;
				goto IL_006e;
			case 2:
				{
					_003C_003E1__state = -1;
					((Component)intro).gameObject.SetActive(false);
					return false;
				}
				IL_006e:
				if (intro.DBEFBFPAOAA < intro.AFMFHCAHEFO)
				{
					intro.DMNLFBAAMMK(intro.blackScreen);
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait1;
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

	public static Intro instance;

	public IntroStory introStory;

	public GameObject tavern;

	public GameObject agreement;

	public GameObject sign;

	public CanvasGroup character;

	public CanvasGroup blackScreen;

	public RectTransform hand;

	public DialogueSystemTrigger dialogue;

	public TextMeshProUGUI holdToSkip;

	public Image[] drunkEffectCharacters;

	public Image shadowDrunkEffect;

	public bool characterShowsUp;

	public bool scrollIntroStart;

	public bool scrollIntroEnd;

	public bool agreementStart;

	public bool agreementEnd;

	public bool introEnd;

	public bool pauseMenuBlock;

	private float AFMFHCAHEFO;

	private float DBEFBFPAOAA;

	private float DCGBADKLANM;

	private float LJAMOPAKFPL;

	private float OBIMGJCLPML;

	private Coroutine NAPOPPGIHJF;

	private bool NJGDKPLIAHG;

	public static void ConversationAloneEnd()
	{
		instance.characterShowsUp = true;
	}

	public static void DHPHFBKLAFD()
	{
		instance.introEnd = true;
	}

	protected virtual void JONELKAGNCA()
	{
		PlayerInputs.POBGMHINPHA(0, (MonoBehaviour)(object)this);
		PlayerController.RemoveMovementBlocker(0, (Object)(object)this);
		MusicController.instance.PauseBasicMood(IEAALMNBABK: false);
		CommonReferences.GGFJGHHHEJC.FLJBFMBMCII(1, MCOIFGJGFGF: false);
		GameActionBarUI.MGLNAMHAIDG(0).OpenUI();
		PlayerInputs.DEGBDMMDIIL(0).AMMIOLBGBPB("00");
		((Component)introStory).gameObject.SetActive(false);
		tavern.SetActive(false);
		agreement.SetActive(true);
		if (SaveUI.instance.tutorial)
		{
			((MonoBehaviour)this).StartCoroutine(PLFDDAOKJPD());
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(KNNEBELPKHF());
		}
	}

	public static void CEMOLLKLHLG()
	{
		instance.scrollIntroEnd = false;
	}

	private IEnumerator OCCIDGKIIAD()
	{
		NewTutorialManager.instance.StartTutorial();
		AFMFHCAHEFO = 2f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DMNLFBAAMMK(blackScreen);
			yield return null;
		}
		yield return CommonReferences.wait1;
		((Component)this).gameObject.SetActive(false);
	}

	public static void IJEMLEJEMJH()
	{
		instance.scrollIntroEnd = false;
	}

	private IEnumerator JKHFDJJCIML()
	{
		float _currentLerpTime = 0f;
		while (_currentLerpTime < 0.5f)
		{
			_currentLerpTime += Time.deltaTime;
			DCGBADKLANM = _currentLerpTime / 0.5f;
			DCGBADKLANM = Mathf.Sin(DCGBADKLANM * MathF.PI * 0.5f);
			hand.anchoredPosition = new Vector2(hand.anchoredPosition.x, Mathf.Lerp(50f, 0f, DCGBADKLANM));
			yield return null;
		}
	}

	private IEnumerator MCOICCFFANP()
	{
		return new GFGEEAGLPOA(1)
		{
			_003C_003E4__this = this
		};
	}

	private void GOJKOBEEMNA()
	{
		instance = this;
	}

	protected virtual void CDCHOMKPPAG()
	{
		PlayerInputs.DEPNDGJDKOL(1, (MonoBehaviour)(object)this);
		PlayerController.RemoveMovementBlocker(0, (Object)(object)this);
		MusicController.instance.HELAEMKFJBE(IEAALMNBABK: false);
		CommonReferences.MNFMOEKMJKN().AODJGCKEPCO(0, MCOIFGJGFGF: true);
		GameActionBarUI.PPDMGBACONH(1).IDLAGJNLPJL();
		PlayerInputs.GetPlayer(1).SwitchMapCategoryNextFrame("ReceiveSetUniqueCropDay");
		((Component)introStory).gameObject.SetActive(true);
		tavern.SetActive(false);
		agreement.SetActive(true);
		if (SaveUI.instance.tutorial)
		{
			((MonoBehaviour)this).StartCoroutine(HMGJBCILDBI());
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(HPJLEOFLNCK());
		}
	}

	private IEnumerator HEHCPDOOCFM()
	{
		return new MCIHONOCMGJ(1)
		{
			_003C_003E4__this = this
		};
	}

	private void HEMAHKJEONA()
	{
		instance = this;
	}

	private IEnumerator HMGJBCILDBI()
	{
		return new EPIPPINDBLO(1)
		{
			_003C_003E4__this = this
		};
	}

	private void BLNODLLKHHN(CanvasGroup BBLAIJKECPF)
	{
		DBEFBFPAOAA += Time.deltaTime;
		DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
		if (DCGBADKLANM > 627f)
		{
			DCGBADKLANM = 862f;
		}
		BBLAIJKECPF.alpha = Mathf.Lerp(1866f, 738f, DCGBADKLANM);
	}

	public static void OMKMIPEHCGB()
	{
		instance.agreementEnd = false;
	}

	private void DMNLFBAAMMK(CanvasGroup BBLAIJKECPF)
	{
		DBEFBFPAOAA += Time.deltaTime;
		DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
		if (DCGBADKLANM > 1f)
		{
			DCGBADKLANM = 1f;
		}
		BBLAIJKECPF.alpha = Mathf.Lerp(1f, 0f, DCGBADKLANM);
	}

	public static void OHLFLGFGENC()
	{
		instance.agreementStart = false;
	}

	private void GDIMBIKAOOE(CanvasGroup BBLAIJKECPF)
	{
		DBEFBFPAOAA += Time.deltaTime;
		DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
		if (DCGBADKLANM > 679f)
		{
			DCGBADKLANM = 1133f;
		}
		BBLAIJKECPF.alpha = DCGBADKLANM;
	}

	public void PAEKDOEDNCJ()
	{
		for (int i = 0; i < drunkEffectCharacters.Length; i++)
		{
			((Component)drunkEffectCharacters[i]).gameObject.SetActive(false);
		}
		((Component)shadowDrunkEffect).gameObject.SetActive(true);
		((MonoBehaviour)this).StartCoroutine(LCKGJNBBJPO());
	}

	public static void PIKJLLNCAOD()
	{
		instance.introEnd = false;
	}

	public static void OHIBEHMFBNM()
	{
		instance.agreementStart = true;
	}

	protected virtual void IGAMOIHIEKM()
	{
		CommonReferences.MNFMOEKMJKN().HPDOMEIJAJI(0, JGJCFHPMKGF: true);
		PlayerInputs.DisableKeyboardInputs(0, (MonoBehaviour)(object)this);
		PlayerController.AddMovementBlocker(0, (Object)(object)this, ANJCLPDCJHL: true);
		PlayerInputs.DEGBDMMDIIL(0).SwitchMapCategoryNextFrame("OpenTalents");
		GameActionBarUI.FHPEHDDFOIB(0).BOBCIFEDJED();
		CommonReferences.GGFJGHHHEJC.AODJGCKEPCO(0, MCOIFGJGFGF: true);
		ButtonsContext.GetPlayer(1).ResetButtons();
	}

	public static void ScrollIntroEnd()
	{
		instance.scrollIntroEnd = true;
	}

	private IEnumerator HDMOCLPBNBJ()
	{
		return new EPIPPINDBLO(1)
		{
			_003C_003E4__this = this
		};
	}

	private void OKEEMAGCBMN(CanvasGroup BBLAIJKECPF)
	{
		DBEFBFPAOAA += Time.deltaTime;
		DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
		if (DCGBADKLANM > 1558f)
		{
			DCGBADKLANM = 722f;
		}
		BBLAIJKECPF.alpha = DCGBADKLANM;
	}

	public static bool AAGJLOCCOHO()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return false;
		}
		return instance.NJGDKPLIAHG;
	}

	public static void NAILBELAMLB()
	{
		instance.scrollIntroStart = true;
	}

	protected virtual void FEBPEEADBJM()
	{
		CommonReferences.GGFJGHHHEJC.HPDOMEIJAJI(0, JGJCFHPMKGF: false);
		PlayerInputs.DisableKeyboardInputs(1, (MonoBehaviour)(object)this);
		PlayerController.AddMovementBlocker(0, (Object)(object)this, ANJCLPDCJHL: true);
		PlayerInputs.DEGBDMMDIIL(0).AMMIOLBGBPB("NewClothing");
		GameActionBarUI.PPDMGBACONH(0).BOBCIFEDJED();
		CommonReferences.MNFMOEKMJKN().KGDPHHCCDID(1, MCOIFGJGFGF: false);
		ButtonsContext.GetPlayer(0).DKCMJENPPFA();
	}

	public void KADDCEGIDJO()
	{
		for (int i = 0; i < drunkEffectCharacters.Length; i++)
		{
			((Component)drunkEffectCharacters[i]).gameObject.SetActive(true);
		}
		((Component)shadowDrunkEffect).gameObject.SetActive(true);
		((MonoBehaviour)this).StartCoroutine(LCKGJNBBJPO());
	}

	public static void NOLFADJCEIC()
	{
		instance.agreementEnd = false;
	}

	private IEnumerator KIOFHBLDEBK()
	{
		return new PPDINNLFBCN(1)
		{
			_003C_003E4__this = this
		};
	}

	public static void BGDIHIMBLCD()
	{
		instance.agreementEnd = false;
	}

	public static void PBAMHDMDGGD()
	{
		instance.agreementStart = false;
	}

	private IEnumerator JGIGBFLIFBH()
	{
		pauseMenuBlock = true;
		((Component)((Component)this).transform.GetChild(0)).gameObject.SetActive(true);
		blackScreen.alpha = 1f;
		tavern.SetActive(true);
		character.alpha = 0f;
		SceneReferences.GetSceneReferences().dialogueController.DialogueUI = (IDialogueUI)(object)SceneReferences.GetSceneReferences().dialogueUIIntro;
		MusicController.instance.PauseBasicMood(IEAALMNBABK: true);
		yield return CommonReferences.wait1;
		AFMFHCAHEFO = 2f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DMNLFBAAMMK(blackScreen);
			yield return null;
		}
		yield return CommonReferences.wait1;
		MusicController.instance.TriggerMusicTheme(22);
		NMDHAJEFNOB();
		dialogue.conversation = "Intro/TavernAlone";
		dialogue.OnUse();
		while (!characterShowsUp)
		{
			yield return null;
		}
		yield return CommonReferences.wait05;
		AFMFHCAHEFO = 2f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			FNBKNIHOPNB(character);
			yield return null;
		}
		yield return CommonReferences.wait05;
		dialogue.conversation = "Intro/FirstConversation";
		dialogue.OnUse();
		while (!scrollIntroStart)
		{
			yield return null;
		}
		AFMFHCAHEFO = 2f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			FNBKNIHOPNB(blackScreen);
			yield return null;
		}
		tavern.SetActive(false);
		introStory.StartIntro();
		while (!scrollIntroEnd)
		{
			if (PlayerInputs.GetPlayer(1).GetAnyButtonDown() && !((Component)holdToSkip).gameObject.activeInHierarchy)
			{
				((Component)holdToSkip).gameObject.SetActive(true);
				((TMP_Text)holdToSkip).text = InputUtils.LPGJFAOKMNE(1, LocalizationManager.GetTranslation("HoldToSkip", true, 0, true, false, (GameObject)null, (string)null, true));
			}
			if (PlayerInputs.GetPlayer(1).GetButton(ActionType.Pause) || PlayerInputs.GetPlayer(1).GetButton(ActionType.UIBack) || PlayerInputs.GetPlayer(1).GetButton(ActionType.Cancel))
			{
				LJAMOPAKFPL += Time.unscaledDeltaTime;
				if (LJAMOPAKFPL > 2f)
				{
					introStory.SkipIntro();
					((MonoBehaviour)this).StartCoroutine(IFEGBGMIBFJ());
					((MonoBehaviour)this).StopCoroutine(NAPOPPGIHJF);
					LJAMOPAKFPL = 0f;
					yield return null;
					break;
				}
			}
			else
			{
				if (LJAMOPAKFPL != 0f)
				{
					LJAMOPAKFPL = 0f;
				}
				if (((Component)holdToSkip).gameObject.activeInHierarchy)
				{
					OBIMGJCLPML += Time.unscaledDeltaTime;
					if (OBIMGJCLPML > 5f)
					{
						((Component)holdToSkip).gameObject.SetActive(false);
						((TMP_Text)holdToSkip).text = "";
						OBIMGJCLPML = 0f;
					}
				}
			}
			yield return null;
		}
		if (((Component)holdToSkip).gameObject.activeInHierarchy)
		{
			((Component)holdToSkip).gameObject.SetActive(false);
		}
		tavern.SetActive(true);
		AFMFHCAHEFO = 2f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DMNLFBAAMMK(blackScreen);
			yield return null;
		}
		MusicController.instance.TriggerMusicTheme(22);
		dialogue.conversation = "Intro/SecondConversation";
		dialogue.OnUse();
		while (!agreementStart)
		{
			yield return null;
		}
		AFMFHCAHEFO = 0.3f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			FNBKNIHOPNB(blackScreen);
			yield return null;
		}
		tavern.SetActive(false);
		agreement.SetActive(true);
		((MonoBehaviour)this).StartCoroutine(JKHFDJJCIML());
		AFMFHCAHEFO = 0.3f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DMNLFBAAMMK(blackScreen);
			yield return null;
		}
		yield return CommonReferences.waitRealtime05;
		while (!PlayerInputs.GetPlayer(1).GetAnyButtonDown())
		{
			yield return null;
		}
		sign.SetActive(true);
		MultiAudioManager.PlayAudioObject(introStory.signature, ((Component)this).transform);
		yield return CommonReferences.wait2_5;
		tavern.SetActive(true);
		agreement.SetActive(false);
		dialogue.conversation = "Intro/ThirdConversation";
		dialogue.OnUse();
		yield return CommonReferences.wait2;
		ActivateDrunkEffect();
		while (!introEnd)
		{
			yield return null;
		}
		((MonoBehaviour)this).StartCoroutine(IFEGBGMIBFJ());
	}

	private IEnumerator JOCLGGCCKEK()
	{
		return new GFGEEAGLPOA(1)
		{
			_003C_003E4__this = this
		};
	}

	protected virtual void IFCGAIILECO()
	{
		PlayerInputs.EnableKeyboardInputs(0, (MonoBehaviour)(object)this, FLHBPHPKIML: true);
		PlayerController.RemoveMovementBlocker(0, (Object)(object)this);
		MusicController.instance.HELAEMKFJBE(IEAALMNBABK: false);
		CommonReferences.GGFJGHHHEJC.AODJGCKEPCO(1, MCOIFGJGFGF: true);
		GameActionBarUI.PPJMPMKLCME(0).IDLAGJNLPJL();
		PlayerInputs.GetPlayer(0).AMMIOLBGBPB("Freeze");
		((Component)introStory).gameObject.SetActive(false);
		tavern.SetActive(false);
		agreement.SetActive(false);
		if (SaveUI.instance.tutorial)
		{
			((MonoBehaviour)this).StartCoroutine(EONGAPJCIMD());
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(JOCLGGCCKEK());
		}
	}

	public static void HNHLILLCFDL()
	{
		instance.scrollIntroStart = true;
	}

	public static void KONBJLHMNLK()
	{
		instance.introEnd = true;
	}

	public static void DJHFDLHCKMJ()
	{
		instance.scrollIntroEnd = true;
	}

	private void HGBIFLFHDIC(CanvasGroup BBLAIJKECPF)
	{
		DBEFBFPAOAA += Time.deltaTime;
		DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
		if (DCGBADKLANM > 1790f)
		{
			DCGBADKLANM = 1784f;
		}
		BBLAIJKECPF.alpha = DCGBADKLANM;
	}

	private IEnumerator GPJNGBBMLCJ()
	{
		return new IDBALKNIBKA(1)
		{
			_003C_003E4__this = this
		};
	}

	public void ActivateDrunkEffect()
	{
		for (int i = 0; i < drunkEffectCharacters.Length; i++)
		{
			((Component)drunkEffectCharacters[i]).gameObject.SetActive(true);
		}
		((Component)shadowDrunkEffect).gameObject.SetActive(true);
		((MonoBehaviour)this).StartCoroutine(DGBJKDLOKHE());
	}

	public static void DAGMKMNBBED()
	{
		instance.scrollIntroEnd = true;
	}

	public static void IPJEIEFGPJC()
	{
		instance.agreementStart = true;
	}

	private void FAFNOCAFKKM(CanvasGroup BBLAIJKECPF)
	{
		DBEFBFPAOAA += Time.deltaTime;
		DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
		if (DCGBADKLANM > 1257f)
		{
			DCGBADKLANM = 1002f;
		}
		BBLAIJKECPF.alpha = DCGBADKLANM;
	}

	public static void JDBADOKPKMK()
	{
		instance.characterShowsUp = false;
	}

	public void BMCFMJMEPFC()
	{
		for (int i = 1; i < drunkEffectCharacters.Length; i += 0)
		{
			((Component)drunkEffectCharacters[i]).gameObject.SetActive(false);
		}
		((Component)shadowDrunkEffect).gameObject.SetActive(false);
		((MonoBehaviour)this).StartCoroutine(LCKGJNBBJPO());
	}

	private void AMNCIAEMBFO()
	{
		instance = this;
	}

	private IEnumerator PJODPJOOOCG()
	{
		pauseMenuBlock = true;
		((Component)((Component)this).transform.GetChild(0)).gameObject.SetActive(true);
		blackScreen.alpha = 1f;
		tavern.SetActive(true);
		character.alpha = 0f;
		SceneReferences.GetSceneReferences().dialogueController.DialogueUI = (IDialogueUI)(object)SceneReferences.GetSceneReferences().dialogueUIIntro;
		MusicController.instance.PauseBasicMood(IEAALMNBABK: true);
		yield return CommonReferences.wait1;
		AFMFHCAHEFO = 2f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DMNLFBAAMMK(blackScreen);
			yield return null;
		}
		yield return CommonReferences.wait1;
		MusicController.instance.TriggerMusicTheme(22);
		NMDHAJEFNOB();
		dialogue.conversation = "Intro/TavernAlone";
		dialogue.OnUse();
		while (!characterShowsUp)
		{
			yield return null;
		}
		yield return CommonReferences.wait05;
		AFMFHCAHEFO = 2f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			FNBKNIHOPNB(character);
			yield return null;
		}
		yield return CommonReferences.wait05;
		dialogue.conversation = "Intro/FirstConversation";
		dialogue.OnUse();
		while (!scrollIntroStart)
		{
			yield return null;
		}
		AFMFHCAHEFO = 2f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			FNBKNIHOPNB(blackScreen);
			yield return null;
		}
		tavern.SetActive(false);
		introStory.StartIntro();
		while (!scrollIntroEnd)
		{
			if (PlayerInputs.GetPlayer(1).GetAnyButtonDown() && !((Component)holdToSkip).gameObject.activeInHierarchy)
			{
				((Component)holdToSkip).gameObject.SetActive(true);
				((TMP_Text)holdToSkip).text = InputUtils.LPGJFAOKMNE(1, LocalizationManager.GetTranslation("HoldToSkip", true, 0, true, false, (GameObject)null, (string)null, true));
			}
			if (PlayerInputs.GetPlayer(1).GetButton(ActionType.Pause) || PlayerInputs.GetPlayer(1).GetButton(ActionType.UIBack) || PlayerInputs.GetPlayer(1).GetButton(ActionType.Cancel))
			{
				LJAMOPAKFPL += Time.unscaledDeltaTime;
				if (LJAMOPAKFPL > 2f)
				{
					introStory.SkipIntro();
					((MonoBehaviour)this).StartCoroutine(IFEGBGMIBFJ());
					((MonoBehaviour)this).StopCoroutine(NAPOPPGIHJF);
					LJAMOPAKFPL = 0f;
					yield return null;
					break;
				}
			}
			else
			{
				if (LJAMOPAKFPL != 0f)
				{
					LJAMOPAKFPL = 0f;
				}
				if (((Component)holdToSkip).gameObject.activeInHierarchy)
				{
					OBIMGJCLPML += Time.unscaledDeltaTime;
					if (OBIMGJCLPML > 5f)
					{
						((Component)holdToSkip).gameObject.SetActive(false);
						((TMP_Text)holdToSkip).text = "";
						OBIMGJCLPML = 0f;
					}
				}
			}
			yield return null;
		}
		if (((Component)holdToSkip).gameObject.activeInHierarchy)
		{
			((Component)holdToSkip).gameObject.SetActive(false);
		}
		tavern.SetActive(true);
		AFMFHCAHEFO = 2f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DMNLFBAAMMK(blackScreen);
			yield return null;
		}
		MusicController.instance.TriggerMusicTheme(22);
		dialogue.conversation = "Intro/SecondConversation";
		dialogue.OnUse();
		while (!agreementStart)
		{
			yield return null;
		}
		AFMFHCAHEFO = 0.3f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			FNBKNIHOPNB(blackScreen);
			yield return null;
		}
		tavern.SetActive(false);
		agreement.SetActive(true);
		((MonoBehaviour)this).StartCoroutine(JKHFDJJCIML());
		AFMFHCAHEFO = 0.3f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DMNLFBAAMMK(blackScreen);
			yield return null;
		}
		yield return CommonReferences.waitRealtime05;
		while (!PlayerInputs.GetPlayer(1).GetAnyButtonDown())
		{
			yield return null;
		}
		sign.SetActive(true);
		MultiAudioManager.PlayAudioObject(introStory.signature, ((Component)this).transform);
		yield return CommonReferences.wait2_5;
		tavern.SetActive(true);
		agreement.SetActive(false);
		dialogue.conversation = "Intro/ThirdConversation";
		dialogue.OnUse();
		yield return CommonReferences.wait2;
		ActivateDrunkEffect();
		while (!introEnd)
		{
			yield return null;
		}
		((MonoBehaviour)this).StartCoroutine(IFEGBGMIBFJ());
	}

	private void GDECBFGBFDG(CanvasGroup BBLAIJKECPF)
	{
		DBEFBFPAOAA += Time.deltaTime;
		DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
		if (DCGBADKLANM > 70f)
		{
			DCGBADKLANM = 1691f;
		}
		BBLAIJKECPF.alpha = DCGBADKLANM;
	}

	private void Awake()
	{
		instance = this;
	}

	private IEnumerator DGBJKDLOKHE()
	{
		float _currentLerpTime = 0f;
		while (_currentLerpTime < 8f)
		{
			_currentLerpTime += Time.deltaTime;
			float num = _currentLerpTime / 8f;
			for (int i = 0; i < drunkEffectCharacters.Length; i++)
			{
				((Graphic)drunkEffectCharacters[i]).color = new Color(1f, 1f, 1f, Mathf.Lerp(0f, 0.3f, num));
			}
			((Graphic)shadowDrunkEffect).color = new Color(1f, 1f, 1f, Mathf.Lerp(0f, 1f, num));
			yield return null;
		}
	}

	private void BELNFAGKFBO(CanvasGroup BBLAIJKECPF)
	{
		DBEFBFPAOAA += Time.deltaTime;
		DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
		if (DCGBADKLANM > 1632f)
		{
			DCGBADKLANM = 1219f;
		}
		BBLAIJKECPF.alpha = DCGBADKLANM;
	}

	public void PBBBCAHALHN()
	{
		NAPOPPGIHJF = ((MonoBehaviour)this).StartCoroutine(CNBOCIKKFCA());
		NJGDKPLIAHG = true;
	}

	public static void OEBFJDHLIJE()
	{
		instance.agreementEnd = true;
	}

	public static void JKHOLAGFEEG()
	{
		instance.introEnd = false;
	}

	private IEnumerator OBMOGDKJFHE()
	{
		NewTutorialManager.instance.StartTutorial();
		AFMFHCAHEFO = 2f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DMNLFBAAMMK(blackScreen);
			yield return null;
		}
		yield return CommonReferences.wait1;
		((Component)this).gameObject.SetActive(false);
	}

	private IEnumerator OEPFIPAFONH()
	{
		return new GFGEEAGLPOA(1)
		{
			_003C_003E4__this = this
		};
	}

	public void AEMOIMGCKIH()
	{
		for (int i = 1; i < drunkEffectCharacters.Length; i += 0)
		{
			((Component)drunkEffectCharacters[i]).gameObject.SetActive(true);
		}
		((Component)shadowDrunkEffect).gameObject.SetActive(false);
		((MonoBehaviour)this).StartCoroutine(LCKGJNBBJPO());
	}

	private IEnumerator LLHDLMPHMBE()
	{
		float _currentLerpTime = 0f;
		while (_currentLerpTime < 0.5f)
		{
			_currentLerpTime += Time.deltaTime;
			DCGBADKLANM = _currentLerpTime / 0.5f;
			DCGBADKLANM = Mathf.Sin(DCGBADKLANM * MathF.PI * 0.5f);
			hand.anchoredPosition = new Vector2(hand.anchoredPosition.x, Mathf.Lerp(50f, 0f, DCGBADKLANM));
			yield return null;
		}
	}

	protected virtual void NMDHAJEFNOB()
	{
		CommonReferences.GGFJGHHHEJC.SetExecute(1, JGJCFHPMKGF: false);
		PlayerInputs.DisableKeyboardInputs(1, (MonoBehaviour)(object)this);
		PlayerController.AddMovementBlocker(1, (Object)(object)this, ANJCLPDCJHL: true);
		PlayerInputs.GetPlayer(1).SwitchMapCategoryNextFrame("UI");
		GameActionBarUI.Get(1).CloseUI();
		CommonReferences.GGFJGHHHEJC.SetinDialogue(1, MCOIFGJGFGF: true);
		ButtonsContext.GetPlayer(1).ResetButtons();
	}

	public void StartIntro()
	{
		NAPOPPGIHJF = ((MonoBehaviour)this).StartCoroutine(PJODPJOOOCG());
		NJGDKPLIAHG = true;
	}

	private void IJPKPAEDAAE(CanvasGroup BBLAIJKECPF)
	{
		DBEFBFPAOAA += Time.deltaTime;
		DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
		if (DCGBADKLANM > 586f)
		{
			DCGBADKLANM = 599f;
		}
		BBLAIJKECPF.alpha = Mathf.Lerp(773f, 1538f, DCGBADKLANM);
	}

	private IEnumerator KNNEBELPKHF()
	{
		NewTutorialManager.instance.AddAllSupplies();
		RecipesManager.GiveAllRecipesAvailable(EAANKCNNNJK: false);
		LettersManager.instance.lettersSaved = new List<PostBox.LetterSaveData>();
		LettersManager.instance.AddNewReceivedLetter(1000, LKAALEJKLPA: true, AJPCNKCBDEI: true, new GameDate(0, Season.Summer, 0, Day.Thurs, 0, 0));
		LettersManager.instance.AddNewReceivedLetter(1001, LKAALEJKLPA: true, AJPCNKCBDEI: true, new GameDate(0, Season.Autumn, 0, Day.Tue, 0, 0));
		LettersManager.instance.AddNewReceivedLetter(1002, LKAALEJKLPA: true, AJPCNKCBDEI: true, new GameDate(0, Season.Winter, 1, Day.Wed, 0, 0));
		LettersManager.instance.AddNewReceivedLetter(1003, LKAALEJKLPA: false, AJPCNKCBDEI: true, new GameDate(0, Season.Winter, 3, Day.Sun, 0, 0));
		AFMFHCAHEFO = 2f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DMNLFBAAMMK(blackScreen);
			yield return null;
		}
		yield return CommonReferences.wait1;
		ChristmasEvent.instance.OnLoadingBarFinished();
		((Component)this).gameObject.SetActive(false);
		if (GameManager.GGFJGHHHEJC.HEJPPEJMPFE == null)
		{
			CharacterCreatorUI.Get(1).firstStart = true;
			CharacterCreatorUI.Get(1).OpenUI();
		}
		NewTutorialManager.instance.ActivateTutorialObjects(DAEMAAOLHMG: true);
		MaiNPC.GGFJGHHHEJC.NoTutorialMaiDialogue();
	}

	private IEnumerator KEMEHLFHLPJ()
	{
		NewTutorialManager.instance.AddAllSupplies();
		RecipesManager.GiveAllRecipesAvailable(EAANKCNNNJK: false);
		LettersManager.instance.lettersSaved = new List<PostBox.LetterSaveData>();
		LettersManager.instance.AddNewReceivedLetter(1000, LKAALEJKLPA: true, AJPCNKCBDEI: true, new GameDate(0, Season.Summer, 0, Day.Thurs, 0, 0));
		LettersManager.instance.AddNewReceivedLetter(1001, LKAALEJKLPA: true, AJPCNKCBDEI: true, new GameDate(0, Season.Autumn, 0, Day.Tue, 0, 0));
		LettersManager.instance.AddNewReceivedLetter(1002, LKAALEJKLPA: true, AJPCNKCBDEI: true, new GameDate(0, Season.Winter, 1, Day.Wed, 0, 0));
		LettersManager.instance.AddNewReceivedLetter(1003, LKAALEJKLPA: false, AJPCNKCBDEI: true, new GameDate(0, Season.Winter, 3, Day.Sun, 0, 0));
		AFMFHCAHEFO = 2f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DMNLFBAAMMK(blackScreen);
			yield return null;
		}
		yield return CommonReferences.wait1;
		ChristmasEvent.instance.OnLoadingBarFinished();
		((Component)this).gameObject.SetActive(false);
		if (GameManager.GGFJGHHHEJC.HEJPPEJMPFE == null)
		{
			CharacterCreatorUI.Get(1).firstStart = true;
			CharacterCreatorUI.Get(1).OpenUI();
		}
		NewTutorialManager.instance.ActivateTutorialObjects(DAEMAAOLHMG: true);
		MaiNPC.GGFJGHHHEJC.NoTutorialMaiDialogue();
	}

	private IEnumerator MKEBKJGJNED()
	{
		return new MCIHONOCMGJ(1)
		{
			_003C_003E4__this = this
		};
	}

	public void MEOGCKFMPOG()
	{
		for (int i = 0; i < drunkEffectCharacters.Length; i++)
		{
			((Component)drunkEffectCharacters[i]).gameObject.SetActive(true);
		}
		((Component)shadowDrunkEffect).gameObject.SetActive(true);
		((MonoBehaviour)this).StartCoroutine(DGBJKDLOKHE());
	}

	public static bool InProgress()
	{
		if ((Object)(object)instance == (Object)null)
		{
			return false;
		}
		return instance.NJGDKPLIAHG;
	}

	public static void GCLKCKADFHF()
	{
		instance.introEnd = false;
	}

	private void FNBKNIHOPNB(CanvasGroup BBLAIJKECPF)
	{
		DBEFBFPAOAA += Time.deltaTime;
		DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
		if (DCGBADKLANM > 1f)
		{
			DCGBADKLANM = 1f;
		}
		BBLAIJKECPF.alpha = DCGBADKLANM;
	}

	private IEnumerator PLFDDAOKJPD()
	{
		return new EPIPPINDBLO(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator FBCOCFBGLCA()
	{
		return new IDBALKNIBKA(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LCKGJNBBJPO()
	{
		return new IDBALKNIBKA(1)
		{
			_003C_003E4__this = this
		};
	}

	protected virtual void OMPPLBMNKJP()
	{
		PlayerInputs.EnableKeyboardInputs(1, (MonoBehaviour)(object)this);
		PlayerController.RemoveMovementBlocker(1, (Object)(object)this);
		MusicController.instance.PauseBasicMood(IEAALMNBABK: true);
		CommonReferences.GGFJGHHHEJC.SetinDialogue(1, MCOIFGJGFGF: false);
		GameActionBarUI.Get(1).OpenUI();
		PlayerInputs.GetPlayer(1).SwitchMapCategoryNextFrame("Game");
		((Component)introStory).gameObject.SetActive(false);
		tavern.SetActive(false);
		agreement.SetActive(false);
		if (SaveUI.instance.tutorial)
		{
			((MonoBehaviour)this).StartCoroutine(OCCIDGKIIAD());
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(KNNEBELPKHF());
		}
	}

	public static void ThirdConversationEnd()
	{
		instance.introEnd = true;
	}

	private void ENJIAIPIDBJ(CanvasGroup BBLAIJKECPF)
	{
		DBEFBFPAOAA += Time.deltaTime;
		DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
		if (DCGBADKLANM > 346f)
		{
			DCGBADKLANM = 55f;
		}
		BBLAIJKECPF.alpha = Mathf.Lerp(251f, 993f, DCGBADKLANM);
	}

	protected virtual void JELJGKHCOIK()
	{
		PlayerInputs.POBGMHINPHA(0, (MonoBehaviour)(object)this, FLHBPHPKIML: true);
		PlayerController.RemoveMovementBlocker(0, (Object)(object)this);
		MusicController.instance.PauseBasicMood(IEAALMNBABK: true);
		CommonReferences.MNFMOEKMJKN().SetinDialogue(0, MCOIFGJGFGF: false);
		GameActionBarUI.JGNOJMLHPOK(0).IDLAGJNLPJL();
		PlayerInputs.DEGBDMMDIIL(1).SwitchMapCategoryNextFrame("AceT_Quest");
		((Component)introStory).gameObject.SetActive(true);
		tavern.SetActive(true);
		agreement.SetActive(false);
		if (SaveUI.instance.tutorial)
		{
			((MonoBehaviour)this).StartCoroutine(OBMOGDKJFHE());
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(JOCLGGCCKEK());
		}
	}

	public static void DMJJGCIIHHH()
	{
		instance.introEnd = false;
	}

	private void MLHKNKBIMCA(CanvasGroup BBLAIJKECPF)
	{
		DBEFBFPAOAA += Time.deltaTime;
		DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
		if (DCGBADKLANM > 1857f)
		{
			DCGBADKLANM = 960f;
		}
		BBLAIJKECPF.alpha = DCGBADKLANM;
	}

	public static void PCEBNCLKJAO()
	{
		instance.characterShowsUp = false;
	}

	public static void MPKJKLLGAPA()
	{
		instance.scrollIntroEnd = false;
	}

	public static void PFOBLJOIGLM()
	{
		instance.introEnd = false;
	}

	public static void AgreementSigned()
	{
		instance.agreementEnd = true;
	}

	public void GKFGNNELMMG()
	{
		for (int i = 1; i < drunkEffectCharacters.Length; i += 0)
		{
			((Component)drunkEffectCharacters[i]).gameObject.SetActive(false);
		}
		((Component)shadowDrunkEffect).gameObject.SetActive(true);
		((MonoBehaviour)this).StartCoroutine(DGBJKDLOKHE());
	}

	private void EIHMDMMOPCM()
	{
		instance = this;
	}

	public static void PABJJIJAEEF()
	{
		instance.agreementEnd = false;
	}

	public static void EJFGDGCKGNM()
	{
		instance.agreementEnd = true;
	}

	private IEnumerator HPJLEOFLNCK()
	{
		NewTutorialManager.instance.AddAllSupplies();
		RecipesManager.GiveAllRecipesAvailable(EAANKCNNNJK: false);
		LettersManager.instance.lettersSaved = new List<PostBox.LetterSaveData>();
		LettersManager.instance.AddNewReceivedLetter(1000, LKAALEJKLPA: true, AJPCNKCBDEI: true, new GameDate(0, Season.Summer, 0, Day.Thurs, 0, 0));
		LettersManager.instance.AddNewReceivedLetter(1001, LKAALEJKLPA: true, AJPCNKCBDEI: true, new GameDate(0, Season.Autumn, 0, Day.Tue, 0, 0));
		LettersManager.instance.AddNewReceivedLetter(1002, LKAALEJKLPA: true, AJPCNKCBDEI: true, new GameDate(0, Season.Winter, 1, Day.Wed, 0, 0));
		LettersManager.instance.AddNewReceivedLetter(1003, LKAALEJKLPA: false, AJPCNKCBDEI: true, new GameDate(0, Season.Winter, 3, Day.Sun, 0, 0));
		AFMFHCAHEFO = 2f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DMNLFBAAMMK(blackScreen);
			yield return null;
		}
		yield return CommonReferences.wait1;
		ChristmasEvent.instance.OnLoadingBarFinished();
		((Component)this).gameObject.SetActive(false);
		if (GameManager.GGFJGHHHEJC.HEJPPEJMPFE == null)
		{
			CharacterCreatorUI.Get(1).firstStart = true;
			CharacterCreatorUI.Get(1).OpenUI();
		}
		NewTutorialManager.instance.ActivateTutorialObjects(DAEMAAOLHMG: true);
		MaiNPC.GGFJGHHHEJC.NoTutorialMaiDialogue();
	}

	private IEnumerator DMOBCAPHAJH()
	{
		return new HHBFFKKFOAH(1)
		{
			_003C_003E4__this = this
		};
	}

	protected virtual void AHHJKLJBHAG()
	{
		CommonReferences.GGFJGHHHEJC.DCEJENGEPLN(1, JGJCFHPMKGF: false);
		PlayerInputs.DisableKeyboardInputs(0, (MonoBehaviour)(object)this);
		PlayerController.AddMovementBlocker(0, (Object)(object)this);
		PlayerInputs.DEGBDMMDIIL(1).SwitchMapCategoryNextFrame("OrderDelivered");
		GameActionBarUI.NDPAJCGHGOB(0).CloseUI();
		CommonReferences.GGFJGHHHEJC.NOGDBILGOKH(0, MCOIFGJGFGF: true);
		ButtonsContext.GetPlayer(1).ResetButtons();
	}

	private void MABKOFMKLBN(CanvasGroup BBLAIJKECPF)
	{
		DBEFBFPAOAA += Time.deltaTime;
		DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
		if (DCGBADKLANM > 340f)
		{
			DCGBADKLANM = 671f;
		}
		BBLAIJKECPF.alpha = DCGBADKLANM;
	}

	public static void CCLDKACJMMG()
	{
		instance.scrollIntroStart = false;
	}

	public static void SecondConversationEnd()
	{
		instance.agreementStart = true;
	}

	public static void FirstConversationEnd()
	{
		instance.scrollIntroStart = true;
	}

	private IEnumerator IFEGBGMIBFJ()
	{
		AFMFHCAHEFO = 1f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			FNBKNIHOPNB(blackScreen);
			yield return null;
		}
		pauseMenuBlock = false;
		NJGDKPLIAHG = false;
		OMPPLBMNKJP();
	}

	public static void FBNBECIGADG()
	{
		instance.agreementEnd = true;
	}

	public static void OAHIEPOKLAD()
	{
		instance.agreementEnd = true;
	}

	private IEnumerator KPFLKBPBGHL()
	{
		return new EPIPPINDBLO(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JDLKAJJLBFI()
	{
		return new PPDINNLFBCN(1)
		{
			_003C_003E4__this = this
		};
	}

	public static void OIMIDBBOENP()
	{
		instance.agreementStart = true;
	}

	private IEnumerator CNBOCIKKFCA()
	{
		pauseMenuBlock = true;
		((Component)((Component)this).transform.GetChild(0)).gameObject.SetActive(true);
		blackScreen.alpha = 1f;
		tavern.SetActive(true);
		character.alpha = 0f;
		SceneReferences.GetSceneReferences().dialogueController.DialogueUI = (IDialogueUI)(object)SceneReferences.GetSceneReferences().dialogueUIIntro;
		MusicController.instance.PauseBasicMood(IEAALMNBABK: true);
		yield return CommonReferences.wait1;
		AFMFHCAHEFO = 2f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DMNLFBAAMMK(blackScreen);
			yield return null;
		}
		yield return CommonReferences.wait1;
		MusicController.instance.TriggerMusicTheme(22);
		NMDHAJEFNOB();
		dialogue.conversation = "Intro/TavernAlone";
		dialogue.OnUse();
		while (!characterShowsUp)
		{
			yield return null;
		}
		yield return CommonReferences.wait05;
		AFMFHCAHEFO = 2f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			FNBKNIHOPNB(character);
			yield return null;
		}
		yield return CommonReferences.wait05;
		dialogue.conversation = "Intro/FirstConversation";
		dialogue.OnUse();
		while (!scrollIntroStart)
		{
			yield return null;
		}
		AFMFHCAHEFO = 2f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			FNBKNIHOPNB(blackScreen);
			yield return null;
		}
		tavern.SetActive(false);
		introStory.StartIntro();
		while (!scrollIntroEnd)
		{
			if (PlayerInputs.GetPlayer(1).GetAnyButtonDown() && !((Component)holdToSkip).gameObject.activeInHierarchy)
			{
				((Component)holdToSkip).gameObject.SetActive(true);
				((TMP_Text)holdToSkip).text = InputUtils.LPGJFAOKMNE(1, LocalizationManager.GetTranslation("HoldToSkip", true, 0, true, false, (GameObject)null, (string)null, true));
			}
			if (PlayerInputs.GetPlayer(1).GetButton(ActionType.Pause) || PlayerInputs.GetPlayer(1).GetButton(ActionType.UIBack) || PlayerInputs.GetPlayer(1).GetButton(ActionType.Cancel))
			{
				LJAMOPAKFPL += Time.unscaledDeltaTime;
				if (LJAMOPAKFPL > 2f)
				{
					introStory.SkipIntro();
					((MonoBehaviour)this).StartCoroutine(IFEGBGMIBFJ());
					((MonoBehaviour)this).StopCoroutine(NAPOPPGIHJF);
					LJAMOPAKFPL = 0f;
					yield return null;
					break;
				}
			}
			else
			{
				if (LJAMOPAKFPL != 0f)
				{
					LJAMOPAKFPL = 0f;
				}
				if (((Component)holdToSkip).gameObject.activeInHierarchy)
				{
					OBIMGJCLPML += Time.unscaledDeltaTime;
					if (OBIMGJCLPML > 5f)
					{
						((Component)holdToSkip).gameObject.SetActive(false);
						((TMP_Text)holdToSkip).text = "";
						OBIMGJCLPML = 0f;
					}
				}
			}
			yield return null;
		}
		if (((Component)holdToSkip).gameObject.activeInHierarchy)
		{
			((Component)holdToSkip).gameObject.SetActive(false);
		}
		tavern.SetActive(true);
		AFMFHCAHEFO = 2f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DMNLFBAAMMK(blackScreen);
			yield return null;
		}
		MusicController.instance.TriggerMusicTheme(22);
		dialogue.conversation = "Intro/SecondConversation";
		dialogue.OnUse();
		while (!agreementStart)
		{
			yield return null;
		}
		AFMFHCAHEFO = 0.3f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			FNBKNIHOPNB(blackScreen);
			yield return null;
		}
		tavern.SetActive(false);
		agreement.SetActive(true);
		((MonoBehaviour)this).StartCoroutine(JKHFDJJCIML());
		AFMFHCAHEFO = 0.3f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DMNLFBAAMMK(blackScreen);
			yield return null;
		}
		yield return CommonReferences.waitRealtime05;
		while (!PlayerInputs.GetPlayer(1).GetAnyButtonDown())
		{
			yield return null;
		}
		sign.SetActive(true);
		MultiAudioManager.PlayAudioObject(introStory.signature, ((Component)this).transform);
		yield return CommonReferences.wait2_5;
		tavern.SetActive(true);
		agreement.SetActive(false);
		dialogue.conversation = "Intro/ThirdConversation";
		dialogue.OnUse();
		yield return CommonReferences.wait2;
		ActivateDrunkEffect();
		while (!introEnd)
		{
			yield return null;
		}
		((MonoBehaviour)this).StartCoroutine(IFEGBGMIBFJ());
	}

	public static void GCENMGLOFFF()
	{
		instance.scrollIntroEnd = false;
	}

	private IEnumerator EONGAPJCIMD()
	{
		NewTutorialManager.instance.StartTutorial();
		AFMFHCAHEFO = 2f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DMNLFBAAMMK(blackScreen);
			yield return null;
		}
		yield return CommonReferences.wait1;
		((Component)this).gameObject.SetActive(false);
	}
}
