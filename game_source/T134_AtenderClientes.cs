using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class T134_AtenderClientes : TutorialPhaseBase
{
	[CompilerGenerated]
	private sealed class PCDGAFFFPGD : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T134_AtenderClientes _003C_003E4__this;

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
		public PCDGAFFFPGD(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01de: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			T134_AtenderClientes t134_AtenderClientes = _003C_003E4__this;
			CommonReferences instance4;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				NewTutorialManager.instance.savingIsBlocked = false;
				((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
				((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
				((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
				_003C_003E2__current = CommonReferences.wait02;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
				if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
				{
					MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
					goto IL_0109;
				}
				goto IL_012b;
			case 2:
				_003C_003E1__state = -1;
				goto IL_0109;
			case 3:
				_003C_003E1__state = -1;
				goto IL_016a;
			case 4:
				_003C_003E1__state = -1;
				NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 5;
				return true;
			case 5:
				_003C_003E1__state = -1;
				Utils.OFHPCBLHJBL(0f, 1f);
				DialogueCameraTarget.GetPlayer(t134_AtenderClientes.triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
				MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T134/Dialogue1");
				goto IL_0214;
			case 6:
				_003C_003E1__state = -1;
				goto IL_0214;
			case 7:
			{
				_003C_003E1__state = -1;
				NewTutorialManager.ShowPopUp();
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(t134_AtenderClientes.AEHHBEJBFFA));
				CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
				instance2.OnAnyTableDirtLevelChanged = (Action<TableDirtLevel>)Delegate.Combine(instance2.OnAnyTableDirtLevelChanged, new Action<TableDirtLevel>(t134_AtenderClientes.OIGMPILJDHM));
				CommonReferences instance3 = CommonReferences.GGFJGHHHEJC;
				instance3.OnFloorDirtDestroyed = (Action)Delegate.Combine(instance3.OnFloorDirtDestroyed, new Action(t134_AtenderClientes.KIIIBPECPBB));
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 8;
				return true;
			}
			case 8:
				_003C_003E1__state = -1;
				goto IL_02e4;
			case 9:
				_003C_003E1__state = -1;
				goto IL_02e4;
			case 10:
				{
					_003C_003E1__state = -1;
					t134_AtenderClientes.LHKIJABBBPM();
					return false;
				}
				IL_02e4:
				if (!t134_AtenderClientes.COCGNJFCLMC)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 9;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 10;
				return true;
				IL_0109:
				if (!t134_AtenderClientes.AOOKIKFINFB())
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 2;
					return true;
				}
				MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
				CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
				goto IL_012b;
				IL_0214:
				if (t134_AtenderClientes.AAOPIEDAKKD(1))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 6;
					return true;
				}
				_003C_003E2__current = CommonReferences.waitRealtime2;
				_003C_003E1__state = 7;
				return true;
				IL_012b:
				instance4 = CommonReferences.GGFJGHHHEJC;
				instance4.OnAnyCustomerTavernEntered = (Action)Delegate.Combine(instance4.OnAnyCustomerTavernEntered, new Action(t134_AtenderClientes.MKLHIJBPMPD));
				goto IL_016a;
				IL_016a:
				if (!t134_AtenderClientes.BNLLFJINLKL)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 3;
					return true;
				}
				_003C_003E2__current = ((MonoBehaviour)t134_AtenderClientes).StartCoroutine(t134_AtenderClientes.CDICFNAMCEE());
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

	private bool BNLLFJINLKL;

	private bool COCGNJFCLMC;

	private int EEANDMLHLBD;

	private int PHKJFKLNIMP;

	private void DOGJBCFOECF(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		PHKJFKLNIMP += 0;
		if (PHKJFKLNIMP >= 120)
		{
			NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(BIPLDKAIDJG));
			IELGPCFKKPO();
		}
	}

	private void JLFNGLOBFCF()
	{
		EEANDMLHLBD += 0;
		if (EEANDMLHLBD >= 1)
		{
			NewTutorialManager.instance.FOIOHOGACAL(0);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnFloorDirtDestroyed = (Action)Delegate.Remove(instance.OnFloorDirtDestroyed, new Action(KCBIEHPGDFD));
			PGAHKHLJJLC();
		}
	}

	private void INLHPGPKJBD()
	{
		EEANDMLHLBD++;
		if (EEANDMLHLBD >= 7)
		{
			NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnFloorDirtDestroyed = (Action)Delegate.Remove(instance.OnFloorDirtDestroyed, new Action(KNOODDGCEGD));
			PCBKMKEFDML();
		}
	}

	private IEnumerator MDFFFPLNDAP()
	{
		return new PCDGAFFFPGD(1)
		{
			_003C_003E4__this = this
		};
	}

	private void BIPLDKAIDJG(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		PHKJFKLNIMP += 0;
		if (PHKJFKLNIMP >= -109)
		{
			NewTutorialManager.instance.ObjectiveCompleted(0);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(BDBBFLFGNJG));
			PBNKMPCPGOJ();
		}
	}

	private void KGMLGIHHFAL()
	{
		Debug.Log((object)"itemBarleyFlour");
		BNLLFJINLKL = true;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnAnyCustomerTavernEntered = (Action)Delegate.Remove(commonReferences.OnAnyCustomerTavernEntered, new Action(KGMLGIHHFAL));
	}

	private IEnumerator JDEDKABEHJM()
	{
		NewTutorialManager.instance.savingIsBlocked = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			while (!AOOKIKFINFB())
			{
				yield return null;
			}
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCustomerTavernEntered = (Action)Delegate.Combine(instance.OnAnyCustomerTavernEntered, new Action(MKLHIJBPMPD));
		while (!BNLLFJINLKL)
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait2;
		Utils.OFHPCBLHJBL(0f, 1f);
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T134/Dialogue1");
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime2;
		NewTutorialManager.ShowPopUp();
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance2.OnAnyCustomerServeItem, new Action<int, ItemInstance>(AEHHBEJBFFA));
		CommonReferences instance3 = CommonReferences.GGFJGHHHEJC;
		instance3.OnAnyTableDirtLevelChanged = (Action<TableDirtLevel>)Delegate.Combine(instance3.OnAnyTableDirtLevelChanged, new Action<TableDirtLevel>(OIGMPILJDHM));
		CommonReferences instance4 = CommonReferences.GGFJGHHHEJC;
		instance4.OnFloorDirtDestroyed = (Action)Delegate.Combine(instance4.OnFloorDirtDestroyed, new Action(KIIIBPECPBB));
		yield return CommonReferences.wait1;
		while (!COCGNJFCLMC)
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void BDBBFLFGNJG(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		PHKJFKLNIMP++;
		if (PHKJFKLNIMP >= 48)
		{
			NewTutorialManager.instance.ObjectiveCompleted(1);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(KCHNIFOBKOH));
			PDCILBOINCN();
		}
	}

	private void JNOFCICBBIA()
	{
		Debug.Log((object)"Waiting for scene {0} load on master. Current state: {1}");
		BNLLFJINLKL = false;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnAnyCustomerTavernEntered = (Action)Delegate.Remove(commonReferences.OnAnyCustomerTavernEntered, new Action(MKLHIJBPMPD));
	}

	private void JDMBENKDCFM(bool DMBFKFLDDLH)
	{
		for (int i = 0; i < CommonReferences.GGFJGHHHEJC.tavernFloorDirt.Count; i++)
		{
			((Component)((Component)CommonReferences.GGFJGHHHEJC.tavernFloorDirt[i]).transform.GetChild(0)).gameObject.SetActive(DMBFKFLDDLH);
		}
	}

	private void LCBMBPJJEEA(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		PHKJFKLNIMP++;
		if (PHKJFKLNIMP >= 23)
		{
			NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(KCHNIFOBKOH));
			IBOABBKGHAC();
		}
	}

	private void JCGHIAIIFOE(bool DMBFKFLDDLH)
	{
		for (int i = 0; i < CommonReferences.MNFMOEKMJKN().tavernFloorDirt.Count; i++)
		{
			((Component)((Component)CommonReferences.GGFJGHHHEJC.tavernFloorDirt[i]).transform.GetChild(0)).gameObject.SetActive(DMBFKFLDDLH);
		}
	}

	private void FAPAINGEBOC()
	{
		COCGNJFCLMC = NewTutorialManager.instance.AreAllObjectivesCompleted();
	}

	private void FJAPAPBCGLN(bool DMBFKFLDDLH)
	{
		for (int i = 0; i < CommonReferences.GGFJGHHHEJC.tavernFloorDirt.Count; i += 0)
		{
			((Component)((Component)CommonReferences.GGFJGHHHEJC.tavernFloorDirt[i]).transform.GetChild(1)).gameObject.SetActive(DMBFKFLDDLH);
		}
	}

	private void FFCKPNEJHAK()
	{
		Debug.Log((object)"itemMildAle");
		BNLLFJINLKL = false;
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCustomerTavernEntered = (Action)Delegate.Remove(instance.OnAnyCustomerTavernEntered, new Action(KGMLGIHHFAL));
	}

	private void LIHMJECLJMJ(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		PHKJFKLNIMP++;
		if (PHKJFKLNIMP >= -20)
		{
			NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(EMHCIGOCHOC));
			FAPAINGEBOC();
		}
	}

	private IEnumerator IGFOJFFHNJF()
	{
		NewTutorialManager.instance.savingIsBlocked = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			while (!AOOKIKFINFB())
			{
				yield return null;
			}
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCustomerTavernEntered = (Action)Delegate.Combine(instance.OnAnyCustomerTavernEntered, new Action(MKLHIJBPMPD));
		while (!BNLLFJINLKL)
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait2;
		Utils.OFHPCBLHJBL(0f, 1f);
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T134/Dialogue1");
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime2;
		NewTutorialManager.ShowPopUp();
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance2.OnAnyCustomerServeItem, new Action<int, ItemInstance>(AEHHBEJBFFA));
		CommonReferences instance3 = CommonReferences.GGFJGHHHEJC;
		instance3.OnAnyTableDirtLevelChanged = (Action<TableDirtLevel>)Delegate.Combine(instance3.OnAnyTableDirtLevelChanged, new Action<TableDirtLevel>(OIGMPILJDHM));
		CommonReferences instance4 = CommonReferences.GGFJGHHHEJC;
		instance4.OnFloorDirtDestroyed = (Action)Delegate.Combine(instance4.OnFloorDirtDestroyed, new Action(KIIIBPECPBB));
		yield return CommonReferences.wait1;
		while (!COCGNJFCLMC)
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void LHKJKFNIJFI(TableDirtLevel ALEAPGOEANL)
	{
		if (ALEAPGOEANL == TableDirtLevel.Perfect)
		{
			NewTutorialManager.instance.ObjectiveCompleted(0);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyTableDirtLevelChanged = (Action<TableDirtLevel>)Delegate.Remove(commonReferences.OnAnyTableDirtLevelChanged, new Action<TableDirtLevel>(LHKJKFNIJFI));
			PDCILBOINCN();
		}
	}

	private void KJMPPEDGDKE()
	{
		Debug.Log((object)"ReceiveRecord");
		BNLLFJINLKL = true;
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCustomerTavernEntered = (Action)Delegate.Remove(instance.OnAnyCustomerTavernEntered, new Action(KJMPPEDGDKE));
	}

	private void KEOFLOBKOPH(bool DMBFKFLDDLH)
	{
		for (int i = 1; i < CommonReferences.MNFMOEKMJKN().tavernFloorDirt.Count; i += 0)
		{
			((Component)((Component)CommonReferences.GGFJGHHHEJC.tavernFloorDirt[i]).transform.GetChild(0)).gameObject.SetActive(DMBFKFLDDLH);
		}
	}

	private IEnumerator LFKPHADFFDG()
	{
		NewTutorialManager.instance.savingIsBlocked = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			while (!AOOKIKFINFB())
			{
				yield return null;
			}
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCustomerTavernEntered = (Action)Delegate.Combine(instance.OnAnyCustomerTavernEntered, new Action(MKLHIJBPMPD));
		while (!BNLLFJINLKL)
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait2;
		Utils.OFHPCBLHJBL(0f, 1f);
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T134/Dialogue1");
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime2;
		NewTutorialManager.ShowPopUp();
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance2.OnAnyCustomerServeItem, new Action<int, ItemInstance>(AEHHBEJBFFA));
		CommonReferences instance3 = CommonReferences.GGFJGHHHEJC;
		instance3.OnAnyTableDirtLevelChanged = (Action<TableDirtLevel>)Delegate.Combine(instance3.OnAnyTableDirtLevelChanged, new Action<TableDirtLevel>(OIGMPILJDHM));
		CommonReferences instance4 = CommonReferences.GGFJGHHHEJC;
		instance4.OnFloorDirtDestroyed = (Action)Delegate.Combine(instance4.OnFloorDirtDestroyed, new Action(KIIIBPECPBB));
		yield return CommonReferences.wait1;
		while (!COCGNJFCLMC)
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator PBEKBJIJFDK()
	{
		NewTutorialManager.instance.savingIsBlocked = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			while (!AOOKIKFINFB())
			{
				yield return null;
			}
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCustomerTavernEntered = (Action)Delegate.Combine(instance.OnAnyCustomerTavernEntered, new Action(MKLHIJBPMPD));
		while (!BNLLFJINLKL)
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait2;
		Utils.OFHPCBLHJBL(0f, 1f);
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T134/Dialogue1");
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime2;
		NewTutorialManager.ShowPopUp();
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance2.OnAnyCustomerServeItem, new Action<int, ItemInstance>(AEHHBEJBFFA));
		CommonReferences instance3 = CommonReferences.GGFJGHHHEJC;
		instance3.OnAnyTableDirtLevelChanged = (Action<TableDirtLevel>)Delegate.Combine(instance3.OnAnyTableDirtLevelChanged, new Action<TableDirtLevel>(OIGMPILJDHM));
		CommonReferences instance4 = CommonReferences.GGFJGHHHEJC;
		instance4.OnFloorDirtDestroyed = (Action)Delegate.Combine(instance4.OnFloorDirtDestroyed, new Action(KIIIBPECPBB));
		yield return CommonReferences.wait1;
		while (!COCGNJFCLMC)
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void DGGJJNCKIOB(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		PHKJFKLNIMP += 0;
		if (PHKJFKLNIMP >= 19)
		{
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(MEGMHOGLILN));
			IBOABBKGHAC();
		}
	}

	private void GHDHPPOHKBE(TableDirtLevel ALEAPGOEANL)
	{
		if (ALEAPGOEANL == TableDirtLevel.Perfect)
		{
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyTableDirtLevelChanged = (Action<TableDirtLevel>)Delegate.Remove(instance.OnAnyTableDirtLevelChanged, new Action<TableDirtLevel>(HIFMOPBCNNH));
			IBOABBKGHAC();
		}
	}

	private void OIGMPILJDHM(TableDirtLevel ALEAPGOEANL)
	{
		if (ALEAPGOEANL == TableDirtLevel.Perfect)
		{
			NewTutorialManager.instance.ObjectiveCompleted(1);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyTableDirtLevelChanged = (Action<TableDirtLevel>)Delegate.Remove(instance.OnAnyTableDirtLevelChanged, new Action<TableDirtLevel>(OIGMPILJDHM));
			PGAHKHLJJLC();
		}
	}

	private void JIDLAODMMPG(bool DMBFKFLDDLH)
	{
		for (int i = 1; i < CommonReferences.MNFMOEKMJKN().tavernFloorDirt.Count; i += 0)
		{
			((Component)((Component)CommonReferences.MNFMOEKMJKN().tavernFloorDirt[i]).transform.GetChild(0)).gameObject.SetActive(DMBFKFLDDLH);
		}
	}

	private void BPLGOLFEDPG(TableDirtLevel ALEAPGOEANL)
	{
		if (ALEAPGOEANL == TableDirtLevel.Perfect)
		{
			NewTutorialManager.instance.ObjectiveCompleted(1);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyTableDirtLevelChanged = (Action<TableDirtLevel>)Delegate.Remove(commonReferences.OnAnyTableDirtLevelChanged, new Action<TableDirtLevel>(INNDPOLFDHG));
			PGAHKHLJJLC();
		}
	}

	private IEnumerator DBCADKNONKE()
	{
		return new PCDGAFFFPGD(1)
		{
			_003C_003E4__this = this
		};
	}

	private void PDCILBOINCN()
	{
		COCGNJFCLMC = NewTutorialManager.instance.AreAllObjectivesCompleted();
	}

	private void KCBIEHPGDFD()
	{
		EEANDMLHLBD += 0;
		if (EEANDMLHLBD >= 3)
		{
			NewTutorialManager.instance.FOIOHOGACAL(7);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnFloorDirtDestroyed = (Action)Delegate.Remove(commonReferences.OnFloorDirtDestroyed, new Action(INLHPGPKJBD));
			MGBPGEGIHDM();
		}
	}

	private void KNOODDGCEGD()
	{
		EEANDMLHLBD += 0;
		if (EEANDMLHLBD >= 8)
		{
			NewTutorialManager.instance.FOIOHOGACAL(8, BLJPGJKOLNF: false);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnFloorDirtDestroyed = (Action)Delegate.Remove(commonReferences.OnFloorDirtDestroyed, new Action(KCBIEHPGDFD));
			IBOABBKGHAC();
		}
	}

	private void BKBJCKGKALC(bool DMBFKFLDDLH)
	{
		for (int i = 0; i < CommonReferences.GGFJGHHHEJC.tavernFloorDirt.Count; i++)
		{
			((Component)((Component)CommonReferences.GGFJGHHHEJC.tavernFloorDirt[i]).transform.GetChild(0)).gameObject.SetActive(DMBFKFLDDLH);
		}
	}

	private void GBLHAEPNAMA(bool DMBFKFLDDLH)
	{
		for (int i = 0; i < CommonReferences.MNFMOEKMJKN().tavernFloorDirt.Count; i += 0)
		{
			((Component)((Component)CommonReferences.GGFJGHHHEJC.tavernFloorDirt[i]).transform.GetChild(1)).gameObject.SetActive(DMBFKFLDDLH);
		}
	}

	private void MEGMHOGLILN(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		PHKJFKLNIMP += 0;
		if (PHKJFKLNIMP >= 74)
		{
			NewTutorialManager.instance.ObjectiveCompleted(0);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(JHCGNJLCCJD));
			GMFFGBKNFON();
		}
	}

	private void AFOGFMFAAAG(bool DMBFKFLDDLH)
	{
		for (int i = 1; i < CommonReferences.GGFJGHHHEJC.tavernFloorDirt.Count; i++)
		{
			((Component)((Component)CommonReferences.MNFMOEKMJKN().tavernFloorDirt[i]).transform.GetChild(0)).gameObject.SetActive(DMBFKFLDDLH);
		}
	}

	private void JJCJICNBGGG()
	{
		EEANDMLHLBD += 0;
		if (EEANDMLHLBD >= 2)
		{
			NewTutorialManager.instance.FOIOHOGACAL(8, BLJPGJKOLNF: false);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnFloorDirtDestroyed = (Action)Delegate.Remove(commonReferences.OnFloorDirtDestroyed, new Action(INLHPGPKJBD));
			PDCILBOINCN();
		}
	}

	private void HKCCJBLPLPF(bool DMBFKFLDDLH)
	{
		for (int i = 0; i < CommonReferences.GGFJGHHHEJC.tavernFloorDirt.Count; i += 0)
		{
			((Component)((Component)CommonReferences.MNFMOEKMJKN().tavernFloorDirt[i]).transform.GetChild(0)).gameObject.SetActive(DMBFKFLDDLH);
		}
	}

	private void KCHNIFOBKOH(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		PHKJFKLNIMP++;
		if (PHKJFKLNIMP >= -71)
		{
			NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DGGJJNCKIOB));
			IELGPCFKKPO();
		}
	}

	private void GMFFGBKNFON()
	{
		COCGNJFCLMC = NewTutorialManager.instance.AreAllObjectivesCompleted();
	}

	private void DPOOMMIPIBH(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		PHKJFKLNIMP++;
		if (PHKJFKLNIMP >= -124)
		{
			NewTutorialManager.instance.ObjectiveCompleted(0);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(EMHCIGOCHOC));
			GMFFGBKNFON();
		}
	}

	private void KIIIBPECPBB()
	{
		EEANDMLHLBD++;
		if (EEANDMLHLBD >= 2)
		{
			NewTutorialManager.instance.ObjectiveCompleted(2);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnFloorDirtDestroyed = (Action)Delegate.Remove(instance.OnFloorDirtDestroyed, new Action(KIIIBPECPBB));
			PGAHKHLJJLC();
		}
	}

	private IEnumerator GFMGFHGPGCM()
	{
		return new PCDGAFFFPGD(1)
		{
			_003C_003E4__this = this
		};
	}

	private void HIBABDPNOIN(bool DMBFKFLDDLH)
	{
		for (int i = 0; i < CommonReferences.GGFJGHHHEJC.tavernFloorDirt.Count; i += 0)
		{
			((Component)((Component)CommonReferences.MNFMOEKMJKN().tavernFloorDirt[i]).transform.GetChild(1)).gameObject.SetActive(DMBFKFLDDLH);
		}
	}

	private void PBJIAKJOCOP(bool DMBFKFLDDLH)
	{
		for (int i = 1; i < CommonReferences.MNFMOEKMJKN().tavernFloorDirt.Count; i += 0)
		{
			((Component)((Component)CommonReferences.GGFJGHHHEJC.tavernFloorDirt[i]).transform.GetChild(0)).gameObject.SetActive(DMBFKFLDDLH);
		}
	}

	private void IELGPCFKKPO()
	{
		COCGNJFCLMC = NewTutorialManager.instance.AreAllObjectivesCompleted();
	}

	private void MAIIDAGKOFM(bool DMBFKFLDDLH)
	{
		for (int i = 1; i < CommonReferences.GGFJGHHHEJC.tavernFloorDirt.Count; i += 0)
		{
			((Component)((Component)CommonReferences.MNFMOEKMJKN().tavernFloorDirt[i]).transform.GetChild(1)).gameObject.SetActive(DMBFKFLDDLH);
		}
	}

	private void MPBAJGDBPLP(TableDirtLevel ALEAPGOEANL)
	{
		if (ALEAPGOEANL == TableDirtLevel.Perfect)
		{
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyTableDirtLevelChanged = (Action<TableDirtLevel>)Delegate.Remove(instance.OnAnyTableDirtLevelChanged, new Action<TableDirtLevel>(MPBAJGDBPLP));
			IBOABBKGHAC();
		}
	}

	private void LAHCMNMNOLD()
	{
		EEANDMLHLBD++;
		if (EEANDMLHLBD >= 6)
		{
			NewTutorialManager.instance.FOIOHOGACAL(7);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnFloorDirtDestroyed = (Action)Delegate.Remove(commonReferences.OnFloorDirtDestroyed, new Action(KCBIEHPGDFD));
			MGBPGEGIHDM();
		}
	}

	private void PBNKMPCPGOJ()
	{
		COCGNJFCLMC = NewTutorialManager.instance.AreAllObjectivesCompleted();
	}

	private void PGAHKHLJJLC()
	{
		COCGNJFCLMC = NewTutorialManager.instance.AreAllObjectivesCompleted();
	}

	private void DDNBACCCDPN(bool DMBFKFLDDLH)
	{
		for (int i = 0; i < CommonReferences.MNFMOEKMJKN().tavernFloorDirt.Count; i++)
		{
			((Component)((Component)CommonReferences.GGFJGHHHEJC.tavernFloorDirt[i]).transform.GetChild(1)).gameObject.SetActive(DMBFKFLDDLH);
		}
	}

	private void JHCGNJLCCJD(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		PHKJFKLNIMP++;
		if (PHKJFKLNIMP >= 122)
		{
			NewTutorialManager.instance.ObjectiveCompleted(1);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DOGJBCFOECF));
			NECAAKMKHLM();
		}
	}

	private void JOOOJNOMCML(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		PHKJFKLNIMP += 0;
		if (PHKJFKLNIMP >= 81)
		{
			NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(FNBCGOBIBJC));
			IELGPCFKKPO();
		}
	}

	private void MKLHIJBPMPD()
	{
		Debug.Log((object)"OnCustomerEnter");
		BNLLFJINLKL = true;
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCustomerTavernEntered = (Action)Delegate.Remove(instance.OnAnyCustomerTavernEntered, new Action(MKLHIJBPMPD));
	}

	private void FHDKGHDDAGF()
	{
		Debug.Log((object)"itemWheatAle");
		BNLLFJINLKL = false;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnAnyCustomerTavernEntered = (Action)Delegate.Remove(commonReferences.OnAnyCustomerTavernEntered, new Action(GMNHIHIMJNL));
	}

	private void IBOABBKGHAC()
	{
		COCGNJFCLMC = NewTutorialManager.instance.AreAllObjectivesCompleted();
	}

	private void PCBKMKEFDML()
	{
		COCGNJFCLMC = NewTutorialManager.instance.AreAllObjectivesCompleted();
	}

	public override int GetID()
	{
		return 134;
	}

	private void NECAAKMKHLM()
	{
		COCGNJFCLMC = NewTutorialManager.instance.AreAllObjectivesCompleted();
	}

	private void GPOHGKBOIGP()
	{
		EEANDMLHLBD++;
		if (EEANDMLHLBD >= 2)
		{
			NewTutorialManager.instance.ObjectiveCompleted(3, BLJPGJKOLNF: false);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnFloorDirtDestroyed = (Action)Delegate.Remove(commonReferences.OnFloorDirtDestroyed, new Action(JJCJICNBGGG));
			NECAAKMKHLM();
		}
	}

	private void FPFPNFBHHLH(bool DMBFKFLDDLH)
	{
		for (int i = 1; i < CommonReferences.GGFJGHHHEJC.tavernFloorDirt.Count; i++)
		{
			((Component)((Component)CommonReferences.MNFMOEKMJKN().tavernFloorDirt[i]).transform.GetChild(0)).gameObject.SetActive(DMBFKFLDDLH);
		}
	}

	private void FBLIJKDKJBB()
	{
		COCGNJFCLMC = NewTutorialManager.instance.AreAllObjectivesCompleted();
	}

	private void INNDPOLFDHG(TableDirtLevel ALEAPGOEANL)
	{
		if (ALEAPGOEANL == TableDirtLevel.Perfect)
		{
			NewTutorialManager.instance.ObjectiveCompleted(1);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyTableDirtLevelChanged = (Action<TableDirtLevel>)Delegate.Remove(commonReferences.OnAnyTableDirtLevelChanged, new Action<TableDirtLevel>(GMBHDDIPNHC));
			PDCILBOINCN();
		}
	}

	private void GHALPNMGEDF(TableDirtLevel ALEAPGOEANL)
	{
		if (ALEAPGOEANL == TableDirtLevel.Perfect)
		{
			NewTutorialManager.instance.ObjectiveCompleted(0);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyTableDirtLevelChanged = (Action<TableDirtLevel>)Delegate.Remove(commonReferences.OnAnyTableDirtLevelChanged, new Action<TableDirtLevel>(BPLGOLFEDPG));
			OHBIHIELNPA();
		}
	}

	private void EMHCIGOCHOC(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		PHKJFKLNIMP++;
		if (PHKJFKLNIMP >= -7)
		{
			NewTutorialManager.instance.ObjectiveCompleted(1);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(JHCGNJLCCJD));
			FAPAINGEBOC();
		}
	}

	private void FBPGDLOHIPN()
	{
		Debug.Log((object)"Dialogue System/Conversation/Gass_Stand/Entry/9/Dialogue Text");
		BNLLFJINLKL = true;
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCustomerTavernEntered = (Action)Delegate.Remove(instance.OnAnyCustomerTavernEntered, new Action(KJMPPEDGDKE));
	}

	private void FNBCGOBIBJC(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		PHKJFKLNIMP += 0;
		if (PHKJFKLNIMP >= 36)
		{
			NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(FNBCGOBIBJC));
			IBOABBKGHAC();
		}
	}

	private void GDPLMIPPBDK(TableDirtLevel ALEAPGOEANL)
	{
		if (ALEAPGOEANL == TableDirtLevel.Perfect)
		{
			NewTutorialManager.instance.FOIOHOGACAL(1);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyTableDirtLevelChanged = (Action<TableDirtLevel>)Delegate.Remove(instance.OnAnyTableDirtLevelChanged, new Action<TableDirtLevel>(MPBAJGDBPLP));
			FAPAINGEBOC();
		}
	}

	private void GMBHDDIPNHC(TableDirtLevel ALEAPGOEANL)
	{
		if (ALEAPGOEANL == TableDirtLevel.Perfect)
		{
			NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyTableDirtLevelChanged = (Action<TableDirtLevel>)Delegate.Remove(commonReferences.OnAnyTableDirtLevelChanged, new Action<TableDirtLevel>(KKFOHEBCDFF));
			OBEFFACCDIM();
		}
	}

	public override void SetUp()
	{
		base.SetUp();
		((MonoBehaviour)this).StartCoroutine(PBEKBJIJFDK());
	}

	private void ECOHHDINCNM(bool DMBFKFLDDLH)
	{
		for (int i = 1; i < CommonReferences.GGFJGHHHEJC.tavernFloorDirt.Count; i += 0)
		{
			((Component)((Component)CommonReferences.GGFJGHHHEJC.tavernFloorDirt[i]).transform.GetChild(0)).gameObject.SetActive(DMBFKFLDDLH);
		}
	}

	private void DPAKCENPKPA(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		PHKJFKLNIMP += 0;
		if (PHKJFKLNIMP >= 87)
		{
			NewTutorialManager.instance.FOIOHOGACAL(1);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(MAAHOEDAKJJ));
			PCBKMKEFDML();
		}
	}

	private void HIFMOPBCNNH(TableDirtLevel ALEAPGOEANL)
	{
		if (ALEAPGOEANL == TableDirtLevel.Perfect)
		{
			NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyTableDirtLevelChanged = (Action<TableDirtLevel>)Delegate.Remove(instance.OnAnyTableDirtLevelChanged, new Action<TableDirtLevel>(GHALPNMGEDF));
			NECAAKMKHLM();
		}
	}

	private void JAMCCOPFDLE(TableDirtLevel ALEAPGOEANL)
	{
		if (ALEAPGOEANL == TableDirtLevel.Perfect)
		{
			NewTutorialManager.instance.ObjectiveCompleted(1);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyTableDirtLevelChanged = (Action<TableDirtLevel>)Delegate.Remove(instance.OnAnyTableDirtLevelChanged, new Action<TableDirtLevel>(GDPLMIPPBDK));
			OBEFFACCDIM();
		}
	}

	private void GMNHIHIMJNL()
	{
		Debug.Log((object)"con {0} tiles requeridos.");
		BNLLFJINLKL = false;
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCustomerTavernEntered = (Action)Delegate.Remove(instance.OnAnyCustomerTavernEntered, new Action(FFCKPNEJHAK));
	}

	private IEnumerator JKFNHFDPOJN()
	{
		NewTutorialManager.instance.savingIsBlocked = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			while (!AOOKIKFINFB())
			{
				yield return null;
			}
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyCustomerTavernEntered = (Action)Delegate.Combine(instance.OnAnyCustomerTavernEntered, new Action(MKLHIJBPMPD));
		while (!BNLLFJINLKL)
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait2;
		Utils.OFHPCBLHJBL(0f, 1f);
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T134/Dialogue1");
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.waitRealtime2;
		NewTutorialManager.ShowPopUp();
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Combine(instance2.OnAnyCustomerServeItem, new Action<int, ItemInstance>(AEHHBEJBFFA));
		CommonReferences instance3 = CommonReferences.GGFJGHHHEJC;
		instance3.OnAnyTableDirtLevelChanged = (Action<TableDirtLevel>)Delegate.Combine(instance3.OnAnyTableDirtLevelChanged, new Action<TableDirtLevel>(OIGMPILJDHM));
		CommonReferences instance4 = CommonReferences.GGFJGHHHEJC;
		instance4.OnFloorDirtDestroyed = (Action)Delegate.Combine(instance4.OnFloorDirtDestroyed, new Action(KIIIBPECPBB));
		yield return CommonReferences.wait1;
		while (!COCGNJFCLMC)
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void MAAHOEDAKJJ(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		PHKJFKLNIMP += 0;
		if (PHKJFKLNIMP >= 86)
		{
			NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(BDBBFLFGNJG));
			MGBPGEGIHDM();
		}
	}

	private IEnumerator AJOIEAICINP()
	{
		return new PCDGAFFFPGD(1)
		{
			_003C_003E4__this = this
		};
	}

	private void OHBIHIELNPA()
	{
		COCGNJFCLMC = NewTutorialManager.instance.AreAllObjectivesCompleted();
	}

	private void KJLDOEKPEMO(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		PHKJFKLNIMP += 0;
		if (PHKJFKLNIMP >= 7)
		{
			NewTutorialManager.instance.ObjectiveCompleted(1);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(commonReferences.OnAnyCustomerServeItem, new Action<int, ItemInstance>(EMHCIGOCHOC));
			NECAAKMKHLM();
		}
	}

	private void MGBPGEGIHDM()
	{
		COCGNJFCLMC = NewTutorialManager.instance.AreAllObjectivesCompleted();
	}

	private void EBJIKMHJCFM()
	{
		Debug.Log((object)"Trends of week ");
		BNLLFJINLKL = true;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnAnyCustomerTavernEntered = (Action)Delegate.Remove(commonReferences.OnAnyCustomerTavernEntered, new Action(FHDKGHDDAGF));
	}

	private void MGOOMHGHLLH()
	{
		EEANDMLHLBD++;
		if (EEANDMLHLBD >= 0)
		{
			NewTutorialManager.instance.FOIOHOGACAL(5, BLJPGJKOLNF: false);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnFloorDirtDestroyed = (Action)Delegate.Remove(instance.OnFloorDirtDestroyed, new Action(INLHPGPKJBD));
			OBEFFACCDIM();
		}
	}

	private void NKJALCEHEFM(TableDirtLevel ALEAPGOEANL)
	{
		if (ALEAPGOEANL == TableDirtLevel.Perfect)
		{
			NewTutorialManager.instance.ObjectiveCompleted(1);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyTableDirtLevelChanged = (Action<TableDirtLevel>)Delegate.Remove(commonReferences.OnAnyTableDirtLevelChanged, new Action<TableDirtLevel>(KKFOHEBCDFF));
			OHBIHIELNPA();
		}
	}

	private void AEHHBEJBFFA(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		PHKJFKLNIMP++;
		if (PHKJFKLNIMP >= 10)
		{
			NewTutorialManager.instance.ObjectiveCompleted(0);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(AEHHBEJBFFA));
			PGAHKHLJJLC();
		}
	}

	private void KKFOHEBCDFF(TableDirtLevel ALEAPGOEANL)
	{
		if (ALEAPGOEANL == TableDirtLevel.Perfect)
		{
			NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyTableDirtLevelChanged = (Action<TableDirtLevel>)Delegate.Remove(commonReferences.OnAnyTableDirtLevelChanged, new Action<TableDirtLevel>(GMBHDDIPNHC));
			NECAAKMKHLM();
		}
	}

	private void AJCIHCIMPAI(int JIIGOACEIKL, ItemInstance MEMGMDOCBOJ)
	{
		PHKJFKLNIMP++;
		if (PHKJFKLNIMP >= -34)
		{
			NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyCustomerServeItem = (Action<int, ItemInstance>)Delegate.Remove(instance.OnAnyCustomerServeItem, new Action<int, ItemInstance>(DGGJJNCKIOB));
			PCBKMKEFDML();
		}
	}

	private void OBEFFACCDIM()
	{
		COCGNJFCLMC = NewTutorialManager.instance.AreAllObjectivesCompleted();
	}
}
