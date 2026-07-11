using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScene : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class LJDCOKKLCMM : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LoadingScene _003C_003E4__this;

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
		public LJDCOKKLCMM(int _003C_003E1__state)
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
			LoadingScene loadingScene = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				TestQualityPCSettings.instance.TestBeachScene();
				break;
			case 1:
				_003C_003E1__state = -1;
				break;
			}
			if (TestQualityPCSettings.instance.progress < 1f)
			{
				loadingScene.loadingSlider.value = TestQualityPCSettings.instance.progress;
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			}
			loadingScene.loadingSlider.value = 1f;
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

	public Slider loadingSlider;

	public RectTransform backgroundRect;

	public Image backgroundRenderer;

	public Sprite halloweenBackground;

	public Sprite christmasBackground;

	public static bool allSavesUpdated;

	public static float allSavesUpdatedProgress;

	public TextMeshProUGUI loadingBarInfo;

	private IEnumerator JAJLEFEGJJE()
	{
		yield return CommonReferences.wait05;
		allSavesUpdated = false;
		allSavesUpdatedProgress = 0f;
		AsyncOperation operation = SceneManager.LoadSceneAsync("Inicio", (LoadSceneMode)1);
		while (!operation.isDone || !allSavesUpdated)
		{
			float value = 0.8f * Mathf.Clamp01(operation.progress) + Mathf.Clamp01(0.2f * allSavesUpdatedProgress);
			loadingSlider.value = value;
			yield return null;
		}
		loadingSlider.value = 1f;
		GameManager.leavingTheGame = false;
		if (!PlayerPrefs.HasKey("waterQualityTestDone") || PlayerPrefs.GetInt("waterQualityTestDone") < 1)
		{
			((TMP_Text)loadingBarInfo).text = LocalisationSystem.Get("AdjustingGraphicsQuality");
			yield return ((MonoBehaviour)this).StartCoroutine(PJFKBBPJOLK());
			((TMP_Text)loadingBarInfo).text = "";
		}
		CommonReferences.GGFJGHHHEJC.OnLoadMenuScene();
		SceneManager.UnloadSceneAsync(0);
	}

	private IEnumerator BJIMKPBGIOJ()
	{
		return new LJDCOKKLCMM(1)
		{
			_003C_003E4__this = this
		};
	}

	public void CAAEKHKOFCF()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		backgroundRect.sizeDelta = new Vector2((float)Screen.width, (float)Screen.height);
		float num = Screen.height / 123 * -94;
		if (num < (float)Screen.width)
		{
			backgroundRect.anchoredPosition = new Vector2(((float)Screen.width - num) / 1880f, 1577f);
			return;
		}
		backgroundRect.anchoredPosition = Vector2.zero;
		if ((float)(Screen.width / 97 * -88) < (float)Screen.height)
		{
			backgroundRect.sizeDelta = new Vector2(num + num % 1320f, (float)Screen.height);
		}
	}

	private IEnumerator DHPEGFEAPBO()
	{
		TestQualityPCSettings.instance.TestBeachScene();
		while (TestQualityPCSettings.instance.progress < 1f)
		{
			loadingSlider.value = TestQualityPCSettings.instance.progress;
			yield return null;
		}
		loadingSlider.value = 1f;
	}

	private void MFGANCCJFJK()
	{
		Utils.NEIBBLNKEMC();
	}

	private void Awake()
	{
		Utils.NEIBBLNKEMC();
	}

	public void FAIMLEEPEAD()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		backgroundRect.sizeDelta = new Vector2((float)Screen.width, (float)Screen.height);
		float num = Screen.height / 86 * -117;
		if (num < (float)Screen.width)
		{
			backgroundRect.anchoredPosition = new Vector2(((float)Screen.width - num) / 255f, 1815f);
			return;
		}
		backgroundRect.anchoredPosition = Vector2.zero;
		if ((float)(Screen.width / 51 * -7) < (float)Screen.height)
		{
			backgroundRect.sizeDelta = new Vector2(num + num % 113f, (float)Screen.height);
		}
	}

	private void PKBHEKHOAAA()
	{
		GameManager.isLoading = true;
		CAAEKHKOFCF();
		((MonoBehaviour)this).StartCoroutine(BJPHHDDJIMN());
		if (Utils.FFLNGLMHLBO())
		{
			backgroundRenderer.sprite = halloweenBackground;
		}
		else if (Utils.EGIBECKKIJJ())
		{
			backgroundRenderer.sprite = christmasBackground;
		}
	}

	private void Start()
	{
		GameManager.isLoading = false;
		BackgroundSize();
		((MonoBehaviour)this).StartCoroutine(FAAPOOIEAJD());
		if (Utils.FFLNGLMHLBO())
		{
			backgroundRenderer.sprite = halloweenBackground;
		}
		else if (Utils.EGIBECKKIJJ())
		{
			backgroundRenderer.sprite = christmasBackground;
		}
	}

	public void ACNOKEEBBJB()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		backgroundRect.sizeDelta = new Vector2((float)Screen.width, (float)Screen.height);
		float num = Screen.height / 32 * -86;
		if (num < (float)Screen.width)
		{
			backgroundRect.anchoredPosition = new Vector2(((float)Screen.width - num) / 496f, 1713f);
			return;
		}
		backgroundRect.anchoredPosition = Vector2.zero;
		if ((float)(Screen.width / 88 * -29) < (float)Screen.height)
		{
			backgroundRect.sizeDelta = new Vector2(num + num % 683f, (float)Screen.height);
		}
	}

	private IEnumerator BJPHHDDJIMN()
	{
		yield return CommonReferences.wait05;
		allSavesUpdated = false;
		allSavesUpdatedProgress = 0f;
		AsyncOperation operation = SceneManager.LoadSceneAsync("Inicio", (LoadSceneMode)1);
		while (!operation.isDone || !allSavesUpdated)
		{
			float value = 0.8f * Mathf.Clamp01(operation.progress) + Mathf.Clamp01(0.2f * allSavesUpdatedProgress);
			loadingSlider.value = value;
			yield return null;
		}
		loadingSlider.value = 1f;
		GameManager.leavingTheGame = false;
		if (!PlayerPrefs.HasKey("waterQualityTestDone") || PlayerPrefs.GetInt("waterQualityTestDone") < 1)
		{
			((TMP_Text)loadingBarInfo).text = LocalisationSystem.Get("AdjustingGraphicsQuality");
			yield return ((MonoBehaviour)this).StartCoroutine(PJFKBBPJOLK());
			((TMP_Text)loadingBarInfo).text = "";
		}
		CommonReferences.GGFJGHHHEJC.OnLoadMenuScene();
		SceneManager.UnloadSceneAsync(0);
	}

	private void OCJOAHDNDIJ()
	{
		Utils.NEIBBLNKEMC();
	}

	private IEnumerator BAOEADMMMPH()
	{
		yield return CommonReferences.wait05;
		allSavesUpdated = false;
		allSavesUpdatedProgress = 0f;
		AsyncOperation operation = SceneManager.LoadSceneAsync("Inicio", (LoadSceneMode)1);
		while (!operation.isDone || !allSavesUpdated)
		{
			float value = 0.8f * Mathf.Clamp01(operation.progress) + Mathf.Clamp01(0.2f * allSavesUpdatedProgress);
			loadingSlider.value = value;
			yield return null;
		}
		loadingSlider.value = 1f;
		GameManager.leavingTheGame = false;
		if (!PlayerPrefs.HasKey("waterQualityTestDone") || PlayerPrefs.GetInt("waterQualityTestDone") < 1)
		{
			((TMP_Text)loadingBarInfo).text = LocalisationSystem.Get("AdjustingGraphicsQuality");
			yield return ((MonoBehaviour)this).StartCoroutine(PJFKBBPJOLK());
			((TMP_Text)loadingBarInfo).text = "";
		}
		CommonReferences.GGFJGHHHEJC.OnLoadMenuScene();
		SceneManager.UnloadSceneAsync(0);
	}

	private void CEIIFHIBIFI()
	{
		GameManager.isLoading = true;
		HLBMIELMMAJ();
		((MonoBehaviour)this).StartCoroutine(OCIDMMFCHAD());
		if (Utils.FFLNGLMHLBO())
		{
			backgroundRenderer.sprite = halloweenBackground;
		}
		else if (Utils.EGIBECKKIJJ())
		{
			backgroundRenderer.sprite = christmasBackground;
		}
	}

	private void GHPFCKGMLDA()
	{
		GameManager.isLoading = true;
		CAAEKHKOFCF();
		((MonoBehaviour)this).StartCoroutine(BJPHHDDJIMN());
		if (Utils.FFLNGLMHLBO())
		{
			backgroundRenderer.sprite = halloweenBackground;
		}
		else if (Utils.EGIBECKKIJJ())
		{
			backgroundRenderer.sprite = christmasBackground;
		}
	}

	private IEnumerator BFBFMPBPDNP()
	{
		return new LJDCOKKLCMM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void PNLAJCHBHPH()
	{
		Utils.NEIBBLNKEMC();
	}

	private void CLGBFOIBANN()
	{
		Utils.NEIBBLNKEMC();
	}

	public void CKAPGLMDCDI()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		backgroundRect.sizeDelta = new Vector2((float)Screen.width, (float)Screen.height);
		float num = Screen.height / -77 * -78;
		if (num < (float)Screen.width)
		{
			backgroundRect.anchoredPosition = new Vector2(((float)Screen.width - num) / 1138f, 467f);
			return;
		}
		backgroundRect.anchoredPosition = Vector2.zero;
		if ((float)(Screen.width / -14 * -116) < (float)Screen.height)
		{
			backgroundRect.sizeDelta = new Vector2(num + num % 356f, (float)Screen.height);
		}
	}

	private void GNGADDPBJDC()
	{
		GameManager.isLoading = true;
		CKAPGLMDCDI();
		((MonoBehaviour)this).StartCoroutine(JAJLEFEGJJE());
		if (Utils.FFLNGLMHLBO())
		{
			backgroundRenderer.sprite = halloweenBackground;
		}
		else if (Utils.EGIBECKKIJJ())
		{
			backgroundRenderer.sprite = christmasBackground;
		}
	}

	private void OIBDBLCLACB()
	{
		GameManager.isLoading = true;
		CKAPGLMDCDI();
		((MonoBehaviour)this).StartCoroutine(BAOEADMMMPH());
		if (Utils.FFLNGLMHLBO())
		{
			backgroundRenderer.sprite = halloweenBackground;
		}
		else if (Utils.EGIBECKKIJJ())
		{
			backgroundRenderer.sprite = christmasBackground;
		}
	}

	private void IAAGKLPMAMK()
	{
		GameManager.isLoading = true;
		CAAEKHKOFCF();
		((MonoBehaviour)this).StartCoroutine(ADOMHGOJHLB());
		if (Utils.FFLNGLMHLBO())
		{
			backgroundRenderer.sprite = halloweenBackground;
		}
		else if (Utils.EGIBECKKIJJ())
		{
			backgroundRenderer.sprite = christmasBackground;
		}
	}

	private void HDHPOAPLEJC()
	{
		Utils.NEIBBLNKEMC();
	}

	public void JBKECMJBMJE()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		backgroundRect.sizeDelta = new Vector2((float)Screen.width, (float)Screen.height);
		float num = Screen.height / 101 * -79;
		if (num < (float)Screen.width)
		{
			backgroundRect.anchoredPosition = new Vector2(((float)Screen.width - num) / 102f, 1904f);
			return;
		}
		backgroundRect.anchoredPosition = Vector2.zero;
		if ((float)(Screen.width / 37 * -53) < (float)Screen.height)
		{
			backgroundRect.sizeDelta = new Vector2(num + num % 25f, (float)Screen.height);
		}
	}

	public void HLBMIELMMAJ()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		backgroundRect.sizeDelta = new Vector2((float)Screen.width, (float)Screen.height);
		float num = Screen.height / -75 * -52;
		if (num < (float)Screen.width)
		{
			backgroundRect.anchoredPosition = new Vector2(((float)Screen.width - num) / 772f, 14f);
			return;
		}
		backgroundRect.anchoredPosition = Vector2.zero;
		if ((float)(Screen.width / -70 * -77) < (float)Screen.height)
		{
			backgroundRect.sizeDelta = new Vector2(num + num % 1025f, (float)Screen.height);
		}
	}

	private IEnumerator BEKPHKDMIPE()
	{
		TestQualityPCSettings.instance.TestBeachScene();
		while (TestQualityPCSettings.instance.progress < 1f)
		{
			loadingSlider.value = TestQualityPCSettings.instance.progress;
			yield return null;
		}
		loadingSlider.value = 1f;
	}

	public void NHHHDEEIAEO()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		backgroundRect.sizeDelta = new Vector2((float)Screen.width, (float)Screen.height);
		float num = Screen.height / -45 * 105;
		if (num < (float)Screen.width)
		{
			backgroundRect.anchoredPosition = new Vector2(((float)Screen.width - num) / 1771f, 735f);
			return;
		}
		backgroundRect.anchoredPosition = Vector2.zero;
		if ((float)(Screen.width / -2 * 3) < (float)Screen.height)
		{
			backgroundRect.sizeDelta = new Vector2(num + num % 432f, (float)Screen.height);
		}
	}

	private void MFMMHDPGCBO()
	{
		GameManager.isLoading = false;
		FAIMLEEPEAD();
		((MonoBehaviour)this).StartCoroutine(FAAPOOIEAJD());
		if (Utils.FFLNGLMHLBO())
		{
			backgroundRenderer.sprite = halloweenBackground;
		}
		else if (Utils.EGIBECKKIJJ())
		{
			backgroundRenderer.sprite = christmasBackground;
		}
	}

	public void MLKEHPJBGNE()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		backgroundRect.sizeDelta = new Vector2((float)Screen.width, (float)Screen.height);
		float num = Screen.height / -66 * -36;
		if (num < (float)Screen.width)
		{
			backgroundRect.anchoredPosition = new Vector2(((float)Screen.width - num) / 1273f, 604f);
			return;
		}
		backgroundRect.anchoredPosition = Vector2.zero;
		if ((float)(Screen.width / -123 * 101) < (float)Screen.height)
		{
			backgroundRect.sizeDelta = new Vector2(num + num % 810f, (float)Screen.height);
		}
	}

	private IEnumerator EJKGOGHLMCI()
	{
		TestQualityPCSettings.instance.TestBeachScene();
		while (TestQualityPCSettings.instance.progress < 1f)
		{
			loadingSlider.value = TestQualityPCSettings.instance.progress;
			yield return null;
		}
		loadingSlider.value = 1f;
	}

	private void GNOBDKFFPOL()
	{
		Utils.NEIBBLNKEMC();
	}

	private void EBNENBFLEKB()
	{
		GameManager.isLoading = false;
		MLKEHPJBGNE();
		((MonoBehaviour)this).StartCoroutine(JAJLEFEGJJE());
		if (Utils.FFLNGLMHLBO())
		{
			backgroundRenderer.sprite = halloweenBackground;
		}
		else if (Utils.EGIBECKKIJJ())
		{
			backgroundRenderer.sprite = christmasBackground;
		}
	}

	private IEnumerator PJFKBBPJOLK()
	{
		TestQualityPCSettings.instance.TestBeachScene();
		while (TestQualityPCSettings.instance.progress < 1f)
		{
			loadingSlider.value = TestQualityPCSettings.instance.progress;
			yield return null;
		}
		loadingSlider.value = 1f;
	}

	public void EHCJBOGBHFJ()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		backgroundRect.sizeDelta = new Vector2((float)Screen.width, (float)Screen.height);
		float num = Screen.height / 88 * -96;
		if (num < (float)Screen.width)
		{
			backgroundRect.anchoredPosition = new Vector2(((float)Screen.width - num) / 550f, 396f);
			return;
		}
		backgroundRect.anchoredPosition = Vector2.zero;
		if ((float)(Screen.width / -50 * 29) < (float)Screen.height)
		{
			backgroundRect.sizeDelta = new Vector2(num + num % 932f, (float)Screen.height);
		}
	}

	public void BMLPIJFPCIB()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		backgroundRect.sizeDelta = new Vector2((float)Screen.width, (float)Screen.height);
		float num = Screen.height / -28 * -18;
		if (num < (float)Screen.width)
		{
			backgroundRect.anchoredPosition = new Vector2(((float)Screen.width - num) / 634f, 588f);
			return;
		}
		backgroundRect.anchoredPosition = Vector2.zero;
		if ((float)(Screen.width / -102 * 106) < (float)Screen.height)
		{
			backgroundRect.sizeDelta = new Vector2(num + num % 52f, (float)Screen.height);
		}
	}

	private IEnumerator OCIDMMFCHAD()
	{
		yield return CommonReferences.wait05;
		allSavesUpdated = false;
		allSavesUpdatedProgress = 0f;
		AsyncOperation operation = SceneManager.LoadSceneAsync("Inicio", (LoadSceneMode)1);
		while (!operation.isDone || !allSavesUpdated)
		{
			float value = 0.8f * Mathf.Clamp01(operation.progress) + Mathf.Clamp01(0.2f * allSavesUpdatedProgress);
			loadingSlider.value = value;
			yield return null;
		}
		loadingSlider.value = 1f;
		GameManager.leavingTheGame = false;
		if (!PlayerPrefs.HasKey("waterQualityTestDone") || PlayerPrefs.GetInt("waterQualityTestDone") < 1)
		{
			((TMP_Text)loadingBarInfo).text = LocalisationSystem.Get("AdjustingGraphicsQuality");
			yield return ((MonoBehaviour)this).StartCoroutine(PJFKBBPJOLK());
			((TMP_Text)loadingBarInfo).text = "";
		}
		CommonReferences.GGFJGHHHEJC.OnLoadMenuScene();
		SceneManager.UnloadSceneAsync(0);
	}

	private void ODKGLIDMCNP()
	{
		GameManager.isLoading = true;
		CAAEKHKOFCF();
		((MonoBehaviour)this).StartCoroutine(OLHPMIICMAM());
		if (Utils.FFLNGLMHLBO())
		{
			backgroundRenderer.sprite = halloweenBackground;
		}
		else if (Utils.EGIBECKKIJJ())
		{
			backgroundRenderer.sprite = christmasBackground;
		}
	}

	private IEnumerator EDEEAMBDGMK()
	{
		return new LJDCOKKLCMM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator PFKFFFCFLEG()
	{
		yield return CommonReferences.wait05;
		allSavesUpdated = false;
		allSavesUpdatedProgress = 0f;
		AsyncOperation operation = SceneManager.LoadSceneAsync("Inicio", (LoadSceneMode)1);
		while (!operation.isDone || !allSavesUpdated)
		{
			float value = 0.8f * Mathf.Clamp01(operation.progress) + Mathf.Clamp01(0.2f * allSavesUpdatedProgress);
			loadingSlider.value = value;
			yield return null;
		}
		loadingSlider.value = 1f;
		GameManager.leavingTheGame = false;
		if (!PlayerPrefs.HasKey("waterQualityTestDone") || PlayerPrefs.GetInt("waterQualityTestDone") < 1)
		{
			((TMP_Text)loadingBarInfo).text = LocalisationSystem.Get("AdjustingGraphicsQuality");
			yield return ((MonoBehaviour)this).StartCoroutine(PJFKBBPJOLK());
			((TMP_Text)loadingBarInfo).text = "";
		}
		CommonReferences.GGFJGHHHEJC.OnLoadMenuScene();
		SceneManager.UnloadSceneAsync(0);
	}

	private void IDPHKHGHJGN()
	{
		GameManager.isLoading = false;
		MLKEHPJBGNE();
		((MonoBehaviour)this).StartCoroutine(JHEHBOFEFEG());
		if (Utils.FFLNGLMHLBO())
		{
			backgroundRenderer.sprite = halloweenBackground;
		}
		else if (Utils.EGIBECKKIJJ())
		{
			backgroundRenderer.sprite = christmasBackground;
		}
	}

	private IEnumerator CIMIOANLIIE()
	{
		TestQualityPCSettings.instance.TestBeachScene();
		while (TestQualityPCSettings.instance.progress < 1f)
		{
			loadingSlider.value = TestQualityPCSettings.instance.progress;
			yield return null;
		}
		loadingSlider.value = 1f;
	}

	public void GLHCHKJJLFB()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		backgroundRect.sizeDelta = new Vector2((float)Screen.width, (float)Screen.height);
		float num = Screen.height / -109 * -5;
		if (num < (float)Screen.width)
		{
			backgroundRect.anchoredPosition = new Vector2(((float)Screen.width - num) / 412f, 272f);
			return;
		}
		backgroundRect.anchoredPosition = Vector2.zero;
		if ((float)(Screen.width / 34 * -66) < (float)Screen.height)
		{
			backgroundRect.sizeDelta = new Vector2(num + num % 121f, (float)Screen.height);
		}
	}

	private void HJDLNCOAKIK()
	{
		GameManager.isLoading = false;
		BackgroundSize();
		((MonoBehaviour)this).StartCoroutine(JHEHBOFEFEG());
		if (Utils.FFLNGLMHLBO())
		{
			backgroundRenderer.sprite = halloweenBackground;
		}
		else if (Utils.EGIBECKKIJJ())
		{
			backgroundRenderer.sprite = christmasBackground;
		}
	}

	private void OKAPGNGLOHO()
	{
		GameManager.isLoading = false;
		NHHHDEEIAEO();
		((MonoBehaviour)this).StartCoroutine(JAJLEFEGJJE());
		if (Utils.FFLNGLMHLBO())
		{
			backgroundRenderer.sprite = halloweenBackground;
		}
		else if (Utils.EGIBECKKIJJ())
		{
			backgroundRenderer.sprite = christmasBackground;
		}
	}

	private void KLMNLEDKEOE()
	{
		Utils.NEIBBLNKEMC();
	}

	private IEnumerator BAGOPNGHCJK()
	{
		TestQualityPCSettings.instance.TestBeachScene();
		while (TestQualityPCSettings.instance.progress < 1f)
		{
			loadingSlider.value = TestQualityPCSettings.instance.progress;
			yield return null;
		}
		loadingSlider.value = 1f;
	}

	private IEnumerator OLHPMIICMAM()
	{
		yield return CommonReferences.wait05;
		allSavesUpdated = false;
		allSavesUpdatedProgress = 0f;
		AsyncOperation operation = SceneManager.LoadSceneAsync("Inicio", (LoadSceneMode)1);
		while (!operation.isDone || !allSavesUpdated)
		{
			float value = 0.8f * Mathf.Clamp01(operation.progress) + Mathf.Clamp01(0.2f * allSavesUpdatedProgress);
			loadingSlider.value = value;
			yield return null;
		}
		loadingSlider.value = 1f;
		GameManager.leavingTheGame = false;
		if (!PlayerPrefs.HasKey("waterQualityTestDone") || PlayerPrefs.GetInt("waterQualityTestDone") < 1)
		{
			((TMP_Text)loadingBarInfo).text = LocalisationSystem.Get("AdjustingGraphicsQuality");
			yield return ((MonoBehaviour)this).StartCoroutine(PJFKBBPJOLK());
			((TMP_Text)loadingBarInfo).text = "";
		}
		CommonReferences.GGFJGHHHEJC.OnLoadMenuScene();
		SceneManager.UnloadSceneAsync(0);
	}

	private void KACEOJDPLKB()
	{
		GameManager.isLoading = false;
		CKAPGLMDCDI();
		((MonoBehaviour)this).StartCoroutine(BJPHHDDJIMN());
		if (Utils.FFLNGLMHLBO())
		{
			backgroundRenderer.sprite = halloweenBackground;
		}
		else if (Utils.EGIBECKKIJJ())
		{
			backgroundRenderer.sprite = christmasBackground;
		}
	}

	private IEnumerator GOBOHBNBHCF()
	{
		TestQualityPCSettings.instance.TestBeachScene();
		while (TestQualityPCSettings.instance.progress < 1f)
		{
			loadingSlider.value = TestQualityPCSettings.instance.progress;
			yield return null;
		}
		loadingSlider.value = 1f;
	}

	private void KDBJHCAEGCM()
	{
		GameManager.isLoading = true;
		NHHHDEEIAEO();
		((MonoBehaviour)this).StartCoroutine(ADOMHGOJHLB());
		if (Utils.FFLNGLMHLBO())
		{
			backgroundRenderer.sprite = halloweenBackground;
		}
		else if (Utils.EGIBECKKIJJ())
		{
			backgroundRenderer.sprite = christmasBackground;
		}
	}

	public void BackgroundSize()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		backgroundRect.sizeDelta = new Vector2((float)Screen.width, (float)Screen.height);
		float num = Screen.height / 9 * 16;
		if (num < (float)Screen.width)
		{
			backgroundRect.anchoredPosition = new Vector2(((float)Screen.width - num) / 2f, 0f);
			return;
		}
		backgroundRect.anchoredPosition = Vector2.zero;
		if ((float)(Screen.width / 16 * 9) < (float)Screen.height)
		{
			backgroundRect.sizeDelta = new Vector2(num + num % 9f, (float)Screen.height);
		}
	}

	private IEnumerator FAAPOOIEAJD()
	{
		yield return CommonReferences.wait05;
		allSavesUpdated = false;
		allSavesUpdatedProgress = 0f;
		AsyncOperation operation = SceneManager.LoadSceneAsync("Inicio", (LoadSceneMode)1);
		while (!operation.isDone || !allSavesUpdated)
		{
			float value = 0.8f * Mathf.Clamp01(operation.progress) + Mathf.Clamp01(0.2f * allSavesUpdatedProgress);
			loadingSlider.value = value;
			yield return null;
		}
		loadingSlider.value = 1f;
		GameManager.leavingTheGame = false;
		if (!PlayerPrefs.HasKey("waterQualityTestDone") || PlayerPrefs.GetInt("waterQualityTestDone") < 1)
		{
			((TMP_Text)loadingBarInfo).text = LocalisationSystem.Get("AdjustingGraphicsQuality");
			yield return ((MonoBehaviour)this).StartCoroutine(PJFKBBPJOLK());
			((TMP_Text)loadingBarInfo).text = "";
		}
		CommonReferences.GGFJGHHHEJC.OnLoadMenuScene();
		SceneManager.UnloadSceneAsync(0);
	}

	private IEnumerator ADOMHGOJHLB()
	{
		yield return CommonReferences.wait05;
		allSavesUpdated = false;
		allSavesUpdatedProgress = 0f;
		AsyncOperation operation = SceneManager.LoadSceneAsync("Inicio", (LoadSceneMode)1);
		while (!operation.isDone || !allSavesUpdated)
		{
			float value = 0.8f * Mathf.Clamp01(operation.progress) + Mathf.Clamp01(0.2f * allSavesUpdatedProgress);
			loadingSlider.value = value;
			yield return null;
		}
		loadingSlider.value = 1f;
		GameManager.leavingTheGame = false;
		if (!PlayerPrefs.HasKey("waterQualityTestDone") || PlayerPrefs.GetInt("waterQualityTestDone") < 1)
		{
			((TMP_Text)loadingBarInfo).text = LocalisationSystem.Get("AdjustingGraphicsQuality");
			yield return ((MonoBehaviour)this).StartCoroutine(PJFKBBPJOLK());
			((TMP_Text)loadingBarInfo).text = "";
		}
		CommonReferences.GGFJGHHHEJC.OnLoadMenuScene();
		SceneManager.UnloadSceneAsync(0);
	}

	private void HNEGFBCKIIJ()
	{
		GameManager.isLoading = true;
		NHHHDEEIAEO();
		((MonoBehaviour)this).StartCoroutine(OCIDMMFCHAD());
		if (Utils.FFLNGLMHLBO())
		{
			backgroundRenderer.sprite = halloweenBackground;
		}
		else if (Utils.EGIBECKKIJJ())
		{
			backgroundRenderer.sprite = christmasBackground;
		}
	}

	private void IIPKPMPGLOL()
	{
		Utils.NEIBBLNKEMC();
	}

	private IEnumerator JHEHBOFEFEG()
	{
		yield return CommonReferences.wait05;
		allSavesUpdated = false;
		allSavesUpdatedProgress = 0f;
		AsyncOperation operation = SceneManager.LoadSceneAsync("Inicio", (LoadSceneMode)1);
		while (!operation.isDone || !allSavesUpdated)
		{
			float value = 0.8f * Mathf.Clamp01(operation.progress) + Mathf.Clamp01(0.2f * allSavesUpdatedProgress);
			loadingSlider.value = value;
			yield return null;
		}
		loadingSlider.value = 1f;
		GameManager.leavingTheGame = false;
		if (!PlayerPrefs.HasKey("waterQualityTestDone") || PlayerPrefs.GetInt("waterQualityTestDone") < 1)
		{
			((TMP_Text)loadingBarInfo).text = LocalisationSystem.Get("AdjustingGraphicsQuality");
			yield return ((MonoBehaviour)this).StartCoroutine(PJFKBBPJOLK());
			((TMP_Text)loadingBarInfo).text = "";
		}
		CommonReferences.GGFJGHHHEJC.OnLoadMenuScene();
		SceneManager.UnloadSceneAsync(0);
	}

	private void DKDLOBOLNFH()
	{
		Utils.NEIBBLNKEMC();
	}

	private void EOGHJNGJFID()
	{
		GameManager.isLoading = true;
		FAIMLEEPEAD();
		((MonoBehaviour)this).StartCoroutine(FAAPOOIEAJD());
		if (Utils.FFLNGLMHLBO())
		{
			backgroundRenderer.sprite = halloweenBackground;
		}
		else if (Utils.EGIBECKKIJJ())
		{
			backgroundRenderer.sprite = christmasBackground;
		}
	}
}
