using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class T108_PrimerPlato : TutorialPhaseBase
{
	[CompilerGenerated]
	private sealed class ILGBEHOLOGL : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T108_PrimerPlato _003C_003E4__this;

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
			T108_PrimerPlato t108_PrimerPlato = _003C_003E4__this;
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
				t108_PrimerPlato.LHKIJABBBPM();
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

		public T108_PrimerPlato _003C_003E4__this;

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
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_014c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0151: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01da: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			T108_PrimerPlato t108_PrimerPlato = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
				((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
				((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
				_003C_003E2__current = CommonReferences.wait02;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
				MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
				goto IL_00dd;
			case 2:
				_003C_003E1__state = -1;
				goto IL_00dd;
			case 3:
				_003C_003E1__state = -1;
				NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 4;
				return true;
			case 4:
				_003C_003E1__state = -1;
				DialogueCameraTarget.GetPlayer(t108_PrimerPlato.triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
				MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T108/Dialogue1", t108_PrimerPlato.triggerPlayerNum);
				goto IL_018c;
			case 5:
				_003C_003E1__state = -1;
				goto IL_018c;
			case 6:
				{
					_003C_003E1__state = -1;
					NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
					NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
					NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)BarMenuManager.instance).transform.position), Vector2.up * 0.1f, ref t108_PrimerPlato.JELIKOFDONK);
					CommonReferences instance = CommonReferences.GGFJGHHHEJC;
					instance.OnBarStockChanged = (Action)Delegate.Combine(instance.OnBarStockChanged, new Action(t108_PrimerPlato.DPIFOKCMOIC));
					return false;
				}
				IL_018c:
				if (t108_PrimerPlato.AAOPIEDAKKD(1))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 5;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 6;
				return true;
				IL_00dd:
				if (!t108_PrimerPlato.AOOKIKFINFB())
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 2;
					return true;
				}
				MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
				_003C_003E2__current = ((MonoBehaviour)t108_PrimerPlato).StartCoroutine(t108_PrimerPlato.CDICFNAMCEE());
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

	private IEnumerator AKMGPONCFHL()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void JLKAAJKJHNE()
	{
		if (BarMenuInventory.EGJFDPIEHEC().FKMFFABKJMB(ItemDatabaseAccessor.GetItem(183, GGBBJNBBLMF: false, DAINLFIMLIH: false)))
		{
			NewTutorialManager.instance.ObjectiveCompleted(0);
			((MonoBehaviour)this).StartCoroutine(LFANGJJGBFG());
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnBarStockChanged = (Action)Delegate.Remove(instance.OnBarStockChanged, new Action(AJDKJBHKEJN));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private IEnumerator DNLEAJAPNOM()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator PDAEFKAMACE()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void HBOOBFFDALE()
	{
		if (BarMenuInventory.DCEBHEAHHID().MMDOFEBHGMA(ItemDatabaseAccessor.GetItem(-152)))
		{
			NewTutorialManager.instance.ObjectiveCompleted(1);
			((MonoBehaviour)this).StartCoroutine(HCCJFBLCABN());
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnBarStockChanged = (Action)Delegate.Remove(instance.OnBarStockChanged, new Action(CICDFJKNMON));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private IEnumerator HPNEFMANGHJ()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator IHBNOLLFNPA()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
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
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait05;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T108/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)BarMenuManager.instance).transform.position), Vector2.up * 0.1f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnBarStockChanged = (Action)Delegate.Combine(instance.OnBarStockChanged, new Action(DPIFOKCMOIC));
	}

	private void ILLLLGCCMJJ()
	{
		if (BarMenuInventory.EFCEICIPNND().HMIDIPBNEGC(ItemDatabaseAccessor.KMBGJEKCJFJ(-98, GGBBJNBBLMF: false, DAINLFIMLIH: false)))
		{
			NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			((MonoBehaviour)this).StartCoroutine(OCHEOJEEFGA());
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnBarStockChanged = (Action)Delegate.Remove(commonReferences.OnBarStockChanged, new Action(NONFBBIPPCL));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private IEnumerator IAOFDDMPMBJ()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void IKCMEHNHLOE()
	{
		if (BarMenuInventory.GOBCANBKFEM().MMDOFEBHGMA(ItemDatabaseAccessor.CPMMBEPEJLO(-78, GGBBJNBBLMF: false, DAINLFIMLIH: false)))
		{
			NewTutorialManager.instance.FOIOHOGACAL(1);
			((MonoBehaviour)this).StartCoroutine(IAOFDDMPMBJ());
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnBarStockChanged = (Action)Delegate.Remove(instance.OnBarStockChanged, new Action(DPIFOKCMOIC));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private IEnumerator JDEDKABEHJM()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator PBEKBJIJFDK()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
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
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait05;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T108/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)BarMenuManager.instance).transform.position), Vector2.up * 0.1f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnBarStockChanged = (Action)Delegate.Combine(instance.OnBarStockChanged, new Action(DPIFOKCMOIC));
	}

	private void JACDAOJAKLO()
	{
		if (BarMenuInventory.FOOABDHABNH().HasItem(ItemDatabaseAccessor.KMBGJEKCJFJ(37, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
		{
			NewTutorialManager.instance.ObjectiveCompleted(1);
			((MonoBehaviour)this).StartCoroutine(DNLEAJAPNOM());
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnBarStockChanged = (Action)Delegate.Remove(instance.OnBarStockChanged, new Action(LOPHDDOAPLH));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private void LNBLCJOHFDI()
	{
		if (BarMenuInventory.CHPCJAHBJJF().HasItem(ItemDatabaseAccessor.GOKIDLOELKB(21, GGBBJNBBLMF: true)))
		{
			NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			((MonoBehaviour)this).StartCoroutine(BJPDFDCOJKJ());
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnBarStockChanged = (Action)Delegate.Remove(commonReferences.OnBarStockChanged, new Action(DNJMHDBOGOC));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private IEnumerator LGODBMNLILN()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private void CICDFJKNMON()
	{
		if (BarMenuInventory.DLNGMHJPJBK().HasItem(ItemDatabaseAccessor.INJBNHPGCIJ(117)))
		{
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			((MonoBehaviour)this).StartCoroutine(OOGKJFJEHFO());
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnBarStockChanged = (Action)Delegate.Remove(instance.OnBarStockChanged, new Action(CICDFJKNMON));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private IEnumerator JKFNHFDPOJN()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
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
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait05;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T108/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)BarMenuManager.instance).transform.position), Vector2.up * 0.1f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnBarStockChanged = (Action)Delegate.Combine(instance.OnBarStockChanged, new Action(DPIFOKCMOIC));
	}

	private IEnumerator CNPPMBAKEBJ()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private void NONFBBIPPCL()
	{
		if (BarMenuInventory.JLPGGCKFJAD().FKMFFABKJMB(ItemDatabaseAccessor.EABMGELAAPG(103)))
		{
			NewTutorialManager.instance.FOIOHOGACAL(0);
			((MonoBehaviour)this).StartCoroutine(IHGGOFFGMBD());
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnBarStockChanged = (Action)Delegate.Remove(instance.OnBarStockChanged, new Action(OGHFFDALDJK));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private IEnumerator DABNLFBDKGN()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator LHIPOAGIOJK()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
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
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait05;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T108/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)BarMenuManager.instance).transform.position), Vector2.up * 0.1f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnBarStockChanged = (Action)Delegate.Combine(instance.OnBarStockChanged, new Action(DPIFOKCMOIC));
	}

	public override int GetID()
	{
		return 108;
	}

	private void KAFCFLAJMKN()
	{
		if (BarMenuInventory.FKBPDKBLDFG().MMDOFEBHGMA(ItemDatabaseAccessor.EABMGELAAPG(-67)))
		{
			NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			((MonoBehaviour)this).StartCoroutine(OCHEOJEEFGA());
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnBarStockChanged = (Action)Delegate.Remove(commonReferences.OnBarStockChanged, new Action(MHOCCJMNGLC));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private IEnumerator JBBPOCHHHND()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
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
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait05;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T108/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)BarMenuManager.instance).transform.position), Vector2.up * 0.1f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnBarStockChanged = (Action)Delegate.Combine(instance.OnBarStockChanged, new Action(DPIFOKCMOIC));
	}

	private IEnumerator HHLKPNANHKK()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator LHDDHIJIFCN()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator LFANGJJGBFG()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private void DPIFOKCMOIC()
	{
		if (BarMenuInventory.GetInstance().HasItem(ItemDatabaseAccessor.GetItem(1536)))
		{
			NewTutorialManager.instance.ObjectiveCompleted(0);
			((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnBarStockChanged = (Action)Delegate.Remove(instance.OnBarStockChanged, new Action(DPIFOKCMOIC));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private void GEHDGCBDILI()
	{
		if (BarMenuInventory.CHPCJAHBJJF().HasItem(ItemDatabaseAccessor.KMBGJEKCJFJ(141, GGBBJNBBLMF: false, DAINLFIMLIH: false)))
		{
			NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			((MonoBehaviour)this).StartCoroutine(OCHEOJEEFGA());
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnBarStockChanged = (Action)Delegate.Remove(commonReferences.OnBarStockChanged, new Action(ABPKDFKACOJ));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private IEnumerator CNPIAJBODCG()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator FBHLJKDLPOB()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private void ABPKDFKACOJ()
	{
		if (BarMenuInventory.GOJHIEFPHDK().MMDOFEBHGMA(ItemDatabaseAccessor.CPMMBEPEJLO(-194)))
		{
			NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			((MonoBehaviour)this).StartCoroutine(CNPPMBAKEBJ());
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnBarStockChanged = (Action)Delegate.Remove(instance.OnBarStockChanged, new Action(LOPHDDOAPLH));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private IEnumerator MIGPNMAOJPK()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
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
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait05;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T108/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)BarMenuManager.instance).transform.position), Vector2.up * 0.1f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnBarStockChanged = (Action)Delegate.Combine(instance.OnBarStockChanged, new Action(DPIFOKCMOIC));
	}

	private void NHFICGNKLLB()
	{
		if (BarMenuInventory.LLJEGHHGOGC().FKMFFABKJMB(ItemDatabaseAccessor.KMBGJEKCJFJ(67, GGBBJNBBLMF: false, DAINLFIMLIH: false)))
		{
			NewTutorialManager.instance.ObjectiveCompleted(1);
			((MonoBehaviour)this).StartCoroutine(HCKDBDMBMFL());
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnBarStockChanged = (Action)Delegate.Remove(commonReferences.OnBarStockChanged, new Action(DPIFOKCMOIC));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private IEnumerator NPCCKFEDCHI()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator ELPDKDFFJJD()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
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
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait05;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T108/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)BarMenuManager.instance).transform.position), Vector2.up * 0.1f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnBarStockChanged = (Action)Delegate.Combine(instance.OnBarStockChanged, new Action(DPIFOKCMOIC));
	}

	private IEnumerator BAGKLMIFNIH()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator BJPDFDCOJKJ()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HFMMNGELPGN()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
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
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait05;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T108/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)BarMenuManager.instance).transform.position), Vector2.up * 0.1f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnBarStockChanged = (Action)Delegate.Combine(instance.OnBarStockChanged, new Action(DPIFOKCMOIC));
	}

	private IEnumerator JAHNJFGKFII()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HHDLDPPCLPE()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
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
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait05;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T108/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)BarMenuManager.instance).transform.position), Vector2.up * 0.1f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnBarStockChanged = (Action)Delegate.Combine(instance.OnBarStockChanged, new Action(DPIFOKCMOIC));
	}

	private IEnumerator BGFNCKGFJPG()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private void LOPHDDOAPLH()
	{
		if (BarMenuInventory.EOCHAGBPHCC().FKMFFABKJMB(ItemDatabaseAccessor.EABMGELAAPG(-187, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
		{
			NewTutorialManager.instance.ObjectiveCompleted(1);
			((MonoBehaviour)this).StartCoroutine(PDAEFKAMACE());
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnBarStockChanged = (Action)Delegate.Remove(commonReferences.OnBarStockChanged, new Action(DPIFOKCMOIC));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private IEnumerator FGLMKBOMOBA()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
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
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait05;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T108/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)BarMenuManager.instance).transform.position), Vector2.up * 0.1f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnBarStockChanged = (Action)Delegate.Combine(instance.OnBarStockChanged, new Action(DPIFOKCMOIC));
	}

	private IEnumerator OCHEOJEEFGA()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private void DKHIOIANENC()
	{
		if (BarMenuInventory.GOJHIEFPHDK().HMIDIPBNEGC(ItemDatabaseAccessor.KMBGJEKCJFJ(87, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
		{
			NewTutorialManager.instance.FOIOHOGACAL(1);
			((MonoBehaviour)this).StartCoroutine(AJJPECIKMJN());
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnBarStockChanged = (Action)Delegate.Remove(instance.OnBarStockChanged, new Action(IKCMEHNHLOE));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private void ANCOABBOFPD()
	{
		if (BarMenuInventory.HPCJAODINCN().MMDOFEBHGMA(ItemDatabaseAccessor.GOKIDLOELKB(-90, GGBBJNBBLMF: true)))
		{
			NewTutorialManager.instance.FOIOHOGACAL(0);
			((MonoBehaviour)this).StartCoroutine(OOGKJFJEHFO());
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnBarStockChanged = (Action)Delegate.Remove(commonReferences.OnBarStockChanged, new Action(AJDKJBHKEJN));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private IEnumerator HCCJFBLCABN()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator AOJFNNKFCBL()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator BOMICOPCCML()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void FJOEMLCJJPB()
	{
		if (BarMenuInventory.DCEBHEAHHID().FKMFFABKJMB(ItemDatabaseAccessor.INJBNHPGCIJ(-114, GGBBJNBBLMF: false, DAINLFIMLIH: false)))
		{
			NewTutorialManager.instance.ObjectiveCompleted(1);
			((MonoBehaviour)this).StartCoroutine(DNLEAJAPNOM());
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnBarStockChanged = (Action)Delegate.Remove(instance.OnBarStockChanged, new Action(FJOEMLCJJPB));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private IEnumerator JHBNODHNMCI()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
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
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait05;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T108/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)BarMenuManager.instance).transform.position), Vector2.up * 0.1f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnBarStockChanged = (Action)Delegate.Combine(instance.OnBarStockChanged, new Action(DPIFOKCMOIC));
	}

	private IEnumerator OOGKJFJEHFO()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void BCEOLCLJPHB()
	{
		if (BarMenuInventory.EOCHAGBPHCC().MMDOFEBHGMA(ItemDatabaseAccessor.EABMGELAAPG(-160, GGBBJNBBLMF: true)))
		{
			NewTutorialManager.instance.FOIOHOGACAL(1);
			((MonoBehaviour)this).StartCoroutine(LFANGJJGBFG());
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnBarStockChanged = (Action)Delegate.Remove(commonReferences.OnBarStockChanged, new Action(NHFICGNKLLB));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private IEnumerator AJJPECIKMJN()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AELFLHCNMBB()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator GFMGFHGPGCM()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
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
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait05;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T108/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)BarMenuManager.instance).transform.position), Vector2.up * 0.1f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnBarStockChanged = (Action)Delegate.Combine(instance.OnBarStockChanged, new Action(DPIFOKCMOIC));
	}

	private void KFAFAIIJBNM()
	{
		if (BarMenuInventory.FIEKINOFHMO().HasItem(ItemDatabaseAccessor.CPMMBEPEJLO(101, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
		{
			NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			((MonoBehaviour)this).StartCoroutine(BOMICOPCCML());
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnBarStockChanged = (Action)Delegate.Remove(commonReferences.OnBarStockChanged, new Action(CICDFJKNMON));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private void AGIFOLMHLAH()
	{
		if (BarMenuInventory.FIEKINOFHMO().HMIDIPBNEGC(ItemDatabaseAccessor.INJBNHPGCIJ(68)))
		{
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			((MonoBehaviour)this).StartCoroutine(OOGKJFJEHFO());
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnBarStockChanged = (Action)Delegate.Remove(instance.OnBarStockChanged, new Action(ANCOABBOFPD));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private IEnumerator JIBIJLBJMCH()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JPFGGJMNOKH()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator NHPCNDODFAK()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void KHGKHBIEADF()
	{
		if (BarMenuInventory.EMBCJPOLBCB().HMIDIPBNEGC(ItemDatabaseAccessor.KMBGJEKCJFJ(62, GGBBJNBBLMF: false, DAINLFIMLIH: false)))
		{
			NewTutorialManager.instance.ObjectiveCompleted(1);
			((MonoBehaviour)this).StartCoroutine(DNLEAJAPNOM());
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnBarStockChanged = (Action)Delegate.Remove(instance.OnBarStockChanged, new Action(DNJMHDBOGOC));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private IEnumerator HCKDBDMBMFL()
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

	private void DNJMHDBOGOC()
	{
		if (BarMenuInventory.IIJAOOJGNHO().HasItem(ItemDatabaseAccessor.EABMGELAAPG(92, GGBBJNBBLMF: false, DAINLFIMLIH: false)))
		{
			NewTutorialManager.instance.FOIOHOGACAL(1);
			((MonoBehaviour)this).StartCoroutine(OOGKJFJEHFO());
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnBarStockChanged = (Action)Delegate.Remove(commonReferences.OnBarStockChanged, new Action(GEMLAGHILHM));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private IEnumerator FHCNAFEMIGK()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator IHGGOFFGMBD()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void AJDKJBHKEJN()
	{
		if (BarMenuInventory.OIIIPELOBOK().FKMFFABKJMB(ItemDatabaseAccessor.GOKIDLOELKB(169)))
		{
			NewTutorialManager.instance.FOIOHOGACAL(0);
			((MonoBehaviour)this).StartCoroutine(BJPDFDCOJKJ());
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnBarStockChanged = (Action)Delegate.Remove(commonReferences.OnBarStockChanged, new Action(KAFCFLAJMKN));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private void OGHFFDALDJK()
	{
		if (BarMenuInventory.AKKHNCEFDCB().HMIDIPBNEGC(ItemDatabaseAccessor.INJBNHPGCIJ(126, GGBBJNBBLMF: true)))
		{
			NewTutorialManager.instance.FOIOHOGACAL(1);
			((MonoBehaviour)this).StartCoroutine(AJJPECIKMJN());
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnBarStockChanged = (Action)Delegate.Remove(commonReferences.OnBarStockChanged, new Action(KFAFAIIJBNM));
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

	private IEnumerator DIGIMPCLCCL()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator CMMJDBDKAEO()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NNKFBMKFBMN()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
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
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait05;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T108/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)BarMenuManager.instance).transform.position), Vector2.up * 0.1f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnBarStockChanged = (Action)Delegate.Combine(instance.OnBarStockChanged, new Action(DPIFOKCMOIC));
	}

	private IEnumerator FBCDFDFAILD()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HCKCEGEOJLO()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void GEMLAGHILHM()
	{
		if (BarMenuInventory.GICPPAGFDPG().HMIDIPBNEGC(ItemDatabaseAccessor.INJBNHPGCIJ(106, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
		{
			NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			((MonoBehaviour)this).StartCoroutine(AELFLHCNMBB());
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnBarStockChanged = (Action)Delegate.Remove(commonReferences.OnBarStockChanged, new Action(IKCMEHNHLOE));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private void MHOCCJMNGLC()
	{
		if (BarMenuInventory.EOCHAGBPHCC().FKMFFABKJMB(ItemDatabaseAccessor.KMBGJEKCJFJ(128, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
		{
			NewTutorialManager.instance.FOIOHOGACAL(1);
			((MonoBehaviour)this).StartCoroutine(BAGKLMIFNIH());
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnBarStockChanged = (Action)Delegate.Remove(commonReferences.OnBarStockChanged, new Action(GEMLAGHILHM));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private IEnumerator LNFHFIMPNHD()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AOGGKPMBLBK()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
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
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait05;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T108/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)BarMenuManager.instance).transform.position), Vector2.up * 0.1f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnBarStockChanged = (Action)Delegate.Combine(instance.OnBarStockChanged, new Action(DPIFOKCMOIC));
	}

	private IEnumerator FDMJPHBJACE()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator PBPKJEAAGFE()
	{
		return new DBHBDMOHMPM(1)
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
}
