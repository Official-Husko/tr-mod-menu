using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using PixelCrushers.DialogueSystem;
using UnityEngine;
using psai.net;

public class OldMansDuelEvent : GameEvent
{
	[CompilerGenerated]
	private sealed class JPEKGDEIACO : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private float _003CoriginalVolume_003E5__2;

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
		public JPEKGDEIACO(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				instance.EDGDFPPKGDL = null;
				_003CoriginalVolume_003E5__2 = PsaiCore.Instance.GetVolume();
				MusicController.instance.ModifiyVolumeOverTime(0f, 0.3f);
				instance.backPain.SetActive(true);
				((Component)KujakuNPC.GGFJGHHHEJC).transform.parent = instance.backPain.transform;
				((Renderer)(KujakuNPC.GGFJGHHHEJC.animationBase as NPCAnimation).npcSprite).sortingOrder = 3;
				((Renderer)(KujakuNPC.GGFJGHHHEJC.animationBase as NPCAnimation).npcSprite).sortingLayerName = "Top";
				((Component)ZuzzuNPC.GGFJGHHHEJC).transform.parent = instance.backPain.transform;
				((Renderer)(ZuzzuNPC.GGFJGHHHEJC.animationBase as NPCAnimation).npcSprite).sortingOrder = 3;
				((Renderer)(ZuzzuNPC.GGFJGHHHEJC.animationBase as NPCAnimation).npcSprite).sortingLayerName = "Top";
				_003C_003E2__current = CommonReferences.wait1_5;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				KujakuNPC.GGFJGHHHEJC.animationBase.SetBool("WeaponEnd", EGFGNGJGBOP: false);
				KujakuNPC.GGFJGHHHEJC.animationBase.SetBool("BackPain", EGFGNGJGBOP: true);
				ZuzzuNPC.GGFJGHHHEJC.animationBase.SetBool("StaffEnd", EGFGNGJGBOP: false);
				ZuzzuNPC.GGFJGHHHEJC.animationBase.SetBool("Backache", EGFGNGJGBOP: true);
				_003C_003E2__current = CommonReferences.wait1_5;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				MusicController.instance.ModifiyVolumeOverTime(_003CoriginalVolume_003E5__2, 1f);
				instance.backPain.SetActive(false);
				((Component)KujakuNPC.GGFJGHHHEJC).transform.parent = null;
				((Component)ZuzzuNPC.GGFJGHHHEJC).transform.parent = null;
				KujakuNPC.GGFJGHHHEJC.animationBase.SetBool("BackPain", EGFGNGJGBOP: true);
				ZuzzuNPC.GGFJGHHHEJC.animationBase.SetBool("Backache", EGFGNGJGBOP: true);
				((Renderer)(KujakuNPC.GGFJGHHHEJC.animationBase as NPCAnimation).npcSprite).sortingLayerName = "OnFloor";
				((Renderer)(KujakuNPC.GGFJGHHHEJC.animationBase as NPCAnimation).npcSprite).sortingOrder = 0;
				((Renderer)(ZuzzuNPC.GGFJGHHHEJC.animationBase as NPCAnimation).npcSprite).sortingLayerName = "OnFloor";
				((Renderer)(ZuzzuNPC.GGFJGHHHEJC.animationBase as NPCAnimation).npcSprite).sortingOrder = 0;
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
	private sealed class NBOAFDJFLOM : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OldMansDuelEvent _003C_003E4__this;

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
		public NBOAFDJFLOM(int _003C_003E1__state)
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
			OldMansDuelEvent oldMansDuelEvent = _003C_003E4__this;
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
				oldMansDuelEvent.EndWeaponsAnim();
				_003C_003E2__current = CommonReferences.wait3;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				oldMansDuelEvent.BackPainAnim();
				_003C_003E2__current = CommonReferences.wait5;
				_003C_003E1__state = 3;
				return true;
			case 3:
				_003C_003E1__state = -1;
				instance.EDGDFPPKGDL = KujakuNPC.GGFJGHHHEJC;
				instance.MDFALJKHKED = "DueloDeViejos/MainEvent2";
				_003C_003E2__current = OnlineManager.WaitForAllPlayers();
				_003C_003E1__state = 4;
				return true;
			case 4:
				_003C_003E1__state = -1;
				if (instance.isActor)
				{
					KujakuNPC.GGFJGHHHEJC.StartConversation(1, "DueloDeViejos/MainEvent2");
				}
				else if (OnlineManager.PlayingOnline())
				{
					_003C_003E2__current = KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
					_003C_003E1__state = 5;
					return true;
				}
				break;
			case 5:
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

	[CompilerGenerated]
	private sealed class HMNLFFCGBPC : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OldMansDuelEvent _003C_003E4__this;

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
		public HMNLFFCGBPC(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_026e: Unknown result type (might be due to invalid IL or missing references)
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0157: Unknown result type (might be due to invalid IL or missing references)
			//IL_0186: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			OldMansDuelEvent oldMansDuelEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				DialogueLua.SetVariable("MainProgress", (object)14);
				DialogueCameraTarget.GetPlayer(1).ReturnControlToCameraTarget();
				if (GameManager.LocalCoop())
				{
					LocalCooperativeManager.RestoreCameraInLocalCoop();
				}
				MissionsManager.instance.StartMission(315, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
				MissionsManager.instance.StartMission(316, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
				Utils.DLIIAHACOJB(38);
				PlayerController.GetPlayer(1).gridController.disable = false;
				if (GameManager.LocalCoop())
				{
					PlayerController.GetPlayer(2).gridController.disable = false;
				}
				oldMansDuelEvent.sceneFinished = true;
				goto IL_00c5;
			case 1:
				_003C_003E1__state = -1;
				goto IL_00c5;
			case 2:
				{
					_003C_003E1__state = -1;
					if (OnlineManager.MasterOrOffline())
					{
						((Behaviour)KujakuNPC.GGFJGHHHEJC.routine).enabled = true;
						KujakuNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
						((Behaviour)ZuzzuNPC.GGFJGHHHEJC.routine).enabled = true;
						ZuzzuNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
					}
					ZuzzuNPC.GGFJGHHHEJC.content.SetActive(true);
					((Component)ZuzzuNPC.GGFJGHHHEJC).transform.position = instance.PMHJMCIODBO[1];
					ZuzzuNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Down);
					KujakuNPC.GGFJGHHHEJC.playerCanInteract = true;
					ZuzzuNPC.GGFJGHHHEJC.playerCanInteract = true;
					PrecisionEvent.instance.ActivateEvent();
					BalanceEvent.instance.ActivateEvent();
					return false;
				}
				IL_00c5:
				if (Utils.NGLLIJPOBEC(Location.Road))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
				((GameEvent)oldMansDuelEvent).EndEvent(BGKCHMNJBLJ: false);
				((Component)SceneReferences.instance.customerPool).gameObject.SetActive(true);
				for (int i = 0; i < oldMansDuelEvent.carriages.Length; i++)
				{
					instance.carriages[i].SetActive(false);
				}
				((Component)HikariNPC.GGFJGHHHEJC).transform.position = HikariNPC.GGFJGHHHEJC.beachPosition;
				HikariNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Down);
				HikariNPC.GGFJGHHHEJC.inScene = false;
				((Component)KentaNPC.GGFJGHHHEJC).transform.position = instance.PMHJMCIODBO[2];
				KentaNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Down);
				((Component)RinNPC.GGFJGHHHEJC).transform.position = instance.PMHJMCIODBO[3];
				RinNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Down);
				if (OnlineManager.MasterOrOffline())
				{
					((Behaviour)RinNPC.GGFJGHHHEJC.routine).enabled = true;
					RinNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
					((Behaviour)KentaNPC.GGFJGHHHEJC.routine).enabled = true;
					KentaNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
				}
				_003C_003E2__current = CommonReferences.wait10;
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

