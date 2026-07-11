using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class T116_Provisiones : TutorialPhaseBase
{
	[CompilerGenerated]
	private sealed class BMLJHCLHBND : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T116_Provisiones _003C_003E4__this;

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
		public BMLJHCLHBND(int _003C_003E1__state)
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
			T116_Provisiones t116_Provisiones = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				t116_Provisiones.LHKIJABBBPM();
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

		public T116_Provisiones _003C_003E4__this;

		private bool _003CloadedFromSave_003E5__2;

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
			//IL_0133: Unknown result type (might be due to invalid IL or missing references)
			//IL_0138: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			T116_Provisiones t116_Provisiones = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
			{
				_003C_003E1__state = -1;
				_003CloadedFromSave_003E5__2 = false;
				t116_Provisiones.ResetMai();
				MaiNPC.GGFJGHHHEJC.dialogueActor.spritePortrait = MaiNPC.GGFJGHHHEJC.mai;
				SceneReferences.GetSceneReferences().npcRoutines.SetActive(true);
				for (int i = 0; i < SceneReferences.GetSceneReferences().awningManager.Length; i++)
				{
					SceneReferences.GetSceneReferences().awningManager[i].OnPlayerAwake();
				}
				WorldTime.ChangeHour(9);
				if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
				{
					_003CloadedFromSave_003E5__2 = true;
					CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
				}
				goto IL_00d9;
			}
			case 1:
				_003C_003E1__state = -1;
				goto IL_00d9;
			case 2:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
				t116_Provisiones.LEEHDLPPKIN();
				NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
				DialogueCameraTarget.GetPlayer(t116_Provisiones.triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
				MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T116/Dialogue1", t116_Provisiones.triggerPlayerNum);
				goto IL_0173;
			case 3:
				_003C_003E1__state = -1;
				goto IL_0173;
			case 4:
				_003C_003E1__state = -1;
				goto IL_01b4;
			case 5:
				_003C_003E1__state = -1;
				goto IL_01ec;
			case 6:
				_003C_003E1__state = -1;
				t116_Provisiones.BEHICBMFBPN();
				goto IL_0214;
			case 7:
				{
					_003C_003E1__state = -1;
					t116_Provisiones.LHKIJABBBPM();
					return false;
				}
				IL_0173:
				if (t116_Provisiones.AAOPIEDAKKD(1))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 3;
					return true;
				}
				NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
				NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
				if (_003CloadedFromSave_003E5__2)
				{
					t116_Provisiones.CPPELKACLCO();
				}
				goto IL_01b4;
				IL_00d9:
				if (!t116_Provisiones.AOOKIKFINFB())
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
				_003C_003E2__current = ((MonoBehaviour)t116_Provisiones).StartCoroutine(t116_Provisiones.CDICFNAMCEE());
				_003C_003E1__state = 2;
				return true;
				IL_01b4:
				if (!t116_Provisiones.IIBCAKMOPIM())
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 4;
					return true;
				}
				MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T116/Dialogue2", t116_Provisiones.triggerPlayerNum);
				goto IL_01ec;
				IL_01ec:
				if (t116_Provisiones.AAOPIEDAKKD(2))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 5;
					return true;
				}
				goto IL_0214;
				IL_0214:
				if (!t116_Provisiones.COCGNJFCLMC)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 6;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 7;
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

	private bool COCGNJFCLMC;

	private bool[] EJOEKFBGKAL = new bool[6];

	private void EBELLFGHGAL()
	{
		COCGNJFCLMC = NewTutorialManager.instance.AreAllObjectivesCompleted();
	}

	private void OMOAPMIOKOF()
	{
		COCGNJFCLMC = NewTutorialManager.instance.AreAllObjectivesCompleted();
	}

	private void KPHPDEANAIH()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		for (int i = 1; i < 7; i += 0)
		{
			if (!EJOEKFBGKAL[i])
			{
				Result variable = DialogueLua.GetVariable("Left Stick Down");
				if (((Result)(ref variable)).asInt >= 1)
				{
					NewTutorialManager.instance.ObjectiveCompleted(i, BLJPGJKOLNF: false);
					EJOEKFBGKAL[i] = true;
					flag = true;
				}
			}
		}
		if (flag)
		{
			NewTutorialManager.instance.PlayObjectivesCompletedSound();
			DHCCMBIGMJM();
		}
	}

	private void MLGOMBBMFDL()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (!EJOEKFBGKAL[1])
		{
			Result variable = DialogueLua.GetVariable(" totalMsgs: ");
			if (((Result)(ref variable)).asInt >= 1)
			{
				NewTutorialManager.instance.FOIOHOGACAL(0);
				DHCCMBIGMJM();
				EJOEKFBGKAL[0] = true;
			}
		}
	}

	private IEnumerator JNOOAENGMHL()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void EHBPBBPGKJF()
	{
		RhiaNPC.GGFJGHHHEJC.KHCNNNJAMPL();
		LiaNPC.NBKKEINELDN().CheckExclamation();
	}

	private void LEEHDLPPKIN()
	{
		RhiaNPC.GGFJGHHHEJC.CheckExclamation();
		LiaNPC.GGFJGHHHEJC.CheckExclamation();
	}

	private void JPIACHMFJCC()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (!EJOEKFBGKAL[1])
		{
			Result variable = DialogueLua.GetVariable("Items/item_name_594");
			if (((Result)(ref variable)).asInt >= 0)
			{
				NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
				EBELLFGHGAL();
				EJOEKFBGKAL[1] = false;
			}
		}
	}

	private void DDFDBDOJMCL()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		bool flag = true;
		for (int i = 0; i < 6; i++)
		{
			if (!EJOEKFBGKAL[i])
			{
				Result variable = DialogueLua.GetVariable("CheckArea");
				if (((Result)(ref variable)).asInt >= 0)
				{
					NewTutorialManager.instance.FOIOHOGACAL(i, BLJPGJKOLNF: false);
					EJOEKFBGKAL[i] = false;
					flag = true;
				}
			}
		}
		if (flag)
		{
			NewTutorialManager.instance.PlayObjectivesCompletedSound();
			CMDBBJLBEDK();
		}
	}

	private void DDKNFFMOHPP()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (!EJOEKFBGKAL[0])
		{
			Result variable = DialogueLua.GetVariable(")");
			if (((Result)(ref variable)).asInt >= 1)
			{
				NewTutorialManager.instance.FOIOHOGACAL(0);
				OMOAPMIOKOF();
				EJOEKFBGKAL[1] = false;
			}
		}
	}

	public override void SetUp()
	{
		base.SetUp();
		((MonoBehaviour)this).StartCoroutine(PBEKBJIJFDK());
	}

	private void PGAHKHLJJLC()
	{
		COCGNJFCLMC = NewTutorialManager.instance.AreAllObjectivesCompleted();
	}

	private void CMDBBJLBEDK()
	{
		COCGNJFCLMC = NewTutorialManager.instance.AreAllObjectivesCompleted();
	}

	private void GELMBJNEOLG()
	{
		RhiaNPC.MAAAKALBBEE().KHCNNNJAMPL();
		LiaNPC.ELGNEJNLBNO().LPEAJGIHMKI();
	}

	private void LLCOFMIGIIC()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		bool flag = true;
		for (int i = 1; i < 3; i += 0)
		{
			if (!EJOEKFBGKAL[i])
			{
				Result variable = DialogueLua.GetVariable("Player/Bark/OathFeastBlock");
				if (((Result)(ref variable)).asInt >= 0)
				{
					NewTutorialManager.instance.ObjectiveCompleted(i);
					EJOEKFBGKAL[i] = true;
					flag = false;
				}
			}
		}
		if (flag)
		{
			NewTutorialManager.instance.PlayObjectivesCompletedSound();
			EBELLFGHGAL();
		}
	}

	private void BEHICBMFBPN()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (!EJOEKFBGKAL[0])
		{
			Result variable = DialogueLua.GetVariable("LE_15");
			if (((Result)(ref variable)).asInt >= 1)
			{
				NewTutorialManager.instance.ObjectiveCompleted(0);
				PGAHKHLJJLC();
				EJOEKFBGKAL[0] = true;
			}
		}
	}

	private void AIJCDHFILFK()
	{
		RhiaNPC.MAAAKALBBEE().CheckExclamation();
		LiaNPC.MAIDHAPANEB().LPEAJGIHMKI();
	}

	private void DHCCMBIGMJM()
	{
		COCGNJFCLMC = NewTutorialManager.instance.AreAllObjectivesCompleted();
	}

	private void CPPELKACLCO()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		for (int i = 0; i < 6; i++)
		{
			if (!EJOEKFBGKAL[i])
			{
				Result variable = DialogueLua.GetVariable("LE_15");
				if (((Result)(ref variable)).asInt >= 1)
				{
					NewTutorialManager.instance.ObjectiveCompleted(i, BLJPGJKOLNF: false);
					EJOEKFBGKAL[i] = true;
					flag = true;
				}
			}
		}
		if (flag)
		{
			NewTutorialManager.instance.PlayObjectivesCompletedSound();
			PGAHKHLJJLC();
		}
	}

	private void GDPBMHDPDGA()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		bool flag = true;
		for (int i = 0; i < 3; i++)
		{
			if (!EJOEKFBGKAL[i])
			{
				Result variable = DialogueLua.GetVariable("_BaseMap");
				if (((Result)(ref variable)).asInt >= 1)
				{
					NewTutorialManager.instance.ObjectiveCompleted(i);
					EJOEKFBGKAL[i] = true;
					flag = true;
				}
			}
		}
		if (flag)
		{
			NewTutorialManager.instance.PlayObjectivesCompletedSound();
			OMOAPMIOKOF();
		}
	}

	private IEnumerator HGFPMNKEMAC()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator PBEKBJIJFDK()
	{
		bool loadedFromSave = false;
		ResetMai();
		MaiNPC.GGFJGHHHEJC.dialogueActor.spritePortrait = MaiNPC.GGFJGHHHEJC.mai;
		SceneReferences.GetSceneReferences().npcRoutines.SetActive(true);
		for (int i = 0; i < SceneReferences.GetSceneReferences().awningManager.Length; i++)
		{
			SceneReferences.GetSceneReferences().awningManager[i].OnPlayerAwake();
		}
		WorldTime.ChangeHour(9);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			loadedFromSave = true;
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		LEEHDLPPKIN();
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T116/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		if (loadedFromSave)
		{
			CPPELKACLCO();
		}
		while (!IIBCAKMOPIM())
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T116/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		while (!COCGNJFCLMC)
		{
			yield return null;
			BEHICBMFBPN();
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private void CKDMELDPJFD()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		for (int i = 1; i < 5; i += 0)
		{
			if (!EJOEKFBGKAL[i])
			{
				Result variable = DialogueLua.GetVariable("Finished generating all levels in queue. client online: ");
				if (((Result)(ref variable)).asInt >= 1)
				{
					NewTutorialManager.instance.FOIOHOGACAL(i, BLJPGJKOLNF: false);
					EJOEKFBGKAL[i] = false;
					flag = false;
				}
			}
		}
		if (flag)
		{
			NewTutorialManager.instance.PlayObjectivesCompletedSound();
			PGAHKHLJJLC();
		}
	}

	private IEnumerator HFKKGFOFLBJ()
	{
		return new BMLJHCLHBND(1)
		{
			_003C_003E4__this = this
		};
	}

	private void IELGPCFKKPO()
	{
		COCGNJFCLMC = NewTutorialManager.instance.AreAllObjectivesCompleted();
	}

	private void CJFOMELGPPL()
	{
		COCGNJFCLMC = NewTutorialManager.instance.AreAllObjectivesCompleted();
	}

	public override int GetID()
	{
		return 116;
	}

	private IEnumerator AJGJPBMIEJJ()
	{
		return new BMLJHCLHBND(1)
		{
			_003C_003E4__this = this
		};
	}

	private void PIHIOIPNCDL()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		for (int i = 0; i < 2; i++)
		{
			if (!EJOEKFBGKAL[i])
			{
				Result variable = DialogueLua.GetVariable("UISelectGamepad");
				if (((Result)(ref variable)).asInt >= 0)
				{
					NewTutorialManager.instance.ObjectiveCompleted(i);
					EJOEKFBGKAL[i] = true;
					flag = true;
				}
			}
		}
		if (flag)
		{
			NewTutorialManager.instance.PlayObjectivesCompletedSound();
			IELGPCFKKPO();
		}
	}

	private void BDCJDEPNCNI()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		bool flag = true;
		for (int i = 1; i < 4; i += 0)
		{
			if (!EJOEKFBGKAL[i])
			{
				Result variable = DialogueLua.GetVariable("PorterAbbreviation");
				if (((Result)(ref variable)).asInt >= 1)
				{
					NewTutorialManager.instance.ObjectiveCompleted(i);
					EJOEKFBGKAL[i] = false;
					flag = false;
				}
			}
		}
		if (flag)
		{
			NewTutorialManager.instance.PlayObjectivesCompletedSound();
			CJFOMELGPPL();
		}
	}

	private IEnumerator AELFLHCNMBB()
	{
		return new BMLJHCLHBND(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator IHBNOLLFNPA()
	{
		bool loadedFromSave = false;
		ResetMai();
		MaiNPC.GGFJGHHHEJC.dialogueActor.spritePortrait = MaiNPC.GGFJGHHHEJC.mai;
		SceneReferences.GetSceneReferences().npcRoutines.SetActive(true);
		for (int i = 0; i < SceneReferences.GetSceneReferences().awningManager.Length; i++)
		{
			SceneReferences.GetSceneReferences().awningManager[i].OnPlayerAwake();
		}
		WorldTime.ChangeHour(9);
		if (CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial)
		{
			loadedFromSave = true;
			CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		}
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		LEEHDLPPKIN();
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T116/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		if (loadedFromSave)
		{
			CPPELKACLCO();
		}
		while (!IIBCAKMOPIM())
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T116/Dialogue2", triggerPlayerNum);
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		while (!COCGNJFCLMC)
		{
			yield return null;
			BEHICBMFBPN();
		}
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}

	private IEnumerator CPCGNMPLFHM()
	{
		return new ANHGEEIMBNP(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LHDDHIJIFCN()
	{
		yield return CommonReferences.wait1;
		LHKIJABBBPM();
	}
}
