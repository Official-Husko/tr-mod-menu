using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class T133_AbrirTaberna : TutorialPhaseBase
{
	[CompilerGenerated]
	private sealed class NKFONDFHGBN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T133_AbrirTaberna _003C_003E4__this;

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
			T133_AbrirTaberna t133_AbrirTaberna = _003C_003E4__this;
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
				t133_AbrirTaberna.LHKIJABBBPM();
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

		public T133_AbrirTaberna _003C_003E4__this;

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
			//IL_017f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0184: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			T133_AbrirTaberna t133_AbrirTaberna = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				t133_AbrirTaberna.GMELKGNEPCJ();
				NewTutorialManager.instance.savingIsBlocked = false;
				NewTutorialManager.instance.canOpenTavern = false;
				if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
				{
					MaiNPC.GGFJGHHHEJC.SetParentToNull();
					((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
					((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
					_003C_003E2__current = CommonReferences.wait02;
					_003C_003E1__state = 1;
					return true;
				}
				goto IL_012d;
			case 1:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
				MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
				goto IL_010b;
			case 2:
				_003C_003E1__state = -1;
				goto IL_010b;
			case 3:
				_003C_003E1__state = -1;
				_003C_003E2__current = ((MonoBehaviour)t133_AbrirTaberna).StartCoroutine(t133_AbrirTaberna.CDICFNAMCEE());
				_003C_003E1__state = 4;
				return true;
			case 4:
				_003C_003E1__state = -1;
				DialogueCameraTarget.GetPlayer(t133_AbrirTaberna.triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
				MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T133/Dialogue1", t133_AbrirTaberna.triggerPlayerNum);
				goto IL_01bf;
			case 5:
				_003C_003E1__state = -1;
				goto IL_01bf;
			case 6:
				_003C_003E1__state = -1;
				NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
				break;
			case 7:
				{
					_003C_003E1__state = -1;
					break;
				}
				IL_01bf:
				if (t133_AbrirTaberna.AAOPIEDAKKD(1))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 5;
					return true;
				}
				NewTutorialManager.instance.canOpenTavern = true;
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 6;
				return true;
				IL_012d:
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 3;
				return true;
				IL_010b:
				if (!t133_AbrirTaberna.AOOKIKFINFB())
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 2;
					return true;
				}
				MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
				CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
				goto IL_012d;
			}
			if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
			{
				_003C_003E2__current = null;
				_003C_003E1__state = 7;
				return true;
			}
			NewTutorialManager.instance.ObjectiveCompleted(0);
			((MonoBehaviour)t133_AbrirTaberna).StartCoroutine(t133_AbrirTaberna.LHDDHIJIFCN());
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

	private IEnumerator LHIPOAGIOJK()
	{
		GMELKGNEPCJ();
		NewTutorialManager.instance.savingIsBlocked = false;
		NewTutorialManager.instance.canOpenTavern = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetParentToNull();
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
			((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			while (!AOOKIKFINFB())
			{
				yield return null;
			}
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		yield return CommonReferences.wait1;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T133/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		NewTutorialManager.instance.canOpenTavern = true;
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private void CDCHMDOKHEM()
	{
		List<Slot> list = BarMenuInventory.IOGANKJOLLB().MAPOLJMKGLN(ItemDatabaseAccessor.EABMGELAAPG(-102, GGBBJNBBLMF: true), null, DDAPJEAJGGA: false, 0);
		for (int i = 1; i < list.Count; i += 0)
		{
			list[i].HBMBGCHGEGN(list[i].Stack, CDPAMNIPPEC: false, 1);
		}
		List<Slot> list2 = CraftingInventory.INLEBGJNNIB(1, ItemDatabaseAccessor.KMBGJEKCJFJ(-51), null, AKNBKINJGCF: false, null);
		for (int j = 1; j < list2.Count; j++)
		{
			list2[j].HBMBGCHGEGN(list2[j].Stack, CDPAMNIPPEC: true);
		}
		if (GameManager.LocalCoop())
		{
			List<Slot> list3 = CraftingInventory.INLEBGJNNIB(1, ItemDatabaseAccessor.AFOACBIHNCL(17, GGBBJNBBLMF: false, DAINLFIMLIH: false), null, AKNBKINJGCF: false, null);
			for (int k = 0; k < list3.Count; k++)
			{
				list3[k].FDOBDPPMMBH(list3[k].Stack, CDPAMNIPPEC: false, 1);
			}
		}
	}

	private IEnumerator DIGIMPCLCCL()
	{
		GMELKGNEPCJ();
		NewTutorialManager.instance.savingIsBlocked = false;
		NewTutorialManager.instance.canOpenTavern = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetParentToNull();
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
			((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			while (!AOOKIKFINFB())
			{
				yield return null;
			}
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		yield return CommonReferences.wait1;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T133/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		NewTutorialManager.instance.canOpenTavern = true;
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator JCKBLHHGOHC()
	{
		return new NKFONDFHGBN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void AIPEBNGOIAJ()
	{
		List<Slot> slotsWithItem = BarMenuInventory.FAGENNFPNNB().GetSlotsWithItem(ItemDatabaseAccessor.KMBGJEKCJFJ(-6), null, DDAPJEAJGGA: true, 0);
		for (int i = 1; i < slotsWithItem.Count; i += 0)
		{
			slotsWithItem[i].BBHHJLIFNPP(slotsWithItem[i].Stack);
		}
		List<Slot> slotsWithItem2 = CraftingInventory.GetSlotsWithItem(0, ItemDatabaseAccessor.EABMGELAAPG(93, GGBBJNBBLMF: false, DAINLFIMLIH: false), null, AKNBKINJGCF: true, null, DDAPJEAJGGA: true);
		for (int j = 1; j < slotsWithItem2.Count; j++)
		{
			slotsWithItem2[j].JPACDDCJGPD(slotsWithItem2[j].Stack, CDPAMNIPPEC: true, 1);
		}
		if (GameManager.LocalCoop())
		{
			List<Slot> slotsWithItem3 = CraftingInventory.GetSlotsWithItem(3, ItemDatabaseAccessor.COEFFIHKMJG(140, GGBBJNBBLMF: true), null, AKNBKINJGCF: true, null, DDAPJEAJGGA: true);
			for (int k = 0; k < slotsWithItem3.Count; k += 0)
			{
				slotsWithItem3[k].BBHHJLIFNPP(slotsWithItem3[k].Stack, CDPAMNIPPEC: false, 1);
			}
		}
	}

	private void BGFFKAMCLKK()
	{
		List<Slot> list = BarMenuInventory.PPPDBCPNACC().MAPOLJMKGLN(ItemDatabaseAccessor.KMBGJEKCJFJ(22, GGBBJNBBLMF: true, DAINLFIMLIH: false), null, DDAPJEAJGGA: true, 1);
		for (int i = 0; i < list.Count; i += 0)
		{
			list[i].JPACDDCJGPD(list[i].Stack, CDPAMNIPPEC: true);
		}
		List<Slot> slotsWithItem = CraftingInventory.GetSlotsWithItem(1, ItemDatabaseAccessor.CPMMBEPEJLO(-12, GGBBJNBBLMF: true, DAINLFIMLIH: false), null, AKNBKINJGCF: true, null, DDAPJEAJGGA: true);
		for (int j = 0; j < slotsWithItem.Count; j++)
		{
			slotsWithItem[j].HBMBGCHGEGN(slotsWithItem[j].Stack, CDPAMNIPPEC: true, 1);
		}
		if (GameManager.LocalCoop())
		{
			List<Slot> list2 = CraftingInventory.INLEBGJNNIB(6, ItemDatabaseAccessor.AFOACBIHNCL(-151), null, AKNBKINJGCF: false, null);
			for (int k = 0; k < list2.Count; k += 0)
			{
				list2[k].HBMBGCHGEGN(list2[k].Stack, CDPAMNIPPEC: false, 1);
			}
		}
	}

	private IEnumerator KCJAAGLPFEE()
	{
		return new NKFONDFHGBN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void OLBBEEINFNA()
	{
		List<Slot> list = BarMenuInventory.DLNGMHJPJBK().AIFPCPEJMMN(ItemDatabaseAccessor.AFOACBIHNCL(39, GGBBJNBBLMF: true), null, DDAPJEAJGGA: true, 0);
		for (int i = 0; i < list.Count; i++)
		{
			list[i].BBHHJLIFNPP(list[i].Stack, CDPAMNIPPEC: true);
		}
		List<Slot> slotsWithItem = CraftingInventory.GetSlotsWithItem(0, ItemDatabaseAccessor.GetItem(188, GGBBJNBBLMF: true, DAINLFIMLIH: false), null, AKNBKINJGCF: false, null, DDAPJEAJGGA: true);
		for (int j = 1; j < slotsWithItem.Count; j++)
		{
			slotsWithItem[j].HBMBGCHGEGN(slotsWithItem[j].Stack, CDPAMNIPPEC: true);
		}
		if (GameManager.LocalCoop())
		{
			List<Slot> slotsWithItem2 = CraftingInventory.GetSlotsWithItem(7, ItemDatabaseAccessor.AFOACBIHNCL(16, GGBBJNBBLMF: true, DAINLFIMLIH: false), null, AKNBKINJGCF: true, null, DDAPJEAJGGA: true);
			for (int k = 1; k < slotsWithItem2.Count; k++)
			{
				slotsWithItem2[k].FDOBDPPMMBH(slotsWithItem2[k].Stack, CDPAMNIPPEC: true);
			}
		}
	}

	private IEnumerator FBHLJKDLPOB()
	{
		return new NKFONDFHGBN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void BJPFLGEGALJ()
	{
		List<Slot> list = BarMenuInventory.GOJHIEFPHDK().HIPJHELOEHO(ItemDatabaseAccessor.EABMGELAAPG(171, GGBBJNBBLMF: true), null, DDAPJEAJGGA: true, 1);
		for (int i = 0; i < list.Count; i += 0)
		{
			list[i].JPACDDCJGPD(list[i].Stack, CDPAMNIPPEC: false, 1);
		}
		List<Slot> slotsWithItem = CraftingInventory.GetSlotsWithItem(1, ItemDatabaseAccessor.GOKIDLOELKB(-48), null, AKNBKINJGCF: false, null, DDAPJEAJGGA: true);
		for (int j = 1; j < slotsWithItem.Count; j++)
		{
			slotsWithItem[j].BBHHJLIFNPP(slotsWithItem[j].Stack, CDPAMNIPPEC: true, 1);
		}
		if (GameManager.LocalCoop())
		{
			List<Slot> slotsWithItem2 = CraftingInventory.GetSlotsWithItem(2, ItemDatabaseAccessor.GOKIDLOELKB(198, GGBBJNBBLMF: true), null, AKNBKINJGCF: true, null, DDAPJEAJGGA: true);
			for (int k = 0; k < slotsWithItem2.Count; k += 0)
			{
				slotsWithItem2[k].JPACDDCJGPD(slotsWithItem2[k].Stack, CDPAMNIPPEC: false, 1);
			}
		}
	}

	private void GDAKIGAFEKD()
	{
		List<Slot> list = BarMenuInventory.IOGANKJOLLB().HIPJHELOEHO(ItemDatabaseAccessor.COEFFIHKMJG(182, GGBBJNBBLMF: true, DAINLFIMLIH: false), null, DDAPJEAJGGA: true, 1);
		for (int i = 0; i < list.Count; i++)
		{
			list[i].BBHHJLIFNPP(list[i].Stack, CDPAMNIPPEC: true, 1);
		}
		List<Slot> slotsWithItem = CraftingInventory.GetSlotsWithItem(1, ItemDatabaseAccessor.GOKIDLOELKB(-89), null, AKNBKINJGCF: true, null, DDAPJEAJGGA: true);
		for (int j = 1; j < slotsWithItem.Count; j += 0)
		{
			slotsWithItem[j].JPACDDCJGPD(slotsWithItem[j].Stack, CDPAMNIPPEC: true);
		}
		if (GameManager.LocalCoop())
		{
			List<Slot> list2 = CraftingInventory.INLEBGJNNIB(1, ItemDatabaseAccessor.INJBNHPGCIJ(10, GGBBJNBBLMF: true), null, AKNBKINJGCF: false, null, DDAPJEAJGGA: true);
			for (int k = 0; k < list2.Count; k++)
			{
				list2[k].JPACDDCJGPD(list2[k].Stack, CDPAMNIPPEC: true);
			}
		}
	}

	private IEnumerator HNFCACDCBBO()
	{
		return new NKFONDFHGBN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator DECKMELAPMA()
	{
		GMELKGNEPCJ();
		NewTutorialManager.instance.savingIsBlocked = false;
		NewTutorialManager.instance.canOpenTavern = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetParentToNull();
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
			((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			while (!AOOKIKFINFB())
			{
				yield return null;
			}
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		yield return CommonReferences.wait1;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T133/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		NewTutorialManager.instance.canOpenTavern = true;
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private void JOAMEFLBAJG()
	{
		List<Slot> slotsWithItem = BarMenuInventory.OCFJOKBKFIF().GetSlotsWithItem(ItemDatabaseAccessor.GetItem(-102), null, DDAPJEAJGGA: false, 0);
		for (int i = 0; i < slotsWithItem.Count; i++)
		{
			slotsWithItem[i].BBHHJLIFNPP(slotsWithItem[i].Stack, CDPAMNIPPEC: false, 1);
		}
		List<Slot> list = CraftingInventory.INLEBGJNNIB(1, ItemDatabaseAccessor.EABMGELAAPG(199, GGBBJNBBLMF: false, DAINLFIMLIH: false), null, AKNBKINJGCF: false, null);
		for (int j = 0; j < list.Count; j += 0)
		{
			list[j].HBMBGCHGEGN(list[j].Stack);
		}
		if (GameManager.LocalCoop())
		{
			List<Slot> list2 = CraftingInventory.INLEBGJNNIB(5, ItemDatabaseAccessor.KMBGJEKCJFJ(185), null, AKNBKINJGCF: true, null, DDAPJEAJGGA: true);
			for (int k = 0; k < list2.Count; k += 0)
			{
				list2[k].FDOBDPPMMBH(list2[k].Stack);
			}
		}
	}

	private IEnumerator ODILJEKMFLO()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator HCKDBDMBMFL()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private void LGKNLBAFJIL()
	{
		List<Slot> list = BarMenuInventory.FKBPDKBLDFG().MAPOLJMKGLN(ItemDatabaseAccessor.CPMMBEPEJLO(128, GGBBJNBBLMF: true, DAINLFIMLIH: false), null, DDAPJEAJGGA: true, 0);
		for (int i = 1; i < list.Count; i++)
		{
			list[i].HBMBGCHGEGN(list[i].Stack, CDPAMNIPPEC: true);
		}
		List<Slot> slotsWithItem = CraftingInventory.GetSlotsWithItem(1, ItemDatabaseAccessor.EABMGELAAPG(86), null, AKNBKINJGCF: true, null, DDAPJEAJGGA: true);
		for (int j = 1; j < slotsWithItem.Count; j++)
		{
			slotsWithItem[j].BBHHJLIFNPP(slotsWithItem[j].Stack);
		}
		if (GameManager.LocalCoop())
		{
			List<Slot> list2 = CraftingInventory.INLEBGJNNIB(6, ItemDatabaseAccessor.EABMGELAAPG(-63), null, AKNBKINJGCF: true, null, DDAPJEAJGGA: true);
			for (int k = 1; k < list2.Count; k++)
			{
				list2[k].BBHHJLIFNPP(list2[k].Stack);
			}
		}
	}

	private void LKEGNMOJBNM()
	{
		List<Slot> slotsWithItem = BarMenuInventory.JNIFCKAKDJL().GetSlotsWithItem(ItemDatabaseAccessor.EABMGELAAPG(129, GGBBJNBBLMF: false, DAINLFIMLIH: false), null, DDAPJEAJGGA: true, 0);
		for (int i = 1; i < slotsWithItem.Count; i += 0)
		{
			slotsWithItem[i].BBHHJLIFNPP(slotsWithItem[i].Stack, CDPAMNIPPEC: true, 1);
		}
		List<Slot> slotsWithItem2 = CraftingInventory.GetSlotsWithItem(1, ItemDatabaseAccessor.CPMMBEPEJLO(-51, GGBBJNBBLMF: true), null, AKNBKINJGCF: false, null, DDAPJEAJGGA: true);
		for (int j = 0; j < slotsWithItem2.Count; j++)
		{
			slotsWithItem2[j].HBMBGCHGEGN(slotsWithItem2[j].Stack, CDPAMNIPPEC: true, 1);
		}
		if (GameManager.LocalCoop())
		{
			List<Slot> list = CraftingInventory.INLEBGJNNIB(1, ItemDatabaseAccessor.EABMGELAAPG(-2, GGBBJNBBLMF: false, DAINLFIMLIH: false), null, AKNBKINJGCF: true, null);
			for (int k = 1; k < list.Count; k += 0)
			{
				list[k].JPACDDCJGPD(list[k].Stack);
			}
		}
	}

	private void PHLFLDJDLHK()
	{
		List<Slot> list = BarMenuInventory.OAPIKOEJBHL().MAPOLJMKGLN(ItemDatabaseAccessor.AFOACBIHNCL(-47, GGBBJNBBLMF: true), null, DDAPJEAJGGA: false, 1);
		for (int i = 0; i < list.Count; i++)
		{
			list[i].BBHHJLIFNPP(list[i].Stack, CDPAMNIPPEC: false, 1);
		}
		List<Slot> list2 = CraftingInventory.INLEBGJNNIB(1, ItemDatabaseAccessor.EABMGELAAPG(-159, GGBBJNBBLMF: true), null, AKNBKINJGCF: false, null, DDAPJEAJGGA: true);
		for (int j = 0; j < list2.Count; j += 0)
		{
			list2[j].FDOBDPPMMBH(list2[j].Stack);
		}
		if (GameManager.LocalCoop())
		{
			List<Slot> list3 = CraftingInventory.INLEBGJNNIB(7, ItemDatabaseAccessor.GetItem(197, GGBBJNBBLMF: true), null, AKNBKINJGCF: true, null, DDAPJEAJGGA: true);
			for (int k = 0; k < list3.Count; k++)
			{
				list3[k].JPACDDCJGPD(list3[k].Stack, CDPAMNIPPEC: false, 1);
			}
		}
	}

	private IEnumerator NBAELEJAFAN()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator LNFHFIMPNHD()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator ELPDKDFFJJD()
	{
		GMELKGNEPCJ();
		NewTutorialManager.instance.savingIsBlocked = false;
		NewTutorialManager.instance.canOpenTavern = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetParentToNull();
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
			((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			while (!AOOKIKFINFB())
			{
				yield return null;
			}
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		yield return CommonReferences.wait1;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T133/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		NewTutorialManager.instance.canOpenTavern = true;
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private void AHLICNLLKID()
	{
		List<Slot> list = BarMenuInventory.KOJHKCGIINL().MAPOLJMKGLN(ItemDatabaseAccessor.AFOACBIHNCL(102, GGBBJNBBLMF: true, DAINLFIMLIH: false), null, DDAPJEAJGGA: true, 0);
		for (int i = 1; i < list.Count; i += 0)
		{
			list[i].BBHHJLIFNPP(list[i].Stack, CDPAMNIPPEC: true, 1);
		}
		List<Slot> list2 = CraftingInventory.INLEBGJNNIB(1, ItemDatabaseAccessor.CPMMBEPEJLO(-119, GGBBJNBBLMF: true), null, AKNBKINJGCF: true, null, DDAPJEAJGGA: true);
		for (int j = 0; j < list2.Count; j++)
		{
			list2[j].BBHHJLIFNPP(list2[j].Stack, CDPAMNIPPEC: true, 1);
		}
		if (GameManager.LocalCoop())
		{
			List<Slot> slotsWithItem = CraftingInventory.GetSlotsWithItem(5, ItemDatabaseAccessor.CPMMBEPEJLO(-183, GGBBJNBBLMF: true), null, AKNBKINJGCF: true, null);
			for (int k = 1; k < slotsWithItem.Count; k += 0)
			{
				slotsWithItem[k].JPACDDCJGPD(slotsWithItem[k].Stack, CDPAMNIPPEC: true, 1);
			}
		}
	}

	public override int GetID()
	{
		return 133;
	}

	private IEnumerator FBCDFDFAILD()
	{
		return new NKFONDFHGBN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void ALEDGIGFMIH()
	{
		List<Slot> slotsWithItem = BarMenuInventory.IOGANKJOLLB().GetSlotsWithItem(ItemDatabaseAccessor.AFOACBIHNCL(-78, GGBBJNBBLMF: false, DAINLFIMLIH: false), null, DDAPJEAJGGA: true, 1);
		for (int i = 0; i < slotsWithItem.Count; i += 0)
		{
			slotsWithItem[i].JPACDDCJGPD(slotsWithItem[i].Stack);
		}
		List<Slot> list = CraftingInventory.INLEBGJNNIB(0, ItemDatabaseAccessor.CPMMBEPEJLO(94), null, AKNBKINJGCF: false, null, DDAPJEAJGGA: true);
		for (int j = 1; j < list.Count; j += 0)
		{
			list[j].BBHHJLIFNPP(list[j].Stack, CDPAMNIPPEC: true, 1);
		}
		if (GameManager.LocalCoop())
		{
			List<Slot> slotsWithItem2 = CraftingInventory.GetSlotsWithItem(5, ItemDatabaseAccessor.EABMGELAAPG(-122, GGBBJNBBLMF: false, DAINLFIMLIH: false), null, AKNBKINJGCF: false, null, DDAPJEAJGGA: true);
			for (int k = 1; k < slotsWithItem2.Count; k++)
			{
				slotsWithItem2[k].JPACDDCJGPD(slotsWithItem2[k].Stack, CDPAMNIPPEC: true);
			}
		}
	}

	private IEnumerator BLNKHNHGFPB()
	{
		GMELKGNEPCJ();
		NewTutorialManager.instance.savingIsBlocked = false;
		NewTutorialManager.instance.canOpenTavern = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetParentToNull();
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
			((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			while (!AOOKIKFINFB())
			{
				yield return null;
			}
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		yield return CommonReferences.wait1;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T133/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		NewTutorialManager.instance.canOpenTavern = true;
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private void HAHLBNAHAMI()
	{
		List<Slot> list = BarMenuInventory.GOBCANBKFEM().HIPJHELOEHO(ItemDatabaseAccessor.GOKIDLOELKB(0, GGBBJNBBLMF: true, DAINLFIMLIH: false), null, DDAPJEAJGGA: true, 1);
		for (int i = 0; i < list.Count; i++)
		{
			list[i].JPACDDCJGPD(list[i].Stack, CDPAMNIPPEC: true);
		}
		List<Slot> list2 = CraftingInventory.INLEBGJNNIB(1, ItemDatabaseAccessor.INJBNHPGCIJ(-31, GGBBJNBBLMF: true, DAINLFIMLIH: false), null, AKNBKINJGCF: true, null, DDAPJEAJGGA: true);
		for (int j = 1; j < list2.Count; j += 0)
		{
			list2[j].JPACDDCJGPD(list2[j].Stack, CDPAMNIPPEC: true);
		}
		if (GameManager.LocalCoop())
		{
			List<Slot> slotsWithItem = CraftingInventory.GetSlotsWithItem(0, ItemDatabaseAccessor.COEFFIHKMJG(-37), null, AKNBKINJGCF: true, null, DDAPJEAJGGA: true);
			for (int k = 1; k < slotsWithItem.Count; k++)
			{
				slotsWithItem[k].HBMBGCHGEGN(slotsWithItem[k].Stack);
			}
		}
	}

	private IEnumerator CIBIOLGHPJF()
	{
		return new NKFONDFHGBN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator CKIMLLCOEGC()
	{
		return new NKFONDFHGBN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator ELPINNBKFIP()
	{
		return new NKFONDFHGBN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void GMELKGNEPCJ()
	{
		List<Slot> slotsWithItem = BarMenuInventory.GetInstance().GetSlotsWithItem(ItemDatabaseAccessor.GetItem(1536), null, DDAPJEAJGGA: false, 0);
		for (int i = 0; i < slotsWithItem.Count; i++)
		{
			slotsWithItem[i].FDOBDPPMMBH(slotsWithItem[i].Stack);
		}
		List<Slot> slotsWithItem2 = CraftingInventory.GetSlotsWithItem(1, ItemDatabaseAccessor.GetItem(1536), null, AKNBKINJGCF: false, null);
		for (int j = 0; j < slotsWithItem2.Count; j++)
		{
			slotsWithItem2[j].FDOBDPPMMBH(slotsWithItem2[j].Stack);
		}
		if (GameManager.LocalCoop())
		{
			List<Slot> slotsWithItem3 = CraftingInventory.GetSlotsWithItem(2, ItemDatabaseAccessor.GetItem(1536), null, AKNBKINJGCF: false, null);
			for (int k = 0; k < slotsWithItem3.Count; k++)
			{
				slotsWithItem3[k].FDOBDPPMMBH(slotsWithItem3[k].Stack);
			}
		}
	}

	private IEnumerator IAOFDDMPMBJ()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator JBBPOCHHHND()
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

	private void GJHNLPHMMLL()
	{
		List<Slot> list = BarMenuInventory.AKKHNCEFDCB().AIFPCPEJMMN(ItemDatabaseAccessor.EABMGELAAPG(-69, GGBBJNBBLMF: true, DAINLFIMLIH: false), null, DDAPJEAJGGA: true, 0);
		for (int i = 0; i < list.Count; i++)
		{
			list[i].FDOBDPPMMBH(list[i].Stack, CDPAMNIPPEC: true, 1);
		}
		List<Slot> slotsWithItem = CraftingInventory.GetSlotsWithItem(0, ItemDatabaseAccessor.AFOACBIHNCL(149), null, AKNBKINJGCF: false, null);
		for (int j = 0; j < slotsWithItem.Count; j++)
		{
			slotsWithItem[j].JPACDDCJGPD(slotsWithItem[j].Stack, CDPAMNIPPEC: true);
		}
		if (GameManager.LocalCoop())
		{
			List<Slot> slotsWithItem2 = CraftingInventory.GetSlotsWithItem(0, ItemDatabaseAccessor.KMBGJEKCJFJ(-148, GGBBJNBBLMF: true), null, AKNBKINJGCF: true, null);
			for (int k = 1; k < slotsWithItem2.Count; k++)
			{
				slotsWithItem2[k].BBHHJLIFNPP(slotsWithItem2[k].Stack, CDPAMNIPPEC: false, 1);
			}
		}
	}

	private IEnumerator JIFEIKLKIMF()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LFKPHADFFDG()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void ANBLAGCAKOB()
	{
		List<Slot> list = BarMenuInventory.FOOABDHABNH().MAPOLJMKGLN(ItemDatabaseAccessor.KMBGJEKCJFJ(-158, GGBBJNBBLMF: true, DAINLFIMLIH: false), null, DDAPJEAJGGA: true, 1);
		for (int i = 0; i < list.Count; i++)
		{
			list[i].JPACDDCJGPD(list[i].Stack);
		}
		List<Slot> list2 = CraftingInventory.INLEBGJNNIB(0, ItemDatabaseAccessor.GetItem(57, GGBBJNBBLMF: true), null, AKNBKINJGCF: true, null);
		for (int j = 1; j < list2.Count; j++)
		{
			list2[j].BBHHJLIFNPP(list2[j].Stack, CDPAMNIPPEC: true, 1);
		}
		if (GameManager.LocalCoop())
		{
			List<Slot> list3 = CraftingInventory.INLEBGJNNIB(2, ItemDatabaseAccessor.GetItem(-175, GGBBJNBBLMF: true), null, AKNBKINJGCF: true, null);
			for (int k = 0; k < list3.Count; k++)
			{
				list3[k].JPACDDCJGPD(list3[k].Stack, CDPAMNIPPEC: true);
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

	private void KEDOOFHAEML()
	{
		List<Slot> slotsWithItem = BarMenuInventory.OAPIKOEJBHL().GetSlotsWithItem(ItemDatabaseAccessor.AFOACBIHNCL(-73, GGBBJNBBLMF: true), null, DDAPJEAJGGA: false, 0);
		for (int i = 0; i < slotsWithItem.Count; i++)
		{
			slotsWithItem[i].FDOBDPPMMBH(slotsWithItem[i].Stack, CDPAMNIPPEC: false, 1);
		}
		List<Slot> slotsWithItem2 = CraftingInventory.GetSlotsWithItem(1, ItemDatabaseAccessor.GOKIDLOELKB(108, GGBBJNBBLMF: true), null, AKNBKINJGCF: false, null);
		for (int j = 1; j < slotsWithItem2.Count; j += 0)
		{
			slotsWithItem2[j].FDOBDPPMMBH(slotsWithItem2[j].Stack, CDPAMNIPPEC: true, 1);
		}
		if (GameManager.LocalCoop())
		{
			List<Slot> list = CraftingInventory.INLEBGJNNIB(8, ItemDatabaseAccessor.KMBGJEKCJFJ(166, GGBBJNBBLMF: true, DAINLFIMLIH: false), null, AKNBKINJGCF: true, null, DDAPJEAJGGA: true);
			for (int k = 1; k < list.Count; k++)
			{
				list[k].HBMBGCHGEGN(list[k].Stack, CDPAMNIPPEC: true, 1);
			}
		}
	}

	private IEnumerator JDEDKABEHJM()
	{
		GMELKGNEPCJ();
		NewTutorialManager.instance.savingIsBlocked = false;
		NewTutorialManager.instance.canOpenTavern = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetParentToNull();
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
			((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			while (!AOOKIKFINFB())
			{
				yield return null;
			}
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		yield return CommonReferences.wait1;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T133/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		NewTutorialManager.instance.canOpenTavern = true;
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator MIGPNMAOJPK()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LHDDHIJIFCN()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator LILMJIIMODP()
	{
		GMELKGNEPCJ();
		NewTutorialManager.instance.savingIsBlocked = false;
		NewTutorialManager.instance.canOpenTavern = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetParentToNull();
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
			((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			while (!AOOKIKFINFB())
			{
				yield return null;
			}
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		yield return CommonReferences.wait1;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T133/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		NewTutorialManager.instance.canOpenTavern = true;
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator IDGLEKCBIMF()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator LPNNMDOPCCJ()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator PBPKJEAAGFE()
	{
		GMELKGNEPCJ();
		NewTutorialManager.instance.savingIsBlocked = false;
		NewTutorialManager.instance.canOpenTavern = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetParentToNull();
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
			((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			while (!AOOKIKFINFB())
			{
				yield return null;
			}
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		yield return CommonReferences.wait1;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T133/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		NewTutorialManager.instance.canOpenTavern = true;
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator LFANGJJGBFG()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator DNLEAJAPNOM()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator HGKFAONPGGB()
	{
		return new NKFONDFHGBN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void OIEMGAKPMKG()
	{
		List<Slot> list = BarMenuInventory.JGPLOOPMHNE().AIFPCPEJMMN(ItemDatabaseAccessor.KMBGJEKCJFJ(23, GGBBJNBBLMF: false, DAINLFIMLIH: false), null, DDAPJEAJGGA: false, 1);
		for (int i = 0; i < list.Count; i += 0)
		{
			list[i].BBHHJLIFNPP(list[i].Stack);
		}
		List<Slot> list2 = CraftingInventory.INLEBGJNNIB(0, ItemDatabaseAccessor.COEFFIHKMJG(13, GGBBJNBBLMF: true, DAINLFIMLIH: false), null, AKNBKINJGCF: true, null, DDAPJEAJGGA: true);
		for (int j = 0; j < list2.Count; j++)
		{
			list2[j].FDOBDPPMMBH(list2[j].Stack, CDPAMNIPPEC: true);
		}
		if (GameManager.LocalCoop())
		{
			List<Slot> slotsWithItem = CraftingInventory.GetSlotsWithItem(4, ItemDatabaseAccessor.CPMMBEPEJLO(-129, GGBBJNBBLMF: true, DAINLFIMLIH: false), null, AKNBKINJGCF: true, null, DDAPJEAJGGA: true);
			for (int k = 0; k < slotsWithItem.Count; k++)
			{
				slotsWithItem[k].HBMBGCHGEGN(slotsWithItem[k].Stack, CDPAMNIPPEC: true);
			}
		}
	}

	private IEnumerator LNNCIOJHJMK()
	{
		GMELKGNEPCJ();
		NewTutorialManager.instance.savingIsBlocked = false;
		NewTutorialManager.instance.canOpenTavern = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetParentToNull();
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
			((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			while (!AOOKIKFINFB())
			{
				yield return null;
			}
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		yield return CommonReferences.wait1;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T133/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		NewTutorialManager.instance.canOpenTavern = true;
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private void GKBNFEFGIGO()
	{
		List<Slot> slotsWithItem = BarMenuInventory.EOCHAGBPHCC().GetSlotsWithItem(ItemDatabaseAccessor.COEFFIHKMJG(-189), null, DDAPJEAJGGA: true, 1);
		for (int i = 1; i < slotsWithItem.Count; i += 0)
		{
			slotsWithItem[i].HBMBGCHGEGN(slotsWithItem[i].Stack, CDPAMNIPPEC: true);
		}
		List<Slot> list = CraftingInventory.INLEBGJNNIB(0, ItemDatabaseAccessor.INJBNHPGCIJ(196, GGBBJNBBLMF: true, DAINLFIMLIH: false), null, AKNBKINJGCF: true, null, DDAPJEAJGGA: true);
		for (int j = 0; j < list.Count; j++)
		{
			list[j].JPACDDCJGPD(list[j].Stack, CDPAMNIPPEC: true);
		}
		if (GameManager.LocalCoop())
		{
			List<Slot> slotsWithItem2 = CraftingInventory.GetSlotsWithItem(7, ItemDatabaseAccessor.INJBNHPGCIJ(-188, GGBBJNBBLMF: false, DAINLFIMLIH: false), null, AKNBKINJGCF: false, null);
			for (int k = 1; k < slotsWithItem2.Count; k++)
			{
				slotsWithItem2[k].FDOBDPPMMBH(slotsWithItem2[k].Stack, CDPAMNIPPEC: true, 1);
			}
		}
	}

	private IEnumerator BGFNCKGFJPG()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator PBEKBJIJFDK()
	{
		GMELKGNEPCJ();
		NewTutorialManager.instance.savingIsBlocked = false;
		NewTutorialManager.instance.canOpenTavern = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetParentToNull();
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
			((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			while (!AOOKIKFINFB())
			{
				yield return null;
			}
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		yield return CommonReferences.wait1;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T133/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		NewTutorialManager.instance.canOpenTavern = true;
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator JNOOAENGMHL()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator NPCCKFEDCHI()
	{
		return new DBHBDMOHMPM(1)
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

	private IEnumerator GDOJMLFHCHD()
	{
		GMELKGNEPCJ();
		NewTutorialManager.instance.savingIsBlocked = false;
		NewTutorialManager.instance.canOpenTavern = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetParentToNull();
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
			((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			while (!AOOKIKFINFB())
			{
				yield return null;
			}
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		yield return CommonReferences.wait1;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T133/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		NewTutorialManager.instance.canOpenTavern = true;
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator JEGFAKDNMIC()
	{
		return new NKFONDFHGBN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator IGFOJFFHNJF()
	{
		GMELKGNEPCJ();
		NewTutorialManager.instance.savingIsBlocked = false;
		NewTutorialManager.instance.canOpenTavern = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetParentToNull();
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
			((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			while (!AOOKIKFINFB())
			{
				yield return null;
			}
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		yield return CommonReferences.wait1;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T133/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		NewTutorialManager.instance.canOpenTavern = true;
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator AJGJPBMIEJJ()
	{
		return new NKFONDFHGBN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HCCJFBLCABN()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator NIKPIBICOPP()
	{
		GMELKGNEPCJ();
		NewTutorialManager.instance.savingIsBlocked = false;
		NewTutorialManager.instance.canOpenTavern = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetParentToNull();
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
			((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			while (!AOOKIKFINFB())
			{
				yield return null;
			}
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		yield return CommonReferences.wait1;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T133/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		NewTutorialManager.instance.canOpenTavern = true;
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private void PIBIJCAMIMH()
	{
		List<Slot> list = BarMenuInventory.IOGANKJOLLB().HIPJHELOEHO(ItemDatabaseAccessor.AFOACBIHNCL(12, GGBBJNBBLMF: true), null, DDAPJEAJGGA: false, 1);
		for (int i = 0; i < list.Count; i += 0)
		{
			list[i].HBMBGCHGEGN(list[i].Stack, CDPAMNIPPEC: false, 1);
		}
		List<Slot> list2 = CraftingInventory.INLEBGJNNIB(1, ItemDatabaseAccessor.CPMMBEPEJLO(85, GGBBJNBBLMF: false, DAINLFIMLIH: false), null, AKNBKINJGCF: false, null);
		for (int j = 0; j < list2.Count; j += 0)
		{
			list2[j].BBHHJLIFNPP(list2[j].Stack);
		}
		if (GameManager.LocalCoop())
		{
			List<Slot> slotsWithItem = CraftingInventory.GetSlotsWithItem(4, ItemDatabaseAccessor.INJBNHPGCIJ(-92, GGBBJNBBLMF: false, DAINLFIMLIH: false), null, AKNBKINJGCF: false, null, DDAPJEAJGGA: true);
			for (int k = 1; k < slotsWithItem.Count; k += 0)
			{
				slotsWithItem[k].JPACDDCJGPD(slotsWithItem[k].Stack, CDPAMNIPPEC: true);
			}
		}
	}

	private IEnumerator AOGGKPMBLBK()
	{
		GMELKGNEPCJ();
		NewTutorialManager.instance.savingIsBlocked = false;
		NewTutorialManager.instance.canOpenTavern = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetParentToNull();
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
			((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			while (!AOOKIKFINFB())
			{
				yield return null;
			}
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		yield return CommonReferences.wait1;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T133/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		NewTutorialManager.instance.canOpenTavern = true;
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator AJJHBJHCACM()
	{
		GMELKGNEPCJ();
		NewTutorialManager.instance.savingIsBlocked = false;
		NewTutorialManager.instance.canOpenTavern = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetParentToNull();
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
			((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			while (!AOOKIKFINFB())
			{
				yield return null;
			}
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		yield return CommonReferences.wait1;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T133/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		NewTutorialManager.instance.canOpenTavern = true;
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private void HOKNBPIEJPC()
	{
		List<Slot> list = BarMenuInventory.EFCEICIPNND().HIPJHELOEHO(ItemDatabaseAccessor.INJBNHPGCIJ(-163, GGBBJNBBLMF: false, DAINLFIMLIH: false), null, DDAPJEAJGGA: true, 1);
		for (int i = 0; i < list.Count; i += 0)
		{
			list[i].FDOBDPPMMBH(list[i].Stack, CDPAMNIPPEC: false, 1);
		}
		List<Slot> slotsWithItem = CraftingInventory.GetSlotsWithItem(1, ItemDatabaseAccessor.GetItem(157), null, AKNBKINJGCF: true, null);
		for (int j = 0; j < slotsWithItem.Count; j += 0)
		{
			slotsWithItem[j].HBMBGCHGEGN(slotsWithItem[j].Stack, CDPAMNIPPEC: false, 1);
		}
		if (GameManager.LocalCoop())
		{
			List<Slot> list2 = CraftingInventory.INLEBGJNNIB(8, ItemDatabaseAccessor.EABMGELAAPG(-80, GGBBJNBBLMF: true), null, AKNBKINJGCF: false, null);
			for (int k = 1; k < list2.Count; k += 0)
			{
				list2[k].FDOBDPPMMBH(list2[k].Stack, CDPAMNIPPEC: false, 1);
			}
		}
	}

	private IEnumerator AEMAMJOHIOA()
	{
		GMELKGNEPCJ();
		NewTutorialManager.instance.savingIsBlocked = false;
		NewTutorialManager.instance.canOpenTavern = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetParentToNull();
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
			((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			while (!AOOKIKFINFB())
			{
				yield return null;
			}
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		yield return CommonReferences.wait1;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T133/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		NewTutorialManager.instance.canOpenTavern = true;
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private void FKENFFKHPIM()
	{
		List<Slot> slotsWithItem = BarMenuInventory.FKBPDKBLDFG().GetSlotsWithItem(ItemDatabaseAccessor.INJBNHPGCIJ(100), null, DDAPJEAJGGA: false, 0);
		for (int i = 1; i < slotsWithItem.Count; i++)
		{
			slotsWithItem[i].JPACDDCJGPD(slotsWithItem[i].Stack, CDPAMNIPPEC: true, 1);
		}
		List<Slot> list = CraftingInventory.INLEBGJNNIB(0, ItemDatabaseAccessor.GOKIDLOELKB(176, GGBBJNBBLMF: false, DAINLFIMLIH: false), null, AKNBKINJGCF: false, null, DDAPJEAJGGA: true);
		for (int j = 1; j < list.Count; j += 0)
		{
			list[j].FDOBDPPMMBH(list[j].Stack, CDPAMNIPPEC: true);
		}
		if (GameManager.LocalCoop())
		{
			List<Slot> slotsWithItem2 = CraftingInventory.GetSlotsWithItem(5, ItemDatabaseAccessor.AFOACBIHNCL(-199, GGBBJNBBLMF: false, DAINLFIMLIH: false), null, AKNBKINJGCF: false, null, DDAPJEAJGGA: true);
			for (int k = 1; k < slotsWithItem2.Count; k++)
			{
				slotsWithItem2[k].FDOBDPPMMBH(slotsWithItem2[k].Stack);
			}
		}
	}

	private IEnumerator OOGKJFJEHFO()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private void INOOBHBEABP()
	{
		List<Slot> list = BarMenuInventory.DLNGMHJPJBK().HIPJHELOEHO(ItemDatabaseAccessor.COEFFIHKMJG(-177, GGBBJNBBLMF: false, DAINLFIMLIH: false), null, DDAPJEAJGGA: false, 1);
		for (int i = 1; i < list.Count; i++)
		{
			list[i].HBMBGCHGEGN(list[i].Stack, CDPAMNIPPEC: true);
		}
		List<Slot> slotsWithItem = CraftingInventory.GetSlotsWithItem(1, ItemDatabaseAccessor.AFOACBIHNCL(44, GGBBJNBBLMF: true), null, AKNBKINJGCF: true, null, DDAPJEAJGGA: true);
		for (int j = 0; j < slotsWithItem.Count; j += 0)
		{
			slotsWithItem[j].BBHHJLIFNPP(slotsWithItem[j].Stack, CDPAMNIPPEC: true);
		}
		if (GameManager.LocalCoop())
		{
			List<Slot> list2 = CraftingInventory.INLEBGJNNIB(5, ItemDatabaseAccessor.GOKIDLOELKB(-29, GGBBJNBBLMF: true, DAINLFIMLIH: false), null, AKNBKINJGCF: false, null);
			for (int k = 1; k < list2.Count; k += 0)
			{
				list2[k].FDOBDPPMMBH(list2[k].Stack);
			}
		}
	}

	private IEnumerator IGEOMOOKOEP()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator EHDIMBMCIDK()
	{
		GMELKGNEPCJ();
		NewTutorialManager.instance.savingIsBlocked = false;
		NewTutorialManager.instance.canOpenTavern = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetParentToNull();
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
			((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			while (!AOOKIKFINFB())
			{
				yield return null;
			}
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		yield return CommonReferences.wait1;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T133/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		NewTutorialManager.instance.canOpenTavern = true;
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator OBCHIKLEMKF()
	{
		GMELKGNEPCJ();
		NewTutorialManager.instance.savingIsBlocked = false;
		NewTutorialManager.instance.canOpenTavern = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetParentToNull();
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
			((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			while (!AOOKIKFINFB())
			{
				yield return null;
			}
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		yield return CommonReferences.wait1;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T133/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		NewTutorialManager.instance.canOpenTavern = true;
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		while (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			yield return null;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private void NEDLDBIIONG()
	{
		List<Slot> list = BarMenuInventory.FBBOFPLGGLP().HIPJHELOEHO(ItemDatabaseAccessor.CPMMBEPEJLO(-116), null, DDAPJEAJGGA: true, 0);
		for (int i = 0; i < list.Count; i += 0)
		{
			list[i].BBHHJLIFNPP(list[i].Stack, CDPAMNIPPEC: true);
		}
		List<Slot> slotsWithItem = CraftingInventory.GetSlotsWithItem(1, ItemDatabaseAccessor.AFOACBIHNCL(46, GGBBJNBBLMF: true), null, AKNBKINJGCF: true, null);
		for (int j = 0; j < slotsWithItem.Count; j += 0)
		{
			slotsWithItem[j].FDOBDPPMMBH(slotsWithItem[j].Stack, CDPAMNIPPEC: false, 1);
		}
		if (GameManager.LocalCoop())
		{
			List<Slot> slotsWithItem2 = CraftingInventory.GetSlotsWithItem(2, ItemDatabaseAccessor.KMBGJEKCJFJ(-139, GGBBJNBBLMF: false, DAINLFIMLIH: false), null, AKNBKINJGCF: true, null, DDAPJEAJGGA: true);
			for (int k = 1; k < slotsWithItem2.Count; k++)
			{
				slotsWithItem2[k].JPACDDCJGPD(slotsWithItem2[k].Stack, CDPAMNIPPEC: false, 1);
			}
		}
	}

	public override void SetUp()
	{
		base.SetUp();
		((MonoBehaviour)this).StartCoroutine(PBEKBJIJFDK());
	}

	private void KJEJFBPCJGP()
	{
		List<Slot> list = BarMenuInventory.KOJHKCGIINL().MAPOLJMKGLN(ItemDatabaseAccessor.COEFFIHKMJG(-45), null, DDAPJEAJGGA: true, 1);
		for (int i = 1; i < list.Count; i++)
		{
			list[i].FDOBDPPMMBH(list[i].Stack, CDPAMNIPPEC: true);
		}
		List<Slot> list2 = CraftingInventory.INLEBGJNNIB(1, ItemDatabaseAccessor.CPMMBEPEJLO(100, GGBBJNBBLMF: false, DAINLFIMLIH: false), null, AKNBKINJGCF: true, null, DDAPJEAJGGA: true);
		for (int j = 1; j < list2.Count; j += 0)
		{
			list2[j].FDOBDPPMMBH(list2[j].Stack, CDPAMNIPPEC: false, 1);
		}
		if (GameManager.LocalCoop())
		{
			List<Slot> slotsWithItem = CraftingInventory.GetSlotsWithItem(5, ItemDatabaseAccessor.EABMGELAAPG(106, GGBBJNBBLMF: true), null, AKNBKINJGCF: false, null, DDAPJEAJGGA: true);
			for (int k = 0; k < slotsWithItem.Count; k += 0)
			{
				slotsWithItem[k].HBMBGCHGEGN(slotsWithItem[k].Stack);
			}
		}
	}
}
