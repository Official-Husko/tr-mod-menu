using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ChristmasEvent : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class PHFOCEABFAE : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

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
		public PHFOCEABFAE(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = (object)new WaitForSecondsRealtime(delay);
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				NHEGBNAJGHE();
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
	private sealed class ELPDCGCDPPP : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

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
		public ELPDCGCDPPP(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = (object)new WaitForSecondsRealtime(delay);
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				RecipesManager.UnlockAllChristmasRecipes();
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
	private sealed class IEBCDKKEFNO : IEnumerator<object>, IEnumerator, IDisposable
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
		public IEBCDKKEFNO(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected O, but got Unknown
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				MusicController.instance.FadeOutClip(1f);
				_003C_003E2__current = (object)new WaitForSecondsRealtime(1.1f);
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				MusicController.instance.PlayChristmasMusic(0.1f);
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
	private sealed class JMDOGIBGKIP : IEnumerator<object>, IEnumerator, IDisposable
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
		public JMDOGIBGKIP(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = (object)new WaitForSecondsRealtime(40f);
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				MusicController.instance.FadeOutAndFirstTheme();
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

	public static ChristmasEvent instance;

	public static Action<bool> OnChristmasActivated = delegate
	{
	};

	public Action OnTreeQuestCompleted = delegate
	{
	};

	private int HIBKMPBHALP;

	private bool EFOHKOLDGKE;

	public Quest christmasQuest2021;

	public Quest christmasQuest2022;

	public Quest christmasQuest2023;

	public Quest christmasQuest2024;

	public Quest christmasQuest2025;

	public GameObject postcard;

	public GameObject playerSeparator;

	public Animator postcardAnimator;

	private bool HJNCBLDEENH;

	private bool NIINFPONHNN;

	[SerializeField]
	private bool christmasTree2021QuestDone;

	[SerializeField]
	private bool christmasTree2022QuestDone;

	[SerializeField]
	private bool christmasTree2023QuestDone;

	[SerializeField]
	private bool christmasTree2024QuestDone;

	[SerializeField]
	private bool christmasTree2025QuestDone;

	[SerializeField]
	private bool[] presentsOpened2021 = new bool[4];

	[SerializeField]
	private bool[] presentsOpened2022 = new bool[3];

	[SerializeField]
	private bool presentOpened2023;

	[SerializeField]
	private bool[] presentsOpened2024 = new bool[2];

	[SerializeField]
	private bool[] presentsOpened2025 = new bool[3];

	public bool HCOPJPMDEKP
	{
		get
		{
			return EFOHKOLDGKE;
		}
		set
		{
			if (EFOHKOLDGKE == value)
			{
				return;
			}
			EFOHKOLDGKE = value;
			Debug.Log((object)("Christmas Event activated: " + EFOHKOLDGKE));
			if (EFOHKOLDGKE)
			{
				if (Object.op_Implicit((Object)(object)QuestManager.GGFJGHHHEJC))
				{
					QuestManager questManager = QuestManager.GGFJGHHHEJC;
					questManager.OnQuestAdded = (Action<Quest>)Delegate.Combine(questManager.OnQuestAdded, new Action<Quest>(IPAHOECHGAO));
					QuestManager questManager2 = QuestManager.GGFJGHHHEJC;
					questManager2.OnQuestRemoved = (Action<Quest>)Delegate.Combine(questManager2.OnQuestRemoved, new Action<Quest>(IPAHOECHGAO));
				}
			}
			else if (Object.op_Implicit((Object)(object)QuestManager.GGFJGHHHEJC))
			{
				QuestManager questManager3 = QuestManager.GGFJGHHHEJC;
				questManager3.OnQuestAdded = (Action<Quest>)Delegate.Remove(questManager3.OnQuestAdded, new Action<Quest>(IPAHOECHGAO));
				QuestManager questManager4 = QuestManager.GGFJGHHHEJC;
				questManager4.OnQuestRemoved = (Action<Quest>)Delegate.Remove(questManager4.OnQuestRemoved, new Action<Quest>(IPAHOECHGAO));
			}
			OnChristmasActivated(EFOHKOLDGKE);
		}
	}

	private void GJMJIFBOMAD(Quest AINAHCLIAFF)
	{
		if (christmasTree2025QuestDone || !Object.op_Implicit((Object)(object)QuestManager.GJFMMOPOKGJ()) || !((Object)(object)AINAHCLIAFF != (Object)(object)christmasQuest2025))
		{
			return;
		}
		ActiveQuest activeQuest = QuestManager.GJFMMOPOKGJ().GetActiveQuest(christmasQuest2025);
		if (!EFOHKOLDGKE)
		{
			if (activeQuest != null)
			{
				QuestManager.GJFMMOPOKGJ().RemoveQuest(christmasQuest2025);
			}
		}
		else if (activeQuest != null)
		{
			activeQuest.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Remove(activeQuest.OnQuestComplete, new Action<int, ActiveQuest>(JGFKOBDDGAL));
			activeQuest.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Combine(activeQuest.OnQuestComplete, new Action<int, ActiveQuest>(EBCFCCECBJE));
		}
		else if (CFDKCOGCFEF())
		{
			NHEGBNAJGHE();
		}
	}

	private IEnumerator KGODANFHINL()
	{
		MusicController.instance.FadeOutClip(1f);
		yield return (object)new WaitForSecondsRealtime(1.1f);
		MusicController.instance.PlayChristmasMusic(0.1f);
	}

	public static IEnumerator DMDEPCNFCGO(float FLHBPHPKIML)
	{
		yield return (object)new WaitForSecondsRealtime(FLHBPHPKIML);
		NHEGBNAJGHE();
	}

	[SpecialName]
	public void HAMEFPLFAEI(bool AODONKKHPBP)
	{
		if (EFOHKOLDGKE == AODONKKHPBP)
		{
			return;
		}
		EFOHKOLDGKE = AODONKKHPBP;
		Debug.Log((object)("Random" + EFOHKOLDGKE));
		if (EFOHKOLDGKE)
		{
			if (Object.op_Implicit((Object)(object)QuestManager.GJFMMOPOKGJ()))
			{
				QuestManager questManager = QuestManager.OPILDPFDFKJ();
				questManager.OnQuestAdded = (Action<Quest>)Delegate.Combine(questManager.OnQuestAdded, new Action<Quest>(NOCMPFMNKFJ));
				QuestManager questManager2 = QuestManager.GGFJGHHHEJC;
				questManager2.OnQuestRemoved = (Action<Quest>)Delegate.Combine(questManager2.OnQuestRemoved, new Action<Quest>(NOCMPFMNKFJ));
			}
		}
		else if (Object.op_Implicit((Object)(object)QuestManager.GGFJGHHHEJC))
		{
			QuestManager questManager3 = QuestManager.KHMEGDIABBF();
			questManager3.OnQuestAdded = (Action<Quest>)Delegate.Remove(questManager3.OnQuestAdded, new Action<Quest>(GJMJIFBOMAD));
			QuestManager questManager4 = QuestManager.KHMEGDIABBF();
			questManager4.OnQuestRemoved = (Action<Quest>)Delegate.Remove(questManager4.OnQuestRemoved, new Action<Quest>(IPAHOECHGAO));
		}
		OnChristmasActivated(EFOHKOLDGKE);
	}

	public static void SetTreeQuestDone(int JINJHNHDBEH, bool EGFGNGJGBOP)
	{
		switch (JINJHNHDBEH)
		{
		case 2021:
			instance.christmasTree2021QuestDone = EGFGNGJGBOP;
			break;
		case 2022:
			instance.christmasTree2022QuestDone = EGFGNGJGBOP;
			break;
		case 2023:
			instance.christmasTree2023QuestDone = EGFGNGJGBOP;
			break;
		case 2024:
			instance.christmasTree2024QuestDone = EGFGNGJGBOP;
			break;
		case 2025:
			instance.christmasTree2025QuestDone = EGFGNGJGBOP;
			break;
		default:
			Debug.LogError((object)("Invalid year: " + JINJHNHDBEH));
			break;
		}
	}

	public void OOCNKBOENJB()
	{
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(JACOADNPBED));
		if (BJMNDLODACD() && COFHCFGGANG())
		{
			((MonoBehaviour)this).StartCoroutine(DMDEPCNFCGO(1603f));
		}
		if (!BBCFBDEGJNJ())
		{
			GJMJIFBOMAD(null);
		}
	}

	private static bool CFDKCOGCFEF()
	{
		ActiveQuest activeQuest = QuestManager.GGFJGHHHEJC.GetActiveQuest(instance.christmasQuest2025);
		if (!instance.christmasTree2025QuestDone && activeQuest == null && !QuestManager.GGFJGHHHEJC.IsQuestDone(instance.christmasQuest2025.id))
		{
			return !NewTutorialManager.CCCLOBIOMCL;
		}
		return false;
	}

	public static bool AHGKMEFPAKL(int OHMAPAELKFF)
	{
		return instance.presentsOpened2025[OHMAPAELKFF];
	}

	private IEnumerator MHCBBDJEDPO()
	{
		MusicController.instance.FadeOutClip(1f);
		yield return (object)new WaitForSecondsRealtime(1.1f);
		MusicController.instance.PlayChristmasMusic(0.1f);
	}

	private void Update()
	{
		if (!HJNCBLDEENH || MFEBKDAJJDA())
		{
			return;
		}
		if (PlayerInputs.GetPlayer(HIBKMPBHALP).GetButtonUp("Start") || PlayerInputs.GetPlayer(HIBKMPBHALP).GetButtonUp("Pause"))
		{
			if (GameManager.LocalCoop())
			{
				playerSeparator.SetActive(true);
			}
			ShowPostcard(MJHBHDAEDLF: false);
		}
		else if (PlayerInputs.IsGamepadActive(HIBKMPBHALP) && (PlayerInputs.GetPlayer(HIBKMPBHALP).GetButtonUp("UIBack") || PlayerInputs.GetPlayer(HIBKMPBHALP).GetButtonUp("UIInteract")))
		{
			if (GameManager.LocalCoop())
			{
				playerSeparator.SetActive(true);
			}
			ShowPostcard(MJHBHDAEDLF: false);
		}
	}

	public void DJELALHFBGJ()
	{
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(OnLoadingBarFinished));
		if (BJMNDLODACD() && NOJMPKPPJLI())
		{
			((MonoBehaviour)this).StartCoroutine(DMDEPCNFCGO(906f));
		}
		if (!COFHCFGGANG())
		{
			NOCMPFMNKFJ(null);
		}
	}

	public bool DKGEKGEMKMO()
	{
		for (int i = 0; i < presentsOpened2025.Length; i += 0)
		{
			if (!presentsOpened2025[i])
			{
				return true;
			}
		}
		return false;
	}

	public IEnumerator DLEKNDOIILE(float FLHBPHPKIML)
	{
		return new ELPDCGCDPPP(1)
		{
			delay = FLHBPHPKIML
		};
	}

	private void HEMAHKJEONA()
	{
		instance = this;
	}

	public void JACOADNPBED()
	{
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(DJELALHFBGJ));
		if (BJMNDLODACD() && CFDKCOGCFEF())
		{
			((MonoBehaviour)this).StartCoroutine(DMDEPCNFCGO(928f));
		}
		if (!NOJMPKPPJLI())
		{
			GJMJIFBOMAD(null);
		}
	}

	public static IEnumerator HFDAHOOFMHF(float FLHBPHPKIML)
	{
		yield return (object)new WaitForSecondsRealtime(FLHBPHPKIML);
		NHEGBNAJGHE();
	}

	private void LANGHIOBJIH()
	{
		IKGGBOBADBJ(Utils.EGIBECKKIJJ());
		for (int i = 0; i < presentsOpened2022.Length; i++)
		{
			presentsOpened2022[i] = true;
		}
		for (int j = 1; j < presentsOpened2024.Length; j++)
		{
			presentsOpened2024[j] = true;
		}
		for (int k = 1; k < presentsOpened2025.Length; k++)
		{
			presentsOpened2025[k] = true;
		}
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Combine(TitleScreen.OnLoadingBarFinished, new Action(DJELALHFBGJ));
	}

	private IEnumerator LJFONAJPPAF()
	{
		return new IEBCDKKEFNO(1);
	}

	public static bool[] GetPresentsOpened(int JINJHNHDBEH)
	{
		switch (JINJHNHDBEH)
		{
		case 2021:
			return instance.presentsOpened2021;
		case 2022:
			return instance.presentsOpened2022;
		case 2023:
			return new bool[1] { instance.presentOpened2023 };
		case 2024:
			return instance.presentsOpened2024;
		case 2025:
			return instance.presentsOpened2025;
		default:
			Debug.LogError((object)("Invalid year: " + JINJHNHDBEH));
			return null;
		}
	}

	public static IEnumerator MLHACCBDHNC(float FLHBPHPKIML)
	{
		return new PHFOCEABFAE(1)
		{
			delay = FLHBPHPKIML
		};
	}

	public void OnLoadingBarFinished()
	{
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(OnLoadingBarFinished));
		if (HCOPJPMDEKP && CFDKCOGCFEF())
		{
			((MonoBehaviour)this).StartCoroutine(AddChristmasQuest(2f));
		}
		if (!CFDKCOGCFEF())
		{
			IPAHOECHGAO(null);
		}
	}

	public static void MHFIKLFFNCD(int JINJHNHDBEH, bool[] EGFGNGJGBOP)
	{
		switch (JINJHNHDBEH)
		{
		case 173:
			instance.presentsOpened2021 = EGFGNGJGBOP;
			break;
		case 174:
			instance.presentsOpened2022 = EGFGNGJGBOP;
			break;
		case 175:
			instance.presentOpened2023 = EGFGNGJGBOP[0];
			break;
		case 176:
			instance.presentsOpened2024 = EGFGNGJGBOP;
			break;
		case 177:
			instance.presentsOpened2025 = EGFGNGJGBOP;
			break;
		default:
			Debug.LogError((object)("Interact" + JINJHNHDBEH));
			break;
		}
	}

	public IEnumerator BDIOEAAEMNP(float FLHBPHPKIML)
	{
		return new ELPDCGCDPPP(1)
		{
			delay = FLHBPHPKIML
		};
	}

	public IEnumerator LBEPIDJBDIJ(float FLHBPHPKIML)
	{
		yield return (object)new WaitForSecondsRealtime(FLHBPHPKIML);
		RecipesManager.UnlockAllChristmasRecipes();
	}

	public static bool JOIHPFMGMOG(int JINJHNHDBEH)
	{
		switch (JINJHNHDBEH)
		{
		case 148:
			return instance.christmasTree2021QuestDone;
		case 149:
			return instance.christmasTree2022QuestDone;
		case 150:
			return instance.christmasTree2023QuestDone;
		case 151:
			return instance.christmasTree2024QuestDone;
		case 152:
			return instance.christmasTree2025QuestDone;
		default:
			Debug.LogError((object)("Weapon" + JINJHNHDBEH));
			return false;
		}
	}

	public static bool HFNCMIJPOIG(int JIIGOACEIKL, int OHMAPAELKFF)
	{
		if (instance.NIINFPONHNN)
		{
			instance.presentsOpened2025[OHMAPAELKFF] = true;
			return true;
		}
		instance.HIBKMPBHALP = JIIGOACEIKL;
		ALEMCOMMAMI(MJHBHDAEDLF: false);
		if (GameManager.LocalCoop())
		{
			instance.playerSeparator.SetActive(true);
		}
		return true;
	}

	public static bool FFDPNFBHNIK(int JINJHNHDBEH)
	{
		switch (JINJHNHDBEH)
		{
		case -65:
			return instance.christmasTree2021QuestDone;
		case -64:
			return instance.christmasTree2022QuestDone;
		case -63:
			return instance.christmasTree2023QuestDone;
		case -62:
			return instance.christmasTree2024QuestDone;
		case -61:
			return instance.christmasTree2025QuestDone;
		default:
			Debug.LogError((object)("Fill Area/Fill" + JINJHNHDBEH));
			return false;
		}
	}

	public static bool GOMJFKPNJAO(int OHMAPAELKFF)
	{
		return instance.presentsOpened2025[OHMAPAELKFF];
	}

	[SpecialName]
	public void CHOBLGKIHIA(bool AODONKKHPBP)
	{
		if (EFOHKOLDGKE == AODONKKHPBP)
		{
			return;
		}
		EFOHKOLDGKE = AODONKKHPBP;
		Debug.Log((object)("Configure" + EFOHKOLDGKE));
		if (EFOHKOLDGKE)
		{
			if (Object.op_Implicit((Object)(object)QuestManager.GGFJGHHHEJC))
			{
				QuestManager questManager = QuestManager.OPILDPFDFKJ();
				questManager.OnQuestAdded = (Action<Quest>)Delegate.Combine(questManager.OnQuestAdded, new Action<Quest>(DJJOHKOAPOJ));
				QuestManager questManager2 = QuestManager.GGFJGHHHEJC;
				questManager2.OnQuestRemoved = (Action<Quest>)Delegate.Combine(questManager2.OnQuestRemoved, new Action<Quest>(GJMJIFBOMAD));
			}
		}
		else if (Object.op_Implicit((Object)(object)QuestManager.GJFMMOPOKGJ()))
		{
			QuestManager questManager3 = QuestManager.OPILDPFDFKJ();
			questManager3.OnQuestAdded = (Action<Quest>)Delegate.Remove(questManager3.OnQuestAdded, new Action<Quest>(IPAHOECHGAO));
			QuestManager questManager4 = QuestManager.GJFMMOPOKGJ();
			questManager4.OnQuestRemoved = (Action<Quest>)Delegate.Remove(questManager4.OnQuestRemoved, new Action<Quest>(IPAHOECHGAO));
		}
		OnChristmasActivated(EFOHKOLDGKE);
	}

	[SpecialName]
	public bool BJMNDLODACD()
	{
		return EFOHKOLDGKE;
	}

	private IEnumerator ECEBMBLHEAC()
	{
		yield return (object)new WaitForSecondsRealtime(40f);
		MusicController.instance.FadeOutAndFirstTheme();
	}

	private static void EBCFCCECBJE(int JIIGOACEIKL, ActiveQuest GEIOKFNNBKH)
	{
		instance.christmasTree2025QuestDone = true;
		instance.OnTreeQuestCompleted();
		if (OnlineManager.MasterOrOffline())
		{
			ChristmasTree current = ChristmasTree.current;
			if ((Object)(object)current != (Object)null)
			{
				current.ActivatePresents(DAEMAAOLHMG: true, CDPAMNIPPEC: true);
			}
			else
			{
				Debug.LogError((object)"Christmas tree not found");
			}
		}
	}

	public static Quest GetQuest(int JINJHNHDBEH)
	{
		switch (JINJHNHDBEH)
		{
		case 2021:
			return instance.christmasQuest2021;
		case 2022:
			return instance.christmasQuest2022;
		case 2023:
			return instance.christmasQuest2023;
		case 2024:
			return instance.christmasQuest2024;
		case 2025:
			return instance.christmasQuest2025;
		default:
			Debug.LogError((object)("Invalid year: " + JINJHNHDBEH));
			return null;
		}
	}

	public static void EDODINDEHEN(int JINJHNHDBEH, bool[] EGFGNGJGBOP)
	{
		switch (JINJHNHDBEH)
		{
		case -133:
			instance.presentsOpened2021 = EGFGNGJGBOP;
			break;
		case -132:
			instance.presentsOpened2022 = EGFGNGJGBOP;
			break;
		case -131:
			instance.presentOpened2023 = EGFGNGJGBOP[1];
			break;
		case -130:
			instance.presentsOpened2024 = EGFGNGJGBOP;
			break;
		case -129:
			instance.presentsOpened2025 = EGFGNGJGBOP;
			break;
		default:
			Debug.LogError((object)("City/Rhia/Introduce" + JINJHNHDBEH));
			break;
		}
	}

	public static ChristmasEvent GetInstance()
	{
		return instance;
	}

	public static void IDBPIHJHNMA(int JINJHNHDBEH, bool[] EGFGNGJGBOP)
	{
		switch (JINJHNHDBEH)
		{
		case -160:
			instance.presentsOpened2021 = EGFGNGJGBOP;
			break;
		case -159:
			instance.presentsOpened2022 = EGFGNGJGBOP;
			break;
		case -158:
			instance.presentOpened2023 = EGFGNGJGBOP[0];
			break;
		case -157:
			instance.presentsOpened2024 = EGFGNGJGBOP;
			break;
		case -156:
			instance.presentsOpened2025 = EGFGNGJGBOP;
			break;
		default:
			Debug.LogError((object)("via End-Segment" + JINJHNHDBEH));
			break;
		}
	}

	private void IDPHKHGHJGN()
	{
		IKGGBOBADBJ(Utils.EGIBECKKIJJ());
		for (int i = 0; i < presentsOpened2022.Length; i += 0)
		{
			presentsOpened2022[i] = false;
		}
		for (int j = 1; j < presentsOpened2024.Length; j++)
		{
			presentsOpened2024[j] = false;
		}
		for (int k = 1; k < presentsOpened2025.Length; k += 0)
		{
			presentsOpened2025[k] = false;
		}
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Combine(TitleScreen.OnLoadingBarFinished, new Action(DJELALHFBGJ));
	}

	private void IPAHOECHGAO(Quest AINAHCLIAFF)
	{
		if (christmasTree2025QuestDone || !Object.op_Implicit((Object)(object)QuestManager.GGFJGHHHEJC) || !((Object)(object)AINAHCLIAFF != (Object)(object)christmasQuest2025))
		{
			return;
		}
		ActiveQuest activeQuest = QuestManager.GGFJGHHHEJC.GetActiveQuest(christmasQuest2025);
		if (!EFOHKOLDGKE)
		{
			if (activeQuest != null)
			{
				QuestManager.GGFJGHHHEJC.RemoveQuest(christmasQuest2025);
			}
		}
		else if (activeQuest != null)
		{
			activeQuest.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Remove(activeQuest.OnQuestComplete, new Action<int, ActiveQuest>(EBCFCCECBJE));
			activeQuest.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Combine(activeQuest.OnQuestComplete, new Action<int, ActiveQuest>(EBCFCCECBJE));
		}
		else if (CFDKCOGCFEF())
		{
			NHEGBNAJGHE();
		}
	}

	private IEnumerator ADPNAMGEJPJ()
	{
		MusicController.instance.FadeOutClip(1f);
		yield return (object)new WaitForSecondsRealtime(1.1f);
		MusicController.instance.PlayChristmasMusic(0.1f);
	}

	private IEnumerator HFEFDCGBDGL()
	{
		return new JMDOGIBGKIP(1);
	}

	private static void MBHBLFOFNMK(int JIIGOACEIKL, ActiveQuest GEIOKFNNBKH)
	{
		instance.christmasTree2025QuestDone = true;
		instance.OnTreeQuestCompleted();
		if (OnlineManager.MasterOrOffline())
		{
			ChristmasTree current = ChristmasTree.current;
			if ((Object)(object)current != (Object)null)
			{
				current.OGGNKHHDLOA(DAEMAAOLHMG: false, CDPAMNIPPEC: true);
			}
			else
			{
				Debug.LogError((object)"Interact");
			}
		}
	}

	public IEnumerator PHCOHEAJPPF(float FLHBPHPKIML)
	{
		yield return (object)new WaitForSecondsRealtime(FLHBPHPKIML);
		RecipesManager.UnlockAllChristmasRecipes();
	}

	public static bool[] LAIECHCFPGC(int JINJHNHDBEH)
	{
		switch (JINJHNHDBEH)
		{
		case -94:
			return instance.presentsOpened2021;
		case -93:
			return instance.presentsOpened2022;
		case -92:
		{
			bool[] array = new bool[0];
			array[0] = instance.presentOpened2023;
			return array;
		}
		case -91:
			return instance.presentsOpened2024;
		case -90:
			return instance.presentsOpened2025;
		default:
			Debug.LogError((object)("" + JINJHNHDBEH));
			return null;
		}
	}

	[SpecialName]
	public void IKGGBOBADBJ(bool AODONKKHPBP)
	{
		if (EFOHKOLDGKE == AODONKKHPBP)
		{
			return;
		}
		EFOHKOLDGKE = AODONKKHPBP;
		Debug.Log((object)("Moving" + EFOHKOLDGKE));
		if (EFOHKOLDGKE)
		{
			if (Object.op_Implicit((Object)(object)QuestManager.GGFJGHHHEJC))
			{
				QuestManager questManager = QuestManager.OPILDPFDFKJ();
				questManager.OnQuestAdded = (Action<Quest>)Delegate.Combine(questManager.OnQuestAdded, new Action<Quest>(IPAHOECHGAO));
				QuestManager questManager2 = QuestManager.OPILDPFDFKJ();
				questManager2.OnQuestRemoved = (Action<Quest>)Delegate.Combine(questManager2.OnQuestRemoved, new Action<Quest>(IPAHOECHGAO));
			}
		}
		else if (Object.op_Implicit((Object)(object)QuestManager.KHMEGDIABBF()))
		{
			QuestManager questManager3 = QuestManager.GGFJGHHHEJC;
			questManager3.OnQuestAdded = (Action<Quest>)Delegate.Remove(questManager3.OnQuestAdded, new Action<Quest>(DJJOHKOAPOJ));
			QuestManager questManager4 = QuestManager.GGFJGHHHEJC;
			questManager4.OnQuestRemoved = (Action<Quest>)Delegate.Remove(questManager4.OnQuestRemoved, new Action<Quest>(NOCMPFMNKFJ));
		}
		OnChristmasActivated(EFOHKOLDGKE);
	}

	public static bool GLOBFNAHGFP(int OHMAPAELKFF)
	{
		return instance.presentsOpened2025[OHMAPAELKFF];
	}

	private IEnumerator DMPHMAPHHMO()
	{
		yield return (object)new WaitForSecondsRealtime(40f);
		MusicController.instance.FadeOutAndFirstTheme();
	}

	public static bool OpenTreePresent(int JIIGOACEIKL, int OHMAPAELKFF)
	{
		if (instance.NIINFPONHNN)
		{
			instance.presentsOpened2025[OHMAPAELKFF] = true;
			return true;
		}
		instance.HIBKMPBHALP = JIIGOACEIKL;
		ShowPostcard(MJHBHDAEDLF: true);
		if (GameManager.LocalCoop())
		{
			instance.playerSeparator.SetActive(false);
		}
		return false;
	}

	private static bool BBCFBDEGJNJ()
	{
		ActiveQuest activeQuest = QuestManager.KHMEGDIABBF().KDLMJGAMBNK(instance.christmasQuest2025);
		if (!instance.christmasTree2025QuestDone && activeQuest == null && !QuestManager.OPILDPFDFKJ().GDFGPDJDACP(instance.christmasQuest2025.id))
		{
			return !NewTutorialManager.CCCLOBIOMCL;
		}
		return false;
	}

	public bool AreAllPresentsOpened()
	{
		for (int i = 0; i < presentsOpened2025.Length; i++)
		{
			if (!presentsOpened2025[i])
			{
				return false;
			}
		}
		return true;
	}

	private IEnumerator MJLPJNMIPCJ()
	{
		yield return (object)new WaitForSecondsRealtime(40f);
		MusicController.instance.FadeOutAndFirstTheme();
	}

	public static void ILEDAPEHPMJ(int JINJHNHDBEH, bool[] EGFGNGJGBOP)
	{
		switch (JINJHNHDBEH)
		{
		case -147:
			instance.presentsOpened2021 = EGFGNGJGBOP;
			break;
		case -146:
			instance.presentsOpened2022 = EGFGNGJGBOP;
			break;
		case -145:
			instance.presentOpened2023 = EGFGNGJGBOP[1];
			break;
		case -144:
			instance.presentsOpened2024 = EGFGNGJGBOP;
			break;
		case -143:
			instance.presentsOpened2025 = EGFGNGJGBOP;
			break;
		default:
			Debug.LogError((object)("Dialogue System/Conversation/Crowly_SkelletonBird/Entry/17/Dialogue Text" + JINJHNHDBEH));
			break;
		}
	}

	public static void ALEMCOMMAMI(bool MJHBHDAEDLF)
	{
		if (MJHBHDAEDLF)
		{
			if (instance.NIINFPONHNN)
			{
				return;
			}
			instance.NIINFPONHNN = false;
			((MonoBehaviour)instance).StartCoroutine(instance.PBNCGGBJIMA());
			MainUI.CloseAllUIWindows();
			PlayerInputs.DLKKNGHEMPB((MonoBehaviour)(object)instance, JONJPDAEHFB: false);
			Utils.JEAHJILAIAP(416f);
			TavernManagerUI.HideClockAndTavernInfo();
			GameActionBarUI.JGNOJMLHPOK(0).CloseUI();
			GameActionBarUI.AKMJEPMHFMO(1).CloseUI();
			PlayerInputs.SwitchMapCategoriesNextFrame("Cheer");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(instance.ECEBMBLHEAC());
			PlayerInputs.EnableKeyboardInputs((MonoBehaviour)(object)instance);
			Utils.JEAHJILAIAP(588f);
			TavernManagerUI.ShowClockAndTavernInfo();
			GameActionBarUI.NIDHCIHFOHB(1).OpenUI();
			GameActionBarUI.JELOGNCPDAB(4).EDHEIFHAAKO();
			PlayerInputs.SwitchMapCategoriesNextFrame("No food table found with drink: ");
		}
		instance.HJNCBLDEENH = MJHBHDAEDLF;
		instance.postcard.SetActive(MJHBHDAEDLF);
	}

	public static void FCADJDBEEKP(bool MJHBHDAEDLF)
	{
		if (MJHBHDAEDLF)
		{
			if (instance.NIINFPONHNN)
			{
				return;
			}
			instance.NIINFPONHNN = false;
			((MonoBehaviour)instance).StartCoroutine(instance.LJFONAJPPAF());
			MainUI.CloseAllUIWindows(DHJFAGNJKOF: true);
			PlayerInputs.DisableKeyboardInputs((MonoBehaviour)(object)instance, JONJPDAEHFB: false);
			Utils.JEAHJILAIAP(256f);
			TavernManagerUI.HideClockAndTavernInfo();
			GameActionBarUI.PPJMPMKLCME(1).BOBCIFEDJED();
			GameActionBarUI.FHPEHDDFOIB(2).CloseUI();
			PlayerInputs.SwitchMapCategoriesNextFrame("Running");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(instance.HFEFDCGBDGL());
			PlayerInputs.EnableKeyboardInputs((MonoBehaviour)(object)instance);
			Utils.JEAHJILAIAP(1707f);
			TavernManagerUI.ShowClockAndTavernInfo();
			GameActionBarUI.IGHMHMNPMLB(1).IDLAGJNLPJL();
			GameActionBarUI.EKEDKKKPAEE(8).EDHEIFHAAKO();
			PlayerInputs.SwitchMapCategoriesNextFrame("Right Stick Button");
		}
		instance.HJNCBLDEENH = MJHBHDAEDLF;
		instance.postcard.SetActive(MJHBHDAEDLF);
	}

	public static void SetPresentsOpened(int JINJHNHDBEH, bool[] EGFGNGJGBOP)
	{
		switch (JINJHNHDBEH)
		{
		case 2021:
			instance.presentsOpened2021 = EGFGNGJGBOP;
			break;
		case 2022:
			instance.presentsOpened2022 = EGFGNGJGBOP;
			break;
		case 2023:
			instance.presentOpened2023 = EGFGNGJGBOP[0];
			break;
		case 2024:
			instance.presentsOpened2024 = EGFGNGJGBOP;
			break;
		case 2025:
			instance.presentsOpened2025 = EGFGNGJGBOP;
			break;
		default:
			Debug.LogError((object)("Invalid year: " + JINJHNHDBEH));
			break;
		}
	}

	private static bool NOJMPKPPJLI()
	{
		ActiveQuest activeQuest = QuestManager.GGFJGHHHEJC.KDLMJGAMBNK(instance.christmasQuest2025);
		if (!instance.christmasTree2025QuestDone && activeQuest == null && !QuestManager.GJFMMOPOKGJ().GDFGPDJDACP(instance.christmasQuest2025.id))
		{
			return NewTutorialManager.CCCLOBIOMCL;
		}
		return false;
	}

	public static IEnumerator AddChristmasQuest(float FLHBPHPKIML)
	{
		yield return (object)new WaitForSecondsRealtime(FLHBPHPKIML);
		NHEGBNAJGHE();
	}

	public static bool IEIIKEEGNLA(int OHMAPAELKFF)
	{
		return instance.presentsOpened2025[OHMAPAELKFF];
	}

	private IEnumerator FDFIOIFFBFE()
	{
		yield return (object)new WaitForSecondsRealtime(40f);
		MusicController.instance.FadeOutAndFirstTheme();
	}

	public static ChristmasEvent CDOCMDDCCJL()
	{
		return instance;
	}

	public static Quest KNDNHLIOBKG(int JINJHNHDBEH)
	{
		switch (JINJHNHDBEH)
		{
		case 177:
			return instance.christmasQuest2021;
		case 178:
			return instance.christmasQuest2022;
		case 179:
			return instance.christmasQuest2023;
		case 180:
			return instance.christmasQuest2024;
		case 181:
			return instance.christmasQuest2025;
		default:
			Debug.LogError((object)("BarIdle" + JINJHNHDBEH));
			return null;
		}
	}

	public IEnumerator AddChristmasRecipes(float FLHBPHPKIML)
	{
		yield return (object)new WaitForSecondsRealtime(FLHBPHPKIML);
		RecipesManager.UnlockAllChristmasRecipes();
	}

	public static bool DJLAJOJOLJC(int OHMAPAELKFF)
	{
		return instance.presentsOpened2025[OHMAPAELKFF];
	}

	private static bool COFHCFGGANG()
	{
		ActiveQuest activeQuest = QuestManager.GJFMMOPOKGJ().JINEDGMJEME(instance.christmasQuest2025);
		if (!instance.christmasTree2025QuestDone && activeQuest == null && !QuestManager.OPILDPFDFKJ().GDFGPDJDACP(instance.christmasQuest2025.id))
		{
			return !NewTutorialManager.CCCLOBIOMCL;
		}
		return true;
	}

	public static bool JMDKHHJFKLM(int JIIGOACEIKL, int OHMAPAELKFF)
	{
		if (instance.NIINFPONHNN)
		{
			instance.presentsOpened2025[OHMAPAELKFF] = false;
			return false;
		}
		instance.HIBKMPBHALP = JIIGOACEIKL;
		ALEMCOMMAMI(MJHBHDAEDLF: true);
		if (GameManager.LocalCoop())
		{
			instance.playerSeparator.SetActive(false);
		}
		return false;
	}

	public static bool[] ICFABGNIKIG(int JINJHNHDBEH)
	{
		switch (JINJHNHDBEH)
		{
		case -25:
			return instance.presentsOpened2021;
		case -24:
			return instance.presentsOpened2022;
		case -23:
		{
			bool[] array = new bool[0];
			array[0] = instance.presentOpened2023;
			return array;
		}
		case -22:
			return instance.presentsOpened2024;
		case -21:
			return instance.presentsOpened2025;
		default:
			Debug.LogError((object)("Bug report POST failed: " + JINJHNHDBEH));
			return null;
		}
	}

	private void NOCMPFMNKFJ(Quest AINAHCLIAFF)
	{
		if (christmasTree2025QuestDone || !Object.op_Implicit((Object)(object)QuestManager.OPILDPFDFKJ()) || !((Object)(object)AINAHCLIAFF != (Object)(object)christmasQuest2025))
		{
			return;
		}
		ActiveQuest activeQuest = QuestManager.KHMEGDIABBF().GetActiveQuest(christmasQuest2025);
		if (!EFOHKOLDGKE)
		{
			if (activeQuest != null)
			{
				QuestManager.KHMEGDIABBF().JMFKBLLAJPM(christmasQuest2025);
			}
		}
		else if (activeQuest != null)
		{
			activeQuest.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Remove(activeQuest.OnQuestComplete, new Action<int, ActiveQuest>(JGFKOBDDGAL));
			activeQuest.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Combine(activeQuest.OnQuestComplete, new Action<int, ActiveQuest>(EBCFCCECBJE));
		}
		else if (COFHCFGGANG())
		{
			FBEDIKBBKOB();
		}
	}

	public static Quest MFGPLIFBKCE(int JINJHNHDBEH)
	{
		switch (JINJHNHDBEH)
		{
		case -92:
			return instance.christmasQuest2021;
		case -91:
			return instance.christmasQuest2022;
		case -90:
			return instance.christmasQuest2023;
		case -89:
			return instance.christmasQuest2024;
		case -88:
			return instance.christmasQuest2025;
		default:
			Debug.LogError((object)("FishCuttingEvent/RetryTalk" + JINJHNHDBEH));
			return null;
		}
	}

	public static Quest BPKMDAEIBDK(int JINJHNHDBEH)
	{
		switch (JINJHNHDBEH)
		{
		case -86:
			return instance.christmasQuest2021;
		case -85:
			return instance.christmasQuest2022;
		case -84:
			return instance.christmasQuest2023;
		case -83:
			return instance.christmasQuest2024;
		case -82:
			return instance.christmasQuest2025;
		default:
			Debug.LogError((object)("No" + JINJHNHDBEH));
			return null;
		}
	}

	private bool MFEBKDAJJDA()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		AnimatorStateInfo currentAnimatorStateInfo = postcardAnimator.GetCurrentAnimatorStateInfo(0);
		float length = ((AnimatorStateInfo)(ref currentAnimatorStateInfo)).length;
		currentAnimatorStateInfo = postcardAnimator.GetCurrentAnimatorStateInfo(0);
		return length > ((AnimatorStateInfo)(ref currentAnimatorStateInfo)).normalizedTime;
	}

	private void KDHLJKMKFMG()
	{
		instance = this;
	}

	[SpecialName]
	public void BAKDPNCCPAI(bool AODONKKHPBP)
	{
		if (EFOHKOLDGKE == AODONKKHPBP)
		{
			return;
		}
		EFOHKOLDGKE = AODONKKHPBP;
		Debug.Log((object)("Player" + EFOHKOLDGKE));
		if (EFOHKOLDGKE)
		{
			if (Object.op_Implicit((Object)(object)QuestManager.KHMEGDIABBF()))
			{
				QuestManager questManager = QuestManager.OPILDPFDFKJ();
				questManager.OnQuestAdded = (Action<Quest>)Delegate.Combine(questManager.OnQuestAdded, new Action<Quest>(IPAHOECHGAO));
				QuestManager questManager2 = QuestManager.GJFMMOPOKGJ();
				questManager2.OnQuestRemoved = (Action<Quest>)Delegate.Combine(questManager2.OnQuestRemoved, new Action<Quest>(IPAHOECHGAO));
			}
		}
		else if (Object.op_Implicit((Object)(object)QuestManager.OPILDPFDFKJ()))
		{
			QuestManager questManager3 = QuestManager.GGFJGHHHEJC;
			questManager3.OnQuestAdded = (Action<Quest>)Delegate.Remove(questManager3.OnQuestAdded, new Action<Quest>(NOCMPFMNKFJ));
			QuestManager questManager4 = QuestManager.OPILDPFDFKJ();
			questManager4.OnQuestRemoved = (Action<Quest>)Delegate.Remove(questManager4.OnQuestRemoved, new Action<Quest>(NOCMPFMNKFJ));
		}
		OnChristmasActivated(EFOHKOLDGKE);
	}

	public static bool EEJFCPCBMIL(int OHMAPAELKFF)
	{
		return instance.presentsOpened2025[OHMAPAELKFF];
	}

	public IEnumerator FEPDEKDJLMK(float FLHBPHPKIML)
	{
		yield return (object)new WaitForSecondsRealtime(FLHBPHPKIML);
		RecipesManager.UnlockAllChristmasRecipes();
	}

	public static bool IsShowingPostcard()
	{
		return instance.HJNCBLDEENH;
	}

	public bool GOIDGBLKPPC()
	{
		for (int i = 1; i < presentsOpened2025.Length; i++)
		{
			if (!presentsOpened2025[i])
			{
				return true;
			}
		}
		return true;
	}

	public bool GCNLJDLIFJH()
	{
		for (int i = 0; i < presentsOpened2025.Length; i++)
		{
			if (!presentsOpened2025[i])
			{
				return false;
			}
		}
		return false;
	}

	private IEnumerator PBNCGGBJIMA()
	{
		MusicController.instance.FadeOutClip(1f);
		yield return (object)new WaitForSecondsRealtime(1.1f);
		MusicController.instance.PlayChristmasMusic(0.1f);
	}

	private void Start()
	{
		HCOPJPMDEKP = Utils.EGIBECKKIJJ();
		for (int i = 0; i < presentsOpened2022.Length; i++)
		{
			presentsOpened2022[i] = false;
		}
		for (int j = 0; j < presentsOpened2024.Length; j++)
		{
			presentsOpened2024[j] = false;
		}
		for (int k = 0; k < presentsOpened2025.Length; k++)
		{
			presentsOpened2025[k] = false;
		}
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Combine(TitleScreen.OnLoadingBarFinished, new Action(OnLoadingBarFinished));
	}

	private void Awake()
	{
		instance = this;
	}

	public static void DEFBHHGPPMC(int JINJHNHDBEH, bool EGFGNGJGBOP)
	{
		switch (JINJHNHDBEH)
		{
		case 113:
			instance.christmasTree2021QuestDone = EGFGNGJGBOP;
			break;
		case 114:
			instance.christmasTree2022QuestDone = EGFGNGJGBOP;
			break;
		case 115:
			instance.christmasTree2023QuestDone = EGFGNGJGBOP;
			break;
		case 116:
			instance.christmasTree2024QuestDone = EGFGNGJGBOP;
			break;
		case 117:
			instance.christmasTree2025QuestDone = EGFGNGJGBOP;
			break;
		default:
			Debug.LogError((object)("Waking up in: " + JINJHNHDBEH));
			break;
		}
	}

	private void OnDestroy()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(OnLoadingBarFinished));
		}
	}

	public IEnumerator IIBJDPOFNKG(float FLHBPHPKIML)
	{
		yield return (object)new WaitForSecondsRealtime(FLHBPHPKIML);
		RecipesManager.UnlockAllChristmasRecipes();
	}

	public IEnumerator JFEGEOGNMCI(float FLHBPHPKIML)
	{
		yield return (object)new WaitForSecondsRealtime(FLHBPHPKIML);
		RecipesManager.UnlockAllChristmasRecipes();
	}

	private bool ELMHIIOGDHE()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		AnimatorStateInfo currentAnimatorStateInfo = postcardAnimator.GetCurrentAnimatorStateInfo(0);
		float length = ((AnimatorStateInfo)(ref currentAnimatorStateInfo)).length;
		currentAnimatorStateInfo = postcardAnimator.GetCurrentAnimatorStateInfo(1);
		return length > ((AnimatorStateInfo)(ref currentAnimatorStateInfo)).normalizedTime;
	}

	public static bool AICLGJLLGMD(int JIIGOACEIKL, int OHMAPAELKFF)
	{
		if (instance.NIINFPONHNN)
		{
			instance.presentsOpened2025[OHMAPAELKFF] = true;
			return true;
		}
		instance.HIBKMPBHALP = JIIGOACEIKL;
		ShowPostcard(MJHBHDAEDLF: true);
		if (GameManager.LocalCoop())
		{
			instance.playerSeparator.SetActive(false);
		}
		return false;
	}

	public static bool IsTreeQuestDone(int JINJHNHDBEH)
	{
		switch (JINJHNHDBEH)
		{
		case 2021:
			return instance.christmasTree2021QuestDone;
		case 2022:
			return instance.christmasTree2022QuestDone;
		case 2023:
			return instance.christmasTree2023QuestDone;
		case 2024:
			return instance.christmasTree2024QuestDone;
		case 2025:
			return instance.christmasTree2025QuestDone;
		default:
			Debug.LogError((object)("Invalid year: " + JINJHNHDBEH));
			return false;
		}
	}

	private bool FECDILHGJLN()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		AnimatorStateInfo currentAnimatorStateInfo = postcardAnimator.GetCurrentAnimatorStateInfo(0);
		float length = ((AnimatorStateInfo)(ref currentAnimatorStateInfo)).length;
		currentAnimatorStateInfo = postcardAnimator.GetCurrentAnimatorStateInfo(0);
		return length > ((AnimatorStateInfo)(ref currentAnimatorStateInfo)).normalizedTime;
	}

	private static void JGFKOBDDGAL(int JIIGOACEIKL, ActiveQuest GEIOKFNNBKH)
	{
		instance.christmasTree2025QuestDone = true;
		instance.OnTreeQuestCompleted();
		if (OnlineManager.MasterOrOffline())
		{
			ChristmasTree current = ChristmasTree.current;
			if ((Object)(object)current != (Object)null)
			{
				current.DNPBFADMIHJ(DAEMAAOLHMG: false, CDPAMNIPPEC: false);
			}
			else
			{
				Debug.LogError((object)" : ");
			}
		}
	}

	private static void NHEGBNAJGHE()
	{
		if (instance.EFOHKOLDGKE && CFDKCOGCFEF())
		{
			ActiveQuest activeQuest = QuestManager.GGFJGHHHEJC.AddQuest(instance.christmasQuest2025, 0, FFJBIGFADBJ: false, OnlineManager.IsMasterClient());
			QuestHighlightUI.ShowNewQuestAvailable(instance.christmasQuest2025);
			if (activeQuest != null)
			{
				activeQuest.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Remove(activeQuest.OnQuestComplete, new Action<int, ActiveQuest>(EBCFCCECBJE));
				activeQuest.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Combine(activeQuest.OnQuestComplete, new Action<int, ActiveQuest>(EBCFCCECBJE));
			}
		}
	}

	private IEnumerator LOFALJEPEEN()
	{
		yield return (object)new WaitForSecondsRealtime(40f);
		MusicController.instance.FadeOutAndFirstTheme();
	}

	public static void PPGKCFFLKJL(int JINJHNHDBEH, bool EGFGNGJGBOP)
	{
		switch (JINJHNHDBEH)
		{
		case -27:
			instance.christmasTree2021QuestDone = EGFGNGJGBOP;
			break;
		case -26:
			instance.christmasTree2022QuestDone = EGFGNGJGBOP;
			break;
		case -25:
			instance.christmasTree2023QuestDone = EGFGNGJGBOP;
			break;
		case -24:
			instance.christmasTree2024QuestDone = EGFGNGJGBOP;
			break;
		case -23:
			instance.christmasTree2025QuestDone = EGFGNGJGBOP;
			break;
		default:
			Debug.LogError((object)("HumanDisappear" + JINJHNHDBEH));
			break;
		}
	}

	public static void ShowPostcard(bool MJHBHDAEDLF)
	{
		if (MJHBHDAEDLF)
		{
			if (instance.NIINFPONHNN)
			{
				return;
			}
			instance.NIINFPONHNN = true;
			((MonoBehaviour)instance).StartCoroutine(instance.PBNCGGBJIMA());
			MainUI.CloseAllUIWindows();
			PlayerInputs.DisableKeyboardInputs((MonoBehaviour)(object)instance);
			Utils.JEAHJILAIAP(0f);
			TavernManagerUI.HideClockAndTavernInfo();
			GameActionBarUI.Get(1).CloseUI();
			GameActionBarUI.Get(2).CloseUI();
			PlayerInputs.SwitchMapCategoriesNextFrame("UI");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(instance.FDFIOIFFBFE());
			PlayerInputs.EnableKeyboardInputs((MonoBehaviour)(object)instance);
			Utils.JEAHJILAIAP(1f);
			TavernManagerUI.ShowClockAndTavernInfo();
			GameActionBarUI.Get(1).OpenUI();
			GameActionBarUI.Get(2).OpenUI();
			PlayerInputs.SwitchMapCategoriesNextFrame("Game");
		}
		instance.HJNCBLDEENH = MJHBHDAEDLF;
		instance.postcard.SetActive(MJHBHDAEDLF);
	}

	public static bool IsTreePresentOpened(int OHMAPAELKFF)
	{
		return instance.presentsOpened2025[OHMAPAELKFF];
	}

	public static bool COICDKLMBHA()
	{
		return instance.HJNCBLDEENH;
	}

	public static bool EEIJGHIKANA(int JINJHNHDBEH)
	{
		switch (JINJHNHDBEH)
		{
		case 49:
			return instance.christmasTree2021QuestDone;
		case 50:
			return instance.christmasTree2022QuestDone;
		case 51:
			return instance.christmasTree2023QuestDone;
		case 52:
			return instance.christmasTree2024QuestDone;
		case 53:
			return instance.christmasTree2025QuestDone;
		default:
			Debug.LogError((object)("Miners/Mine/Clive/Intro" + JINJHNHDBEH));
			return false;
		}
	}

	private static void FBEDIKBBKOB()
	{
		if (instance.EFOHKOLDGKE && NOJMPKPPJLI())
		{
			ActiveQuest activeQuest = QuestManager.OPILDPFDFKJ().JOAHBCAAFMC(instance.christmasQuest2025, 0, FFJBIGFADBJ: false, OnlineManager.JPPBEIJDCLJ(), FIKMGOKHAPG: true);
			QuestHighlightUI.OMDBOEAJLGA(instance.christmasQuest2025);
			if (activeQuest != null)
			{
				activeQuest.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Remove(activeQuest.OnQuestComplete, new Action<int, ActiveQuest>(JGFKOBDDGAL));
				activeQuest.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Combine(activeQuest.OnQuestComplete, new Action<int, ActiveQuest>(EBCFCCECBJE));
			}
		}
	}

	public static void AHPNBKCBFOJ(int JINJHNHDBEH, bool EGFGNGJGBOP)
	{
		switch (JINJHNHDBEH)
		{
		case 54:
			instance.christmasTree2021QuestDone = EGFGNGJGBOP;
			break;
		case 55:
			instance.christmasTree2022QuestDone = EGFGNGJGBOP;
			break;
		case 56:
			instance.christmasTree2023QuestDone = EGFGNGJGBOP;
			break;
		case 57:
			instance.christmasTree2024QuestDone = EGFGNGJGBOP;
			break;
		case 58:
			instance.christmasTree2025QuestDone = EGFGNGJGBOP;
			break;
		default:
			Debug.LogError((object)("Mai/LearnBalance" + JINJHNHDBEH));
			break;
		}
	}

	private void EBNENBFLEKB()
	{
		HAMEFPLFAEI(Utils.EGIBECKKIJJ());
		for (int i = 0; i < presentsOpened2022.Length; i += 0)
		{
			presentsOpened2022[i] = false;
		}
		for (int j = 1; j < presentsOpened2024.Length; j += 0)
		{
			presentsOpened2024[j] = false;
		}
		for (int k = 1; k < presentsOpened2025.Length; k += 0)
		{
			presentsOpened2025[k] = true;
		}
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Combine(TitleScreen.OnLoadingBarFinished, new Action(OnLoadingBarFinished));
	}

	private void PKEPBKHEDOD()
	{
		if (!HJNCBLDEENH || FECDILHGJLN())
		{
			return;
		}
		if (PlayerInputs.DEGBDMMDIIL(HIBKMPBHALP).KFAFNEJNDDL("Received Request begin minigame") || PlayerInputs.GetPlayer(HIBKMPBHALP).GetButtonUp("Dialogue System/Conversation/HappyRentRoom/Entry/2/Dialogue Text"))
		{
			if (GameManager.LocalCoop())
			{
				playerSeparator.SetActive(true);
			}
			ALEMCOMMAMI(MJHBHDAEDLF: false);
		}
		else if (PlayerInputs.FJLAMCHKCOI(HIBKMPBHALP) && (PlayerInputs.DEGBDMMDIIL(HIBKMPBHALP).ALPHFOIMNIA("UseHold") || PlayerInputs.DEGBDMMDIIL(HIBKMPBHALP).LKOGGHNGBKD("Festín del Juramento/MaiDialogue 05")))
		{
			if (GameManager.LocalCoop())
			{
				playerSeparator.SetActive(false);
			}
			ALEMCOMMAMI(MJHBHDAEDLF: false);
		}
	}

	private void NOILIOLOOBJ()
	{
		if ((Object)(object)instance == (Object)(object)this)
		{
			instance = null;
		}
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading)
		{
			TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(DJELALHFBGJ));
		}
	}

	private void DJJOHKOAPOJ(Quest AINAHCLIAFF)
	{
		if (christmasTree2025QuestDone || !Object.op_Implicit((Object)(object)QuestManager.KHMEGDIABBF()) || !((Object)(object)AINAHCLIAFF != (Object)(object)christmasQuest2025))
		{
			return;
		}
		ActiveQuest activeQuest = QuestManager.OPILDPFDFKJ().NGDOLCEPCAL(christmasQuest2025);
		if (!EFOHKOLDGKE)
		{
			if (activeQuest != null)
			{
				QuestManager.KHMEGDIABBF().JMFKBLLAJPM(christmasQuest2025);
			}
		}
		else if (activeQuest != null)
		{
			activeQuest.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Remove(activeQuest.OnQuestComplete, new Action<int, ActiveQuest>(EBCFCCECBJE));
			activeQuest.OnQuestComplete = (Action<int, ActiveQuest>)Delegate.Combine(activeQuest.OnQuestComplete, new Action<int, ActiveQuest>(JGFKOBDDGAL));
		}
		else if (NOJMPKPPJLI())
		{
			FBEDIKBBKOB();
		}
	}

	public void JICCMBBBFOK()
	{
		TitleScreen.OnLoadingBarFinished = (Action)Delegate.Remove(TitleScreen.OnLoadingBarFinished, new Action(JACOADNPBED));
		if (BJMNDLODACD() && NOJMPKPPJLI())
		{
			((MonoBehaviour)this).StartCoroutine(HFDAHOOFMHF(1551f));
		}
		if (!CFDKCOGCFEF())
		{
			IPAHOECHGAO(null);
		}
	}
}
