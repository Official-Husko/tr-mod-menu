using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class HotBathEvent : GameEvent, IInteractable, IHoverable, IProximity
{
	[CompilerGenerated]
	private sealed class KEOJDGLFAFA : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HotBathEvent _003C_003E4__this;

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
		public KEOJDGLFAFA(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			HotBathEvent hotBathEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
			{
				_003C_003E1__state = -1;
				TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Quarry, Location.Road);
				travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(hotBathEvent.IFANGKBFGKF));
				TravelZone travelZone2 = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Quarry, Location.Bathhouse);
				travelZone2.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone2.OnTravelZoneTo, new Action<int>(hotBathEvent.IFANGKBFGKF));
				TravelZone travelZone3 = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Quarry, Location.QuarryCave);
				travelZone3.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone3.OnTravelZoneTo, new Action<int>(hotBathEvent.IFANGKBFGKF));
				if (OnlineManager.MasterOrOffline())
				{
					FerroNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(instance.ferroMovePosition.position), Direction.Left);
				}
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 1;
				return true;
			}
			case 1:
				_003C_003E1__state = -1;
				if (Utils.AHMPFOEGJHF(Location.Quarry))
				{
					FadeCamera.GetPlayer(1).FadeOut();
					FadeCamera.GetPlayer(1).JDKHJJIOLOE += hotBathEvent.HHGEKEKHDNK;
				}
				if (Utils.AHMPFOEGJHF(Location.Quarry, 2) && GameManager.LocalCoop())
				{
					FadeCamera.GetPlayer(2).FadeOut();
					if (!Utils.AHMPFOEGJHF(Location.Quarry))
					{
						FadeCamera.GetPlayer(2).JDKHJJIOLOE += hotBathEvent.HHGEKEKHDNK;
					}
				}
				if (!Utils.AHMPFOEGJHF(Location.Quarry))
				{
					_003C_003E2__current = CommonReferences.wait10;
					_003C_003E1__state = 2;
					return true;
				}
				break;
			case 2:
				_003C_003E1__state = -1;
				hotBathEvent.EndEventOutOfMap();
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
	private sealed class NBGKFAGMEBN : IEnumerator<object>, IEnumerator, IDisposable
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
		public NBGKFAGMEBN(int _003C_003E1__state)
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
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				FerroNPC.GGFJGHHHEJC.animationBase.SetTrigger("Jump");
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				FerroNPC.GGFJGHHHEJC.inSpecialEvent = false;
				FerroNPC.GGFJGHHHEJC.blockActionBar = false;
				instance.EDGDFPPKGDL = FerroNPC.GGFJGHHHEJC;
				instance.MDFALJKHKED = "HotBath/Main 3";
				if (instance.isActor)
				{
					FerroNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "HotBath/Main 3");
				}
				else if (Utils.AHMPFOEGJHF(Location.Quarry))
				{
					((MonoBehaviour)instance).StartCoroutine(FerroNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
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
	private sealed class LHHPPAOHPEE : IEnumerator<object>, IEnumerator, IDisposable
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
		public LHHPPAOHPEE(int _003C_003E1__state)
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
				FerroNPC.GGFJGHHHEJC.animationBase.SetTrigger("Jump");
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				instance.EDGDFPPKGDL = FerroNPC.GGFJGHHHEJC;
				instance.MDFALJKHKED = "HotBath/Main 2";
				if (instance.isActor)
				{
					FerroNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "HotBath/Main 2");
				}
				else if (Utils.AHMPFOEGJHF(Location.Quarry))
				{
					((MonoBehaviour)instance).StartCoroutine(FerroNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
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
	private sealed class LNKOAFPNMON : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HotBathEvent _003C_003E4__this;

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
		public LNKOAFPNMON(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_015b: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_0117: Unknown result type (might be due to invalid IL or missing references)
			//IL_011c: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			HotBathEvent hotBathEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				if (instance.isActor)
				{
					PlayerController.GetPlayer(hotBathEvent.CJODOOFLLLB).GoToPosition(Vector2.op_Implicit(hotBathEvent.playerPosition.position), KLGOCJMGKFO: true);
					goto IL_007c;
				}
				goto IL_00b5;
			case 1:
				_003C_003E1__state = -1;
				goto IL_007c;
			case 2:
				_003C_003E1__state = -1;
				goto IL_00d9;
			case 3:
				_003C_003E1__state = -1;
				FerroNPC.GGFJGHHHEJC.content.SetActive(true);
				FerroNPC.GGFJGHHHEJC.animationBase.SetTrigger("Unfreeze");
				FerroNPC.GGFJGHHHEJC.animationBase.SetBool("Freeze", EGFGNGJGBOP: false, HALNIEBONKH: true);
				((Component)FerroNPC.GGFJGHHHEJC).transform.parent = null;
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 4;
				return true;
			case 4:
				_003C_003E1__state = -1;
				instance.MDAPOJADLIN();
				_003C_003E2__current = CommonReferences.wait2_5;
				_003C_003E1__state = 5;
				return true;
			case 5:
				{
					_003C_003E1__state = -1;
					Utils.DLIIAHACOJB(46, CDPAMNIPPEC: true);
					instance.ice.gameObject.SetActive(false);
					FerroNPC.GGFJGHHHEJC.barkDialogue = false;
					FerroNPC.GGFJGHHHEJC.inSpecialEvent = true;
					FerroNPC.GGFJGHHHEJC.blockActionBar = true;
					instance.EDGDFPPKGDL = FerroNPC.GGFJGHHHEJC;
					instance.MDFALJKHKED = "HotBath/Main";
					if (instance.isActor)
					{
						FerroNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "HotBath/Main");
					}
					else if (Utils.AHMPFOEGJHF(Location.Quarry))
					{
						((MonoBehaviour)instance).StartCoroutine(FerroNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
					}
					return false;
				}
				IL_007c:
				if (!PlayerController.GetPlayer(hotBathEvent.CJODOOFLLLB).GoToPosition(Vector2.op_Implicit(hotBathEvent.playerPosition.position), KLGOCJMGKFO: false))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
				PlayerController.GetPlayer(hotBathEvent.CJODOOFLLLB).characterAnimation.SetDirection(Direction.Up);
				goto IL_00b5;
				IL_00d9:
				Debug.Log((object)"IntroFerroCoroutine started");
				if (Utils.AHMPFOEGJHF(Location.Quarry))
				{
					DialogueCameraTarget.GetPlayer(instance.CJODOOFLLLB).cameraInEvent = true;
					DialogueCameraTarget.GetPlayer(instance.CJODOOFLLLB).MoveCameraToPositionFromCameraTarget(Vector2.op_Implicit(hotBathEvent.cameraPosition.position));
				}
				hotBathEvent.iceAnimator.SetTrigger("Melt");
				FerroNPC.GGFJGHHHEJC.content.SetActive(true);
				((Component)FerroNPC.GGFJGHHHEJC).transform.position = hotBathEvent.ferroFreezePosition.position;
				FerroNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Down);
				FerroNPC.GGFJGHHHEJC.animationBase.SetBool("Freeze", EGFGNGJGBOP: true, HALNIEBONKH: true);
				((Component)FerroNPC.GGFJGHHHEJC).transform.parent = instance.iceParent;
				((Component)FerroNPC.GGFJGHHHEJC).transform.localPosition = Vector3.zero;
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 3;
				return true;
				IL_00b5:
				if (Utils.MMMFJPKECAB(Location.Quarry))
				{
					_003C_003E2__current = OnlineManager.WaitForAllPlayers();
					_003C_003E1__state = 2;
					return true;
				}
				goto IL_00d9;
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
	private sealed class GCMEFKAGLAE : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HotBathEvent _003C_003E4__this;

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
		public GCMEFKAGLAE(int _003C_003E1__state)
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
			HotBathEvent hotBathEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
			{
				_003C_003E1__state = -1;
				FadeCamera player = FadeCamera.GetPlayer(1);
				player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(hotBathEvent.GEHNCBAJNKP));
				if (GameManager.LocalCoop())
				{
					FadeCamera player2 = FadeCamera.GetPlayer(2);
					player2.OnFadeFinished = (Action<int>)Delegate.Remove(player2.OnFadeFinished, new Action<int>(hotBathEvent.GEHNCBAJNKP));
				}
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 1;
				return true;
			}
			case 1:
				_003C_003E1__state = -1;
				PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
				if (Utils.AHMPFOEGJHF(Location.Quarry))
				{
					DialogueCameraTarget.GetPlayer(1).ReturnControlToCameraTarget();
				}
				if (GameManager.LocalCoop() && Utils.AHMPFOEGJHF(Location.Quarry, 2))
				{
					LocalCooperativeManager.RestoreCameraInLocalCoop();
					DialogueCameraTarget.GetPlayer(2).ReturnControlToCameraTarget();
				}
				if (GameManager.LocalCoop())
				{
					hotBathEvent.RemoveAllTravelZonesCallbacks(Location.Quarry);
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
	private sealed class IABGCALFCGB : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HotBathEvent _003C_003E4__this;

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
		public IABGCALFCGB(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_012a: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			HotBathEvent hotBathEvent = _003C_003E4__this;
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
				FadeCamera.GetPlayer(1).JDKHJJIOLOE -= hotBathEvent.HHGEKEKHDNK;
				if (GameManager.LocalCoop())
				{
					FadeCamera.GetPlayer(2).JDKHJJIOLOE -= hotBathEvent.HHGEKEKHDNK;
				}
				FerroNPC.GGFJGHHHEJC.ferroEvent = true;
				CliveNPC.GGFJGHHHEJC.ferroEvent = true;
				RochelleNPC.GGFJGHHHEJC.ferroEvent = true;
				BrockNPC.GGFJGHHHEJC.ferroEvent = true;
				RochelleNPC.GGFJGHHHEJC.animationBase.SetBool("IdleCamp", EGFGNGJGBOP: true);
				DialogueLua.SetVariable("MineFloor", (object)1);
				DialogueLua.SetVariable("RochelleProgress", (object)1);
				DialogueLua.SetVariable("FerroProgress", (object)1);
				DialogueLua.SetVariable("BrockProgress", (object)1);
				DialogueLua.SetVariable("MineState", (object)2);
				FerroNPC.GGFJGHHHEJC.walkTo.JKGGEMBAPAJ();
				((Component)FerroNPC.GGFJGHHHEJC).transform.position = hotBathEvent.ferroMovePosition.position;
				FerroNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Down);
				FerroNPC.GGFJGHHHEJC.animationBase.SetBool("IdleCamp", EGFGNGJGBOP: true);
				FerroNPC.GGFJGHHHEJC.playerCanInteract = true;
				CommonReferences instance = CommonReferences.GGFJGHHHEJC;
				instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(hotBathEvent.IFHFNDELKOP));
				if (Utils.MMMFJPKECAB(Location.Quarry))
				{
					_003C_003E2__current = OnlineManager.WaitForAllPlayers();
					_003C_003E1__state = 2;
					return true;
				}
				break;
			}
			case 2:
				_003C_003E1__state = -1;
				break;
			}
			if (Utils.AHMPFOEGJHF(Location.Quarry))
			{
				FadeCamera.GetPlayer(1).FadeInWithDelay();
				FadeCamera player = FadeCamera.GetPlayer(1);
				player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(hotBathEvent.GEHNCBAJNKP));
			}
			if (Utils.AHMPFOEGJHF(Location.Quarry, 2) && GameManager.LocalCoop())
			{
				FadeCamera.GetPlayer(2).FadeInWithDelay();
				if (!Utils.AHMPFOEGJHF(Location.Quarry))
				{
					FadeCamera player2 = FadeCamera.GetPlayer(2);
					player2.OnFadeFinished = (Action<int>)Delegate.Combine(player2.OnFadeFinished, new Action<int>(hotBathEvent.GEHNCBAJNKP));
				}
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
	private sealed class IEBKFHGOGKE : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public HotBathEvent _003C_003E4__this;

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
		public IEBKFHGOGKE(int _003C_003E1__state)
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
			HotBathEvent hotBathEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait3_5;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				hotBathEvent.NNLHCAJDGCD = true;
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

	public static HotBathEvent instance;

	public GameObject inputByProximity;

	public GameObject ice;

	public Animator iceAnimator;

	public Transform iceParent;

	public Transform ferroFreezePosition;

	public Transform ferroMovePosition;

	public Transform playerPosition;

	private bool NNLHCAJDGCD = true;

	private Coroutine CEACJENCFNF;

	public Transform endPointFall;

	public float durationFall = 2f;

	public float desacelerationFall = 2f;

	private float OAKMHJBMJJM;

	[SerializeField]
	private bool movingFall;

	private Vector3 FBDPMGHMHIP;

	private Vector3 LAPILKLAEAC;

	public bool LOCIBONDBGF(int JIIGOACEIKL)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		if (!IsAvailableByProximity(JIIGOACEIKL))
		{
			return false;
		}
		NNLHCAJDGCD = false;
		CommonReferences.GGFJGHHHEJC.eventNum[8] += 0;
		CommonReferences.MNFMOEKMJKN().OnActionDone(0, (ActionDone)105);
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.ferroIceMelting, ferroFreezePosition.position);
		if (CommonReferences.GGFJGHHHEJC.eventNum[4] == 0)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark("Dialogue System/Conversation/Crowly_Introduce/Entry/15/Dialogue Text");
			iceAnimator.SetTrigger(" has null in variant objects list.");
		}
		else if (CommonReferences.MNFMOEKMJKN().eventNum[4] == 5)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).PlayerBark("Input field already has console support component: {0}");
			iceAnimator.SetTrigger("Player");
		}
		else if (CommonReferences.MNFMOEKMJKN().eventNum[0] == 4)
		{
			instance.CJODOOFLLLB = JIIGOACEIKL;
			IGDCLHMBFKF();
		}
		PlayerInventory.IOAIPCDECME(JIIGOACEIKL, -15, 1);
		PlayerInventory.NEKDDPIAOBE(JIIGOACEIKL).OJDGOADOCMG(ItemDatabaseAccessor.EABMGELAAPG(72).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false, EHGHJNOFMKF: false);
		((MonoBehaviour)instance).StartCoroutine(LJLFPBGIGBD());
		if (OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendPourWater();
		}
		return false;
	}

	private void IDPHKHGHJGN()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(BGPGIOMKKAO));
		}
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

	public override GameEvent GetInstance()
	{
		return instance;
	}

	public void CDNPCGKAGLI(int JIIGOACEIKL)
	{
	}

	private IEnumerator AGJLKACCPLG()
	{
		yield return CommonReferences.wait05;
		FerroNPC.GGFJGHHHEJC.animationBase.SetTrigger("Jump");
		yield return CommonReferences.wait1;
		FerroNPC.GGFJGHHHEJC.inSpecialEvent = false;
		FerroNPC.GGFJGHHHEJC.blockActionBar = false;
		instance.EDGDFPPKGDL = FerroNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "HotBath/Main 3";
		if (instance.isActor)
		{
			FerroNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "HotBath/Main 3");
		}
		else if (Utils.AHMPFOEGJHF(Location.Quarry))
		{
			((MonoBehaviour)instance).StartCoroutine(FerroNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private IEnumerator DOKOLLCNIIM(int JIIGOACEIKL)
	{
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(GEHNCBAJNKP));
		if (GameManager.LocalCoop())
		{
			FadeCamera player2 = FadeCamera.GetPlayer(2);
			player2.OnFadeFinished = (Action<int>)Delegate.Remove(player2.OnFadeFinished, new Action<int>(GEHNCBAJNKP));
		}
		yield return CommonReferences.wait05;
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		if (Utils.AHMPFOEGJHF(Location.Quarry))
		{
			DialogueCameraTarget.GetPlayer(1).ReturnControlToCameraTarget();
		}
		if (GameManager.LocalCoop() && Utils.AHMPFOEGJHF(Location.Quarry, 2))
		{
			LocalCooperativeManager.RestoreCameraInLocalCoop();
			DialogueCameraTarget.GetPlayer(2).ReturnControlToCameraTarget();
		}
		if (GameManager.LocalCoop())
		{
			RemoveAllTravelZonesCallbacks(Location.Quarry);
		}
	}

	private void GMLFGAKIEAD()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(GMLFGAKIEAD));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(BGPGIOMKKAO));
		}
		if (!EventsManager.BBMAEAFHEFK((EventsManager.EventType)(-162)) && !EventsManager.ALEMDEBCFDH((EventsManager.EventType)(-171)))
		{
			FNNGDCGNINJ();
		}
		if (EventsManager.HGALHLALOKJ((EventsManager.EventType)158))
		{
			inputByProximity.SetActive(true);
			ice.SetActive(true);
		}
	}

	private IEnumerator INBEOFEFGOF(int JIIGOACEIKL)
	{
		return new IABGCALFCGB(1)
		{
			_003C_003E4__this = this
		};
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		if (!DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH && PlayerInventory.GetPlayer(JIIGOACEIKL).HasItem(1962) && CommonReferences.GGFJGHHHEJC.eventNum[4] < 3)
		{
			return NNLHCAJDGCD;
		}
		return false;
	}

	public void LFDBCGGIPOM(int JIIGOACEIKL)
	{
	}

	public void EndEventOutOfMap()
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		FerroNPC.GGFJGHHHEJC.ferroEvent = true;
		CliveNPC.GGFJGHHHEJC.ferroEvent = true;
		RochelleNPC.GGFJGHHHEJC.ferroEvent = true;
		BrockNPC.GGFJGHHHEJC.ferroEvent = true;
		DialogueLua.SetVariable("MineFloor", (object)1);
		DialogueLua.SetVariable("RochelleProgress", (object)1);
		DialogueLua.SetVariable("FerroProgress", (object)1);
		DialogueLua.SetVariable("BrockProgress", (object)1);
		DialogueLua.SetVariable("MineState", (object)2);
		((Component)FerroNPC.GGFJGHHHEJC).transform.position = ferroMovePosition.position;
		FerroNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Down);
		FerroNPC.GGFJGHHHEJC.animationBase.SetBool("IdleCamp", EGFGNGJGBOP: true, HALNIEBONKH: true);
		FerroNPC.GGFJGHHHEJC.playerCanInteract = true;
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(IFHFNDELKOP));
	}

	private IEnumerator JMHAHACFLLN(int JIIGOACEIKL)
	{
		return new IABGCALFCGB(1)
		{
			_003C_003E4__this = this
		};
	}

	public void JBAMJKJNMHG(int JIIGOACEIKL)
	{
	}

	private void CHIMNJLPCPO()
	{
		FNNGDCGNINJ();
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		return true;
	}

	public void LKKFFMFNHCE()
	{
		((MonoBehaviour)instance).StartCoroutine(GHMIGFJAGAC());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.JELFEKMGPNM();
		}
	}

	private IEnumerator EKEILEOIJFM(int JIIGOACEIKL)
	{
		return new GCMEFKAGLAE(1)
		{
			_003C_003E4__this = this
		};
	}

	private void FILEBNNDLLM()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(IELNMIMCJMO));
		FerroNPC.MLPCDJPLBAC().ferroEvent = true;
		CliveNPC.PEJFACMBPBN().ferroEvent = false;
		RochelleNPC.CNDNOECMKME().ferroEvent = true;
		BrockNPC.HNNJEBNIPOI().ferroEvent = false;
		RochelleNPC.FOPGLLMEEDE().animationBase.SetBool("repUnlockUpgrades", EGFGNGJGBOP: true, HALNIEBONKH: true);
		MinersManager.instance.PNJOKEMGEHF();
		CliveNPC.KNLLFEJAMNN().CheckExclamationSendOnline(sendOnline: false);
		FerroNPC.GGFJGHHHEJC.CheckExclamationSendOnline(sendOnline: false);
	}

	private IEnumerator LDLMKJCDLFJ()
	{
		FerroNPC.GGFJGHHHEJC.animationBase.SetTrigger("Jump");
		yield return CommonReferences.wait1;
		instance.EDGDFPPKGDL = FerroNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "HotBath/Main 2";
		if (instance.isActor)
		{
			FerroNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "HotBath/Main 2");
		}
		else if (Utils.AHMPFOEGJHF(Location.Quarry))
		{
			((MonoBehaviour)instance).StartCoroutine(FerroNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	public void OEABDBJMEHI()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		NNLHCAJDGCD = false;
		CommonReferences.GGFJGHHHEJC.eventNum[4] += 0;
		CommonReferences.GGFJGHHHEJC.OnActionDone(1, (ActionDone)(-116));
		MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().ferroIceMelting, ferroFreezePosition.position);
		if (CommonReferences.GGFJGHHHEJC.eventNum[1] == 1)
		{
			iceAnimator.SetTrigger("input info");
		}
		else if (CommonReferences.GGFJGHHHEJC.eventNum[7] == 1)
		{
			iceAnimator.SetTrigger("Body_Extra");
		}
		((MonoBehaviour)instance).StartCoroutine(LJLFPBGIGBD());
	}

	public void BBIAGBIAELE(int JIIGOACEIKL)
	{
	}

	private IEnumerator LJLFPBGIGBD()
	{
		yield return CommonReferences.wait3_5;
		NNLHCAJDGCD = true;
	}

	public void DOKKHJCMIDD()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		NNLHCAJDGCD = true;
		CommonReferences.GGFJGHHHEJC.eventNum[5] += 0;
		CommonReferences.MNFMOEKMJKN().OnActionDone(1, (ActionDone)127);
		MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().ferroIceMelting, ferroFreezePosition.position);
		if (CommonReferences.MNFMOEKMJKN().eventNum[4] == 1)
		{
			iceAnimator.SetTrigger("ReceiveBarkInfoWithObject");
		}
		else if (CommonReferences.MNFMOEKMJKN().eventNum[5] == 0)
		{
			iceAnimator.SetTrigger("Disabled");
		}
		((MonoBehaviour)instance).StartCoroutine(LJLFPBGIGBD());
	}

	private IEnumerator PHDADHEBFNC()
	{
		yield return CommonReferences.wait05;
		FerroNPC.GGFJGHHHEJC.animationBase.SetTrigger("Jump");
		yield return CommonReferences.wait1;
		FerroNPC.GGFJGHHHEJC.inSpecialEvent = false;
		FerroNPC.GGFJGHHHEJC.blockActionBar = false;
		instance.EDGDFPPKGDL = FerroNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "HotBath/Main 3";
		if (instance.isActor)
		{
			FerroNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "HotBath/Main 3");
		}
		else if (Utils.AHMPFOEGJHF(Location.Quarry))
		{
			((MonoBehaviour)instance).StartCoroutine(FerroNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private void MDAPOJADLIN()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		FBDPMGHMHIP = ferroFreezePosition.position;
		LAPILKLAEAC = endPointFall.position;
		OAKMHJBMJJM = 0f;
		movingFall = true;
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		if (!IsAvailableByProximity(JIIGOACEIKL))
		{
			return false;
		}
		NNLHCAJDGCD = false;
		CommonReferences.GGFJGHHHEJC.eventNum[4]++;
		CommonReferences.GGFJGHHHEJC.OnActionDone(1, ActionDone.UnfreezeFerro);
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.ferroIceMelting, ferroFreezePosition.position);
		if (CommonReferences.GGFJGHHHEJC.eventNum[4] == 1)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark("HotBath/Bark");
			iceAnimator.SetTrigger("Melt");
		}
		else if (CommonReferences.GGFJGHHHEJC.eventNum[4] == 2)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark("HotBath/Bark 2");
			iceAnimator.SetTrigger("Melt");
		}
		else if (CommonReferences.GGFJGHHHEJC.eventNum[4] == 3)
		{
			instance.CJODOOFLLLB = JIIGOACEIKL;
			IGDCLHMBFKF();
		}
		PlayerInventory.RemoveItems(JIIGOACEIKL, 1962, 1);
		PlayerInventory.GetPlayer(JIIGOACEIKL).AddItem(ItemDatabaseAccessor.GetItem(1961).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
		((MonoBehaviour)instance).StartCoroutine(LJLFPBGIGBD());
		if (OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendPourWater();
		}
		return true;
	}

	private void NPCPLINCDLO()
	{
		if (OnlineManager.MasterOrOffline())
		{
			GameManager gameManager = GameManager.GGFJGHHHEJC;
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(GMLFGAKIEAD));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(NPCPLINCDLO));
		}
		if (!EventsManager.NKMELJPGOBB((EventsManager.EventType)(-99)) && !EventsManager.OMNBJDPGPEN((EventsManager.EventType)28))
		{
			NMOOFGAHBEN();
		}
		if (EventsManager.AEFHILOAEEE((EventsManager.EventType)63))
		{
			inputByProximity.SetActive(true);
			ice.SetActive(false);
		}
	}

	private IEnumerator HHGEKEKHDNK(int JIIGOACEIKL)
	{
		yield return CommonReferences.wait1;
		FadeCamera.GetPlayer(1).JDKHJJIOLOE -= HHGEKEKHDNK;
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).JDKHJJIOLOE -= HHGEKEKHDNK;
		}
		FerroNPC.GGFJGHHHEJC.ferroEvent = true;
		CliveNPC.GGFJGHHHEJC.ferroEvent = true;
		RochelleNPC.GGFJGHHHEJC.ferroEvent = true;
		BrockNPC.GGFJGHHHEJC.ferroEvent = true;
		RochelleNPC.GGFJGHHHEJC.animationBase.SetBool("IdleCamp", EGFGNGJGBOP: true);
		DialogueLua.SetVariable("MineFloor", (object)1);
		DialogueLua.SetVariable("RochelleProgress", (object)1);
		DialogueLua.SetVariable("FerroProgress", (object)1);
		DialogueLua.SetVariable("BrockProgress", (object)1);
		DialogueLua.SetVariable("MineState", (object)2);
		FerroNPC.GGFJGHHHEJC.walkTo.JKGGEMBAPAJ();
		((Component)FerroNPC.GGFJGHHHEJC).transform.position = ferroMovePosition.position;
		FerroNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Down);
		FerroNPC.GGFJGHHHEJC.animationBase.SetBool("IdleCamp", EGFGNGJGBOP: true);
		FerroNPC.GGFJGHHHEJC.playerCanInteract = true;
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(IFHFNDELKOP));
		if (Utils.MMMFJPKECAB(Location.Quarry))
		{
			yield return OnlineManager.WaitForAllPlayers();
		}
		if (Utils.AHMPFOEGJHF(Location.Quarry))
		{
			FadeCamera.GetPlayer(1).FadeInWithDelay();
			FadeCamera player = FadeCamera.GetPlayer(1);
			player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(GEHNCBAJNKP));
		}
		if (Utils.AHMPFOEGJHF(Location.Quarry, 2) && GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeInWithDelay();
			if (!Utils.AHMPFOEGJHF(Location.Quarry))
			{
				FadeCamera player2 = FadeCamera.GetPlayer(2);
				player2.OnFadeFinished = (Action<int>)Delegate.Combine(player2.OnFadeFinished, new Action<int>(GEHNCBAJNKP));
			}
		}
	}

	public void FerroJump2()
	{
		((MonoBehaviour)instance).StartCoroutine(PHDADHEBFNC());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendJumpFerro2();
		}
	}

	public bool JJANBHCGKOJ(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (IsAvailableByProximity(JIIGOACEIKL) && !IIEDALMMNLI)
		{
			ButtonsContext.SetPosition(JIIGOACEIKL, PlayerController.GetPlayerPosition(JIIGOACEIKL) + Vector3.up * 1f);
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("PourWater"));
			return true;
		}
		return false;
	}

	private IEnumerator HKIPKDFIGFE(int JIIGOACEIKL)
	{
		yield return CommonReferences.wait1;
		FadeCamera.GetPlayer(1).JDKHJJIOLOE -= HHGEKEKHDNK;
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).JDKHJJIOLOE -= HHGEKEKHDNK;
		}
		FerroNPC.GGFJGHHHEJC.ferroEvent = true;
		CliveNPC.GGFJGHHHEJC.ferroEvent = true;
		RochelleNPC.GGFJGHHHEJC.ferroEvent = true;
		BrockNPC.GGFJGHHHEJC.ferroEvent = true;
		RochelleNPC.GGFJGHHHEJC.animationBase.SetBool("IdleCamp", EGFGNGJGBOP: true);
		DialogueLua.SetVariable("MineFloor", (object)1);
		DialogueLua.SetVariable("RochelleProgress", (object)1);
		DialogueLua.SetVariable("FerroProgress", (object)1);
		DialogueLua.SetVariable("BrockProgress", (object)1);
		DialogueLua.SetVariable("MineState", (object)2);
		FerroNPC.GGFJGHHHEJC.walkTo.JKGGEMBAPAJ();
		((Component)FerroNPC.GGFJGHHHEJC).transform.position = ferroMovePosition.position;
		FerroNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Down);
		FerroNPC.GGFJGHHHEJC.animationBase.SetBool("IdleCamp", EGFGNGJGBOP: true);
		FerroNPC.GGFJGHHHEJC.playerCanInteract = true;
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(IFHFNDELKOP));
		if (Utils.MMMFJPKECAB(Location.Quarry))
		{
			yield return OnlineManager.WaitForAllPlayers();
		}
		if (Utils.AHMPFOEGJHF(Location.Quarry))
		{
			FadeCamera.GetPlayer(1).FadeInWithDelay();
			FadeCamera player = FadeCamera.GetPlayer(1);
			player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(GEHNCBAJNKP));
		}
		if (Utils.AHMPFOEGJHF(Location.Quarry, 2) && GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeInWithDelay();
			if (!Utils.AHMPFOEGJHF(Location.Quarry))
			{
				FadeCamera player2 = FadeCamera.GetPlayer(2);
				player2.OnFadeFinished = (Action<int>)Delegate.Combine(player2.OnFadeFinished, new Action<int>(GEHNCBAJNKP));
			}
		}
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
	}

	private void NCBMDINLLOP()
	{
		StartEvent(BFLCJPHHDJM: true, CDPAMNIPPEC: true);
	}

	public void IDEMEHDCPMC()
	{
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		FerroNPC.GGFJGHHHEJC.ferroEvent = true;
		CliveNPC.HKBJIIJHBJB().ferroEvent = false;
		RochelleNPC.JFNOOMJMHCB().ferroEvent = true;
		BrockNPC.BADFKMEJOKE().ferroEvent = false;
		DialogueLua.SetVariable("FallRight", (object)1);
		DialogueLua.SetVariable("MineFloor", (object)0);
		DialogueLua.SetVariable("Floor_5", (object)1);
		DialogueLua.SetVariable("F1", (object)1);
		DialogueLua.SetVariable("DogNPC instance is null", (object)3);
		((Component)FerroNPC.GGFJGHHHEJC).transform.position = ferroMovePosition.position;
		FerroNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Up);
		FerroNPC.MLPCDJPLBAC().animationBase.CGEADHOLHCH("mForMins", EGFGNGJGBOP: false);
		FerroNPC.GGFJGHHHEJC.playerCanInteract = false;
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(FILEBNNDLLM));
	}

	private void ICBJCKIGMKF(int AAAIOBLCOFO)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		DialogueCameraTarget.GetPlayer(instance.CJODOOFLLLB).cameraInEvent = false;
		DialogueCameraTarget.DACNEICGAAE(instance.CJODOOFLLLB).OCOMNGMLHIB(Vector2.op_Implicit(cameraPosition.position), 710f);
		((MonoBehaviour)instance).StartCoroutine(FerroNPC.MLPCDJPLBAC().StartObserverDialogueWhenItIsPossible(1));
	}

	private void GIHNJCGDCIF()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		if (movingFall && !OnlineManager.ClientOnline())
		{
			OAKMHJBMJJM += Time.deltaTime;
			float num = Mathf.Clamp01(OAKMHJBMJJM / durationFall);
			float num2 = 1f - Mathf.Pow(1f - num, desacelerationFall);
			((Component)FerroNPC.GGFJGHHHEJC).transform.position = Vector3.Lerp(FBDPMGHMHIP, LAPILKLAEAC, num2);
			if (num >= 1f)
			{
				((Component)FerroNPC.GGFJGHHHEJC).transform.position = LAPILKLAEAC;
				movingFall = false;
			}
		}
	}

	public bool GFMLDGEKMHA(int JIIGOACEIKL)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		if (!IsAvailableByProximity(JIIGOACEIKL))
		{
			return true;
		}
		NNLHCAJDGCD = false;
		CommonReferences.GGFJGHHHEJC.eventNum[7]++;
		CommonReferences.GGFJGHHHEJC.OnActionDone(1, (ActionDone)78);
		MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().ferroIceMelting, ferroFreezePosition.position);
		if (CommonReferences.GGFJGHHHEJC.eventNum[1] == 0)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).PlayerBark("ButtonPause");
			iceAnimator.SetTrigger("Move Right");
		}
		else if (CommonReferences.GGFJGHHHEJC.eventNum[1] == 0)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).PlayerBark("Send begin retry");
			iceAnimator.SetTrigger("UINextCategory");
		}
		else if (CommonReferences.GGFJGHHHEJC.eventNum[8] == 2)
		{
			instance.CJODOOFLLLB = JIIGOACEIKL;
			IGDCLHMBFKF();
		}
		PlayerInventory.RemoveItems(JIIGOACEIKL, -108, 0, CDPAMNIPPEC: false);
		PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).OJDGOADOCMG(ItemDatabaseAccessor.CPMMBEPEJLO(-67, GGBBJNBBLMF: true).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: false, EHGHJNOFMKF: false);
		((MonoBehaviour)instance).StartCoroutine(LJLFPBGIGBD());
		if (OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendPourWater();
		}
		return true;
	}

	private void NKJNEDEKFNF()
	{
		instance.ice.gameObject.SetActive(false);
		iceAnimator.SetInteger("\n", CommonReferences.MNFMOEKMJKN().eventNum[1]);
		((Behaviour)FerroNPC.GGFJGHHHEJC.simpleAnimation).enabled = true;
		((Behaviour)FerroNPC.MLPCDJPLBAC().animationController).enabled = true;
		FerroNPC.GGFJGHHHEJC.playerCanInteract = true;
	}

	private void OLDCOMPNLAJ()
	{
		NMOOFGAHBEN();
	}

	public override void ActivateEvent()
	{
		base.ActivateEvent();
		inputByProximity.SetActive(true);
		FNNGDCGNINJ();
		if (CEACJENCFNF == null)
		{
			CEACJENCFNF = ((MonoBehaviour)this).StartCoroutine(HHDCGKGFIAA());
		}
	}

	private void EELJLJHHDDA(int AAAIOBLCOFO)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		DialogueCameraTarget.HHONLOCNFNC(instance.CJODOOFLLLB).cameraInEvent = true;
		DialogueCameraTarget.PDLEDGLONGO(instance.CJODOOFLLLB).NNKFFOJCACK(Vector2.op_Implicit(cameraPosition.position), 1465f);
		((MonoBehaviour)instance).StartCoroutine(FerroNPC.MLPCDJPLBAC().StartObserverDialogueWhenItIsPossible(1));
	}

	public bool DKLAKIBJKID(int JIIGOACEIKL)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		if (!IsAvailableByProximity(JIIGOACEIKL))
		{
			return false;
		}
		NNLHCAJDGCD = false;
		CommonReferences.GGFJGHHHEJC.eventNum[0]++;
		CommonReferences.MNFMOEKMJKN().OnActionDone(0, (ActionDone)(-50));
		MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().ferroIceMelting, ferroFreezePosition.position);
		if (CommonReferences.MNFMOEKMJKN().eventNum[8] == 0)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).PlayerBark("LE_10");
			iceAnimator.SetTrigger("ReceiveEmployeeTask");
		}
		else if (CommonReferences.GGFJGHHHEJC.eventNum[6] == 6)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).PlayerBark("Left Alt");
			iceAnimator.SetTrigger("SetUpOptions");
		}
		else if (CommonReferences.GGFJGHHHEJC.eventNum[3] == 3)
		{
			instance.CJODOOFLLLB = JIIGOACEIKL;
			IGDCLHMBFKF();
		}
		PlayerInventory.RemoveItems(JIIGOACEIKL, -13, 0);
		PlayerInventory.OGKNJNINGMH(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AddItem(ItemDatabaseAccessor.AFOACBIHNCL(-102, GGBBJNBBLMF: true).JMDALJBNFML(), HMPDLIPFBGD: true);
		((MonoBehaviour)instance).StartCoroutine(BJPHDFADNHN());
		if (OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendPourWater();
		}
		return false;
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool OHGLJCKNBFB(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (IsAvailableByProximity(JIIGOACEIKL) && !IIEDALMMNLI)
		{
			ButtonsContext.SetPosition(JIIGOACEIKL, PlayerController.GetPlayerPosition(JIIGOACEIKL) + Vector3.up * 369f);
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Colliders encontrados: "));
			return true;
		}
		return false;
	}

	private void IFHFNDELKOP()
	{
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(IFHFNDELKOP));
		FerroNPC.GGFJGHHHEJC.ferroEvent = false;
		CliveNPC.GGFJGHHHEJC.ferroEvent = false;
		RochelleNPC.GGFJGHHHEJC.ferroEvent = false;
		BrockNPC.GGFJGHHHEJC.ferroEvent = false;
		RochelleNPC.GGFJGHHHEJC.animationBase.SetBool("IdleCamp", EGFGNGJGBOP: false, HALNIEBONKH: true);
		MinersManager.instance.SetMinersInCave();
		CliveNPC.GGFJGHHHEJC.CheckExclamationSendOnline(sendOnline: true);
		FerroNPC.GGFJGHHHEJC.CheckExclamationSendOnline(sendOnline: true);
	}

	private void IFANGKBFGKF(int AAAIOBLCOFO)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		DialogueCameraTarget.GetPlayer(instance.CJODOOFLLLB).cameraInEvent = true;
		DialogueCameraTarget.GetPlayer(instance.CJODOOFLLLB).MoveCameraToPositionFromCameraTarget(Vector2.op_Implicit(cameraPosition.position));
		((MonoBehaviour)instance).StartCoroutine(FerroNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
	}

	public void ACOAGLHGJFL(int JIIGOACEIKL)
	{
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	private IEnumerator LJABJLDHLCB()
	{
		TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Quarry, Location.Road);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(IFANGKBFGKF));
		TravelZone travelZone2 = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Quarry, Location.Bathhouse);
		travelZone2.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone2.OnTravelZoneTo, new Action<int>(IFANGKBFGKF));
		TravelZone travelZone3 = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Quarry, Location.QuarryCave);
		travelZone3.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone3.OnTravelZoneTo, new Action<int>(IFANGKBFGKF));
		if (OnlineManager.MasterOrOffline())
		{
			FerroNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(instance.ferroMovePosition.position), Direction.Left);
		}
		yield return CommonReferences.wait2;
		if (Utils.AHMPFOEGJHF(Location.Quarry))
		{
			FadeCamera.GetPlayer(1).FadeOut();
			FadeCamera.GetPlayer(1).JDKHJJIOLOE += HHGEKEKHDNK;
		}
		if (Utils.AHMPFOEGJHF(Location.Quarry, 2) && GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeOut();
			if (!Utils.AHMPFOEGJHF(Location.Quarry))
			{
				FadeCamera.GetPlayer(2).JDKHJJIOLOE += HHGEKEKHDNK;
			}
		}
		if (!Utils.AHMPFOEGJHF(Location.Quarry))
		{
			yield return CommonReferences.wait10;
			EndEventOutOfMap();
		}
	}

	protected override void Awake()
	{
		base.Awake();
		instance = this;
	}

	private void BGPGIOMKKAO()
	{
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
		if (!EventsManager.IsActive(EventsManager.EventType.HotBath) && !EventsManager.IsDone(EventsManager.EventType.HotBath))
		{
			FNNGDCGNINJ();
		}
		if (EventsManager.IsDone(EventsManager.EventType.HotBath))
		{
			inputByProximity.SetActive(false);
			ice.SetActive(false);
		}
	}

	public bool DNCHPIGICIH(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (IsAvailableByProximity(JIIGOACEIKL) && !IIEDALMMNLI)
		{
			ButtonsContext.KBPDNGECKJN(JIIGOACEIKL, PlayerController.GetPlayerPosition(JIIGOACEIKL) + Vector3.up * 639f);
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Desactivando el variant "));
			return false;
		}
		return true;
	}

	private void GEHNCBAJNKP(int JIIGOACEIKL)
	{
		((MonoBehaviour)instance).StartCoroutine(instance.DOKOLLCNIIM(JIIGOACEIKL));
	}

	private void DGALAENNLEE()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		if (movingFall && !OnlineManager.ClientOnline())
		{
			OAKMHJBMJJM += Time.deltaTime;
			float num = Mathf.Clamp01(OAKMHJBMJJM / durationFall);
			float num2 = 1336f - Mathf.Pow(642f - num, desacelerationFall);
			((Component)FerroNPC.GGFJGHHHEJC).transform.position = Vector3.Lerp(FBDPMGHMHIP, LAPILKLAEAC, num2);
			if (num >= 1423f)
			{
				((Component)FerroNPC.GGFJGHHHEJC).transform.position = LAPILKLAEAC;
				movingFall = false;
			}
		}
	}

	public override void EndEvent(bool BFLCJPHHDJM)
	{
		base.EndEvent(BFLCJPHHDJM);
		((MonoBehaviour)instance).StartCoroutine(instance.LJABJLDHLCB());
	}

	private IEnumerator NFDGJADMCOG()
	{
		TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Quarry, Location.Road);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(IFANGKBFGKF));
		TravelZone travelZone2 = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Quarry, Location.Bathhouse);
		travelZone2.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone2.OnTravelZoneTo, new Action<int>(IFANGKBFGKF));
		TravelZone travelZone3 = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Quarry, Location.QuarryCave);
		travelZone3.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone3.OnTravelZoneTo, new Action<int>(IFANGKBFGKF));
		if (OnlineManager.MasterOrOffline())
		{
			FerroNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(instance.ferroMovePosition.position), Direction.Left);
		}
		yield return CommonReferences.wait2;
		if (Utils.AHMPFOEGJHF(Location.Quarry))
		{
			FadeCamera.GetPlayer(1).FadeOut();
			FadeCamera.GetPlayer(1).JDKHJJIOLOE += HHGEKEKHDNK;
		}
		if (Utils.AHMPFOEGJHF(Location.Quarry, 2) && GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeOut();
			if (!Utils.AHMPFOEGJHF(Location.Quarry))
			{
				FadeCamera.GetPlayer(2).JDKHJJIOLOE += HHGEKEKHDNK;
			}
		}
		if (!Utils.AHMPFOEGJHF(Location.Quarry))
		{
			yield return CommonReferences.wait10;
			EndEventOutOfMap();
		}
	}

	private IEnumerator GHMIGFJAGAC()
	{
		return new LHHPPAOHPEE(1);
	}

	private IEnumerator EFFBBCPHPFL()
	{
		return new IEBKFHGOGKE(1)
		{
			_003C_003E4__this = this
		};
	}

	public void PourWaterOnline()
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		NNLHCAJDGCD = false;
		CommonReferences.GGFJGHHHEJC.eventNum[4]++;
		CommonReferences.GGFJGHHHEJC.OnActionDone(1, ActionDone.UnfreezeFerro);
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.ferroIceMelting, ferroFreezePosition.position);
		if (CommonReferences.GGFJGHHHEJC.eventNum[4] == 1)
		{
			iceAnimator.SetTrigger("Melt");
		}
		else if (CommonReferences.GGFJGHHHEJC.eventNum[4] == 2)
		{
			iceAnimator.SetTrigger("Melt");
		}
		((MonoBehaviour)instance).StartCoroutine(LJLFPBGIGBD());
	}

	private IEnumerator JIDNDFBCJFA()
	{
		return new NBGKFAGMEBN(1);
	}

	public void CEDDOKBCHAI(int JIIGOACEIKL)
	{
	}

	private IEnumerator MCHMBPMPKHB()
	{
		return new LHHPPAOHPEE(1);
	}

	private void KNPBKAMGFAM(int AAAIOBLCOFO)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		DialogueCameraTarget.GetPlayer(instance.CJODOOFLLLB).cameraInEvent = false;
		DialogueCameraTarget.GetPlayer(instance.CJODOOFLLLB).MoveCameraToPositionFromCameraTarget(Vector2.op_Implicit(cameraPosition.position), 97f);
		((MonoBehaviour)instance).StartCoroutine(FerroNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
	}

	private IEnumerator JPFOBEPGAOO()
	{
		if (instance.isActor)
		{
			PlayerController.GetPlayer(CJODOOFLLLB).GoToPosition(Vector2.op_Implicit(playerPosition.position), KLGOCJMGKFO: true);
			while (!PlayerController.GetPlayer(CJODOOFLLLB).GoToPosition(Vector2.op_Implicit(playerPosition.position), KLGOCJMGKFO: false))
			{
				yield return null;
			}
			PlayerController.GetPlayer(CJODOOFLLLB).characterAnimation.SetDirection(Direction.Up);
		}
		if (Utils.MMMFJPKECAB(Location.Quarry))
		{
			yield return OnlineManager.WaitForAllPlayers();
		}
		Debug.Log((object)"IntroFerroCoroutine started");
		if (Utils.AHMPFOEGJHF(Location.Quarry))
		{
			DialogueCameraTarget.GetPlayer(instance.CJODOOFLLLB).cameraInEvent = true;
			DialogueCameraTarget.GetPlayer(instance.CJODOOFLLLB).MoveCameraToPositionFromCameraTarget(Vector2.op_Implicit(cameraPosition.position));
		}
		iceAnimator.SetTrigger("Melt");
		FerroNPC.GGFJGHHHEJC.content.SetActive(true);
		((Component)FerroNPC.GGFJGHHHEJC).transform.position = ferroFreezePosition.position;
		FerroNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Down);
		FerroNPC.GGFJGHHHEJC.animationBase.SetBool("Freeze", EGFGNGJGBOP: true, HALNIEBONKH: true);
		((Component)FerroNPC.GGFJGHHHEJC).transform.parent = instance.iceParent;
		((Component)FerroNPC.GGFJGHHHEJC).transform.localPosition = Vector3.zero;
		yield return CommonReferences.wait1;
		FerroNPC.GGFJGHHHEJC.content.SetActive(true);
		FerroNPC.GGFJGHHHEJC.animationBase.SetTrigger("Unfreeze");
		FerroNPC.GGFJGHHHEJC.animationBase.SetBool("Freeze", EGFGNGJGBOP: false, HALNIEBONKH: true);
		((Component)FerroNPC.GGFJGHHHEJC).transform.parent = null;
		yield return CommonReferences.wait05;
		instance.MDAPOJADLIN();
		yield return CommonReferences.wait2_5;
		Utils.DLIIAHACOJB(46, CDPAMNIPPEC: true);
		instance.ice.gameObject.SetActive(false);
		FerroNPC.GGFJGHHHEJC.barkDialogue = false;
		FerroNPC.GGFJGHHHEJC.inSpecialEvent = true;
		FerroNPC.GGFJGHHHEJC.blockActionBar = true;
		instance.EDGDFPPKGDL = FerroNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "HotBath/Main";
		if (instance.isActor)
		{
			FerroNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "HotBath/Main");
		}
		else if (Utils.AHMPFOEGJHF(Location.Quarry))
		{
			((MonoBehaviour)instance).StartCoroutine(FerroNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private void MBONNCDBIPM()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			GameManager gameManager = GameManager.NJNFHEPLEHL();
			gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(MBONNCDBIPM));
		}
		else
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(GMLFGAKIEAD));
		}
		if (!EventsManager.BBMAEAFHEFK((EventsManager.EventType)188) && !EventsManager.LOFKKDNOKNF((EventsManager.EventType)(-144)))
		{
			NMOOFGAHBEN();
		}
		if (EventsManager.FDIHEFGPKFP((EventsManager.EventType)149))
		{
			inputByProximity.SetActive(true);
			ice.SetActive(true);
		}
	}

	private void IGDCLHMBFKF()
	{
		StartEvent(BFLCJPHHDJM: true, CDPAMNIPPEC: true);
	}

	private void GJMLHECPGBP()
	{
		if (OnlineManager.PGAGDFAEEFB())
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

	public void MJNNGIAAGFH(int JIIGOACEIKL)
	{
	}

	public void FerroJump()
	{
		((MonoBehaviour)instance).StartCoroutine(LDLMKJCDLFJ());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendJumpFerro();
		}
	}

	private void IELNMIMCJMO()
	{
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(IELNMIMCJMO));
		FerroNPC.GGFJGHHHEJC.ferroEvent = true;
		CliveNPC.GAGMPCEPONF().ferroEvent = false;
		RochelleNPC.MIGKKKELOJO().ferroEvent = true;
		BrockNPC.MAIDHAPANEB().ferroEvent = true;
		RochelleNPC.ABDJJBFNLBJ().animationBase.CGEADHOLHCH("NotMyChest", EGFGNGJGBOP: true, HALNIEBONKH: true);
		MinersManager.instance.DOGILJIDGPH();
		CliveNPC.EJHDHCNILDH().CheckExclamationSendOnline(sendOnline: true);
		FerroNPC.MLPCDJPLBAC().CheckExclamationSendOnline(sendOnline: true);
	}

	private void KAEDAOLDHKK()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		if (movingFall && !OnlineManager.ClientOnline())
		{
			OAKMHJBMJJM += Time.deltaTime;
			float num = Mathf.Clamp01(OAKMHJBMJJM / durationFall);
			float num2 = 1945f - Mathf.Pow(1339f - num, desacelerationFall);
			((Component)FerroNPC.GGFJGHHHEJC).transform.position = Vector3.Lerp(FBDPMGHMHIP, LAPILKLAEAC, num2);
			if (num >= 111f)
			{
				((Component)FerroNPC.MLPCDJPLBAC()).transform.position = LAPILKLAEAC;
				movingFall = true;
			}
		}
	}

	public void OffHover(int JIIGOACEIKL)
	{
	}

	public void LGDKFCALLKA(int JIIGOACEIKL)
	{
	}

	public bool OKBPDMDJICC(int JIIGOACEIKL)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		if (!IsAvailableByProximity(JIIGOACEIKL))
		{
			return true;
		}
		NNLHCAJDGCD = true;
		CommonReferences.GGFJGHHHEJC.eventNum[2] += 0;
		CommonReferences.MNFMOEKMJKN().OnActionDone(1, (ActionDone)127);
		MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().ferroIceMelting, ferroFreezePosition.position);
		if (CommonReferences.GGFJGHHHEJC.eventNum[0] == 0)
		{
			PlayerController.OPHDCMJLLEC(JIIGOACEIKL).PlayerBark("FishMiniGameWin");
			iceAnimator.SetTrigger("Moving");
		}
		else if (CommonReferences.GGFJGHHHEJC.eventNum[1] == 1)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark("Removing Rented Room Zone!");
			iceAnimator.SetTrigger("");
		}
		else if (CommonReferences.MNFMOEKMJKN().eventNum[5] == 5)
		{
			instance.CJODOOFLLLB = JIIGOACEIKL;
			IGDCLHMBFKF();
		}
		PlayerInventory.RemoveItems(JIIGOACEIKL, -113, 1);
		PlayerInventory.EIFPKCAFDIB(JIIGOACEIKL).OJDGOADOCMG(ItemDatabaseAccessor.GOKIDLOELKB(174, GGBBJNBBLMF: true).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
		((MonoBehaviour)instance).StartCoroutine(EFFBBCPHPFL());
		if (OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendPourWater();
		}
		return false;
	}

	private void NMOOFGAHBEN()
	{
		instance.ice.gameObject.SetActive(false);
		iceAnimator.SetInteger("Next Item", CommonReferences.MNFMOEKMJKN().eventNum[6]);
		((Behaviour)FerroNPC.GGFJGHHHEJC.simpleAnimation).enabled = false;
		((Behaviour)FerroNPC.MLPCDJPLBAC().animationController).enabled = true;
		FerroNPC.GGFJGHHHEJC.playerCanInteract = true;
	}

	private void MDEOLNAPKDE()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		if (movingFall && !OnlineManager.ClientOnline())
		{
			OAKMHJBMJJM += Time.deltaTime;
			float num = Mathf.Clamp01(OAKMHJBMJJM / durationFall);
			float num2 = 989f - Mathf.Pow(476f - num, desacelerationFall);
			((Component)FerroNPC.GGFJGHHHEJC).transform.position = Vector3.Lerp(FBDPMGHMHIP, LAPILKLAEAC, num2);
			if (num >= 585f)
			{
				((Component)FerroNPC.MLPCDJPLBAC()).transform.position = LAPILKLAEAC;
				movingFall = true;
			}
		}
	}

	private void FNNGDCGNINJ()
	{
		instance.ice.gameObject.SetActive(true);
		iceAnimator.SetInteger("MeltState", CommonReferences.GGFJGHHHEJC.eventNum[4]);
		((Behaviour)FerroNPC.GGFJGHHHEJC.simpleAnimation).enabled = false;
		((Behaviour)FerroNPC.GGFJGHHHEJC.animationController).enabled = false;
		FerroNPC.GGFJGHHHEJC.playerCanInteract = false;
	}

	private IEnumerator GCIKACEGHIL()
	{
		return new LHHPPAOHPEE(1);
	}

	private IEnumerator DHINCHODEFI()
	{
		return new KEOJDGLFAFA(1)
		{
			_003C_003E4__this = this
		};
	}

	private void JMNBECMKICD()
	{
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(IELNMIMCJMO));
		FerroNPC.MLPCDJPLBAC().ferroEvent = true;
		CliveNPC.BIIOFAHFNPA().ferroEvent = false;
		RochelleNPC.CMIHGBHPLFP().ferroEvent = true;
		BrockNPC.DIHCEGINELM().ferroEvent = true;
		RochelleNPC.NBKKEINELDN().animationBase.CGEADHOLHCH("Drag item:", EGFGNGJGBOP: true);
		MinersManager.instance.LGMADKBOJCB();
		CliveNPC.DBJCACLEFGK().CheckExclamationSendOnline(sendOnline: true);
		FerroNPC.GGFJGHHHEJC.CheckExclamationSendOnline(sendOnline: true);
	}

	private IEnumerator HHDCGKGFIAA()
	{
		while (isActive)
		{
			yield return null;
			GIHNJCGDCIF();
		}
		CEACJENCFNF = null;
	}

	public bool FHFFNFECPKB(int JIIGOACEIKL)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		if (!IsAvailableByProximity(JIIGOACEIKL))
		{
			return false;
		}
		NNLHCAJDGCD = true;
		CommonReferences.GGFJGHHHEJC.eventNum[2] += 0;
		CommonReferences.GGFJGHHHEJC.OnActionDone(1, (ActionDone)(-39));
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.ferroIceMelting, ferroFreezePosition.position);
		if (CommonReferences.GGFJGHHHEJC.eventNum[3] == 0)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark("Herbal");
			iceAnimator.SetTrigger("SkeletonBird");
		}
		else if (CommonReferences.GGFJGHHHEJC.eventNum[4] == 7)
		{
			PlayerController.GetPlayer(JIIGOACEIKL).PlayerBark("Error_NoDogFood");
			iceAnimator.SetTrigger("Festín del Juramento/ComensalesBarks");
		}
		else if (CommonReferences.GGFJGHHHEJC.eventNum[0] == 6)
		{
			instance.CJODOOFLLLB = JIIGOACEIKL;
			IGDCLHMBFKF();
		}
		PlayerInventory.RemoveItems(JIIGOACEIKL, -6, 0);
		PlayerInventory.GetPlayer(JIIGOACEIKL, LAGHIOKLJGH: true, ADPNMHGBFKG: true).OJDGOADOCMG(ItemDatabaseAccessor.GOKIDLOELKB(-85, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
		((MonoBehaviour)instance).StartCoroutine(LJLFPBGIGBD());
		if (OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendPourWater();
		}
		return false;
	}

	private IEnumerator BJPHDFADNHN()
	{
		yield return CommonReferences.wait3_5;
		NNLHCAJDGCD = true;
	}

	private void CHOCGHNFMPN()
	{
		NMOOFGAHBEN();
	}

	public void GIBLFNNJNEL()
	{
		((MonoBehaviour)instance).StartCoroutine(AGJLKACCPLG());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendJumpFerro2();
		}
	}

	private IEnumerator LPPCBMIDINM()
	{
		return new LNKOAFPNMON(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator KMOMLCNPGFA(int JIIGOACEIKL)
	{
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(GEHNCBAJNKP));
		if (GameManager.LocalCoop())
		{
			FadeCamera player2 = FadeCamera.GetPlayer(2);
			player2.OnFadeFinished = (Action<int>)Delegate.Remove(player2.OnFadeFinished, new Action<int>(GEHNCBAJNKP));
		}
		yield return CommonReferences.wait05;
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		if (Utils.AHMPFOEGJHF(Location.Quarry))
		{
			DialogueCameraTarget.GetPlayer(1).ReturnControlToCameraTarget();
		}
		if (GameManager.LocalCoop() && Utils.AHMPFOEGJHF(Location.Quarry, 2))
		{
			LocalCooperativeManager.RestoreCameraInLocalCoop();
			DialogueCameraTarget.GetPlayer(2).ReturnControlToCameraTarget();
		}
		if (GameManager.LocalCoop())
		{
			RemoveAllTravelZonesCallbacks(Location.Quarry);
		}
	}

	private IEnumerator LHKCAAMGFMH()
	{
		while (isActive)
		{
			yield return null;
			GIHNJCGDCIF();
		}
		CEACJENCFNF = null;
	}

	public override void StartEvent(bool BFLCJPHHDJM, bool CDPAMNIPPEC)
	{
		base.StartEvent(BFLCJPHHDJM, CDPAMNIPPEC);
		if (GameManager.LocalCoop())
		{
			PrepareLocalCoop(Location.Quarry);
		}
		else if (!Utils.AHMPFOEGJHF(Location.Quarry))
		{
			TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Quarry, Location.Road);
			travelZone.OnTravelZoneTo = (Action<int>)Delegate.Combine(travelZone.OnTravelZoneTo, new Action<int>(IFANGKBFGKF));
			TravelZone travelZone2 = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Quarry, Location.Bathhouse);
			travelZone2.OnTravelZoneTo = (Action<int>)Delegate.Combine(travelZone2.OnTravelZoneTo, new Action<int>(IFANGKBFGKF));
			TravelZone travelZone3 = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Quarry, Location.QuarryCave);
			travelZone3.OnTravelZoneTo = (Action<int>)Delegate.Combine(travelZone3.OnTravelZoneTo, new Action<int>(IFANGKBFGKF));
		}
		if (Utils.AHMPFOEGJHF(Location.Quarry))
		{
			PlayerInputs.DisableKeyboardInputsAndMovement(instance.CJODOOFLLLB, (MonoBehaviour)(object)instance);
		}
		((MonoBehaviour)instance).StartCoroutine(JPFOBEPGAOO());
	}
}
