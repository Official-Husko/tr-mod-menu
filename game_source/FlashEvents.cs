using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class FlashEvents : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class LDCDNAAJHLE : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FlashEvents _003C_003E4__this;

		private Color _003Ccolor_003E5__2;

		private float _003CstartAlpha_003E5__3;

		private float _003Ctime_003E5__4;

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
		public LDCDNAAJHLE(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			FlashEvents flashEvents = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003Ccolor_003E5__2 = ((Graphic)flashEvents.flashImage).color;
				_003CstartAlpha_003E5__3 = _003Ccolor_003E5__2.a;
				_003Ctime_003E5__4 = 0f;
				break;
			case 1:
				_003C_003E1__state = -1;
				break;
			}
			if (_003Ctime_003E5__4 < flashEvents.duration)
			{
				_003Ctime_003E5__4 += Time.deltaTime;
				_003Ccolor_003E5__2.a = Mathf.Lerp(_003CstartAlpha_003E5__3, 0f, _003Ctime_003E5__4 / flashEvents.duration);
				((Graphic)flashEvents.flashImage).color = _003Ccolor_003E5__2;
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			}
			_003Ccolor_003E5__2.a = 0f;
			((Graphic)flashEvents.flashImage).color = _003Ccolor_003E5__2;
			flashEvents.flash.SetActive(false);
			_003Ccolor_003E5__2.a = 1f;
			((Graphic)flashEvents.flashImage).color = _003Ccolor_003E5__2;
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

	public static FlashEvents instance;

	public GameObject flash;

	public Image flashImage;

	public float duration = 0.2f;

	private float AFLCFJCMMBC;

	private float ABOMBEFIHFE;

	private float FPMOCOGHOHM;

	private IEnumerator CJAOBPJHIBJ()
	{
		return new LDCDNAAJHLE(1)
		{
			_003C_003E4__this = this
		};
	}

	public void FFFJAKEEFLH()
	{
		((MonoBehaviour)this).StartCoroutine(EPFKCJDPLIE());
	}

	public void MCIIIGFEDMK()
	{
		((MonoBehaviour)this).StartCoroutine(LJHONFMFAFP());
	}

	private IEnumerator BLAJHGIFLDL()
	{
		Color color = ((Graphic)flashImage).color;
		float startAlpha = color.a;
		float time = 0f;
		while (time < duration)
		{
			time += Time.deltaTime;
			color.a = Mathf.Lerp(startAlpha, 0f, time / duration);
			((Graphic)flashImage).color = color;
			yield return null;
		}
		color.a = 0f;
		((Graphic)flashImage).color = color;
		flash.SetActive(false);
		color.a = 1f;
		((Graphic)flashImage).color = color;
	}

	private IEnumerator LJHONFMFAFP()
	{
		return new LDCDNAAJHLE(1)
		{
			_003C_003E4__this = this
		};
	}

	private void CMLLBIDFNEB()
	{
		instance = this;
	}

	public void PHKFDHANJKD()
	{
		flash.SetActive(false);
	}

	private void EOGHJNGJFID()
	{
		instance = this;
	}

	public void DACAGKJMAND()
	{
		flash.SetActive(false);
	}

	private IEnumerator EPFKCJDPLIE()
	{
		return new LDCDNAAJHLE(1)
		{
			_003C_003E4__this = this
		};
	}

	public void PEMBJCNLAJE()
	{
		flash.SetActive(true);
	}

	public void GCNDHNPMLPL()
	{
		((MonoBehaviour)this).StartCoroutine(EJAKAIPLGCL());
	}

	public void ANIMBEOEFDE()
	{
		flash.SetActive(false);
	}

	public void HIDNDBBIEAE()
	{
		flash.SetActive(true);
	}

	private void EGACIHOKJLH()
	{
		instance = this;
	}

	private void GNMMELIJKML()
	{
		instance = this;
	}

	private void CFHOODNCOLK()
	{
		instance = this;
	}

	private void CHIJGHPHCNA()
	{
		instance = this;
	}

	public void OAJMCEGPGBI()
	{
		flash.SetActive(false);
	}

	public void FEOMHPGLNIL()
	{
		((MonoBehaviour)this).StartCoroutine(EJAKAIPLGCL());
	}

	private void KACEOJDPLKB()
	{
		instance = this;
	}

	public void EJMFHJOGJMN()
	{
		flash.SetActive(false);
	}

	private void BDJKNKIOPIJ()
	{
		instance = this;
	}

	public void KDOKENMNAFO()
	{
		flash.SetActive(false);
	}

	private IEnumerator FGLLKAKBKJA()
	{
		return new LDCDNAAJHLE(1)
		{
			_003C_003E4__this = this
		};
	}

	public void PCIALEOMIOE()
	{
		flash.SetActive(false);
	}

	private IEnumerator HAOOPGNJCMN()
	{
		Color color = ((Graphic)flashImage).color;
		float startAlpha = color.a;
		float time = 0f;
		while (time < duration)
		{
			time += Time.deltaTime;
			color.a = Mathf.Lerp(startAlpha, 0f, time / duration);
			((Graphic)flashImage).color = color;
			yield return null;
		}
		color.a = 0f;
		((Graphic)flashImage).color = color;
		flash.SetActive(false);
		color.a = 1f;
		((Graphic)flashImage).color = color;
	}

	public void NNJMLLNJLFO()
	{
		flash.SetActive(true);
	}

	public void DCBKEMLNMPO()
	{
		((MonoBehaviour)this).StartCoroutine(BLAJHGIFLDL());
	}

	private void OKAPGNGLOHO()
	{
		instance = this;
	}

	public void MGHLCABPIFF()
	{
		flash.SetActive(false);
	}

	private IEnumerator IBKKOGDIJMG()
	{
		Color color = ((Graphic)flashImage).color;
		float startAlpha = color.a;
		float time = 0f;
		while (time < duration)
		{
			time += Time.deltaTime;
			color.a = Mathf.Lerp(startAlpha, 0f, time / duration);
			((Graphic)flashImage).color = color;
			yield return null;
		}
		color.a = 0f;
		((Graphic)flashImage).color = color;
		flash.SetActive(false);
		color.a = 1f;
		((Graphic)flashImage).color = color;
	}

	public void HLNBBJJJDMM()
	{
		((MonoBehaviour)this).StartCoroutine(NPCKJKPIFHI());
	}

	public void AGMIDNMEGGE()
	{
		flash.SetActive(false);
	}

	private void NFABFPFLNEE()
	{
		instance = this;
	}

	private IEnumerator LJCLFDGGNHG()
	{
		Color color = ((Graphic)flashImage).color;
		float startAlpha = color.a;
		float time = 0f;
		while (time < duration)
		{
			time += Time.deltaTime;
			color.a = Mathf.Lerp(startAlpha, 0f, time / duration);
			((Graphic)flashImage).color = color;
			yield return null;
		}
		color.a = 0f;
		((Graphic)flashImage).color = color;
		flash.SetActive(false);
		color.a = 1f;
		((Graphic)flashImage).color = color;
	}

	public void ALHBAHOGMPP()
	{
		((MonoBehaviour)this).StartCoroutine(DNMKOFDODAL());
	}

	public void NJNCPNOCILF()
	{
		((MonoBehaviour)this).StartCoroutine(PIOADJEJCIM());
	}

	private void ICFHPJHBPDN()
	{
		instance = this;
	}

	public void HAPOKHCMOBN()
	{
		((MonoBehaviour)this).StartCoroutine(FGLLKAKBKJA());
	}

	public void LCCDCNCADGH()
	{
		flash.SetActive(true);
	}

	public void OEHFAHOCJEH()
	{
		((MonoBehaviour)this).StartCoroutine(EPFKCJDPLIE());
	}

	private void EBNENBFLEKB()
	{
		instance = this;
	}

	public void NFDENJINBLH()
	{
		((MonoBehaviour)this).StartCoroutine(EJAKAIPLGCL());
	}

	private IEnumerator EOABFLPDJGF()
	{
		Color color = ((Graphic)flashImage).color;
		float startAlpha = color.a;
		float time = 0f;
		while (time < duration)
		{
			time += Time.deltaTime;
			color.a = Mathf.Lerp(startAlpha, 0f, time / duration);
			((Graphic)flashImage).color = color;
			yield return null;
		}
		color.a = 0f;
		((Graphic)flashImage).color = color;
		flash.SetActive(false);
		color.a = 1f;
		((Graphic)flashImage).color = color;
	}

	private void HFFFFAJFIPB()
	{
		instance = this;
	}

	public void LMLLABBOLCK()
	{
		((MonoBehaviour)this).StartCoroutine(DNMKOFDODAL());
	}

	private IEnumerator FNPLMAOOEGB()
	{
		Color color = ((Graphic)flashImage).color;
		float startAlpha = color.a;
		float time = 0f;
		while (time < duration)
		{
			time += Time.deltaTime;
			color.a = Mathf.Lerp(startAlpha, 0f, time / duration);
			((Graphic)flashImage).color = color;
			yield return null;
		}
		color.a = 0f;
		((Graphic)flashImage).color = color;
		flash.SetActive(false);
		color.a = 1f;
		((Graphic)flashImage).color = color;
	}

	private void IDPHKHGHJGN()
	{
		instance = this;
	}

	private void IAIDKPJKLIC()
	{
		instance = this;
	}

	public void IOOKGJMIGJF()
	{
		((MonoBehaviour)this).StartCoroutine(BLAJHGIFLDL());
	}

	private void MLLADNLMIMP()
	{
		instance = this;
	}

	private IEnumerator GKPCAELFLKN()
	{
		Color color = ((Graphic)flashImage).color;
		float startAlpha = color.a;
		float time = 0f;
		while (time < duration)
		{
			time += Time.deltaTime;
			color.a = Mathf.Lerp(startAlpha, 0f, time / duration);
			((Graphic)flashImage).color = color;
			yield return null;
		}
		color.a = 0f;
		((Graphic)flashImage).color = color;
		flash.SetActive(false);
		color.a = 1f;
		((Graphic)flashImage).color = color;
	}

	public void NHEGLIJGHJD()
	{
		((MonoBehaviour)this).StartCoroutine(HAOOPGNJCMN());
	}

	public void BNFJCOLLMNN()
	{
		((MonoBehaviour)this).StartCoroutine(EPFKCJDPLIE());
	}

	private IEnumerator NPCKJKPIFHI()
	{
		Color color = ((Graphic)flashImage).color;
		float startAlpha = color.a;
		float time = 0f;
		while (time < duration)
		{
			time += Time.deltaTime;
			color.a = Mathf.Lerp(startAlpha, 0f, time / duration);
			((Graphic)flashImage).color = color;
			yield return null;
		}
		color.a = 0f;
		((Graphic)flashImage).color = color;
		flash.SetActive(false);
		color.a = 1f;
		((Graphic)flashImage).color = color;
	}

	private void NELBHAMPBPL()
	{
		instance = this;
	}

	private void PFLBPMIEKGF()
	{
		instance = this;
	}

	private void MFMMHDPGCBO()
	{
		instance = this;
	}

	public void DFCKIANNGNG()
	{
		((MonoBehaviour)this).StartCoroutine(HAOOPGNJCMN());
	}

	private IEnumerator DAFCLKANDOE()
	{
		return new LDCDNAAJHLE(1)
		{
			_003C_003E4__this = this
		};
	}

	public void OLFINLLMGJK()
	{
		flash.SetActive(true);
	}

	public void BMHECGNOGPM()
	{
		((MonoBehaviour)this).StartCoroutine(LJCLFDGGNHG());
	}

	public void MMHFEDHDLLM()
	{
		flash.SetActive(true);
	}

	private IEnumerator DNMKOFDODAL()
	{
		return new LDCDNAAJHLE(1)
		{
			_003C_003E4__this = this
		};
	}

	public void NJKFNBPJDDG()
	{
		flash.SetActive(true);
	}

	private IEnumerator MFMHNKKFODF()
	{
		Color color = ((Graphic)flashImage).color;
		float startAlpha = color.a;
		float time = 0f;
		while (time < duration)
		{
			time += Time.deltaTime;
			color.a = Mathf.Lerp(startAlpha, 0f, time / duration);
			((Graphic)flashImage).color = color;
			yield return null;
		}
		color.a = 0f;
		((Graphic)flashImage).color = color;
		flash.SetActive(false);
		color.a = 1f;
		((Graphic)flashImage).color = color;
	}

	private IEnumerator EJAKAIPLGCL()
	{
		Color color = ((Graphic)flashImage).color;
		float startAlpha = color.a;
		float time = 0f;
		while (time < duration)
		{
			time += Time.deltaTime;
			color.a = Mathf.Lerp(startAlpha, 0f, time / duration);
			((Graphic)flashImage).color = color;
			yield return null;
		}
		color.a = 0f;
		((Graphic)flashImage).color = color;
		flash.SetActive(false);
		color.a = 1f;
		((Graphic)flashImage).color = color;
	}

	private IEnumerator KMCADPCONHG()
	{
		return new LDCDNAAJHLE(1)
		{
			_003C_003E4__this = this
		};
	}

	public void ANIJGDKAFIL()
	{
		((MonoBehaviour)this).StartCoroutine(IBKKOGDIJMG());
	}

	public void ActivateCanvas()
	{
		flash.SetActive(true);
	}

	private void BNIKICAEIND()
	{
		instance = this;
	}

	public void DDBGPCNJJBE()
	{
		flash.SetActive(true);
	}

	public void FadeOut()
	{
		((MonoBehaviour)this).StartCoroutine(GKPCAELFLKN());
	}

	private void KDBJHCAEGCM()
	{
		instance = this;
	}

	private IEnumerator PIOADJEJCIM()
	{
		Color color = ((Graphic)flashImage).color;
		float startAlpha = color.a;
		float time = 0f;
		while (time < duration)
		{
			time += Time.deltaTime;
			color.a = Mathf.Lerp(startAlpha, 0f, time / duration);
			((Graphic)flashImage).color = color;
			yield return null;
		}
		color.a = 0f;
		((Graphic)flashImage).color = color;
		flash.SetActive(false);
		color.a = 1f;
		((Graphic)flashImage).color = color;
	}

	private void IMIONHLAKIH()
	{
		instance = this;
	}

	private IEnumerator LGIGMMNCNLO()
	{
		Color color = ((Graphic)flashImage).color;
		float startAlpha = color.a;
		float time = 0f;
		while (time < duration)
		{
			time += Time.deltaTime;
			color.a = Mathf.Lerp(startAlpha, 0f, time / duration);
			((Graphic)flashImage).color = color;
			yield return null;
		}
		color.a = 0f;
		((Graphic)flashImage).color = color;
		flash.SetActive(false);
		color.a = 1f;
		((Graphic)flashImage).color = color;
	}

	public void LAAOHDFKMMM()
	{
		((MonoBehaviour)this).StartCoroutine(DAFCLKANDOE());
	}

	public void KKGKGNNPEBD()
	{
		((MonoBehaviour)this).StartCoroutine(LJCLFDGGNHG());
	}

	public void GPBOEBGJJPM()
	{
		((MonoBehaviour)this).StartCoroutine(IBKKOGDIJMG());
	}

	private void Start()
	{
		instance = this;
	}
}
