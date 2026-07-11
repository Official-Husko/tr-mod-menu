using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using PixelCrushers.DialogueSystem;
using UnityEngine;

public class FishingController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class DGKGJJCPOMI : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FishingController _003C_003E4__this;

		public Vector3 fishPosition;

		public Rod _rod;

		private float _003CfinalTime_003E5__2;

		private bool _003CstartFishMinigame_003E5__3;

		private bool _003CfishingTime_003E5__4;

		private float _003CfinalBiteTime_003E5__5;

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
		public DGKGJJCPOMI(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_010e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0118: Expected O, but got Unknown
			int num = _003C_003E1__state;
			FishingController fishingController = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				fishingController.MLHCLDNJEAG = (fishingController.settings.EASY_FISHING ? fishingController.settings.easyMode : fishingController.settings.normalMode);
				_003C_003E2__current = null;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				FishingUI.Get(fishingController.playerNum).fish = null;
				fishingController.OILGOIDPIOF(fishingController.playerNum, fishPosition);
				fishingController.OnHookThrown?.Invoke((byte)fishingController.playerController.GetDirection());
				_003CfinalTime_003E5__2 = Time.time + (float)fishingController.settings.totalTime;
				_003CstartFishMinigame_003E5__3 = false;
				_003CfishingTime_003E5__4 = false;
				fishingController.OMCCPAOFBBI = Item.MLBOMGHINCA(FishingManager.SelectAFish(fishingController.playerNum, _rod), null);
				_003C_003E2__current = (object)new WaitForSeconds(fishingController.settings.initialDelayTime);
				_003C_003E1__state = 2;
				return true;
			case 2:
				_003C_003E1__state = -1;
				_003CfinalBiteTime_003E5__5 = 0f;
				fishingController.bitesList.Clear();
				if (fishingController.OMCCPAOFBBI)
				{
					fishingController.CreateBitesList();
					_003CfinalBiteTime_003E5__5 = fishingController.bitesList[fishingController.bitesList.Count - 1] + fishingController.settings.realBiteDuration;
				}
				goto IL_0176;
			case 3:
				_003C_003E1__state = -1;
				goto IL_0176;
			case 4:
			{
				_003C_003E1__state = -1;
				Result variable = DialogueLua.GetVariable("LE_10");
				if (((Result)(ref variable)).asInt == 8)
				{
					HikariNPC.GGFJGHHHEJC.ActiveDialogue(fishingController.playerNum);
					_003C_003E2__current = CommonReferences.wait04;
					_003C_003E1__state = 5;
					return true;
				}
				goto IL_0408;
			}
			case 5:
				_003C_003E1__state = -1;
				goto IL_0408;
			case 6:
				_003C_003E1__state = -1;
				goto IL_0408;
			case 7:
				{
					_003C_003E1__state = -1;
					goto IL_0459;
				}
				IL_032e:
				_003C_003E2__current = null;
				_003C_003E1__state = 3;
				return true;
				IL_0408:
				if (CommonReferences.GGFJGHHHEJC.IsInDialogue(fishingController.playerNum))
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 6;
					return true;
				}
				FishingUI.Get(fishingController.playerNum).OpenUI();
				FishingUI.Get(fishingController.playerNum).StartFishingGame(_rod);
				goto IL_0459;
				IL_034a:
				if (_003CstartFishMinigame_003E5__3)
				{
					fishingController.OnFishBite?.Invoke();
					fishingController.fishingHook.SetStruggle(NJHMBMGKCPL: true);
					fishingController.playerController.characterAnimation.SetIdleFishing(NKFPJPCFBJI: false);
					fishingController.playerController.characterAnimation.SetStruggleFishing(NKFPJPCFBJI: true);
					_003C_003E2__current = CommonReferences.wait05;
					_003C_003E1__state = 4;
					return true;
				}
				break;
				IL_0459:
				if (FishingUI.Get(fishingController.playerNum).IsOpen())
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 7;
					return true;
				}
				break;
				IL_01bd:
				if (!_003CfishingTime_003E5__4 && fishingController.bitesList.Count > 0 && Time.time > fishingController.bitesList[0])
				{
					if (fishingController.bitesList.Count == 1)
					{
						_003CfishingTime_003E5__4 = true;
						PlayerInputs.GetPlayer(fishingController.playerNum).SetVibration(0f, 0.3f, 0.5f);
						fishingController.fishingHook.SetBait();
					}
					else
					{
						PlayerInputs.GetPlayer(fishingController.playerNum).SetVibration(0f, 0.1f, 0.05f);
						fishingController.fishingHook.SetFake();
						fishingController.bitesList.RemoveAt(0);
					}
				}
				if (!PlayerInputs.GetPlayer(fishingController.playerNum).GetButtonDown("Use") && !PlayerInputs.GetPlayer(fishingController.playerNum).GetButtonDown("LeftMouseDetect"))
				{
					goto IL_032e;
				}
				if (fishingController.OMCCPAOFBBI & _003CfishingTime_003E5__4)
				{
					fishingController.playerController.emotionController.StartEmotion("Exclamation");
					MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.exclamationFishing, ((Component)PlayerController.GetPlayer(fishingController.playerNum)).transform);
					_003CstartFishMinigame_003E5__3 = true;
				}
				goto IL_034a;
				IL_0176:
				if (!CommonReferences.GGFJGHHHEJC.IsInDialogue(fishingController.playerNum))
				{
					if (fishingController.OMCCPAOFBBI)
					{
						if (!_003CfishingTime_003E5__4 || !(Time.time > _003CfinalBiteTime_003E5__5))
						{
							goto IL_01bd;
						}
					}
					else if (!(Time.time > _003CfinalTime_003E5__2))
					{
						goto IL_01bd;
					}
					goto IL_034a;
				}
				_003CfinalTime_003E5__2 = Time.time + (float)fishingController.settings.totalTime;
				if (fishingController.OMCCPAOFBBI)
				{
					_003CfinalBiteTime_003E5__5 = fishingController.bitesList[fishingController.bitesList.Count - 1] + fishingController.settings.realBiteDuration;
				}
				goto IL_032e;
			}
			fishingController.FinishFishing(_003CstartFishMinigame_003E5__3);
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
	private sealed class PBAKNKJIBFH : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FishingController _003C_003E4__this;

		public Direction direction;

		private Vector2 _003CfishingPosition_003E5__2;

		private Vector2 _003CthrowingPoint_003E5__3;

		private float _003CcurrentLerpTime_003E5__4;

		private float _003CfinalRotation_003E5__5;

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
		public PBAKNKJIBFH(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0145: Unknown result type (might be due to invalid IL or missing references)
			//IL_014a: Unknown result type (might be due to invalid IL or missing references)
			//IL_014f: Unknown result type (might be due to invalid IL or missing references)
			//IL_025c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0261: Unknown result type (might be due to invalid IL or missing references)
			//IL_0276: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0213: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			FishingController fishingController = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				fishingController.AOJKMMOCFCA = direction;
				if (direction == Direction.Up || direction == Direction.Down)
				{
					_003CfishingPosition_003E5__2 = Vector2.op_Implicit(fishingController.playerController.GetPosition() + 2f * Utils.NGFODNCHPHB(direction));
				}
				else
				{
					_003CfishingPosition_003E5__2 = Vector2.op_Implicit(fishingController.playerController.GetPosition() + 4f * Utils.NGFODNCHPHB(direction));
				}
				_003CfishingPosition_003E5__2 = Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(Vector2.op_Implicit(_003CfishingPosition_003E5__2)));
				((Component)fishingController.fishingHook).gameObject.SetActive(true);
				((Renderer)fishingController.fishingHook.spriteRenderer).enabled = true;
				((Component)fishingController.fishingHook).transform.eulerAngles = new Vector3(0f, 0f, 180f);
				goto IL_0122;
			case 1:
				_003C_003E1__state = -1;
				goto IL_0122;
			case 2:
				{
					_003C_003E1__state = -1;
					break;
				}
				IL_0122:
				if (((Component)fishingController.fishingHook.fishingHookPosition).gameObject.activeInHierarchy)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
				_003CthrowingPoint_003E5__3 = Vector2.op_Implicit(fishingController.fishingHook.fishingHookPosition.position);
				_003CcurrentLerpTime_003E5__4 = 0f;
				if (direction == Direction.Left)
				{
					_003CfinalRotation_003E5__5 = 360f;
				}
				else
				{
					_003CfinalRotation_003E5__5 = 0f;
				}
				break;
			}
			if (_003CcurrentLerpTime_003E5__4 / fishingController.settings.time < 1f)
			{
				_003CcurrentLerpTime_003E5__4 += Time.deltaTime;
				if (_003CcurrentLerpTime_003E5__4 < fishingController.settings.time)
				{
					((Component)fishingController.fishingHook).transform.position = fishingController.BBBAJNLEEGB(_003CcurrentLerpTime_003E5__4, _003CthrowingPoint_003E5__3, _003CfishingPosition_003E5__2, fishingController.settings.height, fishingController.settings.time);
					((Component)fishingController.fishingHook).transform.eulerAngles = fishingController.PDINCCBJLIH(_003CcurrentLerpTime_003E5__4, 180f, _003CfinalRotation_003E5__5, fishingController.settings.time);
				}
				_003C_003E2__current = null;
				_003C_003E1__state = 2;
				return true;
			}
			((Component)fishingController.fishingHook).transform.position = Vector2.op_Implicit(_003CfishingPosition_003E5__2);
			((Component)fishingController.fishingHook).transform.eulerAngles = Vector3.zero;
			fishingController.fishingHook.SetWater(NJHMBMGKCPL: true);
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.waterSmallSplash, ((Component)fishingController.fishingHook).transform);
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
	private sealed class FNFOIMNIFLI : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FishingController _003C_003E4__this;

		public Vector3 initialPosition;

		private Vector2 _003CfinalPosition_003E5__2;

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
		public FNFOIMNIFLI(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Expected O, but got Unknown
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0275: Unknown result type (might be due to invalid IL or missing references)
			//IL_018a: Unknown result type (might be due to invalid IL or missing references)
			//IL_018f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0195: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_013f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0144: Unknown result type (might be due to invalid IL or missing references)
			//IL_014a: Unknown result type (might be due to invalid IL or missing references)
			//IL_016b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0222: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			FishingController fishingController = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				fishingController.DBEFBFPAOAA = 0f;
				fishingController.fishingHook.SetStruggle(NJHMBMGKCPL: false);
				_003C_003E2__current = (object)new WaitForSeconds(fishingController.settings.rollUpWaitTime);
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				_003CfinalPosition_003E5__2 = Vector2.op_Implicit(fishingController.fishingHook.fishingHookPosition.position);
				fishingController.fishingHook.SetFishIcon(null);
				fishingController.fishingHook.SetStruggle(NJHMBMGKCPL: false);
				fishingController.fishingHook.SetWater(NJHMBMGKCPL: false);
				MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.waterSmallSplash, ((Component)fishingController.fishingHook).transform);
				if (fishingController.AOJKMMOCFCA == Direction.Left)
				{
					((Component)fishingController.fishingHook).transform.eulerAngles = new Vector3(0f, 0f, 360f);
				}
				else
				{
					((Component)fishingController.fishingHook).transform.eulerAngles = Vector3.zero;
				}
				break;
			case 2:
				_003C_003E1__state = -1;
				break;
			}
			if (fishingController.DBEFBFPAOAA < fishingController.settings.rollUpTime)
			{
				fishingController.DBEFBFPAOAA += Time.deltaTime;
				if (PlayerController.GetPlayerDirection(fishingController.playerNum) == Direction.Down)
				{
					((Component)fishingController.fishingHook).transform.position = fishingController.BBBAJNLEEGB(fishingController.DBEFBFPAOAA, Vector2.op_Implicit(initialPosition), _003CfinalPosition_003E5__2, fishingController.settings.rollUpHeight + 3f, fishingController.settings.rollUpTime);
				}
				else
				{
					((Component)fishingController.fishingHook).transform.position = fishingController.BBBAJNLEEGB(fishingController.DBEFBFPAOAA, Vector2.op_Implicit(initialPosition), _003CfinalPosition_003E5__2, fishingController.settings.rollUpHeight, fishingController.settings.rollUpTime);
				}
				if (PlayerController.GetPlayerDirection(fishingController.playerNum) == Direction.Left)
				{
					((Component)fishingController.fishingHook).transform.eulerAngles = fishingController.PDINCCBJLIH(fishingController.DBEFBFPAOAA, 360f, 180f, fishingController.settings.rollUpTime);
				}
				else
				{
					((Component)fishingController.fishingHook).transform.eulerAngles = fishingController.PDINCCBJLIH(fishingController.DBEFBFPAOAA, 0f, 180f, fishingController.settings.rollUpTime);
				}
				_003C_003E2__current = null;
				_003C_003E1__state = 2;
				return true;
			}
			((Renderer)fishingController.fishingHook.spriteRenderer).enabled = false;
			((Component)fishingController.fishingHook).transform.eulerAngles = Vector3.zero;
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
	private sealed class DLGCBADMBPP : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FishingController _003C_003E4__this;

		public bool fishMinigameDone;

		public Vector3 initialPosition;

		private bool _003CisKeyFragment_003E5__2;

		private int _003Csize_003E5__3;

		private Vector2 _003CfinalPosition_003E5__4;

		private float _003CcurrentLerpTime_003E5__5;

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
		public DLGCBADMBPP(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0201: Unknown result type (might be due to invalid IL or missing references)
			//IL_0206: Unknown result type (might be due to invalid IL or missing references)
			//IL_020b: Unknown result type (might be due to invalid IL or missing references)
			//IL_06fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_089f: Unknown result type (might be due to invalid IL or missing references)
			//IL_029d: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_03cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_037f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0384: Unknown result type (might be due to invalid IL or missing references)
			//IL_038a: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_01db: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e5: Expected O, but got Unknown
			//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0506: Expected O, but got Unknown
			//IL_033d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0323: Unknown result type (might be due to invalid IL or missing references)
			//IL_0462: Unknown result type (might be due to invalid IL or missing references)
			//IL_042f: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			FishingController fishingController = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003CisKeyFragment_003E5__2 = (Object)(object)fishingController.BBOKEGODFGF != (Object)null;
				if (_003CisKeyFragment_003E5__2 && (!fishMinigameDone || Item.NGIIPJDAMGP(FishingUI.Get(fishingController.playerNum).fish, null)))
				{
					fishingController.BBOKEGODFGF = null;
					_003CisKeyFragment_003E5__2 = false;
				}
				_003Csize_003E5__3 = 0;
				if (fishMinigameDone && Item.MLBOMGHINCA(FishingUI.Get(fishingController.playerNum).fish, null))
				{
					float num2 = Random.Range(0f, 1f);
					num2 *= num2;
					_003Csize_003E5__3 = Mathf.RoundToInt(Mathf.Lerp((float)((Vector2Int)(ref FishingUI.Get(fishingController.playerNum).fish.lenght)).x, (float)((Vector2Int)(ref FishingUI.Get(fishingController.playerNum).fish.lenght)).y, num2));
					if (num2 > 0.95f)
					{
						_003Csize_003E5__3 = ((Vector2Int)(ref FishingUI.Get(fishingController.playerNum).fish.lenght)).y;
					}
					if (_003CisKeyFragment_003E5__2)
					{
						fishingController.OnKeyItemFished?.Invoke();
					}
					else
					{
						fishingController.OnFishCaught?.Invoke((short)FishingUI.Get(fishingController.playerNum).fish.JDJGFAACPFC(), (short)_003Csize_003E5__3);
					}
				}
				else
				{
					fishingController.OnReeledIn?.Invoke();
				}
				fishingController.DBEFBFPAOAA = 0f;
				fishingController.playerController.characterAnimation.SetIdleFishing(NKFPJPCFBJI: false);
				fishingController.playerController.characterAnimation.SetStruggleFishing(NKFPJPCFBJI: false);
				fishingController.fishingHook.SetStruggle(NJHMBMGKCPL: false);
				_003C_003E2__current = (object)new WaitForSeconds(fishingController.settings.rollUpWaitTime);
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				_003CfinalPosition_003E5__4 = Vector2.op_Implicit(fishingController.fishingHook.fishingHookPosition.position);
				if (_003CisKeyFragment_003E5__2 & fishMinigameDone)
				{
					fishingController.fishingHook.SetOtherIcon(fishingController.BBOKEGODFGF.GetSprite());
				}
				else
				{
					fishingController.fishingHook.SetFishIcon(fishMinigameDone ? FishingUI.Get(fishingController.playerNum).fish : null);
				}
				fishingController.fishingHook.SetStruggle(NJHMBMGKCPL: false);
				fishingController.fishingHook.SetWater(NJHMBMGKCPL: false);
				MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.waterSmallSplash, ((Component)fishingController.fishingHook).transform);
				if (fishingController.OMCCPAOFBBI)
				{
					Result variable = DialogueLua.GetVariable("LE_10");
					if (((Result)(ref variable)).asInt > 10 && Random.Range(0, 100) >= PerksDatabaseAccessor.GetPlayerPerkValue(5))
					{
						PlayerInventory.GetPlayer(fishingController.playerNum).RemoveItem(FishingManager.BaitItem(fishingController.baitSelected));
					}
				}
				else
				{
					DialogueManager.Bark("Player/Bark/Fishing/NoFish", ((Component)PlayerController.GetPlayer(fishingController.playerNum)).transform);
				}
				if (PlayerController.GetPlayerDirection(fishingController.playerNum) == Direction.Left)
				{
					((Component)fishingController.fishingHook).transform.eulerAngles = new Vector3(0f, 0f, 360f);
				}
				else
				{
					((Component)fishingController.fishingHook).transform.eulerAngles = Vector3.zero;
				}
				goto IL_0483;
			case 2:
				_003C_003E1__state = -1;
				goto IL_0483;
			case 3:
				_003C_003E1__state = -1;
				fishingController.fishingHook.fishInfo.SetActive(true);
				if (_003CisKeyFragment_003E5__2)
				{
					fishingController.fishingHook.fishIconInfo.sprite = fishingController.BBOKEGODFGF.GetSprite();
					FishingTexts.Get(fishingController.playerNum).ActivateContent(DAEMAAOLHMG: false);
					fishingController.BBOKEGODFGF.OnItemFished();
					fishingController.OnKeyItemFished?.Invoke();
					fishingController.fishingHook.bigSuccessParticles.SetActive(true);
					fishingController.fishingHook.successParticles.SetActive(false);
				}
				else
				{
					fishingController.fishingHook.fishIconInfo.sprite = FishingUI.Get(fishingController.playerNum).fish.icon;
					bool pFBIBFJKHDD = FishingManager.AddToRecordList(FishingUI.Get(fishingController.playerNum).fish, _003Csize_003E5__3);
					FishingTexts.Get(fishingController.playerNum).SetFishInfo(FishingUI.Get(fishingController.playerNum).fish, _003Csize_003E5__3, pFBIBFJKHDD);
					if (_003Csize_003E5__3 > 0)
					{
						fishingController.fishingHook.bigSuccessParticles.SetActive(true);
						fishingController.fishingHook.successParticles.SetActive(false);
						Utils.FKKHJPEMNBG("fishCaught", 1);
					}
					else
					{
						fishingController.fishingHook.bigSuccessParticles.SetActive(false);
						fishingController.fishingHook.successParticles.SetActive(true);
					}
				}
				fishingController.fishingCamera = false;
				fishingController.DCGBADKLANM = 0f;
				_003CcurrentLerpTime_003E5__5 = 0f;
				goto IL_071e;
			case 4:
				_003C_003E1__state = -1;
				goto IL_071e;
			case 5:
				_003C_003E1__state = -1;
				if (_003CisKeyFragment_003E5__2)
				{
					Debug.Log((object)("Key item fished: " + fishingController.BBOKEGODFGF.GetKeyItem().IABAKHPEOAF()));
					PlayerInventory.GetPlayer(fishingController.playerNum).AddItem(fishingController.BBOKEGODFGF.GetKeyItem().JMDALJBNFML(), HMPDLIPFBGD: true);
					fishingController.BBOKEGODFGF = null;
				}
				else
				{
					PlayerInventory.GetPlayer(fishingController.playerNum).AddItem(FishingUI.Get(fishingController.playerNum).fish.JMDALJBNFML(), HMPDLIPFBGD: true);
					if (FishingUI.Get(fishingController.playerNum).fish.fishType == Fish.FishType.Trash)
					{
						Utils.FKKHJPEMNBG("trashCollected", 1);
					}
				}
				_003C_003E2__current = CommonReferences.wait1_5;
				_003C_003E1__state = 6;
				return true;
			case 6:
				_003C_003E1__state = -1;
				fishingController.DCGBADKLANM = 0f;
				_003CcurrentLerpTime_003E5__5 = 0f;
				goto IL_08c0;
			case 7:
				_003C_003E1__state = -1;
				goto IL_08c0;
			case 8:
				{
					_003C_003E1__state = -1;
					fishingController.fishingHook.fishInfo.SetActive(false);
					break;
				}
				IL_08c0:
				if (fishingController.DCGBADKLANM < 1f)
				{
					_003CcurrentLerpTime_003E5__5 += Time.deltaTime;
					fishingController.DCGBADKLANM = _003CcurrentLerpTime_003E5__5 / 0.5f;
					FishingTexts.Get(fishingController.playerNum).SetAlpha(Mathf.Lerp(1f, 0f, fishingController.DCGBADKLANM));
					fishingController.fishingHook.fishIconInfo.color = new Color(1f, 1f, 1f, Mathf.Lerp(1f, 0f, fishingController.DCGBADKLANM));
					_003C_003E2__current = null;
					_003C_003E1__state = 7;
					return true;
				}
				fishingController.fishing = false;
				_003C_003E2__current = CommonReferences.wait1_5;
				_003C_003E1__state = 8;
				return true;
				IL_071e:
				if (fishingController.DCGBADKLANM < 1f)
				{
					_003CcurrentLerpTime_003E5__5 += Time.deltaTime;
					fishingController.DCGBADKLANM = _003CcurrentLerpTime_003E5__5 / 0.5f;
					FishingTexts.Get(fishingController.playerNum).SetAlpha(Mathf.Lerp(0f, 1f, fishingController.DCGBADKLANM));
					fishingController.fishingHook.fishIconInfo.color = new Color(1f, 1f, 1f, Mathf.Lerp(0f, 1f, fishingController.DCGBADKLANM));
					_003C_003E2__current = null;
					_003C_003E1__state = 4;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait1_5;
				_003C_003E1__state = 5;
				return true;
				IL_0483:
				if (fishingController.DBEFBFPAOAA < fishingController.settings.rollUpTime)
				{
					fishingController.DBEFBFPAOAA += Time.deltaTime;
					if (PlayerController.GetPlayerDirection(fishingController.playerNum) == Direction.Down)
					{
						((Component)fishingController.fishingHook).transform.position = fishingController.BBBAJNLEEGB(fishingController.DBEFBFPAOAA, Vector2.op_Implicit(initialPosition), _003CfinalPosition_003E5__4, fishingController.settings.rollUpHeight + 3f, fishingController.settings.rollUpTime);
					}
					else
					{
						((Component)fishingController.fishingHook).transform.position = fishingController.BBBAJNLEEGB(fishingController.DBEFBFPAOAA, Vector2.op_Implicit(initialPosition), _003CfinalPosition_003E5__4, fishingController.settings.rollUpHeight, fishingController.settings.rollUpTime);
					}
					if (PlayerController.GetPlayerDirection(fishingController.playerNum) == Direction.Left)
					{
						((Component)fishingController.fishingHook).transform.eulerAngles = fishingController.PDINCCBJLIH(fishingController.DBEFBFPAOAA, 360f, 180f, fishingController.settings.rollUpTime);
					}
					else
					{
						((Component)fishingController.fishingHook).transform.eulerAngles = fishingController.PDINCCBJLIH(fishingController.DBEFBFPAOAA, 0f, 180f, fishingController.settings.rollUpTime);
					}
					_003C_003E2__current = null;
					_003C_003E1__state = 2;
					return true;
				}
				if (fishMinigameDone && Item.MLBOMGHINCA(FishingUI.Get(fishingController.playerNum).fish, null))
				{
					((Component)fishingController.fishingHook).transform.eulerAngles = Vector3.zero;
					((Renderer)fishingController.fishingHook.fishIcon).enabled = false;
					((Renderer)fishingController.fishingHook.spriteRenderer).enabled = false;
					_003C_003E2__current = (object)new WaitForSeconds(0.35f);
					_003C_003E1__state = 3;
					return true;
				}
				fishingController.fishing = false;
				fishingController.fishingCamera = false;
				break;
			}
			if (!fishingController.fishing)
			{
				((Component)fishingController.fishingHook).gameObject.SetActive(false);
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
	private sealed class JHJFBPKEBHG : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FishingController _003C_003E4__this;

		public Fish fish;

		public Vector3 initialPosition;

		public int size;

		private Vector2 _003CfinalPosition_003E5__2;

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
		public JHJFBPKEBHG(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Expected O, but got Unknown
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0112: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_019f: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0154: Unknown result type (might be due to invalid IL or missing references)
			//IL_0159: Unknown result type (might be due to invalid IL or missing references)
			//IL_015f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0180: Unknown result type (might be due to invalid IL or missing references)
			//IL_0237: Unknown result type (might be due to invalid IL or missing references)
			//IL_0204: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			FishingController fishingController = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				fishingController.DBEFBFPAOAA = 0f;
				fishingController.fishingHook.SetStruggle(NJHMBMGKCPL: false);
				_003C_003E2__current = (object)new WaitForSeconds(fishingController.settings.rollUpWaitTime);
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				_003CfinalPosition_003E5__2 = Vector2.op_Implicit(fishingController.fishingHook.fishingHookPosition.position);
				fishingController.fishingHook.SetFishIcon(fish);
				fishingController.fishingHook.SetStruggle(NJHMBMGKCPL: false);
				fishingController.fishingHook.SetWater(NJHMBMGKCPL: false);
				MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.waterSmallSplash, ((Component)fishingController.fishingHook).transform);
				if (fishingController.AOJKMMOCFCA == Direction.Left)
				{
					((Component)fishingController.fishingHook).transform.eulerAngles = new Vector3(0f, 0f, 360f);
				}
				else
				{
					((Component)fishingController.fishingHook).transform.eulerAngles = Vector3.zero;
				}
				goto IL_0258;
			case 2:
				_003C_003E1__state = -1;
				goto IL_0258;
			case 3:
				_003C_003E1__state = -1;
				goto IL_0412;
			case 4:
				_003C_003E1__state = -1;
				fishingController.DCGBADKLANM = 0f;
				fishingController.DBEFBFPAOAA = 0f;
				goto IL_04f1;
			case 5:
				_003C_003E1__state = -1;
				goto IL_04f1;
			case 6:
				{
					_003C_003E1__state = -1;
					fishingController.fishingHook.fishInfo.SetActive(false);
					((Component)fishingController.fishingHook).gameObject.SetActive(false);
					((Renderer)fishingController.fishingHook.spriteRenderer).enabled = true;
					return false;
				}
				IL_04f1:
				if (fishingController.DCGBADKLANM < 1f)
				{
					fishingController.DBEFBFPAOAA += Time.deltaTime;
					fishingController.DCGBADKLANM = fishingController.DBEFBFPAOAA / 0.5f;
					OnlineFishingTexts.Get(fishingController.playerNum).SetAlpha(Mathf.Lerp(1f, 0f, fishingController.DCGBADKLANM));
					fishingController.fishingHook.fishIconInfo.color = new Color(1f, 1f, 1f, Mathf.Lerp(1f, 0f, fishingController.DCGBADKLANM));
					_003C_003E2__current = null;
					_003C_003E1__state = 5;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait1_5;
				_003C_003E1__state = 6;
				return true;
				IL_0258:
				if (fishingController.DBEFBFPAOAA < fishingController.settings.rollUpTime)
				{
					fishingController.DBEFBFPAOAA += Time.deltaTime;
					if (PlayerController.GetPlayerDirection(fishingController.playerNum) == Direction.Down)
					{
						((Component)fishingController.fishingHook).transform.position = fishingController.BBBAJNLEEGB(fishingController.DBEFBFPAOAA, Vector2.op_Implicit(initialPosition), _003CfinalPosition_003E5__2, fishingController.settings.rollUpHeight + 3f, fishingController.settings.rollUpTime);
					}
					else
					{
						((Component)fishingController.fishingHook).transform.position = fishingController.BBBAJNLEEGB(fishingController.DBEFBFPAOAA, Vector2.op_Implicit(initialPosition), _003CfinalPosition_003E5__2, fishingController.settings.rollUpHeight, fishingController.settings.rollUpTime);
					}
					if (PlayerController.GetPlayerDirection(fishingController.playerNum) == Direction.Left)
					{
						((Component)fishingController.fishingHook).transform.eulerAngles = fishingController.PDINCCBJLIH(fishingController.DBEFBFPAOAA, 360f, 180f, fishingController.settings.rollUpTime);
					}
					else
					{
						((Component)fishingController.fishingHook).transform.eulerAngles = fishingController.PDINCCBJLIH(fishingController.DBEFBFPAOAA, 0f, 180f, fishingController.settings.rollUpTime);
					}
					_003C_003E2__current = null;
					_003C_003E1__state = 2;
					return true;
				}
				((Renderer)fishingController.fishingHook.fishIcon).enabled = false;
				((Component)fishingController.fishingHook).gameObject.SetActive(true);
				fishingController.fishingHook.fishInfo.SetActive(true);
				((Renderer)fishingController.fishingHook.spriteRenderer).enabled = false;
				((Component)fishingController.fishingHook).transform.eulerAngles = Vector3.zero;
				((Renderer)fishingController.fishingHook.fishIconInfo).enabled = true;
				fishingController.fishingHook.fishIconInfo.sprite = fish.icon;
				OnlineFishingTexts.Get(fishingController.playerNum).SetFishInfo(fish, size);
				if (size > 0)
				{
					fishingController.fishingHook.bigSuccessParticles.SetActive(true);
					fishingController.fishingHook.successParticles.SetActive(false);
				}
				else
				{
					fishingController.fishingHook.bigSuccessParticles.SetActive(false);
					fishingController.fishingHook.successParticles.SetActive(true);
				}
				fishingController.DCGBADKLANM = 0f;
				fishingController.DBEFBFPAOAA = 0f;
				goto IL_0412;
				IL_0412:
				if (fishingController.DCGBADKLANM < 1f)
				{
					fishingController.DBEFBFPAOAA += Time.deltaTime;
					fishingController.DCGBADKLANM = fishingController.DBEFBFPAOAA / 0.5f;
					OnlineFishingTexts.Get(fishingController.playerNum).SetAlpha(Mathf.Lerp(0f, 1f, fishingController.DCGBADKLANM));
					fishingController.fishingHook.fishIconInfo.color = new Color(1f, 1f, 1f, Mathf.Lerp(0f, 1f, fishingController.DCGBADKLANM));
					_003C_003E2__current = null;
					_003C_003E1__state = 3;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait3;
				_003C_003E1__state = 4;
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
	private sealed class ACNAOMLHONE : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FishingController _003C_003E4__this;

		public MineFishingKeyItem keyItem;

		public Vector3 initialPosition;

		private Vector2 _003CfinalPosition_003E5__2;

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
		public ACNAOMLHONE(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Expected O, but got Unknown
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0117: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_039a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0451: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01af: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_0159: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0164: Unknown result type (might be due to invalid IL or missing references)
			//IL_0185: Unknown result type (might be due to invalid IL or missing references)
			//IL_023c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0209: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			FishingController fishingController = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				fishingController.DBEFBFPAOAA = 0f;
				fishingController.fishingHook.SetStruggle(NJHMBMGKCPL: false);
				_003C_003E2__current = (object)new WaitForSeconds(fishingController.settings.rollUpWaitTime);
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				_003CfinalPosition_003E5__2 = Vector2.op_Implicit(fishingController.fishingHook.fishingHookPosition.position);
				fishingController.fishingHook.SetOtherIcon(keyItem.GetSprite());
				fishingController.fishingHook.SetStruggle(NJHMBMGKCPL: false);
				fishingController.fishingHook.SetWater(NJHMBMGKCPL: false);
				MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.waterSmallSplash, ((Component)fishingController.fishingHook).transform);
				if (fishingController.AOJKMMOCFCA == Direction.Left)
				{
					((Component)fishingController.fishingHook).transform.eulerAngles = new Vector3(0f, 0f, 360f);
				}
				else
				{
					((Component)fishingController.fishingHook).transform.eulerAngles = Vector3.zero;
				}
				goto IL_025d;
			case 2:
				_003C_003E1__state = -1;
				goto IL_025d;
			case 3:
				_003C_003E1__state = -1;
				goto IL_03bb;
			case 4:
				_003C_003E1__state = -1;
				fishingController.DCGBADKLANM = 0f;
				fishingController.DBEFBFPAOAA = 0f;
				goto IL_0472;
			case 5:
				_003C_003E1__state = -1;
				goto IL_0472;
			case 6:
				{
					_003C_003E1__state = -1;
					fishingController.fishingHook.fishInfo.SetActive(false);
					((Component)fishingController.fishingHook).gameObject.SetActive(false);
					((Renderer)fishingController.fishingHook.spriteRenderer).enabled = true;
					return false;
				}
				IL_0472:
				if (fishingController.DCGBADKLANM < 1f)
				{
					fishingController.DBEFBFPAOAA += Time.deltaTime;
					fishingController.DCGBADKLANM = fishingController.DBEFBFPAOAA / 0.5f;
					fishingController.fishingHook.fishIconInfo.color = new Color(1f, 1f, 1f, Mathf.Lerp(1f, 0f, fishingController.DCGBADKLANM));
					_003C_003E2__current = null;
					_003C_003E1__state = 5;
					return true;
				}
				keyItem.OnItemFished();
				_003C_003E2__current = CommonReferences.wait1_5;
				_003C_003E1__state = 6;
				return true;
				IL_025d:
				if (fishingController.DBEFBFPAOAA < fishingController.settings.rollUpTime)
				{
					fishingController.DBEFBFPAOAA += Time.deltaTime;
					if (PlayerController.GetPlayerDirection(fishingController.playerNum) == Direction.Down)
					{
						((Component)fishingController.fishingHook).transform.position = fishingController.BBBAJNLEEGB(fishingController.DBEFBFPAOAA, Vector2.op_Implicit(initialPosition), _003CfinalPosition_003E5__2, fishingController.settings.rollUpHeight + 3f, fishingController.settings.rollUpTime);
					}
					else
					{
						((Component)fishingController.fishingHook).transform.position = fishingController.BBBAJNLEEGB(fishingController.DBEFBFPAOAA, Vector2.op_Implicit(initialPosition), _003CfinalPosition_003E5__2, fishingController.settings.rollUpHeight, fishingController.settings.rollUpTime);
					}
					if (PlayerController.GetPlayerDirection(fishingController.playerNum) == Direction.Left)
					{
						((Component)fishingController.fishingHook).transform.eulerAngles = fishingController.PDINCCBJLIH(fishingController.DBEFBFPAOAA, 360f, 180f, fishingController.settings.rollUpTime);
					}
					else
					{
						((Component)fishingController.fishingHook).transform.eulerAngles = fishingController.PDINCCBJLIH(fishingController.DBEFBFPAOAA, 0f, 180f, fishingController.settings.rollUpTime);
					}
					_003C_003E2__current = null;
					_003C_003E1__state = 2;
					return true;
				}
				((Renderer)fishingController.fishingHook.fishIcon).enabled = false;
				((Component)fishingController.fishingHook).gameObject.SetActive(true);
				fishingController.fishingHook.fishInfo.SetActive(true);
				((Renderer)fishingController.fishingHook.spriteRenderer).enabled = false;
				((Component)fishingController.fishingHook).transform.eulerAngles = Vector3.zero;
				((Renderer)fishingController.fishingHook.fishIconInfo).enabled = true;
				fishingController.fishingHook.fishIconInfo.sprite = keyItem.GetSprite();
				OnlineFishingTexts.Get(fishingController.playerNum).SetAlpha(0f);
				fishingController.fishingHook.bigSuccessParticles.SetActive(true);
				fishingController.fishingHook.successParticles.SetActive(false);
				fishingController.DCGBADKLANM = 0f;
				fishingController.DBEFBFPAOAA = 0f;
				goto IL_03bb;
				IL_03bb:
				if (fishingController.DCGBADKLANM < 1f)
				{
					fishingController.DBEFBFPAOAA += Time.deltaTime;
					fishingController.DCGBADKLANM = fishingController.DBEFBFPAOAA / 0.5f;
					fishingController.fishingHook.fishIconInfo.color = new Color(1f, 1f, 1f, Mathf.Lerp(0f, 1f, fishingController.DCGBADKLANM));
					_003C_003E2__current = null;
					_003C_003E1__state = 3;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait3;
				_003C_003E1__state = 4;
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
	private sealed class LGAFAMAHFCE : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FishingController _003C_003E4__this;

		public int playerNum;

		public Vector2 fallPoint;

		private Vector2 _003CthrowingPoint_003E5__2;

		private float _003CcurrentLerpTime_003E5__3;

		private float _003CfinalRotation_003E5__4;

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
		public LGAFAMAHFCE(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0109: Unknown result type (might be due to invalid IL or missing references)
			//IL_010f: Unknown result type (might be due to invalid IL or missing references)
			//IL_012a: Unknown result type (might be due to invalid IL or missing references)
			//IL_015c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0268: Unknown result type (might be due to invalid IL or missing references)
			//IL_026d: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			FishingController fishingController = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				((Component)fishingController.fishingHook).transform.eulerAngles = new Vector3(0f, 0f, 180f);
				goto IL_0066;
			case 1:
				_003C_003E1__state = -1;
				goto IL_0066;
			case 2:
				{
					_003C_003E1__state = -1;
					break;
				}
				IL_0066:
				if (((Component)fishingController.fishingHook.fishingHookPosition).gameObject.activeInHierarchy)
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
				_003CthrowingPoint_003E5__2 = Vector2.op_Implicit(fishingController.fishingHook.fishingHookPosition.position);
				_003CcurrentLerpTime_003E5__3 = 0f;
				if (PlayerController.GetPlayerDirection(playerNum) == Direction.Left)
				{
					_003CfinalRotation_003E5__4 = 360f;
				}
				else
				{
					_003CfinalRotation_003E5__4 = 0f;
				}
				break;
			}
			if (_003CcurrentLerpTime_003E5__3 / fishingController.settings.time < 1f)
			{
				_003CcurrentLerpTime_003E5__3 += Time.deltaTime;
				if (_003CcurrentLerpTime_003E5__3 < fishingController.settings.time)
				{
					((Component)fishingController.fishingHook).transform.position = fishingController.BBBAJNLEEGB(_003CcurrentLerpTime_003E5__3, _003CthrowingPoint_003E5__2, fallPoint, fishingController.settings.height, fishingController.settings.time);
					((Component)fishingController.fishingHook).transform.eulerAngles = fishingController.PDINCCBJLIH(_003CcurrentLerpTime_003E5__3, 180f, _003CfinalRotation_003E5__4, fishingController.settings.time);
				}
				_003C_003E2__current = null;
				_003C_003E1__state = 2;
				return true;
			}
			((Component)fishingController.fishingHook).transform.position = Vector2.op_Implicit(fallPoint);
			((Component)fishingController.fishingHook).transform.eulerAngles = Vector3.zero;
			fishingController.fishingHook.SetWater(NJHMBMGKCPL: true);
			PlayerInputs.GetPlayer(playerNum).SetVibration(0.1f, 0f, 0.2f);
			PlayerInputs.GetPlayer(playerNum).SetVibration(0f, 0.3f, 0.5f);
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.waterSmallSplash, ((Component)fishingController.fishingHook).transform);
			fishingController.BBOKEGODFGF = null;
			MineFishingKeyItem mineFishingKeyItem = ProceduralMine.GetCurrentLevel()?.puzzleManager?.GetKeyFishingSpot();
			if ((Object)(object)mineFishingKeyItem != (Object)null && mineFishingKeyItem.IsHookInRange(Vector2.op_Implicit(((Component)fishingController.fishingHook).transform.position)))
			{
				fishingController.BBOKEGODFGF = mineFishingKeyItem;
			}
			FishingUI.Get(playerNum).SetFishingIcon(fishingController.BBOKEGODFGF);
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

	public Action<short, short> OnFishCaught = delegate
	{
	};

	public Action<byte> OnHookThrown = delegate
	{
	};

	public Action OnFishBite = delegate
	{
	};

	public Action OnReeledIn = delegate
	{
	};

	public Action OnKeyItemFished = delegate
	{
	};

	[SerializeField]
	private FishingManagerSettings settings;

	private FishingManagerSettings.DifficultySettings MLHCLDNJEAG;

	public int playerNum;

	public bool fishing;

	[HideInInspector]
	public bool fishingCamera;

	public List<float> bitesList = new List<float>();

	public Fish.BaitType baitSelected;

	public FishingHook fishingHook;

	[SerializeField]
	private PlayerController playerController;

	private float DCGBADKLANM;

	private float IFKKOJDLPBH;

	private float AJLNHKCPHCE;

	private bool OMCCPAOFBBI;

	private Direction AOJKMMOCFCA;

	private MineFishingKeyItem BBOKEGODFGF;

	private Vector3 KGHICGONENB;

	private Vector3 KCGMEPNOEEL;

	private Vector3 DHOKFGFAMEK;

	private Vector3 BDHLADGNJJL;

	private float DBEFBFPAOAA;

	private Vector3 PDINCCBJLIH(float DBEFBFPAOAA, float GDBONJNKLCD, float MEOEHBFJOAN, float AMOLDGGJMKF)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		DCGBADKLANM = DBEFBFPAOAA / AMOLDGGJMKF;
		return new Vector3(0f, 0f, Mathf.Lerp(GDBONJNKLCD, MEOEHBFJOAN, DCGBADKLANM));
	}

	public void LPPDGNMMNHE()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		((MonoBehaviour)this).StartCoroutine(DHDCKBLIBPG(((Component)fishingHook).transform.position));
	}

	private IEnumerator BHNILHCNOBO(Vector3 NOLFMLNLJJG, MineFishingKeyItem FPBPEAAIOBK)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		DBEFBFPAOAA = 0f;
		fishingHook.SetStruggle(NJHMBMGKCPL: false);
		yield return (object)new WaitForSeconds(settings.rollUpWaitTime);
		Vector2 finalPosition = Vector2.op_Implicit(fishingHook.fishingHookPosition.position);
		fishingHook.SetOtherIcon(FPBPEAAIOBK.GetSprite());
		fishingHook.SetStruggle(NJHMBMGKCPL: false);
		fishingHook.SetWater(NJHMBMGKCPL: false);
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.waterSmallSplash, ((Component)fishingHook).transform);
		if (AOJKMMOCFCA == Direction.Left)
		{
			((Component)fishingHook).transform.eulerAngles = new Vector3(0f, 0f, 360f);
		}
		else
		{
			((Component)fishingHook).transform.eulerAngles = Vector3.zero;
		}
		while (DBEFBFPAOAA < settings.rollUpTime)
		{
			DBEFBFPAOAA += Time.deltaTime;
			if (PlayerController.GetPlayerDirection(playerNum) == Direction.Down)
			{
				((Component)fishingHook).transform.position = BBBAJNLEEGB(DBEFBFPAOAA, Vector2.op_Implicit(NOLFMLNLJJG), finalPosition, settings.rollUpHeight + 3f, settings.rollUpTime);
			}
			else
			{
				((Component)fishingHook).transform.position = BBBAJNLEEGB(DBEFBFPAOAA, Vector2.op_Implicit(NOLFMLNLJJG), finalPosition, settings.rollUpHeight, settings.rollUpTime);
			}
			if (PlayerController.GetPlayerDirection(playerNum) == Direction.Left)
			{
				((Component)fishingHook).transform.eulerAngles = PDINCCBJLIH(DBEFBFPAOAA, 360f, 180f, settings.rollUpTime);
			}
			else
			{
				((Component)fishingHook).transform.eulerAngles = PDINCCBJLIH(DBEFBFPAOAA, 0f, 180f, settings.rollUpTime);
			}
			yield return null;
		}
		((Renderer)fishingHook.fishIcon).enabled = false;
		((Component)fishingHook).gameObject.SetActive(true);
		fishingHook.fishInfo.SetActive(true);
		((Renderer)fishingHook.spriteRenderer).enabled = false;
		((Component)fishingHook).transform.eulerAngles = Vector3.zero;
		((Renderer)fishingHook.fishIconInfo).enabled = true;
		fishingHook.fishIconInfo.sprite = FPBPEAAIOBK.GetSprite();
		OnlineFishingTexts.Get(playerNum).SetAlpha(0f);
		fishingHook.bigSuccessParticles.SetActive(true);
		fishingHook.successParticles.SetActive(false);
		DCGBADKLANM = 0f;
		DBEFBFPAOAA = 0f;
		while (DCGBADKLANM < 1f)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / 0.5f;
			fishingHook.fishIconInfo.color = new Color(1f, 1f, 1f, Mathf.Lerp(0f, 1f, DCGBADKLANM));
			yield return null;
		}
		yield return CommonReferences.wait3;
		DCGBADKLANM = 0f;
		DBEFBFPAOAA = 0f;
		while (DCGBADKLANM < 1f)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / 0.5f;
			fishingHook.fishIconInfo.color = new Color(1f, 1f, 1f, Mathf.Lerp(1f, 0f, DCGBADKLANM));
			yield return null;
		}
		FPBPEAAIOBK.OnItemFished();
		yield return CommonReferences.wait1_5;
		fishingHook.fishInfo.SetActive(false);
		((Component)fishingHook).gameObject.SetActive(false);
		((Renderer)fishingHook.spriteRenderer).enabled = true;
	}

	private void KIIONOCNIED(int JIIGOACEIKL, Vector3 JPIMPMOAAHC)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)fishingHook).gameObject.SetActive(true);
		((MonoBehaviour)this).StartCoroutine(EKBLFFPOHBC(JIIGOACEIKL, Vector2.op_Implicit(JPIMPMOAAHC)));
	}

	private IEnumerator HPHBHJIFMED(Vector3 NOLFMLNLJJG, MineFishingKeyItem FPBPEAAIOBK)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		DBEFBFPAOAA = 0f;
		fishingHook.SetStruggle(NJHMBMGKCPL: false);
		yield return (object)new WaitForSeconds(settings.rollUpWaitTime);
		Vector2 finalPosition = Vector2.op_Implicit(fishingHook.fishingHookPosition.position);
		fishingHook.SetOtherIcon(FPBPEAAIOBK.GetSprite());
		fishingHook.SetStruggle(NJHMBMGKCPL: false);
		fishingHook.SetWater(NJHMBMGKCPL: false);
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.waterSmallSplash, ((Component)fishingHook).transform);
		if (AOJKMMOCFCA == Direction.Left)
		{
			((Component)fishingHook).transform.eulerAngles = new Vector3(0f, 0f, 360f);
		}
		else
		{
			((Component)fishingHook).transform.eulerAngles = Vector3.zero;
		}
		while (DBEFBFPAOAA < settings.rollUpTime)
		{
			DBEFBFPAOAA += Time.deltaTime;
			if (PlayerController.GetPlayerDirection(playerNum) == Direction.Down)
			{
				((Component)fishingHook).transform.position = BBBAJNLEEGB(DBEFBFPAOAA, Vector2.op_Implicit(NOLFMLNLJJG), finalPosition, settings.rollUpHeight + 3f, settings.rollUpTime);
			}
			else
			{
				((Component)fishingHook).transform.position = BBBAJNLEEGB(DBEFBFPAOAA, Vector2.op_Implicit(NOLFMLNLJJG), finalPosition, settings.rollUpHeight, settings.rollUpTime);
			}
			if (PlayerController.GetPlayerDirection(playerNum) == Direction.Left)
			{
				((Component)fishingHook).transform.eulerAngles = PDINCCBJLIH(DBEFBFPAOAA, 360f, 180f, settings.rollUpTime);
			}
			else
			{
				((Component)fishingHook).transform.eulerAngles = PDINCCBJLIH(DBEFBFPAOAA, 0f, 180f, settings.rollUpTime);
			}
			yield return null;
		}
		((Renderer)fishingHook.fishIcon).enabled = false;
		((Component)fishingHook).gameObject.SetActive(true);
		fishingHook.fishInfo.SetActive(true);
		((Renderer)fishingHook.spriteRenderer).enabled = false;
		((Component)fishingHook).transform.eulerAngles = Vector3.zero;
		((Renderer)fishingHook.fishIconInfo).enabled = true;
		fishingHook.fishIconInfo.sprite = FPBPEAAIOBK.GetSprite();
		OnlineFishingTexts.Get(playerNum).SetAlpha(0f);
		fishingHook.bigSuccessParticles.SetActive(true);
		fishingHook.successParticles.SetActive(false);
		DCGBADKLANM = 0f;
		DBEFBFPAOAA = 0f;
		while (DCGBADKLANM < 1f)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / 0.5f;
			fishingHook.fishIconInfo.color = new Color(1f, 1f, 1f, Mathf.Lerp(0f, 1f, DCGBADKLANM));
			yield return null;
		}
		yield return CommonReferences.wait3;
		DCGBADKLANM = 0f;
		DBEFBFPAOAA = 0f;
		while (DCGBADKLANM < 1f)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / 0.5f;
			fishingHook.fishIconInfo.color = new Color(1f, 1f, 1f, Mathf.Lerp(1f, 0f, DCGBADKLANM));
			yield return null;
		}
		FPBPEAAIOBK.OnItemFished();
		yield return CommonReferences.wait1_5;
		fishingHook.fishInfo.SetActive(false);
		((Component)fishingHook).gameObject.SetActive(false);
		((Renderer)fishingHook.spriteRenderer).enabled = true;
	}

	private IEnumerator KNKGAFOBFBB(Vector3 NOLFMLNLJJG, bool KAPEFGCIDJL)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		return new DLGCBADMBPP(1)
		{
			_003C_003E4__this = this,
			initialPosition = NOLFMLNLJJG,
			fishMinigameDone = KAPEFGCIDJL
		};
	}

	public void KEAMLOBPGPL()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		((MonoBehaviour)this).StartCoroutine(FIOAMIMPOOF(((Component)fishingHook).transform.position));
	}

	private void GNOBDKFFPOL()
	{
		((Component)fishingHook).gameObject.SetActive(true);
		if ((Object)(object)playerController == (Object)null)
		{
			playerController = ((Component)this).gameObject.GetComponent<PlayerController>();
		}
		playerNum = playerController.GetPlayerNum();
	}

	private void KFGNNFCOGKO(int JIIGOACEIKL, Vector3 JPIMPMOAAHC)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)fishingHook).gameObject.SetActive(true);
		((MonoBehaviour)this).StartCoroutine(AIAPOLDPANI(JIIGOACEIKL, Vector2.op_Implicit(JPIMPMOAAHC)));
	}

	private IEnumerator HACMNEBPBAM(Vector3 NOLFMLNLJJG, MineFishingKeyItem FPBPEAAIOBK)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		DBEFBFPAOAA = 0f;
		fishingHook.SetStruggle(NJHMBMGKCPL: false);
		yield return (object)new WaitForSeconds(settings.rollUpWaitTime);
		Vector2 finalPosition = Vector2.op_Implicit(fishingHook.fishingHookPosition.position);
		fishingHook.SetOtherIcon(FPBPEAAIOBK.GetSprite());
		fishingHook.SetStruggle(NJHMBMGKCPL: false);
		fishingHook.SetWater(NJHMBMGKCPL: false);
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.waterSmallSplash, ((Component)fishingHook).transform);
		if (AOJKMMOCFCA == Direction.Left)
		{
			((Component)fishingHook).transform.eulerAngles = new Vector3(0f, 0f, 360f);
		}
		else
		{
			((Component)fishingHook).transform.eulerAngles = Vector3.zero;
		}
		while (DBEFBFPAOAA < settings.rollUpTime)
		{
			DBEFBFPAOAA += Time.deltaTime;
			if (PlayerController.GetPlayerDirection(playerNum) == Direction.Down)
			{
				((Component)fishingHook).transform.position = BBBAJNLEEGB(DBEFBFPAOAA, Vector2.op_Implicit(NOLFMLNLJJG), finalPosition, settings.rollUpHeight + 3f, settings.rollUpTime);
			}
			else
			{
				((Component)fishingHook).transform.position = BBBAJNLEEGB(DBEFBFPAOAA, Vector2.op_Implicit(NOLFMLNLJJG), finalPosition, settings.rollUpHeight, settings.rollUpTime);
			}
			if (PlayerController.GetPlayerDirection(playerNum) == Direction.Left)
			{
				((Component)fishingHook).transform.eulerAngles = PDINCCBJLIH(DBEFBFPAOAA, 360f, 180f, settings.rollUpTime);
			}
			else
			{
				((Component)fishingHook).transform.eulerAngles = PDINCCBJLIH(DBEFBFPAOAA, 0f, 180f, settings.rollUpTime);
			}
			yield return null;
		}
		((Renderer)fishingHook.fishIcon).enabled = false;
		((Component)fishingHook).gameObject.SetActive(true);
		fishingHook.fishInfo.SetActive(true);
		((Renderer)fishingHook.spriteRenderer).enabled = false;
		((Component)fishingHook).transform.eulerAngles = Vector3.zero;
		((Renderer)fishingHook.fishIconInfo).enabled = true;
		fishingHook.fishIconInfo.sprite = FPBPEAAIOBK.GetSprite();
		OnlineFishingTexts.Get(playerNum).SetAlpha(0f);
		fishingHook.bigSuccessParticles.SetActive(true);
		fishingHook.successParticles.SetActive(false);
		DCGBADKLANM = 0f;
		DBEFBFPAOAA = 0f;
		while (DCGBADKLANM < 1f)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / 0.5f;
			fishingHook.fishIconInfo.color = new Color(1f, 1f, 1f, Mathf.Lerp(0f, 1f, DCGBADKLANM));
			yield return null;
		}
		yield return CommonReferences.wait3;
		DCGBADKLANM = 0f;
		DBEFBFPAOAA = 0f;
		while (DCGBADKLANM < 1f)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / 0.5f;
			fishingHook.fishIconInfo.color = new Color(1f, 1f, 1f, Mathf.Lerp(1f, 0f, DCGBADKLANM));
			yield return null;
		}
		FPBPEAAIOBK.OnItemFished();
		yield return CommonReferences.wait1_5;
		fishingHook.fishInfo.SetActive(false);
		((Component)fishingHook).gameObject.SetActive(false);
		((Renderer)fishingHook.spriteRenderer).enabled = true;
	}

	private void MNPAFJKFDKN(int JIIGOACEIKL, Vector3 JPIMPMOAAHC)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)fishingHook).gameObject.SetActive(false);
		((MonoBehaviour)this).StartCoroutine(NNDIEIAJOLC(JIIGOACEIKL, Vector2.op_Implicit(JPIMPMOAAHC)));
	}

	public void FMCEGPBACPC()
	{
		bitesList.Clear();
		float num = (Application.isPlaying ? Time.time : 800f);
		int num2 = Random.Range(((Vector2Int)(ref settings.bitesNum)).x, ((Vector2Int)(ref settings.bitesNum)).y + 0);
		for (int i = 1; i < num2; i += 0)
		{
			float num3 = Random.Range(num, num + (float)settings.totalTime);
			bool flag = false;
			for (int j = 0; j < bitesList.Count; j++)
			{
				if (Mathf.Abs(num3 - bitesList[j]) < settings.timeBetweenBites)
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				bitesList.Add(num3);
			}
		}
		int num4 = Random.Range(0, bitesList.Count);
		for (int num5 = bitesList.Count - 1; num5 > num4; num5--)
		{
			bitesList.RemoveAt(num5);
		}
		bitesList.Sort();
		if (bitesList.Count == 0)
		{
			Debug.LogError((object)"Invalid seating");
		}
	}

	public void MOECKIFAFII(bool KAPEFGCIDJL)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		((MonoBehaviour)this).StartCoroutine(CLGDAEEPFHH(((Component)fishingHook).transform.position, KAPEFGCIDJL));
	}

	private IEnumerator AIAPOLDPANI(int JIIGOACEIKL, Vector2 LKHOBGLHNIK)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		((Component)fishingHook).transform.eulerAngles = new Vector3(0f, 0f, 180f);
		while (((Component)fishingHook.fishingHookPosition).gameObject.activeInHierarchy)
		{
			yield return null;
		}
		Vector2 throwingPoint = Vector2.op_Implicit(fishingHook.fishingHookPosition.position);
		float currentLerpTime = 0f;
		float finalRotation = ((PlayerController.GetPlayerDirection(JIIGOACEIKL) != Direction.Left) ? 0f : 360f);
		while (currentLerpTime / settings.time < 1f)
		{
			currentLerpTime += Time.deltaTime;
			if (currentLerpTime < settings.time)
			{
				((Component)fishingHook).transform.position = BBBAJNLEEGB(currentLerpTime, throwingPoint, LKHOBGLHNIK, settings.height, settings.time);
				((Component)fishingHook).transform.eulerAngles = PDINCCBJLIH(currentLerpTime, 180f, finalRotation, settings.time);
			}
			yield return null;
		}
		((Component)fishingHook).transform.position = Vector2.op_Implicit(LKHOBGLHNIK);
		((Component)fishingHook).transform.eulerAngles = Vector3.zero;
		fishingHook.SetWater(NJHMBMGKCPL: true);
		PlayerInputs.GetPlayer(JIIGOACEIKL).SetVibration(0.1f, 0f, 0.2f);
		PlayerInputs.GetPlayer(JIIGOACEIKL).SetVibration(0f, 0.3f, 0.5f);
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.waterSmallSplash, ((Component)fishingHook).transform);
		BBOKEGODFGF = null;
		MineFishingKeyItem mineFishingKeyItem = ProceduralMine.GetCurrentLevel()?.puzzleManager?.GetKeyFishingSpot();
		if ((Object)(object)mineFishingKeyItem != (Object)null && mineFishingKeyItem.IsHookInRange(Vector2.op_Implicit(((Component)fishingHook).transform.position)))
		{
			BBOKEGODFGF = mineFishingKeyItem;
		}
		FishingUI.Get(JIIGOACEIKL).SetFishingIcon(BBOKEGODFGF);
	}

	private IEnumerator NKNDCGEJHLJ(Vector3 NOLFMLNLJJG, MineFishingKeyItem FPBPEAAIOBK)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		DBEFBFPAOAA = 0f;
		fishingHook.SetStruggle(NJHMBMGKCPL: false);
		yield return (object)new WaitForSeconds(settings.rollUpWaitTime);
		Vector2 finalPosition = Vector2.op_Implicit(fishingHook.fishingHookPosition.position);
		fishingHook.SetOtherIcon(FPBPEAAIOBK.GetSprite());
		fishingHook.SetStruggle(NJHMBMGKCPL: false);
		fishingHook.SetWater(NJHMBMGKCPL: false);
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.waterSmallSplash, ((Component)fishingHook).transform);
		if (AOJKMMOCFCA == Direction.Left)
		{
			((Component)fishingHook).transform.eulerAngles = new Vector3(0f, 0f, 360f);
		}
		else
		{
			((Component)fishingHook).transform.eulerAngles = Vector3.zero;
		}
		while (DBEFBFPAOAA < settings.rollUpTime)
		{
			DBEFBFPAOAA += Time.deltaTime;
			if (PlayerController.GetPlayerDirection(playerNum) == Direction.Down)
			{
				((Component)fishingHook).transform.position = BBBAJNLEEGB(DBEFBFPAOAA, Vector2.op_Implicit(NOLFMLNLJJG), finalPosition, settings.rollUpHeight + 3f, settings.rollUpTime);
			}
			else
			{
				((Component)fishingHook).transform.position = BBBAJNLEEGB(DBEFBFPAOAA, Vector2.op_Implicit(NOLFMLNLJJG), finalPosition, settings.rollUpHeight, settings.rollUpTime);
			}
			if (PlayerController.GetPlayerDirection(playerNum) == Direction.Left)
			{
				((Component)fishingHook).transform.eulerAngles = PDINCCBJLIH(DBEFBFPAOAA, 360f, 180f, settings.rollUpTime);
			}
			else
			{
				((Component)fishingHook).transform.eulerAngles = PDINCCBJLIH(DBEFBFPAOAA, 0f, 180f, settings.rollUpTime);
			}
			yield return null;
		}
		((Renderer)fishingHook.fishIcon).enabled = false;
		((Component)fishingHook).gameObject.SetActive(true);
		fishingHook.fishInfo.SetActive(true);
		((Renderer)fishingHook.spriteRenderer).enabled = false;
		((Component)fishingHook).transform.eulerAngles = Vector3.zero;
		((Renderer)fishingHook.fishIconInfo).enabled = true;
		fishingHook.fishIconInfo.sprite = FPBPEAAIOBK.GetSprite();
		OnlineFishingTexts.Get(playerNum).SetAlpha(0f);
		fishingHook.bigSuccessParticles.SetActive(true);
		fishingHook.successParticles.SetActive(false);
		DCGBADKLANM = 0f;
		DBEFBFPAOAA = 0f;
		while (DCGBADKLANM < 1f)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / 0.5f;
			fishingHook.fishIconInfo.color = new Color(1f, 1f, 1f, Mathf.Lerp(0f, 1f, DCGBADKLANM));
			yield return null;
		}
		yield return CommonReferences.wait3;
		DCGBADKLANM = 0f;
		DBEFBFPAOAA = 0f;
		while (DCGBADKLANM < 1f)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / 0.5f;
			fishingHook.fishIconInfo.color = new Color(1f, 1f, 1f, Mathf.Lerp(1f, 0f, DCGBADKLANM));
			yield return null;
		}
		FPBPEAAIOBK.OnItemFished();
		yield return CommonReferences.wait1_5;
		fishingHook.fishInfo.SetActive(false);
		((Component)fishingHook).gameObject.SetActive(false);
		((Renderer)fishingHook.spriteRenderer).enabled = true;
	}

	private IEnumerator FIIAKENKGEC(Vector3 NOLFMLNLJJG, bool KAPEFGCIDJL)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		return new DLGCBADMBPP(1)
		{
			_003C_003E4__this = this,
			initialPosition = NOLFMLNLJJG,
			fishMinigameDone = KAPEFGCIDJL
		};
	}

	private IEnumerator ABKAPLHDOBI(int JIIGOACEIKL, Vector2 LKHOBGLHNIK)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		return new LGAFAMAHFCE(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL,
			fallPoint = LKHOBGLHNIK
		};
	}

	private IEnumerator LCLFMIHCKOL(int JIIGOACEIKL, Vector2 LKHOBGLHNIK)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		((Component)fishingHook).transform.eulerAngles = new Vector3(0f, 0f, 180f);
		while (((Component)fishingHook.fishingHookPosition).gameObject.activeInHierarchy)
		{
			yield return null;
		}
		Vector2 throwingPoint = Vector2.op_Implicit(fishingHook.fishingHookPosition.position);
		float currentLerpTime = 0f;
		float finalRotation = ((PlayerController.GetPlayerDirection(JIIGOACEIKL) != Direction.Left) ? 0f : 360f);
		while (currentLerpTime / settings.time < 1f)
		{
			currentLerpTime += Time.deltaTime;
			if (currentLerpTime < settings.time)
			{
				((Component)fishingHook).transform.position = BBBAJNLEEGB(currentLerpTime, throwingPoint, LKHOBGLHNIK, settings.height, settings.time);
				((Component)fishingHook).transform.eulerAngles = PDINCCBJLIH(currentLerpTime, 180f, finalRotation, settings.time);
			}
			yield return null;
		}
		((Component)fishingHook).transform.position = Vector2.op_Implicit(LKHOBGLHNIK);
		((Component)fishingHook).transform.eulerAngles = Vector3.zero;
		fishingHook.SetWater(NJHMBMGKCPL: true);
		PlayerInputs.GetPlayer(JIIGOACEIKL).SetVibration(0.1f, 0f, 0.2f);
		PlayerInputs.GetPlayer(JIIGOACEIKL).SetVibration(0f, 0.3f, 0.5f);
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.waterSmallSplash, ((Component)fishingHook).transform);
		BBOKEGODFGF = null;
		MineFishingKeyItem mineFishingKeyItem = ProceduralMine.GetCurrentLevel()?.puzzleManager?.GetKeyFishingSpot();
		if ((Object)(object)mineFishingKeyItem != (Object)null && mineFishingKeyItem.IsHookInRange(Vector2.op_Implicit(((Component)fishingHook).transform.position)))
		{
			BBOKEGODFGF = mineFishingKeyItem;
		}
		FishingUI.Get(JIIGOACEIKL).SetFishingIcon(BBOKEGODFGF);
	}

	public void EHOFOMHDPFJ(Vector3 JPIMPMOAAHC, Rod COHELLCBDMF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		((MonoBehaviour)this).StartCoroutine(NELPAJGBJKE(JPIMPMOAAHC, COHELLCBDMF));
	}

	private IEnumerator AEFJOENMPOD(Vector3 NOLFMLNLJJG, Fish HAJFJGCNKFF, int KKANDELPDKP)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		return new JHJFBPKEBHG(1)
		{
			_003C_003E4__this = this,
			initialPosition = NOLFMLNLJJG,
			fish = HAJFJGCNKFF,
			size = KKANDELPDKP
		};
	}

	public void ShowCaughtFishOnline(short FFNOEIENNFM, short KKANDELPDKP)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < ItemDatabaseAccessor.GetFishList().Count; i++)
		{
			if (ItemDatabaseAccessor.GetFishList()[i].JDJGFAACPFC() == FFNOEIENNFM)
			{
				((MonoBehaviour)this).StartCoroutine(GJCHEBPBCDO(((Component)fishingHook).transform.position, ItemDatabaseAccessor.GetFishList()[i], KKANDELPDKP));
				break;
			}
		}
	}

	private IEnumerator MBCAHKBCEFM(Vector3 NOLFMLNLJJG)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		DBEFBFPAOAA = 0f;
		fishingHook.SetStruggle(NJHMBMGKCPL: false);
		yield return (object)new WaitForSeconds(settings.rollUpWaitTime);
		Vector2 finalPosition = Vector2.op_Implicit(fishingHook.fishingHookPosition.position);
		fishingHook.SetFishIcon(null);
		fishingHook.SetStruggle(NJHMBMGKCPL: false);
		fishingHook.SetWater(NJHMBMGKCPL: false);
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.waterSmallSplash, ((Component)fishingHook).transform);
		if (AOJKMMOCFCA == Direction.Left)
		{
			((Component)fishingHook).transform.eulerAngles = new Vector3(0f, 0f, 360f);
		}
		else
		{
			((Component)fishingHook).transform.eulerAngles = Vector3.zero;
		}
		while (DBEFBFPAOAA < settings.rollUpTime)
		{
			DBEFBFPAOAA += Time.deltaTime;
			if (PlayerController.GetPlayerDirection(playerNum) == Direction.Down)
			{
				((Component)fishingHook).transform.position = BBBAJNLEEGB(DBEFBFPAOAA, Vector2.op_Implicit(NOLFMLNLJJG), finalPosition, settings.rollUpHeight + 3f, settings.rollUpTime);
			}
			else
			{
				((Component)fishingHook).transform.position = BBBAJNLEEGB(DBEFBFPAOAA, Vector2.op_Implicit(NOLFMLNLJJG), finalPosition, settings.rollUpHeight, settings.rollUpTime);
			}
			if (PlayerController.GetPlayerDirection(playerNum) == Direction.Left)
			{
				((Component)fishingHook).transform.eulerAngles = PDINCCBJLIH(DBEFBFPAOAA, 360f, 180f, settings.rollUpTime);
			}
			else
			{
				((Component)fishingHook).transform.eulerAngles = PDINCCBJLIH(DBEFBFPAOAA, 0f, 180f, settings.rollUpTime);
			}
			yield return null;
		}
		((Renderer)fishingHook.spriteRenderer).enabled = false;
		((Component)fishingHook).transform.eulerAngles = Vector3.zero;
	}

	public void IJJCPNOJAGF()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		MineFishingKeyItem mineFishingKeyItem = ProceduralMine.GetCurrentLevel()?.puzzleManager?.GetKeyFishingSpot();
		if (!((Object)(object)mineFishingKeyItem == (Object)null))
		{
			((MonoBehaviour)this).StartCoroutine(HACMNEBPBAM(((Component)fishingHook).transform.position, mineFishingKeyItem));
		}
	}

	private IEnumerator CIHONGBLKKJ(int JIIGOACEIKL, Vector2 LKHOBGLHNIK)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		((Component)fishingHook).transform.eulerAngles = new Vector3(0f, 0f, 180f);
		while (((Component)fishingHook.fishingHookPosition).gameObject.activeInHierarchy)
		{
			yield return null;
		}
		Vector2 throwingPoint = Vector2.op_Implicit(fishingHook.fishingHookPosition.position);
		float currentLerpTime = 0f;
		float finalRotation = ((PlayerController.GetPlayerDirection(JIIGOACEIKL) != Direction.Left) ? 0f : 360f);
		while (currentLerpTime / settings.time < 1f)
		{
			currentLerpTime += Time.deltaTime;
			if (currentLerpTime < settings.time)
			{
				((Component)fishingHook).transform.position = BBBAJNLEEGB(currentLerpTime, throwingPoint, LKHOBGLHNIK, settings.height, settings.time);
				((Component)fishingHook).transform.eulerAngles = PDINCCBJLIH(currentLerpTime, 180f, finalRotation, settings.time);
			}
			yield return null;
		}
		((Component)fishingHook).transform.position = Vector2.op_Implicit(LKHOBGLHNIK);
		((Component)fishingHook).transform.eulerAngles = Vector3.zero;
		fishingHook.SetWater(NJHMBMGKCPL: true);
		PlayerInputs.GetPlayer(JIIGOACEIKL).SetVibration(0.1f, 0f, 0.2f);
		PlayerInputs.GetPlayer(JIIGOACEIKL).SetVibration(0f, 0.3f, 0.5f);
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.waterSmallSplash, ((Component)fishingHook).transform);
		BBOKEGODFGF = null;
		MineFishingKeyItem mineFishingKeyItem = ProceduralMine.GetCurrentLevel()?.puzzleManager?.GetKeyFishingSpot();
		if ((Object)(object)mineFishingKeyItem != (Object)null && mineFishingKeyItem.IsHookInRange(Vector2.op_Implicit(((Component)fishingHook).transform.position)))
		{
			BBOKEGODFGF = mineFishingKeyItem;
		}
		FishingUI.Get(JIIGOACEIKL).SetFishingIcon(BBOKEGODFGF);
	}

	private IEnumerator EJFPKMNFHFD(Direction FCGBJEIIMBC)
	{
		AOJKMMOCFCA = FCGBJEIIMBC;
		Vector2 fishingPosition2 = ((FCGBJEIIMBC != 0 && FCGBJEIIMBC != Direction.Down) ? Vector2.op_Implicit(playerController.GetPosition() + 4f * Utils.NGFODNCHPHB(FCGBJEIIMBC)) : Vector2.op_Implicit(playerController.GetPosition() + 2f * Utils.NGFODNCHPHB(FCGBJEIIMBC)));
		fishingPosition2 = Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(Vector2.op_Implicit(fishingPosition2)));
		((Component)fishingHook).gameObject.SetActive(true);
		((Renderer)fishingHook.spriteRenderer).enabled = true;
		((Component)fishingHook).transform.eulerAngles = new Vector3(0f, 0f, 180f);
		while (((Component)fishingHook.fishingHookPosition).gameObject.activeInHierarchy)
		{
			yield return null;
		}
		Vector2 throwingPoint = Vector2.op_Implicit(fishingHook.fishingHookPosition.position);
		float currentLerpTime = 0f;
		float finalRotation = ((FCGBJEIIMBC != Direction.Left) ? 0f : 360f);
		while (currentLerpTime / settings.time < 1f)
		{
			currentLerpTime += Time.deltaTime;
			if (currentLerpTime < settings.time)
			{
				((Component)fishingHook).transform.position = BBBAJNLEEGB(currentLerpTime, throwingPoint, fishingPosition2, settings.height, settings.time);
				((Component)fishingHook).transform.eulerAngles = PDINCCBJLIH(currentLerpTime, 180f, finalRotation, settings.time);
			}
			yield return null;
		}
		((Component)fishingHook).transform.position = Vector2.op_Implicit(fishingPosition2);
		((Component)fishingHook).transform.eulerAngles = Vector3.zero;
		fishingHook.SetWater(NJHMBMGKCPL: true);
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.waterSmallSplash, ((Component)fishingHook).transform);
	}

	private IEnumerator KKCKAIFLACG(Vector3 JPIMPMOAAHC, Rod COHELLCBDMF)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		MLHCLDNJEAG = (settings.EASY_FISHING ? settings.easyMode : settings.normalMode);
		yield return null;
		FishingUI.Get(playerNum).fish = null;
		OILGOIDPIOF(playerNum, JPIMPMOAAHC);
		OnHookThrown?.Invoke((byte)playerController.GetDirection());
		float finalTime = Time.time + (float)settings.totalTime;
		bool startFishMinigame = false;
		bool fishingTime = false;
		OMCCPAOFBBI = Item.MLBOMGHINCA(FishingManager.SelectAFish(playerNum, COHELLCBDMF), null);
		yield return (object)new WaitForSeconds(settings.initialDelayTime);
		float finalBiteTime = 0f;
		bitesList.Clear();
		if (OMCCPAOFBBI)
		{
			CreateBitesList();
			finalBiteTime = bitesList[bitesList.Count - 1] + settings.realBiteDuration;
		}
		while (true)
		{
			if (!CommonReferences.GGFJGHHHEJC.IsInDialogue(playerNum))
			{
				if (OMCCPAOFBBI)
				{
					if (fishingTime && Time.time > finalBiteTime)
					{
						break;
					}
				}
				else if (Time.time > finalTime)
				{
					break;
				}
				if (!fishingTime && bitesList.Count > 0 && Time.time > bitesList[0])
				{
					if (bitesList.Count == 1)
					{
						fishingTime = true;
						PlayerInputs.GetPlayer(playerNum).SetVibration(0f, 0.3f, 0.5f);
						fishingHook.SetBait();
					}
					else
					{
						PlayerInputs.GetPlayer(playerNum).SetVibration(0f, 0.1f, 0.05f);
						fishingHook.SetFake();
						bitesList.RemoveAt(0);
					}
				}
				if (PlayerInputs.GetPlayer(playerNum).GetButtonDown("Use") || PlayerInputs.GetPlayer(playerNum).GetButtonDown("LeftMouseDetect"))
				{
					if (OMCCPAOFBBI && fishingTime)
					{
						playerController.emotionController.StartEmotion("Exclamation");
						MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.exclamationFishing, ((Component)PlayerController.GetPlayer(playerNum)).transform);
						startFishMinigame = true;
					}
					break;
				}
			}
			else
			{
				finalTime = Time.time + (float)settings.totalTime;
				if (OMCCPAOFBBI)
				{
					finalBiteTime = bitesList[bitesList.Count - 1] + settings.realBiteDuration;
				}
			}
			yield return null;
		}
		if (startFishMinigame)
		{
			OnFishBite?.Invoke();
			fishingHook.SetStruggle(NJHMBMGKCPL: true);
			playerController.characterAnimation.SetIdleFishing(NKFPJPCFBJI: false);
			playerController.characterAnimation.SetStruggleFishing(NKFPJPCFBJI: true);
			yield return CommonReferences.wait05;
			Result variable = DialogueLua.GetVariable("LE_10");
			if (((Result)(ref variable)).asInt == 8)
			{
				HikariNPC.GGFJGHHHEJC.ActiveDialogue(playerNum);
				yield return CommonReferences.wait04;
			}
			while (CommonReferences.GGFJGHHHEJC.IsInDialogue(playerNum))
			{
				yield return null;
			}
			FishingUI.Get(playerNum).OpenUI();
			FishingUI.Get(playerNum).StartFishingGame(COHELLCBDMF);
			while (FishingUI.Get(playerNum).IsOpen())
			{
				yield return null;
			}
		}
		FinishFishing(startFishMinigame);
	}

	public static FishingController LAMFGLIGLOP(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) == (Object)null)
		{
			return null;
		}
		return PlayerController.OPHDCMJLLEC(JIIGOACEIKL).fishingController;
	}

	public void FinishFishingOnline()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		((MonoBehaviour)this).StartCoroutine(DHDCKBLIBPG(((Component)fishingHook).transform.position));
	}

	public void IJLFHJKNMGI(short FFNOEIENNFM, short KKANDELPDKP)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < ItemDatabaseAccessor.MBLHBFCOADO().Count; i += 0)
		{
			if (ItemDatabaseAccessor.PCFCELEHIAN()[i].JGHNDJBCFAJ() == FFNOEIENNFM)
			{
				((MonoBehaviour)this).StartCoroutine(HDFKKBGOAIM(((Component)fishingHook).transform.position, ItemDatabaseAccessor.MBLHBFCOADO()[i], KKANDELPDKP));
				break;
			}
		}
	}

	private Vector3 LKPFHCDCDIF(float DBEFBFPAOAA, float GDBONJNKLCD, float MEOEHBFJOAN, float AMOLDGGJMKF)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		DCGBADKLANM = DBEFBFPAOAA / AMOLDGGJMKF;
		return new Vector3(1567f, 873f, Mathf.Lerp(GDBONJNKLCD, MEOEHBFJOAN, DCGBADKLANM));
	}

	private IEnumerator EKBLFFPOHBC(int JIIGOACEIKL, Vector2 LKHOBGLHNIK)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		((Component)fishingHook).transform.eulerAngles = new Vector3(0f, 0f, 180f);
		while (((Component)fishingHook.fishingHookPosition).gameObject.activeInHierarchy)
		{
			yield return null;
		}
		Vector2 throwingPoint = Vector2.op_Implicit(fishingHook.fishingHookPosition.position);
		float currentLerpTime = 0f;
		float finalRotation = ((PlayerController.GetPlayerDirection(JIIGOACEIKL) != Direction.Left) ? 0f : 360f);
		while (currentLerpTime / settings.time < 1f)
		{
			currentLerpTime += Time.deltaTime;
			if (currentLerpTime < settings.time)
			{
				((Component)fishingHook).transform.position = BBBAJNLEEGB(currentLerpTime, throwingPoint, LKHOBGLHNIK, settings.height, settings.time);
				((Component)fishingHook).transform.eulerAngles = PDINCCBJLIH(currentLerpTime, 180f, finalRotation, settings.time);
			}
			yield return null;
		}
		((Component)fishingHook).transform.position = Vector2.op_Implicit(LKHOBGLHNIK);
		((Component)fishingHook).transform.eulerAngles = Vector3.zero;
		fishingHook.SetWater(NJHMBMGKCPL: true);
		PlayerInputs.GetPlayer(JIIGOACEIKL).SetVibration(0.1f, 0f, 0.2f);
		PlayerInputs.GetPlayer(JIIGOACEIKL).SetVibration(0f, 0.3f, 0.5f);
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.waterSmallSplash, ((Component)fishingHook).transform);
		BBOKEGODFGF = null;
		MineFishingKeyItem mineFishingKeyItem = ProceduralMine.GetCurrentLevel()?.puzzleManager?.GetKeyFishingSpot();
		if ((Object)(object)mineFishingKeyItem != (Object)null && mineFishingKeyItem.IsHookInRange(Vector2.op_Implicit(((Component)fishingHook).transform.position)))
		{
			BBOKEGODFGF = mineFishingKeyItem;
		}
		FishingUI.Get(JIIGOACEIKL).SetFishingIcon(BBOKEGODFGF);
	}

	private void Awake()
	{
		((Component)fishingHook).gameObject.SetActive(false);
		if ((Object)(object)playerController == (Object)null)
		{
			playerController = ((Component)this).gameObject.GetComponent<PlayerController>();
		}
		playerNum = playerController.GetPlayerNum();
	}

	public void JBNCHCFIBCB()
	{
		bitesList.Clear();
		float num = (Application.isPlaying ? Time.time : 1080f);
		int num2 = Random.Range(((Vector2Int)(ref settings.bitesNum)).x, ((Vector2Int)(ref settings.bitesNum)).y + 0);
		for (int i = 1; i < num2; i++)
		{
			float num3 = Random.Range(num, num + (float)settings.totalTime);
			bool flag = false;
			for (int j = 1; j < bitesList.Count; j += 0)
			{
				if (Mathf.Abs(num3 - bitesList[j]) < settings.timeBetweenBites)
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				bitesList.Add(num3);
			}
		}
		int num4 = Random.Range(0, bitesList.Count);
		for (int num5 = bitesList.Count - 1; num5 > num4; num5 -= 0)
		{
			bitesList.RemoveAt(num5);
		}
		bitesList.Sort();
		if (bitesList.Count == 0)
		{
			Debug.LogError((object)"Frog(Clone)");
		}
	}

	public static FishingController AIMEAJAHLAA(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) == (Object)null)
		{
			return null;
		}
		return PlayerController.OPHDCMJLLEC(JIIGOACEIKL).fishingController;
	}

	private IEnumerator ADMBPGLODAJ(Vector3 NOLFMLNLJJG, bool KAPEFGCIDJL)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		return new DLGCBADMBPP(1)
		{
			_003C_003E4__this = this,
			initialPosition = NOLFMLNLJJG,
			fishMinigameDone = KAPEFGCIDJL
		};
	}

	private void KHCJDKHONPK()
	{
		((Component)fishingHook).gameObject.SetActive(false);
		if ((Object)(object)playerController == (Object)null)
		{
			playerController = ((Component)this).gameObject.GetComponent<PlayerController>();
		}
		playerNum = playerController.GetPlayerNum();
	}

	private IEnumerator NELPAJGBJKE(Vector3 JPIMPMOAAHC, Rod COHELLCBDMF)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		return new DGKGJJCPOMI(1)
		{
			_003C_003E4__this = this,
			fishPosition = JPIMPMOAAHC,
			_rod = COHELLCBDMF
		};
	}

	private void DALBDAGNICJ(int JIIGOACEIKL, Vector3 JPIMPMOAAHC)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)fishingHook).gameObject.SetActive(false);
		((MonoBehaviour)this).StartCoroutine(AIAPOLDPANI(JIIGOACEIKL, Vector2.op_Implicit(JPIMPMOAAHC)));
	}

	private IEnumerator PEFNGEGBMIO(Direction FCGBJEIIMBC)
	{
		AOJKMMOCFCA = FCGBJEIIMBC;
		Vector2 fishingPosition2 = ((FCGBJEIIMBC != 0 && FCGBJEIIMBC != Direction.Down) ? Vector2.op_Implicit(playerController.GetPosition() + 4f * Utils.NGFODNCHPHB(FCGBJEIIMBC)) : Vector2.op_Implicit(playerController.GetPosition() + 2f * Utils.NGFODNCHPHB(FCGBJEIIMBC)));
		fishingPosition2 = Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(Vector2.op_Implicit(fishingPosition2)));
		((Component)fishingHook).gameObject.SetActive(true);
		((Renderer)fishingHook.spriteRenderer).enabled = true;
		((Component)fishingHook).transform.eulerAngles = new Vector3(0f, 0f, 180f);
		while (((Component)fishingHook.fishingHookPosition).gameObject.activeInHierarchy)
		{
			yield return null;
		}
		Vector2 throwingPoint = Vector2.op_Implicit(fishingHook.fishingHookPosition.position);
		float currentLerpTime = 0f;
		float finalRotation = ((FCGBJEIIMBC != Direction.Left) ? 0f : 360f);
		while (currentLerpTime / settings.time < 1f)
		{
			currentLerpTime += Time.deltaTime;
			if (currentLerpTime < settings.time)
			{
				((Component)fishingHook).transform.position = BBBAJNLEEGB(currentLerpTime, throwingPoint, fishingPosition2, settings.height, settings.time);
				((Component)fishingHook).transform.eulerAngles = PDINCCBJLIH(currentLerpTime, 180f, finalRotation, settings.time);
			}
			yield return null;
		}
		((Component)fishingHook).transform.position = Vector2.op_Implicit(fishingPosition2);
		((Component)fishingHook).transform.eulerAngles = Vector3.zero;
		fishingHook.SetWater(NJHMBMGKCPL: true);
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.waterSmallSplash, ((Component)fishingHook).transform);
	}

	private IEnumerator NFDGIMJNACH(Vector3 NOLFMLNLJJG, Fish HAJFJGCNKFF, int KKANDELPDKP)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		DBEFBFPAOAA = 0f;
		fishingHook.SetStruggle(NJHMBMGKCPL: false);
		yield return (object)new WaitForSeconds(settings.rollUpWaitTime);
		Vector2 finalPosition = Vector2.op_Implicit(fishingHook.fishingHookPosition.position);
		fishingHook.SetFishIcon(HAJFJGCNKFF);
		fishingHook.SetStruggle(NJHMBMGKCPL: false);
		fishingHook.SetWater(NJHMBMGKCPL: false);
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.waterSmallSplash, ((Component)fishingHook).transform);
		if (AOJKMMOCFCA == Direction.Left)
		{
			((Component)fishingHook).transform.eulerAngles = new Vector3(0f, 0f, 360f);
		}
		else
		{
			((Component)fishingHook).transform.eulerAngles = Vector3.zero;
		}
		while (DBEFBFPAOAA < settings.rollUpTime)
		{
			DBEFBFPAOAA += Time.deltaTime;
			if (PlayerController.GetPlayerDirection(playerNum) == Direction.Down)
			{
				((Component)fishingHook).transform.position = BBBAJNLEEGB(DBEFBFPAOAA, Vector2.op_Implicit(NOLFMLNLJJG), finalPosition, settings.rollUpHeight + 3f, settings.rollUpTime);
			}
			else
			{
				((Component)fishingHook).transform.position = BBBAJNLEEGB(DBEFBFPAOAA, Vector2.op_Implicit(NOLFMLNLJJG), finalPosition, settings.rollUpHeight, settings.rollUpTime);
			}
			if (PlayerController.GetPlayerDirection(playerNum) == Direction.Left)
			{
				((Component)fishingHook).transform.eulerAngles = PDINCCBJLIH(DBEFBFPAOAA, 360f, 180f, settings.rollUpTime);
			}
			else
			{
				((Component)fishingHook).transform.eulerAngles = PDINCCBJLIH(DBEFBFPAOAA, 0f, 180f, settings.rollUpTime);
			}
			yield return null;
		}
		((Renderer)fishingHook.fishIcon).enabled = false;
		((Component)fishingHook).gameObject.SetActive(true);
		fishingHook.fishInfo.SetActive(true);
		((Renderer)fishingHook.spriteRenderer).enabled = false;
		((Component)fishingHook).transform.eulerAngles = Vector3.zero;
		((Renderer)fishingHook.fishIconInfo).enabled = true;
		fishingHook.fishIconInfo.sprite = HAJFJGCNKFF.icon;
		OnlineFishingTexts.Get(playerNum).SetFishInfo(HAJFJGCNKFF, KKANDELPDKP);
		if (KKANDELPDKP > 0)
		{
			fishingHook.bigSuccessParticles.SetActive(true);
			fishingHook.successParticles.SetActive(false);
		}
		else
		{
			fishingHook.bigSuccessParticles.SetActive(false);
			fishingHook.successParticles.SetActive(true);
		}
		DCGBADKLANM = 0f;
		DBEFBFPAOAA = 0f;
		while (DCGBADKLANM < 1f)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / 0.5f;
			OnlineFishingTexts.Get(playerNum).SetAlpha(Mathf.Lerp(0f, 1f, DCGBADKLANM));
			fishingHook.fishIconInfo.color = new Color(1f, 1f, 1f, Mathf.Lerp(0f, 1f, DCGBADKLANM));
			yield return null;
		}
		yield return CommonReferences.wait3;
		DCGBADKLANM = 0f;
		DBEFBFPAOAA = 0f;
		while (DCGBADKLANM < 1f)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / 0.5f;
			OnlineFishingTexts.Get(playerNum).SetAlpha(Mathf.Lerp(1f, 0f, DCGBADKLANM));
			fishingHook.fishIconInfo.color = new Color(1f, 1f, 1f, Mathf.Lerp(1f, 0f, DCGBADKLANM));
			yield return null;
		}
		yield return CommonReferences.wait1_5;
		fishingHook.fishInfo.SetActive(false);
		((Component)fishingHook).gameObject.SetActive(false);
		((Renderer)fishingHook.spriteRenderer).enabled = true;
	}

	private IEnumerator OFAIHFAAFKG(int JIIGOACEIKL, Vector2 LKHOBGLHNIK)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		((Component)fishingHook).transform.eulerAngles = new Vector3(0f, 0f, 180f);
		while (((Component)fishingHook.fishingHookPosition).gameObject.activeInHierarchy)
		{
			yield return null;
		}
		Vector2 throwingPoint = Vector2.op_Implicit(fishingHook.fishingHookPosition.position);
		float currentLerpTime = 0f;
		float finalRotation = ((PlayerController.GetPlayerDirection(JIIGOACEIKL) != Direction.Left) ? 0f : 360f);
		while (currentLerpTime / settings.time < 1f)
		{
			currentLerpTime += Time.deltaTime;
			if (currentLerpTime < settings.time)
			{
				((Component)fishingHook).transform.position = BBBAJNLEEGB(currentLerpTime, throwingPoint, LKHOBGLHNIK, settings.height, settings.time);
				((Component)fishingHook).transform.eulerAngles = PDINCCBJLIH(currentLerpTime, 180f, finalRotation, settings.time);
			}
			yield return null;
		}
		((Component)fishingHook).transform.position = Vector2.op_Implicit(LKHOBGLHNIK);
		((Component)fishingHook).transform.eulerAngles = Vector3.zero;
		fishingHook.SetWater(NJHMBMGKCPL: true);
		PlayerInputs.GetPlayer(JIIGOACEIKL).SetVibration(0.1f, 0f, 0.2f);
		PlayerInputs.GetPlayer(JIIGOACEIKL).SetVibration(0f, 0.3f, 0.5f);
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.waterSmallSplash, ((Component)fishingHook).transform);
		BBOKEGODFGF = null;
		MineFishingKeyItem mineFishingKeyItem = ProceduralMine.GetCurrentLevel()?.puzzleManager?.GetKeyFishingSpot();
		if ((Object)(object)mineFishingKeyItem != (Object)null && mineFishingKeyItem.IsHookInRange(Vector2.op_Implicit(((Component)fishingHook).transform.position)))
		{
			BBOKEGODFGF = mineFishingKeyItem;
		}
		FishingUI.Get(JIIGOACEIKL).SetFishingIcon(BBOKEGODFGF);
	}

	public void GJKBNFMCNDE(byte FCGBJEIIMBC)
	{
		((MonoBehaviour)this).StartCoroutine(EJFPKMNFHFD((Direction)FCGBJEIIMBC));
	}

	public void HHPIGGJPHHN()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		((MonoBehaviour)this).StartCoroutine(DHDCKBLIBPG(((Component)fishingHook).transform.position));
	}

	private IEnumerator KGKELKDHDDP(Direction FCGBJEIIMBC)
	{
		AOJKMMOCFCA = FCGBJEIIMBC;
		Vector2 fishingPosition2 = ((FCGBJEIIMBC != 0 && FCGBJEIIMBC != Direction.Down) ? Vector2.op_Implicit(playerController.GetPosition() + 4f * Utils.NGFODNCHPHB(FCGBJEIIMBC)) : Vector2.op_Implicit(playerController.GetPosition() + 2f * Utils.NGFODNCHPHB(FCGBJEIIMBC)));
		fishingPosition2 = Vector2.op_Implicit(WorldGrid.LOJBKLKMINM(Vector2.op_Implicit(fishingPosition2)));
		((Component)fishingHook).gameObject.SetActive(true);
		((Renderer)fishingHook.spriteRenderer).enabled = true;
		((Component)fishingHook).transform.eulerAngles = new Vector3(0f, 0f, 180f);
		while (((Component)fishingHook.fishingHookPosition).gameObject.activeInHierarchy)
		{
			yield return null;
		}
		Vector2 throwingPoint = Vector2.op_Implicit(fishingHook.fishingHookPosition.position);
		float currentLerpTime = 0f;
		float finalRotation = ((FCGBJEIIMBC != Direction.Left) ? 0f : 360f);
		while (currentLerpTime / settings.time < 1f)
		{
			currentLerpTime += Time.deltaTime;
			if (currentLerpTime < settings.time)
			{
				((Component)fishingHook).transform.position = BBBAJNLEEGB(currentLerpTime, throwingPoint, fishingPosition2, settings.height, settings.time);
				((Component)fishingHook).transform.eulerAngles = PDINCCBJLIH(currentLerpTime, 180f, finalRotation, settings.time);
			}
			yield return null;
		}
		((Component)fishingHook).transform.position = Vector2.op_Implicit(fishingPosition2);
		((Component)fishingHook).transform.eulerAngles = Vector3.zero;
		fishingHook.SetWater(NJHMBMGKCPL: true);
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.waterSmallSplash, ((Component)fishingHook).transform);
	}

	private IEnumerator IIGENDEOAHJ(int JIIGOACEIKL, Vector2 LKHOBGLHNIK)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		return new LGAFAMAHFCE(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL,
			fallPoint = LKHOBGLHNIK
		};
	}

	public void FGLKDAAHKKH(byte FCGBJEIIMBC)
	{
		((MonoBehaviour)this).StartCoroutine(KGKELKDHDDP((Direction)FCGBJEIIMBC));
	}

	private void OILGOIDPIOF(int JIIGOACEIKL, Vector3 JPIMPMOAAHC)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)fishingHook).gameObject.SetActive(true);
		((MonoBehaviour)this).StartCoroutine(LCLFMIHCKOL(JIIGOACEIKL, Vector2.op_Implicit(JPIMPMOAAHC)));
	}

	public void LJCNGJHKCFN(short FFNOEIENNFM, short KKANDELPDKP)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < ItemDatabaseAccessor.GetFishList().Count; i += 0)
		{
			if (ItemDatabaseAccessor.LNBAODAAJLI()[i].ODENMDOJPLC() == FFNOEIENNFM)
			{
				((MonoBehaviour)this).StartCoroutine(PICIMDLKMEI(((Component)fishingHook).transform.position, ItemDatabaseAccessor.MBLHBFCOADO()[i], KKANDELPDKP));
				break;
			}
		}
	}

	public void BHOBBOBMGBP()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		((MonoBehaviour)this).StartCoroutine(NIDCDGPINAA(((Component)fishingHook).transform.position));
	}

	private IEnumerator NNDIEIAJOLC(int JIIGOACEIKL, Vector2 LKHOBGLHNIK)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		return new LGAFAMAHFCE(1)
		{
			_003C_003E4__this = this,
			playerNum = JIIGOACEIKL,
			fallPoint = LKHOBGLHNIK
		};
	}

	public void IAACFAPNOFI(bool KAPEFGCIDJL)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		((MonoBehaviour)this).StartCoroutine(CLGDAEEPFHH(((Component)fishingHook).transform.position, KAPEFGCIDJL));
	}

	private IEnumerator KEFJMDGFFKO(Direction FCGBJEIIMBC)
	{
		return new PBAKNKJIBFH(1)
		{
			_003C_003E4__this = this,
			direction = FCGBJEIIMBC
		};
	}

	private IEnumerator GJCHEBPBCDO(Vector3 NOLFMLNLJJG, Fish HAJFJGCNKFF, int KKANDELPDKP)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		DBEFBFPAOAA = 0f;
		fishingHook.SetStruggle(NJHMBMGKCPL: false);
		yield return (object)new WaitForSeconds(settings.rollUpWaitTime);
		Vector2 finalPosition = Vector2.op_Implicit(fishingHook.fishingHookPosition.position);
		fishingHook.SetFishIcon(HAJFJGCNKFF);
		fishingHook.SetStruggle(NJHMBMGKCPL: false);
		fishingHook.SetWater(NJHMBMGKCPL: false);
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.waterSmallSplash, ((Component)fishingHook).transform);
		if (AOJKMMOCFCA == Direction.Left)
		{
			((Component)fishingHook).transform.eulerAngles = new Vector3(0f, 0f, 360f);
		}
		else
		{
			((Component)fishingHook).transform.eulerAngles = Vector3.zero;
		}
		while (DBEFBFPAOAA < settings.rollUpTime)
		{
			DBEFBFPAOAA += Time.deltaTime;
			if (PlayerController.GetPlayerDirection(playerNum) == Direction.Down)
			{
				((Component)fishingHook).transform.position = BBBAJNLEEGB(DBEFBFPAOAA, Vector2.op_Implicit(NOLFMLNLJJG), finalPosition, settings.rollUpHeight + 3f, settings.rollUpTime);
			}
			else
			{
				((Component)fishingHook).transform.position = BBBAJNLEEGB(DBEFBFPAOAA, Vector2.op_Implicit(NOLFMLNLJJG), finalPosition, settings.rollUpHeight, settings.rollUpTime);
			}
			if (PlayerController.GetPlayerDirection(playerNum) == Direction.Left)
			{
				((Component)fishingHook).transform.eulerAngles = PDINCCBJLIH(DBEFBFPAOAA, 360f, 180f, settings.rollUpTime);
			}
			else
			{
				((Component)fishingHook).transform.eulerAngles = PDINCCBJLIH(DBEFBFPAOAA, 0f, 180f, settings.rollUpTime);
			}
			yield return null;
		}
		((Renderer)fishingHook.fishIcon).enabled = false;
		((Component)fishingHook).gameObject.SetActive(true);
		fishingHook.fishInfo.SetActive(true);
		((Renderer)fishingHook.spriteRenderer).enabled = false;
		((Component)fishingHook).transform.eulerAngles = Vector3.zero;
		((Renderer)fishingHook.fishIconInfo).enabled = true;
		fishingHook.fishIconInfo.sprite = HAJFJGCNKFF.icon;
		OnlineFishingTexts.Get(playerNum).SetFishInfo(HAJFJGCNKFF, KKANDELPDKP);
		if (KKANDELPDKP > 0)
		{
			fishingHook.bigSuccessParticles.SetActive(true);
			fishingHook.successParticles.SetActive(false);
		}
		else
		{
			fishingHook.bigSuccessParticles.SetActive(false);
			fishingHook.successParticles.SetActive(true);
		}
		DCGBADKLANM = 0f;
		DBEFBFPAOAA = 0f;
		while (DCGBADKLANM < 1f)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / 0.5f;
			OnlineFishingTexts.Get(playerNum).SetAlpha(Mathf.Lerp(0f, 1f, DCGBADKLANM));
			fishingHook.fishIconInfo.color = new Color(1f, 1f, 1f, Mathf.Lerp(0f, 1f, DCGBADKLANM));
			yield return null;
		}
		yield return CommonReferences.wait3;
		DCGBADKLANM = 0f;
		DBEFBFPAOAA = 0f;
		while (DCGBADKLANM < 1f)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / 0.5f;
			OnlineFishingTexts.Get(playerNum).SetAlpha(Mathf.Lerp(1f, 0f, DCGBADKLANM));
			fishingHook.fishIconInfo.color = new Color(1f, 1f, 1f, Mathf.Lerp(1f, 0f, DCGBADKLANM));
			yield return null;
		}
		yield return CommonReferences.wait1_5;
		fishingHook.fishInfo.SetActive(false);
		((Component)fishingHook).gameObject.SetActive(false);
		((Renderer)fishingHook.spriteRenderer).enabled = true;
	}

	private IEnumerator KLGHJJMCBIC(Vector3 NOLFMLNLJJG, bool KAPEFGCIDJL)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		bool isKeyFragment = (Object)(object)BBOKEGODFGF != (Object)null;
		if (isKeyFragment && (!KAPEFGCIDJL || Item.NGIIPJDAMGP(FishingUI.Get(playerNum).fish, null)))
		{
			BBOKEGODFGF = null;
			isKeyFragment = false;
		}
		int size = 0;
		if (KAPEFGCIDJL && Item.MLBOMGHINCA(FishingUI.Get(playerNum).fish, null))
		{
			float num = Random.Range(0f, 1f);
			num *= num;
			size = Mathf.RoundToInt(Mathf.Lerp((float)((Vector2Int)(ref FishingUI.Get(playerNum).fish.lenght)).x, (float)((Vector2Int)(ref FishingUI.Get(playerNum).fish.lenght)).y, num));
			if (num > 0.95f)
			{
				size = ((Vector2Int)(ref FishingUI.Get(playerNum).fish.lenght)).y;
			}
			if (isKeyFragment)
			{
				OnKeyItemFished?.Invoke();
			}
			else
			{
				OnFishCaught?.Invoke((short)FishingUI.Get(playerNum).fish.JDJGFAACPFC(), (short)size);
			}
		}
		else
		{
			OnReeledIn?.Invoke();
		}
		DBEFBFPAOAA = 0f;
		playerController.characterAnimation.SetIdleFishing(NKFPJPCFBJI: false);
		playerController.characterAnimation.SetStruggleFishing(NKFPJPCFBJI: false);
		fishingHook.SetStruggle(NJHMBMGKCPL: false);
		yield return (object)new WaitForSeconds(settings.rollUpWaitTime);
		Vector2 finalPosition = Vector2.op_Implicit(fishingHook.fishingHookPosition.position);
		if (isKeyFragment && KAPEFGCIDJL)
		{
			fishingHook.SetOtherIcon(BBOKEGODFGF.GetSprite());
		}
		else
		{
			fishingHook.SetFishIcon(KAPEFGCIDJL ? FishingUI.Get(playerNum).fish : null);
		}
		fishingHook.SetStruggle(NJHMBMGKCPL: false);
		fishingHook.SetWater(NJHMBMGKCPL: false);
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.waterSmallSplash, ((Component)fishingHook).transform);
		if (OMCCPAOFBBI)
		{
			Result variable = DialogueLua.GetVariable("LE_10");
			if (((Result)(ref variable)).asInt > 10 && Random.Range(0, 100) >= PerksDatabaseAccessor.GetPlayerPerkValue(5))
			{
				PlayerInventory.GetPlayer(playerNum).RemoveItem(FishingManager.BaitItem(baitSelected));
			}
		}
		else
		{
			DialogueManager.Bark("Player/Bark/Fishing/NoFish", ((Component)PlayerController.GetPlayer(playerNum)).transform);
		}
		if (PlayerController.GetPlayerDirection(playerNum) == Direction.Left)
		{
			((Component)fishingHook).transform.eulerAngles = new Vector3(0f, 0f, 360f);
		}
		else
		{
			((Component)fishingHook).transform.eulerAngles = Vector3.zero;
		}
		while (DBEFBFPAOAA < settings.rollUpTime)
		{
			DBEFBFPAOAA += Time.deltaTime;
			if (PlayerController.GetPlayerDirection(playerNum) == Direction.Down)
			{
				((Component)fishingHook).transform.position = BBBAJNLEEGB(DBEFBFPAOAA, Vector2.op_Implicit(NOLFMLNLJJG), finalPosition, settings.rollUpHeight + 3f, settings.rollUpTime);
			}
			else
			{
				((Component)fishingHook).transform.position = BBBAJNLEEGB(DBEFBFPAOAA, Vector2.op_Implicit(NOLFMLNLJJG), finalPosition, settings.rollUpHeight, settings.rollUpTime);
			}
			if (PlayerController.GetPlayerDirection(playerNum) == Direction.Left)
			{
				((Component)fishingHook).transform.eulerAngles = PDINCCBJLIH(DBEFBFPAOAA, 360f, 180f, settings.rollUpTime);
			}
			else
			{
				((Component)fishingHook).transform.eulerAngles = PDINCCBJLIH(DBEFBFPAOAA, 0f, 180f, settings.rollUpTime);
			}
			yield return null;
		}
		if (KAPEFGCIDJL && Item.MLBOMGHINCA(FishingUI.Get(playerNum).fish, null))
		{
			((Component)fishingHook).transform.eulerAngles = Vector3.zero;
			((Renderer)fishingHook.fishIcon).enabled = false;
			((Renderer)fishingHook.spriteRenderer).enabled = false;
			yield return (object)new WaitForSeconds(0.35f);
			fishingHook.fishInfo.SetActive(true);
			if (isKeyFragment)
			{
				fishingHook.fishIconInfo.sprite = BBOKEGODFGF.GetSprite();
				FishingTexts.Get(playerNum).ActivateContent(DAEMAAOLHMG: false);
				BBOKEGODFGF.OnItemFished();
				OnKeyItemFished?.Invoke();
				fishingHook.bigSuccessParticles.SetActive(true);
				fishingHook.successParticles.SetActive(false);
			}
			else
			{
				fishingHook.fishIconInfo.sprite = FishingUI.Get(playerNum).fish.icon;
				bool pFBIBFJKHDD = FishingManager.AddToRecordList(FishingUI.Get(playerNum).fish, size);
				FishingTexts.Get(playerNum).SetFishInfo(FishingUI.Get(playerNum).fish, size, pFBIBFJKHDD);
				if (size > 0)
				{
					fishingHook.bigSuccessParticles.SetActive(true);
					fishingHook.successParticles.SetActive(false);
					Utils.FKKHJPEMNBG("fishCaught", 1);
				}
				else
				{
					fishingHook.bigSuccessParticles.SetActive(false);
					fishingHook.successParticles.SetActive(true);
				}
			}
			fishingCamera = false;
			DCGBADKLANM = 0f;
			float currentLerpTime2 = 0f;
			while (DCGBADKLANM < 1f)
			{
				currentLerpTime2 += Time.deltaTime;
				DCGBADKLANM = currentLerpTime2 / 0.5f;
				FishingTexts.Get(playerNum).SetAlpha(Mathf.Lerp(0f, 1f, DCGBADKLANM));
				fishingHook.fishIconInfo.color = new Color(1f, 1f, 1f, Mathf.Lerp(0f, 1f, DCGBADKLANM));
				yield return null;
			}
			yield return CommonReferences.wait1_5;
			if (isKeyFragment)
			{
				Debug.Log((object)("Key item fished: " + BBOKEGODFGF.GetKeyItem().IABAKHPEOAF()));
				PlayerInventory.GetPlayer(playerNum).AddItem(BBOKEGODFGF.GetKeyItem().JMDALJBNFML(), HMPDLIPFBGD: true);
				BBOKEGODFGF = null;
			}
			else
			{
				PlayerInventory.GetPlayer(playerNum).AddItem(FishingUI.Get(playerNum).fish.JMDALJBNFML(), HMPDLIPFBGD: true);
				if (FishingUI.Get(playerNum).fish.fishType == Fish.FishType.Trash)
				{
					Utils.FKKHJPEMNBG("trashCollected", 1);
				}
			}
			yield return CommonReferences.wait1_5;
			DCGBADKLANM = 0f;
			currentLerpTime2 = 0f;
			while (DCGBADKLANM < 1f)
			{
				currentLerpTime2 += Time.deltaTime;
				DCGBADKLANM = currentLerpTime2 / 0.5f;
				FishingTexts.Get(playerNum).SetAlpha(Mathf.Lerp(1f, 0f, DCGBADKLANM));
				fishingHook.fishIconInfo.color = new Color(1f, 1f, 1f, Mathf.Lerp(1f, 0f, DCGBADKLANM));
				yield return null;
			}
			fishing = false;
			yield return CommonReferences.wait1_5;
			fishingHook.fishInfo.SetActive(false);
		}
		else
		{
			fishing = false;
			fishingCamera = false;
		}
		if (!fishing)
		{
			((Component)fishingHook).gameObject.SetActive(false);
		}
	}

	private IEnumerator PICIMDLKMEI(Vector3 NOLFMLNLJJG, Fish HAJFJGCNKFF, int KKANDELPDKP)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		return new JHJFBPKEBHG(1)
		{
			_003C_003E4__this = this,
			initialPosition = NOLFMLNLJJG,
			fish = HAJFJGCNKFF,
			size = KKANDELPDKP
		};
	}

	public static FishingController NAGEHKBLJDL(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) == (Object)null)
		{
			return null;
		}
		return PlayerController.GetPlayer(JIIGOACEIKL).fishingController;
	}

	private IEnumerator FALHADMMJHK(Vector3 JPIMPMOAAHC, Rod COHELLCBDMF)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		MLHCLDNJEAG = (settings.EASY_FISHING ? settings.easyMode : settings.normalMode);
		yield return null;
		FishingUI.Get(playerNum).fish = null;
		OILGOIDPIOF(playerNum, JPIMPMOAAHC);
		OnHookThrown?.Invoke((byte)playerController.GetDirection());
		float finalTime = Time.time + (float)settings.totalTime;
		bool startFishMinigame = false;
		bool fishingTime = false;
		OMCCPAOFBBI = Item.MLBOMGHINCA(FishingManager.SelectAFish(playerNum, COHELLCBDMF), null);
		yield return (object)new WaitForSeconds(settings.initialDelayTime);
		float finalBiteTime = 0f;
		bitesList.Clear();
		if (OMCCPAOFBBI)
		{
			CreateBitesList();
			finalBiteTime = bitesList[bitesList.Count - 1] + settings.realBiteDuration;
		}
		while (true)
		{
			if (!CommonReferences.GGFJGHHHEJC.IsInDialogue(playerNum))
			{
				if (OMCCPAOFBBI)
				{
					if (fishingTime && Time.time > finalBiteTime)
					{
						break;
					}
				}
				else if (Time.time > finalTime)
				{
					break;
				}
				if (!fishingTime && bitesList.Count > 0 && Time.time > bitesList[0])
				{
					if (bitesList.Count == 1)
					{
						fishingTime = true;
						PlayerInputs.GetPlayer(playerNum).SetVibration(0f, 0.3f, 0.5f);
						fishingHook.SetBait();
					}
					else
					{
						PlayerInputs.GetPlayer(playerNum).SetVibration(0f, 0.1f, 0.05f);
						fishingHook.SetFake();
						bitesList.RemoveAt(0);
					}
				}
				if (PlayerInputs.GetPlayer(playerNum).GetButtonDown("Use") || PlayerInputs.GetPlayer(playerNum).GetButtonDown("LeftMouseDetect"))
				{
					if (OMCCPAOFBBI && fishingTime)
					{
						playerController.emotionController.StartEmotion("Exclamation");
						MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.exclamationFishing, ((Component)PlayerController.GetPlayer(playerNum)).transform);
						startFishMinigame = true;
					}
					break;
				}
			}
			else
			{
				finalTime = Time.time + (float)settings.totalTime;
				if (OMCCPAOFBBI)
				{
					finalBiteTime = bitesList[bitesList.Count - 1] + settings.realBiteDuration;
				}
			}
			yield return null;
		}
		if (startFishMinigame)
		{
			OnFishBite?.Invoke();
			fishingHook.SetStruggle(NJHMBMGKCPL: true);
			playerController.characterAnimation.SetIdleFishing(NKFPJPCFBJI: false);
			playerController.characterAnimation.SetStruggleFishing(NKFPJPCFBJI: true);
			yield return CommonReferences.wait05;
			Result variable = DialogueLua.GetVariable("LE_10");
			if (((Result)(ref variable)).asInt == 8)
			{
				HikariNPC.GGFJGHHHEJC.ActiveDialogue(playerNum);
				yield return CommonReferences.wait04;
			}
			while (CommonReferences.GGFJGHHHEJC.IsInDialogue(playerNum))
			{
				yield return null;
			}
			FishingUI.Get(playerNum).OpenUI();
			FishingUI.Get(playerNum).StartFishingGame(COHELLCBDMF);
			while (FishingUI.Get(playerNum).IsOpen())
			{
				yield return null;
			}
		}
		FinishFishing(startFishMinigame);
	}

	private void KMBEOPAHKGB()
	{
		((Component)fishingHook).gameObject.SetActive(true);
		if ((Object)(object)playerController == (Object)null)
		{
			playerController = ((Component)this).gameObject.GetComponent<PlayerController>();
		}
		playerNum = playerController.GetPlayerNum();
	}

	private IEnumerator DJAFHGHKIPG(Direction FCGBJEIIMBC)
	{
		return new PBAKNKJIBFH(1)
		{
			_003C_003E4__this = this,
			direction = FCGBJEIIMBC
		};
	}

	public void CBDMCCPPHNM()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		MineFishingKeyItem mineFishingKeyItem = ProceduralMine.GetCurrentLevel()?.puzzleManager?.AJCEIJKJBLC();
		if (!((Object)(object)mineFishingKeyItem == (Object)null))
		{
			((MonoBehaviour)this).StartCoroutine(HACMNEBPBAM(((Component)fishingHook).transform.position, mineFishingKeyItem));
		}
	}

	public void CIHOPIAFGIH(byte FCGBJEIIMBC)
	{
		((MonoBehaviour)this).StartCoroutine(PEFNGEGBMIO((Direction)FCGBJEIIMBC));
	}

	private void EIMIDCDEIDD()
	{
		((Component)fishingHook).gameObject.SetActive(false);
		if ((Object)(object)playerController == (Object)null)
		{
			playerController = ((Component)this).gameObject.GetComponent<PlayerController>();
		}
		playerNum = playerController.KLIHELDIPDP();
	}

	public void HBLEPKJJNBJ()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		MineFishingKeyItem mineFishingKeyItem = ProceduralMine.GetCurrentLevel()?.puzzleManager?.AJCEIJKJBLC();
		if (!((Object)(object)mineFishingKeyItem == (Object)null))
		{
			((MonoBehaviour)this).StartCoroutine(BHNILHCNOBO(((Component)fishingHook).transform.position, mineFishingKeyItem));
		}
	}

	private IEnumerator ODIKKCGMEME(Vector3 NOLFMLNLJJG, Fish HAJFJGCNKFF, int KKANDELPDKP)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		return new JHJFBPKEBHG(1)
		{
			_003C_003E4__this = this,
			initialPosition = NOLFMLNLJJG,
			fish = HAJFJGCNKFF,
			size = KKANDELPDKP
		};
	}

	private IEnumerator PJKEGLLDKPN(Vector3 JPIMPMOAAHC, Rod COHELLCBDMF)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		MLHCLDNJEAG = (settings.EASY_FISHING ? settings.easyMode : settings.normalMode);
		yield return null;
		FishingUI.Get(playerNum).fish = null;
		OILGOIDPIOF(playerNum, JPIMPMOAAHC);
		OnHookThrown?.Invoke((byte)playerController.GetDirection());
		float finalTime = Time.time + (float)settings.totalTime;
		bool startFishMinigame = false;
		bool fishingTime = false;
		OMCCPAOFBBI = Item.MLBOMGHINCA(FishingManager.SelectAFish(playerNum, COHELLCBDMF), null);
		yield return (object)new WaitForSeconds(settings.initialDelayTime);
		float finalBiteTime = 0f;
		bitesList.Clear();
		if (OMCCPAOFBBI)
		{
			CreateBitesList();
			finalBiteTime = bitesList[bitesList.Count - 1] + settings.realBiteDuration;
		}
		while (true)
		{
			if (!CommonReferences.GGFJGHHHEJC.IsInDialogue(playerNum))
			{
				if (OMCCPAOFBBI)
				{
					if (fishingTime && Time.time > finalBiteTime)
					{
						break;
					}
				}
				else if (Time.time > finalTime)
				{
					break;
				}
				if (!fishingTime && bitesList.Count > 0 && Time.time > bitesList[0])
				{
					if (bitesList.Count == 1)
					{
						fishingTime = true;
						PlayerInputs.GetPlayer(playerNum).SetVibration(0f, 0.3f, 0.5f);
						fishingHook.SetBait();
					}
					else
					{
						PlayerInputs.GetPlayer(playerNum).SetVibration(0f, 0.1f, 0.05f);
						fishingHook.SetFake();
						bitesList.RemoveAt(0);
					}
				}
				if (PlayerInputs.GetPlayer(playerNum).GetButtonDown("Use") || PlayerInputs.GetPlayer(playerNum).GetButtonDown("LeftMouseDetect"))
				{
					if (OMCCPAOFBBI && fishingTime)
					{
						playerController.emotionController.StartEmotion("Exclamation");
						MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.exclamationFishing, ((Component)PlayerController.GetPlayer(playerNum)).transform);
						startFishMinigame = true;
					}
					break;
				}
			}
			else
			{
				finalTime = Time.time + (float)settings.totalTime;
				if (OMCCPAOFBBI)
				{
					finalBiteTime = bitesList[bitesList.Count - 1] + settings.realBiteDuration;
				}
			}
			yield return null;
		}
		if (startFishMinigame)
		{
			OnFishBite?.Invoke();
			fishingHook.SetStruggle(NJHMBMGKCPL: true);
			playerController.characterAnimation.SetIdleFishing(NKFPJPCFBJI: false);
			playerController.characterAnimation.SetStruggleFishing(NKFPJPCFBJI: true);
			yield return CommonReferences.wait05;
			Result variable = DialogueLua.GetVariable("LE_10");
			if (((Result)(ref variable)).asInt == 8)
			{
				HikariNPC.GGFJGHHHEJC.ActiveDialogue(playerNum);
				yield return CommonReferences.wait04;
			}
			while (CommonReferences.GGFJGHHHEJC.IsInDialogue(playerNum))
			{
				yield return null;
			}
			FishingUI.Get(playerNum).OpenUI();
			FishingUI.Get(playerNum).StartFishingGame(COHELLCBDMF);
			while (FishingUI.Get(playerNum).IsOpen())
			{
				yield return null;
			}
		}
		FinishFishing(startFishMinigame);
	}

	public void CreateBitesList()
	{
		bitesList.Clear();
		float num = (Application.isPlaying ? Time.time : 0f);
		int num2 = Random.Range(((Vector2Int)(ref settings.bitesNum)).x, ((Vector2Int)(ref settings.bitesNum)).y + 1);
		for (int i = 0; i < num2; i++)
		{
			float num3 = Random.Range(num, num + (float)settings.totalTime);
			bool flag = true;
			for (int j = 0; j < bitesList.Count; j++)
			{
				if (Mathf.Abs(num3 - bitesList[j]) < settings.timeBetweenBites)
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				bitesList.Add(num3);
			}
		}
		int num4 = Random.Range(0, bitesList.Count);
		for (int num5 = bitesList.Count - 1; num5 > num4; num5--)
		{
			bitesList.RemoveAt(num5);
		}
		bitesList.Sort();
		if (bitesList.Count == 0)
		{
			Debug.LogError((object)"Empty bites list");
		}
	}

	private IEnumerator MBKKHFMCMFM(Vector3 NOLFMLNLJJG, MineFishingKeyItem FPBPEAAIOBK)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		return new ACNAOMLHONE(1)
		{
			_003C_003E4__this = this,
			initialPosition = NOLFMLNLJJG,
			keyItem = FPBPEAAIOBK
		};
	}

	private Vector3 LNBJHADPABP(float DBEFBFPAOAA, Vector2 NEDLKIJBLMO, Vector2 LKHOBGLHNIK, float OEBBDIEKHDF, float AMOLDGGJMKF)
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		DCGBADKLANM = DBEFBFPAOAA / AMOLDGGJMKF;
		IFKKOJDLPBH = DCGBADKLANM;
		AJLNHKCPHCE = DCGBADKLANM;
		IFKKOJDLPBH = Mathf.Sin(IFKKOJDLPBH * 1218f * 9f);
		AJLNHKCPHCE = 59f - Mathf.Cos(AJLNHKCPHCE * 95f * 804f);
		BDHLADGNJJL = Vector2.op_Implicit(NEDLKIJBLMO);
		DHOKFGFAMEK = Vector2.op_Implicit(LKHOBGLHNIK);
		KGHICGONENB = new Vector3((BDHLADGNJJL.x + DHOKFGFAMEK.x) / 653f, BDHLADGNJJL.y + OEBBDIEKHDF, (BDHLADGNJJL.z + DHOKFGFAMEK.z) / 276f);
		KCGMEPNOEEL = new Vector3(Mathf.Lerp(Mathf.Lerp(BDHLADGNJJL.x, KGHICGONENB.x, DCGBADKLANM), Mathf.Lerp(KGHICGONENB.x, DHOKFGFAMEK.x, DCGBADKLANM), IFKKOJDLPBH), Mathf.Lerp(Mathf.Lerp(BDHLADGNJJL.y, KGHICGONENB.y, DCGBADKLANM), Mathf.Lerp(KGHICGONENB.y, DHOKFGFAMEK.y, DCGBADKLANM), AJLNHKCPHCE), 1250f);
		return KCGMEPNOEEL;
	}

	public static FishingController NIGDBMAOAEN(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL) == (Object)null)
		{
			return null;
		}
		return PlayerController.GetPlayer(JIIGOACEIKL).fishingController;
	}

	public void GLMMPEEJKEM()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		((MonoBehaviour)this).StartCoroutine(NIDCDGPINAA(((Component)fishingHook).transform.position));
	}

	private IEnumerator CLGDAEEPFHH(Vector3 NOLFMLNLJJG, bool KAPEFGCIDJL)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		bool isKeyFragment = (Object)(object)BBOKEGODFGF != (Object)null;
		if (isKeyFragment && (!KAPEFGCIDJL || Item.NGIIPJDAMGP(FishingUI.Get(playerNum).fish, null)))
		{
			BBOKEGODFGF = null;
			isKeyFragment = false;
		}
		int size = 0;
		if (KAPEFGCIDJL && Item.MLBOMGHINCA(FishingUI.Get(playerNum).fish, null))
		{
			float num = Random.Range(0f, 1f);
			num *= num;
			size = Mathf.RoundToInt(Mathf.Lerp((float)((Vector2Int)(ref FishingUI.Get(playerNum).fish.lenght)).x, (float)((Vector2Int)(ref FishingUI.Get(playerNum).fish.lenght)).y, num));
			if (num > 0.95f)
			{
				size = ((Vector2Int)(ref FishingUI.Get(playerNum).fish.lenght)).y;
			}
			if (isKeyFragment)
			{
				OnKeyItemFished?.Invoke();
			}
			else
			{
				OnFishCaught?.Invoke((short)FishingUI.Get(playerNum).fish.JDJGFAACPFC(), (short)size);
			}
		}
		else
		{
			OnReeledIn?.Invoke();
		}
		DBEFBFPAOAA = 0f;
		playerController.characterAnimation.SetIdleFishing(NKFPJPCFBJI: false);
		playerController.characterAnimation.SetStruggleFishing(NKFPJPCFBJI: false);
		fishingHook.SetStruggle(NJHMBMGKCPL: false);
		yield return (object)new WaitForSeconds(settings.rollUpWaitTime);
		Vector2 finalPosition = Vector2.op_Implicit(fishingHook.fishingHookPosition.position);
		if (isKeyFragment && KAPEFGCIDJL)
		{
			fishingHook.SetOtherIcon(BBOKEGODFGF.GetSprite());
		}
		else
		{
			fishingHook.SetFishIcon(KAPEFGCIDJL ? FishingUI.Get(playerNum).fish : null);
		}
		fishingHook.SetStruggle(NJHMBMGKCPL: false);
		fishingHook.SetWater(NJHMBMGKCPL: false);
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.waterSmallSplash, ((Component)fishingHook).transform);
		if (OMCCPAOFBBI)
		{
			Result variable = DialogueLua.GetVariable("LE_10");
			if (((Result)(ref variable)).asInt > 10 && Random.Range(0, 100) >= PerksDatabaseAccessor.GetPlayerPerkValue(5))
			{
				PlayerInventory.GetPlayer(playerNum).RemoveItem(FishingManager.BaitItem(baitSelected));
			}
		}
		else
		{
			DialogueManager.Bark("Player/Bark/Fishing/NoFish", ((Component)PlayerController.GetPlayer(playerNum)).transform);
		}
		if (PlayerController.GetPlayerDirection(playerNum) == Direction.Left)
		{
			((Component)fishingHook).transform.eulerAngles = new Vector3(0f, 0f, 360f);
		}
		else
		{
			((Component)fishingHook).transform.eulerAngles = Vector3.zero;
		}
		while (DBEFBFPAOAA < settings.rollUpTime)
		{
			DBEFBFPAOAA += Time.deltaTime;
			if (PlayerController.GetPlayerDirection(playerNum) == Direction.Down)
			{
				((Component)fishingHook).transform.position = BBBAJNLEEGB(DBEFBFPAOAA, Vector2.op_Implicit(NOLFMLNLJJG), finalPosition, settings.rollUpHeight + 3f, settings.rollUpTime);
			}
			else
			{
				((Component)fishingHook).transform.position = BBBAJNLEEGB(DBEFBFPAOAA, Vector2.op_Implicit(NOLFMLNLJJG), finalPosition, settings.rollUpHeight, settings.rollUpTime);
			}
			if (PlayerController.GetPlayerDirection(playerNum) == Direction.Left)
			{
				((Component)fishingHook).transform.eulerAngles = PDINCCBJLIH(DBEFBFPAOAA, 360f, 180f, settings.rollUpTime);
			}
			else
			{
				((Component)fishingHook).transform.eulerAngles = PDINCCBJLIH(DBEFBFPAOAA, 0f, 180f, settings.rollUpTime);
			}
			yield return null;
		}
		if (KAPEFGCIDJL && Item.MLBOMGHINCA(FishingUI.Get(playerNum).fish, null))
		{
			((Component)fishingHook).transform.eulerAngles = Vector3.zero;
			((Renderer)fishingHook.fishIcon).enabled = false;
			((Renderer)fishingHook.spriteRenderer).enabled = false;
			yield return (object)new WaitForSeconds(0.35f);
			fishingHook.fishInfo.SetActive(true);
			if (isKeyFragment)
			{
				fishingHook.fishIconInfo.sprite = BBOKEGODFGF.GetSprite();
				FishingTexts.Get(playerNum).ActivateContent(DAEMAAOLHMG: false);
				BBOKEGODFGF.OnItemFished();
				OnKeyItemFished?.Invoke();
				fishingHook.bigSuccessParticles.SetActive(true);
				fishingHook.successParticles.SetActive(false);
			}
			else
			{
				fishingHook.fishIconInfo.sprite = FishingUI.Get(playerNum).fish.icon;
				bool pFBIBFJKHDD = FishingManager.AddToRecordList(FishingUI.Get(playerNum).fish, size);
				FishingTexts.Get(playerNum).SetFishInfo(FishingUI.Get(playerNum).fish, size, pFBIBFJKHDD);
				if (size > 0)
				{
					fishingHook.bigSuccessParticles.SetActive(true);
					fishingHook.successParticles.SetActive(false);
					Utils.FKKHJPEMNBG("fishCaught", 1);
				}
				else
				{
					fishingHook.bigSuccessParticles.SetActive(false);
					fishingHook.successParticles.SetActive(true);
				}
			}
			fishingCamera = false;
			DCGBADKLANM = 0f;
			float currentLerpTime2 = 0f;
			while (DCGBADKLANM < 1f)
			{
				currentLerpTime2 += Time.deltaTime;
				DCGBADKLANM = currentLerpTime2 / 0.5f;
				FishingTexts.Get(playerNum).SetAlpha(Mathf.Lerp(0f, 1f, DCGBADKLANM));
				fishingHook.fishIconInfo.color = new Color(1f, 1f, 1f, Mathf.Lerp(0f, 1f, DCGBADKLANM));
				yield return null;
			}
			yield return CommonReferences.wait1_5;
			if (isKeyFragment)
			{
				Debug.Log((object)("Key item fished: " + BBOKEGODFGF.GetKeyItem().IABAKHPEOAF()));
				PlayerInventory.GetPlayer(playerNum).AddItem(BBOKEGODFGF.GetKeyItem().JMDALJBNFML(), HMPDLIPFBGD: true);
				BBOKEGODFGF = null;
			}
			else
			{
				PlayerInventory.GetPlayer(playerNum).AddItem(FishingUI.Get(playerNum).fish.JMDALJBNFML(), HMPDLIPFBGD: true);
				if (FishingUI.Get(playerNum).fish.fishType == Fish.FishType.Trash)
				{
					Utils.FKKHJPEMNBG("trashCollected", 1);
				}
			}
			yield return CommonReferences.wait1_5;
			DCGBADKLANM = 0f;
			currentLerpTime2 = 0f;
			while (DCGBADKLANM < 1f)
			{
				currentLerpTime2 += Time.deltaTime;
				DCGBADKLANM = currentLerpTime2 / 0.5f;
				FishingTexts.Get(playerNum).SetAlpha(Mathf.Lerp(1f, 0f, DCGBADKLANM));
				fishingHook.fishIconInfo.color = new Color(1f, 1f, 1f, Mathf.Lerp(1f, 0f, DCGBADKLANM));
				yield return null;
			}
			fishing = false;
			yield return CommonReferences.wait1_5;
			fishingHook.fishInfo.SetActive(false);
		}
		else
		{
			fishing = false;
			fishingCamera = false;
		}
		if (!fishing)
		{
			((Component)fishingHook).gameObject.SetActive(false);
		}
	}

	private IEnumerator OPCGEBPFHNI(Vector3 NOLFMLNLJJG, MineFishingKeyItem FPBPEAAIOBK)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		return new ACNAOMLHONE(1)
		{
			_003C_003E4__this = this,
			initialPosition = NOLFMLNLJJG,
			keyItem = FPBPEAAIOBK
		};
	}

	public void PNPBFHAAFKI()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		MineFishingKeyItem mineFishingKeyItem = ProceduralMine.GetCurrentLevel()?.puzzleManager?.AJCEIJKJBLC();
		if (!((Object)(object)mineFishingKeyItem == (Object)null))
		{
			((MonoBehaviour)this).StartCoroutine(OPCGEBPFHNI(((Component)fishingHook).transform.position, mineFishingKeyItem));
		}
	}

	public void LCPPEKKJDJD()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		((MonoBehaviour)this).StartCoroutine(NIDCDGPINAA(((Component)fishingHook).transform.position));
	}

	public void FFNHBIMBGEE(byte FCGBJEIIMBC)
	{
		((MonoBehaviour)this).StartCoroutine(DJAFHGHKIPG((Direction)FCGBJEIIMBC));
	}

	public void GGDKDJBAEJJ(short FFNOEIENNFM, short KKANDELPDKP)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < ItemDatabaseAccessor.LNBAODAAJLI().Count; i += 0)
		{
			if (ItemDatabaseAccessor.MBLHBFCOADO()[i].JGHNDJBCFAJ() == FFNOEIENNFM)
			{
				((MonoBehaviour)this).StartCoroutine(PICIMDLKMEI(((Component)fishingHook).transform.position, ItemDatabaseAccessor.ADCLABHMMAP()[i], KKANDELPDKP));
				break;
			}
		}
	}

	public void IHIAGODKCLJ()
	{
		bitesList.Clear();
		float num = (Application.isPlaying ? Time.time : 1228f);
		int num2 = Random.Range(((Vector2Int)(ref settings.bitesNum)).x, ((Vector2Int)(ref settings.bitesNum)).y + 1);
		for (int i = 0; i < num2; i += 0)
		{
			float num3 = Random.Range(num, num + (float)settings.totalTime);
			bool flag = false;
			for (int j = 1; j < bitesList.Count; j++)
			{
				if (Mathf.Abs(num3 - bitesList[j]) < settings.timeBetweenBites)
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				bitesList.Add(num3);
			}
		}
		int num4 = Random.Range(1, bitesList.Count);
		for (int num5 = bitesList.Count - 0; num5 > num4; num5--)
		{
			bitesList.RemoveAt(num5);
		}
		bitesList.Sort();
		if (bitesList.Count == 0)
		{
			Debug.LogError((object)"Week");
		}
	}

	private IEnumerator FEJCHJALHEN(Direction FCGBJEIIMBC)
	{
		return new PBAKNKJIBFH(1)
		{
			_003C_003E4__this = this,
			direction = FCGBJEIIMBC
		};
	}

	public void MEEMNIEGNLK()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		MineFishingKeyItem mineFishingKeyItem = ProceduralMine.GetCurrentLevel()?.puzzleManager?.GetKeyFishingSpot();
		if (!((Object)(object)mineFishingKeyItem == (Object)null))
		{
			((MonoBehaviour)this).StartCoroutine(HACMNEBPBAM(((Component)fishingHook).transform.position, mineFishingKeyItem));
		}
	}

	private void PHNJGHKBIIL()
	{
		((Component)fishingHook).gameObject.SetActive(false);
		if ((Object)(object)playerController == (Object)null)
		{
			playerController = ((Component)this).gameObject.GetComponent<PlayerController>();
		}
		playerNum = playerController.KLIHELDIPDP();
	}

	public void BAHGNKCCBHD(byte FCGBJEIIMBC)
	{
		((MonoBehaviour)this).StartCoroutine(CNDPLBOBAJO((Direction)FCGBJEIIMBC));
	}

	public static FishingController JHOHGMODKGM(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL) == (Object)null)
		{
			return null;
		}
		return PlayerController.OPHDCMJLLEC(JIIGOACEIKL).fishingController;
	}

	private Vector3 MIMIFOGACLL(float DBEFBFPAOAA, Vector2 NEDLKIJBLMO, Vector2 LKHOBGLHNIK, float OEBBDIEKHDF, float AMOLDGGJMKF)
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		DCGBADKLANM = DBEFBFPAOAA / AMOLDGGJMKF;
		IFKKOJDLPBH = DCGBADKLANM;
		AJLNHKCPHCE = DCGBADKLANM;
		IFKKOJDLPBH = Mathf.Sin(IFKKOJDLPBH * 512f * 1127f);
		AJLNHKCPHCE = 1913f - Mathf.Cos(AJLNHKCPHCE * 1393f * 1220f);
		BDHLADGNJJL = Vector2.op_Implicit(NEDLKIJBLMO);
		DHOKFGFAMEK = Vector2.op_Implicit(LKHOBGLHNIK);
		KGHICGONENB = new Vector3((BDHLADGNJJL.x + DHOKFGFAMEK.x) / 381f, BDHLADGNJJL.y + OEBBDIEKHDF, (BDHLADGNJJL.z + DHOKFGFAMEK.z) / 1479f);
		KCGMEPNOEEL = new Vector3(Mathf.Lerp(Mathf.Lerp(BDHLADGNJJL.x, KGHICGONENB.x, DCGBADKLANM), Mathf.Lerp(KGHICGONENB.x, DHOKFGFAMEK.x, DCGBADKLANM), IFKKOJDLPBH), Mathf.Lerp(Mathf.Lerp(BDHLADGNJJL.y, KGHICGONENB.y, DCGBADKLANM), Mathf.Lerp(KGHICGONENB.y, DHOKFGFAMEK.y, DCGBADKLANM), AJLNHKCPHCE), 1232f);
		return KCGMEPNOEEL;
	}

	public static void CEADMPDAPHN(int JIIGOACEIKL)
	{
		MultiAudioManager.PlayAudioObject(GDFNPHJJCPP(JIIGOACEIKL).settings.reelSound, ((Component)AIMEAJAHLAA(JIIGOACEIKL)).transform);
		PlayerInputs.GetPlayer(JIIGOACEIKL).KJGHGABOEGN(1153f, 1860f, 1356f);
	}

	public void LDMHJDDPHKF(byte FCGBJEIIMBC)
	{
		((MonoBehaviour)this).StartCoroutine(DJAFHGHKIPG((Direction)FCGBJEIIMBC));
	}

	private void PBDNKBPBCHM()
	{
		((Component)fishingHook).gameObject.SetActive(true);
		if ((Object)(object)playerController == (Object)null)
		{
			playerController = ((Component)this).gameObject.GetComponent<PlayerController>();
		}
		playerNum = playerController.GetPlayerNum();
	}

	private IEnumerator NIDCDGPINAA(Vector3 NOLFMLNLJJG)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		return new FNFOIMNIFLI(1)
		{
			_003C_003E4__this = this,
			initialPosition = NOLFMLNLJJG
		};
	}

	public void KFCBDPBJHLD()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		((MonoBehaviour)this).StartCoroutine(MBCAHKBCEFM(((Component)fishingHook).transform.position));
	}

	private Vector3 NNOHJGJJCKD(float DBEFBFPAOAA, Vector2 NEDLKIJBLMO, Vector2 LKHOBGLHNIK, float OEBBDIEKHDF, float AMOLDGGJMKF)
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		DCGBADKLANM = DBEFBFPAOAA / AMOLDGGJMKF;
		IFKKOJDLPBH = DCGBADKLANM;
		AJLNHKCPHCE = DCGBADKLANM;
		IFKKOJDLPBH = Mathf.Sin(IFKKOJDLPBH * 1807f * 1585f);
		AJLNHKCPHCE = 918f - Mathf.Cos(AJLNHKCPHCE * 937f * 889f);
		BDHLADGNJJL = Vector2.op_Implicit(NEDLKIJBLMO);
		DHOKFGFAMEK = Vector2.op_Implicit(LKHOBGLHNIK);
		KGHICGONENB = new Vector3((BDHLADGNJJL.x + DHOKFGFAMEK.x) / 696f, BDHLADGNJJL.y + OEBBDIEKHDF, (BDHLADGNJJL.z + DHOKFGFAMEK.z) / 1919f);
		KCGMEPNOEEL = new Vector3(Mathf.Lerp(Mathf.Lerp(BDHLADGNJJL.x, KGHICGONENB.x, DCGBADKLANM), Mathf.Lerp(KGHICGONENB.x, DHOKFGFAMEK.x, DCGBADKLANM), IFKKOJDLPBH), Mathf.Lerp(Mathf.Lerp(BDHLADGNJJL.y, KGHICGONENB.y, DCGBADKLANM), Mathf.Lerp(KGHICGONENB.y, DHOKFGFAMEK.y, DCGBADKLANM), AJLNHKCPHCE), 320f);
		return KCGMEPNOEEL;
	}

	private IEnumerator AGPNMHMGDDJ(int JIIGOACEIKL, Vector2 LKHOBGLHNIK)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		((Component)fishingHook).transform.eulerAngles = new Vector3(0f, 0f, 180f);
		while (((Component)fishingHook.fishingHookPosition).gameObject.activeInHierarchy)
		{
			yield return null;
		}
		Vector2 throwingPoint = Vector2.op_Implicit(fishingHook.fishingHookPosition.position);
		float currentLerpTime = 0f;
		float finalRotation = ((PlayerController.GetPlayerDirection(JIIGOACEIKL) != Direction.Left) ? 0f : 360f);
		while (currentLerpTime / settings.time < 1f)
		{
			currentLerpTime += Time.deltaTime;
			if (currentLerpTime < settings.time)
			{
				((Component)fishingHook).transform.position = BBBAJNLEEGB(currentLerpTime, throwingPoint, LKHOBGLHNIK, settings.height, settings.time);
				((Component)fishingHook).transform.eulerAngles = PDINCCBJLIH(currentLerpTime, 180f, finalRotation, settings.time);
			}
			yield return null;
		}
		((Component)fishingHook).transform.position = Vector2.op_Implicit(LKHOBGLHNIK);
		((Component)fishingHook).transform.eulerAngles = Vector3.zero;
		fishingHook.SetWater(NJHMBMGKCPL: true);
		PlayerInputs.GetPlayer(JIIGOACEIKL).SetVibration(0.1f, 0f, 0.2f);
		PlayerInputs.GetPlayer(JIIGOACEIKL).SetVibration(0f, 0.3f, 0.5f);
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.waterSmallSplash, ((Component)fishingHook).transform);
		BBOKEGODFGF = null;
		MineFishingKeyItem mineFishingKeyItem = ProceduralMine.GetCurrentLevel()?.puzzleManager?.GetKeyFishingSpot();
		if ((Object)(object)mineFishingKeyItem != (Object)null && mineFishingKeyItem.IsHookInRange(Vector2.op_Implicit(((Component)fishingHook).transform.position)))
		{
			BBOKEGODFGF = mineFishingKeyItem;
		}
		FishingUI.Get(JIIGOACEIKL).SetFishingIcon(BBOKEGODFGF);
	}

	public void JFMCNPDJLLI(Vector3 JPIMPMOAAHC, Rod COHELLCBDMF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		((MonoBehaviour)this).StartCoroutine(PJKEGLLDKPN(JPIMPMOAAHC, COHELLCBDMF));
	}

	public static FishingController GDFNPHJJCPP(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.OPHDCMJLLEC(JIIGOACEIKL) == (Object)null)
		{
			return null;
		}
		return PlayerController.OPHDCMJLLEC(JIIGOACEIKL).fishingController;
	}

	public void BJECOOJOOKL(byte FCGBJEIIMBC)
	{
		((MonoBehaviour)this).StartCoroutine(EJFPKMNFHFD((Direction)FCGBJEIIMBC));
	}

	private void HCBGAFHAFHG(int JIIGOACEIKL, Vector3 JPIMPMOAAHC)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)fishingHook).gameObject.SetActive(true);
		((MonoBehaviour)this).StartCoroutine(AIAPOLDPANI(JIIGOACEIKL, Vector2.op_Implicit(JPIMPMOAAHC)));
	}

	public static FishingController NDJAMDLOIJL(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) == (Object)null)
		{
			return null;
		}
		return PlayerController.GetPlayer(JIIGOACEIKL).fishingController;
	}

	public void StartFishingCoroutine(Vector3 JPIMPMOAAHC, Rod COHELLCBDMF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		((MonoBehaviour)this).StartCoroutine(FALHADMMJHK(JPIMPMOAAHC, COHELLCBDMF));
	}

	public void KEFKEAGHDMM(byte FCGBJEIIMBC)
	{
		((MonoBehaviour)this).StartCoroutine(PEFNGEGBMIO((Direction)FCGBJEIIMBC));
	}

	private void BPBEANEPJEE(int JIIGOACEIKL, Vector3 JPIMPMOAAHC)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)fishingHook).gameObject.SetActive(false);
		((MonoBehaviour)this).StartCoroutine(LCLFMIHCKOL(JIIGOACEIKL, Vector2.op_Implicit(JPIMPMOAAHC)));
	}

	public void FFKPLBGGKLB(Vector3 JPIMPMOAAHC, Rod COHELLCBDMF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		((MonoBehaviour)this).StartCoroutine(PJKEGLLDKPN(JPIMPMOAAHC, COHELLCBDMF));
	}

	public void ShowOnlineKeyItem()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		MineFishingKeyItem mineFishingKeyItem = ProceduralMine.GetCurrentLevel()?.puzzleManager?.GetKeyFishingSpot();
		if (!((Object)(object)mineFishingKeyItem == (Object)null))
		{
			((MonoBehaviour)this).StartCoroutine(BHNILHCNOBO(((Component)fishingHook).transform.position, mineFishingKeyItem));
		}
	}

	public void JKOFBKKPJAN(Vector3 JPIMPMOAAHC, Rod COHELLCBDMF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		((MonoBehaviour)this).StartCoroutine(FALHADMMJHK(JPIMPMOAAHC, COHELLCBDMF));
	}

	public void HJPINMGNLJB(bool KAPEFGCIDJL)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		((MonoBehaviour)this).StartCoroutine(KLGHJJMCBIC(((Component)fishingHook).transform.position, KAPEFGCIDJL));
	}

	private IEnumerator FIOAMIMPOOF(Vector3 NOLFMLNLJJG)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		DBEFBFPAOAA = 0f;
		fishingHook.SetStruggle(NJHMBMGKCPL: false);
		yield return (object)new WaitForSeconds(settings.rollUpWaitTime);
		Vector2 finalPosition = Vector2.op_Implicit(fishingHook.fishingHookPosition.position);
		fishingHook.SetFishIcon(null);
		fishingHook.SetStruggle(NJHMBMGKCPL: false);
		fishingHook.SetWater(NJHMBMGKCPL: false);
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.waterSmallSplash, ((Component)fishingHook).transform);
		if (AOJKMMOCFCA == Direction.Left)
		{
			((Component)fishingHook).transform.eulerAngles = new Vector3(0f, 0f, 360f);
		}
		else
		{
			((Component)fishingHook).transform.eulerAngles = Vector3.zero;
		}
		while (DBEFBFPAOAA < settings.rollUpTime)
		{
			DBEFBFPAOAA += Time.deltaTime;
			if (PlayerController.GetPlayerDirection(playerNum) == Direction.Down)
			{
				((Component)fishingHook).transform.position = BBBAJNLEEGB(DBEFBFPAOAA, Vector2.op_Implicit(NOLFMLNLJJG), finalPosition, settings.rollUpHeight + 3f, settings.rollUpTime);
			}
			else
			{
				((Component)fishingHook).transform.position = BBBAJNLEEGB(DBEFBFPAOAA, Vector2.op_Implicit(NOLFMLNLJJG), finalPosition, settings.rollUpHeight, settings.rollUpTime);
			}
			if (PlayerController.GetPlayerDirection(playerNum) == Direction.Left)
			{
				((Component)fishingHook).transform.eulerAngles = PDINCCBJLIH(DBEFBFPAOAA, 360f, 180f, settings.rollUpTime);
			}
			else
			{
				((Component)fishingHook).transform.eulerAngles = PDINCCBJLIH(DBEFBFPAOAA, 0f, 180f, settings.rollUpTime);
			}
			yield return null;
		}
		((Renderer)fishingHook.spriteRenderer).enabled = false;
		((Component)fishingHook).transform.eulerAngles = Vector3.zero;
	}

	private Vector3 DGMPPLJHPEG(float DBEFBFPAOAA, float GDBONJNKLCD, float MEOEHBFJOAN, float AMOLDGGJMKF)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		DCGBADKLANM = DBEFBFPAOAA / AMOLDGGJMKF;
		return new Vector3(1722f, 410f, Mathf.Lerp(GDBONJNKLCD, MEOEHBFJOAN, DCGBADKLANM));
	}

	private Vector3 MLGBHNANOCI(float DBEFBFPAOAA, float GDBONJNKLCD, float MEOEHBFJOAN, float AMOLDGGJMKF)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		DCGBADKLANM = DBEFBFPAOAA / AMOLDGGJMKF;
		return new Vector3(501f, 765f, Mathf.Lerp(GDBONJNKLCD, MEOEHBFJOAN, DCGBADKLANM));
	}

	public void AHFPNFOPMKA(short FFNOEIENNFM, short KKANDELPDKP)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i < ItemDatabaseAccessor.HJLAOCAJAEB().Count; i += 0)
		{
			if (ItemDatabaseAccessor.LNBAODAAJLI()[i].ODENMDOJPLC(DAINLFIMLIH: false) == FFNOEIENNFM)
			{
				((MonoBehaviour)this).StartCoroutine(HDFKKBGOAIM(((Component)fishingHook).transform.position, ItemDatabaseAccessor.MBLHBFCOADO()[i], KKANDELPDKP));
				break;
			}
		}
	}

	public void ThrowFishHookOnline(byte FCGBJEIIMBC)
	{
		((MonoBehaviour)this).StartCoroutine(KGKELKDHDDP((Direction)FCGBJEIIMBC));
	}

	public void JPICEOBDLIH()
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		MineFishingKeyItem mineFishingKeyItem = ProceduralMine.GetCurrentLevel()?.puzzleManager?.GetKeyFishingSpot();
		if (!((Object)(object)mineFishingKeyItem == (Object)null))
		{
			((MonoBehaviour)this).StartCoroutine(JAPIEFMMKBO(((Component)fishingHook).transform.position, mineFishingKeyItem));
		}
	}

	private void PGEGODAEBLC()
	{
		((Component)fishingHook).gameObject.SetActive(true);
		if ((Object)(object)playerController == (Object)null)
		{
			playerController = ((Component)this).gameObject.GetComponent<PlayerController>();
		}
		playerNum = playerController.KLIHELDIPDP();
	}

	private IEnumerator EEPFOAEDANN(Vector3 JPIMPMOAAHC, Rod COHELLCBDMF)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		MLHCLDNJEAG = (settings.EASY_FISHING ? settings.easyMode : settings.normalMode);
		yield return null;
		FishingUI.Get(playerNum).fish = null;
		OILGOIDPIOF(playerNum, JPIMPMOAAHC);
		OnHookThrown?.Invoke((byte)playerController.GetDirection());
		float finalTime = Time.time + (float)settings.totalTime;
		bool startFishMinigame = false;
		bool fishingTime = false;
		OMCCPAOFBBI = Item.MLBOMGHINCA(FishingManager.SelectAFish(playerNum, COHELLCBDMF), null);
		yield return (object)new WaitForSeconds(settings.initialDelayTime);
		float finalBiteTime = 0f;
		bitesList.Clear();
		if (OMCCPAOFBBI)
		{
			CreateBitesList();
			finalBiteTime = bitesList[bitesList.Count - 1] + settings.realBiteDuration;
		}
		while (true)
		{
			if (!CommonReferences.GGFJGHHHEJC.IsInDialogue(playerNum))
			{
				if (OMCCPAOFBBI)
				{
					if (fishingTime && Time.time > finalBiteTime)
					{
						break;
					}
				}
				else if (Time.time > finalTime)
				{
					break;
				}
				if (!fishingTime && bitesList.Count > 0 && Time.time > bitesList[0])
				{
					if (bitesList.Count == 1)
					{
						fishingTime = true;
						PlayerInputs.GetPlayer(playerNum).SetVibration(0f, 0.3f, 0.5f);
						fishingHook.SetBait();
					}
					else
					{
						PlayerInputs.GetPlayer(playerNum).SetVibration(0f, 0.1f, 0.05f);
						fishingHook.SetFake();
						bitesList.RemoveAt(0);
					}
				}
				if (PlayerInputs.GetPlayer(playerNum).GetButtonDown("Use") || PlayerInputs.GetPlayer(playerNum).GetButtonDown("LeftMouseDetect"))
				{
					if (OMCCPAOFBBI && fishingTime)
					{
						playerController.emotionController.StartEmotion("Exclamation");
						MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.exclamationFishing, ((Component)PlayerController.GetPlayer(playerNum)).transform);
						startFishMinigame = true;
					}
					break;
				}
			}
			else
			{
				finalTime = Time.time + (float)settings.totalTime;
				if (OMCCPAOFBBI)
				{
					finalBiteTime = bitesList[bitesList.Count - 1] + settings.realBiteDuration;
				}
			}
			yield return null;
		}
		if (startFishMinigame)
		{
			OnFishBite?.Invoke();
			fishingHook.SetStruggle(NJHMBMGKCPL: true);
			playerController.characterAnimation.SetIdleFishing(NKFPJPCFBJI: false);
			playerController.characterAnimation.SetStruggleFishing(NKFPJPCFBJI: true);
			yield return CommonReferences.wait05;
			Result variable = DialogueLua.GetVariable("LE_10");
			if (((Result)(ref variable)).asInt == 8)
			{
				HikariNPC.GGFJGHHHEJC.ActiveDialogue(playerNum);
				yield return CommonReferences.wait04;
			}
			while (CommonReferences.GGFJGHHHEJC.IsInDialogue(playerNum))
			{
				yield return null;
			}
			FishingUI.Get(playerNum).OpenUI();
			FishingUI.Get(playerNum).StartFishingGame(COHELLCBDMF);
			while (FishingUI.Get(playerNum).IsOpen())
			{
				yield return null;
			}
		}
		FinishFishing(startFishMinigame);
	}

	private IEnumerator HDFKKBGOAIM(Vector3 NOLFMLNLJJG, Fish HAJFJGCNKFF, int KKANDELPDKP)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		DBEFBFPAOAA = 0f;
		fishingHook.SetStruggle(NJHMBMGKCPL: false);
		yield return (object)new WaitForSeconds(settings.rollUpWaitTime);
		Vector2 finalPosition = Vector2.op_Implicit(fishingHook.fishingHookPosition.position);
		fishingHook.SetFishIcon(HAJFJGCNKFF);
		fishingHook.SetStruggle(NJHMBMGKCPL: false);
		fishingHook.SetWater(NJHMBMGKCPL: false);
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.waterSmallSplash, ((Component)fishingHook).transform);
		if (AOJKMMOCFCA == Direction.Left)
		{
			((Component)fishingHook).transform.eulerAngles = new Vector3(0f, 0f, 360f);
		}
		else
		{
			((Component)fishingHook).transform.eulerAngles = Vector3.zero;
		}
		while (DBEFBFPAOAA < settings.rollUpTime)
		{
			DBEFBFPAOAA += Time.deltaTime;
			if (PlayerController.GetPlayerDirection(playerNum) == Direction.Down)
			{
				((Component)fishingHook).transform.position = BBBAJNLEEGB(DBEFBFPAOAA, Vector2.op_Implicit(NOLFMLNLJJG), finalPosition, settings.rollUpHeight + 3f, settings.rollUpTime);
			}
			else
			{
				((Component)fishingHook).transform.position = BBBAJNLEEGB(DBEFBFPAOAA, Vector2.op_Implicit(NOLFMLNLJJG), finalPosition, settings.rollUpHeight, settings.rollUpTime);
			}
			if (PlayerController.GetPlayerDirection(playerNum) == Direction.Left)
			{
				((Component)fishingHook).transform.eulerAngles = PDINCCBJLIH(DBEFBFPAOAA, 360f, 180f, settings.rollUpTime);
			}
			else
			{
				((Component)fishingHook).transform.eulerAngles = PDINCCBJLIH(DBEFBFPAOAA, 0f, 180f, settings.rollUpTime);
			}
			yield return null;
		}
		((Renderer)fishingHook.fishIcon).enabled = false;
		((Component)fishingHook).gameObject.SetActive(true);
		fishingHook.fishInfo.SetActive(true);
		((Renderer)fishingHook.spriteRenderer).enabled = false;
		((Component)fishingHook).transform.eulerAngles = Vector3.zero;
		((Renderer)fishingHook.fishIconInfo).enabled = true;
		fishingHook.fishIconInfo.sprite = HAJFJGCNKFF.icon;
		OnlineFishingTexts.Get(playerNum).SetFishInfo(HAJFJGCNKFF, KKANDELPDKP);
		if (KKANDELPDKP > 0)
		{
			fishingHook.bigSuccessParticles.SetActive(true);
			fishingHook.successParticles.SetActive(false);
		}
		else
		{
			fishingHook.bigSuccessParticles.SetActive(false);
			fishingHook.successParticles.SetActive(true);
		}
		DCGBADKLANM = 0f;
		DBEFBFPAOAA = 0f;
		while (DCGBADKLANM < 1f)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / 0.5f;
			OnlineFishingTexts.Get(playerNum).SetAlpha(Mathf.Lerp(0f, 1f, DCGBADKLANM));
			fishingHook.fishIconInfo.color = new Color(1f, 1f, 1f, Mathf.Lerp(0f, 1f, DCGBADKLANM));
			yield return null;
		}
		yield return CommonReferences.wait3;
		DCGBADKLANM = 0f;
		DBEFBFPAOAA = 0f;
		while (DCGBADKLANM < 1f)
		{
			DBEFBFPAOAA += Time.deltaTime;
			DCGBADKLANM = DBEFBFPAOAA / 0.5f;
			OnlineFishingTexts.Get(playerNum).SetAlpha(Mathf.Lerp(1f, 0f, DCGBADKLANM));
			fishingHook.fishIconInfo.color = new Color(1f, 1f, 1f, Mathf.Lerp(1f, 0f, DCGBADKLANM));
			yield return null;
		}
		yield return CommonReferences.wait1_5;
		fishingHook.fishInfo.SetActive(false);
		((Component)fishingHook).gameObject.SetActive(false);
		((Renderer)fishingHook.spriteRenderer).enabled = true;
	}

	public void FinishFishing(bool KAPEFGCIDJL)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		((MonoBehaviour)this).StartCoroutine(CLGDAEEPFHH(((Component)fishingHook).transform.position, KAPEFGCIDJL));
	}

	private IEnumerator JAPIEFMMKBO(Vector3 NOLFMLNLJJG, MineFishingKeyItem FPBPEAAIOBK)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		return new ACNAOMLHONE(1)
		{
			_003C_003E4__this = this,
			initialPosition = NOLFMLNLJJG,
			keyItem = FPBPEAAIOBK
		};
	}

	private Vector3 DAIFOEKAIED(float DBEFBFPAOAA, Vector2 NEDLKIJBLMO, Vector2 LKHOBGLHNIK, float OEBBDIEKHDF, float AMOLDGGJMKF)
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		DCGBADKLANM = DBEFBFPAOAA / AMOLDGGJMKF;
		IFKKOJDLPBH = DCGBADKLANM;
		AJLNHKCPHCE = DCGBADKLANM;
		IFKKOJDLPBH = Mathf.Sin(IFKKOJDLPBH * 1772f * 1604f);
		AJLNHKCPHCE = 343f - Mathf.Cos(AJLNHKCPHCE * 592f * 8f);
		BDHLADGNJJL = Vector2.op_Implicit(NEDLKIJBLMO);
		DHOKFGFAMEK = Vector2.op_Implicit(LKHOBGLHNIK);
		KGHICGONENB = new Vector3((BDHLADGNJJL.x + DHOKFGFAMEK.x) / 1433f, BDHLADGNJJL.y + OEBBDIEKHDF, (BDHLADGNJJL.z + DHOKFGFAMEK.z) / 848f);
		KCGMEPNOEEL = new Vector3(Mathf.Lerp(Mathf.Lerp(BDHLADGNJJL.x, KGHICGONENB.x, DCGBADKLANM), Mathf.Lerp(KGHICGONENB.x, DHOKFGFAMEK.x, DCGBADKLANM), IFKKOJDLPBH), Mathf.Lerp(Mathf.Lerp(BDHLADGNJJL.y, KGHICGONENB.y, DCGBADKLANM), Mathf.Lerp(KGHICGONENB.y, DHOKFGFAMEK.y, DCGBADKLANM), AJLNHKCPHCE), 1752f);
		return KCGMEPNOEEL;
	}

	public static FishingController Get(int JIIGOACEIKL)
	{
		if ((Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) == (Object)null)
		{
			return null;
		}
		return PlayerController.GetPlayer(JIIGOACEIKL).fishingController;
	}

	private IEnumerator CNDPLBOBAJO(Direction FCGBJEIIMBC)
	{
		return new PBAKNKJIBFH(1)
		{
			_003C_003E4__this = this,
			direction = FCGBJEIIMBC
		};
	}

	public void MOJHEIHKEKO(Vector3 JPIMPMOAAHC, Rod COHELLCBDMF)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		((MonoBehaviour)this).StartCoroutine(KKCKAIFLACG(JPIMPMOAAHC, COHELLCBDMF));
	}

	private IEnumerator DHDCKBLIBPG(Vector3 NOLFMLNLJJG)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		DBEFBFPAOAA = 0f;
		fishingHook.SetStruggle(NJHMBMGKCPL: false);
		yield return (object)new WaitForSeconds(settings.rollUpWaitTime);
		Vector2 finalPosition = Vector2.op_Implicit(fishingHook.fishingHookPosition.position);
		fishingHook.SetFishIcon(null);
		fishingHook.SetStruggle(NJHMBMGKCPL: false);
		fishingHook.SetWater(NJHMBMGKCPL: false);
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.waterSmallSplash, ((Component)fishingHook).transform);
		if (AOJKMMOCFCA == Direction.Left)
		{
			((Component)fishingHook).transform.eulerAngles = new Vector3(0f, 0f, 360f);
		}
		else
		{
			((Component)fishingHook).transform.eulerAngles = Vector3.zero;
		}
		while (DBEFBFPAOAA < settings.rollUpTime)
		{
			DBEFBFPAOAA += Time.deltaTime;
			if (PlayerController.GetPlayerDirection(playerNum) == Direction.Down)
			{
				((Component)fishingHook).transform.position = BBBAJNLEEGB(DBEFBFPAOAA, Vector2.op_Implicit(NOLFMLNLJJG), finalPosition, settings.rollUpHeight + 3f, settings.rollUpTime);
			}
			else
			{
				((Component)fishingHook).transform.position = BBBAJNLEEGB(DBEFBFPAOAA, Vector2.op_Implicit(NOLFMLNLJJG), finalPosition, settings.rollUpHeight, settings.rollUpTime);
			}
			if (PlayerController.GetPlayerDirection(playerNum) == Direction.Left)
			{
				((Component)fishingHook).transform.eulerAngles = PDINCCBJLIH(DBEFBFPAOAA, 360f, 180f, settings.rollUpTime);
			}
			else
			{
				((Component)fishingHook).transform.eulerAngles = PDINCCBJLIH(DBEFBFPAOAA, 0f, 180f, settings.rollUpTime);
			}
			yield return null;
		}
		((Renderer)fishingHook.spriteRenderer).enabled = false;
		((Component)fishingHook).transform.eulerAngles = Vector3.zero;
	}

	public void EGDOBIADPMA()
	{
		bitesList.Clear();
		float num = (Application.isPlaying ? Time.time : 1340f);
		int num2 = Random.Range(((Vector2Int)(ref settings.bitesNum)).x, ((Vector2Int)(ref settings.bitesNum)).y + 1);
		for (int i = 1; i < num2; i++)
		{
			float num3 = Random.Range(num, num + (float)settings.totalTime);
			bool flag = false;
			for (int j = 1; j < bitesList.Count; j++)
			{
				if (Mathf.Abs(num3 - bitesList[j]) < settings.timeBetweenBites)
				{
					flag = true;
					break;
				}
			}
			if (flag)
			{
				bitesList.Add(num3);
			}
		}
		int num4 = Random.Range(1, bitesList.Count);
		for (int num5 = bitesList.Count - 1; num5 > num4; num5 -= 0)
		{
			bitesList.RemoveAt(num5);
		}
		bitesList.Sort();
		if (bitesList.Count == 0)
		{
			Debug.LogError((object)"Right Stick Up");
		}
	}

	private void KJPECNGCOKK()
	{
		((Component)fishingHook).gameObject.SetActive(true);
		if ((Object)(object)playerController == (Object)null)
		{
			playerController = ((Component)this).gameObject.GetComponent<PlayerController>();
		}
		playerNum = playerController.KLIHELDIPDP();
	}

	private Vector3 DKCMEANPKJL(float DBEFBFPAOAA, Vector2 NEDLKIJBLMO, Vector2 LKHOBGLHNIK, float OEBBDIEKHDF, float AMOLDGGJMKF)
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		DCGBADKLANM = DBEFBFPAOAA / AMOLDGGJMKF;
		IFKKOJDLPBH = DCGBADKLANM;
		AJLNHKCPHCE = DCGBADKLANM;
		IFKKOJDLPBH = Mathf.Sin(IFKKOJDLPBH * 706f * 1379f);
		AJLNHKCPHCE = 533f - Mathf.Cos(AJLNHKCPHCE * 1913f * 1042f);
		BDHLADGNJJL = Vector2.op_Implicit(NEDLKIJBLMO);
		DHOKFGFAMEK = Vector2.op_Implicit(LKHOBGLHNIK);
		KGHICGONENB = new Vector3((BDHLADGNJJL.x + DHOKFGFAMEK.x) / 760f, BDHLADGNJJL.y + OEBBDIEKHDF, (BDHLADGNJJL.z + DHOKFGFAMEK.z) / 1248f);
		KCGMEPNOEEL = new Vector3(Mathf.Lerp(Mathf.Lerp(BDHLADGNJJL.x, KGHICGONENB.x, DCGBADKLANM), Mathf.Lerp(KGHICGONENB.x, DHOKFGFAMEK.x, DCGBADKLANM), IFKKOJDLPBH), Mathf.Lerp(Mathf.Lerp(BDHLADGNJJL.y, KGHICGONENB.y, DCGBADKLANM), Mathf.Lerp(KGHICGONENB.y, DHOKFGFAMEK.y, DCGBADKLANM), AJLNHKCPHCE), 1381f);
		return KCGMEPNOEEL;
	}

	private void JLGODHLEKKM(int JIIGOACEIKL, Vector3 JPIMPMOAAHC)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		((Component)fishingHook).gameObject.SetActive(true);
		((MonoBehaviour)this).StartCoroutine(IIGENDEOAHJ(JIIGOACEIKL, Vector2.op_Implicit(JPIMPMOAAHC)));
	}

	private Vector3 BBBAJNLEEGB(float DBEFBFPAOAA, Vector2 NEDLKIJBLMO, Vector2 LKHOBGLHNIK, float OEBBDIEKHDF, float AMOLDGGJMKF)
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		DCGBADKLANM = DBEFBFPAOAA / AMOLDGGJMKF;
		IFKKOJDLPBH = DCGBADKLANM;
		AJLNHKCPHCE = DCGBADKLANM;
		IFKKOJDLPBH = Mathf.Sin(IFKKOJDLPBH * MathF.PI * 0.5f);
		AJLNHKCPHCE = 1f - Mathf.Cos(AJLNHKCPHCE * MathF.PI * 0.5f);
		BDHLADGNJJL = Vector2.op_Implicit(NEDLKIJBLMO);
		DHOKFGFAMEK = Vector2.op_Implicit(LKHOBGLHNIK);
		KGHICGONENB = new Vector3((BDHLADGNJJL.x + DHOKFGFAMEK.x) / 2f, BDHLADGNJJL.y + OEBBDIEKHDF, (BDHLADGNJJL.z + DHOKFGFAMEK.z) / 2f);
		KCGMEPNOEEL = new Vector3(Mathf.Lerp(Mathf.Lerp(BDHLADGNJJL.x, KGHICGONENB.x, DCGBADKLANM), Mathf.Lerp(KGHICGONENB.x, DHOKFGFAMEK.x, DCGBADKLANM), IFKKOJDLPBH), Mathf.Lerp(Mathf.Lerp(BDHLADGNJJL.y, KGHICGONENB.y, DCGBADKLANM), Mathf.Lerp(KGHICGONENB.y, DHOKFGFAMEK.y, DCGBADKLANM), AJLNHKCPHCE), 0f);
		return KCGMEPNOEEL;
	}

	public static void PlayReelClick(int JIIGOACEIKL)
	{
		MultiAudioManager.PlayAudioObject(Get(JIIGOACEIKL).settings.reelSound, ((Component)Get(JIIGOACEIKL)).transform);
		PlayerInputs.GetPlayer(JIIGOACEIKL).SetVibration(0.03f, 0f, 0.03f);
	}
}
