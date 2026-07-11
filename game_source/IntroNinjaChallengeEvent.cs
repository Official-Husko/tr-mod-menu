using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class IntroNinjaChallengeEvent : GameEvent
{
	[CompilerGenerated]
	private sealed class KBPHLLGNLEF : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public IntroNinjaChallengeEvent _003C_003E4__this;

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
		public KBPHLLGNLEF(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			IntroNinjaChallengeEvent introNinjaChallengeEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				instance.EDGDFPPKGDL = null;
				DialogueLua.SetVariable("MainProgress", (object)19);
				if (Utils.AHMPFOEGJHF(Location.BathhouseInterior))
				{
					DialogueCameraTarget.GetPlayer(1).cameraInEvent = true;
					DialogueCameraTarget.GetPlayer(2).cameraInEvent = true;
					DialogueCameraTarget.MoveCameraToPositionFromCameraTargetAllPlayers(Vector2.op_Implicit(introNinjaChallengeEvent.cameraPositions[0].position));
				}
				KyrohNPC.GGFJGHHHEJC.targetWalkTo = Vector2.op_Implicit(introNinjaChallengeEvent.movePositions[1].position);
				KyrohNPC.GGFJGHHHEJC.disable = true;
				KyrohNPC.GGFJGHHHEJC.ChangeState(KyrohState.WalkTo);
				ZuzzuNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(introNinjaChallengeEvent.movePositions[2].position), Direction.Down, AMEOKNOLILB: true);
				_003C_003E2__current = CommonReferences.wait5;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
				if (Utils.AHMPFOEGJHF(Location.BathhouseInterior))
				{
					DialogueCameraTarget.GetPlayer(1).ReturnControlToCameraTarget();
				}
				if (GameManager.LocalCoop() && Utils.AHMPFOEGJHF(Location.BathhouseInterior, 2))
				{
					DialogueCameraTarget.GetPlayer(2).ReturnControlToCameraTarget();
				}
				_003C_003E2__current = CommonReferences.wait5;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				NinjaChallengeEvent.instance.ActivateEvent();
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
	private sealed class MPEBPBMIPGA : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public IntroNinjaChallengeEvent _003C_003E4__this;

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
		public MPEBPBMIPGA(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			IntroNinjaChallengeEvent introNinjaChallengeEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				instance.EDGDFPPKGDL = null;
				if (Utils.AHMPFOEGJHF(Location.BathhouseInterior))
				{
					DialogueCameraTarget.GetPlayer(1).cameraInEvent = true;
					DialogueCameraTarget.GetPlayer(2).cameraInEvent = true;
					DialogueCameraTarget.MoveCameraToPositionFromCameraTargetAllPlayers(Vector2.op_Implicit(introNinjaChallengeEvent.cameraPositions[0].position), 2f);
				}
				ZuzzuNPC.GGFJGHHHEJC.content.SetActive(true);
				((Component)ZuzzuNPC.GGFJGHHHEJC).transform.position = introNinjaChallengeEvent.positions[1].position;
				ZuzzuNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
				ZuzzuNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(introNinjaChallengeEvent.movePositions[0].position), Direction.Right);
				_003C_003E2__current = CommonReferences.wait5;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				if (Utils.AHMPFOEGJHF(Location.BathhouseInterior))
				{
					DialogueCameraTarget.GetPlayer(1).ReturnControlToCameraTarget();
				}
				if (GameManager.LocalCoop() && Utils.AHMPFOEGJHF(Location.BathhouseInterior, 2))
				{
					DialogueCameraTarget.GetPlayer(2).ReturnControlToCameraTarget();
				}
				KyrohNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Left);
				if (instance.isActor)
				{
					PlayerController.GetPlayer(1).characterAnimation.SetDirection(Direction.Left);
				}
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				instance.EDGDFPPKGDL = ZuzzuNPC.GGFJGHHHEJC;
				instance.MDFALJKHKED = "IntroNinjaChallengeEvent/Main 2";
				if (instance.isActor)
				{
					ZuzzuNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "IntroNinjaChallengeEvent/Main 2");
				}
				else if (Utils.AHMPFOEGJHF(Location.BathhouseInterior))
				{
					((MonoBehaviour)instance).StartCoroutine(ZuzzuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
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

	public static IntroNinjaChallengeEvent instance;

	public Transform[] cameraPositions;

	public Transform[] positions;

	public Transform[] movePositions;

	public void NPJNFPJHBCJ()
	{
		((MonoBehaviour)instance).StartCoroutine(AGKNGFCCMNJ());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendIntroNinjaChallengeEventMoveZuzzu();
		}
	}

	private void BCBCJFHJHDI(bool GFNHAMCPEAK)
	{
		if (GFNHAMCPEAK)
		{
			CJODOOFLLLB = KyrohNPC.PBJDFFEFMKM().EHHOHCPHAAO;
			StartEvent(GFNHAMCPEAK, CDPAMNIPPEC: true);
		}
	}

	public void MoveZuzzu()
	{
		((MonoBehaviour)instance).StartCoroutine(IKPNMPALKAH());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendIntroNinjaChallengeEventMoveZuzzu();
		}
	}

	private IEnumerator GLKHNENPAIA()
	{
		instance.EDGDFPPKGDL = null;
		DialogueLua.SetVariable("MainProgress", (object)19);
		if (Utils.AHMPFOEGJHF(Location.BathhouseInterior))
		{
			DialogueCameraTarget.GetPlayer(1).cameraInEvent = true;
			DialogueCameraTarget.GetPlayer(2).cameraInEvent = true;
			DialogueCameraTarget.MoveCameraToPositionFromCameraTargetAllPlayers(Vector2.op_Implicit(cameraPositions[0].position));
		}
		KyrohNPC.GGFJGHHHEJC.targetWalkTo = Vector2.op_Implicit(movePositions[1].position);
		KyrohNPC.GGFJGHHHEJC.disable = true;
		KyrohNPC.GGFJGHHHEJC.ChangeState(KyrohState.WalkTo);
		ZuzzuNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePositions[2].position), Direction.Down, AMEOKNOLILB: true);
		yield return CommonReferences.wait5;
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		if (Utils.AHMPFOEGJHF(Location.BathhouseInterior))
		{
			DialogueCameraTarget.GetPlayer(1).ReturnControlToCameraTarget();
		}
		if (GameManager.LocalCoop() && Utils.AHMPFOEGJHF(Location.BathhouseInterior, 2))
		{
			DialogueCameraTarget.GetPlayer(2).ReturnControlToCameraTarget();
		}
		yield return CommonReferences.wait5;
		NinjaChallengeEvent.instance.ActivateEvent();
	}

	private IEnumerator IKPNMPALKAH()
	{
		instance.EDGDFPPKGDL = null;
		if (Utils.AHMPFOEGJHF(Location.BathhouseInterior))
		{
			DialogueCameraTarget.GetPlayer(1).cameraInEvent = true;
			DialogueCameraTarget.GetPlayer(2).cameraInEvent = true;
			DialogueCameraTarget.MoveCameraToPositionFromCameraTargetAllPlayers(Vector2.op_Implicit(cameraPositions[0].position), 2f);
		}
		ZuzzuNPC.GGFJGHHHEJC.content.SetActive(true);
		((Component)ZuzzuNPC.GGFJGHHHEJC).transform.position = positions[1].position;
		ZuzzuNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		ZuzzuNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePositions[0].position), Direction.Right);
		yield return CommonReferences.wait5;
		if (Utils.AHMPFOEGJHF(Location.BathhouseInterior))
		{
			DialogueCameraTarget.GetPlayer(1).ReturnControlToCameraTarget();
		}
		if (GameManager.LocalCoop() && Utils.AHMPFOEGJHF(Location.BathhouseInterior, 2))
		{
			DialogueCameraTarget.GetPlayer(2).ReturnControlToCameraTarget();
		}
		KyrohNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Left);
		if (instance.isActor)
		{
			PlayerController.GetPlayer(1).characterAnimation.SetDirection(Direction.Left);
		}
		yield return CommonReferences.wait1;
		instance.EDGDFPPKGDL = ZuzzuNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "IntroNinjaChallengeEvent/Main 2";
		if (instance.isActor)
		{
			ZuzzuNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "IntroNinjaChallengeEvent/Main 2");
		}
		else if (Utils.AHMPFOEGJHF(Location.BathhouseInterior))
		{
			((MonoBehaviour)instance).StartCoroutine(ZuzzuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private IEnumerator DJBCKIFHFNO()
	{
		instance.EDGDFPPKGDL = null;
		if (Utils.AHMPFOEGJHF(Location.BathhouseInterior))
		{
			DialogueCameraTarget.GetPlayer(1).cameraInEvent = true;
			DialogueCameraTarget.GetPlayer(2).cameraInEvent = true;
			DialogueCameraTarget.MoveCameraToPositionFromCameraTargetAllPlayers(Vector2.op_Implicit(cameraPositions[0].position), 2f);
		}
		ZuzzuNPC.GGFJGHHHEJC.content.SetActive(true);
		((Component)ZuzzuNPC.GGFJGHHHEJC).transform.position = positions[1].position;
		ZuzzuNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		ZuzzuNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePositions[0].position), Direction.Right);
		yield return CommonReferences.wait5;
		if (Utils.AHMPFOEGJHF(Location.BathhouseInterior))
		{
			DialogueCameraTarget.GetPlayer(1).ReturnControlToCameraTarget();
		}
		if (GameManager.LocalCoop() && Utils.AHMPFOEGJHF(Location.BathhouseInterior, 2))
		{
			DialogueCameraTarget.GetPlayer(2).ReturnControlToCameraTarget();
		}
		KyrohNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Left);
		if (instance.isActor)
		{
			PlayerController.GetPlayer(1).characterAnimation.SetDirection(Direction.Left);
		}
		yield return CommonReferences.wait1;
		instance.EDGDFPPKGDL = ZuzzuNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "IntroNinjaChallengeEvent/Main 2";
		if (instance.isActor)
		{
			ZuzzuNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "IntroNinjaChallengeEvent/Main 2");
		}
		else if (Utils.AHMPFOEGJHF(Location.BathhouseInterior))
		{
			((MonoBehaviour)instance).StartCoroutine(ZuzzuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private void BGOGMLGDCMH(bool GFNHAMCPEAK)
	{
		if (GFNHAMCPEAK)
		{
			CJODOOFLLLB = KyrohNPC.GGFJGHHHEJC.EHHOHCPHAAO;
			StartEvent(GFNHAMCPEAK, CDPAMNIPPEC: false);
		}
	}

	public void MOHFCPMBJIM()
	{
		((MonoBehaviour)instance).StartCoroutine(DJBCKIFHFNO());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendIntroNinjaChallengeEventMoveZuzzu();
		}
	}

	public void KMPCNECKLJC()
	{
		((MonoBehaviour)instance).StartCoroutine(GCCOEDGBLBK());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendIntroNinjaChallengeEventMoveZuzzu();
		}
	}

	public override GameEvent GetInstance()
	{
		return instance;
	}

	private IEnumerator ELNJOBCEPHA()
	{
		return new MPEBPBMIPGA(1)
		{
			_003C_003E4__this = this
		};
	}

	public void DPBIKPGMENM()
	{
		((MonoBehaviour)instance).StartCoroutine(LPBPHFKMPJO());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendIntroNinjaChallengeEventMoveZuzzu();
		}
	}

	public void MOGMCGJNOKD()
	{
		((MonoBehaviour)instance).StartCoroutine(DIHBFNHNKPJ());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendIntroNinjaChallengeEventMoveZuzzu();
		}
	}

	protected override void Awake()
	{
		base.Awake();
		instance = this;
	}

	private void MMLKNDAGKPB(bool GFNHAMCPEAK)
	{
		if (GFNHAMCPEAK)
		{
			CJODOOFLLLB = KyrohNPC.AGGAGCBAGLL().EHHOHCPHAAO;
			StartEvent(GFNHAMCPEAK, CDPAMNIPPEC: false);
		}
	}

	private IEnumerator CIJFOPNABGB()
	{
		return new KBPHLLGNLEF(1)
		{
			_003C_003E4__this = this
		};
	}

	public void FCCAJFKHCMA()
	{
		((MonoBehaviour)instance).StartCoroutine(ELNJOBCEPHA());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendIntroNinjaChallengeEventMoveZuzzu();
		}
	}

	private IEnumerator LPBPHFKMPJO()
	{
		instance.EDGDFPPKGDL = null;
		if (Utils.AHMPFOEGJHF(Location.BathhouseInterior))
		{
			DialogueCameraTarget.GetPlayer(1).cameraInEvent = true;
			DialogueCameraTarget.GetPlayer(2).cameraInEvent = true;
			DialogueCameraTarget.MoveCameraToPositionFromCameraTargetAllPlayers(Vector2.op_Implicit(cameraPositions[0].position), 2f);
		}
		ZuzzuNPC.GGFJGHHHEJC.content.SetActive(true);
		((Component)ZuzzuNPC.GGFJGHHHEJC).transform.position = positions[1].position;
		ZuzzuNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		ZuzzuNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePositions[0].position), Direction.Right);
		yield return CommonReferences.wait5;
		if (Utils.AHMPFOEGJHF(Location.BathhouseInterior))
		{
			DialogueCameraTarget.GetPlayer(1).ReturnControlToCameraTarget();
		}
		if (GameManager.LocalCoop() && Utils.AHMPFOEGJHF(Location.BathhouseInterior, 2))
		{
			DialogueCameraTarget.GetPlayer(2).ReturnControlToCameraTarget();
		}
		KyrohNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Left);
		if (instance.isActor)
		{
			PlayerController.GetPlayer(1).characterAnimation.SetDirection(Direction.Left);
		}
		yield return CommonReferences.wait1;
		instance.EDGDFPPKGDL = ZuzzuNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "IntroNinjaChallengeEvent/Main 2";
		if (instance.isActor)
		{
			ZuzzuNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "IntroNinjaChallengeEvent/Main 2");
		}
		else if (Utils.AHMPFOEGJHF(Location.BathhouseInterior))
		{
			((MonoBehaviour)instance).StartCoroutine(ZuzzuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	public override void StartEvent(bool BFLCJPHHDJM, bool CDPAMNIPPEC)
	{
		base.StartEvent(BFLCJPHHDJM, CDPAMNIPPEC);
		KyrohNPC kyrohNPC = KyrohNPC.GGFJGHHHEJC;
		kyrohNPC.ConversationStarted = (Action<bool>)Delegate.Remove(kyrohNPC.ConversationStarted, new Action<bool>(AEEHFGIDCMJ));
		KyrohNPC.GGFJGHHHEJC.inSpecialEvent = true;
		KyrohNPC.GGFJGHHHEJC.blockActionBar = true;
		EDGDFPPKGDL = KyrohNPC.GGFJGHHHEJC;
		MDFALJKHKED = "IntroNinjaChallengeEvent/Main";
		if (GameManager.LocalCoop())
		{
			cameraPosition = ((Component)KyrohNPC.GGFJGHHHEJC).transform;
			PrepareLocalCoop(Location.BathhouseInterior);
		}
		if (Utils.AHMPFOEGJHF(Location.BathhouseInterior, CJODOOFLLLB))
		{
			PlayerInputs.DisableKeyboardInputsAndMovement(CJODOOFLLLB, (MonoBehaviour)(object)instance);
		}
		if (!isActor && OnlineManager.PlayingOnline() && Utils.AHMPFOEGJHF(Location.BathhouseInterior))
		{
			((MonoBehaviour)this).StartCoroutine(KyrohNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private IEnumerator OPPFGDILELM()
	{
		instance.EDGDFPPKGDL = null;
		DialogueLua.SetVariable("MainProgress", (object)19);
		if (Utils.AHMPFOEGJHF(Location.BathhouseInterior))
		{
			DialogueCameraTarget.GetPlayer(1).cameraInEvent = true;
			DialogueCameraTarget.GetPlayer(2).cameraInEvent = true;
			DialogueCameraTarget.MoveCameraToPositionFromCameraTargetAllPlayers(Vector2.op_Implicit(cameraPositions[0].position));
		}
		KyrohNPC.GGFJGHHHEJC.targetWalkTo = Vector2.op_Implicit(movePositions[1].position);
		KyrohNPC.GGFJGHHHEJC.disable = true;
		KyrohNPC.GGFJGHHHEJC.ChangeState(KyrohState.WalkTo);
		ZuzzuNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePositions[2].position), Direction.Down, AMEOKNOLILB: true);
		yield return CommonReferences.wait5;
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		if (Utils.AHMPFOEGJHF(Location.BathhouseInterior))
		{
			DialogueCameraTarget.GetPlayer(1).ReturnControlToCameraTarget();
		}
		if (GameManager.LocalCoop() && Utils.AHMPFOEGJHF(Location.BathhouseInterior, 2))
		{
			DialogueCameraTarget.GetPlayer(2).ReturnControlToCameraTarget();
		}
		yield return CommonReferences.wait5;
		NinjaChallengeEvent.instance.ActivateEvent();
	}

	private void AEEHFGIDCMJ(bool GFNHAMCPEAK)
	{
		if (GFNHAMCPEAK)
		{
			CJODOOFLLLB = KyrohNPC.GGFJGHHHEJC.EHHOHCPHAAO;
			StartEvent(GFNHAMCPEAK, CDPAMNIPPEC: true);
		}
	}

	public void CHGJJBDMIGK()
	{
		((MonoBehaviour)instance).StartCoroutine(DJBCKIFHFNO());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendIntroNinjaChallengeEventMoveZuzzu();
		}
	}

	public void NOMEIFMHIFB()
	{
		((MonoBehaviour)instance).StartCoroutine(IKPNMPALKAH());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendIntroNinjaChallengeEventMoveZuzzu();
		}
	}

	private void BLIJAFHDDCJ(bool GFNHAMCPEAK)
	{
		if (GFNHAMCPEAK)
		{
			CJODOOFLLLB = KyrohNPC.JLNBMNKJCHE().EHHOHCPHAAO;
			StartEvent(GFNHAMCPEAK, CDPAMNIPPEC: true);
		}
	}

	public override void ActivateEvent()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		base.ActivateEvent();
		((Component)ZuzzuNPC.GGFJGHHHEJC).transform.position = positions[1].position;
		ZuzzuNPC.GGFJGHHHEJC.content.SetActive(false);
		((Component)KyrohNPC.GGFJGHHHEJC).transform.parent = null;
		if (OnlineManager.MasterOrOffline())
		{
			ZuzzuNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
			((Behaviour)ZuzzuNPC.GGFJGHHHEJC.routine).enabled = false;
			KyrohNPC.GGFJGHHHEJC.content.SetActive(false);
		}
		KyrohNPC.GGFJGHHHEJC.content.SetActive(true);
		((Component)KyrohNPC.GGFJGHHHEJC).transform.position = positions[0].position;
		KyrohNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		KyrohNPC kyrohNPC = KyrohNPC.GGFJGHHHEJC;
		kyrohNPC.ConversationStarted = (Action<bool>)Delegate.Combine(kyrohNPC.ConversationStarted, new Action<bool>(AEEHFGIDCMJ));
	}

	private IEnumerator FECCGCOIEDJ()
	{
		instance.EDGDFPPKGDL = null;
		DialogueLua.SetVariable("MainProgress", (object)19);
		if (Utils.AHMPFOEGJHF(Location.BathhouseInterior))
		{
			DialogueCameraTarget.GetPlayer(1).cameraInEvent = true;
			DialogueCameraTarget.GetPlayer(2).cameraInEvent = true;
			DialogueCameraTarget.MoveCameraToPositionFromCameraTargetAllPlayers(Vector2.op_Implicit(cameraPositions[0].position));
		}
		KyrohNPC.GGFJGHHHEJC.targetWalkTo = Vector2.op_Implicit(movePositions[1].position);
		KyrohNPC.GGFJGHHHEJC.disable = true;
		KyrohNPC.GGFJGHHHEJC.ChangeState(KyrohState.WalkTo);
		ZuzzuNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePositions[2].position), Direction.Down, AMEOKNOLILB: true);
		yield return CommonReferences.wait5;
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		if (Utils.AHMPFOEGJHF(Location.BathhouseInterior))
		{
			DialogueCameraTarget.GetPlayer(1).ReturnControlToCameraTarget();
		}
		if (GameManager.LocalCoop() && Utils.AHMPFOEGJHF(Location.BathhouseInterior, 2))
		{
			DialogueCameraTarget.GetPlayer(2).ReturnControlToCameraTarget();
		}
		yield return CommonReferences.wait5;
		NinjaChallengeEvent.instance.ActivateEvent();
	}

	private IEnumerator ELFPIDGFEHH()
	{
		instance.EDGDFPPKGDL = null;
		DialogueLua.SetVariable("MainProgress", (object)19);
		if (Utils.AHMPFOEGJHF(Location.BathhouseInterior))
		{
			DialogueCameraTarget.GetPlayer(1).cameraInEvent = true;
			DialogueCameraTarget.GetPlayer(2).cameraInEvent = true;
			DialogueCameraTarget.MoveCameraToPositionFromCameraTargetAllPlayers(Vector2.op_Implicit(cameraPositions[0].position));
		}
		KyrohNPC.GGFJGHHHEJC.targetWalkTo = Vector2.op_Implicit(movePositions[1].position);
		KyrohNPC.GGFJGHHHEJC.disable = true;
		KyrohNPC.GGFJGHHHEJC.ChangeState(KyrohState.WalkTo);
		ZuzzuNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePositions[2].position), Direction.Down, AMEOKNOLILB: true);
		yield return CommonReferences.wait5;
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		if (Utils.AHMPFOEGJHF(Location.BathhouseInterior))
		{
			DialogueCameraTarget.GetPlayer(1).ReturnControlToCameraTarget();
		}
		if (GameManager.LocalCoop() && Utils.AHMPFOEGJHF(Location.BathhouseInterior, 2))
		{
			DialogueCameraTarget.GetPlayer(2).ReturnControlToCameraTarget();
		}
		yield return CommonReferences.wait5;
		NinjaChallengeEvent.instance.ActivateEvent();
	}

	private void INICHFPEEBG(bool GFNHAMCPEAK)
	{
		if (GFNHAMCPEAK)
		{
			CJODOOFLLLB = KyrohNPC.JLNBMNKJCHE().EHHOHCPHAAO;
			StartEvent(GFNHAMCPEAK, CDPAMNIPPEC: false);
		}
	}

	private IEnumerator AJGGMHBIKHK()
	{
		instance.EDGDFPPKGDL = null;
		DialogueLua.SetVariable("MainProgress", (object)19);
		if (Utils.AHMPFOEGJHF(Location.BathhouseInterior))
		{
			DialogueCameraTarget.GetPlayer(1).cameraInEvent = true;
			DialogueCameraTarget.GetPlayer(2).cameraInEvent = true;
			DialogueCameraTarget.MoveCameraToPositionFromCameraTargetAllPlayers(Vector2.op_Implicit(cameraPositions[0].position));
		}
		KyrohNPC.GGFJGHHHEJC.targetWalkTo = Vector2.op_Implicit(movePositions[1].position);
		KyrohNPC.GGFJGHHHEJC.disable = true;
		KyrohNPC.GGFJGHHHEJC.ChangeState(KyrohState.WalkTo);
		ZuzzuNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePositions[2].position), Direction.Down, AMEOKNOLILB: true);
		yield return CommonReferences.wait5;
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		if (Utils.AHMPFOEGJHF(Location.BathhouseInterior))
		{
			DialogueCameraTarget.GetPlayer(1).ReturnControlToCameraTarget();
		}
		if (GameManager.LocalCoop() && Utils.AHMPFOEGJHF(Location.BathhouseInterior, 2))
		{
			DialogueCameraTarget.GetPlayer(2).ReturnControlToCameraTarget();
		}
		yield return CommonReferences.wait5;
		NinjaChallengeEvent.instance.ActivateEvent();
	}

	public void CKLKGMEKBOH()
	{
		((MonoBehaviour)instance).StartCoroutine(ELNJOBCEPHA());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendIntroNinjaChallengeEventMoveZuzzu();
		}
	}

	public override void EndEvent(bool _isActor)
	{
		base.EndEvent(_isActor);
		((MonoBehaviour)instance).StartCoroutine(LJABJLDHLCB());
	}

	private IEnumerator KDKMHBNNHKE()
	{
		return new KBPHLLGNLEF(1)
		{
			_003C_003E4__this = this
		};
	}

	private void BEPAKMIFIJK(bool GFNHAMCPEAK)
	{
		if (GFNHAMCPEAK)
		{
			CJODOOFLLLB = KyrohNPC.KADHMEPDIKM().EHHOHCPHAAO;
			StartEvent(GFNHAMCPEAK, CDPAMNIPPEC: true);
		}
	}

	public void DIFHAMCLIDG()
	{
		((MonoBehaviour)instance).StartCoroutine(AGKNGFCCMNJ());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendIntroNinjaChallengeEventMoveZuzzu();
		}
	}

	private IEnumerator LBCKNFKEEPB()
	{
		return new KBPHLLGNLEF(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator DIHBFNHNKPJ()
	{
		instance.EDGDFPPKGDL = null;
		if (Utils.AHMPFOEGJHF(Location.BathhouseInterior))
		{
			DialogueCameraTarget.GetPlayer(1).cameraInEvent = true;
			DialogueCameraTarget.GetPlayer(2).cameraInEvent = true;
			DialogueCameraTarget.MoveCameraToPositionFromCameraTargetAllPlayers(Vector2.op_Implicit(cameraPositions[0].position), 2f);
		}
		ZuzzuNPC.GGFJGHHHEJC.content.SetActive(true);
		((Component)ZuzzuNPC.GGFJGHHHEJC).transform.position = positions[1].position;
		ZuzzuNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		ZuzzuNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePositions[0].position), Direction.Right);
		yield return CommonReferences.wait5;
		if (Utils.AHMPFOEGJHF(Location.BathhouseInterior))
		{
			DialogueCameraTarget.GetPlayer(1).ReturnControlToCameraTarget();
		}
		if (GameManager.LocalCoop() && Utils.AHMPFOEGJHF(Location.BathhouseInterior, 2))
		{
			DialogueCameraTarget.GetPlayer(2).ReturnControlToCameraTarget();
		}
		KyrohNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Left);
		if (instance.isActor)
		{
			PlayerController.GetPlayer(1).characterAnimation.SetDirection(Direction.Left);
		}
		yield return CommonReferences.wait1;
		instance.EDGDFPPKGDL = ZuzzuNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "IntroNinjaChallengeEvent/Main 2";
		if (instance.isActor)
		{
			ZuzzuNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "IntroNinjaChallengeEvent/Main 2");
		}
		else if (Utils.AHMPFOEGJHF(Location.BathhouseInterior))
		{
			((MonoBehaviour)instance).StartCoroutine(ZuzzuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private IEnumerator GCCOEDGBLBK()
	{
		return new MPEBPBMIPGA(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JCDIMFGBEPB()
	{
		return new MPEBPBMIPGA(1)
		{
			_003C_003E4__this = this
		};
	}

	private void GINEBGJCGGG(bool GFNHAMCPEAK)
	{
		if (GFNHAMCPEAK)
		{
			CJODOOFLLLB = KyrohNPC.KFGKCKCDMLG().EHHOHCPHAAO;
			StartEvent(GFNHAMCPEAK, CDPAMNIPPEC: false);
		}
	}

	private IEnumerator LEAOONIJDLD()
	{
		return new KBPHLLGNLEF(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AGKNGFCCMNJ()
	{
		instance.EDGDFPPKGDL = null;
		if (Utils.AHMPFOEGJHF(Location.BathhouseInterior))
		{
			DialogueCameraTarget.GetPlayer(1).cameraInEvent = true;
			DialogueCameraTarget.GetPlayer(2).cameraInEvent = true;
			DialogueCameraTarget.MoveCameraToPositionFromCameraTargetAllPlayers(Vector2.op_Implicit(cameraPositions[0].position), 2f);
		}
		ZuzzuNPC.GGFJGHHHEJC.content.SetActive(true);
		((Component)ZuzzuNPC.GGFJGHHHEJC).transform.position = positions[1].position;
		ZuzzuNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		ZuzzuNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePositions[0].position), Direction.Right);
		yield return CommonReferences.wait5;
		if (Utils.AHMPFOEGJHF(Location.BathhouseInterior))
		{
			DialogueCameraTarget.GetPlayer(1).ReturnControlToCameraTarget();
		}
		if (GameManager.LocalCoop() && Utils.AHMPFOEGJHF(Location.BathhouseInterior, 2))
		{
			DialogueCameraTarget.GetPlayer(2).ReturnControlToCameraTarget();
		}
		KyrohNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Left);
		if (instance.isActor)
		{
			PlayerController.GetPlayer(1).characterAnimation.SetDirection(Direction.Left);
		}
		yield return CommonReferences.wait1;
		instance.EDGDFPPKGDL = ZuzzuNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "IntroNinjaChallengeEvent/Main 2";
		if (instance.isActor)
		{
			ZuzzuNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "IntroNinjaChallengeEvent/Main 2");
		}
		else if (Utils.AHMPFOEGJHF(Location.BathhouseInterior))
		{
			((MonoBehaviour)instance).StartCoroutine(ZuzzuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private IEnumerator LJABJLDHLCB()
	{
		instance.EDGDFPPKGDL = null;
		DialogueLua.SetVariable("MainProgress", (object)19);
		if (Utils.AHMPFOEGJHF(Location.BathhouseInterior))
		{
			DialogueCameraTarget.GetPlayer(1).cameraInEvent = true;
			DialogueCameraTarget.GetPlayer(2).cameraInEvent = true;
			DialogueCameraTarget.MoveCameraToPositionFromCameraTargetAllPlayers(Vector2.op_Implicit(cameraPositions[0].position));
		}
		KyrohNPC.GGFJGHHHEJC.targetWalkTo = Vector2.op_Implicit(movePositions[1].position);
		KyrohNPC.GGFJGHHHEJC.disable = true;
		KyrohNPC.GGFJGHHHEJC.ChangeState(KyrohState.WalkTo);
		ZuzzuNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePositions[2].position), Direction.Down, AMEOKNOLILB: true);
		yield return CommonReferences.wait5;
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		if (Utils.AHMPFOEGJHF(Location.BathhouseInterior))
		{
			DialogueCameraTarget.GetPlayer(1).ReturnControlToCameraTarget();
		}
		if (GameManager.LocalCoop() && Utils.AHMPFOEGJHF(Location.BathhouseInterior, 2))
		{
			DialogueCameraTarget.GetPlayer(2).ReturnControlToCameraTarget();
		}
		yield return CommonReferences.wait5;
		NinjaChallengeEvent.instance.ActivateEvent();
	}

	private IEnumerator KAFMCBNCBFI()
	{
		instance.EDGDFPPKGDL = null;
		DialogueLua.SetVariable("MainProgress", (object)19);
		if (Utils.AHMPFOEGJHF(Location.BathhouseInterior))
		{
			DialogueCameraTarget.GetPlayer(1).cameraInEvent = true;
			DialogueCameraTarget.GetPlayer(2).cameraInEvent = true;
			DialogueCameraTarget.MoveCameraToPositionFromCameraTargetAllPlayers(Vector2.op_Implicit(cameraPositions[0].position));
		}
		KyrohNPC.GGFJGHHHEJC.targetWalkTo = Vector2.op_Implicit(movePositions[1].position);
		KyrohNPC.GGFJGHHHEJC.disable = true;
		KyrohNPC.GGFJGHHHEJC.ChangeState(KyrohState.WalkTo);
		ZuzzuNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePositions[2].position), Direction.Down, AMEOKNOLILB: true);
		yield return CommonReferences.wait5;
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		if (Utils.AHMPFOEGJHF(Location.BathhouseInterior))
		{
			DialogueCameraTarget.GetPlayer(1).ReturnControlToCameraTarget();
		}
		if (GameManager.LocalCoop() && Utils.AHMPFOEGJHF(Location.BathhouseInterior, 2))
		{
			DialogueCameraTarget.GetPlayer(2).ReturnControlToCameraTarget();
		}
		yield return CommonReferences.wait5;
		NinjaChallengeEvent.instance.ActivateEvent();
	}

	private void CJMPLCDBOEP(bool GFNHAMCPEAK)
	{
		if (GFNHAMCPEAK)
		{
			CJODOOFLLLB = KyrohNPC.OAPOJCODNCO().EHHOHCPHAAO;
			StartEvent(GFNHAMCPEAK, CDPAMNIPPEC: true);
		}
	}

	private IEnumerator KCJMAECGPLN()
	{
		instance.EDGDFPPKGDL = null;
		DialogueLua.SetVariable("MainProgress", (object)19);
		if (Utils.AHMPFOEGJHF(Location.BathhouseInterior))
		{
			DialogueCameraTarget.GetPlayer(1).cameraInEvent = true;
			DialogueCameraTarget.GetPlayer(2).cameraInEvent = true;
			DialogueCameraTarget.MoveCameraToPositionFromCameraTargetAllPlayers(Vector2.op_Implicit(cameraPositions[0].position));
		}
		KyrohNPC.GGFJGHHHEJC.targetWalkTo = Vector2.op_Implicit(movePositions[1].position);
		KyrohNPC.GGFJGHHHEJC.disable = true;
		KyrohNPC.GGFJGHHHEJC.ChangeState(KyrohState.WalkTo);
		ZuzzuNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePositions[2].position), Direction.Down, AMEOKNOLILB: true);
		yield return CommonReferences.wait5;
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		if (Utils.AHMPFOEGJHF(Location.BathhouseInterior))
		{
			DialogueCameraTarget.GetPlayer(1).ReturnControlToCameraTarget();
		}
		if (GameManager.LocalCoop() && Utils.AHMPFOEGJHF(Location.BathhouseInterior, 2))
		{
			DialogueCameraTarget.GetPlayer(2).ReturnControlToCameraTarget();
		}
		yield return CommonReferences.wait5;
		NinjaChallengeEvent.instance.ActivateEvent();
	}

	private IEnumerator DHINCHODEFI()
	{
		return new KBPHLLGNLEF(1)
		{
			_003C_003E4__this = this
		};
	}
}
