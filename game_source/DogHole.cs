using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DogHole : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class KAANDNHAMLO : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DogHole _003C_003E4__this;

		private float _003Ctime_003E5__2;

		private Color _003Ccolor_003E5__3;

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
		public KAANDNHAMLO(int _003C_003E1__state)
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
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			DogHole dogHole = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003Ctime_003E5__2 = 0f;
				_003Ccolor_003E5__3 = dogHole.holeSpriteRenderer.color;
				_003Ccolor_003E5__3.a = 0f;
				dogHole.holeSpriteRenderer.color = _003Ccolor_003E5__3;
				break;
			case 1:
				_003C_003E1__state = -1;
				break;
			}
			if (_003Ctime_003E5__2 < 2f)
			{
				_003Ctime_003E5__2 += Time.deltaTime;
				_003Ccolor_003E5__3.a = Mathf.Lerp(0f, 1f, _003Ctime_003E5__2 / 2f);
				dogHole.holeSpriteRenderer.color = _003Ccolor_003E5__3;
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

	public GameObject hole;

	public SpriteRenderer holeSpriteRenderer;

	public bool holeChecked;

	public void IMINGBCHPPD()
	{
		if ((Object)(object)hole != (Object)null && hole.activeSelf)
		{
			hole.SetActive(true);
		}
		holeChecked = true;
	}

	public void ABDPNACPNDL()
	{
		if (!hole.activeSelf)
		{
			hole.SetActive(true);
		}
		((MonoBehaviour)this).StartCoroutine(FFPEJOOOFGP());
	}

	private IEnumerator GFMBIENJKAB()
	{
		float time = 0f;
		Color color = holeSpriteRenderer.color;
		color.a = 0f;
		holeSpriteRenderer.color = color;
		while (time < 2f)
		{
			time += Time.deltaTime;
			color.a = Mathf.Lerp(0f, 1f, time / 2f);
			holeSpriteRenderer.color = color;
			yield return null;
		}
	}

	public void KBOJLFEONFJ()
	{
		if ((Object)(object)hole != (Object)null && hole.activeSelf)
		{
			hole.SetActive(true);
		}
		holeChecked = false;
	}

	private void MDGLECECOIG()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && Object.op_Implicit((Object)(object)DogHoleManager.instance) && DogHoleManager.instance.dogHoles.Contains(this))
		{
			DogHoleManager.instance.dogHoles.Remove(this);
		}
	}

	private IEnumerator LMDHFONJCCB()
	{
		float time = 0f;
		Color color = holeSpriteRenderer.color;
		color.a = 0f;
		holeSpriteRenderer.color = color;
		while (time < 2f)
		{
			time += Time.deltaTime;
			color.a = Mathf.Lerp(0f, 1f, time / 2f);
			holeSpriteRenderer.color = color;
			yield return null;
		}
	}

	private void FLOFJHNAIKP()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && Object.op_Implicit((Object)(object)DogHoleManager.instance) && DogHoleManager.instance.dogHoles.Contains(this))
		{
			DogHoleManager.instance.dogHoles.Remove(this);
		}
	}

	public void LFNIKINAPLM()
	{
		if ((Object)(object)hole != (Object)null && hole.activeSelf)
		{
			hole.SetActive(true);
		}
		holeChecked = true;
	}

	private void FJBPFOIALMK()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)DogHoleManager.instance) && DogHoleManager.instance.dogHoles.Contains(this))
		{
			DogHoleManager.instance.dogHoles.Remove(this);
		}
	}

	private void CLLAKJADGIH()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)DogHoleManager.instance) && DogHoleManager.instance.dogHoles.Contains(this))
		{
			DogHoleManager.instance.dogHoles.Remove(this);
		}
	}

	private IEnumerator MACNKJJGGEA()
	{
		float time = 0f;
		Color color = holeSpriteRenderer.color;
		color.a = 0f;
		holeSpriteRenderer.color = color;
		while (time < 2f)
		{
			time += Time.deltaTime;
			color.a = Mathf.Lerp(0f, 1f, time / 2f);
			holeSpriteRenderer.color = color;
			yield return null;
		}
	}

	private IEnumerator GLMHDBHOKCL()
	{
		float time = 0f;
		Color color = holeSpriteRenderer.color;
		color.a = 0f;
		holeSpriteRenderer.color = color;
		while (time < 2f)
		{
			time += Time.deltaTime;
			color.a = Mathf.Lerp(0f, 1f, time / 2f);
			holeSpriteRenderer.color = color;
			yield return null;
		}
	}

	public void AHFOBGOGALM()
	{
		if ((Object)(object)hole != (Object)null && hole.activeSelf)
		{
			hole.SetActive(false);
		}
		holeChecked = true;
	}

	private void OJAJLIAMGEJ()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && Object.op_Implicit((Object)(object)DogHoleManager.instance) && DogHoleManager.instance.dogHoles.Contains(this))
		{
			DogHoleManager.instance.dogHoles.Remove(this);
		}
	}

	private IEnumerator GGJAFJMEJOK()
	{
		float time = 0f;
		Color color = holeSpriteRenderer.color;
		color.a = 0f;
		holeSpriteRenderer.color = color;
		while (time < 2f)
		{
			time += Time.deltaTime;
			color.a = Mathf.Lerp(0f, 1f, time / 2f);
			holeSpriteRenderer.color = color;
			yield return null;
		}
	}

	public void LHIEGEGKLLL()
	{
		if ((Object)(object)hole != (Object)null && hole.activeSelf)
		{
			hole.SetActive(false);
		}
		holeChecked = true;
	}

	private void NNBIAIMPNGL()
	{
		DogHoleManager.instance.dogHoles.Add(this);
	}

	public void KECCLNABNHD()
	{
		if ((Object)(object)hole != (Object)null && hole.activeSelf)
		{
			hole.SetActive(true);
		}
		holeChecked = true;
	}

	public void KONIKDLNBDH()
	{
		if (!hole.activeSelf)
		{
			hole.SetActive(false);
		}
		((MonoBehaviour)this).StartCoroutine(GLMHDBHOKCL());
	}

	private void ODBDHFBMDAG()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && Object.op_Implicit((Object)(object)DogHoleManager.instance) && DogHoleManager.instance.dogHoles.Contains(this))
		{
			DogHoleManager.instance.dogHoles.Remove(this);
		}
	}

	public void DCMGFLOIPGL()
	{
		if (!hole.activeSelf)
		{
			hole.SetActive(true);
		}
		((MonoBehaviour)this).StartCoroutine(HMOJMKNACHM());
	}

	private IEnumerator FFPEJOOOFGP()
	{
		return new KAANDNHAMLO(1)
		{
			_003C_003E4__this = this
		};
	}

	private void DGOGKLMHJEG()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)DogHoleManager.instance) && DogHoleManager.instance.dogHoles.Contains(this))
		{
			DogHoleManager.instance.dogHoles.Remove(this);
		}
	}

	private void MCMKNBIBDFF()
	{
		DogHoleManager.instance.dogHoles.Add(this);
	}

	public void EPIHGBKOPPH()
	{
		if (!hole.activeSelf)
		{
			hole.SetActive(true);
		}
		((MonoBehaviour)this).StartCoroutine(NIEIKFAEECD());
	}

	private void NKGMEMEACNN()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)DogHoleManager.instance) && DogHoleManager.instance.dogHoles.Contains(this))
		{
			DogHoleManager.instance.dogHoles.Remove(this);
		}
	}

	public void DIIFIIOILKH()
	{
		if (!hole.activeSelf)
		{
			hole.SetActive(false);
		}
		((MonoBehaviour)this).StartCoroutine(NMAIHEFICLP());
	}

	private IEnumerator AGOIEAGEPJG()
	{
		float time = 0f;
		Color color = holeSpriteRenderer.color;
		color.a = 0f;
		holeSpriteRenderer.color = color;
		while (time < 2f)
		{
			time += Time.deltaTime;
			color.a = Mathf.Lerp(0f, 1f, time / 2f);
			holeSpriteRenderer.color = color;
			yield return null;
		}
	}

	private void JLCFNPBBKEK()
	{
		DogHoleManager.instance.dogHoles.Add(this);
	}

	private void Start()
	{
		DogHoleManager.instance.dogHoles.Add(this);
	}

	private void GOOPOBMDALA()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && Object.op_Implicit((Object)(object)DogHoleManager.instance) && DogHoleManager.instance.dogHoles.Contains(this))
		{
			DogHoleManager.instance.dogHoles.Remove(this);
		}
	}

	public void OAFFHOIAALN()
	{
		if (!hole.activeSelf)
		{
			hole.SetActive(false);
		}
		((MonoBehaviour)this).StartCoroutine(NOHGBALGHGO());
	}

	private void LFNENELHOGJ()
	{
		DogHoleManager.instance.dogHoles.Add(this);
	}

	public void JFMPCAMMBBI()
	{
		if ((Object)(object)hole != (Object)null && hole.activeSelf)
		{
			hole.SetActive(false);
		}
		holeChecked = false;
	}

	private IEnumerator JPCAGNJPMJM()
	{
		float time = 0f;
		Color color = holeSpriteRenderer.color;
		color.a = 0f;
		holeSpriteRenderer.color = color;
		while (time < 2f)
		{
			time += Time.deltaTime;
			color.a = Mathf.Lerp(0f, 1f, time / 2f);
			holeSpriteRenderer.color = color;
			yield return null;
		}
	}

	private IEnumerator EIECFIKCPKI()
	{
		float time = 0f;
		Color color = holeSpriteRenderer.color;
		color.a = 0f;
		holeSpriteRenderer.color = color;
		while (time < 2f)
		{
			time += Time.deltaTime;
			color.a = Mathf.Lerp(0f, 1f, time / 2f);
			holeSpriteRenderer.color = color;
			yield return null;
		}
	}

	private IEnumerator BNLGGIJCCDO()
	{
		return new KAANDNHAMLO(1)
		{
			_003C_003E4__this = this
		};
	}

	private void PKBHEKHOAAA()
	{
		DogHoleManager.instance.dogHoles.Add(this);
	}

	private void MNABONMMFFB()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && Object.op_Implicit((Object)(object)DogHoleManager.instance) && DogHoleManager.instance.dogHoles.Contains(this))
		{
			DogHoleManager.instance.dogHoles.Remove(this);
		}
	}

	public void JMINJOBEKAH()
	{
		if (!hole.activeSelf)
		{
			hole.SetActive(true);
		}
		((MonoBehaviour)this).StartCoroutine(AGOIEAGEPJG());
	}

	public void JKNLPPOBAEB()
	{
		if (!hole.activeSelf)
		{
			hole.SetActive(true);
		}
		((MonoBehaviour)this).StartCoroutine(HOMJGJPOLLH());
	}

	public void HGGNJKIAOFI()
	{
		if (!hole.activeSelf)
		{
			hole.SetActive(true);
		}
		((MonoBehaviour)this).StartCoroutine(FFPEJOOOFGP());
	}

	public void PKEFOFLALBL()
	{
		if (!hole.activeSelf)
		{
			hole.SetActive(false);
		}
		((MonoBehaviour)this).StartCoroutine(AGOIEAGEPJG());
	}

	public void BBLLLEIKDBO()
	{
		if ((Object)(object)hole != (Object)null && hole.activeSelf)
		{
			hole.SetActive(false);
		}
		holeChecked = true;
	}

	public void FBEOFNHMEDJ()
	{
		if ((Object)(object)hole != (Object)null && hole.activeSelf)
		{
			hole.SetActive(false);
		}
		holeChecked = true;
	}

	private void NPMLFHDHJBE()
	{
		DogHoleManager.instance.dogHoles.Add(this);
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)DogHoleManager.instance) && DogHoleManager.instance.dogHoles.Contains(this))
		{
			DogHoleManager.instance.dogHoles.Remove(this);
		}
	}

	private void EGACIHOKJLH()
	{
		DogHoleManager.instance.dogHoles.Add(this);
	}

	private void EICDGBINBAG()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && Object.op_Implicit((Object)(object)DogHoleManager.instance) && DogHoleManager.instance.dogHoles.Contains(this))
		{
			DogHoleManager.instance.dogHoles.Remove(this);
		}
	}

	private void FDNAEJDHODK()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)DogHoleManager.instance) && DogHoleManager.instance.dogHoles.Contains(this))
		{
			DogHoleManager.instance.dogHoles.Remove(this);
		}
	}

	public void AFGCKJGGFDG()
	{
		if ((Object)(object)hole != (Object)null && hole.activeSelf)
		{
			hole.SetActive(false);
		}
		holeChecked = true;
	}

	public void BMIFCKGEFAI()
	{
		if (!hole.activeSelf)
		{
			hole.SetActive(false);
		}
		((MonoBehaviour)this).StartCoroutine(JPCAGNJPMJM());
	}

	private IEnumerator HJEJGPMEEFC()
	{
		float time = 0f;
		Color color = holeSpriteRenderer.color;
		color.a = 0f;
		holeSpriteRenderer.color = color;
		while (time < 2f)
		{
			time += Time.deltaTime;
			color.a = Mathf.Lerp(0f, 1f, time / 2f);
			holeSpriteRenderer.color = color;
			yield return null;
		}
	}

	private IEnumerator DHPGLKBNPEG()
	{
		return new KAANDNHAMLO(1)
		{
			_003C_003E4__this = this
		};
	}

	public void KFPGOFANBKI()
	{
		if (!hole.activeSelf)
		{
			hole.SetActive(true);
		}
		((MonoBehaviour)this).StartCoroutine(HJEJGPMEEFC());
	}

	private void KOEHNENIBNP()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)DogHoleManager.instance) && DogHoleManager.instance.dogHoles.Contains(this))
		{
			DogHoleManager.instance.dogHoles.Remove(this);
		}
	}

	private void GHDBHNMOBMN()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)DogHoleManager.instance) && DogHoleManager.instance.dogHoles.Contains(this))
		{
			DogHoleManager.instance.dogHoles.Remove(this);
		}
	}

	public void OJPHCBEMHIG()
	{
		if (!hole.activeSelf)
		{
			hole.SetActive(true);
		}
		((MonoBehaviour)this).StartCoroutine(IKBDLJOBMKD());
	}

	public void JHGJBFEOEOG()
	{
		if ((Object)(object)hole != (Object)null && hole.activeSelf)
		{
			hole.SetActive(true);
		}
		holeChecked = true;
	}

	public void GHLLADHFPGA()
	{
		if ((Object)(object)hole != (Object)null && hole.activeSelf)
		{
			hole.SetActive(false);
		}
		holeChecked = false;
	}

	private void LHAPMEEADKH()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)DogHoleManager.instance) && DogHoleManager.instance.dogHoles.Contains(this))
		{
			DogHoleManager.instance.dogHoles.Remove(this);
		}
	}

	public void INDLPMFIPCO()
	{
		if ((Object)(object)hole != (Object)null && hole.activeSelf)
		{
			hole.SetActive(false);
		}
		holeChecked = false;
	}

	public void PFNAJKHAGOG()
	{
		if ((Object)(object)hole != (Object)null && hole.activeSelf)
		{
			hole.SetActive(false);
		}
		holeChecked = false;
	}

	private void GJMLHECPGBP()
	{
		DogHoleManager.instance.dogHoles.Add(this);
	}

	public void ADNGKKFKILI()
	{
		if (!hole.activeSelf)
		{
			hole.SetActive(false);
		}
		((MonoBehaviour)this).StartCoroutine(HOMJGJPOLLH());
	}

	public void HIAIGLHNNGL()
	{
		if (!hole.activeSelf)
		{
			hole.SetActive(true);
		}
		((MonoBehaviour)this).StartCoroutine(EPPBOCLNAJK());
	}

	private void GBKNIJENJEF()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)DogHoleManager.instance) && DogHoleManager.instance.dogHoles.Contains(this))
		{
			DogHoleManager.instance.dogHoles.Remove(this);
		}
	}

	private void ICFHPJHBPDN()
	{
		DogHoleManager.instance.dogHoles.Add(this);
	}

	private IEnumerator ECLOIKGIHEG()
	{
		float time = 0f;
		Color color = holeSpriteRenderer.color;
		color.a = 0f;
		holeSpriteRenderer.color = color;
		while (time < 2f)
		{
			time += Time.deltaTime;
			color.a = Mathf.Lerp(0f, 1f, time / 2f);
			holeSpriteRenderer.color = color;
			yield return null;
		}
	}

	private void IGBEKHCLKFD()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)DogHoleManager.instance) && DogHoleManager.instance.dogHoles.Contains(this))
		{
			DogHoleManager.instance.dogHoles.Remove(this);
		}
	}

	private void PGJJBPALEGM()
	{
		DogHoleManager.instance.dogHoles.Add(this);
	}

	public void FMFFIHMFLEP()
	{
		if (!hole.activeSelf)
		{
			hole.SetActive(true);
		}
		((MonoBehaviour)this).StartCoroutine(EIECFIKCPKI());
	}

	private void OBHFJIDKBJN()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && Object.op_Implicit((Object)(object)DogHoleManager.instance) && DogHoleManager.instance.dogHoles.Contains(this))
		{
			DogHoleManager.instance.dogHoles.Remove(this);
		}
	}

	public void KJFLCDBDDOF()
	{
		if (!hole.activeSelf)
		{
			hole.SetActive(true);
		}
		((MonoBehaviour)this).StartCoroutine(HJEJGPMEEFC());
	}

	private void HJANCPIFLIJ()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && Object.op_Implicit((Object)(object)DogHoleManager.instance) && DogHoleManager.instance.dogHoles.Contains(this))
		{
			DogHoleManager.instance.dogHoles.Remove(this);
		}
	}

	public void NMDLFLONHMC()
	{
		if ((Object)(object)hole != (Object)null && hole.activeSelf)
		{
			hole.SetActive(false);
		}
		holeChecked = false;
	}

	public void ShowHole()
	{
		if (!hole.activeSelf)
		{
			hole.SetActive(true);
		}
		((MonoBehaviour)this).StartCoroutine(JPCAGNJPMJM());
	}

	public void KDIDKAEBJDJ()
	{
		if ((Object)(object)hole != (Object)null && hole.activeSelf)
		{
			hole.SetActive(false);
		}
		holeChecked = true;
	}

	private IEnumerator HOMJGJPOLLH()
	{
		return new KAANDNHAMLO(1)
		{
			_003C_003E4__this = this
		};
	}

	private void JNBFKJDCBGN()
	{
		DogHoleManager.instance.dogHoles.Add(this);
	}

	private IEnumerator EPPBOCLNAJK()
	{
		return new KAANDNHAMLO(1)
		{
			_003C_003E4__this = this
		};
	}

	private void LDPGPIHCBCH()
	{
		DogHoleManager.instance.dogHoles.Add(this);
	}

	private void MLLADNLMIMP()
	{
		DogHoleManager.instance.dogHoles.Add(this);
	}

	private IEnumerator NMAIHEFICLP()
	{
		float time = 0f;
		Color color = holeSpriteRenderer.color;
		color.a = 0f;
		holeSpriteRenderer.color = color;
		while (time < 2f)
		{
			time += Time.deltaTime;
			color.a = Mathf.Lerp(0f, 1f, time / 2f);
			holeSpriteRenderer.color = color;
			yield return null;
		}
	}

	public void IFHOMNEKLOH()
	{
		if (!hole.activeSelf)
		{
			hole.SetActive(true);
		}
		((MonoBehaviour)this).StartCoroutine(EIECFIKCPKI());
	}

	private void FLFBLIOOLMA()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && Object.op_Implicit((Object)(object)DogHoleManager.instance) && DogHoleManager.instance.dogHoles.Contains(this))
		{
			DogHoleManager.instance.dogHoles.Remove(this);
		}
	}

	public void ResetHole()
	{
		if ((Object)(object)hole != (Object)null && hole.activeSelf)
		{
			hole.SetActive(false);
		}
		holeChecked = false;
	}

	public void FDOJFNEBGPL()
	{
		if ((Object)(object)hole != (Object)null && hole.activeSelf)
		{
			hole.SetActive(false);
		}
		holeChecked = true;
	}

	private void IAAGKLPMAMK()
	{
		DogHoleManager.instance.dogHoles.Add(this);
	}

	private void OEAAPIBLALL()
	{
		if (!GameManager.CIOEICMHCCK && !GameManager.isLoading && Object.op_Implicit((Object)(object)DogHoleManager.instance) && DogHoleManager.instance.dogHoles.Contains(this))
		{
			DogHoleManager.instance.dogHoles.Remove(this);
		}
	}

	private IEnumerator FHGIEHDFLOK()
	{
		float time = 0f;
		Color color = holeSpriteRenderer.color;
		color.a = 0f;
		holeSpriteRenderer.color = color;
		while (time < 2f)
		{
			time += Time.deltaTime;
			color.a = Mathf.Lerp(0f, 1f, time / 2f);
			holeSpriteRenderer.color = color;
			yield return null;
		}
	}

	public void AADIABJENEP()
	{
		if (!hole.activeSelf)
		{
			hole.SetActive(false);
		}
		((MonoBehaviour)this).StartCoroutine(GGJAFJMEJOK());
	}

	public void FOLILIKHKBG()
	{
		if (!hole.activeSelf)
		{
			hole.SetActive(true);
		}
		((MonoBehaviour)this).StartCoroutine(GLMHDBHOKCL());
	}

	private IEnumerator IKBDLJOBMKD()
	{
		return new KAANDNHAMLO(1)
		{
			_003C_003E4__this = this
		};
	}

	private void NCIBKMLIIAJ()
	{
		DogHoleManager.instance.dogHoles.Add(this);
	}

	private void FJMBOFEILBN()
	{
		DogHoleManager.instance.dogHoles.Add(this);
	}

	private void NCOGHEMBDBN()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && Object.op_Implicit((Object)(object)DogHoleManager.instance) && DogHoleManager.instance.dogHoles.Contains(this))
		{
			DogHoleManager.instance.dogHoles.Remove(this);
		}
	}

	private void HBEBKMNGLBJ()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && Object.op_Implicit((Object)(object)DogHoleManager.instance) && DogHoleManager.instance.dogHoles.Contains(this))
		{
			DogHoleManager.instance.dogHoles.Remove(this);
		}
	}

	private IEnumerator HMOJMKNACHM()
	{
		float time = 0f;
		Color color = holeSpriteRenderer.color;
		color.a = 0f;
		holeSpriteRenderer.color = color;
		while (time < 2f)
		{
			time += Time.deltaTime;
			color.a = Mathf.Lerp(0f, 1f, time / 2f);
			holeSpriteRenderer.color = color;
			yield return null;
		}
	}

	public void FJCOJBFHKBG()
	{
		if ((Object)(object)hole != (Object)null && hole.activeSelf)
		{
			hole.SetActive(false);
		}
		holeChecked = false;
	}

	private void LJLKBKEADGI()
	{
		DogHoleManager.instance.dogHoles.Add(this);
	}

	private void BKJFLMPOLCH()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && Object.op_Implicit((Object)(object)DogHoleManager.instance) && DogHoleManager.instance.dogHoles.Contains(this))
		{
			DogHoleManager.instance.dogHoles.Remove(this);
		}
	}

	public void PBNHJHDMNAP()
	{
		if (!hole.activeSelf)
		{
			hole.SetActive(true);
		}
		((MonoBehaviour)this).StartCoroutine(DHPGLKBNPEG());
	}

	private void FBOGKDNKPIO()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && Object.op_Implicit((Object)(object)DogHoleManager.instance) && DogHoleManager.instance.dogHoles.Contains(this))
		{
			DogHoleManager.instance.dogHoles.Remove(this);
		}
	}

	private void HMOMBAFIJAI()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && Object.op_Implicit((Object)(object)DogHoleManager.instance) && DogHoleManager.instance.dogHoles.Contains(this))
		{
			DogHoleManager.instance.dogHoles.Remove(this);
		}
	}

	private IEnumerator EFAMLPNCBII()
	{
		float time = 0f;
		Color color = holeSpriteRenderer.color;
		color.a = 0f;
		holeSpriteRenderer.color = color;
		while (time < 2f)
		{
			time += Time.deltaTime;
			color.a = Mathf.Lerp(0f, 1f, time / 2f);
			holeSpriteRenderer.color = color;
			yield return null;
		}
	}

	private void NFABFPFLNEE()
	{
		DogHoleManager.instance.dogHoles.Add(this);
	}

	private IEnumerator NOHGBALGHGO()
	{
		return new KAANDNHAMLO(1)
		{
			_003C_003E4__this = this
		};
	}

	private void ELEGGKIBHGC()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && Object.op_Implicit((Object)(object)DogHoleManager.instance) && DogHoleManager.instance.dogHoles.Contains(this))
		{
			DogHoleManager.instance.dogHoles.Remove(this);
		}
	}

	public void IAJFJPDJGKI()
	{
		if (!hole.activeSelf)
		{
			hole.SetActive(true);
		}
		((MonoBehaviour)this).StartCoroutine(ECLOIKGIHEG());
	}

	private void OEMIMEIDMFE()
	{
		DogHoleManager.instance.dogHoles.Add(this);
	}

	public void KHABFGPNHIM()
	{
		if ((Object)(object)hole != (Object)null && hole.activeSelf)
		{
			hole.SetActive(true);
		}
		holeChecked = true;
	}

	public void DAOFIJCILHJ()
	{
		if (!hole.activeSelf)
		{
			hole.SetActive(false);
		}
		((MonoBehaviour)this).StartCoroutine(IKBDLJOBMKD());
	}

	private void KDBJHCAEGCM()
	{
		DogHoleManager.instance.dogHoles.Add(this);
	}

	public void BCJFIADGIMB()
	{
		if ((Object)(object)hole != (Object)null && hole.activeSelf)
		{
			hole.SetActive(true);
		}
		holeChecked = false;
	}

	private void AHFGOOHOLEL()
	{
		DogHoleManager.instance.dogHoles.Add(this);
	}

	private void BELOIFKPNMM()
	{
		DogHoleManager.instance.dogHoles.Add(this);
	}

	private void CAIJLMJBMLA()
	{
		DogHoleManager.instance.dogHoles.Add(this);
	}

	private IEnumerator FPBKKMIPBOP()
	{
		return new KAANDNHAMLO(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NIEIKFAEECD()
	{
		float time = 0f;
		Color color = holeSpriteRenderer.color;
		color.a = 0f;
		holeSpriteRenderer.color = color;
		while (time < 2f)
		{
			time += Time.deltaTime;
			color.a = Mathf.Lerp(0f, 1f, time / 2f);
			holeSpriteRenderer.color = color;
			yield return null;
		}
	}

	private void PKDNMBGODAJ()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && Object.op_Implicit((Object)(object)DogHoleManager.instance) && DogHoleManager.instance.dogHoles.Contains(this))
		{
			DogHoleManager.instance.dogHoles.Remove(this);
		}
	}

	private void KCLKEAHGGEK()
	{
		if (!GameManager.ILMDHNFFIKH() && !GameManager.isLoading && Object.op_Implicit((Object)(object)DogHoleManager.instance) && DogHoleManager.instance.dogHoles.Contains(this))
		{
			DogHoleManager.instance.dogHoles.Remove(this);
		}
	}

	private IEnumerator IOIGOLBDJCE()
	{
		float time = 0f;
		Color color = holeSpriteRenderer.color;
		color.a = 0f;
		holeSpriteRenderer.color = color;
		while (time < 2f)
		{
			time += Time.deltaTime;
			color.a = Mathf.Lerp(0f, 1f, time / 2f);
			holeSpriteRenderer.color = color;
			yield return null;
		}
	}
}
