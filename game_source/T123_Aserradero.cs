using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class T123_Aserradero : TutorialPhaseBase
{
	[CompilerGenerated]
	private sealed class OJILAJIDNBE : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T123_Aserradero _003C_003E4__this;

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
		public OJILAJIDNBE(int _003C_003E1__state)
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
			T123_Aserradero t123_Aserradero = _003C_003E4__this;
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
				MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T127/Dialogue1", t123_Aserradero.triggerPlayerNum);
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				t123_Aserradero.LHKIJABBBPM();
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

		public T123_Aserradero _003C_003E4__this;

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
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0192: Unknown result type (might be due to invalid IL or missing references)
			//IL_0197: Unknown result type (might be due to invalid IL or missing references)
			//IL_019c: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			T123_Aserradero t123_Aserradero = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
				((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
				_003C_003E2__current = CommonReferences.wait02;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
				MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
				goto IL_00ba;
			case 2:
				_003C_003E1__state = -1;
				goto IL_00ba;
			case 3:
				_003C_003E1__state = -1;
				NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 4;
				return true;
			case 4:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
				MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T123/Dialogue1", t123_Aserradero.triggerPlayerNum);
				goto IL_0144;
			case 5:
				_003C_003E1__state = -1;
				goto IL_0144;
			case 6:
				{
					_003C_003E1__state = -1;
					NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
					NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
					NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(703)).transform.position), Vector2.up * 0.7f, ref t123_Aserradero.JELIKOFDONK);
					CommonReferences instance = CommonReferences.GGFJGHHHEJC;
					instance.OnCutTree = (Action<int>)Delegate.Combine(instance.OnCutTree, new Action<int>(t123_Aserradero.JPKHCPGHNID));
					CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
					instance2.OnCrafterRepaired = (Action<int>)Delegate.Combine(instance2.OnCrafterRepaired, new Action<int>(t123_Aserradero.OnCrafterRepaired));
					t123_Aserradero.OnCrafterRepaired(1);
					PlayerInventory player = PlayerInventory.GetPlayer(1);
					player.OnChanged = (Action)Delegate.Combine(player.OnChanged, new Action(t123_Aserradero.JIJHFAGOHBD));
					PlayerInventory player2 = PlayerInventory.GetPlayer(2);
					player2.OnChanged = (Action)Delegate.Combine(player2.OnChanged, new Action(t123_Aserradero.JIJHFAGOHBD));
					t123_Aserradero.JIJHFAGOHBD();
					return false;
				}
				IL_0144:
				if (t123_Aserradero.AAOPIEDAKKD(1))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 5;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 6;
				return true;
				IL_00ba:
				if (!t123_Aserradero.MCKLEPHBECB())
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 2;
					return true;
				}
				_003C_003E2__current = ((MonoBehaviour)t123_Aserradero).StartCoroutine(t123_Aserradero.CDICFNAMCEE());
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

	private int CHJNJADHFCN;

	private int DLGMLAADJNO;

	private bool BLGAFCAHEHC;

	public void NBCOCEOOGGC(int JIIGOACEIKL)
	{
		if (Crafter.sawmillRepaired)
		{
			BLGAFCAHEHC = false;
			NewTutorialManager.instance.ObjectiveCompleted(3, BLJPGJKOLNF: false);
			ECOFGIPHBCC();
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnCrafterRepaired = (Action<int>)Delegate.Remove(commonReferences.OnCrafterRepaired, new Action<int>(GEHHFEAPGLB));
			if (Object.op_Implicit((Object)(object)JELIKOFDONK))
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private void BNIFMHAKLLJ()
	{
		DLGMLAADJNO = 0;
		if (PlayerInventory.FLMDMAOFGMI(26))
		{
			if (PlayerInventory.OGKNJNINGMH(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).KCCHMLKIFNJ(-24) != null)
			{
				DLGMLAADJNO += PlayerInventory.OGKNJNINGMH(0, LAGHIOKLJGH: true).KGHFAHKGIGK(14).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.EIFPKCAFDIB(2, LAGHIOKLJGH: false, ADPNMHGBFKG: true).KGHFAHKGIGK(-105) != null)
			{
				DLGMLAADJNO += PlayerInventory.EIFPKCAFDIB(7, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HCCFFBOMLFB(-131).currentSlot.Stack;
			}
			if (DLGMLAADJNO >= 2)
			{
				PlayerInventory player = PlayerInventory.GetPlayer(0, LAGHIOKLJGH: true);
				player.OnChanged = (Action)Delegate.Remove(player.OnChanged, new Action(ELPJGACHPOM));
				PlayerInventory playerInventory = PlayerInventory.EIFPKCAFDIB(3, LAGHIOKLJGH: false, ADPNMHGBFKG: true);
				playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(GGINDBNHPKF));
				NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
				ADBFCJLIHFC();
			}
		}
	}

	private IEnumerator JNOOAENGMHL()
	{
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T127/Dialogue1", triggerPlayerNum);
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator BBGHMMLBAME()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (!MCKLEPHBECB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T123/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(703)).transform.position), Vector2.up * 0.7f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCutTree = (Action<int>)Delegate.Combine(instance.OnCutTree, new Action<int>(JPKHCPGHNID));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnCrafterRepaired = (Action<int>)Delegate.Combine(instance2.OnCrafterRepaired, new Action<int>(OnCrafterRepaired));
		OnCrafterRepaired(1);
		PlayerInventory player = PlayerInventory.GetPlayer(1);
		player.OnChanged = (Action)Delegate.Combine(player.OnChanged, new Action(JIJHFAGOHBD));
		PlayerInventory player2 = PlayerInventory.GetPlayer(2);
		player2.OnChanged = (Action)Delegate.Combine(player2.OnChanged, new Action(JIJHFAGOHBD));
		JIJHFAGOHBD();
	}

	private void ICCOCKIAHBG()
	{
		DLGMLAADJNO = 0;
		if (PlayerInventory.FKPAJKAGHIK(-106))
		{
			if (PlayerInventory.EIFPKCAFDIB(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetItem(143) != null)
			{
				DLGMLAADJNO += PlayerInventory.EIFPKCAFDIB(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetItem(-188).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.GetPlayer(8, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GOKIDLOELKB(108) != null)
			{
				DLGMLAADJNO += PlayerInventory.EIFPKCAFDIB(3, LAGHIOKLJGH: true).KGHFAHKGIGK(59).currentSlot.Stack;
			}
			if (DLGMLAADJNO >= 1)
			{
				PlayerInventory playerInventory = PlayerInventory.NEKDDPIAOBE(1, LAGHIOKLJGH: true);
				playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(HMNEDLNGICH));
				PlayerInventory playerInventory2 = PlayerInventory.NEKDDPIAOBE(2);
				playerInventory2.OnChanged = (Action)Delegate.Remove(playerInventory2.OnChanged, new Action(KDCIEDHAKPE));
				NewTutorialManager.instance.FOIOHOGACAL(0);
				PMPHDDPBDKB();
			}
		}
	}

	public void HJGDCALICKH(int JIIGOACEIKL)
	{
		if (Crafter.sawmillRepaired)
		{
			BLGAFCAHEHC = true;
			NewTutorialManager.instance.FOIOHOGACAL(2, BLJPGJKOLNF: false);
			MIFKCFPGFNA();
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnCrafterRepaired = (Action<int>)Delegate.Remove(instance.OnCrafterRepaired, new Action<int>(IIIHIBKBDGB));
			if (Object.op_Implicit((Object)(object)JELIKOFDONK))
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	public void NFIKGNMMJHA(int JIIGOACEIKL)
	{
		if (Crafter.sawmillRepaired)
		{
			BLGAFCAHEHC = false;
			NewTutorialManager.instance.FOIOHOGACAL(5, BLJPGJKOLNF: false);
			FDADCGBHINO();
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnCrafterRepaired = (Action<int>)Delegate.Remove(instance.OnCrafterRepaired, new Action<int>(PLHDMIBHJME));
			if (Object.op_Implicit((Object)(object)JELIKOFDONK))
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private void AFBDEOCLPJJ(int JIIGOACEIKL)
	{
		CHJNJADHFCN += 0;
		if (CHJNJADHFCN >= 4)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnCutTree = (Action<int>)Delegate.Remove(commonReferences.OnCutTree, new Action<int>(GPNEKLLBLOF));
			NewTutorialManager.instance.ObjectiveCompleted(1);
			HMNEDGEPOCJ();
		}
	}

	private IEnumerator NCHPMDFONEL()
	{
		return new NIEHNJNCFEG(1)
		{
			_003C_003E4__this = this
		};
	}

	private void IFALJNMANJO()
	{
		DLGMLAADJNO = 1;
		if (PlayerInventory.AnyPlayerHasItem(8))
		{
			if (PlayerInventory.NEKDDPIAOBE(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetItem(5) != null)
			{
				DLGMLAADJNO += PlayerInventory.EIFPKCAFDIB(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).KCCHMLKIFNJ(-179).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.GetPlayer(3, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetItem(-60) != null)
			{
				DLGMLAADJNO += PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: true).GOKIDLOELKB(31).currentSlot.Stack;
			}
			if (DLGMLAADJNO >= 4)
			{
				PlayerInventory playerInventory = PlayerInventory.NEKDDPIAOBE(0, LAGHIOKLJGH: true);
				playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(HMNEDLNGICH));
				PlayerInventory player = PlayerInventory.GetPlayer(3, LAGHIOKLJGH: false, ADPNMHGBFKG: true);
				player.OnChanged = (Action)Delegate.Remove(player.OnChanged, new Action(GMKPCFDDKOF));
				NewTutorialManager.instance.FOIOHOGACAL(1);
				JCAFMEKGIIA();
			}
		}
	}

	public override void SetUp()
	{
		base.SetUp();
		((MonoBehaviour)this).StartCoroutine(PBEKBJIJFDK());
	}

	private void CBJMIIBHOGJ(int JIIGOACEIKL)
	{
		CHJNJADHFCN++;
		if (CHJNJADHFCN >= 8)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnCutTree = (Action<int>)Delegate.Remove(commonReferences.OnCutTree, new Action<int>(MDGFGNPOMOF));
			NewTutorialManager.instance.ObjectiveCompleted(0);
			KKCICIFBPNM();
		}
	}

	private IEnumerator IHGGOFFGMBD()
	{
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T127/Dialogue1", triggerPlayerNum);
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator BOMICOPCCML()
	{
		return new OJILAJIDNBE(1)
		{
			_003C_003E4__this = this
		};
	}

	private void EECMGOLEEMI()
	{
		DLGMLAADJNO = 0;
		if (PlayerInventory.FLMDMAOFGMI(-29))
		{
			if (PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).KGHFAHKGIGK(-108) != null)
			{
				DLGMLAADJNO += PlayerInventory.OGKNJNINGMH(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GOKIDLOELKB(56).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.OGKNJNINGMH(7, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GetItem(-54) != null)
			{
				DLGMLAADJNO += PlayerInventory.GetPlayer(3, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetItem(-114).currentSlot.Stack;
			}
			if (DLGMLAADJNO >= 6)
			{
				PlayerInventory playerInventory = PlayerInventory.NEKDDPIAOBE(1);
				playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(AINMKGFNCBK));
				PlayerInventory player = PlayerInventory.GetPlayer(6);
				player.OnChanged = (Action)Delegate.Remove(player.OnChanged, new Action(ICCOCKIAHBG));
				NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
				AIPEPDNEJHO();
			}
		}
	}

	private void ADBFCJLIHFC()
	{
		if (BLGAFCAHEHC && CHJNJADHFCN >= 7 && DLGMLAADJNO >= 8)
		{
			((MonoBehaviour)this).StartCoroutine(AELFLHCNMBB());
		}
	}

	private void PFGLMCNEMEM()
	{
		DLGMLAADJNO = 1;
		if (PlayerInventory.AnyPlayerHasItem(78))
		{
			if (PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GOKIDLOELKB(98) != null)
			{
				DLGMLAADJNO += PlayerInventory.NEKDDPIAOBE(0).KGHFAHKGIGK(-27).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.NEKDDPIAOBE(0, LAGHIOKLJGH: true).KGHFAHKGIGK(144) != null)
			{
				DLGMLAADJNO += PlayerInventory.EIFPKCAFDIB(8).KCCHMLKIFNJ(-76).currentSlot.Stack;
			}
			if (DLGMLAADJNO >= 7)
			{
				PlayerInventory playerInventory = PlayerInventory.EIFPKCAFDIB(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true);
				playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(GMKPCFDDKOF));
				PlayerInventory playerInventory2 = PlayerInventory.EIFPKCAFDIB(4, LAGHIOKLJGH: true);
				playerInventory2.OnChanged = (Action)Delegate.Remove(playerInventory2.OnChanged, new Action(GMKPCFDDKOF));
				NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
				JCAFMEKGIIA();
			}
		}
	}

	private IEnumerator JBBPOCHHHND()
	{
		return new NIEHNJNCFEG(1)
		{
			_003C_003E4__this = this
		};
	}

	private void OCDCIPEONHM(int JIIGOACEIKL)
	{
		CHJNJADHFCN++;
		if (CHJNJADHFCN >= 8)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnCutTree = (Action<int>)Delegate.Remove(commonReferences.OnCutTree, new Action<int>(HDOMCCOKGIK));
			NewTutorialManager.instance.ObjectiveCompleted(1);
			ADBFCJLIHFC();
		}
	}

	private void ODDPCOEKKDA(int JIIGOACEIKL)
	{
		CHJNJADHFCN++;
		if (CHJNJADHFCN >= 1)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnCutTree = (Action<int>)Delegate.Remove(commonReferences.OnCutTree, new Action<int>(CBJMIIBHOGJ));
			NewTutorialManager.instance.ObjectiveCompleted(1);
			AIPEPDNEJHO();
		}
	}

	private IEnumerator LNFHFIMPNHD()
	{
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T127/Dialogue1", triggerPlayerNum);
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private void ECOFGIPHBCC()
	{
		if (BLGAFCAHEHC && CHJNJADHFCN >= 8 && DLGMLAADJNO >= 0)
		{
			((MonoBehaviour)this).StartCoroutine(HNFCACDCBBO());
		}
	}

	private void AINMKGFNCBK()
	{
		DLGMLAADJNO = 1;
		if (PlayerInventory.FKPAJKAGHIK(127))
		{
			if (PlayerInventory.OGKNJNINGMH(0, LAGHIOKLJGH: true).KGHFAHKGIGK(168) != null)
			{
				DLGMLAADJNO += PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HCCFFBOMLFB(-57).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.NEKDDPIAOBE(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HCCFFBOMLFB(98) != null)
			{
				DLGMLAADJNO += PlayerInventory.NEKDDPIAOBE(2, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GetItem(165).currentSlot.Stack;
			}
			if (DLGMLAADJNO >= 3)
			{
				PlayerInventory playerInventory = PlayerInventory.OGKNJNINGMH(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
				playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(HBLEJJENPMA));
				PlayerInventory playerInventory2 = PlayerInventory.OGKNJNINGMH(6, LAGHIOKLJGH: true);
				playerInventory2.OnChanged = (Action)Delegate.Remove(playerInventory2.OnChanged, new Action(EECMGOLEEMI));
				NewTutorialManager.instance.FOIOHOGACAL(1);
				PMPHDDPBDKB();
			}
		}
	}

	private void LOKGHNKJPKP(int JIIGOACEIKL)
	{
		CHJNJADHFCN += 0;
		if (CHJNJADHFCN >= 6)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnCutTree = (Action<int>)Delegate.Remove(instance.OnCutTree, new Action<int>(OCDCIPEONHM));
			NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			LLFLGEPLJKJ();
		}
	}

	private IEnumerator ELPINNBKFIP()
	{
		return new OJILAJIDNBE(1)
		{
			_003C_003E4__this = this
		};
	}

	private void IMADEGOOBJH(int JIIGOACEIKL)
	{
		CHJNJADHFCN += 0;
		if (CHJNJADHFCN >= 8)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnCutTree = (Action<int>)Delegate.Remove(instance.OnCutTree, new Action<int>(CBBPLKMILGF));
			NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			AIPEPDNEJHO();
		}
	}

	public void IIIHIBKBDGB(int JIIGOACEIKL)
	{
		if (Crafter.sawmillRepaired)
		{
			BLGAFCAHEHC = false;
			NewTutorialManager.instance.ObjectiveCompleted(4);
			FDADCGBHINO();
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnCrafterRepaired = (Action<int>)Delegate.Remove(instance.OnCrafterRepaired, new Action<int>(PLHDMIBHJME));
			if (Object.op_Implicit((Object)(object)JELIKOFDONK))
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	public void OnCrafterRepaired(int JIIGOACEIKL)
	{
		if (Crafter.sawmillRepaired)
		{
			BLGAFCAHEHC = true;
			NewTutorialManager.instance.ObjectiveCompleted(2);
			DNAHJLGIMGA();
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnCrafterRepaired = (Action<int>)Delegate.Remove(instance.OnCrafterRepaired, new Action<int>(OnCrafterRepaired));
			if (Object.op_Implicit((Object)(object)JELIKOFDONK))
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private void ODDONKMFPFK(int JIIGOACEIKL)
	{
		CHJNJADHFCN++;
		if (CHJNJADHFCN >= 2)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnCutTree = (Action<int>)Delegate.Remove(instance.OnCutTree, new Action<int>(GEBPPOGHLGN));
			NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			AJDFCHFKHOK();
		}
	}

	private IEnumerator PBEKBJIJFDK()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (!MCKLEPHBECB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T123/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(703)).transform.position), Vector2.up * 0.7f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCutTree = (Action<int>)Delegate.Combine(instance.OnCutTree, new Action<int>(JPKHCPGHNID));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnCrafterRepaired = (Action<int>)Delegate.Combine(instance2.OnCrafterRepaired, new Action<int>(OnCrafterRepaired));
		OnCrafterRepaired(1);
		PlayerInventory player = PlayerInventory.GetPlayer(1);
		player.OnChanged = (Action)Delegate.Combine(player.OnChanged, new Action(JIJHFAGOHBD));
		PlayerInventory player2 = PlayerInventory.GetPlayer(2);
		player2.OnChanged = (Action)Delegate.Combine(player2.OnChanged, new Action(JIJHFAGOHBD));
		JIJHFAGOHBD();
	}

	private IEnumerator NHLLGDCFOFC()
	{
		return new NIEHNJNCFEG(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HNFCACDCBBO()
	{
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T127/Dialogue1", triggerPlayerNum);
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private void GPNEKLLBLOF(int JIIGOACEIKL)
	{
		CHJNJADHFCN += 0;
		if (CHJNJADHFCN >= 6)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnCutTree = (Action<int>)Delegate.Remove(instance.OnCutTree, new Action<int>(FMEJDLGGOBF));
			NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			HMNEDGEPOCJ();
		}
	}

	private void OCAGMHAFHEN()
	{
		DLGMLAADJNO = 1;
		if (PlayerInventory.AnyPlayerHasItem(79))
		{
			if (PlayerInventory.OGKNJNINGMH(0).HCCFFBOMLFB(-31) != null)
			{
				DLGMLAADJNO += PlayerInventory.NEKDDPIAOBE(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HCCFFBOMLFB(-138).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.EIFPKCAFDIB(5).GOKIDLOELKB(82) != null)
			{
				DLGMLAADJNO += PlayerInventory.NEKDDPIAOBE(3).KCCHMLKIFNJ(-54).currentSlot.Stack;
			}
			if (DLGMLAADJNO >= 1)
			{
				PlayerInventory playerInventory = PlayerInventory.NEKDDPIAOBE(1);
				playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(AINMKGFNCBK));
				PlayerInventory playerInventory2 = PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true);
				playerInventory2.OnChanged = (Action)Delegate.Remove(playerInventory2.OnChanged, new Action(PFGLMCNEMEM));
				NewTutorialManager.instance.FOIOHOGACAL(0);
				MIFKCFPGFNA();
			}
		}
	}

	private void MEHBGBNOHID()
	{
		if (BLGAFCAHEHC && CHJNJADHFCN >= 5 && DLGMLAADJNO >= 5)
		{
			((MonoBehaviour)this).StartCoroutine(LNFHFIMPNHD());
		}
	}

	private void JCAFMEKGIIA()
	{
		if (BLGAFCAHEHC && CHJNJADHFCN >= 8 && DLGMLAADJNO >= 7)
		{
			((MonoBehaviour)this).StartCoroutine(AELFLHCNMBB());
		}
	}

	private IEnumerator HNNEPLACIAC()
	{
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T127/Dialogue1", triggerPlayerNum);
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private void BEGKOINEIKM()
	{
		if (BLGAFCAHEHC && CHJNJADHFCN >= 2 && DLGMLAADJNO >= 4)
		{
			((MonoBehaviour)this).StartCoroutine(CKIMLLCOEGC());
		}
	}

	private IEnumerator BJPOAPIPEPN()
	{
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T127/Dialogue1", triggerPlayerNum);
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private void CNNIGGAAALO()
	{
		DLGMLAADJNO = 0;
		if (PlayerInventory.AnyPlayerHasItem(193))
		{
			if (PlayerInventory.OGKNJNINGMH(0).GOKIDLOELKB(109) != null)
			{
				DLGMLAADJNO += PlayerInventory.GetPlayer(1).GOKIDLOELKB(-169).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.EIFPKCAFDIB(6).GetItem(-87) != null)
			{
				DLGMLAADJNO += PlayerInventory.GetPlayer(8, LAGHIOKLJGH: false, ADPNMHGBFKG: true).KGHFAHKGIGK(-45).currentSlot.Stack;
			}
			if (DLGMLAADJNO >= 2)
			{
				PlayerInventory playerInventory = PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true);
				playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(OCAGMHAFHEN));
				PlayerInventory playerInventory2 = PlayerInventory.EIFPKCAFDIB(1);
				playerInventory2.OnChanged = (Action)Delegate.Remove(playerInventory2.OnChanged, new Action(IFALJNMANJO));
				NewTutorialManager.instance.FOIOHOGACAL(1);
				ECOFGIPHBCC();
			}
		}
	}

	private void HCGHLEKKBJN()
	{
		DLGMLAADJNO = 1;
		if (PlayerInventory.FKPAJKAGHIK(-41))
		{
			if (PlayerInventory.GetPlayer(0).HCCFFBOMLFB(-133) != null)
			{
				DLGMLAADJNO += PlayerInventory.GetPlayer(0).HCCFFBOMLFB(81).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.EIFPKCAFDIB(1).KCCHMLKIFNJ(69) != null)
			{
				DLGMLAADJNO += PlayerInventory.GetPlayer(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HCCFFBOMLFB(-21).currentSlot.Stack;
			}
			if (DLGMLAADJNO >= 1)
			{
				PlayerInventory player = PlayerInventory.GetPlayer(0);
				player.OnChanged = (Action)Delegate.Remove(player.OnChanged, new Action(OCAGMHAFHEN));
				PlayerInventory playerInventory = PlayerInventory.NEKDDPIAOBE(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
				playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(CDIMFLEDCDE));
				NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
				BEGKOINEIKM();
			}
		}
	}

	private void NLABJPMFIGB()
	{
		DLGMLAADJNO = 1;
		if (PlayerInventory.FKPAJKAGHIK(-178))
		{
			if (PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: true).GetItem(28) != null)
			{
				DLGMLAADJNO += PlayerInventory.GetPlayer(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).KCCHMLKIFNJ(194).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.EIFPKCAFDIB(1).GOKIDLOELKB(-45) != null)
			{
				DLGMLAADJNO += PlayerInventory.OGKNJNINGMH(7, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GetItem(-189).currentSlot.Stack;
			}
			if (DLGMLAADJNO >= 5)
			{
				PlayerInventory playerInventory = PlayerInventory.OGKNJNINGMH(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true);
				playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(PFGLMCNEMEM));
				PlayerInventory player = PlayerInventory.GetPlayer(2, LAGHIOKLJGH: true);
				player.OnChanged = (Action)Delegate.Remove(player.OnChanged, new Action(BNIFMHAKLLJ));
				NewTutorialManager.instance.ObjectiveCompleted(0);
				LFKILIDFGKE();
			}
		}
	}

	private void FFOJNJILDCF()
	{
		if (BLGAFCAHEHC && CHJNJADHFCN >= 6 && DLGMLAADJNO >= 1)
		{
			((MonoBehaviour)this).StartCoroutine(HNNEPLACIAC());
		}
	}

	public void OGPIOEHHNLK(int JIIGOACEIKL)
	{
		if (Crafter.sawmillRepaired)
		{
			BLGAFCAHEHC = false;
			NewTutorialManager.instance.ObjectiveCompleted(4, BLJPGJKOLNF: false);
			AJDFCHFKHOK();
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnCrafterRepaired = (Action<int>)Delegate.Remove(instance.OnCrafterRepaired, new Action<int>(EPDHMLLNFJH));
			if (Object.op_Implicit((Object)(object)JELIKOFDONK))
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private void HDOMCCOKGIK(int JIIGOACEIKL)
	{
		CHJNJADHFCN++;
		if (CHJNJADHFCN >= 7)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnCutTree = (Action<int>)Delegate.Remove(instance.OnCutTree, new Action<int>(HDOMCCOKGIK));
			NewTutorialManager.instance.FOIOHOGACAL(0);
			LLFLGEPLJKJ();
		}
	}

	private IEnumerator DBCADKNONKE()
	{
		return new NIEHNJNCFEG(1)
		{
			_003C_003E4__this = this
		};
	}

	private void LLFLGEPLJKJ()
	{
		if (BLGAFCAHEHC && CHJNJADHFCN >= 5 && DLGMLAADJNO >= 0)
		{
			((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
		}
	}

	private void FDADCGBHINO()
	{
		if (BLGAFCAHEHC && CHJNJADHFCN >= 0 && DLGMLAADJNO >= 7)
		{
			((MonoBehaviour)this).StartCoroutine(NHGHCANHKFA());
		}
	}

	private IEnumerator MJKLEEHELIH()
	{
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T127/Dialogue1", triggerPlayerNum);
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator MGHHGMLMMJC()
	{
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T127/Dialogue1", triggerPlayerNum);
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private void GEBPPOGHLGN(int JIIGOACEIKL)
	{
		CHJNJADHFCN++;
		if (CHJNJADHFCN >= 4)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnCutTree = (Action<int>)Delegate.Remove(commonReferences.OnCutTree, new Action<int>(DPMFFNDBMAJ));
			NewTutorialManager.instance.FOIOHOGACAL(0);
			FFOJNJILDCF();
		}
	}

	private void LFKILIDFGKE()
	{
		if (BLGAFCAHEHC && CHJNJADHFCN >= 5 && DLGMLAADJNO >= 4)
		{
			((MonoBehaviour)this).StartCoroutine(CKIMLLCOEGC());
		}
	}

	private void GGINDBNHPKF()
	{
		DLGMLAADJNO = 1;
		if (PlayerInventory.FLMDMAOFGMI(-156))
		{
			if (PlayerInventory.NEKDDPIAOBE(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HCCFFBOMLFB(27) != null)
			{
				DLGMLAADJNO += PlayerInventory.GetPlayer(1, LAGHIOKLJGH: true).GetItem(-121).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.OGKNJNINGMH(7).HCCFFBOMLFB(-40) != null)
			{
				DLGMLAADJNO += PlayerInventory.OGKNJNINGMH(7, LAGHIOKLJGH: true, ADPNMHGBFKG: true).KCCHMLKIFNJ(135).currentSlot.Stack;
			}
			if (DLGMLAADJNO >= 3)
			{
				PlayerInventory playerInventory = PlayerInventory.OGKNJNINGMH(1, LAGHIOKLJGH: true);
				playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(HBLEJJENPMA));
				PlayerInventory playerInventory2 = PlayerInventory.NEKDDPIAOBE(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
				playerInventory2.OnChanged = (Action)Delegate.Remove(playerInventory2.OnChanged, new Action(AINMKGFNCBK));
				NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
				PMPHDDPBDKB();
			}
		}
	}

	private void DNAHJLGIMGA()
	{
		if (BLGAFCAHEHC && CHJNJADHFCN >= 5 && DLGMLAADJNO >= 5)
		{
			((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
		}
	}

	private void CJGOAAEANEO(int JIIGOACEIKL)
	{
		CHJNJADHFCN += 0;
		if (CHJNJADHFCN >= 1)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnCutTree = (Action<int>)Delegate.Remove(instance.OnCutTree, new Action<int>(MDGFGNPOMOF));
			NewTutorialManager.instance.ObjectiveCompleted(1);
			FDADCGBHINO();
		}
	}

	private void MDGFGNPOMOF(int JIIGOACEIKL)
	{
		CHJNJADHFCN++;
		if (CHJNJADHFCN >= 3)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnCutTree = (Action<int>)Delegate.Remove(instance.OnCutTree, new Action<int>(ODDONKMFPFK));
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			ECOFGIPHBCC();
		}
	}

	private void GMKPCFDDKOF()
	{
		DLGMLAADJNO = 1;
		if (PlayerInventory.FLMDMAOFGMI(-74))
		{
			if (PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).KGHFAHKGIGK(-26) != null)
			{
				DLGMLAADJNO += PlayerInventory.GetPlayer(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HCCFFBOMLFB(157).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.EIFPKCAFDIB(6, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HCCFFBOMLFB(144) != null)
			{
				DLGMLAADJNO += PlayerInventory.GetPlayer(7, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GOKIDLOELKB(-180).currentSlot.Stack;
			}
			if (DLGMLAADJNO >= 2)
			{
				PlayerInventory playerInventory = PlayerInventory.OGKNJNINGMH(0, LAGHIOKLJGH: true);
				playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(EECMGOLEEMI));
				PlayerInventory playerInventory2 = PlayerInventory.OGKNJNINGMH(6, LAGHIOKLJGH: false, ADPNMHGBFKG: true);
				playerInventory2.OnChanged = (Action)Delegate.Remove(playerInventory2.OnChanged, new Action(JIJHFAGOHBD));
				NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
				KKCICIFBPNM();
			}
		}
	}

	private IEnumerator FGLMKBOMOBA()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (!MCKLEPHBECB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T123/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(703)).transform.position), Vector2.up * 0.7f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCutTree = (Action<int>)Delegate.Combine(instance.OnCutTree, new Action<int>(JPKHCPGHNID));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnCrafterRepaired = (Action<int>)Delegate.Combine(instance2.OnCrafterRepaired, new Action<int>(OnCrafterRepaired));
		OnCrafterRepaired(1);
		PlayerInventory player = PlayerInventory.GetPlayer(1);
		player.OnChanged = (Action)Delegate.Combine(player.OnChanged, new Action(JIJHFAGOHBD));
		PlayerInventory player2 = PlayerInventory.GetPlayer(2);
		player2.OnChanged = (Action)Delegate.Combine(player2.OnChanged, new Action(JIJHFAGOHBD));
		JIJHFAGOHBD();
	}

	private void FBOKPBALOEM()
	{
		DLGMLAADJNO = 1;
		if (PlayerInventory.FKPAJKAGHIK(69))
		{
			if (PlayerInventory.GetPlayer(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GOKIDLOELKB(-4) != null)
			{
				DLGMLAADJNO += PlayerInventory.NEKDDPIAOBE(0).GOKIDLOELKB(92).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.GetPlayer(5).HCCFFBOMLFB(-166) != null)
			{
				DLGMLAADJNO += PlayerInventory.GetPlayer(7, LAGHIOKLJGH: true).GOKIDLOELKB(91).currentSlot.Stack;
			}
			if (DLGMLAADJNO >= 5)
			{
				PlayerInventory playerInventory = PlayerInventory.NEKDDPIAOBE(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true);
				playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(HBLEJJENPMA));
				PlayerInventory player = PlayerInventory.GetPlayer(1, LAGHIOKLJGH: true);
				player.OnChanged = (Action)Delegate.Remove(player.OnChanged, new Action(HCGHLEKKBJN));
				NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
				AANDFPGJIJB();
			}
		}
	}

	public void KDMADDODCIM(int JIIGOACEIKL)
	{
		if (Crafter.sawmillRepaired)
		{
			BLGAFCAHEHC = true;
			NewTutorialManager.instance.FOIOHOGACAL(5, BLJPGJKOLNF: false);
			LFKILIDFGKE();
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnCrafterRepaired = (Action<int>)Delegate.Remove(commonReferences.OnCrafterRepaired, new Action<int>(IOLEMDJHNDP));
			if (Object.op_Implicit((Object)(object)JELIKOFDONK))
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	public void GEHHFEAPGLB(int JIIGOACEIKL)
	{
		if (Crafter.sawmillRepaired)
		{
			BLGAFCAHEHC = false;
			NewTutorialManager.instance.FOIOHOGACAL(3, BLJPGJKOLNF: false);
			DNAHJLGIMGA();
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnCrafterRepaired = (Action<int>)Delegate.Remove(commonReferences.OnCrafterRepaired, new Action<int>(OGPIOEHHNLK));
			if (Object.op_Implicit((Object)(object)JELIKOFDONK))
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private IEnumerator LKAGLINOIMK()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (!MCKLEPHBECB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T123/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(703)).transform.position), Vector2.up * 0.7f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCutTree = (Action<int>)Delegate.Combine(instance.OnCutTree, new Action<int>(JPKHCPGHNID));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnCrafterRepaired = (Action<int>)Delegate.Combine(instance2.OnCrafterRepaired, new Action<int>(OnCrafterRepaired));
		OnCrafterRepaired(1);
		PlayerInventory player = PlayerInventory.GetPlayer(1);
		player.OnChanged = (Action)Delegate.Combine(player.OnChanged, new Action(JIJHFAGOHBD));
		PlayerInventory player2 = PlayerInventory.GetPlayer(2);
		player2.OnChanged = (Action)Delegate.Combine(player2.OnChanged, new Action(JIJHFAGOHBD));
		JIJHFAGOHBD();
	}

	private void JIJHFAGOHBD()
	{
		DLGMLAADJNO = 0;
		if (PlayerInventory.AnyPlayerHasItem(1055))
		{
			if (PlayerInventory.GetPlayer(1).GetItem(1055) != null)
			{
				DLGMLAADJNO += PlayerInventory.GetPlayer(1).GetItem(1055).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.GetPlayer(2).GetItem(1055) != null)
			{
				DLGMLAADJNO += PlayerInventory.GetPlayer(2).GetItem(1055).currentSlot.Stack;
			}
			if (DLGMLAADJNO >= 5)
			{
				PlayerInventory player = PlayerInventory.GetPlayer(1);
				player.OnChanged = (Action)Delegate.Remove(player.OnChanged, new Action(JIJHFAGOHBD));
				PlayerInventory player2 = PlayerInventory.GetPlayer(2);
				player2.OnChanged = (Action)Delegate.Remove(player2.OnChanged, new Action(JIJHFAGOHBD));
				NewTutorialManager.instance.ObjectiveCompleted(1);
				DNAHJLGIMGA();
			}
		}
	}

	private IEnumerator JIJEDGBCENE()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (!MCKLEPHBECB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T123/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(703)).transform.position), Vector2.up * 0.7f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCutTree = (Action<int>)Delegate.Combine(instance.OnCutTree, new Action<int>(JPKHCPGHNID));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnCrafterRepaired = (Action<int>)Delegate.Combine(instance2.OnCrafterRepaired, new Action<int>(OnCrafterRepaired));
		OnCrafterRepaired(1);
		PlayerInventory player = PlayerInventory.GetPlayer(1);
		player.OnChanged = (Action)Delegate.Combine(player.OnChanged, new Action(JIJHFAGOHBD));
		PlayerInventory player2 = PlayerInventory.GetPlayer(2);
		player2.OnChanged = (Action)Delegate.Combine(player2.OnChanged, new Action(JIJHFAGOHBD));
		JIJHFAGOHBD();
	}

	private void ELPJGACHPOM()
	{
		DLGMLAADJNO = 0;
		if (PlayerInventory.AnyPlayerHasItem(159))
		{
			if (PlayerInventory.EIFPKCAFDIB(0, LAGHIOKLJGH: true).GOKIDLOELKB(-110) != null)
			{
				DLGMLAADJNO += PlayerInventory.NEKDDPIAOBE(0, LAGHIOKLJGH: true).GOKIDLOELKB(151).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.NEKDDPIAOBE(7).GetItem(58) != null)
			{
				DLGMLAADJNO += PlayerInventory.GetPlayer(2).KGHFAHKGIGK(-51).currentSlot.Stack;
			}
			if (DLGMLAADJNO >= 4)
			{
				PlayerInventory player = PlayerInventory.GetPlayer(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true);
				player.OnChanged = (Action)Delegate.Remove(player.OnChanged, new Action(GMKPCFDDKOF));
				PlayerInventory playerInventory = PlayerInventory.EIFPKCAFDIB(5, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
				playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(HCGHLEKKBJN));
				NewTutorialManager.instance.FOIOHOGACAL(0);
				DNAHJLGIMGA();
			}
		}
	}

	private IEnumerator LOPECFGACHD()
	{
		return new NIEHNJNCFEG(1)
		{
			_003C_003E4__this = this
		};
	}

	private void FHCHMJGNALM()
	{
		DLGMLAADJNO = 1;
		if (PlayerInventory.FKPAJKAGHIK(-16))
		{
			if (PlayerInventory.GetPlayer(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetItem(-187) != null)
			{
				DLGMLAADJNO += PlayerInventory.NEKDDPIAOBE(0).HCCFFBOMLFB(185).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.OGKNJNINGMH(7).HCCFFBOMLFB(-117) != null)
			{
				DLGMLAADJNO += PlayerInventory.EIFPKCAFDIB(8, LAGHIOKLJGH: true).KCCHMLKIFNJ(102).currentSlot.Stack;
			}
			if (DLGMLAADJNO >= 4)
			{
				PlayerInventory playerInventory = PlayerInventory.EIFPKCAFDIB(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true);
				playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(NLABJPMFIGB));
				PlayerInventory player = PlayerInventory.GetPlayer(2);
				player.OnChanged = (Action)Delegate.Remove(player.OnChanged, new Action(GGINDBNHPKF));
				NewTutorialManager.instance.ObjectiveCompleted(0);
				MIFKCFPGFNA();
			}
		}
	}

	private void PMPHDDPBDKB()
	{
		if (BLGAFCAHEHC && CHJNJADHFCN >= 8 && DLGMLAADJNO >= 4)
		{
			((MonoBehaviour)this).StartCoroutine(NHGHCANHKFA());
		}
	}

	private void MHEMFKMHBON(int JIIGOACEIKL)
	{
		CHJNJADHFCN++;
		if (CHJNJADHFCN >= 3)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnCutTree = (Action<int>)Delegate.Remove(commonReferences.OnCutTree, new Action<int>(AFBDEOCLPJJ));
			NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			AANDFPGJIJB();
		}
	}

	private IEnumerator KGIJEMPBBED()
	{
		return new OJILAJIDNBE(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator CFGLAPAKKAL()
	{
		return new OJILAJIDNBE(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LHDDHIJIFCN()
	{
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T127/Dialogue1", triggerPlayerNum);
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator DCEJFBKLGCD()
	{
		return new NIEHNJNCFEG(1)
		{
			_003C_003E4__this = this
		};
	}

	private void KDCIEDHAKPE()
	{
		DLGMLAADJNO = 0;
		if (PlayerInventory.FLMDMAOFGMI(74))
		{
			if (PlayerInventory.EIFPKCAFDIB(1).KCCHMLKIFNJ(-63) != null)
			{
				DLGMLAADJNO += PlayerInventory.GetPlayer(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GOKIDLOELKB(76).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.OGKNJNINGMH(6).GOKIDLOELKB(-200) != null)
			{
				DLGMLAADJNO += PlayerInventory.NEKDDPIAOBE(3, LAGHIOKLJGH: true).KGHFAHKGIGK(191).currentSlot.Stack;
			}
			if (DLGMLAADJNO >= 2)
			{
				PlayerInventory playerInventory = PlayerInventory.EIFPKCAFDIB(0, LAGHIOKLJGH: true);
				playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(ELPJGACHPOM));
				PlayerInventory playerInventory2 = PlayerInventory.EIFPKCAFDIB(1);
				playerInventory2.OnChanged = (Action)Delegate.Remove(playerInventory2.OnChanged, new Action(DGOEGEPOOGB));
				NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
				PMPHDDPBDKB();
			}
		}
	}

	private void KKCICIFBPNM()
	{
		if (BLGAFCAHEHC && CHJNJADHFCN >= 7 && DLGMLAADJNO >= 8)
		{
			((MonoBehaviour)this).StartCoroutine(BOMICOPCCML());
		}
	}

	private IEnumerator AJJHBJHCACM()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (!MCKLEPHBECB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T123/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(703)).transform.position), Vector2.up * 0.7f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCutTree = (Action<int>)Delegate.Combine(instance.OnCutTree, new Action<int>(JPKHCPGHNID));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnCrafterRepaired = (Action<int>)Delegate.Combine(instance2.OnCrafterRepaired, new Action<int>(OnCrafterRepaired));
		OnCrafterRepaired(1);
		PlayerInventory player = PlayerInventory.GetPlayer(1);
		player.OnChanged = (Action)Delegate.Combine(player.OnChanged, new Action(JIJHFAGOHBD));
		PlayerInventory player2 = PlayerInventory.GetPlayer(2);
		player2.OnChanged = (Action)Delegate.Combine(player2.OnChanged, new Action(JIJHFAGOHBD));
		JIJHFAGOHBD();
	}

	private void JPKHCPGHNID(int JIIGOACEIKL)
	{
		CHJNJADHFCN++;
		if (CHJNJADHFCN >= 5)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnCutTree = (Action<int>)Delegate.Remove(instance.OnCutTree, new Action<int>(JPKHCPGHNID));
			NewTutorialManager.instance.ObjectiveCompleted(0);
			DNAHJLGIMGA();
		}
	}

	private IEnumerator NHPCNDODFAK()
	{
		return new OJILAJIDNBE(1)
		{
			_003C_003E4__this = this
		};
	}

	private void HBLEJJENPMA()
	{
		DLGMLAADJNO = 0;
		if (PlayerInventory.FKPAJKAGHIK(-82))
		{
			if (PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).KGHFAHKGIGK(115) != null)
			{
				DLGMLAADJNO += PlayerInventory.NEKDDPIAOBE(0, LAGHIOKLJGH: true).HCCFFBOMLFB(47).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.EIFPKCAFDIB(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GetItem(97) != null)
			{
				DLGMLAADJNO += PlayerInventory.NEKDDPIAOBE(8, LAGHIOKLJGH: true).GOKIDLOELKB(107).currentSlot.Stack;
			}
			if (DLGMLAADJNO >= 5)
			{
				PlayerInventory playerInventory = PlayerInventory.NEKDDPIAOBE(1, LAGHIOKLJGH: true);
				playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(AINMKGFNCBK));
				PlayerInventory player = PlayerInventory.GetPlayer(1, LAGHIOKLJGH: true);
				player.OnChanged = (Action)Delegate.Remove(player.OnChanged, new Action(BNIFMHAKLLJ));
				NewTutorialManager.instance.FOIOHOGACAL(1);
				MIFKCFPGFNA();
			}
		}
	}

	public void OMEIFICFOMJ(int JIIGOACEIKL)
	{
		if (Crafter.sawmillRepaired)
		{
			BLGAFCAHEHC = true;
			NewTutorialManager.instance.ObjectiveCompleted(4);
			AIPEPDNEJHO();
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnCrafterRepaired = (Action<int>)Delegate.Remove(commonReferences.OnCrafterRepaired, new Action<int>(OGPIOEHHNLK));
			if (Object.op_Implicit((Object)(object)JELIKOFDONK))
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	public void CNGHLMLBOOM(int JIIGOACEIKL)
	{
		if (Crafter.sawmillRepaired)
		{
			BLGAFCAHEHC = true;
			NewTutorialManager.instance.FOIOHOGACAL(5, BLJPGJKOLNF: false);
			DNAHJLGIMGA();
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnCrafterRepaired = (Action<int>)Delegate.Remove(commonReferences.OnCrafterRepaired, new Action<int>(IIIHIBKBDGB));
			if (Object.op_Implicit((Object)(object)JELIKOFDONK))
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private void CDIMFLEDCDE()
	{
		DLGMLAADJNO = 1;
		if (PlayerInventory.FKPAJKAGHIK(194))
		{
			if (PlayerInventory.OGKNJNINGMH(1, LAGHIOKLJGH: true).GOKIDLOELKB(-190) != null)
			{
				DLGMLAADJNO += PlayerInventory.GetPlayer(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GOKIDLOELKB(137).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.OGKNJNINGMH(7, LAGHIOKLJGH: true, ADPNMHGBFKG: true).KCCHMLKIFNJ(10) != null)
			{
				DLGMLAADJNO += PlayerInventory.GetPlayer(8, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HCCFFBOMLFB(-29).currentSlot.Stack;
			}
			if (DLGMLAADJNO >= 1)
			{
				PlayerInventory playerInventory = PlayerInventory.OGKNJNINGMH(1);
				playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(AINMKGFNCBK));
				PlayerInventory player = PlayerInventory.GetPlayer(3);
				player.OnChanged = (Action)Delegate.Remove(player.OnChanged, new Action(BNIFMHAKLLJ));
				NewTutorialManager.instance.FOIOHOGACAL(1);
				BEGKOINEIKM();
			}
		}
	}

	private IEnumerator IKOKBPCANJK()
	{
		return new OJILAJIDNBE(1)
		{
			_003C_003E4__this = this
		};
	}

	private void NEJHPBLACJI()
	{
		DLGMLAADJNO = 0;
		if (PlayerInventory.AnyPlayerHasItem(166))
		{
			if (PlayerInventory.NEKDDPIAOBE(1).GOKIDLOELKB(-156) != null)
			{
				DLGMLAADJNO += PlayerInventory.OGKNJNINGMH(0, LAGHIOKLJGH: true).HCCFFBOMLFB(167).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.GetPlayer(2, LAGHIOKLJGH: true).KGHFAHKGIGK(-43) != null)
			{
				DLGMLAADJNO += PlayerInventory.GetPlayer(3, LAGHIOKLJGH: true).KCCHMLKIFNJ(149).currentSlot.Stack;
			}
			if (DLGMLAADJNO >= 3)
			{
				PlayerInventory player = PlayerInventory.GetPlayer(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true);
				player.OnChanged = (Action)Delegate.Remove(player.OnChanged, new Action(BNIFMHAKLLJ));
				PlayerInventory playerInventory = PlayerInventory.NEKDDPIAOBE(4);
				playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(CDIMFLEDCDE));
				NewTutorialManager.instance.FOIOHOGACAL(1);
				MIFKCFPGFNA();
			}
		}
	}

	private IEnumerator CKIMLLCOEGC()
	{
		return new OJILAJIDNBE(1)
		{
			_003C_003E4__this = this
		};
	}

	public void IBFGDPDNGIM(int JIIGOACEIKL)
	{
		if (Crafter.sawmillRepaired)
		{
			BLGAFCAHEHC = false;
			NewTutorialManager.instance.FOIOHOGACAL(5, BLJPGJKOLNF: false);
			AJDFCHFKHOK();
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnCrafterRepaired = (Action<int>)Delegate.Remove(commonReferences.OnCrafterRepaired, new Action<int>(GEHHFEAPGLB));
			if (Object.op_Implicit((Object)(object)JELIKOFDONK))
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private void HMNEDGEPOCJ()
	{
		if (BLGAFCAHEHC && CHJNJADHFCN >= 7 && DLGMLAADJNO >= 6)
		{
			((MonoBehaviour)this).StartCoroutine(BOMICOPCCML());
		}
	}

	private IEnumerator NCBODCOOANK()
	{
		return new OJILAJIDNBE(1)
		{
			_003C_003E4__this = this
		};
	}

	public override int GetID()
	{
		return 123;
	}

	private void HMNEDLNGICH()
	{
		DLGMLAADJNO = 1;
		if (PlayerInventory.FKPAJKAGHIK(93))
		{
			if (PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).KGHFAHKGIGK(-146) != null)
			{
				DLGMLAADJNO += PlayerInventory.NEKDDPIAOBE(1, LAGHIOKLJGH: true).KCCHMLKIFNJ(61).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.OGKNJNINGMH(2, LAGHIOKLJGH: true).KGHFAHKGIGK(153) != null)
			{
				DLGMLAADJNO += PlayerInventory.NEKDDPIAOBE(4, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HCCFFBOMLFB(-42).currentSlot.Stack;
			}
			if (DLGMLAADJNO >= 5)
			{
				PlayerInventory playerInventory = PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: true);
				playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(DGOEGEPOOGB));
				PlayerInventory playerInventory2 = PlayerInventory.OGKNJNINGMH(0);
				playerInventory2.OnChanged = (Action)Delegate.Remove(playerInventory2.OnChanged, new Action(FHCHMJGNALM));
				NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
				AJDFCHFKHOK();
			}
		}
	}

	private void AJDFCHFKHOK()
	{
		if (BLGAFCAHEHC && CHJNJADHFCN >= 7 && DLGMLAADJNO >= 7)
		{
			((MonoBehaviour)this).StartCoroutine(CFGLAPAKKAL());
		}
	}

	public void PEFNOBNPJNH(int JIIGOACEIKL)
	{
		if (Crafter.sawmillRepaired)
		{
			BLGAFCAHEHC = false;
			NewTutorialManager.instance.FOIOHOGACAL(8);
			BEGKOINEIKM();
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnCrafterRepaired = (Action<int>)Delegate.Remove(instance.OnCrafterRepaired, new Action<int>(GEHHFEAPGLB));
			if (Object.op_Implicit((Object)(object)JELIKOFDONK))
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private IEnumerator CNPIAJBODCG()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (!MCKLEPHBECB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T123/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(703)).transform.position), Vector2.up * 0.7f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCutTree = (Action<int>)Delegate.Combine(instance.OnCutTree, new Action<int>(JPKHCPGHNID));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnCrafterRepaired = (Action<int>)Delegate.Combine(instance2.OnCrafterRepaired, new Action<int>(OnCrafterRepaired));
		OnCrafterRepaired(1);
		PlayerInventory player = PlayerInventory.GetPlayer(1);
		player.OnChanged = (Action)Delegate.Combine(player.OnChanged, new Action(JIJHFAGOHBD));
		PlayerInventory player2 = PlayerInventory.GetPlayer(2);
		player2.OnChanged = (Action)Delegate.Combine(player2.OnChanged, new Action(JIJHFAGOHBD));
		JIJHFAGOHBD();
	}

	private void FGCCHFAJGIL()
	{
		DLGMLAADJNO = 1;
		if (PlayerInventory.AnyPlayerHasItem(-121))
		{
			if (PlayerInventory.OGKNJNINGMH(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).KCCHMLKIFNJ(-50) != null)
			{
				DLGMLAADJNO += PlayerInventory.OGKNJNINGMH(0, LAGHIOKLJGH: true).HCCFFBOMLFB(4).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.EIFPKCAFDIB(7, LAGHIOKLJGH: false, ADPNMHGBFKG: true).KGHFAHKGIGK(-132) != null)
			{
				DLGMLAADJNO += PlayerInventory.EIFPKCAFDIB(2, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GetItem(-191).currentSlot.Stack;
			}
			if (DLGMLAADJNO >= 2)
			{
				PlayerInventory playerInventory = PlayerInventory.NEKDDPIAOBE(0, LAGHIOKLJGH: true);
				playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(FBOKPBALOEM));
				PlayerInventory playerInventory2 = PlayerInventory.OGKNJNINGMH(6);
				playerInventory2.OnChanged = (Action)Delegate.Remove(playerInventory2.OnChanged, new Action(NEJHPBLACJI));
				NewTutorialManager.instance.FOIOHOGACAL(1);
				LLFLGEPLJKJ();
			}
		}
	}

	private void NCFPIGEBJIN()
	{
		DLGMLAADJNO = 0;
		if (PlayerInventory.FLMDMAOFGMI(185))
		{
			if (PlayerInventory.EIFPKCAFDIB(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HCCFFBOMLFB(47) != null)
			{
				DLGMLAADJNO += PlayerInventory.OGKNJNINGMH(0).KGHFAHKGIGK(-193).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.EIFPKCAFDIB(0).GetItem(-62) != null)
			{
				DLGMLAADJNO += PlayerInventory.NEKDDPIAOBE(7, LAGHIOKLJGH: true, ADPNMHGBFKG: true).KCCHMLKIFNJ(153).currentSlot.Stack;
			}
			if (DLGMLAADJNO >= 5)
			{
				PlayerInventory playerInventory = PlayerInventory.OGKNJNINGMH(0);
				playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(GMKPCFDDKOF));
				PlayerInventory playerInventory2 = PlayerInventory.OGKNJNINGMH(6, LAGHIOKLJGH: true);
				playerInventory2.OnChanged = (Action)Delegate.Remove(playerInventory2.OnChanged, new Action(ELPJGACHPOM));
				NewTutorialManager.instance.FOIOHOGACAL(0);
				HMNEDGEPOCJ();
			}
		}
	}

	private void DPMFFNDBMAJ(int JIIGOACEIKL)
	{
		CHJNJADHFCN += 0;
		if (CHJNJADHFCN >= 3)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnCutTree = (Action<int>)Delegate.Remove(commonReferences.OnCutTree, new Action<int>(OCDCIPEONHM));
			NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			AIPEPDNEJHO();
		}
	}

	private IEnumerator OPCHFFMKPCN()
	{
		return new NIEHNJNCFEG(1)
		{
			_003C_003E4__this = this
		};
	}

	private void EDCHFKMPJDK()
	{
		if (BLGAFCAHEHC && CHJNJADHFCN >= 7 && DLGMLAADJNO >= 4)
		{
			((MonoBehaviour)this).StartCoroutine(MGHHGMLMMJC());
		}
	}

	private IEnumerator AIHDGKOJBCO()
	{
		return new NIEHNJNCFEG(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator IIMPCJICOOO()
	{
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T127/Dialogue1", triggerPlayerNum);
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private void AIPEPDNEJHO()
	{
		if (BLGAFCAHEHC && CHJNJADHFCN >= 6 && DLGMLAADJNO >= 5)
		{
			((MonoBehaviour)this).StartCoroutine(IHGGOFFGMBD());
		}
	}

	public void CGLPEOILBCJ(int JIIGOACEIKL)
	{
		if (Crafter.sawmillRepaired)
		{
			BLGAFCAHEHC = false;
			NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			FFOJNJILDCF();
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnCrafterRepaired = (Action<int>)Delegate.Remove(instance.OnCrafterRepaired, new Action<int>(IBFGDPDNGIM));
			if (Object.op_Implicit((Object)(object)JELIKOFDONK))
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private void AANDFPGJIJB()
	{
		if (BLGAFCAHEHC && CHJNJADHFCN >= 3 && DLGMLAADJNO >= 3)
		{
			((MonoBehaviour)this).StartCoroutine(CFGLAPAKKAL());
		}
	}

	private void CBBPLKMILGF(int JIIGOACEIKL)
	{
		CHJNJADHFCN += 0;
		if (CHJNJADHFCN >= 1)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnCutTree = (Action<int>)Delegate.Remove(commonReferences.OnCutTree, new Action<int>(HDOMCCOKGIK));
			NewTutorialManager.instance.ObjectiveCompleted(0);
			LFKILIDFGKE();
		}
	}

	private IEnumerator JPFGGJMNOKH()
	{
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T127/Dialogue1", triggerPlayerNum);
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private void DGOEGEPOOGB()
	{
		DLGMLAADJNO = 0;
		if (PlayerInventory.FKPAJKAGHIK(193))
		{
			if (PlayerInventory.EIFPKCAFDIB(1).HCCFFBOMLFB(129) != null)
			{
				DLGMLAADJNO += PlayerInventory.EIFPKCAFDIB(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GOKIDLOELKB(188).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.NEKDDPIAOBE(5, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GetItem(43) != null)
			{
				DLGMLAADJNO += PlayerInventory.NEKDDPIAOBE(5).GOKIDLOELKB(37).currentSlot.Stack;
			}
			if (DLGMLAADJNO >= 1)
			{
				PlayerInventory playerInventory = PlayerInventory.NEKDDPIAOBE(0);
				playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(NLABJPMFIGB));
				PlayerInventory playerInventory2 = PlayerInventory.EIFPKCAFDIB(4, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
				playerInventory2.OnChanged = (Action)Delegate.Remove(playerInventory2.OnChanged, new Action(IFALJNMANJO));
				NewTutorialManager.instance.ObjectiveCompleted(1);
				MIFKCFPGFNA();
			}
		}
	}

	public void PLHDMIBHJME(int JIIGOACEIKL)
	{
		if (Crafter.sawmillRepaired)
		{
			BLGAFCAHEHC = false;
			NewTutorialManager.instance.FOIOHOGACAL(4);
			FFOJNJILDCF();
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnCrafterRepaired = (Action<int>)Delegate.Remove(commonReferences.OnCrafterRepaired, new Action<int>(OMEIFICFOMJ));
			if (Object.op_Implicit((Object)(object)JELIKOFDONK))
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private IEnumerator AELFLHCNMBB()
	{
		return new OJILAJIDNBE(1)
		{
			_003C_003E4__this = this
		};
	}

	private void MIFKCFPGFNA()
	{
		if (BLGAFCAHEHC && CHJNJADHFCN >= 6 && DLGMLAADJNO >= 4)
		{
			((MonoBehaviour)this).StartCoroutine(CKIMLLCOEGC());
		}
	}

	private void MEAJICFEOOP(int JIIGOACEIKL)
	{
		CHJNJADHFCN += 0;
		if (CHJNJADHFCN >= 0)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnCutTree = (Action<int>)Delegate.Remove(instance.OnCutTree, new Action<int>(AFBDEOCLPJJ));
			NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			AJDFCHFKHOK();
		}
	}

	public void EPDHMLLNFJH(int JIIGOACEIKL)
	{
		if (Crafter.sawmillRepaired)
		{
			BLGAFCAHEHC = false;
			NewTutorialManager.instance.FOIOHOGACAL(5);
			ECOFGIPHBCC();
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnCrafterRepaired = (Action<int>)Delegate.Remove(commonReferences.OnCrafterRepaired, new Action<int>(PLHDMIBHJME));
			if (Object.op_Implicit((Object)(object)JELIKOFDONK))
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private void PJNMCKKJCOF(int JIIGOACEIKL)
	{
		CHJNJADHFCN += 0;
		if (CHJNJADHFCN >= 2)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnCutTree = (Action<int>)Delegate.Remove(instance.OnCutTree, new Action<int>(CJGOAAEANEO));
			NewTutorialManager.instance.ObjectiveCompleted(0);
			MIFKCFPGFNA();
		}
	}

	public void IOLEMDJHNDP(int JIIGOACEIKL)
	{
		if (Crafter.sawmillRepaired)
		{
			BLGAFCAHEHC = true;
			NewTutorialManager.instance.ObjectiveCompleted(6);
			PMPHDDPBDKB();
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnCrafterRepaired = (Action<int>)Delegate.Remove(commonReferences.OnCrafterRepaired, new Action<int>(PLHDMIBHJME));
			if (Object.op_Implicit((Object)(object)JELIKOFDONK))
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private void NNCJGJNPJFO(int JIIGOACEIKL)
	{
		CHJNJADHFCN += 0;
		if (CHJNJADHFCN >= 0)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnCutTree = (Action<int>)Delegate.Remove(commonReferences.OnCutTree, new Action<int>(MEAJICFEOOP));
			NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			HMNEDGEPOCJ();
		}
	}

	private IEnumerator JCMMNNCKPDO()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(5.958333f, -12.875f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (!MCKLEPHBECB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T123/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)NewTutorialManager.instance.FindACrafter(703)).transform.position), Vector2.up * 0.7f, ref JELIKOFDONK);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnCutTree = (Action<int>)Delegate.Combine(instance.OnCutTree, new Action<int>(JPKHCPGHNID));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnCrafterRepaired = (Action<int>)Delegate.Combine(instance2.OnCrafterRepaired, new Action<int>(OnCrafterRepaired));
		OnCrafterRepaired(1);
		PlayerInventory player = PlayerInventory.GetPlayer(1);
		player.OnChanged = (Action)Delegate.Combine(player.OnChanged, new Action(JIJHFAGOHBD));
		PlayerInventory player2 = PlayerInventory.GetPlayer(2);
		player2.OnChanged = (Action)Delegate.Combine(player2.OnChanged, new Action(JIJHFAGOHBD));
		JIJHFAGOHBD();
	}

	public void MFMAHOIAPJL(int JIIGOACEIKL)
	{
		if (Crafter.sawmillRepaired)
		{
			BLGAFCAHEHC = true;
			NewTutorialManager.instance.ObjectiveCompleted(4);
			MEHBGBNOHID();
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnCrafterRepaired = (Action<int>)Delegate.Remove(instance.OnCrafterRepaired, new Action<int>(HJGDCALICKH));
			if (Object.op_Implicit((Object)(object)JELIKOFDONK))
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	public void DDGDCIPPHLM(int JIIGOACEIKL)
	{
		if (Crafter.sawmillRepaired)
		{
			BLGAFCAHEHC = false;
			NewTutorialManager.instance.FOIOHOGACAL(0);
			MEHBGBNOHID();
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnCrafterRepaired = (Action<int>)Delegate.Remove(commonReferences.OnCrafterRepaired, new Action<int>(NFIKGNMMJHA));
			if (Object.op_Implicit((Object)(object)JELIKOFDONK))
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
		}
	}

	private IEnumerator NHGHCANHKFA()
	{
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T127/Dialogue1", triggerPlayerNum);
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private void FMEJDLGGOBF(int JIIGOACEIKL)
	{
		CHJNJADHFCN += 0;
		if (CHJNJADHFCN >= 2)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnCutTree = (Action<int>)Delegate.Remove(commonReferences.OnCutTree, new Action<int>(FMEJDLGGOBF));
			NewTutorialManager.instance.ObjectiveCompleted(0);
			LLFLGEPLJKJ();
		}
	}
}
