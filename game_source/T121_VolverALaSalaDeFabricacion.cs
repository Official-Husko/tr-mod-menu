using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class T121_VolverALaSalaDeFabricacion : TutorialPhaseBase
{
	[CompilerGenerated]
	private sealed class NKFONDFHGBN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T121_VolverALaSalaDeFabricacion _003C_003E4__this;

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
			T121_VolverALaSalaDeFabricacion t121_VolverALaSalaDeFabricacion = _003C_003E4__this;
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
				t121_VolverALaSalaDeFabricacion.LHKIJABBBPM();
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

		public T121_VolverALaSalaDeFabricacion _003C_003E4__this;

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
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			T121_VolverALaSalaDeFabricacion t121_VolverALaSalaDeFabricacion = _003C_003E4__this;
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
				((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(11.83333f, 916.5f, 0f);
				_003C_003E2__current = CommonReferences.wait02;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
				MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
				(SceneReferences.instance.crafterPlaceable[1].onlinePlaceable as OnlineCrafter).crafter.FinishCrafter();
				goto IL_00fc;
			case 3:
				_003C_003E1__state = -1;
				goto IL_00fc;
			case 4:
				_003C_003E1__state = -1;
				goto IL_013f;
			case 5:
				{
					_003C_003E1__state = -1;
					NewTutorialManager.instance.ObjectiveCompleted(0);
					((MonoBehaviour)t121_VolverALaSalaDeFabricacion).StartCoroutine(t121_VolverALaSalaDeFabricacion.LHDDHIJIFCN());
					return false;
				}
				IL_00fc:
				if (WorldTime.EDIPJBOOEHD > (float)(3 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.EDIPJBOOEHD < (float)(6 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 3;
					return true;
				}
				goto IL_013f;
				IL_013f:
				if (!t121_VolverALaSalaDeFabricacion.CLJJAIEMOLN())
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 4;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 5;
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

	private IEnumerator NHPCNDODFAK()
	{
		return new NKFONDFHGBN(1)
		{
			_003C_003E4__this = this
		};
	}

	public override int GetID()
	{
		return 121;
	}

	private IEnumerator IDGLEKCBIMF()
	{
		return new NKFONDFHGBN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NIKPIBICOPP()
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

	private IEnumerator HCCJFBLCABN()
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

	private IEnumerator HPNEFMANGHJ()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator CAKPGBAIIPI()
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

	private IEnumerator PBEKBJIJFDK()
	{
		yield return CommonReferences.wait05;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(11.83333f, 916.5f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		(SceneReferences.instance.crafterPlaceable[1].onlinePlaceable as OnlineCrafter).crafter.FinishCrafter();
		while (WorldTime.EDIPJBOOEHD > (float)(3 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.EDIPJBOOEHD < (float)(6 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR))
		{
			yield return null;
		}
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator FAEKOKEINEH()
	{
		return new DBHBDMOHMPM(1)
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

	private IEnumerator LHDDHIJIFCN()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator CLCOEDFCDPK()
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

	private IEnumerator CFGLAPAKKAL()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator DIGIMPCLCCL()
	{
		yield return CommonReferences.wait05;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(11.83333f, 916.5f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		(SceneReferences.instance.crafterPlaceable[1].onlinePlaceable as OnlineCrafter).crafter.FinishCrafter();
		while (WorldTime.EDIPJBOOEHD > (float)(3 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.EDIPJBOOEHD < (float)(6 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR))
		{
			yield return null;
		}
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}
}
