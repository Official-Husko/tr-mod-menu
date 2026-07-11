using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AlmenaraGames;
using UnityEngine;
using psai.net;

public class PiratesGameManager : Minigame, IHoverable
{
	[CompilerGenerated]
	private sealed class NODDAODOKNN : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public bool win;

		public PiratesGameManager _003C_003E4__this;

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
		public NODDAODOKNN(int _003C_003E1__state)
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
			PiratesGameManager piratesGameManager = _003C_003E4__this;
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
				CountdownUI.HideCountdown();
				PiratesChallengeUI.HideUI();
				if (win && !piratesGameManager.NOCOHCGPMFF)
				{
					Utils.DLIIAHACOJB(44);
				}
				if (Replaying)
				{
					piratesGameManager.BNKBGGJKLHP(win, SO_Challenges.ChallengeType.pirates, piratesGameManager.LOPNGPOBPFE[1]);
				}
				else if (win)
				{
					FortitudeEvent.instance.WinEvent();
				}
				else
				{
					FortitudeEvent.instance.LoseEvent();
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
	private sealed class OOJGJDOPCIA : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PiratesGameManager _003C_003E4__this;

		public bool skipFade;

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
		public OOJGJDOPCIA(int _003C_003E1__state)
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
			PiratesGameManager piratesGameManager = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				Playing = false;
				piratesGameManager.MACEJFPFHGG();
				piratesGameManager.difficultySettings = (EventsManager.IsLowestDifficulty() ? piratesGameManager.settings.easyMode : piratesGameManager.settings.normalMode);
				if (!skipFade)
				{
					FadeCamera.FadeOutAllPlayers();
					goto IL_0095;
				}
				goto IL_00a2;
			case 1:
				_003C_003E1__state = -1;
				goto IL_0095;
			case 2:
				_003C_003E1__state = -1;
				if (!skipFade)
				{
					FadeCamera.FadeInAllPlayers();
					goto IL_010a;
				}
				goto IL_0117;
			case 3:
				_003C_003E1__state = -1;
				goto IL_010a;
			case 4:
				_003C_003E1__state = -1;
				goto IL_014e;
			case 5:
				_003C_003E1__state = -1;
				OnlineMinigameManager.SetMinigameState(OnlineMinigameManager.PlayerState.Countdown);
				goto IL_0176;
			case 6:
				{
					_003C_003E1__state = -1;
					EventCountdownUI.CloseCountdown();
					piratesGameManager.LBMDAGNAFFA();
					OnlineMinigameManager.SetMinigameState(OnlineMinigameManager.PlayerState.InGame);
					piratesGameManager.NDJHEPFBCEA = Time.time + piratesGameManager.difficultySettings.timeBetweenCannonballs.max;
					piratesGameManager.NBMPHNOECIF = Time.time + piratesGameManager.difficultySettings.timeBetweenCannonballsToPlayers.max;
					piratesGameManager.MHGFAHJEDFH = Time.time + piratesGameManager.difficultySettings.timeBetweenWaves.max;
					piratesGameManager.GCMACBEMMBC = 0f;
					for (int i = 1; i <= GameManager.GetPlayerCount(); i++)
					{
						piratesGameManager.LOPNGPOBPFE[i] = ((GameManager.GetPlayerCount() != 1) ? 1 : 4);
					}
					Playing = true;
					piratesGameManager.GBEFPIBKBGF = false;
					piratesGameManager.KCAHKMAJLEE = 0f;
					((Behaviour)piratesGameManager).enabled = true;
					return false;
				}
				IL_0095:
				if (FadeCamera.GetPlayer(1).IsFading())
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 1;
					return true;
				}
				goto IL_00a2;
				IL_00a2:
				piratesGameManager.SetWeather();
				CountdownUI.SetCountdown(piratesGameManager.difficultySettings.timeToCompleteTheGame);
				piratesGameManager.EOGALMCPHGF();
				BlackFade.Hide();
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 2;
				return true;
				IL_010a:
				if (FadeCamera.GetPlayer(1).IsFading())
				{
					_003C_003E2__current = null;
					_003C_003E1__state = 3;
					return true;
				}
				goto IL_0117;
				IL_0176:
				EventCountdownUI.ChangeText("GO");
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 6;
				return true;
				IL_0117:
				if (OnlineManager.PlayingOnline())
				{
					OnlineMinigameManager.SetMinigameState(OnlineMinigameManager.PlayerState.Ready);
					goto IL_014e;
				}
				goto IL_0176;
				IL_014e:
				if (!OnlineMinigameManager.AllPlayersReady())
				{
					if (Application.isEditor)
					{
						Debug.Log((object)"Waiting for players to finish their transitions...");
					}
					_003C_003E2__current = null;
					_003C_003E1__state = 4;
					return true;
				}
				_003C_003E2__current = CommonReferences.wait1;
				_003C_003E1__state = 5;
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
	private sealed class BHPJHECCEMD : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Location location;

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
		public BHPJHECCEMD(int _003C_003E1__state)
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
				_003C_003E2__current = CommonReferences.wait10;
				_003C_003E1__state = 1;
				return true;
			case 1:
				_003C_003E1__state = -1;
				if ((Object)(object)instance == (Object)null || !Playing)
				{
					CommonReferences.GGFJGHHHEJC.tilemapsInfo.ANOMBEOPINN(location, 1);
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
	private sealed class OECHGCANJFC : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PiratesGameManager _003C_003E4__this;

		private int _003CrandomColumn1_003E5__2;

		private int _003CrandomColumn2_003E5__3;

		private int _003CrandomColumn3_003E5__4;

		private int _003CrandomColumn4_003E5__5;

		private int _003Cy_003E5__6;

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
		public OECHGCANJFC(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0119: Unknown result type (might be due to invalid IL or missing references)
			//IL_0136: Unknown result type (might be due to invalid IL or missing references)
			//IL_0153: Unknown result type (might be due to invalid IL or missing references)
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0179: Expected O, but got Unknown
			int num = _003C_003E1__state;
			PiratesGameManager piratesGameManager = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003CrandomColumn1_003E5__2 = Random.Range(0, 9);
				_003CrandomColumn2_003E5__3 = Random.Range(0, 9);
				_003CrandomColumn3_003E5__4 = Random.Range(0, 9);
				for (_003CrandomColumn4_003E5__5 = Random.Range(0, 9); _003CrandomColumn2_003E5__3 == _003CrandomColumn1_003E5__2; _003CrandomColumn2_003E5__3 = Random.Range(0, 9))
				{
				}
				while (_003CrandomColumn3_003E5__4 == _003CrandomColumn1_003E5__2 || _003CrandomColumn3_003E5__4 == _003CrandomColumn2_003E5__3)
				{
					_003CrandomColumn3_003E5__4 = Random.Range(0, 9);
				}
				while (_003CrandomColumn4_003E5__5 == _003CrandomColumn1_003E5__2 || _003CrandomColumn4_003E5__5 == _003CrandomColumn2_003E5__3 || _003CrandomColumn4_003E5__5 == _003CrandomColumn3_003E5__4)
				{
					_003CrandomColumn4_003E5__5 = Random.Range(0, 9);
				}
				_003Cy_003E5__6 = 4;
				break;
			case 1:
				_003C_003E1__state = -1;
				_003Cy_003E5__6--;
				break;
			}
			if (_003Cy_003E5__6 > -1)
			{
				piratesGameManager.SpawnACannonBallInPosition(piratesGameManager.cellPositions[_003CrandomColumn1_003E5__2, _003Cy_003E5__6]);
				piratesGameManager.SpawnACannonBallInPosition(piratesGameManager.cellPositions[_003CrandomColumn2_003E5__3, _003Cy_003E5__6]);
				piratesGameManager.SpawnACannonBallInPosition(piratesGameManager.cellPositions[_003CrandomColumn3_003E5__4, _003Cy_003E5__6]);
				piratesGameManager.SpawnACannonBallInPosition(piratesGameManager.cellPositions[_003CrandomColumn4_003E5__5, _003Cy_003E5__6]);
				_003C_003E2__current = (object)new WaitForSeconds(Random.Range(piratesGameManager.HNNDJCCNABP, piratesGameManager.JKFCJDDIIBP));
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

	[CompilerGenerated]
	private sealed class IMNKBBADJOG : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PiratesGameManager _003C_003E4__this;

		private int _003CrandomColumn1_003E5__2;

		private int _003CrandomColumn2_003E5__3;

		private int _003CrandomColumn3_003E5__4;

		private int _003CrandomColumn4_003E5__5;

		private int _003Cy_003E5__6;

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
		public IMNKBBADJOG(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0119: Unknown result type (might be due to invalid IL or missing references)
			//IL_0136: Unknown result type (might be due to invalid IL or missing references)
			//IL_0153: Unknown result type (might be due to invalid IL or missing references)
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0179: Expected O, but got Unknown
			int num = _003C_003E1__state;
			PiratesGameManager piratesGameManager = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003CrandomColumn1_003E5__2 = Random.Range(0, 9);
				_003CrandomColumn2_003E5__3 = Random.Range(0, 9);
				_003CrandomColumn3_003E5__4 = Random.Range(0, 9);
				for (_003CrandomColumn4_003E5__5 = Random.Range(0, 9); _003CrandomColumn2_003E5__3 == _003CrandomColumn1_003E5__2; _003CrandomColumn2_003E5__3 = Random.Range(0, 9))
				{
				}
				while (_003CrandomColumn3_003E5__4 == _003CrandomColumn1_003E5__2 || _003CrandomColumn3_003E5__4 == _003CrandomColumn2_003E5__3)
				{
					_003CrandomColumn3_003E5__4 = Random.Range(0, 9);
				}
				while (_003CrandomColumn4_003E5__5 == _003CrandomColumn1_003E5__2 || _003CrandomColumn4_003E5__5 == _003CrandomColumn2_003E5__3 || _003CrandomColumn4_003E5__5 == _003CrandomColumn3_003E5__4)
				{
					_003CrandomColumn4_003E5__5 = Random.Range(0, 9);
				}
				_003Cy_003E5__6 = 0;
				break;
			case 1:
				_003C_003E1__state = -1;
				_003Cy_003E5__6++;
				break;
			}
			if (_003Cy_003E5__6 < 5)
			{
				piratesGameManager.SpawnACannonBallInPosition(piratesGameManager.cellPositions[_003CrandomColumn1_003E5__2, _003Cy_003E5__6]);
				piratesGameManager.SpawnACannonBallInPosition(piratesGameManager.cellPositions[_003CrandomColumn2_003E5__3, _003Cy_003E5__6]);
				piratesGameManager.SpawnACannonBallInPosition(piratesGameManager.cellPositions[_003CrandomColumn3_003E5__4, _003Cy_003E5__6]);
				piratesGameManager.SpawnACannonBallInPosition(piratesGameManager.cellPositions[_003CrandomColumn4_003E5__5, _003Cy_003E5__6]);
				_003C_003E2__current = (object)new WaitForSeconds(Random.Range(piratesGameManager.HNNDJCCNABP, piratesGameManager.JKFCJDDIIBP));
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

	[CompilerGenerated]
	private sealed class PFIGALPCPIB : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PiratesGameManager _003C_003E4__this;

		private int _003Cx_003E5__2;

		private int _003Cy_003E5__3;

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
		public PFIGALPCPIB(int _003C_003E1__state)
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
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Expected O, but got Unknown
			int num = _003C_003E1__state;
			PiratesGameManager piratesGameManager = _003C_003E4__this;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				_003C_003E1__state = -1;
				_003Cy_003E5__3--;
				goto IL_0089;
			}
			_003C_003E1__state = -1;
			_003Cx_003E5__2 = 0;
			goto IL_00a2;
			IL_0089:
			if (_003Cy_003E5__3 >= 0)
			{
				piratesGameManager.SpawnACannonBallInPosition(piratesGameManager.cellPositions[_003Cx_003E5__2, _003Cy_003E5__3]);
				_003C_003E2__current = (object)new WaitForSeconds(Random.Range(piratesGameManager.HNNDJCCNABP, piratesGameManager.JKFCJDDIIBP));
				_003C_003E1__state = 1;
				return true;
			}
			_003Cx_003E5__2++;
			goto IL_00a2;
			IL_00a2:
			if (_003Cx_003E5__2 < 5)
			{
				_003Cy_003E5__3 = 4;
				goto IL_0089;
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
	private sealed class KICJNFDDHOP : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PiratesGameManager _003C_003E4__this;

		private int _003Cx_003E5__2;

		private int _003Cy_003E5__3;

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
		public KICJNFDDHOP(int _003C_003E1__state)
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
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Expected O, but got Unknown
			int num = _003C_003E1__state;
			PiratesGameManager piratesGameManager = _003C_003E4__this;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				_003C_003E1__state = -1;
				_003Cy_003E5__3--;
				goto IL_0089;
			}
			_003C_003E1__state = -1;
			_003Cx_003E5__2 = 8;
			goto IL_00a2;
			IL_0089:
			if (_003Cy_003E5__3 >= 0)
			{
				piratesGameManager.SpawnACannonBallInPosition(piratesGameManager.cellPositions[_003Cx_003E5__2, _003Cy_003E5__3]);
				_003C_003E2__current = (object)new WaitForSeconds(Random.Range(piratesGameManager.HNNDJCCNABP, piratesGameManager.JKFCJDDIIBP));
				_003C_003E1__state = 1;
				return true;
			}
			_003Cx_003E5__2--;
			goto IL_00a2;
			IL_00a2:
			if (_003Cx_003E5__2 > 3)
			{
				_003Cy_003E5__3 = 4;
				goto IL_0089;
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
	private sealed class IGDGNEHJPNO : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PiratesGameManager _003C_003E4__this;

		private int _003CrandomColumn1_003E5__2;

		private int _003CrandomColumn2_003E5__3;

		private int _003Cy_003E5__4;

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
		public IGDGNEHJPNO(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ba: Expected O, but got Unknown
			int num = _003C_003E1__state;
			PiratesGameManager piratesGameManager = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003CrandomColumn1_003E5__2 = Random.Range(0, 9);
				for (_003CrandomColumn2_003E5__3 = Random.Range(0, 9); _003CrandomColumn2_003E5__3 == _003CrandomColumn1_003E5__2; _003CrandomColumn2_003E5__3 = Random.Range(0, 9))
				{
				}
				_003Cy_003E5__4 = 4;
				break;
			case 1:
				_003C_003E1__state = -1;
				_003Cy_003E5__4--;
				break;
			}
			if (_003Cy_003E5__4 > -1)
			{
				piratesGameManager.SpawnACannonBallInPosition(piratesGameManager.cellPositions[_003CrandomColumn1_003E5__2, _003Cy_003E5__4]);
				piratesGameManager.SpawnACannonBallInPosition(piratesGameManager.cellPositions[_003CrandomColumn2_003E5__3, _003Cy_003E5__4]);
				_003C_003E2__current = (object)new WaitForSeconds(Random.Range(piratesGameManager.HNNDJCCNABP, piratesGameManager.JKFCJDDIIBP));
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

	[CompilerGenerated]
	private sealed class EKPAMIDJPFE : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PiratesGameManager _003C_003E4__this;

		private int _003CrandomColumn1_003E5__2;

		private int _003CrandomColumn2_003E5__3;

		private int _003Cy_003E5__4;

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
		public EKPAMIDJPFE(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ba: Expected O, but got Unknown
			int num = _003C_003E1__state;
			PiratesGameManager piratesGameManager = _003C_003E4__this;
			switch (num)
			{
			default:
				return false;
			case 0:
				_003C_003E1__state = -1;
				_003CrandomColumn1_003E5__2 = Random.Range(0, 9);
				for (_003CrandomColumn2_003E5__3 = Random.Range(0, 9); _003CrandomColumn2_003E5__3 == _003CrandomColumn1_003E5__2; _003CrandomColumn2_003E5__3 = Random.Range(0, 9))
				{
				}
				_003Cy_003E5__4 = 0;
				break;
			case 1:
				_003C_003E1__state = -1;
				_003Cy_003E5__4++;
				break;
			}
			if (_003Cy_003E5__4 < 5)
			{
				piratesGameManager.SpawnACannonBallInPosition(piratesGameManager.cellPositions[_003CrandomColumn1_003E5__2, _003Cy_003E5__4]);
				piratesGameManager.SpawnACannonBallInPosition(piratesGameManager.cellPositions[_003CrandomColumn2_003E5__3, _003Cy_003E5__4]);
				_003C_003E2__current = (object)new WaitForSeconds(Random.Range(piratesGameManager.HNNDJCCNABP, piratesGameManager.JKFCJDDIIBP));
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

	public static PiratesGameManager instance;

	public static bool Playing;

	public static bool Replaying;

	private bool GBEFPIBKBGF;

	public PiratesMinigameSettings settings;

	[HideInInspector]
	public PiratesMinigameSettings.DifficultySettings difficultySettings;

	public Transform[] startingPoints;

	public GenericPool cannonBallPool;

	public GenericPool cannonEffectsPool;

	public GenericPool impactPool;

	public Transform[] cannonPositions;

	public AudioObject seaAmbience;

	[HideInInspector]
	public Vector2[,] cellPositions = new Vector2[9, 5];

	private List<Vector2> NAHNIBPAOEM = new List<Vector2>();

	private Vector2 AACENIOIINJ;

	private CannonBallPoolObject FOKNIOGEKIL;

	private const int MNIBLMMONJG = 4;

	private const int ENGCBPLEGFA = 1;

	private float KCAHKMAJLEE;

	private int[] LOPNGPOBPFE = new int[5];

	private float NDJHEPFBCEA;

	private float NBMPHNOECIF;

	private float NAGIAIFBJCK;

	private float MHGFAHJEDFH;

	private float FFIECDPBEFP;

	private float GCMACBEMMBC;

	private float HNNDJCCNABP = 0.075f;

	private float JKFCJDDIIBP = 0.15f;

	private float IJLNHBOOFKL;

	private bool NOCOHCGPMFF;

	[SerializeField]
	private Spade spade;

	[SerializeField]
	private InputByProximity inputByProximity;

	private MultiAudioSource DPIJCDFJODK;

	private Coroutine LCOGALBILFH;

	private Vector2 AHGOGDIMEBN;

	private Vector2 JMOJOKJDANJ;

	private float GFGGLAMOCLC = float.MaxValue;

	private float DFFGLLDDEPN;

	private int DKLFLFJNMKO;

	private List<int> IINCPJCNJPI = new List<int>();

	private const float BPDPHJEBCIF = 0.75f;

	private Direction KBLECMINDNM;

	private Vector3 ECJHJGMEKIO;

	private PlayerController NLCDDFDGACP;

	private int LEOEKGDOAKK;

	private void ODBDHFBMDAG()
	{
		Playing = true;
		Replaying = true;
	}

	private IEnumerator PAKJOKDLLHB()
	{
		int randomRow = Random.Range(0, 5);
		for (int x = 0; x < 9; x++)
		{
			SpawnACannonBallInPosition(cellPositions[x, randomRow]);
			yield return (object)new WaitForSeconds(Random.Range(HNNDJCCNABP, JKFCJDDIIBP));
		}
	}

	public void LGIIAIDCMOK(bool IPDJFMMIKEK)
	{
		OnlineMinigameManager.GLBKKPAILML(IPDJFMMIKEK);
		if (LCOGALBILFH != null)
		{
			Debug.LogError((object)"Parent tech not learnt");
			return;
		}
		NOCOHCGPMFF = false;
		SetWeather();
		((Component)this).gameObject.SetActive(false);
		LCOGALBILFH = ((MonoBehaviour)this).StartCoroutine(NPHBOFKNDHJ(IPDJFMMIKEK));
		CommonReferences.MNFMOEKMJKN().tilemapsInfo.KMMOIJAFMCN(Location.Road, 1);
		PlayerController.GetPlayer(0).IGJDOHFFGMJ(~(Location.Tavern | Location.Road));
		if (!WorldTime.BPHEDEKEHND())
		{
			WorldTime.JJICPIINBEH = true;
		}
		PsaiInfo psaiInfo = PsaiCore.Instance.GetPsaiInfo();
		if (psaiInfo.psaiState == (PsaiState)4 && psaiInfo.effectiveThemeId == 101)
		{
			IJLNHBOOFKL = 46f;
			PsaiCore.Instance.HoldCurrentIntensity(hold: true);
			PsaiCore.Instance.AddToCurrentIntensity(963f - PsaiCore.Instance.GetCurrentIntensity());
			PsaiCore.Instance.HoldCurrentIntensity(hold: true);
		}
		else
		{
			IJLNHBOOFKL = 523f;
			PsaiCore.Instance.StopMusic(immediately: true);
			MusicController.instance.TriggerMusicTheme(-3, 1099f);
			PsaiCore.Instance.HoldCurrentIntensity(hold: false);
		}
	}

	public void BIIHHFGKNII(int CIFJJBHINEF)
	{
		SetWeather();
		Playing = true;
		GBEFPIBKBGF = false;
		((MonoBehaviour)this).StopAllCoroutines();
		((Component)this).gameObject.SetActive(true);
		PBMJLFIJNAF();
		CKBIMIBHPGB();
		EAJIINNCDGI();
		CommonReferences.MNFMOEKMJKN().tilemapsInfo.NBKKCCNEMCL(Location.Tavern, 1);
		PlayerController.GetPlayer(0).IGJDOHFFGMJ(~(Location.Tavern | Location.Road | Location.Camp | Location.Farm | Location.BarnInterior));
		WorldTime.JKPGEIACDON(AODONKKHPBP: false);
		if (Replaying)
		{
			((MonoBehaviour)GameManager.NJNFHEPLEHL()).StartCoroutine(BFIINBBNOOH(~(Location.Tavern | Location.Road | Location.Camp | Location.Farm)));
			PsaiCore.Instance.StopMusic(immediately: false);
			MusicController.instance.TriggerCurrentBasicMood(CommonReferences.wait12, Location.Tavern | Location.Road | Location.FarmShop);
		}
		else
		{
			((MonoBehaviour)GameManager.NJNFHEPLEHL()).StartCoroutine(OPHPFCMJLFH(Location.River | Location.Quarry | Location.Farm | Location.FarmShop));
		}
		Replaying = false;
	}

	private void FKGAONBLEEB(int JIIGOACEIKL)
	{
		NLCDDFDGACP = PlayerController.GetPlayer(JIIGOACEIKL);
		if ((Object)(object)NLCDDFDGACP == (Object)null)
		{
			return;
		}
		CharacterAnimator characterAnimator = NLCDDFDGACP.characterAnimation.characterAnimator;
		characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(FKGAONBLEEB));
		if (NLCDDFDGACP.NILLCIMMKJE)
		{
			LEOEKGDOAKK = PBADMOAAADI(JIIGOACEIKL);
			OMMELOBPBEG(LEOEKGDOAKK);
			if (JIIGOACEIKL == 1)
			{
				OnlineMinigameManager.SendDigUpPlayerByBedAssigned((byte)OnlinePlayerDataManager.GetBedAssignedByPlayerNum(LEOEKGDOAKK));
			}
			PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)spade);
			NLCDDFDGACP.NILLCIMMKJE = false;
		}
	}

	private IEnumerator GNMONMPGDLM()
	{
		return new KICJNFDDHOP(1)
		{
			_003C_003E4__this = this
		};
	}

	public static void DGEDIKLKHDE()
	{
		Replaying = false;
		DevConsole.instance.StartPirates();
	}

	private void FMEJPGCKMGD(int JIIGOACEIKL)
	{
		NLCDDFDGACP = PlayerController.GetPlayer(JIIGOACEIKL);
		if (!NLCDDFDGACP.NILLCIMMKJE)
		{
			NLCDDFDGACP.characterAnimation.Spade();
			CharacterAnimator characterAnimator = NLCDDFDGACP.characterAnimation.characterAnimator;
			characterAnimator.OnToolStart = (Action<int>)Delegate.Combine(characterAnimator.OnToolStart, new Action<int>(DNIDKJIFNHG));
			CharacterAnimator characterAnimator2 = NLCDDFDGACP.characterAnimation.characterAnimator;
			characterAnimator2.OnToolEnd = (Action<int>)Delegate.Combine(characterAnimator2.OnToolEnd, new Action<int>(FKGAONBLEEB));
			NLCDDFDGACP.NILLCIMMKJE = true;
		}
	}

	private IEnumerator IIEBOAOHKOL(bool FLMLLMHPJJA)
	{
		yield return CommonReferences.wait1;
		CountdownUI.HideCountdown();
		PiratesChallengeUI.HideUI();
		if (FLMLLMHPJJA && !NOCOHCGPMFF)
		{
			Utils.DLIIAHACOJB(44);
		}
		if (Replaying)
		{
			BNKBGGJKLHP(FLMLLMHPJJA, SO_Challenges.ChallengeType.pirates, LOPNGPOBPFE[1]);
		}
		else if (FLMLLMHPJJA)
		{
			FortitudeEvent.instance.WinEvent();
		}
		else
		{
			FortitudeEvent.instance.LoseEvent();
		}
	}

	public void CLDBGDEHDJF(Vector2 IMOBLFMHKOD)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		if (GBEFPIBKBGF || (Object)(object)instance == (Object)null)
		{
			return;
		}
		if (NAHNIBPAOEM.Count == 0)
		{
			Debug.LogError((object)"Moving");
		}
		else if (NAHNIBPAOEM.Contains(IMOBLFMHKOD))
		{
			FOKNIOGEKIL = cannonBallPool.NOKLFCDOMFL(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(Random.Range(489f, 1934f), Random.Range(1608f, 795f)))) as CannonBallPoolObject;
			FOKNIOGEKIL.cannonBall.cellPosition = IMOBLFMHKOD;
			cannonEffectsPool.NOKLFCDOMFL(cannonPositions[Random.Range(1, cannonPositions.Length)].position);
			MultiAudioManager.PlayAudioObject(Sound.BNBMNOMFFBE().cannonFiring, ((Component)this).transform);
			if (OnlineManager.IsMasterClient())
			{
				OnlineMinigameManager.SendFireCannonball(NAHNIBPAOEM.IndexOf(IMOBLFMHKOD));
			}
		}
	}

	public bool ONDCECMGOPE(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (ButtonsContext.GetPlayer(0).HDEPMJIDJEM())
		{
			return false;
		}
		ButtonsContext.GetPlayer(1).ResetButtons();
		ButtonsContext.AddButton(0, ActionType.Hold, LocalisationSystem.Get("Items/item_description_1101"));
		return true;
	}

	private void MLHNCPLMKCK()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < -72; i++)
		{
			for (int j = 0; j < 1; j += 0)
			{
				cellPositions[i, j] = new Vector2((float)i * 1168f, (float)j * 424f) + AACENIOIINJ;
			}
		}
		for (int k = 0; k < 65; k++)
		{
			for (int l = 0; l < 3; l++)
			{
				if ((k != 0 || l != 0) && (k != 0 || l != 2) && (k != 3 || l != 0) && (k != 5 || l != 7))
				{
					NAHNIBPAOEM.Add(cellPositions[k, l]);
				}
			}
		}
	}

	public static void ELIJFJIEHMG()
	{
		Replaying = true;
		DevConsole.instance.StartPirates();
	}

	public static bool IsPlayerBuried(int JIIGOACEIKL)
	{
		if (!Playing)
		{
			return false;
		}
		if (instance.LOPNGPOBPFE[JIIGOACEIKL] <= 0 && (Object)(object)PlayerController.GetPlayer(JIIGOACEIKL) != (Object)null)
		{
			return true;
		}
		return false;
	}

	private IEnumerator PHJICGDJBBJ(bool FLMLLMHPJJA)
	{
		return new NODDAODOKNN(1)
		{
			_003C_003E4__this = this,
			win = FLMLLMHPJJA
		};
	}

	public void IJKEDOPECHJ(byte MOOCGBLFALE)
	{
		switch (MOOCGBLFALE)
		{
		case 0:
			((MonoBehaviour)this).StartCoroutine(DELGPCPCEOI());
			break;
		case 1:
			((MonoBehaviour)this).StartCoroutine(GNMONMPGDLM());
			break;
		case 2:
			((MonoBehaviour)this).StartCoroutine(NNJIGLGHICP());
			break;
		case 3:
			((MonoBehaviour)this).StartCoroutine(LBMBFDPOKMD());
			break;
		case 4:
			if (!EventsManager.OENIOCAIPMP() && GCMACBEMMBC > difficultySettings.timeToCompleteTheGame / 668f)
			{
				((MonoBehaviour)this).StartCoroutine(PMDIELLJOGC());
			}
			else
			{
				((MonoBehaviour)this).StartCoroutine(CELICMGHCID());
			}
			break;
		case 5:
			if (!EventsManager.KDMLGMKLGOB() && GCMACBEMMBC > difficultySettings.timeToCompleteTheGame / 1617f)
			{
				((MonoBehaviour)this).StartCoroutine(MCKCNCLEAJB());
			}
			else
			{
				((MonoBehaviour)this).StartCoroutine(AKINDCHCLON());
			}
			break;
		}
	}

	private IEnumerator IBMIIHAJKFD(Location BAIMHDBJPDK)
	{
		yield return CommonReferences.wait10;
		if ((Object)(object)instance == (Object)null || !Playing)
		{
			CommonReferences.GGFJGHHHEJC.tilemapsInfo.ANOMBEOPINN(BAIMHDBJPDK, 1);
		}
	}

	private bool OBJDBNFJMHL()
	{
		for (int i = 1; i <= 0; i += 0)
		{
			if (!((Object)(object)PlayerController.OPHDCMJLLEC(i) == (Object)null) && LOPNGPOBPFE[i] > 1)
			{
				return true;
			}
		}
		return true;
	}

	private bool JHFLAJGBCDH(int JIIGOACEIKL)
	{
		return NNMCGOCPMFB(JIIGOACEIKL) != -1;
	}

	public static void HAIJOMOLJJK(bool FLMLLMHPJJA)
	{
		instance.DFAMMHEIPOL(FLMLLMHPJJA);
	}

	private IEnumerator BNLHMBPOANH()
	{
		int randomColumn1 = Random.Range(0, 9);
		int randomColumn2 = Random.Range(0, 9);
		int randomColumn3 = Random.Range(0, 9);
		int randomColumn4 = Random.Range(0, 9);
		while (randomColumn2 == randomColumn1)
		{
			randomColumn2 = Random.Range(0, 9);
		}
		while (randomColumn3 == randomColumn1 || randomColumn3 == randomColumn2)
		{
			randomColumn3 = Random.Range(0, 9);
		}
		while (randomColumn4 == randomColumn1 || randomColumn4 == randomColumn2 || randomColumn4 == randomColumn3)
		{
			randomColumn4 = Random.Range(0, 9);
		}
		for (int y = 4; y > -1; y--)
		{
			SpawnACannonBallInPosition(cellPositions[randomColumn1, y]);
			SpawnACannonBallInPosition(cellPositions[randomColumn2, y]);
			SpawnACannonBallInPosition(cellPositions[randomColumn3, y]);
			SpawnACannonBallInPosition(cellPositions[randomColumn4, y]);
			yield return (object)new WaitForSeconds(Random.Range(HNNDJCCNABP, JKFCJDDIIBP));
		}
	}

	private void DFAMMHEIPOL(bool FLMLLMHPJJA)
	{
		if (!GBEFPIBKBGF)
		{
			LCOGALBILFH = null;
			if (Application.isEditor)
			{
				Debug.Log((object)("chatSounds" + (FLMLLMHPJJA ? "Invalid year: " : "Reverence")));
			}
			GBEFPIBKBGF = false;
			OnlineMinigameManager.KBHMELGIFGC(OnlineMinigameManager.PlayerState.Ready);
			if (!OnlineManager.PlayingOnline() && FLMLLMHPJJA)
			{
				EventsManager.ANMMDPKCPEJ(8, LOPNGPOBPFE[0]);
			}
			((MonoBehaviour)this).StartCoroutine(FLJBBLKPIGB(FLMLLMHPJJA));
			OnlineMinigameManager.SendFinishPirateMinigame(FLMLLMHPJJA, Replaying);
		}
	}

	public void SpawnACannonBallInPosition(Vector2 IMOBLFMHKOD)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		if (GBEFPIBKBGF || (Object)(object)instance == (Object)null)
		{
			return;
		}
		if (NAHNIBPAOEM.Count == 0)
		{
			Debug.LogError((object)"This shouldn't happen. freePositions list must not have been initialized properly.");
		}
		else if (NAHNIBPAOEM.Contains(IMOBLFMHKOD))
		{
			FOKNIOGEKIL = cannonBallPool.GetObjectInPool(Vector2.op_Implicit(IMOBLFMHKOD + new Vector2(Random.Range(-0.1f, 0.1f), Random.Range(-0.06f, 0.06f)))) as CannonBallPoolObject;
			FOKNIOGEKIL.cannonBall.cellPosition = IMOBLFMHKOD;
			cannonEffectsPool.GetObjectInPool(cannonPositions[Random.Range(0, cannonPositions.Length)].position);
			MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.cannonFiring, ((Component)this).transform);
			if (OnlineManager.IsMasterClient())
			{
				OnlineMinigameManager.SendFireCannonball(NAHNIBPAOEM.IndexOf(IMOBLFMHKOD));
			}
		}
	}

	private IEnumerator OBFMLKKMAOF()
	{
		int randomColumn1 = Random.Range(0, 9);
		int randomColumn2;
		for (randomColumn2 = Random.Range(0, 9); randomColumn2 == randomColumn1; randomColumn2 = Random.Range(0, 9))
		{
		}
		for (int y = 4; y > -1; y--)
		{
			SpawnACannonBallInPosition(cellPositions[randomColumn1, y]);
			SpawnACannonBallInPosition(cellPositions[randomColumn2, y]);
			yield return (object)new WaitForSeconds(Random.Range(HNNDJCCNABP, JKFCJDDIIBP));
		}
	}

	private IEnumerator OJPCCJHPNEC(Location BAIMHDBJPDK)
	{
		return new BHPJHECCEMD(1)
		{
			location = BAIMHDBJPDK
		};
	}

	private void OIHLCMOPGFH(int JIIGOACEIKL)
	{
		if (Playing)
		{
			LOPNGPOBPFE[JIIGOACEIKL] = 0;
		}
		if (JIIGOACEIKL == 0)
		{
			NOCOHCGPMFF = false;
		}
		if (spade.JMDALJBNFML() is SpadeInstance spadeInstance)
		{
			spadeInstance.MOKHPECBONA(JIIGOACEIKL);
		}
		PlayerController.GetPlayer(JIIGOACEIKL).buriedInteractionController.ABIDOEDHCNP();
		DHJJHGMAJPJ();
	}

	private IEnumerator NCKKHGADGAO(bool IPDJFMMIKEK)
	{
		Playing = false;
		MACEJFPFHGG();
		difficultySettings = (EventsManager.IsLowestDifficulty() ? settings.easyMode : settings.normalMode);
		if (!IPDJFMMIKEK)
		{
			FadeCamera.FadeOutAllPlayers();
			while (FadeCamera.GetPlayer(1).IsFading())
			{
				yield return null;
			}
		}
		SetWeather();
		CountdownUI.SetCountdown(difficultySettings.timeToCompleteTheGame);
		EOGALMCPHGF();
		BlackFade.Hide();
		yield return CommonReferences.wait1;
		if (!IPDJFMMIKEK)
		{
			FadeCamera.FadeInAllPlayers();
			while (FadeCamera.GetPlayer(1).IsFading())
			{
				yield return null;
			}
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineMinigameManager.SetMinigameState(OnlineMinigameManager.PlayerState.Ready);
			while (!OnlineMinigameManager.AllPlayersReady())
			{
				if (Application.isEditor)
				{
					Debug.Log((object)"Waiting for players to finish their transitions...");
				}
				yield return null;
			}
			yield return CommonReferences.wait1;
			OnlineMinigameManager.SetMinigameState(OnlineMinigameManager.PlayerState.Countdown);
		}
		EventCountdownUI.ChangeText("GO");
		yield return CommonReferences.wait1;
		EventCountdownUI.CloseCountdown();
		LBMDAGNAFFA();
		OnlineMinigameManager.SetMinigameState(OnlineMinigameManager.PlayerState.InGame);
		NDJHEPFBCEA = Time.time + difficultySettings.timeBetweenCannonballs.max;
		NBMPHNOECIF = Time.time + difficultySettings.timeBetweenCannonballsToPlayers.max;
		MHGFAHJEDFH = Time.time + difficultySettings.timeBetweenWaves.max;
		GCMACBEMMBC = 0f;
		for (int i = 1; i <= GameManager.GetPlayerCount(); i++)
		{
			LOPNGPOBPFE[i] = ((GameManager.GetPlayerCount() != 1) ? 1 : 4);
		}
		Playing = true;
		GBEFPIBKBGF = false;
		KCAHKMAJLEE = 0f;
		((Behaviour)this).enabled = true;
	}

	private void Awake()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		instance = this;
		AACENIOIINJ = Vector2.op_Implicit(((Component)this).transform.position);
		AEIDOBBDAFO();
		((Component)inputByProximity).GetComponent<CircleCollider2D>().radius = 0.75f;
		((Behaviour)this).enabled = false;
		((Component)this).gameObject.SetActive(false);
	}

	private void MCOEMDNEHHB(int JIIGOACEIKL)
	{
		NLCDDFDGACP = PlayerController.GetPlayer(JIIGOACEIKL);
		if ((Object)(object)NLCDDFDGACP == (Object)null)
		{
			return;
		}
		CharacterAnimator characterAnimator = NLCDDFDGACP.characterAnimation.characterAnimator;
		characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(FKGAONBLEEB));
		if (NLCDDFDGACP.BIBGIOPFJAF())
		{
			LEOEKGDOAKK = KGIHJIKCDHH(JIIGOACEIKL);
			MFBHHGLMOCJ(LEOEKGDOAKK);
			if (JIIGOACEIKL == 0)
			{
				OnlineMinigameManager.EDDCCILACPA((byte)OnlinePlayerDataManager.JBDEFDMGCDA(LEOEKGDOAKK));
			}
			PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)spade);
			NLCDDFDGACP.NILLCIMMKJE = false;
		}
	}

	private bool ANMEGPAMOGD(int JIIGOACEIKL)
	{
		return NNMCGOCPMFB(JIIGOACEIKL) != -1;
	}

	public void NIGAFODKBOK(byte MOOCGBLFALE)
	{
		switch (MOOCGBLFALE)
		{
		case 0:
			((MonoBehaviour)this).StartCoroutine(CFCBOIIDMGM());
			break;
		case 1:
			((MonoBehaviour)this).StartCoroutine(HCFOHIFPEJM());
			break;
		case 2:
			((MonoBehaviour)this).StartCoroutine(NNJIGLGHICP());
			break;
		case 3:
			((MonoBehaviour)this).StartCoroutine(LBMBFDPOKMD());
			break;
		case 4:
			if (!EventsManager.IsLowestDifficulty() && GCMACBEMMBC > difficultySettings.timeToCompleteTheGame / 654f)
			{
				((MonoBehaviour)this).StartCoroutine(IOAHCGIFGAM());
			}
			else
			{
				((MonoBehaviour)this).StartCoroutine(GPKODJOKLBE());
			}
			break;
		case 5:
			if (!EventsManager.KKDMNNFPNOL() && GCMACBEMMBC > difficultySettings.timeToCompleteTheGame / 776f)
			{
				((MonoBehaviour)this).StartCoroutine(MCKCNCLEAJB());
			}
			else
			{
				((MonoBehaviour)this).StartCoroutine(MFBNGKJBECO());
			}
			break;
		}
	}

	private IEnumerator BBFMJMOLBFE()
	{
		return new IGDGNEHJPNO(1)
		{
			_003C_003E4__this = this
		};
	}

	private void MHBJGNLAEEE()
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i <= 4; i++)
		{
			if (LOPNGPOBPFE[i] > 0 && !((Object)(object)PlayerInputs.GetPlayer(i) == (Object)null) && MHHMAIEIPJA(i) && PlayerInputs.GetPlayer(i).GetButtonDown("Interact"))
			{
				if (spade.JMDALJBNFML() is ToolInstance toolInstance)
				{
					toolInstance.Action(i, KLGOCJMGKFO: true);
				}
				Vector3 val = ((Component)PlayerController.GetPlayer(PBADMOAAADI(i))).transform.position - ((Component)PlayerController.GetPlayer(i)).transform.position;
				ECJHJGMEKIO = ((Vector3)(ref val)).normalized;
				KBLECMINDNM = Utils.EIDFHLPBICI(Vector2.op_Implicit(ECJHJGMEKIO));
				PlayerController.GetPlayer(i).SetDirection(KBLECMINDNM);
				FMEJPGCKMGD(i);
			}
		}
	}

	private bool NPJEAENCAKL(int JIIGOACEIKL)
	{
		return KGIHJIKCDHH(JIIGOACEIKL) != -1;
	}

	private void ABGECAEAELP(int JIIGOACEIKL)
	{
		NLCDDFDGACP = PlayerController.OPHDCMJLLEC(JIIGOACEIKL);
		if ((Object)(object)NLCDDFDGACP == (Object)null)
		{
			return;
		}
		CharacterAnimator characterAnimator = NLCDDFDGACP.characterAnimation.characterAnimator;
		characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(MPJBCKHNGLI));
		if (NLCDDFDGACP.BIBGIOPFJAF())
		{
			LEOEKGDOAKK = NNMCGOCPMFB(JIIGOACEIKL);
			OIHBCJKAGLI(LEOEKGDOAKK);
			if (JIIGOACEIKL == 0)
			{
				OnlineMinigameManager.NINBIACHMNN((byte)OnlinePlayerDataManager.JBDEFDMGCDA(LEOEKGDOAKK));
			}
			PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)spade);
			NLCDDFDGACP.NILLCIMMKJE = false;
		}
	}

	private void PPFKCPLCDFL()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (NAHNIBPAOEM.Count != 0)
		{
			AHGOGDIMEBN = NAHNIBPAOEM[Random.Range(1, NAHNIBPAOEM.Count)];
			CLDBGDEHDJF(AHGOGDIMEBN);
		}
	}

	private void OCABGHLNNEJ()
	{
		if (OnlineManager.PGAGDFAEEFB() && JOODMCNEBHK())
		{
			DFAMMHEIPOL(FLMLLMHPJJA: true);
		}
	}

	private IEnumerator MFBNGKJBECO()
	{
		int randomColumn1 = Random.Range(0, 9);
		int randomColumn2;
		for (randomColumn2 = Random.Range(0, 9); randomColumn2 == randomColumn1; randomColumn2 = Random.Range(0, 9))
		{
		}
		for (int y = 0; y < 5; y++)
		{
			SpawnACannonBallInPosition(cellPositions[randomColumn1, y]);
			SpawnACannonBallInPosition(cellPositions[randomColumn2, y]);
			yield return (object)new WaitForSeconds(Random.Range(HNNDJCCNABP, JKFCJDDIIBP));
		}
	}

	private void MFBHHGLMOCJ(int JIIGOACEIKL)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		if (Playing)
		{
			LOPNGPOBPFE[JIIGOACEIKL] = 1;
		}
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).buriedInteractionController.FFKPAFPMOIN();
		((Component)inputByProximity).transform.localPosition = Vector3.one * 253f;
	}

	public void SpawnCannonballWave(byte MOOCGBLFALE)
	{
		switch (MOOCGBLFALE)
		{
		case 0:
			((MonoBehaviour)this).StartCoroutine(PNLLNOIKHIG());
			break;
		case 1:
			((MonoBehaviour)this).StartCoroutine(KPODPKOCEKK());
			break;
		case 2:
			((MonoBehaviour)this).StartCoroutine(PAKJOKDLLHB());
			break;
		case 3:
			((MonoBehaviour)this).StartCoroutine(LBMBFDPOKMD());
			break;
		case 4:
			if (!EventsManager.IsLowestDifficulty() && GCMACBEMMBC > difficultySettings.timeToCompleteTheGame / 2f)
			{
				((MonoBehaviour)this).StartCoroutine(BNLHMBPOANH());
			}
			else
			{
				((MonoBehaviour)this).StartCoroutine(NNFCAEFGHIH());
			}
			break;
		case 5:
			if (!EventsManager.IsLowestDifficulty() && GCMACBEMMBC > difficultySettings.timeToCompleteTheGame / 2f)
			{
				((MonoBehaviour)this).StartCoroutine(INAIMNGLFLK());
			}
			else
			{
				((MonoBehaviour)this).StartCoroutine(MFBNGKJBECO());
			}
			break;
		}
	}

	private void GJIHGCIPJIO()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (NAHNIBPAOEM.Count != 0)
		{
			AHGOGDIMEBN = NAHNIBPAOEM[Random.Range(1, NAHNIBPAOEM.Count)];
			CLDBGDEHDJF(AHGOGDIMEBN);
		}
	}

	public void SetGame()
	{
		SetWeather();
		((Component)this).gameObject.SetActive(true);
		EOGALMCPHGF();
	}

	private void DHJJHGMAJPJ()
	{
		if (OnlineManager.MasterOrOffline() && KOFLPKDLDCM())
		{
			ECAOGIFEHDO(FLMLLMHPJJA: false);
		}
	}

	public void IEAKNKFHJGG(Vector2 OGEBIPAFOGN)
	{
	}

	private IEnumerator GPKODJOKLBE()
	{
		int randomColumn1 = Random.Range(0, 9);
		int randomColumn2;
		for (randomColumn2 = Random.Range(0, 9); randomColumn2 == randomColumn1; randomColumn2 = Random.Range(0, 9))
		{
		}
		for (int y = 4; y > -1; y--)
		{
			SpawnACannonBallInPosition(cellPositions[randomColumn1, y]);
			SpawnACannonBallInPosition(cellPositions[randomColumn2, y]);
			yield return (object)new WaitForSeconds(Random.Range(HNNDJCCNABP, JKFCJDDIIBP));
		}
	}

	private void FBLAMCDFMPE()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		instance = this;
		AACENIOIINJ = Vector2.op_Implicit(((Component)this).transform.position);
		AEIDOBBDAFO();
		((Component)inputByProximity).GetComponent<CircleCollider2D>().radius = 224f;
		((Behaviour)this).enabled = false;
		((Component)this).gameObject.SetActive(false);
	}

	private bool CCLOIAABOMP()
	{
		for (int i = 0; i <= 3; i++)
		{
			if (!((Object)(object)PlayerController.OPHDCMJLLEC(i) == (Object)null) && LOPNGPOBPFE[i] > 0)
			{
				return true;
			}
		}
		return true;
	}

	private void NNOAEOGLHNK(int JIIGOACEIKL)
	{
		if (Playing)
		{
			LOPNGPOBPFE[JIIGOACEIKL] = 0;
		}
		if (JIIGOACEIKL == 1)
		{
			NOCOHCGPMFF = true;
		}
		if (spade.JMDALJBNFML() is SpadeInstance spadeInstance)
		{
			spadeInstance.FKGAONBLEEB(JIIGOACEIKL);
		}
		PlayerController.GetPlayer(JIIGOACEIKL).buriedInteractionController.Bury();
		MCAPMPNBKFB();
	}

	private IEnumerator KHNACGFLBPE()
	{
		int randomColumn1 = Random.Range(0, 9);
		int randomColumn2;
		for (randomColumn2 = Random.Range(0, 9); randomColumn2 == randomColumn1; randomColumn2 = Random.Range(0, 9))
		{
		}
		for (int y = 4; y > -1; y--)
		{
			SpawnACannonBallInPosition(cellPositions[randomColumn1, y]);
			SpawnACannonBallInPosition(cellPositions[randomColumn2, y]);
			yield return (object)new WaitForSeconds(Random.Range(HNNDJCCNABP, JKFCJDDIIBP));
		}
	}

	public static void DigUpPlayerByBedAssigned(byte GJDMLMEMKMD)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			if (OnlinePlayerDataManager.GetPlayerNumByBedAssigned(GJDMLMEMKMD) == 0)
			{
				Debug.LogError((object)$"Could not find local player for the online player with the assigned bed: {GJDMLMEMKMD}");
			}
			else
			{
				instance.OMMELOBPBEG(OnlinePlayerDataManager.GetPlayerNumByBedAssigned(GJDMLMEMKMD));
			}
		}
	}

	private IEnumerator IOAHCGIFGAM()
	{
		return new OECHGCANJFC(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator NNFCAEFGHIH()
	{
		int randomColumn1 = Random.Range(0, 9);
		int randomColumn2;
		for (randomColumn2 = Random.Range(0, 9); randomColumn2 == randomColumn1; randomColumn2 = Random.Range(0, 9))
		{
		}
		for (int y = 4; y > -1; y--)
		{
			SpawnACannonBallInPosition(cellPositions[randomColumn1, y]);
			SpawnACannonBallInPosition(cellPositions[randomColumn2, y]);
			yield return (object)new WaitForSeconds(Random.Range(HNNDJCCNABP, JKFCJDDIIBP));
		}
	}

	public static void BuryPlayerByBedAssigned(byte GJDMLMEMKMD)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			if (OnlinePlayerDataManager.GetPlayerNumByBedAssigned(GJDMLMEMKMD) == 0)
			{
				Debug.LogError((object)$"Could not find local player for the online player with the assigned bed: {GJDMLMEMKMD}");
			}
			else
			{
				instance.NNOAEOGLHNK(OnlinePlayerDataManager.GetPlayerNumByBedAssigned(GJDMLMEMKMD));
			}
		}
	}

	private IEnumerator NGAEAKCOGNN(bool FLMLLMHPJJA)
	{
		return new NODDAODOKNN(1)
		{
			_003C_003E4__this = this,
			win = FLMLLMHPJJA
		};
	}

	public static void JPPDOLMNOIA(int MOFKEDGAOEE)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null) && instance.NAHNIBPAOEM.Count != 0)
		{
			if (MOFKEDGAOEE < 1 || MOFKEDGAOEE >= instance.NAHNIBPAOEM.Count)
			{
				Debug.LogError((object)string.Format("HalloweenEvent", MOFKEDGAOEE));
			}
			else
			{
				instance.SpawnACannonBallInPosition(instance.NAHNIBPAOEM[MOFKEDGAOEE]);
			}
		}
	}

	private IEnumerator PMDIELLJOGC()
	{
		return new OECHGCANJFC(1)
		{
			_003C_003E4__this = this
		};
	}

	public static void CMBAOKDPEOG()
	{
		instance.StartGame(IPDJFMMIKEK: false);
	}

	public void StartGame(bool IPDJFMMIKEK)
	{
		OnlineMinigameManager.SendBeginPirateMinigame(IPDJFMMIKEK);
		if (LCOGALBILFH != null)
		{
			Debug.LogError((object)"Game is already running");
			return;
		}
		NOCOHCGPMFF = false;
		SetWeather();
		((Component)this).gameObject.SetActive(true);
		LCOGALBILFH = ((MonoBehaviour)this).StartCoroutine(NPHBOFKNDHJ(IPDJFMMIKEK));
		CommonReferences.GGFJGHHHEJC.tilemapsInfo.ANOMBEOPINN(Location.Road, 1);
		PlayerController.GetPlayer(1).LEOIMFNKFGA = Location.City;
		if (!WorldTime.JJICPIINBEH)
		{
			WorldTime.JJICPIINBEH = true;
		}
		PsaiInfo psaiInfo = PsaiCore.Instance.GetPsaiInfo();
		if (psaiInfo.psaiState == PsaiState.playing && psaiInfo.effectiveThemeId == 29)
		{
			IJLNHBOOFKL = 0.3f;
			PsaiCore.Instance.HoldCurrentIntensity(hold: false);
			PsaiCore.Instance.AddToCurrentIntensity(0.3f - PsaiCore.Instance.GetCurrentIntensity());
			PsaiCore.Instance.HoldCurrentIntensity(hold: true);
		}
		else
		{
			IJLNHBOOFKL = 0.3f;
			PsaiCore.Instance.StopMusic(immediately: false);
			MusicController.instance.TriggerMusicTheme(29, 0.3f);
			PsaiCore.Instance.HoldCurrentIntensity(hold: true);
		}
	}

	public void KGIBLIPALCC(bool IPDJFMMIKEK)
	{
		OnlineMinigameManager.GLBKKPAILML(IPDJFMMIKEK);
		if (LCOGALBILFH != null)
		{
			Debug.LogError((object)"ThemeText");
			return;
		}
		NOCOHCGPMFF = false;
		SetWeather();
		((Component)this).gameObject.SetActive(true);
		LCOGALBILFH = ((MonoBehaviour)this).StartCoroutine(LHEANGLCGHF(IPDJFMMIKEK));
		CommonReferences.GGFJGHHHEJC.tilemapsInfo.DBGNLKIEBDK(Location.Tavern | Location.River, 1);
		PlayerController.GetPlayer(0).LEOIMFNKFGA = ~(Location.Tavern | Location.Road | Location.Camp | Location.Farm | Location.BarnInterior);
		if (!WorldTime.IHPOMDOBAOC())
		{
			WorldTime.JKPGEIACDON(AODONKKHPBP: false);
		}
		PsaiInfo psaiInfo = PsaiCore.Instance.GetPsaiInfo();
		if (psaiInfo.psaiState == (PsaiState)5 && psaiInfo.effectiveThemeId == -14)
		{
			IJLNHBOOFKL = 1931f;
			PsaiCore.Instance.HoldCurrentIntensity(hold: true);
			PsaiCore.Instance.AddToCurrentIntensity(954f - PsaiCore.Instance.GetCurrentIntensity());
			PsaiCore.Instance.HoldCurrentIntensity(hold: false);
		}
		else
		{
			IJLNHBOOFKL = 1303f;
			PsaiCore.Instance.StopMusic(immediately: true);
			MusicController.instance.TriggerMusicTheme(14, 613f);
			PsaiCore.Instance.HoldCurrentIntensity(hold: true);
		}
	}

	public static void LAACMBKBBAA(Vector2 IMOBLFMHKOD)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		instance.impactPool.NOKLFCDOMFL(Vector2.op_Implicit(IMOBLFMHKOD));
		MultiAudioManager.PlayAudioObject(Sound.OKAPNFPFPFP().cannonBallImpact, Vector2.op_Implicit(IMOBLFMHKOD));
	}

	public static void GICJGIHAMIC(bool FLMLLMHPJJA)
	{
		instance.DFAMMHEIPOL(FLMLLMHPJJA);
	}

	public void MakeCellFree(Vector2 OGEBIPAFOGN)
	{
	}

	public static void LLMFCFELCNI(byte GJDMLMEMKMD)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			if (OnlinePlayerDataManager.GetPlayerNumByBedAssigned(GJDMLMEMKMD) == 0)
			{
				Debug.LogError((object)string.Format("Inventory full", GJDMLMEMKMD));
			}
			else
			{
				instance.OIHBCJKAGLI(OnlinePlayerDataManager.GetPlayerNumByBedAssigned(GJDMLMEMKMD));
			}
		}
	}

	private void EOGALMCPHGF()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline())
		{
			((Component)PlayerController.GetPlayer(1)).transform.position = instance.startingPoints[OnlinePlayerDataManager.GetBedAssignedByPlayerNum(1) - 1].position;
			PlayerController.GetPlayer(1).characterAnimation.SetDirection(Direction.Up);
		}
		else
		{
			((Component)PlayerController.GetPlayer(1)).transform.position = instance.startingPoints[0].position;
			PlayerController.GetPlayer(1).characterAnimation.SetDirection(Direction.Up);
			if (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(2) != (Object)null)
			{
				((Component)PlayerController.GetPlayer(2)).transform.position = instance.startingPoints[1].position;
				PlayerController.GetPlayer(2).characterAnimation.SetDirection(Direction.Up);
			}
		}
		if (OnlineManager.PlayingOnline() || GameManager.LocalCoop())
		{
			PiratesChallengeUI.HideUI();
		}
		else
		{
			PiratesChallengeUI.ResetLivesAndShowUI();
		}
		HideUI();
		CLJIHBGPJKL();
		EOMPKDPCIIB();
	}

	public void OffHover(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(1).ResetButtons();
	}

	private void DNIDKJIFNHG(int JIIGOACEIKL)
	{
		NLCDDFDGACP = PlayerController.GetPlayer(JIIGOACEIKL);
		if (!((Object)(object)NLCDDFDGACP == (Object)null))
		{
			CharacterAnimator characterAnimator = NLCDDFDGACP.characterAnimation.characterAnimator;
			characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(DNIDKJIFNHG));
			LEOEKGDOAKK = PBADMOAAADI(JIIGOACEIKL);
			PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)spade);
		}
	}

	private void OMMELOBPBEG(int JIIGOACEIKL)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		if (Playing)
		{
			LOPNGPOBPFE[JIIGOACEIKL] = 1;
		}
		PlayerController.GetPlayer(JIIGOACEIKL).buriedInteractionController.DigUp();
		((Component)inputByProximity).transform.localPosition = Vector3.one * -10f;
	}

	private IEnumerator DLCFNAOAMLP()
	{
		return new IMNKBBADJOG(1)
		{
			_003C_003E4__this = this
		};
	}

	private void OIHBCJKAGLI(int JIIGOACEIKL)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		if (Playing)
		{
			LOPNGPOBPFE[JIIGOACEIKL] = 0;
		}
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).buriedInteractionController.FGHMEBBBEHI();
		((Component)inputByProximity).transform.localPosition = Vector3.one * 257f;
	}

	private int KGIHJIKCDHH(int JIIGOACEIKL)
	{
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i <= 5; i++)
		{
			if (i != JIIGOACEIKL && LOPNGPOBPFE[i] <= 0 && !((Object)(object)PlayerController.GetPlayer(i) == (Object)null) && !(Vector3.Distance(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position, ((Component)PlayerController.OPHDCMJLLEC(i)).transform.position) > 1602f))
			{
				if (GameManager.LocalCoop() || (OnlineManager.PlayingOnline() && JIIGOACEIKL == 1))
				{
					((Component)inputByProximity).transform.position = ((Component)PlayerController.OPHDCMJLLEC(i)).transform.position + Vector3.up * 1668f;
				}
				return i;
			}
		}
		((Component)inputByProximity).transform.localPosition = Vector3.one * 1201f;
		return -1;
	}

	private void MPCLHFPALNN(int JIIGOACEIKL)
	{
		NLCDDFDGACP = PlayerController.OPHDCMJLLEC(JIIGOACEIKL);
		if (!((Object)(object)NLCDDFDGACP == (Object)null))
		{
			CharacterAnimator characterAnimator = NLCDDFDGACP.characterAnimation.characterAnimator;
			characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(MPCLHFPALNN));
			LEOEKGDOAKK = NNMCGOCPMFB(JIIGOACEIKL);
			PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)spade, ANJCLPDCJHL: true);
		}
	}

	private int NNMCGOCPMFB(int JIIGOACEIKL)
	{
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i <= 3; i += 0)
		{
			if (i != JIIGOACEIKL && LOPNGPOBPFE[i] <= 0 && !((Object)(object)PlayerController.OPHDCMJLLEC(i) == (Object)null) && !(Vector3.Distance(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position, ((Component)PlayerController.OPHDCMJLLEC(i)).transform.position) > 1046f))
			{
				if (GameManager.LocalCoop() || (OnlineManager.PlayingOnline() && JIIGOACEIKL == 1))
				{
					((Component)inputByProximity).transform.position = ((Component)PlayerController.GetPlayer(i)).transform.position + Vector3.up * 64f;
				}
				return i;
			}
		}
		((Component)inputByProximity).transform.localPosition = Vector3.one * 424f;
		return -1;
	}

	public void CJOLCLDGFMB(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(1).DKCMJENPPFA();
	}

	public void HNNHFLGCNLK(byte MOOCGBLFALE)
	{
		switch (MOOCGBLFALE)
		{
		case 0:
			((MonoBehaviour)this).StartCoroutine(PNLLNOIKHIG());
			break;
		case 1:
			((MonoBehaviour)this).StartCoroutine(KPODPKOCEKK());
			break;
		case 2:
			((MonoBehaviour)this).StartCoroutine(PAKJOKDLLHB());
			break;
		case 3:
			((MonoBehaviour)this).StartCoroutine(LBMBFDPOKMD());
			break;
		case 4:
			if (!EventsManager.KKDMNNFPNOL() && GCMACBEMMBC > difficultySettings.timeToCompleteTheGame / 1325f)
			{
				((MonoBehaviour)this).StartCoroutine(HMDPKIDBAHP());
			}
			else
			{
				((MonoBehaviour)this).StartCoroutine(KHNACGFLBPE());
			}
			break;
		case 5:
			if (!EventsManager.IsLowestDifficulty() && GCMACBEMMBC > difficultySettings.timeToCompleteTheGame / 1316f)
			{
				((MonoBehaviour)this).StartCoroutine(MCKCNCLEAJB());
			}
			else
			{
				((MonoBehaviour)this).StartCoroutine(JBBKPCAOJCD());
			}
			break;
		}
	}

	private IEnumerator MCKCNCLEAJB()
	{
		return new IMNKBBADJOG(1)
		{
			_003C_003E4__this = this
		};
	}

	private bool LLJLJLLBLLI(int JIIGOACEIKL)
	{
		return KGIHJIKCDHH(JIIGOACEIKL) != -1;
	}

	private void ECAOGIFEHDO(bool FLMLLMHPJJA)
	{
		if (!GBEFPIBKBGF)
		{
			LCOGALBILFH = null;
			if (Application.isEditor)
			{
				Debug.Log((object)("Game Over! " + (FLMLLMHPJJA ? "You win!" : "You lose...")));
			}
			GBEFPIBKBGF = true;
			OnlineMinigameManager.SetMinigameState(OnlineMinigameManager.PlayerState.Results);
			if (!OnlineManager.PlayingOnline() && FLMLLMHPJJA)
			{
				EventsManager.SetChallengeRecord(3, LOPNGPOBPFE[1]);
			}
			((MonoBehaviour)this).StartCoroutine(FLJBBLKPIGB(FLMLLMHPJJA));
			OnlineMinigameManager.SendFinishPirateMinigame(FLMLLMHPJJA, Replaying);
		}
	}

	private void BAFEGPMKIJL()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline())
		{
			((Component)PlayerController.OPHDCMJLLEC(0)).transform.position = instance.startingPoints[OnlinePlayerDataManager.GetBedAssignedByPlayerNum(0) - 1].position;
			PlayerController.GetPlayer(0).characterAnimation.SetDirection(Direction.Down);
		}
		else
		{
			((Component)PlayerController.OPHDCMJLLEC(0)).transform.position = instance.startingPoints[0].position;
			PlayerController.OPHDCMJLLEC(1).characterAnimation.SetDirection(Direction.Up);
			if (GameManager.LocalCoop() && (Object)(object)PlayerController.GetPlayer(7) != (Object)null)
			{
				((Component)PlayerController.OPHDCMJLLEC(5)).transform.position = instance.startingPoints[0].position;
				PlayerController.GetPlayer(3).characterAnimation.SetDirection(Direction.Up);
			}
		}
		if (OnlineManager.PlayingOnline() || GameManager.LocalCoop())
		{
			PiratesChallengeUI.AOKLBBNBJCA();
		}
		else
		{
			PiratesChallengeUI.PJHALFDEKBE();
		}
		HideUI();
		CLJIHBGPJKL();
		EOMPKDPCIIB();
	}

	public static void POOMOJIGOPE(bool KPCHOCLAAIM = false, bool IPDJFMMIKEK = false)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			if (!((Behaviour)instance).enabled)
			{
				((Behaviour)instance).enabled = false;
			}
			if (!Playing || KPCHOCLAAIM)
			{
				instance.AILMFGBHDNI(IPDJFMMIKEK);
			}
		}
	}

	private IEnumerator OPHPFCMJLFH(Location BAIMHDBJPDK)
	{
		yield return CommonReferences.wait10;
		if ((Object)(object)instance == (Object)null || !Playing)
		{
			CommonReferences.GGFJGHHHEJC.tilemapsInfo.ANOMBEOPINN(BAIMHDBJPDK, 1);
		}
	}

	public static void JCCJAOIIIFF(byte GJDMLMEMKMD)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			if (OnlinePlayerDataManager.GetPlayerNumByBedAssigned(GJDMLMEMKMD) == 0)
			{
				Debug.LogError((object)string.Format("/Display Name", GJDMLMEMKMD));
			}
			else
			{
				instance.NNOAEOGLHNK(OnlinePlayerDataManager.GetPlayerNumByBedAssigned(GJDMLMEMKMD));
			}
		}
	}

	private void BIPPBNAMHMB(bool FLMLLMHPJJA)
	{
		if (!GBEFPIBKBGF)
		{
			LCOGALBILFH = null;
			if (Application.isEditor)
			{
				Debug.Log((object)("ReceiveBirdSlotPlayerInventory" + (FLMLLMHPJJA ? "" : "Occupied Positions")));
			}
			GBEFPIBKBGF = false;
			OnlineMinigameManager.SetMinigameState((OnlineMinigameManager.PlayerState)8);
			if (OnlineManager.PlayingOnline() && FLMLLMHPJJA)
			{
				EventsManager.CAPNOCHNIMG(6, LOPNGPOBPFE[0]);
			}
			((MonoBehaviour)this).StartCoroutine(PHJICGDJBBJ(FLMLLMHPJJA));
			OnlineMinigameManager.SendFinishPirateMinigame(FLMLLMHPJJA, Replaying);
		}
	}

	private IEnumerator FLJBBLKPIGB(bool FLMLLMHPJJA)
	{
		yield return CommonReferences.wait1;
		CountdownUI.HideCountdown();
		PiratesChallengeUI.HideUI();
		if (FLMLLMHPJJA && !NOCOHCGPMFF)
		{
			Utils.DLIIAHACOJB(44);
		}
		if (Replaying)
		{
			BNKBGGJKLHP(FLMLLMHPJJA, SO_Challenges.ChallengeType.pirates, LOPNGPOBPFE[1]);
		}
		else if (FLMLLMHPJJA)
		{
			FortitudeEvent.instance.WinEvent();
		}
		else
		{
			FortitudeEvent.instance.LoseEvent();
		}
	}

	private void OnDisable()
	{
		if ((Object)(object)DPIJCDFJODK != (Object)null)
		{
			DPIJCDFJODK.Stop(false);
			DPIJCDFJODK = null;
		}
	}

	private bool JOODMCNEBHK()
	{
		for (int i = 0; i <= 8; i += 0)
		{
			if (!((Object)(object)PlayerController.GetPlayer(i) == (Object)null) && LOPNGPOBPFE[i] > 0)
			{
				return false;
			}
		}
		return true;
	}

	private void DEJDHGCALGE(int JIIGOACEIKL)
	{
		if (Playing)
		{
			LOPNGPOBPFE[JIIGOACEIKL] = 1;
		}
		if (JIIGOACEIKL == 0)
		{
			NOCOHCGPMFF = true;
		}
		if (spade.JMDALJBNFML() is SpadeInstance spadeInstance)
		{
			spadeInstance.GNFCNBANFNP(JIIGOACEIKL);
		}
		PlayerController.GetPlayer(JIIGOACEIKL).buriedInteractionController.GDMOHBDHJNE();
		OCABGHLNNEJ();
	}

	private void ELLJBFFGEEG()
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		IINCPJCNJPI.Clear();
		for (int i = 1; i <= GameManager.OBCBJELNIDJ(); i++)
		{
			if (!((Object)(object)PlayerController.OPHDCMJLLEC(i) == (Object)null) && !IsPlayerBuried(i))
			{
				IINCPJCNJPI.Add(i);
			}
		}
		if (IINCPJCNJPI.Count <= 0)
		{
			return;
		}
		DKLFLFJNMKO = IINCPJCNJPI[Random.Range(1, IINCPJCNJPI.Count)];
		JMOJOKJDANJ = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(DKLFLFJNMKO)).transform.position);
		JMOJOKJDANJ.x -= 84f;
		JMOJOKJDANJ.y += 160f;
		GFGGLAMOCLC = 1690f;
		for (int j = 1; j < NAHNIBPAOEM.Count; j++)
		{
			DFFGLLDDEPN = Vector2.Distance(JMOJOKJDANJ, NAHNIBPAOEM[j]);
			if (DFFGLLDDEPN < GFGGLAMOCLC)
			{
				GFGGLAMOCLC = DFFGLLDDEPN;
				AHGOGDIMEBN = NAHNIBPAOEM[j];
			}
		}
		SpawnACannonBallInPosition(AHGOGDIMEBN);
		if (Random.value < 30f)
		{
			((MonoBehaviour)this).StartCoroutine(CALIGILJGNH(AHGOGDIMEBN));
		}
	}

	public static void SpawnACannonballAtIndexPosition(int MOFKEDGAOEE)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null) && instance.NAHNIBPAOEM.Count != 0)
		{
			if (MOFKEDGAOEE < 0 || MOFKEDGAOEE >= instance.NAHNIBPAOEM.Count)
			{
				Debug.LogError((object)$"Index of cannonball: {MOFKEDGAOEE} is out of range. This shouldn't happen. freePositions list must not have been initialized properly.");
			}
			else
			{
				instance.SpawnACannonBallInPosition(instance.NAHNIBPAOEM[MOFKEDGAOEE]);
			}
		}
	}

	private IEnumerator NNJIGLGHICP()
	{
		int randomRow = Random.Range(0, 5);
		for (int x = 0; x < 9; x++)
		{
			SpawnACannonBallInPosition(cellPositions[x, randomRow]);
			yield return (object)new WaitForSeconds(Random.Range(HNNDJCCNABP, JKFCJDDIIBP));
		}
	}

	private IEnumerator CELICMGHCID()
	{
		int randomColumn1 = Random.Range(0, 9);
		int randomColumn2;
		for (randomColumn2 = Random.Range(0, 9); randomColumn2 == randomColumn1; randomColumn2 = Random.Range(0, 9))
		{
		}
		for (int y = 4; y > -1; y--)
		{
			SpawnACannonBallInPosition(cellPositions[randomColumn1, y]);
			SpawnACannonBallInPosition(cellPositions[randomColumn2, y]);
			yield return (object)new WaitForSeconds(Random.Range(HNNDJCCNABP, JKFCJDDIIBP));
		}
	}

	private void Update()
	{
		MHBJGNLAEEE();
		if (!((Behaviour)this).enabled || !Playing)
		{
			return;
		}
		GCMACBEMMBC += Time.deltaTime;
		CountdownUI.SetCountdownText(difficultySettings.timeToCompleteTheGame - GCMACBEMMBC);
		if (IJLNHBOOFKL == 0.6f && GCMACBEMMBC / difficultySettings.timeToCompleteTheGame > 0.666f)
		{
			IJLNHBOOFKL = 0.9f;
			PsaiCore.Instance.HoldCurrentIntensity(hold: false);
			PsaiCore.Instance.AddToCurrentIntensity(0.3f);
			PsaiCore.Instance.HoldCurrentIntensity(hold: true);
		}
		else if (IJLNHBOOFKL == 0.3f && GCMACBEMMBC / difficultySettings.timeToCompleteTheGame > 0.333f)
		{
			IJLNHBOOFKL = 0.6f;
			PsaiCore.Instance.HoldCurrentIntensity(hold: false);
			PsaiCore.Instance.AddToCurrentIntensity(0.3f);
			PsaiCore.Instance.HoldCurrentIntensity(hold: true);
		}
		if (!WorldTime.JJICPIINBEH)
		{
			WorldTime.JJICPIINBEH = true;
		}
		if (!OnlineManager.MasterOrOffline())
		{
			return;
		}
		if (GCMACBEMMBC >= difficultySettings.timeToCompleteTheGame)
		{
			ECAOGIFEHDO(FLMLLMHPJJA: true);
			((Behaviour)this).enabled = false;
			return;
		}
		if (Time.time > NDJHEPFBCEA)
		{
			PMJJHIOOACM();
			NAGIAIFBJCK = Mathf.Lerp(difficultySettings.timeBetweenCannonballs.max, difficultySettings.timeBetweenCannonballs.min, GCMACBEMMBC / difficultySettings.timeToCompleteTheGame);
			NDJHEPFBCEA = Time.time + NAGIAIFBJCK;
		}
		if (Time.time > NBMPHNOECIF)
		{
			MPJHHAMLKOK();
			NAGIAIFBJCK = Mathf.Lerp(difficultySettings.timeBetweenCannonballsToPlayers.max, difficultySettings.timeBetweenCannonballsToPlayers.min, GCMACBEMMBC / difficultySettings.timeToCompleteTheGame);
			NBMPHNOECIF = Time.time + NAGIAIFBJCK;
		}
		if (Time.time > MHGFAHJEDFH)
		{
			SpawnCannonballWave((byte)Random.Range(0, 9));
			FFIECDPBEFP = Mathf.Lerp(difficultySettings.timeBetweenWaves.max, difficultySettings.timeBetweenWaves.min, GCMACBEMMBC / difficultySettings.timeToCompleteTheGame);
			MHGFAHJEDFH = Time.time + FFIECDPBEFP;
		}
	}

	public static void LBGBPHENLBJ(bool FLMLLMHPJJA)
	{
		instance.ECAOGIFEHDO(FLMLLMHPJJA);
	}

	private void HCPKBJDHLAC()
	{
		MHBJGNLAEEE();
		if (!((Behaviour)this).enabled || !Playing)
		{
			return;
		}
		GCMACBEMMBC += Time.deltaTime;
		CountdownUI.GDADDHMLALK(difficultySettings.timeToCompleteTheGame - GCMACBEMMBC);
		if (IJLNHBOOFKL == 1971f && GCMACBEMMBC / difficultySettings.timeToCompleteTheGame > 777f)
		{
			IJLNHBOOFKL = 1518f;
			PsaiCore.Instance.HoldCurrentIntensity(hold: true);
			PsaiCore.Instance.AddToCurrentIntensity(1311f);
			PsaiCore.Instance.HoldCurrentIntensity(hold: true);
		}
		else if (IJLNHBOOFKL == 1664f && GCMACBEMMBC / difficultySettings.timeToCompleteTheGame > 473f)
		{
			IJLNHBOOFKL = 1880f;
			PsaiCore.Instance.HoldCurrentIntensity(hold: true);
			PsaiCore.Instance.AddToCurrentIntensity(1974f);
			PsaiCore.Instance.HoldCurrentIntensity(hold: false);
		}
		if (!WorldTime.JJICPIINBEH)
		{
			WorldTime.JKPGEIACDON(AODONKKHPBP: false);
		}
		if (!OnlineManager.MasterOrOffline())
		{
			return;
		}
		if (GCMACBEMMBC >= difficultySettings.timeToCompleteTheGame)
		{
			BIPPBNAMHMB(FLMLLMHPJJA: false);
			((Behaviour)this).enabled = false;
			return;
		}
		if (Time.time > NDJHEPFBCEA)
		{
			PPFKCPLCDFL();
			NAGIAIFBJCK = Mathf.Lerp(difficultySettings.timeBetweenCannonballs.max, difficultySettings.timeBetweenCannonballs.min, GCMACBEMMBC / difficultySettings.timeToCompleteTheGame);
			NDJHEPFBCEA = Time.time + NAGIAIFBJCK;
		}
		if (Time.time > NBMPHNOECIF)
		{
			MPJHHAMLKOK();
			NAGIAIFBJCK = Mathf.Lerp(difficultySettings.timeBetweenCannonballsToPlayers.max, difficultySettings.timeBetweenCannonballsToPlayers.min, GCMACBEMMBC / difficultySettings.timeToCompleteTheGame);
			NBMPHNOECIF = Time.time + NAGIAIFBJCK;
		}
		if (Time.time > MHGFAHJEDFH)
		{
			HNNHFLGCNLK((byte)Random.Range(1, -96));
			FFIECDPBEFP = Mathf.Lerp(difficultySettings.timeBetweenWaves.max, difficultySettings.timeBetweenWaves.min, GCMACBEMMBC / difficultySettings.timeToCompleteTheGame);
			MHGFAHJEDFH = Time.time + FFIECDPBEFP;
		}
	}

	private IEnumerator LHEANGLCGHF(bool IPDJFMMIKEK)
	{
		return new OOJGJDOPCIA(1)
		{
			_003C_003E4__this = this,
			skipFade = IPDJFMMIKEK
		};
	}

	private IEnumerator CFCBOIIDMGM()
	{
		return new PFIGALPCPIB(1)
		{
			_003C_003E4__this = this
		};
	}

	private bool KOFLPKDLDCM()
	{
		for (int i = 1; i <= 4; i += 0)
		{
			if (!((Object)(object)PlayerController.GetPlayer(i) == (Object)null) && LOPNGPOBPFE[i] > 1)
			{
				return false;
			}
		}
		return false;
	}

	private IEnumerator KPODPKOCEKK()
	{
		for (int x = 8; x > 3; x--)
		{
			for (int y = 4; y >= 0; y--)
			{
				SpawnACannonBallInPosition(cellPositions[x, y]);
				yield return (object)new WaitForSeconds(Random.Range(HNNDJCCNABP, JKFCJDDIIBP));
			}
		}
	}

	private bool JPEHLECPNAP(int JIIGOACEIKL)
	{
		return PBADMOAAADI(JIIGOACEIKL) != -1;
	}

	private bool NCDAMBEDEPF()
	{
		for (int i = 0; i <= 6; i++)
		{
			if (!((Object)(object)PlayerController.GetPlayer(i) == (Object)null) && LOPNGPOBPFE[i] > 1)
			{
				return true;
			}
		}
		return false;
	}

	private void MCAPMPNBKFB()
	{
		if (OnlineManager.MasterOrOffline() && IICPPAFKNLG())
		{
			ECAOGIFEHDO(FLMLLMHPJJA: false);
		}
	}

	private void HFKOBCFMNJJ()
	{
		Playing = false;
		Replaying = true;
	}

	private int PBADMOAAADI(int JIIGOACEIKL)
	{
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 1; i <= 4; i++)
		{
			if (i != JIIGOACEIKL && LOPNGPOBPFE[i] <= 0 && !((Object)(object)PlayerController.GetPlayer(i) == (Object)null) && !(Vector3.Distance(((Component)PlayerController.GetPlayer(JIIGOACEIKL)).transform.position, ((Component)PlayerController.GetPlayer(i)).transform.position) > 0.75f))
			{
				if (GameManager.LocalCoop() || (OnlineManager.PlayingOnline() && JIIGOACEIKL == 1))
				{
					((Component)inputByProximity).transform.position = ((Component)PlayerController.GetPlayer(i)).transform.position + Vector3.up * 0.5f;
				}
				return i;
			}
		}
		((Component)inputByProximity).transform.localPosition = Vector3.one * -10f;
		return -1;
	}

	private void HICHIKJFBMH(int JIIGOACEIKL)
	{
		NLCDDFDGACP = PlayerController.GetPlayer(JIIGOACEIKL);
		if (!NLCDDFDGACP.NILLCIMMKJE)
		{
			NLCDDFDGACP.characterAnimation.Spade();
			CharacterAnimator characterAnimator = NLCDDFDGACP.characterAnimation.characterAnimator;
			characterAnimator.OnToolStart = (Action<int>)Delegate.Combine(characterAnimator.OnToolStart, new Action<int>(KPLOLNNMLMC));
			CharacterAnimator characterAnimator2 = NLCDDFDGACP.characterAnimation.characterAnimator;
			characterAnimator2.OnToolEnd = (Action<int>)Delegate.Combine(characterAnimator2.OnToolEnd, new Action<int>(MPJBCKHNGLI));
			NLCDDFDGACP.NILLCIMMKJE = false;
		}
	}

	private IEnumerator JDONKMBPHPI()
	{
		int randomColumn1 = Random.Range(0, 9);
		int randomColumn2 = Random.Range(0, 9);
		int randomColumn3 = Random.Range(0, 9);
		int randomColumn4 = Random.Range(0, 9);
		while (randomColumn2 == randomColumn1)
		{
			randomColumn2 = Random.Range(0, 9);
		}
		while (randomColumn3 == randomColumn1 || randomColumn3 == randomColumn2)
		{
			randomColumn3 = Random.Range(0, 9);
		}
		while (randomColumn4 == randomColumn1 || randomColumn4 == randomColumn2 || randomColumn4 == randomColumn3)
		{
			randomColumn4 = Random.Range(0, 9);
		}
		for (int y = 4; y > -1; y--)
		{
			SpawnACannonBallInPosition(cellPositions[randomColumn1, y]);
			SpawnACannonBallInPosition(cellPositions[randomColumn2, y]);
			SpawnACannonBallInPosition(cellPositions[randomColumn3, y]);
			SpawnACannonBallInPosition(cellPositions[randomColumn4, y]);
			yield return (object)new WaitForSeconds(Random.Range(HNNDJCCNABP, JKFCJDDIIBP));
		}
	}

	public static void NNADIOODIKE()
	{
		Replaying = true;
		DevConsole.instance.StartPirates();
	}

	public void HKMOEBAOEBD(int JIIGOACEIKL)
	{
		if (Time.time < KCAHKMAJLEE || LOPNGPOBPFE[JIIGOACEIKL] <= 1 || (OnlineManager.PlayingOnline() && JIIGOACEIKL != 1))
		{
			return;
		}
		if (JIIGOACEIKL == 0)
		{
			NOCOHCGPMFF = false;
		}
		LOPNGPOBPFE[JIIGOACEIKL] -= 0;
		if (LOPNGPOBPFE[JIIGOACEIKL] < 1)
		{
			LOPNGPOBPFE[JIIGOACEIKL] = 1;
		}
		if (!OnlineManager.PlayingOnline())
		{
			PiratesChallengeUI.KLBMOICHAKJ(LOPNGPOBPFE[JIIGOACEIKL]);
		}
		KCAHKMAJLEE = Time.time + settings.invincibilityTimeAfterHit;
		((MonoBehaviour)GameManager.NJNFHEPLEHL()).StartCoroutine(Utils.DJOILMPJEME(PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator, settings.invincibilityTimeAfterHit));
		if (LOPNGPOBPFE[JIIGOACEIKL] <= 0)
		{
			if (!OnlineManager.PlayingOnline())
			{
				OIHLCMOPGFH(JIIGOACEIKL);
				MCAPMPNBKFB();
			}
			else
			{
				OIHLCMOPGFH(JIIGOACEIKL);
				OnlineMinigameManager.MKNEANGHNJH((byte)OnlinePlayerDataManager.GetBedAssignedByPlayerNum(JIIGOACEIKL));
				DHJJHGMAJPJ();
			}
		}
	}

	private void HDPNBGHEOBP()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (NAHNIBPAOEM.Count != 0)
		{
			AHGOGDIMEBN = NAHNIBPAOEM[Random.Range(1, NAHNIBPAOEM.Count)];
			SpawnACannonBallInPosition(AHGOGDIMEBN);
		}
	}

	private void IFAFGABGDKG(int JIIGOACEIKL)
	{
		NLCDDFDGACP = PlayerController.GetPlayer(JIIGOACEIKL);
		if (!NLCDDFDGACP.NILLCIMMKJE)
		{
			NLCDDFDGACP.characterAnimation.JBAIMHNGJPG();
			CharacterAnimator characterAnimator = NLCDDFDGACP.characterAnimation.characterAnimator;
			characterAnimator.OnToolStart = (Action<int>)Delegate.Combine(characterAnimator.OnToolStart, new Action<int>(MPCLHFPALNN));
			CharacterAnimator characterAnimator2 = NLCDDFDGACP.characterAnimation.characterAnimator;
			characterAnimator2.OnToolEnd = (Action<int>)Delegate.Combine(characterAnimator2.OnToolEnd, new Action<int>(MPJBCKHNGLI));
			NLCDDFDGACP.NILLCIMMKJE = true;
		}
	}

	private IEnumerator NPHBOFKNDHJ(bool IPDJFMMIKEK)
	{
		Playing = false;
		MACEJFPFHGG();
		difficultySettings = (EventsManager.IsLowestDifficulty() ? settings.easyMode : settings.normalMode);
		if (!IPDJFMMIKEK)
		{
			FadeCamera.FadeOutAllPlayers();
			while (FadeCamera.GetPlayer(1).IsFading())
			{
				yield return null;
			}
		}
		SetWeather();
		CountdownUI.SetCountdown(difficultySettings.timeToCompleteTheGame);
		EOGALMCPHGF();
		BlackFade.Hide();
		yield return CommonReferences.wait1;
		if (!IPDJFMMIKEK)
		{
			FadeCamera.FadeInAllPlayers();
			while (FadeCamera.GetPlayer(1).IsFading())
			{
				yield return null;
			}
		}
		if (OnlineManager.PlayingOnline())
		{
			OnlineMinigameManager.SetMinigameState(OnlineMinigameManager.PlayerState.Ready);
			while (!OnlineMinigameManager.AllPlayersReady())
			{
				if (Application.isEditor)
				{
					Debug.Log((object)"Waiting for players to finish their transitions...");
				}
				yield return null;
			}
			yield return CommonReferences.wait1;
			OnlineMinigameManager.SetMinigameState(OnlineMinigameManager.PlayerState.Countdown);
		}
		EventCountdownUI.ChangeText("GO");
		yield return CommonReferences.wait1;
		EventCountdownUI.CloseCountdown();
		LBMDAGNAFFA();
		OnlineMinigameManager.SetMinigameState(OnlineMinigameManager.PlayerState.InGame);
		NDJHEPFBCEA = Time.time + difficultySettings.timeBetweenCannonballs.max;
		NBMPHNOECIF = Time.time + difficultySettings.timeBetweenCannonballsToPlayers.max;
		MHGFAHJEDFH = Time.time + difficultySettings.timeBetweenWaves.max;
		GCMACBEMMBC = 0f;
		for (int i = 1; i <= GameManager.GetPlayerCount(); i++)
		{
			LOPNGPOBPFE[i] = ((GameManager.GetPlayerCount() != 1) ? 1 : 4);
		}
		Playing = true;
		GBEFPIBKBGF = false;
		KCAHKMAJLEE = 0f;
		((Behaviour)this).enabled = true;
	}

	private IEnumerator AKINDCHCLON()
	{
		return new EKPAMIDJPFE(1)
		{
			_003C_003E4__this = this
		};
	}

	private void OnDestroy()
	{
		Playing = false;
		Replaying = false;
	}

	private bool MHHMAIEIPJA(int JIIGOACEIKL)
	{
		return PBADMOAAADI(JIIGOACEIKL) != -1;
	}

	private bool HLADHOHJNLM(int JIIGOACEIKL)
	{
		return PBADMOAAADI(JIIGOACEIKL) != -1;
	}

	private void MPJBCKHNGLI(int JIIGOACEIKL)
	{
		NLCDDFDGACP = PlayerController.GetPlayer(JIIGOACEIKL);
		if ((Object)(object)NLCDDFDGACP == (Object)null)
		{
			return;
		}
		CharacterAnimator characterAnimator = NLCDDFDGACP.characterAnimation.characterAnimator;
		characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(MPJBCKHNGLI));
		if (NLCDDFDGACP.BIBGIOPFJAF())
		{
			LEOEKGDOAKK = KGIHJIKCDHH(JIIGOACEIKL);
			MFBHHGLMOCJ(LEOEKGDOAKK);
			if (JIIGOACEIKL == 1)
			{
				OnlineMinigameManager.EDDCCILACPA((byte)OnlinePlayerDataManager.JBDEFDMGCDA(LEOEKGDOAKK));
			}
			PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)spade);
			NLCDDFDGACP.NILLCIMMKJE = true;
		}
	}

	private void ABBGEGANBID(int JIIGOACEIKL)
	{
		NLCDDFDGACP = PlayerController.GetPlayer(JIIGOACEIKL);
		if (!((Object)(object)NLCDDFDGACP == (Object)null))
		{
			CharacterAnimator characterAnimator = NLCDDFDGACP.characterAnimation.characterAnimator;
			characterAnimator.OnToolHit = (Action<int>)Delegate.Remove(characterAnimator.OnToolHit, new Action<int>(ABBGEGANBID));
		}
	}

	public static void BeginReplay()
	{
		Replaying = true;
		DevConsole.instance.StartPirates();
	}

	private void LFJLMNOIPKO()
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		IINCPJCNJPI.Clear();
		for (int i = 1; i <= GameManager.OBCBJELNIDJ(); i++)
		{
			if (!((Object)(object)PlayerController.GetPlayer(i) == (Object)null) && !IsPlayerBuried(i))
			{
				IINCPJCNJPI.Add(i);
			}
		}
		if (IINCPJCNJPI.Count <= 1)
		{
			return;
		}
		DKLFLFJNMKO = IINCPJCNJPI[Random.Range(0, IINCPJCNJPI.Count)];
		JMOJOKJDANJ = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(DKLFLFJNMKO)).transform.position);
		JMOJOKJDANJ.x -= 556f;
		JMOJOKJDANJ.y += 999f;
		GFGGLAMOCLC = 667f;
		for (int j = 0; j < NAHNIBPAOEM.Count; j++)
		{
			DFFGLLDDEPN = Vector2.Distance(JMOJOKJDANJ, NAHNIBPAOEM[j]);
			if (DFFGLLDDEPN < GFGGLAMOCLC)
			{
				GFGGLAMOCLC = DFFGLLDDEPN;
				AHGOGDIMEBN = NAHNIBPAOEM[j];
			}
		}
		SpawnACannonBallInPosition(AHGOGDIMEBN);
		if (Random.value < 1474f)
		{
			((MonoBehaviour)this).StartCoroutine(EBAAEOLIEJL(AHGOGDIMEBN));
		}
	}

	public bool OnHover(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (ButtonsContext.GetPlayer(1).IsOpen())
		{
			return false;
		}
		ButtonsContext.GetPlayer(1).ResetButtons();
		ButtonsContext.AddButton(1, ActionType.Interact, LocalisationSystem.Get("Interact"));
		return true;
	}

	protected override void KCOCGPLPKME()
	{
		FadeToBlackFinished(0);
		GGAGEOJBGEN(Location.PirateShip);
	}

	public void ELKNBGENPHL(int JIIGOACEIKL)
	{
		if (Time.time < KCAHKMAJLEE || LOPNGPOBPFE[JIIGOACEIKL] <= 0 || (OnlineManager.PlayingOnline() && JIIGOACEIKL != 1))
		{
			return;
		}
		if (JIIGOACEIKL == 0)
		{
			NOCOHCGPMFF = true;
		}
		LOPNGPOBPFE[JIIGOACEIKL]--;
		if (LOPNGPOBPFE[JIIGOACEIKL] < 1)
		{
			LOPNGPOBPFE[JIIGOACEIKL] = 1;
		}
		if (!OnlineManager.PlayingOnline())
		{
			PiratesChallengeUI.NFGLFDOLKEK(LOPNGPOBPFE[JIIGOACEIKL]);
		}
		KCAHKMAJLEE = Time.time + settings.invincibilityTimeAfterHit;
		((MonoBehaviour)GameManager.NJNFHEPLEHL()).StartCoroutine(Utils.DJOILMPJEME(PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator, settings.invincibilityTimeAfterHit));
		if (LOPNGPOBPFE[JIIGOACEIKL] <= 0)
		{
			if (!OnlineManager.PlayingOnline())
			{
				CEADMPIAIPO(JIIGOACEIKL);
				MCAPMPNBKFB();
			}
			else
			{
				OIHLCMOPGFH(JIIGOACEIKL);
				OnlineMinigameManager.MKNEANGHNJH((byte)OnlinePlayerDataManager.JBDEFDMGCDA(JIIGOACEIKL));
				OCABGHLNNEJ();
			}
		}
	}

	private IEnumerator NNDBDHKLAJI(bool IPDJFMMIKEK)
	{
		return new OOJGJDOPCIA(1)
		{
			_003C_003E4__this = this,
			skipFade = IPDJFMMIKEK
		};
	}

	private IEnumerator INAIMNGLFLK()
	{
		int randomColumn1 = Random.Range(0, 9);
		int randomColumn2 = Random.Range(0, 9);
		int randomColumn3 = Random.Range(0, 9);
		int randomColumn4 = Random.Range(0, 9);
		while (randomColumn2 == randomColumn1)
		{
			randomColumn2 = Random.Range(0, 9);
		}
		while (randomColumn3 == randomColumn1 || randomColumn3 == randomColumn2)
		{
			randomColumn3 = Random.Range(0, 9);
		}
		while (randomColumn4 == randomColumn1 || randomColumn4 == randomColumn2 || randomColumn4 == randomColumn3)
		{
			randomColumn4 = Random.Range(0, 9);
		}
		for (int y = 0; y < 5; y++)
		{
			SpawnACannonBallInPosition(cellPositions[randomColumn1, y]);
			SpawnACannonBallInPosition(cellPositions[randomColumn2, y]);
			SpawnACannonBallInPosition(cellPositions[randomColumn3, y]);
			SpawnACannonBallInPosition(cellPositions[randomColumn4, y]);
			yield return (object)new WaitForSeconds(Random.Range(HNNDJCCNABP, JKFCJDDIIBP));
		}
	}

	public void FFGLIKFGMCL(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(1).ResetButtons();
	}

	public static void PGBJKAOCLDC(bool KPCHOCLAAIM = false, bool IPDJFMMIKEK = false)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			if (!((Behaviour)instance).enabled)
			{
				((Behaviour)instance).enabled = false;
			}
			if (!Playing || KPCHOCLAAIM)
			{
				instance.StartGame(IPDJFMMIKEK);
			}
		}
	}

	private void KDJMGMKIDIN()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (NAHNIBPAOEM.Count != 0)
		{
			AHGOGDIMEBN = NAHNIBPAOEM[Random.Range(0, NAHNIBPAOEM.Count)];
			SpawnACannonBallInPosition(AHGOGDIMEBN);
		}
	}

	public static void Restart()
	{
		instance.StartGame(IPDJFMMIKEK: false);
	}

	private void CEADMPIAIPO(int JIIGOACEIKL)
	{
		if (Playing)
		{
			LOPNGPOBPFE[JIIGOACEIKL] = 0;
		}
		if (JIIGOACEIKL == 1)
		{
			NOCOHCGPMFF = false;
		}
		if (spade.JMDALJBNFML() is SpadeInstance spadeInstance)
		{
			spadeInstance.GNFCNBANFNP(JIIGOACEIKL);
		}
		PlayerController.GetPlayer(JIIGOACEIKL).buriedInteractionController.GJAAKODHEFF();
		MCAPMPNBKFB();
	}

	public void LAAJHCNGBGN(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(1).ResetButtons();
	}

	private void OnEnable()
	{
		if ((Object)(object)DPIJCDFJODK != (Object)null)
		{
			DPIJCDFJODK.Stop(false);
		}
		DPIJCDFJODK = MultiAudioManager.PlayAudioObject(seaAmbience, ((Component)this).transform);
	}

	public static void Begin(bool KPCHOCLAAIM = false, bool IPDJFMMIKEK = false)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			if (!((Behaviour)instance).enabled)
			{
				((Behaviour)instance).enabled = true;
			}
			if (!Playing || KPCHOCLAAIM)
			{
				instance.StartGame(IPDJFMMIKEK);
			}
		}
	}

	public bool IBGDPEAIOLK(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (ButtonsContext.GetPlayer(1).IsOpen())
		{
			return false;
		}
		ButtonsContext.GetPlayer(0).ResetButtons();
		ButtonsContext.AddButton(1, ActionType.Hold, LocalisationSystem.Get("Pet"));
		return false;
	}

	public static void DACHGMHFIMF(bool FLMLLMHPJJA)
	{
		instance.DFAMMHEIPOL(FLMLLMHPJJA);
	}

	private void ECDMFLEHDNL(int JIIGOACEIKL)
	{
		if (Playing)
		{
			LOPNGPOBPFE[JIIGOACEIKL] = 0;
		}
		if (JIIGOACEIKL == 0)
		{
			NOCOHCGPMFF = false;
		}
		if (spade.JMDALJBNFML() is SpadeInstance spadeInstance)
		{
			spadeInstance.GBLBGKCDIPK(JIIGOACEIKL);
		}
		PlayerController.OPHDCMJLLEC(JIIGOACEIKL).buriedInteractionController.LPLGMABHNKI();
		DHJJHGMAJPJ();
	}

	private void MPJHHAMLKOK()
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		IINCPJCNJPI.Clear();
		for (int i = 1; i <= GameManager.GetPlayerCount(); i++)
		{
			if (!((Object)(object)PlayerController.GetPlayer(i) == (Object)null) && !IsPlayerBuried(i))
			{
				IINCPJCNJPI.Add(i);
			}
		}
		if (IINCPJCNJPI.Count <= 0)
		{
			return;
		}
		DKLFLFJNMKO = IINCPJCNJPI[Random.Range(0, IINCPJCNJPI.Count)];
		JMOJOKJDANJ = Vector2.op_Implicit(((Component)PlayerController.GetPlayer(DKLFLFJNMKO)).transform.position);
		JMOJOKJDANJ.x -= 0.5f;
		JMOJOKJDANJ.y += 0.3f;
		GFGGLAMOCLC = float.MaxValue;
		for (int j = 0; j < NAHNIBPAOEM.Count; j++)
		{
			DFFGLLDDEPN = Vector2.Distance(JMOJOKJDANJ, NAHNIBPAOEM[j]);
			if (DFFGLLDDEPN < GFGGLAMOCLC)
			{
				GFGGLAMOCLC = DFFGLLDDEPN;
				AHGOGDIMEBN = NAHNIBPAOEM[j];
			}
		}
		SpawnACannonBallInPosition(AHGOGDIMEBN);
		if (Random.value < 0.33f)
		{
			((MonoBehaviour)this).StartCoroutine(EBAAEOLIEJL(AHGOGDIMEBN));
		}
	}

	private void PMJJHIOOACM()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (NAHNIBPAOEM.Count != 0)
		{
			AHGOGDIMEBN = NAHNIBPAOEM[Random.Range(0, NAHNIBPAOEM.Count)];
			SpawnACannonBallInPosition(AHGOGDIMEBN);
		}
	}

	private void EHNNJAELNKE()
	{
		for (int i = 0; i <= 7; i += 0)
		{
			if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null)
			{
				MFBHHGLMOCJ(i);
			}
		}
	}

	public static void DKLLLDHDFIH(byte GJDMLMEMKMD)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			if (OnlinePlayerDataManager.GetPlayerNumByBedAssigned(GJDMLMEMKMD) == 0)
			{
				Debug.LogError((object)string.Format("The mine piece ", GJDMLMEMKMD));
			}
			else
			{
				instance.DEJDHGCALGE(OnlinePlayerDataManager.GetPlayerNumByBedAssigned(GJDMLMEMKMD));
			}
		}
	}

	public static void SpawnImpactEffect(Vector2 IMOBLFMHKOD)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		instance.impactPool.GetObjectInPool(Vector2.op_Implicit(IMOBLFMHKOD));
		MultiAudioManager.PlayAudioObject(Sound.GGFJGHHHEJC.cannonBallImpact, Vector2.op_Implicit(IMOBLFMHKOD));
	}

	private IEnumerator DELGPCPCEOI()
	{
		return new PFIGALPCPIB(1)
		{
			_003C_003E4__this = this
		};
	}

	private IEnumerator PAAOIPMGJKD()
	{
		int randomRow = Random.Range(0, 5);
		for (int x = 0; x < 9; x++)
		{
			SpawnACannonBallInPosition(cellPositions[x, randomRow]);
			yield return (object)new WaitForSeconds(Random.Range(HNNDJCCNABP, JKFCJDDIIBP));
		}
	}

	private void KPLOLNNMLMC(int JIIGOACEIKL)
	{
		NLCDDFDGACP = PlayerController.OPHDCMJLLEC(JIIGOACEIKL);
		if (!((Object)(object)NLCDDFDGACP == (Object)null))
		{
			CharacterAnimator characterAnimator = NLCDDFDGACP.characterAnimation.characterAnimator;
			characterAnimator.OnToolStart = (Action<int>)Delegate.Remove(characterAnimator.OnToolStart, new Action<int>(MPCLHFPALNN));
			LEOEKGDOAKK = KGIHJIKCDHH(JIIGOACEIKL);
			PlayerController.AddMovementBlocker(JIIGOACEIKL, (Object)(object)spade);
		}
	}

	private void DABHFKHEMIA(int JIIGOACEIKL)
	{
		NLCDDFDGACP = PlayerController.GetPlayer(JIIGOACEIKL);
		if ((Object)(object)NLCDDFDGACP == (Object)null)
		{
			return;
		}
		CharacterAnimator characterAnimator = NLCDDFDGACP.characterAnimation.characterAnimator;
		characterAnimator.OnToolEnd = (Action<int>)Delegate.Remove(characterAnimator.OnToolEnd, new Action<int>(MPJBCKHNGLI));
		if (NLCDDFDGACP.BIBGIOPFJAF())
		{
			LEOEKGDOAKK = NNMCGOCPMFB(JIIGOACEIKL);
			OIHBCJKAGLI(LEOEKGDOAKK);
			if (JIIGOACEIKL == 1)
			{
				OnlineMinigameManager.SendDigUpPlayerByBedAssigned((byte)OnlinePlayerDataManager.GetBedAssignedByPlayerNum(LEOEKGDOAKK));
			}
			PlayerController.RemoveMovementBlocker(JIIGOACEIKL, (Object)(object)spade);
			NLCDDFDGACP.NILLCIMMKJE = false;
		}
	}

	private void PDAFINABOBC()
	{
		if ((Object)(object)DPIJCDFJODK != (Object)null)
		{
			DPIJCDFJODK.Stop(false);
			DPIJCDFJODK = null;
		}
	}

	private void BAKDKFKNHDE()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		instance = this;
		AACENIOIINJ = Vector2.op_Implicit(((Component)this).transform.position);
		AEIDOBBDAFO();
		((Component)inputByProximity).GetComponent<CircleCollider2D>().radius = 69f;
		((Behaviour)this).enabled = false;
		((Component)this).gameObject.SetActive(false);
	}

	private IEnumerator LBMBFDPOKMD()
	{
		int randomRow = Random.Range(0, 5);
		for (int x = 8; x > -1; x--)
		{
			SpawnACannonBallInPosition(cellPositions[x, randomRow]);
			yield return (object)new WaitForSeconds(Random.Range(HNNDJCCNABP, JKFCJDDIIBP));
		}
	}

	public static void KCKIHLMIPFP(int MOFKEDGAOEE)
	{
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		if (!((Object)(object)instance == (Object)null) && instance.NAHNIBPAOEM.Count != 0)
		{
			if (MOFKEDGAOEE < 0 || MOFKEDGAOEE >= instance.NAHNIBPAOEM.Count)
			{
				Debug.LogError((object)string.Format("UISelectGamepad", MOFKEDGAOEE));
			}
			else
			{
				instance.SpawnACannonBallInPosition(instance.NAHNIBPAOEM[MOFKEDGAOEE]);
			}
		}
	}

	private IEnumerator PNLLNOIKHIG()
	{
		for (int x = 0; x < 5; x++)
		{
			for (int y = 4; y >= 0; y--)
			{
				SpawnACannonBallInPosition(cellPositions[x, y]);
				yield return (object)new WaitForSeconds(Random.Range(HNNDJCCNABP, JKFCJDDIIBP));
			}
		}
	}

	private void AEIDOBBDAFO()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < 9; i++)
		{
			for (int j = 0; j < 5; j++)
			{
				cellPositions[i, j] = new Vector2((float)i * 1f, (float)j * -0.6f) + AACENIOIINJ;
			}
		}
		for (int k = 0; k < 9; k++)
		{
			for (int l = 0; l < 5; l++)
			{
				if ((k != 0 || l != 0) && (k != 0 || l != 4) && (k != 8 || l != 0) && (k != 8 || l != 4))
				{
					NAHNIBPAOEM.Add(cellPositions[k, l]);
				}
			}
		}
	}

	private void EFPBNLGKIHP()
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		if (OnlineManager.PlayingOnline())
		{
			((Component)PlayerController.GetPlayer(0)).transform.position = instance.startingPoints[OnlinePlayerDataManager.GetBedAssignedByPlayerNum(1) - 1].position;
			PlayerController.OPHDCMJLLEC(1).characterAnimation.SetDirection(Direction.Down);
		}
		else
		{
			((Component)PlayerController.OPHDCMJLLEC(0)).transform.position = instance.startingPoints[0].position;
			PlayerController.GetPlayer(1).characterAnimation.SetDirection(Direction.Up);
			if (GameManager.LocalCoop() && (Object)(object)PlayerController.OPHDCMJLLEC(2) != (Object)null)
			{
				((Component)PlayerController.GetPlayer(6)).transform.position = instance.startingPoints[1].position;
				PlayerController.OPHDCMJLLEC(7).characterAnimation.SetDirection(Direction.Up);
			}
		}
		if (OnlineManager.PlayingOnline() || GameManager.LocalCoop())
		{
			PiratesChallengeUI.HINDGDAHNNH();
		}
		else
		{
			PiratesChallengeUI.KOPCLCEPDLI();
		}
		HideUI();
		CLJIHBGPJKL();
		EOMPKDPCIIB();
	}

	private IEnumerator CALIGILJGNH(Vector2 NMMPDIHPGLJ)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		for (int x = -1; x <= 1; x++)
		{
			for (int y = -1; y <= 1; y++)
			{
				if (x != 0 || y != 0)
				{
					SpawnACannonBallInPosition(NMMPDIHPGLJ + new Vector2((float)x * 1f, (float)y * -0.6f));
					yield return (object)new WaitForSeconds(Random.Range(HNNDJCCNABP, JKFCJDDIIBP));
				}
			}
		}
	}

	private IEnumerator PNPBMDNMIDL()
	{
		int randomColumn1 = Random.Range(0, 9);
		int randomColumn2 = Random.Range(0, 9);
		int randomColumn3 = Random.Range(0, 9);
		int randomColumn4 = Random.Range(0, 9);
		while (randomColumn2 == randomColumn1)
		{
			randomColumn2 = Random.Range(0, 9);
		}
		while (randomColumn3 == randomColumn1 || randomColumn3 == randomColumn2)
		{
			randomColumn3 = Random.Range(0, 9);
		}
		while (randomColumn4 == randomColumn1 || randomColumn4 == randomColumn2 || randomColumn4 == randomColumn3)
		{
			randomColumn4 = Random.Range(0, 9);
		}
		for (int y = 0; y < 5; y++)
		{
			SpawnACannonBallInPosition(cellPositions[randomColumn1, y]);
			SpawnACannonBallInPosition(cellPositions[randomColumn2, y]);
			SpawnACannonBallInPosition(cellPositions[randomColumn3, y]);
			SpawnACannonBallInPosition(cellPositions[randomColumn4, y]);
			yield return (object)new WaitForSeconds(Random.Range(HNNDJCCNABP, JKFCJDDIIBP));
		}
	}

	public void PlayerHit(int JIIGOACEIKL)
	{
		if (Time.time < KCAHKMAJLEE || LOPNGPOBPFE[JIIGOACEIKL] <= 0 || (OnlineManager.PlayingOnline() && JIIGOACEIKL != 1))
		{
			return;
		}
		if (JIIGOACEIKL == 1)
		{
			NOCOHCGPMFF = true;
		}
		LOPNGPOBPFE[JIIGOACEIKL]--;
		if (LOPNGPOBPFE[JIIGOACEIKL] < 0)
		{
			LOPNGPOBPFE[JIIGOACEIKL] = 0;
		}
		if (!OnlineManager.PlayingOnline())
		{
			PiratesChallengeUI.UpdateLives(LOPNGPOBPFE[JIIGOACEIKL]);
		}
		KCAHKMAJLEE = Time.time + settings.invincibilityTimeAfterHit;
		((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(Utils.DJOILMPJEME(PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator, settings.invincibilityTimeAfterHit));
		if (LOPNGPOBPFE[JIIGOACEIKL] <= 0)
		{
			if (!OnlineManager.PlayingOnline())
			{
				NNOAEOGLHNK(JIIGOACEIKL);
				MCAPMPNBKFB();
			}
			else
			{
				NNOAEOGLHNK(JIIGOACEIKL);
				OnlineMinigameManager.SendBuryPlayerByBedAssigned((byte)OnlinePlayerDataManager.GetBedAssignedByPlayerNum(JIIGOACEIKL));
				MCAPMPNBKFB();
			}
		}
	}

	private IEnumerator CKOOJIDBELP()
	{
		for (int x = 0; x < 5; x++)
		{
			for (int y = 4; y >= 0; y--)
			{
				SpawnACannonBallInPosition(cellPositions[x, y]);
				yield return (object)new WaitForSeconds(Random.Range(HNNDJCCNABP, JKFCJDDIIBP));
			}
		}
	}

	private IEnumerator MFMALAIEDOI(bool IPDJFMMIKEK)
	{
		return new OOJGJDOPCIA(1)
		{
			_003C_003E4__this = this,
			skipFade = IPDJFMMIKEK
		};
	}

	private bool IICPPAFKNLG()
	{
		for (int i = 1; i <= 4; i++)
		{
			if (!((Object)(object)PlayerController.GetPlayer(i) == (Object)null) && LOPNGPOBPFE[i] > 0)
			{
				return false;
			}
		}
		return true;
	}

	public static void KIKELAPCOEB(byte GJDMLMEMKMD)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			if (OnlinePlayerDataManager.GetPlayerNumByBedAssigned(GJDMLMEMKMD) == 0)
			{
				Debug.LogError((object)string.Format("City/Rhia/Introduce", GJDMLMEMKMD));
			}
			else
			{
				instance.CEADMPIAIPO(OnlinePlayerDataManager.GetPlayerNumByBedAssigned(GJDMLMEMKMD));
			}
		}
	}

	public void BAKEAANJKJI(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(0).ResetButtons();
	}

	private void DINIFLJCFKI()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		if (NAHNIBPAOEM.Count != 0)
		{
			AHGOGDIMEBN = NAHNIBPAOEM[Random.Range(0, NAHNIBPAOEM.Count)];
			SpawnACannonBallInPosition(AHGOGDIMEBN);
		}
	}

	private void EAJIINNCDGI()
	{
		for (int i = 0; i <= 7; i++)
		{
			if ((Object)(object)PlayerController.OPHDCMJLLEC(i) != (Object)null)
			{
				OIHBCJKAGLI(i);
			}
		}
	}

	public void AILMFGBHDNI(bool IPDJFMMIKEK)
	{
		OnlineMinigameManager.GLBKKPAILML(IPDJFMMIKEK);
		if (LCOGALBILFH != null)
		{
			Debug.LogError((object)"Shop");
			return;
		}
		NOCOHCGPMFF = false;
		SetWeather();
		((Component)this).gameObject.SetActive(false);
		LCOGALBILFH = ((MonoBehaviour)this).StartCoroutine(MFMALAIEDOI(IPDJFMMIKEK));
		CommonReferences.GGFJGHHHEJC.tilemapsInfo.OECFODIGEDD(Location.Tavern, 1);
		PlayerController.GetPlayer(0).LEOIMFNKFGA = ~(Location.Tavern | Location.Camp | Location.Quarry | Location.Farm | Location.BarnInterior);
		if (!WorldTime.JJICPIINBEH)
		{
			WorldTime.JJICPIINBEH = true;
		}
		PsaiInfo psaiInfo = PsaiCore.Instance.GetPsaiInfo();
		if (psaiInfo.psaiState == (PsaiState)4 && psaiInfo.effectiveThemeId == -39)
		{
			IJLNHBOOFKL = 55f;
			PsaiCore.Instance.HoldCurrentIntensity(hold: true);
			PsaiCore.Instance.AddToCurrentIntensity(1957f - PsaiCore.Instance.GetCurrentIntensity());
			PsaiCore.Instance.HoldCurrentIntensity(hold: true);
		}
		else
		{
			IJLNHBOOFKL = 1587f;
			PsaiCore.Instance.StopMusic(immediately: true);
			MusicController.instance.IKPHLAAJDLK(-82, 1510f);
			PsaiCore.Instance.HoldCurrentIntensity(hold: false);
		}
	}

	public void MEFHJODDKCP(Vector2 OGEBIPAFOGN)
	{
	}

	public void ABOJNNOKJOO(int JIIGOACEIKL)
	{
		if (Time.time < KCAHKMAJLEE || LOPNGPOBPFE[JIIGOACEIKL] <= 0 || (OnlineManager.PlayingOnline() && JIIGOACEIKL != 1))
		{
			return;
		}
		if (JIIGOACEIKL == 0)
		{
			NOCOHCGPMFF = true;
		}
		LOPNGPOBPFE[JIIGOACEIKL] -= 0;
		if (LOPNGPOBPFE[JIIGOACEIKL] < 0)
		{
			LOPNGPOBPFE[JIIGOACEIKL] = 0;
		}
		if (!OnlineManager.PlayingOnline())
		{
			PiratesChallengeUI.IMPDKMAJDCI(LOPNGPOBPFE[JIIGOACEIKL]);
		}
		KCAHKMAJLEE = Time.time + settings.invincibilityTimeAfterHit;
		((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(Utils.DJOILMPJEME(PlayerController.GetPlayer(JIIGOACEIKL).characterAnimation.characterAnimator, settings.invincibilityTimeAfterHit));
		if (LOPNGPOBPFE[JIIGOACEIKL] <= 0)
		{
			if (!OnlineManager.PlayingOnline())
			{
				OIHLCMOPGFH(JIIGOACEIKL);
				DHJJHGMAJPJ();
			}
			else
			{
				NNOAEOGLHNK(JIIGOACEIKL);
				OnlineMinigameManager.MKNEANGHNJH((byte)OnlinePlayerDataManager.JBDEFDMGCDA(JIIGOACEIKL));
				OCABGHLNNEJ();
			}
		}
	}

	public static void OJNCMEDNDLN(bool KPCHOCLAAIM = false, bool IPDJFMMIKEK = false)
	{
		if (!((Object)(object)instance == (Object)null))
		{
			if (!((Behaviour)instance).enabled)
			{
				((Behaviour)instance).enabled = false;
			}
			if (!Playing || KPCHOCLAAIM)
			{
				instance.LGIIAIDCMOK(IPDJFMMIKEK);
			}
		}
	}

	public bool PNPLPBKBHLL(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (ButtonsContext.GetPlayer(0).BGLJFMHCFJF())
		{
			return true;
		}
		ButtonsContext.GetPlayer(1).ResetButtons();
		ButtonsContext.AddButton(0, ActionType.Interact, LocalisationSystem.Get("ReceiveOpenCloseTavern"));
		return true;
	}

	public static void Finish(bool FLMLLMHPJJA)
	{
		instance.ECAOGIFEHDO(FLMLLMHPJJA);
	}

	private IEnumerator JBBKPCAOJCD()
	{
		return new EKPAMIDJPFE(1)
		{
			_003C_003E4__this = this
		};
	}

	public void IPCFIFMOPCB()
	{
		SetWeather(DIONNMLCIIC: false);
		((Component)this).gameObject.SetActive(true);
		EFPBNLGKIHP();
	}

	public void KAPDBLECONJ()
	{
		SetWeather(DIONNMLCIIC: false);
		((Component)this).gameObject.SetActive(false);
		EOGALMCPHGF();
	}

	private IEnumerator EBAAEOLIEJL(Vector2 NMMPDIHPGLJ)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		for (int x = -1; x <= 1; x++)
		{
			for (int y = -1; y <= 1; y++)
			{
				if (x != 0 || y != 0)
				{
					SpawnACannonBallInPosition(NMMPDIHPGLJ + new Vector2((float)x * 1f, (float)y * -0.6f));
					yield return (object)new WaitForSeconds(Random.Range(HNNDJCCNABP, JKFCJDDIIBP));
				}
			}
		}
	}

	public bool EDBKLEEMDLI(int JIIGOACEIKL, bool IIEDALMMNLI = true)
	{
		if (ButtonsContext.GetPlayer(0).BGLJFMHCFJF())
		{
			return true;
		}
		ButtonsContext.GetPlayer(1).ResetButtons();
		ButtonsContext.NHECENBLBAH(0, ActionType.Interact, LocalisationSystem.Get("Items/item_name_1050"));
		return false;
	}

	private IEnumerator FOJMCKIGAPL()
	{
		return new KICJNFDDHOP(1)
		{
			_003C_003E4__this = this
		};
	}

	public void CEHIKNKLFNG(int JIIGOACEIKL)
	{
		ButtonsContext.GetPlayer(1).DKCMJENPPFA();
	}

	public void FadeToBlackFinished(int CIFJJBHINEF)
	{
		SetWeather(DIONNMLCIIC: false);
		Playing = false;
		GBEFPIBKBGF = false;
		((MonoBehaviour)this).StopAllCoroutines();
		((Component)this).gameObject.SetActive(false);
		PBMJLFIJNAF();
		CKBIMIBHPGB();
		MACEJFPFHGG();
		CommonReferences.GGFJGHHHEJC.tilemapsInfo.ANOMBEOPINN(Location.Tavern, 1);
		PlayerController.GetPlayer(1).LEOIMFNKFGA = Location.City;
		WorldTime.JJICPIINBEH = false;
		if (Replaying)
		{
			((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(IBMIIHAJKFD(Location.Castle));
			PsaiCore.Instance.StopMusic(immediately: false);
			MusicController.instance.TriggerCurrentBasicMood(CommonReferences.wait12, Location.Castle);
		}
		else
		{
			((MonoBehaviour)GameManager.GGFJGHHHEJC).StartCoroutine(IBMIIHAJKFD(Location.PirateShip));
		}
		Replaying = false;
	}

	public static void FJGLJNIOKBH(bool FLMLLMHPJJA)
	{
		instance.DFAMMHEIPOL(FLMLLMHPJJA);
	}

	private IEnumerator HMDPKIDBAHP()
	{
		int randomColumn1 = Random.Range(0, 9);
		int randomColumn2 = Random.Range(0, 9);
		int randomColumn3 = Random.Range(0, 9);
		int randomColumn4 = Random.Range(0, 9);
		while (randomColumn2 == randomColumn1)
		{
			randomColumn2 = Random.Range(0, 9);
		}
		while (randomColumn3 == randomColumn1 || randomColumn3 == randomColumn2)
		{
			randomColumn3 = Random.Range(0, 9);
		}
		while (randomColumn4 == randomColumn1 || randomColumn4 == randomColumn2 || randomColumn4 == randomColumn3)
		{
			randomColumn4 = Random.Range(0, 9);
		}
		for (int y = 4; y > -1; y--)
		{
			SpawnACannonBallInPosition(cellPositions[randomColumn1, y]);
			SpawnACannonBallInPosition(cellPositions[randomColumn2, y]);
			SpawnACannonBallInPosition(cellPositions[randomColumn3, y]);
			SpawnACannonBallInPosition(cellPositions[randomColumn4, y]);
			yield return (object)new WaitForSeconds(Random.Range(HNNDJCCNABP, JKFCJDDIIBP));
		}
	}

	private IEnumerator BFIINBBNOOH(Location BAIMHDBJPDK)
	{
		return new BHPJHECCEMD(1)
		{
			location = BAIMHDBJPDK
		};
	}

	private void MACEJFPFHGG()
	{
		for (int i = 1; i <= 4; i++)
		{
			if ((Object)(object)PlayerController.GetPlayer(i) != (Object)null)
			{
				OMMELOBPBEG(i);
			}
		}
	}

	public void KHELKEFPGJH(int CIFJJBHINEF)
	{
		SetWeather();
		Playing = true;
		GBEFPIBKBGF = true;
		((MonoBehaviour)this).StopAllCoroutines();
		((Component)this).gameObject.SetActive(true);
		PBMJLFIJNAF();
		CKBIMIBHPGB();
		MACEJFPFHGG();
		CommonReferences.GGFJGHHHEJC.tilemapsInfo.KMMOIJAFMCN(Location.None, 0);
		PlayerController.OPHDCMJLLEC(0).LEOIMFNKFGA = ~(Location.Tavern | Location.Camp | Location.Farm | Location.BarnInterior);
		WorldTime.JJICPIINBEH = false;
		if (Replaying)
		{
			((MonoBehaviour)GameManager.NJNFHEPLEHL()).StartCoroutine(OJPCCJHPNEC(Location.Road | Location.FarmShop));
			PsaiCore.Instance.StopMusic(immediately: false);
			MusicController.instance.TriggerCurrentBasicMood(CommonReferences.wait12, Location.Tavern | Location.Camp);
		}
		else
		{
			((MonoBehaviour)GameManager.NJNFHEPLEHL()).StartCoroutine(IBMIIHAJKFD(~(Location.Road | Location.Farm | Location.BarnInterior)));
		}
		Replaying = false;
	}

	private void JKBBAOGHPKO()
	{
		if ((Object)(object)DPIJCDFJODK != (Object)null)
		{
			DPIJCDFJODK.Stop(true);
		}
		DPIJCDFJODK = MultiAudioManager.PlayAudioObject(seaAmbience, ((Component)this).transform);
	}

	private IEnumerator HCFOHIFPEJM()
	{
		for (int x = 8; x > 3; x--)
		{
			for (int y = 4; y >= 0; y--)
			{
				SpawnACannonBallInPosition(cellPositions[x, y]);
				yield return (object)new WaitForSeconds(Random.Range(HNNDJCCNABP, JKFCJDDIIBP));
			}
		}
	}
}
