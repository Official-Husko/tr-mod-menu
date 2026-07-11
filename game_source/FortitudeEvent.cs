using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;
using psai.net;

public class FortitudeEvent : GameEvent
{
	private enum LOGEKNJJJOB
	{
		MoveChum,
		BrookDrink,
		ChumDrinkEvent,
		ChumLeftEvent,
		FadeOut,
		FadeIn,
		SpawnCannonBall,
		ReturnToShip,
		StartMinigame,
		Burp,
		SetDrunkOnLeft
	}

	[CompilerGenerated]
	private sealed class OOGJOKJDMPI : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FortitudeEvent _003C_003E4__this;

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
		public OOGJOKJDMPI(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			FortitudeEvent fortitudeEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				fortitudeEvent.EDGDFPPKGDL = null;
				if (OnlineManager.MasterOrOffline())
				{
					ChumNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(fortitudeEvent.movePosition[1].position), Direction.Right);
				}
				_003C_003E2__current = CommonReferences.wait3;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				BrookDWittNPC.GGFJGHHHEJC.animationBase.SetBool("Serve", EGFGNGJGBOP: true);
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				fortitudeEvent.EDGDFPPKGDL = BrookDWittNPC.GGFJGHHHEJC;
				fortitudeEvent.MDFALJKHKED = "Fortitude/MainEvent 3";
				_003C_003E2__current = OnlineManager.WaitForAllPlayers();
				_003C_003E1__state = 3;
				return true;
			case 3:
				_003C_003E1__state = -1;
				if (instance.isActor)
				{
					BrookDWittNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "Fortitude/MainEvent 3");
				}
				else if (PlayerController.GetPlayer(1).LEOIMFNKFGA == Location.PirateShip)
				{
					((MonoBehaviour)instance).StartCoroutine(BrookDWittNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
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
	private sealed class NIGCDEEMEEK : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FortitudeEvent _003C_003E4__this;

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
		public NIGCDEEMEEK(int _003C_003E1__state)
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
			FortitudeEvent fortitudeEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				fortitudeEvent.EDGDFPPKGDL = null;
				ChumNPC.GGFJGHHHEJC.animationBase.SetTrigger("Drink");
				_003C_003E2__current = CommonReferences.wait4;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				fortitudeEvent.EDGDFPPKGDL = BrookDWittNPC.GGFJGHHHEJC;
				fortitudeEvent.MDFALJKHKED = "Fortitude/MainEvent 4";
				if (instance.isActor)
				{
					BrookDWittNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "Fortitude/MainEvent 4");
				}
				else if (PlayerController.GetPlayer(1).LEOIMFNKFGA == Location.PirateShip)
				{
					((MonoBehaviour)instance).StartCoroutine(BrookDWittNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
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
	private sealed class PLLEFHILJEG : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FortitudeEvent _003C_003E4__this;

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
		public PLLEFHILJEG(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			FortitudeEvent fortitudeEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				fortitudeEvent.EDGDFPPKGDL = null;
				if (OnlineManager.MasterOrOffline())
				{
					ChumNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(fortitudeEvent.movePosition[2].position), Direction.Right, AMEOKNOLILB: true);
				}
				_003C_003E2__current = CommonReferences.wait3;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				fortitudeEvent.EDGDFPPKGDL = BrookDWittNPC.GGFJGHHHEJC;
				fortitudeEvent.MDFALJKHKED = "Fortitude/MainEvent 5";
				_003C_003E2__current = OnlineManager.WaitForAllPlayers();
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				BrookDWittNPC.GGFJGHHHEJC.blockActionBar = false;
				EventsManager.SetActive(EventsManager.EventType.Fortitude, DMBFKFLDDLH: true);
				if (instance.isActor)
				{
					BrookDWittNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "Fortitude/MainEvent 5");
				}
				else
				{
					((MonoBehaviour)instance).StartCoroutine(BrookDWittNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
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
	private sealed class MKBMGEMEBDM : IEnumerator<object>, IEnumerator, IDisposable
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
		public MKBMGEMEBDM(int _003C_003E1__state)
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
				break;
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
			BrookDWittNPC.GGFJGHHHEJC.animationBase.SetBool("Serve", EGFGNGJGBOP: false);
			BrookDWittNPC.GGFJGHHHEJC.animationBase.SetBool("Drunk", EGFGNGJGBOP: false);
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
	private sealed class DGOKGOEKAMK : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FortitudeEvent _003C_003E4__this;

		public int playerNum;

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
		public DGOKGOEKAMK(int _003C_003E1__state)
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
			FortitudeEvent fortitudeEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
			{
				_003C_003E1__state = -1;
				FadeCamera player = FadeCamera.GetPlayer(1);
				player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(fortitudeEvent.GNCBHBEDKDL));
				PiratesGameManager.instance.FadeToBlackFinished(playerNum);
				PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
				BrookDWittNPC.GGFJGHHHEJC.blockActionBar = false;
				PlayerController.GetPlayer(1).LEOIMFNKFGA = Location.PirateShip;
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 1;
				return true;
			}
			case 1:
				_003C_003E1__state = -1;
				_003C_003E2__current = OnlineManager.WaitForAllPlayers();
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				PlayerController.GetPlayer(1).gridController.disable = false;
				if (GameManager.LocalCoop())
				{
					PlayerController.GetPlayer(2).gridController.disable = false;
				}
				BrookDWittNPC.GGFJGHHHEJC.inSpecialEvent = true;
				if (instance.FLMLLMHPJJA)
				{
					if (OnlineManager.MasterOrOffline())
					{
						BrookDWittNPC.GGFJGHHHEJC.StartConversation(1, "PirateMinigame/Win2");
					}
				}
				else
				{
					instance.isStarted = false;
					if (OnlineManager.MasterOrOffline())
					{
						BrookDWittNPC.GGFJGHHHEJC.StartConversation(1, "PirateMinigame/Lose2");
					}
					fortitudeEvent.SetDrunkOnLeft();
				}
				if (OnlineManager.ClientOnline())
				{
					((MonoBehaviour)instance).StartCoroutine(BrookDWittNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
				}
				BrookDWittNPC.GGFJGHHHEJC.inSpecialEvent = false;
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
	private sealed class FFFNJALMCEP : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FortitudeEvent _003C_003E4__this;

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
		public FFFNJALMCEP(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			FortitudeEvent fortitudeEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				ChumNPC.GGFJGHHHEJC.animationBase.SetBool("Clean", EGFGNGJGBOP: false);
				if (OnlineManager.MasterOrOffline())
				{
					ChumNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(fortitudeEvent.movePosition[0].position), Direction.Right);
				}
				_003C_003E2__current = CommonReferences.wait3;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				fortitudeEvent.EDGDFPPKGDL = BrookDWittNPC.GGFJGHHHEJC;
				fortitudeEvent.MDFALJKHKED = "Fortitude/MainEvent 2";
				_003C_003E2__current = OnlineManager.WaitForAllPlayers();
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				if (instance.isActor)
				{
					BrookDWittNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "Fortitude/MainEvent 2");
				}
				else if (PlayerController.GetPlayer(1).LEOIMFNKFGA == Location.PirateShip)
				{
					((MonoBehaviour)instance).StartCoroutine(BrookDWittNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
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
	private sealed class NNNCIKIBIBC : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FortitudeEvent _003C_003E4__this;

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
		public NNNCIKIBIBC(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			FortitudeEvent fortitudeEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				fortitudeEvent.EDGDFPPKGDL = null;
				if (OnlineManager.MasterOrOffline())
				{
					PiratesGameManager.instance.SpawnACannonBallInPosition(PiratesGameManager.instance.cellPositions[2, 4]);
				}
				_003C_003E2__current = CommonReferences.wait3;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				fortitudeEvent.EDGDFPPKGDL = BrookDWittNPC.GGFJGHHHEJC;
				fortitudeEvent.MDFALJKHKED = "PirateMinigame/Minigame2";
				_003C_003E2__current = OnlineManager.WaitForAllPlayers();
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
				if (instance.isActor)
				{
					BrookDWittNPC.GGFJGHHHEJC.StartConversation(1, "PirateMinigame/Minigame2");
				}
				else
				{
					((MonoBehaviour)instance).StartCoroutine(BrookDWittNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
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
	private sealed class CAILABENCLI : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool restart;

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
		public CAILABENCLI(int _003C_003E1__state)
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
				if (restart)
				{
					PiratesGameManager.Restart();
				}
				else
				{
					PiratesGameManager.Begin(KPCHOCLAAIM: true, IPDJFMMIKEK: true);
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

	public static FortitudeEvent instance;

	public Transform[] initialPosition;

	public Transform[] movePosition;

	private bool FLMLLMHPJJA;

	public void GJPEKHCFMAB()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.NMHNJLDAFAD(IBAFLJPMOCN: true));
		if (OnlineManager.MasterOrOffline() && TavernManager.NENEEGEALBI())
		{
			TavernManager.GGFJGHHHEJC.SetOpen(0, AODONKKHPBP: false, AINPJHKNJGL: true);
		}
	}

	private void PHOKIBMPONB(int JIIGOACEIKL)
	{
		FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(0);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(EOHFDEAOEEH));
		instance.EDGDFPPKGDL = BrookDWittNPC.LFPEPJBNCBF();
		instance.MDFALJKHKED = " ";
		if (instance.isActor)
		{
			BrookDWittNPC.KEJMJMKEEGA().StartConversation(0, "Key2", FLHBPHPKIML: true);
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(BrookDWittNPC.HFHPMKJGMPA().StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private void PPAJPPILKKI(bool BFLCJPHHDJM)
	{
		instance.isActor = BFLCJPHHDJM;
		if (BFLCJPHHDJM && Utils.MMMFJPKECAB(~(Location.Tavern | Location.Road | Location.River | Location.Quarry | Location.FarmShop)))
		{
			CJODOOFLLLB = BrookDWittNPC.JCMKNNOEONP().EHHOHCPHAAO;
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: true);
		}
	}

	public void DJNKBOENDOE()
	{
		instance.EDGDFPPKGDL = null;
		if (OnlineManager.MasterOrOffline())
		{
			ChumNPC.EJHDHCNILDH().routine.noDisableOnReset = true;
			((Behaviour)ChumNPC.EBAIHKJHCCA().routine).enabled = false;
		}
		PsaiCore.Instance.StopMusic(immediately: true);
		MusicController.instance.TriggerCurrentBasicMood(CommonReferences.wait12, Location.River | Location.Camp);
		PlayerInputs.CMEBIMMKIAB((MonoBehaviour)(object)instance, ANJCLPDCJHL: true);
		BrookDWittNPC.LCNGJIFNEOK().blockActionBar = true;
		TravelZonesManager.BGMJCCFNNDL().NKEBECDKDOO(~(Location.Road | Location.River | Location.Quarry | Location.BarnInterior), ~(Location.Tavern | Location.River | Location.Camp | Location.Quarry | Location.Farm | Location.FarmShop)).StartTravelZone(1);
		FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(0);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Combine(fadeCamera.OnFadeFinished, new Action<int>(IMMMIBDJBHG));
		if (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(2) != (Object)null)
		{
			TravelZonesManager.BGMJCCFNNDL().ECFDFECLDFK(~(Location.Tavern | Location.River | Location.Quarry | Location.Farm), ~(Location.Tavern | Location.Road | Location.FarmShop)).StartTravelZone(1);
		}
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
	}

	public void LoseEvent()
	{
		DialogueLua.SetVariable("LearnMettle", (object)1);
		FLMLLMHPJJA = false;
		BrookDWittNPC.GGFJGHHHEJC.animationBase.SetBool("Drunk", EGFGNGJGBOP: true);
		if (OnlineManager.MasterOrOffline())
		{
			BrookDWittNPC.GGFJGHHHEJC.StartConversation(1, "PirateMinigame/Lose");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(BrookDWittNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private IEnumerator IJBFAMPBJED()
	{
		return new OOGJOKJDMPI(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator BLINOAPIKPO()
	{
		return new MKBMGEMEBDM(1);
	}

	private void OOENGEGPPHK()
	{
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		BrookDWittNPC.HKBJIIJHBJB().animationBase.SetTrigger("Gass_CoctelQuest", HALNIEBONKH: true);
		instance.isStarted = true;
	}

	private IEnumerator NMOJGAENJHL()
	{
		return new OOGJOKJDMPI(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator CBJEOIBEBDN()
	{
		EDGDFPPKGDL = null;
		if (OnlineManager.MasterOrOffline())
		{
			PiratesGameManager.instance.SpawnACannonBallInPosition(PiratesGameManager.instance.cellPositions[2, 4]);
		}
		yield return CommonReferences.wait3;
		EDGDFPPKGDL = BrookDWittNPC.GGFJGHHHEJC;
		MDFALJKHKED = "PirateMinigame/Minigame2";
		yield return OnlineManager.WaitForAllPlayers();
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		if (instance.isActor)
		{
			BrookDWittNPC.GGFJGHHHEJC.StartConversation(1, "PirateMinigame/Minigame2");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(BrookDWittNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	public void BrookDrinkEvent()
	{
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		((MonoBehaviour)instance).StartCoroutine(instance.HFDJDNMNMEF());
		if (OnlineManager.PlayingOnline() && instance.isActor)
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 1);
		}
	}

	private IEnumerator LJABJLDHLCB()
	{
		while (Utils.NGLLIJPOBEC(Location.PirateShip))
		{
			yield return null;
		}
		BrookDWittNPC.GGFJGHHHEJC.animationBase.SetBool("Serve", EGFGNGJGBOP: false);
		BrookDWittNPC.GGFJGHHHEJC.animationBase.SetBool("Drunk", EGFGNGJGBOP: false);
	}

	private void GLIPCHCDBKD()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		MothersRecipeEvent.instance.treasureChest.SetActive(false);
		((Component)BrookDWittNPC.HGJMGNJOHGF()).transform.position = initialPosition[0].position;
		BrookDWittNPC.JCMKNNOEONP().content.SetActive(false);
		BrookDWittNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		BrookDWittNPC.HNNJEBNIPOI().animationBase.SetBool("ReceivePlaceableInfo", EGFGNGJGBOP: true, HALNIEBONKH: true);
		if (OnlineManager.PGAGDFAEEFB())
		{
			ChumNPC.OACNNJCLEDE().routine.noDisableOnReset = false;
			((Behaviour)ChumNPC.POINNCPMEIG().routine).enabled = false;
		}
		((Component)ChumNPC.OJJDNLEFNPJ()).transform.position = initialPosition[1].position;
		ChumNPC.GGFJGHHHEJC.content.SetActive(true);
		ChumNPC.OJJDNLEFNPJ().animationBase.SetDirection(Direction.Down);
		ChumNPC.EBAIHKJHCCA().animationBase.SetBool("HotBath/Clive Talk", EGFGNGJGBOP: false);
	}

	private IEnumerator GNELJJGBDID()
	{
		return new PLLEFHILJEG(1)
		{
			_003C_003E4__this = this
		};
	}

	public void NMFEGGOFEFF()
	{
		instance.EDGDFPPKGDL = null;
		instance.isStarted = false;
		if (OnlineManager.MasterOrOffline())
		{
			instance.isActor = true;
			((MonoBehaviour)instance).StartCoroutine(instance.MGFJMAINFIE(IBAFLJPMOCN: false));
			return;
		}
		if (instance.isActor)
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 3);
		}
		instance.isActor = true;
	}

	private IEnumerator HDAPKMDLKKG()
	{
		ChumNPC.GGFJGHHHEJC.animationBase.SetBool("Clean", EGFGNGJGBOP: false);
		if (OnlineManager.MasterOrOffline())
		{
			ChumNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePosition[0].position), Direction.Right);
		}
		yield return CommonReferences.wait3;
		EDGDFPPKGDL = BrookDWittNPC.GGFJGHHHEJC;
		MDFALJKHKED = "Fortitude/MainEvent 2";
		yield return OnlineManager.WaitForAllPlayers();
		if (instance.isActor)
		{
			BrookDWittNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "Fortitude/MainEvent 2");
		}
		else if (PlayerController.GetPlayer(1).LEOIMFNKFGA == Location.PirateShip)
		{
			((MonoBehaviour)instance).StartCoroutine(BrookDWittNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private void LIMEMMFIAPM()
	{
		PlayerInputs.DOGOHAPPMAC((MonoBehaviour)(object)instance);
		BrookDWittNPC.JHMAMLIPBNN().animationBase.SetTrigger("Dialogue System/Conversation/Gass_Quest/Entry/38/Dialogue Text", HALNIEBONKH: true);
		instance.isStarted = true;
	}

	private IEnumerator HFDJDNMNMEF()
	{
		EDGDFPPKGDL = null;
		if (OnlineManager.MasterOrOffline())
		{
			ChumNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePosition[1].position), Direction.Right);
		}
		yield return CommonReferences.wait3;
		BrookDWittNPC.GGFJGHHHEJC.animationBase.SetBool("Serve", EGFGNGJGBOP: true);
		yield return CommonReferences.wait2;
		EDGDFPPKGDL = BrookDWittNPC.GGFJGHHHEJC;
		MDFALJKHKED = "Fortitude/MainEvent 3";
		yield return OnlineManager.WaitForAllPlayers();
		if (instance.isActor)
		{
			BrookDWittNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "Fortitude/MainEvent 3");
		}
		else if (PlayerController.GetPlayer(1).LEOIMFNKFGA == Location.PirateShip)
		{
			((MonoBehaviour)instance).StartCoroutine(BrookDWittNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	public override void EndEvent(bool BFLCJPHHDJM)
	{
		base.EndEvent(BFLCJPHHDJM);
		DialogueLua.SetVariable("LearnMettle", (object)2);
		CommonReferences.GGFJGHHHEJC.OnActionDone(1, ActionDone.Fortitude);
		CommonReferences.GGFJGHHHEJC.OnEventComplete(1);
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		if (OnlineManager.MasterOrOffline())
		{
			PlayerInventory.GetPlayer(1).AddItem(ItemDatabaseAccessor.GetItem(1673).JMDALJBNFML(), HMPDLIPFBGD: true);
			PlayerInventory.GetPlayer(1).AddItem(ItemDatabaseAccessor.GetItem(1680).JMDALJBNFML(), HMPDLIPFBGD: true);
		}
		((MonoBehaviour)this).StartCoroutine(LJABJLDHLCB());
	}

	private void GJBNMNBAJIP()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		MothersRecipeEvent.instance.treasureChest.SetActive(false);
		((Component)BrookDWittNPC.GGFJGHHHEJC).transform.position = initialPosition[0].position;
		BrookDWittNPC.GGFJGHHHEJC.content.SetActive(true);
		BrookDWittNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		BrookDWittNPC.GGFJGHHHEJC.animationBase.SetBool("Drunk", EGFGNGJGBOP: true, HALNIEBONKH: true);
		if (OnlineManager.MasterOrOffline())
		{
			ChumNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
			((Behaviour)ChumNPC.GGFJGHHHEJC.routine).enabled = false;
		}
		((Component)ChumNPC.GGFJGHHHEJC).transform.position = initialPosition[1].position;
		ChumNPC.GGFJGHHHEJC.content.SetActive(true);
		ChumNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		ChumNPC.GGFJGHHHEJC.animationBase.SetBool("Clean", EGFGNGJGBOP: true, HALNIEBONKH: true);
	}

	private IEnumerator CICELGGAMCO()
	{
		ChumNPC.GGFJGHHHEJC.animationBase.SetBool("Clean", EGFGNGJGBOP: false);
		if (OnlineManager.MasterOrOffline())
		{
			ChumNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePosition[0].position), Direction.Right);
		}
		yield return CommonReferences.wait3;
		EDGDFPPKGDL = BrookDWittNPC.GGFJGHHHEJC;
		MDFALJKHKED = "Fortitude/MainEvent 2";
		yield return OnlineManager.WaitForAllPlayers();
		if (instance.isActor)
		{
			BrookDWittNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "Fortitude/MainEvent 2");
		}
		else if (PlayerController.GetPlayer(1).LEOIMFNKFGA == Location.PirateShip)
		{
			((MonoBehaviour)instance).StartCoroutine(BrookDWittNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private IEnumerator IIHLEDFIBIA()
	{
		return new PLLEFHILJEG(1)
		{
			_003C_003E4__this = this
		};
	}

	public void DCIOBOLNBKC()
	{
		instance.EDGDFPPKGDL = null;
		instance.isStarted = true;
		if (OnlineManager.PGAGDFAEEFB())
		{
			instance.isActor = true;
			((MonoBehaviour)instance).StartCoroutine(instance.MGFJMAINFIE(IBAFLJPMOCN: false));
			return;
		}
		if (instance.isActor)
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 8);
		}
		instance.isActor = false;
	}

	private IEnumerator KACKJGKLAKC(int JIIGOACEIKL)
	{
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(GNCBHBEDKDL));
		PiratesGameManager.instance.FadeToBlackFinished(JIIGOACEIKL);
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		BrookDWittNPC.GGFJGHHHEJC.blockActionBar = false;
		PlayerController.GetPlayer(1).LEOIMFNKFGA = Location.PirateShip;
		yield return CommonReferences.wait1;
		yield return OnlineManager.WaitForAllPlayers();
		PlayerController.GetPlayer(1).gridController.disable = false;
		if (GameManager.LocalCoop())
		{
			PlayerController.GetPlayer(2).gridController.disable = false;
		}
		BrookDWittNPC.GGFJGHHHEJC.inSpecialEvent = true;
		if (instance.FLMLLMHPJJA)
		{
			if (OnlineManager.MasterOrOffline())
			{
				BrookDWittNPC.GGFJGHHHEJC.StartConversation(1, "PirateMinigame/Win2");
			}
		}
		else
		{
			instance.isStarted = false;
			if (OnlineManager.MasterOrOffline())
			{
				BrookDWittNPC.GGFJGHHHEJC.StartConversation(1, "PirateMinigame/Lose2");
			}
			SetDrunkOnLeft();
		}
		if (OnlineManager.ClientOnline())
		{
			((MonoBehaviour)instance).StartCoroutine(BrookDWittNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
		BrookDWittNPC.GGFJGHHHEJC.inSpecialEvent = false;
	}

	public void GCLOGEFCOGF()
	{
		instance.EDGDFPPKGDL = null;
		if (OnlineManager.MasterOrOffline())
		{
			ChumNPC.KIALFDOKABP().routine.noDisableOnReset = false;
			((Behaviour)ChumNPC.LKOABOAADCD().routine).enabled = true;
		}
		PsaiCore.Instance.StopMusic(immediately: true);
		MusicController.instance.TriggerCurrentBasicMood(CommonReferences.wait12, ~(Location.Tavern | Location.River | Location.Camp | Location.Quarry | Location.FarmShop));
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		BrookDWittNPC.BNDNMBGJEKP().blockActionBar = true;
		TravelZonesManager.GFMBEDCANNI().GetTravelZone(~(Location.River | Location.Camp | Location.Quarry | Location.FarmShop), ~(Location.River | Location.Quarry | Location.Farm | Location.FarmShop)).KACGDPCMGPL(0);
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(0);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Combine(fadeCamera.OnFadeFinished, new Action<int>(IMMMIBDJBHG));
		if (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(6) != (Object)null)
		{
			TravelZonesManager.OMFKNGDCJFN().DAOACOMANPN(~(Location.Tavern | Location.Road | Location.River | Location.Camp | Location.Farm | Location.BarnInterior), ~Location.Farm).KACGDPCMGPL(0);
		}
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 2);
		}
	}

	public void ChumLeftEvent()
	{
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		((MonoBehaviour)instance).StartCoroutine(instance.GGMFKKJJHBJ());
		if (OnlineManager.PlayingOnline() && instance.isActor)
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 3);
		}
	}

	private void BIFBKHKMPKE()
	{
		List<Slot> slotsWithItem = CraftingInventory.GetSlotsWithItem(1, ItemDatabaseAccessor.INJBNHPGCIJ(-128, GGBBJNBBLMF: true, DAINLFIMLIH: false), null, AKNBKINJGCF: false, null, DDAPJEAJGGA: true);
		for (int i = 0; i < slotsWithItem.Count; i += 0)
		{
			slotsWithItem[i].FDOBDPPMMBH(slotsWithItem[i].Stack);
		}
		if (GameManager.LocalCoop())
		{
			List<Slot> slotsWithItem2 = CraftingInventory.GetSlotsWithItem(1, ItemDatabaseAccessor.KMBGJEKCJFJ(-76, GGBBJNBBLMF: true, DAINLFIMLIH: false), null, AKNBKINJGCF: true, null, DDAPJEAJGGA: true);
			for (int j = 1; j < slotsWithItem2.Count; j += 0)
			{
				slotsWithItem2[j].JPACDDCJGPD(slotsWithItem2[j].Stack, CDPAMNIPPEC: true);
			}
		}
	}

	public void OnFadeIn()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.DOKOLLCNIIM());
		CommonReferences.GGFJGHHHEJC.tilemapsInfo.ANOMBEOPINN(Location.Road, 1);
		if (OnlineManager.PlayingOnline() && instance.isActor)
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 5);
		}
	}

	public void FadeOut()
	{
		instance.EDGDFPPKGDL = null;
		PlayerController.GetPlayer(1).gridController.disable = true;
		if (GameManager.LocalCoop())
		{
			PlayerController.GetPlayer(2).gridController.disable = true;
		}
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		BrookDWittNPC.GGFJGHHHEJC.blockActionBar = true;
		FadeCamera.GetPlayer(1).FadeOut(0.4f);
		FadeCamera.GetPlayer(1).JDKHJJIOLOE += HHGEKEKHDNK;
		CommonReferences.GGFJGHHHEJC.tilemapsInfo.ANOMBEOPINN(Location.Tavern, 1);
		PlayerController.GetPlayer(1).LEOIMFNKFGA = Location.Road;
		PiratesGameManager.instance.SetWeather();
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeOut(0.4f);
		}
		if (OnlineManager.PlayingOnline() && instance.isActor)
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 4);
		}
	}

	public void ChumDrinkEvent()
	{
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		((MonoBehaviour)instance).StartCoroutine(instance.AGCDDCGFGOA());
		if (OnlineManager.PlayingOnline() && instance.isActor)
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 2);
		}
	}

	private void KCIEGFHHPGN()
	{
		PlayerInputs.ELJNFCLAGGI((MonoBehaviour)(object)instance);
		BrookDWittNPC.IECOPNFJBFD().animationBase.SetTrigger("Player/Bark/Tutorial/CantDoYet", HALNIEBONKH: true);
		instance.isStarted = true;
	}

	private IEnumerator KEGBLGGIGJI(int JIIGOACEIKL)
	{
		return new DGOKGOEKAMK(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	public void JJNNEAEKDJJ()
	{
		DialogueLua.SetVariable("ReceiveCompletedMission", (object)1);
		FLMLLMHPJJA = false;
		BrookDWittNPC.DPJEGJBHBNP().animationBase.CGEADHOLHCH("OrderDelivered", EGFGNGJGBOP: false);
		if (OnlineManager.PGAGDFAEEFB())
		{
			BrookDWittNPC.JHMAMLIPBNN().StartConversation(0, "WaitIntro");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(BrookDWittNPC.FMIDAFEGDCD().StartObserverDialogueWhenItIsPossible(0));
		}
	}

	public void StartPirateGame()
	{
		instance.EDGDFPPKGDL = null;
		instance.isStarted = true;
		if (OnlineManager.MasterOrOffline())
		{
			instance.isActor = true;
			((MonoBehaviour)instance).StartCoroutine(instance.OCNCCAILJGG(IBAFLJPMOCN: false));
			return;
		}
		if (instance.isActor)
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 8);
		}
		instance.isActor = false;
	}

	public void ReturnToShip()
	{
		instance.EDGDFPPKGDL = null;
		if (OnlineManager.MasterOrOffline())
		{
			ChumNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
			((Behaviour)ChumNPC.GGFJGHHHEJC.routine).enabled = true;
		}
		PsaiCore.Instance.StopMusic(immediately: false);
		MusicController.instance.TriggerCurrentBasicMood(CommonReferences.wait12, Location.PirateShip);
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		BrookDWittNPC.GGFJGHHHEJC.blockActionBar = true;
		TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.PirateCave, Location.PirateShip).StartTravelZone(1);
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(GNCBHBEDKDL));
		if (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(2) != (Object)null)
		{
			TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.PirateCave, Location.PirateShip).StartTravelZone(2);
		}
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 7);
		}
	}

	protected override void Awake()
	{
		base.Awake();
		instance = this;
	}

	public void PDEGLIABLBJ()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.MDCOJGCKCEE());
		if (OnlineManager.PlayingOnline() && instance.isActor)
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 6);
		}
	}

	private void ENHDFDOBEIO(int JIIGOACEIKL)
	{
		((MonoBehaviour)instance).StartCoroutine(KACKJGKLAKC(JIIGOACEIKL));
	}

	private IEnumerator CDMEDEOLBJI()
	{
		return new NNNCIKIBIBC(1)
		{
			_003C_003E4__this = this
		};
	}

	private void ABJFNKAECJA()
	{
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		BrookDWittNPC.GGFJGHHHEJC.animationBase.SetTrigger("Burp");
		instance.isStarted = false;
	}

	public void HKGLJACPCIC()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.NMHNJLDAFAD(IBAFLJPMOCN: false));
		if (OnlineManager.PGAGDFAEEFB() && TavernManager.IsOpen())
		{
			TavernManager.GGFJGHHHEJC.SetOpen(0, AODONKKHPBP: true, AINPJHKNJGL: true);
		}
	}

	public void PHEODIIJOLL()
	{
		PlayerInputs.CMEBIMMKIAB((MonoBehaviour)(object)instance);
		((MonoBehaviour)instance).StartCoroutine(instance.IDOIEOLMAGK());
		if (OnlineManager.PlayingOnline() && instance.isActor)
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 3);
		}
	}

	private void CNEHECIFLEB()
	{
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		BrookDWittNPC.GGFJGHHHEJC.animationBase.SetBool("Serve", EGFGNGJGBOP: false);
		BrookDWittNPC.GGFJGHHHEJC.animationBase.SetBool("Drunk", EGFGNGJGBOP: true);
		instance.isStarted = false;
	}

	public void KEGKFAEMGNI()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.HFDBCPLPCMP(IBAFLJPMOCN: true));
		if (OnlineManager.MasterOrOffline() && TavernManager.NBMKDJFBHEL())
		{
			TavernManager.GGFJGHHHEJC.PHCLGNAFEFL(0, AODONKKHPBP: true);
		}
	}

	private void GJLBJDICOKO()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		MothersRecipeEvent.instance.treasureChest.SetActive(false);
		((Component)BrookDWittNPC.HKBJIIJHBJB()).transform.position = initialPosition[0].position;
		BrookDWittNPC.MPJJAPCFENH().content.SetActive(true);
		BrookDWittNPC.HKBJIIJHBJB().animationBase.SetDirection(Direction.Up);
		BrookDWittNPC.JHMAMLIPBNN().animationBase.CGEADHOLHCH("ReceiveUnlockPerkLevelMaster", EGFGNGJGBOP: true, HALNIEBONKH: true);
		if (OnlineManager.MasterOrOffline())
		{
			ChumNPC.KMKILBCGJOI().routine.noDisableOnReset = false;
			((Behaviour)ChumNPC.EJHDHCNILDH().routine).enabled = false;
		}
		((Component)ChumNPC.OJJDNLEFNPJ()).transform.position = initialPosition[0].position;
		ChumNPC.CHKMFEFOFKJ().content.SetActive(true);
		ChumNPC.OJJDNLEFNPJ().animationBase.SetDirection(Direction.Up);
		ChumNPC.CHKMFEFOFKJ().animationBase.CGEADHOLHCH("FocusedActionBar2", EGFGNGJGBOP: false);
	}

	private void NMLFCBLCNOM(bool BFLCJPHHDJM)
	{
		instance.isActor = BFLCJPHHDJM;
		if (BFLCJPHHDJM && Utils.MMMFJPKECAB(Location.Road | Location.River | Location.Camp | Location.Quarry))
		{
			CJODOOFLLLB = BrookDWittNPC.FOPGLLMEEDE().EHHOHCPHAAO;
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: true);
		}
	}

	private IEnumerator LLGHFFPFLJG()
	{
		return new FFFNJALMCEP(1)
		{
			_003C_003E4__this = this
		};
	}

	public void Burp()
	{
		instance.ABJFNKAECJA();
		if (OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 9);
		}
	}

	private void LPJAHGLEJCK()
	{
		PlayerInputs.JJEMCEMNMGC((MonoBehaviour)(object)instance);
		BrookDWittNPC.MAIDHAPANEB().animationBase.SetTrigger("Room occupied", HALNIEBONKH: true);
		instance.isStarted = true;
	}

	private void KAMCIIAFCGI()
	{
		List<Slot> list = CraftingInventory.INLEBGJNNIB(0, ItemDatabaseAccessor.EABMGELAAPG(74), null, AKNBKINJGCF: true, null, DDAPJEAJGGA: true);
		for (int i = 1; i < list.Count; i += 0)
		{
			list[i].FDOBDPPMMBH(list[i].Stack, CDPAMNIPPEC: true, 1);
		}
		if (GameManager.LocalCoop())
		{
			List<Slot> slotsWithItem = CraftingInventory.GetSlotsWithItem(6, ItemDatabaseAccessor.KMBGJEKCJFJ(-114, GGBBJNBBLMF: true), null, AKNBKINJGCF: false, null);
			for (int j = 0; j < slotsWithItem.Count; j++)
			{
				slotsWithItem[j].FDOBDPPMMBH(slotsWithItem[j].Stack, CDPAMNIPPEC: true);
			}
		}
	}

	public void EDMNHCDPENH()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.MDGDPJEOLNI(IBAFLJPMOCN: false));
		if (OnlineManager.MasterOrOffline() && TavernManager.NBMKDJFBHEL())
		{
			TavernManager.GGFJGHHHEJC.PHCLGNAFEFL(1, AODONKKHPBP: false);
		}
	}

	public void INMHAOIPHCH()
	{
		instance.EDGDFPPKGDL = null;
		instance.isActor = true;
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance, ANJCLPDCJHL: true);
		instance.MoveChumFunction();
	}

	private IEnumerator PABOAIKOBFF()
	{
		return new FFFNJALMCEP(1)
		{
			_003C_003E4__this = this
		};
	}

	public void NEFJNILOABI()
	{
		instance.EDGDFPPKGDL = null;
		instance.isStarted = true;
		if (OnlineManager.PGAGDFAEEFB())
		{
			instance.isActor = true;
			((MonoBehaviour)instance).StartCoroutine(instance.HFDBCPLPCMP(IBAFLJPMOCN: false));
			return;
		}
		if (instance.isActor)
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 5);
		}
		instance.isActor = true;
	}

	public void SpawnCannonBall()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.CBJEOIBEBDN());
		if (OnlineManager.PlayingOnline() && instance.isActor)
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 6);
		}
	}

	private IEnumerator MDCOJGCKCEE()
	{
		EDGDFPPKGDL = null;
		if (OnlineManager.MasterOrOffline())
		{
			PiratesGameManager.instance.SpawnACannonBallInPosition(PiratesGameManager.instance.cellPositions[2, 4]);
		}
		yield return CommonReferences.wait3;
		EDGDFPPKGDL = BrookDWittNPC.GGFJGHHHEJC;
		MDFALJKHKED = "PirateMinigame/Minigame2";
		yield return OnlineManager.WaitForAllPlayers();
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		if (instance.isActor)
		{
			BrookDWittNPC.GGFJGHHHEJC.StartConversation(1, "PirateMinigame/Minigame2");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(BrookDWittNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private IEnumerator OKGGKJNCACN()
	{
		return new NNNCIKIBIBC(1)
		{
			_003C_003E4__this = this
		};
	}

	public void PAIDNJIHEBE()
	{
		FLMLLMHPJJA = true;
		BrookDWittNPC.LCNGJIFNEOK().animationBase.CGEADHOLHCH("On Simple Event ", EGFGNGJGBOP: true);
		if (OnlineManager.MasterOrOffline())
		{
			BrookDWittNPC.MPJJAPCFENH().StartConversation(0, "Can find Seat", FLHBPHPKIML: true);
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(BrookDWittNPC.MPJJAPCFENH().StartObserverDialogueWhenItIsPossible(1));
		}
	}

	public void MoveChum()
	{
		instance.EDGDFPPKGDL = null;
		instance.isActor = true;
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		instance.MoveChumFunction();
	}

	public void MJJIEGFMKEK()
	{
		instance.KCIEGFHHPGN();
		if (OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 104);
		}
	}

	public void MOIPMFFPEEK()
	{
		FLMLLMHPJJA = true;
		BrookDWittNPC.HGJMGNJOHGF().animationBase.CGEADHOLHCH("Exit build mode", EGFGNGJGBOP: false);
		if (OnlineManager.MasterOrOffline())
		{
			BrookDWittNPC.LCNGJIFNEOK().StartConversation(0, " installed", FLHBPHPKIML: true);
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(BrookDWittNPC.DPJEGJBHBNP().StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private void LKFBAFFKJKM()
	{
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		BrookDWittNPC.OJJDNLEFNPJ().animationBase.SetBool("ItemSetup not attached to prefab ", EGFGNGJGBOP: false);
		BrookDWittNPC.BNDNMBGJEKP().animationBase.SetBool("GalaxyInstance.Storage.FileShare method started", EGFGNGJGBOP: true, HALNIEBONKH: true);
		instance.isStarted = false;
	}

	private void EKMLIHCBLBB()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		MothersRecipeEvent.instance.treasureChest.SetActive(false);
		((Component)BrookDWittNPC.FMIDAFEGDCD()).transform.position = initialPosition[0].position;
		BrookDWittNPC.FMIDAFEGDCD().content.SetActive(true);
		BrookDWittNPC.MPJJAPCFENH().animationBase.SetDirection(Direction.Down);
		BrookDWittNPC.KEJMJMKEEGA().animationBase.SetBool("Items/item_description_615", EGFGNGJGBOP: false);
		if (OnlineManager.MasterOrOffline())
		{
			ChumNPC.KMKILBCGJOI().routine.noDisableOnReset = true;
			((Behaviour)ChumNPC.OACNNJCLEDE().routine).enabled = false;
		}
		((Component)ChumNPC.KMKILBCGJOI()).transform.position = initialPosition[0].position;
		ChumNPC.KIALFDOKABP().content.SetActive(true);
		ChumNPC.KIALFDOKABP().animationBase.SetDirection(Direction.Down);
		ChumNPC.LKOABOAADCD().animationBase.SetBool("End", EGFGNGJGBOP: false);
	}

	private IEnumerator NEBOJDFEOBL()
	{
		EDGDFPPKGDL = null;
		if (OnlineManager.MasterOrOffline())
		{
			ChumNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePosition[2].position), Direction.Right, AMEOKNOLILB: true);
		}
		yield return CommonReferences.wait3;
		EDGDFPPKGDL = BrookDWittNPC.GGFJGHHHEJC;
		MDFALJKHKED = "Fortitude/MainEvent 5";
		yield return OnlineManager.WaitForAllPlayers();
		BrookDWittNPC.GGFJGHHHEJC.blockActionBar = false;
		EventsManager.SetActive(EventsManager.EventType.Fortitude, DMBFKFLDDLH: true);
		if (instance.isActor)
		{
			BrookDWittNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "Fortitude/MainEvent 5");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(BrookDWittNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private IEnumerator FIOGGJJENNH()
	{
		ChumNPC.GGFJGHHHEJC.animationBase.SetBool("Clean", EGFGNGJGBOP: false);
		if (OnlineManager.MasterOrOffline())
		{
			ChumNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePosition[0].position), Direction.Right);
		}
		yield return CommonReferences.wait3;
		EDGDFPPKGDL = BrookDWittNPC.GGFJGHHHEJC;
		MDFALJKHKED = "Fortitude/MainEvent 2";
		yield return OnlineManager.WaitForAllPlayers();
		if (instance.isActor)
		{
			BrookDWittNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "Fortitude/MainEvent 2");
		}
		else if (PlayerController.GetPlayer(1).LEOIMFNKFGA == Location.PirateShip)
		{
			((MonoBehaviour)instance).StartCoroutine(BrookDWittNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	public void DOLOLPPAMML()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.OCNCCAILJGG(IBAFLJPMOCN: false));
		if (OnlineManager.PGAGDFAEEFB() && TavernManager.HDEPMJIDJEM())
		{
			TavernManager.GGFJGHHHEJC.PHCLGNAFEFL(1, AODONKKHPBP: true);
		}
	}

	private IEnumerator JIOLLFMMEIA(bool IBAFLJPMOCN)
	{
		yield return CommonReferences.wait1;
		if (IBAFLJPMOCN)
		{
			PiratesGameManager.Restart();
		}
		else
		{
			PiratesGameManager.Begin(KPCHOCLAAIM: true, IPDJFMMIKEK: true);
		}
	}

	private IEnumerator HEANHCBDEEJ()
	{
		ChumNPC.GGFJGHHHEJC.animationBase.SetBool("Clean", EGFGNGJGBOP: false);
		if (OnlineManager.MasterOrOffline())
		{
			ChumNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePosition[0].position), Direction.Right);
		}
		yield return CommonReferences.wait3;
		EDGDFPPKGDL = BrookDWittNPC.GGFJGHHHEJC;
		MDFALJKHKED = "Fortitude/MainEvent 2";
		yield return OnlineManager.WaitForAllPlayers();
		if (instance.isActor)
		{
			BrookDWittNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "Fortitude/MainEvent 2");
		}
		else if (PlayerController.GetPlayer(1).LEOIMFNKFGA == Location.PirateShip)
		{
			((MonoBehaviour)instance).StartCoroutine(BrookDWittNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	public void SetDrunkOnLeft()
	{
		instance.CNEHECIFLEB();
		if (OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 10);
		}
	}

	public void MoveChumFunction()
	{
		instance.BMCFPCEJHDD();
		if (OnlineManager.MasterOrOffline())
		{
			ChumNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
			((Behaviour)ChumNPC.GGFJGHHHEJC.routine).enabled = false;
		}
		((MonoBehaviour)instance).StartCoroutine(instance.HDAPKMDLKKG());
		if (OnlineManager.PlayingOnline() && instance.isActor)
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
	}

	public void ELJEOBCNDAD()
	{
		instance.KCIEGFHHPGN();
		if (OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 54);
		}
	}

	private IEnumerator NNKNADLCNOJ()
	{
		return new MKBMGEMEBDM(1);
	}

	public void FFFJAKEEFLH()
	{
		instance.EDGDFPPKGDL = null;
		PlayerController.OPHDCMJLLEC(1).gridController.disable = true;
		if (GameManager.LocalCoop())
		{
			PlayerController.OPHDCMJLLEC(1).gridController.disable = false;
		}
		PlayerInputs.CMEBIMMKIAB((MonoBehaviour)(object)instance);
		BrookDWittNPC.DPJEGJBHBNP().blockActionBar = true;
		FadeCamera.GetPlayer(1).GPBOEBGJJPM(1219f);
		FadeCamera.GetPlayer(0).HDDEGMGIBDM(HHGEKEKHDNK);
		CommonReferences.MNFMOEKMJKN().tilemapsInfo.KMMOIJAFMCN(Location.Tavern, 1);
		PlayerController.OPHDCMJLLEC(1).GEPOGLACOPO(Location.Tavern | Location.Road | Location.River);
		PiratesGameManager.instance.SetWeather(DIONNMLCIIC: false);
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(6).IONMINJHMKL(1065f);
		}
		if (OnlineManager.PlayingOnline() && instance.isActor)
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 1);
		}
	}

	private void NDFJEBNDCPL()
	{
		List<Slot> slotsWithItem = CraftingInventory.GetSlotsWithItem(0, ItemDatabaseAccessor.GetItem(157), null, AKNBKINJGCF: true, null, DDAPJEAJGGA: true);
		for (int i = 1; i < slotsWithItem.Count; i += 0)
		{
			slotsWithItem[i].JPACDDCJGPD(slotsWithItem[i].Stack, CDPAMNIPPEC: true);
		}
		if (GameManager.LocalCoop())
		{
			List<Slot> slotsWithItem2 = CraftingInventory.GetSlotsWithItem(6, ItemDatabaseAccessor.AFOACBIHNCL(77, GGBBJNBBLMF: true, DAINLFIMLIH: false), null, AKNBKINJGCF: false, null, DDAPJEAJGGA: true);
			for (int j = 0; j < slotsWithItem2.Count; j += 0)
			{
				slotsWithItem2[j].HBMBGCHGEGN(slotsWithItem2[j].Stack, CDPAMNIPPEC: true);
			}
		}
	}

	public void EHCFLJFFGCH()
	{
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		((MonoBehaviour)instance).StartCoroutine(instance.NEBOJDFEOBL());
		if (OnlineManager.PlayingOnline() && instance.isActor)
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 4);
		}
	}

	public void CEEAIMCMPJN()
	{
		instance.EDGDFPPKGDL = null;
		instance.isActor = false;
		PlayerInputs.CMEBIMMKIAB((MonoBehaviour)(object)instance, ANJCLPDCJHL: true);
		instance.MoveChumFunction();
	}

	public void KGECAOPNPKO()
	{
		FLMLLMHPJJA = true;
		BrookDWittNPC.DPJEGJBHBNP().animationBase.SetBool("Input field already has console support component: {0}", EGFGNGJGBOP: true, HALNIEBONKH: true);
		if (OnlineManager.MasterOrOffline())
		{
			BrookDWittNPC.OKAPNFPFPFP().StartConversation(1, "UI2");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(BrookDWittNPC.FOPGLLMEEDE().StartObserverDialogueWhenItIsPossible(0));
		}
	}

	private void MPBICLKJCGE()
	{
		PlayerInputs.CJNGJEFBHGI((MonoBehaviour)(object)instance);
		BrookDWittNPC.EKDNJDJHONF().animationBase.SetTrigger("ThrownHookRPC", HALNIEBONKH: true);
		instance.isStarted = true;
	}

	private void HIJAKDDGJKM()
	{
		List<Slot> list = CraftingInventory.INLEBGJNNIB(1, ItemDatabaseAccessor.CPMMBEPEJLO(-156, GGBBJNBBLMF: true), null, AKNBKINJGCF: true, null, DDAPJEAJGGA: true);
		for (int i = 1; i < list.Count; i += 0)
		{
			list[i].JPACDDCJGPD(list[i].Stack, CDPAMNIPPEC: true, 1);
		}
		if (GameManager.LocalCoop())
		{
			List<Slot> list2 = CraftingInventory.INLEBGJNNIB(6, ItemDatabaseAccessor.EABMGELAAPG(153, GGBBJNBBLMF: false, DAINLFIMLIH: false), null, AKNBKINJGCF: false, null);
			for (int j = 1; j < list2.Count; j++)
			{
				list2[j].BBHHJLIFNPP(list2[j].Stack, CDPAMNIPPEC: true, 1);
			}
		}
	}

	public void PJDFJAALDCF()
	{
		instance.AEEIEIEBNMC();
		if (OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, -48);
		}
	}

	private IEnumerator HOJCAPPHHFE()
	{
		EDGDFPPKGDL = null;
		ChumNPC.GGFJGHHHEJC.animationBase.SetTrigger("Drink");
		yield return CommonReferences.wait4;
		EDGDFPPKGDL = BrookDWittNPC.GGFJGHHHEJC;
		MDFALJKHKED = "Fortitude/MainEvent 4";
		if (instance.isActor)
		{
			BrookDWittNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "Fortitude/MainEvent 4");
		}
		else if (PlayerController.GetPlayer(1).LEOIMFNKFGA == Location.PirateShip)
		{
			((MonoBehaviour)instance).StartCoroutine(BrookDWittNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private void MMEOGODILAN()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		MothersRecipeEvent.instance.treasureChest.SetActive(false);
		((Component)BrookDWittNPC.ABHIDHPMLLD()).transform.position = initialPosition[1].position;
		BrookDWittNPC.GGFJGHHHEJC.content.SetActive(true);
		BrookDWittNPC.MPJJAPCFENH().animationBase.SetDirection(Direction.Down);
		BrookDWittNPC.FMIDAFEGDCD().animationBase.SetBool("Next Trends", EGFGNGJGBOP: true, HALNIEBONKH: true);
		if (OnlineManager.PGAGDFAEEFB())
		{
			ChumNPC.OJJDNLEFNPJ().routine.noDisableOnReset = true;
			((Behaviour)ChumNPC.GGFJGHHHEJC.routine).enabled = true;
		}
		((Component)ChumNPC.KIALFDOKABP()).transform.position = initialPosition[0].position;
		ChumNPC.GGFJGHHHEJC.content.SetActive(true);
		ChumNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
		ChumNPC.LKOABOAADCD().animationBase.CGEADHOLHCH("Tutorial/Barn_Holly", EGFGNGJGBOP: false, HALNIEBONKH: true);
	}

	private void AEEIEIEBNMC()
	{
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		BrookDWittNPC.MNFMOEKMJKN().animationBase.CGEADHOLHCH("[HierarchyPrinter] Log dividido en {0} fragmentos para evitar truncado.", EGFGNGJGBOP: false);
		BrookDWittNPC.FMIDAFEGDCD().animationBase.SetBool("ButtonImmediately", EGFGNGJGBOP: true, HALNIEBONKH: true);
		instance.isStarted = true;
	}

	private IEnumerator BKPKCLLIHMM()
	{
		ChumNPC.GGFJGHHHEJC.animationBase.SetBool("Clean", EGFGNGJGBOP: false);
		if (OnlineManager.MasterOrOffline())
		{
			ChumNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePosition[0].position), Direction.Right);
		}
		yield return CommonReferences.wait3;
		EDGDFPPKGDL = BrookDWittNPC.GGFJGHHHEJC;
		MDFALJKHKED = "Fortitude/MainEvent 2";
		yield return OnlineManager.WaitForAllPlayers();
		if (instance.isActor)
		{
			BrookDWittNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "Fortitude/MainEvent 2");
		}
		else if (PlayerController.GetPlayer(1).LEOIMFNKFGA == Location.PirateShip)
		{
			((MonoBehaviour)instance).StartCoroutine(BrookDWittNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private IEnumerator EAHBFILGIGI()
	{
		EDGDFPPKGDL = null;
		ChumNPC.GGFJGHHHEJC.animationBase.SetTrigger("Drink");
		yield return CommonReferences.wait4;
		EDGDFPPKGDL = BrookDWittNPC.GGFJGHHHEJC;
		MDFALJKHKED = "Fortitude/MainEvent 4";
		if (instance.isActor)
		{
			BrookDWittNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "Fortitude/MainEvent 4");
		}
		else if (PlayerController.GetPlayer(1).LEOIMFNKFGA == Location.PirateShip)
		{
			((MonoBehaviour)instance).StartCoroutine(BrookDWittNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	public void NKJMLEMEDCF()
	{
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance, ANJCLPDCJHL: true);
		((MonoBehaviour)instance).StartCoroutine(instance.JCKNPGNHMNI());
		if (OnlineManager.PlayingOnline() && instance.isActor)
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 7);
		}
	}

	private IEnumerator HHCAIMCHHIP()
	{
		instance.EDGDFPPKGDL = null;
		PiratesGameManager.instance.SetGame();
		yield return CommonReferences.wait3;
		yield return OnlineManager.WaitForAllPlayers();
		FadeCamera.GetPlayer(1).FadeInWithDelay();
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(ICBNFLJAMCH));
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeInWithDelay();
		}
	}

	public void CHCDDMODFBF()
	{
		FLMLLMHPJJA = false;
		BrookDWittNPC.LFPEPJBNCBF().animationBase.SetBool("Player with actor number {0} removed from Players dictionary. Entries left: {1}", EGFGNGJGBOP: true);
		if (OnlineManager.PGAGDFAEEFB())
		{
			BrookDWittNPC.OJJDNLEFNPJ().StartConversation(0, "ReceiveFoodSlotFromContainer", FLHBPHPKIML: true);
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(BrookDWittNPC.HKBJIIJHBJB().StartObserverDialogueWhenItIsPossible(0));
		}
	}

	private void GIKEKKIDKLC()
	{
		PlayerInputs.ELJNFCLAGGI((MonoBehaviour)(object)instance);
		BrookDWittNPC.AJIGOHGPFPP().animationBase.SetTrigger("Move Forward", HALNIEBONKH: true);
		instance.isStarted = true;
	}

	private IEnumerator GGFFENOKDCE(int JIIGOACEIKL)
	{
		FadeCamera.GetPlayer(1).JDKHJJIOLOE -= HHGEKEKHDNK;
		yield return CommonReferences.wait2;
		if (OnlineManager.MasterOrOffline() && TavernManager.IsOpen())
		{
			TavernManager.GGFJGHHHEJC.SetOpen(1, AODONKKHPBP: false, AINPJHKNJGL: true);
		}
		instance.EDGDFPPKGDL = BrookDWittNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "Fortitude/MainEvent 6";
		yield return OnlineManager.WaitForAllPlayers();
		if (instance.isActor)
		{
			BrookDWittNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "Fortitude/MainEvent 6");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(BrookDWittNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	public void HKBLPMMOCBB()
	{
		PlayerInputs.CMEBIMMKIAB((MonoBehaviour)(object)instance, ANJCLPDCJHL: true);
		((MonoBehaviour)instance).StartCoroutine(instance.GNELJJGBDID());
		if (OnlineManager.PlayingOnline() && instance.isActor)
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 2);
		}
	}

	private void EOHFDEAOEEH(int JIIGOACEIKL)
	{
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(0);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(EOHFDEAOEEH));
		instance.EDGDFPPKGDL = BrookDWittNPC.FOPGLLMEEDE();
		instance.MDFALJKHKED = "Giving Quest 35";
		if (instance.isActor)
		{
			BrookDWittNPC.MAIDHAPANEB().StartConversation(0, "ActiveDecoMode", FLHBPHPKIML: true);
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(BrookDWittNPC.LCNGJIFNEOK().StartObserverDialogueWhenItIsPossible(0));
		}
	}

	public void JCPIAGJFHMO()
	{
		instance.MPBICLKJCGE();
		if (OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, -84);
		}
	}

	private void IMMMIBDJBHG(int JIIGOACEIKL)
	{
		((MonoBehaviour)instance).StartCoroutine(CIAEMOGNDNE(JIIGOACEIKL));
	}

	private IEnumerator HNFNINAPONO()
	{
		return new OOGJOKJDMPI(1)
		{
			_003C_003E4__this = this
		};
	}

	private void KLOFIDLAIAG(int JIIGOACEIKL)
	{
		((MonoBehaviour)instance).StartCoroutine(KEGBLGGIGJI(JIIGOACEIKL));
	}

	private void KBBAAPBIPKN(bool BFLCJPHHDJM)
	{
		instance.isActor = BFLCJPHHDJM;
		if (BFLCJPHHDJM && Utils.MMMFJPKECAB(~(Location.Tavern | Location.Road | Location.Camp | Location.FarmShop)))
		{
			CJODOOFLLLB = BrookDWittNPC.HGJMGNJOHGF().EHHOHCPHAAO;
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: true);
		}
	}

	public void ECAMIHIBCPE()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.HHCAIMCHHIP());
		CommonReferences.MNFMOEKMJKN().tilemapsInfo.CPAKBFAPJLA(Location.Camp, 1);
		if (OnlineManager.PlayingOnline() && instance.isActor)
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 5);
		}
	}

	private IEnumerator HFDBCPLPCMP(bool IBAFLJPMOCN)
	{
		yield return CommonReferences.wait1;
		if (IBAFLJPMOCN)
		{
			PiratesGameManager.Restart();
		}
		else
		{
			PiratesGameManager.Begin(KPCHOCLAAIM: true, IPDJFMMIKEK: true);
		}
	}

	private IEnumerator MHIJGMLMHAN()
	{
		return new NNNCIKIBIBC(1)
		{
			_003C_003E4__this = this
		};
	}

	public void HCMNDGMOBDK()
	{
		instance.EDGDFPPKGDL = null;
		instance.isStarted = false;
		if (OnlineManager.PGAGDFAEEFB())
		{
			instance.isActor = true;
			((MonoBehaviour)instance).StartCoroutine(instance.MDGDPJEOLNI(IBAFLJPMOCN: false));
			return;
		}
		if (instance.isActor)
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
		instance.isActor = false;
	}

	private void KHIMBGHCEFI()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		MothersRecipeEvent.instance.treasureChest.SetActive(true);
		((Component)BrookDWittNPC.MNFMOEKMJKN()).transform.position = initialPosition[0].position;
		BrookDWittNPC.OMFKNGDCJFN().content.SetActive(true);
		BrookDWittNPC.JLNBMNKJCHE().animationBase.SetDirection(Direction.Up);
		BrookDWittNPC.ACPHFLBLJAA().animationBase.SetBool("ReceiveAssignChicken", EGFGNGJGBOP: false);
		if (OnlineManager.PGAGDFAEEFB())
		{
			ChumNPC.KIALFDOKABP().routine.noDisableOnReset = false;
			((Behaviour)ChumNPC.EJHDHCNILDH().routine).enabled = true;
		}
		((Component)ChumNPC.EJHDHCNILDH()).transform.position = initialPosition[1].position;
		ChumNPC.GGFJGHHHEJC.content.SetActive(true);
		ChumNPC.OACNNJCLEDE().animationBase.SetDirection(Direction.Down);
		ChumNPC.MAIDHAPANEB().animationBase.CGEADHOLHCH("room info with code ", EGFGNGJGBOP: true);
	}

	public void DKBEBFGKPNO()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.MGFJMAINFIE(IBAFLJPMOCN: true));
		if (OnlineManager.MasterOrOffline() && TavernManager.NENEEGEALBI())
		{
			TavernManager.GGFJGHHHEJC.SetOpen(1, AODONKKHPBP: false);
		}
	}

	private IEnumerator DOKOLLCNIIM()
	{
		instance.EDGDFPPKGDL = null;
		PiratesGameManager.instance.SetGame();
		yield return CommonReferences.wait3;
		yield return OnlineManager.WaitForAllPlayers();
		FadeCamera.GetPlayer(1).FadeInWithDelay();
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(ICBNFLJAMCH));
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeInWithDelay();
		}
	}

	private void EPNLHLMBJFL()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		MothersRecipeEvent.instance.treasureChest.SetActive(true);
		((Component)BrookDWittNPC.EKDNJDJHONF()).transform.position = initialPosition[1].position;
		BrookDWittNPC.GFMBEDCANNI().content.SetActive(true);
		BrookDWittNPC.DOIKFJDLKJP().animationBase.SetDirection(Direction.Up);
		BrookDWittNPC.OKAPNFPFPFP().animationBase.SetBool("tutorialPopUp81", EGFGNGJGBOP: false, HALNIEBONKH: true);
		if (OnlineManager.PGAGDFAEEFB())
		{
			ChumNPC.OJJDNLEFNPJ().routine.noDisableOnReset = false;
			((Behaviour)ChumNPC.EJHDHCNILDH().routine).enabled = true;
		}
		((Component)ChumNPC.GGFJGHHHEJC).transform.position = initialPosition[1].position;
		ChumNPC.POINNCPMEIG().content.SetActive(false);
		ChumNPC.KIALFDOKABP().animationBase.SetDirection(Direction.Up);
		ChumNPC.EBAIHKJHCCA().animationBase.SetBool("EnableNPC", EGFGNGJGBOP: false, HALNIEBONKH: true);
	}

	public void NLOODMKKNMB()
	{
		instance.EDGDFPPKGDL = null;
		instance.isStarted = true;
		if (OnlineManager.MasterOrOffline())
		{
			instance.isActor = true;
			((MonoBehaviour)instance).StartCoroutine(instance.OCNCCAILJGG(IBAFLJPMOCN: false));
			return;
		}
		if (instance.isActor)
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 8);
		}
		instance.isActor = true;
	}

	private IEnumerator NMHNJLDAFAD(bool IBAFLJPMOCN)
	{
		yield return CommonReferences.wait1;
		if (IBAFLJPMOCN)
		{
			PiratesGameManager.Restart();
		}
		else
		{
			PiratesGameManager.Begin(KPCHOCLAAIM: true, IPDJFMMIKEK: true);
		}
	}

	public void KNFINGBEALO()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.BNFGPJMEKLE());
		CommonReferences.GGFJGHHHEJC.tilemapsInfo.DBGNLKIEBDK(Location.Road, 1);
		if (OnlineManager.PlayingOnline() && instance.isActor)
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 4);
		}
	}

	private IEnumerator JCKNPGNHMNI()
	{
		EDGDFPPKGDL = null;
		ChumNPC.GGFJGHHHEJC.animationBase.SetTrigger("Drink");
		yield return CommonReferences.wait4;
		EDGDFPPKGDL = BrookDWittNPC.GGFJGHHHEJC;
		MDFALJKHKED = "Fortitude/MainEvent 4";
		if (instance.isActor)
		{
			BrookDWittNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "Fortitude/MainEvent 4");
		}
		else if (PlayerController.GetPlayer(1).LEOIMFNKFGA == Location.PirateShip)
		{
			((MonoBehaviour)instance).StartCoroutine(BrookDWittNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	public void IPBOONNCGHF()
	{
		instance.EDGDFPPKGDL = null;
		instance.isStarted = true;
		if (OnlineManager.MasterOrOffline())
		{
			instance.isActor = false;
			((MonoBehaviour)instance).StartCoroutine(instance.OCNCCAILJGG(IBAFLJPMOCN: true));
			return;
		}
		if (instance.isActor)
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
		instance.isActor = true;
	}

	public void DFHJEFGAMNA()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.AJEJIJPHKOK());
		CommonReferences.GGFJGHHHEJC.tilemapsInfo.DBGNLKIEBDK(Location.Road, 1);
		if (OnlineManager.PlayingOnline() && instance.isActor)
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 8);
		}
	}

	public void CDEIMCHLGKB()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.NMHNJLDAFAD(IBAFLJPMOCN: true));
		if (OnlineManager.PGAGDFAEEFB() && TavernManager.NBMKDJFBHEL())
		{
			TavernManager.GGFJGHHHEJC.SetOpen(0, AODONKKHPBP: true);
		}
	}

	public void CIFFKIEJAGF()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.OCNCCAILJGG(IBAFLJPMOCN: false));
		if (OnlineManager.MasterOrOffline() && TavernManager.NBMKDJFBHEL())
		{
			TavernManager.GGFJGHHHEJC.SetOpen(1, AODONKKHPBP: false);
		}
	}

	private IEnumerator MDGDPJEOLNI(bool IBAFLJPMOCN)
	{
		return new CAILABENCLI(1)
		{
			restart = IBAFLJPMOCN
		};
	}

	private void BMCFPCEJHDD()
	{
		List<Slot> slotsWithItem = CraftingInventory.GetSlotsWithItem(1, ItemDatabaseAccessor.GetItem(1810), null, AKNBKINJGCF: false, null);
		for (int i = 0; i < slotsWithItem.Count; i++)
		{
			slotsWithItem[i].FDOBDPPMMBH(slotsWithItem[i].Stack);
		}
		if (GameManager.LocalCoop())
		{
			List<Slot> slotsWithItem2 = CraftingInventory.GetSlotsWithItem(2, ItemDatabaseAccessor.GetItem(1810), null, AKNBKINJGCF: false, null);
			for (int j = 0; j < slotsWithItem2.Count; j++)
			{
				slotsWithItem2[j].FDOBDPPMMBH(slotsWithItem2[j].Stack);
			}
		}
	}

	private void GNCBHBEDKDL(int JIIGOACEIKL)
	{
		((MonoBehaviour)instance).StartCoroutine(OCIKGJCGCBH(JIIGOACEIKL));
	}

	public void JNOMADJBOMG()
	{
		instance.EDGDFPPKGDL = null;
		if (OnlineManager.PGAGDFAEEFB())
		{
			ChumNPC.MAIDHAPANEB().routine.noDisableOnReset = false;
			((Behaviour)ChumNPC.MAIDHAPANEB().routine).enabled = false;
		}
		PsaiCore.Instance.StopMusic(immediately: true);
		MusicController.instance.TriggerCurrentBasicMood(CommonReferences.wait12, Location.Tavern | Location.Road | Location.Camp | Location.Quarry | Location.Farm | Location.BarnInterior);
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		BrookDWittNPC.IECOPNFJBFD().blockActionBar = true;
		TravelZonesManager.CFHEJAGKIII().DAOACOMANPN(~(Location.Camp | Location.Quarry | Location.BarnInterior), ~(Location.Tavern | Location.Road | Location.Quarry | Location.Farm | Location.BarnInterior)).KACGDPCMGPL(0);
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(1);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Combine(fadeCamera.OnFadeFinished, new Action<int>(GNCBHBEDKDL));
		if (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(2) != (Object)null)
		{
			TravelZonesManager.GFMBEDCANNI().KCJMDAPPJLB(Location.Tavern | Location.Road | Location.River | Location.Camp | Location.Quarry | Location.FarmShop, Location.Farm).StartTravelZone(4);
		}
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 8);
		}
	}

	public void BGABMGNBMPG()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.OKGGKJNCACN());
		if (OnlineManager.PlayingOnline() && instance.isActor)
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 6);
		}
	}

	public void OMHOLIMBEJI()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.BNFGPJMEKLE());
		CommonReferences.GGFJGHHHEJC.tilemapsInfo.BAJPNPNOLHF(Location.Tavern, 1);
		if (OnlineManager.PlayingOnline() && instance.isActor)
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 4);
		}
	}

	private IEnumerator OCIKGJCGCBH(int JIIGOACEIKL)
	{
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(GNCBHBEDKDL));
		PiratesGameManager.instance.FadeToBlackFinished(JIIGOACEIKL);
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		BrookDWittNPC.GGFJGHHHEJC.blockActionBar = false;
		PlayerController.GetPlayer(1).LEOIMFNKFGA = Location.PirateShip;
		yield return CommonReferences.wait1;
		yield return OnlineManager.WaitForAllPlayers();
		PlayerController.GetPlayer(1).gridController.disable = false;
		if (GameManager.LocalCoop())
		{
			PlayerController.GetPlayer(2).gridController.disable = false;
		}
		BrookDWittNPC.GGFJGHHHEJC.inSpecialEvent = true;
		if (instance.FLMLLMHPJJA)
		{
			if (OnlineManager.MasterOrOffline())
			{
				BrookDWittNPC.GGFJGHHHEJC.StartConversation(1, "PirateMinigame/Win2");
			}
		}
		else
		{
			instance.isStarted = false;
			if (OnlineManager.MasterOrOffline())
			{
				BrookDWittNPC.GGFJGHHHEJC.StartConversation(1, "PirateMinigame/Lose2");
			}
			SetDrunkOnLeft();
		}
		if (OnlineManager.ClientOnline())
		{
			((MonoBehaviour)instance).StartCoroutine(BrookDWittNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
		BrookDWittNPC.GGFJGHHHEJC.inSpecialEvent = false;
	}

	public override void StartEvent(bool BFLCJPHHDJM, bool CDPAMNIPPEC)
	{
		base.StartEvent(BFLCJPHHDJM, CDPAMNIPPEC);
		BrookDWittNPC brookDWittNPC = BrookDWittNPC.GGFJGHHHEJC;
		brookDWittNPC.ConversationStarted = (Action<bool>)Delegate.Remove(brookDWittNPC.ConversationStarted, new Action<bool>(AEEHFGIDCMJ));
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		EDGDFPPKGDL = BrookDWittNPC.GGFJGHHHEJC;
		MDFALJKHKED = "Fortitude/MainEvent 1";
		if (!isActor && OnlineManager.PlayingOnline())
		{
			((MonoBehaviour)instance).StartCoroutine(BrookDWittNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
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
		case LOGEKNJJJOB.MoveChum:
			MoveChumFunction();
			break;
		case LOGEKNJJJOB.BrookDrink:
			BrookDrinkEvent();
			break;
		case LOGEKNJJJOB.ChumDrinkEvent:
			ChumDrinkEvent();
			break;
		case LOGEKNJJJOB.ChumLeftEvent:
			ChumLeftEvent();
			break;
		case LOGEKNJJJOB.FadeOut:
			FadeOut();
			break;
		case LOGEKNJJJOB.FadeIn:
			OnFadeIn();
			break;
		case LOGEKNJJJOB.SpawnCannonBall:
			SpawnCannonBall();
			break;
		case LOGEKNJJJOB.ReturnToShip:
			ReturnToShip();
			break;
		case LOGEKNJJJOB.StartMinigame:
			StartPirateGame();
			break;
		case LOGEKNJJJOB.Burp:
			ABJFNKAECJA();
			break;
		case LOGEKNJJJOB.SetDrunkOnLeft:
			CNEHECIFLEB();
			break;
		}
	}

	public void BMIEECOIEMC()
	{
		instance.LIMEMMFIAPM();
		if (OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, -81);
		}
	}

	private void ANOEOPKLIPN()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		MothersRecipeEvent.instance.treasureChest.SetActive(true);
		((Component)BrookDWittNPC.MPJJAPCFENH()).transform.position = initialPosition[1].position;
		BrookDWittNPC.JLNBMNKJCHE().content.SetActive(true);
		BrookDWittNPC.MPJJAPCFENH().animationBase.SetDirection(Direction.Up);
		BrookDWittNPC.OJJDNLEFNPJ().animationBase.SetBool(" ", EGFGNGJGBOP: false);
		if (OnlineManager.MasterOrOffline())
		{
			ChumNPC.OACNNJCLEDE().routine.noDisableOnReset = true;
			((Behaviour)ChumNPC.GGFJGHHHEJC.routine).enabled = true;
		}
		((Component)ChumNPC.MAIDHAPANEB()).transform.position = initialPosition[0].position;
		ChumNPC.KMKILBCGJOI().content.SetActive(false);
		ChumNPC.CHKMFEFOFKJ().animationBase.SetDirection(Direction.Down);
		ChumNPC.EBAIHKJHCCA().animationBase.CGEADHOLHCH("ReceiveBarkBuzzDoorInfoLuaInt", EGFGNGJGBOP: false, HALNIEBONKH: true);
	}

	public void CMHIEKKCHLF()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.MPJKFHOCDMM());
		if (OnlineManager.PlayingOnline() && instance.isActor)
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 3);
		}
	}

	public void GFHJOEJMFPA()
	{
		FLMLLMHPJJA = true;
		BrookDWittNPC.MNFMOEKMJKN().animationBase.SetBool("", EGFGNGJGBOP: true, HALNIEBONKH: true);
		if (OnlineManager.MasterOrOffline())
		{
			BrookDWittNPC.ACPHFLBLJAA().StartConversation(0, "Exclamation", FLHBPHPKIML: true);
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(BrookDWittNPC.HGJMGNJOHGF().StartObserverDialogueWhenItIsPossible(1));
		}
	}

	public void HHLIAHFLEHN()
	{
		PlayerInputs.CMEBIMMKIAB((MonoBehaviour)(object)instance);
		((MonoBehaviour)instance).StartCoroutine(instance.HNFNINAPONO());
		if (OnlineManager.PlayingOnline() && instance.isActor)
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 1);
		}
	}

	public void WinEvent()
	{
		FLMLLMHPJJA = true;
		BrookDWittNPC.GGFJGHHHEJC.animationBase.SetBool("Drunk", EGFGNGJGBOP: false);
		if (OnlineManager.MasterOrOffline())
		{
			BrookDWittNPC.GGFJGHHHEJC.StartConversation(1, "PirateMinigame/Win");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(BrookDWittNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private IEnumerator AJEJIJPHKOK()
	{
		instance.EDGDFPPKGDL = null;
		PiratesGameManager.instance.SetGame();
		yield return CommonReferences.wait3;
		yield return OnlineManager.WaitForAllPlayers();
		FadeCamera.GetPlayer(1).FadeInWithDelay();
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(ICBNFLJAMCH));
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeInWithDelay();
		}
	}

	private void AMFAFFJMOCH(int JIIGOACEIKL)
	{
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(1);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(PHOKIBMPONB));
		instance.EDGDFPPKGDL = BrookDWittNPC.HKBJIIJHBJB();
		instance.MDFALJKHKED = "NormalRight";
		if (instance.isActor)
		{
			BrookDWittNPC.HNNJEBNIPOI().StartConversation(0, "Items/item_description_608");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(BrookDWittNPC.HKBJIIJHBJB().StartObserverDialogueWhenItIsPossible(0));
		}
	}

	public void GEPPHPIAOPG()
	{
		PlayerInputs.CMEBIMMKIAB((MonoBehaviour)(object)instance, ANJCLPDCJHL: true);
		((MonoBehaviour)instance).StartCoroutine(instance.EGEKOAJJCKI());
		if (OnlineManager.PlayingOnline() && instance.isActor)
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 6);
		}
	}

	private IEnumerator BNFGPJMEKLE()
	{
		instance.EDGDFPPKGDL = null;
		PiratesGameManager.instance.SetGame();
		yield return CommonReferences.wait3;
		yield return OnlineManager.WaitForAllPlayers();
		FadeCamera.GetPlayer(1).FadeInWithDelay();
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(ICBNFLJAMCH));
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeInWithDelay();
		}
	}

	private IEnumerator MGFJMAINFIE(bool IBAFLJPMOCN)
	{
		return new CAILABENCLI(1)
		{
			restart = IBAFLJPMOCN
		};
	}

	private void KOHHBIMKNBC()
	{
		List<Slot> slotsWithItem = CraftingInventory.GetSlotsWithItem(1, ItemDatabaseAccessor.CPMMBEPEJLO(-186, GGBBJNBBLMF: false, DAINLFIMLIH: false), null, AKNBKINJGCF: false, null);
		for (int i = 1; i < slotsWithItem.Count; i++)
		{
			slotsWithItem[i].HBMBGCHGEGN(slotsWithItem[i].Stack, CDPAMNIPPEC: true);
		}
		if (GameManager.LocalCoop())
		{
			List<Slot> slotsWithItem2 = CraftingInventory.GetSlotsWithItem(7, ItemDatabaseAccessor.INJBNHPGCIJ(180, GGBBJNBBLMF: true), null, AKNBKINJGCF: false, null);
			for (int j = 1; j < slotsWithItem2.Count; j += 0)
			{
				slotsWithItem2[j].HBMBGCHGEGN(slotsWithItem2[j].Stack);
			}
		}
	}

	private IEnumerator AGCDDCGFGOA()
	{
		EDGDFPPKGDL = null;
		ChumNPC.GGFJGHHHEJC.animationBase.SetTrigger("Drink");
		yield return CommonReferences.wait4;
		EDGDFPPKGDL = BrookDWittNPC.GGFJGHHHEJC;
		MDFALJKHKED = "Fortitude/MainEvent 4";
		if (instance.isActor)
		{
			BrookDWittNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "Fortitude/MainEvent 4");
		}
		else if (PlayerController.GetPlayer(1).LEOIMFNKFGA == Location.PirateShip)
		{
			((MonoBehaviour)instance).StartCoroutine(BrookDWittNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	public void HLGEJAANAGH()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.NMHNJLDAFAD(IBAFLJPMOCN: false));
		if (OnlineManager.MasterOrOffline() && TavernManager.IsOpen())
		{
			TavernManager.GGFJGHHHEJC.PHCLGNAFEFL(0, AODONKKHPBP: false);
		}
	}

	private IEnumerator GGMFKKJJHBJ()
	{
		EDGDFPPKGDL = null;
		if (OnlineManager.MasterOrOffline())
		{
			ChumNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePosition[2].position), Direction.Right, AMEOKNOLILB: true);
		}
		yield return CommonReferences.wait3;
		EDGDFPPKGDL = BrookDWittNPC.GGFJGHHHEJC;
		MDFALJKHKED = "Fortitude/MainEvent 5";
		yield return OnlineManager.WaitForAllPlayers();
		BrookDWittNPC.GGFJGHHHEJC.blockActionBar = false;
		EventsManager.SetActive(EventsManager.EventType.Fortitude, DMBFKFLDDLH: true);
		if (instance.isActor)
		{
			BrookDWittNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "Fortitude/MainEvent 5");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(BrookDWittNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	public override void ActivateEvent()
	{
		base.ActivateEvent();
		GJBNMNBAJIP();
		BrookDWittNPC brookDWittNPC = BrookDWittNPC.GGFJGHHHEJC;
		brookDWittNPC.ConversationStarted = (Action<bool>)Delegate.Combine(brookDWittNPC.ConversationStarted, new Action<bool>(AEEHFGIDCMJ));
	}

	private IEnumerator LMCKOFMMBDJ()
	{
		ChumNPC.GGFJGHHHEJC.animationBase.SetBool("Clean", EGFGNGJGBOP: false);
		if (OnlineManager.MasterOrOffline())
		{
			ChumNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePosition[0].position), Direction.Right);
		}
		yield return CommonReferences.wait3;
		EDGDFPPKGDL = BrookDWittNPC.GGFJGHHHEJC;
		MDFALJKHKED = "Fortitude/MainEvent 2";
		yield return OnlineManager.WaitForAllPlayers();
		if (instance.isActor)
		{
			BrookDWittNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "Fortitude/MainEvent 2");
		}
		else if (PlayerController.GetPlayer(1).LEOIMFNKFGA == Location.PirateShip)
		{
			((MonoBehaviour)instance).StartCoroutine(BrookDWittNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private void INICHFPEEBG(bool BFLCJPHHDJM)
	{
		instance.isActor = BFLCJPHHDJM;
		if (BFLCJPHHDJM && Utils.MMMFJPKECAB(Location.Tavern | Location.Road | Location.River | Location.Camp | Location.Farm | Location.FarmShop))
		{
			CJODOOFLLLB = BrookDWittNPC.MNFMOEKMJKN().EHHOHCPHAAO;
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: false);
		}
	}

	public void DBAPFCBGAFJ()
	{
		instance.KAMCIIAFCGI();
		if (OnlineManager.MasterOrOffline())
		{
			ChumNPC.EJHDHCNILDH().routine.noDisableOnReset = true;
			((Behaviour)ChumNPC.EJHDHCNILDH().routine).enabled = true;
		}
		((MonoBehaviour)instance).StartCoroutine(instance.LMCKOFMMBDJ());
		if (OnlineManager.PlayingOnline() && instance.isActor)
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 1);
		}
	}

	private IEnumerator POCNKFEBCBE(bool IBAFLJPMOCN)
	{
		return new CAILABENCLI(1)
		{
			restart = IBAFLJPMOCN
		};
	}

	public void ELACKHEGPHP()
	{
		instance.LPJAHGLEJCK();
		if (OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, -55);
		}
	}

	private void CHMFJHPILDO(bool BFLCJPHHDJM)
	{
		instance.isActor = BFLCJPHHDJM;
		if (BFLCJPHHDJM && Utils.MMMFJPKECAB(Location.River | Location.Camp | Location.Farm | Location.BarnInterior))
		{
			CJODOOFLLLB = BrookDWittNPC.OJJDNLEFNPJ().EHHOHCPHAAO;
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: true);
		}
	}

	private IEnumerator EGEKOAJJCKI()
	{
		return new NIGCDEEMEEK(1)
		{
			_003C_003E4__this = this
		};
	}

	private void ICBNFLJAMCH(int JIIGOACEIKL)
	{
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(ICBNFLJAMCH));
		instance.EDGDFPPKGDL = BrookDWittNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "PirateMinigame/Minigame";
		if (instance.isActor)
		{
			BrookDWittNPC.GGFJGHHHEJC.StartConversation(1, "PirateMinigame/Minigame");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(BrookDWittNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private IEnumerator MPJKFHOCDMM()
	{
		EDGDFPPKGDL = null;
		if (OnlineManager.MasterOrOffline())
		{
			PiratesGameManager.instance.SpawnACannonBallInPosition(PiratesGameManager.instance.cellPositions[2, 4]);
		}
		yield return CommonReferences.wait3;
		EDGDFPPKGDL = BrookDWittNPC.GGFJGHHHEJC;
		MDFALJKHKED = "PirateMinigame/Minigame2";
		yield return OnlineManager.WaitForAllPlayers();
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		if (instance.isActor)
		{
			BrookDWittNPC.GGFJGHHHEJC.StartConversation(1, "PirateMinigame/Minigame2");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(BrookDWittNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	public void IJJMIAENHFC()
	{
		FLMLLMHPJJA = false;
		BrookDWittNPC.EKDNJDJHONF().animationBase.CGEADHOLHCH("Advanced", EGFGNGJGBOP: true);
		if (OnlineManager.PGAGDFAEEFB())
		{
			BrookDWittNPC.LANAINBEMCM().StartConversation(1, "Disabled", FLHBPHPKIML: true);
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(BrookDWittNPC.MAIDHAPANEB().StartObserverDialogueWhenItIsPossible(0));
		}
	}

	private void AEEHFGIDCMJ(bool BFLCJPHHDJM)
	{
		instance.isActor = BFLCJPHHDJM;
		if (BFLCJPHHDJM && Utils.MMMFJPKECAB(Location.PirateShip))
		{
			CJODOOFLLLB = BrookDWittNPC.GGFJGHHHEJC.EHHOHCPHAAO;
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: true);
		}
	}

	private void LFIDBBIBAEE(int JIIGOACEIKL)
	{
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(0);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(AMFAFFJMOCH));
		instance.EDGDFPPKGDL = BrookDWittNPC.AJIGOHGPFPP();
		instance.MDFALJKHKED = "ReceiveKeyPuzzleSolved";
		if (instance.isActor)
		{
			BrookDWittNPC.LANAINBEMCM().StartConversation(0, "UIAddRemove", FLHBPHPKIML: true);
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(BrookDWittNPC.JHMAMLIPBNN().StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private IEnumerator HHGEKEKHDNK(int JIIGOACEIKL)
	{
		FadeCamera.GetPlayer(1).JDKHJJIOLOE -= HHGEKEKHDNK;
		yield return CommonReferences.wait2;
		if (OnlineManager.MasterOrOffline() && TavernManager.IsOpen())
		{
			TavernManager.GGFJGHHHEJC.SetOpen(1, AODONKKHPBP: false, AINPJHKNJGL: true);
		}
		instance.EDGDFPPKGDL = BrookDWittNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "Fortitude/MainEvent 6";
		yield return OnlineManager.WaitForAllPlayers();
		if (instance.isActor)
		{
			BrookDWittNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "Fortitude/MainEvent 6");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(BrookDWittNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private IEnumerator JGLLCGEAEBC()
	{
		EDGDFPPKGDL = null;
		if (OnlineManager.MasterOrOffline())
		{
			PiratesGameManager.instance.SpawnACannonBallInPosition(PiratesGameManager.instance.cellPositions[2, 4]);
		}
		yield return CommonReferences.wait3;
		EDGDFPPKGDL = BrookDWittNPC.GGFJGHHHEJC;
		MDFALJKHKED = "PirateMinigame/Minigame2";
		yield return OnlineManager.WaitForAllPlayers();
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		if (instance.isActor)
		{
			BrookDWittNPC.GGFJGHHHEJC.StartConversation(1, "PirateMinigame/Minigame2");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(BrookDWittNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private IEnumerator IDOIEOLMAGK()
	{
		return new PLLEFHILJEG(1)
		{
			_003C_003E4__this = this
		};
	}

	private void HGFDAFMPGLB(int JIIGOACEIKL)
	{
		((MonoBehaviour)instance).StartCoroutine(KEGBLGGIGJI(JIIGOACEIKL));
	}

	private IEnumerator CIAEMOGNDNE(int JIIGOACEIKL)
	{
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(GNCBHBEDKDL));
		PiratesGameManager.instance.FadeToBlackFinished(JIIGOACEIKL);
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		BrookDWittNPC.GGFJGHHHEJC.blockActionBar = false;
		PlayerController.GetPlayer(1).LEOIMFNKFGA = Location.PirateShip;
		yield return CommonReferences.wait1;
		yield return OnlineManager.WaitForAllPlayers();
		PlayerController.GetPlayer(1).gridController.disable = false;
		if (GameManager.LocalCoop())
		{
			PlayerController.GetPlayer(2).gridController.disable = false;
		}
		BrookDWittNPC.GGFJGHHHEJC.inSpecialEvent = true;
		if (instance.FLMLLMHPJJA)
		{
			if (OnlineManager.MasterOrOffline())
			{
				BrookDWittNPC.GGFJGHHHEJC.StartConversation(1, "PirateMinigame/Win2");
			}
		}
		else
		{
			instance.isStarted = false;
			if (OnlineManager.MasterOrOffline())
			{
				BrookDWittNPC.GGFJGHHHEJC.StartConversation(1, "PirateMinigame/Lose2");
			}
			SetDrunkOnLeft();
		}
		if (OnlineManager.ClientOnline())
		{
			((MonoBehaviour)instance).StartCoroutine(BrookDWittNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
		BrookDWittNPC.GGFJGHHHEJC.inSpecialEvent = false;
	}

	private IEnumerator JADOKNBNIDO()
	{
		return new NIGCDEEMEEK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator OCNCCAILJGG(bool IBAFLJPMOCN)
	{
		yield return CommonReferences.wait1;
		if (IBAFLJPMOCN)
		{
			PiratesGameManager.Restart();
		}
		else
		{
			PiratesGameManager.Begin(KPCHOCLAAIM: true, IPDJFMMIKEK: true);
		}
	}

	public void RestartGame()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.OCNCCAILJGG(IBAFLJPMOCN: true));
		if (OnlineManager.MasterOrOffline() && TavernManager.IsOpen())
		{
			TavernManager.GGFJGHHHEJC.SetOpen(1, AODONKKHPBP: false, AINPJHKNJGL: true);
		}
	}

	public void JKADNHCHPJB()
	{
		DialogueLua.SetVariable("itemRedWineJuice", (object)0);
		FLMLLMHPJJA = true;
		BrookDWittNPC.GFMBEDCANNI().animationBase.CGEADHOLHCH("Dialogue System/Conversation/AcceptRoomFirstFloor/Entry/2/Dialogue Text", EGFGNGJGBOP: false, HALNIEBONKH: true);
		if (OnlineManager.PGAGDFAEEFB())
		{
			BrookDWittNPC.MPJJAPCFENH().StartConversation(0, "00");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(BrookDWittNPC.ABHIDHPMLLD().StartObserverDialogueWhenItIsPossible(0));
		}
	}

	public void DGKFFDMHPIF()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.MPJKFHOCDMM());
		if (OnlineManager.PlayingOnline() && instance.isActor)
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 4);
		}
	}

	private IEnumerator OKOPHBAMEJJ(int JIIGOACEIKL)
	{
		FadeCamera.GetPlayer(1).JDKHJJIOLOE -= HHGEKEKHDNK;
		yield return CommonReferences.wait2;
		if (OnlineManager.MasterOrOffline() && TavernManager.IsOpen())
		{
			TavernManager.GGFJGHHHEJC.SetOpen(1, AODONKKHPBP: false, AINPJHKNJGL: true);
		}
		instance.EDGDFPPKGDL = BrookDWittNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "Fortitude/MainEvent 6";
		yield return OnlineManager.WaitForAllPlayers();
		if (instance.isActor)
		{
			BrookDWittNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "Fortitude/MainEvent 6");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(BrookDWittNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private void HIDCGEALAJP()
	{
		List<Slot> list = CraftingInventory.INLEBGJNNIB(1, ItemDatabaseAccessor.KMBGJEKCJFJ(101, GGBBJNBBLMF: false, DAINLFIMLIH: false), null, AKNBKINJGCF: false, null);
		for (int i = 1; i < list.Count; i++)
		{
			list[i].HBMBGCHGEGN(list[i].Stack);
		}
		if (GameManager.LocalCoop())
		{
			List<Slot> list2 = CraftingInventory.INLEBGJNNIB(2, ItemDatabaseAccessor.KMBGJEKCJFJ(53, GGBBJNBBLMF: true, DAINLFIMLIH: false), null, AKNBKINJGCF: true, null);
			for (int j = 1; j < list2.Count; j++)
			{
				list2[j].JPACDDCJGPD(list2[j].Stack, CDPAMNIPPEC: false, 1);
			}
		}
	}

	public override GameEvent GetInstance()
	{
		return instance;
	}

	public void JKNGMCLJDNK()
	{
		instance.EDGDFPPKGDL = null;
		PlayerController.GetPlayer(1).gridController.disable = true;
		if (GameManager.LocalCoop())
		{
			PlayerController.GetPlayer(5).gridController.disable = true;
		}
		PlayerInputs.CMEBIMMKIAB((MonoBehaviour)(object)instance);
		BrookDWittNPC.EKDNJDJHONF().blockActionBar = false;
		FadeCamera.EIFPKCAFDIB(0).FadeOut(201f);
		FadeCamera.EIFPKCAFDIB(0).ODBKGIJCHHI(GGFFENOKDCE);
		CommonReferences.GGFJGHHHEJC.tilemapsInfo.OECFODIGEDD(Location.None, 1);
		PlayerController.OPHDCMJLLEC(1).GEPOGLACOPO(Location.Road | Location.River);
		PiratesGameManager.instance.SetWeather(DIONNMLCIIC: false);
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(5).GPBOEBGJJPM(866f);
		}
		if (OnlineManager.PlayingOnline() && instance.isActor)
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 3);
		}
	}

	public void GPFMEPIDFKJ()
	{
		instance.EDGDFPPKGDL = null;
		if (OnlineManager.PGAGDFAEEFB())
		{
			ChumNPC.LKOABOAADCD().routine.noDisableOnReset = false;
			((Behaviour)ChumNPC.OACNNJCLEDE().routine).enabled = false;
		}
		PsaiCore.Instance.StopMusic(immediately: false);
		MusicController.instance.TriggerCurrentBasicMood(CommonReferences.wait12, Location.Road | Location.Farm | Location.FarmShop);
		PlayerInputs.CMEBIMMKIAB((MonoBehaviour)(object)instance, ANJCLPDCJHL: true);
		BrookDWittNPC.OJJDNLEFNPJ().blockActionBar = true;
		TravelZonesManager.GGFJGHHHEJC.IMKJEBFOBKK(~(Location.BarnInterior | Location.FarmShop), Location.Tavern | Location.Road | Location.River).KACGDPCMGPL(0);
		FadeCamera player = FadeCamera.GetPlayer(0);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(GNCBHBEDKDL));
		if (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(6) != (Object)null)
		{
			TravelZonesManager.GFMBEDCANNI().ECFDFECLDFK(Location.River | Location.Quarry | Location.Farm, ~(Location.Tavern | Location.Quarry)).StartTravelZone(7);
		}
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 8);
		}
	}
}
