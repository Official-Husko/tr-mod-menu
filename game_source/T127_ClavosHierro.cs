using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class T127_ClavosHierro : TutorialPhaseBase
{
	[CompilerGenerated]
	private sealed class JILLIBJGIIK : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T127_ClavosHierro _003C_003E4__this;

		private bool _003CstoneStationFound_003E5__2;

		private int _003Ci_003E5__3;

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
		public JILLIBJGIIK(int _003C_003E1__state)
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
			T127_ClavosHierro t127_ClavosHierro = _003C_003E4__this;
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
			{
				_003C_003E1__state = -1;
				NewTutorialManager instance = NewTutorialManager.instance;
				instance.ObjectivesUpdated = (Action)Delegate.Remove(instance.ObjectivesUpdated, new Action(t127_ClavosHierro.EFCMMONCGCP));
				_003CstoneStationFound_003E5__2 = false;
				_003Ci_003E5__3 = 0;
				goto IL_0149;
			}
			case 2:
				{
					_003C_003E1__state = -1;
					goto IL_0139;
				}
				IL_0149:
				if (_003Ci_003E5__3 >= PlaceablesManager.GGFJGHHHEJC.currentPlaceables.Count)
				{
					break;
				}
				if (PlaceablesManager.GGFJGHHHEJC.currentPlaceables[_003Ci_003E5__3].CCIKENEGHCA && PlaceablesManager.GGFJGHHHEJC.currentPlaceables[_003Ci_003E5__3].itemSetup.item.JDJGFAACPFC() == 706 && !_003CstoneStationFound_003E5__2)
				{
					_003CstoneStationFound_003E5__2 = true;
					CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
					instance2.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(instance2.OnPlaceablePlaced, new Action<int, Placeable>(t127_ClavosHierro.PDJGPNDJDNF));
					NewTutorialManager.instance.ObjectiveCompleted(0);
					t127_ClavosHierro.KJKKJDDMMKH = true;
					t127_ClavosHierro.DNAHJLGIMGA();
					if (!_003CstoneStationFound_003E5__2)
					{
						_003C_003E2__current = CommonReferences.wait05;
						_003C_003E1__state = 2;
						return true;
					}
					break;
				}
				goto IL_0139;
				IL_0139:
				_003Ci_003E5__3++;
				goto IL_0149;
			}
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

	[CompilerGenerated]
	private sealed class OJILAJIDNBE : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T127_ClavosHierro _003C_003E4__this;

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
			T127_ClavosHierro t127_ClavosHierro = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				goto IL_0046;
			case 1:
				_003C_003E1__state = -1;
				goto IL_0046;
			case 2:
				_003C_003E1__state = -1;
				goto IL_0079;
			case 3:
				{
					_003C_003E1__state = -1;
					t127_ClavosHierro.LHKIJABBBPM();
					return false;
				}
				IL_0046:
				if (t127_ClavosHierro.DEDAGAANMIB())
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
				MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T127/Dialogue2");
				goto IL_0079;
				IL_0079:
				if (t127_ClavosHierro.AAOPIEDAKKD(2))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 2;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait2;
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
	private sealed class ANHGEEIMBNP : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T127_ClavosHierro _003C_003E4__this;

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
		public ANHGEEIMBNP(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			T127_ClavosHierro t127_ClavosHierro = _003C_003E4__this;
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
				goto IL_00db;
			case 1:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
				MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
				CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
				goto IL_00db;
			case 2:
				_003C_003E1__state = -1;
				goto IL_00db;
			case 3:
				_003C_003E1__state = -1;
				NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
				if (_003CloadedFromSave_003E5__2)
				{
					_003C_003E2__current = CommonReferences.wait1;
					_003C_003E1__state = 4;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait3;
				_003C_003E1__state = 5;
				return true;
			case 4:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
				goto IL_015a;
			case 5:
				_003C_003E1__state = -1;
				goto IL_015a;
			case 6:
				_003C_003E1__state = -1;
				goto IL_018a;
			case 7:
				{
					_003C_003E1__state = -1;
					NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
					NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
					RecipesManager.UnlockRecipe(206);
					CommonReferences instance = CommonReferences.GGFJGHHHEJC;
					instance.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Combine(instance.OnPlaceablePlaced, new Action<int, Placeable>(t127_ClavosHierro.PDJGPNDJDNF));
					CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
					instance2.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Combine(instance2.OnRecipeToCraftAdded, new Action<int, Recipe>(t127_ClavosHierro.EECHIAJHKLD));
					NewTutorialManager instance3 = NewTutorialManager.instance;
					instance3.ObjectivesUpdated = (Action)Delegate.Combine(instance3.ObjectivesUpdated, new Action(t127_ClavosHierro.EFCMMONCGCP));
					return false;
				}
				IL_015a:
				MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T127/Dialogue1", t127_ClavosHierro.triggerPlayerNum);
				goto IL_018a;
				IL_018a:
				if (t127_ClavosHierro.AAOPIEDAKKD(1))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 6;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 7;
				return true;
				IL_00db:
				if (!t127_ClavosHierro.MCKLEPHBECB())
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 2;
					return true;
				}
				_003C_003E2__current = ((MonoBehaviour)t127_ClavosHierro).StartCoroutine(t127_ClavosHierro.CDICFNAMCEE());
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

	private bool EGIFPPECOAD;

	private bool KJKKJDDMMKH;

	public override void SetUp()
	{
		base.SetUp();
		((MonoBehaviour)this).StartCoroutine(PBEKBJIJFDK());
	}

	private void MJFJDGMEJMF()
	{
		if (EGIFPPECOAD && KJKKJDDMMKH)
		{
			((MonoBehaviour)this).StartCoroutine(KNBNIMCHKIE());
		}
	}

	private IEnumerator LJHLMGGLOOJ()
	{
		return new JILLIBJGIIK(1)
		{
			_003C_003E4__this = this
		};
	}

	private void NFJAGNCMIMB()
	{
		((MonoBehaviour)this).StartCoroutine(OHGAPFKFHGP());
	}

	private void KKCICIFBPNM()
	{
		if (EGIFPPECOAD && KJKKJDDMMKH)
		{
			((MonoBehaviour)this).StartCoroutine(GLLMLANGBOJ());
		}
	}

	private void FCDIEOCCLAD()
	{
		((MonoBehaviour)this).StartCoroutine(OHGAPFKFHGP());
	}

	private IEnumerator GDCMANLMBDB()
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
		if (loadedFromSave)
		{
			yield return CommonReferences.wait1;
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		else
		{
			yield return CommonReferences.wait3;
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T127/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		RecipesManager.UnlockRecipe(206);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Combine(instance.OnPlaceablePlaced, new Action<int, Placeable>(PDJGPNDJDNF));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Combine(instance2.OnRecipeToCraftAdded, new Action<int, Recipe>(EECHIAJHKLD));
		NewTutorialManager instance3 = NewTutorialManager.instance;
		instance3.ObjectivesUpdated = (Action)Delegate.Combine(instance3.ObjectivesUpdated, new Action(EFCMMONCGCP));
	}

	private IEnumerator HCKDBDMBMFL()
	{
		return new OJILAJIDNBE(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LEIEDKIDEHH()
	{
		return new JILLIBJGIIK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator BFKOPLNBPDK()
	{
		yield return CommonReferences.wait1;
		NewTutorialManager instance = NewTutorialManager.instance;
		instance.ObjectivesUpdated = (Action)Delegate.Remove(instance.ObjectivesUpdated, new Action(EFCMMONCGCP));
		bool stoneStationFound = false;
		for (int i = 0; i < PlaceablesManager.GGFJGHHHEJC.currentPlaceables.Count; i++)
		{
			if (PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].CCIKENEGHCA && PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].itemSetup.item.JDJGFAACPFC() == 706 && !stoneStationFound)
			{
				stoneStationFound = true;
				CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
				instance2.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(instance2.OnPlaceablePlaced, new Action<int, Placeable>(PDJGPNDJDNF));
				NewTutorialManager.instance.ObjectiveCompleted(0);
				KJKKJDDMMKH = true;
				DNAHJLGIMGA();
				if (stoneStationFound)
				{
					break;
				}
				yield return CommonReferences.wait05;
			}
		}
	}

	private void HGCKGABBNAK(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		if (EAPCLAODGAE.itemSetup.item.JGHNDJBCFAJ() == 177)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(commonReferences.OnPlaceablePlaced, new Action<int, Placeable>(GMOJKLOGFNO));
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			KJKKJDDMMKH = false;
			KKCICIFBPNM();
		}
	}

	private void GODLODDDFKC(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		if (EAPCLAODGAE.itemSetup.item.ODENMDOJPLC(DAINLFIMLIH: false) == -165)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(commonReferences.OnPlaceablePlaced, new Action<int, Placeable>(PDJGPNDJDNF));
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			KJKKJDDMMKH = true;
			AIPEPDNEJHO();
		}
	}

	private void HEJDJFCLKEE(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		if (EAPCLAODGAE.itemSetup.item.ODENMDOJPLC() == -32)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(commonReferences.OnPlaceablePlaced, new Action<int, Placeable>(BAPGNONOHMH));
			NewTutorialManager.instance.FOIOHOGACAL(0);
			KJKKJDDMMKH = true;
			JIFCOCEMIDM();
		}
	}

	public override int GetID()
	{
		return 127;
	}

	private IEnumerator MPDOMAMBIML()
	{
		yield return CommonReferences.wait1;
		NewTutorialManager instance = NewTutorialManager.instance;
		instance.ObjectivesUpdated = (Action)Delegate.Remove(instance.ObjectivesUpdated, new Action(EFCMMONCGCP));
		bool stoneStationFound = false;
		for (int i = 0; i < PlaceablesManager.GGFJGHHHEJC.currentPlaceables.Count; i++)
		{
			if (PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].CCIKENEGHCA && PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].itemSetup.item.JDJGFAACPFC() == 706 && !stoneStationFound)
			{
				stoneStationFound = true;
				CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
				instance2.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(instance2.OnPlaceablePlaced, new Action<int, Placeable>(PDJGPNDJDNF));
				NewTutorialManager.instance.ObjectiveCompleted(0);
				KJKKJDDMMKH = true;
				DNAHJLGIMGA();
				if (stoneStationFound)
				{
					break;
				}
				yield return CommonReferences.wait05;
			}
		}
	}

	private void AALIFCENHFD(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.CIGFGKKCPCK(DAINLFIMLIH: false) == 102)
		{
			NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(BEKPBGGMMAG));
			EGIFPPECOAD = false;
			GGJPCAKJJJI();
		}
	}

	private IEnumerator GLBHLKLKMNN()
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
		if (loadedFromSave)
		{
			yield return CommonReferences.wait1;
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		else
		{
			yield return CommonReferences.wait3;
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T127/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		RecipesManager.UnlockRecipe(206);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Combine(instance.OnPlaceablePlaced, new Action<int, Placeable>(PDJGPNDJDNF));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Combine(instance2.OnRecipeToCraftAdded, new Action<int, Recipe>(EECHIAJHKLD));
		NewTutorialManager instance3 = NewTutorialManager.instance;
		instance3.ObjectivesUpdated = (Action)Delegate.Combine(instance3.ObjectivesUpdated, new Action(EFCMMONCGCP));
	}

	private void LFKILIDFGKE()
	{
		if (EGIFPPECOAD && KJKKJDDMMKH)
		{
			((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
		}
	}

	private void BPPFLBPDKKA()
	{
		((MonoBehaviour)this).StartCoroutine(BJMCBLMEPEB());
	}

	private IEnumerator CFCMKAPFPCE()
	{
		while (DEDAGAANMIB())
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T127/Dialogue2");
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator BAGKLMIFNIH()
	{
		return new OJILAJIDNBE(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator KNBNIMCHKIE()
	{
		while (DEDAGAANMIB())
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T127/Dialogue2");
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator MIGPNMAOJPK()
	{
		return new ANHGEEIMBNP(1)
		{
			_003C_003E4__this = this
		};
	}

	private void AIPEPDNEJHO()
	{
		if (EGIFPPECOAD && KJKKJDDMMKH)
		{
			((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
		}
	}

	private void OONMDBKIFOP(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		if (EAPCLAODGAE.itemSetup.item.JDJGFAACPFC() == 153)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(commonReferences.OnPlaceablePlaced, new Action<int, Placeable>(GCIFLBFPNBJ));
			NewTutorialManager.instance.ObjectiveCompleted(1);
			KJKKJDDMMKH = true;
			OOMJFMGEFFK();
		}
	}

	private IEnumerator EBMPBCHIHKF()
	{
		return new JILLIBJGIIK(1)
		{
			_003C_003E4__this = this
		};
	}

	private void LONNGKGJOFF()
	{
		((MonoBehaviour)this).StartCoroutine(LBKCLGMELIK());
	}

	private IEnumerator PDAEFKAMACE()
	{
		return new OJILAJIDNBE(1)
		{
			_003C_003E4__this = this
		};
	}

	private void MNIGNHIODPO(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.IMCJPECAAPC(DAINLFIMLIH: false) == 126)
		{
			NewTutorialManager.instance.ObjectiveCompleted(1);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(JDDNCIDFMFE));
			EGIFPPECOAD = false;
			HPFJGKPOEFJ();
		}
	}

	private void LHDMLNIIJKK(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.CIGFGKKCPCK(DAINLFIMLIH: false) == 32)
		{
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(commonReferences.OnRecipeToCraftAdded, new Action<int, Recipe>(JDDNCIDFMFE));
			EGIFPPECOAD = false;
			AIPEPDNEJHO();
		}
	}

	private void NIPHFOEIHJE(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		if (EAPCLAODGAE.itemSetup.item.ODENMDOJPLC() == -108)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(instance.OnPlaceablePlaced, new Action<int, Placeable>(PNONACEDOIA));
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			KJKKJDDMMKH = true;
			FMEOHOMLJAF();
		}
	}

	private void KGGIGBBHNPK()
	{
		((MonoBehaviour)this).StartCoroutine(KAFCIGBJIIL());
	}

	private void OLJIAAJLPOC()
	{
		if (EGIFPPECOAD && KJKKJDDMMKH)
		{
			((MonoBehaviour)this).StartCoroutine(HGILIEMBJGH());
		}
	}

	private void COCOKBDKMLD()
	{
		((MonoBehaviour)this).StartCoroutine(HCGIIECALPF());
	}

	private IEnumerator AHENCONCNDJ()
	{
		yield return CommonReferences.wait1;
		NewTutorialManager instance = NewTutorialManager.instance;
		instance.ObjectivesUpdated = (Action)Delegate.Remove(instance.ObjectivesUpdated, new Action(EFCMMONCGCP));
		bool stoneStationFound = false;
		for (int i = 0; i < PlaceablesManager.GGFJGHHHEJC.currentPlaceables.Count; i++)
		{
			if (PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].CCIKENEGHCA && PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].itemSetup.item.JDJGFAACPFC() == 706 && !stoneStationFound)
			{
				stoneStationFound = true;
				CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
				instance2.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(instance2.OnPlaceablePlaced, new Action<int, Placeable>(PDJGPNDJDNF));
				NewTutorialManager.instance.ObjectiveCompleted(0);
				KJKKJDDMMKH = true;
				DNAHJLGIMGA();
				if (stoneStationFound)
				{
					break;
				}
				yield return CommonReferences.wait05;
			}
		}
	}

	private void JDDNCIDFMFE(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.CIGFGKKCPCK() == -144)
		{
			NewTutorialManager.instance.ObjectiveCompleted(0);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(commonReferences.OnRecipeToCraftAdded, new Action<int, Recipe>(IPEPJHHBFPM));
			EGIFPPECOAD = false;
			LGKJBGJLMGA();
		}
	}

	private IEnumerator BJMCBLMEPEB()
	{
		return new JILLIBJGIIK(1)
		{
			_003C_003E4__this = this
		};
	}

	private void BNNIPIOHNHH(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		if (EAPCLAODGAE.itemSetup.item.ODENMDOJPLC(DAINLFIMLIH: false) == 143)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(commonReferences.OnPlaceablePlaced, new Action<int, Placeable>(NIPHFOEIHJE));
			NewTutorialManager.instance.ObjectiveCompleted(0);
			KJKKJDDMMKH = false;
			KKCICIFBPNM();
		}
	}

	private void HMNEDGEPOCJ()
	{
		if (EGIFPPECOAD && KJKKJDDMMKH)
		{
			((MonoBehaviour)this).StartCoroutine(KNBNIMCHKIE());
		}
	}

	private void NIINOBGAACD()
	{
		((MonoBehaviour)this).StartCoroutine(AJAIHFMLBBI());
	}

	private void OOMJFMGEFFK()
	{
		if (EGIFPPECOAD && KJKKJDDMMKH)
		{
			((MonoBehaviour)this).StartCoroutine(KNBNIMCHKIE());
		}
	}

	private void MJGAKEGOFLM(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		if (EAPCLAODGAE.itemSetup.item.ODENMDOJPLC(DAINLFIMLIH: false) == 137)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(instance.OnPlaceablePlaced, new Action<int, Placeable>(PDJGPNDJDNF));
			NewTutorialManager.instance.FOIOHOGACAL(1);
			KJKKJDDMMKH = false;
			IDHBLOBJMGD();
		}
	}

	private IEnumerator KBAFIHCCEJG()
	{
		return new OJILAJIDNBE(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AIOFEEJOIPL()
	{
		while (DEDAGAANMIB())
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T127/Dialogue2");
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator KFKLJPJJFLJ()
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
		if (loadedFromSave)
		{
			yield return CommonReferences.wait1;
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		else
		{
			yield return CommonReferences.wait3;
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T127/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		RecipesManager.UnlockRecipe(206);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Combine(instance.OnPlaceablePlaced, new Action<int, Placeable>(PDJGPNDJDNF));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Combine(instance2.OnRecipeToCraftAdded, new Action<int, Recipe>(EECHIAJHKLD));
		NewTutorialManager instance3 = NewTutorialManager.instance;
		instance3.ObjectivesUpdated = (Action)Delegate.Combine(instance3.ObjectivesUpdated, new Action(EFCMMONCGCP));
	}

	private IEnumerator COIPAFGCKOK()
	{
		yield return CommonReferences.wait1;
		NewTutorialManager instance = NewTutorialManager.instance;
		instance.ObjectivesUpdated = (Action)Delegate.Remove(instance.ObjectivesUpdated, new Action(EFCMMONCGCP));
		bool stoneStationFound = false;
		for (int i = 0; i < PlaceablesManager.GGFJGHHHEJC.currentPlaceables.Count; i++)
		{
			if (PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].CCIKENEGHCA && PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].itemSetup.item.JDJGFAACPFC() == 706 && !stoneStationFound)
			{
				stoneStationFound = true;
				CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
				instance2.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(instance2.OnPlaceablePlaced, new Action<int, Placeable>(PDJGPNDJDNF));
				NewTutorialManager.instance.ObjectiveCompleted(0);
				KJKKJDDMMKH = true;
				DNAHJLGIMGA();
				if (stoneStationFound)
				{
					break;
				}
				yield return CommonReferences.wait05;
			}
		}
	}

	private void GGJPCAKJJJI()
	{
		if (EGIFPPECOAD && KJKKJDDMMKH)
		{
			((MonoBehaviour)this).StartCoroutine(HGILIEMBJGH());
		}
	}

	private IEnumerator FOAGIFLHLCC()
	{
		return new JILLIBJGIIK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NPCCKFEDCHI()
	{
		return new ANHGEEIMBNP(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator INHPCDBIPOJ()
	{
		yield return CommonReferences.wait1;
		NewTutorialManager instance = NewTutorialManager.instance;
		instance.ObjectivesUpdated = (Action)Delegate.Remove(instance.ObjectivesUpdated, new Action(EFCMMONCGCP));
		bool stoneStationFound = false;
		for (int i = 0; i < PlaceablesManager.GGFJGHHHEJC.currentPlaceables.Count; i++)
		{
			if (PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].CCIKENEGHCA && PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].itemSetup.item.JDJGFAACPFC() == 706 && !stoneStationFound)
			{
				stoneStationFound = true;
				CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
				instance2.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(instance2.OnPlaceablePlaced, new Action<int, Placeable>(PDJGPNDJDNF));
				NewTutorialManager.instance.ObjectiveCompleted(0);
				KJKKJDDMMKH = true;
				DNAHJLGIMGA();
				if (stoneStationFound)
				{
					break;
				}
				yield return CommonReferences.wait05;
			}
		}
	}

	private void DIMJHJBJGGN(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.JGHNDJBCFAJ() == 126)
		{
			NewTutorialManager.instance.ObjectiveCompleted(0);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(LHDMLNIIJKK));
			EGIFPPECOAD = false;
			AIPEPDNEJHO();
		}
	}

	private void ACBGPMBCCBB(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.IMCJPECAAPC(DAINLFIMLIH: false) == -106)
		{
			NewTutorialManager.instance.FOIOHOGACAL(1);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(commonReferences.OnRecipeToCraftAdded, new Action<int, Recipe>(DIMJHJBJGGN));
			EGIFPPECOAD = false;
			GGJPCAKJJJI();
		}
	}

	private void LMLHJPEMPHH(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.JGHNDJBCFAJ() == 159)
		{
			NewTutorialManager.instance.ObjectiveCompleted(0);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(MNIGNHIODPO));
			EGIFPPECOAD = false;
			EFOFEKMIMGB();
		}
	}

	private void PBBFGNNDKBN()
	{
		((MonoBehaviour)this).StartCoroutine(FOAGIFLHLCC());
	}

	private void KNMEJFJKPDJ(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		if (EAPCLAODGAE.itemSetup.item.JGHNDJBCFAJ() == 9)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(instance.OnPlaceablePlaced, new Action<int, Placeable>(APHCADKIAOH));
			NewTutorialManager.instance.FOIOHOGACAL(1);
			KJKKJDDMMKH = true;
			EFOFEKMIMGB();
		}
	}

	private IEnumerator IGEOMOOKOEP()
	{
		return new ANHGEEIMBNP(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NHPCNDODFAK()
	{
		while (DEDAGAANMIB())
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T127/Dialogue2");
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator HGFPMNKEMAC()
	{
		while (DEDAGAANMIB())
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T127/Dialogue2");
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator DIGIMPCLCCL()
	{
		return new ANHGEEIMBNP(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NBAELEJAFAN()
	{
		return new OJILAJIDNBE(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NHLLGDCFOFC()
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
		if (loadedFromSave)
		{
			yield return CommonReferences.wait1;
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		else
		{
			yield return CommonReferences.wait3;
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T127/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		RecipesManager.UnlockRecipe(206);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Combine(instance.OnPlaceablePlaced, new Action<int, Placeable>(PDJGPNDJDNF));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Combine(instance2.OnRecipeToCraftAdded, new Action<int, Recipe>(EECHIAJHKLD));
		NewTutorialManager instance3 = NewTutorialManager.instance;
		instance3.ObjectivesUpdated = (Action)Delegate.Combine(instance3.ObjectivesUpdated, new Action(EFCMMONCGCP));
	}

	private IEnumerator MPJMCMIMHFC()
	{
		while (DEDAGAANMIB())
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T127/Dialogue2");
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator BPMIGCIFGML()
	{
		return new ANHGEEIMBNP(1)
		{
			_003C_003E4__this = this
		};
	}

	private void AANDFPGJIJB()
	{
		if (EGIFPPECOAD && KJKKJDDMMKH)
		{
			((MonoBehaviour)this).StartCoroutine(KNBNIMCHKIE());
		}
	}

	private IEnumerator KAFCIGBJIIL()
	{
		yield return CommonReferences.wait1;
		NewTutorialManager instance = NewTutorialManager.instance;
		instance.ObjectivesUpdated = (Action)Delegate.Remove(instance.ObjectivesUpdated, new Action(EFCMMONCGCP));
		bool stoneStationFound = false;
		for (int i = 0; i < PlaceablesManager.GGFJGHHHEJC.currentPlaceables.Count; i++)
		{
			if (PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].CCIKENEGHCA && PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].itemSetup.item.JDJGFAACPFC() == 706 && !stoneStationFound)
			{
				stoneStationFound = true;
				CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
				instance2.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(instance2.OnPlaceablePlaced, new Action<int, Placeable>(PDJGPNDJDNF));
				NewTutorialManager.instance.ObjectiveCompleted(0);
				KJKKJDDMMKH = true;
				DNAHJLGIMGA();
				if (stoneStationFound)
				{
					break;
				}
				yield return CommonReferences.wait05;
			}
		}
	}

	private IEnumerator HCGIIECALPF()
	{
		return new JILLIBJGIIK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LBKCLGMELIK()
	{
		return new JILLIBJGIIK(1)
		{
			_003C_003E4__this = this
		};
	}

	private void PLPCLNONLKI(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		if (EAPCLAODGAE.itemSetup.item.JGHNDJBCFAJ() == 23)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(commonReferences.OnPlaceablePlaced, new Action<int, Placeable>(HGCKGABBNAK));
			NewTutorialManager.instance.FOIOHOGACAL(0);
			KJKKJDDMMKH = false;
			HMNEDGEPOCJ();
		}
	}

	private IEnumerator DOLNMFALDFP()
	{
		yield return CommonReferences.wait1;
		NewTutorialManager instance = NewTutorialManager.instance;
		instance.ObjectivesUpdated = (Action)Delegate.Remove(instance.ObjectivesUpdated, new Action(EFCMMONCGCP));
		bool stoneStationFound = false;
		for (int i = 0; i < PlaceablesManager.GGFJGHHHEJC.currentPlaceables.Count; i++)
		{
			if (PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].CCIKENEGHCA && PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].itemSetup.item.JDJGFAACPFC() == 706 && !stoneStationFound)
			{
				stoneStationFound = true;
				CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
				instance2.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(instance2.OnPlaceablePlaced, new Action<int, Placeable>(PDJGPNDJDNF));
				NewTutorialManager.instance.ObjectiveCompleted(0);
				KJKKJDDMMKH = true;
				DNAHJLGIMGA();
				if (stoneStationFound)
				{
					break;
				}
				yield return CommonReferences.wait05;
			}
		}
	}

	private void BOHMAGDHOFI()
	{
		((MonoBehaviour)this).StartCoroutine(BJMCBLMEPEB());
	}

	private IEnumerator KOJJCIBCNPJ()
	{
		return new JILLIBJGIIK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HGILIEMBJGH()
	{
		return new OJILAJIDNBE(1)
		{
			_003C_003E4__this = this
		};
	}

	private void DNAHJLGIMGA()
	{
		if (EGIFPPECOAD && KJKKJDDMMKH)
		{
			((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
		}
	}

	private void HPFJGKPOEFJ()
	{
		if (EGIFPPECOAD && KJKKJDDMMKH)
		{
			((MonoBehaviour)this).StartCoroutine(HGILIEMBJGH());
		}
	}

	private void MLFEDJAAPOM()
	{
		((MonoBehaviour)this).StartCoroutine(MPDOMAMBIML());
	}

	private void FMEOHOMLJAF()
	{
		if (EGIFPPECOAD && KJKKJDDMMKH)
		{
			((MonoBehaviour)this).StartCoroutine(AIOFEEJOIPL());
		}
	}

	private void AMCFPDLGOFB()
	{
		if (EGIFPPECOAD && KJKKJDDMMKH)
		{
			((MonoBehaviour)this).StartCoroutine(BAGKLMIFNIH());
		}
	}

	private void OCJOMNIEHED(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.JDJGFAACPFC(DAINLFIMLIH: false) == 64)
		{
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(JEDPMLACHFN));
			EGIFPPECOAD = false;
			HPFJGKPOEFJ();
		}
	}

	private void EECHIAJHKLD(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.JDJGFAACPFC() == 1045)
		{
			NewTutorialManager.instance.ObjectiveCompleted(1);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(EECHIAJHKLD));
			EGIFPPECOAD = true;
			DNAHJLGIMGA();
		}
	}

	private void EFCMMONCGCP()
	{
		((MonoBehaviour)this).StartCoroutine(OHFHKAENGBL());
	}

	private IEnumerator GLLMLANGBOJ()
	{
		while (DEDAGAANMIB())
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T127/Dialogue2");
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private void OKGOBKIKDHN()
	{
		((MonoBehaviour)this).StartCoroutine(EBMPBCHIHKF());
	}

	private void GBPEGGCAODI(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		if (EAPCLAODGAE.itemSetup.item.ODENMDOJPLC(DAINLFIMLIH: false) == 66)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(commonReferences.OnPlaceablePlaced, new Action<int, Placeable>(GODLODDDFKC));
			NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			KJKKJDDMMKH = false;
			OLJIAAJLPOC();
		}
	}

	private void BAPGNONOHMH(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		if (EAPCLAODGAE.itemSetup.item.JGHNDJBCFAJ(DAINLFIMLIH: false) == 152)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(instance.OnPlaceablePlaced, new Action<int, Placeable>(GBPEGGCAODI));
			NewTutorialManager.instance.ObjectiveCompleted(1);
			KJKKJDDMMKH = true;
			MJFJDGMEJMF();
		}
	}

	private void BOCHBLNFCKJ(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		if (EAPCLAODGAE.itemSetup.item.ODENMDOJPLC() == -61)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(instance.OnPlaceablePlaced, new Action<int, Placeable>(BAPGNONOHMH));
			NewTutorialManager.instance.ObjectiveCompleted(0);
			KJKKJDDMMKH = false;
			JLFDJBKLJPE();
		}
	}

	private IEnumerator EOCBHNPFJLL()
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
		if (loadedFromSave)
		{
			yield return CommonReferences.wait1;
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		else
		{
			yield return CommonReferences.wait3;
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T127/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		RecipesManager.UnlockRecipe(206);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Combine(instance.OnPlaceablePlaced, new Action<int, Placeable>(PDJGPNDJDNF));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Combine(instance2.OnRecipeToCraftAdded, new Action<int, Recipe>(EECHIAJHKLD));
		NewTutorialManager instance3 = NewTutorialManager.instance;
		instance3.ObjectivesUpdated = (Action)Delegate.Combine(instance3.ObjectivesUpdated, new Action(EFCMMONCGCP));
	}

	private void EFOFEKMIMGB()
	{
		if (EGIFPPECOAD && KJKKJDDMMKH)
		{
			((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
		}
	}

	private void JPIKJIFBAFM()
	{
		((MonoBehaviour)this).StartCoroutine(DOLNMFALDFP());
	}

	private IEnumerator BLHFOAMKOAH()
	{
		while (DEDAGAANMIB())
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T127/Dialogue2");
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator LHDDHIJIFCN()
	{
		while (DEDAGAANMIB())
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T127/Dialogue2");
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private void HFLPMLOJPHL()
	{
		if (EGIFPPECOAD && KJKKJDDMMKH)
		{
			((MonoBehaviour)this).StartCoroutine(AIOFEEJOIPL());
		}
	}

	private IEnumerator HFMMNGELPGN()
	{
		return new ANHGEEIMBNP(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator ABAEAEAJEJE()
	{
		return new JILLIBJGIIK(1)
		{
			_003C_003E4__this = this
		};
	}

	private void BBCGLNCMFIN()
	{
		((MonoBehaviour)this).StartCoroutine(DOLNMFALDFP());
	}

	private void BDGDHKEPHGG()
	{
		((MonoBehaviour)this).StartCoroutine(DOLNMFALDFP());
	}

	private void GMOJKLOGFNO(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		if (EAPCLAODGAE.itemSetup.item.ODENMDOJPLC() == -72)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(commonReferences.OnPlaceablePlaced, new Action<int, Placeable>(PLPCLNONLKI));
			NewTutorialManager.instance.ObjectiveCompleted(1);
			KJKKJDDMMKH = true;
			FMEOHOMLJAF();
		}
	}

	private void LGKJBGJLMGA()
	{
		if (EGIFPPECOAD && KJKKJDDMMKH)
		{
			((MonoBehaviour)this).StartCoroutine(NHPCNDODFAK());
		}
	}

	private void JEDPMLACHFN(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.JPNFKDMFKMC(DAINLFIMLIH: false) == 101)
		{
			NewTutorialManager.instance.ObjectiveCompleted(0);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(DIMJHJBJGGN));
			EGIFPPECOAD = false;
			MJFJDGMEJMF();
		}
	}

	private void CEFKLNOKKHA()
	{
		((MonoBehaviour)this).StartCoroutine(OHFHKAENGBL());
	}

	private void JIFCOCEMIDM()
	{
		if (EGIFPPECOAD && KJKKJDDMMKH)
		{
			((MonoBehaviour)this).StartCoroutine(MPJMCMIMHFC());
		}
	}

	private void APHCADKIAOH(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		if (EAPCLAODGAE.itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) == 119)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(commonReferences.OnPlaceablePlaced, new Action<int, Placeable>(BNNIPIOHNHH));
			NewTutorialManager.instance.FOIOHOGACAL(1);
			KJKKJDDMMKH = false;
			OOIPPGNNGKM();
		}
	}

	private IEnumerator OHGAPFKFHGP()
	{
		return new JILLIBJGIIK(1)
		{
			_003C_003E4__this = this
		};
	}

	private void IDHBLOBJMGD()
	{
		if (EGIFPPECOAD && KJKKJDDMMKH)
		{
			((MonoBehaviour)this).StartCoroutine(BAGKLMIFNIH());
		}
	}

	private void OOIPPGNNGKM()
	{
		if (EGIFPPECOAD && KJKKJDDMMKH)
		{
			((MonoBehaviour)this).StartCoroutine(MPJMCMIMHFC());
		}
	}

	private IEnumerator FALMLGKJBDF()
	{
		yield return CommonReferences.wait1;
		NewTutorialManager instance = NewTutorialManager.instance;
		instance.ObjectivesUpdated = (Action)Delegate.Remove(instance.ObjectivesUpdated, new Action(EFCMMONCGCP));
		bool stoneStationFound = false;
		for (int i = 0; i < PlaceablesManager.GGFJGHHHEJC.currentPlaceables.Count; i++)
		{
			if (PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].CCIKENEGHCA && PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].itemSetup.item.JDJGFAACPFC() == 706 && !stoneStationFound)
			{
				stoneStationFound = true;
				CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
				instance2.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(instance2.OnPlaceablePlaced, new Action<int, Placeable>(PDJGPNDJDNF));
				NewTutorialManager.instance.ObjectiveCompleted(0);
				KJKKJDDMMKH = true;
				DNAHJLGIMGA();
				if (stoneStationFound)
				{
					break;
				}
				yield return CommonReferences.wait05;
			}
		}
	}

	private void GCIFLBFPNBJ(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		if (EAPCLAODGAE.itemSetup.item.JGHNDJBCFAJ(DAINLFIMLIH: false) == 44)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(instance.OnPlaceablePlaced, new Action<int, Placeable>(OONMDBKIFOP));
			NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			KJKKJDDMMKH = false;
			NLKKMKFOIEM();
		}
	}

	private IEnumerator AJAIHFMLBBI()
	{
		return new JILLIBJGIIK(1)
		{
			_003C_003E4__this = this
		};
	}

	private void PDJGPNDJDNF(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		if (EAPCLAODGAE.itemSetup.item.JDJGFAACPFC() == 706)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(instance.OnPlaceablePlaced, new Action<int, Placeable>(PDJGPNDJDNF));
			NewTutorialManager.instance.ObjectiveCompleted(0);
			KJKKJDDMMKH = true;
			DNAHJLGIMGA();
		}
	}

	private void PNONACEDOIA(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		if (EAPCLAODGAE.itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) == -87)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(commonReferences.OnPlaceablePlaced, new Action<int, Placeable>(MJGAKEGOFLM));
			NewTutorialManager.instance.FOIOHOGACAL(1);
			KJKKJDDMMKH = true;
			LGKJBGJLMGA();
		}
	}

	private void BEKPBGGMMAG(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.JGHNDJBCFAJ(DAINLFIMLIH: false) == 105)
		{
			NewTutorialManager.instance.FOIOHOGACAL(1);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(commonReferences.OnRecipeToCraftAdded, new Action<int, Recipe>(FCHKFJKKAAC));
			EGIFPPECOAD = true;
			HFLPMLOJPHL();
		}
	}

	private void NLKKMKFOIEM()
	{
		if (EGIFPPECOAD && KJKKJDDMMKH)
		{
			((MonoBehaviour)this).StartCoroutine(MPJMCMIMHFC());
		}
	}

	private void JLFDJBKLJPE()
	{
		if (EGIFPPECOAD && KJKKJDDMMKH)
		{
			((MonoBehaviour)this).StartCoroutine(DABNLFBDKGN());
		}
	}

	private void OMCPGGEOGMH()
	{
		((MonoBehaviour)this).StartCoroutine(MPDOMAMBIML());
	}

	private void FCHKFJKKAAC(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.JGHNDJBCFAJ() == 55)
		{
			NewTutorialManager.instance.ObjectiveCompleted(0);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(commonReferences.OnRecipeToCraftAdded, new Action<int, Recipe>(JDDNCIDFMFE));
			EGIFPPECOAD = false;
			OOIPPGNNGKM();
		}
	}

	private void IPEPJHHBFPM(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.ODENMDOJPLC() == -188)
		{
			NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(JEDPMLACHFN));
			EGIFPPECOAD = false;
			MJFJDGMEJMF();
		}
	}

	private IEnumerator DABNLFBDKGN()
	{
		while (DEDAGAANMIB())
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T127/Dialogue2");
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator JOCBLNNOJPE()
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
		if (loadedFromSave)
		{
			yield return CommonReferences.wait1;
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		else
		{
			yield return CommonReferences.wait3;
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T127/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		RecipesManager.UnlockRecipe(206);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Combine(instance.OnPlaceablePlaced, new Action<int, Placeable>(PDJGPNDJDNF));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Combine(instance2.OnRecipeToCraftAdded, new Action<int, Recipe>(EECHIAJHKLD));
		NewTutorialManager instance3 = NewTutorialManager.instance;
		instance3.ObjectivesUpdated = (Action)Delegate.Combine(instance3.ObjectivesUpdated, new Action(EFCMMONCGCP));
	}

	private IEnumerator EKMOJHNJOCG()
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
		if (loadedFromSave)
		{
			yield return CommonReferences.wait1;
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		else
		{
			yield return CommonReferences.wait3;
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T127/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		RecipesManager.UnlockRecipe(206);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Combine(instance.OnPlaceablePlaced, new Action<int, Placeable>(PDJGPNDJDNF));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Combine(instance2.OnRecipeToCraftAdded, new Action<int, Recipe>(EECHIAJHKLD));
		NewTutorialManager instance3 = NewTutorialManager.instance;
		instance3.ObjectivesUpdated = (Action)Delegate.Combine(instance3.ObjectivesUpdated, new Action(EFCMMONCGCP));
	}

	private void OKHLMNGJOND(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.CIGFGKKCPCK(DAINLFIMLIH: false) == -107)
		{
			NewTutorialManager.instance.FOIOHOGACAL(0);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(commonReferences.OnRecipeToCraftAdded, new Action<int, Recipe>(IPEPJHHBFPM));
			EGIFPPECOAD = true;
			KKCICIFBPNM();
		}
	}

	private IEnumerator CPCGNMPLFHM()
	{
		return new ANHGEEIMBNP(1)
		{
			_003C_003E4__this = this
		};
	}

	private void GDDCLHJNGJA()
	{
		if (EGIFPPECOAD && KJKKJDDMMKH)
		{
			((MonoBehaviour)this).StartCoroutine(PDAEFKAMACE());
		}
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
		if (loadedFromSave)
		{
			yield return CommonReferences.wait1;
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		else
		{
			yield return CommonReferences.wait3;
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T127/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		RecipesManager.UnlockRecipe(206);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Combine(instance.OnPlaceablePlaced, new Action<int, Placeable>(PDJGPNDJDNF));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Combine(instance2.OnRecipeToCraftAdded, new Action<int, Recipe>(EECHIAJHKLD));
		NewTutorialManager instance3 = NewTutorialManager.instance;
		instance3.ObjectivesUpdated = (Action)Delegate.Combine(instance3.ObjectivesUpdated, new Action(EFCMMONCGCP));
	}

	private void MFJAPECBNDD()
	{
		((MonoBehaviour)this).StartCoroutine(COIPAFGCKOK());
	}

	private IEnumerator CFAFGIADLPJ()
	{
		return new ANHGEEIMBNP(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator OHFHKAENGBL()
	{
		yield return CommonReferences.wait1;
		NewTutorialManager instance = NewTutorialManager.instance;
		instance.ObjectivesUpdated = (Action)Delegate.Remove(instance.ObjectivesUpdated, new Action(EFCMMONCGCP));
		bool stoneStationFound = false;
		for (int i = 0; i < PlaceablesManager.GGFJGHHHEJC.currentPlaceables.Count; i++)
		{
			if (PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].CCIKENEGHCA && PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].itemSetup.item.JDJGFAACPFC() == 706 && !stoneStationFound)
			{
				stoneStationFound = true;
				CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
				instance2.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(instance2.OnPlaceablePlaced, new Action<int, Placeable>(PDJGPNDJDNF));
				NewTutorialManager.instance.ObjectiveCompleted(0);
				KJKKJDDMMKH = true;
				DNAHJLGIMGA();
				if (stoneStationFound)
				{
					break;
				}
				yield return CommonReferences.wait05;
			}
		}
	}
}
