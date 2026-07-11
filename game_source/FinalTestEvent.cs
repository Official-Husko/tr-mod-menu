using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class FinalTestEvent : GameEvent
{
	private enum LOGEKNJJJOB
	{
		StandEvent
	}

	[CompilerGenerated]
	private sealed class KKBMPMFGHLI : IEnumerator<object>, IEnumerator, IDisposable
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
		public KKBMPMFGHLI(int _003C_003E1__state)
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
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				KyrohNPC.GGFJGHHHEJC.content.SetActive(false);
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
	private sealed class FILPNADCGKG : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FinalTestEvent _003C_003E4__this;

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
		public FILPNADCGKG(int _003C_003E1__state)
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
			FinalTestEvent finalTestEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				Debug.Log((object)"FinalTestEvent SetEventCoroutine");
				break;
			case 1:
				_003C_003E1__state = -1;
				break;
			}
			if (WorldTime.EDIPJBOOEHD > (float)(3 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.EDIPJBOOEHD < (float)(20 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR))
			{
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			}
			finalTestEvent.DGDFPIJKDKA();
			finalTestEvent.MCIBOCGJLGN = null;
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
	private sealed class DGLBPJLOBCN : IEnumerator<object>, IEnumerator, IDisposable
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
		public DGLBPJLOBCN(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				instance.EDGDFPPKGDL = null;
				KyrohNPC.GGFJGHHHEJC.animationBase.SetBool("Meditation", EGFGNGJGBOP: false);
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				KyrohNPC.GGFJGHHHEJC.inSpecialEvent = false;
				KyrohNPC.GGFJGHHHEJC.blockActionBar = false;
				instance.EDGDFPPKGDL = KyrohNPC.GGFJGHHHEJC;
				instance.MDFALJKHKED = "FinalTest/MainEvent 2";
				if (instance.isActor)
				{
					KyrohNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "FinalTest/MainEvent 2");
				}
				else if (Utils.JANBGCMGMEE(Vector2.op_Implicit(((Component)KyrohNPC.GGFJGHHHEJC).transform.position), 10f))
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

	public static FinalTestEvent instance;

	public Transform kyrohPosition;

	public Transform rockParent;

	private Coroutine MCIBOCGJLGN;

	private void FBNHEICDCHC()
	{
		EventsManager.FOHLKKJIFOL((EventsManager.EventType)(-101), DMBFKFLDDLH: false);
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(FOFPFNLHIKN));
		CommonReferences.MNFMOEKMJKN().OnActionDone(0, (ActionDone)(-96));
	}

	public void DJLFLGBHNPF()
	{
		((MonoBehaviour)instance).StartCoroutine(DFIPMCBIFOB());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 1);
		}
	}

	private void EEPPCKGNAPC()
	{
		EventsManager.SetActive((EventsManager.EventType)(-71), DMBFKFLDDLH: true);
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(LODAPIBOABC));
		CommonReferences.GGFJGHHHEJC.OnActionDone(0, ActionDone.SunriseReunion);
	}

	public void MGMMMNCHEJL()
	{
		((MonoBehaviour)instance).StartCoroutine(FCPDMIFIDEP());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
	}

	private void DNDHACEMLKN(bool GFNHAMCPEAK)
	{
		if (GFNHAMCPEAK)
		{
			CJODOOFLLLB = KyrohNPC.JFNOOMJMHCB().EHHOHCPHAAO;
			StartEvent(GFNHAMCPEAK, CDPAMNIPPEC: true);
		}
	}

	public void FNLEHAINEND()
	{
		((MonoBehaviour)instance).StartCoroutine(DFIPMCBIFOB());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
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
			StandEvent();
		}
	}

	private void NGIODPNJFMA()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)"Cross");
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(PENLIJAHGGI));
		KyrohNPC.JFNOOMJMHCB().FIOKAPKBCOD(KyrohState.Inactive);
		((Component)KyrohNPC.OAPOJCODNCO()).transform.position = kyrohPosition.position;
		((Component)KyrohNPC.GGFJGHHHEJC).transform.parent = rockParent;
		KyrohNPC.JFNOOMJMHCB().content.SetActive(false);
		KyrohNPC.JFNOOMJMHCB().animationBase.SetTrigger("ToFish");
		KyrohNPC.PBJDFFEFMKM().animationBase.SetBool("roomsRented", EGFGNGJGBOP: false);
		KyrohNPC.GGFJGHHHEJC.AOKALFHINDA(DMBFKFLDDLH: false);
		KyrohNPC kyrohNPC = KyrohNPC.AGGAGCBAGLL();
		kyrohNPC.ConversationStarted = (Action<bool>)Delegate.Combine(kyrohNPC.ConversationStarted, new Action<bool>(PNOPODJEDHH));
	}

	public void BKDCHHCAKOH()
	{
		((MonoBehaviour)instance).StartCoroutine(PLLCHLJCIMP());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 1);
		}
	}

	private IEnumerator ICINMEGAKNK()
	{
		return new KKBMPMFGHLI(1);
	}

	private void FJOFPBNLBEJ()
	{
		EventsManager.DIFPOBMAOLL((EventsManager.EventType)(-6), DMBFKFLDDLH: true);
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(EEPPCKGNAPC));
		CommonReferences.GGFJGHHHEJC.OnActionDone(1, (ActionDone)(-50));
	}

	public void PJCBPCKKAPK()
	{
		((MonoBehaviour)instance).StartCoroutine(MADILACPEPN());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 1);
		}
	}

	private void INOKAKHKAOI()
	{
		MaiWorriedEvent.instance.ActivateEvent();
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(GAEBPMJCOAD));
	}

	private IEnumerator FCPDMIFIDEP()
	{
		instance.EDGDFPPKGDL = null;
		KyrohNPC.GGFJGHHHEJC.animationBase.SetBool("Meditation", EGFGNGJGBOP: false);
		yield return CommonReferences.wait1;
		KyrohNPC.GGFJGHHHEJC.inSpecialEvent = false;
		KyrohNPC.GGFJGHHHEJC.blockActionBar = false;
		instance.EDGDFPPKGDL = KyrohNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "FinalTest/MainEvent 2";
		if (instance.isActor)
		{
			KyrohNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "FinalTest/MainEvent 2");
		}
		else if (Utils.JANBGCMGMEE(Vector2.op_Implicit(((Component)KyrohNPC.GGFJGHHHEJC).transform.position), 10f))
		{
			((MonoBehaviour)instance).StartCoroutine(KyrohNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private void JLJHKPJDBMF()
	{
		if (EventsManager.IKCEIJMLNOP((EventsManager.EventType)108))
		{
			KyrohNPC.GGFJGHHHEJC.content.SetActive(false);
			KyrohNPC.JFNOOMJMHCB().ActiveBigCollider(DMBFKFLDDLH: true);
			KyrohNPC kyrohNPC = KyrohNPC.KADHMEPDIKM();
			kyrohNPC.ConversationStarted = (Action<bool>)Delegate.Remove(kyrohNPC.ConversationStarted, new Action<bool>(AINKBCHNIGA));
			ActivateEvent();
		}
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(HGMGHCHDKCP));
	}

	private IEnumerator PLLCHLJCIMP()
	{
		instance.EDGDFPPKGDL = null;
		KyrohNPC.GGFJGHHHEJC.animationBase.SetBool("Meditation", EGFGNGJGBOP: false);
		yield return CommonReferences.wait1;
		KyrohNPC.GGFJGHHHEJC.inSpecialEvent = false;
		KyrohNPC.GGFJGHHHEJC.blockActionBar = false;
		instance.EDGDFPPKGDL = KyrohNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "FinalTest/MainEvent 2";
		if (instance.isActor)
		{
			KyrohNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "FinalTest/MainEvent 2");
		}
		else if (Utils.JANBGCMGMEE(Vector2.op_Implicit(((Component)KyrohNPC.GGFJGHHHEJC).transform.position), 10f))
		{
			((MonoBehaviour)instance).StartCoroutine(KyrohNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private void JLEFMNKIFAC()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)"ReceiveAddDrink");
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(HGMGHCHDKCP));
		KyrohNPC.OAPOJCODNCO().EKBJHJLFODI(KyrohState.Inactive);
		((Component)KyrohNPC.GGFJGHHHEJC).transform.position = kyrohPosition.position;
		((Component)KyrohNPC.JFNOOMJMHCB()).transform.parent = rockParent;
		KyrohNPC.OAPOJCODNCO().content.SetActive(false);
		KyrohNPC.KFGKCKCDMLG().animationBase.SetTrigger("Receive next game date from host ");
		KyrohNPC.OAPOJCODNCO().animationBase.CGEADHOLHCH("Only host can do building tutorial", EGFGNGJGBOP: true);
		KyrohNPC.GGFJGHHHEJC.AOKALFHINDA(DMBFKFLDDLH: false);
		KyrohNPC kyrohNPC = KyrohNPC.OAPOJCODNCO();
		kyrohNPC.ConversationStarted = (Action<bool>)Delegate.Combine(kyrohNPC.ConversationStarted, new Action<bool>(AINKBCHNIGA));
	}

	private IEnumerator LEDKIGHJMPO()
	{
		yield return CommonReferences.wait2;
		KyrohNPC.GGFJGHHHEJC.content.SetActive(false);
	}

	public void GMKHBNHFKNL()
	{
		MissionsManager.OKBKHFFDNOA(-91);
	}

	private void APOJJALKHDK()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)"Items/item_description_732");
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(JECFMJPKGJM));
		KyrohNPC.GGFJGHHHEJC.FIOKAPKBCOD(KyrohState.Idle);
		((Component)KyrohNPC.KADHMEPDIKM()).transform.position = kyrohPosition.position;
		((Component)KyrohNPC.KFGKCKCDMLG()).transform.parent = rockParent;
		KyrohNPC.KFGKCKCDMLG().content.SetActive(false);
		KyrohNPC.OAPOJCODNCO().animationBase.SetTrigger("</color>", HALNIEBONKH: true);
		KyrohNPC.KFGKCKCDMLG().animationBase.CGEADHOLHCH("ReceivInstantiateMiscellaneousHarvest", EGFGNGJGBOP: true, HALNIEBONKH: true);
		KyrohNPC.KFGKCKCDMLG().CGAANBOCHOG(DMBFKFLDDLH: false);
		KyrohNPC kyrohNPC = KyrohNPC.OAPOJCODNCO();
		kyrohNPC.ConversationStarted = (Action<bool>)Delegate.Combine(kyrohNPC.ConversationStarted, new Action<bool>(JBGPCBMHKJC));
	}

	private void EFJCJPPLKOD()
	{
		if (EventsManager.BBMAEAFHEFK((EventsManager.EventType)(-80)))
		{
			KyrohNPC.AGGAGCBAGLL().content.SetActive(false);
			KyrohNPC.OAPOJCODNCO().KANODDKKEGJ(DMBFKFLDDLH: true);
			KyrohNPC kyrohNPC = KyrohNPC.JLNBMNKJCHE();
			kyrohNPC.ConversationStarted = (Action<bool>)Delegate.Remove(kyrohNPC.ConversationStarted, new Action<bool>(DNDHACEMLKN));
			ActivateEvent();
		}
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(JLJHKPJDBMF));
	}

	private void DFAIOIPDHJF()
	{
		if (EventsManager.CJMECHEOFOF((EventsManager.EventType)95))
		{
			KyrohNPC.JLNBMNKJCHE().content.SetActive(false);
			KyrohNPC.KFGKCKCDMLG().KANODDKKEGJ(DMBFKFLDDLH: false);
			KyrohNPC kyrohNPC = KyrohNPC.KADHMEPDIKM();
			kyrohNPC.ConversationStarted = (Action<bool>)Delegate.Remove(kyrohNPC.ConversationStarted, new Action<bool>(EEGHAGAFIFP));
			ActivateEvent();
		}
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(JLJHKPJDBMF));
	}

	private void NOHMFBICOBF()
	{
		if (EventsManager.FFELMGLBAMH((EventsManager.EventType)55))
		{
			KyrohNPC.JLNBMNKJCHE().content.SetActive(false);
			KyrohNPC.GGFJGHHHEJC.KANODDKKEGJ(DMBFKFLDDLH: true);
			KyrohNPC kyrohNPC = KyrohNPC.PBJDFFEFMKM();
			kyrohNPC.ConversationStarted = (Action<bool>)Delegate.Remove(kyrohNPC.ConversationStarted, new Action<bool>(PHDPGDKPNOD));
			ActivateEvent();
		}
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(PENLIJAHGGI));
	}

	private void PHDPGDKPNOD(bool GFNHAMCPEAK)
	{
		if (GFNHAMCPEAK)
		{
			CJODOOFLLLB = KyrohNPC.JFNOOMJMHCB().EHHOHCPHAAO;
			StartEvent(GFNHAMCPEAK, CDPAMNIPPEC: true);
		}
	}

	public void LPFFGONABHG()
	{
		((MonoBehaviour)instance).StartCoroutine(DFIPMCBIFOB());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 1);
		}
	}

	protected override void Awake()
	{
		base.Awake();
		instance = this;
	}

	private IEnumerator FAIOOFLAICP()
	{
		return new KKBMPMFGHLI(1);
	}

	private void DGDFPIJKDKA()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)"FinalTestEvent SetKyroh");
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(DFIGNGCFMCP));
		KyrohNPC.GGFJGHHHEJC.ChangeState(KyrohState.Idle);
		((Component)KyrohNPC.GGFJGHHHEJC).transform.position = kyrohPosition.position;
		((Component)KyrohNPC.GGFJGHHHEJC).transform.parent = rockParent;
		KyrohNPC.GGFJGHHHEJC.content.SetActive(true);
		KyrohNPC.GGFJGHHHEJC.animationBase.SetTrigger("MeditationIntro");
		KyrohNPC.GGFJGHHHEJC.animationBase.SetBool("Meditation", EGFGNGJGBOP: true, HALNIEBONKH: true);
		KyrohNPC.GGFJGHHHEJC.ActiveBigCollider(DMBFKFLDDLH: true);
		KyrohNPC kyrohNPC = KyrohNPC.GGFJGHHHEJC;
		kyrohNPC.ConversationStarted = (Action<bool>)Delegate.Combine(kyrohNPC.ConversationStarted, new Action<bool>(AEEHFGIDCMJ));
	}

	public void DFLNNLDNBOB()
	{
		((MonoBehaviour)instance).StartCoroutine(OGPBFBCNIOC());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
	}

	private IEnumerator DKMAKKJCBMM()
	{
		instance.EDGDFPPKGDL = null;
		KyrohNPC.GGFJGHHHEJC.animationBase.SetBool("Meditation", EGFGNGJGBOP: false);
		yield return CommonReferences.wait1;
		KyrohNPC.GGFJGHHHEJC.inSpecialEvent = false;
		KyrohNPC.GGFJGHHHEJC.blockActionBar = false;
		instance.EDGDFPPKGDL = KyrohNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "FinalTest/MainEvent 2";
		if (instance.isActor)
		{
			KyrohNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "FinalTest/MainEvent 2");
		}
		else if (Utils.JANBGCMGMEE(Vector2.op_Implicit(((Component)KyrohNPC.GGFJGHHHEJC).transform.position), 10f))
		{
			((MonoBehaviour)instance).StartCoroutine(KyrohNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private IEnumerator HCKGMCDHIIM()
	{
		instance.EDGDFPPKGDL = null;
		KyrohNPC.GGFJGHHHEJC.animationBase.SetBool("Meditation", EGFGNGJGBOP: false);
		yield return CommonReferences.wait1;
		KyrohNPC.GGFJGHHHEJC.inSpecialEvent = false;
		KyrohNPC.GGFJGHHHEJC.blockActionBar = false;
		instance.EDGDFPPKGDL = KyrohNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "FinalTest/MainEvent 2";
		if (instance.isActor)
		{
			KyrohNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "FinalTest/MainEvent 2");
		}
		else if (Utils.JANBGCMGMEE(Vector2.op_Implicit(((Component)KyrohNPC.GGFJGHHHEJC).transform.position), 10f))
		{
			((MonoBehaviour)instance).StartCoroutine(KyrohNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	public void INBIMHOMAJI()
	{
		((MonoBehaviour)instance).StartCoroutine(DKMAKKJCBMM());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
	}

	private void HKAFEMBKBFE()
	{
		MaiWorriedEvent.instance.ActivateEvent();
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(PLFKIIHDPCJ));
	}

	private void GOOGKCHMGKL()
	{
		EventsManager.BIOJKNIHGAF((EventsManager.EventType)(-75), DMBFKFLDDLH: true);
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(FBNHEICDCHC));
		CommonReferences.MNFMOEKMJKN().OnActionDone(1, (ActionDone)(-35));
	}

	private void DFIGNGCFMCP()
	{
		if (EventsManager.IsActive(EventsManager.EventType.FinalTest))
		{
			KyrohNPC.GGFJGHHHEJC.content.SetActive(false);
			KyrohNPC.GGFJGHHHEJC.ActiveBigCollider(DMBFKFLDDLH: false);
			KyrohNPC kyrohNPC = KyrohNPC.GGFJGHHHEJC;
			kyrohNPC.ConversationStarted = (Action<bool>)Delegate.Remove(kyrohNPC.ConversationStarted, new Action<bool>(AEEHFGIDCMJ));
			ActivateEvent();
		}
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(DFIGNGCFMCP));
	}

	public void HEKBHHLNJNH()
	{
		MissionsManager.IKKHOGBJHKA(90);
	}

	public void AMHBLMLHKLA()
	{
		((MonoBehaviour)instance).StartCoroutine(CDJCNBNABEE());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 1);
		}
	}

	private void NLPPDMCAAMG()
	{
		MaiWorriedEvent.instance.ActivateEvent();
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(GAEBPMJCOAD));
	}

	private void HGMGHCHDKCP()
	{
		if (EventsManager.JAGPJPGBHDK((EventsManager.EventType)(-19)))
		{
			KyrohNPC.KADHMEPDIKM().content.SetActive(false);
			KyrohNPC.GGFJGHHHEJC.AOKALFHINDA(DMBFKFLDDLH: false);
			KyrohNPC kyrohNPC = KyrohNPC.JLNBMNKJCHE();
			kyrohNPC.ConversationStarted = (Action<bool>)Delegate.Remove(kyrohNPC.ConversationStarted, new Action<bool>(AINKBCHNIGA));
			ActivateEvent();
		}
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(HAFHPDGBDIP));
	}

	private void IFHFNDELKOP()
	{
		EventsManager.SetActive(EventsManager.EventType.MaiWorried, DMBFKFLDDLH: true);
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(IFHFNDELKOP));
		CommonReferences.GGFJGHHHEJC.OnActionDone(1, ActionDone.DuelSleep);
	}

	private void LFGCFBLIDCN()
	{
		if (EventsManager.NKMELJPGOBB((EventsManager.EventType)(-112)))
		{
			KyrohNPC.OAPOJCODNCO().content.SetActive(false);
			KyrohNPC.KADHMEPDIKM().LIDENNPPDBJ(DMBFKFLDDLH: true);
			KyrohNPC kyrohNPC = KyrohNPC.PBJDFFEFMKM();
			kyrohNPC.ConversationStarted = (Action<bool>)Delegate.Remove(kyrohNPC.ConversationStarted, new Action<bool>(MPNGOCJMPOI));
			ActivateEvent();
		}
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(HGMGHCHDKCP));
	}

	public void DPMJKIEIJIL()
	{
		MissionsManager.IKKHOGBJHKA(1);
	}

	private void MMEDOKIJJAE()
	{
		EventsManager.FOHLKKJIFOL((EventsManager.EventType)(-83), DMBFKFLDDLH: true);
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(MMEDOKIJJAE));
		CommonReferences.GGFJGHHHEJC.OnActionDone(0, (ActionDone)60);
	}

	public override void StartEvent(bool BFLCJPHHDJM, bool CDPAMNIPPEC)
	{
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		base.StartEvent(BFLCJPHHDJM, CDPAMNIPPEC);
		KyrohNPC kyrohNPC = KyrohNPC.GGFJGHHHEJC;
		kyrohNPC.ConversationStarted = (Action<bool>)Delegate.Remove(kyrohNPC.ConversationStarted, new Action<bool>(AEEHFGIDCMJ));
		KyrohNPC.GGFJGHHHEJC.ActiveBigCollider(DMBFKFLDDLH: false);
		KyrohNPC.GGFJGHHHEJC.inSpecialEvent = true;
		KyrohNPC.GGFJGHHHEJC.blockActionBar = true;
		if (Utils.AHMPFOEGJHF(Location.Forest, CJODOOFLLLB))
		{
			PlayerInputs.DisableKeyboardInputsAndMovement(CJODOOFLLLB, (MonoBehaviour)(object)instance);
		}
		if (GameManager.LocalCoop())
		{
			PrepareLocalCoop(Location.Forest);
		}
		EDGDFPPKGDL = KyrohNPC.GGFJGHHHEJC;
		MDFALJKHKED = "FinalTest/MainEvent";
		if (!isActor && OnlineManager.PlayingOnline() && Utils.JANBGCMGMEE(Vector2.op_Implicit(((Component)KyrohNPC.GGFJGHHHEJC).transform.position), 10f))
		{
			if (MainUI.IsAnyUIOpen())
			{
				MainUI.CloseAllUIWindows();
			}
			((MonoBehaviour)this).StartCoroutine(KyrohNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	public void NHMAJBFOGKO()
	{
		((MonoBehaviour)instance).StartCoroutine(CDJCNBNABEE());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
	}

	private void JGBHLEDMELN()
	{
		if (EventsManager.FFELMGLBAMH((EventsManager.EventType)72))
		{
			KyrohNPC.PBJDFFEFMKM().content.SetActive(false);
			KyrohNPC.KFGKCKCDMLG().DEMLJLONDIN(DMBFKFLDDLH: false);
			KyrohNPC kyrohNPC = KyrohNPC.PBJDFFEFMKM();
			kyrohNPC.ConversationStarted = (Action<bool>)Delegate.Remove(kyrohNPC.ConversationStarted, new Action<bool>(PHDPGDKPNOD));
			ActivateEvent();
		}
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(JGBHLEDMELN));
	}

	private void GCKPPGEFIFJ()
	{
		MaiWorriedEvent.instance.ActivateEvent();
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(GAEBPMJCOAD));
	}

	private void PCGJGLGHIOG(bool GFNHAMCPEAK)
	{
		if (GFNHAMCPEAK)
		{
			CJODOOFLLLB = KyrohNPC.OAPOJCODNCO().EHHOHCPHAAO;
			StartEvent(GFNHAMCPEAK, CDPAMNIPPEC: true);
		}
	}

	public void GBALIFDGCLN()
	{
		MissionsManager.OKBKHFFDNOA(80);
	}

	private void LDBNOCAEDJP()
	{
		MaiWorriedEvent.instance.ActivateEvent();
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(NLPPDMCAAMG));
	}

	private void KOOLMPHKFFF()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)". Time since startup: ");
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(JECFMJPKGJM));
		KyrohNPC.AGGAGCBAGLL().GLLDOLHPIBD(KyrohState.Inactive);
		((Component)KyrohNPC.PBJDFFEFMKM()).transform.position = kyrohPosition.position;
		((Component)KyrohNPC.KADHMEPDIKM()).transform.parent = rockParent;
		KyrohNPC.KADHMEPDIKM().content.SetActive(false);
		KyrohNPC.JFNOOMJMHCB().animationBase.SetTrigger("inviteFromDifferentRegion");
		KyrohNPC.JLNBMNKJCHE().animationBase.CGEADHOLHCH("add item ", EGFGNGJGBOP: false);
		KyrohNPC.JFNOOMJMHCB().FJJDADFEIEL(DMBFKFLDDLH: true);
		KyrohNPC kyrohNPC = KyrohNPC.GGFJGHHHEJC;
		kyrohNPC.ConversationStarted = (Action<bool>)Delegate.Combine(kyrohNPC.ConversationStarted, new Action<bool>(FOABKIGLBEE));
	}

	private IEnumerator LJABJLDHLCB()
	{
		yield return CommonReferences.wait2;
		KyrohNPC.GGFJGHHHEJC.content.SetActive(false);
	}

	private IEnumerator NEMKFKPEBGP()
	{
		return new DGLBPJLOBCN(1);
	}

	private void AINKBCHNIGA(bool GFNHAMCPEAK)
	{
		if (GFNHAMCPEAK)
		{
			CJODOOFLLLB = KyrohNPC.GGFJGHHHEJC.EHHOHCPHAAO;
			StartEvent(GFNHAMCPEAK, CDPAMNIPPEC: true);
		}
	}

	private IEnumerator FMNCOOFJLPO()
	{
		return new FILPNADCGKG(1)
		{
			_003C_003E4__this = this
		};
	}

	private void AEEHFGIDCMJ(bool GFNHAMCPEAK)
	{
		if (GFNHAMCPEAK)
		{
			CJODOOFLLLB = KyrohNPC.GGFJGHHHEJC.EHHOHCPHAAO;
			StartEvent(GFNHAMCPEAK, CDPAMNIPPEC: true);
		}
	}

	private void HAFHPDGBDIP()
	{
		if (EventsManager.NKMELJPGOBB((EventsManager.EventType)(-108)))
		{
			KyrohNPC.AGGAGCBAGLL().content.SetActive(true);
			KyrohNPC.JFNOOMJMHCB().CGAANBOCHOG(DMBFKFLDDLH: false);
			KyrohNPC kyrohNPC = KyrohNPC.AGGAGCBAGLL();
			kyrohNPC.ConversationStarted = (Action<bool>)Delegate.Remove(kyrohNPC.ConversationStarted, new Action<bool>(FOABKIGLBEE));
			ActivateEvent();
		}
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(NOHMFBICOBF));
	}

	private void CEHNKBIELIL()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)"ValueId");
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(PDLIOCCNBCA));
		KyrohNPC.OAPOJCODNCO().GLLDOLHPIBD(KyrohState.Inactive);
		((Component)KyrohNPC.JLNBMNKJCHE()).transform.position = kyrohPosition.position;
		((Component)KyrohNPC.PBJDFFEFMKM()).transform.parent = rockParent;
		KyrohNPC.KFGKCKCDMLG().content.SetActive(false);
		KyrohNPC.JFNOOMJMHCB().animationBase.SetTrigger("\n");
		KyrohNPC.KADHMEPDIKM().animationBase.CGEADHOLHCH("Body Part Dictionary:\n[\n", EGFGNGJGBOP: true);
		KyrohNPC.GGFJGHHHEJC.AOKALFHINDA(DMBFKFLDDLH: false);
		KyrohNPC kyrohNPC = KyrohNPC.AGGAGCBAGLL();
		kyrohNPC.ConversationStarted = (Action<bool>)Delegate.Combine(kyrohNPC.ConversationStarted, new Action<bool>(AINKBCHNIGA));
	}

	private void JBGPCBMHKJC(bool GFNHAMCPEAK)
	{
		if (GFNHAMCPEAK)
		{
			CJODOOFLLLB = KyrohNPC.OAPOJCODNCO().EHHOHCPHAAO;
			StartEvent(GFNHAMCPEAK, CDPAMNIPPEC: true);
		}
	}

	public void NFCBLCDDLHE()
	{
		((MonoBehaviour)instance).StartCoroutine(PPBAMKEDKMK());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
	}

	private IEnumerator BNCBLHCJHJF()
	{
		instance.EDGDFPPKGDL = null;
		KyrohNPC.GGFJGHHHEJC.animationBase.SetBool("Meditation", EGFGNGJGBOP: false);
		yield return CommonReferences.wait1;
		KyrohNPC.GGFJGHHHEJC.inSpecialEvent = false;
		KyrohNPC.GGFJGHHHEJC.blockActionBar = false;
		instance.EDGDFPPKGDL = KyrohNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "FinalTest/MainEvent 2";
		if (instance.isActor)
		{
			KyrohNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "FinalTest/MainEvent 2");
		}
		else if (Utils.JANBGCMGMEE(Vector2.op_Implicit(((Component)KyrohNPC.GGFJGHHHEJC).transform.position), 10f))
		{
			((MonoBehaviour)instance).StartCoroutine(KyrohNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private IEnumerator CGBONPLNONH()
	{
		return new DGLBPJLOBCN(1);
	}

	private IEnumerator NJFNGJCBAPI()
	{
		Debug.Log((object)"FinalTestEvent SetEventCoroutine");
		while (WorldTime.EDIPJBOOEHD > (float)(3 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.EDIPJBOOEHD < (float)(20 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR))
		{
			yield return null;
		}
		DGDFPIJKDKA();
		MCIBOCGJLGN = null;
	}

	private IEnumerator GILGKPKLDPD()
	{
		yield return CommonReferences.wait2;
		KyrohNPC.GGFJGHHHEJC.content.SetActive(false);
	}

	private void PLFKIIHDPCJ()
	{
		MaiWorriedEvent.instance.ActivateEvent();
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(PLFKIIHDPCJ));
	}

	public void JAACGLAINBH()
	{
		MissionsManager.EGKEIFMPBFL(-89);
	}

	public void HAILPBBGDLJ()
	{
		MissionsManager.CompleteMission(-81);
	}

	public void StandEvent()
	{
		((MonoBehaviour)instance).StartCoroutine(PLLCHLJCIMP());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
	}

	private IEnumerator HPKLJPOBLPK()
	{
		yield return CommonReferences.wait2;
		KyrohNPC.GGFJGHHHEJC.content.SetActive(false);
	}

	private void JECFMJPKGJM()
	{
		if (EventsManager.CGPHKBKPCJF((EventsManager.EventType)31))
		{
			KyrohNPC.PBJDFFEFMKM().content.SetActive(false);
			KyrohNPC.AGGAGCBAGLL().LIDENNPPDBJ(DMBFKFLDDLH: true);
			KyrohNPC kyrohNPC = KyrohNPC.KADHMEPDIKM();
			kyrohNPC.ConversationStarted = (Action<bool>)Delegate.Remove(kyrohNPC.ConversationStarted, new Action<bool>(PNOPODJEDHH));
			ActivateEvent();
		}
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(JLJHKPJDBMF));
	}

	private IEnumerator ALGFHNGKHNI()
	{
		return new FILPNADCGKG(1)
		{
			_003C_003E4__this = this
		};
	}

	private void MOJOHBIGMLJ(bool GFNHAMCPEAK)
	{
		if (GFNHAMCPEAK)
		{
			CJODOOFLLLB = KyrohNPC.JFNOOMJMHCB().EHHOHCPHAAO;
			StartEvent(GFNHAMCPEAK, CDPAMNIPPEC: false);
		}
	}

	private IEnumerator LCKPJBFEBKL()
	{
		yield return CommonReferences.wait2;
		KyrohNPC.GGFJGHHHEJC.content.SetActive(false);
	}

	private IEnumerator JGAHLDCLAKL()
	{
		yield return CommonReferences.wait2;
		KyrohNPC.GGFJGHHHEJC.content.SetActive(false);
	}

	public void PJEGEBPAJBM()
	{
		MissionsManager.EGKEIFMPBFL(-54);
	}

	private IEnumerator DFKJBCCEIFG()
	{
		return new DGLBPJLOBCN(1);
	}

	private IEnumerator MCJLGHBBIBC()
	{
		Debug.Log((object)"FinalTestEvent SetEventCoroutine");
		while (WorldTime.EDIPJBOOEHD > (float)(3 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.EDIPJBOOEHD < (float)(20 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR))
		{
			yield return null;
		}
		DGDFPIJKDKA();
		MCIBOCGJLGN = null;
	}

	private IEnumerator OLPADKCEBGM()
	{
		return new KKBMPMFGHLI(1);
	}

	public override GameEvent GetInstance()
	{
		return instance;
	}

	private void BMBCEPGJMBF()
	{
		MaiWorriedEvent.instance.ActivateEvent();
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(GAEBPMJCOAD));
	}

	private IEnumerator PGPGLCKCCJC()
	{
		Debug.Log((object)"FinalTestEvent SetEventCoroutine");
		while (WorldTime.EDIPJBOOEHD > (float)(3 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.EDIPJBOOEHD < (float)(20 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR))
		{
			yield return null;
		}
		DGDFPIJKDKA();
		MCIBOCGJLGN = null;
	}

	private IEnumerator DOMOFJADJHF()
	{
		instance.EDGDFPPKGDL = null;
		KyrohNPC.GGFJGHHHEJC.animationBase.SetBool("Meditation", EGFGNGJGBOP: false);
		yield return CommonReferences.wait1;
		KyrohNPC.GGFJGHHHEJC.inSpecialEvent = false;
		KyrohNPC.GGFJGHHHEJC.blockActionBar = false;
		instance.EDGDFPPKGDL = KyrohNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "FinalTest/MainEvent 2";
		if (instance.isActor)
		{
			KyrohNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "FinalTest/MainEvent 2");
		}
		else if (Utils.JANBGCMGMEE(Vector2.op_Implicit(((Component)KyrohNPC.GGFJGHHHEJC).transform.position), 10f))
		{
			((MonoBehaviour)instance).StartCoroutine(KyrohNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private void GAEBPMJCOAD()
	{
		MaiWorriedEvent.instance.ActivateEvent();
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(JNHKPOHPHLM));
	}

	private IEnumerator MADILACPEPN()
	{
		return new DGLBPJLOBCN(1);
	}

	private void JCGJACPJEMK()
	{
		EventsManager.BBLFJJEENML((EventsManager.EventType)41, DMBFKFLDDLH: true);
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(EEPPCKGNAPC));
		CommonReferences.GGFJGHHHEJC.OnActionDone(0, (ActionDone)(-36));
	}

	public void CompleteMission()
	{
		MissionsManager.CompleteMission(310);
	}

	private void COHDGLGBBNP(bool GFNHAMCPEAK)
	{
		if (GFNHAMCPEAK)
		{
			CJODOOFLLLB = KyrohNPC.JLNBMNKJCHE().EHHOHCPHAAO;
			StartEvent(GFNHAMCPEAK, CDPAMNIPPEC: true);
		}
	}

	private void GCBDJHDFFDI(bool GFNHAMCPEAK)
	{
		if (GFNHAMCPEAK)
		{
			CJODOOFLLLB = KyrohNPC.JFNOOMJMHCB().EHHOHCPHAAO;
			StartEvent(GFNHAMCPEAK, CDPAMNIPPEC: true);
		}
	}

	public void MJDEABGCKDA()
	{
		((MonoBehaviour)instance).StartCoroutine(DFIPMCBIFOB());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
	}

	private void ECCHNCKJFEA()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)" - ");
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(JGBHLEDMELN));
		KyrohNPC.AGGAGCBAGLL().FKMFEACDJHB(KyrohState.Idle);
		((Component)KyrohNPC.KADHMEPDIKM()).transform.position = kyrohPosition.position;
		((Component)KyrohNPC.GGFJGHHHEJC).transform.parent = rockParent;
		KyrohNPC.KFGKCKCDMLG().content.SetActive(false);
		KyrohNPC.GGFJGHHHEJC.animationBase.SetTrigger("Talk", HALNIEBONKH: true);
		KyrohNPC.OAPOJCODNCO().animationBase.SetBool("ClosePopUp", EGFGNGJGBOP: true);
		KyrohNPC.PBJDFFEFMKM().CPMFHGGNLFN(DMBFKFLDDLH: true);
		KyrohNPC kyrohNPC = KyrohNPC.JFNOOMJMHCB();
		kyrohNPC.ConversationStarted = (Action<bool>)Delegate.Combine(kyrohNPC.ConversationStarted, new Action<bool>(GCBDJHDFFDI));
	}

	private IEnumerator ICNOIPFJLNM()
	{
		return new FILPNADCGKG(1)
		{
			_003C_003E4__this = this
		};
	}

	private void FOFPFNLHIKN()
	{
		EventsManager.MMIFHDJECOG((EventsManager.EventType)(-6), DMBFKFLDDLH: true);
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(FJOFPBNLBEJ));
		CommonReferences.GGFJGHHHEJC.OnActionDone(0, (ActionDone)104);
	}

	private void JNHKPOHPHLM()
	{
		MaiWorriedEvent.instance.ActivateEvent();
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(LDBNOCAEDJP));
	}

	private void EEGHAGAFIFP(bool GFNHAMCPEAK)
	{
		if (GFNHAMCPEAK)
		{
			CJODOOFLLLB = KyrohNPC.AGGAGCBAGLL().EHHOHCPHAAO;
			StartEvent(GFNHAMCPEAK, CDPAMNIPPEC: false);
		}
	}

	private IEnumerator AHGIIGDABHL()
	{
		Debug.Log((object)"FinalTestEvent SetEventCoroutine");
		while (WorldTime.EDIPJBOOEHD > (float)(3 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.EDIPJBOOEHD < (float)(20 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR))
		{
			yield return null;
		}
		DGDFPIJKDKA();
		MCIBOCGJLGN = null;
	}

	private void KBBMEIIIMMH()
	{
		if (EventsManager.NKMELJPGOBB(EventsManager.EventType.KujakuShop))
		{
			KyrohNPC.JFNOOMJMHCB().content.SetActive(true);
			KyrohNPC.JFNOOMJMHCB().AOKALFHINDA(DMBFKFLDDLH: false);
			KyrohNPC kyrohNPC = KyrohNPC.JFNOOMJMHCB();
			kyrohNPC.ConversationStarted = (Action<bool>)Delegate.Remove(kyrohNPC.ConversationStarted, new Action<bool>(AINKBCHNIGA));
			ActivateEvent();
		}
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(JECFMJPKGJM));
	}

	private IEnumerator OGPBFBCNIOC()
	{
		instance.EDGDFPPKGDL = null;
		KyrohNPC.GGFJGHHHEJC.animationBase.SetBool("Meditation", EGFGNGJGBOP: false);
		yield return CommonReferences.wait1;
		KyrohNPC.GGFJGHHHEJC.inSpecialEvent = false;
		KyrohNPC.GGFJGHHHEJC.blockActionBar = false;
		instance.EDGDFPPKGDL = KyrohNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "FinalTest/MainEvent 2";
		if (instance.isActor)
		{
			KyrohNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "FinalTest/MainEvent 2");
		}
		else if (Utils.JANBGCMGMEE(Vector2.op_Implicit(((Component)KyrohNPC.GGFJGHHHEJC).transform.position), 10f))
		{
			((MonoBehaviour)instance).StartCoroutine(KyrohNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private void HCAKIDOJOAH()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)"City/Rhia/Introduce");
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(JECFMJPKGJM));
		KyrohNPC.KADHMEPDIKM().FKMFEACDJHB(KyrohState.Inactive);
		((Component)KyrohNPC.AGGAGCBAGLL()).transform.position = kyrohPosition.position;
		((Component)KyrohNPC.AGGAGCBAGLL()).transform.parent = rockParent;
		KyrohNPC.JLNBMNKJCHE().content.SetActive(true);
		KyrohNPC.PBJDFFEFMKM().animationBase.SetTrigger("<color=#A45D20>", HALNIEBONKH: true);
		KyrohNPC.OAPOJCODNCO().animationBase.CGEADHOLHCH("[OfferingStatuePuzzle] Initialized. Required items: ", EGFGNGJGBOP: false);
		KyrohNPC.JFNOOMJMHCB().KANODDKKEGJ(DMBFKFLDDLH: false);
		KyrohNPC kyrohNPC = KyrohNPC.GGFJGHHHEJC;
		kyrohNPC.ConversationStarted = (Action<bool>)Delegate.Combine(kyrohNPC.ConversationStarted, new Action<bool>(AINKBCHNIGA));
	}

	public override void EndEvent(bool _isActor)
	{
		base.EndEvent(_isActor);
		instance.EDGDFPPKGDL = null;
		DialogueLua.SetVariable("MainProgress", (object)16);
		KyrohNPC.GGFJGHHHEJC.animationBase.SetTrigger("SmokeBomb");
		MissionsManager.instance.StartMission(321);
		if (Utils.AHMPFOEGJHF(Location.Forest))
		{
			DialogueCameraTarget.GetPlayer(1).ReturnControlToCameraTarget();
		}
		if (GameManager.LocalCoop() && Utils.AHMPFOEGJHF(Location.Forest, 2))
		{
			DialogueCameraTarget.GetPlayer(2).ReturnControlToCameraTarget();
		}
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerSleep = (Action)Delegate.Combine(commonReferences.OnPlayerSleep, new Action(IFHFNDELKOP));
		CommonReferences commonReferences2 = CommonReferences.GGFJGHHHEJC;
		commonReferences2.OnPlayerAwake = (Action)Delegate.Combine(commonReferences2.OnPlayerAwake, new Action(PLFKIIHDPCJ));
		((MonoBehaviour)instance).StartCoroutine(LJABJLDHLCB());
	}

	private IEnumerator CDJCNBNABEE()
	{
		return new DGLBPJLOBCN(1);
	}

	private void EOINPIHAICH()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)"Object ");
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(NANJAMLJPOM));
		KyrohNPC.AGGAGCBAGLL().EKBJHJLFODI(KyrohState.Idle);
		((Component)KyrohNPC.GGFJGHHHEJC).transform.position = kyrohPosition.position;
		((Component)KyrohNPC.JLNBMNKJCHE()).transform.parent = rockParent;
		KyrohNPC.KFGKCKCDMLG().content.SetActive(true);
		KyrohNPC.KADHMEPDIKM().animationBase.SetTrigger("Items/item_name_628", HALNIEBONKH: true);
		KyrohNPC.PBJDFFEFMKM().animationBase.SetBool(")...", EGFGNGJGBOP: true);
		KyrohNPC.KADHMEPDIKM().ActiveBigCollider(DMBFKFLDDLH: false);
		KyrohNPC kyrohNPC = KyrohNPC.PBJDFFEFMKM();
		kyrohNPC.ConversationStarted = (Action<bool>)Delegate.Combine(kyrohNPC.ConversationStarted, new Action<bool>(GCBDJHDFFDI));
	}

	private void LODAPIBOABC()
	{
		EventsManager.BIOJKNIHGAF((EventsManager.EventType)(-31), DMBFKFLDDLH: false);
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(LODAPIBOABC));
		CommonReferences.MNFMOEKMJKN().OnActionDone(0, (ActionDone)87);
	}

	private void JBKABHCHOKE()
	{
		if (EventsManager.CJMECHEOFOF((EventsManager.EventType)75))
		{
			KyrohNPC.KADHMEPDIKM().content.SetActive(false);
			KyrohNPC.GGFJGHHHEJC.DEMLJLONDIN(DMBFKFLDDLH: true);
			KyrohNPC kyrohNPC = KyrohNPC.JFNOOMJMHCB();
			kyrohNPC.ConversationStarted = (Action<bool>)Delegate.Remove(kyrohNPC.ConversationStarted, new Action<bool>(PNOPODJEDHH));
			ActivateEvent();
		}
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(PDLIOCCNBCA));
	}

	private void ILILDBHCMGK(bool GFNHAMCPEAK)
	{
		if (GFNHAMCPEAK)
		{
			CJODOOFLLLB = KyrohNPC.KADHMEPDIKM().EHHOHCPHAAO;
			StartEvent(GFNHAMCPEAK, CDPAMNIPPEC: false);
		}
	}

	private IEnumerator PPBAMKEDKMK()
	{
		instance.EDGDFPPKGDL = null;
		KyrohNPC.GGFJGHHHEJC.animationBase.SetBool("Meditation", EGFGNGJGBOP: false);
		yield return CommonReferences.wait1;
		KyrohNPC.GGFJGHHHEJC.inSpecialEvent = false;
		KyrohNPC.GGFJGHHHEJC.blockActionBar = false;
		instance.EDGDFPPKGDL = KyrohNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "FinalTest/MainEvent 2";
		if (instance.isActor)
		{
			KyrohNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "FinalTest/MainEvent 2");
		}
		else if (Utils.JANBGCMGMEE(Vector2.op_Implicit(((Component)KyrohNPC.GGFJGHHHEJC).transform.position), 10f))
		{
			((MonoBehaviour)instance).StartCoroutine(KyrohNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private void ENGNNEMJBBM()
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)"Sit");
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(PDLIOCCNBCA));
		KyrohNPC.AGGAGCBAGLL().EKBJHJLFODI(KyrohState.Inactive);
		((Component)KyrohNPC.GGFJGHHHEJC).transform.position = kyrohPosition.position;
		((Component)KyrohNPC.OAPOJCODNCO()).transform.parent = rockParent;
		KyrohNPC.KFGKCKCDMLG().content.SetActive(true);
		KyrohNPC.KADHMEPDIKM().animationBase.SetTrigger("Tutorial_Main_", HALNIEBONKH: true);
		KyrohNPC.PBJDFFEFMKM().animationBase.CGEADHOLHCH("TreasureMapUI", EGFGNGJGBOP: false);
		KyrohNPC.AGGAGCBAGLL().AOKALFHINDA(DMBFKFLDDLH: true);
		KyrohNPC kyrohNPC = KyrohNPC.JLNBMNKJCHE();
		kyrohNPC.ConversationStarted = (Action<bool>)Delegate.Combine(kyrohNPC.ConversationStarted, new Action<bool>(DNDHACEMLKN));
	}

	private void PENLIJAHGGI()
	{
		if (EventsManager.BBMAEAFHEFK((EventsManager.EventType)(-101)))
		{
			KyrohNPC.GGFJGHHHEJC.content.SetActive(true);
			KyrohNPC.AGGAGCBAGLL().AOKALFHINDA(DMBFKFLDDLH: true);
			KyrohNPC kyrohNPC = KyrohNPC.AGGAGCBAGLL();
			kyrohNPC.ConversationStarted = (Action<bool>)Delegate.Remove(kyrohNPC.ConversationStarted, new Action<bool>(AEEHFGIDCMJ));
			ActivateEvent();
		}
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(NOHMFBICOBF));
	}

	private IEnumerator DEJAMLCDDHL()
	{
		return new KKBMPMFGHLI(1);
	}

	private IEnumerator OEOACMOKCGN()
	{
		yield return CommonReferences.wait2;
		KyrohNPC.GGFJGHHHEJC.content.SetActive(false);
	}

	private void PDLIOCCNBCA()
	{
		if (EventsManager.NJBACCBIHID((EventsManager.EventType)(-99)))
		{
			KyrohNPC.KFGKCKCDMLG().content.SetActive(true);
			KyrohNPC.OAPOJCODNCO().KANODDKKEGJ(DMBFKFLDDLH: false);
			KyrohNPC kyrohNPC = KyrohNPC.JLNBMNKJCHE();
			kyrohNPC.ConversationStarted = (Action<bool>)Delegate.Remove(kyrohNPC.ConversationStarted, new Action<bool>(COHDGLGBBNP));
			ActivateEvent();
		}
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(JGBHLEDMELN));
	}

	private IEnumerator NFIGLLPPIDC()
	{
		return new DGLBPJLOBCN(1);
	}

	public void DDDLLGMNFOP()
	{
		MissionsManager.OKBKHFFDNOA(89);
	}

	private void FOABKIGLBEE(bool GFNHAMCPEAK)
	{
		if (GFNHAMCPEAK)
		{
			CJODOOFLLLB = KyrohNPC.JLNBMNKJCHE().EHHOHCPHAAO;
			StartEvent(GFNHAMCPEAK, CDPAMNIPPEC: true);
		}
	}

	private void LHNJAGJNPIG()
	{
		EventsManager.BBLFJJEENML((EventsManager.EventType)44, DMBFKFLDDLH: true);
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(FJOFPBNLBEJ));
		CommonReferences.MNFMOEKMJKN().OnActionDone(1, (ActionDone)65);
	}

	public override void ActivateEvent()
	{
		base.ActivateEvent();
		DialogueLua.SetVariable("MainProgress", (object)15);
		KyrohNPC.GGFJGHHHEJC.CheckExclamation();
		KyrohNPC.GGFJGHHHEJC.content.SetActive(false);
		KyrohNPC.GGFJGHHHEJC.ActiveBigCollider(DMBFKFLDDLH: false);
		if (MCIBOCGJLGN == null)
		{
			MCIBOCGJLGN = ((MonoBehaviour)this).StartCoroutine(NJFNGJCBAPI());
		}
	}

	public void EMLJDFGHOKA()
	{
		((MonoBehaviour)instance).StartCoroutine(OGPBFBCNIOC());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
	}

	private void DHPGIFIKGEK(bool GFNHAMCPEAK)
	{
		if (GFNHAMCPEAK)
		{
			CJODOOFLLLB = KyrohNPC.KFGKCKCDMLG().EHHOHCPHAAO;
			StartEvent(GFNHAMCPEAK, CDPAMNIPPEC: false);
		}
	}

	private IEnumerator JANOHPIGBMP()
	{
		Debug.Log((object)"FinalTestEvent SetEventCoroutine");
		while (WorldTime.EDIPJBOOEHD > (float)(3 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.EDIPJBOOEHD < (float)(20 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR))
		{
			yield return null;
		}
		DGDFPIJKDKA();
		MCIBOCGJLGN = null;
	}

	private void PNOPODJEDHH(bool GFNHAMCPEAK)
	{
		if (GFNHAMCPEAK)
		{
			CJODOOFLLLB = KyrohNPC.GGFJGHHHEJC.EHHOHCPHAAO;
			StartEvent(GFNHAMCPEAK, CDPAMNIPPEC: false);
		}
	}

	private void EOCPMBDCJJA(bool GFNHAMCPEAK)
	{
		if (GFNHAMCPEAK)
		{
			CJODOOFLLLB = KyrohNPC.GGFJGHHHEJC.EHHOHCPHAAO;
			StartEvent(GFNHAMCPEAK, CDPAMNIPPEC: true);
		}
	}

	private void MPNGOCJMPOI(bool GFNHAMCPEAK)
	{
		if (GFNHAMCPEAK)
		{
			CJODOOFLLLB = KyrohNPC.GGFJGHHHEJC.EHHOHCPHAAO;
			StartEvent(GFNHAMCPEAK, CDPAMNIPPEC: false);
		}
	}

	private void NANJAMLJPOM()
	{
		if (EventsManager.JAGPJPGBHDK((EventsManager.EventType)25))
		{
			KyrohNPC.JFNOOMJMHCB().content.SetActive(true);
			KyrohNPC.GGFJGHHHEJC.CPMFHGGNLFN(DMBFKFLDDLH: false);
			KyrohNPC kyrohNPC = KyrohNPC.GGFJGHHHEJC;
			kyrohNPC.ConversationStarted = (Action<bool>)Delegate.Remove(kyrohNPC.ConversationStarted, new Action<bool>(FOABKIGLBEE));
			ActivateEvent();
		}
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(JBKABHCHOKE));
	}

	private IEnumerator DFIPMCBIFOB()
	{
		return new DGLBPJLOBCN(1);
	}
}
