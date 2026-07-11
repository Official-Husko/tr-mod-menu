using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class T139_VolverDeLaCiudad : TutorialPhaseBase
{
	[CompilerGenerated]
	private sealed class NKFONDFHGBN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T139_VolverDeLaCiudad _003C_003E4__this;

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
		public NKFONDFHGBN(int _003C_003E1__state)
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
			T139_VolverDeLaCiudad t139_VolverDeLaCiudad = _003C_003E4__this;
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
				t139_VolverDeLaCiudad.LHKIJABBBPM();
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
	private sealed class DBHBDMOHMPM : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T139_VolverDeLaCiudad _003C_003E4__this;

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
		public DBHBDMOHMPM(int _003C_003E1__state)
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
			T139_VolverDeLaCiudad t139_VolverDeLaCiudad = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
				goto IL_0077;
			case 2:
				_003C_003E1__state = -1;
				goto IL_0077;
			case 3:
				{
					_003C_003E1__state = -1;
					NewTutorialManager.instance.ObjectiveCompleted(0);
					((MonoBehaviour)t139_VolverDeLaCiudad).StartCoroutine(t139_VolverDeLaCiudad.LHDDHIJIFCN());
					return false;
				}
				IL_0077:
				if (!t139_VolverDeLaCiudad.AOOKIKFINFB())
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 2;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 3;
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

	private IEnumerator ELPDKDFFJJD()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator OPCHFFMKPCN()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator LHDDHIJIFCN()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	public override int GetID()
	{
		return 139;
	}

	private IEnumerator GEFGNPHFAHG()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator JAKPMNEGELN()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator DECKMELAPMA()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HCCJFBLCABN()
	{
		return new NKFONDFHGBN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator CIBIOLGHPJF()
	{
		return new NKFONDFHGBN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LPCPNKEMCNM()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator EOCBHNPFJLL()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator ELNHMAPENDB()
	{
		return new NKFONDFHGBN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator BJPDFDCOJKJ()
	{
		return new NKFONDFHGBN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator DABNLFBDKGN()
	{
		return new NKFONDFHGBN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HHLKPNANHKK()
	{
		return new NKFONDFHGBN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator IGFOJFFHNJF()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator JNOOAENGMHL()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator IAOFDDMPMBJ()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator JDEDKABEHJM()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator FGLMKBOMOBA()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator JHBNODHNMCI()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator OAIEBGHEBAK()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator PBEKBJIJFDK()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator GDOJMLFHCHD()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator HCKDBDMBMFL()
	{
		return new NKFONDFHGBN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator BLNKHNHGFPB()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JIFEIKLKIMF()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AJOIEAICINP()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator AFHGHLOCAPA()
	{
		return new NKFONDFHGBN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AOJFNNKFCBL()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator ODILJEKMFLO()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator OGOFIFJCMEB()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AEMAMJOHIOA()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator OOFDOHFANIE()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator IHBNOLLFNPA()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator HFKKGFOFLBJ()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator DIGIMPCLCCL()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator CPCGNMPLFHM()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator CAKPGBAIIPI()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator CNPIAJBODCG()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator HNFCACDCBBO()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator DNLEAJAPNOM()
	{
		return new NKFONDFHGBN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator FBCDFDFAILD()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator PPMPKJECPDE()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JEGFAKDNMIC()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator LFANGJJGBFG()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator HCKCEGEOJLO()
	{
		return new NKFONDFHGBN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JIJEDGBCENE()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	public override void SetUp()
	{
		base.SetUp();
		((MonoBehaviour)this).StartCoroutine(PBEKBJIJFDK());
		ResetMai();
	}

	private IEnumerator HGKFAONPGGB()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator IHGGOFFGMBD()
	{
		return new NKFONDFHGBN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator BAGKLMIFNIH()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}
}
