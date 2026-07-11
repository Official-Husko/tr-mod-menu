using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class KlaynTavernEvent : GameEvent
{
	[CompilerGenerated]
	private sealed class KIAIDGNGHIA : IEnumerator<object>, IEnumerator, IDisposable
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
		public KIAIDGNGHIA(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				DialogueCameraTarget.GetPlayer(1).cameraInEvent = true;
				DialogueCameraTarget.GetPlayer(1).MoveCameraToPositionFromCameraTarget(Vector2.op_Implicit(((Component)KlaynNPC.instance).transform.position));
				_003C_003E2__current = KlaynNPC.instance.StartObserverDialogueWhenItIsPossible(1);
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
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

	public static KlaynTavernEvent instance;

	public GameObject guardPrefab;

	private Coroutine NJAHPOIJMPM;

	public GuardKlaynEvent guard;

	public GuardKlaynEvent guard2;

	private bool KOFENOPMKDC;

	private IEnumerator BPACBOFKLFI(bool GFNHAMCPEAK)
	{
		EDGDFPPKGDL = null;
		KlaynNPC klaynNPC = KlaynNPC.instance;
		klaynNPC.ConversationStarted = (Action<bool>)Delegate.Remove(klaynNPC.ConversationStarted, new Action<bool>(AEEHFGIDCMJ));
		MusicController.instance.FadeOutClip(2f, MMEHJCGGNFE: true);
		int playerNum = 1;
		if (GameManager.LocalCoop())
		{
			playerNum = KlaynNPC.instance.EHHOHCPHAAO;
		}
		if (BBNJNAMKICJ())
		{
			PlayerInputs.DisableKeyboardInputsAndMovement(playerNum, (MonoBehaviour)(object)this);
		}
		KlaynNPC.instance.disable = true;
		guard.destroy = true;
		guard2.destroy = true;
		if (OnlineManager.MasterOrOffline())
		{
			Bar.instance.blockBarSpaces = false;
			KlaynNPC.instance.animationBase.SetTrigger("Random");
		}
		yield return CommonReferences.wait1;
		if (OnlineManager.MasterOrOffline())
		{
			KlaynNPC.instance.targetWalkTo = new Vector2(6f, 904f);
			KlaynNPC.instance.ChangeState(KlaynState.WalkTo);
			KOFENOPMKDC = true;
		}
		yield return CommonReferences.wait02;
		guard.targetWalkTo = Vector2.op_Implicit(new Vector2(6f, 904f));
		guard.animationBase.SetDirection(guard2.animationBase.FCGBJEIIMBC);
		guard.StartWalking();
		yield return CommonReferences.wait02;
		guard2.targetWalkTo = Vector2.op_Implicit(new Vector2(6f, 904f));
		guard2.animationBase.SetDirection(guard2.animationBase.FCGBJEIIMBC);
		guard2.StartWalking();
		Debug.Log((object)"Waiting for guards to finish walking...");
		while ((Object)(object)guard2 != (Object)null)
		{
			yield return null;
		}
		Debug.Log((object)"Guards finished walking.");
		KOFENOPMKDC = false;
		MaiNPC.GGFJGHHHEJC.ActiveMaiInBar();
		yield return CommonReferences.wait1;
		PlayerInputs.EnableKeyboardInputsAndMovement(playerNum, (MonoBehaviour)(object)this);
		PlayerController.GetPlayer(playerNum).characterAnimation.LookAt(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		EDGDFPPKGDL = MaiNPC.GGFJGHHHEJC;
		MDFALJKHKED = "TabernaClausurada/MaiDialogue 02";
		if (GFNHAMCPEAK)
		{
			MaiNPC.GGFJGHHHEJC.StartConversation(playerNum, MDFALJKHKED);
		}
		else if (BBNJNAMKICJ())
		{
			yield return MaiNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
			MaiNPC maiNPC = MaiNPC.GGFJGHHHEJC;
			maiNPC.ConversationEnded = (Action<bool>)Delegate.Combine(maiNPC.ConversationEnded, new Action<bool>(MICIEFNANML));
		}
		DialogueLua.SetVariable("LE_22", (object)1);
		TavernBuilding.instance.ActivateCeaseSigns(DMBFKFLDDLH: true);
		MusicController.instance.TriggerCurrentBasicMood();
		CastleFormEvent.instance.ActivateEvent();
		if (OnlineManager.MasterOrOffline())
		{
			LettersManager.instance.AddNewReceivedLetter(1011);
		}
	}

	private void DGHPACOPEAI(bool GFNHAMCPEAK)
	{
		MaiNPC maiNPC = MaiNPC.GGFJGHHHEJC;
		maiNPC.ConversationEnded = (Action<bool>)Delegate.Remove(maiNPC.ConversationEnded, new Action<bool>(MICIEFNANML));
		DialogueCameraTarget.IOBMIHLMGNH(1).FKEAOBGOJPI();
	}

	private void BLNHCAGIOAN(int JIIGOACEIKL)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("MainProgress");
		if (((Result)(ref variable)).asInt > 1)
		{
			TavernManager tavernManager = TavernManager.GGFJGHHHEJC;
			tavernManager.OnTavernOpen = (Action<int>)Delegate.Remove(tavernManager.OnTavernOpen, new Action<int>(BLNHCAGIOAN));
			TavernManager tavernManager2 = TavernManager.GGFJGHHHEJC;
			tavernManager2.OnTavernClose = (Action<int>)Delegate.Remove(tavernManager2.OnTavernClose, new Action<int>(CKOHCGBADKN));
		}
		else if (TavernReputation.GetMilestone() >= 3 && MissionsManager.instance.IsMissionComplete(301) && Utils.NGLLIJPOBEC(Location.Tavern))
		{
			NJAHPOIJMPM = ((MonoBehaviour)this).StartCoroutine(IMBKPMBEILK());
		}
	}

	private void LANGHIOBJIH()
	{
		if (OnlineManager.MasterOrOffline())
		{
			TavernManager tavernManager = TavernManager.GGFJGHHHEJC;
			tavernManager.OnTavernOpen = (Action<int>)Delegate.Combine(tavernManager.OnTavernOpen, new Action<int>(BLNHCAGIOAN));
			TavernManager tavernManager2 = TavernManager.GGFJGHHHEJC;
			tavernManager2.OnTavernClose = (Action<int>)Delegate.Combine(tavernManager2.OnTavernClose, new Action<int>(CKOHCGBADKN));
		}
	}

	private IEnumerator IMBKPMBEILK()
	{
		yield return (object)new WaitForSeconds(90f);
		while (!Utils.NGLLIJPOBEC(Location.Tavern))
		{
			yield return null;
		}
		if (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			StartEvent(GFNHAMCPEAK: true, CDPAMNIPPEC: true);
			NJAHPOIJMPM = null;
		}
	}

	private void EPHJILCDGMI(bool GFNHAMCPEAK)
	{
		MaiNPC maiNPC = MaiNPC.GGFJGHHHEJC;
		maiNPC.ConversationEnded = (Action<bool>)Delegate.Remove(maiNPC.ConversationEnded, new Action<bool>(EPHJILCDGMI));
		DialogueCameraTarget.IJMLNIHAOGK(0).FKEAOBGOJPI(1);
	}

	public override void StartEvent(bool GFNHAMCPEAK, bool CDPAMNIPPEC)
	{
		base.StartEvent(GFNHAMCPEAK, CDPAMNIPPEC);
		((MonoBehaviour)this).StartCoroutine(DHKNOIJDFDJ(GFNHAMCPEAK));
	}

	private void MICIEFNANML(bool GFNHAMCPEAK)
	{
		MaiNPC maiNPC = MaiNPC.GGFJGHHHEJC;
		maiNPC.ConversationEnded = (Action<bool>)Delegate.Remove(maiNPC.ConversationEnded, new Action<bool>(MICIEFNANML));
		DialogueCameraTarget.GetPlayer(1).ReturnControlToCameraTarget();
	}

	private IEnumerator JGKMBGMAJAE()
	{
		return new KIAIDGNGHIA(1);
	}

	private void DOOPGCNKLJP(int JIIGOACEIKL)
	{
		if (NJAHPOIJMPM != null)
		{
			((MonoBehaviour)this).StopCoroutine(NJAHPOIJMPM);
			NJAHPOIJMPM = null;
		}
	}

	private void NEEDICILAND(int JIIGOACEIKL)
	{
		if (NJAHPOIJMPM != null)
		{
			((MonoBehaviour)this).StopCoroutine(NJAHPOIJMPM);
			NJAHPOIJMPM = null;
		}
	}

	public override void EndEvent(bool GFNHAMCPEAK = true)
	{
		base.EndEvent(GFNHAMCPEAK);
		((MonoBehaviour)this).StartCoroutine(NMIEOCMCEFC(GFNHAMCPEAK));
	}

	private bool FHKOIKMFOJF()
	{
		if (PlayerController.GetPlayer(0).IsTavernLocation())
		{
			return !MainUI.BBNDLNLJIEB();
		}
		return false;
	}

	private void FICBJELPHFN(int JIIGOACEIKL)
	{
		if (NJAHPOIJMPM != null)
		{
			((MonoBehaviour)this).StopCoroutine(NJAHPOIJMPM);
			NJAHPOIJMPM = null;
		}
	}

	private void AMMEOCGLAPC(bool GFNHAMCPEAK)
	{
		MaiNPC maiNPC = MaiNPC.GGFJGHHHEJC;
		maiNPC.ConversationEnded = (Action<bool>)Delegate.Remove(maiNPC.ConversationEnded, new Action<bool>(EPHJILCDGMI));
		DialogueCameraTarget.DACNEICGAAE(1).FKEAOBGOJPI(1);
	}

	private void Start()
	{
		if (OnlineManager.MasterOrOffline())
		{
			TavernManager tavernManager = TavernManager.GGFJGHHHEJC;
			tavernManager.OnTavernOpen = (Action<int>)Delegate.Combine(tavernManager.OnTavernOpen, new Action<int>(BLNHCAGIOAN));
			TavernManager tavernManager2 = TavernManager.GGFJGHHHEJC;
			tavernManager2.OnTavernClose = (Action<int>)Delegate.Combine(tavernManager2.OnTavernClose, new Action<int>(CKOHCGBADKN));
		}
	}

	public override GameEvent GetInstance()
	{
		return instance;
	}

	private IEnumerator CHKLFCJNDEF()
	{
		DialogueCameraTarget.GetPlayer(1).cameraInEvent = true;
		DialogueCameraTarget.GetPlayer(1).MoveCameraToPositionFromCameraTarget(Vector2.op_Implicit(((Component)KlaynNPC.instance).transform.position));
		yield return KlaynNPC.instance.StartObserverDialogueWhenItIsPossible(1);
	}

	private bool FDFHMMGOJNN()
	{
		if (PlayerController.GetPlayer(0).IsTavernLocation())
		{
			return MainUI.BHNFPAIHJLM();
		}
		return false;
	}

	private void DFLLEHEFPHD(int JIIGOACEIKL)
	{
		if (NJAHPOIJMPM != null)
		{
			((MonoBehaviour)this).StopCoroutine(NJAHPOIJMPM);
			NJAHPOIJMPM = null;
		}
	}

	private IEnumerator NMIEOCMCEFC(bool GFNHAMCPEAK)
	{
		EDGDFPPKGDL = null;
		KlaynNPC klaynNPC = KlaynNPC.instance;
		klaynNPC.ConversationStarted = (Action<bool>)Delegate.Remove(klaynNPC.ConversationStarted, new Action<bool>(AEEHFGIDCMJ));
		MusicController.instance.FadeOutClip(2f, MMEHJCGGNFE: true);
		int playerNum = 1;
		if (GameManager.LocalCoop())
		{
			playerNum = KlaynNPC.instance.EHHOHCPHAAO;
		}
		if (BBNJNAMKICJ())
		{
			PlayerInputs.DisableKeyboardInputsAndMovement(playerNum, (MonoBehaviour)(object)this);
		}
		KlaynNPC.instance.disable = true;
		guard.destroy = true;
		guard2.destroy = true;
		if (OnlineManager.MasterOrOffline())
		{
			Bar.instance.blockBarSpaces = false;
			KlaynNPC.instance.animationBase.SetTrigger("Random");
		}
		yield return CommonReferences.wait1;
		if (OnlineManager.MasterOrOffline())
		{
			KlaynNPC.instance.targetWalkTo = new Vector2(6f, 904f);
			KlaynNPC.instance.ChangeState(KlaynState.WalkTo);
			KOFENOPMKDC = true;
		}
		yield return CommonReferences.wait02;
		guard.targetWalkTo = Vector2.op_Implicit(new Vector2(6f, 904f));
		guard.animationBase.SetDirection(guard2.animationBase.FCGBJEIIMBC);
		guard.StartWalking();
		yield return CommonReferences.wait02;
		guard2.targetWalkTo = Vector2.op_Implicit(new Vector2(6f, 904f));
		guard2.animationBase.SetDirection(guard2.animationBase.FCGBJEIIMBC);
		guard2.StartWalking();
		Debug.Log((object)"Waiting for guards to finish walking...");
		while ((Object)(object)guard2 != (Object)null)
		{
			yield return null;
		}
		Debug.Log((object)"Guards finished walking.");
		KOFENOPMKDC = false;
		MaiNPC.GGFJGHHHEJC.ActiveMaiInBar();
		yield return CommonReferences.wait1;
		PlayerInputs.EnableKeyboardInputsAndMovement(playerNum, (MonoBehaviour)(object)this);
		PlayerController.GetPlayer(playerNum).characterAnimation.LookAt(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		EDGDFPPKGDL = MaiNPC.GGFJGHHHEJC;
		MDFALJKHKED = "TabernaClausurada/MaiDialogue 02";
		if (GFNHAMCPEAK)
		{
			MaiNPC.GGFJGHHHEJC.StartConversation(playerNum, MDFALJKHKED);
		}
		else if (BBNJNAMKICJ())
		{
			yield return MaiNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
			MaiNPC maiNPC = MaiNPC.GGFJGHHHEJC;
			maiNPC.ConversationEnded = (Action<bool>)Delegate.Combine(maiNPC.ConversationEnded, new Action<bool>(MICIEFNANML));
		}
		DialogueLua.SetVariable("LE_22", (object)1);
		TavernBuilding.instance.ActivateCeaseSigns(DMBFKFLDDLH: true);
		MusicController.instance.TriggerCurrentBasicMood();
		CastleFormEvent.instance.ActivateEvent();
		if (OnlineManager.MasterOrOffline())
		{
			LettersManager.instance.AddNewReceivedLetter(1011);
		}
	}

	private bool BBNJNAMKICJ()
	{
		if (PlayerController.GetPlayer(1).IsTavernLocation())
		{
			return !MainUI.IsAnyUIOpen();
		}
		return false;
	}

	private void HBMDEHPHAPF()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			TavernManager tavernManager = TavernManager.GGFJGHHHEJC;
			tavernManager.OnTavernOpen = (Action<int>)Delegate.Combine(tavernManager.OnTavernOpen, new Action<int>(BLNHCAGIOAN));
			TavernManager tavernManager2 = TavernManager.GGFJGHHHEJC;
			tavernManager2.OnTavernClose = (Action<int>)Delegate.Combine(tavernManager2.OnTavernClose, new Action<int>(DFLLEHEFPHD));
		}
	}

	private bool GDNPOMJGCND()
	{
		if (PlayerController.GetPlayer(1).IsTavernLocation())
		{
			return !MainUI.BBNDLNLJIEB();
		}
		return false;
	}

	private IEnumerator BCGABOCODJG()
	{
		DialogueCameraTarget.GetPlayer(1).cameraInEvent = true;
		DialogueCameraTarget.GetPlayer(1).MoveCameraToPositionFromCameraTarget(Vector2.op_Implicit(((Component)KlaynNPC.instance).transform.position));
		yield return KlaynNPC.instance.StartObserverDialogueWhenItIsPossible(1);
	}

	private void PKEPBKHEDOD()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if (KOFENOPMKDC)
		{
			PlayerController.GetPlayer(KlaynNPC.instance.EHHOHCPHAAO).characterAnimation.FEJFMBPBJGA(Vector2.op_Implicit(((Component)KlaynNPC.instance).transform.position));
		}
	}

	private void AEEHFGIDCMJ(bool GFNHAMCPEAK)
	{
		KlaynNPC klaynNPC = KlaynNPC.instance;
		klaynNPC.ConversationStarted = (Action<bool>)Delegate.Remove(klaynNPC.ConversationStarted, new Action<bool>(AEEHFGIDCMJ));
		Debug.Log((object)("OnConversationStarted " + GFNHAMCPEAK));
		EDGDFPPKGDL = KlaynNPC.instance;
		MDFALJKHKED = "TabernaClausurada/KlaynDialogue 01";
		if (!GFNHAMCPEAK && BBNJNAMKICJ())
		{
			((MonoBehaviour)this).StartCoroutine(BCGABOCODJG());
		}
	}

	private bool FDCIBPCFBOJ()
	{
		if (PlayerController.GetPlayer(1).IsTavernLocation())
		{
			return MainUI.BBNDLNLJIEB();
		}
		return true;
	}

	private void PMDCBHFKGBM(bool GFNHAMCPEAK)
	{
		KlaynNPC klaynNPC = KlaynNPC.instance;
		klaynNPC.ConversationStarted = (Action<bool>)Delegate.Remove(klaynNPC.ConversationStarted, new Action<bool>(AEEHFGIDCMJ));
		Debug.Log((object)("ToggleListView" + GFNHAMCPEAK));
		EDGDFPPKGDL = KlaynNPC.instance;
		MDFALJKHKED = " ";
		if (!GFNHAMCPEAK && BBNJNAMKICJ())
		{
			((MonoBehaviour)this).StartCoroutine(BCGABOCODJG());
		}
	}

	private void HJOMJHKKBFK(int JIIGOACEIKL)
	{
		if (NJAHPOIJMPM != null)
		{
			((MonoBehaviour)this).StopCoroutine(NJAHPOIJMPM);
			NJAHPOIJMPM = null;
		}
	}

	protected override void Awake()
	{
		base.Awake();
		instance = this;
	}

	private IEnumerator LLJPGCCEMKB()
	{
		yield return (object)new WaitForSeconds(90f);
		while (!Utils.NGLLIJPOBEC(Location.Tavern))
		{
			yield return null;
		}
		if (TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			StartEvent(GFNHAMCPEAK: true, CDPAMNIPPEC: true);
			NJAHPOIJMPM = null;
		}
	}

	public IEnumerator ExecuteAllCoroutines()
	{
		yield return DHKNOIJDFDJ(GFNHAMCPEAK: false);
	}

	private bool DHEMHHJBDOG()
	{
		if (PlayerController.GetPlayer(1).IsTavernLocation())
		{
			return MainUI.ADNMPFPHCMB();
		}
		return true;
	}

	private IEnumerator DHKNOIJDFDJ(bool GFNHAMCPEAK)
	{
		EventsManager.SetActive(EventsManager.EventType.KlaynTavern, DMBFKFLDDLH: true);
		yield return CommonReferences.wait3;
		EDGDFPPKGDL = null;
		MusicController.instance.FadeOutClip(2f, MMEHJCGGNFE: true);
		KlaynNPC.instance.content.SetActive(true);
		if (OnlineManager.PlayingOnline())
		{
			KlaynNPC klaynNPC = KlaynNPC.instance;
			klaynNPC.ConversationStarted = (Action<bool>)Delegate.Combine(klaynNPC.ConversationStarted, new Action<bool>(AEEHFGIDCMJ));
		}
		if (OnlineManager.MasterOrOffline())
		{
			Bar.instance.blockBarSpaces = true;
			for (int i = 0; i < Bar.instance.occupier.Length; i++)
			{
				if ((Object)(object)Bar.instance.occupier[i] != (Object)null)
				{
					Bar.instance.occupier[i].customer.ChangeState(CustomerState.Leaving);
				}
			}
			Bar.instance.ClearBar(1);
			((Component)KlaynNPC.instance).transform.position = Vector2.op_Implicit(new Vector2(6f, 904f));
			KlaynNPC.instance.animationBase.SetDirection(Direction.Up);
			KlaynNPC.instance.targetWalkTo = Vector2.op_Implicit(((Component)Bar.instance.barSpaces[1]).transform.position);
			KlaynNPC.instance.endWalkDirection = Direction.Down;
			KlaynNPC.instance.endTriggerAnimation = "Observation";
			KlaynNPC.instance.ChangeState(KlaynState.WalkTo);
		}
		yield return CommonReferences.wait02;
		guard = Object.Instantiate<GameObject>(guardPrefab, Vector2.op_Implicit(new Vector2(6f, 904f)), Quaternion.identity).GetComponent<GuardKlaynEvent>();
		guard.animationBase.SetDirection(Direction.Up);
		guard.endWalkDirection = Direction.Down;
		guard.targetWalkTo = ((Component)Bar.instance.barSpaces[0]).transform.position;
		yield return CommonReferences.wait02;
		guard2 = Object.Instantiate<GameObject>(guardPrefab, Vector2.op_Implicit(new Vector2(6f, 904f)), Quaternion.identity).GetComponent<GuardKlaynEvent>();
		guard2.animationBase.SetDirection(Direction.Up);
		guard2.endWalkDirection = Direction.Down;
		guard2.targetWalkTo = ((Component)Bar.instance.barSpaces[2]).transform.position;
		KlaynNPC.instance.barksTime = 7f + Time.time;
		yield return CommonReferences.wait1;
		MusicController.instance.TriggerMusicTheme(28);
	}

	private void Update()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		if (KOFENOPMKDC)
		{
			PlayerController.GetPlayer(KlaynNPC.instance.EHHOHCPHAAO).characterAnimation.LookAt(Vector2.op_Implicit(((Component)KlaynNPC.instance).transform.position));
		}
	}

	private void CKOHCGBADKN(int JIIGOACEIKL)
	{
		if (NJAHPOIJMPM != null)
		{
			((MonoBehaviour)this).StopCoroutine(NJAHPOIJMPM);
			NJAHPOIJMPM = null;
		}
	}

	private void MAGDLEGDDLD(int JIIGOACEIKL)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Mooruroa");
		if (((Result)(ref variable)).asInt > 0)
		{
			TavernManager tavernManager = TavernManager.GGFJGHHHEJC;
			tavernManager.OnTavernOpen = (Action<int>)Delegate.Remove(tavernManager.OnTavernOpen, new Action<int>(MAGDLEGDDLD));
			TavernManager tavernManager2 = TavernManager.GGFJGHHHEJC;
			tavernManager2.OnTavernClose = (Action<int>)Delegate.Remove(tavernManager2.OnTavernClose, new Action<int>(FICBJELPHFN));
		}
		else if (TavernReputation.GetMilestone() >= 4 && MissionsManager.instance.BMFOFINGDLK(-28) && Utils.NGLLIJPOBEC(Location.None))
		{
			NJAHPOIJMPM = ((MonoBehaviour)this).StartCoroutine(IMBKPMBEILK());
		}
	}
}
