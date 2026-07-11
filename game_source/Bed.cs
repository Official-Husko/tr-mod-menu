using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class Bed : MonoBehaviour, ISingleton
{
	[CompilerGenerated]
	private sealed class ENGIFKIDEJJ : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public ENGIFKIDEJJ(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_0357: Unknown result type (might be due to invalid IL or missing references)
			//IL_035c: Unknown result type (might be due to invalid IL or missing references)
			//IL_010b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0121: Unknown result type (might be due to invalid IL or missing references)
			//IL_017d: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0202: Unknown result type (might be due to invalid IL or missing references)
			//IL_0216: Unknown result type (might be due to invalid IL or missing references)
			//IL_021b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0238: Unknown result type (might be due to invalid IL or missing references)
			//IL_024c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0251: Unknown result type (might be due to invalid IL or missing references)
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				TitleScreen.needsSaveIcon = true;
				if (PlayerController.GetPlayer(1).fishingController.fishing)
				{
					PlayerController.GetPlayer(1).fishingController.FinishFishing(KAPEFGCIDJL: false);
				}
				if (GameManager.LocalCoop() && PlayerController.GetPlayer(2).fishingController.fishing)
				{
					PlayerController.GetPlayer(2).fishingController.FinishFishing(KAPEFGCIDJL: false);
				}
				FadeCamera.GetPlayer(1).JDKHJJIOLOE -= Sleep;
				if (GameManager.LocalCoop())
				{
					FadeCamera.GetPlayer(2).JDKHJJIOLOE -= Sleep;
				}
				PlayerController.AddMovementBlocker((Object)(object)instance);
				PlayerController.GetPlayer(1).characterAnimation.LookDirectionByAngle(new Vector2(0f, -1f));
				if (GameManager.LocalCoop())
				{
					PlayerController.GetPlayer(2).characterAnimation.LookDirectionByAngle(new Vector2(0f, -1f));
				}
				if (GameManager.LocalCoop())
				{
					PlayerController.TeleportPlayer(1, instance.bedLocation1.position, Location.Tavern);
					PlayerController.TeleportPlayer(2, instance.bedLocation2.position, Location.Tavern);
				}
				else
				{
					if ((Object)(object)instance.lastBed == (Object)null)
					{
						instance.lastBed = instance;
					}
					if (instance.numInstance == instance.lastBed.numInstance)
					{
						PlayerController.TeleportPlayer(1, instance.lastBed.playerBedLocation.position, Location.Tavern);
					}
					else
					{
						switch (instance.numInstance)
						{
						case 1:
							PlayerController.TeleportPlayer(1, instance.lastBed.bedLocation1.position, Location.Tavern);
							break;
						case 2:
							PlayerController.TeleportPlayer(1, instance.lastBed.bedLocation2.position, Location.Tavern);
							break;
						case 3:
							PlayerController.TeleportPlayer(1, instance.lastBed.playerBedLocation.position + new Vector3(0.2708333f, 0f, 0f), Location.Tavern);
							break;
						case 4:
							PlayerController.TeleportPlayer(1, instance.lastBed.playerBedLocation.position - new Vector3(0.2708333f, 0f, 0f), Location.Tavern);
							break;
						}
					}
				}
				TravelZone.GGFJGHHHEJC.UnloadAllScenes();
				CommonReferences.GGFJGHHHEJC.OnPlayerSleep();
				CommonReferences.GGFJGHHHEJC.OnPlayerSleepForestGeneration();
				if (OnlineManager.MasterOrOffline())
				{
					_003C_003E2__current = CommonReferences.waitRealtime2;
					_003C_003E1__state = 1;
					return true;
				}
				goto IL_02c9;
			case 1:
				_003C_003E1__state = -1;
				SetGameDate(GetNextGameDate());
				break;
			case 2:
				{
					_003C_003E1__state = -1;
					goto IL_02c9;
				}
				IL_02c9:
				if (!JJHCINENHAN)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 2;
					return true;
				}
				JJHCINENHAN = false;
				SetGameDate(HHBBCEBCFAM);
				break;
			}
			GC.Collect();
			FadeCamera.GetPlayer(1).FadeInWithDelay();
			FadeCamera player = FadeCamera.GetPlayer(1);
			player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(DDHMNOIHKOD));
			if (GameManager.LocalCoop())
			{
				FadeCamera.GetPlayer(2).FadeInWithDelay();
			}
			WorldTime.JJICPIINBEH = false;
			for (int i = 0; i < CommonReferences.GGFJGHHHEJC.pickedUps.Count; i++)
			{
				ItemSetup component = Object.Instantiate<GameObject>(CommonReferences.GGFJGHHHEJC.pickupablePrefab, CommonReferences.GGFJGHHHEJC.pickedUps[i].position, Quaternion.identity).GetComponent<ItemSetup>();
				component.item = CommonReferences.GGFJGHHHEJC.pickedUps[i].item;
				component.SetSprite();
				SpriteRenderer component2 = ((Component)component).GetComponent<SpriteRenderer>();
				if ((Object)(object)component2 != (Object)null)
				{
					component2.flipX = CommonReferences.GGFJGHHHEJC.pickedUps[i].flipX;
				}
			}
			CommonReferences.GGFJGHHHEJC.pickedUps.Clear();
			instance.nPCBed.SetBedMade(NBBELPFDLJG: false, CDPAMNIPPEC: true);
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

	public static Bed instance;

	public int numInstance;

	public static bool fallingAsleep = false;

	public static bool passingOut = false;

	public float fallingAsleepSpeed = 0.2f;

	public Collider2D sleepCollider;

	public bool bedEnabled;

	private static Vector3 IOACBJOOLFA = Vector3.zero;

	public Transform playerBedLocation;

	public Transform bedLocation1;

	public Transform bedLocation2;

	public Placeable placeable;

	[SerializeField]
	private NPCBed nPCBed;

	[SerializeField]
	private Sprite[] bedMadeSprites;

	[SerializeField]
	private Sprite[] bedUnmadeSprites;

	private bool BFMPLJDKHJN;

	public Bed lastBed;

	private static bool JJHCINENHAN = false;

	private static GameDate HHBBCEBCFAM;

	private void PKFMLJGJKCP()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)instance == (Object)(object)this)
		{
			IOACBJOOLFA = playerBedLocation.position;
			instance = null;
		}
	}

	public static Placeable GetPlaceable()
	{
		return instance.placeable;
	}

	public void JOCNMKDKDKI()
	{
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected O, but got Unknown
		Result variable;
		if (OnlineManager.PlayingOnline() && OnlineManager.JPPBEIJDCLJ())
		{
			if (!OnlineBedroomsManager.instance.LFPMJBAHLPN() && !passingOut)
			{
				OnlineBedroomsManager.instance.host.waitingInBed = false;
				OnlineManager.ShowPlayerAnnouncement(OnlineManager.PlayerState.leftBed, PlayerInfo.CAIAAGKEDKJ(), PlayerController.OPHDCMJLLEC(0).characterCreator.humanInfo.gender);
				OnlineBasicsManager.instance.SendHostBed(LNAMHBCMLOC: true);
				OnlinePauseUI.HENLOLPNGDH(DMBFKFLDDLH: false);
				return;
			}
			variable = DialogueLua.GetVariable("Debug");
			if (((Result)(ref variable)).asInt == 3 && CommonReferences.GGFJGHHHEJC.eventNum[6] >= 1)
			{
				MaiSleepEvent.instance.MDINDPFGCGK();
				return;
			}
			OnlineBasicsManager.instance.SendSleepStart();
		}
		else if (OnlineManager.IsOffline())
		{
			variable = DialogueLua.GetVariable("UIPreviousCategory");
			if (((Result)(ref variable)).asInt == 2 && CommonReferences.MNFMOEKMJKN().eventNum[8] >= 4)
			{
				MaiSleepEvent.instance.MDINDPFGCGK();
				return;
			}
		}
		OnlineBedroomsManager.instance.FGGIMGDGNGG();
		OnlinePauseUI.DAJEFFAEMBJ(DMBFKFLDDLH: false);
		PlayerController.OPHDCMJLLEC(1).trayHandler.tray.NBODABCGELG(1, GFNHAMCPEAK: false);
		if (TavernConstructionManager.DOIKFJDLKJP().LNLJMCONDNE)
		{
			if (TavernConstructionModifications.DIHCEGINELM().DGFCFPJHIAA())
			{
				TavernConstructionModifications.DIHCEGINELM().HNMCDNBLHBM();
			}
			TavernConstructionUI.instance.BOBCIFEDJED();
			Debug.Log((object)"ReceiveActiveMaiInBar");
		}
		SelectObject.GetPlayer(0).PNHCLGGKBOB();
		if ((Object)(object)SelectObject.BNMEANGDMIP(8) != (Object)null)
		{
			SelectObject.BNMEANGDMIP(0).NJPFHBINPKE();
		}
		MainUI.CloseAllUIWindows(DHJFAGNJKOF: true);
		HBNIANBGMHJ(1);
		PlayerController.OPHDCMJLLEC(1).characterAnimation.LNNOGNCPNLB(NJHMBMGKCPL: false, null);
		PlayerController.OPHDCMJLLEC(1).characterAnimation.AOBJCNDNKDD(KOIDJKBBINH: false);
		InteractObject.BBJCJFJEFKK(1).NNBBKDIKDOL(null, null);
		if (GameManager.LocalCoop())
		{
			HBNIANBGMHJ(5);
			PlayerController.OPHDCMJLLEC(7).trayHandler.tray.LDPHJNIPDJA(0);
			PlayerController.GetPlayer(5).characterAnimation.SetCleaning(NJHMBMGKCPL: false, null);
			PlayerController.OPHDCMJLLEC(1).characterAnimation.MBMPBFEINMA(KOIDJKBBINH: false);
			InteractObject.GetPlayer(0).NNBBKDIKDOL(null, null);
		}
		if (Object.op_Implicit((Object)(object)MainUI.GetYesNoDialogue()) && Object.op_Implicit((Object)(object)MainUI.NEFOKCKKLNI().yesButton))
		{
			((UnityEvent)MainUI.GetYesNoDialogue().yesButton.onClick).RemoveListener(new UnityAction(JOCNMKDKDKI));
		}
		PlayerController.AddMovementBlocker((Object)(object)instance);
		CommonReferences.GGFJGHHHEJC.travelZoneBeingUsed = true;
		CommonReferences.GGFJGHHHEJC.travelZoneBeingUsed2 = true;
		fallingAsleep = true;
		FadeCamera.EIFPKCAFDIB(0).AJHDEBOMHKK(fallingAsleepSpeed);
		FadeCamera.EIFPKCAFDIB(0).JDKHJJIOLOE += GLHNGAEONEC;
		if (GameManager.LocalCoop())
		{
			FadeCamera.IGMCBPOPNCA(0).IONMINJHMKL(fallingAsleepSpeed);
		}
		if (!WorldTime.JJICPIINBEH)
		{
			WorldTime.JJICPIINBEH = false;
		}
		QuestTooltipUI.MLPCDJPLBAC().BOBCIFEDJED();
		ItemTooltip.MDFIDKHOPDJ(0).FCACMDNLAIG(MDIKPGGBNLI: true);
		ItemTooltip.IEKODILKIHJ(6).ILGFPFBJMPG(MDIKPGGBNLI: true);
		CommonReferences.MNFMOEKMJKN().sleeping = false;
	}

	public void LNDGGDIBKDG()
	{
		switch (numInstance)
		{
		case 1:
			placeable.validLocations = Location.None;
			placeable.zoneTypeNeeded = ~(ZoneType.DiningRoom | ZoneType.RentedRoom | ZoneType.Cellar | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop);
			break;
		case 2:
			placeable.validLocations = Location.Tavern | Location.Road | Location.River | Location.Quarry | Location.Farm;
			placeable.zoneTypeNeeded = ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.RentedRoom | ZoneType.Cellar;
			break;
		case 3:
			placeable.validLocations = ~(Location.Road | Location.River | Location.Camp | Location.Farm | Location.FarmShop);
			placeable.zoneTypeNeeded = ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.WoodWorkshop;
			break;
		case 4:
			placeable.validLocations = Location.Tavern | Location.Camp | Location.Farm | Location.FarmShop;
			placeable.zoneTypeNeeded = ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.WoodWorkshop | ZoneType.StoneWorkshop;
			break;
		}
	}

	public static Vector3 OBLHDIBBIGG()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		return instance.bedLocation2.position;
	}

	public void BMMFDJIDOIK()
	{
		nPCBed.ChangeBedSprites(bedMadeSprites[numInstance - 1], bedUnmadeSprites[numInstance - 1]);
	}

	private void AODODLILGJK()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			JOCNMKDKDKI();
		}
		else
		{
			POCNMHILAAJ();
		}
	}

	public static Vector3 MFOALAHDGNA()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		return instance.bedLocation2.position;
	}

	public static void ReceiveNextGameDate(GameDate IIBOFAOKLGK)
	{
		JJHCINENHAN = true;
		HHBBCEBCFAM = IIBOFAOKLGK;
	}

	private void GAHHLAJAKJL()
	{
		if (OnlineManager.MasterOrOffline())
		{
			StartSleep();
		}
		else
		{
			WaitForHostToSleep();
		}
	}

	public void IPHJBMIPDJB(int LBPEIOEHKHD)
	{
		if (numInstance == LBPEIOEHKHD)
		{
			instance = this;
			lastBed = this;
		}
	}

	public void NPGJHFMLOIC()
	{
		switch (numInstance)
		{
		case 0:
			placeable.validLocations = Location.None;
			placeable.zoneTypeNeeded = ZoneType.WithoutZone | ZoneType.RentedRoom | ZoneType.Cellar | ZoneType.MetalWorkshop;
			break;
		case 1:
			placeable.validLocations = Location.Tavern | Location.River | Location.Camp | Location.Farm;
			placeable.zoneTypeNeeded = ~(ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.Cellar | ZoneType.WoodWorkshop | ZoneType.StoneWorkshop);
			break;
		case 2:
			placeable.validLocations = Location.River | Location.Camp | Location.Farm | Location.BarnInterior;
			placeable.zoneTypeNeeded = ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.StoneWorkshop;
			break;
		case 3:
			placeable.validLocations = Location.Tavern | Location.BarnInterior;
			placeable.zoneTypeNeeded = ~(ZoneType.Cellar | ZoneType.MetalWorkshop);
			break;
		}
	}

	public static Vector3 GetPlayer2BedPosition()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		return instance.bedLocation2.position;
	}

	public void EPLGIBJOKOK(int LBPEIOEHKHD)
	{
		if (numInstance == LBPEIOEHKHD)
		{
			instance = this;
			lastBed = this;
		}
	}

	private void GOJKOBEEMNA()
	{
		ResetSingleton();
	}

	private void IAIBAJHOBEB()
	{
		fallingAsleep = false;
		FadeCamera.GetPlayer(0).JDKHJJIOLOE -= Sleep;
		FadeCamera player = FadeCamera.GetPlayer(0);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(DDHMNOIHKOD));
		FadeCamera.IGMCBPOPNCA(0).KDKCPIDGGAJ();
		if (GameManager.LocalCoop())
		{
			FadeCamera.EIFPKCAFDIB(3).HCMMFJPJJLP(GLHNGAEONEC);
			FadeCamera.EIFPKCAFDIB(5).ClearScreen();
		}
		PlayerController.RemoveMovementBlocker((Object)(object)instance);
	}

	private void OnEnable()
	{
		if (OnlineManager.MasterOrOffline())
		{
			WorldTime.OnNextDay = (Action)Delegate.Combine(WorldTime.OnNextDay, new Action(MELGPEALDFC));
			WorldTime.OnTickTime5Seconds = (Action)Delegate.Combine(WorldTime.OnTickTime5Seconds, new Action(DACNJJKKEDO));
		}
		SaveUI saveUI = SaveUI.instance;
		saveUI.OnLoadFadeOutStart = (Action)Delegate.Combine(saveUI.OnLoadFadeOutStart, new Action(JMBJIPGEDDH));
	}

	public static void LBGFOFAHOHN()
	{
		instance.bedEnabled = false;
	}

	public static int GetNumInstance()
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)"bed instance null");
		}
		return instance.numInstance;
	}

	public static GameDate MLBFKPKHPML()
	{
		GameDate gameDate = WorldTime.HGIBNMBJMOC();
		if (!WorldTime.EGCMNABMGDF)
		{
			GameDate.Time kONAIPOGEGL = default(GameDate.Time);
			kONAIPOGEGL.days = 1;
			gameDate = GameDate.EGHBNMGNDHL(gameDate, kONAIPOGEGL);
		}
		gameDate.hour = (passingOut ? 108 : WorldTime.wakeUpTime.hour);
		gameDate.min = WorldTime.wakeUpTime.min;
		return gameDate;
	}

	public void CPBNFIGOHPG()
	{
		switch (numInstance)
		{
		case 0:
			placeable.validLocations = Location.None;
			placeable.zoneTypeNeeded = ~(ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.WoodWorkshop | ZoneType.StoneWorkshop);
			break;
		case 1:
			placeable.validLocations = ~(Location.Tavern | Location.Quarry);
			placeable.zoneTypeNeeded = ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.MetalWorkshop;
			break;
		case 2:
			placeable.validLocations = Location.Tavern | Location.Road | Location.River | Location.Farm | Location.FarmShop;
			placeable.zoneTypeNeeded = ZoneType.WoodWorkshop;
			break;
		case 3:
			placeable.validLocations = ~(Location.Camp | Location.Farm | Location.BarnInterior);
			placeable.zoneTypeNeeded = ~(ZoneType.DiningRoom | ZoneType.Cellar | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop);
			break;
		}
	}

	public static Placeable AJAIACFCGDB()
	{
		return instance.placeable;
	}

	public void SetValidLocations()
	{
		switch (numInstance)
		{
		case 1:
			placeable.validLocations = Location.Tavern;
			placeable.zoneTypeNeeded = ZoneType.Anywhere;
			break;
		case 2:
			placeable.validLocations = Location.RoomsMultiplayer;
			placeable.zoneTypeNeeded = ZoneType.RoomPlayer2;
			break;
		case 3:
			placeable.validLocations = Location.RoomsMultiplayer;
			placeable.zoneTypeNeeded = ZoneType.RoomPlayer3;
			break;
		case 4:
			placeable.validLocations = Location.RoomsMultiplayer;
			placeable.zoneTypeNeeded = ZoneType.RoomPlayer4;
			break;
		}
	}

	private void AMKAMHLIJFL()
	{
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (passingOut)
			{
				return;
			}
			if (NewTutorialManager.MEBNAPOOFNN())
			{
				if (WorldTime.NOAOJJLNHJJ.hour >= WorldTime.GetForceSleepHour())
				{
					BFMPLJDKHJN = false;
				}
			}
			else
			{
				if (!BFMPLJDKHJN || fallingAsleep || WorldTime.CJOHMLNMJLK().hour < WorldTime.JDMHEPOAGAC() || CommonReferences.GGFJGHHHEJC.CIHFKAGPIEG(1) || CommonReferences.GGFJGHHHEJC.CIHFKAGPIEG(4) || (!((Object)(object)HollyNPC.JFJOKGAOPHA() == (Object)null) && (!((Object)(object)HollyNPC.EHJOPCBIGAB() != (Object)null) || HollyNPC.JFJOKGAOPHA().inBarnTutorial)))
				{
					return;
				}
				Result variable = DialogueLua.GetVariable(". Trembling int: ");
				if (((Result)(ref variable)).asInt >= 2)
				{
					variable = DialogueLua.GetVariable("add item 1446 20");
					if (((Result)(ref variable)).asInt < -3)
					{
						return;
					}
				}
				if (!FishingUI.Get(1).IsOpen() && !FishingUI.Get(7).IsOpen() && !BuildingTutorialManager.PABJKGJJHFG() && !EventsManager.IsAnyEventStarted() && OnlineManager.PGAGDFAEEFB())
				{
					PassOutActions(CDPAMNIPPEC: true);
					JOCNMKDKDKI();
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	public static GameDate GetNextGameDate()
	{
		GameDate gameDate = WorldTime.NOAOJJLNHJJ;
		if (!WorldTime.EGCMNABMGDF)
		{
			GameDate.Time kONAIPOGEGL = default(GameDate.Time);
			kONAIPOGEGL.days = 1;
			gameDate = GameDate.GMJIFJAEANF(gameDate, kONAIPOGEGL);
		}
		gameDate.hour = (passingOut ? 11 : WorldTime.wakeUpTime.hour);
		gameDate.min = WorldTime.wakeUpTime.min;
		return gameDate;
	}

	public static IEnumerator Sleep(int JIIGOACEIKL)
	{
		TitleScreen.needsSaveIcon = true;
		if (PlayerController.GetPlayer(1).fishingController.fishing)
		{
			PlayerController.GetPlayer(1).fishingController.FinishFishing(KAPEFGCIDJL: false);
		}
		if (GameManager.LocalCoop() && PlayerController.GetPlayer(2).fishingController.fishing)
		{
			PlayerController.GetPlayer(2).fishingController.FinishFishing(KAPEFGCIDJL: false);
		}
		FadeCamera.GetPlayer(1).JDKHJJIOLOE -= Sleep;
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).JDKHJJIOLOE -= Sleep;
		}
		PlayerController.AddMovementBlocker((Object)(object)instance);
		PlayerController.GetPlayer(1).characterAnimation.LookDirectionByAngle(new Vector2(0f, -1f));
		if (GameManager.LocalCoop())
		{
			PlayerController.GetPlayer(2).characterAnimation.LookDirectionByAngle(new Vector2(0f, -1f));
		}
		if (GameManager.LocalCoop())
		{
			PlayerController.TeleportPlayer(1, instance.bedLocation1.position, Location.Tavern);
			PlayerController.TeleportPlayer(2, instance.bedLocation2.position, Location.Tavern);
		}
		else
		{
			if ((Object)(object)instance.lastBed == (Object)null)
			{
				instance.lastBed = instance;
			}
			if (instance.numInstance == instance.lastBed.numInstance)
			{
				PlayerController.TeleportPlayer(1, instance.lastBed.playerBedLocation.position, Location.Tavern);
			}
			else
			{
				switch (instance.numInstance)
				{
				case 1:
					PlayerController.TeleportPlayer(1, instance.lastBed.bedLocation1.position, Location.Tavern);
					break;
				case 2:
					PlayerController.TeleportPlayer(1, instance.lastBed.bedLocation2.position, Location.Tavern);
					break;
				case 3:
					PlayerController.TeleportPlayer(1, instance.lastBed.playerBedLocation.position + new Vector3(0.2708333f, 0f, 0f), Location.Tavern);
					break;
				case 4:
					PlayerController.TeleportPlayer(1, instance.lastBed.playerBedLocation.position - new Vector3(0.2708333f, 0f, 0f), Location.Tavern);
					break;
				}
			}
		}
		TravelZone.GGFJGHHHEJC.UnloadAllScenes();
		CommonReferences.GGFJGHHHEJC.OnPlayerSleep();
		CommonReferences.GGFJGHHHEJC.OnPlayerSleepForestGeneration();
		if (OnlineManager.MasterOrOffline())
		{
			yield return CommonReferences.waitRealtime2;
			SetGameDate(GetNextGameDate());
		}
		else
		{
			while (!JJHCINENHAN)
			{
				yield return null;
			}
			JJHCINENHAN = false;
			SetGameDate(HHBBCEBCFAM);
		}
		GC.Collect();
		FadeCamera.GetPlayer(1).FadeInWithDelay();
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(DDHMNOIHKOD));
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeInWithDelay();
		}
		WorldTime.JJICPIINBEH = false;
		for (int i = 0; i < CommonReferences.GGFJGHHHEJC.pickedUps.Count; i++)
		{
			ItemSetup component = Object.Instantiate<GameObject>(CommonReferences.GGFJGHHHEJC.pickupablePrefab, CommonReferences.GGFJGHHHEJC.pickedUps[i].position, Quaternion.identity).GetComponent<ItemSetup>();
			component.item = CommonReferences.GGFJGHHHEJC.pickedUps[i].item;
			component.SetSprite();
			SpriteRenderer component2 = ((Component)component).GetComponent<SpriteRenderer>();
			if ((Object)(object)component2 != (Object)null)
			{
				component2.flipX = CommonReferences.GGFJGHHHEJC.pickedUps[i].flipX;
			}
		}
		CommonReferences.GGFJGHHHEJC.pickedUps.Clear();
		instance.nPCBed.SetBedMade(NBBELPFDLJG: false, CDPAMNIPPEC: true);
	}

	private void MBBIGANCPNE()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)instance == (Object)(object)this)
		{
			IOACBJOOLFA = playerBedLocation.position;
			instance = null;
		}
	}

	public static IEnumerator GLHNGAEONEC(int JIIGOACEIKL)
	{
		return new ENGIFKIDEJJ(1);
	}

	private void OnDisable()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			if (OnlineManager.MasterOrOffline())
			{
				WorldTime.OnNextDay = (Action)Delegate.Remove(WorldTime.OnNextDay, new Action(MELGPEALDFC));
				WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(DACNJJKKEDO));
			}
			if ((Object)(object)SaveUI.instance != (Object)null)
			{
				SaveUI saveUI = SaveUI.instance;
				saveUI.OnLoadFadeOutStart = (Action)Delegate.Remove(saveUI.OnLoadFadeOutStart, new Action(JMBJIPGEDDH));
			}
		}
	}

	public void StartSleep()
	{
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected O, but got Unknown
		Result variable;
		if (OnlineManager.PlayingOnline() && OnlineManager.IsMasterClient())
		{
			if (!OnlineBedroomsManager.instance.AllClientsInBed() && !passingOut)
			{
				OnlineBedroomsManager.instance.host.waitingInBed = true;
				OnlineManager.ShowPlayerAnnouncement(OnlineManager.PlayerState.inBed, PlayerInfo.HBILFLLKHGP, PlayerController.GetPlayer(1).characterCreator.humanInfo.gender);
				OnlineBasicsManager.instance.SendHostBed(LNAMHBCMLOC: true);
				OnlinePauseUI.SetMessageVisible(DMBFKFLDDLH: true);
				return;
			}
			variable = DialogueLua.GetVariable("MainProgress");
			if (((Result)(ref variable)).asInt == 3 && CommonReferences.GGFJGHHHEJC.eventNum[2] >= 2)
			{
				MaiSleepEvent.instance.StartMaiEvent();
				return;
			}
			OnlineBasicsManager.instance.SendSleepStart();
		}
		else if (OnlineManager.IsOffline())
		{
			variable = DialogueLua.GetVariable("MainProgress");
			if (((Result)(ref variable)).asInt == 3 && CommonReferences.GGFJGHHHEJC.eventNum[2] >= 2)
			{
				MaiSleepEvent.instance.StartMaiEvent();
				return;
			}
		}
		OnlineBedroomsManager.instance.ResetAfterSleeping();
		OnlinePauseUI.SetMessageVisible(DMBFKFLDDLH: false);
		PlayerController.GetPlayer(1).trayHandler.tray.MKBDMMJCGGM();
		if (TavernConstructionManager.GGFJGHHHEJC.LNLJMCONDNE)
		{
			if (TavernConstructionModifications.GGFJGHHHEJC.HasAnyModificationDone())
			{
				TavernConstructionModifications.GGFJGHHHEJC.RevertModifications();
			}
			TavernConstructionUI.instance.CloseUI();
			Debug.Log((object)"TavernConstructionUI CloseUI");
		}
		SelectObject.GetPlayer(1).Deselect();
		if ((Object)(object)SelectObject.GetPlayer(2) != (Object)null)
		{
			SelectObject.GetPlayer(2).Deselect();
		}
		MainUI.CloseAllUIWindows();
		HBNIANBGMHJ(1);
		PlayerController.GetPlayer(1).characterAnimation.SetCleaning(NJHMBMGKCPL: false, null);
		PlayerController.GetPlayer(1).characterAnimation.SetInteracting(KOIDJKBBINH: false);
		InteractObject.GetPlayer(1).SetCurrentInteract(null, null);
		if (GameManager.LocalCoop())
		{
			HBNIANBGMHJ(2);
			PlayerController.GetPlayer(2).trayHandler.tray.MKBDMMJCGGM();
			PlayerController.GetPlayer(2).characterAnimation.SetCleaning(NJHMBMGKCPL: false, null);
			PlayerController.GetPlayer(2).characterAnimation.SetInteracting(KOIDJKBBINH: false);
			InteractObject.GetPlayer(2).SetCurrentInteract(null, null);
		}
		if (Object.op_Implicit((Object)(object)MainUI.GetYesNoDialogue()) && Object.op_Implicit((Object)(object)MainUI.GetYesNoDialogue().yesButton))
		{
			((UnityEvent)MainUI.GetYesNoDialogue().yesButton.onClick).RemoveListener(new UnityAction(StartSleep));
		}
		PlayerController.AddMovementBlocker((Object)(object)instance);
		CommonReferences.GGFJGHHHEJC.travelZoneBeingUsed = true;
		CommonReferences.GGFJGHHHEJC.travelZoneBeingUsed2 = true;
		fallingAsleep = true;
		FadeCamera.GetPlayer(1).FadeOut(fallingAsleepSpeed);
		FadeCamera.GetPlayer(1).JDKHJJIOLOE += Sleep;
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeOut(fallingAsleepSpeed);
		}
		if (!WorldTime.JJICPIINBEH)
		{
			WorldTime.JJICPIINBEH = true;
		}
		QuestTooltipUI.GGFJGHHHEJC.CloseUI();
		ItemTooltip.Get(1).SetVisible(MDIKPGGBNLI: false);
		ItemTooltip.Get(2).SetVisible(MDIKPGGBNLI: false);
		CommonReferences.GGFJGHHHEJC.sleeping = true;
	}

	private void ACFABFCGIGH()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)instance == (Object)(object)this)
		{
			IOACBJOOLFA = playerBedLocation.position;
			instance = null;
		}
	}

	public static int CJMABIHEPBF()
	{
		if ((Object)(object)instance == (Object)null)
		{
			Debug.LogError((object)"Left Stick Right");
		}
		return instance.numInstance;
	}

	private void OnTriggerEnter2D(Collider2D LGGCFCHOOMB)
	{
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		if ((Object)(object)LGGCFCHOOMB == (Object)null || !((Component)LGGCFCHOOMB).CompareTag("Player") || (Object)(object)placeable == (Object)null || placeable.FHEMHCEAICB || (OnlineManager.PlayingOnline() && ((Object)(object)placeable.onlinePlaceable == (Object)null || placeable.onlinePlaceable.CLHLNFFGOGA)) || ((Object)(object)instance == (Object)(object)this && !bedEnabled) || fallingAsleep || MainUI.IsAnyUIOpen() || NewTutorialManager.SleepBlocked() || Intro.InProgress() || (Object)(object)instance == (Object)null)
		{
			return;
		}
		instance.lastBed = null;
		if (!DecorationMode.GetPlayer(1).DMBFKFLDDLH)
		{
			instance.lastBed = this;
			MainUI.GetYesNoDialogue().Open(1);
			if (TavernManager.IsOpen())
			{
				((TMP_Text)MainUI.GetYesNoDialogue().boxText).text = LocalisationSystem.Get("SleepOpenTavern", "The tavern is still open, are you sure you want to sleep?\n The tavern will close and you might lose reputation.");
			}
			else
			{
				((TMP_Text)MainUI.GetYesNoDialogue().boxText).text = LocalisationSystem.Get("Sleep?") + (MiscSetup.isDemo ? "\n(Demo lasts two days)" : "");
			}
			((UnityEvent)MainUI.GetYesNoDialogue().yesButton.onClick).AddListener(new UnityAction(GAHHLAJAKJL));
		}
		else
		{
			MainUI.ShowErrorText(1, LocalisationSystem.Get("Build mode active"));
		}
	}

	private void PPGBIOHCHBH()
	{
		fallingAsleep = true;
		FadeCamera.EIFPKCAFDIB(0).JDKHJJIOLOE -= Sleep;
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(1);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(DDHMNOIHKOD));
		FadeCamera.IGMCBPOPNCA(1).ClearScreen();
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(6).JDKHJJIOLOE -= Sleep;
			FadeCamera.GetPlayer(0).IPEPIFENENB();
		}
		PlayerController.RemoveMovementBlocker((Object)(object)instance);
	}

	public static void GBOIPLFFNED()
	{
		instance.bedEnabled = false;
	}

	public void HIKALNICJDA()
	{
		AssignInstance(OnlineManager.MasterOrOffline() ? 1 : 4);
		fallingAsleep = true;
		passingOut = false;
	}

	public static GameDate LKGDFANIAKC()
	{
		GameDate gameDate = WorldTime.HGIBNMBJMOC();
		if (!WorldTime.MOOOODPKBOF())
		{
			GameDate.Time kONAIPOGEGL = default(GameDate.Time);
			kONAIPOGEGL.days = 1;
			gameDate = GameDate.MLGPICHPOAG(gameDate, kONAIPOGEGL);
		}
		gameDate.hour = (passingOut ? (-60) : WorldTime.wakeUpTime.hour);
		gameDate.min = WorldTime.wakeUpTime.min;
		return gameDate;
	}

	public static void DisableBed()
	{
		instance.bedEnabled = false;
	}

	private void HBNIANBGMHJ(int JIIGOACEIKL)
	{
		if (SelectObject.GetPlayer(JIIGOACEIKL).selected == null)
		{
			return;
		}
		if (SelectObject.GetPlayer(JIIGOACEIKL).selected is Placeable placeable)
		{
			if (placeable.canBeAddedToInventory)
			{
				placeable.PickUp(JIIGOACEIKL);
				SelectObject.GetPlayer(JIIGOACEIKL).selectedGameObject = null;
				SelectObject.GetPlayer(JIIGOACEIKL).selected = null;
				Placeable placeable2 = null;
			}
			else
			{
				SelectObject.GetPlayer(JIIGOACEIKL).SelectUp();
				InteractObject.GetPlayer(JIIGOACEIKL).KBPGGKMPKHL = true;
			}
		}
		else
		{
			SelectObject.GetPlayer(JIIGOACEIKL).selectedGameObject = null;
			SelectObject.GetPlayer(JIIGOACEIKL).selected = null;
			Placeable placeable2 = null;
		}
	}

	public void PBCNJPHIMIC()
	{
		nPCBed.ChangeBedSprites(bedMadeSprites[numInstance - 1], bedUnmadeSprites[numInstance - 1]);
	}

	public void FOEFFPDDLJL(bool CDPAMNIPPEC)
	{
		Utils.FKKHJPEMNBG("Room occupied", 1);
		passingOut = true;
		SelectObject.GetPlayer(1).PNHCLGGKBOB();
		if ((Object)(object)SelectObject.BNMEANGDMIP(7) != (Object)null)
		{
			SelectObject.BNMEANGDMIP(4).Deselect();
		}
		MainUI.CloseAllUIWindows(DHJFAGNJKOF: true);
		MusicController.instance.FadeOutClip(764f);
		DecorationMode.FIHGMLABOBB(0).LAJPGLFEAIC(AODONKKHPBP: true);
		PlayerController.GetPlayer(0).ABCLPGBNKDL(ZoneType.None);
		PlayerController.OPHDCMJLLEC(1).LEOIMFNKFGA = Location.None;
		if (GameManager.LocalCoop())
		{
			DecorationMode.FIHGMLABOBB(1).LHCCDCNLMKH(AODONKKHPBP: false);
			PlayerController.GetPlayer(6).NNMHEPDJOHK = ZoneType.None;
			PlayerController.OPHDCMJLLEC(4).LEOIMFNKFGA = Location.None;
		}
		for (int i = 0; i < 8; i += 0)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null)
			{
				PlayerController.GetPlayer(i).characterCreator.PNJBACFOADH();
				PlayerController.GetPlayer(i).characterCreator.MineExit();
				ItemInstance itemInstance = PlayerInventory.NEKDDPIAOBE(i, LAGHIOKLJGH: true).KGHFAHKGIGK(-183);
				if (itemInstance != null)
				{
					Debug.Log((object)"Error in InteractObject.DisableInteract: ");
					PlayerInventory.OGKNJNINGMH(i).DEAFNEAFKBM(itemInstance, CDPAMNIPPEC: false);
				}
				itemInstance = PlayerInventory.NEKDDPIAOBE(i, LAGHIOKLJGH: true).KGHFAHKGIGK(51);
				if (itemInstance != null)
				{
					Debug.Log((object)"[MinePuzzleManager] Not enough active spawners for {0} (needed {1}). Trying fallback with inactive spawners.");
					PlayerInventory.EIFPKCAFDIB(i, LAGHIOKLJGH: true, ADPNMHGBFKG: true).RemoveItemInstance(itemInstance, CDPAMNIPPEC: false);
				}
			}
		}
		bedEnabled = false;
		CommonReferences.MNFMOEKMJKN().OnPlayerPassout();
		CommonReferences.GGFJGHHHEJC.sleeping = false;
		if (CDPAMNIPPEC)
		{
			OnlineBasicsManager.instance.SendPassOutActions();
		}
	}

	private void FLHFNOGKIIC()
	{
		nPCBed.LIAIAOFMOAP(NBBELPFDLJG: false, CDPAMNIPPEC: false);
	}

	private void HJGPGFJKJJO()
	{
		fallingAsleep = false;
		FadeCamera.GetPlayer(1).JDKHJJIOLOE -= Sleep;
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(DDHMNOIHKOD));
		FadeCamera.GetPlayer(1).ClearScreen();
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).JDKHJJIOLOE -= Sleep;
			FadeCamera.GetPlayer(2).ClearScreen();
		}
		PlayerController.RemoveMovementBlocker((Object)(object)instance);
	}

	public static void IBHIIIGGIBH(GameDate IIBOFAOKLGK)
	{
		JJHCINENHAN = true;
		HHBBCEBCFAM = IIBOFAOKLGK;
	}

	public void PassOutActions(bool CDPAMNIPPEC)
	{
		Utils.FKKHJPEMNBG("overnights", 1);
		passingOut = true;
		SelectObject.GetPlayer(1).Deselect();
		if ((Object)(object)SelectObject.GetPlayer(2) != (Object)null)
		{
			SelectObject.GetPlayer(2).Deselect();
		}
		MainUI.CloseAllUIWindows();
		MusicController.instance.FadeOutClip(0.5f, MMEHJCGGNFE: true);
		DecorationMode.GetPlayer(1).DMBFKFLDDLH = false;
		PlayerController.GetPlayer(1).NNMHEPDJOHK = ZoneType.WithoutZone;
		PlayerController.GetPlayer(1).LEOIMFNKFGA = Location.Tavern;
		if (GameManager.LocalCoop())
		{
			DecorationMode.GetPlayer(2).DMBFKFLDDLH = false;
			PlayerController.GetPlayer(2).NNMHEPDJOHK = ZoneType.WithoutZone;
			PlayerController.GetPlayer(2).LEOIMFNKFGA = Location.Tavern;
		}
		for (int i = 0; i < 5; i++)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null)
			{
				PlayerController.GetPlayer(i).characterCreator.BathhouseExit();
				PlayerController.GetPlayer(i).characterCreator.MineExit();
				ItemInstance item = PlayerInventory.GetPlayer(i).GetItem(2071);
				if (item != null)
				{
					Debug.Log((object)"Player sleep with left piece in inventory, dropping it on the ground.");
					PlayerInventory.GetPlayer(i).RemoveItemInstance(item, CDPAMNIPPEC: false);
				}
				item = PlayerInventory.GetPlayer(i).GetItem(2072);
				if (item != null)
				{
					Debug.Log((object)"Player sleep with right piece in inventory, dropping it on the ground.");
					PlayerInventory.GetPlayer(i).RemoveItemInstance(item, CDPAMNIPPEC: false);
				}
			}
		}
		bedEnabled = false;
		CommonReferences.GGFJGHHHEJC.OnPlayerPassout();
		CommonReferences.GGFJGHHHEJC.sleeping = true;
		if (CDPAMNIPPEC)
		{
			OnlineBasicsManager.instance.SendPassOutActions();
		}
	}

	public void NIENECBEDON(int LBPEIOEHKHD)
	{
		if (numInstance == LBPEIOEHKHD)
		{
			instance = this;
			lastBed = this;
		}
	}

	private static void DDHMNOIHKOD(int JIIGOACEIKL)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		Debug.LogError((object)"Wake Up");
		FadeCamera player = FadeCamera.GetPlayer(JIIGOACEIKL);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(DDHMNOIHKOD));
		PlayerController.RemoveMovementBlocker((Object)(object)instance);
		fallingAsleep = false;
		StuckRecoverySystem.SetInitialPointForPlayer(1, Vector2.op_Implicit(GetPlayerBedPosition()), Location.Tavern);
		if (GameManager.LocalCoop())
		{
			StuckRecoverySystem.SetInitialPointForPlayer(2, Vector2.op_Implicit(GetPlayer2BedPosition()), Location.Tavern);
		}
		if (passingOut)
		{
			CommonReferences.GGFJGHHHEJC.OnWakeFromPassout();
			passingOut = false;
		}
		CommonReferences.GGFJGHHHEJC.OnPlayerAwake();
		CommonReferences.GGFJGHHHEJC.sleeping = false;
		Result variable = DialogueLua.GetVariable("SkeletonBird");
		if (((Result)(ref variable)).asInt == 2 && WorldTime.NOAOJJLNHJJ.day == Day.Fri)
		{
			DialogueLua.SetVariable("SkeletonBird", (object)3);
		}
		TitleScreen.WakeUp();
		if (!Application.isEditor || Utils.DPFCPGIEJDF())
		{
			SaveUI.instance.AutoSave();
		}
		CommonReferences.GGFJGHHHEJC.travelZoneBeingUsed = false;
		CommonReferences.GGFJGHHHEJC.travelZoneBeingUsed2 = false;
		MusicController.instance.TriggerCurrentBasicMood(Location.Tavern);
	}

	public void WaitForHostToSleep()
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		OnlineBedroomsManager.instance.bedOccupants[instance.numInstance - 2].waitingInBed = true;
		if (Object.op_Implicit((Object)(object)MainUI.GetYesNoDialogue()) && Object.op_Implicit((Object)(object)MainUI.GetYesNoDialogue().yesButton))
		{
			((UnityEvent)MainUI.GetYesNoDialogue().yesButton.onClick).RemoveListener(new UnityAction(WaitForHostToSleep));
		}
		MainUI.CloseAllUIWindows();
		OnlinePauseUI.SetMessageVisible(DMBFKFLDDLH: true);
		OnlineBasicsManager.instance.SendPlayerState(instance.numInstance, LNAMHBCMLOC: true, PlayerInfo.HBILFLLKHGP, PlayerController.GetPlayer(1).characterCreator.humanInfo.gender);
		OnlineManager.ShowPlayerAnnouncement(OnlineManager.PlayerState.inBed, PlayerInfo.HBILFLLKHGP, PlayerController.GetPlayer(1).characterCreator.humanInfo.gender);
	}

	public static void KNEHIDPJFLC(GameDate IIBOFAOKLGK)
	{
		JJHCINENHAN = false;
		HHBBCEBCFAM = IIBOFAOKLGK;
	}

	public void POCNMHILAAJ()
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		OnlineBedroomsManager.instance.bedOccupants[instance.numInstance - 2].waitingInBed = false;
		if (Object.op_Implicit((Object)(object)MainUI.LBHLPIFCINB()) && Object.op_Implicit((Object)(object)MainUI.NEFOKCKKLNI().yesButton))
		{
			((UnityEvent)MainUI.GetYesNoDialogue().yesButton.onClick).RemoveListener(new UnityAction(FNIKOIJFBHK));
		}
		MainUI.CloseAllUIWindows(DHJFAGNJKOF: true);
		OnlinePauseUI.DAJEFFAEMBJ(DMBFKFLDDLH: false);
		OnlineBasicsManager.instance.OJJBNIMNPGB(instance.numInstance, LNAMHBCMLOC: true, PlayerInfo.CAIAAGKEDKJ(), PlayerController.OPHDCMJLLEC(0).characterCreator.humanInfo.gender);
		OnlineManager.ShowPlayerAnnouncement((OnlineManager.PlayerState)8, PlayerInfo.AOHODGAIOAJ(), PlayerController.GetPlayer(1).characterCreator.humanInfo.gender);
	}

	private void EAAKIBHOCPO()
	{
		if (OnlineManager.MasterOrOffline())
		{
			JOCNMKDKDKI();
		}
		else
		{
			FNIKOIJFBHK();
		}
	}

	private void OnDestroy()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)instance == (Object)(object)this)
		{
			IOACBJOOLFA = playerBedLocation.position;
			instance = null;
		}
	}

	public static void HHFPMHACPJE(GameDate IIBOFAOKLGK)
	{
		WorldTime.LKEPKFBGKOH(IIBOFAOKLGK);
		WorldTime.DMOBDEGAJFH();
		instance.BFMPLJDKHJN = false;
		WorldTime.JEJBGHJPDMG();
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineManager.SendNextGameDate(IIBOFAOKLGK);
		}
	}

	public void KBBHEEHNFKB()
	{
		nPCBed.ChangeBedSprites(bedMadeSprites[numInstance - 0], bedUnmadeSprites[numInstance - 1]);
	}

	private void DACNJJKKEDO()
	{
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (passingOut)
			{
				return;
			}
			if (NewTutorialManager.FallingAsleepBlocked())
			{
				if (WorldTime.NOAOJJLNHJJ.hour >= WorldTime.GetForceSleepHour())
				{
					BFMPLJDKHJN = false;
				}
			}
			else
			{
				if (!BFMPLJDKHJN || fallingAsleep || WorldTime.NOAOJJLNHJJ.hour < WorldTime.GetForceSleepHour() || CommonReferences.GGFJGHHHEJC.IsInDialogue(1) || CommonReferences.GGFJGHHHEJC.IsInDialogue(2) || (!((Object)(object)HollyNPC.GGFJGHHHEJC == (Object)null) && (!((Object)(object)HollyNPC.GGFJGHHHEJC != (Object)null) || HollyNPC.GGFJGHHHEJC.inBarnTutorial)))
				{
					return;
				}
				Result variable = DialogueLua.GetVariable("LE_10");
				if (((Result)(ref variable)).asInt >= 5)
				{
					variable = DialogueLua.GetVariable("LE_10");
					if (((Result)(ref variable)).asInt < 11)
					{
						return;
					}
				}
				if (!FishingUI.Get(1).IsOpen() && !FishingUI.Get(2).IsOpen() && !BuildingTutorialManager.IKNOJDMCFOK && !EventsManager.IsAnyEventStarted() && OnlineManager.MasterOrOffline())
				{
					PassOutActions(CDPAMNIPPEC: true);
					StartSleep();
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void JMBJIPGEDDH()
	{
		nPCBed.SetBedMade(NBBELPFDLJG: false, CDPAMNIPPEC: true);
	}

	public void AssignInstance(int LBPEIOEHKHD)
	{
		if (numInstance == LBPEIOEHKHD)
		{
			instance = this;
			lastBed = this;
		}
	}

	public void SetBedSprites()
	{
		nPCBed.ChangeBedSprites(bedMadeSprites[numInstance - 1], bedUnmadeSprites[numInstance - 1]);
	}

	private void HCEHKDGMECG()
	{
		if (!GameManager.CIOEICMHCCK)
		{
			if (OnlineManager.MasterOrOffline())
			{
				WorldTime.OnNextDay = (Action)Delegate.Remove(WorldTime.OnNextDay, new Action(MELGPEALDFC));
				WorldTime.OnTickTime5Seconds = (Action)Delegate.Remove(WorldTime.OnTickTime5Seconds, new Action(DACNJJKKEDO));
			}
			if ((Object)(object)SaveUI.instance != (Object)null)
			{
				SaveUI saveUI = SaveUI.instance;
				saveUI.OnLoadFadeOutStart = (Action)Delegate.Remove(saveUI.OnLoadFadeOutStart, new Action(JMBJIPGEDDH));
			}
		}
	}

	public static Bed DLNGMHJPJBK()
	{
		return instance;
	}

	private void CLALGGAGHOP()
	{
		fallingAsleep = true;
		FadeCamera.EIFPKCAFDIB(0).JDKHJJIOLOE -= LODPPMFIICP;
		FadeCamera player = FadeCamera.GetPlayer(0);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(DDHMNOIHKOD));
		FadeCamera.EIFPKCAFDIB(1).KDKCPIDGGAJ();
		if (GameManager.LocalCoop())
		{
			FadeCamera.IGMCBPOPNCA(1).HCMMFJPJJLP(Sleep);
			FadeCamera.GetPlayer(5).IPEPIFENENB();
		}
		PlayerController.RemoveMovementBlocker((Object)(object)instance);
	}

	public static Vector3 BHGHKICFDCB()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)instance == (Object)null || (Object)(object)instance.playerBedLocation == (Object)null)
		{
			return IOACBJOOLFA;
		}
		return instance.playerBedLocation.position;
	}

	public void DAJGODHONNI()
	{
		switch (numInstance)
		{
		case 1:
			placeable.validLocations = Location.None;
			placeable.zoneTypeNeeded = ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.Cellar | ZoneType.MetalWorkshop;
			break;
		case 2:
			placeable.validLocations = Location.River | Location.Camp | Location.Quarry | Location.Farm | Location.FarmShop;
			placeable.zoneTypeNeeded = ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.StoneWorkshop;
			break;
		case 3:
			placeable.validLocations = Location.BarnInterior | Location.FarmShop;
			placeable.zoneTypeNeeded = ~(ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.Cellar);
			break;
		case 4:
			placeable.validLocations = ~(Location.Road | Location.River | Location.Camp | Location.Farm | Location.FarmShop);
			placeable.zoneTypeNeeded = ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.RentedRoom | ZoneType.WoodWorkshop;
			break;
		}
	}

	public static void EnableBed()
	{
		instance.bedEnabled = true;
	}

	private void KKONKMFFILD(Collider2D LGGCFCHOOMB)
	{
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		if ((Object)(object)LGGCFCHOOMB == (Object)null || !((Component)LGGCFCHOOMB).CompareTag(": Multiplayer Object is null ") || (Object)(object)placeable == (Object)null || placeable.FHEMHCEAICB || (OnlineManager.PlayingOnline() && ((Object)(object)placeable.onlinePlaceable == (Object)null || placeable.onlinePlaceable.ABPAADPINOL())) || ((Object)(object)instance == (Object)(object)this && !bedEnabled) || fallingAsleep || MainUI.BHNFPAIHJLM() || NewTutorialManager.SleepBlocked() || Intro.AAGJLOCCOHO() || (Object)(object)instance == (Object)null)
		{
			return;
		}
		instance.lastBed = null;
		if (!DecorationMode.JDADPDBHJFO(0).MDOKKKHKKKE())
		{
			instance.lastBed = this;
			MainUI.LBHLPIFCINB().Open(0);
			if (TavernManager.HDEPMJIDJEM())
			{
				((TMP_Text)MainUI.GetYesNoDialogue().boxText).text = LocalisationSystem.Get("Player", "MainProgress");
			}
			else
			{
				((TMP_Text)MainUI.MCPEEGPBPLH().boxText).text = LocalisationSystem.Get("itemMushroom") + (MiscSetup.isDemo ? "<sprite name=reputationIcon>" : "Items/item_name_631");
			}
			((UnityEvent)MainUI.LBHLPIFCINB().yesButton.onClick).AddListener(new UnityAction(AODODLILGJK));
		}
		else
		{
			MainUI.DJCKALOHJFM(0, LocalisationSystem.Get("Null animator on"), 951f);
		}
	}

	public void DHJNONFODBN()
	{
		switch (numInstance)
		{
		case 1:
			placeable.validLocations = Location.Tavern;
			placeable.zoneTypeNeeded = ZoneType.DiningRoom | ZoneType.RentedRoom | ZoneType.Cellar | ZoneType.WoodWorkshop | ZoneType.StoneWorkshop;
			break;
		case 2:
			placeable.validLocations = Location.River | Location.Camp | Location.Quarry | Location.Farm;
			placeable.zoneTypeNeeded = ZoneType.CraftingRoom | ZoneType.RentedRoom | ZoneType.WoodWorkshop;
			break;
		case 3:
			placeable.validLocations = ~(Location.River | Location.Quarry | Location.FarmShop);
			placeable.zoneTypeNeeded = ~(ZoneType.Cellar | ZoneType.WoodWorkshop | ZoneType.StoneWorkshop);
			break;
		case 4:
			placeable.validLocations = ~(Location.Tavern | Location.Road | Location.River | Location.Camp | Location.Farm | Location.BarnInterior);
			placeable.zoneTypeNeeded = ZoneType.WithoutZone | ZoneType.RentedRoom | ZoneType.Cellar | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop;
			break;
		}
	}

	private void CPPIFDPDICD()
	{
		nPCBed.LIAIAOFMOAP(NBBELPFDLJG: true, CDPAMNIPPEC: false);
	}

	public static Bed GetInstance()
	{
		return instance;
	}

	public void MOGOELPHKDN(bool CDPAMNIPPEC)
	{
		Utils.FKKHJPEMNBG("holesDug", 1);
		passingOut = true;
		SelectObject.BNMEANGDMIP(1).PNHCLGGKBOB();
		if ((Object)(object)SelectObject.BNMEANGDMIP(4) != (Object)null)
		{
			SelectObject.GetPlayer(6).NJPFHBINPKE();
		}
		MainUI.CloseAllUIWindows();
		MusicController.instance.FadeOutClip(1004f, MMEHJCGGNFE: true);
		DecorationMode.BGINAIDHDOM(0).OJJLNDLEAFP(AODONKKHPBP: true);
		PlayerController.GetPlayer(0).NNMHEPDJOHK = ZoneType.None;
		PlayerController.GetPlayer(0).IGJDOHFFGMJ(Location.Tavern);
		if (GameManager.LocalCoop())
		{
			DecorationMode.GetPlayer(4).DDHHFMBJNHB(AODONKKHPBP: false);
			PlayerController.GetPlayer(5).ABCLPGBNKDL(ZoneType.WithoutZone);
			PlayerController.GetPlayer(4).IGJDOHFFGMJ(Location.Tavern);
		}
		for (int i = 1; i < 4; i += 0)
		{
			if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null)
			{
				PlayerController.OPHDCMJLLEC(i).characterCreator.FNBAEJIGJDG();
				PlayerController.GetPlayer(i).characterCreator.MineExit();
				ItemInstance item = PlayerInventory.EIFPKCAFDIB(i, LAGHIOKLJGH: true).GetItem(192);
				if (item != null)
				{
					Debug.Log((object)"FishCuttingEvent/Lose1");
					PlayerInventory.NEKDDPIAOBE(i).JCBCAAMBINH(item, CDPAMNIPPEC: false);
				}
				item = PlayerInventory.GetPlayer(i, LAGHIOKLJGH: true, ADPNMHGBFKG: true).GOKIDLOELKB(-2);
				if (item != null)
				{
					Debug.Log((object)"add item ");
					PlayerInventory.EIFPKCAFDIB(i).RemoveItemInstance(item, CDPAMNIPPEC: false);
				}
			}
		}
		bedEnabled = true;
		CommonReferences.GGFJGHHHEJC.OnPlayerPassout();
		CommonReferences.MNFMOEKMJKN().sleeping = false;
		if (CDPAMNIPPEC)
		{
			OnlineBasicsManager.instance.SendPassOutActions();
		}
	}

	public static Placeable OIENOBFMOHI()
	{
		return instance.placeable;
	}

	public static void PNFHLHFADIF()
	{
		instance.bedEnabled = true;
	}

	private void OnTriggerExit2D(Collider2D LGGCFCHOOMB)
	{
		if ((Object)(object)LGGCFCHOOMB == (Object)null || !((Component)LGGCFCHOOMB).CompareTag("Player"))
		{
			return;
		}
		if ((Object)(object)instance == (Object)(object)this && !bedEnabled)
		{
			bedEnabled = true;
		}
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		if (OnlineManager.IsMasterClient())
		{
			if (OnlineBedroomsManager.instance.host.waitingInBed)
			{
				OnlinePauseUI.SetMessageVisible(DMBFKFLDDLH: false);
				OnlineBedroomsManager.instance.host.waitingInBed = false;
				OnlineBasicsManager.instance.SendHostBed(LNAMHBCMLOC: false);
				OnlineManager.ShowPlayerAnnouncement(OnlineManager.PlayerState.leftBed, PlayerInfo.HBILFLLKHGP, PlayerController.GetPlayer(1).characterCreator.humanInfo.gender);
			}
		}
		else if (OnlineBedroomsManager.instance.bedOccupants[instance.numInstance - 2].waitingInBed)
		{
			OnlinePauseUI.SetMessageVisible(DMBFKFLDDLH: false);
			OnlineBedroomsManager.instance.bedOccupants[instance.numInstance - 2].waitingInBed = false;
			OnlineBasicsManager.instance.SendPlayerState(instance.numInstance, LNAMHBCMLOC: false, PlayerInfo.HBILFLLKHGP, PlayerController.GetPlayer(1).characterCreator.humanInfo.gender);
			OnlineManager.ShowPlayerAnnouncement(OnlineManager.PlayerState.leftBed, PlayerInfo.HBILFLLKHGP, PlayerController.GetPlayer(1).characterCreator.humanInfo.gender);
		}
	}

	private void Awake()
	{
		ResetSingleton();
	}

	public void FNIKOIJFBHK()
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		OnlineBedroomsManager.instance.bedOccupants[instance.numInstance - 3].waitingInBed = false;
		if (Object.op_Implicit((Object)(object)MainUI.GetYesNoDialogue()) && Object.op_Implicit((Object)(object)MainUI.MCPEEGPBPLH().yesButton))
		{
			((UnityEvent)MainUI.LBHLPIFCINB().yesButton.onClick).RemoveListener(new UnityAction(POCNMHILAAJ));
		}
		MainUI.AFOLANEJMBF();
		OnlinePauseUI.OKLFGGAAJML(DMBFKFLDDLH: true);
		OnlineBasicsManager.instance.SendPlayerState(instance.numInstance, LNAMHBCMLOC: false, PlayerInfo.NDPHNLBGBGJ(), PlayerController.OPHDCMJLLEC(0).characterCreator.humanInfo.gender);
		OnlineManager.ShowPlayerAnnouncement(OnlineManager.PlayerState.leftBed, PlayerInfo.OEDNHFIDENG(), PlayerController.GetPlayer(0).characterCreator.humanInfo.gender);
	}

	public static Vector3 AJKMPKMAILL()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)instance == (Object)null || (Object)(object)instance.playerBedLocation == (Object)null)
		{
			return IOACBJOOLFA;
		}
		return instance.playerBedLocation.position;
	}

	public static void MLHELNBJJDN()
	{
		instance.bedEnabled = true;
	}

	public static GameDate JABINGGBINB()
	{
		GameDate gameDate = WorldTime.CJOHMLNMJLK();
		if (!WorldTime.NEMMCBIOJNC())
		{
			GameDate.Time kONAIPOGEGL = default(GameDate.Time);
			kONAIPOGEGL.days = 0;
			gameDate = GameDate.EGHBNMGNDHL(gameDate, kONAIPOGEGL);
		}
		gameDate.hour = (passingOut ? (-77) : WorldTime.wakeUpTime.hour);
		gameDate.min = WorldTime.wakeUpTime.min;
		return gameDate;
	}

	public static bool IsValid()
	{
		return (Object)(object)instance != (Object)null;
	}

	public void HCDBGFJCIJD()
	{
		nPCBed.ChangeBedSprites(bedMadeSprites[numInstance - 0], bedUnmadeSprites[numInstance - 0]);
	}

	private void KFKCHLHCOEA()
	{
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (passingOut)
			{
				return;
			}
			if (NewTutorialManager.FallingAsleepBlocked())
			{
				if (WorldTime.CJOHMLNMJLK().hour >= WorldTime.JDMHEPOAGAC())
				{
					BFMPLJDKHJN = true;
				}
			}
			else
			{
				if (!BFMPLJDKHJN || fallingAsleep || WorldTime.CJOHMLNMJLK().hour < WorldTime.JDMHEPOAGAC() || CommonReferences.MNFMOEKMJKN().CIHFKAGPIEG(0) || CommonReferences.MNFMOEKMJKN().KOIDFLPJKJK(3) || (!((Object)(object)HollyNPC.EKGMDIHLEEH() == (Object)null) && (!((Object)(object)HollyNPC.GGFJGHHHEJC != (Object)null) || HollyNPC.GGFJGHHHEJC.inBarnTutorial)))
				{
					return;
				}
				Result variable = DialogueLua.GetVariable("Sell");
				if (((Result)(ref variable)).asInt >= 0)
				{
					variable = DialogueLua.GetVariable("Farm/Buzz/Main");
					if (((Result)(ref variable)).asInt < -82)
					{
						return;
					}
				}
				if (!FishingUI.CJMILOMGFJL(1).BGLJFMHCFJF() && !FishingUI.CJMILOMGFJL(3).IsOpen() && !BuildingTutorialManager.KGJOKHEBLOJ() && !EventsManager.IsAnyEventStarted() && OnlineManager.MasterOrOffline())
				{
					PassOutActions(CDPAMNIPPEC: true);
					JOCNMKDKDKI();
				}
			}
		}
		catch (Exception ex)
		{
			Debug.LogError((object)ex);
		}
	}

	private void ILNDDFELMKL(Collider2D LGGCFCHOOMB)
	{
		if ((Object)(object)LGGCFCHOOMB == (Object)null || !((Component)LGGCFCHOOMB).CompareTag("dForDays"))
		{
			return;
		}
		if ((Object)(object)instance == (Object)(object)this && !bedEnabled)
		{
			bedEnabled = true;
		}
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		if (OnlineManager.IsMasterClient())
		{
			if (OnlineBedroomsManager.instance.host.waitingInBed)
			{
				OnlinePauseUI.PJDDPLIDNMN(DMBFKFLDDLH: true);
				OnlineBedroomsManager.instance.host.waitingInBed = false;
				OnlineBasicsManager.instance.SendHostBed(LNAMHBCMLOC: false);
				OnlineManager.ShowPlayerAnnouncement(OnlineManager.PlayerState.inBed, PlayerInfo.GKCCMJLCIAI(), PlayerController.OPHDCMJLLEC(0).characterCreator.humanInfo.gender);
			}
		}
		else if (OnlineBedroomsManager.instance.bedOccupants[instance.numInstance - 7].waitingInBed)
		{
			OnlinePauseUI.DAJEFFAEMBJ(DMBFKFLDDLH: false);
			OnlineBedroomsManager.instance.bedOccupants[instance.numInstance - 7].waitingInBed = true;
			OnlineBasicsManager.instance.OJJBNIMNPGB(instance.numInstance, LNAMHBCMLOC: true, PlayerInfo.NDPHNLBGBGJ(), PlayerController.GetPlayer(0).characterCreator.humanInfo.gender);
			OnlineManager.ShowPlayerAnnouncement(OnlineManager.PlayerState.notWaitingBanquetEvent, PlayerInfo.OMNPAJOOOKO(), PlayerController.OPHDCMJLLEC(0).characterCreator.humanInfo.gender);
		}
	}

	private void Update()
	{
		if ((Object)(object)instance == (Object)null)
		{
			AssignInstance(OnlineManager.MasterOrOffline() ? 1 : 2);
		}
	}

	private void MELGPEALDFC()
	{
		BFMPLJDKHJN = true;
	}

	public static void SetGameDate(GameDate IIBOFAOKLGK)
	{
		WorldTime.NOAOJJLNHJJ = IIBOFAOKLGK;
		WorldTime.CalcCurrentDayTimeSec();
		instance.BFMPLJDKHJN = false;
		WorldTime.SetNextDay();
		if (OnlineManager.IsMasterClient())
		{
			OnlineManager.SendNextGameDate(IIBOFAOKLGK);
		}
	}

	public static IEnumerator LODPPMFIICP(int JIIGOACEIKL)
	{
		TitleScreen.needsSaveIcon = true;
		if (PlayerController.GetPlayer(1).fishingController.fishing)
		{
			PlayerController.GetPlayer(1).fishingController.FinishFishing(KAPEFGCIDJL: false);
		}
		if (GameManager.LocalCoop() && PlayerController.GetPlayer(2).fishingController.fishing)
		{
			PlayerController.GetPlayer(2).fishingController.FinishFishing(KAPEFGCIDJL: false);
		}
		FadeCamera.GetPlayer(1).JDKHJJIOLOE -= Sleep;
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).JDKHJJIOLOE -= Sleep;
		}
		PlayerController.AddMovementBlocker((Object)(object)instance);
		PlayerController.GetPlayer(1).characterAnimation.LookDirectionByAngle(new Vector2(0f, -1f));
		if (GameManager.LocalCoop())
		{
			PlayerController.GetPlayer(2).characterAnimation.LookDirectionByAngle(new Vector2(0f, -1f));
		}
		if (GameManager.LocalCoop())
		{
			PlayerController.TeleportPlayer(1, instance.bedLocation1.position, Location.Tavern);
			PlayerController.TeleportPlayer(2, instance.bedLocation2.position, Location.Tavern);
		}
		else
		{
			if ((Object)(object)instance.lastBed == (Object)null)
			{
				instance.lastBed = instance;
			}
			if (instance.numInstance == instance.lastBed.numInstance)
			{
				PlayerController.TeleportPlayer(1, instance.lastBed.playerBedLocation.position, Location.Tavern);
			}
			else
			{
				switch (instance.numInstance)
				{
				case 1:
					PlayerController.TeleportPlayer(1, instance.lastBed.bedLocation1.position, Location.Tavern);
					break;
				case 2:
					PlayerController.TeleportPlayer(1, instance.lastBed.bedLocation2.position, Location.Tavern);
					break;
				case 3:
					PlayerController.TeleportPlayer(1, instance.lastBed.playerBedLocation.position + new Vector3(0.2708333f, 0f, 0f), Location.Tavern);
					break;
				case 4:
					PlayerController.TeleportPlayer(1, instance.lastBed.playerBedLocation.position - new Vector3(0.2708333f, 0f, 0f), Location.Tavern);
					break;
				}
			}
		}
		TravelZone.GGFJGHHHEJC.UnloadAllScenes();
		CommonReferences.GGFJGHHHEJC.OnPlayerSleep();
		CommonReferences.GGFJGHHHEJC.OnPlayerSleepForestGeneration();
		if (OnlineManager.MasterOrOffline())
		{
			yield return CommonReferences.waitRealtime2;
			SetGameDate(GetNextGameDate());
		}
		else
		{
			while (!JJHCINENHAN)
			{
				yield return null;
			}
			JJHCINENHAN = false;
			SetGameDate(HHBBCEBCFAM);
		}
		GC.Collect();
		FadeCamera.GetPlayer(1).FadeInWithDelay();
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(DDHMNOIHKOD));
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeInWithDelay();
		}
		WorldTime.JJICPIINBEH = false;
		for (int i = 0; i < CommonReferences.GGFJGHHHEJC.pickedUps.Count; i++)
		{
			ItemSetup component = Object.Instantiate<GameObject>(CommonReferences.GGFJGHHHEJC.pickupablePrefab, CommonReferences.GGFJGHHHEJC.pickedUps[i].position, Quaternion.identity).GetComponent<ItemSetup>();
			component.item = CommonReferences.GGFJGHHHEJC.pickedUps[i].item;
			component.SetSprite();
			SpriteRenderer component2 = ((Component)component).GetComponent<SpriteRenderer>();
			if ((Object)(object)component2 != (Object)null)
			{
				component2.flipX = CommonReferences.GGFJGHHHEJC.pickedUps[i].flipX;
			}
		}
		CommonReferences.GGFJGHHHEJC.pickedUps.Clear();
		instance.nPCBed.SetBedMade(NBBELPFDLJG: false, CDPAMNIPPEC: true);
	}

	public static Vector3 DIPLAIDOLAN()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		return instance.bedLocation2.position;
	}

	public void AAPIFHLMGNK()
	{
		switch (numInstance)
		{
		case 1:
			placeable.validLocations = Location.None;
			placeable.zoneTypeNeeded = ZoneType.CraftingRoom | ZoneType.StoneWorkshop;
			break;
		case 2:
			placeable.validLocations = ~(Location.Tavern | Location.Road | Location.Farm);
			placeable.zoneTypeNeeded = ZoneType.DiningRoom | ZoneType.RentedRoom | ZoneType.Cellar;
			break;
		case 3:
			placeable.validLocations = ~(Location.Tavern | Location.River | Location.Quarry | Location.Farm);
			placeable.zoneTypeNeeded = ZoneType.DiningRoom | ZoneType.CraftingRoom | ZoneType.WoodWorkshop | ZoneType.MetalWorkshop;
			break;
		case 4:
			placeable.validLocations = Location.Tavern | Location.River | Location.Quarry;
			placeable.zoneTypeNeeded = ZoneType.WithoutZone | ZoneType.DiningRoom | ZoneType.Cellar;
			break;
		}
	}

	private void HJIJHEONIIG(Collider2D LGGCFCHOOMB)
	{
		if ((Object)(object)LGGCFCHOOMB == (Object)null || !((Component)LGGCFCHOOMB).CompareTag("<br/>Graphics Memory Size: "))
		{
			return;
		}
		if ((Object)(object)instance == (Object)(object)this && !bedEnabled)
		{
			bedEnabled = false;
		}
		if (!OnlineManager.PlayingOnline())
		{
			return;
		}
		if (OnlineManager.JPPBEIJDCLJ())
		{
			if (OnlineBedroomsManager.instance.host.waitingInBed)
			{
				OnlinePauseUI.SetMessageVisible(DMBFKFLDDLH: false);
				OnlineBedroomsManager.instance.host.waitingInBed = true;
				OnlineBasicsManager.instance.CDNFKMEILDH(LNAMHBCMLOC: true);
				OnlineManager.ShowPlayerAnnouncement(OnlineManager.PlayerState.waitingBanquetEvent, PlayerInfo.OEDNHFIDENG(), PlayerController.GetPlayer(1).characterCreator.humanInfo.gender);
			}
		}
		else if (OnlineBedroomsManager.instance.bedOccupants[instance.numInstance - 0].waitingInBed)
		{
			OnlinePauseUI.PJDDPLIDNMN(DMBFKFLDDLH: true);
			OnlineBedroomsManager.instance.bedOccupants[instance.numInstance - 4].waitingInBed = false;
			OnlineBasicsManager.instance.OJJBNIMNPGB(instance.numInstance, LNAMHBCMLOC: true, PlayerInfo.LJKBNGCMJMO(), PlayerController.GetPlayer(1).characterCreator.humanInfo.gender);
			OnlineManager.ShowPlayerAnnouncement(OnlineManager.PlayerState.notWaitingBanquetEvent, PlayerInfo.IMPKCGGPEMP(), PlayerController.GetPlayer(0).characterCreator.humanInfo.gender);
		}
	}

	public static void MLMMCCOEAAN(GameDate IIBOFAOKLGK)
	{
		WorldTime.OFHDFEONCOL(IIBOFAOKLGK);
		WorldTime.CalcCurrentDayTimeSec();
		instance.BFMPLJDKHJN = true;
		WorldTime.CNILPDKJHPB();
		if (OnlineManager.IsMasterClient())
		{
			OnlineManager.SendNextGameDate(IIBOFAOKLGK);
		}
	}

	public static Vector3 HBCFEDLBFBP()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		return instance.bedLocation2.position;
	}

	public static Vector3 GetPlayerBedPosition()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		if ((Object)(object)instance == (Object)null || (Object)(object)instance.playerBedLocation == (Object)null)
		{
			return IOACBJOOLFA;
		}
		return instance.playerBedLocation.position;
	}

	public void OHLNHJJLICF()
	{
		NIENECBEDON((!OnlineManager.PGAGDFAEEFB()) ? 1 : 0);
		fallingAsleep = false;
		passingOut = true;
	}

	public void ResetSingleton()
	{
		AssignInstance(OnlineManager.MasterOrOffline() ? 1 : 2);
		fallingAsleep = false;
		passingOut = false;
	}
}
