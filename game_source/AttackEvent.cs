using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using PixelCrushers.DialogueSystem;
using UnityEngine;
using psai.net;

public class AttackEvent : GameEvent
{
	private enum LOGEKNJJJOB
	{
		MoveLucen,
		GrabScene,
		Throw,
		Laugh,
		Shield,
		MaiPower,
		LucenPower,
		EndPower,
		LucenLeft,
		MoveCameraAndBathhousePeople,
		RescueKyroh
	}

	[CompilerGenerated]
	private sealed class GGCDLOGKLPC : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AttackEvent _003C_003E4__this;

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
		public GGCDLOGKLPC(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_013d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0142: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			AttackEvent attackEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				instance.EDGDFPPKGDL = null;
				PsaiCore.Instance.HoldCurrentIntensity(hold: false);
				PsaiCore.Instance.StopMusic(immediately: false);
				MusicController.instance.TriggerCurrentBasicMood(CommonReferences.wait20, Location.Bathhouse);
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				KyrohNPC.GGFJGHHHEJC.inSpecialEvent = false;
				KyrohNPC.GGFJGHHHEJC.blockActionBar = false;
				LucenNPC.GGFJGHHHEJC.inSpecialEvent = false;
				LucenNPC.GGFJGHHHEJC.blockActionBar = false;
				MaiNPC.GGFJGHHHEJC.inSpecialEvent = false;
				MaiNPC.GGFJGHHHEJC.blockActionBar = false;
				ZuzzuNPC.GGFJGHHHEJC.inSpecialEvent = false;
				ZuzzuNPC.GGFJGHHHEJC.blockActionBar = false;
				MaiNPC.GGFJGHHHEJC.animationBase.SetTrigger("HumanDisappear");
				DialogueLua.SetVariable("MainProgress", (object)21);
				if (!Utils.NGLLIJPOBEC(Location.Bathhouse))
				{
					_003C_003E2__current = CommonReferences.wait1;
					_003C_003E1__state = 2;
					return true;
				}
				goto IL_014c;
			case 2:
				_003C_003E1__state = -1;
				DialogueCameraTarget.GetPlayer(1).TransportCameraToPosition(Vector2.op_Implicit(((Component)CameraTarget.GetPlayer(1)).transform.position));
				goto IL_014c;
			case 3:
				_003C_003E1__state = -1;
				_003C_003E2__current = OnlineManager.WaitForAllPlayers();
				_003C_003E1__state = 4;
				return true;
			case 4:
				_003C_003E1__state = -1;
				GameActionBarUI.Get(1).OpenUI();
				PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
				MaiNPC.GGFJGHHHEJC.dialogueActor.actor = "Mai";
				MaiNPC.GGFJGHHHEJC.ResetMai();
				attackEvent.PBMJLFIJNAF();
				WorldTime.JJICPIINBEH = false;
				if (attackEvent.CEACJENCFNF != null)
				{
					((MonoBehaviour)attackEvent).StopCoroutine(attackEvent.CEACJENCFNF);
					attackEvent.CEACJENCFNF = null;
				}
				OnlineManager.ResetPlayersPreparedToContinue();
				break;
			case 5:
				{
					_003C_003E1__state = -1;
					break;
				}
				IL_014c:
				DialogueCameraTarget.GetPlayer(1).ReturnControlToCameraTarget();
				if (GameManager.LocalCoop())
				{
					LocalCooperativeManager.RestoreCameraInLocalCoop();
				}
				_003C_003E2__current = CommonReferences.wait3;
				_003C_003E1__state = 3;
				return true;
			}
			if (Utils.NGLLIJPOBEC(Location.Bathhouse))
			{
				_003C_003E2__current = null;
				_003C_003E1__state = 5;
				return true;
			}
			if (OnlineManager.MasterOrOffline())
			{
				((Behaviour)ZuzzuNPC.GGFJGHHHEJC.routine).enabled = true;
				ZuzzuNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
			}
			instance.npcsExterior.SetActive(true);
			attackEvent.SetSleepEvent();
			Puente_EAEvent.instance.ActivateEvent();
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
	private sealed class GFABOIMCDFE : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AttackEvent _003C_003E4__this;

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
		public GFABOIMCDFE(int _003C_003E1__state)
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
			AttackEvent attackEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				instance.EDGDFPPKGDL = null;
				KyrohNPC.GGFJGHHHEJC.shadow.transform.parent = null;
				LucenNPC.GGFJGHHHEJC.animationBase.SetBool("Force", EGFGNGJGBOP: true);
				KyrohNPC.GGFJGHHHEJC.animationBase.SetBool("LucenGrab", EGFGNGJGBOP: true);
				instance.EIDFODEPLBP();
				PsaiCore.Instance.HoldCurrentIntensity(hold: false);
				PsaiCore.Instance.AddToCurrentIntensity(0.3f);
				PsaiCore.Instance.HoldCurrentIntensity(hold: true);
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				attackEvent.EDGDFPPKGDL = LucenNPC.GGFJGHHHEJC;
				attackEvent.MDFALJKHKED = "Attack/MainEvent 3";
				if (instance.isActor)
				{
					LucenNPC.GGFJGHHHEJC.StartConversation(1, "Attack/MainEvent 3");
					break;
				}
				_003C_003E2__current = LucenNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
				_003C_003E1__state = 2;
				return true;
			case 2:
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
	private sealed class AHADCBGNHDM : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AttackEvent _003C_003E4__this;

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
		public AHADCBGNHDM(int _003C_003E1__state)
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
			AttackEvent attackEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				instance.EDGDFPPKGDL = null;
				LucenNPC.GGFJGHHHEJC.animationBase.SetBool("DarkStance", EGFGNGJGBOP: true);
				LucenNPC.GGFJGHHHEJC.StartIntensityDarkAuraLight(1f, FLDIKKNAKPM: false);
				attackEvent.OJJIHCEMMAD = MultiAudioManager.FadeInAudioObject(attackEvent.darkEnergy, ((Component)LucenNPC.GGFJGHHHEJC).transform, 0.5f);
				_003C_003E2__current = CommonReferences.wait03;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				LucenNPC.GGFJGHHHEJC.darkAura.SetActive(true);
				((Component)LucenNPC.GGFJGHHHEJC.darkAuraLight).gameObject.SetActive(true);
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				attackEvent.EDGDFPPKGDL = MaiNPC.GGFJGHHHEJC;
				attackEvent.MDFALJKHKED = "Attack/MainEvent 8";
				if (instance.isActor)
				{
					MaiNPC.GGFJGHHHEJC.StartConversation(1, "Attack/MainEvent 8");
					break;
				}
				_003C_003E2__current = MaiNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
				_003C_003E1__state = 3;
				return true;
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
	private sealed class BOHGAAIOMGK : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AttackEvent _003C_003E4__this;

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
		public BOHGAAIOMGK(int _003C_003E1__state)
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
			AttackEvent attackEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				instance.EDGDFPPKGDL = null;
				MaiNPC.GGFJGHHHEJC.dialogueActor.actor = "Mai ";
				MaiNPC.GGFJGHHHEJC.animationBase.SetBool("Shield", EGFGNGJGBOP: false);
				instance.shield.DisableShield();
				if (Object.op_Implicit((Object)(object)attackEvent.ADJFFGPKJHH))
				{
					attackEvent.ADJFFGPKJHH.FadeOut(0.3f, false);
				}
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.StartAlphaAvatarEyes(0.5f, FLDIKKNAKPM: false);
				MaiNPC.GGFJGHHHEJC.StartIntensityAvatarLight(0.5f, FLDIKKNAKPM: false);
				MaiNPC.GGFJGHHHEJC.animationBase.SetBool("Avatar", EGFGNGJGBOP: true);
				((Component)MaiNPC.GGFJGHHHEJC.avatarLight).gameObject.SetActive(true);
				attackEvent.HNCPLAPNGLA = MultiAudioManager.FadeInAudioObject(attackEvent.maiAvatarMode, ((Component)MaiNPC.GGFJGHHHEJC).transform, 0.5f);
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
				MaiNPC.GGFJGHHHEJC.inSpecialEvent = true;
				MaiNPC.GGFJGHHHEJC.blockActionBar = true;
				attackEvent.EDGDFPPKGDL = MaiNPC.GGFJGHHHEJC;
				attackEvent.MDFALJKHKED = "Attack/MainEvent 7";
				if (instance.isActor)
				{
					MaiNPC.GGFJGHHHEJC.StartConversation(1, "Attack/MainEvent 7");
					break;
				}
				_003C_003E2__current = MaiNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
				_003C_003E1__state = 4;
				return true;
			case 4:
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
	private sealed class IDEDMEPHNPB : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AttackEvent _003C_003E4__this;

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
		public IDEDMEPHNPB(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			AttackEvent attackEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				LucenNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(attackEvent.movePositions[2].position), Direction.Up);
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				LucenNPC.GGFJGHHHEJC.animationBase.SetTrigger("Hair");
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				attackEvent.EDGDFPPKGDL = LucenNPC.GGFJGHHHEJC;
				attackEvent.MDFALJKHKED = "Attack/MainEvent 4";
				if (instance.isActor)
				{
					LucenNPC.GGFJGHHHEJC.StartConversation(1, "Attack/MainEvent 4");
					break;
				}
				_003C_003E2__current = LucenNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
				_003C_003E1__state = 3;
				return true;
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
	private sealed class DHJHABGGDHN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AttackEvent _003C_003E4__this;

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
		public DHJHABGGDHN(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			AttackEvent attackEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				instance.EDGDFPPKGDL = null;
				KentaNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(attackEvent.movePositions[8].position));
				_003C_003E2__current = CommonReferences.wait02;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				RinNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(attackEvent.movePositions[9].position));
				_003C_003E2__current = CommonReferences.wait3;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				FadeCamera.GetPlayer(1).FadeOut(0.4f);
				FadeCamera.GetPlayer(1).JDKHJJIOLOE += attackEvent.HHGEKEKHDNK;
				if (GameManager.LocalCoop())
				{
					FadeCamera.GetPlayer(2).FadeOut(0.4f);
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
	private sealed class FNFNCINMEAD : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public AttackEvent _003C_003E4__this;

		private Vector3 _003CoffsetPosition_003E5__2;

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
		public FNFNCINMEAD(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0167: Unknown result type (might be due to invalid IL or missing references)
			//IL_016c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_010a: Unknown result type (might be due to invalid IL or missing references)
			//IL_010f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0114: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			AttackEvent attackEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				attackEvent.EDGDFPPKGDL = null;
				if (GameManager.LocalCoop())
				{
					LocalCooperativeManager.FocusCameraToPlayerInLocalCoop(1);
				}
				_003CoffsetPosition_003E5__2 = new Vector3((float)(Bed.instance.numInstance - 1) * 0.4f, (float)(Bed.instance.numInstance - 1) * 0.2f);
				PlayerController.GetPlayer(1).GoToPosition(Vector2.op_Implicit(attackEvent.movePositions[0].position + _003CoffsetPosition_003E5__2), KLGOCJMGKFO: true);
				if (GameManager.LocalCoop())
				{
					PlayerController.GetPlayer(2).GoToPositionIndependentThread(Vector2.op_Implicit(attackEvent.movePositions[0].position + new Vector3(0.5f, 0.3f)), Direction.Down);
				}
				goto IL_00f6;
			case 1:
				_003C_003E1__state = -1;
				goto IL_00f6;
			case 2:
				_003C_003E1__state = -1;
				DialogueCameraTarget.GetPlayer(1).cameraInEvent = true;
				DialogueCameraTarget.GetPlayer(1).MoveCameraToPositionFromCameraTarget(Vector2.op_Implicit(attackEvent.cameraPositions[0].position));
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 3;
				return true;
			case 3:
				_003C_003E1__state = -1;
				_003C_003E2__current = OnlineManager.WaitForAllPlayers();
				_003C_003E1__state = 4;
				return true;
			case 4:
				_003C_003E1__state = -1;
				attackEvent.EDGDFPPKGDL = KyrohNPC.GGFJGHHHEJC;
				attackEvent.MDFALJKHKED = "Attack/MainEvent";
				KyrohNPC.GGFJGHHHEJC.inSpecialEvent = true;
				KyrohNPC.GGFJGHHHEJC.blockActionBar = true;
				if (instance.isActor)
				{
					KyrohNPC.GGFJGHHHEJC.StartConversation(1, "Attack/MainEvent");
					break;
				}
				_003C_003E2__current = KyrohNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
				_003C_003E1__state = 5;
				return true;
			case 5:
				{
					_003C_003E1__state = -1;
					break;
				}
				IL_00f6:
				if (!PlayerController.GetPlayer(1).GoToPosition(Vector2.op_Implicit(attackEvent.movePositions[0].position + _003CoffsetPosition_003E5__2), KLGOCJMGKFO: false))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
				PlayerController.GetPlayer(1).characterAnimation.SetDirection(Direction.Down);
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 2;
				return true;
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

	public static AttackEvent instance;

	public Transform[] cameraPositions;

	public Transform[] initialPositions;

	public Transform[] movePositions;

	public NightStart nightStartLamp;

	public Animator stoneLamp;

	public GameObject splash;

	public MaiShield shield;

	public GameObject npcsExterior;

	public Transform endPointGrab;

	public float durationGrab = 2f;

	public float desacelerationGrab = 2f;

	private float OEEDGJHBDFL;

	[SerializeField]
	private bool movingGrab;

	private Vector3 KDPILMCIHIP;

	private Vector3 BLPLEPCFJJL;

	public Transform inicio;

	public Transform destino;

	public Transform breakLampPoint;

	public float duracion = 1.5f;

	public float gravedad = -9.8f;

	private Vector2 OMBHJEPKGAL;

	[SerializeField]
	private bool lanzando;

	[SerializeField]
	private bool breakLamp;

	private float BJOMEOAILKI;

	public float initialSpeed = 10f;

	public float desaceleracion = 5f;

	public float distanciaMax = 10f;

	private float NPCDEKGDFMK;

	private Vector3 DIFKLOCALFE;

	[SerializeField]
	private bool moviendo;

	public Transform endPoint;

	public float duration = 2f;

	public float acceleration = 2f;

	private float JHJOJONNDCD;

	[SerializeField]
	private bool movement;

	private Vector3 KPKFJGNEAEB;

	private Vector3 DBACIMHFEKD;

	public Transform dowmMovementInitPoint;

	public Transform dowmMovementEndPoint;

	public float dowmMovementDuration = 2f;

	public float dowmMovementDesaceleration = 2f;

	private float EMLOCMPLFLK;

	[SerializeField]
	private bool dowmMovement;

	private Vector3 CNFAPDNPILF;

	private Vector3 AGJAMKMHFLL;

	public AudioObject rejectDrag;

	public AudioObject flash;

	public AudioObject darkGrabThrow;

	public AudioObject darkGrabLoop;

	public AudioObject darkLaunch;

	public AudioObject darkEnergy;

	public AudioObject magicShield;

	public AudioObject maiAvatarMode;

	public AudioObject lucenLaugh;

	private MultiAudioSource MJJJEPMFAKD;

	private MultiAudioSource OJJIHCEMMAD;

	private MultiAudioSource ADJFFGPKJHH;

	private MultiAudioSource HNCPLAPNGLA;

	public float flashTime;

	private Coroutine CEACJENCFNF;

	private float DCGBADKLANM;

	private float EGGCGDGADKP;

	public void HorizontalMovementUpdate()
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		if (moviendo && !OnlineManager.ClientOnline())
		{
			NPCDEKGDFMK -= desaceleracion * Time.deltaTime;
			if (NPCDEKGDFMK < 0f)
			{
				NPCDEKGDFMK = 0f;
				moviendo = false;
			}
			Transform transform = ((Component)KyrohNPC.GGFJGHHHEJC).transform;
			transform.position += Vector3.right * NPCDEKGDFMK * Time.deltaTime;
			if (((Component)KyrohNPC.GGFJGHHHEJC).transform.position.x >= DIFKLOCALFE.x + distanciaMax)
			{
				moviendo = false;
				((Component)KyrohNPC.GGFJGHHHEJC).transform.position = new Vector3(DIFKLOCALFE.x + distanciaMax, DIFKLOCALFE.y, DIFKLOCALFE.z);
			}
		}
	}

	public void OLCNFINDMBI()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.HBGOJJADDPH());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 1);
		}
	}

	public void AEBNKILLFEK()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.FBHPEHLEDKE());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 4);
		}
	}

	private IEnumerator PIMADJBGICP()
	{
		OnlineManager.ResetAllPlayersPrepared();
		TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.BathhouseInterior, Location.Bathhouse).StartTravelZone(1);
		if (GameManager.LocalCoop())
		{
			TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.BathhouseInterior, Location.Bathhouse).StartTravelZone(2);
		}
		yield return CommonReferences.wait01;
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
	}

	private IEnumerator HHGEKEKHDNK(int JIIGOACEIKL)
	{
		yield return CommonReferences.wait3;
		FadeCamera.GetPlayer(1).JDKHJJIOLOE -= HHGEKEKHDNK;
		ZuzzuNPC.GGFJGHHHEJC.content.SetActive(false);
		KentaNPC.GGFJGHHHEJC.content.SetActive(false);
		RinNPC.GGFJGHHHEJC.content.SetActive(false);
		KyrohNPC.GGFJGHHHEJC.content.SetActive(false);
		if (isActor)
		{
			PlayerController.GetPlayer(1).SetDirection(Direction.Down);
		}
		if (GameManager.LocalCoop())
		{
			PlayerController.GetPlayer(2).SetDirection(Direction.Down);
		}
		yield return OnlineManager.WaitForAllPlayers();
		FadeCamera.GetPlayer(1).FadeInWithDelay();
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(GEHNCBAJNKP));
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeInWithDelay();
		}
	}

	private IEnumerator OJFKPGEIGNN()
	{
		instance.EDGDFPPKGDL = null;
		LucenNPC.GGFJGHHHEJC.animationBase.SetBool("Grab", EGFGNGJGBOP: true);
		yield return CommonReferences.wait04;
		instance.DCLMLLDGBJL();
		yield return CommonReferences.wait4;
		EDGDFPPKGDL = LucenNPC.GGFJGHHHEJC;
		MDFALJKHKED = "Attack/MainEvent 6";
		if (instance.isActor)
		{
			LucenNPC.GGFJGHHHEJC.StartConversation(1, "Attack/MainEvent 6");
		}
		else
		{
			yield return LucenNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private IEnumerator DODHGCLIIBG()
	{
		instance.EDGDFPPKGDL = null;
		MaiNPC.GGFJGHHHEJC.dialogueActor.actor = "Mai ";
		MaiNPC.GGFJGHHHEJC.animationBase.SetBool("Shield", EGFGNGJGBOP: false);
		instance.shield.DisableShield();
		if (Object.op_Implicit((Object)(object)ADJFFGPKJHH))
		{
			ADJFFGPKJHH.FadeOut(0.3f, false);
		}
		yield return CommonReferences.wait05;
		MaiNPC.GGFJGHHHEJC.StartAlphaAvatarEyes(0.5f, FLDIKKNAKPM: false);
		MaiNPC.GGFJGHHHEJC.StartIntensityAvatarLight(0.5f, FLDIKKNAKPM: false);
		MaiNPC.GGFJGHHHEJC.animationBase.SetBool("Avatar", EGFGNGJGBOP: true);
		((Component)MaiNPC.GGFJGHHHEJC.avatarLight).gameObject.SetActive(true);
		HNCPLAPNGLA = MultiAudioManager.FadeInAudioObject(maiAvatarMode, ((Component)MaiNPC.GGFJGHHHEJC).transform, 0.5f);
		yield return CommonReferences.wait2;
		yield return OnlineManager.WaitForAllPlayers();
		MaiNPC.GGFJGHHHEJC.inSpecialEvent = true;
		MaiNPC.GGFJGHHHEJC.blockActionBar = true;
		EDGDFPPKGDL = MaiNPC.GGFJGHHHEJC;
		MDFALJKHKED = "Attack/MainEvent 7";
		if (instance.isActor)
		{
			MaiNPC.GGFJGHHHEJC.StartConversation(1, "Attack/MainEvent 7");
		}
		else
		{
			yield return MaiNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
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
		case LOGEKNJJJOB.MoveLucen:
			MoveLucen();
			break;
		case LOGEKNJJJOB.GrabScene:
			GrabScene();
			break;
		case LOGEKNJJJOB.Throw:
			ThrowEvent();
			break;
		case LOGEKNJJJOB.Laugh:
			LaughEvent();
			break;
		case LOGEKNJJJOB.Shield:
			ShieldEvent();
			break;
		case LOGEKNJJJOB.MaiPower:
			MaiPowerEvent();
			break;
		case LOGEKNJJJOB.LucenPower:
			LucenPowerEvent();
			break;
		case LOGEKNJJJOB.EndPower:
			EndPowerEvent();
			break;
		case LOGEKNJJJOB.LucenLeft:
			LucenLeft();
			break;
		case LOGEKNJJJOB.MoveCameraAndBathhousePeople:
			MoveCameraAndBathhousePeople();
			break;
		case LOGEKNJJJOB.RescueKyroh:
			RescueKyroh();
			break;
		}
	}

	private IEnumerator LHMDJAADHMH()
	{
		return new DHJHABGGDHN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator OBOHDPCDLMK()
	{
		instance.EDGDFPPKGDL = null;
		LucenNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePositions[3].position), Direction.Down, KEEGDBAAEOG: true);
		PsaiCore.Instance.HoldCurrentIntensity(hold: false);
		PsaiCore.Instance.AddToCurrentIntensity(0.2f);
		PsaiCore.Instance.HoldCurrentIntensity(hold: true);
		yield return CommonReferences.wait4;
		ZuzzuNPC.GGFJGHHHEJC.inSpecialEvent = true;
		ZuzzuNPC.GGFJGHHHEJC.blockActionBar = true;
		EDGDFPPKGDL = ZuzzuNPC.GGFJGHHHEJC;
		MDFALJKHKED = "Attack/MainEvent 10";
		if (instance.isActor)
		{
			ZuzzuNPC.GGFJGHHHEJC.StartConversation(1, "Attack/MainEvent 10");
		}
		else
		{
			yield return ZuzzuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private IEnumerator DOKOLLCNIIM(int JIIGOACEIKL)
	{
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(GEHNCBAJNKP));
		yield return CommonReferences.wait1_5;
		EDGDFPPKGDL = MaiNPC.GGFJGHHHEJC;
		MDFALJKHKED = "Attack/MainEvent 12";
		if (instance.isActor)
		{
			MaiNPC.GGFJGHHHEJC.StartConversation(1, "Attack/MainEvent 12");
		}
		else
		{
			yield return MaiNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private void KMNEIBLKCCD()
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		LucenNPC.POAGAIBEFBF().animationBase.CGEADHOLHCH(" seconds.", EGFGNGJGBOP: true);
		KyrohNPC.AGGAGCBAGLL().animationBase.SetBool("RPC Receive Talents From Other ", EGFGNGJGBOP: true, HALNIEBONKH: true);
		KyrohNPC.JLNBMNKJCHE().animationBase.SetBool("Items/item_name_1069", EGFGNGJGBOP: false, HALNIEBONKH: true);
		splash.transform.position = ((Component)KyrohNPC.GGFJGHHHEJC).transform.position;
		splash.SetActive(false);
		DIFKLOCALFE = ((Component)KyrohNPC.KFGKCKCDMLG()).transform.position;
		NPCDEKGDFMK = initialSpeed;
		moviendo = false;
	}

	public void OGPHNBHDBFF()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.BPIKKEPGKLO());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
	}

	private IEnumerator CACLKMADBFH()
	{
		instance.EDGDFPPKGDL = null;
		yield return CommonReferences.wait05;
		LucenNPC.GGFJGHHHEJC.darkAuraEnd.SetActive(true);
		LucenNPC.GGFJGHHHEJC.StartIntensityDarkAuraLight(0.4f, FLDIKKNAKPM: true);
		yield return CommonReferences.wait03;
		LucenNPC.GGFJGHHHEJC.darkAura.SetActive(false);
		LucenNPC.GGFJGHHHEJC.animationBase.SetBool("DarkStance", EGFGNGJGBOP: false);
		if (Object.op_Implicit((Object)(object)OJJIHCEMMAD))
		{
			OJJIHCEMMAD.FadeOut(0.3f, false);
		}
		yield return CommonReferences.wait2;
		MaiNPC.GGFJGHHHEJC.StartAlphaAvatarEyes(0.4f, FLDIKKNAKPM: true);
		MaiNPC.GGFJGHHHEJC.StartIntensityAvatarLight(0.4f, FLDIKKNAKPM: true);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetBool("Avatar", EGFGNGJGBOP: false);
		HNCPLAPNGLA.FadeOut(0.3f, false);
		yield return CommonReferences.wait1;
		EDGDFPPKGDL = LucenNPC.GGFJGHHHEJC;
		MDFALJKHKED = "Attack/MainEvent 9";
		if (instance.isActor)
		{
			LucenNPC.GGFJGHHHEJC.StartConversation(1, "Attack/MainEvent 9");
		}
		else
		{
			yield return LucenNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private void LBHNPIJKMBH()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		CNFAPDNPILF = dowmMovementInitPoint.position;
		AGJAMKMHFLL = dowmMovementEndPoint.position;
		EMLOCMPLFLK = 0f;
		dowmMovement = true;
		MultiAudioManager.PlayAudioObject(rejectDrag, ((Component)LucenNPC.GGFJGHHHEJC).transform);
		LucenNPC.GGFJGHHHEJC.animationBase.SetBool("Grab", EGFGNGJGBOP: false);
		LucenNPC.GGFJGHHHEJC.animationBase.SetBool("Reject", EGFGNGJGBOP: true);
		LucenNPC.GGFJGHHHEJC.dustDown.SetActive(true);
	}

	private IEnumerator FBHPEHLEDKE()
	{
		instance.EDGDFPPKGDL = null;
		LucenNPC.GGFJGHHHEJC.animationBase.SetBool("DarkStance", EGFGNGJGBOP: true);
		LucenNPC.GGFJGHHHEJC.StartIntensityDarkAuraLight(1f, FLDIKKNAKPM: false);
		OJJIHCEMMAD = MultiAudioManager.FadeInAudioObject(darkEnergy, ((Component)LucenNPC.GGFJGHHHEJC).transform, 0.5f);
		yield return CommonReferences.wait03;
		LucenNPC.GGFJGHHHEJC.darkAura.SetActive(true);
		((Component)LucenNPC.GGFJGHHHEJC.darkAuraLight).gameObject.SetActive(true);
		yield return CommonReferences.wait2;
		EDGDFPPKGDL = MaiNPC.GGFJGHHHEJC;
		MDFALJKHKED = "Attack/MainEvent 8";
		if (instance.isActor)
		{
			MaiNPC.GGFJGHHHEJC.StartConversation(1, "Attack/MainEvent 8");
		}
		else
		{
			yield return MaiNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private IEnumerator HHDCGKGFIAA()
	{
		while (isActive)
		{
			yield return null;
			GNOPBLECFML();
			ELBCLMDGLBO();
			HorizontalMovementUpdate();
			KALGHMOIDLP();
			LOFGHDGCBJA();
		}
		CEACJENCFNF = null;
	}

	private void EIDFODEPLBP()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		KDPILMCIHIP = ((Component)initialPositions[0]).transform.position;
		BLPLEPCFJJL = endPointGrab.position;
		OEEDGJHBDFL = 0f;
		movingGrab = true;
		MJJJEPMFAKD = MultiAudioManager.FadeInAudioObject(darkGrabLoop, ((Component)LucenNPC.GGFJGHHHEJC).transform, 0.5f);
	}

	private IEnumerator BJEEBDAGBIB()
	{
		instance.EDGDFPPKGDL = null;
		MaiNPC.GGFJGHHHEJC.dialogueActor.actor = "Mai ";
		MaiNPC.GGFJGHHHEJC.animationBase.SetBool("Shield", EGFGNGJGBOP: false);
		instance.shield.DisableShield();
		if (Object.op_Implicit((Object)(object)ADJFFGPKJHH))
		{
			ADJFFGPKJHH.FadeOut(0.3f, false);
		}
		yield return CommonReferences.wait05;
		MaiNPC.GGFJGHHHEJC.StartAlphaAvatarEyes(0.5f, FLDIKKNAKPM: false);
		MaiNPC.GGFJGHHHEJC.StartIntensityAvatarLight(0.5f, FLDIKKNAKPM: false);
		MaiNPC.GGFJGHHHEJC.animationBase.SetBool("Avatar", EGFGNGJGBOP: true);
		((Component)MaiNPC.GGFJGHHHEJC.avatarLight).gameObject.SetActive(true);
		HNCPLAPNGLA = MultiAudioManager.FadeInAudioObject(maiAvatarMode, ((Component)MaiNPC.GGFJGHHHEJC).transform, 0.5f);
		yield return CommonReferences.wait2;
		yield return OnlineManager.WaitForAllPlayers();
		MaiNPC.GGFJGHHHEJC.inSpecialEvent = true;
		MaiNPC.GGFJGHHHEJC.blockActionBar = true;
		EDGDFPPKGDL = MaiNPC.GGFJGHHHEJC;
		MDFALJKHKED = "Attack/MainEvent 7";
		if (instance.isActor)
		{
			MaiNPC.GGFJGHHHEJC.StartConversation(1, "Attack/MainEvent 7");
		}
		else
		{
			yield return MaiNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private IEnumerator FFFDDCEOKAD()
	{
		return new BOHGAAIOMGK(1)
		{
			_003C_003E4__this = this
		};
	}

	public void NLBCAGCMOCI()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		breakLamp = false;
		BJOMEOAILKI = 1233f;
		lanzando = true;
		Vector2 val = Vector2.op_Implicit(destino.position - ((Component)KyrohNPC.OAPOJCODNCO()).transform.position);
		float num = val.x / duracion;
		float num2 = (val.y - 1927f * gravedad * duracion * duracion) / duracion;
		OMBHJEPKGAL = new Vector2(num, num2);
		MJJJEPMFAKD.FadeOut(1625f, true);
		MJJJEPMFAKD = null;
		MultiAudioManager.PlayAudioObject(darkGrabThrow, ((Component)LucenNPC.BNBMNOMFFBE()).transform);
	}

	public void GrabScene()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.NFGLCCMNKHJ());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 1);
		}
	}

	public void Throw()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		breakLamp = false;
		BJOMEOAILKI = 0f;
		lanzando = true;
		Vector2 val = Vector2.op_Implicit(destino.position - ((Component)KyrohNPC.GGFJGHHHEJC).transform.position);
		float num = val.x / duracion;
		float num2 = (val.y - 0.5f * gravedad * duracion * duracion) / duracion;
		OMBHJEPKGAL = new Vector2(num, num2);
		MJJJEPMFAKD.FadeOut(0.1f, false);
		MJJJEPMFAKD = null;
		MultiAudioManager.PlayAudioObject(darkGrabThrow, ((Component)LucenNPC.GGFJGHHHEJC).transform);
	}

	private IEnumerator BPIKKEPGKLO()
	{
		instance.EDGDFPPKGDL = null;
		LucenNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePositions[1].position), Direction.Up);
		yield return CommonReferences.wait1;
		LucenNPC.GGFJGHHHEJC.inSpecialEvent = true;
		LucenNPC.GGFJGHHHEJC.blockActionBar = true;
		EDGDFPPKGDL = LucenNPC.GGFJGHHHEJC;
		MDFALJKHKED = "Attack/MainEvent 2";
		if (instance.isActor)
		{
			LucenNPC.GGFJGHHHEJC.StartConversation(1, "Attack/MainEvent 2");
		}
		else
		{
			yield return LucenNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private IEnumerator HBGOJJADDPH()
	{
		instance.EDGDFPPKGDL = null;
		LucenNPC.GGFJGHHHEJC.animationBase.SetBool("DarkStance", EGFGNGJGBOP: true);
		LucenNPC.GGFJGHHHEJC.StartIntensityDarkAuraLight(1f, FLDIKKNAKPM: false);
		OJJIHCEMMAD = MultiAudioManager.FadeInAudioObject(darkEnergy, ((Component)LucenNPC.GGFJGHHHEJC).transform, 0.5f);
		yield return CommonReferences.wait03;
		LucenNPC.GGFJGHHHEJC.darkAura.SetActive(true);
		((Component)LucenNPC.GGFJGHHHEJC.darkAuraLight).gameObject.SetActive(true);
		yield return CommonReferences.wait2;
		EDGDFPPKGDL = MaiNPC.GGFJGHHHEJC;
		MDFALJKHKED = "Attack/MainEvent 8";
		if (instance.isActor)
		{
			MaiNPC.GGFJGHHHEJC.StartConversation(1, "Attack/MainEvent 8");
		}
		else
		{
			yield return MaiNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	public void LaughEvent()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.HBEBKKIGGIM());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 3);
		}
	}

	private IEnumerator HBEBKKIGGIM()
	{
		instance.EDGDFPPKGDL = null;
		LucenNPC.GGFJGHHHEJC.animationBase.SetBool("Laugh", EGFGNGJGBOP: true);
		MultiAudioManager.PlayAudioObject(lucenLaugh, ((Component)LucenNPC.GGFJGHHHEJC).transform);
		yield return CommonReferences.wait2_5;
		LucenNPC.GGFJGHHHEJC.animationBase.SetBool("Laugh", EGFGNGJGBOP: false);
		EDGDFPPKGDL = LucenNPC.GGFJGHHHEJC;
		MDFALJKHKED = "Attack/MainEvent 5";
		if (instance.isActor)
		{
			LucenNPC.GGFJGHHHEJC.StartConversation(1, "Attack/MainEvent 5");
		}
		else
		{
			yield return LucenNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private IEnumerator OJHKJIDBMFL()
	{
		LucenNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePositions[2].position), Direction.Up);
		yield return CommonReferences.wait1;
		LucenNPC.GGFJGHHHEJC.animationBase.SetTrigger("Hair");
		yield return CommonReferences.wait05;
		EDGDFPPKGDL = LucenNPC.GGFJGHHHEJC;
		MDFALJKHKED = "Attack/MainEvent 4";
		if (instance.isActor)
		{
			LucenNPC.GGFJGHHHEJC.StartConversation(1, "Attack/MainEvent 4");
		}
		else
		{
			yield return LucenNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private IEnumerator ODAHFGDKLCI()
	{
		instance.EDGDFPPKGDL = null;
		LucenNPC.GGFJGHHHEJC.animationBase.SetBool("Throw", EGFGNGJGBOP: true);
		KyrohNPC.GGFJGHHHEJC.animationBase.SetBool("LucenThrow", EGFGNGJGBOP: true);
		LucenNPC.GGFJGHHHEJC.animationBase.SetBool("Force", EGFGNGJGBOP: false);
		KyrohNPC.GGFJGHHHEJC.animationBase.SetBool("LucenGrab", EGFGNGJGBOP: false);
		instance.Throw();
		yield return CommonReferences.wait2;
		yield return OnlineManager.WaitForAllPlayers();
		yield return OJHKJIDBMFL();
	}

	private IEnumerator LGLEGEPOHHM()
	{
		while (isActive)
		{
			yield return null;
			GNOPBLECFML();
			ELBCLMDGLBO();
			HorizontalMovementUpdate();
			KALGHMOIDLP();
			LOFGHDGCBJA();
		}
		CEACJENCFNF = null;
	}

	private IEnumerator NIGFODLLNID()
	{
		return new IDEDMEPHNPB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator IPMLCJOJFJD()
	{
		instance.EDGDFPPKGDL = null;
		LucenNPC.GGFJGHHHEJC.animationBase.SetBool("DarkStance", EGFGNGJGBOP: true);
		LucenNPC.GGFJGHHHEJC.StartIntensityDarkAuraLight(1f, FLDIKKNAKPM: false);
		OJJIHCEMMAD = MultiAudioManager.FadeInAudioObject(darkEnergy, ((Component)LucenNPC.GGFJGHHHEJC).transform, 0.5f);
		yield return CommonReferences.wait03;
		LucenNPC.GGFJGHHHEJC.darkAura.SetActive(true);
		((Component)LucenNPC.GGFJGHHHEJC.darkAuraLight).gameObject.SetActive(true);
		yield return CommonReferences.wait2;
		EDGDFPPKGDL = MaiNPC.GGFJGHHHEJC;
		MDFALJKHKED = "Attack/MainEvent 8";
		if (instance.isActor)
		{
			MaiNPC.GGFJGHHHEJC.StartConversation(1, "Attack/MainEvent 8");
		}
		else
		{
			yield return MaiNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private IEnumerator JOKOFNNBJGN()
	{
		instance.EDGDFPPKGDL = null;
		KentaNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePositions[8].position));
		yield return CommonReferences.wait02;
		RinNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePositions[9].position));
		yield return CommonReferences.wait3;
		FadeCamera.GetPlayer(1).FadeOut(0.4f);
		FadeCamera.GetPlayer(1).JDKHJJIOLOE += HHGEKEKHDNK;
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeOut(0.4f);
		}
	}

	public void JIHMGOAGKNH()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.LALDLHPGADM());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, -38);
		}
	}

	public void ThrowEvent()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.ODAHFGDKLCI());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 2);
		}
	}

	public void MoveCameraAndBathhousePeople()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.LALDLHPGADM());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 9);
		}
	}

	private void BGPGIOMKKAO()
	{
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
		if (EventsManager.IsDone(EventsManager.EventType.Attack))
		{
			nightStartLamp.NightEnd();
			stoneLamp.SetTrigger("Break");
			SetSleepEvent();
		}
	}

	private void CCMNMFIELED()
	{
		GameActionBarUI.NIDHCIHFOHB(0).CloseUI();
		if (GameManager.LocalCoop())
		{
			GameActionBarUI.PPDMGBACONH(1).CloseUI();
		}
		TavernManagerUI.ShowClock(MDIKPGGBNLI: true);
		MissionsManager.PKPKGMACKLP();
	}

	private void ADFMHFLPNOF()
	{
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(ADFMHFLPNOF));
		if (EventsManager.OOCOFHECMDA((EventsManager.EventType)86))
		{
			nightStartLamp.DCFCKCOOOAF();
			stoneLamp.SetTrigger("{0}x{1}");
			CHDMKOJGEFD();
		}
	}

	private IEnumerator PDBMBFDDBHO()
	{
		return new FNFNCINMEAD(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LJABJLDHLCB()
	{
		instance.EDGDFPPKGDL = null;
		PsaiCore.Instance.HoldCurrentIntensity(hold: false);
		PsaiCore.Instance.StopMusic(immediately: false);
		MusicController.instance.TriggerCurrentBasicMood(CommonReferences.wait20, Location.Bathhouse);
		yield return CommonReferences.wait1;
		KyrohNPC.GGFJGHHHEJC.inSpecialEvent = false;
		KyrohNPC.GGFJGHHHEJC.blockActionBar = false;
		LucenNPC.GGFJGHHHEJC.inSpecialEvent = false;
		LucenNPC.GGFJGHHHEJC.blockActionBar = false;
		MaiNPC.GGFJGHHHEJC.inSpecialEvent = false;
		MaiNPC.GGFJGHHHEJC.blockActionBar = false;
		ZuzzuNPC.GGFJGHHHEJC.inSpecialEvent = false;
		ZuzzuNPC.GGFJGHHHEJC.blockActionBar = false;
		MaiNPC.GGFJGHHHEJC.animationBase.SetTrigger("HumanDisappear");
		DialogueLua.SetVariable("MainProgress", (object)21);
		if (!Utils.NGLLIJPOBEC(Location.Bathhouse))
		{
			yield return CommonReferences.wait1;
			DialogueCameraTarget.GetPlayer(1).TransportCameraToPosition(Vector2.op_Implicit(((Component)CameraTarget.GetPlayer(1)).transform.position));
		}
		DialogueCameraTarget.GetPlayer(1).ReturnControlToCameraTarget();
		if (GameManager.LocalCoop())
		{
			LocalCooperativeManager.RestoreCameraInLocalCoop();
		}
		yield return CommonReferences.wait3;
		yield return OnlineManager.WaitForAllPlayers();
		GameActionBarUI.Get(1).OpenUI();
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		MaiNPC.GGFJGHHHEJC.dialogueActor.actor = "Mai";
		MaiNPC.GGFJGHHHEJC.ResetMai();
		PBMJLFIJNAF();
		WorldTime.JJICPIINBEH = false;
		if (CEACJENCFNF != null)
		{
			((MonoBehaviour)this).StopCoroutine(CEACJENCFNF);
			CEACJENCFNF = null;
		}
		OnlineManager.ResetPlayersPreparedToContinue();
		while (Utils.NGLLIJPOBEC(Location.Bathhouse))
		{
			yield return null;
		}
		if (OnlineManager.MasterOrOffline())
		{
			((Behaviour)ZuzzuNPC.GGFJGHHHEJC.routine).enabled = true;
			ZuzzuNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
		}
		instance.npcsExterior.SetActive(true);
		SetSleepEvent();
		Puente_EAEvent.instance.ActivateEvent();
	}

	public void LucenPowerEvent()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.HBGOJJADDPH());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 6);
		}
	}

	public override GameEvent GetInstance()
	{
		return instance;
	}

	private void PJIPKAGPHCD()
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		if (movement)
		{
			JHJOJONNDCD += Time.deltaTime;
			DCGBADKLANM = Mathf.Clamp01(JHJOJONNDCD / duration);
			if (OnlineManager.PGAGDFAEEFB())
			{
				EGGCGDGADKP = Mathf.Pow(DCGBADKLANM, acceleration);
				((Component)LucenNPC.LPFNKEOJJKE()).transform.position = Vector3.Lerp(KPKFJGNEAEB, DBACIMHFEKD, EGGCGDGADKP);
			}
			if (DCGBADKLANM >= 1607f)
			{
				((Component)LucenNPC.BNBMNOMFFBE()).transform.position = DBACIMHFEKD;
				movement = false;
				((MonoBehaviour)instance).StartCoroutine(IFIOMJAMFFG());
			}
		}
	}

	private IEnumerator GCCEMJEJLLM()
	{
		instance.EDGDFPPKGDL = null;
		PsaiCore.Instance.HoldCurrentIntensity(hold: false);
		PsaiCore.Instance.StopMusic(immediately: false);
		MusicController.instance.TriggerCurrentBasicMood(CommonReferences.wait20, Location.Bathhouse);
		yield return CommonReferences.wait1;
		KyrohNPC.GGFJGHHHEJC.inSpecialEvent = false;
		KyrohNPC.GGFJGHHHEJC.blockActionBar = false;
		LucenNPC.GGFJGHHHEJC.inSpecialEvent = false;
		LucenNPC.GGFJGHHHEJC.blockActionBar = false;
		MaiNPC.GGFJGHHHEJC.inSpecialEvent = false;
		MaiNPC.GGFJGHHHEJC.blockActionBar = false;
		ZuzzuNPC.GGFJGHHHEJC.inSpecialEvent = false;
		ZuzzuNPC.GGFJGHHHEJC.blockActionBar = false;
		MaiNPC.GGFJGHHHEJC.animationBase.SetTrigger("HumanDisappear");
		DialogueLua.SetVariable("MainProgress", (object)21);
		if (!Utils.NGLLIJPOBEC(Location.Bathhouse))
		{
			yield return CommonReferences.wait1;
			DialogueCameraTarget.GetPlayer(1).TransportCameraToPosition(Vector2.op_Implicit(((Component)CameraTarget.GetPlayer(1)).transform.position));
		}
		DialogueCameraTarget.GetPlayer(1).ReturnControlToCameraTarget();
		if (GameManager.LocalCoop())
		{
			LocalCooperativeManager.RestoreCameraInLocalCoop();
		}
		yield return CommonReferences.wait3;
		yield return OnlineManager.WaitForAllPlayers();
		GameActionBarUI.Get(1).OpenUI();
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		MaiNPC.GGFJGHHHEJC.dialogueActor.actor = "Mai";
		MaiNPC.GGFJGHHHEJC.ResetMai();
		PBMJLFIJNAF();
		WorldTime.JJICPIINBEH = false;
		if (CEACJENCFNF != null)
		{
			((MonoBehaviour)this).StopCoroutine(CEACJENCFNF);
			CEACJENCFNF = null;
		}
		OnlineManager.ResetPlayersPreparedToContinue();
		while (Utils.NGLLIJPOBEC(Location.Bathhouse))
		{
			yield return null;
		}
		if (OnlineManager.MasterOrOffline())
		{
			((Behaviour)ZuzzuNPC.GGFJGHHHEJC.routine).enabled = true;
			ZuzzuNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
		}
		instance.npcsExterior.SetActive(true);
		SetSleepEvent();
		Puente_EAEvent.instance.ActivateEvent();
	}

	public void BFBFMFLIPAF()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable(" ");
		if (((Result)(ref variable)).asInt == 95)
		{
			RinNPC.EBAIHKJHCCA().routine.noDisableOnReset = true;
			KentaNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
			((Behaviour)RinNPC.BNBMNOMFFBE().routine).enabled = false;
			((Behaviour)KentaNPC.GGFJGHHHEJC.routine).enabled = true;
			KyrohNPC.KADHMEPDIKM().playerCanInteract = false;
			KyrohNPC.KFGKCKCDMLG().content.SetActive(false);
			((Component)KyrohNPC.AGGAGCBAGLL()).transform.position = initialPositions[4].position;
			KyrohNPC.OAPOJCODNCO().animationBase.CGEADHOLHCH("[Grey", EGFGNGJGBOP: false, HALNIEBONKH: true);
			RinNPC.POAGAIBEFBF().content.SetActive(true);
			((Component)RinNPC.BNBMNOMFFBE()).transform.position = initialPositions[2].position;
			RinNPC.AFFGPMFKEFH().animationBase.SetDirection(Direction.Diagonal);
			RinNPC.OPILDPFDFKJ().animationBase.CGEADHOLHCH("Player/Bark/Error/NotAllPlayersHere", EGFGNGJGBOP: true, HALNIEBONKH: true);
			KentaNPC.GGFJGHHHEJC.content.SetActive(false);
			((Component)KentaNPC.GGFJGHHHEJC).transform.position = initialPositions[5].position;
			KentaNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
			KentaNPC.GGFJGHHHEJC.animationBase.SetBool("tutorialPopUp28", EGFGNGJGBOP: false);
		}
	}

	private void PBMJLFIJNAF()
	{
		GameActionBarUI.Get(1).OpenUI();
		if (GameManager.LocalCoop())
		{
			GameActionBarUI.Get(2).OpenUI();
		}
		TavernManagerUI.ShowPermanentTavernInfo((MonoBehaviour)(object)NinjaChallenge.instance);
		TavernManagerUI.ShowClockAndTavernInfo();
		MissionsManager.ShowObjectivesPanel();
	}

	public static void TeleportToBathhouse()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.PIMADJBGICP());
	}

	private void LPGMCKPIBMA()
	{
		GameActionBarUI.DIMABMEHNNI(1).CloseUI();
		if (GameManager.LocalCoop())
		{
			GameActionBarUI.MENNLOGFNOK(4).CloseUI();
		}
		TavernManagerUI.ShowClock(MDIKPGGBNLI: true);
		MissionsManager.HideObjectivesPanel();
	}

	private IEnumerator EHOPLJGOIBJ()
	{
		LucenNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePositions[2].position), Direction.Up);
		yield return CommonReferences.wait1;
		LucenNPC.GGFJGHHHEJC.animationBase.SetTrigger("Hair");
		yield return CommonReferences.wait05;
		EDGDFPPKGDL = LucenNPC.GGFJGHHHEJC;
		MDFALJKHKED = "Attack/MainEvent 4";
		if (instance.isActor)
		{
			LucenNPC.GGFJGHHHEJC.StartConversation(1, "Attack/MainEvent 4");
		}
		else
		{
			yield return LucenNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	public void NOCKEOPDAHM()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.OBOHDPCDLMK());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 6);
		}
	}

	private void ELBCLMDGLBO()
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		if (lanzando)
		{
			Debug.Log((object)"Throw Update");
			BJOMEOAILKI += Time.deltaTime;
			if (OnlineManager.MasterOrOffline())
			{
				DCGBADKLANM = Mathf.Clamp(BJOMEOAILKI, 0f, duracion);
				float num = inicio.position.x + OMBHJEPKGAL.x * DCGBADKLANM;
				float num2 = inicio.position.y + OMBHJEPKGAL.y * DCGBADKLANM + 0.5f * gravedad * DCGBADKLANM * DCGBADKLANM;
				((Component)KyrohNPC.GGFJGHHHEJC).transform.position = Vector2.op_Implicit(new Vector2(num, num2));
				KyrohNPC.GGFJGHHHEJC.shadow.transform.position = Vector2.op_Implicit(new Vector2(num, KyrohNPC.GGFJGHHHEJC.shadow.transform.position.y));
			}
			if (!breakLamp && ((Component)KyrohNPC.GGFJGHHHEJC).transform.position.x >= breakLampPoint.position.x)
			{
				nightStartLamp.NightEnd();
				stoneLamp.SetTrigger("Break");
				breakLamp = true;
			}
			if (BJOMEOAILKI >= duracion)
			{
				KyrohNPC.GGFJGHHHEJC.shadow.transform.parent = KyrohNPC.GGFJGHHHEJC.visual.transform.parent;
				((Component)KyrohNPC.GGFJGHHHEJC).transform.position = destino.position;
				lanzando = false;
				NJEJKIFMINF();
			}
		}
	}

	private void HPCOIICLFBD()
	{
		GameActionBarUI.Get(1).CloseUI();
		if (GameManager.LocalCoop())
		{
			GameActionBarUI.Get(2).CloseUI();
		}
		TavernManagerUI.ShowClock(MDIKPGGBNLI: false);
		MissionsManager.HideObjectivesPanel();
	}

	public void StartEvent(int AAAIOBLCOFO)
	{
		StartEvent(OnlineManager.MasterOrOffline(), CDPAMNIPPEC: false);
	}

	private void HFKLNGJJBKP()
	{
		GameActionBarUI.NDPAJCGHGOB(1).OpenUI();
		if (GameManager.LocalCoop())
		{
			GameActionBarUI.GDFNPHJJCPP(4).IDLAGJNLPJL();
		}
		TavernManagerUI.ShowPermanentTavernInfo((MonoBehaviour)(object)NinjaChallenge.instance);
		TavernManagerUI.ShowClockAndTavernInfo();
		MissionsManager.GCNOIADEBAP();
	}

	protected override void Awake()
	{
		base.Awake();
		instance = this;
	}

	private void LOFGHDGCBJA()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		if (dowmMovement && !OnlineManager.ClientOnline())
		{
			EMLOCMPLFLK += Time.deltaTime;
			float num = Mathf.Clamp01(EMLOCMPLFLK / dowmMovementDuration);
			float num2 = 1f - Mathf.Pow(1f - num, dowmMovementDesaceleration);
			((Component)LucenNPC.GGFJGHHHEJC).transform.position = Vector3.Lerp(CNFAPDNPILF, AGJAMKMHFLL, num2);
			if (num >= 1f)
			{
				((Component)LucenNPC.GGFJGHHHEJC).transform.position = AGJAMKMHFLL;
				dowmMovement = false;
				LucenNPC.GGFJGHHHEJC.animationBase.SetBool("Reject", EGFGNGJGBOP: false);
			}
		}
	}

	public void EndPowerEvent()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.MHKPOGEOBOO());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 7);
		}
	}

	private void Start()
	{
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
	}

	private void KAOKPKDLHGH()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		if (dowmMovement && !OnlineManager.ClientOnline())
		{
			EMLOCMPLFLK += Time.deltaTime;
			float num = Mathf.Clamp01(EMLOCMPLFLK / dowmMovementDuration);
			float num2 = 181f - Mathf.Pow(1084f - num, dowmMovementDesaceleration);
			((Component)LucenNPC.MOAKANGAMBA()).transform.position = Vector3.Lerp(CNFAPDNPILF, AGJAMKMHFLL, num2);
			if (num >= 598f)
			{
				((Component)LucenNPC.LPFNKEOJJKE()).transform.position = AGJAMKMHFLL;
				dowmMovement = true;
				LucenNPC.LPFNKEOJJKE().animationBase.CGEADHOLHCH("MoveDirection", EGFGNGJGBOP: false);
			}
		}
	}

	public void RescueKyroh()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.JOKOFNNBJGN());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 10);
		}
	}

	private void GEHNCBAJNKP(int JIIGOACEIKL)
	{
		((MonoBehaviour)instance).StartCoroutine(instance.DOKOLLCNIIM(JIIGOACEIKL));
	}

	private IEnumerator LHOPIAJBIFH()
	{
		while (isActive)
		{
			yield return null;
			GNOPBLECFML();
			ELBCLMDGLBO();
			HorizontalMovementUpdate();
			KALGHMOIDLP();
			LOFGHDGCBJA();
		}
		CEACJENCFNF = null;
	}

	public void LucenLeft()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.OBOHDPCDLMK());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 8);
		}
	}

	private void OIAHJHNPPCO()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(ADFMHFLPNOF));
	}

	private void PLNAAGMCKBH()
	{
		GameActionBarUI.PPJMPMKLCME(0).IDLAGJNLPJL();
		if (GameManager.LocalCoop())
		{
			GameActionBarUI.PHDBJGOEKHB(7).IDLAGJNLPJL();
		}
		TavernManagerUI.ShowPermanentTavernInfo((MonoBehaviour)(object)NinjaChallenge.instance);
		TavernManagerUI.ShowClockAndTavernInfo();
		MissionsManager.ShowObjectivesPanel();
	}

	private void PECDMCAKCJJ()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		KPKFJGNEAEB = movePositions[1].position;
		DBACIMHFEKD = endPoint.position;
		JHJOJONNDCD = 1557f;
		movement = false;
		LucenNPC.NHKAFANMEJC().dustUp.SetActive(false);
		MultiAudioManager.PlayAudioObject(darkLaunch, ((Component)LucenNPC.MOAKANGAMBA()).transform);
	}

	private IEnumerator LALDLHPGADM()
	{
		instance.EDGDFPPKGDL = null;
		ZuzzuNPC.GGFJGHHHEJC.content.SetActive(true);
		((Component)ZuzzuNPC.GGFJGHHHEJC).transform.position = initialPositions[3].position;
		ZuzzuNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		KentaNPC.GGFJGHHHEJC.content.SetActive(true);
		((Component)KentaNPC.GGFJGHHHEJC).transform.position = initialPositions[4].position;
		KentaNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		RinNPC.GGFJGHHHEJC.content.SetActive(true);
		((Component)RinNPC.GGFJGHHHEJC).transform.position = initialPositions[5].position;
		RinNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		ZuzzuNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePositions[4].position));
		yield return CommonReferences.wait05;
		KentaNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePositions[5].position));
		yield return CommonReferences.wait02;
		RinNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePositions[6].position));
		DialogueCameraTarget.GetPlayer(1).cameraInEvent = true;
		DialogueCameraTarget.GetPlayer(1).MoveCameraToPosition(Vector2.op_Implicit(cameraPositions[0].position), Vector2.op_Implicit(cameraPositions[1].position));
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
		if (isActor)
		{
			PlayerController.GetPlayer(1).SetDirection(Direction.Up);
		}
		if (GameManager.LocalCoop())
		{
			PlayerController.GetPlayer(2).SetDirection(Direction.Up);
		}
		yield return CommonReferences.wait3;
		EDGDFPPKGDL = ZuzzuNPC.GGFJGHHHEJC;
		MDFALJKHKED = "Attack/MainEvent 11";
		if (instance.isActor)
		{
			ZuzzuNPC.GGFJGHHHEJC.StartConversation(1, "Attack/MainEvent 11");
		}
		else
		{
			yield return ZuzzuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private IEnumerator HGOPNPPFOFH()
	{
		instance.EDGDFPPKGDL = null;
		LucenNPC.GGFJGHHHEJC.animationBase.SetBool("DarkStance", EGFGNGJGBOP: true);
		LucenNPC.GGFJGHHHEJC.StartIntensityDarkAuraLight(1f, FLDIKKNAKPM: false);
		OJJIHCEMMAD = MultiAudioManager.FadeInAudioObject(darkEnergy, ((Component)LucenNPC.GGFJGHHHEJC).transform, 0.5f);
		yield return CommonReferences.wait03;
		LucenNPC.GGFJGHHHEJC.darkAura.SetActive(true);
		((Component)LucenNPC.GGFJGHHHEJC.darkAuraLight).gameObject.SetActive(true);
		yield return CommonReferences.wait2;
		EDGDFPPKGDL = MaiNPC.GGFJGHHHEJC;
		MDFALJKHKED = "Attack/MainEvent 8";
		if (instance.isActor)
		{
			MaiNPC.GGFJGHHHEJC.StartConversation(1, "Attack/MainEvent 8");
		}
		else
		{
			yield return MaiNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	public void MaiPowerEvent()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.DODHGCLIIBG());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 5);
		}
	}

	private IEnumerator HLJNLJLNGFH()
	{
		return new GFABOIMCDFE(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator EFOONHMKJEB()
	{
		EDGDFPPKGDL = null;
		if (GameManager.LocalCoop())
		{
			LocalCooperativeManager.FocusCameraToPlayerInLocalCoop(1);
		}
		Vector3 offsetPosition = new Vector3((float)(Bed.instance.numInstance - 1) * 0.4f, (float)(Bed.instance.numInstance - 1) * 0.2f);
		PlayerController.GetPlayer(1).GoToPosition(Vector2.op_Implicit(movePositions[0].position + offsetPosition), KLGOCJMGKFO: true);
		if (GameManager.LocalCoop())
		{
			PlayerController.GetPlayer(2).GoToPositionIndependentThread(Vector2.op_Implicit(movePositions[0].position + new Vector3(0.5f, 0.3f)), Direction.Down);
		}
		while (!PlayerController.GetPlayer(1).GoToPosition(Vector2.op_Implicit(movePositions[0].position + offsetPosition), KLGOCJMGKFO: false))
		{
			yield return null;
		}
		PlayerController.GetPlayer(1).characterAnimation.SetDirection(Direction.Down);
		yield return CommonReferences.wait1;
		DialogueCameraTarget.GetPlayer(1).cameraInEvent = true;
		DialogueCameraTarget.GetPlayer(1).MoveCameraToPositionFromCameraTarget(Vector2.op_Implicit(cameraPositions[0].position));
		yield return CommonReferences.wait2;
		yield return OnlineManager.WaitForAllPlayers();
		EDGDFPPKGDL = KyrohNPC.GGFJGHHHEJC;
		MDFALJKHKED = "Attack/MainEvent";
		KyrohNPC.GGFJGHHHEJC.inSpecialEvent = true;
		KyrohNPC.GGFJGHHHEJC.blockActionBar = true;
		if (instance.isActor)
		{
			KyrohNPC.GGFJGHHHEJC.StartConversation(1, "Attack/MainEvent");
		}
		else
		{
			yield return KyrohNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private void GNOPBLECFML()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		if (movingGrab && !OnlineManager.ClientOnline())
		{
			OEEDGJHBDFL += Time.deltaTime;
			float num = Mathf.Clamp01(OEEDGJHBDFL / durationGrab);
			float num2 = 1f - Mathf.Pow(1f - num, desacelerationGrab);
			((Component)KyrohNPC.GGFJGHHHEJC).transform.position = Vector3.Lerp(KDPILMCIHIP, BLPLEPCFJJL, num2);
			if (num >= 1f)
			{
				((Component)KyrohNPC.GGFJGHHHEJC).transform.position = BLPLEPCFJJL;
				movingGrab = false;
			}
		}
	}

	private void DKDECKGJLFI()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		KDPILMCIHIP = ((Component)initialPositions[1]).transform.position;
		BLPLEPCFJJL = endPointGrab.position;
		OEEDGJHBDFL = 431f;
		movingGrab = false;
		MJJJEPMFAKD = MultiAudioManager.FadeInAudioObject(darkGrabLoop, ((Component)LucenNPC.ABDJJBFNLBJ()).transform, 1442f);
	}

	public void ShieldEvent()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.OJFKPGEIGNN());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 4);
		}
	}

	private IEnumerator LJNMLKJOKDM()
	{
		return new AHADCBGNHDM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator IFIOMJAMFFG()
	{
		PsaiCore.Instance.HoldCurrentIntensity(hold: false);
		PsaiCore.Instance.AddToCurrentIntensity(0.2f);
		PsaiCore.Instance.HoldCurrentIntensity(hold: true);
		FlashEvents.instance.ActivateCanvas();
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		MaiNPC.GGFJGHHHEJC.content.SetActive(true);
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = initialPositions[2].position;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.animationBase.SetBool("Disabled", EGFGNGJGBOP: false);
		MaiNPC.GGFJGHHHEJC.animationBase.SetTrigger("ShieldTrigger");
		MaiNPC.GGFJGHHHEJC.animationBase.SetBool("Shield", EGFGNGJGBOP: true);
		((Component)shield).gameObject.SetActive(true);
		MultiAudioManager.PlayAudioObject(flash, ((Component)LucenNPC.GGFJGHHHEJC).transform.position);
		ADJFFGPKJHH = MultiAudioManager.FadeInAudioObject(magicShield, ((Component)MaiNPC.GGFJGHHHEJC).transform, flashTime);
		yield return (object)new WaitForSeconds(flashTime);
		FlashEvents.instance.FadeOut();
		LBHNPIJKMBH();
	}

	public void SetSleepEvent()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("MainProgress");
		if (((Result)(ref variable)).asInt == 21)
		{
			RinNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
			KentaNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
			((Behaviour)RinNPC.GGFJGHHHEJC.routine).enabled = false;
			((Behaviour)KentaNPC.GGFJGHHHEJC.routine).enabled = false;
			KyrohNPC.GGFJGHHHEJC.playerCanInteract = false;
			KyrohNPC.GGFJGHHHEJC.content.SetActive(true);
			((Component)KyrohNPC.GGFJGHHHEJC).transform.position = initialPositions[6].position;
			KyrohNPC.GGFJGHHHEJC.animationBase.SetBool("Sleep", EGFGNGJGBOP: true);
			RinNPC.GGFJGHHHEJC.content.SetActive(true);
			((Component)RinNPC.GGFJGHHHEJC).transform.position = initialPositions[7].position;
			RinNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Left);
			RinNPC.GGFJGHHHEJC.animationBase.SetBool("KyrohScene", EGFGNGJGBOP: true);
			KentaNPC.GGFJGHHHEJC.content.SetActive(true);
			((Component)KentaNPC.GGFJGHHHEJC).transform.position = initialPositions[8].position;
			KentaNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			KentaNPC.GGFJGHHHEJC.animationBase.SetBool("KyrohScene", EGFGNGJGBOP: true);
		}
	}

	private void NHPKDHGEIKJ()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		if (movingGrab && !OnlineManager.ClientOnline())
		{
			OEEDGJHBDFL += Time.deltaTime;
			float num = Mathf.Clamp01(OEEDGJHBDFL / durationGrab);
			float num2 = 1340f - Mathf.Pow(189f - num, desacelerationGrab);
			((Component)KyrohNPC.OAPOJCODNCO()).transform.position = Vector3.Lerp(KDPILMCIHIP, BLPLEPCFJJL, num2);
			if (num >= 1299f)
			{
				((Component)KyrohNPC.KADHMEPDIKM()).transform.position = BLPLEPCFJJL;
				movingGrab = true;
			}
		}
	}

	public void CHDMKOJGEFD()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Ratio pantalla: ");
		if (((Result)(ref variable)).asInt == 122)
		{
			RinNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
			KentaNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
			((Behaviour)RinNPC.AFFGPMFKEFH().routine).enabled = false;
			((Behaviour)KentaNPC.GGFJGHHHEJC.routine).enabled = true;
			KyrohNPC.KADHMEPDIKM().playerCanInteract = false;
			KyrohNPC.JFNOOMJMHCB().content.SetActive(false);
			((Component)KyrohNPC.KADHMEPDIKM()).transform.position = initialPositions[8].position;
			KyrohNPC.PBJDFFEFMKM().animationBase.CGEADHOLHCH("\nInternal current input text: ", EGFGNGJGBOP: true, HALNIEBONKH: true);
			RinNPC.BNBMNOMFFBE().content.SetActive(true);
			((Component)RinNPC.OPILDPFDFKJ()).transform.position = initialPositions[0].position;
			RinNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			RinNPC.OPILDPFDFKJ().animationBase.CGEADHOLHCH("NextToWall", EGFGNGJGBOP: true);
			KentaNPC.GGFJGHHHEJC.content.SetActive(false);
			((Component)KentaNPC.GGFJGHHHEJC).transform.position = initialPositions[4].position;
			KentaNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
			KentaNPC.GGFJGHHHEJC.animationBase.SetBool("ReceiveTalentsLoad", EGFGNGJGBOP: true, HALNIEBONKH: true);
		}
	}

	public void MoveLucen()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.BPIKKEPGKLO());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
	}

	private void FMNLNHHEFFM()
	{
		GameActionBarUI.JGNOJMLHPOK(0).BOBCIFEDJED();
		if (GameManager.LocalCoop())
		{
			GameActionBarUI.MENNLOGFNOK(0).BOBCIFEDJED();
		}
		TavernManagerUI.ShowClock(MDIKPGGBNLI: true);
		MissionsManager.PKPKGMACKLP();
	}

	private IEnumerator IMJDDKGAHPM()
	{
		PsaiCore.Instance.HoldCurrentIntensity(hold: false);
		PsaiCore.Instance.AddToCurrentIntensity(0.2f);
		PsaiCore.Instance.HoldCurrentIntensity(hold: true);
		FlashEvents.instance.ActivateCanvas();
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		MaiNPC.GGFJGHHHEJC.content.SetActive(true);
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = initialPositions[2].position;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.animationBase.SetBool("Disabled", EGFGNGJGBOP: false);
		MaiNPC.GGFJGHHHEJC.animationBase.SetTrigger("ShieldTrigger");
		MaiNPC.GGFJGHHHEJC.animationBase.SetBool("Shield", EGFGNGJGBOP: true);
		((Component)shield).gameObject.SetActive(true);
		MultiAudioManager.PlayAudioObject(flash, ((Component)LucenNPC.GGFJGHHHEJC).transform.position);
		ADJFFGPKJHH = MultiAudioManager.FadeInAudioObject(magicShield, ((Component)MaiNPC.GGFJGHHHEJC).transform, flashTime);
		yield return (object)new WaitForSeconds(flashTime);
		FlashEvents.instance.FadeOut();
		LBHNPIJKMBH();
	}

	private void KALGHMOIDLP()
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		if (movement)
		{
			JHJOJONNDCD += Time.deltaTime;
			DCGBADKLANM = Mathf.Clamp01(JHJOJONNDCD / duration);
			if (OnlineManager.MasterOrOffline())
			{
				EGGCGDGADKP = Mathf.Pow(DCGBADKLANM, acceleration);
				((Component)LucenNPC.GGFJGHHHEJC).transform.position = Vector3.Lerp(KPKFJGNEAEB, DBACIMHFEKD, EGGCGDGADKP);
			}
			if (DCGBADKLANM >= 1f)
			{
				((Component)LucenNPC.GGFJGHHHEJC).transform.position = DBACIMHFEKD;
				movement = false;
				((MonoBehaviour)instance).StartCoroutine(IMJDDKGAHPM());
			}
		}
	}

	private IEnumerator EANKMDIJOIN()
	{
		return new IDEDMEPHNPB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void DCLMLLDGBJL()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		KPKFJGNEAEB = movePositions[2].position;
		DBACIMHFEKD = endPoint.position;
		JHJOJONNDCD = 0f;
		movement = true;
		LucenNPC.GGFJGHHHEJC.dustUp.SetActive(true);
		MultiAudioManager.PlayAudioObject(darkLaunch, ((Component)LucenNPC.GGFJGHHHEJC).transform);
	}

	private IEnumerator OKPNIPLAADN()
	{
		return new GGCDLOGKLPC(1)
		{
			_003C_003E4__this = this
		};
	}

	public void DGDKMNMOEIP()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.HLJNLJLNGFH());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
	}

	public void HGPJPFCECMA()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.OJFKPGEIGNN());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 3);
		}
	}

	private void CKCNCPJDPLE()
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		if (movement)
		{
			JHJOJONNDCD += Time.deltaTime;
			DCGBADKLANM = Mathf.Clamp01(JHJOJONNDCD / duration);
			if (OnlineManager.PGAGDFAEEFB())
			{
				EGGCGDGADKP = Mathf.Pow(DCGBADKLANM, acceleration);
				((Component)LucenNPC.IBEGPMLJIOJ()).transform.position = Vector3.Lerp(KPKFJGNEAEB, DBACIMHFEKD, EGGCGDGADKP);
			}
			if (DCGBADKLANM >= 1283f)
			{
				((Component)LucenNPC.DFJGHOHPPEL()).transform.position = DBACIMHFEKD;
				movement = false;
				((MonoBehaviour)instance).StartCoroutine(IMJDDKGAHPM());
			}
		}
	}

	private IEnumerator MHKPOGEOBOO()
	{
		instance.EDGDFPPKGDL = null;
		yield return CommonReferences.wait05;
		LucenNPC.GGFJGHHHEJC.darkAuraEnd.SetActive(true);
		LucenNPC.GGFJGHHHEJC.StartIntensityDarkAuraLight(0.4f, FLDIKKNAKPM: true);
		yield return CommonReferences.wait03;
		LucenNPC.GGFJGHHHEJC.darkAura.SetActive(false);
		LucenNPC.GGFJGHHHEJC.animationBase.SetBool("DarkStance", EGFGNGJGBOP: false);
		if (Object.op_Implicit((Object)(object)OJJIHCEMMAD))
		{
			OJJIHCEMMAD.FadeOut(0.3f, false);
		}
		yield return CommonReferences.wait2;
		MaiNPC.GGFJGHHHEJC.StartAlphaAvatarEyes(0.4f, FLDIKKNAKPM: true);
		MaiNPC.GGFJGHHHEJC.StartIntensityAvatarLight(0.4f, FLDIKKNAKPM: true);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetBool("Avatar", EGFGNGJGBOP: false);
		HNCPLAPNGLA.FadeOut(0.3f, false);
		yield return CommonReferences.wait1;
		EDGDFPPKGDL = LucenNPC.GGFJGHHHEJC;
		MDFALJKHKED = "Attack/MainEvent 9";
		if (instance.isActor)
		{
			LucenNPC.GGFJGHHHEJC.StartConversation(1, "Attack/MainEvent 9");
		}
		else
		{
			yield return LucenNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private IEnumerator NFGLCCMNKHJ()
	{
		instance.EDGDFPPKGDL = null;
		KyrohNPC.GGFJGHHHEJC.shadow.transform.parent = null;
		LucenNPC.GGFJGHHHEJC.animationBase.SetBool("Force", EGFGNGJGBOP: true);
		KyrohNPC.GGFJGHHHEJC.animationBase.SetBool("LucenGrab", EGFGNGJGBOP: true);
		instance.EIDFODEPLBP();
		PsaiCore.Instance.HoldCurrentIntensity(hold: false);
		PsaiCore.Instance.AddToCurrentIntensity(0.3f);
		PsaiCore.Instance.HoldCurrentIntensity(hold: true);
		yield return CommonReferences.wait2;
		EDGDFPPKGDL = LucenNPC.GGFJGHHHEJC;
		MDFALJKHKED = "Attack/MainEvent 3";
		if (instance.isActor)
		{
			LucenNPC.GGFJGHHHEJC.StartConversation(1, "Attack/MainEvent 3");
		}
		else
		{
			yield return LucenNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	public override void EndEvent(bool _isActor)
	{
		base.EndEvent(_isActor);
		((MonoBehaviour)instance).StartCoroutine(LJABJLDHLCB());
	}

	public override void ActivateEvent()
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		base.ActivateEvent();
		npcsExterior.SetActive(false);
		if (CEACJENCFNF == null)
		{
			CEACJENCFNF = ((MonoBehaviour)this).StartCoroutine(HHDCGKGFIAA());
		}
		KyrohNPC.GGFJGHHHEJC.ChangeState(KyrohState.Idle);
		KyrohNPC.GGFJGHHHEJC.animationBase.animator.Rebind();
		KyrohNPC.GGFJGHHHEJC.animationBase.animator.Update(0f);
		if (OnlineManager.MasterOrOffline())
		{
			KyrohNPC.GGFJGHHHEJC.content.SetActive(false);
		}
		KyrohNPC.GGFJGHHHEJC.content.SetActive(true);
		((Component)KyrohNPC.GGFJGHHHEJC).transform.position = initialPositions[0].position;
		KyrohNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		LucenNPC.GGFJGHHHEJC.content.SetActive(true);
		((Component)LucenNPC.GGFJGHHHEJC).transform.position = initialPositions[1].position;
		LucenNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
		if (OnlineManager.MasterOrOffline())
		{
			ZuzzuNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
			RinNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
			KentaNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
			((Behaviour)ZuzzuNPC.GGFJGHHHEJC.routine).enabled = false;
			((Behaviour)RinNPC.GGFJGHHHEJC.routine).enabled = false;
			((Behaviour)KentaNPC.GGFJGHHHEJC.routine).enabled = false;
		}
		TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Bathhouse, Location.BathhouseInterior);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Combine(travelZone.OnTravelZoneTo, new Action<int>(StartEvent));
	}

	private void NJEJKIFMINF()
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		LucenNPC.GGFJGHHHEJC.animationBase.SetBool("Throw", EGFGNGJGBOP: false);
		KyrohNPC.GGFJGHHHEJC.animationBase.SetBool("LucenFall", EGFGNGJGBOP: true);
		KyrohNPC.GGFJGHHHEJC.animationBase.SetBool("LucenThrow", EGFGNGJGBOP: false);
		splash.transform.position = ((Component)KyrohNPC.GGFJGHHHEJC).transform.position;
		splash.SetActive(true);
		DIFKLOCALFE = ((Component)KyrohNPC.GGFJGHHHEJC).transform.position;
		NPCDEKGDFMK = initialSpeed;
		moviendo = true;
	}

	public override void StartEvent(bool BFLCJPHHDJM, bool CDPAMNIPPEC)
	{
		base.StartEvent(BFLCJPHHDJM, CDPAMNIPPEC);
		PsaiCore.Instance.StopMusic(immediately: false);
		MusicController.instance.TriggerMusicTheme(38, 0.3f);
		PsaiCore.Instance.HoldCurrentIntensity(hold: true);
		WorldTime.JJICPIINBEH = false;
		WorldTime.ChangeHour(23);
		WorldTime.StopTimeWithDelay();
		TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Bathhouse, Location.BathhouseInterior);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(StartEvent));
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		HPCOIICLFBD();
		((MonoBehaviour)this).StartCoroutine(EFOONHMKJEB());
	}
}
