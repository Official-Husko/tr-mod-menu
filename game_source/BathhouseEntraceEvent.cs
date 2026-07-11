using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class BathhouseEntraceEvent : GameEvent
{
	[CompilerGenerated]
	private sealed class PCEEJNAEBNG : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BathhouseEntraceEvent _003C_003E4__this;

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
		public PCEEJNAEBNG(int _003C_003E1__state)
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
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_010c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0111: Unknown result type (might be due to invalid IL or missing references)
			//IL_0148: Unknown result type (might be due to invalid IL or missing references)
			//IL_014d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0152: Unknown result type (might be due to invalid IL or missing references)
			//IL_017a: Unknown result type (might be due to invalid IL or missing references)
			//IL_017f: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			BathhouseEntraceEvent bathhouseEntraceEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				bathhouseEntraceEvent.EDGDFPPKGDL = null;
				KlaynNPC.instance.content.SetActive(true);
				((Component)KlaynNPC.instance).transform.position = bathhouseEntraceEvent.positions[0].position;
				KlaynNPC.instance.animationBase.SetDirection(Direction.Down);
				TweekNPC.GGFJGHHHEJC.content.SetActive(true);
				((Component)TweekNPC.GGFJGHHHEJC).transform.position = bathhouseEntraceEvent.positions[1].position;
				TweekNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
				if (instance.isActor)
				{
					PlayerController.GetPlayer(bathhouseEntraceEvent.CJODOOFLLLB).GoToPosition(Vector2.op_Implicit(bathhouseEntraceEvent.movePositions[0].position), KLGOCJMGKFO: true);
					goto IL_00f9;
				}
				goto IL_0134;
			case 1:
				_003C_003E1__state = -1;
				goto IL_00f9;
			case 2:
				_003C_003E1__state = -1;
				KlaynNPC.instance.inSpecialEvent = true;
				_003C_003E2__current = OnlineManager.WaitForAllPlayers();
				_003C_003E1__state = 3;
				return true;
			case 3:
				_003C_003E1__state = -1;
				KlaynNPC.instance.blockActionBar = true;
				TweekNPC.GGFJGHHHEJC.blockActionBar = true;
				bathhouseEntraceEvent.EDGDFPPKGDL = KlaynNPC.instance;
				bathhouseEntraceEvent.MDFALJKHKED = "BathhouseEntrace/Main";
				if (instance.isActor)
				{
					KlaynNPC.instance.StartConversation(bathhouseEntraceEvent.CJODOOFLLLB, "BathhouseEntrace/Main");
				}
				else if (Utils.AHMPFOEGJHF(Location.Bathhouse))
				{
					_003C_003E2__current = KlaynNPC.instance.StartObserverDialogueWhenItIsPossible(1);
					_003C_003E1__state = 4;
					return true;
				}
				break;
			case 4:
				{
					_003C_003E1__state = -1;
					break;
				}
				IL_00f9:
				if (!PlayerController.GetPlayer(bathhouseEntraceEvent.CJODOOFLLLB).GoToPosition(Vector2.op_Implicit(bathhouseEntraceEvent.movePositions[0].position), KLGOCJMGKFO: false))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
				PlayerController.GetPlayer(bathhouseEntraceEvent.CJODOOFLLLB).characterAnimation.SetDirection(Direction.Up);
				goto IL_0134;
				IL_0134:
				if (OnlineManager.MasterOrOffline())
				{
					KlaynNPC.instance.targetWalkTo = Vector2.op_Implicit(bathhouseEntraceEvent.movePositions[1].position);
					KlaynNPC.instance.endWalkDirection = Direction.Right;
					KlaynNPC.instance.ChangeState(KlaynState.WalkTo);
					TweekNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(bathhouseEntraceEvent.movePositions[2].position), Direction.Left);
				}
				if (Utils.AHMPFOEGJHF(Location.Bathhouse))
				{
					bathhouseEntraceEvent.JCIDFJMJMAA(bathhouseEntraceEvent.cameraPosition);
				}
				_003C_003E2__current = CommonReferences.wait3;
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

	public static BathhouseEntraceEvent instance;

	public Transform[] positions;

	public Transform[] movePositions;

	public Collider2D trigger;

	public override void StartEvent(bool BFLCJPHHDJM, bool CDPAMNIPPEC)
	{
		base.StartEvent(BFLCJPHHDJM, CDPAMNIPPEC);
		((Behaviour)trigger).enabled = false;
		if (GameManager.LocalCoop())
		{
			PrepareLocalCoop(Location.Bathhouse);
		}
		if (Utils.AHMPFOEGJHF(Location.Bathhouse, CJODOOFLLLB))
		{
			PlayerInputs.DisableKeyboardInputsAndMovement(CJODOOFLLLB, (MonoBehaviour)(object)instance);
		}
		else if (OnlineManager.PlayingOnline())
		{
			TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Bathhouse, Location.Quarry);
			travelZone.OnTravelZoneTo = (Action<int>)Delegate.Combine(travelZone.OnTravelZoneTo, new Action<int>(JKELFKLGGID));
		}
		((MonoBehaviour)this).StartCoroutine(instance.IOBCDFAIKCA());
	}

	public void MoveToPlayerEvent()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.GPGJDJKFDJC());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendBathhouseEntranceEventMoveToPlayer();
		}
	}

	public void HLCDLKOAFNA()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.PJPCEDNJBGD());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendBathhouseEntranceEventLeftBathhouse();
		}
	}

	private IEnumerator NDONKLKIJGO()
	{
		EDGDFPPKGDL = null;
		KlaynNPC.instance.content.SetActive(true);
		((Component)KlaynNPC.instance).transform.position = positions[0].position;
		KlaynNPC.instance.animationBase.SetDirection(Direction.Down);
		TweekNPC.GGFJGHHHEJC.content.SetActive(true);
		((Component)TweekNPC.GGFJGHHHEJC).transform.position = positions[1].position;
		TweekNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (instance.isActor)
		{
			PlayerController.GetPlayer(CJODOOFLLLB).GoToPosition(Vector2.op_Implicit(movePositions[0].position), KLGOCJMGKFO: true);
			while (!PlayerController.GetPlayer(CJODOOFLLLB).GoToPosition(Vector2.op_Implicit(movePositions[0].position), KLGOCJMGKFO: false))
			{
				yield return null;
			}
			PlayerController.GetPlayer(CJODOOFLLLB).characterAnimation.SetDirection(Direction.Up);
		}
		if (OnlineManager.MasterOrOffline())
		{
			KlaynNPC.instance.targetWalkTo = Vector2.op_Implicit(movePositions[1].position);
			KlaynNPC.instance.endWalkDirection = Direction.Right;
			KlaynNPC.instance.ChangeState(KlaynState.WalkTo);
			TweekNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePositions[2].position), Direction.Left);
		}
		if (Utils.AHMPFOEGJHF(Location.Bathhouse))
		{
			JCIDFJMJMAA(cameraPosition);
		}
		yield return CommonReferences.wait3;
		KlaynNPC.instance.inSpecialEvent = true;
		yield return OnlineManager.WaitForAllPlayers();
		KlaynNPC.instance.blockActionBar = true;
		TweekNPC.GGFJGHHHEJC.blockActionBar = true;
		EDGDFPPKGDL = KlaynNPC.instance;
		MDFALJKHKED = "BathhouseEntrace/Main";
		if (instance.isActor)
		{
			KlaynNPC.instance.StartConversation(CJODOOFLLLB, "BathhouseEntrace/Main");
		}
		else if (Utils.AHMPFOEGJHF(Location.Bathhouse))
		{
			yield return KlaynNPC.instance.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	public void LeftBathhouseEvent()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.PJPCEDNJBGD());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendBathhouseEntranceEventLeftBathhouse();
		}
	}

	private IEnumerator MJBKLKEHDEI()
	{
		EDGDFPPKGDL = null;
		if (OnlineManager.MasterOrOffline())
		{
			KlaynNPC.instance.targetWalkTo = Vector2.op_Implicit(instance.movePositions[5].position);
			KlaynNPC.instance.disable = true;
			KlaynNPC.instance.ChangeState(KlaynState.WalkTo);
			TweekNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(instance.movePositions[6].position));
		}
		yield return CommonReferences.wait2_5;
		KlaynNPC.instance.blockActionBar = false;
		TweekNPC.GGFJGHHHEJC.blockActionBar = false;
		EDGDFPPKGDL = TweekNPC.GGFJGHHHEJC;
		MDFALJKHKED = "BathhouseEntrace/Main 3";
		if (instance.isActor)
		{
			TweekNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "BathhouseEntrace/Main 3");
		}
		else if (Utils.AHMPFOEGJHF(Location.Bathhouse))
		{
			yield return TweekNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	public void OGMJJDFJNDD()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.NFFFKJKIDAG());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendBathhouseEntranceEventMoveToPlayer();
		}
	}

	private void ANCLKCMNPLA(int JIIGOACEIKL)
	{
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance, ANJCLPDCJHL: true);
		PlayerController.GetPlayer(1).characterAnimation.SetDirection((Direction)8);
		if (Object.op_Implicit((Object)(object)EDGDFPPKGDL))
		{
			((MonoBehaviour)this).StartCoroutine(EDGDFPPKGDL.StartObserverDialogueWhenItIsPossible(1));
		}
		JCIDFJMJMAA(((Component)KlaynNPC.instance).gameObject);
	}

	private void JKELFKLGGID(int JIIGOACEIKL)
	{
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		PlayerController.GetPlayer(1).characterAnimation.SetDirection(Direction.Left);
		if (Object.op_Implicit((Object)(object)EDGDFPPKGDL))
		{
			((MonoBehaviour)this).StartCoroutine(EDGDFPPKGDL.StartObserverDialogueWhenItIsPossible(1));
		}
		JCIDFJMJMAA(((Component)KlaynNPC.instance).gameObject);
	}

	private void ONMNAKPKAKH(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Door") || ((Component)HANHCHBHHEH).CompareTag("bed"))
		{
			CJODOOFLLLB = (((Component)HANHCHBHHEH).CompareTag("Selected") ? 1 : 0);
			StartEvent(BFLCJPHHDJM: false, CDPAMNIPPEC: false);
		}
	}

	public override GameEvent GetInstance()
	{
		return instance;
	}

	public void CKPLPNGNINJ()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.OCFNAAEIEEC());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendBathhouseEntranceEventLeftBathhouse();
		}
	}

	private void MJKDLOHNECA(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag(":</color> ") || ((Component)HANHCHBHHEH).CompareTag("hour"))
		{
			CJODOOFLLLB = (((Component)HANHCHBHHEH).CompareTag("CultivableDuringOneMonth") ? 0 : 0);
			StartEvent(BFLCJPHHDJM: true, CDPAMNIPPEC: false);
		}
	}

	private IEnumerator NFDGJADMCOG()
	{
		EDGDFPPKGDL = null;
		TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Bathhouse, Location.Quarry);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(JKELFKLGGID));
		DialogueLua.SetVariable("MainProgress", (object)18);
		TweekNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(instance.movePositions[7].position), Direction.Down, AMEOKNOLILB: true);
		TweekNPC.GGFJGHHHEJC.playerCanInteract = false;
		KlaynNPC.instance.playerCanInteract = false;
		yield return CommonReferences.wait3;
		if (Utils.AHMPFOEGJHF(Location.Bathhouse))
		{
			DialogueCameraTarget.GetPlayer(1).ReturnControlToCameraTarget();
		}
		if (GameManager.LocalCoop() && Utils.AHMPFOEGJHF(Location.Bathhouse, 2))
		{
			DialogueCameraTarget.GetPlayer(2).ReturnControlToCameraTarget();
		}
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		IntroNinjaChallengeEvent.instance.ActivateEvent();
		yield return CommonReferences.wait10;
		TweekNPC.GGFJGHHHEJC.playerCanInteract = true;
		KlaynNPC.instance.playerCanInteract = true;
	}

	private void OnTriggerEnter2D(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Player") || ((Component)HANHCHBHHEH).CompareTag("Player2"))
		{
			CJODOOFLLLB = ((!((Component)HANHCHBHHEH).CompareTag("Player2")) ? 1 : 2);
			StartEvent(BFLCJPHHDJM: true, CDPAMNIPPEC: true);
		}
	}

	protected override void Awake()
	{
		base.Awake();
		instance = this;
	}

	private IEnumerator DDKDOFIOACD()
	{
		return new PCEEJNAEBNG(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator KKMBCNFKGHF()
	{
		return new PCEEJNAEBNG(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator PJPCEDNJBGD()
	{
		EDGDFPPKGDL = null;
		if (OnlineManager.MasterOrOffline())
		{
			KlaynNPC.instance.targetWalkTo = Vector2.op_Implicit(instance.movePositions[5].position);
			KlaynNPC.instance.disable = true;
			KlaynNPC.instance.ChangeState(KlaynState.WalkTo);
			TweekNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(instance.movePositions[6].position));
		}
		yield return CommonReferences.wait2_5;
		KlaynNPC.instance.blockActionBar = false;
		TweekNPC.GGFJGHHHEJC.blockActionBar = false;
		EDGDFPPKGDL = TweekNPC.GGFJGHHHEJC;
		MDFALJKHKED = "BathhouseEntrace/Main 3";
		if (instance.isActor)
		{
			TweekNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "BathhouseEntrace/Main 3");
		}
		else if (Utils.AHMPFOEGJHF(Location.Bathhouse))
		{
			yield return TweekNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private IEnumerator GLCCMPPNCEC()
	{
		EDGDFPPKGDL = null;
		KlaynNPC.instance.content.SetActive(true);
		((Component)KlaynNPC.instance).transform.position = positions[0].position;
		KlaynNPC.instance.animationBase.SetDirection(Direction.Down);
		TweekNPC.GGFJGHHHEJC.content.SetActive(true);
		((Component)TweekNPC.GGFJGHHHEJC).transform.position = positions[1].position;
		TweekNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (instance.isActor)
		{
			PlayerController.GetPlayer(CJODOOFLLLB).GoToPosition(Vector2.op_Implicit(movePositions[0].position), KLGOCJMGKFO: true);
			while (!PlayerController.GetPlayer(CJODOOFLLLB).GoToPosition(Vector2.op_Implicit(movePositions[0].position), KLGOCJMGKFO: false))
			{
				yield return null;
			}
			PlayerController.GetPlayer(CJODOOFLLLB).characterAnimation.SetDirection(Direction.Up);
		}
		if (OnlineManager.MasterOrOffline())
		{
			KlaynNPC.instance.targetWalkTo = Vector2.op_Implicit(movePositions[1].position);
			KlaynNPC.instance.endWalkDirection = Direction.Right;
			KlaynNPC.instance.ChangeState(KlaynState.WalkTo);
			TweekNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePositions[2].position), Direction.Left);
		}
		if (Utils.AHMPFOEGJHF(Location.Bathhouse))
		{
			JCIDFJMJMAA(cameraPosition);
		}
		yield return CommonReferences.wait3;
		KlaynNPC.instance.inSpecialEvent = true;
		yield return OnlineManager.WaitForAllPlayers();
		KlaynNPC.instance.blockActionBar = true;
		TweekNPC.GGFJGHHHEJC.blockActionBar = true;
		EDGDFPPKGDL = KlaynNPC.instance;
		MDFALJKHKED = "BathhouseEntrace/Main";
		if (instance.isActor)
		{
			KlaynNPC.instance.StartConversation(CJODOOFLLLB, "BathhouseEntrace/Main");
		}
		else if (Utils.AHMPFOEGJHF(Location.Bathhouse))
		{
			yield return KlaynNPC.instance.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private IEnumerator FCNJKBPKLJK()
	{
		return new PCEEJNAEBNG(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator KDKMHBNNHKE()
	{
		EDGDFPPKGDL = null;
		TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Bathhouse, Location.Quarry);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(JKELFKLGGID));
		DialogueLua.SetVariable("MainProgress", (object)18);
		TweekNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(instance.movePositions[7].position), Direction.Down, AMEOKNOLILB: true);
		TweekNPC.GGFJGHHHEJC.playerCanInteract = false;
		KlaynNPC.instance.playerCanInteract = false;
		yield return CommonReferences.wait3;
		if (Utils.AHMPFOEGJHF(Location.Bathhouse))
		{
			DialogueCameraTarget.GetPlayer(1).ReturnControlToCameraTarget();
		}
		if (GameManager.LocalCoop() && Utils.AHMPFOEGJHF(Location.Bathhouse, 2))
		{
			DialogueCameraTarget.GetPlayer(2).ReturnControlToCameraTarget();
		}
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		IntroNinjaChallengeEvent.instance.ActivateEvent();
		yield return CommonReferences.wait10;
		TweekNPC.GGFJGHHHEJC.playerCanInteract = true;
		KlaynNPC.instance.playerCanInteract = true;
	}

	private IEnumerator IOBCDFAIKCA()
	{
		EDGDFPPKGDL = null;
		KlaynNPC.instance.content.SetActive(true);
		((Component)KlaynNPC.instance).transform.position = positions[0].position;
		KlaynNPC.instance.animationBase.SetDirection(Direction.Down);
		TweekNPC.GGFJGHHHEJC.content.SetActive(true);
		((Component)TweekNPC.GGFJGHHHEJC).transform.position = positions[1].position;
		TweekNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (instance.isActor)
		{
			PlayerController.GetPlayer(CJODOOFLLLB).GoToPosition(Vector2.op_Implicit(movePositions[0].position), KLGOCJMGKFO: true);
			while (!PlayerController.GetPlayer(CJODOOFLLLB).GoToPosition(Vector2.op_Implicit(movePositions[0].position), KLGOCJMGKFO: false))
			{
				yield return null;
			}
			PlayerController.GetPlayer(CJODOOFLLLB).characterAnimation.SetDirection(Direction.Up);
		}
		if (OnlineManager.MasterOrOffline())
		{
			KlaynNPC.instance.targetWalkTo = Vector2.op_Implicit(movePositions[1].position);
			KlaynNPC.instance.endWalkDirection = Direction.Right;
			KlaynNPC.instance.ChangeState(KlaynState.WalkTo);
			TweekNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePositions[2].position), Direction.Left);
		}
		if (Utils.AHMPFOEGJHF(Location.Bathhouse))
		{
			JCIDFJMJMAA(cameraPosition);
		}
		yield return CommonReferences.wait3;
		KlaynNPC.instance.inSpecialEvent = true;
		yield return OnlineManager.WaitForAllPlayers();
		KlaynNPC.instance.blockActionBar = true;
		TweekNPC.GGFJGHHHEJC.blockActionBar = true;
		EDGDFPPKGDL = KlaynNPC.instance;
		MDFALJKHKED = "BathhouseEntrace/Main";
		if (instance.isActor)
		{
			KlaynNPC.instance.StartConversation(CJODOOFLLLB, "BathhouseEntrace/Main");
		}
		else if (Utils.AHMPFOEGJHF(Location.Bathhouse))
		{
			yield return KlaynNPC.instance.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private IEnumerator PDAEJOBLIIJ()
	{
		EDGDFPPKGDL = null;
		KlaynNPC.instance.animationBase.SetDirection(Direction.Down);
		TweekNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		KlaynNPC.instance.StartEmotions("Exclamation");
		TweekNPC.GGFJGHHHEJC.StartEmotions("Exclamation");
		KlaynNPC.instance.animationBase.SetTrigger("SurpriseJump");
		TweekNPC.GGFJGHHHEJC.animationBase.SetTrigger("SurpriseJump");
		yield return CommonReferences.wait1_5;
		if (OnlineManager.MasterOrOffline())
		{
			KlaynNPC.instance.targetWalkTo = Vector2.op_Implicit(instance.movePositions[3].position);
			KlaynNPC.instance.ChangeState(KlaynState.WalkTo);
			TweekNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(instance.movePositions[4].position));
		}
		yield return CommonReferences.wait1_5;
		yield return OnlineManager.WaitForAllPlayers();
		EDGDFPPKGDL = KlaynNPC.instance;
		MDFALJKHKED = "BathhouseEntrace/Main 2";
		if (instance.isActor)
		{
			KlaynNPC.instance.StartConversation(CJODOOFLLLB, "BathhouseEntrace/Main 2");
		}
		else if (Utils.AHMPFOEGJHF(Location.Bathhouse))
		{
			yield return KlaynNPC.instance.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private void PKKBPKPMMJG(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Items/item_description_653") || ((Component)HANHCHBHHEH).CompareTag("{0}: {1}\n"))
		{
			CJODOOFLLLB = ((!((Component)HANHCHBHHEH).CompareTag("Dialogue System/Conversation/BirdCatInteraction/Entry/4/Dialogue Text")) ? 1 : 0);
			StartEvent(BFLCJPHHDJM: false, CDPAMNIPPEC: true);
		}
	}

	private IEnumerator OCFNAAEIEEC()
	{
		EDGDFPPKGDL = null;
		if (OnlineManager.MasterOrOffline())
		{
			KlaynNPC.instance.targetWalkTo = Vector2.op_Implicit(instance.movePositions[5].position);
			KlaynNPC.instance.disable = true;
			KlaynNPC.instance.ChangeState(KlaynState.WalkTo);
			TweekNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(instance.movePositions[6].position));
		}
		yield return CommonReferences.wait2_5;
		KlaynNPC.instance.blockActionBar = false;
		TweekNPC.GGFJGHHHEJC.blockActionBar = false;
		EDGDFPPKGDL = TweekNPC.GGFJGHHHEJC;
		MDFALJKHKED = "BathhouseEntrace/Main 3";
		if (instance.isActor)
		{
			TweekNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "BathhouseEntrace/Main 3");
		}
		else if (Utils.AHMPFOEGJHF(Location.Bathhouse))
		{
			yield return TweekNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private IEnumerator LJABJLDHLCB()
	{
		EDGDFPPKGDL = null;
		TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Bathhouse, Location.Quarry);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(JKELFKLGGID));
		DialogueLua.SetVariable("MainProgress", (object)18);
		TweekNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(instance.movePositions[7].position), Direction.Down, AMEOKNOLILB: true);
		TweekNPC.GGFJGHHHEJC.playerCanInteract = false;
		KlaynNPC.instance.playerCanInteract = false;
		yield return CommonReferences.wait3;
		if (Utils.AHMPFOEGJHF(Location.Bathhouse))
		{
			DialogueCameraTarget.GetPlayer(1).ReturnControlToCameraTarget();
		}
		if (GameManager.LocalCoop() && Utils.AHMPFOEGJHF(Location.Bathhouse, 2))
		{
			DialogueCameraTarget.GetPlayer(2).ReturnControlToCameraTarget();
		}
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		IntroNinjaChallengeEvent.instance.ActivateEvent();
		yield return CommonReferences.wait10;
		TweekNPC.GGFJGHHHEJC.playerCanInteract = true;
		KlaynNPC.instance.playerCanInteract = true;
	}

	private IEnumerator GPGJDJKFDJC()
	{
		EDGDFPPKGDL = null;
		KlaynNPC.instance.animationBase.SetDirection(Direction.Down);
		TweekNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		KlaynNPC.instance.StartEmotions("Exclamation");
		TweekNPC.GGFJGHHHEJC.StartEmotions("Exclamation");
		KlaynNPC.instance.animationBase.SetTrigger("SurpriseJump");
		TweekNPC.GGFJGHHHEJC.animationBase.SetTrigger("SurpriseJump");
		yield return CommonReferences.wait1_5;
		if (OnlineManager.MasterOrOffline())
		{
			KlaynNPC.instance.targetWalkTo = Vector2.op_Implicit(instance.movePositions[3].position);
			KlaynNPC.instance.ChangeState(KlaynState.WalkTo);
			TweekNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(instance.movePositions[4].position));
		}
		yield return CommonReferences.wait1_5;
		yield return OnlineManager.WaitForAllPlayers();
		EDGDFPPKGDL = KlaynNPC.instance;
		MDFALJKHKED = "BathhouseEntrace/Main 2";
		if (instance.isActor)
		{
			KlaynNPC.instance.StartConversation(CJODOOFLLLB, "BathhouseEntrace/Main 2");
		}
		else if (Utils.AHMPFOEGJHF(Location.Bathhouse))
		{
			yield return KlaynNPC.instance.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	public void DAMHMNLCHFA()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.NFFFKJKIDAG());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendBathhouseEntranceEventMoveToPlayer();
		}
	}

	public override void EndEvent(bool _isActor)
	{
		base.EndEvent(_isActor);
		((MonoBehaviour)instance).StartCoroutine(instance.LJABJLDHLCB());
	}

	private void KICCNEPCCFB(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Disabled") || ((Component)HANHCHBHHEH).CompareTag("Items/item_description_648"))
		{
			CJODOOFLLLB = (((Component)HANHCHBHHEH).CompareTag("ExampleScripted") ? 6 : 0);
			StartEvent(BFLCJPHHDJM: false, CDPAMNIPPEC: false);
		}
	}

	private IEnumerator NKIBNFLBBNI()
	{
		return new PCEEJNAEBNG(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator PKHBFIMPNJK()
	{
		EDGDFPPKGDL = null;
		TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Bathhouse, Location.Quarry);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(JKELFKLGGID));
		DialogueLua.SetVariable("MainProgress", (object)18);
		TweekNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(instance.movePositions[7].position), Direction.Down, AMEOKNOLILB: true);
		TweekNPC.GGFJGHHHEJC.playerCanInteract = false;
		KlaynNPC.instance.playerCanInteract = false;
		yield return CommonReferences.wait3;
		if (Utils.AHMPFOEGJHF(Location.Bathhouse))
		{
			DialogueCameraTarget.GetPlayer(1).ReturnControlToCameraTarget();
		}
		if (GameManager.LocalCoop() && Utils.AHMPFOEGJHF(Location.Bathhouse, 2))
		{
			DialogueCameraTarget.GetPlayer(2).ReturnControlToCameraTarget();
		}
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		IntroNinjaChallengeEvent.instance.ActivateEvent();
		yield return CommonReferences.wait10;
		TweekNPC.GGFJGHHHEJC.playerCanInteract = true;
		KlaynNPC.instance.playerCanInteract = true;
	}

	private void GLMENOJADEF(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("PlayerJoined") || ((Component)HANHCHBHHEH).CompareTag("[ProceduralMine] AltarFirst: {0} - AltarTarget: {1} - PuzzleTarget: {2}"))
		{
			CJODOOFLLLB = (((Component)HANHCHBHHEH).CompareTag("FloorMaterial") ? 1 : 0);
			StartEvent(BFLCJPHHDJM: false, CDPAMNIPPEC: false);
		}
	}

	private void EDKLIJCELNO(int JIIGOACEIKL)
	{
		PlayerInputs.CMEBIMMKIAB((MonoBehaviour)(object)instance);
		PlayerController.OPHDCMJLLEC(0).characterAnimation.SetDirection(Direction.Right);
		if (Object.op_Implicit((Object)(object)EDGDFPPKGDL))
		{
			((MonoBehaviour)this).StartCoroutine(EDGDFPPKGDL.StartObserverDialogueWhenItIsPossible(0));
		}
		JCIDFJMJMAA(((Component)KlaynNPC.instance).gameObject);
	}

	public void CDHIIIKEPFB()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.MJBKLKEHDEI());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendBathhouseEntranceEventLeftBathhouse();
		}
	}

	private void IFNIHABABKH(int JIIGOACEIKL)
	{
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		PlayerController.OPHDCMJLLEC(0).characterAnimation.SetDirection(Direction.Left);
		if (Object.op_Implicit((Object)(object)EDGDFPPKGDL))
		{
			((MonoBehaviour)this).StartCoroutine(EDGDFPPKGDL.StartObserverDialogueWhenItIsPossible(0));
		}
		JCIDFJMJMAA(((Component)KlaynNPC.instance).gameObject);
	}

	public override void ActivateEvent()
	{
		base.ActivateEvent();
		((Behaviour)trigger).enabled = true;
	}

	private IEnumerator KJDFHMHOHMB()
	{
		EDGDFPPKGDL = null;
		KlaynNPC.instance.animationBase.SetDirection(Direction.Down);
		TweekNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		KlaynNPC.instance.StartEmotions("Exclamation");
		TweekNPC.GGFJGHHHEJC.StartEmotions("Exclamation");
		KlaynNPC.instance.animationBase.SetTrigger("SurpriseJump");
		TweekNPC.GGFJGHHHEJC.animationBase.SetTrigger("SurpriseJump");
		yield return CommonReferences.wait1_5;
		if (OnlineManager.MasterOrOffline())
		{
			KlaynNPC.instance.targetWalkTo = Vector2.op_Implicit(instance.movePositions[3].position);
			KlaynNPC.instance.ChangeState(KlaynState.WalkTo);
			TweekNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(instance.movePositions[4].position));
		}
		yield return CommonReferences.wait1_5;
		yield return OnlineManager.WaitForAllPlayers();
		EDGDFPPKGDL = KlaynNPC.instance;
		MDFALJKHKED = "BathhouseEntrace/Main 2";
		if (instance.isActor)
		{
			KlaynNPC.instance.StartConversation(CJODOOFLLLB, "BathhouseEntrace/Main 2");
		}
		else if (Utils.AHMPFOEGJHF(Location.Bathhouse))
		{
			yield return KlaynNPC.instance.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private IEnumerator NFFFKJKIDAG()
	{
		EDGDFPPKGDL = null;
		KlaynNPC.instance.animationBase.SetDirection(Direction.Down);
		TweekNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		KlaynNPC.instance.StartEmotions("Exclamation");
		TweekNPC.GGFJGHHHEJC.StartEmotions("Exclamation");
		KlaynNPC.instance.animationBase.SetTrigger("SurpriseJump");
		TweekNPC.GGFJGHHHEJC.animationBase.SetTrigger("SurpriseJump");
		yield return CommonReferences.wait1_5;
		if (OnlineManager.MasterOrOffline())
		{
			KlaynNPC.instance.targetWalkTo = Vector2.op_Implicit(instance.movePositions[3].position);
			KlaynNPC.instance.ChangeState(KlaynState.WalkTo);
			TweekNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(instance.movePositions[4].position));
		}
		yield return CommonReferences.wait1_5;
		yield return OnlineManager.WaitForAllPlayers();
		EDGDFPPKGDL = KlaynNPC.instance;
		MDFALJKHKED = "BathhouseEntrace/Main 2";
		if (instance.isActor)
		{
			KlaynNPC.instance.StartConversation(CJODOOFLLLB, "BathhouseEntrace/Main 2");
		}
		else if (Utils.AHMPFOEGJHF(Location.Bathhouse))
		{
			yield return KlaynNPC.instance.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	public void PCNPIKFHPGE()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.NFFFKJKIDAG());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendBathhouseEntranceEventMoveToPlayer();
		}
	}

	private IEnumerator CIJFOPNABGB()
	{
		EDGDFPPKGDL = null;
		TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Bathhouse, Location.Quarry);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(JKELFKLGGID));
		DialogueLua.SetVariable("MainProgress", (object)18);
		TweekNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(instance.movePositions[7].position), Direction.Down, AMEOKNOLILB: true);
		TweekNPC.GGFJGHHHEJC.playerCanInteract = false;
		KlaynNPC.instance.playerCanInteract = false;
		yield return CommonReferences.wait3;
		if (Utils.AHMPFOEGJHF(Location.Bathhouse))
		{
			DialogueCameraTarget.GetPlayer(1).ReturnControlToCameraTarget();
		}
		if (GameManager.LocalCoop() && Utils.AHMPFOEGJHF(Location.Bathhouse, 2))
		{
			DialogueCameraTarget.GetPlayer(2).ReturnControlToCameraTarget();
		}
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		IntroNinjaChallengeEvent.instance.ActivateEvent();
		yield return CommonReferences.wait10;
		TweekNPC.GGFJGHHHEJC.playerCanInteract = true;
		KlaynNPC.instance.playerCanInteract = true;
	}

	private void KFBPPJJPCBF(int JIIGOACEIKL)
	{
		PlayerInputs.CMEBIMMKIAB((MonoBehaviour)(object)instance, ANJCLPDCJHL: true);
		PlayerController.OPHDCMJLLEC(1).characterAnimation.SetDirection((Direction)6);
		if (Object.op_Implicit((Object)(object)EDGDFPPKGDL))
		{
			((MonoBehaviour)this).StartCoroutine(EDGDFPPKGDL.StartObserverDialogueWhenItIsPossible(1));
		}
		JCIDFJMJMAA(((Component)KlaynNPC.instance).gameObject);
	}

	private void PIOMHOLIHKH(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("autoRun") || ((Component)HANHCHBHHEH).CompareTag("LE_22"))
		{
			CJODOOFLLLB = (((Component)HANHCHBHHEH).CompareTag("Override save?") ? 0 : 0);
			StartEvent(BFLCJPHHDJM: true, CDPAMNIPPEC: true);
		}
	}

	private IEnumerator KFFOGPDLKGJ()
	{
		EDGDFPPKGDL = null;
		KlaynNPC.instance.content.SetActive(true);
		((Component)KlaynNPC.instance).transform.position = positions[0].position;
		KlaynNPC.instance.animationBase.SetDirection(Direction.Down);
		TweekNPC.GGFJGHHHEJC.content.SetActive(true);
		((Component)TweekNPC.GGFJGHHHEJC).transform.position = positions[1].position;
		TweekNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		if (instance.isActor)
		{
			PlayerController.GetPlayer(CJODOOFLLLB).GoToPosition(Vector2.op_Implicit(movePositions[0].position), KLGOCJMGKFO: true);
			while (!PlayerController.GetPlayer(CJODOOFLLLB).GoToPosition(Vector2.op_Implicit(movePositions[0].position), KLGOCJMGKFO: false))
			{
				yield return null;
			}
			PlayerController.GetPlayer(CJODOOFLLLB).characterAnimation.SetDirection(Direction.Up);
		}
		if (OnlineManager.MasterOrOffline())
		{
			KlaynNPC.instance.targetWalkTo = Vector2.op_Implicit(movePositions[1].position);
			KlaynNPC.instance.endWalkDirection = Direction.Right;
			KlaynNPC.instance.ChangeState(KlaynState.WalkTo);
			TweekNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePositions[2].position), Direction.Left);
		}
		if (Utils.AHMPFOEGJHF(Location.Bathhouse))
		{
			JCIDFJMJMAA(cameraPosition);
		}
		yield return CommonReferences.wait3;
		KlaynNPC.instance.inSpecialEvent = true;
		yield return OnlineManager.WaitForAllPlayers();
		KlaynNPC.instance.blockActionBar = true;
		TweekNPC.GGFJGHHHEJC.blockActionBar = true;
		EDGDFPPKGDL = KlaynNPC.instance;
		MDFALJKHKED = "BathhouseEntrace/Main";
		if (instance.isActor)
		{
			KlaynNPC.instance.StartConversation(CJODOOFLLLB, "BathhouseEntrace/Main");
		}
		else if (Utils.AHMPFOEGJHF(Location.Bathhouse))
		{
			yield return KlaynNPC.instance.StartObserverDialogueWhenItIsPossible(1);
		}
	}
}
