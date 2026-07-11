using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TutorialRat : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class HMCKOLLKMNK : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public TutorialRat _003C_003E4__this;

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
		public HMCKOLLKMNK(int _003C_003E1__state)
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
			TutorialRat tutorialRat = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				if (!NewTutorialManager.CCCLOBIOMCL || NewTutorialManager.GetCurrentPhaseID() > 106)
				{
					Utils.BLPDAEHPOBA(((Component)tutorialRat).gameObject);
				}
				else if (!SceneReferences.GetSceneReferences().tutorialRats.Contains(((Component)tutorialRat).gameObject))
				{
					SceneReferences.GetSceneReferences().tutorialRats.Add(((Component)tutorialRat).gameObject);
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

	private void AJGPMBGBPGH()
	{
		if (!GameManager.ILMDHNFFIKH() && (Object)(object)SceneReferences.GetSceneReferences() != (Object)null)
		{
			SceneReferences.CFAMKBHIGLO().tutorialRats.Remove(((Component)this).gameObject);
		}
	}

	private void NHGBKNAJHOP()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
		((MonoBehaviour)this).StartCoroutine(FKHAGGBAPBG());
	}

	private IEnumerator FKHAGGBAPBG()
	{
		return new HMCKOLLKMNK(1)
		{
			_003C_003E4__this = this
		};
	}

	private void JGIIGHAAIHF()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(CAKEKPKEPBG));
		((MonoBehaviour)this).StartCoroutine(BILAPIKKACC());
	}

	private void CAKEKPKEPBG()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(HLLCOCEAGHK));
		((MonoBehaviour)this).StartCoroutine(HHAAHFFHHNB());
	}

	private void IKMPNICLPBM()
	{
		if (!GameManager.CIOEICMHCCK && (Object)(object)SceneReferences.GetSceneReferences() != (Object)null)
		{
			SceneReferences.CFAMKBHIGLO().tutorialRats.Remove(((Component)this).gameObject);
		}
	}

	private void GJMLHECPGBP()
	{
		if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			((MonoBehaviour)this).StartCoroutine(PIPFHEDBNEM());
			return;
		}
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(BJHFPGAEDFM));
	}

	private void HLCAKACHOOE()
	{
		if (!GameManager.CIOEICMHCCK && (Object)(object)SceneReferences.CKDKHMPHENE() != (Object)null)
		{
			SceneReferences.FAOPFMBMMJJ().tutorialRats.Remove(((Component)this).gameObject);
		}
	}

	private void ELEGGKIBHGC()
	{
		if (!GameManager.CIOEICMHCCK && (Object)(object)SceneReferences.CKDKHMPHENE() != (Object)null)
		{
			SceneReferences.CFAMKBHIGLO().tutorialRats.Remove(((Component)this).gameObject);
		}
	}

	private IEnumerator PIPFHEDBNEM()
	{
		yield return CommonReferences.wait2;
		if (!NewTutorialManager.CCCLOBIOMCL || NewTutorialManager.GetCurrentPhaseID() > 106)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
		else if (!SceneReferences.GetSceneReferences().tutorialRats.Contains(((Component)this).gameObject))
		{
			SceneReferences.GetSceneReferences().tutorialRats.Add(((Component)this).gameObject);
		}
	}

	private void CEIIFHIBIFI()
	{
		if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			((MonoBehaviour)this).StartCoroutine(HHAAHFFHHNB());
			return;
		}
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(HLLCOCEAGHK));
	}

	private void CACJMKJBJDP()
	{
		if (!GameManager.CIOEICMHCCK && (Object)(object)SceneReferences.GetSceneReferences() != (Object)null)
		{
			SceneReferences.CFAMKBHIGLO().tutorialRats.Remove(((Component)this).gameObject);
		}
	}

	private void BGPGIOMKKAO()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(BGPGIOMKKAO));
		((MonoBehaviour)this).StartCoroutine(JKNPNPJGGIK());
	}

	private void Start()
	{
		if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			((MonoBehaviour)this).StartCoroutine(JKNPNPJGGIK());
			return;
		}
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(BGPGIOMKKAO));
	}

	private void OIBDBLCLACB()
	{
		if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			((MonoBehaviour)this).StartCoroutine(BILAPIKKACC());
			return;
		}
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(NFKMBHPEAHN));
	}

	private void NCDBCDJKPLA()
	{
		if (!GameManager.ILMDHNFFIKH() && (Object)(object)SceneReferences.CKDKHMPHENE() != (Object)null)
		{
			SceneReferences.GetSceneReferences().tutorialRats.Remove(((Component)this).gameObject);
		}
	}

	private IEnumerator HHAAHFFHHNB()
	{
		yield return CommonReferences.wait2;
		if (!NewTutorialManager.CCCLOBIOMCL || NewTutorialManager.GetCurrentPhaseID() > 106)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
		else if (!SceneReferences.GetSceneReferences().tutorialRats.Contains(((Component)this).gameObject))
		{
			SceneReferences.GetSceneReferences().tutorialRats.Add(((Component)this).gameObject);
		}
	}

	private IEnumerator JKNPNPJGGIK()
	{
		yield return CommonReferences.wait2;
		if (!NewTutorialManager.CCCLOBIOMCL || NewTutorialManager.GetCurrentPhaseID() > 106)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
		else if (!SceneReferences.GetSceneReferences().tutorialRats.Contains(((Component)this).gameObject))
		{
			SceneReferences.GetSceneReferences().tutorialRats.Add(((Component)this).gameObject);
		}
	}

	private void GNGADDPBJDC()
	{
		if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			((MonoBehaviour)this).StartCoroutine(HHAAHFFHHNB());
			return;
		}
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(CBHLNKHLDBG));
	}

	private void CDHBLKJEOPI()
	{
		if (!GameManager.ILMDHNFFIKH() && (Object)(object)SceneReferences.GetSceneReferences() != (Object)null)
		{
			SceneReferences.FAOPFMBMMJJ().tutorialRats.Remove(((Component)this).gameObject);
		}
	}

	private void OACFPJIJDFO()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(AANKFMNMCJN));
		((MonoBehaviour)this).StartCoroutine(JKNPNPJGGIK());
	}

	private void CHIJGHPHCNA()
	{
		if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			((MonoBehaviour)this).StartCoroutine(FLJPHPDBPML());
			return;
		}
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(NHGBKNAJHOP));
	}

	private void HLLCOCEAGHK()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(AANKFMNMCJN));
		((MonoBehaviour)this).StartCoroutine(JKNPNPJGGIK());
	}

	private void KACEOJDPLKB()
	{
		if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			((MonoBehaviour)this).StartCoroutine(PIPFHEDBNEM());
			return;
		}
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(BJHFPGAEDFM));
	}

	private void BLAJFMAAMDO()
	{
		if (!GameManager.CIOEICMHCCK && (Object)(object)SceneReferences.GetSceneReferences() != (Object)null)
		{
			SceneReferences.CKDKHMPHENE().tutorialRats.Remove(((Component)this).gameObject);
		}
	}

	private void FFFJENNJMFG()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(BLOCJJJBDDD));
		((MonoBehaviour)this).StartCoroutine(OIMLLBPMHEN());
	}

	private void AANKFMNMCJN()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(JGIIGHAAIHF));
		((MonoBehaviour)this).StartCoroutine(BILAPIKKACC());
	}

	private void ILCBKEIEOAN()
	{
		if (!GameManager.CIOEICMHCCK && (Object)(object)SceneReferences.FAOPFMBMMJJ() != (Object)null)
		{
			SceneReferences.GetSceneReferences().tutorialRats.Remove(((Component)this).gameObject);
		}
	}

	private IEnumerator FLJPHPDBPML()
	{
		return new HMCKOLLKMNK(1)
		{
			_003C_003E4__this = this
		};
	}

	private void BJHFPGAEDFM()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(JGIIGHAAIHF));
		((MonoBehaviour)this).StartCoroutine(FKHAGGBAPBG());
	}

	private void OnDestroy()
	{
		if (!GameManager.CIOEICMHCCK && (Object)(object)SceneReferences.GetSceneReferences() != (Object)null)
		{
			SceneReferences.GetSceneReferences().tutorialRats.Remove(((Component)this).gameObject);
		}
	}

	private void CBHLNKHLDBG()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(MDNCIAFNFCM));
		((MonoBehaviour)this).StartCoroutine(PIPFHEDBNEM());
	}

	private IEnumerator BILAPIKKACC()
	{
		return new HMCKOLLKMNK(1)
		{
			_003C_003E4__this = this
		};
	}

	private void CFIIEJDJFPB()
	{
		if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			((MonoBehaviour)this).StartCoroutine(BILAPIKKACC());
			return;
		}
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(CAKEKPKEPBG));
	}

	private void LJHIPOLCFBP()
	{
		if (!GameManager.CIOEICMHCCK && (Object)(object)SceneReferences.FAOPFMBMMJJ() != (Object)null)
		{
			SceneReferences.GetSceneReferences().tutorialRats.Remove(((Component)this).gameObject);
		}
	}

	private void DJNEMIOEIGI()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(CBHLNKHLDBG));
		((MonoBehaviour)this).StartCoroutine(BILAPIKKACC());
	}

	private void MFMMHDPGCBO()
	{
		if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			((MonoBehaviour)this).StartCoroutine(JCMFEEMMAHD());
			return;
		}
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(OACFPJIJDFO));
	}

	private void NFKMBHPEAHN()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(FFFJENNJMFG));
		((MonoBehaviour)this).StartCoroutine(FKHAGGBAPBG());
	}

	private void GHPFCKGMLDA()
	{
		if (GameManager.GGFJGHHHEJC.NAPGPOJEEOJ)
		{
			((MonoBehaviour)this).StartCoroutine(BILAPIKKACC());
			return;
		}
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(FFFJENNJMFG));
	}

	private void PCBKNPFOFCC()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(DJNEMIOEIGI));
		((MonoBehaviour)this).StartCoroutine(OIMLLBPMHEN());
	}

	private void PJJMNNCEGIH()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(AANKFMNMCJN));
		((MonoBehaviour)this).StartCoroutine(HHAAHFFHHNB());
	}

	private IEnumerator JCMFEEMMAHD()
	{
		return new HMCKOLLKMNK(1)
		{
			_003C_003E4__this = this
		};
	}

	private void AFCIKJPPLFA()
	{
		if (!GameManager.CIOEICMHCCK && (Object)(object)SceneReferences.FAOPFMBMMJJ() != (Object)null)
		{
			SceneReferences.CFAMKBHIGLO().tutorialRats.Remove(((Component)this).gameObject);
		}
	}

	private void OPIHPIJFDOP()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(PCBKNPFOFCC));
		((MonoBehaviour)this).StartCoroutine(JKNPNPJGGIK());
	}

	private void IDPHKHGHJGN()
	{
		if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			((MonoBehaviour)this).StartCoroutine(JCMFEEMMAHD());
			return;
		}
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(JGIIGHAAIHF));
	}

	private void PLHEHGHFCJI()
	{
		if (GameManager.NJNFHEPLEHL().NAPGPOJEEOJ)
		{
			((MonoBehaviour)this).StartCoroutine(FLJPHPDBPML());
			return;
		}
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Combine(instance.OnWorldLoaded, new Action(PJJMNNCEGIH));
	}

	private IEnumerator OIMLLBPMHEN()
	{
		yield return CommonReferences.wait2;
		if (!NewTutorialManager.CCCLOBIOMCL || NewTutorialManager.GetCurrentPhaseID() > 106)
		{
			Utils.BLPDAEHPOBA(((Component)this).gameObject);
		}
		else if (!SceneReferences.GetSceneReferences().tutorialRats.Contains(((Component)this).gameObject))
		{
			SceneReferences.GetSceneReferences().tutorialRats.Add(((Component)this).gameObject);
		}
	}

	private void MDNCIAFNFCM()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(BLOCJJJBDDD));
		((MonoBehaviour)this).StartCoroutine(OIMLLBPMHEN());
	}

	private void EBAMOAEABNH()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(OPIHPIJFDOP));
		((MonoBehaviour)this).StartCoroutine(FLJPHPDBPML());
	}

	private void BLOCJJJBDDD()
	{
		GameManager instance = GameManager.GGFJGHHHEJC;
		instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(HLLCOCEAGHK));
		((MonoBehaviour)this).StartCoroutine(FLJPHPDBPML());
	}
}
