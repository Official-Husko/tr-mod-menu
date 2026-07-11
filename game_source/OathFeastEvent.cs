using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class OathFeastEvent : GameEvent
{
	[CompilerGenerated]
	private sealed class IMHJBMJLFDC : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public IMHJBMJLFDC(int _003C_003E1__state)
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
				MaiNPC.GGFJGHHHEJC.ActiveMaiInBed();
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				BanquetEvent.instance.ActivateEvent();
				if (OnlineManager.MasterOrOffline())
				{
					MaiNPC.GGFJGHHHEJC.StartConversation(playerNum, "Festín del Juramento/MaiDialogue 01");
					break;
				}
				_003C_003E2__current = MaiNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(playerNum);
				_003C_003E1__state = 2;
				return true;
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
	private sealed class LHFPFABFMHJ : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OathFeastEvent _003C_003E4__this;

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
		public LHFPFABFMHJ(int _003C_003E1__state)
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
			OathFeastEvent nPJDIDHOEFB = _003C_003E4__this;
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
				_003C_003E1__state = -1;
				PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)nPJDIDHOEFB);
				((Component)RefereeNPC.GGFJGHHHEJC.barrel).gameObject.SetActive(true);
				RefereeNPC.GGFJGHHHEJC.barrel.ResetMovement();
				DialogueCameraTarget.BarrelEventCamController(JCFILMOCAKK: true);
				if (GameManager.LocalCoop())
				{
					LocalCooperativeManager.FocusCameraToPlayerInLocalCoop(1);
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
	private sealed class LGFEIHPJLKL : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OathFeastEvent _003C_003E4__this;

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
		public LGFEIHPJLKL(int _003C_003E1__state)
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
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00de: Unknown result type (might be due to invalid IL or missing references)
			//IL_011c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0130: Unknown result type (might be due to invalid IL or missing references)
			//IL_0135: Unknown result type (might be due to invalid IL or missing references)
			//IL_019d: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			OathFeastEvent oathFeastEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				if (OnlineManager.MasterOrOffline())
				{
					LucenNPC.GGFJGHHHEJC.TriggerAnimation("Hair");
					_003C_003E2__current = CommonReferences.wait1;
					_003C_003E1__state = 1;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 3;
				return true;
			case 1:
				_003C_003E1__state = -1;
				LucenNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Up);
				OrwinIINPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Right);
				PuddingNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Left);
				OxNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Right);
				((Component)OxNPC.GGFJGHHHEJC).transform.position = ((Component)OxNPC.GGFJGHHHEJC).transform.position - new Vector3(0.25f, 0f, 0f);
				OxNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Right);
				RibellaNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Left);
				((Component)RibellaNPC.GGFJGHHHEJC).transform.position = ((Component)RibellaNPC.GGFJGHHHEJC).transform.position + new Vector3(0.25f, 0f, 0f);
				RibellaNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Left);
				TweekNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Right);
				KyrohNPC.GGFJGHHHEJC.animationBase.SetBool("Random", EGFGNGJGBOP: true);
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				LucenNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(oathFeastEvent.spawn[0].position), Direction.Down, KEEGDBAAEOG: true);
				goto IL_01e6;
			case 3:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 4;
				return true;
			case 4:
				_003C_003E1__state = -1;
				goto IL_01e6;
			case 5:
				_003C_003E1__state = -1;
				MusicController.instance.TriggerMusicTheme(24);
				OxNPC.GGFJGHHHEJC.inSpecialEvent = true;
				_003C_003E2__current = OnlineManager.WaitForAllPlayers();
				_003C_003E1__state = 6;
				return true;
			case 6:
				_003C_003E1__state = -1;
				if (oathFeastEvent.isActor)
				{
					OxNPC.GGFJGHHHEJC.StartConversation(1, "Festín del Juramento/PresentacionMaestros 02");
					break;
				}
				_003C_003E2__current = OxNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
				_003C_003E1__state = 7;
				return true;
			case 7:
				{
					_003C_003E1__state = -1;
					break;
				}
				IL_01e6:
				MusicController.instance.FadeOutClip(2f, MMEHJCGGNFE: true);
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 5;
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

	[CompilerGenerated]
	private sealed class HDKJPBPDOEH : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OathFeastEvent _003C_003E4__this;

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
		public HDKJPBPDOEH(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00df: Unknown result type (might be due to invalid IL or missing references)
			//IL_0113: Unknown result type (might be due to invalid IL or missing references)
			//IL_0118: Unknown result type (might be due to invalid IL or missing references)
			//IL_014c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0151: Unknown result type (might be due to invalid IL or missing references)
			//IL_0185: Unknown result type (might be due to invalid IL or missing references)
			//IL_018a: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			OathFeastEvent oathFeastEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				if (OnlineManager.MasterOrOffline())
				{
					TweekNPC.GGFJGHHHEJC.animationBase.SetTrigger("Jump");
					((Renderer)TweekNPC.GGFJGHHHEJC.KIIEOIGDPFF.npcSprite).sortingOrder = 0;
					_003C_003E2__current = CommonReferences.wait05;
					_003C_003E1__state = 1;
					return true;
				}
				goto IL_01dd;
			case 1:
				_003C_003E1__state = -1;
				TweekNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(oathFeastEvent.spawn[5].position), Direction.Down, AMEOKNOLILB: true);
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				RibellaNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(oathFeastEvent.spawn[4].position), Direction.Down, AMEOKNOLILB: true);
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 3;
				return true;
			case 3:
				_003C_003E1__state = -1;
				OxNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(oathFeastEvent.spawn[3].position), Direction.Down, AMEOKNOLILB: true);
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 4;
				return true;
			case 4:
				_003C_003E1__state = -1;
				PuddingNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(oathFeastEvent.spawn[2].position), Direction.Down, AMEOKNOLILB: true);
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 5;
				return true;
			case 5:
				_003C_003E1__state = -1;
				OrwinIINPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(oathFeastEvent.spawn[1].position), Direction.Down, AMEOKNOLILB: true);
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 6;
				return true;
			case 6:
				_003C_003E1__state = -1;
				KyrohNPC.GGFJGHHHEJC.animationBase.SetBool("Crouch", EGFGNGJGBOP: false);
				KyrohNPC.GGFJGHHHEJC.animationBase.SetBool("Random", EGFGNGJGBOP: false);
				goto IL_01dd;
			case 7:
				_003C_003E1__state = -1;
				_003C_003E2__current = OnlineManager.WaitForAllPlayers();
				_003C_003E1__state = 8;
				return true;
			case 8:
				_003C_003E1__state = -1;
				if (oathFeastEvent.isActor)
				{
					KlaynNPC.instance.StartConversation(1, "Festín del Juramento/KlaynDialogue 04");
					break;
				}
				_003C_003E2__current = KlaynNPC.instance.StartObserverDialogueWhenItIsPossible(1);
				_003C_003E1__state = 9;
				return true;
			case 9:
				{
					_003C_003E1__state = -1;
					break;
				}
				IL_01dd:
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 7;
				return true;
			}
			DialogueCameraTarget.IntroMastersEventCamController2(JCFILMOCAKK: false);
			DialogueCameraTarget.GetPlayer(1).cameraInEvent = false;
			if (OnlineManager.MasterOrOffline())
			{
				oathFeastEvent.FinalDialogueMai();
				KyrohNPC.GGFJGHHHEJC.ChangeState(KyrohState.Inactive);
				((Renderer)(KyrohNPC.GGFJGHHHEJC.animationBase as NPCAnimation).npcSprite).sortingOrder = 0;
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
	private sealed class PFGOIAAOOPA : IEnumerator<object>, IEnumerator, IDisposable
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
		public PFGOIAAOOPA(int _003C_003E1__state)
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
				MaiNPC.GGFJGHHHEJC.ResetMai();
				if (OnlineManager.IsMasterClient())
				{
					OnlineEventsManager.SendEndMaiEvent();
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
	private sealed class LOBGMNAIOIM : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OathFeastEvent _003C_003E4__this;

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
		public LOBGMNAIOIM(int _003C_003E1__state)
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
			OathFeastEvent oathFeastEvent = _003C_003E4__this;
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
				goto IL_0067;
			case 3:
				{
					_003C_003E1__state = -1;
					MaiNPC.GGFJGHHHEJC.StartConversation(oathFeastEvent.triggerPlayerNum, "Festín del Juramento/MaiDialogue 05");
					return false;
				}
				IL_0046:
				if (!oathFeastEvent.DMMFNMNKJLL())
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
				goto IL_0067;
				IL_0067:
				if (TavernManager.IsOpen())
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 2;
					return true;
				}
				MaiNPC.GGFJGHHHEJC.ActiveMaiInBar();
				if (OnlineManager.PlayingOnline())
				{
					OnlineOathFeastManager.instance.SendActiveMaiInBar();
				}
				_003C_003E2__current = CommonReferences.wait1;
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

	[CompilerGenerated]
	private sealed class OIOBEEHEMCN : IEnumerator<object>, IEnumerator, IDisposable
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
		public OIOBEEHEMCN(int _003C_003E1__state)
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
				MusicController.instance.TriggerMusicTheme(24);
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
	private sealed class BLGHJLLJIPC : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

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
		public BLGHJLLJIPC(int _003C_003E1__state)
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
				FadeCamera.GetPlayer(1).JDKHJJIOLOE -= GBCOLIOIDNJ;
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				RefereeNPC.GGFJGHHHEJC.barkDialogue = false;
				_003C_003E2__current = OnlineManager.WaitForAllPlayers();
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				if (instance.isActor)
				{
					RefereeNPC.GGFJGHHHEJC.StartConversation(1, "Festín del Juramento/JudgeDialogue 03");
					break;
				}
				_003C_003E2__current = RefereeNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(playerNum);
				_003C_003E1__state = 3;
				return true;
			case 3:
				_003C_003E1__state = -1;
				break;
			}
			PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
			if (GameManager.LocalCoop())
			{
				BanquetRoundsManager.instance.BlockPlayers();
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
	private sealed class APJNIONNGLB : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OathFeastEvent _003C_003E4__this;

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
		public APJNIONNGLB(int _003C_003E1__state)
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
			OathFeastEvent oathFeastEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				FadeCamera.GetPlayer(1).JDKHJJIOLOE -= oathFeastEvent.MNKGGKNKMON;
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				_003C_003E2__current = OnlineManager.WaitForAllPlayers();
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				if (!oathFeastEvent.isActor)
				{
					_003C_003E2__current = CommonReferences.wait1;
					_003C_003E1__state = 3;
					return true;
				}
				goto IL_00a5;
			case 3:
				_003C_003E1__state = -1;
				goto IL_00a5;
			case 4:
				_003C_003E1__state = -1;
				break;
			case 5:
				{
					_003C_003E1__state = -1;
					break;
				}
				IL_00a5:
				if (ChallengePointsSystem.IsAnyPlayerWinning())
				{
					if (OnlineManager.MasterOrOffline())
					{
						ChallengePointsSystem.SaveHostRecordWhenWinning();
					}
					_003C_003E2__current = oathFeastEvent.HOGMINHBAHL();
					_003C_003E1__state = 4;
					return true;
				}
				_003C_003E2__current = oathFeastEvent.CNBFOFBIECG();
				_003C_003E1__state = 5;
				return true;
			}
			PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)oathFeastEvent);
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
	private sealed class FDCJHNDAFJI : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OathFeastEvent _003C_003E4__this;

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
		public FDCJHNDAFJI(int _003C_003E1__state)
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
			OathFeastEvent oathFeastEvent = _003C_003E4__this;
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
				FadeCamera.GetPlayer(1).JDKHJJIOLOE -= oathFeastEvent.HHGEKEKHDNK;
				FadeCamera.GetPlayer(1).FadeInWithDelay();
				FadeCamera player = FadeCamera.GetPlayer(1);
				player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(oathFeastEvent.GEHNCBAJNKP));
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
	private sealed class DJLBHAOELFK : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OathFeastEvent _003C_003E4__this;

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
		public DJLBHAOELFK(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			OathFeastEvent hFKNIAIFFCB = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				FadeCamera.GetPlayer(1).JDKHJJIOLOE -= hFKNIAIFFCB.CFGCIINPPFF;
				BanquetRoundsManager.instance.RestartAllCharactersPositionsWaitingPlayers();
				if (GameManager.LocalCoop())
				{
					LocalCooperativeManager.FocusCameraToPlayerInLocalCoop(1);
				}
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				FadeCamera.GetPlayer(1).FadeInWithDelay();
				FadeCamera.GetPlayer(1).JDKHJJIOLOE += hFKNIAIFFCB.MNKGGKNKMON;
				if (GameManager.LocalCoop())
				{
					((Component)PlayerController.GetPlayer(2)).transform.position = Vector2.op_Implicit(new Vector2(-989.4792f, 36.22917f));
					PlayerController.GetPlayer(1).characterAnimation.SetDirection(Direction.Down);
					FadeCamera.GetPlayer(2).FadeInWithDelay();
				}
				BanquetEvent.ActivateCameraBounds(HCOPJPMDEKP: false);
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
	private sealed class IICLGGFEIAM : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OathFeastEvent _003C_003E4__this;

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
		public IICLGGFEIAM(int _003C_003E1__state)
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
			OathFeastEvent oathFeastEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				if (OnlineManager.MasterOrOffline())
				{
					(RefereeNPC.GGFJGHHHEJC.animationBase as NPCAnimation).npcSprite.flipX = false;
					RefereeNPC.GGFJGHHHEJC.animationBase.SetTrigger("Winner");
				}
				RefereeNPC.GGFJGHHHEJC.barkDialogue = false;
				if (oathFeastEvent.isActor)
				{
					RefereeNPC.GGFJGHHHEJC.StopConversation();
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
				_003C_003E2__current = RefereeNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
				_003C_003E1__state = 2;
				return true;
			case 1:
				_003C_003E1__state = -1;
				RefereeNPC.GGFJGHHHEJC.StartConversation(1, "Festín del Juramento/Victoria");
				break;
			case 2:
				_003C_003E1__state = -1;
				break;
			}
			BanquetEvent.instance.GiveRewards(CEAFHAIEOLB: true);
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
	private sealed class BDLBNCNLBFD : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OathFeastEvent _003C_003E4__this;

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
		public BDLBNCNLBFD(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			OathFeastEvent oathFeastEvent = _003C_003E4__this;
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
				PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)oathFeastEvent);
				if (GameManager.LocalCoop())
				{
					DialogueCameraTarget.GetPlayer(1).cameraInEvent = true;
					DialogueCameraTarget.GetPlayer(1).MoveCameraToPosition(Vector2.op_Implicit(((Component)DialogueCameraTarget.GetPlayer(1)).transform.position), Vector2.op_Implicit(((Component)KlaynNPC.instance).transform.position));
				}
				else if (instance.isActor)
				{
					DialogueCameraTarget.BarrelEventCamController(JCFILMOCAKK: false);
				}
				else
				{
					DialogueCameraTarget.GetPlayer(1).MoveCameraToPosition(Vector2.op_Implicit(((Component)DialogueCameraTarget.GetPlayer(1)).transform.position), Vector2.op_Implicit(((Component)KlaynNPC.instance).transform.position));
				}
				_003C_003E2__current = OnlineManager.WaitForAllPlayers();
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				if (oathFeastEvent.isActor)
				{
					RefereeNPC.GGFJGHHHEJC.StartConversation(1, "Festín del Juramento/JudgeDialogue 02");
					break;
				}
				_003C_003E2__current = RefereeNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
				_003C_003E1__state = 3;
				return true;
			case 3:
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
	private sealed class IMGKJICHDNA : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public OathFeastEvent _003C_003E4__this;

		private int _003Cindex_003E5__2;

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
		public IMGKJICHDNA(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0100: Unknown result type (might be due to invalid IL or missing references)
			//IL_0131: Unknown result type (might be due to invalid IL or missing references)
			//IL_0162: Unknown result type (might be due to invalid IL or missing references)
			//IL_0193: Unknown result type (might be due to invalid IL or missing references)
			//IL_01da: Unknown result type (might be due to invalid IL or missing references)
			//IL_0282: Unknown result type (might be due to invalid IL or missing references)
			//IL_0287: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0305: Unknown result type (might be due to invalid IL or missing references)
			//IL_030a: Unknown result type (might be due to invalid IL or missing references)
			//IL_033e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0343: Unknown result type (might be due to invalid IL or missing references)
			//IL_0377: Unknown result type (might be due to invalid IL or missing references)
			//IL_037c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0452: Unknown result type (might be due to invalid IL or missing references)
			//IL_048c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0491: Unknown result type (might be due to invalid IL or missing references)
			//IL_0496: Unknown result type (might be due to invalid IL or missing references)
			//IL_0583: Unknown result type (might be due to invalid IL or missing references)
			//IL_0588: Unknown result type (might be due to invalid IL or missing references)
			//IL_0249: Unknown result type (might be due to invalid IL or missing references)
			//IL_024e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0519: Unknown result type (might be due to invalid IL or missing references)
			//IL_051e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0546: Unknown result type (might be due to invalid IL or missing references)
			//IL_054b: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			OathFeastEvent oathFeastEvent = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				ChallengeEventPointsUI.instance.CloseUI();
				MusicController.instance.FadeOutClip(1.5f, MMEHJCGGNFE: true);
				_003C_003E2__current = CommonReferences.wait03;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				DialogueCameraTarget.IntroMastersEventCamController(JCFILMOCAKK: true);
				LucenNPC.GGFJGHHHEJC.content.gameObject.SetActive(true);
				((Component)LucenNPC.GGFJGHHHEJC).transform.position = oathFeastEvent.spawn[0].position;
				OrwinIINPC.GGFJGHHHEJC.content.gameObject.SetActive(true);
				((Component)OrwinIINPC.GGFJGHHHEJC).transform.position = oathFeastEvent.spawn[1].position;
				PuddingNPC.GGFJGHHHEJC.content.gameObject.SetActive(true);
				((Component)PuddingNPC.GGFJGHHHEJC).transform.position = oathFeastEvent.spawn[2].position;
				OxNPC.GGFJGHHHEJC.content.gameObject.SetActive(true);
				((Component)OxNPC.GGFJGHHHEJC).transform.position = oathFeastEvent.spawn[3].position;
				RibellaNPC.GGFJGHHHEJC.content.gameObject.SetActive(true);
				((Component)RibellaNPC.GGFJGHHHEJC).transform.position = oathFeastEvent.spawn[4].position;
				TweekNPC.GGFJGHHHEJC.content.gameObject.SetActive(true);
				TweekNPC.GGFJGHHHEJC.animationBase.SetBool("Roll", EGFGNGJGBOP: true);
				((Component)TweekNPC.GGFJGHHHEJC).transform.position = oathFeastEvent.spawn[5].position;
				if (OnlineManager.ClientOnline())
				{
					_003C_003E2__current = CommonReferences.wait07;
					_003C_003E1__state = 2;
					return true;
				}
				goto IL_0232;
			case 2:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 3;
				return true;
			case 3:
				_003C_003E1__state = -1;
				MusicController.instance.TriggerMusicTheme(26);
				goto IL_0232;
			case 4:
				_003C_003E1__state = -1;
				OrwinIINPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(oathFeastEvent.points[1].position));
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 5;
				return true;
			case 5:
				_003C_003E1__state = -1;
				PuddingNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(oathFeastEvent.points[2].position));
				MusicController.instance.TriggerMusicTheme(26);
				_003C_003E2__current = CommonReferences.wait04;
				_003C_003E1__state = 6;
				return true;
			case 6:
				_003C_003E1__state = -1;
				OxNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(oathFeastEvent.points[3].position));
				_003C_003E2__current = CommonReferences.wait06;
				_003C_003E1__state = 7;
				return true;
			case 7:
				_003C_003E1__state = -1;
				RibellaNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(oathFeastEvent.points[4].position));
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 8;
				return true;
			case 8:
				_003C_003E1__state = -1;
				TweekNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(oathFeastEvent.points[5].position));
				goto IL_0388;
			case 9:
				_003C_003E1__state = -1;
				_003C_003E2__current = OnlineManager.WaitForAllPlayers();
				_003C_003E1__state = 10;
				return true;
			case 10:
				_003C_003E1__state = -1;
				DialogueCameraTarget.GetPlayer(1).cameraInEvent = true;
				DialogueCameraTarget.IntroMastersEventCamController(JCFILMOCAKK: false);
				DialogueCameraTarget.IntroMastersEventCamController2(JCFILMOCAKK: true);
				_003C_003E2__current = CommonReferences.wait2;
				_003C_003E1__state = 11;
				return true;
			case 11:
				_003C_003E1__state = -1;
				((Renderer)(KyrohNPC.GGFJGHHHEJC.animationBase as NPCAnimation).npcSprite).sortingOrder = 1;
				KyrohNPC.GGFJGHHHEJC.content.gameObject.SetActive(true);
				if (OnlineManager.MasterOrOffline())
				{
					KyrohNPC.GGFJGHHHEJC.animationBase.SetBool("Crouch", EGFGNGJGBOP: true);
					((Component)KyrohNPC.GGFJGHHHEJC).transform.position = oathFeastEvent.spawn[6].position;
				}
				_003C_003E2__current = CommonReferences.wait05;
				_003C_003E1__state = 12;
				return true;
			case 12:
				_003C_003E1__state = -1;
				if (OnlineManager.MasterOrOffline())
				{
					KlaynNPC.instance.targetWalkTo = Vector2.op_Implicit(oathFeastEvent.points[6].position);
					KlaynNPC.instance.endWalkDirection = Direction.Up;
					KlaynNPC.instance.ChangeState(KlaynState.WalkTo);
				}
				if (OnlineManager.MasterOrOffline())
				{
					PuddingNPC.GGFJGHHHEJC.animationBase.SetBool("Reverence", EGFGNGJGBOP: true);
					RibellaNPC.GGFJGHHHEJC.animationBase.SetBool("Random", EGFGNGJGBOP: true);
				}
				RefereeNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
				_003Cindex_003E5__2 = Bed.instance.numInstance + 6;
				PlayerController.GetPlayer(1).GoToPosition(Vector2.op_Implicit(oathFeastEvent.points[_003Cindex_003E5__2].position), KLGOCJMGKFO: true);
				if (GameManager.LocalCoop())
				{
					PlayerController.GetPlayer(2).GoToPositionIndependentThread(Vector2.op_Implicit(oathFeastEvent.points[_003Cindex_003E5__2 + 1].position), Direction.Up);
				}
				goto IL_0570;
			case 13:
				_003C_003E1__state = -1;
				goto IL_0570;
			case 14:
				_003C_003E1__state = -1;
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 15;
				return true;
			case 15:
				_003C_003E1__state = -1;
				if (OnlineManager.MasterOrOffline())
				{
					PuddingNPC.GGFJGHHHEJC.animationBase.SetBool("Reverence", EGFGNGJGBOP: false);
					_003C_003E2__current = CommonReferences.wait05;
					_003C_003E1__state = 16;
					return true;
				}
				goto IL_0628;
			case 16:
				_003C_003E1__state = -1;
				RibellaNPC.GGFJGHHHEJC.animationBase.SetBool("Random", EGFGNGJGBOP: false);
				goto IL_0628;
			case 17:
				_003C_003E1__state = -1;
				_003C_003E2__current = OnlineManager.WaitForAllPlayers();
				_003C_003E1__state = 18;
				return true;
			case 18:
				_003C_003E1__state = -1;
				oathFeastEvent.EDGDFPPKGDL = KlaynNPC.instance;
				oathFeastEvent.MDFALJKHKED = "Festín del Juramento/PresentacionMaestros 01";
				if (instance.isActor)
				{
					KlaynNPC.instance.StartConversation(1, "Festín del Juramento/PresentacionMaestros 01");
					break;
				}
				_003C_003E2__current = KlaynNPC.instance.StartObserverDialogueWhenItIsPossible(1);
				_003C_003E1__state = 19;
				return true;
			case 19:
				{
					_003C_003E1__state = -1;
					break;
				}
				IL_0628:
				_003C_003E2__current = CommonReferences.wait1_5;
				_003C_003E1__state = 17;
				return true;
				IL_0570:
				if (!PlayerController.GetPlayer(1).GoToPosition(Vector2.op_Implicit(oathFeastEvent.points[_003Cindex_003E5__2].position), KLGOCJMGKFO: false))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 13;
					return true;
				}
				_003C_003E2__current = PlayerController.GetPlayer(1).characterAnimation.SetDirectionWithDelay(Direction.Up);
				_003C_003E1__state = 14;
				return true;
				IL_0232:
				if (OnlineManager.MasterOrOffline())
				{
					LucenNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(oathFeastEvent.points[0].position));
					_003C_003E2__current = CommonReferences.wait07;
					_003C_003E1__state = 4;
					return true;
				}
				goto IL_0388;
				IL_0388:
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 9;
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

	public static OathFeastEvent instance;

	public Transform[] spawn;

	public Transform[] points;

	public int triggerPlayerNum = 1;

	private readonly Vector2 PNECFFHLIPK = new Vector2(-992.375f, 36.22917f);

	private readonly Vector2 PJBNBACCNLJ = new Vector2(-991.3125f, 36.875f);

	private IEnumerator CAHMPEGEEFF()
	{
		return new HDKJPBPDOEH(1)
		{
			_003C_003E4__this = this
		};
	}

	public void EndMaiEventClientOnline()
	{
		PlayerController.AddMovementBlocker((Object)(object)instance);
		FadeCamera.GetPlayer(1).FadeOut(1f);
		FadeCamera.GetPlayer(1).JDKHJJIOLOE += HHGEKEKHDNK;
	}

	private IEnumerator LOIOGFLLPBM()
	{
		return new LOBGMNAIOIM(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator JCLJEDBGHIC(int JIIGOACEIKL)
	{
		return base.GGJCNNAHOAB(JIIGOACEIKL);
	}

	public static void DKHMDMBABGM()
	{
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance, ANJCLPDCJHL: true);
		FadeCamera.IGMCBPOPNCA(1).JDKHJJIOLOE += LAJPLJGPHOB;
		FadeCamera.INDLIJHGNCL(299f);
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineOathFeastManager.instance.SendStartKlaynCombat();
		}
	}

	private static IEnumerator GIOBFJJMIMH(int JIIGOACEIKL)
	{
		FadeCamera.GetPlayer(1).JDKHJJIOLOE -= GBCOLIOIDNJ;
		yield return CommonReferences.wait1;
		RefereeNPC.GGFJGHHHEJC.barkDialogue = false;
		yield return OnlineManager.WaitForAllPlayers();
		if (instance.isActor)
		{
			RefereeNPC.GGFJGHHHEJC.StartConversation(1, "Festín del Juramento/JudgeDialogue 03");
		}
		else
		{
			yield return RefereeNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(JIIGOACEIKL);
		}
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		if (GameManager.LocalCoop())
		{
			BanquetRoundsManager.instance.BlockPlayers();
		}
	}

	public static void FNJDJGJLNBI()
	{
		PlayerInputs.CMEBIMMKIAB((MonoBehaviour)(object)instance);
		FadeCamera.EIFPKCAFDIB(1).HDDEGMGIBDM(LAJPLJGPHOB);
		FadeCamera.INDLIJHGNCL(1541f);
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineOathFeastManager.instance.KPNKPKHPEEB();
		}
	}

	private IEnumerator DIAGCNGEADB()
	{
		yield return CommonReferences.wait05;
		MaiNPC.GGFJGHHHEJC.SetTrigger("Disappear");
		MaiNPC.GGFJGHHHEJC.ResetMai();
		if (OnlineManager.IsMasterClient())
		{
			OnlineEventsManager.SendEndMaiEvent();
		}
	}

	public void FinalDialogueMai()
	{
		((MonoBehaviour)this).StartCoroutine(NMIPNKKOGBD());
	}

	private IEnumerator LBPMDGCIGCN(int JIIGOACEIKL)
	{
		FadeCamera.GetPlayer(1).JDKHJJIOLOE -= CFGCIINPPFF;
		BanquetRoundsManager.instance.RestartAllCharactersPositionsWaitingPlayers();
		if (GameManager.LocalCoop())
		{
			LocalCooperativeManager.FocusCameraToPlayerInLocalCoop(1);
		}
		yield return null;
		FadeCamera.GetPlayer(1).FadeInWithDelay();
		FadeCamera.GetPlayer(1).JDKHJJIOLOE += MNKGGKNKMON;
		if (GameManager.LocalCoop())
		{
			((Component)PlayerController.GetPlayer(2)).transform.position = Vector2.op_Implicit(new Vector2(-989.4792f, 36.22917f));
			PlayerController.GetPlayer(1).characterAnimation.SetDirection(Direction.Down);
			FadeCamera.GetPlayer(2).FadeInWithDelay();
		}
		BanquetEvent.ActivateCameraBounds(HCOPJPMDEKP: false);
	}

	private IEnumerator FOMNMKCMDCP()
	{
		yield return CommonReferences.wait2;
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)this);
		if (GameManager.LocalCoop())
		{
			DialogueCameraTarget.GetPlayer(1).cameraInEvent = true;
			DialogueCameraTarget.GetPlayer(1).MoveCameraToPosition(Vector2.op_Implicit(((Component)DialogueCameraTarget.GetPlayer(1)).transform.position), Vector2.op_Implicit(((Component)KlaynNPC.instance).transform.position));
		}
		else if (instance.isActor)
		{
			DialogueCameraTarget.BarrelEventCamController(JCFILMOCAKK: false);
		}
		else
		{
			DialogueCameraTarget.GetPlayer(1).MoveCameraToPosition(Vector2.op_Implicit(((Component)DialogueCameraTarget.GetPlayer(1)).transform.position), Vector2.op_Implicit(((Component)KlaynNPC.instance).transform.position));
		}
		yield return OnlineManager.WaitForAllPlayers();
		if (isActor)
		{
			RefereeNPC.GGFJGHHHEJC.StartConversation(1, "Festín del Juramento/JudgeDialogue 02");
		}
		else
		{
			yield return RefereeNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private IEnumerator ECDICNPHEIM(int JIIGOACEIKL)
	{
		yield return null;
		FadeCamera.GetPlayer(1).JDKHJJIOLOE -= HHGEKEKHDNK;
		FadeCamera.GetPlayer(1).FadeInWithDelay();
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(GEHNCBAJNKP));
	}

	private void BGFCHEIOKOG()
	{
		if (!EventsManager.FDIHEFGPKFP((EventsManager.EventType)4))
		{
			CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(GAGMDCHBNLA));
		}
	}

	private IEnumerator JFJLGGKDIGF(int JIIGOACEIKL)
	{
		MaiNPC.GGFJGHHHEJC.ActiveMaiInBed();
		yield return CommonReferences.wait1;
		BanquetEvent.instance.ActivateEvent();
		if (OnlineManager.MasterOrOffline())
		{
			MaiNPC.GGFJGHHHEJC.StartConversation(JIIGOACEIKL, "Festín del Juramento/MaiDialogue 01");
		}
		else
		{
			yield return MaiNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(JIIGOACEIKL);
		}
	}

	public void EndMaiEvent()
	{
		((MonoBehaviour)instance).StartCoroutine(DIAGCNGEADB());
	}

	private void ALGOBMNPLIB()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("MainProgress");
		if (((Result)(ref variable)).asInt == 4 && CommonReferences.GGFJGHHHEJC.eventNum[3] >= 2 && !EventsManager.IsActive(EventsManager.EventType.OathFeast))
		{
			((MonoBehaviour)this).StartCoroutine(JFJLGGKDIGF(1));
			return;
		}
		variable = DialogueLua.GetVariable("MainProgress");
		if (((Result)(ref variable)).asInt == 4 && !EventsManager.IsActive(EventsManager.EventType.OathFeast))
		{
			CommonReferences.GGFJGHHHEJC.eventNum[3]++;
		}
		else if (EventsManager.IsDone(EventsManager.EventType.OathFeast))
		{
			BanquetEvent.instance.DeactivateEvent();
			CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
			commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(ALGOBMNPLIB));
		}
	}

	private void HFCLLOOCEAD(int JIIGOACEIKL)
	{
		FadeCamera fadeCamera = FadeCamera.IGMCBPOPNCA(0);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(GEHNCBAJNKP));
		PlayerController.RemoveMovementBlocker((Object)(object)instance);
	}

	public void JEGBLBOMOBD()
	{
		PlayerController.AddMovementBlocker((Object)(object)instance);
		FadeCamera.IGMCBPOPNCA(0).GPBOEBGJJPM(881f);
		FadeCamera.GetPlayer(0).ODBKGIJCHHI(ECDICNPHEIM);
	}

	public void KHGLJIHBNBH()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			RefereeNPC.DOIKFJDLKJP().animationBase.SetBool("PlayerBed", EGFGNGJGBOP: true, HALNIEBONKH: true);
		}
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)this);
		FadeCamera.EIFPKCAFDIB(0).HDDEGMGIBDM(LBPMDGCIGCN);
		FadeCamera.FMFFGFJHCOC(14f);
		((MonoBehaviour)this).StartCoroutine(FKKABPPEBFK());
	}

	public static void JOGGIBMLIPB()
	{
		FadeCamera player = FadeCamera.GetPlayer(0);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(BBFHIMIMNKM));
		FadeCamera.INDLIJHGNCL(1057f);
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineOathFeastManager.instance.SendFinishKlaynChallenge();
		}
	}

	private bool CPMHKMEFFBM()
	{
		if (PlayerController.GetPlayer(1).IsTavernLocation())
		{
			triggerPlayerNum = 0;
			return false;
		}
		if (GameManager.LocalCoop() && PlayerController.GetPlayer(1).IsTavernLocation())
		{
			triggerPlayerNum = 4;
			return false;
		}
		return true;
	}

	private IEnumerator FEPAKDOEALF(int JIIGOACEIKL)
	{
		return base.GGJCNNAHOAB(JIIGOACEIKL);
	}

	protected override IEnumerator LNNGFCFBKEN(int JIIGOACEIKL)
	{
		GameActionBarUI.Get(1).Open(1);
		if (GameManager.LocalCoop())
		{
			GameActionBarUI.Get(2).Open(1);
		}
		if (GameManager.LocalCoop())
		{
			LocalCooperativeManager.RestoreCameraInLocalCoop();
		}
		yield return OnlineManager.WaitForAllPlayers();
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)this);
		BanquetEvent.FinishKlaynChallenge();
		TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.CastleGarden, Location.City).StartTravelZone(1);
		if (GameManager.LocalCoop())
		{
			TravelZonesManager.GGFJGHHHEJC.GetTravelZone(Location.CastleGarden, Location.City).StartTravelZone(2);
		}
		OnlineManager.ResetPlayersPreparedToContinue();
	}

	public static void IJDHMCEILMF()
	{
		PlayerInputs.CMEBIMMKIAB((MonoBehaviour)(object)instance);
		FadeCamera.EIFPKCAFDIB(0).HDDEGMGIBDM(LAJPLJGPHOB);
		FadeCamera.KMOEPLNDPEK(1019f);
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineOathFeastManager.instance.EPPPPMBFHKH();
		}
	}

	public void JEICLBMEKHL()
	{
		((MonoBehaviour)this).StartCoroutine(FMOFPEGLAMB(1));
	}

	public static void GNLLKDAKEDP()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.FCPMDEOOCOH());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineOathFeastManager.instance.SendEndIntroMasters();
		}
	}

	private IEnumerator LGPONJOIPFB()
	{
		if (OnlineManager.MasterOrOffline())
		{
			LucenNPC.GGFJGHHHEJC.TriggerAnimation("Hair");
			yield return CommonReferences.wait1;
			LucenNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Up);
			OrwinIINPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Right);
			PuddingNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Left);
			OxNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Right);
			((Component)OxNPC.GGFJGHHHEJC).transform.position = ((Component)OxNPC.GGFJGHHHEJC).transform.position - new Vector3(0.25f, 0f, 0f);
			OxNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Right);
			RibellaNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Left);
			((Component)RibellaNPC.GGFJGHHHEJC).transform.position = ((Component)RibellaNPC.GGFJGHHHEJC).transform.position + new Vector3(0.25f, 0f, 0f);
			RibellaNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Left);
			TweekNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Right);
			KyrohNPC.GGFJGHHHEJC.animationBase.SetBool("Random", EGFGNGJGBOP: true);
			yield return CommonReferences.wait05;
			LucenNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(spawn[0].position), Direction.Down, KEEGDBAAEOG: true);
		}
		else
		{
			yield return CommonReferences.wait1;
			yield return CommonReferences.wait05;
		}
		MusicController.instance.FadeOutClip(2f, MMEHJCGGNFE: true);
		yield return CommonReferences.wait2;
		MusicController.instance.TriggerMusicTheme(24);
		OxNPC.GGFJGHHHEJC.inSpecialEvent = true;
		yield return OnlineManager.WaitForAllPlayers();
		if (isActor)
		{
			OxNPC.GGFJGHHHEJC.StartConversation(1, "Festín del Juramento/PresentacionMaestros 02");
		}
		else
		{
			yield return OxNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	public void EEJOCNJJBNL(bool BFLCJPHHDJM = true)
	{
		isActor = BFLCJPHHDJM;
		((MonoBehaviour)this).StartCoroutine(OJKKIHMFDDE());
		CIKGDDCIDAL = 0;
		if (isActor && OnlineManager.PlayingOnline())
		{
			OnlineOathFeastManager.instance.IKEPDNODOFL();
		}
	}

	private static IEnumerator NNPLCKLMIJE(int JIIGOACEIKL)
	{
		return new BLGHJLLJIPC(1)
		{
			playerNum = JIIGOACEIKL
		};
	}

	public void IDLDGKNDEPK()
	{
		((MonoBehaviour)this).StartCoroutine(LOIOGFLLPBM());
	}

	private IEnumerator DPCONIDCDHA(int JIIGOACEIKL)
	{
		return new APJNIONNGLB(1)
		{
			_003C_003E4__this = this
		};
	}

	private void GAGMDCHBNLA()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Items/item_name_644");
		if (((Result)(ref variable)).asInt == 4 && CommonReferences.GGFJGHHHEJC.eventNum[7] >= 3 && !EventsManager.GIJNJBNBMJK(EventsManager.EventType.KlaynTavern))
		{
			((MonoBehaviour)this).StartCoroutine(NCNCLKIAKKI(1));
			return;
		}
		variable = DialogueLua.GetVariable("/");
		if (((Result)(ref variable)).asInt == 5 && !EventsManager.IsActive(EventsManager.EventType.KlaynTavern))
		{
			CommonReferences.MNFMOEKMJKN().eventNum[4] += 0;
		}
		else if (EventsManager.FDIHEFGPKFP(EventsManager.EventType.ThroneRoom))
		{
			BanquetEvent.instance.DeactivateEvent();
			CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
			commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(ALGOBMNPLIB));
		}
	}

	private static IEnumerator GBCOLIOIDNJ(int JIIGOACEIKL)
	{
		FadeCamera.GetPlayer(1).JDKHJJIOLOE -= GBCOLIOIDNJ;
		yield return CommonReferences.wait1;
		RefereeNPC.GGFJGHHHEJC.barkDialogue = false;
		yield return OnlineManager.WaitForAllPlayers();
		if (instance.isActor)
		{
			RefereeNPC.GGFJGHHHEJC.StartConversation(1, "Festín del Juramento/JudgeDialogue 03");
		}
		else
		{
			yield return RefereeNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(JIIGOACEIKL);
		}
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		if (GameManager.LocalCoop())
		{
			BanquetRoundsManager.instance.BlockPlayers();
		}
	}

	public void StartDialogueIntro()
	{
		((MonoBehaviour)this).StartCoroutine(FOMNMKCMDCP());
	}

	public static void GPJDAFALEIK()
	{
		RefereeNPC.NGIMIHFFNMH().content.SetActive(true);
		RefereeNPC.NGIMIHFFNMH().animationBase.CGEADHOLHCH("Moving", EGFGNGJGBOP: true);
		RefereeNPC.OPILDPFDFKJ().animationBase.SetDirection(Direction.Up);
		instance.CBPDNHLJKGA();
		BanquetEvent.OOOIEFMGCNB(HCOPJPMDEKP: true);
	}

	private IEnumerator JMHAHACFLLN(int JIIGOACEIKL)
	{
		return new FDCJHNDAFJI(1)
		{
			_003C_003E4__this = this
		};
	}

	public void StarEvent()
	{
		((MonoBehaviour)this).StartCoroutine(JFJLGGKDIGF(1));
	}

	public void KNCLLFIPENB()
	{
		PlayerController.AddMovementBlocker((Object)(object)instance);
		FadeCamera.GetPlayer(1).IONMINJHMKL(69f);
		FadeCamera.GetPlayer(1).JDKHJJIOLOE += KLEDEBPHNHH;
	}

	public static void AMDPNNCKKEB()
	{
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance, ANJCLPDCJHL: true);
		FadeCamera.GetPlayer(0).ODBKGIJCHHI(LAJPLJGPHOB);
		FadeCamera.KMOEPLNDPEK(654f);
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineOathFeastManager.instance.KMLAEGMIENP();
		}
	}

	private IEnumerator FFJKBKENHLA()
	{
		yield return null;
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)this);
		((Component)RefereeNPC.GGFJGHHHEJC.barrel).gameObject.SetActive(true);
		RefereeNPC.GGFJGHHHEJC.barrel.ResetMovement();
		DialogueCameraTarget.BarrelEventCamController(JCFILMOCAKK: true);
		if (GameManager.LocalCoop())
		{
			LocalCooperativeManager.FocusCameraToPlayerInLocalCoop(1);
		}
	}

	private void Start()
	{
		if (!EventsManager.IsDone(EventsManager.EventType.OathFeast))
		{
			CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(ALGOBMNPLIB));
		}
	}

	private IEnumerator FJAPHJHCDHA()
	{
		ChallengeEventPointsUI.instance.CloseUI();
		MusicController.instance.FadeOutClip(1.5f, MMEHJCGGNFE: true);
		yield return CommonReferences.wait03;
		DialogueCameraTarget.IntroMastersEventCamController(JCFILMOCAKK: true);
		LucenNPC.GGFJGHHHEJC.content.gameObject.SetActive(true);
		((Component)LucenNPC.GGFJGHHHEJC).transform.position = spawn[0].position;
		OrwinIINPC.GGFJGHHHEJC.content.gameObject.SetActive(true);
		((Component)OrwinIINPC.GGFJGHHHEJC).transform.position = spawn[1].position;
		PuddingNPC.GGFJGHHHEJC.content.gameObject.SetActive(true);
		((Component)PuddingNPC.GGFJGHHHEJC).transform.position = spawn[2].position;
		OxNPC.GGFJGHHHEJC.content.gameObject.SetActive(true);
		((Component)OxNPC.GGFJGHHHEJC).transform.position = spawn[3].position;
		RibellaNPC.GGFJGHHHEJC.content.gameObject.SetActive(true);
		((Component)RibellaNPC.GGFJGHHHEJC).transform.position = spawn[4].position;
		TweekNPC.GGFJGHHHEJC.content.gameObject.SetActive(true);
		TweekNPC.GGFJGHHHEJC.animationBase.SetBool("Roll", EGFGNGJGBOP: true);
		((Component)TweekNPC.GGFJGHHHEJC).transform.position = spawn[5].position;
		if (OnlineManager.ClientOnline())
		{
			yield return CommonReferences.wait07;
			yield return CommonReferences.wait05;
			MusicController.instance.TriggerMusicTheme(26);
		}
		if (OnlineManager.MasterOrOffline())
		{
			LucenNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(points[0].position));
			yield return CommonReferences.wait07;
			OrwinIINPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(points[1].position));
			yield return CommonReferences.wait05;
			PuddingNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(points[2].position));
			MusicController.instance.TriggerMusicTheme(26);
			yield return CommonReferences.wait04;
			OxNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(points[3].position));
			yield return CommonReferences.wait06;
			RibellaNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(points[4].position));
			yield return CommonReferences.wait05;
			TweekNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(points[5].position));
		}
		yield return CommonReferences.wait1;
		yield return OnlineManager.WaitForAllPlayers();
		DialogueCameraTarget.GetPlayer(1).cameraInEvent = true;
		DialogueCameraTarget.IntroMastersEventCamController(JCFILMOCAKK: false);
		DialogueCameraTarget.IntroMastersEventCamController2(JCFILMOCAKK: true);
		yield return CommonReferences.wait2;
		((Renderer)(KyrohNPC.GGFJGHHHEJC.animationBase as NPCAnimation).npcSprite).sortingOrder = 1;
		KyrohNPC.GGFJGHHHEJC.content.gameObject.SetActive(true);
		if (OnlineManager.MasterOrOffline())
		{
			KyrohNPC.GGFJGHHHEJC.animationBase.SetBool("Crouch", EGFGNGJGBOP: true);
			((Component)KyrohNPC.GGFJGHHHEJC).transform.position = spawn[6].position;
		}
		yield return CommonReferences.wait05;
		if (OnlineManager.MasterOrOffline())
		{
			KlaynNPC.instance.targetWalkTo = Vector2.op_Implicit(points[6].position);
			KlaynNPC.instance.endWalkDirection = Direction.Up;
			KlaynNPC.instance.ChangeState(KlaynState.WalkTo);
		}
		if (OnlineManager.MasterOrOffline())
		{
			PuddingNPC.GGFJGHHHEJC.animationBase.SetBool("Reverence", EGFGNGJGBOP: true);
			RibellaNPC.GGFJGHHHEJC.animationBase.SetBool("Random", EGFGNGJGBOP: true);
		}
		RefereeNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Up);
		int index = Bed.instance.numInstance + 6;
		PlayerController.GetPlayer(1).GoToPosition(Vector2.op_Implicit(points[index].position), KLGOCJMGKFO: true);
		if (GameManager.LocalCoop())
		{
			PlayerController.GetPlayer(2).GoToPositionIndependentThread(Vector2.op_Implicit(points[index + 1].position), Direction.Up);
		}
		while (!PlayerController.GetPlayer(1).GoToPosition(Vector2.op_Implicit(points[index].position), KLGOCJMGKFO: false))
		{
			yield return null;
		}
		yield return PlayerController.GetPlayer(1).characterAnimation.SetDirectionWithDelay(Direction.Up);
		yield return CommonReferences.wait1;
		if (OnlineManager.MasterOrOffline())
		{
			PuddingNPC.GGFJGHHHEJC.animationBase.SetBool("Reverence", EGFGNGJGBOP: false);
			yield return CommonReferences.wait05;
			RibellaNPC.GGFJGHHHEJC.animationBase.SetBool("Random", EGFGNGJGBOP: false);
		}
		yield return CommonReferences.wait1_5;
		yield return OnlineManager.WaitForAllPlayers();
		EDGDFPPKGDL = KlaynNPC.instance;
		MDFALJKHKED = "Festín del Juramento/PresentacionMaestros 01";
		if (instance.isActor)
		{
			KlaynNPC.instance.StartConversation(1, "Festín del Juramento/PresentacionMaestros 01");
		}
		else
		{
			yield return KlaynNPC.instance.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	public void DBKBPNAOJAE()
	{
		((MonoBehaviour)this).StartCoroutine(KMGBGOENLFF());
	}

	public void GGCCNFEDOIE()
	{
		((MonoBehaviour)this).StartCoroutine(NMIPNKKOGBD());
	}

	public override void LoadGameEvent(bool FAFHGCBNNJO, bool GKECEPMLCNA)
	{
		base.LoadGameEvent(FAFHGCBNNJO, GKECEPMLCNA);
		if (FAFHGCBNNJO)
		{
			BanquetEvent.instance.ActivateEvent();
		}
	}

	private IEnumerator ACJMPGGHCLJ()
	{
		return new PFGOIAAOOPA(1);
	}

	public static void FinishKlaynChallenge()
	{
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(NDEPHPDFGEB));
		FadeCamera.FadeOutAllPlayers();
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineOathFeastManager.instance.SendFinishKlaynChallenge();
		}
	}

	public static void KFGFHJGKCIH()
	{
		if (BanquetEvent.Replaying)
		{
			BanquetEvent.OABOMCNDPLP();
		}
		else
		{
			PlayerInputs.CMEBIMMKIAB((MonoBehaviour)(object)instance);
			EventsManager.KJLBHNLHCNL(EventsManager.EventType.Scolding, POADAPOJIAI: true);
			BanquetEvent.JPEBIDNDOLD(AODONKKHPBP: true);
			((MonoBehaviour)instance).StartCoroutine(instance.KCOOMHBGKBC());
			BanquetDrinksManager.instance.PFCKBEBMOCE(MDIKPGGBNLI: false);
		}
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineOathFeastManager.instance.EJJLLGGMFDM();
		}
	}

	private void GEHNCBAJNKP(int JIIGOACEIKL)
	{
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(GEHNCBAJNKP));
		PlayerController.RemoveMovementBlocker((Object)(object)instance);
	}

	private bool DMMFNMNKJLL()
	{
		if (PlayerController.GetPlayer(1).IsTavernLocation())
		{
			triggerPlayerNum = 1;
			return true;
		}
		if (GameManager.LocalCoop() && PlayerController.GetPlayer(2).IsTavernLocation())
		{
			triggerPlayerNum = 2;
			return true;
		}
		return false;
	}

	public static void AEMELAGBJKH()
	{
		FadeCamera player = FadeCamera.GetPlayer(0);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(NDEPHPDFGEB));
		FadeCamera.CEGBCONNLDP(1206f);
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineOathFeastManager.instance.HGOPKGIICOD();
		}
	}

	private IEnumerator CDEIAIEGAMA()
	{
		return new PFGOIAAOOPA(1);
	}

	public void LOKGMIDCINF()
	{
		((MonoBehaviour)this).StartCoroutine(KMGBGOENLFF());
	}

	private IEnumerator GMBMICJEPEC()
	{
		if (OnlineManager.MasterOrOffline())
		{
			LucenNPC.GGFJGHHHEJC.TriggerAnimation("Hair");
			yield return CommonReferences.wait1;
			LucenNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Up);
			OrwinIINPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Right);
			PuddingNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Left);
			OxNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Right);
			((Component)OxNPC.GGFJGHHHEJC).transform.position = ((Component)OxNPC.GGFJGHHHEJC).transform.position - new Vector3(0.25f, 0f, 0f);
			OxNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Right);
			RibellaNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Left);
			((Component)RibellaNPC.GGFJGHHHEJC).transform.position = ((Component)RibellaNPC.GGFJGHHHEJC).transform.position + new Vector3(0.25f, 0f, 0f);
			RibellaNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Left);
			TweekNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Right);
			KyrohNPC.GGFJGHHHEJC.animationBase.SetBool("Random", EGFGNGJGBOP: true);
			yield return CommonReferences.wait05;
			LucenNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(spawn[0].position), Direction.Down, KEEGDBAAEOG: true);
		}
		else
		{
			yield return CommonReferences.wait1;
			yield return CommonReferences.wait05;
		}
		MusicController.instance.FadeOutClip(2f, MMEHJCGGNFE: true);
		yield return CommonReferences.wait2;
		MusicController.instance.TriggerMusicTheme(24);
		OxNPC.GGFJGHHHEJC.inSpecialEvent = true;
		yield return OnlineManager.WaitForAllPlayers();
		if (isActor)
		{
			OxNPC.GGFJGHHHEJC.StartConversation(1, "Festín del Juramento/PresentacionMaestros 02");
		}
		else
		{
			yield return OxNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	public static void JGKOBKLIANI()
	{
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance, ANJCLPDCJHL: true);
		FadeCamera.GetPlayer(0).JDKHJJIOLOE += LAJPLJGPHOB;
		FadeCamera.INDLIJHGNCL(49f);
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineOathFeastManager.instance.KMLAEGMIENP();
		}
	}

	public void UnlockItems()
	{
		ItemDatabaseAccessor.GetItem(1811).IPGBILAIAPG(CDPAMNIPPEC: true);
	}

	public static void StartCombatEvent()
	{
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		FadeCamera.GetPlayer(1).JDKHJJIOLOE += LAJPLJGPHOB;
		FadeCamera.FadeOutAllPlayers(1f);
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineOathFeastManager.instance.SendStartKlaynCombat();
		}
	}

	public void DELJPMCAAMI()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			RefereeNPC.GGFJGHHHEJC.animationBase.SetBool("Render mode: ", EGFGNGJGBOP: false, HALNIEBONKH: true);
		}
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)this, ANJCLPDCJHL: true);
		FadeCamera.EIFPKCAFDIB(1).JDKHJJIOLOE += NCMBMBNFCHA;
		FadeCamera.INDLIJHGNCL(380f);
		((MonoBehaviour)this).StartCoroutine(JHKEGMPLLCJ());
	}

	public override GameEvent GetInstance()
	{
		return instance;
	}

	public void LKPBLNCLIIB(bool BFLCJPHHDJM = true)
	{
		isActor = BFLCJPHHDJM;
		((MonoBehaviour)this).StartCoroutine(FFJKBKENHLA());
		CIKGDDCIDAL = 0;
		if (isActor && OnlineManager.PlayingOnline())
		{
			OnlineOathFeastManager.instance.IGPNHECPAJK();
		}
	}

	private IEnumerator CFGCIINPPFF(int JIIGOACEIKL)
	{
		FadeCamera.GetPlayer(1).JDKHJJIOLOE -= CFGCIINPPFF;
		BanquetRoundsManager.instance.RestartAllCharactersPositionsWaitingPlayers();
		if (GameManager.LocalCoop())
		{
			LocalCooperativeManager.FocusCameraToPlayerInLocalCoop(1);
		}
		yield return null;
		FadeCamera.GetPlayer(1).FadeInWithDelay();
		FadeCamera.GetPlayer(1).JDKHJJIOLOE += MNKGGKNKMON;
		if (GameManager.LocalCoop())
		{
			((Component)PlayerController.GetPlayer(2)).transform.position = Vector2.op_Implicit(new Vector2(-989.4792f, 36.22917f));
			PlayerController.GetPlayer(1).characterAnimation.SetDirection(Direction.Down);
			FadeCamera.GetPlayer(2).FadeInWithDelay();
		}
		BanquetEvent.ActivateCameraBounds(HCOPJPMDEKP: false);
	}

	public void LFKHNHIDIEK(bool BFLCJPHHDJM = true)
	{
		isActor = BFLCJPHHDJM;
		((MonoBehaviour)this).StartCoroutine(FFJKBKENHLA());
		CIKGDDCIDAL = 0;
		if (isActor && OnlineManager.PlayingOnline())
		{
			OnlineOathFeastManager.instance.NLGLNLFCJAF();
		}
	}

	private IEnumerator NPNDCAJNBCI()
	{
		MusicController.instance.FadeOutClip(2f, MMEHJCGGNFE: true);
		yield return CommonReferences.wait2;
		MusicController.instance.TriggerMusicTheme(24);
	}

	private IEnumerator CJJKIAODIKO()
	{
		return new LGFEIHPJLKL(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NDEPOAMCOOP()
	{
		yield return CommonReferences.wait2;
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)this);
		if (GameManager.LocalCoop())
		{
			DialogueCameraTarget.GetPlayer(1).cameraInEvent = true;
			DialogueCameraTarget.GetPlayer(1).MoveCameraToPosition(Vector2.op_Implicit(((Component)DialogueCameraTarget.GetPlayer(1)).transform.position), Vector2.op_Implicit(((Component)KlaynNPC.instance).transform.position));
		}
		else if (instance.isActor)
		{
			DialogueCameraTarget.BarrelEventCamController(JCFILMOCAKK: false);
		}
		else
		{
			DialogueCameraTarget.GetPlayer(1).MoveCameraToPosition(Vector2.op_Implicit(((Component)DialogueCameraTarget.GetPlayer(1)).transform.position), Vector2.op_Implicit(((Component)KlaynNPC.instance).transform.position));
		}
		yield return OnlineManager.WaitForAllPlayers();
		if (isActor)
		{
			RefereeNPC.GGFJGHHHEJC.StartConversation(1, "Festín del Juramento/JudgeDialogue 02");
		}
		else
		{
			yield return RefereeNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	public static void JDNNPKCKFOF()
	{
		if (BanquetEvent.Replaying)
		{
			BanquetEvent.OABOMCNDPLP();
		}
		else
		{
			PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance, ANJCLPDCJHL: true);
			EventsManager.KEEOLOALKBA(EventsManager.EventType.Scolding, POADAPOJIAI: true);
			BanquetEvent.JPEBIDNDOLD(AODONKKHPBP: false);
			((MonoBehaviour)instance).StartCoroutine(instance.GPOCFJDIPFO());
			BanquetDrinksManager.instance.PFCKBEBMOCE(MDIKPGGBNLI: false);
		}
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineOathFeastManager.instance.DCIDNFIJOGD();
		}
	}

	public static void GKDGNLDIDCK()
	{
		RefereeNPC.MPJJAPCFENH().content.SetActive(true);
		RefereeNPC.OMFKNGDCJFN().animationBase.SetBool("Tutorial/T110/Dialogue1", EGFGNGJGBOP: true);
		RefereeNPC.OAPOJCODNCO().animationBase.SetDirection(Direction.Up);
		instance.CBPDNHLJKGA();
		BanquetEvent.OOOIEFMGCNB(HCOPJPMDEKP: false);
	}

	private IEnumerator FMOFPEGLAMB(int JIIGOACEIKL)
	{
		MaiNPC.GGFJGHHHEJC.ActiveMaiInBed();
		yield return CommonReferences.wait1;
		BanquetEvent.instance.ActivateEvent();
		if (OnlineManager.MasterOrOffline())
		{
			MaiNPC.GGFJGHHHEJC.StartConversation(JIIGOACEIKL, "Festín del Juramento/MaiDialogue 01");
		}
		else
		{
			yield return MaiNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(JIIGOACEIKL);
		}
	}

	public void JJCBGIMGMGH()
	{
		((MonoBehaviour)instance).StartCoroutine(DIAGCNGEADB());
	}

	private IEnumerator KFAPEENNKFL()
	{
		return new PFGOIAAOOPA(1);
	}

	private IEnumerator BALAHGOMNLI(int JIIGOACEIKL)
	{
		return base.GGJCNNAHOAB(JIIGOACEIKL);
	}

	public void KOEPIHKKDID()
	{
		((MonoBehaviour)this).StartCoroutine(FMOFPEGLAMB(1));
	}

	public void HAONCDNFKCA(bool BFLCJPHHDJM = true)
	{
		isActor = BFLCJPHHDJM;
		((MonoBehaviour)this).StartCoroutine(FFJKBKENHLA());
		CIKGDDCIDAL = 1;
		if (isActor && OnlineManager.PlayingOnline())
		{
			OnlineOathFeastManager.instance.FONEKGAIOFG();
		}
	}

	private IEnumerator NBCBKEDOJIE(int JIIGOACEIKL)
	{
		return base.GGJCNNAHOAB(JIIGOACEIKL);
	}

	public static void ECFMLOKFDLD()
	{
		RefereeNPC.OAPOJCODNCO().content.SetActive(true);
		RefereeNPC.JFNOOMJMHCB().animationBase.CGEADHOLHCH("]", EGFGNGJGBOP: false);
		RefereeNPC.KIALFDOKABP().animationBase.SetDirection(Direction.Down);
		instance.CBPDNHLJKGA();
		BanquetEvent.ActivateCameraBounds(HCOPJPMDEKP: false);
	}

	private IEnumerator NCNCLKIAKKI(int JIIGOACEIKL)
	{
		MaiNPC.GGFJGHHHEJC.ActiveMaiInBed();
		yield return CommonReferences.wait1;
		BanquetEvent.instance.ActivateEvent();
		if (OnlineManager.MasterOrOffline())
		{
			MaiNPC.GGFJGHHHEJC.StartConversation(JIIGOACEIKL, "Festín del Juramento/MaiDialogue 01");
		}
		else
		{
			yield return MaiNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(JIIGOACEIKL);
		}
	}

	private IEnumerator IKNCJAMEJED(int JIIGOACEIKL)
	{
		MaiNPC.GGFJGHHHEJC.ActiveMaiInBed();
		yield return CommonReferences.wait1;
		BanquetEvent.instance.ActivateEvent();
		if (OnlineManager.MasterOrOffline())
		{
			MaiNPC.GGFJGHHHEJC.StartConversation(JIIGOACEIKL, "Festín del Juramento/MaiDialogue 01");
		}
		else
		{
			yield return MaiNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(JIIGOACEIKL);
		}
	}

	public static void OPNHBNHJELG()
	{
		PlayerInputs.CMEBIMMKIAB((MonoBehaviour)(object)instance);
		FadeCamera.IGMCBPOPNCA(0).HDDEGMGIBDM(LAJPLJGPHOB);
		FadeCamera.FadeOutAllPlayers(1550f);
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineOathFeastManager.instance.KPNKPKHPEEB();
		}
	}

	private IEnumerator MKAPMGIHIKH()
	{
		yield return null;
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)this);
		((Component)RefereeNPC.GGFJGHHHEJC.barrel).gameObject.SetActive(true);
		RefereeNPC.GGFJGHHHEJC.barrel.ResetMovement();
		DialogueCameraTarget.BarrelEventCamController(JCFILMOCAKK: true);
		if (GameManager.LocalCoop())
		{
			LocalCooperativeManager.FocusCameraToPlayerInLocalCoop(1);
		}
	}

	public static void ANMJNAFIIMO()
	{
		FadeCamera player = FadeCamera.GetPlayer(0);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(BBFHIMIMNKM));
		FadeCamera.INDLIJHGNCL(1047f);
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineOathFeastManager.instance.NHEIGLAGKAJ();
		}
	}

	public static void NPANKEKMPMG()
	{
		RefereeNPC.DOIKFJDLKJP().content.SetActive(false);
		RefereeNPC.MPJJAPCFENH().animationBase.SetBool(" : ", EGFGNGJGBOP: true);
		RefereeNPC.EJHDHCNILDH().animationBase.SetDirection(Direction.Down);
		instance.CBPDNHLJKGA();
		BanquetEvent.ActivateCameraBounds(HCOPJPMDEKP: false);
	}

	private IEnumerator FCPMDEOOCOH()
	{
		if (OnlineManager.MasterOrOffline())
		{
			TweekNPC.GGFJGHHHEJC.animationBase.SetTrigger("Jump");
			((Renderer)TweekNPC.GGFJGHHHEJC.KIIEOIGDPFF.npcSprite).sortingOrder = 0;
			yield return CommonReferences.wait05;
			TweekNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(spawn[5].position), Direction.Down, AMEOKNOLILB: true);
			yield return CommonReferences.wait05;
			RibellaNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(spawn[4].position), Direction.Down, AMEOKNOLILB: true);
			yield return CommonReferences.wait05;
			OxNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(spawn[3].position), Direction.Down, AMEOKNOLILB: true);
			yield return CommonReferences.wait05;
			PuddingNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(spawn[2].position), Direction.Down, AMEOKNOLILB: true);
			yield return CommonReferences.wait05;
			OrwinIINPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(spawn[1].position), Direction.Down, AMEOKNOLILB: true);
			yield return CommonReferences.wait1;
			KyrohNPC.GGFJGHHHEJC.animationBase.SetBool("Crouch", EGFGNGJGBOP: false);
			KyrohNPC.GGFJGHHHEJC.animationBase.SetBool("Random", EGFGNGJGBOP: false);
		}
		yield return CommonReferences.wait2;
		yield return OnlineManager.WaitForAllPlayers();
		if (isActor)
		{
			KlaynNPC.instance.StartConversation(1, "Festín del Juramento/KlaynDialogue 04");
		}
		else
		{
			yield return KlaynNPC.instance.StartObserverDialogueWhenItIsPossible(1);
		}
		DialogueCameraTarget.IntroMastersEventCamController2(JCFILMOCAKK: false);
		DialogueCameraTarget.GetPlayer(1).cameraInEvent = false;
		if (OnlineManager.MasterOrOffline())
		{
			FinalDialogueMai();
			KyrohNPC.GGFJGHHHEJC.ChangeState(KyrohState.Inactive);
			((Renderer)(KyrohNPC.GGFJGHHHEJC.animationBase as NPCAnimation).npcSprite).sortingOrder = 0;
		}
	}

	protected override IEnumerator GGJCNNAHOAB(int JIIGOACEIKL)
	{
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)this);
		yield return base.GGJCNNAHOAB(JIIGOACEIKL);
		BanquetEvent.ActivateCameraBounds(HCOPJPMDEKP: true);
		if (GameManager.LocalCoop())
		{
			LocalCooperativeManager.RestoreCameraInLocalCoop();
		}
		yield return OnlineManager.WaitForAllPlayers();
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)this);
		CBPDNHLJKGA();
		FadeCamera.FadeInAllPlayers();
		BanquetEvent.StartKlaynChallenge(CDPAMNIPPEC: false);
	}

	private IEnumerator HDNOPKLCKGA(int JIIGOACEIKL)
	{
		yield return null;
		FadeCamera.GetPlayer(1).JDKHJJIOLOE -= HHGEKEKHDNK;
		FadeCamera.GetPlayer(1).FadeInWithDelay();
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(GEHNCBAJNKP));
	}

	private void JPOLFKMLHNH()
	{
		if (!EventsManager.OOCOFHECMDA(EventsManager.EventType.Scolding))
		{
			CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
			commonReferences.OnPlayerAwake = (Action)Delegate.Combine(commonReferences.OnPlayerAwake, new Action(GAGMDCHBNLA));
		}
	}

	private IEnumerator LEEFJFJLJPA()
	{
		yield return CommonReferences.wait2;
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)this);
		if (GameManager.LocalCoop())
		{
			DialogueCameraTarget.GetPlayer(1).cameraInEvent = true;
			DialogueCameraTarget.GetPlayer(1).MoveCameraToPosition(Vector2.op_Implicit(((Component)DialogueCameraTarget.GetPlayer(1)).transform.position), Vector2.op_Implicit(((Component)KlaynNPC.instance).transform.position));
		}
		else if (instance.isActor)
		{
			DialogueCameraTarget.BarrelEventCamController(JCFILMOCAKK: false);
		}
		else
		{
			DialogueCameraTarget.GetPlayer(1).MoveCameraToPosition(Vector2.op_Implicit(((Component)DialogueCameraTarget.GetPlayer(1)).transform.position), Vector2.op_Implicit(((Component)KlaynNPC.instance).transform.position));
		}
		yield return OnlineManager.WaitForAllPlayers();
		if (isActor)
		{
			RefereeNPC.GGFJGHHHEJC.StartConversation(1, "Festín del Juramento/JudgeDialogue 02");
		}
		else
		{
			yield return RefereeNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private IEnumerator NBOPINOPCKA()
	{
		return new IICLGGFEIAM(1)
		{
			_003C_003E4__this = this
		};
	}

	public void OOONDOICADN()
	{
		((MonoBehaviour)this).StartCoroutine(NDEPOAMCOOP());
	}

	public void MICPIKIIEOH()
	{
		ItemDatabaseAccessor.KMBGJEKCJFJ(-116, GGBBJNBBLMF: false, DAINLFIMLIH: false).ECHJFKLFIBG(CDPAMNIPPEC: true);
	}

	public void StartIntroMasters()
	{
		StartIntroMastersAction();
	}

	private static void BBFHIMIMNKM(int JIIGOACEIKL)
	{
		if (GameManager.LocalCoop())
		{
			LocalCooperativeManager.AANJNFNNEAP();
		}
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(0);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(NDEPHPDFGEB));
		BanquetEvent.FinishKlaynChallenge();
		FadeCamera.EMMOAIGPGHN(878f);
	}

	public static void EndIntroMasters()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.FCPMDEOOCOH());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineOathFeastManager.instance.SendEndIntroMasters();
		}
	}

	private void MNCDAHNHNMJ()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		Result variable = DialogueLua.GetVariable("Sprout");
		if (((Result)(ref variable)).asInt == 6 && CommonReferences.GGFJGHHHEJC.eventNum[1] >= 7 && !EventsManager.CGPHKBKPCJF(EventsManager.EventType.KyrohWaterfall))
		{
			((MonoBehaviour)this).StartCoroutine(CHGPHJPBAGO(1));
			return;
		}
		variable = DialogueLua.GetVariable("ReceiveResetAllTalents");
		if (((Result)(ref variable)).asInt == 5 && !EventsManager.KEGDEHKPKMP(EventsManager.EventType.OathFeast))
		{
			CommonReferences.MNFMOEKMJKN().eventNum[0]++;
		}
		else if (EventsManager.DOPLDNPIBPP(EventsManager.EventType.KujakuShop))
		{
			BanquetEvent.instance.PFJLHIAAJGD();
			CommonReferences commonReferences = CommonReferences.GGFJGHHHEJC;
			commonReferences.OnPlayerAwake = (Action)Delegate.Remove(commonReferences.OnPlayerAwake, new Action(ALGOBMNPLIB));
		}
	}

	private IEnumerator PDDMLHGENFF(int JIIGOACEIKL)
	{
		FadeCamera.GetPlayer(1).JDKHJJIOLOE -= CFGCIINPPFF;
		BanquetRoundsManager.instance.RestartAllCharactersPositionsWaitingPlayers();
		if (GameManager.LocalCoop())
		{
			LocalCooperativeManager.FocusCameraToPlayerInLocalCoop(1);
		}
		yield return null;
		FadeCamera.GetPlayer(1).FadeInWithDelay();
		FadeCamera.GetPlayer(1).JDKHJJIOLOE += MNKGGKNKMON;
		if (GameManager.LocalCoop())
		{
			((Component)PlayerController.GetPlayer(2)).transform.position = Vector2.op_Implicit(new Vector2(-989.4792f, 36.22917f));
			PlayerController.GetPlayer(1).characterAnimation.SetDirection(Direction.Down);
			FadeCamera.GetPlayer(2).FadeInWithDelay();
		}
		BanquetEvent.ActivateCameraBounds(HCOPJPMDEKP: false);
	}

	public void BOFNEFCPHJB()
	{
		((MonoBehaviour)this).StartCoroutine(KMGBGOENLFF());
	}

	public static void JGFHKEMAGAO()
	{
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		FadeCamera.EIFPKCAFDIB(0).HDDEGMGIBDM(LAJPLJGPHOB);
		FadeCamera.CEGBCONNLDP(1718f);
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineOathFeastManager.instance.LMNJGLINJCH();
		}
	}

	public void JDKOKCGLHAN()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			RefereeNPC.JFNOOMJMHCB().animationBase.CGEADHOLHCH("BanquetDrinksManager instance is null", EGFGNGJGBOP: false, HALNIEBONKH: true);
		}
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)this, ANJCLPDCJHL: true);
		FadeCamera.EIFPKCAFDIB(0).KKAAAOEHGEK(CFGCIINPPFF);
		FadeCamera.INDLIJHGNCL(1724f);
		((MonoBehaviour)this).StartCoroutine(JHKEGMPLLCJ());
	}

	public void CELPAJCMIJH()
	{
		((MonoBehaviour)instance).StartCoroutine(DIAGCNGEADB());
	}

	private IEnumerator GNCOIHDOAFB(int JIIGOACEIKL)
	{
		return new APJNIONNGLB(1)
		{
			_003C_003E4__this = this
		};
	}

	protected override void CBPDNHLJKGA()
	{
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.MasterOrOffline())
		{
			KlaynNPC.instance.ChangeState(KlaynState.Wait);
			((Component)KlaynNPC.instance).transform.position = Vector2.op_Implicit(PNECFFHLIPK);
			KlaynNPC.instance.animationBase.SetDirection(Direction.Down);
			if (Object.op_Implicit((Object)(object)DogNPC.instance) && (Object)(object)DogNPC.instance.playerFollowing != (Object)null)
			{
				DogNPC.instance.ChangeState(DogState.Stopped);
				((Component)DogNPC.instance).transform.position = BanquetEvent.instance.dogPosition.position;
				DogNPC.instance.dogAnimation.SetDirection(Direction.Right);
				DogNPC.instance.dogAnimation.SetBoolWithDelay("Sit", EGFGNGJGBOP: true, 1f);
			}
		}
		((Component)RefereeNPC.GGFJGHHHEJC).transform.position = Vector2.op_Implicit(PJBNBACCNLJ);
		if (!EventsManager.IsDone(EventsManager.EventType.OathFeast))
		{
			((Component)PlayerController.GetPlayer(1)).transform.position = BanquetRoundsManager.instance.startPositionPlayers[Bed.instance.numInstance - 1].position;
			PlayerController.SetDirection(1, Direction.Down);
			if (GameManager.LocalCoop())
			{
				((Component)PlayerController.GetPlayer(2)).transform.position = BanquetRoundsManager.instance.startPositionPlayers[1].position;
				PlayerController.SetDirection(2, Direction.Down);
			}
		}
	}

	private IEnumerator NLFHDNAGCKC()
	{
		if (OnlineManager.MasterOrOffline())
		{
			TweekNPC.GGFJGHHHEJC.animationBase.SetTrigger("Jump");
			((Renderer)TweekNPC.GGFJGHHHEJC.KIIEOIGDPFF.npcSprite).sortingOrder = 0;
			yield return CommonReferences.wait05;
			TweekNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(spawn[5].position), Direction.Down, AMEOKNOLILB: true);
			yield return CommonReferences.wait05;
			RibellaNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(spawn[4].position), Direction.Down, AMEOKNOLILB: true);
			yield return CommonReferences.wait05;
			OxNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(spawn[3].position), Direction.Down, AMEOKNOLILB: true);
			yield return CommonReferences.wait05;
			PuddingNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(spawn[2].position), Direction.Down, AMEOKNOLILB: true);
			yield return CommonReferences.wait05;
			OrwinIINPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(spawn[1].position), Direction.Down, AMEOKNOLILB: true);
			yield return CommonReferences.wait1;
			KyrohNPC.GGFJGHHHEJC.animationBase.SetBool("Crouch", EGFGNGJGBOP: false);
			KyrohNPC.GGFJGHHHEJC.animationBase.SetBool("Random", EGFGNGJGBOP: false);
		}
		yield return CommonReferences.wait2;
		yield return OnlineManager.WaitForAllPlayers();
		if (isActor)
		{
			KlaynNPC.instance.StartConversation(1, "Festín del Juramento/KlaynDialogue 04");
		}
		else
		{
			yield return KlaynNPC.instance.StartObserverDialogueWhenItIsPossible(1);
		}
		DialogueCameraTarget.IntroMastersEventCamController2(JCFILMOCAKK: false);
		DialogueCameraTarget.GetPlayer(1).cameraInEvent = false;
		if (OnlineManager.MasterOrOffline())
		{
			FinalDialogueMai();
			KyrohNPC.GGFJGHHHEJC.ChangeState(KyrohState.Inactive);
			((Renderer)(KyrohNPC.GGFJGHHHEJC.animationBase as NPCAnimation).npcSprite).sortingOrder = 0;
		}
	}

	private static void NDEPHPDFGEB(int JIIGOACEIKL)
	{
		if (GameManager.LocalCoop())
		{
			LocalCooperativeManager.RestoreCameraInLocalCoop();
		}
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Remove(player.OnFadeFinished, new Action<int>(NDEPHPDFGEB));
		BanquetEvent.FinishKlaynChallenge();
		FadeCamera.FadeInAllPlayers();
	}

	private IEnumerator CNBFOFBIECG()
	{
		if (OnlineManager.MasterOrOffline())
		{
			(RefereeNPC.GGFJGHHHEJC.animationBase as NPCAnimation).npcSprite.flipX = true;
			RefereeNPC.GGFJGHHHEJC.animationBase.SetTrigger("Winner");
		}
		RefereeNPC.GGFJGHHHEJC.barkDialogue = false;
		if (OnlineManager.MasterOrOffline())
		{
			RefereeNPC.GGFJGHHHEJC.StopConversation();
			yield return null;
			RefereeNPC.GGFJGHHHEJC.StartConversation(1, "Festín del Juramento/Derrota");
		}
		else
		{
			yield return RefereeNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	public static void StartIntroMastersAction()
	{
		if (BanquetEvent.Replaying)
		{
			BanquetEvent.FinishReplayKlaynChallenge();
		}
		else
		{
			PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance);
			EventsManager.SetDone(EventsManager.EventType.OathFeast, POADAPOJIAI: true);
			BanquetEvent.GGPPFKPOCLL = false;
			((MonoBehaviour)instance).StartCoroutine(instance.FJAPHJHCDHA());
			BanquetDrinksManager.instance.SetVisibleDrinkInBarrels(MDIKPGGBNLI: false);
		}
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineOathFeastManager.instance.SendStartIntroMasters();
		}
	}

	public static void EndIntroLucen()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.GMBMICJEPEC());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineOathFeastManager.instance.SendEndIntroLucen();
		}
	}

	public static void GNNKJJOFPDL()
	{
		PlayerInputs.CMEBIMMKIAB((MonoBehaviour)(object)instance, ANJCLPDCJHL: true);
		FadeCamera.EIFPKCAFDIB(1).BOBBJLPKDBP(LAJPLJGPHOB);
		FadeCamera.CEGBCONNLDP(1844f);
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineOathFeastManager.instance.LMNJGLINJCH();
		}
	}

	private IEnumerator IEEMPCJILDD()
	{
		return new IICLGGFEIAM(1)
		{
			_003C_003E4__this = this
		};
	}

	public void MMKOOPOKEFB()
	{
		((MonoBehaviour)this).StartCoroutine(CHGPHJPBAGO(0));
	}

	public static void KPMHEGHADLC()
	{
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)instance, ANJCLPDCJHL: true);
		FadeCamera.IGMCBPOPNCA(0).HDDEGMGIBDM(LAJPLJGPHOB);
		FadeCamera.CEGBCONNLDP(1241f);
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineOathFeastManager.instance.SendStartKlaynCombat();
		}
	}

	private IEnumerator KFONEPKCFOI()
	{
		return new BDLBNCNLBFD(1)
		{
			_003C_003E4__this = this
		};
	}

	private static IEnumerator LAJPLJGPHOB(int JIIGOACEIKL)
	{
		FadeCamera.GetPlayer(1).JDKHJJIOLOE -= LAJPLJGPHOB;
		if (GameManager.LocalCoop())
		{
			LocalCooperativeManager.RestoreCameraInLocalCoop();
			DialogueCameraTarget.GetPlayer(1).ReturnControlToCameraTarget();
		}
		DialogueCameraTarget.GetPlayer(1).cameraInEvent = false;
		yield return null;
		instance.CBPDNHLJKGA();
		if (!instance.isActor)
		{
			((Behaviour)DialogueCameraTarget.GetPlayer(1).cameraTarget).enabled = true;
			DialogueCameraTarget.GetPlayer(1).AOKFMJNDDPF = false;
		}
		yield return OnlineManager.WaitForAllPlayers();
		FadeCamera.GetPlayer(1).FadeInWithDelay();
		FadeCamera.GetPlayer(1).JDKHJJIOLOE += GBCOLIOIDNJ;
		if (GameManager.LocalCoop())
		{
			((Component)PlayerController.GetPlayer(2)).transform.position = Vector2.op_Implicit(new Vector2(-989.4792f, 36.22917f));
			PlayerController.GetPlayer(1).characterAnimation.SetDirection(Direction.Down);
			FadeCamera.GetPlayer(2).FadeInWithDelay();
		}
		BanquetEvent.instance.crowdNpcs.SetActive(true);
		BanquetEvent.instance.randomNpcs.SetActive(false);
		BanquetEvent.ActivateCameraBounds(HCOPJPMDEKP: true);
	}

	public void PEIMAJHGADD()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			RefereeNPC.MPJJAPCFENH().animationBase.SetBool("Items/item_name_1177", EGFGNGJGBOP: false);
		}
		PlayerInputs.CMEBIMMKIAB((MonoBehaviour)(object)this, ANJCLPDCJHL: true);
		FadeCamera.IGMCBPOPNCA(0).ODBKGIJCHHI(NCMBMBNFCHA);
		FadeCamera.AONDJPKLMDK(1340f);
		((MonoBehaviour)this).StartCoroutine(CCJLFIHLCOP());
	}

	private IEnumerator EKJMJFCLFFA()
	{
		if (OnlineManager.MasterOrOffline())
		{
			(RefereeNPC.GGFJGHHHEJC.animationBase as NPCAnimation).npcSprite.flipX = false;
			RefereeNPC.GGFJGHHHEJC.animationBase.SetTrigger("Winner");
		}
		RefereeNPC.GGFJGHHHEJC.barkDialogue = false;
		if (isActor)
		{
			RefereeNPC.GGFJGHHHEJC.StopConversation();
			yield return null;
			RefereeNPC.GGFJGHHHEJC.StartConversation(1, "Festín del Juramento/Victoria");
		}
		else
		{
			yield return RefereeNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
		BanquetEvent.instance.GiveRewards(CEAFHAIEOLB: true);
	}

	private IEnumerator OLKBCGIFPAC()
	{
		return new HDKJPBPDOEH(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator KLEDEBPHNHH(int JIIGOACEIKL)
	{
		return new FDCJHNDAFJI(1)
		{
			_003C_003E4__this = this
		};
	}

	public void CEDKNEGEKAF()
	{
		ItemDatabaseAccessor.GOKIDLOELKB(-87, GGBBJNBBLMF: false, DAINLFIMLIH: false).ECHJFKLFIBG(CDPAMNIPPEC: true);
	}

	public static void JLJEDDFJEKJ()
	{
		if (BanquetEvent.Replaying)
		{
			BanquetEvent.OABOMCNDPLP();
		}
		else
		{
			PlayerInputs.CMEBIMMKIAB((MonoBehaviour)(object)instance);
			EventsManager.KJLBHNLHCNL(EventsManager.EventType.AdventureContinues, POADAPOJIAI: true);
			BanquetEvent.GGPPFKPOCLL = true;
			((MonoBehaviour)instance).StartCoroutine(instance.GPOCFJDIPFO());
			BanquetDrinksManager.instance.JDFKABIDJKN(MDIKPGGBNLI: false);
		}
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineOathFeastManager.instance.LHJLFKMBAOA();
		}
	}

	private IEnumerator NCMBMBNFCHA(int JIIGOACEIKL)
	{
		return new DJLBHAOELFK(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator HHGEKEKHDNK(int JIIGOACEIKL)
	{
		yield return null;
		FadeCamera.GetPlayer(1).JDKHJJIOLOE -= HHGEKEKHDNK;
		FadeCamera.GetPlayer(1).FadeInWithDelay();
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(GEHNCBAJNKP));
	}

	private IEnumerator MNKGGKNKMON(int JIIGOACEIKL)
	{
		FadeCamera.GetPlayer(1).JDKHJJIOLOE -= MNKGGKNKMON;
		yield return CommonReferences.wait1;
		yield return OnlineManager.WaitForAllPlayers();
		if (!isActor)
		{
			yield return CommonReferences.wait1;
		}
		if (ChallengePointsSystem.IsAnyPlayerWinning())
		{
			if (OnlineManager.MasterOrOffline())
			{
				ChallengePointsSystem.SaveHostRecordWhenWinning();
			}
			yield return HOGMINHBAHL();
		}
		else
		{
			yield return CNBFOFBIECG();
		}
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)this);
	}

	private IEnumerator GPOCFJDIPFO()
	{
		return new IMGKJICHDNA(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NMIPNKKOGBD()
	{
		while (!DMMFNMNKJLL())
		{
			yield return null;
		}
		while (TavernManager.IsOpen())
		{
			yield return null;
		}
		MaiNPC.GGFJGHHHEJC.ActiveMaiInBar();
		if (OnlineManager.PlayingOnline())
		{
			OnlineOathFeastManager.instance.SendActiveMaiInBar();
		}
		yield return CommonReferences.wait1;
		MaiNPC.GGFJGHHHEJC.StartConversation(triggerPlayerNum, "Festín del Juramento/MaiDialogue 05");
	}

	public static void NOBAMOIFCOL()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.LGPONJOIPFB());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineOathFeastManager.instance.HCGOBJAMCAG();
		}
	}

	public void OJGDJLJGLPJ()
	{
		if (OnlineManager.PGAGDFAEEFB())
		{
			RefereeNPC.OMFKNGDCJFN().animationBase.CGEADHOLHCH("ReceiveStartWork", EGFGNGJGBOP: false, HALNIEBONKH: true);
		}
		PlayerInputs.CMEBIMMKIAB((MonoBehaviour)(object)this, ANJCLPDCJHL: true);
		FadeCamera.GetPlayer(0).ODBKGIJCHHI(NCMBMBNFCHA);
		FadeCamera.INDLIJHGNCL(1953f);
		((MonoBehaviour)this).StartCoroutine(NPNDCAJNBCI());
	}

	private IEnumerator OJKKIHMFDDE()
	{
		return new LHFPFABFMHJ(1)
		{
			_003C_003E4__this = this
		};
	}

	public void StartWinnerScene()
	{
		if (OnlineManager.MasterOrOffline())
		{
			RefereeNPC.GGFJGHHHEJC.animationBase.SetBool("Cheer", EGFGNGJGBOP: false);
		}
		PlayerInputs.DisableKeyboardInputsAndMovement((MonoBehaviour)(object)this);
		FadeCamera.GetPlayer(1).JDKHJJIOLOE += CFGCIINPPFF;
		FadeCamera.FadeOutAllPlayers(1f);
		((MonoBehaviour)this).StartCoroutine(NPNDCAJNBCI());
	}

	private IEnumerator IDIOOGLBNFG()
	{
		return new IICLGGFEIAM(1)
		{
			_003C_003E4__this = this
		};
	}

	private void LILIKHHKFEA(int JIIGOACEIKL)
	{
		FadeCamera fadeCamera = FadeCamera.EIFPKCAFDIB(0);
		fadeCamera.OnFadeFinished = (Action<int>)Delegate.Remove(fadeCamera.OnFadeFinished, new Action<int>(HFCLLOOCEAD));
		PlayerController.RemoveMovementBlocker((Object)(object)instance);
	}

	private IEnumerator JHKEGMPLLCJ()
	{
		return new OIOBEEHEMCN(1);
	}

	public void ActiveBarrelIntro(bool BFLCJPHHDJM = true)
	{
		isActor = BFLCJPHHDJM;
		((MonoBehaviour)this).StartCoroutine(FFJKBKENHLA());
		CIKGDDCIDAL = 0;
		if (isActor && OnlineManager.PlayingOnline())
		{
			OnlineOathFeastManager.instance.SendStartIntroBarrel();
		}
	}

	protected override void Awake()
	{
		base.Awake();
		instance = this;
	}

	private IEnumerator KCOOMHBGKBC()
	{
		return new IMGKJICHDNA(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator MPPILGIDGKA()
	{
		if (OnlineManager.MasterOrOffline())
		{
			(RefereeNPC.GGFJGHHHEJC.animationBase as NPCAnimation).npcSprite.flipX = false;
			RefereeNPC.GGFJGHHHEJC.animationBase.SetTrigger("Winner");
		}
		RefereeNPC.GGFJGHHHEJC.barkDialogue = false;
		if (isActor)
		{
			RefereeNPC.GGFJGHHHEJC.StopConversation();
			yield return null;
			RefereeNPC.GGFJGHHHEJC.StartConversation(1, "Festín del Juramento/Victoria");
		}
		else
		{
			yield return RefereeNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
		BanquetEvent.instance.GiveRewards(CEAFHAIEOLB: true);
	}

	private IEnumerator KMGBGOENLFF()
	{
		return new BDLBNCNLBFD(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator PDCPCDCDIFD()
	{
		yield return CommonReferences.wait2;
		PlayerInputs.EnableKeyboardInputsAndMovement((MonoBehaviour)(object)this);
		if (GameManager.LocalCoop())
		{
			DialogueCameraTarget.GetPlayer(1).cameraInEvent = true;
			DialogueCameraTarget.GetPlayer(1).MoveCameraToPosition(Vector2.op_Implicit(((Component)DialogueCameraTarget.GetPlayer(1)).transform.position), Vector2.op_Implicit(((Component)KlaynNPC.instance).transform.position));
		}
		else if (instance.isActor)
		{
			DialogueCameraTarget.BarrelEventCamController(JCFILMOCAKK: false);
		}
		else
		{
			DialogueCameraTarget.GetPlayer(1).MoveCameraToPosition(Vector2.op_Implicit(((Component)DialogueCameraTarget.GetPlayer(1)).transform.position), Vector2.op_Implicit(((Component)KlaynNPC.instance).transform.position));
		}
		yield return OnlineManager.WaitForAllPlayers();
		if (isActor)
		{
			RefereeNPC.GGFJGHHHEJC.StartConversation(1, "Festín del Juramento/JudgeDialogue 02");
		}
		else
		{
			yield return RefereeNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	public void OAOGPDEPMID()
	{
		((MonoBehaviour)this).StartCoroutine(FMOFPEGLAMB(1));
	}

	public void OPJECDMMEJJ()
	{
		ItemDatabaseAccessor.EABMGELAAPG(-149).KGCOBHPFJKD(CDPAMNIPPEC: false);
	}

	private IEnumerator CHGPHJPBAGO(int JIIGOACEIKL)
	{
		return new IMHJBMJLFDC(1)
		{
			playerNum = JIIGOACEIKL
		};
	}

	private IEnumerator JGDJNLCHGFI()
	{
		if (OnlineManager.MasterOrOffline())
		{
			LucenNPC.GGFJGHHHEJC.TriggerAnimation("Hair");
			yield return CommonReferences.wait1;
			LucenNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Up);
			OrwinIINPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Right);
			PuddingNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Left);
			OxNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Right);
			((Component)OxNPC.GGFJGHHHEJC).transform.position = ((Component)OxNPC.GGFJGHHHEJC).transform.position - new Vector3(0.25f, 0f, 0f);
			OxNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Right);
			RibellaNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Left);
			((Component)RibellaNPC.GGFJGHHHEJC).transform.position = ((Component)RibellaNPC.GGFJGHHHEJC).transform.position + new Vector3(0.25f, 0f, 0f);
			RibellaNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Left);
			TweekNPC.GGFJGHHHEJC.animationBase.LookDirection(Direction.Right);
			KyrohNPC.GGFJGHHHEJC.animationBase.SetBool("Random", EGFGNGJGBOP: true);
			yield return CommonReferences.wait05;
			LucenNPC.GGFJGHHHEJC.Walk(Vector2.op_Implicit(spawn[0].position), Direction.Down, KEEGDBAAEOG: true);
		}
		else
		{
			yield return CommonReferences.wait1;
			yield return CommonReferences.wait05;
		}
		MusicController.instance.FadeOutClip(2f, MMEHJCGGNFE: true);
		yield return CommonReferences.wait2;
		MusicController.instance.TriggerMusicTheme(24);
		OxNPC.GGFJGHHHEJC.inSpecialEvent = true;
		yield return OnlineManager.WaitForAllPlayers();
		if (isActor)
		{
			OxNPC.GGFJGHHHEJC.StartConversation(1, "Festín del Juramento/PresentacionMaestros 02");
		}
		else
		{
			yield return OxNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
	}

	private IEnumerator ADBCOJCMJNO(int JIIGOACEIKL)
	{
		yield return null;
		FadeCamera.GetPlayer(1).JDKHJJIOLOE -= HHGEKEKHDNK;
		FadeCamera.GetPlayer(1).FadeInWithDelay();
		FadeCamera player = FadeCamera.GetPlayer(1);
		player.OnFadeFinished = (Action<int>)Delegate.Combine(player.OnFadeFinished, new Action<int>(GEHNCBAJNKP));
	}

	private IEnumerator KDOCJCNGMML(int JIIGOACEIKL)
	{
		return new FDCJHNDAFJI(1)
		{
			_003C_003E4__this = this
		};
	}

	public static void AIOEIFMLALK()
	{
		((MonoBehaviour)instance).StartCoroutine(instance.OLKBCGIFPAC());
		if (instance.isActor && OnlineManager.PlayingOnline())
		{
			OnlineOathFeastManager.instance.KJADFPFEEJG();
		}
	}

	public static void HFELCBPIKJH()
	{
		RefereeNPC.OPILDPFDFKJ().content.SetActive(true);
		RefereeNPC.GGFJGHHHEJC.animationBase.SetBool("Player2", EGFGNGJGBOP: false, HALNIEBONKH: true);
		RefereeNPC.OMFKNGDCJFN().animationBase.SetDirection(Direction.Down);
		instance.CBPDNHLJKGA();
		BanquetEvent.OOOIEFMGCNB(HCOPJPMDEKP: false);
	}

	[DebuggerHidden]
	[CompilerGenerated]
	private IEnumerator LLIJGOCKPBB(int JIIGOACEIKL)
	{
		return base.GGJCNNAHOAB(JIIGOACEIKL);
	}

	private IEnumerator FKKABPPEBFK()
	{
		MusicController.instance.FadeOutClip(2f, MMEHJCGGNFE: true);
		yield return CommonReferences.wait2;
		MusicController.instance.TriggerMusicTheme(24);
	}

	private IEnumerator HOGMINHBAHL()
	{
		if (OnlineManager.MasterOrOffline())
		{
			(RefereeNPC.GGFJGHHHEJC.animationBase as NPCAnimation).npcSprite.flipX = false;
			RefereeNPC.GGFJGHHHEJC.animationBase.SetTrigger("Winner");
		}
		RefereeNPC.GGFJGHHHEJC.barkDialogue = false;
		if (isActor)
		{
			RefereeNPC.GGFJGHHHEJC.StopConversation();
			yield return null;
			RefereeNPC.GGFJGHHHEJC.StartConversation(1, "Festín del Juramento/Victoria");
		}
		else
		{
			yield return RefereeNPC.GGFJGHHHEJC.StartObserverDialogueWhenItIsPossible(1);
		}
		BanquetEvent.instance.GiveRewards(CEAFHAIEOLB: true);
	}

	public static void ActivateReplayCharacters()
	{
		RefereeNPC.GGFJGHHHEJC.content.SetActive(true);
		RefereeNPC.GGFJGHHHEJC.animationBase.SetBool("Cheer", EGFGNGJGBOP: true);
		RefereeNPC.GGFJGHHHEJC.animationBase.SetDirection(Direction.Down);
		instance.CBPDNHLJKGA();
		BanquetEvent.ActivateCameraBounds(HCOPJPMDEKP: true);
	}

	private IEnumerator CCJLFIHLCOP()
	{
		return new OIOBEEHEMCN(1);
	}
}
