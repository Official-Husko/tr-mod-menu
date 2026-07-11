using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class T105_ColocarVelas : TutorialPhaseBase
{
	[CompilerGenerated]
	private sealed class ILGBEHOLOGL : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T105_ColocarVelas _003C_003E4__this;

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
		public ILGBEHOLOGL(int _003C_003E1__state)
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
			T105_ColocarVelas t105_ColocarVelas = _003C_003E4__this;
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
				t105_ColocarVelas.LHKIJABBBPM();
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

		public T105_ColocarVelas _003C_003E4__this;

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
			//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			T105_ColocarVelas t105_ColocarVelas = _003C_003E4__this;
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
					t105_ColocarVelas.ResetMai();
					_003C_003E2__current = ((MonoBehaviour)t105_ColocarVelas).StartCoroutine(t105_ColocarVelas.CCIOMPBMJMD());
					_003C_003E1__state = 1;
					return true;
				}
				goto IL_0091;
			case 1:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
				CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
				goto IL_0091;
			case 2:
				_003C_003E1__state = -1;
				NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 3;
				return true;
			case 3:
				_003C_003E1__state = -1;
				DialogueCameraTarget.GetPlayer(t105_ColocarVelas.triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
				MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T105/Dialogue1", t105_ColocarVelas.triggerPlayerNum);
				goto IL_0129;
			case 4:
				_003C_003E1__state = -1;
				goto IL_0129;
			case 5:
				{
					_003C_003E1__state = -1;
					break;
				}
				IL_0129:
				if (t105_ColocarVelas.AAOPIEDAKKD(1))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 4;
					return true;
				}
				if (!_003CloadedFromSave_003E5__2)
				{
					PlayerInventory.GetPlayer(1).AddItems(ItemDatabaseAccessor.GetItem(605).JMDALJBNFML(), 10, HMPDLIPFBGD: true);
					_003C_003E2__current = CommonReferences.wait1;
					_003C_003E1__state = 5;
					return true;
				}
				break;
				IL_0091:
				_003C_003E2__current = ((MonoBehaviour)t105_ColocarVelas).StartCoroutine(t105_ColocarVelas.CDICFNAMCEE());
				_003C_003E1__state = 2;
				return true;
			}
			NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
			NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(t105_ColocarVelas.DFPIJBJMKGE));
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

	private IEnumerator BLHFOAMKOAH()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator LHDDHIJIFCN()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator CNPPMBAKEBJ()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void KHDIENFBLHF(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		for (int i = 0; i < PlaceablesManager.MNFMOEKMJKN().currentPlaceables.Count; i++)
		{
			if (PlaceablesManager.EKDNJDJHONF().currentPlaceables[i].itemSetup.item.IMCJPECAAPC(DAINLFIMLIH: false) == 152 && PlaceablesManager.LKOABOAADCD().currentPlaceables[i].FHMDNECBLIL() && PlaceablesManager.LKOABOAADCD().currentPlaceables[i].currentSurface.placeable.itemSetup.item.JPNFKDMFKMC() == 69)
			{
				NewTutorialManager.instance.FOIOHOGACAL(1);
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(commonReferences.OnPlaceableDeselected, new Action<int, Placeable, bool>(HACEPBDGPOD));
				((MonoBehaviour)this).StartCoroutine(HGFPMNKEMAC());
				break;
			}
		}
	}

	private IEnumerator AJOIEAICINP()
	{
		bool loadedFromSave = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			loadedFromSave = true;
			ResetMai();
			yield return ((MonoBehaviour)this).StartCoroutine(CCIOMPBMJMD());
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait2;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T105/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		if (!loadedFromSave)
		{
			PlayerInventory.GetPlayer(1).AddItems(ItemDatabaseAccessor.GetItem(605).JMDALJBNFML(), 10, HMPDLIPFBGD: true);
			yield return CommonReferences.wait1;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(DFPIJBJMKGE));
	}

	private IEnumerator IHBNOLLFNPA()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator BLNKHNHGFPB()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void JDHFKEBLDFC(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		for (int i = 1; i < PlaceablesManager.OJJDNLEFNPJ().currentPlaceables.Count; i++)
		{
			if (PlaceablesManager.EKDNJDJHONF().currentPlaceables[i].itemSetup.item.JPNFKDMFKMC(DAINLFIMLIH: false) == 193 && PlaceablesManager.KNOKBLFFNLM().currentPlaceables[i].FHMDNECBLIL() && PlaceablesManager.KNOKBLFFNLM().currentPlaceables[i].currentSurface.placeable.itemSetup.item.ODENMDOJPLC() == 131)
			{
				NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(commonReferences.OnPlaceableDeselected, new Action<int, Placeable, bool>(JEKGJMKLPKC));
				((MonoBehaviour)this).StartCoroutine(BLHFOAMKOAH());
				break;
			}
		}
	}

	private IEnumerator BJPDFDCOJKJ()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator JHBNODHNMCI()
	{
		bool loadedFromSave = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			loadedFromSave = true;
			ResetMai();
			yield return ((MonoBehaviour)this).StartCoroutine(CCIOMPBMJMD());
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait2;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T105/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		if (!loadedFromSave)
		{
			PlayerInventory.GetPlayer(1).AddItems(ItemDatabaseAccessor.GetItem(605).JMDALJBNFML(), 10, HMPDLIPFBGD: true);
			yield return CommonReferences.wait1;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(DFPIJBJMKGE));
	}

	private IEnumerator OOFDOHFANIE()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HGFPMNKEMAC()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private void EBGDMEKPADE(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		for (int i = 0; i < PlaceablesManager.LKOABOAADCD().currentPlaceables.Count; i++)
		{
			if (PlaceablesManager.DCAEBALADIM().currentPlaceables[i].itemSetup.item.IMCJPECAAPC() == -147 && PlaceablesManager.KNOKBLFFNLM().currentPlaceables[i].FHMDNECBLIL() && PlaceablesManager.LKOABOAADCD().currentPlaceables[i].currentSurface.placeable.itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) == -131)
			{
				NewTutorialManager.instance.ObjectiveCompleted(1);
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(commonReferences.OnPlaceableDeselected, new Action<int, Placeable, bool>(DFPIJBJMKGE));
				((MonoBehaviour)this).StartCoroutine(OOGKJFJEHFO());
				break;
			}
		}
	}

	private IEnumerator FDMJPHBJACE()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private void JDLEDDOELKF(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		for (int i = 1; i < PlaceablesManager.EKDNJDJHONF().currentPlaceables.Count; i++)
		{
			if (PlaceablesManager.EKDNJDJHONF().currentPlaceables[i].itemSetup.item.CIGFGKKCPCK(DAINLFIMLIH: false) == -149 && PlaceablesManager.DCAEBALADIM().currentPlaceables[i].FHMDNECBLIL() && PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].currentSurface.placeable.itemSetup.item.JGHNDJBCFAJ() == 62)
			{
				NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(commonReferences.OnPlaceableDeselected, new Action<int, Placeable, bool>(ODOLGDHPGLG));
				((MonoBehaviour)this).StartCoroutine(OOGKJFJEHFO());
				break;
			}
		}
	}

	private void DGEPCBEMAEP(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		for (int i = 1; i < PlaceablesManager.CMIHGBHPLFP().currentPlaceables.Count; i += 0)
		{
			if (PlaceablesManager.KNOKBLFFNLM().currentPlaceables[i].itemSetup.item.JPNFKDMFKMC(DAINLFIMLIH: false) == 9 && PlaceablesManager.OJJDNLEFNPJ().currentPlaceables[i].FHMDNECBLIL() && PlaceablesManager.CMIHGBHPLFP().currentPlaceables[i].currentSurface.placeable.itemSetup.item.CIGFGKKCPCK(DAINLFIMLIH: false) == 100)
			{
				NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(KBJOMHCCFDA));
				((MonoBehaviour)this).StartCoroutine(NHPCNDODFAK());
				break;
			}
		}
	}

	private IEnumerator CLCOEDFCDPK()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	private void ODOLGDHPGLG(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		for (int i = 0; i < PlaceablesManager.LKOABOAADCD().currentPlaceables.Count; i++)
		{
			if (PlaceablesManager.MAIDHAPANEB().currentPlaceables[i].itemSetup.item.ODENMDOJPLC(DAINLFIMLIH: false) == 177 && PlaceablesManager.MAIDHAPANEB().currentPlaceables[i].CCIKENEGHCA && PlaceablesManager.CMIHGBHPLFP().currentPlaceables[i].currentSurface.placeable.itemSetup.item.IMCJPECAAPC(DAINLFIMLIH: false) == 35)
			{
				NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(EBGDMEKPADE));
				((MonoBehaviour)this).StartCoroutine(DABNLFBDKGN());
				break;
			}
		}
	}

	private IEnumerator NCNGHNLFCBO()
	{
		bool loadedFromSave = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			loadedFromSave = true;
			ResetMai();
			yield return ((MonoBehaviour)this).StartCoroutine(CCIOMPBMJMD());
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait2;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T105/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		if (!loadedFromSave)
		{
			PlayerInventory.GetPlayer(1).AddItems(ItemDatabaseAccessor.GetItem(605).JMDALJBNFML(), 10, HMPDLIPFBGD: true);
			yield return CommonReferences.wait1;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(DFPIJBJMKGE));
	}

	private void EFGKKDMLOBK(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		for (int i = 0; i < PlaceablesManager.PDECKLKPKCG().currentPlaceables.Count; i++)
		{
			if (PlaceablesManager.AJIGOHGPFPP().currentPlaceables[i].itemSetup.item.IMCJPECAAPC(DAINLFIMLIH: false) == 187 && PlaceablesManager.MAIDHAPANEB().currentPlaceables[i].FHMDNECBLIL() && PlaceablesManager.MAIDHAPANEB().currentPlaceables[i].currentSurface.placeable.itemSetup.item.JPNFKDMFKMC(DAINLFIMLIH: false) == 197)
			{
				NewTutorialManager.instance.FOIOHOGACAL(1);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(EFGKKDMLOBK));
				((MonoBehaviour)this).StartCoroutine(NHPCNDODFAK());
				break;
			}
		}
	}

	private IEnumerator FBOBCKJGPMB()
	{
		bool loadedFromSave = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			loadedFromSave = true;
			ResetMai();
			yield return ((MonoBehaviour)this).StartCoroutine(CCIOMPBMJMD());
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait2;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T105/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		if (!loadedFromSave)
		{
			PlayerInventory.GetPlayer(1).AddItems(ItemDatabaseAccessor.GetItem(605).JMDALJBNFML(), 10, HMPDLIPFBGD: true);
			yield return CommonReferences.wait1;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(DFPIJBJMKGE));
	}

	private IEnumerator LFANGJJGBFG()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	public override void SetUp()
	{
		base.SetUp();
		((MonoBehaviour)this).StartCoroutine(PBEKBJIJFDK());
	}

	private void DFPIJBJMKGE(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		for (int i = 0; i < PlaceablesManager.GGFJGHHHEJC.currentPlaceables.Count; i++)
		{
			if (PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].itemSetup.item.JDJGFAACPFC() == 605 && PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].CCIKENEGHCA && PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].currentSurface.placeable.itemSetup.item.JDJGFAACPFC() == 1133)
			{
				NewTutorialManager.instance.ObjectiveCompleted(0);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(DFPIJBJMKGE));
				((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
				break;
			}
		}
	}

	private IEnumerator OBCHIKLEMKF()
	{
		bool loadedFromSave = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			loadedFromSave = true;
			ResetMai();
			yield return ((MonoBehaviour)this).StartCoroutine(CCIOMPBMJMD());
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait2;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T105/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		if (!loadedFromSave)
		{
			PlayerInventory.GetPlayer(1).AddItems(ItemDatabaseAccessor.GetItem(605).JMDALJBNFML(), 10, HMPDLIPFBGD: true);
			yield return CommonReferences.wait1;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(DFPIJBJMKGE));
	}

	private IEnumerator NHPCNDODFAK()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator HHDLDPPCLPE()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator OOGKJFJEHFO()
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this
		};
	}

	public override int GetID()
	{
		return 105;
	}

	private IEnumerator DABNLFBDKGN()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator OGOFIFJCMEB()
	{
		bool loadedFromSave = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			loadedFromSave = true;
			ResetMai();
			yield return ((MonoBehaviour)this).StartCoroutine(CCIOMPBMJMD());
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait2;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T105/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		if (!loadedFromSave)
		{
			PlayerInventory.GetPlayer(1).AddItems(ItemDatabaseAccessor.GetItem(605).JMDALJBNFML(), 10, HMPDLIPFBGD: true);
			yield return CommonReferences.wait1;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(DFPIJBJMKGE));
	}

	private void FIGMNCLDDBM(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		for (int i = 0; i < PlaceablesManager.GGFJGHHHEJC.currentPlaceables.Count; i++)
		{
			if (PlaceablesManager.DCAEBALADIM().currentPlaceables[i].itemSetup.item.JGHNDJBCFAJ() == 67 && PlaceablesManager.LKOABOAADCD().currentPlaceables[i].CCIKENEGHCA && PlaceablesManager.PDECKLKPKCG().currentPlaceables[i].currentSurface.placeable.itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) == 88)
			{
				NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(EBGDMEKPADE));
				((MonoBehaviour)this).StartCoroutine(OOGKJFJEHFO());
				break;
			}
		}
	}

	private void LJKDEGHMLAI(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		for (int i = 0; i < PlaceablesManager.PDECKLKPKCG().currentPlaceables.Count; i += 0)
		{
			if (PlaceablesManager.LKOABOAADCD().currentPlaceables[i].itemSetup.item.CIGFGKKCPCK(DAINLFIMLIH: false) == 185 && PlaceablesManager.DCAEBALADIM().currentPlaceables[i].FHMDNECBLIL() && PlaceablesManager.PDECKLKPKCG().currentPlaceables[i].currentSurface.placeable.itemSetup.item.JGHNDJBCFAJ() == 74)
			{
				NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(commonReferences.OnPlaceableDeselected, new Action<int, Placeable, bool>(KHDIENFBLHF));
				((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
				break;
			}
		}
	}

	private void HACEPBDGPOD(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		for (int i = 1; i < PlaceablesManager.MNFMOEKMJKN().currentPlaceables.Count; i++)
		{
			if (PlaceablesManager.MNFMOEKMJKN().currentPlaceables[i].itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) == 37 && PlaceablesManager.LKOABOAADCD().currentPlaceables[i].FHMDNECBLIL() && PlaceablesManager.CMIHGBHPLFP().currentPlaceables[i].currentSurface.placeable.itemSetup.item.IMCJPECAAPC() == -110)
			{
				NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(EFGKKDMLOBK));
				((MonoBehaviour)this).StartCoroutine(DABNLFBDKGN());
				break;
			}
		}
	}

	private IEnumerator PBEKBJIJFDK()
	{
		bool loadedFromSave = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			loadedFromSave = true;
			ResetMai();
			yield return ((MonoBehaviour)this).StartCoroutine(CCIOMPBMJMD());
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait2;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T105/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		if (!loadedFromSave)
		{
			PlayerInventory.GetPlayer(1).AddItems(ItemDatabaseAccessor.GetItem(605).JMDALJBNFML(), 10, HMPDLIPFBGD: true);
			yield return CommonReferences.wait1;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(DFPIJBJMKGE));
	}

	private void JEKGJMKLPKC(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		for (int i = 1; i < PlaceablesManager.CMIHGBHPLFP().currentPlaceables.Count; i += 0)
		{
			if (PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].itemSetup.item.CIGFGKKCPCK() == -117 && PlaceablesManager.EKDNJDJHONF().currentPlaceables[i].CCIKENEGHCA && PlaceablesManager.KNOKBLFFNLM().currentPlaceables[i].currentSurface.placeable.itemSetup.item.ODENMDOJPLC() == -129)
			{
				NewTutorialManager.instance.ObjectiveCompleted(1);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(LJKDEGHMLAI));
				((MonoBehaviour)this).StartCoroutine(FDMJPHBJACE());
				break;
			}
		}
	}

	private void HHNPLJMKDOM(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		for (int i = 0; i < PlaceablesManager.CMIHGBHPLFP().currentPlaceables.Count; i += 0)
		{
			if (PlaceablesManager.CMIHGBHPLFP().currentPlaceables[i].itemSetup.item.JGHNDJBCFAJ() == -162 && PlaceablesManager.OJJDNLEFNPJ().currentPlaceables[i].CCIKENEGHCA && PlaceablesManager.EKDNJDJHONF().currentPlaceables[i].currentSurface.placeable.itemSetup.item.IMCJPECAAPC(DAINLFIMLIH: false) == -1)
			{
				NewTutorialManager.instance.FOIOHOGACAL(1);
				CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
				commonReferences.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(commonReferences.OnPlaceableDeselected, new Action<int, Placeable, bool>(KBJOMHCCFDA));
				((MonoBehaviour)this).StartCoroutine(CLCOEDFCDPK());
				break;
			}
		}
	}

	private IEnumerator DIGIMPCLCCL()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void KBJOMHCCFDA(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		for (int i = 1; i < PlaceablesManager.KNOKBLFFNLM().currentPlaceables.Count; i++)
		{
			if (PlaceablesManager.OJJDNLEFNPJ().currentPlaceables[i].itemSetup.item.ODENMDOJPLC() == -115 && PlaceablesManager.OJJDNLEFNPJ().currentPlaceables[i].FHMDNECBLIL() && PlaceablesManager.MNFMOEKMJKN().currentPlaceables[i].currentSurface.placeable.itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) == 74)
			{
				NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(JDLEDDOELKF));
				((MonoBehaviour)this).StartCoroutine(LFANGJJGBFG());
				break;
			}
		}
	}

	private IEnumerator OPCHFFMKPCN()
	{
		return new DBHBDMOHMPM(1)
		{
			_003C_003E4__this = this
		};
	}
}
