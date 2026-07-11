using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class T115_Dormir : TutorialPhaseBase
{
	[CompilerGenerated]
	private sealed class BGBGBBECCHB : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T115_Dormir _003C_003E4__this;

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
		public BGBGBBECCHB(int _003C_003E1__state)
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
			T115_Dormir t115_Dormir = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				NewTutorialManager.instance.ObjectiveCompleted(1);
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				t115_Dormir.LHKIJABBBPM();
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

		public T115_Dormir _003C_003E4__this;

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
			//IL_0116: Unknown result type (might be due to invalid IL or missing references)
			//IL_011b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			//IL_012a: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Expected O, but got Unknown
			int num = _003C_003E1__state;
			T115_Dormir t115_Dormir = _003C_003E4__this;
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
				_003C_003E2__current = ((MonoBehaviour)t115_Dormir).StartCoroutine(t115_Dormir.CDICFNAMCEE());
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				Utils.OFHPCBLHJBL(0f, 1f);
				NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
				MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T115/Dialogue1", t115_Dormir.triggerPlayerNum);
				goto IL_00be;
			case 3:
				_003C_003E1__state = -1;
				goto IL_00be;
			case 4:
				{
					_003C_003E1__state = -1;
					Utils.OFHPCBLHJBL(1f, 1f);
					NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
					NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
					NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bed.instance).transform.position), Vector2.up * 0.6f, ref t115_Dormir.JELIKOFDONK);
					CommonReferences instance = CommonReferences.GGFJGHHHEJC;
					instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(t115_Dormir.CEHMCNPOEOL));
					TavernManager instance2 = TavernManager.GGFJGHHHEJC;
					instance2.OnTavernClose = (Action<int>)Delegate.Combine(instance2.OnTavernClose, new Action<int>(t115_Dormir.LOGAAGEKGOK));
					return false;
				}
				IL_00be:
				if (t115_Dormir.AAOPIEDAKKD(1))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 3;
					return true;
				}
				_003C_003E2__current = (object)new WaitForSecondsRealtime(1.5f);
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

	private IEnumerator LHDDHIJIFCN()
	{
		NewTutorialManager.instance.ObjectiveCompleted(1);
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void AIJEIABCLBL(int JIIGOACEIKL)
	{
		NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernClose = (Action<int>)Delegate.Remove(instance.OnTavernClose, new Action<int>(EONMBGIDHEP));
	}

	private void DMBOPDCMLHG()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(DMBOPDCMLHG));
		SceneReferences.CFAMKBHIGLO().humanCustomerPool.GetComponent<CustomerPool>().DNGMNICCPJM();
		SceneReferences.instance.humanCustomerPool.gameObject.SetActive(true);
		((Component)SceneReferences.instance.customerPool).gameObject.SetActive(false);
		Object.Destroy((Object)(object)JELIKOFDONK);
		((MonoBehaviour)this).StartCoroutine(CLCOEDFCDPK());
	}

	private IEnumerator JNOOAENGMHL()
	{
		return new BGBGBBECCHB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void EONMBGIDHEP(int JIIGOACEIKL)
	{
		NewTutorialManager.instance.FOIOHOGACAL(0);
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernClose = (Action<int>)Delegate.Remove(instance.OnTavernClose, new Action<int>(LOGAAGEKGOK));
	}

	public override int GetID()
	{
		return 115;
	}

	private IEnumerator HCCJFBLCABN()
	{
		return new BGBGBBECCHB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void KKENLFHBPOJ(int JIIGOACEIKL)
	{
		NewTutorialManager.instance.FOIOHOGACAL(0);
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernClose = (Action<int>)Delegate.Remove(instance.OnTavernClose, new Action<int>(AIJEIABCLBL));
	}

	private IEnumerator KCJAAGLPFEE()
	{
		return new BGBGBBECCHB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void HDFOOJPBNKM()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(IIFDKPOIOHK));
		SceneReferences.FAOPFMBMMJJ().humanCustomerPool.GetComponent<CustomerPool>().JNICKMPINEK();
		SceneReferences.instance.humanCustomerPool.gameObject.SetActive(false);
		((Component)SceneReferences.instance.customerPool).gameObject.SetActive(false);
		Object.Destroy((Object)(object)JELIKOFDONK);
		((MonoBehaviour)this).StartCoroutine(KCJAAGLPFEE());
	}

	private IEnumerator ODILJEKMFLO()
	{
		return new BGBGBBECCHB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator PBEKBJIJFDK()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		yield return CommonReferences.wait1;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T115/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return (object)new WaitForSecondsRealtime(1.5f);
		Utils.OFHPCBLHJBL(1f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bed.instance).transform.position), Vector2.up * 0.6f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Combine(instance.OnPlayerAwake, new Action(CEHMCNPOEOL));
		TavernManager instance2 = TavernManager.GGFJGHHHEJC;
		instance2.OnTavernClose = (Action<int>)Delegate.Combine(instance2.OnTavernClose, new Action<int>(LOGAAGEKGOK));
	}

	private void MKFGDGGJAHN()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(CEHMCNPOEOL));
		SceneReferences.FAOPFMBMMJJ().humanCustomerPool.GetComponent<CustomerPool>().DNGMNICCPJM();
		SceneReferences.instance.humanCustomerPool.gameObject.SetActive(false);
		((Component)SceneReferences.instance.customerPool).gameObject.SetActive(true);
		Object.Destroy((Object)(object)JELIKOFDONK);
		((MonoBehaviour)this).StartCoroutine(CLCOEDFCDPK());
	}

	private void IIFDKPOIOHK()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(AEENPHMPGLG));
		SceneReferences.CKDKHMPHENE().humanCustomerPool.GetComponent<CustomerPool>().DNGMNICCPJM();
		SceneReferences.instance.humanCustomerPool.gameObject.SetActive(false);
		((Component)SceneReferences.instance.customerPool).gameObject.SetActive(true);
		Object.Destroy((Object)(object)JELIKOFDONK);
		((MonoBehaviour)this).StartCoroutine(KCJAAGLPFEE());
	}

	public override void SetUp()
	{
		base.SetUp();
		((MonoBehaviour)this).StartCoroutine(PBEKBJIJFDK());
	}

	private void PGDJCKPGKOA()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(AEENPHMPGLG));
		SceneReferences.FAOPFMBMMJJ().humanCustomerPool.GetComponent<CustomerPool>().OEMMGMPPCIF();
		SceneReferences.instance.humanCustomerPool.gameObject.SetActive(false);
		((Component)SceneReferences.instance.customerPool).gameObject.SetActive(false);
		Object.Destroy((Object)(object)JELIKOFDONK);
		((MonoBehaviour)this).StartCoroutine(JNOOAENGMHL());
	}

	private void AEENPHMPGLG()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(CEHMCNPOEOL));
		SceneReferences.CKDKHMPHENE().humanCustomerPool.GetComponent<CustomerPool>().AMNGKAGAMJI();
		SceneReferences.instance.humanCustomerPool.gameObject.SetActive(true);
		((Component)SceneReferences.instance.customerPool).gameObject.SetActive(false);
		Object.Destroy((Object)(object)JELIKOFDONK);
		((MonoBehaviour)this).StartCoroutine(HCCJFBLCABN());
	}

	private void NFJNGDAGMCI(int JIIGOACEIKL)
	{
		NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernClose = (Action<int>)Delegate.Remove(instance.OnTavernClose, new Action<int>(NFJNGDAGMCI));
	}

	private void AANFEABGLEG()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(IIFDKPOIOHK));
		SceneReferences.GetSceneReferences().humanCustomerPool.GetComponent<CustomerPool>().AMNGKAGAMJI();
		SceneReferences.instance.humanCustomerPool.gameObject.SetActive(true);
		((Component)SceneReferences.instance.customerPool).gameObject.SetActive(false);
		Object.Destroy((Object)(object)JELIKOFDONK);
		((MonoBehaviour)this).StartCoroutine(AOJFNNKFCBL());
	}

	private IEnumerator AOJFNNKFCBL()
	{
		return new BGBGBBECCHB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void MCKMAIMMPHO()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(HDFOOJPBNKM));
		SceneReferences.GetSceneReferences().humanCustomerPool.GetComponent<CustomerPool>().OEMMGMPPCIF();
		SceneReferences.instance.humanCustomerPool.gameObject.SetActive(true);
		((Component)SceneReferences.instance.customerPool).gameObject.SetActive(false);
		Object.Destroy((Object)(object)JELIKOFDONK);
		((MonoBehaviour)this).StartCoroutine(HCCJFBLCABN());
	}

	private void HLJFLHAMFLJ()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(IIFDKPOIOHK));
		SceneReferences.CFAMKBHIGLO().humanCustomerPool.GetComponent<CustomerPool>().JNICKMPINEK();
		SceneReferences.instance.humanCustomerPool.gameObject.SetActive(false);
		((Component)SceneReferences.instance.customerPool).gameObject.SetActive(true);
		Object.Destroy((Object)(object)JELIKOFDONK);
		((MonoBehaviour)this).StartCoroutine(HCCJFBLCABN());
	}

	private void KHENNELIGFM(int JIIGOACEIKL)
	{
		NewTutorialManager.instance.FOIOHOGACAL(0);
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernClose = (Action<int>)Delegate.Remove(instance.OnTavernClose, new Action<int>(EONMBGIDHEP));
	}

	private void DFCNIAADEBM(int JIIGOACEIKL)
	{
		NewTutorialManager.instance.FOIOHOGACAL(1);
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernClose = (Action<int>)Delegate.Remove(instance.OnTavernClose, new Action<int>(FKPDFEKFLKI));
	}

	private void CEHMCNPOEOL()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerAwake = (Action)Delegate.Remove(instance.OnPlayerAwake, new Action(CEHMCNPOEOL));
		SceneReferences.GetSceneReferences().humanCustomerPool.GetComponent<CustomerPool>().DisableAllCustomers();
		SceneReferences.instance.humanCustomerPool.gameObject.SetActive(false);
		((Component)SceneReferences.instance.customerPool).gameObject.SetActive(true);
		Object.Destroy((Object)(object)JELIKOFDONK);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private void FKPDFEKFLKI(int JIIGOACEIKL)
	{
		NewTutorialManager.instance.FOIOHOGACAL(0);
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernClose = (Action<int>)Delegate.Remove(instance.OnTavernClose, new Action<int>(DFCNIAADEBM));
	}

	private IEnumerator JIFEIKLKIMF()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator CLCOEDFCDPK()
	{
		return new BGBGBBECCHB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void LOGAAGEKGOK(int JIIGOACEIKL)
	{
		NewTutorialManager.instance.ObjectiveCompleted(0);
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernClose = (Action<int>)Delegate.Remove(instance.OnTavernClose, new Action<int>(LOGAAGEKGOK));
	}
}
