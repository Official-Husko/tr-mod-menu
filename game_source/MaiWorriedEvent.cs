using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class MaiWorriedEvent : GameEvent
{
	private enum LOGEKNJJJOB
	{
		ActivaMaiInRoad
	}

	[CompilerGenerated]
	private sealed class ECEJIIMBIBF : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MaiWorriedEvent _003C_003E4__this;

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
		public ECEJIIMBIBF(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			MaiWorriedEvent maiWorriedEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				MaiNPC.SetBool("Disabled", AODONKKHPBP: true);
				((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)DeliveryChest.GetInstance()).transform;
				((Component)MaiNPC.GGFJGHHHEJC).transform.position = maiWorriedEvent.maiPositionInRoad.position;
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
				MaiNPC.SetBool("Disabled", AODONKKHPBP: false);
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
			switch (_003C_003E1__state)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait5;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
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
	private sealed class ODGNALKOJKB : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MaiWorriedEvent _003C_003E4__this;

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
		public ODGNALKOJKB(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			MaiWorriedEvent maiWorriedEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				goto IL_0046;
			case 1:
				_003C_003E1__state = -1;
				goto IL_0046;
			case 2:
				_003C_003E1__state = -1;
				maiWorriedEvent.EDNFGHLMBGN();
				if (OnlineManager.PlayingOnline())
				{
					OnlineEventsManager.SendSimpleEvent(maiWorriedEvent.eventType, 0);
				}
				PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 3;
				return true;
			case 3:
				{
					_003C_003E1__state = -1;
					PlayerController.GetPlayer(1).characterAnimation.LookAt(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
					maiWorriedEvent.isStarted = true;
					maiWorriedEvent.EDGDFPPKGDL = MaiNPC.GGFJGHHHEJC;
					maiWorriedEvent.MDFALJKHKED = "MaiWorried/Main";
					PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
					MaiNPC.GGFJGHHHEJC.StartConversation(1, maiWorriedEvent.MDFALJKHKED);
					return false;
				}
				IL_0046:
				if (!Utils.AHMPFOEGJHF(Location.Road))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
				_003C_003E2__current = ((MonoBehaviour)maiWorriedEvent).StartCoroutine(maiWorriedEvent.CDICFNAMCEE());
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
	private sealed class CIGHDELAPPN : IEnumerator<object>, IEnumerator, IDisposable
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
		public CIGHDELAPPN(int _003C_003E1__state)
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
				break;
			case 1:
				_003C_003E1__state = -1;
				break;
			}
			if (MainUI.IsAnyUIOpen())
			{
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
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

	public static MaiWorriedEvent instance;

	public Transform maiPositionInRoad;

	private IEnumerator OCIKBJLDBGD()
	{
		return new ODGNALKOJKB(1)
		{
			_003C_003E4__this = this
		};
	}

	protected IEnumerator KFPLDIOOCKA()
	{
		while (MainUI.IsAnyUIOpen())
		{
			yield return null;
		}
	}

	private void GOINIDJJMCP()
	{
		((MonoBehaviour)this).StartCoroutine(JNKKGGKPPDJ());
	}

	private IEnumerator PFDOANENEBM()
	{
		return new ECEJIIMBIBF(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator CKCGKGFHEID()
	{
		return new ODGNALKOJKB(1)
		{
			_003C_003E4__this = this
		};
	}

	private bool GNLLCNECLEA()
	{
		if (PlayerController.OPHDCMJLLEC(0).IsTavernLocation())
		{
			return !MainUI.BHNFPAIHJLM();
		}
		return false;
	}

	protected IEnumerator IOLMDKJPHCP()
	{
		while (MainUI.IsAnyUIOpen())
		{
			yield return null;
		}
	}

	private IEnumerator HLLJNMPKMIJ()
	{
		return new ODGNALKOJKB(1)
		{
			_003C_003E4__this = this
		};
	}

	protected IEnumerator IJEJAPENBNM()
	{
		return new CIGHDELAPPN(1);
	}

	private bool EIIMMPPLBPC()
	{
		if (PlayerController.GetPlayer(0).IsTavernLocation())
		{
			return MainUI.ADNMPFPHCMB();
		}
		return true;
	}

	private IEnumerator ALGFHNGKHNI()
	{
		while (!Utils.AHMPFOEGJHF(Location.Road))
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		EDNFGHLMBGN();
		if (OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		yield return CommonReferences.wait2;
		PlayerController.GetPlayer(1).characterAnimation.LookAt(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		isStarted = true;
		EDGDFPPKGDL = MaiNPC.GGFJGHHHEJC;
		MDFALJKHKED = "MaiWorried/Main";
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		MaiNPC.GGFJGHHHEJC.StartConversation(1, MDFALJKHKED);
	}

	private IEnumerator ILACGKHFIEC()
	{
		while (!Utils.AHMPFOEGJHF(Location.Road))
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		EDNFGHLMBGN();
		if (OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		yield return CommonReferences.wait2;
		PlayerController.GetPlayer(1).characterAnimation.LookAt(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		isStarted = true;
		EDGDFPPKGDL = MaiNPC.GGFJGHHHEJC;
		MDFALJKHKED = "MaiWorried/Main";
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		MaiNPC.GGFJGHHHEJC.StartConversation(1, MDFALJKHKED);
	}

	protected IEnumerator GCMFLBIEGAH()
	{
		return new CIGHDELAPPN(1);
	}

	protected IEnumerator JANODDKIKEI()
	{
		while (MainUI.IsAnyUIOpen())
		{
			yield return null;
		}
	}

	private bool FGDLMDPJGJM()
	{
		if (PlayerController.GetPlayer(0).IsTavernLocation())
		{
			return MainUI.AMOAACGGPJO();
		}
		return false;
	}

	private IEnumerator ONJOEDANANK()
	{
		yield return CommonReferences.wait5;
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
	}

	protected IEnumerator CGKIPPOBGPH()
	{
		while (MainUI.IsAnyUIOpen())
		{
			yield return null;
		}
	}

	private IEnumerator LJABJLDHLCB()
	{
		yield return CommonReferences.wait5;
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
	}

	private IEnumerator LHCNOFOBFCF()
	{
		return new ODGNALKOJKB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator DHFIBPCEAJC()
	{
		while (!Utils.AHMPFOEGJHF(Location.Road))
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		EDNFGHLMBGN();
		if (OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		yield return CommonReferences.wait2;
		PlayerController.GetPlayer(1).characterAnimation.LookAt(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		isStarted = true;
		EDGDFPPKGDL = MaiNPC.GGFJGHHHEJC;
		MDFALJKHKED = "MaiWorried/Main";
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		MaiNPC.GGFJGHHHEJC.StartConversation(1, MDFALJKHKED);
	}

	protected IEnumerator JGCMCGCKPHL()
	{
		while (MainUI.IsAnyUIOpen())
		{
			yield return null;
		}
	}

	private bool HLNNGHEECOB()
	{
		if (PlayerController.GetPlayer(1).IsTavernLocation())
		{
			return !MainUI.BBNDLNLJIEB();
		}
		return false;
	}

	private void NLEJMLGCPFL()
	{
		((MonoBehaviour)this).StartCoroutine(IHNLGMEDAFK());
	}

	private IEnumerator LNAAPGJGDFG()
	{
		while (!Utils.AHMPFOEGJHF(Location.Road))
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		EDNFGHLMBGN();
		if (OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		yield return CommonReferences.wait2;
		PlayerController.GetPlayer(1).characterAnimation.LookAt(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		isStarted = true;
		EDGDFPPKGDL = MaiNPC.GGFJGHHHEJC;
		MDFALJKHKED = "MaiWorried/Main";
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		MaiNPC.GGFJGHHHEJC.StartConversation(1, MDFALJKHKED);
	}

	private void LOOCLPGOODL()
	{
		((MonoBehaviour)this).StartCoroutine(FFNMKGILNIL());
	}

	protected IEnumerator IAOJFAIIHNL()
	{
		while (MainUI.IsAnyUIOpen())
		{
			yield return null;
		}
	}

	private IEnumerator HEBFNADPOFD()
	{
		return new ECEJIIMBIBF(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator LCKPJBFEBKL()
	{
		yield return CommonReferences.wait5;
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
	}

	protected IEnumerator CDICFNAMCEE()
	{
		while (MainUI.IsAnyUIOpen())
		{
			yield return null;
		}
	}

	private IEnumerator LMIKJPJMCKB()
	{
		return new ODGNALKOJKB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void OINGEPFAOJJ()
	{
		((MonoBehaviour)this).StartCoroutine(MHICODNGGIE());
	}

	protected IEnumerator AACMNIEPDFJ()
	{
		while (MainUI.IsAnyUIOpen())
		{
			yield return null;
		}
	}

	protected IEnumerator MDCLICEFDGK()
	{
		return new CIGHDELAPPN(1);
	}

	protected IEnumerator DPLAGNBEHBD()
	{
		return new CIGHDELAPPN(1);
	}

	private IEnumerator MCECKBFLGAK()
	{
		return new NNHLBCGNEOA(1);
	}

	private IEnumerator CLMDNEOMIOP()
	{
		return new ECEJIIMBIBF(1)
		{
			_003C_003E4__this = this
		};
	}

	private void DKKGAOGKMFB()
	{
		((MonoBehaviour)this).StartCoroutine(IHNLGMEDAFK());
	}

	private void GCIGBDCMAPI()
	{
		((MonoBehaviour)this).StartCoroutine(GCGOJGJICCN());
	}

	private bool BAKEBNKFPLJ()
	{
		if (PlayerController.OPHDCMJLLEC(0).IsTavernLocation())
		{
			return !MainUI.ADNMPFPHCMB();
		}
		return true;
	}

	protected IEnumerator GJFMGDLKFOP()
	{
		while (MainUI.IsAnyUIOpen())
		{
			yield return null;
		}
	}

	public override void OnSimpleEvent(short JFNMCNCHMEO)
	{
		base.OnSimpleEvent(JFNMCNCHMEO);
		string[] obj = new string[5] { "On Simple Event ", null, null, null, null };
		LOGEKNJJJOB lOGEKNJJJOB = (LOGEKNJJJOB)JFNMCNCHMEO;
		obj[1] = lOGEKNJJJOB.ToString();
		obj[2] = ". Time since startup: ";
		obj[3] = Time.realtimeSinceStartup.ToString("F2");
		obj[4] = " seconds.";
		Debug.Log((object)string.Concat(obj));
		if (JFNMCNCHMEO == 0)
		{
			EDNFGHLMBGN();
		}
	}

	private IEnumerator OPDAICBNENN()
	{
		yield return CommonReferences.wait5;
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
	}

	private IEnumerator HPEPFMOFKEG()
	{
		yield return CommonReferences.wait5;
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
	}

	protected IEnumerator IDBDDNKLMKD()
	{
		while (MainUI.IsAnyUIOpen())
		{
			yield return null;
		}
	}

	private bool IIBDKCHPBAO()
	{
		if (PlayerController.OPHDCMJLLEC(1).IsTavernLocation())
		{
			return !MainUI.IsAnyUIOpen();
		}
		return true;
	}

	private IEnumerator IHKGCAPHHCH()
	{
		return new ECEJIIMBIBF(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator OBKJMOKDKGM()
	{
		while (!Utils.AHMPFOEGJHF(Location.Road))
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		EDNFGHLMBGN();
		if (OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		yield return CommonReferences.wait2;
		PlayerController.GetPlayer(1).characterAnimation.LookAt(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		isStarted = true;
		EDGDFPPKGDL = MaiNPC.GGFJGHHHEJC;
		MDFALJKHKED = "MaiWorried/Main";
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		MaiNPC.GGFJGHHHEJC.StartConversation(1, MDFALJKHKED);
	}

	private IEnumerator JIFJLCMNMEA()
	{
		return new NNHLBCGNEOA(1);
	}

	private void NBKHCGEIGFI()
	{
		((MonoBehaviour)this).StartCoroutine(IHKGCAPHHCH());
	}

	protected IEnumerator KEKIGOEPOGA()
	{
		return new CIGHDELAPPN(1);
	}

	private IEnumerator OGHLNLPFDOP()
	{
		yield return CommonReferences.wait5;
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
	}

	public override void EndEvent(bool BFLCJPHHDJM)
	{
		base.EndEvent(BFLCJPHHDJM);
		MaiNPC.GGFJGHHHEJC.DisappearMai();
		EDGDFPPKGDL = null;
		DialogueLua.SetVariable("MainProgress", (object)17);
		MissionsManager.instance.StartMission(322);
		BathhouseEntraceEvent.instance.ActivateEvent();
		((MonoBehaviour)instance).StartCoroutine(LJABJLDHLCB());
	}

	private IEnumerator MHICODNGGIE()
	{
		return new ECEJIIMBIBF(1)
		{
			_003C_003E4__this = this
		};
	}

	private bool CIILOBHPGNE()
	{
		if (PlayerController.GetPlayer(1).IsTavernLocation())
		{
			return MainUI.BHNFPAIHJLM();
		}
		return false;
	}

	public override void ActivateEvent()
	{
		base.ActivateEvent();
		if (OnlineManager.MasterOrOffline())
		{
			((MonoBehaviour)this).StartCoroutine(NJFNGJCBAPI());
		}
	}

	private bool LHCBEAJHMAH()
	{
		if (PlayerController.GetPlayer(1).IsTavernLocation())
		{
			return !MainUI.AMOAACGGPJO();
		}
		return true;
	}

	private bool AHFHNFMOMGB()
	{
		if (PlayerController.GetPlayer(1).IsTavernLocation())
		{
			return !MainUI.ADNMPFPHCMB();
		}
		return false;
	}

	private IEnumerator EIHPDECEBAD()
	{
		MaiNPC.SetBool("Disabled", AODONKKHPBP: true);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)DeliveryChest.GetInstance()).transform;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = maiPositionInRoad.position;
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.SetBool("Disabled", AODONKKHPBP: false);
	}

	private IEnumerator LGJAFPFEDFO()
	{
		yield return CommonReferences.wait5;
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
	}

	private bool EBGNLPPOBAD()
	{
		if (PlayerController.GetPlayer(1).IsTavernLocation())
		{
			return MainUI.AMOAACGGPJO();
		}
		return true;
	}

	private void BFPDMLAJLFH()
	{
		((MonoBehaviour)this).StartCoroutine(PNDFOLBKAGA());
	}

	private IEnumerator JHHJHDLAFKE()
	{
		return new ECEJIIMBIBF(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator EEBGPIOLBIB()
	{
		return new ODGNALKOJKB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void DBCOJEOBGEG()
	{
		((MonoBehaviour)this).StartCoroutine(IHNLGMEDAFK());
	}

	private IEnumerator CIKPCMILKMH()
	{
		return new NNHLBCGNEOA(1);
	}

	private void MMAIANOGEBM()
	{
		((MonoBehaviour)this).StartCoroutine(JNKKGGKPPDJ());
	}

	private bool BEILFPNCOAO()
	{
		if (PlayerController.GetPlayer(0).IsTavernLocation())
		{
			return MainUI.BHNFPAIHJLM();
		}
		return true;
	}

	private void OMHPDOOEEKC()
	{
		((MonoBehaviour)this).StartCoroutine(EIHPDECEBAD());
	}

	protected override void Awake()
	{
		base.Awake();
		instance = this;
	}

	private IEnumerator FFNMKGILNIL()
	{
		MaiNPC.SetBool("Disabled", AODONKKHPBP: true);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)DeliveryChest.GetInstance()).transform;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = maiPositionInRoad.position;
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.SetBool("Disabled", AODONKKHPBP: false);
	}

	private IEnumerator FCELAMHDKGL()
	{
		MaiNPC.SetBool("Disabled", AODONKKHPBP: true);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)DeliveryChest.GetInstance()).transform;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = maiPositionInRoad.position;
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.SetBool("Disabled", AODONKKHPBP: false);
	}

	private bool EGFPFBFBNPF()
	{
		if (PlayerController.GetPlayer(1).IsTavernLocation())
		{
			return !MainUI.BBNDLNLJIEB();
		}
		return false;
	}

	private IEnumerator FMNCOOFJLPO()
	{
		return new ODGNALKOJKB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator OIKDONLFAIL()
	{
		yield return CommonReferences.wait5;
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
	}

	private void NCPKGFHJGGK()
	{
		((MonoBehaviour)this).StartCoroutine(PFDOANENEBM());
	}

	private IEnumerator ELKGDJOFCIC()
	{
		return new ECEJIIMBIBF(1)
		{
			_003C_003E4__this = this
		};
	}

	protected IEnumerator FLFNKJJMLCB()
	{
		return new CIGHDELAPPN(1);
	}

	private IEnumerator AJGGMHBIKHK()
	{
		yield return CommonReferences.wait5;
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
	}

	private bool HHKIBOJMBPB()
	{
		if (PlayerController.OPHDCMJLLEC(0).IsTavernLocation())
		{
			return MainUI.BHNFPAIHJLM();
		}
		return false;
	}

	private void AKCLBHPPAGB()
	{
		((MonoBehaviour)this).StartCoroutine(IHNLGMEDAFK());
	}

	private IEnumerator BDLLENEGHMB()
	{
		return new NNHLBCGNEOA(1);
	}

	private IEnumerator LDLJOPENBMM()
	{
		yield return CommonReferences.wait5;
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
	}

	private IEnumerator KNEDHGFNDJB()
	{
		yield return CommonReferences.wait5;
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
	}

	private IEnumerator GBMDDMGAAIA()
	{
		yield return CommonReferences.wait5;
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
	}

	private bool EEKKHBLKFMF()
	{
		if (PlayerController.GetPlayer(0).IsTavernLocation())
		{
			return !MainUI.BHNFPAIHJLM();
		}
		return true;
	}

	private IEnumerator COJOLLMKHIF()
	{
		while (!Utils.AHMPFOEGJHF(Location.Road))
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		EDNFGHLMBGN();
		if (OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		yield return CommonReferences.wait2;
		PlayerController.GetPlayer(1).characterAnimation.LookAt(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		isStarted = true;
		EDGDFPPKGDL = MaiNPC.GGFJGHHHEJC;
		MDFALJKHKED = "MaiWorried/Main";
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		MaiNPC.GGFJGHHHEJC.StartConversation(1, MDFALJKHKED);
	}

	protected IEnumerator NDMOHNFKFGN()
	{
		return new CIGHDELAPPN(1);
	}

	protected IEnumerator LCLNNOIADBL()
	{
		while (MainUI.IsAnyUIOpen())
		{
			yield return null;
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

	private IEnumerator PNDFOLBKAGA()
	{
		MaiNPC.SetBool("Disabled", AODONKKHPBP: true);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)DeliveryChest.GetInstance()).transform;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = maiPositionInRoad.position;
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.SetBool("Disabled", AODONKKHPBP: false);
	}

	private IEnumerator GCGOJGJICCN()
	{
		MaiNPC.SetBool("Disabled", AODONKKHPBP: true);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)DeliveryChest.GetInstance()).transform;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = maiPositionInRoad.position;
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.SetBool("Disabled", AODONKKHPBP: false);
	}

	private IEnumerator IHNLGMEDAFK()
	{
		return new ECEJIIMBIBF(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator FOJGKFCCFAA()
	{
		return new NNHLBCGNEOA(1);
	}

	private bool HOHOPPDLOLI()
	{
		if (PlayerController.OPHDCMJLLEC(0).IsTavernLocation())
		{
			return MainUI.AMOAACGGPJO();
		}
		return true;
	}

	private IEnumerator GCDBHEGHEND()
	{
		return new ODGNALKOJKB(1)
		{
			_003C_003E4__this = this
		};
	}

	private bool BKINKIOKFDE()
	{
		if (PlayerController.OPHDCMJLLEC(0).IsTavernLocation())
		{
			return MainUI.BHNFPAIHJLM();
		}
		return true;
	}

	protected IEnumerator OMKPEKKJKEB()
	{
		while (MainUI.IsAnyUIOpen())
		{
			yield return null;
		}
	}

	protected IEnumerator GAGKJEGHAKK()
	{
		while (MainUI.IsAnyUIOpen())
		{
			yield return null;
		}
	}

	protected IEnumerator JAMPHCLJEID()
	{
		while (MainUI.IsAnyUIOpen())
		{
			yield return null;
		}
	}

	private IEnumerator LODHNEEINAA()
	{
		return new ODGNALKOJKB(1)
		{
			_003C_003E4__this = this
		};
	}

	protected IEnumerator OIIFPFCGIHA()
	{
		return new CIGHDELAPPN(1);
	}

	private void JGMJLJPHKHL()
	{
		((MonoBehaviour)this).StartCoroutine(GCGOJGJICCN());
	}

	private IEnumerator CGFAIPCPGHL()
	{
		return new NNHLBCGNEOA(1);
	}

	private void NOOEEJIHHKH()
	{
		((MonoBehaviour)this).StartCoroutine(EIHPDECEBAD());
	}

	protected IEnumerator JGNKGEPKBJC()
	{
		return new CIGHDELAPPN(1);
	}

	private IEnumerator AJJOPOIDDJH()
	{
		return new ECEJIIMBIBF(1)
		{
			_003C_003E4__this = this
		};
	}

	private void PIPKJHJIPDK()
	{
		((MonoBehaviour)this).StartCoroutine(HEBFNADPOFD());
	}

	private void PLIOGBJEOGI()
	{
		((MonoBehaviour)this).StartCoroutine(CLMDNEOMIOP());
	}

	public override GameEvent GetInstance()
	{
		return instance;
	}

	private IEnumerator NKCPLDBAOJN()
	{
		return new ODGNALKOJKB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void BAPLPIOHLMK()
	{
		((MonoBehaviour)this).StartCoroutine(HEBFNADPOFD());
	}

	private IEnumerator JNKKGGKPPDJ()
	{
		return new ECEJIIMBIBF(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator FFLLLAIDAAP()
	{
		return new ODGNALKOJKB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator ELFPIDGFEHH()
	{
		return new NNHLBCGNEOA(1);
	}

	private IEnumerator MNGEJIMEOKF()
	{
		return new NNHLBCGNEOA(1);
	}

	private void MLCPHLBPEMM()
	{
		((MonoBehaviour)this).StartCoroutine(IHNLGMEDAFK());
	}

	private void GIGBGDOJAIL()
	{
		((MonoBehaviour)this).StartCoroutine(JPBHFPPMFEO());
	}

	private void EDNFGHLMBGN()
	{
		((MonoBehaviour)this).StartCoroutine(EIHPDECEBAD());
	}

	private IEnumerator BLGBAKOIHPL()
	{
		MaiNPC.SetBool("Disabled", AODONKKHPBP: true);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)DeliveryChest.GetInstance()).transform;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = maiPositionInRoad.position;
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.SetBool("Disabled", AODONKKHPBP: false);
	}

	private void DCFFHGGOKCB()
	{
		((MonoBehaviour)this).StartCoroutine(NHMPHGCALII());
	}

	private IEnumerator HNCCDHNOJLO()
	{
		while (!Utils.AHMPFOEGJHF(Location.Road))
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		EDNFGHLMBGN();
		if (OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		yield return CommonReferences.wait2;
		PlayerController.GetPlayer(1).characterAnimation.LookAt(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		isStarted = true;
		EDGDFPPKGDL = MaiNPC.GGFJGHHHEJC;
		MDFALJKHKED = "MaiWorried/Main";
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		MaiNPC.GGFJGHHHEJC.StartConversation(1, MDFALJKHKED);
	}

	protected IEnumerator GOBFICADLBF()
	{
		return new CIGHDELAPPN(1);
	}

	private IEnumerator NEDIKKOBOJJ()
	{
		return new ODGNALKOJKB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void BFMFKAMEHMB()
	{
		((MonoBehaviour)this).StartCoroutine(IHKGCAPHHCH());
	}

	private void OFBLMIALHOI()
	{
		((MonoBehaviour)this).StartCoroutine(HEBFNADPOFD());
	}

	private IEnumerator JPBHFPPMFEO()
	{
		MaiNPC.SetBool("Disabled", AODONKKHPBP: true);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)DeliveryChest.GetInstance()).transform;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = maiPositionInRoad.position;
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.SetBool("Disabled", AODONKKHPBP: false);
	}

	private bool CKKFBEPEGBF()
	{
		if (PlayerController.OPHDCMJLLEC(1).IsTavernLocation())
		{
			return MainUI.IsAnyUIOpen();
		}
		return true;
	}

	private IEnumerator NJFNGJCBAPI()
	{
		while (!Utils.AHMPFOEGJHF(Location.Road))
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		EDNFGHLMBGN();
		if (OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		yield return CommonReferences.wait2;
		PlayerController.GetPlayer(1).characterAnimation.LookAt(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		isStarted = true;
		EDGDFPPKGDL = MaiNPC.GGFJGHHHEJC;
		MDFALJKHKED = "MaiWorried/Main";
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		MaiNPC.GGFJGHHHEJC.StartConversation(1, MDFALJKHKED);
	}

	private IEnumerator DIAPDNEEOIB()
	{
		return new NNHLBCGNEOA(1);
	}

	private IEnumerator IPBLEENMPDD()
	{
		while (!Utils.AHMPFOEGJHF(Location.Road))
		{
			yield return null;
		}
		yield return ((MonoBehaviour)this).StartCoroutine(CDICFNAMCEE());
		EDNFGHLMBGN();
		if (OnlineManager.PlayingOnline())
		{
			OnlineEventsManager.SendSimpleEvent(eventType, 0);
		}
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		yield return CommonReferences.wait2;
		PlayerController.GetPlayer(1).characterAnimation.LookAt(Vector2.op_Implicit(((Component)MaiNPC.GGFJGHHHEJC).transform.position));
		isStarted = true;
		EDGDFPPKGDL = MaiNPC.GGFJGHHHEJC;
		MDFALJKHKED = "MaiWorried/Main";
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		MaiNPC.GGFJGHHHEJC.StartConversation(1, MDFALJKHKED);
	}

	private void PAFJFNIBDKH()
	{
		((MonoBehaviour)this).StartCoroutine(JPBHFPPMFEO());
	}

	private void AFIEHLLOGFG()
	{
		((MonoBehaviour)this).StartCoroutine(CLMDNEOMIOP());
	}

	private IEnumerator NHMPHGCALII()
	{
		return new ECEJIIMBIBF(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator PGNNNJENOFL()
	{
		yield return CommonReferences.wait5;
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = null;
	}

	private void FLMKMGJBIMN()
	{
		((MonoBehaviour)this).StartCoroutine(EIHPDECEBAD());
	}

	protected IEnumerator EOONLEIACKI()
	{
		return new CIGHDELAPPN(1);
	}

	private IEnumerator CAJLHDGKNGN()
	{
		MaiNPC.SetBool("Disabled", AODONKKHPBP: true);
		((Component)MaiNPC.GGFJGHHHEJC).transform.parent = ((Component)DeliveryChest.GetInstance()).transform;
		((Component)MaiNPC.GGFJGHHHEJC).transform.position = maiPositionInRoad.position;
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		MaiNPC.SetBool("Disabled", AODONKKHPBP: false);
	}

	protected IEnumerator JDBFMHEJOLD()
	{
		return new CIGHDELAPPN(1);
	}

	private IEnumerator KGMENLGJDCF()
	{
		return new ECEJIIMBIBF(1)
		{
			_003C_003E4__this = this
		};
	}

	private bool EICLMOPCBHH()
	{
		if (PlayerController.OPHDCMJLLEC(1).IsTavernLocation())
		{
			return MainUI.IsAnyUIOpen();
		}
		return false;
	}
}
