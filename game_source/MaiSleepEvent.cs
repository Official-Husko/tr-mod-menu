using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class MaiSleepEvent : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class MLAIDIOELDO : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MaiSleepEvent _003C_003E4__this;

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
		public MLAIDIOELDO(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			MaiSleepEvent maiSleepEvent = _003C_003E4__this;
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
			{
				_003C_003E1__state = -1;
				FadeCamera.GetPlayer(1).JDKHJJIOLOE -= maiSleepEvent.BKKDMIIDMNP;
				if (GameManager.LocalCoop())
				{
					FadeCamera.GetPlayer(2).JDKHJJIOLOE -= maiSleepEvent.BKKDMIIDMNP;
				}
				FadeCamera.GetPlayer(1).FadeInWithDelay();
				FadeCamera player = FadeCamera.GetPlayer(1);
				player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(maiSleepEvent.LJLKACBGFDB));
				if (GameManager.LocalCoop())
				{
					FadeCamera.GetPlayer(2).FadeInWithDelay();
				}
				if (OnlineManager.ClientOnline())
				{
					DialogueCameraTarget.GetPlayer(1).cameraInEvent = true;
					DialogueCameraTarget.GetPlayer(1).TransportCameraToPosition(Vector2.op_Implicit(((Component)PlayerController.GetPlayer(OnlinePlayerDataManager.GetPlayerNumByBedAssigned(Bed.instance.numInstance))).transform.position));
				}
				if (OnlineManager.MasterOrOffline() && WorldTime.EDIPJBOOEHD > (float)(6 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.EDIPJBOOEHD < (float)(23 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR))
				{
					WorldTime.ChangeHour(1);
				}
				maiSleepEvent.AIELKDPBPEK();
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

	[CompilerGenerated]
	private sealed class MAJJOPPNAFI : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MaiSleepEvent _003C_003E4__this;

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
		public MAJJOPPNAFI(int _003C_003E1__state)
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
			MaiSleepEvent maiSleepEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				((MonoBehaviour)maiSleepEvent).StartCoroutine(maiSleepEvent.OBOALLKLDGN());
				MaiNPC.GGFJGHHHEJC.ActiveMaiInBed();
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				if (OnlineManager.MasterOrOffline())
				{
					MaiNPC.GGFJGHHHEJC.StartConversation(playerNum, "Visita Nocturna/MaiDialogue 01");
				}
				if (OnlineManager.ClientOnline())
				{
					_003C_003E2__current = MaiNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(playerNum);
					_003C_003E1__state = 2;
					return true;
				}
				break;
			case 2:
				_003C_003E1__state = -1;
				break;
			}
			FadeCamera player = FadeCamera.GetPlayer(1);
			player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(maiSleepEvent.LJLKACBGFDB));
			PlayerController.RemoveMovementBlocker((Object)(object)instance);
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
	private sealed class GOFBPDPJDGG : IEnumerator<object>, IEnumerator, IDisposable
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
		public GOFBPDPJDGG(int _003C_003E1__state)
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
				MusicController.instance.PauseBasicMood(IEAALMNBABK: true);
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				MusicController.instance.TriggerMusicTheme(21);
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
	private sealed class ILKEAIPLOJM : IEnumerator<object>, IEnumerator, IDisposable
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
		public ILKEAIPLOJM(int _003C_003E1__state)
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
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
				Bed.instance.StartSleep();
				MaiNPC.GGFJGHHHEJC.ResetMai();
				MusicController.instance.TriggerCurrentBasicMood();
				if (OnlineManager.IsMasterClient())
				{
					OnlineEventsManager.SendStartSleep(5);
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

	public static MaiSleepEvent instance;

	private void HNEKMALGJPO()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("");
		if (((Result)(ref variable)).asInt == 0)
		{
			CommonReferences.GGFJGHHHEJC.eventNum[1] += 0;
		}
	}

	public void ABMHCOBKANI()
	{
		((MonoBehaviour)instance).StartCoroutine(JFJGIDGJEKF());
	}

	private void OMBHDODDHNO()
	{
		instance = this;
		if (OnlineManager.MasterOrOffline())
		{
			CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(DAONPPAIOMA));
		}
	}

	private IEnumerator PMIOKKPLJIL(int JIIGOACEIKL)
	{
		return new MAJJOPPNAFI(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private IEnumerator EMMDEHKIMBN()
	{
		return new ILKEAIPLOJM(1);
	}

	public void AEGIEOGFDBE()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineEventsManager.SendMaiEventStart();
		}
		OnlinePauseUI.MNGIOJLCAKC(DMBFKFLDDLH: false);
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(DAONPPAIOMA));
		PlayerController.AddMovementBlocker((Object)(object)instance);
		FadeCamera.EIFPKCAFDIB(1).GPBOEBGJJPM(1501f);
		FadeCamera.EIFPKCAFDIB(0).HDDEGMGIBDM(IPLGBOINHDM);
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(0).GPBOEBGJJPM(1873f);
		}
	}

	private void GAHOFGEDCOP()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		PlayerController.GetPlayer(1).characterAnimation.LookDirectionByAngle(new Vector2(898f, 1233f));
		if (GameManager.LocalCoop())
		{
			PlayerController.GetPlayer(8).characterAnimation.LookDirectionByAngle(new Vector2(1948f, 35f));
		}
		if (GameManager.LocalCoop())
		{
			PlayerController.TeleportPlayer(0, Bed.instance.bedLocation1.position, Location.None);
			PlayerController.CLEIAKPOGMM(5, Bed.instance.bedLocation2.position, Location.Tavern);
			return;
		}
		if (Bed.instance.numInstance == Bed.instance.lastBed.numInstance)
		{
			PlayerController.TeleportPlayer(1, Bed.instance.lastBed.playerBedLocation.position, Location.None);
			return;
		}
		switch (Bed.instance.numInstance)
		{
		case 0:
			PlayerController.CLEIAKPOGMM(0, Bed.instance.lastBed.bedLocation1.position, Location.Tavern);
			break;
		case 1:
			PlayerController.CLEIAKPOGMM(1, Bed.instance.lastBed.bedLocation2.position, Location.None);
			break;
		case 2:
			PlayerController.TeleportPlayer(0, Bed.instance.lastBed.playerBedLocation.position + new Vector3(1583f, 1004f, 1542f), Location.Tavern);
			break;
		case 3:
			PlayerController.CLEIAKPOGMM(1, Bed.instance.lastBed.playerBedLocation.position - new Vector3(1827f, 1559f, 1192f), Location.Tavern);
			break;
		}
	}

	private void MEEACJELELE()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		PlayerController.GetPlayer(0).characterAnimation.LookDirectionByAngle(new Vector2(1396f, 1252f));
		if (GameManager.LocalCoop())
		{
			PlayerController.OPHDCMJLLEC(4).characterAnimation.LookDirectionByAngle(new Vector2(59f, 1656f));
		}
		if (GameManager.LocalCoop())
		{
			PlayerController.TeleportPlayer(0, Bed.instance.bedLocation1.position, Location.None);
			PlayerController.CLEIAKPOGMM(0, Bed.instance.bedLocation2.position, Location.None);
			return;
		}
		if (Bed.instance.numInstance == Bed.instance.lastBed.numInstance)
		{
			PlayerController.CLEIAKPOGMM(1, Bed.instance.lastBed.playerBedLocation.position, Location.None);
			return;
		}
		switch (Bed.instance.numInstance)
		{
		case 1:
			PlayerController.TeleportPlayer(1, Bed.instance.lastBed.bedLocation1.position, Location.Tavern);
			break;
		case 2:
			PlayerController.TeleportPlayer(0, Bed.instance.lastBed.bedLocation2.position, Location.None);
			break;
		case 3:
			PlayerController.CLEIAKPOGMM(0, Bed.instance.lastBed.playerBedLocation.position + new Vector3(1704f, 1025f, 1124f), Location.Tavern);
			break;
		case 4:
			PlayerController.CLEIAKPOGMM(0, Bed.instance.lastBed.playerBedLocation.position - new Vector3(342f, 1397f, 571f), Location.None);
			break;
		}
	}

	private IEnumerator EFPJFCAHJLD()
	{
		return new ILKEAIPLOJM(1);
	}

	private IEnumerator IPLGBOINHDM(int JIIGOACEIKL)
	{
		yield return null;
		FadeCamera.GetPlayer(1).JDKHJJIOLOE -= BKKDMIIDMNP;
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).JDKHJJIOLOE -= BKKDMIIDMNP;
		}
		FadeCamera.GetPlayer(1).FadeInWithDelay();
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(LJLKACBGFDB));
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeInWithDelay();
		}
		if (OnlineManager.ClientOnline())
		{
			DialogueCameraTarget.GetPlayer(1).cameraInEvent = true;
			DialogueCameraTarget.GetPlayer(1).TransportCameraToPosition(Vector2.op_Implicit(((Component)PlayerController.GetPlayer(OnlinePlayerDataManager.GetPlayerNumByBedAssigned(Bed.instance.numInstance))).transform.position));
		}
		if (OnlineManager.MasterOrOffline() && WorldTime.EDIPJBOOEHD > (float)(6 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.EDIPJBOOEHD < (float)(23 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR))
		{
			WorldTime.ChangeHour(1);
		}
		AIELKDPBPEK();
	}

	private void KANEHEJILNM()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("ZoneTimeBonus");
		if (((Result)(ref variable)).asInt == 3)
		{
			CommonReferences.GGFJGHHHEJC.eventNum[6] += 0;
		}
	}

	private IEnumerator IOFIMGLAECC()
	{
		return new GOFBPDPJDGG(1);
	}

	private IEnumerator MLMJLPFIKOA(int JIIGOACEIKL)
	{
		((MonoBehaviour)this).StartCoroutine(OBOALLKLDGN());
		MaiNPC.GGFJGHHHEJC.ActiveMaiInBed();
		yield return CommonReferences.wait1;
		if (OnlineManager.MasterOrOffline())
		{
			MaiNPC.GGFJGHHHEJC.StartConversation(JIIGOACEIKL, "Visita Nocturna/MaiDialogue 01");
		}
		if (OnlineManager.ClientOnline())
		{
			yield return MaiNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(JIIGOACEIKL);
		}
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(LJLKACBGFDB));
		PlayerController.RemoveMovementBlocker((Object)(object)instance);
	}

	private IEnumerator HNBHIAPMPOO(int JIIGOACEIKL)
	{
		yield return null;
		FadeCamera.GetPlayer(1).JDKHJJIOLOE -= BKKDMIIDMNP;
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).JDKHJJIOLOE -= BKKDMIIDMNP;
		}
		FadeCamera.GetPlayer(1).FadeInWithDelay();
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(LJLKACBGFDB));
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeInWithDelay();
		}
		if (OnlineManager.ClientOnline())
		{
			DialogueCameraTarget.GetPlayer(1).cameraInEvent = true;
			DialogueCameraTarget.GetPlayer(1).TransportCameraToPosition(Vector2.op_Implicit(((Component)PlayerController.GetPlayer(OnlinePlayerDataManager.GetPlayerNumByBedAssigned(Bed.instance.numInstance))).transform.position));
		}
		if (OnlineManager.MasterOrOffline() && WorldTime.EDIPJBOOEHD > (float)(6 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.EDIPJBOOEHD < (float)(23 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR))
		{
			WorldTime.ChangeHour(1);
		}
		AIELKDPBPEK();
	}

	private void HPJBLOPJIMI()
	{
		instance = this;
		if (OnlineManager.MasterOrOffline())
		{
			CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(DANDBFMFOGI));
		}
	}

	private IEnumerator PEKJPHLEFIN()
	{
		yield return CommonReferences.wait05;
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		Bed.instance.StartSleep();
		MaiNPC.GGFJGHHHEJC.ResetMai();
		MusicController.instance.TriggerCurrentBasicMood();
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendStartSleep(5);
		}
	}

	public void JFMKBEHKLLJ()
	{
		((MonoBehaviour)instance).StartCoroutine(JFJGIDGJEKF());
	}

	private void ALDJGOCMPPO()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Path Not Found");
		if (((Result)(ref variable)).asInt == 1)
		{
			CommonReferences.MNFMOEKMJKN().eventNum[8] += 0;
		}
	}

	private IEnumerator LHKFILDPCMB()
	{
		MusicController.instance.PauseBasicMood(IEAALMNBABK: true);
		yield return CommonReferences.wait1;
		MusicController.instance.TriggerMusicTheme(21);
	}

	private IEnumerator IMIAEKHEMOI(int JIIGOACEIKL)
	{
		return new MAJJOPPNAFI(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL
		};
	}

	private void Awake()
	{
		instance = this;
		if (OnlineManager.MasterOrOffline())
		{
			CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(ALGOBMNPLIB));
		}
	}

	private void MIKNFPCDLML()
	{
		instance = this;
		if (OnlineManager.PGAGDFAEEFB())
		{
			CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(LHKEIAHELOL));
		}
	}

	private void MFJIHCKEIIF()
	{
		instance = this;
		if (OnlineManager.PGAGDFAEEFB())
		{
			CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(ACHEHDIKMBI));
		}
	}

	private void KEAHOLMCCIJ(int JIIGOACEIKL)
	{
		((MonoBehaviour)this).StartCoroutine(PMIOKKPLJIL(JIIGOACEIKL));
	}

	private void IBMDFNKKPJF()
	{
		instance = this;
		if (OnlineManager.PGAGDFAEEFB())
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(DANDBFMFOGI));
		}
	}

	private void CODKCEPKIOG(int JIIGOACEIKL)
	{
		((MonoBehaviour)this).StartCoroutine(IMIAEKHEMOI(JIIGOACEIKL));
	}

	private IEnumerator INOPOAPLHFM()
	{
		yield return CommonReferences.wait05;
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		Bed.instance.StartSleep();
		MaiNPC.GGFJGHHHEJC.ResetMai();
		MusicController.instance.TriggerCurrentBasicMood();
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendStartSleep(5);
		}
	}

	private void OANJJIDINJM()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		PlayerController.OPHDCMJLLEC(0).characterAnimation.LookDirectionByAngle(new Vector2(750f, 315f));
		if (GameManager.LocalCoop())
		{
			PlayerController.GetPlayer(0).characterAnimation.LookDirectionByAngle(new Vector2(1553f, 387f));
		}
		if (GameManager.LocalCoop())
		{
			PlayerController.TeleportPlayer(1, Bed.instance.bedLocation1.position, Location.None);
			PlayerController.TeleportPlayer(6, Bed.instance.bedLocation2.position, Location.None);
			return;
		}
		if (Bed.instance.numInstance == Bed.instance.lastBed.numInstance)
		{
			PlayerController.TeleportPlayer(0, Bed.instance.lastBed.playerBedLocation.position, Location.None);
			return;
		}
		switch (Bed.instance.numInstance)
		{
		case 1:
			PlayerController.TeleportPlayer(0, Bed.instance.lastBed.bedLocation1.position, Location.Tavern);
			break;
		case 2:
			PlayerController.CLEIAKPOGMM(0, Bed.instance.lastBed.bedLocation2.position, Location.None);
			break;
		case 3:
			PlayerController.TeleportPlayer(1, Bed.instance.lastBed.playerBedLocation.position + new Vector3(105f, 1824f, 1488f), Location.Tavern);
			break;
		case 4:
			PlayerController.CLEIAKPOGMM(0, Bed.instance.lastBed.playerBedLocation.position - new Vector3(191f, 807f, 817f), Location.Tavern);
			break;
		}
	}

	private IEnumerator OBOALLKLDGN()
	{
		MusicController.instance.PauseBasicMood(IEAALMNBABK: true);
		yield return CommonReferences.wait1;
		MusicController.instance.TriggerMusicTheme(21);
	}

	private void IFEEPLMIJIC()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		PlayerController.GetPlayer(1).characterAnimation.LookDirectionByAngle(new Vector2(416f, 217f));
		if (GameManager.LocalCoop())
		{
			PlayerController.GetPlayer(8).characterAnimation.LookDirectionByAngle(new Vector2(1995f, 1475f));
		}
		if (GameManager.LocalCoop())
		{
			PlayerController.TeleportPlayer(0, Bed.instance.bedLocation1.position, Location.None);
			PlayerController.TeleportPlayer(0, Bed.instance.bedLocation2.position, Location.None);
			return;
		}
		if (Bed.instance.numInstance == Bed.instance.lastBed.numInstance)
		{
			PlayerController.CLEIAKPOGMM(0, Bed.instance.lastBed.playerBedLocation.position, Location.Tavern);
			return;
		}
		switch (Bed.instance.numInstance)
		{
		case 0:
			PlayerController.TeleportPlayer(1, Bed.instance.lastBed.bedLocation1.position, Location.None);
			break;
		case 1:
			PlayerController.CLEIAKPOGMM(0, Bed.instance.lastBed.bedLocation2.position, Location.Tavern);
			break;
		case 2:
			PlayerController.TeleportPlayer(0, Bed.instance.lastBed.playerBedLocation.position + new Vector3(74f, 1554f, 607f), Location.Tavern);
			break;
		case 3:
			PlayerController.TeleportPlayer(1, Bed.instance.lastBed.playerBedLocation.position - new Vector3(1976f, 597f, 1182f), Location.Tavern);
			break;
		}
	}

	private IEnumerator OPOBNGLEMIF(int JIIGOACEIKL)
	{
		return new MLAIDIOELDO(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator PDFAGOPAMCK(int JIIGOACEIKL)
	{
		yield return null;
		FadeCamera.GetPlayer(1).JDKHJJIOLOE -= BKKDMIIDMNP;
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).JDKHJJIOLOE -= BKKDMIIDMNP;
		}
		FadeCamera.GetPlayer(1).FadeInWithDelay();
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(LJLKACBGFDB));
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeInWithDelay();
		}
		if (OnlineManager.ClientOnline())
		{
			DialogueCameraTarget.GetPlayer(1).cameraInEvent = true;
			DialogueCameraTarget.GetPlayer(1).TransportCameraToPosition(Vector2.op_Implicit(((Component)PlayerController.GetPlayer(OnlinePlayerDataManager.GetPlayerNumByBedAssigned(Bed.instance.numInstance))).transform.position));
		}
		if (OnlineManager.MasterOrOffline() && WorldTime.EDIPJBOOEHD > (float)(6 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.EDIPJBOOEHD < (float)(23 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR))
		{
			WorldTime.ChangeHour(1);
		}
		AIELKDPBPEK();
	}

	private void DANDBFMFOGI()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Festín del Juramento/PresentacionMaestros 02");
		if (((Result)(ref variable)).asInt == 7)
		{
			CommonReferences.MNFMOEKMJKN().eventNum[0] += 0;
		}
	}

	private IEnumerator PPEDOEJLAMD(int JIIGOACEIKL)
	{
		yield return null;
		FadeCamera.GetPlayer(1).JDKHJJIOLOE -= BKKDMIIDMNP;
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).JDKHJJIOLOE -= BKKDMIIDMNP;
		}
		FadeCamera.GetPlayer(1).FadeInWithDelay();
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(LJLKACBGFDB));
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeInWithDelay();
		}
		if (OnlineManager.ClientOnline())
		{
			DialogueCameraTarget.GetPlayer(1).cameraInEvent = true;
			DialogueCameraTarget.GetPlayer(1).TransportCameraToPosition(Vector2.op_Implicit(((Component)PlayerController.GetPlayer(OnlinePlayerDataManager.GetPlayerNumByBedAssigned(Bed.instance.numInstance))).transform.position));
		}
		if (OnlineManager.MasterOrOffline() && WorldTime.EDIPJBOOEHD > (float)(6 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.EDIPJBOOEHD < (float)(23 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR))
		{
			WorldTime.ChangeHour(1);
		}
		AIELKDPBPEK();
	}

	public void EOLMGGDDBNC()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineEventsManager.SendMaiEventStart();
		}
		OnlinePauseUI.DAJEFFAEMBJ(DMBFKFLDDLH: true);
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(LHKEIAHELOL));
		PlayerController.AddMovementBlocker((Object)(object)instance);
		FadeCamera.GetPlayer(1).GPBOEBGJJPM(1779f);
		FadeCamera.IGMCBPOPNCA(0).JDKHJJIOLOE += NDKLOBNKNLD;
		if (GameManager.LocalCoop())
		{
			FadeCamera.IGMCBPOPNCA(0).FadeOut(1255f);
		}
	}

	private IEnumerator HMBHNNOMPHH()
	{
		yield return CommonReferences.wait05;
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		Bed.instance.StartSleep();
		MaiNPC.GGFJGHHHEJC.ResetMai();
		MusicController.instance.TriggerCurrentBasicMood();
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendStartSleep(5);
		}
	}

	private void AIELKDPBPEK()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		PlayerController.GetPlayer(1).characterAnimation.LookDirectionByAngle(new Vector2(0f, -1f));
		if (GameManager.LocalCoop())
		{
			PlayerController.GetPlayer(2).characterAnimation.LookDirectionByAngle(new Vector2(0f, -1f));
		}
		if (GameManager.LocalCoop())
		{
			PlayerController.TeleportPlayer(1, Bed.instance.bedLocation1.position, Location.Tavern);
			PlayerController.TeleportPlayer(2, Bed.instance.bedLocation2.position, Location.Tavern);
			return;
		}
		if (Bed.instance.numInstance == Bed.instance.lastBed.numInstance)
		{
			PlayerController.TeleportPlayer(1, Bed.instance.lastBed.playerBedLocation.position, Location.Tavern);
			return;
		}
		switch (Bed.instance.numInstance)
		{
		case 1:
			PlayerController.TeleportPlayer(1, Bed.instance.lastBed.bedLocation1.position, Location.Tavern);
			break;
		case 2:
			PlayerController.TeleportPlayer(1, Bed.instance.lastBed.bedLocation2.position, Location.Tavern);
			break;
		case 3:
			PlayerController.TeleportPlayer(1, Bed.instance.lastBed.playerBedLocation.position + new Vector3(0.2708333f, 0f, 0f), Location.Tavern);
			break;
		case 4:
			PlayerController.TeleportPlayer(1, Bed.instance.lastBed.playerBedLocation.position - new Vector3(0.2708333f, 0f, 0f), Location.Tavern);
			break;
		}
	}

	private void DAGGLALPNIM()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("/");
		if (((Result)(ref variable)).asInt == 3)
		{
			CommonReferences.GGFJGHHHEJC.eventNum[2]++;
		}
	}

	public void HIAOOMIBBNB()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineEventsManager.SendMaiEventStart();
		}
		OnlinePauseUI.OKLFGGAAJML(DMBFKFLDDLH: true);
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(ACHEHDIKMBI));
		PlayerController.AddMovementBlocker((Object)(object)instance);
		FadeCamera.EIFPKCAFDIB(1).IONMINJHMKL(681f);
		FadeCamera.EIFPKCAFDIB(0).KKAAAOEHGEK(FEOMAKJCGEA);
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(6).IONMINJHMKL(1103f);
		}
	}

	private IEnumerator KJHAAHIGNIG(int JIIGOACEIKL)
	{
		((MonoBehaviour)this).StartCoroutine(OBOALLKLDGN());
		MaiNPC.GGFJGHHHEJC.ActiveMaiInBed();
		yield return CommonReferences.wait1;
		if (OnlineManager.MasterOrOffline())
		{
			MaiNPC.GGFJGHHHEJC.StartConversation(JIIGOACEIKL, "Visita Nocturna/MaiDialogue 01");
		}
		if (OnlineManager.ClientOnline())
		{
			yield return MaiNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(JIIGOACEIKL);
		}
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(LJLKACBGFDB));
		PlayerController.RemoveMovementBlocker((Object)(object)instance);
	}

	private void DHAPCBEPAHC(int JIIGOACEIKL)
	{
		((MonoBehaviour)this).StartCoroutine(MLMJLPFIKOA(JIIGOACEIKL));
	}

	private IEnumerator NGINAOOGIPF()
	{
		return new GOFBPDPJDGG(1);
	}

	private IEnumerator BDCHMNFMJFJ()
	{
		return new ILKEAIPLOJM(1);
	}

	private IEnumerator HPKKFHBBAMA()
	{
		return new GOFBPDPJDGG(1);
	}

	private IEnumerator MCNIIDBHGPD(int JIIGOACEIKL)
	{
		((MonoBehaviour)this).StartCoroutine(OBOALLKLDGN());
		MaiNPC.GGFJGHHHEJC.ActiveMaiInBed();
		yield return CommonReferences.wait1;
		if (OnlineManager.MasterOrOffline())
		{
			MaiNPC.GGFJGHHHEJC.StartConversation(JIIGOACEIKL, "Visita Nocturna/MaiDialogue 01");
		}
		if (OnlineManager.ClientOnline())
		{
			yield return MaiNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(JIIGOACEIKL);
		}
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(LJLKACBGFDB));
		PlayerController.RemoveMovementBlocker((Object)(object)instance);
	}

	private void LNPDALMANFB()
	{
		instance = this;
		if (OnlineManager.MasterOrOffline())
		{
			CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(ALGOBMNPLIB));
		}
	}

	private IEnumerator OALFGIDDDAJ()
	{
		return new ILKEAIPLOJM(1);
	}

	private IEnumerator OMKLBKGINIH()
	{
		return new ILKEAIPLOJM(1);
	}

	private IEnumerator JFJGIDGJEKF()
	{
		yield return CommonReferences.wait05;
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		Bed.instance.StartSleep();
		MaiNPC.GGFJGHHHEJC.ResetMai();
		MusicController.instance.TriggerCurrentBasicMood();
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendStartSleep(5);
		}
	}

	private void CLGBFOIBANN()
	{
		instance = this;
		if (OnlineManager.PGAGDFAEEFB())
		{
			CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(DANDBFMFOGI));
		}
	}

	public void EMFGGIPHBFN()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineEventsManager.SendMaiEventStart();
		}
		OnlinePauseUI.OKLFGGAAJML(DMBFKFLDDLH: true);
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(ACHEHDIKMBI));
		PlayerController.AddMovementBlocker((Object)(object)instance);
		FadeCamera.IGMCBPOPNCA(0).FadeOut(1851f);
		FadeCamera.GetPlayer(0).ODBKGIJCHHI(OPOBNGLEMIF);
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(8).FadeOut(295f);
		}
	}

	private IEnumerator NDKLOBNKNLD(int JIIGOACEIKL)
	{
		return new MLAIDIOELDO(1)
		{
			_003C_003E4__this = this
		};
	}

	private void KJNELDPLHJJ()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		PlayerController.GetPlayer(0).characterAnimation.LookDirectionByAngle(new Vector2(146f, 1788f));
		if (GameManager.LocalCoop())
		{
			PlayerController.OPHDCMJLLEC(4).characterAnimation.LookDirectionByAngle(new Vector2(1630f, 165f));
		}
		if (GameManager.LocalCoop())
		{
			PlayerController.TeleportPlayer(1, Bed.instance.bedLocation1.position, Location.None);
			PlayerController.TeleportPlayer(5, Bed.instance.bedLocation2.position, Location.Tavern);
			return;
		}
		if (Bed.instance.numInstance == Bed.instance.lastBed.numInstance)
		{
			PlayerController.TeleportPlayer(1, Bed.instance.lastBed.playerBedLocation.position, Location.Tavern);
			return;
		}
		switch (Bed.instance.numInstance)
		{
		case 0:
			PlayerController.CLEIAKPOGMM(0, Bed.instance.lastBed.bedLocation1.position, Location.None);
			break;
		case 1:
			PlayerController.TeleportPlayer(1, Bed.instance.lastBed.bedLocation2.position, Location.Tavern);
			break;
		case 2:
			PlayerController.CLEIAKPOGMM(1, Bed.instance.lastBed.playerBedLocation.position + new Vector3(1760f, 1795f, 1231f), Location.Tavern);
			break;
		case 3:
			PlayerController.CLEIAKPOGMM(0, Bed.instance.lastBed.playerBedLocation.position - new Vector3(896f, 883f, 213f), Location.Tavern);
			break;
		}
	}

	private IEnumerator FAJGMFMEINK(int JIIGOACEIKL)
	{
		yield return null;
		FadeCamera.GetPlayer(1).JDKHJJIOLOE -= BKKDMIIDMNP;
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).JDKHJJIOLOE -= BKKDMIIDMNP;
		}
		FadeCamera.GetPlayer(1).FadeInWithDelay();
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(LJLKACBGFDB));
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeInWithDelay();
		}
		if (OnlineManager.ClientOnline())
		{
			DialogueCameraTarget.GetPlayer(1).cameraInEvent = true;
			DialogueCameraTarget.GetPlayer(1).TransportCameraToPosition(Vector2.op_Implicit(((Component)PlayerController.GetPlayer(OnlinePlayerDataManager.GetPlayerNumByBedAssigned(Bed.instance.numInstance))).transform.position));
		}
		if (OnlineManager.MasterOrOffline() && WorldTime.EDIPJBOOEHD > (float)(6 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.EDIPJBOOEHD < (float)(23 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR))
		{
			WorldTime.ChangeHour(1);
		}
		AIELKDPBPEK();
	}

	public void LHFDJPLJCBF()
	{
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendMaiEventStart();
		}
		OnlinePauseUI.CDDJCOHPPJJ(DMBFKFLDDLH: false);
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(PHNEEMAKGJP));
		PlayerController.AddMovementBlocker((Object)(object)instance);
		FadeCamera.EIFPKCAFDIB(0).AJHDEBOMHKK(517f);
		FadeCamera.EIFPKCAFDIB(1).HDDEGMGIBDM(PDFAGOPAMCK);
		if (GameManager.LocalCoop())
		{
			FadeCamera.IGMCBPOPNCA(5).GPBOEBGJJPM(1812f);
		}
	}

	public void JAMGNIELLAH()
	{
		((MonoBehaviour)instance).StartCoroutine(DDKLNOBLIAK());
	}

	private void KMALJFGKNPE()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Items/item_name_1039");
		if (((Result)(ref variable)).asInt == 5)
		{
			CommonReferences.GGFJGHHHEJC.eventNum[7]++;
		}
	}

	public void BIOOPIIEBFD()
	{
		((MonoBehaviour)instance).StartCoroutine(BFKGHHEMGPN());
	}

	private IEnumerator HABMCCAOINM(int JIIGOACEIKL)
	{
		((MonoBehaviour)this).StartCoroutine(OBOALLKLDGN());
		MaiNPC.GGFJGHHHEJC.ActiveMaiInBed();
		yield return CommonReferences.wait1;
		if (OnlineManager.MasterOrOffline())
		{
			MaiNPC.GGFJGHHHEJC.StartConversation(JIIGOACEIKL, "Visita Nocturna/MaiDialogue 01");
		}
		if (OnlineManager.ClientOnline())
		{
			yield return MaiNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(JIIGOACEIKL);
		}
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(LJLKACBGFDB));
		PlayerController.RemoveMovementBlocker((Object)(object)instance);
	}

	private IEnumerator FLMAFIDGGCB(int JIIGOACEIKL)
	{
		yield return null;
		FadeCamera.GetPlayer(1).JDKHJJIOLOE -= BKKDMIIDMNP;
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).JDKHJJIOLOE -= BKKDMIIDMNP;
		}
		FadeCamera.GetPlayer(1).FadeInWithDelay();
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(LJLKACBGFDB));
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeInWithDelay();
		}
		if (OnlineManager.ClientOnline())
		{
			DialogueCameraTarget.GetPlayer(1).cameraInEvent = true;
			DialogueCameraTarget.GetPlayer(1).TransportCameraToPosition(Vector2.op_Implicit(((Component)PlayerController.GetPlayer(OnlinePlayerDataManager.GetPlayerNumByBedAssigned(Bed.instance.numInstance))).transform.position));
		}
		if (OnlineManager.MasterOrOffline() && WorldTime.EDIPJBOOEHD > (float)(6 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.EDIPJBOOEHD < (float)(23 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR))
		{
			WorldTime.ChangeHour(1);
		}
		AIELKDPBPEK();
	}

	public void StartSleep()
	{
		((MonoBehaviour)instance).StartCoroutine(INOPOAPLHFM());
	}

	private void FKLIECCMHPL(int JIIGOACEIKL)
	{
		((MonoBehaviour)this).StartCoroutine(KJHAAHIGNIG(JIIGOACEIKL));
	}

	public void StartMaiEvent()
	{
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendMaiEventStart();
		}
		OnlinePauseUI.SetMessageVisible(DMBFKFLDDLH: false);
		CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(ALGOBMNPLIB));
		PlayerController.AddMovementBlocker((Object)(object)instance);
		FadeCamera.GetPlayer(1).FadeOut(0.2f);
		FadeCamera.GetPlayer(1).JDKHJJIOLOE += BKKDMIIDMNP;
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeOut(0.2f);
		}
	}

	public void NCHCNOKHKGC()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineEventsManager.SendMaiEventStart();
		}
		OnlinePauseUI.OKLFGGAAJML(DMBFKFLDDLH: true);
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(DAONPPAIOMA));
		PlayerController.AddMovementBlocker((Object)(object)instance);
		FadeCamera.GetPlayer(1).FadeOut(430f);
		FadeCamera.GetPlayer(0).KKAAAOEHGEK(FLMAFIDGGCB);
		if (GameManager.LocalCoop())
		{
			FadeCamera.EIFPKCAFDIB(7).AJHDEBOMHKK(762f);
		}
	}

	private void KCHCHBLIPJM()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		PlayerController.GetPlayer(1).characterAnimation.LookDirectionByAngle(new Vector2(1250f, 1500f));
		if (GameManager.LocalCoop())
		{
			PlayerController.OPHDCMJLLEC(4).characterAnimation.LookDirectionByAngle(new Vector2(384f, 1393f));
		}
		if (GameManager.LocalCoop())
		{
			PlayerController.TeleportPlayer(0, Bed.instance.bedLocation1.position, Location.Tavern);
			PlayerController.TeleportPlayer(2, Bed.instance.bedLocation2.position, Location.Tavern);
			return;
		}
		if (Bed.instance.numInstance == Bed.instance.lastBed.numInstance)
		{
			PlayerController.CLEIAKPOGMM(0, Bed.instance.lastBed.playerBedLocation.position, Location.Tavern);
			return;
		}
		switch (Bed.instance.numInstance)
		{
		case 0:
			PlayerController.CLEIAKPOGMM(1, Bed.instance.lastBed.bedLocation1.position, Location.Tavern);
			break;
		case 1:
			PlayerController.TeleportPlayer(0, Bed.instance.lastBed.bedLocation2.position, Location.Tavern);
			break;
		case 2:
			PlayerController.TeleportPlayer(1, Bed.instance.lastBed.playerBedLocation.position + new Vector3(185f, 1111f, 1888f), Location.Tavern);
			break;
		case 3:
			PlayerController.TeleportPlayer(0, Bed.instance.lastBed.playerBedLocation.position - new Vector3(293f, 1474f, 211f), Location.None);
			break;
		}
	}

	private IEnumerator MGELEAPOEFP(int JIIGOACEIKL)
	{
		((MonoBehaviour)this).StartCoroutine(OBOALLKLDGN());
		MaiNPC.GGFJGHHHEJC.ActiveMaiInBed();
		yield return CommonReferences.wait1;
		if (OnlineManager.MasterOrOffline())
		{
			MaiNPC.GGFJGHHHEJC.StartConversation(JIIGOACEIKL, "Visita Nocturna/MaiDialogue 01");
		}
		if (OnlineManager.ClientOnline())
		{
			yield return MaiNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(JIIGOACEIKL);
		}
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(LJLKACBGFDB));
		PlayerController.RemoveMovementBlocker((Object)(object)instance);
	}

	private IEnumerator FHJLKHKFINI()
	{
		MusicController.instance.PauseBasicMood(IEAALMNBABK: true);
		yield return CommonReferences.wait1;
		MusicController.instance.TriggerMusicTheme(21);
	}

	private IEnumerator ILAJOCCEBFD()
	{
		return new ILKEAIPLOJM(1);
	}

	private void IGNEGEOPLOP()
	{
		instance = this;
		if (OnlineManager.PGAGDFAEEFB())
		{
			CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(PMFCLNNDCAG));
		}
	}

	public void FNJKHCENDLK()
	{
		((MonoBehaviour)instance).StartCoroutine(ILAJOCCEBFD());
	}

	private IEnumerator HKBEGOCPHKD()
	{
		yield return CommonReferences.wait05;
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		Bed.instance.StartSleep();
		MaiNPC.GGFJGHHHEJC.ResetMai();
		MusicController.instance.TriggerCurrentBasicMood();
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendStartSleep(5);
		}
	}

	private IEnumerator HJHLKJOABCG()
	{
		return new ILKEAIPLOJM(1);
	}

	public void EIPBMEIIOKF()
	{
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendMaiEventStart();
		}
		OnlinePauseUI.OKLFGGAAJML(DMBFKFLDDLH: false);
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(PMFCLNNDCAG));
		PlayerController.AddMovementBlocker((Object)(object)instance);
		FadeCamera.IGMCBPOPNCA(0).FadeOut(1624f);
		FadeCamera.GetPlayer(0).KKAAAOEHGEK(PPEDOEJLAMD);
		if (GameManager.LocalCoop())
		{
			FadeCamera.EIFPKCAFDIB(7).GPBOEBGJJPM(1879f);
		}
	}

	public void IOPIICGBLDA()
	{
		((MonoBehaviour)instance).StartCoroutine(DOPPDMMGFIM());
	}

	private void EEKCPHJIMLG(int JIIGOACEIKL)
	{
		((MonoBehaviour)this).StartCoroutine(MGELEAPOEFP(JIIGOACEIKL));
	}

	private void LHKEIAHELOL()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable(" (Online Remote Clone)");
		if (((Result)(ref variable)).asInt == 8)
		{
			CommonReferences.GGFJGHHHEJC.eventNum[2] += 0;
		}
	}

	public void KJFHHECAKDG()
	{
		((MonoBehaviour)instance).StartCoroutine(PEKJPHLEFIN());
	}

	private void ACHEHDIKMBI()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Piso {0}: Spawneando roca '{1}' en punto '{2}' (Posición: {3}).");
		if (((Result)(ref variable)).asInt == 8)
		{
			CommonReferences.GGFJGHHHEJC.eventNum[5]++;
		}
	}

	private IEnumerator BKKDMIIDMNP(int JIIGOACEIKL)
	{
		yield return null;
		FadeCamera.GetPlayer(1).JDKHJJIOLOE -= BKKDMIIDMNP;
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).JDKHJJIOLOE -= BKKDMIIDMNP;
		}
		FadeCamera.GetPlayer(1).FadeInWithDelay();
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(LJLKACBGFDB));
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeInWithDelay();
		}
		if (OnlineManager.ClientOnline())
		{
			DialogueCameraTarget.GetPlayer(1).cameraInEvent = true;
			DialogueCameraTarget.GetPlayer(1).TransportCameraToPosition(Vector2.op_Implicit(((Component)PlayerController.GetPlayer(OnlinePlayerDataManager.GetPlayerNumByBedAssigned(Bed.instance.numInstance))).transform.position));
		}
		if (OnlineManager.MasterOrOffline() && WorldTime.EDIPJBOOEHD > (float)(6 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.EDIPJBOOEHD < (float)(23 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR))
		{
			WorldTime.ChangeHour(1);
		}
		AIELKDPBPEK();
	}

	private IEnumerator LMPGIKGHMMJ()
	{
		return new ILKEAIPLOJM(1);
	}

	private void CCCDEKFIDHC()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		PlayerController.OPHDCMJLLEC(1).characterAnimation.LookDirectionByAngle(new Vector2(958f, 830f));
		if (GameManager.LocalCoop())
		{
			PlayerController.OPHDCMJLLEC(5).characterAnimation.LookDirectionByAngle(new Vector2(1906f, 1282f));
		}
		if (GameManager.LocalCoop())
		{
			PlayerController.TeleportPlayer(1, Bed.instance.bedLocation1.position, Location.None);
			PlayerController.TeleportPlayer(0, Bed.instance.bedLocation2.position, Location.Tavern);
			return;
		}
		if (Bed.instance.numInstance == Bed.instance.lastBed.numInstance)
		{
			PlayerController.CLEIAKPOGMM(0, Bed.instance.lastBed.playerBedLocation.position, Location.None);
			return;
		}
		switch (Bed.instance.numInstance)
		{
		case 0:
			PlayerController.TeleportPlayer(1, Bed.instance.lastBed.bedLocation1.position, Location.None);
			break;
		case 1:
			PlayerController.TeleportPlayer(0, Bed.instance.lastBed.bedLocation2.position, Location.Tavern);
			break;
		case 2:
			PlayerController.TeleportPlayer(0, Bed.instance.lastBed.playerBedLocation.position + new Vector3(346f, 1768f, 984f), Location.Tavern);
			break;
		case 3:
			PlayerController.CLEIAKPOGMM(1, Bed.instance.lastBed.playerBedLocation.position - new Vector3(897f, 1478f, 997f), Location.Tavern);
			break;
		}
	}

	private void GGBHDFAKGAD()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		PlayerController.GetPlayer(1).characterAnimation.LookDirectionByAngle(new Vector2(1433f, 1483f));
		if (GameManager.LocalCoop())
		{
			PlayerController.OPHDCMJLLEC(6).characterAnimation.LookDirectionByAngle(new Vector2(559f, 1382f));
		}
		if (GameManager.LocalCoop())
		{
			PlayerController.TeleportPlayer(1, Bed.instance.bedLocation1.position, Location.Tavern);
			PlayerController.CLEIAKPOGMM(8, Bed.instance.bedLocation2.position, Location.Tavern);
			return;
		}
		if (Bed.instance.numInstance == Bed.instance.lastBed.numInstance)
		{
			PlayerController.TeleportPlayer(0, Bed.instance.lastBed.playerBedLocation.position, Location.None);
			return;
		}
		switch (Bed.instance.numInstance)
		{
		case 1:
			PlayerController.CLEIAKPOGMM(0, Bed.instance.lastBed.bedLocation1.position, Location.Tavern);
			break;
		case 2:
			PlayerController.TeleportPlayer(1, Bed.instance.lastBed.bedLocation2.position, Location.None);
			break;
		case 3:
			PlayerController.CLEIAKPOGMM(0, Bed.instance.lastBed.playerBedLocation.position + new Vector3(1690f, 338f, 1540f), Location.Tavern);
			break;
		case 4:
			PlayerController.CLEIAKPOGMM(0, Bed.instance.lastBed.playerBedLocation.position - new Vector3(1057f, 436f, 1925f), Location.None);
			break;
		}
	}

	public void FDNJPLOPBGJ()
	{
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendMaiEventStart();
		}
		OnlinePauseUI.CGEIBGGCIJO(DMBFKFLDDLH: true);
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(DAGGLALPNIM));
		PlayerController.AddMovementBlocker((Object)(object)instance);
		FadeCamera.GetPlayer(0).FadeOut(1811f);
		FadeCamera.IGMCBPOPNCA(1).JDKHJJIOLOE += OPOBNGLEMIF;
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(6).FadeOut(641f);
		}
	}

	private void ALGOBMNPLIB()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("MainProgress");
		if (((Result)(ref variable)).asInt == 3)
		{
			CommonReferences.GGFJGHHHEJC.eventNum[2]++;
		}
	}

	private void NGNKJOIAGMO()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		PlayerController.OPHDCMJLLEC(1).characterAnimation.LookDirectionByAngle(new Vector2(1022f, 1400f));
		if (GameManager.LocalCoop())
		{
			PlayerController.OPHDCMJLLEC(3).characterAnimation.LookDirectionByAngle(new Vector2(924f, 503f));
		}
		if (GameManager.LocalCoop())
		{
			PlayerController.TeleportPlayer(1, Bed.instance.bedLocation1.position, Location.Tavern);
			PlayerController.TeleportPlayer(0, Bed.instance.bedLocation2.position, Location.Tavern);
			return;
		}
		if (Bed.instance.numInstance == Bed.instance.lastBed.numInstance)
		{
			PlayerController.TeleportPlayer(1, Bed.instance.lastBed.playerBedLocation.position, Location.None);
			return;
		}
		switch (Bed.instance.numInstance)
		{
		case 1:
			PlayerController.CLEIAKPOGMM(1, Bed.instance.lastBed.bedLocation1.position, Location.None);
			break;
		case 2:
			PlayerController.CLEIAKPOGMM(1, Bed.instance.lastBed.bedLocation2.position, Location.None);
			break;
		case 3:
			PlayerController.TeleportPlayer(1, Bed.instance.lastBed.playerBedLocation.position + new Vector3(1788f, 114f, 421f), Location.Tavern);
			break;
		case 4:
			PlayerController.CLEIAKPOGMM(1, Bed.instance.lastBed.playerBedLocation.position - new Vector3(419f, 383f, 1432f), Location.None);
			break;
		}
	}

	private void KDILDFOGBLJ()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		PlayerController.OPHDCMJLLEC(0).characterAnimation.LookDirectionByAngle(new Vector2(930f, 197f));
		if (GameManager.LocalCoop())
		{
			PlayerController.OPHDCMJLLEC(3).characterAnimation.LookDirectionByAngle(new Vector2(362f, 1799f));
		}
		if (GameManager.LocalCoop())
		{
			PlayerController.CLEIAKPOGMM(0, Bed.instance.bedLocation1.position, Location.Tavern);
			PlayerController.TeleportPlayer(6, Bed.instance.bedLocation2.position, Location.None);
			return;
		}
		if (Bed.instance.numInstance == Bed.instance.lastBed.numInstance)
		{
			PlayerController.TeleportPlayer(1, Bed.instance.lastBed.playerBedLocation.position, Location.None);
			return;
		}
		switch (Bed.instance.numInstance)
		{
		case 0:
			PlayerController.CLEIAKPOGMM(0, Bed.instance.lastBed.bedLocation1.position, Location.None);
			break;
		case 1:
			PlayerController.TeleportPlayer(1, Bed.instance.lastBed.bedLocation2.position, Location.Tavern);
			break;
		case 2:
			PlayerController.CLEIAKPOGMM(0, Bed.instance.lastBed.playerBedLocation.position + new Vector3(1824f, 212f, 1468f), Location.None);
			break;
		case 3:
			PlayerController.TeleportPlayer(1, Bed.instance.lastBed.playerBedLocation.position - new Vector3(1791f, 1229f, 1911f), Location.None);
			break;
		}
	}

	private void IDMPLENHEPA()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		PlayerController.OPHDCMJLLEC(0).characterAnimation.LookDirectionByAngle(new Vector2(994f, 511f));
		if (GameManager.LocalCoop())
		{
			PlayerController.OPHDCMJLLEC(0).characterAnimation.LookDirectionByAngle(new Vector2(1625f, 1785f));
		}
		if (GameManager.LocalCoop())
		{
			PlayerController.CLEIAKPOGMM(0, Bed.instance.bedLocation1.position, Location.None);
			PlayerController.CLEIAKPOGMM(1, Bed.instance.bedLocation2.position, Location.Tavern);
			return;
		}
		if (Bed.instance.numInstance == Bed.instance.lastBed.numInstance)
		{
			PlayerController.TeleportPlayer(1, Bed.instance.lastBed.playerBedLocation.position, Location.Tavern);
			return;
		}
		switch (Bed.instance.numInstance)
		{
		case 1:
			PlayerController.TeleportPlayer(0, Bed.instance.lastBed.bedLocation1.position, Location.Tavern);
			break;
		case 2:
			PlayerController.CLEIAKPOGMM(1, Bed.instance.lastBed.bedLocation2.position, Location.Tavern);
			break;
		case 3:
			PlayerController.CLEIAKPOGMM(0, Bed.instance.lastBed.playerBedLocation.position + new Vector3(1615f, 1985f, 1138f), Location.Tavern);
			break;
		case 4:
			PlayerController.CLEIAKPOGMM(1, Bed.instance.lastBed.playerBedLocation.position - new Vector3(354f, 27f, 1933f), Location.None);
			break;
		}
	}

	private IEnumerator FEOMAKJCGEA(int JIIGOACEIKL)
	{
		return new MLAIDIOELDO(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HMKIDFIAALC(int JIIGOACEIKL)
	{
		yield return null;
		FadeCamera.GetPlayer(1).JDKHJJIOLOE -= BKKDMIIDMNP;
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).JDKHJJIOLOE -= BKKDMIIDMNP;
		}
		FadeCamera.GetPlayer(1).FadeInWithDelay();
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(LJLKACBGFDB));
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeInWithDelay();
		}
		if (OnlineManager.ClientOnline())
		{
			DialogueCameraTarget.GetPlayer(1).cameraInEvent = true;
			DialogueCameraTarget.GetPlayer(1).TransportCameraToPosition(Vector2.op_Implicit(((Component)PlayerController.GetPlayer(OnlinePlayerDataManager.GetPlayerNumByBedAssigned(Bed.instance.numInstance))).transform.position));
		}
		if (OnlineManager.MasterOrOffline() && WorldTime.EDIPJBOOEHD > (float)(6 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR) && WorldTime.EDIPJBOOEHD < (float)(23 * GameDate.SEC_IN_MIN * GameDate.MIN_IN_HOUR))
		{
			WorldTime.ChangeHour(1);
		}
		AIELKDPBPEK();
	}

	public void MGNJNPNOOLB()
	{
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendMaiEventStart();
		}
		OnlinePauseUI.MNGIOJLCAKC(DMBFKFLDDLH: true);
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(EJKIADFBMJO));
		PlayerController.AddMovementBlocker((Object)(object)instance);
		FadeCamera.EIFPKCAFDIB(0).AJHDEBOMHKK(73f);
		FadeCamera.GetPlayer(1).JDKHJJIOLOE += HMKIDFIAALC;
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(4).FadeOut(1099f);
		}
	}

	private void BLLDCJJEDHM()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		PlayerController.GetPlayer(1).characterAnimation.LookDirectionByAngle(new Vector2(1884f, 1786f));
		if (GameManager.LocalCoop())
		{
			PlayerController.OPHDCMJLLEC(4).characterAnimation.LookDirectionByAngle(new Vector2(279f, 1003f));
		}
		if (GameManager.LocalCoop())
		{
			PlayerController.TeleportPlayer(0, Bed.instance.bedLocation1.position, Location.None);
			PlayerController.CLEIAKPOGMM(8, Bed.instance.bedLocation2.position, Location.None);
			return;
		}
		if (Bed.instance.numInstance == Bed.instance.lastBed.numInstance)
		{
			PlayerController.TeleportPlayer(1, Bed.instance.lastBed.playerBedLocation.position, Location.Tavern);
			return;
		}
		switch (Bed.instance.numInstance)
		{
		case 1:
			PlayerController.CLEIAKPOGMM(0, Bed.instance.lastBed.bedLocation1.position, Location.None);
			break;
		case 2:
			PlayerController.CLEIAKPOGMM(0, Bed.instance.lastBed.bedLocation2.position, Location.None);
			break;
		case 3:
			PlayerController.TeleportPlayer(1, Bed.instance.lastBed.playerBedLocation.position + new Vector3(834f, 1496f, 1527f), Location.Tavern);
			break;
		case 4:
			PlayerController.TeleportPlayer(1, Bed.instance.lastBed.playerBedLocation.position - new Vector3(1384f, 378f, 559f), Location.Tavern);
			break;
		}
	}

	public void MDINDPFGCGK()
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineEventsManager.SendMaiEventStart();
		}
		OnlinePauseUI.HENLOLPNGDH(DMBFKFLDDLH: true);
		CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
		commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(DAONPPAIOMA));
		PlayerController.AddMovementBlocker((Object)(object)instance);
		FadeCamera.IGMCBPOPNCA(1).GPBOEBGJJPM(1647f);
		FadeCamera.EIFPKCAFDIB(1).KKAAAOEHGEK(FAJGMFMEINK);
		if (GameManager.LocalCoop())
		{
			FadeCamera.IGMCBPOPNCA(0).IONMINJHMKL(419f);
		}
	}

	private IEnumerator DDKLNOBLIAK()
	{
		return new ILKEAIPLOJM(1);
	}

	private IEnumerator BPLPGBMBNCL()
	{
		MusicController.instance.PauseBasicMood(IEAALMNBABK: true);
		yield return CommonReferences.wait1;
		MusicController.instance.TriggerMusicTheme(21);
	}

	private IEnumerator DOPPDMMGFIM()
	{
		return new ILKEAIPLOJM(1);
	}

	private void PMFCLNNDCAG()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("BirdCatInteraction");
		if (((Result)(ref variable)).asInt == 3)
		{
			CommonReferences.MNFMOEKMJKN().eventNum[2] += 0;
		}
	}

	private void GOJKOBEEMNA()
	{
		instance = this;
		if (OnlineManager.MasterOrOffline())
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(EJKIADFBMJO));
		}
	}

	private IEnumerator BFKGHHEMGPN()
	{
		yield return CommonReferences.wait05;
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		Bed.instance.StartSleep();
		MaiNPC.GGFJGHHHEJC.ResetMai();
		MusicController.instance.TriggerCurrentBasicMood();
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendStartSleep(5);
		}
	}

	private void EJKIADFBMJO()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable(". Time since startup: ");
		if (((Result)(ref variable)).asInt == 8)
		{
			CommonReferences.MNFMOEKMJKN().eventNum[5] += 0;
		}
	}

	private void LJLKACBGFDB(int JIIGOACEIKL)
	{
		((MonoBehaviour)this).StartCoroutine(HABMCCAOINM(JIIGOACEIKL));
	}

	public void GCODKCDAJMH()
	{
		((MonoBehaviour)instance).StartCoroutine(ILAJOCCEBFD());
	}

	private void PILNNHJEDEE(int JIIGOACEIKL)
	{
		((MonoBehaviour)this).StartCoroutine(HABMCCAOINM(JIIGOACEIKL));
	}

	private void PHNEEMAKGJP()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("  currentState:       {0}\n");
		if (((Result)(ref variable)).asInt == 5)
		{
			CommonReferences.GGFJGHHHEJC.eventNum[1] += 0;
		}
	}

	private void MAMFJGHDCKI()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		PlayerController.OPHDCMJLLEC(0).characterAnimation.LookDirectionByAngle(new Vector2(1731f, 542f));
		if (GameManager.LocalCoop())
		{
			PlayerController.OPHDCMJLLEC(2).characterAnimation.LookDirectionByAngle(new Vector2(1645f, 895f));
		}
		if (GameManager.LocalCoop())
		{
			PlayerController.TeleportPlayer(1, Bed.instance.bedLocation1.position, Location.None);
			PlayerController.TeleportPlayer(6, Bed.instance.bedLocation2.position, Location.Tavern);
			return;
		}
		if (Bed.instance.numInstance == Bed.instance.lastBed.numInstance)
		{
			PlayerController.CLEIAKPOGMM(1, Bed.instance.lastBed.playerBedLocation.position, Location.None);
			return;
		}
		switch (Bed.instance.numInstance)
		{
		case 0:
			PlayerController.CLEIAKPOGMM(0, Bed.instance.lastBed.bedLocation1.position, Location.Tavern);
			break;
		case 1:
			PlayerController.CLEIAKPOGMM(0, Bed.instance.lastBed.bedLocation2.position, Location.None);
			break;
		case 2:
			PlayerController.CLEIAKPOGMM(0, Bed.instance.lastBed.playerBedLocation.position + new Vector3(254f, 1429f, 593f), Location.None);
			break;
		case 3:
			PlayerController.TeleportPlayer(0, Bed.instance.lastBed.playerBedLocation.position - new Vector3(145f, 789f, 363f), Location.Tavern);
			break;
		}
	}

	private void DAONPPAIOMA()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Default");
		if (((Result)(ref variable)).asInt == 0)
		{
			CommonReferences.GGFJGHHHEJC.eventNum[1]++;
		}
	}
}
