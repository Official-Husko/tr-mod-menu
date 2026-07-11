using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class T138_DesbloqueaReceta : TutorialPhaseBase
{
	[CompilerGenerated]
	private sealed class ILGBEHOLOGL : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T138_DesbloqueaReceta _003C_003E4__this;

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
			T138_DesbloqueaReceta t138_DesbloqueaReceta = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				if ((Object)(object)MaiNPC.GGFJGHHHEJC != (Object)null)
				{
					MaiNPC.GGFJGHHHEJC.SetTrigger("Transform");
				}
				goto IL_007e;
			case 1:
				_003C_003E1__state = -1;
				goto IL_007e;
			case 2:
				_003C_003E1__state = -1;
				_003C_003E2__current = ((MonoBehaviour)t138_DesbloqueaReceta).StartCoroutine(t138_DesbloqueaReceta.CDICFNAMCEE());
				_003C_003E1__state = 3;
				return true;
			case 3:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T138/Dialogue1", t138_DesbloqueaReceta.triggerPlayerNum);
				goto IL_0106;
			case 4:
				_003C_003E1__state = -1;
				goto IL_0106;
			case 5:
				_003C_003E1__state = -1;
				t138_DesbloqueaReceta.ResetMai();
				goto IL_0158;
			case 6:
				_003C_003E1__state = -1;
				goto IL_0158;
			case 7:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
				MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T138/Dialogue2", t138_DesbloqueaReceta.triggerPlayerNum);
				goto IL_01c1;
			case 8:
				_003C_003E1__state = -1;
				goto IL_01c1;
			case 9:
				_003C_003E1__state = -1;
				CommonReferences.GGFJGHHHEJC.OnActionDone(1, ActionDone.FinishMaiTutorial);
				PlayerPrefs.SetInt("tutorialCompleted", 1);
				PlayerPrefs.Save();
				Utils.disableHalloweenEvent = false;
				Utils.disableChristmasEvent = false;
				t138_DesbloqueaReceta.LHKIJABBBPM();
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 10;
				return true;
			case 10:
				{
					_003C_003E1__state = -1;
					ChristmasEvent.instance.OnLoadingBarFinished();
					return false;
				}
				IL_01c1:
				if (t138_DesbloqueaReceta.AAOPIEDAKKD(2))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 8;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 9;
				return true;
				IL_007e:
				if (t138_DesbloqueaReceta.LJNJGMLHCIC() || t138_DesbloqueaReceta.FMMJDDBDPCP())
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
				NewTutorialManager.instance.ShowObjectives(MFAAMBHBBJO: false);
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 2;
				return true;
				IL_0158:
				if (!t138_DesbloqueaReceta.AOOKIKFINFB())
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 6;
					return true;
				}
				_003C_003E2__current = ((MonoBehaviour)t138_DesbloqueaReceta).StartCoroutine(t138_DesbloqueaReceta.CDICFNAMCEE());
				_003C_003E1__state = 7;
				return true;
				IL_0106:
				if (t138_DesbloqueaReceta.AAOPIEDAKKD(1))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 4;
					return true;
				}
				MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
				_003C_003E2__current = CommonReferences.wait2;
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

	[CompilerGenerated]
	private sealed class DBHBDMOHMPM : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T138_DesbloqueaReceta _003C_003E4__this;

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
			T138_DesbloqueaReceta @object = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
			{
				_003C_003E1__state = -1;
				NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
				RecipesManager instance = RecipesManager.GGFJGHHHEJC;
				instance.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Combine(instance.OnAnyRecipeUnlocked, new Action<Recipe>(@object.JDJPBCFPIDN));
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 1;
				return true;
			}
			case 1:
				_003C_003E1__state = -1;
				NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
				NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
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

	private IEnumerator PIHPPADDGMG()
	{
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		RecipesManager instance = RecipesManager.GGFJGHHHEJC;
		instance.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Combine(instance.OnAnyRecipeUnlocked, new Action<Recipe>(JDJPBCFPIDN));
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
	}

	private IEnumerator NBENGPAEGCL()
	{
		if ((Object)(object)MaiNPC.GGFJGHHHEJC != (Object)null)
		{
			MaiNPC.GGFJGHHHEJC.SetTrigger("Transform");
		}
		while (LJNJGMLHCIC() || FMMJDDBDPCP())
		{
			yield return null;
		}
		NewTutorialManager.instance.ShowObjectives(MFAAMBHBBJO: false);
		yield return CommonReferences.wait2;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T138/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		ResetMai();
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T138/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		CommonReferences.GGFJGHHHEJC.OnActionDone(1, ActionDone.FinishMaiTutorial);
		PlayerPrefs.SetInt("tutorialCompleted", 1);
		PlayerPrefs.Save();
		Utils.disableHalloweenEvent = false;
		Utils.disableChristmasEvent = false;
		LHKIJABBBPM();
		yield return CommonReferences.wait2;
		ChristmasEvent.instance.OnLoadingBarFinished();
	}

	private void GEDODLFIDEC(Recipe JNLKEMLDFIM)
	{
		NewTutorialManager.instance.recipePurchased = false;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		RecipesManager instance = RecipesManager.GGFJGHHHEJC;
		instance.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Remove(instance.OnAnyRecipeUnlocked, new Action<Recipe>(LEOIKNBAKAA));
		((MonoBehaviour)this).StartCoroutine(IAOFDDMPMBJ());
	}

	private IEnumerator GFMGFHGPGCM()
	{
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		RecipesManager instance = RecipesManager.GGFJGHHHEJC;
		instance.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Combine(instance.OnAnyRecipeUnlocked, new Action<Recipe>(JDJPBCFPIDN));
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
	}

	private void NBEHFJPPBIH(Recipe JNLKEMLDFIM)
	{
		NewTutorialManager.instance.recipePurchased = false;
		NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
		RecipesManager recipesManager = RecipesManager.MPFJOKOJIOO();
		recipesManager.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Remove(recipesManager.OnAnyRecipeUnlocked, new Action<Recipe>(KAABEFCHMJC));
		((MonoBehaviour)this).StartCoroutine(CKIMLLCOEGC());
	}

	private void BEADFHFCDEE(Recipe JNLKEMLDFIM)
	{
		NewTutorialManager.instance.recipePurchased = true;
		NewTutorialManager.instance.ObjectiveCompleted(1);
		RecipesManager recipesManager = RecipesManager.MPFJOKOJIOO();
		recipesManager.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Remove(recipesManager.OnAnyRecipeUnlocked, new Action<Recipe>(AFDPBPOMMJP));
		((MonoBehaviour)this).StartCoroutine(OKJDBENIAEP());
	}

	private IEnumerator JIFEIKLKIMF()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void OMFDPLGNJBG(Recipe JNLKEMLDFIM)
	{
		NewTutorialManager.instance.recipePurchased = true;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		RecipesManager instance = RecipesManager.GGFJGHHHEJC;
		instance.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Remove(instance.OnAnyRecipeUnlocked, new Action<Recipe>(NJPEHAJHLAJ));
		((MonoBehaviour)this).StartCoroutine(HNFCACDCBBO());
	}

	private void BNFFMKPOCJG(Recipe JNLKEMLDFIM)
	{
		NewTutorialManager.instance.recipePurchased = false;
		NewTutorialManager.instance.ObjectiveCompleted(1);
		RecipesManager instance = RecipesManager.GGFJGHHHEJC;
		instance.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Remove(instance.OnAnyRecipeUnlocked, new Action<Recipe>(KMHIIBBDLGM));
		((MonoBehaviour)this).StartCoroutine(COMPHHHBLIO());
	}

	private void JOIAHGOMKHN(Recipe JNLKEMLDFIM)
	{
		NewTutorialManager.instance.recipePurchased = true;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		RecipesManager instance = RecipesManager.GGFJGHHHEJC;
		instance.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Remove(instance.OnAnyRecipeUnlocked, new Action<Recipe>(AKHGANBFPKH));
		((MonoBehaviour)this).StartCoroutine(CAKPGBAIIPI());
	}

	private void KAABEFCHMJC(Recipe JNLKEMLDFIM)
	{
		NewTutorialManager.instance.recipePurchased = true;
		NewTutorialManager.instance.ObjectiveCompleted(1);
		RecipesManager recipesManager = RecipesManager.MPFJOKOJIOO();
		recipesManager.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Remove(recipesManager.OnAnyRecipeUnlocked, new Action<Recipe>(JJGBIMCDLEJ));
		((MonoBehaviour)this).StartCoroutine(JEGFAKDNMIC());
	}

	private IEnumerator JCMMNNCKPDO()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void CKJPLJMPBPD(Recipe JNLKEMLDFIM)
	{
		NewTutorialManager.instance.recipePurchased = true;
		NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
		RecipesManager instance = RecipesManager.GGFJGHHHEJC;
		instance.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Remove(instance.OnAnyRecipeUnlocked, new Action<Recipe>(BOHDGFMBGEI));
		((MonoBehaviour)this).StartCoroutine(NBENGPAEGCL());
	}

	private void DLCCGHBPBIN(Recipe JNLKEMLDFIM)
	{
		NewTutorialManager.instance.recipePurchased = false;
		NewTutorialManager.instance.ObjectiveCompleted(1);
		RecipesManager instance = RecipesManager.GGFJGHHHEJC;
		instance.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Remove(instance.OnAnyRecipeUnlocked, new Action<Recipe>(PCMLKIPFCOE));
		((MonoBehaviour)this).StartCoroutine(NBENGPAEGCL());
	}

	private IEnumerator OBCHIKLEMKF()
	{
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		RecipesManager instance = RecipesManager.GGFJGHHHEJC;
		instance.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Combine(instance.OnAnyRecipeUnlocked, new Action<Recipe>(JDJPBCFPIDN));
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
	}

	private IEnumerator LHDDHIJIFCN()
	{
		if ((Object)(object)MaiNPC.GGFJGHHHEJC != (Object)null)
		{
			MaiNPC.GGFJGHHHEJC.SetTrigger("Transform");
		}
		while (LJNJGMLHCIC() || FMMJDDBDPCP())
		{
			yield return null;
		}
		NewTutorialManager.instance.ShowObjectives(MFAAMBHBBJO: false);
		yield return CommonReferences.wait2;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T138/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		ResetMai();
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T138/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		CommonReferences.GGFJGHHHEJC.OnActionDone(1, ActionDone.FinishMaiTutorial);
		PlayerPrefs.SetInt("tutorialCompleted", 1);
		PlayerPrefs.Save();
		Utils.disableHalloweenEvent = false;
		Utils.disableChristmasEvent = false;
		LHKIJABBBPM();
		yield return CommonReferences.wait2;
		ChristmasEvent.instance.OnLoadingBarFinished();
	}

	private void JCPDIFIFPHM(Recipe JNLKEMLDFIM)
	{
		NewTutorialManager.instance.recipePurchased = true;
		NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
		RecipesManager recipesManager = RecipesManager.MPFJOKOJIOO();
		recipesManager.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Remove(recipesManager.OnAnyRecipeUnlocked, new Action<Recipe>(DLCCGHBPBIN));
		((MonoBehaviour)this).StartCoroutine(KGIJEMPBBED());
	}

	private void AFDPBPOMMJP(Recipe JNLKEMLDFIM)
	{
		NewTutorialManager.instance.recipePurchased = true;
		NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
		RecipesManager instance = RecipesManager.GGFJGHHHEJC;
		instance.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Remove(instance.OnAnyRecipeUnlocked, new Action<Recipe>(KAABEFCHMJC));
		((MonoBehaviour)this).StartCoroutine(AOJFNNKFCBL());
	}

	private void AHADMLOBEEO(Recipe JNLKEMLDFIM)
	{
		NewTutorialManager.instance.recipePurchased = true;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		RecipesManager recipesManager = RecipesManager.MPFJOKOJIOO();
		recipesManager.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Remove(recipesManager.OnAnyRecipeUnlocked, new Action<Recipe>(ONCNLJCCPND));
		((MonoBehaviour)this).StartCoroutine(ELNHMAPENDB());
	}

	private IEnumerator LFFCFNNODFJ()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator EHDIMBMCIDK()
	{
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		RecipesManager instance = RecipesManager.GGFJGHHHEJC;
		instance.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Combine(instance.OnAnyRecipeUnlocked, new Action<Recipe>(JDJPBCFPIDN));
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
	}

	private IEnumerator DCEJFBKLGCD()
	{
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		RecipesManager instance = RecipesManager.GGFJGHHHEJC;
		instance.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Combine(instance.OnAnyRecipeUnlocked, new Action<Recipe>(JDJPBCFPIDN));
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
	}

	private void AILNOACEAAG(Recipe JNLKEMLDFIM)
	{
		NewTutorialManager.instance.recipePurchased = true;
		NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
		RecipesManager instance = RecipesManager.GGFJGHHHEJC;
		instance.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Remove(instance.OnAnyRecipeUnlocked, new Action<Recipe>(NJPEHAJHLAJ));
		((MonoBehaviour)this).StartCoroutine(LFFCFNNODFJ());
	}

	private void GOJLGKJOLLE(Recipe JNLKEMLDFIM)
	{
		NewTutorialManager.instance.recipePurchased = true;
		NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
		RecipesManager instance = RecipesManager.GGFJGHHHEJC;
		instance.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Remove(instance.OnAnyRecipeUnlocked, new Action<Recipe>(BOHDGFMBGEI));
		((MonoBehaviour)this).StartCoroutine(LGODBMNLILN());
	}

	private IEnumerator LGJLBBOBIJI()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LHIPOAGIOJK()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void KMHIIBBDLGM(Recipe JNLKEMLDFIM)
	{
		NewTutorialManager.instance.recipePurchased = true;
		NewTutorialManager.instance.ObjectiveCompleted(1);
		RecipesManager instance = RecipesManager.GGFJGHHHEJC;
		instance.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Remove(instance.OnAnyRecipeUnlocked, new Action<Recipe>(INHJFKBKOHA));
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator PBEKBJIJFDK()
	{
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		RecipesManager instance = RecipesManager.GGFJGHHHEJC;
		instance.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Combine(instance.OnAnyRecipeUnlocked, new Action<Recipe>(JDJPBCFPIDN));
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
	}

	private void BOEBAJIEMKL(Recipe JNLKEMLDFIM)
	{
		NewTutorialManager.instance.recipePurchased = false;
		NewTutorialManager.instance.FOIOHOGACAL(1);
		RecipesManager instance = RecipesManager.GGFJGHHHEJC;
		instance.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Remove(instance.OnAnyRecipeUnlocked, new Action<Recipe>(OMFDPLGNJBG));
		((MonoBehaviour)this).StartCoroutine(LGODBMNLILN());
	}

	private void AKHGANBFPKH(Recipe JNLKEMLDFIM)
	{
		NewTutorialManager.instance.recipePurchased = false;
		NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
		RecipesManager instance = RecipesManager.GGFJGHHHEJC;
		instance.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Remove(instance.OnAnyRecipeUnlocked, new Action<Recipe>(KAABEFCHMJC));
		((MonoBehaviour)this).StartCoroutine(AJGJPBMIEJJ());
	}

	private IEnumerator EKMOJHNJOCG()
	{
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		RecipesManager instance = RecipesManager.GGFJGHHHEJC;
		instance.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Combine(instance.OnAnyRecipeUnlocked, new Action<Recipe>(JDJPBCFPIDN));
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
	}

	private IEnumerator EBJFNGDABLK()
	{
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		RecipesManager instance = RecipesManager.GGFJGHHHEJC;
		instance.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Combine(instance.OnAnyRecipeUnlocked, new Action<Recipe>(JDJPBCFPIDN));
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
	}

	private IEnumerator HFMMNGELPGN()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void INHJFKBKOHA(Recipe JNLKEMLDFIM)
	{
		NewTutorialManager.instance.recipePurchased = true;
		NewTutorialManager.instance.ObjectiveCompleted(1);
		RecipesManager recipesManager = RecipesManager.MPFJOKOJIOO();
		recipesManager.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Remove(recipesManager.OnAnyRecipeUnlocked, new Action<Recipe>(INHJFKBKOHA));
		((MonoBehaviour)this).StartCoroutine(JAKPMNEGELN());
	}

	private IEnumerator COMPHHHBLIO()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator ELNHMAPENDB()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private void OKFLHCEBGJA(Recipe JNLKEMLDFIM)
	{
		NewTutorialManager.instance.recipePurchased = false;
		NewTutorialManager.instance.ObjectiveCompleted(1);
		RecipesManager recipesManager = RecipesManager.MPFJOKOJIOO();
		recipesManager.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Remove(recipesManager.OnAnyRecipeUnlocked, new Action<Recipe>(NBEHFJPPBIH));
		((MonoBehaviour)this).StartCoroutine(IAOFDDMPMBJ());
	}

	private void NPKIOFNLBBK(Recipe JNLKEMLDFIM)
	{
		NewTutorialManager.instance.recipePurchased = true;
		NewTutorialManager.instance.FOIOHOGACAL(0);
		RecipesManager recipesManager = RecipesManager.MPFJOKOJIOO();
		recipesManager.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Remove(recipesManager.OnAnyRecipeUnlocked, new Action<Recipe>(JJGBIMCDLEJ));
		((MonoBehaviour)this).StartCoroutine(HNFCACDCBBO());
	}

	private IEnumerator NHLLGDCFOFC()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void BKGFIDGJJPN(Recipe JNLKEMLDFIM)
	{
		NewTutorialManager.instance.recipePurchased = true;
		NewTutorialManager.instance.FOIOHOGACAL(1);
		RecipesManager recipesManager = RecipesManager.MPFJOKOJIOO();
		recipesManager.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Remove(recipesManager.OnAnyRecipeUnlocked, new Action<Recipe>(JCPDIFIFPHM));
		((MonoBehaviour)this).StartCoroutine(CAKPGBAIIPI());
	}

	private IEnumerator OCHEOJEEFGA()
	{
		if ((Object)(object)MaiNPC.GGFJGHHHEJC != (Object)null)
		{
			MaiNPC.GGFJGHHHEJC.SetTrigger("Transform");
		}
		while (LJNJGMLHCIC() || FMMJDDBDPCP())
		{
			yield return null;
		}
		NewTutorialManager.instance.ShowObjectives(MFAAMBHBBJO: false);
		yield return CommonReferences.wait2;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T138/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		ResetMai();
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T138/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		CommonReferences.GGFJGHHHEJC.OnActionDone(1, ActionDone.FinishMaiTutorial);
		PlayerPrefs.SetInt("tutorialCompleted", 1);
		PlayerPrefs.Save();
		Utils.disableHalloweenEvent = false;
		Utils.disableChristmasEvent = false;
		LHKIJABBBPM();
		yield return CommonReferences.wait2;
		ChristmasEvent.instance.OnLoadingBarFinished();
	}

	private void DHNLBAKEABD(Recipe JNLKEMLDFIM)
	{
		NewTutorialManager.instance.recipePurchased = true;
		NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
		RecipesManager recipesManager = RecipesManager.MPFJOKOJIOO();
		recipesManager.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Remove(recipesManager.OnAnyRecipeUnlocked, new Action<Recipe>(IEIDMPJLFKP));
		((MonoBehaviour)this).StartCoroutine(NBENGPAEGCL());
	}

	private void MGJJKIBMEII(Recipe JNLKEMLDFIM)
	{
		NewTutorialManager.instance.recipePurchased = true;
		NewTutorialManager.instance.FOIOHOGACAL(0);
		RecipesManager recipesManager = RecipesManager.MPFJOKOJIOO();
		recipesManager.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Remove(recipesManager.OnAnyRecipeUnlocked, new Action<Recipe>(JCPDIFIFPHM));
		((MonoBehaviour)this).StartCoroutine(LGODBMNLILN());
	}

	private IEnumerator PDAEFKAMACE()
	{
		if ((Object)(object)MaiNPC.GGFJGHHHEJC != (Object)null)
		{
			MaiNPC.GGFJGHHHEJC.SetTrigger("Transform");
		}
		while (LJNJGMLHCIC() || FMMJDDBDPCP())
		{
			yield return null;
		}
		NewTutorialManager.instance.ShowObjectives(MFAAMBHBBJO: false);
		yield return CommonReferences.wait2;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T138/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		ResetMai();
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T138/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		CommonReferences.GGFJGHHHEJC.OnActionDone(1, ActionDone.FinishMaiTutorial);
		PlayerPrefs.SetInt("tutorialCompleted", 1);
		PlayerPrefs.Save();
		Utils.disableHalloweenEvent = false;
		Utils.disableChristmasEvent = false;
		LHKIJABBBPM();
		yield return CommonReferences.wait2;
		ChristmasEvent.instance.OnLoadingBarFinished();
	}

	private IEnumerator BPMIGCIFGML()
	{
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		RecipesManager instance = RecipesManager.GGFJGHHHEJC;
		instance.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Combine(instance.OnAnyRecipeUnlocked, new Action<Recipe>(JDJPBCFPIDN));
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
	}

	private void MGGJGBGFDHG(Recipe JNLKEMLDFIM)
	{
		NewTutorialManager.instance.recipePurchased = true;
		NewTutorialManager.instance.ObjectiveCompleted(1);
		RecipesManager instance = RecipesManager.GGFJGHHHEJC;
		instance.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Remove(instance.OnAnyRecipeUnlocked, new Action<Recipe>(DHNLBAKEABD));
		((MonoBehaviour)this).StartCoroutine(LFFCFNNODFJ());
	}

	private IEnumerator EAIFKHKDDEI()
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

	private void IEIDMPJLFKP(Recipe JNLKEMLDFIM)
	{
		NewTutorialManager.instance.recipePurchased = false;
		NewTutorialManager.instance.FOIOHOGACAL(0);
		RecipesManager recipesManager = RecipesManager.MPFJOKOJIOO();
		recipesManager.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Remove(recipesManager.OnAnyRecipeUnlocked, new Action<Recipe>(OCKKLJBHKNG));
		((MonoBehaviour)this).StartCoroutine(COMPHHHBLIO());
	}

	private IEnumerator ANLLGDBMBAE()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private void LEOIKNBAKAA(Recipe JNLKEMLDFIM)
	{
		NewTutorialManager.instance.recipePurchased = true;
		NewTutorialManager.instance.ObjectiveCompleted(1);
		RecipesManager recipesManager = RecipesManager.MPFJOKOJIOO();
		recipesManager.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Remove(recipesManager.OnAnyRecipeUnlocked, new Action<Recipe>(LEOIKNBAKAA));
		((MonoBehaviour)this).StartCoroutine(NBONAPPPLMN());
	}

	private IEnumerator EGAGPFBFKIL()
	{
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		RecipesManager instance = RecipesManager.GGFJGHHHEJC;
		instance.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Combine(instance.OnAnyRecipeUnlocked, new Action<Recipe>(JDJPBCFPIDN));
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
	}

	private IEnumerator IGEOMOOKOEP()
	{
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		RecipesManager instance = RecipesManager.GGFJGHHHEJC;
		instance.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Combine(instance.OnAnyRecipeUnlocked, new Action<Recipe>(JDJPBCFPIDN));
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
	}

	private void PAGOEJPFMFM(Recipe JNLKEMLDFIM)
	{
		NewTutorialManager.instance.recipePurchased = true;
		NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
		RecipesManager recipesManager = RecipesManager.MPFJOKOJIOO();
		recipesManager.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Remove(recipesManager.OnAnyRecipeUnlocked, new Action<Recipe>(CKJPLJMPBPD));
		((MonoBehaviour)this).StartCoroutine(LGJLBBOBIJI());
	}

	private void HKGDENMEPPM(Recipe JNLKEMLDFIM)
	{
		NewTutorialManager.instance.recipePurchased = true;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		RecipesManager recipesManager = RecipesManager.MPFJOKOJIOO();
		recipesManager.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Remove(recipesManager.OnAnyRecipeUnlocked, new Action<Recipe>(LDMMBAFOALP));
		((MonoBehaviour)this).StartCoroutine(OCHEOJEEFGA());
	}

	private void JJGBIMCDLEJ(Recipe JNLKEMLDFIM)
	{
		NewTutorialManager.instance.recipePurchased = true;
		NewTutorialManager.instance.FOIOHOGACAL(1);
		RecipesManager instance = RecipesManager.GGFJGHHHEJC;
		instance.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Remove(instance.OnAnyRecipeUnlocked, new Action<Recipe>(MGGJGBGFDHG));
		((MonoBehaviour)this).StartCoroutine(LGODBMNLILN());
	}

	private void CPLIGELDEHG(Recipe JNLKEMLDFIM)
	{
		NewTutorialManager.instance.recipePurchased = false;
		NewTutorialManager.instance.ObjectiveCompleted(1);
		RecipesManager recipesManager = RecipesManager.MPFJOKOJIOO();
		recipesManager.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Remove(recipesManager.OnAnyRecipeUnlocked, new Action<Recipe>(AKHGANBFPKH));
		((MonoBehaviour)this).StartCoroutine(IAOFDDMPMBJ());
	}

	private void OCKKLJBHKNG(Recipe JNLKEMLDFIM)
	{
		NewTutorialManager.instance.recipePurchased = true;
		NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
		RecipesManager instance = RecipesManager.GGFJGHHHEJC;
		instance.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Remove(instance.OnAnyRecipeUnlocked, new Action<Recipe>(AHADMLOBEEO));
		((MonoBehaviour)this).StartCoroutine(MPJMCMIMHFC());
	}

	private IEnumerator KMIBOOOFJKB()
	{
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		RecipesManager instance = RecipesManager.GGFJGHHHEJC;
		instance.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Combine(instance.OnAnyRecipeUnlocked, new Action<Recipe>(JDJPBCFPIDN));
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
	}

	private IEnumerator HNFCACDCBBO()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JEGFAKDNMIC()
	{
		if ((Object)(object)MaiNPC.GGFJGHHHEJC != (Object)null)
		{
			MaiNPC.GGFJGHHHEJC.SetTrigger("Transform");
		}
		while (LJNJGMLHCIC() || FMMJDDBDPCP())
		{
			yield return null;
		}
		NewTutorialManager.instance.ShowObjectives(MFAAMBHBBJO: false);
		yield return CommonReferences.wait2;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T138/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		ResetMai();
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T138/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		CommonReferences.GGFJGHHHEJC.OnActionDone(1, ActionDone.FinishMaiTutorial);
		PlayerPrefs.SetInt("tutorialCompleted", 1);
		PlayerPrefs.Save();
		Utils.disableHalloweenEvent = false;
		Utils.disableChristmasEvent = false;
		LHKIJABBBPM();
		yield return CommonReferences.wait2;
		ChristmasEvent.instance.OnLoadingBarFinished();
	}

	private IEnumerator OPCHFFMKPCN()
	{
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		RecipesManager instance = RecipesManager.GGFJGHHHEJC;
		instance.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Combine(instance.OnAnyRecipeUnlocked, new Action<Recipe>(JDJPBCFPIDN));
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
	}

	private IEnumerator IHGGOFFGMBD()
	{
		if ((Object)(object)MaiNPC.GGFJGHHHEJC != (Object)null)
		{
			MaiNPC.GGFJGHHHEJC.SetTrigger("Transform");
		}
		while (LJNJGMLHCIC() || FMMJDDBDPCP())
		{
			yield return null;
		}
		NewTutorialManager.instance.ShowObjectives(MFAAMBHBBJO: false);
		yield return CommonReferences.wait2;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T138/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		ResetMai();
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T138/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		CommonReferences.GGFJGHHHEJC.OnActionDone(1, ActionDone.FinishMaiTutorial);
		PlayerPrefs.SetInt("tutorialCompleted", 1);
		PlayerPrefs.Save();
		Utils.disableHalloweenEvent = false;
		Utils.disableChristmasEvent = false;
		LHKIJABBBPM();
		yield return CommonReferences.wait2;
		ChristmasEvent.instance.OnLoadingBarFinished();
	}

	private void JDJPBCFPIDN(Recipe JNLKEMLDFIM)
	{
		NewTutorialManager.instance.recipePurchased = true;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		RecipesManager instance = RecipesManager.GGFJGHHHEJC;
		instance.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Remove(instance.OnAnyRecipeUnlocked, new Action<Recipe>(JDJPBCFPIDN));
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator OAIEBGHEBAK()
	{
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		RecipesManager instance = RecipesManager.GGFJGHHHEJC;
		instance.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Combine(instance.OnAnyRecipeUnlocked, new Action<Recipe>(JDJPBCFPIDN));
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
	}

	private void LOAOLGGEENL(Recipe JNLKEMLDFIM)
	{
		NewTutorialManager.instance.recipePurchased = false;
		NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
		RecipesManager instance = RecipesManager.GGFJGHHHEJC;
		instance.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Remove(instance.OnAnyRecipeUnlocked, new Action<Recipe>(NPKIOFNLBBK));
		((MonoBehaviour)this).StartCoroutine(AOJFNNKFCBL());
	}

	private IEnumerator JECHOKLEDDA()
	{
		if ((Object)(object)MaiNPC.GGFJGHHHEJC != (Object)null)
		{
			MaiNPC.GGFJGHHHEJC.SetTrigger("Transform");
		}
		while (LJNJGMLHCIC() || FMMJDDBDPCP())
		{
			yield return null;
		}
		NewTutorialManager.instance.ShowObjectives(MFAAMBHBBJO: false);
		yield return CommonReferences.wait2;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T138/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		ResetMai();
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T138/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		CommonReferences.GGFJGHHHEJC.OnActionDone(1, ActionDone.FinishMaiTutorial);
		PlayerPrefs.SetInt("tutorialCompleted", 1);
		PlayerPrefs.Save();
		Utils.disableHalloweenEvent = false;
		Utils.disableChristmasEvent = false;
		LHKIJABBBPM();
		yield return CommonReferences.wait2;
		ChristmasEvent.instance.OnLoadingBarFinished();
	}

	private void BOHDGFMBGEI(Recipe JNLKEMLDFIM)
	{
		NewTutorialManager.instance.recipePurchased = true;
		NewTutorialManager.instance.FOIOHOGACAL(1);
		RecipesManager instance = RecipesManager.GGFJGHHHEJC;
		instance.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Remove(instance.OnAnyRecipeUnlocked, new Action<Recipe>(LOAOLGGEENL));
		((MonoBehaviour)this).StartCoroutine(HNFCACDCBBO());
	}

	private IEnumerator JOBFBHOMJNC()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JAKPMNEGELN()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LGDNIGIMDKP()
	{
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		RecipesManager instance = RecipesManager.GGFJGHHHEJC;
		instance.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Combine(instance.OnAnyRecipeUnlocked, new Action<Recipe>(JDJPBCFPIDN));
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
	}

	private IEnumerator AJGJPBMIEJJ()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator APNIOHEFHLP()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator OKJDBENIAEP()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HGFPMNKEMAC()
	{
		if ((Object)(object)MaiNPC.GGFJGHHHEJC != (Object)null)
		{
			MaiNPC.GGFJGHHHEJC.SetTrigger("Transform");
		}
		while (LJNJGMLHCIC() || FMMJDDBDPCP())
		{
			yield return null;
		}
		NewTutorialManager.instance.ShowObjectives(MFAAMBHBBJO: false);
		yield return CommonReferences.wait2;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T138/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		ResetMai();
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T138/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		CommonReferences.GGFJGHHHEJC.OnActionDone(1, ActionDone.FinishMaiTutorial);
		PlayerPrefs.SetInt("tutorialCompleted", 1);
		PlayerPrefs.Save();
		Utils.disableHalloweenEvent = false;
		Utils.disableChristmasEvent = false;
		LHKIJABBBPM();
		yield return CommonReferences.wait2;
		ChristmasEvent.instance.OnLoadingBarFinished();
	}

	private void DNFLFHFNKEI(Recipe JNLKEMLDFIM)
	{
		NewTutorialManager.instance.recipePurchased = true;
		NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
		RecipesManager recipesManager = RecipesManager.MPFJOKOJIOO();
		recipesManager.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Remove(recipesManager.OnAnyRecipeUnlocked, new Action<Recipe>(AHADMLOBEEO));
		((MonoBehaviour)this).StartCoroutine(PDAEFKAMACE());
	}

	private IEnumerator DABNLFBDKGN()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private void PCMLKIPFCOE(Recipe JNLKEMLDFIM)
	{
		NewTutorialManager.instance.recipePurchased = false;
		NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
		RecipesManager instance = RecipesManager.GGFJGHHHEJC;
		instance.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Remove(instance.OnAnyRecipeUnlocked, new Action<Recipe>(JDJPBCFPIDN));
		((MonoBehaviour)this).StartCoroutine(AJJPECIKMJN());
	}

	private void ONCNLJCCPND(Recipe JNLKEMLDFIM)
	{
		NewTutorialManager.instance.recipePurchased = false;
		NewTutorialManager.instance.ObjectiveCompleted(1);
		RecipesManager instance = RecipesManager.GGFJGHHHEJC;
		instance.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Remove(instance.OnAnyRecipeUnlocked, new Action<Recipe>(OPCHKHCOPBH));
		((MonoBehaviour)this).StartCoroutine(AOJFNNKFCBL());
	}

	private IEnumerator MFFGIOALMIC()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AJJHBJHCACM()
	{
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		RecipesManager instance = RecipesManager.GGFJGHHHEJC;
		instance.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Combine(instance.OnAnyRecipeUnlocked, new Action<Recipe>(JDJPBCFPIDN));
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
	}

	private IEnumerator CCOGIOADJKC()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NNKFBMKFBMN()
	{
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		RecipesManager instance = RecipesManager.GGFJGHHHEJC;
		instance.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Combine(instance.OnAnyRecipeUnlocked, new Action<Recipe>(JDJPBCFPIDN));
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
	}

	private IEnumerator JAHNJFGKFII()
	{
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		RecipesManager instance = RecipesManager.GGFJGHHHEJC;
		instance.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Combine(instance.OnAnyRecipeUnlocked, new Action<Recipe>(JDJPBCFPIDN));
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
	}

	private IEnumerator NBONAPPPLMN()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator IHPLPBAELKL()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JNOOAENGMHL()
	{
		if ((Object)(object)MaiNPC.GGFJGHHHEJC != (Object)null)
		{
			MaiNPC.GGFJGHHHEJC.SetTrigger("Transform");
		}
		while (LJNJGMLHCIC() || FMMJDDBDPCP())
		{
			yield return null;
		}
		NewTutorialManager.instance.ShowObjectives(MFAAMBHBBJO: false);
		yield return CommonReferences.wait2;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T138/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		ResetMai();
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T138/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		CommonReferences.GGFJGHHHEJC.OnActionDone(1, ActionDone.FinishMaiTutorial);
		PlayerPrefs.SetInt("tutorialCompleted", 1);
		PlayerPrefs.Save();
		Utils.disableHalloweenEvent = false;
		Utils.disableChristmasEvent = false;
		LHKIJABBBPM();
		yield return CommonReferences.wait2;
		ChristmasEvent.instance.OnLoadingBarFinished();
	}

	private IEnumerator AKMGPONCFHL()
	{
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		RecipesManager instance = RecipesManager.GGFJGHHHEJC;
		instance.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Combine(instance.OnAnyRecipeUnlocked, new Action<Recipe>(JDJPBCFPIDN));
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
	}

	private IEnumerator AJJPECIKMJN()
	{
		if ((Object)(object)MaiNPC.GGFJGHHHEJC != (Object)null)
		{
			MaiNPC.GGFJGHHHEJC.SetTrigger("Transform");
		}
		while (LJNJGMLHCIC() || FMMJDDBDPCP())
		{
			yield return null;
		}
		NewTutorialManager.instance.ShowObjectives(MFAAMBHBBJO: false);
		yield return CommonReferences.wait2;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T138/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		ResetMai();
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T138/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		CommonReferences.GGFJGHHHEJC.OnActionDone(1, ActionDone.FinishMaiTutorial);
		PlayerPrefs.SetInt("tutorialCompleted", 1);
		PlayerPrefs.Save();
		Utils.disableHalloweenEvent = false;
		Utils.disableChristmasEvent = false;
		LHKIJABBBPM();
		yield return CommonReferences.wait2;
		ChristmasEvent.instance.OnLoadingBarFinished();
	}

	private IEnumerator AOJFNNKFCBL()
	{
		if ((Object)(object)MaiNPC.GGFJGHHHEJC != (Object)null)
		{
			MaiNPC.GGFJGHHHEJC.SetTrigger("Transform");
		}
		while (LJNJGMLHCIC() || FMMJDDBDPCP())
		{
			yield return null;
		}
		NewTutorialManager.instance.ShowObjectives(MFAAMBHBBJO: false);
		yield return CommonReferences.wait2;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T138/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		ResetMai();
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T138/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		CommonReferences.GGFJGHHHEJC.OnActionDone(1, ActionDone.FinishMaiTutorial);
		PlayerPrefs.SetInt("tutorialCompleted", 1);
		PlayerPrefs.Save();
		Utils.disableHalloweenEvent = false;
		Utils.disableChristmasEvent = false;
		LHKIJABBBPM();
		yield return CommonReferences.wait2;
		ChristmasEvent.instance.OnLoadingBarFinished();
	}

	private IEnumerator CKIMLLCOEGC()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private void OPCHKHCOPBH(Recipe JNLKEMLDFIM)
	{
		NewTutorialManager.instance.recipePurchased = false;
		NewTutorialManager.instance.ObjectiveCompleted(1);
		RecipesManager recipesManager = RecipesManager.MPFJOKOJIOO();
		recipesManager.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Remove(recipesManager.OnAnyRecipeUnlocked, new Action<Recipe>(OKFLHCEBGJA));
		((MonoBehaviour)this).StartCoroutine(AJJPECIKMJN());
	}

	private void KPKIGHNFODB(Recipe JNLKEMLDFIM)
	{
		NewTutorialManager.instance.recipePurchased = true;
		NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
		RecipesManager recipesManager = RecipesManager.MPFJOKOJIOO();
		recipesManager.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Remove(recipesManager.OnAnyRecipeUnlocked, new Action<Recipe>(LEOIKNBAKAA));
		((MonoBehaviour)this).StartCoroutine(CKIMLLCOEGC());
	}

	private IEnumerator HEAFCDJINCN()
	{
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		RecipesManager instance = RecipesManager.GGFJGHHHEJC;
		instance.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Combine(instance.OnAnyRecipeUnlocked, new Action<Recipe>(JDJPBCFPIDN));
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
	}

	private IEnumerator BBGHMMLBAME()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JIBIJLBJMCH()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator IAOFDDMPMBJ()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private void LDMMBAFOALP(Recipe JNLKEMLDFIM)
	{
		NewTutorialManager.instance.recipePurchased = true;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		RecipesManager recipesManager = RecipesManager.MPFJOKOJIOO();
		recipesManager.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Remove(recipesManager.OnAnyRecipeUnlocked, new Action<Recipe>(NJPEHAJHLAJ));
		((MonoBehaviour)this).StartCoroutine(JECHOKLEDDA());
	}

	private IEnumerator EJMHFLGBJKM()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JGGBPKEJMIJ()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HNAAFAPLALL()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator CAKPGBAIIPI()
	{
		if ((Object)(object)MaiNPC.GGFJGHHHEJC != (Object)null)
		{
			MaiNPC.GGFJGHHHEJC.SetTrigger("Transform");
		}
		while (LJNJGMLHCIC() || FMMJDDBDPCP())
		{
			yield return null;
		}
		NewTutorialManager.instance.ShowObjectives(MFAAMBHBBJO: false);
		yield return CommonReferences.wait2;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T138/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		ResetMai();
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T138/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		CommonReferences.GGFJGHHHEJC.OnActionDone(1, ActionDone.FinishMaiTutorial);
		PlayerPrefs.SetInt("tutorialCompleted", 1);
		PlayerPrefs.Save();
		Utils.disableHalloweenEvent = false;
		Utils.disableChristmasEvent = false;
		LHKIJABBBPM();
		yield return CommonReferences.wait2;
		ChristmasEvent.instance.OnLoadingBarFinished();
	}

	private IEnumerator LGODBMNLILN()
	{
		if ((Object)(object)MaiNPC.GGFJGHHHEJC != (Object)null)
		{
			MaiNPC.GGFJGHHHEJC.SetTrigger("Transform");
		}
		while (LJNJGMLHCIC() || FMMJDDBDPCP())
		{
			yield return null;
		}
		NewTutorialManager.instance.ShowObjectives(MFAAMBHBBJO: false);
		yield return CommonReferences.wait2;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T138/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		ResetMai();
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T138/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		CommonReferences.GGFJGHHHEJC.OnActionDone(1, ActionDone.FinishMaiTutorial);
		PlayerPrefs.SetInt("tutorialCompleted", 1);
		PlayerPrefs.Save();
		Utils.disableHalloweenEvent = false;
		Utils.disableChristmasEvent = false;
		LHKIJABBBPM();
		yield return CommonReferences.wait2;
		ChristmasEvent.instance.OnLoadingBarFinished();
	}

	public override int GetID()
	{
		return 138;
	}

	private IEnumerator FPIHNICAJHI()
	{
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		RecipesManager instance = RecipesManager.GGFJGHHHEJC;
		instance.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Combine(instance.OnAnyRecipeUnlocked, new Action<Recipe>(JDJPBCFPIDN));
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
	}

	private IEnumerator KGIJEMPBBED()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private void NJPEHAJHLAJ(Recipe JNLKEMLDFIM)
	{
		NewTutorialManager.instance.recipePurchased = true;
		NewTutorialManager.instance.FOIOHOGACAL(0);
		RecipesManager recipesManager = RecipesManager.MPFJOKOJIOO();
		recipesManager.OnAnyRecipeUnlocked = (Action<Recipe>)Delegate.Remove(recipesManager.OnAnyRecipeUnlocked, new Action<Recipe>(OKFLHCEBGJA));
		((MonoBehaviour)this).StartCoroutine(DABNLFBDKGN());
	}

	private IEnumerator MPJMCMIMHFC()
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
}
