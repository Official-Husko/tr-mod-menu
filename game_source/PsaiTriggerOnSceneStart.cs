using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using psai.net;

public class PsaiTriggerOnSceneStart : PsaiTriggerOnSignal
{
	[CompilerGenerated]
	private sealed class BFPIEBOIMBI : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PsaiTriggerOnSceneStart _003C_003E4__this;

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
		public BFPIEBOIMBI(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num = _003C_003E1__state;
			PsaiTriggerOnSceneStart psaiTriggerOnSceneStart = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				break;
			case 1:
				_003C_003E1__state = -1;
				break;
			}
			if (!PsaiCore.IsInstanceInitialized() || PsaiCore.Instance.GetSoundtrackInfo().themeCount == 0)
			{
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			}
			PsaiCore.Instance.TriggerMusicTheme(psaiTriggerOnSceneStart.themeId, psaiTriggerOnSceneStart.intensity);
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

	private IEnumerator KFIFLGOPKMD()
	{
		return new BFPIEBOIMBI(1)
		{
			_003C_003E4__this = this
		};
	}

	private void HJDLNCOAKIK()
	{
		((MonoBehaviour)this).StartCoroutine(GMHJEEKOHMO());
	}

	private void IFHLGOMBACP()
	{
		((MonoBehaviour)this).StartCoroutine(AEMCJDFGGPF());
	}

	private void LJLKBKEADGI()
	{
		((MonoBehaviour)this).StartCoroutine(PKGMMEGNEDC());
	}

	private IEnumerator ANMOJBHKPLL()
	{
		while (!PsaiCore.IsInstanceInitialized() || PsaiCore.Instance.GetSoundtrackInfo().themeCount == 0)
		{
			yield return null;
		}
		PsaiCore.Instance.TriggerMusicTheme(themeId, intensity);
	}

	private void NFABFPFLNEE()
	{
		((MonoBehaviour)this).StartCoroutine(MNNCBLKHMEL());
	}

	private void KACEOJDPLKB()
	{
		((MonoBehaviour)this).StartCoroutine(AEMCJDFGGPF());
	}

	private void HBMDEHPHAPF()
	{
		((MonoBehaviour)this).StartCoroutine(OANMGLKBPNN());
	}

