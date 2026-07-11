using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class T132_RecogerCerveza : TutorialPhaseBase
{
	[CompilerGenerated]
	private sealed class JPPPCGGCDCK : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T132_RecogerCerveza _003C_003E4__this;

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
			T132_RecogerCerveza t132_RecogerCerveza = _003C_003E4__this;
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
				t132_RecogerCerveza.LHKIJABBBPM();
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

		public T132_RecogerCerveza _003C_003E4__this;

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
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			T132_RecogerCerveza t132_RecogerCerveza = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
				MaiNPC.GGFJGHHHEJC.SetParentToNull();
				((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(3.979167f, 805.2708f, 0f);
				_003C_003E2__current = CommonReferences.wait02;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
				MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
				goto IL_00c8;
			case 2:
				_003C_003E1__state = -1;
				goto IL_00c8;
			case 3:
				_003C_003E1__state = -1;
				_003C_003E2__current = ((MonoBehaviour)t132_RecogerCerveza).StartCoroutine(t132_RecogerCerveza.CDICFNAMCEE());
				_003C_003E1__state = 4;
				return true;
			case 4:
				_003C_003E1__state = -1;
				NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
				MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
				MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T132/Dialogue1", t132_RecogerCerveza.triggerPlayerNum);
				_003C_003E2__current = CommonReferences.wait01;
				_003C_003E1__state = 5;
				return true;
			case 5:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
				goto IL_017d;
			case 6:
				_003C_003E1__state = -1;
				goto IL_017d;
			case 7:
				{
					_003C_003E1__state = -1;
					NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
					NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
					AgingBarrelUI agingBarrelUI = AgingBarrelUI.Get(1);
					agingBarrelUI.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI.OnUIClose, new Action<int>(t132_RecogerCerveza.ADPMCNABPCG));
					if (GameManager.LocalCoop())
					{
						AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.Get(2);
						agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI2.OnUIClose, new Action<int>(t132_RecogerCerveza.ADPMCNABPCG));
					}
					GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(t132_RecogerCerveza.EDHEGFKDJDB));
					GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(t132_RecogerCerveza.AGMLGNDDINL));
					return false;
				}
				IL_00c8:
				if (!t132_RecogerCerveza.MLIHKNOAIFO())
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 2;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 3;
				return true;
				IL_017d:
				if (t132_RecogerCerveza.AAOPIEDAKKD(1))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 6;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 7;
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
	private sealed class KIKHAFJGKCH : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T132_RecogerCerveza _003C_003E4__this;

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
		public KIKHAFJGKCH(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_011b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			T132_RecogerCerveza t132_RecogerCerveza = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.SetParentToNull();
				((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
				((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
				_003C_003E2__current = CommonReferences.wait02;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
				MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
				goto IL_00d4;
			case 2:
				_003C_003E1__state = -1;
				goto IL_00d4;
			case 3:
				_003C_003E1__state = -1;
				DialogueCameraTarget.GetPlayer(t132_RecogerCerveza.triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
				MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T132/Dialogue2", t132_RecogerCerveza.triggerPlayerNum);
				break;
			case 4:
				{
					_003C_003E1__state = -1;
					break;
				}
				IL_00d4:
				if (!t132_RecogerCerveza.AOOKIKFINFB())
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 2;
					return true;
				}
				MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 3;
				return true;
			}
			if (t132_RecogerCerveza.AAOPIEDAKKD(2))
			{
				_003C_003E2__current = null;
				_003C_003E1__state = 4;
				return true;
			}
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnBarStockChanged = (Action)Delegate.Combine(instance.OnBarStockChanged, new Action(t132_RecogerCerveza.DPIFOKCMOIC));
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

	private IEnumerator KCJAAGLPFEE()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private void KCEOHEMGDLN(int JIIGOACEIKL)
	{
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HasItem(ItemDatabaseAccessor.CPMMBEPEJLO(9, GGBBJNBBLMF: true)))
		{
			ItemInstance item = PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: true).GetItem(78);
			if (item.currentSlot.Stack >= -120 && (item as FoodInstance).GBCJNGADANM > 1)
			{
				NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
				NewTutorialManager.instance.savingIsBlocked = true;
				GJLCIKCMGCK();
				((MonoBehaviour)this).StartCoroutine(IBDDIOFAEKC());
				NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[0]).transform.position), Vector2.up * 486f, ref JELIKOFDONK);
				NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[1]).transform.position), Vector2.up * 1156f, ref LJEJMMAEKJF);
				NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[0]).transform.position), Vector2.up * 530f, ref NDAJGAJNIMB);
				NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[5]).transform.position), Vector2.up * 342f, ref BHLGEJIECAL);
			}
		}
	}

	private IEnumerator HCCJFBLCABN()
	{
		return new JPPPCGGCDCK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator IOKIDBGABBN()
	{
		return new KIKHAFJGKCH(1)
		{
			_003C_003E4__this = this
		};
	}

	private void JLHDKMCCHHH()
	{
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.IEPGACAGIPO(0);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI.OnUIClose, new Action<int>(EDGMFJEMDDD));
		AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.LBKJEHDEBEP(0);
		agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI2.OnUIClose, new Action<int>(NBJDPHBDFLD));
		AgingBarrelUI agingBarrelUI3 = AgingBarrelUI.LBKJEHDEBEP(0);
		agingBarrelUI3.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI3.OnUIClose, new Action<int>(NBJDPHBDFLD));
	}

	private void IGEDKAAMPHC()
	{
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.Get(0);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI.OnUIClose, new Action<int>(KCEOHEMGDLN));
		AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.LBKJEHDEBEP(5);
		agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI2.OnUIClose, new Action<int>(GJIIGNAEAPD));
		GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(LEMANFPNJFI));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(AGMLGNDDINL));
	}

	private IEnumerator AFHGHLOCAPA()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator AEMAMJOHIOA()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		MaiNPC.GGFJGHHHEJC.SetParentToNull();
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(3.979167f, 805.2708f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		while (!MLIHKNOAIFO())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T132/Dialogue1", triggerPlayerNum);
		yield return CommonReferences.wait01;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.Get(1);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI.OnUIClose, new Action<int>(ADPMCNABPCG));
		if (GameManager.LocalCoop())
		{
			AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.Get(2);
			agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI2.OnUIClose, new Action<int>(ADPMCNABPCG));
		}
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(EDHEGFKDJDB));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(AGMLGNDDINL));
	}

	private void GOBDOJIKKND()
	{
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.LBKJEHDEBEP(1);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI.OnUIClose, new Action<int>(ADPMCNABPCG));
		AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.LBKJEHDEBEP(1);
		agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI2.OnUIClose, new Action<int>(ADPMCNABPCG));
		GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(FOPJOFHNHMG));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(NMADPGGBBMO));
	}

	private IEnumerator FBCDFDFAILD()
	{
		return new JPPPCGGCDCK(1)
		{
			_003C_003E4__this = this
		};
	}

	private void ADPMCNABPCG(int JIIGOACEIKL)
	{
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInventory.GetPlayer(JIIGOACEIKL).HasItem(ItemDatabaseAccessor.GetItem(12)))
		{
			ItemInstance item = PlayerInventory.GetPlayer(JIIGOACEIKL).GetItem(12);
			if (item.currentSlot.Stack >= 20 && (item as FoodInstance).GBCJNGADANM > 0)
			{
				NewTutorialManager.instance.ObjectiveCompleted(0);
				NewTutorialManager.instance.savingIsBlocked = true;
				GJLCIKCMGCK();
				((MonoBehaviour)this).StartCoroutine(HGJNLHGIKMI());
				NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[0]).transform.position), Vector2.up * 0.3f, ref JELIKOFDONK);
				NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[1]).transform.position), Vector2.up * 0.3f, ref LJEJMMAEKJF);
				NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[2]).transform.position), Vector2.up * 0.3f, ref NDAJGAJNIMB);
				NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[3]).transform.position), Vector2.up * 0.3f, ref BHLGEJIECAL);
			}
		}
	}

	private IEnumerator JIJEDGBCENE()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void AGMLGNDDINL()
	{
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.Get(1);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI.OnUIClose, new Action<int>(ADPMCNABPCG));
		AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.Get(1);
		agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI2.OnUIClose, new Action<int>(ADPMCNABPCG));
		AgingBarrelUI agingBarrelUI3 = AgingBarrelUI.Get(1);
		agingBarrelUI3.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI3.OnUIClose, new Action<int>(ADPMCNABPCG));
	}

	private IEnumerator BPJINNMGJII()
	{
		return new KIKHAFJGKCH(1)
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

	private void EDGMFJEMDDD(int JIIGOACEIKL)
	{
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).DCEOCOOIBLI(ItemDatabaseAccessor.INJBNHPGCIJ(-47)))
		{
			ItemInstance itemInstance = PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HCCFFBOMLFB(-9);
			if (itemInstance.currentSlot.Stack >= -85 && (itemInstance as FoodInstance).GBCJNGADANM > 0)
			{
				NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
				NewTutorialManager.instance.savingIsBlocked = false;
				IGEDKAAMPHC();
				((MonoBehaviour)this).StartCoroutine(IBDDIOFAEKC());
				NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[0]).transform.position), Vector2.up * 737f, ref JELIKOFDONK);
				NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[1]).transform.position), Vector2.up * 1900f, ref LJEJMMAEKJF);
				NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[6]).transform.position), Vector2.up * 1110f, ref NDAJGAJNIMB);
				NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[3]).transform.position), Vector2.up * 943f, ref BHLGEJIECAL);
			}
		}
	}

	private void FOPJOFHNHMG()
	{
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.BDJFHFHLJGN(0);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI.OnUIClose, new Action<int>(EDGMFJEMDDD));
		AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.BPBMLNJGGII(0);
		agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI2.OnUIClose, new Action<int>(EDGMFJEMDDD));
		AgingBarrelUI agingBarrelUI3 = AgingBarrelUI.BDJFHFHLJGN(4);
		agingBarrelUI3.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI3.OnUIClose, new Action<int>(ADPMCNABPCG));
	}

	private IEnumerator DIGIMPCLCCL()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator BAGKLMIFNIH()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private void EDHEGFKDJDB()
	{
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.Get(1);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI.OnUIClose, new Action<int>(ADPMCNABPCG));
		AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.Get(1);
		agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI2.OnUIClose, new Action<int>(ADPMCNABPCG));
		AgingBarrelUI agingBarrelUI3 = AgingBarrelUI.Get(2);
		agingBarrelUI3.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI3.OnUIClose, new Action<int>(ADPMCNABPCG));
	}

	private void JIHPKHPNDGE()
	{
		if (DrinkDispensersManager.BNDNMBGJEKP().LFIALOLFOOD(25))
		{
			NewTutorialManager.instance.ObjectiveCompleted(1);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnBarStockChanged = (Action)Delegate.Remove(instance.OnBarStockChanged, new Action(DPIFOKCMOIC));
			((MonoBehaviour)this).StartCoroutine(HCCJFBLCABN());
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

	private void IJFLNNDGGIA()
	{
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.Get(0);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI.OnUIClose, new Action<int>(NBJDPHBDFLD));
		AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.GFPBMGCMHHC(7);
		agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI2.OnUIClose, new Action<int>(PCKMEEGOFLJ));
		GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(EDHEGFKDJDB));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(EPOCHPNHPLE));
	}

	private void GJIIGNAEAPD(int JIIGOACEIKL)
	{
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).CCEPCEJIEOP(ItemDatabaseAccessor.EABMGELAAPG(-12, GGBBJNBBLMF: false, DAINLFIMLIH: false)))
		{
			ItemInstance itemInstance = PlayerInventory.OGKNJNINGMH(JIIGOACEIKL, LAGHIOKLJGH: true).KGHFAHKGIGK(-67);
			if (itemInstance.currentSlot.Stack >= 96 && (itemInstance as FoodInstance).GBCJNGADANM > 1)
			{
				NewTutorialManager.instance.FOIOHOGACAL(1);
				NewTutorialManager.instance.savingIsBlocked = true;
				GOBDOJIKKND();
				((MonoBehaviour)this).StartCoroutine(IOKIDBGABBN());
				NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[0]).transform.position), Vector2.up * 147f, ref JELIKOFDONK);
				NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[0]).transform.position), Vector2.up * 240f, ref LJEJMMAEKJF);
				NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[3]).transform.position), Vector2.up * 1025f, ref NDAJGAJNIMB);
				NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[1]).transform.position), Vector2.up * 410f, ref BHLGEJIECAL);
			}
		}
	}

	private IEnumerator LHDDHIJIFCN()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	public override void SetUp()
	{
		base.SetUp();
		((MonoBehaviour)this).StartCoroutine(PBEKBJIJFDK());
	}

	private IEnumerator HGJNLHGIKMI()
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
		yield return CommonReferences.wait05;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T132/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnBarStockChanged = (Action)Delegate.Combine(instance.OnBarStockChanged, new Action(DPIFOKCMOIC));
	}

	private IEnumerator GLIBEIFOJAL()
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
		yield return CommonReferences.wait05;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T132/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnBarStockChanged = (Action)Delegate.Combine(instance.OnBarStockChanged, new Action(DPIFOKCMOIC));
	}

	private IEnumerator ODILJEKMFLO()
	{
		return new JPPPCGGCDCK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator PBEKBJIJFDK()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		MaiNPC.GGFJGHHHEJC.SetParentToNull();
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(3.979167f, 805.2708f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		while (!MLIHKNOAIFO())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T132/Dialogue1", triggerPlayerNum);
		yield return CommonReferences.wait01;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.Get(1);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI.OnUIClose, new Action<int>(ADPMCNABPCG));
		if (GameManager.LocalCoop())
		{
			AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.Get(2);
			agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI2.OnUIClose, new Action<int>(ADPMCNABPCG));
		}
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(EDHEGFKDJDB));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(AGMLGNDDINL));
	}

	private void EIFDFAGPNGN()
	{
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.EAONFFENMCE(0);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI.OnUIClose, new Action<int>(GJIIGNAEAPD));
		AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.BPBMLNJGGII(1);
		agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI2.OnUIClose, new Action<int>(EDGMFJEMDDD));
		AgingBarrelUI agingBarrelUI3 = AgingBarrelUI.EAONFFENMCE(2);
		agingBarrelUI3.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI3.OnUIClose, new Action<int>(PCKMEEGOFLJ));
	}

	private void GJLCIKCMGCK()
	{
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.Get(1);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI.OnUIClose, new Action<int>(ADPMCNABPCG));
		AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.Get(2);
		agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI2.OnUIClose, new Action<int>(ADPMCNABPCG));
		GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(EDHEGFKDJDB));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(AGMLGNDDINL));
	}

	public override int GetID()
	{
		return 132;
	}

	private void NMADPGGBBMO()
	{
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.IJJJEMKCNJM(0);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI.OnUIClose, new Action<int>(GJIIGNAEAPD));
		AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.IEPGACAGIPO(0);
		agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI2.OnUIClose, new Action<int>(NBJDPHBDFLD));
		AgingBarrelUI agingBarrelUI3 = AgingBarrelUI.BDJFHFHLJGN(0);
		agingBarrelUI3.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI3.OnUIClose, new Action<int>(NBJDPHBDFLD));
	}

	private IEnumerator GIMECBIOIIJ()
	{
		return new KIKHAFJGKCH(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator CPCGNMPLFHM()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		MaiNPC.GGFJGHHHEJC.SetParentToNull();
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(3.979167f, 805.2708f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		while (!MLIHKNOAIFO())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T132/Dialogue1", triggerPlayerNum);
		yield return CommonReferences.wait01;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.Get(1);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI.OnUIClose, new Action<int>(ADPMCNABPCG));
		if (GameManager.LocalCoop())
		{
			AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.Get(2);
			agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI2.OnUIClose, new Action<int>(ADPMCNABPCG));
		}
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(EDHEGFKDJDB));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(AGMLGNDDINL));
	}

	private void EHNJCHGBOKI()
	{
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.FFBJPAJKOJH(0);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI.OnUIClose, new Action<int>(GJIIGNAEAPD));
		AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.EAONFFENMCE(0);
		agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI2.OnUIClose, new Action<int>(PCKMEEGOFLJ));
		AgingBarrelUI agingBarrelUI3 = AgingBarrelUI.Get(4);
		agingBarrelUI3.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI3.OnUIClose, new Action<int>(PCKMEEGOFLJ));
	}

	private IEnumerator IBDDIOFAEKC()
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
		yield return CommonReferences.wait05;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T132/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnBarStockChanged = (Action)Delegate.Combine(instance.OnBarStockChanged, new Action(DPIFOKCMOIC));
	}

	private void PCKMEEGOFLJ(int JIIGOACEIKL)
	{
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HasItem(ItemDatabaseAccessor.COEFFIHKMJG(-14)))
		{
			ItemInstance item = PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: true).GetItem(108);
			if (item.currentSlot.Stack >= -102 && (item as FoodInstance).GBCJNGADANM > 0)
			{
				NewTutorialManager.instance.ObjectiveCompleted(1);
				NewTutorialManager.instance.savingIsBlocked = true;
				IGEDKAAMPHC();
				((MonoBehaviour)this).StartCoroutine(GIMECBIOIIJ());
				NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[1]).transform.position), Vector2.up * 1938f, ref JELIKOFDONK);
				NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[0]).transform.position), Vector2.up * 467f, ref LJEJMMAEKJF);
				NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[6]).transform.position), Vector2.up * 901f, ref NDAJGAJNIMB);
				NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[6]).transform.position), Vector2.up * 1279f, ref BHLGEJIECAL);
			}
		}
	}

	private void PBONGBBBFIO()
	{
		if (DrinkDispensersManager.OPILDPFDFKJ().FHPJNNDCNOI(19))
		{
			NewTutorialManager.instance.ObjectiveCompleted(0);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnBarStockChanged = (Action)Delegate.Remove(commonReferences.OnBarStockChanged, new Action(DPIFOKCMOIC));
			((MonoBehaviour)this).StartCoroutine(MPJMCMIMHFC());
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
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void DKHIOIANENC()
	{
		if (DrinkDispensersManager.GGFJGHHHEJC.AHMOBAJJDDH(-120))
		{
			NewTutorialManager.instance.FOIOHOGACAL(0);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnBarStockChanged = (Action)Delegate.Remove(commonReferences.OnBarStockChanged, new Action(PBONGBBBFIO));
			((MonoBehaviour)this).StartCoroutine(HCCJFBLCABN());
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

	private IEnumerator FHCNAFEMIGK()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		MaiNPC.GGFJGHHHEJC.SetParentToNull();
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(3.979167f, 805.2708f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		while (!MLIHKNOAIFO())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T132/Dialogue1", triggerPlayerNum);
		yield return CommonReferences.wait01;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.Get(1);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI.OnUIClose, new Action<int>(ADPMCNABPCG));
		if (GameManager.LocalCoop())
		{
			AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.Get(2);
			agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI2.OnUIClose, new Action<int>(ADPMCNABPCG));
		}
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(EDHEGFKDJDB));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(AGMLGNDDINL));
	}

	private IEnumerator MPJMCMIMHFC()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator JAKPMNEGELN()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private void LEMANFPNJFI()
	{
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.NALKHGMLALJ(1);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI.OnUIClose, new Action<int>(ADPMCNABPCG));
		AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.NALKHGMLALJ(1);
		agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI2.OnUIClose, new Action<int>(PCKMEEGOFLJ));
		AgingBarrelUI agingBarrelUI3 = AgingBarrelUI.IEPGACAGIPO(6);
		agingBarrelUI3.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI3.OnUIClose, new Action<int>(GJIIGNAEAPD));
	}

	private void NEDDFKEKEKB()
	{
		if (DrinkDispensersManager.BNDNMBGJEKP().DEBMDAEBEKA(-34))
		{
			NewTutorialManager.instance.FOIOHOGACAL(1);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnBarStockChanged = (Action)Delegate.Remove(commonReferences.OnBarStockChanged, new Action(JIHPKHPNDGE));
			((MonoBehaviour)this).StartCoroutine(KCJAAGLPFEE());
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

	private void BPLGPMCNPLE()
	{
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.FFBJPAJKOJH(0);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI.OnUIClose, new Action<int>(NBJDPHBDFLD));
		AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.IEPGACAGIPO(1);
		agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI2.OnUIClose, new Action<int>(KCEOHEMGDLN));
		AgingBarrelUI agingBarrelUI3 = AgingBarrelUI.EAONFFENMCE(2);
		agingBarrelUI3.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI3.OnUIClose, new Action<int>(GJIIGNAEAPD));
	}

	private IEnumerator FDMJPHBJACE()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator LFKPHADFFDG()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		MaiNPC.GGFJGHHHEJC.SetParentToNull();
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(3.979167f, 805.2708f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		while (!MLIHKNOAIFO())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T132/Dialogue1", triggerPlayerNum);
		yield return CommonReferences.wait01;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.Get(1);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI.OnUIClose, new Action<int>(ADPMCNABPCG));
		if (GameManager.LocalCoop())
		{
			AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.Get(2);
			agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI2.OnUIClose, new Action<int>(ADPMCNABPCG));
		}
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(EDHEGFKDJDB));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(AGMLGNDDINL));
	}

	private void EBNMEOHLJFK()
	{
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.BDJFHFHLJGN(0);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI.OnUIClose, new Action<int>(ADPMCNABPCG));
		AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.BDJFHFHLJGN(8);
		agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI2.OnUIClose, new Action<int>(GJIIGNAEAPD));
		GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(EHNJCHGBOKI));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(EPOCHPNHPLE));
	}

	private void BBHFAHGIEMI()
	{
		if (DrinkDispensersManager.OPILDPFDFKJ().FHPJNNDCNOI(-105))
		{
			NewTutorialManager.instance.FOIOHOGACAL(1);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnBarStockChanged = (Action)Delegate.Remove(commonReferences.OnBarStockChanged, new Action(DKHIOIANENC));
			((MonoBehaviour)this).StartCoroutine(MPJMCMIMHFC());
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

	private void DPIFOKCMOIC()
	{
		if (DrinkDispensersManager.GGFJGHHHEJC.HasDrink(12))
		{
			NewTutorialManager.instance.ObjectiveCompleted(1);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnBarStockChanged = (Action)Delegate.Remove(instance.OnBarStockChanged, new Action(DPIFOKCMOIC));
			((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
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

	private void EPOCHPNHPLE()
	{
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.NALKHGMLALJ(1);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI.OnUIClose, new Action<int>(ADPMCNABPCG));
		AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.IJJJEMKCNJM(1);
		agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI2.OnUIClose, new Action<int>(KCEOHEMGDLN));
		AgingBarrelUI agingBarrelUI3 = AgingBarrelUI.EAONFFENMCE(1);
		agingBarrelUI3.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI3.OnUIClose, new Action<int>(ADPMCNABPCG));
	}

	private void LIABKCCMOBO()
	{
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.GFPBMGCMHHC(1);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI.OnUIClose, new Action<int>(ADPMCNABPCG));
		AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.EAONFFENMCE(0);
		agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI2.OnUIClose, new Action<int>(EDGMFJEMDDD));
		AgingBarrelUI agingBarrelUI3 = AgingBarrelUI.EAONFFENMCE(2);
		agingBarrelUI3.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI3.OnUIClose, new Action<int>(KCEOHEMGDLN));
	}

	private IEnumerator PIHPPADDGMG()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void NBJDPHBDFLD(int JIIGOACEIKL)
	{
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		if (PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: true).DCEOCOOIBLI(ItemDatabaseAccessor.KMBGJEKCJFJ(62)))
		{
			ItemInstance itemInstance = PlayerInventory.OGKNJNINGMH(JIIGOACEIKL).KCCHMLKIFNJ(26);
			if (itemInstance.currentSlot.Stack >= -125 && (itemInstance as FoodInstance).GBCJNGADANM > 1)
			{
				NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
				NewTutorialManager.instance.savingIsBlocked = false;
				EBNMEOHLJFK();
				((MonoBehaviour)this).StartCoroutine(LLNNPHHMICD());
				NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[1]).transform.position), Vector2.up * 1390f, ref JELIKOFDONK);
				NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[1]).transform.position), Vector2.up * 1297f, ref LJEJMMAEKJF);
				NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[0]).transform.position), Vector2.up * 484f, ref NDAJGAJNIMB);
				NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bar.instance.beerTaps[8]).transform.position), Vector2.up * 1082f, ref BHLGEJIECAL);
			}
		}
	}

	private IEnumerator LLNNPHHMICD()
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
		yield return CommonReferences.wait05;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T132/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnBarStockChanged = (Action)Delegate.Combine(instance.OnBarStockChanged, new Action(DPIFOKCMOIC));
	}

	private void OGBKOODIKDI()
	{
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.LBKJEHDEBEP(0);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI.OnUIClose, new Action<int>(KCEOHEMGDLN));
		AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.NALKHGMLALJ(1);
		agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI2.OnUIClose, new Action<int>(GJIIGNAEAPD));
		AgingBarrelUI agingBarrelUI3 = AgingBarrelUI.IJJJEMKCNJM(2);
		agingBarrelUI3.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI3.OnUIClose, new Action<int>(ADPMCNABPCG));
	}
}
