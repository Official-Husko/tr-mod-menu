using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AwningManager : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class IELIHNGJEMK : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AwningManager _003C_003E4__this;

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
		public IELIHNGJEMK(int _003C_003E1__state)
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
			AwningManager awningManager = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait5;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				awningManager.awningControllers.OnPlayerAwake();
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

	public AwningController awningControllers;

	public void FEMMGHPCOBI()
	{
		awningControllers.COPDNJFJKCH();
	}

	public void BONHDKBLOMP()
	{
		awningControllers.OnPlayerAwake();
	}

	private void PKPHKBMPJGJ()
	{
		awningControllers.IEPLKEACHCO();
		((MonoBehaviour)this).StartCoroutine(LPAIPJBPFOH());
	}

	private IEnumerator INDNLOPPPGI()
	{
		yield return CommonReferences.wait5;
		awningControllers.OnPlayerAwake();
	}

	private IEnumerator LNHPDLGKABK()
	{
		return new IELIHNGJEMK(1)
		{
			_003C_003E4__this = this
		};
	}

	private void CLGBFOIBANN()
	{
		awningControllers.IEPLKEACHCO();
		((MonoBehaviour)this).StartCoroutine(INDNLOPPPGI());
	}

	private IEnumerator OIFIBNDOOPE()
	{
		yield return CommonReferences.wait5;
		awningControllers.OnPlayerAwake();
	}

	private void COKBJNMAMDI()
	{
		awningControllers.DOFLFGNDBAM();
		((MonoBehaviour)this).StartCoroutine(ADFLGIIIAOH());
	}

	private void KMBEOPAHKGB()
	{
		awningControllers.KHNPANNPLLL();
		((MonoBehaviour)this).StartCoroutine(CBKNIBCGGAM());
	}

	private void FHOCCEBKHJI()
	{
		awningControllers.InitAwning();
		((MonoBehaviour)this).StartCoroutine(LPAIPJBPFOH());
	}

	private void EHBMONGBJFI()
	{
		awningControllers.HIHPHLNLDNP();
		((MonoBehaviour)this).StartCoroutine(GHLKLIJPPOI());
	}

	public void PIIIOILIDHA()
	{
		awningControllers.GCAKMALKGPJ();
	}

	private IEnumerator OHLGLLMKAIE()
	{
		return new IELIHNGJEMK(1)
		{
			_003C_003E4__this = this
		};
	}

	private void NJAFKFAPDIE()
	{
		awningControllers.MPKEEKIBIAE();
		((MonoBehaviour)this).StartCoroutine(OHLGLLMKAIE());
	}

	private void JIAJFDKNJME()
	{
		awningControllers.NIMLBCFOKFL();
		((MonoBehaviour)this).StartCoroutine(CBKNIBCGGAM());
	}

	private void BHAFCBHENPL()
	{
		awningControllers.JFKHEBGEPHG();
		((MonoBehaviour)this).StartCoroutine(KGEHNJOCNJD());
	}

	public void GIBFJNCCPJL()
	{
		awningControllers.CKHDGFBDOGB();
	}

	public void FHLDCHCHANF()
	{
		awningControllers.CKHDGFBDOGB();
	}

	private void IGNEGEOPLOP()
	{
		awningControllers.NIMLBCFOKFL();
		((MonoBehaviour)this).StartCoroutine(GLDIIPPLHLG());
	}

	private IEnumerator ANIBIPCKOFC()
	{
		return new IELIHNGJEMK(1)
		{
			_003C_003E4__this = this
		};
	}

	private void KLHIMJFCHPD()
	{
		awningControllers.JFKHEBGEPHG();
		((MonoBehaviour)this).StartCoroutine(PJKDOCFIHJD());
	}

	private IEnumerator PJKDOCFIHJD()
	{
		yield return CommonReferences.wait5;
		awningControllers.OnPlayerAwake();
	}

	private void DNBGIIGAKMJ()
	{
		awningControllers.HIHPHLNLDNP();
		((MonoBehaviour)this).StartCoroutine(KGEHNJOCNJD());
	}

	public void GOKMHENLMLB()
	{
		awningControllers.KPFCJAAFFEI();
	}

	private IEnumerator PMIJOBIIJII()
	{
		return new IELIHNGJEMK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator ADFLGIIIAOH()
	{
		yield return CommonReferences.wait5;
		awningControllers.OnPlayerAwake();
	}

	public void ACHEHDIKMBI()
	{
		awningControllers.OBCBKGCFGFE();
	}

	private void AAEAAEBBFKG()
	{
		awningControllers.HIHPHLNLDNP();
		((MonoBehaviour)this).StartCoroutine(LNHPDLGKABK());
	}

	public void COPDNJFJKCH()
	{
		awningControllers.GCAKMALKGPJ();
	}

	private void Awake()
	{
		awningControllers.InitAwning();
		((MonoBehaviour)this).StartCoroutine(AFOALPIKOEC());
	}

	private IEnumerator DCFONHPPBAG()
	{
		return new IELIHNGJEMK(1)
		{
			_003C_003E4__this = this
		};
	}

	private void NEOICNJNKNL()
	{
		awningControllers.DOFLFGNDBAM();
		((MonoBehaviour)this).StartCoroutine(OHLGLLMKAIE());
	}

	private IEnumerator NNHJGKBLGHM()
	{
		return new IELIHNGJEMK(1)
		{
			_003C_003E4__this = this
		};
	}

	public void JFMIGDHHKAP()
	{
		awningControllers.COPDNJFJKCH();
	}

	public void JAIFBCOBGGJ()
	{
		awningControllers.DCHDJABABLE();
	}

	private IEnumerator AFOALPIKOEC()
	{
		yield return CommonReferences.wait5;
		awningControllers.OnPlayerAwake();
	}

	private IEnumerator HIFBKMNOAFC()
	{
		return new IELIHNGJEMK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator GLDIIPPLHLG()
	{
		return new IELIHNGJEMK(1)
		{
			_003C_003E4__this = this
		};
	}

	private void HPJBLOPJIMI()
	{
		awningControllers.InitAwning();
		((MonoBehaviour)this).StartCoroutine(CBKNIBCGGAM());
	}

	private IEnumerator KGEHNJOCNJD()
	{
		return new IELIHNGJEMK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HJBAIDDAIGC()
	{
		yield return CommonReferences.wait5;
		awningControllers.OnPlayerAwake();
	}

	private IEnumerator CBKNIBCGGAM()
	{
		return new IELIHNGJEMK(1)
		{
			_003C_003E4__this = this
		};
	}

	public void CKHDGFBDOGB()
	{
		awningControllers.KPFCJAAFFEI();
	}

	private IEnumerator CMDKDJEPMDP()
	{
		yield return CommonReferences.wait5;
		awningControllers.OnPlayerAwake();
	}

	private IEnumerator KOIJOAKAJKM()
	{
		yield return CommonReferences.wait5;
		awningControllers.OnPlayerAwake();
	}

	public void IAPAKPNFAJF()
	{
		awningControllers.COPDNJFJKCH();
	}

	private IEnumerator JKDFPBLJBJG()
	{
		yield return CommonReferences.wait5;
		awningControllers.OnPlayerAwake();
	}

	public void OnPlayerAwake()
	{
		awningControllers.OnPlayerAwake();
	}

	public void OEAPMJBCIHJ()
	{
		awningControllers.CKHDGFBDOGB();
	}

	private void BGBFJPJLPMF()
	{
		awningControllers.KHNPANNPLLL();
		((MonoBehaviour)this).StartCoroutine(KGEHNJOCNJD());
	}

	private void CLNBMOPMNOF()
	{
		awningControllers.OHEKHKGFIKI();
		((MonoBehaviour)this).StartCoroutine(LHDHFNOCMLE());
	}

	public void PHNEEMAKGJP()
	{
		awningControllers.DCHDJABABLE();
	}

	private IEnumerator NIKHECOKFNN()
	{
		return new IELIHNGJEMK(1)
		{
			_003C_003E4__this = this
		};
	}

	private void ALEAOANPHIO()
	{
		awningControllers.InitAwning();
		((MonoBehaviour)this).StartCoroutine(DCFONHPPBAG());
	}

	public void ONEDJBMPCBH()
	{
		awningControllers.KPFCJAAFFEI();
	}

	private IEnumerator LPAIPJBPFOH()
	{
		yield return CommonReferences.wait5;
		awningControllers.OnPlayerAwake();
	}

	private void AGELAMLCINB()
	{
		awningControllers.NIMLBCFOKFL();
		((MonoBehaviour)this).StartCoroutine(DCFONHPPBAG());
	}

	private IEnumerator LHDHFNOCMLE()
	{
		yield return CommonReferences.wait5;
		awningControllers.OnPlayerAwake();
	}

	private void JDHHJKBOJML()
	{
		awningControllers.JHPBIGEBHOB();
		((MonoBehaviour)this).StartCoroutine(PJKDOCFIHJD());
	}

	public void EJKIADFBMJO()
	{
		awningControllers.KPFCJAAFFEI();
	}

	public void DCHDJABABLE()
	{
		awningControllers.OBCBKGCFGFE();
	}

	public void DAONPPAIOMA()
	{
		awningControllers.OBCBKGCFGFE();
	}

	public void GMJGBMOIIJJ()
	{
		awningControllers.GCAKMALKGPJ();
	}

	private void CEOEHODJAJK()
	{
		awningControllers.InitAwning();
		((MonoBehaviour)this).StartCoroutine(GLDIIPPLHLG());
	}

	public void JBFFNMCKOEM()
	{
		awningControllers.OnPlayerAwake();
	}

	private void CIICEKEJANM()
	{
		awningControllers.JFKHEBGEPHG();
		((MonoBehaviour)this).StartCoroutine(NIKHECOKFNN());
	}

	private void JDMMNLKLMAA()
	{
		awningControllers.JHPBIGEBHOB();
		((MonoBehaviour)this).StartCoroutine(OIFIBNDOOPE());
	}

	public void KHOFBHDDPKK()
	{
		awningControllers.GCAKMALKGPJ();
	}

	private IEnumerator HAENKJMCJGD()
	{
		yield return CommonReferences.wait5;
		awningControllers.OnPlayerAwake();
	}

	public void PJKNCIBFAFO()
	{
		awningControllers.GCAKMALKGPJ();
	}

	public void OEICMCEBGKK()
	{
		awningControllers.OnPlayerAwake();
	}

	public void IAMJGJLOLNN()
	{
		awningControllers.CKHDGFBDOGB();
	}

	private void NMKGOAJLMDG()
	{
		awningControllers.MPKEEKIBIAE();
		((MonoBehaviour)this).StartCoroutine(DCFONHPPBAG());
	}

	private void KJHKBGDJNDC()
	{
		awningControllers.JHPBIGEBHOB();
		((MonoBehaviour)this).StartCoroutine(AFOALPIKOEC());
	}

	public void NKLAEFMJPDE()
	{
		awningControllers.CKHDGFBDOGB();
	}

	private IEnumerator GHLKLIJPPOI()
	{
		yield return CommonReferences.wait5;
		awningControllers.OnPlayerAwake();
	}

	public void FNJIMIFMJGO()
	{
		awningControllers.CKHDGFBDOGB();
	}

	private IEnumerator EAPFPIAIAII()
	{
		return new IELIHNGJEMK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JKNGODJNHPE()
	{
		return new IELIHNGJEMK(1)
		{
			_003C_003E4__this = this
		};
	}
}
