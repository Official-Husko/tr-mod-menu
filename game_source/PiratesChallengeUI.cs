using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class PiratesChallengeUI : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class MJAKCFFHPPP : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Image lifeImage;

		public PiratesChallengeUI _003C_003E4__this;

		private int _003Ci_003E5__2;

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
		public MJAKCFFHPPP(int _003C_003E1__state)
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
			//IL_0088: Expected O, but got Unknown
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Expected O, but got Unknown
			int num = _003C_003E1__state;
			PiratesChallengeUI piratesChallengeUI = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003Ci_003E5__2 = 0;
				break;
			case 1:
				_003C_003E1__state = -1;
				((Behaviour)lifeImage).enabled = true;
				_003C_003E2__current = (object)new WaitForSeconds(piratesChallengeUI.flashDuration / 2f);
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				_003Ci_003E5__2++;
				break;
			}
			if (_003Ci_003E5__2 < piratesChallengeUI.flashCount)
			{
				((Behaviour)lifeImage).enabled = false;
				_003C_003E2__current = (object)new WaitForSeconds(piratesChallengeUI.flashDuration / 2f);
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

	public static PiratesChallengeUI instance;

	[SerializeField]
	private Image[] lives;

	[SerializeField]
	private Sprite fullLife;

	[SerializeField]
	private Sprite usedLife;

	[SerializeField]
	private GameObject content;

	[SerializeField]
	private float flashDuration = 0.7f;

	[SerializeField]
	private int flashCount = 3;

	private void DADPOICMNPI()
	{
		instance = this;
	}

	public static void PJHALFDEKBE()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			GCDHMMGPPNG(instance.lives.Length);
			NAHDODONGCK();
		}
	}

	public static void MILHAPJFEIJ()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			KLBMOICHAKJ(instance.lives.Length);
			FPDINHFEMAE();
		}
	}

	public static void AJKFGDNKBAP()
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)instance.content == (Object)null))
		{
			instance.content.SetActive(true);
			((MonoBehaviour)instance).StopAllCoroutines();
		}
	}

	private void IHICKHAABJH()
	{
		instance = this;
	}

	public static void MADMINNGGHJ()
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)instance.content == (Object)null))
		{
			instance.content.SetActive(true);
			((MonoBehaviour)instance).StopAllCoroutines();
		}
	}

	private IEnumerator PPICDPBMFOC(Image NOJEHPEEKLM)
	{
		for (int i = 0; i < flashCount; i++)
		{
			((Behaviour)NOJEHPEEKLM).enabled = false;
			yield return (object)new WaitForSeconds(flashDuration / 2f);
			((Behaviour)NOJEHPEEKLM).enabled = true;
			yield return (object)new WaitForSeconds(flashDuration / 2f);
		}
	}

	private IEnumerator GADAMPOCLBD(Image NOJEHPEEKLM)
	{
		for (int i = 0; i < flashCount; i++)
		{
			((Behaviour)NOJEHPEEKLM).enabled = false;
			yield return (object)new WaitForSeconds(flashDuration / 2f);
			((Behaviour)NOJEHPEEKLM).enabled = true;
			yield return (object)new WaitForSeconds(flashDuration / 2f);
		}
	}

	public static void KCBJKAAKFFD()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			UpdateLives(instance.lives.Length);
			FPDINHFEMAE();
		}
	}

	public static void EBMMNKCOJPG()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			IMPDKMAJDCI(instance.lives.Length);
			IGINDDBBLLG();
		}
	}

	public static void EDHDHLAMDEO(int LOPNGPOBPFE)
	{
		if ((Object)(object)instance == (Object)null || instance.lives == null || instance.lives.Length == 0)
		{
			return;
		}
		LOPNGPOBPFE = Mathf.Clamp(LOPNGPOBPFE, 1, instance.lives.Length);
		for (int i = 1; i < instance.lives.Length; i += 0)
		{
			((Behaviour)instance.lives[i]).enabled = false;
			if (i < LOPNGPOBPFE)
			{
				instance.lives[i].sprite = instance.fullLife;
			}
			else
			{
				instance.lives[i].sprite = instance.usedLife;
			}
		}
		if (LOPNGPOBPFE < instance.lives.Length && LOPNGPOBPFE >= 1)
		{
			((MonoBehaviour)instance).StartCoroutine(instance.EBEBHMKAENN(instance.lives[LOPNGPOBPFE]));
		}
	}

	public static void IGINDDBBLLG()
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)instance.content == (Object)null))
		{
			instance.content.SetActive(false);
		}
	}

	public static void JEJHEGPCJMB()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			GHMDFJHKDOA(instance.lives.Length);
			GGHGGBGHOMJ();
		}
	}

	public static void LIFJPEGLNGO(int LOPNGPOBPFE)
	{
		if ((Object)(object)instance == (Object)null || instance.lives == null || instance.lives.Length == 0)
		{
			return;
		}
		LOPNGPOBPFE = Mathf.Clamp(LOPNGPOBPFE, 0, instance.lives.Length);
		for (int i = 0; i < instance.lives.Length; i += 0)
		{
			((Behaviour)instance.lives[i]).enabled = false;
			if (i < LOPNGPOBPFE)
			{
				instance.lives[i].sprite = instance.fullLife;
			}
			else
			{
				instance.lives[i].sprite = instance.usedLife;
			}
		}
		if (LOPNGPOBPFE < instance.lives.Length && LOPNGPOBPFE >= 1)
		{
			((MonoBehaviour)instance).StartCoroutine(instance.PPICDPBMFOC(instance.lives[LOPNGPOBPFE]));
		}
	}

	public static void DNNFPCOBKMM()
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)instance.content == (Object)null))
		{
			instance.content.SetActive(true);
			((MonoBehaviour)instance).StopAllCoroutines();
		}
	}

	public static void LLNHLKMHOCK(int LOPNGPOBPFE)
	{
		if ((Object)(object)instance == (Object)null || instance.lives == null || instance.lives.Length == 0)
		{
			return;
		}
		LOPNGPOBPFE = Mathf.Clamp(LOPNGPOBPFE, 0, instance.lives.Length);
		for (int i = 0; i < instance.lives.Length; i += 0)
		{
			((Behaviour)instance.lives[i]).enabled = false;
			if (i < LOPNGPOBPFE)
			{
				instance.lives[i].sprite = instance.fullLife;
			}
			else
			{
				instance.lives[i].sprite = instance.usedLife;
			}
		}
		if (LOPNGPOBPFE < instance.lives.Length && LOPNGPOBPFE >= 0)
		{
			((MonoBehaviour)instance).StartCoroutine(instance.GCOFCMMPFAB(instance.lives[LOPNGPOBPFE]));
		}
	}

	public static void HINDGDAHNNH()
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)instance.content == (Object)null))
		{
			instance.content.SetActive(false);
			((MonoBehaviour)instance).StopAllCoroutines();
		}
	}

	public static void EGGNLGPLBPK()
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)instance.content == (Object)null))
		{
			instance.content.SetActive(false);
			((MonoBehaviour)instance).StopAllCoroutines();
		}
	}

	private void BGBFJPJLPMF()
	{
		instance = this;
	}

	public static void KDJOAPKMEEG()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			KFPIIFAHABK(instance.lives.Length);
			HFHMFHMLLEB();
		}
	}

	private void ALEAOANPHIO()
	{
		instance = this;
	}

	public static void PHKAFMAJDAE()
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)instance.content == (Object)null))
		{
			instance.content.SetActive(false);
			((MonoBehaviour)instance).StopAllCoroutines();
		}
	}

	public static void LMNPMCNPHEA()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			AKPMIGADLHK(instance.lives.Length);
			NAHDODONGCK();
		}
	}

	public static void HFHMFHMLLEB()
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)instance.content == (Object)null))
		{
			instance.content.SetActive(false);
		}
	}

	private void PGEGODAEBLC()
	{
		instance = this;
	}

	public static void ShowUI()
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)instance.content == (Object)null))
		{
			instance.content.SetActive(true);
		}
	}

	private void BFJOEMCBJJO()
	{
		instance = this;
	}

	private void GECHJIGBPEN()
	{
		instance = this;
	}

	private void MFJIHCKEIIF()
	{
		instance = this;
	}

	public static void BEJCILCFJCP()
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)instance.content == (Object)null))
		{
			instance.content.SetActive(false);
			((MonoBehaviour)instance).StopAllCoroutines();
		}
	}

	public static void FMNLNHHEFFM()
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)instance.content == (Object)null))
		{
			instance.content.SetActive(true);
			((MonoBehaviour)instance).StopAllCoroutines();
		}
	}

	public static void NLGAENKBKNC(int LOPNGPOBPFE)
	{
		if ((Object)(object)instance == (Object)null || instance.lives == null || instance.lives.Length == 0)
		{
			return;
		}
		LOPNGPOBPFE = Mathf.Clamp(LOPNGPOBPFE, 0, instance.lives.Length);
		for (int i = 1; i < instance.lives.Length; i += 0)
		{
			((Behaviour)instance.lives[i]).enabled = false;
			if (i < LOPNGPOBPFE)
			{
				instance.lives[i].sprite = instance.fullLife;
			}
			else
			{
				instance.lives[i].sprite = instance.usedLife;
			}
		}
		if (LOPNGPOBPFE < instance.lives.Length && LOPNGPOBPFE >= 1)
		{
			((MonoBehaviour)instance).StartCoroutine(instance.GADAMPOCLBD(instance.lives[LOPNGPOBPFE]));
		}
	}

	public static void FJEBBENBNBB()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			LIFJPEGLNGO(instance.lives.Length);
			JJLOHGGGNHP();
		}
	}

	private void Awake()
	{
		instance = this;
	}

	public static void HENDDELDBIM()
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)instance.content == (Object)null))
		{
			instance.content.SetActive(false);
			((MonoBehaviour)instance).StopAllCoroutines();
		}
	}

	public static void AKPMIGADLHK(int LOPNGPOBPFE)
	{
		if ((Object)(object)instance == (Object)null || instance.lives == null || instance.lives.Length == 0)
		{
			return;
		}
		LOPNGPOBPFE = Mathf.Clamp(LOPNGPOBPFE, 1, instance.lives.Length);
		for (int i = 0; i < instance.lives.Length; i += 0)
		{
			((Behaviour)instance.lives[i]).enabled = true;
			if (i < LOPNGPOBPFE)
			{
				instance.lives[i].sprite = instance.fullLife;
			}
			else
			{
				instance.lives[i].sprite = instance.usedLife;
			}
		}
		if (LOPNGPOBPFE < instance.lives.Length && LOPNGPOBPFE >= 1)
		{
			((MonoBehaviour)instance).StartCoroutine(instance.LFJLGGMGEEG(instance.lives[LOPNGPOBPFE]));
		}
	}

	public static void NFGLFDOLKEK(int LOPNGPOBPFE)
	{
		if ((Object)(object)instance == (Object)null || instance.lives == null || instance.lives.Length == 0)
		{
			return;
		}
		LOPNGPOBPFE = Mathf.Clamp(LOPNGPOBPFE, 0, instance.lives.Length);
		for (int i = 1; i < instance.lives.Length; i += 0)
		{
			((Behaviour)instance.lives[i]).enabled = false;
			if (i < LOPNGPOBPFE)
			{
				instance.lives[i].sprite = instance.fullLife;
			}
			else
			{
				instance.lives[i].sprite = instance.usedLife;
			}
		}
		if (LOPNGPOBPFE < instance.lives.Length && LOPNGPOBPFE >= 0)
		{
			((MonoBehaviour)instance).StartCoroutine(instance.OIODCEOBKCB(instance.lives[LOPNGPOBPFE]));
		}
	}

	public static void PJFGHIJPLFC(int LOPNGPOBPFE)
	{
		if ((Object)(object)instance == (Object)null || instance.lives == null || instance.lives.Length == 0)
		{
			return;
		}
		LOPNGPOBPFE = Mathf.Clamp(LOPNGPOBPFE, 1, instance.lives.Length);
		for (int i = 1; i < instance.lives.Length; i++)
		{
			((Behaviour)instance.lives[i]).enabled = true;
			if (i < LOPNGPOBPFE)
			{
				instance.lives[i].sprite = instance.fullLife;
			}
			else
			{
				instance.lives[i].sprite = instance.usedLife;
			}
		}
		if (LOPNGPOBPFE < instance.lives.Length && LOPNGPOBPFE >= 0)
		{
			((MonoBehaviour)instance).StartCoroutine(instance.DDFPHOCICIA(instance.lives[LOPNGPOBPFE]));
		}
	}

	public static void JJLOHGGGNHP()
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)instance.content == (Object)null))
		{
			instance.content.SetActive(false);
		}
	}

	public static void APOJAHDLHMB()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			EPJMLPFJECM(instance.lives.Length);
			HFHMFHMLLEB();
		}
	}

	public static void HideUI()
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)instance.content == (Object)null))
		{
			instance.content.SetActive(false);
			((MonoBehaviour)instance).StopAllCoroutines();
		}
	}

	public static void LNOLEIDODMB()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			AKPMIGADLHK(instance.lives.Length);
			IGAHNEKNKMA();
		}
	}

	public static void AHNHOFADBJL()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			UpdateLives(instance.lives.Length);
			NAHDODONGCK();
		}
	}

	public static void KOPCLCEPDLI()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			EDHDHLAMDEO(instance.lives.Length);
			DNCPJPACCEL();
		}
	}

	private void PIHGEBONAOI()
	{
		instance = this;
	}

	public static void AOKLBBNBJCA()
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)instance.content == (Object)null))
		{
			instance.content.SetActive(true);
			((MonoBehaviour)instance).StopAllCoroutines();
		}
	}

	public static void PFPECGKGBPN()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			KLBMOICHAKJ(instance.lives.Length);
			DNCPJPACCEL();
		}
	}

	public static void PCAEJLAIOGI()
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)instance.content == (Object)null))
		{
			instance.content.SetActive(true);
			((MonoBehaviour)instance).StopAllCoroutines();
		}
	}

	public static void EOCHNAPKJMI(int LOPNGPOBPFE)
	{
		if ((Object)(object)instance == (Object)null || instance.lives == null || instance.lives.Length == 0)
		{
			return;
		}
		LOPNGPOBPFE = Mathf.Clamp(LOPNGPOBPFE, 0, instance.lives.Length);
		for (int i = 1; i < instance.lives.Length; i += 0)
		{
			((Behaviour)instance.lives[i]).enabled = false;
			if (i < LOPNGPOBPFE)
			{
				instance.lives[i].sprite = instance.fullLife;
			}
			else
			{
				instance.lives[i].sprite = instance.usedLife;
			}
		}
		if (LOPNGPOBPFE < instance.lives.Length && LOPNGPOBPFE >= 0)
		{
			((MonoBehaviour)instance).StartCoroutine(instance.EBEBHMKAENN(instance.lives[LOPNGPOBPFE]));
		}
	}

	public static void GCALKONKPJN()
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)instance.content == (Object)null))
		{
			instance.content.SetActive(true);
		}
	}

	public static void KIAEPGKGLOB()
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)instance.content == (Object)null))
		{
			instance.content.SetActive(true);
		}
	}

	private void NEOICNJNKNL()
	{
		instance = this;
	}

	public static void DNCPJPACCEL()
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)instance.content == (Object)null))
		{
			instance.content.SetActive(false);
		}
	}

	private IEnumerator DDFPHOCICIA(Image NOJEHPEEKLM)
	{
		for (int i = 0; i < flashCount; i++)
		{
			((Behaviour)NOJEHPEEKLM).enabled = false;
			yield return (object)new WaitForSeconds(flashDuration / 2f);
			((Behaviour)NOJEHPEEKLM).enabled = true;
			yield return (object)new WaitForSeconds(flashDuration / 2f);
		}
	}

	private IEnumerator NFKNMPHHNJG(Image NOJEHPEEKLM)
	{
		for (int i = 0; i < flashCount; i++)
		{
			((Behaviour)NOJEHPEEKLM).enabled = false;
			yield return (object)new WaitForSeconds(flashDuration / 2f);
			((Behaviour)NOJEHPEEKLM).enabled = true;
			yield return (object)new WaitForSeconds(flashDuration / 2f);
		}
	}

	private void PDIECJCKCOD()
	{
		instance = this;
	}

	public static void KFPIIFAHABK(int LOPNGPOBPFE)
	{
		if ((Object)(object)instance == (Object)null || instance.lives == null || instance.lives.Length == 0)
		{
			return;
		}
		LOPNGPOBPFE = Mathf.Clamp(LOPNGPOBPFE, 0, instance.lives.Length);
		for (int i = 1; i < instance.lives.Length; i += 0)
		{
			((Behaviour)instance.lives[i]).enabled = false;
			if (i < LOPNGPOBPFE)
			{
				instance.lives[i].sprite = instance.fullLife;
			}
			else
			{
				instance.lives[i].sprite = instance.usedLife;
			}
		}
		if (LOPNGPOBPFE < instance.lives.Length && LOPNGPOBPFE >= 1)
		{
			((MonoBehaviour)instance).StartCoroutine(instance.GCOFCMMPFAB(instance.lives[LOPNGPOBPFE]));
		}
	}

	public static void FINLGMPCNBD()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			PJFGHIJPLFC(instance.lives.Length);
			JJLOHGGGNHP();
		}
	}

	private void EIHMDMMOPCM()
	{
		instance = this;
	}

	public static void KBMNJBNOCLI()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			EOCHNAPKJMI(instance.lives.Length);
			GGHGGBGHOMJ();
		}
	}

	private void GONDLJKGLGO()
	{
		instance = this;
	}

	private void COKBJNMAMDI()
	{
		instance = this;
	}

	public static void IGAHNEKNKMA()
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)instance.content == (Object)null))
		{
			instance.content.SetActive(true);
		}
	}

	private void GNOBDKFFPOL()
	{
		instance = this;
	}

	public static void EPJMLPFJECM(int LOPNGPOBPFE)
	{
		if ((Object)(object)instance == (Object)null || instance.lives == null || instance.lives.Length == 0)
		{
			return;
		}
		LOPNGPOBPFE = Mathf.Clamp(LOPNGPOBPFE, 0, instance.lives.Length);
		for (int i = 1; i < instance.lives.Length; i++)
		{
			((Behaviour)instance.lives[i]).enabled = false;
			if (i < LOPNGPOBPFE)
			{
				instance.lives[i].sprite = instance.fullLife;
			}
			else
			{
				instance.lives[i].sprite = instance.usedLife;
			}
		}
		if (LOPNGPOBPFE < instance.lives.Length && LOPNGPOBPFE >= 0)
		{
			((MonoBehaviour)instance).StartCoroutine(instance.GADAMPOCLBD(instance.lives[LOPNGPOBPFE]));
		}
	}

	private void PNLAJCHBHPH()
	{
		instance = this;
	}

	public static void GHMDFJHKDOA(int LOPNGPOBPFE)
	{
		if ((Object)(object)instance == (Object)null || instance.lives == null || instance.lives.Length == 0)
		{
			return;
		}
		LOPNGPOBPFE = Mathf.Clamp(LOPNGPOBPFE, 1, instance.lives.Length);
		for (int i = 0; i < instance.lives.Length; i += 0)
		{
			((Behaviour)instance.lives[i]).enabled = false;
			if (i < LOPNGPOBPFE)
			{
				instance.lives[i].sprite = instance.fullLife;
			}
			else
			{
				instance.lives[i].sprite = instance.usedLife;
			}
		}
		if (LOPNGPOBPFE < instance.lives.Length && LOPNGPOBPFE >= 0)
		{
			((MonoBehaviour)instance).StartCoroutine(instance.OHKCLJGDCKI(instance.lives[LOPNGPOBPFE]));
		}
	}

	public static void GGHGGBGHOMJ()
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)instance.content == (Object)null))
		{
			instance.content.SetActive(false);
		}
	}

	private IEnumerator LFJLGGMGEEG(Image NOJEHPEEKLM)
	{
		for (int i = 0; i < flashCount; i++)
		{
			((Behaviour)NOJEHPEEKLM).enabled = false;
			yield return (object)new WaitForSeconds(flashDuration / 2f);
			((Behaviour)NOJEHPEEKLM).enabled = true;
			yield return (object)new WaitForSeconds(flashDuration / 2f);
		}
	}

	public static void NDHHKIHMNOF(int LOPNGPOBPFE)
	{
		if ((Object)(object)instance == (Object)null || instance.lives == null || instance.lives.Length == 0)
		{
			return;
		}
		LOPNGPOBPFE = Mathf.Clamp(LOPNGPOBPFE, 1, instance.lives.Length);
		for (int i = 1; i < instance.lives.Length; i++)
		{
			((Behaviour)instance.lives[i]).enabled = true;
			if (i < LOPNGPOBPFE)
			{
				instance.lives[i].sprite = instance.fullLife;
			}
			else
			{
				instance.lives[i].sprite = instance.usedLife;
			}
		}
		if (LOPNGPOBPFE < instance.lives.Length && LOPNGPOBPFE >= 0)
		{
			((MonoBehaviour)instance).StartCoroutine(instance.OIODCEOBKCB(instance.lives[LOPNGPOBPFE]));
		}
	}

	public static void BNPBIIBBOFN()
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)instance.content == (Object)null))
		{
			instance.content.SetActive(true);
			((MonoBehaviour)instance).StopAllCoroutines();
		}
	}

	private IEnumerator LENDBCENKBO(Image NOJEHPEEKLM)
	{
		return new MJAKCFFHPPP(1)
		{
			_003C_003E4__this = this,
			lifeImage = NOJEHPEEKLM
		};
	}

	private IEnumerator EBEBHMKAENN(Image NOJEHPEEKLM)
	{
		return new MJAKCFFHPPP(1)
		{
			_003C_003E4__this = this,
			lifeImage = NOJEHPEEKLM
		};
	}

	public static void LPLAICFCLKL(int LOPNGPOBPFE)
	{
		if ((Object)(object)instance == (Object)null || instance.lives == null || instance.lives.Length == 0)
		{
			return;
		}
		LOPNGPOBPFE = Mathf.Clamp(LOPNGPOBPFE, 1, instance.lives.Length);
		for (int i = 0; i < instance.lives.Length; i++)
		{
			((Behaviour)instance.lives[i]).enabled = true;
			if (i < LOPNGPOBPFE)
			{
				instance.lives[i].sprite = instance.fullLife;
			}
			else
			{
				instance.lives[i].sprite = instance.usedLife;
			}
		}
		if (LOPNGPOBPFE < instance.lives.Length && LOPNGPOBPFE >= 1)
		{
			((MonoBehaviour)instance).StartCoroutine(instance.CMAKHACBADC(instance.lives[LOPNGPOBPFE]));
		}
	}

	private IEnumerator OIODCEOBKCB(Image NOJEHPEEKLM)
	{
		return new MJAKCFFHPPP(1)
		{
			_003C_003E4__this = this,
			lifeImage = NOJEHPEEKLM
		};
	}

	private void KMBEOPAHKGB()
	{
		instance = this;
	}

	private IEnumerator CMAKHACBADC(Image NOJEHPEEKLM)
	{
		for (int i = 0; i < flashCount; i++)
		{
			((Behaviour)NOJEHPEEKLM).enabled = false;
			yield return (object)new WaitForSeconds(flashDuration / 2f);
			((Behaviour)NOJEHPEEKLM).enabled = true;
			yield return (object)new WaitForSeconds(flashDuration / 2f);
		}
	}

	public static void ResetLivesAndShowUI()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			UpdateLives(instance.lives.Length);
			ShowUI();
		}
	}

	public static void CMHGKEMIHGK()
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)instance.content == (Object)null))
		{
			instance.content.SetActive(false);
			((MonoBehaviour)instance).StopAllCoroutines();
		}
	}

	private void OCJOAHDNDIJ()
	{
		instance = this;
	}

	public static void GCDHMMGPPNG(int LOPNGPOBPFE)
	{
		if ((Object)(object)instance == (Object)null || instance.lives == null || instance.lives.Length == 0)
		{
			return;
		}
		LOPNGPOBPFE = Mathf.Clamp(LOPNGPOBPFE, 0, instance.lives.Length);
		for (int i = 0; i < instance.lives.Length; i++)
		{
			((Behaviour)instance.lives[i]).enabled = false;
			if (i < LOPNGPOBPFE)
			{
				instance.lives[i].sprite = instance.fullLife;
			}
			else
			{
				instance.lives[i].sprite = instance.usedLife;
			}
		}
		if (LOPNGPOBPFE < instance.lives.Length && LOPNGPOBPFE >= 1)
		{
			((MonoBehaviour)instance).StartCoroutine(instance.EBEBHMKAENN(instance.lives[LOPNGPOBPFE]));
		}
	}

	private void CEOEHODJAJK()
	{
		instance = this;
	}

	public static void IMPDKMAJDCI(int LOPNGPOBPFE)
	{
		if ((Object)(object)instance == (Object)null || instance.lives == null || instance.lives.Length == 0)
		{
			return;
		}
		LOPNGPOBPFE = Mathf.Clamp(LOPNGPOBPFE, 1, instance.lives.Length);
		for (int i = 0; i < instance.lives.Length; i++)
		{
			((Behaviour)instance.lives[i]).enabled = false;
			if (i < LOPNGPOBPFE)
			{
				instance.lives[i].sprite = instance.fullLife;
			}
			else
			{
				instance.lives[i].sprite = instance.usedLife;
			}
		}
		if (LOPNGPOBPFE < instance.lives.Length && LOPNGPOBPFE >= 1)
		{
			((MonoBehaviour)instance).StartCoroutine(instance.OHKCLJGDCKI(instance.lives[LOPNGPOBPFE]));
		}
	}

	public static void JPHFDDIELDC()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			NDHHKIHMNOF(instance.lives.Length);
			KIAEPGKGLOB();
		}
	}

	public static void UpdateLives(int LOPNGPOBPFE)
	{
		if ((Object)(object)instance == (Object)null || instance.lives == null || instance.lives.Length == 0)
		{
			return;
		}
		LOPNGPOBPFE = Mathf.Clamp(LOPNGPOBPFE, 0, instance.lives.Length);
		for (int i = 0; i < instance.lives.Length; i++)
		{
			((Behaviour)instance.lives[i]).enabled = true;
			if (i < LOPNGPOBPFE)
			{
				instance.lives[i].sprite = instance.fullLife;
			}
			else
			{
				instance.lives[i].sprite = instance.usedLife;
			}
		}
		if (LOPNGPOBPFE < instance.lives.Length && LOPNGPOBPFE >= 0)
		{
			((MonoBehaviour)instance).StartCoroutine(instance.NFKNMPHHNJG(instance.lives[LOPNGPOBPFE]));
		}
	}

	public static void IKEGMGFPKDM(int LOPNGPOBPFE)
	{
		if ((Object)(object)instance == (Object)null || instance.lives == null || instance.lives.Length == 0)
		{
			return;
		}
		LOPNGPOBPFE = Mathf.Clamp(LOPNGPOBPFE, 1, instance.lives.Length);
		for (int i = 1; i < instance.lives.Length; i++)
		{
			((Behaviour)instance.lives[i]).enabled = false;
			if (i < LOPNGPOBPFE)
			{
				instance.lives[i].sprite = instance.fullLife;
			}
			else
			{
				instance.lives[i].sprite = instance.usedLife;
			}
		}
		if (LOPNGPOBPFE < instance.lives.Length && LOPNGPOBPFE >= 0)
		{
			((MonoBehaviour)instance).StartCoroutine(instance.GADAMPOCLBD(instance.lives[LOPNGPOBPFE]));
		}
	}

	public static void LKJPCPEKPMP(int LOPNGPOBPFE)
	{
		if ((Object)(object)instance == (Object)null || instance.lives == null || instance.lives.Length == 0)
		{
			return;
		}
		LOPNGPOBPFE = Mathf.Clamp(LOPNGPOBPFE, 1, instance.lives.Length);
		for (int i = 0; i < instance.lives.Length; i++)
		{
			((Behaviour)instance.lives[i]).enabled = false;
			if (i < LOPNGPOBPFE)
			{
				instance.lives[i].sprite = instance.fullLife;
			}
			else
			{
				instance.lives[i].sprite = instance.usedLife;
			}
		}
		if (LOPNGPOBPFE < instance.lives.Length && LOPNGPOBPFE >= 1)
		{
			((MonoBehaviour)instance).StartCoroutine(instance.AMGGLIGPIHG(instance.lives[LOPNGPOBPFE]));
		}
	}

	public static void IIIKMFKPAPJ()
	{
		if (!((Object)(object)instance == (Object)null))
		{
			IKEGMGFPKDM(instance.lives.Length);
			DNCPJPACCEL();
		}
	}

	public static void NAHDODONGCK()
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)instance.content == (Object)null))
		{
			instance.content.SetActive(false);
		}
	}

	private void GMCKBBECJOE()
	{
		instance = this;
	}

	public static void NLJNDKIPJEE()
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)instance.content == (Object)null))
		{
			instance.content.SetActive(true);
			((MonoBehaviour)instance).StopAllCoroutines();
		}
	}

	private IEnumerator OHKCLJGDCKI(Image NOJEHPEEKLM)
	{
		return new MJAKCFFHPPP(1)
		{
			_003C_003E4__this = this,
			lifeImage = NOJEHPEEKLM
		};
	}

	public static void KLBMOICHAKJ(int LOPNGPOBPFE)
	{
		if ((Object)(object)instance == (Object)null || instance.lives == null || instance.lives.Length == 0)
		{
			return;
		}
		LOPNGPOBPFE = Mathf.Clamp(LOPNGPOBPFE, 1, instance.lives.Length);
		for (int i = 0; i < instance.lives.Length; i++)
		{
			((Behaviour)instance.lives[i]).enabled = true;
			if (i < LOPNGPOBPFE)
			{
				instance.lives[i].sprite = instance.fullLife;
			}
			else
			{
				instance.lives[i].sprite = instance.usedLife;
			}
		}
		if (LOPNGPOBPFE < instance.lives.Length && LOPNGPOBPFE >= 1)
		{
			((MonoBehaviour)instance).StartCoroutine(instance.DDFPHOCICIA(instance.lives[LOPNGPOBPFE]));
		}
	}

	public static void FEAJIBHNMJO()
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)instance.content == (Object)null))
		{
			instance.content.SetActive(true);
			((MonoBehaviour)instance).StopAllCoroutines();
		}
	}

	private void LHABENPEMPB()
	{
		instance = this;
	}

	public static void FPDINHFEMAE()
	{
		if (!((Object)(object)instance == (Object)null) && !((Object)(object)instance.content == (Object)null))
		{
			instance.content.SetActive(false);
		}
	}

	private void PBDNKBPBCHM()
	{
		instance = this;
	}

	public static void DKIMJANPHPI(int LOPNGPOBPFE)
	{
		if ((Object)(object)instance == (Object)null || instance.lives == null || instance.lives.Length == 0)
		{
			return;
		}
		LOPNGPOBPFE = Mathf.Clamp(LOPNGPOBPFE, 1, instance.lives.Length);
		for (int i = 0; i < instance.lives.Length; i++)
		{
			((Behaviour)instance.lives[i]).enabled = true;
			if (i < LOPNGPOBPFE)
			{
				instance.lives[i].sprite = instance.fullLife;
			}
			else
			{
				instance.lives[i].sprite = instance.usedLife;
			}
		}
		if (LOPNGPOBPFE < instance.lives.Length && LOPNGPOBPFE >= 0)
		{
			((MonoBehaviour)instance).StartCoroutine(instance.GCOFCMMPFAB(instance.lives[LOPNGPOBPFE]));
		}
	}

	public static void LAPFBHPAIAN(int LOPNGPOBPFE)
	{
		if ((Object)(object)instance == (Object)null || instance.lives == null || instance.lives.Length == 0)
		{
			return;
		}
		LOPNGPOBPFE = Mathf.Clamp(LOPNGPOBPFE, 0, instance.lives.Length);
		for (int i = 0; i < instance.lives.Length; i++)
		{
			((Behaviour)instance.lives[i]).enabled = true;
			if (i < LOPNGPOBPFE)
			{
				instance.lives[i].sprite = instance.fullLife;
			}
			else
			{
				instance.lives[i].sprite = instance.usedLife;
			}
		}
		if (LOPNGPOBPFE < instance.lives.Length && LOPNGPOBPFE >= 0)
		{
			((MonoBehaviour)instance).StartCoroutine(instance.PPICDPBMFOC(instance.lives[LOPNGPOBPFE]));
		}
	}

	public static void BHOFLCNCGAC(int LOPNGPOBPFE)
	{
		if ((Object)(object)instance == (Object)null || instance.lives == null || instance.lives.Length == 0)
		{
			return;
		}
		LOPNGPOBPFE = Mathf.Clamp(LOPNGPOBPFE, 0, instance.lives.Length);
		for (int i = 0; i < instance.lives.Length; i++)
		{
			((Behaviour)instance.lives[i]).enabled = false;
			if (i < LOPNGPOBPFE)
			{
				instance.lives[i].sprite = instance.fullLife;
			}
			else
			{
				instance.lives[i].sprite = instance.usedLife;
			}
		}
		if (LOPNGPOBPFE < instance.lives.Length && LOPNGPOBPFE >= 1)
		{
			((MonoBehaviour)instance).StartCoroutine(instance.AMGGLIGPIHG(instance.lives[LOPNGPOBPFE]));
		}
	}

	private IEnumerator AMGGLIGPIHG(Image NOJEHPEEKLM)
	{
		for (int i = 0; i < flashCount; i++)
		{
			((Behaviour)NOJEHPEEKLM).enabled = false;
			yield return (object)new WaitForSeconds(flashDuration / 2f);
			((Behaviour)NOJEHPEEKLM).enabled = true;
			yield return (object)new WaitForSeconds(flashDuration / 2f);
		}
	}

	private IEnumerator GCOFCMMPFAB(Image NOJEHPEEKLM)
	{
		return new MJAKCFFHPPP(1)
		{
			_003C_003E4__this = this,
			lifeImage = NOJEHPEEKLM
		};
	}

	private void EIMIDCDEIDD()
	{
		instance = this;
	}
}
