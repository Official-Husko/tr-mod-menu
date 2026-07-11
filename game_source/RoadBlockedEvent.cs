using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RoadBlockedEvent : GameEvent
{
	[CompilerGenerated]
	private sealed class AIMKFBHLLCG : IEnumerator<object>, IEnumerator, IDisposable
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
		public AIMKFBHLLCG(int _003C_003E1__state)
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
				BobNPC.GGFJGHHHEJC.animationBase.SetBool("Sleep", EGFGNGJGBOP: false, HALNIEBONKH: true);
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				instance.EDGDFPPKGDL = BobNPC.GGFJGHHHEJC;
				instance.MDFALJKHKED = "RoadBlocked/Main 2";
				BobNPC.GGFJGHHHEJC.blockActionBar = false;
				BobNPC.GGFJGHHHEJC.inSpecialEvent = false;
				BobNPC.GGFJGHHHEJC.dialogueActor.actor = "Bob";
				BobNPC.GGFJGHHHEJC.dialogueActor.spritePortrait = BobNPC.GGFJGHHHEJC.bobPortrait;
				if (instance.isActor)
				{
					BobNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "RoadBlocked/Main 2");
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
	private sealed class NNHLBCGNEOA : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public RoadBlockedEvent _003C_003E4__this;

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
		public NNHLBCGNEOA(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0113: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			RoadBlockedEvent roadBlockedEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				if (OnlineManager.MasterOrOffline())
				{
					BobNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(roadBlockedEvent.bobMovePosition.position), Direction.Down, AMEOKNOLILB: true);
				}
				BobNPC.GGFJGHHHEJC.playerCanInteract = false;
				HotBathEvent.instance.ActivateEvent();
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				if (instance.isActor)
				{
					DialogueCameraTarget.GetPlayer(BobNPC.GGFJGHHHEJC.EHHOHCPHAAO).ReturnControlToCameraTarget();
					PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
				}
				MissionsManager.instance.StartMission(325, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
				goto IL_00d5;
			case 2:
				_003C_003E1__state = -1;
				goto IL_00d5;
			case 3:
				{
					_003C_003E1__state = -1;
					Debug.Log((object)"RoadBlockedEvent: Bob goes to farm");
					((Component)BobNPC.GGFJGHHHEJC).transform.position = roadBlockedEvent.bobFarmPosition.position;
					BobNPC.GGFJGHHHEJC.content.SetActive(true);
					((Behaviour)BobNPC.GGFJGHHHEJC.bobAnim).enabled = true;
					BobNPC.GGFJGHHHEJC.playerCanInteract = true;
					return false;
				}
				IL_00d5:
				if (Utils.NGLLIJPOBEC(Location.Farm))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 2;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait5;
				_003C_003E1__state = 3;
				return true;
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

	public static RoadBlockedEvent instance;

	public Transform bobPosition;

	public Transform bobMovePosition;

	public Transform bobFarmPosition;

	private IEnumerator GGGBGFGDLPA()
	{
		if (OnlineManager.MasterOrOffline())
		{
			BobNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(bobMovePosition.position), Direction.Down, AMEOKNOLILB: true);
		}
		BobNPC.GGFJGHHHEJC.playerCanInteract = false;
		HotBathEvent.instance.ActivateEvent();
		yield return CommonReferences.wait2;
		if (instance.isActor)
		{
			DialogueCameraTarget.GetPlayer(BobNPC.GGFJGHHHEJC.EHHOHCPHAAO).ReturnControlToCameraTarget();
			PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		}
		MissionsManager.instance.StartMission(325, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		while (Utils.NGLLIJPOBEC(Location.Farm))
		{
			yield return null;
		}
		yield return CommonReferences.wait5;
		Debug.Log((object)"RoadBlockedEvent: Bob goes to farm");
		((Component)BobNPC.GGFJGHHHEJC).transform.position = bobFarmPosition.position;
		BobNPC.GGFJGHHHEJC.content.SetActive(true);
		((Behaviour)BobNPC.GGFJGHHHEJC.bobAnim).enabled = true;
		BobNPC.GGFJGHHHEJC.playerCanInteract = true;
	}

	private IEnumerator DHINCHODEFI()
	{
		if (OnlineManager.MasterOrOffline())
		{
			BobNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(bobMovePosition.position), Direction.Down, AMEOKNOLILB: true);
		}
		BobNPC.GGFJGHHHEJC.playerCanInteract = false;
		HotBathEvent.instance.ActivateEvent();
		yield return CommonReferences.wait2;
		if (instance.isActor)
		{
			DialogueCameraTarget.GetPlayer(BobNPC.GGFJGHHHEJC.EHHOHCPHAAO).ReturnControlToCameraTarget();
			PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		}
		MissionsManager.instance.StartMission(325, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		while (Utils.NGLLIJPOBEC(Location.Farm))
		{
			yield return null;
		}
		yield return CommonReferences.wait5;
		Debug.Log((object)"RoadBlockedEvent: Bob goes to farm");
		((Component)BobNPC.GGFJGHHHEJC).transform.position = bobFarmPosition.position;
		BobNPC.GGFJGHHHEJC.content.SetActive(true);
		((Behaviour)BobNPC.GGFJGHHHEJC.bobAnim).enabled = true;
		BobNPC.GGFJGHHHEJC.playerCanInteract = true;
	}

	private void PHENEPGPJKO(bool BFLCJPHHDJM)
	{
		isActor = BFLCJPHHDJM;
		BobNPC bobNPC = BobNPC.GGFJGHHHEJC;
		bobNPC.ConversationStarted = (Action<bool>)Delegate.Remove(bobNPC.ConversationStarted, new Action<bool>(NLNDMDEEJDB));
		if (isActor)
		{
			CJODOOFLLLB = BobNPC.POINNCPMEIG().EHHOHCPHAAO;
			StartEvent(isActor, CDPAMNIPPEC: true);
		}
	}

	private IEnumerator OPGAJFLIGOM()
	{
		BobNPC.GGFJGHHHEJC.animationBase.SetBool("Sleep", EGFGNGJGBOP: false, HALNIEBONKH: true);
		yield return CommonReferences.wait1;
		instance.EDGDFPPKGDL = BobNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "RoadBlocked/Main 2";
		BobNPC.GGFJGHHHEJC.blockActionBar = false;
		BobNPC.GGFJGHHHEJC.inSpecialEvent = false;
		BobNPC.GGFJGHHHEJC.dialogueActor.actor = "Bob";
		BobNPC.GGFJGHHHEJC.dialogueActor.spritePortrait = BobNPC.GGFJGHHHEJC.bobPortrait;
		if (instance.isActor)
		{
			BobNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "RoadBlocked/Main 2");
		}
	}

	public void DBPEDPOODBN()
	{
		PlayerInventory.OGKNJNINGMH(BobNPC.BNDNMBGJEKP().EHHOHCPHAAO, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AddItem(ItemDatabaseAccessor.KMBGJEKCJFJ(84, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: true);
	}

	public void OBNPLOBDOAK()
	{
		PlayerInventory.OGKNJNINGMH(BobNPC.LDBJELPPBAI().EHHOHCPHAAO, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AddItem(ItemDatabaseAccessor.CPMMBEPEJLO(-112, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML());
	}

	private IEnumerator PKKKHFDFLPK()
	{
		if (OnlineManager.MasterOrOffline())
		{
			BobNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(bobMovePosition.position), Direction.Down, AMEOKNOLILB: true);
		}
		BobNPC.GGFJGHHHEJC.playerCanInteract = false;
		HotBathEvent.instance.ActivateEvent();
		yield return CommonReferences.wait2;
		if (instance.isActor)
		{
			DialogueCameraTarget.GetPlayer(BobNPC.GGFJGHHHEJC.EHHOHCPHAAO).ReturnControlToCameraTarget();
			PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		}
		MissionsManager.instance.StartMission(325, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		while (Utils.NGLLIJPOBEC(Location.Farm))
		{
			yield return null;
		}
		yield return CommonReferences.wait5;
		Debug.Log((object)"RoadBlockedEvent: Bob goes to farm");
		((Component)BobNPC.GGFJGHHHEJC).transform.position = bobFarmPosition.position;
		BobNPC.GGFJGHHHEJC.content.SetActive(true);
		((Behaviour)BobNPC.GGFJGHHHEJC.bobAnim).enabled = true;
		BobNPC.GGFJGHHHEJC.playerCanInteract = true;
	}

	private void COHDGLGBBNP(bool BFLCJPHHDJM)
	{
		isActor = BFLCJPHHDJM;
		BobNPC bobNPC = BobNPC.BNDNMBGJEKP();
		bobNPC.ConversationStarted = (Action<bool>)Delegate.Remove(bobNPC.ConversationStarted, new Action<bool>(OCADBOKNLLO));
		if (isActor)
		{
			CJODOOFLLLB = BobNPC.DFJGHOHPPEL().EHHOHCPHAAO;
			StartEvent(isActor, CDPAMNIPPEC: true);
		}
	}

	private IEnumerator FANGJJOFJNG()
	{
		return new AIMKFBHLLCG(1);
	}

	public void OCLBPLGEPJL()
	{
		PlayerInventory.EIFPKCAFDIB(BobNPC.BNDNMBGJEKP().EHHOHCPHAAO, LAGHIOKLJGH: true).AddItem(ItemDatabaseAccessor.KMBGJEKCJFJ(47, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: false);
	}

	private IEnumerator ONCFGJMLJIP()
	{
		return new AIMKFBHLLCG(1);
	}

	public void PEEFFOBFFED()
	{
		((MonoBehaviour)instance).StartCoroutine(CJKGCMDCGGK());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendAwakeBob();
		}
	}

	public void GiveBottle()
	{
		PlayerInventory.GetPlayer(BobNPC.GGFJGHHHEJC.EHHOHCPHAAO).AddItem(ItemDatabaseAccessor.GetItem(1961).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
	}

	public void LGELLGLLIOA()
	{
		((MonoBehaviour)instance).StartCoroutine(CIOFCNDNJIE());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendAwakeBob();
		}
	}

	public void GHPOGAFKOBH()
	{
		((MonoBehaviour)instance).StartCoroutine(EMJHNHFPHEE());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.EAOBJJDKPKO();
		}
	}

	private IEnumerator BDLBPIJEHKD()
	{
		return new AIMKFBHLLCG(1);
	}

	public void IEPMOGBPABB()
	{
		((MonoBehaviour)instance).StartCoroutine(HPGJAIBIBEO());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.EAOBJJDKPKO();
		}
	}

	private IEnumerator IKDENICFIFN()
	{
		return new NNHLBCGNEOA(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JHFEIKHMMHF()
	{
		BobNPC.GGFJGHHHEJC.animationBase.SetBool("Sleep", EGFGNGJGBOP: false, HALNIEBONKH: true);
		yield return CommonReferences.wait1;
		instance.EDGDFPPKGDL = BobNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "RoadBlocked/Main 2";
		BobNPC.GGFJGHHHEJC.blockActionBar = false;
		BobNPC.GGFJGHHHEJC.inSpecialEvent = false;
		BobNPC.GGFJGHHHEJC.dialogueActor.actor = "Bob";
		BobNPC.GGFJGHHHEJC.dialogueActor.spritePortrait = BobNPC.GGFJGHHHEJC.bobPortrait;
		if (instance.isActor)
		{
			BobNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "RoadBlocked/Main 2");
		}
	}

	public void HIHBFICMIJC()
	{
		PlayerInventory.GetPlayer(BobNPC.GGFJGHHHEJC.EHHOHCPHAAO, LAGHIOKLJGH: true).OJDGOADOCMG(ItemDatabaseAccessor.CPMMBEPEJLO(-136).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false, EHGHJNOFMKF: true, APBCMCOAFDM: false);
	}

	private IEnumerator OGHLNLPFDOP()
	{
		if (OnlineManager.MasterOrOffline())
		{
			BobNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(bobMovePosition.position), Direction.Down, AMEOKNOLILB: true);
		}
		BobNPC.GGFJGHHHEJC.playerCanInteract = false;
		HotBathEvent.instance.ActivateEvent();
		yield return CommonReferences.wait2;
		if (instance.isActor)
		{
			DialogueCameraTarget.GetPlayer(BobNPC.GGFJGHHHEJC.EHHOHCPHAAO).ReturnControlToCameraTarget();
			PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		}
		MissionsManager.instance.StartMission(325, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		while (Utils.NGLLIJPOBEC(Location.Farm))
		{
			yield return null;
		}
		yield return CommonReferences.wait5;
		Debug.Log((object)"RoadBlockedEvent: Bob goes to farm");
		((Component)BobNPC.GGFJGHHHEJC).transform.position = bobFarmPosition.position;
		BobNPC.GGFJGHHHEJC.content.SetActive(true);
		((Behaviour)BobNPC.GGFJGHHHEJC.bobAnim).enabled = true;
		BobNPC.GGFJGHHHEJC.playerCanInteract = true;
	}

	private void EJNMPNOLOIG(bool BFLCJPHHDJM)
	{
		isActor = BFLCJPHHDJM;
		BobNPC bobNPC = BobNPC.DFJGHOHPPEL();
		bobNPC.ConversationStarted = (Action<bool>)Delegate.Remove(bobNPC.ConversationStarted, new Action<bool>(ABAFFIJLPCM));
		if (isActor)
		{
			CJODOOFLLLB = BobNPC.DFJGHOHPPEL().EHHOHCPHAAO;
			StartEvent(isActor, CDPAMNIPPEC: false);
		}
	}

	private void LEEHOCDOLKE(bool BFLCJPHHDJM)
	{
		isActor = BFLCJPHHDJM;
		BobNPC bobNPC = BobNPC.LDBJELPPBAI();
		bobNPC.ConversationStarted = (Action<bool>)Delegate.Remove(bobNPC.ConversationStarted, new Action<bool>(IBOFKHNIPAE));
		if (isActor)
		{
			CJODOOFLLLB = BobNPC.EJHDHCNILDH().EHHOHCPHAAO;
			StartEvent(isActor, CDPAMNIPPEC: true);
		}
	}

	private IEnumerator MKBAPBAMIHM()
	{
		BobNPC.GGFJGHHHEJC.animationBase.SetBool("Sleep", EGFGNGJGBOP: false, HALNIEBONKH: true);
		yield return CommonReferences.wait1;
		instance.EDGDFPPKGDL = BobNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "RoadBlocked/Main 2";
		BobNPC.GGFJGHHHEJC.blockActionBar = false;
		BobNPC.GGFJGHHHEJC.inSpecialEvent = false;
		BobNPC.GGFJGHHHEJC.dialogueActor.actor = "Bob";
		BobNPC.GGFJGHHHEJC.dialogueActor.spritePortrait = BobNPC.GGFJGHHHEJC.bobPortrait;
		if (instance.isActor)
		{
			BobNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "RoadBlocked/Main 2");
		}
	}

	public override void EndEvent(bool BFLCJPHHDJM)
	{
		base.EndEvent(BFLCJPHHDJM);
		((MonoBehaviour)instance).StartCoroutine(instance.LJABJLDHLCB());
	}

	public void KBHHHLJLEPP()
	{
		((MonoBehaviour)instance).StartCoroutine(FIFNJCOCCJM());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.EAOBJJDKPKO();
		}
	}

	public void NGHPJIKAFJA()
	{
		((MonoBehaviour)instance).StartCoroutine(AANHAEENJFO());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.EAOBJJDKPKO();
		}
	}

	public void IKNJMDFAJNK()
	{
		((MonoBehaviour)instance).StartCoroutine(BDLBPIJEHKD());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendAwakeBob();
		}
	}

	private void DHPGIFIKGEK(bool BFLCJPHHDJM)
	{
		isActor = BFLCJPHHDJM;
		BobNPC bobNPC = BobNPC.EJHDHCNILDH();
		bobNPC.ConversationStarted = (Action<bool>)Delegate.Remove(bobNPC.ConversationStarted, new Action<bool>(POGDBEKIDGI));
		if (isActor)
		{
			CJODOOFLLLB = BobNPC.DFJGHOHPPEL().EHHOHCPHAAO;
			StartEvent(isActor, CDPAMNIPPEC: true);
		}
	}

	public void JAPPJBNMIGM()
	{
		((MonoBehaviour)instance).StartCoroutine(JPFHDKPIJFI());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.EAOBJJDKPKO();
		}
	}

	private void KJJPHJKEAHB(bool BFLCJPHHDJM)
	{
		isActor = BFLCJPHHDJM;
		BobNPC bobNPC = BobNPC.POINNCPMEIG();
		bobNPC.ConversationStarted = (Action<bool>)Delegate.Remove(bobNPC.ConversationStarted, new Action<bool>(KJJPHJKEAHB));
		if (isActor)
		{
			CJODOOFLLLB = BobNPC.EJHDHCNILDH().EHHOHCPHAAO;
			StartEvent(isActor, CDPAMNIPPEC: false);
		}
	}

	private IEnumerator OEFKKIOGPII()
	{
		if (OnlineManager.MasterOrOffline())
		{
			BobNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(bobMovePosition.position), Direction.Down, AMEOKNOLILB: true);
		}
		BobNPC.GGFJGHHHEJC.playerCanInteract = false;
		HotBathEvent.instance.ActivateEvent();
		yield return CommonReferences.wait2;
		if (instance.isActor)
		{
			DialogueCameraTarget.GetPlayer(BobNPC.GGFJGHHHEJC.EHHOHCPHAAO).ReturnControlToCameraTarget();
			PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		}
		MissionsManager.instance.StartMission(325, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		while (Utils.NGLLIJPOBEC(Location.Farm))
		{
			yield return null;
		}
		yield return CommonReferences.wait5;
		Debug.Log((object)"RoadBlockedEvent: Bob goes to farm");
		((Component)BobNPC.GGFJGHHHEJC).transform.position = bobFarmPosition.position;
		BobNPC.GGFJGHHHEJC.content.SetActive(true);
		((Behaviour)BobNPC.GGFJGHHHEJC.bobAnim).enabled = true;
		BobNPC.GGFJGHHHEJC.playerCanInteract = true;
	}

	private void GGBCFKJBDGE(bool BFLCJPHHDJM)
	{
		isActor = BFLCJPHHDJM;
		BobNPC bobNPC = BobNPC.EJHDHCNILDH();
		bobNPC.ConversationStarted = (Action<bool>)Delegate.Remove(bobNPC.ConversationStarted, new Action<bool>(EBCLCPEJMPE));
		if (isActor)
		{
			CJODOOFLLLB = BobNPC.DFJGHOHPPEL().EHHOHCPHAAO;
			StartEvent(isActor, CDPAMNIPPEC: false);
		}
	}

	private IEnumerator JMDLIBGFJGL()
	{
		if (OnlineManager.MasterOrOffline())
		{
			BobNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(bobMovePosition.position), Direction.Down, AMEOKNOLILB: true);
		}
		BobNPC.GGFJGHHHEJC.playerCanInteract = false;
		HotBathEvent.instance.ActivateEvent();
		yield return CommonReferences.wait2;
		if (instance.isActor)
		{
			DialogueCameraTarget.GetPlayer(BobNPC.GGFJGHHHEJC.EHHOHCPHAAO).ReturnControlToCameraTarget();
			PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		}
		MissionsManager.instance.StartMission(325, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		while (Utils.NGLLIJPOBEC(Location.Farm))
		{
			yield return null;
		}
		yield return CommonReferences.wait5;
		Debug.Log((object)"RoadBlockedEvent: Bob goes to farm");
		((Component)BobNPC.GGFJGHHHEJC).transform.position = bobFarmPosition.position;
		BobNPC.GGFJGHHHEJC.content.SetActive(true);
		((Behaviour)BobNPC.GGFJGHHHEJC.bobAnim).enabled = true;
		BobNPC.GGFJGHHHEJC.playerCanInteract = true;
	}

	public void LOAKONCLJGD()
	{
		PlayerInventory.GetPlayer(BobNPC.OPDKAPNDBJE().EHHOHCPHAAO, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AddItem(ItemDatabaseAccessor.GetItem(54, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false);
	}

	public void FLEGDLKOFGA()
	{
		PlayerInventory.EIFPKCAFDIB(BobNPC.BNDNMBGJEKP().EHHOHCPHAAO, LAGHIOKLJGH: true).OJDGOADOCMG(ItemDatabaseAccessor.INJBNHPGCIJ(116).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
	}

	private IEnumerator EMJHNHFPHEE()
	{
		return new AIMKFBHLLCG(1);
	}

	public void EGNNCKPPHMF()
	{
		PlayerInventory.GetPlayer(BobNPC.OPDKAPNDBJE().EHHOHCPHAAO, LAGHIOKLJGH: true, ADPNMHGBFKG: true).OJDGOADOCMG(ItemDatabaseAccessor.KMBGJEKCJFJ(66, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: false);
	}

	private IEnumerator GMFCFNHLFGK()
	{
		BobNPC.GGFJGHHHEJC.animationBase.SetBool("Sleep", EGFGNGJGBOP: false, HALNIEBONKH: true);
		yield return CommonReferences.wait1;
		instance.EDGDFPPKGDL = BobNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "RoadBlocked/Main 2";
		BobNPC.GGFJGHHHEJC.blockActionBar = false;
		BobNPC.GGFJGHHHEJC.inSpecialEvent = false;
		BobNPC.GGFJGHHHEJC.dialogueActor.actor = "Bob";
		BobNPC.GGFJGHHHEJC.dialogueActor.spritePortrait = BobNPC.GGFJGHHHEJC.bobPortrait;
		if (instance.isActor)
		{
			BobNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "RoadBlocked/Main 2");
		}
	}

	private IEnumerator AANHAEENJFO()
	{
		return new AIMKFBHLLCG(1);
	}

	private IEnumerator NDAHKMDIKCE()
	{
		return new AIMKFBHLLCG(1);
	}

	public void JLGLOKFGMDG()
	{
		PlayerInventory.OGKNJNINGMH(BobNPC.OPDKAPNDBJE().EHHOHCPHAAO, LAGHIOKLJGH: false, ADPNMHGBFKG: true).OJDGOADOCMG(ItemDatabaseAccessor.GOKIDLOELKB(-114, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: false, EHGHJNOFMKF: false, APBCMCOAFDM: false);
	}

	private IEnumerator FCDACILBALO()
	{
		return new NNHLBCGNEOA(1)
		{
			_003C_003E4__this = this
		};
	}

	public void IADCMIONMAG()
	{
		((MonoBehaviour)instance).StartCoroutine(JHFEIKHMMHF());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendAwakeBob();
		}
	}

	private IEnumerator ODFIKPKCIGG()
	{
		return new NNHLBCGNEOA(1)
		{
			_003C_003E4__this = this
		};
	}

	public void CCNJGIOMCMK()
	{
		((MonoBehaviour)instance).StartCoroutine(IHAOHCCCIPE());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.EAOBJJDKPKO();
		}
	}

	private IEnumerator CJKGCMDCGGK()
	{
		BobNPC.GGFJGHHHEJC.animationBase.SetBool("Sleep", EGFGNGJGBOP: false, HALNIEBONKH: true);
		yield return CommonReferences.wait1;
		instance.EDGDFPPKGDL = BobNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "RoadBlocked/Main 2";
		BobNPC.GGFJGHHHEJC.blockActionBar = false;
		BobNPC.GGFJGHHHEJC.inSpecialEvent = false;
		BobNPC.GGFJGHHHEJC.dialogueActor.actor = "Bob";
		BobNPC.GGFJGHHHEJC.dialogueActor.spritePortrait = BobNPC.GGFJGHHHEJC.bobPortrait;
		if (instance.isActor)
		{
			BobNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "RoadBlocked/Main 2");
		}
	}

	public void OFAHIAKAOEG()
	{
		PlayerInventory.OGKNJNINGMH(BobNPC.EJHDHCNILDH().EHHOHCPHAAO, LAGHIOKLJGH: true).AddItem(ItemDatabaseAccessor.INJBNHPGCIJ(23, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false, EHGHJNOFMKF: false);
	}

	public void OHDMEPKFDIG()
	{
		PlayerInventory.NEKDDPIAOBE(BobNPC.DFJGHOHPPEL().EHHOHCPHAAO).AddItem(ItemDatabaseAccessor.AFOACBIHNCL(176, GGBBJNBBLMF: true).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false, EHGHJNOFMKF: true, APBCMCOAFDM: false);
	}

	public void BPEHIJFNHDN()
	{
		PlayerInventory.GetPlayer(BobNPC.DFJGHOHPPEL().EHHOHCPHAAO, LAGHIOKLJGH: true).AddItem(ItemDatabaseAccessor.GOKIDLOELKB(-141, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: false);
	}

	private void POGDBEKIDGI(bool BFLCJPHHDJM)
	{
		isActor = BFLCJPHHDJM;
		BobNPC bobNPC = BobNPC.LDBJELPPBAI();
		bobNPC.ConversationStarted = (Action<bool>)Delegate.Remove(bobNPC.ConversationStarted, new Action<bool>(FCKNCJKEJPP));
		if (isActor)
		{
			CJODOOFLLLB = BobNPC.OPDKAPNDBJE().EHHOHCPHAAO;
			StartEvent(isActor, CDPAMNIPPEC: true);
		}
	}

	private IEnumerator OLPADKCEBGM()
	{
		if (OnlineManager.MasterOrOffline())
		{
			BobNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(bobMovePosition.position), Direction.Down, AMEOKNOLILB: true);
		}
		BobNPC.GGFJGHHHEJC.playerCanInteract = false;
		HotBathEvent.instance.ActivateEvent();
		yield return CommonReferences.wait2;
		if (instance.isActor)
		{
			DialogueCameraTarget.GetPlayer(BobNPC.GGFJGHHHEJC.EHHOHCPHAAO).ReturnControlToCameraTarget();
			PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		}
		MissionsManager.instance.StartMission(325, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		while (Utils.NGLLIJPOBEC(Location.Farm))
		{
			yield return null;
		}
		yield return CommonReferences.wait5;
		Debug.Log((object)"RoadBlockedEvent: Bob goes to farm");
		((Component)BobNPC.GGFJGHHHEJC).transform.position = bobFarmPosition.position;
		BobNPC.GGFJGHHHEJC.content.SetActive(true);
		((Behaviour)BobNPC.GGFJGHHHEJC.bobAnim).enabled = true;
		BobNPC.GGFJGHHHEJC.playerCanInteract = true;
	}

	public void ALIHIBDLCDP()
	{
		((MonoBehaviour)instance).StartCoroutine(IDEDHJPCJHL());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendAwakeBob();
		}
	}

	private void KJKPIKCPAPN(bool BFLCJPHHDJM)
	{
		isActor = BFLCJPHHDJM;
		BobNPC bobNPC = BobNPC.LDBJELPPBAI();
		bobNPC.ConversationStarted = (Action<bool>)Delegate.Remove(bobNPC.ConversationStarted, new Action<bool>(LEEHOCDOLKE));
		if (isActor)
		{
			CJODOOFLLLB = BobNPC.BNDNMBGJEKP().EHHOHCPHAAO;
			StartEvent(isActor, CDPAMNIPPEC: false);
		}
	}

	private void IEHMACGHAJJ(bool BFLCJPHHDJM)
	{
		isActor = BFLCJPHHDJM;
		BobNPC bobNPC = BobNPC.BNDNMBGJEKP();
		bobNPC.ConversationStarted = (Action<bool>)Delegate.Remove(bobNPC.ConversationStarted, new Action<bool>(GGCPJPIIOKI));
		if (isActor)
		{
			CJODOOFLLLB = BobNPC.POINNCPMEIG().EHHOHCPHAAO;
			StartEvent(isActor, CDPAMNIPPEC: false);
		}
	}

	private IEnumerator AHJHIPCOLIM()
	{
		return new NNHLBCGNEOA(1)
		{
			_003C_003E4__this = this
		};
	}

	private void ILILDBHCMGK(bool BFLCJPHHDJM)
	{
		isActor = BFLCJPHHDJM;
		BobNPC bobNPC = BobNPC.GGFJGHHHEJC;
		bobNPC.ConversationStarted = (Action<bool>)Delegate.Remove(bobNPC.ConversationStarted, new Action<bool>(GGBCFKJBDGE));
		if (isActor)
		{
			CJODOOFLLLB = BobNPC.OFLELHKKNKC().EHHOHCPHAAO;
			StartEvent(isActor, CDPAMNIPPEC: false);
		}
	}

	private void FJFCPIPAGLK(bool BFLCJPHHDJM)
	{
		isActor = BFLCJPHHDJM;
		BobNPC bobNPC = BobNPC.LDBJELPPBAI();
		bobNPC.ConversationStarted = (Action<bool>)Delegate.Remove(bobNPC.ConversationStarted, new Action<bool>(GGCPJPIIOKI));
		if (isActor)
		{
			CJODOOFLLLB = BobNPC.OPDKAPNDBJE().EHHOHCPHAAO;
			StartEvent(isActor, CDPAMNIPPEC: true);
		}
	}

	private IEnumerator OPOFKHLOGFE()
	{
		if (OnlineManager.MasterOrOffline())
		{
			BobNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(bobMovePosition.position), Direction.Down, AMEOKNOLILB: true);
		}
		BobNPC.GGFJGHHHEJC.playerCanInteract = false;
		HotBathEvent.instance.ActivateEvent();
		yield return CommonReferences.wait2;
		if (instance.isActor)
		{
			DialogueCameraTarget.GetPlayer(BobNPC.GGFJGHHHEJC.EHHOHCPHAAO).ReturnControlToCameraTarget();
			PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		}
		MissionsManager.instance.StartMission(325, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		while (Utils.NGLLIJPOBEC(Location.Farm))
		{
			yield return null;
		}
		yield return CommonReferences.wait5;
		Debug.Log((object)"RoadBlockedEvent: Bob goes to farm");
		((Component)BobNPC.GGFJGHHHEJC).transform.position = bobFarmPosition.position;
		BobNPC.GGFJGHHHEJC.content.SetActive(true);
		((Behaviour)BobNPC.GGFJGHHHEJC.bobAnim).enabled = true;
		BobNPC.GGFJGHHHEJC.playerCanInteract = true;
	}

	private IEnumerator GLKHNENPAIA()
	{
		if (OnlineManager.MasterOrOffline())
		{
			BobNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(bobMovePosition.position), Direction.Down, AMEOKNOLILB: true);
		}
		BobNPC.GGFJGHHHEJC.playerCanInteract = false;
		HotBathEvent.instance.ActivateEvent();
		yield return CommonReferences.wait2;
		if (instance.isActor)
		{
			DialogueCameraTarget.GetPlayer(BobNPC.GGFJGHHHEJC.EHHOHCPHAAO).ReturnControlToCameraTarget();
			PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		}
		MissionsManager.instance.StartMission(325, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		while (Utils.NGLLIJPOBEC(Location.Farm))
		{
			yield return null;
		}
		yield return CommonReferences.wait5;
		Debug.Log((object)"RoadBlockedEvent: Bob goes to farm");
		((Component)BobNPC.GGFJGHHHEJC).transform.position = bobFarmPosition.position;
		BobNPC.GGFJGHHHEJC.content.SetActive(true);
		((Behaviour)BobNPC.GGFJGHHHEJC.bobAnim).enabled = true;
		BobNPC.GGFJGHHHEJC.playerCanInteract = true;
	}

	private IEnumerator BDLKIJAAMLM()
	{
		return new AIMKFBHLLCG(1);
	}

	private IEnumerator GHLNBIIJJGI()
	{
		BobNPC.GGFJGHHHEJC.animationBase.SetBool("Sleep", EGFGNGJGBOP: false, HALNIEBONKH: true);
		yield return CommonReferences.wait1;
		instance.EDGDFPPKGDL = BobNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "RoadBlocked/Main 2";
		BobNPC.GGFJGHHHEJC.blockActionBar = false;
		BobNPC.GGFJGHHHEJC.inSpecialEvent = false;
		BobNPC.GGFJGHHHEJC.dialogueActor.actor = "Bob";
		BobNPC.GGFJGHHHEJC.dialogueActor.spritePortrait = BobNPC.GGFJGHHHEJC.bobPortrait;
		if (instance.isActor)
		{
			BobNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "RoadBlocked/Main 2");
		}
	}

	public void IEBFCBPJFGP()
	{
		((MonoBehaviour)instance).StartCoroutine(FANGJJOFJNG());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendAwakeBob();
		}
	}

	public void NIJKKHENLAH()
	{
		PlayerInventory.NEKDDPIAOBE(BobNPC.OPDKAPNDBJE().EHHOHCPHAAO, LAGHIOKLJGH: true).AddItem(ItemDatabaseAccessor.COEFFIHKMJG(186).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
	}

	private IEnumerator PJFDJMBOHPO()
	{
		if (OnlineManager.MasterOrOffline())
		{
			BobNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(bobMovePosition.position), Direction.Down, AMEOKNOLILB: true);
		}
		BobNPC.GGFJGHHHEJC.playerCanInteract = false;
		HotBathEvent.instance.ActivateEvent();
		yield return CommonReferences.wait2;
		if (instance.isActor)
		{
			DialogueCameraTarget.GetPlayer(BobNPC.GGFJGHHHEJC.EHHOHCPHAAO).ReturnControlToCameraTarget();
			PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		}
		MissionsManager.instance.StartMission(325, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		while (Utils.NGLLIJPOBEC(Location.Farm))
		{
			yield return null;
		}
		yield return CommonReferences.wait5;
		Debug.Log((object)"RoadBlockedEvent: Bob goes to farm");
		((Component)BobNPC.GGFJGHHHEJC).transform.position = bobFarmPosition.position;
		BobNPC.GGFJGHHHEJC.content.SetActive(true);
		((Behaviour)BobNPC.GGFJGHHHEJC.bobAnim).enabled = true;
		BobNPC.GGFJGHHHEJC.playerCanInteract = true;
	}

	public void NBAJMCMGGJD()
	{
		PlayerInventory.EIFPKCAFDIB(BobNPC.EJHDHCNILDH().EHHOHCPHAAO, LAGHIOKLJGH: true).AddItem(ItemDatabaseAccessor.COEFFIHKMJG(-59, GGBBJNBBLMF: true).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: false);
	}

	public void IBMJPKIHHNN()
	{
		((MonoBehaviour)instance).StartCoroutine(GHLNBIIJJGI());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendAwakeBob();
		}
	}

	public void DOKJFNBPLGP()
	{
		((MonoBehaviour)instance).StartCoroutine(IHAOHCCCIPE());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendAwakeBob();
		}
	}

	public void CKBLEKACJFL()
	{
		PlayerInventory.OGKNJNINGMH(BobNPC.BNDNMBGJEKP().EHHOHCPHAAO, LAGHIOKLJGH: true, ADPNMHGBFKG: true).OJDGOADOCMG(ItemDatabaseAccessor.GOKIDLOELKB(108, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: false, EHGHJNOFMKF: false, APBCMCOAFDM: false);
	}

	public void KCANLAMPHFA()
	{
		PlayerInventory.NEKDDPIAOBE(BobNPC.OFLELHKKNKC().EHHOHCPHAAO, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AddItem(ItemDatabaseAccessor.GetItem(190).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false, EHGHJNOFMKF: false);
	}

	private void NLNDMDEEJDB(bool BFLCJPHHDJM)
	{
		isActor = BFLCJPHHDJM;
		BobNPC bobNPC = BobNPC.LDBJELPPBAI();
		bobNPC.ConversationStarted = (Action<bool>)Delegate.Remove(bobNPC.ConversationStarted, new Action<bool>(KJJPHJKEAHB));
		if (isActor)
		{
			CJODOOFLLLB = BobNPC.OPDKAPNDBJE().EHHOHCPHAAO;
			StartEvent(isActor, CDPAMNIPPEC: true);
		}
	}

	private void OKFAAKBNLEG(bool BFLCJPHHDJM)
	{
		isActor = BFLCJPHHDJM;
		BobNPC bobNPC = BobNPC.OPDKAPNDBJE();
		bobNPC.ConversationStarted = (Action<bool>)Delegate.Remove(bobNPC.ConversationStarted, new Action<bool>(OKFAAKBNLEG));
		if (isActor)
		{
			CJODOOFLLLB = BobNPC.EJHDHCNILDH().EHHOHCPHAAO;
			StartEvent(isActor, CDPAMNIPPEC: false);
		}
	}

	public void CADBIEMGCOO()
	{
		PlayerInventory.OGKNJNINGMH(BobNPC.LDBJELPPBAI().EHHOHCPHAAO, LAGHIOKLJGH: true).OJDGOADOCMG(ItemDatabaseAccessor.INJBNHPGCIJ(182, GGBBJNBBLMF: true).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: false);
	}

	public void INAIMBKKFKD()
	{
		PlayerInventory.OGKNJNINGMH(BobNPC.OPDKAPNDBJE().EHHOHCPHAAO, LAGHIOKLJGH: true).OJDGOADOCMG(ItemDatabaseAccessor.AFOACBIHNCL(-19, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: false);
	}

	private IEnumerator DKMKMLBLFJP()
	{
		return new AIMKFBHLLCG(1);
	}

	private void EBCLCPEJMPE(bool BFLCJPHHDJM)
	{
		isActor = BFLCJPHHDJM;
		BobNPC bobNPC = BobNPC.OPDKAPNDBJE();
		bobNPC.ConversationStarted = (Action<bool>)Delegate.Remove(bobNPC.ConversationStarted, new Action<bool>(MEMENIIFOEC));
		if (isActor)
		{
			CJODOOFLLLB = BobNPC.DFJGHOHPPEL().EHHOHCPHAAO;
			StartEvent(isActor, CDPAMNIPPEC: true);
		}
	}

	private IEnumerator IDEDHJPCJHL()
	{
		BobNPC.GGFJGHHHEJC.animationBase.SetBool("Sleep", EGFGNGJGBOP: false, HALNIEBONKH: true);
		yield return CommonReferences.wait1;
		instance.EDGDFPPKGDL = BobNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "RoadBlocked/Main 2";
		BobNPC.GGFJGHHHEJC.blockActionBar = false;
		BobNPC.GGFJGHHHEJC.inSpecialEvent = false;
		BobNPC.GGFJGHHHEJC.dialogueActor.actor = "Bob";
		BobNPC.GGFJGHHHEJC.dialogueActor.spritePortrait = BobNPC.GGFJGHHHEJC.bobPortrait;
		if (instance.isActor)
		{
			BobNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "RoadBlocked/Main 2");
		}
	}

	private void IBOFKHNIPAE(bool BFLCJPHHDJM)
	{
		isActor = BFLCJPHHDJM;
		BobNPC bobNPC = BobNPC.DFJGHOHPPEL();
		bobNPC.ConversationStarted = (Action<bool>)Delegate.Remove(bobNPC.ConversationStarted, new Action<bool>(MIIJELDFCJG));
		if (isActor)
		{
			CJODOOFLLLB = BobNPC.GGFJGHHHEJC.EHHOHCPHAAO;
			StartEvent(isActor, CDPAMNIPPEC: true);
		}
	}

	public void AwakeBob()
	{
		((MonoBehaviour)instance).StartCoroutine(GJJDLLBFFMG());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendAwakeBob();
		}
	}

	private void JMOJBJHIGLC(bool BFLCJPHHDJM)
	{
		isActor = BFLCJPHHDJM;
		BobNPC bobNPC = BobNPC.BNDNMBGJEKP();
		bobNPC.ConversationStarted = (Action<bool>)Delegate.Remove(bobNPC.ConversationStarted, new Action<bool>(GGBCFKJBDGE));
		if (isActor)
		{
			CJODOOFLLLB = BobNPC.OPDKAPNDBJE().EHHOHCPHAAO;
			StartEvent(isActor, CDPAMNIPPEC: false);
		}
	}

	public void ABOHCNFPHKD()
	{
		((MonoBehaviour)instance).StartCoroutine(FIFNJCOCCJM());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendAwakeBob();
		}
	}

	public void AGEJLPMAKCL()
	{
		PlayerInventory.GetPlayer(BobNPC.GGFJGHHHEJC.EHHOHCPHAAO, LAGHIOKLJGH: true).AddItem(ItemDatabaseAccessor.EABMGELAAPG(178, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false, EHGHJNOFMKF: false, APBCMCOAFDM: false);
	}

	private IEnumerator EKKHDGIIPJD()
	{
		BobNPC.GGFJGHHHEJC.animationBase.SetBool("Sleep", EGFGNGJGBOP: false, HALNIEBONKH: true);
		yield return CommonReferences.wait1;
		instance.EDGDFPPKGDL = BobNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "RoadBlocked/Main 2";
		BobNPC.GGFJGHHHEJC.blockActionBar = false;
		BobNPC.GGFJGHHHEJC.inSpecialEvent = false;
		BobNPC.GGFJGHHHEJC.dialogueActor.actor = "Bob";
		BobNPC.GGFJGHHHEJC.dialogueActor.spritePortrait = BobNPC.GGFJGHHHEJC.bobPortrait;
		if (instance.isActor)
		{
			BobNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "RoadBlocked/Main 2");
		}
	}

	private void MEMENIIFOEC(bool BFLCJPHHDJM)
	{
		isActor = BFLCJPHHDJM;
		BobNPC bobNPC = BobNPC.GGFJGHHHEJC;
		bobNPC.ConversationStarted = (Action<bool>)Delegate.Remove(bobNPC.ConversationStarted, new Action<bool>(LEEHOCDOLKE));
		if (isActor)
		{
			CJODOOFLLLB = BobNPC.DFJGHOHPPEL().EHHOHCPHAAO;
			StartEvent(isActor, CDPAMNIPPEC: false);
		}
	}

	private void MNAPHNEMCHI(bool BFLCJPHHDJM)
	{
		isActor = BFLCJPHHDJM;
		BobNPC bobNPC = BobNPC.OFLELHKKNKC();
		bobNPC.ConversationStarted = (Action<bool>)Delegate.Remove(bobNPC.ConversationStarted, new Action<bool>(MEMENIIFOEC));
		if (isActor)
		{
			CJODOOFLLLB = BobNPC.EJHDHCNILDH().EHHOHCPHAAO;
			StartEvent(isActor, CDPAMNIPPEC: false);
		}
	}

	public void DALJJNGOOEO()
	{
		PlayerInventory.NEKDDPIAOBE(BobNPC.BNDNMBGJEKP().EHHOHCPHAAO, LAGHIOKLJGH: true).AddItem(ItemDatabaseAccessor.AFOACBIHNCL(-133, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
	}

	private IEnumerator FCOEDNBAHBH()
	{
		return new NNHLBCGNEOA(1)
		{
			_003C_003E4__this = this
		};
	}

	public override GameEvent GetInstance()
	{
		return instance;
	}

	public void BOIDIEFICAN()
	{
		((MonoBehaviour)instance).StartCoroutine(LEMPPIOKNLM());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendAwakeBob();
		}
	}

	public void JHECNKHPCKP()
	{
		((MonoBehaviour)instance).StartCoroutine(BDLKIJAAMLM());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.EAOBJJDKPKO();
		}
	}

	private IEnumerator HEGPAHPFAOM()
	{
		if (OnlineManager.MasterOrOffline())
		{
			BobNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(bobMovePosition.position), Direction.Down, AMEOKNOLILB: true);
		}
		BobNPC.GGFJGHHHEJC.playerCanInteract = false;
		HotBathEvent.instance.ActivateEvent();
		yield return CommonReferences.wait2;
		if (instance.isActor)
		{
			DialogueCameraTarget.GetPlayer(BobNPC.GGFJGHHHEJC.EHHOHCPHAAO).ReturnControlToCameraTarget();
			PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		}
		MissionsManager.instance.StartMission(325, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		while (Utils.NGLLIJPOBEC(Location.Farm))
		{
			yield return null;
		}
		yield return CommonReferences.wait5;
		Debug.Log((object)"RoadBlockedEvent: Bob goes to farm");
		((Component)BobNPC.GGFJGHHHEJC).transform.position = bobFarmPosition.position;
		BobNPC.GGFJGHHHEJC.content.SetActive(true);
		((Behaviour)BobNPC.GGFJGHHHEJC.bobAnim).enabled = true;
		BobNPC.GGFJGHHHEJC.playerCanInteract = true;
	}

	private IEnumerator CIOFCNDNJIE()
	{
		return new AIMKFBHLLCG(1);
	}

	public void AAMGJPPCAGD()
	{
		PlayerInventory.EIFPKCAFDIB(BobNPC.OFLELHKKNKC().EHHOHCPHAAO, LAGHIOKLJGH: true, ADPNMHGBFKG: true).OJDGOADOCMG(ItemDatabaseAccessor.GetItem(95).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: false, EHGHJNOFMKF: false);
	}

	public void BHEJGNNECCO()
	{
		((MonoBehaviour)instance).StartCoroutine(FIFNJCOCCJM());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendAwakeBob();
		}
	}

	private IEnumerator HCMDPMNBDFO()
	{
		return new NNHLBCGNEOA(1)
		{
			_003C_003E4__this = this
		};
	}

	private void AEEHFGIDCMJ(bool BFLCJPHHDJM)
	{
		isActor = BFLCJPHHDJM;
		BobNPC bobNPC = BobNPC.GGFJGHHHEJC;
		bobNPC.ConversationStarted = (Action<bool>)Delegate.Remove(bobNPC.ConversationStarted, new Action<bool>(AEEHFGIDCMJ));
		if (isActor)
		{
			CJODOOFLLLB = BobNPC.GGFJGHHHEJC.EHHOHCPHAAO;
			StartEvent(isActor, CDPAMNIPPEC: true);
		}
	}

	public void JIKGLAPGOPA()
	{
		PlayerInventory.NEKDDPIAOBE(BobNPC.LDBJELPPBAI().EHHOHCPHAAO, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AddItem(ItemDatabaseAccessor.INJBNHPGCIJ(-55, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: true);
	}

	public override void ActivateEvent()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		base.ActivateEvent();
		BobNPC bobNPC = BobNPC.GGFJGHHHEJC;
		bobNPC.ConversationStarted = (Action<bool>)Delegate.Combine(bobNPC.ConversationStarted, new Action<bool>(AEEHFGIDCMJ));
		((Behaviour)BobNPC.GGFJGHHHEJC.bobAnim).enabled = false;
		((Component)BobNPC.GGFJGHHHEJC).transform.position = bobPosition.position;
		BobNPC.GGFJGHHHEJC.content.SetActive(true);
		BobNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		BobNPC.GGFJGHHHEJC.animationBase.SetBool("Sleep", EGFGNGJGBOP: true, HALNIEBONKH: true);
		BobNPC.GGFJGHHHEJC.CheckExclamationSendOnline(sendOnline: true);
		BobNPC.GGFJGHHHEJC.dialogueActor.actor = "???";
		BobNPC.GGFJGHHHEJC.dialogueActor.spritePortrait = BobNPC.GGFJGHHHEJC.blackPortrait;
	}

	private void AGOAIEKLONA(bool BFLCJPHHDJM)
	{
		isActor = BFLCJPHHDJM;
		BobNPC bobNPC = BobNPC.EJHDHCNILDH();
		bobNPC.ConversationStarted = (Action<bool>)Delegate.Remove(bobNPC.ConversationStarted, new Action<bool>(KJKPIKCPAPN));
		if (isActor)
		{
			CJODOOFLLLB = BobNPC.EJHDHCNILDH().EHHOHCPHAAO;
			StartEvent(isActor, CDPAMNIPPEC: true);
		}
	}

	public void LPGBIBFDMEI()
	{
		PlayerInventory.NEKDDPIAOBE(BobNPC.LDBJELPPBAI().EHHOHCPHAAO).OJDGOADOCMG(ItemDatabaseAccessor.GetItem(-8, GGBBJNBBLMF: true).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
	}

	private void EAOHKIIFDNB(bool BFLCJPHHDJM)
	{
		isActor = BFLCJPHHDJM;
		BobNPC bobNPC = BobNPC.EJHDHCNILDH();
		bobNPC.ConversationStarted = (Action<bool>)Delegate.Remove(bobNPC.ConversationStarted, new Action<bool>(LEEHOCDOLKE));
		if (isActor)
		{
			CJODOOFLLLB = BobNPC.DFJGHOHPPEL().EHHOHCPHAAO;
			StartEvent(isActor, CDPAMNIPPEC: true);
		}
	}

	private IEnumerator IHAOHCCCIPE()
	{
		return new AIMKFBHLLCG(1);
	}

	public void HCDCIEPKPEK()
	{
		((MonoBehaviour)instance).StartCoroutine(EKKHDGIIPJD());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendAwakeBob();
		}
	}

	public void MMEIMCLEDNC()
	{
		((MonoBehaviour)instance).StartCoroutine(BDLKIJAAMLM());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.EAOBJJDKPKO();
		}
	}

	private IEnumerator PPKFJNCCFLH()
	{
		if (OnlineManager.MasterOrOffline())
		{
			BobNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(bobMovePosition.position), Direction.Down, AMEOKNOLILB: true);
		}
		BobNPC.GGFJGHHHEJC.playerCanInteract = false;
		HotBathEvent.instance.ActivateEvent();
		yield return CommonReferences.wait2;
		if (instance.isActor)
		{
			DialogueCameraTarget.GetPlayer(BobNPC.GGFJGHHHEJC.EHHOHCPHAAO).ReturnControlToCameraTarget();
			PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		}
		MissionsManager.instance.StartMission(325, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		while (Utils.NGLLIJPOBEC(Location.Farm))
		{
			yield return null;
		}
		yield return CommonReferences.wait5;
		Debug.Log((object)"RoadBlockedEvent: Bob goes to farm");
		((Component)BobNPC.GGFJGHHHEJC).transform.position = bobFarmPosition.position;
		BobNPC.GGFJGHHHEJC.content.SetActive(true);
		((Behaviour)BobNPC.GGFJGHHHEJC.bobAnim).enabled = true;
		BobNPC.GGFJGHHHEJC.playerCanInteract = true;
	}

	private IEnumerator HPGJAIBIBEO()
	{
		BobNPC.GGFJGHHHEJC.animationBase.SetBool("Sleep", EGFGNGJGBOP: false, HALNIEBONKH: true);
		yield return CommonReferences.wait1;
		instance.EDGDFPPKGDL = BobNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "RoadBlocked/Main 2";
		BobNPC.GGFJGHHHEJC.blockActionBar = false;
		BobNPC.GGFJGHHHEJC.inSpecialEvent = false;
		BobNPC.GGFJGHHHEJC.dialogueActor.actor = "Bob";
		BobNPC.GGFJGHHHEJC.dialogueActor.spritePortrait = BobNPC.GGFJGHHHEJC.bobPortrait;
		if (instance.isActor)
		{
			BobNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "RoadBlocked/Main 2");
		}
	}

	private IEnumerator LMILMCMMIBM()
	{
		return new NNHLBCGNEOA(1)
		{
			_003C_003E4__this = this
		};
	}

	public void GDKBHIJLHEH()
	{
		((MonoBehaviour)instance).StartCoroutine(GJJDLLBFFMG());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.EAOBJJDKPKO();
		}
	}

	private IEnumerator GJJDLLBFFMG()
	{
		BobNPC.GGFJGHHHEJC.animationBase.SetBool("Sleep", EGFGNGJGBOP: false, HALNIEBONKH: true);
		yield return CommonReferences.wait1;
		instance.EDGDFPPKGDL = BobNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "RoadBlocked/Main 2";
		BobNPC.GGFJGHHHEJC.blockActionBar = false;
		BobNPC.GGFJGHHHEJC.inSpecialEvent = false;
		BobNPC.GGFJGHHHEJC.dialogueActor.actor = "Bob";
		BobNPC.GGFJGHHHEJC.dialogueActor.spritePortrait = BobNPC.GGFJGHHHEJC.bobPortrait;
		if (instance.isActor)
		{
			BobNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "RoadBlocked/Main 2");
		}
	}

	public void NKFFPKFAMGA()
	{
		((MonoBehaviour)instance).StartCoroutine(EKKHDGIIPJD());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.EAOBJJDKPKO();
		}
	}

	private void AKCCIOHLHIE(bool BFLCJPHHDJM)
	{
		isActor = BFLCJPHHDJM;
		BobNPC bobNPC = BobNPC.EJHDHCNILDH();
		bobNPC.ConversationStarted = (Action<bool>)Delegate.Remove(bobNPC.ConversationStarted, new Action<bool>(PHENEPGPJKO));
		if (isActor)
		{
			CJODOOFLLLB = BobNPC.BNDNMBGJEKP().EHHOHCPHAAO;
			StartEvent(isActor, CDPAMNIPPEC: true);
		}
	}

	public void DNHNKAECBNN()
	{
		((MonoBehaviour)instance).StartCoroutine(CIIDOFFBFKF());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendAwakeBob();
		}
	}

	private IEnumerator KDKMHBNNHKE()
	{
		return new NNHLBCGNEOA(1)
		{
			_003C_003E4__this = this
		};
	}

	public void JBACFPKFNAM()
	{
		PlayerInventory.EIFPKCAFDIB(BobNPC.OPDKAPNDBJE().EHHOHCPHAAO, LAGHIOKLJGH: false, ADPNMHGBFKG: true).AddItem(ItemDatabaseAccessor.CPMMBEPEJLO(-59, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: false);
	}

	public void JCAKJHBEMGE()
	{
		((MonoBehaviour)instance).StartCoroutine(BDLKIJAAMLM());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendAwakeBob();
		}
	}

	private IEnumerator FIFNJCOCCJM()
	{
		return new AIMKFBHLLCG(1);
	}

	private void FCKNCJKEJPP(bool BFLCJPHHDJM)
	{
		isActor = BFLCJPHHDJM;
		BobNPC bobNPC = BobNPC.POINNCPMEIG();
		bobNPC.ConversationStarted = (Action<bool>)Delegate.Remove(bobNPC.ConversationStarted, new Action<bool>(OCADBOKNLLO));
		if (isActor)
		{
			CJODOOFLLLB = BobNPC.OFLELHKKNKC().EHHOHCPHAAO;
			StartEvent(isActor, CDPAMNIPPEC: true);
		}
	}

	private IEnumerator IFMABNFAEMF()
	{
		return new AIMKFBHLLCG(1);
	}

	public void IEIFLAPEONM()
	{
		PlayerInventory.NEKDDPIAOBE(BobNPC.BNDNMBGJEKP().EHHOHCPHAAO).OJDGOADOCMG(ItemDatabaseAccessor.INJBNHPGCIJ(-28, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: false, EHGHJNOFMKF: true, APBCMCOAFDM: false);
	}

	private void JEPFLPOFAKE(bool BFLCJPHHDJM)
	{
		isActor = BFLCJPHHDJM;
		BobNPC bobNPC = BobNPC.EJHDHCNILDH();
		bobNPC.ConversationStarted = (Action<bool>)Delegate.Remove(bobNPC.ConversationStarted, new Action<bool>(GGCPJPIIOKI));
		if (isActor)
		{
			CJODOOFLLLB = BobNPC.GGFJGHHHEJC.EHHOHCPHAAO;
			StartEvent(isActor, CDPAMNIPPEC: false);
		}
	}

	private IEnumerator KFDFLDMJFAI()
	{
		return new NNHLBCGNEOA(1)
		{
			_003C_003E4__this = this
		};
	}

	public void POAGJAHLKHN()
	{
		((MonoBehaviour)instance).StartCoroutine(LEMPPIOKNLM());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendAwakeBob();
		}
	}

	private IEnumerator HPKLJPOBLPK()
	{
		return new NNHLBCGNEOA(1)
		{
			_003C_003E4__this = this
		};
	}

	private void MIIJELDFCJG(bool BFLCJPHHDJM)
	{
		isActor = BFLCJPHHDJM;
		BobNPC bobNPC = BobNPC.POINNCPMEIG();
		bobNPC.ConversationStarted = (Action<bool>)Delegate.Remove(bobNPC.ConversationStarted, new Action<bool>(LEEHOCDOLKE));
		if (isActor)
		{
			CJODOOFLLLB = BobNPC.DFJGHOHPPEL().EHHOHCPHAAO;
			StartEvent(isActor, CDPAMNIPPEC: true);
		}
	}

	private IEnumerator LJABJLDHLCB()
	{
		if (OnlineManager.MasterOrOffline())
		{
			BobNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(bobMovePosition.position), Direction.Down, AMEOKNOLILB: true);
		}
		BobNPC.GGFJGHHHEJC.playerCanInteract = false;
		HotBathEvent.instance.ActivateEvent();
		yield return CommonReferences.wait2;
		if (instance.isActor)
		{
			DialogueCameraTarget.GetPlayer(BobNPC.GGFJGHHHEJC.EHHOHCPHAAO).ReturnControlToCameraTarget();
			PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		}
		MissionsManager.instance.StartMission(325, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		while (Utils.NGLLIJPOBEC(Location.Farm))
		{
			yield return null;
		}
		yield return CommonReferences.wait5;
		Debug.Log((object)"RoadBlockedEvent: Bob goes to farm");
		((Component)BobNPC.GGFJGHHHEJC).transform.position = bobFarmPosition.position;
		BobNPC.GGFJGHHHEJC.content.SetActive(true);
		((Behaviour)BobNPC.GGFJGHHHEJC.bobAnim).enabled = true;
		BobNPC.GGFJGHHHEJC.playerCanInteract = true;
	}

	public void MLCKNEEHECD()
	{
		PlayerInventory.OGKNJNINGMH(BobNPC.BNDNMBGJEKP().EHHOHCPHAAO).OJDGOADOCMG(ItemDatabaseAccessor.INJBNHPGCIJ(-45, GGBBJNBBLMF: false, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
	}

	public void OCANLABDDKA()
	{
		PlayerInventory.OGKNJNINGMH(BobNPC.BNDNMBGJEKP().EHHOHCPHAAO, LAGHIOKLJGH: true).AddItem(ItemDatabaseAccessor.COEFFIHKMJG(-77).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: false);
	}

	private void OCADBOKNLLO(bool BFLCJPHHDJM)
	{
		isActor = BFLCJPHHDJM;
		BobNPC bobNPC = BobNPC.POINNCPMEIG();
		bobNPC.ConversationStarted = (Action<bool>)Delegate.Remove(bobNPC.ConversationStarted, new Action<bool>(NLNDMDEEJDB));
		if (isActor)
		{
			CJODOOFLLLB = BobNPC.POINNCPMEIG().EHHOHCPHAAO;
			StartEvent(isActor, CDPAMNIPPEC: true);
		}
	}

	private IEnumerator BIOHCFLNMAF()
	{
		if (OnlineManager.MasterOrOffline())
		{
			BobNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(bobMovePosition.position), Direction.Down, AMEOKNOLILB: true);
		}
		BobNPC.GGFJGHHHEJC.playerCanInteract = false;
		HotBathEvent.instance.ActivateEvent();
		yield return CommonReferences.wait2;
		if (instance.isActor)
		{
			DialogueCameraTarget.GetPlayer(BobNPC.GGFJGHHHEJC.EHHOHCPHAAO).ReturnControlToCameraTarget();
			PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		}
		MissionsManager.instance.StartMission(325, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		while (Utils.NGLLIJPOBEC(Location.Farm))
		{
			yield return null;
		}
		yield return CommonReferences.wait5;
		Debug.Log((object)"RoadBlockedEvent: Bob goes to farm");
		((Component)BobNPC.GGFJGHHHEJC).transform.position = bobFarmPosition.position;
		BobNPC.GGFJGHHHEJC.content.SetActive(true);
		((Behaviour)BobNPC.GGFJGHHHEJC.bobAnim).enabled = true;
		BobNPC.GGFJGHHHEJC.playerCanInteract = true;
	}

	public void NADCPGADIIA()
	{
		PlayerInventory.GetPlayer(BobNPC.OPDKAPNDBJE().EHHOHCPHAAO, LAGHIOKLJGH: true, ADPNMHGBFKG: true).OJDGOADOCMG(ItemDatabaseAccessor.COEFFIHKMJG(-96).JMDALJBNFML(), HMPDLIPFBGD: true, OJKJLIPNHOI: true, EHGHJNOFMKF: false, APBCMCOAFDM: false);
	}

	private void GGCPJPIIOKI(bool BFLCJPHHDJM)
	{
		isActor = BFLCJPHHDJM;
		BobNPC bobNPC = BobNPC.GGFJGHHHEJC;
		bobNPC.ConversationStarted = (Action<bool>)Delegate.Remove(bobNPC.ConversationStarted, new Action<bool>(LEEHOCDOLKE));
		if (isActor)
		{
			CJODOOFLLLB = BobNPC.GGFJGHHHEJC.EHHOHCPHAAO;
			StartEvent(isActor, CDPAMNIPPEC: false);
		}
	}

	private IEnumerator JPFHDKPIJFI()
	{
		return new AIMKFBHLLCG(1);
	}

	private IEnumerator OIKDONLFAIL()
	{
		if (OnlineManager.MasterOrOffline())
		{
			BobNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(bobMovePosition.position), Direction.Down, AMEOKNOLILB: true);
		}
		BobNPC.GGFJGHHHEJC.playerCanInteract = false;
		HotBathEvent.instance.ActivateEvent();
		yield return CommonReferences.wait2;
		if (instance.isActor)
		{
			DialogueCameraTarget.GetPlayer(BobNPC.GGFJGHHHEJC.EHHOHCPHAAO).ReturnControlToCameraTarget();
			PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		}
		MissionsManager.instance.StartMission(325, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		while (Utils.NGLLIJPOBEC(Location.Farm))
		{
			yield return null;
		}
		yield return CommonReferences.wait5;
		Debug.Log((object)"RoadBlockedEvent: Bob goes to farm");
		((Component)BobNPC.GGFJGHHHEJC).transform.position = bobFarmPosition.position;
		BobNPC.GGFJGHHHEJC.content.SetActive(true);
		((Behaviour)BobNPC.GGFJGHHHEJC.bobAnim).enabled = true;
		BobNPC.GGFJGHHHEJC.playerCanInteract = true;
	}

	public override void StartEvent(bool GFNHAMCPEAK, bool CDPAMNIPPEC)
	{
		base.StartEvent(GFNHAMCPEAK, CDPAMNIPPEC);
		if (instance.isActor)
		{
			PCPDOOPJCKE(CJODOOFLLLB);
			PlayerInputs.DisableKeyboardInputsAndMovement(CJODOOFLLLB, (MonoBehaviour)(object)instance);
		}
		if (instance.isActor)
		{
			BobNPC.GGFJGHHHEJC.blockActionBar = true;
			BobNPC.GGFJGHHHEJC.inSpecialEvent = true;
		}
		EDGDFPPKGDL = BobNPC.GGFJGHHHEJC;
		MDFALJKHKED = "RoadBlocked/Main";
	}

	private IEnumerator KCDPOBJCCOI()
	{
		return new NNHLBCGNEOA(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LCHCJEKLAKL()
	{
		return new NNHLBCGNEOA(1)
		{
			_003C_003E4__this = this
		};
	}

	public void JIPNNCCODIG()
	{
		PlayerInventory.EIFPKCAFDIB(BobNPC.OPDKAPNDBJE().EHHOHCPHAAO, LAGHIOKLJGH: false, ADPNMHGBFKG: true).OJDGOADOCMG(ItemDatabaseAccessor.GetItem(107, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML());
	}

	private IEnumerator LEMPPIOKNLM()
	{
		BobNPC.GGFJGHHHEJC.animationBase.SetBool("Sleep", EGFGNGJGBOP: false, HALNIEBONKH: true);
		yield return CommonReferences.wait1;
		instance.EDGDFPPKGDL = BobNPC.GGFJGHHHEJC;
		instance.MDFALJKHKED = "RoadBlocked/Main 2";
		BobNPC.GGFJGHHHEJC.blockActionBar = false;
		BobNPC.GGFJGHHHEJC.inSpecialEvent = false;
		BobNPC.GGFJGHHHEJC.dialogueActor.actor = "Bob";
		BobNPC.GGFJGHHHEJC.dialogueActor.spritePortrait = BobNPC.GGFJGHHHEJC.bobPortrait;
		if (instance.isActor)
		{
			BobNPC.GGFJGHHHEJC.StartConversation(instance.CJODOOFLLLB, "RoadBlocked/Main 2");
		}
	}

	private IEnumerator LMAJILHIHJM()
	{
		if (OnlineManager.MasterOrOffline())
		{
			BobNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(bobMovePosition.position), Direction.Down, AMEOKNOLILB: true);
		}
		BobNPC.GGFJGHHHEJC.playerCanInteract = false;
		HotBathEvent.instance.ActivateEvent();
		yield return CommonReferences.wait2;
		if (instance.isActor)
		{
			DialogueCameraTarget.GetPlayer(BobNPC.GGFJGHHHEJC.EHHOHCPHAAO).ReturnControlToCameraTarget();
			PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		}
		MissionsManager.instance.StartMission(325, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		while (Utils.NGLLIJPOBEC(Location.Farm))
		{
			yield return null;
		}
		yield return CommonReferences.wait5;
		Debug.Log((object)"RoadBlockedEvent: Bob goes to farm");
		((Component)BobNPC.GGFJGHHHEJC).transform.position = bobFarmPosition.position;
		BobNPC.GGFJGHHHEJC.content.SetActive(true);
		((Behaviour)BobNPC.GGFJGHHHEJC.bobAnim).enabled = true;
		BobNPC.GGFJGHHHEJC.playerCanInteract = true;
	}

	private void HFLHGODBFBE(bool BFLCJPHHDJM)
	{
		isActor = BFLCJPHHDJM;
		BobNPC bobNPC = BobNPC.BNDNMBGJEKP();
		bobNPC.ConversationStarted = (Action<bool>)Delegate.Remove(bobNPC.ConversationStarted, new Action<bool>(DHPGIFIKGEK));
		if (isActor)
		{
			CJODOOFLLLB = BobNPC.LDBJELPPBAI().EHHOHCPHAAO;
			StartEvent(isActor, CDPAMNIPPEC: true);
		}
	}

	public void PKKOHBLFOLM()
	{
		((MonoBehaviour)instance).StartCoroutine(MKBAPBAMIHM());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.EAOBJJDKPKO();
		}
	}

	private void ABAFFIJLPCM(bool BFLCJPHHDJM)
	{
		isActor = BFLCJPHHDJM;
		BobNPC bobNPC = BobNPC.OFLELHKKNKC();
		bobNPC.ConversationStarted = (Action<bool>)Delegate.Remove(bobNPC.ConversationStarted, new Action<bool>(COHDGLGBBNP));
		if (isActor)
		{
			CJODOOFLLLB = BobNPC.LDBJELPPBAI().EHHOHCPHAAO;
			StartEvent(isActor, CDPAMNIPPEC: false);
		}
	}

	protected override void Awake()
	{
		base.Awake();
		instance = this;
	}

	public void HAFNCJLJJIE()
	{
		((MonoBehaviour)instance).StartCoroutine(IHAOHCCCIPE());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendAwakeBob();
		}
	}

	private IEnumerator GICKHENLPAA()
	{
		if (OnlineManager.MasterOrOffline())
		{
			BobNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(bobMovePosition.position), Direction.Down, AMEOKNOLILB: true);
		}
		BobNPC.GGFJGHHHEJC.playerCanInteract = false;
		HotBathEvent.instance.ActivateEvent();
		yield return CommonReferences.wait2;
		if (instance.isActor)
		{
			DialogueCameraTarget.GetPlayer(BobNPC.GGFJGHHHEJC.EHHOHCPHAAO).ReturnControlToCameraTarget();
			PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		}
		MissionsManager.instance.StartMission(325, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		while (Utils.NGLLIJPOBEC(Location.Farm))
		{
			yield return null;
		}
		yield return CommonReferences.wait5;
		Debug.Log((object)"RoadBlockedEvent: Bob goes to farm");
		((Component)BobNPC.GGFJGHHHEJC).transform.position = bobFarmPosition.position;
		BobNPC.GGFJGHHHEJC.content.SetActive(true);
		((Behaviour)BobNPC.GGFJGHHHEJC.bobAnim).enabled = true;
		BobNPC.GGFJGHHHEJC.playerCanInteract = true;
	}

	private IEnumerator LECMDOIAHGB()
	{
		return new NNHLBCGNEOA(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator KGGLJKBEIIB()
	{
		return new AIMKFBHLLCG(1);
	}

	private IEnumerator CIIDOFFBFKF()
	{
		return new AIMKFBHLLCG(1);
	}

	private void GELGHLAPDGJ(bool BFLCJPHHDJM)
	{
		isActor = BFLCJPHHDJM;
		BobNPC bobNPC = BobNPC.LDBJELPPBAI();
		bobNPC.ConversationStarted = (Action<bool>)Delegate.Remove(bobNPC.ConversationStarted, new Action<bool>(FJFCPIPAGLK));
		if (isActor)
		{
			CJODOOFLLLB = BobNPC.GGFJGHHHEJC.EHHOHCPHAAO;
			StartEvent(isActor, CDPAMNIPPEC: false);
		}
	}

	public void JOAPLCEPKLA()
	{
		PlayerInventory.NEKDDPIAOBE(BobNPC.POINNCPMEIG().EHHOHCPHAAO, LAGHIOKLJGH: true, ADPNMHGBFKG: true).AddItem(ItemDatabaseAccessor.AFOACBIHNCL(115, GGBBJNBBLMF: true, DAINLFIMLIH: false).JMDALJBNFML(), HMPDLIPFBGD: false, OJKJLIPNHOI: true, EHGHJNOFMKF: true, APBCMCOAFDM: false);
	}

	public void CJFEBBAJHAM()
	{
		((MonoBehaviour)instance).StartCoroutine(EKKHDGIIPJD());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendAwakeBob();
		}
	}
}
