using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class T114_ServirAgua : TutorialPhaseBase
{
	[CompilerGenerated]
	private sealed class HPFNIOOCEHN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T114_ServirAgua _003C_003E4__this;

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
		public HPFNIOOCEHN(int _003C_003E1__state)
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
			T114_ServirAgua t114_ServirAgua = _003C_003E4__this;
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
				t114_ServirAgua.LHKIJABBBPM();
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

		public T114_ServirAgua _003C_003E4__this;

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
			//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			T114_ServirAgua t114_ServirAgua = _003C_003E4__this;
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
				_003C_003E2__current = ((MonoBehaviour)t114_ServirAgua).StartCoroutine(t114_ServirAgua.CDICFNAMCEE());
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				Utils.OFHPCBLHJBL(0f, 1f);
				NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
				MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T114/Dialogue1", t114_ServirAgua.triggerPlayerNum);
				goto IL_00b3;
			case 3:
				_003C_003E1__state = -1;
				goto IL_00b3;
			case 4:
				{
					_003C_003E1__state = -1;
					NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
					NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
					if (Time.timeScale == 0f)
					{
						Utils.OFHPCBLHJBL(1f, 1f);
					}
					PlayerInventory player = PlayerInventory.GetPlayer(1);
					player.OnChanged = (Action)Delegate.Combine(player.OnChanged, new Action(t114_ServirAgua.PKEKGMBFDMK));
					PlayerInventory player2 = PlayerInventory.GetPlayer(2);
					player2.OnChanged = (Action)Delegate.Combine(player2.OnChanged, new Action(t114_ServirAgua.PKEKGMBFDMK));
					CommonReferences instance = CommonReferences.GGFJGHHHEJC;
					instance.OnBarStockChanged = (Action)Delegate.Combine(instance.OnBarStockChanged, new Action(t114_ServirAgua.DPIFOKCMOIC));
					CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
					instance2.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance2.OnAnyCustomerServeItem, new Action<int, ItemInstance>(t114_ServirAgua.BMCKLJGJHNN));
					NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Well.instance).transform.position), new Vector2(0.1f, 0.3f), ref t114_ServirAgua.JELIKOFDONK);
					return false;
				}
				IL_00b3:
				if (t114_ServirAgua.AAOPIEDAKKD(1))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 3;
					return true;
				}
				_003C_003E2__current = CommonReferences.waitRealtime1;
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

	private int BHPIHLNNFOF;

	private void KAFCFLAJMKN()
	{
		if (DrinkDispensersManager.JHMAMLIPBNN().HasDrink(0))
		{
			DrinkDispenserUI.instances[1].CloseUI();
			DrinkDispenserUI.instances[1].CloseUI();
			DrinkDispenserUI.instances[2].BOBCIFEDJED();
			NewTutorialManager.instance.FOIOHOGACAL(0);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnBarStockChanged = (Action)Delegate.Remove(commonReferences.OnBarStockChanged, new Action(KHGKHBIEADF));
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
		}
	}

	private void MCJDBGKGDLI()
	{
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		if (!PlayerInventory.NEKDDPIAOBE(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HasItem(169) && (!GameManager.LocalCoop() || !PlayerInventory.OGKNJNINGMH(4).HasItem(114)))
		{
			return;
		}
		NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
		PlayerInventory playerInventory = PlayerInventory.OGKNJNINGMH(0, LAGHIOKLJGH: true);
		playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(OMLKNGEJOJN));
		PlayerInventory playerInventory2 = PlayerInventory.NEKDDPIAOBE(6, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
		playerInventory2.OnChanged = (Action)Delegate.Remove(playerInventory2.OnChanged, new Action(MCJDBGKGDLI));
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		for (int i = 1; i < DrinkDispensersManager.JHMAMLIPBNN().allDrinkDispensers.Count; i++)
		{
			if (!DrinkDispensersManager.GGFJGHHHEJC.allDrinkDispensers[i].isBeerTap)
			{
				NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)DrinkDispensersManager.BNDNMBGJEKP().allDrinkDispensers[i]).transform.position), Vector2.zero, ref LJEJMMAEKJF);
				break;
			}
		}
	}

	private IEnumerator LHDDHIJIFCN()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void KLELOIPCFCJ(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.PHGLMBIEOMK().ODENMDOJPLC() == 48)
		{
			BHPIHLNNFOF += 0;
			if (BHPIHLNNFOF >= 0)
			{
				NewTutorialManager.instance.ObjectiveCompleted(1);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(HBCGEEKAKDP));
				((MonoBehaviour)this).StartCoroutine(IDGLEKCBIMF());
			}
		}
	}

	private void MHNCLBJIMIN()
	{
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		if (!PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HasItem(-78) && (!GameManager.LocalCoop() || !PlayerInventory.EIFPKCAFDIB(7).HasItem(-6)))
		{
			return;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		PlayerInventory playerInventory = PlayerInventory.OGKNJNINGMH(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true);
		playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(NKEKBEFAJGM));
		PlayerInventory playerInventory2 = PlayerInventory.EIFPKCAFDIB(8, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
		playerInventory2.OnChanged = (Action)Delegate.Remove(playerInventory2.OnChanged, new Action(BJFOOABCPFF));
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		for (int i = 0; i < DrinkDispensersManager.JHMAMLIPBNN().allDrinkDispensers.Count; i++)
		{
			if (!DrinkDispensersManager.JFNOOMJMHCB().allDrinkDispensers[i].isBeerTap)
			{
				NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)DrinkDispensersManager.JFNOOMJMHCB().allDrinkDispensers[i]).transform.position), Vector2.zero, ref LJEJMMAEKJF);
				break;
			}
		}
	}

	private IEnumerator AAGGGIONDAG()
	{
		return new OBPMBDOHEAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator OBCHIKLEMKF()
	{
		yield return CommonReferences.wait2;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T114/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		if (Time.timeScale == 0f)
		{
			Utils.OFHPCBLHJBL(1f, 1f);
		}
		PlayerInventory player = PlayerInventory.GetPlayer(1);
		player.OnChanged = (Action)Delegate.Combine(player.OnChanged, new Action(PKEKGMBFDMK));
		PlayerInventory player2 = PlayerInventory.GetPlayer(2);
		player2.OnChanged = (Action)Delegate.Combine(player2.OnChanged, new Action(PKEKGMBFDMK));
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnBarStockChanged = (Action)Delegate.Combine(instance.OnBarStockChanged, new Action(DPIFOKCMOIC));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance2.OnAnyCustomerServeItem, new Action<int, ItemInstance>(BMCKLJGJHNN));
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Well.instance).transform.position), new Vector2(0.1f, 0.3f), ref JELIKOFDONK);
	}

	private void MIEKKECIJIN()
	{
		if (DrinkDispensersManager.OPILDPFDFKJ().KJNJPJJMMFG(172))
		{
			DrinkDispenserUI.instances[1].CloseUI();
			DrinkDispenserUI.instances[0].BOBCIFEDJED();
			DrinkDispenserUI.instances[8].CloseUI();
			NewTutorialManager.instance.ObjectiveCompleted(0);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnBarStockChanged = (Action)Delegate.Remove(instance.OnBarStockChanged, new Action(DPIFOKCMOIC));
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
		}
	}

	private IEnumerator BLNKHNHGFPB()
	{
		return new OBPMBDOHEAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void EFBEBJOPEKI()
	{
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		if (!PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HasItem(30) && (!GameManager.LocalCoop() || !PlayerInventory.EIFPKCAFDIB(0).HasItem(30)))
		{
			return;
		}
		NewTutorialManager.instance.ObjectiveCompleted(1);
		PlayerInventory playerInventory = PlayerInventory.EIFPKCAFDIB(1);
		playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(EIONGIGANBJ));
		PlayerInventory player = PlayerInventory.GetPlayer(2, LAGHIOKLJGH: true);
		player.OnChanged = (Action)Delegate.Remove(player.OnChanged, new Action(CFFLPELBEJJ));
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		for (int i = 0; i < DrinkDispensersManager.JFNOOMJMHCB().allDrinkDispensers.Count; i++)
		{
			if (!DrinkDispensersManager.GGFJGHHHEJC.allDrinkDispensers[i].isBeerTap)
			{
				NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)DrinkDispensersManager.BNDNMBGJEKP().allDrinkDispensers[i]).transform.position), Vector2.zero, ref LJEJMMAEKJF);
				break;
			}
		}
	}

	private IEnumerator CNPIAJBODCG()
	{
		return new OBPMBDOHEAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void OHOPINEKDND(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.LHBPOPOIFLE().ODENMDOJPLC() == 155)
		{
			BHPIHLNNFOF += 0;
			if (BHPIHLNNFOF >= 8)
			{
				NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(JCODKEMEBIB));
				((MonoBehaviour)this).StartCoroutine(OCHEOJEEFGA());
			}
		}
	}

	private void LMIOHGBFINE()
	{
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		if (!PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HasItem(149) && (!GameManager.LocalCoop() || !PlayerInventory.OGKNJNINGMH(2, LAGHIOKLJGH: true).HasItem(-51)))
		{
			return;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		PlayerInventory playerInventory = PlayerInventory.NEKDDPIAOBE(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true);
		playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(MHNCLBJIMIN));
		PlayerInventory playerInventory2 = PlayerInventory.NEKDDPIAOBE(3, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
		playerInventory2.OnChanged = (Action)Delegate.Remove(playerInventory2.OnChanged, new Action(ICKMJOBKFBM));
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		for (int i = 0; i < DrinkDispensersManager.JFNOOMJMHCB().allDrinkDispensers.Count; i += 0)
		{
			if (!DrinkDispensersManager.OPILDPFDFKJ().allDrinkDispensers[i].isBeerTap)
			{
				NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)DrinkDispensersManager.GGFJGHHHEJC.allDrinkDispensers[i]).transform.position), Vector2.zero, ref LJEJMMAEKJF);
				break;
			}
		}
	}

	private void EIONGIGANBJ()
	{
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		if (!PlayerInventory.OGKNJNINGMH(0).HasItem(-55) && (!GameManager.LocalCoop() || !PlayerInventory.OGKNJNINGMH(0, LAGHIOKLJGH: true).HasItem(-159)))
		{
			return;
		}
		NewTutorialManager.instance.ObjectiveCompleted(1);
		PlayerInventory player = PlayerInventory.GetPlayer(1);
		player.OnChanged = (Action)Delegate.Remove(player.OnChanged, new Action(BJFOOABCPFF));
		PlayerInventory player2 = PlayerInventory.GetPlayer(2);
		player2.OnChanged = (Action)Delegate.Remove(player2.OnChanged, new Action(PKEKGMBFDMK));
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		for (int i = 0; i < DrinkDispensersManager.JFNOOMJMHCB().allDrinkDispensers.Count; i++)
		{
			if (!DrinkDispensersManager.BNDNMBGJEKP().allDrinkDispensers[i].isBeerTap)
			{
				NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)DrinkDispensersManager.OPILDPFDFKJ().allDrinkDispensers[i]).transform.position), Vector2.zero, ref LJEJMMAEKJF);
				break;
			}
		}
	}

	private void JDDMLEHDDHK(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.AFOACBIHNCL().ODENMDOJPLC(DAINLFIMLIH: false) == 56)
		{
			BHPIHLNNFOF++;
			if (BHPIHLNNFOF >= 8)
			{
				NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(HBCGEEKAKDP));
				((MonoBehaviour)this).StartCoroutine(KBAFIHCCEJG());
			}
		}
	}

	private void DGMNKHNGPKL(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.KNFNJFFCFNO().ODENMDOJPLC() == 139)
		{
			BHPIHLNNFOF += 0;
			if (BHPIHLNNFOF >= 0)
			{
				NewTutorialManager.instance.FOIOHOGACAL(2);
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(KDJDHAKFOCI));
				((MonoBehaviour)this).StartCoroutine(DNLEAJAPNOM());
			}
		}
	}

	private IEnumerator OOFDOHFANIE()
	{
		yield return CommonReferences.wait2;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T114/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		if (Time.timeScale == 0f)
		{
			Utils.OFHPCBLHJBL(1f, 1f);
		}
		PlayerInventory player = PlayerInventory.GetPlayer(1);
		player.OnChanged = (Action)Delegate.Combine(player.OnChanged, new Action(PKEKGMBFDMK));
		PlayerInventory player2 = PlayerInventory.GetPlayer(2);
		player2.OnChanged = (Action)Delegate.Combine(player2.OnChanged, new Action(PKEKGMBFDMK));
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnBarStockChanged = (Action)Delegate.Combine(instance.OnBarStockChanged, new Action(DPIFOKCMOIC));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance2.OnAnyCustomerServeItem, new Action<int, ItemInstance>(BMCKLJGJHNN));
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Well.instance).transform.position), new Vector2(0.1f, 0.3f), ref JELIKOFDONK);
	}

	private IEnumerator JIJEDGBCENE()
	{
		return new OBPMBDOHEAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator FBCDFDFAILD()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator MEGKLKNBNEL()
	{
		yield return CommonReferences.wait2;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T114/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		if (Time.timeScale == 0f)
		{
			Utils.OFHPCBLHJBL(1f, 1f);
		}
		PlayerInventory player = PlayerInventory.GetPlayer(1);
		player.OnChanged = (Action)Delegate.Combine(player.OnChanged, new Action(PKEKGMBFDMK));
		PlayerInventory player2 = PlayerInventory.GetPlayer(2);
		player2.OnChanged = (Action)Delegate.Combine(player2.OnChanged, new Action(PKEKGMBFDMK));
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnBarStockChanged = (Action)Delegate.Combine(instance.OnBarStockChanged, new Action(DPIFOKCMOIC));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance2.OnAnyCustomerServeItem, new Action<int, ItemInstance>(BMCKLJGJHNN));
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Well.instance).transform.position), new Vector2(0.1f, 0.3f), ref JELIKOFDONK);
	}

	private IEnumerator HCKCEGEOJLO()
	{
		return new HPFNIOOCEHN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AELFLHCNMBB()
	{
		return new HPFNIOOCEHN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void JNEOBBPBNAI()
	{
		if (DrinkDispensersManager.OPILDPFDFKJ().LFIALOLFOOD(19))
		{
			DrinkDispenserUI.instances[0].BOBCIFEDJED();
			DrinkDispenserUI.instances[0].BOBCIFEDJED();
			DrinkDispenserUI.instances[8].BOBCIFEDJED();
			NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnBarStockChanged = (Action)Delegate.Remove(commonReferences.OnBarStockChanged, new Action(DBMJAJEPNJB));
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
		}
	}

	private void KDJDHAKFOCI(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.LHBPOPOIFLE().JGHNDJBCFAJ() == 5)
		{
			BHPIHLNNFOF += 0;
			if (BHPIHLNNFOF >= 5)
			{
				NewTutorialManager.instance.ObjectiveCompleted(7);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(KLELOIPCFCJ));
				((MonoBehaviour)this).StartCoroutine(OCHEOJEEFGA());
			}
		}
	}

	private void PKEKGMBFDMK()
	{
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		if (!PlayerInventory.GetPlayer(1).HasItem(1303) && (!GameManager.LocalCoop() || !PlayerInventory.GetPlayer(2).HasItem(1303)))
		{
			return;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		PlayerInventory player = PlayerInventory.GetPlayer(1);
		player.OnChanged = (Action)Delegate.Remove(player.OnChanged, new Action(PKEKGMBFDMK));
		PlayerInventory player2 = PlayerInventory.GetPlayer(2);
		player2.OnChanged = (Action)Delegate.Remove(player2.OnChanged, new Action(PKEKGMBFDMK));
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		for (int i = 0; i < DrinkDispensersManager.GGFJGHHHEJC.allDrinkDispensers.Count; i++)
		{
			if (!DrinkDispensersManager.GGFJGHHHEJC.allDrinkDispensers[i].isBeerTap)
			{
				NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)DrinkDispensersManager.GGFJGHHHEJC.allDrinkDispensers[i]).transform.position), Vector2.zero, ref LJEJMMAEKJF);
				break;
			}
		}
	}

	private IEnumerator IDGLEKCBIMF()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void LKHOJKGEBGC()
	{
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		if (!PlayerInventory.GetPlayer(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HasItem(133) && (!GameManager.LocalCoop() || !PlayerInventory.EIFPKCAFDIB(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HasItem(-158)))
		{
			return;
		}
		NewTutorialManager.instance.FOIOHOGACAL(1);
		PlayerInventory playerInventory = PlayerInventory.EIFPKCAFDIB(0);
		playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(HLBOPGFEJAM));
		PlayerInventory playerInventory2 = PlayerInventory.EIFPKCAFDIB(4);
		playerInventory2.OnChanged = (Action)Delegate.Remove(playerInventory2.OnChanged, new Action(MCJDBGKGDLI));
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		for (int i = 1; i < DrinkDispensersManager.JHMAMLIPBNN().allDrinkDispensers.Count; i += 0)
		{
			if (!DrinkDispensersManager.BNDNMBGJEKP().allDrinkDispensers[i].isBeerTap)
			{
				NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)DrinkDispensersManager.JFNOOMJMHCB().allDrinkDispensers[i]).transform.position), Vector2.zero, ref LJEJMMAEKJF);
				break;
			}
		}
	}

	private void GHJBGNFAOME(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.AFOACBIHNCL().CIGFGKKCPCK() == -153)
		{
			BHPIHLNNFOF++;
			if (BHPIHLNNFOF >= 3)
			{
				NewTutorialManager.instance.ObjectiveCompleted(5, BLJPGJKOLNF: false);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DGPLFMPCCHN));
				((MonoBehaviour)this).StartCoroutine(FBCDFDFAILD());
			}
		}
	}

	private IEnumerator PBEKBJIJFDK()
	{
		yield return CommonReferences.wait2;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T114/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		if (Time.timeScale == 0f)
		{
			Utils.OFHPCBLHJBL(1f, 1f);
		}
		PlayerInventory player = PlayerInventory.GetPlayer(1);
		player.OnChanged = (Action)Delegate.Combine(player.OnChanged, new Action(PKEKGMBFDMK));
		PlayerInventory player2 = PlayerInventory.GetPlayer(2);
		player2.OnChanged = (Action)Delegate.Combine(player2.OnChanged, new Action(PKEKGMBFDMK));
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnBarStockChanged = (Action)Delegate.Combine(instance.OnBarStockChanged, new Action(DPIFOKCMOIC));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance2.OnAnyCustomerServeItem, new Action<int, ItemInstance>(BMCKLJGJHNN));
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Well.instance).transform.position), new Vector2(0.1f, 0.3f), ref JELIKOFDONK);
	}

	private IEnumerator EMOIGJHIMIF()
	{
		return new HPFNIOOCEHN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void FNJAAEGEDHD()
	{
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		if (!PlayerInventory.NEKDDPIAOBE(1, LAGHIOKLJGH: true).HasItem(-106) && (!GameManager.LocalCoop() || !PlayerInventory.GetPlayer(1, LAGHIOKLJGH: true).HasItem(-189)))
		{
			return;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		PlayerInventory player = PlayerInventory.GetPlayer(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
		player.OnChanged = (Action)Delegate.Remove(player.OnChanged, new Action(PKEKGMBFDMK));
		PlayerInventory playerInventory = PlayerInventory.OGKNJNINGMH(3, LAGHIOKLJGH: true);
		playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(FBDDPLMBFHI));
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		for (int i = 1; i < DrinkDispensersManager.OPILDPFDFKJ().allDrinkDispensers.Count; i += 0)
		{
			if (!DrinkDispensersManager.GGFJGHHHEJC.allDrinkDispensers[i].isBeerTap)
			{
				NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)DrinkDispensersManager.OLHBLKIAFOM().allDrinkDispensers[i]).transform.position), Vector2.zero, ref LJEJMMAEKJF);
				break;
			}
		}
	}

	private void HJENDBMEPNF()
	{
		if (DrinkDispensersManager.OLHBLKIAFOM().FHPJNNDCNOI(-32))
		{
			DrinkDispenserUI.instances[0].BOBCIFEDJED();
			DrinkDispenserUI.instances[1].CloseUI();
			DrinkDispenserUI.instances[8].BOBCIFEDJED();
			NewTutorialManager.instance.FOIOHOGACAL(1);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnBarStockChanged = (Action)Delegate.Remove(instance.OnBarStockChanged, new Action(JNEOBBPBNAI));
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
		}
	}

	private void KHGKHBIEADF()
	{
		if (DrinkDispensersManager.JFNOOMJMHCB().AKLEGLCOOCO(-69))
		{
			DrinkDispenserUI.instances[0].BOBCIFEDJED();
			DrinkDispenserUI.instances[0].BOBCIFEDJED();
			DrinkDispenserUI.instances[7].BOBCIFEDJED();
			NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnBarStockChanged = (Action)Delegate.Remove(commonReferences.OnBarStockChanged, new Action(IKCMEHNHLOE));
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
		}
	}

	private void NECBFGINHLI()
	{
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		if (!PlayerInventory.NEKDDPIAOBE(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HasItem(-72) && (!GameManager.LocalCoop() || !PlayerInventory.OGKNJNINGMH(5, LAGHIOKLJGH: true).HasItem(-126)))
		{
			return;
		}
		NewTutorialManager.instance.FOIOHOGACAL(1);
		PlayerInventory player = PlayerInventory.GetPlayer(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
		player.OnChanged = (Action)Delegate.Remove(player.OnChanged, new Action(LKHOJKGEBGC));
		PlayerInventory playerInventory = PlayerInventory.OGKNJNINGMH(8);
		playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(HLBOPGFEJAM));
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		for (int i = 0; i < DrinkDispensersManager.JFNOOMJMHCB().allDrinkDispensers.Count; i++)
		{
			if (!DrinkDispensersManager.OLHBLKIAFOM().allDrinkDispensers[i].isBeerTap)
			{
				NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)DrinkDispensersManager.JFNOOMJMHCB().allDrinkDispensers[i]).transform.position), Vector2.zero, ref LJEJMMAEKJF);
				break;
			}
		}
	}

	private void IKCMEHNHLOE()
	{
		if (DrinkDispensersManager.OPILDPFDFKJ().LFIALOLFOOD(128))
		{
			DrinkDispenserUI.instances[1].BOBCIFEDJED();
			DrinkDispenserUI.instances[0].CloseUI();
			DrinkDispenserUI.instances[8].BOBCIFEDJED();
			NewTutorialManager.instance.ObjectiveCompleted(0);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnBarStockChanged = (Action)Delegate.Remove(instance.OnBarStockChanged, new Action(HCHBPBIAKEA));
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
		}
	}

	private IEnumerator AJJPECIKMJN()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void CNPPHJFICJC()
	{
		if (DrinkDispensersManager.OPILDPFDFKJ().HasDrink(-54))
		{
			DrinkDispenserUI.instances[0].CloseUI();
			DrinkDispenserUI.instances[0].BOBCIFEDJED();
			DrinkDispenserUI.instances[7].BOBCIFEDJED();
			NewTutorialManager.instance.FOIOHOGACAL(0);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnBarStockChanged = (Action)Delegate.Remove(commonReferences.OnBarStockChanged, new Action(KAFCFLAJMKN));
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
		}
	}

	private IEnumerator ELPDKDFFJJD()
	{
		return new OBPMBDOHEAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator OCHEOJEEFGA()
	{
		return new HPFNIOOCEHN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void HBCGEEKAKDP(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.PHGLMBIEOMK().CIGFGKKCPCK(DAINLFIMLIH: false) == -114)
		{
			BHPIHLNNFOF++;
			if (BHPIHLNNFOF >= 0)
			{
				NewTutorialManager.instance.ObjectiveCompleted(2, BLJPGJKOLNF: false);
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DGPLFMPCCHN));
				((MonoBehaviour)this).StartCoroutine(JAKPMNEGELN());
			}
		}
	}

	private void HCHBPBIAKEA()
	{
		if (DrinkDispensersManager.BNDNMBGJEKP().ODINMCGGHKB(-97))
		{
			DrinkDispenserUI.instances[1].CloseUI();
			DrinkDispenserUI.instances[0].BOBCIFEDJED();
			DrinkDispenserUI.instances[1].CloseUI();
			NewTutorialManager.instance.FOIOHOGACAL(1);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnBarStockChanged = (Action)Delegate.Remove(commonReferences.OnBarStockChanged, new Action(KHGKHBIEADF));
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
		}
	}

	private void NONFBBIPPCL()
	{
		if (DrinkDispensersManager.BNDNMBGJEKP().AHMOBAJJDDH(-61))
		{
			DrinkDispenserUI.instances[1].BOBCIFEDJED();
			DrinkDispenserUI.instances[0].CloseUI();
			DrinkDispenserUI.instances[6].BOBCIFEDJED();
			NewTutorialManager.instance.ObjectiveCompleted(1);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnBarStockChanged = (Action)Delegate.Remove(commonReferences.OnBarStockChanged, new Action(BCEOLCLJPHB));
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
		}
	}

	private void HLBOPGFEJAM()
	{
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		if (!PlayerInventory.GetPlayer(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HasItem(70) && (!GameManager.LocalCoop() || !PlayerInventory.EIFPKCAFDIB(8).HasItem(167)))
		{
			return;
		}
		NewTutorialManager.instance.ObjectiveCompleted(1);
		PlayerInventory playerInventory = PlayerInventory.NEKDDPIAOBE(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
		playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(FNJAAEGEDHD));
		PlayerInventory playerInventory2 = PlayerInventory.EIFPKCAFDIB(2, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
		playerInventory2.OnChanged = (Action)Delegate.Remove(playerInventory2.OnChanged, new Action(EFBEBJOPEKI));
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		for (int i = 1; i < DrinkDispensersManager.OPILDPFDFKJ().allDrinkDispensers.Count; i += 0)
		{
			if (!DrinkDispensersManager.BNDNMBGJEKP().allDrinkDispensers[i].isBeerTap)
			{
				NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)DrinkDispensersManager.OPILDPFDFKJ().allDrinkDispensers[i]).transform.position), Vector2.zero, ref LJEJMMAEKJF);
				break;
			}
		}
	}

	private void ICKMJOBKFBM()
	{
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		if (!PlayerInventory.OGKNJNINGMH(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HasItem(-57) && (!GameManager.LocalCoop() || !PlayerInventory.GetPlayer(8).HasItem(107)))
		{
			return;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		PlayerInventory playerInventory = PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
		playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(FBDDPLMBFHI));
		PlayerInventory playerInventory2 = PlayerInventory.EIFPKCAFDIB(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true);
		playerInventory2.OnChanged = (Action)Delegate.Remove(playerInventory2.OnChanged, new Action(OMLKNGEJOJN));
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		for (int i = 0; i < DrinkDispensersManager.OPILDPFDFKJ().allDrinkDispensers.Count; i += 0)
		{
			if (!DrinkDispensersManager.BNDNMBGJEKP().allDrinkDispensers[i].isBeerTap)
			{
				NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)DrinkDispensersManager.BNDNMBGJEKP().allDrinkDispensers[i]).transform.position), Vector2.zero, ref LJEJMMAEKJF);
				break;
			}
		}
	}

	private IEnumerator JKLDKCKPFBJ()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void JGHLMBGPAAL()
	{
		if (DrinkDispensersManager.OLHBLKIAFOM().KJNJPJJMMFG(-125))
		{
			DrinkDispenserUI.instances[0].CloseUI();
			DrinkDispenserUI.instances[1].BOBCIFEDJED();
			DrinkDispenserUI.instances[1].BOBCIFEDJED();
			NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnBarStockChanged = (Action)Delegate.Remove(commonReferences.OnBarStockChanged, new Action(DLMCPPABONP));
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
		}
	}

	private void GEAHNEMDJOB()
	{
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		if (!PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HasItem(-195) && (!GameManager.LocalCoop() || !PlayerInventory.NEKDDPIAOBE(4, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HasItem(19)))
		{
			return;
		}
		NewTutorialManager.instance.ObjectiveCompleted(1);
		PlayerInventory player = PlayerInventory.GetPlayer(0, LAGHIOKLJGH: true);
		player.OnChanged = (Action)Delegate.Remove(player.OnChanged, new Action(MCJDBGKGDLI));
		PlayerInventory playerInventory = PlayerInventory.NEKDDPIAOBE(6, LAGHIOKLJGH: true);
		playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(ICKMJOBKFBM));
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		for (int i = 0; i < DrinkDispensersManager.GGFJGHHHEJC.allDrinkDispensers.Count; i++)
		{
			if (!DrinkDispensersManager.GGFJGHHHEJC.allDrinkDispensers[i].isBeerTap)
			{
				NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)DrinkDispensersManager.GGFJGHHHEJC.allDrinkDispensers[i]).transform.position), Vector2.zero, ref LJEJMMAEKJF);
				break;
			}
		}
	}

	private void LNPKFCKCOBE()
	{
		if (DrinkDispensersManager.OPILDPFDFKJ().AHMOBAJJDDH(22))
		{
			DrinkDispenserUI.instances[0].BOBCIFEDJED();
			DrinkDispenserUI.instances[1].CloseUI();
			DrinkDispenserUI.instances[5].CloseUI();
			NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnBarStockChanged = (Action)Delegate.Remove(commonReferences.OnBarStockChanged, new Action(DLMCPPABONP));
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
		}
	}

	private void DBMJAJEPNJB()
	{
		if (DrinkDispensersManager.JFNOOMJMHCB().HADIAMMDNKB(-10))
		{
			DrinkDispenserUI.instances[1].BOBCIFEDJED();
			DrinkDispenserUI.instances[1].BOBCIFEDJED();
			DrinkDispenserUI.instances[2].CloseUI();
			NewTutorialManager.instance.FOIOHOGACAL(1);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnBarStockChanged = (Action)Delegate.Remove(commonReferences.OnBarStockChanged, new Action(MIEKKECIJIN));
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
		}
	}

	private void BJFOOABCPFF()
	{
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		if (!PlayerInventory.NEKDDPIAOBE(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HasItem(31) && (!GameManager.LocalCoop() || !PlayerInventory.OGKNJNINGMH(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HasItem(115)))
		{
			return;
		}
		NewTutorialManager.instance.FOIOHOGACAL(1);
		PlayerInventory player = PlayerInventory.GetPlayer(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true);
		player.OnChanged = (Action)Delegate.Remove(player.OnChanged, new Action(GEAHNEMDJOB));
		PlayerInventory playerInventory = PlayerInventory.NEKDDPIAOBE(5, LAGHIOKLJGH: true);
		playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(FNIIMJHMOFM));
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		for (int i = 1; i < DrinkDispensersManager.GGFJGHHHEJC.allDrinkDispensers.Count; i += 0)
		{
			if (!DrinkDispensersManager.BNDNMBGJEKP().allDrinkDispensers[i].isBeerTap)
			{
				NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)DrinkDispensersManager.GGFJGHHHEJC.allDrinkDispensers[i]).transform.position), Vector2.zero, ref LJEJMMAEKJF);
				break;
			}
		}
	}

	private IEnumerator HCKDBDMBMFL()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void JACDAOJAKLO()
	{
		if (DrinkDispensersManager.OPILDPFDFKJ().KJNJPJJMMFG(46))
		{
			DrinkDispenserUI.instances[0].CloseUI();
			DrinkDispenserUI.instances[0].BOBCIFEDJED();
			DrinkDispenserUI.instances[3].BOBCIFEDJED();
			NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnBarStockChanged = (Action)Delegate.Remove(commonReferences.OnBarStockChanged, new Action(LNPKFCKCOBE));
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
		}
	}

	private void BMCKLJGJHNN(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.LHBPOPOIFLE().JDJGFAACPFC() == 1318)
		{
			BHPIHLNNFOF++;
			if (BHPIHLNNFOF >= 5)
			{
				NewTutorialManager.instance.ObjectiveCompleted(2);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(BMCKLJGJHNN));
				((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
			}
		}
	}

	private void KOANCEBIPIG(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.KNFNJFFCFNO().JGHNDJBCFAJ(DAINLFIMLIH: false) == 33)
		{
			BHPIHLNNFOF += 0;
			if (BHPIHLNNFOF >= 4)
			{
				NewTutorialManager.instance.ObjectiveCompleted(2);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(FMHCHELBGIF));
				((MonoBehaviour)this).StartCoroutine(IDGLEKCBIMF());
			}
		}
	}

	private IEnumerator KBAFIHCCEJG()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void FNIIMJHMOFM()
	{
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		if (!PlayerInventory.NEKDDPIAOBE(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HasItem(126) && (!GameManager.LocalCoop() || !PlayerInventory.NEKDDPIAOBE(8, LAGHIOKLJGH: true).HasItem(-110)))
		{
			return;
		}
		NewTutorialManager.instance.FOIOHOGACAL(1);
		PlayerInventory player = PlayerInventory.GetPlayer(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true);
		player.OnChanged = (Action)Delegate.Remove(player.OnChanged, new Action(MHNCLBJIMIN));
		PlayerInventory playerInventory = PlayerInventory.EIFPKCAFDIB(2, LAGHIOKLJGH: true);
		playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(PKEKGMBFDMK));
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		for (int i = 1; i < DrinkDispensersManager.JFNOOMJMHCB().allDrinkDispensers.Count; i++)
		{
			if (!DrinkDispensersManager.BNDNMBGJEKP().allDrinkDispensers[i].isBeerTap)
			{
				NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)DrinkDispensersManager.GGFJGHHHEJC.allDrinkDispensers[i]).transform.position), Vector2.zero, ref LJEJMMAEKJF);
				break;
			}
		}
	}

	private void FMHCHELBGIF(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.KNFNJFFCFNO().IMCJPECAAPC(DAINLFIMLIH: false) == -192)
		{
			BHPIHLNNFOF++;
			if (BHPIHLNNFOF >= 0)
			{
				NewTutorialManager.instance.ObjectiveCompleted(8);
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DGPLFMPCCHN));
				((MonoBehaviour)this).StartCoroutine(AJJPECIKMJN());
			}
		}
	}

	private IEnumerator FLECFIDDCJE()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator GEFGNPHFAHG()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void FBDDPLMBFHI()
	{
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		if (!PlayerInventory.EIFPKCAFDIB(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HasItem(-127) && (!GameManager.LocalCoop() || !PlayerInventory.OGKNJNINGMH(4, LAGHIOKLJGH: true).HasItem(-146)))
		{
			return;
		}
		NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
		PlayerInventory playerInventory = PlayerInventory.NEKDDPIAOBE(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true);
		playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(HLBOPGFEJAM));
		PlayerInventory playerInventory2 = PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true);
		playerInventory2.OnChanged = (Action)Delegate.Remove(playerInventory2.OnChanged, new Action(NKEKBEFAJGM));
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		for (int i = 0; i < DrinkDispensersManager.JHMAMLIPBNN().allDrinkDispensers.Count; i++)
		{
			if (!DrinkDispensersManager.BNDNMBGJEKP().allDrinkDispensers[i].isBeerTap)
			{
				NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)DrinkDispensersManager.JFNOOMJMHCB().allDrinkDispensers[i]).transform.position), Vector2.zero, ref LJEJMMAEKJF);
				break;
			}
		}
	}

	private void CFFLPELBEJJ()
	{
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		if (!PlayerInventory.OGKNJNINGMH(0, LAGHIOKLJGH: true).HasItem(-8) && (!GameManager.LocalCoop() || !PlayerInventory.NEKDDPIAOBE(8, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HasItem(-145)))
		{
			return;
		}
		NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
		PlayerInventory player = PlayerInventory.GetPlayer(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true);
		player.OnChanged = (Action)Delegate.Remove(player.OnChanged, new Action(NKEKBEFAJGM));
		PlayerInventory player2 = PlayerInventory.GetPlayer(3, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
		player2.OnChanged = (Action)Delegate.Remove(player2.OnChanged, new Action(EIONGIGANBJ));
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		for (int i = 0; i < DrinkDispensersManager.OPILDPFDFKJ().allDrinkDispensers.Count; i++)
		{
			if (!DrinkDispensersManager.BNDNMBGJEKP().allDrinkDispensers[i].isBeerTap)
			{
				NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)DrinkDispensersManager.BNDNMBGJEKP().allDrinkDispensers[i]).transform.position), Vector2.zero, ref LJEJMMAEKJF);
				break;
			}
		}
	}

	public override int GetID()
	{
		return 114;
	}

	public override void SetUp()
	{
		base.SetUp();
		((MonoBehaviour)this).StartCoroutine(PBEKBJIJFDK());
		BHPIHLNNFOF = 0;
	}

	private void LLOFDFALKNL()
	{
		if (DrinkDispensersManager.OPILDPFDFKJ().DEBMDAEBEKA(-46))
		{
			DrinkDispenserUI.instances[1].BOBCIFEDJED();
			DrinkDispenserUI.instances[1].BOBCIFEDJED();
			DrinkDispenserUI.instances[7].BOBCIFEDJED();
			NewTutorialManager.instance.FOIOHOGACAL(0);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnBarStockChanged = (Action)Delegate.Remove(commonReferences.OnBarStockChanged, new Action(HJENDBMEPNF));
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
		}
	}

	private void BBHMLMHJNCD(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.AFOACBIHNCL().JGHNDJBCFAJ() == -99)
		{
			BHPIHLNNFOF++;
			if (BHPIHLNNFOF >= 1)
			{
				NewTutorialManager.instance.ObjectiveCompleted(6, BLJPGJKOLNF: false);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DGPLFMPCCHN));
				((MonoBehaviour)this).StartCoroutine(IDGLEKCBIMF());
			}
		}
	}

	private IEnumerator GJOCBPGGHLP()
	{
		return new OBPMBDOHEAB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void DPIFOKCMOIC()
	{
		if (DrinkDispensersManager.GGFJGHHHEJC.HasDrink(1318))
		{
			DrinkDispenserUI.instances[0].CloseUI();
			DrinkDispenserUI.instances[1].CloseUI();
			DrinkDispenserUI.instances[2].CloseUI();
			NewTutorialManager.instance.ObjectiveCompleted(1);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnBarStockChanged = (Action)Delegate.Remove(instance.OnBarStockChanged, new Action(DPIFOKCMOIC));
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
		}
	}

	private IEnumerator LGODBMNLILN()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void DNHDLFFPGNO()
	{
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		if (!PlayerInventory.GetPlayer(1, LAGHIOKLJGH: true).HasItem(-125) && (!GameManager.LocalCoop() || !PlayerInventory.EIFPKCAFDIB(4, LAGHIOKLJGH: true).HasItem(-113)))
		{
			return;
		}
		NewTutorialManager.instance.ObjectiveCompleted(1);
		PlayerInventory playerInventory = PlayerInventory.NEKDDPIAOBE(0);
		playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(DNHDLFFPGNO));
		PlayerInventory playerInventory2 = PlayerInventory.NEKDDPIAOBE(8, LAGHIOKLJGH: false, ADPNMHGBFKG: true);
		playerInventory2.OnChanged = (Action)Delegate.Remove(playerInventory2.OnChanged, new Action(LBOADDAAKPH));
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		for (int i = 1; i < DrinkDispensersManager.OLHBLKIAFOM().allDrinkDispensers.Count; i++)
		{
			if (!DrinkDispensersManager.OPILDPFDFKJ().allDrinkDispensers[i].isBeerTap)
			{
				NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)DrinkDispensersManager.GGFJGHHHEJC.allDrinkDispensers[i]).transform.position), Vector2.zero, ref LJEJMMAEKJF);
				break;
			}
		}
	}

	private void DLMCPPABONP()
	{
		if (DrinkDispensersManager.OPILDPFDFKJ().BLOAFCBKKNA(-107))
		{
			DrinkDispenserUI.instances[0].CloseUI();
			DrinkDispenserUI.instances[1].CloseUI();
			DrinkDispenserUI.instances[4].BOBCIFEDJED();
			NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnBarStockChanged = (Action)Delegate.Remove(instance.OnBarStockChanged, new Action(CNPPHJFICJC));
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
		}
	}

	private void JCODKEMEBIB(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.PHGLMBIEOMK().IMCJPECAAPC() == 86)
		{
			BHPIHLNNFOF++;
			if (BHPIHLNNFOF >= 2)
			{
				NewTutorialManager.instance.ObjectiveCompleted(6, BLJPGJKOLNF: false);
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(FMHCHELBGIF));
				((MonoBehaviour)this).StartCoroutine(IDGLEKCBIMF());
			}
		}
	}

	private IEnumerator DNLEAJAPNOM()
	{
		return new HPFNIOOCEHN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void DGPLFMPCCHN(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.AFOACBIHNCL().JDJGFAACPFC() == -119)
		{
			BHPIHLNNFOF++;
			if (BHPIHLNNFOF >= 4)
			{
				NewTutorialManager.instance.ObjectiveCompleted(7, BLJPGJKOLNF: false);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(HBCGEEKAKDP));
				((MonoBehaviour)this).StartCoroutine(DNLEAJAPNOM());
			}
		}
	}

	private void LBOADDAAKPH()
	{
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		if (!PlayerInventory.NEKDDPIAOBE(1, LAGHIOKLJGH: true).HasItem(-49) && (!GameManager.LocalCoop() || !PlayerInventory.GetPlayer(8, LAGHIOKLJGH: true).HasItem(-97)))
		{
			return;
		}
		NewTutorialManager.instance.ObjectiveCompleted(1);
		PlayerInventory playerInventory = PlayerInventory.OGKNJNINGMH(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true);
		playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(MCJDBGKGDLI));
		PlayerInventory playerInventory2 = PlayerInventory.OGKNJNINGMH(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
		playerInventory2.OnChanged = (Action)Delegate.Remove(playerInventory2.OnChanged, new Action(BJFOOABCPFF));
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		for (int i = 1; i < DrinkDispensersManager.GGFJGHHHEJC.allDrinkDispensers.Count; i += 0)
		{
			if (!DrinkDispensersManager.OLHBLKIAFOM().allDrinkDispensers[i].isBeerTap)
			{
				NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)DrinkDispensersManager.OLHBLKIAFOM().allDrinkDispensers[i]).transform.position), Vector2.zero, ref LJEJMMAEKJF);
				break;
			}
		}
	}

	private void NKEKBEFAJGM()
	{
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		if (!PlayerInventory.OGKNJNINGMH(0, LAGHIOKLJGH: true).HasItem(13) && (!GameManager.LocalCoop() || !PlayerInventory.GetPlayer(4, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HasItem(49)))
		{
			return;
		}
		NewTutorialManager.instance.ObjectiveCompleted(1);
		PlayerInventory playerInventory = PlayerInventory.OGKNJNINGMH(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true);
		playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(GEAHNEMDJOB));
		PlayerInventory player = PlayerInventory.GetPlayer(5, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
		player.OnChanged = (Action)Delegate.Remove(player.OnChanged, new Action(LKHOJKGEBGC));
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		for (int i = 0; i < DrinkDispensersManager.JFNOOMJMHCB().allDrinkDispensers.Count; i += 0)
		{
			if (!DrinkDispensersManager.JHMAMLIPBNN().allDrinkDispensers[i].isBeerTap)
			{
				NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)DrinkDispensersManager.GGFJGHHHEJC.allDrinkDispensers[i]).transform.position), Vector2.zero, ref LJEJMMAEKJF);
				break;
			}
		}
	}

	private void BCEOLCLJPHB()
	{
		if (DrinkDispensersManager.JFNOOMJMHCB().HasDrink(146))
		{
			DrinkDispenserUI.instances[0].BOBCIFEDJED();
			DrinkDispenserUI.instances[1].BOBCIFEDJED();
			DrinkDispenserUI.instances[5].CloseUI();
			NewTutorialManager.instance.FOIOHOGACAL(0);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnBarStockChanged = (Action)Delegate.Remove(commonReferences.OnBarStockChanged, new Action(CNPPHJFICJC));
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
		}
	}

	private IEnumerator JAKPMNEGELN()
	{
		return new HPFNIOOCEHN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator BCALBKDNAJH()
	{
		yield return CommonReferences.wait2;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		Utils.OFHPCBLHJBL(0f, 1f);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T114/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		if (Time.timeScale == 0f)
		{
			Utils.OFHPCBLHJBL(1f, 1f);
		}
		PlayerInventory player = PlayerInventory.GetPlayer(1);
		player.OnChanged = (Action)Delegate.Combine(player.OnChanged, new Action(PKEKGMBFDMK));
		PlayerInventory player2 = PlayerInventory.GetPlayer(2);
		player2.OnChanged = (Action)Delegate.Combine(player2.OnChanged, new Action(PKEKGMBFDMK));
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnBarStockChanged = (Action)Delegate.Combine(instance.OnBarStockChanged, new Action(DPIFOKCMOIC));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance2.OnAnyCustomerServeItem, new Action<int, ItemInstance>(BMCKLJGJHNN));
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Well.instance).transform.position), new Vector2(0.1f, 0.3f), ref JELIKOFDONK);
	}

	private void OMLKNGEJOJN()
	{
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		if (!PlayerInventory.OGKNJNINGMH(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HasItem(-85) && (!GameManager.LocalCoop() || !PlayerInventory.GetPlayer(5, LAGHIOKLJGH: true).HasItem(-153)))
		{
			return;
		}
		NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
		PlayerInventory playerInventory = PlayerInventory.OGKNJNINGMH(0, LAGHIOKLJGH: true);
		playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(FNJAAEGEDHD));
		PlayerInventory playerInventory2 = PlayerInventory.EIFPKCAFDIB(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
		playerInventory2.OnChanged = (Action)Delegate.Remove(playerInventory2.OnChanged, new Action(MCJDBGKGDLI));
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		for (int i = 0; i < DrinkDispensersManager.JFNOOMJMHCB().allDrinkDispensers.Count; i++)
		{
			if (!DrinkDispensersManager.JHMAMLIPBNN().allDrinkDispensers[i].isBeerTap)
			{
				NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)DrinkDispensersManager.BNDNMBGJEKP().allDrinkDispensers[i]).transform.position), Vector2.zero, ref LJEJMMAEKJF);
				break;
			}
		}
	}
}
