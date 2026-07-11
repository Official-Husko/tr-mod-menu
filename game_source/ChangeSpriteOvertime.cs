using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ChangeSpriteOvertime : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class GCCFCNCCCDJ : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ChangeSpriteOvertime _003C_003E4__this;

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
		public GCCFCNCCCDJ(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Expected O, but got Unknown
			int num = _003C_003E1__state;
			ChangeSpriteOvertime changeSpriteOvertime = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = (object)new WaitForSeconds(changeSpriteOvertime.time);
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				if (Object.op_Implicit((Object)(object)changeSpriteOvertime.spriteRenderer))
				{
					changeSpriteOvertime.spriteRenderer.sprite = changeSpriteOvertime.newSprite;
				}
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

	public SpriteRenderer spriteRenderer;

	public Sprite newSprite;

	public float time = 20f;

	private IEnumerator AHPDBFCHFBG()
	{
		yield return (object)new WaitForSeconds(time);
		if (Object.op_Implicit((Object)(object)spriteRenderer))
		{
			spriteRenderer.sprite = newSprite;
		}
	}

	private void FOHGHCPODBJ()
	{
		((MonoBehaviour)this).StartCoroutine(LFLFIABPOAH());
	}

	private void BELOIFKPNMM()
	{
		((MonoBehaviour)this).StartCoroutine(GNBABPKIOPH());
	}

	private void PKBHEKHOAAA()
	{
		((MonoBehaviour)this).StartCoroutine(APNIJINIOEJ());
	}

	private void BHAFCBHENPL()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
	}

	private void HBMDEHPHAPF()
	{
		((MonoBehaviour)this).StartCoroutine(PGEHPLDJMAL());
	}

	private IEnumerator APNIJINIOEJ()
	{
		yield return (object)new WaitForSeconds(time);
		if (Object.op_Implicit((Object)(object)spriteRenderer))
		{
			spriteRenderer.sprite = newSprite;
		}
	}

	private IEnumerator OAKJFILCPEN()
	{
		yield return (object)new WaitForSeconds(time);
		if (Object.op_Implicit((Object)(object)spriteRenderer))
		{
			spriteRenderer.sprite = newSprite;
		}
	}

	private IEnumerator LFLFIABPOAH()
	{
		return new GCCFCNCCCDJ(1)
		{
			_003C_003E4__this = this
		};
	}

	private void NEOICNJNKNL()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
	}

	private void CEOEHODJAJK()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
	}

	private IEnumerator DEFLHGMODKF()
	{
		yield return (object)new WaitForSeconds(time);
		if (Object.op_Implicit((Object)(object)spriteRenderer))
		{
			spriteRenderer.sprite = newSprite;
		}
	}

	private void GNOBDKFFPOL()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
	}

	private void GFLFDLIMOLI()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
	}

	private void Awake()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
	}

	private void GONDLJKGLGO()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
	}

	private IEnumerator PHCNLCGGPHO()
	{
		return new GCCFCNCCCDJ(1)
		{
			_003C_003E4__this = this
		};
	}

	private void IDPHKHGHJGN()
	{
		((MonoBehaviour)this).StartCoroutine(GNBABPKIOPH());
	}

	private IEnumerator GNBABPKIOPH()
	{
		yield return (object)new WaitForSeconds(time);
		if (Object.op_Implicit((Object)(object)spriteRenderer))
		{
			spriteRenderer.sprite = newSprite;
		}
	}

	private void HDHPOAPLEJC()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
	}

	private void CAIJLMJBMLA()
	{
		((MonoBehaviour)this).StartCoroutine(OAKJFILCPEN());
	}

	private IEnumerator HJKEADBKLFI()
	{
		yield return (object)new WaitForSeconds(time);
		if (Object.op_Implicit((Object)(object)spriteRenderer))
		{
			spriteRenderer.sprite = newSprite;
		}
	}

	private IEnumerator NMOKFAILKEO()
	{
		yield return (object)new WaitForSeconds(time);
		if (Object.op_Implicit((Object)(object)spriteRenderer))
		{
			spriteRenderer.sprite = newSprite;
		}
	}

	private void KHONOODGLBI()
	{
		if ((Object)(object)spriteRenderer == (Object)null)
		{
			spriteRenderer = ((Component)this).GetComponent<SpriteRenderer>();
		}
	}

	private IEnumerator PGEHPLDJMAL()
	{
		yield return (object)new WaitForSeconds(time);
		if (Object.op_Implicit((Object)(object)spriteRenderer))
		{
			spriteRenderer.sprite = newSprite;
		}
	}

	private IEnumerator BENOCPOLJCE()
	{
		return new GCCFCNCCCDJ(1)
		{
			_003C_003E4__this = this
		};
	}

	private void BNIKICAEIND()
	{
		((MonoBehaviour)this).StartCoroutine(PGEHPLDJMAL());
	}

	private void Start()
	{
		((MonoBehaviour)this).StartCoroutine(APNIJINIOEJ());
	}

	private void NKDFMFFDGKC()
	{
		((MonoBehaviour)this).StartCoroutine(NMOKFAILKEO());
	}
}
