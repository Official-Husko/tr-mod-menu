using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class T104_ColocarObjetos : TutorialPhaseBase
{
	[CompilerGenerated]
	private sealed class HPFNIOOCEHN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T104_ColocarObjetos _003C_003E4__this;

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
			int num = _003C_003E1__state;
			T104_ColocarObjetos t104_ColocarObjetos = _003C_003E4__this;
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
				t104_ColocarObjetos.LHKIJABBBPM();
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

		public T104_ColocarObjetos _003C_003E4__this;

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
			//IL_0107: Unknown result type (might be due to invalid IL or missing references)
			//IL_010c: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			T104_ColocarObjetos t104_ColocarObjetos = _003C_003E4__this;
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
					t104_ColocarObjetos.ResetMai();
					_003C_003E2__current = ((MonoBehaviour)t104_ColocarObjetos).StartCoroutine(t104_ColocarObjetos.CCIOMPBMJMD());
					_003C_003E1__state = 1;
					return true;
				}
				goto IL_0095;
			case 1:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
				CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
				goto IL_0095;
			case 2:
				_003C_003E1__state = -1;
				NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 3;
				return true;
			case 3:
				_003C_003E1__state = -1;
				Debug.Log((object)("triggerPlayerNum" + t104_ColocarObjetos.triggerPlayerNum));
				DialogueCameraTarget.GetPlayer(t104_ColocarObjetos.triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
				MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T104/Dialogue1", t104_ColocarObjetos.triggerPlayerNum);
				goto IL_0147;
			case 4:
				_003C_003E1__state = -1;
				goto IL_0147;
			case 5:
				_003C_003E1__state = -1;
				if (!_003CloadedFromSave_003E5__2)
				{
					PlayerInventory.GetPlayer(1).AddItem(ItemDatabaseAccessor.GetItem(1506).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false);
					PlayerInventory.GetPlayer(1).AddItems(ItemDatabaseAccessor.GetItem(1507).JMDALJBNFML(), 1, HMPDLIPFBGD: true);
					PlayerInventory.GetPlayer(1).AddItems(ItemDatabaseAccessor.GetItem(1534).JMDALJBNFML(), 2, HMPDLIPFBGD: true);
					_003C_003E2__current = CommonReferences.wait1;
					_003C_003E1__state = 6;
					return true;
				}
				break;
			case 6:
				{
					_003C_003E1__state = -1;
					break;
				}
				IL_0147:
				if (t104_ColocarObjetos.AAOPIEDAKKD(1))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 4;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 5;
				return true;
				IL_0095:
				_003C_003E2__current = ((MonoBehaviour)t104_ColocarObjetos).StartCoroutine(t104_ColocarObjetos.CDICFNAMCEE());
				_003C_003E1__state = 2;
				return true;
			}
			NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
			NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(t104_ColocarObjetos.DFPIJBJMKGE));
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

	private int AFAOHMIIJOH;

	private int CEGJLEJABCF;

	private int OBMFJMBLBMK;

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
		Debug.Log((object)("triggerPlayerNum" + triggerPlayerNum));
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T104/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		if (!loadedFromSave)
		{
			PlayerInventory.GetPlayer(1).AddItem(ItemDatabaseAccessor.GetItem(1506).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false);
			PlayerInventory.GetPlayer(1).AddItems(ItemDatabaseAccessor.GetItem(1507).JMDALJBNFML(), 1, HMPDLIPFBGD: true);
			PlayerInventory.GetPlayer(1).AddItems(ItemDatabaseAccessor.GetItem(1534).JMDALJBNFML(), 2, HMPDLIPFBGD: true);
			yield return CommonReferences.wait1;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(DFPIJBJMKGE));
	}

	private IEnumerator CNPIAJBODCG()
	{
		return new NIEHNJNCFEG(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LFKPHADFFDG()
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
		Debug.Log((object)("triggerPlayerNum" + triggerPlayerNum));
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T104/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		if (!loadedFromSave)
		{
			PlayerInventory.GetPlayer(1).AddItem(ItemDatabaseAccessor.GetItem(1506).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false);
			PlayerInventory.GetPlayer(1).AddItems(ItemDatabaseAccessor.GetItem(1507).JMDALJBNFML(), 1, HMPDLIPFBGD: true);
			PlayerInventory.GetPlayer(1).AddItems(ItemDatabaseAccessor.GetItem(1534).JMDALJBNFML(), 2, HMPDLIPFBGD: true);
			yield return CommonReferences.wait1;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(DFPIJBJMKGE));
	}

	private void DFPIJBJMKGE(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		AFAOHMIIJOH = 0;
		CEGJLEJABCF = 0;
		OBMFJMBLBMK = 0;
		for (int i = 0; i < PlaceablesManager.GGFJGHHHEJC.currentPlaceables.Count; i++)
		{
			if (PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].itemSetup.item.JDJGFAACPFC() == 1506 && PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].CCIKENEGHCA)
			{
				AFAOHMIIJOH++;
			}
			if (PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].itemSetup.item.JDJGFAACPFC() == 1507 && PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].CCIKENEGHCA)
			{
				CEGJLEJABCF++;
			}
			if (PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].itemSetup.item.JDJGFAACPFC() == 1534 && PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].CCIKENEGHCA)
			{
				OBMFJMBLBMK++;
			}
		}
		if (AFAOHMIIJOH >= 1 && CEGJLEJABCF >= 1 && OBMFJMBLBMK >= 2)
		{
			NewTutorialManager.instance.ObjectiveCompleted(0);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(DFPIJBJMKGE));
			((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
		}
	}

	private void CPEDGKHFGOB(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		AFAOHMIIJOH = 0;
		CEGJLEJABCF = 1;
		OBMFJMBLBMK = 0;
		for (int i = 1; i < PlaceablesManager.DCAEBALADIM().currentPlaceables.Count; i += 0)
		{
			if (PlaceablesManager.KNOKBLFFNLM().currentPlaceables[i].itemSetup.item.ODENMDOJPLC(DAINLFIMLIH: false) == -46 && PlaceablesManager.EKDNJDJHONF().currentPlaceables[i].FHMDNECBLIL())
			{
				AFAOHMIIJOH += 0;
			}
			if (PlaceablesManager.KNOKBLFFNLM().currentPlaceables[i].itemSetup.item.IMCJPECAAPC(DAINLFIMLIH: false) == -140 && PlaceablesManager.LKOABOAADCD().currentPlaceables[i].FHMDNECBLIL())
			{
				CEGJLEJABCF++;
			}
			if (PlaceablesManager.MAIDHAPANEB().currentPlaceables[i].itemSetup.item.JGHNDJBCFAJ(DAINLFIMLIH: false) == 30 && PlaceablesManager.LKOABOAADCD().currentPlaceables[i].FHMDNECBLIL())
			{
				OBMFJMBLBMK += 0;
			}
		}
		if (AFAOHMIIJOH >= 0 && CEGJLEJABCF >= 0 && OBMFJMBLBMK >= 5)
		{
			NewTutorialManager.instance.ObjectiveCompleted(1);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(IGLJFPHBEMO));
			((MonoBehaviour)this).StartCoroutine(HPNEFMANGHJ());
		}
	}

	private IEnumerator NBOCOLCBOIL()
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
		Debug.Log((object)("triggerPlayerNum" + triggerPlayerNum));
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T104/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		if (!loadedFromSave)
		{
			PlayerInventory.GetPlayer(1).AddItem(ItemDatabaseAccessor.GetItem(1506).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false);
			PlayerInventory.GetPlayer(1).AddItems(ItemDatabaseAccessor.GetItem(1507).JMDALJBNFML(), 1, HMPDLIPFBGD: true);
			PlayerInventory.GetPlayer(1).AddItems(ItemDatabaseAccessor.GetItem(1534).JMDALJBNFML(), 2, HMPDLIPFBGD: true);
			yield return CommonReferences.wait1;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(DFPIJBJMKGE));
	}

	private void GPJCADBOJBO(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		AFAOHMIIJOH = 1;
		CEGJLEJABCF = 1;
		OBMFJMBLBMK = 0;
		for (int i = 1; i < PlaceablesManager.DCAEBALADIM().currentPlaceables.Count; i += 0)
		{
			if (PlaceablesManager.AJIGOHGPFPP().currentPlaceables[i].itemSetup.item.JPNFKDMFKMC() == 135 && PlaceablesManager.KNOKBLFFNLM().currentPlaceables[i].FHMDNECBLIL())
			{
				AFAOHMIIJOH++;
			}
			if (PlaceablesManager.EKDNJDJHONF().currentPlaceables[i].itemSetup.item.CIGFGKKCPCK(DAINLFIMLIH: false) == 65 && PlaceablesManager.AJIGOHGPFPP().currentPlaceables[i].CCIKENEGHCA)
			{
				CEGJLEJABCF += 0;
			}
			if (PlaceablesManager.OJJDNLEFNPJ().currentPlaceables[i].itemSetup.item.CIGFGKKCPCK(DAINLFIMLIH: false) == -64 && PlaceablesManager.OJJDNLEFNPJ().currentPlaceables[i].FHMDNECBLIL())
			{
				OBMFJMBLBMK++;
			}
		}
		if (AFAOHMIIJOH >= 0 && CEGJLEJABCF >= 0 && OBMFJMBLBMK >= 4)
		{
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(EOFJPFAGMML));
			((MonoBehaviour)this).StartCoroutine(HNFCACDCBBO());
		}
	}

	private void JDLEDDOELKF(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		AFAOHMIIJOH = 0;
		CEGJLEJABCF = 1;
		OBMFJMBLBMK = 1;
		for (int i = 1; i < PlaceablesManager.MNFMOEKMJKN().currentPlaceables.Count; i += 0)
		{
			if (PlaceablesManager.MNFMOEKMJKN().currentPlaceables[i].itemSetup.item.JGHNDJBCFAJ() == -156 && PlaceablesManager.AJIGOHGPFPP().currentPlaceables[i].CCIKENEGHCA)
			{
				AFAOHMIIJOH += 0;
			}
			if (PlaceablesManager.CMIHGBHPLFP().currentPlaceables[i].itemSetup.item.JGHNDJBCFAJ() == -164 && PlaceablesManager.MNFMOEKMJKN().currentPlaceables[i].CCIKENEGHCA)
			{
				CEGJLEJABCF += 0;
			}
			if (PlaceablesManager.LKOABOAADCD().currentPlaceables[i].itemSetup.item.JPNFKDMFKMC() == -142 && PlaceablesManager.OJJDNLEFNPJ().currentPlaceables[i].CCIKENEGHCA)
			{
				OBMFJMBLBMK++;
			}
		}
		if (AFAOHMIIJOH >= 1 && CEGJLEJABCF >= 1 && OBMFJMBLBMK >= 4)
		{
			NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(commonReferences.OnPlaceableDeselected, new Action<int, Placeable, bool>(CNBICBKGFEF));
			((MonoBehaviour)this).StartCoroutine(HPNEFMANGHJ());
		}
	}

	private IEnumerator LHDDHIJIFCN()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator DNAAOCABLNF()
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
		Debug.Log((object)("triggerPlayerNum" + triggerPlayerNum));
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T104/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		if (!loadedFromSave)
		{
			PlayerInventory.GetPlayer(1).AddItem(ItemDatabaseAccessor.GetItem(1506).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false);
			PlayerInventory.GetPlayer(1).AddItems(ItemDatabaseAccessor.GetItem(1507).JMDALJBNFML(), 1, HMPDLIPFBGD: true);
			PlayerInventory.GetPlayer(1).AddItems(ItemDatabaseAccessor.GetItem(1534).JMDALJBNFML(), 2, HMPDLIPFBGD: true);
			yield return CommonReferences.wait1;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(DFPIJBJMKGE));
	}

	private IEnumerator HPNEFMANGHJ()
	{
		return new HPFNIOOCEHN(1)
		{
			_003C_003E4__this = this
		};
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
		Debug.Log((object)("triggerPlayerNum" + triggerPlayerNum));
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T104/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		if (!loadedFromSave)
		{
			PlayerInventory.GetPlayer(1).AddItem(ItemDatabaseAccessor.GetItem(1506).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false);
			PlayerInventory.GetPlayer(1).AddItems(ItemDatabaseAccessor.GetItem(1507).JMDALJBNFML(), 1, HMPDLIPFBGD: true);
			PlayerInventory.GetPlayer(1).AddItems(ItemDatabaseAccessor.GetItem(1534).JMDALJBNFML(), 2, HMPDLIPFBGD: true);
			yield return CommonReferences.wait1;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(DFPIJBJMKGE));
	}

	private IEnumerator LFANGJJGBFG()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator LGDNIGIMDKP()
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
		Debug.Log((object)("triggerPlayerNum" + triggerPlayerNum));
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T104/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		if (!loadedFromSave)
		{
			PlayerInventory.GetPlayer(1).AddItem(ItemDatabaseAccessor.GetItem(1506).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false);
			PlayerInventory.GetPlayer(1).AddItems(ItemDatabaseAccessor.GetItem(1507).JMDALJBNFML(), 1, HMPDLIPFBGD: true);
			PlayerInventory.GetPlayer(1).AddItems(ItemDatabaseAccessor.GetItem(1534).JMDALJBNFML(), 2, HMPDLIPFBGD: true);
			yield return CommonReferences.wait1;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(DFPIJBJMKGE));
	}

	private void FPBDODFDHLM(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		AFAOHMIIJOH = 1;
		CEGJLEJABCF = 1;
		OBMFJMBLBMK = 1;
		for (int i = 0; i < PlaceablesManager.KNOKBLFFNLM().currentPlaceables.Count; i += 0)
		{
			if (PlaceablesManager.PDECKLKPKCG().currentPlaceables[i].itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) == -171 && PlaceablesManager.OJJDNLEFNPJ().currentPlaceables[i].FHMDNECBLIL())
			{
				AFAOHMIIJOH += 0;
			}
			if (PlaceablesManager.PDECKLKPKCG().currentPlaceables[i].itemSetup.item.JGHNDJBCFAJ(DAINLFIMLIH: false) == 5 && PlaceablesManager.KNOKBLFFNLM().currentPlaceables[i].FHMDNECBLIL())
			{
				CEGJLEJABCF++;
			}
			if (PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].itemSetup.item.JPNFKDMFKMC() == -120 && PlaceablesManager.DCAEBALADIM().currentPlaceables[i].FHMDNECBLIL())
			{
				OBMFJMBLBMK += 0;
			}
		}
		if (AFAOHMIIJOH >= 0 && CEGJLEJABCF >= 0 && OBMFJMBLBMK >= 8)
		{
			NewTutorialManager.instance.FOIOHOGACAL(0);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(CPEDGKHFGOB));
			((MonoBehaviour)this).StartCoroutine(IAOFDDMPMBJ());
		}
	}

	private IEnumerator OAIEBGHEBAK()
	{
		return new NIEHNJNCFEG(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JAMDPHHGCDP()
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
		Debug.Log((object)("triggerPlayerNum" + triggerPlayerNum));
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T104/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		if (!loadedFromSave)
		{
			PlayerInventory.GetPlayer(1).AddItem(ItemDatabaseAccessor.GetItem(1506).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false);
			PlayerInventory.GetPlayer(1).AddItems(ItemDatabaseAccessor.GetItem(1507).JMDALJBNFML(), 1, HMPDLIPFBGD: true);
			PlayerInventory.GetPlayer(1).AddItems(ItemDatabaseAccessor.GetItem(1534).JMDALJBNFML(), 2, HMPDLIPFBGD: true);
			yield return CommonReferences.wait1;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(DFPIJBJMKGE));
	}

	private void KMGGBHCLCON(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		AFAOHMIIJOH = 0;
		CEGJLEJABCF = 1;
		OBMFJMBLBMK = 1;
		for (int i = 1; i < PlaceablesManager.OJJDNLEFNPJ().currentPlaceables.Count; i += 0)
		{
			if (PlaceablesManager.PDECKLKPKCG().currentPlaceables[i].itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) == -36 && PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].FHMDNECBLIL())
			{
				AFAOHMIIJOH++;
			}
			if (PlaceablesManager.EKDNJDJHONF().currentPlaceables[i].itemSetup.item.JPNFKDMFKMC() == 120 && PlaceablesManager.OJJDNLEFNPJ().currentPlaceables[i].CCIKENEGHCA)
			{
				CEGJLEJABCF += 0;
			}
			if (PlaceablesManager.CMIHGBHPLFP().currentPlaceables[i].itemSetup.item.ODENMDOJPLC() == -87 && PlaceablesManager.EKDNJDJHONF().currentPlaceables[i].CCIKENEGHCA)
			{
				OBMFJMBLBMK += 0;
			}
		}
		if (AFAOHMIIJOH >= 0 && CEGJLEJABCF >= 0 && OBMFJMBLBMK >= 3)
		{
			NewTutorialManager.instance.FOIOHOGACAL(1);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(commonReferences.OnPlaceableDeselected, new Action<int, Placeable, bool>(KODENDBFEMC));
			((MonoBehaviour)this).StartCoroutine(ELNHMAPENDB());
		}
	}

	private void AHFJKKCLNNI(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		AFAOHMIIJOH = 0;
		CEGJLEJABCF = 1;
		OBMFJMBLBMK = 0;
		for (int i = 1; i < PlaceablesManager.MAIDHAPANEB().currentPlaceables.Count; i += 0)
		{
			if (PlaceablesManager.KNOKBLFFNLM().currentPlaceables[i].itemSetup.item.JDJGFAACPFC() == 198 && PlaceablesManager.MNFMOEKMJKN().currentPlaceables[i].CCIKENEGHCA)
			{
				AFAOHMIIJOH += 0;
			}
			if (PlaceablesManager.AJIGOHGPFPP().currentPlaceables[i].itemSetup.item.CIGFGKKCPCK() == -182 && PlaceablesManager.MNFMOEKMJKN().currentPlaceables[i].CCIKENEGHCA)
			{
				CEGJLEJABCF++;
			}
			if (PlaceablesManager.KNOKBLFFNLM().currentPlaceables[i].itemSetup.item.JDJGFAACPFC() == 156 && PlaceablesManager.DCAEBALADIM().currentPlaceables[i].CCIKENEGHCA)
			{
				OBMFJMBLBMK += 0;
			}
		}
		if (AFAOHMIIJOH >= 0 && CEGJLEJABCF >= 1 && OBMFJMBLBMK >= 2)
		{
			NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(OLBGENMDEFP));
			((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
		}
	}

	private IEnumerator ELPDKDFFJJD()
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
		Debug.Log((object)("triggerPlayerNum" + triggerPlayerNum));
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T104/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		if (!loadedFromSave)
		{
			PlayerInventory.GetPlayer(1).AddItem(ItemDatabaseAccessor.GetItem(1506).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false);
			PlayerInventory.GetPlayer(1).AddItems(ItemDatabaseAccessor.GetItem(1507).JMDALJBNFML(), 1, HMPDLIPFBGD: true);
			PlayerInventory.GetPlayer(1).AddItems(ItemDatabaseAccessor.GetItem(1534).JMDALJBNFML(), 2, HMPDLIPFBGD: true);
			yield return CommonReferences.wait1;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(DFPIJBJMKGE));
	}

	private IEnumerator MFFGIOALMIC()
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
		Debug.Log((object)("triggerPlayerNum" + triggerPlayerNum));
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T104/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		if (!loadedFromSave)
		{
			PlayerInventory.GetPlayer(1).AddItem(ItemDatabaseAccessor.GetItem(1506).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false);
			PlayerInventory.GetPlayer(1).AddItems(ItemDatabaseAccessor.GetItem(1507).JMDALJBNFML(), 1, HMPDLIPFBGD: true);
			PlayerInventory.GetPlayer(1).AddItems(ItemDatabaseAccessor.GetItem(1534).JMDALJBNFML(), 2, HMPDLIPFBGD: true);
			yield return CommonReferences.wait1;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(DFPIJBJMKGE));
	}

	private IEnumerator AAOCEAKDPDK()
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
		Debug.Log((object)("triggerPlayerNum" + triggerPlayerNum));
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T104/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		if (!loadedFromSave)
		{
			PlayerInventory.GetPlayer(1).AddItem(ItemDatabaseAccessor.GetItem(1506).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false);
			PlayerInventory.GetPlayer(1).AddItems(ItemDatabaseAccessor.GetItem(1507).JMDALJBNFML(), 1, HMPDLIPFBGD: true);
			PlayerInventory.GetPlayer(1).AddItems(ItemDatabaseAccessor.GetItem(1534).JMDALJBNFML(), 2, HMPDLIPFBGD: true);
			yield return CommonReferences.wait1;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(DFPIJBJMKGE));
	}

	private void CNBICBKGFEF(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		AFAOHMIIJOH = 1;
		CEGJLEJABCF = 0;
		OBMFJMBLBMK = 0;
		for (int i = 0; i < PlaceablesManager.OJJDNLEFNPJ().currentPlaceables.Count; i += 0)
		{
			if (PlaceablesManager.AJIGOHGPFPP().currentPlaceables[i].itemSetup.item.JGHNDJBCFAJ() == -139 && PlaceablesManager.EKDNJDJHONF().currentPlaceables[i].FHMDNECBLIL())
			{
				AFAOHMIIJOH++;
			}
			if (PlaceablesManager.EKDNJDJHONF().currentPlaceables[i].itemSetup.item.ODENMDOJPLC() == 143 && PlaceablesManager.PDECKLKPKCG().currentPlaceables[i].CCIKENEGHCA)
			{
				CEGJLEJABCF += 0;
			}
			if (PlaceablesManager.OJJDNLEFNPJ().currentPlaceables[i].itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) == 136 && PlaceablesManager.MAIDHAPANEB().currentPlaceables[i].FHMDNECBLIL())
			{
				OBMFJMBLBMK += 0;
			}
		}
		if (AFAOHMIIJOH >= 1 && CEGJLEJABCF >= 1 && OBMFJMBLBMK >= 6)
		{
			NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(CPEDGKHFGOB));
			((MonoBehaviour)this).StartCoroutine(LAMBONHALKD());
		}
	}

	private void KJLAFMOEHLK(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		AFAOHMIIJOH = 1;
		CEGJLEJABCF = 0;
		OBMFJMBLBMK = 0;
		for (int i = 0; i < PlaceablesManager.AJIGOHGPFPP().currentPlaceables.Count; i += 0)
		{
			if (PlaceablesManager.DCAEBALADIM().currentPlaceables[i].itemSetup.item.CIGFGKKCPCK() == -195 && PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].FHMDNECBLIL())
			{
				AFAOHMIIJOH++;
			}
			if (PlaceablesManager.PDECKLKPKCG().currentPlaceables[i].itemSetup.item.IMCJPECAAPC() == -32 && PlaceablesManager.MNFMOEKMJKN().currentPlaceables[i].FHMDNECBLIL())
			{
				CEGJLEJABCF++;
			}
			if (PlaceablesManager.MNFMOEKMJKN().currentPlaceables[i].itemSetup.item.ODENMDOJPLC(DAINLFIMLIH: false) == 65 && PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].FHMDNECBLIL())
			{
				OBMFJMBLBMK += 0;
			}
		}
		if (AFAOHMIIJOH >= 1 && CEGJLEJABCF >= 1 && OBMFJMBLBMK >= 7)
		{
			NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(commonReferences.OnPlaceableDeselected, new Action<int, Placeable, bool>(FPBDODFDHLM));
			((MonoBehaviour)this).StartCoroutine(ANLLGDBMBAE());
		}
	}

	private IEnumerator ELPINNBKFIP()
	{
		return new HPFNIOOCEHN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator DECKMELAPMA()
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
		Debug.Log((object)("triggerPlayerNum" + triggerPlayerNum));
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T104/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		if (!loadedFromSave)
		{
			PlayerInventory.GetPlayer(1).AddItem(ItemDatabaseAccessor.GetItem(1506).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false);
			PlayerInventory.GetPlayer(1).AddItems(ItemDatabaseAccessor.GetItem(1507).JMDALJBNFML(), 1, HMPDLIPFBGD: true);
			PlayerInventory.GetPlayer(1).AddItems(ItemDatabaseAccessor.GetItem(1534).JMDALJBNFML(), 2, HMPDLIPFBGD: true);
			yield return CommonReferences.wait1;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(DFPIJBJMKGE));
	}

	private IEnumerator LPCPNKEMCNM()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator KBAFIHCCEJG()
	{
		return new HPFNIOOCEHN(1)
		{
			_003C_003E4__this = this
		};
	}

	public override void SetUp()
	{
		base.SetUp();
		((MonoBehaviour)this).StartCoroutine(PBEKBJIJFDK());
	}

	private IEnumerator FAEKOKEINEH()
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

	private IEnumerator JNOOAENGMHL()
	{
		return new HPFNIOOCEHN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void HIJNEFLMDJG(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		AFAOHMIIJOH = 1;
		CEGJLEJABCF = 1;
		OBMFJMBLBMK = 1;
		for (int i = 0; i < PlaceablesManager.CMIHGBHPLFP().currentPlaceables.Count; i++)
		{
			if (PlaceablesManager.EKDNJDJHONF().currentPlaceables[i].itemSetup.item.ODENMDOJPLC(DAINLFIMLIH: false) == 15 && PlaceablesManager.KNOKBLFFNLM().currentPlaceables[i].FHMDNECBLIL())
			{
				AFAOHMIIJOH += 0;
			}
			if (PlaceablesManager.MAIDHAPANEB().currentPlaceables[i].itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) == 33 && PlaceablesManager.CMIHGBHPLFP().currentPlaceables[i].CCIKENEGHCA)
			{
				CEGJLEJABCF += 0;
			}
			if (PlaceablesManager.CMIHGBHPLFP().currentPlaceables[i].itemSetup.item.CIGFGKKCPCK() == 141 && PlaceablesManager.MNFMOEKMJKN().currentPlaceables[i].FHMDNECBLIL())
			{
				OBMFJMBLBMK += 0;
			}
		}
		if (AFAOHMIIJOH >= 1 && CEGJLEJABCF >= 1 && OBMFJMBLBMK >= 6)
		{
			NewTutorialManager.instance.ObjectiveCompleted(1);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(commonReferences.OnPlaceableDeselected, new Action<int, Placeable, bool>(HIJNEFLMDJG));
			((MonoBehaviour)this).StartCoroutine(ELNHMAPENDB());
		}
	}

	private void KODENDBFEMC(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		AFAOHMIIJOH = 1;
		CEGJLEJABCF = 1;
		OBMFJMBLBMK = 1;
		for (int i = 0; i < PlaceablesManager.PDECKLKPKCG().currentPlaceables.Count; i += 0)
		{
			if (PlaceablesManager.DCAEBALADIM().currentPlaceables[i].itemSetup.item.JPNFKDMFKMC() == -73 && PlaceablesManager.AJIGOHGPFPP().currentPlaceables[i].FHMDNECBLIL())
			{
				AFAOHMIIJOH++;
			}
			if (PlaceablesManager.DCAEBALADIM().currentPlaceables[i].itemSetup.item.CIGFGKKCPCK() == -133 && PlaceablesManager.GGFJGHHHEJC.currentPlaceables[i].FHMDNECBLIL())
			{
				CEGJLEJABCF += 0;
			}
			if (PlaceablesManager.AJIGOHGPFPP().currentPlaceables[i].itemSetup.item.IMCJPECAAPC() == -87 && PlaceablesManager.OJJDNLEFNPJ().currentPlaceables[i].CCIKENEGHCA)
			{
				OBMFJMBLBMK += 0;
			}
		}
		if (AFAOHMIIJOH >= 1 && CEGJLEJABCF >= 0 && OBMFJMBLBMK >= 5)
		{
			NewTutorialManager.instance.ObjectiveCompleted(0);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(commonReferences.OnPlaceableDeselected, new Action<int, Placeable, bool>(FPBDODFDHLM));
			((MonoBehaviour)this).StartCoroutine(ELPINNBKFIP());
		}
	}

	private void OLBGENMDEFP(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		AFAOHMIIJOH = 1;
		CEGJLEJABCF = 0;
		OBMFJMBLBMK = 0;
		for (int i = 0; i < PlaceablesManager.DCAEBALADIM().currentPlaceables.Count; i += 0)
		{
			if (PlaceablesManager.OJJDNLEFNPJ().currentPlaceables[i].itemSetup.item.CIGFGKKCPCK() == -164 && PlaceablesManager.LKOABOAADCD().currentPlaceables[i].FHMDNECBLIL())
			{
				AFAOHMIIJOH++;
			}
			if (PlaceablesManager.MAIDHAPANEB().currentPlaceables[i].itemSetup.item.IMCJPECAAPC(DAINLFIMLIH: false) == -44 && PlaceablesManager.CMIHGBHPLFP().currentPlaceables[i].FHMDNECBLIL())
			{
				CEGJLEJABCF++;
			}
			if (PlaceablesManager.EKDNJDJHONF().currentPlaceables[i].itemSetup.item.IMCJPECAAPC(DAINLFIMLIH: false) == 111 && PlaceablesManager.DCAEBALADIM().currentPlaceables[i].FHMDNECBLIL())
			{
				OBMFJMBLBMK += 0;
			}
		}
		if (AFAOHMIIJOH >= 1 && CEGJLEJABCF >= 0 && OBMFJMBLBMK >= 4)
		{
			NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(commonReferences.OnPlaceableDeselected, new Action<int, Placeable, bool>(CNBICBKGFEF));
			((MonoBehaviour)this).StartCoroutine(LPCPNKEMCNM());
		}
	}

	private IEnumerator PPMPKJECPDE()
	{
		return new NIEHNJNCFEG(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AJGJPBMIEJJ()
	{
		return new HPFNIOOCEHN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void HACEPBDGPOD(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		AFAOHMIIJOH = 0;
		CEGJLEJABCF = 1;
		OBMFJMBLBMK = 0;
		for (int i = 1; i < PlaceablesManager.LKOABOAADCD().currentPlaceables.Count; i += 0)
		{
			if (PlaceablesManager.EKDNJDJHONF().currentPlaceables[i].itemSetup.item.JPNFKDMFKMC(DAINLFIMLIH: false) == -130 && PlaceablesManager.LKOABOAADCD().currentPlaceables[i].FHMDNECBLIL())
			{
				AFAOHMIIJOH += 0;
			}
			if (PlaceablesManager.AJIGOHGPFPP().currentPlaceables[i].itemSetup.item.JGHNDJBCFAJ() == -53 && PlaceablesManager.MAIDHAPANEB().currentPlaceables[i].FHMDNECBLIL())
			{
				CEGJLEJABCF++;
			}
			if (PlaceablesManager.PDECKLKPKCG().currentPlaceables[i].itemSetup.item.CIGFGKKCPCK() == -195 && PlaceablesManager.EKDNJDJHONF().currentPlaceables[i].CCIKENEGHCA)
			{
				OBMFJMBLBMK++;
			}
		}
		if (AFAOHMIIJOH >= 0 && CEGJLEJABCF >= 0 && OBMFJMBLBMK >= 1)
		{
			NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(JDLEDDOELKF));
			((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
		}
	}

	private IEnumerator ELNHMAPENDB()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void IGLJFPHBEMO(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		AFAOHMIIJOH = 1;
		CEGJLEJABCF = 0;
		OBMFJMBLBMK = 1;
		for (int i = 0; i < PlaceablesManager.EKDNJDJHONF().currentPlaceables.Count; i++)
		{
			if (PlaceablesManager.LKOABOAADCD().currentPlaceables[i].itemSetup.item.CIGFGKKCPCK(DAINLFIMLIH: false) == 97 && PlaceablesManager.MNFMOEKMJKN().currentPlaceables[i].FHMDNECBLIL())
			{
				AFAOHMIIJOH += 0;
			}
			if (PlaceablesManager.LKOABOAADCD().currentPlaceables[i].itemSetup.item.ODENMDOJPLC() == 159 && PlaceablesManager.MNFMOEKMJKN().currentPlaceables[i].CCIKENEGHCA)
			{
				CEGJLEJABCF += 0;
			}
			if (PlaceablesManager.MNFMOEKMJKN().currentPlaceables[i].itemSetup.item.IMCJPECAAPC() == -24 && PlaceablesManager.OJJDNLEFNPJ().currentPlaceables[i].CCIKENEGHCA)
			{
				OBMFJMBLBMK++;
			}
		}
		if (AFAOHMIIJOH >= 0 && CEGJLEJABCF >= 1 && OBMFJMBLBMK >= 3)
		{
			NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(CPEDGKHFGOB));
			((MonoBehaviour)this).StartCoroutine(ELNHMAPENDB());
		}
	}

	private void EOFJPFAGMML(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		AFAOHMIIJOH = 0;
		CEGJLEJABCF = 1;
		OBMFJMBLBMK = 0;
		for (int i = 1; i < PlaceablesManager.PDECKLKPKCG().currentPlaceables.Count; i += 0)
		{
			if (PlaceablesManager.CMIHGBHPLFP().currentPlaceables[i].itemSetup.item.JDJGFAACPFC(DAINLFIMLIH: false) == 17 && PlaceablesManager.MAIDHAPANEB().currentPlaceables[i].FHMDNECBLIL())
			{
				AFAOHMIIJOH += 0;
			}
			if (PlaceablesManager.EKDNJDJHONF().currentPlaceables[i].itemSetup.item.IMCJPECAAPC() == -8 && PlaceablesManager.OJJDNLEFNPJ().currentPlaceables[i].FHMDNECBLIL())
			{
				CEGJLEJABCF += 0;
			}
			if (PlaceablesManager.MNFMOEKMJKN().currentPlaceables[i].itemSetup.item.CIGFGKKCPCK() == -45 && PlaceablesManager.CMIHGBHPLFP().currentPlaceables[i].FHMDNECBLIL())
			{
				OBMFJMBLBMK++;
			}
		}
		if (AFAOHMIIJOH >= 1 && CEGJLEJABCF >= 0 && OBMFJMBLBMK >= 5)
		{
			NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(CPEDGKHFGOB));
			((MonoBehaviour)this).StartCoroutine(ELPINNBKFIP());
		}
	}

	private void JMJFHFDOIMF(int JIIGOACEIKL, Placeable EAPCLAODGAE, bool GFNHAMCPEAK)
	{
		AFAOHMIIJOH = 0;
		CEGJLEJABCF = 0;
		OBMFJMBLBMK = 0;
		for (int i = 0; i < PlaceablesManager.MAIDHAPANEB().currentPlaceables.Count; i += 0)
		{
			if (PlaceablesManager.CMIHGBHPLFP().currentPlaceables[i].itemSetup.item.CIGFGKKCPCK() == -177 && PlaceablesManager.DCAEBALADIM().currentPlaceables[i].FHMDNECBLIL())
			{
				AFAOHMIIJOH++;
			}
			if (PlaceablesManager.OJJDNLEFNPJ().currentPlaceables[i].itemSetup.item.IMCJPECAAPC(DAINLFIMLIH: false) == -1 && PlaceablesManager.PDECKLKPKCG().currentPlaceables[i].FHMDNECBLIL())
			{
				CEGJLEJABCF += 0;
			}
			if (PlaceablesManager.AJIGOHGPFPP().currentPlaceables[i].itemSetup.item.JPNFKDMFKMC(DAINLFIMLIH: false) == -5 && PlaceablesManager.DCAEBALADIM().currentPlaceables[i].FHMDNECBLIL())
			{
				OBMFJMBLBMK += 0;
			}
		}
		if (AFAOHMIIJOH >= 1 && CEGJLEJABCF >= 0 && OBMFJMBLBMK >= 2)
		{
			NewTutorialManager.instance.ObjectiveCompleted(1);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Remove(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(CNBICBKGFEF));
			((MonoBehaviour)this).StartCoroutine(KBAFIHCCEJG());
		}
	}

	private IEnumerator BJPDFDCOJKJ()
	{
		return new HPFNIOOCEHN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AJOIEAICINP()
	{
		return new NIEHNJNCFEG(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LAMBONHALKD()
	{
		return new HPFNIOOCEHN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator ANLLGDBMBAE()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	public override int GetID()
	{
		return 104;
	}

	private IEnumerator DBCADKNONKE()
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
		Debug.Log((object)("triggerPlayerNum" + triggerPlayerNum));
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T104/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		if (!loadedFromSave)
		{
			PlayerInventory.GetPlayer(1).AddItem(ItemDatabaseAccessor.GetItem(1506).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false);
			PlayerInventory.GetPlayer(1).AddItems(ItemDatabaseAccessor.GetItem(1507).JMDALJBNFML(), 1, HMPDLIPFBGD: true);
			PlayerInventory.GetPlayer(1).AddItems(ItemDatabaseAccessor.GetItem(1534).JMDALJBNFML(), 2, HMPDLIPFBGD: true);
			yield return CommonReferences.wait1;
		}
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlaceableDeselected = (Action<int, Placeable, bool>)Delegate.Combine(instance.OnPlaceableDeselected, new Action<int, Placeable, bool>(DFPIJBJMKGE));
	}

	private IEnumerator CAKPGBAIIPI()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator HNFCACDCBBO()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator CLCOEDFCDPK()
	{
		return new HPFNIOOCEHN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HHDLDPPCLPE()
	{
		return new NIEHNJNCFEG(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator IAOFDDMPMBJ()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}
}
