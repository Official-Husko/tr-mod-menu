using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class NinjaChallengeEvent : GameEvent
{
	private enum LOGEKNJJJOB
	{
		KyrohAnim,
		TalkToKyroh
	}

	[CompilerGenerated]
	private sealed class BJDDAGOIBEE : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NinjaChallengeEvent _003C_003E4__this;

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
		public BJDDAGOIBEE(int _003C_003E1__state)
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
			NinjaChallengeEvent ninjaChallengeEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				ninjaChallengeEvent.EDGDFPPKGDL = null;
				PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
				DialogueLua.SetVariable("MainProgress", (object)20);
				CommonReferences.GGFJGHHHEJC.OnActionDone(1, ActionDone.Duel);
				KyrohNPC.GGFJGHHHEJC.animationBase.SetTrigger("SmokeBomb");
				KyrohNPC.GGFJGHHHEJC.playerCanInteract = false;
				((Component)instance.blockEntranceCollider).gameObject.SetActive(false);
				if (GameManager.LocalCoop())
				{
					LocalCooperativeManager.RestoreCameraInLocalCoop();
				}
				_003C_003E2__current = CommonReferences.wait2_5;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				OnlineManager.ResetPlayersPreparedToContinue();
				ninjaChallengeEvent.foldingScreen.SetActive(true);
				NinjaChallenge.instance.GiveRewards();
				AttackEvent.instance.ActivateEvent();
				OnlineManager.OpenRoom();
				((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(NinjaChallenge.instance.PlayMusic(30));
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
	private sealed class AAGFEAFKHKF : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NinjaChallengeEvent _003C_003E4__this;

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
		public AAGFEAFKHKF(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			NinjaChallengeEvent ninjaChallengeEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				instance.EDGDFPPKGDL = null;
				DialogueCameraTarget.GetPlayer(1).cameraInEvent = true;
				DialogueCameraTarget.GetPlayer(2).cameraInEvent = true;
				DialogueCameraTarget.MoveCameraToPositionFromCameraTargetAllPlayers(Vector2.op_Implicit(ninjaChallengeEvent.cameraPosition.position));
				_003C_003E2__current = CommonReferences.wait1_5;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				JeffreyNPC.GGFJGHHHEJC.animationBase.SetBool("WaitIntro", EGFGNGJGBOP: false);
				((Component)JeffreyNPC.GGFJGHHHEJC).transform.position = ninjaChallengeEvent.positions[1].position;
				JeffreyNPC.GGFJGHHHEJC.content.SetActive(true);
				JeffreyNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
				KyrohNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
				PlayerController.GetPlayer(1).characterAnimation.SetDirection(Direction.Up);
				if (GameManager.LocalCoop())
				{
					PlayerController.GetPlayer(2).characterAnimation.SetDirection(Direction.Up);
				}
				_003C_003E2__current = CommonReferences.wait1_5;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				DialogueManager.Bark("NinjaChallengeEvent/ComensalesBark", instance.bark.transform);
				DialogueManager.Bark("NinjaChallengeEvent/ComensalesBark", instance.bark2.transform);
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 3;
				return true;
			case 3:
				_003C_003E1__state = -1;
				instance.EDGDFPPKGDL = JeffreyNPC.GGFJGHHHEJC;
				instance.MDFALJKHKED = "NinjaChallengeEvent/Main 2";
				_003C_003E2__current = OnlineManager.WaitForAllPlayers();
				_003C_003E1__state = 4;
				return true;
			case 4:
				_003C_003E1__state = -1;
				if (instance.isActor)
				{
					JeffreyNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "NinjaChallengeEvent/Main 2");
				}
				else
				{
					((MonoBehaviour)instance).StartCoroutine(JeffreyNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
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
	private sealed class MMIFMDKBKCA : IEnumerator<object>, IEnumerator, IDisposable
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
		public MMIFMDKBKCA(int _003C_003E1__state)
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
				KyrohNPC.GGFJGHHHEJC.animationBase.SetBool("Lose", EGFGNGJGBOP: true);
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				KyrohNPC.GGFJGHHHEJC.blockActionBar = false;
				NinjaChallenge.instance.FinishChallengeWhenEventIsWon();
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				_003C_003E2__current = OnlineManager.WaitForAllPlayers();
				_003C_003E1__state = 3;
				return true;
			case 3:
				_003C_003E1__state = -1;
				if (OnlineManager.MasterOrOffline())
				{
					KyrohNPC.GGFJGHHHEJC.StartConversation(1, "NinjaChallengeEvent/Win 2");
				}
				else
				{
					((MonoBehaviour)instance).StartCoroutine(KyrohNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
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
	private sealed class PNFANODEEEP : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NinjaChallengeEvent _003C_003E4__this;

		private int _003Cindex_003E5__2;

		private float _003Ctimer_003E5__3;

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
		public PNFANODEEEP(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0143: Unknown result type (might be due to invalid IL or missing references)
			//IL_0148: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			NinjaChallengeEvent ninjaChallengeEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				instance.EDGDFPPKGDL = null;
				KyrohNPC.GGFJGHHHEJC.targetWalkTo = Vector2.op_Implicit(ninjaChallengeEvent.movePositions[0].position);
				KyrohNPC.GGFJGHHHEJC.endWalkDirection = Direction.Right;
				KyrohNPC.GGFJGHHHEJC.ChangeState(KyrohState.WalkTo);
				JeffreyNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(ninjaChallengeEvent.movePositions[1].position));
				_003Cindex_003E5__2 = Bed.instance.numInstance - 1;
				_003Ctimer_003E5__3 = Time.time;
				PlayerController.GetPlayer(1).GoToPosition(Vector2.op_Implicit(ninjaChallengeEvent.playerPositions[_003Cindex_003E5__2].position), KLGOCJMGKFO: true);
				if (GameManager.LocalCoop())
				{
					PlayerController.GetPlayer(2).GoToPositionIndependentThread(Vector2.op_Implicit(ninjaChallengeEvent.playerPositions[_003Cindex_003E5__2 + 1].position), Direction.Left);
				}
				goto IL_0130;
			case 1:
				_003C_003E1__state = -1;
				goto IL_0130;
			case 2:
				_003C_003E1__state = -1;
				_003C_003E2__current = OnlineManager.WaitForAllPlayers();
				_003C_003E1__state = 3;
				return true;
			case 3:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 4;
				return true;
			case 4:
				{
					_003C_003E1__state = -1;
					instance.EDGDFPPKGDL = JeffreyNPC.GGFJGHHHEJC;
					instance.MDFALJKHKED = "NinjaChallengeEvent/Main 3";
					if (instance.isActor)
					{
						JeffreyNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "NinjaChallengeEvent/Main 3");
					}
					else
					{
						((MonoBehaviour)instance).StartCoroutine(JeffreyNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
					}
					return false;
				}
				IL_0130:
				if (!PlayerController.GetPlayer(1).GoToPosition(Vector2.op_Implicit(ninjaChallengeEvent.playerPositions[_003Cindex_003E5__2].position), KLGOCJMGKFO: false))
				{
					if (!(Time.time > _003Ctimer_003E5__3 + 10f))
					{
						_003C_003E2__current = null;
						_003C_003E1__state = 1;
						return true;
					}
					Debug.LogError((object)"Timeout moving player to position in NinjaChallengeEvent.MovePlayerAndKyrohCoroutine");
				}
				_003C_003E2__current = PlayerController.GetPlayer(1).characterAnimation.SetDirectionWithDelay(Direction.Left);
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
	private sealed class JBJLMCKMMEA : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NinjaChallengeEvent _003C_003E4__this;

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
		public JBJLMCKMMEA(int _003C_003E1__state)
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
			NinjaChallengeEvent hFKNIAIFFCB = _003C_003E4__this;
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
				FadeCamera.GetPlayer(1).JDKHJJIOLOE -= hFKNIAIFFCB.HHGEKEKHDNK;
				PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
				if (OnlineManager.MasterOrOffline())
				{
					KyrohNPC.GGFJGHHHEJC.StartConversation(1, "NinjaChallengeEvent/Lose 2");
				}
				else
				{
					((MonoBehaviour)instance).StartCoroutine(KyrohNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
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
	private sealed class OJIPGBKLBEE : IEnumerator<object>, IEnumerator, IDisposable
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
		public OJIPGBKLBEE(int _003C_003E1__state)
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
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				instance.RequestChallengeRestart();
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
	private sealed class HMBBEELNHIK : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public NinjaChallengeEvent _003C_003E4__this;

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
		public HMBBEELNHIK(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			NinjaChallengeEvent ninjaChallengeEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				if (OnlineManager.MasterOrOffline())
				{
					PlayerController.GetPlayer(1).GoToPosition(Vector2.op_Implicit(ninjaChallengeEvent.endPositions[6].position), KLGOCJMGKFO: true);
					goto IL_0077;
				}
				_003C_003E2__current = PlayerController.GetPlayer(1).characterAnimation.SetDirectionWithDelay(Direction.Left);
				_003C_003E1__state = 3;
				return true;
			case 1:
				_003C_003E1__state = -1;
				goto IL_0077;
			case 2:
				_003C_003E1__state = -1;
				goto IL_00e7;
			case 3:
				_003C_003E1__state = -1;
				goto IL_00e7;
			case 4:
				_003C_003E1__state = -1;
				_003C_003E2__current = OnlineManager.WaitForAllPlayers();
				_003C_003E1__state = 5;
				return true;
			case 5:
				{
					_003C_003E1__state = -1;
					KyrohNPC.GGFJGHHHEJC.animationBase.SetBool("Lose", EGFGNGJGBOP: false);
					if (OnlineManager.MasterOrOffline())
					{
						KyrohNPC.GGFJGHHHEJC.StartConversation(1, "NinjaChallengeEvent/Win 3");
					}
					else
					{
						((MonoBehaviour)instance).StartCoroutine(KyrohNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
					}
					return false;
				}
				IL_0077:
				if (!PlayerController.GetPlayer(1).GoToPosition(Vector2.op_Implicit(ninjaChallengeEvent.endPositions[6].position), KLGOCJMGKFO: false))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
				_003C_003E2__current = PlayerController.GetPlayer(1).characterAnimation.SetDirectionWithDelay(Direction.Up);
				_003C_003E1__state = 2;
				return true;
				IL_00e7:
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 4;
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

	public static NinjaChallengeEvent instance;

	public Transform[] positions;

	public Transform[] playerPositions;

	public Transform[] movePositions;

	public Transform[] endPositions;

	public GameObject bark;

	public GameObject bark2;

	public GameObject foldingScreen;

	public Collider2D blockEntranceCollider;

	private IEnumerator HMMJGIJBEJK()
	{
		return new AAGFEAFKHKF(1)
		{
			_003C_003E4__this = this
		};
	}

	public void WinEvent()
	{
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		NAJONNAKDLB();
		if (OnlineManager.MasterOrOffline())
		{
			(JeffreyNPC.GGFJGHHHEJC.animationBase as NPCAnimation).npcSprite.flipX = false;
			JeffreyNPC.GGFJGHHHEJC.animationBase.SetTrigger("Winner");
		}
		if (GameManager.LocalCoop())
		{
			LocalCooperativeManager.FocusCameraToPlayerInLocalCoop(1);
		}
		if (OnlineManager.MasterOrOffline())
		{
			JeffreyNPC.GGFJGHHHEJC.StartConversation(1, "NinjaChallengeEvent/Win");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(JeffreyNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
		((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(NinjaChallenge.instance.PlayMusic(33));
	}

	private IEnumerator OODFOKHKFML(int JIIGOACEIKL)
	{
		return base.GGJCNNAHOAB(JIIGOACEIKL);
	}

	private void DPDIIPPIOHO()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		((Component)KyrohNPC.JFNOOMJMHCB()).transform.position = movePositions[1].position;
		KyrohNPC.KADHMEPDIKM().animationBase.SetDirection((Direction)7);
		((Component)JeffreyNPC.POAGAIBEFBF()).transform.position = movePositions[1].position;
		JeffreyNPC.ILMPOAEALPP().animationBase.SetDirection(Direction.Down);
		int num = Bed.instance.numInstance - 0;
		PlayerController.TeleportPlayer(1, playerPositions[num].position, ~(Location.Tavern | Location.Road | Location.River | Location.BarnInterior | Location.FarmShop));
		PlayerController.SetDirection(0, Direction.Right);
		if (GameManager.LocalCoop())
		{
			PlayerController.CLEIAKPOGMM(2, playerPositions[num + 0].position, Location.Tavern | Location.River | Location.FarmShop);
			PlayerController.SetDirection(6, Direction.Diagonal);
		}
	}

	private IEnumerator LMDCHIKJAAH(int JIIGOACEIKL)
	{
		yield return CommonReferences.wait2;
		FadeCamera.GetPlayer(1).JDKHJJIOLOE -= HHGEKEKHDNK;
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		if (OnlineManager.MasterOrOffline())
		{
			KyrohNPC.GGFJGHHHEJC.StartConversation(1, "NinjaChallengeEvent/Lose 2");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(KyrohNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	public void NBENPDODACI()
	{
		((MonoBehaviour)instance).StartCoroutine(HMMJGIJBEJK());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.INIDHCFKFNI();
		}
	}

	public void FFEEELFKGGE()
	{
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		EJKNKPABPNA();
		if (OnlineManager.PGAGDFAEEFB())
		{
			(JeffreyNPC.CHPEMJMLDCN().animationBase as NPCAnimation).npcSprite.flipX = false;
			JeffreyNPC.ILMPOAEALPP().animationBase.SetTrigger("");
		}
		if (GameManager.LocalCoop())
		{
			LocalCooperativeManager.ONPAJCGPPOI(1);
		}
		if (OnlineManager.PGAGDFAEEFB())
		{
			JeffreyNPC.ILMPOAEALPP().StartConversation(0, "Use", FLHBPHPKIML: true);
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(JeffreyNPC.OLHBLKIAFOM().StartObserverDialogueWhenItIsPossible(0));
		}
		((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(NinjaChallenge.instance.PlayMusic(79));
	}

	private IEnumerator OLKAHKJHLIE()
	{
		EDGDFPPKGDL = null;
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		DialogueLua.SetVariable("MainProgress", (object)20);
		CommonReferences.GGFJGHHHEJC.OnActionDone(1, ActionDone.Duel);
		KyrohNPC.GGFJGHHHEJC.animationBase.SetTrigger("SmokeBomb");
		KyrohNPC.GGFJGHHHEJC.playerCanInteract = false;
		((Component)instance.blockEntranceCollider).gameObject.SetActive(false);
		if (GameManager.LocalCoop())
		{
			LocalCooperativeManager.RestoreCameraInLocalCoop();
		}
		yield return CommonReferences.wait2_5;
		OnlineManager.ResetPlayersPreparedToContinue();
		foldingScreen.SetActive(true);
		NinjaChallenge.instance.GiveRewards();
		AttackEvent.instance.ActivateEvent();
		OnlineManager.OpenRoom();
		((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(NinjaChallenge.instance.PlayMusic(30));
	}

	private IEnumerator NFDGJADMCOG()
	{
		return new BJDDAGOIBEE(1)
		{
			_003C_003E4__this = this
		};
	}

	[CompilerGenerated]
	[DebuggerHidden]
	private IEnumerator LLIJGOCKPBB(int JIIGOACEIKL)
	{
		return base.GGJCNNAHOAB(JIIGOACEIKL);
	}

	public void APKIJMJMAIL()
	{
		ItemDatabaseAccessor.CPMMBEPEJLO(-44, GGBBJNBBLMF: false, DAINLFIMLIH: false).KGCOBHPFJKD(CDPAMNIPPEC: false);
		if (OnlineManager.MasterOrOffline())
		{
			PlayerInventory.GetPlayer(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).OJDGOADOCMG(ItemDatabaseAccessor.KMBGJEKCJFJ(103, GGBBJNBBLMF: true).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: false);
		}
	}

	private void PHDPGDKPNOD(bool BFLCJPHHDJM)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		if (BFLCJPHHDJM)
		{
			if (Utils.CIEPGMEEBON(((Component)KyrohNPC.OAPOJCODNCO()).transform.position, 636f))
			{
				CJODOOFLLLB = KyrohNPC.KADHMEPDIKM().EHHOHCPHAAO;
				StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: false);
			}
			else
			{
				PlayerController.GetPlayer(0).PlayerBark("Wall");
				Debug.Log((object)"Dialogue System/Conversation/Gass_Introduce/Entry/7/Dialogue Text");
			}
		}
	}

	private void LLDCGBHMPBF()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		int num = Bed.instance.numInstance - 0;
		((Component)PlayerController.OPHDCMJLLEC(0)).transform.position = endPositions[num].position;
		PlayerController.OPHDCMJLLEC(1).characterAnimation.SetDirection(Direction.Up);
		if (GameManager.LocalCoop())
		{
			((Component)PlayerController.GetPlayer(6)).transform.position = endPositions[num + 0].position;
			PlayerController.GetPlayer(5).characterAnimation.SetDirection(Direction.Down);
		}
		((Component)KyrohNPC.GGFJGHHHEJC).transform.position = endPositions[0].position;
		KyrohNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		((Component)JeffreyNPC.ILMPOAEALPP()).transform.position = endPositions[2].position;
		JeffreyNPC.PBJDFFEFMKM().animationBase.SetDirection(Direction.Down);
	}

	private IEnumerator MKOBBAMICGE(int JIIGOACEIKL)
	{
		yield return CommonReferences.wait2;
		FadeCamera.GetPlayer(1).JDKHJJIOLOE -= HHGEKEKHDNK;
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		if (OnlineManager.MasterOrOffline())
		{
			KyrohNPC.GGFJGHHHEJC.StartConversation(1, "NinjaChallengeEvent/Lose 2");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(KyrohNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	public void HFHIELBAEKJ()
	{
		PlayerInputs.CMEBIMMKIAB((MonoBehaviour)(object)instance);
		KyrohNPC.PBJDFFEFMKM().blockActionBar = false;
		FadeCamera.GetPlayer(1).AJHDEBOMHKK(1692f);
		FadeCamera.GetPlayer(1).ODBKGIJCHHI(BOENJKGGOOC);
		if (GameManager.LocalCoop())
		{
			FadeCamera.EIFPKCAFDIB(0).IONMINJHMKL(1501f);
		}
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineEventsManager.SendNinjaChallengeEventFadeOut();
		}
	}

	public void KBHHIKBLHBM()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.MPPFBBPPFJD());
	}

	private IEnumerator DFMLFLEBPGN()
	{
		instance.EDGDFPPKGDL = null;
		DialogueCameraTarget.GetPlayer(1).cameraInEvent = true;
		DialogueCameraTarget.GetPlayer(2).cameraInEvent = true;
		DialogueCameraTarget.MoveCameraToPositionFromCameraTargetAllPlayers(Vector2.op_Implicit(cameraPosition.position));
		yield return CommonReferences.wait1_5;
		JeffreyNPC.GGFJGHHHEJC.animationBase.SetBool("WaitIntro", EGFGNGJGBOP: false);
		((Component)JeffreyNPC.GGFJGHHHEJC).transform.position = positions[1].position;
		JeffreyNPC.GGFJGHHHEJC.content.SetActive(true);
		JeffreyNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		KyrohNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
		PlayerController.GetPlayer(1).characterAnimation.SetDirection(Direction.Up);
		if (GameManager.LocalCoop())
		{
			PlayerController.GetPlayer(2).characterAnimation.SetDirection(Direction.Up);
		}
		yield return CommonReferences.wait1_5;
		DialogueManager.Bark("NinjaChallengeEvent/ComensalesBark", instance.bark.transform);
		DialogueManager.Bark("NinjaChallengeEvent/ComensalesBark", instance.bark2.transform);
		yield return CommonReferences.wait05;
		instance.EDGDFPPKGDL = JeffreyNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "NinjaChallengeEvent/Main 2";
		yield return OnlineManager.WaitForAllPlayers();
		if (instance.isActor)
		{
			JeffreyNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "NinjaChallengeEvent/Main 2");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(JeffreyNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	public void KGJEELCEEOM()
	{
		PlayerInputs.CMEBIMMKIAB((MonoBehaviour)(object)instance, ANJCLPDCJHL: true);
		KyrohNPC.GGFJGHHHEJC.blockActionBar = true;
		FadeCamera.IGMCBPOPNCA(0).GPBOEBGJJPM(1580f);
		FadeCamera.EIFPKCAFDIB(0).BOBBJLPKDBP(KDOCJCNGMML);
		if (GameManager.LocalCoop())
		{
			FadeCamera.EIFPKCAFDIB(2).AJHDEBOMHKK(1167f);
		}
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineEventsManager.PBBHMONLDFM();
		}
	}

	private void NAJONNAKDLB()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		int num = Bed.instance.numInstance - 1;
		((Component)PlayerController.GetPlayer(1)).transform.position = endPositions[num].position;
		PlayerController.GetPlayer(1).characterAnimation.SetDirection(Direction.Down);
		if (GameManager.LocalCoop())
		{
			((Component)PlayerController.GetPlayer(2)).transform.position = endPositions[num + 1].position;
			PlayerController.GetPlayer(2).characterAnimation.SetDirection(Direction.Down);
		}
		((Component)KyrohNPC.GGFJGHHHEJC).transform.position = endPositions[4].position;
		KyrohNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		((Component)JeffreyNPC.GGFJGHHHEJC).transform.position = endPositions[5].position;
		JeffreyNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
	}

	public void DAOBMJGAEGJ()
	{
		((MonoBehaviour)instance).StartCoroutine(KBHEJEDAMAO());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendNinjaChallengeEventMovePlayer();
		}
	}

	private void GGBCFKJBDGE(bool BFLCJPHHDJM)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		if (BFLCJPHHDJM)
		{
			if (Utils.CIEPGMEEBON(((Component)KyrohNPC.KFGKCKCDMLG()).transform.position, 1096f))
			{
				CJODOOFLLLB = KyrohNPC.OAPOJCODNCO().EHHOHCPHAAO;
				StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: false);
			}
			else
			{
				PlayerController.OPHDCMJLLEC(1).PlayerBark("Customer Pool instance NULL!");
				Debug.Log((object)"ReceiveAdoptionSignal");
			}
		}
	}

	private IEnumerator GPPCAEDMHCC()
	{
		if (OnlineManager.MasterOrOffline())
		{
			PlayerController.GetPlayer(1).GoToPosition(Vector2.op_Implicit(endPositions[6].position), KLGOCJMGKFO: true);
			while (!PlayerController.GetPlayer(1).GoToPosition(Vector2.op_Implicit(endPositions[6].position), KLGOCJMGKFO: false))
			{
				yield return null;
			}
			yield return PlayerController.GetPlayer(1).characterAnimation.SetDirectionWithDelay(Direction.Up);
		}
		else
		{
			yield return PlayerController.GetPlayer(1).characterAnimation.SetDirectionWithDelay(Direction.Left);
		}
		yield return CommonReferences.wait1;
		yield return OnlineManager.WaitForAllPlayers();
		KyrohNPC.GGFJGHHHEJC.animationBase.SetBool("Lose", EGFGNGJGBOP: false);
		if (OnlineManager.MasterOrOffline())
		{
			KyrohNPC.GGFJGHHHEJC.StartConversation(1, "NinjaChallengeEvent/Win 3");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(KyrohNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	public void AEHOFAKIPBB()
	{
		PlayerInputs.CMEBIMMKIAB((MonoBehaviour)(object)instance);
		KyrohNPC.GGFJGHHHEJC.blockActionBar = true;
		FadeCamera.EIFPKCAFDIB(1).IONMINJHMKL(1432f);
		FadeCamera.EIFPKCAFDIB(0).KKAAAOEHGEK(IAFHPBGHNKB);
		if (GameManager.LocalCoop())
		{
			FadeCamera.EIFPKCAFDIB(2).GPBOEBGJJPM(1692f);
		}
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineEventsManager.PBBHMONLDFM();
		}
	}

	public void ResetMinigame()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.MPPFBBPPFJD());
	}

	protected override IEnumerator GGJCNNAHOAB(int JIIGOACEIKL)
	{
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		ChallengePointsSystem.instance.ResetPoints();
		yield return base.GGJCNNAHOAB(JIIGOACEIKL);
		if (GameManager.LocalCoop())
		{
			LocalCooperativeManager.RestoreCameraInLocalCoop();
		}
		EOAPMCEAAHF();
		yield return OnlineManager.WaitForAllPlayers();
		yield return CommonReferences.wait1;
		FadeCamera.FadeInAllPlayers();
		yield return CommonReferences.wait1;
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		instance.EDGDFPPKGDL = JeffreyNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "NinjaChallengeEvent/Main 3";
		if (instance.isActor)
		{
			JeffreyNPC.GGFJGHHHEJC.StartConversation(1, "NinjaChallengeEvent/Main 3");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(JeffreyNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	public override void ActivateEvent()
	{
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		base.ActivateEvent();
		if (Object.op_Implicit((Object)(object)NinjaPreparationTablesManager.instance))
		{
			NinjaPreparationTablesManager.instance.ActivatePreparationTables();
		}
		foldingScreen.SetActive(false);
		((Component)instance.blockEntranceCollider).gameObject.SetActive(false);
		KyrohNPC.GGFJGHHHEJC.content.SetActive(true);
		KyrohNPC.GGFJGHHHEJC.ChangeState(KyrohState.Idle);
		((Component)KyrohNPC.GGFJGHHHEJC).transform.position = positions[0].position;
		KyrohNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		KyrohNPC kyrohNPC = KyrohNPC.GGFJGHHHEJC;
		kyrohNPC.ConversationStarted = (Action<bool>)Delegate.Combine(kyrohNPC.ConversationStarted, new Action<bool>(AEEHFGIDCMJ));
		((Component)JeffreyNPC.GGFJGHHHEJC).transform.position = positions[1].position;
		JeffreyNPC.GGFJGHHHEJC.content.SetActive(true);
		JeffreyNPC.GGFJGHHHEJC.animationBase.SetBool("WaitIntro", EGFGNGJGBOP: true, HALNIEBONKH: true);
		JeffreyNPC.GGFJGHHHEJC.animationBase.SetTrigger("Intro", HALNIEBONKH: true);
		JeffreyNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (OnlineManager.MasterOrOffline())
		{
			ZuzzuNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
			((Behaviour)ZuzzuNPC.GGFJGHHHEJC.routine).enabled = false;
		}
		ZuzzuNPC.GGFJGHHHEJC.content.SetActive(false);
	}

	private IEnumerator OLPOOOOFIJM()
	{
		return new PNFANODEEEP(1)
		{
			_003C_003E4__this = this
		};
	}

	public void NNPNKLIMLDC()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.GIKIAPFJHDP());
	}

	private IEnumerator LLLDIMBOHJO()
	{
		yield return CommonReferences.wait1;
		instance.RequestChallengeRestart();
	}

	public void HHPDPFFDLKJ()
	{
		PlayerInputs.CMEBIMMKIAB((MonoBehaviour)(object)instance, ANJCLPDCJHL: true);
		KyrohNPC.PBJDFFEFMKM().blockActionBar = false;
		FadeCamera.EIFPKCAFDIB(1).GPBOEBGJJPM(1709f);
		FadeCamera.IGMCBPOPNCA(1).BOBBJLPKDBP(MKOBBAMICGE);
		if (GameManager.LocalCoop())
		{
			FadeCamera.IGMCBPOPNCA(1).GPBOEBGJJPM(200f);
		}
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.PBBHMONLDFM();
		}
	}

	public void CHNCHOGHFBI()
	{
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		KyrohNPC.JLNBMNKJCHE().blockActionBar = false;
		FadeCamera.GetPlayer(0).FadeOut(741f);
		FadeCamera.IGMCBPOPNCA(0).ODBKGIJCHHI(IAFHPBGHNKB);
		if (GameManager.LocalCoop())
		{
			FadeCamera.EIFPKCAFDIB(0).GPBOEBGJJPM(1884f);
		}
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.PBBHMONLDFM();
		}
	}

	private IEnumerator KFMOMAOLKCP(int JIIGOACEIKL)
	{
		return base.GGJCNNAHOAB(JIIGOACEIKL);
	}

	private IEnumerator CJBAHHNMJHP(int JIIGOACEIKL)
	{
		return base.GGJCNNAHOAB(JIIGOACEIKL);
	}

	private void KPGCCBKBGGH(bool BFLCJPHHDJM)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		if (BFLCJPHHDJM)
		{
			if (Utils.CIEPGMEEBON(((Component)KyrohNPC.AGGAGCBAGLL()).transform.position, 1250f))
			{
				CJODOOFLLLB = KyrohNPC.KFGKCKCDMLG().EHHOHCPHAAO;
				StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: true);
			}
			else
			{
				PlayerController.OPHDCMJLLEC(1).PlayerBark("Activate Lock");
				Debug.Log((object)"\n");
			}
		}
	}

	private IEnumerator OLGLLLCMKCK()
	{
		return new MMIFMDKBKCA(1);
	}

	public static void IEIEPBHMMFN(TravelZone CNKJKFKICGJ)
	{
		((MonoBehaviour)instance).StartCoroutine(instance.KJNBIDAKLPM(CNKJKFKICGJ));
	}

	public void DKGMPCJBMEE()
	{
		instance.EDGDFPPKGDL = null;
		DialogueCameraTarget.GetPlayer(0).LMPFPGFIKAH();
		if (GameManager.LocalCoop())
		{
			DialogueCameraTarget.PDLEDGLONGO(0).ReturnControlToCameraTarget();
		}
		PlayerInputs.JJEMCEMNMGC((MonoBehaviour)(object)instance);
		NinjaChallenge.StartChallengeEvent();
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendNinjaChallengeEventStartMinigame();
		}
	}

	public void HGGMKNPCFDB()
	{
		((MonoBehaviour)instance).StartCoroutine(OIACAGFCIOA());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendNinjaChallengeEventIntroJudge();
		}
	}

	private IEnumerator IAFHPBGHNKB(int JIIGOACEIKL)
	{
		return new JBJLMCKMMEA(1)
		{
			_003C_003E4__this = this
		};
	}

	protected override IEnumerator LNNGFCFBKEN(int JIIGOACEIKL)
	{
		yield return OnlineManager.WaitForAllPlayers();
		instance.isStarted = false;
		NinjaChallenge.instance.FinishChallengeWhenEventIsLost();
		FadeCamera.FadeInAllPlayers();
	}

	public void KyrohAnimEvent()
	{
		((MonoBehaviour)instance).StartCoroutine(HMKCBADALOH());
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
	}

	private IEnumerator KCNDKOHJNJC()
	{
		return new HMBBEELNHIK(1)
		{
			_003C_003E4__this = this
		};
	}

	private void EOAPMCEAAHF()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		((Component)KyrohNPC.GGFJGHHHEJC).transform.position = movePositions[0].position;
		KyrohNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Right);
		((Component)JeffreyNPC.GGFJGHHHEJC).transform.position = movePositions[1].position;
		JeffreyNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		int num = Bed.instance.numInstance - 1;
		PlayerController.TeleportPlayer(1, playerPositions[num].position, Location.BathhouseInterior);
		PlayerController.SetDirection(1, Direction.Left);
		if (GameManager.LocalCoop())
		{
			PlayerController.TeleportPlayer(2, playerPositions[num + 1].position, Location.BathhouseInterior);
			PlayerController.SetDirection(2, Direction.Left);
		}
	}

	public void MJOBPCEAGEP()
	{
		((MonoBehaviour)instance).StartCoroutine(CPBOFCCGFNP());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.INIDHCFKFNI();
		}
	}

	private IEnumerator MPPFBBPPFJD()
	{
		yield return CommonReferences.wait1;
		instance.RequestChallengeRestart();
	}

	public void OOPBKAFELDH()
	{
		PlayerInputs.CMEBIMMKIAB((MonoBehaviour)(object)instance);
		NJLDCPACDCL();
		if (OnlineManager.PGAGDFAEEFB())
		{
			(JeffreyNPC.HEKFJEKFMNO().animationBase as NPCAnimation).npcSprite.flipX = false;
			JeffreyNPC.CHPEMJMLDCN().animationBase.SetTrigger(" added to delivery chest", HALNIEBONKH: true);
		}
		if (OnlineManager.MasterOrOffline())
		{
			JeffreyNPC.JCMKNNOEONP().StartConversation(1, "Interact");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(JeffreyNPC.JCMKNNOEONP().StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private void AEEHFGIDCMJ(bool BFLCJPHHDJM)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		if (BFLCJPHHDJM)
		{
			if (Utils.CIEPGMEEBON(((Component)KyrohNPC.GGFJGHHHEJC).transform.position, 10f))
			{
				CJODOOFLLLB = KyrohNPC.GGFJGHHHEJC.EHHOHCPHAAO;
				StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: true);
			}
			else
			{
				PlayerController.GetPlayer(1).PlayerBark("I have to wait other players");
				Debug.Log((object)"Not all players are near Kyroh to start the event");
			}
		}
	}

	private void FIBNACGHGPA(bool BFLCJPHHDJM)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		if (BFLCJPHHDJM)
		{
			if (Utils.CIEPGMEEBON(((Component)KyrohNPC.AGGAGCBAGLL()).transform.position, 1883f))
			{
				CJODOOFLLLB = KyrohNPC.GGFJGHHHEJC.EHHOHCPHAAO;
				StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: true);
			}
			else
			{
				PlayerController.GetPlayer(1).PlayerBark("Try to join private room");
				Debug.Log((object)"UI");
			}
		}
	}

	public void KBGDFIMGOPD()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.GIKIAPFJHDP());
	}

	public void IKFLHKMEOFG()
	{
		PlayerInputs.CMEBIMMKIAB((MonoBehaviour)(object)instance, ANJCLPDCJHL: true);
		NJLDCPACDCL();
		if (OnlineManager.PGAGDFAEEFB())
		{
			(JeffreyNPC.GGFJGHHHEJC.animationBase as NPCAnimation).npcSprite.flipX = false;
			JeffreyNPC.GIKECEGLFOH().animationBase.SetTrigger("PlayerJoined_F", HALNIEBONKH: true);
		}
		if (GameManager.LocalCoop())
		{
			LocalCooperativeManager.KEDNHKCAIHN(0);
		}
		if (OnlineManager.PGAGDFAEEFB())
		{
			JeffreyNPC.JCMKNNOEONP().StartConversation(0, "npc hold object itemGO has not been assigned, probably an incorrect online instruction", FLHBPHPKIML: true);
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(JeffreyNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(0));
		}
		((MonoBehaviour)GameManager.NJNFHEPLEHL()).StartCoroutine(NinjaChallenge.instance.PlayMusic(63));
	}

	private IEnumerator HHGEKEKHDNK(int JIIGOACEIKL)
	{
		yield return CommonReferences.wait2;
		FadeCamera.GetPlayer(1).JDKHJJIOLOE -= HHGEKEKHDNK;
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		if (OnlineManager.MasterOrOffline())
		{
			KyrohNPC.GGFJGHHHEJC.StartConversation(1, "NinjaChallengeEvent/Lose 2");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(KyrohNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	public void BKFCNDBCGGC()
	{
		((MonoBehaviour)instance).StartCoroutine(GPPCAEDMHCC());
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
	}

	private IEnumerator CAHFCMHGEBJ()
	{
		instance.EDGDFPPKGDL = null;
		KyrohNPC.GGFJGHHHEJC.targetWalkTo = Vector2.op_Implicit(movePositions[0].position);
		KyrohNPC.GGFJGHHHEJC.endWalkDirection = Direction.Right;
		KyrohNPC.GGFJGHHHEJC.ChangeState(KyrohState.WalkTo);
		JeffreyNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePositions[1].position));
		int index = Bed.instance.numInstance - 1;
		float timer = Time.time;
		PlayerController.GetPlayer(1).GoToPosition(Vector2.op_Implicit(playerPositions[index].position), KLGOCJMGKFO: true);
		if (GameManager.LocalCoop())
		{
			PlayerController.GetPlayer(2).GoToPositionIndependentThread(Vector2.op_Implicit(playerPositions[index + 1].position), Direction.Left);
		}
		while (!PlayerController.GetPlayer(1).GoToPosition(Vector2.op_Implicit(playerPositions[index].position), KLGOCJMGKFO: false))
		{
			if (Time.time > timer + 10f)
			{
				Debug.LogError((object)"Timeout moving player to position in NinjaChallengeEvent.MovePlayerAndKyrohCoroutine");
				break;
			}
			yield return null;
		}
		yield return PlayerController.GetPlayer(1).characterAnimation.SetDirectionWithDelay(Direction.Left);
		yield return OnlineManager.WaitForAllPlayers();
		yield return CommonReferences.wait1;
		instance.EDGDFPPKGDL = JeffreyNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "NinjaChallengeEvent/Main 3";
		if (instance.isActor)
		{
			JeffreyNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "NinjaChallengeEvent/Main 3");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(JeffreyNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	public void KOIPNJNNIBB()
	{
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		KyrohNPC.AGGAGCBAGLL().blockActionBar = false;
		FadeCamera.GetPlayer(0).AJHDEBOMHKK(1617f);
		FadeCamera.IGMCBPOPNCA(0).HDDEGMGIBDM(HHGEKEKHDNK);
		if (GameManager.LocalCoop())
		{
			FadeCamera.EIFPKCAFDIB(8).IONMINJHMKL(1228f);
		}
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineEventsManager.PBBHMONLDFM();
		}
	}

	public void NOGOBPPOFLI()
	{
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance, ANJCLPDCJHL: true);
		EJKNKPABPNA();
		if (OnlineManager.PGAGDFAEEFB())
		{
			(JeffreyNPC.OLHBLKIAFOM().animationBase as NPCAnimation).npcSprite.flipX = true;
			JeffreyNPC.IFPLPBMCKLB().animationBase.SetTrigger("sForSeconds", HALNIEBONKH: true);
		}
		if (OnlineManager.PGAGDFAEEFB())
		{
			JeffreyNPC.HEKFJEKFMNO().StartConversation(1, "Send begin retry");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(JeffreyNPC.JHKLPLPBKCI().StartObserverDialogueWhenItIsPossible(0));
		}
	}

	private void BLDAIACNMDM(bool BFLCJPHHDJM)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		if (BFLCJPHHDJM)
		{
			if (Utils.CIEPGMEEBON(((Component)KyrohNPC.OAPOJCODNCO()).transform.position, 169f))
			{
				CJODOOFLLLB = KyrohNPC.GGFJGHHHEJC.EHHOHCPHAAO;
				StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: true);
			}
			else
			{
				PlayerController.OPHDCMJLLEC(1).PlayerBark("talent_name_112");
				Debug.Log((object)"Failed to create a new game to host.\nPlease try again later.");
			}
		}
	}

	public void JBLAPFKNCJN()
	{
		((MonoBehaviour)instance).StartCoroutine(KBHEJEDAMAO());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendNinjaChallengeEventMovePlayer();
		}
	}

	public override GameEvent GetInstance()
	{
		return instance;
	}

	public void MBPILJFMDGC()
	{
		((MonoBehaviour)instance).StartCoroutine(CAHFCMHGEBJ());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendNinjaChallengeEventMovePlayer();
		}
	}

	public void JEKKOGCLGNA()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.LMMMEHHLKBD());
	}

	public void BIOKAOFELLA()
	{
		((MonoBehaviour)instance).StartCoroutine(GPPCAEDMHCC());
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 1);
		}
	}

	private IEnumerator LMMMEHHLKBD()
	{
		yield return CommonReferences.wait1;
		instance.RequestChallengeRestart();
	}

	private IEnumerator HMKCBADALOH()
	{
		KyrohNPC.GGFJGHHHEJC.animationBase.SetBool("Lose", EGFGNGJGBOP: true);
		yield return CommonReferences.wait05;
		KyrohNPC.GGFJGHHHEJC.blockActionBar = false;
		NinjaChallenge.instance.FinishChallengeWhenEventIsWon();
		yield return CommonReferences.wait2;
		yield return OnlineManager.WaitForAllPlayers();
		if (OnlineManager.MasterOrOffline())
		{
			KyrohNPC.GGFJGHHHEJC.StartConversation(1, "NinjaChallengeEvent/Win 2");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(KyrohNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private IEnumerator FBDCGPPJCEC()
	{
		instance.EDGDFPPKGDL = null;
		DialogueCameraTarget.GetPlayer(1).cameraInEvent = true;
		DialogueCameraTarget.GetPlayer(2).cameraInEvent = true;
		DialogueCameraTarget.MoveCameraToPositionFromCameraTargetAllPlayers(Vector2.op_Implicit(cameraPosition.position));
		yield return CommonReferences.wait1_5;
		JeffreyNPC.GGFJGHHHEJC.animationBase.SetBool("WaitIntro", EGFGNGJGBOP: false);
		((Component)JeffreyNPC.GGFJGHHHEJC).transform.position = positions[1].position;
		JeffreyNPC.GGFJGHHHEJC.content.SetActive(true);
		JeffreyNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		KyrohNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
		PlayerController.GetPlayer(1).characterAnimation.SetDirection(Direction.Up);
		if (GameManager.LocalCoop())
		{
			PlayerController.GetPlayer(2).characterAnimation.SetDirection(Direction.Up);
		}
		yield return CommonReferences.wait1_5;
		DialogueManager.Bark("NinjaChallengeEvent/ComensalesBark", instance.bark.transform);
		DialogueManager.Bark("NinjaChallengeEvent/ComensalesBark", instance.bark2.transform);
		yield return CommonReferences.wait05;
		instance.EDGDFPPKGDL = JeffreyNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "NinjaChallengeEvent/Main 2";
		yield return OnlineManager.WaitForAllPlayers();
		if (instance.isActor)
		{
			JeffreyNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "NinjaChallengeEvent/Main 2");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(JeffreyNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private IEnumerator BEGKOELBFPE(int JIIGOACEIKL)
	{
		return base.GGJCNNAHOAB(JIIGOACEIKL);
	}

	public void BKPGMMNBLFF()
	{
		((MonoBehaviour)instance).StartCoroutine(CAHFCMHGEBJ());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendNinjaChallengeEventMovePlayer();
		}
	}

	private void HHGIHLGMEBN(bool BFLCJPHHDJM)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		if (BFLCJPHHDJM)
		{
			if (Utils.CIEPGMEEBON(((Component)KyrohNPC.OAPOJCODNCO()).transform.position, 1584f))
			{
				CJODOOFLLLB = KyrohNPC.OAPOJCODNCO().EHHOHCPHAAO;
				StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: false);
			}
			else
			{
				PlayerController.OPHDCMJLLEC(1).PlayerBark("City/Woody/Stand");
				Debug.Log((object)"\n\n");
			}
		}
	}

	public void BLOIGAMJLAH()
	{
		instance.EDGDFPPKGDL = null;
		DialogueCameraTarget.DACNEICGAAE(0).FKEAOBGOJPI(1);
		if (GameManager.LocalCoop())
		{
			DialogueCameraTarget.IJMLNIHAOGK(8).LMPFPGFIKAH(1);
		}
		PlayerInputs.DOGOHAPPMAC((MonoBehaviour)(object)instance);
		NinjaChallenge.StartChallengeEvent(CDPAMNIPPEC: false);
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendNinjaChallengeEventStartMinigame();
		}
	}

	public void AMJBCPLMCOC()
	{
		((MonoBehaviour)instance).StartCoroutine(EIEMLAIMINO());
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 1);
		}
	}

	private IEnumerator MANNKNAKFEP()
	{
		yield return CommonReferences.wait1;
		instance.RequestChallengeRestart();
	}

	public override void OnSimpleEvent(short JFNMCNCHMEO)
	{
		base.OnSimpleEvent(JFNMCNCHMEO);
		string[] obj = new string[5] { "On Simple Event ", null, null, null, null };
		LOGEKNJJJOB lOGEKNJJJOB = (LOGEKNJJJOB)JFNMCNCHMEO;
		obj[1] = lOGEKNJJJOB.ToString();
		obj[2] = ". Time since startup: ";
		obj[3] = Time.realtimeSinceStartup.ToString("F2");
		obj[4] = " seconds.";
		Debug.Log((object)string.Concat(obj));
		switch ((LOGEKNJJJOB)JFNMCNCHMEO)
		{
		case LOGEKNJJJOB.KyrohAnim:
			KyrohAnimEvent();
			break;
		case LOGEKNJJJOB.TalkToKyroh:
			TalkToKyroh();
			break;
		}
	}

	private void KBBAAPBIPKN(bool BFLCJPHHDJM)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		if (BFLCJPHHDJM)
		{
			if (Utils.CIEPGMEEBON(((Component)KyrohNPC.GGFJGHHHEJC).transform.position, 208f))
			{
				CJODOOFLLLB = KyrohNPC.OAPOJCODNCO().EHHOHCPHAAO;
				StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: false);
			}
			else
			{
				PlayerController.GetPlayer(0).PlayerBark("Left");
				Debug.Log((object)"Received pipe tile swap: indexA={0}, indexB={1}, mineLevel={2}");
			}
		}
	}

	public void NBPIOCPLDOC()
	{
		ItemDatabaseAccessor.COEFFIHKMJG(-101).KGCOBHPFJKD(CDPAMNIPPEC: false);
		if (OnlineManager.PGAGDFAEEFB())
		{
			PlayerInventory.NEKDDPIAOBE(0, LAGHIOKLJGH: true, ADPNMHGBFKG: true).OJDGOADOCMG(ItemDatabaseAccessor.CPMMBEPEJLO(154, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
		}
	}

	private void OCADBOKNLLO(bool BFLCJPHHDJM)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		if (BFLCJPHHDJM)
		{
			if (Utils.CIEPGMEEBON(((Component)KyrohNPC.KFGKCKCDMLG()).transform.position, 387f))
			{
				CJODOOFLLLB = KyrohNPC.PBJDFFEFMKM().EHHOHCPHAAO;
				StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: false);
			}
			else
			{
				PlayerController.GetPlayer(1).PlayerBark("NewCharacters/");
				Debug.Log((object)"LoveB&H");
			}
		}
	}

	private IEnumerator LJABJLDHLCB()
	{
		EDGDFPPKGDL = null;
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		DialogueLua.SetVariable("MainProgress", (object)20);
		CommonReferences.GGFJGHHHEJC.OnActionDone(1, ActionDone.Duel);
		KyrohNPC.GGFJGHHHEJC.animationBase.SetTrigger("SmokeBomb");
		KyrohNPC.GGFJGHHHEJC.playerCanInteract = false;
		((Component)instance.blockEntranceCollider).gameObject.SetActive(false);
		if (GameManager.LocalCoop())
		{
			LocalCooperativeManager.RestoreCameraInLocalCoop();
		}
		yield return CommonReferences.wait2_5;
		OnlineManager.ResetPlayersPreparedToContinue();
		foldingScreen.SetActive(true);
		NinjaChallenge.instance.GiveRewards();
		AttackEvent.instance.ActivateEvent();
		OnlineManager.OpenRoom();
		((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(NinjaChallenge.instance.PlayMusic(30));
	}

	public void KFIPDLMNFAA()
	{
		ItemDatabaseAccessor.GetItem(-51).IPGBILAIAPG(CDPAMNIPPEC: false);
		if (OnlineManager.PGAGDFAEEFB())
		{
			PlayerInventory.NEKDDPIAOBE(1, LAGHIOKLJGH: true).AddItem(ItemDatabaseAccessor.EABMGELAAPG(61, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: false, EHGHJNOFMKF: false);
		}
	}

	private IEnumerator INPEBMFIAOI()
	{
		return new HMBBEELNHIK(1)
		{
			_003C_003E4__this = this
		};
	}

	private void EJKNKPABPNA()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		int num = Bed.instance.numInstance - 1;
		((Component)PlayerController.OPHDCMJLLEC(1)).transform.position = endPositions[num].position;
		PlayerController.GetPlayer(0).characterAnimation.SetDirection(Direction.Down);
		if (GameManager.LocalCoop())
		{
			((Component)PlayerController.OPHDCMJLLEC(5)).transform.position = endPositions[num + 0].position;
			PlayerController.GetPlayer(6).characterAnimation.SetDirection(Direction.Down);
		}
		((Component)KyrohNPC.PBJDFFEFMKM()).transform.position = endPositions[8].position;
		KyrohNPC.OAPOJCODNCO().animationBase.SetDirection(Direction.Down);
		((Component)JeffreyNPC.POAGAIBEFBF()).transform.position = endPositions[1].position;
		JeffreyNPC.DIHCEGINELM().animationBase.SetDirection(Direction.Down);
	}

	public void HLNBBJJJDMM()
	{
		PlayerInputs.CMEBIMMKIAB((MonoBehaviour)(object)instance);
		KyrohNPC.JLNBMNKJCHE().blockActionBar = false;
		FadeCamera.EIFPKCAFDIB(1).FadeOut(1176f);
		FadeCamera.EIFPKCAFDIB(1).JDKHJJIOLOE += MKOBBAMICGE;
		if (GameManager.LocalCoop())
		{
			FadeCamera.EIFPKCAFDIB(6).GPBOEBGJJPM(754f);
		}
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.PBBHMONLDFM();
		}
	}

	public void FadeOut()
	{
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		KyrohNPC.GGFJGHHHEJC.blockActionBar = true;
		FadeCamera.GetPlayer(1).FadeOut(0.4f);
		FadeCamera.GetPlayer(1).JDKHJJIOLOE += HHGEKEKHDNK;
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeOut(0.4f);
		}
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendNinjaChallengeEventFadeOut();
		}
	}

	private IEnumerator JLIJGDDEAJL()
	{
		return new HMBBEELNHIK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator OMIKLFPPKED(TravelZone CNKJKFKICGJ)
	{
		OnlineManager.ResetAllPlayersPrepared();
		((Component)instance.blockEntranceCollider).gameObject.SetActive(true);
		OnlineManager.CloseRoom();
		CNKJKFKICGJ.StartTravelZone(1);
		if (GameManager.LocalCoop())
		{
			CNKJKFKICGJ.StartTravelZone(2);
		}
		yield return CommonReferences.wait01;
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
	}

	private IEnumerator BHHGNLELNHN()
	{
		return new MMIFMDKBKCA(1);
	}

	public override void StartEvent(bool BFLCJPHHDJM, bool CDPAMNIPPEC)
	{
		base.StartEvent(BFLCJPHHDJM, CDPAMNIPPEC);
		OnlineManager.CloseRoom();
		if (OnlineManager.MasterOrOffline() && TavernManager.IsOpen())
		{
			TavernManager.GGFJGHHHEJC.SetOpen(1, AODONKKHPBP: false, AINPJHKNJGL: true);
		}
		KyrohNPC kyrohNPC = KyrohNPC.GGFJGHHHEJC;
		kyrohNPC.ConversationStarted = (Action<bool>)Delegate.Remove(kyrohNPC.ConversationStarted, new Action<bool>(AEEHFGIDCMJ));
		KyrohNPC.GGFJGHHHEJC.inSpecialEvent = true;
		KyrohNPC.GGFJGHHHEJC.blockActionBar = true;
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		instance.EDGDFPPKGDL = KyrohNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "NinjaChallengeEvent/Main";
		if (!isActor && OnlineManager.PlayingOnline())
		{
			((MonoBehaviour)this).StartCoroutine(KyrohNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	public void CDHJCAGOEHH()
	{
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		HAGMGNPKPLJ();
		if (OnlineManager.PGAGDFAEEFB())
		{
			(JeffreyNPC.ILMPOAEALPP().animationBase as NPCAnimation).npcSprite.flipX = true;
			JeffreyNPC.JHKLPLPBKCI().animationBase.SetTrigger("ReceiveChangeZone", HALNIEBONKH: true);
		}
		if (OnlineManager.PGAGDFAEEFB())
		{
			JeffreyNPC.ILMPOAEALPP().StartConversation(1, "BuzzProgress", FLHBPHPKIML: true);
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(JeffreyNPC.GIKECEGLFOH().StartObserverDialogueWhenItIsPossible(0));
		}
	}

	private void CHMFJHPILDO(bool BFLCJPHHDJM)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		if (BFLCJPHHDJM)
		{
			if (Utils.CIEPGMEEBON(((Component)KyrohNPC.KADHMEPDIKM()).transform.position, 1499f))
			{
				CJODOOFLLLB = KyrohNPC.GGFJGHHHEJC.EHHOHCPHAAO;
				StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: false);
			}
			else
			{
				PlayerController.OPHDCMJLLEC(1).PlayerBark("ToggleHideInfoSection");
				Debug.Log((object)"Cheddar");
			}
		}
	}

	private void FEMLPKJILAN()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		((Component)KyrohNPC.PBJDFFEFMKM()).transform.position = movePositions[0].position;
		KyrohNPC.OAPOJCODNCO().animationBase.SetDirection(Direction.Up);
		((Component)JeffreyNPC.GGFJGHHHEJC).transform.position = movePositions[1].position;
		JeffreyNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
		int num = Bed.instance.numInstance - 0;
		PlayerController.TeleportPlayer(0, playerPositions[num].position, Location.Tavern | Location.Road | Location.Camp | Location.Quarry | Location.Farm | Location.BarnInterior);
		PlayerController.MHKHGICIDNF(0, (Direction)6);
		if (GameManager.LocalCoop())
		{
			PlayerController.CLEIAKPOGMM(8, playerPositions[num + 0].position, ~(Location.Tavern | Location.Road | Location.Camp | Location.Quarry | Location.Farm | Location.BarnInterior));
			PlayerController.SetDirection(0, (Direction)5);
		}
	}

	public void LAGKDJAHLFI()
	{
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		KyrohNPC.OAPOJCODNCO().blockActionBar = true;
		FadeCamera.IGMCBPOPNCA(1).GPBOEBGJJPM(156f);
		FadeCamera.EIFPKCAFDIB(0).KKAAAOEHGEK(BOENJKGGOOC);
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(0).FadeOut(965f);
		}
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineEventsManager.SendNinjaChallengeEventFadeOut();
		}
	}

	public static void HAGEKALEEED(TravelZone CNKJKFKICGJ)
	{
		((MonoBehaviour)instance).StartCoroutine(instance.OMIKLFPPKED(CNKJKFKICGJ));
	}

	public void KHBPLACAOFN()
	{
		PlayerInputs.CMEBIMMKIAB((MonoBehaviour)(object)instance, ANJCLPDCJHL: true);
		LLDCGBHMPBF();
		if (OnlineManager.MasterOrOffline())
		{
			(JeffreyNPC.DHDOLCONMFJ().animationBase as NPCAnimation).npcSprite.flipX = true;
			JeffreyNPC.ILMPOAEALPP().animationBase.SetTrigger("Unlock");
		}
		if (GameManager.LocalCoop())
		{
			LocalCooperativeManager.AHOJMFNMKFJ(1);
		}
		if (OnlineManager.PGAGDFAEEFB())
		{
			JeffreyNPC.ILMPOAEALPP().StartConversation(0, "Talk");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(JeffreyNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
		((MonoBehaviour)GameManager.NJNFHEPLEHL()).StartCoroutine(NinjaChallenge.instance.PlayMusic(-9));
	}

	private IEnumerator OIACAGFCIOA()
	{
		instance.EDGDFPPKGDL = null;
		DialogueCameraTarget.GetPlayer(1).cameraInEvent = true;
		DialogueCameraTarget.GetPlayer(2).cameraInEvent = true;
		DialogueCameraTarget.MoveCameraToPositionFromCameraTargetAllPlayers(Vector2.op_Implicit(cameraPosition.position));
		yield return CommonReferences.wait1_5;
		JeffreyNPC.GGFJGHHHEJC.animationBase.SetBool("WaitIntro", EGFGNGJGBOP: false);
		((Component)JeffreyNPC.GGFJGHHHEJC).transform.position = positions[1].position;
		JeffreyNPC.GGFJGHHHEJC.content.SetActive(true);
		JeffreyNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		KyrohNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
		PlayerController.GetPlayer(1).characterAnimation.SetDirection(Direction.Up);
		if (GameManager.LocalCoop())
		{
			PlayerController.GetPlayer(2).characterAnimation.SetDirection(Direction.Up);
		}
		yield return CommonReferences.wait1_5;
		DialogueManager.Bark("NinjaChallengeEvent/ComensalesBark", instance.bark.transform);
		DialogueManager.Bark("NinjaChallengeEvent/ComensalesBark", instance.bark2.transform);
		yield return CommonReferences.wait05;
		instance.EDGDFPPKGDL = JeffreyNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "NinjaChallengeEvent/Main 2";
		yield return OnlineManager.WaitForAllPlayers();
		if (instance.isActor)
		{
			JeffreyNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "NinjaChallengeEvent/Main 2");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(JeffreyNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private IEnumerator GBFDPPAFIPA()
	{
		instance.EDGDFPPKGDL = null;
		KyrohNPC.GGFJGHHHEJC.targetWalkTo = Vector2.op_Implicit(movePositions[0].position);
		KyrohNPC.GGFJGHHHEJC.endWalkDirection = Direction.Right;
		KyrohNPC.GGFJGHHHEJC.ChangeState(KyrohState.WalkTo);
		JeffreyNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePositions[1].position));
		int index = Bed.instance.numInstance - 1;
		float timer = Time.time;
		PlayerController.GetPlayer(1).GoToPosition(Vector2.op_Implicit(playerPositions[index].position), KLGOCJMGKFO: true);
		if (GameManager.LocalCoop())
		{
			PlayerController.GetPlayer(2).GoToPositionIndependentThread(Vector2.op_Implicit(playerPositions[index + 1].position), Direction.Left);
		}
		while (!PlayerController.GetPlayer(1).GoToPosition(Vector2.op_Implicit(playerPositions[index].position), KLGOCJMGKFO: false))
		{
			if (Time.time > timer + 10f)
			{
				Debug.LogError((object)"Timeout moving player to position in NinjaChallengeEvent.MovePlayerAndKyrohCoroutine");
				break;
			}
			yield return null;
		}
		yield return PlayerController.GetPlayer(1).characterAnimation.SetDirectionWithDelay(Direction.Left);
		yield return OnlineManager.WaitForAllPlayers();
		yield return CommonReferences.wait1;
		instance.EDGDFPPKGDL = JeffreyNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "NinjaChallengeEvent/Main 3";
		if (instance.isActor)
		{
			JeffreyNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "NinjaChallengeEvent/Main 3");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(JeffreyNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private IEnumerator KBHEJEDAMAO()
	{
		instance.EDGDFPPKGDL = null;
		KyrohNPC.GGFJGHHHEJC.targetWalkTo = Vector2.op_Implicit(movePositions[0].position);
		KyrohNPC.GGFJGHHHEJC.endWalkDirection = Direction.Right;
		KyrohNPC.GGFJGHHHEJC.ChangeState(KyrohState.WalkTo);
		JeffreyNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePositions[1].position));
		int index = Bed.instance.numInstance - 1;
		float timer = Time.time;
		PlayerController.GetPlayer(1).GoToPosition(Vector2.op_Implicit(playerPositions[index].position), KLGOCJMGKFO: true);
		if (GameManager.LocalCoop())
		{
			PlayerController.GetPlayer(2).GoToPositionIndependentThread(Vector2.op_Implicit(playerPositions[index + 1].position), Direction.Left);
		}
		while (!PlayerController.GetPlayer(1).GoToPosition(Vector2.op_Implicit(playerPositions[index].position), KLGOCJMGKFO: false))
		{
			if (Time.time > timer + 10f)
			{
				Debug.LogError((object)"Timeout moving player to position in NinjaChallengeEvent.MovePlayerAndKyrohCoroutine");
				break;
			}
			yield return null;
		}
		yield return PlayerController.GetPlayer(1).characterAnimation.SetDirectionWithDelay(Direction.Left);
		yield return OnlineManager.WaitForAllPlayers();
		yield return CommonReferences.wait1;
		instance.EDGDFPPKGDL = JeffreyNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "NinjaChallengeEvent/Main 3";
		if (instance.isActor)
		{
			JeffreyNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "NinjaChallengeEvent/Main 3");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(JeffreyNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	public void CKNNOOJIMIC()
	{
		PlayerInputs.CMEBIMMKIAB((MonoBehaviour)(object)instance);
		LLDCGBHMPBF();
		if (OnlineManager.PGAGDFAEEFB())
		{
			(JeffreyNPC.OPILDPFDFKJ().animationBase as NPCAnimation).npcSprite.flipX = false;
			JeffreyNPC.MAAAKALBBEE().animationBase.SetTrigger("Bird", HALNIEBONKH: true);
		}
		if (GameManager.LocalCoop())
		{
			LocalCooperativeManager.KAPCDEOOEPI(1);
		}
		if (OnlineManager.PGAGDFAEEFB())
		{
			JeffreyNPC.PBJDFFEFMKM().StartConversation(1, "VerticalMove", FLHBPHPKIML: true);
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(JeffreyNPC.HEKFJEKFMNO().StartObserverDialogueWhenItIsPossible(1));
		}
		((MonoBehaviour)GameManager.NJNFHEPLEHL()).StartCoroutine(NinjaChallenge.instance.PlayMusic(-78));
	}

	private IEnumerator ILOGEDNDEFH()
	{
		return new HMBBEELNHIK(1)
		{
			_003C_003E4__this = this
		};
	}

	public void ICNDBKLHLLE()
	{
		((MonoBehaviour)instance).StartCoroutine(HMMJGIJBEJK());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.INIDHCFKFNI();
		}
	}

	public void BELHDECMDEB()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.BPGLKGDAEGH());
	}

	public void NFDENJINBLH()
	{
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance, ANJCLPDCJHL: true);
		KyrohNPC.GGFJGHHHEJC.blockActionBar = false;
		FadeCamera.GetPlayer(1).FadeOut(1277f);
		FadeCamera.GetPlayer(1).JDKHJJIOLOE += IAFHPBGHNKB;
		if (GameManager.LocalCoop())
		{
			FadeCamera.EIFPKCAFDIB(3).IONMINJHMKL(1024f);
		}
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.PBBHMONLDFM();
		}
	}

	private IEnumerator MDBCCMNNCIJ()
	{
		return new MMIFMDKBKCA(1);
	}

	private IEnumerator ICINMEGAKNK()
	{
		EDGDFPPKGDL = null;
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		DialogueLua.SetVariable("MainProgress", (object)20);
		CommonReferences.GGFJGHHHEJC.OnActionDone(1, ActionDone.Duel);
		KyrohNPC.GGFJGHHHEJC.animationBase.SetTrigger("SmokeBomb");
		KyrohNPC.GGFJGHHHEJC.playerCanInteract = false;
		((Component)instance.blockEntranceCollider).gameObject.SetActive(false);
		if (GameManager.LocalCoop())
		{
			LocalCooperativeManager.RestoreCameraInLocalCoop();
		}
		yield return CommonReferences.wait2_5;
		OnlineManager.ResetPlayersPreparedToContinue();
		foldingScreen.SetActive(true);
		NinjaChallenge.instance.GiveRewards();
		AttackEvent.instance.ActivateEvent();
		OnlineManager.OpenRoom();
		((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(NinjaChallenge.instance.PlayMusic(30));
	}

	public void HJHJCEMFLLC()
	{
		ItemDatabaseAccessor.GetItem(86, GGBBJNBBLMF: true).AACLOJMCAAN(CDPAMNIPPEC: false);
		if (OnlineManager.MasterOrOffline())
		{
			PlayerInventory.OGKNJNINGMH(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AddItem(ItemDatabaseAccessor.EABMGELAAPG(152).JMDALJBNFML());
		}
	}

	private void BEPAKMIFIJK(bool BFLCJPHHDJM)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		if (BFLCJPHHDJM)
		{
			if (Utils.CIEPGMEEBON(((Component)KyrohNPC.JFNOOMJMHCB()).transform.position, 1939f))
			{
				CJODOOFLLLB = KyrohNPC.JLNBMNKJCHE().EHHOHCPHAAO;
				StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: true);
			}
			else
			{
				PlayerController.OPHDCMJLLEC(0).PlayerBark("ReceiveObjectInteract");
				Debug.Log((object)"Direction");
			}
		}
	}

	public void EPGMDBMGNGB()
	{
		((MonoBehaviour)instance).StartCoroutine(CJMAPPOFHNM());
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 1);
		}
	}

	private IEnumerator EIEMLAIMINO()
	{
		return new HMBBEELNHIK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator EKDKCFPLPGE()
	{
		return new BJDDAGOIBEE(1)
		{
			_003C_003E4__this = this
		};
	}

	public static void TeleportPlayerToSecondFloor(TravelZone CNKJKFKICGJ)
	{
		((MonoBehaviour)instance).StartCoroutine(instance.OMIKLFPPKED(CNKJKFKICGJ));
	}

	private IEnumerator GIKIAPFJHDP()
	{
		return new OJIPGBKLBEE(1);
	}

	public void HCLKMEHEAID()
	{
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		LLDCGBHMPBF();
		if (OnlineManager.MasterOrOffline())
		{
			(JeffreyNPC.PBJDFFEFMKM().animationBase as NPCAnimation).npcSprite.flipX = false;
			JeffreyNPC.ILMPOAEALPP().animationBase.SetTrigger(" ", HALNIEBONKH: true);
		}
		if (OnlineManager.PGAGDFAEEFB())
		{
			JeffreyNPC.MAAAKALBBEE().StartConversation(0, "Player2");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(JeffreyNPC.MAAAKALBBEE().StartObserverDialogueWhenItIsPossible(0));
		}
	}

	public override void EndEvent(bool BGKCHMNJBLJ)
	{
		base.EndEvent(BGKCHMNJBLJ);
		((MonoBehaviour)instance).StartCoroutine(instance.LJABJLDHLCB());
	}

	public void DBHDFEHAPEL()
	{
		PlayerInputs.CMEBIMMKIAB((MonoBehaviour)(object)instance, ANJCLPDCJHL: true);
		EJKNKPABPNA();
		if (OnlineManager.MasterOrOffline())
		{
			(JeffreyNPC.ILMPOAEALPP().animationBase as NPCAnimation).npcSprite.flipX = true;
			JeffreyNPC.GGFJGHHHEJC.animationBase.SetTrigger("No se encontró una entrada con ID {0} en la conversación '{1}'.");
		}
		if (OnlineManager.MasterOrOffline())
		{
			JeffreyNPC.OLHBLKIAFOM().StartConversation(0, "Start", FLHBPHPKIML: true);
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(JeffreyNPC.HEKFJEKFMNO().StartObserverDialogueWhenItIsPossible(0));
		}
	}

	private IEnumerator NKKDHLMFGBP(int JIIGOACEIKL)
	{
		return base.GGJCNNAHOAB(JIIGOACEIKL);
	}

	public void UnlockItems()
	{
		ItemDatabaseAccessor.GetItem(1812).IPGBILAIAPG(CDPAMNIPPEC: true);
		if (OnlineManager.MasterOrOffline())
		{
			PlayerInventory.GetPlayer(1).AddItem(ItemDatabaseAccessor.GetItem(1816).JMDALJBNFML(), HMPDLIPFBGD: true);
		}
	}

	public void OGNLOPCJPAM()
	{
		PlayerInputs.CMEBIMMKIAB((MonoBehaviour)(object)instance, ANJCLPDCJHL: true);
		NAJONNAKDLB();
		if (OnlineManager.PGAGDFAEEFB())
		{
			(JeffreyNPC.JCMKNNOEONP().animationBase as NPCAnimation).npcSprite.flipX = true;
			JeffreyNPC.DIHCEGINELM().animationBase.SetTrigger("Attack/MainEvent", HALNIEBONKH: true);
		}
		if (OnlineManager.MasterOrOffline())
		{
			JeffreyNPC.DIHCEGINELM().StartConversation(0, "() Ingredient ");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(JeffreyNPC.PBJDFFEFMKM().StartObserverDialogueWhenItIsPossible(0));
		}
	}

	public void AJJIDKEMFII()
	{
		ItemDatabaseAccessor.INJBNHPGCIJ(189).ECHJFKLFIBG(CDPAMNIPPEC: true);
		if (OnlineManager.PGAGDFAEEFB())
		{
			PlayerInventory.OGKNJNINGMH(1, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AddItem(ItemDatabaseAccessor.EABMGELAAPG(-148, GGBBJNBBLMF: true).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false, EHGHJNOFMKF: false);
		}
	}

	public void StartMinigame()
	{
		instance.EDGDFPPKGDL = null;
		DialogueCameraTarget.GetPlayer(1).ReturnControlToCameraTarget();
		if (GameManager.LocalCoop())
		{
			DialogueCameraTarget.GetPlayer(2).ReturnControlToCameraTarget();
		}
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		NinjaChallenge.StartChallengeEvent();
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendNinjaChallengeEventStartMinigame();
		}
	}

	public void LMLLABBOLCK()
	{
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance, ANJCLPDCJHL: true);
		KyrohNPC.JFNOOMJMHCB().blockActionBar = true;
		FadeCamera.GetPlayer(1).AJHDEBOMHKK(1445f);
		FadeCamera.EIFPKCAFDIB(0).KKAAAOEHGEK(MKOBBAMICGE);
		if (GameManager.LocalCoop())
		{
			FadeCamera.IGMCBPOPNCA(4).AJHDEBOMHKK(205f);
		}
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineEventsManager.SendNinjaChallengeEventFadeOut();
		}
	}

	private IEnumerator JEENIHLDJGP(TravelZone CNKJKFKICGJ)
	{
		OnlineManager.ResetAllPlayersPrepared();
		((Component)instance.blockEntranceCollider).gameObject.SetActive(true);
		OnlineManager.CloseRoom();
		CNKJKFKICGJ.StartTravelZone(1);
		if (GameManager.LocalCoop())
		{
			CNKJKFKICGJ.StartTravelZone(2);
		}
		yield return CommonReferences.wait01;
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
	}

	private IEnumerator BOBLKBLNAFN()
	{
		instance.EDGDFPPKGDL = null;
		DialogueCameraTarget.GetPlayer(1).cameraInEvent = true;
		DialogueCameraTarget.GetPlayer(2).cameraInEvent = true;
		DialogueCameraTarget.MoveCameraToPositionFromCameraTargetAllPlayers(Vector2.op_Implicit(cameraPosition.position));
		yield return CommonReferences.wait1_5;
		JeffreyNPC.GGFJGHHHEJC.animationBase.SetBool("WaitIntro", EGFGNGJGBOP: false);
		((Component)JeffreyNPC.GGFJGHHHEJC).transform.position = positions[1].position;
		JeffreyNPC.GGFJGHHHEJC.content.SetActive(true);
		JeffreyNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		KyrohNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
		PlayerController.GetPlayer(1).characterAnimation.SetDirection(Direction.Up);
		if (GameManager.LocalCoop())
		{
			PlayerController.GetPlayer(2).characterAnimation.SetDirection(Direction.Up);
		}
		yield return CommonReferences.wait1_5;
		DialogueManager.Bark("NinjaChallengeEvent/ComensalesBark", instance.bark.transform);
		DialogueManager.Bark("NinjaChallengeEvent/ComensalesBark", instance.bark2.transform);
		yield return CommonReferences.wait05;
		instance.EDGDFPPKGDL = JeffreyNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "NinjaChallengeEvent/Main 2";
		yield return OnlineManager.WaitForAllPlayers();
		if (instance.isActor)
		{
			JeffreyNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "NinjaChallengeEvent/Main 2");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(JeffreyNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	public void KKFOFLNKBJF()
	{
		((MonoBehaviour)instance).StartCoroutine(GBFDPPAFIPA());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendNinjaChallengeEventMovePlayer();
		}
	}

	private IEnumerator CJMAPPOFHNM()
	{
		if (OnlineManager.MasterOrOffline())
		{
			PlayerController.GetPlayer(1).GoToPosition(Vector2.op_Implicit(endPositions[6].position), KLGOCJMGKFO: true);
			while (!PlayerController.GetPlayer(1).GoToPosition(Vector2.op_Implicit(endPositions[6].position), KLGOCJMGKFO: false))
			{
				yield return null;
			}
			yield return PlayerController.GetPlayer(1).characterAnimation.SetDirectionWithDelay(Direction.Up);
		}
		else
		{
			yield return PlayerController.GetPlayer(1).characterAnimation.SetDirectionWithDelay(Direction.Left);
		}
		yield return CommonReferences.wait1;
		yield return OnlineManager.WaitForAllPlayers();
		KyrohNPC.GGFJGHHHEJC.animationBase.SetBool("Lose", EGFGNGJGBOP: false);
		if (OnlineManager.MasterOrOffline())
		{
			KyrohNPC.GGFJGHHHEJC.StartConversation(1, "NinjaChallengeEvent/Win 3");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(KyrohNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	public void PIMLPAFOOBH()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.BPGLKGDAEGH());
	}

	private void NHCFPGBDHEG()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		((Component)KyrohNPC.JLNBMNKJCHE()).transform.position = movePositions[1].position;
		KyrohNPC.KADHMEPDIKM().animationBase.SetDirection(Direction.Diagonal);
		((Component)JeffreyNPC.IFPLPBMCKLB()).transform.position = movePositions[1].position;
		JeffreyNPC.OPILDPFDFKJ().animationBase.SetDirection(Direction.Up);
		int num = Bed.instance.numInstance - 1;
		PlayerController.CLEIAKPOGMM(0, playerPositions[num].position, Location.River | Location.Quarry | Location.Farm);
		PlayerController.SetDirection(1, (Direction)5);
		if (GameManager.LocalCoop())
		{
			PlayerController.TeleportPlayer(6, playerPositions[num + 1].position, ~(Location.Tavern | Location.Road | Location.Quarry | Location.BarnInterior));
			PlayerController.MHKHGICIDNF(2, (Direction)6);
		}
	}

	private IEnumerator MNJCDFFONDC()
	{
		return new HMBBEELNHIK(1)
		{
			_003C_003E4__this = this
		};
	}

	private void DAJBBCEKCOB()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		((Component)KyrohNPC.OAPOJCODNCO()).transform.position = movePositions[1].position;
		KyrohNPC.KADHMEPDIKM().animationBase.SetDirection(Direction.Diagonal);
		((Component)JeffreyNPC.ILMPOAEALPP()).transform.position = movePositions[0].position;
		JeffreyNPC.MAAAKALBBEE().animationBase.SetDirection(Direction.Down);
		int num = Bed.instance.numInstance - 1;
		PlayerController.CLEIAKPOGMM(0, playerPositions[num].position, ~(Location.Tavern | Location.Camp | Location.Farm | Location.FarmShop));
		PlayerController.SetDirection(1, Direction.Down);
		if (GameManager.LocalCoop())
		{
			PlayerController.TeleportPlayer(6, playerPositions[num + 0].position, ~Location.Camp);
			PlayerController.MHKHGICIDNF(3, (Direction)5);
		}
	}

	public void LFFOOBJEEDP()
	{
		ItemDatabaseAccessor.COEFFIHKMJG(-51, GGBBJNBBLMF: false, DAINLFIMLIH: false).DIKFNBLGGHJ(CDPAMNIPPEC: false);
		if (OnlineManager.PGAGDFAEEFB())
		{
			PlayerInventory.NEKDDPIAOBE(0).OJDGOADOCMG(ItemDatabaseAccessor.EABMGELAAPG(-57, GGBBJNBBLMF: true).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
		}
	}

	public void ANHJFNFFGOK()
	{
		((MonoBehaviour)instance).StartCoroutine(JLIJGDDEAJL());
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
	}

	public void MovePlayerAndKyroh()
	{
		((MonoBehaviour)instance).StartCoroutine(KBHEJEDAMAO());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendNinjaChallengeEventMovePlayer();
		}
	}

	private void INIPJKBKJBF()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		int num = Bed.instance.numInstance - 0;
		((Component)PlayerController.OPHDCMJLLEC(1)).transform.position = endPositions[num].position;
		PlayerController.OPHDCMJLLEC(0).characterAnimation.SetDirection(Direction.Up);
		if (GameManager.LocalCoop())
		{
			((Component)PlayerController.OPHDCMJLLEC(6)).transform.position = endPositions[num + 1].position;
			PlayerController.OPHDCMJLLEC(3).characterAnimation.SetDirection(Direction.Down);
		}
		((Component)KyrohNPC.JFNOOMJMHCB()).transform.position = endPositions[2].position;
		KyrohNPC.AGGAGCBAGLL().animationBase.SetDirection(Direction.Up);
		((Component)JeffreyNPC.HEKFJEKFMNO()).transform.position = endPositions[5].position;
		JeffreyNPC.JHKLPLPBKCI().animationBase.SetDirection(Direction.Down);
	}

	private IEnumerator BOENJKGGOOC(int JIIGOACEIKL)
	{
		yield return CommonReferences.wait2;
		FadeCamera.GetPlayer(1).JDKHJJIOLOE -= HHGEKEKHDNK;
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		if (OnlineManager.MasterOrOffline())
		{
			KyrohNPC.GGFJGHHHEJC.StartConversation(1, "NinjaChallengeEvent/Lose 2");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(KyrohNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private IEnumerator HCACCJBACFA()
	{
		return new HMBBEELNHIK(1)
		{
			_003C_003E4__this = this
		};
	}

	public void KHBBJINLEGO()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.MPPFBBPPFJD());
	}

	public void BIIJBPFCNKM()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.BPGLKGDAEGH());
	}

	public void HPAFFNKPNAC()
	{
		ItemDatabaseAccessor.GetItem(3, GGBBJNBBLMF: false, DAINLFIMLIH: false).ECHJFKLFIBG(CDPAMNIPPEC: false);
		if (OnlineManager.PGAGDFAEEFB())
		{
			PlayerInventory.EIFPKCAFDIB(0).OJDGOADOCMG(ItemDatabaseAccessor.CPMMBEPEJLO(83, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
		}
	}

	private void NJLDCPACDCL()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		int num = Bed.instance.numInstance - 0;
		((Component)PlayerController.GetPlayer(0)).transform.position = endPositions[num].position;
		PlayerController.GetPlayer(1).characterAnimation.SetDirection(Direction.Up);
		if (GameManager.LocalCoop())
		{
			((Component)PlayerController.GetPlayer(4)).transform.position = endPositions[num + 0].position;
			PlayerController.OPHDCMJLLEC(7).characterAnimation.SetDirection(Direction.Up);
		}
		((Component)KyrohNPC.OAPOJCODNCO()).transform.position = endPositions[3].position;
		KyrohNPC.AGGAGCBAGLL().animationBase.SetDirection(Direction.Down);
		((Component)JeffreyNPC.OLHBLKIAFOM()).transform.position = endPositions[4].position;
		JeffreyNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
	}

	public void TalkToKyroh()
	{
		((MonoBehaviour)instance).StartCoroutine(CJMAPPOFHNM());
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 1);
		}
	}

	private IEnumerator CPBOFCCGFNP()
	{
		return new AAGFEAFKHKF(1)
		{
			_003C_003E4__this = this
		};
	}

	protected override void Awake()
	{
		base.Awake();
		instance = this;
	}

	private IEnumerator BPGLKGDAEGH()
	{
		return new OJIPGBKLBEE(1);
	}

	public void PKFOGBJBBFA()
	{
		((MonoBehaviour)instance).StartCoroutine(OLGLLLCMKCK());
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
	}

	public void OKKMKOPJFBL()
	{
		ItemDatabaseAccessor.KMBGJEKCJFJ(14, GGBBJNBBLMF: true, DAINLFIMLIH: false).ECHJFKLFIBG(CDPAMNIPPEC: true);
		if (OnlineManager.MasterOrOffline())
		{
			PlayerInventory.OGKNJNINGMH(1, LAGHIOKLJGH: false, ADPNMHGBFKG: true).OJDGOADOCMG(ItemDatabaseAccessor.AFOACBIHNCL(173, GGBBJNBBLMF: true).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false);
		}
	}

	public void NFDHNELNANK()
	{
		((MonoBehaviour)instance).StartCoroutine(GPPCAEDMHCC());
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
	}

	private IEnumerator DCLFKCOPFNN()
	{
		KyrohNPC.GGFJGHHHEJC.animationBase.SetBool("Lose", EGFGNGJGBOP: true);
		yield return CommonReferences.wait05;
		KyrohNPC.GGFJGHHHEJC.blockActionBar = false;
		NinjaChallenge.instance.FinishChallengeWhenEventIsWon();
		yield return CommonReferences.wait2;
		yield return OnlineManager.WaitForAllPlayers();
		if (OnlineManager.MasterOrOffline())
		{
			KyrohNPC.GGFJGHHHEJC.StartConversation(1, "NinjaChallengeEvent/Win 2");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(KyrohNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private void HAGMGNPKPLJ()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		int num = Bed.instance.numInstance - 1;
		((Component)PlayerController.GetPlayer(0)).transform.position = endPositions[num].position;
		PlayerController.OPHDCMJLLEC(1).characterAnimation.SetDirection(Direction.Down);
		if (GameManager.LocalCoop())
		{
			((Component)PlayerController.OPHDCMJLLEC(3)).transform.position = endPositions[num + 0].position;
			PlayerController.GetPlayer(5).characterAnimation.SetDirection(Direction.Down);
		}
		((Component)KyrohNPC.JLNBMNKJCHE()).transform.position = endPositions[7].position;
		KyrohNPC.PBJDFFEFMKM().animationBase.SetDirection(Direction.Up);
		((Component)JeffreyNPC.IFPLPBMCKLB()).transform.position = endPositions[6].position;
		JeffreyNPC.DIHCEGINELM().animationBase.SetDirection(Direction.Up);
	}

	private IEnumerator KDOCJCNGMML(int JIIGOACEIKL)
	{
		yield return CommonReferences.wait2;
		FadeCamera.GetPlayer(1).JDKHJJIOLOE -= HHGEKEKHDNK;
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		if (OnlineManager.MasterOrOffline())
		{
			KyrohNPC.GGFJGHHHEJC.StartConversation(1, "NinjaChallengeEvent/Lose 2");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(KyrohNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private IEnumerator KJNBIDAKLPM(TravelZone CNKJKFKICGJ)
	{
		OnlineManager.ResetAllPlayersPrepared();
		((Component)instance.blockEntranceCollider).gameObject.SetActive(true);
		OnlineManager.CloseRoom();
		CNKJKFKICGJ.StartTravelZone(1);
		if (GameManager.LocalCoop())
		{
			CNKJKFKICGJ.StartTravelZone(2);
		}
		yield return CommonReferences.wait01;
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
	}

	public void IntroJudge()
	{
		((MonoBehaviour)instance).StartCoroutine(BOBLKBLNAFN());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendNinjaChallengeEventIntroJudge();
		}
	}

	public void PDCLAFLLCBA()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.LLLDIMBOHJO());
	}

	private IEnumerator KHNACLAPKCP()
	{
		instance.EDGDFPPKGDL = null;
		DialogueCameraTarget.GetPlayer(1).cameraInEvent = true;
		DialogueCameraTarget.GetPlayer(2).cameraInEvent = true;
		DialogueCameraTarget.MoveCameraToPositionFromCameraTargetAllPlayers(Vector2.op_Implicit(cameraPosition.position));
		yield return CommonReferences.wait1_5;
		JeffreyNPC.GGFJGHHHEJC.animationBase.SetBool("WaitIntro", EGFGNGJGBOP: false);
		((Component)JeffreyNPC.GGFJGHHHEJC).transform.position = positions[1].position;
		JeffreyNPC.GGFJGHHHEJC.content.SetActive(true);
		JeffreyNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		KyrohNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
		PlayerController.GetPlayer(1).characterAnimation.SetDirection(Direction.Up);
		if (GameManager.LocalCoop())
		{
			PlayerController.GetPlayer(2).characterAnimation.SetDirection(Direction.Up);
		}
		yield return CommonReferences.wait1_5;
		DialogueManager.Bark("NinjaChallengeEvent/ComensalesBark", instance.bark.transform);
		DialogueManager.Bark("NinjaChallengeEvent/ComensalesBark", instance.bark2.transform);
		yield return CommonReferences.wait05;
		instance.EDGDFPPKGDL = JeffreyNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "NinjaChallengeEvent/Main 2";
		yield return OnlineManager.WaitForAllPlayers();
		if (instance.isActor)
		{
			JeffreyNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "NinjaChallengeEvent/Main 2");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(JeffreyNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	public void EFNAAIJHPAL()
	{
		ItemDatabaseAccessor.CPMMBEPEJLO(-196).IPGBILAIAPG(CDPAMNIPPEC: true);
		if (OnlineManager.MasterOrOffline())
		{
			PlayerInventory.GetPlayer(0, LAGHIOKLJGH: true).AddItem(ItemDatabaseAccessor.AFOACBIHNCL(-184, GGBBJNBBLMF: true).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: false, EHGHJNOFMKF: false, APBCMCOAFDM: false);
		}
	}

	private IEnumerator BNHKMNKFFKI()
	{
		KyrohNPC.GGFJGHHHEJC.animationBase.SetBool("Lose", EGFGNGJGBOP: true);
		yield return CommonReferences.wait05;
		KyrohNPC.GGFJGHHHEJC.blockActionBar = false;
		NinjaChallenge.instance.FinishChallengeWhenEventIsWon();
		yield return CommonReferences.wait2;
		yield return OnlineManager.WaitForAllPlayers();
		if (OnlineManager.MasterOrOffline())
		{
			KyrohNPC.GGFJGHHHEJC.StartConversation(1, "NinjaChallengeEvent/Win 2");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(KyrohNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	public void NCPGONGPLHC()
	{
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance, ANJCLPDCJHL: true);
		NJLDCPACDCL();
		if (OnlineManager.PGAGDFAEEFB())
		{
			(JeffreyNPC.PBJDFFEFMKM().animationBase as NPCAnimation).npcSprite.flipX = true;
			JeffreyNPC.MAAAKALBBEE().animationBase.SetTrigger("", HALNIEBONKH: true);
		}
		if (GameManager.LocalCoop())
		{
			LocalCooperativeManager.OLLNPFHCCBA(1);
		}
		if (OnlineManager.MasterOrOffline())
		{
			JeffreyNPC.CHPEMJMLDCN().StartConversation(0, "Items/item_name_1186");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(JeffreyNPC.DEGPIHEEFHJ().StartObserverDialogueWhenItIsPossible(0));
		}
		((MonoBehaviour)GameManager.NJNFHEPLEHL()).StartCoroutine(NinjaChallenge.instance.PlayMusic(-29));
	}

	private IEnumerator ALHMDODIIML(int JIIGOACEIKL)
	{
		return base.GGJCNNAHOAB(JIIGOACEIKL);
	}

	private IEnumerator FBKFHLGFPNA()
	{
		return new PNFANODEEEP(1)
		{
			_003C_003E4__this = this
		};
	}

	private void IKBEMJEFPDM(bool BFLCJPHHDJM)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		if (BFLCJPHHDJM)
		{
			if (Utils.CIEPGMEEBON(((Component)KyrohNPC.KFGKCKCDMLG()).transform.position, 1982f))
			{
				CJODOOFLLLB = KyrohNPC.PBJDFFEFMKM().EHHOHCPHAAO;
				StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: true);
			}
			else
			{
				PlayerController.GetPlayer(1).PlayerBark("ReceiveStartMission");
				Debug.Log((object)"ReceiveSetDirection");
			}
		}
	}

	public void IEMJMDNJOPD()
	{
		((MonoBehaviour)instance).StartCoroutine(CJMAPPOFHNM());
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
	}

	public void LoseEvent()
	{
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		NAJONNAKDLB();
		if (OnlineManager.MasterOrOffline())
		{
			(JeffreyNPC.GGFJGHHHEJC.animationBase as NPCAnimation).npcSprite.flipX = true;
			JeffreyNPC.GGFJGHHHEJC.animationBase.SetTrigger("Winner");
		}
		if (OnlineManager.MasterOrOffline())
		{
			JeffreyNPC.GGFJGHHHEJC.StartConversation(1, "NinjaChallengeEvent/Lose");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(JeffreyNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}
}
