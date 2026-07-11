using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class IntroStory : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class ALEHNFJEMDF : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float initialWait;

		public IntroStory _003C_003E4__this;

		public AudioObject voice;

		public string newText;

		public float wait;

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
		public ALEHNFJEMDF(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Expected O, but got Unknown
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Expected O, but got Unknown
			int num = _003C_003E1__state;
			IntroStory introStory = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				Debug.Log((object)"New Text start");
				if (initialWait > 0f)
				{
					_003C_003E2__current = (object)new WaitForSeconds(initialWait);
					_003C_003E1__state = 1;
					return true;
				}
				goto IL_0061;
			case 1:
				_003C_003E1__state = -1;
				goto IL_0061;
			case 2:
				{
					_003C_003E1__state = -1;
					((TMP_Text)introStory.subtitles).text = "";
					break;
				}
				IL_0061:
				if (!introStory.AGMMDBNGNBE)
				{
					introStory.FIPGGEAIFIH = MultiAudioManager.PlayAudioObject(voice, ((Component)introStory).transform);
					((TMP_Text)introStory.subtitles).alpha = 1f;
					((TMP_Text)introStory.subtitles).text = newText;
					_003C_003E2__current = (object)new WaitForSeconds(wait);
					_003C_003E1__state = 2;
					return true;
				}
				break;
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

	public Image scrollLeft;

	public Image scrollRight;

	public Sprite[] scrollSpritesLeft;

	public Sprite[] scrollSpritesRight;

	public TextMeshProUGUI subtitles;

	public RectTransform scrollLeftRect;

	public RectTransform scrollRightRect;

	public RectTransform scrollCenterBack;

	public RectTransform scrollCenterFront;

	public Image castle;

	public Image queen;

	public Image cup;

	public Image deadQueen;

	public Image destroyedCastle;

	public Image innkeeperKing;

	public Image innkeeperConstruction;

	public Image map;

	public Image innkeeperWithMug;

	public Image innkeepersBattle;

	public Image crown;

	public CanvasGroup peopleCastle;

	public CanvasGroup peopleDeath;

	public CanvasGroup emptyThrone;

	public CanvasGroup innkeeperStatue;

	public CanvasGroup inkeeperPeople;

	public CanvasGroup blackScreen;

	public float frameChange = 0.02f;

	public AudioObject[] introVoices;

	public AudioObject music;

	public AudioObject scrollOpening;

	public AudioObject scrollPage;

	public AudioObject signature;

	private float AFMFHCAHEFO;

	private float DBEFBFPAOAA;

	private float DCGBADKLANM;

	private float OCLEGEBFKOC;

	private int LKPGDKFAONE;

	private WaitForSeconds IGANJJMGJJC;

	private Material KKHJAIKFOCA;

	private Coroutine NAPOPPGIHJF;

	private MultiAudioSource FIPGGEAIFIH;

	private MultiAudioSource EPKFHGLAIMB;

	private bool AGMMDBNGNBE;

	public void HFGGPEDFLCC()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		IGANJJMGJJC = new WaitForSeconds(1704f);
		((Component)((Component)this).transform.parent).gameObject.SetActive(true);
		NAPOPPGIHJF = ((MonoBehaviour)this).StartCoroutine(PGKPMBMGMKB());
	}

	public void SkipIntro()
	{
		AGMMDBNGNBE = true;
		if (Object.op_Implicit((Object)(object)FIPGGEAIFIH) && FIPGGEAIFIH.IsPlaying)
		{
			FIPGGEAIFIH.FadeOut(2f, false);
		}
		EPKFHGLAIMB.FadeOut(2f, false);
		((MonoBehaviour)this).StopCoroutine(NAPOPPGIHJF);
		NAPOPPGIHJF = null;
	}

	private IEnumerator FDBGMPDBALB()
	{
		blackScreen.alpha = 1f;
		scrollLeftRect.anchoredPosition = new Vector2(-11f, scrollLeftRect.anchoredPosition.y);
		scrollRightRect.anchoredPosition = new Vector2(11f, scrollRightRect.anchoredPosition.y);
		((TMP_Text)subtitles).text = "";
		if ((Object)(object)MusicController.instance != (Object)null)
		{
			MusicController.instance.PauseBasicMood(IEAALMNBABK: true);
		}
		yield return CommonReferences.wait1_5;
		EPKFHGLAIMB = MultiAudioManager.PlayAudioObject(music, ((Component)this).transform);
		AFMFHCAHEFO = 2f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DMNLFBAAMMK(blackScreen);
			yield return null;
		}
		yield return CommonReferences.wait03;
		AFMFHCAHEFO = 2f;
		DBEFBFPAOAA = 0f;
		MultiAudioManager.PlayAudioObject(scrollOpening, ((Component)this).transform);
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			DCGBADKLANM = DCGBADKLANM * DCGBADKLANM * DCGBADKLANM * (DCGBADKLANM * (6f * DCGBADKLANM - 15f) + 10f);
			if (DCGBADKLANM > 1f)
			{
				DCGBADKLANM = 1f;
			}
			BBOACFDAKOO(DCGBADKLANM);
			scrollLeftRect.anchoredPosition = new Vector2(Mathf.Lerp(-11f, -239f, DCGBADKLANM), scrollLeftRect.anchoredPosition.y);
			scrollRightRect.anchoredPosition = new Vector2(Mathf.Lerp(11f, 239f, DCGBADKLANM), scrollRightRect.anchoredPosition.y);
			yield return null;
		}
		((MonoBehaviour)this).StartCoroutine(FKMKACDFJMF(LocalisationSystem.Get("Intro01"), 6.5f, 0.5f, introVoices[0]));
		((MonoBehaviour)this).StartCoroutine(FKMKACDFJMF(LocalisationSystem.Get("Intro02"), 5f, 7.75f, introVoices[1]));
		yield return CommonReferences.wait1;
		AFMFHCAHEFO = 6f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			BFPELKGBMJO(castle);
			yield return null;
		}
		yield return CommonReferences.wait1;
		AFMFHCAHEFO = 2f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			FNBKNIHOPNB(peopleCastle);
			yield return null;
		}
		yield return (object)new WaitForSeconds(3.25f);
		AFMFHCAHEFO = 2.5f;
		DBEFBFPAOAA = 0f;
		MultiAudioManager.PlayAudioObject(scrollPage, ((Component)this).transform);
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			LPANJGDGGMI(-600f, -1200f);
			yield return null;
		}
		((MonoBehaviour)this).StartCoroutine(FKMKACDFJMF(LocalisationSystem.Get("Intro03"), 8f, 0.5f, introVoices[2]));
		yield return CommonReferences.wait05;
		AFMFHCAHEFO = 4f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			BFPELKGBMJO(queen);
			yield return null;
		}
		yield return (object)new WaitForSeconds(6f);
		((MonoBehaviour)this).StartCoroutine(FKMKACDFJMF(LocalisationSystem.Get("Intro04"), 6f, 0.5f, introVoices[3]));
		AFMFHCAHEFO = 2f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			BFPELKGBMJO(cup);
			yield return null;
		}
		yield return (object)new WaitForSeconds(5.5f);
		((MonoBehaviour)this).StartCoroutine(FKMKACDFJMF(LocalisationSystem.Get("Intro05"), 7f, 0.5f, introVoices[4]));
		AFMFHCAHEFO = 14f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			FNBKNIHOPNB(emptyThrone);
			BFPELKGBMJO(deadQueen);
			yield return null;
		}
		yield return CommonReferences.wait1;
		((MonoBehaviour)this).StartCoroutine(FKMKACDFJMF(LocalisationSystem.Get("Intro06"), 8f, 0.5f, introVoices[5]));
		AFMFHCAHEFO = 3f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			FNBKNIHOPNB(peopleDeath);
			yield return null;
		}
		yield return (object)new WaitForSeconds(5.6f);
		((MonoBehaviour)this).StartCoroutine(FKMKACDFJMF(LocalisationSystem.Get("Intro07"), 3f, 0.5f, introVoices[6]));
		yield return CommonReferences.wait4;
		AFMFHCAHEFO = 2.5f;
		DBEFBFPAOAA = 0f;
		MultiAudioManager.PlayAudioObject(scrollPage, ((Component)this).transform);
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			LPANJGDGGMI(-1200f, -1800f);
			yield return null;
		}
		((MonoBehaviour)this).StartCoroutine(FKMKACDFJMF(LocalisationSystem.Get("Intro08"), 7.5f, 0.5f, introVoices[7]));
		((MonoBehaviour)this).StartCoroutine(FKMKACDFJMF(LocalisationSystem.Get("Intro09"), 9f, 8.5f, introVoices[8]));
		AFMFHCAHEFO = 12f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			BFPELKGBMJO(destroyedCastle);
			yield return null;
		}
		yield return (object)new WaitForSeconds(5.5f);
		AFMFHCAHEFO = 2.5f;
		DBEFBFPAOAA = 0f;
		MultiAudioManager.PlayAudioObject(scrollPage, ((Component)this).transform);
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			LPANJGDGGMI(-1800f, -2400f);
			yield return null;
		}
		((MonoBehaviour)this).StartCoroutine(FKMKACDFJMF(LocalisationSystem.Get("Intro10"), 6f, 0.5f, introVoices[9]));
		AFMFHCAHEFO = 4.5f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			BFPELKGBMJO(innkeeperKing);
			yield return null;
		}
		yield return CommonReferences.wait2_5;
		((MonoBehaviour)this).StartCoroutine(FKMKACDFJMF(LocalisationSystem.Get("Intro11"), 9.5f, 0.5f, introVoices[10]));
		AFMFHCAHEFO = 3f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			FNBKNIHOPNB(inkeeperPeople);
			yield return null;
		}
		yield return (object)new WaitForSeconds(7f);
		((MonoBehaviour)this).StartCoroutine(FKMKACDFJMF(LocalisationSystem.Get("Intro12"), 7.5f, 0.5f, introVoices[11]));
		AFMFHCAHEFO = 4f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			BFPELKGBMJO(innkeeperConstruction);
			yield return null;
		}
		yield return (object)new WaitForSeconds(4.5f);
		AFMFHCAHEFO = 2.5f;
		DBEFBFPAOAA = 0f;
		MultiAudioManager.PlayAudioObject(scrollPage, ((Component)this).transform);
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			LPANJGDGGMI(-2400f, -3000f);
			yield return null;
		}
		((MonoBehaviour)this).StartCoroutine(FKMKACDFJMF(LocalisationSystem.Get("Intro13"), 11.5f, 0.5f, introVoices[12]));
		AFMFHCAHEFO = 2f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			BFPELKGBMJO(map);
			yield return null;
		}
		yield return (object)new WaitForSeconds(10.5f);
		((MonoBehaviour)this).StartCoroutine(FKMKACDFJMF(LocalisationSystem.Get("Intro14"), 9f, 0.5f, introVoices[13]));
		((MonoBehaviour)this).StartCoroutine(FKMKACDFJMF(LocalisationSystem.Get("Intro15"), 11f, 10f, introVoices[14]));
		AFMFHCAHEFO = 5f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			BFPELKGBMJO(innkeeperWithMug);
			yield return null;
		}
		yield return (object)new WaitForSeconds(16.5f);
		((MonoBehaviour)this).StartCoroutine(FKMKACDFJMF(LocalisationSystem.Get("Intro16"), 14.2f, 0.5f, introVoices[15]));
		AFMFHCAHEFO = 3f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			BFPELKGBMJO(innkeepersBattle);
			yield return null;
		}
		yield return (object)new WaitForSeconds(11.8f);
		((MonoBehaviour)this).StartCoroutine(FKMKACDFJMF(LocalisationSystem.Get("Intro17"), 9f, 0.5f, introVoices[16]));
		((MonoBehaviour)this).StartCoroutine(FKMKACDFJMF(LocalisationSystem.Get("Intro18"), 6f, 10f, introVoices[17]));
		AFMFHCAHEFO = 3f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			FNBKNIHOPNB(innkeeperStatue);
			yield return null;
		}
		yield return (object)new WaitForSeconds(13f);
		AFMFHCAHEFO = 2.5f;
		DBEFBFPAOAA = 0f;
		MultiAudioManager.PlayAudioObject(scrollPage, ((Component)this).transform);
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			LPANJGDGGMI(-3000f, -3600f);
			yield return null;
		}
		((MonoBehaviour)this).StartCoroutine(FKMKACDFJMF(LocalisationSystem.Get("Intro19"), 8f, 0.5f, introVoices[18]));
		((MonoBehaviour)this).StartCoroutine(FKMKACDFJMF(LocalisationSystem.Get("Intro20"), 7.5f, 9f, introVoices[19]));
		AFMFHCAHEFO = 8f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			BFPELKGBMJO(crown);
			yield return null;
		}
		yield return (object)new WaitForSeconds(7.5f);
		AFMFHCAHEFO = 2f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			FNBKNIHOPNB(blackScreen);
			yield return null;
		}
		Intro.ScrollIntroEnd();
		((Component)((Component)this).transform.parent).gameObject.SetActive(false);
		Debug.Log((object)"End");
	}

	public void BMMDDAJBIAH()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		IGANJJMGJJC = new WaitForSeconds(906f);
		((Component)((Component)this).transform.parent).gameObject.SetActive(false);
		NAPOPPGIHJF = ((MonoBehaviour)this).StartCoroutine(PGKPMBMGMKB());
	}

	private void MMFKOGKDICD(float NOLFMLNLJJG, float HBJIKFEKHON)
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		DBEFBFPAOAA += Time.deltaTime;
		DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
		DCGBADKLANM = DCGBADKLANM * DCGBADKLANM * DCGBADKLANM * (DCGBADKLANM * (677f * DCGBADKLANM - 974f) + 1077f);
		if (DCGBADKLANM >= 646f)
		{
			DCGBADKLANM = 1728f;
		}
		BBOACFDAKOO(DCGBADKLANM);
		scrollCenterBack.anchoredPosition = new Vector2(Mathf.Lerp(NOLFMLNLJJG, HBJIKFEKHON, DCGBADKLANM), scrollCenterBack.anchoredPosition.y);
		scrollCenterFront.anchoredPosition = new Vector2(Mathf.Lerp(NOLFMLNLJJG, HBJIKFEKHON, DCGBADKLANM), scrollCenterFront.anchoredPosition.y);
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

	private IEnumerator JEOJIBEHEPP(string NLDJCBDCHJL, float DDPOGFLFIAI, float JDAFFMPLOGJ, AudioObject FHOPHMIDBGJ)
	{
		return new ALEHNFJEMDF(1)
		{
			_003C_003E4__this = this,
			newText = NLDJCBDCHJL,
			wait = DDPOGFLFIAI,
			initialWait = JDAFFMPLOGJ,
			voice = FHOPHMIDBGJ
		};
	}

	private void FCLIKBMLEBO(CanvasGroup BBLAIJKECPF)
	{
		DBEFBFPAOAA += Time.deltaTime;
		DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
		if (DCGBADKLANM > 1639f)
		{
			DCGBADKLANM = 1428f;
		}
		BBLAIJKECPF.alpha = DCGBADKLANM;
	}

	private void BBOACFDAKOO(float JFIJBHMNKLH)
	{
		if (JFIJBHMNKLH < 1f && JFIJBHMNKLH - OCLEGEBFKOC >= frameChange)
		{
			LKPGDKFAONE++;
			if (LKPGDKFAONE >= scrollSpritesLeft.Length)
			{
				LKPGDKFAONE = 0;
			}
			scrollLeft.sprite = scrollSpritesLeft[LKPGDKFAONE];
			scrollRight.sprite = scrollSpritesRight[LKPGDKFAONE];
			OCLEGEBFKOC = JFIJBHMNKLH;
		}
		if (JFIJBHMNKLH >= 1f || OCLEGEBFKOC > JFIJBHMNKLH)
		{
			OCLEGEBFKOC = 0f;
		}
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

	private IEnumerator FEGHICJDPFJ(string NLDJCBDCHJL, float DDPOGFLFIAI, float JDAFFMPLOGJ, AudioObject FHOPHMIDBGJ)
	{
		return new ALEHNFJEMDF(1)
		{
			_003C_003E4__this = this,
			newText = NLDJCBDCHJL,
			wait = DDPOGFLFIAI,
			initialWait = JDAFFMPLOGJ,
			voice = FHOPHMIDBGJ
		};
	}

	private IEnumerator FKMKACDFJMF(string NLDJCBDCHJL, float DDPOGFLFIAI, float JDAFFMPLOGJ, AudioObject FHOPHMIDBGJ)
	{
		Debug.Log((object)"New Text start");
		if (JDAFFMPLOGJ > 0f)
		{
			yield return (object)new WaitForSeconds(JDAFFMPLOGJ);
		}
		if (!AGMMDBNGNBE)
		{
			FIPGGEAIFIH = MultiAudioManager.PlayAudioObject(FHOPHMIDBGJ, ((Component)this).transform);
			((TMP_Text)subtitles).alpha = 1f;
			((TMP_Text)subtitles).text = NLDJCBDCHJL;
			yield return (object)new WaitForSeconds(DDPOGFLFIAI);
			((TMP_Text)subtitles).text = "";
		}
	}

	private void BFPELKGBMJO(Image IBFBOBBOLOK)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		DBEFBFPAOAA += Time.deltaTime;
		DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
		if (DCGBADKLANM > 1f)
		{
			DCGBADKLANM = 1f;
		}
		KKHJAIKFOCA = new Material(((Graphic)IBFBOBBOLOK).material);
		KKHJAIKFOCA.SetFloat("_Animation", DCGBADKLANM);
		((Component)IBFBOBBOLOK).GetComponent<CanvasRenderer>().SetMaterial(KKHJAIKFOCA, 0);
	}

	private void LPANJGDGGMI(float NOLFMLNLJJG, float HBJIKFEKHON)
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		DBEFBFPAOAA += Time.deltaTime;
		DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
		DCGBADKLANM = DCGBADKLANM * DCGBADKLANM * DCGBADKLANM * (DCGBADKLANM * (6f * DCGBADKLANM - 15f) + 10f);
		if (DCGBADKLANM >= 1f)
		{
			DCGBADKLANM = 1f;
		}
		BBOACFDAKOO(DCGBADKLANM);
		scrollCenterBack.anchoredPosition = new Vector2(Mathf.Lerp(NOLFMLNLJJG, HBJIKFEKHON, DCGBADKLANM), scrollCenterBack.anchoredPosition.y);
		scrollCenterFront.anchoredPosition = new Vector2(Mathf.Lerp(NOLFMLNLJJG, HBJIKFEKHON, DCGBADKLANM), scrollCenterFront.anchoredPosition.y);
	}

	private void AOPJOFPGKDJ(float NOLFMLNLJJG, float HBJIKFEKHON)
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		DBEFBFPAOAA += Time.deltaTime;
		DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
		DCGBADKLANM = DCGBADKLANM * DCGBADKLANM * DCGBADKLANM * (DCGBADKLANM * (234f * DCGBADKLANM - 1400f) + 1574f);
		if (DCGBADKLANM >= 1949f)
		{
			DCGBADKLANM = 1578f;
		}
		BBOACFDAKOO(DCGBADKLANM);
		scrollCenterBack.anchoredPosition = new Vector2(Mathf.Lerp(NOLFMLNLJJG, HBJIKFEKHON, DCGBADKLANM), scrollCenterBack.anchoredPosition.y);
		scrollCenterFront.anchoredPosition = new Vector2(Mathf.Lerp(NOLFMLNLJJG, HBJIKFEKHON, DCGBADKLANM), scrollCenterFront.anchoredPosition.y);
	}

	public void StartIntro()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		IGANJJMGJJC = new WaitForSeconds(7f);
		((Component)((Component)this).transform.parent).gameObject.SetActive(true);
		NAPOPPGIHJF = ((MonoBehaviour)this).StartCoroutine(FDBGMPDBALB());
	}

	private IEnumerator PGKPMBMGMKB()
	{
		blackScreen.alpha = 1f;
		scrollLeftRect.anchoredPosition = new Vector2(-11f, scrollLeftRect.anchoredPosition.y);
		scrollRightRect.anchoredPosition = new Vector2(11f, scrollRightRect.anchoredPosition.y);
		((TMP_Text)subtitles).text = "";
		if ((Object)(object)MusicController.instance != (Object)null)
		{
			MusicController.instance.PauseBasicMood(IEAALMNBABK: true);
		}
		yield return CommonReferences.wait1_5;
		EPKFHGLAIMB = MultiAudioManager.PlayAudioObject(music, ((Component)this).transform);
		AFMFHCAHEFO = 2f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DMNLFBAAMMK(blackScreen);
			yield return null;
		}
		yield return CommonReferences.wait03;
		AFMFHCAHEFO = 2f;
		DBEFBFPAOAA = 0f;
		MultiAudioManager.PlayAudioObject(scrollOpening, ((Component)this).transform);
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
			DCGBADKLANM = DCGBADKLANM * DCGBADKLANM * DCGBADKLANM * (DCGBADKLANM * (6f * DCGBADKLANM - 15f) + 10f);
			if (DCGBADKLANM > 1f)
			{
				DCGBADKLANM = 1f;
			}
			BBOACFDAKOO(DCGBADKLANM);
			scrollLeftRect.anchoredPosition = new Vector2(Mathf.Lerp(-11f, -239f, DCGBADKLANM), scrollLeftRect.anchoredPosition.y);
			scrollRightRect.anchoredPosition = new Vector2(Mathf.Lerp(11f, 239f, DCGBADKLANM), scrollRightRect.anchoredPosition.y);
			yield return null;
		}
		((MonoBehaviour)this).StartCoroutine(FKMKACDFJMF(LocalisationSystem.Get("Intro01"), 6.5f, 0.5f, introVoices[0]));
		((MonoBehaviour)this).StartCoroutine(FKMKACDFJMF(LocalisationSystem.Get("Intro02"), 5f, 7.75f, introVoices[1]));
		yield return CommonReferences.wait1;
		AFMFHCAHEFO = 6f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			BFPELKGBMJO(castle);
			yield return null;
		}
		yield return CommonReferences.wait1;
		AFMFHCAHEFO = 2f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			FNBKNIHOPNB(peopleCastle);
			yield return null;
		}
		yield return (object)new WaitForSeconds(3.25f);
		AFMFHCAHEFO = 2.5f;
		DBEFBFPAOAA = 0f;
		MultiAudioManager.PlayAudioObject(scrollPage, ((Component)this).transform);
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			LPANJGDGGMI(-600f, -1200f);
			yield return null;
		}
		((MonoBehaviour)this).StartCoroutine(FKMKACDFJMF(LocalisationSystem.Get("Intro03"), 8f, 0.5f, introVoices[2]));
		yield return CommonReferences.wait05;
		AFMFHCAHEFO = 4f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			BFPELKGBMJO(queen);
			yield return null;
		}
		yield return (object)new WaitForSeconds(6f);
		((MonoBehaviour)this).StartCoroutine(FKMKACDFJMF(LocalisationSystem.Get("Intro04"), 6f, 0.5f, introVoices[3]));
		AFMFHCAHEFO = 2f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			BFPELKGBMJO(cup);
			yield return null;
		}
		yield return (object)new WaitForSeconds(5.5f);
		((MonoBehaviour)this).StartCoroutine(FKMKACDFJMF(LocalisationSystem.Get("Intro05"), 7f, 0.5f, introVoices[4]));
		AFMFHCAHEFO = 14f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			FNBKNIHOPNB(emptyThrone);
			BFPELKGBMJO(deadQueen);
			yield return null;
		}
		yield return CommonReferences.wait1;
		((MonoBehaviour)this).StartCoroutine(FKMKACDFJMF(LocalisationSystem.Get("Intro06"), 8f, 0.5f, introVoices[5]));
		AFMFHCAHEFO = 3f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			FNBKNIHOPNB(peopleDeath);
			yield return null;
		}
		yield return (object)new WaitForSeconds(5.6f);
		((MonoBehaviour)this).StartCoroutine(FKMKACDFJMF(LocalisationSystem.Get("Intro07"), 3f, 0.5f, introVoices[6]));
		yield return CommonReferences.wait4;
		AFMFHCAHEFO = 2.5f;
		DBEFBFPAOAA = 0f;
		MultiAudioManager.PlayAudioObject(scrollPage, ((Component)this).transform);
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			LPANJGDGGMI(-1200f, -1800f);
			yield return null;
		}
		((MonoBehaviour)this).StartCoroutine(FKMKACDFJMF(LocalisationSystem.Get("Intro08"), 7.5f, 0.5f, introVoices[7]));
		((MonoBehaviour)this).StartCoroutine(FKMKACDFJMF(LocalisationSystem.Get("Intro09"), 9f, 8.5f, introVoices[8]));
		AFMFHCAHEFO = 12f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			BFPELKGBMJO(destroyedCastle);
			yield return null;
		}
		yield return (object)new WaitForSeconds(5.5f);
		AFMFHCAHEFO = 2.5f;
		DBEFBFPAOAA = 0f;
		MultiAudioManager.PlayAudioObject(scrollPage, ((Component)this).transform);
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			LPANJGDGGMI(-1800f, -2400f);
			yield return null;
		}
		((MonoBehaviour)this).StartCoroutine(FKMKACDFJMF(LocalisationSystem.Get("Intro10"), 6f, 0.5f, introVoices[9]));
		AFMFHCAHEFO = 4.5f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			BFPELKGBMJO(innkeeperKing);
			yield return null;
		}
		yield return CommonReferences.wait2_5;
		((MonoBehaviour)this).StartCoroutine(FKMKACDFJMF(LocalisationSystem.Get("Intro11"), 9.5f, 0.5f, introVoices[10]));
		AFMFHCAHEFO = 3f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			FNBKNIHOPNB(inkeeperPeople);
			yield return null;
		}
		yield return (object)new WaitForSeconds(7f);
		((MonoBehaviour)this).StartCoroutine(FKMKACDFJMF(LocalisationSystem.Get("Intro12"), 7.5f, 0.5f, introVoices[11]));
		AFMFHCAHEFO = 4f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			BFPELKGBMJO(innkeeperConstruction);
			yield return null;
		}
		yield return (object)new WaitForSeconds(4.5f);
		AFMFHCAHEFO = 2.5f;
		DBEFBFPAOAA = 0f;
		MultiAudioManager.PlayAudioObject(scrollPage, ((Component)this).transform);
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			LPANJGDGGMI(-2400f, -3000f);
			yield return null;
		}
		((MonoBehaviour)this).StartCoroutine(FKMKACDFJMF(LocalisationSystem.Get("Intro13"), 11.5f, 0.5f, introVoices[12]));
		AFMFHCAHEFO = 2f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			BFPELKGBMJO(map);
			yield return null;
		}
		yield return (object)new WaitForSeconds(10.5f);
		((MonoBehaviour)this).StartCoroutine(FKMKACDFJMF(LocalisationSystem.Get("Intro14"), 9f, 0.5f, introVoices[13]));
		((MonoBehaviour)this).StartCoroutine(FKMKACDFJMF(LocalisationSystem.Get("Intro15"), 11f, 10f, introVoices[14]));
		AFMFHCAHEFO = 5f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			BFPELKGBMJO(innkeeperWithMug);
			yield return null;
		}
		yield return (object)new WaitForSeconds(16.5f);
		((MonoBehaviour)this).StartCoroutine(FKMKACDFJMF(LocalisationSystem.Get("Intro16"), 14.2f, 0.5f, introVoices[15]));
		AFMFHCAHEFO = 3f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			BFPELKGBMJO(innkeepersBattle);
			yield return null;
		}
		yield return (object)new WaitForSeconds(11.8f);
		((MonoBehaviour)this).StartCoroutine(FKMKACDFJMF(LocalisationSystem.Get("Intro17"), 9f, 0.5f, introVoices[16]));
		((MonoBehaviour)this).StartCoroutine(FKMKACDFJMF(LocalisationSystem.Get("Intro18"), 6f, 10f, introVoices[17]));
		AFMFHCAHEFO = 3f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			FNBKNIHOPNB(innkeeperStatue);
			yield return null;
		}
		yield return (object)new WaitForSeconds(13f);
		AFMFHCAHEFO = 2.5f;
		DBEFBFPAOAA = 0f;
		MultiAudioManager.PlayAudioObject(scrollPage, ((Component)this).transform);
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			LPANJGDGGMI(-3000f, -3600f);
			yield return null;
		}
		((MonoBehaviour)this).StartCoroutine(FKMKACDFJMF(LocalisationSystem.Get("Intro19"), 8f, 0.5f, introVoices[18]));
		((MonoBehaviour)this).StartCoroutine(FKMKACDFJMF(LocalisationSystem.Get("Intro20"), 7.5f, 9f, introVoices[19]));
		AFMFHCAHEFO = 8f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			BFPELKGBMJO(crown);
			yield return null;
		}
		yield return (object)new WaitForSeconds(7.5f);
		AFMFHCAHEFO = 2f;
		DBEFBFPAOAA = 0f;
		while (DBEFBFPAOAA < AFMFHCAHEFO)
		{
			FNBKNIHOPNB(blackScreen);
			yield return null;
		}
		Intro.ScrollIntroEnd();
		((Component)((Component)this).transform.parent).gameObject.SetActive(false);
		Debug.Log((object)"End");
	}

	private void PKOOAJDMKAE(Image IBFBOBBOLOK)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		DBEFBFPAOAA += Time.deltaTime;
		DCGBADKLANM = DBEFBFPAOAA / AFMFHCAHEFO;
		if (DCGBADKLANM > 83f)
		{
			DCGBADKLANM = 1801f;
		}
		KKHJAIKFOCA = new Material(((Graphic)IBFBOBBOLOK).material);
		KKHJAIKFOCA.SetFloat("Press {0} to continue", DCGBADKLANM);
		((Component)IBFBOBBOLOK).GetComponent<CanvasRenderer>().SetMaterial(KKHJAIKFOCA, 0);
	}

	private IEnumerator IEFEOMFNODE(string NLDJCBDCHJL, float DDPOGFLFIAI, float JDAFFMPLOGJ, AudioObject FHOPHMIDBGJ)
	{
		return new ALEHNFJEMDF(1)
		{
			_003C_003E4__this = this,
			newText = NLDJCBDCHJL,
			wait = DDPOGFLFIAI,
			initialWait = JDAFFMPLOGJ,
			voice = FHOPHMIDBGJ
		};
	}

	public void LKIHFHCGMEE()
	{
		AGMMDBNGNBE = false;
		if (Object.op_Implicit((Object)(object)FIPGGEAIFIH) && FIPGGEAIFIH.IsPlaying)
		{
			FIPGGEAIFIH.FadeOut(59f, true);
		}
		EPKFHGLAIMB.FadeOut(634f, false);
		((MonoBehaviour)this).StopCoroutine(NAPOPPGIHJF);
		NAPOPPGIHJF = null;
	}
}
