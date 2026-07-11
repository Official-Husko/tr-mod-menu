using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using PixelCrushers.DialogueSystem;
using UnityEngine;
using psai.net;

public class KyrohWaterfallEvent : GameEvent
{
	private enum LOGEKNJJJOB
	{
		StartFishAnimation,
		StartCutEvent,
		StartFlowerFX
	}

	[CompilerGenerated]
	private sealed class FHOPHJGCNAL : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public KyrohWaterfallEvent _003C_003E4__this;

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
		public FHOPHJGCNAL(int _003C_003E1__state)
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
			KyrohWaterfallEvent kyrohWaterfallEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				instance.EDGDFPPKGDL = null;
				KyrohNPC.GGFJGHHHEJC.animationBase.SetTrigger("Throw");
				_003C_003E2__current = CommonReferences.wait12;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				instance.EDGDFPPKGDL = KyrohNPC.GGFJGHHHEJC;
				instance.MDFALJKHKED = "NoEresDigno/EndEvent";
				_003C_003E2__current = OnlineManager.WaitForAllPlayers();
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				if (instance.isActor)
				{
					KyrohNPC.GGFJGHHHEJC.StartConversation(kyrohWaterfallEvent.CJODOOFLLLB, "NoEresDigno/EndEvent");
				}
				else if (OnlineManager.PlayingOnline() && kyrohWaterfallEvent.NPKJAEDIBCM())
				{
					_003C_003E2__current = KyrohNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
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
	private sealed class EJLBJHILOKN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public KyrohWaterfallEvent _003C_003E4__this;

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
		public EJLBJHILOKN(int _003C_003E1__state)
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
			KyrohWaterfallEvent @object = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
			{
				_003C_003E1__state = -1;
				TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Forest, Location.River);
				travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(@object.EAPLAJLIHBO));
				TravelZone travelZone2 = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Forest, Location.VampireHouse);
				travelZone2.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone2.OnTravelZoneTo, new Action<int>(@object.EAPLAJLIHBO));
				TravelZone travelZone3 = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Forest, Location.Camp);
				travelZone3.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone3.OnTravelZoneTo, new Action<int>(@object.EAPLAJLIHBO));
				instance.EDGDFPPKGDL = null;
				DialogueLua.SetVariable("MainProgress", (object)9);
				MissionsManager.instance.StartMission(310, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
				KyrohNPC.GGFJGHHHEJC.inSpecialEvent = false;
				KyrohNPC.GGFJGHHHEJC.blockActionBar = false;
				KyrohNPC.GGFJGHHHEJC.animationBase.SetBool("Fish", EGFGNGJGBOP: false);
				KyrohNPC.GGFJGHHHEJC.ActiveBigCollider(DMBFKFLDDLH: false);
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 1;
				return true;
			}
			case 1:
				_003C_003E1__state = -1;
				if (Utils.AHMPFOEGJHF(Location.Forest))
				{
					DialogueCameraTarget.GetPlayer(1).ReturnControlToCameraTarget();
				}
				if (GameManager.LocalCoop() && Utils.AHMPFOEGJHF(Location.Forest, 2))
				{
					DialogueCameraTarget.GetPlayer(2).ReturnControlToCameraTarget();
				}
				PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
				KyrohNPC.GGFJGHHHEJC.ChangeState(KyrohState.Inactive);
				((Component)KyrohNPC.GGFJGHHHEJC).transform.parent = null;
				KujakuShopEvent.instance.ActivateEvent();
				MothersRecipeEvent.instance.ActivateEvent();
				MusicController.instance.FadeOutClip(5f);
				MusicController.instance.TriggerCurrentBasicMood(CommonReferences.wait15, Location.Forest);
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
	private sealed class OECJFJIHNIC : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public KyrohWaterfallEvent _003C_003E4__this;

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
		public OECJFJIHNIC(int _003C_003E1__state)
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
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			KyrohWaterfallEvent kyrohWaterfallEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				if (kyrohWaterfallEvent.NPKJAEDIBCM(kyrohWaterfallEvent.CJODOOFLLLB))
				{
					instance.flowerFX.transform.position = instance.cameraPosition.position;
					instance.flowerBGFX.transform.position = instance.cameraPosition.position;
					instance.flowerFX.SetActive(true);
					instance.flowerBGFX.SetActive(true);
					((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(instance.VolumeFade());
					MultiAudioManager.PlayAudioObject(instance.flowerSound, instance.cameraPosition.position);
				}
				instance.EDGDFPPKGDL = null;
				_003C_003E2__current = CommonReferences.wait4;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				instance.EDGDFPPKGDL = KyrohNPC.GGFJGHHHEJC;
				instance.MDFALJKHKED = "NoEresDigno/EndEvent2";
				if (instance.isActor)
				{
					KyrohNPC.GGFJGHHHEJC.StartConversation(kyrohWaterfallEvent.CJODOOFLLLB, "NoEresDigno/EndEvent2");
				}
				else if (OnlineManager.PlayingOnline() && kyrohWaterfallEvent.NPKJAEDIBCM())
				{
					_003C_003E2__current = KyrohNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
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

	[CompilerGenerated]
	private sealed class AFPCFCEBHMH : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public KyrohWaterfallEvent _003C_003E4__this;

		private float _003ClerpTime_003E5__2;

		private float _003Celapsed_003E5__3;

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
		public AFPCFCEBHMH(int _003C_003E1__state)
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
			KyrohWaterfallEvent kyrohWaterfallEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				kyrohWaterfallEvent.KDNNBPNHDKC = PsaiCore.Instance.GetVolume();
				_003ClerpTime_003E5__2 = 0.2f;
				_003Celapsed_003E5__3 = 0f;
				goto IL_00a5;
			case 1:
				_003C_003E1__state = -1;
				goto IL_00a5;
			case 2:
				_003C_003E1__state = -1;
				_003ClerpTime_003E5__2 = 0.2f;
				_003Celapsed_003E5__3 = 0f;
				break;
			case 3:
				{
					_003C_003E1__state = -1;
					break;
				}
				IL_00a5:
				if (_003Celapsed_003E5__3 < _003ClerpTime_003E5__2)
				{
					_003Celapsed_003E5__3 += Time.unscaledDeltaTime;
					PsaiCore.Instance.SetVolume(Mathf.Lerp(kyrohWaterfallEvent.KDNNBPNHDKC, 0f, _003Celapsed_003E5__3 / _003ClerpTime_003E5__2));
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait5;
				_003C_003E1__state = 2;
				return true;
			}
			if (_003Celapsed_003E5__3 < _003ClerpTime_003E5__2)
			{
				_003Celapsed_003E5__3 += Time.unscaledDeltaTime;
				PsaiCore.Instance.SetVolume(Mathf.Lerp(0f, kyrohWaterfallEvent.KDNNBPNHDKC, _003Celapsed_003E5__3 / _003ClerpTime_003E5__2));
				_003C_003E2__current = null;
				_003C_003E1__state = 3;
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

	public static KyrohWaterfallEvent instance;

	public Transform kyrohPosition;

	public Transform rockParent;

	public GameObject flowerFX;

	public GameObject flowerBGFX;

	public AudioObject flowerSound;

	private float KDNNBPNHDKC;

	private void KDGFJEEEMLE()
	{
		PlayerInputs.CMEBIMMKIAB((MonoBehaviour)(object)instance);
		if (Object.op_Implicit((Object)(object)EDGDFPPKGDL))
		{
			((MonoBehaviour)this).StartCoroutine(EDGDFPPKGDL.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private void MHKMIKHMAED()
	{
		if (EventsManager.GGGECIBEKJG(EventsManager.EventType.KyrohWaterfall) && MissionsManager.instance.BHEDPICFPLG(118))
		{
			SetKyrohWaterfall();
		}
	}

	private void LDIJPDHIDNP()
	{
		((Component)KyrohNPC.OAPOJCODNCO()).transform.parent = rockParent;
		KyrohNPC.PBJDFFEFMKM().DEMLJLONDIN(DMBFKFLDDLH: false);
	}

	private void JKELFKLGGID()
	{
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		if (Object.op_Implicit((Object)(object)EDGDFPPKGDL))
		{
			((MonoBehaviour)this).StartCoroutine(EDGDFPPKGDL.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private void CAHANIAOAJN(int AAAIOBLCOFO)
	{
		PCPDOOPJCKE(1);
		KDGFJEEEMLE();
	}

	private void JFKEKEBJBCN(int AAAIOBLCOFO)
	{
		PCPDOOPJCKE(0);
		EBCDAEIPPAF();
	}

	private bool EFJJODEFIFI(int JIIGOACEIKL = 1)
	{
		return Utils.AHMPFOEGJHF(Location.Tavern | Location.River | Location.Camp | Location.Quarry | Location.BarnInterior, JIIGOACEIKL);
	}

	public IEnumerator GLDPCEFEKKM()
	{
		KDNNBPNHDKC = PsaiCore.Instance.GetVolume();
		float lerpTime2 = 0.2f;
		float elapsed2 = 0f;
		while (elapsed2 < lerpTime2)
		{
			elapsed2 += Time.unscaledDeltaTime;
			PsaiCore.Instance.SetVolume(Mathf.Lerp(KDNNBPNHDKC, 0f, elapsed2 / lerpTime2));
			yield return null;
		}
		yield return CommonReferences.wait5;
		lerpTime2 = 0.2f;
		elapsed2 = 0f;
		while (elapsed2 < lerpTime2)
		{
			elapsed2 += Time.unscaledDeltaTime;
			PsaiCore.Instance.SetVolume(Mathf.Lerp(0f, KDNNBPNHDKC, elapsed2 / lerpTime2));
			yield return null;
		}
	}

	private void EAIOBAHJGBE()
	{
		PlayerInputs.CMEBIMMKIAB((MonoBehaviour)(object)instance);
		if (Object.op_Implicit((Object)(object)EDGDFPPKGDL))
		{
			((MonoBehaviour)this).StartCoroutine(EDGDFPPKGDL.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	public IEnumerator HJLKFMGGMJJ()
	{
		return new AFPCFCEBHMH(1)
		{
			_003C_003E4__this = this
		};
	}

	private void FFNKHFGGODO(int AAAIOBLCOFO)
	{
		PCPDOOPJCKE(0);
		AIHGFNGIIHO();
	}

	private void IDHCLDEEHJN()
	{
		if (EventsManager.IsDone((EventsManager.EventType)4) && MissionsManager.instance.LKKDCLPBABN(-24))
		{
			LDIJPDHIDNP();
		}
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(PFIFBJCAHMD));
	}

	private void EKGLIHCAHOF()
	{
		((Component)KyrohNPC.KADHMEPDIKM()).transform.parent = rockParent;
		KyrohNPC.JLNBMNKJCHE().KONBEBIHFJE(DMBFKFLDDLH: true);
	}

	private void LFNENELHOGJ()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(KBIEPNJFMBF));
		if (OnlineManager.HHDBMDMFEMP())
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(IDHCLDEEHJN));
		}
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(OCCICJGKPLB));
	}

	public void JCNBGKEMDJI()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.HCEAJFCACNK());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 7);
		}
	}

	private void BGFCHEIOKOG()
	{
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(GDBOOAEIMFP));
		if (OnlineManager.HHDBMDMFEMP())
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(FPGCDCIFONG));
		}
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(KCGHNMFHMKE));
	}

	public IEnumerator AJBAPEJHAJG()
	{
		KDNNBPNHDKC = PsaiCore.Instance.GetVolume();
		float lerpTime2 = 0.2f;
		float elapsed2 = 0f;
		while (elapsed2 < lerpTime2)
		{
			elapsed2 += Time.unscaledDeltaTime;
			PsaiCore.Instance.SetVolume(Mathf.Lerp(KDNNBPNHDKC, 0f, elapsed2 / lerpTime2));
			yield return null;
		}
		yield return CommonReferences.wait5;
		lerpTime2 = 0.2f;
		elapsed2 = 0f;
		while (elapsed2 < lerpTime2)
		{
			elapsed2 += Time.unscaledDeltaTime;
			PsaiCore.Instance.SetVolume(Mathf.Lerp(0f, KDNNBPNHDKC, elapsed2 / lerpTime2));
			yield return null;
		}
	}

	public void NKNDDKIOICB()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		KyrohNPC.JFNOOMJMHCB().content.SetActive(true);
		((Component)KyrohNPC.GGFJGHHHEJC).transform.position = kyrohPosition.position;
		((Component)KyrohNPC.GGFJGHHHEJC).transform.parent = rockParent;
		KyrohNPC.JFNOOMJMHCB().content.SetActive(true);
		KyrohNPC.JFNOOMJMHCB().animationBase.CGEADHOLHCH("Player", EGFGNGJGBOP: false);
		KyrohNPC.JLNBMNKJCHE().DCAGOAIGEIG(DMBFKFLDDLH: true);
	}

	private void OEPGEENIGNN()
	{
		if (EventsManager.ALEMDEBCFDH(EventsManager.EventType.Scolding) && MissionsManager.instance.IsMissionActive(-14))
		{
			CPNFAFLECMB();
		}
	}

	public void PCPJMPKOJLO()
	{
		instance.EDGDFPPKGDL = null;
		if (OnlineManager.PGAGDFAEEFB())
		{
			KyrohNPC.OAPOJCODNCO().animationBase.CGEADHOLHCH("Decline", EGFGNGJGBOP: true);
			KyrohNPC.JLNBMNKJCHE().animationBase.CGEADHOLHCH("Items/item_description_1109", EGFGNGJGBOP: true, HALNIEBONKH: true);
		}
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 1);
		}
	}

	private bool PGMCFMHLPHP(int JIIGOACEIKL = 1)
	{
		return Utils.AHMPFOEGJHF(~(Location.Road | Location.FarmShop), JIIGOACEIKL);
	}

	private IEnumerator KNNFOBBGPOB()
	{
		return new FHOPHJGCNAL(1)
		{
			_003C_003E4__this = this
		};
	}

	private void HNMJNBJJJLN()
	{
		if (EventsManager.OOCOFHECMDA(EventsManager.EventType.CastleForm) && MissionsManager.instance.IsMissionActive(-173))
		{
			KMBGPFNMHDP();
		}
	}

	private void EFGDLMILNDG(bool GFNHAMCPEAK)
	{
		KyrohNPC kyrohNPC = KyrohNPC.OAPOJCODNCO();
		kyrohNPC.ConversationStarted = (Action<bool>)Delegate.Remove(kyrohNPC.ConversationStarted, new Action<bool>(MPNGOCJMPOI));
		CJODOOFLLLB = KyrohNPC.OAPOJCODNCO().EHHOHCPHAAO;
		if (GFNHAMCPEAK)
		{
			StartEvent(GFNHAMCPEAK, CDPAMNIPPEC: true);
		}
	}

	private void EBNENBFLEKB()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(LJBFGDCCAFG));
		if (OnlineManager.ClientOnline())
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(HMGDAAHHMFA));
		}
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(OCCICJGKPLB));
	}

	public void LDNEFAFMMHG()
	{
		if (OnlineManager.MasterOrOffline() && EventsManager.GGGECIBEKJG(EventsManager.EventType.AdventureContinues) && MissionsManager.instance.IsMissionActive(-180))
		{
			EKFKDPOAMFD();
		}
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(ADGKMLOOMBG));
	}

	private void HABGLBIJINF()
	{
		if (EventsManager.AEFHILOAEEE(EventsManager.EventType.Scolding) && MissionsManager.instance.LKKDCLPBABN(-9))
		{
			EKGLIHCAHOF();
		}
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(OJFHINNMELL));
	}

	public void CPNFAFLECMB()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		KyrohNPC.GGFJGHHHEJC.content.SetActive(true);
		((Component)KyrohNPC.GGFJGHHHEJC).transform.position = kyrohPosition.position;
		((Component)KyrohNPC.AGGAGCBAGLL()).transform.parent = rockParent;
		KyrohNPC.OAPOJCODNCO().content.SetActive(false);
		KyrohNPC.PBJDFFEFMKM().animationBase.CGEADHOLHCH(" ", EGFGNGJGBOP: true, HALNIEBONKH: true);
		KyrohNPC.KFGKCKCDMLG().DCAGOAIGEIG(DMBFKFLDDLH: false);
	}

	private void IGLPCPBNMCJ(bool GFNHAMCPEAK)
	{
		KyrohNPC kyrohNPC = KyrohNPC.AGGAGCBAGLL();
		kyrohNPC.ConversationStarted = (Action<bool>)Delegate.Remove(kyrohNPC.ConversationStarted, new Action<bool>(IGLPCPBNMCJ));
		CJODOOFLLLB = KyrohNPC.JFNOOMJMHCB().EHHOHCPHAAO;
		if (GFNHAMCPEAK)
		{
			StartEvent(GFNHAMCPEAK, CDPAMNIPPEC: false);
		}
	}

	public void StartFishAnimation()
	{
		instance.EDGDFPPKGDL = null;
		if (OnlineManager.MasterOrOffline())
		{
			KyrohNPC.GGFJGHHHEJC.animationBase.SetBool("Meditation", EGFGNGJGBOP: false);
			KyrohNPC.GGFJGHHHEJC.animationBase.SetBool("Fish", EGFGNGJGBOP: true);
		}
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
	}

	private void OILHJENGGEL()
	{
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(LJBFGDCCAFG));
		if (OnlineManager.ClientOnline())
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(FPGCDCIFONG));
		}
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(HNMJNBJJJLN));
	}

	private void HNEKMALGJPO()
	{
		if (EventsManager.OMNBJDPGPEN((EventsManager.EventType)4) && MissionsManager.instance.IsMissionActive(-17))
		{
			CPNFAFLECMB();
		}
	}

	private void GCLCBJDIBCB()
	{
		if (EventsManager.HGALHLALOKJ((EventsManager.EventType)4) && MissionsManager.instance.BHEDPICFPLG(107))
		{
			FFGKKJJBAOJ();
		}
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(OJFHINNMELL));
	}

	public IEnumerator BNJCJDJBCBM()
	{
		return new AFPCFCEBHMH(1)
		{
			_003C_003E4__this = this
		};
	}

	private void FFGKKJJBAOJ()
	{
		((Component)KyrohNPC.JLNBMNKJCHE()).transform.parent = rockParent;
		KyrohNPC.JFNOOMJMHCB().LIDENNPPDBJ(DMBFKFLDDLH: false);
	}

	private void JPMFAEMADHC()
	{
		if (EventsManager.OMNBJDPGPEN(EventsManager.EventType.OathFeast) && MissionsManager.instance.LKKDCLPBABN(35))
		{
			MAKDEEMPALC();
		}
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(HMGDAAHHMFA));
	}

	public void OKBKLIMPLMK()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.JECBCBODAIN());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 3);
		}
	}

	private IEnumerator JOHDDHDACHA()
	{
		if (NPKJAEDIBCM(CJODOOFLLLB))
		{
			instance.flowerFX.transform.position = instance.cameraPosition.position;
			instance.flowerBGFX.transform.position = instance.cameraPosition.position;
			instance.flowerFX.SetActive(true);
			instance.flowerBGFX.SetActive(true);
			((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(instance.VolumeFade());
			MultiAudioManager.PlayAudioObject(instance.flowerSound, instance.cameraPosition.position);
		}
		instance.EDGDFPPKGDL = null;
		yield return CommonReferences.wait4;
		instance.EDGDFPPKGDL = KyrohNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "NoEresDigno/EndEvent2";
		if (instance.isActor)
		{
			KyrohNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "NoEresDigno/EndEvent2");
		}
		else if (OnlineManager.PlayingOnline() && NPKJAEDIBCM())
		{
			yield return KyrohNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	public IEnumerator HEHNOCNBAGG()
	{
		return new AFPCFCEBHMH(1)
		{
			_003C_003E4__this = this
		};
	}

	private void HKNJCPEINBN()
	{
		PlayerInputs.CMEBIMMKIAB((MonoBehaviour)(object)instance);
		if (Object.op_Implicit((Object)(object)EDGDFPPKGDL))
		{
			((MonoBehaviour)this).StartCoroutine(EDGDFPPKGDL.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	protected override void Awake()
	{
		base.Awake();
		instance = this;
	}

	public void FGODFCKPNDJ()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		KyrohNPC.JLNBMNKJCHE().content.SetActive(true);
		((Component)KyrohNPC.AGGAGCBAGLL()).transform.position = kyrohPosition.position;
		((Component)KyrohNPC.KFGKCKCDMLG()).transform.parent = rockParent;
		KyrohNPC.KFGKCKCDMLG().content.SetActive(false);
		KyrohNPC.GGFJGHHHEJC.animationBase.SetBool("LE_20", EGFGNGJGBOP: false);
		KyrohNPC.JLNBMNKJCHE().CPMFHGGNLFN(DMBFKFLDDLH: true);
	}

	public void LGJMGOJKIBJ()
	{
		instance.EDGDFPPKGDL = null;
		if (OnlineManager.MasterOrOffline())
		{
			KyrohNPC.JFNOOMJMHCB().animationBase.SetBool(" PlayerNum: ", EGFGNGJGBOP: false);
			KyrohNPC.JLNBMNKJCHE().animationBase.CGEADHOLHCH("ReceiveRemoveItemInstanceOnTray", EGFGNGJGBOP: true, HALNIEBONKH: true);
		}
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
	}

	private void BLDAIACNMDM(bool GFNHAMCPEAK)
	{
		KyrohNPC kyrohNPC = KyrohNPC.KFGKCKCDMLG();
		kyrohNPC.ConversationStarted = (Action<bool>)Delegate.Remove(kyrohNPC.ConversationStarted, new Action<bool>(MPNGOCJMPOI));
		CJODOOFLLLB = KyrohNPC.JFNOOMJMHCB().EHHOHCPHAAO;
		if (GFNHAMCPEAK)
		{
			StartEvent(GFNHAMCPEAK, CDPAMNIPPEC: false);
		}
	}

	private void AIHGFNGIIHO()
	{
		PlayerInputs.CMEBIMMKIAB((MonoBehaviour)(object)instance, ANJCLPDCJHL: true);
		if (Object.op_Implicit((Object)(object)EDGDFPPKGDL))
		{
			((MonoBehaviour)this).StartCoroutine(EDGDFPPKGDL.StartObserverDialogueWhenItIsPossible(0));
		}
	}

	private void CGGCHKFKGHK(int AAAIOBLCOFO)
	{
		PCPDOOPJCKE(1);
		EAIOBAHJGBE();
	}

	private void PFIFBJCAHMD()
	{
		if (EventsManager.LOFKKDNOKNF(EventsManager.EventType.KlaynTavern) && MissionsManager.instance.LKKDCLPBABN(-155))
		{
			EKGLIHCAHOF();
		}
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(DDCPFCMCCPG));
	}

	private IEnumerator ILBCGHPLEMG()
	{
		return new FHOPHJGCNAL(1)
		{
			_003C_003E4__this = this
		};
	}

	public void MOJLOLPHLID()
	{
		if (OnlineManager.MasterOrOffline() && EventsManager.IsDone(EventsManager.EventType.OathFeast) && MissionsManager.instance.BHEDPICFPLG(-115))
		{
			CPNFAFLECMB();
		}
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(KBIEPNJFMBF));
	}

	private bool GNOOLPCCLJJ(int JIIGOACEIKL = 1)
	{
		return Utils.AHMPFOEGJHF(Location.Tavern | Location.Road | Location.Camp | Location.Farm | Location.BarnInterior, JIIGOACEIKL);
	}

	private IEnumerator DNCBBJFAKME()
	{
		instance.EDGDFPPKGDL = null;
		KyrohNPC.GGFJGHHHEJC.animationBase.SetTrigger("Throw");
		yield return CommonReferences.wait12;
		instance.EDGDFPPKGDL = KyrohNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "NoEresDigno/EndEvent";
		yield return OnlineManager.WaitForAllPlayers();
		if (instance.isActor)
		{
			KyrohNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "NoEresDigno/EndEvent");
		}
		else if (OnlineManager.PlayingOnline() && NPKJAEDIBCM())
		{
			yield return KyrohNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	public void KMBGPFNMHDP()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		KyrohNPC.PBJDFFEFMKM().content.SetActive(false);
		((Component)KyrohNPC.OAPOJCODNCO()).transform.position = kyrohPosition.position;
		((Component)KyrohNPC.KADHMEPDIKM()).transform.parent = rockParent;
		KyrohNPC.KFGKCKCDMLG().content.SetActive(true);
		KyrohNPC.JFNOOMJMHCB().animationBase.SetBool("itemMildAle", EGFGNGJGBOP: false, HALNIEBONKH: true);
		KyrohNPC.JLNBMNKJCHE().FJJDADFEIEL(DMBFKFLDDLH: false);
	}

	private bool JJOOGCLIAAE(int JIIGOACEIKL = 1)
	{
		return Utils.AHMPFOEGJHF(Location.Road | Location.River | Location.BarnInterior | Location.FarmShop, JIIGOACEIKL);
	}

	public void CKGFGEFDNEK()
	{
		if (OnlineManager.PGAGDFAEEFB() && EventsManager.OOCOFHECMDA(EventsManager.EventType.AdventureContinues) && MissionsManager.instance.BHEDPICFPLG(58))
		{
			SetKyrohWaterfall();
		}
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(LJBFGDCCAFG));
	}

	private void DDCPFCMCCPG()
	{
		if (EventsManager.IsDone(EventsManager.EventType.ThroneRoom) && MissionsManager.instance.LKKDCLPBABN(-136))
		{
			KNMLGGJINEC();
		}
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(DDCPFCMCCPG));
	}

	public void BGCLDLFJCMJ()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.JEDKMKKAINN());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 4);
		}
	}

	public void LJBFGDCCAFG()
	{
		if (OnlineManager.PGAGDFAEEFB() && EventsManager.AEFHILOAEEE(EventsManager.EventType.ThroneRoom) && MissionsManager.instance.LKKDCLPBABN(-37))
		{
			KMBGPFNMHDP();
		}
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(LJBFGDCCAFG));
	}

	private IEnumerator NHOHLNILMFI()
	{
		instance.EDGDFPPKGDL = null;
		KyrohNPC.GGFJGHHHEJC.animationBase.SetTrigger("Throw");
		yield return CommonReferences.wait12;
		instance.EDGDFPPKGDL = KyrohNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "NoEresDigno/EndEvent";
		yield return OnlineManager.WaitForAllPlayers();
		if (instance.isActor)
		{
			KyrohNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "NoEresDigno/EndEvent");
		}
		else if (OnlineManager.PlayingOnline() && NPKJAEDIBCM())
		{
			yield return KyrohNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private void MAKDEEMPALC()
	{
		((Component)KyrohNPC.GGFJGHHHEJC).transform.parent = rockParent;
		KyrohNPC.GGFJGHHHEJC.ActiveBigCollider(DMBFKFLDDLH: true);
	}

	public void NPKHIINPBPL()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		KyrohNPC.GGFJGHHHEJC.content.SetActive(false);
		((Component)KyrohNPC.KFGKCKCDMLG()).transform.position = kyrohPosition.position;
		((Component)KyrohNPC.AGGAGCBAGLL()).transform.parent = rockParent;
		KyrohNPC.PBJDFFEFMKM().content.SetActive(false);
		KyrohNPC.JFNOOMJMHCB().animationBase.SetBool("", EGFGNGJGBOP: true);
		KyrohNPC.OAPOJCODNCO().KONBEBIHFJE(DMBFKFLDDLH: true);
	}

	private IEnumerator BPGMOCOEFJA()
	{
		instance.EDGDFPPKGDL = null;
		KyrohNPC.GGFJGHHHEJC.animationBase.SetTrigger("Throw");
		yield return CommonReferences.wait12;
		instance.EDGDFPPKGDL = KyrohNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "NoEresDigno/EndEvent";
		yield return OnlineManager.WaitForAllPlayers();
		if (instance.isActor)
		{
			KyrohNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "NoEresDigno/EndEvent");
		}
		else if (OnlineManager.PlayingOnline() && NPKJAEDIBCM())
		{
			yield return KyrohNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private void KNMLGGJINEC()
	{
		((Component)KyrohNPC.KFGKCKCDMLG()).transform.parent = rockParent;
		KyrohNPC.JLNBMNKJCHE().DCAGOAIGEIG(DMBFKFLDDLH: true);
	}

	public void CBEJHDECPGH()
	{
		instance.EDGDFPPKGDL = null;
		if (OnlineManager.PGAGDFAEEFB())
		{
			KyrohNPC.OAPOJCODNCO().animationBase.CGEADHOLHCH("Dialogue System/Conversation/Gass_Quest/Entry/35/Dialogue Text", EGFGNGJGBOP: false);
			KyrohNPC.JLNBMNKJCHE().animationBase.SetBool("Loop", EGFGNGJGBOP: false, HALNIEBONKH: true);
		}
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
	}

	private IEnumerator ABCPMFDCIOI()
	{
		instance.EDGDFPPKGDL = null;
		KyrohNPC.GGFJGHHHEJC.animationBase.SetTrigger("Throw");
		yield return CommonReferences.wait12;
		instance.EDGDFPPKGDL = KyrohNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "NoEresDigno/EndEvent";
		yield return OnlineManager.WaitForAllPlayers();
		if (instance.isActor)
		{
			KyrohNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "NoEresDigno/EndEvent");
		}
		else if (OnlineManager.PlayingOnline() && NPKJAEDIBCM())
		{
			yield return KyrohNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private void Start()
	{
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(OnWorldLoaded));
		if (OnlineManager.ClientOnline())
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(FPGCDCIFONG));
		}
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(ALGOBMNPLIB));
	}

	private void MDBCHLMMBNM()
	{
		if (EventsManager.IsDone(EventsManager.EventType.KlaynTavern) && MissionsManager.instance.IsMissionActive(-156))
		{
			KHHIJEGHOOG();
		}
	}

	private IEnumerator JICPCECLPAF()
	{
		return new FHOPHJGCNAL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NDJMNAKAIKJ()
	{
		return new FHOPHJGCNAL(1)
		{
			_003C_003E4__this = this
		};
	}

	private void KJOJLHCDFPP()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(LJBFGDCCAFG));
		if (OnlineManager.HHDBMDMFEMP())
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(DDCPFCMCCPG));
		}
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(MHKMIKHMAED));
	}

	private void CFIIEJDJFPB()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(LDNEFAFMMHG));
		if (OnlineManager.ClientOnline())
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(IDHCLDEEHJN));
		}
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(HNEKMALGJPO));
	}

	public void AECLJDAJKAL()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.JOHDDHDACHA());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 7);
		}
	}

	private bool OGFDBNHDIBP(int JIIGOACEIKL = 1)
	{
		return Utils.AHMPFOEGJHF(Location.Quarry | Location.Farm, JIIGOACEIKL);
	}

	public void StartCutEvent()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.FFEMFHAJOME());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 1);
		}
	}

	private IEnumerator FDBPLNHMGFI()
	{
		return new FHOPHJGCNAL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator OBGLPDKBFKN()
	{
		return new FHOPHJGCNAL(1)
		{
			_003C_003E4__this = this
		};
	}

	private void EAPLAJLIHBO(int AAAIOBLCOFO)
	{
		PCPDOOPJCKE(1);
		JKELFKLGGID();
	}

	public void SetKyrohWaterfall()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		KyrohNPC.GGFJGHHHEJC.content.SetActive(false);
		((Component)KyrohNPC.GGFJGHHHEJC).transform.position = kyrohPosition.position;
		((Component)KyrohNPC.GGFJGHHHEJC).transform.parent = rockParent;
		KyrohNPC.GGFJGHHHEJC.content.SetActive(true);
		KyrohNPC.GGFJGHHHEJC.animationBase.SetBool("Meditation", EGFGNGJGBOP: true);
		KyrohNPC.GGFJGHHHEJC.ActiveBigCollider(DMBFKFLDDLH: true);
	}

	private void FPBKLAKFGDH(int AAAIOBLCOFO)
	{
		PCPDOOPJCKE(1);
		JKELFKLGGID();
	}

	private IEnumerator KPDPJMGLGJI()
	{
		return new EJLBJHILOKN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void EBCDAEIPPAF()
	{
		PlayerInputs.CMEBIMMKIAB((MonoBehaviour)(object)instance);
		if (Object.op_Implicit((Object)(object)EDGDFPPKGDL))
		{
			((MonoBehaviour)this).StartCoroutine(EDGDFPPKGDL.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	public override void ActivateEvent()
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		base.ActivateEvent();
		EDGDFPPKGDL = null;
		if (OnlineManager.MasterOrOffline())
		{
			KyrohNPC.GGFJGHHHEJC.content.SetActive(false);
		}
		KyrohNPC.GGFJGHHHEJC.content.SetActive(true);
		((Component)KyrohNPC.GGFJGHHHEJC).transform.position = kyrohPosition.position;
		((Component)KyrohNPC.GGFJGHHHEJC).transform.parent = rockParent;
		KyrohNPC.GGFJGHHHEJC.ChangeState(KyrohState.Idle);
		KyrohNPC.GGFJGHHHEJC.animationBase.SetBool("Meditation", EGFGNGJGBOP: true, HALNIEBONKH: true);
		KyrohNPC.GGFJGHHHEJC.ActiveBigCollider(DMBFKFLDDLH: true);
		KyrohNPC kyrohNPC = KyrohNPC.GGFJGHHHEJC;
		kyrohNPC.ConversationStarted = (Action<bool>)Delegate.Combine(kyrohNPC.ConversationStarted, new Action<bool>(AEEHFGIDCMJ));
	}

	public void ADGKMLOOMBG()
	{
		if (OnlineManager.PGAGDFAEEFB() && EventsManager.DOPLDNPIBPP(EventsManager.EventType.KlaynTavern) && MissionsManager.instance.BHEDPICFPLG(45))
		{
			SetKyrohWaterfall();
		}
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(PMHNOIOIKOH));
	}

	private void LKDDKBGBFOD()
	{
		PlayerInputs.CMEBIMMKIAB((MonoBehaviour)(object)instance);
		if (Object.op_Implicit((Object)(object)EDGDFPPKGDL))
		{
			((MonoBehaviour)this).StartCoroutine(EDGDFPPKGDL.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private void GOEGBOEMHLI()
	{
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(GDBOOAEIMFP));
		if (OnlineManager.HHDBMDMFEMP())
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(JPMFAEMADHC));
		}
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(IAPAKPNFAJF));
	}

	public void OnWorldLoaded()
	{
		if (OnlineManager.MasterOrOffline() && EventsManager.IsDone(EventsManager.EventType.KyrohWaterfall) && MissionsManager.instance.IsMissionActive(310))
		{
			SetKyrohWaterfall();
		}
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(OnWorldLoaded));
	}

	private bool EHIENLMFIEI(int JIIGOACEIKL = 1)
	{
		return Utils.AHMPFOEGJHF(~(Location.River | Location.Quarry), JIIGOACEIKL);
	}

	private IEnumerator JECBCBODAIN()
	{
		if (NPKJAEDIBCM(CJODOOFLLLB))
		{
			instance.flowerFX.transform.position = instance.cameraPosition.position;
			instance.flowerBGFX.transform.position = instance.cameraPosition.position;
			instance.flowerFX.SetActive(true);
			instance.flowerBGFX.SetActive(true);
			((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(instance.VolumeFade());
			MultiAudioManager.PlayAudioObject(instance.flowerSound, instance.cameraPosition.position);
		}
		instance.EDGDFPPKGDL = null;
		yield return CommonReferences.wait4;
		instance.EDGDFPPKGDL = KyrohNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "NoEresDigno/EndEvent2";
		if (instance.isActor)
		{
			KyrohNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "NoEresDigno/EndEvent2");
		}
		else if (OnlineManager.PlayingOnline() && NPKJAEDIBCM())
		{
			yield return KyrohNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	public IEnumerator OJJMIFFCKOK()
	{
		return new AFPCFCEBHMH(1)
		{
			_003C_003E4__this = this
		};
	}

	public void KHHIJEGHOOG()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		KyrohNPC.KFGKCKCDMLG().content.SetActive(false);
		((Component)KyrohNPC.GGFJGHHHEJC).transform.position = kyrohPosition.position;
		((Component)KyrohNPC.GGFJGHHHEJC).transform.parent = rockParent;
		KyrohNPC.OAPOJCODNCO().content.SetActive(true);
		KyrohNPC.PBJDFFEFMKM().animationBase.SetBool(" not found in OnlineEventsManager.", EGFGNGJGBOP: true, HALNIEBONKH: true);
		KyrohNPC.OAPOJCODNCO().AOKALFHINDA(DMBFKFLDDLH: false);
	}

	private void NABKHBDOMIH()
	{
		if (EventsManager.ALEMDEBCFDH(EventsManager.EventType.ThroneRoom) && MissionsManager.instance.IsMissionActive(170))
		{
			SetKyrohWaterfall();
		}
	}

	private void BPKKAIKAHAG()
	{
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		if (Object.op_Implicit((Object)(object)EDGDFPPKGDL))
		{
			((MonoBehaviour)this).StartCoroutine(EDGDFPPKGDL.StartObserverDialogueWhenItIsPossible(0));
		}
	}

	private bool NPDKICINMOG(int JIIGOACEIKL = 1)
	{
		return Utils.AHMPFOEGJHF(~(Location.Tavern | Location.Road | Location.Quarry | Location.FarmShop), JIIGOACEIKL);
	}

	public void BLAGGBIBEJE()
	{
		instance.EDGDFPPKGDL = null;
		if (OnlineManager.PGAGDFAEEFB())
		{
			KyrohNPC.JLNBMNKJCHE().animationBase.SetBool("Visita Nocturna/MaiDialogue 01", EGFGNGJGBOP: false, HALNIEBONKH: true);
			KyrohNPC.GGFJGHHHEJC.animationBase.SetBool("OnFloor", EGFGNGJGBOP: false, HALNIEBONKH: true);
		}
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 1);
		}
	}

	private void NDNBDEHFFJF()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(KBIEPNJFMBF));
		if (OnlineManager.HHDBMDMFEMP())
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(HMGDAAHHMFA));
		}
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(MHKMIKHMAED));
	}

	public override void StartEvent(bool GFNHAMCPEAK, bool CDPAMNIPPEC)
	{
		base.StartEvent(GFNHAMCPEAK, CDPAMNIPPEC);
		KyrohNPC kyrohNPC = KyrohNPC.GGFJGHHHEJC;
		kyrohNPC.ConversationStarted = (Action<bool>)Delegate.Remove(kyrohNPC.ConversationStarted, new Action<bool>(AEEHFGIDCMJ));
		KyrohNPC.GGFJGHHHEJC.ActiveBigCollider(DMBFKFLDDLH: false);
		if (NPKJAEDIBCM(CJODOOFLLLB))
		{
			PCPDOOPJCKE(CJODOOFLLLB);
		}
		if (GameManager.LocalCoop())
		{
			PrepareLocalCoop(Location.Forest);
		}
		if (instance.isActor || NPKJAEDIBCM(CJODOOFLLLB))
		{
			PlayerInputs.DisableKeyboardInputsAndMovement(CJODOOFLLLB, (MonoBehaviour)(object)instance);
		}
		KyrohNPC.GGFJGHHHEJC.inSpecialEvent = true;
		KyrohNPC.GGFJGHHHEJC.blockActionBar = true;
		EDGDFPPKGDL = KyrohNPC.GGFJGHHHEJC;
		MDFALJKHKED = "NoEresDigno/MainEvent";
		if (OnlineManager.PlayingOnline() && !NPKJAEDIBCM())
		{
			TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Forest, Location.River);
			travelZone.OnTravelZoneTo = (Action<int>)Delegate.Combine(travelZone.OnTravelZoneTo, new Action<int>(EAPLAJLIHBO));
			TravelZone travelZone2 = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Forest, Location.VampireHouse);
			travelZone2.OnTravelZoneTo = (Action<int>)Delegate.Combine(travelZone2.OnTravelZoneTo, new Action<int>(EAPLAJLIHBO));
			TravelZone travelZone3 = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Forest, Location.Camp);
			travelZone3.OnTravelZoneTo = (Action<int>)Delegate.Combine(travelZone3.OnTravelZoneTo, new Action<int>(EAPLAJLIHBO));
		}
		else if (!GFNHAMCPEAK && OnlineManager.PlayingOnline() && NPKJAEDIBCM())
		{
			((MonoBehaviour)this).StartCoroutine(KyrohNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	public void PMHNOIOIKOH()
	{
		if (OnlineManager.PGAGDFAEEFB() && EventsManager.HGALHLALOKJ(EventsManager.EventType.KujakuShop) && MissionsManager.instance.BHEDPICFPLG(-171))
		{
			CPNFAFLECMB();
		}
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(LJBFGDCCAFG));
	}

	private IEnumerator NAIHJAKNAEL()
	{
		return new OECJFJIHNIC(1)
		{
			_003C_003E4__this = this
		};
	}

	private void OJFHINNMELL()
	{
		if (EventsManager.DOPLDNPIBPP(EventsManager.EventType.CastleForm) && MissionsManager.instance.BHEDPICFPLG(-114))
		{
			KNMLGGJINEC();
		}
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(IDHCLDEEHJN));
	}

	private IEnumerator HCEAJFCACNK()
	{
		if (NPKJAEDIBCM(CJODOOFLLLB))
		{
			instance.flowerFX.transform.position = instance.cameraPosition.position;
			instance.flowerBGFX.transform.position = instance.cameraPosition.position;
			instance.flowerFX.SetActive(true);
			instance.flowerBGFX.SetActive(true);
			((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(instance.VolumeFade());
			MultiAudioManager.PlayAudioObject(instance.flowerSound, instance.cameraPosition.position);
		}
		instance.EDGDFPPKGDL = null;
		yield return CommonReferences.wait4;
		instance.EDGDFPPKGDL = KyrohNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "NoEresDigno/EndEvent2";
		if (instance.isActor)
		{
			KyrohNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "NoEresDigno/EndEvent2");
		}
		else if (OnlineManager.PlayingOnline() && NPKJAEDIBCM())
		{
			yield return KyrohNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private void KPDHGPEEOEN()
	{
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance, ANJCLPDCJHL: true);
		if (Object.op_Implicit((Object)(object)EDGDFPPKGDL))
		{
			((MonoBehaviour)this).StartCoroutine(EDGDFPPKGDL.StartObserverDialogueWhenItIsPossible(0));
		}
	}

	private void KCGHNMFHMKE()
	{
		if (EventsManager.OOCOFHECMDA(EventsManager.EventType.KyrohWaterfall) && MissionsManager.instance.BHEDPICFPLG(132))
		{
			CPNFAFLECMB();
		}
	}

	public void OCJICBLOILK()
	{
		instance.EDGDFPPKGDL = null;
		if (OnlineManager.PGAGDFAEEFB())
		{
			KyrohNPC.AGGAGCBAGLL().animationBase.CGEADHOLHCH("Trying to add a player that's already on the list.", EGFGNGJGBOP: false);
			KyrohNPC.KADHMEPDIKM().animationBase.SetBool("F1", EGFGNGJGBOP: true);
		}
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 1);
		}
	}

	private void IIECFBPNJIK()
	{
		PlayerInputs.CMEBIMMKIAB((MonoBehaviour)(object)instance, ANJCLPDCJHL: true);
		if (Object.op_Implicit((Object)(object)EDGDFPPKGDL))
		{
			((MonoBehaviour)this).StartCoroutine(EDGDFPPKGDL.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private void CLEOMLGKHPE()
	{
		if (EventsManager.GGGECIBEKJG(EventsManager.EventType.CastleForm) && MissionsManager.instance.BHEDPICFPLG(86))
		{
			KMBGPFNMHDP();
		}
	}

	public void EKFKDPOAMFD()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		KyrohNPC.KADHMEPDIKM().content.SetActive(true);
		((Component)KyrohNPC.JFNOOMJMHCB()).transform.position = kyrohPosition.position;
		((Component)KyrohNPC.JFNOOMJMHCB()).transform.parent = rockParent;
		KyrohNPC.JLNBMNKJCHE().content.SetActive(false);
		KyrohNPC.KADHMEPDIKM().animationBase.SetBool("0.#", EGFGNGJGBOP: true);
		KyrohNPC.GGFJGHHHEJC.LIDENNPPDBJ(DMBFKFLDDLH: false);
	}

	public void CCEALMOENKB()
	{
		instance.EDGDFPPKGDL = null;
		if (OnlineManager.MasterOrOffline())
		{
			KyrohNPC.JLNBMNKJCHE().animationBase.SetBool("BirdInteract", EGFGNGJGBOP: false, HALNIEBONKH: true);
			KyrohNPC.PBJDFFEFMKM().animationBase.SetBool("Dialogue System/Conversation/TooCold/Entry/2/Dialogue Text", EGFGNGJGBOP: false);
		}
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
	}

	private void FPGCDCIFONG()
	{
		if (EventsManager.IsDone(EventsManager.EventType.KyrohWaterfall) && MissionsManager.instance.IsMissionActive(310))
		{
			MAKDEEMPALC();
		}
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(FPGCDCIFONG));
	}

	private IEnumerator ALHIBPKDAMA()
	{
		if (NPKJAEDIBCM(CJODOOFLLLB))
		{
			instance.flowerFX.transform.position = instance.cameraPosition.position;
			instance.flowerBGFX.transform.position = instance.cameraPosition.position;
			instance.flowerFX.SetActive(true);
			instance.flowerBGFX.SetActive(true);
			((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(instance.VolumeFade());
			MultiAudioManager.PlayAudioObject(instance.flowerSound, instance.cameraPosition.position);
		}
		instance.EDGDFPPKGDL = null;
		yield return CommonReferences.wait4;
		instance.EDGDFPPKGDL = KyrohNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "NoEresDigno/EndEvent2";
		if (instance.isActor)
		{
			KyrohNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "NoEresDigno/EndEvent2");
		}
		else if (OnlineManager.PlayingOnline() && NPKJAEDIBCM())
		{
			yield return KyrohNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	public void MEIJBLPONFK()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.ILBCGHPLEMG());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 1);
		}
	}

	public IEnumerator PLBKHOMNCJJ()
	{
		return new AFPCFCEBHMH(1)
		{
			_003C_003E4__this = this
		};
	}

	public IEnumerator VolumeFade()
	{
		KDNNBPNHDKC = PsaiCore.Instance.GetVolume();
		float lerpTime2 = 0.2f;
		float elapsed2 = 0f;
		while (elapsed2 < lerpTime2)
		{
			elapsed2 += Time.unscaledDeltaTime;
			PsaiCore.Instance.SetVolume(Mathf.Lerp(KDNNBPNHDKC, 0f, elapsed2 / lerpTime2));
			yield return null;
		}
		yield return CommonReferences.wait5;
		lerpTime2 = 0.2f;
		elapsed2 = 0f;
		while (elapsed2 < lerpTime2)
		{
			elapsed2 += Time.unscaledDeltaTime;
			PsaiCore.Instance.SetVolume(Mathf.Lerp(0f, KDNNBPNHDKC, elapsed2 / lerpTime2));
			yield return null;
		}
	}

	private void EBPMNJKFNMD()
	{
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(MOJLOLPHLID));
		if (OnlineManager.ClientOnline())
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(GCLCBJDIBCB));
		}
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(ALGOBMNPLIB));
	}

	private void HPDBBGNGBHO()
	{
		((Component)KyrohNPC.JLNBMNKJCHE()).transform.parent = rockParent;
		KyrohNPC.JFNOOMJMHCB().KANODDKKEGJ(DMBFKFLDDLH: false);
	}

	private IEnumerator JEDKMKKAINN()
	{
		if (NPKJAEDIBCM(CJODOOFLLLB))
		{
			instance.flowerFX.transform.position = instance.cameraPosition.position;
			instance.flowerBGFX.transform.position = instance.cameraPosition.position;
			instance.flowerFX.SetActive(true);
			instance.flowerBGFX.SetActive(true);
			((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(instance.VolumeFade());
			MultiAudioManager.PlayAudioObject(instance.flowerSound, instance.cameraPosition.position);
		}
		instance.EDGDFPPKGDL = null;
		yield return CommonReferences.wait4;
		instance.EDGDFPPKGDL = KyrohNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "NoEresDigno/EndEvent2";
		if (instance.isActor)
		{
			KyrohNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "NoEresDigno/EndEvent2");
		}
		else if (OnlineManager.PlayingOnline() && NPKJAEDIBCM())
		{
			yield return KyrohNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private void IAPAKPNFAJF()
	{
		if (EventsManager.FDIHEFGPKFP(EventsManager.EventType.AdventureContinues) && MissionsManager.instance.BHEDPICFPLG(129))
		{
			FGODFCKPNDJ();
		}
	}

	public void KLEOBCIAPNA()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.NAIHJAKNAEL());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 3);
		}
	}

	public void HCEODPKLFKL()
	{
		instance.EDGDFPPKGDL = null;
		if (OnlineManager.MasterOrOffline())
		{
			KyrohNPC.KADHMEPDIKM().animationBase.SetBool("Send begin retry", EGFGNGJGBOP: true, HALNIEBONKH: true);
			KyrohNPC.GGFJGHHHEJC.animationBase.CGEADHOLHCH("Starting", EGFGNGJGBOP: false, HALNIEBONKH: true);
		}
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 1);
		}
	}

	public void LPOMHEJENIL()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.HCEAJFCACNK());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 1);
		}
	}

	public void OAAPNNEKKMO()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.FDBPLNHMGFI());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 1);
		}
	}

	private bool IHENONMLNAC(int JIIGOACEIKL = 1)
	{
		return Utils.AHMPFOEGJHF(~(Location.Road | Location.Camp | Location.Farm), JIIGOACEIKL);
	}

	public override void EndEvent(bool BGKCHMNJBLJ)
	{
		base.EndEvent(BGKCHMNJBLJ);
		((MonoBehaviour)instance).StartCoroutine(instance.OMDAAFBFMIE());
	}

	private IEnumerator AFHMCJHAFAJ()
	{
		return new EJLBJHILOKN(1)
		{
			_003C_003E4__this = this
		};
	}

	public override GameEvent GetInstance()
	{
		return instance;
	}

	public void StartFlowerFX()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.JEDKMKKAINN());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 2);
		}
	}

	private bool KKNHBBANGHG(int JIIGOACEIKL = 1)
	{
		return Utils.AHMPFOEGJHF(Location.Tavern | Location.Quarry | Location.Farm | Location.FarmShop, JIIGOACEIKL);
	}

	private IEnumerator OMDAAFBFMIE()
	{
		TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Forest, Location.River);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(EAPLAJLIHBO));
		TravelZone travelZone2 = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Forest, Location.VampireHouse);
		travelZone2.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone2.OnTravelZoneTo, new Action<int>(EAPLAJLIHBO));
		TravelZone travelZone3 = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Forest, Location.Camp);
		travelZone3.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone3.OnTravelZoneTo, new Action<int>(EAPLAJLIHBO));
		instance.EDGDFPPKGDL = null;
		DialogueLua.SetVariable("MainProgress", (object)9);
		MissionsManager.instance.StartMission(310, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		KyrohNPC.GGFJGHHHEJC.inSpecialEvent = false;
		KyrohNPC.GGFJGHHHEJC.blockActionBar = false;
		KyrohNPC.GGFJGHHHEJC.animationBase.SetBool("Fish", EGFGNGJGBOP: false);
		KyrohNPC.GGFJGHHHEJC.ActiveBigCollider(DMBFKFLDDLH: false);
		yield return CommonReferences.wait2;
		if (Utils.AHMPFOEGJHF(Location.Forest))
		{
			DialogueCameraTarget.GetPlayer(1).ReturnControlToCameraTarget();
		}
		if (GameManager.LocalCoop() && Utils.AHMPFOEGJHF(Location.Forest, 2))
		{
			DialogueCameraTarget.GetPlayer(2).ReturnControlToCameraTarget();
		}
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		KyrohNPC.GGFJGHHHEJC.ChangeState(KyrohState.Inactive);
		((Component)KyrohNPC.GGFJGHHHEJC).transform.parent = null;
		KujakuShopEvent.instance.ActivateEvent();
		MothersRecipeEvent.instance.ActivateEvent();
		MusicController.instance.FadeOutClip(5f);
		MusicController.instance.TriggerCurrentBasicMood(CommonReferences.wait15, Location.Forest);
	}

	private void GGGFENBPOFD()
	{
		((Component)KyrohNPC.AGGAGCBAGLL()).transform.parent = rockParent;
		KyrohNPC.KFGKCKCDMLG().CPMFHGGNLFN(DMBFKFLDDLH: true);
	}

	private IEnumerator FFEMFHAJOME()
	{
		instance.EDGDFPPKGDL = null;
		KyrohNPC.GGFJGHHHEJC.animationBase.SetTrigger("Throw");
		yield return CommonReferences.wait12;
		instance.EDGDFPPKGDL = KyrohNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "NoEresDigno/EndEvent";
		yield return OnlineManager.WaitForAllPlayers();
		if (instance.isActor)
		{
			KyrohNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "NoEresDigno/EndEvent");
		}
		else if (OnlineManager.PlayingOnline() && NPKJAEDIBCM())
		{
			yield return KyrohNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	public void GDBOOAEIMFP()
	{
		if (OnlineManager.MasterOrOffline() && EventsManager.GGGECIBEKJG(EventsManager.EventType.CastleForm) && MissionsManager.instance.BHEDPICFPLG(-160))
		{
			KMBGPFNMHDP();
		}
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(PMHNOIOIKOH));
	}

	public void AAHFFBOBNOA()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.JICPCECLPAF());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
	}

	private IEnumerator KOIFAOHDAEG()
	{
		TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Forest, Location.River);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(EAPLAJLIHBO));
		TravelZone travelZone2 = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Forest, Location.VampireHouse);
		travelZone2.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone2.OnTravelZoneTo, new Action<int>(EAPLAJLIHBO));
		TravelZone travelZone3 = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Forest, Location.Camp);
		travelZone3.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone3.OnTravelZoneTo, new Action<int>(EAPLAJLIHBO));
		instance.EDGDFPPKGDL = null;
		DialogueLua.SetVariable("MainProgress", (object)9);
		MissionsManager.instance.StartMission(310, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		KyrohNPC.GGFJGHHHEJC.inSpecialEvent = false;
		KyrohNPC.GGFJGHHHEJC.blockActionBar = false;
		KyrohNPC.GGFJGHHHEJC.animationBase.SetBool("Fish", EGFGNGJGBOP: false);
		KyrohNPC.GGFJGHHHEJC.ActiveBigCollider(DMBFKFLDDLH: false);
		yield return CommonReferences.wait2;
		if (Utils.AHMPFOEGJHF(Location.Forest))
		{
			DialogueCameraTarget.GetPlayer(1).ReturnControlToCameraTarget();
		}
		if (GameManager.LocalCoop() && Utils.AHMPFOEGJHF(Location.Forest, 2))
		{
			DialogueCameraTarget.GetPlayer(2).ReturnControlToCameraTarget();
		}
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		KyrohNPC.GGFJGHHHEJC.ChangeState(KyrohState.Inactive);
		((Component)KyrohNPC.GGFJGHHHEJC).transform.parent = null;
		KujakuShopEvent.instance.ActivateEvent();
		MothersRecipeEvent.instance.ActivateEvent();
		MusicController.instance.FadeOutClip(5f);
		MusicController.instance.TriggerCurrentBasicMood(CommonReferences.wait15, Location.Forest);
	}

	private void HMGDAAHHMFA()
	{
		if (EventsManager.OMNBJDPGPEN(EventsManager.EventType.AdventureContinues) && MissionsManager.instance.IsMissionActive(171))
		{
			GGGFENBPOFD();
		}
		OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
		onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Remove(onlineLoadManager.OnFinishedOnlineLoad, new Action(FPGCDCIFONG));
	}

	private void DFNAAECFDCD(int AAAIOBLCOFO)
	{
		PCPDOOPJCKE(0);
		KPDHGPEEOEN();
	}

	private bool NPKJAEDIBCM(int JIIGOACEIKL = 1)
	{
		return Utils.AHMPFOEGJHF(Location.Forest, JIIGOACEIKL);
	}

	public void HNOIJBPELOM()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.ILBCGHPLEMG());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 1);
		}
	}

	public void MLCKAJDFBFG()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.JECBCBODAIN());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 2);
		}
	}

	private void MPNGOCJMPOI(bool GFNHAMCPEAK)
	{
		KyrohNPC kyrohNPC = KyrohNPC.KFGKCKCDMLG();
		kyrohNPC.ConversationStarted = (Action<bool>)Delegate.Remove(kyrohNPC.ConversationStarted, new Action<bool>(IGLPCPBNMCJ));
		CJODOOFLLLB = KyrohNPC.KFGKCKCDMLG().EHHOHCPHAAO;
		if (GFNHAMCPEAK)
		{
			StartEvent(GFNHAMCPEAK, CDPAMNIPPEC: false);
		}
	}

	private void DJADNFCFHAG()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(PMHNOIOIKOH));
		if (OnlineManager.HHDBMDMFEMP())
		{
			OnlineLoadManager onlineLoadManager = OnlineLoadManager.instance;
			onlineLoadManager.OnFinishedOnlineLoad = (Action)Delegate.Combine(onlineLoadManager.OnFinishedOnlineLoad, new Action(DDCPFCMCCPG));
		}
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(OEPGEENIGNN));
	}

	public IEnumerator JDMMBFEGCKH()
	{
		return new AFPCFCEBHMH(1)
		{
			_003C_003E4__this = this
		};
	}

	private void OCCICJGKPLB()
	{
		if (EventsManager.FDIHEFGPKFP(EventsManager.EventType.AdventureContinues) && MissionsManager.instance.IsMissionActive(-10))
		{
			NPKHIINPBPL();
		}
	}

	private void NODJAHPIJGK(int AAAIOBLCOFO)
	{
		PCPDOOPJCKE(0);
		BPKKAIKAHAG();
	}

	private IEnumerator NIMGNBHHFKM()
	{
		if (NPKJAEDIBCM(CJODOOFLLLB))
		{
			instance.flowerFX.transform.position = instance.cameraPosition.position;
			instance.flowerBGFX.transform.position = instance.cameraPosition.position;
			instance.flowerFX.SetActive(true);
			instance.flowerBGFX.SetActive(true);
			((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(instance.VolumeFade());
			MultiAudioManager.PlayAudioObject(instance.flowerSound, instance.cameraPosition.position);
		}
		instance.EDGDFPPKGDL = null;
		yield return CommonReferences.wait4;
		instance.EDGDFPPKGDL = KyrohNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "NoEresDigno/EndEvent2";
		if (instance.isActor)
		{
			KyrohNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "NoEresDigno/EndEvent2");
		}
		else if (OnlineManager.PlayingOnline() && NPKJAEDIBCM())
		{
			yield return KyrohNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	public void DDBLPCHAEHN()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.HCEAJFCACNK());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 8);
		}
	}

	public void KBIEPNJFMBF()
	{
		if (OnlineManager.MasterOrOffline() && EventsManager.OOCOFHECMDA(EventsManager.EventType.KujakuShop) && MissionsManager.instance.BHEDPICFPLG(-160))
		{
			SetKyrohWaterfall();
		}
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(GDBOOAEIMFP));
	}

	private bool GBEKAGDEKAF(int JIIGOACEIKL = 1)
	{
		return Utils.AHMPFOEGJHF(Location.Road | Location.Farm | Location.BarnInterior, JIIGOACEIKL);
	}

	private IEnumerator DILOCKBJIEC()
	{
		return new EJLBJHILOKN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void ALGOBMNPLIB()
	{
		if (EventsManager.IsDone(EventsManager.EventType.KyrohWaterfall) && MissionsManager.instance.IsMissionActive(310))
		{
			SetKyrohWaterfall();
		}
	}

	private void AEEHFGIDCMJ(bool GFNHAMCPEAK)
	{
		KyrohNPC kyrohNPC = KyrohNPC.GGFJGHHHEJC;
		kyrohNPC.ConversationStarted = (Action<bool>)Delegate.Remove(kyrohNPC.ConversationStarted, new Action<bool>(AEEHFGIDCMJ));
		CJODOOFLLLB = KyrohNPC.GGFJGHHHEJC.EHHOHCPHAAO;
		if (GFNHAMCPEAK)
		{
			StartEvent(GFNHAMCPEAK, CDPAMNIPPEC: true);
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
		case LOGEKNJJJOB.StartFishAnimation:
			StartFishAnimation();
			break;
		case LOGEKNJJJOB.StartCutEvent:
			StartCutEvent();
			break;
		case LOGEKNJJJOB.StartFlowerFX:
			StartFlowerFX();
			break;
		}
	}

	public void NCKNNHGBEKO()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.KNNFOBBGPOB());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 1);
		}
	}

	public void IBIMCLOKMEM()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.HCEAJFCACNK());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 7);
		}
	}

	private IEnumerator APNBNCLIOPJ()
	{
		TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Forest, Location.River);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(EAPLAJLIHBO));
		TravelZone travelZone2 = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Forest, Location.VampireHouse);
		travelZone2.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone2.OnTravelZoneTo, new Action<int>(EAPLAJLIHBO));
		TravelZone travelZone3 = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Forest, Location.Camp);
		travelZone3.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone3.OnTravelZoneTo, new Action<int>(EAPLAJLIHBO));
		instance.EDGDFPPKGDL = null;
		DialogueLua.SetVariable("MainProgress", (object)9);
		MissionsManager.instance.StartMission(310, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		KyrohNPC.GGFJGHHHEJC.inSpecialEvent = false;
		KyrohNPC.GGFJGHHHEJC.blockActionBar = false;
		KyrohNPC.GGFJGHHHEJC.animationBase.SetBool("Fish", EGFGNGJGBOP: false);
		KyrohNPC.GGFJGHHHEJC.ActiveBigCollider(DMBFKFLDDLH: false);
		yield return CommonReferences.wait2;
		if (Utils.AHMPFOEGJHF(Location.Forest))
		{
			DialogueCameraTarget.GetPlayer(1).ReturnControlToCameraTarget();
		}
		if (GameManager.LocalCoop() && Utils.AHMPFOEGJHF(Location.Forest, 2))
		{
			DialogueCameraTarget.GetPlayer(2).ReturnControlToCameraTarget();
		}
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		KyrohNPC.GGFJGHHHEJC.ChangeState(KyrohState.Inactive);
		((Component)KyrohNPC.GGFJGHHHEJC).transform.parent = null;
		KujakuShopEvent.instance.ActivateEvent();
		MothersRecipeEvent.instance.ActivateEvent();
		MusicController.instance.FadeOutClip(5f);
		MusicController.instance.TriggerCurrentBasicMood(CommonReferences.wait15, Location.Forest);
	}
}
