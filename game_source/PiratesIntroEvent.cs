using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class PiratesIntroEvent : GameEvent
{
	private enum LOGEKNJJJOB
	{
		Throw
	}

	[CompilerGenerated]
	private sealed class HIGBKBENDAH : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PiratesIntroEvent _003C_003E4__this;

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
		public HIGBKBENDAH(int _003C_003E1__state)
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
			PiratesIntroEvent @object = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
			{
				_003C_003E1__state = -1;
				TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.PirateShip, Location.PirateCave);
				travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(@object.ACKDEEIAMEH));
				BrookDWittNPC.GGFJGHHHEJC.animationBase.SetBool("Angry", EGFGNGJGBOP: false);
				PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
				if (Utils.AHMPFOEGJHF(Location.PirateShip))
				{
					GameActionBarUI.Get(1).OpenUI();
				}
				if (GameManager.LocalCoop() && Utils.AHMPFOEGJHF(Location.PirateShip, 2))
				{
					GameActionBarUI.Get(2).OpenUI();
				}
				break;
			}
			case 1:
				_003C_003E1__state = -1;
				break;
			}
			if (Utils.NGLLIJPOBEC(Location.PirateShip))
			{
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			}
			if (OnlineManager.MasterOrOffline())
			{
				((Behaviour)ChumNPC.GGFJGHHHEJC.routine).enabled = true;
				ChumNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
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
	private sealed class NKFCBFCJOED : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PiratesIntroEvent _003C_003E4__this;

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
		public NKFCBFCJOED(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			PiratesIntroEvent piratesIntroEvent = _003C_003E4__this;
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
				Result variable = DialogueLua.GetVariable("BrookProgress");
				if (((Result)(ref variable)).asInt == 0 && !EventsManager.IsDone(EventsManager.EventType.PiratesIntro) && !EventsManager.IsActive(EventsManager.EventType.PiratesIntro))
				{
					piratesIntroEvent.ActivateEvent();
				}
				GameManager instance = GameManager.GGFJGHHHEJC;
				instance.OnWorldLoaded = (Action)Delegate.Remove(instance.OnWorldLoaded, new Action(piratesIntroEvent.BGPGIOMKKAO));
				return false;
			}
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
	private sealed class GIJINOFHMOI : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PiratesIntroEvent _003C_003E4__this;

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
		public GIJINOFHMOI(int _003C_003E1__state)
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
			PiratesIntroEvent piratesIntroEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				piratesIntroEvent.EDGDFPPKGDL = BrookDWittNPC.GGFJGHHHEJC;
				piratesIntroEvent.MDFALJKHKED = "Pirates/Brook/Intro";
				piratesIntroEvent.actorNumber = 1;
				BrookDWittNPC.GGFJGHHHEJC.barkDialogue = false;
				BrookDWittNPC.GGFJGHHHEJC.inSpecialEvent = true;
				BrookDWittNPC.GGFJGHHHEJC.blockActionBar = true;
				Debug.Log((object)"Starting Pirates Intro Event");
				if (instance.isActor)
				{
					BrookDWittNPC.GGFJGHHHEJC.StartConversation(piratesIntroEvent.CJODOOFLLLB, "Pirates/Brook/Intro");
				}
				else if (Utils.AHMPFOEGJHF(Location.PirateShip))
				{
					_003C_003E2__current = BrookDWittNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
					_003C_003E1__state = 1;
					return true;
				}
				break;
			case 1:
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
	private sealed class EOPEMHDOLDK : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PiratesIntroEvent _003C_003E4__this;

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
		public EOPEMHDOLDK(int _003C_003E1__state)
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
			PiratesIntroEvent piratesIntroEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				BrookDWittNPC.GGFJGHHHEJC.animationBase.SetTrigger("Throw");
				_003C_003E2__current = CommonReferences.wait1_5;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				BrookDWittNPC.GGFJGHHHEJC.inSpecialEvent = false;
				BrookDWittNPC.GGFJGHHHEJC.blockActionBar = false;
				if (instance.isActor)
				{
					BrookDWittNPC.GGFJGHHHEJC.StartConversation(piratesIntroEvent.CJODOOFLLLB, "Pirates/Brook/Intro2");
				}
				else if (Utils.AHMPFOEGJHF(Location.PirateShip))
				{
					_003C_003E2__current = BrookDWittNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
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

	public static PiratesIntroEvent instance;

	public Transform chumPosition;

	public void LGNEHKHMABG(int AAAIOBLCOFO)
	{
		if (!ChallengesUI.AnyMinigameInProgress)
		{
			CJODOOFLLLB = AAAIOBLCOFO;
			StartEvent(BFLCJPHHDJM: true, CDPAMNIPPEC: false);
		}
	}

	private IEnumerator CIJFOPNABGB()
	{
		return new HIGBKBENDAH(1)
		{
			_003C_003E4__this = this
		};
	}

	private void GMLFGAKIEAD()
	{
		((MonoBehaviour)this).StartCoroutine(EELINDAIHKD());
	}

	private void NDNBDEHFFJF()
	{
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(CNCKFABKNOF));
	}

	public override GameEvent GetInstance()
	{
		return instance;
	}

	private void EBKPPHGMAEL(int AAAIOBLCOFO)
	{
		StartEvent(BFLCJPHHDJM: false, CDPAMNIPPEC: true);
		TravelZone travelZone = TravelZonesManager.EKDNJDJHONF().ECFDFECLDFK(Location.Tavern | Location.River, Location.Tavern | Location.Road | Location.River | Location.Camp | Location.Farm);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(MHPAHDAPBPM));
	}

	private void MHPAHDAPBPM(int AAAIOBLCOFO)
	{
		StartEvent(BFLCJPHHDJM: true, CDPAMNIPPEC: false);
		TravelZone travelZone = TravelZonesManager.GFMBEDCANNI().OFIPCMMKFLP(Location.Tavern | Location.River | Location.Quarry | Location.BarnInterior, ~(Location.Quarry | Location.BarnInterior));
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(EMCHCGFMGCL));
	}

	private IEnumerator BDHDLMAJILA()
	{
		return new HIGBKBENDAH(1)
		{
			_003C_003E4__this = this
		};
	}

	public void FDDICCOICLN()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.PIENDCFAEND());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
	}

	private IEnumerator MMHNAPKOJJC()
	{
		yield return CommonReferences.wait1;
		Result variable = DialogueLua.GetVariable("BrookProgress");
		if (((Result)(ref variable)).asInt == 0 && !EventsManager.IsDone(EventsManager.EventType.PiratesIntro) && !EventsManager.IsActive(EventsManager.EventType.PiratesIntro))
		{
			ActivateEvent();
		}
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
	}

	private void GDBOOAEIMFP()
	{
		((MonoBehaviour)this).StartCoroutine(PLDCPDAEJJM());
	}

	public override void ActivateEvent()
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		base.ActivateEvent();
		if (OnlineManager.MasterOrOffline())
		{
			ChumNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
			((Behaviour)ChumNPC.GGFJGHHHEJC.routine).enabled = false;
		}
		ChumNPC.GGFJGHHHEJC.content.SetActive(true);
		((Component)ChumNPC.GGFJGHHHEJC).transform.position = chumPosition.position;
		ChumNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
		BrookDWittNPC.GGFJGHHHEJC.content.SetActive(true);
		BrookDWittNPC.GGFJGHHHEJC.animationBase.SetBool("Angry", EGFGNGJGBOP: true, HALNIEBONKH: true);
		TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.PirateShip, Location.PirateCave);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Combine(travelZone.OnTravelZoneTo, new Action<int>(OnTravelZone));
	}

	private void KNABGIGNPAM()
	{
		((MonoBehaviour)this).StartCoroutine(HBMEBCCEGOL());
	}

	private IEnumerator BFNAMNMMBOG()
	{
		return new GIJINOFHMOI(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator INAPBOMOEBE()
	{
		TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.PirateShip, Location.PirateCave);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(ACKDEEIAMEH));
		BrookDWittNPC.GGFJGHHHEJC.animationBase.SetBool("Angry", EGFGNGJGBOP: false);
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		if (Utils.AHMPFOEGJHF(Location.PirateShip))
		{
			GameActionBarUI.Get(1).OpenUI();
		}
		if (GameManager.LocalCoop() && Utils.AHMPFOEGJHF(Location.PirateShip, 2))
		{
			GameActionBarUI.Get(2).OpenUI();
		}
		while (Utils.NGLLIJPOBEC(Location.PirateShip))
		{
			yield return null;
		}
		if (OnlineManager.MasterOrOffline())
		{
			((Behaviour)ChumNPC.GGFJGHHHEJC.routine).enabled = true;
			ChumNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
		}
	}

	private IEnumerator AKMAILIIGOH()
	{
		return new NKFCBFCJOED(1)
		{
			_003C_003E4__this = this
		};
	}

	private void Start()
	{
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
	}

	private IEnumerator NEBHONKAONI()
	{
		BrookDWittNPC.GGFJGHHHEJC.animationBase.SetTrigger("Throw");
		yield return CommonReferences.wait1_5;
		BrookDWittNPC.GGFJGHHHEJC.inSpecialEvent = false;
		BrookDWittNPC.GGFJGHHHEJC.blockActionBar = false;
		if (instance.isActor)
		{
			BrookDWittNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "Pirates/Brook/Intro2");
		}
		else if (Utils.AHMPFOEGJHF(Location.PirateShip))
		{
			yield return BrookDWittNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private IEnumerator EEIDFGNBNGN()
	{
		return new EOPEMHDOLDK(1)
		{
			_003C_003E4__this = this
		};
	}

	public void PMKDCLKPFOC()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.LHNCPEABKLO());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
	}

	private void PDLHJLCIJFF()
	{
		((MonoBehaviour)this).StartCoroutine(HBMEBCCEGOL());
	}

	private IEnumerator PEJDEMKBHEK()
	{
		BrookDWittNPC.GGFJGHHHEJC.animationBase.SetTrigger("Throw");
		yield return CommonReferences.wait1_5;
		BrookDWittNPC.GGFJGHHHEJC.inSpecialEvent = false;
		BrookDWittNPC.GGFJGHHHEJC.blockActionBar = false;
		if (instance.isActor)
		{
			BrookDWittNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "Pirates/Brook/Intro2");
		}
		else if (Utils.AHMPFOEGJHF(Location.PirateShip))
		{
			yield return BrookDWittNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private void EGPONANBCNP()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(CNCKFABKNOF));
	}

	private void IBJDMJBFMIO()
	{
		((MonoBehaviour)this).StartCoroutine(HBMEBCCEGOL());
	}

	private void LBPGLJOGDMK()
	{
		((MonoBehaviour)this).StartCoroutine(HBMEBCCEGOL());
	}

	public void BBKDAIACGLJ()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.KGELHEOJBBI());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
	}

	private IEnumerator IIGNGCLCKMA()
	{
		yield return CommonReferences.wait1;
		Result variable = DialogueLua.GetVariable("BrookProgress");
		if (((Result)(ref variable)).asInt == 0 && !EventsManager.IsDone(EventsManager.EventType.PiratesIntro) && !EventsManager.IsActive(EventsManager.EventType.PiratesIntro))
		{
			ActivateEvent();
		}
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
	}

	private IEnumerator DBEFDDFCODN()
	{
		BrookDWittNPC.GGFJGHHHEJC.animationBase.SetTrigger("Throw");
		yield return CommonReferences.wait1_5;
		BrookDWittNPC.GGFJGHHHEJC.inSpecialEvent = false;
		BrookDWittNPC.GGFJGHHHEJC.blockActionBar = false;
		if (instance.isActor)
		{
			BrookDWittNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "Pirates/Brook/Intro2");
		}
		else if (Utils.AHMPFOEGJHF(Location.PirateShip))
		{
			yield return BrookDWittNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	public void LPEMMADBACG(int AAAIOBLCOFO)
	{
		if (!ChallengesUI.AnyMinigameInProgress)
		{
			CJODOOFLLLB = AAAIOBLCOFO;
			StartEvent(BFLCJPHHDJM: false, CDPAMNIPPEC: true);
		}
	}

	public void OMIIBDOAKPC(int AAAIOBLCOFO)
	{
		if (!ChallengesUI.AnyMinigameInProgress)
		{
			CJODOOFLLLB = AAAIOBLCOFO;
			StartEvent(BFLCJPHHDJM: true, CDPAMNIPPEC: true);
		}
	}

	private IEnumerator OPPFGDILELM()
	{
		TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.PirateShip, Location.PirateCave);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(ACKDEEIAMEH));
		BrookDWittNPC.GGFJGHHHEJC.animationBase.SetBool("Angry", EGFGNGJGBOP: false);
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		if (Utils.AHMPFOEGJHF(Location.PirateShip))
		{
			GameActionBarUI.Get(1).OpenUI();
		}
		if (GameManager.LocalCoop() && Utils.AHMPFOEGJHF(Location.PirateShip, 2))
		{
			GameActionBarUI.Get(2).OpenUI();
		}
		while (Utils.NGLLIJPOBEC(Location.PirateShip))
		{
			yield return null;
		}
		if (OnlineManager.MasterOrOffline())
		{
			((Behaviour)ChumNPC.GGFJGHHHEJC.routine).enabled = true;
			ChumNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
		}
	}

	private IEnumerator PLDCPDAEJJM()
	{
		yield return CommonReferences.wait1;
		Result variable = DialogueLua.GetVariable("BrookProgress");
		if (((Result)(ref variable)).asInt == 0 && !EventsManager.IsDone(EventsManager.EventType.PiratesIntro) && !EventsManager.IsActive(EventsManager.EventType.PiratesIntro))
		{
			ActivateEvent();
		}
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
	}

	private IEnumerator ACJCOEBMHNA()
	{
		yield return CommonReferences.wait1;
		Result variable = DialogueLua.GetVariable("BrookProgress");
		if (((Result)(ref variable)).asInt == 0 && !EventsManager.IsDone(EventsManager.EventType.PiratesIntro) && !EventsManager.IsActive(EventsManager.EventType.PiratesIntro))
		{
			ActivateEvent();
		}
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
	}

	private void NEJABGEEFJF()
	{
		((MonoBehaviour)this).StartCoroutine(GHIPLILIBNA());
	}

	private void ACKDEEIAMEH(int AAAIOBLCOFO)
	{
		StartEvent(BFLCJPHHDJM: false, CDPAMNIPPEC: false);
		TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.PirateShip, Location.PirateCave);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(ACKDEEIAMEH));
	}

	private IEnumerator LEDKIGHJMPO()
	{
		return new HIGBKBENDAH(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NICLDHAAHMB()
	{
		TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.PirateShip, Location.PirateCave);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(ACKDEEIAMEH));
		BrookDWittNPC.GGFJGHHHEJC.animationBase.SetBool("Angry", EGFGNGJGBOP: false);
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		if (Utils.AHMPFOEGJHF(Location.PirateShip))
		{
			GameActionBarUI.Get(1).OpenUI();
		}
		if (GameManager.LocalCoop() && Utils.AHMPFOEGJHF(Location.PirateShip, 2))
		{
			GameActionBarUI.Get(2).OpenUI();
		}
		while (Utils.NGLLIJPOBEC(Location.PirateShip))
		{
			yield return null;
		}
		if (OnlineManager.MasterOrOffline())
		{
			((Behaviour)ChumNPC.GGFJGHHHEJC.routine).enabled = true;
			ChumNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
		}
	}

	private IEnumerator GHFHEDIHFHA()
	{
		return new GIJINOFHMOI(1)
		{
			_003C_003E4__this = this
		};
	}

	private void KEFNELHKFJD(int AAAIOBLCOFO)
	{
		StartEvent(BFLCJPHHDJM: true, CDPAMNIPPEC: false);
		TravelZone travelZone = TravelZonesManager.LKOABOAADCD().NKEBECDKDOO(~(Location.Tavern | Location.River | Location.Camp | Location.Farm | Location.FarmShop), Location.Tavern | Location.River | Location.Quarry | Location.Farm | Location.BarnInterior);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(EMCHCGFMGCL));
	}

	private void HKKDEKIFPPJ()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(GMLFGAKIEAD));
	}

	public void GEPMPNGCJBK(int AAAIOBLCOFO)
	{
		if (!ChallengesUI.AnyMinigameInProgress)
		{
			CJODOOFLLLB = AAAIOBLCOFO;
			StartEvent(BFLCJPHHDJM: false, CDPAMNIPPEC: false);
		}
	}

	private IEnumerator AJLCFLFFBGF()
	{
		yield return CommonReferences.wait1;
		Result variable = DialogueLua.GetVariable("BrookProgress");
		if (((Result)(ref variable)).asInt == 0 && !EventsManager.IsDone(EventsManager.EventType.PiratesIntro) && !EventsManager.IsActive(EventsManager.EventType.PiratesIntro))
		{
			ActivateEvent();
		}
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
	}

	private IEnumerator ALDGGPPIMFP()
	{
		return new HIGBKBENDAH(1)
		{
			_003C_003E4__this = this
		};
	}

	private void HKGDHOALFBN(int AAAIOBLCOFO)
	{
		StartEvent(BFLCJPHHDJM: false, CDPAMNIPPEC: false);
		TravelZone travelZone = TravelZonesManager.OLHBLKIAFOM().KCJMDAPPJLB(Location.Tavern | Location.River | Location.Quarry | Location.FarmShop, ~(Location.River | Location.Camp | Location.Quarry | Location.Farm | Location.BarnInterior));
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(KEFNELHKFJD));
	}

	public void OPENPKIELLH(int AAAIOBLCOFO)
	{
		if (!ChallengesUI.AnyMinigameInProgress)
		{
			CJODOOFLLLB = AAAIOBLCOFO;
			StartEvent(BFLCJPHHDJM: true, CDPAMNIPPEC: false);
		}
	}

	public override void StartEvent(bool BFLCJPHHDJM, bool CDPAMNIPPEC)
	{
		base.StartEvent(BFLCJPHHDJM, CDPAMNIPPEC);
		TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.PirateShip, Location.PirateCave);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(OnTravelZone));
		if (GameManager.LocalCoop())
		{
			PrepareLocalCoop(Location.PirateShip);
		}
		if (!Utils.AHMPFOEGJHF(Location.PirateShip) && !isActor)
		{
			TravelZone travelZone2 = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.PirateShip, Location.PirateCave);
			travelZone2.OnTravelZoneTo = (Action<int>)Delegate.Combine(travelZone2.OnTravelZoneTo, new Action<int>(ACKDEEIAMEH));
			return;
		}
		if (Utils.AHMPFOEGJHF(Location.PirateShip))
		{
			PlayerInputs.DisableKeyboardInputsAndMovement(1, (MonoBehaviour)(object)instance);
		}
		((MonoBehaviour)this).StartCoroutine(instance.EFOONHMKJEB());
	}

	public void FJDFKMDGBCG(int AAAIOBLCOFO)
	{
		if (!ChallengesUI.AnyMinigameInProgress)
		{
			CJODOOFLLLB = AAAIOBLCOFO;
			StartEvent(BFLCJPHHDJM: false, CDPAMNIPPEC: true);
		}
	}

	private void EMCHCGFMGCL(int AAAIOBLCOFO)
	{
		StartEvent(BFLCJPHHDJM: false, CDPAMNIPPEC: false);
		TravelZone travelZone = TravelZonesManager.DGCNCEDIFOF().KCJMDAPPJLB(~(Location.Tavern | Location.River | Location.Camp | Location.Quarry | Location.Farm), Location.Tavern | Location.Quarry | Location.Farm);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(KEFNELHKFJD));
	}

	private IEnumerator NHGJHENLCJA()
	{
		return new NKFCBFCJOED(1)
		{
			_003C_003E4__this = this
		};
	}

	private void CFIIEJDJFPB()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(KNABGIGNPAM));
	}

	private IEnumerator MELKOLJHEFP()
	{
		yield return CommonReferences.wait1;
		Result variable = DialogueLua.GetVariable("BrookProgress");
		if (((Result)(ref variable)).asInt == 0 && !EventsManager.IsDone(EventsManager.EventType.PiratesIntro) && !EventsManager.IsActive(EventsManager.EventType.PiratesIntro))
		{
			ActivateEvent();
		}
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
	}

	private IEnumerator PIENDCFAEND()
	{
		return new EOPEMHDOLDK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator EFOONHMKJEB()
	{
		EDGDFPPKGDL = BrookDWittNPC.GGFJGHHHEJC;
		MDFALJKHKED = "Pirates/Brook/Intro";
		actorNumber = 1;
		BrookDWittNPC.GGFJGHHHEJC.barkDialogue = false;
		BrookDWittNPC.GGFJGHHHEJC.inSpecialEvent = true;
		BrookDWittNPC.GGFJGHHHEJC.blockActionBar = true;
		Debug.Log((object)"Starting Pirates Intro Event");
		if (instance.isActor)
		{
			BrookDWittNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "Pirates/Brook/Intro");
		}
		else if (Utils.AHMPFOEGJHF(Location.PirateShip))
		{
			yield return BrookDWittNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private IEnumerator BMJLKKGKBCL()
	{
		EDGDFPPKGDL = BrookDWittNPC.GGFJGHHHEJC;
		MDFALJKHKED = "Pirates/Brook/Intro";
		actorNumber = 1;
		BrookDWittNPC.GGFJGHHHEJC.barkDialogue = false;
		BrookDWittNPC.GGFJGHHHEJC.inSpecialEvent = true;
		BrookDWittNPC.GGFJGHHHEJC.blockActionBar = true;
		Debug.Log((object)"Starting Pirates Intro Event");
		if (instance.isActor)
		{
			BrookDWittNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "Pirates/Brook/Intro");
		}
		else if (Utils.AHMPFOEGJHF(Location.PirateShip))
		{
			yield return BrookDWittNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private IEnumerator KGELHEOJBBI()
	{
		BrookDWittNPC.GGFJGHHHEJC.animationBase.SetTrigger("Throw");
		yield return CommonReferences.wait1_5;
		BrookDWittNPC.GGFJGHHHEJC.inSpecialEvent = false;
		BrookDWittNPC.GGFJGHHHEJC.blockActionBar = false;
		if (instance.isActor)
		{
			BrookDWittNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "Pirates/Brook/Intro2");
		}
		else if (Utils.AHMPFOEGJHF(Location.PirateShip))
		{
			yield return BrookDWittNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	public void JNCFCBOKFGI(int AAAIOBLCOFO)
	{
		if (!ChallengesUI.AnyMinigameInProgress)
		{
			CJODOOFLLLB = AAAIOBLCOFO;
			StartEvent(BFLCJPHHDJM: false, CDPAMNIPPEC: false);
		}
	}

	private void BGPGIOMKKAO()
	{
		((MonoBehaviour)this).StartCoroutine(MMHNAPKOJJC());
	}

	private void OKAPGNGLOHO()
	{
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(IBJDMJBFMIO));
	}

	private void BJHFPGAEDFM()
	{
		((MonoBehaviour)this).StartCoroutine(KEMAGLJCAHL());
	}

	protected override void Awake()
	{
		base.Awake();
		instance = this;
	}

	public void CDBBHAMDPFL()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.ONONIOHDOPJ());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
	}

	private IEnumerator OLPADKCEBGM()
	{
		return new HIGBKBENDAH(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator GHHKNJLKKDK()
	{
		EDGDFPPKGDL = BrookDWittNPC.GGFJGHHHEJC;
		MDFALJKHKED = "Pirates/Brook/Intro";
		actorNumber = 1;
		BrookDWittNPC.GGFJGHHHEJC.barkDialogue = false;
		BrookDWittNPC.GGFJGHHHEJC.inSpecialEvent = true;
		BrookDWittNPC.GGFJGHHHEJC.blockActionBar = true;
		Debug.Log((object)"Starting Pirates Intro Event");
		if (instance.isActor)
		{
			BrookDWittNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "Pirates/Brook/Intro");
		}
		else if (Utils.AHMPFOEGJHF(Location.PirateShip))
		{
			yield return BrookDWittNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private IEnumerator LHNCPEABKLO()
	{
		return new EOPEMHDOLDK(1)
		{
			_003C_003E4__this = this
		};
	}

	private void ODNGBEOKEFK()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(CNCKFABKNOF));
	}

	public void ThrowEvent()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.ODAHFGDKLCI());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
	}

	public void BHOMKPDMGOL(int AAAIOBLCOFO)
	{
		if (!ChallengesUI.AnyMinigameInProgress)
		{
			CJODOOFLLLB = AAAIOBLCOFO;
			StartEvent(BFLCJPHHDJM: true, CDPAMNIPPEC: true);
		}
	}

	private void IGIKNCOLCKL()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(NEJABGEEFJF));
	}

	public void PNBIKMNFEAN(int AAAIOBLCOFO)
	{
		if (!ChallengesUI.AnyMinigameInProgress)
		{
			CJODOOFLLLB = AAAIOBLCOFO;
			StartEvent(BFLCJPHHDJM: true, CDPAMNIPPEC: true);
		}
	}

	public void OnTravelZone(int AAAIOBLCOFO)
	{
		if (!ChallengesUI.AnyMinigameInProgress)
		{
			CJODOOFLLLB = AAAIOBLCOFO;
			StartEvent(BFLCJPHHDJM: true, CDPAMNIPPEC: true);
		}
	}

	private void NDGFPPOBCNP()
	{
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(CBHLNKHLDBG));
	}

	private IEnumerator EELINDAIHKD()
	{
		return new NKFCBFCJOED(1)
		{
			_003C_003E4__this = this
		};
	}

	private void NHPONJBGMAE(int AAAIOBLCOFO)
	{
		StartEvent(BFLCJPHHDJM: true, CDPAMNIPPEC: true);
		TravelZone travelZone = TravelZonesManager.OACNNJCLEDE().GetTravelZone(Location.Tavern | Location.Road, ~(Location.Tavern | Location.Road | Location.Camp | Location.BarnInterior));
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(EMCHCGFMGCL));
	}

	public void ADCHFCGAJLI(int AAAIOBLCOFO)
	{
		if (!ChallengesUI.AnyMinigameInProgress)
		{
			CJODOOFLLLB = AAAIOBLCOFO;
			StartEvent(BFLCJPHHDJM: false, CDPAMNIPPEC: false);
		}
	}

	private IEnumerator OECAEJINCGH()
	{
		EDGDFPPKGDL = BrookDWittNPC.GGFJGHHHEJC;
		MDFALJKHKED = "Pirates/Brook/Intro";
		actorNumber = 1;
		BrookDWittNPC.GGFJGHHHEJC.barkDialogue = false;
		BrookDWittNPC.GGFJGHHHEJC.inSpecialEvent = true;
		BrookDWittNPC.GGFJGHHHEJC.blockActionBar = true;
		Debug.Log((object)"Starting Pirates Intro Event");
		if (instance.isActor)
		{
			BrookDWittNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "Pirates/Brook/Intro");
		}
		else if (Utils.AHMPFOEGJHF(Location.PirateShip))
		{
			yield return BrookDWittNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private IEnumerator ONONIOHDOPJ()
	{
		BrookDWittNPC.GGFJGHHHEJC.animationBase.SetTrigger("Throw");
		yield return CommonReferences.wait1_5;
		BrookDWittNPC.GGFJGHHHEJC.inSpecialEvent = false;
		BrookDWittNPC.GGFJGHHHEJC.blockActionBar = false;
		if (instance.isActor)
		{
			BrookDWittNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "Pirates/Brook/Intro2");
		}
		else if (Utils.AHMPFOEGJHF(Location.PirateShip))
		{
			yield return BrookDWittNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private IEnumerator JIFJLCMNMEA()
	{
		return new HIGBKBENDAH(1)
		{
			_003C_003E4__this = this
		};
	}

	public void BAJPIMEEFPL(int AAAIOBLCOFO)
	{
		if (!ChallengesUI.AnyMinigameInProgress)
		{
			CJODOOFLLLB = AAAIOBLCOFO;
			StartEvent(BFLCJPHHDJM: false, CDPAMNIPPEC: true);
		}
	}

	public void LBGFCEKHEAL(int AAAIOBLCOFO)
	{
		if (!ChallengesUI.AnyMinigameInProgress)
		{
			CJODOOFLLLB = AAAIOBLCOFO;
			StartEvent(BFLCJPHHDJM: false, CDPAMNIPPEC: true);
		}
	}

	private IEnumerator GHIPLILIBNA()
	{
		yield return CommonReferences.wait1;
		Result variable = DialogueLua.GetVariable("BrookProgress");
		if (((Result)(ref variable)).asInt == 0 && !EventsManager.IsDone(EventsManager.EventType.PiratesIntro) && !EventsManager.IsActive(EventsManager.EventType.PiratesIntro))
		{
			ActivateEvent();
		}
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
	}

	private IEnumerator ACIGPFJIFKO()
	{
		EDGDFPPKGDL = BrookDWittNPC.GGFJGHHHEJC;
		MDFALJKHKED = "Pirates/Brook/Intro";
		actorNumber = 1;
		BrookDWittNPC.GGFJGHHHEJC.barkDialogue = false;
		BrookDWittNPC.GGFJGHHHEJC.inSpecialEvent = true;
		BrookDWittNPC.GGFJGHHHEJC.blockActionBar = true;
		Debug.Log((object)"Starting Pirates Intro Event");
		if (instance.isActor)
		{
			BrookDWittNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "Pirates/Brook/Intro");
		}
		else if (Utils.AHMPFOEGJHF(Location.PirateShip))
		{
			yield return BrookDWittNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	public void BFBFKGKHEPE()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.KGELHEOJBBI());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 1);
		}
	}

	public void OKAGLAJIACA()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.ODAHFGDKLCI());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
	}

	public void AELDOEOOICP(int AAAIOBLCOFO)
	{
		if (!ChallengesUI.AnyMinigameInProgress)
		{
			CJODOOFLLLB = AAAIOBLCOFO;
			StartEvent(BFLCJPHHDJM: true, CDPAMNIPPEC: true);
		}
	}

	private IEnumerator MCECKBFLGAK()
	{
		return new HIGBKBENDAH(1)
		{
			_003C_003E4__this = this
		};
	}

	public void FAAIPGINCHO(int AAAIOBLCOFO)
	{
		if (!ChallengesUI.AnyMinigameInProgress)
		{
			CJODOOFLLLB = AAAIOBLCOFO;
			StartEvent(BFLCJPHHDJM: true, CDPAMNIPPEC: true);
		}
	}

	private IEnumerator MLCAOOONCGJ()
	{
		BrookDWittNPC.GGFJGHHHEJC.animationBase.SetTrigger("Throw");
		yield return CommonReferences.wait1_5;
		BrookDWittNPC.GGFJGHHHEJC.inSpecialEvent = false;
		BrookDWittNPC.GGFJGHHHEJC.blockActionBar = false;
		if (instance.isActor)
		{
			BrookDWittNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "Pirates/Brook/Intro2");
		}
		else if (Utils.AHMPFOEGJHF(Location.PirateShip))
		{
			yield return BrookDWittNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private IEnumerator NMAPGABNDBP()
	{
		TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.PirateShip, Location.PirateCave);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(ACKDEEIAMEH));
		BrookDWittNPC.GGFJGHHHEJC.animationBase.SetBool("Angry", EGFGNGJGBOP: false);
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		if (Utils.AHMPFOEGJHF(Location.PirateShip))
		{
			GameActionBarUI.Get(1).OpenUI();
		}
		if (GameManager.LocalCoop() && Utils.AHMPFOEGJHF(Location.PirateShip, 2))
		{
			GameActionBarUI.Get(2).OpenUI();
		}
		while (Utils.NGLLIJPOBEC(Location.PirateShip))
		{
			yield return null;
		}
		if (OnlineManager.MasterOrOffline())
		{
			((Behaviour)ChumNPC.GGFJGHHHEJC.routine).enabled = true;
			ChumNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
		}
	}

	private IEnumerator DHBEOHEIJBC()
	{
		yield return CommonReferences.wait1;
		Result variable = DialogueLua.GetVariable("BrookProgress");
		if (((Result)(ref variable)).asInt == 0 && !EventsManager.IsDone(EventsManager.EventType.PiratesIntro) && !EventsManager.IsActive(EventsManager.EventType.PiratesIntro))
		{
			ActivateEvent();
		}
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
	}

	private IEnumerator KNDHHAFEAJL()
	{
		EDGDFPPKGDL = BrookDWittNPC.GGFJGHHHEJC;
		MDFALJKHKED = "Pirates/Brook/Intro";
		actorNumber = 1;
		BrookDWittNPC.GGFJGHHHEJC.barkDialogue = false;
		BrookDWittNPC.GGFJGHHHEJC.inSpecialEvent = true;
		BrookDWittNPC.GGFJGHHHEJC.blockActionBar = true;
		Debug.Log((object)"Starting Pirates Intro Event");
		if (instance.isActor)
		{
			BrookDWittNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "Pirates/Brook/Intro");
		}
		else if (Utils.AHMPFOEGJHF(Location.PirateShip))
		{
			yield return BrookDWittNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private IEnumerator ODAHFGDKLCI()
	{
		BrookDWittNPC.GGFJGHHHEJC.animationBase.SetTrigger("Throw");
		yield return CommonReferences.wait1_5;
		BrookDWittNPC.GGFJGHHHEJC.inSpecialEvent = false;
		BrookDWittNPC.GGFJGHHHEJC.blockActionBar = false;
		if (instance.isActor)
		{
			BrookDWittNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "Pirates/Brook/Intro2");
		}
		else if (Utils.AHMPFOEGJHF(Location.PirateShip))
		{
			yield return BrookDWittNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private IEnumerator PFCHAADNMEI()
	{
		EDGDFPPKGDL = BrookDWittNPC.GGFJGHHHEJC;
		MDFALJKHKED = "Pirates/Brook/Intro";
		actorNumber = 1;
		BrookDWittNPC.GGFJGHHHEJC.barkDialogue = false;
		BrookDWittNPC.GGFJGHHHEJC.inSpecialEvent = true;
		BrookDWittNPC.GGFJGHHHEJC.blockActionBar = true;
		Debug.Log((object)"Starting Pirates Intro Event");
		if (instance.isActor)
		{
			BrookDWittNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "Pirates/Brook/Intro");
		}
		else if (Utils.AHMPFOEGJHF(Location.PirateShip))
		{
			yield return BrookDWittNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	public void JOBFIFBPIPB()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.KDHFNPMKBMA());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 1);
		}
	}

	private void IDODLLIMEMO()
	{
		((MonoBehaviour)this).StartCoroutine(AKMAILIIGOH());
	}

	private IEnumerator MLACIHIBCCA()
	{
		TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.PirateShip, Location.PirateCave);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(ACKDEEIAMEH));
		BrookDWittNPC.GGFJGHHHEJC.animationBase.SetBool("Angry", EGFGNGJGBOP: false);
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		if (Utils.AHMPFOEGJHF(Location.PirateShip))
		{
			GameActionBarUI.Get(1).OpenUI();
		}
		if (GameManager.LocalCoop() && Utils.AHMPFOEGJHF(Location.PirateShip, 2))
		{
			GameActionBarUI.Get(2).OpenUI();
		}
		while (Utils.NGLLIJPOBEC(Location.PirateShip))
		{
			yield return null;
		}
		if (OnlineManager.MasterOrOffline())
		{
			((Behaviour)ChumNPC.GGFJGHHHEJC.routine).enabled = true;
			ChumNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
		}
	}

	private void CBHLNKHLDBG()
	{
		((MonoBehaviour)this).StartCoroutine(AJLCFLFFBGF());
	}

	private IEnumerator EOFDCOHAFKJ()
	{
		EDGDFPPKGDL = BrookDWittNPC.GGFJGHHHEJC;
		MDFALJKHKED = "Pirates/Brook/Intro";
		actorNumber = 1;
		BrookDWittNPC.GGFJGHHHEJC.barkDialogue = false;
		BrookDWittNPC.GGFJGHHHEJC.inSpecialEvent = true;
		BrookDWittNPC.GGFJGHHHEJC.blockActionBar = true;
		Debug.Log((object)"Starting Pirates Intro Event");
		if (instance.isActor)
		{
			BrookDWittNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "Pirates/Brook/Intro");
		}
		else if (Utils.AHMPFOEGJHF(Location.PirateShip))
		{
			yield return BrookDWittNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private void DMFMNEMDFNP()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(NEJABGEEFJF));
	}

	private IEnumerator HIEHNBCNMKJ()
	{
		return new HIGBKBENDAH(1)
		{
			_003C_003E4__this = this
		};
	}

	private void CNCKFABKNOF()
	{
		((MonoBehaviour)this).StartCoroutine(ACJCOEBMHNA());
	}

	private IEnumerator NBEGJDIJAAH()
	{
		BrookDWittNPC.GGFJGHHHEJC.animationBase.SetTrigger("Throw");
		yield return CommonReferences.wait1_5;
		BrookDWittNPC.GGFJGHHHEJC.inSpecialEvent = false;
		BrookDWittNPC.GGFJGHHHEJC.blockActionBar = false;
		if (instance.isActor)
		{
			BrookDWittNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "Pirates/Brook/Intro2");
		}
		else if (Utils.AHMPFOEGJHF(Location.PirateShip))
		{
			yield return BrookDWittNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private void BNIKICAEIND()
	{
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(NEJABGEEFJF));
	}

	private IEnumerator FGOHPBNPOHO()
	{
		return new NKFCBFCJOED(1)
		{
			_003C_003E4__this = this
		};
	}

	public override void EndEvent(bool BGKCHMNJBLJ)
	{
		base.EndEvent(BGKCHMNJBLJ);
		((MonoBehaviour)instance).StartCoroutine(instance.LJABJLDHLCB());
	}

	private void IAIDKPJKLIC()
	{
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(GMLFGAKIEAD));
	}

	public void IPMBANNHDAN(int AAAIOBLCOFO)
	{
		if (!ChallengesUI.AnyMinigameInProgress)
		{
			CJODOOFLLLB = AAAIOBLCOFO;
			StartEvent(BFLCJPHHDJM: false, CDPAMNIPPEC: true);
		}
	}

	private IEnumerator BOBGOEMKOCH()
	{
		yield return CommonReferences.wait1;
		Result variable = DialogueLua.GetVariable("BrookProgress");
		if (((Result)(ref variable)).asInt == 0 && !EventsManager.IsDone(EventsManager.EventType.PiratesIntro) && !EventsManager.IsActive(EventsManager.EventType.PiratesIntro))
		{
			ActivateEvent();
		}
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
	}

	private IEnumerator BDLLENEGHMB()
	{
		return new HIGBKBENDAH(1)
		{
			_003C_003E4__this = this
		};
	}

	public void GEBKOANHGBE(int AAAIOBLCOFO)
	{
		if (!ChallengesUI.AnyMinigameInProgress)
		{
			CJODOOFLLLB = AAAIOBLCOFO;
			StartEvent(BFLCJPHHDJM: true, CDPAMNIPPEC: false);
		}
	}

	private IEnumerator GELEIEKPFMN()
	{
		yield return CommonReferences.wait1;
		Result variable = DialogueLua.GetVariable("BrookProgress");
		if (((Result)(ref variable)).asInt == 0 && !EventsManager.IsDone(EventsManager.EventType.PiratesIntro) && !EventsManager.IsActive(EventsManager.EventType.PiratesIntro))
		{
			ActivateEvent();
		}
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
	}

	private IEnumerator ODGBDHJPKBF()
	{
		return new NKFCBFCJOED(1)
		{
			_003C_003E4__this = this
		};
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
		if (JFNMCNCHMEO == 0)
		{
			ThrowEvent();
		}
	}

	private IEnumerator KEMAGLJCAHL()
	{
		return new NKFCBFCJOED(1)
		{
			_003C_003E4__this = this
		};
	}

	public void ENNIHIHCJJK(int AAAIOBLCOFO)
	{
		if (!ChallengesUI.AnyMinigameInProgress)
		{
			CJODOOFLLLB = AAAIOBLCOFO;
			StartEvent(BFLCJPHHDJM: true, CDPAMNIPPEC: false);
		}
	}

	private IEnumerator LJABJLDHLCB()
	{
		TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.PirateShip, Location.PirateCave);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(ACKDEEIAMEH));
		BrookDWittNPC.GGFJGHHHEJC.animationBase.SetBool("Angry", EGFGNGJGBOP: false);
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		if (Utils.AHMPFOEGJHF(Location.PirateShip))
		{
			GameActionBarUI.Get(1).OpenUI();
		}
		if (GameManager.LocalCoop() && Utils.AHMPFOEGJHF(Location.PirateShip, 2))
		{
			GameActionBarUI.Get(2).OpenUI();
		}
		while (Utils.NGLLIJPOBEC(Location.PirateShip))
		{
			yield return null;
		}
		if (OnlineManager.MasterOrOffline())
		{
			((Behaviour)ChumNPC.GGFJGHHHEJC.routine).enabled = true;
			ChumNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
		}
	}

	private void DCKKIDMJKJM()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(BJHFPGAEDFM));
	}

	public void OHDGAPICFPM(int AAAIOBLCOFO)
	{
		if (!ChallengesUI.AnyMinigameInProgress)
		{
			CJODOOFLLLB = AAAIOBLCOFO;
			StartEvent(BFLCJPHHDJM: false, CDPAMNIPPEC: true);
		}
	}

	private IEnumerator HBMEBCCEGOL()
	{
		return new NKFCBFCJOED(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator KDHFNPMKBMA()
	{
		return new EOPEMHDOLDK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HGHGMFAICJA()
	{
		return new EOPEMHDOLDK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LBPKBEIEIMJ()
	{
		return new HIGBKBENDAH(1)
		{
			_003C_003E4__this = this
		};
	}

	public void BMIFMEBPDHM()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.ODAHFGDKLCI());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
	}

	private IEnumerator FPKMPECAHBN()
	{
		return new EOPEMHDOLDK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator OLKAHKJHLIE()
	{
		return new HIGBKBENDAH(1)
		{
			_003C_003E4__this = this
		};
	}

	public void KCGFBGBDEDI()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.DBEFDDFCODN());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 1);
		}
	}

	private IEnumerator HEGPAHPFAOM()
	{
		return new HIGBKBENDAH(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator PHFNFCCJEMB()
	{
		EDGDFPPKGDL = BrookDWittNPC.GGFJGHHHEJC;
		MDFALJKHKED = "Pirates/Brook/Intro";
		actorNumber = 1;
		BrookDWittNPC.GGFJGHHHEJC.barkDialogue = false;
		BrookDWittNPC.GGFJGHHHEJC.inSpecialEvent = true;
		BrookDWittNPC.GGFJGHHHEJC.blockActionBar = true;
		Debug.Log((object)"Starting Pirates Intro Event");
		if (instance.isActor)
		{
			BrookDWittNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "Pirates/Brook/Intro");
		}
		else if (Utils.AHMPFOEGJHF(Location.PirateShip))
		{
			yield return BrookDWittNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	public void JKPIFCHOLOE()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.KLMPFGCGOCM());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 1);
		}
	}

	private IEnumerator KLMPFGCGOCM()
	{
		BrookDWittNPC.GGFJGHHHEJC.animationBase.SetTrigger("Throw");
		yield return CommonReferences.wait1_5;
		BrookDWittNPC.GGFJGHHHEJC.inSpecialEvent = false;
		BrookDWittNPC.GGFJGHHHEJC.blockActionBar = false;
		if (instance.isActor)
		{
			BrookDWittNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "Pirates/Brook/Intro2");
		}
		else if (Utils.AHMPFOEGJHF(Location.PirateShip))
		{
			yield return BrookDWittNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private void JNAIMKNLIIM(int AAAIOBLCOFO)
	{
		StartEvent(BFLCJPHHDJM: true, CDPAMNIPPEC: true);
		TravelZone travelZone = TravelZonesManager.DGCNCEDIFOF().ECFDFECLDFK(Location.Tavern | Location.Farm, Location.Tavern | Location.Road | Location.BarnInterior | Location.FarmShop);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(EBKPPHGMAEL));
	}

	private void GHPFCKGMLDA()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
	}

	public void CBBDCHCMCKC()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.HGHGMFAICJA());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
	}
}
