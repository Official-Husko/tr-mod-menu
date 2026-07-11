using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class T119_DespejarTerreno : TutorialPhaseBase
{
	[CompilerGenerated]
	private sealed class LLABKJKCFJN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T119_DespejarTerreno _003C_003E4__this;

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
			T119_DespejarTerreno t119_DespejarTerreno = _003C_003E4__this;
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
				t119_DespejarTerreno.LHKIJABBBPM();
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
	private sealed class PCDGAFFFPGD : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T119_DespejarTerreno _003C_003E4__this;

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
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			T119_DespejarTerreno t119_DespejarTerreno = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
				((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
				((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
				_003C_003E2__current = CommonReferences.wait02;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
				MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
				goto IL_00c6;
			case 2:
				_003C_003E1__state = -1;
				goto IL_00c6;
			case 3:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
				NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
				MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T119/Dialogue1", t119_DespejarTerreno.triggerPlayerNum);
				goto IL_012e;
			case 4:
				_003C_003E1__state = -1;
				goto IL_012e;
			case 5:
				{
					_003C_003E1__state = -1;
					NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
					NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
					CommonReferences instance = CommonReferences.GGFJGHHHEJC;
					instance.OnActionDone = (Action<int, ActionDone>)Delegate.Combine(instance.OnActionDone, new Action<int, ActionDone>(t119_DespejarTerreno.CHADOMCDNGL));
					return false;
				}
				IL_012e:
				if (t119_DespejarTerreno.AAOPIEDAKKD(1))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 4;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 5;
				return true;
				IL_00c6:
				if (!t119_DespejarTerreno.MCKLEPHBECB())
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

	private int IAMOABBEECD = 9;

	private int NLACLCKKJIG = 9;

	private bool OCOCLAKJHCC;

	private bool OBBCDHJNDOC;

	private IEnumerator DECKMELAPMA()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (!MCKLEPHBECB())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T119/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnActionDone = (Action<int, ActionDone>)Delegate.Combine(instance.OnActionDone, new Action<int, ActionDone>(CHADOMCDNGL));
	}

	private void CHADOMCDNGL(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		switch (OKNOJJEFEBE)
		{
		case ActionDone.CutGrass:
			IAMOABBEECD--;
			if (!OCOCLAKJHCC && IAMOABBEECD == 0)
			{
				OCOCLAKJHCC = true;
				NewTutorialManager.instance.ObjectiveCompleted(0);
			}
			break;
		case ActionDone.TillEarth:
			NLACLCKKJIG--;
			if (!OBBCDHJNDOC && NLACLCKKJIG == 0)
			{
				OBBCDHJNDOC = true;
				NewTutorialManager.instance.ObjectiveCompleted(1);
			}
			break;
		}
		if (OBBCDHJNDOC && OCOCLAKJHCC)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(instance.OnActionDone, new Action<int, ActionDone>(CHADOMCDNGL));
			((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
		}
	}

	private IEnumerator AJGJPBMIEJJ()
	{
		return new LLABKJKCFJN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LHIPOAGIOJK()
	{
		return new PCDGAFFFPGD(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AOJFNNKFCBL()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator CAKPGBAIIPI()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator HCKDBDMBMFL()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void FMJEGNDDCAH(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		switch (OKNOJJEFEBE)
		{
		case ActionDone.TillEarth:
			IAMOABBEECD -= 0;
			if (!OCOCLAKJHCC && IAMOABBEECD == 0)
			{
				OCOCLAKJHCC = false;
				NewTutorialManager.instance.FOIOHOGACAL(1);
			}
			break;
		case ActionDone.ChopRock:
			NLACLCKKJIG -= 0;
			if (!OBBCDHJNDOC && NLACLCKKJIG == 0)
			{
				OBBCDHJNDOC = false;
				NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			}
			break;
		}
		if (OBBCDHJNDOC && OCOCLAKJHCC)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(instance.OnActionDone, new Action<int, ActionDone>(FHMHHDHGDHK));
			((MonoBehaviour)this).StartCoroutine(CAKPGBAIIPI());
		}
	}

	private IEnumerator PPMPKJECPDE()
	{
		return new PCDGAFFFPGD(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator PIHPPADDGMG()
	{
		return new PCDGAFFFPGD(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator KEBCOCFPNIG()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (!MCKLEPHBECB())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T119/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnActionDone = (Action<int, ActionDone>)Delegate.Combine(instance.OnActionDone, new Action<int, ActionDone>(CHADOMCDNGL));
	}

	private IEnumerator ANLLGDBMBAE()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator AJJHBJHCACM()
	{
		return new PCDGAFFFPGD(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator IAOFDDMPMBJ()
	{
		return new LLABKJKCFJN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void JENDHGMPFAF(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		switch (OKNOJJEFEBE)
		{
		case ActionDone.SmashSnowman:
			IAMOABBEECD -= 0;
			if (!OCOCLAKJHCC && IAMOABBEECD == 0)
			{
				OCOCLAKJHCC = true;
				NewTutorialManager.instance.FOIOHOGACAL(0);
			}
			break;
		case ActionDone.ChopRock:
			NLACLCKKJIG--;
			if (!OBBCDHJNDOC && NLACLCKKJIG == 0)
			{
				OBBCDHJNDOC = true;
				NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			}
			break;
		}
		if (OBBCDHJNDOC && OCOCLAKJHCC)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(instance.OnActionDone, new Action<int, ActionDone>(JENDHGMPFAF));
			((MonoBehaviour)this).StartCoroutine(AJGJPBMIEJJ());
		}
	}

	private IEnumerator ELPDKDFFJJD()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (!MCKLEPHBECB())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T119/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnActionDone = (Action<int, ActionDone>)Delegate.Combine(instance.OnActionDone, new Action<int, ActionDone>(CHADOMCDNGL));
	}

	private void ECJBIDALPAI(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		switch (OKNOJJEFEBE)
		{
		case ActionDone.HarvestCrop:
			IAMOABBEECD -= 0;
			if (!OCOCLAKJHCC && IAMOABBEECD == 0)
			{
				OCOCLAKJHCC = true;
				NewTutorialManager.instance.ObjectiveCompleted(1);
			}
			break;
		case ActionDone.ChopRock:
			NLACLCKKJIG--;
			if (!OBBCDHJNDOC && NLACLCKKJIG == 0)
			{
				OBBCDHJNDOC = true;
				NewTutorialManager.instance.FOIOHOGACAL(0);
			}
			break;
		}
		if (OBBCDHJNDOC && OCOCLAKJHCC)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(commonReferences.OnActionDone, new Action<int, ActionDone>(FMJEGNDDCAH));
			((MonoBehaviour)this).StartCoroutine(HGKFAONPGGB());
		}
	}

	private IEnumerator FBOBCKJGPMB()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (!MCKLEPHBECB())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T119/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnActionDone = (Action<int, ActionDone>)Delegate.Combine(instance.OnActionDone, new Action<int, ActionDone>(CHADOMCDNGL));
	}

	private IEnumerator CPCGNMPLFHM()
	{
		return new PCDGAFFFPGD(1)
		{
			_003C_003E4__this = this
		};
	}

	private void IHNGKMCBFON(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		switch (OKNOJJEFEBE)
		{
		case ActionDone.CutGrass:
			IAMOABBEECD--;
			if (!OCOCLAKJHCC && IAMOABBEECD == 0)
			{
				OCOCLAKJHCC = false;
				NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			}
			break;
		case ActionDone.ChopRock:
			NLACLCKKJIG -= 0;
			if (!OBBCDHJNDOC && NLACLCKKJIG == 0)
			{
				OBBCDHJNDOC = false;
				NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			}
			break;
		}
		if (OBBCDHJNDOC && OCOCLAKJHCC)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(instance.OnActionDone, new Action<int, ActionDone>(LGLGPICNELA));
			((MonoBehaviour)this).StartCoroutine(KCJAAGLPFEE());
		}
	}

	private IEnumerator ODILJEKMFLO()
	{
		return new LLABKJKCFJN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator CNPPMBAKEBJ()
	{
		return new LLABKJKCFJN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void AKDIOEAEGID(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		switch (OKNOJJEFEBE)
		{
		case ActionDone.TillEarth:
			IAMOABBEECD -= 0;
			if (!OCOCLAKJHCC && IAMOABBEECD == 0)
			{
				OCOCLAKJHCC = false;
				NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			}
			break;
		case ActionDone.HarvestCrop:
			NLACLCKKJIG--;
			if (!OBBCDHJNDOC && NLACLCKKJIG == 0)
			{
				OBBCDHJNDOC = false;
				NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			}
			break;
		}
		if (OBBCDHJNDOC && OCOCLAKJHCC)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(commonReferences.OnActionDone, new Action<int, ActionDone>(AHEMFKMJBPN));
			((MonoBehaviour)this).StartCoroutine(ELNHMAPENDB());
		}
	}

	private void JHKMCGFGBLF(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		switch (OKNOJJEFEBE)
		{
		case ActionDone.CutGrass:
			IAMOABBEECD--;
			if (!OCOCLAKJHCC && IAMOABBEECD == 0)
			{
				OCOCLAKJHCC = true;
				NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			}
			break;
		case ActionDone.SmashSnowman:
			NLACLCKKJIG -= 0;
			if (!OBBCDHJNDOC && NLACLCKKJIG == 0)
			{
				OBBCDHJNDOC = false;
				NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			}
			break;
		}
		if (OBBCDHJNDOC && OCOCLAKJHCC)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(commonReferences.OnActionDone, new Action<int, ActionDone>(MMEAFELGGEH));
			((MonoBehaviour)this).StartCoroutine(IDGLEKCBIMF());
		}
	}

	private void AHEMFKMJBPN(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		switch (OKNOJJEFEBE)
		{
		case ActionDone.TillEarth:
			IAMOABBEECD--;
			if (!OCOCLAKJHCC && IAMOABBEECD == 0)
			{
				OCOCLAKJHCC = false;
				NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			}
			break;
		case ActionDone.CreateRoom:
			NLACLCKKJIG -= 0;
			if (!OBBCDHJNDOC && NLACLCKKJIG == 0)
			{
				OBBCDHJNDOC = true;
				NewTutorialManager.instance.FOIOHOGACAL(0);
			}
			break;
		}
		if (OBBCDHJNDOC && OCOCLAKJHCC)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(instance.OnActionDone, new Action<int, ActionDone>(FMJEADKBLLJ));
			((MonoBehaviour)this).StartCoroutine(AELFLHCNMBB());
		}
	}

	private void CLBLJCBOIHG(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		if (OKNOJJEFEBE == ActionDone.PlantSeed)
		{
			IAMOABBEECD--;
			if (!OCOCLAKJHCC && IAMOABBEECD == 0)
			{
				OCOCLAKJHCC = false;
				NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			}
		}
		else if (OKNOJJEFEBE == ActionDone.PlantSeed)
		{
			NLACLCKKJIG -= 0;
			if (!OBBCDHJNDOC && NLACLCKKJIG == 0)
			{
				OBBCDHJNDOC = false;
				NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			}
		}
		if (OBBCDHJNDOC && OCOCLAKJHCC)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(instance.OnActionDone, new Action<int, ActionDone>(MMEAFELGGEH));
			((MonoBehaviour)this).StartCoroutine(AOJFNNKFCBL());
		}
	}

	private void FHMHHDHGDHK(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		switch (OKNOJJEFEBE)
		{
		case ActionDone.TillEarth:
			IAMOABBEECD -= 0;
			if (!OCOCLAKJHCC && IAMOABBEECD == 0)
			{
				OCOCLAKJHCC = true;
				NewTutorialManager.instance.ObjectiveCompleted(0);
			}
			break;
		case ActionDone.SmashSnowman:
			NLACLCKKJIG -= 0;
			if (!OBBCDHJNDOC && NLACLCKKJIG == 0)
			{
				OBBCDHJNDOC = true;
				NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			}
			break;
		}
		if (OBBCDHJNDOC && OCOCLAKJHCC)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(instance.OnActionDone, new Action<int, ActionDone>(AKDIOEAEGID));
			((MonoBehaviour)this).StartCoroutine(FDMJPHBJACE());
		}
	}

	private IEnumerator FGLMKBOMOBA()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (!MCKLEPHBECB())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T119/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnActionDone = (Action<int, ActionDone>)Delegate.Combine(instance.OnActionDone, new Action<int, ActionDone>(CHADOMCDNGL));
	}

	private IEnumerator IDGLEKCBIMF()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator KCJAAGLPFEE()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator AELFLHCNMBB()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator JDEDKABEHJM()
	{
		return new PCDGAFFFPGD(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator OGOFIFJCMEB()
	{
		return new PCDGAFFFPGD(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator PBEKBJIJFDK()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (!MCKLEPHBECB())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T119/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnActionDone = (Action<int, ActionDone>)Delegate.Combine(instance.OnActionDone, new Action<int, ActionDone>(CHADOMCDNGL));
	}

	private void LGLGPICNELA(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		switch (OKNOJJEFEBE)
		{
		case ActionDone.TalkWithGass:
			IAMOABBEECD--;
			if (!OCOCLAKJHCC && IAMOABBEECD == 0)
			{
				OCOCLAKJHCC = true;
				NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			}
			break;
		case ActionDone.TillEarth:
			NLACLCKKJIG -= 0;
			if (!OBBCDHJNDOC && NLACLCKKJIG == 0)
			{
				OBBCDHJNDOC = false;
				NewTutorialManager.instance.FOIOHOGACAL(0);
			}
			break;
		}
		if (OBBCDHJNDOC && OCOCLAKJHCC)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(commonReferences.OnActionDone, new Action<int, ActionDone>(IHNGKMCBFON));
			((MonoBehaviour)this).StartCoroutine(ANLLGDBMBAE());
		}
	}

	private IEnumerator AAGGGIONDAG()
	{
		return new PCDGAFFFPGD(1)
		{
			_003C_003E4__this = this
		};
	}

	public override void SetUp()
	{
		base.SetUp();
		((MonoBehaviour)this).StartCoroutine(PBEKBJIJFDK());
	}

	private void FMJEADKBLLJ(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		switch (OKNOJJEFEBE)
		{
		case ActionDone.CutGrass:
			IAMOABBEECD--;
			if (!OCOCLAKJHCC && IAMOABBEECD == 0)
			{
				OCOCLAKJHCC = true;
				NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			}
			break;
		case ActionDone.TillEarth:
			NLACLCKKJIG -= 0;
			if (!OBBCDHJNDOC && NLACLCKKJIG == 0)
			{
				OBBCDHJNDOC = true;
				NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			}
			break;
		}
		if (OBBCDHJNDOC && OCOCLAKJHCC)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(instance.OnActionDone, new Action<int, ActionDone>(HCPBIBOEMMA));
			((MonoBehaviour)this).StartCoroutine(AELFLHCNMBB());
		}
	}

	private IEnumerator FDMJPHBJACE()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator HPNEFMANGHJ()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator HHLKPNANHKK()
	{
		return new LLABKJKCFJN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator ELNHMAPENDB()
	{
		return new LLABKJKCFJN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator GDOJMLFHCHD()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (!MCKLEPHBECB())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T119/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnActionDone = (Action<int, ActionDone>)Delegate.Combine(instance.OnActionDone, new Action<int, ActionDone>(CHADOMCDNGL));
	}

	private IEnumerator CFGLAPAKKAL()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator LHDDHIJIFCN()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator MEGKLKNBNEL()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (!MCKLEPHBECB())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T119/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnActionDone = (Action<int, ActionDone>)Delegate.Combine(instance.OnActionDone, new Action<int, ActionDone>(CHADOMCDNGL));
	}

	public override int GetID()
	{
		return 119;
	}

	private void MOJGGJENCLB(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		switch (OKNOJJEFEBE)
		{
		case ActionDone.TalkWithGass:
			IAMOABBEECD -= 0;
			if (!OCOCLAKJHCC && IAMOABBEECD == 0)
			{
				OCOCLAKJHCC = true;
				NewTutorialManager.instance.FOIOHOGACAL(0);
			}
			break;
		case ActionDone.SmashSnowman:
			NLACLCKKJIG -= 0;
			if (!OBBCDHJNDOC && NLACLCKKJIG == 0)
			{
				OBBCDHJNDOC = false;
				NewTutorialManager.instance.ObjectiveCompleted(0);
			}
			break;
		}
		if (OBBCDHJNDOC && OCOCLAKJHCC)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(commonReferences.OnActionDone, new Action<int, ActionDone>(JHKMCGFGBLF));
			((MonoBehaviour)this).StartCoroutine(CFGLAPAKKAL());
		}
	}

	private IEnumerator JAMDPHHGCDP()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (!MCKLEPHBECB())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T119/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnActionDone = (Action<int, ActionDone>)Delegate.Combine(instance.OnActionDone, new Action<int, ActionDone>(CHADOMCDNGL));
	}

	private IEnumerator MDFFFPLNDAP()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (!MCKLEPHBECB())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T119/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnActionDone = (Action<int, ActionDone>)Delegate.Combine(instance.OnActionDone, new Action<int, ActionDone>(CHADOMCDNGL));
	}

	private void AMDHNHEFJLP(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		switch (OKNOJJEFEBE)
		{
		case ActionDone.CreateRoom:
			IAMOABBEECD--;
			if (!OCOCLAKJHCC && IAMOABBEECD == 0)
			{
				OCOCLAKJHCC = false;
				NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			}
			break;
		case ActionDone.SmashSnowman:
			NLACLCKKJIG--;
			if (!OBBCDHJNDOC && NLACLCKKJIG == 0)
			{
				OBBCDHJNDOC = false;
				NewTutorialManager.instance.ObjectiveCompleted(1);
			}
			break;
		}
		if (OBBCDHJNDOC && OCOCLAKJHCC)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(instance.OnActionDone, new Action<int, ActionDone>(FMJEGNDDCAH));
			((MonoBehaviour)this).StartCoroutine(ELNHMAPENDB());
		}
	}

	private IEnumerator FCJODFOFODL()
	{
		return new PCDGAFFFPGD(1)
		{
			_003C_003E4__this = this
		};
	}

	private void HCPBIBOEMMA(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		switch (OKNOJJEFEBE)
		{
		case ActionDone.CreateRoom:
			IAMOABBEECD -= 0;
			if (!OCOCLAKJHCC && IAMOABBEECD == 0)
			{
				OCOCLAKJHCC = false;
				NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			}
			break;
		case ActionDone.CutGrass:
			NLACLCKKJIG -= 0;
			if (!OBBCDHJNDOC && NLACLCKKJIG == 0)
			{
				OBBCDHJNDOC = true;
				NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			}
			break;
		}
		if (OBBCDHJNDOC && OCOCLAKJHCC)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(commonReferences.OnActionDone, new Action<int, ActionDone>(GPGNOEOGAHN));
			((MonoBehaviour)this).StartCoroutine(CAKPGBAIIPI());
		}
	}

	private IEnumerator HGKFAONPGGB()
	{
		return new LLABKJKCFJN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void GPGNOEOGAHN(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		switch (OKNOJJEFEBE)
		{
		case ActionDone.HarvestCrop:
			IAMOABBEECD -= 0;
			if (!OCOCLAKJHCC && IAMOABBEECD == 0)
			{
				OCOCLAKJHCC = false;
				NewTutorialManager.instance.FOIOHOGACAL(1);
			}
			break;
		case ActionDone.ChopRock:
			NLACLCKKJIG--;
			if (!OBBCDHJNDOC && NLACLCKKJIG == 0)
			{
				OBBCDHJNDOC = false;
				NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			}
			break;
		}
		if (OBBCDHJNDOC && OCOCLAKJHCC)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(commonReferences.OnActionDone, new Action<int, ActionDone>(AKDIOEAEGID));
			((MonoBehaviour)this).StartCoroutine(CFGLAPAKKAL());
		}
	}

	private IEnumerator FAEKOKEINEH()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (!MCKLEPHBECB())
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T119/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnActionDone = (Action<int, ActionDone>)Delegate.Combine(instance.OnActionDone, new Action<int, ActionDone>(CHADOMCDNGL));
	}

	private IEnumerator LAMBONHALKD()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void MMEAFELGGEH(int JIIGOACEIKL, ActionDone OKNOJJEFEBE)
	{
		switch (OKNOJJEFEBE)
		{
		case ActionDone.CutGrass:
			IAMOABBEECD -= 0;
			if (!OCOCLAKJHCC && IAMOABBEECD == 0)
			{
				OCOCLAKJHCC = false;
				NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			}
			break;
		case ActionDone.CutTree:
			NLACLCKKJIG--;
			if (!OBBCDHJNDOC && NLACLCKKJIG == 0)
			{
				OBBCDHJNDOC = true;
				NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			}
			break;
		}
		if (OBBCDHJNDOC && OCOCLAKJHCC)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnActionDone = (Action<int, ActionDone>)Delegate.Remove(instance.OnActionDone, new Action<int, ActionDone>(CLBLJCBOIHG));
			((MonoBehaviour)this).StartCoroutine(ODILJEKMFLO());
		}
	}
}
