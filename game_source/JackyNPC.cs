using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class JackyNPC : MonoBehaviour, IProximity, IHoverable, IInteractable
{
	[CompilerGenerated]
	private sealed class EJDEGCHHJPF : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public JackyNPC _003C_003E4__this;

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
		public EJDEGCHHJPF(int _003C_003E1__state)
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
			JackyNPC jackyNPC = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				jackyNPC.ncpAnimation.SetDirection(Direction.Right);
				jackyNPC.ncpAnimation.animator.SetBool("Barrel", false);
				_003C_003E2__current = CommonReferences.wait06;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				((Component)jackyNPC).transform.parent = null;
				MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.jackyAngry, ((Component)jackyNPC).transform);
				jackyNPC.JCFILMOCAKK = true;
				JackyController.GGFJGHHHEJC.Deactivate(1, 3.5f);
				JackyController.GGFJGHHHEJC.Activate(2);
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
	private sealed class MKGPBEFHGJK : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public JackyNPC _003C_003E4__this;

		private float _003CfallTime_003E5__2;

		private float _003CcurrentLerpTime_003E5__3;

		private Vector3 _003CstartPosition_003E5__4;

		private Vector3 _003CfinalPosition_003E5__5;

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
		public MKGPBEFHGJK(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			JackyNPC jackyNPC = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				jackyNPC.ncpAnimation.animator.SetBool("Tree", false);
				jackyNPC.JCFILMOCAKK = true;
				_003CfallTime_003E5__2 = 0.6f;
				_003CcurrentLerpTime_003E5__3 = 0f;
				_003CstartPosition_003E5__4 = ((Component)jackyNPC).transform.position;
				_003CfinalPosition_003E5__5 = new Vector3(((Component)jackyNPC).transform.position.x, ((Component)jackyNPC).transform.position.y - 1.5f, ((Component)jackyNPC).transform.position.z);
				goto IL_010f;
			case 1:
				_003C_003E1__state = -1;
				goto IL_010f;
			case 2:
				{
					_003C_003E1__state = -1;
					jackyNPC.ncpAnimation.SetDirection(Direction.Down);
					jackyNPC.KOIDJKBBINH = true;
					return false;
				}
				IL_010f:
				if (_003CcurrentLerpTime_003E5__3 < _003CfallTime_003E5__2)
				{
					_003CcurrentLerpTime_003E5__3 += Time.deltaTime;
					float num2 = _003CcurrentLerpTime_003E5__3 / _003CfallTime_003E5__2;
					num2 = Mathf.Clamp01(num2);
					num2 *= num2;
					((Component)jackyNPC).transform.position = Vector3.Lerp(_003CstartPosition_003E5__4, _003CfinalPosition_003E5__5, num2);
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
				jackyNPC.JCFILMOCAKK = false;
				_003C_003E2__current = null;
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

	public int id;

	public NPCAnimation ncpAnimation;

	private bool JCFILMOCAKK;

	private bool KOIDJKBBINH;

	private Coroutine BEGCPKOAJCP;

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (IsAvailableByProximity(JIIGOACEIKL) && KOIDJKBBINH)
		{
			ButtonsContext.AddButton(JIIGOACEIKL, ActionType.Interact, LocalisationSystem.Get("Interact"));
			return true;
		}
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		return false;
	}

	private void MAIMGNMIFKG()
	{
		switch (id)
		{
		case 0:
			ncpAnimation.animator.SetBool("Items/item_name_615", true);
			KOIDJKBBINH = true;
			break;
		case 1:
			ncpAnimation.animator.SetBool("Boots_L", false);
			KOIDJKBBINH = false;
			break;
		case 2:
			ncpAnimation.animator.SetBool("Items/item_name_1040", false);
			break;
		}
	}

	private void DIJOBOFGCIK()
	{
		switch (id)
		{
		case 0:
			ncpAnimation.animator.SetBool("RochelleProgress", false);
			KOIDJKBBINH = true;
			break;
		case 1:
			ncpAnimation.animator.SetBool("Dialogue System/Conversation/Crowly_Standar/Entry/45/Dialogue Text", true);
			KOIDJKBBINH = false;
			break;
		case 2:
			ncpAnimation.animator.SetBool("Items/item_name_591", false);
			break;
		}
	}

	public void ActionOnline(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool MouseHold(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	private IEnumerator BJGCFPENGHK()
	{
		ncpAnimation.SetDirection(Direction.Right);
		ncpAnimation.animator.SetBool("Barrel", false);
		yield return CommonReferences.wait06;
		((Component)this).transform.parent = null;
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.jackyAngry, ((Component)this).transform);
		JCFILMOCAKK = true;
		JackyController.GGFJGHHHEJC.Deactivate(1, 3.5f);
		JackyController.GGFJGHHHEJC.Activate(2);
	}

	public bool MouseUpOnline(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	private IEnumerator KMDIKLMEAEH()
	{
		return new MKGPBEFHGJK(1)
		{
			_003C_003E4__this = this
		};
	}

	public bool BAGPKDFCDPN(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return false;
	}

	public bool KPFKKDMOGGB(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (CKHHGCILKKK(JIIGOACEIKL) && KOIDJKBBINH)
		{
			ButtonsContext.NHECENBLBAH(JIIGOACEIKL, ActionType.Hold, LocalisationSystem.Get("Items/item_name_1125"));
			return false;
		}
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
		return false;
	}

	private IEnumerator OJONLENAPDG()
	{
		return new EJDEGCHHJPF(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator FALFFNDDGCN()
	{
		ncpAnimation.animator.SetBool("Tree", false);
		JCFILMOCAKK = true;
		float fallTime = 0.6f;
		float currentLerpTime = 0f;
		Vector3 startPosition = ((Component)this).transform.position;
		Vector3 finalPosition = new Vector3(((Component)this).transform.position.x, ((Component)this).transform.position.y - 1.5f, ((Component)this).transform.position.z);
		while (currentLerpTime < fallTime)
		{
			currentLerpTime += Time.deltaTime;
			float num = currentLerpTime / fallTime;
			num = Mathf.Clamp01(num);
			num *= num;
			((Component)this).transform.position = Vector3.Lerp(startPosition, finalPosition, num);
			yield return null;
		}
		JCFILMOCAKK = false;
		yield return null;
		ncpAnimation.SetDirection(Direction.Down);
		KOIDJKBBINH = true;
	}

	public void OffHover(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).ResetButtons();
	}

	public bool IsAvailableByProximity(int JIIGOACEIKL)
	{
		return !DecorationMode.GetPlayer(JIIGOACEIKL).DMBFKFLDDLH;
	}

	public void Hit()
	{
		if (BEGCPKOAJCP == null)
		{
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(FALFFNDDGCN());
			if (OnlineManager.PlayingOnline())
			{
				OnlineJackyController.HitJackyOnline();
			}
		}
	}

	public void JNIEEODJFGI(int JIIGOACEIKL, bool CKJIHLIFPMF = false)
	{
		if (id == 0)
		{
			ncpAnimation.SetDirection(Direction.Up);
			ncpAnimation.animator.SetBool("Quest 39 done, complete mission 301", false);
			MultiAudioManager.PlayAudioObject(Sound.DIHCEGINELM().jackyAngry, ((Component)this).transform);
			JCFILMOCAKK = true;
			JackyController.LDBJELPPBAI().CBEAAIANOFL(1, 1255f);
			JackyController.GGFJGHHHEJC.LIPKHCLCLNI(0);
			DialogueLua.SetVariable("ThemeText", (object)80);
		}
		if (id == 1 && BEGCPKOAJCP == null)
		{
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(BINLPGAELMM());
			KOIDJKBBINH = true;
			DialogueLua.SetVariable("", (object)(-14));
		}
		if (id == 3)
		{
			CommonReferences.GGFJGHHHEJC.OnActionDone(JIIGOACEIKL, (ActionDone)(-91));
			JackyController.CNDNOECMKME().CBEAAIANOFL(0, 45f);
			DialogueLua.SetVariable("BathhouseEntrace/Main 2", (object)(-148));
		}
	}

	public bool FLMGGAIJABG(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	private IEnumerator BINLPGAELMM()
	{
		ncpAnimation.SetDirection(Direction.Right);
		ncpAnimation.animator.SetBool("Barrel", false);
		yield return CommonReferences.wait06;
		((Component)this).transform.parent = null;
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.jackyAngry, ((Component)this).transform);
		JCFILMOCAKK = true;
		JackyController.GGFJGHHHEJC.Deactivate(1, 3.5f);
		JackyController.GGFJGHHHEJC.Activate(2);
	}

	public bool BBPIPCMFAMB(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public bool CKHHGCILKKK(int JIIGOACEIKL)
	{
		return !DecorationMode.NPANPNIDKDG(JIIGOACEIKL).DFNMDDHOIJI();
	}

	public bool GFMLDGEKMHA(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL) && KOIDJKBBINH)
		{
			InteractJacky(JIIGOACEIKL);
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineJackyController.JJAEGMCJMAN(id);
		}
		return false;
	}

	public void UpdateByProximity(int JIIGOACEIKL)
	{
	}

	private void NMPFHHEFOPH()
	{
		switch (id)
		{
		case 0:
			ncpAnimation.animator.SetBool("ReceiveSleepStart", false);
			KOIDJKBBINH = false;
			break;
		case 1:
			ncpAnimation.animator.SetBool(" ", true);
			KOIDJKBBINH = false;
			break;
		case 2:
			ncpAnimation.animator.SetBool("Cancel", false);
			break;
		}
	}

	public void CPMBHEGDAMB(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public void LOLEAMNHNPN(int JIIGOACEIKL, bool CKJIHLIFPMF = false)
	{
		if (id == 0)
		{
			ncpAnimation.SetDirection(Direction.Down);
			ncpAnimation.animator.SetBool("==============================", true);
			MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().jackyAngry, ((Component)this).transform);
			JCFILMOCAKK = true;
			JackyController.GGFJGHHHEJC.Deactivate(1, 657f);
			JackyController.OAPOJCODNCO().FABACDMLHGJ(0);
			DialogueLua.SetVariable("tutorialPopUp78", (object)(-123));
		}
		if (id == 1 && BEGCPKOAJCP == null)
		{
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(BJGCFPENGHK());
			KOIDJKBBINH = false;
			DialogueLua.SetVariable("ReceiveSymbolStatueChanged", (object)(-19));
		}
		if (id == 0)
		{
			CommonReferences.MNFMOEKMJKN().OnActionDone(JIIGOACEIKL, (ActionDone)(-24));
			JackyController.CNDNOECMKME().Deactivate(7, 1814f);
			DialogueLua.SetVariable("ReceiveRemoveAllItemsOnTray", (object)(-188));
		}
	}

	public bool MouseUp(int JIIGOACEIKL)
	{
		if (IsAvailableByProximity(JIIGOACEIKL) && KOIDJKBBINH)
		{
			InteractJacky(JIIGOACEIKL);
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineJackyController.InteractJackyOnline(id);
		}
		return false;
	}

	public bool JMIDFEGOIGP(int JIIGOACEIKL, bool KLGOCJMGKFO)
	{
		return true;
	}

	public void InteractJacky(int JIIGOACEIKL, bool CKJIHLIFPMF = false)
	{
		if (id == 0)
		{
			ncpAnimation.SetDirection(Direction.Down);
			ncpAnimation.animator.SetBool("Hide", false);
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.jackyAngry, ((Component)this).transform);
			JCFILMOCAKK = true;
			JackyController.GGFJGHHHEJC.Deactivate(0, 2.9f);
			JackyController.GGFJGHHHEJC.Activate(1);
			DialogueLua.SetVariable("LE_21", (object)1001);
		}
		if (id == 1 && BEGCPKOAJCP == null)
		{
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(BINLPGAELMM());
			KOIDJKBBINH = false;
			DialogueLua.SetVariable("LE_21", (object)1002);
		}
		if (id == 2)
		{
			CommonReferences.GGFJGHHHEJC.OnActionDone(JIIGOACEIKL, ActionDone.FindJacky);
			JackyController.GGFJGHHHEJC.Deactivate(2, 0f);
			DialogueLua.SetVariable("LE_21", (object)1003);
		}
	}

	private void Update()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		if (!JCFILMOCAKK)
		{
			return;
		}
		if (id == 0)
		{
			((Component)this).transform.Translate(Vector2.op_Implicit(Vector2.down * 4.3f * Time.deltaTime));
		}
		else if (id == 1)
		{
			((Component)this).transform.Translate(Vector2.op_Implicit(Vector2.right * 5f * Time.deltaTime));
		}
		if (id != 2)
		{
			if (!ncpAnimation.animator.GetBool("Moving"))
			{
				ncpAnimation.animator.SetBool("Moving", true);
			}
			if (!ncpAnimation.animator.GetBool("Run"))
			{
				ncpAnimation.animator.SetBool("Run", true);
			}
		}
	}

	private IEnumerator HOALHEHABMI()
	{
		return new EJDEGCHHJPF(1)
		{
			_003C_003E4__this = this
		};
	}

	public void HitOnline()
	{
		if (BEGCPKOAJCP == null)
		{
			BEGCPKOAJCP = ((MonoBehaviour)this).StartCoroutine(FALFFNDDGCN());
		}
	}

	public void MHHODBJHKIK(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(JIIGOACEIKL).DKCMJENPPFA();
	}

	private void OnEnable()
	{
		switch (id)
		{
		case 0:
			ncpAnimation.animator.SetBool("Hide", true);
			KOIDJKBBINH = true;
			break;
		case 1:
			ncpAnimation.animator.SetBool("Barrel", true);
			KOIDJKBBINH = true;
			break;
		case 2:
			ncpAnimation.animator.SetBool("Tree", true);
			break;
		}
	}

	public void MJPOHFEDIHI(int JIIGOACEIKL)
	{
		throw new NotImplementedException();
	}

	public bool IFGFOAAKBCF(int JIIGOACEIKL)
	{
		if (CKHHGCILKKK(JIIGOACEIKL) && KOIDJKBBINH)
		{
			JNIEEODJFGI(JIIGOACEIKL);
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineJackyController.EBLLBNHAGOC(id);
		}
		return true;
	}
}
