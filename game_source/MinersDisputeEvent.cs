using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using psai.net;

public class MinersDisputeEvent : GameEvent
{
	[CompilerGenerated]
	private sealed class DLAHDPFNNBN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MinersDisputeEvent _003C_003E4__this;

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
		public DLAHDPFNNBN(int _003C_003E1__state)
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
			MinersDisputeEvent minersDisputeEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait3;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				if (!EventsManager.IsDone(EventsManager.EventType.MinersDispute))
				{
					minersDisputeEvent.ActivateEvent();
				}
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
	private sealed class NNHLBCGNEOA : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MinersDisputeEvent _003C_003E4__this;

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
		public NNHLBCGNEOA(int _003C_003E1__state)
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
			MinersDisputeEvent minersDisputeEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
			{
				_003C_003E1__state = -1;
				TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Quarry, Location.Road);
				travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(minersDisputeEvent.IFANGKBFGKF));
				if (GameManager.LocalCoop())
				{
					minersDisputeEvent.RemoveAllTravelZonesCallbacks(Location.Quarry);
				}
				((Renderer)instance.tocon).sortingOrder = 0;
				BrockNPC.GGFJGHHHEJC.animationBase.SetBool("Arguing", EGFGNGJGBOP: false);
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 1;
				return true;
			}
			case 1:
				_003C_003E1__state = -1;
				RochelleNPC.GGFJGHHHEJC.animationBase.SetBool("Arguing", EGFGNGJGBOP: false);
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				CliveNPC.GGFJGHHHEJC.animationBase.SetBool("Arguing", EGFGNGJGBOP: false);
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 3;
				return true;
			case 3:
				_003C_003E1__state = -1;
				MissionsManager.instance.StartMission(324, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
				RoadBlockedEvent.instance.ActivateEvent();
				PsaiCore.Instance.HoldCurrentIntensity(hold: false);
				PsaiCore.Instance.StopMusic(immediately: false);
				MusicController.instance.TriggerCurrentBasicMood(CommonReferences.wait20, Location.Quarry);
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
	private sealed class AOFHMANNIPF : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MinersDisputeEvent _003C_003E4__this;

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
		public AOFHMANNIPF(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			MinersDisputeEvent minersDisputeEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
			{
				_003C_003E1__state = -1;
				TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Quarry, Location.Road);
				travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(minersDisputeEvent.IFANGKBFGKF));
				instance.EDGDFPPKGDL = null;
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 1;
				return true;
			}
			case 1:
				_003C_003E1__state = -1;
				PsaiCore.Instance.StopMusic(immediately: true, 0.5f);
				MusicController.instance.TriggerMusicTheme(44);
				PsaiCore.Instance.HoldCurrentIntensity(hold: true);
				DialogueCameraTarget.GetPlayer(minersDisputeEvent.CJODOOFLLLB).cameraInEvent = true;
				DialogueCameraTarget.GetPlayer(minersDisputeEvent.CJODOOFLLLB).MoveCameraToPositionFromCameraTarget(Vector2.op_Implicit(minersDisputeEvent.cameraPosition.position));
				_003C_003E2__current = CommonReferences.wait3;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				instance.EDGDFPPKGDL = BrockNPC.GGFJGHHHEJC;
				instance.MDFALJKHKED = "DiscusionMineros/Main";
				BrockNPC.GGFJGHHHEJC.barkDialogue = false;
				BrockNPC.GGFJGHHHEJC.inSpecialEvent = true;
				BrockNPC.GGFJGHHHEJC.blockActionBar = true;
				if (instance.isActor)
				{
					BrockNPC.GGFJGHHHEJC.StartConversation(minersDisputeEvent.CJODOOFLLLB, "DiscusionMineros/Main");
				}
				else if (OnlineManager.PlayingOnline() && Utils.AHMPFOEGJHF(Location.Quarry))
				{
					_003C_003E2__current = BrockNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
					_003C_003E1__state = 3;
					return true;
				}
				break;
			case 3:
				_003C_003E1__state = -1;
				break;
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

	public static MinersDisputeEvent instance;

	public Transform[] characterPositions;

	public SpriteRenderer tocon;

	private IEnumerator FBAACGACBDO()
	{
		TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Quarry, Location.Road);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(IFANGKBFGKF));
		instance.EDGDFPPKGDL = null;
		yield return CommonReferences.wait05;
		PsaiCore.Instance.StopMusic(immediately: true, 0.5f);
		MusicController.instance.TriggerMusicTheme(44);
		PsaiCore.Instance.HoldCurrentIntensity(hold: true);
		DialogueCameraTarget.GetPlayer(CJODOOFLLLB).cameraInEvent = true;
		DialogueCameraTarget.GetPlayer(CJODOOFLLLB).MoveCameraToPositionFromCameraTarget(Vector2.op_Implicit(cameraPosition.position));
		yield return CommonReferences.wait3;
		instance.EDGDFPPKGDL = BrockNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "DiscusionMineros/Main";
		BrockNPC.GGFJGHHHEJC.barkDialogue = false;
		BrockNPC.GGFJGHHHEJC.inSpecialEvent = true;
		BrockNPC.GGFJGHHHEJC.blockActionBar = true;
		if (instance.isActor)
		{
			BrockNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "DiscusionMineros/Main");
		}
		else if (OnlineManager.PlayingOnline() && Utils.AHMPFOEGJHF(Location.Quarry))
		{
			yield return BrockNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private IEnumerator KGMFDKKBGKI()
	{
		return new DLAHDPFNNBN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator DBNCGNPFGOA()
	{
		return new AOFHMANNIPF(1)
		{
			_003C_003E4__this = this
		};
	}

	public override GameEvent GetInstance()
	{
		return instance;
	}

	private IEnumerator GILGKPKLDPD()
	{
		TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Quarry, Location.Road);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(IFANGKBFGKF));
		if (GameManager.LocalCoop())
		{
			RemoveAllTravelZonesCallbacks(Location.Quarry);
		}
		((Renderer)instance.tocon).sortingOrder = 0;
		BrockNPC.GGFJGHHHEJC.animationBase.SetBool("Arguing", EGFGNGJGBOP: false);
		yield return CommonReferences.wait1;
		RochelleNPC.GGFJGHHHEJC.animationBase.SetBool("Arguing", EGFGNGJGBOP: false);
		yield return CommonReferences.wait05;
		CliveNPC.GGFJGHHHEJC.animationBase.SetBool("Arguing", EGFGNGJGBOP: false);
		yield return CommonReferences.wait2;
		MissionsManager.instance.StartMission(324, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		RoadBlockedEvent.instance.ActivateEvent();
		PsaiCore.Instance.HoldCurrentIntensity(hold: false);
		PsaiCore.Instance.StopMusic(immediately: false);
		MusicController.instance.TriggerCurrentBasicMood(CommonReferences.wait20, Location.Quarry);
	}

	private void ONGCOMDEJLL()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		((Renderer)tocon).sortingOrder = 0;
		BrockNPC.PFHFIJDDOME().content.SetActive(true);
		((Component)BrockNPC.MMLBHCGFMMJ()).transform.position = characterPositions[0].position;
		BrockNPC.OPILDPFDFKJ().animationBase.LookDirection(Direction.Down);
		BrockNPC.DCAEBALADIM().animationBase.CGEADHOLHCH("Not enough ingredients", EGFGNGJGBOP: false, HALNIEBONKH: true);
		CliveNPC.GAGMPCEPONF().content.SetActive(false);
		((Component)CliveNPC.ABHIDHPMLLD()).transform.position = characterPositions[0].position;
		CliveNPC.CMIHGBHPLFP().animationBase.LookDirection(Direction.Left);
		CliveNPC.LADDMEMMJFP().animationBase.SetBool("Exit build mode", EGFGNGJGBOP: false);
		RochelleNPC.MIGKKKELOJO().content.SetActive(true);
		((Component)RochelleNPC.FMIDAFEGDCD()).transform.position = characterPositions[8].position;
		RochelleNPC.MIGKKKELOJO().animationBase.LookDirection((Direction)7);
		RochelleNPC.ICNFHJLLHGP().animationBase.CGEADHOLHCH(" (", EGFGNGJGBOP: true);
	}

	private void IFANGKBFGKF(int AAAIOBLCOFO)
	{
		StartEvent(BFLCJPHHDJM: false, CDPAMNIPPEC: false);
	}

	private IEnumerator LJABJLDHLCB()
	{
		TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Quarry, Location.Road);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(IFANGKBFGKF));
		if (GameManager.LocalCoop())
		{
			RemoveAllTravelZonesCallbacks(Location.Quarry);
		}
		((Renderer)instance.tocon).sortingOrder = 0;
		BrockNPC.GGFJGHHHEJC.animationBase.SetBool("Arguing", EGFGNGJGBOP: false);
		yield return CommonReferences.wait1;
		RochelleNPC.GGFJGHHHEJC.animationBase.SetBool("Arguing", EGFGNGJGBOP: false);
		yield return CommonReferences.wait05;
		CliveNPC.GGFJGHHHEJC.animationBase.SetBool("Arguing", EGFGNGJGBOP: false);
		yield return CommonReferences.wait2;
		MissionsManager.instance.StartMission(324, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		RoadBlockedEvent.instance.ActivateEvent();
		PsaiCore.Instance.HoldCurrentIntensity(hold: false);
		PsaiCore.Instance.StopMusic(immediately: false);
		MusicController.instance.TriggerCurrentBasicMood(CommonReferences.wait20, Location.Quarry);
	}

	private IEnumerator LCOBKPCBING()
	{
		TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Quarry, Location.Road);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(IFANGKBFGKF));
		instance.EDGDFPPKGDL = null;
		yield return CommonReferences.wait05;
		PsaiCore.Instance.StopMusic(immediately: true, 0.5f);
		MusicController.instance.TriggerMusicTheme(44);
		PsaiCore.Instance.HoldCurrentIntensity(hold: true);
		DialogueCameraTarget.GetPlayer(CJODOOFLLLB).cameraInEvent = true;
		DialogueCameraTarget.GetPlayer(CJODOOFLLLB).MoveCameraToPositionFromCameraTarget(Vector2.op_Implicit(cameraPosition.position));
		yield return CommonReferences.wait3;
		instance.EDGDFPPKGDL = BrockNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "DiscusionMineros/Main";
		BrockNPC.GGFJGHHHEJC.barkDialogue = false;
		BrockNPC.GGFJGHHHEJC.inSpecialEvent = true;
		BrockNPC.GGFJGHHHEJC.blockActionBar = true;
		if (instance.isActor)
		{
			BrockNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "DiscusionMineros/Main");
		}
		else if (OnlineManager.PlayingOnline() && Utils.AHMPFOEGJHF(Location.Quarry))
		{
			yield return BrockNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private IEnumerator OAMFAPIGIPE()
	{
		TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Quarry, Location.Road);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(IFANGKBFGKF));
		instance.EDGDFPPKGDL = null;
		yield return CommonReferences.wait05;
		PsaiCore.Instance.StopMusic(immediately: true, 0.5f);
		MusicController.instance.TriggerMusicTheme(44);
		PsaiCore.Instance.HoldCurrentIntensity(hold: true);
		DialogueCameraTarget.GetPlayer(CJODOOFLLLB).cameraInEvent = true;
		DialogueCameraTarget.GetPlayer(CJODOOFLLLB).MoveCameraToPositionFromCameraTarget(Vector2.op_Implicit(cameraPosition.position));
		yield return CommonReferences.wait3;
		instance.EDGDFPPKGDL = BrockNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "DiscusionMineros/Main";
		BrockNPC.GGFJGHHHEJC.barkDialogue = false;
		BrockNPC.GGFJGHHHEJC.inSpecialEvent = true;
		BrockNPC.GGFJGHHHEJC.blockActionBar = true;
		if (instance.isActor)
		{
			BrockNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "DiscusionMineros/Main");
		}
		else if (OnlineManager.PlayingOnline() && Utils.AHMPFOEGJHF(Location.Quarry))
		{
			yield return BrockNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private IEnumerator JCDGBBGFGAI()
	{
		yield return CommonReferences.wait3;
		if (!EventsManager.IsDone(EventsManager.EventType.MinersDispute))
		{
			ActivateEvent();
		}
	}

	private IEnumerator NABNDEHKMND()
	{
		return new DLAHDPFNNBN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator GJIIMNBHLKF()
	{
		return new AOFHMANNIPF(1)
		{
			_003C_003E4__this = this
		};
	}

	private void HEJHABHAOBN()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		((Renderer)tocon).sortingOrder = 0;
		BrockNPC.MAMKICHCPON().content.SetActive(false);
		((Component)BrockNPC.LKDJNKLJKGO()).transform.position = characterPositions[1].position;
		BrockNPC.LKOABOAADCD().animationBase.LookDirection(Direction.Down);
		BrockNPC.PFHFIJDDOME().animationBase.SetBool("ListViewEntry", EGFGNGJGBOP: true, HALNIEBONKH: true);
		CliveNPC.GDAHBDMFPCB().content.SetActive(true);
		((Component)CliveNPC.DCAEBALADIM()).transform.position = characterPositions[0].position;
		CliveNPC.IDIGFHEHIDM().animationBase.LookDirection((Direction)7);
		CliveNPC.JLNBMNKJCHE().animationBase.CGEADHOLHCH("Rummage", EGFGNGJGBOP: true);
		RochelleNPC.ELGNEJNLBNO().content.SetActive(false);
		((Component)RochelleNPC.EBAIHKJHCCA()).transform.position = characterPositions[6].position;
		RochelleNPC.ELGNEJNLBNO().animationBase.LookDirection(Direction.Down);
		RochelleNPC.EBAIHKJHCCA().animationBase.SetBool("Player", EGFGNGJGBOP: true, HALNIEBONKH: true);
	}

	private void OIBDMBKHGDF()
	{
		if ((MissionsManager.instance.LKKDCLPBABN(120) || MissionsManager.instance.BMFOFINGDLK(-139) || MissionsManager.instance.LKKDCLPBABN(-180) || MissionsManager.instance.LLOBLPDJNJE(5)) && !EventsManager.OMNBJDPGPEN((EventsManager.EventType)88))
		{
			ActivateEvent();
		}
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(INHHGMPOFBF));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(INHHGMPOFBF));
		}
	}

	private void IMPHCPJFACB(int AAAIOBLCOFO)
	{
		StartEvent(BFLCJPHHDJM: true, CDPAMNIPPEC: true);
	}

	private void BGPGIOMKKAO()
	{
		if ((MissionsManager.instance.IsMissionActive(300) || MissionsManager.instance.IsMissionComplete(300) || MissionsManager.instance.IsMissionActive(301) || MissionsManager.instance.IsMissionComplete(301)) && !EventsManager.IsDone(EventsManager.EventType.MinersDispute))
		{
			ActivateEvent();
		}
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(BGPGIOMKKAO));
		}
	}

	private IEnumerator EFOONHMKJEB()
	{
		TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Quarry, Location.Road);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(IFANGKBFGKF));
		instance.EDGDFPPKGDL = null;
		yield return CommonReferences.wait05;
		PsaiCore.Instance.StopMusic(immediately: true, 0.5f);
		MusicController.instance.TriggerMusicTheme(44);
		PsaiCore.Instance.HoldCurrentIntensity(hold: true);
		DialogueCameraTarget.GetPlayer(CJODOOFLLLB).cameraInEvent = true;
		DialogueCameraTarget.GetPlayer(CJODOOFLLLB).MoveCameraToPositionFromCameraTarget(Vector2.op_Implicit(cameraPosition.position));
		yield return CommonReferences.wait3;
		instance.EDGDFPPKGDL = BrockNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "DiscusionMineros/Main";
		BrockNPC.GGFJGHHHEJC.barkDialogue = false;
		BrockNPC.GGFJGHHHEJC.inSpecialEvent = true;
		BrockNPC.GGFJGHHHEJC.blockActionBar = true;
		if (instance.isActor)
		{
			BrockNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "DiscusionMineros/Main");
		}
		else if (OnlineManager.PlayingOnline() && Utils.AHMPFOEGJHF(Location.Quarry))
		{
			yield return BrockNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private void MCMKNBIBDFF()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(OIBDMBKHGDF));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(NHGBKNAJHOP));
		}
	}

	private IEnumerator IIDNCILCGKI()
	{
		return new AOFHMANNIPF(1)
		{
			_003C_003E4__this = this
		};
	}

	public override void ActivateEvent()
	{
		base.ActivateEvent();
		GJBNMNBAJIP();
		TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Quarry, Location.Road);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(OnTravelZoneTo));
		TravelZone travelZone2 = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Quarry, Location.Road);
		travelZone2.OnTravelZoneTo = (Action<int>)Delegate.Combine(travelZone2.OnTravelZoneTo, new Action<int>(OnTravelZoneTo));
	}

	private IEnumerator ENOMADMNLNP()
	{
		return new AOFHMANNIPF(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator MLACIHIBCCA()
	{
		TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Quarry, Location.Road);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(IFANGKBFGKF));
		if (GameManager.LocalCoop())
		{
			RemoveAllTravelZonesCallbacks(Location.Quarry);
		}
		((Renderer)instance.tocon).sortingOrder = 0;
		BrockNPC.GGFJGHHHEJC.animationBase.SetBool("Arguing", EGFGNGJGBOP: false);
		yield return CommonReferences.wait1;
		RochelleNPC.GGFJGHHHEJC.animationBase.SetBool("Arguing", EGFGNGJGBOP: false);
		yield return CommonReferences.wait05;
		CliveNPC.GGFJGHHHEJC.animationBase.SetBool("Arguing", EGFGNGJGBOP: false);
		yield return CommonReferences.wait2;
		MissionsManager.instance.StartMission(324, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		RoadBlockedEvent.instance.ActivateEvent();
		PsaiCore.Instance.HoldCurrentIntensity(hold: false);
		PsaiCore.Instance.StopMusic(immediately: false);
		MusicController.instance.TriggerCurrentBasicMood(CommonReferences.wait20, Location.Quarry);
	}

	private void MNLJDFCFFDE()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		((Renderer)tocon).sortingOrder = 0;
		BrockNPC.MAIDHAPANEB().content.SetActive(false);
		((Component)BrockNPC.FJAMHCAAEAM()).transform.position = characterPositions[1].position;
		BrockNPC.FMIDAFEGDCD().animationBase.LookDirection(Direction.Up);
		BrockNPC.FMIDAFEGDCD().animationBase.SetBool(" %", EGFGNGJGBOP: true, HALNIEBONKH: true);
		CliveNPC.CNDNOECMKME().content.SetActive(false);
		((Component)CliveNPC.CMIHGBHPLFP()).transform.position = characterPositions[0].position;
		CliveNPC.DBJCACLEFGK().animationBase.LookDirection(Direction.Right);
		CliveNPC.JHKLPLPBKCI().animationBase.SetBool("Disabled", EGFGNGJGBOP: true);
		RochelleNPC.KIALFDOKABP().content.SetActive(true);
		((Component)RochelleNPC.KNOKBLFFNLM()).transform.position = characterPositions[5].position;
		RochelleNPC.FMIDAFEGDCD().animationBase.LookDirection((Direction)8);
		RochelleNPC.MAAAKALBBEE().animationBase.CGEADHOLHCH("Error_OccupiedRoom", EGFGNGJGBOP: false);
	}

	private IEnumerator BECBOALHGEJ()
	{
		TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Quarry, Location.Road);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(IFANGKBFGKF));
		instance.EDGDFPPKGDL = null;
		yield return CommonReferences.wait05;
		PsaiCore.Instance.StopMusic(immediately: true, 0.5f);
		MusicController.instance.TriggerMusicTheme(44);
		PsaiCore.Instance.HoldCurrentIntensity(hold: true);
		DialogueCameraTarget.GetPlayer(CJODOOFLLLB).cameraInEvent = true;
		DialogueCameraTarget.GetPlayer(CJODOOFLLLB).MoveCameraToPositionFromCameraTarget(Vector2.op_Implicit(cameraPosition.position));
		yield return CommonReferences.wait3;
		instance.EDGDFPPKGDL = BrockNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "DiscusionMineros/Main";
		BrockNPC.GGFJGHHHEJC.barkDialogue = false;
		BrockNPC.GGFJGHHHEJC.inSpecialEvent = true;
		BrockNPC.GGFJGHHHEJC.blockActionBar = true;
		if (instance.isActor)
		{
			BrockNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "DiscusionMineros/Main");
		}
		else if (OnlineManager.PlayingOnline() && Utils.AHMPFOEGJHF(Location.Quarry))
		{
			yield return BrockNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	public void NJBOMLGDMFD(int AAAIOBLCOFO)
	{
		TravelZone travelZone = TravelZonesManager.OACNNJCLEDE().GetTravelZone(Location.Tavern | Location.River, Location.Tavern | Location.Road | Location.River);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(BEOFPJAFHIG));
		CJODOOFLLLB = AAAIOBLCOFO;
		StartEvent(BFLCJPHHDJM: true, CDPAMNIPPEC: false);
	}

	private void LPLKFFBPMDH(int AAAIOBLCOFO)
	{
		StartEvent(BFLCJPHHDJM: false, CDPAMNIPPEC: true);
	}

	private IEnumerator FPDBFCAJNMD()
	{
		return new AOFHMANNIPF(1)
		{
			_003C_003E4__this = this
		};
	}

	private void Start()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(BGPGIOMKKAO));
		}
	}

	public void CPDENGEECPL()
	{
		((MonoBehaviour)this).StartCoroutine(NABNDEHKMND());
	}

	private IEnumerator LEAOONIJDLD()
	{
		return new NNHLBCGNEOA(1)
		{
			_003C_003E4__this = this
		};
	}

	private void KOJFFCGELND(int AAAIOBLCOFO)
	{
		StartEvent(BFLCJPHHDJM: true, CDPAMNIPPEC: false);
	}

	private IEnumerator ENEDKDCENCG()
	{
		return new NNHLBCGNEOA(1)
		{
			_003C_003E4__this = this
		};
	}

	private void INHHGMPOFBF()
	{
		if ((MissionsManager.instance.IsMissionActive(32) || MissionsManager.instance.IsMissionComplete(109) || MissionsManager.instance.BHEDPICFPLG(-160) || MissionsManager.instance.LLOBLPDJNJE(13)) && !EventsManager.HGALHLALOKJ((EventsManager.EventType)(-56)))
		{
			ActivateEvent();
		}
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(NHGBKNAJHOP));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(BGPGIOMKKAO));
		}
	}

	private void JPOLFKMLHNH()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(NHGBKNAJHOP));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(NFKMBHPEAHN));
		}
	}

	public void ActivateMinersDisputeFromMission()
	{
		((MonoBehaviour)this).StartCoroutine(PPPNBBBKPNE());
	}

	public override void StartEvent(bool BFLCJPHHDJM, bool CDPAMNIPPEC)
	{
		base.StartEvent(BFLCJPHHDJM, CDPAMNIPPEC);
		TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Quarry, Location.Road);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(OnTravelZoneTo));
		if (GameManager.LocalCoop())
		{
			PrepareLocalCoop(Location.Quarry);
		}
		else if (!Utils.AHMPFOEGJHF(Location.Quarry))
		{
			TravelZone travelZone2 = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Quarry, Location.Road);
			travelZone2.OnTravelZoneTo = (Action<int>)Delegate.Combine(travelZone2.OnTravelZoneTo, new Action<int>(IFANGKBFGKF));
			return;
		}
		PlayerInputs.DisableKeyboardInputsAndMovement(CJODOOFLLLB, (MonoBehaviour)(object)instance);
		((MonoBehaviour)this).StartCoroutine(EFOONHMKJEB());
	}

	public void BIMOJDFCMBB()
	{
		((MonoBehaviour)this).StartCoroutine(GIPJHNBLAJB());
	}

	public void KPBHIECKCLH(int AAAIOBLCOFO)
	{
		TravelZone travelZone = TravelZonesManager.OMFKNGDCJFN().IMKJEBFOBKK(Location.Road | Location.Camp | Location.Quarry | Location.Farm, Location.None);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(KPBHIECKCLH));
		CJODOOFLLLB = AAAIOBLCOFO;
		StartEvent(BFLCJPHHDJM: true, CDPAMNIPPEC: false);
	}

	private void DMFMNEMDFNP()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(INHHGMPOFBF));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(DJBKHJFHAHL));
		}
	}

	public void MBEILICECIA(int AAAIOBLCOFO)
	{
		TravelZone travelZone = TravelZonesManager.BGMJCCFNNDL().KCJMDAPPJLB(Location.Tavern | Location.River | Location.Quarry | Location.BarnInterior, Location.Tavern | Location.Road);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(HIBKMFJJNHF));
		CJODOOFLLLB = AAAIOBLCOFO;
		StartEvent(BFLCJPHHDJM: false, CDPAMNIPPEC: true);
	}

	private IEnumerator DHINCHODEFI()
	{
		TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Quarry, Location.Road);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(IFANGKBFGKF));
		if (GameManager.LocalCoop())
		{
			RemoveAllTravelZonesCallbacks(Location.Quarry);
		}
		((Renderer)instance.tocon).sortingOrder = 0;
		BrockNPC.GGFJGHHHEJC.animationBase.SetBool("Arguing", EGFGNGJGBOP: false);
		yield return CommonReferences.wait1;
		RochelleNPC.GGFJGHHHEJC.animationBase.SetBool("Arguing", EGFGNGJGBOP: false);
		yield return CommonReferences.wait05;
		CliveNPC.GGFJGHHHEJC.animationBase.SetBool("Arguing", EGFGNGJGBOP: false);
		yield return CommonReferences.wait2;
		MissionsManager.instance.StartMission(324, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		RoadBlockedEvent.instance.ActivateEvent();
		PsaiCore.Instance.HoldCurrentIntensity(hold: false);
		PsaiCore.Instance.StopMusic(immediately: false);
		MusicController.instance.TriggerCurrentBasicMood(CommonReferences.wait20, Location.Quarry);
	}

	private IEnumerator DCPGBMIDPLA()
	{
		TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Quarry, Location.Road);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(IFANGKBFGKF));
		if (GameManager.LocalCoop())
		{
			RemoveAllTravelZonesCallbacks(Location.Quarry);
		}
		((Renderer)instance.tocon).sortingOrder = 0;
		BrockNPC.GGFJGHHHEJC.animationBase.SetBool("Arguing", EGFGNGJGBOP: false);
		yield return CommonReferences.wait1;
		RochelleNPC.GGFJGHHHEJC.animationBase.SetBool("Arguing", EGFGNGJGBOP: false);
		yield return CommonReferences.wait05;
		CliveNPC.GGFJGHHHEJC.animationBase.SetBool("Arguing", EGFGNGJGBOP: false);
		yield return CommonReferences.wait2;
		MissionsManager.instance.StartMission(324, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		RoadBlockedEvent.instance.ActivateEvent();
		PsaiCore.Instance.HoldCurrentIntensity(hold: false);
		PsaiCore.Instance.StopMusic(immediately: false);
		MusicController.instance.TriggerCurrentBasicMood(CommonReferences.wait20, Location.Quarry);
	}

	public override void EndEvent(bool BGKCHMNJBLJ)
	{
		base.EndEvent(BGKCHMNJBLJ);
		if (Utils.AHMPFOEGJHF(Location.Quarry))
		{
			DialogueCameraTarget.GetPlayer(1).ReturnControlToCameraTarget();
		}
		if (GameManager.LocalCoop() && Utils.AHMPFOEGJHF(Location.Quarry, 2))
		{
			LocalCooperativeManager.RestoreCameraInLocalCoop();
			DialogueCameraTarget.GetPlayer(2).ReturnControlToCameraTarget();
		}
		BrockNPC.GGFJGHHHEJC.inSpecialEvent = false;
		BrockNPC.GGFJGHHHEJC.blockActionBar = false;
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		if (Utils.AHMPFOEGJHF(Location.Quarry))
		{
			GameActionBarUI.Get(1).OpenUI();
		}
		if (GameManager.LocalCoop() && Utils.AHMPFOEGJHF(Location.Quarry, 2))
		{
			GameActionBarUI.Get(2).OpenUI();
		}
		((MonoBehaviour)instance).StartCoroutine(LJABJLDHLCB());
		if (BGKCHMNJBLJ && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendEndEvent(eventType);
		}
	}

	private void GJBNMNBAJIP()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		((Renderer)tocon).sortingOrder = 1;
		BrockNPC.GGFJGHHHEJC.content.SetActive(true);
		((Component)BrockNPC.GGFJGHHHEJC).transform.position = characterPositions[0].position;
		BrockNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Down);
		BrockNPC.GGFJGHHHEJC.animationBase.SetBool("Arguing", EGFGNGJGBOP: true);
		CliveNPC.GGFJGHHHEJC.content.SetActive(true);
		((Component)CliveNPC.GGFJGHHHEJC).transform.position = characterPositions[1].position;
		CliveNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Right);
		CliveNPC.GGFJGHHHEJC.animationBase.SetBool("Arguing", EGFGNGJGBOP: true);
		RochelleNPC.GGFJGHHHEJC.content.SetActive(true);
		((Component)RochelleNPC.GGFJGHHHEJC).transform.position = characterPositions[2].position;
		RochelleNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Right);
		RochelleNPC.GGFJGHHHEJC.animationBase.SetBool("Arguing", EGFGNGJGBOP: true);
	}

	private void NHGBKNAJHOP()
	{
		if ((MissionsManager.instance.LKKDCLPBABN(-172) || MissionsManager.instance.BMFOFINGDLK(-1) || MissionsManager.instance.IsMissionActive(12) || MissionsManager.instance.BMFOFINGDLK(134)) && !EventsManager.OMNBJDPGPEN((EventsManager.EventType)56))
		{
			ActivateEvent();
		}
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(INHHGMPOFBF));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(NHGBKNAJHOP));
		}
	}

	private IEnumerator GIPJHNBLAJB()
	{
		return new DLAHDPFNNBN(1)
		{
			_003C_003E4__this = this
		};
	}

	public void GBNJEKLHOIM()
	{
		((MonoBehaviour)this).StartCoroutine(KGMFDKKBGKI());
	}

	public void OnTravelZoneTo(int AAAIOBLCOFO)
	{
		TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Quarry, Location.Road);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(OnTravelZoneTo));
		CJODOOFLLLB = AAAIOBLCOFO;
		StartEvent(BFLCJPHHDJM: true, CDPAMNIPPEC: true);
	}

	private void CGHONFBKJEA()
	{
		if ((MissionsManager.instance.IsMissionActive(164) || MissionsManager.instance.BMFOFINGDLK(20) || MissionsManager.instance.IsMissionActive(128) || MissionsManager.instance.LLOBLPDJNJE(172)) && !EventsManager.ALEMDEBCFDH((EventsManager.EventType)(-94)))
		{
			ActivateEvent();
		}
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(OIBDMBKHGDF));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(INHHGMPOFBF));
		}
	}

	private void NFKMBHPEAHN()
	{
		if ((MissionsManager.instance.BHEDPICFPLG(77) || MissionsManager.instance.BMFOFINGDLK(164) || MissionsManager.instance.LKKDCLPBABN(-69) || MissionsManager.instance.BMFOFINGDLK(-160)) && !EventsManager.GGGECIBEKJG((EventsManager.EventType)(-153)))
		{
			ActivateEvent();
		}
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(INHHGMPOFBF));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(INHHGMPOFBF));
		}
	}

	public void NKICFDBPFOL()
	{
		((MonoBehaviour)this).StartCoroutine(NABNDEHKMND());
	}

	private void LINBGIENNNN(int AAAIOBLCOFO)
	{
		StartEvent(BFLCJPHHDJM: false, CDPAMNIPPEC: true);
	}

	private IEnumerator PPPNBBBKPNE()
	{
		yield return CommonReferences.wait3;
		if (!EventsManager.IsDone(EventsManager.EventType.MinersDispute))
		{
			ActivateEvent();
		}
	}

	private void BBHLPAKDHGL()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		((Renderer)tocon).sortingOrder = 0;
		BrockNPC.HFIJHDBKCIA().content.SetActive(false);
		((Component)BrockNPC.FMIDAFEGDCD()).transform.position = characterPositions[0].position;
		BrockNPC.PDECKLKPKCG().animationBase.LookDirection(Direction.Up);
		BrockNPC.BADFKMEJOKE().animationBase.CGEADHOLHCH("Items/item_description_724", EGFGNGJGBOP: false);
		CliveNPC.KNLLFEJAMNN().content.SetActive(true);
		((Component)CliveNPC.KNLLFEJAMNN()).transform.position = characterPositions[1].position;
		CliveNPC.GIKECEGLFOH().animationBase.LookDirection(Direction.Down);
		CliveNPC.MJCMPKPCNGB().animationBase.CGEADHOLHCH("F2", EGFGNGJGBOP: false);
		RochelleNPC.JFNOOMJMHCB().content.SetActive(false);
		((Component)RochelleNPC.KFGKCKCDMLG()).transform.position = characterPositions[0].position;
		RochelleNPC.LFPEPJBNCBF().animationBase.LookDirection(Direction.Diagonal);
		RochelleNPC.ICNFHJLLHGP().animationBase.SetBool("Rotate", EGFGNGJGBOP: false, HALNIEBONKH: true);
	}

	private void OIBDBLCLACB()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(NFKMBHPEAHN));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(CGHONFBKJEA));
		}
	}

	public void JMGNHKOHJDM(int AAAIOBLCOFO)
	{
		TravelZone travelZone = TravelZonesManager.DCAEBALADIM().OFIPCMMKFLP(~(Location.Tavern | Location.River | Location.Farm), Location.Road);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(OnTravelZoneTo));
		CJODOOFLLLB = AAAIOBLCOFO;
		StartEvent(BFLCJPHHDJM: false, CDPAMNIPPEC: true);
	}

	private void BELOIFKPNMM()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(NFKMBHPEAHN));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(DJBKHJFHAHL));
		}
	}

	private IEnumerator AHJHIPCOLIM()
	{
		TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Quarry, Location.Road);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(IFANGKBFGKF));
		if (GameManager.LocalCoop())
		{
			RemoveAllTravelZonesCallbacks(Location.Quarry);
		}
		((Renderer)instance.tocon).sortingOrder = 0;
		BrockNPC.GGFJGHHHEJC.animationBase.SetBool("Arguing", EGFGNGJGBOP: false);
		yield return CommonReferences.wait1;
		RochelleNPC.GGFJGHHHEJC.animationBase.SetBool("Arguing", EGFGNGJGBOP: false);
		yield return CommonReferences.wait05;
		CliveNPC.GGFJGHHHEJC.animationBase.SetBool("Arguing", EGFGNGJGBOP: false);
		yield return CommonReferences.wait2;
		MissionsManager.instance.StartMission(324, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		RoadBlockedEvent.instance.ActivateEvent();
		PsaiCore.Instance.HoldCurrentIntensity(hold: false);
		PsaiCore.Instance.StopMusic(immediately: false);
		MusicController.instance.TriggerCurrentBasicMood(CommonReferences.wait20, Location.Quarry);
	}

	private void FNEHEHIHEDJ(int AAAIOBLCOFO)
	{
		StartEvent(BFLCJPHHDJM: true, CDPAMNIPPEC: false);
	}

	private void PBFGFECPPPO()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(NFKMBHPEAHN));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(NFKMBHPEAHN));
		}
	}

	private void DJBKHJFHAHL()
	{
		if ((MissionsManager.instance.LKKDCLPBABN(-72) || MissionsManager.instance.IsMissionComplete(53) || MissionsManager.instance.LKKDCLPBABN(139) || MissionsManager.instance.LLOBLPDJNJE(-160)) && !EventsManager.GGGECIBEKJG((EventsManager.EventType)(-185)))
		{
			ActivateEvent();
		}
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(NHGBKNAJHOP));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(INHHGMPOFBF));
		}
	}

	private void FFEDAGCBGEB()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		((Renderer)tocon).sortingOrder = 1;
		BrockNPC.NBKKEINELDN().content.SetActive(true);
		((Component)BrockNPC.LKOABOAADCD()).transform.position = characterPositions[1].position;
		BrockNPC.LKDJNKLJKGO().animationBase.LookDirection(Direction.Up);
		BrockNPC.DCAEBALADIM().animationBase.SetBool("[OnlineLoadPuzzles] LoadTorchPuzzleMessage: puzzle instance {0} is null", EGFGNGJGBOP: false, HALNIEBONKH: true);
		CliveNPC.OMFKNGDCJFN().content.SetActive(false);
		((Component)CliveNPC.GAGMPCEPONF()).transform.position = characterPositions[0].position;
		CliveNPC.KCFGPDHELKP().animationBase.LookDirection(Direction.Diagonal);
		CliveNPC.HKBJIIJHBJB().animationBase.SetBool("UI2", EGFGNGJGBOP: false, HALNIEBONKH: true);
		RochelleNPC.KNOKBLFFNLM().content.SetActive(true);
		((Component)RochelleNPC.MIGKKKELOJO()).transform.position = characterPositions[0].position;
		RochelleNPC.ELGNEJNLBNO().animationBase.LookDirection(Direction.Diagonal);
		RochelleNPC.FMIDAFEGDCD().animationBase.SetBool("Error in DogIdleState.OnPlayerSleep: ", EGFGNGJGBOP: false, HALNIEBONKH: true);
	}

	private void HBMDEHPHAPF()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(INHHGMPOFBF));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(NFKMBHPEAHN));
		}
	}

	protected override void Awake()
	{
		base.Awake();
		instance = this;
	}

	private void IDPHKHGHJGN()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(OIBDMBKHGDF));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(OIBDMBKHGDF));
		}
	}

	private void OLMAMELHFAJ(int AAAIOBLCOFO)
	{
		StartEvent(BFLCJPHHDJM: true, CDPAMNIPPEC: false);
	}

	private IEnumerator NFDGJADMCOG()
	{
		return new NNHLBCGNEOA(1)
		{
			_003C_003E4__this = this
		};
	}

	public void BEOFPJAFHIG(int AAAIOBLCOFO)
	{
		TravelZone travelZone = TravelZonesManager.BGMJCCFNNDL().ECFDFECLDFK(Location.Tavern | Location.River | Location.Camp, Location.Tavern | Location.Road | Location.River);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(NJBOMLGDMFD));
		CJODOOFLLLB = AAAIOBLCOFO;
		StartEvent(BFLCJPHHDJM: false, CDPAMNIPPEC: true);
	}

	public void LDJMMHBKFJB(int AAAIOBLCOFO)
	{
		TravelZone travelZone = TravelZonesManager.BGMJCCFNNDL().KCJMDAPPJLB(Location.Camp | Location.Quarry | Location.Farm | Location.BarnInterior, Location.Tavern);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(OnTravelZoneTo));
		CJODOOFLLLB = AAAIOBLCOFO;
		StartEvent(BFLCJPHHDJM: true, CDPAMNIPPEC: true);
	}

	private IEnumerator OPPFGDILELM()
	{
		TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Quarry, Location.Road);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(IFANGKBFGKF));
		if (GameManager.LocalCoop())
		{
			RemoveAllTravelZonesCallbacks(Location.Quarry);
		}
		((Renderer)instance.tocon).sortingOrder = 0;
		BrockNPC.GGFJGHHHEJC.animationBase.SetBool("Arguing", EGFGNGJGBOP: false);
		yield return CommonReferences.wait1;
		RochelleNPC.GGFJGHHHEJC.animationBase.SetBool("Arguing", EGFGNGJGBOP: false);
		yield return CommonReferences.wait05;
		CliveNPC.GGFJGHHHEJC.animationBase.SetBool("Arguing", EGFGNGJGBOP: false);
		yield return CommonReferences.wait2;
		MissionsManager.instance.StartMission(324, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		RoadBlockedEvent.instance.ActivateEvent();
		PsaiCore.Instance.HoldCurrentIntensity(hold: false);
		PsaiCore.Instance.StopMusic(immediately: false);
		MusicController.instance.TriggerCurrentBasicMood(CommonReferences.wait20, Location.Quarry);
	}

	public void HIBKMFJJNHF(int AAAIOBLCOFO)
	{
		TravelZone travelZone = TravelZonesManager.OACNNJCLEDE().KCJMDAPPJLB(Location.None, Location.Tavern);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(OnTravelZoneTo));
		CJODOOFLLLB = AAAIOBLCOFO;
		StartEvent(BFLCJPHHDJM: false, CDPAMNIPPEC: false);
	}
}
