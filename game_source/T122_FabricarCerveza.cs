using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class T122_FabricarCerveza : TutorialPhaseBase
{
	[CompilerGenerated]
	private sealed class JLIDEPIJIEE : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int playerNum;

		public string dialogue;

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
		public JLIDEPIJIEE(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				UISelectionManager.GetPlayer(playerNum).Deselect();
				MaiNPC.GGFJGHHHEJC.StartTutorialDialogue(dialogue, playerNum, DHELBHAICMM: false, CGKNJONAKGD: false);
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
	private sealed class BGBGBBECCHB : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T122_FabricarCerveza _003C_003E4__this;

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
			T122_FabricarCerveza t122_FabricarCerveza = _003C_003E4__this;
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
				MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T122/Dialogue3", t122_FabricarCerveza.triggerPlayerNum);
				goto IL_0078;
			case 2:
				_003C_003E1__state = -1;
				goto IL_0078;
			case 3:
				{
					_003C_003E1__state = -1;
					t122_FabricarCerveza.LHKIJABBBPM();
					return false;
				}
				IL_0078:
				if (t122_FabricarCerveza.AAOPIEDAKKD(3))
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
	private sealed class DBHBDMOHMPM : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T122_FabricarCerveza _003C_003E4__this;

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
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			T122_FabricarCerveza t122_FabricarCerveza = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
				((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(11.83333f, 916.5f, 0f);
				_003C_003E2__current = CommonReferences.wait02;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
				MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
				goto IL_00c2;
			case 2:
				_003C_003E1__state = -1;
				goto IL_00c2;
			case 3:
				_003C_003E1__state = -1;
				goto IL_0105;
			case 4:
				_003C_003E1__state = -1;
				NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 5;
				return true;
			case 5:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
				MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T122/Dialogue1", t122_FabricarCerveza.triggerPlayerNum);
				goto IL_018f;
			case 6:
				_003C_003E1__state = -1;
				goto IL_018f;
			case 7:
			{
				_003C_003E1__state = -1;
				NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
				NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
				NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(675)).transform.position), Vector2.up * 0.7f, ref t122_FabricarCerveza.JELIKOFDONK);
				RecipesManager.UnlockRecipe(510, IBHGAMNNOHI: true);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCrafterOpened = (Action<int, Crafter>)Delegate.Combine(instance.OnAnyCrafterOpened, new Action<int, Crafter>(t122_FabricarCerveza.HGIBCKCGFKO));
				break;
			}
			case 8:
				{
					_003C_003E1__state = -1;
					break;
				}
				IL_018f:
				if (t122_FabricarCerveza.AAOPIEDAKKD(1))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 6;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 7;
				return true;
				IL_0105:
				if (!t122_FabricarCerveza.CLJJAIEMOLN())
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 3;
					return true;
				}
				_003C_003E2__current = ((MonoBehaviour)t122_FabricarCerveza).StartCoroutine(t122_FabricarCerveza.CDICFNAMCEE());
				_003C_003E1__state = 4;
				return true;
				IL_00c2:
				if (WorldTime.EDIPJBOOEHD > (float)(3 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.EDIPJBOOEHD < (float)(6 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 2;
					return true;
				}
				goto IL_0105;
			}
			if (t122_FabricarCerveza.AAOPIEDAKKD(2))
			{
				_003C_003E2__current = null;
				_003C_003E1__state = 8;
				return true;
			}
			CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
			instance2.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Combine(instance2.OnRecipeToCraftAdded, new Action<int, Recipe>(t122_FabricarCerveza.EECHIAJHKLD));
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

	private IEnumerator FMOBJFCJFGH()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(11.83333f, 916.5f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (WorldTime.EDIPJBOOEHD > (float)(3 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.EDIPJBOOEHD < (float)(6 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR))
		{
			yield return null;
		}
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait05;
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T122/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(675)).transform.position), Vector2.up * 0.7f, ref JELIKOFDONK);
		RecipesManager.UnlockRecipe(510, IBHGAMNNOHI: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCrafterOpened = (Action<int, Crafter>)Delegate.Combine(instance.OnAnyCrafterOpened, new Action<int, Crafter>(HGIBCKCGFKO));
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Combine(instance2.OnRecipeToCraftAdded, new Action<int, Recipe>(EECHIAJHKLD));
	}

	private IEnumerator FLECFIDDCJE()
	{
		yield return CommonReferences.wait2;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T122/Dialogue3", triggerPlayerNum);
		while (AAOPIEDAKKD(3))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private void ELKJACJPOID(int JIIGOACEIKL, Crafter LDLINOBIKPL)
	{
		if (LDLINOBIKPL.recipeList.ID == -195)
		{
			Utils.OFHPCBLHJBL(1137f, 1468f);
			((MonoBehaviour)this).StartCoroutine(FCJFECNDJBN(JIIGOACEIKL, " %"));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyCrafterOpened = (Action<int, Crafter>)Delegate.Remove(instance.OnAnyCrafterOpened, new Action<int, Crafter>(ELKJACJPOID));
		}
	}

	private IEnumerator BAGKLMIFNIH()
	{
		return new BGBGBBECCHB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void NBECCBKOJCL(int JIIGOACEIKL, Crafter LDLINOBIKPL)
	{
		if (LDLINOBIKPL.recipeList.ID == -46)
		{
			Utils.OFHPCBLHJBL(427f, 1575f);
			((MonoBehaviour)this).StartCoroutine(NEPPDGMOLAN(JIIGOACEIKL, "NotValid"));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyCrafterOpened = (Action<int, Crafter>)Delegate.Remove(instance.OnAnyCrafterOpened, new Action<int, Crafter>(FFMKKOMBPKC));
		}
	}

	private void MDBFAKCKKJL(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.JGHNDJBCFAJ(DAINLFIMLIH: false) == 53)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(KHGBOEFFFBK));
			NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			((MonoBehaviour)this).StartCoroutine(HGKFAONPGGB());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private void EECHIAJHKLD(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.JDJGFAACPFC() == 12)
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

	private void FHFBKAAKHDF(int JIIGOACEIKL, Crafter LDLINOBIKPL)
	{
		if (LDLINOBIKPL.recipeList.ID == -104)
		{
			Utils.OFHPCBLHJBL(1873f, 498f);
			((MonoBehaviour)this).StartCoroutine(JJNCCBKOBOD(JIIGOACEIKL, "Cheer"));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyCrafterOpened = (Action<int, Crafter>)Delegate.Remove(instance.OnAnyCrafterOpened, new Action<int, Crafter>(NBECCBKOJCL));
		}
	}

	private void ADKEFLLCGEA(int JIIGOACEIKL, Crafter LDLINOBIKPL)
	{
		if (LDLINOBIKPL.recipeList.ID == -150)
		{
			Utils.OFHPCBLHJBL(159f, 52f);
			((MonoBehaviour)this).StartCoroutine(NEPPDGMOLAN(JIIGOACEIKL, "ReceiveReduceDirtiness"));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyCrafterOpened = (Action<int, Crafter>)Delegate.Remove(instance.OnAnyCrafterOpened, new Action<int, Crafter>(EALNNIJMJIF));
		}
	}

	private void KCOPEOHANAP(int JIIGOACEIKL, Crafter LDLINOBIKPL)
	{
		if (LDLINOBIKPL.recipeList.ID == 109)
		{
			Utils.OFHPCBLHJBL(587f, 1234f);
			((MonoBehaviour)this).StartCoroutine(KEFJKJGLFBL(JIIGOACEIKL, "Room occupied"));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyCrafterOpened = (Action<int, Crafter>)Delegate.Remove(instance.OnAnyCrafterOpened, new Action<int, Crafter>(EIKBINFCAJJ));
		}
	}

	private void KJCLAOCNEHM(int JIIGOACEIKL, Crafter LDLINOBIKPL)
	{
		if (LDLINOBIKPL.recipeList.ID == -154)
		{
			Utils.OFHPCBLHJBL(1277f, 1853f);
			((MonoBehaviour)this).StartCoroutine(ANKHHALGKDG(JIIGOACEIKL, "Dialogue System/Conversation/Gass_Quest/Entry/37/Dialogue Text"));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyCrafterOpened = (Action<int, Crafter>)Delegate.Remove(instance.OnAnyCrafterOpened, new Action<int, Crafter>(OJOPMAOJMAP));
		}
	}

	private IEnumerator OCCLCKFAILK()
	{
		yield return CommonReferences.wait2;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T122/Dialogue3", triggerPlayerNum);
		while (AAOPIEDAKKD(3))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator JGEOKFOMALG(int JIIGOACEIKL, string ACMJBEGLONB)
	{
		yield return null;
		UISelectionManager.GetPlayer(JIIGOACEIKL).Deselect();
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue(ACMJBEGLONB, JIIGOACEIKL, DHELBHAICMM: false, CGKNJONAKGD: false);
	}

	private IEnumerator AFHGHLOCAPA()
	{
		yield return CommonReferences.wait2;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T122/Dialogue3", triggerPlayerNum);
		while (AAOPIEDAKKD(3))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator HHLKPNANHKK()
	{
		yield return CommonReferences.wait2;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T122/Dialogue3", triggerPlayerNum);
		while (AAOPIEDAKKD(3))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator OFOLEPNOONG()
	{
		yield return CommonReferences.wait2;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T122/Dialogue3", triggerPlayerNum);
		while (AAOPIEDAKKD(3))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private void KHGBOEFFFBK(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.ODENMDOJPLC() == 108)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(commonReferences.OnRecipeToCraftAdded, new Action<int, Recipe>(NOKLMNJDCDE));
			NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			((MonoBehaviour)this).StartCoroutine(FBHLJKDLPOB());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private IEnumerator HDNAFBGHOJD()
	{
		return new BGBGBBECCHB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator CKNJJKJDBGA(int JIIGOACEIKL, string ACMJBEGLONB)
	{
		yield return null;
		UISelectionManager.GetPlayer(JIIGOACEIKL).Deselect();
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue(ACMJBEGLONB, JIIGOACEIKL, DHELBHAICMM: false, CGKNJONAKGD: false);
	}

	private void LGEKGDILAFP(int JIIGOACEIKL, Crafter LDLINOBIKPL)
	{
		if (LDLINOBIKPL.recipeList.ID == 99)
		{
			Utils.OFHPCBLHJBL(1001f, 1471f);
			((MonoBehaviour)this).StartCoroutine(DNEPDMDONLM(JIIGOACEIKL, "Items/item_description_1083"));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyCrafterOpened = (Action<int, Crafter>)Delegate.Remove(instance.OnAnyCrafterOpened, new Action<int, Crafter>(NKIKJJBJKJI));
		}
	}

	private void KHOODGCADGK(int JIIGOACEIKL, Crafter LDLINOBIKPL)
	{
		if (LDLINOBIKPL.recipeList.ID == 125)
		{
			Utils.OFHPCBLHJBL(598f, 579f);
			((MonoBehaviour)this).StartCoroutine(JIJAOMIMPGN(JIIGOACEIKL, "Dialogue System/Conversation/Crowly_Introduce/Entry/16/Dialogue Text"));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyCrafterOpened = (Action<int, Crafter>)Delegate.Remove(instance.OnAnyCrafterOpened, new Action<int, Crafter>(OMFBJGCJLAL));
		}
	}

	private IEnumerator CMMJDBDKAEO()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(11.83333f, 916.5f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (WorldTime.EDIPJBOOEHD > (float)(3 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.EDIPJBOOEHD < (float)(6 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR))
		{
			yield return null;
		}
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait05;
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T122/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(675)).transform.position), Vector2.up * 0.7f, ref JELIKOFDONK);
		RecipesManager.UnlockRecipe(510, IBHGAMNNOHI: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCrafterOpened = (Action<int, Crafter>)Delegate.Combine(instance.OnAnyCrafterOpened, new Action<int, Crafter>(HGIBCKCGFKO));
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Combine(instance2.OnRecipeToCraftAdded, new Action<int, Recipe>(EECHIAJHKLD));
	}

	private IEnumerator GFMGFHGPGCM()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(11.83333f, 916.5f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (WorldTime.EDIPJBOOEHD > (float)(3 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.EDIPJBOOEHD < (float)(6 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR))
		{
			yield return null;
		}
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait05;
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T122/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(675)).transform.position), Vector2.up * 0.7f, ref JELIKOFDONK);
		RecipesManager.UnlockRecipe(510, IBHGAMNNOHI: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCrafterOpened = (Action<int, Crafter>)Delegate.Combine(instance.OnAnyCrafterOpened, new Action<int, Crafter>(HGIBCKCGFKO));
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Combine(instance2.OnRecipeToCraftAdded, new Action<int, Recipe>(EECHIAJHKLD));
	}

	private void GNCDKBJDOOA(int JIIGOACEIKL, Crafter LDLINOBIKPL)
	{
		if (LDLINOBIKPL.recipeList.ID == -161)
		{
			Utils.OFHPCBLHJBL(1290f, 138f);
			((MonoBehaviour)this).StartCoroutine(MOBJFAIMJOM(JIIGOACEIKL, "\\[HouseKeeperGender=[^\\]]*\\]"));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyCrafterOpened = (Action<int, Crafter>)Delegate.Remove(instance.OnAnyCrafterOpened, new Action<int, Crafter>(PIINIODLJJM));
		}
	}

	private void NKIKJJBJKJI(int JIIGOACEIKL, Crafter LDLINOBIKPL)
	{
		if (LDLINOBIKPL.recipeList.ID == 56)
		{
			Utils.OFHPCBLHJBL(167f, 1235f);
			((MonoBehaviour)this).StartCoroutine(IFDALMFLMDM(JIIGOACEIKL, ":</color> "));
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyCrafterOpened = (Action<int, Crafter>)Delegate.Remove(commonReferences.OnAnyCrafterOpened, new Action<int, Crafter>(EALNNIJMJIF));
		}
	}

	private IEnumerator MFFGIOALMIC()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(11.83333f, 916.5f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (WorldTime.EDIPJBOOEHD > (float)(3 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.EDIPJBOOEHD < (float)(6 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR))
		{
			yield return null;
		}
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait05;
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T122/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(675)).transform.position), Vector2.up * 0.7f, ref JELIKOFDONK);
		RecipesManager.UnlockRecipe(510, IBHGAMNNOHI: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCrafterOpened = (Action<int, Crafter>)Delegate.Combine(instance.OnAnyCrafterOpened, new Action<int, Crafter>(HGIBCKCGFKO));
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Combine(instance2.OnRecipeToCraftAdded, new Action<int, Recipe>(EECHIAJHKLD));
	}

	private IEnumerator CFCMKAPFPCE()
	{
		yield return CommonReferences.wait2;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T122/Dialogue3", triggerPlayerNum);
		while (AAOPIEDAKKD(3))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator FGHCBJDNPEF(int JIIGOACEIKL, string ACMJBEGLONB)
	{
		yield return null;
		UISelectionManager.GetPlayer(JIIGOACEIKL).Deselect();
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue(ACMJBEGLONB, JIIGOACEIKL, DHELBHAICMM: false, CGKNJONAKGD: false);
	}

	private IEnumerator MLAOLHNEEJC()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator EHLJJPKMACO(int JIIGOACEIKL, string ACMJBEGLONB)
	{
		return new JLIDEPIJIEE(1)
		{
			playerNum = JIIGOACEIKL,
			dialogue = ACMJBEGLONB
		};
	}

	private void NKDCGAIFEAN(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.ODENMDOJPLC(DAINLFIMLIH: false) == 23)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(commonReferences.OnRecipeToCraftAdded, new Action<int, Recipe>(EECHIAJHKLD));
			NewTutorialManager.instance.FOIOHOGACAL(1);
			((MonoBehaviour)this).StartCoroutine(CFCMKAPFPCE());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private IEnumerator HGKFAONPGGB()
	{
		return new BGBGBBECCHB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator CKMLGHPIEEK(int JIIGOACEIKL, string ACMJBEGLONB)
	{
		return new JLIDEPIJIEE(1)
		{
			playerNum = JIIGOACEIKL,
			dialogue = ACMJBEGLONB
		};
	}

	private IEnumerator LFFCFNNODFJ()
	{
		return new BGBGBBECCHB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator OPCHFFMKPCN()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(11.83333f, 916.5f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (WorldTime.EDIPJBOOEHD > (float)(3 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.EDIPJBOOEHD < (float)(6 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR))
		{
			yield return null;
		}
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait05;
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T122/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(675)).transform.position), Vector2.up * 0.7f, ref JELIKOFDONK);
		RecipesManager.UnlockRecipe(510, IBHGAMNNOHI: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCrafterOpened = (Action<int, Crafter>)Delegate.Combine(instance.OnAnyCrafterOpened, new Action<int, Crafter>(HGIBCKCGFKO));
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Combine(instance2.OnRecipeToCraftAdded, new Action<int, Recipe>(EECHIAJHKLD));
	}

	private IEnumerator BJKKIJIKPMC()
	{
		return new BGBGBBECCHB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator BDBMGIKGDNG()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(11.83333f, 916.5f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (WorldTime.EDIPJBOOEHD > (float)(3 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.EDIPJBOOEHD < (float)(6 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR))
		{
			yield return null;
		}
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait05;
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T122/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(675)).transform.position), Vector2.up * 0.7f, ref JELIKOFDONK);
		RecipesManager.UnlockRecipe(510, IBHGAMNNOHI: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCrafterOpened = (Action<int, Crafter>)Delegate.Combine(instance.OnAnyCrafterOpened, new Action<int, Crafter>(HGIBCKCGFKO));
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Combine(instance2.OnRecipeToCraftAdded, new Action<int, Recipe>(EECHIAJHKLD));
	}

	private IEnumerator BEGCHMCDPOK(int JIIGOACEIKL, string ACMJBEGLONB)
	{
		yield return null;
		UISelectionManager.GetPlayer(JIIGOACEIKL).Deselect();
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue(ACMJBEGLONB, JIIGOACEIKL, DHELBHAICMM: false, CGKNJONAKGD: false);
	}

	private IEnumerator BBIMBLPLMJP(int JIIGOACEIKL, string ACMJBEGLONB)
	{
		yield return null;
		UISelectionManager.GetPlayer(JIIGOACEIKL).Deselect();
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue(ACMJBEGLONB, JIIGOACEIKL, DHELBHAICMM: false, CGKNJONAKGD: false);
	}

	private void ONGOOILBOPM(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.CIGFGKKCPCK(DAINLFIMLIH: false) == 41)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(FEBIPDBJIAC));
			NewTutorialManager.instance.ObjectiveCompleted(0);
			((MonoBehaviour)this).StartCoroutine(BAGKLMIFNIH());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private void CLIDPEJDLPM(int JIIGOACEIKL, Crafter LDLINOBIKPL)
	{
		if (LDLINOBIKPL.recipeList.ID == 108)
		{
			Utils.OFHPCBLHJBL(1442f, 652f);
			((MonoBehaviour)this).StartCoroutine(ODPACDKBJHJ(JIIGOACEIKL, "Player2"));
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyCrafterOpened = (Action<int, Crafter>)Delegate.Remove(commonReferences.OnAnyCrafterOpened, new Action<int, Crafter>(OMFBJGCJLAL));
		}
	}

	public override int GetID()
	{
		return 122;
	}

	private IEnumerator LAMBONHALKD()
	{
		return new BGBGBBECCHB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator IGFOJFFHNJF()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AENDGJJDOLL(int JIIGOACEIKL, string ACMJBEGLONB)
	{
		yield return null;
		UISelectionManager.GetPlayer(JIIGOACEIKL).Deselect();
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue(ACMJBEGLONB, JIIGOACEIKL, DHELBHAICMM: false, CGKNJONAKGD: false);
	}

	private void ODEMCMHBKDF(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.JPNFKDMFKMC() == 74)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(commonReferences.OnRecipeToCraftAdded, new Action<int, Recipe>(PNOMEDAMOIA));
			NewTutorialManager.instance.ObjectiveCompleted(0);
			((MonoBehaviour)this).StartCoroutine(HHLKPNANHKK());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private IEnumerator ODPACDKBJHJ(int JIIGOACEIKL, string ACMJBEGLONB)
	{
		return new JLIDEPIJIEE(1)
		{
			playerNum = JIIGOACEIKL,
			dialogue = ACMJBEGLONB
		};
	}

	private IEnumerator DGGJFGHINNL(int JIIGOACEIKL, string ACMJBEGLONB)
	{
		return new JLIDEPIJIEE(1)
		{
			playerNum = JIIGOACEIKL,
			dialogue = ACMJBEGLONB
		};
	}

	private void BDLINIOJCEM(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.JPNFKDMFKMC(DAINLFIMLIH: false) == 116)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(commonReferences.OnRecipeToCraftAdded, new Action<int, Recipe>(PEKOCNBJLJG));
			NewTutorialManager.instance.ObjectiveCompleted(1);
			((MonoBehaviour)this).StartCoroutine(LPCPNKEMCNM());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private void GGLOBMHAOFL(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.ODENMDOJPLC(DAINLFIMLIH: false) == 75)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(NKDCGAIFEAN));
			NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			((MonoBehaviour)this).StartCoroutine(AFHGHLOCAPA());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private IEnumerator GGACDGHOJEF()
	{
		yield return CommonReferences.wait2;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T122/Dialogue3", triggerPlayerNum);
		while (AAOPIEDAKKD(3))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private void PJHCKCFHDFD(int JIIGOACEIKL, Crafter LDLINOBIKPL)
	{
		if (LDLINOBIKPL.recipeList.ID == 158)
		{
			Utils.OFHPCBLHJBL(1299f, 1999f);
			((MonoBehaviour)this).StartCoroutine(CKMLGHPIEEK(JIIGOACEIKL, "Service Debug: True"));
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyCrafterOpened = (Action<int, Crafter>)Delegate.Remove(commonReferences.OnAnyCrafterOpened, new Action<int, Crafter>(ADKEFLLCGEA));
		}
	}

	private IEnumerator ANKHHALGKDG(int JIIGOACEIKL, string ACMJBEGLONB)
	{
		return new JLIDEPIJIEE(1)
		{
			playerNum = JIIGOACEIKL,
			dialogue = ACMJBEGLONB
		};
	}

	private void FFMKKOMBPKC(int JIIGOACEIKL, Crafter LDLINOBIKPL)
	{
		if (LDLINOBIKPL.recipeList.ID == 53)
		{
			Utils.OFHPCBLHJBL(187f, 996f);
			((MonoBehaviour)this).StartCoroutine(AENDGJJDOLL(JIIGOACEIKL, "Items/item_description_675"));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyCrafterOpened = (Action<int, Crafter>)Delegate.Remove(instance.OnAnyCrafterOpened, new Action<int, Crafter>(EIKBINFCAJJ));
		}
	}

	private IEnumerator ADFMBGJOMKK()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(11.83333f, 916.5f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (WorldTime.EDIPJBOOEHD > (float)(3 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.EDIPJBOOEHD < (float)(6 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR))
		{
			yield return null;
		}
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait05;
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T122/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(675)).transform.position), Vector2.up * 0.7f, ref JELIKOFDONK);
		RecipesManager.UnlockRecipe(510, IBHGAMNNOHI: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCrafterOpened = (Action<int, Crafter>)Delegate.Combine(instance.OnAnyCrafterOpened, new Action<int, Crafter>(HGIBCKCGFKO));
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Combine(instance2.OnRecipeToCraftAdded, new Action<int, Recipe>(EECHIAJHKLD));
	}

	private IEnumerator ENFDAOPBCJM(int JIIGOACEIKL, string ACMJBEGLONB)
	{
		return new JLIDEPIJIEE(1)
		{
			playerNum = JIIGOACEIKL,
			dialogue = ACMJBEGLONB
		};
	}

	private IEnumerator IHGGOFFGMBD()
	{
		yield return CommonReferences.wait2;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T122/Dialogue3", triggerPlayerNum);
		while (AAOPIEDAKKD(3))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private void JPFELEHCBEN(int JIIGOACEIKL, Crafter LDLINOBIKPL)
	{
		if (LDLINOBIKPL.recipeList.ID == -181)
		{
			Utils.OFHPCBLHJBL(1383f, 89f);
			((MonoBehaviour)this).StartCoroutine(KEFJKJGLFBL(JIIGOACEIKL, "Player/Bark/RentRoom/NoRooms"));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyCrafterOpened = (Action<int, Crafter>)Delegate.Remove(instance.OnAnyCrafterOpened, new Action<int, Crafter>(KHOODGCADGK));
		}
	}

	private void HHPHFFNLGDI(int JIIGOACEIKL, Crafter LDLINOBIKPL)
	{
		if (LDLINOBIKPL.recipeList.ID == -191)
		{
			Utils.OFHPCBLHJBL(229f, 594f);
			((MonoBehaviour)this).StartCoroutine(ANKHHALGKDG(JIIGOACEIKL, ">"));
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyCrafterOpened = (Action<int, Crafter>)Delegate.Remove(commonReferences.OnAnyCrafterOpened, new Action<int, Crafter>(OMFBJGCJLAL));
		}
	}

	private IEnumerator JNOOAENGMHL()
	{
		yield return CommonReferences.wait2;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T122/Dialogue3", triggerPlayerNum);
		while (AAOPIEDAKKD(3))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator OHLAKCMJEDJ(int JIIGOACEIKL, string ACMJBEGLONB)
	{
		return new JLIDEPIJIEE(1)
		{
			playerNum = JIIGOACEIKL,
			dialogue = ACMJBEGLONB
		};
	}

	private IEnumerator PBEKBJIJFDK()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(11.83333f, 916.5f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (WorldTime.EDIPJBOOEHD > (float)(3 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.EDIPJBOOEHD < (float)(6 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR))
		{
			yield return null;
		}
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait05;
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T122/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(675)).transform.position), Vector2.up * 0.7f, ref JELIKOFDONK);
		RecipesManager.UnlockRecipe(510, IBHGAMNNOHI: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCrafterOpened = (Action<int, Crafter>)Delegate.Combine(instance.OnAnyCrafterOpened, new Action<int, Crafter>(HGIBCKCGFKO));
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Combine(instance2.OnRecipeToCraftAdded, new Action<int, Recipe>(EECHIAJHKLD));
	}

	private IEnumerator INNCNOGFIMG(int JIIGOACEIKL, string ACMJBEGLONB)
	{
		yield return null;
		UISelectionManager.GetPlayer(JIIGOACEIKL).Deselect();
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue(ACMJBEGLONB, JIIGOACEIKL, DHELBHAICMM: false, CGKNJONAKGD: false);
	}

	private IEnumerator FCJFECNDJBN(int JIIGOACEIKL, string ACMJBEGLONB)
	{
		yield return null;
		UISelectionManager.GetPlayer(JIIGOACEIKL).Deselect();
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue(ACMJBEGLONB, JIIGOACEIKL, DHELBHAICMM: false, CGKNJONAKGD: false);
	}

	private IEnumerator JJNCCBKOBOD(int JIIGOACEIKL, string ACMJBEGLONB)
	{
		return new JLIDEPIJIEE(1)
		{
			playerNum = JIIGOACEIKL,
			dialogue = ACMJBEGLONB
		};
	}

	private IEnumerator FEEJKJJEEPO()
	{
		yield return CommonReferences.wait2;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T122/Dialogue3", triggerPlayerNum);
		while (AAOPIEDAKKD(3))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private void PIINIODLJJM(int JIIGOACEIKL, Crafter LDLINOBIKPL)
	{
		if (LDLINOBIKPL.recipeList.ID == 161)
		{
			Utils.OFHPCBLHJBL(1846f, 393f);
			((MonoBehaviour)this).StartCoroutine(IFDALMFLMDM(JIIGOACEIKL, ""));
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyCrafterOpened = (Action<int, Crafter>)Delegate.Remove(commonReferences.OnAnyCrafterOpened, new Action<int, Crafter>(FDNEAEKHCLM));
		}
	}

	private IEnumerator MOBJFAIMJOM(int JIIGOACEIKL, string ACMJBEGLONB)
	{
		yield return null;
		UISelectionManager.GetPlayer(JIIGOACEIKL).Deselect();
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue(ACMJBEGLONB, JIIGOACEIKL, DHELBHAICMM: false, CGKNJONAKGD: false);
	}

	private void EIKBINFCAJJ(int JIIGOACEIKL, Crafter LDLINOBIKPL)
	{
		if (LDLINOBIKPL.recipeList.ID == 167)
		{
			Utils.OFHPCBLHJBL(1196f, 1034f);
			((MonoBehaviour)this).StartCoroutine(ANKHHALGKDG(JIIGOACEIKL, "Open"));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyCrafterOpened = (Action<int, Crafter>)Delegate.Remove(instance.OnAnyCrafterOpened, new Action<int, Crafter>(NBECCBKOJCL));
		}
	}

	private IEnumerator GACJBLGDMFG()
	{
		return new BGBGBBECCHB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator FENELGHHOID(int JIIGOACEIKL, string ACMJBEGLONB)
	{
		return new JLIDEPIJIEE(1)
		{
			playerNum = JIIGOACEIKL,
			dialogue = ACMJBEGLONB
		};
	}

	private IEnumerator LHDDHIJIFCN()
	{
		yield return CommonReferences.wait2;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T122/Dialogue3", triggerPlayerNum);
		while (AAOPIEDAKKD(3))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private void DHMJMFOOEOF(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.ODENMDOJPLC(DAINLFIMLIH: false) == -88)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(commonReferences.OnRecipeToCraftAdded, new Action<int, Recipe>(LALCOJOBCCH));
			NewTutorialManager.instance.ObjectiveCompleted(0);
			((MonoBehaviour)this).StartCoroutine(OFOLEPNOONG());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private void PEKOCNBJLJG(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.IMCJPECAAPC() == -86)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(AEDJDBNEAKK));
			NewTutorialManager.instance.FOIOHOGACAL(1);
			((MonoBehaviour)this).StartCoroutine(HHLKPNANHKK());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private void OMFBJGCJLAL(int JIIGOACEIKL, Crafter LDLINOBIKPL)
	{
		if (LDLINOBIKPL.recipeList.ID == 65)
		{
			Utils.OFHPCBLHJBL(1604f, 1298f);
			((MonoBehaviour)this).StartCoroutine(GKGLHNPNMGN(JIIGOACEIKL, "questNameBoiling"));
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyCrafterOpened = (Action<int, Crafter>)Delegate.Remove(commonReferences.OnAnyCrafterOpened, new Action<int, Crafter>(HGIBCKCGFKO));
		}
	}

	private void LAFMNMBGLKM(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.JGHNDJBCFAJ(DAINLFIMLIH: false) == 39)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(commonReferences.OnRecipeToCraftAdded, new Action<int, Recipe>(GEOAJAJJAPI));
			NewTutorialManager.instance.FOIOHOGACAL(1);
			((MonoBehaviour)this).StartCoroutine(GACJBLGDMFG());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private void OJOPMAOJMAP(int JIIGOACEIKL, Crafter LDLINOBIKPL)
	{
		if (LDLINOBIKPL.recipeList.ID == 102)
		{
			Utils.OFHPCBLHJBL(216f, 1695f);
			((MonoBehaviour)this).StartCoroutine(FCJFECNDJBN(JIIGOACEIKL, "ReceiveOfferingItemCleared"));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyCrafterOpened = (Action<int, Crafter>)Delegate.Remove(instance.OnAnyCrafterOpened, new Action<int, Crafter>(KCOPEOHANAP));
		}
	}

	private IEnumerator KBHDCKMNMHF(int JIIGOACEIKL, string ACMJBEGLONB)
	{
		yield return null;
		UISelectionManager.GetPlayer(JIIGOACEIKL).Deselect();
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue(ACMJBEGLONB, JIIGOACEIKL, DHELBHAICMM: false, CGKNJONAKGD: false);
	}

	private IEnumerator KEFJKJGLFBL(int JIIGOACEIKL, string ACMJBEGLONB)
	{
		yield return null;
		UISelectionManager.GetPlayer(JIIGOACEIKL).Deselect();
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue(ACMJBEGLONB, JIIGOACEIKL, DHELBHAICMM: false, CGKNJONAKGD: false);
	}

	private IEnumerator LNJLAOCCEAP(int JIIGOACEIKL, string ACMJBEGLONB)
	{
		return new JLIDEPIJIEE(1)
		{
			playerNum = JIIGOACEIKL,
			dialogue = ACMJBEGLONB
		};
	}

	private IEnumerator NHGNIPINAOF(int JIIGOACEIKL, string ACMJBEGLONB)
	{
		yield return null;
		UISelectionManager.GetPlayer(JIIGOACEIKL).Deselect();
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue(ACMJBEGLONB, JIIGOACEIKL, DHELBHAICMM: false, CGKNJONAKGD: false);
	}

	private void HMPIIOKPGNE(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.JGHNDJBCFAJ() == -113)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(commonReferences.OnRecipeToCraftAdded, new Action<int, Recipe>(CHIDJLJJEKF));
			NewTutorialManager.instance.ObjectiveCompleted(0);
			((MonoBehaviour)this).StartCoroutine(AFHGHLOCAPA());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private void EALNNIJMJIF(int JIIGOACEIKL, Crafter LDLINOBIKPL)
	{
		if (LDLINOBIKPL.recipeList.ID == -57)
		{
			Utils.OFHPCBLHJBL(1200f, 608f);
			((MonoBehaviour)this).StartCoroutine(FGHCBJDNPEF(JIIGOACEIKL, "Items/item_name_605"));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyCrafterOpened = (Action<int, Crafter>)Delegate.Remove(instance.OnAnyCrafterOpened, new Action<int, Crafter>(PIINIODLJJM));
		}
	}

	private IEnumerator FAFNDKCPGLK(int JIIGOACEIKL, string ACMJBEGLONB)
	{
		return new JLIDEPIJIEE(1)
		{
			playerNum = JIIGOACEIKL,
			dialogue = ACMJBEGLONB
		};
	}

	private IEnumerator KBCMEHCIEBA()
	{
		return new BGBGBBECCHB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NEPPDGMOLAN(int JIIGOACEIKL, string ACMJBEGLONB)
	{
		yield return null;
		UISelectionManager.GetPlayer(JIIGOACEIKL).Deselect();
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue(ACMJBEGLONB, JIIGOACEIKL, DHELBHAICMM: false, CGKNJONAKGD: false);
	}

	private IEnumerator KBAFIHCCEJG()
	{
		return new BGBGBBECCHB(1)
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

	private IEnumerator AJJPECIKMJN()
	{
		yield return CommonReferences.wait2;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T122/Dialogue3", triggerPlayerNum);
		while (AAOPIEDAKKD(3))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private void AEDJDBNEAKK(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.ODENMDOJPLC(DAINLFIMLIH: false) == 102)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(PFLKNKJFBMH));
			NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			((MonoBehaviour)this).StartCoroutine(NLJAMKLPLBJ());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private IEnumerator IFDALMFLMDM(int JIIGOACEIKL, string ACMJBEGLONB)
	{
		return new JLIDEPIJIEE(1)
		{
			playerNum = JIIGOACEIKL,
			dialogue = ACMJBEGLONB
		};
	}

	private void FDNEAEKHCLM(int JIIGOACEIKL, Crafter LDLINOBIKPL)
	{
		if (LDLINOBIKPL.recipeList.ID == -190)
		{
			Utils.OFHPCBLHJBL(1422f, 199f);
			((MonoBehaviour)this).StartCoroutine(IJIFLIFIMOG(JIIGOACEIKL, "Tutorial/T112/Dialogue2"));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyCrafterOpened = (Action<int, Crafter>)Delegate.Remove(instance.OnAnyCrafterOpened, new Action<int, Crafter>(CLIDPEJDLPM));
		}
	}

	private IEnumerator NKOJNIDHGBJ()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(11.83333f, 916.5f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (WorldTime.EDIPJBOOEHD > (float)(3 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.EDIPJBOOEHD < (float)(6 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR))
		{
			yield return null;
		}
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait05;
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T122/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(675)).transform.position), Vector2.up * 0.7f, ref JELIKOFDONK);
		RecipesManager.UnlockRecipe(510, IBHGAMNNOHI: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCrafterOpened = (Action<int, Crafter>)Delegate.Combine(instance.OnAnyCrafterOpened, new Action<int, Crafter>(HGIBCKCGFKO));
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Combine(instance2.OnRecipeToCraftAdded, new Action<int, Recipe>(EECHIAJHKLD));
	}

	private void FEBIPDBJIAC(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.JDJGFAACPFC(DAINLFIMLIH: false) == -69)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(commonReferences.OnRecipeToCraftAdded, new Action<int, Recipe>(NKDCGAIFEAN));
			NewTutorialManager.instance.ObjectiveCompleted(1);
			((MonoBehaviour)this).StartCoroutine(BJKKIJIKPMC());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private IEnumerator GDFFGECEIMN()
	{
		return new BGBGBBECCHB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void NBMKBBDBLJI(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.JDJGFAACPFC() == 88)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(AHGEPHIIGON));
			NewTutorialManager.instance.ObjectiveCompleted(1);
			((MonoBehaviour)this).StartCoroutine(AJJPECIKMJN());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private void PNOMEDAMOIA(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.JGHNDJBCFAJ() == -86)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(KHGBOEFFFBK));
			NewTutorialManager.instance.ObjectiveCompleted(1);
			((MonoBehaviour)this).StartCoroutine(FEEJKJJEEPO());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private IEnumerator DNEPDMDONLM(int JIIGOACEIKL, string ACMJBEGLONB)
	{
		return new JLIDEPIJIEE(1)
		{
			playerNum = JIIGOACEIKL,
			dialogue = ACMJBEGLONB
		};
	}

	private IEnumerator FBHLJKDLPOB()
	{
		yield return CommonReferences.wait2;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T122/Dialogue3", triggerPlayerNum);
		while (AAOPIEDAKKD(3))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	public override void SetUp()
	{
		base.SetUp();
		((MonoBehaviour)this).StartCoroutine(PBEKBJIJFDK());
	}

	private void NOKLMNJDCDE(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.IMCJPECAAPC(DAINLFIMLIH: false) == 45)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(NBMKBBDBLJI));
			NewTutorialManager.instance.FOIOHOGACAL(1);
			((MonoBehaviour)this).StartCoroutine(AJJPECIKMJN());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private IEnumerator EOCBHNPFJLL()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator GDCMANLMBDB()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JIJAOMIMPGN(int JIIGOACEIKL, string ACMJBEGLONB)
	{
		yield return null;
		UISelectionManager.GetPlayer(JIIGOACEIKL).Deselect();
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue(ACMJBEGLONB, JIIGOACEIKL, DHELBHAICMM: false, CGKNJONAKGD: false);
	}

	private void AHGEPHIIGON(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.JPNFKDMFKMC() == -42)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(commonReferences.OnRecipeToCraftAdded, new Action<int, Recipe>(FEBIPDBJIAC));
			NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			((MonoBehaviour)this).StartCoroutine(LFFCFNNODFJ());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private void OHFFBGMLDGB(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.IMCJPECAAPC() == -65)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(OHFFBGMLDGB));
			NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			((MonoBehaviour)this).StartCoroutine(GMOJIGLJCJP());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private void PIILJOKPHHP(int JIIGOACEIKL, Crafter LDLINOBIKPL)
	{
		if (LDLINOBIKPL.recipeList.ID == 24)
		{
			Utils.OFHPCBLHJBL(1926f, 1640f);
			((MonoBehaviour)this).StartCoroutine(INNCNOGFIMG(JIIGOACEIKL, "Final recipe fragments: "));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyCrafterOpened = (Action<int, Crafter>)Delegate.Remove(instance.OnAnyCrafterOpened, new Action<int, Crafter>(FDNEAEKHCLM));
		}
	}

	private IEnumerator PAONJEAFLDC()
	{
		return new BGBGBBECCHB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void JDDNCIDFMFE(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.JDJGFAACPFC() == 109)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(commonReferences.OnRecipeToCraftAdded, new Action<int, Recipe>(DCLILAIMLNG));
			NewTutorialManager.instance.FOIOHOGACAL(0);
			((MonoBehaviour)this).StartCoroutine(IHGGOFFGMBD());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private void PFLKNKJFBMH(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.JDJGFAACPFC() == -26)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(commonReferences.OnRecipeToCraftAdded, new Action<int, Recipe>(JDDNCIDFMFE));
			NewTutorialManager.instance.ObjectiveCompleted(1);
			((MonoBehaviour)this).StartCoroutine(NLJAMKLPLBJ());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private void COEACIMAAOE(int JIIGOACEIKL, Crafter LDLINOBIKPL)
	{
		if (LDLINOBIKPL.recipeList.ID == 61)
		{
			Utils.OFHPCBLHJBL(1523f, 1418f);
			((MonoBehaviour)this).StartCoroutine(FAFNDKCPGLK(JIIGOACEIKL, "Partida comprimida. Tiempo: "));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyCrafterOpened = (Action<int, Crafter>)Delegate.Remove(instance.OnAnyCrafterOpened, new Action<int, Crafter>(LGEKGDILAFP));
		}
	}

	private void PAELLEJMJAN(int JIIGOACEIKL, Crafter LDLINOBIKPL)
	{
		if (LDLINOBIKPL.recipeList.ID == -121)
		{
			Utils.OFHPCBLHJBL(1822f, 874f);
			((MonoBehaviour)this).StartCoroutine(FGHCBJDNPEF(JIIGOACEIKL, "Freeze"));
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyCrafterOpened = (Action<int, Crafter>)Delegate.Remove(commonReferences.OnAnyCrafterOpened, new Action<int, Crafter>(DHDGPIPAEEA));
		}
	}

	private IEnumerator LPCPNKEMCNM()
	{
		yield return CommonReferences.wait2;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T122/Dialogue3", triggerPlayerNum);
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
		return new BGBGBBECCHB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void DHDGPIPAEEA(int JIIGOACEIKL, Crafter LDLINOBIKPL)
	{
		if (LDLINOBIKPL.recipeList.ID == -70)
		{
			Utils.OFHPCBLHJBL(1199f, 161f);
			((MonoBehaviour)this).StartCoroutine(JJNCCBKOBOD(JIIGOACEIKL, "Game is already running"));
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyCrafterOpened = (Action<int, Crafter>)Delegate.Remove(commonReferences.OnAnyCrafterOpened, new Action<int, Crafter>(CLIDPEJDLPM));
		}
	}

	private IEnumerator KGIJEMPBBED()
	{
		return new BGBGBBECCHB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NLJAMKLPLBJ()
	{
		yield return CommonReferences.wait2;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T122/Dialogue3", triggerPlayerNum);
		while (AAOPIEDAKKD(3))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator PDJOKGEHFPE(int JIIGOACEIKL, string ACMJBEGLONB)
	{
		yield return null;
		UISelectionManager.GetPlayer(JIIGOACEIKL).Deselect();
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue(ACMJBEGLONB, JIIGOACEIKL, DHELBHAICMM: false, CGKNJONAKGD: false);
	}

	private void HGIBCKCGFKO(int JIIGOACEIKL, Crafter LDLINOBIKPL)
	{
		if (LDLINOBIKPL.recipeList.ID == 675)
		{
			Utils.OFHPCBLHJBL(1f, 1f);
			((MonoBehaviour)this).StartCoroutine(INNCNOGFIMG(JIIGOACEIKL, "Tutorial/T122/Dialogue2"));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyCrafterOpened = (Action<int, Crafter>)Delegate.Remove(instance.OnAnyCrafterOpened, new Action<int, Crafter>(HGIBCKCGFKO));
		}
	}

	private IEnumerator DIKOFPFKCOB()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LNNCIOJHJMK()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator IIMPCJICOOO()
	{
		return new BGBGBBECCHB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator GPEEMDDAMMN()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(11.83333f, 916.5f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (WorldTime.EDIPJBOOEHD > (float)(3 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.EDIPJBOOEHD < (float)(6 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR))
		{
			yield return null;
		}
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait05;
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T122/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(675)).transform.position), Vector2.up * 0.7f, ref JELIKOFDONK);
		RecipesManager.UnlockRecipe(510, IBHGAMNNOHI: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCrafterOpened = (Action<int, Crafter>)Delegate.Combine(instance.OnAnyCrafterOpened, new Action<int, Crafter>(HGIBCKCGFKO));
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Combine(instance2.OnRecipeToCraftAdded, new Action<int, Recipe>(EECHIAJHKLD));
	}

	private void GEOAJAJJAPI(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.JGHNDJBCFAJ(DAINLFIMLIH: false) == 62)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(commonReferences.OnRecipeToCraftAdded, new Action<int, Recipe>(AHGEPHIIGON));
			NewTutorialManager.instance.ObjectiveCompleted(1);
			((MonoBehaviour)this).StartCoroutine(AJJPECIKMJN());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private void LALCOJOBCCH(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.CIGFGKKCPCK(DAINLFIMLIH: false) == -29)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(commonReferences.OnRecipeToCraftAdded, new Action<int, Recipe>(LALCOJOBCCH));
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			((MonoBehaviour)this).StartCoroutine(KBAFIHCCEJG());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private IEnumerator BLHFOAMKOAH()
	{
		return new BGBGBBECCHB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator GMOJIGLJCJP()
	{
		yield return CommonReferences.wait2;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T122/Dialogue3", triggerPlayerNum);
		while (AAOPIEDAKKD(3))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private void CHIDJLJJEKF(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.IMCJPECAAPC(DAINLFIMLIH: false) == 118)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(commonReferences.OnRecipeToCraftAdded, new Action<int, Recipe>(KHGBOEFFFBK));
			NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			((MonoBehaviour)this).StartCoroutine(GACJBLGDMFG());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private IEnumerator GKGLHNPNMGN(int JIIGOACEIKL, string ACMJBEGLONB)
	{
		yield return null;
		UISelectionManager.GetPlayer(JIIGOACEIKL).Deselect();
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue(ACMJBEGLONB, JIIGOACEIKL, DHELBHAICMM: false, CGKNJONAKGD: false);
	}

	private void DCLILAIMLNG(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.ODENMDOJPLC() == 84)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(HDLBHLLAJHC));
			NewTutorialManager.instance.FOIOHOGACAL(1);
			((MonoBehaviour)this).StartCoroutine(NLJAMKLPLBJ());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private void IIBJBNLLMEM(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.CIGFGKKCPCK() == -19)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(LENCNLCLHLN));
			NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			((MonoBehaviour)this).StartCoroutine(AJJPECIKMJN());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private IEnumerator IJIFLIFIMOG(int JIIGOACEIKL, string ACMJBEGLONB)
	{
		yield return null;
		UISelectionManager.GetPlayer(JIIGOACEIKL).Deselect();
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue(ACMJBEGLONB, JIIGOACEIKL, DHELBHAICMM: false, CGKNJONAKGD: false);
	}

	private void LENCNLCLHLN(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.JDJGFAACPFC(DAINLFIMLIH: false) == -95)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(commonReferences.OnRecipeToCraftAdded, new Action<int, Recipe>(LENCNLCLHLN));
			NewTutorialManager.instance.FOIOHOGACAL(1);
			((MonoBehaviour)this).StartCoroutine(BJKKIJIKPMC());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private void HDLBHLLAJHC(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.JDJGFAACPFC(DAINLFIMLIH: false) == -57)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(commonReferences.OnRecipeToCraftAdded, new Action<int, Recipe>(IIBJBNLLMEM));
			NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}
}
