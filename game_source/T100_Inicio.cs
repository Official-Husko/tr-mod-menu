using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using UnityEngine;

public class T100_Inicio : TutorialPhaseBase
{
	[CompilerGenerated]
	private sealed class EICJAKJFOIH : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T100_Inicio _003C_003E4__this;

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
		public EICJAKJFOIH(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Expected O, but got Unknown
			int num = _003C_003E1__state;
			T100_Inicio t100_Inicio = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				t100_Inicio.FHNFKEHGJHJ = MultiAudioManager.FadeInAudioObject(t100_Inicio.carriage, ((Component)t100_Inicio.PJNODKDAPOI).transform, 0.4f);
				goto IL_0098;
			case 1:
				_003C_003E1__state = -1;
				goto IL_0098;
			case 2:
				{
					_003C_003E1__state = -1;
					Utils.BLPDAEHPOBA(((Component)t100_Inicio.FOCPGKMJMOB).gameObject);
					return false;
				}
				IL_0098:
				if (t100_Inicio.FOCPGKMJMOB.position.x > -14f)
				{
					t100_Inicio.FOCPGKMJMOB.position = Utils.EKCCGNEDPNO(t100_Inicio.FOCPGKMJMOB.position - t100_Inicio.HGMFJBLNCJJ * Time.fixedDeltaTime, 1);
					_003C_003E2__current = (object)new WaitForFixedUpdate();
					_003C_003E1__state = 1;
					return true;
				}
				t100_Inicio.FHNFKEHGJHJ.FadeOut(0.4f, false);
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 2;
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
	private sealed class ENFOLJJKLJH : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T100_Inicio _003C_003E4__this;

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
		public ENFOLJJKLJH(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_024f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0254: Unknown result type (might be due to invalid IL or missing references)
			//IL_026f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0274: Unknown result type (might be due to invalid IL or missing references)
			//IL_0279: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_035e: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_0318: Unknown result type (might be due to invalid IL or missing references)
			//IL_031e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0328: Unknown result type (might be due to invalid IL or missing references)
			//IL_032d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0333: Unknown result type (might be due to invalid IL or missing references)
			//IL_033e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0348: Expected O, but got Unknown
			//IL_037b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0380: Unknown result type (might be due to invalid IL or missing references)
			//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d9: Expected O, but got Unknown
			//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			T100_Inicio t100_Inicio = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
			{
				_003C_003E1__state = -1;
				SceneReferences.GetSceneReferences().npcRoutines.SetActive(false);
				SceneReferences.GetSceneReferences().customerPool.DisableAllCustomers();
				((Component)SceneReferences.GetSceneReferences().customerPool).gameObject.SetActive(false);
				t100_Inicio.BMFMBLJFLEB(MJHBHDAEDLF: false);
				MusicController.instance.PauseBasicMood(IEAALMNBABK: true);
				LettersManager.instance.lettersSaved = new List<PostBox.LetterSaveData>();
				LettersManager.instance.AddNewReceivedLetter(1000, LKAALEJKLPA: true, AJPCNKCBDEI: true, new GameDate(0, Season.Summer, 0, Day.Thurs, 0, 0));
				LettersManager.instance.AddNewReceivedLetter(1001, LKAALEJKLPA: true, AJPCNKCBDEI: true, new GameDate(0, Season.Autumn, 0, Day.Tue, 0, 0));
				LettersManager.instance.AddNewReceivedLetter(1002, LKAALEJKLPA: true, AJPCNKCBDEI: true, new GameDate(0, Season.Winter, 1, Day.Wed, 0, 0));
				LettersManager.instance.AddNewReceivedLetter(1003, LKAALEJKLPA: false, AJPCNKCBDEI: true, new GameDate(0, Season.Winter, 3, Day.Sun, 0, 0));
				for (int i = 0; i < SceneReferences.GetSceneReferences().nightStartDeactive.Length; i++)
				{
					((Behaviour)SceneReferences.GetSceneReferences().nightStartDeactive[i]).enabled = false;
				}
				for (int j = 0; j < SceneReferences.GetSceneReferences().blueFires.Length; j++)
				{
					((Component)SceneReferences.GetSceneReferences().blueFires[j]).gameObject.SetActive(false);
				}
				for (int k = 0; k < SceneReferences.GetSceneReferences().blueFireLights.Length; k++)
				{
					((Component)SceneReferences.GetSceneReferences().blueFireLights[k]).gameObject.SetActive(false);
				}
				PostBox.instance.unreadIcon.SetActive(false);
				PlayerController.TeleportPlayer(1, Vector2.op_Implicit(new Vector2(10f, 0f)), Location.Road);
				WorldTime.ChangeHour(21);
				Weather.ShowWeather(Weather.WeatherType.PrecipitationStormyClouds);
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			}
			case 1:
				_003C_003E1__state = -1;
				Weather.NextThunder(5f);
				SceneReferences.instance.table.SetDirtiness(2000f);
				CameraTarget.GetPlayer(1).movementDisabled = true;
				((Component)CameraTarget.GetPlayer(1)).transform.position = Vector2.op_Implicit(new Vector2(9.5f, -13f));
				t100_Inicio.PJNODKDAPOI = ((Component)Object.Instantiate<GameObject>(t100_Inicio.rocinantePrefab, Vector2.op_Implicit(new Vector2(24f, -14f)), Quaternion.identity).transform.GetChild(0)).GetComponent<Animator>();
				t100_Inicio.FOCPGKMJMOB = ((Component)t100_Inicio.PJNODKDAPOI).transform.parent;
				((Component)t100_Inicio.PJNODKDAPOI).transform.localScale = new Vector3(-1f, 1f, 1f);
				t100_Inicio.PJNODKDAPOI.SetBool("Walking", true);
				PlayerController.AddMovementBlocker((Object)(object)t100_Inicio);
				t100_Inicio.FHNFKEHGJHJ = MultiAudioManager.FadeInAudioObject(t100_Inicio.carriage, ((Component)t100_Inicio.PJNODKDAPOI).transform, 0.4f);
				goto IL_0358;
			case 2:
				_003C_003E1__state = -1;
				goto IL_0358;
			case 3:
				_003C_003E1__state = -1;
				goto IL_03e9;
			case 4:
				_003C_003E1__state = -1;
				CarretilleroNPC.GGFJGHHHEJC.inTutorial = true;
				CarretilleroNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T100/Dialogue2", 1, DHELBHAICMM: false, CGKNJONAKGD: false);
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 5;
				return true;
			case 5:
				_003C_003E1__state = -1;
				t100_Inicio.PJNODKDAPOI.SetBool("Talking", true);
				goto IL_049f;
			case 6:
				_003C_003E1__state = -1;
				goto IL_049f;
			case 7:
				_003C_003E1__state = -1;
				t100_Inicio.BBCGOJEAPBG();
				PlayerController.TeleportPlayer(1, Vector2.op_Implicit(new Vector2(10f, -15f)), Location.Road);
				PlayerController.GetPlayer(1).characterAnimation.LookDirection(Direction.Up);
				CameraTarget.GetPlayer(1).movementDisabled = false;
				goto IL_051a;
			case 8:
				_003C_003E1__state = -1;
				goto IL_051a;
			case 9:
				_003C_003E1__state = -1;
				CarretilleroNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T100/Dialogue3", 1, DHELBHAICMM: false, CGKNJONAKGD: false);
				goto IL_056a;
			case 10:
				_003C_003E1__state = -1;
				goto IL_056a;
			case 11:
				_003C_003E1__state = -1;
				CarretilleroNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T100/Dialogue4", 1, DHELBHAICMM: true, CGKNJONAKGD: false);
				_003C_003E2__current = CommonReferences.wait1_5;
				_003C_003E1__state = 12;
				return true;
			case 12:
				_003C_003E1__state = -1;
				t100_Inicio.PJNODKDAPOI.SetBool("Walking", true);
				_003C_003E2__current = CommonReferences.wait02;
				_003C_003E1__state = 13;
				return true;
			case 13:
				_003C_003E1__state = -1;
				MultiAudioManager.PlayAudioObject(t100_Inicio.whip, ((Component)t100_Inicio.PJNODKDAPOI).transform);
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 14;
				return true;
			case 14:
				_003C_003E1__state = -1;
				((MonoBehaviour)t100_Inicio).StartCoroutine(t100_Inicio.NJGEOBPMNNM());
				CarretilleroNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T100/Dialogue5", 1, DHELBHAICMM: true, CGKNJONAKGD: false);
				_003C_003E2__current = CommonReferences.wait4;
				_003C_003E1__state = 15;
				return true;
			case 15:
				_003C_003E1__state = -1;
				PostBox.instance.unreadIcon.SetActive(true);
				NewTutorialManager.ShowPopUp();
				goto IL_0687;
			case 16:
				_003C_003E1__state = -1;
				goto IL_0687;
			case 17:
				_003C_003E1__state = -1;
				goto IL_06d1;
			case 18:
				_003C_003E1__state = -1;
				NewTutorialManager.instance.ObjectiveCompleted(0);
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 19;
				return true;
			case 19:
				{
					_003C_003E1__state = -1;
					t100_Inicio.LHKIJABBBPM();
					return false;
				}
				IL_0687:
				if (NewTutorialManager.instance.open)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 16;
					return true;
				}
				PlayerController.RemoveMovementBlocker((Object)(object)t100_Inicio);
				t100_Inicio.BMFMBLJFLEB(MJHBHDAEDLF: true);
				NewTutorialManager.instance.player2Blocked = false;
				t100_Inicio.ResetMai();
				t100_Inicio.JBKBMNPPCDM();
				goto IL_06d1;
				IL_06d1:
				if (!PlayerController.GetPlayer(1).IsTavernLocation() && (!GameManager.LocalCoop() || !PlayerController.GetPlayer(2).IsTavernLocation()))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 17;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 18;
				return true;
				IL_03e9:
				if (t100_Inicio.FOCPGKMJMOB.position.x > 9.5f)
				{
					t100_Inicio.FOCPGKMJMOB.position = Utils.BMBMPKNANAC(t100_Inicio.FOCPGKMJMOB.position - t100_Inicio.HGMFJBLNCJJ * Time.fixedDeltaTime);
					_003C_003E2__current = (object)new WaitForFixedUpdate();
					_003C_003E1__state = 3;
					return true;
				}
				t100_Inicio.PJNODKDAPOI.SetBool("Walking", false);
				t100_Inicio.FHNFKEHGJHJ.FadeOut(0.4f, false);
				_003C_003E2__current = CommonReferences.wait5;
				_003C_003E1__state = 4;
				return true;
				IL_049f:
				if (t100_Inicio.AAOPIEDAKKD(1))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 6;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 7;
				return true;
				IL_056a:
				if (t100_Inicio.AAOPIEDAKKD(2))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 10;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 11;
				return true;
				IL_051a:
				if (!t100_Inicio.MAMIBIOEDNF)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 8;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 9;
				return true;
				IL_0358:
				if (t100_Inicio.FOCPGKMJMOB.position.x > 13f)
				{
					t100_Inicio.FOCPGKMJMOB.position = Utils.EKCCGNEDPNO(t100_Inicio.FOCPGKMJMOB.position - t100_Inicio.HGMFJBLNCJJ * Time.fixedDeltaTime, 1);
					_003C_003E2__current = (object)new WaitForFixedUpdate();
					_003C_003E1__state = 2;
					return true;
				}
				t100_Inicio.FOCPGKMJMOB.position = Utils.BMBMPKNANAC(t100_Inicio.FOCPGKMJMOB.position);
				CarretilleroNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T100/Dialogue1", 1, DHELBHAICMM: true, CGKNJONAKGD: false);
				goto IL_03e9;
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

	public GameObject rocinantePrefab;

	public AudioObject carriage;

	public AudioObject whip;

	private MultiAudioSource FHNFKEHGJHJ;

	private Animator PJNODKDAPOI;

	private Transform FOCPGKMJMOB;

	private Vector3 HGMFJBLNCJJ = new Vector3(1.65f, 0f, 0f);

	private bool EGEIPCHGCOK;

	private bool MAMIBIOEDNF;

	private IEnumerator KPHADDFLJGN()
	{
		return new EICJAKJFOIH(1)
		{
			_003C_003E4__this = this
		};
	}

	private void GABODIIJINN()
	{
		CharacterCreatorUI.loadGame = null;
		CharacterCreatorUI.Get(1).EDHEIFHAAKO();
		InteractObject.GNCPLNHMFHN(1).interactingObject = ((Component)this).gameObject;
		PlayerController player = PlayerController.GetPlayer(0);
		player.OnPlayerMoving = (Action)Delegate.Combine(player.OnPlayerMoving, new Action(LJDMOKKEPJC));
		CharacterCreatorUI characterCreatorUI = CharacterCreatorUI.PCEEOGGDBFB(1);
		characterCreatorUI.OnUIClose = (Action<int>)Delegate.Combine(characterCreatorUI.OnUIClose, new Action<int>(CECPEMFHEGP));
	}

	public void JPGKENPAGMM(int JIIGOACEIKL)
	{
		PlayerController player = PlayerController.GetPlayer(1);
		player.OnPlayerMoving = (Action)Delegate.Remove(player.OnPlayerMoving, new Action(ILKJPDMMDPL));
		CharacterCreatorUI.Get(1).CloseUI();
		CharacterCreatorUI characterCreatorUI = CharacterCreatorUI.MENPEHNHFOA(1);
		characterCreatorUI.OnUIClose = (Action<int>)Delegate.Remove(characterCreatorUI.OnUIClose, new Action<int>(CloseCharacterCreator));
		MAMIBIOEDNF = false;
	}

	protected void LALAFOIGMKN()
	{
		if (NewTutorialManager.CCCLOBIOMCL && (Object)(object)FHNFKEHGJHJ != (Object)null)
		{
			if (Time.timeScale == 125f && !EGEIPCHGCOK)
			{
				FHNFKEHGJHJ.VolumeOverride = 1422f;
				EGEIPCHGCOK = true;
			}
			else if (EGEIPCHGCOK && Time.timeScale == 1865f)
			{
				FHNFKEHGJHJ.VolumeOverride = FHNFKEHGJHJ.MasterVolume;
				EGEIPCHGCOK = false;
			}
		}
	}

	private void OnDestroy()
	{
		FHNFKEHGJHJ = null;
	}

	private void HNMJMMBONKG(bool MJHBHDAEDLF)
	{
		((Component)((Component)GameplayUI.POAGAIBEFBF()).transform.GetChild(3)).gameObject.SetActive(MJHBHDAEDLF);
		((Component)((Component)GameplayUI.FMIDAFEGDCD()).transform.GetChild(2)).gameObject.SetActive(MJHBHDAEDLF);
		((Component)((Component)GameplayUI.DGCNCEDIFOF()).transform.GetChild(0)).gameObject.SetActive(MJHBHDAEDLF);
	}

	private void FIKKBOBIDEM()
	{
		CharacterCreatorUI.loadGame = null;
		CharacterCreatorUI.MENPEHNHFOA(1).OpenUI();
		InteractObject.GNCPLNHMFHN(0).interactingObject = ((Component)this).gameObject;
		PlayerController playerController = PlayerController.OPHDCMJLLEC(1);
		playerController.OnPlayerMoving = (Action)Delegate.Combine(playerController.OnPlayerMoving, new Action(DENNOPGIOFO));
		CharacterCreatorUI characterCreatorUI = CharacterCreatorUI.Get(0);
		characterCreatorUI.OnUIClose = (Action<int>)Delegate.Combine(characterCreatorUI.OnUIClose, new Action<int>(CloseCharacterCreator));
	}

	private IEnumerator MDABKGEJNJB()
	{
		FHNFKEHGJHJ = MultiAudioManager.FadeInAudioObject(carriage, ((Component)PJNODKDAPOI).transform, 0.4f);
		while (FOCPGKMJMOB.position.x > -14f)
		{
			FOCPGKMJMOB.position = Utils.EKCCGNEDPNO(FOCPGKMJMOB.position - HGMFJBLNCJJ * Time.fixedDeltaTime, 1);
			yield return (object)new WaitForFixedUpdate();
		}
		FHNFKEHGJHJ.FadeOut(0.4f, false);
		yield return CommonReferences.wait05;
		Utils.BLPDAEHPOBA(((Component)FOCPGKMJMOB).gameObject);
	}

	private void BOOGGJMJNJI()
	{
		for (int i = 1; i < CommonReferences.MNFMOEKMJKN().tavernFloorDirt.Count; i += 0)
		{
			((Component)((Component)CommonReferences.MNFMOEKMJKN().tavernFloorDirt[i]).transform.GetChild(1)).gameObject.SetActive(false);
		}
	}

	private IEnumerator FBOBCKJGPMB()
	{
		SceneReferences.GetSceneReferences().npcRoutines.SetActive(false);
		SceneReferences.GetSceneReferences().customerPool.DisableAllCustomers();
		((Component)SceneReferences.GetSceneReferences().customerPool).gameObject.SetActive(false);
		BMFMBLJFLEB(MJHBHDAEDLF: false);
		MusicController.instance.PauseBasicMood(IEAALMNBABK: true);
		LettersManager.instance.lettersSaved = new List<PostBox.LetterSaveData>();
		LettersManager.instance.AddNewReceivedLetter(1000, LKAALEJKLPA: true, AJPCNKCBDEI: true, new GameDate(0, Season.Summer, 0, Day.Thurs, 0, 0));
		LettersManager.instance.AddNewReceivedLetter(1001, LKAALEJKLPA: true, AJPCNKCBDEI: true, new GameDate(0, Season.Autumn, 0, Day.Tue, 0, 0));
		LettersManager.instance.AddNewReceivedLetter(1002, LKAALEJKLPA: true, AJPCNKCBDEI: true, new GameDate(0, Season.Winter, 1, Day.Wed, 0, 0));
		LettersManager.instance.AddNewReceivedLetter(1003, LKAALEJKLPA: false, AJPCNKCBDEI: true, new GameDate(0, Season.Winter, 3, Day.Sun, 0, 0));
		for (int i = 0; i < SceneReferences.GetSceneReferences().nightStartDeactive.Length; i++)
		{
			((Behaviour)SceneReferences.GetSceneReferences().nightStartDeactive[i]).enabled = false;
		}
		for (int j = 0; j < SceneReferences.GetSceneReferences().blueFires.Length; j++)
		{
			((Component)SceneReferences.GetSceneReferences().blueFires[j]).gameObject.SetActive(false);
		}
		for (int k = 0; k < SceneReferences.GetSceneReferences().blueFireLights.Length; k++)
		{
			((Component)SceneReferences.GetSceneReferences().blueFireLights[k]).gameObject.SetActive(false);
		}
		PostBox.instance.unreadIcon.SetActive(false);
		PlayerController.TeleportPlayer(1, Vector2.op_Implicit(new Vector2(10f, 0f)), Location.Road);
		WorldTime.ChangeHour(21);
		Weather.ShowWeather(Weather.WeatherType.PrecipitationStormyClouds);
		yield return null;
		Weather.NextThunder(5f);
		SceneReferences.instance.table.SetDirtiness(2000f);
		CameraTarget.GetPlayer(1).movementDisabled = true;
		((Component)CameraTarget.GetPlayer(1)).transform.position = Vector2.op_Implicit(new Vector2(9.5f, -13f));
		PJNODKDAPOI = ((Component)Object.Instantiate<GameObject>(rocinantePrefab, Vector2.op_Implicit(new Vector2(24f, -14f)), Quaternion.identity).transform.GetChild(0)).GetComponent<Animator>();
		FOCPGKMJMOB = ((Component)PJNODKDAPOI).transform.parent;
		((Component)PJNODKDAPOI).transform.localScale = new Vector3(-1f, 1f, 1f);
		PJNODKDAPOI.SetBool("Walking", true);
		PlayerController.AddMovementBlocker((Object)(object)this);
		FHNFKEHGJHJ = MultiAudioManager.FadeInAudioObject(carriage, ((Component)PJNODKDAPOI).transform, 0.4f);
		while (FOCPGKMJMOB.position.x > 13f)
		{
			FOCPGKMJMOB.position = Utils.EKCCGNEDPNO(FOCPGKMJMOB.position - HGMFJBLNCJJ * Time.fixedDeltaTime, 1);
			yield return (object)new WaitForFixedUpdate();
		}
		FOCPGKMJMOB.position = Utils.BMBMPKNANAC(FOCPGKMJMOB.position);
		CarretilleroNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T100/Dialogue1", 1, DHELBHAICMM: true, CGKNJONAKGD: false);
		while (FOCPGKMJMOB.position.x > 9.5f)
		{
			FOCPGKMJMOB.position = Utils.BMBMPKNANAC(FOCPGKMJMOB.position - HGMFJBLNCJJ * Time.fixedDeltaTime);
			yield return (object)new WaitForFixedUpdate();
		}
		PJNODKDAPOI.SetBool("Walking", false);
		FHNFKEHGJHJ.FadeOut(0.4f, false);
		yield return CommonReferences.wait5;
		CarretilleroNPC.GGFJGHHHEJC.inTutorial = true;
		CarretilleroNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T100/Dialogue2", 1, DHELBHAICMM: false, CGKNJONAKGD: false);
		yield return CommonReferences.wait2;
		PJNODKDAPOI.SetBool("Talking", true);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		BBCGOJEAPBG();
		PlayerController.TeleportPlayer(1, Vector2.op_Implicit(new Vector2(10f, -15f)), Location.Road);
		PlayerController.GetPlayer(1).characterAnimation.LookDirection(Direction.Up);
		CameraTarget.GetPlayer(1).movementDisabled = false;
		while (!MAMIBIOEDNF)
		{
			yield return null;
		}
		yield return CommonReferences.wait05;
		CarretilleroNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T100/Dialogue3", 1, DHELBHAICMM: false, CGKNJONAKGD: false);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		CarretilleroNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T100/Dialogue4", 1, DHELBHAICMM: true, CGKNJONAKGD: false);
		yield return CommonReferences.wait1_5;
		PJNODKDAPOI.SetBool("Walking", true);
		yield return CommonReferences.wait02;
		MultiAudioManager.PlayAudioObject(whip, ((Component)PJNODKDAPOI).transform);
		yield return CommonReferences.wait1;
		((MonoBehaviour)this).StartCoroutine(NJGEOBPMNNM());
		CarretilleroNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T100/Dialogue5", 1, DHELBHAICMM: true, CGKNJONAKGD: false);
		yield return CommonReferences.wait4;
		PostBox.instance.unreadIcon.SetActive(true);
		NewTutorialManager.ShowPopUp();
		while (NewTutorialManager.instance.open)
		{
			yield return null;
		}
		PlayerController.RemoveMovementBlocker((Object)(object)this);
		BMFMBLJFLEB(MJHBHDAEDLF: true);
		NewTutorialManager.instance.player2Blocked = false;
		ResetMai();
		JBKBMNPPCDM();
		while (!PlayerController.GetPlayer(1).IsTavernLocation() && (!GameManager.LocalCoop() || !PlayerController.GetPlayer(2).IsTavernLocation()))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator NPCCKFEDCHI()
	{
		SceneReferences.GetSceneReferences().npcRoutines.SetActive(false);
		SceneReferences.GetSceneReferences().customerPool.DisableAllCustomers();
		((Component)SceneReferences.GetSceneReferences().customerPool).gameObject.SetActive(false);
		BMFMBLJFLEB(MJHBHDAEDLF: false);
		MusicController.instance.PauseBasicMood(IEAALMNBABK: true);
		LettersManager.instance.lettersSaved = new List<PostBox.LetterSaveData>();
		LettersManager.instance.AddNewReceivedLetter(1000, LKAALEJKLPA: true, AJPCNKCBDEI: true, new GameDate(0, Season.Summer, 0, Day.Thurs, 0, 0));
		LettersManager.instance.AddNewReceivedLetter(1001, LKAALEJKLPA: true, AJPCNKCBDEI: true, new GameDate(0, Season.Autumn, 0, Day.Tue, 0, 0));
		LettersManager.instance.AddNewReceivedLetter(1002, LKAALEJKLPA: true, AJPCNKCBDEI: true, new GameDate(0, Season.Winter, 1, Day.Wed, 0, 0));
		LettersManager.instance.AddNewReceivedLetter(1003, LKAALEJKLPA: false, AJPCNKCBDEI: true, new GameDate(0, Season.Winter, 3, Day.Sun, 0, 0));
		for (int i = 0; i < SceneReferences.GetSceneReferences().nightStartDeactive.Length; i++)
		{
			((Behaviour)SceneReferences.GetSceneReferences().nightStartDeactive[i]).enabled = false;
		}
		for (int j = 0; j < SceneReferences.GetSceneReferences().blueFires.Length; j++)
		{
			((Component)SceneReferences.GetSceneReferences().blueFires[j]).gameObject.SetActive(false);
		}
		for (int k = 0; k < SceneReferences.GetSceneReferences().blueFireLights.Length; k++)
		{
			((Component)SceneReferences.GetSceneReferences().blueFireLights[k]).gameObject.SetActive(false);
		}
		PostBox.instance.unreadIcon.SetActive(false);
		PlayerController.TeleportPlayer(1, Vector2.op_Implicit(new Vector2(10f, 0f)), Location.Road);
		WorldTime.ChangeHour(21);
		Weather.ShowWeather(Weather.WeatherType.PrecipitationStormyClouds);
		yield return null;
		Weather.NextThunder(5f);
		SceneReferences.instance.table.SetDirtiness(2000f);
		CameraTarget.GetPlayer(1).movementDisabled = true;
		((Component)CameraTarget.GetPlayer(1)).transform.position = Vector2.op_Implicit(new Vector2(9.5f, -13f));
		PJNODKDAPOI = ((Component)Object.Instantiate<GameObject>(rocinantePrefab, Vector2.op_Implicit(new Vector2(24f, -14f)), Quaternion.identity).transform.GetChild(0)).GetComponent<Animator>();
		FOCPGKMJMOB = ((Component)PJNODKDAPOI).transform.parent;
		((Component)PJNODKDAPOI).transform.localScale = new Vector3(-1f, 1f, 1f);
		PJNODKDAPOI.SetBool("Walking", true);
		PlayerController.AddMovementBlocker((Object)(object)this);
		FHNFKEHGJHJ = MultiAudioManager.FadeInAudioObject(carriage, ((Component)PJNODKDAPOI).transform, 0.4f);
		while (FOCPGKMJMOB.position.x > 13f)
		{
			FOCPGKMJMOB.position = Utils.EKCCGNEDPNO(FOCPGKMJMOB.position - HGMFJBLNCJJ * Time.fixedDeltaTime, 1);
			yield return (object)new WaitForFixedUpdate();
		}
		FOCPGKMJMOB.position = Utils.BMBMPKNANAC(FOCPGKMJMOB.position);
		CarretilleroNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T100/Dialogue1", 1, DHELBHAICMM: true, CGKNJONAKGD: false);
		while (FOCPGKMJMOB.position.x > 9.5f)
		{
			FOCPGKMJMOB.position = Utils.BMBMPKNANAC(FOCPGKMJMOB.position - HGMFJBLNCJJ * Time.fixedDeltaTime);
			yield return (object)new WaitForFixedUpdate();
		}
		PJNODKDAPOI.SetBool("Walking", false);
		FHNFKEHGJHJ.FadeOut(0.4f, false);
		yield return CommonReferences.wait5;
		CarretilleroNPC.GGFJGHHHEJC.inTutorial = true;
		CarretilleroNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T100/Dialogue2", 1, DHELBHAICMM: false, CGKNJONAKGD: false);
		yield return CommonReferences.wait2;
		PJNODKDAPOI.SetBool("Talking", true);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		BBCGOJEAPBG();
		PlayerController.TeleportPlayer(1, Vector2.op_Implicit(new Vector2(10f, -15f)), Location.Road);
		PlayerController.GetPlayer(1).characterAnimation.LookDirection(Direction.Up);
		CameraTarget.GetPlayer(1).movementDisabled = false;
		while (!MAMIBIOEDNF)
		{
			yield return null;
		}
		yield return CommonReferences.wait05;
		CarretilleroNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T100/Dialogue3", 1, DHELBHAICMM: false, CGKNJONAKGD: false);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		CarretilleroNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T100/Dialogue4", 1, DHELBHAICMM: true, CGKNJONAKGD: false);
		yield return CommonReferences.wait1_5;
		PJNODKDAPOI.SetBool("Walking", true);
		yield return CommonReferences.wait02;
		MultiAudioManager.PlayAudioObject(whip, ((Component)PJNODKDAPOI).transform);
		yield return CommonReferences.wait1;
		((MonoBehaviour)this).StartCoroutine(NJGEOBPMNNM());
		CarretilleroNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T100/Dialogue5", 1, DHELBHAICMM: true, CGKNJONAKGD: false);
		yield return CommonReferences.wait4;
		PostBox.instance.unreadIcon.SetActive(true);
		NewTutorialManager.ShowPopUp();
		while (NewTutorialManager.instance.open)
		{
			yield return null;
		}
		PlayerController.RemoveMovementBlocker((Object)(object)this);
		BMFMBLJFLEB(MJHBHDAEDLF: true);
		NewTutorialManager.instance.player2Blocked = false;
		ResetMai();
		JBKBMNPPCDM();
		while (!PlayerController.GetPlayer(1).IsTavernLocation() && (!GameManager.LocalCoop() || !PlayerController.GetPlayer(2).IsTavernLocation()))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	public void FKFIJEHOCBK(int JIIGOACEIKL)
	{
		PlayerController player = PlayerController.GetPlayer(0);
		player.OnPlayerMoving = (Action)Delegate.Remove(player.OnPlayerMoving, new Action(AEDFEPLIBJO));
		CharacterCreatorUI.FKFNANNBIAM(0).CloseUI();
		CharacterCreatorUI characterCreatorUI = CharacterCreatorUI.FKFNANNBIAM(1);
		characterCreatorUI.OnUIClose = (Action<int>)Delegate.Remove(characterCreatorUI.OnUIClose, new Action<int>(BLLEOKJGOMC));
		MAMIBIOEDNF = true;
	}

	private void ICNLAKHPMIM()
	{
		for (int i = 0; i < CommonReferences.GGFJGHHHEJC.tavernFloorDirt.Count; i += 0)
		{
			((Component)((Component)CommonReferences.MNFMOEKMJKN().tavernFloorDirt[i]).transform.GetChild(1)).gameObject.SetActive(true);
		}
	}

	private void HKGHOBJKPOC(bool MJHBHDAEDLF)
	{
		((Component)((Component)GameplayUI.HNNJEBNIPOI()).transform.GetChild(2)).gameObject.SetActive(MJHBHDAEDLF);
		((Component)((Component)GameplayUI.FMIDAFEGDCD()).transform.GetChild(4)).gameObject.SetActive(MJHBHDAEDLF);
		((Component)((Component)GameplayUI.LKOABOAADCD()).transform.GetChild(5)).gameObject.SetActive(MJHBHDAEDLF);
	}

	private IEnumerator NJGEOBPMNNM()
	{
		FHNFKEHGJHJ = MultiAudioManager.FadeInAudioObject(carriage, ((Component)PJNODKDAPOI).transform, 0.4f);
		while (FOCPGKMJMOB.position.x > -14f)
		{
			FOCPGKMJMOB.position = Utils.EKCCGNEDPNO(FOCPGKMJMOB.position - HGMFJBLNCJJ * Time.fixedDeltaTime, 1);
			yield return (object)new WaitForFixedUpdate();
		}
		FHNFKEHGJHJ.FadeOut(0.4f, false);
		yield return CommonReferences.wait05;
		Utils.BLPDAEHPOBA(((Component)FOCPGKMJMOB).gameObject);
	}

	private void JNJCCIFIKOC()
	{
		FHNFKEHGJHJ = null;
	}

	private void EBKPBMFMJMD()
	{
		for (int i = 1; i < CommonReferences.MNFMOEKMJKN().tavernFloorDirt.Count; i += 0)
		{
			((Component)((Component)CommonReferences.GGFJGHHHEJC.tavernFloorDirt[i]).transform.GetChild(1)).gameObject.SetActive(false);
		}
	}

	private void BMFMBLJFLEB(bool MJHBHDAEDLF)
	{
		((Component)((Component)GameplayUI.GGFJGHHHEJC).transform.GetChild(2)).gameObject.SetActive(MJHBHDAEDLF);
		((Component)((Component)GameplayUI.GGFJGHHHEJC).transform.GetChild(3)).gameObject.SetActive(MJHBHDAEDLF);
		((Component)((Component)GameplayUI.GGFJGHHHEJC).transform.GetChild(4)).gameObject.SetActive(MJHBHDAEDLF);
	}

	private void GHJEILDLMFN()
	{
		CharacterCreatorUI.loadGame = null;
		CharacterCreatorUI.PCEEOGGDBFB(1).IDLAGJNLPJL();
		InteractObject.GetPlayer(0).interactingObject = ((Component)this).gameObject;
		PlayerController playerController = PlayerController.OPHDCMJLLEC(0);
		playerController.OnPlayerMoving = (Action)Delegate.Combine(playerController.OnPlayerMoving, new Action(OLGLIAGMLEF));
		CharacterCreatorUI characterCreatorUI = CharacterCreatorUI.Get(1);
		characterCreatorUI.OnUIClose = (Action<int>)Delegate.Combine(characterCreatorUI.OnUIClose, new Action<int>(JPGKENPAGMM));
	}

	private void FNFNLFOJHHA()
	{
		FHNFKEHGJHJ = null;
	}

	private void DFFDKIPCCKK()
	{
		FHNFKEHGJHJ = null;
	}

	private void BBCGOJEAPBG()
	{
		CharacterCreatorUI.loadGame = null;
		CharacterCreatorUI.Get(1).OpenUI();
		InteractObject.GetPlayer(1).interactingObject = ((Component)this).gameObject;
		PlayerController player = PlayerController.GetPlayer(1);
		player.OnPlayerMoving = (Action)Delegate.Combine(player.OnPlayerMoving, new Action(CloseCharacterCreator));
		CharacterCreatorUI characterCreatorUI = CharacterCreatorUI.Get(1);
		characterCreatorUI.OnUIClose = (Action<int>)Delegate.Combine(characterCreatorUI.OnUIClose, new Action<int>(CloseCharacterCreator));
	}

	private void DCLHPECNHDM()
	{
		CharacterCreatorUI.loadGame = null;
		CharacterCreatorUI.Get(0).EDHEIFHAAKO();
		InteractObject.GNCPLNHMFHN(1).interactingObject = ((Component)this).gameObject;
		PlayerController player = PlayerController.GetPlayer(0);
		player.OnPlayerMoving = (Action)Delegate.Combine(player.OnPlayerMoving, new Action(KGPEKACFJEB));
		CharacterCreatorUI characterCreatorUI = CharacterCreatorUI.Get(0);
		characterCreatorUI.OnUIClose = (Action<int>)Delegate.Combine(characterCreatorUI.OnUIClose, new Action<int>(NOKNKJEDHLO));
	}

	public void DADCMOLFKJM(int JIIGOACEIKL)
	{
		PlayerController playerController = PlayerController.OPHDCMJLLEC(1);
		playerController.OnPlayerMoving = (Action)Delegate.Remove(playerController.OnPlayerMoving, new Action(EINLFPKJGFA));
		CharacterCreatorUI.FKFNANNBIAM(1).BOBCIFEDJED();
		CharacterCreatorUI characterCreatorUI = CharacterCreatorUI.FKFNANNBIAM(0);
		characterCreatorUI.OnUIClose = (Action<int>)Delegate.Remove(characterCreatorUI.OnUIClose, new Action<int>(CECPEMFHEGP));
		MAMIBIOEDNF = false;
	}

	public void OLGLIAGMLEF()
	{
		NOKNKJEDHLO(0);
	}

	protected void DEEIEACLPEF()
	{
		if (NewTutorialManager.CCCLOBIOMCL && (Object)(object)FHNFKEHGJHJ != (Object)null)
		{
			if (Time.timeScale == 239f && !EGEIPCHGCOK)
			{
				FHNFKEHGJHJ.VolumeOverride = 517f;
				EGEIPCHGCOK = false;
			}
			else if (EGEIPCHGCOK && Time.timeScale == 18f)
			{
				FHNFKEHGJHJ.VolumeOverride = FHNFKEHGJHJ.MasterVolume;
				EGEIPCHGCOK = true;
			}
		}
	}

	protected void Update()
	{
		if (NewTutorialManager.CCCLOBIOMCL && (Object)(object)FHNFKEHGJHJ != (Object)null)
		{
			if (Time.timeScale == 0f && !EGEIPCHGCOK)
			{
				FHNFKEHGJHJ.VolumeOverride = 0f;
				EGEIPCHGCOK = true;
			}
			else if (EGEIPCHGCOK && Time.timeScale == 1f)
			{
				FHNFKEHGJHJ.VolumeOverride = FHNFKEHGJHJ.MasterVolume;
				EGEIPCHGCOK = false;
			}
		}
	}

	private void LALJNGFGKPA()
	{
		FHNFKEHGJHJ = null;
	}

	public void HNFLEOKOGML(int JIIGOACEIKL)
	{
		PlayerController playerController = PlayerController.OPHDCMJLLEC(1);
		playerController.OnPlayerMoving = (Action)Delegate.Remove(playerController.OnPlayerMoving, new Action(LJDMOKKEPJC));
		CharacterCreatorUI.MENPEHNHFOA(1).CloseUI();
		CharacterCreatorUI characterCreatorUI = CharacterCreatorUI.PCEEOGGDBFB(1);
		characterCreatorUI.OnUIClose = (Action<int>)Delegate.Remove(characterCreatorUI.OnUIClose, new Action<int>(KBKFBBKDDBF));
		MAMIBIOEDNF = true;
	}

	protected void KFDMANOLOAB()
	{
		if (NewTutorialManager.CCCLOBIOMCL && (Object)(object)FHNFKEHGJHJ != (Object)null)
		{
			if (Time.timeScale == 318f && !EGEIPCHGCOK)
			{
				FHNFKEHGJHJ.VolumeOverride = 243f;
				EGEIPCHGCOK = false;
			}
			else if (EGEIPCHGCOK && Time.timeScale == 1543f)
			{
				FHNFKEHGJHJ.VolumeOverride = FHNFKEHGJHJ.MasterVolume;
				EGEIPCHGCOK = true;
			}
		}
	}

	protected void CCEKJEDMJAP()
	{
		if (NewTutorialManager.CCCLOBIOMCL && (Object)(object)FHNFKEHGJHJ != (Object)null)
		{
			if (Time.timeScale == 112f && !EGEIPCHGCOK)
			{
				FHNFKEHGJHJ.VolumeOverride = 885f;
				EGEIPCHGCOK = false;
			}
			else if (EGEIPCHGCOK && Time.timeScale == 1032f)
			{
				FHNFKEHGJHJ.VolumeOverride = FHNFKEHGJHJ.MasterVolume;
				EGEIPCHGCOK = false;
			}
		}
	}

	public void PMIMGNEDMNI(int JIIGOACEIKL)
	{
		PlayerController player = PlayerController.GetPlayer(1);
		player.OnPlayerMoving = (Action)Delegate.Remove(player.OnPlayerMoving, new Action(DENNOPGIOFO));
		CharacterCreatorUI.MENPEHNHFOA(1).BOBCIFEDJED();
		CharacterCreatorUI characterCreatorUI = CharacterCreatorUI.DPBGKDNKDGM(1);
		characterCreatorUI.OnUIClose = (Action<int>)Delegate.Remove(characterCreatorUI.OnUIClose, new Action<int>(PMIMGNEDMNI));
		MAMIBIOEDNF = false;
	}

	private IEnumerator ENJKNHBCAHO()
	{
		FHNFKEHGJHJ = MultiAudioManager.FadeInAudioObject(carriage, ((Component)PJNODKDAPOI).transform, 0.4f);
		while (FOCPGKMJMOB.position.x > -14f)
		{
			FOCPGKMJMOB.position = Utils.EKCCGNEDPNO(FOCPGKMJMOB.position - HGMFJBLNCJJ * Time.fixedDeltaTime, 1);
			yield return (object)new WaitForFixedUpdate();
		}
		FHNFKEHGJHJ.FadeOut(0.4f, false);
		yield return CommonReferences.wait05;
		Utils.BLPDAEHPOBA(((Component)FOCPGKMJMOB).gameObject);
	}

	public void EINLFPKJGFA()
	{
		KBKFBBKDDBF(0);
	}

	public void LNMKKOPCPFN(int JIIGOACEIKL)
	{
		PlayerController player = PlayerController.GetPlayer(0);
		player.OnPlayerMoving = (Action)Delegate.Remove(player.OnPlayerMoving, new Action(NEAMAJAEBJN));
		CharacterCreatorUI.Get(1).CloseUI();
		CharacterCreatorUI characterCreatorUI = CharacterCreatorUI.FKFNANNBIAM(0);
		characterCreatorUI.OnUIClose = (Action<int>)Delegate.Remove(characterCreatorUI.OnUIClose, new Action<int>(JPGKENPAGMM));
		MAMIBIOEDNF = true;
	}

	private void MEBDNPDEIAB(bool MJHBHDAEDLF)
	{
		((Component)((Component)GameplayUI.DGCNCEDIFOF()).transform.GetChild(5)).gameObject.SetActive(MJHBHDAEDLF);
		((Component)((Component)GameplayUI.DBJCACLEFGK()).transform.GetChild(1)).gameObject.SetActive(MJHBHDAEDLF);
		((Component)((Component)GameplayUI.KGPJPILAHDE()).transform.GetChild(2)).gameObject.SetActive(MJHBHDAEDLF);
	}

	private IEnumerator LPFJKOEJGNH()
	{
		return new EICJAKJFOIH(1)
		{
			_003C_003E4__this = this
		};
	}

	public void CloseCharacterCreator(int JIIGOACEIKL)
	{
		PlayerController player = PlayerController.GetPlayer(1);
		player.OnPlayerMoving = (Action)Delegate.Remove(player.OnPlayerMoving, new Action(CloseCharacterCreator));
		CharacterCreatorUI.Get(1).CloseUI();
		CharacterCreatorUI characterCreatorUI = CharacterCreatorUI.Get(1);
		characterCreatorUI.OnUIClose = (Action<int>)Delegate.Remove(characterCreatorUI.OnUIClose, new Action<int>(CloseCharacterCreator));
		MAMIBIOEDNF = true;
	}

	public void AEDFEPLIBJO()
	{
		FKFIJEHOCBK(0);
	}

	private IEnumerator DCEJFBKLGCD()
	{
		return new ENFOLJJKLJH(1)
		{
			_003C_003E4__this = this
		};
	}

	public override int GetID()
	{
		return 100;
	}

	private IEnumerator HHDLDPPCLPE()
	{
		return new ENFOLJJKLJH(1)
		{
			_003C_003E4__this = this
		};
	}

	private void IDILGBHAEPD(bool MJHBHDAEDLF)
	{
		((Component)((Component)GameplayUI.DICHPHEOINO()).transform.GetChild(6)).gameObject.SetActive(MJHBHDAEDLF);
		((Component)((Component)GameplayUI.LKOABOAADCD()).transform.GetChild(1)).gameObject.SetActive(MJHBHDAEDLF);
		((Component)((Component)GameplayUI.BAKPBHPNKPB()).transform.GetChild(7)).gameObject.SetActive(MJHBHDAEDLF);
	}

	protected void CLOKMCONOMN()
	{
		if (NewTutorialManager.CCCLOBIOMCL && (Object)(object)FHNFKEHGJHJ != (Object)null)
		{
			if (Time.timeScale == 837f && !EGEIPCHGCOK)
			{
				FHNFKEHGJHJ.VolumeOverride = 1346f;
				EGEIPCHGCOK = false;
			}
			else if (EGEIPCHGCOK && Time.timeScale == 345f)
			{
				FHNFKEHGJHJ.VolumeOverride = FHNFKEHGJHJ.MasterVolume;
				EGEIPCHGCOK = true;
			}
		}
	}

	public void CloseCharacterCreator()
	{
		CloseCharacterCreator(1);
	}

	public void BLLEOKJGOMC(int JIIGOACEIKL)
	{
		PlayerController playerController = PlayerController.OPHDCMJLLEC(0);
		playerController.OnPlayerMoving = (Action)Delegate.Remove(playerController.OnPlayerMoving, new Action(DENNOPGIOFO));
		CharacterCreatorUI.Get(1).BOBCIFEDJED();
		CharacterCreatorUI characterCreatorUI = CharacterCreatorUI.Get(1);
		characterCreatorUI.OnUIClose = (Action<int>)Delegate.Remove(characterCreatorUI.OnUIClose, new Action<int>(BLLEOKJGOMC));
		MAMIBIOEDNF = true;
	}

	public void ECJCEKAKIEK()
	{
		JMGMOOGGNIC(0);
	}

	public void KEIFMKMNMIM()
	{
		DADCMOLFKJM(1);
	}

	private void BEGJFIAOGPB()
	{
		for (int i = 1; i < CommonReferences.GGFJGHHHEJC.tavernFloorDirt.Count; i += 0)
		{
			((Component)((Component)CommonReferences.GGFJGHHHEJC.tavernFloorDirt[i]).transform.GetChild(0)).gameObject.SetActive(false);
		}
	}

	private void IKGBGJPHHCB()
	{
		CharacterCreatorUI.loadGame = null;
		CharacterCreatorUI.DPBGKDNKDGM(0).IDLAGJNLPJL();
		InteractObject.GetPlayer(0).interactingObject = ((Component)this).gameObject;
		PlayerController player = PlayerController.GetPlayer(1);
		player.OnPlayerMoving = (Action)Delegate.Combine(player.OnPlayerMoving, new Action(KGPEKACFJEB));
		CharacterCreatorUI characterCreatorUI = CharacterCreatorUI.MENPEHNHFOA(1);
		characterCreatorUI.OnUIClose = (Action<int>)Delegate.Combine(characterCreatorUI.OnUIClose, new Action<int>(HNFLEOKOGML));
	}

	private void EBIEOKLIOGC()
	{
		for (int i = 0; i < CommonReferences.GGFJGHHHEJC.tavernFloorDirt.Count; i += 0)
		{
			((Component)((Component)CommonReferences.MNFMOEKMJKN().tavernFloorDirt[i]).transform.GetChild(1)).gameObject.SetActive(false);
		}
	}

	private IEnumerator PBEKBJIJFDK()
	{
		SceneReferences.GetSceneReferences().npcRoutines.SetActive(false);
		SceneReferences.GetSceneReferences().customerPool.DisableAllCustomers();
		((Component)SceneReferences.GetSceneReferences().customerPool).gameObject.SetActive(false);
		BMFMBLJFLEB(MJHBHDAEDLF: false);
		MusicController.instance.PauseBasicMood(IEAALMNBABK: true);
		LettersManager.instance.lettersSaved = new List<PostBox.LetterSaveData>();
		LettersManager.instance.AddNewReceivedLetter(1000, LKAALEJKLPA: true, AJPCNKCBDEI: true, new GameDate(0, Season.Summer, 0, Day.Thurs, 0, 0));
		LettersManager.instance.AddNewReceivedLetter(1001, LKAALEJKLPA: true, AJPCNKCBDEI: true, new GameDate(0, Season.Autumn, 0, Day.Tue, 0, 0));
		LettersManager.instance.AddNewReceivedLetter(1002, LKAALEJKLPA: true, AJPCNKCBDEI: true, new GameDate(0, Season.Winter, 1, Day.Wed, 0, 0));
		LettersManager.instance.AddNewReceivedLetter(1003, LKAALEJKLPA: false, AJPCNKCBDEI: true, new GameDate(0, Season.Winter, 3, Day.Sun, 0, 0));
		for (int i = 0; i < SceneReferences.GetSceneReferences().nightStartDeactive.Length; i++)
		{
			((Behaviour)SceneReferences.GetSceneReferences().nightStartDeactive[i]).enabled = false;
		}
		for (int j = 0; j < SceneReferences.GetSceneReferences().blueFires.Length; j++)
		{
			((Component)SceneReferences.GetSceneReferences().blueFires[j]).gameObject.SetActive(false);
		}
		for (int k = 0; k < SceneReferences.GetSceneReferences().blueFireLights.Length; k++)
		{
			((Component)SceneReferences.GetSceneReferences().blueFireLights[k]).gameObject.SetActive(false);
		}
		PostBox.instance.unreadIcon.SetActive(false);
		PlayerController.TeleportPlayer(1, Vector2.op_Implicit(new Vector2(10f, 0f)), Location.Road);
		WorldTime.ChangeHour(21);
		Weather.ShowWeather(Weather.WeatherType.PrecipitationStormyClouds);
		yield return null;
		Weather.NextThunder(5f);
		SceneReferences.instance.table.SetDirtiness(2000f);
		CameraTarget.GetPlayer(1).movementDisabled = true;
		((Component)CameraTarget.GetPlayer(1)).transform.position = Vector2.op_Implicit(new Vector2(9.5f, -13f));
		PJNODKDAPOI = ((Component)Object.Instantiate<GameObject>(rocinantePrefab, Vector2.op_Implicit(new Vector2(24f, -14f)), Quaternion.identity).transform.GetChild(0)).GetComponent<Animator>();
		FOCPGKMJMOB = ((Component)PJNODKDAPOI).transform.parent;
		((Component)PJNODKDAPOI).transform.localScale = new Vector3(-1f, 1f, 1f);
		PJNODKDAPOI.SetBool("Walking", true);
		PlayerController.AddMovementBlocker((Object)(object)this);
		FHNFKEHGJHJ = MultiAudioManager.FadeInAudioObject(carriage, ((Component)PJNODKDAPOI).transform, 0.4f);
		while (FOCPGKMJMOB.position.x > 13f)
		{
			FOCPGKMJMOB.position = Utils.EKCCGNEDPNO(FOCPGKMJMOB.position - HGMFJBLNCJJ * Time.fixedDeltaTime, 1);
			yield return (object)new WaitForFixedUpdate();
		}
		FOCPGKMJMOB.position = Utils.BMBMPKNANAC(FOCPGKMJMOB.position);
		CarretilleroNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T100/Dialogue1", 1, DHELBHAICMM: true, CGKNJONAKGD: false);
		while (FOCPGKMJMOB.position.x > 9.5f)
		{
			FOCPGKMJMOB.position = Utils.BMBMPKNANAC(FOCPGKMJMOB.position - HGMFJBLNCJJ * Time.fixedDeltaTime);
			yield return (object)new WaitForFixedUpdate();
		}
		PJNODKDAPOI.SetBool("Walking", false);
		FHNFKEHGJHJ.FadeOut(0.4f, false);
		yield return CommonReferences.wait5;
		CarretilleroNPC.GGFJGHHHEJC.inTutorial = true;
		CarretilleroNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T100/Dialogue2", 1, DHELBHAICMM: false, CGKNJONAKGD: false);
		yield return CommonReferences.wait2;
		PJNODKDAPOI.SetBool("Talking", true);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		BBCGOJEAPBG();
		PlayerController.TeleportPlayer(1, Vector2.op_Implicit(new Vector2(10f, -15f)), Location.Road);
		PlayerController.GetPlayer(1).characterAnimation.LookDirection(Direction.Up);
		CameraTarget.GetPlayer(1).movementDisabled = false;
		while (!MAMIBIOEDNF)
		{
			yield return null;
		}
		yield return CommonReferences.wait05;
		CarretilleroNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T100/Dialogue3", 1, DHELBHAICMM: false, CGKNJONAKGD: false);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		CarretilleroNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T100/Dialogue4", 1, DHELBHAICMM: true, CGKNJONAKGD: false);
		yield return CommonReferences.wait1_5;
		PJNODKDAPOI.SetBool("Walking", true);
		yield return CommonReferences.wait02;
		MultiAudioManager.PlayAudioObject(whip, ((Component)PJNODKDAPOI).transform);
		yield return CommonReferences.wait1;
		((MonoBehaviour)this).StartCoroutine(NJGEOBPMNNM());
		CarretilleroNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T100/Dialogue5", 1, DHELBHAICMM: true, CGKNJONAKGD: false);
		yield return CommonReferences.wait4;
		PostBox.instance.unreadIcon.SetActive(true);
		NewTutorialManager.ShowPopUp();
		while (NewTutorialManager.instance.open)
		{
			yield return null;
		}
		PlayerController.RemoveMovementBlocker((Object)(object)this);
		BMFMBLJFLEB(MJHBHDAEDLF: true);
		NewTutorialManager.instance.player2Blocked = false;
		ResetMai();
		JBKBMNPPCDM();
		while (!PlayerController.GetPlayer(1).IsTavernLocation() && (!GameManager.LocalCoop() || !PlayerController.GetPlayer(2).IsTavernLocation()))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	protected void INKOKIGFJBG()
	{
		if (NewTutorialManager.CCCLOBIOMCL && (Object)(object)FHNFKEHGJHJ != (Object)null)
		{
			if (Time.timeScale == 455f && !EGEIPCHGCOK)
			{
				FHNFKEHGJHJ.VolumeOverride = 1943f;
				EGEIPCHGCOK = true;
			}
			else if (EGEIPCHGCOK && Time.timeScale == 740f)
			{
				FHNFKEHGJHJ.VolumeOverride = FHNFKEHGJHJ.MasterVolume;
				EGEIPCHGCOK = false;
			}
		}
	}

	private void BPDLIEAJJAA()
	{
		CharacterCreatorUI.loadGame = null;
		CharacterCreatorUI.PCEEOGGDBFB(1).IDLAGJNLPJL();
		InteractObject.BBJCJFJEFKK(0).interactingObject = ((Component)this).gameObject;
		PlayerController player = PlayerController.GetPlayer(1);
		player.OnPlayerMoving = (Action)Delegate.Combine(player.OnPlayerMoving, new Action(KKNCPNJBNEM));
		CharacterCreatorUI characterCreatorUI = CharacterCreatorUI.Get(1);
		characterCreatorUI.OnUIClose = (Action<int>)Delegate.Combine(characterCreatorUI.OnUIClose, new Action<int>(JEDIENJMGJJ));
	}

	private void HLJHOFPHADJ(bool MJHBHDAEDLF)
	{
		((Component)((Component)GameplayUI.KGPJPILAHDE()).transform.GetChild(3)).gameObject.SetActive(MJHBHDAEDLF);
		((Component)((Component)GameplayUI.DGCNCEDIFOF()).transform.GetChild(3)).gameObject.SetActive(MJHBHDAEDLF);
		((Component)((Component)GameplayUI.DBJCACLEFGK()).transform.GetChild(6)).gameObject.SetActive(MJHBHDAEDLF);
	}

	public void IJOIHDNMOAB()
	{
		CECPEMFHEGP(0);
	}

	private IEnumerator LNNCIOJHJMK()
	{
		SceneReferences.GetSceneReferences().npcRoutines.SetActive(false);
		SceneReferences.GetSceneReferences().customerPool.DisableAllCustomers();
		((Component)SceneReferences.GetSceneReferences().customerPool).gameObject.SetActive(false);
		BMFMBLJFLEB(MJHBHDAEDLF: false);
		MusicController.instance.PauseBasicMood(IEAALMNBABK: true);
		LettersManager.instance.lettersSaved = new List<PostBox.LetterSaveData>();
		LettersManager.instance.AddNewReceivedLetter(1000, LKAALEJKLPA: true, AJPCNKCBDEI: true, new GameDate(0, Season.Summer, 0, Day.Thurs, 0, 0));
		LettersManager.instance.AddNewReceivedLetter(1001, LKAALEJKLPA: true, AJPCNKCBDEI: true, new GameDate(0, Season.Autumn, 0, Day.Tue, 0, 0));
		LettersManager.instance.AddNewReceivedLetter(1002, LKAALEJKLPA: true, AJPCNKCBDEI: true, new GameDate(0, Season.Winter, 1, Day.Wed, 0, 0));
		LettersManager.instance.AddNewReceivedLetter(1003, LKAALEJKLPA: false, AJPCNKCBDEI: true, new GameDate(0, Season.Winter, 3, Day.Sun, 0, 0));
		for (int i = 0; i < SceneReferences.GetSceneReferences().nightStartDeactive.Length; i++)
		{
			((Behaviour)SceneReferences.GetSceneReferences().nightStartDeactive[i]).enabled = false;
		}
		for (int j = 0; j < SceneReferences.GetSceneReferences().blueFires.Length; j++)
		{
			((Component)SceneReferences.GetSceneReferences().blueFires[j]).gameObject.SetActive(false);
		}
		for (int k = 0; k < SceneReferences.GetSceneReferences().blueFireLights.Length; k++)
		{
			((Component)SceneReferences.GetSceneReferences().blueFireLights[k]).gameObject.SetActive(false);
		}
		PostBox.instance.unreadIcon.SetActive(false);
		PlayerController.TeleportPlayer(1, Vector2.op_Implicit(new Vector2(10f, 0f)), Location.Road);
		WorldTime.ChangeHour(21);
		Weather.ShowWeather(Weather.WeatherType.PrecipitationStormyClouds);
		yield return null;
		Weather.NextThunder(5f);
		SceneReferences.instance.table.SetDirtiness(2000f);
		CameraTarget.GetPlayer(1).movementDisabled = true;
		((Component)CameraTarget.GetPlayer(1)).transform.position = Vector2.op_Implicit(new Vector2(9.5f, -13f));
		PJNODKDAPOI = ((Component)Object.Instantiate<GameObject>(rocinantePrefab, Vector2.op_Implicit(new Vector2(24f, -14f)), Quaternion.identity).transform.GetChild(0)).GetComponent<Animator>();
		FOCPGKMJMOB = ((Component)PJNODKDAPOI).transform.parent;
		((Component)PJNODKDAPOI).transform.localScale = new Vector3(-1f, 1f, 1f);
		PJNODKDAPOI.SetBool("Walking", true);
		PlayerController.AddMovementBlocker((Object)(object)this);
		FHNFKEHGJHJ = MultiAudioManager.FadeInAudioObject(carriage, ((Component)PJNODKDAPOI).transform, 0.4f);
		while (FOCPGKMJMOB.position.x > 13f)
		{
			FOCPGKMJMOB.position = Utils.EKCCGNEDPNO(FOCPGKMJMOB.position - HGMFJBLNCJJ * Time.fixedDeltaTime, 1);
			yield return (object)new WaitForFixedUpdate();
		}
		FOCPGKMJMOB.position = Utils.BMBMPKNANAC(FOCPGKMJMOB.position);
		CarretilleroNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T100/Dialogue1", 1, DHELBHAICMM: true, CGKNJONAKGD: false);
		while (FOCPGKMJMOB.position.x > 9.5f)
		{
			FOCPGKMJMOB.position = Utils.BMBMPKNANAC(FOCPGKMJMOB.position - HGMFJBLNCJJ * Time.fixedDeltaTime);
			yield return (object)new WaitForFixedUpdate();
		}
		PJNODKDAPOI.SetBool("Walking", false);
		FHNFKEHGJHJ.FadeOut(0.4f, false);
		yield return CommonReferences.wait5;
		CarretilleroNPC.GGFJGHHHEJC.inTutorial = true;
		CarretilleroNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T100/Dialogue2", 1, DHELBHAICMM: false, CGKNJONAKGD: false);
		yield return CommonReferences.wait2;
		PJNODKDAPOI.SetBool("Talking", true);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		BBCGOJEAPBG();
		PlayerController.TeleportPlayer(1, Vector2.op_Implicit(new Vector2(10f, -15f)), Location.Road);
		PlayerController.GetPlayer(1).characterAnimation.LookDirection(Direction.Up);
		CameraTarget.GetPlayer(1).movementDisabled = false;
		while (!MAMIBIOEDNF)
		{
			yield return null;
		}
		yield return CommonReferences.wait05;
		CarretilleroNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T100/Dialogue3", 1, DHELBHAICMM: false, CGKNJONAKGD: false);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		CarretilleroNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T100/Dialogue4", 1, DHELBHAICMM: true, CGKNJONAKGD: false);
		yield return CommonReferences.wait1_5;
		PJNODKDAPOI.SetBool("Walking", true);
		yield return CommonReferences.wait02;
		MultiAudioManager.PlayAudioObject(whip, ((Component)PJNODKDAPOI).transform);
		yield return CommonReferences.wait1;
		((MonoBehaviour)this).StartCoroutine(NJGEOBPMNNM());
		CarretilleroNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T100/Dialogue5", 1, DHELBHAICMM: true, CGKNJONAKGD: false);
		yield return CommonReferences.wait4;
		PostBox.instance.unreadIcon.SetActive(true);
		NewTutorialManager.ShowPopUp();
		while (NewTutorialManager.instance.open)
		{
			yield return null;
		}
		PlayerController.RemoveMovementBlocker((Object)(object)this);
		BMFMBLJFLEB(MJHBHDAEDLF: true);
		NewTutorialManager.instance.player2Blocked = false;
		ResetMai();
		JBKBMNPPCDM();
		while (!PlayerController.GetPlayer(1).IsTavernLocation() && (!GameManager.LocalCoop() || !PlayerController.GetPlayer(2).IsTavernLocation()))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator EHMJLPGLIHK()
	{
		return new ENFOLJJKLJH(1)
		{
			_003C_003E4__this = this
		};
	}

	private void PPJBCPAKJDP(bool MJHBHDAEDLF)
	{
		((Component)((Component)GameplayUI.HNNJEBNIPOI()).transform.GetChild(1)).gameObject.SetActive(MJHBHDAEDLF);
		((Component)((Component)GameplayUI.ELGNEJNLBNO()).transform.GetChild(1)).gameObject.SetActive(MJHBHDAEDLF);
		((Component)((Component)GameplayUI.OKAPNFPFPFP()).transform.GetChild(3)).gameObject.SetActive(MJHBHDAEDLF);
	}

	private IEnumerator EOCPAMIACMK()
	{
		return new EICJAKJFOIH(1)
		{
			_003C_003E4__this = this
		};
	}

	private void HLHHDNGOGNI()
	{
		FHNFKEHGJHJ = null;
	}

	private void KCLKEAHGGEK()
	{
		FHNFKEHGJHJ = null;
	}

	private void NPLMLCCPBJL()
	{
		CharacterCreatorUI.loadGame = null;
		CharacterCreatorUI.DPBGKDNKDGM(1).EDHEIFHAAKO();
		InteractObject.BBJCJFJEFKK(0).interactingObject = ((Component)this).gameObject;
		PlayerController player = PlayerController.GetPlayer(0);
		player.OnPlayerMoving = (Action)Delegate.Combine(player.OnPlayerMoving, new Action(KKNCPNJBNEM));
		CharacterCreatorUI characterCreatorUI = CharacterCreatorUI.Get(0);
		characterCreatorUI.OnUIClose = (Action<int>)Delegate.Combine(characterCreatorUI.OnUIClose, new Action<int>(LNMKKOPCPFN));
	}

	public void JMGMOOGGNIC(int JIIGOACEIKL)
	{
		PlayerController player = PlayerController.GetPlayer(0);
		player.OnPlayerMoving = (Action)Delegate.Remove(player.OnPlayerMoving, new Action(NEAMAJAEBJN));
		CharacterCreatorUI.FKFNANNBIAM(1).BOBCIFEDJED();
		CharacterCreatorUI characterCreatorUI = CharacterCreatorUI.FKFNANNBIAM(0);
		characterCreatorUI.OnUIClose = (Action<int>)Delegate.Remove(characterCreatorUI.OnUIClose, new Action<int>(HNFLEOKOGML));
		MAMIBIOEDNF = false;
	}

	private IEnumerator JAHNJFGKFII()
	{
		return new ENFOLJJKLJH(1)
		{
			_003C_003E4__this = this
		};
	}

	public void NEAMAJAEBJN()
	{
		PMIMGNEDMNI(1);
	}

	private IEnumerator HIIOOMMOLIC()
	{
		return new EICJAKJFOIH(1)
		{
			_003C_003E4__this = this
		};
	}

	protected void ACPFEBOENOM()
	{
		if (NewTutorialManager.CCCLOBIOMCL && (Object)(object)FHNFKEHGJHJ != (Object)null)
		{
			if (Time.timeScale == 1202f && !EGEIPCHGCOK)
			{
				FHNFKEHGJHJ.VolumeOverride = 660f;
				EGEIPCHGCOK = true;
			}
			else if (EGEIPCHGCOK && Time.timeScale == 1957f)
			{
				FHNFKEHGJHJ.VolumeOverride = FHNFKEHGJHJ.MasterVolume;
				EGEIPCHGCOK = true;
			}
		}
	}

	private void JBKBMNPPCDM()
	{
		for (int i = 0; i < CommonReferences.GGFJGHHHEJC.tavernFloorDirt.Count; i++)
		{
			((Component)((Component)CommonReferences.GGFJGHHHEJC.tavernFloorDirt[i]).transform.GetChild(0)).gameObject.SetActive(false);
		}
	}

	private void CLLAKJADGIH()
	{
		FHNFKEHGJHJ = null;
	}

	private void BBKKLHBPOPH()
	{
		CharacterCreatorUI.loadGame = null;
		CharacterCreatorUI.DPBGKDNKDGM(1).OpenUI();
		InteractObject.GNCPLNHMFHN(1).interactingObject = ((Component)this).gameObject;
		PlayerController player = PlayerController.GetPlayer(0);
		player.OnPlayerMoving = (Action)Delegate.Combine(player.OnPlayerMoving, new Action(EINLFPKJGFA));
		CharacterCreatorUI characterCreatorUI = CharacterCreatorUI.PCEEOGGDBFB(1);
		characterCreatorUI.OnUIClose = (Action<int>)Delegate.Combine(characterCreatorUI.OnUIClose, new Action<int>(CECPEMFHEGP));
	}

	private IEnumerator FPIHNICAJHI()
	{
		SceneReferences.GetSceneReferences().npcRoutines.SetActive(false);
		SceneReferences.GetSceneReferences().customerPool.DisableAllCustomers();
		((Component)SceneReferences.GetSceneReferences().customerPool).gameObject.SetActive(false);
		BMFMBLJFLEB(MJHBHDAEDLF: false);
		MusicController.instance.PauseBasicMood(IEAALMNBABK: true);
		LettersManager.instance.lettersSaved = new List<PostBox.LetterSaveData>();
		LettersManager.instance.AddNewReceivedLetter(1000, LKAALEJKLPA: true, AJPCNKCBDEI: true, new GameDate(0, Season.Summer, 0, Day.Thurs, 0, 0));
		LettersManager.instance.AddNewReceivedLetter(1001, LKAALEJKLPA: true, AJPCNKCBDEI: true, new GameDate(0, Season.Autumn, 0, Day.Tue, 0, 0));
		LettersManager.instance.AddNewReceivedLetter(1002, LKAALEJKLPA: true, AJPCNKCBDEI: true, new GameDate(0, Season.Winter, 1, Day.Wed, 0, 0));
		LettersManager.instance.AddNewReceivedLetter(1003, LKAALEJKLPA: false, AJPCNKCBDEI: true, new GameDate(0, Season.Winter, 3, Day.Sun, 0, 0));
		for (int i = 0; i < SceneReferences.GetSceneReferences().nightStartDeactive.Length; i++)
		{
			((Behaviour)SceneReferences.GetSceneReferences().nightStartDeactive[i]).enabled = false;
		}
		for (int j = 0; j < SceneReferences.GetSceneReferences().blueFires.Length; j++)
		{
			((Component)SceneReferences.GetSceneReferences().blueFires[j]).gameObject.SetActive(false);
		}
		for (int k = 0; k < SceneReferences.GetSceneReferences().blueFireLights.Length; k++)
		{
			((Component)SceneReferences.GetSceneReferences().blueFireLights[k]).gameObject.SetActive(false);
		}
		PostBox.instance.unreadIcon.SetActive(false);
		PlayerController.TeleportPlayer(1, Vector2.op_Implicit(new Vector2(10f, 0f)), Location.Road);
		WorldTime.ChangeHour(21);
		Weather.ShowWeather(Weather.WeatherType.PrecipitationStormyClouds);
		yield return null;
		Weather.NextThunder(5f);
		SceneReferences.instance.table.SetDirtiness(2000f);
		CameraTarget.GetPlayer(1).movementDisabled = true;
		((Component)CameraTarget.GetPlayer(1)).transform.position = Vector2.op_Implicit(new Vector2(9.5f, -13f));
		PJNODKDAPOI = ((Component)Object.Instantiate<GameObject>(rocinantePrefab, Vector2.op_Implicit(new Vector2(24f, -14f)), Quaternion.identity).transform.GetChild(0)).GetComponent<Animator>();
		FOCPGKMJMOB = ((Component)PJNODKDAPOI).transform.parent;
		((Component)PJNODKDAPOI).transform.localScale = new Vector3(-1f, 1f, 1f);
		PJNODKDAPOI.SetBool("Walking", true);
		PlayerController.AddMovementBlocker((Object)(object)this);
		FHNFKEHGJHJ = MultiAudioManager.FadeInAudioObject(carriage, ((Component)PJNODKDAPOI).transform, 0.4f);
		while (FOCPGKMJMOB.position.x > 13f)
		{
			FOCPGKMJMOB.position = Utils.EKCCGNEDPNO(FOCPGKMJMOB.position - HGMFJBLNCJJ * Time.fixedDeltaTime, 1);
			yield return (object)new WaitForFixedUpdate();
		}
		FOCPGKMJMOB.position = Utils.BMBMPKNANAC(FOCPGKMJMOB.position);
		CarretilleroNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T100/Dialogue1", 1, DHELBHAICMM: true, CGKNJONAKGD: false);
		while (FOCPGKMJMOB.position.x > 9.5f)
		{
			FOCPGKMJMOB.position = Utils.BMBMPKNANAC(FOCPGKMJMOB.position - HGMFJBLNCJJ * Time.fixedDeltaTime);
			yield return (object)new WaitForFixedUpdate();
		}
		PJNODKDAPOI.SetBool("Walking", false);
		FHNFKEHGJHJ.FadeOut(0.4f, false);
		yield return CommonReferences.wait5;
		CarretilleroNPC.GGFJGHHHEJC.inTutorial = true;
		CarretilleroNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T100/Dialogue2", 1, DHELBHAICMM: false, CGKNJONAKGD: false);
		yield return CommonReferences.wait2;
		PJNODKDAPOI.SetBool("Talking", true);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		BBCGOJEAPBG();
		PlayerController.TeleportPlayer(1, Vector2.op_Implicit(new Vector2(10f, -15f)), Location.Road);
		PlayerController.GetPlayer(1).characterAnimation.LookDirection(Direction.Up);
		CameraTarget.GetPlayer(1).movementDisabled = false;
		while (!MAMIBIOEDNF)
		{
			yield return null;
		}
		yield return CommonReferences.wait05;
		CarretilleroNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T100/Dialogue3", 1, DHELBHAICMM: false, CGKNJONAKGD: false);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		CarretilleroNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T100/Dialogue4", 1, DHELBHAICMM: true, CGKNJONAKGD: false);
		yield return CommonReferences.wait1_5;
		PJNODKDAPOI.SetBool("Walking", true);
		yield return CommonReferences.wait02;
		MultiAudioManager.PlayAudioObject(whip, ((Component)PJNODKDAPOI).transform);
		yield return CommonReferences.wait1;
		((MonoBehaviour)this).StartCoroutine(NJGEOBPMNNM());
		CarretilleroNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T100/Dialogue5", 1, DHELBHAICMM: true, CGKNJONAKGD: false);
		yield return CommonReferences.wait4;
		PostBox.instance.unreadIcon.SetActive(true);
		NewTutorialManager.ShowPopUp();
		while (NewTutorialManager.instance.open)
		{
			yield return null;
		}
		PlayerController.RemoveMovementBlocker((Object)(object)this);
		BMFMBLJFLEB(MJHBHDAEDLF: true);
		NewTutorialManager.instance.player2Blocked = false;
		ResetMai();
		JBKBMNPPCDM();
		while (!PlayerController.GetPlayer(1).IsTavernLocation() && (!GameManager.LocalCoop() || !PlayerController.GetPlayer(2).IsTavernLocation()))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator KMIBOOOFJKB()
	{
		SceneReferences.GetSceneReferences().npcRoutines.SetActive(false);
		SceneReferences.GetSceneReferences().customerPool.DisableAllCustomers();
		((Component)SceneReferences.GetSceneReferences().customerPool).gameObject.SetActive(false);
		BMFMBLJFLEB(MJHBHDAEDLF: false);
		MusicController.instance.PauseBasicMood(IEAALMNBABK: true);
		LettersManager.instance.lettersSaved = new List<PostBox.LetterSaveData>();
		LettersManager.instance.AddNewReceivedLetter(1000, LKAALEJKLPA: true, AJPCNKCBDEI: true, new GameDate(0, Season.Summer, 0, Day.Thurs, 0, 0));
		LettersManager.instance.AddNewReceivedLetter(1001, LKAALEJKLPA: true, AJPCNKCBDEI: true, new GameDate(0, Season.Autumn, 0, Day.Tue, 0, 0));
		LettersManager.instance.AddNewReceivedLetter(1002, LKAALEJKLPA: true, AJPCNKCBDEI: true, new GameDate(0, Season.Winter, 1, Day.Wed, 0, 0));
		LettersManager.instance.AddNewReceivedLetter(1003, LKAALEJKLPA: false, AJPCNKCBDEI: true, new GameDate(0, Season.Winter, 3, Day.Sun, 0, 0));
		for (int i = 0; i < SceneReferences.GetSceneReferences().nightStartDeactive.Length; i++)
		{
			((Behaviour)SceneReferences.GetSceneReferences().nightStartDeactive[i]).enabled = false;
		}
		for (int j = 0; j < SceneReferences.GetSceneReferences().blueFires.Length; j++)
		{
			((Component)SceneReferences.GetSceneReferences().blueFires[j]).gameObject.SetActive(false);
		}
		for (int k = 0; k < SceneReferences.GetSceneReferences().blueFireLights.Length; k++)
		{
			((Component)SceneReferences.GetSceneReferences().blueFireLights[k]).gameObject.SetActive(false);
		}
		PostBox.instance.unreadIcon.SetActive(false);
		PlayerController.TeleportPlayer(1, Vector2.op_Implicit(new Vector2(10f, 0f)), Location.Road);
		WorldTime.ChangeHour(21);
		Weather.ShowWeather(Weather.WeatherType.PrecipitationStormyClouds);
		yield return null;
		Weather.NextThunder(5f);
		SceneReferences.instance.table.SetDirtiness(2000f);
		CameraTarget.GetPlayer(1).movementDisabled = true;
		((Component)CameraTarget.GetPlayer(1)).transform.position = Vector2.op_Implicit(new Vector2(9.5f, -13f));
		PJNODKDAPOI = ((Component)Object.Instantiate<GameObject>(rocinantePrefab, Vector2.op_Implicit(new Vector2(24f, -14f)), Quaternion.identity).transform.GetChild(0)).GetComponent<Animator>();
		FOCPGKMJMOB = ((Component)PJNODKDAPOI).transform.parent;
		((Component)PJNODKDAPOI).transform.localScale = new Vector3(-1f, 1f, 1f);
		PJNODKDAPOI.SetBool("Walking", true);
		PlayerController.AddMovementBlocker((Object)(object)this);
		FHNFKEHGJHJ = MultiAudioManager.FadeInAudioObject(carriage, ((Component)PJNODKDAPOI).transform, 0.4f);
		while (FOCPGKMJMOB.position.x > 13f)
		{
			FOCPGKMJMOB.position = Utils.EKCCGNEDPNO(FOCPGKMJMOB.position - HGMFJBLNCJJ * Time.fixedDeltaTime, 1);
			yield return (object)new WaitForFixedUpdate();
		}
		FOCPGKMJMOB.position = Utils.BMBMPKNANAC(FOCPGKMJMOB.position);
		CarretilleroNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T100/Dialogue1", 1, DHELBHAICMM: true, CGKNJONAKGD: false);
		while (FOCPGKMJMOB.position.x > 9.5f)
		{
			FOCPGKMJMOB.position = Utils.BMBMPKNANAC(FOCPGKMJMOB.position - HGMFJBLNCJJ * Time.fixedDeltaTime);
			yield return (object)new WaitForFixedUpdate();
		}
		PJNODKDAPOI.SetBool("Walking", false);
		FHNFKEHGJHJ.FadeOut(0.4f, false);
		yield return CommonReferences.wait5;
		CarretilleroNPC.GGFJGHHHEJC.inTutorial = true;
		CarretilleroNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T100/Dialogue2", 1, DHELBHAICMM: false, CGKNJONAKGD: false);
		yield return CommonReferences.wait2;
		PJNODKDAPOI.SetBool("Talking", true);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		BBCGOJEAPBG();
		PlayerController.TeleportPlayer(1, Vector2.op_Implicit(new Vector2(10f, -15f)), Location.Road);
		PlayerController.GetPlayer(1).characterAnimation.LookDirection(Direction.Up);
		CameraTarget.GetPlayer(1).movementDisabled = false;
		while (!MAMIBIOEDNF)
		{
			yield return null;
		}
		yield return CommonReferences.wait05;
		CarretilleroNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T100/Dialogue3", 1, DHELBHAICMM: false, CGKNJONAKGD: false);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		CarretilleroNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T100/Dialogue4", 1, DHELBHAICMM: true, CGKNJONAKGD: false);
		yield return CommonReferences.wait1_5;
		PJNODKDAPOI.SetBool("Walking", true);
		yield return CommonReferences.wait02;
		MultiAudioManager.PlayAudioObject(whip, ((Component)PJNODKDAPOI).transform);
		yield return CommonReferences.wait1;
		((MonoBehaviour)this).StartCoroutine(NJGEOBPMNNM());
		CarretilleroNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T100/Dialogue5", 1, DHELBHAICMM: true, CGKNJONAKGD: false);
		yield return CommonReferences.wait4;
		PostBox.instance.unreadIcon.SetActive(true);
		NewTutorialManager.ShowPopUp();
		while (NewTutorialManager.instance.open)
		{
			yield return null;
		}
		PlayerController.RemoveMovementBlocker((Object)(object)this);
		BMFMBLJFLEB(MJHBHDAEDLF: true);
		NewTutorialManager.instance.player2Blocked = false;
		ResetMai();
		JBKBMNPPCDM();
		while (!PlayerController.GetPlayer(1).IsTavernLocation() && (!GameManager.LocalCoop() || !PlayerController.GetPlayer(2).IsTavernLocation()))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void LEEJMENPDED()
	{
		CharacterCreatorUI.loadGame = null;
		CharacterCreatorUI.MENPEHNHFOA(1).IDLAGJNLPJL();
		InteractObject.GetPlayer(0).interactingObject = ((Component)this).gameObject;
		PlayerController playerController = PlayerController.OPHDCMJLLEC(0);
		playerController.OnPlayerMoving = (Action)Delegate.Combine(playerController.OnPlayerMoving, new Action(OLGLIAGMLEF));
		CharacterCreatorUI characterCreatorUI = CharacterCreatorUI.DPBGKDNKDGM(1);
		characterCreatorUI.OnUIClose = (Action<int>)Delegate.Combine(characterCreatorUI.OnUIClose, new Action<int>(PMIMGNEDMNI));
	}

	public void KKNCPNJBNEM()
	{
		CECPEMFHEGP(1);
	}

	protected void OGBGFLMKFHH()
	{
		if (NewTutorialManager.CCCLOBIOMCL && (Object)(object)FHNFKEHGJHJ != (Object)null)
		{
			if (Time.timeScale == 1446f && !EGEIPCHGCOK)
			{
				FHNFKEHGJHJ.VolumeOverride = 1800f;
				EGEIPCHGCOK = false;
			}
			else if (EGEIPCHGCOK && Time.timeScale == 867f)
			{
				FHNFKEHGJHJ.VolumeOverride = FHNFKEHGJHJ.MasterVolume;
				EGEIPCHGCOK = true;
			}
		}
	}

	public void JEDIENJMGJJ(int JIIGOACEIKL)
	{
		PlayerController playerController = PlayerController.OPHDCMJLLEC(0);
		playerController.OnPlayerMoving = (Action)Delegate.Remove(playerController.OnPlayerMoving, new Action(AEDFEPLIBJO));
		CharacterCreatorUI.PCEEOGGDBFB(1).CloseUI();
		CharacterCreatorUI characterCreatorUI = CharacterCreatorUI.DPBGKDNKDGM(1);
		characterCreatorUI.OnUIClose = (Action<int>)Delegate.Remove(characterCreatorUI.OnUIClose, new Action<int>(PAOEPMFMOPP));
		MAMIBIOEDNF = true;
	}

	private IEnumerator EGFOBDKKNDF()
	{
		return new EICJAKJFOIH(1)
		{
			_003C_003E4__this = this
		};
	}

	private void GJIHLKHKBJO()
	{
		for (int i = 0; i < CommonReferences.MNFMOEKMJKN().tavernFloorDirt.Count; i += 0)
		{
			((Component)((Component)CommonReferences.GGFJGHHHEJC.tavernFloorDirt[i]).transform.GetChild(1)).gameObject.SetActive(true);
		}
	}

	private void MJBFPFFGHCB()
	{
		CharacterCreatorUI.loadGame = null;
		CharacterCreatorUI.MENPEHNHFOA(1).IDLAGJNLPJL();
		InteractObject.BBJCJFJEFKK(0).interactingObject = ((Component)this).gameObject;
		PlayerController playerController = PlayerController.OPHDCMJLLEC(1);
		playerController.OnPlayerMoving = (Action)Delegate.Combine(playerController.OnPlayerMoving, new Action(NEAMAJAEBJN));
		CharacterCreatorUI characterCreatorUI = CharacterCreatorUI.DPBGKDNKDGM(0);
		characterCreatorUI.OnUIClose = (Action<int>)Delegate.Combine(characterCreatorUI.OnUIClose, new Action<int>(JEDIENJMGJJ));
	}

	private void NCDBCDJKPLA()
	{
		FHNFKEHGJHJ = null;
	}

	private void HMAHKCLMMGN(bool MJHBHDAEDLF)
	{
		((Component)((Component)GameplayUI.NGIMIHFFNMH()).transform.GetChild(4)).gameObject.SetActive(MJHBHDAEDLF);
		((Component)((Component)GameplayUI.POAGAIBEFBF()).transform.GetChild(2)).gameObject.SetActive(MJHBHDAEDLF);
		((Component)((Component)GameplayUI.ELGNEJNLBNO()).transform.GetChild(3)).gameObject.SetActive(MJHBHDAEDLF);
	}

	protected void FDHMOEDMPNG()
	{
		if (NewTutorialManager.CCCLOBIOMCL && (Object)(object)FHNFKEHGJHJ != (Object)null)
		{
			if (Time.timeScale == 1470f && !EGEIPCHGCOK)
			{
				FHNFKEHGJHJ.VolumeOverride = 1280f;
				EGEIPCHGCOK = false;
			}
			else if (EGEIPCHGCOK && Time.timeScale == 504f)
			{
				FHNFKEHGJHJ.VolumeOverride = FHNFKEHGJHJ.MasterVolume;
				EGEIPCHGCOK = true;
			}
		}
	}

	public void PAOEPMFMOPP(int JIIGOACEIKL)
	{
		PlayerController playerController = PlayerController.OPHDCMJLLEC(0);
		playerController.OnPlayerMoving = (Action)Delegate.Remove(playerController.OnPlayerMoving, new Action(AEDFEPLIBJO));
		CharacterCreatorUI.PCEEOGGDBFB(1).CloseUI();
		CharacterCreatorUI characterCreatorUI = CharacterCreatorUI.Get(1);
		characterCreatorUI.OnUIClose = (Action<int>)Delegate.Remove(characterCreatorUI.OnUIClose, new Action<int>(CECPEMFHEGP));
		MAMIBIOEDNF = true;
	}

	public void ILKJPDMMDPL()
	{
		JPGKENPAGMM(1);
	}

	private void GBKNIJENJEF()
	{
		FHNFKEHGJHJ = null;
	}

	private void CDDNJGALKOL(bool MJHBHDAEDLF)
	{
		((Component)((Component)GameplayUI.KGPJPILAHDE()).transform.GetChild(8)).gameObject.SetActive(MJHBHDAEDLF);
		((Component)((Component)GameplayUI.GGFJGHHHEJC).transform.GetChild(4)).gameObject.SetActive(MJHBHDAEDLF);
		((Component)((Component)GameplayUI.GGFJGHHHEJC).transform.GetChild(0)).gameObject.SetActive(MJHBHDAEDLF);
	}

	public void DENNOPGIOFO()
	{
		BLLEOKJGOMC(0);
	}

	public void KBKFBBKDDBF(int JIIGOACEIKL)
	{
		PlayerController player = PlayerController.GetPlayer(1);
		player.OnPlayerMoving = (Action)Delegate.Remove(player.OnPlayerMoving, new Action(NEAMAJAEBJN));
		CharacterCreatorUI.MENPEHNHFOA(1).CloseUI();
		CharacterCreatorUI characterCreatorUI = CharacterCreatorUI.MENPEHNHFOA(1);
		characterCreatorUI.OnUIClose = (Action<int>)Delegate.Remove(characterCreatorUI.OnUIClose, new Action<int>(JMGMOOGGNIC));
		MAMIBIOEDNF = true;
	}

	private void OIKPAKEMDGG(bool MJHBHDAEDLF)
	{
		((Component)((Component)GameplayUI.GGFJGHHHEJC).transform.GetChild(0)).gameObject.SetActive(MJHBHDAEDLF);
		((Component)((Component)GameplayUI.DICHPHEOINO()).transform.GetChild(8)).gameObject.SetActive(MJHBHDAEDLF);
		((Component)((Component)GameplayUI.GGFJGHHHEJC).transform.GetChild(2)).gameObject.SetActive(MJHBHDAEDLF);
	}

	public void CECPEMFHEGP(int JIIGOACEIKL)
	{
		PlayerController player = PlayerController.GetPlayer(0);
		player.OnPlayerMoving = (Action)Delegate.Remove(player.OnPlayerMoving, new Action(CloseCharacterCreator));
		CharacterCreatorUI.PCEEOGGDBFB(0).BOBCIFEDJED();
		CharacterCreatorUI characterCreatorUI = CharacterCreatorUI.FKFNANNBIAM(0);
		characterCreatorUI.OnUIClose = (Action<int>)Delegate.Remove(characterCreatorUI.OnUIClose, new Action<int>(JEDIENJMGJJ));
		MAMIBIOEDNF = false;
	}

	private void PBFJOAKJHIO()
	{
		CharacterCreatorUI.loadGame = null;
		CharacterCreatorUI.PCEEOGGDBFB(1).EDHEIFHAAKO();
		InteractObject.GetPlayer(0).interactingObject = ((Component)this).gameObject;
		PlayerController playerController = PlayerController.OPHDCMJLLEC(0);
		playerController.OnPlayerMoving = (Action)Delegate.Combine(playerController.OnPlayerMoving, new Action(AEDFEPLIBJO));
		CharacterCreatorUI characterCreatorUI = CharacterCreatorUI.Get(0);
		characterCreatorUI.OnUIClose = (Action<int>)Delegate.Combine(characterCreatorUI.OnUIClose, new Action<int>(JEDIENJMGJJ));
	}

	private void HGNLJBGNOCF()
	{
		for (int i = 0; i < CommonReferences.MNFMOEKMJKN().tavernFloorDirt.Count; i++)
		{
			((Component)((Component)CommonReferences.MNFMOEKMJKN().tavernFloorDirt[i]).transform.GetChild(0)).gameObject.SetActive(true);
		}
	}

	private void LNKPDNJHGGO()
	{
		for (int i = 0; i < CommonReferences.MNFMOEKMJKN().tavernFloorDirt.Count; i++)
		{
			((Component)((Component)CommonReferences.MNFMOEKMJKN().tavernFloorDirt[i]).transform.GetChild(0)).gameObject.SetActive(true);
		}
	}

	protected void MLICJIBNIFA()
	{
		if (NewTutorialManager.CCCLOBIOMCL && (Object)(object)FHNFKEHGJHJ != (Object)null)
		{
			if (Time.timeScale == 531f && !EGEIPCHGCOK)
			{
				FHNFKEHGJHJ.VolumeOverride = 779f;
				EGEIPCHGCOK = false;
			}
			else if (EGEIPCHGCOK && Time.timeScale == 1091f)
			{
				FHNFKEHGJHJ.VolumeOverride = FHNFKEHGJHJ.MasterVolume;
				EGEIPCHGCOK = false;
			}
		}
	}

	private IEnumerator JHBNODHNMCI()
	{
		SceneReferences.GetSceneReferences().npcRoutines.SetActive(false);
		SceneReferences.GetSceneReferences().customerPool.DisableAllCustomers();
		((Component)SceneReferences.GetSceneReferences().customerPool).gameObject.SetActive(false);
		BMFMBLJFLEB(MJHBHDAEDLF: false);
		MusicController.instance.PauseBasicMood(IEAALMNBABK: true);
		LettersManager.instance.lettersSaved = new List<PostBox.LetterSaveData>();
		LettersManager.instance.AddNewReceivedLetter(1000, LKAALEJKLPA: true, AJPCNKCBDEI: true, new GameDate(0, Season.Summer, 0, Day.Thurs, 0, 0));
		LettersManager.instance.AddNewReceivedLetter(1001, LKAALEJKLPA: true, AJPCNKCBDEI: true, new GameDate(0, Season.Autumn, 0, Day.Tue, 0, 0));
		LettersManager.instance.AddNewReceivedLetter(1002, LKAALEJKLPA: true, AJPCNKCBDEI: true, new GameDate(0, Season.Winter, 1, Day.Wed, 0, 0));
		LettersManager.instance.AddNewReceivedLetter(1003, LKAALEJKLPA: false, AJPCNKCBDEI: true, new GameDate(0, Season.Winter, 3, Day.Sun, 0, 0));
		for (int i = 0; i < SceneReferences.GetSceneReferences().nightStartDeactive.Length; i++)
		{
			((Behaviour)SceneReferences.GetSceneReferences().nightStartDeactive[i]).enabled = false;
		}
		for (int j = 0; j < SceneReferences.GetSceneReferences().blueFires.Length; j++)
		{
			((Component)SceneReferences.GetSceneReferences().blueFires[j]).gameObject.SetActive(false);
		}
		for (int k = 0; k < SceneReferences.GetSceneReferences().blueFireLights.Length; k++)
		{
			((Component)SceneReferences.GetSceneReferences().blueFireLights[k]).gameObject.SetActive(false);
		}
		PostBox.instance.unreadIcon.SetActive(false);
		PlayerController.TeleportPlayer(1, Vector2.op_Implicit(new Vector2(10f, 0f)), Location.Road);
		WorldTime.ChangeHour(21);
		Weather.ShowWeather(Weather.WeatherType.PrecipitationStormyClouds);
		yield return null;
		Weather.NextThunder(5f);
		SceneReferences.instance.table.SetDirtiness(2000f);
		CameraTarget.GetPlayer(1).movementDisabled = true;
		((Component)CameraTarget.GetPlayer(1)).transform.position = Vector2.op_Implicit(new Vector2(9.5f, -13f));
		PJNODKDAPOI = ((Component)Object.Instantiate<GameObject>(rocinantePrefab, Vector2.op_Implicit(new Vector2(24f, -14f)), Quaternion.identity).transform.GetChild(0)).GetComponent<Animator>();
		FOCPGKMJMOB = ((Component)PJNODKDAPOI).transform.parent;
		((Component)PJNODKDAPOI).transform.localScale = new Vector3(-1f, 1f, 1f);
		PJNODKDAPOI.SetBool("Walking", true);
		PlayerController.AddMovementBlocker((Object)(object)this);
		FHNFKEHGJHJ = MultiAudioManager.FadeInAudioObject(carriage, ((Component)PJNODKDAPOI).transform, 0.4f);
		while (FOCPGKMJMOB.position.x > 13f)
		{
			FOCPGKMJMOB.position = Utils.EKCCGNEDPNO(FOCPGKMJMOB.position - HGMFJBLNCJJ * Time.fixedDeltaTime, 1);
			yield return (object)new WaitForFixedUpdate();
		}
		FOCPGKMJMOB.position = Utils.BMBMPKNANAC(FOCPGKMJMOB.position);
		CarretilleroNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T100/Dialogue1", 1, DHELBHAICMM: true, CGKNJONAKGD: false);
		while (FOCPGKMJMOB.position.x > 9.5f)
		{
			FOCPGKMJMOB.position = Utils.BMBMPKNANAC(FOCPGKMJMOB.position - HGMFJBLNCJJ * Time.fixedDeltaTime);
			yield return (object)new WaitForFixedUpdate();
		}
		PJNODKDAPOI.SetBool("Walking", false);
		FHNFKEHGJHJ.FadeOut(0.4f, false);
		yield return CommonReferences.wait5;
		CarretilleroNPC.GGFJGHHHEJC.inTutorial = true;
		CarretilleroNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T100/Dialogue2", 1, DHELBHAICMM: false, CGKNJONAKGD: false);
		yield return CommonReferences.wait2;
		PJNODKDAPOI.SetBool("Talking", true);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		BBCGOJEAPBG();
		PlayerController.TeleportPlayer(1, Vector2.op_Implicit(new Vector2(10f, -15f)), Location.Road);
		PlayerController.GetPlayer(1).characterAnimation.LookDirection(Direction.Up);
		CameraTarget.GetPlayer(1).movementDisabled = false;
		while (!MAMIBIOEDNF)
		{
			yield return null;
		}
		yield return CommonReferences.wait05;
		CarretilleroNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T100/Dialogue3", 1, DHELBHAICMM: false, CGKNJONAKGD: false);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		CarretilleroNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T100/Dialogue4", 1, DHELBHAICMM: true, CGKNJONAKGD: false);
		yield return CommonReferences.wait1_5;
		PJNODKDAPOI.SetBool("Walking", true);
		yield return CommonReferences.wait02;
		MultiAudioManager.PlayAudioObject(whip, ((Component)PJNODKDAPOI).transform);
		yield return CommonReferences.wait1;
		((MonoBehaviour)this).StartCoroutine(NJGEOBPMNNM());
		CarretilleroNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T100/Dialogue5", 1, DHELBHAICMM: true, CGKNJONAKGD: false);
		yield return CommonReferences.wait4;
		PostBox.instance.unreadIcon.SetActive(true);
		NewTutorialManager.ShowPopUp();
		while (NewTutorialManager.instance.open)
		{
			yield return null;
		}
		PlayerController.RemoveMovementBlocker((Object)(object)this);
		BMFMBLJFLEB(MJHBHDAEDLF: true);
		NewTutorialManager.instance.player2Blocked = false;
		ResetMai();
		JBKBMNPPCDM();
		while (!PlayerController.GetPlayer(1).IsTavernLocation() && (!GameManager.LocalCoop() || !PlayerController.GetPlayer(2).IsTavernLocation()))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	protected void EJEEIIGEGOC()
	{
		if (NewTutorialManager.CCCLOBIOMCL && (Object)(object)FHNFKEHGJHJ != (Object)null)
		{
			if (Time.timeScale == 587f && !EGEIPCHGCOK)
			{
				FHNFKEHGJHJ.VolumeOverride = 282f;
				EGEIPCHGCOK = true;
			}
			else if (EGEIPCHGCOK && Time.timeScale == 714f)
			{
				FHNFKEHGJHJ.VolumeOverride = FHNFKEHGJHJ.MasterVolume;
				EGEIPCHGCOK = true;
			}
		}
	}

	protected void HCPKBJDHLAC()
	{
		if (NewTutorialManager.CCCLOBIOMCL && (Object)(object)FHNFKEHGJHJ != (Object)null)
		{
			if (Time.timeScale == 1697f && !EGEIPCHGCOK)
			{
				FHNFKEHGJHJ.VolumeOverride = 373f;
				EGEIPCHGCOK = true;
			}
			else if (EGEIPCHGCOK && Time.timeScale == 1864f)
			{
				FHNFKEHGJHJ.VolumeOverride = FHNFKEHGJHJ.MasterVolume;
				EGEIPCHGCOK = true;
			}
		}
	}

	protected void MMPMJNAFKHC()
	{
		if (NewTutorialManager.CCCLOBIOMCL && (Object)(object)FHNFKEHGJHJ != (Object)null)
		{
			if (Time.timeScale == 888f && !EGEIPCHGCOK)
			{
				FHNFKEHGJHJ.VolumeOverride = 293f;
				EGEIPCHGCOK = false;
			}
			else if (EGEIPCHGCOK && Time.timeScale == 1591f)
			{
				FHNFKEHGJHJ.VolumeOverride = FHNFKEHGJHJ.MasterVolume;
				EGEIPCHGCOK = true;
			}
		}
	}

	private IEnumerator PBPKJEAAGFE()
	{
		return new ENFOLJJKLJH(1)
		{
			_003C_003E4__this = this
		};
	}

	private void CKMCCGDIDOG(bool MJHBHDAEDLF)
	{
		((Component)((Component)GameplayUI.BAKPBHPNKPB()).transform.GetChild(8)).gameObject.SetActive(MJHBHDAEDLF);
		((Component)((Component)GameplayUI.NGIMIHFFNMH()).transform.GetChild(8)).gameObject.SetActive(MJHBHDAEDLF);
		((Component)((Component)GameplayUI.MPJJAPCFENH()).transform.GetChild(0)).gameObject.SetActive(MJHBHDAEDLF);
	}

	private IEnumerator LIDGJAMOOKN()
	{
		return new EICJAKJFOIH(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator PGFCNMDEBAN()
	{
		return new EICJAKJFOIH(1)
		{
			_003C_003E4__this = this
		};
	}

	public void KGPEKACFJEB()
	{
		DADCMOLFKJM(0);
	}

	public void NOKNKJEDHLO(int JIIGOACEIKL)
	{
		PlayerController playerController = PlayerController.OPHDCMJLLEC(1);
		playerController.OnPlayerMoving = (Action)Delegate.Remove(playerController.OnPlayerMoving, new Action(CloseCharacterCreator));
		CharacterCreatorUI.Get(1).BOBCIFEDJED();
		CharacterCreatorUI characterCreatorUI = CharacterCreatorUI.DPBGKDNKDGM(0);
		characterCreatorUI.OnUIClose = (Action<int>)Delegate.Remove(characterCreatorUI.OnUIClose, new Action<int>(LNMKKOPCPFN));
		MAMIBIOEDNF = false;
	}

	private IEnumerator NLCIHJDPGFE()
	{
		SceneReferences.GetSceneReferences().npcRoutines.SetActive(false);
		SceneReferences.GetSceneReferences().customerPool.DisableAllCustomers();
		((Component)SceneReferences.GetSceneReferences().customerPool).gameObject.SetActive(false);
		BMFMBLJFLEB(MJHBHDAEDLF: false);
		MusicController.instance.PauseBasicMood(IEAALMNBABK: true);
		LettersManager.instance.lettersSaved = new List<PostBox.LetterSaveData>();
		LettersManager.instance.AddNewReceivedLetter(1000, LKAALEJKLPA: true, AJPCNKCBDEI: true, new GameDate(0, Season.Summer, 0, Day.Thurs, 0, 0));
		LettersManager.instance.AddNewReceivedLetter(1001, LKAALEJKLPA: true, AJPCNKCBDEI: true, new GameDate(0, Season.Autumn, 0, Day.Tue, 0, 0));
		LettersManager.instance.AddNewReceivedLetter(1002, LKAALEJKLPA: true, AJPCNKCBDEI: true, new GameDate(0, Season.Winter, 1, Day.Wed, 0, 0));
		LettersManager.instance.AddNewReceivedLetter(1003, LKAALEJKLPA: false, AJPCNKCBDEI: true, new GameDate(0, Season.Winter, 3, Day.Sun, 0, 0));
		for (int i = 0; i < SceneReferences.GetSceneReferences().nightStartDeactive.Length; i++)
		{
			((Behaviour)SceneReferences.GetSceneReferences().nightStartDeactive[i]).enabled = false;
		}
		for (int j = 0; j < SceneReferences.GetSceneReferences().blueFires.Length; j++)
		{
			((Component)SceneReferences.GetSceneReferences().blueFires[j]).gameObject.SetActive(false);
		}
		for (int k = 0; k < SceneReferences.GetSceneReferences().blueFireLights.Length; k++)
		{
			((Component)SceneReferences.GetSceneReferences().blueFireLights[k]).gameObject.SetActive(false);
		}
		PostBox.instance.unreadIcon.SetActive(false);
		PlayerController.TeleportPlayer(1, Vector2.op_Implicit(new Vector2(10f, 0f)), Location.Road);
		WorldTime.ChangeHour(21);
		Weather.ShowWeather(Weather.WeatherType.PrecipitationStormyClouds);
		yield return null;
		Weather.NextThunder(5f);
		SceneReferences.instance.table.SetDirtiness(2000f);
		CameraTarget.GetPlayer(1).movementDisabled = true;
		((Component)CameraTarget.GetPlayer(1)).transform.position = Vector2.op_Implicit(new Vector2(9.5f, -13f));
		PJNODKDAPOI = ((Component)Object.Instantiate<GameObject>(rocinantePrefab, Vector2.op_Implicit(new Vector2(24f, -14f)), Quaternion.identity).transform.GetChild(0)).GetComponent<Animator>();
		FOCPGKMJMOB = ((Component)PJNODKDAPOI).transform.parent;
		((Component)PJNODKDAPOI).transform.localScale = new Vector3(-1f, 1f, 1f);
		PJNODKDAPOI.SetBool("Walking", true);
		PlayerController.AddMovementBlocker((Object)(object)this);
		FHNFKEHGJHJ = MultiAudioManager.FadeInAudioObject(carriage, ((Component)PJNODKDAPOI).transform, 0.4f);
		while (FOCPGKMJMOB.position.x > 13f)
		{
			FOCPGKMJMOB.position = Utils.EKCCGNEDPNO(FOCPGKMJMOB.position - HGMFJBLNCJJ * Time.fixedDeltaTime, 1);
			yield return (object)new WaitForFixedUpdate();
		}
		FOCPGKMJMOB.position = Utils.BMBMPKNANAC(FOCPGKMJMOB.position);
		CarretilleroNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T100/Dialogue1", 1, DHELBHAICMM: true, CGKNJONAKGD: false);
		while (FOCPGKMJMOB.position.x > 9.5f)
		{
			FOCPGKMJMOB.position = Utils.BMBMPKNANAC(FOCPGKMJMOB.position - HGMFJBLNCJJ * Time.fixedDeltaTime);
			yield return (object)new WaitForFixedUpdate();
		}
		PJNODKDAPOI.SetBool("Walking", false);
		FHNFKEHGJHJ.FadeOut(0.4f, false);
		yield return CommonReferences.wait5;
		CarretilleroNPC.GGFJGHHHEJC.inTutorial = true;
		CarretilleroNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T100/Dialogue2", 1, DHELBHAICMM: false, CGKNJONAKGD: false);
		yield return CommonReferences.wait2;
		PJNODKDAPOI.SetBool("Talking", true);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		BBCGOJEAPBG();
		PlayerController.TeleportPlayer(1, Vector2.op_Implicit(new Vector2(10f, -15f)), Location.Road);
		PlayerController.GetPlayer(1).characterAnimation.LookDirection(Direction.Up);
		CameraTarget.GetPlayer(1).movementDisabled = false;
		while (!MAMIBIOEDNF)
		{
			yield return null;
		}
		yield return CommonReferences.wait05;
		CarretilleroNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T100/Dialogue3", 1, DHELBHAICMM: false, CGKNJONAKGD: false);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		CarretilleroNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T100/Dialogue4", 1, DHELBHAICMM: true, CGKNJONAKGD: false);
		yield return CommonReferences.wait1_5;
		PJNODKDAPOI.SetBool("Walking", true);
		yield return CommonReferences.wait02;
		MultiAudioManager.PlayAudioObject(whip, ((Component)PJNODKDAPOI).transform);
		yield return CommonReferences.wait1;
		((MonoBehaviour)this).StartCoroutine(NJGEOBPMNNM());
		CarretilleroNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T100/Dialogue5", 1, DHELBHAICMM: true, CGKNJONAKGD: false);
		yield return CommonReferences.wait4;
		PostBox.instance.unreadIcon.SetActive(true);
		NewTutorialManager.ShowPopUp();
		while (NewTutorialManager.instance.open)
		{
			yield return null;
		}
		PlayerController.RemoveMovementBlocker((Object)(object)this);
		BMFMBLJFLEB(MJHBHDAEDLF: true);
		NewTutorialManager.instance.player2Blocked = false;
		ResetMai();
		JBKBMNPPCDM();
		while (!PlayerController.GetPlayer(1).IsTavernLocation() && (!GameManager.LocalCoop() || !PlayerController.GetPlayer(2).IsTavernLocation()))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.ObjectiveCompleted(0);
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void KCJKLHKIPMF()
	{
		CharacterCreatorUI.loadGame = null;
		CharacterCreatorUI.Get(0).OpenUI();
		InteractObject.GetPlayer(0).interactingObject = ((Component)this).gameObject;
		PlayerController player = PlayerController.GetPlayer(0);
		player.OnPlayerMoving = (Action)Delegate.Combine(player.OnPlayerMoving, new Action(OLGLIAGMLEF));
		CharacterCreatorUI characterCreatorUI = CharacterCreatorUI.FKFNANNBIAM(0);
		characterCreatorUI.OnUIClose = (Action<int>)Delegate.Combine(characterCreatorUI.OnUIClose, new Action<int>(BLLEOKJGOMC));
	}

	public override void SetUp()
	{
		base.SetUp();
		((MonoBehaviour)this).StartCoroutine(PBEKBJIJFDK());
	}

	public void LJDMOKKEPJC()
	{
		BLLEOKJGOMC(1);
	}
}