	private IEnumerator AJBIGEAIPEL()
	{
		return new BFPIEBOIMBI(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LPKCKAANFLB()
	{
		while (!PsaiCore.IsInstanceInitialized() || PsaiCore.Instance.GetSoundtrackInfo().themeCount == 0)
		{
			yield return null;
		}
		PsaiCore.Instance.TriggerMusicTheme(themeId, intensity);
	}

	private void GHPFCKGMLDA()
	{
		((MonoBehaviour)this).StartCoroutine(GMHJEEKOHMO());
	}

	private IEnumerator AHGJEGOFOED()
	{
		while (!PsaiCore.IsInstanceInitialized() || PsaiCore.Instance.GetSoundtrackInfo().themeCount == 0)
		{
			yield return null;
		}
		PsaiCore.Instance.TriggerMusicTheme(themeId, intensity);
	}

	private void EOGHJNGJFID()
	{
		((MonoBehaviour)this).StartCoroutine(PKGMMEGNEDC());
	}

	private void NELBHAMPBPL()
	{
		((MonoBehaviour)this).StartCoroutine(MNNCBLKHMEL());
	}

	private void LANGHIOBJIH()
	{
		((MonoBehaviour)this).StartCoroutine(AHGJEGOFOED());
	}

	private IEnumerator IEBBFIMHIDA()
	{
		return new BFPIEBOIMBI(1)
		{
			_003C_003E4__this = this
		};
	}

	private void JLCFNPBBKEK()
	{
		((MonoBehaviour)this).StartCoroutine(AJBIGEAIPEL());
	}

	private void BDGCFCPFKKE()
	{
		((MonoBehaviour)this).StartCoroutine(LDCOBBDLAFM());
	}

	private void HOFKJPBBLGP()
	{
		((MonoBehaviour)this).StartCoroutine(GMHJEEKOHMO());
	}

	private void OIBDBLCLACB()
	{
		((MonoBehaviour)this).StartCoroutine(BCIODFHDCAL());
	}

	private void IMIONHLAKIH()
	{
		((MonoBehaviour)this).StartCoroutine(ANMOJBHKPLL());
	}

	private void IGIKNCOLCKL()
	{
		((MonoBehaviour)this).StartCoroutine(JHLLEKIJGDH());
	}

	private IEnumerator GNGPAMOBBGA()
	{
		return new BFPIEBOIMBI(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JMJBINEPPOO()
	{
		while (!PsaiCore.IsInstanceInitialized() || PsaiCore.Instance.GetSoundtrackInfo().themeCount == 0)
		{
			yield return null;
		}
		PsaiCore.Instance.TriggerMusicTheme(themeId, intensity);
	}

	private void JPOLFKMLHNH()
	{
		((MonoBehaviour)this).StartCoroutine(JACDDNCDKPK());
	}

	private void BELOIFKPNMM()
	{
		((MonoBehaviour)this).StartCoroutine(IOBMGACNLII());
	}

	private IEnumerator HFMAOIMOJNI()
	{
		while (!PsaiCore.IsInstanceInitialized() || PsaiCore.Instance.GetSoundtrackInfo().themeCount == 0)
		{
			yield return null;
		}
		PsaiCore.Instance.TriggerMusicTheme(themeId, intensity);
	}

	private void CFHOODNCOLK()
	{
		((MonoBehaviour)this).StartCoroutine(AJBIGEAIPEL());
	}

	private void PFLBPMIEKGF()
	{
		((MonoBehaviour)this).StartCoroutine(LEHHPMGIFEL());
	}

	private void BDJKNKIOPIJ()
	{
		((MonoBehaviour)this).StartCoroutine(KANLFCALPFE());
	}

	private IEnumerator MNNCBLKHMEL()
	{
		return new BFPIEBOIMBI(1)
		{
			_003C_003E4__this = this
		};
	}

	private void HCEDMLJNOBL()
	{
		((MonoBehaviour)this).StartCoroutine(HMGAEMKOMBP());
	}

	private void IDPHKHGHJGN()
	{
		((MonoBehaviour)this).StartCoroutine(GMHJEEKOHMO());
	}

	private IEnumerator LAGNCEPLFOI()
	{
		return new BFPIEBOIMBI(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator DFHMBDAKPIL()
	{
		return new BFPIEBOIMBI(1)
		{
			_003C_003E4__this = this
		};
	}

	private void FOHGHCPODBJ()
	{
		((MonoBehaviour)this).StartCoroutine(HFMAOIMOJNI());
	}

	private void DCKKIDMJKJM()
	{
		((MonoBehaviour)this).StartCoroutine(OKHCMBBBNML());
	}

	private IEnumerator OKHCMBBBNML()
	{
		return new BFPIEBOIMBI(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HMGAEMKOMBP()
	{
		while (!PsaiCore.IsInstanceInitialized() || PsaiCore.Instance.GetSoundtrackInfo().themeCount == 0)
		{
			yield return null;
		}
		PsaiCore.Instance.TriggerMusicTheme(themeId, intensity);
	}

	private void PLHEHGHFCJI()
	{
		((MonoBehaviour)this).StartCoroutine(IGFFMGLDHEK());
	}

	private void PKBHEKHOAAA()
	{
		((MonoBehaviour)this).StartCoroutine(MNNCBLKHMEL());
	}

	private void EGACIHOKJLH()
	{
		((MonoBehaviour)this).StartCoroutine(IEBBFIMHIDA());
	}

	private IEnumerator PKGMMEGNEDC()
	{
		return new BFPIEBOIMBI(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JHLLEKIJGDH()
	{
		return new BFPIEBOIMBI(1)
		{
			_003C_003E4__this = this
		};
	}

	private void PGJJBPALEGM()
	{
		((MonoBehaviour)this).StartCoroutine(PKGMMEGNEDC());
	}

	private IEnumerator GMHJEEKOHMO()
	{
		while (!PsaiCore.IsInstanceInitialized() || PsaiCore.Instance.GetSoundtrackInfo().themeCount == 0)
		{
			yield return null;
		}
		PsaiCore.Instance.TriggerMusicTheme(themeId, intensity);
	}

	private IEnumerator BGKIDHIDGFD()
	{
		return new BFPIEBOIMBI(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JACDDNCDKPK()
	{
		while (!PsaiCore.IsInstanceInitialized() || PsaiCore.Instance.GetSoundtrackInfo().themeCount == 0)
		{
			yield return null;
		}
		PsaiCore.Instance.TriggerMusicTheme(themeId, intensity);
	}

	private IEnumerator KANLFCALPFE()
	{
		while (!PsaiCore.IsInstanceInitialized() || PsaiCore.Instance.GetSoundtrackInfo().themeCount == 0)
		{
			yield return null;
		}
		PsaiCore.Instance.TriggerMusicTheme(themeId, intensity);
	}

	private IEnumerator LDCOBBDLAFM()
	{
		while (!PsaiCore.IsInstanceInitialized() || PsaiCore.Instance.GetSoundtrackInfo().themeCount == 0)
		{
			yield return null;
		}
		PsaiCore.Instance.TriggerMusicTheme(themeId, intensity);
	}

	private IEnumerator IOBMGACNLII()
	{
		return new BFPIEBOIMBI(1)
		{
			_003C_003E4__this = this
		};
	}

	private void JPHEOLEEAPB()
	{
		((MonoBehaviour)this).StartCoroutine(GMHJEEKOHMO());
	}

	private void Start()
	{
		((MonoBehaviour)this).StartCoroutine(HONILPMCJFD());
	}

	private void GNGADDPBJDC()
	{
		((MonoBehaviour)this).StartCoroutine(LEHHPMGIFEL());
	}

	private IEnumerator HONILPMCJFD()
	{
		while (!PsaiCore.IsInstanceInitialized() || PsaiCore.Instance.GetSoundtrackInfo().themeCount == 0)
		{
			yield return null;
		}
		PsaiCore.Instance.TriggerMusicTheme(themeId, intensity);
	}

	private IEnumerator EAHMNOOKGGH()
	{
		return new BFPIEBOIMBI(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LEHHPMGIFEL()
	{
		return new BFPIEBOIMBI(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator IGFFMGLDHEK()
	{
		return new BFPIEBOIMBI(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AEMCJDFGGPF()
	{
		while (!PsaiCore.IsInstanceInitialized() || PsaiCore.Instance.GetSoundtrackInfo().themeCount == 0)
		{
			yield return null;
		}
		PsaiCore.Instance.TriggerMusicTheme(themeId, intensity);
	}

	private void CAIJLMJBMLA()
	{
		((MonoBehaviour)this).StartCoroutine(GMHJEEKOHMO());
	}

	private IEnumerator BCIODFHDCAL()
	{
		return new BFPIEBOIMBI(1)
		{
			_003C_003E4__this = this
		};
	}

	private void OLDDEAJMHNI()
	{
		((MonoBehaviour)this).StartCoroutine(LAGNCEPLFOI());
	}

	private IEnumerator OANMGLKBPNN()
	{
		while (!PsaiCore.IsInstanceInitialized() || PsaiCore.Instance.GetSoundtrackInfo().themeCount == 0)
		{
			yield return null;
		}
		PsaiCore.Instance.TriggerMusicTheme(themeId, intensity);
	}

	private void EEKOJEKPIMP()
	{
		((MonoBehaviour)this).StartCoroutine(AJBIGEAIPEL());
	}

	private void BNIKICAEIND()
	{
		((MonoBehaviour)this).StartCoroutine(EAHMNOOKGGH());
	}

	private void KDBJHCAEGCM()
	{
		((MonoBehaviour)this).StartCoroutine(AJBIGEAIPEL());
	}

	private IEnumerator CGMFHBOGIDN()
	{
		return new BFPIEBOIMBI(1)
		{
			_003C_003E4__this = this
		};
	}

	private void CHIJGHPHCNA()
	{
		((MonoBehaviour)this).StartCoroutine(AHGJEGOFOED());
	}
}
