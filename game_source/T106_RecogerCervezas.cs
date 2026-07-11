using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class T106_RecogerCervezas : TutorialPhaseBase
{
	[CompilerGenerated]
	private sealed class NIEHNJNCFEG : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T106_RecogerCervezas _003C_003E4__this;

		private bool _003CdrinksAddedToBarrel_003E5__2;

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
			//IL_0193: Unknown result type (might be due to invalid IL or missing references)
			//IL_0198: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01da: Unknown result type (might be due to invalid IL or missing references)
			//IL_0114: Unknown result type (might be due to invalid IL or missing references)
			//IL_0119: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			T106_RecogerCervezas t106_RecogerCervezas = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				NewTutorialManager.instance.canEnterCellar = false;
				if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
				{
					t106_RecogerCervezas.ResetMai();
					_003C_003E2__current = ((MonoBehaviour)t106_RecogerCervezas).StartCoroutine(t106_RecogerCervezas.CCIOMPBMJMD());
					_003C_003E1__state = 1;
					return true;
				}
				goto IL_0096;
			case 1:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
				CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
				goto IL_0096;
			case 2:
				_003C_003E1__state = -1;
				NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 3;
				return true;
			case 3:
				_003C_003E1__state = -1;
				NewTutorialManager.instance.canEnterCellar = true;
				if (t106_RecogerCervezas.MLIHKNOAIFO() && !t106_RecogerCervezas.COCGNJFCLMC)
				{
					NewTutorialManager.instance.canLeaveCellar = false;
				}
				DialogueCameraTarget.GetPlayer(t106_RecogerCervezas.triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
				MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T106/Dialogue1");
				goto IL_014f;
			case 4:
				_003C_003E1__state = -1;
				goto IL_014f;
			case 5:
			{
				_003C_003E1__state = -1;
				NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
				NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
				NewTutorialManager.instance.SpawnArrow(new Vector2(12f, 915f), Vector2.up * 0.1f, ref t106_RecogerCervezas.JELIKOFDONK);
				NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)SceneReferences.GetSceneReferences().agingBarrel).transform.position), Vector2.up * 0.6f, ref t106_RecogerCervezas.LJEJMMAEKJF);
				AgingBarrelUI agingBarrelUI = AgingBarrelUI.Get(1);
				agingBarrelUI.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI.OnUIClose, new Action<int>(t106_RecogerCervezas.ADPMCNABPCG));
				if (GameManager.LocalCoop())
				{
					AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.Get(2);
					agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI2.OnUIClose, new Action<int>(t106_RecogerCervezas.ADPMCNABPCG));
				}
				GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(t106_RecogerCervezas.EDHEGFKDJDB));
				GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(t106_RecogerCervezas.AGMLGNDDINL));
				_003CdrinksAddedToBarrel_003E5__2 = false;
				goto IL_0345;
			}
			case 6:
				_003C_003E1__state = -1;
				t106_RecogerCervezas.GJNINAJEOKO();
				goto IL_0345;
			case 7:
				{
					_003C_003E1__state = -1;
					if ((Object)(object)t106_RecogerCervezas.JELIKOFDONK != (Object)null)
					{
						Object.Destroy((Object)(object)t106_RecogerCervezas.JELIKOFDONK);
					}
					t106_RecogerCervezas.LHKIJABBBPM();
					return false;
				}
				IL_0096:
				_003C_003E2__current = ((MonoBehaviour)t106_RecogerCervezas).StartCoroutine(t106_RecogerCervezas.CDICFNAMCEE());
				_003C_003E1__state = 2;
				return true;
				IL_0345:
				if (!t106_RecogerCervezas.COCGNJFCLMC)
				{
					if (t106_RecogerCervezas.MLIHKNOAIFO() && !t106_RecogerCervezas.FKBLFPKEHKC && !PlayerInventory.GetPlayer(1).HasItem(1065))
					{
						PlayerInventory.GetPlayer(1).AddItem(1065);
						t106_RecogerCervezas.FKBLFPKEHKC = true;
					}
					if (!_003CdrinksAddedToBarrel_003E5__2 && t106_RecogerCervezas.MLIHKNOAIFO())
					{
						_003CdrinksAddedToBarrel_003E5__2 = true;
						ItemInstance itemInstance = ItemDatabaseAccessor.GetItem(1533).JMDALJBNFML();
						(itemInstance as FoodInstance).GBCJNGADANM++;
						SceneReferences.GetSceneReferences().agingBarrel.inputSlot[0].BEEDBHJANGN(1, itemInstance, 5);
					}
					_003C_003E2__current = null;
					_003C_003E1__state = 6;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 7;
				return true;
				IL_014f:
				if (t106_RecogerCervezas.AAOPIEDAKKD(1))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 4;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 5;
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

	private bool COCGNJFCLMC;

	private bool GAFIEBJKJGD;

	private bool FKBLFPKEHKC;

	private void GDEEKNNFKPA()
	{
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.EAONFFENMCE(0);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI.OnUIClose, new Action<int>(GGOLPAAHHAF));
		AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.BPBMLNJGGII(0);
		agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI2.OnUIClose, new Action<int>(DOLDOKLEJOA));
		AgingBarrelUI agingBarrelUI3 = AgingBarrelUI.LBKJEHDEBEP(1);
		agingBarrelUI3.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI3.OnUIClose, new Action<int>(GGOLPAAHHAF));
	}

	private void ILNGFHKBCIJ()
	{
		if (!GAFIEBJKJGD && SceneReferences.CKDKHMPHENE().tutorialRats.Count == 0)
		{
			NewTutorialManager.instance.FOIOHOGACAL(1);
			GAFIEBJKJGD = true;
			BALBAGNFFCH();
		}
	}

	private IEnumerator GDOJMLFHCHD()
	{
		NewTutorialManager.instance.canEnterCellar = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			ResetMai();
			yield return ((MonoBehaviour)this).StartCoroutine(CCIOMPBMJMD());
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait2;
		NewTutorialManager.instance.canEnterCellar = true;
		if (MLIHKNOAIFO() && !COCGNJFCLMC)
		{
			NewTutorialManager.instance.canLeaveCellar = false;
		}
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T106/Dialogue1");
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(new Vector2(12f, 915f), Vector2.up * 0.1f, ref JELIKOFDONK);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)SceneReferences.GetSceneReferences().agingBarrel).transform.position), Vector2.up * 0.6f, ref LJEJMMAEKJF);
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.Get(1);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI.OnUIClose, new Action<int>(ADPMCNABPCG));
		if (GameManager.LocalCoop())
		{
			AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.Get(2);
			agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI2.OnUIClose, new Action<int>(ADPMCNABPCG));
		}
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(EDHEGFKDJDB));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(AGMLGNDDINL));
		bool drinksAddedToBarrel = false;
		while (!COCGNJFCLMC)
		{
			if (MLIHKNOAIFO() && !FKBLFPKEHKC && !PlayerInventory.GetPlayer(1).HasItem(1065))
			{
				PlayerInventory.GetPlayer(1).AddItem(1065);
				FKBLFPKEHKC = true;
			}
			if (!drinksAddedToBarrel && MLIHKNOAIFO())
			{
				drinksAddedToBarrel = true;
				ItemInstance itemInstance = ItemDatabaseAccessor.GetItem(1533).JMDALJBNFML();
				(itemInstance as FoodInstance).GBCJNGADANM++;
				SceneReferences.GetSceneReferences().agingBarrel.inputSlot[0].BEEDBHJANGN(1, itemInstance, 5);
			}
			yield return null;
			GJNINAJEOKO();
		}
		yield return CommonReferences.wait1;
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		LHKIJABBBPM();
	}

	private void MGPNGJPCAOJ(int JIIGOACEIKL)
	{
		if (PlayerInventory.PDIEGHLDAJK(24, 7))
		{
			NewTutorialManager.instance.ObjectiveCompleted(1);
			NewTutorialManager.instance.agingBarrelBlocked = false;
			NEDLOPAJFPC();
			CHOCGPMLCPE();
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
		}
	}

	private void JLPHFELJEJP()
	{
		COCGNJFCLMC = NewTutorialManager.instance.AreAllObjectivesCompleted();
		NewTutorialManager.instance.canLeaveCellar = COCGNJFCLMC;
	}

	private void KMDLLHMDJHB()
	{
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.IEPGACAGIPO(0);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI.OnUIClose, new Action<int>(ECCHBFNDIBJ));
		AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.EAONFFENMCE(0);
		agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI2.OnUIClose, new Action<int>(HLOCHCLMGHG));
		AgingBarrelUI agingBarrelUI3 = AgingBarrelUI.FFBJPAJKOJH(2);
		agingBarrelUI3.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI3.OnUIClose, new Action<int>(KAMKMDGBHPG));
	}

	private void DCJLPEDJIJB()
	{
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.IEPGACAGIPO(1);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI.OnUIClose, new Action<int>(GJIIGNAEAPD));
		AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.EAONFFENMCE(5);
		agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI2.OnUIClose, new Action<int>(ADPMCNABPCG));
		GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(KNMAEAOKFJE));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(OHMGPBGMJPP));
	}

	private void CNLCBECGNHC()
	{
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.IEPGACAGIPO(0);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI.OnUIClose, new Action<int>(BGPFDDDMOGM));
		AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.LBKJEHDEBEP(4);
		agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI2.OnUIClose, new Action<int>(JJGPFGMJIGJ));
		AgingBarrelUI agingBarrelUI3 = AgingBarrelUI.IEPGACAGIPO(1);
		agingBarrelUI3.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI3.OnUIClose, new Action<int>(BGPFDDDMOGM));
	}

	private void AOJFDMJIBPO()
	{
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.IEPGACAGIPO(0);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI.OnUIClose, new Action<int>(KAMKMDGBHPG));
		AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.FFBJPAJKOJH(0);
		agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI2.OnUIClose, new Action<int>(HLOCHCLMGHG));
		AgingBarrelUI agingBarrelUI3 = AgingBarrelUI.BDJFHFHLJGN(6);
		agingBarrelUI3.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI3.OnUIClose, new Action<int>(GJIIGNAEAPD));
	}

	private void GJLCIKCMGCK()
	{
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.Get(1);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI.OnUIClose, new Action<int>(ADPMCNABPCG));
		AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.Get(2);
		agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI2.OnUIClose, new Action<int>(ADPMCNABPCG));
		GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(EDHEGFKDJDB));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(AGMLGNDDINL));
	}

	private void EAGBBBKGLKJ()
	{
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.IJJJEMKCNJM(1);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI.OnUIClose, new Action<int>(ECCHBFNDIBJ));
		AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.IJJJEMKCNJM(8);
		agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI2.OnUIClose, new Action<int>(ECCHBFNDIBJ));
		AgingBarrelUI agingBarrelUI3 = AgingBarrelUI.IEPGACAGIPO(1);
		agingBarrelUI3.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI3.OnUIClose, new Action<int>(GGOLPAAHHAF));
	}

	private void JJGPFGMJIGJ(int JIIGOACEIKL)
	{
		if (PlayerInventory.PDIEGHLDAJK(183, 2))
		{
			NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			NewTutorialManager.instance.agingBarrelBlocked = true;
			IPIIBIECKIF();
			PGAHKHLJJLC();
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
		}
	}

	private void IDLHKLLDEDF()
	{
		COCGNJFCLMC = NewTutorialManager.instance.AreAllObjectivesCompleted();
		NewTutorialManager.instance.canLeaveCellar = COCGNJFCLMC;
	}

	private void EBELLFGHGAL()
	{
		COCGNJFCLMC = NewTutorialManager.instance.AreAllObjectivesCompleted();
		NewTutorialManager.instance.canLeaveCellar = COCGNJFCLMC;
	}

	private void CHOCGPMLCPE()
	{
		COCGNJFCLMC = NewTutorialManager.instance.AreAllObjectivesCompleted();
		NewTutorialManager.instance.canLeaveCellar = COCGNJFCLMC;
	}

	private void INJJANIGIAJ()
	{
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.EAONFFENMCE(0);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI.OnUIClose, new Action<int>(DOLDOKLEJOA));
		AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.FFBJPAJKOJH(0);
		agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI2.OnUIClose, new Action<int>(MGPNGJPCAOJ));
		AgingBarrelUI agingBarrelUI3 = AgingBarrelUI.BPBMLNJGGII(2);
		agingBarrelUI3.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI3.OnUIClose, new Action<int>(GGOLPAAHHAF));
	}

	private IEnumerator PBEKBJIJFDK()
	{
		NewTutorialManager.instance.canEnterCellar = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			ResetMai();
			yield return ((MonoBehaviour)this).StartCoroutine(CCIOMPBMJMD());
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait2;
		NewTutorialManager.instance.canEnterCellar = true;
		if (MLIHKNOAIFO() && !COCGNJFCLMC)
		{
			NewTutorialManager.instance.canLeaveCellar = false;
		}
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T106/Dialogue1");
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(new Vector2(12f, 915f), Vector2.up * 0.1f, ref JELIKOFDONK);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)SceneReferences.GetSceneReferences().agingBarrel).transform.position), Vector2.up * 0.6f, ref LJEJMMAEKJF);
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.Get(1);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI.OnUIClose, new Action<int>(ADPMCNABPCG));
		if (GameManager.LocalCoop())
		{
			AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.Get(2);
			agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI2.OnUIClose, new Action<int>(ADPMCNABPCG));
		}
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(EDHEGFKDJDB));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(AGMLGNDDINL));
		bool drinksAddedToBarrel = false;
		while (!COCGNJFCLMC)
		{
			if (MLIHKNOAIFO() && !FKBLFPKEHKC && !PlayerInventory.GetPlayer(1).HasItem(1065))
			{
				PlayerInventory.GetPlayer(1).AddItem(1065);
				FKBLFPKEHKC = true;
			}
			if (!drinksAddedToBarrel && MLIHKNOAIFO())
			{
				drinksAddedToBarrel = true;
				ItemInstance itemInstance = ItemDatabaseAccessor.GetItem(1533).JMDALJBNFML();
				(itemInstance as FoodInstance).GBCJNGADANM++;
				SceneReferences.GetSceneReferences().agingBarrel.inputSlot[0].BEEDBHJANGN(1, itemInstance, 5);
			}
			yield return null;
			GJNINAJEOKO();
		}
		yield return CommonReferences.wait1;
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		LHKIJABBBPM();
	}

	private void HNDHNMJGKNO()
	{
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.IEPGACAGIPO(1);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI.OnUIClose, new Action<int>(DOLDOKLEJOA));
		AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.BPBMLNJGGII(0);
		agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI2.OnUIClose, new Action<int>(MGPNGJPCAOJ));
		AgingBarrelUI agingBarrelUI3 = AgingBarrelUI.IEPGACAGIPO(6);
		agingBarrelUI3.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI3.OnUIClose, new Action<int>(ECCHBFNDIBJ));
	}

	private IEnumerator FGLMKBOMOBA()
	{
		return new NIEHNJNCFEG(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator OGOFIFJCMEB()
	{
		return new NIEHNJNCFEG(1)
		{
			_003C_003E4__this = this
		};
	}

	private void GJNINAJEOKO()
	{
		if (!GAFIEBJKJGD && SceneReferences.GetSceneReferences().tutorialRats.Count == 0)
		{
			NewTutorialManager.instance.ObjectiveCompleted(1);
			GAFIEBJKJGD = true;
			PGAHKHLJJLC();
		}
	}

	private void JPKENCMNEMM()
	{
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.BPBMLNJGGII(0);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI.OnUIClose, new Action<int>(MGPNGJPCAOJ));
		AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.GFPBMGCMHHC(3);
		agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI2.OnUIClose, new Action<int>(GGOLPAAHHAF));
		AgingBarrelUI agingBarrelUI3 = AgingBarrelUI.Get(1);
		agingBarrelUI3.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI3.OnUIClose, new Action<int>(MGPNGJPCAOJ));
	}

	private IEnumerator BBGHMMLBAME()
	{
		return new NIEHNJNCFEG(1)
		{
			_003C_003E4__this = this
		};
	}

	private void PKINONJCKOJ()
	{
		COCGNJFCLMC = NewTutorialManager.instance.AreAllObjectivesCompleted();
		NewTutorialManager.instance.canLeaveCellar = COCGNJFCLMC;
	}

	private void FAPAINGEBOC()
	{
		COCGNJFCLMC = NewTutorialManager.instance.AreAllObjectivesCompleted();
		NewTutorialManager.instance.canLeaveCellar = COCGNJFCLMC;
	}

	private void HLOCHCLMGHG(int JIIGOACEIKL)
	{
		if (PlayerInventory.PlayersHaveEnoughItems(106, 3))
		{
			NewTutorialManager.instance.FOIOHOGACAL(1);
			NewTutorialManager.instance.agingBarrelBlocked = true;
			GJLCIKCMGCK();
			DHCCMBIGMJM();
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
		}
	}

	private void NNOBJLEGKFJ()
	{
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.FFBJPAJKOJH(0);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI.OnUIClose, new Action<int>(ECCHBFNDIBJ));
		AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.IJJJEMKCNJM(1);
		agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI2.OnUIClose, new Action<int>(MIFBKAELNFO));
		AgingBarrelUI agingBarrelUI3 = AgingBarrelUI.Get(2);
		agingBarrelUI3.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI3.OnUIClose, new Action<int>(BGPFDDDMOGM));
	}

	private void FKPBKANCJOG()
	{
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.GFPBMGCMHHC(0);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI.OnUIClose, new Action<int>(KAMKMDGBHPG));
		AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.GFPBMGCMHHC(2);
		agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI2.OnUIClose, new Action<int>(ECCHBFNDIBJ));
		GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(KNMAEAOKFJE));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(EAGBBBKGLKJ));
	}

	private void OIHICHAFFPD()
	{
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.NALKHGMLALJ(0);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI.OnUIClose, new Action<int>(BGPFDDDMOGM));
		AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.IEPGACAGIPO(8);
		agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI2.OnUIClose, new Action<int>(DOLDOKLEJOA));
		GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(OAKPOEMIEBB));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(EAGBBBKGLKJ));
	}

	private void GJIIGNAEAPD(int JIIGOACEIKL)
	{
		if (PlayerInventory.PlayersHaveEnoughItems(116, 8))
		{
			NewTutorialManager.instance.FOIOHOGACAL(0);
			NewTutorialManager.instance.agingBarrelBlocked = false;
			LMGNBHKEPCI();
			CHOCGPMLCPE();
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
		}
	}

	private void OHBIHIELNPA()
	{
		COCGNJFCLMC = NewTutorialManager.instance.AreAllObjectivesCompleted();
		NewTutorialManager.instance.canLeaveCellar = COCGNJFCLMC;
	}

	private void JHIMEKIOIHE()
	{
		if (!GAFIEBJKJGD && SceneReferences.CFAMKBHIGLO().tutorialRats.Count == 0)
		{
			NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			GAFIEBJKJGD = true;
			FAPAINGEBOC();
		}
	}

	private void BHGPBKLOPJL()
	{
		if (!GAFIEBJKJGD && SceneReferences.CKDKHMPHENE().tutorialRats.Count == 0)
		{
			NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			GAFIEBJKJGD = false;
			DHCCMBIGMJM();
		}
	}

	private void LMGNBHKEPCI()
	{
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.LBKJEHDEBEP(1);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI.OnUIClose, new Action<int>(GJIIGNAEAPD));
		AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.BPBMLNJGGII(2);
		agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI2.OnUIClose, new Action<int>(ADPMCNABPCG));
		GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(KNMAEAOKFJE));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(BIHDJEFALFI));
	}

	private void EDHEGFKDJDB()
	{
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.Get(1);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI.OnUIClose, new Action<int>(ADPMCNABPCG));
		AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.Get(1);
		agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI2.OnUIClose, new Action<int>(ADPMCNABPCG));
		AgingBarrelUI agingBarrelUI3 = AgingBarrelUI.Get(2);
		agingBarrelUI3.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI3.OnUIClose, new Action<int>(ADPMCNABPCG));
	}

	private void FHPFHMCNHFJ()
	{
		COCGNJFCLMC = NewTutorialManager.instance.AreAllObjectivesCompleted();
		NewTutorialManager.instance.canLeaveCellar = COCGNJFCLMC;
	}

	public override int GetID()
	{
		return 106;
	}

	private void PGAHKHLJJLC()
	{
		COCGNJFCLMC = NewTutorialManager.instance.AreAllObjectivesCompleted();
		NewTutorialManager.instance.canLeaveCellar = COCGNJFCLMC;
	}

	private void EJMHLFEEJHJ()
	{
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.Get(0);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI.OnUIClose, new Action<int>(MIFBKAELNFO));
		AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.IEPGACAGIPO(1);
		agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI2.OnUIClose, new Action<int>(ECCHBFNDIBJ));
		AgingBarrelUI agingBarrelUI3 = AgingBarrelUI.BPBMLNJGGII(7);
		agingBarrelUI3.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI3.OnUIClose, new Action<int>(KAMKMDGBHPG));
	}

	public override void SetUp()
	{
		base.SetUp();
		((MonoBehaviour)this).StartCoroutine(PBEKBJIJFDK());
	}

	private void CFDEKGDIFOI()
	{
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.EAONFFENMCE(1);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI.OnUIClose, new Action<int>(JEGBKBDCIFL));
		AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.GFPBMGCMHHC(7);
		agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI2.OnUIClose, new Action<int>(GJIIGNAEAPD));
		AgingBarrelUI agingBarrelUI3 = AgingBarrelUI.NALKHGMLALJ(1);
		agingBarrelUI3.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI3.OnUIClose, new Action<int>(JJGPFGMJIGJ));
	}

	private void OBJEAMADHFE()
	{
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.GFPBMGCMHHC(1);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI.OnUIClose, new Action<int>(JEGBKBDCIFL));
		AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.EAONFFENMCE(0);
		agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI2.OnUIClose, new Action<int>(MGPNGJPCAOJ));
		AgingBarrelUI agingBarrelUI3 = AgingBarrelUI.EAONFFENMCE(3);
		agingBarrelUI3.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI3.OnUIClose, new Action<int>(MGPNGJPCAOJ));
	}

	private void GAFJCENAIHE()
	{
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.BPBMLNJGGII(1);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI.OnUIClose, new Action<int>(BGPFDDDMOGM));
		AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.LBKJEHDEBEP(0);
		agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI2.OnUIClose, new Action<int>(GJIIGNAEAPD));
		AgingBarrelUI agingBarrelUI3 = AgingBarrelUI.EAONFFENMCE(0);
		agingBarrelUI3.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI3.OnUIClose, new Action<int>(ECCHBFNDIBJ));
	}

	private void BIBBBIFNDFN()
	{
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.IEPGACAGIPO(0);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI.OnUIClose, new Action<int>(BGPFDDDMOGM));
		AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.BDJFHFHLJGN(8);
		agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI2.OnUIClose, new Action<int>(ADPMCNABPCG));
		GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(KNMAEAOKFJE));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(JMADNPJODLB));
	}

	private void GGOLPAAHHAF(int JIIGOACEIKL)
	{
		if (PlayerInventory.PDIEGHLDAJK(-79, 2))
		{
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			NewTutorialManager.instance.agingBarrelBlocked = true;
			NEDLOPAJFPC();
			FHPFHMCNHFJ();
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
		}
	}

	private void BIHDJEFALFI()
	{
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.IJJJEMKCNJM(0);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI.OnUIClose, new Action<int>(DOLDOKLEJOA));
		AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.BDJFHFHLJGN(2);
		agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI2.OnUIClose, new Action<int>(BGPFDDDMOGM));
		AgingBarrelUI agingBarrelUI3 = AgingBarrelUI.GFPBMGCMHHC(1);
		agingBarrelUI3.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI3.OnUIClose, new Action<int>(JEGBKBDCIFL));
	}

	private void NEDLOPAJFPC()
	{
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.GFPBMGCMHHC(1);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI.OnUIClose, new Action<int>(HLOCHCLMGHG));
		AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.IJJJEMKCNJM(0);
		agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI2.OnUIClose, new Action<int>(ADPMCNABPCG));
		GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(MELOCKFAIMJ));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(CNLCBECGNHC));
	}

	private void OHMGPBGMJPP()
	{
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.IEPGACAGIPO(1);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI.OnUIClose, new Action<int>(MGPNGJPCAOJ));
		AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.GFPBMGCMHHC(2);
		agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI2.OnUIClose, new Action<int>(ECCHBFNDIBJ));
		AgingBarrelUI agingBarrelUI3 = AgingBarrelUI.IEPGACAGIPO(1);
		agingBarrelUI3.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI3.OnUIClose, new Action<int>(ADPMCNABPCG));
	}

	private void ABLOHLEDPJI()
	{
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.BDJFHFHLJGN(0);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI.OnUIClose, new Action<int>(GGOLPAAHHAF));
		AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.IEPGACAGIPO(7);
		agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI2.OnUIClose, new Action<int>(KAMKMDGBHPG));
		GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(KMDLLHMDJHB));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(BIHDJEFALFI));
	}

	private void KIHGKEDODEG()
	{
		if (!GAFIEBJKJGD && SceneReferences.GetSceneReferences().tutorialRats.Count == 0)
		{
			NewTutorialManager.instance.FOIOHOGACAL(0);
			GAFIEBJKJGD = true;
			PKINONJCKOJ();
		}
	}

	private void FNLCEFFGGEI()
	{
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.NALKHGMLALJ(0);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI.OnUIClose, new Action<int>(MGPNGJPCAOJ));
		AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.EAONFFENMCE(1);
		agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI2.OnUIClose, new Action<int>(JJGPFGMJIGJ));
		GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(BHIGJECHPCD));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(GAFJCENAIHE));
	}

	private void JEGBKBDCIFL(int JIIGOACEIKL)
	{
		if (PlayerInventory.HBDGDEPDPJK(-156, 0))
		{
			NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			NewTutorialManager.instance.agingBarrelBlocked = false;
			LMGNBHKEPCI();
			JLPHFELJEJP();
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
		}
	}

	private void HMOABDMIFCP()
	{
		if (!GAFIEBJKJGD && SceneReferences.CKDKHMPHENE().tutorialRats.Count == 0)
		{
			NewTutorialManager.instance.ObjectiveCompleted(1);
			GAFIEBJKJGD = true;
			EBELLFGHGAL();
		}
	}

	private void MIFBKAELNFO(int JIIGOACEIKL)
	{
		if (PlayerInventory.HBDGDEPDPJK(81, 3))
		{
			NewTutorialManager.instance.ObjectiveCompleted(1);
			NewTutorialManager.instance.agingBarrelBlocked = true;
			LMGNBHKEPCI();
			PKINONJCKOJ();
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
		}
	}

	private IEnumerator AJJHBJHCACM()
	{
		return new NIEHNJNCFEG(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HFFIGEDMMJF()
	{
		return new NIEHNJNCFEG(1)
		{
			_003C_003E4__this = this
		};
	}

	private void LPJGHCMFFEP()
	{
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.Get(1);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI.OnUIClose, new Action<int>(MIFBKAELNFO));
		AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.FFBJPAJKOJH(0);
		agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI2.OnUIClose, new Action<int>(MGPNGJPCAOJ));
		AgingBarrelUI agingBarrelUI3 = AgingBarrelUI.EAONFFENMCE(4);
		agingBarrelUI3.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI3.OnUIClose, new Action<int>(MGPNGJPCAOJ));
	}

	private void AGMLGNDDINL()
	{
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.Get(1);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI.OnUIClose, new Action<int>(ADPMCNABPCG));
		AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.Get(2);
		agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI2.OnUIClose, new Action<int>(ADPMCNABPCG));
		AgingBarrelUI agingBarrelUI3 = AgingBarrelUI.Get(1);
		agingBarrelUI3.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI3.OnUIClose, new Action<int>(ADPMCNABPCG));
	}

	private void OAKPOEMIEBB()
	{
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.GFPBMGCMHHC(1);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI.OnUIClose, new Action<int>(BGPFDDDMOGM));
		AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.LBKJEHDEBEP(1);
		agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI2.OnUIClose, new Action<int>(HLOCHCLMGHG));
		AgingBarrelUI agingBarrelUI3 = AgingBarrelUI.Get(1);
		agingBarrelUI3.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI3.OnUIClose, new Action<int>(BGPFDDDMOGM));
	}

	private void HLLHEFGMNOI()
	{
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.FFBJPAJKOJH(1);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI.OnUIClose, new Action<int>(MGPNGJPCAOJ));
		AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.IEPGACAGIPO(8);
		agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI2.OnUIClose, new Action<int>(JJGPFGMJIGJ));
		GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(HNDHNMJGKNO));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(CFDEKGDIFOI));
	}

	private void MPPCDCDMJKD()
	{
		if (!GAFIEBJKJGD && SceneReferences.CKDKHMPHENE().tutorialRats.Count == 0)
		{
			NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			GAFIEBJKJGD = false;
			PGAHKHLJJLC();
		}
	}

	private void JMADNPJODLB()
	{
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.BDJFHFHLJGN(0);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI.OnUIClose, new Action<int>(JEGBKBDCIFL));
		AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.BDJFHFHLJGN(2);
		agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI2.OnUIClose, new Action<int>(MIFBKAELNFO));
		AgingBarrelUI agingBarrelUI3 = AgingBarrelUI.NALKHGMLALJ(1);
		agingBarrelUI3.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI3.OnUIClose, new Action<int>(JEGBKBDCIFL));
	}

	private void KNMAEAOKFJE()
	{
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.IJJJEMKCNJM(0);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI.OnUIClose, new Action<int>(DOLDOKLEJOA));
		AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.GFPBMGCMHHC(1);
		agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI2.OnUIClose, new Action<int>(ECCHBFNDIBJ));
		AgingBarrelUI agingBarrelUI3 = AgingBarrelUI.BPBMLNJGGII(7);
		agingBarrelUI3.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI3.OnUIClose, new Action<int>(ADPMCNABPCG));
	}

	private void BALBAGNFFCH()
	{
		COCGNJFCLMC = NewTutorialManager.instance.AreAllObjectivesCompleted();
		NewTutorialManager.instance.canLeaveCellar = COCGNJFCLMC;
	}

	private void DHCCMBIGMJM()
	{
		COCGNJFCLMC = NewTutorialManager.instance.AreAllObjectivesCompleted();
		NewTutorialManager.instance.canLeaveCellar = COCGNJFCLMC;
	}

	private IEnumerator MDFFFPLNDAP()
	{
		return new NIEHNJNCFEG(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator EJMHFLGBJKM()
	{
		return new NIEHNJNCFEG(1)
		{
			_003C_003E4__this = this
		};
	}

	private void EEBLIBOJKEE()
	{
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.NALKHGMLALJ(1);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI.OnUIClose, new Action<int>(MIFBKAELNFO));
		AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.BPBMLNJGGII(8);
		agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI2.OnUIClose, new Action<int>(ADPMCNABPCG));
		AgingBarrelUI agingBarrelUI3 = AgingBarrelUI.IJJJEMKCNJM(0);
		agingBarrelUI3.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI3.OnUIClose, new Action<int>(GGOLPAAHHAF));
	}

	private void IGMIBODLPIC()
	{
		if (!GAFIEBJKJGD && SceneReferences.CFAMKBHIGLO().tutorialRats.Count == 0)
		{
			NewTutorialManager.instance.ObjectiveCompleted(0);
			GAFIEBJKJGD = true;
			CHOCGPMLCPE();
		}
	}

	private void ADPMCNABPCG(int JIIGOACEIKL)
	{
		if (PlayerInventory.PlayersHaveEnoughItems(1533, 5))
		{
			NewTutorialManager.instance.ObjectiveCompleted(0);
			NewTutorialManager.instance.agingBarrelBlocked = true;
			GJLCIKCMGCK();
			PGAHKHLJJLC();
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
		}
	}

	private void EBNMEOHLJFK()
	{
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.GFPBMGCMHHC(0);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI.OnUIClose, new Action<int>(HLOCHCLMGHG));
		AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.IJJJEMKCNJM(0);
		agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI2.OnUIClose, new Action<int>(JJGPFGMJIGJ));
		GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(LPJGHCMFFEP));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(CFDEKGDIFOI));
	}

	private void GPKHMCNMOJJ()
	{
		if (!GAFIEBJKJGD && SceneReferences.CKDKHMPHENE().tutorialRats.Count == 0)
		{
			NewTutorialManager.instance.ObjectiveCompleted(0);
			GAFIEBJKJGD = true;
			OHBIHIELNPA();
		}
	}

	private void KKCKOPPNKMI()
	{
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.Get(0);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI.OnUIClose, new Action<int>(DOLDOKLEJOA));
		AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.NALKHGMLALJ(0);
		agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI2.OnUIClose, new Action<int>(HLOCHCLMGHG));
		AgingBarrelUI agingBarrelUI3 = AgingBarrelUI.LBKJEHDEBEP(1);
		agingBarrelUI3.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI3.OnUIClose, new Action<int>(MGPNGJPCAOJ));
	}

	private IEnumerator FAEKOKEINEH()
	{
		NewTutorialManager.instance.canEnterCellar = false;
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			ResetMai();
			yield return ((MonoBehaviour)this).StartCoroutine(CCIOMPBMJMD());
			MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait2;
		NewTutorialManager.instance.canEnterCellar = true;
		if (MLIHKNOAIFO() && !COCGNJFCLMC)
		{
			NewTutorialManager.instance.canLeaveCellar = false;
		}
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T106/Dialogue1");
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.instance.SpawnArrow(new Vector2(12f, 915f), Vector2.up * 0.1f, ref JELIKOFDONK);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)SceneReferences.GetSceneReferences().agingBarrel).transform.position), Vector2.up * 0.6f, ref LJEJMMAEKJF);
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.Get(1);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI.OnUIClose, new Action<int>(ADPMCNABPCG));
		if (GameManager.LocalCoop())
		{
			AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.Get(2);
			agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI2.OnUIClose, new Action<int>(ADPMCNABPCG));
		}
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(EDHEGFKDJDB));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(AGMLGNDDINL));
		bool drinksAddedToBarrel = false;
		while (!COCGNJFCLMC)
		{
			if (MLIHKNOAIFO() && !FKBLFPKEHKC && !PlayerInventory.GetPlayer(1).HasItem(1065))
			{
				PlayerInventory.GetPlayer(1).AddItem(1065);
				FKBLFPKEHKC = true;
			}
			if (!drinksAddedToBarrel && MLIHKNOAIFO())
			{
				drinksAddedToBarrel = true;
				ItemInstance itemInstance = ItemDatabaseAccessor.GetItem(1533).JMDALJBNFML();
				(itemInstance as FoodInstance).GBCJNGADANM++;
				SceneReferences.GetSceneReferences().agingBarrel.inputSlot[0].BEEDBHJANGN(1, itemInstance, 5);
			}
			yield return null;
			GJNINAJEOKO();
		}
		yield return CommonReferences.wait1;
		if ((Object)(object)JELIKOFDONK != (Object)null)
		{
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
		LHKIJABBBPM();
	}

	private void ECCHBFNDIBJ(int JIIGOACEIKL)
	{
		if (PlayerInventory.PDIEGHLDAJK(-15, 8))
		{
			NewTutorialManager.instance.ObjectiveCompleted(0);
			NewTutorialManager.instance.agingBarrelBlocked = true;
			DCJLPEDJIJB();
			IDLHKLLDEDF();
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
		}
	}

	private void HDLFBLLCFGC()
	{
		if (!GAFIEBJKJGD && SceneReferences.FAOPFMBMMJJ().tutorialRats.Count == 0)
		{
			NewTutorialManager.instance.FOIOHOGACAL(0);
			GAFIEBJKJGD = false;
			PKINONJCKOJ();
		}
	}

	private IEnumerator PPMPKJECPDE()
	{
		return new NIEHNJNCFEG(1)
		{
			_003C_003E4__this = this
		};
	}

	private void BGPFDDDMOGM(int JIIGOACEIKL)
	{
		if (PlayerInventory.PlayersHaveEnoughItems(-171, 8))
		{
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			NewTutorialManager.instance.agingBarrelBlocked = false;
			LMGNBHKEPCI();
			BALBAGNFFCH();
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
		}
	}

	private void IJFLNNDGGIA()
	{
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.IEPGACAGIPO(0);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI.OnUIClose, new Action<int>(ADPMCNABPCG));
		AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.IJJJEMKCNJM(5);
		agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI2.OnUIClose, new Action<int>(MIFBKAELNFO));
		GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(OBJEAMADHFE));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(GAFJCENAIHE));
	}

	private void MELOCKFAIMJ()
	{
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.GFPBMGCMHHC(1);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI.OnUIClose, new Action<int>(KAMKMDGBHPG));
		AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.FFBJPAJKOJH(1);
		agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI2.OnUIClose, new Action<int>(ECCHBFNDIBJ));
		AgingBarrelUI agingBarrelUI3 = AgingBarrelUI.IEPGACAGIPO(4);
		agingBarrelUI3.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI3.OnUIClose, new Action<int>(BGPFDDDMOGM));
	}

	private void APBPEDHCDNG()
	{
		if (!GAFIEBJKJGD && SceneReferences.CFAMKBHIGLO().tutorialRats.Count == 0)
		{
			NewTutorialManager.instance.FOIOHOGACAL(0);
			GAFIEBJKJGD = true;
			OHBIHIELNPA();
		}
	}

	private void IPIIBIECKIF()
	{
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.NALKHGMLALJ(1);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI.OnUIClose, new Action<int>(JJGPFGMJIGJ));
		AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.LBKJEHDEBEP(2);
		agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI2.OnUIClose, new Action<int>(MIFBKAELNFO));
		GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(KKCKOPPNKMI));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(CFDEKGDIFOI));
	}

	private IEnumerator OPCHFFMKPCN()
	{
		return new NIEHNJNCFEG(1)
		{
			_003C_003E4__this = this
		};
	}

	private void BHIGJECHPCD()
	{
		AgingBarrelUI agingBarrelUI = AgingBarrelUI.FFBJPAJKOJH(0);
		agingBarrelUI.OnUIClose = (Action<int>)Delegate.Remove(agingBarrelUI.OnUIClose, new Action<int>(GJIIGNAEAPD));
		AgingBarrelUI agingBarrelUI2 = AgingBarrelUI.GFPBMGCMHHC(1);
		agingBarrelUI2.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI2.OnUIClose, new Action<int>(DOLDOKLEJOA));
		AgingBarrelUI agingBarrelUI3 = AgingBarrelUI.GFPBMGCMHHC(2);
		agingBarrelUI3.OnUIClose = (Action<int>)Delegate.Combine(agingBarrelUI3.OnUIClose, new Action<int>(ECCHBFNDIBJ));
	}

	private void KAMKMDGBHPG(int JIIGOACEIKL)
	{
		if (PlayerInventory.HBDGDEPDPJK(-150, 8))
		{
			NewTutorialManager.instance.FOIOHOGACAL(1);
			NewTutorialManager.instance.agingBarrelBlocked = false;
			IPIIBIECKIF();
			JLPHFELJEJP();
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
		}
	}

	private IEnumerator IAGFAELHIPP()
	{
		return new NIEHNJNCFEG(1)
		{
			_003C_003E4__this = this
		};
	}

	private void DOLDOKLEJOA(int JIIGOACEIKL)
	{
		if (PlayerInventory.HBDGDEPDPJK(-90, 0))
		{
			NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			NewTutorialManager.instance.agingBarrelBlocked = true;
			ABLOHLEDPJI();
			CHOCGPMLCPE();
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
		}
	}

	private void MHHLGEFLOHP()
	{
		if (!GAFIEBJKJGD && SceneReferences.GetSceneReferences().tutorialRats.Count == 0)
		{
			NewTutorialManager.instance.FOIOHOGACAL(1);
			GAFIEBJKJGD = false;
			EBELLFGHGAL();
		}
	}

	private IEnumerator KEBCOCFPNIG()
	{
		return new NIEHNJNCFEG(1)
		{
			_003C_003E4__this = this
		};
	}
}
