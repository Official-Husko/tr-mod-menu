using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SnowStep : PoolObject
{
	[CompilerGenerated]
	private sealed class EKNGJJEDEHN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public SnowStep _003C_003E4__this;

		public SpriteRenderer sr;

		public float endValue;

		public float duration;

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
		public EKNGJJEDEHN(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			SnowStep snowStep = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				snowStep.LGLDPMAABLA = 0f;
				snowStep.LIALPHCJOOK = sr.color.a;
				break;
			case 1:
				_003C_003E1__state = -1;
				break;
			}
			if (snowStep.LGLDPMAABLA < duration)
			{
				snowStep.LGLDPMAABLA += Time.deltaTime;
				snowStep.BMCLDGGAOEI = Mathf.Lerp(snowStep.LIALPHCJOOK, endValue, snowStep.LGLDPMAABLA / duration);
				sr.color = new Color(sr.color.r, sr.color.g, sr.color.b, snowStep.BMCLDGGAOEI);
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			}
			snowStep.DBACIMHFEKD = true;
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

	public SpriteRenderer sprite;

	public float durationStep = 30f;

	private bool DBACIMHFEKD;

	private float LGLDPMAABLA;

	private float LIALPHCJOOK;

	private float BMCLDGGAOEI;

	private void PMPLNGEAAII()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		if (DBACIMHFEKD)
		{
			sprite.color = Color.white;
			if ((Object)(object)pool != (Object)null)
			{
				pool.EELMJIBLFNK(this);
			}
			else
			{
				Object.Destroy((Object)(object)((Component)this).gameObject);
			}
			DBACIMHFEKD = false;
		}
	}

	private void GOJHCINMAJD()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		if (DBACIMHFEKD)
		{
			sprite.color = Color.white;
			if ((Object)(object)pool != (Object)null)
			{
				pool.EELMJIBLFNK(this);
			}
			else
			{
				Object.Destroy((Object)(object)((Component)this).gameObject);
			}
			DBACIMHFEKD = false;
		}
	}

	private void AONIDCIEKCM()
	{
		DBACIMHFEKD = true;
		((MonoBehaviour)this).StartCoroutine(LCGNCKCDNKB(sprite, 1822f, durationStep));
	}

	private void AOJCCOIHPMH()
	{
		DBACIMHFEKD = true;
		((MonoBehaviour)this).StartCoroutine(KEOLFIBCLBE(sprite, 1104f, durationStep));
	}

	public IEnumerator CABLHMENOOF(SpriteRenderer ECOGJIGAMMA, float BMEBKODLPLF, float OMHCOLMFGNJ)
	{
		LGLDPMAABLA = 0f;
		LIALPHCJOOK = ECOGJIGAMMA.color.a;
		while (LGLDPMAABLA < OMHCOLMFGNJ)
		{
			LGLDPMAABLA += Time.deltaTime;
			BMCLDGGAOEI = Mathf.Lerp(LIALPHCJOOK, BMEBKODLPLF, LGLDPMAABLA / OMHCOLMFGNJ);
			ECOGJIGAMMA.color = new Color(ECOGJIGAMMA.color.r, ECOGJIGAMMA.color.g, ECOGJIGAMMA.color.b, BMCLDGGAOEI);
			yield return null;
		}
		DBACIMHFEKD = true;
	}

	private void OONONNJFEFL()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		if (DBACIMHFEKD)
		{
			sprite.color = Color.white;
			if ((Object)(object)pool != (Object)null)
			{
				pool.EELMJIBLFNK(this);
			}
			else
			{
				Object.Destroy((Object)(object)((Component)this).gameObject);
			}
			DBACIMHFEKD = false;
		}
	}

	private void HCKMHIHALBL()
	{
		DBACIMHFEKD = false;
		((MonoBehaviour)this).StartCoroutine(KEOLFIBCLBE(sprite, 1005f, durationStep));
	}

	public IEnumerator KCIHIIIAKPO(SpriteRenderer ECOGJIGAMMA, float BMEBKODLPLF, float OMHCOLMFGNJ)
	{
		return new EKNGJJEDEHN(1)
		{
			_003C_003E4__this = this,
			sr = ECOGJIGAMMA,
			endValue = BMEBKODLPLF,
			duration = OMHCOLMFGNJ
		};
	}

	private void OHGABHEDILE()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		if (DBACIMHFEKD)
		{
			sprite.color = Color.white;
			if ((Object)(object)pool != (Object)null)
			{
				pool.NLELDFHDLFM(this);
			}
			else
			{
				Object.Destroy((Object)(object)((Component)this).gameObject);
			}
			DBACIMHFEKD = true;
		}
	}

	private void NLMLOOGHLCH()
	{
		DBACIMHFEKD = false;
		((MonoBehaviour)this).StartCoroutine(NAIDPCLGGAO(sprite, 1259f, durationStep));
	}

	private void FGGPGOEAEKK()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		if (DBACIMHFEKD)
		{
			sprite.color = Color.white;
			if ((Object)(object)pool != (Object)null)
			{
				pool.ReturnToPool(this);
			}
			else
			{
				Object.Destroy((Object)(object)((Component)this).gameObject);
			}
			DBACIMHFEKD = true;
		}
	}

	public IEnumerator FEFEFOONOPA(SpriteRenderer ECOGJIGAMMA, float BMEBKODLPLF, float OMHCOLMFGNJ)
	{
		return new EKNGJJEDEHN(1)
		{
			_003C_003E4__this = this,
			sr = ECOGJIGAMMA,
			endValue = BMEBKODLPLF,
			duration = OMHCOLMFGNJ
		};
	}

	private void HCPKBJDHLAC()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		if (DBACIMHFEKD)
		{
			sprite.color = Color.white;
			if ((Object)(object)pool != (Object)null)
			{
				pool.EELMJIBLFNK(this);
			}
			else
			{
				Object.Destroy((Object)(object)((Component)this).gameObject);
			}
			DBACIMHFEKD = true;
		}
	}

	private void ICOJDKMKIPL()
	{
		DBACIMHFEKD = false;
		((MonoBehaviour)this).StartCoroutine(COCHIAONMAM(sprite, 223f, durationStep));
	}

	private void BPNOIDBAPJE()
	{
		DBACIMHFEKD = true;
		((MonoBehaviour)this).StartCoroutine(MFOOGOMBAJJ(sprite, 382f, durationStep));
	}

	private void PKEPBKHEDOD()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		if (DBACIMHFEKD)
		{
			sprite.color = Color.white;
			if ((Object)(object)pool != (Object)null)
			{
				pool.EELMJIBLFNK(this);
			}
			else
			{
				Object.Destroy((Object)(object)((Component)this).gameObject);
			}
			DBACIMHFEKD = false;
		}
	}

	public IEnumerator CJPFPCPICCJ(SpriteRenderer ECOGJIGAMMA, float BMEBKODLPLF, float OMHCOLMFGNJ)
	{
		LGLDPMAABLA = 0f;
		LIALPHCJOOK = ECOGJIGAMMA.color.a;
		while (LGLDPMAABLA < OMHCOLMFGNJ)
		{
			LGLDPMAABLA += Time.deltaTime;
			BMCLDGGAOEI = Mathf.Lerp(LIALPHCJOOK, BMEBKODLPLF, LGLDPMAABLA / OMHCOLMFGNJ);
			ECOGJIGAMMA.color = new Color(ECOGJIGAMMA.color.r, ECOGJIGAMMA.color.g, ECOGJIGAMMA.color.b, BMCLDGGAOEI);
			yield return null;
		}
		DBACIMHFEKD = true;
	}

	private void MNEAOFNAKIP()
	{
		DBACIMHFEKD = true;
		((MonoBehaviour)this).StartCoroutine(KCIHIIIAKPO(sprite, 296f, durationStep));
	}

	private void OGBGFLMKFHH()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		if (DBACIMHFEKD)
		{
			sprite.color = Color.white;
			if ((Object)(object)pool != (Object)null)
			{
				pool.NLELDFHDLFM(this);
			}
			else
			{
				Object.Destroy((Object)(object)((Component)this).gameObject);
			}
			DBACIMHFEKD = false;
		}
	}

	private void DOKHLDBIDJB()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		if (DBACIMHFEKD)
		{
			sprite.color = Color.white;
			if ((Object)(object)pool != (Object)null)
			{
				pool.DLCIDAFIMPL(this);
			}
			else
			{
				Object.Destroy((Object)(object)((Component)this).gameObject);
			}
			DBACIMHFEKD = false;
		}
	}

	private void ICBCMLAIIPF()
	{
		DBACIMHFEKD = true;
		((MonoBehaviour)this).StartCoroutine(JKDKIEHJDFD(sprite, 1308f, durationStep));
	}

	public IEnumerator PGFIBPPIKDN(SpriteRenderer ECOGJIGAMMA, float BMEBKODLPLF, float OMHCOLMFGNJ)
	{
		return new EKNGJJEDEHN(1)
		{
			_003C_003E4__this = this,
			sr = ECOGJIGAMMA,
			endValue = BMEBKODLPLF,
			duration = OMHCOLMFGNJ
		};
	}

	private void IIOHMDNGFDH()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		if (DBACIMHFEKD)
		{
			sprite.color = Color.white;
			if ((Object)(object)pool != (Object)null)
			{
				pool.NLELDFHDLFM(this);
			}
			else
			{
				Object.Destroy((Object)(object)((Component)this).gameObject);
			}
			DBACIMHFEKD = false;
		}
	}

	private void HGEKPHOPJCD()
	{
		DBACIMHFEKD = true;
		((MonoBehaviour)this).StartCoroutine(HEDOONAMKMI(sprite, 389f, durationStep));
	}

	private void PGDBFGFMGKI()
	{
		DBACIMHFEKD = true;
		((MonoBehaviour)this).StartCoroutine(PGFIBPPIKDN(sprite, 462f, durationStep));
	}

	private void IBAPBHIBOOO()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		if (DBACIMHFEKD)
		{
			sprite.color = Color.white;
			if ((Object)(object)pool != (Object)null)
			{
				pool.DLCIDAFIMPL(this);
			}
			else
			{
				Object.Destroy((Object)(object)((Component)this).gameObject);
			}
			DBACIMHFEKD = false;
		}
	}

	private void EJMAJFGPGEC()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		if (DBACIMHFEKD)
		{
			sprite.color = Color.white;
			if ((Object)(object)pool != (Object)null)
			{
				pool.ReturnToPool(this);
			}
			else
			{
				Object.Destroy((Object)(object)((Component)this).gameObject);
			}
			DBACIMHFEKD = false;
		}
	}

	public IEnumerator JKOFKFMDOEM(SpriteRenderer ECOGJIGAMMA, float BMEBKODLPLF, float OMHCOLMFGNJ)
	{
		return new EKNGJJEDEHN(1)
		{
			_003C_003E4__this = this,
			sr = ECOGJIGAMMA,
			endValue = BMEBKODLPLF,
			duration = OMHCOLMFGNJ
		};
	}

	public IEnumerator GHAKAGDDPDN(SpriteRenderer ECOGJIGAMMA, float BMEBKODLPLF, float OMHCOLMFGNJ)
	{
		return new EKNGJJEDEHN(1)
		{
			_003C_003E4__this = this,
			sr = ECOGJIGAMMA,
			endValue = BMEBKODLPLF,
			duration = OMHCOLMFGNJ
		};
	}

	private void Update()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		if (DBACIMHFEKD)
		{
			sprite.color = Color.white;
			if ((Object)(object)pool != (Object)null)
			{
				pool.ReturnToPool(this);
			}
			else
			{
				Object.Destroy((Object)(object)((Component)this).gameObject);
			}
			DBACIMHFEKD = false;
		}
	}

	private void OnEnable()
	{
		DBACIMHFEKD = false;
		((MonoBehaviour)this).StartCoroutine(SpriteFade(sprite, 0f, durationStep));
	}

	public IEnumerator KEOLFIBCLBE(SpriteRenderer ECOGJIGAMMA, float BMEBKODLPLF, float OMHCOLMFGNJ)
	{
		LGLDPMAABLA = 0f;
		LIALPHCJOOK = ECOGJIGAMMA.color.a;
		while (LGLDPMAABLA < OMHCOLMFGNJ)
		{
			LGLDPMAABLA += Time.deltaTime;
			BMCLDGGAOEI = Mathf.Lerp(LIALPHCJOOK, BMEBKODLPLF, LGLDPMAABLA / OMHCOLMFGNJ);
			ECOGJIGAMMA.color = new Color(ECOGJIGAMMA.color.r, ECOGJIGAMMA.color.g, ECOGJIGAMMA.color.b, BMCLDGGAOEI);
			yield return null;
		}
		DBACIMHFEKD = true;
	}

	private void FPOIFOGELHC()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		if (DBACIMHFEKD)
		{
			sprite.color = Color.white;
			if ((Object)(object)pool != (Object)null)
			{
				pool.DLCIDAFIMPL(this);
			}
			else
			{
				Object.Destroy((Object)(object)((Component)this).gameObject);
			}
			DBACIMHFEKD = false;
		}
	}

	private void LFBIFPBPDMJ()
	{
		DBACIMHFEKD = false;
		((MonoBehaviour)this).StartCoroutine(HCLKCHOLENC(sprite, 611f, durationStep));
	}

	public IEnumerator LCGNCKCDNKB(SpriteRenderer ECOGJIGAMMA, float BMEBKODLPLF, float OMHCOLMFGNJ)
	{
		return new EKNGJJEDEHN(1)
		{
			_003C_003E4__this = this,
			sr = ECOGJIGAMMA,
			endValue = BMEBKODLPLF,
			duration = OMHCOLMFGNJ
		};
	}

	private void KCOFAJBKHAO()
	{
		DBACIMHFEKD = false;
		((MonoBehaviour)this).StartCoroutine(MFOOGOMBAJJ(sprite, 29f, durationStep));
	}

	public IEnumerator HCLKCHOLENC(SpriteRenderer ECOGJIGAMMA, float BMEBKODLPLF, float OMHCOLMFGNJ)
	{
		return new EKNGJJEDEHN(1)
		{
			_003C_003E4__this = this,
			sr = ECOGJIGAMMA,
			endValue = BMEBKODLPLF,
			duration = OMHCOLMFGNJ
		};
	}

	private void OOGMGIPKMAP()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		if (DBACIMHFEKD)
		{
			sprite.color = Color.white;
			if ((Object)(object)pool != (Object)null)
			{
				pool.ReturnToPool(this);
			}
			else
			{
				Object.Destroy((Object)(object)((Component)this).gameObject);
			}
			DBACIMHFEKD = false;
		}
	}

	private void AGFLPEOOEAM()
	{
		DBACIMHFEKD = false;
		((MonoBehaviour)this).StartCoroutine(CBJNHLOEMPJ(sprite, 1987f, durationStep));
	}

	private void CMDHELEDLBP()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		if (DBACIMHFEKD)
		{
			sprite.color = Color.white;
			if ((Object)(object)pool != (Object)null)
			{
				pool.EELMJIBLFNK(this);
			}
			else
			{
				Object.Destroy((Object)(object)((Component)this).gameObject);
			}
			DBACIMHFEKD = false;
		}
	}

	private void KFDMANOLOAB()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		if (DBACIMHFEKD)
		{
			sprite.color = Color.white;
			if ((Object)(object)pool != (Object)null)
			{
				pool.DFOPCCJOGOJ(this);
			}
			else
			{
				Object.Destroy((Object)(object)((Component)this).gameObject);
			}
			DBACIMHFEKD = true;
		}
	}

	private void GNIBPOBGDNC()
	{
		DBACIMHFEKD = true;
		((MonoBehaviour)this).StartCoroutine(JKDKIEHJDFD(sprite, 1133f, durationStep));
	}

	public IEnumerator NDPCNHPGPFP(SpriteRenderer ECOGJIGAMMA, float BMEBKODLPLF, float OMHCOLMFGNJ)
	{
		LGLDPMAABLA = 0f;
		LIALPHCJOOK = ECOGJIGAMMA.color.a;
		while (LGLDPMAABLA < OMHCOLMFGNJ)
		{
			LGLDPMAABLA += Time.deltaTime;
			BMCLDGGAOEI = Mathf.Lerp(LIALPHCJOOK, BMEBKODLPLF, LGLDPMAABLA / OMHCOLMFGNJ);
			ECOGJIGAMMA.color = new Color(ECOGJIGAMMA.color.r, ECOGJIGAMMA.color.g, ECOGJIGAMMA.color.b, BMCLDGGAOEI);
			yield return null;
		}
		DBACIMHFEKD = true;
	}

	private void NBBFLJNPLEA()
	{
		DBACIMHFEKD = true;
		((MonoBehaviour)this).StartCoroutine(SpriteFade(sprite, 1899f, durationStep));
	}

	public IEnumerator BCDENKMGCJG(SpriteRenderer ECOGJIGAMMA, float BMEBKODLPLF, float OMHCOLMFGNJ)
	{
		return new EKNGJJEDEHN(1)
		{
			_003C_003E4__this = this,
			sr = ECOGJIGAMMA,
			endValue = BMEBKODLPLF,
			duration = OMHCOLMFGNJ
		};
	}

	public IEnumerator ALEOMJNLPFE(SpriteRenderer ECOGJIGAMMA, float BMEBKODLPLF, float OMHCOLMFGNJ)
	{
		return new EKNGJJEDEHN(1)
		{
			_003C_003E4__this = this,
			sr = ECOGJIGAMMA,
			endValue = BMEBKODLPLF,
			duration = OMHCOLMFGNJ
		};
	}

	private void HFIHGHBLLAM()
	{
		DBACIMHFEKD = true;
		((MonoBehaviour)this).StartCoroutine(CBJNHLOEMPJ(sprite, 114f, durationStep));
	}

	private void HJKONJICGML()
	{
		DBACIMHFEKD = true;
		((MonoBehaviour)this).StartCoroutine(COCHIAONMAM(sprite, 1436f, durationStep));
	}

	private void JPHFCJIBBMI()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		if (DBACIMHFEKD)
		{
			sprite.color = Color.white;
			if ((Object)(object)pool != (Object)null)
			{
				pool.DLCIDAFIMPL(this);
			}
			else
			{
				Object.Destroy((Object)(object)((Component)this).gameObject);
			}
			DBACIMHFEKD = true;
		}
	}

	public IEnumerator MHBBOADDNHA(SpriteRenderer ECOGJIGAMMA, float BMEBKODLPLF, float OMHCOLMFGNJ)
	{
		LGLDPMAABLA = 0f;
		LIALPHCJOOK = ECOGJIGAMMA.color.a;
		while (LGLDPMAABLA < OMHCOLMFGNJ)
		{
			LGLDPMAABLA += Time.deltaTime;
			BMCLDGGAOEI = Mathf.Lerp(LIALPHCJOOK, BMEBKODLPLF, LGLDPMAABLA / OMHCOLMFGNJ);
			ECOGJIGAMMA.color = new Color(ECOGJIGAMMA.color.r, ECOGJIGAMMA.color.g, ECOGJIGAMMA.color.b, BMCLDGGAOEI);
			yield return null;
		}
		DBACIMHFEKD = true;
	}

	private void EBFJOAEJPGE()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		if (DBACIMHFEKD)
		{
			sprite.color = Color.white;
			if ((Object)(object)pool != (Object)null)
			{
				pool.EELMJIBLFNK(this);
			}
			else
			{
				Object.Destroy((Object)(object)((Component)this).gameObject);
			}
			DBACIMHFEKD = false;
		}
	}

	private void JNDFLHEMOBG()
	{
		DBACIMHFEKD = true;
		((MonoBehaviour)this).StartCoroutine(GHAKAGDDPDN(sprite, 281f, durationStep));
	}

	private void IAJOHONMIBM()
	{
		DBACIMHFEKD = false;
		((MonoBehaviour)this).StartCoroutine(NDPCNHPGPFP(sprite, 612f, durationStep));
	}

	private void MAIMGNMIFKG()
	{
		DBACIMHFEKD = true;
		((MonoBehaviour)this).StartCoroutine(CJPFPCPICCJ(sprite, 1278f, durationStep));
	}

	private void JIBHLLJGGEN()
	{
		DBACIMHFEKD = true;
		((MonoBehaviour)this).StartCoroutine(ALEOMJNLPFE(sprite, 1912f, durationStep));
	}

	public IEnumerator COCHIAONMAM(SpriteRenderer ECOGJIGAMMA, float BMEBKODLPLF, float OMHCOLMFGNJ)
	{
		return new EKNGJJEDEHN(1)
		{
			_003C_003E4__this = this,
			sr = ECOGJIGAMMA,
			endValue = BMEBKODLPLF,
			duration = OMHCOLMFGNJ
		};
	}

	private void CIAIAEJIMCM()
	{
		DBACIMHFEKD = true;
		((MonoBehaviour)this).StartCoroutine(NDPCNHPGPFP(sprite, 138f, durationStep));
	}

	public IEnumerator CBJNHLOEMPJ(SpriteRenderer ECOGJIGAMMA, float BMEBKODLPLF, float OMHCOLMFGNJ)
	{
		return new EKNGJJEDEHN(1)
		{
			_003C_003E4__this = this,
			sr = ECOGJIGAMMA,
			endValue = BMEBKODLPLF,
			duration = OMHCOLMFGNJ
		};
	}

	public IEnumerator JKDKIEHJDFD(SpriteRenderer ECOGJIGAMMA, float BMEBKODLPLF, float OMHCOLMFGNJ)
	{
		LGLDPMAABLA = 0f;
		LIALPHCJOOK = ECOGJIGAMMA.color.a;
		while (LGLDPMAABLA < OMHCOLMFGNJ)
		{
			LGLDPMAABLA += Time.deltaTime;
			BMCLDGGAOEI = Mathf.Lerp(LIALPHCJOOK, BMEBKODLPLF, LGLDPMAABLA / OMHCOLMFGNJ);
			ECOGJIGAMMA.color = new Color(ECOGJIGAMMA.color.r, ECOGJIGAMMA.color.g, ECOGJIGAMMA.color.b, BMCLDGGAOEI);
			yield return null;
		}
		DBACIMHFEKD = true;
	}

	private void PJLKGOACDEN()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		if (DBACIMHFEKD)
		{
			sprite.color = Color.white;
			if ((Object)(object)pool != (Object)null)
			{
				pool.NLELDFHDLFM(this);
			}
			else
			{
				Object.Destroy((Object)(object)((Component)this).gameObject);
			}
			DBACIMHFEKD = false;
		}
	}

	private void OCIHCODJBGC()
	{
		DBACIMHFEKD = false;
		((MonoBehaviour)this).StartCoroutine(JAIJHLIFJNA(sprite, 883f, durationStep));
	}

	private void IJMBEEEGCGF()
	{
		DBACIMHFEKD = false;
		((MonoBehaviour)this).StartCoroutine(JAIJHLIFJNA(sprite, 1778f, durationStep));
	}

	public IEnumerator PJBHHANLLIN(SpriteRenderer ECOGJIGAMMA, float BMEBKODLPLF, float OMHCOLMFGNJ)
	{
		LGLDPMAABLA = 0f;
		LIALPHCJOOK = ECOGJIGAMMA.color.a;
		while (LGLDPMAABLA < OMHCOLMFGNJ)
		{
			LGLDPMAABLA += Time.deltaTime;
			BMCLDGGAOEI = Mathf.Lerp(LIALPHCJOOK, BMEBKODLPLF, LGLDPMAABLA / OMHCOLMFGNJ);
			ECOGJIGAMMA.color = new Color(ECOGJIGAMMA.color.r, ECOGJIGAMMA.color.g, ECOGJIGAMMA.color.b, BMCLDGGAOEI);
			yield return null;
		}
		DBACIMHFEKD = true;
	}

	public IEnumerator NAIDPCLGGAO(SpriteRenderer ECOGJIGAMMA, float BMEBKODLPLF, float OMHCOLMFGNJ)
	{
		LGLDPMAABLA = 0f;
		LIALPHCJOOK = ECOGJIGAMMA.color.a;
		while (LGLDPMAABLA < OMHCOLMFGNJ)
		{
			LGLDPMAABLA += Time.deltaTime;
			BMCLDGGAOEI = Mathf.Lerp(LIALPHCJOOK, BMEBKODLPLF, LGLDPMAABLA / OMHCOLMFGNJ);
			ECOGJIGAMMA.color = new Color(ECOGJIGAMMA.color.r, ECOGJIGAMMA.color.g, ECOGJIGAMMA.color.b, BMCLDGGAOEI);
			yield return null;
		}
		DBACIMHFEKD = true;
	}

	public IEnumerator HEDOONAMKMI(SpriteRenderer ECOGJIGAMMA, float BMEBKODLPLF, float OMHCOLMFGNJ)
	{
		LGLDPMAABLA = 0f;
		LIALPHCJOOK = ECOGJIGAMMA.color.a;
		while (LGLDPMAABLA < OMHCOLMFGNJ)
		{
			LGLDPMAABLA += Time.deltaTime;
			BMCLDGGAOEI = Mathf.Lerp(LIALPHCJOOK, BMEBKODLPLF, LGLDPMAABLA / OMHCOLMFGNJ);
			ECOGJIGAMMA.color = new Color(ECOGJIGAMMA.color.r, ECOGJIGAMMA.color.g, ECOGJIGAMMA.color.b, BMCLDGGAOEI);
			yield return null;
		}
		DBACIMHFEKD = true;
	}

	private void DDLLFPICOJK()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		if (DBACIMHFEKD)
		{
			sprite.color = Color.white;
			if ((Object)(object)pool != (Object)null)
			{
				pool.NLELDFHDLFM(this);
			}
			else
			{
				Object.Destroy((Object)(object)((Component)this).gameObject);
			}
			DBACIMHFEKD = true;
		}
	}

	private void GOJFGHKOFMF()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		if (DBACIMHFEKD)
		{
			sprite.color = Color.white;
			if ((Object)(object)pool != (Object)null)
			{
				pool.DLCIDAFIMPL(this);
			}
			else
			{
				Object.Destroy((Object)(object)((Component)this).gameObject);
			}
			DBACIMHFEKD = false;
		}
	}

	private void MNFMLJJBKNC()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		if (DBACIMHFEKD)
		{
			sprite.color = Color.white;
			if ((Object)(object)pool != (Object)null)
			{
				pool.EELMJIBLFNK(this);
			}
			else
			{
				Object.Destroy((Object)(object)((Component)this).gameObject);
			}
			DBACIMHFEKD = false;
		}
	}

	public IEnumerator JPKFELBLIIH(SpriteRenderer ECOGJIGAMMA, float BMEBKODLPLF, float OMHCOLMFGNJ)
	{
		return new EKNGJJEDEHN(1)
		{
			_003C_003E4__this = this,
			sr = ECOGJIGAMMA,
			endValue = BMEBKODLPLF,
			duration = OMHCOLMFGNJ
		};
	}

	public IEnumerator SpriteFade(SpriteRenderer ECOGJIGAMMA, float BMEBKODLPLF, float OMHCOLMFGNJ)
	{
		LGLDPMAABLA = 0f;
		LIALPHCJOOK = ECOGJIGAMMA.color.a;
		while (LGLDPMAABLA < OMHCOLMFGNJ)
		{
			LGLDPMAABLA += Time.deltaTime;
			BMCLDGGAOEI = Mathf.Lerp(LIALPHCJOOK, BMEBKODLPLF, LGLDPMAABLA / OMHCOLMFGNJ);
			ECOGJIGAMMA.color = new Color(ECOGJIGAMMA.color.r, ECOGJIGAMMA.color.g, ECOGJIGAMMA.color.b, BMCLDGGAOEI);
			yield return null;
		}
		DBACIMHFEKD = true;
	}

	public IEnumerator HNMBALNNLBK(SpriteRenderer ECOGJIGAMMA, float BMEBKODLPLF, float OMHCOLMFGNJ)
	{
		LGLDPMAABLA = 0f;
		LIALPHCJOOK = ECOGJIGAMMA.color.a;
		while (LGLDPMAABLA < OMHCOLMFGNJ)
		{
			LGLDPMAABLA += Time.deltaTime;
			BMCLDGGAOEI = Mathf.Lerp(LIALPHCJOOK, BMEBKODLPLF, LGLDPMAABLA / OMHCOLMFGNJ);
			ECOGJIGAMMA.color = new Color(ECOGJIGAMMA.color.r, ECOGJIGAMMA.color.g, ECOGJIGAMMA.color.b, BMCLDGGAOEI);
			yield return null;
		}
		DBACIMHFEKD = true;
	}

	public IEnumerator JAIJHLIFJNA(SpriteRenderer ECOGJIGAMMA, float BMEBKODLPLF, float OMHCOLMFGNJ)
	{
		return new EKNGJJEDEHN(1)
		{
			_003C_003E4__this = this,
			sr = ECOGJIGAMMA,
			endValue = BMEBKODLPLF,
			duration = OMHCOLMFGNJ
		};
	}

	private void GBAKNAINDJM()
	{
		DBACIMHFEKD = false;
		((MonoBehaviour)this).StartCoroutine(GHAKAGDDPDN(sprite, 836f, durationStep));
	}

	private void LMFICKFGEFI()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		if (DBACIMHFEKD)
		{
			sprite.color = Color.white;
			if ((Object)(object)pool != (Object)null)
			{
				pool.ReturnToPool(this);
			}
			else
			{
				Object.Destroy((Object)(object)((Component)this).gameObject);
			}
			DBACIMHFEKD = false;
		}
	}

	public IEnumerator MFOOGOMBAJJ(SpriteRenderer ECOGJIGAMMA, float BMEBKODLPLF, float OMHCOLMFGNJ)
	{
		return new EKNGJJEDEHN(1)
		{
			_003C_003E4__this = this,
			sr = ECOGJIGAMMA,
			endValue = BMEBKODLPLF,
			duration = OMHCOLMFGNJ
		};
	}

	public IEnumerator FABCEAMBEIP(SpriteRenderer ECOGJIGAMMA, float BMEBKODLPLF, float OMHCOLMFGNJ)
	{
		LGLDPMAABLA = 0f;
		LIALPHCJOOK = ECOGJIGAMMA.color.a;
		while (LGLDPMAABLA < OMHCOLMFGNJ)
		{
			LGLDPMAABLA += Time.deltaTime;
			BMCLDGGAOEI = Mathf.Lerp(LIALPHCJOOK, BMEBKODLPLF, LGLDPMAABLA / OMHCOLMFGNJ);
			ECOGJIGAMMA.color = new Color(ECOGJIGAMMA.color.r, ECOGJIGAMMA.color.g, ECOGJIGAMMA.color.b, BMCLDGGAOEI);
			yield return null;
		}
		DBACIMHFEKD = true;
	}
}
