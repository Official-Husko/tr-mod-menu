using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class T129_IrADormir : TutorialPhaseBase
{
	[CompilerGenerated]
	private sealed class KNIKMNEJCJG : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T129_IrADormir _003C_003E4__this;

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
		public KNIKMNEJCJG(int _003C_003E1__state)
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
			T129_IrADormir t129_IrADormir = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				t129_IrADormir.LHKIJABBBPM();
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

	[CompilerGenerated]
	private sealed class KNKDGAIDNHE : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T129_IrADormir _003C_003E4__this;

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
		public KNKDGAIDNHE(int _003C_003E1__state)
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
			T129_IrADormir @object = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
			{
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
				NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(@object.IFHFNDELKOP));
				return false;
			}
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

	private bool GBDDHBKPHIA;

	private bool EGIFPPECOAD;

	private bool PGHJGAIPOMG;

	private int BILNDDHKPJG;

	private int NJHMLFOLMAD;

	private int FMJKKNACHKB;

	private bool APHHMJMELNE;

	private IEnumerator JAMDPHHGCDP()
	{
		return new KNKDGAIDNHE(1)
		{
			_003C_003E4__this = this
		};
	}

	private void MAEHOJPFNFD()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(AACFLIPMOIE));
		NewTutorialManager.instance.FOIOHOGACAL(0);
		((MonoBehaviour)this).StartCoroutine(AJGJPBMIEJJ());
	}

	public override int GetID()
	{
		return 129;
	}

	private IEnumerator OOGKJFJEHFO()
	{
		return new KNIKMNEJCJG(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator PBEKBJIJFDK()
	{
		yield return null;
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(IFHFNDELKOP));
	}

	private void EGCLLFMNEHH()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(IFHFNDELKOP));
		NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
		((MonoBehaviour)this).StartCoroutine(AJGJPBMIEJJ());
	}

	private void KCJGBKAHIJE()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(ENNDJIEIOMP));
		NewTutorialManager.instance.FOIOHOGACAL(0);
		((MonoBehaviour)this).StartCoroutine(HCKCEGEOJLO());
	}

	private IEnumerator CNPIAJBODCG()
	{
		yield return null;
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(IFHFNDELKOP));
	}

	private void HAJKAHIBMBJ()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(MHNFFPNNBFG));
		NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
		((MonoBehaviour)this).StartCoroutine(HOCIHMHCEAK());
	}

	private IEnumerator FJBKBPOLINL()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator LHIPOAGIOJK()
	{
		yield return null;
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(IFHFNDELKOP));
	}

	private IEnumerator PPMPKJECPDE()
	{
		yield return null;
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(IFHFNDELKOP));
	}

	private void IFHFNDELKOP()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(IFHFNDELKOP));
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator BCALBKDNAJH()
	{
		return new KNKDGAIDNHE(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator MDFFFPLNDAP()
	{
		return new KNKDGAIDNHE(1)
		{
			_003C_003E4__this = this
		};
	}

	private void FLMGEKNFFOO()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(ELFLCMNGENI));
		NewTutorialManager.instance.FOIOHOGACAL(1);
		((MonoBehaviour)this).StartCoroutine(FJBKBPOLINL());
	}

	private void MCDCDBIGMMM()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(CGCGGEIKKNM));
		NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
		((MonoBehaviour)this).StartCoroutine(BJPDFDCOJKJ());
	}

	private IEnumerator JIFEIKLKIMF()
	{
		return new KNKDGAIDNHE(1)
		{
			_003C_003E4__this = this
		};
	}

	private void JMNBECMKICD()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(JFJPPOCCFLH));
		NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
		((MonoBehaviour)this).StartCoroutine(IHGGOFFGMBD());
	}

	private IEnumerator AJJPECIKMJN()
	{
		return new KNIKMNEJCJG(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator CFGLAPAKKAL()
	{
		return new KNIKMNEJCJG(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NBOCOLCBOIL()
	{
		return new KNKDGAIDNHE(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator EHDIMBMCIDK()
	{
		return new KNKDGAIDNHE(1)
		{
			_003C_003E4__this = this
		};
	}

	private void BNNADEAIOOD()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(JMNBECMKICD));
		NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
		((MonoBehaviour)this).StartCoroutine(PAJJMLCLHHK());
	}

	private void JFJPPOCCFLH()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(OAMENOGEOJE));
		NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
		((MonoBehaviour)this).StartCoroutine(KBAFIHCCEJG());
	}

	private IEnumerator LILMJIIMODP()
	{
		return new KNKDGAIDNHE(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator CKIMLLCOEGC()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator OCCLCKFAILK()
	{
		return new KNIKMNEJCJG(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JIJEDGBCENE()
	{
		yield return null;
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(IFHFNDELKOP));
	}

	private IEnumerator HOCIHMHCEAK()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void CGCGGEIKKNM()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(ONPKLGKDDMJ));
		NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
		((MonoBehaviour)this).StartCoroutine(IHGGOFFGMBD());
	}

	private void GOOGKCHMGKL()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(JMNBECMKICD));
		NewTutorialManager.instance.FOIOHOGACAL(1);
		((MonoBehaviour)this).StartCoroutine(LNFHFIMPNHD());
	}

	private IEnumerator KBAFIHCCEJG()
	{
		return new KNIKMNEJCJG(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HHDLDPPCLPE()
	{
		return new KNKDGAIDNHE(1)
		{
			_003C_003E4__this = this
		};
	}

	private void CHNBPHNFLJH()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(FONFDLPKDAH));
		NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
		((MonoBehaviour)this).StartCoroutine(OOGKJFJEHFO());
	}

	private IEnumerator LGODBMNLILN()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator LPNNMDOPCCJ()
	{
		return new KNKDGAIDNHE(1)
		{
			_003C_003E4__this = this
		};
	}

	private void NLAKCFEEGDF()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(DEMGBNGGLKC));
		NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
		((MonoBehaviour)this).StartCoroutine(CFGLAPAKKAL());
	}

	private IEnumerator LNFHFIMPNHD()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator BLHFOAMKOAH()
	{
		return new KNIKMNEJCJG(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LHDDHIJIFCN()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator ANLLGDBMBAE()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator GFMGFHGPGCM()
	{
		return new KNKDGAIDNHE(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HFKKGFOFLBJ()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void MHNFFPNNBFG()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(MAEHOJPFNFD));
		NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
		((MonoBehaviour)this).StartCoroutine(AJGJPBMIEJJ());
	}

	private IEnumerator GEFGNPHFAHG()
	{
		return new KNIKMNEJCJG(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator GJOCBPGGHLP()
	{
		return new KNKDGAIDNHE(1)
		{
			_003C_003E4__this = this
		};
	}

	private void ONPKLGKDDMJ()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(JMNBECMKICD));
		NewTutorialManager.instance.ObjectiveCompleted(1);
		((MonoBehaviour)this).StartCoroutine(BJPDFDCOJKJ());
	}

	public override void SetUp()
	{
		base.SetUp();
		((MonoBehaviour)this).StartCoroutine(PBEKBJIJFDK());
	}

	private void DEMGBNGGLKC()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(JMNBECMKICD));
		NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
		((MonoBehaviour)this).StartCoroutine(IHGGOFFGMBD());
	}

	private IEnumerator PAJJMLCLHHK()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void ENNDJIEIOMP()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(JBLKJJCNDFO));
		NewTutorialManager.instance.ObjectiveCompleted(1);
		((MonoBehaviour)this).StartCoroutine(ODILJEKMFLO());
	}

	private IEnumerator BJPDFDCOJKJ()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator CNPPMBAKEBJ()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator IHGGOFFGMBD()
	{
		return new KNIKMNEJCJG(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HNAAFAPLALL()
	{
		return new KNKDGAIDNHE(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator KGIJEMPBBED()
	{
		return new KNIKMNEJCJG(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HCKCEGEOJLO()
	{
		return new KNIKMNEJCJG(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AJOIEAICINP()
	{
		return new KNKDGAIDNHE(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AKMGPONCFHL()
	{
		yield return null;
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(IFHFNDELKOP));
	}

	private void FONFDLPKDAH()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(MPPJBKFDDAK));
		NewTutorialManager.instance.ObjectiveCompleted(1);
		((MonoBehaviour)this).StartCoroutine(HFKKGFOFLBJ());
	}

	private IEnumerator HHLKPNANHKK()
	{
		return new KNIKMNEJCJG(1)
		{
			_003C_003E4__this = this
		};
	}

	private void NJNHNBAJMLP()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(IFHFNDELKOP));
		NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
		((MonoBehaviour)this).StartCoroutine(KGIJEMPBBED());
	}

	private void FBNHEICDCHC()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(HAJKAHIBMBJ));
		NewTutorialManager.instance.FOIOHOGACAL(0);
		((MonoBehaviour)this).StartCoroutine(ANLLGDBMBAE());
	}

	private IEnumerator AJJHBJHCACM()
	{
		return new KNKDGAIDNHE(1)
		{
			_003C_003E4__this = this
		};
	}

	private void ELFLCMNGENI()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(MCDCDBIGMMM));
		NewTutorialManager.instance.FOIOHOGACAL(1);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator OPCHFFMKPCN()
	{
		return new KNKDGAIDNHE(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AJGJPBMIEJJ()
	{
		return new KNIKMNEJCJG(1)
		{
			_003C_003E4__this = this
		};
	}

	private void MPPJBKFDDAK()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(FONFDLPKDAH));
		NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
		((MonoBehaviour)this).StartCoroutine(GEFGNPHFAHG());
	}

	private void JBLKJJCNDFO()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(OAMENOGEOJE));
		NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private void OAMENOGEOJE()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(MPPJBKFDDAK));
		NewTutorialManager.instance.FOIOHOGACAL(1);
		((MonoBehaviour)this).StartCoroutine(GEFGNPHFAHG());
	}

	private IEnumerator ODILJEKMFLO()
	{
		return new KNIKMNEJCJG(1)
		{
			_003C_003E4__this = this
		};
	}

	private void AACFLIPMOIE()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(DEMGBNGGLKC));
		NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
		((MonoBehaviour)this).StartCoroutine(HHLKPNANHKK());
	}

	private void MNIBJABKLOL()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(FLMGEKNFFOO));
		NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
		((MonoBehaviour)this).StartCoroutine(CKIMLLCOEGC());
	}

	private IEnumerator FGLMKBOMOBA()
	{
		return new KNKDGAIDNHE(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JAKPMNEGELN()
	{
		return new KNIKMNEJCJG(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator PBPKJEAAGFE()
	{
		yield return null;
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(IFHFNDELKOP));
	}
}
