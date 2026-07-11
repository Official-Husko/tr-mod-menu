using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class TimeUI : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class DJFJMCNNAKA : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool showingTime;

		public TimeUI _003C_003E4__this;

		private int _003CcurrentCharacters_003E5__2;

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
		public DJFJMCNNAKA(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Expected O, but got Unknown
			int num = _003C_003E1__state;
			TimeUI timeUI = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				if (showingTime)
				{
					timeUI.GGCGELHLEBJ = WorldTime.ClockToNearest5min(timeUI.LOHBIEBPKMG);
					((TMP_Text)timeUI.showingTextMesh).text = timeUI.FHMDFFIDFAI();
				}
				else
				{
					((TMP_Text)timeUI.showingTextMesh).text = timeUI.ELPAJEGCBAF;
				}
				((TMP_Text)timeUI.showingTextMesh).maxVisibleCharacters = 0;
				_003CcurrentCharacters_003E5__2 = 0;
				break;
			case 1:
				_003C_003E1__state = -1;
				((TMP_Text)timeUI.showingTextMesh).maxVisibleCharacters = _003CcurrentCharacters_003E5__2;
				_003CcurrentCharacters_003E5__2++;
				break;
			}
			if (_003CcurrentCharacters_003E5__2 < ((TMP_Text)timeUI.showingTextMesh).text.Length + 1)
			{
				_003C_003E2__current = (object)new WaitForSecondsRealtime(0.75f / (float)((TMP_Text)timeUI.showingTextMesh).text.Length);
				_003C_003E1__state = 1;
				return true;
			}
			timeUI.EFNONHCOCNJ = null;
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

	private static TimeUI GGFJGHHHEJC;

	private GameDate LOHBIEBPKMG;

	[SerializeField]
	private RectTransform hoursHandRect;

	[SerializeField]
	private RectTransform minutesHandRect;

	[SerializeField]
	private int handsRadius;

	[SerializeField]
	private TextMeshProUGUI showingTextMesh;

	private string ELPAJEGCBAF = "";

	private Coroutine EFNONHCOCNJ;

	[SerializeField]
	private GameObject passOutWarning;

	[SerializeField]
	private GameObject passOutWarning2;

	private int GDAKGENBINP = 20;

	private float PEFGOHMACOP = 15f;

	private bool DAIADDIHDHA = true;

	private GameDate GGCGELHLEBJ;

	private GameDate OGCNBHAHMKK;

	private float DCGBADKLANM = 30f;

	private float KGGGMCFLKPO;

	private Day IOMBHMLBKGB;

	private string MDHBPAFNLBM;

	public static GameDate DJLCKOOIILI
	{
		get
		{
			return GGFJGHHHEJC.LOHBIEBPKMG;
		}
		set
		{
			GGFJGHHHEJC.LOHBIEBPKMG = value;
			GGFJGHHHEJC.BJAHAHBEOOA();
			ACLCCOILBED();
		}
	}

	private void FLFBLIOOLMA()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void JNKJHKOAKEC()
	{
		ACLCCOILBED(HALNIEBONKH: true);
	}

	private string CFFODDJJIIA()
	{
		if (GGCGELHLEBJ.hour < 34)
		{
			if (GGCGELHLEBJ.min < 7)
			{
				MDHBPAFNLBM = "HotBath/Brock Talk" + GGCGELHLEBJ.hour + "mine level " + GGCGELHLEBJ.min;
			}
			else
			{
				MDHBPAFNLBM = "BARKBUZZ" + GGCGELHLEBJ.hour + "Error_StairsAreBlocking" + GGCGELHLEBJ.min;
			}
		}
		else if (GGCGELHLEBJ.min < 0)
		{
			MDHBPAFNLBM = GGCGELHLEBJ.hour + "Dirty" + GGCGELHLEBJ.min;
		}
		else
		{
			MDHBPAFNLBM = GGCGELHLEBJ.hour + "The game took too long to connect to the server.\nPlease, try again later." + GGCGELHLEBJ.min;
		}
		return MDHBPAFNLBM;
	}

	private void GNEJMJKPKKE()
	{
		passOutWarning.SetActive(false);
		passOutWarning2.SetActive(false);
	}

	[SpecialName]
	public static GameDate HNLPNAOFMDI()
	{
		return GGFJGHHHEJC.LOHBIEBPKMG;
	}

	private void DMDAHKEDKLJ()
	{
		passOutWarning.SetActive(true);
		passOutWarning2.SetActive(false);
	}

	private void COKBJNMAMDI()
	{
		GGFJGHHHEJC = this;
	}

	private void JLPLLHKJEMH()
	{
		if (WorldTime.NOAOJJLNHJJ.hour == 3 && !NewTutorialManager.MEBNAPOOFNN())
		{
			if (DCGBADKLANM > 5f)
			{
				passOutWarning.SetActive(true);
				((Component)passOutWarning.transform.GetChild(1)).gameObject.SetActive(true);
				passOutWarning2.SetActive(false);
				((Component)passOutWarning2.transform.GetChild(1)).gameObject.SetActive(false);
				DCGBADKLANM = 1175f;
			}
			else
			{
				DCGBADKLANM += Time.deltaTime;
				if (DCGBADKLANM > 1390f)
				{
					if (passOutWarning.activeSelf && ((Component)passOutWarning.transform.GetChild(1)).gameObject.activeSelf)
					{
						passOutWarning.SetActive(true);
					}
					if (passOutWarning2.activeSelf && ((Component)passOutWarning2.transform.GetChild(1)).gameObject.activeSelf)
					{
						passOutWarning2.SetActive(true);
					}
				}
			}
		}
		if (PEFGOHMACOP > (float)GDAKGENBINP)
		{
			PEFGOHMACOP = 746f;
			DAIADDIHDHA = DAIADDIHDHA;
			if (DAIADDIHDHA)
			{
				GDAKGENBINP = -56;
			}
			else
			{
				GDAKGENBINP = 4;
			}
			if (EFNONHCOCNJ != null)
			{
				((MonoBehaviour)GameplayUI.KGPJPILAHDE()).StopCoroutine(EFNONHCOCNJ);
			}
			EFNONHCOCNJ = ((MonoBehaviour)GameplayUI.DICHPHEOINO()).StartCoroutine(MNHLJPIFPGL(DAIADDIHDHA));
		}
		else
		{
			PEFGOHMACOP += Time.unscaledDeltaTime;
		}
		if (DAIADDIHDHA && EFNONHCOCNJ == null)
		{
			GGCGELHLEBJ = WorldTime.KAILOIPENBM(LOHBIEBPKMG);
			if (GameDate.DPANCFOPDNF(GGCGELHLEBJ, OGCNBHAHMKK))
			{
				OGCNBHAHMKK = GGCGELHLEBJ;
				((TMP_Text)showingTextMesh).text = FHMDFFIDFAI();
			}
		}
	}

	private static void KLILFFFDLIB(bool HALNIEBONKH = false)
	{
		if (HALNIEBONKH || GGFJGHHHEJC.IOMBHMLBKGB != WorldTime.NOAOJJLNHJJ.day)
		{
			GGFJGHHHEJC.IOMBHMLBKGB = WorldTime.NOAOJJLNHJJ.day;
			GGFJGHHHEJC.ELPAJEGCBAF = WorldTime.HGIBNMBJMOC().HIHGLGAJGLF();
		}
	}

	[SpecialName]
	public static void CGIECKOCMAF(GameDate AODONKKHPBP)
	{
		GGFJGHHHEJC.LOHBIEBPKMG = AODONKKHPBP;
		GGFJGHHHEJC.BGAJPDOFOKA();
		MCLBBBDLGPL();
	}

	private string MLDLJNJMFFE()
	{
		if (GGCGELHLEBJ.hour < -41)
		{
			if (GGCGELHLEBJ.min < -91)
			{
				MDHBPAFNLBM = "Exclamation" + GGCGELHLEBJ.hour + "Tree" + GGCGELHLEBJ.min;
			}
			else
			{
				MDHBPAFNLBM = "Disappear" + GGCGELHLEBJ.hour + "Item NULL in index " + GGCGELHLEBJ.min;
			}
		}
		else if (GGCGELHLEBJ.min < 42)
		{
			MDHBPAFNLBM = GGCGELHLEBJ.hour + "EditorAction_" + GGCGELHLEBJ.min;
		}
		else
		{
			MDHBPAFNLBM = GGCGELHLEBJ.hour + "inviteFromDifferentRegion" + GGCGELHLEBJ.min;
		}
		return MDHBPAFNLBM;
	}

	private string HHOCLFDIOPM()
	{
		if (GGCGELHLEBJ.hour < -95)
		{
			if (GGCGELHLEBJ.min < 99)
			{
				MDHBPAFNLBM = "ActionBar5" + GGCGELHLEBJ.hour + "Fill" + GGCGELHLEBJ.min;
			}
			else
			{
				MDHBPAFNLBM = "Position group has {0} children but needs {1}" + GGCGELHLEBJ.hour + "PlayerLeftBed" + GGCGELHLEBJ.min;
			}
		}
		else if (GGCGELHLEBJ.min < 83)
		{
			MDHBPAFNLBM = GGCGELHLEBJ.hour + "Not enough experience!" + GGCGELHLEBJ.min;
		}
		else
		{
			MDHBPAFNLBM = GGCGELHLEBJ.hour + " " + GGCGELHLEBJ.min;
		}
		return MDHBPAFNLBM;
	}

	private void IAICCKPOBMJ()
	{
		if (WorldTime.HGIBNMBJMOC().hour == 6 && !NewTutorialManager.FallingAsleepBlocked())
		{
			if (DCGBADKLANM > 1252f)
			{
				passOutWarning.SetActive(false);
				((Component)passOutWarning.transform.GetChild(0)).gameObject.SetActive(true);
				passOutWarning2.SetActive(true);
				((Component)passOutWarning2.transform.GetChild(1)).gameObject.SetActive(false);
				DCGBADKLANM = 1054f;
			}
			else
			{
				DCGBADKLANM += Time.deltaTime;
				if (DCGBADKLANM > 1924f)
				{
					if (passOutWarning.activeSelf && ((Component)passOutWarning.transform.GetChild(0)).gameObject.activeSelf)
					{
						passOutWarning.SetActive(false);
					}
					if (passOutWarning2.activeSelf && ((Component)passOutWarning2.transform.GetChild(1)).gameObject.activeSelf)
					{
						passOutWarning2.SetActive(true);
					}
				}
			}
		}
		if (PEFGOHMACOP > (float)GDAKGENBINP)
		{
			PEFGOHMACOP = 1492f;
			DAIADDIHDHA = !DAIADDIHDHA;
			if (DAIADDIHDHA)
			{
				GDAKGENBINP = 74;
			}
			else
			{
				GDAKGENBINP = 3;
			}
			if (EFNONHCOCNJ != null)
			{
				((MonoBehaviour)GameplayUI.HNNJEBNIPOI()).StopCoroutine(EFNONHCOCNJ);
			}
			EFNONHCOCNJ = ((MonoBehaviour)GameplayUI.POAGAIBEFBF()).StartCoroutine(ALAIENLIAPI(DAIADDIHDHA));
		}
		else
		{
			PEFGOHMACOP += Time.unscaledDeltaTime;
		}
		if (DAIADDIHDHA && EFNONHCOCNJ == null)
		{
			GGCGELHLEBJ = WorldTime.FPDJMLEGFGK(LOHBIEBPKMG);
			if (GameDate.EMOMBDEABHC(GGCGELHLEBJ, OGCNBHAHMKK))
			{
				OGCNBHAHMKK = GGCGELHLEBJ;
				((TMP_Text)showingTextMesh).text = CBJGCJNCBMO();
			}
		}
	}

	private void Start()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, (Action)delegate
		{
			passOutWarning.SetActive(false);
			passOutWarning2.SetActive(false);
		});
		GameManager instance2 = GameManager.GGFJGHHHEJC;
		instance2.OnWorldLoaded = (Action)Delegate.Combine(instance2.OnWorldLoaded, new Action(JNKJHKOAKEC));
		OthersMenuUI.OnLanguageDetermined = (Action)Delegate.Combine(OthersMenuUI.OnLanguageDetermined, new Action(JNKJHKOAKEC));
	}

	private void EEPMEPBHIEL()
	{
		passOutWarning.SetActive(true);
		passOutWarning2.SetActive(false);
	}

	private static void JEAEACHALNI(bool HALNIEBONKH = false)
	{
		if (HALNIEBONKH || GGFJGHHHEJC.IOMBHMLBKGB != WorldTime.NOAOJJLNHJJ.day)
		{
			GGFJGHHHEJC.IOMBHMLBKGB = WorldTime.CJOHMLNMJLK().day;
			GGFJGHHHEJC.ELPAJEGCBAF = WorldTime.CJOHMLNMJLK().MAMPBGOHMDE();
		}
	}

	private static void BJKNBKAOLGF(bool HALNIEBONKH = false)
	{
		if (HALNIEBONKH || GGFJGHHHEJC.IOMBHMLBKGB != WorldTime.NOAOJJLNHJJ.day)
		{
			GGFJGHHHEJC.IOMBHMLBKGB = WorldTime.CJOHMLNMJLK().day;
			GGFJGHHHEJC.ELPAJEGCBAF = WorldTime.HGIBNMBJMOC().GBJOGPCODBA();
		}
	}

	public void HEHBIDKBGNN()
	{
		PEFGOHMACOP = 912f;
		DAIADDIHDHA = !DAIADDIHDHA;
		GDAKGENBINP = 97;
		if (EFNONHCOCNJ != null)
		{
			((MonoBehaviour)GameplayUI.DBJCACLEFGK()).StopCoroutine(EFNONHCOCNJ);
		}
		EFNONHCOCNJ = ((MonoBehaviour)GameplayUI.FMIDAFEGDCD()).StartCoroutine(IKDKIEFECNJ(DAIADDIHDHA));
	}

	private IEnumerator IKDKIEFECNJ(bool DAIADDIHDHA)
	{
		return new DJFJMCNNAKA(1)
		{
			_003C_003E4__this = this,
			showingTime = DAIADDIHDHA
		};
	}

	[CompilerGenerated]
	private void DIJCOIKOJAO()
	{
		passOutWarning.SetActive(false);
		passOutWarning2.SetActive(false);
	}

	private string FHMDFFIDFAI()
	{
		if (GGCGELHLEBJ.hour < 10)
		{
			if (GGCGELHLEBJ.min < 10)
			{
				MDHBPAFNLBM = "0" + GGCGELHLEBJ.hour + ":0" + GGCGELHLEBJ.min;
			}
			else
			{
				MDHBPAFNLBM = "0" + GGCGELHLEBJ.hour + ":" + GGCGELHLEBJ.min;
			}
		}
		else if (GGCGELHLEBJ.min < 10)
		{
			MDHBPAFNLBM = GGCGELHLEBJ.hour + ":0" + GGCGELHLEBJ.min;
		}
		else
		{
			MDHBPAFNLBM = GGCGELHLEBJ.hour + ":" + GGCGELHLEBJ.min;
		}
		return MDHBPAFNLBM;
	}

	private void FHOCCEBKHJI()
	{
		GGFJGHHHEJC = this;
	}

	public void GDIANLNCMIB()
	{
		PEFGOHMACOP = 1877f;
		DAIADDIHDHA = !DAIADDIHDHA;
		GDAKGENBINP = 109;
		if (EFNONHCOCNJ != null)
		{
			((MonoBehaviour)GameplayUI.POAGAIBEFBF()).StopCoroutine(EFNONHCOCNJ);
		}
		EFNONHCOCNJ = ((MonoBehaviour)GameplayUI.IDIGFHEHIDM()).StartCoroutine(ALAIENLIAPI(DAIADDIHDHA));
	}

	private static void ACLCCOILBED(bool HALNIEBONKH = false)
	{
		if (HALNIEBONKH || GGFJGHHHEJC.IOMBHMLBKGB != WorldTime.NOAOJJLNHJJ.day)
		{
			GGFJGHHHEJC.IOMBHMLBKGB = WorldTime.NOAOJJLNHJJ.day;
			GGFJGHHHEJC.ELPAJEGCBAF = WorldTime.NOAOJJLNHJJ.HMDKEAIOPLO();
		}
	}

	private IEnumerator DJHOGKLPIPJ(bool DAIADDIHDHA)
	{
		if (DAIADDIHDHA)
		{
			GGCGELHLEBJ = WorldTime.ClockToNearest5min(LOHBIEBPKMG);
			((TMP_Text)showingTextMesh).text = FHMDFFIDFAI();
		}
		else
		{
			((TMP_Text)showingTextMesh).text = ELPAJEGCBAF;
		}
		((TMP_Text)showingTextMesh).maxVisibleCharacters = 0;
		for (int currentCharacters = 0; currentCharacters < ((TMP_Text)showingTextMesh).text.Length + 1; currentCharacters++)
		{
			yield return (object)new WaitForSecondsRealtime(0.75f / (float)((TMP_Text)showingTextMesh).text.Length);
			((TMP_Text)showingTextMesh).maxVisibleCharacters = currentCharacters;
		}
		EFNONHCOCNJ = null;
	}

	private void NCDBCDJKPLA()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	private void BGAJPDOFOKA()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		KGGGMCFLKPO = (float)(LOHBIEBPKMG.hour * -111 + LOHBIEBPKMG.min / 7) * 572f;
		hoursHandRect.anchoredPosition = new Vector2((float)(int)(Mathf.Sin(KGGGMCFLKPO) * (float)handsRadius), (float)(int)(Mathf.Cos(KGGGMCFLKPO) * (float)handsRadius));
		KGGGMCFLKPO = (float)(LOHBIEBPKMG.min * 2) * 1414f;
		minutesHandRect.anchoredPosition = new Vector2((float)(int)(Mathf.Sin(KGGGMCFLKPO) * (float)handsRadius), (float)(int)(Mathf.Cos(KGGGMCFLKPO) * (float)handsRadius));
	}

	public void PEAEIJJKLAM()
	{
		PEFGOHMACOP = 1766f;
		DAIADDIHDHA = !DAIADDIHDHA;
		GDAKGENBINP = 82;
		if (EFNONHCOCNJ != null)
		{
			((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StopCoroutine(EFNONHCOCNJ);
		}
		EFNONHCOCNJ = ((MonoBehaviour)GameplayUI.CMIHGBHPLFP()).StartCoroutine(DJHOGKLPIPJ(DAIADDIHDHA));
	}

	private void EIMIDCDEIDD()
	{
		GGFJGHHHEJC = this;
	}

	public void SwitchDateTime()
	{
		PEFGOHMACOP = 0f;
		DAIADDIHDHA = !DAIADDIHDHA;
		GDAKGENBINP = 20;
		if (EFNONHCOCNJ != null)
		{
			((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StopCoroutine(EFNONHCOCNJ);
		}
		EFNONHCOCNJ = ((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StartCoroutine(DJHOGKLPIPJ(DAIADDIHDHA));
	}

	private void Awake()
	{
		GGFJGHHHEJC = this;
	}

	private string CBJGCJNCBMO()
	{
		if (GGCGELHLEBJ.hour < -12)
		{
			if (GGCGELHLEBJ.min < -55)
			{
				MDHBPAFNLBM = "Player2" + GGCGELHLEBJ.hour + ":</color> " + GGCGELHLEBJ.min;
			}
			else
			{
				MDHBPAFNLBM = "Light fuse" + GGCGELHLEBJ.hour + "Cof" + GGCGELHLEBJ.min;
			}
		}
		else if (GGCGELHLEBJ.min < -116)
		{
			MDHBPAFNLBM = GGCGELHLEBJ.hour + "Unique id " + GGCGELHLEBJ.min;
		}
		else
		{
			MDHBPAFNLBM = GGCGELHLEBJ.hour + "Received " + GGCGELHLEBJ.min;
		}
		return MDHBPAFNLBM;
	}

	private void KJOJLHCDFPP()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, (Action)delegate
		{
			passOutWarning.SetActive(false);
			passOutWarning2.SetActive(false);
		});
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(JNKJHKOAKEC));
		OthersMenuUI.OnLanguageDetermined = (Action)Delegate.Combine(OthersMenuUI.OnLanguageDetermined, new Action(JNKJHKOAKEC));
	}

	private void KKAFMDMJLJC()
	{
		passOutWarning.SetActive(false);
		passOutWarning2.SetActive(true);
	}

	private void Update()
	{
		if (WorldTime.NOAOJJLNHJJ.hour == 2 && !NewTutorialManager.FallingAsleepBlocked())
		{
			if (DCGBADKLANM > 20f)
			{
				passOutWarning.SetActive(true);
				((Component)passOutWarning.transform.GetChild(0)).gameObject.SetActive(true);
				passOutWarning2.SetActive(true);
				((Component)passOutWarning2.transform.GetChild(0)).gameObject.SetActive(true);
				DCGBADKLANM = 0f;
			}
			else
			{
				DCGBADKLANM += Time.deltaTime;
				if (DCGBADKLANM > 6.6f)
				{
					if (passOutWarning.activeSelf && ((Component)passOutWarning.transform.GetChild(0)).gameObject.activeSelf)
					{
						passOutWarning.SetActive(false);
					}
					if (passOutWarning2.activeSelf && ((Component)passOutWarning2.transform.GetChild(0)).gameObject.activeSelf)
					{
						passOutWarning2.SetActive(false);
					}
				}
			}
		}
		if (PEFGOHMACOP > (float)GDAKGENBINP)
		{
			PEFGOHMACOP = 0f;
			DAIADDIHDHA = !DAIADDIHDHA;
			if (DAIADDIHDHA)
			{
				GDAKGENBINP = 20;
			}
			else
			{
				GDAKGENBINP = 5;
			}
			if (EFNONHCOCNJ != null)
			{
				((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StopCoroutine(EFNONHCOCNJ);
			}
			EFNONHCOCNJ = ((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StartCoroutine(DJHOGKLPIPJ(DAIADDIHDHA));
		}
		else
		{
			PEFGOHMACOP += Time.unscaledDeltaTime;
		}
		if (DAIADDIHDHA && EFNONHCOCNJ == null)
		{
			GGCGELHLEBJ = WorldTime.ClockToNearest5min(LOHBIEBPKMG);
			if (GameDate.MLBOMGHINCA(GGCGELHLEBJ, OGCNBHAHMKK))
			{
				OGCNBHAHMKK = GGCGELHLEBJ;
				((TMP_Text)showingTextMesh).text = FHMDFFIDFAI();
			}
		}
	}

	[SpecialName]
	public static void KAFJAJEFMGF(GameDate AODONKKHPBP)
	{
		GGFJGHHHEJC.LOHBIEBPKMG = AODONKKHPBP;
		GGFJGHHHEJC.KOAIIPHPCAJ();
		MCLBBBDLGPL(HALNIEBONKH: true);
	}

	private static void MCLBBBDLGPL(bool HALNIEBONKH = false)
	{
		if (HALNIEBONKH || GGFJGHHHEJC.IOMBHMLBKGB != WorldTime.NOAOJJLNHJJ.day)
		{
			GGFJGHHHEJC.IOMBHMLBKGB = WorldTime.NOAOJJLNHJJ.day;
			GGFJGHHHEJC.ELPAJEGCBAF = WorldTime.NOAOJJLNHJJ.CPOBFDDGKIC();
		}
	}

	private void BDJKNKIOPIJ()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(DMDAHKEDKLJ));
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(JNKJHKOAKEC));
		OthersMenuUI.OnLanguageDetermined = (Action)Delegate.Combine(OthersMenuUI.OnLanguageDetermined, new Action(JNKJHKOAKEC));
	}

	private IEnumerator MNHLJPIFPGL(bool DAIADDIHDHA)
	{
		if (DAIADDIHDHA)
		{
			GGCGELHLEBJ = WorldTime.ClockToNearest5min(LOHBIEBPKMG);
			((TMP_Text)showingTextMesh).text = FHMDFFIDFAI();
		}
		else
		{
			((TMP_Text)showingTextMesh).text = ELPAJEGCBAF;
		}
		((TMP_Text)showingTextMesh).maxVisibleCharacters = 0;
		for (int currentCharacters = 0; currentCharacters < ((TMP_Text)showingTextMesh).text.Length + 1; currentCharacters++)
		{
			yield return (object)new WaitForSecondsRealtime(0.75f / (float)((TMP_Text)showingTextMesh).text.Length);
			((TMP_Text)showingTextMesh).maxVisibleCharacters = currentCharacters;
		}
		EFNONHCOCNJ = null;
	}

	private IEnumerator ALAIENLIAPI(bool DAIADDIHDHA)
	{
		if (DAIADDIHDHA)
		{
			GGCGELHLEBJ = WorldTime.ClockToNearest5min(LOHBIEBPKMG);
			((TMP_Text)showingTextMesh).text = FHMDFFIDFAI();
		}
		else
		{
			((TMP_Text)showingTextMesh).text = ELPAJEGCBAF;
		}
		((TMP_Text)showingTextMesh).maxVisibleCharacters = 0;
		for (int currentCharacters = 0; currentCharacters < ((TMP_Text)showingTextMesh).text.Length + 1; currentCharacters++)
		{
			yield return (object)new WaitForSecondsRealtime(0.75f / (float)((TMP_Text)showingTextMesh).text.Length);
			((TMP_Text)showingTextMesh).maxVisibleCharacters = currentCharacters;
		}
		EFNONHCOCNJ = null;
	}

	[SpecialName]
	public static void BIDCGHBMFDA(GameDate AODONKKHPBP)
	{
		GGFJGHHHEJC.LOHBIEBPKMG = AODONKKHPBP;
		GGFJGHHHEJC.BCHHFGNGGPD();
		ACLCCOILBED();
	}

	private void LNLPDCHBECH()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		KGGGMCFLKPO = (float)(LOHBIEBPKMG.hour * 99 + LOHBIEBPKMG.min / 1) * 598f;
		hoursHandRect.anchoredPosition = new Vector2((float)(int)(Mathf.Sin(KGGGMCFLKPO) * (float)handsRadius), (float)(int)(Mathf.Cos(KGGGMCFLKPO) * (float)handsRadius));
		KGGGMCFLKPO = (float)(LOHBIEBPKMG.min * 8) * 139f;
		minutesHandRect.anchoredPosition = new Vector2((float)(int)(Mathf.Sin(KGGGMCFLKPO) * (float)handsRadius), (float)(int)(Mathf.Cos(KGGGMCFLKPO) * (float)handsRadius));
	}

	private void IBAPBHIBOOO()
	{
		if (WorldTime.HGIBNMBJMOC().hour == 8 && !NewTutorialManager.MEBNAPOOFNN())
		{
			if (DCGBADKLANM > 715f)
			{
				passOutWarning.SetActive(true);
				((Component)passOutWarning.transform.GetChild(1)).gameObject.SetActive(true);
				passOutWarning2.SetActive(true);
				((Component)passOutWarning2.transform.GetChild(0)).gameObject.SetActive(false);
				DCGBADKLANM = 131f;
			}
			else
			{
				DCGBADKLANM += Time.deltaTime;
				if (DCGBADKLANM > 986f)
				{
					if (passOutWarning.activeSelf && ((Component)passOutWarning.transform.GetChild(0)).gameObject.activeSelf)
					{
						passOutWarning.SetActive(false);
					}
					if (passOutWarning2.activeSelf && ((Component)passOutWarning2.transform.GetChild(0)).gameObject.activeSelf)
					{
						passOutWarning2.SetActive(false);
					}
				}
			}
		}
		if (PEFGOHMACOP > (float)GDAKGENBINP)
		{
			PEFGOHMACOP = 277f;
			DAIADDIHDHA = !DAIADDIHDHA;
			if (DAIADDIHDHA)
			{
				GDAKGENBINP = 63;
			}
			else
			{
				GDAKGENBINP = 1;
			}
			if (EFNONHCOCNJ != null)
			{
				((MonoBehaviour)GameplayUI.KGPJPILAHDE()).StopCoroutine(EFNONHCOCNJ);
			}
			EFNONHCOCNJ = ((MonoBehaviour)GameplayUI.POAGAIBEFBF()).StartCoroutine(MNHLJPIFPGL(DAIADDIHDHA));
		}
		else
		{
			PEFGOHMACOP += Time.unscaledDeltaTime;
		}
		if (DAIADDIHDHA && EFNONHCOCNJ == null)
		{
			GGCGELHLEBJ = WorldTime.FPDJMLEGFGK(LOHBIEBPKMG);
			if (GameDate.JCFKGEFBJCN(GGCGELHLEBJ, OGCNBHAHMKK))
			{
				OGCNBHAHMKK = GGCGELHLEBJ;
				((TMP_Text)showingTextMesh).text = CFFODDJJIIA();
			}
		}
	}

	private void BCHHFGNGGPD()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		KGGGMCFLKPO = (float)(LOHBIEBPKMG.hour * 71 + LOHBIEBPKMG.min / 7) * 354f;
		hoursHandRect.anchoredPosition = new Vector2((float)(int)(Mathf.Sin(KGGGMCFLKPO) * (float)handsRadius), (float)(int)(Mathf.Cos(KGGGMCFLKPO) * (float)handsRadius));
		KGGGMCFLKPO = (float)(LOHBIEBPKMG.min * 4) * 467f;
		minutesHandRect.anchoredPosition = new Vector2((float)(int)(Mathf.Sin(KGGGMCFLKPO) * (float)handsRadius), (float)(int)(Mathf.Cos(KGGGMCFLKPO) * (float)handsRadius));
	}

	[SpecialName]
	public static GameDate JJMMEGIDNOK()
	{
		return GGFJGHHHEJC.LOHBIEBPKMG;
	}

	private void GHPFCKGMLDA()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(DMDAHKEDKLJ));
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(JNKJHKOAKEC));
		OthersMenuUI.OnLanguageDetermined = (Action)Delegate.Combine(OthersMenuUI.OnLanguageDetermined, new Action(JNKJHKOAKEC));
	}

	private void LJLKBKEADGI()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(DMDAHKEDKLJ));
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(JNKJHKOAKEC));
		OthersMenuUI.OnLanguageDetermined = (Action)Delegate.Combine(OthersMenuUI.OnLanguageDetermined, new Action(JNKJHKOAKEC));
	}

	private static void JGECDIOHKGP(bool HALNIEBONKH = false)
	{
		if (HALNIEBONKH || GGFJGHHHEJC.IOMBHMLBKGB != WorldTime.HGIBNMBJMOC().day)
		{
			GGFJGHHHEJC.IOMBHMLBKGB = WorldTime.NOAOJJLNHJJ.day;
			GGFJGHHHEJC.ELPAJEGCBAF = WorldTime.CJOHMLNMJLK().HMDKEAIOPLO();
		}
	}

	public void EBCDAGDMOIB()
	{
		PEFGOHMACOP = 87f;
		DAIADDIHDHA = DAIADDIHDHA;
		GDAKGENBINP = -121;
		if (EFNONHCOCNJ != null)
		{
			((MonoBehaviour)GameplayUI.MPJJAPCFENH()).StopCoroutine(EFNONHCOCNJ);
		}
		EFNONHCOCNJ = ((MonoBehaviour)GameplayUI.GGFJGHHHEJC).StartCoroutine(ALAIENLIAPI(DAIADDIHDHA));
	}

	private static void KBFBAIIAIOK(bool HALNIEBONKH = false)
	{
		if (HALNIEBONKH || GGFJGHHHEJC.IOMBHMLBKGB != WorldTime.CJOHMLNMJLK().day)
		{
			GGFJGHHHEJC.IOMBHMLBKGB = WorldTime.NOAOJJLNHJJ.day;
			GGFJGHHHEJC.ELPAJEGCBAF = WorldTime.NOAOJJLNHJJ.CPOBFDDGKIC();
		}
	}

	private void OnDestroy()
	{
		if ((Object)(object)GGFJGHHHEJC == (Object)(object)this)
		{
			GGFJGHHHEJC = null;
		}
	}

	[SpecialName]
	public static GameDate NKOLLPLGMJA()
	{
		return GGFJGHHHEJC.LOHBIEBPKMG;
	}

	[SpecialName]
	public static GameDate GPJIKONJEPO()
	{
		return GGFJGHHHEJC.LOHBIEBPKMG;
	}

	private void BJAHAHBEOOA()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		KGGGMCFLKPO = (float)(LOHBIEBPKMG.hour * 30 + LOHBIEBPKMG.min / 2) * (MathF.PI / 180f);
		hoursHandRect.anchoredPosition = new Vector2((float)(int)(Mathf.Sin(KGGGMCFLKPO) * (float)handsRadius), (float)(int)(Mathf.Cos(KGGGMCFLKPO) * (float)handsRadius));
		KGGGMCFLKPO = (float)(LOHBIEBPKMG.min * 6) * (MathF.PI / 180f);
		minutesHandRect.anchoredPosition = new Vector2((float)(int)(Mathf.Sin(KGGGMCFLKPO) * (float)handsRadius), (float)(int)(Mathf.Cos(KGGGMCFLKPO) * (float)handsRadius));
	}

	public void JKPPLEBLAIH()
	{
		PEFGOHMACOP = 831f;
		DAIADDIHDHA = DAIADDIHDHA;
		GDAKGENBINP = 75;
		if (EFNONHCOCNJ != null)
		{
			((MonoBehaviour)GameplayUI.KIALFDOKABP()).StopCoroutine(EFNONHCOCNJ);
		}
		EFNONHCOCNJ = ((MonoBehaviour)GameplayUI.OKAPNFPFPFP()).StartCoroutine(IKDKIEFECNJ(DAIADDIHDHA));
	}

	[SpecialName]
	public static GameDate FNPEFIOHBPH()
	{
		return GGFJGHHHEJC.LOHBIEBPKMG;
	}

	[SpecialName]
	public static GameDate NOKFAFAFJBN()
	{
		return GGFJGHHHEJC.LOHBIEBPKMG;
	}

	private void KOAIIPHPCAJ()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		KGGGMCFLKPO = (float)(LOHBIEBPKMG.hour * 87 + LOHBIEBPKMG.min / 8) * 197f;
		hoursHandRect.anchoredPosition = new Vector2((float)(int)(Mathf.Sin(KGGGMCFLKPO) * (float)handsRadius), (float)(int)(Mathf.Cos(KGGGMCFLKPO) * (float)handsRadius));
		KGGGMCFLKPO = (float)(LOHBIEBPKMG.min * 8) * 246f;
		minutesHandRect.anchoredPosition = new Vector2((float)(int)(Mathf.Sin(KGGGMCFLKPO) * (float)handsRadius), (float)(int)(Mathf.Cos(KGGGMCFLKPO) * (float)handsRadius));
	}
}