	[CompilerGenerated]
	private sealed class BPONOCMNNID : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OldMansDuelEvent _003C_003E4__this;

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
		public BPONOCMNNID(int _003C_003E1__state)
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
			OldMansDuelEvent oldMansDuelEvent = _003C_003E4__this;
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
				oldMansDuelEvent.RightMovement();
				_003C_003E2__current = CommonReferences.wait4;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				KujakuNPC.GGFJGHHHEJC.blockActionBar = false;
				instance.EDGDFPPKGDL = KujakuNPC.GGFJGHHHEJC;
				instance.MDFALJKHKED = "DueloDeViejos/MainEvent3";
				if (instance.isActor)
				{
					KujakuNPC.GGFJGHHHEJC.StartConversation(1, "DueloDeViejos/MainEvent3");
				}
				else if (OnlineManager.PlayingOnline())
				{
					_003C_003E2__current = KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
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

	[CompilerGenerated]
	private sealed class IDNLMLAFJHL : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OldMansDuelEvent _003C_003E4__this;

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
		public IDNLMLAFJHL(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			OldMansDuelEvent oldMansDuelEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				instance.EDGDFPPKGDL = null;
				DialogueCameraTarget.GetPlayer(1).cameraInEvent = true;
				DialogueCameraTarget.GetPlayer(1).MoveCameraToPositionFromCameraTarget(Vector2.op_Implicit(oldMansDuelEvent.cameraPosition.position));
				if (GameManager.LocalCoop())
				{
					LocalCooperativeManager.FocusCameraToPlayerInLocalCoop(1);
				}
				_003C_003E2__current = CommonReferences.wait3;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				_003C_003E2__current = OnlineManager.WaitForAllPlayers();
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				instance.EDGDFPPKGDL = KujakuNPC.GGFJGHHHEJC;
				instance.MDFALJKHKED = "DueloDeViejos/MainEvent";
				KujakuNPC.GGFJGHHHEJC.barkDialogue = false;
				KujakuNPC.GGFJGHHHEJC.inSpecialEvent = true;
				KujakuNPC.GGFJGHHHEJC.blockActionBar = true;
				if (instance.isActor)
				{
					KujakuNPC.GGFJGHHHEJC.StartConversation(1, "DueloDeViejos/MainEvent");
				}
				else if (OnlineManager.PlayingOnline())
				{
					_003C_003E2__current = KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
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

	[CompilerGenerated]
	private sealed class LOBFLFPPEFF : IEnumerator<object>, IEnumerator, IDisposable
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
		public LOBFLFPPEFF(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				OnlineManager.ResetAllPlayersPrepared();
				TravelZonesManager.GGFJGHHHEJC.GetTravelZone(PlayerController.GetPlayer(1).LEOIMFNKFGA, Location.Road).StartTravelZone(1);
				if (GameManager.LocalCoop())
				{
					TravelZonesManager.GGFJGHHHEJC.GetTravelZone(PlayerController.GetPlayer(2).LEOIMFNKFGA, Location.Road).StartTravelZone(2);
				}
				_003C_003E2__current = CommonReferences.wait01;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				PlayerInputs.EnableKeyboardInputsAndMovement(1, (MonoBehaviour)(object)instance);
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

	public static OldMansDuelEvent instance;

	public Transform[] characterPositions;

	public Transform[] movePositions;

	public GameObject[] carriages;

	public GameObject backPain;

	public AudioObject zuzzuLaugh;

	public AudioObject kujakuLaugh;

	public bool sceneFinished;

	private Vector3[] PMHJMCIODBO = (Vector3[])(object)new Vector3[4];

	private float IJLNHBOOFKL;

	private IEnumerator BCJJJBHLEAA()
	{
		return new IDNLMLAFJHL(1)
		{
			_003C_003E4__this = this
		};
	}

	public void HPCKEOMOEAH(int AAAIOBLCOFO)
	{
		Debug.Log((object)"add item ");
		TravelZone travelZone = TravelZonesManager.BGMJCCFNNDL().GetTravelZone(Location.Road, Location.Tavern);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(CGNFKCAMHLJ));
		if (OnlineManager.PlayingOnline())
		{
			TravelZone travelZone2 = TravelZonesManager.CFHEJAGKIII().KCJMDAPPJLB(Location.Tavern | Location.Road | Location.River, ~(Location.Tavern | Location.Road | Location.River | Location.Quarry | Location.Farm | Location.BarnInterior));
			travelZone2.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone2.OnTravelZoneTo, new Action<int>(NKHCJJPDBAC));
		}
		StartEvent(OnlineManager.PGAGDFAEEFB(), CDPAMNIPPEC: false);
	}

	private IEnumerator FOENAGENPKL()
	{
		return new BPONOCMNNID(1)
		{
			_003C_003E4__this = this
		};
	}

	public void DCKMOAHEPMM()
	{
		KujakuNPC.BADFKMEJOKE().animationBase.CGEADHOLHCH("[ChessPillar] Solución: Top={0} | Mid={1} | Bot={2}", EGFGNGJGBOP: true, HALNIEBONKH: true);
		KujakuNPC.GGFJGHHHEJC.animationBase.SetBool("itemSickle", EGFGNGJGBOP: false);
	}

	public void COJDNKHJEAA()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		instance.EDGDFPPKGDL = null;
		KujakuNPC.LANAINBEMCM().HEACFLIHBBI(Vector2.op_Implicit(movePositions[0].position), Direction.Right);
		ZuzzuNPC.DICHPHEOINO().LBCICHLHHJA(Vector2.op_Implicit(movePositions[0].position), (Direction)8, AMEOKNOLILB: true);
	}

	private IEnumerator JPIKPMFMNEB()
	{
		return new NBOAFDJFLOM(1)
		{
			_003C_003E4__this = this
		};
	}

	public void BCGOJIFKEFP()
	{
		instance.EndEvent(BFLCJPHHDJM: true);
	}

	public void CJIGMIHJHHF()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		KujakuNPC.EKDNJDJHONF().animationBase.SetDirection((Direction)6);
		ZuzzuNPC.EBAIHKJHCCA().animationBase.SetDirection(Direction.Up);
		KujakuNPC.LANAINBEMCM().animationBase.SetBool("ReceiveDereserveSpotAdoptionSignal", EGFGNGJGBOP: true);
		ZuzzuNPC.OPDKAPNDBJE().animationBase.SetBool("RochelleProgress", EGFGNGJGBOP: false, HALNIEBONKH: true);
		KujakuNPC.BADFKMEJOKE().Walk(Vector2.op_Implicit(movePositions[0].position), Direction.Up);
		ZuzzuNPC.ELGNEJNLBNO().LBCICHLHHJA(Vector2.op_Implicit(movePositions[1].position));
		((MonoBehaviour)instance).StartCoroutine(instance.FPJLOGEHKJL());
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendOldMansDuelEndLaughAndMove();
		}
	}

	private IEnumerator IBAPDKLGOCE()
	{
		return new JPEKGDEIACO(1);
	}

	public void LFEJNDFJJCJ()
	{
		instance.EndEvent(BFLCJPHHDJM: true);
	}

	public void CFGOJPAPIAF()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		KujakuNPC.DEGPIHEEFHJ().animationBase.SetDirection((Direction)5);
		ZuzzuNPC.DICHPHEOINO().animationBase.SetDirection(Direction.Diagonal);
		KujakuNPC.EKDNJDJHONF().animationBase.CGEADHOLHCH("Inventory full", EGFGNGJGBOP: true, HALNIEBONKH: true);
		ZuzzuNPC.OPDKAPNDBJE().animationBase.SetBool("Items/item_name_1118", EGFGNGJGBOP: false, HALNIEBONKH: true);
		KujakuNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePositions[1].position), Direction.Up);
		ZuzzuNPC.JFNOOMJMHCB().OFABJMDGBDM(Vector2.op_Implicit(movePositions[1].position), (Direction)6, AMEOKNOLILB: true);
		((MonoBehaviour)instance).StartCoroutine(instance.JKLMNMGLCHC());
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineEventsManager.SendOldMansDuelEndLaughAndMove();
		}
	}

	private IEnumerator NMGKALMGBGE()
	{
		return new HMNLFFCGBPC(1)
		{
			_003C_003E4__this = this
		};
	}

	public void DFNLJOJCBBJ()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		instance.EDGDFPPKGDL = null;
		KujakuNPC.EKDNJDJHONF().MLACFFDPKPA(Vector2.op_Implicit(movePositions[6].position), Direction.Right, AMEOKNOLILB: true);
		ZuzzuNPC.OAPOJCODNCO().LAMKDPEEFIN(Vector2.op_Implicit(movePositions[6].position), Direction.Up, AMEOKNOLILB: true);
	}

	public void EOEKOOCMNMC()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.PDICLNNNPEB());
	}

	private IEnumerator MFACAJDJGGJ()
	{
		return new BPONOCMNNID(1)
		{
			_003C_003E4__this = this
		};
	}

	public void PNGFLHHMBLN()
	{
		instance.EDGDFPPKGDL = null;
		KujakuNPC.BADFKMEJOKE().animationBase.CGEADHOLHCH("Direction", EGFGNGJGBOP: true);
		KujakuNPC.BADFKMEJOKE().animationBase.SetBool("xForXP", EGFGNGJGBOP: true);
		ZuzzuNPC.KNLLFEJAMNN().animationBase.CGEADHOLHCH("+connect_lobby", EGFGNGJGBOP: true);
		ZuzzuNPC.OPDKAPNDBJE().animationBase.CGEADHOLHCH("Items/item_name_666", EGFGNGJGBOP: true);
	}

	private void GCMEJEJKGDN()
	{
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			KujakuNPC.BADFKMEJOKE().routine.noDisableOnReset = false;
			ZuzzuNPC.FJAMHCAAEAM().routine.noDisableOnReset = true;
			KentaNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
			RinNPC.BNBMNOMFFBE().routine.noDisableOnReset = false;
			((Behaviour)KujakuNPC.MAAAKALBBEE().routine).enabled = true;
			((Behaviour)ZuzzuNPC.FJAMHCAAEAM().routine).enabled = false;
			((Behaviour)KentaNPC.GGFJGHHHEJC.routine).enabled = false;
			((Behaviour)RinNPC.AFFGPMFKEFH().routine).enabled = true;
		}
		KujakuNPC.MAAAKALBBEE().content.SetActive(false);
		HikariNPC.MNFMOEKMJKN().content.SetActive(true);
		ZuzzuNPC.LFPEPJBNCBF().content.SetActive(false);
		KentaNPC.GGFJGHHHEJC.content.SetActive(true);
		RinNPC.POAGAIBEFBF().content.SetActive(false);
		((Component)KujakuNPC.LANAINBEMCM()).transform.position = characterPositions[1].position;
		KujakuNPC.BADFKMEJOKE().animationBase.SetBool("Player/Bark/Fishing/NoBait", EGFGNGJGBOP: true, HALNIEBONKH: true);
		KujakuNPC.BADFKMEJOKE().animationBase.LookDirection((Direction)6);
		PMHJMCIODBO[0] = ((Component)HikariNPC.EKDNJDJHONF()).transform.position;
		HikariNPC.MNFMOEKMJKN().inScene = true;
		((Component)HikariNPC.ABDJJBFNLBJ()).transform.position = characterPositions[1].position;
		HikariNPC.ABDJJBFNLBJ().animationBase.SetBool("sprint", EGFGNGJGBOP: false, HALNIEBONKH: true);
		HikariNPC.ABDJJBFNLBJ().animationBase.LookDirection((Direction)7);
		PMHJMCIODBO[0] = ((Component)ZuzzuNPC.DFJGHOHPPEL()).transform.position;
		((Component)ZuzzuNPC.ELGNEJNLBNO()).transform.position = characterPositions[3].position;
		ZuzzuNPC.CHKMFEFOFKJ().animationBase.CGEADHOLHCH("Rowdy", EGFGNGJGBOP: true, HALNIEBONKH: true);
		ZuzzuNPC.ELGNEJNLBNO().animationBase.LookDirection(Direction.Right);
		PMHJMCIODBO[8] = ((Component)KentaNPC.GGFJGHHHEJC).transform.position;
		((Component)KentaNPC.GGFJGHHHEJC).transform.position = characterPositions[4].position;
		KentaNPC.GGFJGHHHEJC.animationBase.CGEADHOLHCH("Player/Bark/Tutorial/CrafterBlock", EGFGNGJGBOP: false, HALNIEBONKH: true);
		KentaNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Diagonal);
		instance.PMHJMCIODBO[1] = ((Component)RinNPC.ABHIDHPMLLD()).transform.position;
		((Component)RinNPC.OJJDNLEFNPJ()).transform.position = characterPositions[7].position;
		RinNPC.GGFJGHHHEJC.animationBase.SetBool(") recipes locked", EGFGNGJGBOP: false, HALNIEBONKH: true);
		RinNPC.KNLLFEJAMNN().animationBase.LookDirection((Direction)7);
	}

	private void FCECOJEODKF(bool BGKCHMNJBLJ)
	{
		base.EndEvent(BGKCHMNJBLJ);
	}

	public void JNOJOCPGJFC(int AAAIOBLCOFO)
	{
		Debug.Log((object)"Received Request begin minigame");
		TravelZone travelZone = TravelZonesManager.GFMBEDCANNI().IMKJEBFOBKK(Location.Road | Location.River, Location.Tavern);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(LEMALDJGOKB));
		if (OnlineManager.PlayingOnline())
		{
			TravelZone travelZone2 = TravelZonesManager.DGCNCEDIFOF().NKEBECDKDOO(Location.Tavern, Location.Tavern | Location.Camp | Location.FarmShop);
			travelZone2.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone2.OnTravelZoneTo, new Action<int>(JNOJOCPGJFC));
		}
		StartEvent(OnlineManager.PGAGDFAEEFB(), CDPAMNIPPEC: true);
	}

	public void OLPJMIOOHCP()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		KujakuNPC.GGFJGHHHEJC.animationBase.SetBool("", EGFGNGJGBOP: true);
		KujakuNPC.BADFKMEJOKE().animationBase.SetBool(", ", EGFGNGJGBOP: false, HALNIEBONKH: true);
		ZuzzuNPC.CHPEMJMLDCN().animationBase.SetBool("<color=#BF0000>", EGFGNGJGBOP: false, HALNIEBONKH: true);
		ZuzzuNPC.KNLLFEJAMNN().animationBase.CGEADHOLHCH("Tail", EGFGNGJGBOP: false, HALNIEBONKH: true);
		MultiAudioManager.PlayAudioObject(instance.kujakuLaugh, ((Component)KujakuNPC.EKDNJDJHONF()).transform.position);
		MultiAudioManager.PlayAudioObject(instance.zuzzuLaugh, ((Component)ZuzzuNPC.DICHPHEOINO()).transform.position);
		instance.IJLNHBOOFKL = 1659f;
		PsaiCore.Instance.HoldCurrentIntensity(hold: true);
		PsaiCore.Instance.AddToCurrentIntensity(137f);
		PsaiCore.Instance.HoldCurrentIntensity(hold: false);
	}

	public void HLIJDHICODH()
	{
		instance.EDGDFPPKGDL = null;
		KujakuNPC.EKDNJDJHONF().animationBase.CGEADHOLHCH("─── Fragmento {0}/{1} ───\n{2}", EGFGNGJGBOP: false, HALNIEBONKH: true);
		KujakuNPC.BADFKMEJOKE().animationBase.CGEADHOLHCH("[PipeConnectionPuzzleUI] BuildGrid llamado sin PipePuzzleData.", EGFGNGJGBOP: true, HALNIEBONKH: true);
		ZuzzuNPC.LFPEPJBNCBF().animationBase.CGEADHOLHCH("Community_Translation", EGFGNGJGBOP: false, HALNIEBONKH: true);
		ZuzzuNPC.JFJOKGAOPHA().animationBase.SetBool("Dialogue System/Conversation/EnterTavernNeutral/Entry/2/Dialogue Text", EGFGNGJGBOP: true, HALNIEBONKH: true);
	}

	private IEnumerator ABFPNIJDFJL()
	{
		instance.EDGDFPPKGDL = null;
		DialogueCameraTarget.GetPlayer(1).cameraInEvent = true;
		DialogueCameraTarget.GetPlayer(1).MoveCameraToPositionFromCameraTarget(Vector2.op_Implicit(cameraPosition.position));
		if (GameManager.LocalCoop())
		{
			LocalCooperativeManager.FocusCameraToPlayerInLocalCoop(1);
		}
		yield return CommonReferences.wait3;
		yield return OnlineManager.WaitForAllPlayers();
		instance.EDGDFPPKGDL = KujakuNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "DueloDeViejos/MainEvent";
		KujakuNPC.GGFJGHHHEJC.barkDialogue = false;
		KujakuNPC.GGFJGHHHEJC.inSpecialEvent = true;
		KujakuNPC.GGFJGHHHEJC.blockActionBar = true;
		if (instance.isActor)
		{
			KujakuNPC.GGFJGHHHEJC.StartConversation(1, "DueloDeViejos/MainEvent");
		}
		else if (OnlineManager.PlayingOnline())
		{
			yield return KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private IEnumerator EEEOMMMJKFP()
	{
		yield return CommonReferences.wait2;
		EndWeaponsAnim();
		yield return CommonReferences.wait3;
		BackPainAnim();
		yield return CommonReferences.wait5;
		instance.EDGDFPPKGDL = KujakuNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "DueloDeViejos/MainEvent2";
		yield return OnlineManager.WaitForAllPlayers();
		if (instance.isActor)
		{
			KujakuNPC.GGFJGHHHEJC.StartConversation(1, "DueloDeViejos/MainEvent2");
		}
		else if (OnlineManager.PlayingOnline())
		{
			yield return KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	public void BackPainAnim()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.JDPOPLKELFI());
	}

	public void HFLPKANKDOH()
	{
		ZuzzuNPC.OAPOJCODNCO().animationBase.CGEADHOLHCH("Get Components ", EGFGNGJGBOP: false, HALNIEBONKH: true);
		ZuzzuNPC.OAPOJCODNCO().animationBase.CGEADHOLHCH("No travel zone found for mine stairs destination ", EGFGNGJGBOP: false);
		((MonoBehaviour)instance).StartCoroutine(instance.JPIKPMFMNEB());
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineEventsManager.SendOldMansDuelZuzzuWeaponAnimation();
		}
	}

	private IEnumerator KIIJMOMEJNN()
	{
		yield return CommonReferences.wait2;
		EndWeaponsAnim();
		yield return CommonReferences.wait3;
		BackPainAnim();
		yield return CommonReferences.wait5;
		instance.EDGDFPPKGDL = KujakuNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "DueloDeViejos/MainEvent2";
		yield return OnlineManager.WaitForAllPlayers();
		if (instance.isActor)
		{
			KujakuNPC.GGFJGHHHEJC.StartConversation(1, "DueloDeViejos/MainEvent2");
		}
		else if (OnlineManager.PlayingOnline())
		{
			yield return KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private IEnumerator JDPOPLKELFI()
	{
		instance.EDGDFPPKGDL = null;
		float originalVolume = PsaiCore.Instance.GetVolume();
		MusicController.instance.ModifiyVolumeOverTime(0f, 0.3f);
		instance.backPain.SetActive(true);
		((Component)KujakuNPC.GGFJGHHHEJC).transform.parent = instance.backPain.transform;
		((Renderer)(KujakuNPC.GGFJGHHHEJC.animationBase as NPCAnimation).npcSprite).sortingOrder = 3;
		((Renderer)(KujakuNPC.GGFJGHHHEJC.animationBase as NPCAnimation).npcSprite).sortingLayerName = "Top";
		((Component)ZuzzuNPC.GGFJGHHHEJC).transform.parent = instance.backPain.transform;
		((Renderer)(ZuzzuNPC.GGFJGHHHEJC.animationBase as NPCAnimation).npcSprite).sortingOrder = 3;
		((Renderer)(ZuzzuNPC.GGFJGHHHEJC.animationBase as NPCAnimation).npcSprite).sortingLayerName = "Top";
		yield return CommonReferences.wait1_5;
		KujakuNPC.GGFJGHHHEJC.animationBase.SetBool("WeaponEnd", EGFGNGJGBOP: false);
		KujakuNPC.GGFJGHHHEJC.animationBase.SetBool("BackPain", EGFGNGJGBOP: true);
		ZuzzuNPC.GGFJGHHHEJC.animationBase.SetBool("StaffEnd", EGFGNGJGBOP: false);
		ZuzzuNPC.GGFJGHHHEJC.animationBase.SetBool("Backache", EGFGNGJGBOP: true);
		yield return CommonReferences.wait1_5;
		MusicController.instance.ModifiyVolumeOverTime(originalVolume, 1f);
		instance.backPain.SetActive(false);
		((Component)KujakuNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)ZuzzuNPC.GGFJGHHHEJC).transform.parent = null;
		KujakuNPC.GGFJGHHHEJC.animationBase.SetBool("BackPain", EGFGNGJGBOP: true);
		ZuzzuNPC.GGFJGHHHEJC.animationBase.SetBool("Backache", EGFGNGJGBOP: true);
		((Renderer)(KujakuNPC.GGFJGHHHEJC.animationBase as NPCAnimation).npcSprite).sortingLayerName = "OnFloor";
		((Renderer)(KujakuNPC.GGFJGHHHEJC.animationBase as NPCAnimation).npcSprite).sortingOrder = 0;
		((Renderer)(ZuzzuNPC.GGFJGHHHEJC.animationBase as NPCAnimation).npcSprite).sortingLayerName = "OnFloor";
		((Renderer)(ZuzzuNPC.GGFJGHHHEJC.animationBase as NPCAnimation).npcSprite).sortingOrder = 0;
	}

	public void ZuzzuWeaponAnim()
	{
		ZuzzuNPC.GGFJGHHHEJC.animationBase.SetBool("Angry", EGFGNGJGBOP: false);
		ZuzzuNPC.GGFJGHHHEJC.animationBase.SetBool("Staff", EGFGNGJGBOP: true);
		((MonoBehaviour)instance).StartCoroutine(instance.NJKPLOLIINO());
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendOldMansDuelZuzzuWeaponAnimation();
		}
	}

	protected override void Awake()
	{
		base.Awake();
		instance = this;
	}

	public void BOLMGOHNBBH()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.JDPOPLKELFI());
	}

	public void BAJKFHAPODC()
	{
		instance.EndEvent(BFLCJPHHDJM: true);
	}

	public void LaughAnim()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		KujakuNPC.GGFJGHHHEJC.animationBase.SetBool("BackPain", EGFGNGJGBOP: false);
		KujakuNPC.GGFJGHHHEJC.animationBase.SetBool("Laugh", EGFGNGJGBOP: true);
		ZuzzuNPC.GGFJGHHHEJC.animationBase.SetBool("Backache", EGFGNGJGBOP: false);
		ZuzzuNPC.GGFJGHHHEJC.animationBase.SetBool("Laugh", EGFGNGJGBOP: true);
		MultiAudioManager.PlayAudioObject(instance.kujakuLaugh, ((Component)KujakuNPC.GGFJGHHHEJC).transform.position);
		MultiAudioManager.PlayAudioObject(instance.zuzzuLaugh, ((Component)ZuzzuNPC.GGFJGHHHEJC).transform.position);
		instance.IJLNHBOOFKL = 0.9f;
		PsaiCore.Instance.HoldCurrentIntensity(hold: false);
		PsaiCore.Instance.AddToCurrentIntensity(0.6f);
		PsaiCore.Instance.HoldCurrentIntensity(hold: true);
	}

	private IEnumerator CBFICMLOANI()
	{
		yield return CommonReferences.wait2;
		EndWeaponsAnim();
		yield return CommonReferences.wait3;
		BackPainAnim();
		yield return CommonReferences.wait5;
		instance.EDGDFPPKGDL = KujakuNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "DueloDeViejos/MainEvent2";
		yield return OnlineManager.WaitForAllPlayers();
		if (instance.isActor)
		{
			KujakuNPC.GGFJGHHHEJC.StartConversation(1, "DueloDeViejos/MainEvent2");
		}
		else if (OnlineManager.PlayingOnline())
		{
			yield return KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	public void HGHHMDIMIOB(int AAAIOBLCOFO)
	{
		Debug.Log((object)"Attack/MainEvent 11");
		TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.IMKJEBFOBKK(Location.Road | Location.River, Location.Tavern);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(CGNFKCAMHLJ));
		if (OnlineManager.PlayingOnline())
		{
			TravelZone travelZone2 = TravelZonesManager.GFMBEDCANNI().OFIPCMMKFLP(Location.Tavern | Location.Road | Location.River, ~(Location.Tavern | Location.Road | Location.River | Location.Quarry));
			travelZone2.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone2.OnTravelZoneTo, new Action<int>(LEMALDJGOKB));
		}
		StartEvent(OnlineManager.MasterOrOffline(), CDPAMNIPPEC: true);
	}

	public static void JLMMAMNAICF()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.JGPDBNJEJEA());
	}

	public void PCIKIJAHOLI()
	{
		ZuzzuNPC.KNLLFEJAMNN().animationBase.CGEADHOLHCH("/", EGFGNGJGBOP: true, HALNIEBONKH: true);
		ZuzzuNPC.OPDKAPNDBJE().animationBase.SetBool("F2", EGFGNGJGBOP: true, HALNIEBONKH: true);
		((MonoBehaviour)instance).StartCoroutine(instance.JPIKPMFMNEB());
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendOldMansDuelZuzzuWeaponAnimation();
		}
	}

	private IEnumerator LCKPJBFEBKL()
	{
		return new HMNLFFCGBPC(1)
		{
			_003C_003E4__this = this
		};
	}

	public void IMDMOLAJKNO()
	{
		KujakuNPC.EKDNJDJHONF().animationBase.SetBool(" - <b><color=#8C78BA>", EGFGNGJGBOP: false, HALNIEBONKH: true);
		KujakuNPC.EKDNJDJHONF().animationBase.CGEADHOLHCH("Bomb", EGFGNGJGBOP: true);
	}

	private IEnumerator BBJHMKFJLOK()
	{
		return new JPEKGDEIACO(1);
	}

	public void CGNFKCAMHLJ(int AAAIOBLCOFO)
	{
		Debug.Log((object)"Serve");
		TravelZone travelZone = TravelZonesManager.OLHBLKIAFOM().ECFDFECLDFK(Location.River, Location.Tavern);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(NKLCDJEDFIJ));
		if (OnlineManager.PlayingOnline())
		{
			TravelZone travelZone2 = TravelZonesManager.LKOABOAADCD().ECFDFECLDFK(Location.Camp, ~(Location.Tavern | Location.Road | Location.River | Location.BarnInterior | Location.FarmShop));
			travelZone2.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone2.OnTravelZoneTo, new Action<int>(OnTravelZoneTo));
		}
		StartEvent(OnlineManager.PGAGDFAEEFB(), CDPAMNIPPEC: false);
	}

	public void FKCNOCBJLGF()
	{
		instance.EndEvent(BFLCJPHHDJM: true);
	}

	public void CLHMDLEAHLP()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		KujakuNPC.DEGPIHEEFHJ().animationBase.SetDirection((Direction)6);
		ZuzzuNPC.FJAMHCAAEAM().animationBase.SetDirection(Direction.Up);
		KujakuNPC.EKDNJDJHONF().animationBase.SetBool("", EGFGNGJGBOP: true, HALNIEBONKH: true);
		ZuzzuNPC.LFPEPJBNCBF().animationBase.SetBool("ReciveResetDialogueULiaRhia", EGFGNGJGBOP: true);
		KujakuNPC.EKDNJDJHONF().Walk(Vector2.op_Implicit(movePositions[0].position), (Direction)8, AMEOKNOLILB: true);
		ZuzzuNPC.OAPOJCODNCO().FAOEMFNEMGL(Vector2.op_Implicit(movePositions[0].position), Direction.Right);
		((MonoBehaviour)instance).StartCoroutine(instance.ALFLEDFMOIG());
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineEventsManager.SendOldMansDuelEndLaughAndMove();
		}
	}

	private void MGFOOMMBFEB(bool BGKCHMNJBLJ)
	{
		base.EndEvent(BGKCHMNJBLJ);
	}

	public void EndScene()
	{
		instance.EndEvent(BFLCJPHHDJM: true);
	}

	private IEnumerator LDFIHCIILIK()
	{
		instance.EDGDFPPKGDL = null;
		float originalVolume = PsaiCore.Instance.GetVolume();
		MusicController.instance.ModifiyVolumeOverTime(0f, 0.3f);
		instance.backPain.SetActive(true);
		((Component)KujakuNPC.GGFJGHHHEJC).transform.parent = instance.backPain.transform;
		((Renderer)(KujakuNPC.GGFJGHHHEJC.animationBase as NPCAnimation).npcSprite).sortingOrder = 3;
		((Renderer)(KujakuNPC.GGFJGHHHEJC.animationBase as NPCAnimation).npcSprite).sortingLayerName = "Top";
		((Component)ZuzzuNPC.GGFJGHHHEJC).transform.parent = instance.backPain.transform;
		((Renderer)(ZuzzuNPC.GGFJGHHHEJC.animationBase as NPCAnimation).npcSprite).sortingOrder = 3;
		((Renderer)(ZuzzuNPC.GGFJGHHHEJC.animationBase as NPCAnimation).npcSprite).sortingLayerName = "Top";
		yield return CommonReferences.wait1_5;
		KujakuNPC.GGFJGHHHEJC.animationBase.SetBool("WeaponEnd", EGFGNGJGBOP: false);
		KujakuNPC.GGFJGHHHEJC.animationBase.SetBool("BackPain", EGFGNGJGBOP: true);
		ZuzzuNPC.GGFJGHHHEJC.animationBase.SetBool("StaffEnd", EGFGNGJGBOP: false);
		ZuzzuNPC.GGFJGHHHEJC.animationBase.SetBool("Backache", EGFGNGJGBOP: true);
		yield return CommonReferences.wait1_5;
		MusicController.instance.ModifiyVolumeOverTime(originalVolume, 1f);
		instance.backPain.SetActive(false);
		((Component)KujakuNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)ZuzzuNPC.GGFJGHHHEJC).transform.parent = null;
		KujakuNPC.GGFJGHHHEJC.animationBase.SetBool("BackPain", EGFGNGJGBOP: true);
		ZuzzuNPC.GGFJGHHHEJC.animationBase.SetBool("Backache", EGFGNGJGBOP: true);
		((Renderer)(KujakuNPC.GGFJGHHHEJC.animationBase as NPCAnimation).npcSprite).sortingLayerName = "OnFloor";
		((Renderer)(KujakuNPC.GGFJGHHHEJC.animationBase as NPCAnimation).npcSprite).sortingOrder = 0;
		((Renderer)(ZuzzuNPC.GGFJGHHHEJC.animationBase as NPCAnimation).npcSprite).sortingLayerName = "OnFloor";
		((Renderer)(ZuzzuNPC.GGFJGHHHEJC.animationBase as NPCAnimation).npcSprite).sortingOrder = 0;
	}

	public void JBCAAIIDHPC()
	{
		KujakuNPC.LANAINBEMCM().animationBase.SetBool("Prices", EGFGNGJGBOP: true);
		KujakuNPC.LANAINBEMCM().animationBase.CGEADHOLHCH("D-Pad Right", EGFGNGJGBOP: true, HALNIEBONKH: true);
	}

	public void DFKAMLAMNIA()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		KujakuNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		ZuzzuNPC.ELGNEJNLBNO().animationBase.SetDirection(Direction.Up);
		KujakuNPC.LANAINBEMCM().animationBase.SetBool("NoEresDigno/EndEvent", EGFGNGJGBOP: true);
		ZuzzuNPC.FJAMHCAAEAM().animationBase.CGEADHOLHCH("", EGFGNGJGBOP: true);
		KujakuNPC.BADFKMEJOKE().POCIILOJOJD(Vector2.op_Implicit(movePositions[1].position), (Direction)7);
		ZuzzuNPC.EBAIHKJHCCA().POCIILOJOJD(Vector2.op_Implicit(movePositions[0].position), Direction.Up, AMEOKNOLILB: true);
		((MonoBehaviour)instance).StartCoroutine(instance.AALIOJAFPAM());
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendOldMansDuelEndLaughAndMove();
		}
	}

	private IEnumerator ADOCICAGMMO()
	{
		return new IDNLMLAFJHL(1)
		{
			_003C_003E4__this = this
		};
	}

	public void HCCBDNGOGPF()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		KujakuNPC.BADFKMEJOKE().animationBase.SetDirection((Direction)8);
		ZuzzuNPC.DICHPHEOINO().animationBase.SetDirection(Direction.Down);
		KujakuNPC.GGFJGHHHEJC.animationBase.SetBool("BackWall", EGFGNGJGBOP: false);
		ZuzzuNPC.LFPEPJBNCBF().animationBase.CGEADHOLHCH("itemThymeSeeds", EGFGNGJGBOP: true);
		KujakuNPC.GGFJGHHHEJC.MLACFFDPKPA(Vector2.op_Implicit(movePositions[1].position), Direction.Right, AMEOKNOLILB: true);
		ZuzzuNPC.CHPEMJMLDCN().OFABJMDGBDM(Vector2.op_Implicit(movePositions[0].position), (Direction)8, AMEOKNOLILB: true);
		((MonoBehaviour)instance).StartCoroutine(instance.AALIOJAFPAM());
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineEventsManager.SendOldMansDuelEndLaughAndMove();
		}
	}

	private IEnumerator JNLBJMHGMBP()
	{
		return new NBOAFDJFLOM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator BGNCHMPEIEL()
	{
		return new NBOAFDJFLOM(1)
		{
			_003C_003E4__this = this
		};
	}

	public void GGANAJHNNFA()
	{
		instance.EDGDFPPKGDL = null;
		KujakuNPC.NEFIEJALANL().animationBase.SetBool("MinimisePopUp", EGFGNGJGBOP: true, HALNIEBONKH: true);
		KujakuNPC.DEGPIHEEFHJ().animationBase.SetBool("ServedCustomers", EGFGNGJGBOP: true, HALNIEBONKH: true);
		ZuzzuNPC.CHKMFEFOFKJ().animationBase.SetBool("Key Altar puzzle: assigned ", EGFGNGJGBOP: false);
		ZuzzuNPC.DFJGHOHPPEL().animationBase.CGEADHOLHCH("Game", EGFGNGJGBOP: false);
	}

	private IEnumerator OABJEFIOIGF()
	{
		instance.EDGDFPPKGDL = null;
		DialogueCameraTarget.GetPlayer(1).cameraInEvent = true;
		DialogueCameraTarget.GetPlayer(1).MoveCameraToPositionFromCameraTarget(Vector2.op_Implicit(cameraPosition.position));
		if (GameManager.LocalCoop())
		{
			LocalCooperativeManager.FocusCameraToPlayerInLocalCoop(1);
		}
		yield return CommonReferences.wait3;
		yield return OnlineManager.WaitForAllPlayers();
		instance.EDGDFPPKGDL = KujakuNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "DueloDeViejos/MainEvent";
		KujakuNPC.GGFJGHHHEJC.barkDialogue = false;
		KujakuNPC.GGFJGHHHEJC.inSpecialEvent = true;
		KujakuNPC.GGFJGHHHEJC.blockActionBar = true;
		if (instance.isActor)
		{
			KujakuNPC.GGFJGHHHEJC.StartConversation(1, "DueloDeViejos/MainEvent");
		}
		else if (OnlineManager.PlayingOnline())
		{
			yield return KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private IEnumerator ALFLEDFMOIG()
	{
		return new BPONOCMNNID(1)
		{
			_003C_003E4__this = this
		};
	}

	private void KFGKGNGDNHB()
	{
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			KujakuNPC.EKDNJDJHONF().routine.noDisableOnReset = true;
			ZuzzuNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
			KentaNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
			RinNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
			((Behaviour)KujakuNPC.LANAINBEMCM().routine).enabled = true;
			((Behaviour)ZuzzuNPC.CHPEMJMLDCN().routine).enabled = false;
			((Behaviour)KentaNPC.GGFJGHHHEJC.routine).enabled = false;
			((Behaviour)RinNPC.ABHIDHPMLLD().routine).enabled = true;
		}
		KujakuNPC.EKDNJDJHONF().content.SetActive(true);
		HikariNPC.MNFMOEKMJKN().content.SetActive(true);
		ZuzzuNPC.FJAMHCAAEAM().content.SetActive(true);
		KentaNPC.GGFJGHHHEJC.content.SetActive(true);
		RinNPC.BNBMNOMFFBE().content.SetActive(false);
		((Component)KujakuNPC.GGFJGHHHEJC).transform.position = characterPositions[1].position;
		KujakuNPC.DEGPIHEEFHJ().animationBase.CGEADHOLHCH("Trying to get friend ", EGFGNGJGBOP: false);
		KujakuNPC.EKDNJDJHONF().animationBase.LookDirection((Direction)7);
		PMHJMCIODBO[0] = ((Component)HikariNPC.EKDNJDJHONF()).transform.position;
		HikariNPC.OFLELHKKNKC().inScene = false;
		((Component)HikariNPC.OFLELHKKNKC()).transform.position = characterPositions[0].position;
		HikariNPC.EKDNJDJHONF().animationBase.SetBool("", EGFGNGJGBOP: false);
		HikariNPC.ABDJJBFNLBJ().animationBase.LookDirection(Direction.Up);
		PMHJMCIODBO[0] = ((Component)ZuzzuNPC.CHKMFEFOFKJ()).transform.position;
		((Component)ZuzzuNPC.JFNOOMJMHCB()).transform.position = characterPositions[0].position;
		ZuzzuNPC.DCAEBALADIM().animationBase.CGEADHOLHCH("Cancel", EGFGNGJGBOP: true, HALNIEBONKH: true);
		ZuzzuNPC.EBAIHKJHCCA().animationBase.LookDirection(Direction.Diagonal);
		PMHJMCIODBO[7] = ((Component)KentaNPC.GGFJGHHHEJC).transform.position;
		((Component)KentaNPC.GGFJGHHHEJC).transform.position = characterPositions[1].position;
		KentaNPC.GGFJGHHHEJC.animationBase.SetBool("NetworkSync ", EGFGNGJGBOP: false, HALNIEBONKH: true);
		KentaNPC.GGFJGHHHEJC.animationBase.LookDirection((Direction)5);
		instance.PMHJMCIODBO[2] = ((Component)RinNPC.OPILDPFDFKJ()).transform.position;
		((Component)RinNPC.AFFGPMFKEFH()).transform.position = characterPositions[7].position;
		RinNPC.AFFGPMFKEFH().animationBase.CGEADHOLHCH("BirdInteract", EGFGNGJGBOP: true, HALNIEBONKH: true);
		RinNPC.ABHIDHPMLLD().animationBase.LookDirection(Direction.Diagonal);
	}

	public static void KADCPECKOGB()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.FCNPLLFADOD());
	}

	private IEnumerator NJKPLOLIINO()
	{
		yield return CommonReferences.wait2;
		EndWeaponsAnim();
		yield return CommonReferences.wait3;
		BackPainAnim();
		yield return CommonReferences.wait5;
		instance.EDGDFPPKGDL = KujakuNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "DueloDeViejos/MainEvent2";
		yield return OnlineManager.WaitForAllPlayers();
		if (instance.isActor)
		{
			KujakuNPC.GGFJGHHHEJC.StartConversation(1, "DueloDeViejos/MainEvent2");
		}
		else if (OnlineManager.PlayingOnline())
		{
			yield return KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private IEnumerator LCHCKJFMKIF()
	{
		instance.EDGDFPPKGDL = null;
		float originalVolume = PsaiCore.Instance.GetVolume();
		MusicController.instance.ModifiyVolumeOverTime(0f, 0.3f);
		instance.backPain.SetActive(true);
		((Component)KujakuNPC.GGFJGHHHEJC).transform.parent = instance.backPain.transform;
		((Renderer)(KujakuNPC.GGFJGHHHEJC.animationBase as NPCAnimation).npcSprite).sortingOrder = 3;
		((Renderer)(KujakuNPC.GGFJGHHHEJC.animationBase as NPCAnimation).npcSprite).sortingLayerName = "Top";
		((Component)ZuzzuNPC.GGFJGHHHEJC).transform.parent = instance.backPain.transform;
		((Renderer)(ZuzzuNPC.GGFJGHHHEJC.animationBase as NPCAnimation).npcSprite).sortingOrder = 3;
		((Renderer)(ZuzzuNPC.GGFJGHHHEJC.animationBase as NPCAnimation).npcSprite).sortingLayerName = "Top";
		yield return CommonReferences.wait1_5;
		KujakuNPC.GGFJGHHHEJC.animationBase.SetBool("WeaponEnd", EGFGNGJGBOP: false);
		KujakuNPC.GGFJGHHHEJC.animationBase.SetBool("BackPain", EGFGNGJGBOP: true);
		ZuzzuNPC.GGFJGHHHEJC.animationBase.SetBool("StaffEnd", EGFGNGJGBOP: false);
		ZuzzuNPC.GGFJGHHHEJC.animationBase.SetBool("Backache", EGFGNGJGBOP: true);
		yield return CommonReferences.wait1_5;
		MusicController.instance.ModifiyVolumeOverTime(originalVolume, 1f);
		instance.backPain.SetActive(false);
		((Component)KujakuNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)ZuzzuNPC.GGFJGHHHEJC).transform.parent = null;
		KujakuNPC.GGFJGHHHEJC.animationBase.SetBool("BackPain", EGFGNGJGBOP: true);
		ZuzzuNPC.GGFJGHHHEJC.animationBase.SetBool("Backache", EGFGNGJGBOP: true);
		((Renderer)(KujakuNPC.GGFJGHHHEJC.animationBase as NPCAnimation).npcSprite).sortingLayerName = "OnFloor";
		((Renderer)(KujakuNPC.GGFJGHHHEJC.animationBase as NPCAnimation).npcSprite).sortingOrder = 0;
		((Renderer)(ZuzzuNPC.GGFJGHHHEJC.animationBase as NPCAnimation).npcSprite).sortingLayerName = "OnFloor";
		((Renderer)(ZuzzuNPC.GGFJGHHHEJC.animationBase as NPCAnimation).npcSprite).sortingOrder = 0;
	}

	private IEnumerator HPKLJPOBLPK()
	{
		return new HMNLFFCGBPC(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator ICINMEGAKNK()
	{
		DialogueLua.SetVariable("MainProgress", (object)14);
		DialogueCameraTarget.GetPlayer(1).ReturnControlToCameraTarget();
		if (GameManager.LocalCoop())
		{
			LocalCooperativeManager.RestoreCameraInLocalCoop();
		}
		MissionsManager.instance.StartMission(315, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		MissionsManager.instance.StartMission(316, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		Utils.DLIIAHACOJB(38);
		PlayerController.GetPlayer(1).gridController.disable = false;
		if (GameManager.LocalCoop())
		{
			PlayerController.GetPlayer(2).gridController.disable = false;
		}
		sceneFinished = true;
		while (Utils.NGLLIJPOBEC(Location.Road))
		{
			yield return null;
		}
		base.EndEvent(BGKCHMNJBLJ: false);
		((Component)SceneReferences.instance.customerPool).gameObject.SetActive(true);
		for (int i = 0; i < carriages.Length; i++)
		{
			instance.carriages[i].SetActive(false);
		}
		((Component)HikariNPC.GGFJGHHHEJC).transform.position = HikariNPC.GGFJGHHHEJC.beachPosition;
		HikariNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Down);
		HikariNPC.GGFJGHHHEJC.inScene = false;
		((Component)KentaNPC.GGFJGHHHEJC).transform.position = instance.PMHJMCIODBO[2];
		KentaNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Down);
		((Component)RinNPC.GGFJGHHHEJC).transform.position = instance.PMHJMCIODBO[3];
		RinNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Down);
		if (OnlineManager.MasterOrOffline())
		{
			((Behaviour)RinNPC.GGFJGHHHEJC.routine).enabled = true;
			RinNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
			((Behaviour)KentaNPC.GGFJGHHHEJC.routine).enabled = true;
			KentaNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
		}
		yield return CommonReferences.wait10;
		if (OnlineManager.MasterOrOffline())
		{
			((Behaviour)KujakuNPC.GGFJGHHHEJC.routine).enabled = true;
			KujakuNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
			((Behaviour)ZuzzuNPC.GGFJGHHHEJC.routine).enabled = true;
			ZuzzuNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
		}
		ZuzzuNPC.GGFJGHHHEJC.content.SetActive(true);
		((Component)ZuzzuNPC.GGFJGHHHEJC).transform.position = instance.PMHJMCIODBO[1];
		ZuzzuNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Down);
		KujakuNPC.GGFJGHHHEJC.playerCanInteract = true;
		ZuzzuNPC.GGFJGHHHEJC.playerCanInteract = true;
		PrecisionEvent.instance.ActivateEvent();
		BalanceEvent.instance.ActivateEvent();
	}

	public override void EndEvent(bool BFLCJPHHDJM)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		PsaiCore.Instance.StopMusic(immediately: false);
		MusicController.instance.TriggerCurrentBasicMood(CommonReferences.wait20, Location.Road);
		KujakuNPC.GGFJGHHHEJC.playerCanInteract = false;
		KujakuNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePositions[4].position), Direction.Left, AMEOKNOLILB: true);
		ZuzzuNPC.GGFJGHHHEJC.playerCanInteract = false;
		ZuzzuNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePositions[5].position), Direction.Left, AMEOKNOLILB: true);
		HikariNPC.GGFJGHHHEJC.animationBase.SetBool("Scene", EGFGNGJGBOP: false);
		ZuzzuNPC.GGFJGHHHEJC.animationBase.SetBool("Angry", EGFGNGJGBOP: false);
		KentaNPC.GGFJGHHHEJC.animationBase.SetBool("Scene", EGFGNGJGBOP: false);
		RinNPC.GGFJGHHHEJC.animationBase.SetBool("Scene", EGFGNGJGBOP: false);
		((MonoBehaviour)instance).StartCoroutine(instance.LJABJLDHLCB());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendEndEvent(eventType);
		}
	}

	public void HFDMDOEHMNN()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		instance.EDGDFPPKGDL = null;
		KujakuNPC.BADFKMEJOKE().MLACFFDPKPA(Vector2.op_Implicit(movePositions[1].position), Direction.Right);
		ZuzzuNPC.OPDKAPNDBJE().EEKGHEKNBIM(Vector2.op_Implicit(movePositions[3].position), (Direction)5);
	}

	public void KujakuWeaponAnim()
	{
		KujakuNPC.GGFJGHHHEJC.animationBase.SetBool("Scene", EGFGNGJGBOP: false);
		KujakuNPC.GGFJGHHHEJC.animationBase.SetBool("Weapon", EGFGNGJGBOP: true);
	}

	public void FOHKJNAPDBA()
	{
		instance.EndEvent(BFLCJPHHDJM: false);
	}

	public static void DIAKNAGOJHE()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.JGPDBNJEJEA());
	}

	public void PABCKMCMOCH()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		instance.EDGDFPPKGDL = null;
		KujakuNPC.DEGPIHEEFHJ().MLACFFDPKPA(Vector2.op_Implicit(movePositions[8].position), Direction.Up, AMEOKNOLILB: true);
		ZuzzuNPC.PNHHCHJCDNM().GAINAOFIGGH(Vector2.op_Implicit(movePositions[4].position), Direction.Left, AMEOKNOLILB: true);
	}

	private void GJBNMNBAJIP()
	{
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			KujakuNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
			ZuzzuNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
			KentaNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
			RinNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
			((Behaviour)KujakuNPC.GGFJGHHHEJC.routine).enabled = false;
			((Behaviour)ZuzzuNPC.GGFJGHHHEJC.routine).enabled = false;
			((Behaviour)KentaNPC.GGFJGHHHEJC.routine).enabled = false;
			((Behaviour)RinNPC.GGFJGHHHEJC.routine).enabled = false;
		}
		KujakuNPC.GGFJGHHHEJC.content.SetActive(true);
		HikariNPC.GGFJGHHHEJC.content.SetActive(true);
		ZuzzuNPC.GGFJGHHHEJC.content.SetActive(true);
		KentaNPC.GGFJGHHHEJC.content.SetActive(true);
		RinNPC.GGFJGHHHEJC.content.SetActive(true);
		((Component)KujakuNPC.GGFJGHHHEJC).transform.position = characterPositions[0].position;
		KujakuNPC.GGFJGHHHEJC.animationBase.SetBool("Scene", EGFGNGJGBOP: true, HALNIEBONKH: true);
		KujakuNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Right);
		PMHJMCIODBO[0] = ((Component)HikariNPC.GGFJGHHHEJC).transform.position;
		HikariNPC.GGFJGHHHEJC.inScene = true;
		((Component)HikariNPC.GGFJGHHHEJC).transform.position = characterPositions[1].position;
		HikariNPC.GGFJGHHHEJC.animationBase.SetBool("Scene", EGFGNGJGBOP: true, HALNIEBONKH: true);
		HikariNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Right);
		PMHJMCIODBO[1] = ((Component)ZuzzuNPC.GGFJGHHHEJC).transform.position;
		((Component)ZuzzuNPC.GGFJGHHHEJC).transform.position = characterPositions[2].position;
		ZuzzuNPC.GGFJGHHHEJC.animationBase.SetBool("Angry", EGFGNGJGBOP: true, HALNIEBONKH: true);
		ZuzzuNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Left);
		PMHJMCIODBO[2] = ((Component)KentaNPC.GGFJGHHHEJC).transform.position;
		((Component)KentaNPC.GGFJGHHHEJC).transform.position = characterPositions[3].position;
		KentaNPC.GGFJGHHHEJC.animationBase.SetBool("Scene", EGFGNGJGBOP: true, HALNIEBONKH: true);
		KentaNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Left);
		instance.PMHJMCIODBO[3] = ((Component)RinNPC.GGFJGHHHEJC).transform.position;
		((Component)RinNPC.GGFJGHHHEJC).transform.position = characterPositions[4].position;
		RinNPC.GGFJGHHHEJC.animationBase.SetBool("Scene", EGFGNGJGBOP: true, HALNIEBONKH: true);
		RinNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Left);
	}

	private void FKLOPHAFBDF()
	{
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			KujakuNPC.BADFKMEJOKE().routine.noDisableOnReset = true;
			ZuzzuNPC.DFJGHOHPPEL().routine.noDisableOnReset = false;
			KentaNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
			RinNPC.KNLLFEJAMNN().routine.noDisableOnReset = true;
			((Behaviour)KujakuNPC.DEGPIHEEFHJ().routine).enabled = true;
			((Behaviour)ZuzzuNPC.KNLLFEJAMNN().routine).enabled = true;
			((Behaviour)KentaNPC.GGFJGHHHEJC.routine).enabled = false;
			((Behaviour)RinNPC.OPILDPFDFKJ().routine).enabled = true;
		}
		KujakuNPC.LANAINBEMCM().content.SetActive(true);
		HikariNPC.OFLELHKKNKC().content.SetActive(false);
		ZuzzuNPC.EBAIHKJHCCA().content.SetActive(false);
		KentaNPC.GGFJGHHHEJC.content.SetActive(false);
		RinNPC.GGFJGHHHEJC.content.SetActive(false);
		((Component)KujakuNPC.LANAINBEMCM()).transform.position = characterPositions[0].position;
		KujakuNPC.LANAINBEMCM().animationBase.CGEADHOLHCH("ReceiveLoadSlots", EGFGNGJGBOP: false, HALNIEBONKH: true);
		KujakuNPC.DEGPIHEEFHJ().animationBase.LookDirection((Direction)8);
		PMHJMCIODBO[1] = ((Component)HikariNPC.ABDJJBFNLBJ()).transform.position;
		HikariNPC.OFLELHKKNKC().inScene = true;
		((Component)HikariNPC.GGFJGHHHEJC).transform.position = characterPositions[1].position;
		HikariNPC.EKDNJDJHONF().animationBase.SetBool("Items/item_description_677", EGFGNGJGBOP: false, HALNIEBONKH: true);
		HikariNPC.OFLELHKKNKC().animationBase.LookDirection((Direction)6);
		PMHJMCIODBO[0] = ((Component)ZuzzuNPC.AHBBHCKPIIJ()).transform.position;
		((Component)ZuzzuNPC.LFPEPJBNCBF()).transform.position = characterPositions[1].position;
		ZuzzuNPC.LFPEPJBNCBF().animationBase.SetBool("ScrollUp", EGFGNGJGBOP: false, HALNIEBONKH: true);
		ZuzzuNPC.JHMAMLIPBNN().animationBase.LookDirection(Direction.Up);
		PMHJMCIODBO[8] = ((Component)KentaNPC.GGFJGHHHEJC).transform.position;
		((Component)KentaNPC.GGFJGHHHEJC).transform.position = characterPositions[3].position;
		KentaNPC.GGFJGHHHEJC.animationBase.CGEADHOLHCH("ReceiveLoadSlots", EGFGNGJGBOP: true);
		KentaNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Up);
		instance.PMHJMCIODBO[0] = ((Component)RinNPC.AFFGPMFKEFH()).transform.position;
		((Component)RinNPC.OJJDNLEFNPJ()).transform.position = characterPositions[6].position;
		RinNPC.OJJDNLEFNPJ().animationBase.SetBool("Items/item_description_1152", EGFGNGJGBOP: true, HALNIEBONKH: true);
		RinNPC.EBAIHKJHCCA().animationBase.LookDirection(Direction.Diagonal);
	}

	private IEnumerator JKLMNMGLCHC()
	{
		yield return CommonReferences.wait2;
		RightMovement();
		yield return CommonReferences.wait4;
		KujakuNPC.GGFJGHHHEJC.blockActionBar = false;
		instance.EDGDFPPKGDL = KujakuNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "DueloDeViejos/MainEvent3";
		if (instance.isActor)
		{
			KujakuNPC.GGFJGHHHEJC.StartConversation(1, "DueloDeViejos/MainEvent3");
		}
		else if (OnlineManager.PlayingOnline())
		{
			yield return KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	public void JMFBBHDFHKA()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		instance.EDGDFPPKGDL = null;
		KujakuNPC.EKDNJDJHONF().MLACFFDPKPA(Vector2.op_Implicit(movePositions[4].position), Direction.Left, AMEOKNOLILB: true);
		ZuzzuNPC.PNHHCHJCDNM().LAMKDPEEFIN(Vector2.op_Implicit(movePositions[0].position), (Direction)8, AMEOKNOLILB: true);
	}

	private IEnumerator BGLOEKNLLPI()
	{
		yield return CommonReferences.wait2;
		RightMovement();
		yield return CommonReferences.wait4;
		KujakuNPC.GGFJGHHHEJC.blockActionBar = false;
		instance.EDGDFPPKGDL = KujakuNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "DueloDeViejos/MainEvent3";
		if (instance.isActor)
		{
			KujakuNPC.GGFJGHHHEJC.StartConversation(1, "DueloDeViejos/MainEvent3");
		}
		else if (OnlineManager.PlayingOnline())
		{
			yield return KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private void HILADEGOOKO()
	{
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			KujakuNPC.NEFIEJALANL().routine.noDisableOnReset = true;
			ZuzzuNPC.ELGNEJNLBNO().routine.noDisableOnReset = true;
			KentaNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
			RinNPC.AFFGPMFKEFH().routine.noDisableOnReset = false;
			((Behaviour)KujakuNPC.MAAAKALBBEE().routine).enabled = false;
			((Behaviour)ZuzzuNPC.ELGNEJNLBNO().routine).enabled = true;
			((Behaviour)KentaNPC.GGFJGHHHEJC.routine).enabled = false;
			((Behaviour)RinNPC.GGFJGHHHEJC.routine).enabled = false;
		}
		KujakuNPC.MAAAKALBBEE().content.SetActive(true);
		HikariNPC.EFPJLFMBPLL().content.SetActive(false);
		ZuzzuNPC.JHMAMLIPBNN().content.SetActive(false);
		KentaNPC.GGFJGHHHEJC.content.SetActive(false);
		RinNPC.KNLLFEJAMNN().content.SetActive(false);
		((Component)KujakuNPC.NEFIEJALANL()).transform.position = characterPositions[1].position;
		KujakuNPC.MAAAKALBBEE().animationBase.SetBool("ReceiveHasSnowList", EGFGNGJGBOP: true);
		KujakuNPC.BADFKMEJOKE().animationBase.LookDirection((Direction)7);
		PMHJMCIODBO[1] = ((Component)HikariNPC.OFLELHKKNKC()).transform.position;
		HikariNPC.OFLELHKKNKC().inScene = true;
		((Component)HikariNPC.EKDNJDJHONF()).transform.position = characterPositions[0].position;
		HikariNPC.OFLELHKKNKC().animationBase.SetBool(")", EGFGNGJGBOP: false, HALNIEBONKH: true);
		HikariNPC.ABDJJBFNLBJ().animationBase.LookDirection(Direction.Right);
		PMHJMCIODBO[0] = ((Component)ZuzzuNPC.AHBBHCKPIIJ()).transform.position;
		((Component)ZuzzuNPC.ELGNEJNLBNO()).transform.position = characterPositions[1].position;
		ZuzzuNPC.CHKMFEFOFKJ().animationBase.SetBool("Left Stick Up", EGFGNGJGBOP: false, HALNIEBONKH: true);
		ZuzzuNPC.CHKMFEFOFKJ().animationBase.LookDirection(Direction.Right);
		PMHJMCIODBO[4] = ((Component)KentaNPC.GGFJGHHHEJC).transform.position;
		((Component)KentaNPC.GGFJGHHHEJC).transform.position = characterPositions[5].position;
		KentaNPC.GGFJGHHHEJC.animationBase.SetBool("</color>", EGFGNGJGBOP: true, HALNIEBONKH: true);
		KentaNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Up);
		instance.PMHJMCIODBO[7] = ((Component)RinNPC.BNBMNOMFFBE()).transform.position;
		((Component)RinNPC.OPILDPFDFKJ()).transform.position = characterPositions[6].position;
		RinNPC.OJJDNLEFNPJ().animationBase.SetBool("NoEresDigno/MainEvent", EGFGNGJGBOP: false);
		RinNPC.BNBMNOMFFBE().animationBase.LookDirection(Direction.Diagonal);
	}

	private IEnumerator IDBEFCAHFBP()
	{
		DialogueLua.SetVariable("MainProgress", (object)14);
		DialogueCameraTarget.GetPlayer(1).ReturnControlToCameraTarget();
		if (GameManager.LocalCoop())
		{
			LocalCooperativeManager.RestoreCameraInLocalCoop();
		}
		MissionsManager.instance.StartMission(315, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		MissionsManager.instance.StartMission(316, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		Utils.DLIIAHACOJB(38);
		PlayerController.GetPlayer(1).gridController.disable = false;
		if (GameManager.LocalCoop())
		{
			PlayerController.GetPlayer(2).gridController.disable = false;
		}
		sceneFinished = true;
		while (Utils.NGLLIJPOBEC(Location.Road))
		{
			yield return null;
		}
		base.EndEvent(BGKCHMNJBLJ: false);
		((Component)SceneReferences.instance.customerPool).gameObject.SetActive(true);
		for (int i = 0; i < carriages.Length; i++)
		{
			instance.carriages[i].SetActive(false);
		}
		((Component)HikariNPC.GGFJGHHHEJC).transform.position = HikariNPC.GGFJGHHHEJC.beachPosition;
		HikariNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Down);
		HikariNPC.GGFJGHHHEJC.inScene = false;
		((Component)KentaNPC.GGFJGHHHEJC).transform.position = instance.PMHJMCIODBO[2];
		KentaNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Down);
		((Component)RinNPC.GGFJGHHHEJC).transform.position = instance.PMHJMCIODBO[3];
		RinNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Down);
		if (OnlineManager.MasterOrOffline())
		{
			((Behaviour)RinNPC.GGFJGHHHEJC.routine).enabled = true;
			RinNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
			((Behaviour)KentaNPC.GGFJGHHHEJC.routine).enabled = true;
			KentaNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
		}
		yield return CommonReferences.wait10;
		if (OnlineManager.MasterOrOffline())
		{
			((Behaviour)KujakuNPC.GGFJGHHHEJC.routine).enabled = true;
			KujakuNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
			((Behaviour)ZuzzuNPC.GGFJGHHHEJC.routine).enabled = true;
			ZuzzuNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
		}
		ZuzzuNPC.GGFJGHHHEJC.content.SetActive(true);
		((Component)ZuzzuNPC.GGFJGHHHEJC).transform.position = instance.PMHJMCIODBO[1];
		ZuzzuNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Down);
		KujakuNPC.GGFJGHHHEJC.playerCanInteract = true;
		ZuzzuNPC.GGFJGHHHEJC.playerCanInteract = true;
		PrecisionEvent.instance.ActivateEvent();
		BalanceEvent.instance.ActivateEvent();
	}

	public override GameEvent GetInstance()
	{
		return instance;
	}

	public void FLEJPGJMIMC()
	{
		instance.EDGDFPPKGDL = null;
		KujakuNPC.LANAINBEMCM().animationBase.CGEADHOLHCH("ReceiveEndIntroLucen", EGFGNGJGBOP: true);
		KujakuNPC.NEFIEJALANL().animationBase.SetBool(" %", EGFGNGJGBOP: true, HALNIEBONKH: true);
		ZuzzuNPC.LFPEPJBNCBF().animationBase.CGEADHOLHCH("Items/item_name_596", EGFGNGJGBOP: true, HALNIEBONKH: true);
		ZuzzuNPC.LFPEPJBNCBF().animationBase.CGEADHOLHCH("SceneReferences Start", EGFGNGJGBOP: false);
	}

	public void EndLaughAndMove()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		KujakuNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Right);
		ZuzzuNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Left);
		KujakuNPC.GGFJGHHHEJC.animationBase.SetBool("Laugh", EGFGNGJGBOP: false);
		ZuzzuNPC.GGFJGHHHEJC.animationBase.SetBool("Laugh", EGFGNGJGBOP: false);
		KujakuNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePositions[0].position), Direction.Right);
		ZuzzuNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePositions[1].position), Direction.Left);
		((MonoBehaviour)instance).StartCoroutine(instance.BNHFBEOFPDB());
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendOldMansDuelEndLaughAndMove();
		}
	}

	public void KGGAMKBOGCI()
	{
		ZuzzuNPC.GGFJGHHHEJC.animationBase.SetBool("ReceiveTrends", EGFGNGJGBOP: false);
		ZuzzuNPC.FJAMHCAAEAM().animationBase.CGEADHOLHCH(" in Cellar Light Start", EGFGNGJGBOP: false);
		((MonoBehaviour)instance).StartCoroutine(instance.KIIJMOMEJNN());
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendOldMansDuelZuzzuWeaponAnimation();
		}
	}

	private IEnumerator HMKEAHOFODF()
	{
		return new NBOAFDJFLOM(1)
		{
			_003C_003E4__this = this
		};
	}

	public void OnTravelZoneTo(int AAAIOBLCOFO)
	{
		Debug.Log((object)"OldMansDuelEvent OnTravelZoneTo");
		TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Road, Location.Tavern);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(OnTravelZoneTo));
		if (OnlineManager.PlayingOnline())
		{
			TravelZone travelZone2 = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Road, Location.RoomsMultiplayer);
			travelZone2.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone2.OnTravelZoneTo, new Action<int>(OnTravelZoneTo));
		}
		StartEvent(OnlineManager.MasterOrOffline(), CDPAMNIPPEC: false);
	}

	private IEnumerator FCNPLLFADOD()
	{
		OnlineManager.ResetAllPlayersPrepared();
		TravelZonesManager.GGFJGHHHEJC.GetTravelZone(PlayerController.GetPlayer(1).LEOIMFNKFGA, Location.Road).StartTravelZone(1);
		if (GameManager.LocalCoop())
		{
			TravelZonesManager.GGFJGHHHEJC.GetTravelZone(PlayerController.GetPlayer(2).LEOIMFNKFGA, Location.Road).StartTravelZone(2);
		}
		yield return CommonReferences.wait01;
		PlayerInputs.EnableKeyboardInputsAndMovement(1, (MonoBehaviour)(object)instance);
	}

	public void CJCOKOEIOFO()
	{
		ZuzzuNPC.JFNOOMJMHCB().animationBase.CGEADHOLHCH("Master is Loading. Waiting...", EGFGNGJGBOP: false);
		ZuzzuNPC.OAPOJCODNCO().animationBase.SetBool("ReceiveCursorMove", EGFGNGJGBOP: true, HALNIEBONKH: true);
		((MonoBehaviour)instance).StartCoroutine(instance.CBFICMLOANI());
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendOldMansDuelZuzzuWeaponAnimation();
		}
	}

	private IEnumerator LPHHFMOOPKB()
	{
		instance.EDGDFPPKGDL = null;
		DialogueCameraTarget.GetPlayer(1).cameraInEvent = true;
		DialogueCameraTarget.GetPlayer(1).MoveCameraToPositionFromCameraTarget(Vector2.op_Implicit(cameraPosition.position));
		if (GameManager.LocalCoop())
		{
			LocalCooperativeManager.FocusCameraToPlayerInLocalCoop(1);
		}
		yield return CommonReferences.wait3;
		yield return OnlineManager.WaitForAllPlayers();
		instance.EDGDFPPKGDL = KujakuNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "DueloDeViejos/MainEvent";
		KujakuNPC.GGFJGHHHEJC.barkDialogue = false;
		KujakuNPC.GGFJGHHHEJC.inSpecialEvent = true;
		KujakuNPC.GGFJGHHHEJC.blockActionBar = true;
		if (instance.isActor)
		{
			KujakuNPC.GGFJGHHHEJC.StartConversation(1, "DueloDeViejos/MainEvent");
		}
		else if (OnlineManager.PlayingOnline())
		{
			yield return KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	public void POIOKHLLABP()
	{
		ZuzzuNPC.OPDKAPNDBJE().animationBase.SetBool("TavernManager instance is null, cannot remove open tavern blocker.", EGFGNGJGBOP: false);
		ZuzzuNPC.OAPOJCODNCO().animationBase.CGEADHOLHCH("CharacterChanged", EGFGNGJGBOP: false);
		((MonoBehaviour)instance).StartCoroutine(instance.DBMMNEEMFAM());
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineEventsManager.SendOldMansDuelZuzzuWeaponAnimation();
		}
	}

	private void MFKAECJIKKK()
	{
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_0258: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			KujakuNPC.EKDNJDJHONF().routine.noDisableOnReset = true;
			ZuzzuNPC.JHMAMLIPBNN().routine.noDisableOnReset = true;
			KentaNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
			RinNPC.KNLLFEJAMNN().routine.noDisableOnReset = true;
			((Behaviour)KujakuNPC.GGFJGHHHEJC.routine).enabled = false;
			((Behaviour)ZuzzuNPC.FJAMHCAAEAM().routine).enabled = true;
			((Behaviour)KentaNPC.GGFJGHHHEJC.routine).enabled = true;
			((Behaviour)RinNPC.GGFJGHHHEJC.routine).enabled = false;
		}
		KujakuNPC.MAAAKALBBEE().content.SetActive(true);
		HikariNPC.EFPJLFMBPLL().content.SetActive(false);
		ZuzzuNPC.DICHPHEOINO().content.SetActive(true);
		KentaNPC.GGFJGHHHEJC.content.SetActive(false);
		RinNPC.GGFJGHHHEJC.content.SetActive(false);
		((Component)KujakuNPC.NEFIEJALANL()).transform.position = characterPositions[1].position;
		KujakuNPC.NEFIEJALANL().animationBase.SetBool("psai [{0}]: skipping {1} as there are other Triggers firing: {2}", EGFGNGJGBOP: true);
		KujakuNPC.BADFKMEJOKE().animationBase.LookDirection(Direction.Diagonal);
		PMHJMCIODBO[0] = ((Component)HikariNPC.GGFJGHHHEJC).transform.position;
		HikariNPC.EKDNJDJHONF().inScene = true;
		((Component)HikariNPC.ABDJJBFNLBJ()).transform.position = characterPositions[1].position;
		HikariNPC.GGFJGHHHEJC.animationBase.CGEADHOLHCH(" for reason: ", EGFGNGJGBOP: true, HALNIEBONKH: true);
		HikariNPC.MNFMOEKMJKN().animationBase.LookDirection(Direction.Right);
		PMHJMCIODBO[0] = ((Component)ZuzzuNPC.DCAEBALADIM()).transform.position;
		((Component)ZuzzuNPC.GGFJGHHHEJC).transform.position = characterPositions[0].position;
		ZuzzuNPC.CHPEMJMLDCN().animationBase.SetBool("You Lose", EGFGNGJGBOP: true, HALNIEBONKH: true);
		ZuzzuNPC.FJAMHCAAEAM().animationBase.LookDirection((Direction)6);
		PMHJMCIODBO[6] = ((Component)KentaNPC.GGFJGHHHEJC).transform.position;
		((Component)KentaNPC.GGFJGHHHEJC).transform.position = characterPositions[1].position;
		KentaNPC.GGFJGHHHEJC.animationBase.SetBool("Start Event ", EGFGNGJGBOP: false);
		KentaNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Right);
		instance.PMHJMCIODBO[3] = ((Component)RinNPC.GGFJGHHHEJC).transform.position;
		((Component)RinNPC.OJJDNLEFNPJ()).transform.position = characterPositions[6].position;
		RinNPC.EBAIHKJHCCA().animationBase.CGEADHOLHCH("ReceiveConstructionModeClosed", EGFGNGJGBOP: true, HALNIEBONKH: true);
		RinNPC.EBAIHKJHCCA().animationBase.LookDirection(Direction.Left);
	}

	public void DPBGACKDPJG()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		KujakuNPC.LANAINBEMCM().animationBase.SetDirection((Direction)7);
		ZuzzuNPC.FJAMHCAAEAM().animationBase.SetDirection(Direction.Down);
		KujakuNPC.LANAINBEMCM().animationBase.SetBool("[NPCGender=", EGFGNGJGBOP: false);
		ZuzzuNPC.CHPEMJMLDCN().animationBase.CGEADHOLHCH("OnlinePlayer", EGFGNGJGBOP: true);
		KujakuNPC.BADFKMEJOKE().Walk(Vector2.op_Implicit(movePositions[1].position), (Direction)7);
		ZuzzuNPC.DCAEBALADIM().Walk(Vector2.op_Implicit(movePositions[0].position), (Direction)7);
		((MonoBehaviour)instance).StartCoroutine(instance.MFACAJDJGGJ());
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendOldMansDuelEndLaughAndMove();
		}
	}

	private IEnumerator LJABJLDHLCB()
	{
		DialogueLua.SetVariable("MainProgress", (object)14);
		DialogueCameraTarget.GetPlayer(1).ReturnControlToCameraTarget();
		if (GameManager.LocalCoop())
		{
			LocalCooperativeManager.RestoreCameraInLocalCoop();
		}
		MissionsManager.instance.StartMission(315, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		MissionsManager.instance.StartMission(316, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		Utils.DLIIAHACOJB(38);
		PlayerController.GetPlayer(1).gridController.disable = false;
		if (GameManager.LocalCoop())
		{
			PlayerController.GetPlayer(2).gridController.disable = false;
		}
		sceneFinished = true;
		while (Utils.NGLLIJPOBEC(Location.Road))
		{
			yield return null;
		}
		base.EndEvent(BGKCHMNJBLJ: false);
		((Component)SceneReferences.instance.customerPool).gameObject.SetActive(true);
		for (int i = 0; i < carriages.Length; i++)
		{
			instance.carriages[i].SetActive(false);
		}
		((Component)HikariNPC.GGFJGHHHEJC).transform.position = HikariNPC.GGFJGHHHEJC.beachPosition;
		HikariNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Down);
		HikariNPC.GGFJGHHHEJC.inScene = false;
		((Component)KentaNPC.GGFJGHHHEJC).transform.position = instance.PMHJMCIODBO[2];
		KentaNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Down);
		((Component)RinNPC.GGFJGHHHEJC).transform.position = instance.PMHJMCIODBO[3];
		RinNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Down);
		if (OnlineManager.MasterOrOffline())
		{
			((Behaviour)RinNPC.GGFJGHHHEJC.routine).enabled = true;
			RinNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
			((Behaviour)KentaNPC.GGFJGHHHEJC.routine).enabled = true;
			KentaNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
		}
		yield return CommonReferences.wait10;
		if (OnlineManager.MasterOrOffline())
		{
			((Behaviour)KujakuNPC.GGFJGHHHEJC.routine).enabled = true;
			KujakuNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
			((Behaviour)ZuzzuNPC.GGFJGHHHEJC.routine).enabled = true;
			ZuzzuNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
		}
		ZuzzuNPC.GGFJGHHHEJC.content.SetActive(true);
		((Component)ZuzzuNPC.GGFJGHHHEJC).transform.position = instance.PMHJMCIODBO[1];
		ZuzzuNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Down);
		KujakuNPC.GGFJGHHHEJC.playerCanInteract = true;
		ZuzzuNPC.GGFJGHHHEJC.playerCanInteract = true;
		PrecisionEvent.instance.ActivateEvent();
		BalanceEvent.instance.ActivateEvent();
	}

	private IEnumerator FOJGKFCCFAA()
	{
		return new HMNLFFCGBPC(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AFDIGBEKAIM()
	{
		return new LOBFLFPPEFF(1);
	}

	private IEnumerator PDICLNNNPEB()
	{
		return new JPEKGDEIACO(1);
	}

	private IEnumerator OIKDONLFAIL()
	{
		return new HMNLFFCGBPC(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator PHFNFCCJEMB()
	{
		instance.EDGDFPPKGDL = null;
		DialogueCameraTarget.GetPlayer(1).cameraInEvent = true;
		DialogueCameraTarget.GetPlayer(1).MoveCameraToPositionFromCameraTarget(Vector2.op_Implicit(cameraPosition.position));
		if (GameManager.LocalCoop())
		{
			LocalCooperativeManager.FocusCameraToPlayerInLocalCoop(1);
		}
		yield return CommonReferences.wait3;
		yield return OnlineManager.WaitForAllPlayers();
		instance.EDGDFPPKGDL = KujakuNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "DueloDeViejos/MainEvent";
		KujakuNPC.GGFJGHHHEJC.barkDialogue = false;
		KujakuNPC.GGFJGHHHEJC.inSpecialEvent = true;
		KujakuNPC.GGFJGHHHEJC.blockActionBar = true;
		if (instance.isActor)
		{
			KujakuNPC.GGFJGHHHEJC.StartConversation(1, "DueloDeViejos/MainEvent");
		}
		else if (OnlineManager.PlayingOnline())
		{
			yield return KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	public void MKOEKGJANBG()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		KujakuNPC.MAAAKALBBEE().animationBase.SetDirection(Direction.Up);
		ZuzzuNPC.DCAEBALADIM().animationBase.SetDirection(Direction.Right);
		KujakuNPC.EKDNJDJHONF().animationBase.SetBool("Player2", EGFGNGJGBOP: false);
		ZuzzuNPC.JFNOOMJMHCB().animationBase.SetBool("IntensityBars", EGFGNGJGBOP: false, HALNIEBONKH: true);
		KujakuNPC.GGFJGHHHEJC.HEACFLIHBBI(Vector2.op_Implicit(movePositions[1].position), (Direction)5);
		ZuzzuNPC.PNHHCHJCDNM().GAINAOFIGGH(Vector2.op_Implicit(movePositions[0].position), (Direction)6);
		((MonoBehaviour)instance).StartCoroutine(instance.JKLMNMGLCHC());
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendOldMansDuelEndLaughAndMove();
		}
	}

	private IEnumerator AALIOJAFPAM()
	{
		return new BPONOCMNNID(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator PLPDBLOKDHC()
	{
		yield return CommonReferences.wait2;
		RightMovement();
		yield return CommonReferences.wait4;
		KujakuNPC.GGFJGHHHEJC.blockActionBar = false;
		instance.EDGDFPPKGDL = KujakuNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "DueloDeViejos/MainEvent3";
		if (instance.isActor)
		{
			KujakuNPC.GGFJGHHHEJC.StartConversation(1, "DueloDeViejos/MainEvent3");
		}
		else if (OnlineManager.PlayingOnline())
		{
			yield return KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	public override void StartEvent(bool BFLCJPHHDJM, bool CDPAMNIPPEC)
	{
		base.StartEvent(BFLCJPHHDJM, CDPAMNIPPEC);
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		((MonoBehaviour)this).StartCoroutine(EFOONHMKJEB());
		PlayerController.GetPlayer(1).gridController.disable = true;
		if (GameManager.LocalCoop())
		{
			PlayerController.GetPlayer(2).gridController.disable = true;
		}
		IJLNHBOOFKL = 0.3f;
		PsaiCore.Instance.StopMusic(immediately: false);
		MusicController.instance.TriggerMusicTheme(37, 0.3f);
		PsaiCore.Instance.HoldCurrentIntensity(hold: true);
		CommonReferences.GGFJGHHHEJC.OnActionDone(1, ActionDone.SunriseReunion);
	}

	public void DOPLJELOBBN()
	{
		KujakuNPC.NEFIEJALANL().animationBase.SetBool("Dialogue System/Conversation/TableDirty/Entry/2/Dialogue Text", EGFGNGJGBOP: false, HALNIEBONKH: true);
		KujakuNPC.NEFIEJALANL().animationBase.SetBool("ReceiveBasics", EGFGNGJGBOP: true);
	}

	private IEnumerator EFOONHMKJEB()
	{
		instance.EDGDFPPKGDL = null;
		DialogueCameraTarget.GetPlayer(1).cameraInEvent = true;
		DialogueCameraTarget.GetPlayer(1).MoveCameraToPositionFromCameraTarget(Vector2.op_Implicit(cameraPosition.position));
		if (GameManager.LocalCoop())
		{
			LocalCooperativeManager.FocusCameraToPlayerInLocalCoop(1);
		}
		yield return CommonReferences.wait3;
		yield return OnlineManager.WaitForAllPlayers();
		instance.EDGDFPPKGDL = KujakuNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "DueloDeViejos/MainEvent";
		KujakuNPC.GGFJGHHHEJC.barkDialogue = false;
		KujakuNPC.GGFJGHHHEJC.inSpecialEvent = true;
		KujakuNPC.GGFJGHHHEJC.blockActionBar = true;
		if (instance.isActor)
		{
			KujakuNPC.GGFJGHHHEJC.StartConversation(1, "DueloDeViejos/MainEvent");
		}
		else if (OnlineManager.PlayingOnline())
		{
			yield return KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	public void LEMALDJGOKB(int AAAIOBLCOFO)
	{
		Debug.Log((object)"Invalid item");
		TravelZone travelZone = TravelZonesManager.OLHBLKIAFOM().GetTravelZone(Location.Road, Location.None);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(LEMALDJGOKB));
		if (OnlineManager.PlayingOnline())
		{
			TravelZone travelZone2 = TravelZonesManager.OACNNJCLEDE().OFIPCMMKFLP(Location.Tavern | Location.Road | Location.River, ~(Location.River | Location.Camp | Location.Quarry | Location.BarnInterior));
			travelZone2.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone2.OnTravelZoneTo, new Action<int>(CGNFKCAMHLJ));
		}
		StartEvent(OnlineManager.MasterOrOffline(), CDPAMNIPPEC: true);
	}

	[CompilerGenerated]
	[DebuggerHidden]
	private void LLIJGOCKPBB(bool BGKCHMNJBLJ)
	{
		base.EndEvent(BGKCHMNJBLJ);
	}

	public void EBHAODCCJBI()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		instance.EDGDFPPKGDL = null;
		KujakuNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePositions[3].position));
		ZuzzuNPC.DICHPHEOINO().EEKGHEKNBIM(Vector2.op_Implicit(movePositions[5].position));
	}

	private IEnumerator GHFHEDIHFHA()
	{
		instance.EDGDFPPKGDL = null;
		DialogueCameraTarget.GetPlayer(1).cameraInEvent = true;
		DialogueCameraTarget.GetPlayer(1).MoveCameraToPositionFromCameraTarget(Vector2.op_Implicit(cameraPosition.position));
		if (GameManager.LocalCoop())
		{
			LocalCooperativeManager.FocusCameraToPlayerInLocalCoop(1);
		}
		yield return CommonReferences.wait3;
		yield return OnlineManager.WaitForAllPlayers();
		instance.EDGDFPPKGDL = KujakuNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "DueloDeViejos/MainEvent";
		KujakuNPC.GGFJGHHHEJC.barkDialogue = false;
		KujakuNPC.GGFJGHHHEJC.inSpecialEvent = true;
		KujakuNPC.GGFJGHHHEJC.blockActionBar = true;
		if (instance.isActor)
		{
			KujakuNPC.GGFJGHHHEJC.StartConversation(1, "DueloDeViejos/MainEvent");
		}
		else if (OnlineManager.PlayingOnline())
		{
			yield return KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	public static void TeleportPlayerToRoad()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.FCNPLLFADOD());
	}

	public void COHLPKGILOJ()
	{
		instance.EDGDFPPKGDL = null;
		KujakuNPC.EKDNJDJHONF().animationBase.CGEADHOLHCH("Dialogue System/Conversation/HappyRentRoom/Entry/3/Dialogue Text", EGFGNGJGBOP: true, HALNIEBONKH: true);
		KujakuNPC.NEFIEJALANL().animationBase.CGEADHOLHCH("IsOpen", EGFGNGJGBOP: true);
		ZuzzuNPC.CHKMFEFOFKJ().animationBase.CGEADHOLHCH("lightInEditorEnabled in DayLight checkbox enabled. Remember to disable", EGFGNGJGBOP: true);
		ZuzzuNPC.ELGNEJNLBNO().animationBase.SetBool("TorchPuzzle requires TorchPuzzleSettings", EGFGNGJGBOP: false);
	}

	public static void HJFBILFLBNO()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.AFDIGBEKAIM());
	}

	public void DHKBIJJPEHH()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		KujakuNPC.DEGPIHEEFHJ().animationBase.SetDirection(Direction.Up);
		ZuzzuNPC.FJAMHCAAEAM().animationBase.SetDirection((Direction)7);
		KujakuNPC.NEFIEJALANL().animationBase.SetBool("Items/item_description_673", EGFGNGJGBOP: false);
		ZuzzuNPC.CHKMFEFOFKJ().animationBase.SetBool("00", EGFGNGJGBOP: true, HALNIEBONKH: true);
		KujakuNPC.DEGPIHEEFHJ().Walk(Vector2.op_Implicit(movePositions[1].position));
		ZuzzuNPC.FJAMHCAAEAM().EEKGHEKNBIM(Vector2.op_Implicit(movePositions[0].position), (Direction)7);
		((MonoBehaviour)instance).StartCoroutine(instance.ALFLEDFMOIG());
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineEventsManager.SendOldMansDuelEndLaughAndMove();
		}
	}

	public void PJHHAEIJLEL()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.LCHCKJFMKIF());
	}

	public void AOCNEGONONN()
	{
		instance.EDGDFPPKGDL = null;
		KujakuNPC.EKDNJDJHONF().animationBase.SetBool("Close", EGFGNGJGBOP: true, HALNIEBONKH: true);
		KujakuNPC.BADFKMEJOKE().animationBase.SetBool("Invalid playerNum", EGFGNGJGBOP: false);
		ZuzzuNPC.JFJOKGAOPHA().animationBase.CGEADHOLHCH("Keg empty", EGFGNGJGBOP: false, HALNIEBONKH: true);
		ZuzzuNPC.CHPEMJMLDCN().animationBase.CGEADHOLHCH("Received set minigame", EGFGNGJGBOP: true);
	}

	private IEnumerator FEAIPDPBOCI()
	{
		return new NBOAFDJFLOM(1)
		{
			_003C_003E4__this = this
		};
	}

	public static void HAJFNKCKFDO()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.JGPDBNJEJEA());
	}

	public void ABEJOLNDEAN()
	{
		instance.EDGDFPPKGDL = null;
		KujakuNPC.GGFJGHHHEJC.animationBase.SetBool(" , waking up in: ", EGFGNGJGBOP: false);
		KujakuNPC.NEFIEJALANL().animationBase.SetBool("Disconnected from network. Cause: ", EGFGNGJGBOP: false);
		ZuzzuNPC.JFNOOMJMHCB().animationBase.SetBool("ClosePopUp", EGFGNGJGBOP: true);
		ZuzzuNPC.OPDKAPNDBJE().animationBase.CGEADHOLHCH("Items/item_name_1097", EGFGNGJGBOP: false);
	}

	private IEnumerator LMBMJDJBEOO()
	{
		instance.EDGDFPPKGDL = null;
		float originalVolume = PsaiCore.Instance.GetVolume();
		MusicController.instance.ModifiyVolumeOverTime(0f, 0.3f);
		instance.backPain.SetActive(true);
		((Component)KujakuNPC.GGFJGHHHEJC).transform.parent = instance.backPain.transform;
		((Renderer)(KujakuNPC.GGFJGHHHEJC.animationBase as NPCAnimation).npcSprite).sortingOrder = 3;
		((Renderer)(KujakuNPC.GGFJGHHHEJC.animationBase as NPCAnimation).npcSprite).sortingLayerName = "Top";
		((Component)ZuzzuNPC.GGFJGHHHEJC).transform.parent = instance.backPain.transform;
		((Renderer)(ZuzzuNPC.GGFJGHHHEJC.animationBase as NPCAnimation).npcSprite).sortingOrder = 3;
		((Renderer)(ZuzzuNPC.GGFJGHHHEJC.animationBase as NPCAnimation).npcSprite).sortingLayerName = "Top";
		yield return CommonReferences.wait1_5;
		KujakuNPC.GGFJGHHHEJC.animationBase.SetBool("WeaponEnd", EGFGNGJGBOP: false);
		KujakuNPC.GGFJGHHHEJC.animationBase.SetBool("BackPain", EGFGNGJGBOP: true);
		ZuzzuNPC.GGFJGHHHEJC.animationBase.SetBool("StaffEnd", EGFGNGJGBOP: false);
		ZuzzuNPC.GGFJGHHHEJC.animationBase.SetBool("Backache", EGFGNGJGBOP: true);
		yield return CommonReferences.wait1_5;
		MusicController.instance.ModifiyVolumeOverTime(originalVolume, 1f);
		instance.backPain.SetActive(false);
		((Component)KujakuNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)ZuzzuNPC.GGFJGHHHEJC).transform.parent = null;
		KujakuNPC.GGFJGHHHEJC.animationBase.SetBool("BackPain", EGFGNGJGBOP: true);
		ZuzzuNPC.GGFJGHHHEJC.animationBase.SetBool("Backache", EGFGNGJGBOP: true);
		((Renderer)(KujakuNPC.GGFJGHHHEJC.animationBase as NPCAnimation).npcSprite).sortingLayerName = "OnFloor";
		((Renderer)(KujakuNPC.GGFJGHHHEJC.animationBase as NPCAnimation).npcSprite).sortingOrder = 0;
		((Renderer)(ZuzzuNPC.GGFJGHHHEJC.animationBase as NPCAnimation).npcSprite).sortingLayerName = "OnFloor";
		((Renderer)(ZuzzuNPC.GGFJGHHHEJC.animationBase as NPCAnimation).npcSprite).sortingOrder = 0;
	}

	public void FPEACAGNHNO()
	{
		instance.EndEvent(BFLCJPHHDJM: false);
	}

	public void RightMovement()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		instance.EDGDFPPKGDL = null;
		KujakuNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePositions[2].position), Direction.Right);
		ZuzzuNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePositions[3].position), Direction.Right);
	}

	private IEnumerator JIFJLCMNMEA()
	{
		DialogueLua.SetVariable("MainProgress", (object)14);
		DialogueCameraTarget.GetPlayer(1).ReturnControlToCameraTarget();
		if (GameManager.LocalCoop())
		{
			LocalCooperativeManager.RestoreCameraInLocalCoop();
		}
		MissionsManager.instance.StartMission(315, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		MissionsManager.instance.StartMission(316, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		Utils.DLIIAHACOJB(38);
		PlayerController.GetPlayer(1).gridController.disable = false;
		if (GameManager.LocalCoop())
		{
			PlayerController.GetPlayer(2).gridController.disable = false;
		}
		sceneFinished = true;
		while (Utils.NGLLIJPOBEC(Location.Road))
		{
			yield return null;
		}
		base.EndEvent(BGKCHMNJBLJ: false);
		((Component)SceneReferences.instance.customerPool).gameObject.SetActive(true);
		for (int i = 0; i < carriages.Length; i++)
		{
			instance.carriages[i].SetActive(false);
		}
		((Component)HikariNPC.GGFJGHHHEJC).transform.position = HikariNPC.GGFJGHHHEJC.beachPosition;
		HikariNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Down);
		HikariNPC.GGFJGHHHEJC.inScene = false;
		((Component)KentaNPC.GGFJGHHHEJC).transform.position = instance.PMHJMCIODBO[2];
		KentaNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Down);
		((Component)RinNPC.GGFJGHHHEJC).transform.position = instance.PMHJMCIODBO[3];
		RinNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Down);
		if (OnlineManager.MasterOrOffline())
		{
			((Behaviour)RinNPC.GGFJGHHHEJC.routine).enabled = true;
			RinNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
			((Behaviour)KentaNPC.GGFJGHHHEJC.routine).enabled = true;
			KentaNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
		}
		yield return CommonReferences.wait10;
		if (OnlineManager.MasterOrOffline())
		{
			((Behaviour)KujakuNPC.GGFJGHHHEJC.routine).enabled = true;
			KujakuNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
			((Behaviour)ZuzzuNPC.GGFJGHHHEJC.routine).enabled = true;
			ZuzzuNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
		}
		ZuzzuNPC.GGFJGHHHEJC.content.SetActive(true);
		((Component)ZuzzuNPC.GGFJGHHHEJC).transform.position = instance.PMHJMCIODBO[1];
		ZuzzuNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Down);
		KujakuNPC.GGFJGHHHEJC.playerCanInteract = true;
		ZuzzuNPC.GGFJGHHHEJC.playerCanInteract = true;
		PrecisionEvent.instance.ActivateEvent();
		BalanceEvent.instance.ActivateEvent();
	}

	private IEnumerator HEGPAHPFAOM()
	{
		return new HMNLFFCGBPC(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AHBEKAMDJPK()
	{
		instance.EDGDFPPKGDL = null;
		DialogueCameraTarget.GetPlayer(1).cameraInEvent = true;
		DialogueCameraTarget.GetPlayer(1).MoveCameraToPositionFromCameraTarget(Vector2.op_Implicit(cameraPosition.position));
		if (GameManager.LocalCoop())
		{
			LocalCooperativeManager.FocusCameraToPlayerInLocalCoop(1);
		}
		yield return CommonReferences.wait3;
		yield return OnlineManager.WaitForAllPlayers();
		instance.EDGDFPPKGDL = KujakuNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "DueloDeViejos/MainEvent";
		KujakuNPC.GGFJGHHHEJC.barkDialogue = false;
		KujakuNPC.GGFJGHHHEJC.inSpecialEvent = true;
		KujakuNPC.GGFJGHHHEJC.blockActionBar = true;
		if (instance.isActor)
		{
			KujakuNPC.GGFJGHHHEJC.StartConversation(1, "DueloDeViejos/MainEvent");
		}
		else if (OnlineManager.PlayingOnline())
		{
			yield return KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private IEnumerator MNGEJIMEOKF()
	{
		DialogueLua.SetVariable("MainProgress", (object)14);
		DialogueCameraTarget.GetPlayer(1).ReturnControlToCameraTarget();
		if (GameManager.LocalCoop())
		{
			LocalCooperativeManager.RestoreCameraInLocalCoop();
		}
		MissionsManager.instance.StartMission(315, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		MissionsManager.instance.StartMission(316, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		Utils.DLIIAHACOJB(38);
		PlayerController.GetPlayer(1).gridController.disable = false;
		if (GameManager.LocalCoop())
		{
			PlayerController.GetPlayer(2).gridController.disable = false;
		}
		sceneFinished = true;
		while (Utils.NGLLIJPOBEC(Location.Road))
		{
			yield return null;
		}
		base.EndEvent(BGKCHMNJBLJ: false);
		((Component)SceneReferences.instance.customerPool).gameObject.SetActive(true);
		for (int i = 0; i < carriages.Length; i++)
		{
			instance.carriages[i].SetActive(false);
		}
		((Component)HikariNPC.GGFJGHHHEJC).transform.position = HikariNPC.GGFJGHHHEJC.beachPosition;
		HikariNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Down);
		HikariNPC.GGFJGHHHEJC.inScene = false;
		((Component)KentaNPC.GGFJGHHHEJC).transform.position = instance.PMHJMCIODBO[2];
		KentaNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Down);
		((Component)RinNPC.GGFJGHHHEJC).transform.position = instance.PMHJMCIODBO[3];
		RinNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Down);
		if (OnlineManager.MasterOrOffline())
		{
			((Behaviour)RinNPC.GGFJGHHHEJC.routine).enabled = true;
			RinNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
			((Behaviour)KentaNPC.GGFJGHHHEJC.routine).enabled = true;
			KentaNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
		}
		yield return CommonReferences.wait10;
		if (OnlineManager.MasterOrOffline())
		{
			((Behaviour)KujakuNPC.GGFJGHHHEJC.routine).enabled = true;
			KujakuNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
			((Behaviour)ZuzzuNPC.GGFJGHHHEJC.routine).enabled = true;
			ZuzzuNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
		}
		ZuzzuNPC.GGFJGHHHEJC.content.SetActive(true);
		((Component)ZuzzuNPC.GGFJGHHHEJC).transform.position = instance.PMHJMCIODBO[1];
		ZuzzuNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Down);
		KujakuNPC.GGFJGHHHEJC.playerCanInteract = true;
		ZuzzuNPC.GGFJGHHHEJC.playerCanInteract = true;
		PrecisionEvent.instance.ActivateEvent();
		BalanceEvent.instance.ActivateEvent();
	}

	public override void ActivateEvent()
	{
		base.ActivateEvent();
		SceneReferences.GetSceneReferences().customerPool.DisableAllCustomers();
		((Component)SceneReferences.GetSceneReferences().customerPool).gameObject.SetActive(false);
		for (int i = 0; i < carriages.Length; i++)
		{
			carriages[i].SetActive(true);
		}
		sceneFinished = false;
		GJBNMNBAJIP();
		TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Road, Location.Tavern);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Combine(travelZone.OnTravelZoneTo, new Action<int>(OnTravelZoneTo));
		if (OnlineManager.PlayingOnline())
		{
			TravelZone travelZone2 = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Road, Location.RoomsMultiplayer);
			travelZone2.OnTravelZoneTo = (Action<int>)Delegate.Combine(travelZone2.OnTravelZoneTo, new Action<int>(OnTravelZoneTo));
		}
	}

	public void CHNJJAAEBAP()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		KujakuNPC.GGFJGHHHEJC.animationBase.SetDirection((Direction)6);
		ZuzzuNPC.DFJGHOHPPEL().animationBase.SetDirection((Direction)5);
		KujakuNPC.DEGPIHEEFHJ().animationBase.SetBool("cinemachine empty", EGFGNGJGBOP: false);
		ZuzzuNPC.EBAIHKJHCCA().animationBase.CGEADHOLHCH("Dialogue System/Conversation/TooDark/Entry/9/Dialogue Text", EGFGNGJGBOP: false, HALNIEBONKH: true);
		KujakuNPC.EKDNJDJHONF().Walk(Vector2.op_Implicit(movePositions[1].position), (Direction)5);
		ZuzzuNPC.AHBBHCKPIIJ().BAPCIPCAEKL(Vector2.op_Implicit(movePositions[0].position), Direction.Diagonal);
		((MonoBehaviour)instance).StartCoroutine(instance.MFACAJDJGGJ());
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendOldMansDuelEndLaughAndMove();
		}
	}

	private IEnumerator HMFIKEGAIFL()
	{
		instance.EDGDFPPKGDL = null;
		DialogueCameraTarget.GetPlayer(1).cameraInEvent = true;
		DialogueCameraTarget.GetPlayer(1).MoveCameraToPositionFromCameraTarget(Vector2.op_Implicit(cameraPosition.position));
		if (GameManager.LocalCoop())
		{
			LocalCooperativeManager.FocusCameraToPlayerInLocalCoop(1);
		}
		yield return CommonReferences.wait3;
		yield return OnlineManager.WaitForAllPlayers();
		instance.EDGDFPPKGDL = KujakuNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "DueloDeViejos/MainEvent";
		KujakuNPC.GGFJGHHHEJC.barkDialogue = false;
		KujakuNPC.GGFJGHHHEJC.inSpecialEvent = true;
		KujakuNPC.GGFJGHHHEJC.blockActionBar = true;
		if (instance.isActor)
		{
			KujakuNPC.GGFJGHHHEJC.StartConversation(1, "DueloDeViejos/MainEvent");
		}
		else if (OnlineManager.PlayingOnline())
		{
			yield return KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private IEnumerator FHADOOIFCJK()
	{
		DialogueLua.SetVariable("MainProgress", (object)14);
		DialogueCameraTarget.GetPlayer(1).ReturnControlToCameraTarget();
		if (GameManager.LocalCoop())
		{
			LocalCooperativeManager.RestoreCameraInLocalCoop();
		}
		MissionsManager.instance.StartMission(315, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		MissionsManager.instance.StartMission(316, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		Utils.DLIIAHACOJB(38);
		PlayerController.GetPlayer(1).gridController.disable = false;
		if (GameManager.LocalCoop())
		{
			PlayerController.GetPlayer(2).gridController.disable = false;
		}
		sceneFinished = true;
		while (Utils.NGLLIJPOBEC(Location.Road))
		{
			yield return null;
		}
		base.EndEvent(BGKCHMNJBLJ: false);
		((Component)SceneReferences.instance.customerPool).gameObject.SetActive(true);
		for (int i = 0; i < carriages.Length; i++)
		{
			instance.carriages[i].SetActive(false);
		}
		((Component)HikariNPC.GGFJGHHHEJC).transform.position = HikariNPC.GGFJGHHHEJC.beachPosition;
		HikariNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Down);
		HikariNPC.GGFJGHHHEJC.inScene = false;
		((Component)KentaNPC.GGFJGHHHEJC).transform.position = instance.PMHJMCIODBO[2];
		KentaNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Down);
		((Component)RinNPC.GGFJGHHHEJC).transform.position = instance.PMHJMCIODBO[3];
		RinNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Down);
		if (OnlineManager.MasterOrOffline())
		{
			((Behaviour)RinNPC.GGFJGHHHEJC.routine).enabled = true;
			RinNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
			((Behaviour)KentaNPC.GGFJGHHHEJC.routine).enabled = true;
			KentaNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
		}
		yield return CommonReferences.wait10;
		if (OnlineManager.MasterOrOffline())
		{
			((Behaviour)KujakuNPC.GGFJGHHHEJC.routine).enabled = true;
			KujakuNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
			((Behaviour)ZuzzuNPC.GGFJGHHHEJC.routine).enabled = true;
			ZuzzuNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
		}
		ZuzzuNPC.GGFJGHHHEJC.content.SetActive(true);
		((Component)ZuzzuNPC.GGFJGHHHEJC).transform.position = instance.PMHJMCIODBO[1];
		ZuzzuNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Down);
		KujakuNPC.GGFJGHHHEJC.playerCanInteract = true;
		ZuzzuNPC.GGFJGHHHEJC.playerCanInteract = true;
		PrecisionEvent.instance.ActivateEvent();
		BalanceEvent.instance.ActivateEvent();
	}

	private IEnumerator KGIDEMPHHOA()
	{
		return new JPEKGDEIACO(1);
	}

	public void ECCLPJDGOMD()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		instance.EDGDFPPKGDL = null;
		KujakuNPC.MAAAKALBBEE().MLACFFDPKPA(Vector2.op_Implicit(movePositions[8].position));
		ZuzzuNPC.JFNOOMJMHCB().POCIILOJOJD(Vector2.op_Implicit(movePositions[3].position));
	}

	private IEnumerator JLFHHHPPLDG()
	{
		return new HMNLFFCGBPC(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator BNHFBEOFPDB()
	{
		yield return CommonReferences.wait2;
		RightMovement();
		yield return CommonReferences.wait4;
		KujakuNPC.GGFJGHHHEJC.blockActionBar = false;
		instance.EDGDFPPKGDL = KujakuNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "DueloDeViejos/MainEvent3";
		if (instance.isActor)
		{
			KujakuNPC.GGFJGHHHEJC.StartConversation(1, "DueloDeViejos/MainEvent3");
		}
		else if (OnlineManager.PlayingOnline())
		{
			yield return KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	public void DOIBGJPOAPI()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		KujakuNPC.EKDNJDJHONF().animationBase.SetBool("UI", EGFGNGJGBOP: true);
		KujakuNPC.DEGPIHEEFHJ().animationBase.SetBool("itemRyeBread", EGFGNGJGBOP: true, HALNIEBONKH: true);
		ZuzzuNPC.DICHPHEOINO().animationBase.CGEADHOLHCH("v0.7.5", EGFGNGJGBOP: false);
		ZuzzuNPC.AHBBHCKPIIJ().animationBase.CGEADHOLHCH("FireUp", EGFGNGJGBOP: false, HALNIEBONKH: true);
		MultiAudioManager.PlayAudioObject(instance.kujakuLaugh, ((Component)KujakuNPC.EKDNJDJHONF()).transform.position);
		MultiAudioManager.PlayAudioObject(instance.zuzzuLaugh, ((Component)ZuzzuNPC.LFPEPJBNCBF()).transform.position);
		instance.IJLNHBOOFKL = 1978f;
		PsaiCore.Instance.HoldCurrentIntensity(hold: false);
		PsaiCore.Instance.AddToCurrentIntensity(438f);
		PsaiCore.Instance.HoldCurrentIntensity(hold: false);
	}

	public void OGGCOEPBHCL()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.BBJHMKFJLOK());
	}

	public void DOKAJOGBELA()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		KujakuNPC.EKDNJDJHONF().animationBase.SetDirection((Direction)8);
		ZuzzuNPC.CHKMFEFOFKJ().animationBase.SetDirection((Direction)6);
		KujakuNPC.GGFJGHHHEJC.animationBase.SetBool("Intro08", EGFGNGJGBOP: false);
		ZuzzuNPC.JFJOKGAOPHA().animationBase.CGEADHOLHCH("/resetsize: ", EGFGNGJGBOP: false, HALNIEBONKH: true);
		KujakuNPC.EKDNJDJHONF().HEACFLIHBBI(Vector2.op_Implicit(movePositions[0].position), Direction.Diagonal);
		ZuzzuNPC.JFNOOMJMHCB().DKGKJBJCADE(Vector2.op_Implicit(movePositions[1].position));
		((MonoBehaviour)instance).StartCoroutine(instance.AALIOJAFPAM());
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineEventsManager.SendOldMansDuelEndLaughAndMove();
		}
	}

	public void FNMHMAKJLHF()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		KujakuNPC.DEGPIHEEFHJ().animationBase.SetDirection(Direction.Down);
		ZuzzuNPC.JHMAMLIPBNN().animationBase.SetDirection((Direction)8);
		KujakuNPC.EKDNJDJHONF().animationBase.CGEADHOLHCH("No se encontró la base de datos maestra.", EGFGNGJGBOP: true);
		ZuzzuNPC.FJAMHCAAEAM().animationBase.SetBool("Items/item_description_1045", EGFGNGJGBOP: true);
		KujakuNPC.EKDNJDJHONF().HEACFLIHBBI(Vector2.op_Implicit(movePositions[0].position), Direction.Up, AMEOKNOLILB: true);
		ZuzzuNPC.EBAIHKJHCCA().AMOICFMHDCO(Vector2.op_Implicit(movePositions[0].position), Direction.Right, AMEOKNOLILB: true);
		((MonoBehaviour)instance).StartCoroutine(instance.FPJLOGEHKJL());
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendOldMansDuelEndLaughAndMove();
		}
	}

	private IEnumerator NEEKKKIBHFN()
	{
		return new LOBFLFPPEFF(1);
	}

	public void CEFBINJCIFA()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		KujakuNPC.LANAINBEMCM().animationBase.SetDirection((Direction)5);
		ZuzzuNPC.DICHPHEOINO().animationBase.SetDirection(Direction.Right);
		KujakuNPC.EKDNJDJHONF().animationBase.SetBool("ErrorJoinRoomClosed", EGFGNGJGBOP: false, HALNIEBONKH: true);
		ZuzzuNPC.EBAIHKJHCCA().animationBase.CGEADHOLHCH("FarmReady", EGFGNGJGBOP: false, HALNIEBONKH: true);
		KujakuNPC.GGFJGHHHEJC.MLACFFDPKPA(Vector2.op_Implicit(movePositions[0].position), (Direction)5, AMEOKNOLILB: true);
		ZuzzuNPC.EBAIHKJHCCA().DKGKJBJCADE(Vector2.op_Implicit(movePositions[0].position), Direction.Down, AMEOKNOLILB: true);
		((MonoBehaviour)instance).StartCoroutine(instance.MFACAJDJGGJ());
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineEventsManager.SendOldMansDuelEndLaughAndMove();
		}
	}

	private IEnumerator DBMMNEEMFAM()
	{
		return new NBOAFDJFLOM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator FPJLOGEHKJL()
	{
		return new BPONOCMNNID(1)
		{
			_003C_003E4__this = this
		};
	}

	public void EndWeaponsAnim()
	{
		instance.EDGDFPPKGDL = null;
		KujakuNPC.GGFJGHHHEJC.animationBase.SetBool("Weapon", EGFGNGJGBOP: false);
		KujakuNPC.GGFJGHHHEJC.animationBase.SetBool("WeaponEnd", EGFGNGJGBOP: true);
		ZuzzuNPC.GGFJGHHHEJC.animationBase.SetBool("Staff", EGFGNGJGBOP: false);
		ZuzzuNPC.GGFJGHHHEJC.animationBase.SetBool("StaffEnd", EGFGNGJGBOP: true);
	}

	public void HMHGKCBMPMM()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		KujakuNPC.DEGPIHEEFHJ().animationBase.SetBool("NinjaChallengeEvent/Main", EGFGNGJGBOP: false, HALNIEBONKH: true);
		KujakuNPC.GGFJGHHHEJC.animationBase.SetBool("Loop", EGFGNGJGBOP: false, HALNIEBONKH: true);
		ZuzzuNPC.FJAMHCAAEAM().animationBase.CGEADHOLHCH("", EGFGNGJGBOP: false, HALNIEBONKH: true);
		ZuzzuNPC.OAPOJCODNCO().animationBase.SetBool("Plant", EGFGNGJGBOP: false);
		MultiAudioManager.PlayAudioObject(instance.kujakuLaugh, ((Component)KujakuNPC.DEGPIHEEFHJ()).transform.position);
		MultiAudioManager.PlayAudioObject(instance.zuzzuLaugh, ((Component)ZuzzuNPC.JHMAMLIPBNN()).transform.position);
		instance.IJLNHBOOFKL = 997f;
		PsaiCore.Instance.HoldCurrentIntensity(hold: false);
		PsaiCore.Instance.AddToCurrentIntensity(186f);
		PsaiCore.Instance.HoldCurrentIntensity(hold: true);
	}

	public void NKHCJJPDBAC(int AAAIOBLCOFO)
	{
		Debug.Log((object)"Dialogue System/Conversation/Gass_Quest/Entry/30/Dialogue Text");
		TravelZone travelZone = TravelZonesManager.CFHEJAGKIII().GetTravelZone(Location.Tavern | Location.Road, Location.None);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(HPCKEOMOEAH));
		if (OnlineManager.PlayingOnline())
		{
			TravelZone travelZone2 = TravelZonesManager.EKDNJDJHONF().KCJMDAPPJLB(Location.Tavern | Location.Road, ~(Location.Tavern | Location.Road | Location.River | Location.Camp | Location.Farm));
			travelZone2.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone2.OnTravelZoneTo, new Action<int>(CGNFKCAMHLJ));
		}
		StartEvent(OnlineManager.MasterOrOffline(), CDPAMNIPPEC: true);
	}

	public void NKLCDJEDFIJ(int AAAIOBLCOFO)
	{
		Debug.Log((object)"Player");
		TravelZone travelZone = TravelZonesManager.GFMBEDCANNI().ECFDFECLDFK(Location.Tavern | Location.Road, Location.Tavern);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(LEMALDJGOKB));
		if (OnlineManager.PlayingOnline())
		{
			TravelZone travelZone2 = TravelZonesManager.DGCNCEDIFOF().NKEBECDKDOO(Location.Tavern | Location.Road, Location.Road | Location.Quarry | Location.Farm | Location.FarmShop);
			travelZone2.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone2.OnTravelZoneTo, new Action<int>(NKLCDJEDFIJ));
		}
		StartEvent(OnlineManager.MasterOrOffline(), CDPAMNIPPEC: true);
	}

	private IEnumerator JGPDBNJEJEA()
	{
		return new LOBFLFPPEFF(1);
	}

	private IEnumerator HMKNGHGLKHM()
	{
		return new NBOAFDJFLOM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void HLJAPAMBDDG(bool BGKCHMNJBLJ)
	{
		base.EndEvent(BGKCHMNJBLJ);
	}

	private IEnumerator FAGKFCCKCEA()
	{
		return new JPEKGDEIACO(1);
	}

	public void HDDLDCADENB()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		instance.EDGDFPPKGDL = null;
		KujakuNPC.MAAAKALBBEE().Walk(Vector2.op_Implicit(movePositions[8].position), (Direction)6, AMEOKNOLILB: true);
		ZuzzuNPC.PNHHCHJCDNM().KEKPJGNNHAJ(Vector2.op_Implicit(movePositions[0].position), Direction.Left);
	}
}
