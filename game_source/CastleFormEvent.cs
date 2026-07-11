using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class CastleFormEvent : GameEvent
{
	[CompilerGenerated]
	private sealed class LBBOKMMKHAN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CastleFormEvent _003C_003E4__this;

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
		public LBBOKMMKHAN(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			CastleFormEvent castleFormEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				if (OnlineManager.MasterOrOffline())
				{
					LucenNPC.GGFJGHHHEJC.content.gameObject.SetActive(true);
					LucenNPC.GGFJGHHHEJC.Walk(new Vector2(-929.7708f, 271.2292f), Direction.Right, KEEGDBAAEOG: true);
				}
				castleFormEvent.EDGDFPPKGDL = null;
				_003C_003E2__current = CommonReferences.wait1_5;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				KlaynNPC.instance.barkDialogue = false;
				KlaynNPC.instance.mouseUpTrigger = true;
				castleFormEvent.EDGDFPPKGDL = KlaynNPC.instance;
				castleFormEvent.MDFALJKHKED = "LicenciaDeApertura/KlaynDialogue 07";
				if (castleFormEvent.isActor)
				{
					KlaynNPC.instance.barkDialogue = false;
					KlaynNPC.instance.mouseUpTrigger = true;
					KlaynNPC.instance.StartConversation(castleFormEvent.CJODOOFLLLB, castleFormEvent.MDFALJKHKED);
				}
				else if (castleFormEvent.BCBBDFLOGPP())
				{
					_003C_003E2__current = KlaynNPC.instance.StartObserverDialogueWhenItIsPossible(1);
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
	private sealed class JAFKLGPNMND : IEnumerator<object>, IEnumerator, IDisposable
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
		public JAFKLGPNMND(int _003C_003E1__state)
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
				MusicController.instance.FadeOutClip(2f, MMEHJCGGNFE: true);
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				MusicController.instance.TriggerMusicTheme(27);
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
	private sealed class JFMEKJFLHHF : IEnumerator<object>, IEnumerator, IDisposable
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
		public JFMEKJFLHHF(int _003C_003E1__state)
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
				_003C_003E2__current = CommonReferences.wait01;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				MusicController.instance.FadeOutClip(2f, MMEHJCGGNFE: true);
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				MusicController.instance.TriggerMusicTheme(28);
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
	private sealed class KNBCEIODNKK : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public CastleFormEvent _003C_003E4__this;

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
		public KNBCEIODNKK(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			CastleFormEvent castleFormEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait1_5;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				((Component)castleFormEvent.guard).gameObject.transform.position = ((Component)castleFormEvent.guard).gameObject.transform.position + new Vector3(-0.25f, 0f, 0f);
				castleFormEvent.guard.SetDirection(Direction.Right);
				_003C_003E2__current = CommonReferences.wait1_5;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				((Component)castleFormEvent.guard).gameObject.transform.position = ((Component)castleFormEvent.guard).gameObject.transform.position + new Vector3(0.25f, 0f, 0f);
				castleFormEvent.guard.SetDirection(Direction.Down);
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

	public static CastleFormEvent instance;

	public NPCAnimation guard;

	public Transform localCooperativeCameraPoint;

	public void ELBLLKEMIPD(int JIIGOACEIKL, bool GFNHAMCPEAK = true)
	{
		CJODOOFLLLB = JIIGOACEIKL;
		StartEvent(GFNHAMCPEAK, CDPAMNIPPEC: false);
	}

	private Vector2 EFEAONGJBAH()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		return Vector2.op_Implicit(((Component)TheloniusNPC.FMIDAFEGDCD()).transform.position + new Vector3((float)Random.Range(49, 4), (float)Random.Range(-44, -1)));
	}

	public void JIKLCMPCGPI()
	{
		Debug.Log((object)("Dialogue System/Conversation/AcceptRoomFirstFloor/Entry/3/Dialogue Text" + isActor));
		LucenNPC lucenNPC = LucenNPC.KPDFIEMDDCL();
		lucenNPC.WalkToCompleted = (Action)Delegate.Remove(lucenNPC.WalkToCompleted, new Action(MNBDLNGMBBN));
		LucenNPC.HEKFJEKFMNO().barkDialogue = true;
		LucenNPC.KPDFIEMDDCL().mouseUpTrigger = false;
		EDGDFPPKGDL = LucenNPC.POAGAIBEFBF();
		MDFALJKHKED = "Player2";
		if (isActor)
		{
			LucenNPC.BNBMNOMFFBE().StartConversation(CJODOOFLLLB, MDFALJKHKED);
		}
		else if (CJDGJOMACHI(0))
		{
			((MonoBehaviour)this).StartCoroutine(LucenNPC.NHKAFANMEJC().StartObserverDialogueWhenItIsPossible(0));
		}
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendCastleFormStartLucenDialogue();
		}
	}

	private IEnumerator OPEGAEMIMHK()
	{
		return new LBBOKMMKHAN(1)
		{
			_003C_003E4__this = this
		};
	}

	public void APGBLALLJCI()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		LucenNPC.IBEGPMLJIOJ().content.gameObject.SetActive(false);
		EDGDFPPKGDL = null;
		if (OnlineManager.PGAGDFAEEFB())
		{
			((Component)LucenNPC.KPDFIEMDDCL()).transform.position = Vector2.op_Implicit(new Vector2(586f, 1782f));
			LucenNPC.LPFNKEOJJKE().EJAMGJMEAEM(new Vector2(857f, 905f), Direction.Diagonal, KEEGDBAAEOG: true);
			LucenNPC lucenNPC = LucenNPC.KPDFIEMDDCL();
			lucenNPC.WalkToCompleted = (Action)Delegate.Combine(lucenNPC.WalkToCompleted, new Action(OHGGBEKIDCH));
		}
		if (isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendCastleFormStartLucenEvent();
		}
	}

	public void DFELOOCBOKC()
	{
		Debug.Log((object)("ReceiveLoadSlots" + isActor));
		LucenNPC lucenNPC = LucenNPC.MOAKANGAMBA();
		lucenNPC.WalkToCompleted = (Action)Delegate.Remove(lucenNPC.WalkToCompleted, new Action(MNBDLNGMBBN));
		LucenNPC.ELGNEJNLBNO().barkDialogue = true;
		LucenNPC.ABDJJBFNLBJ().mouseUpTrigger = true;
		EDGDFPPKGDL = LucenNPC.MOAKANGAMBA();
		MDFALJKHKED = "ReceiveRemoveItemInstanceOnTray";
		if (isActor)
		{
			LucenNPC.HEKFJEKFMNO().StartConversation(CJODOOFLLLB, MDFALJKHKED, FLHBPHPKIML: true);
		}
		else if (KECGJCLDHDM())
		{
			((MonoBehaviour)this).StartCoroutine(LucenNPC.IBEGPMLJIOJ().StartObserverDialogueWhenItIsPossible(0));
		}
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineEventsManager.SendCastleFormStartLucenDialogue();
		}
	}

	private void GLBPBGFNLLN(int JIIGOACEIKL)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(1);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(BLHCCEMDNCG));
		FadeCamera.EIFPKCAFDIB(0).FadeIn(1364f);
		PlayerController.TeleportPlayer(JIIGOACEIKL, Vector2.op_Implicit(NCPBGLOJMAG()), ~(Location.Tavern | Location.Road | Location.Camp | Location.Quarry | Location.Farm));
		DGKEOLGHLHE();
	}

	public void BAPDNHJKFDC(int JIIGOACEIKL)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)("Winner" + JIIGOACEIKL));
		PlayerController.SetDirection(JIIGOACEIKL, Utils.EIDFHLPBICI(Vector2.op_Implicit(localCooperativeCameraPoint.position - ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position)));
		PlayerInputs.LPJCFCODNFA(JIIGOACEIKL, (MonoBehaviour)(object)this);
		CameraTarget.IEGOEFNIKLJ(JIIGOACEIKL, localCooperativeCameraPoint);
	}

	private void DJNEMIOEIGI()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(DHOMCKHIGNF));
		if (OnlineManager.PGAGDFAEEFB() && EventsManager.GGGECIBEKJG(EventsManager.EventType.KlaynTavern) && !EventsManager.JAGPJPGBHDK(EventsManager.EventType.KlaynTavern) && !EventsManager.LOFKKDNOKNF(EventsManager.EventType.ThroneRoom))
		{
			EventsManager.DIFPOBMAOLL(EventsManager.EventType.CastleForm, DMBFKFLDDLH: false);
			MissionsManager.instance.StartMission(-58, EPJLPKAGHDM: false);
		}
	}

	public void StartLucenCastleEvent()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		LucenNPC.GGFJGHHHEJC.content.gameObject.SetActive(true);
		EDGDFPPKGDL = null;
		if (OnlineManager.MasterOrOffline())
		{
			((Component)LucenNPC.GGFJGHHHEJC).transform.position = Vector2.op_Implicit(new Vector2(-927.5417f, 263.5417f));
			LucenNPC.GGFJGHHHEJC.Walk(new Vector2(-919.1667f, 264.1042f), Direction.Right);
			LucenNPC lucenNPC = LucenNPC.GGFJGHHHEJC;
			lucenNPC.WalkToCompleted = (Action)Delegate.Combine(lucenNPC.WalkToCompleted, new Action(StartLucenDialogue));
		}
		if (isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendCastleFormStartLucenEvent();
		}
	}

	private bool CJDGJOMACHI(int JIIGOACEIKL = 1)
	{
		return PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA == (Location.River | Location.BarnInterior);
	}

	public void GKDDPIOIHJF(int JIIGOACEIKL)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)(" in onlineObjects is null" + JIIGOACEIKL));
		PlayerController.MHKHGICIDNF(JIIGOACEIKL, Utils.EIDFHLPBICI(Vector2.op_Implicit(localCooperativeCameraPoint.position - ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position)));
		PlayerInputs.OOOGANAJMBB(JIIGOACEIKL, (MonoBehaviour)(object)this);
		CameraTarget.DAOIJLBKNPJ(JIIGOACEIKL, localCooperativeCameraPoint);
	}

	private IEnumerator BHFAGIFBICM()
	{
		return new KNBCEIODNKK(1)
		{
			_003C_003E4__this = this
		};
	}

	private bool BCBBDFLOGPP(int JIIGOACEIKL = 1)
	{
		return PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA == Location.Castle;
	}

	private IEnumerator LJNKACPDDLD()
	{
		MusicController.instance.FadeOutClip(2f, MMEHJCGGNFE: true);
		yield return CommonReferences.wait2;
		MusicController.instance.TriggerMusicTheme(27);
	}

	private IEnumerator KDIHMLIKIHA()
	{
		if (OnlineManager.MasterOrOffline())
		{
			LucenNPC.GGFJGHHHEJC.content.gameObject.SetActive(true);
			LucenNPC.GGFJGHHHEJC.Walk(new Vector2(-929.7708f, 271.2292f), Direction.Right, KEEGDBAAEOG: true);
		}
		EDGDFPPKGDL = null;
		yield return CommonReferences.wait1_5;
		KlaynNPC.instance.barkDialogue = false;
		KlaynNPC.instance.mouseUpTrigger = true;
		EDGDFPPKGDL = KlaynNPC.instance;
		MDFALJKHKED = "LicenciaDeApertura/KlaynDialogue 07";
		if (isActor)
		{
			KlaynNPC.instance.barkDialogue = false;
			KlaynNPC.instance.mouseUpTrigger = true;
			KlaynNPC.instance.StartConversation(CJODOOFLLLB, MDFALJKHKED);
		}
		else if (BCBBDFLOGPP())
		{
			yield return KlaynNPC.instance.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	public void MKOGOKEHKKH(int JIIGOACEIKL)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)("Create room list" + JIIGOACEIKL));
		PlayerController.MHKHGICIDNF(JIIGOACEIKL, Utils.EIDFHLPBICI(Vector2.op_Implicit(localCooperativeCameraPoint.position - ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position)));
		PlayerInputs.LPJCFCODNFA(JIIGOACEIKL, (MonoBehaviour)(object)this, ANJCLPDCJHL: true);
		CameraTarget.IEGOEFNIKLJ(JIIGOACEIKL, localCooperativeCameraPoint);
	}

	public void OEPJDKGENDP()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		LucenNPC.LPFNKEOJJKE().content.gameObject.SetActive(false);
		EDGDFPPKGDL = null;
		if (OnlineManager.PGAGDFAEEFB())
		{
			((Component)LucenNPC.HEKFJEKFMNO()).transform.position = Vector2.op_Implicit(new Vector2(873f, 1888f));
			LucenNPC.BNBMNOMFFBE().PKIBNCNNDJJ(new Vector2(937f, 1995f), (Direction)8, KEEGDBAAEOG: true);
			LucenNPC lucenNPC = LucenNPC.IBEGPMLJIOJ();
			lucenNPC.WalkToCompleted = (Action)Delegate.Combine(lucenNPC.WalkToCompleted, new Action(BLOFKKGGBPE));
		}
		if (isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendCastleFormStartLucenEvent();
		}
	}

	public void JLIJLGPNPNC(int JIIGOACEIKL)
	{
		Debug.Log((object)(" " + JIIGOACEIKL));
		JCIDFJMJMAA(((Component)TheloniusNPC.FMIDAFEGDCD()).gameObject);
		DCCLMODCEFE();
	}

	private void EGLHEAMOICO()
	{
		Debug.Log((object)"Items/item_name_1058");
		PlayerInputs.OOOGANAJMBB(1, (MonoBehaviour)(object)this);
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(CFIAMAPIOIN));
		FadeCamera.IGMCBPOPNCA(0).FadeOut(1053f);
	}

	public void JIJAIGCAAGJ(int JIIGOACEIKL)
	{
		Debug.Log((object)("Pause" + JIIGOACEIKL));
		JCIDFJMJMAA(((Component)TheloniusNPC.EKDNJDJHONF()).gameObject);
		BJLALEDCPNE();
	}

	private bool PGLBFMIJLAL(int JIIGOACEIKL = 1)
	{
		return PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA == (Location.Camp | Location.Farm);
	}

	private void PJJMNNCEGIH()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(DJNEMIOEIGI));
		if (OnlineManager.PGAGDFAEEFB() && EventsManager.OOCOFHECMDA(EventsManager.EventType.Scolding) && !EventsManager.BBMAEAFHEFK(EventsManager.EventType.ThroneRoom) && !EventsManager.FDIHEFGPKFP(EventsManager.EventType.KyrohWaterfall))
		{
			EventsManager.PMJAHPMMPJH(EventsManager.EventType.CastleForm, DMBFKFLDDLH: false);
			MissionsManager.instance.FGNLPCMEMMH(-76);
		}
	}

	private bool BGEOHHBMDCD(int JIIGOACEIKL = 1)
	{
		return PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA == (Location.River | Location.FarmShop);
	}

	private void INJNMCCGFIF()
	{
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(DHOMCKHIGNF));
		if (OnlineManager.MasterOrOffline() && EventsManager.IsDone(EventsManager.EventType.KlaynTavern) && !EventsManager.NJBACCBIHID((EventsManager.EventType)4) && !EventsManager.OOCOFHECMDA(EventsManager.EventType.KyrohWaterfall))
		{
			EventsManager.NEHAHKDCPPA(EventsManager.EventType.Scolding, DMBFKFLDDLH: true);
			MissionsManager.instance.StartMission(-116, EPJLPKAGHDM: true, CDPAMNIPPEC: false);
		}
	}

	public void HDNFPFBBIDA()
	{
		((MonoBehaviour)instance).StartCoroutine(LIGDEANMLOD());
		if (isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.KDDBKGJLHNJ();
		}
	}

	private IEnumerator HADABMFCMCD()
	{
		return new JAFKLGPNMND(1);
	}

	public void OnOnlinePlayerEntersCastle(int JIIGOACEIKL)
	{
		Debug.Log((object)("Online Player Entered Castle and started to see castle form event " + JIIGOACEIKL));
		JCIDFJMJMAA(((Component)TheloniusNPC.GGFJGHHHEJC).gameObject);
		JKELFKLGGID();
	}

	public override GameEvent GetInstance()
	{
		return instance;
	}

	private IEnumerator CKGNAHBCHJH()
	{
		return new KNBCEIODNKK(1)
		{
			_003C_003E4__this = this
		};
	}

	private void AAJNICMPDNO(int JIIGOACEIKL)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(0);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(AAJNICMPDNO));
		FadeCamera.EIFPKCAFDIB(1).NGMCABPPMJI(1032f);
		PlayerController.TeleportPlayer(JIIGOACEIKL, Vector2.op_Implicit(NCPBGLOJMAG()), Location.Tavern | Location.Camp | Location.Quarry);
		CFLOMAFOJHH();
	}

	public void EndLucenCastleEvent()
	{
		((MonoBehaviour)instance).StartCoroutine(KDIHMLIKIHA());
		if (isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendCastleFormEndLucenEvent();
		}
	}

	public void CMJNOAFDEHA()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		LucenNPC.DFJGHOHPPEL().content.gameObject.SetActive(false);
		EDGDFPPKGDL = null;
		if (OnlineManager.PGAGDFAEEFB())
		{
			((Component)LucenNPC.KPDFIEMDDCL()).transform.position = Vector2.op_Implicit(new Vector2(1152f, 917f));
			LucenNPC.ELGNEJNLBNO().DMIHGCBJBKG(new Vector2(760f, 1122f), Direction.Up, KEEGDBAAEOG: true);
			LucenNPC lucenNPC = LucenNPC.IBEGPMLJIOJ();
			lucenNPC.WalkToCompleted = (Action)Delegate.Combine(lucenNPC.WalkToCompleted, new Action(JIKLCMPCGPI));
		}
		if (isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendCastleFormStartLucenEvent();
		}
	}

	private void GDKHAEGALIL()
	{
		Debug.Log((object)"TeleportPlayerOnline");
		PlayerInputs.DisableKeyboardInputsAndMovement(1, (MonoBehaviour)(object)this);
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(BLHCCEMDNCG));
		FadeCamera.GetPlayer(1).FadeOut();
	}

	private void HDKDALIHOBG()
	{
		PlayerInputs.DisableKeyboardInputsAndMovement(0, (MonoBehaviour)(object)this, ANJCLPDCJHL: true);
		PlayerController.OPHDCMJLLEC(1).characterAnimation.SetDirection((Direction)6);
		((MonoBehaviour)this).StartCoroutine(KCDGBBIACHP());
		if (Object.op_Implicit((Object)(object)EDGDFPPKGDL))
		{
			((MonoBehaviour)this).StartCoroutine(EDGDFPPKGDL.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private void LOFJIFGBMBA(int JIIGOACEIKL)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(1);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(CFIAMAPIOIN));
		FadeCamera.EIFPKCAFDIB(1).CPALEJDCIGD(302f);
		PlayerController.CLEIAKPOGMM(JIIGOACEIKL, Vector2.op_Implicit(OJHPJHLGANB()), Location.Road | Location.Quarry);
		DCCLMODCEFE();
	}

	private void JKELFKLGGID()
	{
		PlayerInputs.DisableKeyboardInputsAndMovement(1, (MonoBehaviour)(object)this);
		PlayerController.GetPlayer(1).characterAnimation.SetDirection(Direction.Left);
		((MonoBehaviour)this).StartCoroutine(KCDGBBIACHP());
		if (Object.op_Implicit((Object)(object)EDGDFPPKGDL))
		{
			((MonoBehaviour)this).StartCoroutine(EDGDFPPKGDL.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	public void COOLEJADLFB()
	{
		((MonoBehaviour)instance).StartCoroutine(LIGDEANMLOD());
		if (isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.KDDBKGJLHNJ();
		}
	}

	public void KGBIGNDBMJE()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineEventsManager.SendCastleFormStartKlaynDialogue();
		}
		KlaynNPC klaynNPC = KlaynNPC.instance;
		klaynNPC.WalkToCompleted = (Action)Delegate.Remove(klaynNPC.WalkToCompleted, new Action(NMDEOCHOPEI));
		EDGDFPPKGDL = KlaynNPC.instance;
		MDFALJKHKED = "Dialogue System/Conversation/Gass_Introduce/Entry/24/Dialogue Text";
		if (isActor)
		{
			KlaynNPC.instance.barkDialogue = true;
			KlaynNPC.instance.mouseUpTrigger = true;
			KlaynNPC.instance.StartConversation(CJODOOFLLLB, MDFALJKHKED, FLHBPHPKIML: true);
		}
		else if (PADAMBCJNHB(0))
		{
			DialogueManager.StopAllConversations();
			((MonoBehaviour)this).StartCoroutine(KlaynNPC.instance.StartObserverDialogueWhenItIsPossible(0));
		}
	}

	public void OHMAALENPGC()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		LucenNPC.IBEGPMLJIOJ().content.gameObject.SetActive(false);
		EDGDFPPKGDL = null;
		if (OnlineManager.PGAGDFAEEFB())
		{
			((Component)LucenNPC.GGFJGHHHEJC).transform.position = Vector2.op_Implicit(new Vector2(1662f, 1341f));
			LucenNPC.NHKAFANMEJC().MMAAOFHFPNP(new Vector2(1215f, 1890f));
			LucenNPC lucenNPC = LucenNPC.IBEGPMLJIOJ();
			lucenNPC.WalkToCompleted = (Action)Delegate.Combine(lucenNPC.WalkToCompleted, new Action(OGHEAMFJNHE));
		}
		if (isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendCastleFormStartLucenEvent();
		}
	}

	public void FPMJFBJHLLM(int ABAIKKGKDGD)
	{
		SceneReferences.instance.interactableForms[ABAIKKGKDGD].JIADLKOLEEP(JALCAHLNPOF: true, CDPAMNIPPEC: true);
	}

	public void FKMNAOBGOKK(int ABAIKKGKDGD)
	{
		SceneReferences.instance.interactableForms[ABAIKKGKDGD].JIADLKOLEEP(JALCAHLNPOF: true, CDPAMNIPPEC: true);
	}

	private void DHOMCKHIGNF()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(DHOMCKHIGNF));
		if (OnlineManager.MasterOrOffline() && EventsManager.DOPLDNPIBPP(EventsManager.EventType.Scolding) && !EventsManager.NJBACCBIHID(EventsManager.EventType.OathFeast) && !EventsManager.GGGECIBEKJG(EventsManager.EventType.KlaynTavern))
		{
			EventsManager.FOHLKKJIFOL(EventsManager.EventType.ThroneRoom, DMBFKFLDDLH: false);
			MissionsManager.instance.BFAHLFFBCEJ(-23);
		}
	}

	private IEnumerator IGEAONELMME()
	{
		return new JAFKLGPNMND(1);
	}

	public void MMBPMMPIMAC(int JIIGOACEIKL, bool GFNHAMCPEAK = true)
	{
		CJODOOFLLLB = JIIGOACEIKL;
		StartEvent(GFNHAMCPEAK, CDPAMNIPPEC: false);
	}

	public void PJMHLHACOCK(int JIIGOACEIKL)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)("ReceiveHitJacky" + JIIGOACEIKL));
		PlayerController.SetDirection(JIIGOACEIKL, Utils.EIDFHLPBICI(Vector2.op_Implicit(localCooperativeCameraPoint.position - ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position)));
		PlayerInputs.OOOGANAJMBB(JIIGOACEIKL, (MonoBehaviour)(object)this, ANJCLPDCJHL: true);
		CameraTarget.IEGOEFNIKLJ(JIIGOACEIKL, localCooperativeCameraPoint);
	}

	private void BJLALEDCPNE()
	{
		PlayerInputs.LPJCFCODNFA(0, (MonoBehaviour)(object)this);
		PlayerController.OPHDCMJLLEC(0).characterAnimation.SetDirection((Direction)7);
		((MonoBehaviour)this).StartCoroutine(GNFOEPFJHGA());
		if (Object.op_Implicit((Object)(object)EDGDFPPKGDL))
		{
			((MonoBehaviour)this).StartCoroutine(EDGDFPPKGDL.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private void BGPGIOMKKAO()
	{
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
		if (OnlineManager.MasterOrOffline() && EventsManager.IsDone(EventsManager.EventType.KlaynTavern) && !EventsManager.IsActive(EventsManager.EventType.CastleForm) && !EventsManager.IsDone(EventsManager.EventType.CastleForm))
		{
			EventsManager.SetActive(EventsManager.EventType.CastleForm, DMBFKFLDDLH: true);
			MissionsManager.instance.StartMission(302);
		}
	}

	public void PrepareLocalCoop()
	{
		int jIIGOACEIKL = ((CJODOOFLLLB != 1) ? 1 : 2);
		CameraTarget.SetCameraTarget(CJODOOFLLLB, localCooperativeCameraPoint);
		if (BCBBDFLOGPP(jIIGOACEIKL))
		{
			OnLocalPlayerEntersCastle(jIIGOACEIKL);
			return;
		}
		TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Castle, Location.CastleGarden);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Combine(travelZone.OnTravelZoneTo, new Action<int>(OnLocalPlayerEntersCastle));
	}

	public void FGEHLNEIIEF(int JIIGOACEIKL)
	{
		Debug.Log((object)("Save Game Client" + JIIGOACEIKL));
		JCIDFJMJMAA(((Component)TheloniusNPC.OFLELHKKNKC()).gameObject);
		CFLOMAFOJHH();
	}

	private void OHLLBGHNOIC()
	{
		Debug.Log((object)")");
		PlayerInputs.LPJCFCODNFA(1, (MonoBehaviour)(object)this, ANJCLPDCJHL: true);
		FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(1);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Combine(fadeCamera.OnFadeFinished, new Action<int>(BIIEBOCKIOJ));
		FadeCamera.IGMCBPOPNCA(0).GPBOEBGJJPM(1706f);
	}

	private IEnumerator DPGCIKGBDGO()
	{
		return new LBBOKMMKHAN(1)
		{
			_003C_003E4__this = this
		};
	}

	public override void StartEvent(bool GFNHAMCPEAK, bool CDPAMNIPPEC)
	{
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		base.StartEvent(GFNHAMCPEAK, CDPAMNIPPEC);
		if (GameManager.LocalCoop())
		{
			PrepareLocalCoop();
		}
		else if (OnlineManager.PlayingOnline() && !GFNHAMCPEAK)
		{
			if (BCBBDFLOGPP())
			{
				if (Vector2.Distance(Vector2.op_Implicit(((Component)PlayerController.GetPlayer(1)).transform.position), Vector2.op_Implicit(((Component)TheloniusNPC.GGFJGHHHEJC).transform.position)) < 9f)
				{
					PlayerController.GetPlayer(1).GoToPositionIndependentThread(DIMHIDKJAKB(), Direction.Left);
					JKELFKLGGID();
				}
				else
				{
					JCIDFJMJMAA(((Component)TheloniusNPC.GGFJGHHHEJC).gameObject);
					JKELFKLGGID();
				}
			}
			else
			{
				TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Castle, Location.CastleGarden);
				travelZone.OnTravelZoneTo = (Action<int>)Delegate.Combine(travelZone.OnTravelZoneTo, new Action<int>(OnOnlinePlayerEntersCastle));
			}
		}
		else
		{
			PlayerController.SetDirection(1, Direction.Left);
			PlayerInputs.DisableKeyboardInputsAndMovement(1, (MonoBehaviour)(object)this);
		}
		KlaynNPC.instance.content.SetActive(true);
		if (OnlineManager.MasterOrOffline())
		{
			((Component)KlaynNPC.instance).transform.position = Vector2.op_Implicit(new Vector2(-7f, 28f));
			((Component)KlaynNPC.instance).transform.position = Vector2.op_Implicit(new Vector2(-916.5f, 269.3542f));
			KlaynNPC.instance.animationBase.SetDirection(Direction.Down);
			KlaynNPC.instance.targetWalkTo = new Vector2(-917.5f, 263.9375f);
			KlaynNPC.instance.endWalkDirection = Direction.Right;
			KlaynNPC.instance.ChangeState(KlaynState.WalkTo);
			KlaynNPC klaynNPC = KlaynNPC.instance;
			klaynNPC.WalkToCompleted = (Action)Delegate.Combine(klaynNPC.WalkToCompleted, new Action(StartKlaynDialogue));
			((MonoBehaviour)this).StartCoroutine(KLMCBCDGAHG());
		}
		LucenNPC.GGFJGHHHEJC.barkDialogue = false;
		LucenNPC.GGFJGHHHEJC.SelectDialogueUI();
		if (OnlineManager.MasterOrOffline())
		{
			((MonoBehaviour)this).StartCoroutine(KCDGBBIACHP());
		}
	}

	private IEnumerator AHACPOMEIEO()
	{
		return new LBBOKMMKHAN(1)
		{
			_003C_003E4__this = this
		};
	}

	public void StartLucenDialogue()
	{
		Debug.Log((object)("StartLucenDialogue " + isActor));
		LucenNPC lucenNPC = LucenNPC.GGFJGHHHEJC;
		lucenNPC.WalkToCompleted = (Action)Delegate.Remove(lucenNPC.WalkToCompleted, new Action(StartLucenDialogue));
		LucenNPC.GGFJGHHHEJC.barkDialogue = false;
		LucenNPC.GGFJGHHHEJC.mouseUpTrigger = true;
		EDGDFPPKGDL = LucenNPC.GGFJGHHHEJC;
		MDFALJKHKED = "LicenciaDeApertura/LucenDialogue 06";
		if (isActor)
		{
			LucenNPC.GGFJGHHHEJC.StartConversation(CJODOOFLLLB, MDFALJKHKED);
		}
		else if (BCBBDFLOGPP())
		{
			((MonoBehaviour)this).StartCoroutine(LucenNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1));
		}
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendCastleFormStartLucenDialogue();
		}
	}

	private void BGKPNEAOPJM()
	{
		PlayerInputs.LPJCFCODNFA(0, (MonoBehaviour)(object)this, ANJCLPDCJHL: true);
		PlayerController.OPHDCMJLLEC(0).characterAnimation.SetDirection((Direction)7);
		((MonoBehaviour)this).StartCoroutine(NOBPMADHFDC());
		if (Object.op_Implicit((Object)(object)EDGDFPPKGDL))
		{
			((MonoBehaviour)this).StartCoroutine(EDGDFPPKGDL.StartObserverDialogueWhenItIsPossible(0));
		}
	}

	public void HAEMDKBIKOG(int JIIGOACEIKL)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)("NULL" + JIIGOACEIKL));
		PlayerController.MHKHGICIDNF(JIIGOACEIKL, Utils.EIDFHLPBICI(Vector2.op_Implicit(localCooperativeCameraPoint.position - ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position)));
		PlayerInputs.OOOGANAJMBB(JIIGOACEIKL, (MonoBehaviour)(object)this, ANJCLPDCJHL: true);
		CameraTarget.IEGOEFNIKLJ(JIIGOACEIKL, localCooperativeCameraPoint);
	}

	public void PAKJIOLCGPO(int JIIGOACEIKL)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)("Error_RoomZone" + JIIGOACEIKL));
		PlayerController.MHKHGICIDNF(JIIGOACEIKL, Utils.EIDFHLPBICI(Vector2.op_Implicit(localCooperativeCameraPoint.position - ((Component)PlayerController.OPHDCMJLLEC(JIIGOACEIKL)).transform.position)));
		PlayerInputs.LPJCFCODNFA(JIIGOACEIKL, (MonoBehaviour)(object)this, ANJCLPDCJHL: true);
		CameraTarget.IEGOEFNIKLJ(JIIGOACEIKL, localCooperativeCameraPoint);
	}

	public void OHGGBEKIDCH()
	{
		Debug.Log((object)("Items/item_name_1116" + isActor));
		LucenNPC lucenNPC = LucenNPC.BNDNMBGJEKP();
		lucenNPC.WalkToCompleted = (Action)Delegate.Remove(lucenNPC.WalkToCompleted, new Action(BLOFKKGGBPE));
		LucenNPC.IBEGPMLJIOJ().barkDialogue = true;
		LucenNPC.GGFJGHHHEJC.mouseUpTrigger = true;
		EDGDFPPKGDL = LucenNPC.KPDFIEMDDCL();
		MDFALJKHKED = "Items/item_description_1182";
		if (isActor)
		{
			LucenNPC.IBEGPMLJIOJ().StartConversation(CJODOOFLLLB, MDFALJKHKED, FLHBPHPKIML: true);
		}
		else if (KECGJCLDHDM())
		{
			((MonoBehaviour)this).StartCoroutine(LucenNPC.NHKAFANMEJC().StartObserverDialogueWhenItIsPossible(0));
		}
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendCastleFormStartLucenDialogue();
		}
	}

	private void EFJNFFELBCL()
	{
		GameManager gameManager = GameManager.NJNFHEPLEHL();
		gameManager.OnWorldLoaded = (Action)Delegate.Remove(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
		if (OnlineManager.PGAGDFAEEFB() && EventsManager.GGGECIBEKJG(EventsManager.EventType.Scolding) && !EventsManager.KEGDEHKPKMP(EventsManager.EventType.KujakuShop) && !EventsManager.LOFKKDNOKNF(EventsManager.EventType.KlaynTavern))
		{
			EventsManager.DIBGPIPPDFD(EventsManager.EventType.ThroneRoom, DMBFKFLDDLH: true);
			MissionsManager.instance.BFPLMBMJDEN(-98, EPJLPKAGHDM: false, CDPAMNIPPEC: false);
		}
	}

	public void FOCGCKEAPHC()
	{
		int jIIGOACEIKL = ((CJODOOFLLLB != 1) ? 1 : 4);
		CameraTarget.SetCameraTarget(CJODOOFLLLB, localCooperativeCameraPoint);
		if (ABBNFIBMCIH(jIIGOACEIKL))
		{
			PAKJIOLCGPO(jIIGOACEIKL);
			return;
		}
		TravelZone travelZone = TravelZonesManager.DCAEBALADIM().GetTravelZone(Location.Tavern | Location.Road | Location.Camp | Location.Quarry | Location.Farm | Location.FarmShop, ~(Location.Tavern | Location.Road | Location.River | Location.Quarry | Location.Farm | Location.BarnInterior));
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Combine(travelZone.OnTravelZoneTo, new Action<int>(OnLocalPlayerEntersCastle));
	}

	private IEnumerator MHEKNJDKIFB()
	{
		return new LBBOKMMKHAN(1)
		{
			_003C_003E4__this = this
		};
	}

	public void HNKNIMNNONA()
	{
		((MonoBehaviour)instance).StartCoroutine(AHACPOMEIEO());
		if (isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.KDDBKGJLHNJ();
		}
	}

	public void StartKlaynEvent(int JIIGOACEIKL, bool GFNHAMCPEAK = true)
	{
		CJODOOFLLLB = JIIGOACEIKL;
		StartEvent(GFNHAMCPEAK, CDPAMNIPPEC: true);
	}

	public void CPDHKILEGOD(int ABAIKKGKDGD)
	{
		SceneReferences.instance.interactableForms[ABAIKKGKDGD].BDAJHOCGPAN(JALCAHLNPOF: false, CDPAMNIPPEC: false);
	}

	public void AMOEKCMLANI()
	{
		int jIIGOACEIKL = ((CJODOOFLLLB == 0) ? 0 : 0);
		CameraTarget.DAOIJLBKNPJ(CJODOOFLLLB, localCooperativeCameraPoint);
		if (JIPEKGAJBPA(jIIGOACEIKL))
		{
			LAJKFEMKJMD(jIIGOACEIKL);
			return;
		}
		TravelZone travelZone = TravelZonesManager.OLHBLKIAFOM().JKPNCIFMAOO(~(Location.Road | Location.Camp | Location.FarmShop), ~(Location.Tavern | Location.Farm | Location.BarnInterior));
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Combine(travelZone.OnTravelZoneTo, new Action<int>(PJMHLHACOCK));
	}

	private IEnumerator NOBPMADHFDC()
	{
		return new JFMEKJFLHHF(1);
	}

	private IEnumerator GIDBBCDHEJL()
	{
		MusicController.instance.FadeOutClip(2f, MMEHJCGGNFE: true);
		yield return CommonReferences.wait2;
		MusicController.instance.TriggerMusicTheme(27);
	}

	public void DLPHKHIGONH()
	{
		((MonoBehaviour)instance).StartCoroutine(AHACPOMEIEO());
		if (isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendCastleFormEndLucenEvent();
		}
	}

	private bool PADAMBCJNHB(int JIIGOACEIKL = 1)
	{
		return PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA == (Location.Tavern | Location.River | Location.Camp | Location.Quarry | Location.FarmShop);
	}

	private bool KECGJCLDHDM(int JIIGOACEIKL = 1)
	{
		return PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA == Location.None;
	}

	private bool ABBNFIBMCIH(int JIIGOACEIKL = 1)
	{
		return PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA == ~Location.Road;
	}

	public void ActiveForm(int ABAIKKGKDGD)
	{
		SceneReferences.instance.interactableForms[ABAIKKGKDGD].SetFormMade(JALCAHLNPOF: false, CDPAMNIPPEC: true);
	}

	public void PCAOIJEFFIO(int ABAIKKGKDGD)
	{
		SceneReferences.instance.interactableForms[ABAIKKGKDGD].SetFormMade(JALCAHLNPOF: true, CDPAMNIPPEC: false);
	}

	private Vector2 OHPJMFLIEDM()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		return Vector2.op_Implicit(((Component)TheloniusNPC.KNOKBLFFNLM()).transform.position + new Vector3((float)Random.Range(-11, 4), (float)Random.Range(-113, -1)));
	}

	private void BIIEBOCKIOJ(int JIIGOACEIKL)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(0);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(GLBPBGFNLLN));
		FadeCamera.EIFPKCAFDIB(0).CPALEJDCIGD(1631f);
		PlayerController.CLEIAKPOGMM(JIIGOACEIKL, Vector2.op_Implicit(HPNFICDFFGN()), ~(Location.Road | Location.River | Location.Camp | Location.BarnInterior));
		HDKDALIHOBG();
	}

	public void NJLMFDPNDEO()
	{
		Debug.Log((object)(". Time since startup: " + isActor));
		LucenNPC lucenNPC = LucenNPC.MOAKANGAMBA();
		lucenNPC.WalkToCompleted = (Action)Delegate.Remove(lucenNPC.WalkToCompleted, new Action(OGHEAMFJNHE));
		LucenNPC.MOAKANGAMBA().barkDialogue = true;
		LucenNPC.LPFNKEOJJKE().mouseUpTrigger = false;
		EDGDFPPKGDL = LucenNPC.GGFJGHHHEJC;
		MDFALJKHKED = "Player";
		if (isActor)
		{
			LucenNPC.BNBMNOMFFBE().StartConversation(CJODOOFLLLB, MDFALJKHKED, FLHBPHPKIML: true);
		}
		else if (BGEOHHBMDCD(0))
		{
			((MonoBehaviour)this).StartCoroutine(LucenNPC.ELGNEJNLBNO().StartObserverDialogueWhenItIsPossible(1));
		}
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendCastleFormStartLucenDialogue();
		}
	}

	public void LEBOLIGFHJL()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		LucenNPC.BNBMNOMFFBE().content.gameObject.SetActive(true);
		EDGDFPPKGDL = null;
		if (OnlineManager.PGAGDFAEEFB())
		{
			((Component)LucenNPC.LPFNKEOJJKE()).transform.position = Vector2.op_Implicit(new Vector2(1311f, 1222f));
			LucenNPC.BNDNMBGJEKP().PKIBNCNNDJJ(new Vector2(137f, 440f), Direction.Up, KEEGDBAAEOG: true);
			LucenNPC lucenNPC = LucenNPC.BNBMNOMFFBE();
			lucenNPC.WalkToCompleted = (Action)Delegate.Combine(lucenNPC.WalkToCompleted, new Action(JIKLCMPCGPI));
		}
		if (isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendCastleFormStartLucenEvent();
		}
	}

	private IEnumerator JMNPLHANHMP()
	{
		return new KNBCEIODNKK(1)
		{
			_003C_003E4__this = this
		};
	}

	public void MLGMGJGBNOL(int JIIGOACEIKL)
	{
		Debug.Log((object)("Skill branch not unlocked" + JIIGOACEIKL));
		JCIDFJMJMAA(((Component)TheloniusNPC.EKDNJDJHONF()).gameObject);
		OHNGEMFGBAE();
	}

	public void LAJKFEMKJMD(int JIIGOACEIKL)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)("Tower" + JIIGOACEIKL));
		PlayerController.MHKHGICIDNF(JIIGOACEIKL, Utils.EIDFHLPBICI(Vector2.op_Implicit(localCooperativeCameraPoint.position - ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position)));
		PlayerInputs.LPJCFCODNFA(JIIGOACEIKL, (MonoBehaviour)(object)this);
		CameraTarget.IEGOEFNIKLJ(JIIGOACEIKL, localCooperativeCameraPoint);
	}

	private void AJEAFEBEABI()
	{
		Debug.Log((object)"PlayerLeftBed_F");
		PlayerInputs.LPJCFCODNFA(1, (MonoBehaviour)(object)this, ANJCLPDCJHL: true);
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(1);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Combine(fadeCamera.OnFadeFinished, new Action<int>(LOFJIFGBMBA));
		FadeCamera.IGMCBPOPNCA(0).AJHDEBOMHKK(1969f);
	}

	public void IDOHENEHGFA()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		LucenNPC.NHKAFANMEJC().content.gameObject.SetActive(false);
		EDGDFPPKGDL = null;
		if (OnlineManager.MasterOrOffline())
		{
			((Component)LucenNPC.GGFJGHHHEJC).transform.position = Vector2.op_Implicit(new Vector2(1394f, 551f));
			LucenNPC.HEKFJEKFMNO().PKIBNCNNDJJ(new Vector2(621f, 486f), Direction.Right, KEEGDBAAEOG: true);
			LucenNPC lucenNPC = LucenNPC.MOAKANGAMBA();
			lucenNPC.WalkToCompleted = (Action)Delegate.Combine(lucenNPC.WalkToCompleted, new Action(JIKLCMPCGPI));
		}
		if (isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendCastleFormStartLucenEvent();
		}
	}

	protected override void Awake()
	{
		base.Awake();
		instance = this;
		GameManager gameManager = GameManager.GGFJGHHHEJC;
		gameManager.OnWorldLoaded = (Action)Delegate.Combine(gameManager.OnWorldLoaded, new Action(BGPGIOMKKAO));
	}

	public void OGCKPJDHELO()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		LucenNPC.ELGNEJNLBNO().content.gameObject.SetActive(false);
		EDGDFPPKGDL = null;
		if (OnlineManager.PGAGDFAEEFB())
		{
			((Component)LucenNPC.MOAKANGAMBA()).transform.position = Vector2.op_Implicit(new Vector2(253f, 863f));
			LucenNPC.EFPJLFMBPLL().PKIBNCNNDJJ(new Vector2(1934f, 410f), Direction.Left);
			LucenNPC lucenNPC = LucenNPC.DFJGHOHPPEL();
			lucenNPC.WalkToCompleted = (Action)Delegate.Combine(lucenNPC.WalkToCompleted, new Action(JIKLCMPCGPI));
		}
		if (isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendCastleFormStartLucenEvent();
		}
	}

	public void KCLFGFAJOEG()
	{
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.PFAILBGMCCL();
		}
		KlaynNPC klaynNPC = KlaynNPC.instance;
		klaynNPC.WalkToCompleted = (Action)Delegate.Remove(klaynNPC.WalkToCompleted, new Action(DPPHGHIPFAN));
		EDGDFPPKGDL = KlaynNPC.instance;
		MDFALJKHKED = "Must have a unique ID assigned.";
		if (isActor)
		{
			KlaynNPC.instance.barkDialogue = true;
			KlaynNPC.instance.mouseUpTrigger = false;
			KlaynNPC.instance.StartConversation(CJODOOFLLLB, MDFALJKHKED);
		}
		else if (BGEOHHBMDCD(0))
		{
			DialogueManager.StopAllConversations();
			((MonoBehaviour)this).StartCoroutine(KlaynNPC.instance.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private Vector2 OJHPJHLGANB()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		return Vector2.op_Implicit(((Component)TheloniusNPC.KNOKBLFFNLM()).transform.position + new Vector3((float)Random.Range(-94, 1), (float)Random.Range(-63, -1)));
	}

	public void HFDDDNMBDCF(int JIIGOACEIKL, bool GFNHAMCPEAK = true)
	{
		CJODOOFLLLB = JIIGOACEIKL;
		StartEvent(GFNHAMCPEAK, CDPAMNIPPEC: true);
	}

	private IEnumerator MGBGPCNDNDF()
	{
		return new KNBCEIODNKK(1)
		{
			_003C_003E4__this = this
		};
	}

	private void CFIAMAPIOIN(int JIIGOACEIKL)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(1);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(CFIAMAPIOIN));
		FadeCamera.GetPlayer(0).LHBLBOONEEC(409f);
		PlayerController.CLEIAKPOGMM(JIIGOACEIKL, Vector2.op_Implicit(HPNFICDFFGN()), Location.Tavern | Location.Road | Location.River | Location.Quarry);
		PHKGBIIGBOC();
	}

	public override void EndEvent(bool BGKCHMNJBLJ)
	{
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		if (EventsManager.IsDone(EventsManager.EventType.CastleForm))
		{
			return;
		}
		base.EndEvent(BGKCHMNJBLJ);
		if (GameManager.LocalCoop())
		{
			CameraTarget.RestorePlayerCameraTarget(CJODOOFLLLB);
			int jIIGOACEIKL = ((CJODOOFLLLB != 1) ? 1 : 2);
			if (BCBBDFLOGPP(jIIGOACEIKL))
			{
				CameraTarget.RestorePlayerCameraTarget(jIIGOACEIKL);
			}
		}
		DialogueCameraTarget.GetPlayer(1).ReturnControlToCameraTarget();
		TravelZone travelZone = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Castle, Location.CastleGarden);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone.OnTravelZoneTo, new Action<int>(OnOnlinePlayerEntersCastle));
		TravelZone travelZone2 = TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.Castle, Location.CastleGarden);
		travelZone2.OnTravelZoneTo = (Action<int>)Delegate.Remove(travelZone2.OnTravelZoneTo, new Action<int>(OnLocalPlayerEntersCastle));
		KlaynNPC.instance.playerCanInteract = false;
		if (OnlineManager.MasterOrOffline())
		{
			KlaynNPC.instance.targetWalkTo = new Vector2(-929.7708f, 271.2292f);
			KlaynNPC.instance.ChangeState(KlaynState.WalkTo);
			KlaynNPC.instance.disable = true;
			PlayerInventory.GetPlayer(1).AddItem(ItemDatabaseAccessor.GetItem(1814).JMDALJBNFML(), HMPDLIPFBGD: true);
		}
		TavernBuilding.instance.ActivateCeaseSigns(DMBFKFLDDLH: false);
		if (BCBBDFLOGPP())
		{
			PlayerInputs.EnableKeyboardInputsAndMovement(1, (MonoBehaviour)(object)this);
		}
		if (GameManager.LocalCoop())
		{
			if (BCBBDFLOGPP(2))
			{
				PlayerInputs.EnableKeyboardInputsAndMovement(2, (MonoBehaviour)(object)this);
			}
			((MonoBehaviour)this).StartCoroutine(KPFPHHMIGGI());
		}
		else if (BCBBDFLOGPP())
		{
			((MonoBehaviour)this).StartCoroutine(KPFPHHMIGGI());
		}
	}

	private void PHKGBIIGBOC()
	{
		PlayerInputs.OOOGANAJMBB(1, (MonoBehaviour)(object)this, ANJCLPDCJHL: true);
		PlayerController.GetPlayer(0).characterAnimation.SetDirection(Direction.Right);
		((MonoBehaviour)this).StartCoroutine(GNFOEPFJHGA());
		if (Object.op_Implicit((Object)(object)EDGDFPPKGDL))
		{
			((MonoBehaviour)this).StartCoroutine(EDGDFPPKGDL.StartObserverDialogueWhenItIsPossible(0));
		}
	}

	private IEnumerator KLMCBCDGAHG()
	{
		yield return CommonReferences.wait1_5;
		((Component)guard).gameObject.transform.position = ((Component)guard).gameObject.transform.position + new Vector3(-0.25f, 0f, 0f);
		guard.SetDirection(Direction.Right);
		yield return CommonReferences.wait1_5;
		((Component)guard).gameObject.transform.position = ((Component)guard).gameObject.transform.position + new Vector3(0.25f, 0f, 0f);
		guard.SetDirection(Direction.Down);
	}

	private IEnumerator HJNJHAFHGMD()
	{
		return new LBBOKMMKHAN(1)
		{
			_003C_003E4__this = this
		};
	}

	public void KHPMJKPEOOE(int JIIGOACEIKL)
	{
		Debug.Log((object)("Selected values:\n" + JIIGOACEIKL));
		JCIDFJMJMAA(((Component)TheloniusNPC.HFIJHDBKCIA()).gameObject);
		JKELFKLGGID();
	}

	public void DPJHPINPAMK()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineEventsManager.SendCastleFormStartKlaynDialogue();
		}
		KlaynNPC klaynNPC = KlaynNPC.instance;
		klaynNPC.WalkToCompleted = (Action)Delegate.Remove(klaynNPC.WalkToCompleted, new Action(StartKlaynDialogue));
		EDGDFPPKGDL = KlaynNPC.instance;
		MDFALJKHKED = "Dialogue System/Conversation/BirdNegativeComments/Entry/2/Dialogue Text";
		if (isActor)
		{
			KlaynNPC.instance.barkDialogue = false;
			KlaynNPC.instance.mouseUpTrigger = true;
			KlaynNPC.instance.StartConversation(CJODOOFLLLB, MDFALJKHKED);
		}
		else if (LHDIFJJPNHC(0))
		{
			DialogueManager.StopAllConversations();
			((MonoBehaviour)this).StartCoroutine(KlaynNPC.instance.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private IEnumerator GNFOEPFJHGA()
	{
		return new JFMEKJFLHHF(1);
	}

	private void IDEJKAKCKJK()
	{
		Debug.Log((object)"ReceiveFoodSlotPlayerInventory");
		PlayerInputs.OOOGANAJMBB(0, (MonoBehaviour)(object)this, ANJCLPDCJHL: true);
		FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(1);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Combine(fadeCamera.OnFadeFinished, new Action<int>(AAJNICMPDNO));
		FadeCamera.GetPlayer(1).GPBOEBGJJPM(143f);
	}

	public void LCIMAAEEDCI(int ABAIKKGKDGD)
	{
		SceneReferences.instance.interactableForms[ABAIKKGKDGD].DIGICKCCMON(JALCAHLNPOF: true, CDPAMNIPPEC: true);
	}

	private void BLHCCEMDNCG(int JIIGOACEIKL)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(BLHCCEMDNCG));
		FadeCamera.GetPlayer(1).FadeIn();
		PlayerController.TeleportPlayer(JIIGOACEIKL, Vector2.op_Implicit(DIMHIDKJAKB()), Location.Castle);
		JKELFKLGGID();
	}

	public void StartKlaynDialogue()
	{
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendCastleFormStartKlaynDialogue();
		}
		KlaynNPC klaynNPC = KlaynNPC.instance;
		klaynNPC.WalkToCompleted = (Action)Delegate.Remove(klaynNPC.WalkToCompleted, new Action(StartKlaynDialogue));
		EDGDFPPKGDL = KlaynNPC.instance;
		MDFALJKHKED = "LicenciaDeApertura/KlaynDialogue 05";
		if (isActor)
		{
			KlaynNPC.instance.barkDialogue = false;
			KlaynNPC.instance.mouseUpTrigger = true;
			KlaynNPC.instance.StartConversation(CJODOOFLLLB, MDFALJKHKED);
		}
		else if (BCBBDFLOGPP())
		{
			DialogueManager.StopAllConversations();
			((MonoBehaviour)this).StartCoroutine(KlaynNPC.instance.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	public void FDHBJEHCGBG()
	{
		((MonoBehaviour)instance).StartCoroutine(OPEGAEMIMHK());
		if (isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.KDDBKGJLHNJ();
		}
	}

	public void OGHEAMFJNHE()
	{
		Debug.Log((object)("Game" + isActor));
		LucenNPC lucenNPC = LucenNPC.DFJGHOHPPEL();
		lucenNPC.WalkToCompleted = (Action)Delegate.Remove(lucenNPC.WalkToCompleted, new Action(MNBDLNGMBBN));
		LucenNPC.MOAKANGAMBA().barkDialogue = false;
		LucenNPC.EFPJLFMBPLL().mouseUpTrigger = true;
		EDGDFPPKGDL = LucenNPC.MOAKANGAMBA();
		MDFALJKHKED = "Items/item_description_1183";
		if (isActor)
		{
			LucenNPC.DFJGHOHPPEL().StartConversation(CJODOOFLLLB, MDFALJKHKED);
		}
		else if (ABBNFIBMCIH(0))
		{
			((MonoBehaviour)this).StartCoroutine(LucenNPC.ELGNEJNLBNO().StartObserverDialogueWhenItIsPossible(0));
		}
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineEventsManager.SendCastleFormStartLucenDialogue();
		}
	}

	private void EBHNCMGFKOP()
	{
		Debug.Log((object)"chatx");
		PlayerInputs.LPJCFCODNFA(0, (MonoBehaviour)(object)this);
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(0);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Combine(fadeCamera.OnFadeFinished, new Action<int>(AAJNICMPDNO));
		FadeCamera.EIFPKCAFDIB(1).AJHDEBOMHKK(1032f);
	}

	private IEnumerator KCDGBBIACHP()
	{
		yield return CommonReferences.wait01;
		MusicController.instance.FadeOutClip(2f, MMEHJCGGNFE: true);
		yield return CommonReferences.wait2;
		MusicController.instance.TriggerMusicTheme(28);
	}

	public void NMDEOCHOPEI()
	{
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendCastleFormStartKlaynDialogue();
		}
		KlaynNPC klaynNPC = KlaynNPC.instance;
		klaynNPC.WalkToCompleted = (Action)Delegate.Remove(klaynNPC.WalkToCompleted, new Action(NMDEOCHOPEI));
		EDGDFPPKGDL = KlaynNPC.instance;
		MDFALJKHKED = "ReceiveSkipKlaynChallenge";
		if (isActor)
		{
			KlaynNPC.instance.barkDialogue = true;
			KlaynNPC.instance.mouseUpTrigger = false;
			KlaynNPC.instance.StartConversation(CJODOOFLLLB, MDFALJKHKED);
		}
		else if (JJPLMMHEDKA(0))
		{
			DialogueManager.StopAllConversations();
			((MonoBehaviour)this).StartCoroutine(KlaynNPC.instance.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	public void FAHCFENECAD(int JIIGOACEIKL, bool GFNHAMCPEAK = true)
	{
		CJODOOFLLLB = JIIGOACEIKL;
		StartEvent(GFNHAMCPEAK, CDPAMNIPPEC: false);
	}

	public void AKPJJLGKEPJ(int ABAIKKGKDGD)
	{
		SceneReferences.instance.interactableForms[ABAIKKGKDGD].PNHMJFCFNLO(JALCAHLNPOF: true, CDPAMNIPPEC: true);
	}

	public void PNNMLOBJPJM(int JIIGOACEIKL, bool GFNHAMCPEAK = true)
	{
		CJODOOFLLLB = JIIGOACEIKL;
		StartEvent(GFNHAMCPEAK, CDPAMNIPPEC: false);
	}

	private IEnumerator KIBHPDHBPDD()
	{
		yield return CommonReferences.wait1_5;
		((Component)guard).gameObject.transform.position = ((Component)guard).gameObject.transform.position + new Vector3(-0.25f, 0f, 0f);
		guard.SetDirection(Direction.Right);
		yield return CommonReferences.wait1_5;
		((Component)guard).gameObject.transform.position = ((Component)guard).gameObject.transform.position + new Vector3(0.25f, 0f, 0f);
		guard.SetDirection(Direction.Down);
	}

	private void DCCLMODCEFE()
	{
		PlayerInputs.OOOGANAJMBB(1, (MonoBehaviour)(object)this);
		PlayerController.OPHDCMJLLEC(0).characterAnimation.SetDirection(Direction.Up);
		((MonoBehaviour)this).StartCoroutine(GNFOEPFJHGA());
		if (Object.op_Implicit((Object)(object)EDGDFPPKGDL))
		{
			((MonoBehaviour)this).StartCoroutine(EDGDFPPKGDL.StartObserverDialogueWhenItIsPossible(0));
		}
	}

	private IEnumerator IFIJFDGKHJM()
	{
		return new JAFKLGPNMND(1);
	}

	public void MECJKCFLKLH()
	{
		int jIIGOACEIKL = ((CJODOOFLLLB == 0) ? 4 : 0);
		CameraTarget.BPHGNEPFFKG(CJODOOFLLLB, localCooperativeCameraPoint);
		if (PGLBFMIJLAL(jIIGOACEIKL))
		{
			GKDDPIOIHJF(jIIGOACEIKL);
			return;
		}
		TravelZone travelZone = TravelZonesManager.DGCNCEDIFOF().IMKJEBFOBKK(~(Location.Camp | Location.Quarry | Location.Farm | Location.FarmShop), Location.Road | Location.River | Location.Camp | Location.Farm | Location.BarnInterior);
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Combine(travelZone.OnTravelZoneTo, new Action<int>(OnLocalPlayerEntersCastle));
	}

	private Vector2 DIMHIDKJAKB()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		return Vector2.op_Implicit(((Component)TheloniusNPC.GGFJGHHHEJC).transform.position + new Vector3((float)Random.Range(-2, 2), (float)Random.Range(-2, -1)));
	}

	public void BLOFKKGGBPE()
	{
		Debug.Log((object)("LE_13" + isActor));
		LucenNPC lucenNPC = LucenNPC.MOAKANGAMBA();
		lucenNPC.WalkToCompleted = (Action)Delegate.Remove(lucenNPC.WalkToCompleted, new Action(MNBDLNGMBBN));
		LucenNPC.BNBMNOMFFBE().barkDialogue = true;
		LucenNPC.LPFNKEOJJKE().mouseUpTrigger = true;
		EDGDFPPKGDL = LucenNPC.BNDNMBGJEKP();
		MDFALJKHKED = "Sit";
		if (isActor)
		{
			LucenNPC.DFJGHOHPPEL().StartConversation(CJODOOFLLLB, MDFALJKHKED, FLHBPHPKIML: true);
		}
		else if (BCBBDFLOGPP(0))
		{
			((MonoBehaviour)this).StartCoroutine(LucenNPC.POAGAIBEFBF().StartObserverDialogueWhenItIsPossible(0));
		}
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendCastleFormStartLucenDialogue();
		}
	}

	private void DGKEOLGHLHE()
	{
		PlayerInputs.DisableKeyboardInputsAndMovement(1, (MonoBehaviour)(object)this, ANJCLPDCJHL: true);
		PlayerController.OPHDCMJLLEC(1).characterAnimation.SetDirection(Direction.Right);
		((MonoBehaviour)this).StartCoroutine(KCDGBBIACHP());
		if (Object.op_Implicit((Object)(object)EDGDFPPKGDL))
		{
			((MonoBehaviour)this).StartCoroutine(EDGDFPPKGDL.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	private Vector2 HPNFICDFFGN()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		return Vector2.op_Implicit(((Component)TheloniusNPC.EKDNJDJHONF()).transform.position + new Vector3((float)Random.Range(106, 4), (float)Random.Range(-28, -1)));
	}

	public void NLNFIOMGEFL(int ABAIKKGKDGD)
	{
		SceneReferences.instance.interactableForms[ABAIKKGKDGD].SetFormMade(JALCAHLNPOF: false, CDPAMNIPPEC: false);
	}

	private IEnumerator IJBFIECIOAB()
	{
		MusicController.instance.FadeOutClip(2f, MMEHJCGGNFE: true);
		yield return CommonReferences.wait2;
		MusicController.instance.TriggerMusicTheme(27);
	}

	public void BJBACDIIPPI()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		LucenNPC.EFPJLFMBPLL().content.gameObject.SetActive(false);
		EDGDFPPKGDL = null;
		if (OnlineManager.MasterOrOffline())
		{
			((Component)LucenNPC.NHKAFANMEJC()).transform.position = Vector2.op_Implicit(new Vector2(986f, 1869f));
			LucenNPC.DFJGHOHPPEL().MMAAOFHFPNP(new Vector2(60f, 216f), (Direction)8);
			LucenNPC lucenNPC = LucenNPC.KPDFIEMDDCL();
			lucenNPC.WalkToCompleted = (Action)Delegate.Combine(lucenNPC.WalkToCompleted, new Action(StartLucenDialogue));
		}
		if (isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendCastleFormStartLucenEvent();
		}
	}

	private void OHNGEMFGBAE()
	{
		PlayerInputs.LPJCFCODNFA(0, (MonoBehaviour)(object)this);
		PlayerController.GetPlayer(1).characterAnimation.SetDirection((Direction)5);
		((MonoBehaviour)this).StartCoroutine(GNFOEPFJHGA());
		if (Object.op_Implicit((Object)(object)EDGDFPPKGDL))
		{
			((MonoBehaviour)this).StartCoroutine(EDGDFPPKGDL.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	public void KCHBHKPJKFB(int JIIGOACEIKL, bool GFNHAMCPEAK = true)
	{
		CJODOOFLLLB = JIIGOACEIKL;
		StartEvent(GFNHAMCPEAK, CDPAMNIPPEC: false);
	}

	public void OnLocalPlayerEntersCastle(int JIIGOACEIKL)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		Debug.Log((object)("Local Player Entered Castle and started to see castle form event " + JIIGOACEIKL));
		PlayerController.SetDirection(JIIGOACEIKL, Utils.EIDFHLPBICI(Vector2.op_Implicit(localCooperativeCameraPoint.position - ((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position)));
		PlayerInputs.DisableKeyboardInputsAndMovement(JIIGOACEIKL, (MonoBehaviour)(object)this);
		CameraTarget.SetCameraTarget(JIIGOACEIKL, localCooperativeCameraPoint);
	}

	public void MNBDLNGMBBN()
	{
		Debug.Log((object)("Player2" + isActor));
		LucenNPC lucenNPC = LucenNPC.ELGNEJNLBNO();
		lucenNPC.WalkToCompleted = (Action)Delegate.Remove(lucenNPC.WalkToCompleted, new Action(MNBDLNGMBBN));
		LucenNPC.BNDNMBGJEKP().barkDialogue = true;
		LucenNPC.EFPJLFMBPLL().mouseUpTrigger = true;
		EDGDFPPKGDL = LucenNPC.ABDJJBFNLBJ();
		MDFALJKHKED = "No banquet barrel found with drink: ";
		if (isActor)
		{
			LucenNPC.KPDFIEMDDCL().StartConversation(CJODOOFLLLB, MDFALJKHKED, FLHBPHPKIML: true);
		}
		else if (BGEOHHBMDCD(0))
		{
			((MonoBehaviour)this).StartCoroutine(LucenNPC.DFJGHOHPPEL().StartObserverDialogueWhenItIsPossible(0));
		}
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineEventsManager.SendCastleFormStartLucenDialogue();
		}
	}

	private IEnumerator LIGDEANMLOD()
	{
		if (OnlineManager.MasterOrOffline())
		{
			LucenNPC.GGFJGHHHEJC.content.gameObject.SetActive(true);
			LucenNPC.GGFJGHHHEJC.Walk(new Vector2(-929.7708f, 271.2292f), Direction.Right, KEEGDBAAEOG: true);
		}
		EDGDFPPKGDL = null;
		yield return CommonReferences.wait1_5;
		KlaynNPC.instance.barkDialogue = false;
		KlaynNPC.instance.mouseUpTrigger = true;
		EDGDFPPKGDL = KlaynNPC.instance;
		MDFALJKHKED = "LicenciaDeApertura/KlaynDialogue 07";
		if (isActor)
		{
			KlaynNPC.instance.barkDialogue = false;
			KlaynNPC.instance.mouseUpTrigger = true;
			KlaynNPC.instance.StartConversation(CJODOOFLLLB, MDFALJKHKED);
		}
		else if (BCBBDFLOGPP())
		{
			yield return KlaynNPC.instance.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private bool JJPLMMHEDKA(int JIIGOACEIKL = 1)
	{
		return PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA == (Location.Road | Location.River | Location.BarnInterior);
	}

	public void APCLFGOCOPH()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		LucenNPC.BNDNMBGJEKP().content.gameObject.SetActive(true);
		EDGDFPPKGDL = null;
		if (OnlineManager.MasterOrOffline())
		{
			((Component)LucenNPC.DFJGHOHPPEL()).transform.position = Vector2.op_Implicit(new Vector2(682f, 1423f));
			LucenNPC.ELGNEJNLBNO().EJAMGJMEAEM(new Vector2(144f, 1522f));
			LucenNPC lucenNPC = LucenNPC.GGFJGHHHEJC;
			lucenNPC.WalkToCompleted = (Action)Delegate.Combine(lucenNPC.WalkToCompleted, new Action(OHGGBEKIDCH));
		}
		if (isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendCastleFormStartLucenEvent();
		}
	}

	private bool GBLMBCILNBP(int JIIGOACEIKL = 1)
	{
		return PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA == (Location.Tavern | Location.Road | Location.River | Location.Camp | Location.Quarry | Location.BarnInterior);
	}

	private Vector2 NCPBGLOJMAG()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		return Vector2.op_Implicit(((Component)TheloniusNPC.OFLELHKKNKC()).transform.position + new Vector3((float)Random.Range(32, 1), (float)Random.Range(50, -1)));
	}

	public void DPPHGHIPFAN()
	{
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendCastleFormStartKlaynDialogue();
		}
		KlaynNPC klaynNPC = KlaynNPC.instance;
		klaynNPC.WalkToCompleted = (Action)Delegate.Remove(klaynNPC.WalkToCompleted, new Action(NMDEOCHOPEI));
		EDGDFPPKGDL = KlaynNPC.instance;
		MDFALJKHKED = "via End-Segment";
		if (isActor)
		{
			KlaynNPC.instance.barkDialogue = false;
			KlaynNPC.instance.mouseUpTrigger = false;
			KlaynNPC.instance.StartConversation(CJODOOFLLLB, MDFALJKHKED);
		}
		else if (LLDMMGMDMBH())
		{
			DialogueManager.StopAllConversations();
			((MonoBehaviour)this).StartCoroutine(KlaynNPC.instance.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	public void GIDCOMCPOJF(int JIIGOACEIKL, bool GFNHAMCPEAK = true)
	{
		CJODOOFLLLB = JIIGOACEIKL;
		StartEvent(GFNHAMCPEAK, CDPAMNIPPEC: false);
	}

	private bool PLHNMKIIDEL(int JIIGOACEIKL = 1)
	{
		return PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA == ~(Location.Tavern | Location.Road | Location.River | Location.Farm | Location.FarmShop);
	}

	public void KHCLPKIOCGO()
	{
		((MonoBehaviour)instance).StartCoroutine(DPGCIKGBDGO());
		if (isActor && OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.KDDBKGJLHNJ();
		}
	}

	private void LFBOOFFBINN(int JIIGOACEIKL)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera player = FadeCamera.GetPlayer(0);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(BIIEBOCKIOJ));
		FadeCamera.IGMCBPOPNCA(1).LHBLBOONEEC(115f);
		PlayerController.CLEIAKPOGMM(JIIGOACEIKL, Vector2.op_Implicit(EFEAONGJBAH()), ~(Location.Road | Location.Quarry | Location.FarmShop));
		DGKEOLGHLHE();
	}

	private bool LLDMMGMDMBH(int JIIGOACEIKL = 1)
	{
		return PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA == ~(Location.Tavern | Location.Road | Location.River | Location.Quarry);
	}

	private IEnumerator GIGJPCHLKCF()
	{
		return new LBBOKMMKHAN(1)
		{
			_003C_003E4__this = this
		};
	}

	public void PNAPMKKCAFI()
	{
		int jIIGOACEIKL = ((CJODOOFLLLB != 1) ? 1 : 2);
		CameraTarget.DAOIJLBKNPJ(CJODOOFLLLB, localCooperativeCameraPoint);
		if (PLHNMKIIDEL(jIIGOACEIKL))
		{
			GKDDPIOIHJF(jIIGOACEIKL);
			return;
		}
		TravelZone travelZone = TravelZonesManager.OLHBLKIAFOM().IMKJEBFOBKK(Location.Tavern | Location.Road | Location.River | Location.Camp | Location.Quarry | Location.Farm | Location.FarmShop, ~(Location.Tavern | Location.BarnInterior));
		travelZone.OnTravelZoneTo = (Action<int>)Delegate.Combine(travelZone.OnTravelZoneTo, new Action<int>(PAKJIOLCGPO));
	}

	private IEnumerator CEGLFGCGGPJ()
	{
		return new KNBCEIODNKK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator ECPFPGLFELP()
	{
		return new KNBCEIODNKK(1)
		{
			_003C_003E4__this = this
		};
	}

	private bool JIPEKGAJBPA(int JIIGOACEIKL = 1)
	{
		return PlayerController.GetPlayer(JIIGOACEIKL).LEOIMFNKFGA == (Location.Road | Location.Camp | Location.Farm);
	}

	private bool LHDIFJJPNHC(int JIIGOACEIKL = 1)
	{
		return PlayerController.OPHDCMJLLEC(JIIGOACEIKL).LEOIMFNKFGA == ~(Location.Tavern | Location.River | Location.Farm | Location.FarmShop);
	}

	private IEnumerator JMIFKJACIPA()
	{
		return new LBBOKMMKHAN(1)
		{
			_003C_003E4__this = this
		};
	}

	private void CFLOMAFOJHH()
	{
		PlayerInputs.OOOGANAJMBB(1, (MonoBehaviour)(object)this);
		PlayerController.OPHDCMJLLEC(0).characterAnimation.SetDirection((Direction)5);
		((MonoBehaviour)this).StartCoroutine(KCDGBBIACHP());
		if (Object.op_Implicit((Object)(object)EDGDFPPKGDL))
		{
			((MonoBehaviour)this).StartCoroutine(EDGDFPPKGDL.StartObserverDialogueWhenItIsPossible(1));
		}
	}

	public void KDADFKKPNEB(int ABAIKKGKDGD)
	{
		SceneReferences.instance.interactableForms[ABAIKKGKDGD].SetFormMade(JALCAHLNPOF: false, CDPAMNIPPEC: false);
	}

	public void FAANBCAJLPC(int JIIGOACEIKL, bool GFNHAMCPEAK = true)
	{
		CJODOOFLLLB = JIIGOACEIKL;
		StartEvent(GFNHAMCPEAK, CDPAMNIPPEC: false);
	}

	private IEnumerator KPFPHHMIGGI()
	{
		MusicController.instance.FadeOutClip(2f, MMEHJCGGNFE: true);
		yield return CommonReferences.wait2;
		MusicController.instance.TriggerMusicTheme(27);
	}

	public void GMNLPOLMCHB(int ABAIKKGKDGD)
	{
		SceneReferences.instance.interactableForms[ABAIKKGKDGD].JIADLKOLEEP(JALCAHLNPOF: false, CDPAMNIPPEC: true);
	}
}
