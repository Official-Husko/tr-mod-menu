using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

public class EnvMapAnimator : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class KHOGBPOCKGM : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public EnvMapAnimator _003C_003E4__this;

		private Matrix4x4 _003Cmatrix_003E5__2;

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
		public KHOGBPOCKGM(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			EnvMapAnimator envMapAnimator = _003C_003E4__this;
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
				_003Cmatrix_003E5__2 = default(Matrix4x4);
			}
			((Matrix4x4)(ref _003Cmatrix_003E5__2)).SetTRS(Vector3.zero, Quaternion.Euler(Time.time * envMapAnimator.RotationSpeeds.x, Time.time * envMapAnimator.RotationSpeeds.y, Time.time * envMapAnimator.RotationSpeeds.z), Vector3.one);
			envMapAnimator.KMPABJKBHDC.SetMatrix("_EnvMatrix", _003Cmatrix_003E5__2);
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

	public Vector3 RotationSpeeds;

	private TMP_Text OEMJPAMFMAM;

	private Material KMPABJKBHDC;

	private IEnumerator KJOJLHCDFPP()
	{
		Matrix4x4 matrix = default(Matrix4x4);
		while (true)
		{
			((Matrix4x4)(ref matrix)).SetTRS(Vector3.zero, Quaternion.Euler(Time.time * RotationSpeeds.x, Time.time * RotationSpeeds.y, Time.time * RotationSpeeds.z), Vector3.one);
			KMPABJKBHDC.SetMatrix("_EnvMatrix", matrix);
			yield return null;
		}
	}

	private void FHOCCEBKHJI()
	{
		OEMJPAMFMAM = ((Component)this).GetComponent<TMP_Text>();
		KMPABJKBHDC = OEMJPAMFMAM.fontSharedMaterial;
	}

	private IEnumerator BELOIFKPNMM()
	{
		Matrix4x4 matrix = default(Matrix4x4);
		while (true)
		{
			((Matrix4x4)(ref matrix)).SetTRS(Vector3.zero, Quaternion.Euler(Time.time * RotationSpeeds.x, Time.time * RotationSpeeds.y, Time.time * RotationSpeeds.z), Vector3.one);
			KMPABJKBHDC.SetMatrix("_EnvMatrix", matrix);
			yield return null;
		}
	}

	private IEnumerator JPOLFKMLHNH()
	{
		Matrix4x4 matrix = default(Matrix4x4);
		while (true)
		{
			((Matrix4x4)(ref matrix)).SetTRS(Vector3.zero, Quaternion.Euler(Time.time * RotationSpeeds.x, Time.time * RotationSpeeds.y, Time.time * RotationSpeeds.z), Vector3.one);
			KMPABJKBHDC.SetMatrix("_EnvMatrix", matrix);
			yield return null;
		}
	}

	private void MIKNFPCDLML()
	{
		OEMJPAMFMAM = ((Component)this).GetComponent<TMP_Text>();
		KMPABJKBHDC = OEMJPAMFMAM.fontSharedMaterial;
	}

	private IEnumerator HOFKJPBBLGP()
	{
		Matrix4x4 matrix = default(Matrix4x4);
		while (true)
		{
			((Matrix4x4)(ref matrix)).SetTRS(Vector3.zero, Quaternion.Euler(Time.time * RotationSpeeds.x, Time.time * RotationSpeeds.y, Time.time * RotationSpeeds.z), Vector3.one);
			KMPABJKBHDC.SetMatrix("_EnvMatrix", matrix);
			yield return null;
		}
	}

	private IEnumerator JHBBABPAJJC()
	{
		return new KHOGBPOCKGM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void BHAFCBHENPL()
	{
		OEMJPAMFMAM = ((Component)this).GetComponent<TMP_Text>();
		KMPABJKBHDC = OEMJPAMFMAM.fontSharedMaterial;
	}

	private IEnumerator Start()
	{
		Matrix4x4 matrix = default(Matrix4x4);
		while (true)
		{
			((Matrix4x4)(ref matrix)).SetTRS(Vector3.zero, Quaternion.Euler(Time.time * RotationSpeeds.x, Time.time * RotationSpeeds.y, Time.time * RotationSpeeds.z), Vector3.one);
			KMPABJKBHDC.SetMatrix("_EnvMatrix", matrix);
			yield return null;
		}
	}

	private IEnumerator IDPHKHGHJGN()
	{
		return new KHOGBPOCKGM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JPHEOLEEAPB()
	{
		Matrix4x4 matrix = default(Matrix4x4);
		while (true)
		{
			((Matrix4x4)(ref matrix)).SetTRS(Vector3.zero, Quaternion.Euler(Time.time * RotationSpeeds.x, Time.time * RotationSpeeds.y, Time.time * RotationSpeeds.z), Vector3.one);
			KMPABJKBHDC.SetMatrix("_EnvMatrix", matrix);
			yield return null;
		}
	}

	private void ALEAOANPHIO()
	{
		OEMJPAMFMAM = ((Component)this).GetComponent<TMP_Text>();
		KMPABJKBHDC = OEMJPAMFMAM.fontSharedMaterial;
	}

	private IEnumerator EBNENBFLEKB()
	{
		return new KHOGBPOCKGM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator PKBHEKHOAAA()
	{
		return new KHOGBPOCKGM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void IIPKPMPGLOL()
	{
		OEMJPAMFMAM = ((Component)this).GetComponent<TMP_Text>();
		KMPABJKBHDC = OEMJPAMFMAM.fontSharedMaterial;
	}

	private IEnumerator OIBDBLCLACB()
	{
		return new KHOGBPOCKGM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void KLMNLEDKEOE()
	{
		OEMJPAMFMAM = ((Component)this).GetComponent<TMP_Text>();
		KMPABJKBHDC = OEMJPAMFMAM.fontSharedMaterial;
	}

	private void EIMIDCDEIDD()
	{
		OEMJPAMFMAM = ((Component)this).GetComponent<TMP_Text>();
		KMPABJKBHDC = OEMJPAMFMAM.fontSharedMaterial;
	}

	private void PCKOHAIPHFI()
	{
		OEMJPAMFMAM = ((Component)this).GetComponent<TMP_Text>();
		KMPABJKBHDC = OEMJPAMFMAM.fontSharedMaterial;
	}

	private void AGLMGDNBHBF()
	{
		OEMJPAMFMAM = ((Component)this).GetComponent<TMP_Text>();
		KMPABJKBHDC = OEMJPAMFMAM.fontSharedMaterial;
	}

	private void EFCNKPEPELL()
	{
		OEMJPAMFMAM = ((Component)this).GetComponent<TMP_Text>();
		KMPABJKBHDC = OEMJPAMFMAM.fontSharedMaterial;
	}

	private void OKHLEMPJONN()
	{
		OEMJPAMFMAM = ((Component)this).GetComponent<TMP_Text>();
		KMPABJKBHDC = OEMJPAMFMAM.fontSharedMaterial;
	}

	private IEnumerator FOHGHCPODBJ()
	{
		return new KHOGBPOCKGM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void HPJBLOPJIMI()
	{
		OEMJPAMFMAM = ((Component)this).GetComponent<TMP_Text>();
		KMPABJKBHDC = OEMJPAMFMAM.fontSharedMaterial;
	}

	private IEnumerator LJLKBKEADGI()
	{
		return new KHOGBPOCKGM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void GFLFDLIMOLI()
	{
		OEMJPAMFMAM = ((Component)this).GetComponent<TMP_Text>();
		KMPABJKBHDC = OEMJPAMFMAM.fontSharedMaterial;
	}

	private IEnumerator OLDDEAJMHNI()
	{
		Matrix4x4 matrix = default(Matrix4x4);
		while (true)
		{
			((Matrix4x4)(ref matrix)).SetTRS(Vector3.zero, Quaternion.Euler(Time.time * RotationSpeeds.x, Time.time * RotationSpeeds.y, Time.time * RotationSpeeds.z), Vector3.one);
			KMPABJKBHDC.SetMatrix("_EnvMatrix", matrix);
			yield return null;
		}
	}

	private void Awake()
	{
		OEMJPAMFMAM = ((Component)this).GetComponent<TMP_Text>();
		KMPABJKBHDC = OEMJPAMFMAM.fontSharedMaterial;
	}

	private void JIAJFDKNJME()
	{
		OEMJPAMFMAM = ((Component)this).GetComponent<TMP_Text>();
		KMPABJKBHDC = OEMJPAMFMAM.fontSharedMaterial;
	}

	private void OMBHDODDHNO()
	{
		OEMJPAMFMAM = ((Component)this).GetComponent<TMP_Text>();
		KMPABJKBHDC = OEMJPAMFMAM.fontSharedMaterial;
	}

	private void GNOBDKFFPOL()
	{
		OEMJPAMFMAM = ((Component)this).GetComponent<TMP_Text>();
		KMPABJKBHDC = OEMJPAMFMAM.fontSharedMaterial;
	}

	private IEnumerator MFMMHDPGCBO()
	{
		Matrix4x4 matrix = default(Matrix4x4);
		while (true)
		{
			((Matrix4x4)(ref matrix)).SetTRS(Vector3.zero, Quaternion.Euler(Time.time * RotationSpeeds.x, Time.time * RotationSpeeds.y, Time.time * RotationSpeeds.z), Vector3.one);
			KMPABJKBHDC.SetMatrix("_EnvMatrix", matrix);
			yield return null;
		}
	}

	private IEnumerator HBMDEHPHAPF()
	{
		return new KHOGBPOCKGM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void NAOBODGBECL()
	{
		OEMJPAMFMAM = ((Component)this).GetComponent<TMP_Text>();
		KMPABJKBHDC = OEMJPAMFMAM.fontSharedMaterial;
	}

	private IEnumerator LANGHIOBJIH()
	{
		return new KHOGBPOCKGM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void DKDLOBOLNFH()
	{
		OEMJPAMFMAM = ((Component)this).GetComponent<TMP_Text>();
		KMPABJKBHDC = OEMJPAMFMAM.fontSharedMaterial;
	}

	private void KHONOODGLBI()
	{
		OEMJPAMFMAM = ((Component)this).GetComponent<TMP_Text>();
		KMPABJKBHDC = OEMJPAMFMAM.fontSharedMaterial;
	}

	private void BFJOEMCBJJO()
	{
		OEMJPAMFMAM = ((Component)this).GetComponent<TMP_Text>();
		KMPABJKBHDC = OEMJPAMFMAM.fontSharedMaterial;
	}

	private IEnumerator GNGADDPBJDC()
	{
		return new KHOGBPOCKGM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator CFIIEJDJFPB()
	{
		return new KHOGBPOCKGM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator DMFMNEMDFNP()
	{
		return new KHOGBPOCKGM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void MMNBJPDJHGK()
	{
		OEMJPAMFMAM = ((Component)this).GetComponent<TMP_Text>();
		KMPABJKBHDC = OEMJPAMFMAM.fontSharedMaterial;
	}

	private IEnumerator DCKKIDMJKJM()
	{
		Matrix4x4 matrix = default(Matrix4x4);
		while (true)
		{
			((Matrix4x4)(ref matrix)).SetTRS(Vector3.zero, Quaternion.Euler(Time.time * RotationSpeeds.x, Time.time * RotationSpeeds.y, Time.time * RotationSpeeds.z), Vector3.one);
			KMPABJKBHDC.SetMatrix("_EnvMatrix", matrix);
			yield return null;
		}
	}

	private IEnumerator MCMKNBIBDFF()
	{
		return new KHOGBPOCKGM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void OGEJKOIOKAN()
	{
		OEMJPAMFMAM = ((Component)this).GetComponent<TMP_Text>();
		KMPABJKBHDC = OEMJPAMFMAM.fontSharedMaterial;
	}
}
