using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class DuckManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class CLMAIKHJAHM : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DuckManager _003C_003E4__this;

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
		public CLMAIKHJAHM(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			DuckManager duckManager = _003C_003E4__this;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				_003C_003E1__state = -1;
			}
			else
			{
				_003C_003E1__state = -1;
			}
			for (int i = 0; i < duckManager.ducks.Length; i++)
			{
				for (int j = i + 1; j < duckManager.ducks.Length; j++)
				{
					DuckMovement duckMovement = duckManager.ducks[i];
					DuckMovement duckMovement2 = duckManager.ducks[j];
					if (Vector2.Distance(Vector2.op_Implicit(((Component)duckMovement).transform.position), Vector2.op_Implicit(((Component)duckMovement2).transform.position)) < 2f && !duckMovement.followingDuck)
					{
						duckMovement.SetShouldPause(INEGABKPCEN: true);
					}
					else
					{
						duckMovement.SetShouldPause(INEGABKPCEN: false);
					}
				}
			}
			_003C_003E2__current = null;
			_003C_003E1__state = 1;
			return true;
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

	public DuckMovement[] ducks;

	private IEnumerator PPBMMBHEDDP()
	{
		while (true)
		{
			for (int i = 0; i < ducks.Length; i++)
			{
				for (int j = i + 1; j < ducks.Length; j++)
				{
					DuckMovement duckMovement = ducks[i];
					DuckMovement duckMovement2 = ducks[j];
					if (Vector2.Distance(Vector2.op_Implicit(((Component)duckMovement).transform.position), Vector2.op_Implicit(((Component)duckMovement2).transform.position)) < 2f && !duckMovement.followingDuck)
					{
						duckMovement.SetShouldPause(INEGABKPCEN: true);
					}
					else
					{
						duckMovement.SetShouldPause(INEGABKPCEN: false);
					}
				}
			}
			yield return null;
		}
	}

	private IEnumerator HNPNOHNDLGH()
	{
		return new CLMAIKHJAHM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JMHAMNECDFP()
	{
		while (true)
		{
			for (int i = 0; i < ducks.Length; i++)
			{
				for (int j = i + 1; j < ducks.Length; j++)
				{
					DuckMovement duckMovement = ducks[i];
					DuckMovement duckMovement2 = ducks[j];
					if (Vector2.Distance(Vector2.op_Implicit(((Component)duckMovement).transform.position), Vector2.op_Implicit(((Component)duckMovement2).transform.position)) < 2f && !duckMovement.followingDuck)
					{
						duckMovement.SetShouldPause(INEGABKPCEN: true);
					}
					else
					{
						duckMovement.SetShouldPause(INEGABKPCEN: false);
					}
				}
			}
			yield return null;
		}
	}

	private void BJOOCKCBPLJ()
	{
		((MonoBehaviour)this).StartCoroutine(MCHGPKLICOG());
	}

	private IEnumerator FFDLCHNGFKF()
	{
		while (true)
		{
			for (int i = 0; i < ducks.Length; i++)
			{
				for (int j = i + 1; j < ducks.Length; j++)
				{
					DuckMovement duckMovement = ducks[i];
					DuckMovement duckMovement2 = ducks[j];
					if (Vector2.Distance(Vector2.op_Implicit(((Component)duckMovement).transform.position), Vector2.op_Implicit(((Component)duckMovement2).transform.position)) < 2f && !duckMovement.followingDuck)
					{
						duckMovement.SetShouldPause(INEGABKPCEN: true);
					}
					else
					{
						duckMovement.SetShouldPause(INEGABKPCEN: false);
					}
				}
			}
			yield return null;
		}
	}

	private IEnumerator KAPEJDGDBAH()
	{
		return new CLMAIKHJAHM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator OMDNBPOHLAO()
	{
		return new CLMAIKHJAHM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void DIJOBOFGCIK()
	{
		((MonoBehaviour)this).StartCoroutine(FEMFNJJCBNH());
	}

	private void FPJABCNDEEJ()
	{
		((MonoBehaviour)this).StartCoroutine(BIBGDIJCKPD());
	}

	private void AGFLPEOOEAM()
	{
		((MonoBehaviour)this).StartCoroutine(DEJFJHDKEFM());
	}

	private void LMPCDDGFBGD()
	{
		((MonoBehaviour)this).StartCoroutine(KAPEJDGDBAH());
	}

	private IEnumerator NNFLBDMFPFK()
	{
		return new CLMAIKHJAHM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LONEFNMAJOO()
	{
		while (true)
		{
			for (int i = 0; i < ducks.Length; i++)
			{
				for (int j = i + 1; j < ducks.Length; j++)
				{
					DuckMovement duckMovement = ducks[i];
					DuckMovement duckMovement2 = ducks[j];
					if (Vector2.Distance(Vector2.op_Implicit(((Component)duckMovement).transform.position), Vector2.op_Implicit(((Component)duckMovement2).transform.position)) < 2f && !duckMovement.followingDuck)
					{
						duckMovement.SetShouldPause(INEGABKPCEN: true);
					}
					else
					{
						duckMovement.SetShouldPause(INEGABKPCEN: false);
					}
				}
			}
			yield return null;
		}
	}

	private IEnumerator BIBGDIJCKPD()
	{
		return new CLMAIKHJAHM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator OIPJOEMANBA()
	{
		while (true)
		{
			for (int i = 0; i < ducks.Length; i++)
			{
				for (int j = i + 1; j < ducks.Length; j++)
				{
					DuckMovement duckMovement = ducks[i];
					DuckMovement duckMovement2 = ducks[j];
					if (Vector2.Distance(Vector2.op_Implicit(((Component)duckMovement).transform.position), Vector2.op_Implicit(((Component)duckMovement2).transform.position)) < 2f && !duckMovement.followingDuck)
					{
						duckMovement.SetShouldPause(INEGABKPCEN: true);
					}
					else
					{
						duckMovement.SetShouldPause(INEGABKPCEN: false);
					}
				}
			}
			yield return null;
		}
	}

	private void NBBFLJNPLEA()
	{
		((MonoBehaviour)this).StartCoroutine(HNPNOHNDLGH());
	}

	private void OnEnable()
	{
		((MonoBehaviour)this).StartCoroutine(JMHAMNECDFP());
	}

	private IEnumerator MCBIJCFPAIB()
	{
		return new CLMAIKHJAHM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JKOODAGPNBM()
	{
		return new CLMAIKHJAHM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator MHDNNPLCOEF()
	{
		while (true)
		{
			for (int i = 0; i < ducks.Length; i++)
			{
				for (int j = i + 1; j < ducks.Length; j++)
				{
					DuckMovement duckMovement = ducks[i];
					DuckMovement duckMovement2 = ducks[j];
					if (Vector2.Distance(Vector2.op_Implicit(((Component)duckMovement).transform.position), Vector2.op_Implicit(((Component)duckMovement2).transform.position)) < 2f && !duckMovement.followingDuck)
					{
						duckMovement.SetShouldPause(INEGABKPCEN: true);
					}
					else
					{
						duckMovement.SetShouldPause(INEGABKPCEN: false);
					}
				}
			}
			yield return null;
		}
	}

	private void CIIBBCPIOIP()
	{
		((MonoBehaviour)this).StartCoroutine(MHDNNPLCOEF());
	}

	private IEnumerator DEJFJHDKEFM()
	{
		return new CLMAIKHJAHM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator MKGHMCLOKOF()
	{
		return new CLMAIKHJAHM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void FJFLGDADEKM()
	{
		((MonoBehaviour)this).StartCoroutine(MHDNNPLCOEF());
	}

	private IEnumerator MCHGPKLICOG()
	{
		return new CLMAIKHJAHM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator IBKAACNEDOF()
	{
		while (true)
		{
			for (int i = 0; i < ducks.Length; i++)
			{
				for (int j = i + 1; j < ducks.Length; j++)
				{
					DuckMovement duckMovement = ducks[i];
					DuckMovement duckMovement2 = ducks[j];
					if (Vector2.Distance(Vector2.op_Implicit(((Component)duckMovement).transform.position), Vector2.op_Implicit(((Component)duckMovement2).transform.position)) < 2f && !duckMovement.followingDuck)
					{
						duckMovement.SetShouldPause(INEGABKPCEN: true);
					}
					else
					{
						duckMovement.SetShouldPause(INEGABKPCEN: false);
					}
				}
			}
			yield return null;
		}
	}

	private void IJMBEEEGCGF()
	{
		((MonoBehaviour)this).StartCoroutine(FFDLCHNGFKF());
	}

	private IEnumerator ADKDIEHGKGD()
	{
		return new CLMAIKHJAHM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void AMHGMJDKONK()
	{
		((MonoBehaviour)this).StartCoroutine(JMHAMNECDFP());
	}

	private void ONNAGOCFJML()
	{
		((MonoBehaviour)this).StartCoroutine(BIBGDIJCKPD());
	}

	private void HCKMHIHALBL()
	{
		((MonoBehaviour)this).StartCoroutine(KAPEJDGDBAH());
	}

	private void HJKONJICGML()
	{
		((MonoBehaviour)this).StartCoroutine(HNPNOHNDLGH());
	}

	private void HHHEACKHADN()
	{
		((MonoBehaviour)this).StartCoroutine(MCHGPKLICOG());
	}

	private void LCJCGFNFBBD()
	{
		((MonoBehaviour)this).StartCoroutine(MKGHMCLOKOF());
	}

	private void MAIMGNMIFKG()
	{
		((MonoBehaviour)this).StartCoroutine(MCHGPKLICOG());
	}

	private IEnumerator MGNOBLOKJBO()
	{
		return new CLMAIKHJAHM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator FEMFNJJCBNH()
	{
		while (true)
		{
			for (int i = 0; i < ducks.Length; i++)
			{
				for (int j = i + 1; j < ducks.Length; j++)
				{
					DuckMovement duckMovement = ducks[i];
					DuckMovement duckMovement2 = ducks[j];
					if (Vector2.Distance(Vector2.op_Implicit(((Component)duckMovement).transform.position), Vector2.op_Implicit(((Component)duckMovement2).transform.position)) < 2f && !duckMovement.followingDuck)
					{
						duckMovement.SetShouldPause(INEGABKPCEN: true);
					}
					else
					{
						duckMovement.SetShouldPause(INEGABKPCEN: false);
					}
				}
			}
			yield return null;
		}
	}
}
