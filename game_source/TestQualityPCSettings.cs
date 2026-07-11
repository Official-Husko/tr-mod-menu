using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cinemachine;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestQualityPCSettings : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class OACFKPCCDBF : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TestQualityPCSettings _003C_003E4__this;

		private AsyncOperation _003CloadingScene_003E5__2;

		private float _003CtotalDeltaTime_003E5__3;

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
		public OACFKPCCDBF(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0239: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			TestQualityPCSettings testQualityPCSettings = _003C_003E4__this;
			float num2;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				Debug.Log((object)"Test Beach Scene");
				((CinemachineVirtualCameraBase)testQualityPCSettings.cinemachineVirtualCamera).Follow = ((Component)testQualityPCSettings.waterTestPosition).transform;
				_003CloadingScene_003E5__2 = SceneManager.LoadSceneAsync("Beach", (LoadSceneMode)1);
				goto IL_00a2;
			case 1:
				_003C_003E1__state = -1;
				goto IL_00a2;
			case 2:
				_003C_003E1__state = -1;
				testQualityPCSettings.progress = 0.6f;
				Debug.Log((object)"Start water quality test");
				_003C_003E2__current = null;
				_003C_003E1__state = 3;
				return true;
			case 3:
				_003C_003E1__state = -1;
				GraphicsMenuUI.GGFJGHHHEJC.ApplyZoom(1, 0);
				QualityManager.SetQuality(1);
				_003C_003E2__current = null;
				_003C_003E1__state = 4;
				return true;
			case 4:
				_003C_003E1__state = -1;
				_003CtotalDeltaTime_003E5__3 = 0f;
				testQualityPCSettings.MMIOHHKNADI = 0f;
				goto IL_0135;
			case 5:
				_003C_003E1__state = -1;
				goto IL_0135;
			case 6:
				_003C_003E1__state = -1;
				_003CloadingScene_003E5__2 = SceneManager.UnloadSceneAsync(SceneManager.GetSceneByName("Beach"));
				break;
			case 7:
				{
					_003C_003E1__state = -1;
					break;
				}
				IL_0135:
				_003CtotalDeltaTime_003E5__3 += Time.deltaTime;
				testQualityPCSettings.progress = 0.6f + _003CtotalDeltaTime_003E5__3 / testQualityPCSettings.MBDHPNNLKOO * 0.3f;
				testQualityPCSettings.MMIOHHKNADI += 1f;
				if (!(_003CtotalDeltaTime_003E5__3 > testQualityPCSettings.MBDHPNNLKOO))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 5;
					return true;
				}
				num2 = testQualityPCSettings.MMIOHHKNADI / _003CtotalDeltaTime_003E5__3;
				Debug.Log((object)("Frame Time Average: " + num2));
				if (num2 < (float)testQualityPCSettings.FIBEFHOBOII)
				{
					Debug.Log((object)"Reducing quality water to Low");
					PlayerPrefs.SetInt("qualityWater", 0);
					QualityManager.SetQuality(0);
				}
				else
				{
					Debug.Log((object)"High quality water");
					PlayerPrefs.SetInt("qualityWater", 1);
					QualityManager.SetQuality(1);
				}
				PlayerPrefs.SetInt("waterQualityTestDone", 1);
				GraphicsMenuUI.GGFJGHHHEJC.SetUpZoom(1, NOKFNLBADMO: true);
				_003C_003E2__current = null;
				_003C_003E1__state = 6;
				return true;
				IL_00a2:
				if (!_003CloadingScene_003E5__2.isDone)
				{
					testQualityPCSettings.progress = _003CloadingScene_003E5__2.progress * 0.5f;
					_003C_003E2__current = CommonReferences.wait02;
					_003C_003E1__state = 1;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 2;
				return true;
			}
			if (!_003CloadingScene_003E5__2.isDone)
			{
				testQualityPCSettings.progress = 0.9f + _003CloadingScene_003E5__2.progress * 0.1f;
				_003C_003E2__current = CommonReferences.wait02;
				_003C_003E1__state = 7;
				return true;
			}
			testQualityPCSettings.active = false;
			testQualityPCSettings.progress = 1f;
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

	public static TestQualityPCSettings instance;

	public bool active;

	public float progress;

	[SerializeField]
	private Camera mainCamera;

	[SerializeField]
	private CinemachineVirtualCamera cinemachineVirtualCamera;

	[SerializeField]
	private Transform waterTestPosition;

	private float MBDHPNNLKOO = 5f;

	private float MMIOHHKNADI;

	private int FIBEFHOBOII = 57;

	private void NODKJHJFMCO()
	{
		instance = this;
	}

	public void EMNAANCAFDP()
	{
		active = true;
		((MonoBehaviour)this).StartCoroutine(HFKDKMGHKEH());
	}

	private void EFCNKPEPELL()
	{
		instance = this;
	}

	private void BAKDKFKNHDE()
	{
		instance = this;
	}

	public void LMHHLNEPOGA()
	{
		active = false;
		((MonoBehaviour)this).StartCoroutine(ALADMBDDLJK());
	}

	private void DKNNLPFIBIK()
	{
		instance = this;
	}

	public IEnumerator JELOCNBPIFG()
	{
		return new OACFKPCCDBF(1)
		{
			_003C_003E4__this = this
		};
	}

	public IEnumerator AOPDFLKOMGM()
	{
		Debug.Log((object)"Test Beach Scene");
		((CinemachineVirtualCameraBase)cinemachineVirtualCamera).Follow = ((Component)waterTestPosition).transform;
		AsyncOperation loadingScene2 = SceneManager.LoadSceneAsync("Beach", (LoadSceneMode)1);
		while (!loadingScene2.isDone)
		{
			progress = loadingScene2.progress * 0.5f;
			yield return CommonReferences.wait02;
		}
		yield return CommonReferences.wait1;
		progress = 0.6f;
		Debug.Log((object)"Start water quality test");
		yield return null;
		GraphicsMenuUI.GGFJGHHHEJC.ApplyZoom(1, 0);
		QualityManager.SetQuality(1);
		yield return null;
		float totalDeltaTime = 0f;
		MMIOHHKNADI = 0f;
		while (true)
		{
			totalDeltaTime += Time.deltaTime;
			progress = 0.6f + totalDeltaTime / MBDHPNNLKOO * 0.3f;
			MMIOHHKNADI += 1f;
			if (totalDeltaTime > MBDHPNNLKOO)
			{
				break;
			}
			yield return null;
		}
		float num = MMIOHHKNADI / totalDeltaTime;
		Debug.Log((object)("Frame Time Average: " + num));
		if (num < (float)FIBEFHOBOII)
		{
			Debug.Log((object)"Reducing quality water to Low");
			PlayerPrefs.SetInt("qualityWater", 0);
			QualityManager.SetQuality(0);
		}
		else
		{
			Debug.Log((object)"High quality water");
			PlayerPrefs.SetInt("qualityWater", 1);
			QualityManager.SetQuality(1);
		}
		PlayerPrefs.SetInt("waterQualityTestDone", 1);
		GraphicsMenuUI.GGFJGHHHEJC.SetUpZoom(1, NOKFNLBADMO: true);
		yield return null;
		loadingScene2 = SceneManager.UnloadSceneAsync(SceneManager.GetSceneByName("Beach"));
		while (!loadingScene2.isDone)
		{
			progress = 0.9f + loadingScene2.progress * 0.1f;
			yield return CommonReferences.wait02;
		}
		active = false;
		progress = 1f;
	}

	public IEnumerator NAHIHNGLNDO()
	{
		return new OACFKPCCDBF(1)
		{
			_003C_003E4__this = this
		};
	}

	private void DKDLOBOLNFH()
	{
		instance = this;
	}

	public IEnumerator KJIKBLNFILL()
	{
		return new OACFKPCCDBF(1)
		{
			_003C_003E4__this = this
		};
	}

	public void HMCFMHPPDGL()
	{
		active = false;
		((MonoBehaviour)this).StartCoroutine(JELOCNBPIFG());
	}

	public void GMIPIMBEHIJ()
	{
		active = true;
		((MonoBehaviour)this).StartCoroutine(APICFGGPECJ());
	}

	public IEnumerator ALADMBDDLJK()
	{
		Debug.Log((object)"Test Beach Scene");
		((CinemachineVirtualCameraBase)cinemachineVirtualCamera).Follow = ((Component)waterTestPosition).transform;
		AsyncOperation loadingScene2 = SceneManager.LoadSceneAsync("Beach", (LoadSceneMode)1);
		while (!loadingScene2.isDone)
		{
			progress = loadingScene2.progress * 0.5f;
			yield return CommonReferences.wait02;
		}
		yield return CommonReferences.wait1;
		progress = 0.6f;
		Debug.Log((object)"Start water quality test");
		yield return null;
		GraphicsMenuUI.GGFJGHHHEJC.ApplyZoom(1, 0);
		QualityManager.SetQuality(1);
		yield return null;
		float totalDeltaTime = 0f;
		MMIOHHKNADI = 0f;
		while (true)
		{
			totalDeltaTime += Time.deltaTime;
			progress = 0.6f + totalDeltaTime / MBDHPNNLKOO * 0.3f;
			MMIOHHKNADI += 1f;
			if (totalDeltaTime > MBDHPNNLKOO)
			{
				break;
			}
			yield return null;
		}
		float num = MMIOHHKNADI / totalDeltaTime;
		Debug.Log((object)("Frame Time Average: " + num));
		if (num < (float)FIBEFHOBOII)
		{
			Debug.Log((object)"Reducing quality water to Low");
			PlayerPrefs.SetInt("qualityWater", 0);
			QualityManager.SetQuality(0);
		}
		else
		{
			Debug.Log((object)"High quality water");
			PlayerPrefs.SetInt("qualityWater", 1);
			QualityManager.SetQuality(1);
		}
		PlayerPrefs.SetInt("waterQualityTestDone", 1);
		GraphicsMenuUI.GGFJGHHHEJC.SetUpZoom(1, NOKFNLBADMO: true);
		yield return null;
		loadingScene2 = SceneManager.UnloadSceneAsync(SceneManager.GetSceneByName("Beach"));
		while (!loadingScene2.isDone)
		{
			progress = 0.9f + loadingScene2.progress * 0.1f;
			yield return CommonReferences.wait02;
		}
		active = false;
		progress = 1f;
	}

	public IEnumerator JGEFKCHEAJJ()
	{
		Debug.Log((object)"Test Beach Scene");
		((CinemachineVirtualCameraBase)cinemachineVirtualCamera).Follow = ((Component)waterTestPosition).transform;
		AsyncOperation loadingScene2 = SceneManager.LoadSceneAsync("Beach", (LoadSceneMode)1);
		while (!loadingScene2.isDone)
		{
			progress = loadingScene2.progress * 0.5f;
			yield return CommonReferences.wait02;
		}
		yield return CommonReferences.wait1;
		progress = 0.6f;
		Debug.Log((object)"Start water quality test");
		yield return null;
		GraphicsMenuUI.GGFJGHHHEJC.ApplyZoom(1, 0);
		QualityManager.SetQuality(1);
		yield return null;
		float totalDeltaTime = 0f;
		MMIOHHKNADI = 0f;
		while (true)
		{
			totalDeltaTime += Time.deltaTime;
			progress = 0.6f + totalDeltaTime / MBDHPNNLKOO * 0.3f;
			MMIOHHKNADI += 1f;
			if (totalDeltaTime > MBDHPNNLKOO)
			{
				break;
			}
			yield return null;
		}
		float num = MMIOHHKNADI / totalDeltaTime;
		Debug.Log((object)("Frame Time Average: " + num));
		if (num < (float)FIBEFHOBOII)
		{
			Debug.Log((object)"Reducing quality water to Low");
			PlayerPrefs.SetInt("qualityWater", 0);
			QualityManager.SetQuality(0);
		}
		else
		{
			Debug.Log((object)"High quality water");
			PlayerPrefs.SetInt("qualityWater", 1);
			QualityManager.SetQuality(1);
		}
		PlayerPrefs.SetInt("waterQualityTestDone", 1);
		GraphicsMenuUI.GGFJGHHHEJC.SetUpZoom(1, NOKFNLBADMO: true);
		yield return null;
		loadingScene2 = SceneManager.UnloadSceneAsync(SceneManager.GetSceneByName("Beach"));
		while (!loadingScene2.isDone)
		{
			progress = 0.9f + loadingScene2.progress * 0.1f;
			yield return CommonReferences.wait02;
		}
		active = false;
		progress = 1f;
	}

	public void MKJEKFGLCIA()
	{
		active = false;
		((MonoBehaviour)this).StartCoroutine(AMMOHLGCICP());
	}

	public IEnumerator PFDCCJMCACG()
	{
		return new OACFKPCCDBF(1)
		{
			_003C_003E4__this = this
		};
	}

	private void JDAMCMODANB()
	{
		instance = this;
	}

	private void HFPDNCBLNDE()
	{
		instance = this;
	}

	public IEnumerator CNJEHEAIIPI()
	{
		return new OACFKPCCDBF(1)
		{
			_003C_003E4__this = this
		};
	}

	public void OGNKBKDHPGB()
	{
		active = false;
		((MonoBehaviour)this).StartCoroutine(CGOCJOEPJDI());
	}

	public IEnumerator HFKDKMGHKEH()
	{
		Debug.Log((object)"Test Beach Scene");
		((CinemachineVirtualCameraBase)cinemachineVirtualCamera).Follow = ((Component)waterTestPosition).transform;
		AsyncOperation loadingScene2 = SceneManager.LoadSceneAsync("Beach", (LoadSceneMode)1);
		while (!loadingScene2.isDone)
		{
			progress = loadingScene2.progress * 0.5f;
			yield return CommonReferences.wait02;
		}
		yield return CommonReferences.wait1;
		progress = 0.6f;
		Debug.Log((object)"Start water quality test");
		yield return null;
		GraphicsMenuUI.GGFJGHHHEJC.ApplyZoom(1, 0);
		QualityManager.SetQuality(1);
		yield return null;
		float totalDeltaTime = 0f;
		MMIOHHKNADI = 0f;
		while (true)
		{
			totalDeltaTime += Time.deltaTime;
			progress = 0.6f + totalDeltaTime / MBDHPNNLKOO * 0.3f;
			MMIOHHKNADI += 1f;
			if (totalDeltaTime > MBDHPNNLKOO)
			{
				break;
			}
			yield return null;
		}
		float num = MMIOHHKNADI / totalDeltaTime;
		Debug.Log((object)("Frame Time Average: " + num));
		if (num < (float)FIBEFHOBOII)
		{
			Debug.Log((object)"Reducing quality water to Low");
			PlayerPrefs.SetInt("qualityWater", 0);
			QualityManager.SetQuality(0);
		}
		else
		{
			Debug.Log((object)"High quality water");
			PlayerPrefs.SetInt("qualityWater", 1);
			QualityManager.SetQuality(1);
		}
		PlayerPrefs.SetInt("waterQualityTestDone", 1);
		GraphicsMenuUI.GGFJGHHHEJC.SetUpZoom(1, NOKFNLBADMO: true);
		yield return null;
		loadingScene2 = SceneManager.UnloadSceneAsync(SceneManager.GetSceneByName("Beach"));
		while (!loadingScene2.isDone)
		{
			progress = 0.9f + loadingScene2.progress * 0.1f;
			yield return CommonReferences.wait02;
		}
		active = false;
		progress = 1f;
	}

	public IEnumerator KJHDOPBDNJA()
	{
		return new OACFKPCCDBF(1)
		{
			_003C_003E4__this = this
		};
	}

	private void BMKGHOJDDNB()
	{
		instance = this;
	}

	public void AEIGMNHHIHB()
	{
		active = false;
		((MonoBehaviour)this).StartCoroutine(BBDGLFACAGB());
	}

	public void CJJEPIEEGDC()
	{
		active = true;
		((MonoBehaviour)this).StartCoroutine(PFOFOHNEHMF());
	}

	public void FGHIAOAAPKG()
	{
		active = true;
		((MonoBehaviour)this).StartCoroutine(APICFGGPECJ());
	}

	public IEnumerator CMNAGKJCODD()
	{
		return new OACFKPCCDBF(1)
		{
			_003C_003E4__this = this
		};
	}

	public IEnumerator OEFOGBCDDFG()
	{
		Debug.Log((object)"Test Beach Scene");
		((CinemachineVirtualCameraBase)cinemachineVirtualCamera).Follow = ((Component)waterTestPosition).transform;
		AsyncOperation loadingScene2 = SceneManager.LoadSceneAsync("Beach", (LoadSceneMode)1);
		while (!loadingScene2.isDone)
		{
			progress = loadingScene2.progress * 0.5f;
			yield return CommonReferences.wait02;
		}
		yield return CommonReferences.wait1;
		progress = 0.6f;
		Debug.Log((object)"Start water quality test");
		yield return null;
		GraphicsMenuUI.GGFJGHHHEJC.ApplyZoom(1, 0);
		QualityManager.SetQuality(1);
		yield return null;
		float totalDeltaTime = 0f;
		MMIOHHKNADI = 0f;
		while (true)
		{
			totalDeltaTime += Time.deltaTime;
			progress = 0.6f + totalDeltaTime / MBDHPNNLKOO * 0.3f;
			MMIOHHKNADI += 1f;
			if (totalDeltaTime > MBDHPNNLKOO)
			{
				break;
			}
			yield return null;
		}
		float num = MMIOHHKNADI / totalDeltaTime;
		Debug.Log((object)("Frame Time Average: " + num));
		if (num < (float)FIBEFHOBOII)
		{
			Debug.Log((object)"Reducing quality water to Low");
			PlayerPrefs.SetInt("qualityWater", 0);
			QualityManager.SetQuality(0);
		}
		else
		{
			Debug.Log((object)"High quality water");
			PlayerPrefs.SetInt("qualityWater", 1);
			QualityManager.SetQuality(1);
		}
		PlayerPrefs.SetInt("waterQualityTestDone", 1);
		GraphicsMenuUI.GGFJGHHHEJC.SetUpZoom(1, NOKFNLBADMO: true);
		yield return null;
		loadingScene2 = SceneManager.UnloadSceneAsync(SceneManager.GetSceneByName("Beach"));
		while (!loadingScene2.isDone)
		{
			progress = 0.9f + loadingScene2.progress * 0.1f;
			yield return CommonReferences.wait02;
		}
		active = false;
		progress = 1f;
	}

	private void PKPHKBMPJGJ()
	{
		instance = this;
	}

	public IEnumerator PPKPBPNNBMI()
	{
		Debug.Log((object)"Test Beach Scene");
		((CinemachineVirtualCameraBase)cinemachineVirtualCamera).Follow = ((Component)waterTestPosition).transform;
		AsyncOperation loadingScene2 = SceneManager.LoadSceneAsync("Beach", (LoadSceneMode)1);
		while (!loadingScene2.isDone)
		{
			progress = loadingScene2.progress * 0.5f;
			yield return CommonReferences.wait02;
		}
		yield return CommonReferences.wait1;
		progress = 0.6f;
		Debug.Log((object)"Start water quality test");
		yield return null;
		GraphicsMenuUI.GGFJGHHHEJC.ApplyZoom(1, 0);
		QualityManager.SetQuality(1);
		yield return null;
		float totalDeltaTime = 0f;
		MMIOHHKNADI = 0f;
		while (true)
		{
			totalDeltaTime += Time.deltaTime;
			progress = 0.6f + totalDeltaTime / MBDHPNNLKOO * 0.3f;
			MMIOHHKNADI += 1f;
			if (totalDeltaTime > MBDHPNNLKOO)
			{
				break;
			}
			yield return null;
		}
		float num = MMIOHHKNADI / totalDeltaTime;
		Debug.Log((object)("Frame Time Average: " + num));
		if (num < (float)FIBEFHOBOII)
		{
			Debug.Log((object)"Reducing quality water to Low");
			PlayerPrefs.SetInt("qualityWater", 0);
			QualityManager.SetQuality(0);
		}
		else
		{
			Debug.Log((object)"High quality water");
			PlayerPrefs.SetInt("qualityWater", 1);
			QualityManager.SetQuality(1);
		}
		PlayerPrefs.SetInt("waterQualityTestDone", 1);
		GraphicsMenuUI.GGFJGHHHEJC.SetUpZoom(1, NOKFNLBADMO: true);
		yield return null;
		loadingScene2 = SceneManager.UnloadSceneAsync(SceneManager.GetSceneByName("Beach"));
		while (!loadingScene2.isDone)
		{
			progress = 0.9f + loadingScene2.progress * 0.1f;
			yield return CommonReferences.wait02;
		}
		active = false;
		progress = 1f;
	}

	private void LHABENPEMPB()
	{
		instance = this;
	}

	public IEnumerator PJKKOIMMFEG()
	{
		return new OACFKPCCDBF(1)
		{
			_003C_003E4__this = this
		};
	}

	private void FBLAMCDFMPE()
	{
		instance = this;
	}

	private void CLNBMOPMNOF()
	{
		instance = this;
	}

	public void GGEMEGEAEEA()
	{
		active = true;
		((MonoBehaviour)this).StartCoroutine(AOPDFLKOMGM());
	}

	public void TestBeachScene()
	{
		active = true;
		((MonoBehaviour)this).StartCoroutine(TestBeachSceneCoroutine());
	}

	public IEnumerator KCLNHFMECKM()
	{
		return new OACFKPCCDBF(1)
		{
			_003C_003E4__this = this
		};
	}

	private void NLGHNDLPPKI()
	{
		instance = this;
	}

	public void IEMAJBKOACD()
	{
		active = false;
		((MonoBehaviour)this).StartCoroutine(DMBMCACHHME());
	}

	public void EGELAJMJHHA()
	{
		active = false;
		((MonoBehaviour)this).StartCoroutine(TestBeachSceneCoroutine());
	}

	private void MIKNFPCDLML()
	{
		instance = this;
	}

	public void DIIEOJBINMA()
	{
		active = true;
		((MonoBehaviour)this).StartCoroutine(HDEBKGACJEK());
	}

	public void PNALEIKAPHD()
	{
		active = true;
		((MonoBehaviour)this).StartCoroutine(AJDAKHKANBA());
	}

	public IEnumerator DAFDPEAHNCG()
	{
		return new OACFKPCCDBF(1)
		{
			_003C_003E4__this = this
		};
	}

	public IEnumerator DMBMCACHHME()
	{
		return new OACFKPCCDBF(1)
		{
			_003C_003E4__this = this
		};
	}

	private void IGHMMOKFINH()
	{
		instance = this;
	}

	private void KMEJBPOOBJK()
	{
		instance = this;
	}

	public IEnumerator OFPPEPMHJJA()
	{
		Debug.Log((object)"Test Beach Scene");
		((CinemachineVirtualCameraBase)cinemachineVirtualCamera).Follow = ((Component)waterTestPosition).transform;
		AsyncOperation loadingScene2 = SceneManager.LoadSceneAsync("Beach", (LoadSceneMode)1);
		while (!loadingScene2.isDone)
		{
			progress = loadingScene2.progress * 0.5f;
			yield return CommonReferences.wait02;
		}
		yield return CommonReferences.wait1;
		progress = 0.6f;
		Debug.Log((object)"Start water quality test");
		yield return null;
		GraphicsMenuUI.GGFJGHHHEJC.ApplyZoom(1, 0);
		QualityManager.SetQuality(1);
		yield return null;
		float totalDeltaTime = 0f;
		MMIOHHKNADI = 0f;
		while (true)
		{
			totalDeltaTime += Time.deltaTime;
			progress = 0.6f + totalDeltaTime / MBDHPNNLKOO * 0.3f;
			MMIOHHKNADI += 1f;
			if (totalDeltaTime > MBDHPNNLKOO)
			{
				break;
			}
			yield return null;
		}
		float num = MMIOHHKNADI / totalDeltaTime;
		Debug.Log((object)("Frame Time Average: " + num));
		if (num < (float)FIBEFHOBOII)
		{
			Debug.Log((object)"Reducing quality water to Low");
			PlayerPrefs.SetInt("qualityWater", 0);
			QualityManager.SetQuality(0);
		}
		else
		{
			Debug.Log((object)"High quality water");
			PlayerPrefs.SetInt("qualityWater", 1);
			QualityManager.SetQuality(1);
		}
		PlayerPrefs.SetInt("waterQualityTestDone", 1);
		GraphicsMenuUI.GGFJGHHHEJC.SetUpZoom(1, NOKFNLBADMO: true);
		yield return null;
		loadingScene2 = SceneManager.UnloadSceneAsync(SceneManager.GetSceneByName("Beach"));
		while (!loadingScene2.isDone)
		{
			progress = 0.9f + loadingScene2.progress * 0.1f;
			yield return CommonReferences.wait02;
		}
		active = false;
		progress = 1f;
	}

	private void NMKGOAJLMDG()
	{
		instance = this;
	}

	public IEnumerator PGMGFABKCBM()
	{
		Debug.Log((object)"Test Beach Scene");
		((CinemachineVirtualCameraBase)cinemachineVirtualCamera).Follow = ((Component)waterTestPosition).transform;
		AsyncOperation loadingScene2 = SceneManager.LoadSceneAsync("Beach", (LoadSceneMode)1);
		while (!loadingScene2.isDone)
		{
			progress = loadingScene2.progress * 0.5f;
			yield return CommonReferences.wait02;
		}
		yield return CommonReferences.wait1;
		progress = 0.6f;
		Debug.Log((object)"Start water quality test");
		yield return null;
		GraphicsMenuUI.GGFJGHHHEJC.ApplyZoom(1, 0);
		QualityManager.SetQuality(1);
		yield return null;
		float totalDeltaTime = 0f;
		MMIOHHKNADI = 0f;
		while (true)
		{
			totalDeltaTime += Time.deltaTime;
			progress = 0.6f + totalDeltaTime / MBDHPNNLKOO * 0.3f;
			MMIOHHKNADI += 1f;
			if (totalDeltaTime > MBDHPNNLKOO)
			{
				break;
			}
			yield return null;
		}
		float num = MMIOHHKNADI / totalDeltaTime;
		Debug.Log((object)("Frame Time Average: " + num));
		if (num < (float)FIBEFHOBOII)
		{
			Debug.Log((object)"Reducing quality water to Low");
			PlayerPrefs.SetInt("qualityWater", 0);
			QualityManager.SetQuality(0);
		}
		else
		{
			Debug.Log((object)"High quality water");
			PlayerPrefs.SetInt("qualityWater", 1);
			QualityManager.SetQuality(1);
		}
		PlayerPrefs.SetInt("waterQualityTestDone", 1);
		GraphicsMenuUI.GGFJGHHHEJC.SetUpZoom(1, NOKFNLBADMO: true);
		yield return null;
		loadingScene2 = SceneManager.UnloadSceneAsync(SceneManager.GetSceneByName("Beach"));
		while (!loadingScene2.isDone)
		{
			progress = 0.9f + loadingScene2.progress * 0.1f;
			yield return CommonReferences.wait02;
		}
		active = false;
		progress = 1f;
	}

	private void OKHLEMPJONN()
	{
		instance = this;
	}

	public void LIKOIFGPAKM()
	{
		active = false;
		((MonoBehaviour)this).StartCoroutine(NAHIHNGLNDO());
	}

	private void GANBBAGDALD()
	{
		instance = this;
	}

	public IEnumerator AJDAKHKANBA()
	{
		Debug.Log((object)"Test Beach Scene");
		((CinemachineVirtualCameraBase)cinemachineVirtualCamera).Follow = ((Component)waterTestPosition).transform;
		AsyncOperation loadingScene2 = SceneManager.LoadSceneAsync("Beach", (LoadSceneMode)1);
		while (!loadingScene2.isDone)
		{
			progress = loadingScene2.progress * 0.5f;
			yield return CommonReferences.wait02;
		}
		yield return CommonReferences.wait1;
		progress = 0.6f;
		Debug.Log((object)"Start water quality test");
		yield return null;
		GraphicsMenuUI.GGFJGHHHEJC.ApplyZoom(1, 0);
		QualityManager.SetQuality(1);
		yield return null;
		float totalDeltaTime = 0f;
		MMIOHHKNADI = 0f;
		while (true)
		{
			totalDeltaTime += Time.deltaTime;
			progress = 0.6f + totalDeltaTime / MBDHPNNLKOO * 0.3f;
			MMIOHHKNADI += 1f;
			if (totalDeltaTime > MBDHPNNLKOO)
			{
				break;
			}
			yield return null;
		}
		float num = MMIOHHKNADI / totalDeltaTime;
		Debug.Log((object)("Frame Time Average: " + num));
		if (num < (float)FIBEFHOBOII)
		{
			Debug.Log((object)"Reducing quality water to Low");
			PlayerPrefs.SetInt("qualityWater", 0);
			QualityManager.SetQuality(0);
		}
		else
		{
			Debug.Log((object)"High quality water");
			PlayerPrefs.SetInt("qualityWater", 1);
			QualityManager.SetQuality(1);
		}
		PlayerPrefs.SetInt("waterQualityTestDone", 1);
		GraphicsMenuUI.GGFJGHHHEJC.SetUpZoom(1, NOKFNLBADMO: true);
		yield return null;
		loadingScene2 = SceneManager.UnloadSceneAsync(SceneManager.GetSceneByName("Beach"));
		while (!loadingScene2.isDone)
		{
			progress = 0.9f + loadingScene2.progress * 0.1f;
			yield return CommonReferences.wait02;
		}
		active = false;
		progress = 1f;
	}

	public IEnumerator BMENHIFHJMF()
	{
		Debug.Log((object)"Test Beach Scene");
		((CinemachineVirtualCameraBase)cinemachineVirtualCamera).Follow = ((Component)waterTestPosition).transform;
		AsyncOperation loadingScene2 = SceneManager.LoadSceneAsync("Beach", (LoadSceneMode)1);
		while (!loadingScene2.isDone)
		{
			progress = loadingScene2.progress * 0.5f;
			yield return CommonReferences.wait02;
		}
		yield return CommonReferences.wait1;
		progress = 0.6f;
		Debug.Log((object)"Start water quality test");
		yield return null;
		GraphicsMenuUI.GGFJGHHHEJC.ApplyZoom(1, 0);
		QualityManager.SetQuality(1);
		yield return null;
		float totalDeltaTime = 0f;
		MMIOHHKNADI = 0f;
		while (true)
		{
			totalDeltaTime += Time.deltaTime;
			progress = 0.6f + totalDeltaTime / MBDHPNNLKOO * 0.3f;
			MMIOHHKNADI += 1f;
			if (totalDeltaTime > MBDHPNNLKOO)
			{
				break;
			}
			yield return null;
		}
		float num = MMIOHHKNADI / totalDeltaTime;
		Debug.Log((object)("Frame Time Average: " + num));
		if (num < (float)FIBEFHOBOII)
		{
			Debug.Log((object)"Reducing quality water to Low");
			PlayerPrefs.SetInt("qualityWater", 0);
			QualityManager.SetQuality(0);
		}
		else
		{
			Debug.Log((object)"High quality water");
			PlayerPrefs.SetInt("qualityWater", 1);
			QualityManager.SetQuality(1);
		}
		PlayerPrefs.SetInt("waterQualityTestDone", 1);
		GraphicsMenuUI.GGFJGHHHEJC.SetUpZoom(1, NOKFNLBADMO: true);
		yield return null;
		loadingScene2 = SceneManager.UnloadSceneAsync(SceneManager.GetSceneByName("Beach"));
		while (!loadingScene2.isDone)
		{
			progress = 0.9f + loadingScene2.progress * 0.1f;
			yield return CommonReferences.wait02;
		}
		active = false;
		progress = 1f;
	}

	private void GONDLJKGLGO()
	{
		instance = this;
	}

	private void Awake()
	{
		instance = this;
	}

	public IEnumerator NEEEELOABCH()
	{
		return new OACFKPCCDBF(1)
		{
			_003C_003E4__this = this
		};
	}

	private void KBNMLJNBBMP()
	{
		instance = this;
	}

	public void OIAFDGPIPBN()
	{
		active = false;
		((MonoBehaviour)this).StartCoroutine(PJKKOIMMFEG());
	}

	public void JNHKHOHHKFB()
	{
		active = false;
		((MonoBehaviour)this).StartCoroutine(EABHJOAKFEB());
	}

	public IEnumerator HDEBKGACJEK()
	{
		Debug.Log((object)"Test Beach Scene");
		((CinemachineVirtualCameraBase)cinemachineVirtualCamera).Follow = ((Component)waterTestPosition).transform;
		AsyncOperation loadingScene2 = SceneManager.LoadSceneAsync("Beach", (LoadSceneMode)1);
		while (!loadingScene2.isDone)
		{
			progress = loadingScene2.progress * 0.5f;
			yield return CommonReferences.wait02;
		}
		yield return CommonReferences.wait1;
		progress = 0.6f;
		Debug.Log((object)"Start water quality test");
		yield return null;
		GraphicsMenuUI.GGFJGHHHEJC.ApplyZoom(1, 0);
		QualityManager.SetQuality(1);
		yield return null;
		float totalDeltaTime = 0f;
		MMIOHHKNADI = 0f;
		while (true)
		{
			totalDeltaTime += Time.deltaTime;
			progress = 0.6f + totalDeltaTime / MBDHPNNLKOO * 0.3f;
			MMIOHHKNADI += 1f;
			if (totalDeltaTime > MBDHPNNLKOO)
			{
				break;
			}
			yield return null;
		}
		float num = MMIOHHKNADI / totalDeltaTime;
		Debug.Log((object)("Frame Time Average: " + num));
		if (num < (float)FIBEFHOBOII)
		{
			Debug.Log((object)"Reducing quality water to Low");
			PlayerPrefs.SetInt("qualityWater", 0);
			QualityManager.SetQuality(0);
		}
		else
		{
			Debug.Log((object)"High quality water");
			PlayerPrefs.SetInt("qualityWater", 1);
			QualityManager.SetQuality(1);
		}
		PlayerPrefs.SetInt("waterQualityTestDone", 1);
		GraphicsMenuUI.GGFJGHHHEJC.SetUpZoom(1, NOKFNLBADMO: true);
		yield return null;
		loadingScene2 = SceneManager.UnloadSceneAsync(SceneManager.GetSceneByName("Beach"));
		while (!loadingScene2.isDone)
		{
			progress = 0.9f + loadingScene2.progress * 0.1f;
			yield return CommonReferences.wait02;
		}
		active = false;
		progress = 1f;
	}

	private void GECHJIGBPEN()
	{
		instance = this;
	}

	public IEnumerator FBJBJKIMLNC()
	{
		Debug.Log((object)"Test Beach Scene");
		((CinemachineVirtualCameraBase)cinemachineVirtualCamera).Follow = ((Component)waterTestPosition).transform;
		AsyncOperation loadingScene2 = SceneManager.LoadSceneAsync("Beach", (LoadSceneMode)1);
		while (!loadingScene2.isDone)
		{
			progress = loadingScene2.progress * 0.5f;
			yield return CommonReferences.wait02;
		}
		yield return CommonReferences.wait1;
		progress = 0.6f;
		Debug.Log((object)"Start water quality test");
		yield return null;
		GraphicsMenuUI.GGFJGHHHEJC.ApplyZoom(1, 0);
		QualityManager.SetQuality(1);
		yield return null;
		float totalDeltaTime = 0f;
		MMIOHHKNADI = 0f;
		while (true)
		{
			totalDeltaTime += Time.deltaTime;
			progress = 0.6f + totalDeltaTime / MBDHPNNLKOO * 0.3f;
			MMIOHHKNADI += 1f;
			if (totalDeltaTime > MBDHPNNLKOO)
			{
				break;
			}
			yield return null;
		}
		float num = MMIOHHKNADI / totalDeltaTime;
		Debug.Log((object)("Frame Time Average: " + num));
		if (num < (float)FIBEFHOBOII)
		{
			Debug.Log((object)"Reducing quality water to Low");
			PlayerPrefs.SetInt("qualityWater", 0);
			QualityManager.SetQuality(0);
		}
		else
		{
			Debug.Log((object)"High quality water");
			PlayerPrefs.SetInt("qualityWater", 1);
			QualityManager.SetQuality(1);
		}
		PlayerPrefs.SetInt("waterQualityTestDone", 1);
		GraphicsMenuUI.GGFJGHHHEJC.SetUpZoom(1, NOKFNLBADMO: true);
		yield return null;
		loadingScene2 = SceneManager.UnloadSceneAsync(SceneManager.GetSceneByName("Beach"));
		while (!loadingScene2.isDone)
		{
			progress = 0.9f + loadingScene2.progress * 0.1f;
			yield return CommonReferences.wait02;
		}
		active = false;
		progress = 1f;
	}

	public IEnumerator NIDLNEKGEHA()
	{
		return new OACFKPCCDBF(1)
		{
			_003C_003E4__this = this
		};
	}

	private void BFJOEMCBJJO()
	{
		instance = this;
	}

	public void BPAIKEPPBFK()
	{
		active = true;
		((MonoBehaviour)this).StartCoroutine(DJOOJCCNFHI());
	}

	private void PDIECJCKCOD()
	{
		instance = this;
	}

	public IEnumerator MEJGKGBLPEP()
	{
		Debug.Log((object)"Test Beach Scene");
		((CinemachineVirtualCameraBase)cinemachineVirtualCamera).Follow = ((Component)waterTestPosition).transform;
		AsyncOperation loadingScene2 = SceneManager.LoadSceneAsync("Beach", (LoadSceneMode)1);
		while (!loadingScene2.isDone)
		{
			progress = loadingScene2.progress * 0.5f;
			yield return CommonReferences.wait02;
		}
		yield return CommonReferences.wait1;
		progress = 0.6f;
		Debug.Log((object)"Start water quality test");
		yield return null;
		GraphicsMenuUI.GGFJGHHHEJC.ApplyZoom(1, 0);
		QualityManager.SetQuality(1);
		yield return null;
		float totalDeltaTime = 0f;
		MMIOHHKNADI = 0f;
		while (true)
		{
			totalDeltaTime += Time.deltaTime;
			progress = 0.6f + totalDeltaTime / MBDHPNNLKOO * 0.3f;
			MMIOHHKNADI += 1f;
			if (totalDeltaTime > MBDHPNNLKOO)
			{
				break;
			}
			yield return null;
		}
		float num = MMIOHHKNADI / totalDeltaTime;
		Debug.Log((object)("Frame Time Average: " + num));
		if (num < (float)FIBEFHOBOII)
		{
			Debug.Log((object)"Reducing quality water to Low");
			PlayerPrefs.SetInt("qualityWater", 0);
			QualityManager.SetQuality(0);
		}
		else
		{
			Debug.Log((object)"High quality water");
			PlayerPrefs.SetInt("qualityWater", 1);
			QualityManager.SetQuality(1);
		}
		PlayerPrefs.SetInt("waterQualityTestDone", 1);
		GraphicsMenuUI.GGFJGHHHEJC.SetUpZoom(1, NOKFNLBADMO: true);
		yield return null;
		loadingScene2 = SceneManager.UnloadSceneAsync(SceneManager.GetSceneByName("Beach"));
		while (!loadingScene2.isDone)
		{
			progress = 0.9f + loadingScene2.progress * 0.1f;
			yield return CommonReferences.wait02;
		}
		active = false;
		progress = 1f;
	}

	public IEnumerator JLEENBKMGFM()
	{
		return new OACFKPCCDBF(1)
		{
			_003C_003E4__this = this
		};
	}

	public IEnumerator IKHECAPNMGO()
	{
		return new OACFKPCCDBF(1)
		{
			_003C_003E4__this = this
		};
	}

	public IEnumerator BHBNCKIOGDH()
	{
		Debug.Log((object)"Test Beach Scene");
		((CinemachineVirtualCameraBase)cinemachineVirtualCamera).Follow = ((Component)waterTestPosition).transform;
		AsyncOperation loadingScene2 = SceneManager.LoadSceneAsync("Beach", (LoadSceneMode)1);
		while (!loadingScene2.isDone)
		{
			progress = loadingScene2.progress * 0.5f;
			yield return CommonReferences.wait02;
		}
		yield return CommonReferences.wait1;
		progress = 0.6f;
		Debug.Log((object)"Start water quality test");
		yield return null;
		GraphicsMenuUI.GGFJGHHHEJC.ApplyZoom(1, 0);
		QualityManager.SetQuality(1);
		yield return null;
		float totalDeltaTime = 0f;
		MMIOHHKNADI = 0f;
		while (true)
		{
			totalDeltaTime += Time.deltaTime;
			progress = 0.6f + totalDeltaTime / MBDHPNNLKOO * 0.3f;
			MMIOHHKNADI += 1f;
			if (totalDeltaTime > MBDHPNNLKOO)
			{
				break;
			}
			yield return null;
		}
		float num = MMIOHHKNADI / totalDeltaTime;
		Debug.Log((object)("Frame Time Average: " + num));
		if (num < (float)FIBEFHOBOII)
		{
			Debug.Log((object)"Reducing quality water to Low");
			PlayerPrefs.SetInt("qualityWater", 0);
			QualityManager.SetQuality(0);
		}
		else
		{
			Debug.Log((object)"High quality water");
			PlayerPrefs.SetInt("qualityWater", 1);
			QualityManager.SetQuality(1);
		}
		PlayerPrefs.SetInt("waterQualityTestDone", 1);
		GraphicsMenuUI.GGFJGHHHEJC.SetUpZoom(1, NOKFNLBADMO: true);
		yield return null;
		loadingScene2 = SceneManager.UnloadSceneAsync(SceneManager.GetSceneByName("Beach"));
		while (!loadingScene2.isDone)
		{
			progress = 0.9f + loadingScene2.progress * 0.1f;
			yield return CommonReferences.wait02;
		}
		active = false;
		progress = 1f;
	}

	public IEnumerator BBHFHBBNOFG()
	{
		Debug.Log((object)"Test Beach Scene");
		((CinemachineVirtualCameraBase)cinemachineVirtualCamera).Follow = ((Component)waterTestPosition).transform;
		AsyncOperation loadingScene2 = SceneManager.LoadSceneAsync("Beach", (LoadSceneMode)1);
		while (!loadingScene2.isDone)
		{
			progress = loadingScene2.progress * 0.5f;
			yield return CommonReferences.wait02;
		}
		yield return CommonReferences.wait1;
		progress = 0.6f;
		Debug.Log((object)"Start water quality test");
		yield return null;
		GraphicsMenuUI.GGFJGHHHEJC.ApplyZoom(1, 0);
		QualityManager.SetQuality(1);
		yield return null;
		float totalDeltaTime = 0f;
		MMIOHHKNADI = 0f;
		while (true)
		{
			totalDeltaTime += Time.deltaTime;
			progress = 0.6f + totalDeltaTime / MBDHPNNLKOO * 0.3f;
			MMIOHHKNADI += 1f;
			if (totalDeltaTime > MBDHPNNLKOO)
			{
				break;
			}
			yield return null;
		}
		float num = MMIOHHKNADI / totalDeltaTime;
		Debug.Log((object)("Frame Time Average: " + num));
		if (num < (float)FIBEFHOBOII)
		{
			Debug.Log((object)"Reducing quality water to Low");
			PlayerPrefs.SetInt("qualityWater", 0);
			QualityManager.SetQuality(0);
		}
		else
		{
			Debug.Log((object)"High quality water");
			PlayerPrefs.SetInt("qualityWater", 1);
			QualityManager.SetQuality(1);
		}
		PlayerPrefs.SetInt("waterQualityTestDone", 1);
		GraphicsMenuUI.GGFJGHHHEJC.SetUpZoom(1, NOKFNLBADMO: true);
		yield return null;
		loadingScene2 = SceneManager.UnloadSceneAsync(SceneManager.GetSceneByName("Beach"));
		while (!loadingScene2.isDone)
		{
			progress = 0.9f + loadingScene2.progress * 0.1f;
			yield return CommonReferences.wait02;
		}
		active = false;
		progress = 1f;
	}

	public void BOEHFPMECHK()
	{
		active = true;
		((MonoBehaviour)this).StartCoroutine(KCLNHFMECKM());
	}

	public IEnumerator DJOOJCCNFHI()
	{
		Debug.Log((object)"Test Beach Scene");
		((CinemachineVirtualCameraBase)cinemachineVirtualCamera).Follow = ((Component)waterTestPosition).transform;
		AsyncOperation loadingScene2 = SceneManager.LoadSceneAsync("Beach", (LoadSceneMode)1);
		while (!loadingScene2.isDone)
		{
			progress = loadingScene2.progress * 0.5f;
			yield return CommonReferences.wait02;
		}
		yield return CommonReferences.wait1;
		progress = 0.6f;
		Debug.Log((object)"Start water quality test");
		yield return null;
		GraphicsMenuUI.GGFJGHHHEJC.ApplyZoom(1, 0);
		QualityManager.SetQuality(1);
		yield return null;
		float totalDeltaTime = 0f;
		MMIOHHKNADI = 0f;
		while (true)
		{
			totalDeltaTime += Time.deltaTime;
			progress = 0.6f + totalDeltaTime / MBDHPNNLKOO * 0.3f;
			MMIOHHKNADI += 1f;
			if (totalDeltaTime > MBDHPNNLKOO)
			{
				break;
			}
			yield return null;
		}
		float num = MMIOHHKNADI / totalDeltaTime;
		Debug.Log((object)("Frame Time Average: " + num));
		if (num < (float)FIBEFHOBOII)
		{
			Debug.Log((object)"Reducing quality water to Low");
			PlayerPrefs.SetInt("qualityWater", 0);
			QualityManager.SetQuality(0);
		}
		else
		{
			Debug.Log((object)"High quality water");
			PlayerPrefs.SetInt("qualityWater", 1);
			QualityManager.SetQuality(1);
		}
		PlayerPrefs.SetInt("waterQualityTestDone", 1);
		GraphicsMenuUI.GGFJGHHHEJC.SetUpZoom(1, NOKFNLBADMO: true);
		yield return null;
		loadingScene2 = SceneManager.UnloadSceneAsync(SceneManager.GetSceneByName("Beach"));
		while (!loadingScene2.isDone)
		{
			progress = 0.9f + loadingScene2.progress * 0.1f;
			yield return CommonReferences.wait02;
		}
		active = false;
		progress = 1f;
	}

	private void COKBJNMAMDI()
	{
		instance = this;
	}

	public void CMEFILBIHKI()
	{
		active = false;
		((MonoBehaviour)this).StartCoroutine(HFKDKMGHKEH());
	}

	public IEnumerator KMMHKMDGLJD()
	{
		Debug.Log((object)"Test Beach Scene");
		((CinemachineVirtualCameraBase)cinemachineVirtualCamera).Follow = ((Component)waterTestPosition).transform;
		AsyncOperation loadingScene2 = SceneManager.LoadSceneAsync("Beach", (LoadSceneMode)1);
		while (!loadingScene2.isDone)
		{
			progress = loadingScene2.progress * 0.5f;
			yield return CommonReferences.wait02;
		}
		yield return CommonReferences.wait1;
		progress = 0.6f;
		Debug.Log((object)"Start water quality test");
		yield return null;
		GraphicsMenuUI.GGFJGHHHEJC.ApplyZoom(1, 0);
		QualityManager.SetQuality(1);
		yield return null;
		float totalDeltaTime = 0f;
		MMIOHHKNADI = 0f;
		while (true)
		{
			totalDeltaTime += Time.deltaTime;
			progress = 0.6f + totalDeltaTime / MBDHPNNLKOO * 0.3f;
			MMIOHHKNADI += 1f;
			if (totalDeltaTime > MBDHPNNLKOO)
			{
				break;
			}
			yield return null;
		}
		float num = MMIOHHKNADI / totalDeltaTime;
		Debug.Log((object)("Frame Time Average: " + num));
		if (num < (float)FIBEFHOBOII)
		{
			Debug.Log((object)"Reducing quality water to Low");
			PlayerPrefs.SetInt("qualityWater", 0);
			QualityManager.SetQuality(0);
		}
		else
		{
			Debug.Log((object)"High quality water");
			PlayerPrefs.SetInt("qualityWater", 1);
			QualityManager.SetQuality(1);
		}
		PlayerPrefs.SetInt("waterQualityTestDone", 1);
		GraphicsMenuUI.GGFJGHHHEJC.SetUpZoom(1, NOKFNLBADMO: true);
		yield return null;
		loadingScene2 = SceneManager.UnloadSceneAsync(SceneManager.GetSceneByName("Beach"));
		while (!loadingScene2.isDone)
		{
			progress = 0.9f + loadingScene2.progress * 0.1f;
			yield return CommonReferences.wait02;
		}
		active = false;
		progress = 1f;
	}

	public IEnumerator PFOFOHNEHMF()
	{
		return new OACFKPCCDBF(1)
		{
			_003C_003E4__this = this
		};
	}

	private void GHOKECKAICE()
	{
		instance = this;
	}

	public void KAAJEKKDPDA()
	{
		active = true;
		((MonoBehaviour)this).StartCoroutine(HDEBKGACJEK());
	}

	private void PHJKJHKAABL()
	{
		instance = this;
	}

	private void FCNKGINGJNM()
	{
		instance = this;
	}

	public void DIOEBOKNPHI()
	{
		active = true;
		((MonoBehaviour)this).StartCoroutine(JGEFKCHEAJJ());
	}

	private void ONIALAOGMCF()
	{
		instance = this;
	}

	private void HDHPOAPLEJC()
	{
		instance = this;
	}

	private void ILCLIJOHKHG()
	{
		instance = this;
	}

	public void KEHFCJLIBEK()
	{
		active = false;
		((MonoBehaviour)this).StartCoroutine(MEJGKGBLPEP());
	}

	public void KICMMIIJJJE()
	{
		active = false;
		((MonoBehaviour)this).StartCoroutine(OFPPEPMHJJA());
	}

	public IEnumerator MFOEEKHKAEH()
	{
		Debug.Log((object)"Test Beach Scene");
		((CinemachineVirtualCameraBase)cinemachineVirtualCamera).Follow = ((Component)waterTestPosition).transform;
		AsyncOperation loadingScene2 = SceneManager.LoadSceneAsync("Beach", (LoadSceneMode)1);
		while (!loadingScene2.isDone)
		{
			progress = loadingScene2.progress * 0.5f;
			yield return CommonReferences.wait02;
		}
		yield return CommonReferences.wait1;
		progress = 0.6f;
		Debug.Log((object)"Start water quality test");
		yield return null;
		GraphicsMenuUI.GGFJGHHHEJC.ApplyZoom(1, 0);
		QualityManager.SetQuality(1);
		yield return null;
		float totalDeltaTime = 0f;
		MMIOHHKNADI = 0f;
		while (true)
		{
			totalDeltaTime += Time.deltaTime;
			progress = 0.6f + totalDeltaTime / MBDHPNNLKOO * 0.3f;
			MMIOHHKNADI += 1f;
			if (totalDeltaTime > MBDHPNNLKOO)
			{
				break;
			}
			yield return null;
		}
		float num = MMIOHHKNADI / totalDeltaTime;
		Debug.Log((object)("Frame Time Average: " + num));
		if (num < (float)FIBEFHOBOII)
		{
			Debug.Log((object)"Reducing quality water to Low");
			PlayerPrefs.SetInt("qualityWater", 0);
			QualityManager.SetQuality(0);
		}
		else
		{
			Debug.Log((object)"High quality water");
			PlayerPrefs.SetInt("qualityWater", 1);
			QualityManager.SetQuality(1);
		}
		PlayerPrefs.SetInt("waterQualityTestDone", 1);
		GraphicsMenuUI.GGFJGHHHEJC.SetUpZoom(1, NOKFNLBADMO: true);
		yield return null;
		loadingScene2 = SceneManager.UnloadSceneAsync(SceneManager.GetSceneByName("Beach"));
		while (!loadingScene2.isDone)
		{
			progress = 0.9f + loadingScene2.progress * 0.1f;
			yield return CommonReferences.wait02;
		}
		active = false;
		progress = 1f;
	}

	private void IHICKHAABJH()
	{
		instance = this;
	}

	private void PEFKNEPONAG()
	{
		instance = this;
	}

	private void IBMDFNKKPJF()
	{
		instance = this;
	}

	public IEnumerator MFANEJIDLFH()
	{
		Debug.Log((object)"Test Beach Scene");
		((CinemachineVirtualCameraBase)cinemachineVirtualCamera).Follow = ((Component)waterTestPosition).transform;
		AsyncOperation loadingScene2 = SceneManager.LoadSceneAsync("Beach", (LoadSceneMode)1);
		while (!loadingScene2.isDone)
		{
			progress = loadingScene2.progress * 0.5f;
			yield return CommonReferences.wait02;
		}
		yield return CommonReferences.wait1;
		progress = 0.6f;
		Debug.Log((object)"Start water quality test");
		yield return null;
		GraphicsMenuUI.GGFJGHHHEJC.ApplyZoom(1, 0);
		QualityManager.SetQuality(1);
		yield return null;
		float totalDeltaTime = 0f;
		MMIOHHKNADI = 0f;
		while (true)
		{
			totalDeltaTime += Time.deltaTime;
			progress = 0.6f + totalDeltaTime / MBDHPNNLKOO * 0.3f;
			MMIOHHKNADI += 1f;
			if (totalDeltaTime > MBDHPNNLKOO)
			{
				break;
			}
			yield return null;
		}
		float num = MMIOHHKNADI / totalDeltaTime;
		Debug.Log((object)("Frame Time Average: " + num));
		if (num < (float)FIBEFHOBOII)
		{
			Debug.Log((object)"Reducing quality water to Low");
			PlayerPrefs.SetInt("qualityWater", 0);
			QualityManager.SetQuality(0);
		}
		else
		{
			Debug.Log((object)"High quality water");
			PlayerPrefs.SetInt("qualityWater", 1);
			QualityManager.SetQuality(1);
		}
		PlayerPrefs.SetInt("waterQualityTestDone", 1);
		GraphicsMenuUI.GGFJGHHHEJC.SetUpZoom(1, NOKFNLBADMO: true);
		yield return null;
		loadingScene2 = SceneManager.UnloadSceneAsync(SceneManager.GetSceneByName("Beach"));
		while (!loadingScene2.isDone)
		{
			progress = 0.9f + loadingScene2.progress * 0.1f;
			yield return CommonReferences.wait02;
		}
		active = false;
		progress = 1f;
	}

	private void FFHIGDJEFJE()
	{
		instance = this;
	}

	public void APLGJOIKIBK()
	{
		active = true;
		((MonoBehaviour)this).StartCoroutine(JBBCMAKFMPD());
	}

	public IEnumerator JBBCMAKFMPD()
	{
		Debug.Log((object)"Test Beach Scene");
		((CinemachineVirtualCameraBase)cinemachineVirtualCamera).Follow = ((Component)waterTestPosition).transform;
		AsyncOperation loadingScene2 = SceneManager.LoadSceneAsync("Beach", (LoadSceneMode)1);
		while (!loadingScene2.isDone)
		{
			progress = loadingScene2.progress * 0.5f;
			yield return CommonReferences.wait02;
		}
		yield return CommonReferences.wait1;
		progress = 0.6f;
		Debug.Log((object)"Start water quality test");
		yield return null;
		GraphicsMenuUI.GGFJGHHHEJC.ApplyZoom(1, 0);
		QualityManager.SetQuality(1);
		yield return null;
		float totalDeltaTime = 0f;
		MMIOHHKNADI = 0f;
		while (true)
		{
			totalDeltaTime += Time.deltaTime;
			progress = 0.6f + totalDeltaTime / MBDHPNNLKOO * 0.3f;
			MMIOHHKNADI += 1f;
			if (totalDeltaTime > MBDHPNNLKOO)
			{
				break;
			}
			yield return null;
		}
		float num = MMIOHHKNADI / totalDeltaTime;
		Debug.Log((object)("Frame Time Average: " + num));
		if (num < (float)FIBEFHOBOII)
		{
			Debug.Log((object)"Reducing quality water to Low");
			PlayerPrefs.SetInt("qualityWater", 0);
			QualityManager.SetQuality(0);
		}
		else
		{
			Debug.Log((object)"High quality water");
			PlayerPrefs.SetInt("qualityWater", 1);
			QualityManager.SetQuality(1);
		}
		PlayerPrefs.SetInt("waterQualityTestDone", 1);
		GraphicsMenuUI.GGFJGHHHEJC.SetUpZoom(1, NOKFNLBADMO: true);
		yield return null;
		loadingScene2 = SceneManager.UnloadSceneAsync(SceneManager.GetSceneByName("Beach"));
		while (!loadingScene2.isDone)
		{
			progress = 0.9f + loadingScene2.progress * 0.1f;
			yield return CommonReferences.wait02;
		}
		active = false;
		progress = 1f;
	}

	public void JLNFAPHALEL()
	{
		active = true;
		((MonoBehaviour)this).StartCoroutine(MFOEEKHKAEH());
	}

	public IEnumerator NHNMEOAPPPI()
	{
		Debug.Log((object)"Test Beach Scene");
		((CinemachineVirtualCameraBase)cinemachineVirtualCamera).Follow = ((Component)waterTestPosition).transform;
		AsyncOperation loadingScene2 = SceneManager.LoadSceneAsync("Beach", (LoadSceneMode)1);
		while (!loadingScene2.isDone)
		{
			progress = loadingScene2.progress * 0.5f;
			yield return CommonReferences.wait02;
		}
		yield return CommonReferences.wait1;
		progress = 0.6f;
		Debug.Log((object)"Start water quality test");
		yield return null;
		GraphicsMenuUI.GGFJGHHHEJC.ApplyZoom(1, 0);
		QualityManager.SetQuality(1);
		yield return null;
		float totalDeltaTime = 0f;
		MMIOHHKNADI = 0f;
		while (true)
		{
			totalDeltaTime += Time.deltaTime;
			progress = 0.6f + totalDeltaTime / MBDHPNNLKOO * 0.3f;
			MMIOHHKNADI += 1f;
			if (totalDeltaTime > MBDHPNNLKOO)
			{
				break;
			}
			yield return null;
		}
		float num = MMIOHHKNADI / totalDeltaTime;
		Debug.Log((object)("Frame Time Average: " + num));
		if (num < (float)FIBEFHOBOII)
		{
			Debug.Log((object)"Reducing quality water to Low");
			PlayerPrefs.SetInt("qualityWater", 0);
			QualityManager.SetQuality(0);
		}
		else
		{
			Debug.Log((object)"High quality water");
			PlayerPrefs.SetInt("qualityWater", 1);
			QualityManager.SetQuality(1);
		}
		PlayerPrefs.SetInt("waterQualityTestDone", 1);
		GraphicsMenuUI.GGFJGHHHEJC.SetUpZoom(1, NOKFNLBADMO: true);
		yield return null;
		loadingScene2 = SceneManager.UnloadSceneAsync(SceneManager.GetSceneByName("Beach"));
		while (!loadingScene2.isDone)
		{
			progress = 0.9f + loadingScene2.progress * 0.1f;
			yield return CommonReferences.wait02;
		}
		active = false;
		progress = 1f;
	}

	public IEnumerator HJMAHNDOAMJ()
	{
		return new OACFKPCCDBF(1)
		{
			_003C_003E4__this = this
		};
	}

	public IEnumerator CGOCJOEPJDI()
	{
		Debug.Log((object)"Test Beach Scene");
		((CinemachineVirtualCameraBase)cinemachineVirtualCamera).Follow = ((Component)waterTestPosition).transform;
		AsyncOperation loadingScene2 = SceneManager.LoadSceneAsync("Beach", (LoadSceneMode)1);
		while (!loadingScene2.isDone)
		{
			progress = loadingScene2.progress * 0.5f;
			yield return CommonReferences.wait02;
		}
		yield return CommonReferences.wait1;
		progress = 0.6f;
		Debug.Log((object)"Start water quality test");
		yield return null;
		GraphicsMenuUI.GGFJGHHHEJC.ApplyZoom(1, 0);
		QualityManager.SetQuality(1);
		yield return null;
		float totalDeltaTime = 0f;
		MMIOHHKNADI = 0f;
		while (true)
		{
			totalDeltaTime += Time.deltaTime;
			progress = 0.6f + totalDeltaTime / MBDHPNNLKOO * 0.3f;
			MMIOHHKNADI += 1f;
			if (totalDeltaTime > MBDHPNNLKOO)
			{
				break;
			}
			yield return null;
		}
		float num = MMIOHHKNADI / totalDeltaTime;
		Debug.Log((object)("Frame Time Average: " + num));
		if (num < (float)FIBEFHOBOII)
		{
			Debug.Log((object)"Reducing quality water to Low");
			PlayerPrefs.SetInt("qualityWater", 0);
			QualityManager.SetQuality(0);
		}
		else
		{
			Debug.Log((object)"High quality water");
			PlayerPrefs.SetInt("qualityWater", 1);
			QualityManager.SetQuality(1);
		}
		PlayerPrefs.SetInt("waterQualityTestDone", 1);
		GraphicsMenuUI.GGFJGHHHEJC.SetUpZoom(1, NOKFNLBADMO: true);
		yield return null;
		loadingScene2 = SceneManager.UnloadSceneAsync(SceneManager.GetSceneByName("Beach"));
		while (!loadingScene2.isDone)
		{
			progress = 0.9f + loadingScene2.progress * 0.1f;
			yield return CommonReferences.wait02;
		}
		active = false;
		progress = 1f;
	}

	private void AGLMGDNBHBF()
	{
		instance = this;
	}

	public void OBBKLGDKPPC()
	{
		active = true;
		((MonoBehaviour)this).StartCoroutine(KMMHKMDGLJD());
	}

	private void MFJIHCKEIIF()
	{
		instance = this;
	}

	public void BBGCFNCAPIH()
	{
		active = true;
		((MonoBehaviour)this).StartCoroutine(JLEENBKMGFM());
	}

	public void MHBMPLKAAIF()
	{
		active = false;
		((MonoBehaviour)this).StartCoroutine(HJMAHNDOAMJ());
	}

	public void JDFFMBDDFOF()
	{
		active = true;
		((MonoBehaviour)this).StartCoroutine(AMMOHLGCICP());
	}

	public IEnumerator BBDGLFACAGB()
	{
		return new OACFKPCCDBF(1)
		{
			_003C_003E4__this = this
		};
	}

	public IEnumerator CJKOIDLMMKK()
	{
		Debug.Log((object)"Test Beach Scene");
		((CinemachineVirtualCameraBase)cinemachineVirtualCamera).Follow = ((Component)waterTestPosition).transform;
		AsyncOperation loadingScene2 = SceneManager.LoadSceneAsync("Beach", (LoadSceneMode)1);
		while (!loadingScene2.isDone)
		{
			progress = loadingScene2.progress * 0.5f;
			yield return CommonReferences.wait02;
		}
		yield return CommonReferences.wait1;
		progress = 0.6f;
		Debug.Log((object)"Start water quality test");
		yield return null;
		GraphicsMenuUI.GGFJGHHHEJC.ApplyZoom(1, 0);
		QualityManager.SetQuality(1);
		yield return null;
		float totalDeltaTime = 0f;
		MMIOHHKNADI = 0f;
		while (true)
		{
			totalDeltaTime += Time.deltaTime;
			progress = 0.6f + totalDeltaTime / MBDHPNNLKOO * 0.3f;
			MMIOHHKNADI += 1f;
			if (totalDeltaTime > MBDHPNNLKOO)
			{
				break;
			}
			yield return null;
		}
		float num = MMIOHHKNADI / totalDeltaTime;
		Debug.Log((object)("Frame Time Average: " + num));
		if (num < (float)FIBEFHOBOII)
		{
			Debug.Log((object)"Reducing quality water to Low");
			PlayerPrefs.SetInt("qualityWater", 0);
			QualityManager.SetQuality(0);
		}
		else
		{
			Debug.Log((object)"High quality water");
			PlayerPrefs.SetInt("qualityWater", 1);
			QualityManager.SetQuality(1);
		}
		PlayerPrefs.SetInt("waterQualityTestDone", 1);
		GraphicsMenuUI.GGFJGHHHEJC.SetUpZoom(1, NOKFNLBADMO: true);
		yield return null;
		loadingScene2 = SceneManager.UnloadSceneAsync(SceneManager.GetSceneByName("Beach"));
		while (!loadingScene2.isDone)
		{
			progress = 0.9f + loadingScene2.progress * 0.1f;
			yield return CommonReferences.wait02;
		}
		active = false;
		progress = 1f;
	}

	public void OFBGKPHIDEO()
	{
		active = true;
		((MonoBehaviour)this).StartCoroutine(PJKKOIMMFEG());
	}

	public IEnumerator AIBIMMBECJJ()
	{
		Debug.Log((object)"Test Beach Scene");
		((CinemachineVirtualCameraBase)cinemachineVirtualCamera).Follow = ((Component)waterTestPosition).transform;
		AsyncOperation loadingScene2 = SceneManager.LoadSceneAsync("Beach", (LoadSceneMode)1);
		while (!loadingScene2.isDone)
		{
			progress = loadingScene2.progress * 0.5f;
			yield return CommonReferences.wait02;
		}
		yield return CommonReferences.wait1;
		progress = 0.6f;
		Debug.Log((object)"Start water quality test");
		yield return null;
		GraphicsMenuUI.GGFJGHHHEJC.ApplyZoom(1, 0);
		QualityManager.SetQuality(1);
		yield return null;
		float totalDeltaTime = 0f;
		MMIOHHKNADI = 0f;
		while (true)
		{
			totalDeltaTime += Time.deltaTime;
			progress = 0.6f + totalDeltaTime / MBDHPNNLKOO * 0.3f;
			MMIOHHKNADI += 1f;
			if (totalDeltaTime > MBDHPNNLKOO)
			{
				break;
			}
			yield return null;
		}
		float num = MMIOHHKNADI / totalDeltaTime;
		Debug.Log((object)("Frame Time Average: " + num));
		if (num < (float)FIBEFHOBOII)
		{
			Debug.Log((object)"Reducing quality water to Low");
			PlayerPrefs.SetInt("qualityWater", 0);
			QualityManager.SetQuality(0);
		}
		else
		{
			Debug.Log((object)"High quality water");
			PlayerPrefs.SetInt("qualityWater", 1);
			QualityManager.SetQuality(1);
		}
		PlayerPrefs.SetInt("waterQualityTestDone", 1);
		GraphicsMenuUI.GGFJGHHHEJC.SetUpZoom(1, NOKFNLBADMO: true);
		yield return null;
		loadingScene2 = SceneManager.UnloadSceneAsync(SceneManager.GetSceneByName("Beach"));
		while (!loadingScene2.isDone)
		{
			progress = 0.9f + loadingScene2.progress * 0.1f;
			yield return CommonReferences.wait02;
		}
		active = false;
		progress = 1f;
	}

	public IEnumerator EHPCBNBDCIP()
	{
		Debug.Log((object)"Test Beach Scene");
		((CinemachineVirtualCameraBase)cinemachineVirtualCamera).Follow = ((Component)waterTestPosition).transform;
		AsyncOperation loadingScene2 = SceneManager.LoadSceneAsync("Beach", (LoadSceneMode)1);
		while (!loadingScene2.isDone)
		{
			progress = loadingScene2.progress * 0.5f;
			yield return CommonReferences.wait02;
		}
		yield return CommonReferences.wait1;
		progress = 0.6f;
		Debug.Log((object)"Start water quality test");
		yield return null;
		GraphicsMenuUI.GGFJGHHHEJC.ApplyZoom(1, 0);
		QualityManager.SetQuality(1);
		yield return null;
		float totalDeltaTime = 0f;
		MMIOHHKNADI = 0f;
		while (true)
		{
			totalDeltaTime += Time.deltaTime;
			progress = 0.6f + totalDeltaTime / MBDHPNNLKOO * 0.3f;
			MMIOHHKNADI += 1f;
			if (totalDeltaTime > MBDHPNNLKOO)
			{
				break;
			}
			yield return null;
		}
		float num = MMIOHHKNADI / totalDeltaTime;
		Debug.Log((object)("Frame Time Average: " + num));
		if (num < (float)FIBEFHOBOII)
		{
			Debug.Log((object)"Reducing quality water to Low");
			PlayerPrefs.SetInt("qualityWater", 0);
			QualityManager.SetQuality(0);
		}
		else
		{
			Debug.Log((object)"High quality water");
			PlayerPrefs.SetInt("qualityWater", 1);
			QualityManager.SetQuality(1);
		}
		PlayerPrefs.SetInt("waterQualityTestDone", 1);
		GraphicsMenuUI.GGFJGHHHEJC.SetUpZoom(1, NOKFNLBADMO: true);
		yield return null;
		loadingScene2 = SceneManager.UnloadSceneAsync(SceneManager.GetSceneByName("Beach"));
		while (!loadingScene2.isDone)
		{
			progress = 0.9f + loadingScene2.progress * 0.1f;
			yield return CommonReferences.wait02;
		}
		active = false;
		progress = 1f;
	}

	public IEnumerator APICFGGPECJ()
	{
		Debug.Log((object)"Test Beach Scene");
		((CinemachineVirtualCameraBase)cinemachineVirtualCamera).Follow = ((Component)waterTestPosition).transform;
		AsyncOperation loadingScene2 = SceneManager.LoadSceneAsync("Beach", (LoadSceneMode)1);
		while (!loadingScene2.isDone)
		{
			progress = loadingScene2.progress * 0.5f;
			yield return CommonReferences.wait02;
		}
		yield return CommonReferences.wait1;
		progress = 0.6f;
		Debug.Log((object)"Start water quality test");
		yield return null;
		GraphicsMenuUI.GGFJGHHHEJC.ApplyZoom(1, 0);
		QualityManager.SetQuality(1);
		yield return null;
		float totalDeltaTime = 0f;
		MMIOHHKNADI = 0f;
		while (true)
		{
			totalDeltaTime += Time.deltaTime;
			progress = 0.6f + totalDeltaTime / MBDHPNNLKOO * 0.3f;
			MMIOHHKNADI += 1f;
			if (totalDeltaTime > MBDHPNNLKOO)
			{
				break;
			}
			yield return null;
		}
		float num = MMIOHHKNADI / totalDeltaTime;
		Debug.Log((object)("Frame Time Average: " + num));
		if (num < (float)FIBEFHOBOII)
		{
			Debug.Log((object)"Reducing quality water to Low");
			PlayerPrefs.SetInt("qualityWater", 0);
			QualityManager.SetQuality(0);
		}
		else
		{
			Debug.Log((object)"High quality water");
			PlayerPrefs.SetInt("qualityWater", 1);
			QualityManager.SetQuality(1);
		}
		PlayerPrefs.SetInt("waterQualityTestDone", 1);
		GraphicsMenuUI.GGFJGHHHEJC.SetUpZoom(1, NOKFNLBADMO: true);
		yield return null;
		loadingScene2 = SceneManager.UnloadSceneAsync(SceneManager.GetSceneByName("Beach"));
		while (!loadingScene2.isDone)
		{
			progress = 0.9f + loadingScene2.progress * 0.1f;
			yield return CommonReferences.wait02;
		}
		active = false;
		progress = 1f;
	}

	public void APALEFNACCB()
	{
		active = true;
		((MonoBehaviour)this).StartCoroutine(HNPGPAHCKDC());
	}

	private void HPJBLOPJIMI()
	{
		instance = this;
	}

	public IEnumerator HNPGPAHCKDC()
	{
		return new OACFKPCCDBF(1)
		{
			_003C_003E4__this = this
		};
	}

	public void HNIONJLNHFJ()
	{
		active = false;
		((MonoBehaviour)this).StartCoroutine(NAHIHNGLNDO());
	}

	public IEnumerator TestBeachSceneCoroutine()
	{
		Debug.Log((object)"Test Beach Scene");
		((CinemachineVirtualCameraBase)cinemachineVirtualCamera).Follow = ((Component)waterTestPosition).transform;
		AsyncOperation loadingScene2 = SceneManager.LoadSceneAsync("Beach", (LoadSceneMode)1);
		while (!loadingScene2.isDone)
		{
			progress = loadingScene2.progress * 0.5f;
			yield return CommonReferences.wait02;
		}
		yield return CommonReferences.wait1;
		progress = 0.6f;
		Debug.Log((object)"Start water quality test");
		yield return null;
		GraphicsMenuUI.GGFJGHHHEJC.ApplyZoom(1, 0);
		QualityManager.SetQuality(1);
		yield return null;
		float totalDeltaTime = 0f;
		MMIOHHKNADI = 0f;
		while (true)
		{
			totalDeltaTime += Time.deltaTime;
			progress = 0.6f + totalDeltaTime / MBDHPNNLKOO * 0.3f;
			MMIOHHKNADI += 1f;
			if (totalDeltaTime > MBDHPNNLKOO)
			{
				break;
			}
			yield return null;
		}
		float num = MMIOHHKNADI / totalDeltaTime;
		Debug.Log((object)("Frame Time Average: " + num));
		if (num < (float)FIBEFHOBOII)
		{
			Debug.Log((object)"Reducing quality water to Low");
			PlayerPrefs.SetInt("qualityWater", 0);
			QualityManager.SetQuality(0);
		}
		else
		{
			Debug.Log((object)"High quality water");
			PlayerPrefs.SetInt("qualityWater", 1);
			QualityManager.SetQuality(1);
		}
		PlayerPrefs.SetInt("waterQualityTestDone", 1);
		GraphicsMenuUI.GGFJGHHHEJC.SetUpZoom(1, NOKFNLBADMO: true);
		yield return null;
		loadingScene2 = SceneManager.UnloadSceneAsync(SceneManager.GetSceneByName("Beach"));
		while (!loadingScene2.isDone)
		{
			progress = 0.9f + loadingScene2.progress * 0.1f;
			yield return CommonReferences.wait02;
		}
		active = false;
		progress = 1f;
	}

	public IEnumerator DJMBMKFHCNE()
	{
		Debug.Log((object)"Test Beach Scene");
		((CinemachineVirtualCameraBase)cinemachineVirtualCamera).Follow = ((Component)waterTestPosition).transform;
		AsyncOperation loadingScene2 = SceneManager.LoadSceneAsync("Beach", (LoadSceneMode)1);
		while (!loadingScene2.isDone)
		{
			progress = loadingScene2.progress * 0.5f;
			yield return CommonReferences.wait02;
		}
		yield return CommonReferences.wait1;
		progress = 0.6f;
		Debug.Log((object)"Start water quality test");
		yield return null;
		GraphicsMenuUI.GGFJGHHHEJC.ApplyZoom(1, 0);
		QualityManager.SetQuality(1);
		yield return null;
		float totalDeltaTime = 0f;
		MMIOHHKNADI = 0f;
		while (true)
		{
			totalDeltaTime += Time.deltaTime;
			progress = 0.6f + totalDeltaTime / MBDHPNNLKOO * 0.3f;
			MMIOHHKNADI += 1f;
			if (totalDeltaTime > MBDHPNNLKOO)
			{
				break;
			}
			yield return null;
		}
		float num = MMIOHHKNADI / totalDeltaTime;
		Debug.Log((object)("Frame Time Average: " + num));
		if (num < (float)FIBEFHOBOII)
		{
			Debug.Log((object)"Reducing quality water to Low");
			PlayerPrefs.SetInt("qualityWater", 0);
			QualityManager.SetQuality(0);
		}
		else
		{
			Debug.Log((object)"High quality water");
			PlayerPrefs.SetInt("qualityWater", 1);
			QualityManager.SetQuality(1);
		}
		PlayerPrefs.SetInt("waterQualityTestDone", 1);
		GraphicsMenuUI.GGFJGHHHEJC.SetUpZoom(1, NOKFNLBADMO: true);
		yield return null;
		loadingScene2 = SceneManager.UnloadSceneAsync(SceneManager.GetSceneByName("Beach"));
		while (!loadingScene2.isDone)
		{
			progress = 0.9f + loadingScene2.progress * 0.1f;
			yield return CommonReferences.wait02;
		}
		active = false;
		progress = 1f;
	}

	public IEnumerator ENBEGNAIAPC()
	{
		return new OACFKPCCDBF(1)
		{
			_003C_003E4__this = this
		};
	}

	private void DADPOICMNPI()
	{
		instance = this;
	}

	public void FOHHALJCMBM()
	{
		active = true;
		((MonoBehaviour)this).StartCoroutine(KJHDOPBDNJA());
	}

	public IEnumerator NILAJEJKIIL()
	{
		Debug.Log((object)"Test Beach Scene");
		((CinemachineVirtualCameraBase)cinemachineVirtualCamera).Follow = ((Component)waterTestPosition).transform;
		AsyncOperation loadingScene2 = SceneManager.LoadSceneAsync("Beach", (LoadSceneMode)1);
		while (!loadingScene2.isDone)
		{
			progress = loadingScene2.progress * 0.5f;
			yield return CommonReferences.wait02;
		}
		yield return CommonReferences.wait1;
		progress = 0.6f;
		Debug.Log((object)"Start water quality test");
		yield return null;
		GraphicsMenuUI.GGFJGHHHEJC.ApplyZoom(1, 0);
		QualityManager.SetQuality(1);
		yield return null;
		float totalDeltaTime = 0f;
		MMIOHHKNADI = 0f;
		while (true)
		{
			totalDeltaTime += Time.deltaTime;
			progress = 0.6f + totalDeltaTime / MBDHPNNLKOO * 0.3f;
			MMIOHHKNADI += 1f;
			if (totalDeltaTime > MBDHPNNLKOO)
			{
				break;
			}
			yield return null;
		}
		float num = MMIOHHKNADI / totalDeltaTime;
		Debug.Log((object)("Frame Time Average: " + num));
		if (num < (float)FIBEFHOBOII)
		{
			Debug.Log((object)"Reducing quality water to Low");
			PlayerPrefs.SetInt("qualityWater", 0);
			QualityManager.SetQuality(0);
		}
		else
		{
			Debug.Log((object)"High quality water");
			PlayerPrefs.SetInt("qualityWater", 1);
			QualityManager.SetQuality(1);
		}
		PlayerPrefs.SetInt("waterQualityTestDone", 1);
		GraphicsMenuUI.GGFJGHHHEJC.SetUpZoom(1, NOKFNLBADMO: true);
		yield return null;
		loadingScene2 = SceneManager.UnloadSceneAsync(SceneManager.GetSceneByName("Beach"));
		while (!loadingScene2.isDone)
		{
			progress = 0.9f + loadingScene2.progress * 0.1f;
			yield return CommonReferences.wait02;
		}
		active = false;
		progress = 1f;
	}

	public IEnumerator JEDLBOJGFFO()
	{
		return new OACFKPCCDBF(1)
		{
			_003C_003E4__this = this
		};
	}

	private void KJHKBGDJNDC()
	{
		instance = this;
	}

	public void GDMMGJGHAGB()
	{
		active = true;
		((MonoBehaviour)this).StartCoroutine(KJHDOPBDNJA());
	}

	public IEnumerator AHBEIPIAKLB()
	{
		Debug.Log((object)"Test Beach Scene");
		((CinemachineVirtualCameraBase)cinemachineVirtualCamera).Follow = ((Component)waterTestPosition).transform;
		AsyncOperation loadingScene2 = SceneManager.LoadSceneAsync("Beach", (LoadSceneMode)1);
		while (!loadingScene2.isDone)
		{
			progress = loadingScene2.progress * 0.5f;
			yield return CommonReferences.wait02;
		}
		yield return CommonReferences.wait1;
		progress = 0.6f;
		Debug.Log((object)"Start water quality test");
		yield return null;
		GraphicsMenuUI.GGFJGHHHEJC.ApplyZoom(1, 0);
		QualityManager.SetQuality(1);
		yield return null;
		float totalDeltaTime = 0f;
		MMIOHHKNADI = 0f;
		while (true)
		{
			totalDeltaTime += Time.deltaTime;
			progress = 0.6f + totalDeltaTime / MBDHPNNLKOO * 0.3f;
			MMIOHHKNADI += 1f;
			if (totalDeltaTime > MBDHPNNLKOO)
			{
				break;
			}
			yield return null;
		}
		float num = MMIOHHKNADI / totalDeltaTime;
		Debug.Log((object)("Frame Time Average: " + num));
		if (num < (float)FIBEFHOBOII)
		{
			Debug.Log((object)"Reducing quality water to Low");
			PlayerPrefs.SetInt("qualityWater", 0);
			QualityManager.SetQuality(0);
		}
		else
		{
			Debug.Log((object)"High quality water");
			PlayerPrefs.SetInt("qualityWater", 1);
			QualityManager.SetQuality(1);
		}
		PlayerPrefs.SetInt("waterQualityTestDone", 1);
		GraphicsMenuUI.GGFJGHHHEJC.SetUpZoom(1, NOKFNLBADMO: true);
		yield return null;
		loadingScene2 = SceneManager.UnloadSceneAsync(SceneManager.GetSceneByName("Beach"));
		while (!loadingScene2.isDone)
		{
			progress = 0.9f + loadingScene2.progress * 0.1f;
			yield return CommonReferences.wait02;
		}
		active = false;
		progress = 1f;
	}

	public IEnumerator AMMOHLGCICP()
	{
		Debug.Log((object)"Test Beach Scene");
		((CinemachineVirtualCameraBase)cinemachineVirtualCamera).Follow = ((Component)waterTestPosition).transform;
		AsyncOperation loadingScene2 = SceneManager.LoadSceneAsync("Beach", (LoadSceneMode)1);
		while (!loadingScene2.isDone)
		{
			progress = loadingScene2.progress * 0.5f;
			yield return CommonReferences.wait02;
		}
		yield return CommonReferences.wait1;
		progress = 0.6f;
		Debug.Log((object)"Start water quality test");
		yield return null;
		GraphicsMenuUI.GGFJGHHHEJC.ApplyZoom(1, 0);
		QualityManager.SetQuality(1);
		yield return null;
		float totalDeltaTime = 0f;
		MMIOHHKNADI = 0f;
		while (true)
		{
			totalDeltaTime += Time.deltaTime;
			progress = 0.6f + totalDeltaTime / MBDHPNNLKOO * 0.3f;
			MMIOHHKNADI += 1f;
			if (totalDeltaTime > MBDHPNNLKOO)
			{
				break;
			}
			yield return null;
		}
		float num = MMIOHHKNADI / totalDeltaTime;
		Debug.Log((object)("Frame Time Average: " + num));
		if (num < (float)FIBEFHOBOII)
		{
			Debug.Log((object)"Reducing quality water to Low");
			PlayerPrefs.SetInt("qualityWater", 0);
			QualityManager.SetQuality(0);
		}
		else
		{
			Debug.Log((object)"High quality water");
			PlayerPrefs.SetInt("qualityWater", 1);
			QualityManager.SetQuality(1);
		}
		PlayerPrefs.SetInt("waterQualityTestDone", 1);
		GraphicsMenuUI.GGFJGHHHEJC.SetUpZoom(1, NOKFNLBADMO: true);
		yield return null;
		loadingScene2 = SceneManager.UnloadSceneAsync(SceneManager.GetSceneByName("Beach"));
		while (!loadingScene2.isDone)
		{
			progress = 0.9f + loadingScene2.progress * 0.1f;
			yield return CommonReferences.wait02;
		}
		active = false;
		progress = 1f;
	}

	public IEnumerator AHJHDJOFGCJ()
	{
		Debug.Log((object)"Test Beach Scene");
		((CinemachineVirtualCameraBase)cinemachineVirtualCamera).Follow = ((Component)waterTestPosition).transform;
		AsyncOperation loadingScene2 = SceneManager.LoadSceneAsync("Beach", (LoadSceneMode)1);
		while (!loadingScene2.isDone)
		{
			progress = loadingScene2.progress * 0.5f;
			yield return CommonReferences.wait02;
		}
		yield return CommonReferences.wait1;
		progress = 0.6f;
		Debug.Log((object)"Start water quality test");
		yield return null;
		GraphicsMenuUI.GGFJGHHHEJC.ApplyZoom(1, 0);
		QualityManager.SetQuality(1);
		yield return null;
		float totalDeltaTime = 0f;
		MMIOHHKNADI = 0f;
		while (true)
		{
			totalDeltaTime += Time.deltaTime;
			progress = 0.6f + totalDeltaTime / MBDHPNNLKOO * 0.3f;
			MMIOHHKNADI += 1f;
			if (totalDeltaTime > MBDHPNNLKOO)
			{
				break;
			}
			yield return null;
		}
		float num = MMIOHHKNADI / totalDeltaTime;
		Debug.Log((object)("Frame Time Average: " + num));
		if (num < (float)FIBEFHOBOII)
		{
			Debug.Log((object)"Reducing quality water to Low");
			PlayerPrefs.SetInt("qualityWater", 0);
			QualityManager.SetQuality(0);
		}
		else
		{
			Debug.Log((object)"High quality water");
			PlayerPrefs.SetInt("qualityWater", 1);
			QualityManager.SetQuality(1);
		}
		PlayerPrefs.SetInt("waterQualityTestDone", 1);
		GraphicsMenuUI.GGFJGHHHEJC.SetUpZoom(1, NOKFNLBADMO: true);
		yield return null;
		loadingScene2 = SceneManager.UnloadSceneAsync(SceneManager.GetSceneByName("Beach"));
		while (!loadingScene2.isDone)
		{
			progress = 0.9f + loadingScene2.progress * 0.1f;
			yield return CommonReferences.wait02;
		}
		active = false;
		progress = 1f;
	}

	public IEnumerator EABHJOAKFEB()
	{
		Debug.Log((object)"Test Beach Scene");
		((CinemachineVirtualCameraBase)cinemachineVirtualCamera).Follow = ((Component)waterTestPosition).transform;
		AsyncOperation loadingScene2 = SceneManager.LoadSceneAsync("Beach", (LoadSceneMode)1);
		while (!loadingScene2.isDone)
		{
			progress = loadingScene2.progress * 0.5f;
			yield return CommonReferences.wait02;
		}
		yield return CommonReferences.wait1;
		progress = 0.6f;
		Debug.Log((object)"Start water quality test");
		yield return null;
		GraphicsMenuUI.GGFJGHHHEJC.ApplyZoom(1, 0);
		QualityManager.SetQuality(1);
		yield return null;
		float totalDeltaTime = 0f;
		MMIOHHKNADI = 0f;
		while (true)
		{
			totalDeltaTime += Time.deltaTime;
			progress = 0.6f + totalDeltaTime / MBDHPNNLKOO * 0.3f;
			MMIOHHKNADI += 1f;
			if (totalDeltaTime > MBDHPNNLKOO)
			{
				break;
			}
			yield return null;
		}
		float num = MMIOHHKNADI / totalDeltaTime;
		Debug.Log((object)("Frame Time Average: " + num));
		if (num < (float)FIBEFHOBOII)
		{
			Debug.Log((object)"Reducing quality water to Low");
			PlayerPrefs.SetInt("qualityWater", 0);
			QualityManager.SetQuality(0);
		}
		else
		{
			Debug.Log((object)"High quality water");
			PlayerPrefs.SetInt("qualityWater", 1);
			QualityManager.SetQuality(1);
		}
		PlayerPrefs.SetInt("waterQualityTestDone", 1);
		GraphicsMenuUI.GGFJGHHHEJC.SetUpZoom(1, NOKFNLBADMO: true);
		yield return null;
		loadingScene2 = SceneManager.UnloadSceneAsync(SceneManager.GetSceneByName("Beach"));
		while (!loadingScene2.isDone)
		{
			progress = 0.9f + loadingScene2.progress * 0.1f;
			yield return CommonReferences.wait02;
		}
		active = false;
		progress = 1f;
	}
}
