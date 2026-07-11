using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class T102_Limpiar : TutorialPhaseBase
{
	[CompilerGenerated]
	private sealed class PCJCJGKNLCG : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T102_Limpiar _003C_003E4__this;

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
		public PCJCJGKNLCG(int _003C_003E1__state)
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
			T102_Limpiar t102_Limpiar = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				break;
			case 1:
				_003C_003E1__state = -1;
				break;
			}
			if (NewTutorialManager.instance.mainPopup.activeInHierarchy)
			{
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			}
			if (PlayerInventory.GetPlayer(1).HasItem(ItemDatabaseAccessor.GetItem(1065)) || (GameManager.LocalCoop() && PlayerInventory.GetPlayer(2).HasItem(ItemDatabaseAccessor.GetItem(1065))) || SceneReferences.instance.table.JNHCCCBICDM == TableDirtLevel.Perfect)
			{
				t102_Limpiar.BPNIFENBEJL(SceneReferences.instance.table.JNHCCCBICDM);
				t102_Limpiar.IHDGHPPMCFK();
				NewTutorialManager.instance.PlayObjectivesCompletedSound();
				t102_Limpiar.PGAHKHLJJLC();
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
	private sealed class NIEHNJNCFEG : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T102_Limpiar _003C_003E4__this;

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
			//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0197: Unknown result type (might be due to invalid IL or missing references)
			//IL_019c: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			T102_Limpiar t102_Limpiar = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
				{
					GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(t102_Limpiar.MPAJIIEACDK));
					CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
				}
				Weather.ShowWeather(Weather.WeatherType.None);
				t102_Limpiar.ResetMai();
				goto IL_0099;
			case 1:
				_003C_003E1__state = -1;
				goto IL_0099;
			case 2:
				_003C_003E1__state = -1;
				NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
				DialogueCameraTarget.GetPlayer(t102_Limpiar.triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
				MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
				MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T102/Dialogue1", t102_Limpiar.triggerPlayerNum);
				goto IL_0147;
			case 3:
				_003C_003E1__state = -1;
				goto IL_0147;
			case 4:
			{
				_003C_003E1__state = -1;
				NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
				NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
				NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)SceneReferences.instance.initialChest).transform.position), Vector2.up * 0.2f, ref t102_Limpiar.JELIKOFDONK);
				NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)SceneReferences.instance.table).transform.position), Vector2.down * 0.5f, ref t102_Limpiar.LJEJMMAEKJF);
				SmallContainerUI smallContainerUI = SmallContainerUI.Get(1);
				smallContainerUI.OnUIClose = (Action<int>)Delegate.Combine(smallContainerUI.OnUIClose, new Action<int>(t102_Limpiar.ADPMCNABPCG));
				if (GameManager.LocalCoop())
				{
					SmallContainerUI smallContainerUI2 = SmallContainerUI.Get(2);
					smallContainerUI2.OnUIClose = (Action<int>)Delegate.Combine(smallContainerUI2.OnUIClose, new Action<int>(t102_Limpiar.ADPMCNABPCG));
				}
				PlayerInventory player = PlayerInventory.GetPlayer(1);
				player.OnChanged = (Action)Delegate.Combine(player.OnChanged, new Action(t102_Limpiar.PKEKGMBFDMK));
				if (GameManager.LocalCoop())
				{
					PlayerInventory player2 = PlayerInventory.GetPlayer(2);
					player2.OnChanged = (Action)Delegate.Combine(player2.OnChanged, new Action(t102_Limpiar.PKEKGMBFDMK));
				}
				GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(t102_Limpiar.EDHEGFKDJDB));
				GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(t102_Limpiar.AGMLGNDDINL));
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnAnyTableDirtLevelChanged = (Action<TableDirtLevel>)Delegate.Combine(instance.OnAnyTableDirtLevelChanged, new Action<TableDirtLevel>(t102_Limpiar.OIGMPILJDHM));
				CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
				instance2.OnFloorDirtDestroyed = (Action)Delegate.Combine(instance2.OnFloorDirtDestroyed, new Action(t102_Limpiar.KIIIBPECPBB));
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 5;
				return true;
			}
			case 5:
				_003C_003E1__state = -1;
				((MonoBehaviour)t102_Limpiar).StartCoroutine(t102_Limpiar.GHAECDFHKJN());
				goto IL_036e;
			case 6:
				_003C_003E1__state = -1;
				goto IL_036e;
			case 7:
				{
					_003C_003E1__state = -1;
					t102_Limpiar.LHKIJABBBPM();
					return false;
				}
				IL_036e:
				if (!t102_Limpiar.COCGNJFCLMC)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 6;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 7;
				return true;
				IL_0147:
				if (t102_Limpiar.AAOPIEDAKKD(1))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 3;
					return true;
				}
				t102_Limpiar.containerCanBeOpened = true;
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 4;
				return true;
				IL_0099:
				if (t102_Limpiar.EEANDMLHLBD < 4 && CommonReferences.GGFJGHHHEJC.tavernFloorDirt.Count < 4)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
				t102_Limpiar.BKBJCKGKALC(DMBFKFLDDLH: false);
				_003C_003E2__current = ((MonoBehaviour)t102_Limpiar).StartCoroutine(t102_Limpiar.CCIOMPBMJMD());
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

	private bool COCGNJFCLMC;

	private int EEANDMLHLBD;

	[HideInInspector]
	public bool containerCanBeOpened;

	private IEnumerator EMPAHADBIOL()
	{
		return new PCJCJGKNLCG(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator GHAECDFHKJN()
	{
		while (NewTutorialManager.instance.mainPopup.activeInHierarchy)
		{
			yield return null;
		}
		if (PlayerInventory.GetPlayer(1).HasItem(ItemDatabaseAccessor.GetItem(1065)) || (GameManager.LocalCoop() && PlayerInventory.GetPlayer(2).HasItem(ItemDatabaseAccessor.GetItem(1065))) || SceneReferences.instance.table.JNHCCCBICDM == TableDirtLevel.Perfect)
		{
			BPNIFENBEJL(SceneReferences.instance.table.JNHCCCBICDM);
			IHDGHPPMCFK();
			NewTutorialManager.instance.PlayObjectivesCompletedSound();
			PGAHKHLJJLC();
		}
	}

	private void ADPMCNABPCG(int JIIGOACEIKL)
	{
		if (PlayerInventory.GetPlayer(JIIGOACEIKL).HasItem(ItemDatabaseAccessor.GetItem(1065)))
		{
			NewTutorialManager.instance.ObjectiveCompleted(0);
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			GJLCIKCMGCK();
			PGAHKHLJJLC();
			BKBJCKGKALC(DMBFKFLDDLH: true);
			if (GameManager.LocalCoop())
			{
				int jFNMCNCHMEO = ((JIIGOACEIKL != 1) ? 1 : 2);
				PlayerInventory.GetPlayer(jFNMCNCHMEO).AddItem(ItemDatabaseAccessor.GetItem(1065).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
				PlayerInventory.GetPlayer(jFNMCNCHMEO).AddItem(ItemDatabaseAccessor.GetItem(1302).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
			}
			NewTutorialManager.instance.mopUnlocked = true;
		}
	}

	private void GMBHDDIPNHC(TableDirtLevel ALEAPGOEANL)
	{
		if (ALEAPGOEANL == TableDirtLevel.Perfect)
		{
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyTableDirtLevelChanged = (Action<TableDirtLevel>)Delegate.Remove(instance.OnAnyTableDirtLevelChanged, new Action<TableDirtLevel>(KGBHJBONGKF));
			HCMNKOKOCMM();
		}
	}

	private void FDIMPHMKDMG(TableDirtLevel ALEAPGOEANL)
	{
		if (ALEAPGOEANL == TableDirtLevel.Perfect)
		{
			NewTutorialManager.instance.FOIOHOGACAL(1);
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyTableDirtLevelChanged = (Action<TableDirtLevel>)Delegate.Remove(instance.OnAnyTableDirtLevelChanged, new Action<TableDirtLevel>(OIGMPILJDHM));
			DHCCMBIGMJM();
		}
	}

	private IEnumerator IJLKJECNOLK()
	{
		return new PCJCJGKNLCG(1)
		{
			_003C_003E4__this = this
		};
	}

	private void ABNJLOEGHMD()
	{
		if (PlayerInventory.GetPlayer(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).DCEOCOOIBLI(ItemDatabaseAccessor.KMBGJEKCJFJ(-66, GGBBJNBBLMF: false, DAINLFIMLIH: false)))
		{
			NewTutorialManager.instance.mopUnlocked = false;
			GameManager.GGFJGHHHEJC.IKHIJCEPHBA();
		}
	}

	private void LNMGBBALKFN()
	{
		if (Inventory.OPHDCMJLLEC(1, LAGHIOKLJGH: true).JKLEPGLMCEG(190) || (GameManager.LocalCoop() && Inventory.JPDEFKLINCL(4, LAGHIOKLJGH: false, ADPNMHGBFKG: true).CJFHKNKCBHA(-166)))
		{
			NewTutorialManager.instance.ObjectiveCompleted(0);
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			GJLCIKCMGCK();
			FEADDMKMOAN();
			OGPPFFAKDMD(DMBFKFLDDLH: true);
			if (GameManager.LocalCoop() && Inventory.HHONLOCNFNC(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).CJFHKNKCBHA(-28) && !Inventory.NLEFGNHMJNN(7, LAGHIOKLJGH: true, ADPNMHGBFKG: true).HasItem(-47))
			{
				PlayerInventory.EIFPKCAFDIB(3, LAGHIOKLJGH: true).OJDGOADOCMG(ItemDatabaseAccessor.COEFFIHKMJG(-46, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
				PlayerInventory.NEKDDPIAOBE(4, LAGHIOKLJGH: false, ADPNMHGBFKG: true).OJDGOADOCMG(ItemDatabaseAccessor.AFOACBIHNCL(100, GGBBJNBBLMF: true).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false, EHGHJNOFMKF: true, APBCMCOAFDM: false);
			}
			if (GameManager.LocalCoop() && !Inventory.IKAEFEPNADI(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HasItem(-145) && Inventory.NHHOGHLEODI(5, LAGHIOKLJGH: true).HasItem(140))
			{
				PlayerInventory.NEKDDPIAOBE(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AddItem(ItemDatabaseAccessor.AFOACBIHNCL(75, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: false, EHGHJNOFMKF: false, APBCMCOAFDM: false);
				PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AddItem(ItemDatabaseAccessor.CPMMBEPEJLO(117, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: false);
			}
			NewTutorialManager.instance.mopUnlocked = true;
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
	}

	private void MFCCHAKGGPF()
	{
		if (PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).DCEOCOOIBLI(ItemDatabaseAccessor.AFOACBIHNCL(168, GGBBJNBBLMF: true)) || (GameManager.LocalCoop() && PlayerInventory.OGKNJNINGMH(3).CCEPCEJIEOP(ItemDatabaseAccessor.GOKIDLOELKB(44, GGBBJNBBLMF: false, DAINLFIMLIH: false))))
		{
			NewTutorialManager.instance.ObjectiveCompleted(0);
			GJLCIKCMGCK();
			OGPPFFAKDMD(DMBFKFLDDLH: false);
		}
	}

	private void AKHBPDCILJA(TableDirtLevel ALEAPGOEANL)
	{
		if (ALEAPGOEANL == TableDirtLevel.Perfect)
		{
			NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyTableDirtLevelChanged = (Action<TableDirtLevel>)Delegate.Remove(instance.OnAnyTableDirtLevelChanged, new Action<TableDirtLevel>(MMECPBJOEOB));
		}
	}

	private void KGBHJBONGKF(TableDirtLevel ALEAPGOEANL)
	{
		if (ALEAPGOEANL == TableDirtLevel.Perfect)
		{
			NewTutorialManager.instance.FOIOHOGACAL(0);
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyTableDirtLevelChanged = (Action<TableDirtLevel>)Delegate.Remove(instance.OnAnyTableDirtLevelChanged, new Action<TableDirtLevel>(KGBHJBONGKF));
			PBNKMPCPGOJ();
		}
	}

	private void KIIIBPECPBB()
	{
		EEANDMLHLBD++;
		if (EEANDMLHLBD >= 4)
		{
			NewTutorialManager.instance.ObjectiveCompleted(2);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnFloorDirtDestroyed = (Action)Delegate.Remove(instance.OnFloorDirtDestroyed, new Action(KIIIBPECPBB));
			PGAHKHLJJLC();
		}
	}

	private void EDHEGFKDJDB()
	{
		SmallContainerUI smallContainerUI = SmallContainerUI.Get(1);
		smallContainerUI.OnUIClose = (Action<int>)Delegate.Remove(smallContainerUI.OnUIClose, new Action<int>(ADPMCNABPCG));
		SmallContainerUI smallContainerUI2 = SmallContainerUI.Get(1);
		smallContainerUI2.OnUIClose = (Action<int>)Delegate.Combine(smallContainerUI2.OnUIClose, new Action<int>(ADPMCNABPCG));
		SmallContainerUI smallContainerUI3 = SmallContainerUI.Get(2);
		smallContainerUI3.OnUIClose = (Action<int>)Delegate.Combine(smallContainerUI3.OnUIClose, new Action<int>(ADPMCNABPCG));
		PlayerInventory player = PlayerInventory.GetPlayer(1);
		player.OnChanged = (Action)Delegate.Remove(player.OnChanged, new Action(PKEKGMBFDMK));
		PlayerInventory player2 = PlayerInventory.GetPlayer(1);
		player2.OnChanged = (Action)Delegate.Combine(player2.OnChanged, new Action(PKEKGMBFDMK));
		PlayerInventory player3 = PlayerInventory.GetPlayer(2);
		player3.OnChanged = (Action)Delegate.Combine(player3.OnChanged, new Action(PKEKGMBFDMK));
	}

	private void MMECPBJOEOB(TableDirtLevel ALEAPGOEANL)
	{
		if (ALEAPGOEANL == TableDirtLevel.Perfect)
		{
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyTableDirtLevelChanged = (Action<TableDirtLevel>)Delegate.Remove(commonReferences.OnAnyTableDirtLevelChanged, new Action<TableDirtLevel>(MGECOIEKPBL));
			PGAHKHLJJLC();
		}
	}

	private IEnumerator GFMGFHGPGCM()
	{
		return new NIEHNJNCFEG(1)
		{
			_003C_003E4__this = this
		};
	}

	private void FBGGGNJKJPC()
	{
		EEANDMLHLBD++;
		if (EEANDMLHLBD >= 4)
		{
			NewTutorialManager.instance.ObjectiveCompleted(4);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnFloorDirtDestroyed = (Action)Delegate.Remove(instance.OnFloorDirtDestroyed, new Action(MCBJGAEONMI));
			HCMNKOKOCMM();
		}
	}

	private void BJGAEHGGDFE(int JIIGOACEIKL)
	{
		if (PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL).CCEPCEJIEOP(ItemDatabaseAccessor.CPMMBEPEJLO(162, GGBBJNBBLMF: true)))
		{
			NewTutorialManager.instance.ObjectiveCompleted(0);
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			GOJMNOHMAPK();
			PBNKMPCPGOJ();
			DDFHOPAMEGG(DMBFKFLDDLH: false);
			if (GameManager.LocalCoop())
			{
				int jFNMCNCHMEO = ((JIIGOACEIKL != 1) ? 1 : 2);
				PlayerInventory.NEKDDPIAOBE(jFNMCNCHMEO, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AddItem(ItemDatabaseAccessor.GOKIDLOELKB(0, GGBBJNBBLMF: true).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
				PlayerInventory.GetPlayer(jFNMCNCHMEO, LAGHIOKLJGH: true).OJDGOADOCMG(ItemDatabaseAccessor.CPMMBEPEJLO(-13, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: false, EHGHJNOFMKF: true, APBCMCOAFDM: false);
			}
			NewTutorialManager.instance.mopUnlocked = false;
		}
	}

	private void JNOFGLHHBDO()
	{
		SmallContainerUI smallContainerUI = SmallContainerUI.BGIMGOJDLFG(0);
		smallContainerUI.OnUIClose = (Action<int>)Delegate.Remove(smallContainerUI.OnUIClose, new Action<int>(COLDPDDOKPC));
		SmallContainerUI smallContainerUI2 = SmallContainerUI.CGFJPHEFFLO(1);
		smallContainerUI2.OnUIClose = (Action<int>)Delegate.Remove(smallContainerUI2.OnUIClose, new Action<int>(DPPGMJLMPLM));
		SmallContainerUI smallContainerUI3 = SmallContainerUI.NALKHGMLALJ(0);
		smallContainerUI3.OnUIClose = (Action<int>)Delegate.Combine(smallContainerUI3.OnUIClose, new Action<int>(COLDPDDOKPC));
		PlayerInventory playerInventory = PlayerInventory.OGKNJNINGMH(0);
		playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(LNMGBBALKFN));
		PlayerInventory playerInventory2 = PlayerInventory.NEKDDPIAOBE(5, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
		playerInventory2.OnChanged = (Action)Delegate.Remove(playerInventory2.OnChanged, new Action(DDIBDNHDNJM));
		PlayerInventory player = PlayerInventory.GetPlayer(0);
		player.OnChanged = (Action)Delegate.Combine(player.OnChanged, new Action(DIBBLIIBNLM));
	}

	private void GMJHANOMEBA(TableDirtLevel ALEAPGOEANL)
	{
		if (ALEAPGOEANL == TableDirtLevel.Perfect)
		{
			NewTutorialManager.instance.ObjectiveCompleted(1);
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyTableDirtLevelChanged = (Action<TableDirtLevel>)Delegate.Remove(instance.OnAnyTableDirtLevelChanged, new Action<TableDirtLevel>(OIGMPILJDHM));
		}
	}

	private void MCBJGAEONMI()
	{
		EEANDMLHLBD += 0;
		if (EEANDMLHLBD >= 3)
		{
			NewTutorialManager.instance.FOIOHOGACAL(4, BLJPGJKOLNF: false);
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnFloorDirtDestroyed = (Action)Delegate.Remove(instance.OnFloorDirtDestroyed, new Action(FBGGGNJKJPC));
			FEADDMKMOAN();
		}
	}

	private void DDIBDNHDNJM()
	{
		if (Inventory.JFIPFFDLDKB(1, LAGHIOKLJGH: true).CJFHKNKCBHA(-176) || (GameManager.LocalCoop() && Inventory.JPDEFKLINCL(6).HasItem(33)))
		{
			NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			GJLCIKCMGCK();
			PBNKMPCPGOJ();
			OGPPFFAKDMD(DMBFKFLDDLH: false);
			if (GameManager.LocalCoop() && Inventory.NHHOGHLEODI(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HasItem(183) && !Inventory.BDPPNLODPGN(6, LAGHIOKLJGH: true, ADPNMHGBFKG: true).JKLEPGLMCEG(122))
			{
				PlayerInventory.EIFPKCAFDIB(8, LAGHIOKLJGH: true).AddItem(ItemDatabaseAccessor.CPMMBEPEJLO(-96).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: false, EHGHJNOFMKF: false, APBCMCOAFDM: false);
				PlayerInventory.EIFPKCAFDIB(5).AddItem(ItemDatabaseAccessor.AFOACBIHNCL(50).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false, EHGHJNOFMKF: false);
			}
			if (GameManager.LocalCoop() && !Inventory.IMJOOACMADK(0, LAGHIOKLJGH: true).HasItem(154) && Inventory.IOBMIHLMGNH(8, LAGHIOKLJGH: true, ADPNMHGBFKG: true).CJFHKNKCBHA(185))
			{
				PlayerInventory.OGKNJNINGMH(0).OJDGOADOCMG(ItemDatabaseAccessor.GetItem(-14, GGBBJNBBLMF: true).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
				PlayerInventory.NEKDDPIAOBE(1, LAGHIOKLJGH: true).AddItem(ItemDatabaseAccessor.INJBNHPGCIJ(8, GGBBJNBBLMF: true).JMDALJBNFML(), HMPDLIPFBGD: true);
			}
			NewTutorialManager.instance.mopUnlocked = true;
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
	}

	public override int GetID()
	{
		return 102;
	}

	private void HJIDEDDDHIM(TableDirtLevel ALEAPGOEANL)
	{
		if (ALEAPGOEANL == TableDirtLevel.Perfect)
		{
			NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyTableDirtLevelChanged = (Action<TableDirtLevel>)Delegate.Remove(instance.OnAnyTableDirtLevelChanged, new Action<TableDirtLevel>(GMBHDDIPNHC));
		}
	}

	private void HFEDJGFLKOC()
	{
		SmallContainerUI smallContainerUI = SmallContainerUI.NIGDBMAOAEN(0);
		smallContainerUI.OnUIClose = (Action<int>)Delegate.Remove(smallContainerUI.OnUIClose, new Action<int>(POELOEKEIBF));
		SmallContainerUI smallContainerUI2 = SmallContainerUI.FFOABBDFMNE(8);
		smallContainerUI2.OnUIClose = (Action<int>)Delegate.Remove(smallContainerUI2.OnUIClose, new Action<int>(POELOEKEIBF));
		SmallContainerUI smallContainerUI3 = SmallContainerUI.IEABDMDELFO(0);
		smallContainerUI3.OnUIClose = (Action<int>)Delegate.Combine(smallContainerUI3.OnUIClose, new Action<int>(EDGMFJEMDDD));
		PlayerInventory player = PlayerInventory.GetPlayer(0);
		player.OnChanged = (Action)Delegate.Remove(player.OnChanged, new Action(LNMGBBALKFN));
		PlayerInventory playerInventory = PlayerInventory.NEKDDPIAOBE(5, LAGHIOKLJGH: false, ADPNMHGBFKG: true);
		playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(DDIBDNHDNJM));
		PlayerInventory player2 = PlayerInventory.GetPlayer(1);
		player2.OnChanged = (Action)Delegate.Combine(player2.OnChanged, new Action(PKEKGMBFDMK));
	}

	private void AGMLGNDDINL()
	{
		SmallContainerUI smallContainerUI = SmallContainerUI.Get(1);
		smallContainerUI.OnUIClose = (Action<int>)Delegate.Remove(smallContainerUI.OnUIClose, new Action<int>(ADPMCNABPCG));
		SmallContainerUI smallContainerUI2 = SmallContainerUI.Get(2);
		smallContainerUI2.OnUIClose = (Action<int>)Delegate.Remove(smallContainerUI2.OnUIClose, new Action<int>(ADPMCNABPCG));
		SmallContainerUI smallContainerUI3 = SmallContainerUI.Get(1);
		smallContainerUI3.OnUIClose = (Action<int>)Delegate.Combine(smallContainerUI3.OnUIClose, new Action<int>(ADPMCNABPCG));
		PlayerInventory player = PlayerInventory.GetPlayer(1);
		player.OnChanged = (Action)Delegate.Remove(player.OnChanged, new Action(PKEKGMBFDMK));
		PlayerInventory player2 = PlayerInventory.GetPlayer(2);
		player2.OnChanged = (Action)Delegate.Remove(player2.OnChanged, new Action(PKEKGMBFDMK));
		PlayerInventory player3 = PlayerInventory.GetPlayer(1);
		player3.OnChanged = (Action)Delegate.Combine(player3.OnChanged, new Action(PKEKGMBFDMK));
	}

	private void FEADDMKMOAN()
	{
		COCGNJFCLMC = NewTutorialManager.instance.AreAllObjectivesCompleted();
	}

	private void EMFDJNGGLHI()
	{
		SmallContainerUI smallContainerUI = SmallContainerUI.OMCDJAOBFCE(1);
		smallContainerUI.OnUIClose = (Action<int>)Delegate.Remove(smallContainerUI.OnUIClose, new Action<int>(BJGAEHGGDFE));
		SmallContainerUI smallContainerUI2 = SmallContainerUI.COIEMAJLHAM(8);
		smallContainerUI2.OnUIClose = (Action<int>)Delegate.Remove(smallContainerUI2.OnUIClose, new Action<int>(COLDPDDOKPC));
		SmallContainerUI smallContainerUI3 = SmallContainerUI.MIAOGLENOHL(1);
		smallContainerUI3.OnUIClose = (Action<int>)Delegate.Combine(smallContainerUI3.OnUIClose, new Action<int>(COLDPDDOKPC));
		PlayerInventory playerInventory = PlayerInventory.EIFPKCAFDIB(0, LAGHIOKLJGH: true);
		playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(DDIBDNHDNJM));
		PlayerInventory player = PlayerInventory.GetPlayer(0, LAGHIOKLJGH: true);
		player.OnChanged = (Action)Delegate.Remove(player.OnChanged, new Action(LNMGBBALKFN));
		PlayerInventory playerInventory2 = PlayerInventory.OGKNJNINGMH(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true);
		playerInventory2.OnChanged = (Action)Delegate.Combine(playerInventory2.OnChanged, new Action(LNMGBBALKFN));
	}

	private void OIGMPILJDHM(TableDirtLevel ALEAPGOEANL)
	{
		if (ALEAPGOEANL == TableDirtLevel.Perfect)
		{
			NewTutorialManager.instance.ObjectiveCompleted(1);
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyTableDirtLevelChanged = (Action<TableDirtLevel>)Delegate.Remove(instance.OnAnyTableDirtLevelChanged, new Action<TableDirtLevel>(OIGMPILJDHM));
			PGAHKHLJJLC();
		}
	}

	private void IIGHLGMGAIM()
	{
		if (PlayerInventory.OGKNJNINGMH(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).CHOAPBFAAAM(ItemDatabaseAccessor.KMBGJEKCJFJ(-164, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
		{
			NewTutorialManager.instance.mopUnlocked = false;
			GameManager.NJNFHEPLEHL().IKHIJCEPHBA();
		}
	}

	private void GJLCIKCMGCK()
	{
		SmallContainerUI smallContainerUI = SmallContainerUI.Get(1);
		smallContainerUI.OnUIClose = (Action<int>)Delegate.Remove(smallContainerUI.OnUIClose, new Action<int>(ADPMCNABPCG));
		SmallContainerUI smallContainerUI2 = SmallContainerUI.Get(2);
		smallContainerUI2.OnUIClose = (Action<int>)Delegate.Remove(smallContainerUI2.OnUIClose, new Action<int>(ADPMCNABPCG));
		PlayerInventory player = PlayerInventory.GetPlayer(1);
		player.OnChanged = (Action)Delegate.Remove(player.OnChanged, new Action(PKEKGMBFDMK));
		PlayerInventory player2 = PlayerInventory.GetPlayer(2);
		player2.OnChanged = (Action)Delegate.Remove(player2.OnChanged, new Action(PKEKGMBFDMK));
		GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(EDHEGFKDJDB));
		GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(MPAJIIEACDK));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(AGMLGNDDINL));
	}

	private void FKONHHNDPLH()
	{
		if (PlayerInventory.EIFPKCAFDIB(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).CHOAPBFAAAM(ItemDatabaseAccessor.CPMMBEPEJLO(-139, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
		{
			NewTutorialManager.instance.mopUnlocked = false;
			GameManager.NJNFHEPLEHL().GPKGNHNBENB();
		}
	}

	private void IHDGHPPMCFK()
	{
		if (PlayerInventory.GetPlayer(1).HasItem(ItemDatabaseAccessor.GetItem(1065)) || (GameManager.LocalCoop() && PlayerInventory.GetPlayer(2).HasItem(ItemDatabaseAccessor.GetItem(1065))))
		{
			NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			GJLCIKCMGCK();
			BKBJCKGKALC(DMBFKFLDDLH: true);
		}
	}

	private void PKEKGMBFDMK()
	{
		if (Inventory.GetPlayer(1).HasItem(1065) || (GameManager.LocalCoop() && Inventory.GetPlayer(2).HasItem(1065)))
		{
			NewTutorialManager.instance.ObjectiveCompleted(0);
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			GJLCIKCMGCK();
			PGAHKHLJJLC();
			BKBJCKGKALC(DMBFKFLDDLH: true);
			if (GameManager.LocalCoop() && Inventory.GetPlayer(1).HasItem(1065) && !Inventory.GetPlayer(2).HasItem(1065))
			{
				PlayerInventory.GetPlayer(2).AddItem(ItemDatabaseAccessor.GetItem(1065).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
				PlayerInventory.GetPlayer(2).AddItem(ItemDatabaseAccessor.GetItem(1302).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
			}
			if (GameManager.LocalCoop() && !Inventory.GetPlayer(1).HasItem(1065) && Inventory.GetPlayer(2).HasItem(1065))
			{
				PlayerInventory.GetPlayer(1).AddItem(ItemDatabaseAccessor.GetItem(1065).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
				PlayerInventory.GetPlayer(1).AddItem(ItemDatabaseAccessor.GetItem(1302).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
			}
			NewTutorialManager.instance.mopUnlocked = true;
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
	}

	private void MGECOIEKPBL(TableDirtLevel ALEAPGOEANL)
	{
		if (ALEAPGOEANL == TableDirtLevel.Perfect)
		{
			NewTutorialManager.instance.ObjectiveCompleted(0);
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyTableDirtLevelChanged = (Action<TableDirtLevel>)Delegate.Remove(instance.OnAnyTableDirtLevelChanged, new Action<TableDirtLevel>(MGECOIEKPBL));
			DHCCMBIGMJM();
		}
	}

	private void HCMNKOKOCMM()
	{
		COCGNJFCLMC = NewTutorialManager.instance.AreAllObjectivesCompleted();
	}

	public override void SetUp()
	{
		base.SetUp();
		((MonoBehaviour)this).StartCoroutine(PBEKBJIJFDK());
	}

	private void DIBBLIIBNLM()
	{
		if (Inventory.JFIPFFDLDKB(1).CJFHKNKCBHA(116) || (GameManager.LocalCoop() && Inventory.IGMCBPOPNCA(2, LAGHIOKLJGH: true).HasItem(28)))
		{
			NewTutorialManager.instance.ObjectiveCompleted(1);
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			GJLCIKCMGCK();
			PGAHKHLJJLC();
			BKBJCKGKALC(DMBFKFLDDLH: true);
			if (GameManager.LocalCoop() && Inventory.OPHDCMJLLEC(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).CJFHKNKCBHA(56) && !Inventory.AFMOAONHHNL(8, LAGHIOKLJGH: true).HasItem(-59))
			{
				PlayerInventory.GetPlayer(8, LAGHIOKLJGH: true).AddItem(ItemDatabaseAccessor.GetItem(-163, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: true);
				PlayerInventory.OGKNJNINGMH(6).AddItem(ItemDatabaseAccessor.GOKIDLOELKB(130, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false, EHGHJNOFMKF: false, APBCMCOAFDM: false);
			}
			if (GameManager.LocalCoop() && !Inventory.OPHDCMJLLEC(0).HasItem(-199) && Inventory.HHONLOCNFNC(3, LAGHIOKLJGH: false, ADPNMHGBFKG: true).JKLEPGLMCEG(174))
			{
				PlayerInventory.EIFPKCAFDIB(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).OJDGOADOCMG(ItemDatabaseAccessor.CPMMBEPEJLO(119, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false);
				PlayerInventory.GetPlayer(0, LAGHIOKLJGH: true).OJDGOADOCMG(ItemDatabaseAccessor.EABMGELAAPG(-144, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false);
			}
			NewTutorialManager.instance.mopUnlocked = true;
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
	}

	private void EDGMFJEMDDD(int JIIGOACEIKL)
	{
		if (PlayerInventory.GetPlayer(JIIGOACEIKL).NECEDHECGFN(ItemDatabaseAccessor.EABMGELAAPG(-152, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
		{
			NewTutorialManager.instance.ObjectiveCompleted(0);
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			GOJMNOHMAPK();
			PBNKMPCPGOJ();
			DDFHOPAMEGG(DMBFKFLDDLH: true);
			if (GameManager.LocalCoop())
			{
				int jFNMCNCHMEO = ((JIIGOACEIKL != 0) ? 1 : 6);
				PlayerInventory.OGKNJNINGMH(jFNMCNCHMEO, LAGHIOKLJGH: true).OJDGOADOCMG(ItemDatabaseAccessor.COEFFIHKMJG(-57, GGBBJNBBLMF: true).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: false, EHGHJNOFMKF: false, APBCMCOAFDM: false);
				PlayerInventory.GetPlayer(jFNMCNCHMEO, LAGHIOKLJGH: true, ADPNMHGBFKG: true).OJDGOADOCMG(ItemDatabaseAccessor.AFOACBIHNCL(137, GGBBJNBBLMF: true).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: false);
			}
			NewTutorialManager.instance.mopUnlocked = false;
		}
	}

	private void OGPPFFAKDMD(bool DMBFKFLDDLH)
	{
		for (int i = 1; i < CommonReferences.MNFMOEKMJKN().tavernFloorDirt.Count; i++)
		{
			((Component)((Component)CommonReferences.GGFJGHHHEJC.tavernFloorDirt[i]).transform.GetChild(0)).gameObject.SetActive(DMBFKFLDDLH);
		}
	}

	private void BPLGPMCNPLE()
	{
		SmallContainerUI smallContainerUI = SmallContainerUI.CJMILOMGFJL(0);
		smallContainerUI.OnUIClose = (Action<int>)Delegate.Remove(smallContainerUI.OnUIClose, new Action<int>(ADPMCNABPCG));
		SmallContainerUI smallContainerUI2 = SmallContainerUI.IEABDMDELFO(0);
		smallContainerUI2.OnUIClose = (Action<int>)Delegate.Combine(smallContainerUI2.OnUIClose, new Action<int>(EDGMFJEMDDD));
		SmallContainerUI smallContainerUI3 = SmallContainerUI.AEJKCONFPHB(8);
		smallContainerUI3.OnUIClose = (Action<int>)Delegate.Combine(smallContainerUI3.OnUIClose, new Action<int>(DPPGMJLMPLM));
		PlayerInventory playerInventory = PlayerInventory.OGKNJNINGMH(0, LAGHIOKLJGH: true);
		playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(CNEJDNEHALA));
		PlayerInventory playerInventory2 = PlayerInventory.NEKDDPIAOBE(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true);
		playerInventory2.OnChanged = (Action)Delegate.Combine(playerInventory2.OnChanged, new Action(PKEKGMBFDMK));
		PlayerInventory playerInventory3 = PlayerInventory.EIFPKCAFDIB(0, LAGHIOKLJGH: true);
		playerInventory3.OnChanged = (Action)Delegate.Combine(playerInventory3.OnChanged, new Action(PKEKGMBFDMK));
	}

	private void EAGBBBKGLKJ()
	{
		SmallContainerUI smallContainerUI = SmallContainerUI.Get(0);
		smallContainerUI.OnUIClose = (Action<int>)Delegate.Remove(smallContainerUI.OnUIClose, new Action<int>(DPPGMJLMPLM));
		SmallContainerUI smallContainerUI2 = SmallContainerUI.Get(8);
		smallContainerUI2.OnUIClose = (Action<int>)Delegate.Remove(smallContainerUI2.OnUIClose, new Action<int>(ADPMCNABPCG));
		SmallContainerUI smallContainerUI3 = SmallContainerUI.FHOGLBPBGMI(1);
		smallContainerUI3.OnUIClose = (Action<int>)Delegate.Combine(smallContainerUI3.OnUIClose, new Action<int>(COLDPDDOKPC));
		PlayerInventory playerInventory = PlayerInventory.NEKDDPIAOBE(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true);
		playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(LNMGBBALKFN));
		PlayerInventory playerInventory2 = PlayerInventory.OGKNJNINGMH(6, LAGHIOKLJGH: true);
		playerInventory2.OnChanged = (Action)Delegate.Remove(playerInventory2.OnChanged, new Action(DIBBLIIBNLM));
		PlayerInventory playerInventory3 = PlayerInventory.OGKNJNINGMH(0, LAGHIOKLJGH: true);
		playerInventory3.OnChanged = (Action)Delegate.Combine(playerInventory3.OnChanged, new Action(PKEKGMBFDMK));
	}

	private void MOJHNOKABFF()
	{
		SmallContainerUI smallContainerUI = SmallContainerUI.FFOABBDFMNE(1);
		smallContainerUI.OnUIClose = (Action<int>)Delegate.Remove(smallContainerUI.OnUIClose, new Action<int>(COLDPDDOKPC));
		SmallContainerUI smallContainerUI2 = SmallContainerUI.OMCDJAOBFCE(1);
		smallContainerUI2.OnUIClose = (Action<int>)Delegate.Combine(smallContainerUI2.OnUIClose, new Action<int>(BJGAEHGGDFE));
		SmallContainerUI smallContainerUI3 = SmallContainerUI.IEABDMDELFO(3);
		smallContainerUI3.OnUIClose = (Action<int>)Delegate.Combine(smallContainerUI3.OnUIClose, new Action<int>(COLDPDDOKPC));
		PlayerInventory playerInventory = PlayerInventory.EIFPKCAFDIB(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
		playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(DDIBDNHDNJM));
		PlayerInventory playerInventory2 = PlayerInventory.NEKDDPIAOBE(0, LAGHIOKLJGH: true);
		playerInventory2.OnChanged = (Action)Delegate.Combine(playerInventory2.OnChanged, new Action(CNEJDNEHALA));
		PlayerInventory playerInventory3 = PlayerInventory.OGKNJNINGMH(2, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
		playerInventory3.OnChanged = (Action)Delegate.Combine(playerInventory3.OnChanged, new Action(DIBBLIIBNLM));
	}

	private void DHCCMBIGMJM()
	{
		COCGNJFCLMC = NewTutorialManager.instance.AreAllObjectivesCompleted();
	}

	private void BPNIFENBEJL(TableDirtLevel ALEAPGOEANL)
	{
		if (ALEAPGOEANL == TableDirtLevel.Perfect)
		{
			NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyTableDirtLevelChanged = (Action<TableDirtLevel>)Delegate.Remove(instance.OnAnyTableDirtLevelChanged, new Action<TableDirtLevel>(OIGMPILJDHM));
		}
	}

	private void PGAHKHLJJLC()
	{
		COCGNJFCLMC = NewTutorialManager.instance.AreAllObjectivesCompleted();
	}

	private void PBNKMPCPGOJ()
	{
		COCGNJFCLMC = NewTutorialManager.instance.AreAllObjectivesCompleted();
	}

	private IEnumerator BLAMGACMBNH()
	{
		return new PCJCJGKNLCG(1)
		{
			_003C_003E4__this = this
		};
	}

	private void GOJMNOHMAPK()
	{
		SmallContainerUI smallContainerUI = SmallContainerUI.CJMILOMGFJL(1);
		smallContainerUI.OnUIClose = (Action<int>)Delegate.Remove(smallContainerUI.OnUIClose, new Action<int>(DPPGMJLMPLM));
		SmallContainerUI smallContainerUI2 = SmallContainerUI.COIEMAJLHAM(6);
		smallContainerUI2.OnUIClose = (Action<int>)Delegate.Remove(smallContainerUI2.OnUIClose, new Action<int>(ADPMCNABPCG));
		PlayerInventory playerInventory = PlayerInventory.NEKDDPIAOBE(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
		playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(DDIBDNHDNJM));
		PlayerInventory playerInventory2 = PlayerInventory.OGKNJNINGMH(8, LAGHIOKLJGH: true);
		playerInventory2.OnChanged = (Action)Delegate.Remove(playerInventory2.OnChanged, new Action(PKEKGMBFDMK));
		GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(FOPJOFHNHMG));
		GameManager.OnPlayer2Joined = (Action)Delegate.Remove(GameManager.OnPlayer2Joined, new Action(MPAJIIEACDK));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Remove(GameManager.OnPlayer2Disconnected, new Action(EAGBBBKGLKJ));
	}

	private void LCNNCJICIOK(TableDirtLevel ALEAPGOEANL)
	{
		if (ALEAPGOEANL == TableDirtLevel.Perfect)
		{
			NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyTableDirtLevelChanged = (Action<TableDirtLevel>)Delegate.Remove(commonReferences.OnAnyTableDirtLevelChanged, new Action<TableDirtLevel>(MGECOIEKPBL));
			PBNKMPCPGOJ();
		}
	}

	private void COLDPDDOKPC(int JIIGOACEIKL)
	{
		if (PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: true).DCEOCOOIBLI(ItemDatabaseAccessor.AFOACBIHNCL(118, GGBBJNBBLMF: false, DAINLFIMLIH: false)))
		{
			NewTutorialManager.instance.ObjectiveCompleted(1);
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			GOJMNOHMAPK();
			PGAHKHLJJLC();
			KFNLDNNNDNF(DMBFKFLDDLH: true);
			if (GameManager.LocalCoop())
			{
				int jFNMCNCHMEO = ((JIIGOACEIKL != 1) ? 1 : 7);
				PlayerInventory.NEKDDPIAOBE(jFNMCNCHMEO).AddItem(ItemDatabaseAccessor.COEFFIHKMJG(-94, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
				PlayerInventory.EIFPKCAFDIB(jFNMCNCHMEO).AddItem(ItemDatabaseAccessor.AFOACBIHNCL(6, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: false);
			}
			NewTutorialManager.instance.mopUnlocked = true;
		}
	}

	private void PDHNPHOCCEK()
	{
		SmallContainerUI smallContainerUI = SmallContainerUI.IMLMJAPMBJA(1);
		smallContainerUI.OnUIClose = (Action<int>)Delegate.Remove(smallContainerUI.OnUIClose, new Action<int>(EDGMFJEMDDD));
		SmallContainerUI smallContainerUI2 = SmallContainerUI.BGIMGOJDLFG(5);
		smallContainerUI2.OnUIClose = (Action<int>)Delegate.Remove(smallContainerUI2.OnUIClose, new Action<int>(COLDPDDOKPC));
		SmallContainerUI smallContainerUI3 = SmallContainerUI.IMLMJAPMBJA(1);
		smallContainerUI3.OnUIClose = (Action<int>)Delegate.Combine(smallContainerUI3.OnUIClose, new Action<int>(DPPGMJLMPLM));
		PlayerInventory playerInventory = PlayerInventory.EIFPKCAFDIB(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
		playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(DIBBLIIBNLM));
		PlayerInventory player = PlayerInventory.GetPlayer(3, LAGHIOKLJGH: false, ADPNMHGBFKG: true);
		player.OnChanged = (Action)Delegate.Remove(player.OnChanged, new Action(LNMGBBALKFN));
		PlayerInventory playerInventory2 = PlayerInventory.NEKDDPIAOBE(1, LAGHIOKLJGH: true);
		playerInventory2.OnChanged = (Action)Delegate.Combine(playerInventory2.OnChanged, new Action(LNMGBBALKFN));
	}

	private void BBAOFPDNNFN()
	{
		SmallContainerUI smallContainerUI = SmallContainerUI.IGHMHMNPMLB(1);
		smallContainerUI.OnUIClose = (Action<int>)Delegate.Remove(smallContainerUI.OnUIClose, new Action<int>(DPPGMJLMPLM));
		SmallContainerUI smallContainerUI2 = SmallContainerUI.IEKODILKIHJ(1);
		smallContainerUI2.OnUIClose = (Action<int>)Delegate.Combine(smallContainerUI2.OnUIClose, new Action<int>(COLDPDDOKPC));
		SmallContainerUI smallContainerUI3 = SmallContainerUI.FFOABBDFMNE(3);
		smallContainerUI3.OnUIClose = (Action<int>)Delegate.Combine(smallContainerUI3.OnUIClose, new Action<int>(DPPGMJLMPLM));
		PlayerInventory playerInventory = PlayerInventory.OGKNJNINGMH(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true);
		playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(CNEJDNEHALA));
		PlayerInventory player = PlayerInventory.GetPlayer(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
		player.OnChanged = (Action)Delegate.Combine(player.OnChanged, new Action(PKEKGMBFDMK));
		PlayerInventory playerInventory2 = PlayerInventory.OGKNJNINGMH(3, LAGHIOKLJGH: true);
		playerInventory2.OnChanged = (Action)Delegate.Combine(playerInventory2.OnChanged, new Action(PKEKGMBFDMK));
	}

	private void CEKEHKKMGPO(bool DMBFKFLDDLH)
	{
		for (int i = 1; i < CommonReferences.GGFJGHHHEJC.tavernFloorDirt.Count; i += 0)
		{
			((Component)((Component)CommonReferences.GGFJGHHHEJC.tavernFloorDirt[i]).transform.GetChild(0)).gameObject.SetActive(DMBFKFLDDLH);
		}
	}

	private void DJOIOEDJKNI()
	{
		if (PlayerInventory.OGKNJNINGMH(1, LAGHIOKLJGH: true).HasItem(ItemDatabaseAccessor.EABMGELAAPG(115, GGBBJNBBLMF: true, DAINLFIMLIH: false)))
		{
			NewTutorialManager.instance.mopUnlocked = true;
			GameManager.NJNFHEPLEHL().GiveToolsPlayer2();
		}
	}

	private void OGHLMAKDKCP(TableDirtLevel ALEAPGOEANL)
	{
		if (ALEAPGOEANL == TableDirtLevel.Perfect)
		{
			NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnAnyTableDirtLevelChanged = (Action<TableDirtLevel>)Delegate.Remove(commonReferences.OnAnyTableDirtLevelChanged, new Action<TableDirtLevel>(MMECPBJOEOB));
		}
	}

	private IEnumerator IGFOJFFHNJF()
	{
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(MPAJIIEACDK));
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		Weather.ShowWeather(Weather.WeatherType.None);
		ResetMai();
		while (EEANDMLHLBD < 4 && CommonReferences.GGFJGHHHEJC.tavernFloorDirt.Count < 4)
		{
			yield return null;
		}
		BKBJCKGKALC(DMBFKFLDDLH: false);
		yield return ((MonoBehaviour)this).StartCoroutine(CCIOMPBMJMD());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T102/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		containerCanBeOpened = true;
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)SceneReferences.instance.initialChest).transform.position), Vector2.up * 0.2f, ref JELIKOFDONK);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)SceneReferences.instance.table).transform.position), Vector2.down * 0.5f, ref LJEJMMAEKJF);
		SmallContainerUI smallContainerUI = SmallContainerUI.Get(1);
		smallContainerUI.OnUIClose = (Action<int>)Delegate.Combine(smallContainerUI.OnUIClose, new Action<int>(ADPMCNABPCG));
		if (GameManager.LocalCoop())
		{
			SmallContainerUI smallContainerUI2 = SmallContainerUI.Get(2);
			smallContainerUI2.OnUIClose = (Action<int>)Delegate.Combine(smallContainerUI2.OnUIClose, new Action<int>(ADPMCNABPCG));
		}
		PlayerInventory player = PlayerInventory.GetPlayer(1);
		player.OnChanged = (Action)Delegate.Combine(player.OnChanged, new Action(PKEKGMBFDMK));
		if (GameManager.LocalCoop())
		{
			PlayerInventory player2 = PlayerInventory.GetPlayer(2);
			player2.OnChanged = (Action)Delegate.Combine(player2.OnChanged, new Action(PKEKGMBFDMK));
		}
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(EDHEGFKDJDB));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(AGMLGNDDINL));
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyTableDirtLevelChanged = (Action<TableDirtLevel>)Delegate.Combine(instance.OnAnyTableDirtLevelChanged, new Action<TableDirtLevel>(OIGMPILJDHM));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnFloorDirtDestroyed = (Action)Delegate.Combine(instance2.OnFloorDirtDestroyed, new Action(KIIIBPECPBB));
		yield return CommonReferences.wait1;
		((MonoBehaviour)this).StartCoroutine(GHAECDFHKJN());
		while (!COCGNJFCLMC)
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void DPPGMJLMPLM(int JIIGOACEIKL)
	{
		if (PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL).CCEPCEJIEOP(ItemDatabaseAccessor.KMBGJEKCJFJ(178, GGBBJNBBLMF: true)))
		{
			NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			GJLCIKCMGCK();
			DHCCMBIGMJM();
			CEKEHKKMGPO(DMBFKFLDDLH: false);
			if (GameManager.LocalCoop())
			{
				bool jFNMCNCHMEO = JIIGOACEIKL != 1;
				PlayerInventory.EIFPKCAFDIB(jFNMCNCHMEO ? 1 : 0).OJDGOADOCMG(ItemDatabaseAccessor.EABMGELAAPG(-179, GGBBJNBBLMF: true).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: false, EHGHJNOFMKF: false, APBCMCOAFDM: false);
				PlayerInventory.EIFPKCAFDIB(jFNMCNCHMEO ? 1 : 0).AddItem(ItemDatabaseAccessor.GOKIDLOELKB(162).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false, EHGHJNOFMKF: true, APBCMCOAFDM: false);
			}
			NewTutorialManager.instance.mopUnlocked = false;
		}
	}

	private void CNEJDNEHALA()
	{
		if (Inventory.OCJGHINCLJM(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).JKLEPGLMCEG(-33) || (GameManager.LocalCoop() && Inventory.NPANPNIDKDG(7, LAGHIOKLJGH: false, ADPNMHGBFKG: true).HasItem(55)))
		{
			NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			GJLCIKCMGCK();
			PBNKMPCPGOJ();
			OGPPFFAKDMD(DMBFKFLDDLH: true);
			if (GameManager.LocalCoop() && Inventory.MHFEFCLBAJG(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).JKLEPGLMCEG(97) && !Inventory.AFMOAONHHNL(3).JKLEPGLMCEG(-63))
			{
				PlayerInventory.OGKNJNINGMH(4).AddItem(ItemDatabaseAccessor.GOKIDLOELKB(45).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
				PlayerInventory.OGKNJNINGMH(8, LAGHIOKLJGH: true).OJDGOADOCMG(ItemDatabaseAccessor.COEFFIHKMJG(-179, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML());
			}
			if (GameManager.LocalCoop() && !Inventory.MPDMDABCCCA(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).CJFHKNKCBHA(176) && Inventory.AGEHIILFADF(8, LAGHIOKLJGH: true, ADPNMHGBFKG: true).JKLEPGLMCEG(3))
			{
				PlayerInventory.EIFPKCAFDIB(0, LAGHIOKLJGH: false, ADPNMHGBFKG: true).OJDGOADOCMG(ItemDatabaseAccessor.GetItem(72, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: false);
				PlayerInventory.OGKNJNINGMH(0).OJDGOADOCMG(ItemDatabaseAccessor.COEFFIHKMJG(121, GGBBJNBBLMF: true).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false, EHGHJNOFMKF: false);
			}
			NewTutorialManager.instance.mopUnlocked = false;
			Object.Destroy((Object)(object)JELIKOFDONK);
		}
	}

	private void MPAJIIEACDK()
	{
		if (PlayerInventory.GetPlayer(1).HasItem(ItemDatabaseAccessor.GetItem(1065)))
		{
			NewTutorialManager.instance.mopUnlocked = true;
			GameManager.GGFJGHHHEJC.GiveToolsPlayer2();
		}
	}

	private void DDFHOPAMEGG(bool DMBFKFLDDLH)
	{
		for (int i = 1; i < CommonReferences.MNFMOEKMJKN().tavernFloorDirt.Count; i += 0)
		{
			((Component)((Component)CommonReferences.MNFMOEKMJKN().tavernFloorDirt[i]).transform.GetChild(0)).gameObject.SetActive(DMBFKFLDDLH);
		}
	}

	private void OAKPOEMIEBB()
	{
		SmallContainerUI smallContainerUI = SmallContainerUI.IEKODILKIHJ(1);
		smallContainerUI.OnUIClose = (Action<int>)Delegate.Remove(smallContainerUI.OnUIClose, new Action<int>(ADPMCNABPCG));
		SmallContainerUI smallContainerUI2 = SmallContainerUI.Get(1);
		smallContainerUI2.OnUIClose = (Action<int>)Delegate.Combine(smallContainerUI2.OnUIClose, new Action<int>(ADPMCNABPCG));
		SmallContainerUI smallContainerUI3 = SmallContainerUI.CGFJPHEFFLO(2);
		smallContainerUI3.OnUIClose = (Action<int>)Delegate.Combine(smallContainerUI3.OnUIClose, new Action<int>(ADPMCNABPCG));
		PlayerInventory playerInventory = PlayerInventory.OGKNJNINGMH(0);
		playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(PKEKGMBFDMK));
		PlayerInventory playerInventory2 = PlayerInventory.OGKNJNINGMH(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
		playerInventory2.OnChanged = (Action)Delegate.Combine(playerInventory2.OnChanged, new Action(DIBBLIIBNLM));
		PlayerInventory playerInventory3 = PlayerInventory.EIFPKCAFDIB(5, LAGHIOKLJGH: true, ADPNMHGBFKG: true);
		playerInventory3.OnChanged = (Action)Delegate.Combine(playerInventory3.OnChanged, new Action(DDIBDNHDNJM));
	}

	private IEnumerator DBCADKNONKE()
	{
		return new NIEHNJNCFEG(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator PBEKBJIJFDK()
	{
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(MPAJIIEACDK));
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		Weather.ShowWeather(Weather.WeatherType.None);
		ResetMai();
		while (EEANDMLHLBD < 4 && CommonReferences.GGFJGHHHEJC.tavernFloorDirt.Count < 4)
		{
			yield return null;
		}
		BKBJCKGKALC(DMBFKFLDDLH: false);
		yield return ((MonoBehaviour)this).StartCoroutine(CCIOMPBMJMD());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T102/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		containerCanBeOpened = true;
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)SceneReferences.instance.initialChest).transform.position), Vector2.up * 0.2f, ref JELIKOFDONK);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)SceneReferences.instance.table).transform.position), Vector2.down * 0.5f, ref LJEJMMAEKJF);
		SmallContainerUI smallContainerUI = SmallContainerUI.Get(1);
		smallContainerUI.OnUIClose = (Action<int>)Delegate.Combine(smallContainerUI.OnUIClose, new Action<int>(ADPMCNABPCG));
		if (GameManager.LocalCoop())
		{
			SmallContainerUI smallContainerUI2 = SmallContainerUI.Get(2);
			smallContainerUI2.OnUIClose = (Action<int>)Delegate.Combine(smallContainerUI2.OnUIClose, new Action<int>(ADPMCNABPCG));
		}
		PlayerInventory player = PlayerInventory.GetPlayer(1);
		player.OnChanged = (Action)Delegate.Combine(player.OnChanged, new Action(PKEKGMBFDMK));
		if (GameManager.LocalCoop())
		{
			PlayerInventory player2 = PlayerInventory.GetPlayer(2);
			player2.OnChanged = (Action)Delegate.Combine(player2.OnChanged, new Action(PKEKGMBFDMK));
		}
		GameManager.OnPlayer2Joined = (Action)Delegate.Combine(GameManager.OnPlayer2Joined, new Action(EDHEGFKDJDB));
		GameManager.OnPlayer2Disconnected = (Action)Delegate.Combine(GameManager.OnPlayer2Disconnected, new Action(AGMLGNDDINL));
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnAnyTableDirtLevelChanged = (Action<TableDirtLevel>)Delegate.Combine(instance.OnAnyTableDirtLevelChanged, new Action<TableDirtLevel>(OIGMPILJDHM));
		CommonReferences instance2 = CommonReferences.GGFJGHHHEJC;
		instance2.OnFloorDirtDestroyed = (Action)Delegate.Combine(instance2.OnFloorDirtDestroyed, new Action(KIIIBPECPBB));
		yield return CommonReferences.wait1;
		((MonoBehaviour)this).StartCoroutine(GHAECDFHKJN());
		while (!COCGNJFCLMC)
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void FOPJOFHNHMG()
	{
		SmallContainerUI smallContainerUI = SmallContainerUI.IGHMHMNPMLB(0);
		smallContainerUI.OnUIClose = (Action<int>)Delegate.Remove(smallContainerUI.OnUIClose, new Action<int>(BJGAEHGGDFE));
		SmallContainerUI smallContainerUI2 = SmallContainerUI.CJMILOMGFJL(0);
		smallContainerUI2.OnUIClose = (Action<int>)Delegate.Combine(smallContainerUI2.OnUIClose, new Action<int>(POELOEKEIBF));
		SmallContainerUI smallContainerUI3 = SmallContainerUI.IEABDMDELFO(0);
		smallContainerUI3.OnUIClose = (Action<int>)Delegate.Combine(smallContainerUI3.OnUIClose, new Action<int>(DPPGMJLMPLM));
		PlayerInventory playerInventory = PlayerInventory.OGKNJNINGMH(0);
		playerInventory.OnChanged = (Action)Delegate.Remove(playerInventory.OnChanged, new Action(DDIBDNHDNJM));
		PlayerInventory player = PlayerInventory.GetPlayer(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true);
		player.OnChanged = (Action)Delegate.Combine(player.OnChanged, new Action(LNMGBBALKFN));
		PlayerInventory player2 = PlayerInventory.GetPlayer(4);
		player2.OnChanged = (Action)Delegate.Combine(player2.OnChanged, new Action(DDIBDNHDNJM));
	}

	private void GOHOMIFHPNK(bool DMBFKFLDDLH)
	{
		for (int i = 0; i < CommonReferences.GGFJGHHHEJC.tavernFloorDirt.Count; i++)
		{
			((Component)((Component)CommonReferences.GGFJGHHHEJC.tavernFloorDirt[i]).transform.GetChild(0)).gameObject.SetActive(DMBFKFLDDLH);
		}
	}

	private void KFNLDNNNDNF(bool DMBFKFLDDLH)
	{
		for (int i = 0; i < CommonReferences.MNFMOEKMJKN().tavernFloorDirt.Count; i += 0)
		{
			((Component)((Component)CommonReferences.MNFMOEKMJKN().tavernFloorDirt[i]).transform.GetChild(0)).gameObject.SetActive(DMBFKFLDDLH);
		}
	}

	private void POELOEKEIBF(int JIIGOACEIKL)
	{
		if (PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL, LAGHIOKLJGH: true).CCEPCEJIEOP(ItemDatabaseAccessor.KMBGJEKCJFJ(117, GGBBJNBBLMF: false, DAINLFIMLIH: false)))
		{
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			if ((Object)(object)JELIKOFDONK != (Object)null)
			{
				Object.Destroy((Object)(object)JELIKOFDONK);
			}
			GOJMNOHMAPK();
			FEADDMKMOAN();
			OGPPFFAKDMD(DMBFKFLDDLH: false);
			if (GameManager.LocalCoop())
			{
				int jFNMCNCHMEO = ((JIIGOACEIKL != 0) ? 1 : 0);
				PlayerInventory.EIFPKCAFDIB(jFNMCNCHMEO).OJDGOADOCMG(ItemDatabaseAccessor.AFOACBIHNCL(-36).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: false);
				PlayerInventory.EIFPKCAFDIB(jFNMCNCHMEO, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AddItem(ItemDatabaseAccessor.INJBNHPGCIJ(-31, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false, EHGHJNOFMKF: false);
			}
			NewTutorialManager.instance.mopUnlocked = true;
		}
	}

	private void EGEMJJHBNKL()
	{
		if (PlayerInventory.NEKDDPIAOBE(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).NECEDHECGFN(ItemDatabaseAccessor.AFOACBIHNCL(180)) || (GameManager.LocalCoop() && PlayerInventory.GetPlayer(0).DCEOCOOIBLI(ItemDatabaseAccessor.GOKIDLOELKB(43))))
		{
			NewTutorialManager.instance.ObjectiveCompleted(0);
			GJLCIKCMGCK();
			BKBJCKGKALC(DMBFKFLDDLH: false);
		}
	}

	private void GDGMOHIBGEH(TableDirtLevel ALEAPGOEANL)
	{
		if (ALEAPGOEANL == TableDirtLevel.Perfect)
		{
			NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
			if ((Object)(object)LJEJMMAEKJF != (Object)null)
			{
				Object.Destroy((Object)(object)LJEJMMAEKJF);
			}
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnAnyTableDirtLevelChanged = (Action<TableDirtLevel>)Delegate.Remove(instance.OnAnyTableDirtLevelChanged, new Action<TableDirtLevel>(FDIMPHMKDMG));
			DHCCMBIGMJM();
		}
	}

	private void BKBJCKGKALC(bool DMBFKFLDDLH)
	{
		for (int i = 0; i < CommonReferences.GGFJGHHHEJC.tavernFloorDirt.Count; i++)
		{
			((Component)((Component)CommonReferences.GGFJGHHHEJC.tavernFloorDirt[i]).transform.GetChild(0)).gameObject.SetActive(DMBFKFLDDLH);
		}
	}
}
