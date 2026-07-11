using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PrecisionEvent : GameEvent
{
	private enum LOGEKNJJJOB
	{
		FirstConversationEnd,
		StartDrink,
		BlackScreen
	}

	[CompilerGenerated]
	private sealed class LBLNCMJGOLB : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PrecisionEvent _003C_003E4__this;

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
		public LBLNCMJGOLB(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			PrecisionEvent precisionEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				precisionEvent.EDGDFPPKGDL = null;
				if (OnlineManager.MasterOrOffline())
				{
					KujakuNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(precisionEvent.movePositions[1].position), Direction.Right);
				}
				if (instance.isActor)
				{
					precisionEvent.SetTableParent(precisionEvent.CJODOOFLLLB, sendOnline: true);
					PlayerController.GetPlayer(precisionEvent.CJODOOFLLLB).GoToPosition(Vector2.op_Implicit(instance.movePositions[0].position), KLGOCJMGKFO: true);
					goto IL_00ba;
				}
				goto IL_0166;
			case 1:
				_003C_003E1__state = -1;
				goto IL_00ba;
			case 2:
				_003C_003E1__state = -1;
				_003C_003E2__current = OnlineManager.WaitForAllPlayers();
				_003C_003E1__state = 3;
				return true;
			case 3:
				_003C_003E1__state = -1;
				instance.EDGDFPPKGDL = KujakuNPC.GGFJGHHHEJC;
				instance.MDFALJKHKED = "Precision/DrinkEvent1";
				if (instance.isActor)
				{
					KujakuNPC.GGFJGHHHEJC.StartConversation(precisionEvent.CJODOOFLLLB, "Precision/DrinkEvent1");
				}
				else if (OnlineManager.PlayingOnline())
				{
					_003C_003E2__current = KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
					_003C_003E1__state = 4;
					return true;
				}
				break;
			case 4:
				{
					_003C_003E1__state = -1;
					break;
				}
				IL_0166:
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 2;
				return true;
				IL_00ba:
				if (!PlayerController.GetPlayer(precisionEvent.CJODOOFLLLB).GoToPosition(Vector2.op_Implicit(instance.movePositions[0].position), KLGOCJMGKFO: false))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
				((Component)PlayerController.GetPlayer(precisionEvent.CJODOOFLLLB)).transform.position = instance.playerDrinkPosition.position;
				((Component)PlayerController.GetPlayer(precisionEvent.CJODOOFLLLB).characterAnimation.characterAnimator.eatingSpritesToActivate).transform.parent = instance.kujakuTable.transform;
				PlayerController.GetPlayer(precisionEvent.CJODOOFLLLB).characterAnimation.SetDirection(Direction.Down);
				PlayerController.GetPlayer(precisionEvent.CJODOOFLLLB).characterAnimation.Sit(Direction.Down);
				goto IL_0166;
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
	private sealed class JIHIHDJAKCD : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PrecisionEvent _003C_003E4__this;

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
		public JIHIHDJAKCD(int _003C_003E1__state)
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
			PrecisionEvent precisionEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				FadeCamera.GetPlayer(1).JDKHJJIOLOE -= precisionEvent.HHGEKEKHDNK;
				instance.EDGDFPPKGDL = KujakuNPC.GGFJGHHHEJC;
				instance.MDFALJKHKED = "Precision/DrinkEvent6";
				_003C_003E2__current = OnlineManager.WaitForAllPlayers();
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				if (instance.isActor)
				{
					KujakuNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "Precision/DrinkEvent6");
				}
				else if (OnlineManager.PlayingOnline())
				{
					((MonoBehaviour)precisionEvent).StartCoroutine(KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
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

	public static PrecisionEvent instance;

	public NPCRoutine kujakuRoutine;

	public Transform[] characterPositions;

	public Transform[] movePositions;

	public Transform playerDrinkPosition;

	public GameObject sake;

	public GameObject kujakuTable;

	public SakeDrinker sakeDrinker;

	public AwningManager awningManager;

	public GameObject kujakuSignal;

	public Vector3 hikariInitialPositions;

	private IEnumerator DALBJEOPLEI()
	{
		EDGDFPPKGDL = null;
		if (OnlineManager.MasterOrOffline())
		{
			KujakuNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePositions[1].position), Direction.Right);
		}
		if (instance.isActor)
		{
			SetTableParent(CJODOOFLLLB, sendOnline: true);
			PlayerController.GetPlayer(CJODOOFLLLB).GoToPosition(Vector2.op_Implicit(instance.movePositions[0].position), KLGOCJMGKFO: true);
			while (!PlayerController.GetPlayer(CJODOOFLLLB).GoToPosition(Vector2.op_Implicit(instance.movePositions[0].position), KLGOCJMGKFO: false))
			{
				yield return null;
			}
			((Component)PlayerController.GetPlayer(CJODOOFLLLB)).transform.position = instance.playerDrinkPosition.position;
			((Component)PlayerController.GetPlayer(CJODOOFLLLB).characterAnimation.characterAnimator.eatingSpritesToActivate).transform.parent = instance.kujakuTable.transform;
			PlayerController.GetPlayer(CJODOOFLLLB).characterAnimation.SetDirection(Direction.Down);
			PlayerController.GetPlayer(CJODOOFLLLB).characterAnimation.Sit(Direction.Down);
		}
		yield return CommonReferences.wait1;
		yield return OnlineManager.WaitForAllPlayers();
		instance.EDGDFPPKGDL = KujakuNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "Precision/DrinkEvent1";
		if (instance.isActor)
		{
			KujakuNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "Precision/DrinkEvent1");
		}
		else if (OnlineManager.PlayingOnline())
		{
			yield return KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private IEnumerator AKCKLKNICEL(int JIIGOACEIKL)
	{
		yield return null;
		FadeCamera.GetPlayer(1).JDKHJJIOLOE -= HHGEKEKHDNK;
		instance.EDGDFPPKGDL = KujakuNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "Precision/DrinkEvent6";
		yield return OnlineManager.WaitForAllPlayers();
		if (instance.isActor)
		{
			KujakuNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "Precision/DrinkEvent6");
		}
		else if (OnlineManager.PlayingOnline())
		{
			((MonoBehaviour)this).StartCoroutine(KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	public void JODCCHDKGPE()
	{
		instance.EDGDFPPKGDL = null;
		if (instance.isActor)
		{
			PlayerInputs.EnableKeyboardInputs(instance.CJODOOFLLLB, (MonoBehaviour)(object)instance);
			if (Object.op_Implicit((Object)(object)ActionBarInventory.MHDKNEKDKII(instance.CJODOOFLLLB)))
			{
				ActionBarInventory.BNMEANGDMIP(instance.CJODOOFLLLB, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AddActionBarBlockers((MonoBehaviour)(object)instance);
			}
			instance.sakeDrinker.canDrink = true;
			if (instance.isActor && OnlineManager.PlayingOnline())
			{
				OnlineEventsManager.SendSimpleEvent(eventType, 1);
			}
		}
		else
		{
			PlayerInputs.CMEBIMMKIAB((MonoBehaviour)(object)instance);
		}
	}

	private void CKOHHFFMHGN(bool BFLCJPHHDJM)
	{
		Debug.Log((object)("Gameplay" + BFLCJPHHDJM + "Received finish minigame" + KujakuNPC.MAAAKALBBEE().EHHOHCPHAAO));
		if (BFLCJPHHDJM && Utils.MMMFJPKECAB(~(Location.Tavern | Location.River | Location.Camp | Location.Quarry | Location.Farm | Location.FarmShop)))
		{
			CJODOOFLLLB = KujakuNPC.EKDNJDJHONF().EHHOHCPHAAO;
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: false);
		}
	}

	public void AFJGDGBGIFC()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.BCPKAOHHCGH());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 1);
		}
	}

	public void PBKGMNMKDLN()
	{
		instance.EDGDFPPKGDL = null;
		if (instance.isActor)
		{
			PlayerInputs.DEPNDGJDKOL(instance.CJODOOFLLLB, (MonoBehaviour)(object)instance);
			if (Object.op_Implicit((Object)(object)ActionBarInventory.DACNEICGAAE(instance.CJODOOFLLLB, LAGHIOKLJGH: true, ADPNMHGBFKG: true)))
			{
				ActionBarInventory.ADHIHCNAKFP(instance.CJODOOFLLLB).AddActionBarBlockers((MonoBehaviour)(object)instance);
			}
			instance.sakeDrinker.canDrink = true;
			if (instance.isActor && OnlineManager.PlayingOnline())
			{
				OnlineEventsManager.SendSimpleEvent(eventType, 1);
			}
		}
		else
		{
			PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		}
	}

	public void HMNGIAIIFDO()
	{
		instance.EDGDFPPKGDL = null;
		if (instance.isActor)
		{
			PlayerInputs.POBGMHINPHA(instance.CJODOOFLLLB, (MonoBehaviour)(object)instance);
			if (Object.op_Implicit((Object)(object)ActionBarInventory.BNMEANGDMIP(instance.CJODOOFLLLB, LAGHIOKLJGH: true, ADPNMHGBFKG: true)))
			{
				ActionBarInventory.GetPlayer(instance.CJODOOFLLLB).OIMDEHAGLIG((MonoBehaviour)(object)instance);
			}
			instance.sakeDrinker.canDrink = true;
			if (instance.isActor && OnlineManager.PlayingOnline())
			{
				OnlineEventsManager.SendSimpleEvent(eventType, 1);
			}
		}
		else
		{
			PlayerInputs.CMEBIMMKIAB((MonoBehaviour)(object)instance);
		}
	}

	public void CNLJONPCNKO()
	{
		instance.EDGDFPPKGDL = null;
		if (instance.isActor)
		{
			PlayerInputs.POBGMHINPHA(instance.CJODOOFLLLB, (MonoBehaviour)(object)instance, FLHBPHPKIML: true);
			if (Object.op_Implicit((Object)(object)ActionBarInventory.ADHIHCNAKFP(instance.CJODOOFLLLB)))
			{
				ActionBarInventory.IPBEEBLCHHA(instance.CJODOOFLLLB).AddActionBarBlockers((MonoBehaviour)(object)instance);
			}
			instance.sakeDrinker.canDrink = false;
			if (instance.isActor && OnlineManager.PlayingOnline())
			{
				OnlineEventsManager.SendSimpleEvent(eventType, 0);
			}
		}
		else
		{
			PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance, ANJCLPDCJHL: true);
		}
	}

	private IEnumerator KACGHLPFMMO(int JIIGOACEIKL)
	{
		return new JIHIHDJAKCD(1)
		{
			_003C_003E4__this = this
		};
	}

	private void OIIHPNBIMHB()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			awningManager.awningControllers.LMDMMHLAIOE();
			kujakuRoutine.noDisableOnReset = false;
			((Behaviour)kujakuRoutine).enabled = false;
		}
		kujakuSignal.SetActive(true);
		sake.SetActive(false);
		((Component)KujakuNPC.BADFKMEJOKE()).transform.position = characterPositions[1].position;
		KujakuNPC.NEFIEJALANL().content.SetActive(true);
		KujakuNPC.LANAINBEMCM().animationBase.SetBool("Coming soon!", EGFGNGJGBOP: true, HALNIEBONKH: true);
		KujakuNPC.DEGPIHEEFHJ().animationBase.SetDirection(Direction.Up);
		((Component)HikariNPC.EKDNJDJHONF()).transform.position = characterPositions[0].position;
		HikariNPC.EKDNJDJHONF().content.SetActive(true);
		HikariNPC.ABDJJBFNLBJ().animationBase.CGEADHOLHCH("Dialogue System/Conversation/Rowdy/Entry/5/Dialogue Text", EGFGNGJGBOP: true);
		HikariNPC.EFPJLFMBPLL().animationBase.SetDirection(Direction.Diagonal);
		HikariNPC.ABDJJBFNLBJ().inScene = true;
	}

	private void BBHLPAKDHGL()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			awningManager.awningControllers.DDFIFCLBBLF();
			kujakuRoutine.noDisableOnReset = true;
			((Behaviour)kujakuRoutine).enabled = false;
		}
		kujakuSignal.SetActive(false);
		sake.SetActive(false);
		((Component)KujakuNPC.GGFJGHHHEJC).transform.position = characterPositions[1].position;
		KujakuNPC.EKDNJDJHONF().content.SetActive(true);
		KujakuNPC.EKDNJDJHONF().animationBase.SetBool("-1", EGFGNGJGBOP: true);
		KujakuNPC.NEFIEJALANL().animationBase.SetDirection(Direction.Up);
		((Component)HikariNPC.ABDJJBFNLBJ()).transform.position = characterPositions[1].position;
		HikariNPC.GGFJGHHHEJC.content.SetActive(false);
		HikariNPC.OFLELHKKNKC().animationBase.CGEADHOLHCH("Error in ProceduralMine.OnPlayerSleep: ", EGFGNGJGBOP: false);
		HikariNPC.GGFJGHHHEJC.animationBase.SetDirection((Direction)7);
		HikariNPC.ABDJJBFNLBJ().inScene = false;
	}

	public void NAIELECELCG()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.BCPKAOHHCGH());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 1);
		}
	}

	public void FPKAKLNEDNJ()
	{
		FadeCamera.EIFPKCAFDIB(1).FadeOut(1170f);
		FadeCamera.IGMCBPOPNCA(0).HDDEGMGIBDM(instance.AKCKLKNICEL);
		if (GameManager.LocalCoop())
		{
			FadeCamera.IGMCBPOPNCA(1).GPBOEBGJJPM(999f);
		}
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 7);
		}
	}

	public void KHALPOOFJOH()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.OCOAOPJEBBF());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
	}

	public void PPJKLPHKDAE(int playerNum, bool sendOnline)
	{
		if ((Object)(object)PlayerController.GetPlayer(playerNum) != (Object)null && (Object)(object)instance.kujakuTable != (Object)null)
		{
			((Component)PlayerController.GetPlayer(playerNum)).transform.parent = instance.kujakuTable.transform;
			((Behaviour)instance.kujakuTable.GetComponent<BoxCollider2D>()).enabled = true;
		}
		if (sendOnline && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSetTableParent((byte)OnlinePlayerDataManager.JBDEFDMGCDA(playerNum));
		}
	}

	private IEnumerator OIIPDODGLHE(int JIIGOACEIKL)
	{
		return new JIHIHDJAKCD(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LOAAKDFKJPH(int JIIGOACEIKL)
	{
		yield return null;
		FadeCamera.GetPlayer(1).JDKHJJIOLOE -= HHGEKEKHDNK;
		instance.EDGDFPPKGDL = KujakuNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "Precision/DrinkEvent6";
		yield return OnlineManager.WaitForAllPlayers();
		if (instance.isActor)
		{
			KujakuNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "Precision/DrinkEvent6");
		}
		else if (OnlineManager.PlayingOnline())
		{
			((MonoBehaviour)this).StartCoroutine(KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	public override void EndEvent(bool BFLCJPHHDJM)
	{
		instance.EDGDFPPKGDL = null;
		base.EndEvent(BFLCJPHHDJM);
		instance.sakeDrinker.SetActive(AODONKKHPBP: false);
		KujakuNPC.GGFJGHHHEJC.blockActionBar = false;
		((Behaviour)instance.kujakuTable.GetComponent<BoxCollider2D>()).enabled = true;
		if (OnlineManager.PlayingOnline())
		{
			for (int i = 1; i <= 4; i++)
			{
				if (Object.op_Implicit((Object)(object)PlayerController.GetPlayer(i)))
				{
					((Component)PlayerController.GetPlayer(i)).transform.parent = null;
				}
			}
		}
		else
		{
			((Component)PlayerController.GetPlayer(instance.CJODOOFLLLB)).transform.parent = null;
		}
		PlayerController.GetPlayer(instance.CJODOOFLLLB).characterAnimation.Stand();
		if (Object.op_Implicit((Object)(object)ActionBarInventory.GetPlayer(instance.CJODOOFLLLB)))
		{
			ActionBarInventory.GetPlayer(instance.CJODOOFLLLB).RemoveActionBarBlockers((MonoBehaviour)(object)instance);
		}
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		FishCuttingEvent.instance.StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: false);
	}

	private void MDJNKPBBKPH()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			awningManager.awningControllers.BIFHACGLOJJ();
			kujakuRoutine.noDisableOnReset = true;
			((Behaviour)kujakuRoutine).enabled = false;
		}
		kujakuSignal.SetActive(false);
		sake.SetActive(true);
		((Component)KujakuNPC.LANAINBEMCM()).transform.position = characterPositions[0].position;
		KujakuNPC.LANAINBEMCM().content.SetActive(false);
		KujakuNPC.BADFKMEJOKE().animationBase.SetBool("SetUpImportantGuest", EGFGNGJGBOP: false, HALNIEBONKH: true);
		KujakuNPC.NEFIEJALANL().animationBase.SetDirection(Direction.Up);
		((Component)HikariNPC.EFPJLFMBPLL()).transform.position = characterPositions[1].position;
		HikariNPC.OFLELHKKNKC().content.SetActive(true);
		HikariNPC.MNFMOEKMJKN().animationBase.SetBool("full", EGFGNGJGBOP: false, HALNIEBONKH: true);
		HikariNPC.OFLELHKKNKC().animationBase.SetDirection(Direction.Left);
		HikariNPC.EFPJLFMBPLL().inScene = true;
	}

	private IEnumerator JCKADDOIPCA(int JIIGOACEIKL)
	{
		yield return null;
		FadeCamera.GetPlayer(1).JDKHJJIOLOE -= HHGEKEKHDNK;
		instance.EDGDFPPKGDL = KujakuNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "Precision/DrinkEvent6";
		yield return OnlineManager.WaitForAllPlayers();
		if (instance.isActor)
		{
			KujakuNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "Precision/DrinkEvent6");
		}
		else if (OnlineManager.PlayingOnline())
		{
			((MonoBehaviour)this).StartCoroutine(KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	public override void StartEvent(bool BFLCJPHHDJM, bool CDPAMNIPPEC)
	{
		base.StartEvent(BFLCJPHHDJM, CDPAMNIPPEC);
		KujakuNPC.GGFJGHHHEJC.blockActionBar = true;
		KujakuNPC kujakuNPC = KujakuNPC.GGFJGHHHEJC;
		kujakuNPC.ConversationStarted = (Action<bool>)Delegate.Remove(kujakuNPC.ConversationStarted, new Action<bool>(AEEHFGIDCMJ));
		KujakuNPC.GGFJGHHHEJC.animationBase.SetBool("Hanghover", EGFGNGJGBOP: false);
		KujakuNPC.GGFJGHHHEJC.barkDialogue = false;
		EDGDFPPKGDL = KujakuNPC.GGFJGHHHEJC;
		MDFALJKHKED = "NoEresDigno/MainEvent";
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		if (OnlineManager.PlayingOnline() && !isActor)
		{
			((MonoBehaviour)this).StartCoroutine(KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	public void NGHCMIHCDKL()
	{
		instance.EDGDFPPKGDL = null;
		if (instance.isActor)
		{
			PlayerInputs.DEPNDGJDKOL(instance.CJODOOFLLLB, (MonoBehaviour)(object)instance, FLHBPHPKIML: true);
			if (Object.op_Implicit((Object)(object)ActionBarInventory.ADHIHCNAKFP(instance.CJODOOFLLLB, LAGHIOKLJGH: true, ADPNMHGBFKG: true)))
			{
				ActionBarInventory.GetPlayer(instance.CJODOOFLLLB, LAGHIOKLJGH: false, ADPNMHGBFKG: true).JEGBMANMEFD((MonoBehaviour)(object)instance);
			}
			instance.sakeDrinker.canDrink = false;
			if (instance.isActor && OnlineManager.PlayingOnline())
			{
				OnlineEventsManager.SendSimpleEvent(eventType, 1);
			}
		}
		else
		{
			PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance, ANJCLPDCJHL: true);
		}
	}

	public void GoToMinigameScene()
	{
		instance.EndEvent(BFLCJPHHDJM: true);
	}

	private void HHGIHLGMEBN(bool BFLCJPHHDJM)
	{
		Debug.Log((object)("FerroProgress" + BFLCJPHHDJM + "ReceiveTorchPuzzle" + KujakuNPC.BADFKMEJOKE().EHHOHCPHAAO));
		if (BFLCJPHHDJM && Utils.MMMFJPKECAB(Location.Tavern | Location.Road | Location.Camp | Location.Farm))
		{
			CJODOOFLLLB = KujakuNPC.NEFIEJALANL().EHHOHCPHAAO;
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: false);
		}
	}

	public void AMKFCPAHCJL()
	{
		instance.EndEvent(BFLCJPHHDJM: true);
	}

	public void AJGGLEPILII(int playerNum, bool sendOnline)
	{
		if ((Object)(object)PlayerController.GetPlayer(playerNum) != (Object)null && (Object)(object)instance.kujakuTable != (Object)null)
		{
			((Component)PlayerController.OPHDCMJLLEC(playerNum)).transform.parent = instance.kujakuTable.transform;
			((Behaviour)instance.kujakuTable.GetComponent<BoxCollider2D>()).enabled = false;
		}
		if (sendOnline && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSetTableParent((byte)OnlinePlayerDataManager.GetBedAssignedByPlayerNum(playerNum));
		}
	}

	private void BCBCJFHJHDI(bool BFLCJPHHDJM)
	{
		Debug.Log((object)("Animal" + BFLCJPHHDJM + "Save Game" + KujakuNPC.GGFJGHHHEJC.EHHOHCPHAAO));
		if (BFLCJPHHDJM && Utils.MMMFJPKECAB(~Location.FarmShop))
		{
			CJODOOFLLLB = KujakuNPC.NEFIEJALANL().EHHOHCPHAAO;
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: false);
		}
	}

	private void MOJOHBIGMLJ(bool BFLCJPHHDJM)
	{
		Debug.Log((object)("LE_2" + BFLCJPHHDJM + "Bait" + KujakuNPC.DEGPIHEEFHJ().EHHOHCPHAAO));
		if (BFLCJPHHDJM && Utils.MMMFJPKECAB(Location.Tavern | Location.River | Location.Quarry | Location.FarmShop))
		{
			CJODOOFLLLB = KujakuNPC.GGFJGHHHEJC.EHHOHCPHAAO;
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: true);
		}
	}

	public void HNHLILLCFDL()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.HBLICFOEJJL());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
	}

	public void NINACPOBJIN()
	{
		instance.EDGDFPPKGDL = null;
		if (instance.isActor)
		{
			PlayerInputs.POBGMHINPHA(instance.CJODOOFLLLB, (MonoBehaviour)(object)instance);
			if (Object.op_Implicit((Object)(object)ActionBarInventory.BNMEANGDMIP(instance.CJODOOFLLLB)))
			{
				ActionBarInventory.ADHIHCNAKFP(instance.CJODOOFLLLB, LAGHIOKLJGH: true).OCJBIDIDJNN((MonoBehaviour)(object)instance);
			}
			instance.sakeDrinker.canDrink = false;
			if (instance.isActor && OnlineManager.PlayingOnline())
			{
				OnlineEventsManager.SendSimpleEvent(eventType, 1);
			}
		}
		else
		{
			PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance, ANJCLPDCJHL: true);
		}
	}

	private IEnumerator KKMNALPIEFM(int JIIGOACEIKL)
	{
		return new JIHIHDJAKCD(1)
		{
			_003C_003E4__this = this
		};
	}

	public void POOIIHLHDOP()
	{
		instance.EndEvent(BFLCJPHHDJM: true);
	}

	private IEnumerator EJICNPKJCCN(int JIIGOACEIKL)
	{
		yield return null;
		FadeCamera.GetPlayer(1).JDKHJJIOLOE -= HHGEKEKHDNK;
		instance.EDGDFPPKGDL = KujakuNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "Precision/DrinkEvent6";
		yield return OnlineManager.WaitForAllPlayers();
		if (instance.isActor)
		{
			KujakuNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "Precision/DrinkEvent6");
		}
		else if (OnlineManager.PlayingOnline())
		{
			((MonoBehaviour)this).StartCoroutine(KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	public void JADEOBKINBB()
	{
		FadeCamera.GetPlayer(1).GPBOEBGJJPM(1457f);
		FadeCamera.GetPlayer(0).KKAAAOEHGEK(instance.KKMNALPIEFM);
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(7).AJHDEBOMHKK(1120f);
		}
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 1);
		}
	}

	public void DEHIGLNEJOP()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.AAEMFCAGIBK());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 1);
		}
	}

	private IEnumerator BOENJKGGOOC(int JIIGOACEIKL)
	{
		yield return null;
		FadeCamera.GetPlayer(1).JDKHJJIOLOE -= HHGEKEKHDNK;
		instance.EDGDFPPKGDL = KujakuNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "Precision/DrinkEvent6";
		yield return OnlineManager.WaitForAllPlayers();
		if (instance.isActor)
		{
			KujakuNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "Precision/DrinkEvent6");
		}
		else if (OnlineManager.PlayingOnline())
		{
			((MonoBehaviour)this).StartCoroutine(KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private IEnumerator KJNMGMLHDJB()
	{
		EDGDFPPKGDL = null;
		if (OnlineManager.MasterOrOffline())
		{
			KujakuNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePositions[1].position), Direction.Right);
		}
		if (instance.isActor)
		{
			SetTableParent(CJODOOFLLLB, sendOnline: true);
			PlayerController.GetPlayer(CJODOOFLLLB).GoToPosition(Vector2.op_Implicit(instance.movePositions[0].position), KLGOCJMGKFO: true);
			while (!PlayerController.GetPlayer(CJODOOFLLLB).GoToPosition(Vector2.op_Implicit(instance.movePositions[0].position), KLGOCJMGKFO: false))
			{
				yield return null;
			}
			((Component)PlayerController.GetPlayer(CJODOOFLLLB)).transform.position = instance.playerDrinkPosition.position;
			((Component)PlayerController.GetPlayer(CJODOOFLLLB).characterAnimation.characterAnimator.eatingSpritesToActivate).transform.parent = instance.kujakuTable.transform;
			PlayerController.GetPlayer(CJODOOFLLLB).characterAnimation.SetDirection(Direction.Down);
			PlayerController.GetPlayer(CJODOOFLLLB).characterAnimation.Sit(Direction.Down);
		}
		yield return CommonReferences.wait1;
		yield return OnlineManager.WaitForAllPlayers();
		instance.EDGDFPPKGDL = KujakuNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "Precision/DrinkEvent1";
		if (instance.isActor)
		{
			KujakuNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "Precision/DrinkEvent1");
		}
		else if (OnlineManager.PlayingOnline())
		{
			yield return KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private void PBBIEJANBEF(bool BFLCJPHHDJM)
	{
		Debug.Log((object)(" : " + BFLCJPHHDJM + "Rest" + KujakuNPC.LANAINBEMCM().EHHOHCPHAAO));
		if (BFLCJPHHDJM && Utils.MMMFJPKECAB(Location.None))
		{
			CJODOOFLLLB = KujakuNPC.NEFIEJALANL().EHHOHCPHAAO;
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: true);
		}
	}

	public void AOKHMDCCBKJ(int playerNum, bool sendOnline)
	{
		if ((Object)(object)PlayerController.GetPlayer(playerNum) != (Object)null && (Object)(object)instance.kujakuTable != (Object)null)
		{
			((Component)PlayerController.OPHDCMJLLEC(playerNum)).transform.parent = instance.kujakuTable.transform;
			((Behaviour)instance.kujakuTable.GetComponent<BoxCollider2D>()).enabled = false;
		}
		if (sendOnline && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSetTableParent((byte)OnlinePlayerDataManager.GetBedAssignedByPlayerNum(playerNum));
		}
	}

	private void LFEMHCNHDDI()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			awningManager.awningControllers.IGLOCLJLJNM();
			kujakuRoutine.noDisableOnReset = true;
			((Behaviour)kujakuRoutine).enabled = false;
		}
		kujakuSignal.SetActive(false);
		sake.SetActive(true);
		((Component)KujakuNPC.NEFIEJALANL()).transform.position = characterPositions[0].position;
		KujakuNPC.MAAAKALBBEE().content.SetActive(true);
		KujakuNPC.NEFIEJALANL().animationBase.CGEADHOLHCH("", EGFGNGJGBOP: true, HALNIEBONKH: true);
		KujakuNPC.DEGPIHEEFHJ().animationBase.SetDirection(Direction.Up);
		((Component)HikariNPC.ABDJJBFNLBJ()).transform.position = characterPositions[0].position;
		HikariNPC.OFLELHKKNKC().content.SetActive(false);
		HikariNPC.ABDJJBFNLBJ().animationBase.SetBool("there are {0} keys and {1} values after deserialization. Make sure that both key and value types are serializable.", EGFGNGJGBOP: true);
		HikariNPC.GGFJGHHHEJC.animationBase.SetDirection((Direction)8);
		HikariNPC.GGFJGHHHEJC.inScene = false;
	}

	private void DHPGIFIKGEK(bool BFLCJPHHDJM)
	{
		Debug.Log((object)("buildingObjective_25_1" + BFLCJPHHDJM + "questDescCraftingRoom" + KujakuNPC.MAAAKALBBEE().EHHOHCPHAAO));
		if (BFLCJPHHDJM && Utils.MMMFJPKECAB(Location.None))
		{
			CJODOOFLLLB = KujakuNPC.GGFJGHHHEJC.EHHOHCPHAAO;
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: false);
		}
	}

	private IEnumerator IBHNANJJJOI(int JIIGOACEIKL)
	{
		return new JIHIHDJAKCD(1)
		{
			_003C_003E4__this = this
		};
	}

	public void NGMGDPDKADN()
	{
		instance.EndEvent(BFLCJPHHDJM: true);
	}

	private void CCPJFPKHBIC()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			awningManager.awningControllers.ForceCloseAwning();
			kujakuRoutine.noDisableOnReset = false;
			((Behaviour)kujakuRoutine).enabled = true;
		}
		kujakuSignal.SetActive(false);
		sake.SetActive(true);
		((Component)KujakuNPC.DEGPIHEEFHJ()).transform.position = characterPositions[0].position;
		KujakuNPC.GGFJGHHHEJC.content.SetActive(false);
		KujakuNPC.MAAAKALBBEE().animationBase.CGEADHOLHCH("endconversation", EGFGNGJGBOP: false, HALNIEBONKH: true);
		KujakuNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
		((Component)HikariNPC.MNFMOEKMJKN()).transform.position = characterPositions[1].position;
		HikariNPC.GGFJGHHHEJC.content.SetActive(true);
		HikariNPC.ABDJJBFNLBJ().animationBase.CGEADHOLHCH("ReceiveCrystalPuzzleSolved", EGFGNGJGBOP: false);
		HikariNPC.EFPJLFMBPLL().animationBase.SetDirection(Direction.Right);
		HikariNPC.GGFJGHHHEJC.inScene = true;
	}

	public void JHPKKCPAPOK(int playerNum, bool sendOnline)
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(playerNum) != (Object)null && (Object)(object)instance.kujakuTable != (Object)null)
		{
			((Component)PlayerController.OPHDCMJLLEC(playerNum)).transform.parent = instance.kujakuTable.transform;
			((Behaviour)instance.kujakuTable.GetComponent<BoxCollider2D>()).enabled = false;
		}
		if (sendOnline && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.OFBOFLGMFLL((byte)OnlinePlayerDataManager.JBDEFDMGCDA(playerNum));
		}
	}

	public override void ActivateEvent()
	{
		base.ActivateEvent();
		GJBNMNBAJIP();
		KujakuNPC kujakuNPC = KujakuNPC.GGFJGHHHEJC;
		kujakuNPC.ConversationStarted = (Action<bool>)Delegate.Combine(kujakuNPC.ConversationStarted, new Action<bool>(AEEHFGIDCMJ));
	}

	public void LIBPLMKLGEO()
	{
		instance.EDGDFPPKGDL = null;
		if (instance.isActor)
		{
			PlayerInputs.DEPNDGJDKOL(instance.CJODOOFLLLB, (MonoBehaviour)(object)instance, FLHBPHPKIML: true);
			if (Object.op_Implicit((Object)(object)ActionBarInventory.IPBEEBLCHHA(instance.CJODOOFLLLB, LAGHIOKLJGH: false, ADPNMHGBFKG: true)))
			{
				ActionBarInventory.IPBEEBLCHHA(instance.CJODOOFLLLB, LAGHIOKLJGH: false, ADPNMHGBFKG: true).OIMDEHAGLIG((MonoBehaviour)(object)instance);
			}
			instance.sakeDrinker.canDrink = true;
			if (instance.isActor && OnlineManager.PlayingOnline())
			{
				OnlineEventsManager.SendSimpleEvent(eventType, 0);
			}
		}
		else
		{
			PlayerInputs.CMEBIMMKIAB((MonoBehaviour)(object)instance);
		}
	}

	private void NLNDMDEEJDB(bool BFLCJPHHDJM)
	{
		Debug.Log((object)(", " + BFLCJPHHDJM + "" + KujakuNPC.EKDNJDJHONF().EHHOHCPHAAO));
		if (BFLCJPHHDJM && Utils.MMMFJPKECAB(Location.Tavern | Location.Camp | Location.BarnInterior))
		{
			CJODOOFLLLB = KujakuNPC.MAAAKALBBEE().EHHOHCPHAAO;
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: true);
		}
	}

	public void NLPCPNGKLBH()
	{
		instance.EDGDFPPKGDL = null;
		if (instance.isActor)
		{
			PlayerInputs.POBGMHINPHA(instance.CJODOOFLLLB, (MonoBehaviour)(object)instance, FLHBPHPKIML: true);
			if (Object.op_Implicit((Object)(object)ActionBarInventory.MHDKNEKDKII(instance.CJODOOFLLLB, LAGHIOKLJGH: false, ADPNMHGBFKG: true)))
			{
				ActionBarInventory.IFGBDFBGAED(instance.CJODOOFLLLB, LAGHIOKLJGH: true).AddActionBarBlockers((MonoBehaviour)(object)instance);
			}
			instance.sakeDrinker.canDrink = false;
			if (instance.isActor && OnlineManager.PlayingOnline())
			{
				OnlineEventsManager.SendSimpleEvent(eventType, 0);
			}
		}
		else
		{
			PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance, ANJCLPDCJHL: true);
		}
	}

	private IEnumerator HHFHGHGLMBF(int JIIGOACEIKL)
	{
		return new JIHIHDJAKCD(1)
		{
			_003C_003E4__this = this
		};
	}

	public void MGHEDOOFOLJ()
	{
		instance.EndEvent(BFLCJPHHDJM: false);
	}

	private IEnumerator MFJHGJADIME()
	{
		return new LBLNCMJGOLB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void FCKNCJKEJPP(bool BFLCJPHHDJM)
	{
		Debug.Log((object)("City/Hallmund/Stand" + BFLCJPHHDJM + "ValueName" + KujakuNPC.EKDNJDJHONF().EHHOHCPHAAO));
		if (BFLCJPHHDJM && Utils.MMMFJPKECAB(~(Location.Road | Location.River | Location.Farm)))
		{
			CJODOOFLLLB = KujakuNPC.GGFJGHHHEJC.EHHOHCPHAAO;
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: true);
		}
	}

	private IEnumerator OCOAOPJEBBF()
	{
		EDGDFPPKGDL = null;
		if (OnlineManager.MasterOrOffline())
		{
			KujakuNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePositions[1].position), Direction.Right);
		}
		if (instance.isActor)
		{
			SetTableParent(CJODOOFLLLB, sendOnline: true);
			PlayerController.GetPlayer(CJODOOFLLLB).GoToPosition(Vector2.op_Implicit(instance.movePositions[0].position), KLGOCJMGKFO: true);
			while (!PlayerController.GetPlayer(CJODOOFLLLB).GoToPosition(Vector2.op_Implicit(instance.movePositions[0].position), KLGOCJMGKFO: false))
			{
				yield return null;
			}
			((Component)PlayerController.GetPlayer(CJODOOFLLLB)).transform.position = instance.playerDrinkPosition.position;
			((Component)PlayerController.GetPlayer(CJODOOFLLLB).characterAnimation.characterAnimator.eatingSpritesToActivate).transform.parent = instance.kujakuTable.transform;
			PlayerController.GetPlayer(CJODOOFLLLB).characterAnimation.SetDirection(Direction.Down);
			PlayerController.GetPlayer(CJODOOFLLLB).characterAnimation.Sit(Direction.Down);
		}
		yield return CommonReferences.wait1;
		yield return OnlineManager.WaitForAllPlayers();
		instance.EDGDFPPKGDL = KujakuNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "Precision/DrinkEvent1";
		if (instance.isActor)
		{
			KujakuNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "Precision/DrinkEvent1");
		}
		else if (OnlineManager.PlayingOnline())
		{
			yield return KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
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
		case LOGEKNJJJOB.FirstConversationEnd:
			FirstConversationEnd();
			break;
		case LOGEKNJJJOB.StartDrink:
			StartDrink();
			break;
		case LOGEKNJJJOB.BlackScreen:
			BlackScreen();
			break;
		}
	}

	public void MJHNBPJFMPB()
	{
		instance.EDGDFPPKGDL = null;
		if (instance.isActor)
		{
			PlayerInputs.DEPNDGJDKOL(instance.CJODOOFLLLB, (MonoBehaviour)(object)instance);
			if (Object.op_Implicit((Object)(object)ActionBarInventory.GetPlayer(instance.CJODOOFLLLB, LAGHIOKLJGH: true)))
			{
				ActionBarInventory.IFGBDFBGAED(instance.CJODOOFLLLB, LAGHIOKLJGH: true).AddActionBarBlockers((MonoBehaviour)(object)instance);
			}
			instance.sakeDrinker.canDrink = false;
			if (instance.isActor && OnlineManager.PlayingOnline())
			{
				OnlineEventsManager.SendSimpleEvent(eventType, 1);
			}
		}
		else
		{
			PlayerInputs.CMEBIMMKIAB((MonoBehaviour)(object)instance);
		}
	}

	private IEnumerator CLMLEINNHMG()
	{
		return new LBLNCMJGOLB(1)
		{
			_003C_003E4__this = this
		};
	}

	public void BBODPCKDBON()
	{
		FadeCamera.IGMCBPOPNCA(0).AJHDEBOMHKK(211f);
		FadeCamera.EIFPKCAFDIB(0).JDKHJJIOLOE += instance.OIIPDODGLHE;
		if (GameManager.LocalCoop())
		{
			FadeCamera.EIFPKCAFDIB(7).IONMINJHMKL(1404f);
		}
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 7);
		}
	}

	private IEnumerator HBLICFOEJJL()
	{
		return new LBLNCMJGOLB(1)
		{
			_003C_003E4__this = this
		};
	}

	public void ILKNFMEHPFH()
	{
		FadeCamera.EIFPKCAFDIB(1).AJHDEBOMHKK(1405f);
		FadeCamera.EIFPKCAFDIB(0).HDDEGMGIBDM(instance.HBCDJNEAAFA);
		if (GameManager.LocalCoop())
		{
			FadeCamera.EIFPKCAFDIB(4).FadeOut(685f);
		}
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 7);
		}
	}

	public void HMLOCDJAOCG()
	{
		instance.EndEvent(BFLCJPHHDJM: true);
	}

	private void OJCMBGMBHFJ(bool BFLCJPHHDJM)
	{
		Debug.Log((object)("Items/item_description_695" + BFLCJPHHDJM + "Content" + KujakuNPC.GGFJGHHHEJC.EHHOHCPHAAO));
		if (BFLCJPHHDJM && Utils.MMMFJPKECAB(Location.Quarry | Location.FarmShop))
		{
			CJODOOFLLLB = KujakuNPC.GGFJGHHHEJC.EHHOHCPHAAO;
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: true);
		}
	}

	public override GameEvent GetInstance()
	{
		return instance;
	}

	public void BlackScreen()
	{
		FadeCamera.GetPlayer(1).FadeOut(1f);
		FadeCamera.GetPlayer(1).JDKHJJIOLOE += instance.HHGEKEKHDNK;
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeOut(1f);
		}
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 2);
		}
	}

	public void JMPGENJMGIG()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.DALBJEOPLEI());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
	}

	private IEnumerator HHGEKEKHDNK(int JIIGOACEIKL)
	{
		yield return null;
		FadeCamera.GetPlayer(1).JDKHJJIOLOE -= HHGEKEKHDNK;
		instance.EDGDFPPKGDL = KujakuNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "Precision/DrinkEvent6";
		yield return OnlineManager.WaitForAllPlayers();
		if (instance.isActor)
		{
			KujakuNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "Precision/DrinkEvent6");
		}
		else if (OnlineManager.PlayingOnline())
		{
			((MonoBehaviour)this).StartCoroutine(KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private IEnumerator IIMMLPGLLHF(int JIIGOACEIKL)
	{
		return new JIHIHDJAKCD(1)
		{
			_003C_003E4__this = this
		};
	}

	public void AEFNOGOPDDF()
	{
		instance.EDGDFPPKGDL = null;
		if (instance.isActor)
		{
			PlayerInputs.EnableKeyboardInputs(instance.CJODOOFLLLB, (MonoBehaviour)(object)instance);
			if (Object.op_Implicit((Object)(object)ActionBarInventory.IPBEEBLCHHA(instance.CJODOOFLLLB)))
			{
				ActionBarInventory.ADHIHCNAKFP(instance.CJODOOFLLLB).JEGBMANMEFD((MonoBehaviour)(object)instance);
			}
			instance.sakeDrinker.canDrink = false;
			if (instance.isActor && OnlineManager.PlayingOnline())
			{
				OnlineEventsManager.SendSimpleEvent(eventType, 0);
			}
		}
		else
		{
			PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance, ANJCLPDCJHL: true);
		}
	}

	private IEnumerator BCPKAOHHCGH()
	{
		return new LBLNCMJGOLB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void AEEHFGIDCMJ(bool BFLCJPHHDJM)
	{
		Debug.Log((object)("OnConversationStarted " + BFLCJPHHDJM + " playerDialogue: " + KujakuNPC.GGFJGHHHEJC.EHHOHCPHAAO));
		if (BFLCJPHHDJM && Utils.MMMFJPKECAB(Location.KujakuHouse))
		{
			CJODOOFLLLB = KujakuNPC.GGFJGHHHEJC.EHHOHCPHAAO;
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: true);
		}
	}

	private void IBOFKHNIPAE(bool BFLCJPHHDJM)
	{
		Debug.Log((object)("NinjaChallengeEvent/Main 2" + BFLCJPHHDJM + "Direction" + KujakuNPC.MAAAKALBBEE().EHHOHCPHAAO));
		if (BFLCJPHHDJM && Utils.MMMFJPKECAB(Location.Quarry | Location.Farm | Location.BarnInterior))
		{
			CJODOOFLLLB = KujakuNPC.DEGPIHEEFHJ().EHHOHCPHAAO;
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: true);
		}
	}

	private void JMOJBJHIGLC(bool BFLCJPHHDJM)
	{
		Debug.Log((object)("<b>" + BFLCJPHHDJM + "Error " + KujakuNPC.NEFIEJALANL().EHHOHCPHAAO));
		if (BFLCJPHHDJM && Utils.MMMFJPKECAB(~(Location.Tavern | Location.Camp | Location.Quarry | Location.BarnInterior)))
		{
			CJODOOFLLLB = KujakuNPC.NEFIEJALANL().EHHOHCPHAAO;
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: false);
		}
	}

	public void GALDKAIFODJ()
	{
		FadeCamera.GetPlayer(0).IONMINJHMKL(1328f);
		FadeCamera.IGMCBPOPNCA(0).HDDEGMGIBDM(instance.EJICNPKJCCN);
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(6).FadeOut(101f);
		}
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 4);
		}
	}

	public void FirstConversationEnd()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.OCOAOPJEBBF());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
	}

	private void KJIGBKGBIAN()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			awningManager.awningControllers.IGLOCLJLJNM();
			kujakuRoutine.noDisableOnReset = false;
			((Behaviour)kujakuRoutine).enabled = true;
		}
		kujakuSignal.SetActive(true);
		sake.SetActive(false);
		((Component)KujakuNPC.EKDNJDJHONF()).transform.position = characterPositions[1].position;
		KujakuNPC.NEFIEJALANL().content.SetActive(false);
		KujakuNPC.GGFJGHHHEJC.animationBase.CGEADHOLHCH("BaseCamp", EGFGNGJGBOP: true);
		KujakuNPC.NEFIEJALANL().animationBase.SetDirection(Direction.Up);
		((Component)HikariNPC.OFLELHKKNKC()).transform.position = characterPositions[1].position;
		HikariNPC.MNFMOEKMJKN().content.SetActive(true);
		HikariNPC.OFLELHKKNKC().animationBase.CGEADHOLHCH("Puente_EA/Talk 1", EGFGNGJGBOP: true, HALNIEBONKH: true);
		HikariNPC.MNFMOEKMJKN().animationBase.SetDirection((Direction)7);
		HikariNPC.ABDJJBFNLBJ().inScene = true;
	}

	public void FLOKALFNCBG()
	{
		FadeCamera.GetPlayer(0).FadeOut(1378f);
		FadeCamera.IGMCBPOPNCA(1).BOBBJLPKDBP(instance.AKCKLKNICEL);
		if (GameManager.LocalCoop())
		{
			FadeCamera.EIFPKCAFDIB(4).FadeOut(197f);
		}
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 8);
		}
	}

	public void LDAFCGPPGAA()
	{
		instance.EDGDFPPKGDL = null;
		if (instance.isActor)
		{
			PlayerInputs.EnableKeyboardInputs(instance.CJODOOFLLLB, (MonoBehaviour)(object)instance);
			if (Object.op_Implicit((Object)(object)ActionBarInventory.MHDKNEKDKII(instance.CJODOOFLLLB, LAGHIOKLJGH: true)))
			{
				ActionBarInventory.IFGBDFBGAED(instance.CJODOOFLLLB, LAGHIOKLJGH: true, ADPNMHGBFKG: true).OCJBIDIDJNN((MonoBehaviour)(object)instance);
			}
			instance.sakeDrinker.canDrink = false;
			if (instance.isActor && OnlineManager.PlayingOnline())
			{
				OnlineEventsManager.SendSimpleEvent(eventType, 0);
			}
		}
		else
		{
			PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance, ANJCLPDCJHL: true);
		}
	}

	public void PKHLNOFCDOB()
	{
		instance.EndEvent(BFLCJPHHDJM: true);
	}

	public void EHJIKGLLNAE()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.HBLICFOEJJL());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 1);
		}
	}

	private void DAHNMGPDLJK(bool BFLCJPHHDJM)
	{
		Debug.Log((object)("bed instance null" + BFLCJPHHDJM + "[MinePipePuzzle] No hay puzzles para {0}x{1} " + KujakuNPC.BADFKMEJOKE().EHHOHCPHAAO));
		if (BFLCJPHHDJM && Utils.MMMFJPKECAB(Location.Tavern | Location.Road | Location.Quarry | Location.BarnInterior))
		{
			CJODOOFLLLB = KujakuNPC.MAAAKALBBEE().EHHOHCPHAAO;
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: false);
		}
	}

	private void ONCKCJOFHLB()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			awningManager.awningControllers.DDFIFCLBBLF();
			kujakuRoutine.noDisableOnReset = true;
			((Behaviour)kujakuRoutine).enabled = false;
		}
		kujakuSignal.SetActive(false);
		sake.SetActive(false);
		((Component)KujakuNPC.NEFIEJALANL()).transform.position = characterPositions[0].position;
		KujakuNPC.NEFIEJALANL().content.SetActive(true);
		KujakuNPC.BADFKMEJOKE().animationBase.CGEADHOLHCH("MainProgress", EGFGNGJGBOP: false);
		KujakuNPC.DEGPIHEEFHJ().animationBase.SetDirection(Direction.Up);
		((Component)HikariNPC.GGFJGHHHEJC).transform.position = characterPositions[1].position;
		HikariNPC.ABDJJBFNLBJ().content.SetActive(true);
		HikariNPC.ABDJJBFNLBJ().animationBase.SetBool(" (", EGFGNGJGBOP: true, HALNIEBONKH: true);
		HikariNPC.OFLELHKKNKC().animationBase.SetDirection(Direction.Diagonal);
		HikariNPC.GGFJGHHHEJC.inScene = true;
	}

	public void MAFAKACOBJO(int playerNum, bool sendOnline)
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(playerNum) != (Object)null && (Object)(object)instance.kujakuTable != (Object)null)
		{
			((Component)PlayerController.OPHDCMJLLEC(playerNum)).transform.parent = instance.kujakuTable.transform;
			((Behaviour)instance.kujakuTable.GetComponent<BoxCollider2D>()).enabled = true;
		}
		if (sendOnline && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSetTableParent((byte)OnlinePlayerDataManager.JBDEFDMGCDA(playerNum));
		}
	}

	private void GLIPCHCDBKD()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			awningManager.awningControllers.BIFHACGLOJJ();
			kujakuRoutine.noDisableOnReset = false;
			((Behaviour)kujakuRoutine).enabled = false;
		}
		kujakuSignal.SetActive(false);
		sake.SetActive(true);
		((Component)KujakuNPC.MAAAKALBBEE()).transform.position = characterPositions[1].position;
		KujakuNPC.LANAINBEMCM().content.SetActive(false);
		KujakuNPC.BADFKMEJOKE().animationBase.CGEADHOLHCH("<color=#A95A00>+", EGFGNGJGBOP: true, HALNIEBONKH: true);
		KujakuNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
		((Component)HikariNPC.ABDJJBFNLBJ()).transform.position = characterPositions[1].position;
		HikariNPC.EFPJLFMBPLL().content.SetActive(false);
		HikariNPC.EFPJLFMBPLL().animationBase.SetBool("Items/item_name_1444", EGFGNGJGBOP: false);
		HikariNPC.ABDJJBFNLBJ().animationBase.SetDirection((Direction)6);
		HikariNPC.EKDNJDJHONF().inScene = true;
	}

	private void MCKFPMCNKDF()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			awningManager.awningControllers.ForceCloseAwning();
			kujakuRoutine.noDisableOnReset = true;
			((Behaviour)kujakuRoutine).enabled = false;
		}
		kujakuSignal.SetActive(true);
		sake.SetActive(false);
		((Component)KujakuNPC.DEGPIHEEFHJ()).transform.position = characterPositions[1].position;
		KujakuNPC.DEGPIHEEFHJ().content.SetActive(true);
		KujakuNPC.GGFJGHHHEJC.animationBase.SetBool("Player/Bark/Tutorial/AgingBarrelBlock", EGFGNGJGBOP: true, HALNIEBONKH: true);
		KujakuNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
		((Component)HikariNPC.GGFJGHHHEJC).transform.position = characterPositions[1].position;
		HikariNPC.GGFJGHHHEJC.content.SetActive(false);
		HikariNPC.OFLELHKKNKC().animationBase.SetBool("Dialogue System/Conversation/TooCold/Entry/4/Dialogue Text", EGFGNGJGBOP: false);
		HikariNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Left);
		HikariNPC.EKDNJDJHONF().inScene = false;
	}

	private IEnumerator AAEMFCAGIBK()
	{
		EDGDFPPKGDL = null;
		if (OnlineManager.MasterOrOffline())
		{
			KujakuNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(movePositions[1].position), Direction.Right);
		}
		if (instance.isActor)
		{
			SetTableParent(CJODOOFLLLB, sendOnline: true);
			PlayerController.GetPlayer(CJODOOFLLLB).GoToPosition(Vector2.op_Implicit(instance.movePositions[0].position), KLGOCJMGKFO: true);
			while (!PlayerController.GetPlayer(CJODOOFLLLB).GoToPosition(Vector2.op_Implicit(instance.movePositions[0].position), KLGOCJMGKFO: false))
			{
				yield return null;
			}
			((Component)PlayerController.GetPlayer(CJODOOFLLLB)).transform.position = instance.playerDrinkPosition.position;
			((Component)PlayerController.GetPlayer(CJODOOFLLLB).characterAnimation.characterAnimator.eatingSpritesToActivate).transform.parent = instance.kujakuTable.transform;
			PlayerController.GetPlayer(CJODOOFLLLB).characterAnimation.SetDirection(Direction.Down);
			PlayerController.GetPlayer(CJODOOFLLLB).characterAnimation.Sit(Direction.Down);
		}
		yield return CommonReferences.wait1;
		yield return OnlineManager.WaitForAllPlayers();
		instance.EDGDFPPKGDL = KujakuNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "Precision/DrinkEvent1";
		if (instance.isActor)
		{
			KujakuNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, "Precision/DrinkEvent1");
		}
		else if (OnlineManager.PlayingOnline())
		{
			yield return KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	public void JHPAFCFADKP(int playerNum, bool sendOnline)
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(playerNum) != (Object)null && (Object)(object)instance.kujakuTable != (Object)null)
		{
			((Component)PlayerController.OPHDCMJLLEC(playerNum)).transform.parent = instance.kujakuTable.transform;
			((Behaviour)instance.kujakuTable.GetComponent<BoxCollider2D>()).enabled = false;
		}
		if (sendOnline && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSetTableParent((byte)OnlinePlayerDataManager.JBDEFDMGCDA(playerNum));
		}
	}

	protected override void Awake()
	{
		base.Awake();
		instance = this;
	}

	private void JCAHEFMNHBB()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			awningManager.awningControllers.LMDMMHLAIOE();
			kujakuRoutine.noDisableOnReset = false;
			((Behaviour)kujakuRoutine).enabled = true;
		}
		kujakuSignal.SetActive(false);
		sake.SetActive(false);
		((Component)KujakuNPC.LANAINBEMCM()).transform.position = characterPositions[0].position;
		KujakuNPC.GGFJGHHHEJC.content.SetActive(true);
		KujakuNPC.DEGPIHEEFHJ().animationBase.SetBool("SetAnimatorObjectFloatRPC", EGFGNGJGBOP: false);
		KujakuNPC.MAAAKALBBEE().animationBase.SetDirection(Direction.Down);
		((Component)HikariNPC.EFPJLFMBPLL()).transform.position = characterPositions[0].position;
		HikariNPC.GGFJGHHHEJC.content.SetActive(true);
		HikariNPC.EKDNJDJHONF().animationBase.CGEADHOLHCH("next pos ", EGFGNGJGBOP: true, HALNIEBONKH: true);
		HikariNPC.EFPJLFMBPLL().animationBase.SetDirection(Direction.Down);
		HikariNPC.EFPJLFMBPLL().inScene = false;
	}

	public void HODKAHLCGPG()
	{
		instance.EndEvent(BFLCJPHHDJM: true);
	}

	public void AJFAPGNHGNM()
	{
		FadeCamera.EIFPKCAFDIB(0).GPBOEBGJJPM(1590f);
		FadeCamera.GetPlayer(1).HDDEGMGIBDM(instance.LOAAKDFKJPH);
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(5).GPBOEBGJJPM(780f);
		}
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
	}

	public void IBELIHPPJNE()
	{
		FadeCamera.EIFPKCAFDIB(1).AJHDEBOMHKK(566f);
		FadeCamera.IGMCBPOPNCA(1).JDKHJJIOLOE += instance.LOAAKDFKJPH;
		if (GameManager.LocalCoop())
		{
			FadeCamera.IGMCBPOPNCA(0).AJHDEBOMHKK(1035f);
		}
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 4);
		}
	}

	public void EDGKOJDMFLH()
	{
		instance.EndEvent(BFLCJPHHDJM: true);
	}

	private IEnumerator GBJADCOPCGK(int JIIGOACEIKL)
	{
		return new JIHIHDJAKCD(1)
		{
			_003C_003E4__this = this
		};
	}

	private void PIPKKODLDHI()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PGAGDFAEEFB())
		{
			awningManager.awningControllers.ForceCloseAwning();
			kujakuRoutine.noDisableOnReset = true;
			((Behaviour)kujakuRoutine).enabled = false;
		}
		kujakuSignal.SetActive(true);
		sake.SetActive(false);
		((Component)KujakuNPC.GGFJGHHHEJC).transform.position = characterPositions[0].position;
		KujakuNPC.EKDNJDJHONF().content.SetActive(false);
		KujakuNPC.DEGPIHEEFHJ().animationBase.CGEADHOLHCH("\n\n\nMine Level Info:\n", EGFGNGJGBOP: true);
		KujakuNPC.LANAINBEMCM().animationBase.SetDirection(Direction.Down);
		((Component)HikariNPC.GGFJGHHHEJC).transform.position = characterPositions[0].position;
		HikariNPC.EFPJLFMBPLL().content.SetActive(false);
		HikariNPC.GGFJGHHHEJC.animationBase.CGEADHOLHCH("Items/item_name_1067", EGFGNGJGBOP: true, HALNIEBONKH: true);
		HikariNPC.EFPJLFMBPLL().animationBase.SetDirection(Direction.Up);
		HikariNPC.OFLELHKKNKC().inScene = false;
	}

	public void SetTableParent(int playerNum, bool sendOnline)
	{
		if ((Object)(object)PlayerController.GetPlayer(playerNum) != (Object)null && (Object)(object)instance.kujakuTable != (Object)null)
		{
			((Component)PlayerController.GetPlayer(playerNum)).transform.parent = instance.kujakuTable.transform;
			((Behaviour)instance.kujakuTable.GetComponent<BoxCollider2D>()).enabled = false;
		}
		if (sendOnline && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSetTableParent((byte)OnlinePlayerDataManager.GetBedAssignedByPlayerNum(playerNum));
		}
	}

	private void BGOGMLGDCMH(bool BFLCJPHHDJM)
	{
		Debug.Log((object)("Bark" + BFLCJPHHDJM + "add letter" + KujakuNPC.MAAAKALBBEE().EHHOHCPHAAO));
		if (BFLCJPHHDJM && Utils.MMMFJPKECAB(~(Location.Road | Location.BarnInterior | Location.FarmShop)))
		{
			CJODOOFLLLB = KujakuNPC.DEGPIHEEFHJ().EHHOHCPHAAO;
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: false);
		}
	}

	public void JHOPKJPFGJG()
	{
		FadeCamera.IGMCBPOPNCA(0).IONMINJHMKL(775f);
		FadeCamera.IGMCBPOPNCA(1).KKAAAOEHGEK(instance.HBCDJNEAAFA);
		if (GameManager.LocalCoop())
		{
			FadeCamera.EIFPKCAFDIB(1).IONMINJHMKL(369f);
		}
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 7);
		}
	}

	private IEnumerator DCFDPKKDPDO(int JIIGOACEIKL)
	{
		yield return null;
		FadeCamera.GetPlayer(1).JDKHJJIOLOE -= HHGEKEKHDNK;
		instance.EDGDFPPKGDL = KujakuNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "Precision/DrinkEvent6";
		yield return OnlineManager.WaitForAllPlayers();
		if (instance.isActor)
		{
			KujakuNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "Precision/DrinkEvent6");
		}
		else if (OnlineManager.PlayingOnline())
		{
			((MonoBehaviour)this).StartCoroutine(KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	public void IEMOGJADCBD(int playerNum, bool sendOnline)
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(playerNum) != (Object)null && (Object)(object)instance.kujakuTable != (Object)null)
		{
			((Component)PlayerController.OPHDCMJLLEC(playerNum)).transform.parent = instance.kujakuTable.transform;
			((Behaviour)instance.kujakuTable.GetComponent<BoxCollider2D>()).enabled = false;
		}
		if (sendOnline && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSetTableParent((byte)OnlinePlayerDataManager.GetBedAssignedByPlayerNum(playerNum));
		}
	}

	public void PJGBEMBPJIC()
	{
		FadeCamera.EIFPKCAFDIB(1).AJHDEBOMHKK(1321f);
		FadeCamera.GetPlayer(0).JDKHJJIOLOE += instance.GBJADCOPCGK;
		if (GameManager.LocalCoop())
		{
			FadeCamera.IGMCBPOPNCA(6).AJHDEBOMHKK(657f);
		}
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 8);
		}
	}

	public void LENMHIDEMGF()
	{
		instance.EDGDFPPKGDL = null;
		if (instance.isActor)
		{
			PlayerInputs.POBGMHINPHA(instance.CJODOOFLLLB, (MonoBehaviour)(object)instance);
			if (Object.op_Implicit((Object)(object)ActionBarInventory.GetPlayer(instance.CJODOOFLLLB, LAGHIOKLJGH: true)))
			{
				ActionBarInventory.IFGBDFBGAED(instance.CJODOOFLLLB, LAGHIOKLJGH: true).AddActionBarBlockers((MonoBehaviour)(object)instance);
			}
			instance.sakeDrinker.canDrink = true;
			if (instance.isActor && OnlineManager.PlayingOnline())
			{
				OnlineEventsManager.SendSimpleEvent(eventType, 1);
			}
		}
		else
		{
			PlayerInputs.CMEBIMMKIAB((MonoBehaviour)(object)instance);
		}
	}

	public void DHCIHHNNJFH()
	{
		instance.EDGDFPPKGDL = null;
		if (instance.isActor)
		{
			PlayerInputs.EnableKeyboardInputs(instance.CJODOOFLLLB, (MonoBehaviour)(object)instance, FLHBPHPKIML: true);
			if (Object.op_Implicit((Object)(object)ActionBarInventory.IPBEEBLCHHA(instance.CJODOOFLLLB, LAGHIOKLJGH: true)))
			{
				ActionBarInventory.DACNEICGAAE(instance.CJODOOFLLLB, LAGHIOKLJGH: true).OCJBIDIDJNN((MonoBehaviour)(object)instance);
			}
			instance.sakeDrinker.canDrink = true;
			if (instance.isActor && OnlineManager.PlayingOnline())
			{
				OnlineEventsManager.SendSimpleEvent(eventType, 1);
			}
		}
		else
		{
			PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		}
	}

	public void PFLDNHEGBJG()
	{
		FadeCamera.EIFPKCAFDIB(1).AJHDEBOMHKK(1006f);
		FadeCamera.IGMCBPOPNCA(0).JDKHJJIOLOE += instance.HHFHGHGLMBF;
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(0).IONMINJHMKL(1589f);
		}
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 2);
		}
	}

	public void IGKHBHEFNGH()
	{
		instance.EDGDFPPKGDL = null;
		if (instance.isActor)
		{
			PlayerInputs.EnableKeyboardInputs(instance.CJODOOFLLLB, (MonoBehaviour)(object)instance);
			if (Object.op_Implicit((Object)(object)ActionBarInventory.BNMEANGDMIP(instance.CJODOOFLLLB, LAGHIOKLJGH: true)))
			{
				ActionBarInventory.DACNEICGAAE(instance.CJODOOFLLLB, LAGHIOKLJGH: true, ADPNMHGBFKG: true).OCJBIDIDJNN((MonoBehaviour)(object)instance);
			}
			instance.sakeDrinker.canDrink = false;
			if (instance.isActor && OnlineManager.PlayingOnline())
			{
				OnlineEventsManager.SendSimpleEvent(eventType, 0);
			}
		}
		else
		{
			PlayerInputs.CMEBIMMKIAB((MonoBehaviour)(object)instance);
		}
	}

	private void LHOCOCGEEFP()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			awningManager.awningControllers.LMDMMHLAIOE();
			kujakuRoutine.noDisableOnReset = true;
			((Behaviour)kujakuRoutine).enabled = true;
		}
		kujakuSignal.SetActive(true);
		sake.SetActive(true);
		((Component)KujakuNPC.EKDNJDJHONF()).transform.position = characterPositions[0].position;
		KujakuNPC.EKDNJDJHONF().content.SetActive(false);
		KujakuNPC.LANAINBEMCM().animationBase.CGEADHOLHCH("cornHarvested", EGFGNGJGBOP: true, HALNIEBONKH: true);
		KujakuNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
		((Component)HikariNPC.OFLELHKKNKC()).transform.position = characterPositions[0].position;
		HikariNPC.MNFMOEKMJKN().content.SetActive(false);
		HikariNPC.MNFMOEKMJKN().animationBase.CGEADHOLHCH("Idle", EGFGNGJGBOP: false);
		HikariNPC.ABDJJBFNLBJ().animationBase.SetDirection((Direction)7);
		HikariNPC.GGFJGHHHEJC.inScene = false;
	}

	private IEnumerator HBCDJNEAAFA(int JIIGOACEIKL)
	{
		yield return null;
		FadeCamera.GetPlayer(1).JDKHJJIOLOE -= HHGEKEKHDNK;
		instance.EDGDFPPKGDL = KujakuNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "Precision/DrinkEvent6";
		yield return OnlineManager.WaitForAllPlayers();
		if (instance.isActor)
		{
			KujakuNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "Precision/DrinkEvent6");
		}
		else if (OnlineManager.PlayingOnline())
		{
			((MonoBehaviour)this).StartCoroutine(KujakuNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	public void MGMGPHNAMLN(int playerNum, bool sendOnline)
	{
		if ((Object)(object)PlayerController.GetPlayer(playerNum) != (Object)null && (Object)(object)instance.kujakuTable != (Object)null)
		{
			((Component)PlayerController.GetPlayer(playerNum)).transform.parent = instance.kujakuTable.transform;
			((Behaviour)instance.kujakuTable.GetComponent<BoxCollider2D>()).enabled = false;
		}
		if (sendOnline && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.OCFEADODOND((byte)OnlinePlayerDataManager.JBDEFDMGCDA(playerNum));
		}
	}

	private void GJBNMNBAJIP()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			awningManager.awningControllers.ForceCloseAwning();
			kujakuRoutine.noDisableOnReset = true;
			((Behaviour)kujakuRoutine).enabled = false;
		}
		kujakuSignal.SetActive(true);
		sake.SetActive(true);
		((Component)KujakuNPC.GGFJGHHHEJC).transform.position = characterPositions[0].position;
		KujakuNPC.GGFJGHHHEJC.content.SetActive(true);
		KujakuNPC.GGFJGHHHEJC.animationBase.SetBool("Hanghover", EGFGNGJGBOP: true, HALNIEBONKH: true);
		KujakuNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		((Component)HikariNPC.GGFJGHHHEJC).transform.position = characterPositions[1].position;
		HikariNPC.GGFJGHHHEJC.content.SetActive(true);
		HikariNPC.GGFJGHHHEJC.animationBase.SetBool("Rest", EGFGNGJGBOP: true, HALNIEBONKH: true);
		HikariNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Right);
		HikariNPC.GGFJGHHHEJC.inScene = true;
	}

	private IEnumerator KLEDEBPHNHH(int JIIGOACEIKL)
	{
		return new JIHIHDJAKCD(1)
		{
			_003C_003E4__this = this
		};
	}

	public void GGDNPIBJFGO()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.OCOAOPJEBBF());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 1);
		}
	}

	private void IINGDGPDBKF(bool BFLCJPHHDJM)
	{
		Debug.Log((object)("DisableLeftExterior" + BFLCJPHHDJM + "Items/item_description_641" + KujakuNPC.NEFIEJALANL().EHHOHCPHAAO));
		if (BFLCJPHHDJM && Utils.MMMFJPKECAB(~(Location.Tavern | Location.River | Location.Quarry)))
		{
			CJODOOFLLLB = KujakuNPC.NEFIEJALANL().EHHOHCPHAAO;
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: false);
		}
	}

	public void MIAIDECANGN()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.OCOAOPJEBBF());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
	}

	public void PEGHCNGCHGO()
	{
		instance.EDGDFPPKGDL = null;
		if (instance.isActor)
		{
			PlayerInputs.EnableKeyboardInputs(instance.CJODOOFLLLB, (MonoBehaviour)(object)instance);
			if (Object.op_Implicit((Object)(object)ActionBarInventory.MHDKNEKDKII(instance.CJODOOFLLLB, LAGHIOKLJGH: false, ADPNMHGBFKG: true)))
			{
				ActionBarInventory.GetPlayer(instance.CJODOOFLLLB, LAGHIOKLJGH: true).OIMDEHAGLIG((MonoBehaviour)(object)instance);
			}
			instance.sakeDrinker.canDrink = false;
			if (instance.isActor && OnlineManager.PlayingOnline())
			{
				OnlineEventsManager.SendSimpleEvent(eventType, 1);
			}
		}
		else
		{
			PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		}
	}

	public void PIMNHHCNCMF()
	{
		FadeCamera.EIFPKCAFDIB(1).IONMINJHMKL(1871f);
		FadeCamera.IGMCBPOPNCA(0).KKAAAOEHGEK(instance.DCFDPKKDPDO);
		if (GameManager.LocalCoop())
		{
			FadeCamera.IGMCBPOPNCA(7).AJHDEBOMHKK(1645f);
		}
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 5);
		}
	}

	private void HIOCIHCFPOD(bool BFLCJPHHDJM)
	{
		Debug.Log((object)("Player" + BFLCJPHHDJM + "Moving" + KujakuNPC.BADFKMEJOKE().EHHOHCPHAAO));
		if (BFLCJPHHDJM && Utils.MMMFJPKECAB(Location.River | Location.BarnInterior))
		{
			CJODOOFLLLB = KujakuNPC.MAAAKALBBEE().EHHOHCPHAAO;
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: false);
		}
	}

	public void StartDrink()
	{
		instance.EDGDFPPKGDL = null;
		if (instance.isActor)
		{
			PlayerInputs.EnableKeyboardInputs(instance.CJODOOFLLLB, (MonoBehaviour)(object)instance);
			if (Object.op_Implicit((Object)(object)ActionBarInventory.GetPlayer(instance.CJODOOFLLLB)))
			{
				ActionBarInventory.GetPlayer(instance.CJODOOFLLLB).AddActionBarBlockers((MonoBehaviour)(object)instance);
			}
			instance.sakeDrinker.canDrink = true;
			if (instance.isActor && OnlineManager.PlayingOnline())
			{
				OnlineEventsManager.SendSimpleEvent(eventType, 1);
			}
		}
		else
		{
			PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		}
	}

	public void EJMBDCBKNFN()
	{
		instance.EDGDFPPKGDL = null;
		if (instance.isActor)
		{
			PlayerInputs.DEPNDGJDKOL(instance.CJODOOFLLLB, (MonoBehaviour)(object)instance);
			if (Object.op_Implicit((Object)(object)ActionBarInventory.GetPlayer(instance.CJODOOFLLLB, LAGHIOKLJGH: true)))
			{
				ActionBarInventory.MHDKNEKDKII(instance.CJODOOFLLLB, LAGHIOKLJGH: true, ADPNMHGBFKG: true).OIMDEHAGLIG((MonoBehaviour)(object)instance);
			}
			instance.sakeDrinker.canDrink = true;
			if (instance.isActor && OnlineManager.PlayingOnline())
			{
				OnlineEventsManager.SendSimpleEvent(eventType, 0);
			}
		}
		else
		{
			PlayerInputs.CMEBIMMKIAB((MonoBehaviour)(object)instance, ANJCLPDCJHL: true);
		}
	}

	public void KMNHFCOANKG(int playerNum, bool sendOnline)
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(playerNum) != (Object)null && (Object)(object)instance.kujakuTable != (Object)null)
		{
			((Component)PlayerController.OPHDCMJLLEC(playerNum)).transform.parent = instance.kujakuTable.transform;
			((Behaviour)instance.kujakuTable.GetComponent<BoxCollider2D>()).enabled = false;
		}
		if (sendOnline && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.OCFEADODOND((byte)OnlinePlayerDataManager.JBDEFDMGCDA(playerNum));
		}
	}

	public void AJHMPDEECLA()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.CLMLEINNHMG());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
	}

	private void LOLCJNJBKDD()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			awningManager.awningControllers.ForceCloseAwning();
			kujakuRoutine.noDisableOnReset = true;
			((Behaviour)kujakuRoutine).enabled = false;
		}
		kujakuSignal.SetActive(false);
		sake.SetActive(false);
		((Component)KujakuNPC.NEFIEJALANL()).transform.position = characterPositions[1].position;
		KujakuNPC.DEGPIHEEFHJ().content.SetActive(false);
		KujakuNPC.DEGPIHEEFHJ().animationBase.CGEADHOLHCH("Week", EGFGNGJGBOP: false);
		KujakuNPC.BADFKMEJOKE().animationBase.SetDirection(Direction.Down);
		((Component)HikariNPC.ABDJJBFNLBJ()).transform.position = characterPositions[0].position;
		HikariNPC.EFPJLFMBPLL().content.SetActive(false);
		HikariNPC.ABDJJBFNLBJ().animationBase.SetBool(" ", EGFGNGJGBOP: true, HALNIEBONKH: true);
		HikariNPC.OFLELHKKNKC().animationBase.SetDirection(Direction.Left);
		HikariNPC.MNFMOEKMJKN().inScene = false;
	}

	private void FJFCPIPAGLK(bool BFLCJPHHDJM)
	{
		Debug.Log((object)("Whiskey" + BFLCJPHHDJM + "Normal" + KujakuNPC.LANAINBEMCM().EHHOHCPHAAO));
		if (BFLCJPHHDJM && Utils.MMMFJPKECAB(~(Location.River | Location.Farm)))
		{
			CJODOOFLLLB = KujakuNPC.MAAAKALBBEE().EHHOHCPHAAO;
			StartEvent(BFLCJPHHDJM, CDPAMNIPPEC: true);
		}
	}

	public void LFGPKDFDJGI()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.DALBJEOPLEI());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
	}

	public void JOMPKHHIDOA()
	{
		instance.EndEvent(BFLCJPHHDJM: true);
	}
}
