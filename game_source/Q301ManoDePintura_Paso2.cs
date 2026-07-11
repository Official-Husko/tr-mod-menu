using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using PixelCrushers.DialogueSystem;
using UnityEngine;

[CreateAssetMenu(fileName = "Q301_ManoDePintura_Paso2", menuName = "Missions/Q301_ManoDePintura")]
public class Q301ManoDePintura_Paso2 : MissionBase
{
	[CompilerGenerated]
	private sealed class ILGBEHOLOGL : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Q301ManoDePintura_Paso2 _003C_003E4__this;

		public bool isActor;

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
		public ILGBEHOLOGL(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			Q301ManoDePintura_Paso2 q301ManoDePintura_Paso = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				MainUI.CloseAllUIWindows();
				PlayerInputs.DisableKeyboardInputsAndMovement(1, (MonoBehaviour)(object)MissionsManager.instance);
				if (GameManager.LocalCoop())
				{
					PlayerInputs.DisableKeyboardInputsAndMovement(2, (MonoBehaviour)(object)MissionsManager.instance);
				}
				MaiNPC.GGFJGHHHEJC.canTalk = false;
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 1;
				return true;
			case 1:
			{
				_003C_003E1__state = -1;
				FadeCamera.GetPlayer(1).FadeOut();
				FadeCamera player = FadeCamera.GetPlayer(1);
				player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(q301ManoDePintura_Paso.BHJAOGOGJMN));
				if (GameManager.LocalCoop())
				{
					FadeCamera.GetPlayer(2).FadeOut();
				}
				goto IL_00eb;
			}
			case 2:
				_003C_003E1__state = -1;
				goto IL_00eb;
			case 3:
				_003C_003E1__state = -1;
				FadeCamera.GetPlayer(1).FadeIn();
				if (GameManager.LocalCoop())
				{
					FadeCamera.GetPlayer(2).FadeIn();
				}
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 4;
				return true;
			case 4:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.canTalk = true;
				PlayerInputs.EnableKeyboardInputsAndMovement(1, (MonoBehaviour)(object)MissionsManager.instance);
				if (GameManager.LocalCoop())
				{
					PlayerInputs.EnableKeyboardInputsAndMovement(2, (MonoBehaviour)(object)MissionsManager.instance);
				}
				if (isActor)
				{
					ActiveMission activeMission = MissionsManager.GetActiveMission(q301ManoDePintura_Paso.id);
					MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T300/Dialogue2", activeMission?.triggerPlayerNum ?? 1);
					DialogueLua.SetVariable("MainProgress", (object)1);
					if (OnlineManager.PlayingOnline())
					{
						OnlineDialogueManager instance = OnlineDialogueManager.instance;
						Result variable = DialogueLua.GetVariable("MainProgress");
						instance.SendDialogueInfo("MainProgress", ((Result)(ref variable)).asInt);
					}
					activeMission.LHKIJABBBPM();
				}
				if (OnlineManager.IsMasterClient())
				{
					OnlineManager.OpenRoom();
				}
				if (OnlineManager.PlayingOnline() && !isActor)
				{
					_003C_003E2__current = CommonReferences.wait1;
					_003C_003E1__state = 5;
					return true;
				}
				goto IL_0229;
			case 5:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.StartObserverDialogue(1);
				goto IL_0229;
			case 6:
				{
					_003C_003E1__state = -1;
					CommonReferences.GGFJGHHHEJC.OnTavernRepaired(1);
					return false;
				}
				IL_00eb:
				if (!q301ManoDePintura_Paso.newTavern)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 2;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait6;
				_003C_003E1__state = 3;
				return true;
				IL_0229:
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 6;
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

	[CompilerGenerated]
	private sealed class NJFOIOMPBLF : IEnumerator<object>, IEnumerator, IDisposable
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
		public NJFOIOMPBLF(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.SetParentToNull();
				((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(9f, -14f, 0f);
				_003C_003E2__current = CommonReferences.wait02;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
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

	private bool newTavern;

	public static void GJCHIPCKIAD(bool GFNHAMCPEAK)
	{
		if (OnlineManager.IsMasterClient())
		{
			OnlineManager.DPAPMBHKABN();
		}
		if (GFNHAMCPEAK)
		{
			PlayerInventory.RemoveItems(MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO, -181, 74, CDPAMNIPPEC: false);
			PlayerInventory.IOAIPCDECME(MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO, -95, 21);
			PlayerInventory.IOAIPCDECME(MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO, -131, 4);
		}
		ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(11);
		activeMission.OGHHAGHNOCG(1);
		activeMission.BNGFAGIGJNE(0, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		activeMission.PFNPELJFJKA(0, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		((MonoBehaviour)MissionsManager.instance).StartCoroutine((activeMission.mission as Q301ManoDePintura_Paso2).FOADDIHPLKL(GFNHAMCPEAK));
	}

	public static void ODGNDAJHLMD()
	{
		ADFLMGGLMMI(GFNHAMCPEAK: true);
		if (OnlineManager.PlayingOnline())
		{
			OnlineMissionsManager.instance.SendCompletedQuest301();
		}
	}

	private IEnumerator NONFACDBNGC()
	{
		return new NJFOIOMPBLF(1);
	}

	private void FMDPFGBGDFL(int JIIGOACEIKL)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		TavernBuilding.instance.HJENCOAHCNO();
		NewTutorialManager.instance.MAFAMOJBLFN(DAEMAAOLHMG: false);
		newTavern = false;
		OnlineBedroomsManager.instance.EHKBOMDGDLB(NCCKMIDHPCG: false);
		((MonoBehaviour)MissionsManager.instance).StartCoroutine(JFOPCPAJMDB());
		MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().tavernRepair, ((Component)PlayerController.OPHDCMJLLEC(1)).transform);
		PlayerController.TeleportPlayer(1, new Vector3(306f + (float)Bed.instance.numInstance / 2f, 1364f, 1443f), Location.Road);
		PlayerController.GetPlayer(0).characterAnimation.LookDirection(Direction.Down);
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(POMAIBNEKKB));
		if (GameManager.LocalCoop())
		{
			PlayerController.TeleportPlayer(0, new Vector3(1879f, 613f, 37f), Location.Road);
			PlayerController.GetPlayer(2).characterAnimation.LookDirection(Direction.Down);
		}
	}

	private IEnumerator LBELLEKLPMP()
	{
		MaiNPC.GGFJGHHHEJC.SetParentToNull();
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(9f, -14f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
	}

	private void PHMOCELCKEL(int JIIGOACEIKL)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		TavernBuilding.instance.HJENCOAHCNO();
		NewTutorialManager.instance.ActivateTutorialObjects(DAEMAAOLHMG: true);
		newTavern = false;
		OnlineBedroomsManager.instance.JBMIIEFJMDI(NCCKMIDHPCG: false);
		((MonoBehaviour)MissionsManager.instance).StartCoroutine(JFOPCPAJMDB());
		MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().tavernRepair, ((Component)PlayerController.GetPlayer(1)).transform);
		PlayerController.CLEIAKPOGMM(0, new Vector3(93f + (float)Bed.instance.numInstance / 202f, 275f, 917f), Location.Tavern | Location.River);
		PlayerController.OPHDCMJLLEC(1).characterAnimation.LookDirection(Direction.Down);
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(0);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(HPCKMFNFELA));
		if (GameManager.LocalCoop())
		{
			PlayerController.CLEIAKPOGMM(0, new Vector3(773f, 92f, 1285f), Location.Tavern);
			PlayerController.GetPlayer(1).characterAnimation.LookDirection(Direction.Up);
		}
	}

	public static void FJCPOIBIONH()
	{
		MGHAFMMKFLF(GFNHAMCPEAK: false);
		if (OnlineManager.PlayingOnline())
		{
			OnlineMissionsManager.instance.LNKMIGAAFMM();
		}
	}

	private IEnumerator MIOLEHFCMDN()
	{
		return new NJFOIOMPBLF(1);
	}

