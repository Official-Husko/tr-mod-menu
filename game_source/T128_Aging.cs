using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class T128_Aging : TutorialPhaseBase
{
	[CompilerGenerated]
	private sealed class DGLKKCEIHKP : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T128_Aging _003C_003E4__this;

		public ItemInstance item;

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
		public DGLKKCEIHKP(int _003C_003E1__state)
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
			T128_Aging t128_Aging = _003C_003E4__this;
			switch (num)
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
				if (GameManager.LocalCoop())
				{
					if (!t128_Aging.IHBDMEEDDIK && item.LHBPOPOIFLE().JDJGFAACPFC() == 12 && !PlayerInventory.GetPlayer(1).HasItem(ItemDatabaseAccessor.GetItem(12)) && !PlayerInventory.GetPlayer(2).HasItem(ItemDatabaseAccessor.GetItem(12)))
					{
						t128_Aging.IHBDMEEDDIK = true;
						CommonReferences instance = CommonReferences.GGFJGHHHEJC;
						instance.OnAnyItemStartAging = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyItemStartAging, new Action<int, ItemInstance>(t128_Aging.HGMCIAOHPJK));
						AgingBarrelUI.instances[1].Close();
						AgingBarrelUI.instances[2].Close();
						NewTutorialManager.instance.ObjectiveCompleted(0);
						t128_Aging.LHKIJABBBPM();
						if ((Object)(object)t128_Aging.JELIKOFDONK != (Object)null)
						{
							Object.Destroy((Object)(object)t128_Aging.JELIKOFDONK);
						}
						if ((Object)(object)t128_Aging.LJEJMMAEKJF != (Object)null)
						{
							Object.Destroy((Object)(object)t128_Aging.LJEJMMAEKJF);
						}
					}
				}
				else if (!t128_Aging.IHBDMEEDDIK && item.LHBPOPOIFLE().JDJGFAACPFC() == 12 && !PlayerInventory.GetPlayer(1).HasItem(ItemDatabaseAccessor.GetItem(12)))
				{
					t128_Aging.IHBDMEEDDIK = true;
					CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
					instance2.OnAnyItemStartAging = (Action<int, ItemInstance>)Delegate.Remove(instance2.OnAnyItemStartAging, new Action<int, ItemInstance>(t128_Aging.HGMCIAOHPJK));
					AgingBarrelUI.instances[0].Close();
					NewTutorialManager.instance.ObjectiveCompleted(0);
					t128_Aging.LHKIJABBBPM();
					if ((Object)(object)t128_Aging.JELIKOFDONK != (Object)null)
					{
						Object.Destroy((Object)(object)t128_Aging.JELIKOFDONK);
					}
					if ((Object)(object)t128_Aging.LJEJMMAEKJF != (Object)null)
					{
						Object.Destroy((Object)(object)t128_Aging.LJEJMMAEKJF);
					}
				}
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

		public T128_Aging _003C_003E4__this;

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
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_013c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0141: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0206: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			T128_Aging t128_Aging = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
				NewTutorialManager.instance.agingBarrelBlocked = true;
				((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(11.83333f, 916.5f, 0f);
				_003C_003E2__current = CommonReferences.wait02;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
				MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
				goto IL_00cd;
			case 2:
				_003C_003E1__state = -1;
				goto IL_00cd;
			case 3:
				_003C_003E1__state = -1;
				NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 4;
				return true;
			case 4:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
				DialogueCameraTarget.GetPlayer(t128_Aging.triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
				MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T128/Dialogue1", t128_Aging.triggerPlayerNum);
				NewTutorialManager.instance.agingBarrelBlocked = false;
				goto IL_0187;
			case 5:
				_003C_003E1__state = -1;
				goto IL_0187;
			case 6:
				_003C_003E1__state = -1;
				NewTutorialManager.ShowPopUp();
				NewTutorialManager.instance.SpawnArrow(new Vector2(12f, 915f), Vector2.up * 0.1f, ref t128_Aging.JELIKOFDONK);
				NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)SceneReferences.GetSceneReferences().agingBarrel).transform.position), Vector2.up * 0.6f, ref t128_Aging.LJEJMMAEKJF);
				goto IL_022f;
			case 7:
				_003C_003E1__state = -1;
				goto IL_022f;
			case 8:
				{
					_003C_003E1__state = -1;
					break;
				}
				IL_022f:
				if (!t128_Aging.MLIHKNOAIFO())
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 7;
					return true;
				}
				MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T128/Dialogue2", t128_Aging.triggerPlayerNum);
				break;
				IL_00cd:
				if (!t128_Aging.CLJJAIEMOLN())
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 2;
					return true;
				}
				_003C_003E2__current = ((MonoBehaviour)t128_Aging).StartCoroutine(t128_Aging.CDICFNAMCEE());
				_003C_003E1__state = 3;
				return true;
				IL_0187:
				if (t128_Aging.AAOPIEDAKKD(1))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 5;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 6;
				return true;
			}
			if (t128_Aging.AAOPIEDAKKD(2))
			{
				_003C_003E2__current = null;
				_003C_003E1__state = 8;
				return true;
			}
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyItemStartAging = (Action<int, ItemInstance>)Delegate.Combine(instance.OnAnyItemStartAging, new Action<int, ItemInstance>(t128_Aging.HGMCIAOHPJK));
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

	private bool IHBDMEEDDIK;

	private void GHDPKAGNBND(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		((MonoBehaviour)this).StartCoroutine(APBEDNJGJDF(JIIGOACEIKL, MEMGMDOCBOJ));
	}

	private void BFEPJMOGECF(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		((MonoBehaviour)this).StartCoroutine(NEILABEGACO(JIIGOACEIKL, MEMGMDOCBOJ));
	}

	private IEnumerator APBEDNJGJDF(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		return new DGLKKCEIHKP(1)
		{
			_003C_003E4__this = this,
			item = MEMGMDOCBOJ
		};
	}

	private void GNLJOLGNNBE(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		((MonoBehaviour)this).StartCoroutine(GCGHAEAMLIJ(JIIGOACEIKL, MEMGMDOCBOJ));
	}

	private void DFAHOKAPKPG(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		((MonoBehaviour)this).StartCoroutine(GCGHAEAMLIJ(JIIGOACEIKL, MEMGMDOCBOJ));
	}

	private void FNPNIGLHJPE(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		((MonoBehaviour)this).StartCoroutine(APBEDNJGJDF(JIIGOACEIKL, MEMGMDOCBOJ));
	}

	private void GBBBGBECGDN(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		((MonoBehaviour)this).StartCoroutine(MEGFHFOENJC(JIIGOACEIKL, MEMGMDOCBOJ));
	}

	private IEnumerator OOFDOHFANIE()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	public override int GetID()
	{
		return 128;
	}

	private void PKHOJAMOFEN(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		((MonoBehaviour)this).StartCoroutine(PPGHDECKDAD(JIIGOACEIKL, MEMGMDOCBOJ));
	}

	private IEnumerator DIGIMPCLCCL()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator PPGHDECKDAD(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		yield return null;
		if (GameManager.LocalCoop())
		{
			if (!IHBDMEEDDIK && MEMGMDOCBOJ.LHBPOPOIFLE().JDJGFAACPFC() == 12 && !PlayerInventory.GetPlayer(1).HasItem(ItemDatabaseAccessor.GetItem(12)) && !PlayerInventory.GetPlayer(2).HasItem(ItemDatabaseAccessor.GetItem(12)))
			{
				IHBDMEEDDIK = true;
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyItemStartAging = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyItemStartAging, new Action<int, ItemInstance>(HGMCIAOHPJK));
				AgingBarrelUI.instances[1].Close();
				AgingBarrelUI.instances[2].Close();
				NewTutorialManager.instance.ObjectiveCompleted(0);
				LHKIJABBBPM();
				if ((Object)(object)JELIKOFDONK != (Object)null)
				{
					Object.Destroy((Object)(object)JELIKOFDONK);
				}
				if ((Object)(object)LJEJMMAEKJF != (Object)null)
				{
					Object.Destroy((Object)(object)LJEJMMAEKJF);
				}
			}
		}
		else if (!IHBDMEEDDIK && MEMGMDOCBOJ.LHBPOPOIFLE().JDJGFAACPFC() == 12 && !PlayerInventory.GetPlayer(1).HasItem(ItemDatabaseAccessor.GetItem(12)))
		{
			IHBDMEEDDIK = true;
			CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
			instance2.OnAnyItemStartAging = (Action<int, ItemInstance>)Delegate.Remove(instance2.OnAnyItemStartAging, new Action<int, ItemInstance>(HGMCIAOHPJK));
			AgingBarrelUI.instances[0].Close();
			NewTutorialManager.instance.ObjectiveCompleted(0);
			LHKIJABBBPM();
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
		}
	}

	private IEnumerator GJOCBPGGHLP()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		NewTutorialManager.instance.agingBarrelBlocked = true;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(11.83333f, 916.5f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait05;
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T128/Dialogue1", triggerPlayerNum);
		NewTutorialManager.instance.agingBarrelBlocked = false;
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.ShowPopUp();
		NewTutorialManager.instance.SpawnArrow(new Vector2(12f, 915f), Vector2.up * 0.1f, ref JELIKOFDONK);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)SceneReferences.GetSceneReferences().agingBarrel).transform.position), Vector2.up * 0.6f, ref LJEJMMAEKJF);
		while (!MLIHKNOAIFO())
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T128/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyItemStartAging = (Action<int, ItemInstance>)Delegate.Combine(instance.OnAnyItemStartAging, new Action<int, ItemInstance>(HGMCIAOHPJK));
	}

	public override void SetUp()
	{
		base.SetUp();
		((MonoBehaviour)this).StartCoroutine(PBEKBJIJFDK());
	}

	private IEnumerator AJOIEAICINP()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		NewTutorialManager.instance.agingBarrelBlocked = true;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(11.83333f, 916.5f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait05;
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T128/Dialogue1", triggerPlayerNum);
		NewTutorialManager.instance.agingBarrelBlocked = false;
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.ShowPopUp();
		NewTutorialManager.instance.SpawnArrow(new Vector2(12f, 915f), Vector2.up * 0.1f, ref JELIKOFDONK);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)SceneReferences.GetSceneReferences().agingBarrel).transform.position), Vector2.up * 0.6f, ref LJEJMMAEKJF);
		while (!MLIHKNOAIFO())
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T128/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyItemStartAging = (Action<int, ItemInstance>)Delegate.Combine(instance.OnAnyItemStartAging, new Action<int, ItemInstance>(HGMCIAOHPJK));
	}

	private IEnumerator AOGOKIJAAJO(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		yield return null;
		if (GameManager.LocalCoop())
		{
			if (!IHBDMEEDDIK && MEMGMDOCBOJ.LHBPOPOIFLE().JDJGFAACPFC() == 12 && !PlayerInventory.GetPlayer(1).HasItem(ItemDatabaseAccessor.GetItem(12)) && !PlayerInventory.GetPlayer(2).HasItem(ItemDatabaseAccessor.GetItem(12)))
			{
				IHBDMEEDDIK = true;
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyItemStartAging = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyItemStartAging, new Action<int, ItemInstance>(HGMCIAOHPJK));
				AgingBarrelUI.instances[1].Close();
				AgingBarrelUI.instances[2].Close();
				NewTutorialManager.instance.ObjectiveCompleted(0);
				LHKIJABBBPM();
				if ((Object)(object)JELIKOFDONK != (Object)null)
				{
					Object.Destroy((Object)(object)JELIKOFDONK);
				}
				if ((Object)(object)LJEJMMAEKJF != (Object)null)
				{
					Object.Destroy((Object)(object)LJEJMMAEKJF);
				}
			}
		}
		else if (!IHBDMEEDDIK && MEMGMDOCBOJ.LHBPOPOIFLE().JDJGFAACPFC() == 12 && !PlayerInventory.GetPlayer(1).HasItem(ItemDatabaseAccessor.GetItem(12)))
		{
			IHBDMEEDDIK = true;
			CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
			instance2.OnAnyItemStartAging = (Action<int, ItemInstance>)Delegate.Remove(instance2.OnAnyItemStartAging, new Action<int, ItemInstance>(HGMCIAOHPJK));
			AgingBarrelUI.instances[0].Close();
			NewTutorialManager.instance.ObjectiveCompleted(0);
			LHKIJABBBPM();
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
		}
	}

	private IEnumerator GCGHAEAMLIJ(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		return new DGLKKCEIHKP(1)
		{
			_003C_003E4__this = this,
			item = MEMGMDOCBOJ
		};
	}

	private void HGMCIAOHPJK(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		((MonoBehaviour)this).StartCoroutine(GJMHBFGLBCH(JIIGOACEIKL, MEMGMDOCBOJ));
	}

	private void OAOEEEMECAE(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		((MonoBehaviour)this).StartCoroutine(NEILABEGACO(JIIGOACEIKL, MEMGMDOCBOJ));
	}

	private IEnumerator PBEKBJIJFDK()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		NewTutorialManager.instance.agingBarrelBlocked = true;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(11.83333f, 916.5f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait05;
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T128/Dialogue1", triggerPlayerNum);
		NewTutorialManager.instance.agingBarrelBlocked = false;
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.ShowPopUp();
		NewTutorialManager.instance.SpawnArrow(new Vector2(12f, 915f), Vector2.up * 0.1f, ref JELIKOFDONK);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)SceneReferences.GetSceneReferences().agingBarrel).transform.position), Vector2.up * 0.6f, ref LJEJMMAEKJF);
		while (!MLIHKNOAIFO())
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T128/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyItemStartAging = (Action<int, ItemInstance>)Delegate.Combine(instance.OnAnyItemStartAging, new Action<int, ItemInstance>(HGMCIAOHPJK));
	}

	private IEnumerator OAIEBGHEBAK()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		NewTutorialManager.instance.agingBarrelBlocked = true;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(11.83333f, 916.5f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (!CLJJAIEMOLN())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait05;
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T128/Dialogue1", triggerPlayerNum);
		NewTutorialManager.instance.agingBarrelBlocked = false;
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.ShowPopUp();
		NewTutorialManager.instance.SpawnArrow(new Vector2(12f, 915f), Vector2.up * 0.1f, ref JELIKOFDONK);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)SceneReferences.GetSceneReferences().agingBarrel).transform.position), Vector2.up * 0.6f, ref LJEJMMAEKJF);
		while (!MLIHKNOAIFO())
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T128/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyItemStartAging = (Action<int, ItemInstance>)Delegate.Combine(instance.OnAnyItemStartAging, new Action<int, ItemInstance>(HGMCIAOHPJK));
	}

	private void KGJNOEJNAPG(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		((MonoBehaviour)this).StartCoroutine(PPGHDECKDAD(JIIGOACEIKL, MEMGMDOCBOJ));
	}

	private IEnumerator NEILABEGACO(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		return new DGLKKCEIHKP(1)
		{
			_003C_003E4__this = this,
			item = MEMGMDOCBOJ
		};
	}

	private IEnumerator FBOBCKJGPMB()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator MEGFHFOENJC(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		return new DGLKKCEIHKP(1)
		{
			_003C_003E4__this = this,
			item = MEMGMDOCBOJ
		};
	}

	private void MHDKABJEBDN(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		((MonoBehaviour)this).StartCoroutine(NEILABEGACO(JIIGOACEIKL, MEMGMDOCBOJ));
	}

	private void KKNNFIJDMJC(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		((MonoBehaviour)this).StartCoroutine(GCGHAEAMLIJ(JIIGOACEIKL, MEMGMDOCBOJ));
	}

	private void LJJIFOEFNNM(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		((MonoBehaviour)this).StartCoroutine(BJJOEJOAMEL(JIIGOACEIKL, MEMGMDOCBOJ));
	}

	private IEnumerator BJJOEJOAMEL(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		return new DGLKKCEIHKP(1)
		{
			_003C_003E4__this = this,
			item = MEMGMDOCBOJ
		};
	}

	private IEnumerator GJMHBFGLBCH(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		yield return null;
		if (GameManager.LocalCoop())
		{
			if (!IHBDMEEDDIK && MEMGMDOCBOJ.LHBPOPOIFLE().JDJGFAACPFC() == 12 && !PlayerInventory.GetPlayer(1).HasItem(ItemDatabaseAccessor.GetItem(12)) && !PlayerInventory.GetPlayer(2).HasItem(ItemDatabaseAccessor.GetItem(12)))
			{
				IHBDMEEDDIK = true;
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyItemStartAging = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyItemStartAging, new Action<int, ItemInstance>(HGMCIAOHPJK));
				AgingBarrelUI.instances[1].Close();
				AgingBarrelUI.instances[2].Close();
				NewTutorialManager.instance.ObjectiveCompleted(0);
				LHKIJABBBPM();
				if ((Object)(object)JELIKOFDONK != (Object)null)
				{
					Object.Destroy((Object)(object)JELIKOFDONK);
				}
				if ((Object)(object)LJEJMMAEKJF != (Object)null)
				{
					Object.Destroy((Object)(object)LJEJMMAEKJF);
				}
			}
		}
		else if (!IHBDMEEDDIK && MEMGMDOCBOJ.LHBPOPOIFLE().JDJGFAACPFC() == 12 && !PlayerInventory.GetPlayer(1).HasItem(ItemDatabaseAccessor.GetItem(12)))
		{
			IHBDMEEDDIK = true;
			CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
			instance2.OnAnyItemStartAging = (Action<int, ItemInstance>)Delegate.Remove(instance2.OnAnyItemStartAging, new Action<int, ItemInstance>(HGMCIAOHPJK));
			AgingBarrelUI.instances[0].Close();
			NewTutorialManager.instance.ObjectiveCompleted(0);
			LHKIJABBBPM();
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
		}
	}

	private void GIECPHLKAJG(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		((MonoBehaviour)this).StartCoroutine(NEILABEGACO(JIIGOACEIKL, MEMGMDOCBOJ));
	}
}
