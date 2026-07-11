using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class T107_PinchoDeRata : TutorialPhaseBase
{
	[CompilerGenerated]
	private sealed class IDDAPLLDDOL : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T107_PinchoDeRata _003C_003E4__this;

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
		public IDDAPLLDDOL(int _003C_003E1__state)
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
			T107_PinchoDeRata t107_PinchoDeRata = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				break;
			case 1:
				_003C_003E1__state = -1;
				break;
			}
			if (NewTutorialManager.instance.mainPopup.activeInHierarchy)
			{
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			}
			if (PlayerInventory.AnyPlayerHasItem(1536))
			{
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Remove(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(t107_PinchoDeRata.EECHIAJHKLD));
				NewTutorialManager.instance.ObjectiveCompleted(0);
				((MonoBehaviour)t107_PinchoDeRata).StartCoroutine(t107_PinchoDeRata.LHDDHIJIFCN());
			}
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

	[CompilerGenerated]
	private sealed class JPPPCGGCDCK : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T107_PinchoDeRata _003C_003E4__this;

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
			T107_PinchoDeRata t107_PinchoDeRata = _003C_003E4__this;
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
				RecipesManager.LockRecipe(540);
				MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue3", t107_PinchoDeRata.triggerPlayerNum);
				goto IL_0082;
			case 2:
				_003C_003E1__state = -1;
				goto IL_0082;
			case 3:
				{
					_003C_003E1__state = -1;
					t107_PinchoDeRata.LHKIJABBBPM();
					return false;
				}
				IL_0082:
				if (t107_PinchoDeRata.AAOPIEDAKKD(3))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 2;
					return true;
				}
				MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
				_003C_003E2__current = CommonReferences.wait2;
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

	[CompilerGenerated]
	private sealed class OBPMBDOHEAB : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T107_PinchoDeRata _003C_003E4__this;

		private bool _003CloadedFromSave_003E5__2;

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
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0236: Unknown result type (might be due to invalid IL or missing references)
			//IL_0316: Unknown result type (might be due to invalid IL or missing references)
			//IL_031b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0320: Unknown result type (might be due to invalid IL or missing references)
			//IL_032a: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			T107_PinchoDeRata t107_PinchoDeRata = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003CloadedFromSave_003E5__2 = false;
				((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(12.02083f, 912.0833f, 0f);
				((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
				_003C_003E2__current = CommonReferences.wait02;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
				if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
				{
					MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
					_003CloadedFromSave_003E5__2 = true;
					CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
				}
				else
				{
					MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
				}
				goto IL_0109;
			case 2:
				_003C_003E1__state = -1;
				goto IL_0109;
			case 3:
				_003C_003E1__state = -1;
				NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
				if (!_003CloadedFromSave_003E5__2)
				{
					_003C_003E2__current = CommonReferences.wait2;
					_003C_003E1__state = 4;
					return true;
				}
				goto IL_017e;
			case 4:
				_003C_003E1__state = -1;
				goto IL_017e;
			case 5:
				_003C_003E1__state = -1;
				goto IL_01ae;
			case 6:
				_003C_003E1__state = -1;
				goto IL_01d6;
			case 7:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
				((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.4375f, 917.3125f, 0f);
				_003C_003E2__current = CommonReferences.wait02;
				_003C_003E1__state = 8;
				return true;
			case 8:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
				MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
				_003C_003E2__current = CommonReferences.wait02;
				_003C_003E1__state = 9;
				return true;
			case 9:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue2", t107_PinchoDeRata.triggerPlayerNum);
				goto IL_02c7;
			case 10:
				_003C_003E1__state = -1;
				goto IL_02c7;
			case 11:
				{
					_003C_003E1__state = -1;
					NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
					NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
					NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(672)).transform.position), Vector2.up * 0.7f, ref t107_PinchoDeRata.JELIKOFDONK);
					CommonReferences instance = CommonReferences.GGFJGHHHEJC;
					instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Combine(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(t107_PinchoDeRata.EECHIAJHKLD));
					if (_003CloadedFromSave_003E5__2 && !t107_PinchoDeRata.COCGNJFCLMC)
					{
						((MonoBehaviour)t107_PinchoDeRata).StartCoroutine(t107_PinchoDeRata.CELDEHBONCG());
					}
					return false;
				}
				IL_01d6:
				if (!t107_PinchoDeRata.CLJJAIEMOLN())
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 6;
					return true;
				}
				NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
				MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 7;
				return true;
				IL_02c7:
				if (t107_PinchoDeRata.AAOPIEDAKKD(2))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 10;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 11;
				return true;
				IL_0109:
				if (!t107_PinchoDeRata.KMGCKIBBCMO())
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 2;
					return true;
				}
				if (!_003CloadedFromSave_003E5__2)
				{
					MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
				}
				RecipesManager.UnlockRecipe(540);
				_003C_003E2__current = ((MonoBehaviour)t107_PinchoDeRata).StartCoroutine(t107_PinchoDeRata.CDICFNAMCEE());
				_003C_003E1__state = 3;
				return true;
				IL_017e:
				MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue1", t107_PinchoDeRata.triggerPlayerNum);
				goto IL_01ae;
				IL_01ae:
				if (t107_PinchoDeRata.AAOPIEDAKKD(1))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 5;
					return true;
				}
				NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
				goto IL_01d6;
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

	private bool COCGNJFCLMC;

	private void BDEPKMGBDID(int JIIGOACEIKL, ItemInstanceAmount MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.itemInstance.KNFNJFFCFNO().IMCJPECAAPC(DAINLFIMLIH: false) == -88)
		{
			COCGNJFCLMC = true;
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Remove(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(JEPBMFINLJI));
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			((MonoBehaviour)this).StartCoroutine(FDAPBNJHNJG());
		}
	}

	private void BDLINIOJCEM(int JIIGOACEIKL, ItemInstanceAmount MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.itemInstance.LHBPOPOIFLE().JGHNDJBCFAJ() == -78)
		{
			COCGNJFCLMC = true;
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Remove(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(JIOMCACHOCM));
			NewTutorialManager.instance.ObjectiveCompleted(0);
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			((MonoBehaviour)this).StartCoroutine(PFGNIJGBCIH());
		}
	}

	private IEnumerator IHPLPBAELKL()
	{
		yield return CommonReferences.wait1;
		RecipesManager.LockRecipe(540);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue3", triggerPlayerNum);
		while (AAOPIEDAKKD(3))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator NNKFBMKFBMN()
	{
		bool loadedFromSave = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(12.02083f, 912.0833f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			loadedFromSave = true;
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		else
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		}
		while (!KMGCKIBBCMO())
		{
			yield return null;
		}
		if (!loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		RecipesManager.UnlockRecipe(540);
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		if (!loadedFromSave)
		{
			yield return CommonReferences.wait2;
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.4375f, 917.3125f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(672)).transform.position), Vector2.up * 0.7f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Combine(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(EECHIAJHKLD));
		if (loadedFromSave && !COCGNJFCLMC)
		{
			((MonoBehaviour)this).StartCoroutine(CELDEHBONCG());
		}
	}

	private IEnumerator AAGBOGGBJNF()
	{
		return new IDDAPLLDDOL(1)
		{
			_003C_003E4__this = this
		};
	}

	private void JEPBMFINLJI(int JIIGOACEIKL, ItemInstanceAmount MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.itemInstance.PHGLMBIEOMK().JGHNDJBCFAJ(DAINLFIMLIH: false) == 61)
		{
			COCGNJFCLMC = true;
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Remove(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(DDCCMBLPIMC));
			NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
		}
	}

	private IEnumerator JIICBOOJNMB()
	{
		bool loadedFromSave = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(12.02083f, 912.0833f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			loadedFromSave = true;
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		else
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		}
		while (!KMGCKIBBCMO())
		{
			yield return null;
		}
		if (!loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		RecipesManager.UnlockRecipe(540);
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		if (!loadedFromSave)
		{
			yield return CommonReferences.wait2;
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.4375f, 917.3125f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(672)).transform.position), Vector2.up * 0.7f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Combine(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(EECHIAJHKLD));
		if (loadedFromSave && !COCGNJFCLMC)
		{
			((MonoBehaviour)this).StartCoroutine(CELDEHBONCG());
		}
	}

	private IEnumerator HKKEGAOOPBB()
	{
		while (NewTutorialManager.instance.mainPopup.activeInHierarchy)
		{
			yield return null;
		}
		if (PlayerInventory.AnyPlayerHasItem(1536))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Remove(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(EECHIAJHKLD));
			NewTutorialManager.instance.ObjectiveCompleted(0);
			((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
		}
	}

	private void DODHEPJHMDI(int JIIGOACEIKL, ItemInstanceAmount MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.itemInstance.LHBPOPOIFLE().IMCJPECAAPC() == -84)
		{
			COCGNJFCLMC = false;
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Remove(commonReferences.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(OGCPFEPDOLD));
			NewTutorialManager.instance.ObjectiveCompleted(0);
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			((MonoBehaviour)this).StartCoroutine(AIOFEEJOIPL());
		}
	}

	private IEnumerator GCCGOAJCMGC()
	{
		return new IDDAPLLDDOL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator FFJLJPENMJP()
	{
		while (NewTutorialManager.instance.mainPopup.activeInHierarchy)
		{
			yield return null;
		}
		if (PlayerInventory.AnyPlayerHasItem(1536))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Remove(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(EECHIAJHKLD));
			NewTutorialManager.instance.ObjectiveCompleted(0);
			((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
		}
	}

	private IEnumerator GIKELFLBKPF()
	{
		return new IDDAPLLDDOL(1)
		{
			_003C_003E4__this = this
		};
	}

	private void MHJBHABNLLB(int JIIGOACEIKL, ItemInstanceAmount MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.itemInstance.LHBPOPOIFLE().JDJGFAACPFC(DAINLFIMLIH: false) == 85)
		{
			COCGNJFCLMC = true;
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Remove(commonReferences.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(MNIGNHIODPO));
			NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			((MonoBehaviour)this).StartCoroutine(AFHGHLOCAPA());
		}
	}

	private IEnumerator OGOFIFJCMEB()
	{
		bool loadedFromSave = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(12.02083f, 912.0833f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			loadedFromSave = true;
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		else
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		}
		while (!KMGCKIBBCMO())
		{
			yield return null;
		}
		if (!loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		RecipesManager.UnlockRecipe(540);
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		if (!loadedFromSave)
		{
			yield return CommonReferences.wait2;
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.4375f, 917.3125f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(672)).transform.position), Vector2.up * 0.7f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Combine(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(EECHIAJHKLD));
		if (loadedFromSave && !COCGNJFCLMC)
		{
			((MonoBehaviour)this).StartCoroutine(CELDEHBONCG());
		}
	}

	private void AHMIAHDFOCB(int JIIGOACEIKL, ItemInstanceAmount MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.itemInstance.PHGLMBIEOMK().JPNFKDMFKMC(DAINLFIMLIH: false) == -13)
		{
			COCGNJFCLMC = false;
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Remove(commonReferences.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(GAIEJHDLKCJ));
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			((MonoBehaviour)this).StartCoroutine(KCJAAGLPFEE());
		}
	}

	private void MHEGCHHBMPG(int JIIGOACEIKL, ItemInstanceAmount MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.itemInstance.KNFNJFFCFNO().JPNFKDMFKMC() == 78)
		{
			COCGNJFCLMC = false;
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Remove(commonReferences.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(ONGOOILBOPM));
			NewTutorialManager.instance.FOIOHOGACAL(1);
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			((MonoBehaviour)this).StartCoroutine(IHGGOFFGMBD());
		}
	}

	private void AEDJDBNEAKK(int JIIGOACEIKL, ItemInstanceAmount MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.itemInstance.KNFNJFFCFNO().JGHNDJBCFAJ() == 84)
		{
			COCGNJFCLMC = false;
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Remove(commonReferences.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(CGBNLJNNJCD));
			NewTutorialManager.instance.ObjectiveCompleted(1);
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			((MonoBehaviour)this).StartCoroutine(AJGJPBMIEJJ());
		}
	}

	private IEnumerator BAKIOJMLEMA()
	{
		yield return CommonReferences.wait1;
		RecipesManager.LockRecipe(540);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue3", triggerPlayerNum);
		while (AAOPIEDAKKD(3))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator IGEOMOOKOEP()
	{
		bool loadedFromSave = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(12.02083f, 912.0833f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			loadedFromSave = true;
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		else
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		}
		while (!KMGCKIBBCMO())
		{
			yield return null;
		}
		if (!loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		RecipesManager.UnlockRecipe(540);
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		if (!loadedFromSave)
		{
			yield return CommonReferences.wait2;
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.4375f, 917.3125f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(672)).transform.position), Vector2.up * 0.7f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Combine(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(EECHIAJHKLD));
		if (loadedFromSave && !COCGNJFCLMC)
		{
			((MonoBehaviour)this).StartCoroutine(CELDEHBONCG());
		}
	}

	private IEnumerator PBEKBJIJFDK()
	{
		bool loadedFromSave = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(12.02083f, 912.0833f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			loadedFromSave = true;
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		else
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		}
		while (!KMGCKIBBCMO())
		{
			yield return null;
		}
		if (!loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		RecipesManager.UnlockRecipe(540);
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		if (!loadedFromSave)
		{
			yield return CommonReferences.wait2;
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.4375f, 917.3125f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(672)).transform.position), Vector2.up * 0.7f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Combine(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(EECHIAJHKLD));
		if (loadedFromSave && !COCGNJFCLMC)
		{
			((MonoBehaviour)this).StartCoroutine(CELDEHBONCG());
		}
	}

	private void ONGOOILBOPM(int JIIGOACEIKL, ItemInstanceAmount MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.itemInstance.KNFNJFFCFNO().ODENMDOJPLC(DAINLFIMLIH: false) == -123)
		{
			COCGNJFCLMC = true;
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Remove(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(LMLHJPEMPHH));
			NewTutorialManager.instance.ObjectiveCompleted(1);
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			((MonoBehaviour)this).StartCoroutine(FBHLJKDLPOB());
		}
	}

	private IEnumerator ONEHLMDPDPM()
	{
		bool loadedFromSave = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(12.02083f, 912.0833f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			loadedFromSave = true;
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		else
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		}
		while (!KMGCKIBBCMO())
		{
			yield return null;
		}
		if (!loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		RecipesManager.UnlockRecipe(540);
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		if (!loadedFromSave)
		{
			yield return CommonReferences.wait2;
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.4375f, 917.3125f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(672)).transform.position), Vector2.up * 0.7f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Combine(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(EECHIAJHKLD));
		if (loadedFromSave && !COCGNJFCLMC)
		{
			((MonoBehaviour)this).StartCoroutine(CELDEHBONCG());
		}
	}

	private IEnumerator GMOJIGLJCJP()
	{
		return new JPPPCGGCDCK(1)
		{
			_003C_003E4__this = this
		};
	}

	private void LALCOJOBCCH(int JIIGOACEIKL, ItemInstanceAmount MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.itemInstance.KNFNJFFCFNO().JGHNDJBCFAJ(DAINLFIMLIH: false) == -120)
		{
			COCGNJFCLMC = false;
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Remove(commonReferences.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(MOIKAKJCGNO));
			NewTutorialManager.instance.ObjectiveCompleted(0);
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			((MonoBehaviour)this).StartCoroutine(AJJPECIKMJN());
		}
	}

	private IEnumerator CLGJAPKEOEF()
	{
		return new OBPMBDOHEAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void FEBIPDBJIAC(int JIIGOACEIKL, ItemInstanceAmount MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.itemInstance.PHGLMBIEOMK().IMCJPECAAPC() == -159)
		{
			COCGNJFCLMC = false;
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Remove(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(PPJDHGCCOAI));
			NewTutorialManager.instance.ObjectiveCompleted(1);
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			((MonoBehaviour)this).StartCoroutine(KCJAAGLPFEE());
		}
	}

	private IEnumerator KCJAAGLPFEE()
	{
		yield return CommonReferences.wait1;
		RecipesManager.LockRecipe(540);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue3", triggerPlayerNum);
		while (AAOPIEDAKKD(3))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator DECKMELAPMA()
	{
		bool loadedFromSave = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(12.02083f, 912.0833f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			loadedFromSave = true;
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		else
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		}
		while (!KMGCKIBBCMO())
		{
			yield return null;
		}
		if (!loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		RecipesManager.UnlockRecipe(540);
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		if (!loadedFromSave)
		{
			yield return CommonReferences.wait2;
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.4375f, 917.3125f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(672)).transform.position), Vector2.up * 0.7f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Combine(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(EECHIAJHKLD));
		if (loadedFromSave && !COCGNJFCLMC)
		{
			((MonoBehaviour)this).StartCoroutine(CELDEHBONCG());
		}
	}

	private IEnumerator JHMDEJNLLFL()
	{
		while (NewTutorialManager.instance.mainPopup.activeInHierarchy)
		{
			yield return null;
		}
		if (PlayerInventory.AnyPlayerHasItem(1536))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Remove(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(EECHIAJHKLD));
			NewTutorialManager.instance.ObjectiveCompleted(0);
			((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
		}
	}

	private IEnumerator IJEBOJIMAJG()
	{
		while (NewTutorialManager.instance.mainPopup.activeInHierarchy)
		{
			yield return null;
		}
		if (PlayerInventory.AnyPlayerHasItem(1536))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Remove(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(EECHIAJHKLD));
			NewTutorialManager.instance.ObjectiveCompleted(0);
			((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
		}
	}

	private void CLMGGBAMCAN(int JIIGOACEIKL, ItemInstanceAmount MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.itemInstance.PHGLMBIEOMK().CIGFGKKCPCK(DAINLFIMLIH: false) == -71)
		{
			COCGNJFCLMC = false;
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Remove(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(MFFAPELCOIG));
			NewTutorialManager.instance.FOIOHOGACAL(0);
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			((MonoBehaviour)this).StartCoroutine(DABNLFBDKGN());
		}
	}

	private void MOIKAKJCGNO(int JIIGOACEIKL, ItemInstanceAmount MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.itemInstance.PHGLMBIEOMK().CIGFGKKCPCK(DAINLFIMLIH: false) == -159)
		{
			COCGNJFCLMC = true;
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Remove(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(ONGOOILBOPM));
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			((MonoBehaviour)this).StartCoroutine(IHPLPBAELKL());
		}
	}

	private IEnumerator ELPDKDFFJJD()
	{
		bool loadedFromSave = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(12.02083f, 912.0833f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			loadedFromSave = true;
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		else
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		}
		while (!KMGCKIBBCMO())
		{
			yield return null;
		}
		if (!loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		RecipesManager.UnlockRecipe(540);
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		if (!loadedFromSave)
		{
			yield return CommonReferences.wait2;
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.4375f, 917.3125f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(672)).transform.position), Vector2.up * 0.7f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Combine(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(EECHIAJHKLD));
		if (loadedFromSave && !COCGNJFCLMC)
		{
			((MonoBehaviour)this).StartCoroutine(CELDEHBONCG());
		}
	}

	private IEnumerator GLBHLKLKMNN()
	{
		bool loadedFromSave = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(12.02083f, 912.0833f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			loadedFromSave = true;
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		else
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		}
		while (!KMGCKIBBCMO())
		{
			yield return null;
		}
		if (!loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		RecipesManager.UnlockRecipe(540);
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		if (!loadedFromSave)
		{
			yield return CommonReferences.wait2;
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.4375f, 917.3125f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(672)).transform.position), Vector2.up * 0.7f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Combine(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(EECHIAJHKLD));
		if (loadedFromSave && !COCGNJFCLMC)
		{
			((MonoBehaviour)this).StartCoroutine(CELDEHBONCG());
		}
	}

	private IEnumerator PFGNIJGBCIH()
	{
		return new JPPPCGGCDCK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator MFFGIOALMIC()
	{
		return new OBPMBDOHEAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NIKPIBICOPP()
	{
		return new OBPMBDOHEAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void DHMJMFOOEOF(int JIIGOACEIKL, ItemInstanceAmount MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.itemInstance.LHBPOPOIFLE().ODENMDOJPLC(DAINLFIMLIH: false) == -144)
		{
			COCGNJFCLMC = true;
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Remove(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(LALCOJOBCCH));
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			((MonoBehaviour)this).StartCoroutine(NBENGPAEGCL());
		}
	}

	private IEnumerator AAOAJJPHEPL()
	{
		while (NewTutorialManager.instance.mainPopup.activeInHierarchy)
		{
			yield return null;
		}
		if (PlayerInventory.AnyPlayerHasItem(1536))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Remove(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(EECHIAJHKLD));
			NewTutorialManager.instance.ObjectiveCompleted(0);
			((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
		}
	}

	public override void SetUp()
	{
		base.SetUp();
		((MonoBehaviour)this).StartCoroutine(PBEKBJIJFDK());
	}

	private IEnumerator BLNKHNHGFPB()
	{
		return new OBPMBDOHEAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void NCJBDCAMOKC(int JIIGOACEIKL, ItemInstanceAmount MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.itemInstance.LHBPOPOIFLE().ODENMDOJPLC() == 136)
		{
			COCGNJFCLMC = false;
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Remove(commonReferences.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(NLBOHKCBEBH));
			NewTutorialManager.instance.ObjectiveCompleted(0);
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			((MonoBehaviour)this).StartCoroutine(BAGKLMIFNIH());
		}
	}

	private IEnumerator EJMHFLGBJKM()
	{
		bool loadedFromSave = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(12.02083f, 912.0833f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			loadedFromSave = true;
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		else
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		}
		while (!KMGCKIBBCMO())
		{
			yield return null;
		}
		if (!loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		RecipesManager.UnlockRecipe(540);
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		if (!loadedFromSave)
		{
			yield return CommonReferences.wait2;
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.4375f, 917.3125f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(672)).transform.position), Vector2.up * 0.7f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Combine(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(EECHIAJHKLD));
		if (loadedFromSave && !COCGNJFCLMC)
		{
			((MonoBehaviour)this).StartCoroutine(CELDEHBONCG());
		}
	}

	private IEnumerator JOBCLCJPMDC()
	{
		return new IDDAPLLDDOL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator OOINODMALJM()
	{
		yield return CommonReferences.wait1;
		RecipesManager.LockRecipe(540);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue3", triggerPlayerNum);
		while (AAOPIEDAKKD(3))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator EKMOJHNJOCG()
	{
		return new OBPMBDOHEAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JDMBNPFBIND()
	{
		yield return CommonReferences.wait1;
		RecipesManager.LockRecipe(540);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue3", triggerPlayerNum);
		while (AAOPIEDAKKD(3))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator BLJIIHBNHAA()
	{
		return new OBPMBDOHEAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void CNKMEKCKPHA(int JIIGOACEIKL, ItemInstanceAmount MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.itemInstance.PHGLMBIEOMK().ODENMDOJPLC() == 198)
		{
			COCGNJFCLMC = true;
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Remove(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(JANCPDOHBPJ));
			NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			((MonoBehaviour)this).StartCoroutine(DNLEAJAPNOM());
		}
	}

	private void LMLHJPEMPHH(int JIIGOACEIKL, ItemInstanceAmount MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.itemInstance.LHBPOPOIFLE().JPNFKDMFKMC(DAINLFIMLIH: false) == 6)
		{
			COCGNJFCLMC = false;
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Remove(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(CJCADFOABIL));
			NewTutorialManager.instance.ObjectiveCompleted(1);
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			((MonoBehaviour)this).StartCoroutine(PFGNIJGBCIH());
		}
	}

	private IEnumerator BBKAPGONNOL()
	{
		return new IDDAPLLDDOL(1)
		{
			_003C_003E4__this = this
		};
	}

	private void HMPIIOKPGNE(int JIIGOACEIKL, ItemInstanceAmount MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.itemInstance.PHGLMBIEOMK().CIGFGKKCPCK(DAINLFIMLIH: false) == -61)
		{
			COCGNJFCLMC = false;
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Remove(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(CNKMEKCKPHA));
			NewTutorialManager.instance.ObjectiveCompleted(1);
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			((MonoBehaviour)this).StartCoroutine(AFHGHLOCAPA());
		}
	}

	private IEnumerator EOCBHNPFJLL()
	{
		return new OBPMBDOHEAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator DLDDDCONHLL()
	{
		return new IDDAPLLDDOL(1)
		{
			_003C_003E4__this = this
		};
	}

	private void EAEIGJEKDDH(int JIIGOACEIKL, ItemInstanceAmount MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.itemInstance.PHGLMBIEOMK().JGHNDJBCFAJ(DAINLFIMLIH: false) == 119)
		{
			COCGNJFCLMC = true;
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Remove(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(HMPIIOKPGNE));
			NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			((MonoBehaviour)this).StartCoroutine(NLJAMKLPLBJ());
		}
	}

	private void MFFAPELCOIG(int JIIGOACEIKL, ItemInstanceAmount MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.itemInstance.PHGLMBIEOMK().IMCJPECAAPC() == -133)
		{
			COCGNJFCLMC = true;
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Remove(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(JIOMCACHOCM));
			NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			((MonoBehaviour)this).StartCoroutine(NLJAMKLPLBJ());
		}
	}

	private IEnumerator IPHCPKNNFAI()
	{
		return new IDDAPLLDDOL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator FDAPBNJHNJG()
	{
		return new JPPPCGGCDCK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator GNIABJGPACN()
	{
		return new IDDAPLLDDOL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JOBFBHOMJNC()
	{
		return new JPPPCGGCDCK(1)
		{
			_003C_003E4__this = this
		};
	}

	private void PAINJDGHBFF(int JIIGOACEIKL, ItemInstanceAmount MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.itemInstance.LHBPOPOIFLE().ODENMDOJPLC() == 161)
		{
			COCGNJFCLMC = false;
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Remove(commonReferences.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(NBMKBBDBLJI));
			NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			((MonoBehaviour)this).StartCoroutine(JDMBNPFBIND());
		}
	}

	private void CJCADFOABIL(int JIIGOACEIKL, ItemInstanceAmount MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.itemInstance.LHBPOPOIFLE().ODENMDOJPLC(DAINLFIMLIH: false) == -90)
		{
			COCGNJFCLMC = false;
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Remove(commonReferences.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(NCJBDCAMOKC));
			NewTutorialManager.instance.FOIOHOGACAL(0);
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			((MonoBehaviour)this).StartCoroutine(NAMHCGEICNE());
		}
	}

	private IEnumerator FBDJFDDPKDN()
	{
		return new OBPMBDOHEAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void JIOMCACHOCM(int JIIGOACEIKL, ItemInstanceAmount MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.itemInstance.KNFNJFFCFNO().JPNFKDMFKMC(DAINLFIMLIH: false) == -121)
		{
			COCGNJFCLMC = false;
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Remove(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(JANCPDOHBPJ));
			NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			((MonoBehaviour)this).StartCoroutine(GGACDGHOJEF());
		}
	}

	private void PPJDHGCCOAI(int JIIGOACEIKL, ItemInstanceAmount MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.itemInstance.LHBPOPOIFLE().JPNFKDMFKMC(DAINLFIMLIH: false) == 110)
		{
			COCGNJFCLMC = true;
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Remove(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(JIOMCACHOCM));
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			((MonoBehaviour)this).StartCoroutine(AFHGHLOCAPA());
		}
	}

	private IEnumerator GGACDGHOJEF()
	{
		return new JPPPCGGCDCK(1)
		{
			_003C_003E4__this = this
		};
	}

	private void LMEPNILHDHE(int JIIGOACEIKL, ItemInstanceAmount MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.itemInstance.PHGLMBIEOMK().JGHNDJBCFAJ(DAINLFIMLIH: false) == -56)
		{
			COCGNJFCLMC = true;
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Remove(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(ILLIIMCEFGE));
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			((MonoBehaviour)this).StartCoroutine(IAOFDDMPMBJ());
		}
	}

	private IEnumerator LHIPOAGIOJK()
	{
		bool loadedFromSave = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(12.02083f, 912.0833f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			loadedFromSave = true;
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		else
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		}
		while (!KMGCKIBBCMO())
		{
			yield return null;
		}
		if (!loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		RecipesManager.UnlockRecipe(540);
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		if (!loadedFromSave)
		{
			yield return CommonReferences.wait2;
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.4375f, 917.3125f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(672)).transform.position), Vector2.up * 0.7f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Combine(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(EECHIAJHKLD));
		if (loadedFromSave && !COCGNJFCLMC)
		{
			((MonoBehaviour)this).StartCoroutine(CELDEHBONCG());
		}
	}

	private IEnumerator ELNHMAPENDB()
	{
		return new JPPPCGGCDCK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NCHPMDFONEL()
	{
		bool loadedFromSave = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(12.02083f, 912.0833f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			loadedFromSave = true;
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		else
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		}
		while (!KMGCKIBBCMO())
		{
			yield return null;
		}
		if (!loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		RecipesManager.UnlockRecipe(540);
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		if (!loadedFromSave)
		{
			yield return CommonReferences.wait2;
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.4375f, 917.3125f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(672)).transform.position), Vector2.up * 0.7f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Combine(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(EECHIAJHKLD));
		if (loadedFromSave && !COCGNJFCLMC)
		{
			((MonoBehaviour)this).StartCoroutine(CELDEHBONCG());
		}
	}

	private IEnumerator OAIEBGHEBAK()
	{
		bool loadedFromSave = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(12.02083f, 912.0833f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			loadedFromSave = true;
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		else
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		}
		while (!KMGCKIBBCMO())
		{
			yield return null;
		}
		if (!loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		RecipesManager.UnlockRecipe(540);
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		if (!loadedFromSave)
		{
			yield return CommonReferences.wait2;
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.4375f, 917.3125f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(672)).transform.position), Vector2.up * 0.7f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Combine(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(EECHIAJHKLD));
		if (loadedFromSave && !COCGNJFCLMC)
		{
			((MonoBehaviour)this).StartCoroutine(CELDEHBONCG());
		}
	}

	private IEnumerator NBENGPAEGCL()
	{
		yield return CommonReferences.wait1;
		RecipesManager.LockRecipe(540);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue3", triggerPlayerNum);
		while (AAOPIEDAKKD(3))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator NAMHCGEICNE()
	{
		yield return CommonReferences.wait1;
		RecipesManager.LockRecipe(540);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue3", triggerPlayerNum);
		while (AAOPIEDAKKD(3))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private void OGCPFEPDOLD(int JIIGOACEIKL, ItemInstanceAmount MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.itemInstance.PHGLMBIEOMK().ODENMDOJPLC(DAINLFIMLIH: false) == 10)
		{
			COCGNJFCLMC = true;
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Remove(commonReferences.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(LMLHJPEMPHH));
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			((MonoBehaviour)this).StartCoroutine(KCJAAGLPFEE());
		}
	}

	private IEnumerator CKPACONJNOC()
	{
		return new OBPMBDOHEAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LPNNMDOPCCJ()
	{
		bool loadedFromSave = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(12.02083f, 912.0833f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			loadedFromSave = true;
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		else
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		}
		while (!KMGCKIBBCMO())
		{
			yield return null;
		}
		if (!loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		RecipesManager.UnlockRecipe(540);
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		if (!loadedFromSave)
		{
			yield return CommonReferences.wait2;
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.4375f, 917.3125f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(672)).transform.position), Vector2.up * 0.7f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Combine(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(EECHIAJHKLD));
		if (loadedFromSave && !COCGNJFCLMC)
		{
			((MonoBehaviour)this).StartCoroutine(CELDEHBONCG());
		}
	}

	private void GAIEJHDLKCJ(int JIIGOACEIKL, ItemInstanceAmount MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.itemInstance.PHGLMBIEOMK().JDJGFAACPFC() == -117)
		{
			COCGNJFCLMC = true;
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Remove(commonReferences.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(HANEMGLBPND));
			NewTutorialManager.instance.ObjectiveCompleted(1);
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			((MonoBehaviour)this).StartCoroutine(JOBFBHOMJNC());
		}
	}

	private void ILLIIMCEFGE(int JIIGOACEIKL, ItemInstanceAmount MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.itemInstance.PHGLMBIEOMK().JDJGFAACPFC() == 62)
		{
			COCGNJFCLMC = false;
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Remove(commonReferences.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(AEDJDBNEAKK));
			NewTutorialManager.instance.ObjectiveCompleted(1);
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			((MonoBehaviour)this).StartCoroutine(JNOOAENGMHL());
		}
	}

	private IEnumerator CELDEHBONCG()
	{
		while (NewTutorialManager.instance.mainPopup.activeInHierarchy)
		{
			yield return null;
		}
		if (PlayerInventory.AnyPlayerHasItem(1536))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Remove(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(EECHIAJHKLD));
			NewTutorialManager.instance.ObjectiveCompleted(0);
			((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
		}
	}

	private IEnumerator KEBCOCFPNIG()
	{
		return new OBPMBDOHEAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LIKLODNIEKK()
	{
		while (NewTutorialManager.instance.mainPopup.activeInHierarchy)
		{
			yield return null;
		}
		if (PlayerInventory.AnyPlayerHasItem(1536))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Remove(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(EECHIAJHKLD));
			NewTutorialManager.instance.ObjectiveCompleted(0);
			((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
		}
	}

	private IEnumerator MHDPGKHMJJE()
	{
		while (NewTutorialManager.instance.mainPopup.activeInHierarchy)
		{
			yield return null;
		}
		if (PlayerInventory.AnyPlayerHasItem(1536))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Remove(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(EECHIAJHKLD));
			NewTutorialManager.instance.ObjectiveCompleted(0);
			((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
		}
	}

	private IEnumerator HPNEFMANGHJ()
	{
		yield return CommonReferences.wait1;
		RecipesManager.LockRecipe(540);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue3", triggerPlayerNum);
		while (AAOPIEDAKKD(3))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator IHGGOFFGMBD()
	{
		yield return CommonReferences.wait1;
		RecipesManager.LockRecipe(540);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue3", triggerPlayerNum);
		while (AAOPIEDAKKD(3))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator EHMJLPGLIHK()
	{
		bool loadedFromSave = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(12.02083f, 912.0833f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			loadedFromSave = true;
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		else
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		}
		while (!KMGCKIBBCMO())
		{
			yield return null;
		}
		if (!loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		RecipesManager.UnlockRecipe(540);
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		if (!loadedFromSave)
		{
			yield return CommonReferences.wait2;
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.4375f, 917.3125f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(672)).transform.position), Vector2.up * 0.7f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Combine(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(EECHIAJHKLD));
		if (loadedFromSave && !COCGNJFCLMC)
		{
			((MonoBehaviour)this).StartCoroutine(CELDEHBONCG());
		}
	}

	private IEnumerator PIHPPADDGMG()
	{
		bool loadedFromSave = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(12.02083f, 912.0833f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			loadedFromSave = true;
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		else
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		}
		while (!KMGCKIBBCMO())
		{
			yield return null;
		}
		if (!loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		RecipesManager.UnlockRecipe(540);
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		if (!loadedFromSave)
		{
			yield return CommonReferences.wait2;
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.4375f, 917.3125f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(672)).transform.position), Vector2.up * 0.7f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Combine(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(EECHIAJHKLD));
		if (loadedFromSave && !COCGNJFCLMC)
		{
			((MonoBehaviour)this).StartCoroutine(CELDEHBONCG());
		}
	}

	private IEnumerator JNOOAENGMHL()
	{
		return new JPPPCGGCDCK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AICLJGCPODO()
	{
		while (NewTutorialManager.instance.mainPopup.activeInHierarchy)
		{
			yield return null;
		}
		if (PlayerInventory.AnyPlayerHasItem(1536))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Remove(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(EECHIAJHKLD));
			NewTutorialManager.instance.ObjectiveCompleted(0);
			((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
		}
	}

	private IEnumerator PPMPKJECPDE()
	{
		bool loadedFromSave = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(12.02083f, 912.0833f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			loadedFromSave = true;
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		else
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		}
		while (!KMGCKIBBCMO())
		{
			yield return null;
		}
		if (!loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		RecipesManager.UnlockRecipe(540);
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		if (!loadedFromSave)
		{
			yield return CommonReferences.wait2;
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.4375f, 917.3125f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(672)).transform.position), Vector2.up * 0.7f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Combine(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(EECHIAJHKLD));
		if (loadedFromSave && !COCGNJFCLMC)
		{
			((MonoBehaviour)this).StartCoroutine(CELDEHBONCG());
		}
	}

	private void CGBNLJNNJCD(int JIIGOACEIKL, ItemInstanceAmount MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.itemInstance.KNFNJFFCFNO().CIGFGKKCPCK(DAINLFIMLIH: false) == -128)
		{
			COCGNJFCLMC = false;
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Remove(commonReferences.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(GAIEJHDLKCJ));
			NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			((MonoBehaviour)this).StartCoroutine(AIOFEEJOIPL());
		}
	}

	private IEnumerator NBAELEJAFAN()
	{
		yield return CommonReferences.wait1;
		RecipesManager.LockRecipe(540);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue3", triggerPlayerNum);
		while (AAOPIEDAKKD(3))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator FJBKBPOLINL()
	{
		return new JPPPCGGCDCK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator CKIPOLEIJOD()
	{
		bool loadedFromSave = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(12.02083f, 912.0833f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			loadedFromSave = true;
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		else
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		}
		while (!KMGCKIBBCMO())
		{
			yield return null;
		}
		if (!loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		RecipesManager.UnlockRecipe(540);
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		if (!loadedFromSave)
		{
			yield return CommonReferences.wait2;
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.4375f, 917.3125f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(672)).transform.position), Vector2.up * 0.7f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Combine(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(EECHIAJHKLD));
		if (loadedFromSave && !COCGNJFCLMC)
		{
			((MonoBehaviour)this).StartCoroutine(CELDEHBONCG());
		}
	}

	private void FPPBBKADDDP(int JIIGOACEIKL, ItemInstanceAmount MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.itemInstance.AFOACBIHNCL().ODENMDOJPLC() == 129)
		{
			COCGNJFCLMC = true;
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Remove(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(DODHEPJHMDI));
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			((MonoBehaviour)this).StartCoroutine(FBHLJKDLPOB());
		}
	}

	private IEnumerator AIOFEEJOIPL()
	{
		yield return CommonReferences.wait1;
		RecipesManager.LockRecipe(540);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue3", triggerPlayerNum);
		while (AAOPIEDAKKD(3))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator CDMECHHHKEB()
	{
		while (NewTutorialManager.instance.mainPopup.activeInHierarchy)
		{
			yield return null;
		}
		if (PlayerInventory.AnyPlayerHasItem(1536))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Remove(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(EECHIAJHKLD));
			NewTutorialManager.instance.ObjectiveCompleted(0);
			((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
		}
	}

	private IEnumerator JEBLBIJIDPL()
	{
		yield return CommonReferences.wait1;
		RecipesManager.LockRecipe(540);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue3", triggerPlayerNum);
		while (AAOPIEDAKKD(3))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator GEGGBBHIOAI()
	{
		while (NewTutorialManager.instance.mainPopup.activeInHierarchy)
		{
			yield return null;
		}
		if (PlayerInventory.AnyPlayerHasItem(1536))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Remove(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(EECHIAJHKLD));
			NewTutorialManager.instance.ObjectiveCompleted(0);
			((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
		}
	}

	private void HANEMGLBPND(int JIIGOACEIKL, ItemInstanceAmount MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.itemInstance.KNFNJFFCFNO().JDJGFAACPFC() == -34)
		{
			COCGNJFCLMC = true;
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Remove(commonReferences.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(HMPIIOKPGNE));
			NewTutorialManager.instance.ObjectiveCompleted(1);
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			((MonoBehaviour)this).StartCoroutine(IDGLEKCBIMF());
		}
	}

	public override int GetID()
	{
		return 107;
	}

	private IEnumerator LILMJIIMODP()
	{
		return new OBPMBDOHEAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator KLMLJKJINFC()
	{
		while (NewTutorialManager.instance.mainPopup.activeInHierarchy)
		{
			yield return null;
		}
		if (PlayerInventory.AnyPlayerHasItem(1536))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Remove(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(EECHIAJHKLD));
			NewTutorialManager.instance.ObjectiveCompleted(0);
			((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
		}
	}

	private void DDCCMBLPIMC(int JIIGOACEIKL, ItemInstanceAmount MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.itemInstance.LHBPOPOIFLE().CIGFGKKCPCK(DAINLFIMLIH: false) == 51)
		{
			COCGNJFCLMC = false;
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Remove(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(DHMJMFOOEOF));
			NewTutorialManager.instance.ObjectiveCompleted(0);
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			((MonoBehaviour)this).StartCoroutine(JOBFBHOMJNC());
		}
	}

	private IEnumerator EHHOMOEBCOK()
	{
		while (NewTutorialManager.instance.mainPopup.activeInHierarchy)
		{
			yield return null;
		}
		if (PlayerInventory.AnyPlayerHasItem(1536))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Remove(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(EECHIAJHKLD));
			NewTutorialManager.instance.ObjectiveCompleted(0);
			((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
		}
	}

	private IEnumerator JIJEDGBCENE()
	{
		return new OBPMBDOHEAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator IGFOJFFHNJF()
	{
		bool loadedFromSave = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(12.02083f, 912.0833f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			loadedFromSave = true;
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		else
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		}
		while (!KMGCKIBBCMO())
		{
			yield return null;
		}
		if (!loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		RecipesManager.UnlockRecipe(540);
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		if (!loadedFromSave)
		{
			yield return CommonReferences.wait2;
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.4375f, 917.3125f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(672)).transform.position), Vector2.up * 0.7f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Combine(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(EECHIAJHKLD));
		if (loadedFromSave && !COCGNJFCLMC)
		{
			((MonoBehaviour)this).StartCoroutine(CELDEHBONCG());
		}
	}

	private IEnumerator OLACDODPEGM()
	{
		return new IDDAPLLDDOL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AAGGGIONDAG()
	{
		bool loadedFromSave = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(12.02083f, 912.0833f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			loadedFromSave = true;
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		else
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		}
		while (!KMGCKIBBCMO())
		{
			yield return null;
		}
		if (!loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		RecipesManager.UnlockRecipe(540);
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		if (!loadedFromSave)
		{
			yield return CommonReferences.wait2;
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.4375f, 917.3125f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(672)).transform.position), Vector2.up * 0.7f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Combine(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(EECHIAJHKLD));
		if (loadedFromSave && !COCGNJFCLMC)
		{
			((MonoBehaviour)this).StartCoroutine(CELDEHBONCG());
		}
	}

	private IEnumerator KBCMEHCIEBA()
	{
		return new JPPPCGGCDCK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NCBODCOOANK()
	{
		yield return CommonReferences.wait1;
		RecipesManager.LockRecipe(540);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue3", triggerPlayerNum);
		while (AAOPIEDAKKD(3))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator DABNLFBDKGN()
	{
		return new JPPPCGGCDCK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator CGIMIGHKCID()
	{
		while (NewTutorialManager.instance.mainPopup.activeInHierarchy)
		{
			yield return null;
		}
		if (PlayerInventory.AnyPlayerHasItem(1536))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Remove(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(EECHIAJHKLD));
			NewTutorialManager.instance.ObjectiveCompleted(0);
			((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
		}
	}

	private IEnumerator MEGKLKNBNEL()
	{
		bool loadedFromSave = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(12.02083f, 912.0833f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			loadedFromSave = true;
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		else
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		}
		while (!KMGCKIBBCMO())
		{
			yield return null;
		}
		if (!loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		RecipesManager.UnlockRecipe(540);
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		if (!loadedFromSave)
		{
			yield return CommonReferences.wait2;
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.4375f, 917.3125f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(672)).transform.position), Vector2.up * 0.7f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Combine(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(EECHIAJHKLD));
		if (loadedFromSave && !COCGNJFCLMC)
		{
			((MonoBehaviour)this).StartCoroutine(CELDEHBONCG());
		}
	}

	private IEnumerator KBCJHMHGMBC()
	{
		return new IDDAPLLDDOL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator OOGKJFJEHFO()
	{
		return new JPPPCGGCDCK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator MPFFKPDDFDP()
	{
		while (NewTutorialManager.instance.mainPopup.activeInHierarchy)
		{
			yield return null;
		}
		if (PlayerInventory.AnyPlayerHasItem(1536))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Remove(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(EECHIAJHKLD));
			NewTutorialManager.instance.ObjectiveCompleted(0);
			((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
		}
	}

	private IEnumerator JHJGFLHDKIJ()
	{
		return new IDDAPLLDDOL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator EADKMOCAHFP()
	{
		return new IDDAPLLDDOL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HMLHFFEDBNK()
	{
		return new IDDAPLLDDOL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator IDGLEKCBIMF()
	{
		return new JPPPCGGCDCK(1)
		{
			_003C_003E4__this = this
		};
	}

	private void NBMKBBDBLJI(int JIIGOACEIKL, ItemInstanceAmount MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.itemInstance.LHBPOPOIFLE().IMCJPECAAPC(DAINLFIMLIH: false) == 13)
		{
			COCGNJFCLMC = false;
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Remove(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(PAINJDGHBFF));
			NewTutorialManager.instance.ObjectiveCompleted(0);
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			((MonoBehaviour)this).StartCoroutine(FDAPBNJHNJG());
		}
	}

	private IEnumerator PALMADJGAEM()
	{
		return new IDDAPLLDDOL(1)
		{
			_003C_003E4__this = this
		};
	}

	private void JANCPDOHBPJ(int JIIGOACEIKL, ItemInstanceAmount MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.itemInstance.PHGLMBIEOMK().IMCJPECAAPC(DAINLFIMLIH: false) == 36)
		{
			COCGNJFCLMC = true;
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Remove(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(GAIEJHDLKCJ));
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			((MonoBehaviour)this).StartCoroutine(DABNLFBDKGN());
		}
	}

	private IEnumerator FBHLJKDLPOB()
	{
		return new JPPPCGGCDCK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator KNBNIMCHKIE()
	{
		yield return CommonReferences.wait1;
		RecipesManager.LockRecipe(540);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue3", triggerPlayerNum);
		while (AAOPIEDAKKD(3))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator NLJAMKLPLBJ()
	{
		return new JPPPCGGCDCK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HPDFPEJHCLF()
	{
		bool loadedFromSave = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(12.02083f, 912.0833f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			loadedFromSave = true;
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		else
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		}
		while (!KMGCKIBBCMO())
		{
			yield return null;
		}
		if (!loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		RecipesManager.UnlockRecipe(540);
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		if (!loadedFromSave)
		{
			yield return CommonReferences.wait2;
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.4375f, 917.3125f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(672)).transform.position), Vector2.up * 0.7f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Combine(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(EECHIAJHKLD));
		if (loadedFromSave && !COCGNJFCLMC)
		{
			((MonoBehaviour)this).StartCoroutine(CELDEHBONCG());
		}
	}

	private IEnumerator EIPOEACBLBO()
	{
		while (NewTutorialManager.instance.mainPopup.activeInHierarchy)
		{
			yield return null;
		}
		if (PlayerInventory.AnyPlayerHasItem(1536))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Remove(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(EECHIAJHKLD));
			NewTutorialManager.instance.ObjectiveCompleted(0);
			((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
		}
	}

	private IEnumerator BCALBKDNAJH()
	{
		bool loadedFromSave = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(12.02083f, 912.0833f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			loadedFromSave = true;
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		else
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		}
		while (!KMGCKIBBCMO())
		{
			yield return null;
		}
		if (!loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		RecipesManager.UnlockRecipe(540);
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		if (!loadedFromSave)
		{
			yield return CommonReferences.wait2;
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.4375f, 917.3125f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(672)).transform.position), Vector2.up * 0.7f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Combine(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(EECHIAJHKLD));
		if (loadedFromSave && !COCGNJFCLMC)
		{
			((MonoBehaviour)this).StartCoroutine(CELDEHBONCG());
		}
	}

	private IEnumerator NKOJNIDHGBJ()
	{
		bool loadedFromSave = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(12.02083f, 912.0833f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			loadedFromSave = true;
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		else
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		}
		while (!KMGCKIBBCMO())
		{
			yield return null;
		}
		if (!loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		RecipesManager.UnlockRecipe(540);
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		if (!loadedFromSave)
		{
			yield return CommonReferences.wait2;
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.4375f, 917.3125f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(672)).transform.position), Vector2.up * 0.7f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Combine(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(EECHIAJHKLD));
		if (loadedFromSave && !COCGNJFCLMC)
		{
			((MonoBehaviour)this).StartCoroutine(CELDEHBONCG());
		}
	}

	private IEnumerator COMPHHHBLIO()
	{
		return new JPPPCGGCDCK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator BFKAMMGGCJD()
	{
		return new IDDAPLLDDOL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HBGEACLCCNJ()
	{
		return new IDDAPLLDDOL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator KFDJCAEABFD()
	{
		return new IDDAPLLDDOL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator FJNGKKFPMPN()
	{
		return new OBPMBDOHEAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AJJPECIKMJN()
	{
		yield return CommonReferences.wait1;
		RecipesManager.LockRecipe(540);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue3", triggerPlayerNum);
		while (AAOPIEDAKKD(3))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator HCDGLBBFEJK()
	{
		while (NewTutorialManager.instance.mainPopup.activeInHierarchy)
		{
			yield return null;
		}
		if (PlayerInventory.AnyPlayerHasItem(1536))
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Remove(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(EECHIAJHKLD));
			NewTutorialManager.instance.ObjectiveCompleted(0);
			((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
		}
	}

	private IEnumerator CBNJMAKPBAA()
	{
		return new JPPPCGGCDCK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator BNIBOPPHLHI()
	{
		return new IDDAPLLDDOL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator GDEAHEBKEDG()
	{
		return new IDDAPLLDDOL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator BOBFDCNBOAF()
	{
		return new IDDAPLLDDOL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator BAGKLMIFNIH()
	{
		return new JPPPCGGCDCK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AFHGHLOCAPA()
	{
		yield return CommonReferences.wait1;
		RecipesManager.LockRecipe(540);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue3", triggerPlayerNum);
		while (AAOPIEDAKKD(3))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator AJGJPBMIEJJ()
	{
		yield return CommonReferences.wait1;
		RecipesManager.LockRecipe(540);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue3", triggerPlayerNum);
		while (AAOPIEDAKKD(3))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private void EECHIAJHKLD(int JIIGOACEIKL, ItemInstanceAmount MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.itemInstance.LHBPOPOIFLE().JDJGFAACPFC() == 1536)
		{
			COCGNJFCLMC = true;
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Remove(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(EECHIAJHKLD));
			NewTutorialManager.instance.ObjectiveCompleted(0);
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
		}
	}

	private IEnumerator DNLEAJAPNOM()
	{
		return new JPPPCGGCDCK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LHDDHIJIFCN()
	{
		yield return CommonReferences.wait1;
		RecipesManager.LockRecipe(540);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue3", triggerPlayerNum);
		while (AAOPIEDAKKD(3))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator HOHNKIDANFE()
	{
		bool loadedFromSave = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(12.02083f, 912.0833f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			loadedFromSave = true;
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		else
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		}
		while (!KMGCKIBBCMO())
		{
			yield return null;
		}
		if (!loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		RecipesManager.UnlockRecipe(540);
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		if (!loadedFromSave)
		{
			yield return CommonReferences.wait2;
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.4375f, 917.3125f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(672)).transform.position), Vector2.up * 0.7f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Combine(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(EECHIAJHKLD));
		if (loadedFromSave && !COCGNJFCLMC)
		{
			((MonoBehaviour)this).StartCoroutine(CELDEHBONCG());
		}
	}

	private void MNIGNHIODPO(int JIIGOACEIKL, ItemInstanceAmount MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.itemInstance.AFOACBIHNCL().IMCJPECAAPC(DAINLFIMLIH: false) == -94)
		{
			COCGNJFCLMC = false;
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Remove(instance.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(JEPBMFINLJI));
			NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			((MonoBehaviour)this).StartCoroutine(GMOJIGLJCJP());
		}
	}

	private void NLBOHKCBEBH(int JIIGOACEIKL, ItemInstanceAmount MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.itemInstance.LHBPOPOIFLE().JGHNDJBCFAJ(DAINLFIMLIH: false) == -97)
		{
			COCGNJFCLMC = false;
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyItemCrafted = (Action<int, ItemInstanceAmount>)Delegate.Remove(commonReferences.OnAnyItemCrafted, new Action<int, ItemInstanceAmount>(MFFAPELCOIG));
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			((MonoBehaviour)this).StartCoroutine(NCBODCOOANK());
		}
	}

	private IEnumerator HNNEPLACIAC()
	{
		return new JPPPCGGCDCK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator DPHLIOPNPFN()
	{
		return new IDDAPLLDDOL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator IAOFDDMPMBJ()
	{
		yield return CommonReferences.wait1;
		RecipesManager.LockRecipe(540);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T107/Dialogue3", triggerPlayerNum);
		while (AAOPIEDAKKD(3))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}
}
