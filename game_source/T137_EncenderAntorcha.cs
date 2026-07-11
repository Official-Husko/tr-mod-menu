using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class T137_EncenderAntorcha : TutorialPhaseBase
{
	[CompilerGenerated]
	private sealed class HFGHJKEHEKJ : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T137_EncenderAntorcha _003C_003E4__this;

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
		public HFGHJKEHEKJ(int _003C_003E1__state)
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
			T137_EncenderAntorcha t137_EncenderAntorcha = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				t137_EncenderAntorcha.PGJBPJNFFJK = SceneManager.LoadSceneAsync("Quarry", (LoadSceneMode)1);
				goto IL_0057;
			case 1:
				_003C_003E1__state = -1;
				goto IL_0057;
			case 2:
				_003C_003E1__state = -1;
				FadeCamera.GetPlayer(1).FadeInWithDelay();
				if (GameManager.LocalCoop())
				{
					FadeCamera.GetPlayer(2).FadeInWithDelay();
				}
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 3;
				return true;
			case 3:
				{
					_003C_003E1__state = -1;
					MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T137/Dialogue2", 1, DHELBHAICMM: false, CGKNJONAKGD: false);
					return false;
				}
				IL_0057:
				if (!t137_EncenderAntorcha.PGJBPJNFFJK.isDone)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
				MaiNPC.GGFJGHHHEJC.animationBase.FCGBJEIIMBC = Direction.Up;
				PlayerController.GetPlayer(1).characterAnimation.FCGBJEIIMBC = Direction.Up;
				if (GameManager.LocalCoop())
				{
					PlayerController.GetPlayer(2).characterAnimation.FCGBJEIIMBC = Direction.Up;
				}
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
	private sealed class BMLJHCLHBND : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public T137_EncenderAntorcha _003C_003E4__this;

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
			T137_EncenderAntorcha t137_EncenderAntorcha = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				t137_EncenderAntorcha.LHKIJABBBPM();
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

		public T137_EncenderAntorcha _003C_003E4__this;

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
			//IL_0134: Unknown result type (might be due to invalid IL or missing references)
			//IL_0139: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			T137_EncenderAntorcha t137_EncenderAntorcha = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
				_003C_003E2__current = CommonReferences.wait02;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
				MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
				goto IL_009f;
			case 2:
				_003C_003E1__state = -1;
				goto IL_009f;
			case 3:
				_003C_003E1__state = -1;
				_003C_003E2__current = ((MonoBehaviour)t137_EncenderAntorcha).StartCoroutine(t137_EncenderAntorcha.CDICFNAMCEE());
				_003C_003E1__state = 4;
				return true;
			case 4:
				_003C_003E1__state = -1;
				NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
				MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
				NewTutorialManager.instance.quarryBlock = false;
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 5;
				return true;
			case 5:
				_003C_003E1__state = -1;
				DialogueCameraTarget.GetPlayer(t137_EncenderAntorcha.triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
				MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T137/Dialogue1", t137_EncenderAntorcha.triggerPlayerNum);
				goto IL_0174;
			case 6:
				_003C_003E1__state = -1;
				goto IL_0174;
			case 7:
				_003C_003E1__state = -1;
				t137_EncenderAntorcha.QuarryCaveTp();
				break;
			case 8:
				{
					_003C_003E1__state = -1;
					break;
				}
				IL_0174:
				if (t137_EncenderAntorcha.AAOPIEDAKKD(1))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 6;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 7;
				return true;
				IL_009f:
				if (!t137_EncenderAntorcha.AOOKIKFINFB())
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 2;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 3;
				return true;
			}
			if (t137_EncenderAntorcha.AAOPIEDAKKD(2))
			{
				_003C_003E2__current = null;
				_003C_003E1__state = 8;
				return true;
			}
			NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
			NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
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

	private AsyncOperation PGJBPJNFFJK;

	private IEnumerator HEGJIMFLICJ()
	{
		PGJBPJNFFJK = SceneManager.LoadSceneAsync("Quarry", (LoadSceneMode)1);
		while (!PGJBPJNFFJK.isDone)
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.animationBase.FCGBJEIIMBC = Direction.Up;
		PlayerController.GetPlayer(1).characterAnimation.FCGBJEIIMBC = Direction.Up;
		if (GameManager.LocalCoop())
		{
			PlayerController.GetPlayer(2).characterAnimation.FCGBJEIIMBC = Direction.Up;
		}
		yield return CommonReferences.wait05;
		FadeCamera.GetPlayer(1).FadeInWithDelay();
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeInWithDelay();
		}
		yield return CommonReferences.wait05;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T137/Dialogue2", 1, DHELBHAICMM: false, CGKNJONAKGD: false);
	}

	private IEnumerator CBFFGPLMBMD()
	{
		return new HFGHJKEHEKJ(1)
		{
			_003C_003E4__this = this
		};
	}

	private void AILHAJFDMBE(int JIIGOACEIKL)
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernClose = (Action<int>)Delegate.Remove(instance.OnTavernClose, new Action<int>(AFLAPFHAHMP));
		((MonoBehaviour)this).StartCoroutine(OGOFIFJCMEB());
	}

	private IEnumerator JPNHEKDDJJD()
	{
		return new ANHGEEIMBNP(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JLDPBKAEOJH()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	public void GOBFOIAGIHM()
	{
		NewTutorialManager.GJIDCOKLGCF(APGEBAEHLMM: true);
		NewTutorialManager.instance.FOIOHOGACAL(1);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	public void BFIGBHHHFAJ()
	{
		FadeCamera player = FadeCamera.GetPlayer(0);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(PDEBAOBPBFP));
		FadeCamera.IGMCBPOPNCA(0).AJHDEBOMHKK(1873f);
		if (GameManager.LocalCoop())
		{
			FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(4);
			fadeCamera.OnFadeFinished = (Action<int>)Delegate.Combine(fadeCamera.OnFadeFinished, new Action<int>(JOENNIJFEEL));
			FadeCamera.EIFPKCAFDIB(2).AJHDEBOMHKK(157f);
		}
	}

	private IEnumerator AAGGGIONDAG()
	{
		return new ANHGEEIMBNP(1)
		{
			_003C_003E4__this = this
		};
	}

	public void NCGDAJEKBEG()
	{
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(MAOPADFGKHO));
		FadeCamera.IGMCBPOPNCA(1).IONMINJHMKL(1143f);
		if (GameManager.LocalCoop())
		{
			FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(4);
			fadeCamera.OnFadeFinished = (Action<int>)Delegate.Combine(fadeCamera.OnFadeFinished, new Action<int>(CPMCGCLAKKO));
			FadeCamera.GetPlayer(6).GPBOEBGJJPM(1607f);
		}
	}

	private IEnumerator PCCAMOFKPLK()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		NewTutorialManager.instance.quarryBlock = false;
		yield return CommonReferences.wait05;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T137/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait05;
		QuarryCaveTp();
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
	}

	private IEnumerator JBDHOFJEMEO()
	{
		return new BMLJHCLHBND(1)
		{
			_003C_003E4__this = this
		};
	}

	private void JFONPALKPAM(int JIIGOACEIKL)
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernClose = (Action<int>)Delegate.Remove(instance.OnTavernClose, new Action<int>(BKHJAAKIDKL));
		((MonoBehaviour)this).StartCoroutine(BLNKHNHGFPB());
	}

	private IEnumerator DDPLLOBIADE()
	{
		return new HFGHJKEHEKJ(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HCKCEGEOJLO()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator AHBHFNGMIMA()
	{
		PGJBPJNFFJK = SceneManager.LoadSceneAsync("Quarry", (LoadSceneMode)1);
		while (!PGJBPJNFFJK.isDone)
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.animationBase.FCGBJEIIMBC = Direction.Up;
		PlayerController.GetPlayer(1).characterAnimation.FCGBJEIIMBC = Direction.Up;
		if (GameManager.LocalCoop())
		{
			PlayerController.GetPlayer(2).characterAnimation.FCGBJEIIMBC = Direction.Up;
		}
		yield return CommonReferences.wait05;
		FadeCamera.GetPlayer(1).FadeInWithDelay();
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeInWithDelay();
		}
		yield return CommonReferences.wait05;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T137/Dialogue2", 1, DHELBHAICMM: false, CGKNJONAKGD: false);
	}

	private IEnumerator NLBMDPLFEGO()
	{
		PGJBPJNFFJK = SceneManager.LoadSceneAsync("Quarry", (LoadSceneMode)1);
		while (!PGJBPJNFFJK.isDone)
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.animationBase.FCGBJEIIMBC = Direction.Up;
		PlayerController.GetPlayer(1).characterAnimation.FCGBJEIIMBC = Direction.Up;
		if (GameManager.LocalCoop())
		{
			PlayerController.GetPlayer(2).characterAnimation.FCGBJEIIMBC = Direction.Up;
		}
		yield return CommonReferences.wait05;
		FadeCamera.GetPlayer(1).FadeInWithDelay();
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeInWithDelay();
		}
		yield return CommonReferences.wait05;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T137/Dialogue2", 1, DHELBHAICMM: false, CGKNJONAKGD: false);
	}

	private void IHKIMOJPJEC(int JIIGOACEIKL)
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernClose = (Action<int>)Delegate.Remove(instance.OnTavernClose, new Action<int>(DFCNIAADEBM));
		((MonoBehaviour)this).StartCoroutine(PBEKBJIJFDK());
	}

	private void HFFOMAOHHKM(int JIIGOACEIKL)
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernClose = (Action<int>)Delegate.Remove(instance.OnTavernClose, new Action<int>(BKHJAAKIDKL));
		((MonoBehaviour)this).StartCoroutine(HPDFPEJHCLF());
	}

	public void IPCFDAJDIJC()
	{
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
		((MonoBehaviour)this).StartCoroutine(HGFPMNKEMAC());
	}

	private IEnumerator NCBODCOOANK()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private void PPEFILFJCLP(int JIIGOACEIKL)
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernClose = (Action<int>)Delegate.Remove(instance.OnTavernClose, new Action<int>(KEIJJLNFKAL));
		((MonoBehaviour)this).StartCoroutine(HFFIGEDMMJF());
	}

	public void MMADFNDJFOB()
	{
		FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(1);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Combine(fadeCamera.OnFadeFinished, new Action<int>(MHBKIAOJMPN));
		FadeCamera.IGMCBPOPNCA(0).AJHDEBOMHKK(350f);
		if (GameManager.LocalCoop())
		{
			FadeCamera player = FadeCamera.GetPlayer(4);
			player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(KFCLPBKABHD));
			FadeCamera.IGMCBPOPNCA(4).FadeOut(1302f);
		}
	}

	private IEnumerator AGNICHFHJFH()
	{
		return new HFGHJKEHEKJ(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HPDFPEJHCLF()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		NewTutorialManager.instance.quarryBlock = false;
		yield return CommonReferences.wait05;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T137/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait05;
		QuarryCaveTp();
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
	}

	public void HPDLHBLCLPG()
	{
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
		((MonoBehaviour)this).StartCoroutine(LPCPNKEMCNM());
	}

	private IEnumerator DOEHBKLDFKD()
	{
		PGJBPJNFFJK = SceneManager.LoadSceneAsync("Quarry", (LoadSceneMode)1);
		while (!PGJBPJNFFJK.isDone)
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.animationBase.FCGBJEIIMBC = Direction.Up;
		PlayerController.GetPlayer(1).characterAnimation.FCGBJEIIMBC = Direction.Up;
		if (GameManager.LocalCoop())
		{
			PlayerController.GetPlayer(2).characterAnimation.FCGBJEIIMBC = Direction.Up;
		}
		yield return CommonReferences.wait05;
		FadeCamera.GetPlayer(1).FadeInWithDelay();
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeInWithDelay();
		}
		yield return CommonReferences.wait05;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T137/Dialogue2", 1, DHELBHAICMM: false, CGKNJONAKGD: false);
	}

	private void PBHGJIJHOAB(int ABAIKKGKDGD)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(1);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(IJIPBCAJPED));
		if (PlayerController.OPHDCMJLLEC(0).trayHandler.tray.currentDrinks != null)
		{
			PlayerController.GetPlayer(0).trayHandler.tray.LIHGILDLODK(1, GFNHAMCPEAK: false);
		}
		PlayerController.TeleportPlayer(0, SceneReferences.CKDKHMPHENE().quarryCaveTp.position, Location.River | Location.Quarry);
		if (GameManager.LocalCoop())
		{
			FadeCamera player = FadeCamera.GetPlayer(1);
			player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(KFCLPBKABHD));
			if (PlayerController.GetPlayer(3).trayHandler.tray.currentDrinks != null)
			{
				PlayerController.OPHDCMJLLEC(4).trayHandler.tray.LDPHJNIPDJA(1, GFNHAMCPEAK: false);
			}
			PlayerController.TeleportPlayer(7, SceneReferences.GetSceneReferences().quarryCaveTp.position + new Vector3(718f, 1727f, 1964f), Location.Road);
		}
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = SceneReferences.GetSceneReferences().quarryCaveTp.position - new Vector3(1267f, 1119f, 1593f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((MonoBehaviour)this).StartCoroutine(KJDKCMAANLO());
	}

	private IEnumerator JIICBOOJNMB()
	{
		return new ANHGEEIMBNP(1)
		{
			_003C_003E4__this = this
		};
	}

	public void DJHDBIODDII()
	{
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		NewTutorialManager.instance.ObjectiveCompleted(1);
		((MonoBehaviour)this).StartCoroutine(NCBODCOOANK());
	}

	private void EMLLIIJHLNE(int ABAIKKGKDGD)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(1);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(LONGNFKBGKE));
		if (PlayerController.OPHDCMJLLEC(1).trayHandler.tray.currentDrinks != null)
		{
			PlayerController.GetPlayer(1).trayHandler.tray.LIHGILDLODK(1, GFNHAMCPEAK: false);
		}
		PlayerController.CLEIAKPOGMM(0, SceneReferences.FAOPFMBMMJJ().quarryCaveTp.position, ~(Location.River | Location.Camp));
		if (GameManager.LocalCoop())
		{
			FadeCamera fadeCamera2 = FadeCamera.IGMCBPOPNCA(8);
			fadeCamera2.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera2.OnFadeFinished, new Action<int>(KFCLPBKABHD));
			if (PlayerController.OPHDCMJLLEC(5).trayHandler.tray.currentDrinks != null)
			{
				PlayerController.OPHDCMJLLEC(1).trayHandler.tray.OHAJMGCPGMK(0);
			}
			PlayerController.CLEIAKPOGMM(8, SceneReferences.GetSceneReferences().quarryCaveTp.position + new Vector3(100f, 129f, 1086f), ~(Location.Tavern | Location.Road | Location.Camp | Location.Quarry | Location.BarnInterior));
		}
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = SceneReferences.GetSceneReferences().quarryCaveTp.position - new Vector3(306f, 927f, 1278f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((MonoBehaviour)this).StartCoroutine(MMGOPABAICK());
	}

	public override int GetID()
	{
		return 137;
	}

	private void AFLAPFHAHMP(int JIIGOACEIKL)
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernClose = (Action<int>)Delegate.Remove(instance.OnTavernClose, new Action<int>(LNKHGKGCAOL));
		((MonoBehaviour)this).StartCoroutine(HPDFPEJHCLF());
	}

	private IEnumerator GDCMANLMBDB()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		NewTutorialManager.instance.quarryBlock = false;
		yield return CommonReferences.wait05;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T137/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait05;
		QuarryCaveTp();
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
	}

	private void DFCNIAADEBM(int JIIGOACEIKL)
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernClose = (Action<int>)Delegate.Remove(instance.OnTavernClose, new Action<int>(HOLECPOFCHH));
		((MonoBehaviour)this).StartCoroutine(CNPIAJBODCG());
	}

	private void LDCOKGOICNA(int ABAIKKGKDGD)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera player = FadeCamera.GetPlayer(0);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(PBHGJIJHOAB));
		if (PlayerController.OPHDCMJLLEC(1).trayHandler.tray.currentDrinks != null)
		{
			PlayerController.OPHDCMJLLEC(1).trayHandler.tray.MOFBGCELGFN(0, GFNHAMCPEAK: false);
		}
		PlayerController.CLEIAKPOGMM(0, SceneReferences.CKDKHMPHENE().quarryCaveTp.position, Location.Tavern | Location.Road | Location.BarnInterior);
		if (GameManager.LocalCoop())
		{
			FadeCamera player2 = FadeCamera.GetPlayer(2);
			player2.OnFadeFinished = (Action<int>)Delegate.Remove(player2.OnFadeFinished, new Action<int>(MAOPADFGKHO));
			if (PlayerController.OPHDCMJLLEC(3).trayHandler.tray.currentDrinks != null)
			{
				PlayerController.GetPlayer(5).trayHandler.tray.OHAJMGCPGMK();
			}
			PlayerController.CLEIAKPOGMM(0, SceneReferences.FAOPFMBMMJJ().quarryCaveTp.position + new Vector3(695f, 1281f, 1936f), Location.Road | Location.River | Location.Camp);
		}
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = SceneReferences.CKDKHMPHENE().quarryCaveTp.position - new Vector3(1897f, 1837f, 1471f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((MonoBehaviour)this).StartCoroutine(LOJHHOBFFEB());
	}

	private void NCMICHCNCFO(int JIIGOACEIKL)
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernClose = (Action<int>)Delegate.Remove(instance.OnTavernClose, new Action<int>(EBAKHHLJMGE));
		((MonoBehaviour)this).StartCoroutine(JAHNJFGKFII());
	}

	private void KFCLPBKABHD(int ABAIKKGKDGD)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(0);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(DBKLBDHNGHL));
		if (PlayerController.GetPlayer(0).trayHandler.tray.currentDrinks != null)
		{
			PlayerController.OPHDCMJLLEC(1).trayHandler.tray.FIJLPLJMJFA(1, GFNHAMCPEAK: false);
		}
		PlayerController.TeleportPlayer(1, SceneReferences.FAOPFMBMMJJ().quarryCaveTp.position, Location.Tavern | Location.Road | Location.Quarry);
		if (GameManager.LocalCoop())
		{
			FadeCamera player = FadeCamera.GetPlayer(0);
			player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(CBBILJEAIHN));
			if (PlayerController.OPHDCMJLLEC(1).trayHandler.tray.currentDrinks != null)
			{
				PlayerController.GetPlayer(7).trayHandler.tray.LIHGILDLODK(0, GFNHAMCPEAK: false);
			}
			PlayerController.CLEIAKPOGMM(4, SceneReferences.CKDKHMPHENE().quarryCaveTp.position + new Vector3(171f, 57f, 1887f), Location.Tavern | Location.River | Location.Quarry | Location.Farm | Location.BarnInterior);
		}
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = SceneReferences.GetSceneReferences().quarryCaveTp.position - new Vector3(917f, 655f, 77f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((MonoBehaviour)this).StartCoroutine(LADAGADIGPP());
	}

	private void NOJAHMNFFLF(int ABAIKKGKDGD)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(0);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(MEDBBAMHIPB));
		if (PlayerController.OPHDCMJLLEC(0).trayHandler.tray.currentDrinks != null)
		{
			PlayerController.OPHDCMJLLEC(1).trayHandler.tray.LDPHJNIPDJA();
		}
		PlayerController.CLEIAKPOGMM(0, SceneReferences.GetSceneReferences().quarryCaveTp.position, Location.Road | Location.Quarry | Location.BarnInterior);
		if (GameManager.LocalCoop())
		{
			FadeCamera fadeCamera2 = FadeCamera.IGMCBPOPNCA(4);
			fadeCamera2.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera2.OnFadeFinished, new Action<int>(EMLLIIJHLNE));
			if (PlayerController.GetPlayer(5).trayHandler.tray.currentDrinks != null)
			{
				PlayerController.GetPlayer(5).trayHandler.tray.FIJLPLJMJFA(0);
			}
			PlayerController.CLEIAKPOGMM(4, SceneReferences.CKDKHMPHENE().quarryCaveTp.position + new Vector3(838f, 41f, 683f), Location.Camp);
		}
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = SceneReferences.CKDKHMPHENE().quarryCaveTp.position - new Vector3(670f, 1674f, 1664f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((MonoBehaviour)this).StartCoroutine(JJGPNGAEGCP());
	}

	private void PDEBAOBPBFP(int ABAIKKGKDGD)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(1);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(OAJHGJAGGAB));
		if (PlayerController.GetPlayer(0).trayHandler.tray.currentDrinks != null)
		{
			PlayerController.OPHDCMJLLEC(1).trayHandler.tray.FIJLPLJMJFA(0);
		}
		PlayerController.CLEIAKPOGMM(0, SceneReferences.CFAMKBHIGLO().quarryCaveTp.position, ~(Location.Tavern | Location.Camp | Location.Farm));
		if (GameManager.LocalCoop())
		{
			FadeCamera fadeCamera2 = FadeCamera.IGMCBPOPNCA(8);
			fadeCamera2.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera2.OnFadeFinished, new Action<int>(FDFHKGHDIOE));
			if (PlayerController.GetPlayer(7).trayHandler.tray.currentDrinks != null)
			{
				PlayerController.GetPlayer(1).trayHandler.tray.LDPHJNIPDJA(1, GFNHAMCPEAK: false);
			}
			PlayerController.CLEIAKPOGMM(6, SceneReferences.GetSceneReferences().quarryCaveTp.position + new Vector3(38f, 203f, 1102f), ~(Location.Road | Location.River | Location.Quarry | Location.Farm | Location.BarnInterior));
		}
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = SceneReferences.CKDKHMPHENE().quarryCaveTp.position - new Vector3(650f, 1067f, 1818f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((MonoBehaviour)this).StartCoroutine(LADAGADIGPP());
	}

	private IEnumerator LOPECFGACHD()
	{
		return new ANHGEEIMBNP(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator GGGKNEANNMJ()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator JJGPNGAEGCP()
	{
		PGJBPJNFFJK = SceneManager.LoadSceneAsync("Quarry", (LoadSceneMode)1);
		while (!PGJBPJNFFJK.isDone)
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.animationBase.FCGBJEIIMBC = Direction.Up;
		PlayerController.GetPlayer(1).characterAnimation.FCGBJEIIMBC = Direction.Up;
		if (GameManager.LocalCoop())
		{
			PlayerController.GetPlayer(2).characterAnimation.FCGBJEIIMBC = Direction.Up;
		}
		yield return CommonReferences.wait05;
		FadeCamera.GetPlayer(1).FadeInWithDelay();
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeInWithDelay();
		}
		yield return CommonReferences.wait05;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T137/Dialogue2", 1, DHELBHAICMM: false, CGKNJONAKGD: false);
	}

	private void GDIFNJEKLGC(int ABAIKKGKDGD)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera player = FadeCamera.GetPlayer(0);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(KCFDNLCLJIA));
		if (PlayerController.GetPlayer(0).trayHandler.tray.currentDrinks != null)
		{
			PlayerController.GetPlayer(1).trayHandler.tray.ACDHANDNCNC(1, GFNHAMCPEAK: false);
		}
		PlayerController.CLEIAKPOGMM(1, SceneReferences.CKDKHMPHENE().quarryCaveTp.position, ~(Location.Road | Location.BarnInterior));
		if (GameManager.LocalCoop())
		{
			FadeCamera player2 = FadeCamera.GetPlayer(0);
			player2.OnFadeFinished = (Action<int>)Delegate.Remove(player2.OnFadeFinished, new Action<int>(LONGNFKBGKE));
			if (PlayerController.GetPlayer(4).trayHandler.tray.currentDrinks != null)
			{
				PlayerController.OPHDCMJLLEC(0).trayHandler.tray.OHAJMGCPGMK(0);
			}
			PlayerController.CLEIAKPOGMM(0, SceneReferences.GetSceneReferences().quarryCaveTp.position + new Vector3(1708f, 794f, 671f), Location.Tavern | Location.Camp);
		}
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = SceneReferences.GetSceneReferences().quarryCaveTp.position - new Vector3(572f, 1295f, 1756f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((MonoBehaviour)this).StartCoroutine(AHBHFNGMIMA());
	}

	public void IDMHNLCJFEF()
	{
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
		((MonoBehaviour)this).StartCoroutine(OCCLCKFAILK());
	}

	public void HFILFCAHAGC()
	{
		FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(0);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Combine(fadeCamera.OnFadeFinished, new Action<int>(BCBPENLMBBH));
		FadeCamera.GetPlayer(1).FadeOut(1119f);
		if (GameManager.LocalCoop())
		{
			FadeCamera fadeCamera2 = FadeCamera.EIFPKCAFDIB(4);
			fadeCamera2.OnFadeFinished = (Action<int>)Delegate.Combine(fadeCamera2.OnFadeFinished, new Action<int>(MHBKIAOJMPN));
			FadeCamera.EIFPKCAFDIB(4).GPBOEBGJJPM(1720f);
		}
	}

	private IEnumerator OFOLEPNOONG()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	public void EEPGNIABBKG()
	{
		FadeCamera player = FadeCamera.GetPlayer(0);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(GDIFNJEKLGC));
		FadeCamera.GetPlayer(0).AJHDEBOMHKK(729f);
		if (GameManager.LocalCoop())
		{
			FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(0);
			fadeCamera.OnFadeFinished = (Action<int>)Delegate.Combine(fadeCamera.OnFadeFinished, new Action<int>(MHBKIAOJMPN));
			FadeCamera.IGMCBPOPNCA(7).IONMINJHMKL(673f);
		}
	}

	private IEnumerator MMGOPABAICK()
	{
		PGJBPJNFFJK = SceneManager.LoadSceneAsync("Quarry", (LoadSceneMode)1);
		while (!PGJBPJNFFJK.isDone)
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.animationBase.FCGBJEIIMBC = Direction.Up;
		PlayerController.GetPlayer(1).characterAnimation.FCGBJEIIMBC = Direction.Up;
		if (GameManager.LocalCoop())
		{
			PlayerController.GetPlayer(2).characterAnimation.FCGBJEIIMBC = Direction.Up;
		}
		yield return CommonReferences.wait05;
		FadeCamera.GetPlayer(1).FadeInWithDelay();
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeInWithDelay();
		}
		yield return CommonReferences.wait05;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T137/Dialogue2", 1, DHELBHAICMM: false, CGKNJONAKGD: false);
	}

	private void AEJCFLLAGFI(int ABAIKKGKDGD)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(CBBILJEAIHN));
		if (PlayerController.GetPlayer(1).trayHandler.tray.currentDrinks != null)
		{
			PlayerController.OPHDCMJLLEC(1).trayHandler.tray.MOFBGCELGFN(0, GFNHAMCPEAK: false);
		}
		PlayerController.CLEIAKPOGMM(1, SceneReferences.GetSceneReferences().quarryCaveTp.position, ~(Location.Tavern | Location.Road | Location.River | Location.Quarry));
		if (GameManager.LocalCoop())
		{
			FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(3);
			fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(MHBKIAOJMPN));
			if (PlayerController.GetPlayer(7).trayHandler.tray.currentDrinks != null)
			{
				PlayerController.OPHDCMJLLEC(1).trayHandler.tray.NBODABCGELG(0, GFNHAMCPEAK: false);
			}
			PlayerController.TeleportPlayer(8, SceneReferences.FAOPFMBMMJJ().quarryCaveTp.position + new Vector3(896f, 492f, 1810f), ~(Location.Tavern | Location.Road | Location.River | Location.Farm | Location.BarnInterior));
		}
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = SceneReferences.FAOPFMBMMJJ().quarryCaveTp.position - new Vector3(1443f, 41f, 1754f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((MonoBehaviour)this).StartCoroutine(DOFPPAOIOEP());
	}

	private void FGLHLOCIALH(int JIIGOACEIKL)
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernClose = (Action<int>)Delegate.Remove(instance.OnTavernClose, new Action<int>(FGLHLOCIALH));
		((MonoBehaviour)this).StartCoroutine(CNPIAJBODCG());
	}

	public override void SetUp()
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		base.SetUp();
		NewTutorialManager.instance.quarryBlock = true;
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = new Vector3(6.479167f, 908.7083f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)Bar.instance.placeable.placeableSurface).transform;
		if (!TavernManager.GGFJGHHHEJC.LKOJBFMGMAE)
		{
			((MonoBehaviour)this).StartCoroutine(PBEKBJIJFDK());
			return;
		}
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernClose = (Action<int>)Delegate.Combine(instance.OnTavernClose, new Action<int>(LOGAAGEKGOK));
	}

	private void JOENNIJFEEL(int ABAIKKGKDGD)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(0);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(DBKLBDHNGHL));
		if (PlayerController.OPHDCMJLLEC(1).trayHandler.tray.currentDrinks != null)
		{
			PlayerController.OPHDCMJLLEC(1).trayHandler.tray.OHAJMGCPGMK(1, GFNHAMCPEAK: false);
		}
		PlayerController.CLEIAKPOGMM(0, SceneReferences.GetSceneReferences().quarryCaveTp.position, ~Location.Road);
		if (GameManager.LocalCoop())
		{
			FadeCamera fadeCamera2 = FadeCamera.IGMCBPOPNCA(3);
			fadeCamera2.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera2.OnFadeFinished, new Action<int>(KFCLPBKABHD));
			if (PlayerController.OPHDCMJLLEC(1).trayHandler.tray.currentDrinks != null)
			{
				PlayerController.OPHDCMJLLEC(5).trayHandler.tray.MOFBGCELGFN();
			}
			PlayerController.CLEIAKPOGMM(0, SceneReferences.CFAMKBHIGLO().quarryCaveTp.position + new Vector3(404f, 1921f, 1036f), ~(Location.Tavern | Location.Camp | Location.Farm | Location.BarnInterior));
		}
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = SceneReferences.CFAMKBHIGLO().quarryCaveTp.position - new Vector3(619f, 653f, 648f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((MonoBehaviour)this).StartCoroutine(OONLAPJGKHM());
	}

	private IEnumerator MOGINLPNGOG()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator MBGDCMCGEBC()
	{
		return new ANHGEEIMBNP(1)
		{
			_003C_003E4__this = this
		};
	}

	public void DAEKOLCPEBL()
	{
		NewTutorialManager.GJIDCOKLGCF(APGEBAEHLMM: false);
		NewTutorialManager.instance.FOIOHOGACAL(1, BLJPGJKOLNF: false);
		((MonoBehaviour)this).StartCoroutine(BJPDFDCOJKJ());
	}

	private IEnumerator AGPMPNNAJPF()
	{
		PGJBPJNFFJK = SceneManager.LoadSceneAsync("Quarry", (LoadSceneMode)1);
		while (!PGJBPJNFFJK.isDone)
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.animationBase.FCGBJEIIMBC = Direction.Up;
		PlayerController.GetPlayer(1).characterAnimation.FCGBJEIIMBC = Direction.Up;
		if (GameManager.LocalCoop())
		{
			PlayerController.GetPlayer(2).characterAnimation.FCGBJEIIMBC = Direction.Up;
		}
		yield return CommonReferences.wait05;
		FadeCamera.GetPlayer(1).FadeInWithDelay();
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeInWithDelay();
		}
		yield return CommonReferences.wait05;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T137/Dialogue2", 1, DHELBHAICMM: false, CGKNJONAKGD: false);
	}

	private IEnumerator EFKIBEABCPK()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator BBIGONPOMHO()
	{
		PGJBPJNFFJK = SceneManager.LoadSceneAsync("Quarry", (LoadSceneMode)1);
		while (!PGJBPJNFFJK.isDone)
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.animationBase.FCGBJEIIMBC = Direction.Up;
		PlayerController.GetPlayer(1).characterAnimation.FCGBJEIIMBC = Direction.Up;
		if (GameManager.LocalCoop())
		{
			PlayerController.GetPlayer(2).characterAnimation.FCGBJEIIMBC = Direction.Up;
		}
		yield return CommonReferences.wait05;
		FadeCamera.GetPlayer(1).FadeInWithDelay();
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeInWithDelay();
		}
		yield return CommonReferences.wait05;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T137/Dialogue2", 1, DHELBHAICMM: false, CGKNJONAKGD: false);
	}

	private IEnumerator HFFIGEDMMJF()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		NewTutorialManager.instance.quarryBlock = false;
		yield return CommonReferences.wait05;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T137/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait05;
		QuarryCaveTp();
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
	}

	private IEnumerator OPMGLCANKPH()
	{
		return new ANHGEEIMBNP(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator FJBKBPOLINL()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private void ENMPDHALAPD(int ABAIKKGKDGD)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(0);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(LIKBNNPFFEF));
		if (PlayerController.OPHDCMJLLEC(1).trayHandler.tray.currentDrinks != null)
		{
			PlayerController.OPHDCMJLLEC(0).trayHandler.tray.OHAJMGCPGMK(0);
		}
		PlayerController.CLEIAKPOGMM(0, SceneReferences.GetSceneReferences().quarryCaveTp.position, Location.Tavern | Location.Road | Location.Camp | Location.Quarry | Location.Farm | Location.BarnInterior);
		if (GameManager.LocalCoop())
		{
			FadeCamera fadeCamera2 = FadeCamera.IGMCBPOPNCA(3);
			fadeCamera2.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera2.OnFadeFinished, new Action<int>(GPFHEEJIACF));
			if (PlayerController.OPHDCMJLLEC(8).trayHandler.tray.currentDrinks != null)
			{
				PlayerController.GetPlayer(0).trayHandler.tray.MOFBGCELGFN(1, GFNHAMCPEAK: false);
			}
			PlayerController.TeleportPlayer(1, SceneReferences.FAOPFMBMMJJ().quarryCaveTp.position + new Vector3(805f, 1938f, 1313f), Location.River | Location.Camp | Location.Farm | Location.BarnInterior);
		}
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = SceneReferences.GetSceneReferences().quarryCaveTp.position - new Vector3(541f, 1771f, 1061f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((MonoBehaviour)this).StartCoroutine(DOFPPAOIOEP());
	}

	private void BCBPENLMBBH(int ABAIKKGKDGD)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(BCBPENLMBBH));
		if (PlayerController.GetPlayer(1).trayHandler.tray.currentDrinks != null)
		{
			PlayerController.GetPlayer(1).trayHandler.tray.MKBDMMJCGGM();
		}
		PlayerController.TeleportPlayer(1, SceneReferences.GetSceneReferences().quarryCaveTp.position, Location.Quarry);
		if (GameManager.LocalCoop())
		{
			FadeCamera player2 = FadeCamera.GetPlayer(2);
			player2.OnFadeFinished = (Action<int>)Delegate.Remove(player2.OnFadeFinished, new Action<int>(BCBPENLMBBH));
			if (PlayerController.GetPlayer(2).trayHandler.tray.currentDrinks != null)
			{
				PlayerController.GetPlayer(2).trayHandler.tray.MKBDMMJCGGM();
			}
			PlayerController.TeleportPlayer(2, SceneReferences.GetSceneReferences().quarryCaveTp.position + new Vector3(1f, 0f, 0f), Location.Quarry);
		}
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = SceneReferences.GetSceneReferences().quarryCaveTp.position - new Vector3(1f, 0f, 0f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((MonoBehaviour)this).StartCoroutine(AGPMPNNAJPF());
	}

	private IEnumerator OONLAPJGKHM()
	{
		PGJBPJNFFJK = SceneManager.LoadSceneAsync("Quarry", (LoadSceneMode)1);
		while (!PGJBPJNFFJK.isDone)
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.animationBase.FCGBJEIIMBC = Direction.Up;
		PlayerController.GetPlayer(1).characterAnimation.FCGBJEIIMBC = Direction.Up;
		if (GameManager.LocalCoop())
		{
			PlayerController.GetPlayer(2).characterAnimation.FCGBJEIIMBC = Direction.Up;
		}
		yield return CommonReferences.wait05;
		FadeCamera.GetPlayer(1).FadeInWithDelay();
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeInWithDelay();
		}
		yield return CommonReferences.wait05;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T137/Dialogue2", 1, DHELBHAICMM: false, CGKNJONAKGD: false);
	}

	private void OAJHGJAGGAB(int ABAIKKGKDGD)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(1);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(LDCOKGOICNA));
		if (PlayerController.GetPlayer(1).trayHandler.tray.currentDrinks != null)
		{
			PlayerController.OPHDCMJLLEC(0).trayHandler.tray.OHAJMGCPGMK(0);
		}
		PlayerController.TeleportPlayer(1, SceneReferences.CFAMKBHIGLO().quarryCaveTp.position, Location.Tavern | Location.River | Location.Quarry);
		if (GameManager.LocalCoop())
		{
			FadeCamera fadeCamera2 = FadeCamera.IGMCBPOPNCA(3);
			fadeCamera2.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera2.OnFadeFinished, new Action<int>(LDCOKGOICNA));
			if (PlayerController.GetPlayer(8).trayHandler.tray.currentDrinks != null)
			{
				PlayerController.OPHDCMJLLEC(2).trayHandler.tray.MKBDMMJCGGM();
			}
			PlayerController.CLEIAKPOGMM(1, SceneReferences.CKDKHMPHENE().quarryCaveTp.position + new Vector3(783f, 617f, 1477f), Location.Road | Location.Camp | Location.Quarry | Location.BarnInterior);
		}
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = SceneReferences.CKDKHMPHENE().quarryCaveTp.position - new Vector3(1391f, 1929f, 547f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((MonoBehaviour)this).StartCoroutine(AHBHFNGMIMA());
	}

	private IEnumerator CPCGNMPLFHM()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		NewTutorialManager.instance.quarryBlock = false;
		yield return CommonReferences.wait05;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T137/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait05;
		QuarryCaveTp();
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
	}

	private void IJIPBCAJPED(int ABAIKKGKDGD)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(0);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(MHBKIAOJMPN));
		if (PlayerController.GetPlayer(1).trayHandler.tray.currentDrinks != null)
		{
			PlayerController.OPHDCMJLLEC(1).trayHandler.tray.MOFBGCELGFN(0, GFNHAMCPEAK: false);
		}
		PlayerController.TeleportPlayer(1, SceneReferences.FAOPFMBMMJJ().quarryCaveTp.position, ~(Location.Road | Location.River | Location.Camp | Location.Quarry | Location.Farm | Location.BarnInterior));
		if (GameManager.LocalCoop())
		{
			FadeCamera player = FadeCamera.GetPlayer(7);
			player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(FKDGEBDMAFE));
			if (PlayerController.OPHDCMJLLEC(4).trayHandler.tray.currentDrinks != null)
			{
				PlayerController.GetPlayer(3).trayHandler.tray.MKBDMMJCGGM();
			}
			PlayerController.CLEIAKPOGMM(0, SceneReferences.GetSceneReferences().quarryCaveTp.position + new Vector3(1988f, 419f, 530f), Location.Road | Location.River | Location.Quarry | Location.BarnInterior);
		}
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = SceneReferences.CFAMKBHIGLO().quarryCaveTp.position - new Vector3(743f, 1675f, 1619f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((MonoBehaviour)this).StartCoroutine(AGNICHFHJFH());
	}

	public void BLDPOGJAEPH()
	{
		FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(0);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Combine(fadeCamera.OnFadeFinished, new Action<int>(KCFDNLCLJIA));
		FadeCamera.IGMCBPOPNCA(0).IONMINJHMKL(1192f);
		if (GameManager.LocalCoop())
		{
			FadeCamera fadeCamera2 = FadeCamera.EIFPKCAFDIB(8);
			fadeCamera2.OnFadeFinished = (Action<int>)Delegate.Combine(fadeCamera2.OnFadeFinished, new Action<int>(MHBKIAOJMPN));
			FadeCamera.IGMCBPOPNCA(3).GPBOEBGJJPM(779f);
		}
	}

	public void LGHBAOJICNM()
	{
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(JLDPBKAEOJH());
	}

	private void CBBILJEAIHN(int ABAIKKGKDGD)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(0);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(PDEBAOBPBFP));
		if (PlayerController.OPHDCMJLLEC(1).trayHandler.tray.currentDrinks != null)
		{
			PlayerController.OPHDCMJLLEC(0).trayHandler.tray.LIHGILDLODK(1, GFNHAMCPEAK: false);
		}
		PlayerController.CLEIAKPOGMM(0, SceneReferences.FAOPFMBMMJJ().quarryCaveTp.position, ~(Location.Road | Location.River));
		if (GameManager.LocalCoop())
		{
			FadeCamera player = FadeCamera.GetPlayer(8);
			player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(MHBKIAOJMPN));
			if (PlayerController.OPHDCMJLLEC(3).trayHandler.tray.currentDrinks != null)
			{
				PlayerController.OPHDCMJLLEC(8).trayHandler.tray.MKBDMMJCGGM(0, GFNHAMCPEAK: false);
			}
			PlayerController.CLEIAKPOGMM(1, SceneReferences.CFAMKBHIGLO().quarryCaveTp.position + new Vector3(604f, 1407f, 170f), Location.Tavern | Location.Road | Location.Camp);
		}
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = SceneReferences.CFAMKBHIGLO().quarryCaveTp.position - new Vector3(801f, 1451f, 1324f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((MonoBehaviour)this).StartCoroutine(FHJPDDBHLJA());
	}

	private void CPOHEMLIGJO(int JIIGOACEIKL)
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernClose = (Action<int>)Delegate.Remove(instance.OnTavernClose, new Action<int>(AILHAJFDMBE));
		((MonoBehaviour)this).StartCoroutine(OKCLMKGLKAL());
	}

	public void CMIBKOIHKKH()
	{
		FadeCamera player = FadeCamera.GetPlayer(0);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(ENMPDHALAPD));
		FadeCamera.IGMCBPOPNCA(0).AJHDEBOMHKK(1610f);
		if (GameManager.LocalCoop())
		{
			FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(3);
			fadeCamera.OnFadeFinished = (Action<int>)Delegate.Combine(fadeCamera.OnFadeFinished, new Action<int>(NOJAHMNFFLF));
			FadeCamera.GetPlayer(4).IONMINJHMKL(1041f);
		}
	}

	private void LONGNFKBGKE(int ABAIKKGKDGD)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(1);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(DPNNGDHOHHF));
		if (PlayerController.GetPlayer(1).trayHandler.tray.currentDrinks != null)
		{
			PlayerController.GetPlayer(0).trayHandler.tray.LIHGILDLODK(0);
		}
		PlayerController.TeleportPlayer(0, SceneReferences.CKDKHMPHENE().quarryCaveTp.position, Location.Quarry | Location.BarnInterior);
		if (GameManager.LocalCoop())
		{
			FadeCamera fadeCamera2 = FadeCamera.EIFPKCAFDIB(1);
			fadeCamera2.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera2.OnFadeFinished, new Action<int>(NEHKIEABLBB));
			if (PlayerController.GetPlayer(0).trayHandler.tray.currentDrinks != null)
			{
				PlayerController.OPHDCMJLLEC(2).trayHandler.tray.LMBGCNCJBMA();
			}
			PlayerController.TeleportPlayer(2, SceneReferences.GetSceneReferences().quarryCaveTp.position + new Vector3(1318f, 1177f, 566f), ~(Location.Tavern | Location.Road | Location.Camp | Location.Quarry | Location.BarnInterior));
		}
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = SceneReferences.CKDKHMPHENE().quarryCaveTp.position - new Vector3(1176f, 746f, 1336f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((MonoBehaviour)this).StartCoroutine(HKMGJAEKIKL());
	}

	private IEnumerator DIEKACDHABN()
	{
		PGJBPJNFFJK = SceneManager.LoadSceneAsync("Quarry", (LoadSceneMode)1);
		while (!PGJBPJNFFJK.isDone)
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.animationBase.FCGBJEIIMBC = Direction.Up;
		PlayerController.GetPlayer(1).characterAnimation.FCGBJEIIMBC = Direction.Up;
		if (GameManager.LocalCoop())
		{
			PlayerController.GetPlayer(2).characterAnimation.FCGBJEIIMBC = Direction.Up;
		}
		yield return CommonReferences.wait05;
		FadeCamera.GetPlayer(1).FadeInWithDelay();
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeInWithDelay();
		}
		yield return CommonReferences.wait05;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T137/Dialogue2", 1, DHELBHAICMM: false, CGKNJONAKGD: false);
	}

	private IEnumerator BLJIIHBNHAA()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		NewTutorialManager.instance.quarryBlock = false;
		yield return CommonReferences.wait05;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T137/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait05;
		QuarryCaveTp();
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
	}

	private IEnumerator FHCNAFEMIGK()
	{
		return new ANHGEEIMBNP(1)
		{
			_003C_003E4__this = this
		};
	}

	public void NFKGKGGFNMM()
	{
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(1);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Combine(fadeCamera.OnFadeFinished, new Action<int>(FKDGEBDMAFE));
		FadeCamera.EIFPKCAFDIB(1).FadeOut(996f);
		if (GameManager.LocalCoop())
		{
			FadeCamera fadeCamera2 = FadeCamera.IGMCBPOPNCA(6);
			fadeCamera2.OnFadeFinished = (Action<int>)Delegate.Combine(fadeCamera2.OnFadeFinished, new Action<int>(JOENNIJFEEL));
			FadeCamera.EIFPKCAFDIB(2).IONMINJHMKL(330f);
		}
	}

	private IEnumerator LKAGLINOIMK()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		NewTutorialManager.instance.quarryBlock = false;
		yield return CommonReferences.wait05;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T137/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait05;
		QuarryCaveTp();
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
	}

	private IEnumerator KJDKCMAANLO()
	{
		PGJBPJNFFJK = SceneManager.LoadSceneAsync("Quarry", (LoadSceneMode)1);
		while (!PGJBPJNFFJK.isDone)
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.animationBase.FCGBJEIIMBC = Direction.Up;
		PlayerController.GetPlayer(1).characterAnimation.FCGBJEIIMBC = Direction.Up;
		if (GameManager.LocalCoop())
		{
			PlayerController.GetPlayer(2).characterAnimation.FCGBJEIIMBC = Direction.Up;
		}
		yield return CommonReferences.wait05;
		FadeCamera.GetPlayer(1).FadeInWithDelay();
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeInWithDelay();
		}
		yield return CommonReferences.wait05;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T137/Dialogue2", 1, DHELBHAICMM: false, CGKNJONAKGD: false);
	}

	private IEnumerator BPJDNGACNCI()
	{
		return new ANHGEEIMBNP(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NCHPMDFONEL()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		NewTutorialManager.instance.quarryBlock = false;
		yield return CommonReferences.wait05;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T137/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait05;
		QuarryCaveTp();
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
	}

	public void ILMDCFEFGEP()
	{
		NewTutorialManager.GJIDCOKLGCF(APGEBAEHLMM: false);
		NewTutorialManager.instance.ObjectiveCompleted(1, BLJPGJKOLNF: false);
		((MonoBehaviour)this).StartCoroutine(OFOLEPNOONG());
	}

	private IEnumerator BJPDFDCOJKJ()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator FLECFIDDCJE()
	{
		return new BMLJHCLHBND(1)
		{
			_003C_003E4__this = this
		};
	}

	public void ECOGBMAEKMN()
	{
		FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(1);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Combine(fadeCamera.OnFadeFinished, new Action<int>(MEDBBAMHIPB));
		FadeCamera.IGMCBPOPNCA(1).IONMINJHMKL(1467f);
		if (GameManager.LocalCoop())
		{
			FadeCamera player = FadeCamera.GetPlayer(2);
			player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(PBHGJIJHOAB));
			FadeCamera.GetPlayer(0).IONMINJHMKL(585f);
		}
	}

	private void MAOPADFGKHO(int ABAIKKGKDGD)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(1);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(FDFHKGHDIOE));
		if (PlayerController.OPHDCMJLLEC(1).trayHandler.tray.currentDrinks != null)
		{
			PlayerController.GetPlayer(1).trayHandler.tray.OHAJMGCPGMK(0, GFNHAMCPEAK: false);
		}
		PlayerController.TeleportPlayer(0, SceneReferences.CFAMKBHIGLO().quarryCaveTp.position, ~(Location.Tavern | Location.Quarry | Location.Farm));
		if (GameManager.LocalCoop())
		{
			FadeCamera fadeCamera2 = FadeCamera.EIFPKCAFDIB(8);
			fadeCamera2.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera2.OnFadeFinished, new Action<int>(LIKBNNPFFEF));
			if (PlayerController.OPHDCMJLLEC(5).trayHandler.tray.currentDrinks != null)
			{
				PlayerController.OPHDCMJLLEC(3).trayHandler.tray.LDPHJNIPDJA();
			}
			PlayerController.TeleportPlayer(8, SceneReferences.CFAMKBHIGLO().quarryCaveTp.position + new Vector3(517f, 1321f, 1508f), Location.Quarry | Location.Farm);
		}
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = SceneReferences.FAOPFMBMMJJ().quarryCaveTp.position - new Vector3(373f, 1508f, 479f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((MonoBehaviour)this).StartCoroutine(MMGOPABAICK());
	}

	private void MEDBBAMHIPB(int ABAIKKGKDGD)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(1);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(LIKBNNPFFEF));
		if (PlayerController.GetPlayer(0).trayHandler.tray.currentDrinks != null)
		{
			PlayerController.GetPlayer(1).trayHandler.tray.ACDHANDNCNC(0, GFNHAMCPEAK: false);
		}
		PlayerController.CLEIAKPOGMM(0, SceneReferences.GetSceneReferences().quarryCaveTp.position, ~(Location.Road | Location.River | Location.Camp | Location.Quarry | Location.Farm));
		if (GameManager.LocalCoop())
		{
			FadeCamera fadeCamera2 = FadeCamera.IGMCBPOPNCA(3);
			fadeCamera2.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera2.OnFadeFinished, new Action<int>(NOBJHEDOJAE));
			if (PlayerController.OPHDCMJLLEC(0).trayHandler.tray.currentDrinks != null)
			{
				PlayerController.GetPlayer(1).trayHandler.tray.LIHGILDLODK(0);
			}
			PlayerController.CLEIAKPOGMM(1, SceneReferences.FAOPFMBMMJJ().quarryCaveTp.position + new Vector3(1501f, 87f, 615f), Location.Tavern | Location.Road | Location.Farm | Location.BarnInterior);
		}
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = SceneReferences.FAOPFMBMMJJ().quarryCaveTp.position - new Vector3(379f, 1455f, 80f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((MonoBehaviour)this).StartCoroutine(NLBMDPLFEGO());
	}

	private IEnumerator OGOFBONBDBP()
	{
		return new HFGHJKEHEKJ(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator OKCLMKGLKAL()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		NewTutorialManager.instance.quarryBlock = false;
		yield return CommonReferences.wait05;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T137/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait05;
		QuarryCaveTp();
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
	}

	private void KEIJJLNFKAL(int JIIGOACEIKL)
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernClose = (Action<int>)Delegate.Remove(instance.OnTavernClose, new Action<int>(CPOHEMLIGJO));
		((MonoBehaviour)this).StartCoroutine(PCCAMOFKPLK());
	}

	private void BKHJAAKIDKL(int JIIGOACEIKL)
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernClose = (Action<int>)Delegate.Remove(instance.OnTavernClose, new Action<int>(NCMICHCNCFO));
		((MonoBehaviour)this).StartCoroutine(DIGIMPCLCCL());
	}

	private void KCFDNLCLJIA(int ABAIKKGKDGD)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(1);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(LIKBNNPFFEF));
		if (PlayerController.GetPlayer(0).trayHandler.tray.currentDrinks != null)
		{
			PlayerController.GetPlayer(1).trayHandler.tray.IOCOONMEGLI();
		}
		PlayerController.TeleportPlayer(0, SceneReferences.CKDKHMPHENE().quarryCaveTp.position, Location.Tavern | Location.Camp);
		if (GameManager.LocalCoop())
		{
			FadeCamera player = FadeCamera.GetPlayer(0);
			player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(NEBBCABEMJB));
			if (PlayerController.GetPlayer(6).trayHandler.tray.currentDrinks != null)
			{
				PlayerController.OPHDCMJLLEC(7).trayHandler.tray.MKBDMMJCGGM();
			}
			PlayerController.TeleportPlayer(5, SceneReferences.CKDKHMPHENE().quarryCaveTp.position + new Vector3(1295f, 1672f, 1213f), ~(Location.Road | Location.River | Location.Camp | Location.Quarry | Location.Farm | Location.BarnInterior));
		}
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = SceneReferences.CFAMKBHIGLO().quarryCaveTp.position - new Vector3(1633f, 1091f, 794f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((MonoBehaviour)this).StartCoroutine(AHBHFNGMIMA());
	}

	private IEnumerator PBEKBJIJFDK()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		NewTutorialManager.instance.quarryBlock = false;
		yield return CommonReferences.wait05;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T137/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait05;
		QuarryCaveTp();
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
	}

	private void NEBBCABEMJB(int ABAIKKGKDGD)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(0);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(NOBJHEDOJAE));
		if (PlayerController.OPHDCMJLLEC(0).trayHandler.tray.currentDrinks != null)
		{
			PlayerController.OPHDCMJLLEC(1).trayHandler.tray.LDPHJNIPDJA(1, GFNHAMCPEAK: false);
		}
		PlayerController.CLEIAKPOGMM(0, SceneReferences.CFAMKBHIGLO().quarryCaveTp.position, ~Location.Road);
		if (GameManager.LocalCoop())
		{
			FadeCamera fadeCamera2 = FadeCamera.EIFPKCAFDIB(7);
			fadeCamera2.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera2.OnFadeFinished, new Action<int>(NEHKIEABLBB));
			if (PlayerController.OPHDCMJLLEC(0).trayHandler.tray.currentDrinks != null)
			{
				PlayerController.OPHDCMJLLEC(7).trayHandler.tray.IOCOONMEGLI(0);
			}
			PlayerController.CLEIAKPOGMM(6, SceneReferences.CFAMKBHIGLO().quarryCaveTp.position + new Vector3(997f, 650f, 513f), Location.Quarry | Location.BarnInterior);
		}
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = SceneReferences.CFAMKBHIGLO().quarryCaveTp.position - new Vector3(428f, 1713f, 882f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((MonoBehaviour)this).StartCoroutine(DDPLLOBIADE());
	}

	private IEnumerator OCCLCKFAILK()
	{
		return new BMLJHCLHBND(1)
		{
			_003C_003E4__this = this
		};
	}

	private void LOGAAGEKGOK(int JIIGOACEIKL)
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernClose = (Action<int>)Delegate.Remove(instance.OnTavernClose, new Action<int>(LOGAAGEKGOK));
		((MonoBehaviour)this).StartCoroutine(PBEKBJIJFDK());
	}

	public void DPBLNLIKOIM()
	{
		FadeCamera player = FadeCamera.GetPlayer(0);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(ENMPDHALAPD));
		FadeCamera.EIFPKCAFDIB(1).FadeOut(1777f);
		if (GameManager.LocalCoop())
		{
			FadeCamera player2 = FadeCamera.GetPlayer(1);
			player2.OnFadeFinished = (Action<int>)Delegate.Combine(player2.OnFadeFinished, new Action<int>(NOJAHMNFFLF));
			FadeCamera.EIFPKCAFDIB(8).AJHDEBOMHKK(933f);
		}
	}

	public void NJIGICOLMAO()
	{
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.FOIOHOGACAL(0);
		((MonoBehaviour)this).StartCoroutine(EFKIBEABCPK());
	}

	public void GBJFEJJCDIK()
	{
		FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(0);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Combine(fadeCamera.OnFadeFinished, new Action<int>(NOJAHMNFFLF));
		FadeCamera.GetPlayer(1).IONMINJHMKL(1371f);
		if (GameManager.LocalCoop())
		{
			FadeCamera player = FadeCamera.GetPlayer(4);
			player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(MHBKIAOJMPN));
			FadeCamera.IGMCBPOPNCA(7).GPBOEBGJJPM(336f);
		}
	}

	private void LNKHGKGCAOL(int JIIGOACEIKL)
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernClose = (Action<int>)Delegate.Remove(instance.OnTavernClose, new Action<int>(DFCNIAADEBM));
		((MonoBehaviour)this).StartCoroutine(BPJDNGACNCI());
	}

	private IEnumerator MFFGIOALMIC()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		NewTutorialManager.instance.quarryBlock = false;
		yield return CommonReferences.wait05;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T137/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait05;
		QuarryCaveTp();
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
	}

	private IEnumerator MEGKLKNBNEL()
	{
		return new ANHGEEIMBNP(1)
		{
			_003C_003E4__this = this
		};
	}

	private void DPNNGDHOHHF(int ABAIKKGKDGD)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(1);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(JOENNIJFEEL));
		if (PlayerController.OPHDCMJLLEC(1).trayHandler.tray.currentDrinks != null)
		{
			PlayerController.OPHDCMJLLEC(0).trayHandler.tray.ACDHANDNCNC();
		}
		PlayerController.CLEIAKPOGMM(0, SceneReferences.GetSceneReferences().quarryCaveTp.position, Location.Tavern | Location.Road | Location.River | Location.Camp | Location.Quarry);
		if (GameManager.LocalCoop())
		{
			FadeCamera fadeCamera2 = FadeCamera.IGMCBPOPNCA(2);
			fadeCamera2.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera2.OnFadeFinished, new Action<int>(FKDGEBDMAFE));
			if (PlayerController.OPHDCMJLLEC(6).trayHandler.tray.currentDrinks != null)
			{
				PlayerController.GetPlayer(5).trayHandler.tray.MKBDMMJCGGM(0);
			}
			PlayerController.CLEIAKPOGMM(6, SceneReferences.CFAMKBHIGLO().quarryCaveTp.position + new Vector3(1429f, 856f, 7f), Location.Tavern | Location.Road | Location.Camp | Location.Quarry | Location.Farm);
		}
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = SceneReferences.CKDKHMPHENE().quarryCaveTp.position - new Vector3(1043f, 1691f, 1676f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((MonoBehaviour)this).StartCoroutine(FHJPDDBHLJA());
	}

	public void PJIECGAMMAP()
	{
		NewTutorialManager.GJIDCOKLGCF(APGEBAEHLMM: true);
		NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
		((MonoBehaviour)this).StartCoroutine(MOGINLPNGOG());
	}

	public void GPOENCCKMGD()
	{
		NewTutorialManager.GJIDCOKLGCF(APGEBAEHLMM: true);
		NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
		((MonoBehaviour)this).StartCoroutine(JBDHOFJEMEO());
	}

	private IEnumerator IHGGOFFGMBD()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator LHDDHIJIFCN()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private void HOLECPOFCHH(int JIIGOACEIKL)
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernClose = (Action<int>)Delegate.Remove(instance.OnTavernClose, new Action<int>(EBAKHHLJMGE));
		((MonoBehaviour)this).StartCoroutine(OPMGLCANKPH());
	}

	private IEnumerator LPCPNKEMCNM()
	{
		return new BMLJHCLHBND(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator ONEHLMDPDPM()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		NewTutorialManager.instance.quarryBlock = false;
		yield return CommonReferences.wait05;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T137/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait05;
		QuarryCaveTp();
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
	}

	private void FKDGEBDMAFE(int ABAIKKGKDGD)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera player = FadeCamera.GetPlayer(0);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(AEJCFLLAGFI));
		if (PlayerController.GetPlayer(0).trayHandler.tray.currentDrinks != null)
		{
			PlayerController.GetPlayer(1).trayHandler.tray.LDPHJNIPDJA(0, GFNHAMCPEAK: false);
		}
		PlayerController.CLEIAKPOGMM(1, SceneReferences.GetSceneReferences().quarryCaveTp.position, Location.Farm);
		if (GameManager.LocalCoop())
		{
			FadeCamera player2 = FadeCamera.GetPlayer(2);
			player2.OnFadeFinished = (Action<int>)Delegate.Remove(player2.OnFadeFinished, new Action<int>(GPFHEEJIACF));
			if (PlayerController.GetPlayer(0).trayHandler.tray.currentDrinks != null)
			{
				PlayerController.OPHDCMJLLEC(6).trayHandler.tray.IOCOONMEGLI();
			}
			PlayerController.TeleportPlayer(4, SceneReferences.GetSceneReferences().quarryCaveTp.position + new Vector3(1086f, 251f, 1306f), Location.River | Location.BarnInterior);
		}
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = SceneReferences.GetSceneReferences().quarryCaveTp.position - new Vector3(1131f, 66f, 21f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((MonoBehaviour)this).StartCoroutine(HKMGJAEKIKL());
	}

	private IEnumerator JIFEIKLKIMF()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		NewTutorialManager.instance.quarryBlock = false;
		yield return CommonReferences.wait05;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T137/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait05;
		QuarryCaveTp();
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
	}

	private void MHBKIAOJMPN(int ABAIKKGKDGD)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(1);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(FDFHKGHDIOE));
		if (PlayerController.OPHDCMJLLEC(0).trayHandler.tray.currentDrinks != null)
		{
			PlayerController.OPHDCMJLLEC(0).trayHandler.tray.NBODABCGELG(0);
		}
		PlayerController.TeleportPlayer(0, SceneReferences.CFAMKBHIGLO().quarryCaveTp.position, ~(Location.River | Location.Quarry | Location.Farm | Location.BarnInterior));
		if (GameManager.LocalCoop())
		{
			FadeCamera fadeCamera2 = FadeCamera.IGMCBPOPNCA(6);
			fadeCamera2.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera2.OnFadeFinished, new Action<int>(LIKBNNPFFEF));
			if (PlayerController.OPHDCMJLLEC(5).trayHandler.tray.currentDrinks != null)
			{
				PlayerController.OPHDCMJLLEC(8).trayHandler.tray.MOFBGCELGFN();
			}
			PlayerController.CLEIAKPOGMM(4, SceneReferences.GetSceneReferences().quarryCaveTp.position + new Vector3(211f, 409f, 316f), Location.Camp | Location.Quarry | Location.BarnInterior);
		}
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = SceneReferences.CKDKHMPHENE().quarryCaveTp.position - new Vector3(1236f, 766f, 660f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((MonoBehaviour)this).StartCoroutine(AGPMPNNAJPF());
	}

	public void DHCBEOAOMLM()
	{
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private void FDFHKGHDIOE(int ABAIKKGKDGD)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(1);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(JOENNIJFEEL));
		if (PlayerController.OPHDCMJLLEC(1).trayHandler.tray.currentDrinks != null)
		{
			PlayerController.OPHDCMJLLEC(1).trayHandler.tray.LIHGILDLODK(0);
		}
		PlayerController.TeleportPlayer(0, SceneReferences.FAOPFMBMMJJ().quarryCaveTp.position, Location.Tavern | Location.River | Location.BarnInterior);
		if (GameManager.LocalCoop())
		{
			FadeCamera player = FadeCamera.GetPlayer(2);
			player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(CPMCGCLAKKO));
			if (PlayerController.OPHDCMJLLEC(4).trayHandler.tray.currentDrinks != null)
			{
				PlayerController.OPHDCMJLLEC(6).trayHandler.tray.MKBDMMJCGGM(1, GFNHAMCPEAK: false);
			}
			PlayerController.CLEIAKPOGMM(5, SceneReferences.FAOPFMBMMJJ().quarryCaveTp.position + new Vector3(604f, 1577f, 708f), Location.Tavern | Location.River | Location.Quarry | Location.BarnInterior);
		}
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = SceneReferences.CFAMKBHIGLO().quarryCaveTp.position - new Vector3(1633f, 456f, 332f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((MonoBehaviour)this).StartCoroutine(DOEHBKLDFKD());
	}

	private IEnumerator CNPIAJBODCG()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		NewTutorialManager.instance.quarryBlock = false;
		yield return CommonReferences.wait05;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T137/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait05;
		QuarryCaveTp();
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
	}

	private IEnumerator HKMGJAEKIKL()
	{
		return new HFGHJKEHEKJ(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator FHJPDDBHLJA()
	{
		return new HFGHJKEHEKJ(1)
		{
			_003C_003E4__this = this
		};
	}

	public void LBLLLLFAJLD()
	{
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
		((MonoBehaviour)this).StartCoroutine(BJPDFDCOJKJ());
	}

	private IEnumerator MOINDGPKJDH()
	{
		PGJBPJNFFJK = SceneManager.LoadSceneAsync("Quarry", (LoadSceneMode)1);
		while (!PGJBPJNFFJK.isDone)
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.animationBase.FCGBJEIIMBC = Direction.Up;
		PlayerController.GetPlayer(1).characterAnimation.FCGBJEIIMBC = Direction.Up;
		if (GameManager.LocalCoop())
		{
			PlayerController.GetPlayer(2).characterAnimation.FCGBJEIIMBC = Direction.Up;
		}
		yield return CommonReferences.wait05;
		FadeCamera.GetPlayer(1).FadeInWithDelay();
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeInWithDelay();
		}
		yield return CommonReferences.wait05;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T137/Dialogue2", 1, DHELBHAICMM: false, CGKNJONAKGD: false);
	}

	private IEnumerator OGOFIFJCMEB()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		NewTutorialManager.instance.quarryBlock = false;
		yield return CommonReferences.wait05;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T137/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait05;
		QuarryCaveTp();
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
	}

	private IEnumerator GDPBIJBENCI()
	{
		PGJBPJNFFJK = SceneManager.LoadSceneAsync("Quarry", (LoadSceneMode)1);
		while (!PGJBPJNFFJK.isDone)
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.animationBase.FCGBJEIIMBC = Direction.Up;
		PlayerController.GetPlayer(1).characterAnimation.FCGBJEIIMBC = Direction.Up;
		if (GameManager.LocalCoop())
		{
			PlayerController.GetPlayer(2).characterAnimation.FCGBJEIIMBC = Direction.Up;
		}
		yield return CommonReferences.wait05;
		FadeCamera.GetPlayer(1).FadeInWithDelay();
		if (GameManager.LocalCoop())
		{
			FadeCamera.GetPlayer(2).FadeInWithDelay();
		}
		yield return CommonReferences.wait05;
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T137/Dialogue2", 1, DHELBHAICMM: false, CGKNJONAKGD: false);
	}

	private IEnumerator OOBEJHHFIAN()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	public void ELMELHHDHHN()
	{
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		NewTutorialManager.instance.ObjectiveCompleted(0, BLJPGJKOLNF: false);
		((MonoBehaviour)this).StartCoroutine(EFKIBEABCPK());
	}

	private void DBKLBDHNGHL(int ABAIKKGKDGD)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(1);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(PDEBAOBPBFP));
		if (PlayerController.GetPlayer(1).trayHandler.tray.currentDrinks != null)
		{
			PlayerController.GetPlayer(1).trayHandler.tray.LMBGCNCJBMA(1, GFNHAMCPEAK: false);
		}
		PlayerController.CLEIAKPOGMM(1, SceneReferences.CKDKHMPHENE().quarryCaveTp.position, Location.Tavern | Location.Farm | Location.BarnInterior);
		if (GameManager.LocalCoop())
		{
			FadeCamera fadeCamera2 = FadeCamera.IGMCBPOPNCA(3);
			fadeCamera2.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera2.OnFadeFinished, new Action<int>(NEHKIEABLBB));
			if (PlayerController.OPHDCMJLLEC(4).trayHandler.tray.currentDrinks != null)
			{
				PlayerController.GetPlayer(6).trayHandler.tray.IOCOONMEGLI();
			}
			PlayerController.CLEIAKPOGMM(8, SceneReferences.FAOPFMBMMJJ().quarryCaveTp.position + new Vector3(1662f, 1664f, 1333f), ~(Location.River | Location.Camp | Location.Quarry));
		}
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = SceneReferences.GetSceneReferences().quarryCaveTp.position - new Vector3(1033f, 1568f, 580f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((MonoBehaviour)this).StartCoroutine(JJGPNGAEGCP());
	}

	public void QuarryCaveTp()
	{
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(BCBPENLMBBH));
		FadeCamera.GetPlayer(1).FadeOut();
		if (GameManager.LocalCoop())
		{
			FadeCamera player2 = FadeCamera.GetPlayer(2);
			player2.OnFadeFinished = (Action<int>)Delegate.Combine(player2.OnFadeFinished, new Action<int>(BCBPENLMBBH));
			FadeCamera.GetPlayer(2).FadeOut();
		}
	}

	private void EBAKHHLJMGE(int JIIGOACEIKL)
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernClose = (Action<int>)Delegate.Remove(instance.OnTavernClose, new Action<int>(NCMICHCNCFO));
		((MonoBehaviour)this).StartCoroutine(GDCMANLMBDB());
	}

	private IEnumerator LADAGADIGPP()
	{
		return new HFGHJKEHEKJ(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator DIGIMPCLCCL()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		NewTutorialManager.instance.quarryBlock = false;
		yield return CommonReferences.wait05;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T137/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait05;
		QuarryCaveTp();
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
	}

	public void ENGGBOENKKO()
	{
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
		NewTutorialManager.instance.FOIOHOGACAL(0);
		((MonoBehaviour)this).StartCoroutine(OOBEJHHFIAN());
	}

	private IEnumerator JAHNJFGKFII()
	{
		return new ANHGEEIMBNP(1)
		{
			_003C_003E4__this = this
		};
	}

	public void FireStart()
	{
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		NewTutorialManager.instance.ObjectiveCompleted(0);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private IEnumerator IBPKNIECGII()
	{
		return new HFGHJKEHEKJ(1)
		{
			_003C_003E4__this = this
		};
	}

	private void GPFHEEJIACF(int ABAIKKGKDGD)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(0);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(IJIPBCAJPED));
		if (PlayerController.OPHDCMJLLEC(1).trayHandler.tray.currentDrinks != null)
		{
			PlayerController.OPHDCMJLLEC(0).trayHandler.tray.LDPHJNIPDJA();
		}
		PlayerController.CLEIAKPOGMM(1, SceneReferences.CKDKHMPHENE().quarryCaveTp.position, ~(Location.River | Location.Quarry | Location.Farm));
		if (GameManager.LocalCoop())
		{
			FadeCamera player = FadeCamera.GetPlayer(5);
			player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(KFCLPBKABHD));
			if (PlayerController.OPHDCMJLLEC(7).trayHandler.tray.currentDrinks != null)
			{
				PlayerController.OPHDCMJLLEC(0).trayHandler.tray.MOFBGCELGFN(0, GFNHAMCPEAK: false);
			}
			PlayerController.CLEIAKPOGMM(2, SceneReferences.CFAMKBHIGLO().quarryCaveTp.position + new Vector3(402f, 579f, 840f), ~(Location.River | Location.Camp));
		}
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = SceneReferences.CKDKHMPHENE().quarryCaveTp.position - new Vector3(116f, 1085f, 1005f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((MonoBehaviour)this).StartCoroutine(DDPLLOBIADE());
	}

	public void AKLIBLOJJMF()
	{
		NewTutorialManager.GJIDCOKLGCF(APGEBAEHLMM: true);
		NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
		((MonoBehaviour)this).StartCoroutine(LHDDHIJIFCN());
	}

	private void LIKBNNPFFEF(int ABAIKKGKDGD)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(0);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(KCFDNLCLJIA));
		if (PlayerController.GetPlayer(1).trayHandler.tray.currentDrinks != null)
		{
			PlayerController.GetPlayer(1).trayHandler.tray.LDPHJNIPDJA();
		}
		PlayerController.TeleportPlayer(0, SceneReferences.CKDKHMPHENE().quarryCaveTp.position, ~(Location.Road | Location.Quarry));
		if (GameManager.LocalCoop())
		{
			FadeCamera player = FadeCamera.GetPlayer(3);
			player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(LDCOKGOICNA));
			if (PlayerController.GetPlayer(8).trayHandler.tray.currentDrinks != null)
			{
				PlayerController.OPHDCMJLLEC(6).trayHandler.tray.OHAJMGCPGMK(0);
			}
			PlayerController.TeleportPlayer(4, SceneReferences.GetSceneReferences().quarryCaveTp.position + new Vector3(823f, 1339f, 671f), Location.River | Location.Camp | Location.Farm);
		}
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = SceneReferences.CKDKHMPHENE().quarryCaveTp.position - new Vector3(1788f, 1009f, 767f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((MonoBehaviour)this).StartCoroutine(AHBHFNGMIMA());
	}

	private IEnumerator PIINNENCNGJ()
	{
		return new HFGHJKEHEKJ(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator DOFPPAOIOEP()
	{
		return new HFGHJKEHEKJ(1)
		{
			_003C_003E4__this = this
		};
	}

	private void CPMCGCLAKKO(int ABAIKKGKDGD)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(LDCOKGOICNA));
		if (PlayerController.OPHDCMJLLEC(1).trayHandler.tray.currentDrinks != null)
		{
			PlayerController.OPHDCMJLLEC(0).trayHandler.tray.OHAJMGCPGMK(1, GFNHAMCPEAK: false);
		}
		PlayerController.CLEIAKPOGMM(0, SceneReferences.CKDKHMPHENE().quarryCaveTp.position, ~(Location.Road | Location.Quarry | Location.Farm | Location.BarnInterior));
		if (GameManager.LocalCoop())
		{
			FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(1);
			fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(GPFHEEJIACF));
			if (PlayerController.OPHDCMJLLEC(3).trayHandler.tray.currentDrinks != null)
			{
				PlayerController.OPHDCMJLLEC(7).trayHandler.tray.MOFBGCELGFN(0, GFNHAMCPEAK: false);
			}
			PlayerController.CLEIAKPOGMM(2, SceneReferences.CFAMKBHIGLO().quarryCaveTp.position + new Vector3(702f, 1663f, 985f), Location.River | Location.Farm);
		}
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = SceneReferences.CKDKHMPHENE().quarryCaveTp.position - new Vector3(1500f, 1796f, 164f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((MonoBehaviour)this).StartCoroutine(AHBHFNGMIMA());
	}

	private IEnumerator EOCBHNPFJLL()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		NewTutorialManager.instance.quarryBlock = false;
		yield return CommonReferences.wait05;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T137/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait05;
		QuarryCaveTp();
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
	}

	private void NOBJHEDOJAE(int ABAIKKGKDGD)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(0);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(LIKBNNPFFEF));
		if (PlayerController.GetPlayer(1).trayHandler.tray.currentDrinks != null)
		{
			PlayerController.GetPlayer(0).trayHandler.tray.FIJLPLJMJFA(1, GFNHAMCPEAK: false);
		}
		PlayerController.TeleportPlayer(0, SceneReferences.CFAMKBHIGLO().quarryCaveTp.position, ~(Location.Camp | Location.BarnInterior));
		if (GameManager.LocalCoop())
		{
			FadeCamera fadeCamera2 = FadeCamera.IGMCBPOPNCA(7);
			fadeCamera2.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera2.OnFadeFinished, new Action<int>(KFCLPBKABHD));
			if (PlayerController.OPHDCMJLLEC(5).trayHandler.tray.currentDrinks != null)
			{
				PlayerController.GetPlayer(2).trayHandler.tray.MOFBGCELGFN(0, GFNHAMCPEAK: false);
			}
			PlayerController.CLEIAKPOGMM(0, SceneReferences.CFAMKBHIGLO().quarryCaveTp.position + new Vector3(1424f, 1678f, 1842f), ~(Location.Tavern | Location.Road | Location.River | Location.Camp | Location.Farm | Location.BarnInterior));
		}
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = SceneReferences.GetSceneReferences().quarryCaveTp.position - new Vector3(203f, 1988f, 3f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((MonoBehaviour)this).StartCoroutine(PIINNENCNGJ());
	}

	private IEnumerator AHBFKJJMKPA()
	{
		return new HFGHJKEHEKJ(1)
		{
			_003C_003E4__this = this
		};
	}

	public void HIIFPJLHCJE()
	{
		NewTutorialManager.GJIDCOKLGCF(APGEBAEHLMM: true);
		NewTutorialManager.instance.FOIOHOGACAL(0, BLJPGJKOLNF: false);
		((MonoBehaviour)this).StartCoroutine(BJPDFDCOJKJ());
	}

	private IEnumerator HEAFCDJINCN()
	{
		return new ANHGEEIMBNP(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HGFPMNKEMAC()
	{
		return new BMLJHCLHBND(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JAMDPHHGCDP()
	{
		return new ANHGEEIMBNP(1)
		{
			_003C_003E4__this = this
		};
	}

	private void EBOCMGLNMJL(int JIIGOACEIKL)
	{
		TavernManager instance = TavernManager.GGFJGHHHEJC;
		instance.OnTavernClose = (Action<int>)Delegate.Remove(instance.OnTavernClose, new Action<int>(HFFOMAOHHKM));
		((MonoBehaviour)this).StartCoroutine(LOPECFGACHD());
	}

	private IEnumerator COMPHHHBLIO()
	{
		yield return CommonReferences.wait2;
		LHKIJABBBPM();
	}

	private IEnumerator LOJHHOBFFEB()
	{
		return new HFGHJKEHEKJ(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator BLNKHNHGFPB()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		NewTutorialManager.instance.quarryBlock = false;
		yield return CommonReferences.wait05;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T137/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait05;
		QuarryCaveTp();
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
	}

	public void NOBBLFJCBEL()
	{
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(GDIFNJEKLGC));
		FadeCamera.EIFPKCAFDIB(1).GPBOEBGJJPM(516f);
		if (GameManager.LocalCoop())
		{
			FadeCamera player2 = FadeCamera.GetPlayer(8);
			player2.OnFadeFinished = (Action<int>)Delegate.Combine(player2.OnFadeFinished, new Action<int>(FDFHKGHDIOE));
			FadeCamera.GetPlayer(2).GPBOEBGJJPM(1689f);
		}
	}

	public void HDOIBGAJDOD()
	{
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(1);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Combine(fadeCamera.OnFadeFinished, new Action<int>(MEDBBAMHIPB));
		FadeCamera.EIFPKCAFDIB(1).IONMINJHMKL(1772f);
		if (GameManager.LocalCoop())
		{
			FadeCamera fadeCamera2 = FadeCamera.EIFPKCAFDIB(8);
			fadeCamera2.OnFadeFinished = (Action<int>)Delegate.Combine(fadeCamera2.OnFadeFinished, new Action<int>(MAOPADFGKHO));
			FadeCamera.GetPlayer(2).IONMINJHMKL(1241f);
		}
	}

	private IEnumerator FAPDHBILIID()
	{
		CommonReferences.GGFJGHHHEJC.worldJustLoadedForTutorial = false;
		yield return CommonReferences.wait02;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.GGFJGHHHEJC.SetBoolTrue("Disabled");
		while (!AOOKIKFINFB())
		{
			yield return null;
		}
		yield return CommonReferences.wait2;
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: true);
		MaiNPC.GGFJGHHHEJC.SetBoolFalse("Disabled");
		NewTutorialManager.instance.quarryBlock = false;
		yield return CommonReferences.wait05;
		DialogueCameraTarget.GetPlayer(triggerPlayerNum).AssignDialogueActor(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		MaiNPC.GGFJGHHHEJC.StartTutorialDialogue("Tutorial/T137/Dialogue1", triggerPlayerNum);
		while (AAOPIEDAKKD(1))
		{
			yield return null;
		}
		yield return CommonReferences.wait05;
		QuarryCaveTp();
		while (AAOPIEDAKKD(2))
		{
			yield return null;
		}
		NewTutorialManager.instance.UpdateObjectives(COGCFDJBDOF: true);
		NewTutorialManager.BlockPlayer(APGEBAEHLMM: false);
	}

	public void MPIICILMHKD()
	{
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(0);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Combine(fadeCamera.OnFadeFinished, new Action<int>(DBKLBDHNGHL));
		FadeCamera.EIFPKCAFDIB(0).FadeOut(642f);
		if (GameManager.LocalCoop())
		{
			FadeCamera fadeCamera2 = FadeCamera.IGMCBPOPNCA(2);
			fadeCamera2.OnFadeFinished = (Action<int>)Delegate.Combine(fadeCamera2.OnFadeFinished, new Action<int>(CBBILJEAIHN));
			FadeCamera.IGMCBPOPNCA(1).GPBOEBGJJPM(239f);
		}
	}

	private void NEHKIEABLBB(int ABAIKKGKDGD)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(0);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(GDIFNJEKLGC));
		if (PlayerController.OPHDCMJLLEC(1).trayHandler.tray.currentDrinks != null)
		{
			PlayerController.GetPlayer(0).trayHandler.tray.NBODABCGELG(0);
		}
		PlayerController.TeleportPlayer(0, SceneReferences.GetSceneReferences().quarryCaveTp.position, Location.Road | Location.River | Location.Camp | Location.Quarry | Location.Farm | Location.BarnInterior);
		if (GameManager.LocalCoop())
		{
			FadeCamera player = FadeCamera.GetPlayer(6);
			player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(DBKLBDHNGHL));
			if (PlayerController.GetPlayer(1).trayHandler.tray.currentDrinks != null)
			{
				PlayerController.GetPlayer(6).trayHandler.tray.MKBDMMJCGGM(0);
			}
			PlayerController.TeleportPlayer(5, SceneReferences.FAOPFMBMMJJ().quarryCaveTp.position + new Vector3(1809f, 1638f, 152f), Location.Tavern | Location.Road | Location.River | Location.Quarry);
		}
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = SceneReferences.FAOPFMBMMJJ().quarryCaveTp.position - new Vector3(944f, 421f, 1147f);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
		((MonoBehaviour)this).StartCoroutine(HKMGJAEKIKL());
	}
}
