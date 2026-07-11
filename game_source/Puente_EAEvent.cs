using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using psai.net;

public class Puente_EAEvent : GameEvent
{
	public enum SimpleEvent : short
	{
		ContinueEvent
	}

	[CompilerGenerated]
	private sealed class CMOEONPMKEN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Puente_EAEvent _003C_003E4__this;

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
		public CMOEONPMKEN(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Expected O, but got Unknown
			int num = _003C_003E1__state;
			Puente_EAEvent puente_EAEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				instance.EDGDFPPKGDL = null;
				if (puente_EAEvent.HELPKKFGIBO())
				{
					PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
					MaiMemeUI.instance.OpenUI();
					instance.volumeProfile.SetActive(true);
				}
				PsaiCore.Instance.StopMusic(immediately: true);
				MusicController.instance.TriggerMusicTheme(40);
				Time.timeScale = 0f;
				_003C_003E2__current = (object)new WaitForSecondsRealtime(6f);
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				Time.timeScale = 1f;
				if (GameManager.LocalCoop())
				{
					PlayerInputs.EnableKeyboardInputsAndMovement((puente_EAEvent.CJODOOFLLLB != 1) ? 1 : 2, (MonoBehaviour)(object)instance);
				}
				if (puente_EAEvent.HELPKKFGIBO())
				{
					MaiMemeUI.instance.CloseUI();
					instance.volumeProfile.SetActive(false);
				}
				instance.EDGDFPPKGDL = MaiNPC.GGFJGHHHEJC;
				instance.MDFALJKHKED = "Puente_EA/Talk 2";
				if (instance.isActor)
				{
					MaiNPC.GGFJGHHHEJC.StartConversation(puente_EAEvent.CJODOOFLLLB, "Puente_EA/Talk 2");
				}
				else if (OnlineManager.PlayingOnline() && puente_EAEvent.HELPKKFGIBO())
				{
					_003C_003E2__current = MaiNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
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
	private sealed class BOCIKGGENMN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Puente_EAEvent _003C_003E4__this;

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
		public BOCIKGGENMN(int _003C_003E1__state)
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
			Puente_EAEvent puente_EAEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				instance.EDGDFPPKGDL = null;
				MaiNPC.GGFJGHHHEJC.inSpecialEvent = false;
				MaiNPC.GGFJGHHHEJC.blockActionBar = false;
				if (puente_EAEvent.HELPKKFGIBO())
				{
					DialogueCameraTarget.GetPlayer(puente_EAEvent.CJODOOFLLLB).ReturnControlToCameraTarget();
				}
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.animationBase.SetTrigger("HumanDisappear");
				_003C_003E2__current = CommonReferences.wait3;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
				MaiNPC.GGFJGHHHEJC.dialogueActor.actor = "Mai";
				MaiNPC.GGFJGHHHEJC.ResetMai();
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

	public static Puente_EAEvent instance;

	public GameObject volumeProfile;

	private bool HFEAJGPILHB()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		return Utils.JANBGCMGMEE(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position), 858f);
	}

