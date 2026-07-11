using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class InfoText : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class GEFNHENNKAA : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public InfoText _003C_003E4__this;

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
		public GEFNHENNKAA(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Expected O, but got Unknown
			int num = _003C_003E1__state;
			InfoText infoText = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
			{
				_003C_003E1__state = -1;
				AnimatorStateInfo currentAnimatorStateInfo = ((Component)infoText).GetComponent<Animator>().GetCurrentAnimatorStateInfo(0);
				_003C_003E2__current = (object)new WaitForSecondsRealtime(((AnimatorStateInfo)(ref currentAnimatorStateInfo)).length * infoText.durationMultiplier);
				_003C_003E1__state = 1;
				return true;
			}
			case 1:
				_003C_003E1__state = -1;
				Utils.BLPDAEHPOBA(((Component)infoText).gameObject);
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

	public TextMeshProUGUI textBox;

	public TextMeshProUGUI backgroundTextBox;

	public float durationMultiplier = 1f;

	private void LANGHIOBJIH()
	{
		((MonoBehaviour)this).StartCoroutine(DKIJONBKHBG());
	}

	private void HNEGFBCKIIJ()
	{
		((MonoBehaviour)this).StartCoroutine(EIHIJGDBEDG());
	}

	private void HJDLNCOAKIK()
	{
		((MonoBehaviour)this).StartCoroutine(FCJOIBOOKEN());
	}

	private IEnumerator OBLDIJJGNCJ()
	{
		return new GEFNHENNKAA(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator GDNGFFFKMBM()
	{
		AnimatorStateInfo currentAnimatorStateInfo = ((Component)this).GetComponent<Animator>().GetCurrentAnimatorStateInfo(0);
		yield return (object)new WaitForSecondsRealtime(((AnimatorStateInfo)(ref currentAnimatorStateInfo)).length * durationMultiplier);
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	private IEnumerator AOAKMBLLDIE()
	{
		AnimatorStateInfo currentAnimatorStateInfo = ((Component)this).GetComponent<Animator>().GetCurrentAnimatorStateInfo(0);
		yield return (object)new WaitForSecondsRealtime(((AnimatorStateInfo)(ref currentAnimatorStateInfo)).length * durationMultiplier);
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	private void GJMLHECPGBP()
	{
		((MonoBehaviour)this).StartCoroutine(ELKCJCLOMEB());
	}

	private IEnumerator GPCIKNFINKF()
	{
		AnimatorStateInfo currentAnimatorStateInfo = ((Component)this).GetComponent<Animator>().GetCurrentAnimatorStateInfo(0);
		yield return (object)new WaitForSecondsRealtime(((AnimatorStateInfo)(ref currentAnimatorStateInfo)).length * durationMultiplier);
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	private IEnumerator IMBGNMDHOLN()
	{
		return new GEFNHENNKAA(1)
		{
			_003C_003E4__this = this
		};
	}

	private void HPIMHEMJMAA()
	{
		((MonoBehaviour)this).StartCoroutine(LBOBKNNLEDG());
	}

	private void JPOLFKMLHNH()
	{
		((MonoBehaviour)this).StartCoroutine(ONFIOIIMMCD());
	}

	private void IFHLGOMBACP()
	{
		((MonoBehaviour)this).StartCoroutine(FDIDLGKGLEH());
	}

	private void KACEOJDPLKB()
	{
		((MonoBehaviour)this).StartCoroutine(MLBFDKEDBCC());
	}

	private void JPHEOLEEAPB()
	{
		((MonoBehaviour)this).StartCoroutine(AJHDCJADDHB());
	}

	private void FOHGHCPODBJ()
	{
		((MonoBehaviour)this).StartCoroutine(GPCIKNFINKF());
	}

	private void OKAPGNGLOHO()
	{
		((MonoBehaviour)this).StartCoroutine(FCJOIBOOKEN());
	}

	private void CHIJGHPHCNA()
	{
		((MonoBehaviour)this).StartCoroutine(ONFIOIIMMCD());
	}

	private void MCMKNBIBDFF()
	{
		((MonoBehaviour)this).StartCoroutine(FCJOIBOOKEN());
	}

	private IEnumerator GMNPPEKHOPL()
	{
		return new GEFNHENNKAA(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator FDIDLGKGLEH()
	{
		AnimatorStateInfo currentAnimatorStateInfo = ((Component)this).GetComponent<Animator>().GetCurrentAnimatorStateInfo(0);
		yield return (object)new WaitForSecondsRealtime(((AnimatorStateInfo)(ref currentAnimatorStateInfo)).length * durationMultiplier);
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	private IEnumerator AJHDCJADDHB()
	{
		AnimatorStateInfo currentAnimatorStateInfo = ((Component)this).GetComponent<Animator>().GetCurrentAnimatorStateInfo(0);
		yield return (object)new WaitForSecondsRealtime(((AnimatorStateInfo)(ref currentAnimatorStateInfo)).length * durationMultiplier);
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	private void JHBBABPAJJC()
	{
		((MonoBehaviour)this).StartCoroutine(OLDHCICEGEF());
	}

	private IEnumerator ONFIOIIMMCD()
	{
		return new GEFNHENNKAA(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator ELKCJCLOMEB()
	{
		AnimatorStateInfo currentAnimatorStateInfo = ((Component)this).GetComponent<Animator>().GetCurrentAnimatorStateInfo(0);
		yield return (object)new WaitForSecondsRealtime(((AnimatorStateInfo)(ref currentAnimatorStateInfo)).length * durationMultiplier);
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	private void EBNENBFLEKB()
	{
		((MonoBehaviour)this).StartCoroutine(FDIDLGKGLEH());
	}

	private void OLDDEAJMHNI()
	{
		((MonoBehaviour)this).StartCoroutine(GDNGFFFKMBM());
	}

	private void HCEDMLJNOBL()
	{
		((MonoBehaviour)this).StartCoroutine(LBOBKNNLEDG());
	}

	private void HBMDEHPHAPF()
	{
		((MonoBehaviour)this).StartCoroutine(GJLAIAMFKIB());
	}

	private IEnumerator OLDHCICEGEF()
	{
		return new GEFNHENNKAA(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator GJLAIAMFKIB()
	{
		AnimatorStateInfo currentAnimatorStateInfo = ((Component)this).GetComponent<Animator>().GetCurrentAnimatorStateInfo(0);
		yield return (object)new WaitForSecondsRealtime(((AnimatorStateInfo)(ref currentAnimatorStateInfo)).length * durationMultiplier);
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	private IEnumerator EIHIJGDBEDG()
	{
		return new GEFNHENNKAA(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator CCDOKEPKMHH()
	{
		AnimatorStateInfo currentAnimatorStateInfo = ((Component)this).GetComponent<Animator>().GetCurrentAnimatorStateInfo(0);
		yield return (object)new WaitForSecondsRealtime(((AnimatorStateInfo)(ref currentAnimatorStateInfo)).length * durationMultiplier);
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	private void LJLKBKEADGI()
	{
		((MonoBehaviour)this).StartCoroutine(OBLDIJJGNCJ());
	}

	private IEnumerator MKDMHKFLHBE()
	{
		return new GEFNHENNKAA(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LBOBKNNLEDG()
	{
		return new GEFNHENNKAA(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LFDCFLNICEB()
	{
		return new GEFNHENNKAA(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator FCJOIBOOKEN()
	{
		AnimatorStateInfo currentAnimatorStateInfo = ((Component)this).GetComponent<Animator>().GetCurrentAnimatorStateInfo(0);
		yield return (object)new WaitForSecondsRealtime(((AnimatorStateInfo)(ref currentAnimatorStateInfo)).length * durationMultiplier);
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	private void GHPFCKGMLDA()
	{
		((MonoBehaviour)this).StartCoroutine(MKDMHKFLHBE());
	}

	private void IAAGKLPMAMK()
	{
		((MonoBehaviour)this).StartCoroutine(FCJOIBOOKEN());
	}

	private IEnumerator ANGMIBBHMKP()
	{
		return new GEFNHENNKAA(1)
		{
			_003C_003E4__this = this
		};
	}

	private void IDPHKHGHJGN()
	{
		((MonoBehaviour)this).StartCoroutine(FDIDLGKGLEH());
	}

	private void Start()
	{
		((MonoBehaviour)this).StartCoroutine(AOAKMBLLDIE());
	}

	private void KJOJLHCDFPP()
	{
		((MonoBehaviour)this).StartCoroutine(GMNPPEKHOPL());
	}

	private IEnumerator LFDIOFBPEOL()
	{
		return new GEFNHENNKAA(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator MLBFDKEDBCC()
	{
		AnimatorStateInfo currentAnimatorStateInfo = ((Component)this).GetComponent<Animator>().GetCurrentAnimatorStateInfo(0);
		yield return (object)new WaitForSecondsRealtime(((AnimatorStateInfo)(ref currentAnimatorStateInfo)).length * durationMultiplier);
		Utils.BLPDAEHPOBA(((Component)this).gameObject);
	}

	private void BELOIFKPNMM()
	{
		((MonoBehaviour)this).StartCoroutine(EIHIJGDBEDG());
	}

	private IEnumerator DKIJONBKHBG()
	{
		return new GEFNHENNKAA(1)
		{
			_003C_003E4__this = this
		};
	}
}