	private IEnumerator HGKFAONPGGB(bool GFNHAMCPEAK)
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this,
			isActor = GFNHAMCPEAK
		};
	}

	private IEnumerator LPCPNKEMCNM(bool GFNHAMCPEAK)
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this,
			isActor = GFNHAMCPEAK
		};
	}

	private IEnumerator AFHGHLOCAPA(bool GFNHAMCPEAK)
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this,
			isActor = GFNHAMCPEAK
		};
	}

	private IEnumerator OCCLCKFAILK(bool GFNHAMCPEAK)
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this,
			isActor = GFNHAMCPEAK
		};
	}

	private void HJJNCFCIHCC(int JIIGOACEIKL)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		TavernBuilding.instance.HJENCOAHCNO();
		NewTutorialManager.instance.ActivateTutorialObjects(DAEMAAOLHMG: true);
		newTavern = true;
		OnlineBedroomsManager.instance.LNHMIPCEAKK(NCCKMIDHPCG: false);
		((MonoBehaviour)MissionsManager.instance).StartCoroutine(NONFACDBNGC());
		MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().tavernRepair, ((Component)PlayerController.OPHDCMJLLEC(0)).transform);
		PlayerController.TeleportPlayer(0, new Vector3(427f + (float)Bed.instance.numInstance / 474f, 407f, 1226f), Location.Camp);
		PlayerController.GetPlayer(1).characterAnimation.LookDirection(Direction.Down);
		FadeCamera player = FadeCamera.GetPlayer(0);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(GPGPKOEIEPB));
		if (GameManager.LocalCoop())
		{
			PlayerController.CLEIAKPOGMM(8, new Vector3(1520f, 1619f, 783f), Location.River);
			PlayerController.GetPlayer(7).characterAnimation.LookDirection(Direction.Down);
		}
	}

	private IEnumerator DGKHDFJCJGG()
	{
		return new NJFOIOMPBLF(1);
	}

	private IEnumerator AMNCKCBDBFF()
	{
		MaiNPC.GGFJGHHHEJC.SetParentToNull();
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(9f, -14f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
	}

	public static void NGHAMHMIDDI()
	{
		LJCPJFEJBLG(GFNHAMCPEAK: true);
		if (OnlineManager.PlayingOnline())
		{
			OnlineMissionsManager.instance.CDPABCOEHCH();
		}
	}

	private IEnumerator KEOHIEBPLMF()
	{
		MaiNPC.GGFJGHHHEJC.SetParentToNull();
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(9f, -14f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
	}

	private void ECGAHOEIHJI(int JIIGOACEIKL)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		TavernBuilding.instance.NewTavern();
		NewTutorialManager.instance.ActivateTutorialObjects(DAEMAAOLHMG: false);
		newTavern = false;
		OnlineBedroomsManager.instance.DAFFBIKNJDN(NCCKMIDHPCG: false);
		((MonoBehaviour)MissionsManager.instance).StartCoroutine(NCINDCKKHNJ());
		MultiAudioManager.PlayAudioObject(Sound.MAIDHAPANEB().tavernRepair, ((Component)PlayerController.OPHDCMJLLEC(1)).transform);
		PlayerController.TeleportPlayer(0, new Vector3(1719f + (float)Bed.instance.numInstance / 1431f, 721f, 834f), Location.Tavern | Location.River);
		PlayerController.GetPlayer(1).characterAnimation.LookDirection(Direction.Up);
		FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(1);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(BHJAOGOGJMN));
		if (GameManager.LocalCoop())
		{
			PlayerController.CLEIAKPOGMM(2, new Vector3(629f, 514f, 1120f), Location.Tavern | Location.Road | Location.River);
			PlayerController.OPHDCMJLLEC(0).characterAnimation.LookDirection(Direction.Up);
		}
	}

	private IEnumerator JDJNAEIOJLP(bool GFNHAMCPEAK)
	{
		MainUI.CloseAllUIWindows();
		PlayerInputs.DisableKeyboardInputsAndMovement(1, (MonoBehaviour)(object)MissionsManager.instance);
		if (GameManager.LocalCoop())
		{
			PlayerInputs.DisableKeyboardInputsAndMovement(2, (MonoBehaviour)(object)MissionsManager.instance);
		}
		MaiNPC.GGFJGHHHEJC.canTalk = false;
		yield return CommonReferences.wait2;
		FadeCamera.GetPlayer(1).FadeOut();
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(BHJAOGOGJMN));
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeOut();
		}
		while (!newTavern)
		{
			yield return null;
		}
		yield return CommonReferences.wait6;
		FadeCamera.GetPlayer(1).FadeIn();
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeIn();
		}
		yield return CommonReferences.wait2;
		MaiNPC.GGFJGHHHEJC.canTalk = true;
		PlayerInputs.EnableKeyboardInputsAndMovement(1, (MonoBehaviour)(object)MissionsManager.instance);
		if (GameManager.LocalCoop())
		{
			PlayerInputs.EnableKeyboardInputsAndMovement(2, (MonoBehaviour)(object)MissionsManager.instance);
		}
		if (GFNHAMCPEAK)
		{
			ActiveMission activeMission = MissionsManager.GetActiveMission(id);
			MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T300/Dialogue2", activeMission?.triggerPlayerNum ?? 1);
			DialogueLua.SetVariable("MainProgress", (object)1);
			if (OnlineManager.PlayingOnline())
			{
				OnlineDialogueManager instance = OnlineDialogueManager.instance;
				Result variable = DialogueLua.GetVariable("MainProgress");
				instance.SendDialogueInfo("MainProgress", ((Result)(ref variable)).asInt);
			}
			activeMission.LHKIJABBBPM();
		}
		if (OnlineManager.IsMasterClient())
		{
			OnlineManager.OpenRoom();
		}
		if (OnlineManager.PlayingOnline() && !GFNHAMCPEAK)
		{
			yield return CommonReferences.wait1;
			MaiNPC.GGFJGHHHEJC.StartObserverDialogue(1);
		}
		yield return CommonReferences.wait2;
		CommonReferences.GGFJGHHHEJC.OnTavernRepaired(1);
	}

	public static void EOCLMHCIKJC()
	{
		LJCPJFEJBLG(GFNHAMCPEAK: true);
		if (OnlineManager.PlayingOnline())
		{
			OnlineMissionsManager.instance.CDPABCOEHCH();
		}
	}

	public static void BNLEJLCEMFM()
	{
		JGNBGECEINP(GFNHAMCPEAK: false);
		if (OnlineManager.PlayingOnline())
		{
			OnlineMissionsManager.instance.SendCompletedQuest301();
		}
	}

	public static void FPCBDJNLMKD(bool GFNHAMCPEAK)
	{
		if (OnlineManager.IsMasterClient())
		{
			OnlineManager.DPAPMBHKABN();
		}
		if (GFNHAMCPEAK)
		{
			PlayerInventory.RemoveItems(MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO, -137, 99);
			PlayerInventory.IOAIPCDECME(MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO, -97, 125);
			PlayerInventory.IOAIPCDECME(MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO, -154, 2, CDPAMNIPPEC: false);
		}
		ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(120);
		activeMission.MJJIHGHCDCC(1);
		activeMission.OGHHAGHNOCG(0, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		activeMission.KNOIJBMDJDK(2, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		((MonoBehaviour)MissionsManager.instance).StartCoroutine((activeMission.mission as Q301ManoDePintura_Paso2).MGHHGMLMMJC(GFNHAMCPEAK));
	}

	private IEnumerator AIJLGHJMEIJ()
	{
		MaiNPC.GGFJGHHHEJC.SetParentToNull();
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(9f, -14f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
	}

	private IEnumerator LMHMKPHGFDF()
	{
		MaiNPC.GGFJGHHHEJC.SetParentToNull();
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(9f, -14f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
	}

	private void LPFEFEFJMDI(int JIIGOACEIKL)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		TavernBuilding.instance.HJENCOAHCNO();
		NewTutorialManager.instance.ActivateTutorialObjects(DAEMAAOLHMG: false);
		newTavern = false;
		OnlineBedroomsManager.instance.CheckBedroomsDoor(NCCKMIDHPCG: false);
		((MonoBehaviour)MissionsManager.instance).StartCoroutine(ANEBDLEALHE());
		MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().tavernRepair, ((Component)PlayerController.GetPlayer(0)).transform);
		PlayerController.TeleportPlayer(0, new Vector3(104f + (float)Bed.instance.numInstance / 1001f, 33f, 104f), Location.River);
		PlayerController.GetPlayer(1).characterAnimation.LookDirection(Direction.Down);
		FadeCamera player = FadeCamera.GetPlayer(0);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(HPCKMFNFELA));
		if (GameManager.LocalCoop())
		{
			PlayerController.CLEIAKPOGMM(1, new Vector3(357f, 226f, 202f), Location.Tavern | Location.Road);
			PlayerController.GetPlayer(4).characterAnimation.LookDirection(Direction.Down);
		}
	}

	private IEnumerator DGHEOFDPABM()
	{
		MaiNPC.GGFJGHHHEJC.SetParentToNull();
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(9f, -14f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
	}

	public static void BOKPJNHOOCG()
	{
		OECKOLMGKNO(GFNHAMCPEAK: false);
		if (OnlineManager.PlayingOnline())
		{
			OnlineMissionsManager.instance.MPEAOHPFMIB();
		}
	}

	public static void JNGKJEFBEFI(bool GFNHAMCPEAK)
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineManager.DPAPMBHKABN();
		}
		if (GFNHAMCPEAK)
		{
			PlayerInventory.IOAIPCDECME(MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO, -5, -119, CDPAMNIPPEC: false);
			PlayerInventory.RemoveItems(MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO, 2, -55);
			PlayerInventory.RemoveItems(MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO, 175, 1);
		}
		ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(-158);
		activeMission.KNOIJBMDJDK(0);
		activeMission.BNGFAGIGJNE(0, BLJPGJKOLNF: false);
		activeMission.PFNPELJFJKA(8);
		((MonoBehaviour)MissionsManager.instance).StartCoroutine((activeMission.mission as Q301ManoDePintura_Paso2).KFKGKKAINLL(GFNHAMCPEAK));
	}

	public static void MGHAFMMKFLF(bool GFNHAMCPEAK)
	{
		if (OnlineManager.IsMasterClient())
		{
			OnlineManager.DPAPMBHKABN();
		}
		if (GFNHAMCPEAK)
		{
			PlayerInventory.RemoveItems(MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO, -55, -100);
			PlayerInventory.IOAIPCDECME(MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO, 155, -49, CDPAMNIPPEC: false);
			PlayerInventory.IOAIPCDECME(MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO, -199, 5, CDPAMNIPPEC: false);
		}
		ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(-9);
		activeMission.OGHHAGHNOCG(1);
		activeMission.PFNPELJFJKA(0, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		activeMission.KNOIJBMDJDK(6);
		((MonoBehaviour)MissionsManager.instance).StartCoroutine((activeMission.mission as Q301ManoDePintura_Paso2).MGHHGMLMMJC(GFNHAMCPEAK));
	}

	private IEnumerator BDDLEGHLDEC()
	{
		return new NJFOIOMPBLF(1);
	}

	public static void NINLGIHNGKL(bool GFNHAMCPEAK)
	{
		if (OnlineManager.IsMasterClient())
		{
			OnlineManager.DPAPMBHKABN();
		}
		if (GFNHAMCPEAK)
		{
			PlayerInventory.RemoveItems(MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO, -146, -112, CDPAMNIPPEC: false);
			PlayerInventory.RemoveItems(MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO, -116, -116);
			PlayerInventory.IOAIPCDECME(MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO, 0, 7);
		}
		ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(151);
		activeMission.MJJIHGHCDCC(1, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		activeMission.KNOIJBMDJDK(1, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		activeMission.MJJIHGHCDCC(0, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		((MonoBehaviour)MissionsManager.instance).StartCoroutine((activeMission.mission as Q301ManoDePintura_Paso2).NBENGPAEGCL(GFNHAMCPEAK));
	}

	public static void DFHMMEDFGIJ(bool GFNHAMCPEAK)
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineManager.CloseRoom();
		}
		if (GFNHAMCPEAK)
		{
			PlayerInventory.RemoveItems(MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO, 46, -36, CDPAMNIPPEC: false);
			PlayerInventory.RemoveItems(MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO, 43, -7);
			PlayerInventory.RemoveItems(MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO, -188, 7, CDPAMNIPPEC: false);
		}
		ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(-36);
		activeMission.MJJIHGHCDCC(0, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		activeMission.BNGFAGIGJNE(1, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		activeMission.MJJIHGHCDCC(1, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		((MonoBehaviour)MissionsManager.instance).StartCoroutine((activeMission.mission as Q301ManoDePintura_Paso2).HCKDBDMBMFL(GFNHAMCPEAK));
	}

	private IEnumerator CFGLAPAKKAL(bool GFNHAMCPEAK)
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this,
			isActor = GFNHAMCPEAK
		};
	}

	private void AGEABNAHFKK(int JIIGOACEIKL)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		TavernBuilding.instance.LMDJCCJNGKH();
		NewTutorialManager.instance.ActivateTutorialObjects(DAEMAAOLHMG: true);
		newTavern = false;
		OnlineBedroomsManager.instance.NOFJDHCMGIM(NCCKMIDHPCG: false);
		((MonoBehaviour)MissionsManager.instance).StartCoroutine(LBELLEKLPMP());
		MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().tavernRepair, ((Component)PlayerController.GetPlayer(0)).transform);
		PlayerController.TeleportPlayer(1, new Vector3(779f + (float)Bed.instance.numInstance / 1412f, 213f, 1450f), Location.Road);
		PlayerController.GetPlayer(1).characterAnimation.LookDirection(Direction.Up);
		FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(0);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(FMDPFGBGDFL));
		if (GameManager.LocalCoop())
		{
			PlayerController.CLEIAKPOGMM(6, new Vector3(54f, 1355f, 978f), Location.Tavern);
			PlayerController.GetPlayer(7).characterAnimation.LookDirection(Direction.Down);
		}
	}

	public static void ADFLMGGLMMI(bool GFNHAMCPEAK)
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineManager.CloseRoom();
		}
		if (GFNHAMCPEAK)
		{
			PlayerInventory.RemoveItems(MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO, 55, -19);
			PlayerInventory.RemoveItems(MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO, 174, 105, CDPAMNIPPEC: false);
			PlayerInventory.RemoveItems(MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO, 148, 1);
		}
		ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(-159);
		activeMission.KNOIJBMDJDK(1);
		activeMission.PFNPELJFJKA(1, BLJPGJKOLNF: false);
		activeMission.PFNPELJFJKA(3, BLJPGJKOLNF: false);
		((MonoBehaviour)MissionsManager.instance).StartCoroutine((activeMission.mission as Q301ManoDePintura_Paso2).KBAFIHCCEJG(GFNHAMCPEAK));
	}

	public static void LLMMONIFJBA(bool GFNHAMCPEAK)
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineManager.CloseRoom();
		}
		if (GFNHAMCPEAK)
		{
			PlayerInventory.IOAIPCDECME(MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO, -200, -118, CDPAMNIPPEC: false);
			PlayerInventory.IOAIPCDECME(MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO, 56, 4, CDPAMNIPPEC: false);
			PlayerInventory.IOAIPCDECME(MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO, 88, 0, CDPAMNIPPEC: false);
		}
		ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(-133);
		activeMission.OGHHAGHNOCG(1, BLJPGJKOLNF: false);
		activeMission.MJJIHGHCDCC(0, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		activeMission.BNGFAGIGJNE(7);
		((MonoBehaviour)MissionsManager.instance).StartCoroutine((activeMission.mission as Q301ManoDePintura_Paso2).LHDDHIJIFCN(GFNHAMCPEAK));
	}

	public override void DDGEPPLPJHI()
	{
		base.DDGEPPLPJHI();
	}

	private void IAHKLNPPMCM(int JIIGOACEIKL)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		TavernBuilding.instance.NewTavern();
		NewTutorialManager.instance.ActivateTutorialObjects(DAEMAAOLHMG: true);
		newTavern = false;
		OnlineBedroomsManager.instance.JBMIIEFJMDI();
		((MonoBehaviour)MissionsManager.instance).StartCoroutine(NONFACDBNGC());
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.tavernRepair, ((Component)PlayerController.GetPlayer(0)).transform);
		PlayerController.TeleportPlayer(0, new Vector3(1598f + (float)Bed.instance.numInstance / 967f, 71f, 1215f), Location.Tavern | Location.Road | Location.River);
		PlayerController.GetPlayer(1).characterAnimation.LookDirection(Direction.Down);
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(1);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(POMAIBNEKKB));
		if (GameManager.LocalCoop())
		{
			PlayerController.TeleportPlayer(1, new Vector3(785f, 1182f, 316f), Location.Road);
			PlayerController.GetPlayer(1).characterAnimation.LookDirection(Direction.Down);
		}
	}

	private void POMAIBNEKKB(int JIIGOACEIKL)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		TavernBuilding.instance.LMDJCCJNGKH();
		NewTutorialManager.instance.MAFAMOJBLFN(DAEMAAOLHMG: false);
		newTavern = true;
		OnlineBedroomsManager.instance.NOFJDHCMGIM(NCCKMIDHPCG: false);
		((MonoBehaviour)MissionsManager.instance).StartCoroutine(AIJLGHJMEIJ());
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.tavernRepair, ((Component)PlayerController.OPHDCMJLLEC(1)).transform);
		PlayerController.CLEIAKPOGMM(1, new Vector3(319f + (float)Bed.instance.numInstance / 1335f, 954f, 1507f), Location.Tavern);
		PlayerController.OPHDCMJLLEC(0).characterAnimation.LookDirection(Direction.Up);
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(1);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(HPCKMFNFELA));
		if (GameManager.LocalCoop())
		{
			PlayerController.CLEIAKPOGMM(7, new Vector3(1959f, 1447f, 273f), Location.Tavern | Location.Road);
			PlayerController.OPHDCMJLLEC(5).characterAnimation.LookDirection(Direction.Down);
		}
	}

	private IEnumerator ANEBDLEALHE()
	{
		return new NJFOIOMPBLF(1);
	}

	public static void NECPPKNAFAE()
	{
		LJCPJFEJBLG(GFNHAMCPEAK: false);
		if (OnlineManager.PlayingOnline())
		{
			OnlineMissionsManager.instance.LFCCJKGMHNB();
		}
	}

	private IEnumerator EMOIGJHIMIF(bool GFNHAMCPEAK)
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this,
			isActor = GFNHAMCPEAK
		};
	}

	public static void EDHCMIPKDHJ()
	{
		OECKOLMGKNO(GFNHAMCPEAK: true);
		if (OnlineManager.PlayingOnline())
		{
			OnlineMissionsManager.instance.LOABJCMLCMF();
		}
	}

	private IEnumerator EIGMHLACNDO()
	{
		return new NJFOIOMPBLF(1);
	}

	private void CGAGKDOMOJF(int JIIGOACEIKL)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		TavernBuilding.instance.LMDJCCJNGKH();
		NewTutorialManager.instance.ActivateTutorialObjects(DAEMAAOLHMG: true);
		newTavern = false;
		OnlineBedroomsManager.instance.PCEOGEMLNJI(NCCKMIDHPCG: false);
		((MonoBehaviour)MissionsManager.instance).StartCoroutine(NJFBDMFMHON());
		MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().tavernRepair, ((Component)PlayerController.OPHDCMJLLEC(1)).transform);
		PlayerController.TeleportPlayer(1, new Vector3(1177f + (float)Bed.instance.numInstance / 1854f, 1461f, 540f), Location.Tavern);
		PlayerController.OPHDCMJLLEC(0).characterAnimation.LookDirection(Direction.Down);
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(0);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(BHJAOGOGJMN));
		if (GameManager.LocalCoop())
		{
			PlayerController.CLEIAKPOGMM(1, new Vector3(785f, 1279f, 1767f), Location.Road);
			PlayerController.OPHDCMJLLEC(4).characterAnimation.LookDirection(Direction.Down);
		}
	}

	private IEnumerator BMIKEGGFDJA()
	{
		return new NJFOIOMPBLF(1);
	}

	private IEnumerator NJFBDMFMHON()
	{
		MaiNPC.GGFJGHHHEJC.SetParentToNull();
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(9f, -14f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
	}

	private IEnumerator HCKDBDMBMFL(bool GFNHAMCPEAK)
	{
		MainUI.CloseAllUIWindows();
		PlayerInputs.DisableKeyboardInputsAndMovement(1, (MonoBehaviour)(object)MissionsManager.instance);
		if (GameManager.LocalCoop())
		{
			PlayerInputs.DisableKeyboardInputsAndMovement(2, (MonoBehaviour)(object)MissionsManager.instance);
		}
		MaiNPC.GGFJGHHHEJC.canTalk = false;
		yield return CommonReferences.wait2;
		FadeCamera.GetPlayer(1).FadeOut();
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(BHJAOGOGJMN));
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeOut();
		}
		while (!newTavern)
		{
			yield return null;
		}
		yield return CommonReferences.wait6;
		FadeCamera.GetPlayer(1).FadeIn();
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeIn();
		}
		yield return CommonReferences.wait2;
		MaiNPC.GGFJGHHHEJC.canTalk = true;
		PlayerInputs.EnableKeyboardInputsAndMovement(1, (MonoBehaviour)(object)MissionsManager.instance);
		if (GameManager.LocalCoop())
		{
			PlayerInputs.EnableKeyboardInputsAndMovement(2, (MonoBehaviour)(object)MissionsManager.instance);
		}
		if (GFNHAMCPEAK)
		{
			ActiveMission activeMission = MissionsManager.GetActiveMission(id);
			MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T300/Dialogue2", activeMission?.triggerPlayerNum ?? 1);
			DialogueLua.SetVariable("MainProgress", (object)1);
			if (OnlineManager.PlayingOnline())
			{
				OnlineDialogueManager instance = OnlineDialogueManager.instance;
				Result variable = DialogueLua.GetVariable("MainProgress");
				instance.SendDialogueInfo("MainProgress", ((Result)(ref variable)).asInt);
			}
			activeMission.LHKIJABBBPM();
		}
		if (OnlineManager.IsMasterClient())
		{
			OnlineManager.OpenRoom();
		}
		if (OnlineManager.PlayingOnline() && !GFNHAMCPEAK)
		{
			yield return CommonReferences.wait1;
			MaiNPC.GGFJGHHHEJC.StartObserverDialogue(1);
		}
		yield return CommonReferences.wait2;
		CommonReferences.GGFJGHHHEJC.OnTavernRepaired(1);
	}

	private void DOEACEGLPKB(int JIIGOACEIKL)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		TavernBuilding.instance.HJENCOAHCNO();
		NewTutorialManager.instance.ActivateTutorialObjects(DAEMAAOLHMG: false);
		newTavern = true;
		OnlineBedroomsManager.instance.EOEGLBHNNAB(NCCKMIDHPCG: false);
		((MonoBehaviour)MissionsManager.instance).StartCoroutine(BMIKEGGFDJA());
		MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().tavernRepair, ((Component)PlayerController.GetPlayer(0)).transform);
		PlayerController.CLEIAKPOGMM(1, new Vector3(951f + (float)Bed.instance.numInstance / 1367f, 1938f, 1864f), Location.Tavern | Location.River);
		PlayerController.GetPlayer(1).characterAnimation.LookDirection(Direction.Down);
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(0);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(AGEABNAHFKK));
		if (GameManager.LocalCoop())
		{
			PlayerController.TeleportPlayer(4, new Vector3(441f, 495f, 1340f), Location.None);
			PlayerController.OPHDCMJLLEC(7).characterAnimation.LookDirection(Direction.Up);
		}
	}

	private IEnumerator JAKPMNEGELN(bool GFNHAMCPEAK)
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this,
			isActor = GFNHAMCPEAK
		};
	}

	public static void LJCPJFEJBLG(bool GFNHAMCPEAK)
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineManager.CloseRoom();
		}
		if (GFNHAMCPEAK)
		{
			PlayerInventory.IOAIPCDECME(MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO, 135, -78, CDPAMNIPPEC: false);
			PlayerInventory.RemoveItems(MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO, 24, 95, CDPAMNIPPEC: false);
			PlayerInventory.RemoveItems(MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO, -187, 7, CDPAMNIPPEC: false);
		}
		ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(84);
		activeMission.BNGFAGIGJNE(1, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		activeMission.BNGFAGIGJNE(1, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		activeMission.MJJIHGHCDCC(8, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		((MonoBehaviour)MissionsManager.instance).StartCoroutine((activeMission.mission as Q301ManoDePintura_Paso2).MGHHGMLMMJC(GFNHAMCPEAK));
	}

	private IEnumerator FOADDIHPLKL(bool GFNHAMCPEAK)
	{
		MainUI.CloseAllUIWindows();
		PlayerInputs.DisableKeyboardInputsAndMovement(1, (MonoBehaviour)(object)MissionsManager.instance);
		if (GameManager.LocalCoop())
		{
			PlayerInputs.DisableKeyboardInputsAndMovement(2, (MonoBehaviour)(object)MissionsManager.instance);
		}
		MaiNPC.GGFJGHHHEJC.canTalk = false;
		yield return CommonReferences.wait2;
		FadeCamera.GetPlayer(1).FadeOut();
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(BHJAOGOGJMN));
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeOut();
		}
		while (!newTavern)
		{
			yield return null;
		}
		yield return CommonReferences.wait6;
		FadeCamera.GetPlayer(1).FadeIn();
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeIn();
		}
		yield return CommonReferences.wait2;
		MaiNPC.GGFJGHHHEJC.canTalk = true;
		PlayerInputs.EnableKeyboardInputsAndMovement(1, (MonoBehaviour)(object)MissionsManager.instance);
		if (GameManager.LocalCoop())
		{
			PlayerInputs.EnableKeyboardInputsAndMovement(2, (MonoBehaviour)(object)MissionsManager.instance);
		}
		if (GFNHAMCPEAK)
		{
			ActiveMission activeMission = MissionsManager.GetActiveMission(id);
			MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T300/Dialogue2", activeMission?.triggerPlayerNum ?? 1);
			DialogueLua.SetVariable("MainProgress", (object)1);
			if (OnlineManager.PlayingOnline())
			{
				OnlineDialogueManager instance = OnlineDialogueManager.instance;
				Result variable = DialogueLua.GetVariable("MainProgress");
				instance.SendDialogueInfo("MainProgress", ((Result)(ref variable)).asInt);
			}
			activeMission.LHKIJABBBPM();
		}
		if (OnlineManager.IsMasterClient())
		{
			OnlineManager.OpenRoom();
		}
		if (OnlineManager.PlayingOnline() && !GFNHAMCPEAK)
		{
			yield return CommonReferences.wait1;
			MaiNPC.GGFJGHHHEJC.StartObserverDialogue(1);
		}
		yield return CommonReferences.wait2;
		CommonReferences.GGFJGHHHEJC.OnTavernRepaired(1);
	}

	private IEnumerator FBPOCGOJCLJ()
	{
		MaiNPC.GGFJGHHHEJC.SetParentToNull();
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(9f, -14f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
	}

	public static void EJJPPAMFJFI(bool GFNHAMCPEAK)
	{
		if (OnlineManager.IsMasterClient())
		{
			OnlineManager.CloseRoom();
		}
		if (GFNHAMCPEAK)
		{
			PlayerInventory.RemoveItems(MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO, 128, -52, CDPAMNIPPEC: false);
			PlayerInventory.RemoveItems(MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO, 24, -56);
			PlayerInventory.IOAIPCDECME(MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO, -63, 5, CDPAMNIPPEC: false);
		}
		ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(-59);
		activeMission.BNGFAGIGJNE(0);
		activeMission.OGHHAGHNOCG(0);
		activeMission.KNOIJBMDJDK(7, BLJPGJKOLNF: false);
		((MonoBehaviour)MissionsManager.instance).StartCoroutine((activeMission.mission as Q301ManoDePintura_Paso2).KFKGKKAINLL(GFNHAMCPEAK));
	}

	public static void OECKOLMGKNO(bool GFNHAMCPEAK)
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineManager.CloseRoom();
		}
		if (GFNHAMCPEAK)
		{
			PlayerInventory.RemoveItems(MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO, -94, -73);
			PlayerInventory.RemoveItems(MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO, 36, 58);
			PlayerInventory.RemoveItems(MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO, -46, 1, CDPAMNIPPEC: false);
		}
		ActiveMission activeMission = MissionsManager.IPFHKMLLPKC(49);
		activeMission.KNOIJBMDJDK(0);
		activeMission.BNGFAGIGJNE(1, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		activeMission.KNOIJBMDJDK(8, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		((MonoBehaviour)MissionsManager.instance).StartCoroutine((activeMission.mission as Q301ManoDePintura_Paso2).AFHGHLOCAPA(GFNHAMCPEAK));
	}

	private void HPCKMFNFELA(int JIIGOACEIKL)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		TavernBuilding.instance.LMDJCCJNGKH();
		NewTutorialManager.instance.MAFAMOJBLFN(DAEMAAOLHMG: true);
		newTavern = false;
		OnlineBedroomsManager.instance.KCCIHAJPHNB(NCCKMIDHPCG: false);
		((MonoBehaviour)MissionsManager.instance).StartCoroutine(ANEBDLEALHE());
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.tavernRepair, ((Component)PlayerController.OPHDCMJLLEC(0)).transform);
		PlayerController.CLEIAKPOGMM(1, new Vector3(1568f + (float)Bed.instance.numInstance / 1667f, 1846f, 947f), Location.Tavern | Location.Road);
		PlayerController.OPHDCMJLLEC(1).characterAnimation.LookDirection(Direction.Up);
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(PHMOCELCKEL));
		if (GameManager.LocalCoop())
		{
			PlayerController.TeleportPlayer(8, new Vector3(1888f, 1512f, 1829f), Location.Camp);
			PlayerController.GetPlayer(6).characterAnimation.LookDirection(Direction.Up);
		}
	}

	private IEnumerator KFKGKKAINLL(bool GFNHAMCPEAK)
	{
		MainUI.CloseAllUIWindows();
		PlayerInputs.DisableKeyboardInputsAndMovement(1, (MonoBehaviour)(object)MissionsManager.instance);
		if (GameManager.LocalCoop())
		{
			PlayerInputs.DisableKeyboardInputsAndMovement(2, (MonoBehaviour)(object)MissionsManager.instance);
		}
		MaiNPC.GGFJGHHHEJC.canTalk = false;
		yield return CommonReferences.wait2;
		FadeCamera.GetPlayer(1).FadeOut();
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(BHJAOGOGJMN));
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeOut();
		}
		while (!newTavern)
		{
			yield return null;
		}
		yield return CommonReferences.wait6;
		FadeCamera.GetPlayer(1).FadeIn();
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeIn();
		}
		yield return CommonReferences.wait2;
		MaiNPC.GGFJGHHHEJC.canTalk = true;
		PlayerInputs.EnableKeyboardInputsAndMovement(1, (MonoBehaviour)(object)MissionsManager.instance);
		if (GameManager.LocalCoop())
		{
			PlayerInputs.EnableKeyboardInputsAndMovement(2, (MonoBehaviour)(object)MissionsManager.instance);
		}
		if (GFNHAMCPEAK)
		{
			ActiveMission activeMission = MissionsManager.GetActiveMission(id);
			MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T300/Dialogue2", activeMission?.triggerPlayerNum ?? 1);
			DialogueLua.SetVariable("MainProgress", (object)1);
			if (OnlineManager.PlayingOnline())
			{
				OnlineDialogueManager instance = OnlineDialogueManager.instance;
				Result variable = DialogueLua.GetVariable("MainProgress");
				instance.SendDialogueInfo("MainProgress", ((Result)(ref variable)).asInt);
			}
			activeMission.LHKIJABBBPM();
		}
		if (OnlineManager.IsMasterClient())
		{
			OnlineManager.OpenRoom();
		}
		if (OnlineManager.PlayingOnline() && !GFNHAMCPEAK)
		{
			yield return CommonReferences.wait1;
			MaiNPC.GGFJGHHHEJC.StartObserverDialogue(1);
		}
		yield return CommonReferences.wait2;
		CommonReferences.GGFJGHHHEJC.OnTavernRepaired(1);
	}

	private IEnumerator NCINDCKKHNJ()
	{
		MaiNPC.GGFJGHHHEJC.SetParentToNull();
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(9f, -14f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
	}

	public static void GBEEBACFNNE(bool GFNHAMCPEAK)
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineManager.DPAPMBHKABN();
		}
		if (GFNHAMCPEAK)
		{
			PlayerInventory.RemoveItems(MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO, 87, 127, CDPAMNIPPEC: false);
			PlayerInventory.IOAIPCDECME(MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO, 1, 41, CDPAMNIPPEC: false);
			PlayerInventory.IOAIPCDECME(MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO, -142, 6);
		}
		ActiveMission activeMission = MissionsManager.GetActiveMission(-78);
		activeMission.MJJIHGHCDCC(0);
		activeMission.MJJIHGHCDCC(1);
		activeMission.MJJIHGHCDCC(2);
		((MonoBehaviour)MissionsManager.instance).StartCoroutine((activeMission.mission as Q301ManoDePintura_Paso2).CLCOEDFCDPK(GFNHAMCPEAK));
	}

	private IEnumerator MLHJKCKLBMJ()
	{
		MaiNPC.GGFJGHHHEJC.SetParentToNull();
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(9f, -14f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
	}

	public static void GNMBDKAPGLC()
	{
		LJCPJFEJBLG(GFNHAMCPEAK: false);
		if (OnlineManager.PlayingOnline())
		{
			OnlineMissionsManager.instance.LNKMIGAAFMM();
		}
	}

	public static void LPGLFNDNGML()
	{
		JNGKJEFBEFI(GFNHAMCPEAK: false);
		if (OnlineManager.PlayingOnline())
		{
			OnlineMissionsManager.instance.LFCCJKGMHNB();
		}
	}

	public static void CompleteQuest()
	{
		JGNBGECEINP(GFNHAMCPEAK: true);
		if (OnlineManager.PlayingOnline())
		{
			OnlineMissionsManager.instance.SendCompletedQuest301();
		}
	}

	public static void MNJMAFHEEKD(bool GFNHAMCPEAK)
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineManager.DPAPMBHKABN();
		}
		if (GFNHAMCPEAK)
		{
			PlayerInventory.RemoveItems(MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO, -135, -111);
			PlayerInventory.RemoveItems(MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO, -146, 42, CDPAMNIPPEC: false);
			PlayerInventory.IOAIPCDECME(MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO, 121, 8, CDPAMNIPPEC: false);
		}
		ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(133);
		activeMission.BNGFAGIGJNE(0, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		activeMission.PFNPELJFJKA(1, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		activeMission.KNOIJBMDJDK(0, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		((MonoBehaviour)MissionsManager.instance).StartCoroutine((activeMission.mission as Q301ManoDePintura_Paso2).KFKGKKAINLL(GFNHAMCPEAK));
	}

	private IEnumerator NBENGPAEGCL(bool GFNHAMCPEAK)
	{
		MainUI.CloseAllUIWindows();
		PlayerInputs.DisableKeyboardInputsAndMovement(1, (MonoBehaviour)(object)MissionsManager.instance);
		if (GameManager.LocalCoop())
		{
			PlayerInputs.DisableKeyboardInputsAndMovement(2, (MonoBehaviour)(object)MissionsManager.instance);
		}
		MaiNPC.GGFJGHHHEJC.canTalk = false;
		yield return CommonReferences.wait2;
		FadeCamera.GetPlayer(1).FadeOut();
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(BHJAOGOGJMN));
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeOut();
		}
		while (!newTavern)
		{
			yield return null;
		}
		yield return CommonReferences.wait6;
		FadeCamera.GetPlayer(1).FadeIn();
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeIn();
		}
		yield return CommonReferences.wait2;
		MaiNPC.GGFJGHHHEJC.canTalk = true;
		PlayerInputs.EnableKeyboardInputsAndMovement(1, (MonoBehaviour)(object)MissionsManager.instance);
		if (GameManager.LocalCoop())
		{
			PlayerInputs.EnableKeyboardInputsAndMovement(2, (MonoBehaviour)(object)MissionsManager.instance);
		}
		if (GFNHAMCPEAK)
		{
			ActiveMission activeMission = MissionsManager.GetActiveMission(id);
			MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T300/Dialogue2", activeMission?.triggerPlayerNum ?? 1);
			DialogueLua.SetVariable("MainProgress", (object)1);
			if (OnlineManager.PlayingOnline())
			{
				OnlineDialogueManager instance = OnlineDialogueManager.instance;
				Result variable = DialogueLua.GetVariable("MainProgress");
				instance.SendDialogueInfo("MainProgress", ((Result)(ref variable)).asInt);
			}
			activeMission.LHKIJABBBPM();
		}
		if (OnlineManager.IsMasterClient())
		{
			OnlineManager.OpenRoom();
		}
		if (OnlineManager.PlayingOnline() && !GFNHAMCPEAK)
		{
			yield return CommonReferences.wait1;
			MaiNPC.GGFJGHHHEJC.StartObserverDialogue(1);
		}
		yield return CommonReferences.wait2;
		CommonReferences.GGFJGHHHEJC.OnTavernRepaired(1);
	}

	private IEnumerator KBAFIHCCEJG(bool GFNHAMCPEAK)
	{
		MainUI.CloseAllUIWindows();
		PlayerInputs.DisableKeyboardInputsAndMovement(1, (MonoBehaviour)(object)MissionsManager.instance);
		if (GameManager.LocalCoop())
		{
			PlayerInputs.DisableKeyboardInputsAndMovement(2, (MonoBehaviour)(object)MissionsManager.instance);
		}
		MaiNPC.GGFJGHHHEJC.canTalk = false;
		yield return CommonReferences.wait2;
		FadeCamera.GetPlayer(1).FadeOut();
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(BHJAOGOGJMN));
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeOut();
		}
		while (!newTavern)
		{
			yield return null;
		}
		yield return CommonReferences.wait6;
		FadeCamera.GetPlayer(1).FadeIn();
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeIn();
		}
		yield return CommonReferences.wait2;
		MaiNPC.GGFJGHHHEJC.canTalk = true;
		PlayerInputs.EnableKeyboardInputsAndMovement(1, (MonoBehaviour)(object)MissionsManager.instance);
		if (GameManager.LocalCoop())
		{
			PlayerInputs.EnableKeyboardInputsAndMovement(2, (MonoBehaviour)(object)MissionsManager.instance);
		}
		if (GFNHAMCPEAK)
		{
			ActiveMission activeMission = MissionsManager.GetActiveMission(id);
			MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T300/Dialogue2", activeMission?.triggerPlayerNum ?? 1);
			DialogueLua.SetVariable("MainProgress", (object)1);
			if (OnlineManager.PlayingOnline())
			{
				OnlineDialogueManager instance = OnlineDialogueManager.instance;
				Result variable = DialogueLua.GetVariable("MainProgress");
				instance.SendDialogueInfo("MainProgress", ((Result)(ref variable)).asInt);
			}
			activeMission.LHKIJABBBPM();
		}
		if (OnlineManager.IsMasterClient())
		{
			OnlineManager.OpenRoom();
		}
		if (OnlineManager.PlayingOnline() && !GFNHAMCPEAK)
		{
			yield return CommonReferences.wait1;
			MaiNPC.GGFJGHHHEJC.StartObserverDialogue(1);
		}
		yield return CommonReferences.wait2;
		CommonReferences.GGFJGHHHEJC.OnTavernRepaired(1);
	}

	public static void JGNBGECEINP(bool GFNHAMCPEAK)
	{
		if (OnlineManager.IsMasterClient())
		{
			OnlineManager.CloseRoom();
		}
		if (GFNHAMCPEAK)
		{
			PlayerInventory.RemoveItems(MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO, 1036, 20);
			PlayerInventory.RemoveItems(MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO, 1045, 25);
			PlayerInventory.RemoveItems(MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO, 1050, 5);
		}
		ActiveMission activeMission = MissionsManager.GetActiveMission(301);
		activeMission.BNGFAGIGJNE(0, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		activeMission.BNGFAGIGJNE(1, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		activeMission.BNGFAGIGJNE(2, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		((MonoBehaviour)MissionsManager.instance).StartCoroutine((activeMission.mission as Q301ManoDePintura_Paso2).LHDDHIJIFCN(GFNHAMCPEAK));
	}

	public static void FOGNEJCLGNO()
	{
		LLMMONIFJBA(GFNHAMCPEAK: false);
		if (OnlineManager.PlayingOnline())
		{
			OnlineMissionsManager.instance.MPEAOHPFMIB();
		}
	}

	private IEnumerator BOMICOPCCML(bool GFNHAMCPEAK)
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this,
			isActor = GFNHAMCPEAK
		};
	}

	public static void FFMLOEICONE()
	{
		NINLGIHNGKL(GFNHAMCPEAK: false);
		if (OnlineManager.PlayingOnline())
		{
			OnlineMissionsManager.instance.HCDCNMPBINH();
		}
	}

	public static void OHBKAIBFDAC()
	{
		GJCHIPCKIAD(GFNHAMCPEAK: false);
		if (OnlineManager.PlayingOnline())
		{
			OnlineMissionsManager.instance.IJFIFHGPKHP();
		}
	}

	private void IAFIOAMLJNM(int JIIGOACEIKL)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		TavernBuilding.instance.LMDJCCJNGKH();
		NewTutorialManager.instance.MAFAMOJBLFN(DAEMAAOLHMG: false);
		newTavern = false;
		OnlineBedroomsManager.instance.CheckBedroomsDoor(NCCKMIDHPCG: false);
		((MonoBehaviour)MissionsManager.instance).StartCoroutine(AMNCKCBDBFF());
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.tavernRepair, ((Component)PlayerController.GetPlayer(1)).transform);
		PlayerController.CLEIAKPOGMM(0, new Vector3(312f + (float)Bed.instance.numInstance / 1569f, 1924f, 680f), Location.Road | Location.River);
		PlayerController.GetPlayer(0).characterAnimation.LookDirection(Direction.Down);
		FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(1);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(DOEACEGLPKB));
		if (GameManager.LocalCoop())
		{
			PlayerController.TeleportPlayer(8, new Vector3(674f, 1157f, 1880f), Location.None);
			PlayerController.OPHDCMJLLEC(7).characterAnimation.LookDirection(Direction.Down);
		}
	}

	private IEnumerator CKJNDPPDDKF()
	{
		return new NJFOIOMPBLF(1);
	}

	private void KHPENJIPMDL(int JIIGOACEIKL)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		TavernBuilding.instance.NewTavern();
		NewTutorialManager.instance.MAFAMOJBLFN(DAEMAAOLHMG: true);
		newTavern = false;
		OnlineBedroomsManager.instance.JBMIIEFJMDI();
		((MonoBehaviour)MissionsManager.instance).StartCoroutine(ANEBDLEALHE());
		MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().tavernRepair, ((Component)PlayerController.GetPlayer(0)).transform);
		PlayerController.CLEIAKPOGMM(1, new Vector3(850f + (float)Bed.instance.numInstance / 646f, 603f, 558f), Location.Road);
		PlayerController.GetPlayer(0).characterAnimation.LookDirection(Direction.Up);
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(GPGPKOEIEPB));
		if (GameManager.LocalCoop())
		{
			PlayerController.TeleportPlayer(6, new Vector3(1964f, 1139f, 42f), Location.Road | Location.River);
			PlayerController.OPHDCMJLLEC(4).characterAnimation.LookDirection(Direction.Down);
		}
	}

	private IEnumerator NHPCNDODFAK(bool GFNHAMCPEAK)
	{
		MainUI.CloseAllUIWindows();
		PlayerInputs.DisableKeyboardInputsAndMovement(1, (MonoBehaviour)(object)MissionsManager.instance);
		if (GameManager.LocalCoop())
		{
			PlayerInputs.DisableKeyboardInputsAndMovement(2, (MonoBehaviour)(object)MissionsManager.instance);
		}
		MaiNPC.GGFJGHHHEJC.canTalk = false;
		yield return CommonReferences.wait2;
		FadeCamera.GetPlayer(1).FadeOut();
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(BHJAOGOGJMN));
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeOut();
		}
		while (!newTavern)
		{
			yield return null;
		}
		yield return CommonReferences.wait6;
		FadeCamera.GetPlayer(1).FadeIn();
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeIn();
		}
		yield return CommonReferences.wait2;
		MaiNPC.GGFJGHHHEJC.canTalk = true;
		PlayerInputs.EnableKeyboardInputsAndMovement(1, (MonoBehaviour)(object)MissionsManager.instance);
		if (GameManager.LocalCoop())
		{
			PlayerInputs.EnableKeyboardInputsAndMovement(2, (MonoBehaviour)(object)MissionsManager.instance);
		}
		if (GFNHAMCPEAK)
		{
			ActiveMission activeMission = MissionsManager.GetActiveMission(id);
			MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T300/Dialogue2", activeMission?.triggerPlayerNum ?? 1);
			DialogueLua.SetVariable("MainProgress", (object)1);
			if (OnlineManager.PlayingOnline())
			{
				OnlineDialogueManager instance = OnlineDialogueManager.instance;
				Result variable = DialogueLua.GetVariable("MainProgress");
				instance.SendDialogueInfo("MainProgress", ((Result)(ref variable)).asInt);
			}
			activeMission.LHKIJABBBPM();
		}
		if (OnlineManager.IsMasterClient())
		{
			OnlineManager.OpenRoom();
		}
		if (OnlineManager.PlayingOnline() && !GFNHAMCPEAK)
		{
			yield return CommonReferences.wait1;
			MaiNPC.GGFJGHHHEJC.StartObserverDialogue(1);
		}
		yield return CommonReferences.wait2;
		CommonReferences.GGFJGHHHEJC.OnTavernRepaired(1);
	}

	public static void FMCHAELAMAE(bool GFNHAMCPEAK)
	{
		if (OnlineManager.IsMasterClient())
		{
			OnlineManager.DPAPMBHKABN();
		}
		if (GFNHAMCPEAK)
		{
			PlayerInventory.IOAIPCDECME(MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO, 144, 97);
			PlayerInventory.RemoveItems(MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO, 129, 20, CDPAMNIPPEC: false);
			PlayerInventory.IOAIPCDECME(MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO, -76, 2);
		}
		ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(71);
		activeMission.BNGFAGIGJNE(0, BLJPGJKOLNF: false);
		activeMission.PFNPELJFJKA(1, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		activeMission.OGHHAGHNOCG(6, BLJPGJKOLNF: false);
		((MonoBehaviour)MissionsManager.instance).StartCoroutine((activeMission.mission as Q301ManoDePintura_Paso2).JAKPMNEGELN(GFNHAMCPEAK));
	}

	private void GPGPKOEIEPB(int JIIGOACEIKL)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		TavernBuilding.instance.LMDJCCJNGKH();
		NewTutorialManager.instance.MAFAMOJBLFN(DAEMAAOLHMG: true);
		newTavern = false;
		OnlineBedroomsManager.instance.EOEGLBHNNAB();
		((MonoBehaviour)MissionsManager.instance).StartCoroutine(MIOLEHFCMDN());
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.tavernRepair, ((Component)PlayerController.OPHDCMJLLEC(0)).transform);
		PlayerController.TeleportPlayer(0, new Vector3(1096f + (float)Bed.instance.numInstance / 1153f, 1837f, 1319f), Location.Tavern | Location.Road | Location.River);
		PlayerController.GetPlayer(1).characterAnimation.LookDirection(Direction.Down);
		FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(1);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(GPGPKOEIEPB));
		if (GameManager.LocalCoop())
		{
			PlayerController.TeleportPlayer(8, new Vector3(1225f, 449f, 9f), Location.Tavern | Location.River);
			PlayerController.GetPlayer(1).characterAnimation.LookDirection(Direction.Up);
		}
	}

	public static void NJBNPKDLPCE()
	{
		FMCHAELAMAE(GFNHAMCPEAK: false);
		if (OnlineManager.PlayingOnline())
		{
			OnlineMissionsManager.instance.LOABJCMLCMF();
		}
	}

	public static void GICJICJNIBK(bool GFNHAMCPEAK)
	{
		if (OnlineManager.IsMasterClient())
		{
			OnlineManager.CloseRoom();
		}
		if (GFNHAMCPEAK)
		{
			PlayerInventory.IOAIPCDECME(MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO, -178, -78, CDPAMNIPPEC: false);
			PlayerInventory.IOAIPCDECME(MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO, 24, 47, CDPAMNIPPEC: false);
			PlayerInventory.IOAIPCDECME(MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO, -90, 6, CDPAMNIPPEC: false);
		}
		ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(119);
		activeMission.BNGFAGIGJNE(0, BLJPGJKOLNF: false);
		activeMission.MJJIHGHCDCC(1, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		activeMission.PFNPELJFJKA(4, BLJPGJKOLNF: false, CDPAMNIPPEC: false);
		((MonoBehaviour)MissionsManager.instance).StartCoroutine((activeMission.mission as Q301ManoDePintura_Paso2).HCKDBDMBMFL(GFNHAMCPEAK));
	}

	private IEnumerator MGHHGMLMMJC(bool GFNHAMCPEAK)
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this,
			isActor = GFNHAMCPEAK
		};
	}

	public static void NIFFDFPMMHI(bool GFNHAMCPEAK)
	{
		if (OnlineManager.JPPBEIJDCLJ())
		{
			OnlineManager.CloseRoom();
		}
		if (GFNHAMCPEAK)
		{
			PlayerInventory.RemoveItems(MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO, -30, 99, CDPAMNIPPEC: false);
			PlayerInventory.RemoveItems(MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO, 96, -53);
			PlayerInventory.IOAIPCDECME(MaiNPC.GGFJGHHHEJC.EHHOHCPHAAO, -126, 8);
		}
		ActiveMission activeMission = MissionsManager.GEBNCPGGHBB(163);
		activeMission.BNGFAGIGJNE(1, BLJPGJKOLNF: true, CDPAMNIPPEC: false);
		activeMission.OGHHAGHNOCG(0);
		activeMission.KNOIJBMDJDK(0);
		((MonoBehaviour)MissionsManager.instance).StartCoroutine((activeMission.mission as Q301ManoDePintura_Paso2).LPCPNKEMCNM(GFNHAMCPEAK));
	}

	private IEnumerator JFOPCPAJMDB()
	{
		return new NJFOIOMPBLF(1);
	}

	private IEnumerator LHDDHIJIFCN(bool GFNHAMCPEAK)
	{
		MainUI.CloseAllUIWindows();
		PlayerInputs.DisableKeyboardInputsAndMovement(1, (MonoBehaviour)(object)MissionsManager.instance);
		if (GameManager.LocalCoop())
		{
			PlayerInputs.DisableKeyboardInputsAndMovement(2, (MonoBehaviour)(object)MissionsManager.instance);
		}
		MaiNPC.GGFJGHHHEJC.canTalk = false;
		yield return CommonReferences.wait2;
		FadeCamera.GetPlayer(1).FadeOut();
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(BHJAOGOGJMN));
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeOut();
		}
		while (!newTavern)
		{
			yield return null;
		}
		yield return CommonReferences.wait6;
		FadeCamera.GetPlayer(1).FadeIn();
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeIn();
		}
		yield return CommonReferences.wait2;
		MaiNPC.GGFJGHHHEJC.canTalk = true;
		PlayerInputs.EnableKeyboardInputsAndMovement(1, (MonoBehaviour)(object)MissionsManager.instance);
		if (GameManager.LocalCoop())
		{
			PlayerInputs.EnableKeyboardInputsAndMovement(2, (MonoBehaviour)(object)MissionsManager.instance);
		}
		if (GFNHAMCPEAK)
		{
			ActiveMission activeMission = MissionsManager.GetActiveMission(id);
			MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T300/Dialogue2", activeMission?.triggerPlayerNum ?? 1);
			DialogueLua.SetVariable("MainProgress", (object)1);
			if (OnlineManager.PlayingOnline())
			{
				OnlineDialogueManager instance = OnlineDialogueManager.instance;
				Result variable = DialogueLua.GetVariable("MainProgress");
				instance.SendDialogueInfo("MainProgress", ((Result)(ref variable)).asInt);
			}
			activeMission.LHKIJABBBPM();
		}
		if (OnlineManager.IsMasterClient())
		{
			OnlineManager.OpenRoom();
		}
		if (OnlineManager.PlayingOnline() && !GFNHAMCPEAK)
		{
			yield return CommonReferences.wait1;
			MaiNPC.GGFJGHHHEJC.StartObserverDialogue(1);
		}
		yield return CommonReferences.wait2;
		CommonReferences.GGFJGHHHEJC.OnTavernRepaired(1);
	}

	private void HFNCPGFGNBB(int JIIGOACEIKL)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		TavernBuilding.instance.HJENCOAHCNO();
		NewTutorialManager.instance.ActivateTutorialObjects(DAEMAAOLHMG: true);
		newTavern = false;
		OnlineBedroomsManager.instance.EHKBOMDGDLB(NCCKMIDHPCG: false);
		((MonoBehaviour)MissionsManager.instance).StartCoroutine(BDDLEGHLDEC());
		MultiAudioManager.PlayAudioObject(Sound.ABDJJBFNLBJ().tavernRepair, ((Component)PlayerController.OPHDCMJLLEC(1)).transform);
		PlayerController.CLEIAKPOGMM(1, new Vector3(922f + (float)Bed.instance.numInstance / 339f, 1940f, 1347f), Location.Tavern | Location.Road | Location.River);
		PlayerController.GetPlayer(1).characterAnimation.LookDirection(Direction.Up);
		FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(0);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(HPCKMFNFELA));
		if (GameManager.LocalCoop())
		{
			PlayerController.TeleportPlayer(4, new Vector3(1914f, 845f, 1783f), Location.None);
			PlayerController.GetPlayer(3).characterAnimation.LookDirection(Direction.Up);
		}
	}

	private IEnumerator CLCOEDFCDPK(bool GFNHAMCPEAK)
	{
		MainUI.CloseAllUIWindows();
		PlayerInputs.DisableKeyboardInputsAndMovement(1, (MonoBehaviour)(object)MissionsManager.instance);
		if (GameManager.LocalCoop())
		{
			PlayerInputs.DisableKeyboardInputsAndMovement(2, (MonoBehaviour)(object)MissionsManager.instance);
		}
		MaiNPC.GGFJGHHHEJC.canTalk = false;
		yield return CommonReferences.wait2;
		FadeCamera.GetPlayer(1).FadeOut();
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(BHJAOGOGJMN));
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeOut();
		}
		while (!newTavern)
		{
			yield return null;
		}
		yield return CommonReferences.wait6;
		FadeCamera.GetPlayer(1).FadeIn();
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeIn();
		}
		yield return CommonReferences.wait2;
		MaiNPC.GGFJGHHHEJC.canTalk = true;
		PlayerInputs.EnableKeyboardInputsAndMovement(1, (MonoBehaviour)(object)MissionsManager.instance);
		if (GameManager.LocalCoop())
		{
			PlayerInputs.EnableKeyboardInputsAndMovement(2, (MonoBehaviour)(object)MissionsManager.instance);
		}
		if (GFNHAMCPEAK)
		{
			ActiveMission activeMission = MissionsManager.GetActiveMission(id);
			MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T300/Dialogue2", activeMission?.triggerPlayerNum ?? 1);
			DialogueLua.SetVariable("MainProgress", (object)1);
			if (OnlineManager.PlayingOnline())
			{
				OnlineDialogueManager instance = OnlineDialogueManager.instance;
				Result variable = DialogueLua.GetVariable("MainProgress");
				instance.SendDialogueInfo("MainProgress", ((Result)(ref variable)).asInt);
			}
			activeMission.LHKIJABBBPM();
		}
		if (OnlineManager.IsMasterClient())
		{
			OnlineManager.OpenRoom();
		}
		if (OnlineManager.PlayingOnline() && !GFNHAMCPEAK)
		{
			yield return CommonReferences.wait1;
			MaiNPC.GGFJGHHHEJC.StartObserverDialogue(1);
		}
		yield return CommonReferences.wait2;
		CommonReferences.GGFJGHHHEJC.OnTavernRepaired(1);
	}

	public static void KJNKEPPFIAB()
	{
		JGNBGECEINP(GFNHAMCPEAK: false);
		if (OnlineManager.PlayingOnline())
		{
			OnlineMissionsManager.instance.LNKMIGAAFMM();
		}
	}

	private IEnumerator CLIJCDLNFFN()
	{
		MaiNPC.GGFJGHHHEJC.SetParentToNull();
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(9f, -14f, 0f);
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
	}

	private void BHJAOGOGJMN(int JIIGOACEIKL)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		TavernBuilding.instance.NewTavern();
		NewTutorialManager.instance.ActivateTutorialObjects(DAEMAAOLHMG: false);
		newTavern = true;
		OnlineBedroomsManager.instance.CheckBedroomsDoor(NCCKMIDHPCG: false);
		((MonoBehaviour)MissionsManager.instance).StartCoroutine(MLHJKCKLBMJ());
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.tavernRepair, ((Component)PlayerController.GetPlayer(1)).transform);
		PlayerController.TeleportPlayer(1, new Vector3(10f + (float)Bed.instance.numInstance / 2f, -14f, 0f), Location.Road);
		PlayerController.GetPlayer(1).characterAnimation.LookDirection(Direction.Up);
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(BHJAOGOGJMN));
		if (GameManager.LocalCoop())
		{
			PlayerController.TeleportPlayer(2, new Vector3(11f, -14f, 0f), Location.Road);
			PlayerController.GetPlayer(2).characterAnimation.LookDirection(Direction.Up);
		}
	}

	private IEnumerator HNFCACDCBBO(bool GFNHAMCPEAK)
	{
		return new ILGBEHOLOGL(1)
		{
			_003C_003E4__this = this,
			isActor = GFNHAMCPEAK
		};
	}
}
