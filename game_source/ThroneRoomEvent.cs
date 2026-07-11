using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class ThroneRoomEvent : GameEvent
{
	[CompilerGenerated]
	private sealed class KEGBCFCCMAM : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ThroneRoomEvent _003C_003E4__this;

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
		public KEGBCFCCMAM(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			ThroneRoomEvent throneRoomEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
			{
				_003C_003E1__state = -1;
				TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Castle, Location.CastleGarden);
				travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(throneRoomEvent.EAPLAJLIHBO));
				PlayerInputs.DisableKeyboardInputsAndMovement(throneRoomEvent.CJODOOFLLLB, (MonoBehaviour)(object)instance);
				DialogueCameraTarget.GetPlayer(throneRoomEvent.CJODOOFLLLB).cameraInEvent = true;
				DialogueCameraTarget.GetPlayer(throneRoomEvent.CJODOOFLLLB).MoveCameraToPositionFromCameraTarget(Vector2.op_Implicit(throneRoomEvent.cameraPosition.position));
				_003C_003E2__current = CommonReferences.wait3;
				_003C_003E1__state = 1;
				return true;
			}
			case 1:
				_003C_003E1__state = -1;
				throneRoomEvent.EDGDFPPKGDL = OxNPC.GGFJGHHHEJC;
				throneRoomEvent.MDFALJKHKED = "SalonDelTrono/MainEvent";
				OxNPC.GGFJGHHHEJC.inSpecialEvent = true;
				if (throneRoomEvent.isActor)
				{
					Debug.Log((object)"StartConversation SalonDelTrono");
					OxNPC.GGFJGHHHEJC.barkDialogue = false;
					OxNPC.GGFJGHHHEJC.StartConversation(throneRoomEvent.CJODOOFLLLB, "SalonDelTrono/MainEvent");
				}
				else if (OnlineManager.PlayingOnline())
				{
					Debug.Log((object)"StartObserver SalonDelTrono");
					_003C_003E2__current = OxNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
					_003C_003E1__state = 2;
					return true;
				}
				break;
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

	public static ThroneRoomEvent instance;

	public Transform[] positions;

	public GameObject[] chairs;

	public Door door;

	public Collider2D trigger;

	private IEnumerator AABLGFDJBBC()
	{
		TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Castle, Location.CastleGarden);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(EAPLAJLIHBO));
		PlayerInputs.DisableKeyboardInputsAndMovement(CJODOOFLLLB, (MonoBehaviour)(object)instance);
		DialogueCameraTarget.GetPlayer(CJODOOFLLLB).cameraInEvent = true;
		DialogueCameraTarget.GetPlayer(CJODOOFLLLB).MoveCameraToPositionFromCameraTarget(Vector2.op_Implicit(cameraPosition.position));
		yield return CommonReferences.wait3;
		EDGDFPPKGDL = OxNPC.GGFJGHHHEJC;
		MDFALJKHKED = "SalonDelTrono/MainEvent";
		OxNPC.GGFJGHHHEJC.inSpecialEvent = true;
		if (isActor)
		{
			Debug.Log((object)"StartConversation SalonDelTrono");
			OxNPC.GGFJGHHHEJC.barkDialogue = false;
			OxNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "SalonDelTrono/MainEvent");
		}
		else if (OnlineManager.PlayingOnline())
		{
			Debug.Log((object)"StartObserver SalonDelTrono");
			yield return OxNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private IEnumerator JPKELJFHCCI()
	{
		return new KEGBCFCCMAM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void EAPLAJLIHBO(int AAAIOBLCOFO)
	{
		StartEvent(BFLCJPHHDJM: false, CDPAMNIPPEC: false);
	}

	private IEnumerator FEGLBKFCPCB()
	{
		return new KEGBCFCCMAM(1)
		{
			_003C_003E4__this = this
		};
	}

	protected override void Awake()
	{
		base.Awake();
		instance = this;
	}

	private void MOKFHIFJBFC(int AAAIOBLCOFO)
	{
		StartEvent(BFLCJPHHDJM: true, CDPAMNIPPEC: false);
	}

	private void HBLNGBOFAPN(int AAAIOBLCOFO)
	{
		StartEvent(BFLCJPHHDJM: false, CDPAMNIPPEC: true);
	}

	private IEnumerator BGJJIPACGBE()
	{
		TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Castle, Location.CastleGarden);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(EAPLAJLIHBO));
		PlayerInputs.DisableKeyboardInputsAndMovement(CJODOOFLLLB, (MonoBehaviour)(object)instance);
		DialogueCameraTarget.GetPlayer(CJODOOFLLLB).cameraInEvent = true;
		DialogueCameraTarget.GetPlayer(CJODOOFLLLB).MoveCameraToPositionFromCameraTarget(Vector2.op_Implicit(cameraPosition.position));
		yield return CommonReferences.wait3;
		EDGDFPPKGDL = OxNPC.GGFJGHHHEJC;
		MDFALJKHKED = "SalonDelTrono/MainEvent";
		OxNPC.GGFJGHHHEJC.inSpecialEvent = true;
		if (isActor)
		{
			Debug.Log((object)"StartConversation SalonDelTrono");
			OxNPC.GGFJGHHHEJC.barkDialogue = false;
			OxNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "SalonDelTrono/MainEvent");
		}
		else if (OnlineManager.PlayingOnline())
		{
			Debug.Log((object)"StartObserver SalonDelTrono");
			yield return OxNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	public override void EndEvent(bool BGKCHMNJBLJ)
	{
		((MonoBehaviour)instance).StartCoroutine(instance.LJABJLDHLCB());
		CommonReferences.GGFJGHHHEJC.OnActionDone(CJODOOFLLLB, ActionDone.SpyCastle);
		DialogueLua.SetVariable("MainProgress", (object)8);
		if (BGKCHMNJBLJ && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendEndEvent(eventType);
		}
	}

	private IEnumerator CLHIAHEFHLN()
	{
		return new KEGBCFCCMAM(1)
		{
			_003C_003E4__this = this
		};
	}

	public void PPPKINIAHNI()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		KlaynNPC.instance.GIFBCKEOBGP(KlaynState.WaitingToServe);
		((Component)KlaynNPC.instance).transform.position = positions[2].position;
		KlaynNPC.instance.content.SetActive(false);
		KlaynNPC.instance.animationBase.SetBool("Aged price", EGFGNGJGBOP: false);
		KlaynNPC.instance.animationBase.LookDirection(Direction.Left);
	}

	private void GFFNFFOHNHH(bool BGKCHMNJBLJ)
	{
		base.EndEvent(BGKCHMNJBLJ);
	}

	private IEnumerator LJABJLDHLCB()
	{
		EDGDFPPKGDL = null;
		TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Castle, Location.CastleGarden);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(EAPLAJLIHBO));
		if (GameManager.LocalCoop())
		{
			RemoveAllTravelZonesCallbacks(Location.Castle);
		}
		KyrohNPC.GGFJGHHHEJC.animationBase.SetBool("Sit", EGFGNGJGBOP: false);
		KyrohNPC.GGFJGHHHEJC.animationBase.SetTrigger("SmokeBomb");
		yield return CommonReferences.wait2;
		KyrohNPC.GGFJGHHHEJC.ChangeState(KyrohState.Inactive);
		((Component)KyrohNPC.GGFJGHHHEJC).transform.parent = null;
		yield return CommonReferences.wait1;
		if (Utils.AHMPFOEGJHF(Location.Castle))
		{
			DialogueCameraTarget.GetPlayer(1).ReturnControlToCameraTarget();
		}
		if (GameManager.LocalCoop() && Utils.AHMPFOEGJHF(Location.Castle, 2))
		{
			DialogueCameraTarget.GetPlayer(2).ReturnControlToCameraTarget();
		}
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		while (Utils.NGLLIJPOBEC(Location.Castle))
		{
			yield return null;
		}
		base.EndEvent(BGKCHMNJBLJ: false);
		instance.door.OpenCloseAction(DBCDEKIEHMG: false);
		instance.door.inputEnabled = false;
		HawksNPC.GGFJGHHHEJC.content.SetActive(true);
		LucenNPC.GGFJGHHHEJC.content.SetActive(false);
		KlaynNPC.instance.content.SetActive(false);
		RibellaNPC.GGFJGHHHEJC.content.SetActive(false);
		((Component)RibellaNPC.GGFJGHHHEJC).transform.parent = null;
		OxNPC.GGFJGHHHEJC.content.SetActive(false);
		((Component)OxNPC.GGFJGHHHEJC).transform.parent = null;
		PuddingNPC.GGFJGHHHEJC.content.SetActive(false);
		((Component)PuddingNPC.GGFJGHHHEJC).transform.parent = null;
		OrwinIINPC.GGFJGHHHEJC.content.SetActive(false);
		TweekNPC.GGFJGHHHEJC.content.SetActive(false);
		((Component)TweekNPC.GGFJGHHHEJC).transform.parent = null;
		KyrohNPC.GGFJGHHHEJC.content.SetActive(false);
		KyrohWaterfallEvent.instance.ActivateEvent();
		((MonoBehaviour)this).StopAllCoroutines();
	}

	public override void StartEvent(bool BFLCJPHHDJM, bool CDPAMNIPPEC)
	{
		base.StartEvent(BFLCJPHHDJM, CDPAMNIPPEC);
		((Behaviour)trigger).enabled = false;
		if (GameManager.LocalCoop())
		{
			PrepareLocalCoop(Location.Castle);
		}
		else if (!Utils.AHMPFOEGJHF(Location.Castle))
		{
			TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Castle, Location.CastleGarden);
			travelZone.OnTravelZoneTo = (Action<int>)Delegate.Combine(travelZone.OnTravelZoneTo, new Action<int>(EAPLAJLIHBO));
			return;
		}
		((MonoBehaviour)instance).StartCoroutine(instance.FPMDBKJPEFA());
	}

	private void OnTriggerEnter2D(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("Player") || ((Component)HANHCHBHHEH).CompareTag("Player2"))
		{
			CJODOOFLLLB = ((!((Component)HANHCHBHHEH).CompareTag("Player2")) ? 1 : 2);
			StartEvent(BFLCJPHHDJM: true, CDPAMNIPPEC: true);
		}
	}

	public void SetKlayn()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		KlaynNPC.instance.ChangeState(KlaynState.Wait);
		((Component)KlaynNPC.instance).transform.position = positions[6].position;
		KlaynNPC.instance.content.SetActive(true);
		KlaynNPC.instance.animationBase.SetBool("Sit", EGFGNGJGBOP: true, HALNIEBONKH: true);
		KlaynNPC.instance.animationBase.LookDirection(Direction.Left);
	}

	public void HAEPDOGOKFD()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		KlaynNPC.instance.LIOJBOLAGNG(KlaynState.ServingCustomer);
		((Component)KlaynNPC.instance).transform.position = positions[3].position;
		KlaynNPC.instance.content.SetActive(true);
		KlaynNPC.instance.animationBase.SetBool("Seedy", EGFGNGJGBOP: true);
		KlaynNPC.instance.animationBase.LookDirection(Direction.Diagonal);
	}

	private void FJKKLJHHMLC(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("SprintHoldAction") || ((Component)HANHCHBHHEH).CompareTag("Tray"))
		{
			CJODOOFLLLB = ((!((Component)HANHCHBHHEH).CompareTag("VERSION")) ? 1 : 5);
			StartEvent(BFLCJPHHDJM: true, CDPAMNIPPEC: false);
		}
	}

	private void NDFEMHNLKCE(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("add item ") || ((Component)HANHCHBHHEH).CompareTag("cameraZoom2"))
		{
			CJODOOFLLLB = (((Component)HANHCHBHHEH).CompareTag("TimeLeft") ? 2 : 0);
			StartEvent(BFLCJPHHDJM: false, CDPAMNIPPEC: true);
		}
	}

	private void KICCNEPCCFB(Collider2D HANHCHBHHEH)
	{
		if (((Component)HANHCHBHHEH).CompareTag("<sprite name=\"") || ((Component)HANHCHBHHEH).CompareTag("Cancel"))
		{
			CJODOOFLLLB = (((Component)HANHCHBHHEH).CompareTag(" ") ? 3 : 0);
			StartEvent(BFLCJPHHDJM: false, CDPAMNIPPEC: false);
		}
	}

	private void MEODKIBGNHI(int AAAIOBLCOFO)
	{
		StartEvent(BFLCJPHHDJM: false, CDPAMNIPPEC: true);
	}

	public void JFMGPGBGIOF()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		KlaynNPC.instance.GPBKHBEHIAC(KlaynState.WalkTo);
		((Component)KlaynNPC.instance).transform.position = positions[6].position;
		KlaynNPC.instance.content.SetActive(true);
		KlaynNPC.instance.animationBase.CGEADHOLHCH("Could not assign file ", EGFGNGJGBOP: false);
		KlaynNPC.instance.animationBase.LookDirection(Direction.Diagonal);
	}

	public override void ActivateEvent()
	{
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		base.ActivateEvent();
		((Behaviour)trigger).enabled = true;
		HawksNPC.GGFJGHHHEJC.content.SetActive(false);
		door.inputEnabled = true;
		if (OnlineManager.MasterOrOffline())
		{
			KlaynNPC.instance.content.SetActive(false);
		}
		((Component)LucenNPC.GGFJGHHHEJC).transform.position = positions[0].position;
		LucenNPC.GGFJGHHHEJC.content.SetActive(true);
		LucenNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Down);
		((Component)OrwinIINPC.GGFJGHHHEJC).transform.position = positions[1].position;
		OrwinIINPC.GGFJGHHHEJC.content.SetActive(true);
		OrwinIINPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Left);
		((Component)PuddingNPC.GGFJGHHHEJC).transform.position = positions[2].position;
		((Component)PuddingNPC.GGFJGHHHEJC).transform.parent = chairs[0].transform;
		PuddingNPC.GGFJGHHHEJC.content.SetActive(true);
		PuddingNPC.GGFJGHHHEJC.animationBase.SetBool("Sit", EGFGNGJGBOP: true, HALNIEBONKH: true);
		PuddingNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Left);
		((Component)OxNPC.GGFJGHHHEJC).transform.position = positions[3].position;
		((Component)OxNPC.GGFJGHHHEJC).transform.parent = chairs[1].transform;
		OxNPC.GGFJGHHHEJC.content.SetActive(true);
		OxNPC.GGFJGHHHEJC.animationBase.SetBool("Sit", EGFGNGJGBOP: true, HALNIEBONKH: true);
		((Component)RibellaNPC.GGFJGHHHEJC).transform.position = positions[4].position;
		((Component)RibellaNPC.GGFJGHHHEJC).transform.parent = chairs[2].transform;
		RibellaNPC.GGFJGHHHEJC.content.SetActive(true);
		RibellaNPC.GGFJGHHHEJC.animationBase.SetBool("Sit", EGFGNGJGBOP: true, HALNIEBONKH: true);
		((Component)TweekNPC.GGFJGHHHEJC).transform.position = positions[5].position;
		((Component)TweekNPC.GGFJGHHHEJC).transform.parent = chairs[3].transform;
		TweekNPC.GGFJGHHHEJC.content.SetActive(true);
		TweekNPC.GGFJGHHHEJC.animationBase.SetBool("Sit", EGFGNGJGBOP: true, HALNIEBONKH: true);
		TweekNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Left);
		KlaynNPC.instance.ChangeState(KlaynState.Wait);
		((Component)KlaynNPC.instance).transform.position = positions[6].position;
		KlaynNPC.instance.content.SetActive(true);
		KlaynNPC.instance.animationBase.SetBool("Sit", EGFGNGJGBOP: true, HALNIEBONKH: true);
		KlaynNPC.instance.animationBase.LookDirection(Direction.Left);
		KyrohNPC.GGFJGHHHEJC.ChangeState(KyrohState.Idle);
		((Component)KyrohNPC.GGFJGHHHEJC).transform.position = positions[7].position;
		((Component)KyrohNPC.GGFJGHHHEJC).transform.parent = chairs[4].transform;
		KyrohNPC.GGFJGHHHEJC.content.SetActive(true);
		KyrohNPC.GGFJGHHHEJC.animationBase.SetBool("Sit", EGFGNGJGBOP: true, HALNIEBONKH: true);
	}

	public override GameEvent GetInstance()
	{
		return instance;
	}

	private IEnumerator KDLEMGNJPKL()
	{
		TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Castle, Location.CastleGarden);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(EAPLAJLIHBO));
		PlayerInputs.DisableKeyboardInputsAndMovement(CJODOOFLLLB, (MonoBehaviour)(object)instance);
		DialogueCameraTarget.GetPlayer(CJODOOFLLLB).cameraInEvent = true;
		DialogueCameraTarget.GetPlayer(CJODOOFLLLB).MoveCameraToPositionFromCameraTarget(Vector2.op_Implicit(cameraPosition.position));
		yield return CommonReferences.wait3;
		EDGDFPPKGDL = OxNPC.GGFJGHHHEJC;
		MDFALJKHKED = "SalonDelTrono/MainEvent";
		OxNPC.GGFJGHHHEJC.inSpecialEvent = true;
		if (isActor)
		{
			Debug.Log((object)"StartConversation SalonDelTrono");
			OxNPC.GGFJGHHHEJC.barkDialogue = false;
			OxNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "SalonDelTrono/MainEvent");
		}
		else if (OnlineManager.PlayingOnline())
		{
			Debug.Log((object)"StartObserver SalonDelTrono");
			yield return OxNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private void KHPMJKPEOOE(int AAAIOBLCOFO)
	{
		StartEvent(BFLCJPHHDJM: false, CDPAMNIPPEC: true);
	}

	private void KDMFODOLBIC(int AAAIOBLCOFO)
	{
		StartEvent(BFLCJPHHDJM: true, CDPAMNIPPEC: true);
	}

	[CompilerGenerated]
	[DebuggerHidden]
	private void LLIJGOCKPBB(bool BGKCHMNJBLJ)
	{
		base.EndEvent(BGKCHMNJBLJ);
	}

	private IEnumerator FPMDBKJPEFA()
	{
		TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Castle, Location.CastleGarden);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(EAPLAJLIHBO));
		PlayerInputs.DisableKeyboardInputsAndMovement(CJODOOFLLLB, (MonoBehaviour)(object)instance);
		DialogueCameraTarget.GetPlayer(CJODOOFLLLB).cameraInEvent = true;
		DialogueCameraTarget.GetPlayer(CJODOOFLLLB).MoveCameraToPositionFromCameraTarget(Vector2.op_Implicit(cameraPosition.position));
		yield return CommonReferences.wait3;
		EDGDFPPKGDL = OxNPC.GGFJGHHHEJC;
		MDFALJKHKED = "SalonDelTrono/MainEvent";
		OxNPC.GGFJGHHHEJC.inSpecialEvent = true;
		if (isActor)
		{
			Debug.Log((object)"StartConversation SalonDelTrono");
			OxNPC.GGFJGHHHEJC.barkDialogue = false;
			OxNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "SalonDelTrono/MainEvent");
		}
		else if (OnlineManager.PlayingOnline())
		{
			Debug.Log((object)"StartObserver SalonDelTrono");
			yield return OxNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}
}
