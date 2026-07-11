using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class T118_MaltearTrigo : TutorialPhaseBase
{
	[CompilerGenerated]
	private sealed class ILGBEHOLOGL : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T118_MaltearTrigo _003C_003E4__this;

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
		public ILGBEHOLOGL(int _003C_003E1__state)
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
			T118_MaltearTrigo t118_MaltearTrigo = _003C_003E4__this;
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
				MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T118/Dialogue2", t118_MaltearTrigo.triggerPlayerNum);
				goto IL_007c;
			case 2:
				_003C_003E1__state = -1;
				goto IL_007c;
			case 3:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 4;
				return true;
			case 4:
				{
					_003C_003E1__state = -1;
					t118_MaltearTrigo.LHKIJABBBPM();
					return false;
				}
				IL_007c:
				if (t118_MaltearTrigo.AAOPIEDAKKD(2))
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

	[CompilerGenerated]
	private sealed class DBHBDMOHMPM : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T118_MaltearTrigo _003C_003E4__this;

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
			//IL_0208: Unknown result type (might be due to invalid IL or missing references)
			//IL_020d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0212: Unknown result type (might be due to invalid IL or missing references)
			//IL_021c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			T118_MaltearTrigo t118_MaltearTrigo = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003CloadedFromSave_003E5__2 = false;
				if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
				{
					CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
					_003CloadedFromSave_003E5__2 = true;
				}
				if (!_003CloadedFromSave_003E5__2)
				{
					MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
				}
				((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.4375f, 917.3125f, 0f);
				_003C_003E2__current = CommonReferences.wait02;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
				if (_003CloadedFromSave_003E5__2)
				{
					MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
				}
				goto IL_00f7;
			case 2:
				_003C_003E1__state = -1;
				goto IL_00f7;
			case 3:
				_003C_003E1__state = -1;
				goto IL_011d;
			case 4:
				_003C_003E1__state = -1;
				NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
				if (!_003CloadedFromSave_003E5__2)
				{
					_003C_003E2__current = CommonReferences.wait2;
					_003C_003E1__state = 5;
					return true;
				}
				goto IL_017f;
			case 5:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
				goto IL_017f;
			case 6:
				_003C_003E1__state = -1;
				goto IL_01af;
			case 7:
				{
					_003C_003E1__state = -1;
					NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
					NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
					RecipesManager.UnlockRecipe(506, IBHGAMNNOHI: true);
					NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(673)).transform.position), Vector2.up * 0.7f, ref t118_MaltearTrigo.JELIKOFDONK);
					CommonReferences instance = CommonReferences.GGFJGHHHEJC;
					instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Combine(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(t118_MaltearTrigo.EECHIAJHKLD));
					return false;
				}
				IL_00f7:
				if (GameCraftingUI.Get(1).IsOpen())
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 2;
					return true;
				}
				goto IL_011d;
				IL_017f:
				MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T118/Dialogue1", t118_MaltearTrigo.triggerPlayerNum);
				goto IL_01af;
				IL_01af:
				if (t118_MaltearTrigo.AAOPIEDAKKD(1))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 6;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 7;
				return true;
				IL_011d:
				if (!t118_MaltearTrigo.CLJJAIEMOLN())
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 3;
					return true;
				}
				_003C_003E2__current = ((MonoBehaviour)t118_MaltearTrigo).StartCoroutine(t118_MaltearTrigo.CDICFNAMCEE());
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

	private void OKHLMNGJOND(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.CIGFGKKCPCK() == 11)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(MNIGNHIODPO));
			NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			((MonoBehaviour)this).StartCoroutine(BJPDFDCOJKJ());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private IEnumerator LAMBONHALKD()
	{
		yield return CommonReferences.wait2;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T118/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator AFHGHLOCAPA()
	{
		yield return CommonReferences.wait2;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T118/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator AJJHBJHCACM()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator ANLLGDBMBAE()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private void GEONGEAEHPM(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.CIGFGKKCPCK() == -94)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(NMDCGGEHIGJ));
			NewTutorialManager.instance.FOIOHOGACAL(0);
			((MonoBehaviour)this).StartCoroutine(NHPCNDODFAK());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private IEnumerator CAKPGBAIIPI()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator MPJMCMIMHFC()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private void DNBGKHKGOEM(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.CIGFGKKCPCK(DAINLFIMLIH: false) == -95)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(commonReferences.OnRecipeToCraftAdded, new Action<int, Recipe>(FLCCNECNMDO));
			NewTutorialManager.instance.ObjectiveCompleted(1);
			((MonoBehaviour)this).StartCoroutine(BJPDFDCOJKJ());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private IEnumerator PPMPKJECPDE()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HFKKGFOFLBJ()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator PIHPPADDGMG()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void NMDCGGEHIGJ(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.JPNFKDMFKMC() == -55)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(CKNFKJJPPGJ));
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			((MonoBehaviour)this).StartCoroutine(NHPCNDODFAK());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private IEnumerator LHIPOAGIOJK()
	{
		bool loadedFromSave = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
			loadedFromSave = true;
		}
		if (!loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		}
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.4375f, 917.3125f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		while (GameCraftingUI.Get(1).IsOpen())
		{
			yield return null;
		}
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		if (!loadedFromSave)
		{
			yield return CommonReferences.wait2;
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T118/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		RecipesManager.UnlockRecipe(506, IBHGAMNNOHI: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(673)).transform.position), Vector2.up * 0.7f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Combine(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(EECHIAJHKLD));
	}

	private void HMPIIOKPGNE(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.JDJGFAACPFC() == -19)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(commonReferences.OnRecipeToCraftAdded, new Action<int, Recipe>(NMDCGGEHIGJ));
			NewTutorialManager.instance.ObjectiveCompleted(0);
			((MonoBehaviour)this).StartCoroutine(BGFNCKGFJPG());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private IEnumerator PBEKBJIJFDK()
	{
		bool loadedFromSave = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
			loadedFromSave = true;
		}
		if (!loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		}
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.4375f, 917.3125f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		while (GameCraftingUI.Get(1).IsOpen())
		{
			yield return null;
		}
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		if (!loadedFromSave)
		{
			yield return CommonReferences.wait2;
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T118/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		RecipesManager.UnlockRecipe(506, IBHGAMNNOHI: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(673)).transform.position), Vector2.up * 0.7f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Combine(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(EECHIAJHKLD));
	}

	public override int GetID()
	{
		return 118;
	}

	private void OCJOMNIEHED(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.JDJGFAACPFC(DAINLFIMLIH: false) == 26)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(commonReferences.OnRecipeToCraftAdded, new Action<int, Recipe>(PNCPFALOIED));
			NewTutorialManager.instance.ObjectiveCompleted(1);
			((MonoBehaviour)this).StartCoroutine(NHPCNDODFAK());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private IEnumerator GGACDGHOJEF()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HOCIHMHCEAK()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LNFHFIMPNHD()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator BJPDFDCOJKJ()
	{
		yield return CommonReferences.wait2;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T118/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator JKLDKCKPFBJ()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AOJFNNKFCBL()
	{
		yield return CommonReferences.wait2;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T118/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private void PGKOOGDFJDE(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.JDJGFAACPFC(DAINLFIMLIH: false) == -10)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(NMDCGGEHIGJ));
			NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			((MonoBehaviour)this).StartCoroutine(BOMICOPCCML());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private IEnumerator JIJEDGBCENE()
	{
		bool loadedFromSave = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
			loadedFromSave = true;
		}
		if (!loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		}
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.4375f, 917.3125f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		while (GameCraftingUI.Get(1).IsOpen())
		{
			yield return null;
		}
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		if (!loadedFromSave)
		{
			yield return CommonReferences.wait2;
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T118/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		RecipesManager.UnlockRecipe(506, IBHGAMNNOHI: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(673)).transform.position), Vector2.up * 0.7f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Combine(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(EECHIAJHKLD));
	}

	private void AHGEPHIIGON(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.JGHNDJBCFAJ() == 181)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(commonReferences.OnRecipeToCraftAdded, new Action<int, Recipe>(EIKABBDNFDL));
			NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			((MonoBehaviour)this).StartCoroutine(ANLLGDBMBAE());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private IEnumerator NHPCNDODFAK()
	{
		yield return CommonReferences.wait2;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T118/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private void IIBJBNLLMEM(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.CIGFGKKCPCK() == 92)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(commonReferences.OnRecipeToCraftAdded, new Action<int, Recipe>(OCJOMNIEHED));
			NewTutorialManager.instance.ObjectiveCompleted(1);
			((MonoBehaviour)this).StartCoroutine(ANLLGDBMBAE());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private void PNCPFALOIED(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.JGHNDJBCFAJ() == -3)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(MNIGNHIODPO));
			NewTutorialManager.instance.FOIOHOGACAL(0);
			((MonoBehaviour)this).StartCoroutine(CAKPGBAIIPI());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private IEnumerator FGLMKBOMOBA()
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

	private IEnumerator AKMGPONCFHL()
	{
		bool loadedFromSave = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
			loadedFromSave = true;
		}
		if (!loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		}
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.4375f, 917.3125f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		while (GameCraftingUI.Get(1).IsOpen())
		{
			yield return null;
		}
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		if (!loadedFromSave)
		{
			yield return CommonReferences.wait2;
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T118/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		RecipesManager.UnlockRecipe(506, IBHGAMNNOHI: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(673)).transform.position), Vector2.up * 0.7f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Combine(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(EECHIAJHKLD));
	}

	private IEnumerator BGFNCKGFJPG()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private void JKHKOGGILGK(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.ODENMDOJPLC() == 111)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(OCJOMNIEHED));
			NewTutorialManager.instance.ObjectiveCompleted(0);
			((MonoBehaviour)this).StartCoroutine(BAGKLMIFNIH());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private IEnumerator LFANGJJGBFG()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private void NIKAJCFILLD(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.ODENMDOJPLC(DAINLFIMLIH: false) == 63)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(DDCCMBLPIMC));
			NewTutorialManager.instance.ObjectiveCompleted(0);
			((MonoBehaviour)this).StartCoroutine(NBENGPAEGCL());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private IEnumerator LILMJIIMODP()
	{
		bool loadedFromSave = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
			loadedFromSave = true;
		}
		if (!loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		}
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.4375f, 917.3125f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		while (GameCraftingUI.Get(1).IsOpen())
		{
			yield return null;
		}
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		if (!loadedFromSave)
		{
			yield return CommonReferences.wait2;
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T118/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		RecipesManager.UnlockRecipe(506, IBHGAMNNOHI: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(673)).transform.position), Vector2.up * 0.7f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Combine(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(EECHIAJHKLD));
	}

	private void MBJMOAEIMAB(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.JGHNDJBCFAJ() == -86)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(commonReferences.OnRecipeToCraftAdded, new Action<int, Recipe>(GEONGEAEHPM));
			NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			((MonoBehaviour)this).StartCoroutine(ANLLGDBMBAE());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private IEnumerator NCNGHNLFCBO()
	{
		bool loadedFromSave = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
			loadedFromSave = true;
		}
		if (!loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		}
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.4375f, 917.3125f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		while (GameCraftingUI.Get(1).IsOpen())
		{
			yield return null;
		}
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		if (!loadedFromSave)
		{
			yield return CommonReferences.wait2;
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T118/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		RecipesManager.UnlockRecipe(506, IBHGAMNNOHI: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(673)).transform.position), Vector2.up * 0.7f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Combine(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(EECHIAJHKLD));
	}

	private void EEGEOJLBFFN(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.JPNFKDMFKMC(DAINLFIMLIH: false) == 55)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(MNIGNHIODPO));
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			((MonoBehaviour)this).StartCoroutine(LGODBMNLILN());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private IEnumerator CIBIOLGHPJF()
	{
		yield return CommonReferences.wait2;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T118/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private void CKNFKJJPPGJ(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.ODENMDOJPLC(DAINLFIMLIH: false) == -194)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(FELMMDAIHGP));
			NewTutorialManager.instance.FOIOHOGACAL(1);
			((MonoBehaviour)this).StartCoroutine(MPJMCMIMHFC());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private IEnumerator FCJODFOFODL()
	{
		bool loadedFromSave = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
			loadedFromSave = true;
		}
		if (!loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		}
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.4375f, 917.3125f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		while (GameCraftingUI.Get(1).IsOpen())
		{
			yield return null;
		}
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		if (!loadedFromSave)
		{
			yield return CommonReferences.wait2;
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T118/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		RecipesManager.UnlockRecipe(506, IBHGAMNNOHI: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(673)).transform.position), Vector2.up * 0.7f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Combine(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(EECHIAJHKLD));
	}

	private IEnumerator AJOIEAICINP()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NBENGPAEGCL()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private void DFNDIGAPCAJ(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.JPNFKDMFKMC(DAINLFIMLIH: false) == 86)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(EECHIAJHKLD));
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			((MonoBehaviour)this).StartCoroutine(GGACDGHOJEF());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private IEnumerator JBBPOCHHHND()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LGODBMNLILN()
	{
		yield return CommonReferences.wait2;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T118/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator CPCGNMPLFHM()
	{
		bool loadedFromSave = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
			loadedFromSave = true;
		}
		if (!loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		}
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.4375f, 917.3125f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		while (GameCraftingUI.Get(1).IsOpen())
		{
			yield return null;
		}
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		if (!loadedFromSave)
		{
			yield return CommonReferences.wait2;
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T118/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		RecipesManager.UnlockRecipe(506, IBHGAMNNOHI: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(673)).transform.position), Vector2.up * 0.7f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Combine(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(EECHIAJHKLD));
	}

	private IEnumerator PBPKJEAAGFE()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void EAEIGJEKDDH(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.IMCJPECAAPC(DAINLFIMLIH: false) == -175)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(DNBGKHKGOEM));
			NewTutorialManager.instance.ObjectiveCompleted(1);
			((MonoBehaviour)this).StartCoroutine(BJPDFDCOJKJ());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private void EECHIAJHKLD(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.JDJGFAACPFC() == 1544)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(EECHIAJHKLD));
			NewTutorialManager.instance.ObjectiveCompleted(0);
			((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private void MNIGNHIODPO(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.IMCJPECAAPC() == -47)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(commonReferences.OnRecipeToCraftAdded, new Action<int, Recipe>(PNCPFALOIED));
			NewTutorialManager.instance.FOIOHOGACAL(0);
			((MonoBehaviour)this).StartCoroutine(BAGKLMIFNIH());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private void FLCCNECNMDO(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.JPNFKDMFKMC(DAINLFIMLIH: false) == -79)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(commonReferences.OnRecipeToCraftAdded, new Action<int, Recipe>(HMPIIOKPGNE));
			NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			((MonoBehaviour)this).StartCoroutine(GGACDGHOJEF());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private IEnumerator IHGGOFFGMBD()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	public override void SetUp()
	{
		base.SetUp();
		((MonoBehaviour)this).StartCoroutine(PBEKBJIJFDK());
	}

	private IEnumerator HCKDBDMBMFL()
	{
		yield return CommonReferences.wait2;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T118/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private void EIKABBDNFDL(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.JPNFKDMFKMC() == -58)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(commonReferences.OnRecipeToCraftAdded, new Action<int, Recipe>(JKHKOGGILGK));
			NewTutorialManager.instance.ObjectiveCompleted(0);
			((MonoBehaviour)this).StartCoroutine(AFHGHLOCAPA());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private void PCMNGNADLEB(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.CIGFGKKCPCK() == 162)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(commonReferences.OnRecipeToCraftAdded, new Action<int, Recipe>(IIBJBNLLMEM));
			NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			((MonoBehaviour)this).StartCoroutine(ANLLGDBMBAE());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private IEnumerator FDMJPHBJACE()
	{
		yield return CommonReferences.wait2;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T118/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private void KHGBOEFFFBK(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.CIGFGKKCPCK(DAINLFIMLIH: false) == 192)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(EIKABBDNFDL));
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			((MonoBehaviour)this).StartCoroutine(GGACDGHOJEF());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private IEnumerator BOMICOPCCML()
	{
		yield return CommonReferences.wait2;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T118/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private void DDCCMBLPIMC(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.JDJGFAACPFC(DAINLFIMLIH: false) == 18)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(FLCCNECNMDO));
			NewTutorialManager.instance.ObjectiveCompleted(1);
			((MonoBehaviour)this).StartCoroutine(ANLLGDBMBAE());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private void FELMMDAIHGP(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.JPNFKDMFKMC() == -87)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(EIKABBDNFDL));
			NewTutorialManager.instance.FOIOHOGACAL(1);
			((MonoBehaviour)this).StartCoroutine(AFHGHLOCAPA());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private IEnumerator EOCBHNPFJLL()
	{
		bool loadedFromSave = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
			loadedFromSave = true;
		}
		if (!loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		}
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.4375f, 917.3125f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		while (GameCraftingUI.Get(1).IsOpen())
		{
			yield return null;
		}
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		if (!loadedFromSave)
		{
			yield return CommonReferences.wait2;
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T118/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		RecipesManager.UnlockRecipe(506, IBHGAMNNOHI: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(673)).transform.position), Vector2.up * 0.7f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Combine(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(EECHIAJHKLD));
	}

	private IEnumerator NBAELEJAFAN()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LPNNMDOPCCJ()
	{
		bool loadedFromSave = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
			loadedFromSave = true;
		}
		if (!loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		}
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.4375f, 917.3125f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		while (GameCraftingUI.Get(1).IsOpen())
		{
			yield return null;
		}
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		if (!loadedFromSave)
		{
			yield return CommonReferences.wait2;
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T118/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		RecipesManager.UnlockRecipe(506, IBHGAMNNOHI: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(673)).transform.position), Vector2.up * 0.7f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Combine(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(EECHIAJHKLD));
	}

	private IEnumerator LHDDHIJIFCN()
	{
		yield return CommonReferences.wait2;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T118/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator ELPINNBKFIP()
	{
		yield return CommonReferences.wait2;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T118/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator BAGKLMIFNIH()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AAOCEAKDPDK()
	{
		bool loadedFromSave = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
			loadedFromSave = true;
		}
		if (!loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		}
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.4375f, 917.3125f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		while (GameCraftingUI.Get(1).IsOpen())
		{
			yield return null;
		}
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		if (!loadedFromSave)
		{
			yield return CommonReferences.wait2;
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T118/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		RecipesManager.UnlockRecipe(506, IBHGAMNNOHI: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(673)).transform.position), Vector2.up * 0.7f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Combine(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(EECHIAJHKLD));
	}
}
