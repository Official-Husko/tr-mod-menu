using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class T101_Dormir : TutorialPhaseBase
{
	[CompilerGenerated]
	private sealed class JPPPCGGCDCK : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T101_Dormir _003C_003E4__this;

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
		public JPPPCGGCDCK(int _003C_003E1__state)
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
			T101_Dormir t101_Dormir = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
			{
				_003C_003E1__state = -1;
				for (int i = 0; i < SceneReferences.GetSceneReferences().nightStartDeactive.Length; i++)
				{
					((Behaviour)SceneReferences.GetSceneReferences().nightStartDeactive[i]).enabled = true;
				}
				NewTutorialManager.instance.ObjectiveCompleted(0);
				Object.Destroy((Object)(object)t101_Dormir.JELIKOFDONK);
				if ((Object)(object)NewTutorialManager.fireLoopSource != (Object)null)
				{
					NewTutorialManager.fireLoopSource.FadeOut(1f, false);
					NewTutorialManager.fireLoopSource = null;
				}
				else
				{
					Debug.Log((object)"Fire Loop NULL!!");
				}
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 1;
				return true;
			}
			case 1:
				_003C_003E1__state = -1;
				t101_Dormir.LHKIJABBBPM();
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
	private sealed class ANHGEEIMBNP : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T101_Dormir _003C_003E4__this;

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
		public ANHGEEIMBNP(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_010a: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			T101_Dormir t101_Dormir = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
				goto IL_0075;
			case 1:
				_003C_003E1__state = -1;
				goto IL_0075;
			case 2:
				_003C_003E1__state = -1;
				DialogueManager.Bark("Tutorial/T101/Dialogue1", ((Component)PlayerController.GetPlayer(t101_Dormir.triggerPlayerNum)).transform);
				_003C_003E2__current = CommonReferences.wait5;
				_003C_003E1__state = 3;
				return true;
			case 3:
				_003C_003E1__state = -1;
				MultiAudioManager.PlayAudioObject(t101_Dormir.creak2, ((Component)PlayerController.GetPlayer(t101_Dormir.triggerPlayerNum)).transform.position);
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 4;
				return true;
			case 4:
				_003C_003E1__state = -1;
				PlayerController.GetPlayer(t101_Dormir.triggerPlayerNum).emotionController.StartEmotion("Doubt");
				_003C_003E2__current = CommonReferences.wait5;
				_003C_003E1__state = 5;
				return true;
			case 5:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.dialogueActor.actor = "???";
				MaiNPC.GGFJGHHHEJC.dialogueActor.spritePortrait = MaiNPC.GGFJGHHHEJC.maiUnknown;
				MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T101/Dialogue2", t101_Dormir.triggerPlayerNum);
				goto IL_01c2;
			case 6:
				_003C_003E1__state = -1;
				goto IL_01c2;
			case 7:
				_003C_003E1__state = -1;
				MusicController.instance.TriggerMusicTheme(21);
				_003C_003E2__current = CommonReferences.wait1_5;
				_003C_003E1__state = 8;
				return true;
			case 8:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.dialogueActor.actor = "???";
				MaiNPC.GGFJGHHHEJC.dialogueActor.spritePortrait = MaiNPC.GGFJGHHHEJC.mai;
				MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T101/Dialogue3", t101_Dormir.triggerPlayerNum);
				goto IL_0270;
			case 9:
				_003C_003E1__state = -1;
				goto IL_0270;
			case 10:
				_003C_003E1__state = -1;
				NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
				NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
				NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bed.instance).transform.position), Vector2.up * 0.6f, ref t101_Dormir.JELIKOFDONK);
				PlayerController.RemoveMovementBlocker((Object)(object)t101_Dormir);
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 11;
				return true;
			case 11:
				_003C_003E1__state = -1;
				_003C_003E2__current = ((MonoBehaviour)t101_Dormir).StartCoroutine(t101_Dormir.CDICFNAMCEE());
				_003C_003E1__state = 12;
				return true;
			case 12:
				{
					_003C_003E1__state = -1;
					t101_Dormir.AddQuest(39);
					CommonReferences instance = CommonReferences.GGFJGHHHEJC;
					instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(t101_Dormir.CEHMCNPOEOL));
					return false;
				}
				IL_0270:
				if (t101_Dormir.AAOPIEDAKKD(2))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 9;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 10;
				return true;
				IL_01c2:
				if (t101_Dormir.AAOPIEDAKKD(1))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 6;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 7;
				return true;
				IL_0075:
				if (!t101_Dormir.DMMFNMNKJLL())
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
				MultiAudioManager.PlayAudioObject(t101_Dormir.creak1, ((Component)PlayerController.GetPlayer(t101_Dormir.triggerPlayerNum)).transform.position);
				NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
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

	public AudioObject creak1;

	public AudioObject creak2;

	private IEnumerator IDGLEKCBIMF()
	{
		for (int i = 0; i < SceneReferences.GetSceneReferences().nightStartDeactive.Length; i++)
		{
			((Behaviour)SceneReferences.GetSceneReferences().nightStartDeactive[i]).enabled = true;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		Object.Destroy((Object)(object)JELIKOFDONK);
		if ((Object)(object)NewTutorialManager.fireLoopSource != (Object)null)
		{
			NewTutorialManager.fireLoopSource.FadeOut(1f, false);
			NewTutorialManager.fireLoopSource = null;
		}
		else
		{
			Debug.Log((object)"Fire Loop NULL!!");
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator LKAGLINOIMK()
	{
		return new ANHGEEIMBNP(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LFKPHADFFDG()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		while (!DMMFNMNKJLL())
		{
			yield return null;
		}
		MultiAudioManager.PlayAudioObject(creak1, ((Component)PlayerController.GetPlayer(triggerPlayerNum)).transform.position);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait05;
		DialogueManager.Bark("Tutorial/T101/Dialogue1", ((Component)PlayerController.GetPlayer(triggerPlayerNum)).transform);
		yield return CommonReferences.wait5;
		MultiAudioManager.PlayAudioObject(creak2, ((Component)PlayerController.GetPlayer(triggerPlayerNum)).transform.position);
		yield return CommonReferences.wait05;
		PlayerController.GetPlayer(triggerPlayerNum).emotionController.StartEmotion("Doubt");
		yield return CommonReferences.wait5;
		MaiNPC.GGFJGHHHEJC.dialogueActor.actor = "???";
		MaiNPC.GGFJGHHHEJC.dialogueActor.spritePortrait = MaiNPC.GGFJGHHHEJC.maiUnknown;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T101/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait05;
		MusicController.instance.TriggerMusicTheme(21);
		yield return CommonReferences.wait1_5;
		MaiNPC.GGFJGHHHEJC.dialogueActor.actor = "???";
		MaiNPC.GGFJGHHHEJC.dialogueActor.spritePortrait = MaiNPC.GGFJGHHHEJC.mai;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T101/Dialogue3", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bed.instance).transform.position), Vector2.up * 0.6f, ref JELIKOFDONK);
		PlayerController.RemoveMovementBlocker((Object)(object)this);
		yield return CommonReferences.wait2;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		AddQuest(39);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(CEHMCNPOEOL));
	}

	private void MAKDAHKCJMN()
	{
		try
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(MAKDAHKCJMN));
			((MonoBehaviour)this).StartCoroutine(CNPPMBAKEBJ());
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("EditorAction_8" + ex.Message));
		}
	}

	private IEnumerator OBCHIKLEMKF()
	{
		return new ANHGEEIMBNP(1)
		{
			_003C_003E4__this = this
		};
	}

	private void BONLEKODNHB()
	{
		try
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(MAKDAHKCJMN));
			((MonoBehaviour)this).StartCoroutine(CAKPGBAIIPI());
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("" + ex.Message));
		}
	}

	public override void SetUp()
	{
		base.SetUp();
		((MonoBehaviour)this).StartCoroutine(PBEKBJIJFDK());
	}

	private IEnumerator FAEKOKEINEH()
	{
		return new ANHGEEIMBNP(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator MDFFFPLNDAP()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		while (!DMMFNMNKJLL())
		{
			yield return null;
		}
		MultiAudioManager.PlayAudioObject(creak1, ((Component)PlayerController.GetPlayer(triggerPlayerNum)).transform.position);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait05;
		DialogueManager.Bark("Tutorial/T101/Dialogue1", ((Component)PlayerController.GetPlayer(triggerPlayerNum)).transform);
		yield return CommonReferences.wait5;
		MultiAudioManager.PlayAudioObject(creak2, ((Component)PlayerController.GetPlayer(triggerPlayerNum)).transform.position);
		yield return CommonReferences.wait05;
		PlayerController.GetPlayer(triggerPlayerNum).emotionController.StartEmotion("Doubt");
		yield return CommonReferences.wait5;
		MaiNPC.GGFJGHHHEJC.dialogueActor.actor = "???";
		MaiNPC.GGFJGHHHEJC.dialogueActor.spritePortrait = MaiNPC.GGFJGHHHEJC.maiUnknown;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T101/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait05;
		MusicController.instance.TriggerMusicTheme(21);
		yield return CommonReferences.wait1_5;
		MaiNPC.GGFJGHHHEJC.dialogueActor.actor = "???";
		MaiNPC.GGFJGHHHEJC.dialogueActor.spritePortrait = MaiNPC.GGFJGHHHEJC.mai;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T101/Dialogue3", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bed.instance).transform.position), Vector2.up * 0.6f, ref JELIKOFDONK);
		PlayerController.RemoveMovementBlocker((Object)(object)this);
		yield return CommonReferences.wait2;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		AddQuest(39);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(CEHMCNPOEOL));
	}

	private IEnumerator BLHFOAMKOAH()
	{
		return new JPPPCGGCDCK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JHBNODHNMCI()
	{
		return new ANHGEEIMBNP(1)
		{
			_003C_003E4__this = this
		};
	}

	public override int GetID()
	{
		return 101;
	}

	private void CEHMCNPOEOL()
	{
		try
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(CEHMCNPOEOL));
			((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Error in T101_Dormir.CheckOnPlayerSleep: " + ex.Message));
		}
	}

	private IEnumerator HPNEFMANGHJ()
	{
		return new JPPPCGGCDCK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator FBOBCKJGPMB()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		while (!DMMFNMNKJLL())
		{
			yield return null;
		}
		MultiAudioManager.PlayAudioObject(creak1, ((Component)PlayerController.GetPlayer(triggerPlayerNum)).transform.position);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait05;
		DialogueManager.Bark("Tutorial/T101/Dialogue1", ((Component)PlayerController.GetPlayer(triggerPlayerNum)).transform);
		yield return CommonReferences.wait5;
		MultiAudioManager.PlayAudioObject(creak2, ((Component)PlayerController.GetPlayer(triggerPlayerNum)).transform.position);
		yield return CommonReferences.wait05;
		PlayerController.GetPlayer(triggerPlayerNum).emotionController.StartEmotion("Doubt");
		yield return CommonReferences.wait5;
		MaiNPC.GGFJGHHHEJC.dialogueActor.actor = "???";
		MaiNPC.GGFJGHHHEJC.dialogueActor.spritePortrait = MaiNPC.GGFJGHHHEJC.maiUnknown;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T101/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait05;
		MusicController.instance.TriggerMusicTheme(21);
		yield return CommonReferences.wait1_5;
		MaiNPC.GGFJGHHHEJC.dialogueActor.actor = "???";
		MaiNPC.GGFJGHHHEJC.dialogueActor.spritePortrait = MaiNPC.GGFJGHHHEJC.mai;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T101/Dialogue3", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bed.instance).transform.position), Vector2.up * 0.6f, ref JELIKOFDONK);
		PlayerController.RemoveMovementBlocker((Object)(object)this);
		yield return CommonReferences.wait2;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		AddQuest(39);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(CEHMCNPOEOL));
	}

	private IEnumerator JNOOAENGMHL()
	{
		for (int i = 0; i < SceneReferences.GetSceneReferences().nightStartDeactive.Length; i++)
		{
			((Behaviour)SceneReferences.GetSceneReferences().nightStartDeactive[i]).enabled = true;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		Object.Destroy((Object)(object)JELIKOFDONK);
		if ((Object)(object)NewTutorialManager.fireLoopSource != (Object)null)
		{
			NewTutorialManager.fireLoopSource.FadeOut(1f, false);
			NewTutorialManager.fireLoopSource = null;
		}
		else
		{
			Debug.Log((object)"Fire Loop NULL!!");
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator JAMDPHHGCDP()
	{
		return new ANHGEEIMBNP(1)
		{
			_003C_003E4__this = this
		};
	}

	private void AEENPHMPGLG()
	{
		try
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(BFMGPCKJOLK));
			((MonoBehaviour)this).StartCoroutine(CLCOEDFCDPK());
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Unique ID not set for online rock " + ex.Message));
		}
	}

	private void NMHDBDKJNMG()
	{
		try
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(AEENPHMPGLG));
			((MonoBehaviour)this).StartCoroutine(JNOOAENGMHL());
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Use" + ex.Message));
		}
	}

	private void DMBOPDCMLHG()
	{
		try
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(BONLEKODNHB));
			((MonoBehaviour)this).StartCoroutine(FDMJPHBJACE());
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("FerroProgress" + ex.Message));
		}
	}

	private void BFMGPCKJOLK()
	{
		try
		{
			CommonReferences instance = CommonReferences.GGFJGHHHEJC;
			instance.OnPlayerSleep = (Action)Delegate.Remove(instance.OnPlayerSleep, new Action(DMBOPDCMLHG));
			((MonoBehaviour)this).StartCoroutine(FDMJPHBJACE());
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("Stack" + ex.Message));
		}
	}

	private IEnumerator PBEKBJIJFDK()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		while (!DMMFNMNKJLL())
		{
			yield return null;
		}
		MultiAudioManager.PlayAudioObject(creak1, ((Component)PlayerController.GetPlayer(triggerPlayerNum)).transform.position);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait05;
		DialogueManager.Bark("Tutorial/T101/Dialogue1", ((Component)PlayerController.GetPlayer(triggerPlayerNum)).transform);
		yield return CommonReferences.wait5;
		MultiAudioManager.PlayAudioObject(creak2, ((Component)PlayerController.GetPlayer(triggerPlayerNum)).transform.position);
		yield return CommonReferences.wait05;
		PlayerController.GetPlayer(triggerPlayerNum).emotionController.StartEmotion("Doubt");
		yield return CommonReferences.wait5;
		MaiNPC.GGFJGHHHEJC.dialogueActor.actor = "???";
		MaiNPC.GGFJGHHHEJC.dialogueActor.spritePortrait = MaiNPC.GGFJGHHHEJC.maiUnknown;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T101/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait05;
		MusicController.instance.TriggerMusicTheme(21);
		yield return CommonReferences.wait1_5;
		MaiNPC.GGFJGHHHEJC.dialogueActor.actor = "???";
		MaiNPC.GGFJGHHHEJC.dialogueActor.spritePortrait = MaiNPC.GGFJGHHHEJC.mai;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T101/Dialogue3", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bed.instance).transform.position), Vector2.up * 0.6f, ref JELIKOFDONK);
		PlayerController.RemoveMovementBlocker((Object)(object)this);
		yield return CommonReferences.wait2;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		AddQuest(39);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(CEHMCNPOEOL));
	}

	private IEnumerator OAIEBGHEBAK()
	{
		return new ANHGEEIMBNP(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator CAKPGBAIIPI()
	{
		return new JPPPCGGCDCK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator OOFDOHFANIE()
	{
		return new ANHGEEIMBNP(1)
		{
			_003C_003E4__this = this
		};
	}

	private void KEGLOGLEDDM()
	{
		try
		{
			CommonReferences commonReferences = CommonReferences.MNFMOEKMJKN();
			commonReferences.OnPlayerSleep = (Action)Delegate.Remove(commonReferences.OnPlayerSleep, new Action(BFMGPCKJOLK));
			((MonoBehaviour)this).StartCoroutine(BLHFOAMKOAH());
		}
		catch (Exception ex)
		{
			Debug.LogError((object)("ActionBar3" + ex.Message));
		}
	}

	private IEnumerator CPCGNMPLFHM()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		while (!DMMFNMNKJLL())
		{
			yield return null;
		}
		MultiAudioManager.PlayAudioObject(creak1, ((Component)PlayerController.GetPlayer(triggerPlayerNum)).transform.position);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait05;
		DialogueManager.Bark("Tutorial/T101/Dialogue1", ((Component)PlayerController.GetPlayer(triggerPlayerNum)).transform);
		yield return CommonReferences.wait5;
		MultiAudioManager.PlayAudioObject(creak2, ((Component)PlayerController.GetPlayer(triggerPlayerNum)).transform.position);
		yield return CommonReferences.wait05;
		PlayerController.GetPlayer(triggerPlayerNum).emotionController.StartEmotion("Doubt");
		yield return CommonReferences.wait5;
		MaiNPC.GGFJGHHHEJC.dialogueActor.actor = "???";
		MaiNPC.GGFJGHHHEJC.dialogueActor.spritePortrait = MaiNPC.GGFJGHHHEJC.maiUnknown;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T101/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait05;
		MusicController.instance.TriggerMusicTheme(21);
		yield return CommonReferences.wait1_5;
		MaiNPC.GGFJGHHHEJC.dialogueActor.actor = "???";
		MaiNPC.GGFJGHHHEJC.dialogueActor.spritePortrait = MaiNPC.GGFJGHHHEJC.mai;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T101/Dialogue3", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bed.instance).transform.position), Vector2.up * 0.6f, ref JELIKOFDONK);
		PlayerController.RemoveMovementBlocker((Object)(object)this);
		yield return CommonReferences.wait2;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		AddQuest(39);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(CEHMCNPOEOL));
	}

	private IEnumerator PPMPKJECPDE()
	{
		return new ANHGEEIMBNP(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator ELPINNBKFIP()
	{
		for (int i = 0; i < SceneReferences.GetSceneReferences().nightStartDeactive.Length; i++)
		{
			((Behaviour)SceneReferences.GetSceneReferences().nightStartDeactive[i]).enabled = true;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		Object.Destroy((Object)(object)JELIKOFDONK);
		if ((Object)(object)NewTutorialManager.fireLoopSource != (Object)null)
		{
			NewTutorialManager.fireLoopSource.FadeOut(1f, false);
			NewTutorialManager.fireLoopSource = null;
		}
		else
		{
			Debug.Log((object)"Fire Loop NULL!!");
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator CLCOEDFCDPK()
	{
		return new JPPPCGGCDCK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HHDLDPPCLPE()
	{
		return new ANHGEEIMBNP(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator FDMJPHBJACE()
	{
		return new JPPPCGGCDCK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LGDNIGIMDKP()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		while (!DMMFNMNKJLL())
		{
			yield return null;
		}
		MultiAudioManager.PlayAudioObject(creak1, ((Component)PlayerController.GetPlayer(triggerPlayerNum)).transform.position);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		yield return CommonReferences.wait05;
		DialogueManager.Bark("Tutorial/T101/Dialogue1", ((Component)PlayerController.GetPlayer(triggerPlayerNum)).transform);
		yield return CommonReferences.wait5;
		MultiAudioManager.PlayAudioObject(creak2, ((Component)PlayerController.GetPlayer(triggerPlayerNum)).transform.position);
		yield return CommonReferences.wait05;
		PlayerController.GetPlayer(triggerPlayerNum).emotionController.StartEmotion("Doubt");
		yield return CommonReferences.wait5;
		MaiNPC.GGFJGHHHEJC.dialogueActor.actor = "???";
		MaiNPC.GGFJGHHHEJC.dialogueActor.spritePortrait = MaiNPC.GGFJGHHHEJC.maiUnknown;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T101/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait05;
		MusicController.instance.TriggerMusicTheme(21);
		yield return CommonReferences.wait1_5;
		MaiNPC.GGFJGHHHEJC.dialogueActor.actor = "???";
		MaiNPC.GGFJGHHHEJC.dialogueActor.spritePortrait = MaiNPC.GGFJGHHHEJC.mai;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T101/Dialogue3", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		yield return CommonReferences.wait1;
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.SpawnArrow(Vector2.op_Implicit(((Component)Bed.instance).transform.position), Vector2.up * 0.6f, ref JELIKOFDONK);
		PlayerController.RemoveMovementBlocker((Object)(object)this);
		yield return CommonReferences.wait2;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		AddQuest(39);
		CommonReferences instance = CommonReferences.GGFJGHHHEJC;
		instance.OnPlayerSleep = (Action)Delegate.Combine(instance.OnPlayerSleep, new Action(CEHMCNPOEOL));
	}

	private IEnumerator CNPPMBAKEBJ()
	{
		for (int i = 0; i < SceneReferences.GetSceneReferences().nightStartDeactive.Length; i++)
		{
			((Behaviour)SceneReferences.GetSceneReferences().nightStartDeactive[i]).enabled = true;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		Object.Destroy((Object)(object)JELIKOFDONK);
		if ((Object)(object)NewTutorialManager.fireLoopSource != (Object)null)
		{
			NewTutorialManager.fireLoopSource.FadeOut(1f, false);
			NewTutorialManager.fireLoopSource = null;
		}
		else
		{
			Debug.Log((object)"Fire Loop NULL!!");
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator LHDDHIJIFCN()
	{
		for (int i = 0; i < SceneReferences.GetSceneReferences().nightStartDeactive.Length; i++)
		{
			((Behaviour)SceneReferences.GetSceneReferences().nightStartDeactive[i]).enabled = true;
		}
		NewTutorialManager.instance.ObjectiveCompleted(0);
		Object.Destroy((Object)(object)JELIKOFDONK);
		if ((Object)(object)NewTutorialManager.fireLoopSource != (Object)null)
		{
			NewTutorialManager.fireLoopSource.FadeOut(1f, false);
			NewTutorialManager.fireLoopSource = null;
		}
		else
		{
			Debug.Log((object)"Fire Loop NULL!!");
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator IHBNOLLFNPA()
	{
		return new ANHGEEIMBNP(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator AKMGPONCFHL()
	{
		return new ANHGEEIMBNP(1)
		{
			_003C_003E4__this = this
		};
	}
}