	public override void ActivateEvent()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		base.ActivateEvent();
		MaiNPC.GGFJGHHHEJC.content.SetActive(true);
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = Bar.instance.barSpaces[0].position;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.animationBase.SetBool("Disabled", EGFGNGJGBOP: false);
		MaiNPC.GGFJGHHHEJC.animationBase.SetTrigger("Transform");
		MaiNPC.GGFJGHHHEJC.dialogueActor.actor = "Mai ";
		MaiNPC maiNPC = MaiNPC.GGFJGHHHEJC;
		maiNPC.ConversationStarted = (Action<bool>)Delegate.Combine(maiNPC.ConversationStarted, new Action<bool>(AEEHFGIDCMJ));
	}

	private void JMOJBJHIGLC(bool BFLCJPHHDJM)
	{
		MaiNPC maiNPC = MaiNPC.GGFJGHHHEJC;
		maiNPC.ConversationStarted = (Action<bool>)Delegate.Remove(maiNPC.ConversationStarted, new Action<bool>(AEEHFGIDCMJ));
		if (BFLCJPHHDJM)
		{
			CJODOOFLLLB = MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO;
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: false);
		}
	}

	private IEnumerator LGNHLAKBDAH()
	{
		instance.EDGDFPPKGDL = null;
		MaiNPC.GGFJGHHHEJC.inSpecialEvent = false;
		MaiNPC.GGFJGHHHEJC.blockActionBar = false;
		if (HELPKKFGIBO())
		{
			DialogueCameraTarget.GetPlayer(CJODOOFLLLB).ReturnControlToCameraTarget();
		}
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.animationBase.SetTrigger("HumanDisappear");
		yield return CommonReferences.wait3;
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		MaiNPC.GGFJGHHHEJC.dialogueActor.actor = "Mai";
		MaiNPC.GGFJGHHHEJC.ResetMai();
	}

	private IEnumerator DHINCHODEFI()
	{
		instance.EDGDFPPKGDL = null;
		MaiNPC.GGFJGHHHEJC.inSpecialEvent = false;
		MaiNPC.GGFJGHHHEJC.blockActionBar = false;
		if (HELPKKFGIBO())
		{
			DialogueCameraTarget.GetPlayer(CJODOOFLLLB).ReturnControlToCameraTarget();
		}
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.animationBase.SetTrigger("HumanDisappear");
		yield return CommonReferences.wait3;
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		MaiNPC.GGFJGHHHEJC.dialogueActor.actor = "Mai";
		MaiNPC.GGFJGHHHEJC.ResetMai();
	}

	private IEnumerator ABFENGLFKBM()
	{
		return new CMOEONPMKEN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JAHNGPECFCB()
	{
		instance.EDGDFPPKGDL = null;
		if (HELPKKFGIBO())
		{
			PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
			MaiMemeUI.instance.OpenUI();
			instance.volumeProfile.SetActive(true);
		}
		PsaiCore.Instance.StopMusic(immediately: true);
		MusicController.instance.TriggerMusicTheme(40);
		Time.timeScale = 0f;
		yield return (object)new WaitForSecondsRealtime(6f);
		Time.timeScale = 1f;
		if (GameManager.LocalCoop())
		{
			PlayerInputs.EnableKeyboardInputsAndMovement((CJODOOFLLLB != 1) ? 1 : 2, (MonoBehaviour)(object)instance);
		}
		if (HELPKKFGIBO())
		{
			MaiMemeUI.instance.CloseUI();
			instance.volumeProfile.SetActive(false);
		}
		instance.EDGDFPPKGDL = MaiNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "Puente_EA/Talk 2";
		if (instance.isActor)
		{
			MaiNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "Puente_EA/Talk 2");
		}
		else if (OnlineManager.PlayingOnline() && HELPKKFGIBO())
		{
			yield return MaiNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private IEnumerator ADOMLOOEDMD()
	{
		instance.EDGDFPPKGDL = null;
		if (HELPKKFGIBO())
		{
			PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
			MaiMemeUI.instance.OpenUI();
			instance.volumeProfile.SetActive(true);
		}
		PsaiCore.Instance.StopMusic(immediately: true);
		MusicController.instance.TriggerMusicTheme(40);
		Time.timeScale = 0f;
		yield return (object)new WaitForSecondsRealtime(6f);
		Time.timeScale = 1f;
		if (GameManager.LocalCoop())
		{
			PlayerInputs.EnableKeyboardInputsAndMovement((CJODOOFLLLB != 1) ? 1 : 2, (MonoBehaviour)(object)instance);
		}
		if (HELPKKFGIBO())
		{
			MaiMemeUI.instance.CloseUI();
			instance.volumeProfile.SetActive(false);
		}
		instance.EDGDFPPKGDL = MaiNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "Puente_EA/Talk 2";
		if (instance.isActor)
		{
			MaiNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "Puente_EA/Talk 2");
		}
		else if (OnlineManager.PlayingOnline() && HELPKKFGIBO())
		{
			yield return MaiNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	public void GPLOCOFPAMH()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.OMEOBABHBJP());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 1);
		}
	}

	private void OHKJJGADFKL(bool BFLCJPHHDJM)
	{
		MaiNPC maiNPC = MaiNPC.GGFJGHHHEJC;
		maiNPC.ConversationStarted = (Action<bool>)Delegate.Remove(maiNPC.ConversationStarted, new Action<bool>(EOCPMBDCJJA));
		if (BFLCJPHHDJM)
		{
			CJODOOFLLLB = MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO;
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: true);
		}
	}

	private void JEPFLPOFAKE(bool BFLCJPHHDJM)
	{
		MaiNPC maiNPC = MaiNPC.GGFJGHHHEJC;
		maiNPC.ConversationStarted = (Action<bool>)Delegate.Remove(maiNPC.ConversationStarted, new Action<bool>(AINKBCHNIGA));
		if (BFLCJPHHDJM)
		{
			CJODOOFLLLB = MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO;
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: false);
		}
	}

	private bool EFKJHKGLLOL()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		return Utils.JANBGCMGMEE(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position), 1329f);
	}

	private void EOCPMBDCJJA(bool BFLCJPHHDJM)
	{
		MaiNPC maiNPC = MaiNPC.GGFJGHHHEJC;
		maiNPC.ConversationStarted = (Action<bool>)Delegate.Remove(maiNPC.ConversationStarted, new Action<bool>(PHENEPGPJKO));
		if (BFLCJPHHDJM)
		{
			CJODOOFLLLB = MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO;
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: false);
		}
	}

	private IEnumerator MOCGIAAEIIE()
	{
		return new CMOEONPMKEN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NFDGJADMCOG()
	{
		return new BOCIKGGENMN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void IIMBCHAILID(bool BFLCJPHHDJM)
	{
		MaiNPC maiNPC = MaiNPC.GGFJGHHHEJC;
		maiNPC.ConversationStarted = (Action<bool>)Delegate.Remove(maiNPC.ConversationStarted, new Action<bool>(BEPAKMIFIJK));
		if (BFLCJPHHDJM)
		{
			CJODOOFLLLB = MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO;
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: false);
		}
	}

	private bool IAGKIHJKGJE()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		return Utils.JANBGCMGMEE(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position), 1551f);
	}

	public override GameEvent GetInstance()
	{
		return instance;
	}

	public override void OnSimpleEvent(short JFNMCNCHMEO)
	{
		if (JFNMCNCHMEO == 0)
		{
			ContinueEvent();
		}
	}

	private void NEOGDPGFFFO(bool BFLCJPHHDJM)
	{
		MaiNPC maiNPC = MaiNPC.GGFJGHHHEJC;
		maiNPC.ConversationStarted = (Action<bool>)Delegate.Remove(maiNPC.ConversationStarted, new Action<bool>(NEOGDPGFFFO));
		if (BFLCJPHHDJM)
		{
			CJODOOFLLLB = MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO;
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: true);
		}
	}

	public void NECJLJGBMFN()
	{
		PsaiCore.Instance.HoldCurrentIntensity(hold: false);
		PsaiCore.Instance.StopMusic(immediately: false, 723f);
	}

	private void PHENEPGPJKO(bool BFLCJPHHDJM)
	{
		MaiNPC maiNPC = MaiNPC.GGFJGHHHEJC;
		maiNPC.ConversationStarted = (Action<bool>)Delegate.Remove(maiNPC.ConversationStarted, new Action<bool>(EOCPMBDCJJA));
		if (BFLCJPHHDJM)
		{
			CJODOOFLLLB = MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO;
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: false);
		}
	}

	public void KDAKKFFEOIH()
	{
		PsaiCore.Instance.HoldCurrentIntensity(hold: true);
		PsaiCore.Instance.StopMusic(immediately: true, 1381f);
	}

	private IEnumerator LJABJLDHLCB()
	{
		instance.EDGDFPPKGDL = null;
		MaiNPC.GGFJGHHHEJC.inSpecialEvent = false;
		MaiNPC.GGFJGHHHEJC.blockActionBar = false;
		if (HELPKKFGIBO())
		{
			DialogueCameraTarget.GetPlayer(CJODOOFLLLB).ReturnControlToCameraTarget();
		}
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.animationBase.SetTrigger("HumanDisappear");
		yield return CommonReferences.wait3;
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		MaiNPC.GGFJGHHHEJC.dialogueActor.actor = "Mai";
		MaiNPC.GGFJGHHHEJC.ResetMai();
	}

	private IEnumerator KAFMCBNCBFI()
	{
		return new BOCIKGGENMN(1)
		{
			_003C_003E4__this = this
		};
	}

	public void MusicStops()
	{
		PsaiCore.Instance.HoldCurrentIntensity(hold: false);
		PsaiCore.Instance.StopMusic(immediately: true, 5f);
	}

	private IEnumerator OEOACMOKCGN()
	{
		return new BOCIKGGENMN(1)
		{
			_003C_003E4__this = this
		};
	}

	private bool HELPKKFGIBO()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		return Utils.JANBGCMGMEE(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position), 10f);
	}

	private bool BEBPLLHOFCK()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		return Utils.JANBGCMGMEE(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position), 1636f);
	}

	public void ContinueEvent()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.ADOMLOOEDMD());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
	}

	private bool KDKBALPEBDH()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		return Utils.JANBGCMGMEE(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position), 163f);
	}

	private void INICHFPEEBG(bool BFLCJPHHDJM)
	{
		MaiNPC maiNPC = MaiNPC.GGFJGHHHEJC;
		maiNPC.ConversationStarted = (Action<bool>)Delegate.Remove(maiNPC.ConversationStarted, new Action<bool>(JEPFLPOFAKE));
		if (BFLCJPHHDJM)
		{
			CJODOOFLLLB = MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO;
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: false);
		}
	}

	private IEnumerator HPCPOLPNFKH()
	{
		instance.EDGDFPPKGDL = null;
		MaiNPC.GGFJGHHHEJC.inSpecialEvent = false;
		MaiNPC.GGFJGHHHEJC.blockActionBar = false;
		if (HELPKKFGIBO())
		{
			DialogueCameraTarget.GetPlayer(CJODOOFLLLB).ReturnControlToCameraTarget();
		}
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.animationBase.SetTrigger("HumanDisappear");
		yield return CommonReferences.wait3;
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		MaiNPC.GGFJGHHHEJC.dialogueActor.actor = "Mai";
		MaiNPC.GGFJGHHHEJC.ResetMai();
	}

	public void CAMAKAEOJKB()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.IPLEGGHHFBC());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
	}

	private void AINKBCHNIGA(bool BFLCJPHHDJM)
	{
		MaiNPC maiNPC = MaiNPC.GGFJGHHHEJC;
		maiNPC.ConversationStarted = (Action<bool>)Delegate.Remove(maiNPC.ConversationStarted, new Action<bool>(INICHFPEEBG));
		if (BFLCJPHHDJM)
		{
			CJODOOFLLLB = MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO;
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: false);
		}
	}

	private bool DEODHNIMENE()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		return Utils.JANBGCMGMEE(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position), 344f);
	}

	public void DDIEJLIBPPM()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.OMEOBABHBJP());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
	}

	private bool JNMNEJECBDJ()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		return Utils.JANBGCMGMEE(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position), 1176f);
	}

	protected override void Awake()
	{
		base.Awake();
		instance = this;
	}

	private void AEEHFGIDCMJ(bool BFLCJPHHDJM)
	{
		MaiNPC maiNPC = MaiNPC.GGFJGHHHEJC;
		maiNPC.ConversationStarted = (Action<bool>)Delegate.Remove(maiNPC.ConversationStarted, new Action<bool>(AEEHFGIDCMJ));
		if (BFLCJPHHDJM)
		{
			CJODOOFLLLB = MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO;
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: true);
		}
	}

	private bool CODJPKKOAIP()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		return Utils.JANBGCMGMEE(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position), 1985f);
	}

	private IEnumerator AJCKOGNLDOP()
	{
		instance.EDGDFPPKGDL = null;
		MaiNPC.GGFJGHHHEJC.inSpecialEvent = false;
		MaiNPC.GGFJGHHHEJC.blockActionBar = false;
		if (HELPKKFGIBO())
		{
			DialogueCameraTarget.GetPlayer(CJODOOFLLLB).ReturnControlToCameraTarget();
		}
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.animationBase.SetTrigger("HumanDisappear");
		yield return CommonReferences.wait3;
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		MaiNPC.GGFJGHHHEJC.dialogueActor.actor = "Mai";
		MaiNPC.GGFJGHHHEJC.ResetMai();
	}

	private bool KCAHJLNEMIA()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		return Utils.JANBGCMGMEE(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position), 1708f);
	}

	private bool BOKIGOOOIOE()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		return Utils.JANBGCMGMEE(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position), 1353f);
	}

	public override void StartEvent(bool BFLCJPHHDJM, bool CDPAMNIPPEC)
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		base.StartEvent(BFLCJPHHDJM, CDPAMNIPPEC);
		MaiNPC.GGFJGHHHEJC.inSpecialEvent = true;
		MaiNPC.GGFJGHHHEJC.blockActionBar = true;
		if (HELPKKFGIBO())
		{
			DialogueCameraTarget.GetPlayer(CJODOOFLLLB).AOKFMJNDDPF = false;
			DialogueCameraTarget.GetPlayer(CJODOOFLLLB).cameraInEvent = true;
			DialogueCameraTarget.GetPlayer(CJODOOFLLLB).MoveCameraToPositionFromCameraTarget(Vector2.op_Implicit(((Component)DialogueCameraTarget.GetPlayer(CJODOOFLLLB)).transform.position));
		}
		EDGDFPPKGDL = MaiNPC.GGFJGHHHEJC;
		MDFALJKHKED = "Puente_EA/Talk 1";
		PsaiCore.Instance.StopMusic(immediately: false);
		MusicController.instance.TriggerMusicTheme(39);
		PsaiCore.Instance.HoldCurrentIntensity(hold: true);
		if (!instance.isActor && OnlineManager.PlayingOnline() && HELPKKFGIBO())
		{
			((MonoBehaviour)this).StartCoroutine(MaiNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	public void LHAGDFAAADA()
	{
		PsaiCore.Instance.HoldCurrentIntensity(hold: false);
		PsaiCore.Instance.StopMusic(immediately: true, 58f);
	}

	public void OLFIANJFFIO()
	{
		PsaiCore.Instance.HoldCurrentIntensity(hold: false);
		PsaiCore.Instance.StopMusic(immediately: false, 1346f);
	}

	public void DNMMMNLJJDP()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.JAHNGPECFCB());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
	}

	private bool LDLECNEDIPA()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		return Utils.JANBGCMGMEE(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position), 1224f);
	}

	private bool MCPOLMJFEAN()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		return Utils.JANBGCMGMEE(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position), 1568f);
	}

	private bool EBEFPFPCPDP()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		return Utils.JANBGCMGMEE(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position), 1645f);
	}

	private void MMLKNDAGKPB(bool BFLCJPHHDJM)
	{
		MaiNPC maiNPC = MaiNPC.GGFJGHHHEJC;
		maiNPC.ConversationStarted = (Action<bool>)Delegate.Remove(maiNPC.ConversationStarted, new Action<bool>(EOCPMBDCJJA));
		if (BFLCJPHHDJM)
		{
			CJODOOFLLLB = MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO;
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: true);
		}
	}

	private bool KJLDHAHDAJE()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		return Utils.JANBGCMGMEE(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position), 1048f);
	}

	public void EBHCCJJPACA()
	{
		PsaiCore.Instance.HoldCurrentIntensity(hold: false);
		PsaiCore.Instance.StopMusic(immediately: false, 72f);
	}

	private IEnumerator EPDAEAJBJON()
	{
		return new CMOEONPMKEN(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator OMEOBABHBJP()
	{
		instance.EDGDFPPKGDL = null;
		if (HELPKKFGIBO())
		{
			PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
			MaiMemeUI.instance.OpenUI();
			instance.volumeProfile.SetActive(true);
		}
		PsaiCore.Instance.StopMusic(immediately: true);
		MusicController.instance.TriggerMusicTheme(40);
		Time.timeScale = 0f;
		yield return (object)new WaitForSecondsRealtime(6f);
		Time.timeScale = 1f;
		if (GameManager.LocalCoop())
		{
			PlayerInputs.EnableKeyboardInputsAndMovement((CJODOOFLLLB != 1) ? 1 : 2, (MonoBehaviour)(object)instance);
		}
		if (HELPKKFGIBO())
		{
			MaiMemeUI.instance.CloseUI();
			instance.volumeProfile.SetActive(false);
		}
		instance.EDGDFPPKGDL = MaiNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "Puente_EA/Talk 2";
		if (instance.isActor)
		{
			MaiNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "Puente_EA/Talk 2");
		}
		else if (OnlineManager.PlayingOnline() && HELPKKFGIBO())
		{
			yield return MaiNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	public void MJEENJPLMFM()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.IPLEGGHHFBC());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 1);
		}
	}

	private bool BFMMFKCOGFE()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		return Utils.JANBGCMGMEE(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position), 48f);
	}

	private IEnumerator IPLEGGHHFBC()
	{
		instance.EDGDFPPKGDL = null;
		if (HELPKKFGIBO())
		{
			PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
			MaiMemeUI.instance.OpenUI();
			instance.volumeProfile.SetActive(true);
		}
		PsaiCore.Instance.StopMusic(immediately: true);
		MusicController.instance.TriggerMusicTheme(40);
		Time.timeScale = 0f;
		yield return (object)new WaitForSecondsRealtime(6f);
		Time.timeScale = 1f;
		if (GameManager.LocalCoop())
		{
			PlayerInputs.EnableKeyboardInputsAndMovement((CJODOOFLLLB != 1) ? 1 : 2, (MonoBehaviour)(object)instance);
		}
		if (HELPKKFGIBO())
		{
			MaiMemeUI.instance.CloseUI();
			instance.volumeProfile.SetActive(false);
		}
		instance.EDGDFPPKGDL = MaiNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "Puente_EA/Talk 2";
		if (instance.isActor)
		{
			MaiNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "Puente_EA/Talk 2");
		}
		else if (OnlineManager.PlayingOnline() && HELPKKFGIBO())
		{
			yield return MaiNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	public void MBBPECCMOCE()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.JAHNGPECFCB());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 1);
		}
	}

	private bool DHEJAIJGIIH()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		return Utils.JANBGCMGMEE(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position), 1539f);
	}

	private IEnumerator ALJNBKAPCLN()
	{
		instance.EDGDFPPKGDL = null;
		MaiNPC.GGFJGHHHEJC.inSpecialEvent = false;
		MaiNPC.GGFJGHHHEJC.blockActionBar = false;
		if (HELPKKFGIBO())
		{
			DialogueCameraTarget.GetPlayer(CJODOOFLLLB).ReturnControlToCameraTarget();
		}
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.animationBase.SetTrigger("HumanDisappear");
		yield return CommonReferences.wait3;
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		MaiNPC.GGFJGHHHEJC.dialogueActor.actor = "Mai";
		MaiNPC.GGFJGHHHEJC.ResetMai();
	}

	private void BEPAKMIFIJK(bool BFLCJPHHDJM)
	{
		MaiNPC maiNPC = MaiNPC.GGFJGHHHEJC;
		maiNPC.ConversationStarted = (Action<bool>)Delegate.Remove(maiNPC.ConversationStarted, new Action<bool>(PHENEPGPJKO));
		if (BFLCJPHHDJM)
		{
			CJODOOFLLLB = MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO;
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: true);
		}
	}

	public override void EndEvent(bool _sendOnline)
	{
		base.EndEvent(_sendOnline);
		((MonoBehaviour)instance).StartCoroutine(instance.LJABJLDHLCB());
		PsaiCore.Instance.HoldCurrentIntensity(hold: false);
		PsaiCore.Instance.StopMusic(immediately: false);
		MusicController.instance.TriggerCurrentBasicMood(CommonReferences.wait12, Location.Tavern);
	}

	private IEnumerator KCDPOBJCCOI()
	{
		instance.EDGDFPPKGDL = null;
		MaiNPC.GGFJGHHHEJC.inSpecialEvent = false;
		MaiNPC.GGFJGHHHEJC.blockActionBar = false;
		if (HELPKKFGIBO())
		{
			DialogueCameraTarget.GetPlayer(CJODOOFLLLB).ReturnControlToCameraTarget();
		}
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.animationBase.SetTrigger("HumanDisappear");
		yield return CommonReferences.wait3;
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		MaiNPC.GGFJGHHHEJC.dialogueActor.actor = "Mai";
		MaiNPC.GGFJGHHHEJC.ResetMai();
	}

	private IEnumerator FECCGCOIEDJ()
	{
		instance.EDGDFPPKGDL = null;
		MaiNPC.GGFJGHHHEJC.inSpecialEvent = false;
		MaiNPC.GGFJGHHHEJC.blockActionBar = false;
		if (HELPKKFGIBO())
		{
			DialogueCameraTarget.GetPlayer(CJODOOFLLLB).ReturnControlToCameraTarget();
		}
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.animationBase.SetTrigger("HumanDisappear");
		yield return CommonReferences.wait3;
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		MaiNPC.GGFJGHHHEJC.dialogueActor.actor = "Mai";
		MaiNPC.GGFJGHHHEJC.ResetMai();
	}

	private IEnumerator ELFPIDGFEHH()
	{
		instance.EDGDFPPKGDL = null;
		MaiNPC.GGFJGHHHEJC.inSpecialEvent = false;
		MaiNPC.GGFJGHHHEJC.blockActionBar = false;
		if (HELPKKFGIBO())
		{
			DialogueCameraTarget.GetPlayer(CJODOOFLLLB).ReturnControlToCameraTarget();
		}
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.animationBase.SetTrigger("HumanDisappear");
		yield return CommonReferences.wait3;
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		MaiNPC.GGFJGHHHEJC.dialogueActor.actor = "Mai";
		MaiNPC.GGFJGHHHEJC.ResetMai();
	}

	private bool DPKBAPCKKGD()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		return Utils.JANBGCMGMEE(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position), 1086f);
	}

	private IEnumerator GCCEMJEJLLM()
	{
		return new BOCIKGGENMN(1)
		{
			_003C_003E4__this = this
		};
	}
}
