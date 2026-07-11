using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class T125_ExtraerHierro : TutorialPhaseBase
{
	[CompilerGenerated]
	private sealed class LLABKJKCFJN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T125_ExtraerHierro _003C_003E4__this;

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
			T125_ExtraerHierro t125_ExtraerHierro = _003C_003E4__this;
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
				t125_ExtraerHierro.LHKIJABBBPM();
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

		public T125_ExtraerHierro _003C_003E4__this;

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
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			T125_ExtraerHierro t125_ExtraerHierro = _003C_003E4__this;
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
				MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T125/Dialogue1", t125_ExtraerHierro.triggerPlayerNum);
				goto IL_0169;
			case 5:
				_003C_003E1__state = -1;
				goto IL_0169;
			case 6:
				{
					_003C_003E1__state = -1;
					NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
					NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
					PlayerInventory player = PlayerInventory.GetPlayer(1);
					player.OnChanged = (Action)Delegate.Combine(player.OnChanged, new Action(t125_ExtraerHierro.JIJHFAGOHBD));
					PlayerInventory player2 = PlayerInventory.GetPlayer(2);
					player2.OnChanged = (Action)Delegate.Combine(player2.OnChanged, new Action(t125_ExtraerHierro.JIJHFAGOHBD));
					return false;
				}
				IL_0169:
				if (t125_ExtraerHierro.AAOPIEDAKKD(1))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 5;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 6;
				return true;
				IL_00d7:
				if (!t125_ExtraerHierro.MCKLEPHBECB())
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 2;
					return true;
				}
				_003C_003E2__current = ((MonoBehaviour)t125_ExtraerHierro).StartCoroutine(t125_ExtraerHierro.CDICFNAMCEE());
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

	private int DLGMLAADJNO;

	private int BONADPLNEFE;

	private bool MDAPLEMILBI;

	private bool EDEIAFDEMPF;

	private IEnumerator BJPDFDCOJKJ()
	{
		return new LLABKJKCFJN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void MDPEMJCLGIN()
	{
		BONADPLNEFE = 0;
		DLGMLAADJNO = 1;
		if (!MDAPLEMILBI && PlayerInventory.FKPAJKAGHIK(-40))
		{
			if (PlayerInventory.NEKDDPIAOBE(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).KCCHMLKIFNJ(-169) != null)
			{
				BONADPLNEFE += PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).KCCHMLKIFNJ(125).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.NEKDDPIAOBE(7).HCCFFBOMLFB(194) != null)
			{
				BONADPLNEFE += PlayerInventory.NEKDDPIAOBE(5, LAGHIOKLJGH: true).KCCHMLKIFNJ(-11).currentSlot.Stack;
			}
			if (BONADPLNEFE >= 3)
			{
				MDAPLEMILBI = true;
				NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			}
		}
		if (!EDEIAFDEMPF && PlayerInventory.FLMDMAOFGMI(-104))
		{
			if (PlayerInventory.NEKDDPIAOBE(0).GOKIDLOELKB(68) != null)
			{
				DLGMLAADJNO += PlayerInventory.OGKNJNINGMH(0).HCCFFBOMLFB(122).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.GetPlayer(8, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GOKIDLOELKB(-129) != null)
			{
				DLGMLAADJNO += PlayerInventory.GetPlayer(7, LAGHIOKLJGH: true, ADPNMHGBFKG: true).KCCHMLKIFNJ(7).currentSlot.Stack;
			}
			if (DLGMLAADJNO >= 7)
			{
				EDEIAFDEMPF = false;
				NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			}
		}
		if (EDEIAFDEMPF && MDAPLEMILBI)
		{
			PlayerInventory playerInventory = PlayerInventory.OGKNJNINGMH(1);
			playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(PAGPINIKKDL));
			PlayerInventory playerInventory2 = PlayerInventory.OGKNJNINGMH(3, LAGHIOKLJGH: true);
			playerInventory2.OnChanged = (Action)Delegate.Remove(playerInventory2.OnChanged, new Action(BHGKDFFGPIK));
			((MonoBehaviour)this).StartCoroutine(BJPDFDCOJKJ());
		}
	}

	private IEnumerator NCNGHNLFCBO()
	{
		return new PCDGAFFFPGD(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NKOJNIDHGBJ()
	{
		return new PCDGAFFFPGD(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator BOMICOPCCML()
	{
		return new LLABKJKCFJN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JAHNJFGKFII()
	{
		return new PCDGAFFFPGD(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LAMBONHALKD()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
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
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T125/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		PlayerInventory player = PlayerInventory.GetPlayer(1);
		player.OnChanged = (Action)Delegate.Combine(player.OnChanged, new Action(JIJHFAGOHBD));
		PlayerInventory player2 = PlayerInventory.GetPlayer(2);
		player2.OnChanged = (Action)Delegate.Combine(player2.OnChanged, new Action(JIJHFAGOHBD));
	}

	private void NIAGKLOPNMD()
	{
		BONADPLNEFE = 1;
		DLGMLAADJNO = 0;
		if (!MDAPLEMILBI && PlayerInventory.FLMDMAOFGMI(28))
		{
			if (PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HCCFFBOMLFB(174) != null)
			{
				BONADPLNEFE += PlayerInventory.EIFPKCAFDIB(1).KGHFAHKGIGK(91).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.EIFPKCAFDIB(6).GetItem(147) != null)
			{
				BONADPLNEFE += PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).KGHFAHKGIGK(-27).currentSlot.Stack;
			}
			if (BONADPLNEFE >= 4)
			{
				MDAPLEMILBI = false;
				NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			}
		}
		if (!EDEIAFDEMPF && PlayerInventory.AnyPlayerHasItem(-166))
		{
			if (PlayerInventory.EIFPKCAFDIB(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HCCFFBOMLFB(67) != null)
			{
				DLGMLAADJNO += PlayerInventory.GetPlayer(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GOKIDLOELKB(194).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.NEKDDPIAOBE(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetItem(42) != null)
			{
				DLGMLAADJNO += PlayerInventory.NEKDDPIAOBE(8, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GOKIDLOELKB(-177).currentSlot.Stack;
			}
			if (DLGMLAADJNO >= 2)
			{
				EDEIAFDEMPF = true;
				NewTutorialManager.instance.FOIOHOGACAL(0);
			}
		}
		if (EDEIAFDEMPF && MDAPLEMILBI)
		{
			PlayerInventory player = PlayerInventory.GetPlayer(1, LAGHIOKLJGH: true);
			player.OnChanged = (Action)Delegate.Remove(player.OnChanged, new Action(ANJLLPFAPNI));
			PlayerInventory playerInventory = PlayerInventory.NEKDDPIAOBE(6);
			playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(FHCHMJGNALM));
			((MonoBehaviour)this).StartCoroutine(NBENGPAEGCL());
		}
	}

	private IEnumerator DECKMELAPMA()
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

	private IEnumerator OPCHFFMKPCN()
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
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T125/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		PlayerInventory player = PlayerInventory.GetPlayer(1);
		player.OnChanged = (Action)Delegate.Combine(player.OnChanged, new Action(JIJHFAGOHBD));
		PlayerInventory player2 = PlayerInventory.GetPlayer(2);
		player2.OnChanged = (Action)Delegate.Combine(player2.OnChanged, new Action(JIJHFAGOHBD));
	}

	private IEnumerator NHPCNDODFAK()
	{
		return new LLABKJKCFJN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void JPCGKOFONMP()
	{
		BONADPLNEFE = 1;
		DLGMLAADJNO = 0;
		if (!MDAPLEMILBI && PlayerInventory.FKPAJKAGHIK(-164))
		{
			if (PlayerInventory.OGKNJNINGMH(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HCCFFBOMLFB(171) != null)
			{
				BONADPLNEFE += PlayerInventory.GetPlayer(0, LAGHIOKLJGH: true).HCCFFBOMLFB(-41).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.NEKDDPIAOBE(7, LAGHIOKLJGH: true).GetItem(14) != null)
			{
				BONADPLNEFE += PlayerInventory.NEKDDPIAOBE(8, LAGHIOKLJGH: true).KCCHMLKIFNJ(61).currentSlot.Stack;
			}
			if (BONADPLNEFE >= 2)
			{
				MDAPLEMILBI = true;
				NewTutorialManager.instance.FOIOHOGACAL(0);
			}
		}
		if (!EDEIAFDEMPF && PlayerInventory.FKPAJKAGHIK(169))
		{
			if (PlayerInventory.GetPlayer(1).HCCFFBOMLFB(7) != null)
			{
				DLGMLAADJNO += PlayerInventory.EIFPKCAFDIB(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).KCCHMLKIFNJ(-63).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.OGKNJNINGMH(7).GOKIDLOELKB(6) != null)
			{
				DLGMLAADJNO += PlayerInventory.EIFPKCAFDIB(3, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetItem(119).currentSlot.Stack;
			}
			if (DLGMLAADJNO >= 4)
			{
				EDEIAFDEMPF = false;
				NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			}
		}
		if (EDEIAFDEMPF && MDAPLEMILBI)
		{
			PlayerInventory playerInventory = PlayerInventory.OGKNJNINGMH(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
			playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(ANJLLPFAPNI));
			PlayerInventory player = PlayerInventory.GetPlayer(5, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
			player.OnChanged = (Action)Delegate.Remove(player.OnChanged, new Action(GKBGHBKHEMO));
			((MonoBehaviour)this).StartCoroutine(IAOFDDMPMBJ());
		}
	}

	private IEnumerator CPCGNMPLFHM()
	{
		return new PCDGAFFFPGD(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HGKFAONPGGB()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private void PJONABBLADP()
	{
		BONADPLNEFE = 0;
		DLGMLAADJNO = 1;
		if (!MDAPLEMILBI && PlayerInventory.FLMDMAOFGMI(68))
		{
			if (PlayerInventory.OGKNJNINGMH(0).KGHFAHKGIGK(36) != null)
			{
				BONADPLNEFE += PlayerInventory.GetPlayer(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).KCCHMLKIFNJ(-79).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.EIFPKCAFDIB(7).HCCFFBOMLFB(7) != null)
			{
				BONADPLNEFE += PlayerInventory.GetPlayer(7, LAGHIOKLJGH: true).GOKIDLOELKB(46).currentSlot.Stack;
			}
			if (BONADPLNEFE >= 3)
			{
				MDAPLEMILBI = false;
				NewTutorialManager.instance.ObjectiveCompleted(1);
			}
		}
		if (!EDEIAFDEMPF && PlayerInventory.FLMDMAOFGMI(70))
		{
			if (PlayerInventory.GetPlayer(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HCCFFBOMLFB(110) != null)
			{
				DLGMLAADJNO += PlayerInventory.OGKNJNINGMH(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GetItem(9).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.EIFPKCAFDIB(7, LAGHIOKLJGH: true).KGHFAHKGIGK(94) != null)
			{
				DLGMLAADJNO += PlayerInventory.NEKDDPIAOBE(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).KGHFAHKGIGK(77).currentSlot.Stack;
			}
			if (DLGMLAADJNO >= 8)
			{
				EDEIAFDEMPF = true;
				NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			}
		}
		if (EDEIAFDEMPF && MDAPLEMILBI)
		{
			PlayerInventory playerInventory = PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true);
			playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(PJONABBLADP));
			PlayerInventory playerInventory2 = PlayerInventory.NEKDDPIAOBE(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
			playerInventory2.OnChanged = (Action)Delegate.Remove(playerInventory2.OnChanged, new Action(OCAGMHAFHEN));
			((MonoBehaviour)this).StartCoroutine(JKLDKCKPFBJ());
		}
	}

	private IEnumerator AJJPECIKMJN()
	{
		return new LLABKJKCFJN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator BBGHMMLBAME()
	{
		return new PCDGAFFFPGD(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LHDDHIJIFCN()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator CNPIAJBODCG()
	{
		return new PCDGAFFFPGD(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LPNNMDOPCCJ()
	{
		return new PCDGAFFFPGD(1)
		{
			_003C_003E4__this = this
		};
	}

	private void DNAHLOIBGEO()
	{
		BONADPLNEFE = 1;
		DLGMLAADJNO = 1;
		if (!MDAPLEMILBI && PlayerInventory.FKPAJKAGHIK(-65))
		{
			if (PlayerInventory.OGKNJNINGMH(1, LAGHIOKLJGH: true).HCCFFBOMLFB(-147) != null)
			{
				BONADPLNEFE += PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).KCCHMLKIFNJ(178).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.GetPlayer(1).KCCHMLKIFNJ(164) != null)
			{
				BONADPLNEFE += PlayerInventory.NEKDDPIAOBE(5, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HCCFFBOMLFB(134).currentSlot.Stack;
			}
			if (BONADPLNEFE >= 0)
			{
				MDAPLEMILBI = false;
				NewTutorialManager.instance.ObjectiveCompleted(0);
			}
		}
		if (!EDEIAFDEMPF && PlayerInventory.AnyPlayerHasItem(-69))
		{
			if (PlayerInventory.GetPlayer(1).HCCFFBOMLFB(-165) != null)
			{
				DLGMLAADJNO += PlayerInventory.OGKNJNINGMH(0).KGHFAHKGIGK(137).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.OGKNJNINGMH(8, LAGHIOKLJGH: false, ADPNMHGBFKG: true).KGHFAHKGIGK(-99) != null)
			{
				DLGMLAADJNO += PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: true).KCCHMLKIFNJ(-117).currentSlot.Stack;
			}
			if (DLGMLAADJNO >= 8)
			{
				EDEIAFDEMPF = false;
				NewTutorialManager.instance.FOIOHOGACAL(0);
			}
		}
		if (EDEIAFDEMPF && MDAPLEMILBI)
		{
			PlayerInventory playerInventory = PlayerInventory.OGKNJNINGMH(0);
			playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(ALAJOLFIMME));
			PlayerInventory player = PlayerInventory.GetPlayer(0);
			player.OnChanged = (Action)Delegate.Remove(player.OnChanged, new Action(MDPEMJCLGIN));
			((MonoBehaviour)this).StartCoroutine(AJJPECIKMJN());
		}
	}

	private void FACLDCEIJOK()
	{
		BONADPLNEFE = 1;
		DLGMLAADJNO = 0;
		if (!MDAPLEMILBI && PlayerInventory.FLMDMAOFGMI(-84))
		{
			if (PlayerInventory.GetPlayer(0).GetItem(130) != null)
			{
				BONADPLNEFE += PlayerInventory.EIFPKCAFDIB(0).KGHFAHKGIGK(89).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.EIFPKCAFDIB(6, LAGHIOKLJGH: true).HCCFFBOMLFB(-30) != null)
			{
				BONADPLNEFE += PlayerInventory.OGKNJNINGMH(8, LAGHIOKLJGH: true).KCCHMLKIFNJ(-192).currentSlot.Stack;
			}
			if (BONADPLNEFE >= 8)
			{
				MDAPLEMILBI = true;
				NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			}
		}
		if (!EDEIAFDEMPF && PlayerInventory.AnyPlayerHasItem(68))
		{
			if (PlayerInventory.GetPlayer(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).KCCHMLKIFNJ(-169) != null)
			{
				DLGMLAADJNO += PlayerInventory.OGKNJNINGMH(1).GOKIDLOELKB(113).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.GetPlayer(6, LAGHIOKLJGH: false, ADPNMHGBFKG: true).KCCHMLKIFNJ(-61) != null)
			{
				DLGMLAADJNO += PlayerInventory.OGKNJNINGMH(7).GOKIDLOELKB(127).currentSlot.Stack;
			}
			if (DLGMLAADJNO >= 4)
			{
				EDEIAFDEMPF = false;
				NewTutorialManager.instance.FOIOHOGACAL(0);
			}
		}
		if (EDEIAFDEMPF && MDAPLEMILBI)
		{
			PlayerInventory playerInventory = PlayerInventory.NEKDDPIAOBE(0);
			playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(OCAGMHAFHEN));
			PlayerInventory playerInventory2 = PlayerInventory.OGKNJNINGMH(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
			playerInventory2.OnChanged = (Action)Delegate.Remove(playerInventory2.OnChanged, new Action(JPCGKOFONMP));
			((MonoBehaviour)this).StartCoroutine(BOMICOPCCML());
		}
	}

	private IEnumerator BGFNCKGFJPG()
	{
		return new LLABKJKCFJN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator COMPHHHBLIO()
	{
		return new LLABKJKCFJN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator GGACDGHOJEF()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator DNAAOCABLNF()
	{
		return new PCDGAFFFPGD(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator FAEKOKEINEH()
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
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T125/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		PlayerInventory player = PlayerInventory.GetPlayer(1);
		player.OnChanged = (Action)Delegate.Combine(player.OnChanged, new Action(JIJHFAGOHBD));
		PlayerInventory player2 = PlayerInventory.GetPlayer(2);
		player2.OnChanged = (Action)Delegate.Combine(player2.OnChanged, new Action(JIJHFAGOHBD));
	}

	private IEnumerator OCCLCKFAILK()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator MPJMCMIMHFC()
	{
		return new LLABKJKCFJN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void LBFPICDLEMM()
	{
		BONADPLNEFE = 0;
		DLGMLAADJNO = 0;
		if (!MDAPLEMILBI && PlayerInventory.FLMDMAOFGMI(-118))
		{
			if (PlayerInventory.OGKNJNINGMH(1, LAGHIOKLJGH: true).KGHFAHKGIGK(26) != null)
			{
				BONADPLNEFE += PlayerInventory.NEKDDPIAOBE(0).KCCHMLKIFNJ(-78).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.EIFPKCAFDIB(8, LAGHIOKLJGH: false, ADPNMHGBFKG: true).KCCHMLKIFNJ(-159) != null)
			{
				BONADPLNEFE += PlayerInventory.OGKNJNINGMH(8, LAGHIOKLJGH: true, ADPNMHGBFKG: true).KCCHMLKIFNJ(-3).currentSlot.Stack;
			}
			if (BONADPLNEFE >= 0)
			{
				MDAPLEMILBI = true;
				NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			}
		}
		if (!EDEIAFDEMPF && PlayerInventory.FKPAJKAGHIK(167))
		{
			if (PlayerInventory.GetPlayer(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HCCFFBOMLFB(118) != null)
			{
				DLGMLAADJNO += PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).KGHFAHKGIGK(-177).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.GetPlayer(6, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GetItem(183) != null)
			{
				DLGMLAADJNO += PlayerInventory.NEKDDPIAOBE(2, LAGHIOKLJGH: true).GOKIDLOELKB(-153).currentSlot.Stack;
			}
			if (DLGMLAADJNO >= 0)
			{
				EDEIAFDEMPF = true;
				NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			}
		}
		if (EDEIAFDEMPF && MDAPLEMILBI)
		{
			PlayerInventory player = PlayerInventory.GetPlayer(1, LAGHIOKLJGH: true);
			player.OnChanged = (Action)Delegate.Remove(player.OnChanged, new Action(GGINDBNHPKF));
			PlayerInventory playerInventory = PlayerInventory.EIFPKCAFDIB(7, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
			playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(NIAGKLOPNMD));
			((MonoBehaviour)this).StartCoroutine(LPCPNKEMCNM());
		}
	}

	private IEnumerator IGEOMOOKOEP()
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
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T125/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		PlayerInventory player = PlayerInventory.GetPlayer(1);
		player.OnChanged = (Action)Delegate.Combine(player.OnChanged, new Action(JIJHFAGOHBD));
		PlayerInventory player2 = PlayerInventory.GetPlayer(2);
		player2.OnChanged = (Action)Delegate.Combine(player2.OnChanged, new Action(JIJHFAGOHBD));
	}

	public override void SetUp()
	{
		base.SetUp();
		((MonoBehaviour)this).StartCoroutine(PBEKBJIJFDK());
	}

	private void FHCHMJGNALM()
	{
		BONADPLNEFE = 1;
		DLGMLAADJNO = 1;
		if (!MDAPLEMILBI && PlayerInventory.FKPAJKAGHIK(41))
		{
			if (PlayerInventory.EIFPKCAFDIB(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HCCFFBOMLFB(105) != null)
			{
				BONADPLNEFE += PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HCCFFBOMLFB(188).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.OGKNJNINGMH(1).KCCHMLKIFNJ(63) != null)
			{
				BONADPLNEFE += PlayerInventory.OGKNJNINGMH(2).KGHFAHKGIGK(-90).currentSlot.Stack;
			}
			if (BONADPLNEFE >= 8)
			{
				MDAPLEMILBI = false;
				NewTutorialManager.instance.ObjectiveCompleted(0);
			}
		}
		if (!EDEIAFDEMPF && PlayerInventory.FLMDMAOFGMI(-21))
		{
			if (PlayerInventory.NEKDDPIAOBE(0).GetItem(-133) != null)
			{
				DLGMLAADJNO += PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HCCFFBOMLFB(-60).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.GetPlayer(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HCCFFBOMLFB(173) != null)
			{
				DLGMLAADJNO += PlayerInventory.OGKNJNINGMH(7, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GOKIDLOELKB(-130).currentSlot.Stack;
			}
			if (DLGMLAADJNO >= 1)
			{
				EDEIAFDEMPF = true;
				NewTutorialManager.instance.FOIOHOGACAL(0);
			}
		}
		if (EDEIAFDEMPF && MDAPLEMILBI)
		{
			PlayerInventory playerInventory = PlayerInventory.OGKNJNINGMH(0, LAGHIOKLJGH: true);
			playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(JPCGKOFONMP));
			PlayerInventory playerInventory2 = PlayerInventory.NEKDDPIAOBE(5, LAGHIOKLJGH: false, ADPNMHGBFKG: true);
			playerInventory2.OnChanged = (Action)Delegate.Remove(playerInventory2.OnChanged, new Action(OKPOHCNBJAO));
			((MonoBehaviour)this).StartCoroutine(LPCPNKEMCNM());
		}
	}

	private IEnumerator NBENGPAEGCL()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private void CDIMFLEDCDE()
	{
		BONADPLNEFE = 1;
		DLGMLAADJNO = 1;
		if (!MDAPLEMILBI && PlayerInventory.AnyPlayerHasItem(-173))
		{
			if (PlayerInventory.GetPlayer(0, LAGHIOKLJGH: true).KCCHMLKIFNJ(-69) != null)
			{
				BONADPLNEFE += PlayerInventory.OGKNJNINGMH(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HCCFFBOMLFB(-43).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.NEKDDPIAOBE(6, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HCCFFBOMLFB(121) != null)
			{
				BONADPLNEFE += PlayerInventory.EIFPKCAFDIB(6).KCCHMLKIFNJ(-83).currentSlot.Stack;
			}
			if (BONADPLNEFE >= 1)
			{
				MDAPLEMILBI = true;
				NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			}
		}
		if (!EDEIAFDEMPF && PlayerInventory.FLMDMAOFGMI(-102))
		{
			if (PlayerInventory.OGKNJNINGMH(1).GOKIDLOELKB(73) != null)
			{
				DLGMLAADJNO += PlayerInventory.GetPlayer(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HCCFFBOMLFB(-148).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.OGKNJNINGMH(4, LAGHIOKLJGH: false, ADPNMHGBFKG: true).KCCHMLKIFNJ(68) != null)
			{
				DLGMLAADJNO += PlayerInventory.EIFPKCAFDIB(6).KCCHMLKIFNJ(-114).currentSlot.Stack;
			}
			if (DLGMLAADJNO >= 6)
			{
				EDEIAFDEMPF = true;
				NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			}
		}
		if (EDEIAFDEMPF && MDAPLEMILBI)
		{
			PlayerInventory playerInventory = PlayerInventory.NEKDDPIAOBE(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
			playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(FACLDCEIJOK));
			PlayerInventory playerInventory2 = PlayerInventory.EIFPKCAFDIB(7);
			playerInventory2.OnChanged = (Action)Delegate.Remove(playerInventory2.OnChanged, new Action(LIMJMIEMOMC));
			((MonoBehaviour)this).StartCoroutine(NBENGPAEGCL());
		}
	}

	private void JIJHFAGOHBD()
	{
		BONADPLNEFE = 0;
		DLGMLAADJNO = 0;
		if (!MDAPLEMILBI && PlayerInventory.AnyPlayerHasItem(1041))
		{
			if (PlayerInventory.GetPlayer(1).GetItem(1041) != null)
			{
				BONADPLNEFE += PlayerInventory.GetPlayer(1).GetItem(1041).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.GetPlayer(2).GetItem(1041) != null)
			{
				BONADPLNEFE += PlayerInventory.GetPlayer(2).GetItem(1041).currentSlot.Stack;
			}
			if (BONADPLNEFE >= 5)
			{
				MDAPLEMILBI = true;
				NewTutorialManager.instance.ObjectiveCompleted(0);
			}
		}
		if (!EDEIAFDEMPF && PlayerInventory.AnyPlayerHasItem(1055))
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
				EDEIAFDEMPF = true;
				NewTutorialManager.instance.ObjectiveCompleted(1);
			}
		}
		if (EDEIAFDEMPF && MDAPLEMILBI)
		{
			PlayerInventory player = PlayerInventory.GetPlayer(1);
			player.OnChanged = (Action)Delegate.Remove(player.OnChanged, new Action(JIJHFAGOHBD));
			PlayerInventory player2 = PlayerInventory.GetPlayer(2);
			player2.OnChanged = (Action)Delegate.Remove(player2.OnChanged, new Action(JIJHFAGOHBD));
			((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
		}
	}

	private IEnumerator JDEDKABEHJM()
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
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T125/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		PlayerInventory player = PlayerInventory.GetPlayer(1);
		player.OnChanged = (Action)Delegate.Combine(player.OnChanged, new Action(JIJHFAGOHBD));
		PlayerInventory player2 = PlayerInventory.GetPlayer(2);
		player2.OnChanged = (Action)Delegate.Combine(player2.OnChanged, new Action(JIJHFAGOHBD));
	}

	private IEnumerator ELNHMAPENDB()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private void OCAGMHAFHEN()
	{
		BONADPLNEFE = 1;
		DLGMLAADJNO = 1;
		if (!MDAPLEMILBI && PlayerInventory.AnyPlayerHasItem(-101))
		{
			if (PlayerInventory.EIFPKCAFDIB(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HCCFFBOMLFB(-97) != null)
			{
				BONADPLNEFE += PlayerInventory.NEKDDPIAOBE(0, LAGHIOKLJGH: true).GOKIDLOELKB(-88).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.EIFPKCAFDIB(4, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GOKIDLOELKB(-50) != null)
			{
				BONADPLNEFE += PlayerInventory.NEKDDPIAOBE(7).KGHFAHKGIGK(-122).currentSlot.Stack;
			}
			if (BONADPLNEFE >= 7)
			{
				MDAPLEMILBI = true;
				NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			}
		}
		if (!EDEIAFDEMPF && PlayerInventory.AnyPlayerHasItem(46))
		{
			if (PlayerInventory.EIFPKCAFDIB(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HCCFFBOMLFB(62) != null)
			{
				DLGMLAADJNO += PlayerInventory.GetPlayer(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GOKIDLOELKB(103).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.GetPlayer(3).GOKIDLOELKB(5) != null)
			{
				DLGMLAADJNO += PlayerInventory.OGKNJNINGMH(8).GOKIDLOELKB(60).currentSlot.Stack;
			}
			if (DLGMLAADJNO >= 3)
			{
				EDEIAFDEMPF = false;
				NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			}
		}
		if (EDEIAFDEMPF && MDAPLEMILBI)
		{
			PlayerInventory player = PlayerInventory.GetPlayer(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true);
			player.OnChanged = (Action)Delegate.Remove(player.OnChanged, new Action(CMFECLCAICJ));
			PlayerInventory playerInventory = PlayerInventory.NEKDDPIAOBE(2, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
			playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(LIMJMIEMOMC));
			((MonoBehaviour)this).StartCoroutine(NHPCNDODFAK());
		}
	}

	private IEnumerator GEFGNPHFAHG()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator JKLDKCKPFBJ()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator OOFDOHFANIE()
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
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T125/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		PlayerInventory player = PlayerInventory.GetPlayer(1);
		player.OnChanged = (Action)Delegate.Combine(player.OnChanged, new Action(JIJHFAGOHBD));
		PlayerInventory player2 = PlayerInventory.GetPlayer(2);
		player2.OnChanged = (Action)Delegate.Combine(player2.OnChanged, new Action(JIJHFAGOHBD));
	}

	private IEnumerator FPIHNICAJHI()
	{
		return new PCDGAFFFPGD(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator PDAEFKAMACE()
	{
		return new LLABKJKCFJN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LPCPNKEMCNM()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator HNFCACDCBBO()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator NIKPIBICOPP()
	{
		return new PCDGAFFFPGD(1)
		{
			_003C_003E4__this = this
		};
	}

	private void LIMJMIEMOMC()
	{
		BONADPLNEFE = 1;
		DLGMLAADJNO = 0;
		if (!MDAPLEMILBI && PlayerInventory.FKPAJKAGHIK(37))
		{
			if (PlayerInventory.EIFPKCAFDIB(0).GOKIDLOELKB(171) != null)
			{
				BONADPLNEFE += PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GetItem(-20).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.GetPlayer(2, LAGHIOKLJGH: true, ADPNMHGBFKG: true).KGHFAHKGIGK(-95) != null)
			{
				BONADPLNEFE += PlayerInventory.EIFPKCAFDIB(3, LAGHIOKLJGH: true).GetItem(155).currentSlot.Stack;
			}
			if (BONADPLNEFE >= 0)
			{
				MDAPLEMILBI = true;
				NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			}
		}
		if (!EDEIAFDEMPF && PlayerInventory.FLMDMAOFGMI(-171))
		{
			if (PlayerInventory.NEKDDPIAOBE(0, LAGHIOKLJGH: true).KCCHMLKIFNJ(-152) != null)
			{
				DLGMLAADJNO += PlayerInventory.EIFPKCAFDIB(1).GOKIDLOELKB(-128).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.OGKNJNINGMH(6, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GetItem(-166) != null)
			{
				DLGMLAADJNO += PlayerInventory.NEKDDPIAOBE(8, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GetItem(29).currentSlot.Stack;
			}
			if (DLGMLAADJNO >= 3)
			{
				EDEIAFDEMPF = false;
				NewTutorialManager.instance.ObjectiveCompleted(0);
			}
		}
		if (EDEIAFDEMPF && MDAPLEMILBI)
		{
			PlayerInventory playerInventory = PlayerInventory.EIFPKCAFDIB(1);
			playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(LBFPICDLEMM));
			PlayerInventory playerInventory2 = PlayerInventory.OGKNJNINGMH(8, LAGHIOKLJGH: true);
			playerInventory2.OnChanged = (Action)Delegate.Remove(playerInventory2.OnChanged, new Action(MDPEMJCLGIN));
			((MonoBehaviour)this).StartCoroutine(COMPHHHBLIO());
		}
	}

	private IEnumerator EHDIMBMCIDK()
	{
		return new PCDGAFFFPGD(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AAOCEAKDPDK()
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
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T125/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		PlayerInventory player = PlayerInventory.GetPlayer(1);
		player.OnChanged = (Action)Delegate.Combine(player.OnChanged, new Action(JIJHFAGOHBD));
		PlayerInventory player2 = PlayerInventory.GetPlayer(2);
		player2.OnChanged = (Action)Delegate.Combine(player2.OnChanged, new Action(JIJHFAGOHBD));
	}

	private void OJMNOCEKBEF()
	{
		BONADPLNEFE = 0;
		DLGMLAADJNO = 1;
		if (!MDAPLEMILBI && PlayerInventory.FLMDMAOFGMI(-40))
		{
			if (PlayerInventory.NEKDDPIAOBE(1).GOKIDLOELKB(-28) != null)
			{
				BONADPLNEFE += PlayerInventory.OGKNJNINGMH(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GOKIDLOELKB(-135).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.GetPlayer(0, LAGHIOKLJGH: true).HCCFFBOMLFB(-63) != null)
			{
				BONADPLNEFE += PlayerInventory.OGKNJNINGMH(3, LAGHIOKLJGH: true).GOKIDLOELKB(79).currentSlot.Stack;
			}
			if (BONADPLNEFE >= 0)
			{
				MDAPLEMILBI = true;
				NewTutorialManager.instance.ObjectiveCompleted(1);
			}
		}
		if (!EDEIAFDEMPF && PlayerInventory.FLMDMAOFGMI(-102))
		{
			if (PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GOKIDLOELKB(-131) != null)
			{
				DLGMLAADJNO += PlayerInventory.GetPlayer(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HCCFFBOMLFB(-97).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.GetPlayer(0, LAGHIOKLJGH: true).KCCHMLKIFNJ(92) != null)
			{
				DLGMLAADJNO += PlayerInventory.EIFPKCAFDIB(2, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GOKIDLOELKB(15).currentSlot.Stack;
			}
			if (DLGMLAADJNO >= 6)
			{
				EDEIAFDEMPF = false;
				NewTutorialManager.instance.FOIOHOGACAL(0);
			}
		}
		if (EDEIAFDEMPF && MDAPLEMILBI)
		{
			PlayerInventory playerInventory = PlayerInventory.OGKNJNINGMH(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true);
			playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(NIAGKLOPNMD));
			PlayerInventory playerInventory2 = PlayerInventory.OGKNJNINGMH(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
			playerInventory2.OnChanged = (Action)Delegate.Remove(playerInventory2.OnChanged, new Action(CDIMFLEDCDE));
			((MonoBehaviour)this).StartCoroutine(NBENGPAEGCL());
		}
	}

	private void JAGMPBIEIIO()
	{
		BONADPLNEFE = 1;
		DLGMLAADJNO = 1;
		if (!MDAPLEMILBI && PlayerInventory.FLMDMAOFGMI(125))
		{
			if (PlayerInventory.NEKDDPIAOBE(1).KGHFAHKGIGK(-38) != null)
			{
				BONADPLNEFE += PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).KCCHMLKIFNJ(191).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.EIFPKCAFDIB(4, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HCCFFBOMLFB(-145) != null)
			{
				BONADPLNEFE += PlayerInventory.OGKNJNINGMH(5, LAGHIOKLJGH: false, ADPNMHGBFKG: true).KCCHMLKIFNJ(4).currentSlot.Stack;
			}
			if (BONADPLNEFE >= 0)
			{
				MDAPLEMILBI = false;
				NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			}
		}
		if (!EDEIAFDEMPF && PlayerInventory.FLMDMAOFGMI(-40))
		{
			if (PlayerInventory.NEKDDPIAOBE(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).KGHFAHKGIGK(182) != null)
			{
				DLGMLAADJNO += PlayerInventory.GetPlayer(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).KCCHMLKIFNJ(6).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.OGKNJNINGMH(7, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetItem(8) != null)
			{
				DLGMLAADJNO += PlayerInventory.EIFPKCAFDIB(4, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetItem(-43).currentSlot.Stack;
			}
			if (DLGMLAADJNO >= 0)
			{
				EDEIAFDEMPF = true;
				NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			}
		}
		if (EDEIAFDEMPF && MDAPLEMILBI)
		{
			PlayerInventory playerInventory = PlayerInventory.OGKNJNINGMH(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true);
			playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(DPJKDAEELAH));
			PlayerInventory playerInventory2 = PlayerInventory.NEKDDPIAOBE(6);
			playerInventory2.OnChanged = (Action)Delegate.Remove(playerInventory2.OnChanged, new Action(JIJHFAGOHBD));
			((MonoBehaviour)this).StartCoroutine(GLLMLANGBOJ());
		}
	}

	private IEnumerator ELPDKDFFJJD()
	{
		return new PCDGAFFFPGD(1)
		{
			_003C_003E4__this = this
		};
	}

	private void AOMNMOFFILB()
	{
		BONADPLNEFE = 0;
		DLGMLAADJNO = 0;
		if (!MDAPLEMILBI && PlayerInventory.AnyPlayerHasItem(-185))
		{
			if (PlayerInventory.EIFPKCAFDIB(0).HCCFFBOMLFB(-55) != null)
			{
				BONADPLNEFE += PlayerInventory.EIFPKCAFDIB(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetItem(-37).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.GetPlayer(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GOKIDLOELKB(59) != null)
			{
				BONADPLNEFE += PlayerInventory.NEKDDPIAOBE(4, LAGHIOKLJGH: false, ADPNMHGBFKG: true).KGHFAHKGIGK(60).currentSlot.Stack;
			}
			if (BONADPLNEFE >= 8)
			{
				MDAPLEMILBI = false;
				NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			}
		}
		if (!EDEIAFDEMPF && PlayerInventory.FKPAJKAGHIK(87))
		{
			if (PlayerInventory.NEKDDPIAOBE(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).KGHFAHKGIGK(150) != null)
			{
				DLGMLAADJNO += PlayerInventory.GetPlayer(1, LAGHIOKLJGH: true).KCCHMLKIFNJ(-196).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.OGKNJNINGMH(6, LAGHIOKLJGH: false, ADPNMHGBFKG: true).KGHFAHKGIGK(-126) != null)
			{
				DLGMLAADJNO += PlayerInventory.NEKDDPIAOBE(5, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HCCFFBOMLFB(-105).currentSlot.Stack;
			}
			if (DLGMLAADJNO >= 3)
			{
				EDEIAFDEMPF = true;
				NewTutorialManager.instance.FOIOHOGACAL(1);
			}
		}
		if (EDEIAFDEMPF && MDAPLEMILBI)
		{
			PlayerInventory playerInventory = PlayerInventory.OGKNJNINGMH(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
			playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(DPJKDAEELAH));
			PlayerInventory playerInventory2 = PlayerInventory.OGKNJNINGMH(7);
			playerInventory2.OnChanged = (Action)Delegate.Remove(playerInventory2.OnChanged, new Action(MDPEMJCLGIN));
			((MonoBehaviour)this).StartCoroutine(MPJMCMIMHFC());
		}
	}

	private void ANJLLPFAPNI()
	{
		BONADPLNEFE = 1;
		DLGMLAADJNO = 1;
		if (!MDAPLEMILBI && PlayerInventory.FKPAJKAGHIK(-187))
		{
			if (PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetItem(69) != null)
			{
				BONADPLNEFE += PlayerInventory.NEKDDPIAOBE(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).KCCHMLKIFNJ(6).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: true).GOKIDLOELKB(191) != null)
			{
				BONADPLNEFE += PlayerInventory.OGKNJNINGMH(7, LAGHIOKLJGH: true).GetItem(-9).currentSlot.Stack;
			}
			if (BONADPLNEFE >= 5)
			{
				MDAPLEMILBI = false;
				NewTutorialManager.instance.FOIOHOGACAL(0);
			}
		}
		if (!EDEIAFDEMPF && PlayerInventory.AnyPlayerHasItem(-9))
		{
			if (PlayerInventory.NEKDDPIAOBE(0, LAGHIOKLJGH: true).KGHFAHKGIGK(18) != null)
			{
				DLGMLAADJNO += PlayerInventory.NEKDDPIAOBE(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HCCFFBOMLFB(41).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.GetPlayer(1).KCCHMLKIFNJ(54) != null)
			{
				DLGMLAADJNO += PlayerInventory.OGKNJNINGMH(7).GOKIDLOELKB(191).currentSlot.Stack;
			}
			if (DLGMLAADJNO >= 2)
			{
				EDEIAFDEMPF = true;
				NewTutorialManager.instance.FOIOHOGACAL(0);
			}
		}
		if (EDEIAFDEMPF && MDAPLEMILBI)
		{
			PlayerInventory playerInventory = PlayerInventory.OGKNJNINGMH(0, LAGHIOKLJGH: true);
			playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(OBGFBFLFLGO));
			PlayerInventory playerInventory2 = PlayerInventory.OGKNJNINGMH(7);
			playerInventory2.OnChanged = (Action)Delegate.Remove(playerInventory2.OnChanged, new Action(OCAGMHAFHEN));
			((MonoBehaviour)this).StartCoroutine(NHPCNDODFAK());
		}
	}

	private void OBGFBFLFLGO()
	{
		BONADPLNEFE = 1;
		DLGMLAADJNO = 1;
		if (!MDAPLEMILBI && PlayerInventory.AnyPlayerHasItem(-126))
		{
			if (PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).KCCHMLKIFNJ(-63) != null)
			{
				BONADPLNEFE += PlayerInventory.EIFPKCAFDIB(0, LAGHIOKLJGH: true).KCCHMLKIFNJ(-128).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.GetPlayer(8, LAGHIOKLJGH: true).GetItem(68) != null)
			{
				BONADPLNEFE += PlayerInventory.NEKDDPIAOBE(4, LAGHIOKLJGH: false, ADPNMHGBFKG: true).KGHFAHKGIGK(-116).currentSlot.Stack;
			}
			if (BONADPLNEFE >= 4)
			{
				MDAPLEMILBI = false;
				NewTutorialManager.instance.FOIOHOGACAL(1);
			}
		}
		if (!EDEIAFDEMPF && PlayerInventory.AnyPlayerHasItem(179))
		{
			if (PlayerInventory.OGKNJNINGMH(1, LAGHIOKLJGH: true).GOKIDLOELKB(11) != null)
			{
				DLGMLAADJNO += PlayerInventory.GetPlayer(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).KCCHMLKIFNJ(142).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.GetPlayer(3).HCCFFBOMLFB(-4) != null)
			{
				DLGMLAADJNO += PlayerInventory.EIFPKCAFDIB(8, LAGHIOKLJGH: true, ADPNMHGBFKG: true).KGHFAHKGIGK(-37).currentSlot.Stack;
			}
			if (DLGMLAADJNO >= 8)
			{
				EDEIAFDEMPF = true;
				NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			}
		}
		if (EDEIAFDEMPF && MDAPLEMILBI)
		{
			PlayerInventory playerInventory = PlayerInventory.OGKNJNINGMH(0);
			playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(OBGFBFLFLGO));
			PlayerInventory playerInventory2 = PlayerInventory.NEKDDPIAOBE(2, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
			playerInventory2.OnChanged = (Action)Delegate.Remove(playerInventory2.OnChanged, new Action(JIJHFAGOHBD));
			((MonoBehaviour)this).StartCoroutine(COMPHHHBLIO());
		}
	}

	private IEnumerator JAKPMNEGELN()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator CFCMKAPFPCE()
	{
		return new LLABKJKCFJN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator KGIJEMPBBED()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private void OKPOHCNBJAO()
	{
		BONADPLNEFE = 1;
		DLGMLAADJNO = 0;
		if (!MDAPLEMILBI && PlayerInventory.FKPAJKAGHIK(110))
		{
			if (PlayerInventory.OGKNJNINGMH(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).KGHFAHKGIGK(60) != null)
			{
				BONADPLNEFE += PlayerInventory.EIFPKCAFDIB(1).GOKIDLOELKB(100).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.EIFPKCAFDIB(5, LAGHIOKLJGH: true).KCCHMLKIFNJ(46) != null)
			{
				BONADPLNEFE += PlayerInventory.GetPlayer(6, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GOKIDLOELKB(-181).currentSlot.Stack;
			}
			if (BONADPLNEFE >= 8)
			{
				MDAPLEMILBI = true;
				NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			}
		}
		if (!EDEIAFDEMPF && PlayerInventory.AnyPlayerHasItem(45))
		{
			if (PlayerInventory.GetPlayer(1).GetItem(63) != null)
			{
				DLGMLAADJNO += PlayerInventory.OGKNJNINGMH(0, LAGHIOKLJGH: true).KCCHMLKIFNJ(82).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.GetPlayer(6).GOKIDLOELKB(-195) != null)
			{
				DLGMLAADJNO += PlayerInventory.EIFPKCAFDIB(6, LAGHIOKLJGH: true, ADPNMHGBFKG: true).KCCHMLKIFNJ(-103).currentSlot.Stack;
			}
			if (DLGMLAADJNO >= 3)
			{
				EDEIAFDEMPF = false;
				NewTutorialManager.instance.FOIOHOGACAL(1);
			}
		}
		if (EDEIAFDEMPF && MDAPLEMILBI)
		{
			PlayerInventory player = PlayerInventory.GetPlayer(0);
			player.OnChanged = (Action)Delegate.Remove(player.OnChanged, new Action(DPJKDAEELAH));
			PlayerInventory player2 = PlayerInventory.GetPlayer(7, LAGHIOKLJGH: false, ADPNMHGBFKG: true);
			player2.OnChanged = (Action)Delegate.Remove(player2.OnChanged, new Action(BHGKDFFGPIK));
			((MonoBehaviour)this).StartCoroutine(GGACDGHOJEF());
		}
	}

	private IEnumerator AAGGGIONDAG()
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
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T125/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		PlayerInventory player = PlayerInventory.GetPlayer(1);
		player.OnChanged = (Action)Delegate.Combine(player.OnChanged, new Action(JIJHFAGOHBD));
		PlayerInventory player2 = PlayerInventory.GetPlayer(2);
		player2.OnChanged = (Action)Delegate.Combine(player2.OnChanged, new Action(JIJHFAGOHBD));
	}

	private IEnumerator CAKPGBAIIPI()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private void GGINDBNHPKF()
	{
		BONADPLNEFE = 0;
		DLGMLAADJNO = 1;
		if (!MDAPLEMILBI && PlayerInventory.FLMDMAOFGMI(79))
		{
			if (PlayerInventory.NEKDDPIAOBE(1, LAGHIOKLJGH: true).GOKIDLOELKB(-168) != null)
			{
				BONADPLNEFE += PlayerInventory.NEKDDPIAOBE(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GOKIDLOELKB(82).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.OGKNJNINGMH(2, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetItem(-56) != null)
			{
				BONADPLNEFE += PlayerInventory.OGKNJNINGMH(7, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HCCFFBOMLFB(-77).currentSlot.Stack;
			}
			if (BONADPLNEFE >= 8)
			{
				MDAPLEMILBI = true;
				NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			}
		}
		if (!EDEIAFDEMPF && PlayerInventory.FLMDMAOFGMI(-116))
		{
			if (PlayerInventory.GetPlayer(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetItem(-187) != null)
			{
				DLGMLAADJNO += PlayerInventory.GetPlayer(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).KGHFAHKGIGK(-49).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.NEKDDPIAOBE(8, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GetItem(156) != null)
			{
				DLGMLAADJNO += PlayerInventory.OGKNJNINGMH(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HCCFFBOMLFB(183).currentSlot.Stack;
			}
			if (DLGMLAADJNO >= 4)
			{
				EDEIAFDEMPF = true;
				NewTutorialManager.instance.ObjectiveCompleted(0);
			}
		}
		if (EDEIAFDEMPF && MDAPLEMILBI)
		{
			PlayerInventory playerInventory = PlayerInventory.OGKNJNINGMH(1);
			playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(CMFECLCAICJ));
			PlayerInventory playerInventory2 = PlayerInventory.EIFPKCAFDIB(3, LAGHIOKLJGH: false, ADPNMHGBFKG: true);
			playerInventory2.OnChanged = (Action)Delegate.Remove(playerInventory2.OnChanged, new Action(OKPOHCNBJAO));
			((MonoBehaviour)this).StartCoroutine(JKLDKCKPFBJ());
		}
	}

	private void IBJGPMNDEMM()
	{
		BONADPLNEFE = 1;
		DLGMLAADJNO = 0;
		if (!MDAPLEMILBI && PlayerInventory.FKPAJKAGHIK(-61))
		{
			if (PlayerInventory.GetPlayer(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).KCCHMLKIFNJ(62) != null)
			{
				BONADPLNEFE += PlayerInventory.NEKDDPIAOBE(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GOKIDLOELKB(123).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.GetPlayer(7, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetItem(83) != null)
			{
				BONADPLNEFE += PlayerInventory.GetPlayer(4, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GOKIDLOELKB(140).currentSlot.Stack;
			}
			if (BONADPLNEFE >= 0)
			{
				MDAPLEMILBI = false;
				NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			}
		}
		if (!EDEIAFDEMPF && PlayerInventory.FLMDMAOFGMI(-99))
		{
			if (PlayerInventory.GetPlayer(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HCCFFBOMLFB(-35) != null)
			{
				DLGMLAADJNO += PlayerInventory.NEKDDPIAOBE(0).GetItem(-104).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.OGKNJNINGMH(6, LAGHIOKLJGH: true).GOKIDLOELKB(-171) != null)
			{
				DLGMLAADJNO += PlayerInventory.OGKNJNINGMH(7, LAGHIOKLJGH: true).KGHFAHKGIGK(60).currentSlot.Stack;
			}
			if (DLGMLAADJNO >= 4)
			{
				EDEIAFDEMPF = false;
				NewTutorialManager.instance.ObjectiveCompleted(0);
			}
		}
		if (EDEIAFDEMPF && MDAPLEMILBI)
		{
			PlayerInventory playerInventory = PlayerInventory.OGKNJNINGMH(1);
			playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(OKPOHCNBJAO));
			PlayerInventory playerInventory2 = PlayerInventory.EIFPKCAFDIB(7, LAGHIOKLJGH: true);
			playerInventory2.OnChanged = (Action)Delegate.Remove(playerInventory2.OnChanged, new Action(CMFECLCAICJ));
			((MonoBehaviour)this).StartCoroutine(LPCPNKEMCNM());
		}
	}

	private IEnumerator CFGLAPAKKAL()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator MGHHGMLMMJC()
	{
		return new LLABKJKCFJN(1)
		{
			_003C_003E4__this = this
		};
	}

	public override int GetID()
	{
		return 125;
	}

	private void ALAJOLFIMME()
	{
		BONADPLNEFE = 1;
		DLGMLAADJNO = 0;
		if (!MDAPLEMILBI && PlayerInventory.FKPAJKAGHIK(10))
		{
			if (PlayerInventory.NEKDDPIAOBE(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).KCCHMLKIFNJ(-194) != null)
			{
				BONADPLNEFE += PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: true).KCCHMLKIFNJ(-97).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.OGKNJNINGMH(4, LAGHIOKLJGH: true, ADPNMHGBFKG: true).KGHFAHKGIGK(118) != null)
			{
				BONADPLNEFE += PlayerInventory.GetPlayer(7, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetItem(-52).currentSlot.Stack;
			}
			if (BONADPLNEFE >= 6)
			{
				MDAPLEMILBI = true;
				NewTutorialManager.instance.ObjectiveCompleted(1);
			}
		}
		if (!EDEIAFDEMPF && PlayerInventory.AnyPlayerHasItem(-126))
		{
			if (PlayerInventory.NEKDDPIAOBE(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).KGHFAHKGIGK(-122) != null)
			{
				DLGMLAADJNO += PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HCCFFBOMLFB(-8).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.OGKNJNINGMH(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).KGHFAHKGIGK(-135) != null)
			{
				DLGMLAADJNO += PlayerInventory.NEKDDPIAOBE(5).GetItem(-179).currentSlot.Stack;
			}
			if (DLGMLAADJNO >= 6)
			{
				EDEIAFDEMPF = false;
				NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			}
		}
		if (EDEIAFDEMPF && MDAPLEMILBI)
		{
			PlayerInventory playerInventory = PlayerInventory.OGKNJNINGMH(1, LAGHIOKLJGH: true);
			playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(NDDCDLOEDIC));
			PlayerInventory playerInventory2 = PlayerInventory.OGKNJNINGMH(8, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
			playerInventory2.OnChanged = (Action)Delegate.Remove(playerInventory2.OnChanged, new Action(BHGKDFFGPIK));
			((MonoBehaviour)this).StartCoroutine(LAMBONHALKD());
		}
	}

	private void GKBGHBKHEMO()
	{
		BONADPLNEFE = 1;
		DLGMLAADJNO = 1;
		if (!MDAPLEMILBI && PlayerInventory.FLMDMAOFGMI(165))
		{
			if (PlayerInventory.NEKDDPIAOBE(0).KCCHMLKIFNJ(-22) != null)
			{
				BONADPLNEFE += PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: true).KGHFAHKGIGK(-26).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.OGKNJNINGMH(0, LAGHIOKLJGH: true).HCCFFBOMLFB(-117) != null)
			{
				BONADPLNEFE += PlayerInventory.GetPlayer(7, LAGHIOKLJGH: true).KGHFAHKGIGK(-55).currentSlot.Stack;
			}
			if (BONADPLNEFE >= 4)
			{
				MDAPLEMILBI = true;
				NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			}
		}
		if (!EDEIAFDEMPF && PlayerInventory.FKPAJKAGHIK(178))
		{
			if (PlayerInventory.NEKDDPIAOBE(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GetItem(184) != null)
			{
				DLGMLAADJNO += PlayerInventory.EIFPKCAFDIB(0, LAGHIOKLJGH: true).GetItem(-25).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.NEKDDPIAOBE(1).KGHFAHKGIGK(76) != null)
			{
				DLGMLAADJNO += PlayerInventory.GetPlayer(4, LAGHIOKLJGH: true, ADPNMHGBFKG: true).KCCHMLKIFNJ(70).currentSlot.Stack;
			}
			if (DLGMLAADJNO >= 3)
			{
				EDEIAFDEMPF = true;
				NewTutorialManager.instance.ObjectiveCompleted(0);
			}
		}
		if (EDEIAFDEMPF && MDAPLEMILBI)
		{
			PlayerInventory playerInventory = PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
			playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(OJMNOCEKBEF));
			PlayerInventory playerInventory2 = PlayerInventory.EIFPKCAFDIB(6, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
			playerInventory2.OnChanged = (Action)Delegate.Remove(playerInventory2.OnChanged, new Action(OKPOHCNBJAO));
			((MonoBehaviour)this).StartCoroutine(CAKPGBAIIPI());
		}
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
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T125/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		PlayerInventory player = PlayerInventory.GetPlayer(1);
		player.OnChanged = (Action)Delegate.Combine(player.OnChanged, new Action(JIJHFAGOHBD));
		PlayerInventory player2 = PlayerInventory.GetPlayer(2);
		player2.OnChanged = (Action)Delegate.Combine(player2.OnChanged, new Action(JIJHFAGOHBD));
	}

	private IEnumerator KNBNIMCHKIE()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private void NACPKNPIGGF()
	{
		BONADPLNEFE = 0;
		DLGMLAADJNO = 1;
		if (!MDAPLEMILBI && PlayerInventory.FLMDMAOFGMI(82))
		{
			if (PlayerInventory.OGKNJNINGMH(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).KGHFAHKGIGK(189) != null)
			{
				BONADPLNEFE += PlayerInventory.GetPlayer(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).KCCHMLKIFNJ(-43).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.GetPlayer(6, LAGHIOKLJGH: true).HCCFFBOMLFB(-77) != null)
			{
				BONADPLNEFE += PlayerInventory.NEKDDPIAOBE(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).KCCHMLKIFNJ(183).currentSlot.Stack;
			}
			if (BONADPLNEFE >= 1)
			{
				MDAPLEMILBI = true;
				NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			}
		}
		if (!EDEIAFDEMPF && PlayerInventory.FLMDMAOFGMI(-40))
		{
			if (PlayerInventory.GetPlayer(0).GOKIDLOELKB(-39) != null)
			{
				DLGMLAADJNO += PlayerInventory.NEKDDPIAOBE(1).GetItem(-151).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.NEKDDPIAOBE(5, LAGHIOKLJGH: true, ADPNMHGBFKG: true).KGHFAHKGIGK(131) != null)
			{
				DLGMLAADJNO += PlayerInventory.GetPlayer(8, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetItem(-17).currentSlot.Stack;
			}
			if (DLGMLAADJNO >= 5)
			{
				EDEIAFDEMPF = false;
				NewTutorialManager.instance.ObjectiveCompleted(1);
			}
		}
		if (EDEIAFDEMPF && MDAPLEMILBI)
		{
			PlayerInventory playerInventory = PlayerInventory.OGKNJNINGMH(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
			playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(NDDCDLOEDIC));
			PlayerInventory playerInventory2 = PlayerInventory.OGKNJNINGMH(0, LAGHIOKLJGH: true);
			playerInventory2.OnChanged = (Action)Delegate.Remove(playerInventory2.OnChanged, new Action(NLABJPMFIGB));
			((MonoBehaviour)this).StartCoroutine(CFCMKAPFPCE());
		}
	}

	private void NDDCDLOEDIC()
	{
		BONADPLNEFE = 0;
		DLGMLAADJNO = 0;
		if (!MDAPLEMILBI && PlayerInventory.FLMDMAOFGMI(-46))
		{
			if (PlayerInventory.EIFPKCAFDIB(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).KGHFAHKGIGK(-164) != null)
			{
				BONADPLNEFE += PlayerInventory.EIFPKCAFDIB(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HCCFFBOMLFB(31).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.EIFPKCAFDIB(3, LAGHIOKLJGH: true).GetItem(48) != null)
			{
				BONADPLNEFE += PlayerInventory.NEKDDPIAOBE(5, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GetItem(12).currentSlot.Stack;
			}
			if (BONADPLNEFE >= 4)
			{
				MDAPLEMILBI = false;
				NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			}
		}
		if (!EDEIAFDEMPF && PlayerInventory.FKPAJKAGHIK(160))
		{
			if (PlayerInventory.NEKDDPIAOBE(1).HCCFFBOMLFB(-137) != null)
			{
				DLGMLAADJNO += PlayerInventory.EIFPKCAFDIB(0).GetItem(-194).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.OGKNJNINGMH(4, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HCCFFBOMLFB(-116) != null)
			{
				DLGMLAADJNO += PlayerInventory.GetPlayer(1).KGHFAHKGIGK(-119).currentSlot.Stack;
			}
			if (DLGMLAADJNO >= 6)
			{
				EDEIAFDEMPF = false;
				NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			}
		}
		if (EDEIAFDEMPF && MDAPLEMILBI)
		{
			PlayerInventory playerInventory = PlayerInventory.NEKDDPIAOBE(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
			playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(NACPKNPIGGF));
			PlayerInventory playerInventory2 = PlayerInventory.NEKDDPIAOBE(8, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
			playerInventory2.OnChanged = (Action)Delegate.Remove(playerInventory2.OnChanged, new Action(NACPKNPIGGF));
			((MonoBehaviour)this).StartCoroutine(BOMICOPCCML());
		}
	}

	private IEnumerator MJKLEEHELIH()
	{
		return new LLABKJKCFJN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator MFFGIOALMIC()
	{
		return new PCDGAFFFPGD(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AEMAMJOHIOA()
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
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T125/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		PlayerInventory player = PlayerInventory.GetPlayer(1);
		player.OnChanged = (Action)Delegate.Combine(player.OnChanged, new Action(JIJHFAGOHBD));
		PlayerInventory player2 = PlayerInventory.GetPlayer(2);
		player2.OnChanged = (Action)Delegate.Combine(player2.OnChanged, new Action(JIJHFAGOHBD));
	}

	private void CMFECLCAICJ()
	{
		BONADPLNEFE = 1;
		DLGMLAADJNO = 0;
		if (!MDAPLEMILBI && PlayerInventory.FKPAJKAGHIK(174))
		{
			if (PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GOKIDLOELKB(132) != null)
			{
				BONADPLNEFE += PlayerInventory.EIFPKCAFDIB(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GetItem(-34).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.NEKDDPIAOBE(1, LAGHIOKLJGH: true).GOKIDLOELKB(130) != null)
			{
				BONADPLNEFE += PlayerInventory.GetPlayer(3, LAGHIOKLJGH: true).KGHFAHKGIGK(105).currentSlot.Stack;
			}
			if (BONADPLNEFE >= 4)
			{
				MDAPLEMILBI = true;
				NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			}
		}
		if (!EDEIAFDEMPF && PlayerInventory.AnyPlayerHasItem(75))
		{
			if (PlayerInventory.OGKNJNINGMH(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GOKIDLOELKB(102) != null)
			{
				DLGMLAADJNO += PlayerInventory.GetPlayer(0).KGHFAHKGIGK(-144).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.GetPlayer(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).KCCHMLKIFNJ(121) != null)
			{
				DLGMLAADJNO += PlayerInventory.NEKDDPIAOBE(3).GOKIDLOELKB(-49).currentSlot.Stack;
			}
			if (DLGMLAADJNO >= 3)
			{
				EDEIAFDEMPF = true;
				NewTutorialManager.instance.ObjectiveCompleted(0);
			}
		}
		if (EDEIAFDEMPF && MDAPLEMILBI)
		{
			PlayerInventory playerInventory = PlayerInventory.NEKDDPIAOBE(1);
			playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(FHCHMJGNALM));
			PlayerInventory playerInventory2 = PlayerInventory.EIFPKCAFDIB(7);
			playerInventory2.OnChanged = (Action)Delegate.Remove(playerInventory2.OnChanged, new Action(LBFPICDLEMM));
			((MonoBehaviour)this).StartCoroutine(CAKPGBAIIPI());
		}
	}

	private void PAGPINIKKDL()
	{
		BONADPLNEFE = 0;
		DLGMLAADJNO = 1;
		if (!MDAPLEMILBI && PlayerInventory.AnyPlayerHasItem(-49))
		{
			if (PlayerInventory.NEKDDPIAOBE(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GetItem(82) != null)
			{
				BONADPLNEFE += PlayerInventory.OGKNJNINGMH(0, LAGHIOKLJGH: true).GetItem(149).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.EIFPKCAFDIB(6, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HCCFFBOMLFB(-119) != null)
			{
				BONADPLNEFE += PlayerInventory.NEKDDPIAOBE(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).KCCHMLKIFNJ(-1).currentSlot.Stack;
			}
			if (BONADPLNEFE >= 0)
			{
				MDAPLEMILBI = false;
				NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			}
		}
		if (!EDEIAFDEMPF && PlayerInventory.FLMDMAOFGMI(-58))
		{
			if (PlayerInventory.GetPlayer(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GetItem(117) != null)
			{
				DLGMLAADJNO += PlayerInventory.NEKDDPIAOBE(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).KCCHMLKIFNJ(-126).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.NEKDDPIAOBE(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).KCCHMLKIFNJ(78) != null)
			{
				DLGMLAADJNO += PlayerInventory.OGKNJNINGMH(7).KGHFAHKGIGK(-12).currentSlot.Stack;
			}
			if (DLGMLAADJNO >= 8)
			{
				EDEIAFDEMPF = true;
				NewTutorialManager.instance.ObjectiveCompleted(1);
			}
		}
		if (EDEIAFDEMPF && MDAPLEMILBI)
		{
			PlayerInventory playerInventory = PlayerInventory.NEKDDPIAOBE(1);
			playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(DPJKDAEELAH));
			PlayerInventory playerInventory2 = PlayerInventory.NEKDDPIAOBE(7, LAGHIOKLJGH: true);
			playerInventory2.OnChanged = (Action)Delegate.Remove(playerInventory2.OnChanged, new Action(PJONABBLADP));
			((MonoBehaviour)this).StartCoroutine(MPJMCMIMHFC());
		}
	}

	private void NLABJPMFIGB()
	{
		BONADPLNEFE = 1;
		DLGMLAADJNO = 0;
		if (!MDAPLEMILBI && PlayerInventory.AnyPlayerHasItem(119))
		{
			if (PlayerInventory.OGKNJNINGMH(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GOKIDLOELKB(26) != null)
			{
				BONADPLNEFE += PlayerInventory.OGKNJNINGMH(1, LAGHIOKLJGH: true).HCCFFBOMLFB(-168).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.NEKDDPIAOBE(1).KCCHMLKIFNJ(-126) != null)
			{
				BONADPLNEFE += PlayerInventory.NEKDDPIAOBE(6).HCCFFBOMLFB(-195).currentSlot.Stack;
			}
			if (BONADPLNEFE >= 1)
			{
				MDAPLEMILBI = true;
				NewTutorialManager.instance.ObjectiveCompleted(1);
			}
		}
		if (!EDEIAFDEMPF && PlayerInventory.AnyPlayerHasItem(36))
		{
			if (PlayerInventory.NEKDDPIAOBE(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GetItem(-132) != null)
			{
				DLGMLAADJNO += PlayerInventory.GetPlayer(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HCCFFBOMLFB(3).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.NEKDDPIAOBE(8, LAGHIOKLJGH: true).GOKIDLOELKB(-169) != null)
			{
				DLGMLAADJNO += PlayerInventory.EIFPKCAFDIB(7, LAGHIOKLJGH: true).GOKIDLOELKB(-39).currentSlot.Stack;
			}
			if (DLGMLAADJNO >= 6)
			{
				EDEIAFDEMPF = true;
				NewTutorialManager.instance.ObjectiveCompleted(0);
			}
		}
		if (EDEIAFDEMPF && MDAPLEMILBI)
		{
			PlayerInventory playerInventory = PlayerInventory.OGKNJNINGMH(0);
			playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(PJONABBLADP));
			PlayerInventory player = PlayerInventory.GetPlayer(0, LAGHIOKLJGH: true);
			player.OnChanged = (Action)Delegate.Remove(player.OnChanged, new Action(LIMJMIEMOMC));
			((MonoBehaviour)this).StartCoroutine(GGACDGHOJEF());
		}
	}

	private IEnumerator DABNLFBDKGN()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator CCOGIOADJKC()
	{
		return new PCDGAFFFPGD(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator MLAOLHNEEJC()
	{
		return new PCDGAFFFPGD(1)
		{
			_003C_003E4__this = this
		};
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
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T125/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		PlayerInventory player = PlayerInventory.GetPlayer(1);
		player.OnChanged = (Action)Delegate.Combine(player.OnChanged, new Action(JIJHFAGOHBD));
		PlayerInventory player2 = PlayerInventory.GetPlayer(2);
		player2.OnChanged = (Action)Delegate.Combine(player2.OnChanged, new Action(JIJHFAGOHBD));
	}

	private IEnumerator PAJJMLCLHHK()
	{
		return new LLABKJKCFJN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NDFMAMKPANE()
	{
		return new PCDGAFFFPGD(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator DIGIMPCLCCL()
	{
		return new PCDGAFFFPGD(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator GLLMLANGBOJ()
	{
		return new LLABKJKCFJN(1)
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

	private void DPJKDAEELAH()
	{
		BONADPLNEFE = 1;
		DLGMLAADJNO = 1;
		if (!MDAPLEMILBI && PlayerInventory.FLMDMAOFGMI(56))
		{
			if (PlayerInventory.OGKNJNINGMH(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GOKIDLOELKB(-27) != null)
			{
				BONADPLNEFE += PlayerInventory.NEKDDPIAOBE(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HCCFFBOMLFB(175).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.GetPlayer(2, LAGHIOKLJGH: true).GOKIDLOELKB(133) != null)
			{
				BONADPLNEFE += PlayerInventory.OGKNJNINGMH(7, LAGHIOKLJGH: false, ADPNMHGBFKG: true).KGHFAHKGIGK(101).currentSlot.Stack;
			}
			if (BONADPLNEFE >= 2)
			{
				MDAPLEMILBI = true;
				NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			}
		}
		if (!EDEIAFDEMPF && PlayerInventory.FKPAJKAGHIK(112))
		{
			if (PlayerInventory.EIFPKCAFDIB(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GOKIDLOELKB(-36) != null)
			{
				DLGMLAADJNO += PlayerInventory.EIFPKCAFDIB(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GOKIDLOELKB(41).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.NEKDDPIAOBE(2, LAGHIOKLJGH: false, ADPNMHGBFKG: true).GOKIDLOELKB(3) != null)
			{
				DLGMLAADJNO += PlayerInventory.NEKDDPIAOBE(6).HCCFFBOMLFB(179).currentSlot.Stack;
			}
			if (DLGMLAADJNO >= 3)
			{
				EDEIAFDEMPF = false;
				NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			}
		}
		if (EDEIAFDEMPF && MDAPLEMILBI)
		{
			PlayerInventory player = PlayerInventory.GetPlayer(0, LAGHIOKLJGH: true);
			player.OnChanged = (Action)Delegate.Remove(player.OnChanged, new Action(GKBGHBKHEMO));
			PlayerInventory playerInventory = PlayerInventory.NEKDDPIAOBE(4, LAGHIOKLJGH: true);
			playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(CDIMFLEDCDE));
			((MonoBehaviour)this).StartCoroutine(MGHHGMLMMJC());
		}
	}

	private IEnumerator EFKIBEABCPK()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator KEBCOCFPNIG()
	{
		return new PCDGAFFFPGD(1)
		{
			_003C_003E4__this = this
		};
	}

	private void BHGKDFFGPIK()
	{
		BONADPLNEFE = 1;
		DLGMLAADJNO = 0;
		if (!MDAPLEMILBI && PlayerInventory.FLMDMAOFGMI(-72))
		{
			if (PlayerInventory.GetPlayer(0, LAGHIOKLJGH: true).GOKIDLOELKB(154) != null)
			{
				BONADPLNEFE += PlayerInventory.NEKDDPIAOBE(1, LAGHIOKLJGH: true).KCCHMLKIFNJ(-147).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HCCFFBOMLFB(132) != null)
			{
				BONADPLNEFE += PlayerInventory.OGKNJNINGMH(6, LAGHIOKLJGH: true).HCCFFBOMLFB(-142).currentSlot.Stack;
			}
			if (BONADPLNEFE >= 6)
			{
				MDAPLEMILBI = false;
				NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			}
		}
		if (!EDEIAFDEMPF && PlayerInventory.FKPAJKAGHIK(53))
		{
			if (PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).KCCHMLKIFNJ(-47) != null)
			{
				DLGMLAADJNO += PlayerInventory.NEKDDPIAOBE(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HCCFFBOMLFB(-169).currentSlot.Stack;
			}
			if (GameManager.LocalCoop() && PlayerInventory.EIFPKCAFDIB(6, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HCCFFBOMLFB(127) != null)
			{
				DLGMLAADJNO += PlayerInventory.GetPlayer(6, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GOKIDLOELKB(-128).currentSlot.Stack;
			}
			if (DLGMLAADJNO >= 3)
			{
				EDEIAFDEMPF = false;
				NewTutorialManager.instance.ObjectiveCompleted(0);
			}
		}
		if (EDEIAFDEMPF && MDAPLEMILBI)
		{
			PlayerInventory playerInventory = PlayerInventory.OGKNJNINGMH(1);
			playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(NIAGKLOPNMD));
			PlayerInventory playerInventory2 = PlayerInventory.NEKDDPIAOBE(5, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
			playerInventory2.OnChanged = (Action)Delegate.Remove(playerInventory2.OnChanged, new Action(ALAJOLFIMME));
			((MonoBehaviour)this).StartCoroutine(EFKIBEABCPK());
		}
	}

	private IEnumerator JCKBLHHGOHC()
	{
		return new LLABKJKCFJN(1)
		{
			_003C_003E4__this = this
		};
	}
}
