using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class T142_SalirFuera_129_130 : TutorialPhaseBase
{
	[CompilerGenerated]
	private sealed class NKFONDFHGBN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T142_SalirFuera_129_130 _003C_003E4__this;

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
			T142_SalirFuera_129_130 t142_SalirFuera_129_ = _003C_003E4__this;
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
				t142_SalirFuera_129_.LHKIJABBBPM();
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

		public T142_SalirFuera_129_130 _003C_003E4__this;

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
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_013c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0141: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			T142_SalirFuera_129_130 t142_SalirFuera_129_ = _003C_003E4__this;
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
				((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(16.35417f, 918.1458f, 0f);
				_003C_003E2__current = CommonReferences.wait02;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
				MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
				goto IL_00de;
			case 3:
				_003C_003E1__state = -1;
				goto IL_00de;
			case 4:
				_003C_003E1__state = -1;
				MaiNPC.SetBool("Disabled", AODONKKHPBP: false);
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 5;
				return true;
			case 5:
				_003C_003E1__state = -1;
				DialogueCameraTarget.GetPlayer(t142_SalirFuera_129_.triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
				MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T129/Dialogue2", t142_SalirFuera_129_.triggerPlayerNum);
				goto IL_017c;
			case 6:
				_003C_003E1__state = -1;
				goto IL_017c;
			case 7:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 8;
				return true;
			case 8:
				_003C_003E1__state = -1;
				NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
				MaiNPC.GGFJGHHHEJC.SetParentToNull();
				((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
				_003C_003E2__current = CommonReferences.wait02;
				_003C_003E1__state = 9;
				return true;
			case 9:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
				MaiNPC.SetBool("Disabled", AODONKKHPBP: true);
				t142_SalirFuera_129_.CPMMKKOCDML();
				goto IL_0259;
			case 10:
				_003C_003E1__state = -1;
				goto IL_0259;
			case 11:
				{
					_003C_003E1__state = -1;
					NewTutorialManager.instance.ObjectiveCompleted(0);
					((MonoBehaviour)t142_SalirFuera_129_).StartCoroutine(t142_SalirFuera_129_.LHDDHIJIFCN());
					return false;
				}
				IL_0259:
				if (!t142_SalirFuera_129_.MCKLEPHBECB())
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 10;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 11;
				return true;
				IL_00de:
				if (t142_SalirFuera_129_.AOOKIKFINFB())
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 3;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 4;
				return true;
				IL_017c:
				if (t142_SalirFuera_129_.AAOPIEDAKKD(1))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 6;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 7;
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

	private IEnumerator AEMAMJOHIOA()
	{
		yield return CommonReferences.wait2;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(16.35417f, 918.1458f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (AOOKIKFINFB())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		MaiNPC.SetBool("Disabled", AODONKKHPBP: false);
		yield return CommonReferences.wait1;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T129/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		MaiNPC.GGFJGHHHEJC.SetParentToNull();
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.SetBool("Disabled", AODONKKHPBP: true);
		CPMMKKOCDML();
		while (!MCKLEPHBECB())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator DABNLFBDKGN()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator HGFPMNKEMAC()
	{
		return new NKFONDFHGBN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HFKKGFOFLBJ()
	{
		return new NKFONDFHGBN(1)
		{
			_003C_003E4__this = this
		};
	}

	public override int GetID()
	{
		return 142;
	}

	private IEnumerator FAEKOKEINEH()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator OBCHIKLEMKF()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NHPCNDODFAK()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator HCCJFBLCABN()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator DIGIMPCLCCL()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator FGLMKBOMOBA()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator OOFDOHFANIE()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator DECKMELAPMA()
	{
		yield return CommonReferences.wait2;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(16.35417f, 918.1458f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (AOOKIKFINFB())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		MaiNPC.SetBool("Disabled", AODONKKHPBP: false);
		yield return CommonReferences.wait1;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T129/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		MaiNPC.GGFJGHHHEJC.SetParentToNull();
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.SetBool("Disabled", AODONKKHPBP: true);
		CPMMKKOCDML();
		while (!MCKLEPHBECB())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator OOGKJFJEHFO()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator IDGLEKCBIMF()
	{
		return new NKFONDFHGBN(1)
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

	public override void SetUp()
	{
		base.SetUp();
		((MonoBehaviour)this).StartCoroutine(PBEKBJIJFDK());
	}

	private IEnumerator LHDDHIJIFCN()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator IHGGOFFGMBD()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator PBEKBJIJFDK()
	{
		yield return CommonReferences.wait2;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(16.35417f, 918.1458f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (AOOKIKFINFB())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		MaiNPC.SetBool("Disabled", AODONKKHPBP: false);
		yield return CommonReferences.wait1;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T129/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		MaiNPC.GGFJGHHHEJC.SetParentToNull();
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.SetBool("Disabled", AODONKKHPBP: true);
		CPMMKKOCDML();
		while (!MCKLEPHBECB())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator HHDLDPPCLPE()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NCNGHNLFCBO()
	{
		yield return CommonReferences.wait2;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(16.35417f, 918.1458f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (AOOKIKFINFB())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		MaiNPC.SetBool("Disabled", AODONKKHPBP: false);
		yield return CommonReferences.wait1;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T129/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		MaiNPC.GGFJGHHHEJC.SetParentToNull();
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.SetBool("Disabled", AODONKKHPBP: true);
		CPMMKKOCDML();
		while (!MCKLEPHBECB())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator CAKPGBAIIPI()
	{
		return new NKFONDFHGBN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator BLHFOAMKOAH()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator FBOBCKJGPMB()
	{
		yield return CommonReferences.wait2;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(16.35417f, 918.1458f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (AOOKIKFINFB())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		MaiNPC.SetBool("Disabled", AODONKKHPBP: false);
		yield return CommonReferences.wait1;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T129/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		MaiNPC.GGFJGHHHEJC.SetParentToNull();
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.SetBool("Disabled", AODONKKHPBP: true);
		CPMMKKOCDML();
		while (!MCKLEPHBECB())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator CFGLAPAKKAL()
	{
		return new NKFONDFHGBN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator KCJAAGLPFEE()
	{
		return new NKFONDFHGBN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AJOIEAICINP()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator ODILJEKMFLO()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator AOJFNNKFCBL()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}
}
