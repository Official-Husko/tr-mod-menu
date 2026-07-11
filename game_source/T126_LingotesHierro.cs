using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class T126_LingotesHierro : TutorialPhaseBase
{
	[CompilerGenerated]
	private sealed class JILLIBJGIIK : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T126_LingotesHierro _003C_003E4__this;

		private bool _003CtableFound_003E5__2;

		private bool _003ChornoFound_003E5__3;

		private int _003Ci_003E5__4;

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
			T126_LingotesHierro t126_LingotesHierro = _003C_003E4__this;
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
				instance.ObjectivesUpdated = (Action)Delegate.Remove(instance.ObjectivesUpdated, new Action(t126_LingotesHierro.EFCMMONCGCP));
				_003CtableFound_003E5__2 = false;
				_003ChornoFound_003E5__3 = false;
				_003Ci_003E5__4 = 0;
				goto IL_01cf;
			}
			case 2:
				_003C_003E1__state = -1;
				goto IL_011b;
			case 3:
				{
					_003C_003E1__state = -1;
					goto IL_01bf;
				}
				IL_01cf:
				if (_003Ci_003E5__4 >= PlaceablesManager.GGFJGHHHEJC.currentPlaceables.Count)
				{
					break;
				}
				if (PlaceablesManager.GGFJGHHHEJC.currentPlaceables[_003Ci_003E5__4].CCIKENEGHCA)
				{
					if (PlaceablesManager.GGFJGHHHEJC.currentPlaceables[_003Ci_003E5__4].itemSetup.item.JDJGFAACPFC() == 704 && !_003ChornoFound_003E5__3)
					{
						_003ChornoFound_003E5__3 = true;
						NewTutorialManager.instance.ObjectiveCompleted(0);
						if (!(_003CtableFound_003E5__2 & _003ChornoFound_003E5__3))
						{
							_003C_003E2__current = CommonReferences.wait05;
							_003C_003E1__state = 2;
							return true;
						}
						break;
					}
					goto IL_011b;
				}
				goto IL_01bf;
				IL_011b:
				if (PlaceablesManager.GGFJGHHHEJC.currentPlaceables[_003Ci_003E5__4].itemSetup.item.JDJGFAACPFC() == 728 && !_003CtableFound_003E5__2)
				{
					_003CtableFound_003E5__2 = true;
					CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
					instance2.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(instance2.OnPlaceablePlaced, new Action<int, Placeable>(t126_LingotesHierro.PDJGPNDJDNF));
					NewTutorialManager.instance.ObjectiveCompleted(1);
					t126_LingotesHierro.KJKKJDDMMKH = true;
					t126_LingotesHierro.DNAHJLGIMGA();
					if (!(_003CtableFound_003E5__2 & _003ChornoFound_003E5__3))
					{
						_003C_003E2__current = CommonReferences.wait05;
						_003C_003E1__state = 3;
						return true;
					}
					break;
				}
				goto IL_01bf;
				IL_01bf:
				_003Ci_003E5__4++;
				goto IL_01cf;
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

		public T126_LingotesHierro _003C_003E4__this;

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
			T126_LingotesHierro t126_LingotesHierro = _003C_003E4__this;
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
				t126_LingotesHierro.LHKIJABBBPM();
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
	private sealed class ANHGEEIMBNP : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T126_LingotesHierro _003C_003E4__this;

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
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			T126_LingotesHierro t126_LingotesHierro = _003C_003E4__this;
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
				MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T126/Dialogue1", t126_LingotesHierro.triggerPlayerNum);
				goto IL_0169;
			case 5:
				_003C_003E1__state = -1;
				goto IL_0169;
			case 6:
				{
					_003C_003E1__state = -1;
					NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
					NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
					RecipesManager.UnlockRecipe(216);
					CommonReferences instance = CommonReferences.GGFJGHHHEJC;
					instance.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Combine(instance.OnPlaceablePlaced, new Action<int, Placeable>(t126_LingotesHierro.PDJGPNDJDNF));
					CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
					instance2.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Combine(instance2.OnRecipeToCraftAdded, new Action<int, Recipe>(t126_LingotesHierro.EECHIAJHKLD));
					NewTutorialManager instance3 = NewTutorialManager.instance;
					instance3.ObjectivesUpdated = (Action)Delegate.Combine(instance3.ObjectivesUpdated, new Action(t126_LingotesHierro.EFCMMONCGCP));
					return false;
				}
				IL_0169:
				if (t126_LingotesHierro.AAOPIEDAKKD(1))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 5;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 6;
				return true;
				IL_00d7:
				if (!t126_LingotesHierro.MCKLEPHBECB())
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 2;
					return true;
				}
				_003C_003E2__current = ((MonoBehaviour)t126_LingotesHierro).StartCoroutine(t126_LingotesHierro.CDICFNAMCEE());
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

	private bool FHJBMLINFHM;

	private bool KJKKJDDMMKH;

	private void KNABBKIICAK(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.JPNFKDMFKMC() == -97)
		{
			NewTutorialManager.instance.ObjectiveCompleted(1);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(commonReferences.OnRecipeToCraftAdded, new Action<int, Recipe>(JIOMCACHOCM));
			FHJBMLINFHM = true;
			MJFJDGMEJMF();
		}
	}

	private void JCDNJPCCBCD(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.JGHNDJBCFAJ() == -90)
		{
			NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(KNABBKIICAK));
			FHJBMLINFHM = false;
			PAGLLIDOLCA();
		}
	}

	private void FOBFKCOOLMD()
	{
		((MonoBehaviour)this).StartCoroutine(GOJPFDDMNIJ());
	}

	private IEnumerator EHGECAFMHEA()
	{
		return new ANHGEEIMBNP(1)
		{
			_003C_003E4__this = this
		};
	}

	private void OPKCILHKIBJ()
	{
		if (FHJBMLINFHM && KJKKJDDMMKH)
		{
			((MonoBehaviour)this).StartCoroutine(KNBNIMCHKIE());
		}
	}

	private void LBMOFGIEPCP(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		if (EAPCLAODGAE.itemSetup.item.IMCJPECAAPC(DAINLFIMLIH: false) == -91)
		{
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
		}
		if (EAPCLAODGAE.itemSetup.item.CIGFGKKCPCK(DAINLFIMLIH: false) == 41)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(instance.OnPlaceablePlaced, new Action<int, Placeable>(PDJGPNDJDNF));
			NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			KJKKJDDMMKH = true;
			DFGLGMOEJIE();
		}
	}

	private IEnumerator BCALBKDNAJH()
	{
		return new ANHGEEIMBNP(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator DOLNMFALDFP()
	{
		return new JILLIBJGIIK(1)
		{
			_003C_003E4__this = this
		};
	}

	private void NBJOKBDDCPA()
	{
		((MonoBehaviour)this).StartCoroutine(GOJPFDDMNIJ());
	}

	private IEnumerator AHENCONCNDJ()
	{
		return new JILLIBJGIIK(1)
		{
			_003C_003E4__this = this
		};
	}

	private void EMFGFEKLLCO(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.JDJGFAACPFC(DAINLFIMLIH: false) == -35)
		{
			NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(commonReferences.OnRecipeToCraftAdded, new Action<int, Recipe>(OKHLMNGJOND));
			FHJBMLINFHM = true;
			NDGMLHGNCOE();
		}
	}

	private IEnumerator AOGGKPMBLBK()
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
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T126/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		RecipesManager.UnlockRecipe(216);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Combine(instance.OnPlaceablePlaced, new Action<int, Placeable>(PDJGPNDJDNF));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Combine(instance2.OnRecipeToCraftAdded, new Action<int, Recipe>(EECHIAJHKLD));
		NewTutorialManager instance3 = NewTutorialManager.instance;
		instance3.ObjectivesUpdated = (Action)Delegate.Combine(instance3.ObjectivesUpdated, new Action(EFCMMONCGCP));
	}

	private void CFDKIAHGKIF(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		if (EAPCLAODGAE.itemSetup.item.JPNFKDMFKMC(DAINLFIMLIH: false) == -192)
		{
			NewTutorialManager.instance.FOIOHOGACAL(0);
		}
		if (EAPCLAODGAE.itemSetup.item.JPNFKDMFKMC(DAINLFIMLIH: false) == -27)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(commonReferences.OnPlaceablePlaced, new Action<int, Placeable>(PKMLHDCBCDC));
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			KJKKJDDMMKH = false;
			OPKCILHKIBJ();
		}
	}

	private IEnumerator PGGPPJHHMKM()
	{
		yield return CommonReferences.wait1;
		NewTutorialManager instance = NewTutorialManager.instance;
		instance.ObjectivesUpdated = (Action)Delegate.Remove(instance.ObjectivesUpdated, new Action(EFCMMONCGCP));
		bool tableFound = false;
		bool hornoFound = false;
		for (int i = 0; i < PlaceablesManager.GGFJGHHHEJC.currentPlaceables.Count; i++)
		{
			if (!PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].CCIKENEGHCA)
			{
				continue;
			}
			if (PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].itemSetup.item.JDJGFAACPFC() == 704 && !hornoFound)
			{
				hornoFound = true;
				NewTutorialManager.instance.ObjectiveCompleted(0);
				if (tableFound && hornoFound)
				{
					break;
				}
				yield return CommonReferences.wait05;
			}
			if (PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].itemSetup.item.JDJGFAACPFC() == 728 && !tableFound)
			{
				tableFound = true;
				CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
				instance2.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(instance2.OnPlaceablePlaced, new Action<int, Placeable>(PDJGPNDJDNF));
				NewTutorialManager.instance.ObjectiveCompleted(1);
				KJKKJDDMMKH = true;
				DNAHJLGIMGA();
				if (tableFound && hornoFound)
				{
					break;
				}
				yield return CommonReferences.wait05;
			}
		}
	}

	private void KHGBOEFFFBK(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.JGHNDJBCFAJ() == -58)
		{
			NewTutorialManager.instance.FOIOHOGACAL(0);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(GCOLDIJIENM));
			FHJBMLINFHM = true;
			ADDFKJJPBIG();
		}
	}

	private IEnumerator IHGGOFFGMBD()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private void PEKOCNBJLJG(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.JGHNDJBCFAJ(DAINLFIMLIH: false) == 164)
		{
			NewTutorialManager.instance.ObjectiveCompleted(1);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(AOLKDFMLJKB));
			FHJBMLINFHM = false;
			DNAHJLGIMGA();
		}
	}

	public override void SetUp()
	{
		base.SetUp();
		((MonoBehaviour)this).StartCoroutine(PBEKBJIJFDK());
	}

	private void BJGGMNLHDLA(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.IMCJPECAAPC(DAINLFIMLIH: false) == 108)
		{
			NewTutorialManager.instance.ObjectiveCompleted(7, BLJPGJKOLNF: false);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(BJGGMNLHDLA));
			FHJBMLINFHM = false;
			OPKCILHKIBJ();
		}
	}

	private IEnumerator CPCGNMPLFHM()
	{
		return new ANHGEEIMBNP(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator GFHACKMNCLO()
	{
		yield return CommonReferences.wait1;
		NewTutorialManager instance = NewTutorialManager.instance;
		instance.ObjectivesUpdated = (Action)Delegate.Remove(instance.ObjectivesUpdated, new Action(EFCMMONCGCP));
		bool tableFound = false;
		bool hornoFound = false;
		for (int i = 0; i < PlaceablesManager.GGFJGHHHEJC.currentPlaceables.Count; i++)
		{
			if (!PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].CCIKENEGHCA)
			{
				continue;
			}
			if (PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].itemSetup.item.JDJGFAACPFC() == 704 && !hornoFound)
			{
				hornoFound = true;
				NewTutorialManager.instance.ObjectiveCompleted(0);
				if (tableFound && hornoFound)
				{
					break;
				}
				yield return CommonReferences.wait05;
			}
			if (PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].itemSetup.item.JDJGFAACPFC() == 728 && !tableFound)
			{
				tableFound = true;
				CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
				instance2.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(instance2.OnPlaceablePlaced, new Action<int, Placeable>(PDJGPNDJDNF));
				NewTutorialManager.instance.ObjectiveCompleted(1);
				KJKKJDDMMKH = true;
				DNAHJLGIMGA();
				if (tableFound && hornoFound)
				{
					break;
				}
				yield return CommonReferences.wait05;
			}
		}
	}

	private IEnumerator OHFHKAENGBL()
	{
		yield return CommonReferences.wait1;
		NewTutorialManager instance = NewTutorialManager.instance;
		instance.ObjectivesUpdated = (Action)Delegate.Remove(instance.ObjectivesUpdated, new Action(EFCMMONCGCP));
		bool tableFound = false;
		bool hornoFound = false;
		for (int i = 0; i < PlaceablesManager.GGFJGHHHEJC.currentPlaceables.Count; i++)
		{
			if (!PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].CCIKENEGHCA)
			{
				continue;
			}
			if (PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].itemSetup.item.JDJGFAACPFC() == 704 && !hornoFound)
			{
				hornoFound = true;
				NewTutorialManager.instance.ObjectiveCompleted(0);
				if (tableFound && hornoFound)
				{
					break;
				}
				yield return CommonReferences.wait05;
			}
			if (PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].itemSetup.item.JDJGFAACPFC() == 728 && !tableFound)
			{
				tableFound = true;
				CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
				instance2.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(instance2.OnPlaceablePlaced, new Action<int, Placeable>(PDJGPNDJDNF));
				NewTutorialManager.instance.ObjectiveCompleted(1);
				KJKKJDDMMKH = true;
				DNAHJLGIMGA();
				if (tableFound && hornoFound)
				{
					break;
				}
				yield return CommonReferences.wait05;
			}
		}
	}

	private IEnumerator IGDKALONEOP()
	{
		return new JILLIBJGIIK(1)
		{
			_003C_003E4__this = this
		};
	}

	private void IENIHHLDEOK()
	{
		((MonoBehaviour)this).StartCoroutine(OGJLENOONLL());
	}

	private void JEOAFELGIDK()
	{
		((MonoBehaviour)this).StartCoroutine(HEJBDDMHOJB());
	}

	private IEnumerator HFFIGEDMMJF()
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
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T126/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		RecipesManager.UnlockRecipe(216);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Combine(instance.OnPlaceablePlaced, new Action<int, Placeable>(PDJGPNDJDNF));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Combine(instance2.OnRecipeToCraftAdded, new Action<int, Recipe>(EECHIAJHKLD));
		NewTutorialManager instance3 = NewTutorialManager.instance;
		instance3.ObjectivesUpdated = (Action)Delegate.Combine(instance3.ObjectivesUpdated, new Action(EFCMMONCGCP));
	}

	private void EFCMMONCGCP()
	{
		((MonoBehaviour)this).StartCoroutine(OHFHKAENGBL());
	}

	private void BKEDHEBIEBN()
	{
		((MonoBehaviour)this).StartCoroutine(GFHACKMNCLO());
	}

	private void EECHIAJHKLD(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.JDJGFAACPFC() == 1043)
		{
			NewTutorialManager.instance.ObjectiveCompleted(2);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(EECHIAJHKLD));
			FHJBMLINFHM = true;
			DNAHJLGIMGA();
		}
	}

	private IEnumerator HFMMNGELPGN()
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
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T126/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		RecipesManager.UnlockRecipe(216);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Combine(instance.OnPlaceablePlaced, new Action<int, Placeable>(PDJGPNDJDNF));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Combine(instance2.OnRecipeToCraftAdded, new Action<int, Recipe>(EECHIAJHKLD));
		NewTutorialManager instance3 = NewTutorialManager.instance;
		instance3.ObjectivesUpdated = (Action)Delegate.Combine(instance3.ObjectivesUpdated, new Action(EFCMMONCGCP));
	}

	private IEnumerator HPNEFMANGHJ()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator HNFCACDCBBO()
	{
		return new OJILAJIDNBE(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator KNBNIMCHKIE()
	{
		return new OJILAJIDNBE(1)
		{
			_003C_003E4__this = this
		};
	}

	private void IPNJGNJAJLF(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.IMCJPECAAPC() == 80)
		{
			NewTutorialManager.instance.ObjectiveCompleted(2, BLJPGJKOLNF: false);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(EMFGFEKLLCO));
			FHJBMLINFHM = true;
			PAGLLIDOLCA();
		}
	}

	private IEnumerator CAKPGBAIIPI()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator EAIFKHKDDEI()
	{
		return new ANHGEEIMBNP(1)
		{
			_003C_003E4__this = this
		};
	}

	private void GCOLDIJIENM(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.JGHNDJBCFAJ(DAINLFIMLIH: false) == 47)
		{
			NewTutorialManager.instance.FOIOHOGACAL(8, BLJPGJKOLNF: false);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(commonReferences.OnRecipeToCraftAdded, new Action<int, Recipe>(JDDNCIDFMFE));
			FHJBMLINFHM = false;
			DFGLGMOEJIE();
		}
	}

	private void NDCLJJIJBIO()
	{
		((MonoBehaviour)this).StartCoroutine(DOLNMFALDFP());
	}

	private IEnumerator HHDLDPPCLPE()
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
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T126/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		RecipesManager.UnlockRecipe(216);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Combine(instance.OnPlaceablePlaced, new Action<int, Placeable>(PDJGPNDJDNF));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Combine(instance2.OnRecipeToCraftAdded, new Action<int, Recipe>(EECHIAJHKLD));
		NewTutorialManager instance3 = NewTutorialManager.instance;
		instance3.ObjectivesUpdated = (Action)Delegate.Combine(instance3.ObjectivesUpdated, new Action(EFCMMONCGCP));
	}

	private void CBAHONLGBMJ(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		if (EAPCLAODGAE.itemSetup.item.IMCJPECAAPC(DAINLFIMLIH: false) == 153)
		{
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
		}
		if (EAPCLAODGAE.itemSetup.item.JPNFKDMFKMC() == 182)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(instance.OnPlaceablePlaced, new Action<int, Placeable>(DGCANPHFGFP));
			NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			KJKKJDDMMKH = false;
			MJFJDGMEJMF();
		}
	}

	private void ADDFKJJPBIG()
	{
		if (FHJBMLINFHM && KJKKJDDMMKH)
		{
			((MonoBehaviour)this).StartCoroutine(FLECFIDDCJE());
		}
	}

	private IEnumerator JAHNJFGKFII()
	{
		return new ANHGEEIMBNP(1)
		{
			_003C_003E4__this = this
		};
	}

	private void JDFMFKBHMBE(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		if (EAPCLAODGAE.itemSetup.item.CIGFGKKCPCK(DAINLFIMLIH: false) == 20)
		{
			NewTutorialManager.instance.FOIOHOGACAL(0);
		}
		if (EAPCLAODGAE.itemSetup.item.ODENMDOJPLC(DAINLFIMLIH: false) == 43)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(commonReferences.OnPlaceablePlaced, new Action<int, Placeable>(PKMLHDCBCDC));
			NewTutorialManager.instance.ObjectiveCompleted(0);
			KJKKJDDMMKH = false;
			NDGMLHGNCOE();
		}
	}

	private IEnumerator PODJKKLFLOM()
	{
		yield return CommonReferences.wait1;
		NewTutorialManager instance = NewTutorialManager.instance;
		instance.ObjectivesUpdated = (Action)Delegate.Remove(instance.ObjectivesUpdated, new Action(EFCMMONCGCP));
		bool tableFound = false;
		bool hornoFound = false;
		for (int i = 0; i < PlaceablesManager.GGFJGHHHEJC.currentPlaceables.Count; i++)
		{
			if (!PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].CCIKENEGHCA)
			{
				continue;
			}
			if (PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].itemSetup.item.JDJGFAACPFC() == 704 && !hornoFound)
			{
				hornoFound = true;
				NewTutorialManager.instance.ObjectiveCompleted(0);
				if (tableFound && hornoFound)
				{
					break;
				}
				yield return CommonReferences.wait05;
			}
			if (PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].itemSetup.item.JDJGFAACPFC() == 728 && !tableFound)
			{
				tableFound = true;
				CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
				instance2.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(instance2.OnPlaceablePlaced, new Action<int, Placeable>(PDJGPNDJDNF));
				NewTutorialManager.instance.ObjectiveCompleted(1);
				KJKKJDDMMKH = true;
				DNAHJLGIMGA();
				if (tableFound && hornoFound)
				{
					break;
				}
				yield return CommonReferences.wait05;
			}
		}
	}

	private void EFCBCJIECID(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		if (EAPCLAODGAE.itemSetup.item.JPNFKDMFKMC(DAINLFIMLIH: false) == -67)
		{
			NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
		}
		if (EAPCLAODGAE.itemSetup.item.ODENMDOJPLC() == -19)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(instance.OnPlaceablePlaced, new Action<int, Placeable>(EDDOICNAINH));
			NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			KJKKJDDMMKH = false;
			MJFJDGMEJMF();
		}
	}

	private void DNAHJLGIMGA()
	{
		if (FHJBMLINFHM && KJKKJDDMMKH)
		{
			((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
		}
	}

	private IEnumerator DBCADKNONKE()
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
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T126/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		RecipesManager.UnlockRecipe(216);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Combine(instance.OnPlaceablePlaced, new Action<int, Placeable>(PDJGPNDJDNF));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Combine(instance2.OnRecipeToCraftAdded, new Action<int, Recipe>(EECHIAJHKLD));
		NewTutorialManager instance3 = NewTutorialManager.instance;
		instance3.ObjectivesUpdated = (Action)Delegate.Combine(instance3.ObjectivesUpdated, new Action(EFCMMONCGCP));
	}

	private void KFAHNFGFFHF()
	{
		((MonoBehaviour)this).StartCoroutine(GOJPFDDMNIJ());
	}

	private IEnumerator POIFFBFDBDI()
	{
		yield return CommonReferences.wait1;
		NewTutorialManager instance = NewTutorialManager.instance;
		instance.ObjectivesUpdated = (Action)Delegate.Remove(instance.ObjectivesUpdated, new Action(EFCMMONCGCP));
		bool tableFound = false;
		bool hornoFound = false;
		for (int i = 0; i < PlaceablesManager.GGFJGHHHEJC.currentPlaceables.Count; i++)
		{
			if (!PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].CCIKENEGHCA)
			{
				continue;
			}
			if (PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].itemSetup.item.JDJGFAACPFC() == 704 && !hornoFound)
			{
				hornoFound = true;
				NewTutorialManager.instance.ObjectiveCompleted(0);
				if (tableFound && hornoFound)
				{
					break;
				}
				yield return CommonReferences.wait05;
			}
			if (PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].itemSetup.item.JDJGFAACPFC() == 728 && !tableFound)
			{
				tableFound = true;
				CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
				instance2.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(instance2.OnPlaceablePlaced, new Action<int, Placeable>(PDJGPNDJDNF));
				NewTutorialManager.instance.ObjectiveCompleted(1);
				KJKKJDDMMKH = true;
				DNAHJLGIMGA();
				if (tableFound && hornoFound)
				{
					break;
				}
				yield return CommonReferences.wait05;
			}
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
		yield return CommonReferences.wait1;
		if (loadedFromSave)
		{
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T126/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		RecipesManager.UnlockRecipe(216);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Combine(instance.OnPlaceablePlaced, new Action<int, Placeable>(PDJGPNDJDNF));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Combine(instance2.OnRecipeToCraftAdded, new Action<int, Recipe>(EECHIAJHKLD));
		NewTutorialManager instance3 = NewTutorialManager.instance;
		instance3.ObjectivesUpdated = (Action)Delegate.Combine(instance3.ObjectivesUpdated, new Action(EFCMMONCGCP));
	}

	private IEnumerator JBNDNEDNPIE()
	{
		return new JILLIBJGIIK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LPNNMDOPCCJ()
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
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T126/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		RecipesManager.UnlockRecipe(216);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Combine(instance.OnPlaceablePlaced, new Action<int, Placeable>(PDJGPNDJDNF));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Combine(instance2.OnRecipeToCraftAdded, new Action<int, Recipe>(EECHIAJHKLD));
		NewTutorialManager instance3 = NewTutorialManager.instance;
		instance3.ObjectivesUpdated = (Action)Delegate.Combine(instance3.ObjectivesUpdated, new Action(EFCMMONCGCP));
	}

	private void EOAEDDOMJFG()
	{
		((MonoBehaviour)this).StartCoroutine(PEEMHMJJNAC());
	}

	private void LDMCHHMHIME()
	{
		((MonoBehaviour)this).StartCoroutine(OGJLENOONLL());
	}

	private void AOLKDFMLJKB(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.JPNFKDMFKMC(DAINLFIMLIH: false) == 131)
		{
			NewTutorialManager.instance.FOIOHOGACAL(4, BLJPGJKOLNF: false);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(PEKOCNBJLJG));
			FHJBMLINFHM = false;
			MJFJDGMEJMF();
		}
	}

	private void DFGLGMOEJIE()
	{
		if (FHJBMLINFHM && KJKKJDDMMKH)
		{
			((MonoBehaviour)this).StartCoroutine(FEEJKJJEEPO());
		}
	}

	private IEnumerator GOJPFDDMNIJ()
	{
		yield return CommonReferences.wait1;
		NewTutorialManager instance = NewTutorialManager.instance;
		instance.ObjectivesUpdated = (Action)Delegate.Remove(instance.ObjectivesUpdated, new Action(EFCMMONCGCP));
		bool tableFound = false;
		bool hornoFound = false;
		for (int i = 0; i < PlaceablesManager.GGFJGHHHEJC.currentPlaceables.Count; i++)
		{
			if (!PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].CCIKENEGHCA)
			{
				continue;
			}
			if (PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].itemSetup.item.JDJGFAACPFC() == 704 && !hornoFound)
			{
				hornoFound = true;
				NewTutorialManager.instance.ObjectiveCompleted(0);
				if (tableFound && hornoFound)
				{
					break;
				}
				yield return CommonReferences.wait05;
			}
			if (PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].itemSetup.item.JDJGFAACPFC() == 728 && !tableFound)
			{
				tableFound = true;
				CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
				instance2.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(instance2.OnPlaceablePlaced, new Action<int, Placeable>(PDJGPNDJDNF));
				NewTutorialManager.instance.ObjectiveCompleted(1);
				KJKKJDDMMKH = true;
				DNAHJLGIMGA();
				if (tableFound && hornoFound)
				{
					break;
				}
				yield return CommonReferences.wait05;
			}
		}
	}

	private void GKIGBHOJEGB(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		if (EAPCLAODGAE.itemSetup.item.JPNFKDMFKMC() == -167)
		{
			NewTutorialManager.instance.FOIOHOGACAL(0);
		}
		if (EAPCLAODGAE.itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) == -52)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(instance.OnPlaceablePlaced, new Action<int, Placeable>(CBAHONLGBMJ));
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			KJKKJDDMMKH = true;
			DNAHJLGIMGA();
		}
	}

	private IEnumerator BBGHMMLBAME()
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
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T126/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		RecipesManager.UnlockRecipe(216);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Combine(instance.OnPlaceablePlaced, new Action<int, Placeable>(PDJGPNDJDNF));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Combine(instance2.OnRecipeToCraftAdded, new Action<int, Recipe>(EECHIAJHKLD));
		NewTutorialManager instance3 = NewTutorialManager.instance;
		instance3.ObjectivesUpdated = (Action)Delegate.Combine(instance3.ObjectivesUpdated, new Action(EFCMMONCGCP));
	}

	private IEnumerator BDBMGIKGDNG()
	{
		return new ANHGEEIMBNP(1)
		{
			_003C_003E4__this = this
		};
	}

	private void GDNGJLLNJGA(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		if (EAPCLAODGAE.itemSetup.item.JGHNDJBCFAJ() == 132)
		{
			NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
		}
		if (EAPCLAODGAE.itemSetup.item.ODENMDOJPLC() == -97)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(instance.OnPlaceablePlaced, new Action<int, Placeable>(DGCANPHFGFP));
			NewTutorialManager.instance.ObjectiveCompleted(1);
			KJKKJDDMMKH = true;
			DNAHJLGIMGA();
		}
	}

	private IEnumerator IFMCECILIJB()
	{
		yield return CommonReferences.wait1;
		NewTutorialManager instance = NewTutorialManager.instance;
		instance.ObjectivesUpdated = (Action)Delegate.Remove(instance.ObjectivesUpdated, new Action(EFCMMONCGCP));
		bool tableFound = false;
		bool hornoFound = false;
		for (int i = 0; i < PlaceablesManager.GGFJGHHHEJC.currentPlaceables.Count; i++)
		{
			if (!PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].CCIKENEGHCA)
			{
				continue;
			}
			if (PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].itemSetup.item.JDJGFAACPFC() == 704 && !hornoFound)
			{
				hornoFound = true;
				NewTutorialManager.instance.ObjectiveCompleted(0);
				if (tableFound && hornoFound)
				{
					break;
				}
				yield return CommonReferences.wait05;
			}
			if (PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].itemSetup.item.JDJGFAACPFC() == 728 && !tableFound)
			{
				tableFound = true;
				CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
				instance2.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(instance2.OnPlaceablePlaced, new Action<int, Placeable>(PDJGPNDJDNF));
				NewTutorialManager.instance.ObjectiveCompleted(1);
				KJKKJDDMMKH = true;
				DNAHJLGIMGA();
				if (tableFound && hornoFound)
				{
					break;
				}
				yield return CommonReferences.wait05;
			}
		}
	}

	private IEnumerator OGJLENOONLL()
	{
		yield return CommonReferences.wait1;
		NewTutorialManager instance = NewTutorialManager.instance;
		instance.ObjectivesUpdated = (Action)Delegate.Remove(instance.ObjectivesUpdated, new Action(EFCMMONCGCP));
		bool tableFound = false;
		bool hornoFound = false;
		for (int i = 0; i < PlaceablesManager.GGFJGHHHEJC.currentPlaceables.Count; i++)
		{
			if (!PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].CCIKENEGHCA)
			{
				continue;
			}
			if (PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].itemSetup.item.JDJGFAACPFC() == 704 && !hornoFound)
			{
				hornoFound = true;
				NewTutorialManager.instance.ObjectiveCompleted(0);
				if (tableFound && hornoFound)
				{
					break;
				}
				yield return CommonReferences.wait05;
			}
			if (PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].itemSetup.item.JDJGFAACPFC() == 728 && !tableFound)
			{
				tableFound = true;
				CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
				instance2.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(instance2.OnPlaceablePlaced, new Action<int, Placeable>(PDJGPNDJDNF));
				NewTutorialManager.instance.ObjectiveCompleted(1);
				KJKKJDDMMKH = true;
				DNAHJLGIMGA();
				if (tableFound && hornoFound)
				{
					break;
				}
				yield return CommonReferences.wait05;
			}
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
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T126/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		RecipesManager.UnlockRecipe(216);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Combine(instance.OnPlaceablePlaced, new Action<int, Placeable>(PDJGPNDJDNF));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Combine(instance2.OnRecipeToCraftAdded, new Action<int, Recipe>(EECHIAJHKLD));
		NewTutorialManager instance3 = NewTutorialManager.instance;
		instance3.ObjectivesUpdated = (Action)Delegate.Combine(instance3.ObjectivesUpdated, new Action(EFCMMONCGCP));
	}

	private IEnumerator FEEJKJJEEPO()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator HEJBDDMHOJB()
	{
		return new JILLIBJGIIK(1)
		{
			_003C_003E4__this = this
		};
	}

	private void FEAIOFCKEPI()
	{
		((MonoBehaviour)this).StartCoroutine(IGDKALONEOP());
	}

	private void BBKEPMKBLBG()
	{
		((MonoBehaviour)this).StartCoroutine(AHENCONCNDJ());
	}

	private void KJPLCBNMOCF()
	{
		((MonoBehaviour)this).StartCoroutine(OGJLENOONLL());
	}

	private void DGCANPHFGFP(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		if (EAPCLAODGAE.itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) == 35)
		{
			NewTutorialManager.instance.ObjectiveCompleted(1);
		}
		if (EAPCLAODGAE.itemSetup.item.CIGFGKKCPCK(DAINLFIMLIH: false) == 114)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(commonReferences.OnPlaceablePlaced, new Action<int, Placeable>(CFDKIAHGKIF));
			NewTutorialManager.instance.FOIOHOGACAL(0);
			KJKKJDDMMKH = false;
			PAGLLIDOLCA();
		}
	}

	private void MJFJDGMEJMF()
	{
		if (FHJBMLINFHM && KJKKJDDMMKH)
		{
			((MonoBehaviour)this).StartCoroutine(ELNHMAPENDB());
		}
	}

	private void PKMLHDCBCDC(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		if (EAPCLAODGAE.itemSetup.item.IMCJPECAAPC(DAINLFIMLIH: false) == 25)
		{
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
		}
		if (EAPCLAODGAE.itemSetup.item.JDJGFAACPFC() == -85)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(commonReferences.OnPlaceablePlaced, new Action<int, Placeable>(LBMOFGIEPCP));
			NewTutorialManager.instance.FOIOHOGACAL(0);
			KJKKJDDMMKH = false;
			OPKCILHKIBJ();
		}
	}

	private IEnumerator PEEMHMJJNAC()
	{
		yield return CommonReferences.wait1;
		NewTutorialManager instance = NewTutorialManager.instance;
		instance.ObjectivesUpdated = (Action)Delegate.Remove(instance.ObjectivesUpdated, new Action(EFCMMONCGCP));
		bool tableFound = false;
		bool hornoFound = false;
		for (int i = 0; i < PlaceablesManager.GGFJGHHHEJC.currentPlaceables.Count; i++)
		{
			if (!PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].CCIKENEGHCA)
			{
				continue;
			}
			if (PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].itemSetup.item.JDJGFAACPFC() == 704 && !hornoFound)
			{
				hornoFound = true;
				NewTutorialManager.instance.ObjectiveCompleted(0);
				if (tableFound && hornoFound)
				{
					break;
				}
				yield return CommonReferences.wait05;
			}
			if (PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].itemSetup.item.JDJGFAACPFC() == 728 && !tableFound)
			{
				tableFound = true;
				CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
				instance2.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(instance2.OnPlaceablePlaced, new Action<int, Placeable>(PDJGPNDJDNF));
				NewTutorialManager.instance.ObjectiveCompleted(1);
				KJKKJDDMMKH = true;
				DNAHJLGIMGA();
				if (tableFound && hornoFound)
				{
					break;
				}
				yield return CommonReferences.wait05;
			}
		}
	}

	public override int GetID()
	{
		return 126;
	}

	private void BBCGLNCMFIN()
	{
		((MonoBehaviour)this).StartCoroutine(HEJBDDMHOJB());
	}

	private void PGDHNCDBKKL(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.IMCJPECAAPC(DAINLFIMLIH: false) == -39)
		{
			NewTutorialManager.instance.ObjectiveCompleted(1);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(instance.OnRecipeToCraftAdded, new Action<int, Recipe>(PEKOCNBJLJG));
			FHJBMLINFHM = true;
			PAGLLIDOLCA();
		}
	}

	private IEnumerator AJJPECIKMJN()
	{
		return new OJILAJIDNBE(1)
		{
			_003C_003E4__this = this
		};
	}

	private void EDDOICNAINH(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		if (EAPCLAODGAE.itemSetup.item.JGHNDJBCFAJ() == -189)
		{
			NewTutorialManager.instance.ObjectiveCompleted(0);
		}
		if (EAPCLAODGAE.itemSetup.item.JDJGFAACPFC() == -62)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(commonReferences.OnPlaceablePlaced, new Action<int, Placeable>(CBAHONLGBMJ));
			NewTutorialManager.instance.FOIOHOGACAL(0);
			KJKKJDDMMKH = false;
			DFGLGMOEJIE();
		}
	}

	private IEnumerator KFKGKKAINLL()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private void DMMOMMIEHHA(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		if (EAPCLAODGAE.itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) == -142)
		{
			NewTutorialManager.instance.FOIOHOGACAL(0);
		}
		if (EAPCLAODGAE.itemSetup.item.JGHNDJBCFAJ() == 66)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(commonReferences.OnPlaceablePlaced, new Action<int, Placeable>(PKMLHDCBCDC));
			NewTutorialManager.instance.ObjectiveCompleted(1);
			KJKKJDDMMKH = false;
			DMIPFFMPPFA();
		}
	}

	private void NDGMLHGNCOE()
	{
		if (FHJBMLINFHM && KJKKJDDMMKH)
		{
			((MonoBehaviour)this).StartCoroutine(KNBNIMCHKIE());
		}
	}

	private IEnumerator FLECFIDDCJE()
	{
		return new OJILAJIDNBE(1)
		{
			_003C_003E4__this = this
		};
	}

	private void EDCKJGPKACP()
	{
		((MonoBehaviour)this).StartCoroutine(POIFFBFDBDI());
	}

	private void JDDNCIDFMFE(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.JPNFKDMFKMC() == 179)
		{
			NewTutorialManager.instance.ObjectiveCompleted(7);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(commonReferences.OnRecipeToCraftAdded, new Action<int, Recipe>(PGDHNCDBKKL));
			FHJBMLINFHM = true;
			OPKCILHKIBJ();
		}
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
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T126/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		RecipesManager.UnlockRecipe(216);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Combine(instance.OnPlaceablePlaced, new Action<int, Placeable>(PDJGPNDJDNF));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Combine(instance2.OnRecipeToCraftAdded, new Action<int, Recipe>(EECHIAJHKLD));
		NewTutorialManager instance3 = NewTutorialManager.instance;
		instance3.ObjectivesUpdated = (Action)Delegate.Combine(instance3.ObjectivesUpdated, new Action(EFCMMONCGCP));
	}

	private void HOJALJIPLJP(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		if (EAPCLAODGAE.itemSetup.item.JPNFKDMFKMC() == 61)
		{
			NewTutorialManager.instance.FOIOHOGACAL(1);
		}
		if (EAPCLAODGAE.itemSetup.item.JPNFKDMFKMC() == -76)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(instance.OnPlaceablePlaced, new Action<int, Placeable>(LBMOFGIEPCP));
			NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			KJKKJDDMMKH = true;
			ADDFKJJPBIG();
		}
	}

	private void IOFBGMLHMJP()
	{
		((MonoBehaviour)this).StartCoroutine(AHENCONCNDJ());
	}

	private void LPKGHENPHHC()
	{
		((MonoBehaviour)this).StartCoroutine(IFMCECILIJB());
	}

	private void PDJGPNDJDNF(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		if (EAPCLAODGAE.itemSetup.item.JDJGFAACPFC() == 704)
		{
			NewTutorialManager.instance.ObjectiveCompleted(0);
		}
		if (EAPCLAODGAE.itemSetup.item.JDJGFAACPFC() == 728)
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(instance.OnPlaceablePlaced, new Action<int, Placeable>(PDJGPNDJDNF));
			NewTutorialManager.instance.ObjectiveCompleted(1);
			KJKKJDDMMKH = true;
			DNAHJLGIMGA();
		}
	}

	private IEnumerator LHDDHIJIFCN()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private void DMIPFFMPPFA()
	{
		if (FHJBMLINFHM && KJKKJDDMMKH)
		{
			((MonoBehaviour)this).StartCoroutine(ELNHMAPENDB());
		}
	}

	private void OKHLMNGJOND(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.JGHNDJBCFAJ(DAINLFIMLIH: false) == -166)
		{
			NewTutorialManager.instance.ObjectiveCompleted(2);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(commonReferences.OnRecipeToCraftAdded, new Action<int, Recipe>(PEKOCNBJLJG));
			FHJBMLINFHM = false;
			DMIPFFMPPFA();
		}
	}

	private IEnumerator AJJHBJHCACM()
	{
		return new ANHGEEIMBNP(1)
		{
			_003C_003E4__this = this
		};
	}

	private void HPEMNMOEDEA(int JIIGOACEIKL, Placeable EAPCLAODGAE)
	{
		if (EAPCLAODGAE.itemSetup.item.IMCJPECAAPC() == -60)
		{
			NewTutorialManager.instance.FOIOHOGACAL(1);
		}
		if (EAPCLAODGAE.itemSetup.item.JDJGFAACPFC() == -194)
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Remove(commonReferences.OnPlaceablePlaced, new Action<int, Placeable>(JDFMFKBHMBE));
			NewTutorialManager.instance.FOIOHOGACAL(0);
			KJKKJDDMMKH = false;
			PAGLLIDOLCA();
		}
	}

	private void PAGLLIDOLCA()
	{
		if (FHJBMLINFHM && KJKKJDDMMKH)
		{
			((MonoBehaviour)this).StartCoroutine(FLECFIDDCJE());
		}
	}

	private IEnumerator ELNHMAPENDB()
	{
		return new OJILAJIDNBE(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NLCIHJDPGFE()
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
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T126/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		RecipesManager.UnlockRecipe(216);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceablePlaced = (Action<int, Placeable>)Delegate.Combine(instance.OnPlaceablePlaced, new Action<int, Placeable>(PDJGPNDJDNF));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Combine(instance2.OnRecipeToCraftAdded, new Action<int, Recipe>(EECHIAJHKLD));
		NewTutorialManager instance3 = NewTutorialManager.instance;
		instance3.ObjectivesUpdated = (Action)Delegate.Combine(instance3.ObjectivesUpdated, new Action(EFCMMONCGCP));
	}

	private IEnumerator OBCHIKLEMKF()
	{
		return new ANHGEEIMBNP(1)
		{
			_003C_003E4__this = this
		};
	}

	private void JIOMCACHOCM(int JIIGOACEIKL, Recipe MEMGMDOCBOJ)
	{
		if (MEMGMDOCBOJ.output.item.CIGFGKKCPCK(DAINLFIMLIH: false) == -9)
		{
			NewTutorialManager.instance.FOIOHOGACAL(5);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnRecipeToCraftAdded = (Action<int, Recipe>)Delegate.Remove(commonReferences.OnRecipeToCraftAdded, new Action<int, Recipe>(GCOLDIJIENM));
			FHJBMLINFHM = false;
			DMIPFFMPPFA();
		}
	}

	private IEnumerator CKIMLLCOEGC()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private void NBGMAABMLEB()
	{
		((MonoBehaviour)this).StartCoroutine(IGDKALONEOP());
	}
}
