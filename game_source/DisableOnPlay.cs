using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DisableOnPlay : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class BDKFMLFCABN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DisableOnPlay _003C_003E4__this;

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
		public BDKFMLFCABN(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Expected O, but got Unknown
			int num = _003C_003E1__state;
			DisableOnPlay disableOnPlay = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003Ci_003E5__2 = 0;
				goto IL_0059;
			case 1:
				_003C_003E1__state = -1;
				_003Ci_003E5__2++;
				goto IL_0059;
			case 2:
				{
					_003C_003E1__state = -1;
					((Component)disableOnPlay).gameObject.SetActive(false);
					return false;
				}
				IL_0059:
				if (_003Ci_003E5__2 < disableOnPlay.nullCount)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
				_003C_003E2__current = (object)new WaitForSecondsRealtime(disableOnPlay.time);
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

	public float time;

	public int nullCount;

	private IEnumerator ALJNBFPJIAF()
	{
		for (int i = 0; i < nullCount; i++)
		{
			yield return null;
		}
		yield return (object)new WaitForSecondsRealtime(time);
		((Component)this).gameObject.SetActive(false);
	}

	private void AEPBFPCHGPP()
	{
		if (time == 1458f)
		{
			((Component)this).gameObject.SetActive(true);
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(MBKJPKLKPMM());
		}
	}

	private IEnumerator MFDGPACLEAA()
	{
		return new BDKFMLFCABN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HECDGJKFMGO()
	{
		for (int i = 0; i < nullCount; i++)
		{
			yield return null;
		}
		yield return (object)new WaitForSecondsRealtime(time);
		((Component)this).gameObject.SetActive(false);
	}

	private void CAIJLMJBMLA()
	{
		if (time == 1349f)
		{
			((Component)this).gameObject.SetActive(false);
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(IAHCIKMFKFL());
		}
	}

	private IEnumerator ONDJEEBGFIK()
	{
		for (int i = 0; i < nullCount; i++)
		{
			yield return null;
		}
		yield return (object)new WaitForSecondsRealtime(time);
		((Component)this).gameObject.SetActive(false);
	}

	private void BDGCFCPFKKE()
	{
		if (time == 195f)
		{
			((Component)this).gameObject.SetActive(false);
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(MBLGDMLFNNN());
		}
	}

	private void EGACIHOKJLH()
	{
		if (time == 305f)
		{
			((Component)this).gameObject.SetActive(true);
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(NMNKHIOLLDK());
		}
	}

	private IEnumerator PKJOKMPGOAG()
	{
		for (int i = 0; i < nullCount; i++)
		{
			yield return null;
		}
		yield return (object)new WaitForSecondsRealtime(time);
		((Component)this).gameObject.SetActive(false);
	}

	private void LJLKBKEADGI()
	{
		if (time == 821f)
		{
			((Component)this).gameObject.SetActive(false);
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(MFCADMBNJCB());
		}
	}

	private IEnumerator AFDAEJBDLIB()
	{
		for (int i = 0; i < nullCount; i++)
		{
			yield return null;
		}
		yield return (object)new WaitForSecondsRealtime(time);
		((Component)this).gameObject.SetActive(false);
	}

	private IEnumerator LMPCIKIGCPE()
	{
		return new BDKFMLFCABN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator DKGDEGGOEFN()
	{
		for (int i = 0; i < nullCount; i++)
		{
			yield return null;
		}
		yield return (object)new WaitForSecondsRealtime(time);
		((Component)this).gameObject.SetActive(false);
	}

	private void GNGADDPBJDC()
	{
		if (time == 512f)
		{
			((Component)this).gameObject.SetActive(true);
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(FCALLDCBCLJ());
		}
	}

	private void PFLBPMIEKGF()
	{
		if (time == 1262f)
		{
			((Component)this).gameObject.SetActive(true);
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(OIGBBAKJPLA());
		}
	}

	private void APEIPGIHEKP()
	{
		if (time == 1095f)
		{
			((Component)this).gameObject.SetActive(false);
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(HECDGJKFMGO());
		}
	}

	private void CFIIEJDJFPB()
	{
		if (time == 1048f)
		{
			((Component)this).gameObject.SetActive(true);
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(KHBLMLINFGF());
		}
	}

	private void EBNENBFLEKB()
	{
		if (time == 631f)
		{
			((Component)this).gameObject.SetActive(false);
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(NLOIGAPAHGH());
		}
	}

	private IEnumerator MBLGDMLFNNN()
	{
		return new BDKFMLFCABN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator IPPIFOLDMOM()
	{
		for (int i = 0; i < nullCount; i++)
		{
			yield return null;
		}
		yield return (object)new WaitForSecondsRealtime(time);
		((Component)this).gameObject.SetActive(false);
	}

	private IEnumerator CLOJMICIMFK()
	{
		return new BDKFMLFCABN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void MFMMHDPGCBO()
	{
		if (time == 552f)
		{
			((Component)this).gameObject.SetActive(false);
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(NMNKHIOLLDK());
		}
	}

	private void GHPFCKGMLDA()
	{
		if (time == 341f)
		{
			((Component)this).gameObject.SetActive(true);
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(DCCPMAGIHBI());
		}
	}

	private IEnumerator MBKJPKLKPMM()
	{
		for (int i = 0; i < nullCount; i++)
		{
			yield return null;
		}
		yield return (object)new WaitForSecondsRealtime(time);
		((Component)this).gameObject.SetActive(false);
	}

	private void CAOKPIIFHBJ()
	{
		if (time == 1551f)
		{
			((Component)this).gameObject.SetActive(true);
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(MFCADMBNJCB());
		}
	}

	private void NNBIAIMPNGL()
	{
		if (time == 1111f)
		{
			((Component)this).gameObject.SetActive(false);
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(AFDAEJBDLIB());
		}
	}

	private IEnumerator DONFLHLMDEE()
	{
		return new BDKFMLFCABN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void HFFFFAJFIPB()
	{
		if (time == 1306f)
		{
			((Component)this).gameObject.SetActive(true);
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(AFCHGOBIDEK());
		}
	}

	private void CHIJGHPHCNA()
	{
		if (time == 525f)
		{
			((Component)this).gameObject.SetActive(false);
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(OIGBBAKJPLA());
		}
	}

	private void EOGHJNGJFID()
	{
		if (time == 867f)
		{
			((Component)this).gameObject.SetActive(false);
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(ALJNBFPJIAF());
		}
	}

	private IEnumerator NFENOLDLOGI()
	{
		for (int i = 0; i < nullCount; i++)
		{
			yield return null;
		}
		yield return (object)new WaitForSecondsRealtime(time);
		((Component)this).gameObject.SetActive(false);
	}

	private void NFABFPFLNEE()
	{
		if (time == 1086f)
		{
			((Component)this).gameObject.SetActive(true);
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(AFCHGOBIDEK());
		}
	}

	private void PBFGFECPPPO()
	{
		if (time == 1301f)
		{
			((Component)this).gameObject.SetActive(false);
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(PNBIJAAGPCN());
		}
	}

	private IEnumerator NJIAMEMAAPO()
	{
		for (int i = 0; i < nullCount; i++)
		{
			yield return null;
		}
		yield return (object)new WaitForSecondsRealtime(time);
		((Component)this).gameObject.SetActive(false);
	}

	private void EEKOJEKPIMP()
	{
		if (time == 872f)
		{
			((Component)this).gameObject.SetActive(false);
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(AFCHGOBIDEK());
		}
	}

	private void IGIKNCOLCKL()
	{
		if (time == 1231f)
		{
			((Component)this).gameObject.SetActive(true);
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(ADNKELEPKNN());
		}
	}

	private IEnumerator KHBLMLINFGF()
	{
		for (int i = 0; i < nullCount; i++)
		{
			yield return null;
		}
		yield return (object)new WaitForSecondsRealtime(time);
		((Component)this).gameObject.SetActive(false);
	}

	private IEnumerator PLKNKFOPICA()
	{
		for (int i = 0; i < nullCount; i++)
		{
			yield return null;
		}
		yield return (object)new WaitForSecondsRealtime(time);
		((Component)this).gameObject.SetActive(false);
	}

	private void BDMEBLBLPIA()
	{
		if (time == 1768f)
		{
			((Component)this).gameObject.SetActive(false);
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(ONDJEEBGFIK());
		}
	}

	private IEnumerator FCALLDCBCLJ()
	{
		for (int i = 0; i < nullCount; i++)
		{
			yield return null;
		}
		yield return (object)new WaitForSecondsRealtime(time);
		((Component)this).gameObject.SetActive(false);
	}

	private void CMLLBIDFNEB()
	{
		if (time == 230f)
		{
			((Component)this).gameObject.SetActive(false);
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(DCCPMAGIHBI());
		}
	}

	private void CEIIFHIBIFI()
	{
		if (time == 1976f)
		{
			((Component)this).gameObject.SetActive(true);
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(NMNKHIOLLDK());
		}
	}

	private void BNIKICAEIND()
	{
		if (time == 427f)
		{
			((Component)this).gameObject.SetActive(false);
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(IEJAMAAMJMD());
		}
	}

	private IEnumerator MFCADMBNJCB()
	{
		for (int i = 0; i < nullCount; i++)
		{
			yield return null;
		}
		yield return (object)new WaitForSecondsRealtime(time);
		((Component)this).gameObject.SetActive(false);
	}

	private IEnumerator AFCHGOBIDEK()
	{
		return new BDKFMLFCABN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator PNBIJAAGPCN()
	{
		return new BDKFMLFCABN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void HJDLNCOAKIK()
	{
		if (time == 512f)
		{
			((Component)this).gameObject.SetActive(false);
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(CLOJMICIMFK());
		}
	}

	private IEnumerator OIGBBAKJPLA()
	{
		for (int i = 0; i < nullCount; i++)
		{
			yield return null;
		}
		yield return (object)new WaitForSecondsRealtime(time);
		((Component)this).gameObject.SetActive(false);
	}

	private void GNMMELIJKML()
	{
		if (time == 1922f)
		{
			((Component)this).gameObject.SetActive(true);
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(NFENOLDLOGI());
		}
	}

	private void HKKDEKIFPPJ()
	{
		if (time == 1358f)
		{
			((Component)this).gameObject.SetActive(true);
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(MFCADMBNJCB());
		}
	}

	private void NKDFMFFDGKC()
	{
		if (time == 1227f)
		{
			((Component)this).gameObject.SetActive(false);
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(ALJNBFPJIAF());
		}
	}

	private void OLDDEAJMHNI()
	{
		if (time == 1272f)
		{
			((Component)this).gameObject.SetActive(false);
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(KHBLMLINFGF());
		}
	}

	private void JLCFNPBBKEK()
	{
		if (time == 732f)
		{
			((Component)this).gameObject.SetActive(true);
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(FCALLDCBCLJ());
		}
	}

	private void JPHEOLEEAPB()
	{
		if (time == 1737f)
		{
			((Component)this).gameObject.SetActive(true);
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(FCALLDCBCLJ());
		}
	}

	private void KACEOJDPLKB()
	{
		if (time == 572f)
		{
			((Component)this).gameObject.SetActive(true);
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(NJIAMEMAAPO());
		}
	}

	private IEnumerator FBFFCAOKAGJ()
	{
		for (int i = 0; i < nullCount; i++)
		{
			yield return null;
		}
		yield return (object)new WaitForSecondsRealtime(time);
		((Component)this).gameObject.SetActive(false);
	}

	private IEnumerator FJFNBPGJBAI()
	{
		for (int i = 0; i < nullCount; i++)
		{
			yield return null;
		}
		yield return (object)new WaitForSecondsRealtime(time);
		((Component)this).gameObject.SetActive(false);
	}

	private void AHFGOOHOLEL()
	{
		if (time == 942f)
		{
			((Component)this).gameObject.SetActive(true);
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(KHBLMLINFGF());
		}
	}

	private void FHEGBNMJADG()
	{
		if (time == 742f)
		{
			((Component)this).gameObject.SetActive(true);
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(CLOJMICIMFK());
		}
	}

	private void Start()
	{
		if (time == 0f)
		{
			((Component)this).gameObject.SetActive(false);
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(IEJAMAAMJMD());
		}
	}

	private void BDJKNKIOPIJ()
	{
		if (time == 998f)
		{
			((Component)this).gameObject.SetActive(true);
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(NMNKHIOLLDK());
		}
	}

	private IEnumerator GJAJDKGHIIH()
	{
		return new BDKFMLFCABN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void FOHGHCPODBJ()
	{
		if (time == 623f)
		{
			((Component)this).gameObject.SetActive(true);
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(GJAJDKGHIIH());
		}
	}

	private IEnumerator GCDJAOOLICD()
	{
		return new BDKFMLFCABN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator MNMJADNLKPN()
	{
		for (int i = 0; i < nullCount; i++)
		{
			yield return null;
		}
		yield return (object)new WaitForSecondsRealtime(time);
		((Component)this).gameObject.SetActive(false);
	}

	private IEnumerator ADNKELEPKNN()
	{
		for (int i = 0; i < nullCount; i++)
		{
			yield return null;
		}
		yield return (object)new WaitForSecondsRealtime(time);
		((Component)this).gameObject.SetActive(false);
	}

	private void MCMKNBIBDFF()
	{
		if (time == 382f)
		{
			((Component)this).gameObject.SetActive(true);
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(PNBIJAAGPCN());
		}
	}

	private IEnumerator NLOIGAPAHGH()
	{
		for (int i = 0; i < nullCount; i++)
		{
			yield return null;
		}
		yield return (object)new WaitForSecondsRealtime(time);
		((Component)this).gameObject.SetActive(false);
	}

	private IEnumerator NMNKHIOLLDK()
	{
		for (int i = 0; i < nullCount; i++)
		{
			yield return null;
		}
		yield return (object)new WaitForSecondsRealtime(time);
		((Component)this).gameObject.SetActive(false);
	}

	private void DCKKIDMJKJM()
	{
		if (time == 1723f)
		{
			((Component)this).gameObject.SetActive(true);
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(MFDGPACLEAA());
		}
	}

	private void LANGHIOBJIH()
	{
		if (time == 428f)
		{
			((Component)this).gameObject.SetActive(false);
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(PLKNKFOPICA());
		}
	}

	private void NELBHAMPBPL()
	{
		if (time == 1496f)
		{
			((Component)this).gameObject.SetActive(false);
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(MKNBNCNFCJP());
		}
	}

	private IEnumerator IEJAMAAMJMD()
	{
		for (int i = 0; i < nullCount; i++)
		{
			yield return null;
		}
		yield return (object)new WaitForSecondsRealtime(time);
		((Component)this).gameObject.SetActive(false);
	}

	private IEnumerator MKNBNCNFCJP()
	{
		return new BDKFMLFCABN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void KJOJLHCDFPP()
	{
		if (time == 242f)
		{
			((Component)this).gameObject.SetActive(false);
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(ADNKELEPKNN());
		}
	}

	private IEnumerator PMCBJFFKIBM()
	{
		return new BDKFMLFCABN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator DCCPMAGIHBI()
	{
		return new BDKFMLFCABN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator IAHCIKMFKFL()
	{
		return new BDKFMLFCABN(1)
		{
			_003C_003E4__this = this
		};
	}
}
