using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BalanceEvent : GameEvent
{
	private enum LOGEKNJJJOB
	{
		GoToMinigame
	}

	[CompilerGenerated]
	private sealed class DEBIHNJBDJO : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BalanceEvent _003C_003E4__this;

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
		public DEBIHNJBDJO(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0118: Unknown result type (might be due to invalid IL or missing references)
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			BalanceEvent balanceEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				if (OnlineManager.MasterOrOffline())
				{
					ZuzzuNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(balanceEvent.movePositions[1].position), Direction.Right);
				}
				PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)balanceEvent);
				FadeCamera.GetPlayer(1).FadeOut(0.4f);
				FadeCamera.GetPlayer(1).JDKHJJIOLOE += balanceEvent.HHGEKEKHDNK;
				if (GameManager.LocalCoop())
				{
					FadeCamera.GetPlayer(2).FadeOut(0.4f);
				}
				if (instance.isActor)
				{
					instance.inPosition = false;
					_003C_003E2__current = CommonReferences.wait05;
					_003C_003E1__state = 1;
					return true;
				}
				break;
			case 1:
				_003C_003E1__state = -1;
				PlayerController.GetPlayer(balanceEvent.CJODOOFLLLB).GoToPosition(Vector2.op_Implicit(balanceEvent.movePositions[0].position), KLGOCJMGKFO: true);
				goto IL_0105;
			case 2:
				{
					_003C_003E1__state = -1;
					goto IL_0105;
				}
				IL_0105:
				if (!PlayerController.GetPlayer(balanceEvent.CJODOOFLLLB).GoToPosition(Vector2.op_Implicit(balanceEvent.movePositions[0].position), KLGOCJMGKFO: false) && !instance.inPosition)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 2;
					return true;
				}
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
	private sealed class AFMGFOPKCEF : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BalanceEvent _003C_003E4__this;

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
		public AFMGFOPKCEF(int _003C_003E1__state)
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
			BalanceEvent balanceEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
			{
				_003C_003E1__state = -1;
				FadeCamera player = FadeCamera.GetPlayer(1);
				player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(balanceEvent.GEHNCBAJNKP));
				_003C_003E2__current = CommonReferences.wait1_5;
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
				PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)balanceEvent);
				instance.EDGDFPPKGDL = ZuzzuNPC.GGFJGHHHEJC;
				instance.MDFALJKHKED = "Balance/MainEvent2";
				if (OnlineManager.MasterOrOffline())
				{
					instance.isActor = true;
					ZuzzuNPC.GGFJGHHHEJC.StartConversation(balanceEvent.CJODOOFLLLB, "Balance/MainEvent2");
				}
				else
				{
					instance.isActor = false;
					((MonoBehaviour)balanceEvent).StartCoroutine(ZuzzuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
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
	private sealed class ICCLALMIDCI : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public BalanceEvent _003C_003E4__this;

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
		public ICCLALMIDCI(int _003C_003E1__state)
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
			BalanceEvent balanceEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait3;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				_003C_003E2__current = OnlineManager.WaitForAllPlayers();
				_003C_003E1__state = 2;
				return true;
			case 2:
			{
				_003C_003E1__state = -1;
				FadeCamera.GetPlayer(1).JDKHJJIOLOE -= balanceEvent.HHGEKEKHDNK;
				BathhouseGameManager.instance.SetObjects();
				BathhouseGameManager.instance.SetInitialPosition();
				BathhouseGameManager.instance.HideUI();
				for (int i = 1; i < 5; i++)
				{
					if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null)
					{
						PlayerController.GetPlayer(i).characterCreator.BathhouseEnter();
					}
				}
				instance.inPosition = true;
				FadeCamera.GetPlayer(1).FadeInWithDelay();
				FadeCamera player = FadeCamera.GetPlayer(1);
				player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(balanceEvent.GEHNCBAJNKP));
				if (GameManager.LocalCoop())
				{
					FadeCamera.GetPlayer(2).FadeInWithDelay();
				}
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

	public static BalanceEvent instance;

	public Transform zuzzuPosition;

	public Transform[] movePositions;

	public Vector3 zuzzuInitialPositions;

	public bool inPosition;

	private void MEDKGNAFKDJ()
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			ZuzzuNPC.CHKMFEFOFKJ().routine.noDisableOnReset = true;
			KentaNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
			RinNPC.AFFGPMFKEFH().routine.noDisableOnReset = true;
			((Behaviour)ZuzzuNPC.OPDKAPNDBJE().routine).enabled = true;
			((Behaviour)KentaNPC.GGFJGHHHEJC.routine).enabled = true;
			((Behaviour)RinNPC.ABHIDHPMLLD().routine).enabled = true;
		}
		instance.zuzzuInitialPositions = ((Component)ZuzzuNPC.JHMAMLIPBNN()).transform.position;
		((Component)ZuzzuNPC.FJAMHCAAEAM()).transform.position = zuzzuPosition.position;
		ZuzzuNPC.DFJGHOHPPEL().content.SetActive(false);
		ZuzzuNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		KentaNPC.GGFJGHHHEJC.content.SetActive(true);
		RinNPC.ABHIDHPMLLD().content.SetActive(true);
	}

	private void EFLMOBCHKLL(bool BFLCJPHHDJM)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)("Check to enable" + BFLCJPHHDJM));
		if (BFLCJPHHDJM && Utils.CIEPGMEEBON(((Component)ZuzzuNPC.FJAMHCAAEAM()).transform.position, 243f))
		{
			CJODOOFLLLB = ZuzzuNPC.JFNOOMJMHCB().EHHOHCPHAAO;
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: true);
		}
	}

	private void ANFHOCJIKAL()
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			ZuzzuNPC.EBAIHKJHCCA().routine.noDisableOnReset = true;
			KentaNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
			RinNPC.OJJDNLEFNPJ().routine.noDisableOnReset = false;
			((Behaviour)ZuzzuNPC.EBAIHKJHCCA().routine).enabled = false;
			((Behaviour)KentaNPC.GGFJGHHHEJC.routine).enabled = false;
			((Behaviour)RinNPC.EBAIHKJHCCA().routine).enabled = true;
		}
		instance.zuzzuInitialPositions = ((Component)ZuzzuNPC.EBAIHKJHCCA()).transform.position;
		((Component)ZuzzuNPC.CHKMFEFOFKJ()).transform.position = zuzzuPosition.position;
		ZuzzuNPC.EBAIHKJHCCA().content.SetActive(true);
		ZuzzuNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		KentaNPC.GGFJGHHHEJC.content.SetActive(true);
		RinNPC.ABHIDHPMLLD().content.SetActive(true);
	}

	private IEnumerator OAAKANMLODC(int JIIGOACEIKL)
	{
		yield return CommonReferences.wait3;
		yield return OnlineManager.WaitForAllPlayers();
		FadeCamera.GetPlayer(1).JDKHJJIOLOE -= HHGEKEKHDNK;
		BathhouseGameManager.instance.SetObjects();
		BathhouseGameManager.instance.SetInitialPosition();
		BathhouseGameManager.instance.HideUI();
		for (int i = 1; i < 5; i++)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null)
			{
				PlayerController.GetPlayer(i).characterCreator.BathhouseEnter();
			}
		}
		instance.inPosition = true;
		FadeCamera.GetPlayer(1).FadeInWithDelay();
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(GEHNCBAJNKP));
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeInWithDelay();
		}
	}

	private void GLIPCHCDBKD()
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			ZuzzuNPC.EBAIHKJHCCA().routine.noDisableOnReset = false;
			KentaNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
			RinNPC.AFFGPMFKEFH().routine.noDisableOnReset = true;
			((Behaviour)ZuzzuNPC.OPDKAPNDBJE().routine).enabled = true;
			((Behaviour)KentaNPC.GGFJGHHHEJC.routine).enabled = true;
			((Behaviour)RinNPC.EBAIHKJHCCA().routine).enabled = true;
		}
		instance.zuzzuInitialPositions = ((Component)ZuzzuNPC.PNHHCHJCDNM()).transform.position;
		((Component)ZuzzuNPC.DFJGHOHPPEL()).transform.position = zuzzuPosition.position;
		ZuzzuNPC.DICHPHEOINO().content.SetActive(true);
		ZuzzuNPC.JFNOOMJMHCB().animationBase.SetDirection(Direction.Up);
		KentaNPC.GGFJGHHHEJC.content.SetActive(false);
		RinNPC.OJJDNLEFNPJ().content.SetActive(false);
	}

	private IEnumerator IMPACACMCON(bool ECJJHGJOEJJ)
	{
		if (OnlineManager.MasterOrOffline())
		{
			ZuzzuNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePositions[1].position), Direction.Right);
		}
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)this);
		FadeCamera.GetPlayer(1).FadeOut(0.4f);
		FadeCamera.GetPlayer(1).JDKHJJIOLOE += HHGEKEKHDNK;
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeOut(0.4f);
		}
		if (instance.isActor)
		{
			instance.inPosition = false;
			yield return CommonReferences.wait05;
			PlayerController.GetPlayer(CJODOOFLLLB).GoToPosition(Vector2.op_Implicit(movePositions[0].position), KLGOCJMGKFO: true);
			while (!PlayerController.GetPlayer(CJODOOFLLLB).GoToPosition(Vector2.op_Implicit(movePositions[0].position), KLGOCJMGKFO: false) && !instance.inPosition)
			{
				yield return null;
			}
		}
	}

	private IEnumerator JIFOIBCABLE(int JIIGOACEIKL)
	{
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(GEHNCBAJNKP));
		yield return CommonReferences.wait1_5;
		yield return OnlineManager.WaitForAllPlayers();
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)this);
		instance.EDGDFPPKGDL = ZuzzuNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "Balance/MainEvent2";
		if (OnlineManager.MasterOrOffline())
		{
			instance.isActor = true;
			ZuzzuNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "Balance/MainEvent2");
		}
		else
		{
			instance.isActor = false;
			((MonoBehaviour)this).StartCoroutine(ZuzzuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private void PHENEPGPJKO(bool BFLCJPHHDJM)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)(" with id " + BFLCJPHHDJM));
		if (BFLCJPHHDJM && Utils.CIEPGMEEBON(((Component)ZuzzuNPC.ELGNEJNLBNO()).transform.position, 568f))
		{
			CJODOOFLLLB = ZuzzuNPC.OAPOJCODNCO().EHHOHCPHAAO;
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: false);
		}
	}

	private IEnumerator HHGEKEKHDNK(int JIIGOACEIKL)
	{
		yield return CommonReferences.wait3;
		yield return OnlineManager.WaitForAllPlayers();
		FadeCamera.GetPlayer(1).JDKHJJIOLOE -= HHGEKEKHDNK;
		BathhouseGameManager.instance.SetObjects();
		BathhouseGameManager.instance.SetInitialPosition();
		BathhouseGameManager.instance.HideUI();
		for (int i = 1; i < 5; i++)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null)
			{
				PlayerController.GetPlayer(i).characterCreator.BathhouseEnter();
			}
		}
		instance.inPosition = true;
		FadeCamera.GetPlayer(1).FadeInWithDelay();
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(GEHNCBAJNKP));
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeInWithDelay();
		}
	}

	public void AFNBCIENIDJ(bool actor)
	{
		instance.EDGDFPPKGDL = null;
		ZuzzuNPC.DCAEBALADIM().blockActionBar = false;
		instance.isActor = actor;
		ZuzzuNPC zuzzuNPC = ZuzzuNPC.JHMAMLIPBNN();
		zuzzuNPC.ConversationStarted = (Action<bool>)Delegate.Remove(zuzzuNPC.ConversationStarted, new Action<bool>(BEPAKMIFIJK));
		((MonoBehaviour)instance).StartCoroutine(instance.BPEJLCMHDLJ(actor));
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
		BathhouseGameEvent.instance.CKLENDEPOLJ(OEDBPACCOGH: false, 924f);
	}

	private IEnumerator BNFGPJMEKLE(int JIIGOACEIKL)
	{
		return new AFMGFOPKCEF(1)
		{
			_003C_003E4__this = this
		};
	}

	public void GoToMinigame(bool actor)
	{
		instance.EDGDFPPKGDL = null;
		ZuzzuNPC.GGFJGHHHEJC.blockActionBar = true;
		instance.isActor = actor;
		ZuzzuNPC zuzzuNPC = ZuzzuNPC.GGFJGHHHEJC;
		zuzzuNPC.ConversationStarted = (Action<bool>)Delegate.Remove(zuzzuNPC.ConversationStarted, new Action<bool>(AEEHFGIDCMJ));
		((MonoBehaviour)instance).StartCoroutine(instance.LJEPDBDMLCP(actor));
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
		BathhouseGameEvent.instance.EnableNPCs(OEDBPACCOGH: false);
	}

	public override GameEvent GetInstance()
	{
		return instance;
	}

	private IEnumerator NDACBKNIACE(int JIIGOACEIKL)
	{
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(GEHNCBAJNKP));
		yield return CommonReferences.wait1_5;
		yield return OnlineManager.WaitForAllPlayers();
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)this);
		instance.EDGDFPPKGDL = ZuzzuNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "Balance/MainEvent2";
		if (OnlineManager.MasterOrOffline())
		{
			instance.isActor = true;
			ZuzzuNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "Balance/MainEvent2");
		}
		else
		{
			instance.isActor = false;
			((MonoBehaviour)this).StartCoroutine(ZuzzuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private void AEEHFGIDCMJ(bool BFLCJPHHDJM)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)("OnConversationStarted " + BFLCJPHHDJM));
		if (BFLCJPHHDJM && Utils.CIEPGMEEBON(((Component)ZuzzuNPC.GGFJGHHHEJC).transform.position, 10f))
		{
			CJODOOFLLLB = ZuzzuNPC.GGFJGHHHEJC.EHHOHCPHAAO;
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: true);
		}
	}

	private void GJBNMNBAJIP()
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			ZuzzuNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
			KentaNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
			RinNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
			((Behaviour)ZuzzuNPC.GGFJGHHHEJC.routine).enabled = false;
			((Behaviour)KentaNPC.GGFJGHHHEJC.routine).enabled = false;
			((Behaviour)RinNPC.GGFJGHHHEJC.routine).enabled = false;
		}
		instance.zuzzuInitialPositions = ((Component)ZuzzuNPC.GGFJGHHHEJC).transform.position;
		((Component)ZuzzuNPC.GGFJGHHHEJC).transform.position = zuzzuPosition.position;
		ZuzzuNPC.GGFJGHHHEJC.content.SetActive(true);
		ZuzzuNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		KentaNPC.GGFJGHHHEJC.content.SetActive(false);
		RinNPC.GGFJGHHHEJC.content.SetActive(false);
	}

	private IEnumerator HDNOPKLCKGA(int JIIGOACEIKL)
	{
		return new ICCLALMIDCI(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator DKAEKKKABJG(int JIIGOACEIKL)
	{
		return new AFMGFOPKCEF(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator MAJIPIOAKGM(bool ECJJHGJOEJJ)
	{
		if (OnlineManager.MasterOrOffline())
		{
			ZuzzuNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePositions[1].position), Direction.Right);
		}
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)this);
		FadeCamera.GetPlayer(1).FadeOut(0.4f);
		FadeCamera.GetPlayer(1).JDKHJJIOLOE += HHGEKEKHDNK;
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeOut(0.4f);
		}
		if (instance.isActor)
		{
			instance.inPosition = false;
			yield return CommonReferences.wait05;
			PlayerController.GetPlayer(CJODOOFLLLB).GoToPosition(Vector2.op_Implicit(movePositions[0].position), KLGOCJMGKFO: true);
			while (!PlayerController.GetPlayer(CJODOOFLLLB).GoToPosition(Vector2.op_Implicit(movePositions[0].position), KLGOCJMGKFO: false) && !instance.inPosition)
			{
				yield return null;
			}
		}
	}

	private IEnumerator LMDCHIKJAAH(int JIIGOACEIKL)
	{
		return new ICCLALMIDCI(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HIAPECEEJPL(bool ECJJHGJOEJJ)
	{
		if (OnlineManager.MasterOrOffline())
		{
			ZuzzuNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePositions[1].position), Direction.Right);
		}
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)this);
		FadeCamera.GetPlayer(1).FadeOut(0.4f);
		FadeCamera.GetPlayer(1).JDKHJJIOLOE += HHGEKEKHDNK;
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeOut(0.4f);
		}
		if (instance.isActor)
		{
			instance.inPosition = false;
			yield return CommonReferences.wait05;
			PlayerController.GetPlayer(CJODOOFLLLB).GoToPosition(Vector2.op_Implicit(movePositions[0].position), KLGOCJMGKFO: true);
			while (!PlayerController.GetPlayer(CJODOOFLLLB).GoToPosition(Vector2.op_Implicit(movePositions[0].position), KLGOCJMGKFO: false) && !instance.inPosition)
			{
				yield return null;
			}
		}
	}

	private void EPKIKKNBECB(int JIIGOACEIKL)
	{
		((MonoBehaviour)instance).StartCoroutine(JEIFHJIMCDH(JIIGOACEIKL));
	}

	private IEnumerator OKOPHBAMEJJ(int JIIGOACEIKL)
	{
		yield return CommonReferences.wait3;
		yield return OnlineManager.WaitForAllPlayers();
		FadeCamera.GetPlayer(1).JDKHJJIOLOE -= HHGEKEKHDNK;
		BathhouseGameManager.instance.SetObjects();
		BathhouseGameManager.instance.SetInitialPosition();
		BathhouseGameManager.instance.HideUI();
		for (int i = 1; i < 5; i++)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null)
			{
				PlayerController.GetPlayer(i).characterCreator.BathhouseEnter();
			}
		}
		instance.inPosition = true;
		FadeCamera.GetPlayer(1).FadeInWithDelay();
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(GEHNCBAJNKP));
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeInWithDelay();
		}
	}

	private IEnumerator KDOCJCNGMML(int JIIGOACEIKL)
	{
		yield return CommonReferences.wait3;
		yield return OnlineManager.WaitForAllPlayers();
		FadeCamera.GetPlayer(1).JDKHJJIOLOE -= HHGEKEKHDNK;
		BathhouseGameManager.instance.SetObjects();
		BathhouseGameManager.instance.SetInitialPosition();
		BathhouseGameManager.instance.HideUI();
		for (int i = 1; i < 5; i++)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null)
			{
				PlayerController.GetPlayer(i).characterCreator.BathhouseEnter();
			}
		}
		instance.inPosition = true;
		FadeCamera.GetPlayer(1).FadeInWithDelay();
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(GEHNCBAJNKP));
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeInWithDelay();
		}
	}

	private IEnumerator INLFALOEINK(bool ECJJHGJOEJJ)
	{
		if (OnlineManager.MasterOrOffline())
		{
			ZuzzuNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePositions[1].position), Direction.Right);
		}
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)this);
		FadeCamera.GetPlayer(1).FadeOut(0.4f);
		FadeCamera.GetPlayer(1).JDKHJJIOLOE += HHGEKEKHDNK;
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeOut(0.4f);
		}
		if (instance.isActor)
		{
			instance.inPosition = false;
			yield return CommonReferences.wait05;
			PlayerController.GetPlayer(CJODOOFLLLB).GoToPosition(Vector2.op_Implicit(movePositions[0].position), KLGOCJMGKFO: true);
			while (!PlayerController.GetPlayer(CJODOOFLLLB).GoToPosition(Vector2.op_Implicit(movePositions[0].position), KLGOCJMGKFO: false) && !instance.inPosition)
			{
				yield return null;
			}
		}
	}

	private void GDIPEIBGBDH(int JIIGOACEIKL)
	{
		((MonoBehaviour)instance).StartCoroutine(NDACBKNIACE(JIIGOACEIKL));
	}

	private void FOABKIGLBEE(bool BFLCJPHHDJM)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)("Crafting speed" + BFLCJPHHDJM));
		if (BFLCJPHHDJM && Utils.CIEPGMEEBON(((Component)ZuzzuNPC.KNLLFEJAMNN()).transform.position, 1146f))
		{
			CJODOOFLLLB = ZuzzuNPC.AHBBHCKPIIJ().EHHOHCPHAAO;
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: false);
		}
	}

	public void DMPGKMMAIOC(bool actor)
	{
		instance.EDGDFPPKGDL = null;
		ZuzzuNPC.JHMAMLIPBNN().blockActionBar = true;
		instance.isActor = actor;
		ZuzzuNPC zuzzuNPC = ZuzzuNPC.ELGNEJNLBNO();
		zuzzuNPC.ConversationStarted = (Action<bool>)Delegate.Remove(zuzzuNPC.ConversationStarted, new Action<bool>(EJAPJABCCDN));
		((MonoBehaviour)instance).StartCoroutine(instance.BPEJLCMHDLJ(actor));
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
		BathhouseGameEvent.instance.MEDLCCBICJE(OEDBPACCOGH: true, 659f);
	}

	private void FFEDAGCBGEB()
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			ZuzzuNPC.DICHPHEOINO().routine.noDisableOnReset = true;
			KentaNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
			RinNPC.OJJDNLEFNPJ().routine.noDisableOnReset = false;
			((Behaviour)ZuzzuNPC.OAPOJCODNCO().routine).enabled = false;
			((Behaviour)KentaNPC.GGFJGHHHEJC.routine).enabled = false;
			((Behaviour)RinNPC.AFFGPMFKEFH().routine).enabled = false;
		}
		instance.zuzzuInitialPositions = ((Component)ZuzzuNPC.FJAMHCAAEAM()).transform.position;
		((Component)ZuzzuNPC.KNLLFEJAMNN()).transform.position = zuzzuPosition.position;
		ZuzzuNPC.EBAIHKJHCCA().content.SetActive(true);
		ZuzzuNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
		KentaNPC.GGFJGHHHEJC.content.SetActive(false);
		RinNPC.GGFJGHHHEJC.content.SetActive(true);
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
			GoToMinigame(actor: false);
		}
	}

	private void EGPBGENJPGF()
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			ZuzzuNPC.CHKMFEFOFKJ().routine.noDisableOnReset = true;
			KentaNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
			RinNPC.OJJDNLEFNPJ().routine.noDisableOnReset = true;
			((Behaviour)ZuzzuNPC.DICHPHEOINO().routine).enabled = true;
			((Behaviour)KentaNPC.GGFJGHHHEJC.routine).enabled = true;
			((Behaviour)RinNPC.KNLLFEJAMNN().routine).enabled = false;
		}
		instance.zuzzuInitialPositions = ((Component)ZuzzuNPC.DICHPHEOINO()).transform.position;
		((Component)ZuzzuNPC.JHMAMLIPBNN()).transform.position = zuzzuPosition.position;
		ZuzzuNPC.ELGNEJNLBNO().content.SetActive(false);
		ZuzzuNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
		KentaNPC.GGFJGHHHEJC.content.SetActive(false);
		RinNPC.OPILDPFDFKJ().content.SetActive(true);
	}

	private void EJAPJABCCDN(bool BFLCJPHHDJM)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)(" </mark>" + BFLCJPHHDJM));
		if (BFLCJPHHDJM && Utils.CIEPGMEEBON(((Component)ZuzzuNPC.DCAEBALADIM()).transform.position, 644f))
		{
			CJODOOFLLLB = ZuzzuNPC.GGFJGHHHEJC.EHHOHCPHAAO;
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: true);
		}
	}

	public void FGJICGDIBHD()
	{
		EndEvent(BFLCJPHHDJM: false);
	}

	public void StartMinigame()
	{
		EndEvent(BFLCJPHHDJM: true);
	}

	public void GBCONPCKKBF()
	{
		EndEvent(BFLCJPHHDJM: false);
	}

	private void DBLAOOMDAMB(int JIIGOACEIKL)
	{
		((MonoBehaviour)instance).StartCoroutine(ENBJGFHBJEN(JIIGOACEIKL));
	}

	public override void ActivateEvent()
	{
		base.ActivateEvent();
		GJBNMNBAJIP();
		ZuzzuNPC zuzzuNPC = ZuzzuNPC.GGFJGHHHEJC;
		zuzzuNPC.ConversationStarted = (Action<bool>)Delegate.Combine(zuzzuNPC.ConversationStarted, new Action<bool>(AEEHFGIDCMJ));
	}

	public void NLHKLCGFCDN(bool actor)
	{
		instance.EDGDFPPKGDL = null;
		ZuzzuNPC.KNLLFEJAMNN().blockActionBar = false;
		instance.isActor = actor;
		ZuzzuNPC zuzzuNPC = ZuzzuNPC.CHPEMJMLDCN();
		zuzzuNPC.ConversationStarted = (Action<bool>)Delegate.Remove(zuzzuNPC.ConversationStarted, new Action<bool>(AEEHFGIDCMJ));
		((MonoBehaviour)instance).StartCoroutine(instance.IMPACACMCON(actor));
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 1);
		}
		BathhouseGameEvent.instance.OBGNPDKELIK(OEDBPACCOGH: true, 1167f);
	}

	private IEnumerator EKEILEOIJFM(int JIIGOACEIKL)
	{
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(GEHNCBAJNKP));
		yield return CommonReferences.wait1_5;
		yield return OnlineManager.WaitForAllPlayers();
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)this);
		instance.EDGDFPPKGDL = ZuzzuNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "Balance/MainEvent2";
		if (OnlineManager.MasterOrOffline())
		{
			instance.isActor = true;
			ZuzzuNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "Balance/MainEvent2");
		}
		else
		{
			instance.isActor = false;
			((MonoBehaviour)this).StartCoroutine(ZuzzuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private IEnumerator OPECBMELCAO(bool ECJJHGJOEJJ)
	{
		if (OnlineManager.MasterOrOffline())
		{
			ZuzzuNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePositions[1].position), Direction.Right);
		}
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)this);
		FadeCamera.GetPlayer(1).FadeOut(0.4f);
		FadeCamera.GetPlayer(1).JDKHJJIOLOE += HHGEKEKHDNK;
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeOut(0.4f);
		}
		if (instance.isActor)
		{
			instance.inPosition = false;
			yield return CommonReferences.wait05;
			PlayerController.GetPlayer(CJODOOFLLLB).GoToPosition(Vector2.op_Implicit(movePositions[0].position), KLGOCJMGKFO: true);
			while (!PlayerController.GetPlayer(CJODOOFLLLB).GoToPosition(Vector2.op_Implicit(movePositions[0].position), KLGOCJMGKFO: false) && !instance.inPosition)
			{
				yield return null;
			}
		}
	}

	public void NNNPNDIKAJN(bool actor)
	{
		instance.EDGDFPPKGDL = null;
		ZuzzuNPC.DCAEBALADIM().blockActionBar = true;
		instance.isActor = actor;
		ZuzzuNPC zuzzuNPC = ZuzzuNPC.JHMAMLIPBNN();
		zuzzuNPC.ConversationStarted = (Action<bool>)Delegate.Remove(zuzzuNPC.ConversationStarted, new Action<bool>(PHENEPGPJKO));
		((MonoBehaviour)instance).StartCoroutine(instance.IMPACACMCON(actor));
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 1);
		}
		BathhouseGameEvent.instance.OBGNPDKELIK(OEDBPACCOGH: true, 1434f);
	}

	private void PBBIEJANBEF(bool BFLCJPHHDJM)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)("[SelectSpawnersByMaxDistance] Ran out of candidates at step {0}/{1}." + BFLCJPHHDJM));
		if (BFLCJPHHDJM && Utils.CIEPGMEEBON(((Component)ZuzzuNPC.OPDKAPNDBJE()).transform.position, 37f))
		{
			CJODOOFLLLB = ZuzzuNPC.ELGNEJNLBNO().EHHOHCPHAAO;
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: false);
		}
	}

	private void FPKPKKDEKPO(bool BFLCJPHHDJM)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)("" + BFLCJPHHDJM));
		if (BFLCJPHHDJM && Utils.CIEPGMEEBON(((Component)ZuzzuNPC.PNHHCHJCDNM()).transform.position, 1033f))
		{
			CJODOOFLLLB = ZuzzuNPC.CHKMFEFOFKJ().EHHOHCPHAAO;
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: false);
		}
	}

	private IEnumerator EOGDILPILCH(bool ECJJHGJOEJJ)
	{
		if (OnlineManager.MasterOrOffline())
		{
			ZuzzuNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePositions[1].position), Direction.Right);
		}
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)this);
		FadeCamera.GetPlayer(1).FadeOut(0.4f);
		FadeCamera.GetPlayer(1).JDKHJJIOLOE += HHGEKEKHDNK;
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeOut(0.4f);
		}
		if (instance.isActor)
		{
			instance.inPosition = false;
			yield return CommonReferences.wait05;
			PlayerController.GetPlayer(CJODOOFLLLB).GoToPosition(Vector2.op_Implicit(movePositions[0].position), KLGOCJMGKFO: true);
			while (!PlayerController.GetPlayer(CJODOOFLLLB).GoToPosition(Vector2.op_Implicit(movePositions[0].position), KLGOCJMGKFO: false) && !instance.inPosition)
			{
				yield return null;
			}
		}
	}

	private IEnumerator ENBJGFHBJEN(int JIIGOACEIKL)
	{
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(GEHNCBAJNKP));
		yield return CommonReferences.wait1_5;
		yield return OnlineManager.WaitForAllPlayers();
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)this);
		instance.EDGDFPPKGDL = ZuzzuNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "Balance/MainEvent2";
		if (OnlineManager.MasterOrOffline())
		{
			instance.isActor = true;
			ZuzzuNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "Balance/MainEvent2");
		}
		else
		{
			instance.isActor = false;
			((MonoBehaviour)this).StartCoroutine(ZuzzuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private void CCJHLNKGJEK()
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			ZuzzuNPC.JHMAMLIPBNN().routine.noDisableOnReset = true;
			KentaNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
			RinNPC.POAGAIBEFBF().routine.noDisableOnReset = true;
			((Behaviour)ZuzzuNPC.OPDKAPNDBJE().routine).enabled = true;
			((Behaviour)KentaNPC.GGFJGHHHEJC.routine).enabled = true;
			((Behaviour)RinNPC.BNBMNOMFFBE().routine).enabled = false;
		}
		instance.zuzzuInitialPositions = ((Component)ZuzzuNPC.LFPEPJBNCBF()).transform.position;
		((Component)ZuzzuNPC.PNHHCHJCDNM()).transform.position = zuzzuPosition.position;
		ZuzzuNPC.OAPOJCODNCO().content.SetActive(true);
		ZuzzuNPC.DICHPHEOINO().animationBase.SetDirection(Direction.Down);
		KentaNPC.GGFJGHHHEJC.content.SetActive(false);
		RinNPC.OPILDPFDFKJ().content.SetActive(true);
	}

	private void MPNGOCJMPOI(bool BFLCJPHHDJM)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)("Jump" + BFLCJPHHDJM));
		if (BFLCJPHHDJM && Utils.CIEPGMEEBON(((Component)ZuzzuNPC.DICHPHEOINO()).transform.position, 621f))
		{
			CJODOOFLLLB = ZuzzuNPC.KNLLFEJAMNN().EHHOHCPHAAO;
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: true);
		}
	}

	private void BEPAKMIFIJK(bool BFLCJPHHDJM)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)("No players at the start of the scene. Spawning..." + BFLCJPHHDJM));
		if (BFLCJPHHDJM && Utils.CIEPGMEEBON(((Component)ZuzzuNPC.DICHPHEOINO()).transform.position, 533f))
		{
			CJODOOFLLLB = ZuzzuNPC.CHPEMJMLDCN().EHHOHCPHAAO;
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: true);
		}
	}

	private IEnumerator BOENJKGGOOC(int JIIGOACEIKL)
	{
		return new ICCLALMIDCI(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HLLGHPCPOPP(int JIIGOACEIKL)
	{
		return new AFMGFOPKCEF(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator OJCKPAKOPPE(bool ECJJHGJOEJJ)
	{
		if (OnlineManager.MasterOrOffline())
		{
			ZuzzuNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePositions[1].position), Direction.Right);
		}
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)this);
		FadeCamera.GetPlayer(1).FadeOut(0.4f);
		FadeCamera.GetPlayer(1).JDKHJJIOLOE += HHGEKEKHDNK;
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeOut(0.4f);
		}
		if (instance.isActor)
		{
			instance.inPosition = false;
			yield return CommonReferences.wait05;
			PlayerController.GetPlayer(CJODOOFLLLB).GoToPosition(Vector2.op_Implicit(movePositions[0].position), KLGOCJMGKFO: true);
			while (!PlayerController.GetPlayer(CJODOOFLLLB).GoToPosition(Vector2.op_Implicit(movePositions[0].position), KLGOCJMGKFO: false) && !instance.inPosition)
			{
				yield return null;
			}
		}
	}

	private void HEAEIIHKMJE(int JIIGOACEIKL)
	{
		((MonoBehaviour)instance).StartCoroutine(PJHFJCPCCMD(JIIGOACEIKL));
	}

	private IEnumerator INIJOGIIHNF(int JIIGOACEIKL)
	{
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(GEHNCBAJNKP));
		yield return CommonReferences.wait1_5;
		yield return OnlineManager.WaitForAllPlayers();
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)this);
		instance.EDGDFPPKGDL = ZuzzuNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "Balance/MainEvent2";
		if (OnlineManager.MasterOrOffline())
		{
			instance.isActor = true;
			ZuzzuNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "Balance/MainEvent2");
		}
		else
		{
			instance.isActor = false;
			((MonoBehaviour)this).StartCoroutine(ZuzzuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private void LHGONNPDPOK()
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			ZuzzuNPC.DFJGHOHPPEL().routine.noDisableOnReset = false;
			KentaNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
			RinNPC.OPILDPFDFKJ().routine.noDisableOnReset = true;
			((Behaviour)ZuzzuNPC.OAPOJCODNCO().routine).enabled = false;
			((Behaviour)KentaNPC.GGFJGHHHEJC.routine).enabled = false;
			((Behaviour)RinNPC.EBAIHKJHCCA().routine).enabled = true;
		}
		instance.zuzzuInitialPositions = ((Component)ZuzzuNPC.FJAMHCAAEAM()).transform.position;
		((Component)ZuzzuNPC.DICHPHEOINO()).transform.position = zuzzuPosition.position;
		ZuzzuNPC.JFJOKGAOPHA().content.SetActive(false);
		ZuzzuNPC.JFNOOMJMHCB().animationBase.SetDirection(Direction.Down);
		KentaNPC.GGFJGHHHEJC.content.SetActive(true);
		RinNPC.KNLLFEJAMNN().content.SetActive(false);
	}

	private void MEEBGBBAGPJ(bool BFLCJPHHDJM)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)("a" + BFLCJPHHDJM));
		if (BFLCJPHHDJM && Utils.CIEPGMEEBON(((Component)ZuzzuNPC.CHPEMJMLDCN()).transform.position, 25f))
		{
			CJODOOFLLLB = ZuzzuNPC.DICHPHEOINO().EHHOHCPHAAO;
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: false);
		}
	}

	private void OFIEGKMACFE()
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			ZuzzuNPC.CHKMFEFOFKJ().routine.noDisableOnReset = false;
			KentaNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
			RinNPC.EBAIHKJHCCA().routine.noDisableOnReset = true;
			((Behaviour)ZuzzuNPC.OPDKAPNDBJE().routine).enabled = true;
			((Behaviour)KentaNPC.GGFJGHHHEJC.routine).enabled = false;
			((Behaviour)RinNPC.EBAIHKJHCCA().routine).enabled = true;
		}
		instance.zuzzuInitialPositions = ((Component)ZuzzuNPC.JFJOKGAOPHA()).transform.position;
		((Component)ZuzzuNPC.EBAIHKJHCCA()).transform.position = zuzzuPosition.position;
		ZuzzuNPC.OPDKAPNDBJE().content.SetActive(false);
		ZuzzuNPC.CHKMFEFOFKJ().animationBase.SetDirection(Direction.Up);
		KentaNPC.GGFJGHHHEJC.content.SetActive(true);
		RinNPC.EBAIHKJHCCA().content.SetActive(true);
	}

	public void KEMEJEFHDGF(bool actor)
	{
		instance.EDGDFPPKGDL = null;
		ZuzzuNPC.DFJGHOHPPEL().blockActionBar = true;
		instance.isActor = actor;
		ZuzzuNPC zuzzuNPC = ZuzzuNPC.LFPEPJBNCBF();
		zuzzuNPC.ConversationStarted = (Action<bool>)Delegate.Remove(zuzzuNPC.ConversationStarted, new Action<bool>(MPNGOCJMPOI));
		((MonoBehaviour)instance).StartCoroutine(instance.IIMIGHKDCFL(actor));
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 1);
		}
		BathhouseGameEvent.instance.OBGNPDKELIK(OEDBPACCOGH: false, 1688f);
	}

	private IEnumerator DBGFOMMMIBK(int JIIGOACEIKL)
	{
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(GEHNCBAJNKP));
		yield return CommonReferences.wait1_5;
		yield return OnlineManager.WaitForAllPlayers();
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)this);
		instance.EDGDFPPKGDL = ZuzzuNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "Balance/MainEvent2";
		if (OnlineManager.MasterOrOffline())
		{
			instance.isActor = true;
			ZuzzuNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "Balance/MainEvent2");
		}
		else
		{
			instance.isActor = false;
			((MonoBehaviour)this).StartCoroutine(ZuzzuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	public void KKILPFMDOAG()
	{
		EndEvent(BFLCJPHHDJM: true);
	}

	private void EPCLGCGOALJ(int JIIGOACEIKL)
	{
		((MonoBehaviour)instance).StartCoroutine(JIFOIBCABLE(JIIGOACEIKL));
	}

	private IEnumerator LCAAGKJBNON(bool ECJJHGJOEJJ)
	{
		if (OnlineManager.MasterOrOffline())
		{
			ZuzzuNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePositions[1].position), Direction.Right);
		}
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)this);
		FadeCamera.GetPlayer(1).FadeOut(0.4f);
		FadeCamera.GetPlayer(1).JDKHJJIOLOE += HHGEKEKHDNK;
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeOut(0.4f);
		}
		if (instance.isActor)
		{
			instance.inPosition = false;
			yield return CommonReferences.wait05;
			PlayerController.GetPlayer(CJODOOFLLLB).GoToPosition(Vector2.op_Implicit(movePositions[0].position), KLGOCJMGKFO: true);
			while (!PlayerController.GetPlayer(CJODOOFLLLB).GoToPosition(Vector2.op_Implicit(movePositions[0].position), KLGOCJMGKFO: false) && !instance.inPosition)
			{
				yield return null;
			}
		}
	}

	private IEnumerator LJEPDBDMLCP(bool ECJJHGJOEJJ)
	{
		if (OnlineManager.MasterOrOffline())
		{
			ZuzzuNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePositions[1].position), Direction.Right);
		}
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)this);
		FadeCamera.GetPlayer(1).FadeOut(0.4f);
		FadeCamera.GetPlayer(1).JDKHJJIOLOE += HHGEKEKHDNK;
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeOut(0.4f);
		}
		if (instance.isActor)
		{
			instance.inPosition = false;
			yield return CommonReferences.wait05;
			PlayerController.GetPlayer(CJODOOFLLLB).GoToPosition(Vector2.op_Implicit(movePositions[0].position), KLGOCJMGKFO: true);
			while (!PlayerController.GetPlayer(CJODOOFLLLB).GoToPosition(Vector2.op_Implicit(movePositions[0].position), KLGOCJMGKFO: false) && !instance.inPosition)
			{
				yield return null;
			}
		}
	}

	public void GOLGOMHBDCC(bool actor)
	{
		instance.EDGDFPPKGDL = null;
		ZuzzuNPC.DICHPHEOINO().blockActionBar = true;
		instance.isActor = actor;
		ZuzzuNPC zuzzuNPC = ZuzzuNPC.LFPEPJBNCBF();
		zuzzuNPC.ConversationStarted = (Action<bool>)Delegate.Remove(zuzzuNPC.ConversationStarted, new Action<bool>(PBBIEJANBEF));
		((MonoBehaviour)instance).StartCoroutine(instance.LJEPDBDMLCP(actor));
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
		BathhouseGameEvent.instance.PHFCPPGBJEN(OEDBPACCOGH: false, 1094f);
	}

	protected override void Awake()
	{
		base.Awake();
		instance = this;
	}

	private IEnumerator FHFNKODOAIC(bool ECJJHGJOEJJ)
	{
		return new DEBIHNJBDJO(1)
		{
			_003C_003E4__this = this
		};
	}

	public override void StartEvent(bool BFLCJPHHDJM, bool CDPAMNIPPEC)
	{
		base.StartEvent(BFLCJPHHDJM, CDPAMNIPPEC);
		ZuzzuNPC zuzzuNPC = ZuzzuNPC.GGFJGHHHEJC;
		zuzzuNPC.ConversationStarted = (Action<bool>)Delegate.Remove(zuzzuNPC.ConversationStarted, new Action<bool>(AEEHFGIDCMJ));
		EDGDFPPKGDL = ZuzzuNPC.GGFJGHHHEJC;
		MDFALJKHKED = "Balance/MainEvent";
		if (!isActor && OnlineManager.PlayingOnline())
		{
			((MonoBehaviour)this).StartCoroutine(ZuzzuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private void IDCGHKMCPJB(int JIIGOACEIKL)
	{
		((MonoBehaviour)instance).StartCoroutine(OKBLMOFIJDN(JIIGOACEIKL));
	}

	private void MMBKLOGEPHM()
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			ZuzzuNPC.JHMAMLIPBNN().routine.noDisableOnReset = true;
			KentaNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
			RinNPC.KNLLFEJAMNN().routine.noDisableOnReset = true;
			((Behaviour)ZuzzuNPC.PNHHCHJCDNM().routine).enabled = false;
			((Behaviour)KentaNPC.GGFJGHHHEJC.routine).enabled = false;
			((Behaviour)RinNPC.OPILDPFDFKJ().routine).enabled = false;
		}
		instance.zuzzuInitialPositions = ((Component)ZuzzuNPC.FJAMHCAAEAM()).transform.position;
		((Component)ZuzzuNPC.GGFJGHHHEJC).transform.position = zuzzuPosition.position;
		ZuzzuNPC.KNLLFEJAMNN().content.SetActive(true);
		ZuzzuNPC.DICHPHEOINO().animationBase.SetDirection(Direction.Up);
		KentaNPC.GGFJGHHHEJC.content.SetActive(true);
		RinNPC.ABHIDHPMLLD().content.SetActive(false);
	}

	private void OHKJJGADFKL(bool BFLCJPHHDJM)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)("MainProgress" + BFLCJPHHDJM));
		if (BFLCJPHHDJM && Utils.CIEPGMEEBON(((Component)ZuzzuNPC.GGFJGHHHEJC).transform.position, 254f))
		{
			CJODOOFLLLB = ZuzzuNPC.GGFJGHHHEJC.EHHOHCPHAAO;
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: false);
		}
	}

	private IEnumerator INDOCKEKHPD(int JIIGOACEIKL)
	{
		yield return CommonReferences.wait3;
		yield return OnlineManager.WaitForAllPlayers();
		FadeCamera.GetPlayer(1).JDKHJJIOLOE -= HHGEKEKHDNK;
		BathhouseGameManager.instance.SetObjects();
		BathhouseGameManager.instance.SetInitialPosition();
		BathhouseGameManager.instance.HideUI();
		for (int i = 1; i < 5; i++)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null)
			{
				PlayerController.GetPlayer(i).characterCreator.BathhouseEnter();
			}
		}
		instance.inPosition = true;
		FadeCamera.GetPlayer(1).FadeInWithDelay();
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(GEHNCBAJNKP));
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeInWithDelay();
		}
	}

	public override void EndEvent(bool BFLCJPHHDJM)
	{
		base.EndEvent(BFLCJPHHDJM);
		instance.EDGDFPPKGDL = null;
		BathhouseGameEvent.instance.ActivateEvent(IANKECBCNPM: false);
		BathhouseGameManager.Begin();
	}

	private IEnumerator BPEJLCMHDLJ(bool ECJJHGJOEJJ)
	{
		if (OnlineManager.MasterOrOffline())
		{
			ZuzzuNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePositions[1].position), Direction.Right);
		}
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)this);
		FadeCamera.GetPlayer(1).FadeOut(0.4f);
		FadeCamera.GetPlayer(1).JDKHJJIOLOE += HHGEKEKHDNK;
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeOut(0.4f);
		}
		if (instance.isActor)
		{
			instance.inPosition = false;
			yield return CommonReferences.wait05;
			PlayerController.GetPlayer(CJODOOFLLLB).GoToPosition(Vector2.op_Implicit(movePositions[0].position), KLGOCJMGKFO: true);
			while (!PlayerController.GetPlayer(CJODOOFLLLB).GoToPosition(Vector2.op_Implicit(movePositions[0].position), KLGOCJMGKFO: false) && !instance.inPosition)
			{
				yield return null;
			}
		}
	}

	public void JIEEOABEHMB(bool actor)
	{
		instance.EDGDFPPKGDL = null;
		ZuzzuNPC.CHPEMJMLDCN().blockActionBar = true;
		instance.isActor = actor;
		ZuzzuNPC zuzzuNPC = ZuzzuNPC.GGFJGHHHEJC;
		zuzzuNPC.ConversationStarted = (Action<bool>)Delegate.Remove(zuzzuNPC.ConversationStarted, new Action<bool>(AEEHFGIDCMJ));
		((MonoBehaviour)instance).StartCoroutine(instance.LJEPDBDMLCP(actor));
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 1);
		}
		BathhouseGameEvent.instance.BEOIOKBKLJK(OEDBPACCOGH: false, 591f);
	}

	private void GGBCFKJBDGE(bool BFLCJPHHDJM)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)("UI" + BFLCJPHHDJM));
		if (BFLCJPHHDJM && Utils.CIEPGMEEBON(((Component)ZuzzuNPC.DICHPHEOINO()).transform.position, 128f))
		{
			CJODOOFLLLB = ZuzzuNPC.JFJOKGAOPHA().EHHOHCPHAAO;
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: false);
		}
	}

	private void NENIOEPHOLP(bool BFLCJPHHDJM)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)(" could not be removed because it does not exist" + BFLCJPHHDJM));
		if (BFLCJPHHDJM && Utils.CIEPGMEEBON(((Component)ZuzzuNPC.CHPEMJMLDCN()).transform.position, 1410f))
		{
			CJODOOFLLLB = ZuzzuNPC.CHKMFEFOFKJ().EHHOHCPHAAO;
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: false);
		}
	}

	private IEnumerator IIMIGHKDCFL(bool ECJJHGJOEJJ)
	{
		return new DEBIHNJBDJO(1)
		{
			_003C_003E4__this = this
		};
	}

	private void CCPJFPKHBIC()
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			ZuzzuNPC.CHPEMJMLDCN().routine.noDisableOnReset = true;
			KentaNPC.GGFJGHHHEJC.routine.noDisableOnReset = false;
			RinNPC.GGFJGHHHEJC.routine.noDisableOnReset = true;
			((Behaviour)ZuzzuNPC.PNHHCHJCDNM().routine).enabled = false;
			((Behaviour)KentaNPC.GGFJGHHHEJC.routine).enabled = false;
			((Behaviour)RinNPC.KNLLFEJAMNN().routine).enabled = false;
		}
		instance.zuzzuInitialPositions = ((Component)ZuzzuNPC.OPDKAPNDBJE()).transform.position;
		((Component)ZuzzuNPC.PNHHCHJCDNM()).transform.position = zuzzuPosition.position;
		ZuzzuNPC.JHMAMLIPBNN().content.SetActive(false);
		ZuzzuNPC.PNHHCHJCDNM().animationBase.SetDirection(Direction.Up);
		KentaNPC.GGFJGHHHEJC.content.SetActive(false);
		RinNPC.KNLLFEJAMNN().content.SetActive(false);
	}

	private IEnumerator PJHFJCPCCMD(int JIIGOACEIKL)
	{
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(GEHNCBAJNKP));
		yield return CommonReferences.wait1_5;
		yield return OnlineManager.WaitForAllPlayers();
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)this);
		instance.EDGDFPPKGDL = ZuzzuNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "Balance/MainEvent2";
		if (OnlineManager.MasterOrOffline())
		{
			instance.isActor = true;
			ZuzzuNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "Balance/MainEvent2");
		}
		else
		{
			instance.isActor = false;
			((MonoBehaviour)this).StartCoroutine(ZuzzuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private IEnumerator HOJEHGNOBME(int JIIGOACEIKL)
	{
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(GEHNCBAJNKP));
		yield return CommonReferences.wait1_5;
		yield return OnlineManager.WaitForAllPlayers();
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)this);
		instance.EDGDFPPKGDL = ZuzzuNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "Balance/MainEvent2";
		if (OnlineManager.MasterOrOffline())
		{
			instance.isActor = true;
			ZuzzuNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "Balance/MainEvent2");
		}
		else
		{
			instance.isActor = false;
			((MonoBehaviour)this).StartCoroutine(ZuzzuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private IEnumerator DOKOLLCNIIM(int JIIGOACEIKL)
	{
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(GEHNCBAJNKP));
		yield return CommonReferences.wait1_5;
		yield return OnlineManager.WaitForAllPlayers();
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)this);
		instance.EDGDFPPKGDL = ZuzzuNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "Balance/MainEvent2";
		if (OnlineManager.MasterOrOffline())
		{
			instance.isActor = true;
			ZuzzuNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "Balance/MainEvent2");
		}
		else
		{
			instance.isActor = false;
			((MonoBehaviour)this).StartCoroutine(ZuzzuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private void GEHNCBAJNKP(int JIIGOACEIKL)
	{
		((MonoBehaviour)instance).StartCoroutine(DOKOLLCNIIM(JIIGOACEIKL));
	}

	private IEnumerator OKBLMOFIJDN(int JIIGOACEIKL)
	{
		return new AFMGFOPKCEF(1)
		{
			_003C_003E4__this = this
		};
	}

	public void JAJNIMCHCPJ(bool actor)
	{
		instance.EDGDFPPKGDL = null;
		ZuzzuNPC.DCAEBALADIM().blockActionBar = true;
		instance.isActor = actor;
		ZuzzuNPC zuzzuNPC = ZuzzuNPC.CHPEMJMLDCN();
		zuzzuNPC.ConversationStarted = (Action<bool>)Delegate.Remove(zuzzuNPC.ConversationStarted, new Action<bool>(NENIOEPHOLP));
		((MonoBehaviour)instance).StartCoroutine(instance.OPECBMELCAO(actor));
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
		BathhouseGameEvent.instance.EINHGPDGHMK(OEDBPACCOGH: true, 1374f);
	}

	private IEnumerator JEIFHJIMCDH(int JIIGOACEIKL)
	{
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(GEHNCBAJNKP));
		yield return CommonReferences.wait1_5;
		yield return OnlineManager.WaitForAllPlayers();
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)this);
		instance.EDGDFPPKGDL = ZuzzuNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "Balance/MainEvent2";
		if (OnlineManager.MasterOrOffline())
		{
			instance.isActor = true;
			ZuzzuNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "Balance/MainEvent2");
		}
		else
		{
			instance.isActor = false;
			((MonoBehaviour)this).StartCoroutine(ZuzzuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}
}
