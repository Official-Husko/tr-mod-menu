using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class T109_CervezasPestilentesEnGrifo : TutorialPhaseBase
{
	[CompilerGenerated]
	private sealed class ILGBEHOLOGL : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T109_CervezasPestilentesEnGrifo _003C_003E4__this;

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
			T109_CervezasPestilentesEnGrifo t109_CervezasPestilentesEnGrifo = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				goto IL_0042;
			case 1:
				_003C_003E1__state = -1;
				goto IL_0042;
			case 2:
				{
					_003C_003E1__state = -1;
					t109_CervezasPestilentesEnGrifo.LHKIJABBBPM();
					return false;
				}
				IL_0042:
				if (DrinkDispenserUI.Get(1).IsOpen())
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 2;
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

		public T109_CervezasPestilentesEnGrifo _003C_003E4__this;

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
			//IL_014d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0152: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_021a: Unknown result type (might be due to invalid IL or missing references)
			//IL_021f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0224: Unknown result type (might be due to invalid IL or missing references)
			//IL_022e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0258: Unknown result type (might be due to invalid IL or missing references)
			//IL_025d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0262: Unknown result type (might be due to invalid IL or missing references)
			//IL_026c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0296: Unknown result type (might be due to invalid IL or missing references)
			//IL_029b: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			T109_CervezasPestilentesEnGrifo t109_CervezasPestilentesEnGrifo = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
				{
					CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
					((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
					((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
					_003C_003E2__current = CommonReferences.wait02;
					_003C_003E1__state = 1;
					return true;
				}
				goto IL_00d3;
			case 1:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
				MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
				goto IL_00d3;
			case 2:
				_003C_003E1__state = -1;
				_003C_003E2__current = ((MonoBehaviour)t109_CervezasPestilentesEnGrifo).StartCoroutine(t109_CervezasPestilentesEnGrifo.CDICFNAMCEE());
				_003C_003E1__state = 3;
				return true;
			case 3:
				_003C_003E1__state = -1;
				NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 4;
				return true;
			case 4:
				_003C_003E1__state = -1;
				DialogueCameraTarget.GetPlayer(t109_CervezasPestilentesEnGrifo.triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
				MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T109/Dialogue1", t109_CervezasPestilentesEnGrifo.triggerPlayerNum);
				goto IL_018d;
			case 5:
				_003C_003E1__state = -1;
				goto IL_018d;
			case 6:
				{
					_003C_003E1__state = -1;
					NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
					NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
					NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[0]).transform.position), Vector2.up * 0.3f, ref t109_CervezasPestilentesEnGrifo.JELIKOFDONK);
					NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[1]).transform.position), Vector2.up * 0.3f, ref t109_CervezasPestilentesEnGrifo.LJEJMMAEKJF);
					NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[2]).transform.position), Vector2.up * 0.3f, ref t109_CervezasPestilentesEnGrifo.NDAJGAJNIMB);
					NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[3]).transform.position), Vector2.up * 0.3f, ref t109_CervezasPestilentesEnGrifo.BHLGEJIECAL);
					CommonReferences instance = CommonReferences.GGFJGHHHEJC;
					instance.OnBarStockChanged = (Action)Delegate.Combine(instance.OnBarStockChanged, new Action(t109_CervezasPestilentesEnGrifo.DPIFOKCMOIC));
					return false;
				}
				IL_018d:
				if (t109_CervezasPestilentesEnGrifo.AAOPIEDAKKD(1))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 5;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 6;
				return true;
				IL_00d3:
				_003C_003E2__current = ((MonoBehaviour)t109_CervezasPestilentesEnGrifo).StartCoroutine(t109_CervezasPestilentesEnGrifo.CCIOMPBMJMD());
				_003C_003E1__state = 2;
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

	private void ABPKDFKACOJ()
	{
		if (DrinkDispensersManager.BNDNMBGJEKP().ODINMCGGHKB(-80))
		{
			NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			((MonoBehaviour)this).StartCoroutine(ELPINNBKFIP());
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnBarStockChanged = (Action)Delegate.Remove(instance.OnBarStockChanged, new Action(PELAJAMHPGE));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
			if ((Object)(object)NDAJGAJNIMB != (Object)null)
			{
				Object.Destroy((Object)(object)NDAJGAJNIMB);
			}
			if ((Object)(object)BHLGEJIECAL != (Object)null)
			{
				Object.Destroy((Object)(object)BHLGEJIECAL);
			}
		}
	}

	private IEnumerator ELPINNBKFIP()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NBAELEJAFAN()
	{
		while (DrinkDispenserUI.Get(1).IsOpen())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator IHPLPBAELKL()
	{
		while (DrinkDispenserUI.Get(1).IsOpen())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator ELNHMAPENDB()
	{
		while (DrinkDispenserUI.Get(1).IsOpen())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void GEHDGCBDILI()
	{
		if (DrinkDispensersManager.OPILDPFDFKJ().ODINMCGGHKB(-148))
		{
			NewTutorialManager.instance.ObjectiveCompleted(0);
			((MonoBehaviour)this).StartCoroutine(JLDPBKAEOJH());
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnBarStockChanged = (Action)Delegate.Remove(commonReferences.OnBarStockChanged, new Action(OFFFAEFPDJL));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
			if ((Object)(object)NDAJGAJNIMB != (Object)null)
			{
				Object.Destroy((Object)(object)NDAJGAJNIMB);
			}
			if ((Object)(object)BHLGEJIECAL != (Object)null)
			{
				Object.Destroy((Object)(object)BHLGEJIECAL);
			}
		}
	}

	private IEnumerator JCMMNNCKPDO()
	{
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
			((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CCIOMPBMJMD());
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait2;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T109/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[0]).transform.position), Vector2.up * 0.3f, ref JELIKOFDONK);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[1]).transform.position), Vector2.up * 0.3f, ref LJEJMMAEKJF);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[2]).transform.position), Vector2.up * 0.3f, ref NDAJGAJNIMB);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[3]).transform.position), Vector2.up * 0.3f, ref BHLGEJIECAL);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnBarStockChanged = (Action)Delegate.Combine(instance.OnBarStockChanged, new Action(DPIFOKCMOIC));
	}

	private void FFAGCBMPJON()
	{
		if (DrinkDispensersManager.BNDNMBGJEKP().LFIALOLFOOD(-145))
		{
			NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			((MonoBehaviour)this).StartCoroutine(OFOLEPNOONG());
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnBarStockChanged = (Action)Delegate.Remove(instance.OnBarStockChanged, new Action(NEDDFKEKEKB));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
			if ((Object)(object)NDAJGAJNIMB != (Object)null)
			{
				Object.Destroy((Object)(object)NDAJGAJNIMB);
			}
			if ((Object)(object)BHLGEJIECAL != (Object)null)
			{
				Object.Destroy((Object)(object)BHLGEJIECAL);
			}
		}
	}

	private IEnumerator HCCJFBLCABN()
	{
		while (DrinkDispenserUI.Get(1).IsOpen())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator OOBEJHHFIAN()
	{
		while (DrinkDispenserUI.Get(1).IsOpen())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void FJOEMLCJJPB()
	{
		if (DrinkDispensersManager.JHMAMLIPBNN().LFIALOLFOOD(8))
		{
			NewTutorialManager.instance.FOIOHOGACAL(1);
			((MonoBehaviour)this).StartCoroutine(GLLMLANGBOJ());
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnBarStockChanged = (Action)Delegate.Remove(commonReferences.OnBarStockChanged, new Action(FNHFCPJHANK));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
			if ((Object)(object)NDAJGAJNIMB != (Object)null)
			{
				Object.Destroy((Object)(object)NDAJGAJNIMB);
			}
			if ((Object)(object)BHLGEJIECAL != (Object)null)
			{
				Object.Destroy((Object)(object)BHLGEJIECAL);
			}
		}
	}

	private IEnumerator OFOLEPNOONG()
	{
		while (DrinkDispenserUI.Get(1).IsOpen())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	public override void SetUp()
	{
		base.SetUp();
		((MonoBehaviour)this).StartCoroutine(PBEKBJIJFDK());
	}

	private IEnumerator AAOCEAKDPDK()
	{
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
			((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CCIOMPBMJMD());
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait2;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T109/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[0]).transform.position), Vector2.up * 0.3f, ref JELIKOFDONK);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[1]).transform.position), Vector2.up * 0.3f, ref LJEJMMAEKJF);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[2]).transform.position), Vector2.up * 0.3f, ref NDAJGAJNIMB);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[3]).transform.position), Vector2.up * 0.3f, ref BHLGEJIECAL);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnBarStockChanged = (Action)Delegate.Combine(instance.OnBarStockChanged, new Action(DPIFOKCMOIC));
	}

	private IEnumerator EHDIMBMCIDK()
	{
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
			((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CCIOMPBMJMD());
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait2;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T109/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[0]).transform.position), Vector2.up * 0.3f, ref JELIKOFDONK);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[1]).transform.position), Vector2.up * 0.3f, ref LJEJMMAEKJF);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[2]).transform.position), Vector2.up * 0.3f, ref NDAJGAJNIMB);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[3]).transform.position), Vector2.up * 0.3f, ref BHLGEJIECAL);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnBarStockChanged = (Action)Delegate.Combine(instance.OnBarStockChanged, new Action(DPIFOKCMOIC));
	}

	private IEnumerator KNBNIMCHKIE()
	{
		while (DrinkDispenserUI.Get(1).IsOpen())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator HHDLDPPCLPE()
	{
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
			((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CCIOMPBMJMD());
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait2;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T109/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[0]).transform.position), Vector2.up * 0.3f, ref JELIKOFDONK);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[1]).transform.position), Vector2.up * 0.3f, ref LJEJMMAEKJF);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[2]).transform.position), Vector2.up * 0.3f, ref NDAJGAJNIMB);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[3]).transform.position), Vector2.up * 0.3f, ref BHLGEJIECAL);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnBarStockChanged = (Action)Delegate.Combine(instance.OnBarStockChanged, new Action(DPIFOKCMOIC));
	}

	private IEnumerator NCBODCOOANK()
	{
		while (DrinkDispenserUI.Get(1).IsOpen())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator PIHPPADDGMG()
	{
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
			((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CCIOMPBMJMD());
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait2;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T109/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[0]).transform.position), Vector2.up * 0.3f, ref JELIKOFDONK);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[1]).transform.position), Vector2.up * 0.3f, ref LJEJMMAEKJF);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[2]).transform.position), Vector2.up * 0.3f, ref NDAJGAJNIMB);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[3]).transform.position), Vector2.up * 0.3f, ref BHLGEJIECAL);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnBarStockChanged = (Action)Delegate.Combine(instance.OnBarStockChanged, new Action(DPIFOKCMOIC));
	}

	private void IONEEEEFKLN()
	{
		if (DrinkDispensersManager.OPILDPFDFKJ().BLOAFCBKKNA(56))
		{
			NewTutorialManager.instance.FOIOHOGACAL(1);
			((MonoBehaviour)this).StartCoroutine(CKIMLLCOEGC());
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnBarStockChanged = (Action)Delegate.Remove(commonReferences.OnBarStockChanged, new Action(MOJEHBDAFEM));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
			if ((Object)(object)NDAJGAJNIMB != (Object)null)
			{
				Object.Destroy((Object)(object)NDAJGAJNIMB);
			}
			if ((Object)(object)BHLGEJIECAL != (Object)null)
			{
				Object.Destroy((Object)(object)BHLGEJIECAL);
			}
		}
	}

	private IEnumerator DABNLFBDKGN()
	{
		while (DrinkDispenserUI.Get(1).IsOpen())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator HHLKPNANHKK()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	public override int GetID()
	{
		return 109;
	}

	private void FHNILPHBDKF()
	{
		if (DrinkDispensersManager.JFNOOMJMHCB().HADIAMMDNKB(-115))
		{
			NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			((MonoBehaviour)this).StartCoroutine(JKLDKCKPFBJ());
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnBarStockChanged = (Action)Delegate.Remove(commonReferences.OnBarStockChanged, new Action(EDBMEAGMKME));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
			if ((Object)(object)NDAJGAJNIMB != (Object)null)
			{
				Object.Destroy((Object)(object)NDAJGAJNIMB);
			}
			if ((Object)(object)BHLGEJIECAL != (Object)null)
			{
				Object.Destroy((Object)(object)BHLGEJIECAL);
			}
		}
	}

	private IEnumerator PBEKBJIJFDK()
	{
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
			((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CCIOMPBMJMD());
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait2;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T109/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[0]).transform.position), Vector2.up * 0.3f, ref JELIKOFDONK);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[1]).transform.position), Vector2.up * 0.3f, ref LJEJMMAEKJF);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[2]).transform.position), Vector2.up * 0.3f, ref NDAJGAJNIMB);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[3]).transform.position), Vector2.up * 0.3f, ref BHLGEJIECAL);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnBarStockChanged = (Action)Delegate.Combine(instance.OnBarStockChanged, new Action(DPIFOKCMOIC));
	}

	private void HOADPBHHCFO()
	{
		if (DrinkDispensersManager.GGFJGHHHEJC.BLOAFCBKKNA(-60))
		{
			NewTutorialManager.instance.ObjectiveCompleted(0);
			((MonoBehaviour)this).StartCoroutine(HCKDBDMBMFL());
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnBarStockChanged = (Action)Delegate.Remove(instance.OnBarStockChanged, new Action(IONEEEEFKLN));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
			if ((Object)(object)NDAJGAJNIMB != (Object)null)
			{
				Object.Destroy((Object)(object)NDAJGAJNIMB);
			}
			if ((Object)(object)BHLGEJIECAL != (Object)null)
			{
				Object.Destroy((Object)(object)BHLGEJIECAL);
			}
		}
	}

	private IEnumerator GJOCBPGGHLP()
	{
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
			((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CCIOMPBMJMD());
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait2;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T109/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[0]).transform.position), Vector2.up * 0.3f, ref JELIKOFDONK);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[1]).transform.position), Vector2.up * 0.3f, ref LJEJMMAEKJF);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[2]).transform.position), Vector2.up * 0.3f, ref NDAJGAJNIMB);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[3]).transform.position), Vector2.up * 0.3f, ref BHLGEJIECAL);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnBarStockChanged = (Action)Delegate.Combine(instance.OnBarStockChanged, new Action(DPIFOKCMOIC));
	}

	private IEnumerator BCNPEOJDCIF()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JAHNJFGKFII()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HGFPMNKEMAC()
	{
		while (DrinkDispenserUI.Get(1).IsOpen())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator PDAEFKAMACE()
	{
		while (DrinkDispenserUI.Get(1).IsOpen())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator BJKKIJIKPMC()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private void DPIFOKCMOIC()
	{
		if (DrinkDispensersManager.GGFJGHHHEJC.HasDrink(1533))
		{
			NewTutorialManager.instance.ObjectiveCompleted(0);
			((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnBarStockChanged = (Action)Delegate.Remove(instance.OnBarStockChanged, new Action(DPIFOKCMOIC));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
			if ((Object)(object)NDAJGAJNIMB != (Object)null)
			{
				Object.Destroy((Object)(object)NDAJGAJNIMB);
			}
			if ((Object)(object)BHLGEJIECAL != (Object)null)
			{
				Object.Destroy((Object)(object)BHLGEJIECAL);
			}
		}
	}

	private IEnumerator BLNKHNHGFPB()
	{
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
			((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CCIOMPBMJMD());
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait2;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T109/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[0]).transform.position), Vector2.up * 0.3f, ref JELIKOFDONK);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[1]).transform.position), Vector2.up * 0.3f, ref LJEJMMAEKJF);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[2]).transform.position), Vector2.up * 0.3f, ref NDAJGAJNIMB);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[3]).transform.position), Vector2.up * 0.3f, ref BHLGEJIECAL);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnBarStockChanged = (Action)Delegate.Combine(instance.OnBarStockChanged, new Action(DPIFOKCMOIC));
	}

	private void BEHCIMINICF()
	{
		if (DrinkDispensersManager.BNDNMBGJEKP().AHMOBAJJDDH(73))
		{
			NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			((MonoBehaviour)this).StartCoroutine(NBAELEJAFAN());
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnBarStockChanged = (Action)Delegate.Remove(instance.OnBarStockChanged, new Action(FNHFCPJHANK));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
			if ((Object)(object)NDAJGAJNIMB != (Object)null)
			{
				Object.Destroy((Object)(object)NDAJGAJNIMB);
			}
			if ((Object)(object)BHLGEJIECAL != (Object)null)
			{
				Object.Destroy((Object)(object)BHLGEJIECAL);
			}
		}
	}

	private void PFDGBLEGLKO()
	{
		if (DrinkDispensersManager.OPILDPFDFKJ().LFIALOLFOOD(-186))
		{
			NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			((MonoBehaviour)this).StartCoroutine(JKLDKCKPFBJ());
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnBarStockChanged = (Action)Delegate.Remove(instance.OnBarStockChanged, new Action(KFNABNFOBAB));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
			if ((Object)(object)NDAJGAJNIMB != (Object)null)
			{
				Object.Destroy((Object)(object)NDAJGAJNIMB);
			}
			if ((Object)(object)BHLGEJIECAL != (Object)null)
			{
				Object.Destroy((Object)(object)BHLGEJIECAL);
			}
		}
	}

	private void KFNABNFOBAB()
	{
		if (DrinkDispensersManager.GGFJGHHHEJC.FHPJNNDCNOI(-46))
		{
			NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			((MonoBehaviour)this).StartCoroutine(AJGJPBMIEJJ());
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnBarStockChanged = (Action)Delegate.Remove(commonReferences.OnBarStockChanged, new Action(MFEHNNCLIBG));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
			if ((Object)(object)NDAJGAJNIMB != (Object)null)
			{
				Object.Destroy((Object)(object)NDAJGAJNIMB);
			}
			if ((Object)(object)BHLGEJIECAL != (Object)null)
			{
				Object.Destroy((Object)(object)BHLGEJIECAL);
			}
		}
	}

	private IEnumerator AJGJPBMIEJJ()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator FEEJKJJEEPO()
	{
		while (DrinkDispenserUI.Get(1).IsOpen())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void NDOCABMFIJE()
	{
		if (DrinkDispensersManager.JHMAMLIPBNN().HasDrink(190))
		{
			NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			((MonoBehaviour)this).StartCoroutine(JAKPMNEGELN());
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnBarStockChanged = (Action)Delegate.Remove(commonReferences.OnBarStockChanged, new Action(ILLLLGCCMJJ));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
			if ((Object)(object)NDAJGAJNIMB != (Object)null)
			{
				Object.Destroy((Object)(object)NDAJGAJNIMB);
			}
			if ((Object)(object)BHLGEJIECAL != (Object)null)
			{
				Object.Destroy((Object)(object)BHLGEJIECAL);
			}
		}
	}

	private void GDNJJHPOLOO()
	{
		if (DrinkDispensersManager.BNDNMBGJEKP().BLOAFCBKKNA(-159))
		{
			NewTutorialManager.instance.FOIOHOGACAL(1);
			((MonoBehaviour)this).StartCoroutine(BJKKIJIKPMC());
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnBarStockChanged = (Action)Delegate.Remove(instance.OnBarStockChanged, new Action(NEDDFKEKEKB));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
			if ((Object)(object)NDAJGAJNIMB != (Object)null)
			{
				Object.Destroy((Object)(object)NDAJGAJNIMB);
			}
			if ((Object)(object)BHLGEJIECAL != (Object)null)
			{
				Object.Destroy((Object)(object)BHLGEJIECAL);
			}
		}
	}

	private IEnumerator IHBNOLLFNPA()
	{
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
			((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CCIOMPBMJMD());
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait2;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T109/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[0]).transform.position), Vector2.up * 0.3f, ref JELIKOFDONK);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[1]).transform.position), Vector2.up * 0.3f, ref LJEJMMAEKJF);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[2]).transform.position), Vector2.up * 0.3f, ref NDAJGAJNIMB);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[3]).transform.position), Vector2.up * 0.3f, ref BHLGEJIECAL);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnBarStockChanged = (Action)Delegate.Combine(instance.OnBarStockChanged, new Action(DPIFOKCMOIC));
	}

	private IEnumerator BCALBKDNAJH()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JKLDKCKPFBJ()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private void JIHPKHPNDGE()
	{
		if (DrinkDispensersManager.JFNOOMJMHCB().FHPJNNDCNOI(145))
		{
			NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			((MonoBehaviour)this).StartCoroutine(KFKGKKAINLL());
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnBarStockChanged = (Action)Delegate.Remove(commonReferences.OnBarStockChanged, new Action(BBHFAHGIEMI));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
			if ((Object)(object)NDAJGAJNIMB != (Object)null)
			{
				Object.Destroy((Object)(object)NDAJGAJNIMB);
			}
			if ((Object)(object)BHLGEJIECAL != (Object)null)
			{
				Object.Destroy((Object)(object)BHLGEJIECAL);
			}
		}
	}

	private IEnumerator LPNNMDOPCCJ()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NBONAPPPLMN()
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

	private IEnumerator FPIHNICAJHI()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void BPNOEAOJIHP()
	{
		if (DrinkDispensersManager.GGFJGHHHEJC.ODINMCGGHKB(-116))
		{
			NewTutorialManager.instance.FOIOHOGACAL(1);
			((MonoBehaviour)this).StartCoroutine(PDAEFKAMACE());
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnBarStockChanged = (Action)Delegate.Remove(instance.OnBarStockChanged, new Action(PELAJAMHPGE));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
			if ((Object)(object)NDAJGAJNIMB != (Object)null)
			{
				Object.Destroy((Object)(object)NDAJGAJNIMB);
			}
			if ((Object)(object)BHLGEJIECAL != (Object)null)
			{
				Object.Destroy((Object)(object)BHLGEJIECAL);
			}
		}
	}

	private IEnumerator CKIMLLCOEGC()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private void LNPKFCKCOBE()
	{
		if (DrinkDispensersManager.GGFJGHHHEJC.HasDrink(-134))
		{
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			((MonoBehaviour)this).StartCoroutine(KFKGKKAINLL());
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnBarStockChanged = (Action)Delegate.Remove(commonReferences.OnBarStockChanged, new Action(PFDGBLEGLKO));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
			if ((Object)(object)NDAJGAJNIMB != (Object)null)
			{
				Object.Destroy((Object)(object)NDAJGAJNIMB);
			}
			if ((Object)(object)BHLGEJIECAL != (Object)null)
			{
				Object.Destroy((Object)(object)BHLGEJIECAL);
			}
		}
	}

	private void MOAFFOGPAAL()
	{
		if (DrinkDispensersManager.JFNOOMJMHCB().AKLEGLCOOCO(80))
		{
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			((MonoBehaviour)this).StartCoroutine(FDAPBNJHNJG());
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnBarStockChanged = (Action)Delegate.Remove(commonReferences.OnBarStockChanged, new Action(NDOCABMFIJE));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
			if ((Object)(object)NDAJGAJNIMB != (Object)null)
			{
				Object.Destroy((Object)(object)NDAJGAJNIMB);
			}
			if ((Object)(object)BHLGEJIECAL != (Object)null)
			{
				Object.Destroy((Object)(object)BHLGEJIECAL);
			}
		}
	}

	private void AGIFOLMHLAH()
	{
		if (DrinkDispensersManager.JHMAMLIPBNN().KJNJPJJMMFG(68))
		{
			NewTutorialManager.instance.FOIOHOGACAL(1);
			((MonoBehaviour)this).StartCoroutine(JLDPBKAEOJH());
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnBarStockChanged = (Action)Delegate.Remove(instance.OnBarStockChanged, new Action(NEDDFKEKEKB));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
			if ((Object)(object)NDAJGAJNIMB != (Object)null)
			{
				Object.Destroy((Object)(object)NDAJGAJNIMB);
			}
			if ((Object)(object)BHLGEJIECAL != (Object)null)
			{
				Object.Destroy((Object)(object)BHLGEJIECAL);
			}
		}
	}

	private void CJDIOFAPCDJ()
	{
		if (DrinkDispensersManager.BNDNMBGJEKP().HADIAMMDNKB(155))
		{
			NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			((MonoBehaviour)this).StartCoroutine(AOJFNNKFCBL());
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnBarStockChanged = (Action)Delegate.Remove(instance.OnBarStockChanged, new Action(ABPKDFKACOJ));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
			if ((Object)(object)NDAJGAJNIMB != (Object)null)
			{
				Object.Destroy((Object)(object)NDAJGAJNIMB);
			}
			if ((Object)(object)BHLGEJIECAL != (Object)null)
			{
				Object.Destroy((Object)(object)BHLGEJIECAL);
			}
		}
	}

	private IEnumerator GLLMLANGBOJ()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator KFKGKKAINLL()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AJJHBJHCACM()
	{
		return new DBHBDMOHMPM(1)
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

	private IEnumerator EGAGPFBFKIL()
	{
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
			((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CCIOMPBMJMD());
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait2;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T109/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[0]).transform.position), Vector2.up * 0.3f, ref JELIKOFDONK);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[1]).transform.position), Vector2.up * 0.3f, ref LJEJMMAEKJF);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[2]).transform.position), Vector2.up * 0.3f, ref NDAJGAJNIMB);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[3]).transform.position), Vector2.up * 0.3f, ref BHLGEJIECAL);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnBarStockChanged = (Action)Delegate.Combine(instance.OnBarStockChanged, new Action(DPIFOKCMOIC));
	}

	private IEnumerator MEGKLKNBNEL()
	{
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
			((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CCIOMPBMJMD());
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait2;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T109/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[0]).transform.position), Vector2.up * 0.3f, ref JELIKOFDONK);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[1]).transform.position), Vector2.up * 0.3f, ref LJEJMMAEKJF);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[2]).transform.position), Vector2.up * 0.3f, ref NDAJGAJNIMB);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[3]).transform.position), Vector2.up * 0.3f, ref BHLGEJIECAL);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnBarStockChanged = (Action)Delegate.Combine(instance.OnBarStockChanged, new Action(DPIFOKCMOIC));
	}

	private IEnumerator IMMGACBJLCE()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void MFEHNNCLIBG()
	{
		if (DrinkDispensersManager.OPILDPFDFKJ().DEBMDAEBEKA(-49))
		{
			NewTutorialManager.instance.FOIOHOGACAL(1);
			((MonoBehaviour)this).StartCoroutine(IAOFDDMPMBJ());
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnBarStockChanged = (Action)Delegate.Remove(commonReferences.OnBarStockChanged, new Action(GDNJJHPOLOO));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
			if ((Object)(object)NDAJGAJNIMB != (Object)null)
			{
				Object.Destroy((Object)(object)NDAJGAJNIMB);
			}
			if ((Object)(object)BHLGEJIECAL != (Object)null)
			{
				Object.Destroy((Object)(object)BHLGEJIECAL);
			}
		}
	}

	private void PELAJAMHPGE()
	{
		if (DrinkDispensersManager.GGFJGHHHEJC.AKLEGLCOOCO(-133))
		{
			NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			((MonoBehaviour)this).StartCoroutine(HGFPMNKEMAC());
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnBarStockChanged = (Action)Delegate.Remove(commonReferences.OnBarStockChanged, new Action(FHNILPHBDKF));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
			if ((Object)(object)NDAJGAJNIMB != (Object)null)
			{
				Object.Destroy((Object)(object)NDAJGAJNIMB);
			}
			if ((Object)(object)BHLGEJIECAL != (Object)null)
			{
				Object.Destroy((Object)(object)BHLGEJIECAL);
			}
		}
	}

	private IEnumerator AGFLJLODJJK()
	{
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
			((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CCIOMPBMJMD());
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait2;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T109/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[0]).transform.position), Vector2.up * 0.3f, ref JELIKOFDONK);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[1]).transform.position), Vector2.up * 0.3f, ref LJEJMMAEKJF);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[2]).transform.position), Vector2.up * 0.3f, ref NDAJGAJNIMB);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[3]).transform.position), Vector2.up * 0.3f, ref BHLGEJIECAL);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnBarStockChanged = (Action)Delegate.Combine(instance.OnBarStockChanged, new Action(DPIFOKCMOIC));
	}

	private void NEDDFKEKEKB()
	{
		if (DrinkDispensersManager.OPILDPFDFKJ().AKLEGLCOOCO(199))
		{
			NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			((MonoBehaviour)this).StartCoroutine(DABNLFBDKGN());
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnBarStockChanged = (Action)Delegate.Remove(commonReferences.OnBarStockChanged, new Action(OFFFAEFPDJL));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
			if ((Object)(object)NDAJGAJNIMB != (Object)null)
			{
				Object.Destroy((Object)(object)NDAJGAJNIMB);
			}
			if ((Object)(object)BHLGEJIECAL != (Object)null)
			{
				Object.Destroy((Object)(object)BHLGEJIECAL);
			}
		}
	}

	private IEnumerator FLECFIDDCJE()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private void MOJEHBDAFEM()
	{
		if (DrinkDispensersManager.GGFJGHHHEJC.ODINMCGGHKB(-73))
		{
			NewTutorialManager.instance.FOIOHOGACAL(0);
			((MonoBehaviour)this).StartCoroutine(HOCIHMHCEAK());
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnBarStockChanged = (Action)Delegate.Remove(commonReferences.OnBarStockChanged, new Action(OEHBKEMBAKK));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
			if ((Object)(object)NDAJGAJNIMB != (Object)null)
			{
				Object.Destroy((Object)(object)NDAJGAJNIMB);
			}
			if ((Object)(object)BHLGEJIECAL != (Object)null)
			{
				Object.Destroy((Object)(object)BHLGEJIECAL);
			}
		}
	}

	private void ILLLLGCCMJJ()
	{
		if (DrinkDispensersManager.JHMAMLIPBNN().HADIAMMDNKB(158))
		{
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			((MonoBehaviour)this).StartCoroutine(JLDPBKAEOJH());
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnBarStockChanged = (Action)Delegate.Remove(commonReferences.OnBarStockChanged, new Action(KFNABNFOBAB));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
			if ((Object)(object)NDAJGAJNIMB != (Object)null)
			{
				Object.Destroy((Object)(object)NDAJGAJNIMB);
			}
			if ((Object)(object)BHLGEJIECAL != (Object)null)
			{
				Object.Destroy((Object)(object)BHLGEJIECAL);
			}
		}
	}

	private void OEHBKEMBAKK()
	{
		if (DrinkDispensersManager.JFNOOMJMHCB().AHMOBAJJDDH(4))
		{
			NewTutorialManager.instance.FOIOHOGACAL(0);
			((MonoBehaviour)this).StartCoroutine(NBONAPPPLMN());
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnBarStockChanged = (Action)Delegate.Remove(commonReferences.OnBarStockChanged, new Action(NEDDFKEKEKB));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
			if ((Object)(object)NDAJGAJNIMB != (Object)null)
			{
				Object.Destroy((Object)(object)NDAJGAJNIMB);
			}
			if ((Object)(object)BHLGEJIECAL != (Object)null)
			{
				Object.Destroy((Object)(object)BHLGEJIECAL);
			}
		}
	}

	private void FNHFCPJHANK()
	{
		if (DrinkDispensersManager.GGFJGHHHEJC.HADIAMMDNKB(4))
		{
			NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			((MonoBehaviour)this).StartCoroutine(JKLDKCKPFBJ());
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnBarStockChanged = (Action)Delegate.Remove(instance.OnBarStockChanged, new Action(OEHBKEMBAKK));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
			if ((Object)(object)NDAJGAJNIMB != (Object)null)
			{
				Object.Destroy((Object)(object)NDAJGAJNIMB);
			}
			if ((Object)(object)BHLGEJIECAL != (Object)null)
			{
				Object.Destroy((Object)(object)BHLGEJIECAL);
			}
		}
	}

	private void BBHFAHGIEMI()
	{
		if (DrinkDispensersManager.JHMAMLIPBNN().AHMOBAJJDDH(-82))
		{
			NewTutorialManager.instance.ObjectiveCompleted(0);
			((MonoBehaviour)this).StartCoroutine(MPJMCMIMHFC());
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnBarStockChanged = (Action)Delegate.Remove(instance.OnBarStockChanged, new Action(FNHFCPJHANK));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
			if ((Object)(object)NDAJGAJNIMB != (Object)null)
			{
				Object.Destroy((Object)(object)NDAJGAJNIMB);
			}
			if ((Object)(object)BHLGEJIECAL != (Object)null)
			{
				Object.Destroy((Object)(object)BHLGEJIECAL);
			}
		}
	}

	private void LHFAGIJNKLJ()
	{
		if (DrinkDispensersManager.GGFJGHHHEJC.HasDrink(-119))
		{
			NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnBarStockChanged = (Action)Delegate.Remove(commonReferences.OnBarStockChanged, new Action(BBHFAHGIEMI));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
			if ((Object)(object)NDAJGAJNIMB != (Object)null)
			{
				Object.Destroy((Object)(object)NDAJGAJNIMB);
			}
			if ((Object)(object)BHLGEJIECAL != (Object)null)
			{
				Object.Destroy((Object)(object)BHLGEJIECAL);
			}
		}
	}

	private IEnumerator COMPHHHBLIO()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JIBIJLBJMCH()
	{
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
			((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CCIOMPBMJMD());
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait2;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T109/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[0]).transform.position), Vector2.up * 0.3f, ref JELIKOFDONK);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[1]).transform.position), Vector2.up * 0.3f, ref LJEJMMAEKJF);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[2]).transform.position), Vector2.up * 0.3f, ref NDAJGAJNIMB);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[3]).transform.position), Vector2.up * 0.3f, ref BHLGEJIECAL);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnBarStockChanged = (Action)Delegate.Combine(instance.OnBarStockChanged, new Action(DPIFOKCMOIC));
	}

	private IEnumerator EKMOJHNJOCG()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void OFFFAEFPDJL()
	{
		if (DrinkDispensersManager.GGFJGHHHEJC.AKLEGLCOOCO(-119))
		{
			NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			((MonoBehaviour)this).StartCoroutine(AOJFNNKFCBL());
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnBarStockChanged = (Action)Delegate.Remove(instance.OnBarStockChanged, new Action(GPJANDJFLAJ));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
			if ((Object)(object)NDAJGAJNIMB != (Object)null)
			{
				Object.Destroy((Object)(object)NDAJGAJNIMB);
			}
			if ((Object)(object)BHLGEJIECAL != (Object)null)
			{
				Object.Destroy((Object)(object)BHLGEJIECAL);
			}
		}
	}

	private IEnumerator JDEDKABEHJM()
	{
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
			((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CCIOMPBMJMD());
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait2;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T109/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[0]).transform.position), Vector2.up * 0.3f, ref JELIKOFDONK);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[1]).transform.position), Vector2.up * 0.3f, ref LJEJMMAEKJF);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[2]).transform.position), Vector2.up * 0.3f, ref NDAJGAJNIMB);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[3]).transform.position), Vector2.up * 0.3f, ref BHLGEJIECAL);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnBarStockChanged = (Action)Delegate.Combine(instance.OnBarStockChanged, new Action(DPIFOKCMOIC));
	}

	private IEnumerator KMIBOOOFJKB()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator FDAPBNJHNJG()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NPCCKFEDCHI()
	{
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
			((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CCIOMPBMJMD());
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait2;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T109/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[0]).transform.position), Vector2.up * 0.3f, ref JELIKOFDONK);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[1]).transform.position), Vector2.up * 0.3f, ref LJEJMMAEKJF);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[2]).transform.position), Vector2.up * 0.3f, ref NDAJGAJNIMB);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[3]).transform.position), Vector2.up * 0.3f, ref BHLGEJIECAL);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnBarStockChanged = (Action)Delegate.Combine(instance.OnBarStockChanged, new Action(DPIFOKCMOIC));
	}

	private void DCGCHOGGHDM()
	{
		if (DrinkDispensersManager.BNDNMBGJEKP().FHPJNNDCNOI(177))
		{
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			((MonoBehaviour)this).StartCoroutine(JAKPMNEGELN());
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnBarStockChanged = (Action)Delegate.Remove(commonReferences.OnBarStockChanged, new Action(DPIFOKCMOIC));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
			if ((Object)(object)NDAJGAJNIMB != (Object)null)
			{
				Object.Destroy((Object)(object)NDAJGAJNIMB);
			}
			if ((Object)(object)BHLGEJIECAL != (Object)null)
			{
				Object.Destroy((Object)(object)BHLGEJIECAL);
			}
		}
	}

	private IEnumerator JLDPBKAEOJH()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LGDNIGIMDKP()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AOJFNNKFCBL()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JIFEIKLKIMF()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HNFCACDCBBO()
	{
		while (DrinkDispenserUI.Get(1).IsOpen())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator IAOFDDMPMBJ()
	{
		while (DrinkDispenserUI.Get(1).IsOpen())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void GPJANDJFLAJ()
	{
		if (DrinkDispensersManager.GGFJGHHHEJC.FHPJNNDCNOI(45))
		{
			NewTutorialManager.instance.ObjectiveCompleted(1);
			((MonoBehaviour)this).StartCoroutine(OOBEJHHFIAN());
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnBarStockChanged = (Action)Delegate.Remove(commonReferences.OnBarStockChanged, new Action(PELAJAMHPGE));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
			if ((Object)(object)NDAJGAJNIMB != (Object)null)
			{
				Object.Destroy((Object)(object)NDAJGAJNIMB);
			}
			if ((Object)(object)BHLGEJIECAL != (Object)null)
			{
				Object.Destroy((Object)(object)BHLGEJIECAL);
			}
		}
	}

	private IEnumerator MIGPNMAOJPK()
	{
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
			((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CCIOMPBMJMD());
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait2;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T109/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[0]).transform.position), Vector2.up * 0.3f, ref JELIKOFDONK);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[1]).transform.position), Vector2.up * 0.3f, ref LJEJMMAEKJF);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[2]).transform.position), Vector2.up * 0.3f, ref NDAJGAJNIMB);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[3]).transform.position), Vector2.up * 0.3f, ref BHLGEJIECAL);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnBarStockChanged = (Action)Delegate.Combine(instance.OnBarStockChanged, new Action(DPIFOKCMOIC));
	}

	private IEnumerator JAKPMNEGELN()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator PAJJMLCLHHK()
	{
		while (DrinkDispenserUI.Get(1).IsOpen())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator HCKDBDMBMFL()
	{
		while (DrinkDispenserUI.Get(1).IsOpen())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator LHDDHIJIFCN()
	{
		while (DrinkDispenserUI.Get(1).IsOpen())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator CIBIOLGHPJF()
	{
		while (DrinkDispenserUI.Get(1).IsOpen())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator BCPNMIIJIEJ()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JNOOAENGMHL()
	{
		while (DrinkDispenserUI.Get(1).IsOpen())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator HOCIHMHCEAK()
	{
		while (DrinkDispenserUI.Get(1).IsOpen())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator EBJFNGDABLK()
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

	private void DPOCAKAPMLI()
	{
		if (DrinkDispensersManager.JFNOOMJMHCB().BLOAFCBKKNA(-33))
		{
			NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			((MonoBehaviour)this).StartCoroutine(JAKPMNEGELN());
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnBarStockChanged = (Action)Delegate.Remove(instance.OnBarStockChanged, new Action(BBHFAHGIEMI));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
			if ((Object)(object)NDAJGAJNIMB != (Object)null)
			{
				Object.Destroy((Object)(object)NDAJGAJNIMB);
			}
			if ((Object)(object)BHLGEJIECAL != (Object)null)
			{
				Object.Destroy((Object)(object)BHLGEJIECAL);
			}
		}
	}

	private void OALNPABCPMD()
	{
		if (DrinkDispensersManager.OPILDPFDFKJ().AHMOBAJJDDH(174))
		{
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			((MonoBehaviour)this).StartCoroutine(CKIMLLCOEGC());
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnBarStockChanged = (Action)Delegate.Remove(instance.OnBarStockChanged, new Action(DPKGHMLFCIN));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
			if ((Object)(object)NDAJGAJNIMB != (Object)null)
			{
				Object.Destroy((Object)(object)NDAJGAJNIMB);
			}
			if ((Object)(object)BHLGEJIECAL != (Object)null)
			{
				Object.Destroy((Object)(object)BHLGEJIECAL);
			}
		}
	}

	private void HCHBPBIAKEA()
	{
		if (DrinkDispensersManager.JFNOOMJMHCB().AKLEGLCOOCO(-91))
		{
			NewTutorialManager.instance.FOIOHOGACAL(1);
			((MonoBehaviour)this).StartCoroutine(HGFPMNKEMAC());
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnBarStockChanged = (Action)Delegate.Remove(instance.OnBarStockChanged, new Action(OEHBKEMBAKK));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
			if ((Object)(object)NDAJGAJNIMB != (Object)null)
			{
				Object.Destroy((Object)(object)NDAJGAJNIMB);
			}
			if ((Object)(object)BHLGEJIECAL != (Object)null)
			{
				Object.Destroy((Object)(object)BHLGEJIECAL);
			}
		}
	}

	private IEnumerator JECHOKLEDDA()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private void DPKGHMLFCIN()
	{
		if (DrinkDispensersManager.JFNOOMJMHCB().HADIAMMDNKB(-193))
		{
			NewTutorialManager.instance.FOIOHOGACAL(0);
			((MonoBehaviour)this).StartCoroutine(BJKKIJIKPMC());
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnBarStockChanged = (Action)Delegate.Remove(commonReferences.OnBarStockChanged, new Action(DPOCAKAPMLI));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
			if ((Object)(object)NDAJGAJNIMB != (Object)null)
			{
				Object.Destroy((Object)(object)NDAJGAJNIMB);
			}
			if ((Object)(object)BHLGEJIECAL != (Object)null)
			{
				Object.Destroy((Object)(object)BHLGEJIECAL);
			}
		}
	}

	private IEnumerator JKFNHFDPOJN()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void EDBMEAGMKME()
	{
		if (DrinkDispensersManager.BNDNMBGJEKP().LFIALOLFOOD(64))
		{
			NewTutorialManager.instance.ObjectiveCompleted(0);
			((MonoBehaviour)this).StartCoroutine(GLLMLANGBOJ());
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnBarStockChanged = (Action)Delegate.Remove(instance.OnBarStockChanged, new Action(BEHCIMINICF));
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
			if ((Object)(object)NDAJGAJNIMB != (Object)null)
			{
				Object.Destroy((Object)(object)NDAJGAJNIMB);
			}
			if ((Object)(object)BHLGEJIECAL != (Object)null)
			{
				Object.Destroy((Object)(object)BHLGEJIECAL);
			}
		}
	}

	private IEnumerator NKOJNIDHGBJ()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}
}
