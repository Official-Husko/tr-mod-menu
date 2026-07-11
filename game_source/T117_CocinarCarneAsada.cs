using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class T117_CocinarCarneAsada : TutorialPhaseBase
{
	[CompilerGenerated]
	private sealed class ACLNCOLFJID : IEnumerator<object>, IEnumerator, IDisposable
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
		public ACLNCOLFJID(int _003C_003E1__state)
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

		public T117_CocinarCarneAsada _003C_003E4__this;

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
			T117_CocinarCarneAsada t117_CocinarCarneAsada = _003C_003E4__this;
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
				t117_CocinarCarneAsada.LHKIJABBBPM();
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

		public T117_CocinarCarneAsada _003C_003E4__this;

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
			//IL_015a: Unknown result type (might be due to invalid IL or missing references)
			//IL_015f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0164: Unknown result type (might be due to invalid IL or missing references)
			//IL_016e: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			T117_CocinarCarneAsada t117_CocinarCarneAsada = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
				goto IL_005d;
			case 1:
				_003C_003E1__state = -1;
				goto IL_005d;
			case 2:
				_003C_003E1__state = -1;
				NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 3;
				return true;
			case 3:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
				MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T117/Dialogue1", t117_CocinarCarneAsada.triggerPlayerNum);
				goto IL_00e7;
			case 4:
				_003C_003E1__state = -1;
				goto IL_00e7;
			case 5:
			{
				_003C_003E1__state = -1;
				NewTutorialManager.ShowPopUp();
				RecipesManager.UnlockRecipe(312, IBHGAMNNOHI: true);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCrafterOpened = (Action<int, Crafter>)Delegate.Combine(instance.OnAnyCrafterOpened, new Action<int, Crafter>(t117_CocinarCarneAsada.HGIBCKCGFKO));
				NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(672)).transform.position), Vector2.up * 0.7f, ref t117_CocinarCarneAsada.JELIKOFDONK);
				break;
			}
			case 6:
				{
					_003C_003E1__state = -1;
					break;
				}
				IL_00e7:
				if (t117_CocinarCarneAsada.AAOPIEDAKKD(1))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 4;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 5;
				return true;
				IL_005d:
				if (!t117_CocinarCarneAsada.AOOKIKFINFB())
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
				_003C_003E2__current = ((MonoBehaviour)t117_CocinarCarneAsada).StartCoroutine(t117_CocinarCarneAsada.CDICFNAMCEE());
				_003C_003E1__state = 2;
				return true;
			}
			if (t117_CocinarCarneAsada.AAOPIEDAKKD(2))
			{
				_003C_003E2__current = null;
				_003C_003E1__state = 6;
				return true;
			}
			Slot obj = ModifierUI.Get(1).slots[0];
			obj.OnItemAddedWithItem = (Action<ItemInstance>)Delegate.Combine(obj.OnItemAddedWithItem, new Action<ItemInstance>(t117_CocinarCarneAsada.JJOOABEDOPO));
			if (GameManager.LocalCoop())
			{
				Slot obj2 = ModifierUI.Get(2).slots[0];
				obj2.OnItemAddedWithItem = (Action<ItemInstance>)Delegate.Combine(obj2.OnItemAddedWithItem, new Action<ItemInstance>(t117_CocinarCarneAsada.JJOOABEDOPO));
			}
			GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(t117_CocinarCarneAsada.EDHEGFKDJDB));
			GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(t117_CocinarCarneAsada.AGMLGNDDINL));
			CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
			instance2.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Combine(instance2.OnRecipeToCraftAdded, new Action<int, Recipe>(t117_CocinarCarneAsada.EECHIAJHKLD));
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

	private void FKFLJMBBFAN()
	{
		Slot obj = ModifierUI.MIAOGLENOHL(1).slots[0];
		obj.OnItemAddedWithItem = (Action<ItemInstance>)Delegate.Remove(obj.OnItemAddedWithItem, new Action<ItemInstance>(ICNCOFIPJAF));
		Slot obj2 = ModifierUI.MBGFHNEBOJM(3).slots[1];
		obj2.OnItemAddedWithItem = (Action<ItemInstance>)Delegate.Remove(obj2.OnItemAddedWithItem, new Action<ItemInstance>(BOJFCGEGCAB));
		Slot obj3 = ModifierUI.NIGDBMAOAEN(0).slots[1];
		obj3.OnItemAddedWithItem = (Action<ItemInstance>)Delegate.Combine(obj3.OnItemAddedWithItem, new Action<ItemInstance>(DOGECADIFFO));
	}

	private void DLJELMADMCI(int JIIGOACEIKL, Crafter LDLINOBIKPL)
	{
		if (LDLINOBIKPL.recipeList.ID == -58)
		{
			((MonoBehaviour)this).StartCoroutine(BIHHMCBFPNK(JIIGOACEIKL, ""));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyCrafterOpened = (Action<int, Crafter>)Delegate.Remove(instance.OnAnyCrafterOpened, new Action<int, Crafter>(CJHIAJNBEDN));
		}
	}

	private void HGIBCKCGFKO(int JIIGOACEIKL, Crafter LDLINOBIKPL)
	{
		if (LDLINOBIKPL.recipeList.ID == 672)
		{
			((MonoBehaviour)this).StartCoroutine(INNCNOGFIMG(JIIGOACEIKL, "Tutorial/T117/Dialogue2"));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyCrafterOpened = (Action<int, Crafter>)Delegate.Remove(instance.OnAnyCrafterOpened, new Action<int, Crafter>(HGIBCKCGFKO));
		}
	}

	private void GJLCIKCMGCK()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(EECHIAJHKLD));
		Slot obj = ModifierUI.Get(1).slots[0];
		obj.OnItemAddedWithItem = (Action<ItemInstance>)Delegate.Remove(obj.OnItemAddedWithItem, new Action<ItemInstance>(JJOOABEDOPO));
		Slot obj2 = ModifierUI.Get(2).slots[0];
		obj2.OnItemAddedWithItem = (Action<ItemInstance>)Delegate.Remove(obj2.OnItemAddedWithItem, new Action<ItemInstance>(JJOOABEDOPO));
		GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(EDHEGFKDJDB));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(AGMLGNDDINL));
	}

	private void EECHIAJHKLD(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.JDJGFAACPFC() == 1257)
		{
			GJLCIKCMGCK();
			NewTutorialManager.instance.ObjectiveCompleted(0);
			((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private IEnumerator GOAENJIBOCP(int JIIGOACEIKL, string ACMJBEGLONB)
	{
		return new ACLNCOLFJID(1)
		{
			playerNum = JIIGOACEIKL,
			dialogue = ACMJBEGLONB
		};
	}

	private void FOPJOFHNHMG()
	{
		Slot obj = ModifierUI.MIAOGLENOHL(1).slots[0];
		obj.OnItemAddedWithItem = (Action<ItemInstance>)Delegate.Remove(obj.OnItemAddedWithItem, new Action<ItemInstance>(JJOOABEDOPO));
		Slot obj2 = ModifierUI.MBGFHNEBOJM(1).slots[1];
		obj2.OnItemAddedWithItem = (Action<ItemInstance>)Delegate.Combine(obj2.OnItemAddedWithItem, new Action<ItemInstance>(JJOOABEDOPO));
		Slot obj3 = ModifierUI.Get(1).slots[1];
		obj3.OnItemAddedWithItem = (Action<ItemInstance>)Delegate.Combine(obj3.OnItemAddedWithItem, new Action<ItemInstance>(ICNCOFIPJAF));
	}

	private void DOGECADIFFO(ItemInstance DNLMCHDOMOK)
	{
		int jIIGOACEIKL = ((!ModifierUI.Get(1).NFCHJIDFMFP()) ? 6 : 0);
		if (DNLMCHDOMOK.LHBPOPOIFLE().IMCJPECAAPC() == -183 && (ModifierUI.MBGFHNEBOJM(jIIGOACEIKL).slots[1].itemInstance as IngredientGroupInstance).chosenItemInstance != null)
		{
			((MonoBehaviour)this).StartCoroutine(BIHHMCBFPNK(jIIGOACEIKL, "%><sprite name=RightStick></size>"));
			ModifierUI.Get(jIIGOACEIKL).GFIDPACCBAJ(ModifierUI.MBGFHNEBOJM(jIIGOACEIKL).slots[0], 1, ModifierUI.Get(jIIGOACEIKL).slots[1].Stack);
			ModifierUI.MIAOGLENOHL(jIIGOACEIKL).HKMBLABHCMP();
		}
	}

	private void ICNCOFIPJAF(ItemInstance DNLMCHDOMOK)
	{
		int jIIGOACEIKL = (ModifierUI.Get(0).IMLKMLPFAFA() ? 1 : 2);
		if (DNLMCHDOMOK.KNFNJFFCFNO().CIGFGKKCPCK() == 1 && (ModifierUI.NIGDBMAOAEN(jIIGOACEIKL).slots[1].itemInstance as IngredientGroupInstance).chosenItemInstance != null)
		{
			((MonoBehaviour)this).StartCoroutine(PAMKHEPMEMN(jIIGOACEIKL, "Dialogue System/Conversation/BirdNegativeComments/Entry/10/Dialogue Text"));
			ModifierUI.NIGDBMAOAEN(jIIGOACEIKL).LLPKJIMIMBM(ModifierUI.Get(jIIGOACEIKL).slots[0], 1, ModifierUI.MBGFHNEBOJM(jIIGOACEIKL).slots[1].Stack);
			ModifierUI.MBGFHNEBOJM(jIIGOACEIKL).EHCKDGIGPBI();
		}
	}

	private void PLCFNCMIKEH()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(DDCCMBLPIMC));
		Slot obj = ModifierUI.MIAOGLENOHL(0).slots[1];
		obj.OnItemAddedWithItem = (Action<ItemInstance>)Delegate.Remove(obj.OnItemAddedWithItem, new Action<ItemInstance>(BOJFCGEGCAB));
		Slot obj2 = ModifierUI.NIGDBMAOAEN(3).slots[1];
		obj2.OnItemAddedWithItem = (Action<ItemInstance>)Delegate.Remove(obj2.OnItemAddedWithItem, new Action<ItemInstance>(PMAOEHDAKCL));
		GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(FHDHPPBMEMN));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(FKFLJMBBFAN));
	}

	private IEnumerator BIHHMCBFPNK(int JIIGOACEIKL, string ACMJBEGLONB)
	{
		yield return null;
		UISelectionManager.GetPlayer(JIIGOACEIKL).Deselect();
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue(ACMJBEGLONB, JIIGOACEIKL, DHELBHAICMM: false, CGKNJONAKGD: false);
	}

	private void FHDHPPBMEMN()
	{
		Slot obj = ModifierUI.Get(1).slots[0];
		obj.OnItemAddedWithItem = (Action<ItemInstance>)Delegate.Remove(obj.OnItemAddedWithItem, new Action<ItemInstance>(LEEGAGMIHCB));
		Slot obj2 = ModifierUI.Get(1).slots[0];
		obj2.OnItemAddedWithItem = (Action<ItemInstance>)Delegate.Combine(obj2.OnItemAddedWithItem, new Action<ItemInstance>(BOJFCGEGCAB));
		Slot obj3 = ModifierUI.MIAOGLENOHL(4).slots[0];
		obj3.OnItemAddedWithItem = (Action<ItemInstance>)Delegate.Combine(obj3.OnItemAddedWithItem, new Action<ItemInstance>(PMAOEHDAKCL));
	}

	private void BPDEIGAPPDP()
	{
		Slot obj = ModifierUI.MIAOGLENOHL(0).slots[0];
		obj.OnItemAddedWithItem = (Action<ItemInstance>)Delegate.Remove(obj.OnItemAddedWithItem, new Action<ItemInstance>(JJOOABEDOPO));
		Slot obj2 = ModifierUI.MIAOGLENOHL(0).slots[0];
		obj2.OnItemAddedWithItem = (Action<ItemInstance>)Delegate.Combine(obj2.OnItemAddedWithItem, new Action<ItemInstance>(DOGECADIFFO));
		Slot obj3 = ModifierUI.NIGDBMAOAEN(0).slots[0];
		obj3.OnItemAddedWithItem = (Action<ItemInstance>)Delegate.Combine(obj3.OnItemAddedWithItem, new Action<ItemInstance>(DOGECADIFFO));
	}

	private IEnumerator ODPACDKBJHJ(int JIIGOACEIKL, string ACMJBEGLONB)
	{
		yield return null;
		UISelectionManager.GetPlayer(JIIGOACEIKL).Deselect();
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue(ACMJBEGLONB, JIIGOACEIKL, DHELBHAICMM: false, CGKNJONAKGD: false);
	}

	private IEnumerator DECKMELAPMA()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator BJPDFDCOJKJ()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void ADLNHFFJDLP()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(FELMMDAIHGP));
		Slot obj = ModifierUI.NIGDBMAOAEN(1).slots[1];
		obj.OnItemAddedWithItem = (Action<ItemInstance>)Delegate.Remove(obj.OnItemAddedWithItem, new Action<ItemInstance>(BOJFCGEGCAB));
		Slot obj2 = ModifierUI.Get(3).slots[0];
		obj2.OnItemAddedWithItem = (Action<ItemInstance>)Delegate.Remove(obj2.OnItemAddedWithItem, new Action<ItemInstance>(DOGECADIFFO));
		GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(EDHEGFKDJDB));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(FKFLJMBBFAN));
	}

	private void IMAKEBNFGNH(int JIIGOACEIKL, Crafter LDLINOBIKPL)
	{
		if (LDLINOBIKPL.recipeList.ID == 132)
		{
			((MonoBehaviour)this).StartCoroutine(ODPACDKBJHJ(JIIGOACEIKL, "NewCharacters/"));
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyCrafterOpened = (Action<int, Crafter>)Delegate.Remove(commonReferences.OnAnyCrafterOpened, new Action<int, Crafter>(HGIBCKCGFKO));
		}
	}

	private void DCCCOFBNFCJ()
	{
		Slot obj = ModifierUI.Get(0).slots[0];
		obj.OnItemAddedWithItem = (Action<ItemInstance>)Delegate.Remove(obj.OnItemAddedWithItem, new Action<ItemInstance>(LEEGAGMIHCB));
		Slot obj2 = ModifierUI.MBGFHNEBOJM(1).slots[0];
		obj2.OnItemAddedWithItem = (Action<ItemInstance>)Delegate.Combine(obj2.OnItemAddedWithItem, new Action<ItemInstance>(LEEGAGMIHCB));
		Slot obj3 = ModifierUI.MIAOGLENOHL(8).slots[1];
		obj3.OnItemAddedWithItem = (Action<ItemInstance>)Delegate.Combine(obj3.OnItemAddedWithItem, new Action<ItemInstance>(DOGECADIFFO));
	}

	private void EDHEGFKDJDB()
	{
		Slot obj = ModifierUI.Get(1).slots[0];
		obj.OnItemAddedWithItem = (Action<ItemInstance>)Delegate.Remove(obj.OnItemAddedWithItem, new Action<ItemInstance>(JJOOABEDOPO));
		Slot obj2 = ModifierUI.Get(1).slots[0];
		obj2.OnItemAddedWithItem = (Action<ItemInstance>)Delegate.Combine(obj2.OnItemAddedWithItem, new Action<ItemInstance>(JJOOABEDOPO));
		Slot obj3 = ModifierUI.Get(2).slots[0];
		obj3.OnItemAddedWithItem = (Action<ItemInstance>)Delegate.Combine(obj3.OnItemAddedWithItem, new Action<ItemInstance>(JJOOABEDOPO));
	}

	private void AGMLGNDDINL()
	{
		Slot obj = ModifierUI.Get(1).slots[0];
		obj.OnItemAddedWithItem = (Action<ItemInstance>)Delegate.Remove(obj.OnItemAddedWithItem, new Action<ItemInstance>(JJOOABEDOPO));
		Slot obj2 = ModifierUI.Get(2).slots[0];
		obj2.OnItemAddedWithItem = (Action<ItemInstance>)Delegate.Remove(obj2.OnItemAddedWithItem, new Action<ItemInstance>(JJOOABEDOPO));
		Slot obj3 = ModifierUI.Get(1).slots[0];
		obj3.OnItemAddedWithItem = (Action<ItemInstance>)Delegate.Combine(obj3.OnItemAddedWithItem, new Action<ItemInstance>(JJOOABEDOPO));
	}

	private void MIEIDKLDDMO()
	{
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(FELMMDAIHGP));
		Slot obj = ModifierUI.MIAOGLENOHL(1).slots[0];
		obj.OnItemAddedWithItem = (Action<ItemInstance>)Delegate.Remove(obj.OnItemAddedWithItem, new Action<ItemInstance>(ICNCOFIPJAF));
		Slot obj2 = ModifierUI.MBGFHNEBOJM(5).slots[0];
		obj2.OnItemAddedWithItem = (Action<ItemInstance>)Delegate.Remove(obj2.OnItemAddedWithItem, new Action<ItemInstance>(LEEGAGMIHCB));
		GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(OBMDGAOEPIO));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(FKFLJMBBFAN));
	}

	private IEnumerator HCKCEGEOJLO()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void JJOOABEDOPO(ItemInstance DNLMCHDOMOK)
	{
		int jIIGOACEIKL = (ModifierUI.Get(1).IsOpened() ? 1 : 2);
		if (DNLMCHDOMOK.LHBPOPOIFLE().JDJGFAACPFC() == 1247 && (ModifierUI.Get(jIIGOACEIKL).slots[0].itemInstance as IngredientGroupInstance).chosenItemInstance != null)
		{
			((MonoBehaviour)this).StartCoroutine(INNCNOGFIMG(jIIGOACEIKL, "Tutorial/T117/Dialogue3"));
			ModifierUI.Get(jIIGOACEIKL).TransferItemToCraftingInventory(ModifierUI.Get(jIIGOACEIKL).slots[0], 0, ModifierUI.Get(jIIGOACEIKL).slots[0].Stack);
			ModifierUI.Get(jIIGOACEIKL).UpdateGameInventoryNewSystem();
		}
	}

	private void GOPFNALODEH()
	{
		Slot obj = ModifierUI.NIGDBMAOAEN(1).slots[0];
		obj.OnItemAddedWithItem = (Action<ItemInstance>)Delegate.Remove(obj.OnItemAddedWithItem, new Action<ItemInstance>(ICNCOFIPJAF));
		Slot obj2 = ModifierUI.MBGFHNEBOJM(4).slots[1];
		obj2.OnItemAddedWithItem = (Action<ItemInstance>)Delegate.Remove(obj2.OnItemAddedWithItem, new Action<ItemInstance>(BOJFCGEGCAB));
		Slot obj3 = ModifierUI.NIGDBMAOAEN(1).slots[0];
		obj3.OnItemAddedWithItem = (Action<ItemInstance>)Delegate.Combine(obj3.OnItemAddedWithItem, new Action<ItemInstance>(LEEGAGMIHCB));
	}

	private void DDCCMBLPIMC(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.IMCJPECAAPC() == -191)
		{
			MIEIDKLDDMO();
			NewTutorialManager.instance.FOIOHOGACAL(0);
			((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private void CJHIAJNBEDN(int JIIGOACEIKL, Crafter LDLINOBIKPL)
	{
		if (LDLINOBIKPL.recipeList.ID == 74)
		{
			((MonoBehaviour)this).StartCoroutine(ODPACDKBJHJ(JIIGOACEIKL, " (Online Remote Clone)"));
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyCrafterOpened = (Action<int, Crafter>)Delegate.Remove(instance.OnAnyCrafterOpened, new Action<int, Crafter>(HGIBCKCGFKO));
		}
	}

	private void FELMMDAIHGP(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.IMCJPECAAPC(DAINLFIMLIH: false) == -138)
		{
			MIEIDKLDDMO();
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private void KKCKOPPNKMI()
	{
		Slot obj = ModifierUI.MBGFHNEBOJM(1).slots[1];
		obj.OnItemAddedWithItem = (Action<ItemInstance>)Delegate.Remove(obj.OnItemAddedWithItem, new Action<ItemInstance>(JJOOABEDOPO));
		Slot obj2 = ModifierUI.MIAOGLENOHL(1).slots[1];
		obj2.OnItemAddedWithItem = (Action<ItemInstance>)Delegate.Combine(obj2.OnItemAddedWithItem, new Action<ItemInstance>(DOGECADIFFO));
		Slot obj3 = ModifierUI.MBGFHNEBOJM(6).slots[1];
		obj3.OnItemAddedWithItem = (Action<ItemInstance>)Delegate.Combine(obj3.OnItemAddedWithItem, new Action<ItemInstance>(BOJFCGEGCAB));
	}

	private IEnumerator AJJPECIKMJN()
	{
		return new BGBGBBECCHB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void JPFELEHCBEN(int JIIGOACEIKL, Crafter LDLINOBIKPL)
	{
		if (LDLINOBIKPL.recipeList.ID == -68)
		{
			((MonoBehaviour)this).StartCoroutine(INNCNOGFIMG(JIIGOACEIKL, "Dialogue System/Conversation/Gass_Quest/Entry/24/Dialogue Text"));
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyCrafterOpened = (Action<int, Crafter>)Delegate.Remove(commonReferences.OnAnyCrafterOpened, new Action<int, Crafter>(JPFELEHCBEN));
		}
	}

	private void LEEGAGMIHCB(ItemInstance DNLMCHDOMOK)
	{
		int jIIGOACEIKL = ((!ModifierUI.Get(0).IMLKMLPFAFA()) ? 1 : 0);
		if (DNLMCHDOMOK.LHBPOPOIFLE().IMCJPECAAPC(DAINLFIMLIH: false) == 3 && (ModifierUI.MIAOGLENOHL(jIIGOACEIKL).slots[0].itemInstance as IngredientGroupInstance).chosenItemInstance != null)
		{
			((MonoBehaviour)this).StartCoroutine(GOAENJIBOCP(jIIGOACEIKL, "]"));
			ModifierUI.MIAOGLENOHL(jIIGOACEIKL).LLPKJIMIMBM(ModifierUI.MIAOGLENOHL(jIIGOACEIKL).slots[1], 0, ModifierUI.MBGFHNEBOJM(jIIGOACEIKL).slots[1].Stack, KDCAODJIEMD: true);
			ModifierUI.Get(jIIGOACEIKL).EHCKDGIGPBI();
		}
	}

	private IEnumerator DEDCDHMGDAN(int JIIGOACEIKL, string ACMJBEGLONB)
	{
		yield return null;
		UISelectionManager.GetPlayer(JIIGOACEIKL).Deselect();
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue(ACMJBEGLONB, JIIGOACEIKL, DHELBHAICMM: false, CGKNJONAKGD: false);
	}

	private IEnumerator PAMKHEPMEMN(int JIIGOACEIKL, string ACMJBEGLONB)
	{
		return new ACLNCOLFJID(1)
		{
			playerNum = JIIGOACEIKL,
			dialogue = ACMJBEGLONB
		};
	}

	private void PMAOEHDAKCL(ItemInstance DNLMCHDOMOK)
	{
		int jIIGOACEIKL = (ModifierUI.MIAOGLENOHL(0).NHKBBCBPBMH() ? 1 : 7);
		if (DNLMCHDOMOK.PHGLMBIEOMK().ODENMDOJPLC(DAINLFIMLIH: false) == -45 && (ModifierUI.MBGFHNEBOJM(jIIGOACEIKL).slots[1].itemInstance as IngredientGroupInstance).chosenItemInstance != null)
		{
			((MonoBehaviour)this).StartCoroutine(PAMKHEPMEMN(jIIGOACEIKL, ""));
			ModifierUI.NIGDBMAOAEN(jIIGOACEIKL).TransferItemToCraftingInventory(ModifierUI.MBGFHNEBOJM(jIIGOACEIKL).slots[0], 0, ModifierUI.MIAOGLENOHL(jIIGOACEIKL).slots[0].Stack);
			ModifierUI.Get(jIIGOACEIKL).UpdateGameInventoryNewSystem();
		}
	}

	private void OBMDGAOEPIO()
	{
		Slot obj = ModifierUI.Get(1).slots[0];
		obj.OnItemAddedWithItem = (Action<ItemInstance>)Delegate.Remove(obj.OnItemAddedWithItem, new Action<ItemInstance>(JJOOABEDOPO));
		Slot obj2 = ModifierUI.MIAOGLENOHL(1).slots[0];
		obj2.OnItemAddedWithItem = (Action<ItemInstance>)Delegate.Combine(obj2.OnItemAddedWithItem, new Action<ItemInstance>(PMAOEHDAKCL));
		Slot obj3 = ModifierUI.MBGFHNEBOJM(2).slots[0];
		obj3.OnItemAddedWithItem = (Action<ItemInstance>)Delegate.Combine(obj3.OnItemAddedWithItem, new Action<ItemInstance>(LEEGAGMIHCB));
	}

	private void EJMHLFEEJHJ()
	{
		Slot obj = ModifierUI.MIAOGLENOHL(1).slots[0];
		obj.OnItemAddedWithItem = (Action<ItemInstance>)Delegate.Remove(obj.OnItemAddedWithItem, new Action<ItemInstance>(NONDDEENJPJ));
		Slot obj2 = ModifierUI.NIGDBMAOAEN(0).slots[1];
		obj2.OnItemAddedWithItem = (Action<ItemInstance>)Delegate.Combine(obj2.OnItemAddedWithItem, new Action<ItemInstance>(LEEGAGMIHCB));
		Slot obj3 = ModifierUI.MBGFHNEBOJM(5).slots[1];
		obj3.OnItemAddedWithItem = (Action<ItemInstance>)Delegate.Combine(obj3.OnItemAddedWithItem, new Action<ItemInstance>(BOJFCGEGCAB));
	}

	private IEnumerator LHDDHIJIFCN()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void CPOAPEAGHMB()
	{
		Slot obj = ModifierUI.MBGFHNEBOJM(1).slots[1];
		obj.OnItemAddedWithItem = (Action<ItemInstance>)Delegate.Remove(obj.OnItemAddedWithItem, new Action<ItemInstance>(ICNCOFIPJAF));
		Slot obj2 = ModifierUI.NIGDBMAOAEN(0).slots[0];
		obj2.OnItemAddedWithItem = (Action<ItemInstance>)Delegate.Combine(obj2.OnItemAddedWithItem, new Action<ItemInstance>(ICNCOFIPJAF));
		Slot obj3 = ModifierUI.Get(6).slots[0];
		obj3.OnItemAddedWithItem = (Action<ItemInstance>)Delegate.Combine(obj3.OnItemAddedWithItem, new Action<ItemInstance>(ICNCOFIPJAF));
	}

	private IEnumerator PBEKBJIJFDK()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T117/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		NewTutorialManager.ShowPopUp();
		RecipesManager.UnlockRecipe(312, IBHGAMNNOHI: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCrafterOpened = (Action<int, Crafter>)Delegate.Combine(instance.OnAnyCrafterOpened, new Action<int, Crafter>(HGIBCKCGFKO));
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(672)).transform.position), Vector2.up * 0.7f, ref JELIKOFDONK);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		Slot obj = ModifierUI.Get(1).slots[0];
		obj.OnItemAddedWithItem = (Action<ItemInstance>)Delegate.Combine(obj.OnItemAddedWithItem, new Action<ItemInstance>(JJOOABEDOPO));
		if (GameManager.LocalCoop())
		{
			Slot obj2 = ModifierUI.Get(2).slots[0];
			obj2.OnItemAddedWithItem = (Action<ItemInstance>)Delegate.Combine(obj2.OnItemAddedWithItem, new Action<ItemInstance>(JJOOABEDOPO));
		}
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(EDHEGFKDJDB));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(AGMLGNDDINL));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Combine(instance2.OnRecipeToCraftAdded, new Action<int, Recipe>(EECHIAJHKLD));
	}

	private void NONDDEENJPJ(ItemInstance DNLMCHDOMOK)
	{
		int jIIGOACEIKL = ((!ModifierUI.NIGDBMAOAEN(0).IsOpened()) ? 7 : 0);
		if (DNLMCHDOMOK.AFOACBIHNCL().IMCJPECAAPC() == -90 && (ModifierUI.MBGFHNEBOJM(jIIGOACEIKL).slots[0].itemInstance as IngredientGroupInstance).chosenItemInstance != null)
		{
			((MonoBehaviour)this).StartCoroutine(ODPACDKBJHJ(jIIGOACEIKL, " cannot be unloaded at this time. Either it's already unloaded or it's in the process of unloading."));
			ModifierUI.MBGFHNEBOJM(jIIGOACEIKL).GFIDPACCBAJ(ModifierUI.NIGDBMAOAEN(jIIGOACEIKL).slots[0], 0, ModifierUI.Get(jIIGOACEIKL).slots[0].Stack);
			ModifierUI.MBGFHNEBOJM(jIIGOACEIKL).UpdateGameInventoryNewSystem();
		}
	}

	public override int GetID()
	{
		return 117;
	}

	private void BOJFCGEGCAB(ItemInstance DNLMCHDOMOK)
	{
		int jIIGOACEIKL = (ModifierUI.MBGFHNEBOJM(0).IMLKMLPFAFA() ? 0 : 0);
		if (DNLMCHDOMOK.KNFNJFFCFNO().JGHNDJBCFAJ() == 61 && (ModifierUI.MBGFHNEBOJM(jIIGOACEIKL).slots[1].itemInstance as IngredientGroupInstance).chosenItemInstance != null)
		{
			((MonoBehaviour)this).StartCoroutine(PAMKHEPMEMN(jIIGOACEIKL, "Sending pipe puzzle solved for mine level {0}"));
			ModifierUI.MBGFHNEBOJM(jIIGOACEIKL).TransferItemToCraftingInventory(ModifierUI.MIAOGLENOHL(jIIGOACEIKL).slots[1], 0, ModifierUI.MBGFHNEBOJM(jIIGOACEIKL).slots[0].Stack);
			ModifierUI.MBGFHNEBOJM(jIIGOACEIKL).UpdateGameInventoryNewSystem();
		}
	}

	private IEnumerator INNCNOGFIMG(int JIIGOACEIKL, string ACMJBEGLONB)
	{
		yield return null;
		UISelectionManager.GetPlayer(JIIGOACEIKL).Deselect();
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue(ACMJBEGLONB, JIIGOACEIKL, DHELBHAICMM: false, CGKNJONAKGD: false);
	}

	private void DFNDIGAPCAJ(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.JPNFKDMFKMC() == -4)
		{
			PLCFNCMIKEH();
			NewTutorialManager.instance.FOIOHOGACAL(0);
			((MonoBehaviour)this).StartCoroutine(HCKCEGEOJLO());
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

	public override void SetUp()
	{
		base.SetUp();
		ResetMai();
		((MonoBehaviour)this).StartCoroutine(PBEKBJIJFDK());
	}

	private void IHFOIAIOLIK(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.JPNFKDMFKMC() == 54)
		{
			PLCFNCMIKEH();
			NewTutorialManager.instance.FOIOHOGACAL(1);
			((MonoBehaviour)this).StartCoroutine(HHLKPNANHKK());
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private IEnumerator HHLKPNANHKK()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void LPJGHCMFFEP()
	{
		Slot obj = ModifierUI.NIGDBMAOAEN(0).slots[0];
		obj.OnItemAddedWithItem = (Action<ItemInstance>)Delegate.Remove(obj.OnItemAddedWithItem, new Action<ItemInstance>(ICNCOFIPJAF));
		Slot obj2 = ModifierUI.Get(1).slots[1];
		obj2.OnItemAddedWithItem = (Action<ItemInstance>)Delegate.Combine(obj2.OnItemAddedWithItem, new Action<ItemInstance>(NONDDEENJPJ));
		Slot obj3 = ModifierUI.NIGDBMAOAEN(8).slots[1];
		obj3.OnItemAddedWithItem = (Action<ItemInstance>)Delegate.Combine(obj3.OnItemAddedWithItem, new Action<ItemInstance>(ICNCOFIPJAF));
	}
}
