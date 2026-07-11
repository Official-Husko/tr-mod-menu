using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class T141_SalirFuera_122_123 : TutorialPhaseBase
{
	[CompilerGenerated]
	private sealed class NKFONDFHGBN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T141_SalirFuera_122_123 _003C_003E4__this;

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
			T141_SalirFuera_122_123 t141_SalirFuera_122_ = _003C_003E4__this;
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
				t141_SalirFuera_122_.LHKIJABBBPM();
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

		public T141_SalirFuera_122_123 _003C_003E4__this;

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
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			T141_SalirFuera_122_123 t141_SalirFuera_122_ = _003C_003E4__this;
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
				NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
				CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
				((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
				_003C_003E2__current = CommonReferences.wait02;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
				MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
				goto IL_00d8;
			case 3:
				_003C_003E1__state = -1;
				goto IL_00d8;
			case 4:
				{
					_003C_003E1__state = -1;
					NewTutorialManager.instance.ObjectiveCompleted(0);
					((MonoBehaviour)t141_SalirFuera_122_).StartCoroutine(t141_SalirFuera_122_.LHDDHIJIFCN());
					return false;
				}
				IL_00d8:
				if (!t141_SalirFuera_122_.MCKLEPHBECB())
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 3;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 4;
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

	private IEnumerator CNPPMBAKEBJ()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator LGDNIGIMDKP()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator FEEJKJJEEPO()
	{
		return new NKFONDFHGBN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator CIBIOLGHPJF()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator DIGIMPCLCCL()
	{
		yield return CommonReferences.wait05;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (!MCKLEPHBECB())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator LFKPHADFFDG()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HGFPMNKEMAC()
	{
		return new NKFONDFHGBN(1)
		{
			_003C_003E4__this = this
		};
	}

	public override void SetUp()
	{
		base.SetUp();
		((MonoBehaviour)this).StartCoroutine(PBEKBJIJFDK());
	}

	private IEnumerator AEMAMJOHIOA()
	{
		yield return CommonReferences.wait05;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (!MCKLEPHBECB())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator OOFDOHFANIE()
	{
		yield return CommonReferences.wait05;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (!MCKLEPHBECB())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator FBOBCKJGPMB()
	{
		yield return CommonReferences.wait05;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (!MCKLEPHBECB())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator ELPINNBKFIP()
	{
		return new NKFONDFHGBN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator PAJJMLCLHHK()
	{
		return new NKFONDFHGBN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator PBEKBJIJFDK()
	{
		yield return CommonReferences.wait05;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (!MCKLEPHBECB())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator HCCJFBLCABN()
	{
		return new NKFONDFHGBN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator CNPIAJBODCG()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LNNCIOJHJMK()
	{
		yield return CommonReferences.wait05;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (!MCKLEPHBECB())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator JHBNODHNMCI()
	{
		yield return CommonReferences.wait05;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (!MCKLEPHBECB())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	public override int GetID()
	{
		return 141;
	}

	private IEnumerator AKMGPONCFHL()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LKAGLINOIMK()
	{
		yield return CommonReferences.wait05;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (!MCKLEPHBECB())
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

	private IEnumerator LAMBONHALKD()
	{
		return new NKFONDFHGBN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator CAKPGBAIIPI()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator OBCHIKLEMKF()
	{
		yield return CommonReferences.wait05;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (!MCKLEPHBECB())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator CPCGNMPLFHM()
	{
		yield return CommonReferences.wait05;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (!MCKLEPHBECB())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator AOJFNNKFCBL()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator FGLMKBOMOBA()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HCKCEGEOJLO()
	{
		return new NKFONDFHGBN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator IDGLEKCBIMF()
	{
		return new NKFONDFHGBN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator CFGLAPAKKAL()
	{
		return new NKFONDFHGBN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator IAOFDDMPMBJ()
	{
		return new NKFONDFHGBN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NHPCNDODFAK()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator LFANGJJGBFG()
	{
		return new NKFONDFHGBN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator ODILJEKMFLO()
	{
		return new NKFONDFHGBN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator DABNLFBDKGN()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator GDOJMLFHCHD()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator FDMJPHBJACE()
	{
		return new NKFONDFHGBN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AJOIEAICINP()
	{
		yield return CommonReferences.wait05;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (!MCKLEPHBECB())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator LGODBMNLILN()
	{
		return new NKFONDFHGBN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HHDLDPPCLPE()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LHDDHIJIFCN()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator ELPDKDFFJJD()
	{
		yield return CommonReferences.wait05;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (!MCKLEPHBECB())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}
}
