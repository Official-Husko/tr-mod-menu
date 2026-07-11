using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class T120_PlantarSemillas : TutorialPhaseBase
{
	[CompilerGenerated]
	private sealed class LLABKJKCFJN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T120_PlantarSemillas _003C_003E4__this;

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
		public LLABKJKCFJN(int _003C_003E1__state)
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
			T120_PlantarSemillas t120_PlantarSemillas = _003C_003E4__this;
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
				MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T121/Dialogue2");
				goto IL_0077;
			case 2:
				_003C_003E1__state = -1;
				goto IL_0077;
			case 3:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 4;
				return true;
			case 4:
				{
					_003C_003E1__state = -1;
					t120_PlantarSemillas.LHKIJABBBPM();
					return false;
				}
				IL_0077:
				if (t120_PlantarSemillas.AAOPIEDAKKD(2))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 2;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait1;
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
	private sealed class GHAEMKGGABA : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public int seedID;

		public T120_PlantarSemillas _003C_003E4__this;

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
		public GHAEMKGGABA(int _003C_003E1__state)
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
			T120_PlantarSemillas t120_PlantarSemillas = _003C_003E4__this;
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
				if (seedID == 3019)
				{
					t120_PlantarSemillas.LMHMCFEMDCL++;
					if (t120_PlantarSemillas.LMHMCFEMDCL == 3)
					{
						NewTutorialManager.instance.ObjectiveCompleted(0);
					}
				}
				if (seedID == 4)
				{
					t120_PlantarSemillas.JLKJIJKGIGP++;
					if (t120_PlantarSemillas.JLKJIJKGIGP == 3)
					{
						NewTutorialManager.instance.ObjectiveCompleted(1);
					}
				}
				if (seedID == 3059)
				{
					t120_PlantarSemillas.IHAHNABOEDB++;
					if (t120_PlantarSemillas.IHAHNABOEDB == 3)
					{
						NewTutorialManager.instance.ObjectiveCompleted(2);
					}
				}
				if (t120_PlantarSemillas.LMHMCFEMDCL >= 3 && t120_PlantarSemillas.JLKJIJKGIGP >= 3 && t120_PlantarSemillas.IHAHNABOEDB >= 3)
				{
					CommonReferences instance = CommonReferences.GGFJGHHHEJC;
					instance.OnSeedPlanted = (Action<int, int>)Delegate.Remove(instance.OnSeedPlanted, new Action<int, int>(t120_PlantarSemillas.CHADOMCDNGL));
					((MonoBehaviour)t120_PlantarSemillas).StartCoroutine(t120_PlantarSemillas.LHDDHIJIFCN());
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
	private sealed class NIEHNJNCFEG : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T120_PlantarSemillas _003C_003E4__this;

		private bool _003CloadedFromSave_003E5__2;

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
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			T120_PlantarSemillas t120_PlantarSemillas = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003CloadedFromSave_003E5__2 = false;
				if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
				{
					_003CloadedFromSave_003E5__2 = true;
					((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
					_003C_003E2__current = CommonReferences.wait02;
					_003C_003E1__state = 1;
					return true;
				}
				goto IL_00d7;
			case 1:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
				MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
				CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
				goto IL_00d7;
			case 2:
				_003C_003E1__state = -1;
				goto IL_00d7;
			case 3:
				_003C_003E1__state = -1;
				NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 4;
				return true;
			case 4:
				_003C_003E1__state = -1;
				if (_003CloadedFromSave_003E5__2)
				{
					MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
				}
				MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T120/Dialogue1", t120_PlantarSemillas.triggerPlayerNum);
				goto IL_0169;
			case 5:
				_003C_003E1__state = -1;
				goto IL_0169;
			case 6:
				{
					_003C_003E1__state = -1;
					NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
					NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
					CommonReferences instance = CommonReferences.GGFJGHHHEJC;
					instance.OnSeedPlanted = (Action<int, int>)Delegate.Combine(instance.OnSeedPlanted, new Action<int, int>(t120_PlantarSemillas.CHADOMCDNGL));
					return false;
				}
				IL_0169:
				if (t120_PlantarSemillas.AAOPIEDAKKD(1))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 5;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 6;
				return true;
				IL_00d7:
				if (!t120_PlantarSemillas.MCKLEPHBECB())
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 2;
					return true;
				}
				_003C_003E2__current = ((MonoBehaviour)t120_PlantarSemillas).StartCoroutine(t120_PlantarSemillas.CDICFNAMCEE());
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

	private int LMHMCFEMDCL;

	private int JLKJIJKGIGP;

	private int IHAHNABOEDB;

	private void KCMGGLDMDDC(int JIIGOACEIKL, int BCBFHGNJLOA)
	{
		((MonoBehaviour)this).StartCoroutine(MJNDLLPPLEN(JIIGOACEIKL, BCBFHGNJLOA));
	}

	public override void SetUp()
	{
		base.SetUp();
		((MonoBehaviour)this).StartCoroutine(PBEKBJIJFDK());
	}

	private IEnumerator IGKHMADCKHC(int JIIGOACEIKL, int BCBFHGNJLOA)
	{
		yield return null;
		if (BCBFHGNJLOA == 3019)
		{
			LMHMCFEMDCL++;
			if (LMHMCFEMDCL == 3)
			{
				NewTutorialManager.instance.ObjectiveCompleted(0);
			}
		}
		if (BCBFHGNJLOA == 4)
		{
			JLKJIJKGIGP++;
			if (JLKJIJKGIGP == 3)
			{
				NewTutorialManager.instance.ObjectiveCompleted(1);
			}
		}
		if (BCBFHGNJLOA == 3059)
		{
			IHAHNABOEDB++;
			if (IHAHNABOEDB == 3)
			{
				NewTutorialManager.instance.ObjectiveCompleted(2);
			}
		}
		if (LMHMCFEMDCL >= 3 && JLKJIJKGIGP >= 3 && IHAHNABOEDB >= 3)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnSeedPlanted = (Action<int, int>)Delegate.Remove(instance.OnSeedPlanted, new Action<int, int>(CHADOMCDNGL));
			((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
		}
	}

	private IEnumerator DECKMELAPMA()
	{
		return new NIEHNJNCFEG(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator PAJJMLCLHHK()
	{
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T121/Dialogue2");
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private void BKHLGCDJCAP(int JIIGOACEIKL, int BCBFHGNJLOA)
	{
		((MonoBehaviour)this).StartCoroutine(IGKHMADCKHC(JIIGOACEIKL, BCBFHGNJLOA));
	}

	private void IBDGJAFBAAL(int JIIGOACEIKL, int BCBFHGNJLOA)
	{
		((MonoBehaviour)this).StartCoroutine(LOLMACNKPJB(JIIGOACEIKL, BCBFHGNJLOA));
	}

	private IEnumerator LKAGLINOIMK()
	{
		return new NIEHNJNCFEG(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator MJNDLLPPLEN(int JIIGOACEIKL, int BCBFHGNJLOA)
	{
		return new GHAEMKGGABA(1)
		{
			_003C_003E4__this = this,
			seedID = BCBFHGNJLOA
		};
	}

	private void IHNJIACNICP(int JIIGOACEIKL, int BCBFHGNJLOA)
	{
		((MonoBehaviour)this).StartCoroutine(DMLCOJOADAF(JIIGOACEIKL, BCBFHGNJLOA));
	}

	private void PLCNKLHCBOA(int JIIGOACEIKL, int BCBFHGNJLOA)
	{
		((MonoBehaviour)this).StartCoroutine(DMLCOJOADAF(JIIGOACEIKL, BCBFHGNJLOA));
	}

	private IEnumerator FHCNAFEMIGK()
	{
		bool loadedFromSave = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			loadedFromSave = true;
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		while (!MCKLEPHBECB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait1;
		if (loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T120/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnSeedPlanted = (Action<int, int>)Delegate.Combine(instance.OnSeedPlanted, new Action<int, int>(CHADOMCDNGL));
	}

	private void IEEEKMBEGIL(int JIIGOACEIKL, int BCBFHGNJLOA)
	{
		((MonoBehaviour)this).StartCoroutine(IGKHMADCKHC(JIIGOACEIKL, BCBFHGNJLOA));
	}

	private IEnumerator NHPCNDODFAK()
	{
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T121/Dialogue2");
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator KFJOPKPJGLI(int JIIGOACEIKL, int BCBFHGNJLOA)
	{
		yield return null;
		if (BCBFHGNJLOA == 3019)
		{
			LMHMCFEMDCL++;
			if (LMHMCFEMDCL == 3)
			{
				NewTutorialManager.instance.ObjectiveCompleted(0);
			}
		}
		if (BCBFHGNJLOA == 4)
		{
			JLKJIJKGIGP++;
			if (JLKJIJKGIGP == 3)
			{
				NewTutorialManager.instance.ObjectiveCompleted(1);
			}
		}
		if (BCBFHGNJLOA == 3059)
		{
			IHAHNABOEDB++;
			if (IHAHNABOEDB == 3)
			{
				NewTutorialManager.instance.ObjectiveCompleted(2);
			}
		}
		if (LMHMCFEMDCL >= 3 && JLKJIJKGIGP >= 3 && IHAHNABOEDB >= 3)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnSeedPlanted = (Action<int, int>)Delegate.Remove(instance.OnSeedPlanted, new Action<int, int>(CHADOMCDNGL));
			((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
		}
	}

	private IEnumerator LNNCIOJHJMK()
	{
		bool loadedFromSave = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			loadedFromSave = true;
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		while (!MCKLEPHBECB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait1;
		if (loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T120/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnSeedPlanted = (Action<int, int>)Delegate.Combine(instance.OnSeedPlanted, new Action<int, int>(CHADOMCDNGL));
	}

	private IEnumerator LOLMACNKPJB(int JIIGOACEIKL, int BCBFHGNJLOA)
	{
		yield return null;
		if (BCBFHGNJLOA == 3019)
		{
			LMHMCFEMDCL++;
			if (LMHMCFEMDCL == 3)
			{
				NewTutorialManager.instance.ObjectiveCompleted(0);
			}
		}
		if (BCBFHGNJLOA == 4)
		{
			JLKJIJKGIGP++;
			if (JLKJIJKGIGP == 3)
			{
				NewTutorialManager.instance.ObjectiveCompleted(1);
			}
		}
		if (BCBFHGNJLOA == 3059)
		{
			IHAHNABOEDB++;
			if (IHAHNABOEDB == 3)
			{
				NewTutorialManager.instance.ObjectiveCompleted(2);
			}
		}
		if (LMHMCFEMDCL >= 3 && JLKJIJKGIGP >= 3 && IHAHNABOEDB >= 3)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnSeedPlanted = (Action<int, int>)Delegate.Remove(instance.OnSeedPlanted, new Action<int, int>(CHADOMCDNGL));
			((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
		}
	}

	private IEnumerator CFGLAPAKKAL()
	{
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T121/Dialogue2");
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator MDFFFPLNDAP()
	{
		bool loadedFromSave = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			loadedFromSave = true;
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		while (!MCKLEPHBECB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait1;
		if (loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T120/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnSeedPlanted = (Action<int, int>)Delegate.Combine(instance.OnSeedPlanted, new Action<int, int>(CHADOMCDNGL));
	}

	private IEnumerator PDGKDPMDJNH(int JIIGOACEIKL, int BCBFHGNJLOA)
	{
		yield return null;
		if (BCBFHGNJLOA == 3019)
		{
			LMHMCFEMDCL++;
			if (LMHMCFEMDCL == 3)
			{
				NewTutorialManager.instance.ObjectiveCompleted(0);
			}
		}
		if (BCBFHGNJLOA == 4)
		{
			JLKJIJKGIGP++;
			if (JLKJIJKGIGP == 3)
			{
				NewTutorialManager.instance.ObjectiveCompleted(1);
			}
		}
		if (BCBFHGNJLOA == 3059)
		{
			IHAHNABOEDB++;
			if (IHAHNABOEDB == 3)
			{
				NewTutorialManager.instance.ObjectiveCompleted(2);
			}
		}
		if (LMHMCFEMDCL >= 3 && JLKJIJKGIGP >= 3 && IHAHNABOEDB >= 3)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnSeedPlanted = (Action<int, int>)Delegate.Remove(instance.OnSeedPlanted, new Action<int, int>(CHADOMCDNGL));
			((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
		}
	}

	private void CPACHNJDCMP(int JIIGOACEIKL, int BCBFHGNJLOA)
	{
		((MonoBehaviour)this).StartCoroutine(LOLMACNKPJB(JIIGOACEIKL, BCBFHGNJLOA));
	}

	private IEnumerator IHGGOFFGMBD()
	{
		return new LLABKJKCFJN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void MOJGGJENCLB(int JIIGOACEIKL, int BCBFHGNJLOA)
	{
		((MonoBehaviour)this).StartCoroutine(MJNDLLPPLEN(JIIGOACEIKL, BCBFHGNJLOA));
	}

	private IEnumerator BLHFOAMKOAH()
	{
		return new LLABKJKCFJN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NIKPIBICOPP()
	{
		bool loadedFromSave = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			loadedFromSave = true;
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		while (!MCKLEPHBECB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait1;
		if (loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T120/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnSeedPlanted = (Action<int, int>)Delegate.Combine(instance.OnSeedPlanted, new Action<int, int>(CHADOMCDNGL));
	}

	private IEnumerator PBEKBJIJFDK()
	{
		bool loadedFromSave = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			loadedFromSave = true;
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		while (!MCKLEPHBECB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait1;
		if (loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T120/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnSeedPlanted = (Action<int, int>)Delegate.Combine(instance.OnSeedPlanted, new Action<int, int>(CHADOMCDNGL));
	}

	private IEnumerator LPCPNKEMCNM()
	{
		return new LLABKJKCFJN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator KCLEEGCDICH(int JIIGOACEIKL, int BCBFHGNJLOA)
	{
		return new GHAEMKGGABA(1)
		{
			_003C_003E4__this = this,
			seedID = BCBFHGNJLOA
		};
	}

	private IEnumerator OGOFIFJCMEB()
	{
		bool loadedFromSave = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			loadedFromSave = true;
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		while (!MCKLEPHBECB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait1;
		if (loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T120/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnSeedPlanted = (Action<int, int>)Delegate.Combine(instance.OnSeedPlanted, new Action<int, int>(CHADOMCDNGL));
	}

	private void AKDIOEAEGID(int JIIGOACEIKL, int BCBFHGNJLOA)
	{
		((MonoBehaviour)this).StartCoroutine(DMLCOJOADAF(JIIGOACEIKL, BCBFHGNJLOA));
	}

	private void CHADOMCDNGL(int JIIGOACEIKL, int BCBFHGNJLOA)
	{
		((MonoBehaviour)this).StartCoroutine(PDGKDPMDJNH(JIIGOACEIKL, BCBFHGNJLOA));
	}

	private IEnumerator MFFGIOALMIC()
	{
		return new NIEHNJNCFEG(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator FBOBCKJGPMB()
	{
		return new NIEHNJNCFEG(1)
		{
			_003C_003E4__this = this
		};
	}

	public override int GetID()
	{
		return 120;
	}

	private IEnumerator JIJEDGBCENE()
	{
		bool loadedFromSave = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			loadedFromSave = true;
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		while (!MCKLEPHBECB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait1;
		if (loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T120/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnSeedPlanted = (Action<int, int>)Delegate.Combine(instance.OnSeedPlanted, new Action<int, int>(CHADOMCDNGL));
	}

	private IEnumerator OOGKJFJEHFO()
	{
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T121/Dialogue2");
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private void EAPLDJEJKLA(int JIIGOACEIKL, int BCBFHGNJLOA)
	{
		((MonoBehaviour)this).StartCoroutine(KCLEEGCDICH(JIIGOACEIKL, BCBFHGNJLOA));
	}

	private IEnumerator PPMPKJECPDE()
	{
		bool loadedFromSave = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			loadedFromSave = true;
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		while (!MCKLEPHBECB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait1;
		if (loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T120/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnSeedPlanted = (Action<int, int>)Delegate.Combine(instance.OnSeedPlanted, new Action<int, int>(CHADOMCDNGL));
	}

	private void CGGFABDGOEJ(int JIIGOACEIKL, int BCBFHGNJLOA)
	{
		((MonoBehaviour)this).StartCoroutine(KCLEEGCDICH(JIIGOACEIKL, BCBFHGNJLOA));
	}

	private IEnumerator AJGJPBMIEJJ()
	{
		return new LLABKJKCFJN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void AHEMFKMJBPN(int JIIGOACEIKL, int BCBFHGNJLOA)
	{
		((MonoBehaviour)this).StartCoroutine(GAFFBGNLCNA(JIIGOACEIKL, BCBFHGNJLOA));
	}

	private IEnumerator JHBNODHNMCI()
	{
		return new NIEHNJNCFEG(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator DMLCOJOADAF(int JIIGOACEIKL, int BCBFHGNJLOA)
	{
		yield return null;
		if (BCBFHGNJLOA == 3019)
		{
			LMHMCFEMDCL++;
			if (LMHMCFEMDCL == 3)
			{
				NewTutorialManager.instance.ObjectiveCompleted(0);
			}
		}
		if (BCBFHGNJLOA == 4)
		{
			JLKJIJKGIGP++;
			if (JLKJIJKGIGP == 3)
			{
				NewTutorialManager.instance.ObjectiveCompleted(1);
			}
		}
		if (BCBFHGNJLOA == 3059)
		{
			IHAHNABOEDB++;
			if (IHAHNABOEDB == 3)
			{
				NewTutorialManager.instance.ObjectiveCompleted(2);
			}
		}
		if (LMHMCFEMDCL >= 3 && JLKJIJKGIGP >= 3 && IHAHNABOEDB >= 3)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnSeedPlanted = (Action<int, int>)Delegate.Remove(instance.OnSeedPlanted, new Action<int, int>(CHADOMCDNGL));
			((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
		}
	}

	private IEnumerator LHDDHIJIFCN()
	{
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T121/Dialogue2");
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator GAFFBGNLCNA(int JIIGOACEIKL, int BCBFHGNJLOA)
	{
		yield return null;
		if (BCBFHGNJLOA == 3019)
		{
			LMHMCFEMDCL++;
			if (LMHMCFEMDCL == 3)
			{
				NewTutorialManager.instance.ObjectiveCompleted(0);
			}
		}
		if (BCBFHGNJLOA == 4)
		{
			JLKJIJKGIGP++;
			if (JLKJIJKGIGP == 3)
			{
				NewTutorialManager.instance.ObjectiveCompleted(1);
			}
		}
		if (BCBFHGNJLOA == 3059)
		{
			IHAHNABOEDB++;
			if (IHAHNABOEDB == 3)
			{
				NewTutorialManager.instance.ObjectiveCompleted(2);
			}
		}
		if (LMHMCFEMDCL >= 3 && JLKJIJKGIGP >= 3 && IHAHNABOEDB >= 3)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnSeedPlanted = (Action<int, int>)Delegate.Remove(instance.OnSeedPlanted, new Action<int, int>(CHADOMCDNGL));
			((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
		}
	}

	private IEnumerator LFANGJJGBFG()
	{
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T121/Dialogue2");
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator JAMDPHHGCDP()
	{
		bool loadedFromSave = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			loadedFromSave = true;
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		while (!MCKLEPHBECB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait1;
		if (loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T120/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnSeedPlanted = (Action<int, int>)Delegate.Combine(instance.OnSeedPlanted, new Action<int, int>(CHADOMCDNGL));
	}

	private IEnumerator OBCHIKLEMKF()
	{
		bool loadedFromSave = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			loadedFromSave = true;
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		while (!MCKLEPHBECB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait1;
		if (loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T120/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnSeedPlanted = (Action<int, int>)Delegate.Combine(instance.OnSeedPlanted, new Action<int, int>(CHADOMCDNGL));
	}

	private IEnumerator AJOIEAICINP()
	{
		bool loadedFromSave = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			loadedFromSave = true;
			((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
			yield return CommonReferences.wait02;
			MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		while (!MCKLEPHBECB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait1;
		if (loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T120/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnSeedPlanted = (Action<int, int>)Delegate.Combine(instance.OnSeedPlanted, new Action<int, int>(CHADOMCDNGL));
	}

	private IEnumerator CIBIOLGHPJF()
	{
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T121/Dialogue2");
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}
}
