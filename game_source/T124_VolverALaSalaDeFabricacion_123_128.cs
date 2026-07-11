using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class T124_VolverALaSalaDeFabricacion_123_128 : TutorialPhaseBase
{
	[CompilerGenerated]
	private sealed class NKFONDFHGBN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T124_VolverALaSalaDeFabricacion_123_128 _003C_003E4__this;

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
			T124_VolverALaSalaDeFabricacion_123_128 t124_VolverALaSalaDeFabricacion_123_ = _003C_003E4__this;
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
				t124_VolverALaSalaDeFabricacion_123_.LHKIJABBBPM();
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

		public T124_VolverALaSalaDeFabricacion_123_128 _003C_003E4__this;

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
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			T124_VolverALaSalaDeFabricacion_123_128 t124_VolverALaSalaDeFabricacion_123_ = _003C_003E4__this;
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
				NewTutorialManager.instance.agingBarrelBlocked = true;
				((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(11.83333f, 916.5f, 0f);
				_003C_003E2__current = CommonReferences.wait02;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
				MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
				(SceneReferences.instance.crafterPlaceable[2].onlinePlaceable as OnlineCrafter).crafter.FinishCrafter();
				break;
			case 3:
				_003C_003E1__state = -1;
				break;
			}
			if (!t124_VolverALaSalaDeFabricacion_123_.CLJJAIEMOLN())
			{
				_003C_003E2__current = null;
				_003C_003E1__state = 3;
				return true;
			}
			NewTutorialManager.instance.ObjectiveCompleted(0);
			((MonoBehaviour)t124_VolverALaSalaDeFabricacion_123_).StartCoroutine(t124_VolverALaSalaDeFabricacion_123_.LHDDHIJIFCN());
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

	private IEnumerator AJJHBJHCACM()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator ELPDKDFFJJD()
	{
		yield return CommonReferences.wait05;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		NewTutorialManager.instance.agingBarrelBlocked = true;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(11.83333f, 916.5f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		(SceneReferences.instance.crafterPlaceable[2].onlinePlaceable as OnlineCrafter).crafter.FinishCrafter();
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator IHBNOLLFNPA()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator BAGKLMIFNIH()
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

	private IEnumerator OCHEOJEEFGA()
	{
		return new NKFONDFHGBN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JDEDKABEHJM()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HCKDBDMBMFL()
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

	private IEnumerator OCCLCKFAILK()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
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
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator CPCGNMPLFHM()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AAGGGIONDAG()
	{
		yield return CommonReferences.wait05;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		NewTutorialManager.instance.agingBarrelBlocked = true;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(11.83333f, 916.5f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		(SceneReferences.instance.crafterPlaceable[2].onlinePlaceable as OnlineCrafter).crafter.FinishCrafter();
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator EHGECAFMHEA()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator BGFNCKGFJPG()
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

	private IEnumerator LFKPHADFFDG()
	{
		yield return CommonReferences.wait05;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		NewTutorialManager.instance.agingBarrelBlocked = true;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(11.83333f, 916.5f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		(SceneReferences.instance.crafterPlaceable[2].onlinePlaceable as OnlineCrafter).crafter.FinishCrafter();
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator DABNLFBDKGN()
	{
		return new NKFONDFHGBN(1)
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

	private IEnumerator LPNNMDOPCCJ()
	{
		yield return CommonReferences.wait05;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		NewTutorialManager.instance.agingBarrelBlocked = true;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(11.83333f, 916.5f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		(SceneReferences.instance.crafterPlaceable[2].onlinePlaceable as OnlineCrafter).crafter.FinishCrafter();
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator CKIMLLCOEGC()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator PDAEFKAMACE()
	{
		return new NKFONDFHGBN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator CNPPMBAKEBJ()
	{
		return new NKFONDFHGBN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator OPCHFFMKPCN()
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

	private IEnumerator LHDDHIJIFCN()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator AJOIEAICINP()
	{
		yield return CommonReferences.wait05;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		NewTutorialManager.instance.agingBarrelBlocked = true;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(11.83333f, 916.5f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		(SceneReferences.instance.crafterPlaceable[2].onlinePlaceable as OnlineCrafter).crafter.FinishCrafter();
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator ANLLGDBMBAE()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator LPCPNKEMCNM()
	{
		return new NKFONDFHGBN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AEMAMJOHIOA()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator BBGHMMLBAME()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator KNBNIMCHKIE()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator NCNGHNLFCBO()
	{
		yield return CommonReferences.wait05;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		NewTutorialManager.instance.agingBarrelBlocked = true;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(11.83333f, 916.5f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		(SceneReferences.instance.crafterPlaceable[2].onlinePlaceable as OnlineCrafter).crafter.FinishCrafter();
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator IGEOMOOKOEP()
	{
		yield return CommonReferences.wait05;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		NewTutorialManager.instance.agingBarrelBlocked = true;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(11.83333f, 916.5f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		(SceneReferences.instance.crafterPlaceable[2].onlinePlaceable as OnlineCrafter).crafter.FinishCrafter();
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator GFMGFHGPGCM()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator FPIHNICAJHI()
	{
		yield return CommonReferences.wait05;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		NewTutorialManager.instance.agingBarrelBlocked = true;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(11.83333f, 916.5f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		(SceneReferences.instance.crafterPlaceable[2].onlinePlaceable as OnlineCrafter).crafter.FinishCrafter();
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator NIKPIBICOPP()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator MLAOLHNEEJC()
	{
		yield return CommonReferences.wait05;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		NewTutorialManager.instance.agingBarrelBlocked = true;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(11.83333f, 916.5f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		(SceneReferences.instance.crafterPlaceable[2].onlinePlaceable as OnlineCrafter).crafter.FinishCrafter();
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator LNNCIOJHJMK()
	{
		yield return CommonReferences.wait05;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		NewTutorialManager.instance.agingBarrelBlocked = true;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(11.83333f, 916.5f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		(SceneReferences.instance.crafterPlaceable[2].onlinePlaceable as OnlineCrafter).crafter.FinishCrafter();
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator PPMPKJECPDE()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator FBOBCKJGPMB()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator KGIJEMPBBED()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator GGACDGHOJEF()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator BCALBKDNAJH()
	{
		yield return CommonReferences.wait05;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		NewTutorialManager.instance.agingBarrelBlocked = true;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(11.83333f, 916.5f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		(SceneReferences.instance.crafterPlaceable[2].onlinePlaceable as OnlineCrafter).crafter.FinishCrafter();
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator OBCHIKLEMKF()
	{
		yield return CommonReferences.wait05;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		NewTutorialManager.instance.agingBarrelBlocked = true;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(11.83333f, 916.5f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		(SceneReferences.instance.crafterPlaceable[2].onlinePlaceable as OnlineCrafter).crafter.FinishCrafter();
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
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

	private IEnumerator LAMBONHALKD()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator CCOGIOADJKC()
	{
		yield return CommonReferences.wait05;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		NewTutorialManager.instance.agingBarrelBlocked = true;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(11.83333f, 916.5f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		(SceneReferences.instance.crafterPlaceable[2].onlinePlaceable as OnlineCrafter).crafter.FinishCrafter();
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	public override int GetID()
	{
		return 124;
	}

	private IEnumerator JCKBLHHGOHC()
	{
		return new NKFONDFHGBN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator BCNPEOJDCIF()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator IGFOJFFHNJF()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HNFCACDCBBO()
	{
		return new NKFONDFHGBN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator BOMICOPCCML()
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
		NewTutorialManager.instance.agingBarrelBlocked = true;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(11.83333f, 916.5f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		(SceneReferences.instance.crafterPlaceable[2].onlinePlaceable as OnlineCrafter).crafter.FinishCrafter();
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator FGLMKBOMOBA()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NHPCNDODFAK()
	{
		return new NKFONDFHGBN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator OGOFIFJCMEB()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JKFNHFDPOJN()
	{
		yield return CommonReferences.wait05;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		NewTutorialManager.instance.agingBarrelBlocked = true;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(11.83333f, 916.5f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		(SceneReferences.instance.crafterPlaceable[2].onlinePlaceable as OnlineCrafter).crafter.FinishCrafter();
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator FEEJKJJEEPO()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator AAOCEAKDPDK()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator PBPKJEAAGFE()
	{
		yield return CommonReferences.wait05;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		NewTutorialManager.instance.agingBarrelBlocked = true;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(11.83333f, 916.5f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		(SceneReferences.instance.crafterPlaceable[2].onlinePlaceable as OnlineCrafter).crafter.FinishCrafter();
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator LGDNIGIMDKP()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator GDOJMLFHCHD()
	{
		yield return CommonReferences.wait05;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		NewTutorialManager.instance.agingBarrelBlocked = true;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(11.83333f, 916.5f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		(SceneReferences.instance.crafterPlaceable[2].onlinePlaceable as OnlineCrafter).crafter.FinishCrafter();
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
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

	private IEnumerator NLCIHJDPGFE()
	{
		yield return CommonReferences.wait05;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		NewTutorialManager.instance.agingBarrelBlocked = true;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(11.83333f, 916.5f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		(SceneReferences.instance.crafterPlaceable[2].onlinePlaceable as OnlineCrafter).crafter.FinishCrafter();
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
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

	private IEnumerator HHDLDPPCLPE()
	{
		yield return CommonReferences.wait05;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		NewTutorialManager.instance.agingBarrelBlocked = true;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(11.83333f, 916.5f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		(SceneReferences.instance.crafterPlaceable[2].onlinePlaceable as OnlineCrafter).crafter.FinishCrafter();
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator MGHHGMLMMJC()
	{
		return new NKFONDFHGBN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LKAGLINOIMK()
	{
		yield return CommonReferences.wait05;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		NewTutorialManager.instance.agingBarrelBlocked = true;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(11.83333f, 916.5f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		(SceneReferences.instance.crafterPlaceable[2].onlinePlaceable as OnlineCrafter).crafter.FinishCrafter();
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator ADFMBGJOMKK()
	{
		yield return CommonReferences.wait05;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		NewTutorialManager.instance.agingBarrelBlocked = true;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(11.83333f, 916.5f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		(SceneReferences.instance.crafterPlaceable[2].onlinePlaceable as OnlineCrafter).crafter.FinishCrafter();
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator ODILJEKMFLO()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator PIHPPADDGMG()
	{
		yield return CommonReferences.wait05;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		NewTutorialManager.instance.agingBarrelBlocked = true;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(11.83333f, 916.5f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		(SceneReferences.instance.crafterPlaceable[2].onlinePlaceable as OnlineCrafter).crafter.FinishCrafter();
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator FCJODFOFODL()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator EHDIMBMCIDK()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator GACJBLGDMFG()
	{
		return new NKFONDFHGBN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator MIGPNMAOJPK()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator DNAAOCABLNF()
	{
		yield return CommonReferences.wait05;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		NewTutorialManager.instance.agingBarrelBlocked = true;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(11.83333f, 916.5f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		(SceneReferences.instance.crafterPlaceable[2].onlinePlaceable as OnlineCrafter).crafter.FinishCrafter();
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}
}
