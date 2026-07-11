using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Photon.Pun;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class FishCuttingEvent : GameEvent
{
	private enum LOGEKNJJJOB
	{
		CutTalk
	}

	[CompilerGenerated]
	private sealed class NHOKNDBFEAP : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FishCuttingEvent _003C_003E4__this;

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
		public NHOKNDBFEAP(int _003C_003E1__state)
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
			FishCuttingEvent fishCuttingEvent = _003C_003E4__this;
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
				_003C_003E1__state = -1;
				instance.EDGDFPPKGDL = KujakuNPC.GGFJGHHHEJC;
				instance.MDFALJKHKED = "FishCuttingEvent/Talk2";
				_003C_003E2__current = OnlineManager.WaitForAllPlayers();
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				if (OnlineManager.MasterOrOffline())
				{
					KujakuNPC.GGFJGHHHEJC.StartConversation(1, "FishCuttingEvent/Talk2");
				}
				else
				{
					((MonoBehaviour)fishCuttingEvent).StartCoroutine(KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
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
	private sealed class FMBNFKCJPKJ : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FishCuttingEvent _003C_003E4__this;

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
		public FMBNFKCJPKJ(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_009f: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			FishCuttingEvent fishCuttingEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				KujakuNPC.GGFJGHHHEJC.blockActionBar = false;
				break;
			case 1:
				_003C_003E1__state = -1;
				break;
			}
			if (Utils.NGLLIJPOBEC(Location.KujakuHouse))
			{
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			}
			if (OnlineManager.MasterOrOffline())
			{
				((Behaviour)instance.kujakuRoutine).enabled = true;
				fishCuttingEvent.kujakuRoutine.noDisableOnReset = false;
				PrecisionEvent.instance.awningManager.OnPlayerAwake();
			}
			PrecisionEvent.instance.kujakuSignal.SetActive(false);
			((Component)HikariNPC.GGFJGHHHEJC).transform.position = HikariNPC.GGFJGHHHEJC.beachPosition;
			HikariNPC.GGFJGHHHEJC.animationBase.SetBool("Rest", EGFGNGJGBOP: false);
			HikariNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Down);
			HikariNPC.GGFJGHHHEJC.DisableTalk(CAPPDENDLKP: false);
			HikariNPC.GGFJGHHHEJC.inScene = false;
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
	private sealed class JBBKNHOOPFM : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FishCuttingEvent _003C_003E4__this;

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
		public JBBKNHOOPFM(int _003C_003E1__state)
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
			FishCuttingEvent fishCuttingEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
			{
				_003C_003E1__state = -1;
				FadeCamera player = FadeCamera.GetPlayer(1);
				player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(fishCuttingEvent.GEHNCBAJNKP));
				_003C_003E2__current = OnlineManager.WaitForAllPlayers();
				_003C_003E1__state = 1;
				return true;
			}
			case 1:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait1_5;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				KujakuNPC.GGFJGHHHEJC.blockActionBar = true;
				instance.EDGDFPPKGDL = KujakuNPC.GGFJGHHHEJC;
				instance.MDFALJKHKED = "FishCuttingEvent/Talk1";
				if (OnlineManager.MasterOrOffline())
				{
					KujakuNPC.GGFJGHHHEJC.StartConversation(1, "FishCuttingEvent/Talk1");
				}
				else
				{
					((MonoBehaviour)fishCuttingEvent).StartCoroutine(KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
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
	private sealed class BKLBKCAAMJF : IEnumerator<object>, IEnumerator, IDisposable
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
		public BKLBKCAAMJF(int _003C_003E1__state)
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
				DialogueLua.SetVariable("LearnPrecision", (object)1);
				_003C_003E2__current = OnlineManager.WaitForAllPlayers();
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				if (OnlineManager.MasterOrOffline())
				{
					KujakuNPC.GGFJGHHHEJC.StartConversation(1, "FishCuttingEvent/Lose2");
				}
				else
				{
					((MonoBehaviour)instance).StartCoroutine(KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
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
	private sealed class NIMIPCCEKNG : IEnumerator<object>, IEnumerator, IDisposable
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
		public NIMIPCCEKNG(int _003C_003E1__state)
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
				_003C_003E2__current = OnlineManager.WaitForAllPlayers();
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				if (OnlineManager.MasterOrOffline())
				{
					KujakuNPC.GGFJGHHHEJC.StartConversation(1, "FishCuttingEvent/Win2");
				}
				else
				{
					((MonoBehaviour)instance).StartCoroutine(KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
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
	private sealed class BGIKAKHMMMP : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool skipFade;

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
		public BGIKAKHMMMP(int _003C_003E1__state)
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
				KujakuNPC.GGFJGHHHEJC.playerCanInteract = false;
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				KujakuNPC.GGFJGHHHEJC.playerCanInteract = true;
				if (OnlineManager.ClientOnline())
				{
					OnlineMinigameManager.RequestBeginFishCuttingMinigame();
				}
				else
				{
					FishCuttingGameManager.Begin(KPCHOCLAAIM: true, skipFade);
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
	private sealed class BNEMHHKGJPB : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FishCuttingEvent _003C_003E4__this;

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
		public BNEMHHKGJPB(int _003C_003E1__state)
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
			FishCuttingEvent fishCuttingEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				instance.EDGDFPPKGDL = null;
				if (OnlineManager.MasterOrOffline())
				{
					FishCuttingGameManager.instance.ThrowFish();
				}
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				fishCuttingEvent.MIHIENPCLFM();
				_003C_003E2__current = CommonReferences.wait3;
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
					KujakuNPC.GGFJGHHHEJC.StartConversation(1, "FishCuttingEvent/Talk3");
				}
				else
				{
					((MonoBehaviour)instance).StartCoroutine(KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
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

	public static FishCuttingEvent instance;

	public NPCRoutine kujakuRoutine;

	public Transform[] characterPositions;

	private Vector3 FLLEHNMOHGI;

	private IEnumerator FHAPPDGEACL()
	{
		return new BNEMHHKGJPB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void PJGJGBEADMB()
	{
		FishCuttingGameManager.instance.emotionsControllers[1].EMMBEAHMDHE("Idle");
		FishCuttingGameManager.instance.emotionsControllers[0].NMAPMPBAGMM("LE_10");
	}

	private IEnumerator PPKFJNCCFLH()
	{
		return new FMBNFKCJPKJ(1)
		{
			_003C_003E4__this = this
		};
	}

	private void IDKPDDOOJFN()
	{
		FishCuttingGameManager.instance.emotionsControllers[1].EMMBEAHMDHE("Items/item_description_661");
		FishCuttingGameManager.instance.emotionsControllers[1].EMMBEAHMDHE("/ExtraSettings.sd");
	}

	public void HMEJJKPMJAE()
	{
		if (OnlineManager.MasterOrOffline())
		{
			KujakuNPC.GGFJGHHHEJC.StartConversation(0, "ReciveStopConversationOnlineObjects");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(KujakuNPC.LANAINBEMCM().StartObserverDialogueWhenItIsPossible(0));
		}
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendStartObserveDialogue(CharacterName.None);
		}
	}

	private IEnumerator ADDDBFGMIPH()
	{
		instance.EDGDFPPKGDL = null;
		if (OnlineManager.MasterOrOffline())
		{
			FishCuttingGameManager.instance.ThrowFish();
		}
		yield return CommonReferences.wait2;
		MIHIENPCLFM();
		yield return CommonReferences.wait3;
		yield return OnlineManager.WaitForAllPlayers();
		if (OnlineManager.MasterOrOffline())
		{
			KujakuNPC.GGFJGHHHEJC.StartConversation(1, "FishCuttingEvent/Talk3");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
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
		if (JFNMCNCHMEO == 0)
		{
			CutTalk();
		}
	}

	private void HHGKJMPPGPL(int JIIGOACEIKL)
	{
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(ECFCKKKFKKO));
		((MonoBehaviour)instance).StartCoroutine(instance.HOLBHNPNIND());
	}

	private void JLKJGFMBPHM(int JIIGOACEIKL)
	{
		((MonoBehaviour)this).StartCoroutine(NCMFIFDHPCN());
	}

	private void AKKGKJPCHBF(int JIIGOACEIKL)
	{
		FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(0);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(JGAMCLDLJHC));
		((MonoBehaviour)instance).StartCoroutine(MJFEHLBELHN());
	}

	public void MBEGHGOFHHM()
	{
		TravelZonesManager.DCAEBALADIM().NKEBECDKDOO(~(Location.River | Location.Camp | Location.Farm | Location.FarmShop), ~(Location.Tavern | Location.Quarry)).StartTravelZone(1);
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(0);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Combine(fadeCamera.OnFadeFinished, new Action<int>(ECFCKKKFKKO));
		if (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(8) != (Object)null)
		{
			TravelZonesManager.OACNNJCLEDE().GetTravelZone(Location.Road | Location.FarmShop, ~(Location.Camp | Location.Quarry | Location.Farm | Location.BarnInterior)).StartTravelZone(6);
		}
		FishCuttingGameManager.instance.JGABBOEJKEJ();
		instance.DBFCELGHPLC();
		HikariNPC.EFPJLFMBPLL().DisableTalk(CAPPDENDLKP: false);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineEventsManager.AGHIGOKDCCL();
		}
	}

	protected override void Awake()
	{
		base.Awake();
		instance = this;
	}

	public void JPNJONBNJKP()
	{
		TravelZonesManager.OMFKNGDCJFN().NKEBECDKDOO(Location.Camp | Location.Quarry | Location.BarnInterior, ~(Location.Tavern | Location.Road | Location.Quarry | Location.BarnInterior)).KACGDPCMGPL(0);
		FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(1);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Combine(fadeCamera.OnFadeFinished, new Action<int>(LNBIHMOEDOE));
		if (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(4) != (Object)null)
		{
			TravelZonesManager.LKOABOAADCD().OFIPCMMKFLP(~(Location.River | Location.Quarry | Location.BarnInterior), ~(Location.Tavern | Location.Road | Location.FarmShop)).KACGDPCMGPL(4);
		}
		FishCuttingGameManager.instance.JGABBOEJKEJ();
		instance.DDFFBGGKCKE();
		instance.isStarted = true;
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendFishCuttingEventReturnToHouse();
		}
	}

	private void GDIPEIBGBDH(int JIIGOACEIKL)
	{
		((MonoBehaviour)this).StartCoroutine(PKNEFFFFDFD());
	}

	private IEnumerator CEOFANFPMCJ(bool IPDJFMMIKEK)
	{
		KujakuNPC.GGFJGHHHEJC.playerCanInteract = false;
		yield return CommonReferences.wait1;
		KujakuNPC.GGFJGHHHEJC.playerCanInteract = true;
		if (OnlineManager.ClientOnline())
		{
			OnlineMinigameManager.RequestBeginFishCuttingMinigame();
		}
		else
		{
			FishCuttingGameManager.Begin(KPCHOCLAAIM: true, IPDJFMMIKEK);
		}
	}

	public void DPOOKHLPCGI()
	{
		((MonoBehaviour)this).StartCoroutine(EHDBMLACMBA());
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 1);
		}
	}

	private IEnumerator PONDCFOIBPE()
	{
		yield return CommonReferences.wait1;
		yield return OnlineManager.WaitForAllPlayers();
		if (OnlineManager.MasterOrOffline())
		{
			KujakuNPC.GGFJGHHHEJC.StartConversation(1, "FishCuttingEvent/Win2");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private IEnumerator FPJFBEEODBM()
	{
		yield return CommonReferences.wait1;
		yield return OnlineManager.WaitForAllPlayers();
		if (OnlineManager.MasterOrOffline())
		{
			KujakuNPC.GGFJGHHHEJC.StartConversation(1, "FishCuttingEvent/Win2");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	public void ENFMBFAHMCJ()
	{
		if (OnlineManager.MasterOrOffline())
		{
			KujakuNPC.DEGPIHEEFHJ().StartConversation(1, "Multiplayer", FLHBPHPKIML: true);
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(KujakuNPC.NEFIEJALANL().StartObserverDialogueWhenItIsPossible(0));
		}
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.DOFFLLCJNPG(CharacterName.Thelonious);
		}
	}

	private IEnumerator BANEGAFPBAO()
	{
		return new JBBKNHOOPFM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator GDGJCNGOACP()
	{
		instance.EDGDFPPKGDL = null;
		if (OnlineManager.MasterOrOffline())
		{
			FishCuttingGameManager.instance.ThrowFish();
		}
		yield return CommonReferences.wait2;
		MIHIENPCLFM();
		yield return CommonReferences.wait3;
		yield return OnlineManager.WaitForAllPlayers();
		if (OnlineManager.MasterOrOffline())
		{
			KujakuNPC.GGFJGHHHEJC.StartConversation(1, "FishCuttingEvent/Talk3");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private void MLIAGMJABJB(int JIIGOACEIKL)
	{
		((MonoBehaviour)this).StartCoroutine(KOILPCPABLF());
	}

	private IEnumerator LEODAOIHAPB()
	{
		yield return CommonReferences.wait1;
		instance.EDGDFPPKGDL = KujakuNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "FishCuttingEvent/Talk2";
		yield return OnlineManager.WaitForAllPlayers();
		if (OnlineManager.MasterOrOffline())
		{
			KujakuNPC.GGFJGHHHEJC.StartConversation(1, "FishCuttingEvent/Talk2");
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	public void RestartMiniGameFromKujakuHouse()
	{
		((MonoBehaviour)instance).StartCoroutine(PBDJDOHNGBP(IPDJFMMIKEK: false));
	}

	private IEnumerator DNKGCHJBOGF()
	{
		return new NIMIPCCEKNG(1);
	}

	public void ICHJJIGGEOO()
	{
		((MonoBehaviour)instance).StartCoroutine(CEOFANFPMCJ(IPDJFMMIKEK: true));
	}

	private void NANFCJOJMFO(int JIIGOACEIKL)
	{
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(NANFCJOJMFO));
		((MonoBehaviour)instance).StartCoroutine(instance.FPJFBEEODBM());
	}

	public void MLMHFIBKPOI()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			KujakuNPC.EKDNJDJHONF().StartConversation(1, "UIBack");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(KujakuNPC.EKDNJDJHONF().StartObserverDialogueWhenItIsPossible(0));
		}
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineEventsManager.SendStartObserveDialogue(CharacterName.Kujaku);
		}
	}

	private void OMMFGCJJHCK(int JIIGOACEIKL)
	{
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(LNBIHMOEDOE));
		((MonoBehaviour)instance).StartCoroutine(OPFINNAPHLM());
	}

	public void LCLIIDDAJFK()
	{
		instance.EDGDFPPKGDL = null;
		FishCuttingGameManager.instance.blockSword = false;
		FishCuttingGameManager.instance.checkFirstSwordAction = false;
	}

	private void CIFMALAMEBL(int JIIGOACEIKL)
	{
		((MonoBehaviour)this).StartCoroutine(DOKOLLCNIIM());
	}

	public void CLFOFJANINL()
	{
		((MonoBehaviour)instance).StartCoroutine(CEOFANFPMCJ(IPDJFMMIKEK: false));
	}

	public void JGEIAPJGLDK()
	{
		TravelZonesManager.DGCNCEDIFOF().DAOACOMANPN(~(Location.Road | Location.River | Location.Camp | Location.Quarry), ~(Location.Road | Location.River | Location.Farm | Location.BarnInterior)).StartTravelZone(0);
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(MPKPLPGPDLM));
		if (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(4) != (Object)null)
		{
			TravelZonesManager.GFMBEDCANNI().IMKJEBFOBKK(Location.Tavern | Location.River | Location.BarnInterior, ~(Location.Tavern | Location.Quarry | Location.Farm | Location.FarmShop)).KACGDPCMGPL(0);
		}
		FishCuttingGameManager.instance.OHPNJMIGKKD();
		instance.DBFCELGHPLC();
		HikariNPC.EKDNJDJHONF().DisableTalk(CAPPDENDLKP: false);
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendFishCuttingWinEvent();
		}
	}

	private IEnumerator EILHMABDOKB()
	{
		return new BKLBKCAAMJF(1);
	}

	private IEnumerator KOILPCPABLF()
	{
		return new JBBKNHOOPFM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void IKAPHNJNBFJ(int JIIGOACEIKL)
	{
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(MPKPLPGPDLM));
		((MonoBehaviour)instance).StartCoroutine(instance.HMOPFDPFNDC());
	}

	public void PAKFOPEANAN()
	{
		TravelZonesManager.OMFKNGDCJFN().IMKJEBFOBKK(Location.Tavern | Location.Road | Location.Camp | Location.Quarry | Location.BarnInterior, Location.River | Location.Camp).StartTravelZone(1);
		FadeCamera player = FadeCamera.GetPlayer(0);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(AKKGKJPCHBF));
		if (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(7) != (Object)null)
		{
			TravelZonesManager.GGFJGHHHEJC.IMKJEBFOBKK(~(Location.Road | Location.River | Location.Quarry | Location.Farm | Location.BarnInterior), Location.Tavern | Location.River).StartTravelZone(0);
		}
		FishCuttingGameManager.instance.EndMiniGame();
		instance.ODBJHDEEPEB();
		instance.isStarted = false;
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineEventsManager.SendFishCuttingEventReturnToHouse();
		}
	}

	private void GJBNMNBAJIP()
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			kujakuRoutine.noDisableOnReset = true;
			((Behaviour)instance.kujakuRoutine).enabled = false;
		}
		PrecisionEvent.instance.kujakuSignal.SetActive(true);
		((Component)KujakuNPC.GGFJGHHHEJC).transform.position = characterPositions[0].position;
		KujakuNPC.GGFJGHHHEJC.content.SetActive(true);
		KujakuNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		((Component)HikariNPC.GGFJGHHHEJC).transform.position = characterPositions[1].position;
		HikariNPC.GGFJGHHHEJC.content.SetActive(true);
		HikariNPC.GGFJGHHHEJC.animationBase.SetBool("Rest", EGFGNGJGBOP: true, HALNIEBONKH: true);
		HikariNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Right);
		HikariNPC.GGFJGHHHEJC.inScene = true;
	}

	public void StartEventButton(bool CDPAMNIPPEC)
	{
		StartEvent(GFNHAMCPEAK: true, CDPAMNIPPEC);
	}

	public void EGPGAHHONEH()
	{
		TravelZonesManager.GFMBEDCANNI().DAOACOMANPN(Location.Tavern | Location.River | Location.Farm | Location.BarnInterior, ~(Location.Tavern | Location.Road | Location.River | Location.Camp | Location.Farm)).StartTravelZone(1);
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(NANFCJOJMFO));
		if (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(6) != (Object)null)
		{
			TravelZonesManager.OMFKNGDCJFN().JKPNCIFMAOO(Location.Tavern | Location.River | Location.Camp | Location.Farm | Location.BarnInterior, Location.Tavern | Location.Camp | Location.Quarry).StartTravelZone(3);
		}
		FishCuttingGameManager.instance.OHPNJMIGKKD();
		instance.ODBJHDEEPEB();
		HikariNPC.MNFMOEKMJKN().DisableTalk(CAPPDENDLKP: true);
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendFishCuttingWinEvent();
		}
	}

	private IEnumerator IOCIAGINCOP()
	{
		return new BKLBKCAAMJF(1);
	}

	private void DBFCELGHPLC()
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			kujakuRoutine.noDisableOnReset = true;
			((Behaviour)instance.kujakuRoutine).enabled = false;
		}
		PrecisionEvent.instance.kujakuSignal.SetActive(true);
		((Component)KujakuNPC.BADFKMEJOKE()).transform.position = characterPositions[1].position;
		KujakuNPC.MAAAKALBBEE().content.SetActive(true);
		KujakuNPC.DEGPIHEEFHJ().animationBase.SetDirection(Direction.Down);
		((Component)HikariNPC.GGFJGHHHEJC).transform.position = characterPositions[1].position;
		HikariNPC.EFPJLFMBPLL().content.SetActive(false);
		HikariNPC.ABDJJBFNLBJ().animationBase.CGEADHOLHCH(":\n", EGFGNGJGBOP: false);
		HikariNPC.EKDNJDJHONF().animationBase.SetDirection(Direction.Diagonal);
		HikariNPC.GGFJGHHHEJC.inScene = true;
	}

	public void CutTalk()
	{
		((MonoBehaviour)this).StartCoroutine(LEODAOIHAPB());
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
	}

	private IEnumerator GGDIFCHEKKM()
	{
		instance.EDGDFPPKGDL = null;
		if (OnlineManager.MasterOrOffline())
		{
			FishCuttingGameManager.instance.ThrowFish();
		}
		yield return CommonReferences.wait2;
		MIHIENPCLFM();
		yield return CommonReferences.wait3;
		yield return OnlineManager.WaitForAllPlayers();
		if (OnlineManager.MasterOrOffline())
		{
			KujakuNPC.GGFJGHHHEJC.StartConversation(1, "FishCuttingEvent/Talk3");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	public override void ActivateEvent()
	{
		base.ActivateEvent();
		GJBNMNBAJIP();
	}

	public void JPOHCLBHDAF()
	{
		((MonoBehaviour)instance).StartCoroutine(PBDJDOHNGBP(IPDJFMMIKEK: false));
	}

	public override void StartEvent(bool GFNHAMCPEAK, bool CDPAMNIPPEC)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		base.StartEvent(GFNHAMCPEAK, CDPAMNIPPEC);
		if (instance.FLLEHNMOHGI == Vector3.zero)
		{
			instance.FLLEHNMOHGI = PrecisionEvent.instance.hikariInitialPositions;
		}
		if (OnlineManager.MasterOrOffline() && TavernManager.IsOpen())
		{
			TavernManager.GGFJGHHHEJC.SetOpen(1, AODONKKHPBP: false, AINPJHKNJGL: true);
		}
		if ((Object)(object)FishCuttingGameManager.instance != (Object)null)
		{
			if (OnlineManager.MasterOrOffline())
			{
				FishCuttingGameManager.instance.blockSword = true;
				FishCuttingGameManager.instance.SetMinigame();
			}
			else if (OnlineManager.ClientOnline())
			{
				FishCuttingGameManager.instance.SetOnlinePlayerPosition();
				PlayerInputs.DisableKeyboardInputsAndMovement(1, (MonoBehaviour)(object)FishCuttingGameManager.instance);
				OnlineManager.SendPlayerPrepared(OnlinePlayerDataManager.GetBedAssignedByPlayerNum(1), (RpcTarget)1);
			}
		}
		DialogueCameraTarget.GetPlayer(1).DialogueCamController(JCFILMOCAKK: false);
		FadeCamera.GetPlayer(1).FadeInWithDelay();
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(GEHNCBAJNKP));
		if (GameManager.LocalCoop())
		{
			DialogueCameraTarget.GetPlayer(2).DialogueCamController(JCFILMOCAKK: false);
			FadeCamera.GetPlayer(2).FadeInWithDelay();
		}
	}

	public void FEBBBOOKOPA()
	{
		((MonoBehaviour)instance).StartCoroutine(FIHCOLOBNGB(IPDJFMMIKEK: true));
	}

	public override GameEvent GetInstance()
	{
		return instance;
	}

	public void GBGKDBMPCIK()
	{
		if (OnlineManager.MasterOrOffline())
		{
			KujakuNPC.MAAAKALBBEE().StartConversation(0, "Starting New Game Coroutine", FLHBPHPKIML: true);
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(KujakuNPC.MAAAKALBBEE().StartObserverDialogueWhenItIsPossible(1));
		}
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineEventsManager.SendStartObserveDialogue(CharacterName.Klayn);
		}
	}

	public void MLDHJFFEKPF()
	{
		if (OnlineManager.MasterOrOffline())
		{
			KujakuNPC.LANAINBEMCM().StartConversation(1, " could not be unlocked for reason: ", FLHBPHPKIML: true);
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(KujakuNPC.NEFIEJALANL().StartObserverDialogueWhenItIsPossible(1));
		}
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.DOFFLLCJNPG(CharacterName.Kyroh);
		}
	}

	private IEnumerator LJABJLDHLCB()
	{
		KujakuNPC.GGFJGHHHEJC.blockActionBar = false;
		while (Utils.NGLLIJPOBEC(Location.KujakuHouse))
		{
			yield return null;
		}
		if (OnlineManager.MasterOrOffline())
		{
			((Behaviour)instance.kujakuRoutine).enabled = true;
			kujakuRoutine.noDisableOnReset = false;
			PrecisionEvent.instance.awningManager.OnPlayerAwake();
		}
		PrecisionEvent.instance.kujakuSignal.SetActive(false);
		((Component)HikariNPC.GGFJGHHHEJC).transform.position = HikariNPC.GGFJGHHHEJC.beachPosition;
		HikariNPC.GGFJGHHHEJC.animationBase.SetBool("Rest", EGFGNGJGBOP: false);
		HikariNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Down);
		HikariNPC.GGFJGHHHEJC.DisableTalk(CAPPDENDLKP: false);
		HikariNPC.GGFJGHHHEJC.inScene = false;
	}

	public void JBPMKKBMIMA(bool CDPAMNIPPEC)
	{
		StartEvent(GFNHAMCPEAK: true, CDPAMNIPPEC);
	}

	private IEnumerator LFJDHKAEMJE()
	{
		return new NIMIPCCEKNG(1);
	}

	private IEnumerator PKNEFFFFDFD()
	{
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(GEHNCBAJNKP));
		yield return OnlineManager.WaitForAllPlayers();
		yield return CommonReferences.wait1_5;
		KujakuNPC.GGFJGHHHEJC.blockActionBar = true;
		instance.EDGDFPPKGDL = KujakuNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "FishCuttingEvent/Talk1";
		if (OnlineManager.MasterOrOffline())
		{
			KujakuNPC.GGFJGHHHEJC.StartConversation(1, "FishCuttingEvent/Talk1");
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	public void CMDAFCBJBBJ()
	{
		TravelZonesManager.DGCNCEDIFOF().KCJMDAPPJLB(~(Location.River | Location.Camp | Location.Quarry), ~(Location.Tavern | Location.River | Location.Farm)).KACGDPCMGPL(0);
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(1);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Combine(fadeCamera.OnFadeFinished, new Action<int>(LONJOCBMMIE));
		if (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(7) != (Object)null)
		{
			TravelZonesManager.LKOABOAADCD().IMKJEBFOBKK(Location.Farm | Location.BarnInterior, ~(Location.River | Location.Camp | Location.Quarry | Location.Farm)).KACGDPCMGPL(4);
		}
		FishCuttingGameManager.instance.EndMiniGame();
		instance.DBFCELGHPLC();
		instance.isStarted = true;
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineEventsManager.SendFishCuttingEventReturnToHouse();
		}
	}

	public void WinEvent()
	{
		TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Port, Location.KujakuHouse).StartTravelZone(1);
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(NANFCJOJMFO));
		if (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(2) != (Object)null)
		{
			TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Port, Location.KujakuHouse).StartTravelZone(2);
		}
		FishCuttingGameManager.instance.EndMiniGame();
		instance.GJBNMNBAJIP();
		HikariNPC.GGFJGHHHEJC.DisableTalk(CAPPDENDLKP: true);
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendFishCuttingWinEvent();
		}
	}

	private IEnumerator HMOPFDPFNDC()
	{
		yield return CommonReferences.wait1;
		yield return OnlineManager.WaitForAllPlayers();
		if (OnlineManager.MasterOrOffline())
		{
			KujakuNPC.GGFJGHHHEJC.StartConversation(1, "FishCuttingEvent/Win2");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private IEnumerator FLLICBCFENP()
	{
		instance.EDGDFPPKGDL = null;
		if (OnlineManager.MasterOrOffline())
		{
			FishCuttingGameManager.instance.ThrowFish();
		}
		yield return CommonReferences.wait2;
		MIHIENPCLFM();
		yield return CommonReferences.wait3;
		yield return OnlineManager.WaitForAllPlayers();
		if (OnlineManager.MasterOrOffline())
		{
			KujakuNPC.GGFJGHHHEJC.StartConversation(1, "FishCuttingEvent/Talk3");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	public void JEONLGODGLO()
	{
		((MonoBehaviour)instance).StartCoroutine(FIHCOLOBNGB(IPDJFMMIKEK: true));
	}

	public void HKEIGMABKEM()
	{
		((MonoBehaviour)instance).StartCoroutine(FIHCOLOBNGB(IPDJFMMIKEK: true));
	}

	public void LFPHPDMMPCO()
	{
		TravelZonesManager.BGMJCCFNNDL().KCJMDAPPJLB(Location.River | Location.Camp | Location.Quarry | Location.BarnInterior, ~(Location.Tavern | Location.Road | Location.Farm | Location.BarnInterior)).StartTravelZone(0);
		FadeCamera player = FadeCamera.GetPlayer(0);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(JGAMCLDLJHC));
		if (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(6) != (Object)null)
		{
			TravelZonesManager.OACNNJCLEDE().KCJMDAPPJLB(Location.Tavern | Location.Road | Location.River | Location.Quarry | Location.Farm | Location.FarmShop, Location.Road | Location.River | Location.Quarry | Location.Farm | Location.BarnInterior).KACGDPCMGPL(1);
		}
		FishCuttingGameManager.instance.JGABBOEJKEJ();
		instance.ODBJHDEEPEB();
		instance.isStarted = true;
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendFishCuttingEventReturnToHouse();
		}
	}

	public void LNLOPHLDNPD()
	{
		TravelZonesManager.EKDNJDJHONF().KCJMDAPPJLB(~(Location.Tavern | Location.Road | Location.River | Location.Farm | Location.FarmShop), Location.Tavern | Location.Farm | Location.BarnInterior).KACGDPCMGPL(0);
		FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(0);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Combine(fadeCamera.OnFadeFinished, new Action<int>(LONJOCBMMIE));
		if (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(2) != (Object)null)
		{
			TravelZonesManager.LKOABOAADCD().GetTravelZone(~(Location.Camp | Location.Quarry | Location.BarnInterior), ~Location.BarnInterior).KACGDPCMGPL(3);
		}
		FishCuttingGameManager.instance.OHPNJMIGKKD();
		instance.DDFFBGGKCKE();
		instance.isStarted = false;
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineEventsManager.SendFishCuttingEventReturnToHouse();
		}
	}

	public void BBBBLDAIGHC(bool CDPAMNIPPEC)
	{
		StartEvent(GFNHAMCPEAK: true, CDPAMNIPPEC);
	}

	public void FBKEMFMCEGH()
	{
		instance.EDGDFPPKGDL = null;
		FishCuttingGameManager.instance.blockSword = true;
		FishCuttingGameManager.instance.checkFirstSwordAction = false;
	}

	public void NANPAOAEMFA()
	{
		FishCuttingGameManager.instance.blockSword = true;
		FishCuttingGameManager.Begin();
	}

	private void GEHNCBAJNKP(int JIIGOACEIKL)
	{
		((MonoBehaviour)this).StartCoroutine(DOKOLLCNIIM());
	}

	private IEnumerator FNHLKOOCOKB()
	{
		yield return CommonReferences.wait1;
		instance.EDGDFPPKGDL = KujakuNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "FishCuttingEvent/Talk2";
		yield return OnlineManager.WaitForAllPlayers();
		if (OnlineManager.MasterOrOffline())
		{
			KujakuNPC.GGFJGHHHEJC.StartConversation(1, "FishCuttingEvent/Talk2");
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private IEnumerator HPMCONDECJF()
	{
		return new BKLBKCAAMJF(1);
	}

	public void LJHDOCCLICC()
	{
		TravelZonesManager.EKDNJDJHONF().IMKJEBFOBKK(~(Location.River | Location.Farm | Location.FarmShop), Location.Tavern | Location.River | Location.Camp | Location.Quarry | Location.Farm).StartTravelZone(0);
		FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(0);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Combine(fadeCamera.OnFadeFinished, new Action<int>(JJAEBIKGCEF));
		if (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(6) != (Object)null)
		{
			TravelZonesManager.DGCNCEDIFOF().GetTravelZone(Location.Tavern | Location.River | Location.Camp | Location.FarmShop, ~(Location.River | Location.Camp | Location.FarmShop)).StartTravelZone(1);
		}
		FishCuttingGameManager.instance.OHPNJMIGKKD();
		instance.DDFFBGGKCKE();
		HikariNPC.OFLELHKKNKC().DisableTalk(CAPPDENDLKP: true);
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.AGHIGOKDCCL();
		}
	}

	private void IJOJLLLEDNK(int JIIGOACEIKL)
	{
		FadeCamera player = FadeCamera.GetPlayer(0);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(ECFCKKKFKKO));
		((MonoBehaviour)instance).StartCoroutine(instance.FPJFBEEODBM());
	}

	private void LLGDPOAGOJI()
	{
		FishCuttingGameManager.instance.emotionsControllers[0].GPLECKGJFKM("Items/item_description_1086");
		FishCuttingGameManager.instance.emotionsControllers[0].PIOCPGKDAOF("Welcome to {0}!");
	}

	public void PFAHCFKKMBP()
	{
		((MonoBehaviour)this).StartCoroutine(KCPDIDIBJFF());
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
	}

	public void PKAECNMHFMK()
	{
		TravelZonesManager.OACNNJCLEDE().IMKJEBFOBKK(~(Location.Road | Location.BarnInterior | Location.FarmShop), Location.Road | Location.River | Location.FarmShop).StartTravelZone(1);
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(1);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Combine(fadeCamera.OnFadeFinished, new Action<int>(LNBIHMOEDOE));
		if (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(4) != (Object)null)
		{
			TravelZonesManager.DCAEBALADIM().DAOACOMANPN(~(Location.Tavern | Location.River | Location.Camp | Location.Quarry | Location.Farm | Location.FarmShop), Location.Tavern | Location.River).StartTravelZone(0);
		}
		FishCuttingGameManager.instance.EndMiniGame();
		instance.ODHBCLEHHFA();
		instance.isStarted = true;
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendFishCuttingEventReturnToHouse();
		}
	}

	public void BCGGIFAGMAL()
	{
		((MonoBehaviour)instance).StartCoroutine(FLLICBCFENP());
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendFishCuttingEventThrowScene();
		}
	}

	private IEnumerator NPLBGBMOIDJ()
	{
		return new NIMIPCCEKNG(1);
	}

	private IEnumerator LEDKIGHJMPO()
	{
		KujakuNPC.GGFJGHHHEJC.blockActionBar = false;
		while (Utils.NGLLIJPOBEC(Location.KujakuHouse))
		{
			yield return null;
		}
		if (OnlineManager.MasterOrOffline())
		{
			((Behaviour)instance.kujakuRoutine).enabled = true;
			kujakuRoutine.noDisableOnReset = false;
			PrecisionEvent.instance.awningManager.OnPlayerAwake();
		}
		PrecisionEvent.instance.kujakuSignal.SetActive(false);
		((Component)HikariNPC.GGFJGHHHEJC).transform.position = HikariNPC.GGFJGHHHEJC.beachPosition;
		HikariNPC.GGFJGHHHEJC.animationBase.SetBool("Rest", EGFGNGJGBOP: false);
		HikariNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Down);
		HikariNPC.GGFJGHHHEJC.DisableTalk(CAPPDENDLKP: false);
		HikariNPC.GGFJGHHHEJC.inScene = false;
	}

	public void PMHGKHMPEGC()
	{
		((MonoBehaviour)instance).StartCoroutine(FIHCOLOBNGB(IPDJFMMIKEK: true));
	}

	public void AMAPEDGLIFN()
	{
		((MonoBehaviour)instance).StartCoroutine(PBDJDOHNGBP(IPDJFMMIKEK: true));
	}

	public void PFKCEADHBOG(bool CDPAMNIPPEC)
	{
		StartEvent(GFNHAMCPEAK: true, CDPAMNIPPEC);
	}

	private void KIDDNGOMMJH()
	{
		FishCuttingGameManager.instance.emotionsControllers[0].DCCNJLBLFGI("Player");
		FishCuttingGameManager.instance.emotionsControllers[0].PIOCPGKDAOF("OnlinePlayer");
	}

	private IEnumerator FIHCOLOBNGB(bool IPDJFMMIKEK)
	{
		return new BGIKAKHMMMP(1)
		{
			skipFade = IPDJFMMIKEK
		};
	}

	private IEnumerator GCCEMJEJLLM()
	{
		KujakuNPC.GGFJGHHHEJC.blockActionBar = false;
		while (Utils.NGLLIJPOBEC(Location.KujakuHouse))
		{
			yield return null;
		}
		if (OnlineManager.MasterOrOffline())
		{
			((Behaviour)instance.kujakuRoutine).enabled = true;
			kujakuRoutine.noDisableOnReset = false;
			PrecisionEvent.instance.awningManager.OnPlayerAwake();
		}
		PrecisionEvent.instance.kujakuSignal.SetActive(false);
		((Component)HikariNPC.GGFJGHHHEJC).transform.position = HikariNPC.GGFJGHHHEJC.beachPosition;
		HikariNPC.GGFJGHHHEJC.animationBase.SetBool("Rest", EGFGNGJGBOP: false);
		HikariNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Down);
		HikariNPC.GGFJGHHHEJC.DisableTalk(CAPPDENDLKP: false);
		HikariNPC.GGFJGHHHEJC.inScene = false;
	}

	private IEnumerator PBDJDOHNGBP(bool IPDJFMMIKEK)
	{
		KujakuNPC.GGFJGHHHEJC.playerCanInteract = false;
		yield return CommonReferences.wait1;
		KujakuNPC.GGFJGHHHEJC.playerCanInteract = true;
		if (OnlineManager.ClientOnline())
		{
			OnlineMinigameManager.RequestBeginFishCuttingMinigame();
		}
		else
		{
			FishCuttingGameManager.Begin(KPCHOCLAAIM: true, IPDJFMMIKEK);
		}
	}

	public void ABJKLDGNPKD()
	{
		FishCuttingGameManager.instance.blockSword = false;
		FishCuttingGameManager.Begin(KPCHOCLAAIM: true);
	}

	public void CutScene()
	{
		instance.EDGDFPPKGDL = null;
		FishCuttingGameManager.instance.blockSword = false;
		FishCuttingGameManager.instance.checkFirstSwordAction = true;
	}

	public void JKDKJAFBPDK()
	{
		TravelZonesManager.BGMJCCFNNDL().DAOACOMANPN(~(Location.Road | Location.Farm), ~(Location.Tavern | Location.BarnInterior | Location.FarmShop)).KACGDPCMGPL(1);
		FadeCamera player = FadeCamera.GetPlayer(0);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(AKKGKJPCHBF));
		if (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(4) != (Object)null)
		{
			TravelZonesManager.OACNNJCLEDE().ECFDFECLDFK(~(Location.Tavern | Location.River | Location.Camp), Location.Tavern | Location.Road | Location.Quarry | Location.FarmShop).StartTravelZone(5);
		}
		FishCuttingGameManager.instance.JGABBOEJKEJ();
		instance.DDFFBGGKCKE();
		instance.isStarted = true;
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineEventsManager.SendFishCuttingEventReturnToHouse();
		}
	}

	public void HDGIGJJJHLL()
	{
		if (OnlineManager.MasterOrOffline())
		{
			KujakuNPC.EKDNJDJHONF().StartConversation(0, "Stop Music", FLHBPHPKIML: true);
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(KujakuNPC.DEGPIHEEFHJ().StartObserverDialogueWhenItIsPossible(1));
		}
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineEventsManager.SendStartObserveDialogue(CharacterName.Mai);
		}
	}

	public void PKEEPHKFECB(bool CDPAMNIPPEC)
	{
		StartEvent(GFNHAMCPEAK: false, CDPAMNIPPEC);
	}

	private IEnumerator NCMFIFDHPCN()
	{
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(GEHNCBAJNKP));
		yield return OnlineManager.WaitForAllPlayers();
		yield return CommonReferences.wait1_5;
		KujakuNPC.GGFJGHHHEJC.blockActionBar = true;
		instance.EDGDFPPKGDL = KujakuNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "FishCuttingEvent/Talk1";
		if (OnlineManager.MasterOrOffline())
		{
			KujakuNPC.GGFJGHHHEJC.StartConversation(1, "FishCuttingEvent/Talk1");
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	public void LPCDJLHDMEF()
	{
		((MonoBehaviour)this).StartCoroutine(FJGLOHHCCLP());
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 1);
		}
	}

	public void WinGame()
	{
		if (OnlineManager.MasterOrOffline())
		{
			KujakuNPC.GGFJGHHHEJC.StartConversation(1, "FishCuttingEvent/Win1");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendStartObserveDialogue(CharacterName.Kujaku);
		}
	}

	private void LONJOCBMMIE(int JIIGOACEIKL)
	{
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(LONJOCBMMIE));
		((MonoBehaviour)instance).StartCoroutine(CNMJNNIPFLG());
	}

	public void HGNNADHDEKN()
	{
		((MonoBehaviour)instance).StartCoroutine(CEOFANFPMCJ(IPDJFMMIKEK: false));
	}

	private void MPKPLPGPDLM(int JIIGOACEIKL)
	{
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(1);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(HHGKJMPPGPL));
		((MonoBehaviour)instance).StartCoroutine(instance.PONDCFOIBPE());
	}

	public void KJDIIJKJLIL(bool CDPAMNIPPEC)
	{
		StartEvent(GFNHAMCPEAK: true, CDPAMNIPPEC);
	}

	public void CMNIBABONPL()
	{
		((MonoBehaviour)instance).StartCoroutine(FIHCOLOBNGB(IPDJFMMIKEK: true));
	}

	private IEnumerator EHDBMLACMBA()
	{
		return new NHOKNDBFEAP(1)
		{
			_003C_003E4__this = this
		};
	}

	public void KFLBFOOAPCE()
	{
		if (OnlineManager.MasterOrOffline())
		{
			KujakuNPC.LANAINBEMCM().StartConversation(1, "talentBrown", FLHBPHPKIML: true);
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(KujakuNPC.MAAAKALBBEE().StartObserverDialogueWhenItIsPossible(0));
		}
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineEventsManager.SendStartObserveDialogue(CharacterName.Zuzzu);
		}
	}

	public void LLDCLPGFPKE(bool CDPAMNIPPEC)
	{
		StartEvent(GFNHAMCPEAK: true, CDPAMNIPPEC);
	}

	public void LLLCNPLNFAN()
	{
		instance.EDGDFPPKGDL = null;
		FishCuttingGameManager.instance.blockSword = false;
		FishCuttingGameManager.instance.checkFirstSwordAction = false;
	}

	private IEnumerator HOLBHNPNIND()
	{
		return new NIMIPCCEKNG(1);
	}

	private IEnumerator MLCBMGNACJH()
	{
		yield return CommonReferences.wait1;
		DialogueLua.SetVariable("LearnPrecision", (object)1);
		yield return OnlineManager.WaitForAllPlayers();
		if (OnlineManager.MasterOrOffline())
		{
			KujakuNPC.GGFJGHHHEJC.StartConversation(1, "FishCuttingEvent/Lose2");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	public void FHMDDOFJAGL()
	{
		((MonoBehaviour)instance).StartCoroutine(FNPPAICKBBI());
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineEventsManager.SendFishCuttingEventThrowScene();
		}
	}

	private IEnumerator FJGLOHHCCLP()
	{
		return new NHOKNDBFEAP(1)
		{
			_003C_003E4__this = this
		};
	}

	private void ODBJHDEEPEB()
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			kujakuRoutine.noDisableOnReset = true;
			((Behaviour)instance.kujakuRoutine).enabled = true;
		}
		PrecisionEvent.instance.kujakuSignal.SetActive(false);
		((Component)KujakuNPC.MAAAKALBBEE()).transform.position = characterPositions[1].position;
		KujakuNPC.LANAINBEMCM().content.SetActive(true);
		KujakuNPC.EKDNJDJHONF().animationBase.SetDirection(Direction.Down);
		((Component)HikariNPC.GGFJGHHHEJC).transform.position = characterPositions[0].position;
		HikariNPC.EFPJLFMBPLL().content.SetActive(true);
		HikariNPC.OFLELHKKNKC().animationBase.CGEADHOLHCH("Player", EGFGNGJGBOP: false);
		HikariNPC.ABDJJBFNLBJ().animationBase.SetDirection((Direction)6);
		HikariNPC.ABDJJBFNLBJ().inScene = true;
	}

	public void LoseGame()
	{
		if (OnlineManager.MasterOrOffline())
		{
			KujakuNPC.GGFJGHHHEJC.StartConversation(1, "FishCuttingEvent/Lose1");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendStartObserveDialogue(CharacterName.Kujaku);
		}
	}

	public void CKCDEOAHODF()
	{
		((MonoBehaviour)instance).StartCoroutine(GDGJCNGOACP());
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendFishCuttingEventThrowScene();
		}
	}

	private void JJAEBIKGCEF(int JIIGOACEIKL)
	{
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(1);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(IKAPHNJNBFJ));
		((MonoBehaviour)instance).StartCoroutine(instance.HOLBHNPNIND());
	}

	public void IPHEDLKPFIJ()
	{
		instance.EDGDFPPKGDL = null;
		FishCuttingGameManager.instance.blockSword = true;
		FishCuttingGameManager.instance.checkFirstSwordAction = true;
	}

	private IEnumerator FNPPAICKBBI()
	{
		instance.EDGDFPPKGDL = null;
		if (OnlineManager.MasterOrOffline())
		{
			FishCuttingGameManager.instance.ThrowFish();
		}
		yield return CommonReferences.wait2;
		MIHIENPCLFM();
		yield return CommonReferences.wait3;
		yield return OnlineManager.WaitForAllPlayers();
		if (OnlineManager.MasterOrOffline())
		{
			KujakuNPC.GGFJGHHHEJC.StartConversation(1, "FishCuttingEvent/Talk3");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private void ODHBCLEHHFA()
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			kujakuRoutine.noDisableOnReset = false;
			((Behaviour)instance.kujakuRoutine).enabled = false;
		}
		PrecisionEvent.instance.kujakuSignal.SetActive(true);
		((Component)KujakuNPC.DEGPIHEEFHJ()).transform.position = characterPositions[0].position;
		KujakuNPC.BADFKMEJOKE().content.SetActive(true);
		KujakuNPC.EKDNJDJHONF().animationBase.SetDirection(Direction.Down);
		((Component)HikariNPC.EFPJLFMBPLL()).transform.position = characterPositions[1].position;
		HikariNPC.OFLELHKKNKC().content.SetActive(true);
		HikariNPC.GGFJGHHHEJC.animationBase.SetBool(")", EGFGNGJGBOP: true);
		HikariNPC.EFPJLFMBPLL().animationBase.SetDirection(Direction.Right);
		HikariNPC.OFLELHKKNKC().inScene = false;
	}

	private IEnumerator GILGKPKLDPD()
	{
		KujakuNPC.GGFJGHHHEJC.blockActionBar = false;
		while (Utils.NGLLIJPOBEC(Location.KujakuHouse))
		{
			yield return null;
		}
		if (OnlineManager.MasterOrOffline())
		{
			((Behaviour)instance.kujakuRoutine).enabled = true;
			kujakuRoutine.noDisableOnReset = false;
			PrecisionEvent.instance.awningManager.OnPlayerAwake();
		}
		PrecisionEvent.instance.kujakuSignal.SetActive(false);
		((Component)HikariNPC.GGFJGHHHEJC).transform.position = HikariNPC.GGFJGHHHEJC.beachPosition;
		HikariNPC.GGFJGHHHEJC.animationBase.SetBool("Rest", EGFGNGJGBOP: false);
		HikariNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Down);
		HikariNPC.GGFJGHHHEJC.DisableTalk(CAPPDENDLKP: false);
		HikariNPC.GGFJGHHHEJC.inScene = false;
	}

	public void DDCDBKGIEKA()
	{
		((MonoBehaviour)this).StartCoroutine(FJGLOHHCCLP());
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
	}

	public void LENDKNJIHOG()
	{
		((MonoBehaviour)this).StartCoroutine(FJGLOHHCCLP());
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
	}

	private void JGAMCLDLJHC(int JIIGOACEIKL)
	{
		FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(1);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(PPGFBCBBGPG));
		((MonoBehaviour)instance).StartCoroutine(IOCIAGINCOP());
	}

	private void DEFOALNHHFP(int JIIGOACEIKL)
	{
		((MonoBehaviour)this).StartCoroutine(PKNEFFFFDFD());
	}

	public void IIPMCLEKDMM()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			KujakuNPC.LANAINBEMCM().StartConversation(1, "Smell");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(KujakuNPC.NEFIEJALANL().StartObserverDialogueWhenItIsPossible(0));
		}
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.DOFFLLCJNPG(CharacterName.Zuzzu);
		}
	}

	private IEnumerator CAJJOPOPHMA()
	{
		return new BKLBKCAAMJF(1);
	}

	public void MDFIPGHFMNN()
	{
		((MonoBehaviour)instance).StartCoroutine(PBDJDOHNGBP(IPDJFMMIKEK: false));
	}

	private IEnumerator CNMJNNIPFLG()
	{
		yield return CommonReferences.wait1;
		DialogueLua.SetVariable("LearnPrecision", (object)1);
		yield return OnlineManager.WaitForAllPlayers();
		if (OnlineManager.MasterOrOffline())
		{
			KujakuNPC.GGFJGHHHEJC.StartConversation(1, "FishCuttingEvent/Lose2");
		}
		else
		{
			((MonoBehaviour)instance).StartCoroutine(KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private IEnumerator DOKOLLCNIIM()
	{
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(GEHNCBAJNKP));
		yield return OnlineManager.WaitForAllPlayers();
		yield return CommonReferences.wait1_5;
		KujakuNPC.GGFJGHHHEJC.blockActionBar = true;
		instance.EDGDFPPKGDL = KujakuNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "FishCuttingEvent/Talk1";
		if (OnlineManager.MasterOrOffline())
		{
			KujakuNPC.GGFJGHHHEJC.StartConversation(1, "FishCuttingEvent/Talk1");
		}
		else
		{
			((MonoBehaviour)this).StartCoroutine(KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private IEnumerator OKBLMOFIJDN()
	{
		return new JBBKNHOOPFM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator KCPDIDIBJFF()
	{
		return new NHOKNDBFEAP(1)
		{
			_003C_003E4__this = this
		};
	}

	public void OALBMKGIEGL()
	{
		FishCuttingGameManager.instance.blockSword = true;
		FishCuttingGameManager.Begin();
	}

	public void CGINCCHMEHF(bool CDPAMNIPPEC)
	{
		StartEvent(GFNHAMCPEAK: true, CDPAMNIPPEC);
	}

	private void NIAHHEDHHLJ()
	{
		FishCuttingGameManager.instance.emotionsControllers[1].PIOCPGKDAOF("DiscusionMineros/Main");
		FishCuttingGameManager.instance.emotionsControllers[1].StartEmotion("UIInteract");
	}

	public void BCJOPKKKHFL()
	{
		((MonoBehaviour)instance).StartCoroutine(CEOFANFPMCJ(IPDJFMMIKEK: true));
	}

	private IEnumerator PELDDEMHMBC()
	{
		return new NIMIPCCEKNG(1);
	}

	private void LNNJMGAMBGN(int JIIGOACEIKL)
	{
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(1);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(MPKPLPGPDLM));
		((MonoBehaviour)instance).StartCoroutine(instance.HOLBHNPNIND());
	}

	public void ThrowScene()
	{
		((MonoBehaviour)instance).StartCoroutine(GGDIFCHEKKM());
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendFishCuttingEventThrowScene();
		}
	}

	public void LBPFEADMEIK()
	{
		((MonoBehaviour)this).StartCoroutine(EHDBMLACMBA());
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
	}

	private IEnumerator MJFEHLBELHN()
	{
		return new BKLBKCAAMJF(1);
	}

	public void EndTalk()
	{
		FishCuttingGameManager.instance.blockSword = false;
		FishCuttingGameManager.Begin(KPCHOCLAAIM: false, IPDJFMMIKEK: true);
	}

	private void DDFFBGGKCKE()
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			kujakuRoutine.noDisableOnReset = false;
			((Behaviour)instance.kujakuRoutine).enabled = true;
		}
		PrecisionEvent.instance.kujakuSignal.SetActive(true);
		((Component)KujakuNPC.LANAINBEMCM()).transform.position = characterPositions[0].position;
		KujakuNPC.DEGPIHEEFHJ().content.SetActive(false);
		KujakuNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
		((Component)HikariNPC.MNFMOEKMJKN()).transform.position = characterPositions[0].position;
		HikariNPC.ABDJJBFNLBJ().content.SetActive(true);
		HikariNPC.OFLELHKKNKC().animationBase.SetBool("Not enough money", EGFGNGJGBOP: true, HALNIEBONKH: true);
		HikariNPC.ABDJJBFNLBJ().animationBase.SetDirection((Direction)8);
		HikariNPC.EKDNJDJHONF().inScene = false;
	}

	private void ECFCKKKFKKO(int JIIGOACEIKL)
	{
		FadeCamera player = FadeCamera.GetPlayer(0);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(IJOJLLLEDNK));
		((MonoBehaviour)instance).StartCoroutine(instance.NPLBGBMOIDJ());
	}

	public void CMGOEGHONLF()
	{
		TravelZonesManager.GGFJGHHHEJC.OFIPCMMKFLP(~(Location.River | Location.Quarry | Location.Farm | Location.FarmShop), ~(Location.Road | Location.River | Location.Camp | Location.FarmShop)).StartTravelZone(0);
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(ECFCKKKFKKO));
		if (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(6) != (Object)null)
		{
			TravelZonesManager.DGCNCEDIFOF().JKPNCIFMAOO(Location.Tavern | Location.Camp, Location.Road | Location.River | Location.Quarry).KACGDPCMGPL(1);
		}
		FishCuttingGameManager.instance.OHPNJMIGKKD();
		instance.DDFFBGGKCKE();
		HikariNPC.GGFJGHHHEJC.DisableTalk(CAPPDENDLKP: true);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineEventsManager.SendFishCuttingWinEvent();
		}
	}

	private void MIHIENPCLFM()
	{
		FishCuttingGameManager.instance.emotionsControllers[0].StartEmotion("Dots");
		FishCuttingGameManager.instance.emotionsControllers[1].StartEmotion("Dots");
	}

	public void IELAHDHGMHF()
	{
		TravelZonesManager.OMFKNGDCJFN().ECFDFECLDFK(~(Location.Tavern | Location.Road | Location.Camp | Location.Quarry | Location.FarmShop), ~(Location.Tavern | Location.Road | Location.Camp | Location.Quarry | Location.FarmShop)).StartTravelZone(0);
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(0);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Combine(fadeCamera.OnFadeFinished, new Action<int>(HHGKJMPPGPL));
		if (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(5) != (Object)null)
		{
			TravelZonesManager.GGFJGHHHEJC.NKEBECDKDOO(Location.Quarry | Location.FarmShop, ~(Location.Road | Location.Camp | Location.Farm | Location.BarnInterior)).StartTravelZone(6);
		}
		FishCuttingGameManager.instance.JGABBOEJKEJ();
		instance.ODHBCLEHHFA();
		HikariNPC.MNFMOEKMJKN().DisableTalk(CAPPDENDLKP: true);
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.AGHIGOKDCCL();
		}
	}

	private IEnumerator JJAOGAAGLNC()
	{
		return new BKLBKCAAMJF(1);
	}

	private void PPGFBCBBGPG(int JIIGOACEIKL)
	{
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(JGAMCLDLJHC));
		((MonoBehaviour)instance).StartCoroutine(CAJJOPOPHMA());
	}

	public void AOIFKIJCAHN()
	{
		TravelZonesManager.DGCNCEDIFOF().JKPNCIFMAOO(Location.Quarry | Location.Farm, Location.Tavern | Location.Camp | Location.Farm | Location.BarnInterior).StartTravelZone(0);
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(IJOJLLLEDNK));
		if (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(8) != (Object)null)
		{
			TravelZonesManager.EKDNJDJHONF().DAOACOMANPN(~(Location.Tavern | Location.Quarry | Location.BarnInterior), ~(Location.Farm | Location.FarmShop)).StartTravelZone(8);
		}
		FishCuttingGameManager.instance.JGABBOEJKEJ();
		instance.GJBNMNBAJIP();
		HikariNPC.OFLELHKKNKC().DisableTalk(CAPPDENDLKP: false);
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineEventsManager.SendFishCuttingWinEvent();
		}
	}

	private IEnumerator OPFINNAPHLM()
	{
		return new BKLBKCAAMJF(1);
	}

	public void ReturnToHouse()
	{
		TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Port, Location.KujakuHouse).StartTravelZone(1);
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(LNBIHMOEDOE));
		if (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(2) != (Object)null)
		{
			TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Port, Location.KujakuHouse).StartTravelZone(2);
		}
		FishCuttingGameManager.instance.EndMiniGame();
		instance.GJBNMNBAJIP();
		instance.isStarted = false;
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendFishCuttingEventReturnToHouse();
		}
	}

	public override void EndEvent(bool BFLCJPHHDJM)
	{
		base.EndEvent(BFLCJPHHDJM);
		DialogueLua.SetVariable("LearnPrecision", (object)2);
		CommonReferences.GGFJGHHHEJC.OnActionDone(1, ActionDone.Precision);
		((MonoBehaviour)instance).StartCoroutine(instance.LJABJLDHLCB());
		if (OnlineManager.MasterOrOffline())
		{
			PlayerInventory.GetPlayer(1).AddItem(ItemDatabaseAccessor.GetItem(1815).JMDALJBNFML(), HMPDLIPFBGD: true);
		}
	}

	public void RestartMiniGame()
	{
		((MonoBehaviour)instance).StartCoroutine(PBDJDOHNGBP(IPDJFMMIKEK: true));
	}

	private void LNBIHMOEDOE(int JIIGOACEIKL)
	{
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(LNBIHMOEDOE));
		((MonoBehaviour)instance).StartCoroutine(CNMJNNIPFLG());
	}
}
