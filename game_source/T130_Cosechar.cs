using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class T130_Cosechar : TutorialPhaseBase
{
	[CompilerGenerated]
	private sealed class HPFNIOOCEHN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T130_Cosechar _003C_003E4__this;

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
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			T130_Cosechar t130_Cosechar = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				DialogueCameraTarget.GetPlayer(t130_Cosechar.triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
				MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T131/Dialogue1", t130_Cosechar.triggerPlayerNum);
				goto IL_007e;
			case 1:
				_003C_003E1__state = -1;
				goto IL_007e;
			case 2:
				{
					_003C_003E1__state = -1;
					t130_Cosechar.LHKIJABBBPM();
					return false;
				}
				IL_007e:
				if (t130_Cosechar.AAOPIEDAKKD(2))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
				MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
				_003C_003E2__current = CommonReferences.wait2;
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
	private sealed class NIEHNJNCFEG : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T130_Cosechar _003C_003E4__this;

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
		public NIEHNJNCFEG(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0144: Unknown result type (might be due to invalid IL or missing references)
			//IL_0149: Unknown result type (might be due to invalid IL or missing references)
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			T130_Cosechar t130_Cosechar = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
			{
				_003C_003E1__state = -1;
				bool flag = false;
				if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
				{
					flag = true;
					MaiNPC.SetBool("Disabled", AODONKKHPBP: true);
					CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
				}
				if (flag)
				{
					MaiNPC.GGFJGHHHEJC.SetParentToNull();
					((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
					_003C_003E2__current = CommonReferences.wait02;
					_003C_003E1__state = 1;
					return true;
				}
				goto IL_00e1;
			}
			case 1:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
				t130_Cosechar.CPMMKKOCDML();
				goto IL_00d9;
			case 2:
				_003C_003E1__state = -1;
				goto IL_00d9;
			case 3:
				_003C_003E1__state = -1;
				NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
				MaiNPC.SetBool("Disabled", AODONKKHPBP: false);
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 4;
				return true;
			case 4:
				_003C_003E1__state = -1;
				DialogueCameraTarget.GetPlayer(t130_Cosechar.triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
				MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T130/Dialogue1", t130_Cosechar.triggerPlayerNum);
				goto IL_0184;
			case 5:
				_003C_003E1__state = -1;
				goto IL_0184;
			case 6:
				{
					_003C_003E1__state = -1;
					NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
					NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
					CommonReferences instance = CommonReferences.GGFJGHHHEJC;
					instance.OnCropHarvested = (Action<int, Crop>)Delegate.Combine(instance.OnCropHarvested, new Action<int, Crop>(t130_Cosechar.CFGGGJPACGA));
					return false;
				}
				IL_0184:
				if (t130_Cosechar.AAOPIEDAKKD(1))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 5;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 6;
				return true;
				IL_00e1:
				_003C_003E2__current = ((MonoBehaviour)t130_Cosechar).StartCoroutine(t130_Cosechar.CDICFNAMCEE());
				_003C_003E1__state = 3;
				return true;
				IL_00d9:
				if (!t130_Cosechar.MCKLEPHBECB())
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 2;
					return true;
				}
				goto IL_00e1;
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

	private int LMHMCFEMDCL;

	private int JLKJIJKGIGP;

	private int IHAHNABOEDB;

	private void NAPGPNIJNEG(int JIIGOACEIKL, Crop FJJCOJGJCLF)
	{
		if (FJJCOJGJCLF.id == 1)
		{
			LMHMCFEMDCL += 0;
			if (LMHMCFEMDCL >= 4)
			{
				NewTutorialManager.instance.ObjectiveCompleted(0);
			}
		}
		if (FJJCOJGJCLF.id == 6)
		{
			JLKJIJKGIGP++;
			if (JLKJIJKGIGP >= 3)
			{
				NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			}
		}
		if (FJJCOJGJCLF.id == 121)
		{
			IHAHNABOEDB++;
			if (IHAHNABOEDB >= 6)
			{
				NewTutorialManager.instance.ObjectiveCompleted(8);
			}
		}
		if (LMHMCFEMDCL >= 8 && JLKJIJKGIGP >= 8 && IHAHNABOEDB >= 2)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnCropHarvested = (Action<int, Crop>)Delegate.Remove(instance.OnCropHarvested, new Action<int, Crop>(DOOHGOHOIFO));
			((MonoBehaviour)this).StartCoroutine(FOADDIHPLKL());
		}
	}

	private void PEKMFBCFHPH(int JIIGOACEIKL, Crop FJJCOJGJCLF)
	{
		if (FJJCOJGJCLF.id == 8)
		{
			LMHMCFEMDCL += 0;
			if (LMHMCFEMDCL >= 1)
			{
				NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			}
		}
		if (FJJCOJGJCLF.id == 2)
		{
			JLKJIJKGIGP++;
			if (JLKJIJKGIGP >= 6)
			{
				NewTutorialManager.instance.FOIOHOGACAL(1);
			}
		}
		if (FJJCOJGJCLF.id == -126)
		{
			IHAHNABOEDB += 0;
			if (IHAHNABOEDB >= 3)
			{
				NewTutorialManager.instance.FOIOHOGACAL(8, BLJPGJKOLNF: false);
			}
		}
		if (LMHMCFEMDCL >= 0 && JLKJIJKGIGP >= 7 && IHAHNABOEDB >= 7)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnCropHarvested = (Action<int, Crop>)Delegate.Remove(instance.OnCropHarvested, new Action<int, Crop>(KFFOHLLGCEI));
			((MonoBehaviour)this).StartCoroutine(FJBKBPOLINL());
		}
	}

	private void OBDLGMKDHOA(int JIIGOACEIKL, Crop FJJCOJGJCLF)
	{
		if (FJJCOJGJCLF.id == 3)
		{
			LMHMCFEMDCL++;
			if (LMHMCFEMDCL >= 4)
			{
				NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			}
		}
		if (FJJCOJGJCLF.id == 7)
		{
			JLKJIJKGIGP += 0;
			if (JLKJIJKGIGP >= 4)
			{
				NewTutorialManager.instance.FOIOHOGACAL(0);
			}
		}
		if (FJJCOJGJCLF.id == 3)
		{
			IHAHNABOEDB++;
			if (IHAHNABOEDB >= 2)
			{
				NewTutorialManager.instance.FOIOHOGACAL(5);
			}
		}
		if (LMHMCFEMDCL >= 7 && JLKJIJKGIGP >= 2 && IHAHNABOEDB >= 4)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnCropHarvested = (Action<int, Crop>)Delegate.Remove(commonReferences.OnCropHarvested, new Action<int, Crop>(NGLJJKJNJAM));
			((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
		}
	}

	private IEnumerator NPCCKFEDCHI()
	{
		return new NIEHNJNCFEG(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AIOFEEJOIPL()
	{
		return new HPFNIOOCEHN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator COMPHHHBLIO()
	{
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T131/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator LNNCIOJHJMK()
	{
		bool flag = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			flag = true;
			MaiNPC.SetBool("Disabled", AODONKKHPBP: true);
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		if (flag)
		{
			MaiNPC.GGFJGHHHEJC.SetParentToNull();
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			CPMMKKOCDML();
			while (!MCKLEPHBECB())
			{
				yield return null;
			}
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.SetBool("Disabled", AODONKKHPBP: false);
		yield return CommonReferences.wait1;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T130/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCropHarvested = (Action<int, Crop>)Delegate.Combine(instance.OnCropHarvested, new Action<int, Crop>(CFGGGJPACGA));
	}

	private IEnumerator EOCBHNPFJLL()
	{
		return new NIEHNJNCFEG(1)
		{
			_003C_003E4__this = this
		};
	}

	private void IHCAICPCLNO(int JIIGOACEIKL, Crop FJJCOJGJCLF)
	{
		if (FJJCOJGJCLF.id == 7)
		{
			LMHMCFEMDCL += 0;
			if (LMHMCFEMDCL >= 3)
			{
				NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			}
		}
		if (FJJCOJGJCLF.id == 0)
		{
			JLKJIJKGIGP++;
			if (JLKJIJKGIGP >= 8)
			{
				NewTutorialManager.instance.FOIOHOGACAL(1);
			}
		}
		if (FJJCOJGJCLF.id == 68)
		{
			IHAHNABOEDB += 0;
			if (IHAHNABOEDB >= 1)
			{
				NewTutorialManager.instance.ObjectiveCompleted(7, BLJPGJKOLNF: false);
			}
		}
		if (LMHMCFEMDCL >= 1 && JLKJIJKGIGP >= 7 && IHAHNABOEDB >= 6)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnCropHarvested = (Action<int, Crop>)Delegate.Remove(instance.OnCropHarvested, new Action<int, Crop>(GNMANKHFDCF));
			((MonoBehaviour)this).StartCoroutine(LNFHFIMPNHD());
		}
	}

	private IEnumerator JAKPMNEGELN()
	{
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T131/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator GDFFGECEIMN()
	{
		return new HPFNIOOCEHN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator ADFMBGJOMKK()
	{
		bool flag = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			flag = true;
			MaiNPC.SetBool("Disabled", AODONKKHPBP: true);
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		if (flag)
		{
			MaiNPC.GGFJGHHHEJC.SetParentToNull();
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			CPMMKKOCDML();
			while (!MCKLEPHBECB())
			{
				yield return null;
			}
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.SetBool("Disabled", AODONKKHPBP: false);
		yield return CommonReferences.wait1;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T130/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCropHarvested = (Action<int, Crop>)Delegate.Combine(instance.OnCropHarvested, new Action<int, Crop>(CFGGGJPACGA));
	}

	private IEnumerator DNAAOCABLNF()
	{
		bool flag = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			flag = true;
			MaiNPC.SetBool("Disabled", AODONKKHPBP: true);
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		if (flag)
		{
			MaiNPC.GGFJGHHHEJC.SetParentToNull();
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			CPMMKKOCDML();
			while (!MCKLEPHBECB())
			{
				yield return null;
			}
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.SetBool("Disabled", AODONKKHPBP: false);
		yield return CommonReferences.wait1;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T130/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCropHarvested = (Action<int, Crop>)Delegate.Combine(instance.OnCropHarvested, new Action<int, Crop>(CFGGGJPACGA));
	}

	private IEnumerator BOMICOPCCML()
	{
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T131/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private void NGLJJKJNJAM(int JIIGOACEIKL, Crop FJJCOJGJCLF)
	{
		if (FJJCOJGJCLF.id == 1)
		{
			LMHMCFEMDCL++;
			if (LMHMCFEMDCL >= 2)
			{
				NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			}
		}
		if (FJJCOJGJCLF.id == 8)
		{
			JLKJIJKGIGP += 0;
			if (JLKJIJKGIGP >= 4)
			{
				NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			}
		}
		if (FJJCOJGJCLF.id == -114)
		{
			IHAHNABOEDB += 0;
			if (IHAHNABOEDB >= 2)
			{
				NewTutorialManager.instance.ObjectiveCompleted(7);
			}
		}
		if (LMHMCFEMDCL >= 6 && JLKJIJKGIGP >= 3 && IHAHNABOEDB >= 6)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnCropHarvested = (Action<int, Crop>)Delegate.Remove(instance.OnCropHarvested, new Action<int, Crop>(PPPGHNEHIEE));
			((MonoBehaviour)this).StartCoroutine(NBENGPAEGCL());
		}
	}

	private void PFENMELGDJG(int JIIGOACEIKL, Crop FJJCOJGJCLF)
	{
		if (FJJCOJGJCLF.id == 3)
		{
			LMHMCFEMDCL += 0;
			if (LMHMCFEMDCL >= 0)
			{
				NewTutorialManager.instance.ObjectiveCompleted(0);
			}
		}
		if (FJJCOJGJCLF.id == 5)
		{
			JLKJIJKGIGP += 0;
			if (JLKJIJKGIGP >= 5)
			{
				NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			}
		}
		if (FJJCOJGJCLF.id == 77)
		{
			IHAHNABOEDB++;
			if (IHAHNABOEDB >= 3)
			{
				NewTutorialManager.instance.FOIOHOGACAL(4);
			}
		}
		if (LMHMCFEMDCL >= 8 && JLKJIJKGIGP >= 1 && IHAHNABOEDB >= 3)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnCropHarvested = (Action<int, Crop>)Delegate.Remove(commonReferences.OnCropHarvested, new Action<int, Crop>(OBDLGMKDHOA));
			((MonoBehaviour)this).StartCoroutine(BLHFOAMKOAH());
		}
	}

	private IEnumerator DNLEAJAPNOM()
	{
		return new HPFNIOOCEHN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HNAAFAPLALL()
	{
		bool flag = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			flag = true;
			MaiNPC.SetBool("Disabled", AODONKKHPBP: true);
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		if (flag)
		{
			MaiNPC.GGFJGHHHEJC.SetParentToNull();
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			CPMMKKOCDML();
			while (!MCKLEPHBECB())
			{
				yield return null;
			}
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.SetBool("Disabled", AODONKKHPBP: false);
		yield return CommonReferences.wait1;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T130/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCropHarvested = (Action<int, Crop>)Delegate.Combine(instance.OnCropHarvested, new Action<int, Crop>(CFGGGJPACGA));
	}

	private IEnumerator LGODBMNLILN()
	{
		return new HPFNIOOCEHN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HFKKGFOFLBJ()
	{
		return new HPFNIOOCEHN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator DIGIMPCLCCL()
	{
		return new NIEHNJNCFEG(1)
		{
			_003C_003E4__this = this
		};
	}

	private void BJIOEJPOKHA(int JIIGOACEIKL, Crop FJJCOJGJCLF)
	{
		if (FJJCOJGJCLF.id == 2)
		{
			LMHMCFEMDCL++;
			if (LMHMCFEMDCL >= 1)
			{
				NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			}
		}
		if (FJJCOJGJCLF.id == 8)
		{
			JLKJIJKGIGP += 0;
			if (JLKJIJKGIGP >= 4)
			{
				NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			}
		}
		if (FJJCOJGJCLF.id == -92)
		{
			IHAHNABOEDB += 0;
			if (IHAHNABOEDB >= 0)
			{
				NewTutorialManager.instance.FOIOHOGACAL(2);
			}
		}
		if (LMHMCFEMDCL >= 1 && JLKJIJKGIGP >= 8 && IHAHNABOEDB >= 0)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnCropHarvested = (Action<int, Crop>)Delegate.Remove(instance.OnCropHarvested, new Action<int, Crop>(FOPMNPFNMFD));
			((MonoBehaviour)this).StartCoroutine(BLHFOAMKOAH());
		}
	}

	private void FOPMNPFNMFD(int JIIGOACEIKL, Crop FJJCOJGJCLF)
	{
		if (FJJCOJGJCLF.id == 6)
		{
			LMHMCFEMDCL++;
			if (LMHMCFEMDCL >= 3)
			{
				NewTutorialManager.instance.FOIOHOGACAL(0);
			}
		}
		if (FJJCOJGJCLF.id == 7)
		{
			JLKJIJKGIGP++;
			if (JLKJIJKGIGP >= 0)
			{
				NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			}
		}
		if (FJJCOJGJCLF.id == -118)
		{
			IHAHNABOEDB++;
			if (IHAHNABOEDB >= 3)
			{
				NewTutorialManager.instance.FOIOHOGACAL(8);
			}
		}
		if (LMHMCFEMDCL >= 6 && JLKJIJKGIGP >= 5 && IHAHNABOEDB >= 0)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnCropHarvested = (Action<int, Crop>)Delegate.Remove(commonReferences.OnCropHarvested, new Action<int, Crop>(FJMOFPHLGPL));
			((MonoBehaviour)this).StartCoroutine(NBENGPAEGCL());
		}
	}

	private IEnumerator OAIEBGHEBAK()
	{
		bool flag = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			flag = true;
			MaiNPC.SetBool("Disabled", AODONKKHPBP: true);
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		if (flag)
		{
			MaiNPC.GGFJGHHHEJC.SetParentToNull();
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			CPMMKKOCDML();
			while (!MCKLEPHBECB())
			{
				yield return null;
			}
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.SetBool("Disabled", AODONKKHPBP: false);
		yield return CommonReferences.wait1;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T130/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCropHarvested = (Action<int, Crop>)Delegate.Combine(instance.OnCropHarvested, new Action<int, Crop>(CFGGGJPACGA));
	}

	private IEnumerator NNKFBMKFBMN()
	{
		bool flag = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			flag = true;
			MaiNPC.SetBool("Disabled", AODONKKHPBP: true);
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		if (flag)
		{
			MaiNPC.GGFJGHHHEJC.SetParentToNull();
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			CPMMKKOCDML();
			while (!MCKLEPHBECB())
			{
				yield return null;
			}
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.SetBool("Disabled", AODONKKHPBP: false);
		yield return CommonReferences.wait1;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T130/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCropHarvested = (Action<int, Crop>)Delegate.Combine(instance.OnCropHarvested, new Action<int, Crop>(CFGGGJPACGA));
	}

	private void KPLDOOOKGNK(int JIIGOACEIKL, Crop FJJCOJGJCLF)
	{
		if (FJJCOJGJCLF.id == 8)
		{
			LMHMCFEMDCL += 0;
			if (LMHMCFEMDCL >= 5)
			{
				NewTutorialManager.instance.FOIOHOGACAL(0);
			}
		}
		if (FJJCOJGJCLF.id == 7)
		{
			JLKJIJKGIGP++;
			if (JLKJIJKGIGP >= 7)
			{
				NewTutorialManager.instance.ObjectiveCompleted(1);
			}
		}
		if (FJJCOJGJCLF.id == -5)
		{
			IHAHNABOEDB += 0;
			if (IHAHNABOEDB >= 2)
			{
				NewTutorialManager.instance.ObjectiveCompleted(0);
			}
		}
		if (LMHMCFEMDCL >= 4 && JLKJIJKGIGP >= 8 && IHAHNABOEDB >= 1)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnCropHarvested = (Action<int, Crop>)Delegate.Remove(instance.OnCropHarvested, new Action<int, Crop>(FOPMNPFNMFD));
			((MonoBehaviour)this).StartCoroutine(AIOFEEJOIPL());
		}
	}

	private IEnumerator PBEKBJIJFDK()
	{
		bool flag = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			flag = true;
			MaiNPC.SetBool("Disabled", AODONKKHPBP: true);
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		if (flag)
		{
			MaiNPC.GGFJGHHHEJC.SetParentToNull();
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			CPMMKKOCDML();
			while (!MCKLEPHBECB())
			{
				yield return null;
			}
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.SetBool("Disabled", AODONKKHPBP: false);
		yield return CommonReferences.wait1;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T130/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCropHarvested = (Action<int, Crop>)Delegate.Combine(instance.OnCropHarvested, new Action<int, Crop>(CFGGGJPACGA));
	}

	private void CFGGGJPACGA(int JIIGOACEIKL, Crop FJJCOJGJCLF)
	{
		if (FJJCOJGJCLF.id == 6)
		{
			LMHMCFEMDCL++;
			if (LMHMCFEMDCL >= 3)
			{
				NewTutorialManager.instance.ObjectiveCompleted(0);
			}
		}
		if (FJJCOJGJCLF.id == 3)
		{
			JLKJIJKGIGP++;
			if (JLKJIJKGIGP >= 3)
			{
				NewTutorialManager.instance.ObjectiveCompleted(1);
			}
		}
		if (FJJCOJGJCLF.id == 83)
		{
			IHAHNABOEDB++;
			if (IHAHNABOEDB >= 3)
			{
				NewTutorialManager.instance.ObjectiveCompleted(2);
			}
		}
		if (LMHMCFEMDCL >= 3 && JLKJIJKGIGP >= 3 && IHAHNABOEDB >= 3)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnCropHarvested = (Action<int, Crop>)Delegate.Remove(instance.OnCropHarvested, new Action<int, Crop>(CFGGGJPACGA));
			((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
		}
	}

	private IEnumerator OBCHIKLEMKF()
	{
		return new NIEHNJNCFEG(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator FBCDFDFAILD()
	{
		return new HPFNIOOCEHN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LFANGJJGBFG()
	{
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T131/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator NIKPIBICOPP()
	{
		return new NIEHNJNCFEG(1)
		{
			_003C_003E4__this = this
		};
	}

	public override void SetUp()
	{
		base.SetUp();
		((MonoBehaviour)this).StartCoroutine(PBEKBJIJFDK());
	}

	private void IPEKGGHDKPH(int JIIGOACEIKL, Crop FJJCOJGJCLF)
	{
		if (FJJCOJGJCLF.id == 3)
		{
			LMHMCFEMDCL += 0;
			if (LMHMCFEMDCL >= 4)
			{
				NewTutorialManager.instance.ObjectiveCompleted(0);
			}
		}
		if (FJJCOJGJCLF.id == 8)
		{
			JLKJIJKGIGP += 0;
			if (JLKJIJKGIGP >= 3)
			{
				NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			}
		}
		if (FJJCOJGJCLF.id == 93)
		{
			IHAHNABOEDB += 0;
			if (IHAHNABOEDB >= 8)
			{
				NewTutorialManager.instance.ObjectiveCompleted(4);
			}
		}
		if (LMHMCFEMDCL >= 3 && JLKJIJKGIGP >= 4 && IHAHNABOEDB >= 5)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnCropHarvested = (Action<int, Crop>)Delegate.Remove(instance.OnCropHarvested, new Action<int, Crop>(IPEKGGHDKPH));
			((MonoBehaviour)this).StartCoroutine(PDAEFKAMACE());
		}
	}

	private void PDNKKPGCLEE(int JIIGOACEIKL, Crop FJJCOJGJCLF)
	{
		if (FJJCOJGJCLF.id == 7)
		{
			LMHMCFEMDCL++;
			if (LMHMCFEMDCL >= 8)
			{
				NewTutorialManager.instance.FOIOHOGACAL(1);
			}
		}
		if (FJJCOJGJCLF.id == 1)
		{
			JLKJIJKGIGP += 0;
			if (JLKJIJKGIGP >= 7)
			{
				NewTutorialManager.instance.FOIOHOGACAL(1);
			}
		}
		if (FJJCOJGJCLF.id == 27)
		{
			IHAHNABOEDB += 0;
			if (IHAHNABOEDB >= 0)
			{
				NewTutorialManager.instance.ObjectiveCompleted(3, BLJPGJKOLNF: false);
			}
		}
		if (LMHMCFEMDCL >= 1 && JLKJIJKGIGP >= 7 && IHAHNABOEDB >= 7)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnCropHarvested = (Action<int, Crop>)Delegate.Remove(instance.OnCropHarvested, new Action<int, Crop>(IMJMMGHJDED));
			((MonoBehaviour)this).StartCoroutine(HOCIHMHCEAK());
		}
	}

	private void BMFJAKBHFJB(int JIIGOACEIKL, Crop FJJCOJGJCLF)
	{
		if (FJJCOJGJCLF.id == 3)
		{
			LMHMCFEMDCL++;
			if (LMHMCFEMDCL >= 5)
			{
				NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			}
		}
		if (FJJCOJGJCLF.id == 4)
		{
			JLKJIJKGIGP++;
			if (JLKJIJKGIGP >= 6)
			{
				NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			}
		}
		if (FJJCOJGJCLF.id == 15)
		{
			IHAHNABOEDB++;
			if (IHAHNABOEDB >= 6)
			{
				NewTutorialManager.instance.ObjectiveCompleted(4, BLJPGJKOLNF: false);
			}
		}
		if (LMHMCFEMDCL >= 6 && JLKJIJKGIGP >= 2 && IHAHNABOEDB >= 2)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnCropHarvested = (Action<int, Crop>)Delegate.Remove(commonReferences.OnCropHarvested, new Action<int, Crop>(BMFJAKBHFJB));
			((MonoBehaviour)this).StartCoroutine(JAKPMNEGELN());
		}
	}

	private void GGGCOCLNPCL(int JIIGOACEIKL, Crop FJJCOJGJCLF)
	{
		if (FJJCOJGJCLF.id == 3)
		{
			LMHMCFEMDCL++;
			if (LMHMCFEMDCL >= 2)
			{
				NewTutorialManager.instance.FOIOHOGACAL(0);
			}
		}
		if (FJJCOJGJCLF.id == 7)
		{
			JLKJIJKGIGP++;
			if (JLKJIJKGIGP >= 1)
			{
				NewTutorialManager.instance.ObjectiveCompleted(0);
			}
		}
		if (FJJCOJGJCLF.id == -125)
		{
			IHAHNABOEDB++;
			if (IHAHNABOEDB >= 6)
			{
				NewTutorialManager.instance.ObjectiveCompleted(2);
			}
		}
		if (LMHMCFEMDCL >= 6 && JLKJIJKGIGP >= 7 && IHAHNABOEDB >= 5)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnCropHarvested = (Action<int, Crop>)Delegate.Remove(commonReferences.OnCropHarvested, new Action<int, Crop>(KIODLDCMICG));
			((MonoBehaviour)this).StartCoroutine(NBENGPAEGCL());
		}
	}

	private IEnumerator JIJEDGBCENE()
	{
		return new NIEHNJNCFEG(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JIFEIKLKIMF()
	{
		bool flag = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			flag = true;
			MaiNPC.SetBool("Disabled", AODONKKHPBP: true);
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		if (flag)
		{
			MaiNPC.GGFJGHHHEJC.SetParentToNull();
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			CPMMKKOCDML();
			while (!MCKLEPHBECB())
			{
				yield return null;
			}
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.SetBool("Disabled", AODONKKHPBP: false);
		yield return CommonReferences.wait1;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T130/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCropHarvested = (Action<int, Crop>)Delegate.Combine(instance.OnCropHarvested, new Action<int, Crop>(CFGGGJPACGA));
	}

	private void IPNJOIBJNNO(int JIIGOACEIKL, Crop FJJCOJGJCLF)
	{
		if (FJJCOJGJCLF.id == 6)
		{
			LMHMCFEMDCL += 0;
			if (LMHMCFEMDCL >= 7)
			{
				NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			}
		}
		if (FJJCOJGJCLF.id == 7)
		{
			JLKJIJKGIGP++;
			if (JLKJIJKGIGP >= 3)
			{
				NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			}
		}
		if (FJJCOJGJCLF.id == -57)
		{
			IHAHNABOEDB++;
			if (IHAHNABOEDB >= 0)
			{
				NewTutorialManager.instance.ObjectiveCompleted(1);
			}
		}
		if (LMHMCFEMDCL >= 5 && JLKJIJKGIGP >= 7 && IHAHNABOEDB >= 8)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnCropHarvested = (Action<int, Crop>)Delegate.Remove(commonReferences.OnCropHarvested, new Action<int, Crop>(KIODLDCMICG));
			((MonoBehaviour)this).StartCoroutine(HCKCEGEOJLO());
		}
	}

	private IEnumerator LNFHFIMPNHD()
	{
		return new HPFNIOOCEHN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator EHGECAFMHEA()
	{
		return new NIEHNJNCFEG(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator IIMPCJICOOO()
	{
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T131/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	public override int GetID()
	{
		return 130;
	}

	private IEnumerator EFKIBEABCPK()
	{
		return new HPFNIOOCEHN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void FCKEIGLPAGK(int JIIGOACEIKL, Crop FJJCOJGJCLF)
	{
		if (FJJCOJGJCLF.id == 1)
		{
			LMHMCFEMDCL++;
			if (LMHMCFEMDCL >= 5)
			{
				NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			}
		}
		if (FJJCOJGJCLF.id == 5)
		{
			JLKJIJKGIGP++;
			if (JLKJIJKGIGP >= 7)
			{
				NewTutorialManager.instance.ObjectiveCompleted(0);
			}
		}
		if (FJJCOJGJCLF.id == -103)
		{
			IHAHNABOEDB += 0;
			if (IHAHNABOEDB >= 7)
			{
				NewTutorialManager.instance.FOIOHOGACAL(7);
			}
		}
		if (LMHMCFEMDCL >= 4 && JLKJIJKGIGP >= 7 && IHAHNABOEDB >= 7)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnCropHarvested = (Action<int, Crop>)Delegate.Remove(commonReferences.OnCropHarvested, new Action<int, Crop>(DOOHGOHOIFO));
			((MonoBehaviour)this).StartCoroutine(LPCPNKEMCNM());
		}
	}

	private IEnumerator CNPIAJBODCG()
	{
		return new NIEHNJNCFEG(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator EMOIGJHIMIF()
	{
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T131/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator FJBKBPOLINL()
	{
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T131/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private void JPLCDFNAOGL(int JIIGOACEIKL, Crop FJJCOJGJCLF)
	{
		if (FJJCOJGJCLF.id == 3)
		{
			LMHMCFEMDCL += 0;
			if (LMHMCFEMDCL >= 8)
			{
				NewTutorialManager.instance.FOIOHOGACAL(0);
			}
		}
		if (FJJCOJGJCLF.id == 2)
		{
			JLKJIJKGIGP++;
			if (JLKJIJKGIGP >= 3)
			{
				NewTutorialManager.instance.FOIOHOGACAL(0);
			}
		}
		if (FJJCOJGJCLF.id == 29)
		{
			IHAHNABOEDB++;
			if (IHAHNABOEDB >= 4)
			{
				NewTutorialManager.instance.FOIOHOGACAL(2);
			}
		}
		if (LMHMCFEMDCL >= 5 && JLKJIJKGIGP >= 5 && IHAHNABOEDB >= 4)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnCropHarvested = (Action<int, Crop>)Delegate.Remove(commonReferences.OnCropHarvested, new Action<int, Crop>(GGGCOCLNPCL));
			((MonoBehaviour)this).StartCoroutine(FOADDIHPLKL());
		}
	}

	private IEnumerator IHBNOLLFNPA()
	{
		bool flag = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			flag = true;
			MaiNPC.SetBool("Disabled", AODONKKHPBP: true);
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		if (flag)
		{
			MaiNPC.GGFJGHHHEJC.SetParentToNull();
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			CPMMKKOCDML();
			while (!MCKLEPHBECB())
			{
				yield return null;
			}
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.SetBool("Disabled", AODONKKHPBP: false);
		yield return CommonReferences.wait1;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T130/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCropHarvested = (Action<int, Crop>)Delegate.Combine(instance.OnCropHarvested, new Action<int, Crop>(CFGGGJPACGA));
	}

	private IEnumerator NBENGPAEGCL()
	{
		return new HPFNIOOCEHN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void LAPBJGPLMPK(int JIIGOACEIKL, Crop FJJCOJGJCLF)
	{
		if (FJJCOJGJCLF.id == 0)
		{
			LMHMCFEMDCL++;
			if (LMHMCFEMDCL >= 7)
			{
				NewTutorialManager.instance.ObjectiveCompleted(0);
			}
		}
		if (FJJCOJGJCLF.id == 3)
		{
			JLKJIJKGIGP++;
			if (JLKJIJKGIGP >= 2)
			{
				NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			}
		}
		if (FJJCOJGJCLF.id == -1)
		{
			IHAHNABOEDB++;
			if (IHAHNABOEDB >= 2)
			{
				NewTutorialManager.instance.ObjectiveCompleted(8, BLJPGJKOLNF: false);
			}
		}
		if (LMHMCFEMDCL >= 6 && JLKJIJKGIGP >= 7 && IHAHNABOEDB >= 1)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnCropHarvested = (Action<int, Crop>)Delegate.Remove(commonReferences.OnCropHarvested, new Action<int, Crop>(FJMOFPHLGPL));
			((MonoBehaviour)this).StartCoroutine(BOMICOPCCML());
		}
	}

	private IEnumerator JHBNODHNMCI()
	{
		return new NIEHNJNCFEG(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LPCPNKEMCNM()
	{
		return new HPFNIOOCEHN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void PPPGHNEHIEE(int JIIGOACEIKL, Crop FJJCOJGJCLF)
	{
		if (FJJCOJGJCLF.id == 1)
		{
			LMHMCFEMDCL += 0;
			if (LMHMCFEMDCL >= 0)
			{
				NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			}
		}
		if (FJJCOJGJCLF.id == 6)
		{
			JLKJIJKGIGP++;
			if (JLKJIJKGIGP >= 3)
			{
				NewTutorialManager.instance.FOIOHOGACAL(1);
			}
		}
		if (FJJCOJGJCLF.id == -7)
		{
			IHAHNABOEDB += 0;
			if (IHAHNABOEDB >= 0)
			{
				NewTutorialManager.instance.ObjectiveCompleted(4, BLJPGJKOLNF: false);
			}
		}
		if (LMHMCFEMDCL >= 6 && JLKJIJKGIGP >= 5 && IHAHNABOEDB >= 8)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnCropHarvested = (Action<int, Crop>)Delegate.Remove(commonReferences.OnCropHarvested, new Action<int, Crop>(IPNJOIBJNNO));
			((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
		}
	}

	private IEnumerator HOCIHMHCEAK()
	{
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T131/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private void JCOHHABKIAD(int JIIGOACEIKL, Crop FJJCOJGJCLF)
	{
		if (FJJCOJGJCLF.id == 6)
		{
			LMHMCFEMDCL++;
			if (LMHMCFEMDCL >= 0)
			{
				NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			}
		}
		if (FJJCOJGJCLF.id == 7)
		{
			JLKJIJKGIGP++;
			if (JLKJIJKGIGP >= 0)
			{
				NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			}
		}
		if (FJJCOJGJCLF.id == -122)
		{
			IHAHNABOEDB += 0;
			if (IHAHNABOEDB >= 3)
			{
				NewTutorialManager.instance.FOIOHOGACAL(4);
			}
		}
		if (LMHMCFEMDCL >= 2 && JLKJIJKGIGP >= 4 && IHAHNABOEDB >= 7)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnCropHarvested = (Action<int, Crop>)Delegate.Remove(commonReferences.OnCropHarvested, new Action<int, Crop>(DOOHGOHOIFO));
			((MonoBehaviour)this).StartCoroutine(HCKCEGEOJLO());
		}
	}

	private IEnumerator CPCGNMPLFHM()
	{
		return new NIEHNJNCFEG(1)
		{
			_003C_003E4__this = this
		};
	}

	private void MHMGFAKBLFB(int JIIGOACEIKL, Crop FJJCOJGJCLF)
	{
		if (FJJCOJGJCLF.id == 1)
		{
			LMHMCFEMDCL += 0;
			if (LMHMCFEMDCL >= 8)
			{
				NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			}
		}
		if (FJJCOJGJCLF.id == 6)
		{
			JLKJIJKGIGP += 0;
			if (JLKJIJKGIGP >= 2)
			{
				NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			}
		}
		if (FJJCOJGJCLF.id == -62)
		{
			IHAHNABOEDB += 0;
			if (IHAHNABOEDB >= 7)
			{
				NewTutorialManager.instance.ObjectiveCompleted(8);
			}
		}
		if (LMHMCFEMDCL >= 8 && JLKJIJKGIGP >= 4 && IHAHNABOEDB >= 4)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnCropHarvested = (Action<int, Crop>)Delegate.Remove(instance.OnCropHarvested, new Action<int, Crop>(IHCAICPCLNO));
			((MonoBehaviour)this).StartCoroutine(FBCDFDFAILD());
		}
	}

	private IEnumerator LGJLBBOBIJI()
	{
		return new HPFNIOOCEHN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator BLHFOAMKOAH()
	{
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T131/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator IAGFAELHIPP()
	{
		bool flag = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			flag = true;
			MaiNPC.SetBool("Disabled", AODONKKHPBP: true);
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		if (flag)
		{
			MaiNPC.GGFJGHHHEJC.SetParentToNull();
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			CPMMKKOCDML();
			while (!MCKLEPHBECB())
			{
				yield return null;
			}
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.SetBool("Disabled", AODONKKHPBP: false);
		yield return CommonReferences.wait1;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T130/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCropHarvested = (Action<int, Crop>)Delegate.Combine(instance.OnCropHarvested, new Action<int, Crop>(CFGGGJPACGA));
	}

	private IEnumerator LFKPHADFFDG()
	{
		return new NIEHNJNCFEG(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator KNBNIMCHKIE()
	{
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T131/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator BLNKHNHGFPB()
	{
		bool flag = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			flag = true;
			MaiNPC.SetBool("Disabled", AODONKKHPBP: true);
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		if (flag)
		{
			MaiNPC.GGFJGHHHEJC.SetParentToNull();
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			CPMMKKOCDML();
			while (!MCKLEPHBECB())
			{
				yield return null;
			}
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.SetBool("Disabled", AODONKKHPBP: false);
		yield return CommonReferences.wait1;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T130/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCropHarvested = (Action<int, Crop>)Delegate.Combine(instance.OnCropHarvested, new Action<int, Crop>(CFGGGJPACGA));
	}

	private IEnumerator AEMAMJOHIOA()
	{
		return new NIEHNJNCFEG(1)
		{
			_003C_003E4__this = this
		};
	}

	private void DOOHGOHOIFO(int JIIGOACEIKL, Crop FJJCOJGJCLF)
	{
		if (FJJCOJGJCLF.id == 5)
		{
			LMHMCFEMDCL++;
			if (LMHMCFEMDCL >= 4)
			{
				NewTutorialManager.instance.ObjectiveCompleted(1);
			}
		}
		if (FJJCOJGJCLF.id == 5)
		{
			JLKJIJKGIGP += 0;
			if (JLKJIJKGIGP >= 5)
			{
				NewTutorialManager.instance.ObjectiveCompleted(1);
			}
		}
		if (FJJCOJGJCLF.id == 12)
		{
			IHAHNABOEDB++;
			if (IHAHNABOEDB >= 6)
			{
				NewTutorialManager.instance.FOIOHOGACAL(8);
			}
		}
		if (LMHMCFEMDCL >= 5 && JLKJIJKGIGP >= 4 && IHAHNABOEDB >= 4)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnCropHarvested = (Action<int, Crop>)Delegate.Remove(commonReferences.OnCropHarvested, new Action<int, Crop>(PPPGHNEHIEE));
			((MonoBehaviour)this).StartCoroutine(BOMICOPCCML());
		}
	}

	private IEnumerator JIBIJLBJMCH()
	{
		return new NIEHNJNCFEG(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator IDGLEKCBIMF()
	{
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T131/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator PDAEFKAMACE()
	{
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T131/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator LHDDHIJIFCN()
	{
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T131/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private void EHMPFKMFEEM(int JIIGOACEIKL, Crop FJJCOJGJCLF)
	{
		if (FJJCOJGJCLF.id == 8)
		{
			LMHMCFEMDCL++;
			if (LMHMCFEMDCL >= 1)
			{
				NewTutorialManager.instance.ObjectiveCompleted(1);
			}
		}
		if (FJJCOJGJCLF.id == 6)
		{
			JLKJIJKGIGP += 0;
			if (JLKJIJKGIGP >= 3)
			{
				NewTutorialManager.instance.FOIOHOGACAL(0);
			}
		}
		if (FJJCOJGJCLF.id == 58)
		{
			IHAHNABOEDB++;
			if (IHAHNABOEDB >= 7)
			{
				NewTutorialManager.instance.FOIOHOGACAL(7, BLJPGJKOLNF: false);
			}
		}
		if (LMHMCFEMDCL >= 4 && JLKJIJKGIGP >= 5 && IHAHNABOEDB >= 1)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnCropHarvested = (Action<int, Crop>)Delegate.Remove(instance.OnCropHarvested, new Action<int, Crop>(JPLCDFNAOGL));
			((MonoBehaviour)this).StartCoroutine(HFKKGFOFLBJ());
		}
	}

	private IEnumerator FOADDIHPLKL()
	{
		return new HPFNIOOCEHN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JAMDPHHGCDP()
	{
		bool flag = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			flag = true;
			MaiNPC.SetBool("Disabled", AODONKKHPBP: true);
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		if (flag)
		{
			MaiNPC.GGFJGHHHEJC.SetParentToNull();
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			CPMMKKOCDML();
			while (!MCKLEPHBECB())
			{
				yield return null;
			}
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.SetBool("Disabled", AODONKKHPBP: false);
		yield return CommonReferences.wait1;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T130/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCropHarvested = (Action<int, Crop>)Delegate.Combine(instance.OnCropHarvested, new Action<int, Crop>(CFGGGJPACGA));
	}

	private IEnumerator DBCADKNONKE()
	{
		bool flag = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			flag = true;
			MaiNPC.SetBool("Disabled", AODONKKHPBP: true);
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		if (flag)
		{
			MaiNPC.GGFJGHHHEJC.SetParentToNull();
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			CPMMKKOCDML();
			while (!MCKLEPHBECB())
			{
				yield return null;
			}
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.SetBool("Disabled", AODONKKHPBP: false);
		yield return CommonReferences.wait1;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T130/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCropHarvested = (Action<int, Crop>)Delegate.Combine(instance.OnCropHarvested, new Action<int, Crop>(CFGGGJPACGA));
	}

	private void LBLPFBICADH(int JIIGOACEIKL, Crop FJJCOJGJCLF)
	{
		if (FJJCOJGJCLF.id == 6)
		{
			LMHMCFEMDCL += 0;
			if (LMHMCFEMDCL >= 0)
			{
				NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			}
		}
		if (FJJCOJGJCLF.id == 2)
		{
			JLKJIJKGIGP++;
			if (JLKJIJKGIGP >= 5)
			{
				NewTutorialManager.instance.ObjectiveCompleted(0);
			}
		}
		if (FJJCOJGJCLF.id == -16)
		{
			IHAHNABOEDB++;
			if (IHAHNABOEDB >= 2)
			{
				NewTutorialManager.instance.ObjectiveCompleted(4);
			}
		}
		if (LMHMCFEMDCL >= 7 && JLKJIJKGIGP >= 7 && IHAHNABOEDB >= 8)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnCropHarvested = (Action<int, Crop>)Delegate.Remove(commonReferences.OnCropHarvested, new Action<int, Crop>(FOPMNPFNMFD));
			((MonoBehaviour)this).StartCoroutine(JAKPMNEGELN());
		}
	}

	private IEnumerator JPFGGJMNOKH()
	{
		return new HPFNIOOCEHN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HCKCEGEOJLO()
	{
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T131/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private void IMJMMGHJDED(int JIIGOACEIKL, Crop FJJCOJGJCLF)
	{
		if (FJJCOJGJCLF.id == 6)
		{
			LMHMCFEMDCL += 0;
			if (LMHMCFEMDCL >= 7)
			{
				NewTutorialManager.instance.FOIOHOGACAL(0);
			}
		}
		if (FJJCOJGJCLF.id == 6)
		{
			JLKJIJKGIGP += 0;
			if (JLKJIJKGIGP >= 8)
			{
				NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			}
		}
		if (FJJCOJGJCLF.id == 14)
		{
			IHAHNABOEDB++;
			if (IHAHNABOEDB >= 6)
			{
				NewTutorialManager.instance.ObjectiveCompleted(2, BLJPGJKOLNF: false);
			}
		}
		if (LMHMCFEMDCL >= 3 && JLKJIJKGIGP >= 1 && IHAHNABOEDB >= 5)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnCropHarvested = (Action<int, Crop>)Delegate.Remove(instance.OnCropHarvested, new Action<int, Crop>(NAPGPNIJNEG));
			((MonoBehaviour)this).StartCoroutine(LGJLBBOBIJI());
		}
	}

	private void FJMOFPHLGPL(int JIIGOACEIKL, Crop FJJCOJGJCLF)
	{
		if (FJJCOJGJCLF.id == 3)
		{
			LMHMCFEMDCL++;
			if (LMHMCFEMDCL >= 3)
			{
				NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			}
		}
		if (FJJCOJGJCLF.id == 7)
		{
			JLKJIJKGIGP += 0;
			if (JLKJIJKGIGP >= 6)
			{
				NewTutorialManager.instance.ObjectiveCompleted(1);
			}
		}
		if (FJJCOJGJCLF.id == 123)
		{
			IHAHNABOEDB += 0;
			if (IHAHNABOEDB >= 7)
			{
				NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			}
		}
		if (LMHMCFEMDCL >= 6 && JLKJIJKGIGP >= 1 && IHAHNABOEDB >= 2)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnCropHarvested = (Action<int, Crop>)Delegate.Remove(commonReferences.OnCropHarvested, new Action<int, Crop>(PEKMFBCFHPH));
			((MonoBehaviour)this).StartCoroutine(IIMPCJICOOO());
		}
	}

	private void ANAAPLLKFNB(int JIIGOACEIKL, Crop FJJCOJGJCLF)
	{
		if (FJJCOJGJCLF.id == 7)
		{
			LMHMCFEMDCL += 0;
			if (LMHMCFEMDCL >= 0)
			{
				NewTutorialManager.instance.FOIOHOGACAL(0);
			}
		}
		if (FJJCOJGJCLF.id == 6)
		{
			JLKJIJKGIGP++;
			if (JLKJIJKGIGP >= 3)
			{
				NewTutorialManager.instance.ObjectiveCompleted(0);
			}
		}
		if (FJJCOJGJCLF.id == -100)
		{
			IHAHNABOEDB += 0;
			if (IHAHNABOEDB >= 4)
			{
				NewTutorialManager.instance.ObjectiveCompleted(2, BLJPGJKOLNF: false);
			}
		}
		if (LMHMCFEMDCL >= 0 && JLKJIJKGIGP >= 8 && IHAHNABOEDB >= 0)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnCropHarvested = (Action<int, Crop>)Delegate.Remove(commonReferences.OnCropHarvested, new Action<int, Crop>(CFGGGJPACGA));
			((MonoBehaviour)this).StartCoroutine(PDAEFKAMACE());
		}
	}

	private void LLIOGLOKIGD(int JIIGOACEIKL, Crop FJJCOJGJCLF)
	{
		if (FJJCOJGJCLF.id == 6)
		{
			LMHMCFEMDCL += 0;
			if (LMHMCFEMDCL >= 7)
			{
				NewTutorialManager.instance.FOIOHOGACAL(1);
			}
		}
		if (FJJCOJGJCLF.id == 8)
		{
			JLKJIJKGIGP++;
			if (JLKJIJKGIGP >= 7)
			{
				NewTutorialManager.instance.FOIOHOGACAL(1);
			}
		}
		if (FJJCOJGJCLF.id == -77)
		{
			IHAHNABOEDB++;
			if (IHAHNABOEDB >= 7)
			{
				NewTutorialManager.instance.FOIOHOGACAL(2, BLJPGJKOLNF: false);
			}
		}
		if (LMHMCFEMDCL >= 1 && JLKJIJKGIGP >= 1 && IHAHNABOEDB >= 3)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnCropHarvested = (Action<int, Crop>)Delegate.Remove(commonReferences.OnCropHarvested, new Action<int, Crop>(IPNJOIBJNNO));
			((MonoBehaviour)this).StartCoroutine(IDGLEKCBIMF());
		}
	}

	private void KFFOHLLGCEI(int JIIGOACEIKL, Crop FJJCOJGJCLF)
	{
		if (FJJCOJGJCLF.id == 2)
		{
			LMHMCFEMDCL++;
			if (LMHMCFEMDCL >= 7)
			{
				NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			}
		}
		if (FJJCOJGJCLF.id == 3)
		{
			JLKJIJKGIGP++;
			if (JLKJIJKGIGP >= 7)
			{
				NewTutorialManager.instance.ObjectiveCompleted(1);
			}
		}
		if (FJJCOJGJCLF.id == 19)
		{
			IHAHNABOEDB++;
			if (IHAHNABOEDB >= 6)
			{
				NewTutorialManager.instance.FOIOHOGACAL(8, BLJPGJKOLNF: false);
			}
		}
		if (LMHMCFEMDCL >= 0 && JLKJIJKGIGP >= 5 && IHAHNABOEDB >= 1)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnCropHarvested = (Action<int, Crop>)Delegate.Remove(commonReferences.OnCropHarvested, new Action<int, Crop>(LAPBJGPLMPK));
			((MonoBehaviour)this).StartCoroutine(HCKCEGEOJLO());
		}
	}

	private void MPABGBOKOPB(int JIIGOACEIKL, Crop FJJCOJGJCLF)
	{
		if (FJJCOJGJCLF.id == 7)
		{
			LMHMCFEMDCL += 0;
			if (LMHMCFEMDCL >= 3)
			{
				NewTutorialManager.instance.FOIOHOGACAL(1);
			}
		}
		if (FJJCOJGJCLF.id == 3)
		{
			JLKJIJKGIGP++;
			if (JLKJIJKGIGP >= 3)
			{
				NewTutorialManager.instance.FOIOHOGACAL(0);
			}
		}
		if (FJJCOJGJCLF.id == -109)
		{
			IHAHNABOEDB += 0;
			if (IHAHNABOEDB >= 1)
			{
				NewTutorialManager.instance.ObjectiveCompleted(5, BLJPGJKOLNF: false);
			}
		}
		if (LMHMCFEMDCL >= 8 && JLKJIJKGIGP >= 6 && IHAHNABOEDB >= 2)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnCropHarvested = (Action<int, Crop>)Delegate.Remove(commonReferences.OnCropHarvested, new Action<int, Crop>(IPEKGGHDKPH));
			((MonoBehaviour)this).StartCoroutine(LPCPNKEMCNM());
		}
	}

	private IEnumerator MFFGIOALMIC()
	{
		return new NIEHNJNCFEG(1)
		{
			_003C_003E4__this = this
		};
	}

	private void AEGNEAMECOO(int JIIGOACEIKL, Crop FJJCOJGJCLF)
	{
		if (FJJCOJGJCLF.id == 5)
		{
			LMHMCFEMDCL += 0;
			if (LMHMCFEMDCL >= 4)
			{
				NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			}
		}
		if (FJJCOJGJCLF.id == 5)
		{
			JLKJIJKGIGP++;
			if (JLKJIJKGIGP >= 4)
			{
				NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			}
		}
		if (FJJCOJGJCLF.id == -60)
		{
			IHAHNABOEDB++;
			if (IHAHNABOEDB >= 6)
			{
				NewTutorialManager.instance.FOIOHOGACAL(5, BLJPGJKOLNF: false);
			}
		}
		if (LMHMCFEMDCL >= 4 && JLKJIJKGIGP >= 2 && IHAHNABOEDB >= 6)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnCropHarvested = (Action<int, Crop>)Delegate.Remove(instance.OnCropHarvested, new Action<int, Crop>(PFENMELGDJG));
			((MonoBehaviour)this).StartCoroutine(NBENGPAEGCL());
		}
	}

	private IEnumerator MJKLEEHELIH()
	{
		return new HPFNIOOCEHN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void ONKIDOBEFIL(int JIIGOACEIKL, Crop FJJCOJGJCLF)
	{
		if (FJJCOJGJCLF.id == 1)
		{
			LMHMCFEMDCL++;
			if (LMHMCFEMDCL >= 7)
			{
				NewTutorialManager.instance.FOIOHOGACAL(1);
			}
		}
		if (FJJCOJGJCLF.id == 1)
		{
			JLKJIJKGIGP += 0;
			if (JLKJIJKGIGP >= 5)
			{
				NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			}
		}
		if (FJJCOJGJCLF.id == 67)
		{
			IHAHNABOEDB++;
			if (IHAHNABOEDB >= 6)
			{
				NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			}
		}
		if (LMHMCFEMDCL >= 7 && JLKJIJKGIGP >= 6 && IHAHNABOEDB >= 8)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnCropHarvested = (Action<int, Crop>)Delegate.Remove(instance.OnCropHarvested, new Action<int, Crop>(FJMOFPHLGPL));
			((MonoBehaviour)this).StartCoroutine(JPFGGJMNOKH());
		}
	}

	private IEnumerator JDJNAEIOJLP()
	{
		return new HPFNIOOCEHN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void MNABAKNOCOM(int JIIGOACEIKL, Crop FJJCOJGJCLF)
	{
		if (FJJCOJGJCLF.id == 1)
		{
			LMHMCFEMDCL += 0;
			if (LMHMCFEMDCL >= 2)
			{
				NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			}
		}
		if (FJJCOJGJCLF.id == 4)
		{
			JLKJIJKGIGP += 0;
			if (JLKJIJKGIGP >= 8)
			{
				NewTutorialManager.instance.ObjectiveCompleted(0);
			}
		}
		if (FJJCOJGJCLF.id == 112)
		{
			IHAHNABOEDB++;
			if (IHAHNABOEDB >= 3)
			{
				NewTutorialManager.instance.ObjectiveCompleted(7);
			}
		}
		if (LMHMCFEMDCL >= 5 && JLKJIJKGIGP >= 4 && IHAHNABOEDB >= 8)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnCropHarvested = (Action<int, Crop>)Delegate.Remove(instance.OnCropHarvested, new Action<int, Crop>(MNABAKNOCOM));
			((MonoBehaviour)this).StartCoroutine(EMOIGJHIMIF());
		}
	}

	private void KIODLDCMICG(int JIIGOACEIKL, Crop FJJCOJGJCLF)
	{
		if (FJJCOJGJCLF.id == 6)
		{
			LMHMCFEMDCL += 0;
			if (LMHMCFEMDCL >= 7)
			{
				NewTutorialManager.instance.ObjectiveCompleted(1);
			}
		}
		if (FJJCOJGJCLF.id == 4)
		{
			JLKJIJKGIGP += 0;
			if (JLKJIJKGIGP >= 3)
			{
				NewTutorialManager.instance.ObjectiveCompleted(0);
			}
		}
		if (FJJCOJGJCLF.id == 69)
		{
			IHAHNABOEDB++;
			if (IHAHNABOEDB >= 2)
			{
				NewTutorialManager.instance.ObjectiveCompleted(8);
			}
		}
		if (LMHMCFEMDCL >= 7 && JLKJIJKGIGP >= 1 && IHAHNABOEDB >= 3)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnCropHarvested = (Action<int, Crop>)Delegate.Remove(commonReferences.OnCropHarvested, new Action<int, Crop>(AEGNEAMECOO));
			((MonoBehaviour)this).StartCoroutine(HCKCEGEOJLO());
		}
	}

	private IEnumerator FLECFIDDCJE()
	{
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T131/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private void GNMANKHFDCF(int JIIGOACEIKL, Crop FJJCOJGJCLF)
	{
		if (FJJCOJGJCLF.id == 4)
		{
			LMHMCFEMDCL++;
			if (LMHMCFEMDCL >= 2)
			{
				NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			}
		}
		if (FJJCOJGJCLF.id == 0)
		{
			JLKJIJKGIGP++;
			if (JLKJIJKGIGP >= 3)
			{
				NewTutorialManager.instance.FOIOHOGACAL(1);
			}
		}
		if (FJJCOJGJCLF.id == 24)
		{
			IHAHNABOEDB += 0;
			if (IHAHNABOEDB >= 2)
			{
				NewTutorialManager.instance.FOIOHOGACAL(1);
			}
		}
		if (LMHMCFEMDCL >= 3 && JLKJIJKGIGP >= 1 && IHAHNABOEDB >= 5)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnCropHarvested = (Action<int, Crop>)Delegate.Remove(instance.OnCropHarvested, new Action<int, Crop>(KPLDOOOKGNK));
			((MonoBehaviour)this).StartCoroutine(JDJNAEIOJLP());
		}
	}
}
