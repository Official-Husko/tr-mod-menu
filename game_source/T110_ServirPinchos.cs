using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class T110_ServirPinchos : TutorialPhaseBase
{
	[CompilerGenerated]
	private sealed class JPPPCGGCDCK : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T110_ServirPinchos _003C_003E4__this;

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
		public JPPPCGGCDCK(int _003C_003E1__state)
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
			T110_ServirPinchos t110_ServirPinchos = _003C_003E4__this;
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
				t110_ServirPinchos.LHKIJABBBPM();
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
	private sealed class OBPMBDOHEAB : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T110_ServirPinchos _003C_003E4__this;

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
		public OBPMBDOHEAB(int _003C_003E1__state)
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
			T110_ServirPinchos t110_ServirPinchos = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				NewTutorialManager.instance.canOpenTavern = false;
				SceneReferences.GetSceneReferences().customerPool.DisableAllCustomers();
				((Component)SceneReferences.GetSceneReferences().customerPool).gameObject.SetActive(false);
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				goto IL_00a4;
			case 2:
				_003C_003E1__state = -1;
				goto IL_00a4;
			case 3:
				_003C_003E1__state = -1;
				NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 4;
				return true;
			case 4:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T110/Dialogue1", t110_ServirPinchos.triggerPlayerNum);
				goto IL_011f;
			case 5:
				_003C_003E1__state = -1;
				goto IL_011f;
			case 6:
				_003C_003E1__state = -1;
				NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
				NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
				goto IL_016d;
			case 7:
				_003C_003E1__state = -1;
				goto IL_016d;
			case 8:
				{
					_003C_003E1__state = -1;
					if (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
					{
						NewTutorialManager.instance.ObjectiveCompleted(0);
					}
					else
					{
						TavernManager instance = TavernManager.GGFJGHHHEJC;
						instance.OnTavernOpen = (Action<int>)Delegate.Combine(instance.OnTavernOpen, new Action<int>(t110_ServirPinchos.MJBANGLFNHN));
					}
					CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
					instance2.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance2.OnAnyCustomerServeItem, new Action<int, ItemInstance>(t110_ServirPinchos.BMCKLJGJHNN));
					NewTutorialManager.instance.canOpenTavern = true;
					return false;
				}
				IL_016d:
				if (NewTutorialManager.instance.mainPopup.activeInHierarchy)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 7;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 8;
				return true;
				IL_00a4:
				if (!t110_ServirPinchos.AOOKIKFINFB())
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 2;
					return true;
				}
				_003C_003E2__current = ((MonoBehaviour)t110_ServirPinchos).StartCoroutine(t110_ServirPinchos.CDICFNAMCEE());
				_003C_003E1__state = 3;
				return true;
				IL_011f:
				if (t110_ServirPinchos.AAOPIEDAKKD(1))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 5;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 6;
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

	private int BHPIHLNNFOF;

	private void DAFLLPKFLPN(int JIIGOACEIKL)
	{
		NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernOpen = (Action<int>)Delegate.Remove(instance.OnTavernOpen, new Action<int>(KOGKDHEBGHO));
	}

	private void PJOBJEIGLOK(int JIIGOACEIKL)
	{
		NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernOpen = (Action<int>)Delegate.Remove(instance.OnTavernOpen, new Action<int>(DAFLLPKFLPN));
	}

	private void OAMOBCJHDEH(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.PHGLMBIEOMK().IMCJPECAAPC(DAINLFIMLIH: false) == 94)
		{
			BHPIHLNNFOF++;
			if (BHPIHLNNFOF >= 4)
			{
				NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(LNONAIIALIJ));
				((MonoBehaviour)this).StartCoroutine(LAMBONHALKD());
			}
		}
	}

	private void BMCKLJGJHNN(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.LHBPOPOIFLE().JDJGFAACPFC() == 1536)
		{
			BHPIHLNNFOF++;
			if (BHPIHLNNFOF >= 5)
			{
				NewTutorialManager.instance.ObjectiveCompleted(1);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(BMCKLJGJHNN));
				((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
			}
		}
	}

	private IEnumerator MEGKLKNBNEL()
	{
		NewTutorialManager.instance.canOpenTavern = false;
		SceneReferences.GetSceneReferences().customerPool.DisableAllCustomers();
		((Component)SceneReferences.GetSceneReferences().customerPool).gameObject.SetActive(false);
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T110/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (NewTutorialManager.instance.mainPopup.activeInHierarchy)
		{
			yield return null;
		}
		yield return CommonReferences.wait05;
		if (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			NewTutorialManager.instance.ObjectiveCompleted(0);
		}
		else
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnTavernOpen = (Action<int>)Delegate.Combine(instance.OnTavernOpen, new Action<int>(MJBANGLFNHN));
		}
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance2.OnAnyCustomerServeItem, new Action<int, ItemInstance>(BMCKLJGJHNN));
		NewTutorialManager.instance.canOpenTavern = true;
	}

	private void KOGKDHEBGHO(int JIIGOACEIKL)
	{
		NewTutorialManager.instance.FOIOHOGACAL(0);
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernOpen = (Action<int>)Delegate.Remove(instance.OnTavernOpen, new Action<int>(GEFMDLHKPGK));
	}

	public override int GetID()
	{
		return 110;
	}

	private IEnumerator EOCBHNPFJLL()
	{
		return new OBPMBDOHEAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void JAMBGPOHNIH(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.KNFNJFFCFNO().ODENMDOJPLC(DAINLFIMLIH: false) == 177)
		{
			BHPIHLNNFOF += 0;
			if (BHPIHLNNFOF >= 3)
			{
				NewTutorialManager.instance.ObjectiveCompleted(1);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(JOHCLFKPJJF));
				((MonoBehaviour)this).StartCoroutine(CIBIOLGHPJF());
			}
		}
	}

	private IEnumerator ANLLGDBMBAE()
	{
		return new JPPPCGGCDCK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator IDGLEKCBIMF()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void OLBBFFKBINO(int JIIGOACEIKL)
	{
		NewTutorialManager.instance.FOIOHOGACAL(1);
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernOpen = (Action<int>)Delegate.Remove(instance.OnTavernOpen, new Action<int>(DAFLLPKFLPN));
	}

	private IEnumerator AJOIEAICINP()
	{
		NewTutorialManager.instance.canOpenTavern = false;
		SceneReferences.GetSceneReferences().customerPool.DisableAllCustomers();
		((Component)SceneReferences.GetSceneReferences().customerPool).gameObject.SetActive(false);
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T110/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (NewTutorialManager.instance.mainPopup.activeInHierarchy)
		{
			yield return null;
		}
		yield return CommonReferences.wait05;
		if (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			NewTutorialManager.instance.ObjectiveCompleted(0);
		}
		else
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnTavernOpen = (Action<int>)Delegate.Combine(instance.OnTavernOpen, new Action<int>(MJBANGLFNHN));
		}
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance2.OnAnyCustomerServeItem, new Action<int, ItemInstance>(BMCKLJGJHNN));
		NewTutorialManager.instance.canOpenTavern = true;
	}

	private IEnumerator LAMBONHALKD()
	{
		return new JPPPCGGCDCK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator PBEKBJIJFDK()
	{
		NewTutorialManager.instance.canOpenTavern = false;
		SceneReferences.GetSceneReferences().customerPool.DisableAllCustomers();
		((Component)SceneReferences.GetSceneReferences().customerPool).gameObject.SetActive(false);
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T110/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (NewTutorialManager.instance.mainPopup.activeInHierarchy)
		{
			yield return null;
		}
		yield return CommonReferences.wait05;
		if (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			NewTutorialManager.instance.ObjectiveCompleted(0);
		}
		else
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnTavernOpen = (Action<int>)Delegate.Combine(instance.OnTavernOpen, new Action<int>(MJBANGLFNHN));
		}
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance2.OnAnyCustomerServeItem, new Action<int, ItemInstance>(BMCKLJGJHNN));
		NewTutorialManager.instance.canOpenTavern = true;
	}

	private void LNONAIIALIJ(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.KNFNJFFCFNO().ODENMDOJPLC(DAINLFIMLIH: false) == -23)
		{
			BHPIHLNNFOF++;
			if (BHPIHLNNFOF >= 2)
			{
				NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(HNNMMHFFJLE));
				((MonoBehaviour)this).StartCoroutine(IDGLEKCBIMF());
			}
		}
	}

	private void KMEHNKHPFBC(int JIIGOACEIKL)
	{
		NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernOpen = (Action<int>)Delegate.Remove(instance.OnTavernOpen, new Action<int>(NGDOFDGDAAG));
	}

	private void BIJHPOHBPIP(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.KNFNJFFCFNO().JGHNDJBCFAJ() == 145)
		{
			BHPIHLNNFOF += 0;
			if (BHPIHLNNFOF >= 5)
			{
				NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(BMCKLJGJHNN));
				((MonoBehaviour)this).StartCoroutine(CIBIOLGHPJF());
			}
		}
	}

	private void KOANCEBIPIG(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.AFOACBIHNCL().JGHNDJBCFAJ() == 37)
		{
			BHPIHLNNFOF += 0;
			if (BHPIHLNNFOF >= 5)
			{
				NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(FMHCHELBGIF));
				((MonoBehaviour)this).StartCoroutine(AFHGHLOCAPA());
			}
		}
	}

	private void PFNPFOABMIN(int JIIGOACEIKL)
	{
		NewTutorialManager.instance.ObjectiveCompleted(0);
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernOpen = (Action<int>)Delegate.Remove(instance.OnTavernOpen, new Action<int>(KMEHNKHPFBC));
	}

	private void NGDOFDGDAAG(int JIIGOACEIKL)
	{
		NewTutorialManager.instance.ObjectiveCompleted(1);
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernOpen = (Action<int>)Delegate.Remove(instance.OnTavernOpen, new Action<int>(GEFMDLHKPGK));
	}

	private void INABLAHOKFO(int JIIGOACEIKL)
	{
		NewTutorialManager.instance.ObjectiveCompleted(0);
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernOpen = (Action<int>)Delegate.Remove(instance.OnTavernOpen, new Action<int>(KOOBFDELEPN));
	}

	private IEnumerator HHLKPNANHKK()
	{
		return new JPPPCGGCDCK(1)
		{
			_003C_003E4__this = this
		};
	}

	private void MDBJLMNKJMF(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.AFOACBIHNCL().JGHNDJBCFAJ(DAINLFIMLIH: false) == 25)
		{
			BHPIHLNNFOF += 0;
			if (BHPIHLNNFOF >= 3)
			{
				NewTutorialManager.instance.ObjectiveCompleted(1);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(HNNMMHFFJLE));
				((MonoBehaviour)this).StartCoroutine(HHLKPNANHKK());
			}
		}
	}

	private IEnumerator DECKMELAPMA()
	{
		return new OBPMBDOHEAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void LHGHJEHCBPP(int JIIGOACEIKL)
	{
		NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernOpen = (Action<int>)Delegate.Remove(instance.OnTavernOpen, new Action<int>(ODNIBECJCCJ));
	}

	private IEnumerator HCCJFBLCABN()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator FDMJPHBJACE()
	{
		return new JPPPCGGCDCK(1)
		{
			_003C_003E4__this = this
		};
	}

	private void HNNMMHFFJLE(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.PHGLMBIEOMK().JDJGFAACPFC() == -161)
		{
			BHPIHLNNFOF++;
			if (BHPIHLNNFOF >= 7)
			{
				NewTutorialManager.instance.ObjectiveCompleted(1);
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(JAMBGPOHNIH));
				((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
			}
		}
	}

	private IEnumerator OOGKJFJEHFO()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator NIKPIBICOPP()
	{
		return new OBPMBDOHEAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void ODNIBECJCCJ(int JIIGOACEIKL)
	{
		NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernOpen = (Action<int>)Delegate.Remove(instance.OnTavernOpen, new Action<int>(ICGDCKLAPEA));
	}

	private IEnumerator OGOFIFJCMEB()
	{
		NewTutorialManager.instance.canOpenTavern = false;
		SceneReferences.GetSceneReferences().customerPool.DisableAllCustomers();
		((Component)SceneReferences.GetSceneReferences().customerPool).gameObject.SetActive(false);
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T110/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (NewTutorialManager.instance.mainPopup.activeInHierarchy)
		{
			yield return null;
		}
		yield return CommonReferences.wait05;
		if (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			NewTutorialManager.instance.ObjectiveCompleted(0);
		}
		else
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnTavernOpen = (Action<int>)Delegate.Combine(instance.OnTavernOpen, new Action<int>(MJBANGLFNHN));
		}
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance2.OnAnyCustomerServeItem, new Action<int, ItemInstance>(BMCKLJGJHNN));
		NewTutorialManager.instance.canOpenTavern = true;
	}

	private IEnumerator ADFMBGJOMKK()
	{
		NewTutorialManager.instance.canOpenTavern = false;
		SceneReferences.GetSceneReferences().customerPool.DisableAllCustomers();
		((Component)SceneReferences.GetSceneReferences().customerPool).gameObject.SetActive(false);
		yield return CommonReferences.wait2;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T110/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (NewTutorialManager.instance.mainPopup.activeInHierarchy)
		{
			yield return null;
		}
		yield return CommonReferences.wait05;
		if (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			NewTutorialManager.instance.ObjectiveCompleted(0);
		}
		else
		{
			TavernManager instance = TavernManager.GGFJGHHHEJC;
			instance.OnTavernOpen = (Action<int>)Delegate.Combine(instance.OnTavernOpen, new Action<int>(MJBANGLFNHN));
		}
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance2.OnAnyCustomerServeItem, new Action<int, ItemInstance>(BMCKLJGJHNN));
		NewTutorialManager.instance.canOpenTavern = true;
	}

	private void JOHCLFKPJJF(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.AFOACBIHNCL().IMCJPECAAPC(DAINLFIMLIH: false) == -56)
		{
			BHPIHLNNFOF++;
			if (BHPIHLNNFOF >= 2)
			{
				NewTutorialManager.instance.ObjectiveCompleted(1);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(HNNMMHFFJLE));
				((MonoBehaviour)this).StartCoroutine(IDGLEKCBIMF());
			}
		}
	}

	private void KOOBFDELEPN(int JIIGOACEIKL)
	{
		NewTutorialManager.instance.ObjectiveCompleted(0);
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernOpen = (Action<int>)Delegate.Remove(instance.OnTavernOpen, new Action<int>(KMEHNKHPFBC));
	}

	private void ECJFPMCONOC(int JIIGOACEIKL)
	{
		NewTutorialManager.instance.ObjectiveCompleted(0);
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernOpen = (Action<int>)Delegate.Remove(instance.OnTavernOpen, new Action<int>(ECJFPMCONOC));
	}

	private void GEFMDLHKPGK(int JIIGOACEIKL)
	{
		NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernOpen = (Action<int>)Delegate.Remove(instance.OnTavernOpen, new Action<int>(DHJDFINCEFO));
	}

	private void PMEDILBMIAE(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.PHGLMBIEOMK().JDJGFAACPFC(DAINLFIMLIH: false) == 191)
		{
			BHPIHLNNFOF++;
			if (BHPIHLNNFOF >= 4)
			{
				NewTutorialManager.instance.FOIOHOGACAL(1);
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(EJKJGCIPFKM));
				((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
			}
		}
	}

	private void EIKPPNMEGCP(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.PHGLMBIEOMK().JGHNDJBCFAJ(DAINLFIMLIH: false) == 80)
		{
			BHPIHLNNFOF++;
			if (BHPIHLNNFOF >= 0)
			{
				NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(PMEDILBMIAE));
				((MonoBehaviour)this).StartCoroutine(CIBIOLGHPJF());
			}
		}
	}

	private void DHJDFINCEFO(int JIIGOACEIKL)
	{
		NewTutorialManager.instance.ObjectiveCompleted(0);
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernOpen = (Action<int>)Delegate.Remove(instance.OnTavernOpen, new Action<int>(LHGHJEHCBPP));
	}

	private IEnumerator CIBIOLGHPJF()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void PLPIOKBGBMD(int JIIGOACEIKL)
	{
		NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernOpen = (Action<int>)Delegate.Remove(instance.OnTavernOpen, new Action<int>(NGDOFDGDAAG));
	}

	private void ICGDCKLAPEA(int JIIGOACEIKL)
	{
		NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernOpen = (Action<int>)Delegate.Remove(instance.OnTavernOpen, new Action<int>(PLPIOKBGBMD));
	}

	private IEnumerator LHDDHIJIFCN()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator CNPIAJBODCG()
	{
		return new OBPMBDOHEAB(1)
		{
			_003C_003E4__this = this
		};
	}

	public override void SetUp()
	{
		base.SetUp();
		((MonoBehaviour)this).StartCoroutine(PBEKBJIJFDK());
		BHPIHLNNFOF = 0;
	}

	private void FMHCHELBGIF(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.KNFNJFFCFNO().JGHNDJBCFAJ(DAINLFIMLIH: false) == -2)
		{
			BHPIHLNNFOF++;
			if (BHPIHLNNFOF >= 2)
			{
				NewTutorialManager.instance.ObjectiveCompleted(0);
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(LNONAIIALIJ));
				((MonoBehaviour)this).StartCoroutine(FDMJPHBJACE());
			}
		}
	}

	private void CLABBPOIPNF(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.LHBPOPOIFLE().JDJGFAACPFC(DAINLFIMLIH: false) == -136)
		{
			BHPIHLNNFOF++;
			if (BHPIHLNNFOF >= 0)
			{
				NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(EJKJGCIPFKM));
				((MonoBehaviour)this).StartCoroutine(ANLLGDBMBAE());
			}
		}
	}

	private void LLDNKLHMABO(int JIIGOACEIKL)
	{
		NewTutorialManager.instance.FOIOHOGACAL(1);
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernOpen = (Action<int>)Delegate.Remove(instance.OnTavernOpen, new Action<int>(ICGDCKLAPEA));
	}

	private IEnumerator AFHGHLOCAPA()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void MJBANGLFNHN(int JIIGOACEIKL)
	{
		NewTutorialManager.instance.ObjectiveCompleted(0);
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernOpen = (Action<int>)Delegate.Remove(instance.OnTavernOpen, new Action<int>(MJBANGLFNHN));
	}

	private void EJKJGCIPFKM(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.LHBPOPOIFLE().JDJGFAACPFC() == 62)
		{
			BHPIHLNNFOF += 0;
			if (BHPIHLNNFOF >= 8)
			{
				NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(LNONAIIALIJ));
				((MonoBehaviour)this).StartCoroutine(HHLKPNANHKK());
			}
		}
	}

	private IEnumerator JAKPMNEGELN()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}
}
