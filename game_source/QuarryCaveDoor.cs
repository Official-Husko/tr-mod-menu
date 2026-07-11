using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using UnityEngine;

public class QuarryCaveDoor : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class OAOECPKENHO : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public QuarryCaveDoor _003C_003E4__this;

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
		public OAOECPKENHO(int _003C_003E1__state)
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
			QuarryCaveDoor quarryCaveDoor = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				GGFJGHHHEJC.anim.SetTrigger("Open");
				quarryCaveDoor.SoundTrigger();
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

	private static QuarryCaveDoor IADEMLIIDPC;

	[SerializeField]
	private Animator anim;

	public static QuarryCaveDoor GGFJGHHHEJC => IADEMLIIDPC;

	private IEnumerator KJPIPNOPILI()
	{
		yield return CommonReferences.wait05;
		GGFJGHHHEJC.anim.SetTrigger("Open");
		SoundTrigger();
	}

	public void GGNEOGHPEML()
	{
		MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().doorStoneSlide, ((Component)OJJDNLEFNPJ()).transform);
	}

	public void LDBJDGIMDJG()
	{
		MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().doorStoneSlide, ((Component)DICHPHEOINO()).transform);
	}

	private void LADLGPKMPBP()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)(object)this)
		{
			IADEMLIIDPC = null;
		}
	}

	private void EFCNKPEPELL()
	{
		IADEMLIIDPC = this;
	}

	public void LIMEFJGPFOA()
	{
		((MonoBehaviour)DICHPHEOINO()).StartCoroutine(PONEIAHDDJH());
	}

	[SpecialName]
	public static QuarryCaveDoor OPILDPFDFKJ()
	{
		return IADEMLIIDPC;
	}

	public void JKJLIKJMJFD()
	{
		MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().doorStoneSlide, ((Component)MLPCDJPLBAC()).transform);
	}

	[SpecialName]
	public static QuarryCaveDoor MLPCDJPLBAC()
	{
		return IADEMLIIDPC;
	}

	[SpecialName]
	public static QuarryCaveDoor MAIDHAPANEB()
	{
		return IADEMLIIDPC;
	}

	public void NEFALDJAIKB()
	{
		((MonoBehaviour)EKDNJDJHONF()).StartCoroutine(LOIBJOOCECK());
	}

	private IEnumerator GJBKCMNHHJI()
	{
		yield return CommonReferences.wait05;
		GGFJGHHHEJC.anim.SetTrigger("Open");
		SoundTrigger();
	}

	[SpecialName]
	public static QuarryCaveDoor MMLBHCGFMMJ()
	{
		return IADEMLIIDPC;
	}

	private void AJGPMBGBPGH()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)(object)this)
		{
			IADEMLIIDPC = null;
		}
	}

	private void CLLAKJADGIH()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)(object)this)
		{
			IADEMLIIDPC = null;
		}
	}

	private void DGOGKLMHJEG()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)(object)this)
		{
			IADEMLIIDPC = null;
		}
	}

	private void Start()
	{
		if (!NewTutorialManager.CCCLOBIOMCL || NewTutorialManager.GetCurrentPhaseID() > 137)
		{
			anim.SetTrigger("IsOpen");
		}
	}

	private void HHLBFDBHDMC()
	{
		if (!NewTutorialManager.CCCLOBIOMCL || NewTutorialManager.GetCurrentPhaseID() > 125)
		{
			anim.SetTrigger(")");
		}
	}

	private IEnumerator GPEHAOONIFL()
	{
		yield return CommonReferences.wait05;
		GGFJGHHHEJC.anim.SetTrigger("Open");
		SoundTrigger();
	}

	private void BNIKICAEIND()
	{
		if (!NewTutorialManager.CCCLOBIOMCL || NewTutorialManager.GetCurrentPhaseID() > -124)
		{
			anim.SetTrigger("Hide");
		}
	}

	private void PKBHEKHOAAA()
	{
		if (!NewTutorialManager.CCCLOBIOMCL || NewTutorialManager.GetCurrentPhaseID() > -192)
		{
			anim.SetTrigger("ClosePopUp");
		}
	}

	private void AHFGOOHOLEL()
	{
		if (!NewTutorialManager.CCCLOBIOMCL || NewTutorialManager.GetCurrentPhaseID() > -135)
		{
			anim.SetTrigger("ReceiveSymbolPuzzleSolved");
		}
	}

	public void Open()
	{
		((MonoBehaviour)GGFJGHHHEJC).StartCoroutine(GPEHAOONIFL());
	}

	private void BGBFJPJLPMF()
	{
		IADEMLIIDPC = this;
	}

	private void GBKNIJENJEF()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)(object)this)
		{
			IADEMLIIDPC = null;
		}
	}

	public void GPDGCHFPMDL()
	{
		MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().doorStoneSlide, ((Component)OJJDNLEFNPJ()).transform);
	}

	public void GHCEHKIBLJI()
	{
		MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().doorStoneSlide, ((Component)OOKBNHMMFON()).transform);
	}

	[SpecialName]
	public static QuarryCaveDoor OJJDNLEFNPJ()
	{
		return IADEMLIIDPC;
	}

	private IEnumerator JBHKANKKKIM()
	{
		yield return CommonReferences.wait05;
		GGFJGHHHEJC.anim.SetTrigger("Open");
		SoundTrigger();
	}

	private void DKDLOBOLNFH()
	{
		IADEMLIIDPC = this;
	}

	public void GCEOLAEKBDP()
	{
		((MonoBehaviour)OPILDPFDFKJ()).StartCoroutine(DCLEMPPLFNM());
	}

	public void FMGFNMFILDG()
	{
		((MonoBehaviour)DICHPHEOINO()).StartCoroutine(GJBKCMNHHJI());
	}

	public void HLCDEIBBLBP()
	{
		((MonoBehaviour)MMLBHCGFMMJ()).StartCoroutine(LOIBJOOCECK());
	}

	public void MANNGEMDOCP()
	{
		MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().doorStoneSlide, ((Component)EKDNJDJHONF()).transform);
	}

	public void ICIGIEABIBF()
	{
		MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().doorStoneSlide, ((Component)OPILDPFDFKJ()).transform);
	}

	private IEnumerator BMBPHMELBHN()
	{
		return new OAOECPKENHO(1)
		{
			_003C_003E4__this = this
		};
	}

	private void FGFGCADFFBC()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)(object)this)
		{
			IADEMLIIDPC = null;
		}
	}

	public void DOCGGKBOABH()
	{
		MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().doorStoneSlide, ((Component)GGFJGHHHEJC).transform);
	}

	private void ALEAOANPHIO()
	{
		IADEMLIIDPC = this;
	}

	public void LHCNOEFBOHA()
	{
		MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().doorStoneSlide, ((Component)MLPCDJPLBAC()).transform);
	}

	private IEnumerator LOIBJOOCECK()
	{
		yield return CommonReferences.wait05;
		GGFJGHHHEJC.anim.SetTrigger("Open");
		SoundTrigger();
	}

	private void OAEJGGFFCBO()
	{
		IADEMLIIDPC = this;
	}

	private void FPNCANODJKE()
	{
		IADEMLIIDPC = this;
	}

	private IEnumerator HAIAOEKFABA()
	{
		return new OAOECPKENHO(1)
		{
			_003C_003E4__this = this
		};
	}

	private void MMNBJPDJHGK()
	{
		IADEMLIIDPC = this;
	}

	private IEnumerator AEJGKDJJECN()
	{
		return new OAOECPKENHO(1)
		{
			_003C_003E4__this = this
		};
	}

	public void GEFGPDLCOBO()
	{
		((MonoBehaviour)MMLBHCGFMMJ()).StartCoroutine(KJPIPNOPILI());
	}

	public void ONOFJLMIJLN()
	{
		MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().doorStoneSlide, ((Component)OJJDNLEFNPJ()).transform);
	}

	private void BNFGHAGJEGG()
	{
		IADEMLIIDPC = this;
	}

	public void BFKBALPGNGE()
	{
		MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().doorStoneSlide, ((Component)DICHPHEOINO()).transform);
	}

	private void CFIIEJDJFPB()
	{
		if (!NewTutorialManager.CCCLOBIOMCL || NewTutorialManager.GetCurrentPhaseID() > -136)
		{
			anim.SetTrigger("Drag item:");
		}
	}

	private void PLHEHGHFCJI()
	{
		if (!NewTutorialManager.CCCLOBIOMCL || NewTutorialManager.GetCurrentPhaseID() > 71)
		{
			anim.SetTrigger("");
		}
	}

	public void LJEIPAGIMMI()
	{
		MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().doorStoneSlide, ((Component)MMLBHCGFMMJ()).transform);
	}

	private IEnumerator PONEIAHDDJH()
	{
		return new OAOECPKENHO(1)
		{
			_003C_003E4__this = this
		};
	}

	public void JDNLFJELMPN()
	{
		MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().doorStoneSlide, ((Component)PDECKLKPKCG()).transform);
	}

	private void OnDestroy()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)(object)this)
		{
			IADEMLIIDPC = null;
		}
	}

	private void ICFHPJHBPDN()
	{
		if (!NewTutorialManager.CCCLOBIOMCL || NewTutorialManager.GetCurrentPhaseID() > -91)
		{
			anim.SetTrigger(", ");
		}
	}

	public void HHPPBJLACHJ()
	{
		((MonoBehaviour)OPILDPFDFKJ()).StartCoroutine(PONEIAHDDJH());
	}

	private void DMFMNEMDFNP()
	{
		if (!NewTutorialManager.CCCLOBIOMCL || NewTutorialManager.GetCurrentPhaseID() > 140)
		{
			anim.SetTrigger("");
		}
	}

	[SpecialName]
	public static QuarryCaveDoor DICHPHEOINO()
	{
		return IADEMLIIDPC;
	}

	private void IABEJCPMJOF()
	{
		if (!NewTutorialManager.CCCLOBIOMCL || NewTutorialManager.GetCurrentPhaseID() > -50)
		{
			anim.SetTrigger("//");
		}
	}

	private IEnumerator NPAEKECDNMI()
	{
		yield return CommonReferences.wait05;
		GGFJGHHHEJC.anim.SetTrigger("Open");
		SoundTrigger();
	}

	private IEnumerator DCLEMPPLFNM()
	{
		return new OAOECPKENHO(1)
		{
			_003C_003E4__this = this
		};
	}

	private void KOBNHPKEJJD()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)(object)this)
		{
			IADEMLIIDPC = null;
		}
	}

	public void KIAFJGBADKM()
	{
		MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().doorStoneSlide, ((Component)MLPCDJPLBAC()).transform);
	}

	private void CAOKPIIFHBJ()
	{
		if (!NewTutorialManager.CCCLOBIOMCL || NewTutorialManager.GetCurrentPhaseID() > 124)
		{
			anim.SetTrigger("sunny");
		}
	}

	private void OJJCGNICMBD()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)(object)this)
		{
			IADEMLIIDPC = null;
		}
	}

	private void Awake()
	{
		IADEMLIIDPC = this;
	}

	public void FPINCKPNGDG()
	{
		((MonoBehaviour)MLPCDJPLBAC()).StartCoroutine(DCLEMPPLFNM());
	}

	private IEnumerator LFBOMOKMBDD()
	{
		yield return CommonReferences.wait05;
		GGFJGHHHEJC.anim.SetTrigger("Open");
		SoundTrigger();
	}

	private void PCKOHAIPHFI()
	{
		IADEMLIIDPC = this;
	}

	private void CFHOODNCOLK()
	{
		if (!NewTutorialManager.CCCLOBIOMCL || NewTutorialManager.GetCurrentPhaseID() > -72)
		{
			anim.SetTrigger(" has null in variant objects list.");
		}
	}

	[SpecialName]
	public static QuarryCaveDoor PDECKLKPKCG()
	{
		return IADEMLIIDPC;
	}

	private void GOJKOBEEMNA()
	{
		IADEMLIIDPC = this;
	}

	private IEnumerator ENCANMNCOJK()
	{
		yield return CommonReferences.wait05;
		GGFJGHHHEJC.anim.SetTrigger("Open");
		SoundTrigger();
	}

	public void FPEJEGHEMOH()
	{
		MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().doorStoneSlide, ((Component)DICHPHEOINO()).transform);
	}

	[SpecialName]
	public static QuarryCaveDoor OOKBNHMMFON()
	{
		return IADEMLIIDPC;
	}

	private void FOHGHCPODBJ()
	{
		if (!NewTutorialManager.CCCLOBIOMCL || NewTutorialManager.GetCurrentPhaseID() > 39)
		{
			anim.SetTrigger("Dialogue System/Conversation/Crowly_Standar/Entry/37/Dialogue Text");
		}
	}

	private void AIEKBPENOKC()
	{
		if ((Object)(object)IADEMLIIDPC == (Object)(object)this)
		{
			IADEMLIIDPC = null;
		}
	}

	public void SoundTrigger()
	{
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.doorStoneSlide, ((Component)GGFJGHHHEJC).transform);
	}

	private void JPOLFKMLHNH()
	{
		if (!NewTutorialManager.CCCLOBIOMCL || NewTutorialManager.GetCurrentPhaseID() > -71)
		{
			anim.SetTrigger("");
		}
	}

	[SpecialName]
	public static QuarryCaveDoor EKDNJDJHONF()
	{
		return IADEMLIIDPC;
	}
}
